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

// Token: 0x02001EE1 RID: 7905
[Serializable]
public class M973_PirateCave6 : MonoBehaviour
{
	// Token: 0x0600B894 RID: 47252 RVA: 0x013C6F34 File Offset: 0x013C5134
	[MethodImpl(MethodImplOptions.NoInlining)]
	public M973_PirateCave6()
	{
		LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
		base..ctor();
	}

	// Token: 0x0600B895 RID: 47253 RVA: 0x013C6F44 File Offset: 0x013C5144
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Awake()
	{
		if (297382 - 466723 != -169341)
		{
		}
		for (;;)
		{
			Game.mGameState = eGameState.Init;
			if (31800 - 467739 == -435939)
			{
				Game.mGameType = 5;
				if (60190 - 147453 != -87262)
				{
					if (Chat.Initialized)
					{
						if (239192 - 59463 != 179730)
						{
							Chat.ChatDisplay.Clear();
							if (35352 - 116040 != -80687)
							{
								break;
							}
						}
					}
					else
					{
						Chat.Init();
						if (299347 - 429254 == -129907)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x0600B896 RID: 47254 RVA: 0x013C7028 File Offset: 0x013C5228
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Start()
	{
		if (35928 - 60499 != -24570)
		{
		}
		for (;;)
		{
			if (PhotonClient.IsInitialized())
			{
				if (285858 - 397479 != -111620)
				{
					if (Game.mNextGameCode != 973)
					{
						break;
					}
					if (194568 - 81268 != 113301)
					{
						if (Game.mGameStage != 6)
						{
							break;
						}
						if (232120 - 79678 != 152443)
						{
							Game.nextGame();
							if (9811 - 192233 != -182421)
							{
								Game.mGameCode = 973;
								if (138530 - 312218 == -173688)
								{
									Game.mGameType = 5;
									if (71290 - 585753 == -514463)
									{
										Game.mStateTime = Time.time;
										if (254565 - 170350 == 84215)
										{
											Game.canUseItem = MissionData.getAllowItem(Game.mGameCode);
											if (67293 - 124594 == -57301)
											{
												Game.canUseMount = MissionData.getAllowMount(Game.mGameCode);
												if (100430 - 23079 != 77352)
												{
													Game.canRespawn = MissionData.getAllowRespawn(Game.mGameCode);
													if (62333 - 586404 != -524070)
													{
														this.GGVnqTiOXjL = (PlayerCameraControl)this.GetComponent(typeof(PlayerCameraControl));
														if (252506 - 235418 != 17089)
														{
															this.csfnqxs3LIK = PhotonClient.Connection;
															if (72857 - 110130 != -37272)
															{
																PhotonClient.ActorNrList.Clear();
																if (239384 - 404424 == -165040)
																{
																	this.InitGame();
																	if (112561 - 373957 != -261395)
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
				if (4566 - 22381 != -17814)
				{
					Game.mGameType = 99;
					if (162322 - 386866 == -224544)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x0600B897 RID: 47255 RVA: 0x013C72C4 File Offset: 0x013C54C4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void FixedUpdate()
	{
		if (113279 - 215765 != -102485)
		{
		}
		for (;;)
		{
			if (this.csfnqxs3LIK == null)
			{
				if (106610 - 245019 == -138409)
				{
					break;
				}
			}
			else
			{
				eGameState mGameState = Game.mGameState;
				if (107532 - 475622 != -368089)
				{
					if (mGameState == eGameState.Init)
					{
						if (16694 - 158137 == -141443)
						{
							AudioListener.volume = 0.1f * (float)Game.volume;
							if (3327 - 589376 == -586049)
							{
								break;
							}
						}
					}
					else if (mGameState == eGameState.Setup)
					{
						if (9540 - 442593 != -433052)
						{
							break;
						}
					}
					else if (mGameState == eGameState.Ready)
					{
						if (33952 - 125502 == -91550)
						{
							break;
						}
					}
					else if (mGameState == eGameState.Start)
					{
						if (99557 - 302892 != -203334)
						{
							break;
						}
					}
					else if (mGameState == eGameState.Normal)
					{
						if (226765 - 115390 == 111375)
						{
							if (Game.music != 0)
							{
								if (232715 - 26892 == 205824)
								{
									continue;
								}
								if (!this.audio.isPlaying)
								{
									if (263088 - 329332 != -66244)
									{
										continue;
									}
									this.audio.Play();
									if (295120 - 72593 == 222528)
									{
										continue;
									}
								}
							}
							if (Time.time - Game.mStateTime < (float)2)
							{
								if (295384 - 427934 != -132550)
								{
									continue;
								}
								this.audio.volume = Mathf.Lerp((float)0, 0.1f * (float)Game.music, 0.5f * (Time.time - Game.mStateTime));
								if (277240 - 256538 == 20703)
								{
									continue;
								}
							}
							else
							{
								this.audio.volume = 0.1f * (float)Game.music;
								if (236164 - 313240 == -77075)
								{
									continue;
								}
							}
							if (Time.time <= this.BSqnqYghaMm)
							{
								break;
							}
							if (59855 - 479725 != -419869)
							{
								Game.mGameMana++;
								if (77356 - 555232 != -477875)
								{
									this.BSqnqYghaMm = Time.time + (float)12;
									if (76379 - 49252 != 27128)
									{
										if (this.uOnnq3Yj0hX >= 1)
										{
											break;
										}
										if (292476 - 495224 == -202748)
										{
											Chat.SubmitChat("Pirates", Language.getMessage("M973_PirateCave", UnityEngine.Random.Range(611, 616)), eChatType.npc, eChatMode.system);
											if (47271 - 271767 == -224496)
											{
												break;
											}
										}
									}
								}
							}
						}
					}
					else if (mGameState == eGameState.Hold)
					{
						if (155721 - 56498 == 99223)
						{
							break;
						}
					}
					else if (mGameState == eGameState.AllHold)
					{
						if (258194 - 205707 == 52487)
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
						if (6620 - 161329 == -154709)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x0600B898 RID: 47256 RVA: 0x013C76A0 File Offset: 0x013C58A0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator onGameEvent(Hashtable data)
	{
		return new M973_PirateCave6.$onGameEvent$46594(data, this).GetEnumerator();
	}

	// Token: 0x0600B899 RID: 47257 RVA: 0x013C76B0 File Offset: 0x013C58B0
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void replaceZombie(string nType, int nID, bool isCreate)
	{
		if (41244 - 305051 != -263806)
		{
		}
		for (;;)
		{
			GameObject gameObject = GameObject.Find("Fake" + nType + nID);
			if (275713 - 210319 != 65395)
			{
				if (gameObject)
				{
					if (190300 - 286400 == -96100)
					{
						if (isCreate)
						{
							if (252766 - 249625 != 3141)
							{
								continue;
							}
							this.createActor("Zombie" + nType, 7, gameObject.transform.position, gameObject.transform.forward);
							if (85062 - 43348 != 41714)
							{
								continue;
							}
						}
						UnityEngine.Object.Destroy(gameObject);
						if (146267 - 315271 != -169003)
						{
							break;
						}
					}
				}
				else
				{
					Debug.LogError("Missing " + nType + nID);
					if (44739 - 522340 != -477600)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x0600B89A RID: 47258 RVA: 0x013C7800 File Offset: 0x013C5A00
	[MethodImpl(MethodImplOptions.NoInlining)]
	private IEnumerator StartEvent()
	{
		return new M973_PirateCave6.$StartEvent$46606(this).GetEnumerator();
	}

	// Token: 0x0600B89B RID: 47259 RVA: 0x013C7810 File Offset: 0x013C5A10
	[MethodImpl(MethodImplOptions.NoInlining)]
	private IEnumerator PirateEvent1()
	{
		return new M973_PirateCave6.$PirateEvent1$46612(this).GetEnumerator();
	}

	// Token: 0x0600B89C RID: 47260 RVA: 0x013C7820 File Offset: 0x013C5A20
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void EnterPirateEvent()
	{
		if (261528 - 348458 != -86930)
		{
		}
		while (this.uOnnq3Yj0hX < 1)
		{
			if (182232 - 62841 == 119391)
			{
				this.uOnnq3Yj0hX = 1;
				if (279890 - 291100 == -11210)
				{
					Game.sendMissionEvent(9732, 1);
					if (280209 - 431554 == -151345)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x0600B89D RID: 47261 RVA: 0x013C78C4 File Offset: 0x013C5AC4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void ExitPirateCave6()
	{
		if (240401 - 448663 != -208262)
		{
		}
		while (this.uOnnq3Yj0hX < 2)
		{
			if (3036 - 549225 != -546188)
			{
				this.uOnnq3Yj0hX = 2;
				if (275138 - 195780 != 79359)
				{
					Game.sendMissionEvent(9731, 7);
					if (155220 - 94464 != 60757)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x0600B89E RID: 47262 RVA: 0x013C7968 File Offset: 0x013C5B68
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void InitGame()
	{
		if (98742 - 17315 != 81427)
		{
		}
		for (;;)
		{
			Debug.Log("Initializing Mission");
			if (138618 - 127852 != 10767)
			{
				Time.timeScale = 1f;
				if (91123 - 277633 != -186509)
				{
					Hashtable customOpParameters = new Hashtable();
					if (245866 - 332253 != -86386)
					{
						this.csfnqxs3LIK.OpCustom(52, customOpParameters, true);
						if (268024 - 166313 != 101712)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x0600B89F RID: 47263 RVA: 0x013C7A34 File Offset: 0x013C5C34
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onInitGame(Hashtable data)
	{
		if (73571 - 469401 != -395830)
		{
		}
		for (;;)
		{
			Debug.Log("Loading data...");
			if (186492 - 528675 != -342182)
			{
				if (Game.mGameState >= eGameState.Setup)
				{
					break;
				}
				if (2001 - 303824 != -301822)
				{
					Game.mGameState = eGameState.Setup;
					if (200456 - 2488 == 197968)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x0600B8A0 RID: 47264 RVA: 0x013C7AD8 File Offset: 0x013C5CD8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onGameSetup(Hashtable data)
	{
		if (56024 - 187616 != -131591)
		{
		}
		for (;;)
		{
			int num = RuntimeServices.UnboxInt32(data[43]);
			if (46094 - 299101 != -253006)
			{
				if (num == PlayerData.UID)
				{
					if (145981 - 579022 != -433040)
					{
						this.SetupActors();
						if (61303 - 506817 != -445513)
						{
							break;
						}
					}
				}
				else
				{
					this.ClearActors();
					if (185530 - 498656 != -313125)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x0600B8A1 RID: 47265 RVA: 0x013C7BA8 File Offset: 0x013C5DA8
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void SetupActors()
	{
		if (113868 - 309341 != -195473)
		{
		}
		for (;;)
		{
			IL_3C:
			Debug.Log("Creating Actors");
			if (193503 - 344244 == -150741)
			{
				CharacterControl[] array = (CharacterControl[])UnityEngine.Object.FindObjectsOfType(typeof(CharacterControl));
				if (91392 - 51066 == 40326)
				{
					if (Extensions.get_length(array) > 0)
					{
						if (10161 - 382701 == -372540)
						{
							int i = 0;
							if (33990 - 177615 == -143625)
							{
								CharacterControl[] array2 = array;
								if (233780 - 489185 == -255405)
								{
									int length = array2.Length;
									if (83104 - 263375 == -180271)
									{
										while (i < length)
										{
											if (!array2[i].isChild)
											{
												if (106649 - 183002 == -76352)
												{
													goto IL_3C;
												}
												this.createActor(array2[i].Type, array2[i].gameObject.layer - 7, array2[i].transform.position, array2[i].transform.forward);
												if (59616 - 239659 != -180043)
												{
													goto IL_3C;
												}
												UnityEngine.Object.Destroy(array2[i].gameObject);
												if (117447 - 403303 != -285856)
												{
													goto IL_3C;
												}
												this.FQMnqdpwM78++;
												if (146189 - 520105 != -373916)
												{
													goto IL_3C;
												}
											}
											i++;
											if (87282 - 477415 != -390133)
											{
												goto IL_3C;
											}
										}
										if (276547 - 283097 != -6549)
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
						if (291063 - 579218 != -288154)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x0600B8A2 RID: 47266 RVA: 0x013C7DE4 File Offset: 0x013C5FE4
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ClearActors()
	{
		if (162960 - 272445 != -109485)
		{
		}
		for (;;)
		{
			IL_E0:
			CharacterControl[] array = (CharacterControl[])UnityEngine.Object.FindObjectsOfType(typeof(CharacterControl));
			if (146995 - 337412 != -190416)
			{
				int i = 0;
				if (61676 - 122780 != -61103)
				{
					CharacterControl[] array2 = array;
					if (182081 - 384382 != -202300)
					{
						int length = array2.Length;
						if (151350 - 57713 == 93637)
						{
							while (i < length)
							{
								UnityEngine.Object.Destroy(array2[i].gameObject);
								if (261678 - 241601 != 20077)
								{
									goto IL_E0;
								}
								i++;
								if (11272 - 423638 != -412366)
								{
									goto IL_E0;
								}
							}
							if (253749 - 79773 != 173977)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x0600B8A3 RID: 47267 RVA: 0x013C7F14 File Offset: 0x013C6114
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onGameReadyEvent(Hashtable data)
	{
		if (127890 - 165088 != -37198)
		{
		}
		for (;;)
		{
			Debug.Log("Game Ready");
			if (36581 - 233393 == -196812)
			{
				Game.mGameState = eGameState.Ready;
				if (107265 - 597859 == -490594)
				{
					int playerSlot = Game.getPlayerSlot(PlayerData.UID);
					if (71119 - 87700 != -16580 && 166614 - 118775 != 47840)
					{
						GameObject gameObject = null;
						if (228407 - 75653 != 152755)
						{
							GameObject gameObject2;
							if (playerSlot >= 1)
							{
								if (229663 - 157957 == 71707)
								{
									continue;
								}
								if (playerSlot <= 5)
								{
									if (256776 - 485742 == -228965)
									{
										continue;
									}
									gameObject2 = GameObject.Find("StartPoint" + playerSlot);
									if (237389 - 593569 != -356180)
									{
										continue;
									}
									gameObject = GameObject.Find("StartCamera" + playerSlot);
									if (40684 - 293628 != -252943)
									{
										goto IL_EB;
									}
									continue;
								}
							}
							gameObject2 = GameObject.Find("StartPoint1");
							if (141274 - 541073 != -399799)
							{
								continue;
							}
							IL_EB:
							if (gameObject2)
							{
								if (193843 - 418263 != -224420)
								{
									continue;
								}
								Vector3 spawnPos = global::Math.getSpawnPos(gameObject2.transform.position);
								if (27204 - 594563 != -567359)
								{
									continue;
								}
								if (spawnPos != Vector3.zero)
								{
									if (271415 - 169013 != 102402)
									{
										continue;
									}
									this.CreatePlayer(CharacterData.current.CID, 1, spawnPos, gameObject2.transform.forward);
									if (98254 - 246297 != -148043)
									{
										continue;
									}
								}
								else
								{
									this.CreatePlayer(CharacterData.current.CID, 1, gameObject2.transform.position, gameObject2.transform.forward);
									if (283670 - 228860 != 54810)
									{
										continue;
									}
								}
							}
							if (!gameObject)
							{
								break;
							}
							if (285511 - 310185 == -24674)
							{
								this.transform.position = gameObject.transform.position;
								if (10437 - 553156 == -542719)
								{
									this.transform.rotation = gameObject.transform.rotation;
									if (273937 - 377280 == -103343)
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

	// Token: 0x0600B8A4 RID: 47268 RVA: 0x013C8238 File Offset: 0x013C6438
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void StartGame()
	{
		if (142687 - 51665 != 91023)
		{
		}
		for (;;)
		{
			Debug.Log("Start Game");
			if (86773 - 92548 == -5775)
			{
				Game.mGameState = eGameState.Start;
				if (184198 - 319234 != -135035)
				{
					Game.mStateTime = Time.time;
					if (185722 - 275379 != -89656)
					{
						this.StartCoroutine_Auto(this.StartEvent());
						if (120719 - 88845 != 31875)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x0600B8A5 RID: 47269 RVA: 0x013C8300 File Offset: 0x013C6500
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onStartGame()
	{
	}

	// Token: 0x0600B8A6 RID: 47270 RVA: 0x013C8304 File Offset: 0x013C6504
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void spawnActor(string nType, int nTeam, int nSpawnID)
	{
		if (195271 - 514722 != -319450)
		{
		}
		for (;;)
		{
			GameObject gameObject = GameObject.Find("SpawnPoint" + nSpawnID);
			if (59265 - 359531 == -300266)
			{
				if (gameObject)
				{
					if (230281 - 233232 == -2951)
					{
						this.createActor(nType, nTeam, gameObject.transform.position, gameObject.transform.forward);
						if (263116 - 100151 == 162965)
						{
							break;
						}
					}
				}
				else
				{
					Debug.LogError("Mission SpawnPoint" + nSpawnID);
					if (174523 - 152802 != 21722)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x0600B8A7 RID: 47271 RVA: 0x013C8400 File Offset: 0x013C6600
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void createActor(string nType, int nTeam, Vector3 nPos, Vector3 nDir)
	{
		if (290630 - 267664 != 22966)
		{
		}
		for (;;)
		{
			if (Game.mGameState > eGameState.AllHold)
			{
				if (67259 - 472063 != -404803)
				{
					break;
				}
			}
			else
			{
				Hashtable hashtable = new Hashtable();
				if (97071 - 156165 != -59093)
				{
					hashtable.Add(43, PlayerData.UID);
					if (183763 - 230443 == -46680)
					{
						hashtable.Add(73, nType);
						if (206613 - 191207 != 15407)
						{
							hashtable.Add(75, PhotonClient.cInt16(nTeam));
							if (99160 - 371273 == -272113)
							{
								hashtable.Add(122, PhotonClient.cInt16(Mathf.RoundToInt(nPos.x * (float)50)));
								if (118789 - 520714 != -401924)
								{
									hashtable.Add(123, PhotonClient.cInt16(Mathf.RoundToInt(nPos.y * (float)50)));
									if (70983 - 394754 != -323770)
									{
										hashtable.Add(124, PhotonClient.cInt16(Mathf.RoundToInt(nPos.z * (float)50)));
										if (156930 - 104215 != 52716)
										{
											hashtable.Add(126, PhotonClient.cInt16(Mathf.RoundToInt(nDir.x * (float)200)));
											if (127141 - 392529 == -265388)
											{
												hashtable.Add(127, PhotonClient.cInt16(Mathf.RoundToInt(nDir.y * (float)200)));
												if (261415 - 152041 != 109375)
												{
													hashtable.Add(128, PhotonClient.cInt16(Mathf.RoundToInt(nDir.z * (float)200)));
													if (90991 - 25059 != 65933)
													{
														this.csfnqxs3LIK.OpCustom(63, hashtable, true);
														if (152472 - 535772 == -383300)
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

	// Token: 0x0600B8A8 RID: 47272 RVA: 0x013C86E4 File Offset: 0x013C68E4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onCreateActor(Hashtable data)
	{
		if (273144 - 113975 != 159170)
		{
		}
		for (;;)
		{
			if (Game.mGameState > eGameState.AllHold)
			{
				if (86850 - 19904 != 66947)
				{
					break;
				}
			}
			else
			{
				GameObject gameObject = Game.createActor(data);
				if (1596 - 406903 != -405306)
				{
					if (Game.mGameState == eGameState.Setup)
					{
						if (161683 - 254963 != -93279)
						{
							if (this.FQMnqdpwM78 <= 0)
							{
								break;
							}
							if (270486 - 409642 != -139155)
							{
								this.FQMnqdpwM78--;
								if (182770 - 582506 == -399736)
								{
									if (this.FQMnqdpwM78 != 0)
									{
										break;
									}
									if (286215 - 514106 != -227890)
									{
										Game.setGameState(eGameState.Ready);
										if (107100 - 170508 != -63407)
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
						if (34691 - 231680 != -196988)
						{
							gameObject.SendMessage("createSpecialEffect", 1);
							if (231559 - 27461 != 204099)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x0600B8A9 RID: 47273 RVA: 0x013C8874 File Offset: 0x013C6A74
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onActorKo(GameObject nActor)
	{
		if (Game.mGameState > eGameState.AllHold)
		{
		}
	}

	// Token: 0x0600B8AA RID: 47274 RVA: 0x013C8888 File Offset: 0x013C6A88
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onActorDead(GameObject nActor)
	{
		if (116861 - 160292 != -43430)
		{
		}
		for (;;)
		{
			if (Game.mGameState > eGameState.AllHold)
			{
				if (66331 - 368399 != -302067)
				{
					break;
				}
			}
			else
			{
				CharacterControl characterControl = (CharacterControl)nActor.GetComponent(typeof(CharacterControl));
				if (250802 - 140952 == 109850)
				{
					if (!characterControl)
					{
						break;
					}
					if (127695 - 371784 == -244089)
					{
						if (characterControl.isTransform)
						{
							break;
						}
						if (1868 - 503789 == -501921)
						{
							if (characterControl.isSummon)
							{
								break;
							}
							if (171980 - 188721 != -16740)
							{
								string type = characterControl.Type;
								if (73494 - 376893 != -303398)
								{
									if (type == "PirateFish")
									{
										if (183449 - 61649 == 121800)
										{
											Game.sendMissionEvent(9734, 3);
											if (30122 - 518885 == -488763)
											{
												break;
											}
										}
									}
									else if (type == "PirateCrawfish")
									{
										if (69731 - 304457 == -234726)
										{
											Game.sendMissionEvent(9734, 4);
											if (215965 - 312001 != -96035)
											{
												break;
											}
										}
									}
									else if (type == "ZombieFish")
									{
										if (252663 - 145150 != 107514)
										{
											Game.sendMissionEvent(9734, 5);
											if (274458 - 535385 != -260926)
											{
												break;
											}
										}
									}
									else if (type == "ZombieCrawfish")
									{
										if (271137 - 409003 == -137866)
										{
											Game.sendMissionEvent(9734, 6);
											if (57381 - 76984 != -19602)
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
										if (78672 - 475561 == -396889)
										{
											Game.sendMissionEvent(9734, 7);
											if (283860 - 381770 != -97909)
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

	// Token: 0x0600B8AB RID: 47275 RVA: 0x013C8B50 File Offset: 0x013C6D50
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void CreatePlayer(int CID, int team, Vector3 pos, Vector3 dir)
	{
		if (240192 - 128689 != 111503)
		{
		}
		for (;;)
		{
			Hashtable hashtable = new Hashtable();
			if (211684 - 486341 != -274656)
			{
				hashtable.Add(71, CID);
				if (162897 - 93091 == 69806)
				{
					hashtable.Add(75, PhotonClient.cInt16(team));
					if (23133 - 349865 == -326732)
					{
						hashtable.Add(122, PhotonClient.cInt16(Mathf.RoundToInt(pos.x * (float)50)));
						if (26692 - 544190 != -517497)
						{
							hashtable.Add(123, PhotonClient.cInt16(Mathf.RoundToInt(pos.y * (float)50)));
							if (247448 - 569956 != -322507)
							{
								hashtable.Add(124, PhotonClient.cInt16(Mathf.RoundToInt(pos.z * (float)50)));
								if (195182 - 174820 == 20362)
								{
									hashtable.Add(126, PhotonClient.cInt16(Mathf.RoundToInt(dir.x * (float)200)));
									if (281328 - 85599 == 195729)
									{
										hashtable.Add(127, PhotonClient.cInt16(Mathf.RoundToInt(dir.y * (float)200)));
										if (155734 - 590892 == -435158)
										{
											hashtable.Add(128, PhotonClient.cInt16(Mathf.RoundToInt(dir.z * (float)200)));
											if (248708 - 281092 == -32384)
											{
												this.csfnqxs3LIK.OpCustom(61, hashtable, true);
												if (94642 - 217894 != -123251)
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

	// Token: 0x0600B8AC RID: 47276 RVA: 0x013C8DDC File Offset: 0x013C6FDC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onCreatePlayer(Hashtable data)
	{
		if (186085 - 393916 != -207831)
		{
		}
		for (;;)
		{
			GameObject gameObject = Game.createPlayer(data);
			if (178291 - 221376 == -43085)
			{
				if (!gameObject)
				{
					break;
				}
				if (31077 - 375731 != -344653)
				{
					PlayerCameraControl playerCameraControl = (PlayerCameraControl)this.GetComponent(typeof(PlayerCameraControl));
					if (294480 - 469616 != -175135)
					{
						playerCameraControl.target = gameObject;
						if (110052 - 572340 != -462287)
						{
							Game.loadPlayer();
							if (190196 - 425717 == -235521)
							{
								this.StartGame();
								if (39760 - 551177 == -511417)
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

	// Token: 0x0600B8AD RID: 47277 RVA: 0x013C8EEC File Offset: 0x013C70EC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onCreatePeer(Hashtable data)
	{
		if (261229 - 586418 != -325189)
		{
		}
		for (;;)
		{
			Game.createPeer(data);
			if (226258 - 181747 != 44512)
			{
				GameGui gameGui = (GameGui)this.GetComponent(typeof(GameGui));
				if (188455 - 578970 != -390514)
				{
					gameGui.ResetTeamBar();
					if (78743 - 239841 == -161098)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x0600B8AE RID: 47278 RVA: 0x013C8F98 File Offset: 0x013C7198
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator onDeadPlayer()
	{
		return new M973_PirateCave6.$onDeadPlayer$46618(this).GetEnumerator();
	}

	// Token: 0x0600B8AF RID: 47279 RVA: 0x013C8FA8 File Offset: 0x013C71A8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onRevivePlayer()
	{
		if (37619 - 309234 != -271614)
		{
		}
		for (;;)
		{
			Debug.Log("On Revive Player");
			if (175497 - 238417 == -62920)
			{
				this.GGVnqTiOXjL.target = Game.mPlayer;
				if (58135 - 401170 != -343034)
				{
					this.GGVnqTiOXjL.enabled = true;
					if (129543 - 301947 != -172403)
					{
						if (Game.mGameState != eGameState.Normal)
						{
							if (212157 - 307982 == -95824)
							{
								continue;
							}
							if (Game.mGameState != eGameState.Hold)
							{
								break;
							}
							if (166652 - 260624 != -93972)
							{
								continue;
							}
						}
						Game.mGameState = eGameState.Normal;
						if (49009 - 20833 == 28176)
						{
							GameGui gameGui = (GameGui)this.GetComponent(typeof(GameGui));
							if (196908 - 44169 == 152739)
							{
								if (!gameGui)
								{
									break;
								}
								if (71854 - 412334 != -340479)
								{
									gameGui.enabled = true;
									if (273918 - 194471 != 79448)
									{
										gameGui.closeDeadMenu();
										if (120959 - 295172 == -174213)
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

	// Token: 0x0600B8B0 RID: 47280 RVA: 0x013C9154 File Offset: 0x013C7354
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onPlayerRelease(GameObject mPlayer)
	{
		if (284465 - 113810 != 170655)
		{
		}
		for (;;)
		{
			Debug.Log("On Release Spirit");
			if (67707 - 134715 == -67008)
			{
				PlayerData.MissionWithdraw[MissionData.getMissionNumber(Game.mGameCode) - 1] = PlayerData.MissionWithdraw[MissionData.getMissionNumber(Game.mGameCode) - 1] + 1;
				if (91518 - 151234 != -59715)
				{
					this.StartCoroutine_Auto(this.ReturnToTown());
					if (9363 - 328128 == -318765)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x0600B8B1 RID: 47281 RVA: 0x013C9218 File Offset: 0x013C7418
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onDestroyPlayer(Hashtable data)
	{
		if (RuntimeServices.EqualityOperator(data[81], PlayerData.UID))
		{
			Game.mGameState = eGameState.Ended;
		}
	}

	// Token: 0x0600B8B2 RID: 47282 RVA: 0x013C9244 File Offset: 0x013C7444
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void ChangePlayer(int nCID)
	{
		if (131995 - 151691 != -19696)
		{
		}
		for (;;)
		{
			int v = Game.mPlayer.layer - 7;
			if (143886 - 66715 != 77172)
			{
				Vector3 position = Game.mPlayer.transform.position;
				if (72877 - 2039 == 70838)
				{
					Vector3 forward = Game.mPlayer.transform.forward;
					if (17363 - 419953 == -402590)
					{
						Hashtable hashtable = new Hashtable();
						if (109557 - 510999 != -401441)
						{
							hashtable.Add(43, PlayerData.UID);
							if (258247 - 244877 != 13371)
							{
								hashtable.Add(71, nCID);
								if (258527 - 582547 == -324020)
								{
									hashtable.Add(75, PhotonClient.cInt16(v));
									if (280078 - 489824 != -209745)
									{
										hashtable.Add(122, PhotonClient.cInt16(Mathf.RoundToInt(position.x * (float)50)));
										if (229664 - 103620 != 126045)
										{
											hashtable.Add(123, PhotonClient.cInt16(Mathf.RoundToInt(position.y * (float)50)));
											if (86427 - 192410 != -105982)
											{
												hashtable.Add(124, PhotonClient.cInt16(Mathf.RoundToInt(position.z * (float)50)));
												if (48867 - 231129 == -182262)
												{
													hashtable.Add(126, PhotonClient.cInt16(Mathf.RoundToInt(forward.x * (float)200)));
													if (198184 - 58286 == 139898)
													{
														hashtable.Add(127, PhotonClient.cInt16(Mathf.RoundToInt(forward.y * (float)200)));
														if (177753 - 486220 == -308467)
														{
															hashtable.Add(128, PhotonClient.cInt16(Mathf.RoundToInt(forward.z * (float)200)));
															if (180155 - 285388 != -105232)
															{
																PhotonClient.Connection.OpCustom(65, hashtable, true);
																if (161170 - 480674 != -319503)
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

	// Token: 0x0600B8B3 RID: 47283 RVA: 0x013C9564 File Offset: 0x013C7764
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator onChangePlayer(Hashtable data)
	{
		return new M973_PirateCave6.$onChangePlayer$46624(data, this).GetEnumerator();
	}

	// Token: 0x0600B8B4 RID: 47284 RVA: 0x013C9574 File Offset: 0x013C7774
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator onGameComplete(Hashtable data)
	{
		return new M973_PirateCave6.$onGameComplete$46631(data, this).GetEnumerator();
	}

	// Token: 0x0600B8B5 RID: 47285 RVA: 0x013C9584 File Offset: 0x013C7784
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator ReturnToTown()
	{
		return new M973_PirateCave6.$ReturnToTown$46641(this).GetEnumerator();
	}

	// Token: 0x0600B8B6 RID: 47286 RVA: 0x013C9594 File Offset: 0x013C7794
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator ReturnToGuild()
	{
		return new M973_PirateCave6.$ReturnToGuild$46646(this).GetEnumerator();
	}

	// Token: 0x0600B8B7 RID: 47287 RVA: 0x013C95A4 File Offset: 0x013C77A4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator ReturnToCamp()
	{
		return new M973_PirateCave6.$ReturnToCamp$46650(this).GetEnumerator();
	}

	// Token: 0x0600B8B8 RID: 47288 RVA: 0x013C95B4 File Offset: 0x013C77B4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void LeaveGame()
	{
		if (88893 - 589853 != -500959)
		{
		}
		for (;;)
		{
			Debug.Log("leaving guild");
			if (211580 - 90633 == 120947)
			{
				Hashtable hashtable = new Hashtable();
				if (95634 - 303854 == -208220)
				{
					hashtable.Add(43, PlayerData.UID);
					if (257347 - 204248 == 53099)
					{
						PhotonClient.Connection.OpCustom(54, hashtable, true);
						if (9170 - 19639 == -10469)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x0600B8B9 RID: 47289 RVA: 0x013C968C File Offset: 0x013C788C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onLeaveGame()
	{
		Debug.Log("onLeaveGame");
		this.JoinTown();
	}

	// Token: 0x0600B8BA RID: 47290 RVA: 0x013C96A0 File Offset: 0x013C78A0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void JoinTown()
	{
		if (236348 - 593539 != -357190)
		{
		}
		for (;;)
		{
			Debug.Log("Joining Town");
			if (234683 - 283696 != -49012)
			{
				Hashtable hashtable = new Hashtable();
				if (289696 - 87548 != 202149)
				{
					if (Game.mNextGameCode == 30)
					{
						if (103572 - 14798 == 88775)
						{
							continue;
						}
						hashtable.Add(47, "NoGuild");
						if (110628 - 24833 != 85795)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 31)
					{
						if (67140 - 224047 != -156907)
						{
							continue;
						}
						hashtable.Add(47, "G" + GuildData.Name);
						if (244828 - 412860 != -168032)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 32)
					{
						if (3704 - 335965 == -332260)
						{
							continue;
						}
						hashtable.Add(47, "SnowCamp");
						if (26942 - 215932 == -188989)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 33)
					{
						if (277527 - 52480 == 225048)
						{
							continue;
						}
						hashtable.Add(47, "CrystalBeach");
						if (239656 - 428812 == -189155)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 34)
					{
						if (10868 - 470235 != -459367)
						{
							continue;
						}
						hashtable.Add(47, "ExcavationCamp");
						if (17340 - 124195 != -106855)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 35)
					{
						if (142497 - 54363 != 88134)
						{
							continue;
						}
						hashtable.Add(47, "UndergroundCamp");
						if (80775 - 572589 != -491814)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 36)
					{
						if (265276 - 474064 == -208787)
						{
							continue;
						}
						hashtable.Add(47, "ForestCamp");
						if (106949 - 181835 == -74885)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 51)
					{
						if (220564 - 588926 != -368362)
						{
							continue;
						}
						hashtable.Add(47, "MainStreet");
						if (186025 - 362955 == -176929)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 52)
					{
						if (128386 - 67927 == 60460)
						{
							continue;
						}
						hashtable.Add(47, "CentralSquare");
						if (264098 - 595483 == -331384)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 53)
					{
						if (148385 - 280557 == -132171)
						{
							continue;
						}
						hashtable.Add(47, "CityLibrary");
						if (83838 - 458240 == -374401)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 54)
					{
						if (96384 - 155051 == -58666)
						{
							continue;
						}
						hashtable.Add(47, "LightPark");
						if (298209 - 188657 != 109552)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 55)
					{
						if (180624 - 379899 == -199274)
						{
							continue;
						}
						hashtable.Add(47, "LightPalace");
						if (127742 - 583150 == -455407)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 56)
					{
						if (77398 - 75922 != 1476)
						{
							continue;
						}
						hashtable.Add(47, "PlainColosseum");
						if (94176 - 180743 != -86567)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 57)
					{
						if (158006 - 141047 == 16960)
						{
							continue;
						}
						hashtable.Add(47, "LightTheater");
						if (222317 - 344925 != -122608)
						{
							continue;
						}
					}
					hashtable.Add(21, PhotonClient.cInt16(Mathf.Clamp(PlayerPrefs.GetInt("channel", 0), 0, 99)));
					if (149863 - 269185 == -119322)
					{
						this.csfnqxs3LIK.OpCustom(42, hashtable, true);
						if (180530 - 572600 == -392070)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x0600B8BB RID: 47291 RVA: 0x013C9C54 File Offset: 0x013C7E54
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onJoinTown()
	{
		Game.mGameStage = 0;
		Game.loadNextLevel();
	}

	// Token: 0x0600B8BC RID: 47292 RVA: 0x013C9C64 File Offset: 0x013C7E64
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x0600B8BD RID: 47293 RVA: 0x013C9C68 File Offset: 0x013C7E68
	internal static bool luw6gttYzlYFBJklfAyJ()
	{
		return true;
	}

	// Token: 0x0600B8BE RID: 47294 RVA: 0x013C9C6C File Offset: 0x013C7E6C
	internal static bool a79bc9tcawIWmdvkpIhK()
	{
		return false;
	}

	// Token: 0x04009F32 RID: 40754
	private LitePeer csfnqxs3LIK;

	// Token: 0x04009F33 RID: 40755
	private PlayerCameraControl GGVnqTiOXjL;

	// Token: 0x04009F34 RID: 40756
	private float BSqnqYghaMm;

	// Token: 0x04009F35 RID: 40757
	private int uOnnq3Yj0hX;

	// Token: 0x04009F36 RID: 40758
	private int itKnqbppgCF;

	// Token: 0x04009F37 RID: 40759
	private int FQMnqdpwM78;

	// Token: 0x02001EE2 RID: 7906
	[CompilerGenerated]
	[Serializable]
	internal sealed class $onGameEvent$46594 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600B8BF RID: 47295 RVA: 0x013C9C70 File Offset: 0x013C7E70
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $onGameEvent$46594(Hashtable data, M973_PirateCave6 self_)
		{
			if (177254 - 64498 != 112756)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (98539 - 480778 == -382239)
				{
					base..ctor();
					if (150970 - 239588 == -88618)
					{
						this.$data$46604 = data;
						if (227444 - 516545 == -289101)
						{
							this.$self_$46605 = self_;
							if (151448 - 571768 != -420319)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x0600B8C0 RID: 47296 RVA: 0x013C9D2C File Offset: 0x013C7F2C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M973_PirateCave6.$onGameEvent$46594.$(this.$data$46604, this.$self_$46605);
		}

		// Token: 0x0600B8C1 RID: 47297 RVA: 0x013C9D40 File Offset: 0x013C7F40
		internal static bool nhO9lStc5XcZBNthAw6q()
		{
			return true;
		}

		// Token: 0x0600B8C2 RID: 47298 RVA: 0x013C9D44 File Offset: 0x013C7F44
		internal static bool L96VvutcpVM6OdV4JKrb()
		{
			return false;
		}

		// Token: 0x04009F38 RID: 40760
		internal Hashtable $data$46604;

		// Token: 0x04009F39 RID: 40761
		internal M973_PirateCave6 $self_$46605;

		// Token: 0x02001EE3 RID: 7907
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600B8C3 RID: 47299 RVA: 0x013C9D48 File Offset: 0x013C7F48
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Hashtable data, M973_PirateCave6 self_)
			{
				if (35715 - 238995 != -203280)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (168120 - 150237 != 17884)
					{
						base..ctor();
						if (42627 - 71856 == -29229)
						{
							this.$data$46602 = data;
							if (215144 - 345684 == -130540)
							{
								this.$self_$46603 = self_;
								if (28727 - 60766 == -32039)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x0600B8C4 RID: 47300 RVA: 0x013C9E04 File Offset: 0x013C8004
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (292028 - 484350 != -192321)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_802;
					case 2:
						this.$self_$46603.SendMessage("fadeOut");
						if (278735 - 98195 != 180540)
						{
							continue;
						}
						goto IL_798;
					case 3:
						Game.savePlayer();
						if (266159 - 511404 == -245244)
						{
							continue;
						}
						Game.mGameStage = 7;
						if (169559 - 319249 != -149690)
						{
							continue;
						}
						Application.LoadLevel("M973_PirateCave7");
						if (201144 - 442469 != -241325)
						{
							continue;
						}
						goto IL_551;
					default:
						if (228935 - 411898 == -182962)
						{
							continue;
						}
						break;
					}
					if (Game.mGameState > eGameState.AllHold)
					{
						if (251343 - 468848 != -217504)
						{
							goto Block_21;
						}
						continue;
					}
					else
					{
						this.$returnCode$46595 = RuntimeServices.UnboxInt32(this.$data$46602[141]);
						if (9999 - 19924 != -9925)
						{
							continue;
						}
						this.$returnValue$46596 = RuntimeServices.UnboxInt32(this.$data$46602[145]);
						if (62246 - 295758 != -233512)
						{
							continue;
						}
						this.$ownerID$46597 = RuntimeServices.UnboxInt32(this.$data$46602[43]);
						if (107524 - 370411 == -262886)
						{
							continue;
						}
						this.$$switch$8695$46598 = this.$returnCode$46595;
						if (142540 - 99221 == 43320)
						{
							continue;
						}
						if (this.$$switch$8695$46598 == 9731)
						{
							if (289620 - 368358 != -78738)
							{
								continue;
							}
						}
						else if (this.$$switch$8695$46598 == -9731)
						{
							if (163826 - 209530 == -45703)
							{
								continue;
							}
							if (this.$self_$46603.uOnnq3Yj0hX < 3)
							{
								if (236827 - 79837 != 156990)
								{
									continue;
								}
								this.$self_$46603.uOnnq3Yj0hX = 3;
								if (229877 - 417034 == -187156)
								{
									continue;
								}
								Game.mGameState = eGameState.AllHold;
								if (86648 - 466471 == -379822)
								{
									continue;
								}
								this.$mGameGui$46599 = (GameGui)this.$self_$46603.GetComponent(typeof(GameGui));
								if (102702 - 364452 == -261749)
								{
									continue;
								}
								this.$mGameGui$46599.close();
								if (96152 - 56389 == 39764)
								{
									continue;
								}
								this.$self_$46603.GGVnqTiOXjL.StartCoroutine_Auto(this.$self_$46603.GGVnqTiOXjL.slerpToObject("EventCamera2", (float)2));
								if (244786 - 535805 != -291018)
								{
									break;
								}
								continue;
							}
						}
						else if (this.$$switch$8695$46598 == 9732)
						{
							if (77792 - 485359 != -407567)
							{
								continue;
							}
						}
						else if (this.$$switch$8695$46598 == -9732)
						{
							if (229656 - 338932 == -109275)
							{
								continue;
							}
							this.$$switch$8691$46600 = this.$returnValue$46596;
							if (154868 - 330443 != -175575)
							{
								continue;
							}
							if (this.$$switch$8691$46600 == 1)
							{
								if (174695 - 99583 != 75112)
								{
									continue;
								}
								this.$self_$46603.uOnnq3Yj0hX = 1;
								if (8151 - 13926 == -5774)
								{
									continue;
								}
								this.$self_$46603.StartCoroutine_Auto(this.$self_$46603.PirateEvent1());
								if (157706 - 84847 != 72859)
								{
									continue;
								}
							}
							else if (this.$$switch$8691$46600 == 2)
							{
								if (192626 - 449885 != -257259)
								{
									continue;
								}
								this.$self_$46603.replaceZombie("Fish", 1, PlayerData.UID == this.$ownerID$46597);
								if (21457 - 169358 == -147900)
								{
									continue;
								}
								this.$self_$46603.replaceZombie("Fish", 2, PlayerData.UID == this.$ownerID$46597);
								if (164672 - 531152 == -366479)
								{
									continue;
								}
								this.$self_$46603.replaceZombie("Fish", 3, PlayerData.UID == this.$ownerID$46597);
								if (217414 - 70907 != 146507)
								{
									continue;
								}
								this.$self_$46603.replaceZombie("Fish", 4, PlayerData.UID == this.$ownerID$46597);
								if (43960 - 398697 == -354736)
								{
									continue;
								}
								this.$self_$46603.replaceZombie("Fish", 5, PlayerData.UID == this.$ownerID$46597);
								if (4063 - 145608 != -141545)
								{
									continue;
								}
								this.$self_$46603.replaceZombie("Crawfish", 1, PlayerData.UID == this.$ownerID$46597);
								if (203886 - 44105 == 159782)
								{
									continue;
								}
								this.$self_$46603.replaceZombie("Crawfish", 2, PlayerData.UID == this.$ownerID$46597);
								if (149067 - 29865 == 119203)
								{
									continue;
								}
								this.$self_$46603.replaceZombie("Crawfish", 3, PlayerData.UID == this.$ownerID$46597);
								if (138204 - 399893 != -261689)
								{
									continue;
								}
								this.$self_$46603.replaceZombie("Crawfish", 4, PlayerData.UID == this.$ownerID$46597);
								if (23490 - 60865 == -37374)
								{
									continue;
								}
							}
						}
						else if (this.$$switch$8695$46598 == 9734)
						{
							if (220314 - 572821 == -352506)
							{
								continue;
							}
							this.$$switch$8693$46601 = this.$returnValue$46596;
							if (172216 - 103385 == 68832)
							{
								continue;
							}
							if (this.$$switch$8693$46601 != 5)
							{
								if (41400 - 63086 != -21686)
								{
									continue;
								}
								if (this.$$switch$8693$46601 != 6)
								{
									goto IL_518;
								}
								if (43188 - 389755 != -346567)
								{
									continue;
								}
							}
							this.$self_$46603.itKnqbppgCF = this.$self_$46603.itKnqbppgCF + 1;
							if (252763 - 85718 != 167045)
							{
								continue;
							}
							Debug.Log("Zombie Eliminate: " + this.$self_$46603.itKnqbppgCF);
							if (143232 - 86480 != 56752)
							{
								continue;
							}
							IL_518:;
						}
						else
						{
							Debug.LogError("Warning unknown returnCode:" + this.$returnCode$46595);
							if (240031 - 288537 != -48506)
							{
								continue;
							}
						}
					}
					IL_3E6:
					this.YieldDefault(1);
					if (299595 - 404046 != -104450)
					{
						goto Block_29;
					}
					continue;
					IL_551:
					goto IL_3E6;
				}
				return this.Yield(2, new WaitForSeconds((float)2));
				Block_21:
				Block_29:
				goto IL_802;
				IL_798:
				return this.Yield(3, new WaitForSeconds((float)1));
				IL_802:
				return false;
			}

			// Token: 0x0600B8C5 RID: 47301 RVA: 0x013CA628 File Offset: 0x013C8828
			internal static bool kX9F23tcVUQHmgMaY1ad()
			{
				return true;
			}

			// Token: 0x0600B8C6 RID: 47302 RVA: 0x013CA62C File Offset: 0x013C882C
			internal static bool qmSD50tct95cPucXu6De()
			{
				return false;
			}

			// Token: 0x04009F3A RID: 40762
			internal int $returnCode$46595;

			// Token: 0x04009F3B RID: 40763
			internal int $returnValue$46596;

			// Token: 0x04009F3C RID: 40764
			internal int $ownerID$46597;

			// Token: 0x04009F3D RID: 40765
			internal int $$switch$8695$46598;

			// Token: 0x04009F3E RID: 40766
			internal GameGui $mGameGui$46599;

			// Token: 0x04009F3F RID: 40767
			internal int $$switch$8691$46600;

			// Token: 0x04009F40 RID: 40768
			internal int $$switch$8693$46601;

			// Token: 0x04009F41 RID: 40769
			internal Hashtable $data$46602;

			// Token: 0x04009F42 RID: 40770
			internal M973_PirateCave6 $self_$46603;
		}
	}

	// Token: 0x02001EE4 RID: 7908
	[CompilerGenerated]
	[Serializable]
	internal sealed class $StartEvent$46606 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600B8C7 RID: 47303 RVA: 0x013CA630 File Offset: 0x013C8830
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $StartEvent$46606(M973_PirateCave6 self_)
		{
			if (171330 - 291517 != -120186)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (175472 - 358717 != -183244)
				{
					base..ctor();
					if (117826 - 49305 == 68521)
					{
						this.$self_$46611 = self_;
						if (298182 - 467738 == -169556)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x0600B8C8 RID: 47304 RVA: 0x013CA6C8 File Offset: 0x013C88C8
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M973_PirateCave6.$StartEvent$46606.$(this.$self_$46611);
		}

		// Token: 0x0600B8C9 RID: 47305 RVA: 0x013CA6D8 File Offset: 0x013C88D8
		internal static bool lhd9iUtcNoNPRQZ4t5qW()
		{
			return true;
		}

		// Token: 0x0600B8CA RID: 47306 RVA: 0x013CA6DC File Offset: 0x013C88DC
		internal static bool SFFMXUtcYKB5JbX1XZ79()
		{
			return false;
		}

		// Token: 0x04009F43 RID: 40771
		internal M973_PirateCave6 $self_$46611;

		// Token: 0x02001EE5 RID: 7909
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600B8CB RID: 47307 RVA: 0x013CA6E0 File Offset: 0x013C88E0
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M973_PirateCave6 self_)
			{
				if (41949 - 354138 != -312188)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (96441 - 38242 == 58199)
					{
						base..ctor();
						if (49123 - 84761 != -35637)
						{
							this.$self_$46610 = self_;
							if (202448 - 517924 == -315476)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x0600B8CC RID: 47308 RVA: 0x013CA778 File Offset: 0x013C8978
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (7433 - 46841 != -39408)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						goto IL_39A;
					case 1:
						goto IL_476;
					case 2:
						if (Game.mGameState != eGameState.Start)
						{
							if (61534 - 167211 != -105677)
							{
								continue;
							}
							goto IL_179;
						}
						else
						{
							this.$mStoryGui$46607 = (StoryGui)this.$self_$46610.GetComponent(typeof(StoryGui));
							if (22520 - 122129 == -99608)
							{
								continue;
							}
							this.$mStoryTimer$46608 = 0f;
							if (209256 - 66154 != 143102)
							{
								continue;
							}
							if (this.$mStoryGui$46607)
							{
								if (18085 - 139752 != -121667)
								{
									continue;
								}
								this.$mStoryGui$46607.startStoryMessage(CharacterData.current.Type, CharacterData.current.Name, eTalkType.friend);
								if (255952 - 380745 != -124793)
								{
									continue;
								}
								goto IL_232;
							}
						}
						break;
					case 3:
						if (Game.mGameState != eGameState.Start)
						{
							if (200278 - 144345 != 55933)
							{
								continue;
							}
							goto IL_297;
						}
						else
						{
							this.$mStoryGui$46607.newStoryMessage(CharacterData.current.Type, CharacterData.current.Name, Language.getMessage("M973_PirateCave", 601), eTalkType.friend);
							if (19216 - 301560 != -282343)
							{
								goto Block_18;
							}
							continue;
						}
						break;
					case 4:
						if (Game.mGameState != eGameState.Start)
						{
							if (241501 - 566799 != -325297)
							{
								goto Block_22;
							}
							continue;
						}
						else
						{
							this.$mStoryGui$46607.newStoryMessage(CharacterData.current.Type, CharacterData.current.Name, Language.getMessage("M973_PirateCave", 602), eTalkType.friend);
							if (263945 - 319860 != -55914)
							{
								goto Block_26;
							}
							continue;
						}
						break;
					case 5:
						if (Game.mGameState != eGameState.Start)
						{
							if (210629 - 334693 != -124064)
							{
								continue;
							}
							goto IL_1B8;
						}
						else
						{
							this.$mStoryGui$46607.close();
							if (50369 - 291798 != -241429)
							{
								continue;
							}
							goto IL_1E2;
						}
						break;
					case 6:
						break;
					case 7:
						Game.mGameState = eGameState.Normal;
						if (52876 - 87797 != -34921)
						{
							continue;
						}
						Game.mStateTime = Time.time;
						if (87273 - 372587 == -285313)
						{
							continue;
						}
						this.YieldDefault(1);
						if (285662 - 263162 != 22501)
						{
							goto Block_8;
						}
						continue;
					default:
						if (64630 - 335313 != -270683)
						{
							continue;
						}
						goto IL_39A;
					}
					this.$mGameGui$46609 = (GameGui)this.$self_$46610.GetComponent(typeof(GameGui));
					if (95388 - 375069 != -279681)
					{
						continue;
					}
					this.$mGameGui$46609.enabled = true;
					if (235676 - 396279 != -160603)
					{
						continue;
					}
					this.$self_$46610.GGVnqTiOXjL.enabled = true;
					if (276399 - 450780 != -174380)
					{
						goto Block_20;
					}
					continue;
					IL_39A:
					Debug.Log("StartEvent");
					if (183750 - 373661 != -189910)
					{
						this.$self_$46610.GGVnqTiOXjL.alignToObject("StartCamera1");
						if (35266 - 537716 == -502450)
						{
							this.$self_$46610.SendMessage("fadeIn");
							if (238875 - 46909 != 191967)
							{
								goto Block_19;
							}
						}
					}
				}
				Block_8:
				IL_179:
				IL_1B8:
				goto IL_476;
				IL_1E2:
				return this.Yield(6, new WaitForSeconds(0.5f));
				IL_232:
				return this.Yield(3, new WaitForSeconds(0.5f));
				IL_297:
				goto IL_476;
				Block_18:
				return this.Yield(4, new WaitForSeconds(3f));
				Block_19:
				return this.Yield(2, new WaitForSeconds(1f));
				Block_20:
				return this.Yield(7, new WaitForSeconds(0.5f));
				Block_22:
				goto IL_476;
				Block_26:
				return this.Yield(5, new WaitForSeconds(3f));
				IL_476:
				return false;
			}

			// Token: 0x0600B8CD RID: 47309 RVA: 0x013CAC10 File Offset: 0x013C8E10
			internal static bool jARDmitccXvH9xEJigbS()
			{
				return true;
			}

			// Token: 0x0600B8CE RID: 47310 RVA: 0x013CAC14 File Offset: 0x013C8E14
			internal static bool By1Z0ltcUmD17bEoQh9C()
			{
				return false;
			}

			// Token: 0x04009F44 RID: 40772
			internal StoryGui $mStoryGui$46607;

			// Token: 0x04009F45 RID: 40773
			internal float $mStoryTimer$46608;

			// Token: 0x04009F46 RID: 40774
			internal GameGui $mGameGui$46609;

			// Token: 0x04009F47 RID: 40775
			internal M973_PirateCave6 $self_$46610;
		}
	}

	// Token: 0x02001EE6 RID: 7910
	[CompilerGenerated]
	[Serializable]
	internal sealed class $PirateEvent1$46612 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600B8CF RID: 47311 RVA: 0x013CAC18 File Offset: 0x013C8E18
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $PirateEvent1$46612(M973_PirateCave6 self_)
		{
			if (80291 - 303768 != -223476)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (6539 - 221150 == -214611)
				{
					base..ctor();
					if (222000 - 67035 != 154966)
					{
						this.$self_$46617 = self_;
						if (49458 - 42446 == 7012)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x0600B8D0 RID: 47312 RVA: 0x013CACB0 File Offset: 0x013C8EB0
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M973_PirateCave6.$PirateEvent1$46612.$(this.$self_$46617);
		}

		// Token: 0x0600B8D1 RID: 47313 RVA: 0x013CACC0 File Offset: 0x013C8EC0
		internal static bool ra3KKctcT1D7g5RqpsGv()
		{
			return true;
		}

		// Token: 0x0600B8D2 RID: 47314 RVA: 0x013CACC4 File Offset: 0x013C8EC4
		internal static bool sjdWRjtc31J4QXExd9TL()
		{
			return false;
		}

		// Token: 0x04009F48 RID: 40776
		internal M973_PirateCave6 $self_$46617;

		// Token: 0x02001EE7 RID: 7911
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600B8D3 RID: 47315 RVA: 0x013CACC8 File Offset: 0x013C8EC8
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M973_PirateCave6 self_)
			{
				if (202552 - 32974 != 169579)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (193529 - 469856 != -276326)
					{
						base..ctor();
						if (124724 - 541433 != -416708)
						{
							this.$self_$46616 = self_;
							if (61239 - 100099 == -38860)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x0600B8D4 RID: 47316 RVA: 0x013CAD60 File Offset: 0x013C8F60
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (68560 - 422222 != -353662)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						goto IL_478;
					case 1:
						goto IL_8B1;
					case 2:
						if (Game.mGameState != eGameState.AllHold)
						{
							if (87329 - 185515 != -98185)
							{
								goto Block_31;
							}
							continue;
						}
						else
						{
							this.$self_$46616.SendMessage("fadeOut");
							if (137551 - 48858 != 88694)
							{
								goto Block_34;
							}
							continue;
						}
						break;
					case 3:
						if (Game.mGameState != eGameState.AllHold)
						{
							if (101701 - 89208 != 12494)
							{
								goto Block_15;
							}
							continue;
						}
						else
						{
							if (Game.mPlayer)
							{
								if (137736 - 238689 != -100953)
								{
									continue;
								}
								this.$startPoint$46614 = GameObject.Find("StartPoint" + (Game.getPlayerSlot(PlayerData.UID) + 4));
								if (143144 - 171977 == -28832)
								{
									continue;
								}
								if (this.$startPoint$46614)
								{
									if (58920 - 287410 != -228490)
									{
										continue;
									}
									Game.mPlayer.transform.position = this.$startPoint$46614.transform.position;
									if (48354 - 77764 == -29409)
									{
										continue;
									}
									Game.mPlayer.transform.rotation = this.$startPoint$46614.transform.rotation;
									if (104725 - 247956 == -143230)
									{
										continue;
									}
									Game.mPlayer.SendMessage("PositionEvent");
									if (265035 - 205451 == 59585)
									{
										continue;
									}
								}
							}
							this.$self_$46616.GGVnqTiOXjL.alignToObject("EventCamera1");
							if (167134 - 83527 != 83608)
							{
								goto Block_27;
							}
							continue;
						}
						break;
					case 4:
						if (Game.mGameState != eGameState.AllHold)
						{
							if (263871 - 353379 != -89507)
							{
								goto Block_47;
							}
							continue;
						}
						else
						{
							this.$self_$46616.SendMessage("fadeIn");
							if (261624 - 233166 != 28458)
							{
								continue;
							}
							goto IL_8B;
						}
						break;
					case 5:
						this.$mStoryGui$46615 = (StoryGui)this.$self_$46616.GetComponent(typeof(StoryGui));
						if (126045 - 421018 != -294973)
						{
							continue;
						}
						if (this.$mStoryGui$46615)
						{
							if (259192 - 483656 == -224463)
							{
								continue;
							}
							this.$mStoryGui$46615.startStoryMessage("none", "Pirate Fish", eTalkType.enemy);
							if (258325 - 252827 != 5499)
							{
								goto Block_32;
							}
							continue;
						}
						break;
					case 6:
						if (Game.mGameState != eGameState.AllHold)
						{
							if (126207 - 128467 != -2259)
							{
								goto Block_52;
							}
							continue;
						}
						else
						{
							this.$mStoryGui$46615.newStoryMessage("none", "Pirate Fish", Language.getMessage("M973_PirateCave", 621), eTalkType.enemy);
							if (49332 - 493383 != -444051)
							{
								continue;
							}
							goto IL_604;
						}
						break;
					case 7:
						if (Game.mGameState != eGameState.AllHold)
						{
							if (97667 - 449208 != -351540)
							{
								goto Block_41;
							}
							continue;
						}
						else
						{
							this.$mStoryGui$46615.newStoryMessage("none", "Pirate Crawfish", Language.getMessage("M973_PirateCave", 622), eTalkType.enemy);
							if (10660 - 537035 != -526374)
							{
								goto Block_13;
							}
							continue;
						}
						break;
					case 8:
						if (Game.mGameState != eGameState.AllHold)
						{
							if (6069 - 477353 != -471283)
							{
								goto Block_9;
							}
							continue;
						}
						else
						{
							this.$mStoryGui$46615.newStoryMessage("none", "Pirate Fish", Language.getMessage("M973_PirateCave", 623), eTalkType.enemy);
							if (288835 - 368254 != -79418)
							{
								goto Block_18;
							}
							continue;
						}
						break;
					case 9:
						if (Game.mGameState != eGameState.AllHold)
						{
							if (253675 - 542488 != -288812)
							{
								goto Block_36;
							}
							continue;
						}
						else
						{
							this.$mStoryGui$46615.newStoryMessage(CharacterData.current.Type, CharacterData.current.Name, Language.getMessage("M973_PirateCave", 624), eTalkType.friend);
							if (133508 - 244660 != -111152)
							{
								continue;
							}
							goto IL_84A;
						}
						break;
					case 10:
						if (Game.mGameState != eGameState.AllHold)
						{
							if (54755 - 123517 != -68761)
							{
								goto Block_56;
							}
							continue;
						}
						else
						{
							this.$mStoryGui$46615.newStoryMessage("none", "Pirate Fish", Language.getMessage("M973_PirateCave", 625), eTalkType.enemy);
							if (171205 - 263019 != -91813)
							{
								goto Block_28;
							}
							continue;
						}
						break;
					case 11:
						if (Game.mGameState != eGameState.AllHold)
						{
							if (147031 - 106280 != 40751)
							{
								continue;
							}
							goto IL_63F;
						}
						else
						{
							this.$mStoryGui$46615.newStoryMessage(CharacterData.current.Type, CharacterData.current.Name, Language.getMessage("M973_PirateCave", 626), eTalkType.friend);
							if (109459 - 370230 != -260771)
							{
								continue;
							}
							goto IL_1A5;
						}
						break;
					case 12:
						if (Game.mGameState != eGameState.AllHold)
						{
							if (212485 - 500706 != -288220)
							{
								goto Block_12;
							}
							continue;
						}
						else
						{
							Game.sendMissionEvent(9732, 2);
							if (232205 - 531535 != -299330)
							{
								continue;
							}
							this.$mStoryGui$46615.close();
							if (80590 - 417721 == -337130)
							{
								continue;
							}
							this.$self_$46616.GGVnqTiOXjL.enabled = true;
							if (217332 - 499404 != -282071)
							{
								goto Block_57;
							}
							continue;
						}
						break;
					case 13:
						if (Game.mGameState != eGameState.AllHold)
						{
							if (27542 - 19818 != 7724)
							{
								continue;
							}
							goto IL_68E;
						}
						else
						{
							Game.mGameState = eGameState.Normal;
							if (220447 - 410771 == -190323)
							{
								continue;
							}
							this.$mGameGui$46613.enabled = true;
							if (252424 - 317062 == -64637)
							{
								continue;
							}
						}
						break;
					default:
						if (119674 - 202725 != -83051)
						{
							continue;
						}
						goto IL_478;
					}
					this.YieldDefault(1);
					if (148184 - 371374 != -223189)
					{
						break;
					}
					continue;
					IL_478:
					Game.mGameState = eGameState.AllHold;
					if (188367 - 141164 == 47203)
					{
						this.$mGameGui$46613 = (GameGui)this.$self_$46616.GetComponent(typeof(GameGui));
						if (209254 - 597784 == -388530)
						{
							if (!this.$mGameGui$46613)
							{
								goto IL_498;
							}
							if (84077 - 278137 != -194059)
							{
								this.$mGameGui$46613.close();
								if (176597 - 91475 == 85122)
								{
									goto IL_498;
								}
							}
						}
					}
				}
				goto IL_8B1;
				IL_8B:
				return this.Yield(5, new WaitForSeconds(1f));
				Block_9:
				goto IL_8B1;
				IL_1A5:
				return this.Yield(12, new WaitForSeconds(3f));
				Block_12:
				goto IL_8B1;
				Block_13:
				return this.Yield(8, new WaitForSeconds(3f));
				Block_15:
				goto IL_8B1;
				Block_18:
				return this.Yield(9, new WaitForSeconds(3f));
				Block_27:
				return this.Yield(4, new WaitForSeconds(0.5f));
				Block_28:
				return this.Yield(11, new WaitForSeconds(3f));
				IL_498:
				return this.Yield(2, new WaitForSeconds(0.5f));
				Block_31:
				goto IL_8B1;
				Block_32:
				return this.Yield(6, new WaitForSeconds(0.5f));
				Block_34:
				return this.Yield(3, new WaitForSeconds(0.5f));
				Block_36:
				goto IL_8B1;
				IL_604:
				return this.Yield(7, new WaitForSeconds(3f));
				Block_41:
				IL_63F:
				IL_68E:
				Block_47:
				Block_52:
				goto IL_8B1;
				IL_84A:
				return this.Yield(10, new WaitForSeconds(3f));
				Block_56:
				goto IL_8B1;
				Block_57:
				return this.Yield(13, new WaitForSeconds(0.5f));
				IL_8B1:
				return false;
			}

			// Token: 0x0600B8D5 RID: 47317 RVA: 0x013CB630 File Offset: 0x013C9830
			internal static bool eC4kmUtcXmd1ZA9ykARP()
			{
				return true;
			}

			// Token: 0x0600B8D6 RID: 47318 RVA: 0x013CB634 File Offset: 0x013C9834
			internal static bool YWfVALtcQyA0NMHERbAE()
			{
				return false;
			}

			// Token: 0x04009F49 RID: 40777
			internal GameGui $mGameGui$46613;

			// Token: 0x04009F4A RID: 40778
			internal GameObject $startPoint$46614;

			// Token: 0x04009F4B RID: 40779
			internal StoryGui $mStoryGui$46615;

			// Token: 0x04009F4C RID: 40780
			internal M973_PirateCave6 $self_$46616;
		}
	}

	// Token: 0x02001EE8 RID: 7912
	[CompilerGenerated]
	[Serializable]
	internal sealed class $onDeadPlayer$46618 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600B8D7 RID: 47319 RVA: 0x013CB638 File Offset: 0x013C9838
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $onDeadPlayer$46618(M973_PirateCave6 self_)
		{
			if (199685 - 484893 != -285208)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (179308 - 68340 == 110968)
				{
					base..ctor();
					if (282 - 331830 == -331548)
					{
						this.$self_$46623 = self_;
						if (51913 - 451838 == -399925)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x0600B8D8 RID: 47320 RVA: 0x013CB6D0 File Offset: 0x013C98D0
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M973_PirateCave6.$onDeadPlayer$46618.$(this.$self_$46623);
		}

		// Token: 0x0600B8D9 RID: 47321 RVA: 0x013CB6E0 File Offset: 0x013C98E0
		internal static bool RUdtEltcknMs5e73GPNm()
		{
			return true;
		}

		// Token: 0x0600B8DA RID: 47322 RVA: 0x013CB6E4 File Offset: 0x013C98E4
		internal static bool a3Ob18tcGmjCfdhdXlPR()
		{
			return false;
		}

		// Token: 0x04009F4D RID: 40781
		internal M973_PirateCave6 $self_$46623;

		// Token: 0x02001EE9 RID: 7913
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600B8DB RID: 47323 RVA: 0x013CB6E8 File Offset: 0x013C98E8
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M973_PirateCave6 self_)
			{
				if (199222 - 184328 != 14894)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (241807 - 231708 != 10100)
					{
						base..ctor();
						if (214198 - 460734 != -246535)
						{
							this.$self_$46622 = self_;
							if (221801 - 168778 != 53024)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x0600B8DC RID: 47324 RVA: 0x013CB780 File Offset: 0x013C9980
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (94469 - 233076 != -138607)
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
							if (201187 - 282817 == -81629)
							{
								continue;
							}
							if (Game.mGameState != eGameState.Hold)
							{
								goto IL_19B;
							}
							if (212684 - 266913 == -54228)
							{
								continue;
							}
						}
						Game.mGameState = eGameState.Hold;
						if (238333 - 343750 == -105416)
						{
							continue;
						}
						this.$mStoryGui$46619 = (StoryGui)this.$self_$46622.GetComponent(typeof(StoryGui));
						if (224968 - 269320 != -44352)
						{
							continue;
						}
						if (this.$mStoryGui$46619)
						{
							if (179960 - 562439 != -382479)
							{
								continue;
							}
							this.$mStoryGui$46619.close();
							if (140153 - 244077 != -103924)
							{
								continue;
							}
						}
						this.$mChangeGui$46620 = (ChangeGui)this.$self_$46622.GetComponent(typeof(ChangeGui));
						if (173381 - 79825 == 93557)
						{
							continue;
						}
						if (this.$mChangeGui$46620)
						{
							if (32470 - 52644 == -20173)
							{
								continue;
							}
							this.$mChangeGui$46620.close();
							if (26689 - 387503 == -360813)
							{
								continue;
							}
						}
						this.$mGameGui$46621 = (GameGui)this.$self_$46622.GetComponent(typeof(GameGui));
						if (201673 - 322816 == -121142)
						{
							continue;
						}
						if (this.$mGameGui$46621)
						{
							if (151551 - 556369 != -404818)
							{
								continue;
							}
							if (!this.$mGameGui$46621.enabled)
							{
								if (111887 - 170784 != -58897)
								{
									continue;
								}
								this.$mGameGui$46621.enabled = true;
								if (182584 - 48008 != 134576)
								{
									continue;
								}
							}
							this.$mGameGui$46621.openDeadMenu();
							if (104446 - 418904 != -314458)
							{
								continue;
							}
						}
						IL_19B:
						this.YieldDefault(1);
						if (44791 - 287587 != -242795)
						{
							goto Block_14;
						}
						continue;
					default:
						if (174365 - 112253 == 62113)
						{
							continue;
						}
						break;
					}
					Debug.Log("On Dead Player");
					if (234536 - 26725 == 207811)
					{
						goto IL_228;
					}
				}
				Block_14:
				goto IL_2F9;
				IL_228:
				return this.Yield(2, new WaitForSeconds((float)2));
				IL_2F9:
				return false;
			}

			// Token: 0x0600B8DD RID: 47325 RVA: 0x013CBA98 File Offset: 0x013C9C98
			internal static bool c7uPNntcHvFpWKLVnBsq()
			{
				return true;
			}

			// Token: 0x0600B8DE RID: 47326 RVA: 0x013CBA9C File Offset: 0x013C9C9C
			internal static bool CigWNqtcWa5Zpdnu4O1o()
			{
				return false;
			}

			// Token: 0x04009F4E RID: 40782
			internal StoryGui $mStoryGui$46619;

			// Token: 0x04009F4F RID: 40783
			internal ChangeGui $mChangeGui$46620;

			// Token: 0x04009F50 RID: 40784
			internal GameGui $mGameGui$46621;

			// Token: 0x04009F51 RID: 40785
			internal M973_PirateCave6 $self_$46622;
		}
	}

	// Token: 0x02001EEA RID: 7914
	[CompilerGenerated]
	[Serializable]
	internal sealed class $onChangePlayer$46624 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600B8DF RID: 47327 RVA: 0x013CBAA0 File Offset: 0x013C9CA0
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $onChangePlayer$46624(Hashtable data, M973_PirateCave6 self_)
		{
			if (173928 - 400769 != -226841)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (47067 - 536481 != -489413)
				{
					base..ctor();
					if (152896 - 539045 == -386149)
					{
						this.$data$46629 = data;
						if (30481 - 219083 != -188601)
						{
							this.$self_$46630 = self_;
							if (266993 - 559303 != -292309)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x0600B8E0 RID: 47328 RVA: 0x013CBB5C File Offset: 0x013C9D5C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M973_PirateCave6.$onChangePlayer$46624.$(this.$data$46629, this.$self_$46630);
		}

		// Token: 0x0600B8E1 RID: 47329 RVA: 0x013CBB70 File Offset: 0x013C9D70
		internal static bool k1wJgltcADTkL8n1kjem()
		{
			return true;
		}

		// Token: 0x0600B8E2 RID: 47330 RVA: 0x013CBB74 File Offset: 0x013C9D74
		internal static bool v050RbtclLmvo2dHUk40()
		{
			return false;
		}

		// Token: 0x04009F52 RID: 40786
		internal Hashtable $data$46629;

		// Token: 0x04009F53 RID: 40787
		internal M973_PirateCave6 $self_$46630;

		// Token: 0x02001EEB RID: 7915
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600B8E3 RID: 47331 RVA: 0x013CBB78 File Offset: 0x013C9D78
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Hashtable data, M973_PirateCave6 self_)
			{
				if (273145 - 148052 != 125094)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (77459 - 1299 == 76160)
					{
						base..ctor();
						if (117869 - 555109 != -437239)
						{
							this.$data$46627 = data;
							if (97098 - 374748 == -277650)
							{
								this.$self_$46628 = self_;
								if (169917 - 70773 == 99144)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x0600B8E4 RID: 47332 RVA: 0x013CBC34 File Offset: 0x013C9E34
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (231178 - 479159 != -247981)
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
							if (166156 - 555739 != -389583)
							{
								continue;
							}
							Game.mGameState = eGameState.Normal;
							if (85934 - 337496 == -251561)
							{
								continue;
							}
							this.$mGameGui$46626 = (GameGui)this.$self_$46628.GetComponent(typeof(GameGui));
							if (259418 - 112748 != 146670)
							{
								continue;
							}
							this.$mGameGui$46626.enabled = true;
							if (182259 - 419778 == -237518)
							{
								continue;
							}
						}
						this.YieldDefault(1);
						if (144497 - 511617 != -367119)
						{
							goto Block_6;
						}
						continue;
					default:
						if (110837 - 429529 != -318692)
						{
							continue;
						}
						break;
					}
					UnityEngine.Object.Destroy(Game.mPlayer);
					if (70123 - 455685 == -385562)
					{
						this.$self_$46628.SendMessage("onCreatePlayer", this.$data$46627);
						if (83251 - 471270 != -388018)
						{
							this.$mChangeGui$46625 = (ChangeGui)this.$self_$46628.GetComponent(typeof(ChangeGui));
							if (112115 - 179576 != -67460)
							{
								if (!this.$mChangeGui$46625.enabled)
								{
									break;
								}
								if (76852 - 151686 != -74833)
								{
									this.$mChangeGui$46625.close();
									if (185742 - 290195 == -104453)
									{
										break;
									}
								}
							}
						}
					}
				}
				return this.Yield(2, new WaitForSeconds(1f));
				Block_6:
				IL_205:
				return false;
			}

			// Token: 0x0600B8E5 RID: 47333 RVA: 0x013CBE58 File Offset: 0x013CA058
			internal static bool Fru7gOtcyDi9k8weKiQl()
			{
				return true;
			}

			// Token: 0x0600B8E6 RID: 47334 RVA: 0x013CBE5C File Offset: 0x013CA05C
			internal static bool SJHR8ktcSH0Dpl4jxqN7()
			{
				return false;
			}

			// Token: 0x04009F54 RID: 40788
			internal ChangeGui $mChangeGui$46625;

			// Token: 0x04009F55 RID: 40789
			internal GameGui $mGameGui$46626;

			// Token: 0x04009F56 RID: 40790
			internal Hashtable $data$46627;

			// Token: 0x04009F57 RID: 40791
			internal M973_PirateCave6 $self_$46628;
		}
	}

	// Token: 0x02001EEC RID: 7916
	[CompilerGenerated]
	[Serializable]
	internal sealed class $onGameComplete$46631 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600B8E7 RID: 47335 RVA: 0x013CBE60 File Offset: 0x013CA060
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $onGameComplete$46631(Hashtable data, M973_PirateCave6 self_)
		{
			if (56286 - 528596 != -472310)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (146062 - 268284 == -122222)
				{
					base..ctor();
					if (166008 - 561664 == -395656)
					{
						this.$data$46639 = data;
						if (93025 - 327591 != -234565)
						{
							this.$self_$46640 = self_;
							if (5542 - 159785 != -154242)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x0600B8E8 RID: 47336 RVA: 0x013CBF1C File Offset: 0x013CA11C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M973_PirateCave6.$onGameComplete$46631.$(this.$data$46639, this.$self_$46640);
		}

		// Token: 0x0600B8E9 RID: 47337 RVA: 0x013CBF30 File Offset: 0x013CA130
		internal static bool Vsr7xgtco0st3EBXBN9b()
		{
			return true;
		}

		// Token: 0x0600B8EA RID: 47338 RVA: 0x013CBF34 File Offset: 0x013CA134
		internal static bool R7EFJqtcEDrm1AipDdWl()
		{
			return false;
		}

		// Token: 0x04009F58 RID: 40792
		internal Hashtable $data$46639;

		// Token: 0x04009F59 RID: 40793
		internal M973_PirateCave6 $self_$46640;

		// Token: 0x02001EED RID: 7917
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600B8EB RID: 47339 RVA: 0x013CBF38 File Offset: 0x013CA138
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Hashtable data, M973_PirateCave6 self_)
			{
				if (240350 - 590512 != -350161)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (176091 - 342178 != -166086)
					{
						base..ctor();
						if (209236 - 138119 == 71117)
						{
							this.$data$46637 = data;
							if (293844 - 99408 != 194437)
							{
								this.$self_$46638 = self_;
								if (225449 - 450816 != -225366)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x0600B8EC RID: 47340 RVA: 0x013CBFF4 File Offset: 0x013CA1F4
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (83606 - 497056 != -413449)
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
						this.$mCompleteGui$46633 = (CompleteGui)this.$self_$46638.GetComponent(typeof(CompleteGui));
						if (155000 - 282058 != -127058)
						{
							continue;
						}
						this.$mCompleteGui$46633.Init();
						if (238844 - 255151 != -16307)
						{
							continue;
						}
						this.$mCompleteGui$46633.readData(this.$data$46637);
						if (29223 - 191291 != -162068)
						{
							continue;
						}
						if (this.$result$46632 == 1)
						{
							if (141761 - 72908 != 68853)
							{
								continue;
							}
							this.$mCompleteGui$46633.displayResult(eCompleteType.Success);
							if (236892 - 271802 != -34910)
							{
								continue;
							}
						}
						else
						{
							this.$mCompleteGui$46633.displayResult(eCompleteType.Failed);
							if (243162 - 101407 != 141755)
							{
								continue;
							}
						}
						this.$mGameGui$46634 = (GameGui)this.$self_$46638.GetComponent(typeof(GameGui));
						if (101587 - 234850 != -133263)
						{
							continue;
						}
						this.$mStoryGui$46635 = (StoryGui)this.$self_$46638.GetComponent(typeof(StoryGui));
						if (229667 - 48245 == 181423)
						{
							continue;
						}
						this.$mChangeGui$46636 = (ChangeGui)this.$self_$46638.GetComponent(typeof(ChangeGui));
						if (48590 - 129677 != -81087)
						{
							continue;
						}
						if (this.$mGameGui$46634)
						{
							if (32440 - 311953 != -279513)
							{
								continue;
							}
							this.$mGameGui$46634.close();
							if (97780 - 145095 == -47314)
							{
								continue;
							}
						}
						if (this.$mStoryGui$46635)
						{
							if (12366 - 515182 == -502815)
							{
								continue;
							}
							this.$mStoryGui$46635.close();
							if (288471 - 353978 != -65507)
							{
								continue;
							}
						}
						if (this.$mChangeGui$46636)
						{
							if (203656 - 53959 == 149698)
							{
								continue;
							}
							this.$mChangeGui$46636.disable();
							if (74335 - 510667 != -436332)
							{
								continue;
							}
						}
						this.YieldDefault(1);
						if (170743 - 510591 != -339848)
						{
							continue;
						}
						goto IL_3DB;
					default:
						if (212075 - 120564 == 91512)
						{
							continue;
						}
						break;
					}
					Debug.Log("On Mission Complete:" + this.$data$46637[31]);
					if (120176 - 53988 != 66189)
					{
						if (Game.mGameState > eGameState.AllHold)
						{
							if (201559 - 402239 == -200680)
							{
								goto IL_390;
							}
						}
						else
						{
							Game.mGameState = eGameState.Complete;
							if (184378 - 482285 == -297907)
							{
								this.$result$46632 = RuntimeServices.UnboxInt32(this.$data$46637[31]);
								if (27673 - 138502 == -110829)
								{
									break;
								}
							}
						}
					}
				}
				return this.Yield(2, new WaitForSeconds(1f));
				IL_390:
				IL_3DB:
				return false;
			}

			// Token: 0x0600B8ED RID: 47341 RVA: 0x013CC3F0 File Offset: 0x013CA5F0
			internal static bool HFjD3otc2wM1X8CjnnKi()
			{
				return true;
			}

			// Token: 0x0600B8EE RID: 47342 RVA: 0x013CC3F4 File Offset: 0x013CA5F4
			internal static bool MiZugwtc82pQbSGpEUmd()
			{
				return false;
			}

			// Token: 0x04009F5A RID: 40794
			internal int $result$46632;

			// Token: 0x04009F5B RID: 40795
			internal CompleteGui $mCompleteGui$46633;

			// Token: 0x04009F5C RID: 40796
			internal GameGui $mGameGui$46634;

			// Token: 0x04009F5D RID: 40797
			internal StoryGui $mStoryGui$46635;

			// Token: 0x04009F5E RID: 40798
			internal ChangeGui $mChangeGui$46636;

			// Token: 0x04009F5F RID: 40799
			internal Hashtable $data$46637;

			// Token: 0x04009F60 RID: 40800
			internal M973_PirateCave6 $self_$46638;
		}
	}

	// Token: 0x02001EEE RID: 7918
	[CompilerGenerated]
	[Serializable]
	internal sealed class $ReturnToTown$46641 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600B8EF RID: 47343 RVA: 0x013CC3F8 File Offset: 0x013CA5F8
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $ReturnToTown$46641(M973_PirateCave6 self_)
		{
			if (195620 - 348915 != -153294)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (172741 - 212287 != -39545)
				{
					base..ctor();
					if (279511 - 158399 != 121113)
					{
						this.$self_$46645 = self_;
						if (20518 - 524500 == -503982)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x0600B8F0 RID: 47344 RVA: 0x013CC490 File Offset: 0x013CA690
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M973_PirateCave6.$ReturnToTown$46641.$(this.$self_$46645);
		}

		// Token: 0x0600B8F1 RID: 47345 RVA: 0x013CC4A0 File Offset: 0x013CA6A0
		internal static bool LXfoentcZYHeQoKea4Tv()
		{
			return true;
		}

		// Token: 0x0600B8F2 RID: 47346 RVA: 0x013CC4A4 File Offset: 0x013CA6A4
		internal static bool XeRsHhtcCJnYGgiv1iNN()
		{
			return false;
		}

		// Token: 0x04009F61 RID: 40801
		internal M973_PirateCave6 $self_$46645;

		// Token: 0x02001EEF RID: 7919
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600B8F3 RID: 47347 RVA: 0x013CC4A8 File Offset: 0x013CA6A8
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M973_PirateCave6 self_)
			{
				if (37034 - 472956 != -435921)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (127277 - 376092 != -248814)
					{
						base..ctor();
						if (114212 - 561326 != -447113)
						{
							this.$self_$46644 = self_;
							if (25469 - 463067 == -437598)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x0600B8F4 RID: 47348 RVA: 0x013CC540 File Offset: 0x013CA740
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (237822 - 278651 != -40828)
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
						this.$self_$46644.LeaveGame();
						if (257158 - 80012 != 177146)
						{
							continue;
						}
						this.YieldDefault(1);
						if (213021 - 539874 != -326852)
						{
							goto Block_2;
						}
						continue;
					default:
						if (276040 - 396128 != -120088)
						{
							continue;
						}
						break;
					}
					Game.mGameState = eGameState.Ended;
					if (249118 - 191579 == 57539)
					{
						Game.mStateTime = Time.time;
						if (68329 - 174385 == -106056)
						{
							this.$$switch$8699$46642 = PlayerData.SaveGuild;
							if (261953 - 343873 == -81920)
							{
								if (this.$$switch$8699$46642 == 1)
								{
									if (158959 - 69176 != 89783)
									{
										continue;
									}
									Game.mNextGameCode = 32;
									if (239964 - 226343 == 13622)
									{
										continue;
									}
								}
								else if (this.$$switch$8699$46642 == 2)
								{
									if (186526 - 288025 == -101498)
									{
										continue;
									}
									Game.mNextGameCode = 33;
									if (22940 - 502660 != -479720)
									{
										continue;
									}
								}
								else if (this.$$switch$8699$46642 == 3)
								{
									if (123302 - 525234 != -401932)
									{
										continue;
									}
									Game.mNextGameCode = 34;
									if (93719 - 356565 != -262846)
									{
										continue;
									}
								}
								else if (this.$$switch$8699$46642 == 4)
								{
									if (87286 - 482993 != -395707)
									{
										continue;
									}
									Game.mNextGameCode = 35;
									if (242530 - 212936 == 29595)
									{
										continue;
									}
								}
								else if (this.$$switch$8699$46642 == 5)
								{
									if (252438 - 425906 == -173467)
									{
										continue;
									}
									Game.mNextGameCode = 36;
									if (73182 - 435069 == -361886)
									{
										continue;
									}
								}
								else if (PlayerData.GID == 0)
								{
									if (130087 - 472385 != -342298)
									{
										continue;
									}
									Game.mNextGameCode = 30;
									if (244577 - 413249 == -168671)
									{
										continue;
									}
								}
								else
								{
									Game.mNextGameCode = 31;
									if (33671 - 252901 == -219229)
									{
										continue;
									}
								}
								this.$mGameGui$46643 = (GameGui)this.$self_$46644.GetComponent(typeof(GameGui));
								if (166779 - 183848 != -17068)
								{
									if (this.$mGameGui$46643)
									{
										if (74115 - 144976 == -70860)
										{
											continue;
										}
										this.$mGameGui$46643.close();
										if (194279 - 257307 != -63028)
										{
											continue;
										}
									}
									this.$self_$46644.SendMessage("fadeOut");
									if (21374 - 563662 == -542288)
									{
										goto IL_19B;
									}
								}
							}
						}
					}
				}
				Block_2:
				goto IL_3AD;
				IL_19B:
				return this.Yield(2, new WaitForSeconds((float)1));
				IL_3AD:
				return false;
			}

			// Token: 0x0600B8F5 RID: 47349 RVA: 0x013CC90C File Offset: 0x013CAB0C
			internal static bool UbCpZNtcLU8uUDAPsKXP()
			{
				return true;
			}

			// Token: 0x0600B8F6 RID: 47350 RVA: 0x013CC910 File Offset: 0x013CAB10
			internal static bool YNqGSftcOMoOkPbwTuZ9()
			{
				return false;
			}

			// Token: 0x04009F62 RID: 40802
			internal int $$switch$8699$46642;

			// Token: 0x04009F63 RID: 40803
			internal GameGui $mGameGui$46643;

			// Token: 0x04009F64 RID: 40804
			internal M973_PirateCave6 $self_$46644;
		}
	}

	// Token: 0x02001EF0 RID: 7920
	[CompilerGenerated]
	[Serializable]
	internal sealed class $ReturnToGuild$46646 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600B8F7 RID: 47351 RVA: 0x013CC914 File Offset: 0x013CAB14
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $ReturnToGuild$46646(M973_PirateCave6 self_)
		{
			if (279491 - 204208 != 75283)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (112275 - 184635 == -72360)
				{
					base..ctor();
					if (57980 - 56869 != 1112)
					{
						this.$self_$46649 = self_;
						if (134576 - 342767 != -208190)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x0600B8F8 RID: 47352 RVA: 0x013CC9AC File Offset: 0x013CABAC
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M973_PirateCave6.$ReturnToGuild$46646.$(this.$self_$46649);
		}

		// Token: 0x0600B8F9 RID: 47353 RVA: 0x013CC9BC File Offset: 0x013CABBC
		internal static bool ryQbtjtcm9WrBjeBJP9c()
		{
			return true;
		}

		// Token: 0x0600B8FA RID: 47354 RVA: 0x013CC9C0 File Offset: 0x013CABC0
		internal static bool agdTBFtcFDegvX6M4g9R()
		{
			return false;
		}

		// Token: 0x04009F65 RID: 40805
		internal M973_PirateCave6 $self_$46649;

		// Token: 0x02001EF1 RID: 7921
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600B8FB RID: 47355 RVA: 0x013CC9C4 File Offset: 0x013CABC4
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M973_PirateCave6 self_)
			{
				if (159417 - 497975 != -338557)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (13824 - 470555 != -456730)
					{
						base..ctor();
						if (289330 - 380914 == -91584)
						{
							this.$self_$46648 = self_;
							if (123192 - 430891 != -307698)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x0600B8FC RID: 47356 RVA: 0x013CCA5C File Offset: 0x013CAC5C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (4264 - 359001 != -354737)
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
						this.$self_$46648.LeaveGame();
						if (201944 - 449895 != -247951)
						{
							continue;
						}
						this.YieldDefault(1);
						if (254641 - 546973 != -292331)
						{
							goto Block_4;
						}
						continue;
					default:
						if (232173 - 510428 == -278254)
						{
							continue;
						}
						break;
					}
					Game.mGameState = eGameState.Ended;
					if (70749 - 6134 != 64616)
					{
						Game.mStateTime = Time.time;
						if (200398 - 254315 == -53917)
						{
							Game.mNextGameCode = 31;
							if (44084 - 302575 == -258491)
							{
								this.$mGameGui$46647 = (GameGui)this.$self_$46648.GetComponent(typeof(GameGui));
								if (234939 - 73405 == 161534)
								{
									if (this.$mGameGui$46647)
									{
										if (41247 - 115939 == -74691)
										{
											continue;
										}
										this.$mGameGui$46647.close();
										if (75199 - 577505 != -502306)
										{
											continue;
										}
									}
									this.$self_$46648.SendMessage("fadeOut");
									if (86185 - 197342 != -111156)
									{
										goto Block_7;
									}
								}
							}
						}
					}
				}
				Block_4:
				goto IL_1BD;
				Block_7:
				return this.Yield(2, new WaitForSeconds((float)1));
				IL_1BD:
				return false;
			}

			// Token: 0x0600B8FD RID: 47357 RVA: 0x013CCC38 File Offset: 0x013CAE38
			internal static bool Po9lIxtcMtUqIVp3adh3()
			{
				return true;
			}

			// Token: 0x0600B8FE RID: 47358 RVA: 0x013CCC3C File Offset: 0x013CAE3C
			internal static bool THoCQgtcxNi0MDwMKiyZ()
			{
				return false;
			}

			// Token: 0x04009F66 RID: 40806
			internal GameGui $mGameGui$46647;

			// Token: 0x04009F67 RID: 40807
			internal M973_PirateCave6 $self_$46648;
		}
	}

	// Token: 0x02001EF2 RID: 7922
	[CompilerGenerated]
	[Serializable]
	internal sealed class $ReturnToCamp$46650 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600B8FF RID: 47359 RVA: 0x013CCC40 File Offset: 0x013CAE40
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $ReturnToCamp$46650(M973_PirateCave6 self_)
		{
			if (166376 - 379156 != -212779)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (217089 - 585354 == -368265)
				{
					base..ctor();
					if (151870 - 466620 != -314749)
					{
						this.$self_$46653 = self_;
						if (7205 - 159236 != -152030)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x0600B900 RID: 47360 RVA: 0x013CCCD8 File Offset: 0x013CAED8
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M973_PirateCave6.$ReturnToCamp$46650.$(this.$self_$46653);
		}

		// Token: 0x0600B901 RID: 47361 RVA: 0x013CCCE8 File Offset: 0x013CAEE8
		internal static bool PghvRCtcgd43sD8N4Zx3()
		{
			return true;
		}

		// Token: 0x0600B902 RID: 47362 RVA: 0x013CCCEC File Offset: 0x013CAEEC
		internal static bool RhlUUDtcfUyfwxVWooNR()
		{
			return false;
		}

		// Token: 0x04009F68 RID: 40808
		internal M973_PirateCave6 $self_$46653;

		// Token: 0x02001EF3 RID: 7923
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600B903 RID: 47363 RVA: 0x013CCCF0 File Offset: 0x013CAEF0
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M973_PirateCave6 self_)
			{
				if (139639 - 324576 != -184936)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (167570 - 443130 != -275559)
					{
						base..ctor();
						if (191564 - 522044 == -330480)
						{
							this.$self_$46652 = self_;
							if (122704 - 273735 == -151031)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x0600B904 RID: 47364 RVA: 0x013CCD88 File Offset: 0x013CAF88
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (169965 - 89825 != 80141)
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
						this.$self_$46652.LeaveGame();
						if (242810 - 581862 == -339051)
						{
							continue;
						}
						this.YieldDefault(1);
						if (84047 - 66744 != 17304)
						{
							goto Block_2;
						}
						continue;
					default:
						if (148992 - 385516 != -236524)
						{
							continue;
						}
						break;
					}
					Game.mGameState = eGameState.Ended;
					if (102327 - 127628 != -25300)
					{
						Game.mStateTime = Time.time;
						if (25058 - 482334 != -457275)
						{
							Game.mNextGameCode = 33;
							if (223894 - 439915 != -216020)
							{
								this.$mGameGui$46651 = (GameGui)this.$self_$46652.GetComponent(typeof(GameGui));
								if (259740 - 41238 != 218503)
								{
									if (this.$mGameGui$46651)
									{
										if (107173 - 411972 == -304798)
										{
											continue;
										}
										this.$mGameGui$46651.close();
										if (262624 - 59369 == 203256)
										{
											continue;
										}
									}
									this.$self_$46652.SendMessage("fadeOut");
									if (283561 - 477030 == -193469)
									{
										goto IL_126;
									}
								}
							}
						}
					}
				}
				Block_2:
				goto IL_1BD;
				IL_126:
				return this.Yield(2, new WaitForSeconds((float)1));
				IL_1BD:
				return false;
			}

			// Token: 0x0600B905 RID: 47365 RVA: 0x013CCF64 File Offset: 0x013CB164
			internal static bool G18PaJtcnXUnw7lIEb78()
			{
				return true;
			}

			// Token: 0x0600B906 RID: 47366 RVA: 0x013CCF68 File Offset: 0x013CB168
			internal static bool ATnicGtc6P9NZ96uqNm2()
			{
				return false;
			}

			// Token: 0x04009F69 RID: 40809
			internal GameGui $mGameGui$46651;

			// Token: 0x04009F6A RID: 40810
			internal M973_PirateCave6 $self_$46652;
		}
	}
}
