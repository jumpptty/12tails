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

// Token: 0x02001DE5 RID: 7653
[Serializable]
public class M972_IceTower5 : MonoBehaviour
{
	// Token: 0x0600B2C3 RID: 45763 RVA: 0x013792C0 File Offset: 0x013774C0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public M972_IceTower5()
	{
		LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
		base..ctor();
	}

	// Token: 0x0600B2C4 RID: 45764 RVA: 0x013792D0 File Offset: 0x013774D0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Awake()
	{
		if (177679 - 242201 != -64522)
		{
		}
		for (;;)
		{
			Game.mGameState = eGameState.Init;
			if (70189 - 211300 == -141111)
			{
				Game.mGameType = 5;
				if (133420 - 230647 == -97227)
				{
					if (Chat.Initialized)
					{
						if (271176 - 166229 != 104948)
						{
							Chat.ChatDisplay.Clear();
							if (287839 - 97232 != 190608)
							{
								break;
							}
						}
					}
					else
					{
						Chat.Init();
						if (111870 - 205081 != -93210)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x0600B2C5 RID: 45765 RVA: 0x013793B4 File Offset: 0x013775B4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Start()
	{
		if (37112 - 198436 != -161323)
		{
		}
		for (;;)
		{
			if (PhotonClient.IsInitialized())
			{
				if (85299 - 30795 != 54505)
				{
					if (Game.mNextGameCode != 972)
					{
						break;
					}
					if (75986 - 209163 != -133176)
					{
						if (Game.mGameStage != 5)
						{
							break;
						}
						if (248580 - 108643 != 139938)
						{
							Game.nextGame();
							if (10700 - 89175 == -78475)
							{
								Game.mGameCode = 972;
								if (236447 - 478213 == -241766)
								{
									Game.mGameType = 5;
									if (204152 - 150279 == 53873)
									{
										Game.mStateTime = Time.time;
										if (108948 - 218486 == -109538)
										{
											Game.canRespawn = false;
											if (216754 - 86486 == 130268)
											{
												Game.canUseItem = true;
												if (65656 - 124308 == -58652)
												{
													Game.canUseMount = MissionData.getAllowMount(Game.mGameCode);
													if (111173 - 188371 != -77197)
													{
														this.za0nGkHYSVO = (PlayerCameraControl)this.GetComponent(typeof(PlayerCameraControl));
														if (109044 - 570861 != -461816)
														{
															this.SwrnGon8u4J = PhotonClient.Connection;
															if (220999 - 319023 != -98023)
															{
																PhotonClient.ActorNrList.Clear();
																if (275380 - 542431 == -267051)
																{
																	this.InitGame();
																	if (106204 - 217729 == -111525)
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
				if (206439 - 561334 != -354894)
				{
					Game.mGameType = 99;
					if (125489 - 339171 == -213682)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x0600B2C6 RID: 45766 RVA: 0x0137963C File Offset: 0x0137783C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void FixedUpdate()
	{
		if (47433 - 502007 != -454573)
		{
		}
		for (;;)
		{
			if (this.SwrnGon8u4J == null)
			{
				if (45364 - 450675 != -405310)
				{
					break;
				}
			}
			else
			{
				eGameState mGameState = Game.mGameState;
				if (170787 - 17736 == 153051)
				{
					if (mGameState == eGameState.Init)
					{
						if (234339 - 447884 == -213545)
						{
							AudioListener.volume = 0.1f * (float)Game.volume;
							if (113841 - 239412 != -125570)
							{
								break;
							}
						}
					}
					else if (mGameState == eGameState.Setup)
					{
						if (74889 - 277471 != -202581)
						{
							break;
						}
					}
					else if (mGameState == eGameState.Ready)
					{
						if (265848 - 531313 != -265464)
						{
							break;
						}
					}
					else if (mGameState == eGameState.Start)
					{
						if (255899 - 535870 == -279971)
						{
							break;
						}
					}
					else if (mGameState == eGameState.Normal)
					{
						if (140334 - 218521 == -78187)
						{
							if (Game.music != 0)
							{
								if (277259 - 371085 != -93826)
								{
									continue;
								}
								if (!this.audio.isPlaying)
								{
									if (73650 - 41954 == 31697)
									{
										continue;
									}
									this.audio.Play();
									if (72898 - 469986 == -397087)
									{
										continue;
									}
								}
							}
							if (Time.time - Game.mStateTime < (float)2)
							{
								if (154298 - 62613 != 91685)
								{
									continue;
								}
								this.audio.volume = Mathf.Lerp((float)0, 0.1f * (float)Game.music, 0.5f * (Time.time - Game.mStateTime));
								if (20740 - 476989 != -456249)
								{
									continue;
								}
							}
							else
							{
								this.audio.volume = 0.1f * (float)Game.music;
								if (62837 - 418587 == -355749)
								{
									continue;
								}
							}
							if (Time.time <= this.D7anGFB6stP)
							{
								break;
							}
							if (77889 - 332820 != -254930)
							{
								Game.mGameMana++;
								if (79766 - 442405 == -362639)
								{
									this.D7anGFB6stP = Time.time + (float)12;
									if (274795 - 86408 != 188388)
									{
										break;
									}
								}
							}
						}
					}
					else if (mGameState == eGameState.Hold)
					{
						if (212884 - 414863 == -201979)
						{
							break;
						}
					}
					else if (mGameState == eGameState.AllHold)
					{
						if (174169 - 251863 != -77693)
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
						if (195973 - 478404 == -282431)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x0600B2C7 RID: 45767 RVA: 0x013799B0 File Offset: 0x01377BB0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator onGameEvent(Hashtable data)
	{
		return new M972_IceTower5.$onGameEvent$45797(data, this).GetEnumerator();
	}

	// Token: 0x0600B2C8 RID: 45768 RVA: 0x013799C0 File Offset: 0x01377BC0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void spawnIceChar(string nType, int nSpawnID)
	{
		if (209123 - 512267 != -303144)
		{
		}
		for (;;)
		{
			GameObject gameObject = GameObject.Find("SpawnPoint" + nSpawnID);
			if (183881 - 419145 != -235263)
			{
				if (gameObject)
				{
					if (19728 - 452412 == -432684)
					{
						this.createActor(nType, 8, gameObject.transform.position, gameObject.transform.forward);
						if (73398 - 305636 == -232238)
						{
							break;
						}
					}
				}
				else
				{
					Debug.LogError("Mission SpawnPoint" + nSpawnID);
					if (219856 - 349176 != -129319)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x0600B2C9 RID: 45769 RVA: 0x01379ABC File Offset: 0x01377CBC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator EndEvent()
	{
		return new M972_IceTower5.$EndEvent$45808(this).GetEnumerator();
	}

	// Token: 0x0600B2CA RID: 45770 RVA: 0x01379ACC File Offset: 0x01377CCC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void UseIceGate(int nID)
	{
		Game.sendMissionEvent(9724, nID);
	}

	// Token: 0x0600B2CB RID: 45771 RVA: 0x01379ADC File Offset: 0x01377CDC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator OpenIceGate(int nID)
	{
		return new M972_IceTower5.$OpenIceGate$45821(nID).GetEnumerator();
	}

	// Token: 0x0600B2CC RID: 45772 RVA: 0x01379AEC File Offset: 0x01377CEC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void InitGame()
	{
		if (248647 - 39545 != 209103)
		{
		}
		for (;;)
		{
			Debug.Log("Initializing Mission");
			if (102300 - 556515 != -454214)
			{
				Time.timeScale = 1f;
				if (242957 - 465647 != -222689)
				{
					Hashtable customOpParameters = new Hashtable();
					if (45998 - 295946 == -249948)
					{
						this.SwrnGon8u4J.OpCustom(52, customOpParameters, true);
						if (239103 - 543981 == -304878)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x0600B2CD RID: 45773 RVA: 0x01379BB8 File Offset: 0x01377DB8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onInitGame(Hashtable data)
	{
		if (96828 - 343614 != -246786)
		{
		}
		for (;;)
		{
			Debug.Log("Loading data...");
			if (201323 - 589289 == -387966)
			{
				if (Game.mGameState >= eGameState.Setup)
				{
					break;
				}
				if (220465 - 169638 == 50827)
				{
					Game.mGameState = eGameState.Setup;
					if (122319 - 521048 == -398729)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x0600B2CE RID: 45774 RVA: 0x01379C5C File Offset: 0x01377E5C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onGameSetup(Hashtable data)
	{
		if (271823 - 88518 != 183306)
		{
		}
		for (;;)
		{
			int num = RuntimeServices.UnboxInt32(data[43]);
			if (128312 - 109132 == 19180)
			{
				if (num == PlayerData.UID)
				{
					if (277394 - 266158 != 11237)
					{
						this.SetupActors();
						if (45615 - 240571 == -194956)
						{
							break;
						}
					}
				}
				else
				{
					this.ClearActors();
					if (137976 - 124507 != 13470)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x0600B2CF RID: 45775 RVA: 0x01379D2C File Offset: 0x01377F2C
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void SetupActors()
	{
		if (182024 - 343870 != -161846)
		{
		}
		for (;;)
		{
			IL_1FA:
			Debug.Log("Creating Actors");
			if (219427 - 448002 != -228574)
			{
				CharacterControl[] array = (CharacterControl[])UnityEngine.Object.FindObjectsOfType(typeof(CharacterControl));
				if (56980 - 298470 == -241490)
				{
					if (Extensions.get_length(array) > 0)
					{
						if (50631 - 543466 == -492835)
						{
							int i = 0;
							if (249 - 335295 != -335045)
							{
								CharacterControl[] array2 = array;
								if (6979 - 430281 != -423301)
								{
									int length = array2.Length;
									if (67940 - 356904 != -288963)
									{
										while (i < length)
										{
											if (!array2[i].isChild)
											{
												if (146254 - 319220 != -172966)
												{
													goto IL_1FA;
												}
												this.createActor(array2[i].Type, array2[i].gameObject.layer - 7, array2[i].transform.position, array2[i].transform.forward);
												if (28785 - 23800 == 4986)
												{
													goto IL_1FA;
												}
												UnityEngine.Object.Destroy(array2[i].gameObject);
												if (58925 - 397012 == -338086)
												{
													goto IL_1FA;
												}
												this.TwKnGWq9qye++;
												if (48363 - 223276 != -174913)
												{
													goto IL_1FA;
												}
											}
											i++;
											if (5832 - 12035 != -6203)
											{
												goto IL_1FA;
											}
										}
										if (13232 - 521352 != -508119)
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
						if (236279 - 354174 == -117895)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x0600B2D0 RID: 45776 RVA: 0x01379F68 File Offset: 0x01378168
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ClearActors()
	{
		if (247788 - 456043 != -208255)
		{
		}
		for (;;)
		{
			IL_3C:
			CharacterControl[] array = (CharacterControl[])UnityEngine.Object.FindObjectsOfType(typeof(CharacterControl));
			if (40882 - 229579 == -188697)
			{
				int i = 0;
				if (171122 - 392572 != -221449)
				{
					CharacterControl[] array2 = array;
					if (28245 - 440078 != -411832)
					{
						int length = array2.Length;
						if (191060 - 245534 == -54474)
						{
							while (i < length)
							{
								UnityEngine.Object.Destroy(array2[i].gameObject);
								if (24501 - 583658 != -559157)
								{
									goto IL_3C;
								}
								i++;
								if (32102 - 180657 != -148555)
								{
									goto IL_3C;
								}
							}
							if (2124 - 141657 == -139533)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x0600B2D1 RID: 45777 RVA: 0x0137A098 File Offset: 0x01378298
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onGameReadyEvent(Hashtable data)
	{
		if (46772 - 214435 != -167663)
		{
		}
		for (;;)
		{
			Debug.Log("Game Ready");
			if (233189 - 407407 == -174218)
			{
				Game.mGameState = eGameState.Ready;
				if (220411 - 346420 != -126008)
				{
					int playerSlot = Game.getPlayerSlot(PlayerData.UID);
					if (24343 - 10150 == 14193)
					{
						if (89742 - 276742 == -187000)
						{
							GameObject gameObject = null;
							if (267563 - 30049 == 237514)
							{
								if (playerSlot < 1)
								{
									goto IL_23E;
								}
								if (299395 - 326220 != -26825)
								{
									continue;
								}
								if (playerSlot > 6)
								{
									goto IL_23E;
								}
								if (243706 - 489729 == -246022)
								{
									continue;
								}
								GameObject gameObject2 = GameObject.Find("StartPoint" + playerSlot);
								if (216506 - 460881 != -244375)
								{
									continue;
								}
								gameObject = GameObject.Find("StartCamera" + playerSlot);
								if (226889 - 294186 != -67297)
								{
									continue;
								}
								IL_284:
								if (gameObject2)
								{
									if (59572 - 567110 == -507537)
									{
										continue;
									}
									Vector3 spawnPos = global::Math.getSpawnPos(gameObject2.transform.position);
									if (26645 - 318791 != -292146)
									{
										continue;
									}
									if (spawnPos != Vector3.zero)
									{
										if (151871 - 268170 != -116299)
										{
											continue;
										}
										this.CreatePlayer(CharacterData.current.CID, 1, spawnPos, gameObject2.transform.forward);
										if (32209 - 217843 != -185634)
										{
											continue;
										}
									}
									else
									{
										this.CreatePlayer(CharacterData.current.CID, 1, gameObject2.transform.position, gameObject2.transform.forward);
										if (216098 - 152190 == 63909)
										{
											continue;
										}
									}
								}
								if (!gameObject)
								{
									break;
								}
								if (60487 - 415821 != -355334)
								{
									continue;
								}
								this.transform.position = gameObject.transform.position;
								if (247463 - 29734 != 217729)
								{
									continue;
								}
								this.transform.rotation = gameObject.transform.rotation;
								if (293734 - 264718 != 29016)
								{
									continue;
								}
								break;
								IL_23E:
								gameObject2 = GameObject.Find("StartPoint1");
								if (84157 - 225106 == -140949)
								{
									goto IL_284;
								}
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x0600B2D2 RID: 45778 RVA: 0x0137A3BC File Offset: 0x013785BC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator StartGame()
	{
		return new M972_IceTower5.$StartGame$45825(this).GetEnumerator();
	}

	// Token: 0x0600B2D3 RID: 45779 RVA: 0x0137A3CC File Offset: 0x013785CC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onStartGame()
	{
	}

	// Token: 0x0600B2D4 RID: 45780 RVA: 0x0137A3D0 File Offset: 0x013785D0
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void createActor(string nType, int nTeam, Vector3 nPos, Vector3 nDir)
	{
		if (125581 - 133936 != -8354)
		{
		}
		for (;;)
		{
			if (Game.mGameState > eGameState.AllHold)
			{
				if (267578 - 457131 != -189552)
				{
					break;
				}
			}
			else
			{
				Hashtable hashtable = new Hashtable();
				if (164865 - 458681 == -293816)
				{
					hashtable.Add(43, PlayerData.UID);
					if (891 - 578975 != -578083)
					{
						hashtable.Add(73, nType);
						if (82526 - 191170 == -108644)
						{
							hashtable.Add(75, PhotonClient.cInt16(nTeam));
							if (5577 - 80058 == -74481)
							{
								hashtable.Add(122, PhotonClient.cInt16(Mathf.RoundToInt(nPos.x * (float)50)));
								if (292558 - 562458 == -269900)
								{
									hashtable.Add(123, PhotonClient.cInt16(Mathf.RoundToInt(nPos.y * (float)50)));
									if (294108 - 115034 == 179074)
									{
										hashtable.Add(124, PhotonClient.cInt16(Mathf.RoundToInt(nPos.z * (float)50)));
										if (14508 - 115023 != -100514)
										{
											hashtable.Add(126, PhotonClient.cInt16(Mathf.RoundToInt(nDir.x * (float)200)));
											if (122203 - 258786 == -136583)
											{
												hashtable.Add(127, PhotonClient.cInt16(Mathf.RoundToInt(nDir.y * (float)200)));
												if (87254 - 67862 == 19392)
												{
													hashtable.Add(128, PhotonClient.cInt16(Mathf.RoundToInt(nDir.z * (float)200)));
													if (50869 - 472588 != -421718)
													{
														this.SwrnGon8u4J.OpCustom(63, hashtable, true);
														if (139730 - 59685 != 80046)
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

	// Token: 0x0600B2D5 RID: 45781 RVA: 0x0137A6B4 File Offset: 0x013788B4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onCreateActor(Hashtable data)
	{
		if (19753 - 432562 != -412809)
		{
		}
		for (;;)
		{
			if (Game.mGameState > eGameState.AllHold)
			{
				if (104880 - 341061 != -236180)
				{
					break;
				}
			}
			else
			{
				GameObject gameObject = Game.createActor(data);
				if (186249 - 142825 != 43425)
				{
					if (Game.mGameState == eGameState.Setup)
					{
						if (48010 - 451549 == -403539)
						{
							if (this.TwKnGWq9qye <= 0)
							{
								break;
							}
							if (186173 - 278484 != -92310)
							{
								this.TwKnGWq9qye--;
								if (263161 - 332947 == -69786)
								{
									if (this.TwKnGWq9qye != 0)
									{
										break;
									}
									if (41627 - 165550 != -123922)
									{
										Game.setGameState(eGameState.Ready);
										if (88706 - 161217 == -72511)
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
						if (162145 - 191261 != -29115)
						{
							gameObject.SendMessage("createSpecialEffect", 1);
							if (94836 - 113319 != -18482)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x0600B2D6 RID: 45782 RVA: 0x0137A844 File Offset: 0x01378A44
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onActorKo(GameObject nActor)
	{
		if (Game.mGameState > eGameState.AllHold)
		{
		}
	}

	// Token: 0x0600B2D7 RID: 45783 RVA: 0x0137A858 File Offset: 0x01378A58
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onActorDead(GameObject nActor)
	{
		if (238579 - 415135 != -176555)
		{
		}
		for (;;)
		{
			if (Game.mGameState > eGameState.AllHold)
			{
				if (289812 - 320862 != -31049)
				{
					break;
				}
			}
			else
			{
				CharacterControl characterControl = (CharacterControl)nActor.GetComponent(typeof(CharacterControl));
				if (173431 - 55926 == 117505)
				{
					if (!characterControl)
					{
						break;
					}
					if (70561 - 212253 == -141692)
					{
						if (characterControl.isTransform)
						{
							break;
						}
						if (9476 - 317436 == -307960)
						{
							if (characterControl.isSummon)
							{
								break;
							}
							if (136443 - 478461 == -342018)
							{
								string type = characterControl.Type;
								if (145936 - 292900 == -146964)
								{
									if (type == "SnowMupo")
									{
										if (122300 - 201789 == -79489)
										{
											Game.sendMissionEvent(9723, 1);
											if (21760 - 369142 == -347382)
											{
												break;
											}
										}
									}
									else if (type == "FrostTower")
									{
										if (229597 - 216045 != 13553)
										{
											Game.sendMissionEvent(9723, 2);
											if (249225 - 272854 == -23629)
											{
												break;
											}
										}
									}
									else if (type == "IcePenguin1")
									{
										if (70682 - 319703 != -249020)
										{
											Game.sendMissionEvent(9723, 3);
											if (241018 - 280393 == -39375)
											{
												break;
											}
										}
									}
									else if (type == "IcePenguin2")
									{
										if (76322 - 499104 == -422782)
										{
											Game.sendMissionEvent(9723, 4);
											if (218130 - 592517 == -374387)
											{
												break;
											}
										}
									}
									else if (type == "IcePenguin3")
									{
										if (82755 - 541625 == -458870)
										{
											Game.sendMissionEvent(9723, 5);
											if (157467 - 118262 != 39206)
											{
												break;
											}
										}
									}
									else if (type == "IceDemon")
									{
										if (156522 - 583476 != -426953)
										{
											Game.sendMissionEvent(9723, 6);
											if (171176 - 339920 != -168743)
											{
												break;
											}
										}
									}
									else if (type == "IceGuardian")
									{
										if (282781 - 570530 == -287749)
										{
											Game.sendMissionEvent(9723, 7);
											if (252542 - 195840 != 56703)
											{
												break;
											}
										}
									}
									else if (type == "FrostCrystal")
									{
										if (86015 - 361587 == -275572)
										{
											Game.sendMissionEvent(9723, 8);
											if (264476 - 361591 == -97115)
											{
												break;
											}
										}
									}
									else if (type == "IceGod")
									{
										if (33469 - 300540 != -267070)
										{
											Game.sendMissionEvent(9723, 9);
											if (184031 - 589288 != -405256)
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
										if (54671 - 529460 == -474789)
										{
											Game.sendMissionEvent(9723, 10);
											if (6910 - 43514 != -36603)
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

	// Token: 0x0600B2D8 RID: 45784 RVA: 0x0137ACC4 File Offset: 0x01378EC4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void CreatePlayer(int CID, int team, Vector3 pos, Vector3 dir)
	{
		if (273918 - 576978 != -303059)
		{
		}
		for (;;)
		{
			Hashtable hashtable = new Hashtable();
			if (114026 - 286211 == -172185)
			{
				hashtable.Add(71, CID);
				if (183744 - 354091 == -170347)
				{
					hashtable.Add(75, PhotonClient.cInt16(team));
					if (252161 - 53351 != 198811)
					{
						hashtable.Add(122, PhotonClient.cInt16(Mathf.RoundToInt(pos.x * (float)50)));
						if (26255 - 404031 != -377775)
						{
							hashtable.Add(123, PhotonClient.cInt16(Mathf.RoundToInt(pos.y * (float)50)));
							if (244144 - 588712 == -344568)
							{
								hashtable.Add(124, PhotonClient.cInt16(Mathf.RoundToInt(pos.z * (float)50)));
								if (61730 - 198607 != -136876)
								{
									hashtable.Add(126, PhotonClient.cInt16(Mathf.RoundToInt(dir.x * (float)200)));
									if (34590 - 153876 == -119286)
									{
										hashtable.Add(127, PhotonClient.cInt16(Mathf.RoundToInt(dir.y * (float)200)));
										if (42493 - 64078 == -21585)
										{
											hashtable.Add(128, PhotonClient.cInt16(Mathf.RoundToInt(dir.z * (float)200)));
											if (299843 - 481541 != -181697)
											{
												this.SwrnGon8u4J.OpCustom(61, hashtable, true);
												if (234506 - 512104 != -277597)
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

	// Token: 0x0600B2D9 RID: 45785 RVA: 0x0137AF50 File Offset: 0x01379150
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onCreatePlayer(Hashtable data)
	{
		if (115421 - 364278 != -248856)
		{
		}
		for (;;)
		{
			GameObject gameObject = Game.createPlayer(data);
			if (124610 - 587882 == -463272)
			{
				if (!gameObject)
				{
					break;
				}
				if (216555 - 282839 != -66283)
				{
					PlayerCameraControl playerCameraControl = (PlayerCameraControl)this.GetComponent(typeof(PlayerCameraControl));
					if (74834 - 520700 != -445865)
					{
						playerCameraControl.target = gameObject;
						if (29057 - 585466 == -556409)
						{
							Game.loadPlayer();
							if (130219 - 95381 != 34839)
							{
								this.StartCoroutine_Auto(this.StartGame());
								if (134209 - 550199 == -415990)
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

	// Token: 0x0600B2DA RID: 45786 RVA: 0x0137B068 File Offset: 0x01379268
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onCreatePeer(Hashtable data)
	{
		if (187574 - 540857 != -353283)
		{
		}
		for (;;)
		{
			Game.createPeer(data);
			if (73743 - 74217 == -474)
			{
				GameGui gameGui = (GameGui)this.GetComponent(typeof(GameGui));
				if (192364 - 562983 == -370619)
				{
					gameGui.ResetTeamBar();
					if (110590 - 486151 == -375561)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x0600B2DB RID: 45787 RVA: 0x0137B114 File Offset: 0x01379314
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator onDeadPlayer()
	{
		return new M972_IceTower5.$onDeadPlayer$45829(this).GetEnumerator();
	}

	// Token: 0x0600B2DC RID: 45788 RVA: 0x0137B124 File Offset: 0x01379324
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onRevivePlayer()
	{
		if (42291 - 30431 != 11860)
		{
		}
		for (;;)
		{
			Debug.Log("On Revive Player");
			if (206535 - 80935 != 125601)
			{
				this.za0nGkHYSVO.target = Game.mPlayer;
				if (131771 - 119053 == 12718)
				{
					this.za0nGkHYSVO.enabled = true;
					if (177024 - 247025 != -70000)
					{
						if (Game.mGameState != eGameState.Normal)
						{
							if (129333 - 311240 == -181906)
							{
								continue;
							}
							if (Game.mGameState != eGameState.Hold)
							{
								break;
							}
							if (137158 - 564470 != -427312)
							{
								continue;
							}
						}
						Game.mGameState = eGameState.Normal;
						if (256699 - 586148 != -329448)
						{
							GameGui gameGui = (GameGui)this.GetComponent(typeof(GameGui));
							if (106606 - 541192 == -434586)
							{
								if (!gameGui)
								{
									break;
								}
								if (122546 - 578870 == -456324)
								{
									gameGui.enabled = true;
									if (208142 - 184978 != 23165)
									{
										gameGui.closeDeadMenu();
										if (84288 - 65923 != 18366)
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

	// Token: 0x0600B2DD RID: 45789 RVA: 0x0137B2D0 File Offset: 0x013794D0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onPlayerRelease(GameObject mPlayer)
	{
		if (286157 - 1690 != 284468)
		{
		}
		for (;;)
		{
			Debug.Log("On Release Spirit");
			if (70870 - 427009 == -356139)
			{
				PlayerData.MissionWithdraw[MissionData.getMissionNumber(Game.mGameCode) - 1] = PlayerData.MissionWithdraw[MissionData.getMissionNumber(Game.mGameCode) - 1] + 1;
				if (32508 - 547001 != -514492)
				{
					this.StartCoroutine_Auto(this.ReturnToTown());
					if (73539 - 473040 == -399501)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x0600B2DE RID: 45790 RVA: 0x0137B394 File Offset: 0x01379594
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onDestroyPlayer(Hashtable data)
	{
		if (RuntimeServices.EqualityOperator(data[81], PlayerData.UID))
		{
			Game.mGameState = eGameState.Ended;
		}
	}

	// Token: 0x0600B2DF RID: 45791 RVA: 0x0137B3C0 File Offset: 0x013795C0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void ChangePlayer(int nCID)
	{
		if (62709 - 257250 != -194540)
		{
		}
		for (;;)
		{
			int v = Game.mPlayer.layer - 7;
			if (143651 - 201967 == -58316)
			{
				Vector3 position = Game.mPlayer.transform.position;
				if (86146 - 363801 != -277654)
				{
					Vector3 forward = Game.mPlayer.transform.forward;
					if (292870 - 389335 == -96465)
					{
						Hashtable hashtable = new Hashtable();
						if (197510 - 9596 == 187914)
						{
							hashtable.Add(43, PlayerData.UID);
							if (169245 - 255464 != -86218)
							{
								hashtable.Add(71, nCID);
								if (241578 - 149433 == 92145)
								{
									hashtable.Add(75, PhotonClient.cInt16(v));
									if (67499 - 511643 == -444144)
									{
										hashtable.Add(122, PhotonClient.cInt16(Mathf.RoundToInt(position.x * (float)50)));
										if (291841 - 30229 == 261612)
										{
											hashtable.Add(123, PhotonClient.cInt16(Mathf.RoundToInt(position.y * (float)50)));
											if (256104 - 253793 == 2311)
											{
												hashtable.Add(124, PhotonClient.cInt16(Mathf.RoundToInt(position.z * (float)50)));
												if (174754 - 57256 != 117499)
												{
													hashtable.Add(126, PhotonClient.cInt16(Mathf.RoundToInt(forward.x * (float)200)));
													if (130029 - 17288 != 112742)
													{
														hashtable.Add(127, PhotonClient.cInt16(Mathf.RoundToInt(forward.y * (float)200)));
														if (287186 - 116935 != 170252)
														{
															hashtable.Add(128, PhotonClient.cInt16(Mathf.RoundToInt(forward.z * (float)200)));
															if (55913 - 218081 != -162167)
															{
																PhotonClient.Connection.OpCustom(65, hashtable, true);
																if (77288 - 517918 != -440629)
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

	// Token: 0x0600B2E0 RID: 45792 RVA: 0x0137B6E0 File Offset: 0x013798E0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator onChangePlayer(Hashtable data)
	{
		return new M972_IceTower5.$onChangePlayer$45835(data, this).GetEnumerator();
	}

	// Token: 0x0600B2E1 RID: 45793 RVA: 0x0137B6F0 File Offset: 0x013798F0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator onGameComplete(Hashtable data)
	{
		return new M972_IceTower5.$onGameComplete$45842(data, this).GetEnumerator();
	}

	// Token: 0x0600B2E2 RID: 45794 RVA: 0x0137B700 File Offset: 0x01379900
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator ReturnToTown()
	{
		return new M972_IceTower5.$ReturnToTown$45852(this).GetEnumerator();
	}

	// Token: 0x0600B2E3 RID: 45795 RVA: 0x0137B710 File Offset: 0x01379910
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator ReturnToGuild()
	{
		return new M972_IceTower5.$ReturnToGuild$45857(this).GetEnumerator();
	}

	// Token: 0x0600B2E4 RID: 45796 RVA: 0x0137B720 File Offset: 0x01379920
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator ReturnToCamp()
	{
		return new M972_IceTower5.$ReturnToCamp$45861(this).GetEnumerator();
	}

	// Token: 0x0600B2E5 RID: 45797 RVA: 0x0137B730 File Offset: 0x01379930
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void LeaveGame()
	{
		if (144600 - 108436 != 36165)
		{
		}
		for (;;)
		{
			Debug.Log("leaving guild");
			if (253094 - 337237 != -84142)
			{
				Hashtable hashtable = new Hashtable();
				if (296960 - 526753 == -229793)
				{
					hashtable.Add(43, PlayerData.UID);
					if (136524 - 469622 != -333097)
					{
						PhotonClient.Connection.OpCustom(54, hashtable, true);
						if (123584 - 69820 == 53764)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x0600B2E6 RID: 45798 RVA: 0x0137B808 File Offset: 0x01379A08
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onLeaveGame()
	{
		Debug.Log("onLeaveGame");
		this.JoinTown();
	}

	// Token: 0x0600B2E7 RID: 45799 RVA: 0x0137B81C File Offset: 0x01379A1C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void JoinTown()
	{
		if (194394 - 393977 != -199583)
		{
		}
		for (;;)
		{
			Debug.Log("Joining Town");
			if (299818 - 175453 == 124365)
			{
				Hashtable hashtable = new Hashtable();
				if (2969 - 148033 != -145063)
				{
					if (Game.mNextGameCode == 30)
					{
						if (167640 - 471597 != -303957)
						{
							continue;
						}
						hashtable.Add(47, "NoGuild");
						if (195180 - 159561 != 35619)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 31)
					{
						if (104013 - 342101 == -238087)
						{
							continue;
						}
						hashtable.Add(47, "G" + GuildData.Name);
						if (158728 - 487235 == -328506)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 32)
					{
						if (75373 - 190248 != -114875)
						{
							continue;
						}
						hashtable.Add(47, "SnowCamp");
						if (113954 - 404535 != -290581)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 33)
					{
						if (158284 - 23100 != 135184)
						{
							continue;
						}
						hashtable.Add(47, "CrystalBeach");
						if (236439 - 453021 == -216581)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 34)
					{
						if (56537 - 526415 == -469877)
						{
							continue;
						}
						hashtable.Add(47, "ExcavationCamp");
						if (149432 - 433532 == -284099)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 35)
					{
						if (203154 - 570664 != -367510)
						{
							continue;
						}
						hashtable.Add(47, "UndergroundCamp");
						if (270069 - 353908 != -83839)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 36)
					{
						if (83326 - 29102 != 54224)
						{
							continue;
						}
						hashtable.Add(47, "ForestCamp");
						if (35081 - 328897 != -293816)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 51)
					{
						if (132949 - 37764 != 95185)
						{
							continue;
						}
						hashtable.Add(47, "MainStreet");
						if (231108 - 103464 == 127645)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 52)
					{
						if (88016 - 139010 != -50994)
						{
							continue;
						}
						hashtable.Add(47, "CentralSquare");
						if (268676 - 274922 == -6245)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 53)
					{
						if (96050 - 367942 == -271891)
						{
							continue;
						}
						hashtable.Add(47, "CityLibrary");
						if (66770 - 517422 != -450652)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 54)
					{
						if (93200 - 390247 != -297047)
						{
							continue;
						}
						hashtable.Add(47, "LightPark");
						if (219149 - 476927 == -257777)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 55)
					{
						if (2835 - 429368 == -426532)
						{
							continue;
						}
						hashtable.Add(47, "LightPalace");
						if (54005 - 280045 != -226040)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 56)
					{
						if (141947 - 586059 == -444111)
						{
							continue;
						}
						hashtable.Add(47, "PlainColosseum");
						if (296278 - 305333 == -9054)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 57)
					{
						if (26811 - 295112 == -268300)
						{
							continue;
						}
						hashtable.Add(47, "LightTheater");
						if (158655 - 358252 != -199597)
						{
							continue;
						}
					}
					hashtable.Add(21, PhotonClient.cInt16(Mathf.Clamp(PlayerPrefs.GetInt("channel", 0), 0, 99)));
					if (47831 - 432344 == -384513)
					{
						this.SwrnGon8u4J.OpCustom(42, hashtable, true);
						if (196735 - 21946 == 174789)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x0600B2E8 RID: 45800 RVA: 0x0137BDD0 File Offset: 0x01379FD0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onJoinTown()
	{
		Game.mGameStage = 0;
		Game.loadNextLevel();
	}

	// Token: 0x0600B2E9 RID: 45801 RVA: 0x0137BDE0 File Offset: 0x01379FE0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x0600B2EA RID: 45802 RVA: 0x0137BDE4 File Offset: 0x01379FE4
	internal static bool KNHw3yV4eDCLTlgJAFv0()
	{
		return true;
	}

	// Token: 0x0600B2EB RID: 45803 RVA: 0x0137BDE8 File Offset: 0x01379FE8
	internal static bool WTWYtdV4rHbPnLTWfB7e()
	{
		return false;
	}

	// Token: 0x04009C24 RID: 39972
	private LitePeer SwrnGon8u4J;

	// Token: 0x04009C25 RID: 39973
	private PlayerCameraControl za0nGkHYSVO;

	// Token: 0x04009C26 RID: 39974
	private float D7anGFB6stP;

	// Token: 0x04009C27 RID: 39975
	private int UyqnGAOrqDC;

	// Token: 0x04009C28 RID: 39976
	private int RtnnG9bf2yx;

	// Token: 0x04009C29 RID: 39977
	private int TwKnGWq9qye;

	// Token: 0x02001DE6 RID: 7654
	[CompilerGenerated]
	[Serializable]
	internal sealed class $onGameEvent$45797 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600B2EC RID: 45804 RVA: 0x0137BDEC File Offset: 0x01379FEC
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $onGameEvent$45797(Hashtable data, M972_IceTower5 self_)
		{
			if (227237 - 9624 != 217614)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (229951 - 155739 != 74213)
				{
					base..ctor();
					if (215907 - 413541 == -197634)
					{
						this.$data$45806 = data;
						if (139873 - 80800 != 59074)
						{
							this.$self_$45807 = self_;
							if (78013 - 547814 != -469800)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x0600B2ED RID: 45805 RVA: 0x0137BEA8 File Offset: 0x0137A0A8
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M972_IceTower5.$onGameEvent$45797.$(this.$data$45806, this.$self_$45807);
		}

		// Token: 0x0600B2EE RID: 45806 RVA: 0x0137BEBC File Offset: 0x0137A0BC
		internal static bool FliBWBV4jBNHnG8r4CLw()
		{
			return true;
		}

		// Token: 0x0600B2EF RID: 45807 RVA: 0x0137BEC0 File Offset: 0x0137A0C0
		internal static bool cwViPKV4hHSwhGfdL2rG()
		{
			return false;
		}

		// Token: 0x04009C2A RID: 39978
		internal Hashtable $data$45806;

		// Token: 0x04009C2B RID: 39979
		internal M972_IceTower5 $self_$45807;

		// Token: 0x02001DE7 RID: 7655
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600B2F0 RID: 45808 RVA: 0x0137BEC4 File Offset: 0x0137A0C4
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Hashtable data, M972_IceTower5 self_)
			{
				if (279200 - 272219 != 6982)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (35113 - 566717 != -531603)
					{
						base..ctor();
						if (104401 - 563364 == -458963)
						{
							this.$data$45804 = data;
							if (224722 - 191474 != 33249)
							{
								this.$self_$45805 = self_;
								if (112122 - 587602 != -475479)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x0600B2F1 RID: 45809 RVA: 0x0137BF80 File Offset: 0x0137A180
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (272925 - 161185 != 111741)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_98B;
					case 2:
						Game.savePlayer();
						if (85736 - 511208 == -425471)
						{
							continue;
						}
						Game.mGameStage = 6;
						if (66714 - 139099 != -72385)
						{
							continue;
						}
						Application.LoadLevel("M972_IceTower6");
						if (243039 - 360115 != -117075)
						{
							goto IL_AF;
						}
						continue;
					default:
						if (61374 - 580447 == -519072)
						{
							continue;
						}
						break;
					}
					if (Game.mGameState > eGameState.AllHold)
					{
						if (228707 - 31046 != 197661)
						{
							continue;
						}
						goto IL_84C;
					}
					else
					{
						this.$returnCode$45798 = RuntimeServices.UnboxInt32(this.$data$45804[141]);
						if (91140 - 450267 != -359127)
						{
							continue;
						}
						this.$returnValue$45799 = RuntimeServices.UnboxInt32(this.$data$45804[145]);
						if (160631 - 551623 == -390991)
						{
							continue;
						}
						this.$ownerID$45800 = RuntimeServices.UnboxInt32(this.$data$45804[43]);
						if (230920 - 507766 != -276846)
						{
							continue;
						}
						this.$$switch$8564$45801 = this.$returnCode$45798;
						if (214568 - 56372 != 158196)
						{
							continue;
						}
						if (this.$$switch$8564$45801 == 9721)
						{
							if (288664 - 320511 != -31847)
							{
								continue;
							}
						}
						else if (this.$$switch$8564$45801 == -9721)
						{
							if (11567 - 230777 != -219210)
							{
								continue;
							}
							if (this.$returnValue$45799 == 6)
							{
								if (210824 - 180528 != 30296)
								{
									continue;
								}
								if (this.$self_$45805.UyqnGAOrqDC < 2)
								{
									if (91357 - 462348 != -370991)
									{
										continue;
									}
									this.$self_$45805.UyqnGAOrqDC = 2;
									if (64667 - 489618 != -424951)
									{
										continue;
									}
									Game.mGameState = eGameState.AllHold;
									if (242954 - 330394 == -87439)
									{
										continue;
									}
									this.$mGameGui$45802 = (GameGui)this.$self_$45805.GetComponent(typeof(GameGui));
									if (72645 - 228739 == -156093)
									{
										continue;
									}
									this.$mGameGui$45802.close();
									if (140785 - 395989 == -255203)
									{
										continue;
									}
									this.$self_$45805.SendMessage("fadeOut");
									if (7555 - 241510 != -233954)
									{
										break;
									}
									continue;
								}
							}
						}
						else if (this.$$switch$8564$45801 == 9723)
						{
							if (133253 - 357379 == -224125)
							{
								continue;
							}
							if (this.$returnValue$45799 == 6)
							{
								if (102206 - 325225 == -223018)
								{
									continue;
								}
								this.$self_$45805.RtnnG9bf2yx = this.$self_$45805.RtnnG9bf2yx + 1;
								if (189527 - 178216 != 11311)
								{
									continue;
								}
								this.$$switch$8562$45803 = this.$self_$45805.RtnnG9bf2yx;
								if (75456 - 129155 != -53699)
								{
									continue;
								}
								if (this.$$switch$8562$45803 == 1)
								{
									if (119027 - 140168 == -21140)
									{
										continue;
									}
									if (this.$ownerID$45800 == PlayerData.UID)
									{
										if (110071 - 429693 != -319622)
										{
											continue;
										}
										this.$self_$45805.spawnIceChar("IcePenguin1", 1);
										if (217416 - 322502 != -105086)
										{
											continue;
										}
										this.$self_$45805.spawnIceChar("IcePenguin1", 2);
										if (210591 - 115114 != 95477)
										{
											continue;
										}
										this.$self_$45805.spawnIceChar("IcePenguin2", 3);
										if (52760 - 142892 == -90131)
										{
											continue;
										}
										this.$self_$45805.spawnIceChar("IcePenguin1", 4);
										if (256529 - 513561 != -257032)
										{
											continue;
										}
										this.$self_$45805.spawnIceChar("IcePenguin1", 5);
										if (285141 - 50707 == 234435)
										{
											continue;
										}
										this.$self_$45805.spawnIceChar("IcePenguin1", 6);
										if (205079 - 479864 == -274784)
										{
											continue;
										}
										this.$self_$45805.spawnIceChar("IcePenguin2", 7);
										if (194292 - 19442 != 174850)
										{
											continue;
										}
										this.$self_$45805.spawnIceChar("IcePenguin2", 8);
										if (242732 - 122196 == 120537)
										{
											continue;
										}
										this.$self_$45805.spawnIceChar("IcePenguin2", 9);
										if (90884 - 334694 == -243809)
										{
											continue;
										}
										this.$self_$45805.spawnIceChar("IceDemon", 10);
										if (272570 - 478021 != -205451)
										{
											continue;
										}
									}
								}
								else if (this.$$switch$8562$45803 == 2)
								{
									if (137329 - 81894 == 55436)
									{
										continue;
									}
									if (this.$ownerID$45800 == PlayerData.UID)
									{
										if (37360 - 550396 == -513035)
										{
											continue;
										}
										this.$self_$45805.spawnIceChar("IcePenguin1", 11);
										if (66741 - 98468 == -31726)
										{
											continue;
										}
										this.$self_$45805.spawnIceChar("IcePenguin1", 12);
										if (253490 - 152890 == 100601)
										{
											continue;
										}
										this.$self_$45805.spawnIceChar("IcePenguin2", 13);
										if (224893 - 59474 == 165420)
										{
											continue;
										}
										this.$self_$45805.spawnIceChar("IcePenguin2", 14);
										if (290819 - 8189 != 282630)
										{
											continue;
										}
										this.$self_$45805.spawnIceChar("IcePenguin1", 15);
										if (152032 - 100836 == 51197)
										{
											continue;
										}
										this.$self_$45805.spawnIceChar("IcePenguin2", 16);
										if (245103 - 335634 != -90531)
										{
											continue;
										}
										this.$self_$45805.spawnIceChar("IcePenguin1", 17);
										if (197926 - 162303 != 35623)
										{
											continue;
										}
										this.$self_$45805.spawnIceChar("IcePenguin1", 18);
										if (83288 - 452563 == -369274)
										{
											continue;
										}
										this.$self_$45805.spawnIceChar("IcePenguin1", 19);
										if (297799 - 105885 == 191915)
										{
											continue;
										}
										this.$self_$45805.spawnIceChar("IcePenguin2", 20);
										if (214458 - 414079 == -199620)
										{
											continue;
										}
										this.$self_$45805.spawnIceChar("IcePenguin2", 21);
										if (179958 - 93672 != 86286)
										{
											continue;
										}
										this.$self_$45805.spawnIceChar("IceDemon", 22);
										if (255317 - 461791 != -206474)
										{
											continue;
										}
									}
								}
								else if (this.$$switch$8562$45803 == 3)
								{
									if (167182 - 411054 == -243871)
									{
										continue;
									}
									if (this.$self_$45805.UyqnGAOrqDC < 1)
									{
										if (226235 - 13751 == 212485)
										{
											continue;
										}
										this.$self_$45805.UyqnGAOrqDC = 1;
										if (170669 - 146728 != 23941)
										{
											continue;
										}
										this.$self_$45805.StartCoroutine_Auto(this.$self_$45805.EndEvent());
										if (278376 - 239065 != 39311)
										{
											continue;
										}
									}
								}
							}
						}
						else if (this.$$switch$8564$45801 == 9724)
						{
							if (98201 - 519859 != -421658)
							{
								continue;
							}
							this.$self_$45805.StartCoroutine_Auto(this.$self_$45805.OpenIceGate(this.$returnValue$45799));
							if (104221 - 244405 != -140184)
							{
								continue;
							}
						}
					}
					IL_5E6:
					this.YieldDefault(1);
					if (197136 - 324892 != -127756)
					{
						continue;
					}
					goto IL_98B;
					IL_AF:
					goto IL_5E6;
				}
				return this.Yield(2, new WaitForSeconds((float)1));
				IL_84C:
				IL_98B:
				return false;
			}

			// Token: 0x0600B2F2 RID: 45810 RVA: 0x0137C92C File Offset: 0x0137AB2C
			internal static bool n2mpfMV4sAiOJ9Gn7Nwc()
			{
				return true;
			}

			// Token: 0x0600B2F3 RID: 45811 RVA: 0x0137C930 File Offset: 0x0137AB30
			internal static bool v6MB9cV492NVIXNWc673()
			{
				return false;
			}

			// Token: 0x04009C2C RID: 39980
			internal int $returnCode$45798;

			// Token: 0x04009C2D RID: 39981
			internal int $returnValue$45799;

			// Token: 0x04009C2E RID: 39982
			internal int $ownerID$45800;

			// Token: 0x04009C2F RID: 39983
			internal int $$switch$8564$45801;

			// Token: 0x04009C30 RID: 39984
			internal GameGui $mGameGui$45802;

			// Token: 0x04009C31 RID: 39985
			internal int $$switch$8562$45803;

			// Token: 0x04009C32 RID: 39986
			internal Hashtable $data$45804;

			// Token: 0x04009C33 RID: 39987
			internal M972_IceTower5 $self_$45805;
		}
	}

	// Token: 0x02001DE8 RID: 7656
	[CompilerGenerated]
	[Serializable]
	internal sealed class $EndEvent$45808 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600B2F4 RID: 45812 RVA: 0x0137C934 File Offset: 0x0137AB34
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $EndEvent$45808(M972_IceTower5 self_)
		{
			if (104173 - 65827 != 38346)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (141506 - 23101 == 118405)
				{
					base..ctor();
					if (296489 - 304649 == -8160)
					{
						this.$self_$45820 = self_;
						if (4746 - 563232 != -558485)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x0600B2F5 RID: 45813 RVA: 0x0137C9CC File Offset: 0x0137ABCC
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M972_IceTower5.$EndEvent$45808.$(this.$self_$45820);
		}

		// Token: 0x0600B2F6 RID: 45814 RVA: 0x0137C9DC File Offset: 0x0137ABDC
		internal static bool VhKoUGV41Fg9nqRICEKv()
		{
			return true;
		}

		// Token: 0x0600B2F7 RID: 45815 RVA: 0x0137C9E0 File Offset: 0x0137ABE0
		internal static bool C49eb1V44KsN9nhQecMy()
		{
			return false;
		}

		// Token: 0x04009C34 RID: 39988
		internal M972_IceTower5 $self_$45820;

		// Token: 0x02001DE9 RID: 7657
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600B2F8 RID: 45816 RVA: 0x0137C9E4 File Offset: 0x0137ABE4
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M972_IceTower5 self_)
			{
				if (81329 - 356787 != -275458)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (167575 - 594204 == -426629)
					{
						base..ctor();
						if (17744 - 289293 == -271549)
						{
							this.$self_$45819 = self_;
							if (156851 - 397322 == -240471)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x0600B2F9 RID: 45817 RVA: 0x0137CA7C File Offset: 0x0137AC7C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (51311 - 507543 != -456232)
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
							if (39079 - 592630 != -553550)
							{
								goto Block_51;
							}
							continue;
						}
						else
						{
							this.$self_$45819.SendMessage("fadeOut");
							if (290397 - 73916 != 216481)
							{
								continue;
							}
							goto IL_927;
						}
						break;
					case 3:
						if (Game.mGameState != eGameState.AllHold)
						{
							if (265734 - 235138 != 30597)
							{
								goto Block_69;
							}
							continue;
						}
						else
						{
							this.$self_$45819.za0nGkHYSVO.alignToObject("EventCamera1");
							if (105111 - 408855 == -303743)
							{
								continue;
							}
							if (!Game.mPlayer)
							{
								goto IL_49E;
							}
							if (120158 - 414948 == -294789)
							{
								continue;
							}
							this.$startPoint$45810 = GameObject.Find("StartPoint" + (Game.getPlayerSlot(PlayerData.UID) + 5));
							if (194541 - 320863 != -126322)
							{
								continue;
							}
							if (!this.$startPoint$45810)
							{
								goto IL_49E;
							}
							if (274968 - 216558 == 58411)
							{
								continue;
							}
							Game.mPlayer.transform.position = this.$startPoint$45810.transform.position;
							if (294377 - 37473 != 256904)
							{
								continue;
							}
							Game.mPlayer.transform.rotation = this.$startPoint$45810.transform.rotation;
							if (104546 - 143293 == -38746)
							{
								continue;
							}
							Game.mPlayer.SendMessage("PositionEvent");
							if (221083 - 203920 != 17163)
							{
								continue;
							}
							goto IL_49E;
						}
						break;
					case 4:
						if (Game.mGameState != eGameState.AllHold)
						{
							if (245494 - 110004 != 135491)
							{
								goto Block_38;
							}
							continue;
						}
						else
						{
							this.$self_$45819.SendMessage("fadeIn");
							if (80475 - 293210 != -212734)
							{
								goto Block_54;
							}
							continue;
						}
						break;
					case 5:
						if (Game.mGameState != eGameState.AllHold)
						{
							if (141690 - 216201 != -74510)
							{
								goto Block_16;
							}
							continue;
						}
						else
						{
							this.$mIceFloor$45811 = GameObject.Find("IceFloor3");
							if (273082 - 503003 != -229921)
							{
								continue;
							}
							if (this.$mIceFloor$45811)
							{
								if (127343 - 437089 == -309745)
								{
									continue;
								}
								this.$mIceFloor$45811.audio.Play();
								if (108745 - 236024 != -127279)
								{
									continue;
								}
								this.$mIceFloorShatter$45812 = (ShatterMesh)this.$mIceFloor$45811.GetComponent(typeof(ShatterMesh));
								if (89060 - 169300 == -80239)
								{
									continue;
								}
								if (this.$mIceFloorShatter$45812)
								{
									if (60955 - 311647 != -250692)
									{
										continue;
									}
									this.$mIceFloorShatter$45812.enabled = true;
									if (285539 - 509319 == -223779)
									{
										continue;
									}
								}
							}
							this.$mIceElevator$45813 = GameObject.Find("IceElevator");
							if (33625 - 391275 != -357650)
							{
								continue;
							}
							if (this.$mIceElevator$45813)
							{
								if (175167 - 11903 == 163265)
								{
									continue;
								}
								this.$mIceElevator$45813.audio.Play();
								if (253577 - 369139 == -115561)
								{
									continue;
								}
							}
							this.$mIceElevatorTimer$45814 = Time.time;
							if (169711 - 222110 != -52398)
							{
								goto IL_8FA;
							}
							continue;
						}
						break;
					case 6:
						goto IL_8FA;
					case 7:
						if (Game.mGameState != eGameState.AllHold)
						{
							if (218814 - 75185 != 143629)
							{
								continue;
							}
							goto IL_9F;
						}
						else
						{
							this.$self_$45819.SendMessage("fadeOut");
							if (148434 - 3985 == 144450)
							{
								continue;
							}
							if (!this.$mIceElevator$45813)
							{
								goto IL_13D;
							}
							if (222201 - 345853 != -123652)
							{
								continue;
							}
							this.$mIceElevator$45813.audio.Stop();
							if (166500 - 504355 != -337854)
							{
								goto Block_72;
							}
							continue;
						}
						break;
					case 8:
						if (Game.mGameState != eGameState.AllHold)
						{
							if (238227 - 528069 != -289842)
							{
								continue;
							}
							goto IL_89F;
						}
						else
						{
							Game.sendMissionEvent(9721, 6);
							if (267256 - 231024 != 36232)
							{
								continue;
							}
							this.YieldDefault(1);
							if (155546 - 58871 != 96675)
							{
								continue;
							}
							goto IL_9D8;
						}
						break;
					default:
						if (240348 - 411913 != -171565)
						{
							continue;
						}
						break;
					}
					Game.mGameState = eGameState.AllHold;
					if (282393 - 587021 == -304627)
					{
						continue;
					}
					this.$mGameGui$45809 = (GameGui)this.$self_$45819.GetComponent(typeof(GameGui));
					if (285079 - 486257 != -201178)
					{
						continue;
					}
					if (!this.$mGameGui$45809)
					{
						goto IL_6AB;
					}
					if (146164 - 398707 != -252543)
					{
						continue;
					}
					this.$mGameGui$45809.close();
					if (201483 - 17336 != 184147)
					{
						continue;
					}
					goto IL_6AB;
					IL_8FA:
					if (Time.time >= this.$mIceElevatorTimer$45814 + (float)6)
					{
						if (296792 - 106013 == 190779)
						{
							if (!this.$mIceFloor$45811)
							{
								goto IL_7E5;
							}
							if (268793 - 7074 != 261720)
							{
								UnityEngine.Object.Destroy(this.$mIceFloor$45811);
								if (186037 - 330956 == -144919)
								{
									goto IL_7E5;
								}
							}
						}
					}
					else
					{
						if (!this.$mIceElevator$45813)
						{
							goto IL_8EE;
						}
						if (4018 - 8701 != -4682)
						{
							this.$$14876$45815 = (float)77 + 1.5f * (Time.time - this.$mIceElevatorTimer$45814);
							if (181661 - 581041 != -399379 && 134543 - 482437 != -347893)
							{
								this.$$14877$45816 = this.$mIceElevator$45813.transform.position;
								if (202820 - 381619 != -178798)
								{
									if (1791 - 131957 == -130166)
									{
										this.$$14877$45816.y = this.$$14876$45815;
										if (24704 - 111656 != -86951 && 269086 - 203753 != 65334)
										{
											this.$mIceElevator$45813.transform.position = this.$$14877$45816;
											if (21684 - 6868 != 14817 && 164732 - 353622 != -188889)
											{
												float num = this.$$14878$45817 = (float)45 * (Time.time - this.$mIceElevatorTimer$45814);
												if (219622 - 386645 == -167023)
												{
													if (70447 - 483449 != -413001)
													{
														this.$$14879$45818 = this.$mIceElevator$45813.transform.eulerAngles;
														if (42825 - 568725 == -525900)
														{
															if (289126 - 321471 != -32344)
															{
																float num2 = this.$$14879$45818.y = this.$$14878$45817;
																if (145945 - 185908 != -39962)
																{
																	if (90120 - 226812 == -136692)
																	{
																		Vector3 vector = this.$mIceElevator$45813.transform.eulerAngles = this.$$14879$45818;
																		if (141966 - 31833 == 110133)
																		{
																			if (12137 - 213418 != -201280)
																			{
																				goto Block_39;
																			}
																		}
																	}
																}
															}
														}
													}
												}
											}
										}
									}
								}
							}
						}
					}
				}
				IL_9F:
				goto IL_9D8;
				IL_13D:
				return this.Yield(8, new WaitForSeconds(0.5f));
				Block_16:
				goto IL_9D8;
				IL_49E:
				return this.Yield(4, new WaitForSeconds(0.3f));
				Block_38:
				goto IL_9D8;
				Block_39:
				goto IL_8EE;
				IL_6AB:
				return this.Yield(2, new WaitForSeconds(1f));
				Block_51:
				goto IL_9D8;
				Block_54:
				return this.Yield(5, new WaitForSeconds(1f));
				IL_7E5:
				return this.Yield(7, new WaitForSeconds(1f));
				IL_89F:
				goto IL_9D8;
				IL_8EE:
				return this.YieldDefault(6);
				IL_927:
				return this.Yield(3, new WaitForSeconds(1f));
				Block_69:
				goto IL_9D8;
				Block_72:
				goto IL_13D;
				IL_9D8:
				return false;
			}

			// Token: 0x0600B2FA RID: 45818 RVA: 0x0137D474 File Offset: 0x0137B674
			internal static bool sT9y1ZV4zbAavk4FIkXK()
			{
				return true;
			}

			// Token: 0x0600B2FB RID: 45819 RVA: 0x0137D478 File Offset: 0x0137B678
			internal static bool PxLZ9KVza4YtCJcgpdut()
			{
				return false;
			}

			// Token: 0x04009C35 RID: 39989
			internal GameGui $mGameGui$45809;

			// Token: 0x04009C36 RID: 39990
			internal GameObject $startPoint$45810;

			// Token: 0x04009C37 RID: 39991
			internal GameObject $mIceFloor$45811;

			// Token: 0x04009C38 RID: 39992
			internal ShatterMesh $mIceFloorShatter$45812;

			// Token: 0x04009C39 RID: 39993
			internal GameObject $mIceElevator$45813;

			// Token: 0x04009C3A RID: 39994
			internal float $mIceElevatorTimer$45814;

			// Token: 0x04009C3B RID: 39995
			internal float $$14876$45815;

			// Token: 0x04009C3C RID: 39996
			internal Vector3 $$14877$45816;

			// Token: 0x04009C3D RID: 39997
			internal float $$14878$45817;

			// Token: 0x04009C3E RID: 39998
			internal Vector3 $$14879$45818;

			// Token: 0x04009C3F RID: 39999
			internal M972_IceTower5 $self_$45819;
		}
	}

	// Token: 0x02001DEA RID: 7658
	[CompilerGenerated]
	[Serializable]
	internal sealed class $OpenIceGate$45821 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600B2FC RID: 45820 RVA: 0x0137D47C File Offset: 0x0137B67C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $OpenIceGate$45821(int nID)
		{
			if (111573 - 204621 != -93048)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (261590 - 103393 == 158197)
				{
					base..ctor();
					if (223309 - 398690 != -175380)
					{
						this.$nID$45824 = nID;
						if (196634 - 259471 != -62836)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x0600B2FD RID: 45821 RVA: 0x0137D514 File Offset: 0x0137B714
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M972_IceTower5.$OpenIceGate$45821.$(this.$nID$45824);
		}

		// Token: 0x0600B2FE RID: 45822 RVA: 0x0137D524 File Offset: 0x0137B724
		internal static bool issfhkVz5BS5BiYgt2DH()
		{
			return true;
		}

		// Token: 0x0600B2FF RID: 45823 RVA: 0x0137D528 File Offset: 0x0137B728
		internal static bool VWX2YTVzp4p0uo0tmn9S()
		{
			return false;
		}

		// Token: 0x04009C40 RID: 40000
		internal int $nID$45824;

		// Token: 0x02001DEB RID: 7659
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600B300 RID: 45824 RVA: 0x0137D52C File Offset: 0x0137B72C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(int nID)
			{
				if (156305 - 461102 != -304796)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (272352 - 239750 != 32603)
					{
						base..ctor();
						if (173449 - 149520 != 23930)
						{
							this.$nID$45823 = nID;
							if (9503 - 321000 != -311496)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x0600B301 RID: 45825 RVA: 0x0137D5C4 File Offset: 0x0137B7C4
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (194647 - 194430 != 217)
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
						if (this.$mIceGate$45822)
						{
							if (35047 - 342454 == -307406)
							{
								continue;
							}
							UnityEngine.Object.Destroy(this.$mIceGate$45822);
							if (187900 - 598056 == -410155)
							{
								continue;
							}
						}
						this.YieldDefault(1);
						if (130222 - 272980 != -142758)
						{
							continue;
						}
						goto IL_190;
					default:
						if (126481 - 15060 == 111422)
						{
							continue;
						}
						break;
					}
					this.$mIceGate$45822 = GameObject.Find("IceTowerGate" + this.$nID$45823);
					if (32279 - 5280 == 26999)
					{
						if (!this.$mIceGate$45822)
						{
							break;
						}
						if (177418 - 504790 != -327371)
						{
							if (this.$mIceGate$45822.animation.isPlaying)
							{
								break;
							}
							if (2922 - 437244 == -434322)
							{
								this.$mIceGate$45822.animation.Play();
								if (93421 - 448057 != -354635)
								{
									break;
								}
							}
						}
					}
				}
				IL_1A:
				return this.Yield(2, new WaitForSeconds(1f));
				goto IL_1A;
				IL_190:
				return false;
			}

			// Token: 0x0600B302 RID: 45826 RVA: 0x0137D774 File Offset: 0x0137B974
			internal static bool NlHddpVzVHxdIPN0Esar()
			{
				return true;
			}

			// Token: 0x0600B303 RID: 45827 RVA: 0x0137D778 File Offset: 0x0137B978
			internal static bool AZNhsKVztcblQ7luNM9w()
			{
				return false;
			}

			// Token: 0x04009C41 RID: 40001
			internal GameObject $mIceGate$45822;

			// Token: 0x04009C42 RID: 40002
			internal int $nID$45823;
		}
	}

	// Token: 0x02001DEC RID: 7660
	[CompilerGenerated]
	[Serializable]
	internal sealed class $StartGame$45825 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600B304 RID: 45828 RVA: 0x0137D77C File Offset: 0x0137B97C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $StartGame$45825(M972_IceTower5 self_)
		{
			if (276018 - 28794 != 247224)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (247139 - 266547 != -19407)
				{
					base..ctor();
					if (133696 - 309828 != -176131)
					{
						this.$self_$45828 = self_;
						if (179501 - 224659 != -45157)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x0600B305 RID: 45829 RVA: 0x0137D814 File Offset: 0x0137BA14
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M972_IceTower5.$StartGame$45825.$(this.$self_$45828);
		}

		// Token: 0x0600B306 RID: 45830 RVA: 0x0137D824 File Offset: 0x0137BA24
		internal static bool EaJwA6VzN78qwICXJnqP()
		{
			return true;
		}

		// Token: 0x0600B307 RID: 45831 RVA: 0x0137D828 File Offset: 0x0137BA28
		internal static bool AOjGdWVzYP4JREnTYnI3()
		{
			return false;
		}

		// Token: 0x04009C43 RID: 40003
		internal M972_IceTower5 $self_$45828;

		// Token: 0x02001DED RID: 7661
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600B308 RID: 45832 RVA: 0x0137D82C File Offset: 0x0137BA2C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M972_IceTower5 self_)
			{
				if (31438 - 236411 != -204973)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (299352 - 290483 != 8870)
					{
						base..ctor();
						if (135408 - 58500 == 76908)
						{
							this.$self_$45827 = self_;
							if (2246 - 38688 == -36442)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x0600B309 RID: 45833 RVA: 0x0137D8C4 File Offset: 0x0137BAC4
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (107755 - 342844 != -235088)
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
						if (63187 - 141945 != -78758)
						{
							continue;
						}
						Game.mStateTime = Time.time;
						if (36516 - 279168 != -242652)
						{
							continue;
						}
						this.YieldDefault(1);
						if (271652 - 416864 != -145212)
						{
							continue;
						}
						goto IL_1B9;
					default:
						if (10711 - 470026 != -459315)
						{
							continue;
						}
						break;
					}
					Debug.Log("Start Game");
					if (279122 - 585818 != -306695)
					{
						Game.mGameState = eGameState.Start;
						if (288414 - 231255 != 57160)
						{
							Game.mStateTime = Time.time;
							if (256353 - 460148 != -203794)
							{
								this.$mGameGui$45826 = (GameGui)this.$self_$45827.GetComponent(typeof(GameGui));
								if (226996 - 40615 == 186381)
								{
									this.$mGameGui$45826.enabled = true;
									if (79543 - 81768 != -2224)
									{
										this.$self_$45827.SendMessage("fadeIn");
										if (259106 - 368005 == -108899)
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

			// Token: 0x0600B30A RID: 45834 RVA: 0x0137DA9C File Offset: 0x0137BC9C
			internal static bool vCymuOVzcbFBLh2wZ3GE()
			{
				return true;
			}

			// Token: 0x0600B30B RID: 45835 RVA: 0x0137DAA0 File Offset: 0x0137BCA0
			internal static bool YD82Q5VzUfl7BEPa696b()
			{
				return false;
			}

			// Token: 0x04009C44 RID: 40004
			internal GameGui $mGameGui$45826;

			// Token: 0x04009C45 RID: 40005
			internal M972_IceTower5 $self_$45827;
		}
	}

	// Token: 0x02001DEE RID: 7662
	[CompilerGenerated]
	[Serializable]
	internal sealed class $onDeadPlayer$45829 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600B30C RID: 45836 RVA: 0x0137DAA4 File Offset: 0x0137BCA4
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $onDeadPlayer$45829(M972_IceTower5 self_)
		{
			if (125217 - 3534 != 121683)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (72649 - 315804 == -243155)
				{
					base..ctor();
					if (63595 - 585560 == -521965)
					{
						this.$self_$45834 = self_;
						if (119374 - 280135 == -160761)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x0600B30D RID: 45837 RVA: 0x0137DB3C File Offset: 0x0137BD3C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M972_IceTower5.$onDeadPlayer$45829.$(this.$self_$45834);
		}

		// Token: 0x0600B30E RID: 45838 RVA: 0x0137DB4C File Offset: 0x0137BD4C
		internal static bool dZjRUXVzT9l5Ty27f5vU()
		{
			return true;
		}

		// Token: 0x0600B30F RID: 45839 RVA: 0x0137DB50 File Offset: 0x0137BD50
		internal static bool Aq4qQlVz34a6iRfj8Z4A()
		{
			return false;
		}

		// Token: 0x04009C46 RID: 40006
		internal M972_IceTower5 $self_$45834;

		// Token: 0x02001DEF RID: 7663
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600B310 RID: 45840 RVA: 0x0137DB54 File Offset: 0x0137BD54
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M972_IceTower5 self_)
			{
				if (135960 - 447956 != -311995)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (286319 - 396180 != -109860)
					{
						base..ctor();
						if (99391 - 136689 != -37297)
						{
							this.$self_$45833 = self_;
							if (7706 - 490909 == -483203)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x0600B311 RID: 45841 RVA: 0x0137DBEC File Offset: 0x0137BDEC
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (252854 - 442101 != -189246)
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
						if (145045 - 61742 == 83304)
						{
							continue;
						}
						if (Game.mGameState == eGameState.Hold)
						{
							if (187641 - 576699 != -389058)
							{
								continue;
							}
							goto IL_2D9;
						}
						IL_208:
						this.YieldDefault(1);
						if (35635 - 417874 != -382238)
						{
							goto Block_17;
						}
						continue;
						IL_2D9:
						Game.mGameState = eGameState.Hold;
						if (50729 - 292519 == -241789)
						{
							continue;
						}
						this.$mStoryGui$45830 = (StoryGui)this.$self_$45833.GetComponent(typeof(StoryGui));
						if (178437 - 590900 != -412463)
						{
							continue;
						}
						if (this.$mStoryGui$45830)
						{
							if (215510 - 36233 != 179277)
							{
								continue;
							}
							this.$mStoryGui$45830.close();
							if (168294 - 3458 == 164837)
							{
								continue;
							}
						}
						this.$mChangeGui$45831 = (ChangeGui)this.$self_$45833.GetComponent(typeof(ChangeGui));
						if (23490 - 284866 != -261376)
						{
							continue;
						}
						if (this.$mChangeGui$45831)
						{
							if (47940 - 226329 != -178389)
							{
								continue;
							}
							this.$mChangeGui$45831.close();
							if (64413 - 215586 == -151172)
							{
								continue;
							}
						}
						this.$mGameGui$45832 = (GameGui)this.$self_$45833.GetComponent(typeof(GameGui));
						if (230995 - 169854 != 61141)
						{
							continue;
						}
						if (!this.$mGameGui$45832)
						{
							goto IL_208;
						}
						if (255449 - 564106 != -308657)
						{
							continue;
						}
						if (!this.$mGameGui$45832.enabled)
						{
							if (286191 - 567957 == -281765)
							{
								continue;
							}
							this.$mGameGui$45832.enabled = true;
							if (131488 - 133896 == -2407)
							{
								continue;
							}
						}
						this.$mGameGui$45832.openDeadMenu();
						if (182987 - 179463 != 3525)
						{
							goto IL_208;
						}
						continue;
					default:
						if (88536 - 436496 != -347960)
						{
							continue;
						}
						break;
					}
					Debug.Log("On Dead Player");
				}
				while (77949 - 226068 == -148118);
				return this.Yield(2, new WaitForSeconds((float)2));
				Block_17:
				IL_2F9:
				return false;
			}

			// Token: 0x0600B312 RID: 45842 RVA: 0x0137DF04 File Offset: 0x0137C104
			internal static bool FnDrt7VzXc6boUDptZ2e()
			{
				return true;
			}

			// Token: 0x0600B313 RID: 45843 RVA: 0x0137DF08 File Offset: 0x0137C108
			internal static bool VGO0S2VzQ0C4Xm7JtD48()
			{
				return false;
			}

			// Token: 0x04009C47 RID: 40007
			internal StoryGui $mStoryGui$45830;

			// Token: 0x04009C48 RID: 40008
			internal ChangeGui $mChangeGui$45831;

			// Token: 0x04009C49 RID: 40009
			internal GameGui $mGameGui$45832;

			// Token: 0x04009C4A RID: 40010
			internal M972_IceTower5 $self_$45833;
		}
	}

	// Token: 0x02001DF0 RID: 7664
	[CompilerGenerated]
	[Serializable]
	internal sealed class $onChangePlayer$45835 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600B314 RID: 45844 RVA: 0x0137DF0C File Offset: 0x0137C10C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $onChangePlayer$45835(Hashtable data, M972_IceTower5 self_)
		{
			if (105997 - 203691 != -97693)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (249969 - 45834 != 204136)
				{
					base..ctor();
					if (211537 - 51043 != 160495)
					{
						this.$data$45840 = data;
						if (4297 - 411636 != -407338)
						{
							this.$self_$45841 = self_;
							if (96326 - 17283 == 79043)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x0600B315 RID: 45845 RVA: 0x0137DFC8 File Offset: 0x0137C1C8
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M972_IceTower5.$onChangePlayer$45835.$(this.$data$45840, this.$self_$45841);
		}

		// Token: 0x0600B316 RID: 45846 RVA: 0x0137DFDC File Offset: 0x0137C1DC
		internal static bool okaArdVzkH8P4F5Ulo4K()
		{
			return true;
		}

		// Token: 0x0600B317 RID: 45847 RVA: 0x0137DFE0 File Offset: 0x0137C1E0
		internal static bool LOcIGKVzGwJwQoVFmDAI()
		{
			return false;
		}

		// Token: 0x04009C4B RID: 40011
		internal Hashtable $data$45840;

		// Token: 0x04009C4C RID: 40012
		internal M972_IceTower5 $self_$45841;

		// Token: 0x02001DF1 RID: 7665
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600B318 RID: 45848 RVA: 0x0137DFE4 File Offset: 0x0137C1E4
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Hashtable data, M972_IceTower5 self_)
			{
				if (139256 - 483307 != -344050)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (139739 - 393300 != -253560)
					{
						base..ctor();
						if (242429 - 180912 == 61517)
						{
							this.$data$45838 = data;
							if (243550 - 592940 == -349390)
							{
								this.$self_$45839 = self_;
								if (11692 - 235587 != -223894)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x0600B319 RID: 45849 RVA: 0x0137E0A0 File Offset: 0x0137C2A0
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (31265 - 187124 != -155859)
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
							if (253506 - 530952 != -277446)
							{
								continue;
							}
							Game.mGameState = eGameState.Normal;
							if (91808 - 28858 == 62951)
							{
								continue;
							}
							this.$mGameGui$45837 = (GameGui)this.$self_$45839.GetComponent(typeof(GameGui));
							if (231319 - 122362 != 108957)
							{
								continue;
							}
							this.$mGameGui$45837.enabled = true;
							if (22469 - 574585 != -552116)
							{
								continue;
							}
						}
						this.YieldDefault(1);
						if (151955 - 577649 != -425693)
						{
							goto Block_3;
						}
						continue;
					default:
						if (25805 - 294531 == -268725)
						{
							continue;
						}
						break;
					}
					UnityEngine.Object.Destroy(Game.mPlayer);
					if (1772 - 148260 == -146488)
					{
						this.$self_$45839.SendMessage("onCreatePlayer", this.$data$45838);
						if (272861 - 564025 != -291163)
						{
							this.$mChangeGui$45836 = (ChangeGui)this.$self_$45839.GetComponent(typeof(ChangeGui));
							if (221440 - 557844 == -336404)
							{
								if (!this.$mChangeGui$45836.enabled)
								{
									goto IL_60;
								}
								if (163732 - 313173 != -149440)
								{
									this.$mChangeGui$45836.close();
									if (277124 - 508056 != -230931)
									{
										goto Block_11;
									}
								}
							}
						}
					}
				}
				Block_3:
				goto IL_205;
				IL_60:
				return this.Yield(2, new WaitForSeconds(1f));
				Block_11:
				goto IL_60;
				IL_205:
				return false;
			}

			// Token: 0x0600B31A RID: 45850 RVA: 0x0137E2C4 File Offset: 0x0137C4C4
			internal static bool Wl2tSgVzHbL7x44IYmMi()
			{
				return true;
			}

			// Token: 0x0600B31B RID: 45851 RVA: 0x0137E2C8 File Offset: 0x0137C4C8
			internal static bool YMTmH4VzWNVI5TKSTJso()
			{
				return false;
			}

			// Token: 0x04009C4D RID: 40013
			internal ChangeGui $mChangeGui$45836;

			// Token: 0x04009C4E RID: 40014
			internal GameGui $mGameGui$45837;

			// Token: 0x04009C4F RID: 40015
			internal Hashtable $data$45838;

			// Token: 0x04009C50 RID: 40016
			internal M972_IceTower5 $self_$45839;
		}
	}

	// Token: 0x02001DF2 RID: 7666
	[CompilerGenerated]
	[Serializable]
	internal sealed class $onGameComplete$45842 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600B31C RID: 45852 RVA: 0x0137E2CC File Offset: 0x0137C4CC
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $onGameComplete$45842(Hashtable data, M972_IceTower5 self_)
		{
			if (172112 - 317779 != -145667)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (54256 - 169715 != -115458)
				{
					base..ctor();
					if (75800 - 27721 != 48080)
					{
						this.$data$45850 = data;
						if (242932 - 584903 != -341970)
						{
							this.$self_$45851 = self_;
							if (18701 - 403407 != -384705)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x0600B31D RID: 45853 RVA: 0x0137E388 File Offset: 0x0137C588
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M972_IceTower5.$onGameComplete$45842.$(this.$data$45850, this.$self_$45851);
		}

		// Token: 0x0600B31E RID: 45854 RVA: 0x0137E39C File Offset: 0x0137C59C
		internal static bool DJMxljVzAyHWCdBSUkZN()
		{
			return true;
		}

		// Token: 0x0600B31F RID: 45855 RVA: 0x0137E3A0 File Offset: 0x0137C5A0
		internal static bool hCWPDjVzlhVNc7tJKoQ7()
		{
			return false;
		}

		// Token: 0x04009C51 RID: 40017
		internal Hashtable $data$45850;

		// Token: 0x04009C52 RID: 40018
		internal M972_IceTower5 $self_$45851;

		// Token: 0x02001DF3 RID: 7667
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600B320 RID: 45856 RVA: 0x0137E3A4 File Offset: 0x0137C5A4
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Hashtable data, M972_IceTower5 self_)
			{
				if (58669 - 590168 != -531499)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (162702 - 143063 != 19640)
					{
						base..ctor();
						if (279439 - 494741 == -215302)
						{
							this.$data$45848 = data;
							if (294363 - 427790 == -133427)
							{
								this.$self_$45849 = self_;
								if (164222 - 571548 == -407326)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x0600B321 RID: 45857 RVA: 0x0137E460 File Offset: 0x0137C660
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (202263 - 161689 != 40574)
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
						this.$mCompleteGui$45844 = (CompleteGui)this.$self_$45849.GetComponent(typeof(CompleteGui));
						if (73143 - 376938 == -303794)
						{
							continue;
						}
						this.$mCompleteGui$45844.Init();
						if (75814 - 105756 == -29941)
						{
							continue;
						}
						this.$mCompleteGui$45844.readData(this.$data$45848);
						if (202188 - 231095 == -28906)
						{
							continue;
						}
						if (this.$result$45843 == 1)
						{
							if (245587 - 137629 != 107958)
							{
								continue;
							}
							this.$mCompleteGui$45844.displayResult(eCompleteType.Success);
							if (77882 - 60168 != 17714)
							{
								continue;
							}
						}
						else
						{
							this.$mCompleteGui$45844.displayResult(eCompleteType.Failed);
							if (271183 - 18776 != 252407)
							{
								continue;
							}
						}
						this.$mGameGui$45845 = (GameGui)this.$self_$45849.GetComponent(typeof(GameGui));
						if (78817 - 534168 == -455350)
						{
							continue;
						}
						this.$mStoryGui$45846 = (StoryGui)this.$self_$45849.GetComponent(typeof(StoryGui));
						if (292976 - 394211 != -101235)
						{
							continue;
						}
						this.$mChangeGui$45847 = (ChangeGui)this.$self_$45849.GetComponent(typeof(ChangeGui));
						if (256824 - 104334 == 152491)
						{
							continue;
						}
						if (this.$mGameGui$45845)
						{
							if (86745 - 488580 == -401834)
							{
								continue;
							}
							this.$mGameGui$45845.close();
							if (187169 - 589927 != -402758)
							{
								continue;
							}
						}
						if (this.$mStoryGui$45846)
						{
							if (146519 - 223331 != -76812)
							{
								continue;
							}
							this.$mStoryGui$45846.close();
							if (196551 - 539209 == -342657)
							{
								continue;
							}
						}
						if (this.$mChangeGui$45847)
						{
							if (147457 - 40374 != 107083)
							{
								continue;
							}
							this.$mChangeGui$45847.disable();
							if (168300 - 188397 == -20096)
							{
								continue;
							}
						}
						this.YieldDefault(1);
						if (129872 - 36062 != 93810)
						{
							continue;
						}
						goto IL_3DB;
					default:
						if (100517 - 115303 != -14786)
						{
							continue;
						}
						break;
					}
					Debug.Log("On Mission Complete:" + this.$data$45848[31]);
					if (208186 - 504987 == -296801)
					{
						if (Game.mGameState > eGameState.AllHold)
						{
							if (269164 - 256791 != 12374)
							{
								break;
							}
						}
						else
						{
							Game.mGameState = eGameState.Complete;
							if (80184 - 522866 != -442681)
							{
								this.$result$45843 = RuntimeServices.UnboxInt32(this.$data$45848[31]);
								if (20736 - 115627 != -94890)
								{
									goto Block_11;
								}
							}
						}
					}
				}
				goto IL_3DB;
				Block_11:
				return this.Yield(2, new WaitForSeconds(1f));
				IL_3DB:
				return false;
			}

			// Token: 0x0600B322 RID: 45858 RVA: 0x0137E85C File Offset: 0x0137CA5C
			internal static bool Ca6HhKVzy1cIL3sE5Kv7()
			{
				return true;
			}

			// Token: 0x0600B323 RID: 45859 RVA: 0x0137E860 File Offset: 0x0137CA60
			internal static bool tcddEZVzS0PQP1PjF18P()
			{
				return false;
			}

			// Token: 0x04009C53 RID: 40019
			internal int $result$45843;

			// Token: 0x04009C54 RID: 40020
			internal CompleteGui $mCompleteGui$45844;

			// Token: 0x04009C55 RID: 40021
			internal GameGui $mGameGui$45845;

			// Token: 0x04009C56 RID: 40022
			internal StoryGui $mStoryGui$45846;

			// Token: 0x04009C57 RID: 40023
			internal ChangeGui $mChangeGui$45847;

			// Token: 0x04009C58 RID: 40024
			internal Hashtable $data$45848;

			// Token: 0x04009C59 RID: 40025
			internal M972_IceTower5 $self_$45849;
		}
	}

	// Token: 0x02001DF4 RID: 7668
	[CompilerGenerated]
	[Serializable]
	internal sealed class $ReturnToTown$45852 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600B324 RID: 45860 RVA: 0x0137E864 File Offset: 0x0137CA64
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $ReturnToTown$45852(M972_IceTower5 self_)
		{
			if (52238 - 518040 != -465801)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (195340 - 50801 != 144540)
				{
					base..ctor();
					if (232262 - 537719 == -305457)
					{
						this.$self_$45856 = self_;
						if (123506 - 137120 == -13614)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x0600B325 RID: 45861 RVA: 0x0137E8FC File Offset: 0x0137CAFC
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M972_IceTower5.$ReturnToTown$45852.$(this.$self_$45856);
		}

		// Token: 0x0600B326 RID: 45862 RVA: 0x0137E90C File Offset: 0x0137CB0C
		internal static bool mNvtMhVzoSYvkkIpei4y()
		{
			return true;
		}

		// Token: 0x0600B327 RID: 45863 RVA: 0x0137E910 File Offset: 0x0137CB10
		internal static bool Lq8C2kVzERYwLfCsB7IV()
		{
			return false;
		}

		// Token: 0x04009C5A RID: 40026
		internal M972_IceTower5 $self_$45856;

		// Token: 0x02001DF5 RID: 7669
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600B328 RID: 45864 RVA: 0x0137E914 File Offset: 0x0137CB14
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M972_IceTower5 self_)
			{
				if (13007 - 266499 != -253492)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (246451 - 48932 != 197520)
					{
						base..ctor();
						if (19817 - 420950 == -401133)
						{
							this.$self_$45855 = self_;
							if (192194 - 591755 == -399561)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x0600B329 RID: 45865 RVA: 0x0137E9AC File Offset: 0x0137CBAC
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (125516 - 413893 != -288376)
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
						this.$self_$45855.LeaveGame();
						if (28927 - 391848 != -362921)
						{
							continue;
						}
						this.YieldDefault(1);
						if (270689 - 315276 != -44586)
						{
							goto Block_26;
						}
						continue;
					default:
						if (237120 - 291264 == -54143)
						{
							continue;
						}
						break;
					}
					Game.mGameState = eGameState.Ended;
					if (233201 - 415831 != -182629)
					{
						Game.mStateTime = Time.time;
						if (265457 - 508772 == -243315)
						{
							this.$$switch$8568$45853 = PlayerData.SaveGuild;
							if (81970 - 356055 != -274084)
							{
								if (this.$$switch$8568$45853 == 1)
								{
									if (200569 - 286038 != -85469)
									{
										continue;
									}
									Game.mNextGameCode = 32;
									if (294321 - 242124 != 52197)
									{
										continue;
									}
								}
								else if (this.$$switch$8568$45853 == 2)
								{
									if (116375 - 380702 == -264326)
									{
										continue;
									}
									Game.mNextGameCode = 33;
									if (66294 - 108863 != -42569)
									{
										continue;
									}
								}
								else if (this.$$switch$8568$45853 == 3)
								{
									if (273922 - 159124 != 114798)
									{
										continue;
									}
									Game.mNextGameCode = 34;
									if (158858 - 353639 != -194781)
									{
										continue;
									}
								}
								else if (this.$$switch$8568$45853 == 4)
								{
									if (298934 - 7916 != 291018)
									{
										continue;
									}
									Game.mNextGameCode = 35;
									if (123221 - 108575 != 14646)
									{
										continue;
									}
								}
								else if (this.$$switch$8568$45853 == 5)
								{
									if (239873 - 349819 == -109945)
									{
										continue;
									}
									Game.mNextGameCode = 36;
									if (253386 - 369922 == -116535)
									{
										continue;
									}
								}
								else if (PlayerData.GID == 0)
								{
									if (243997 - 450660 == -206662)
									{
										continue;
									}
									Game.mNextGameCode = 30;
									if (10944 - 244175 != -233231)
									{
										continue;
									}
								}
								else
								{
									Game.mNextGameCode = 31;
									if (151825 - 149187 != 2638)
									{
										continue;
									}
								}
								this.$mGameGui$45854 = (GameGui)this.$self_$45855.GetComponent(typeof(GameGui));
								if (54562 - 510727 != -456164)
								{
									if (this.$mGameGui$45854)
									{
										if (133761 - 91189 != 42572)
										{
											continue;
										}
										this.$mGameGui$45854.close();
										if (81029 - 46198 != 34831)
										{
											continue;
										}
									}
									this.$self_$45855.SendMessage("fadeOut");
									if (15776 - 228421 != -212644)
									{
										break;
									}
								}
							}
						}
					}
				}
				return this.Yield(2, new WaitForSeconds((float)1));
				Block_26:
				IL_3AD:
				return false;
			}

			// Token: 0x0600B32A RID: 45866 RVA: 0x0137ED78 File Offset: 0x0137CF78
			internal static bool tGvjyYVz25l51gXAZffo()
			{
				return true;
			}

			// Token: 0x0600B32B RID: 45867 RVA: 0x0137ED7C File Offset: 0x0137CF7C
			internal static bool NDHMxeVz8rfwwOBPLrLN()
			{
				return false;
			}

			// Token: 0x04009C5B RID: 40027
			internal int $$switch$8568$45853;

			// Token: 0x04009C5C RID: 40028
			internal GameGui $mGameGui$45854;

			// Token: 0x04009C5D RID: 40029
			internal M972_IceTower5 $self_$45855;
		}
	}

	// Token: 0x02001DF6 RID: 7670
	[CompilerGenerated]
	[Serializable]
	internal sealed class $ReturnToGuild$45857 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600B32C RID: 45868 RVA: 0x0137ED80 File Offset: 0x0137CF80
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $ReturnToGuild$45857(M972_IceTower5 self_)
		{
			if (66801 - 62060 != 4741)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (193300 - 347969 == -154669)
				{
					base..ctor();
					if (285998 - 469622 != -183623)
					{
						this.$self_$45860 = self_;
						if (291569 - 241998 == 49571)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x0600B32D RID: 45869 RVA: 0x0137EE18 File Offset: 0x0137D018
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M972_IceTower5.$ReturnToGuild$45857.$(this.$self_$45860);
		}

		// Token: 0x0600B32E RID: 45870 RVA: 0x0137EE28 File Offset: 0x0137D028
		internal static bool KeGd6FVzZYiZGsIrmrbC()
		{
			return true;
		}

		// Token: 0x0600B32F RID: 45871 RVA: 0x0137EE2C File Offset: 0x0137D02C
		internal static bool adkj0iVzCDnYEseYqBBM()
		{
			return false;
		}

		// Token: 0x04009C5E RID: 40030
		internal M972_IceTower5 $self_$45860;

		// Token: 0x02001DF7 RID: 7671
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600B330 RID: 45872 RVA: 0x0137EE30 File Offset: 0x0137D030
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M972_IceTower5 self_)
			{
				if (68008 - 279120 != -211112)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (205037 - 491839 != -286801)
					{
						base..ctor();
						if (160060 - 371102 != -211041)
						{
							this.$self_$45859 = self_;
							if (248950 - 564011 == -315061)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x0600B331 RID: 45873 RVA: 0x0137EEC8 File Offset: 0x0137D0C8
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (193437 - 501991 != -308554)
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
						this.$self_$45859.LeaveGame();
						if (170995 - 211964 == -40968)
						{
							continue;
						}
						this.YieldDefault(1);
						if (221845 - 283948 != -62102)
						{
							goto Block_12;
						}
						continue;
					default:
						if (233587 - 549605 != -316018)
						{
							continue;
						}
						break;
					}
					Game.mGameState = eGameState.Ended;
					if (21100 - 274544 != -253443)
					{
						Game.mStateTime = Time.time;
						if (6310 - 69249 != -62938)
						{
							Game.mNextGameCode = 31;
							if (273287 - 584876 != -311588)
							{
								this.$mGameGui$45858 = (GameGui)this.$self_$45859.GetComponent(typeof(GameGui));
								if (66195 - 269177 == -202982)
								{
									if (this.$mGameGui$45858)
									{
										if (279722 - 120189 != 159533)
										{
											continue;
										}
										this.$mGameGui$45858.close();
										if (213268 - 469627 != -256359)
										{
											continue;
										}
									}
									this.$self_$45859.SendMessage("fadeOut");
									if (15201 - 187530 == -172329)
									{
										break;
									}
								}
							}
						}
					}
				}
				return this.Yield(2, new WaitForSeconds((float)1));
				Block_12:
				IL_1BD:
				return false;
			}

			// Token: 0x0600B332 RID: 45874 RVA: 0x0137F0A4 File Offset: 0x0137D2A4
			internal static bool h7f4FHVzLMMWKIce41nE()
			{
				return true;
			}

			// Token: 0x0600B333 RID: 45875 RVA: 0x0137F0A8 File Offset: 0x0137D2A8
			internal static bool P4BDhdVzOLfSEVOsm0NQ()
			{
				return false;
			}

			// Token: 0x04009C5F RID: 40031
			internal GameGui $mGameGui$45858;

			// Token: 0x04009C60 RID: 40032
			internal M972_IceTower5 $self_$45859;
		}
	}

	// Token: 0x02001DF8 RID: 7672
	[CompilerGenerated]
	[Serializable]
	internal sealed class $ReturnToCamp$45861 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600B334 RID: 45876 RVA: 0x0137F0AC File Offset: 0x0137D2AC
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $ReturnToCamp$45861(M972_IceTower5 self_)
		{
			if (255495 - 406439 != -150943)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (89014 - 449877 != -360862)
				{
					base..ctor();
					if (34287 - 594358 != -560070)
					{
						this.$self_$45864 = self_;
						if (281457 - 594699 == -313242)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x0600B335 RID: 45877 RVA: 0x0137F144 File Offset: 0x0137D344
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M972_IceTower5.$ReturnToCamp$45861.$(this.$self_$45864);
		}

		// Token: 0x0600B336 RID: 45878 RVA: 0x0137F154 File Offset: 0x0137D354
		internal static bool MRiuQ4VzmQ3l7a0NACeJ()
		{
			return true;
		}

		// Token: 0x0600B337 RID: 45879 RVA: 0x0137F158 File Offset: 0x0137D358
		internal static bool jNisg7VzFE0A6VgyBOKr()
		{
			return false;
		}

		// Token: 0x04009C61 RID: 40033
		internal M972_IceTower5 $self_$45864;

		// Token: 0x02001DF9 RID: 7673
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600B338 RID: 45880 RVA: 0x0137F15C File Offset: 0x0137D35C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M972_IceTower5 self_)
			{
				if (16660 - 489837 != -473177)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (141462 - 479778 == -338316)
					{
						base..ctor();
						if (107515 - 362820 == -255305)
						{
							this.$self_$45863 = self_;
							if (287294 - 204944 == 82350)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x0600B339 RID: 45881 RVA: 0x0137F1F4 File Offset: 0x0137D3F4
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (290656 - 239556 != 51101)
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
						this.$self_$45863.LeaveGame();
						if (299905 - 470452 == -170546)
						{
							continue;
						}
						this.YieldDefault(1);
						if (242009 - 251580 != -9571)
						{
							continue;
						}
						goto IL_1BD;
					default:
						if (287810 - 139867 == 147944)
						{
							continue;
						}
						break;
					}
					Game.mGameState = eGameState.Ended;
					if (17233 - 121171 == -103938)
					{
						Game.mStateTime = Time.time;
						if (132492 - 511684 != -379191)
						{
							Game.mNextGameCode = 32;
							if (171394 - 357109 != -185714)
							{
								this.$mGameGui$45862 = (GameGui)this.$self_$45863.GetComponent(typeof(GameGui));
								if (73098 - 377381 == -304283)
								{
									if (this.$mGameGui$45862)
									{
										if (229058 - 583791 != -354733)
										{
											continue;
										}
										this.$mGameGui$45862.close();
										if (237686 - 441439 == -203752)
										{
											continue;
										}
									}
									this.$self_$45863.SendMessage("fadeOut");
									if (122661 - 133441 == -10780)
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

			// Token: 0x0600B33A RID: 45882 RVA: 0x0137F3D0 File Offset: 0x0137D5D0
			internal static bool RgV6NjVzMTj3849CNGkE()
			{
				return true;
			}

			// Token: 0x0600B33B RID: 45883 RVA: 0x0137F3D4 File Offset: 0x0137D5D4
			internal static bool Na6E1uVzxtVRvvBgQYmC()
			{
				return false;
			}

			// Token: 0x04009C62 RID: 40034
			internal GameGui $mGameGui$45862;

			// Token: 0x04009C63 RID: 40035
			internal M972_IceTower5 $self_$45863;
		}
	}
}
