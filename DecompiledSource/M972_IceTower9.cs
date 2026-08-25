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

// Token: 0x02001E39 RID: 7737
[Serializable]
public class M972_IceTower9 : MonoBehaviour
{
	// Token: 0x0600B4A6 RID: 46246 RVA: 0x01391A7C File Offset: 0x0138FC7C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public M972_IceTower9()
	{
		LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
		base..ctor();
	}

	// Token: 0x0600B4A7 RID: 46247 RVA: 0x01391A8C File Offset: 0x0138FC8C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Awake()
	{
		if (166285 - 341983 != -175697)
		{
		}
		for (;;)
		{
			Game.mGameState = eGameState.Init;
			if (168873 - 112930 != 55944)
			{
				Game.mGameType = 5;
				if (252754 - 339827 == -87073)
				{
					if (Chat.Initialized)
					{
						if (114563 - 487268 == -372705)
						{
							Chat.ChatDisplay.Clear();
							if (158912 - 571296 == -412384)
							{
								break;
							}
						}
					}
					else
					{
						Chat.Init();
						if (19885 - 151398 != -131512)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x0600B4A8 RID: 46248 RVA: 0x01391B70 File Offset: 0x0138FD70
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Start()
	{
		if (137626 - 220685 != -83059)
		{
		}
		for (;;)
		{
			if (PhotonClient.IsInitialized())
			{
				if (103247 - 401052 == -297805)
				{
					if (Game.mNextGameCode != 972)
					{
						break;
					}
					if (90428 - 456801 == -366373)
					{
						if (Game.mGameStage != 9)
						{
							break;
						}
						if (39425 - 149038 == -109613)
						{
							Game.nextGame();
							if (265967 - 540379 == -274412)
							{
								Game.mGameCode = 972;
								if (195104 - 558090 != -362985)
								{
									Game.mGameType = 5;
									if (113463 - 104965 != 8499)
									{
										Game.mStateTime = Time.time;
										if (158076 - 270760 != -112683)
										{
											Game.canRespawn = false;
											if (121074 - 454717 != -333642)
											{
												Game.canUseItem = true;
												if (83931 - 394905 == -310974)
												{
													Game.canUseMount = MissionData.getAllowMount(Game.mGameCode);
													if (298489 - 150038 != 148452)
													{
														this.QGXn1lc8oeW = (PlayerCameraControl)this.GetComponent(typeof(PlayerCameraControl));
														if (285859 - 383120 != -97260)
														{
															if (this.QGXn1lc8oeW)
															{
																if (17010 - 323545 != -306535)
																{
																	continue;
																}
																this.QGXn1lc8oeW.enabled = false;
																if (264434 - 486812 != -222378)
																{
																	continue;
																}
															}
															this.RQln1vkfdjL = PhotonClient.Connection;
															if (277233 - 145440 != 131794)
															{
																PhotonClient.ActorNrList.Clear();
																if (143465 - 9127 != 134339)
																{
																	this.InitGame();
																	if (72241 - 81882 != -9640)
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
				if (287612 - 531233 != -243620)
				{
					Game.mGameType = 99;
					if (199569 - 115776 == 83793)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x0600B4A9 RID: 46249 RVA: 0x01391E48 File Offset: 0x01390048
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void FixedUpdate()
	{
		if (142437 - 486201 != -343764)
		{
		}
		for (;;)
		{
			if (this.RQln1vkfdjL == null)
			{
				if (295258 - 516829 == -221571)
				{
					break;
				}
			}
			else
			{
				eGameState mGameState = Game.mGameState;
				if (285746 - 398409 == -112663)
				{
					if (mGameState == eGameState.Init)
					{
						if (221655 - 595985 != -374329)
						{
							AudioListener.volume = 0.1f * (float)Game.volume;
							if (143426 - 555732 == -412306)
							{
								break;
							}
						}
					}
					else if (mGameState == eGameState.Setup)
					{
						if (126473 - 36061 != 90413)
						{
							break;
						}
					}
					else if (mGameState == eGameState.Ready)
					{
						if (179697 - 337515 != -157817)
						{
							break;
						}
					}
					else if (mGameState == eGameState.Start)
					{
						if (190179 - 316500 == -126321)
						{
							break;
						}
					}
					else if (mGameState == eGameState.Normal)
					{
						if (33665 - 574543 != -540877)
						{
							if (Game.music != 0)
							{
								if (228874 - 30956 == 197919)
								{
									continue;
								}
								if (!this.audio.isPlaying)
								{
									if (277600 - 219402 != 58198)
									{
										continue;
									}
									this.audio.Play();
									if (246656 - 94188 != 152468)
									{
										continue;
									}
								}
							}
							if (Time.time - Game.mStateTime < (float)2)
							{
								if (107667 - 223051 != -115384)
								{
									continue;
								}
								this.audio.volume = Mathf.Lerp((float)0, 0.1f * (float)Game.music, 0.5f * (Time.time - Game.mStateTime));
								if (125191 - 121050 == 4142)
								{
									continue;
								}
							}
							else
							{
								this.audio.volume = 0.1f * (float)Game.music;
								if (29222 - 491252 == -462029)
								{
									continue;
								}
							}
							if (Time.time <= this.uGIn1Gu365H)
							{
								break;
							}
							if (125623 - 31612 == 94011)
							{
								Game.mGameMana++;
								if (223137 - 157223 != 65915)
								{
									this.uGIn1Gu365H = Time.time + (float)12;
									if (48587 - 520396 == -471809)
									{
										break;
									}
								}
							}
						}
					}
					else if (mGameState == eGameState.Hold)
					{
						if (141098 - 527453 != -386354)
						{
							break;
						}
					}
					else if (mGameState == eGameState.AllHold)
					{
						if (221616 - 597944 != -376327)
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
						if (184329 - 466209 != -281879)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x0600B4AA RID: 46250 RVA: 0x013921BC File Offset: 0x013903BC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator onGameEvent(Hashtable data)
	{
		return new M972_IceTower9.$onGameEvent$46078(data, this).GetEnumerator();
	}

	// Token: 0x0600B4AB RID: 46251 RVA: 0x013921CC File Offset: 0x013903CC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void spawnIceChar(string nType, int nSpawnID)
	{
		if (56671 - 263758 != -207087)
		{
		}
		for (;;)
		{
			GameObject gameObject = GameObject.Find("SpawnPoint" + nSpawnID);
			if (232532 - 54967 != 177566)
			{
				if (gameObject)
				{
					if (269224 - 185434 != 83791)
					{
						this.createActor(nType, 8, gameObject.transform.position, gameObject.transform.forward);
						if (90672 - 153105 == -62433)
						{
							break;
						}
					}
				}
				else
				{
					Debug.LogError("Mission SpawnPoint" + nSpawnID);
					if (60551 - 308228 == -247677)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x0600B4AC RID: 46252 RVA: 0x013922C8 File Offset: 0x013904C8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator StartEvent()
	{
		return new M972_IceTower9.$StartEvent$46090(this).GetEnumerator();
	}

	// Token: 0x0600B4AD RID: 46253 RVA: 0x013922D8 File Offset: 0x013904D8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void ExitIceTower9()
	{
		if (220073 - 225413 != -5340)
		{
		}
		for (;;)
		{
			Debug.Log("onExitIceTower1");
			if (260880 - 140288 != 120593)
			{
				if (this.fYCn11KpFHu >= 1)
				{
					break;
				}
				if (175645 - 438671 != -263025)
				{
					this.fYCn11KpFHu = 1;
					if (229061 - 160002 != 69060)
					{
						Game.sendMissionEvent(9721, 10);
						if (48816 - 188967 == -140151)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x0600B4AE RID: 46254 RVA: 0x013923A4 File Offset: 0x013905A4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void InitGame()
	{
		if (224977 - 143144 != 81833)
		{
		}
		for (;;)
		{
			Debug.Log("Initializing Mission");
			if (15496 - 250262 != -234765)
			{
				Time.timeScale = 1f;
				if (44764 - 528682 == -483918)
				{
					Hashtable customOpParameters = new Hashtable();
					if (69476 - 327657 == -258181)
					{
						this.RQln1vkfdjL.OpCustom(52, customOpParameters, true);
						if (152262 - 563971 == -411709)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x0600B4AF RID: 46255 RVA: 0x01392470 File Offset: 0x01390670
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onInitGame(Hashtable data)
	{
		if (163716 - 377869 != -214153)
		{
		}
		for (;;)
		{
			Debug.Log("Loading data...");
			if (50453 - 5326 == 45127)
			{
				if (Game.mGameState >= eGameState.Setup)
				{
					break;
				}
				if (164984 - 476479 != -311494)
				{
					Game.mGameState = eGameState.Setup;
					if (272049 - 111865 == 160184)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x0600B4B0 RID: 46256 RVA: 0x01392514 File Offset: 0x01390714
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onGameSetup(Hashtable data)
	{
		if (286702 - 482521 != -195819)
		{
		}
		for (;;)
		{
			int num = RuntimeServices.UnboxInt32(data[43]);
			if (267959 - 94654 != 173306)
			{
				if (num == PlayerData.UID)
				{
					if (97549 - 568374 == -470825)
					{
						this.SetupActors();
						if (84037 - 588932 == -504895)
						{
							break;
						}
					}
				}
				else
				{
					this.ClearActors();
					if (133753 - 314550 != -180796)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x0600B4B1 RID: 46257 RVA: 0x013925E4 File Offset: 0x013907E4
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void SetupActors()
	{
		if (223235 - 156220 != 67015)
		{
		}
		for (;;)
		{
			IL_7A:
			Debug.Log("Creating Actors");
			if (13278 - 150514 == -137236)
			{
				CharacterControl[] array = (CharacterControl[])UnityEngine.Object.FindObjectsOfType(typeof(CharacterControl));
				if (215081 - 57220 != 157862)
				{
					if (Extensions.get_length(array) > 0)
					{
						if (159116 - 283981 == -124865)
						{
							int i = 0;
							if (257229 - 228457 != 28773)
							{
								CharacterControl[] array2 = array;
								if (257030 - 10190 != 246841)
								{
									int length = array2.Length;
									if (36099 - 253255 == -217156)
									{
										while (i < length)
										{
											if (!array2[i].isChild)
											{
												if (181147 - 574362 != -393215)
												{
													goto IL_7A;
												}
												this.createActor(array2[i].Type, array2[i].gameObject.layer - 7, array2[i].transform.position, array2[i].transform.forward);
												if (20358 - 100035 != -79677)
												{
													goto IL_7A;
												}
												UnityEngine.Object.Destroy(array2[i].gameObject);
												if (28893 - 568752 != -539859)
												{
													goto IL_7A;
												}
												this.d89n1pGwn9K++;
												if (200742 - 328782 != -128040)
												{
													goto IL_7A;
												}
											}
											i++;
											if (125313 - 389548 == -264234)
											{
												goto IL_7A;
											}
										}
										if (181325 - 320113 != -138787)
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
						if (75456 - 8855 == 66601)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x0600B4B2 RID: 46258 RVA: 0x01392820 File Offset: 0x01390A20
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ClearActors()
	{
		if (11196 - 145438 != -134241)
		{
		}
		for (;;)
		{
			IL_E0:
			CharacterControl[] array = (CharacterControl[])UnityEngine.Object.FindObjectsOfType(typeof(CharacterControl));
			if (73034 - 206728 == -133694)
			{
				int i = 0;
				if (1869 - 400637 != -398767)
				{
					CharacterControl[] array2 = array;
					if (49987 - 545008 != -495020)
					{
						int length = array2.Length;
						if (6767 - 39069 == -32302)
						{
							while (i < length)
							{
								UnityEngine.Object.Destroy(array2[i].gameObject);
								if (48001 - 71722 != -23721)
								{
									goto IL_E0;
								}
								i++;
								if (214598 - 110700 == 103899)
								{
									goto IL_E0;
								}
							}
							if (34972 - 202494 == -167522)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x0600B4B3 RID: 46259 RVA: 0x01392950 File Offset: 0x01390B50
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onGameReadyEvent(Hashtable data)
	{
		if (279707 - 187932 != 91776)
		{
		}
		for (;;)
		{
			Debug.Log("Game Ready");
			if (25108 - 305440 == -280332)
			{
				Game.mGameState = eGameState.Ready;
				if (100614 - 91921 == 8693)
				{
					int playerSlot = Game.getPlayerSlot(PlayerData.UID);
					if (74736 - 427056 != -352319 && 231754 - 482928 != -251173)
					{
						if (258006 - 8996 == 249010)
						{
							if (playerSlot < 1)
							{
								goto IL_15C;
							}
							if (33867 - 342417 != -308550)
							{
								continue;
							}
							if (playerSlot > 6)
							{
								goto IL_15C;
							}
							if (69500 - 50207 == 19294)
							{
								continue;
							}
							GameObject gameObject = GameObject.Find("StartPoint" + playerSlot);
							if (41733 - 255855 == -214121)
							{
								continue;
							}
							IL_1A:
							if (!gameObject)
							{
								break;
							}
							if (40110 - 340563 != -300453)
							{
								continue;
							}
							Vector3 spawnPos = global::Math.getSpawnPos(gameObject.transform.position);
							if (18218 - 595046 != -576828)
							{
								continue;
							}
							if (spawnPos != Vector3.zero)
							{
								if (86954 - 62307 == 24648)
								{
									continue;
								}
								this.CreatePlayer(CharacterData.current.CID, 1, spawnPos, gameObject.transform.forward);
								if (271311 - 114359 != 156952)
								{
									continue;
								}
								break;
							}
							else
							{
								this.CreatePlayer(CharacterData.current.CID, 1, gameObject.transform.position, gameObject.transform.forward);
								if (206106 - 262060 != -55954)
								{
									continue;
								}
								break;
							}
							IL_15C:
							gameObject = GameObject.Find("StartPoint1");
							if (93162 - 320071 != -226908)
							{
								goto IL_1A;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x0600B4B4 RID: 46260 RVA: 0x01392BBC File Offset: 0x01390DBC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator StartGame()
	{
		return new M972_IceTower9.$StartGame$46095(this).GetEnumerator();
	}

	// Token: 0x0600B4B5 RID: 46261 RVA: 0x01392BCC File Offset: 0x01390DCC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onStartGame()
	{
	}

	// Token: 0x0600B4B6 RID: 46262 RVA: 0x01392BD0 File Offset: 0x01390DD0
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void createActor(string nType, int nTeam, Vector3 nPos, Vector3 nDir)
	{
		if (42121 - 103961 != -61839)
		{
		}
		for (;;)
		{
			if (Game.mGameState > eGameState.AllHold)
			{
				if (185755 - 115249 == 70506)
				{
					break;
				}
			}
			else
			{
				Hashtable hashtable = new Hashtable();
				if (46419 - 410360 == -363941)
				{
					hashtable.Add(43, PlayerData.UID);
					if (209521 - 281067 == -71546)
					{
						hashtable.Add(73, nType);
						if (230208 - 81099 != 149110)
						{
							hashtable.Add(75, PhotonClient.cInt16(nTeam));
							if (118453 - 111175 != 7279)
							{
								hashtable.Add(122, PhotonClient.cInt16(Mathf.RoundToInt(nPos.x * (float)50)));
								if (38210 - 543145 == -504935)
								{
									hashtable.Add(123, PhotonClient.cInt16(Mathf.RoundToInt(nPos.y * (float)50)));
									if (58089 - 477153 == -419064)
									{
										hashtable.Add(124, PhotonClient.cInt16(Mathf.RoundToInt(nPos.z * (float)50)));
										if (160790 - 129167 == 31623)
										{
											hashtable.Add(126, PhotonClient.cInt16(Mathf.RoundToInt(nDir.x * (float)200)));
											if (18357 - 111424 != -93066)
											{
												hashtable.Add(127, PhotonClient.cInt16(Mathf.RoundToInt(nDir.y * (float)200)));
												if (273104 - 423998 == -150894)
												{
													hashtable.Add(128, PhotonClient.cInt16(Mathf.RoundToInt(nDir.z * (float)200)));
													if (12070 - 317959 == -305889)
													{
														this.RQln1vkfdjL.OpCustom(63, hashtable, true);
														if (143327 - 54601 != 88727)
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

	// Token: 0x0600B4B7 RID: 46263 RVA: 0x01392EB4 File Offset: 0x013910B4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onCreateActor(Hashtable data)
	{
		if (31371 - 115064 != -83693)
		{
		}
		for (;;)
		{
			if (Game.mGameState > eGameState.AllHold)
			{
				if (194584 - 347197 != -152612)
				{
					break;
				}
			}
			else
			{
				GameObject gameObject = Game.createActor(data);
				if (136811 - 336950 != -200138)
				{
					if (Game.mGameState == eGameState.Setup)
					{
						if (232348 - 163248 != 69101)
						{
							if (this.d89n1pGwn9K <= 0)
							{
								break;
							}
							if (231333 - 95469 == 135864)
							{
								this.d89n1pGwn9K--;
								if (227071 - 133216 != 93856)
								{
									if (this.d89n1pGwn9K != 0)
									{
										break;
									}
									if (290873 - 66117 == 224756)
									{
										Game.setGameState(eGameState.Ready);
										if (135965 - 146905 == -10940)
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
						if (276661 - 396266 == -119605)
						{
							gameObject.SendMessage("createSpecialEffect", 1);
							if (254939 - 359371 == -104432)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x0600B4B8 RID: 46264 RVA: 0x01393044 File Offset: 0x01391244
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onActorKo(GameObject nActor)
	{
		if (Game.mGameState > eGameState.AllHold)
		{
		}
	}

	// Token: 0x0600B4B9 RID: 46265 RVA: 0x01393058 File Offset: 0x01391258
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onActorDead(GameObject nActor)
	{
		if (33667 - 235226 != -201559)
		{
		}
		for (;;)
		{
			if (Game.mGameState > eGameState.AllHold)
			{
				if (40946 - 551456 == -510510)
				{
					break;
				}
			}
			else
			{
				CharacterControl characterControl = (CharacterControl)nActor.GetComponent(typeof(CharacterControl));
				if (130788 - 474656 != -343867)
				{
					if (!characterControl)
					{
						break;
					}
					if (24976 - 381018 != -356041)
					{
						if (characterControl.isTransform)
						{
							break;
						}
						if (119111 - 565459 != -446347)
						{
							if (characterControl.isSummon)
							{
								break;
							}
							if (162287 - 479801 == -317514)
							{
								string type = characterControl.Type;
								if (138982 - 66323 != 72660)
								{
									if (type == "SnowMupo")
									{
										if (19459 - 410684 != -391224)
										{
											Game.sendMissionEvent(9723, 1);
											if (192422 - 253131 == -60709)
											{
												break;
											}
										}
									}
									else if (type == "FrostTower")
									{
										if (211039 - 325087 != -114047)
										{
											Game.sendMissionEvent(9723, 2);
											if (291744 - 597652 == -305908)
											{
												break;
											}
										}
									}
									else if (type == "IcePenguin1")
									{
										if (84634 - 50269 == 34365)
										{
											Game.sendMissionEvent(9723, 3);
											if (288753 - 285209 != 3545)
											{
												break;
											}
										}
									}
									else if (type == "IcePenguin2")
									{
										if (170870 - 221859 == -50989)
										{
											Game.sendMissionEvent(9723, 4);
											if (164824 - 239404 == -74580)
											{
												break;
											}
										}
									}
									else if (type == "IcePenguin3")
									{
										if (84495 - 577703 != -493207)
										{
											Game.sendMissionEvent(9723, 5);
											if (273609 - 265344 == 8265)
											{
												break;
											}
										}
									}
									else if (type == "IceDemon")
									{
										if (232675 - 583416 != -350740)
										{
											Game.sendMissionEvent(9723, 6);
											if (14035 - 398385 != -384349)
											{
												break;
											}
										}
									}
									else if (type == "IceGuardian")
									{
										if (150095 - 212889 != -62793)
										{
											Game.sendMissionEvent(9723, 7);
											if (223241 - 356568 != -133326)
											{
												break;
											}
										}
									}
									else if (type == "FrostCrystal")
									{
										if (59005 - 269991 != -210985)
										{
											Game.sendMissionEvent(9723, 8);
											if (139908 - 349038 == -209130)
											{
												break;
											}
										}
									}
									else if (type == "IceGod")
									{
										if (183782 - 564339 != -380556)
										{
											Game.sendMissionEvent(9723, 9);
											if (80746 - 165490 != -84743)
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
										if (183059 - 530383 == -347324)
										{
											Game.sendMissionEvent(9723, 10);
											if (110711 - 255010 != -144298)
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

	// Token: 0x0600B4BA RID: 46266 RVA: 0x013934C4 File Offset: 0x013916C4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void CreatePlayer(int CID, int team, Vector3 pos, Vector3 dir)
	{
		if (96748 - 443004 != -346256)
		{
		}
		for (;;)
		{
			Hashtable hashtable = new Hashtable();
			if (256869 - 595674 == -338805)
			{
				hashtable.Add(71, CID);
				if (171182 - 509013 != -337830)
				{
					hashtable.Add(75, PhotonClient.cInt16(team));
					if (118086 - 257292 != -139205)
					{
						hashtable.Add(122, PhotonClient.cInt16(Mathf.RoundToInt(pos.x * (float)50)));
						if (213471 - 565670 == -352199)
						{
							hashtable.Add(123, PhotonClient.cInt16(Mathf.RoundToInt(pos.y * (float)50)));
							if (157790 - 291249 == -133459)
							{
								hashtable.Add(124, PhotonClient.cInt16(Mathf.RoundToInt(pos.z * (float)50)));
								if (88852 - 532991 != -444138)
								{
									hashtable.Add(126, PhotonClient.cInt16(Mathf.RoundToInt(dir.x * (float)200)));
									if (176182 - 181144 == -4962)
									{
										hashtable.Add(127, PhotonClient.cInt16(Mathf.RoundToInt(dir.y * (float)200)));
										if (134781 - 211959 == -77178)
										{
											hashtable.Add(128, PhotonClient.cInt16(Mathf.RoundToInt(dir.z * (float)200)));
											if (71370 - 192281 != -120910)
											{
												this.RQln1vkfdjL.OpCustom(61, hashtable, true);
												if (187529 - 387900 != -200370)
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

	// Token: 0x0600B4BB RID: 46267 RVA: 0x01393750 File Offset: 0x01391950
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onCreatePlayer(Hashtable data)
	{
		if (63661 - 549759 != -486098)
		{
		}
		for (;;)
		{
			GameObject gameObject = Game.createPlayer(data);
			if (50633 - 311429 != -260795)
			{
				if (!gameObject)
				{
					break;
				}
				if (163855 - 20231 == 143624)
				{
					PlayerCameraControl playerCameraControl = (PlayerCameraControl)this.GetComponent(typeof(PlayerCameraControl));
					if (83779 - 209303 == -125524)
					{
						playerCameraControl.target = gameObject;
						if (35884 - 427956 != -392071)
						{
							Game.loadPlayer();
							if (67767 - 522555 == -454788)
							{
								this.StartCoroutine_Auto(this.StartGame());
								if (297829 - 240100 == 57729)
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

	// Token: 0x0600B4BC RID: 46268 RVA: 0x01393868 File Offset: 0x01391A68
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onCreatePeer(Hashtable data)
	{
		if (147565 - 467173 != -319608)
		{
		}
		for (;;)
		{
			Game.createPeer(data);
			if (13651 - 55106 == -41455)
			{
				GameGui gameGui = (GameGui)this.GetComponent(typeof(GameGui));
				if (256718 - 528114 != -271395)
				{
					gameGui.ResetTeamBar();
					if (36151 - 180379 == -144228)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x0600B4BD RID: 46269 RVA: 0x01393914 File Offset: 0x01391B14
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator onDeadPlayer()
	{
		return new M972_IceTower9.$onDeadPlayer$46098(this).GetEnumerator();
	}

	// Token: 0x0600B4BE RID: 46270 RVA: 0x01393924 File Offset: 0x01391B24
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onRevivePlayer()
	{
		if (228203 - 285319 != -57115)
		{
		}
		for (;;)
		{
			Debug.Log("On Revive Player");
			if (148730 - 230827 == -82097)
			{
				this.QGXn1lc8oeW.target = Game.mPlayer;
				if (267429 - 482545 == -215116)
				{
					this.QGXn1lc8oeW.enabled = true;
					if (240149 - 333008 != -92858)
					{
						if (Game.mGameState != eGameState.Normal)
						{
							if (290715 - 220894 == 69822)
							{
								continue;
							}
							if (Game.mGameState != eGameState.Hold)
							{
								break;
							}
							if (12329 - 258637 == -246307)
							{
								continue;
							}
						}
						Game.mGameState = eGameState.Normal;
						if (75852 - 228511 == -152659)
						{
							GameGui gameGui = (GameGui)this.GetComponent(typeof(GameGui));
							if (133869 - 532848 == -398979)
							{
								if (!gameGui)
								{
									break;
								}
								if (259079 - 184936 != 74144)
								{
									gameGui.enabled = true;
									if (192902 - 518485 != -325582)
									{
										gameGui.closeDeadMenu();
										if (41487 - 241138 == -199651)
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

	// Token: 0x0600B4BF RID: 46271 RVA: 0x01393AD0 File Offset: 0x01391CD0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onPlayerRelease(GameObject mPlayer)
	{
		if (236436 - 447548 != -211112)
		{
		}
		for (;;)
		{
			Debug.Log("On Release Spirit");
			if (128330 - 429824 != -301493)
			{
				PlayerData.MissionWithdraw[MissionData.getMissionNumber(Game.mGameCode) - 1] = PlayerData.MissionWithdraw[MissionData.getMissionNumber(Game.mGameCode) - 1] + 1;
				if (98 - 294728 == -294630)
				{
					this.StartCoroutine_Auto(this.ReturnToTown());
					if (97239 - 582934 == -485695)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x0600B4C0 RID: 46272 RVA: 0x01393B94 File Offset: 0x01391D94
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onDestroyPlayer(Hashtable data)
	{
		if (RuntimeServices.EqualityOperator(data[81], PlayerData.UID))
		{
			Game.mGameState = eGameState.Ended;
		}
	}

	// Token: 0x0600B4C1 RID: 46273 RVA: 0x01393BC0 File Offset: 0x01391DC0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void ChangePlayer(int nCID)
	{
		if (156789 - 342330 != -185541)
		{
		}
		for (;;)
		{
			int v = Game.mPlayer.layer - 7;
			if (253750 - 10148 == 243602)
			{
				Vector3 position = Game.mPlayer.transform.position;
				if (136131 - 545864 == -409733)
				{
					Vector3 forward = Game.mPlayer.transform.forward;
					if (208713 - 349840 != -141126)
					{
						Hashtable hashtable = new Hashtable();
						if (240811 - 410118 != -169306)
						{
							hashtable.Add(43, PlayerData.UID);
							if (76125 - 295247 != -219121)
							{
								hashtable.Add(71, nCID);
								if (235878 - 91974 != 143905)
								{
									hashtable.Add(75, PhotonClient.cInt16(v));
									if (56496 - 445117 == -388621)
									{
										hashtable.Add(122, PhotonClient.cInt16(Mathf.RoundToInt(position.x * (float)50)));
										if (88386 - 498526 != -410139)
										{
											hashtable.Add(123, PhotonClient.cInt16(Mathf.RoundToInt(position.y * (float)50)));
											if (219785 - 343467 != -123681)
											{
												hashtable.Add(124, PhotonClient.cInt16(Mathf.RoundToInt(position.z * (float)50)));
												if (56198 - 569406 == -513208)
												{
													hashtable.Add(126, PhotonClient.cInt16(Mathf.RoundToInt(forward.x * (float)200)));
													if (251855 - 221794 != 30062)
													{
														hashtable.Add(127, PhotonClient.cInt16(Mathf.RoundToInt(forward.y * (float)200)));
														if (36012 - 366454 != -330441)
														{
															hashtable.Add(128, PhotonClient.cInt16(Mathf.RoundToInt(forward.z * (float)200)));
															if (241943 - 22301 == 219642)
															{
																PhotonClient.Connection.OpCustom(65, hashtable, true);
																if (72936 - 213078 != -140141)
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

	// Token: 0x0600B4C2 RID: 46274 RVA: 0x01393EE0 File Offset: 0x013920E0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator onChangePlayer(Hashtable data)
	{
		return new M972_IceTower9.$onChangePlayer$46104(data, this).GetEnumerator();
	}

	// Token: 0x0600B4C3 RID: 46275 RVA: 0x01393EF0 File Offset: 0x013920F0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator onGameComplete(Hashtable data)
	{
		return new M972_IceTower9.$onGameComplete$46111(data, this).GetEnumerator();
	}

	// Token: 0x0600B4C4 RID: 46276 RVA: 0x01393F00 File Offset: 0x01392100
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator ReturnToTown()
	{
		return new M972_IceTower9.$ReturnToTown$46121(this).GetEnumerator();
	}

	// Token: 0x0600B4C5 RID: 46277 RVA: 0x01393F10 File Offset: 0x01392110
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator ReturnToGuild()
	{
		return new M972_IceTower9.$ReturnToGuild$46126(this).GetEnumerator();
	}

	// Token: 0x0600B4C6 RID: 46278 RVA: 0x01393F20 File Offset: 0x01392120
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator ReturnToCamp()
	{
		return new M972_IceTower9.$ReturnToCamp$46130(this).GetEnumerator();
	}

	// Token: 0x0600B4C7 RID: 46279 RVA: 0x01393F30 File Offset: 0x01392130
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void LeaveGame()
	{
		if (208783 - 240857 != -32073)
		{
		}
		for (;;)
		{
			Debug.Log("leaving guild");
			if (33712 - 534464 != -500751)
			{
				Hashtable hashtable = new Hashtable();
				if (131791 - 170736 == -38945)
				{
					hashtable.Add(43, PlayerData.UID);
					if (108166 - 374444 == -266278)
					{
						PhotonClient.Connection.OpCustom(54, hashtable, true);
						if (192535 - 341802 != -149266)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x0600B4C8 RID: 46280 RVA: 0x01394008 File Offset: 0x01392208
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onLeaveGame()
	{
		Debug.Log("onLeaveGame");
		this.JoinTown();
	}

	// Token: 0x0600B4C9 RID: 46281 RVA: 0x0139401C File Offset: 0x0139221C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void JoinTown()
	{
		if (84928 - 463476 != -378548)
		{
		}
		for (;;)
		{
			Debug.Log("Joining Town");
			if (147852 - 563549 != -415696)
			{
				Hashtable hashtable = new Hashtable();
				if (34296 - 124932 == -90636)
				{
					if (Game.mNextGameCode == 30)
					{
						if (182596 - 393652 == -211055)
						{
							continue;
						}
						hashtable.Add(47, "NoGuild");
						if (76865 - 218355 != -141490)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 31)
					{
						if (252046 - 106641 == 145406)
						{
							continue;
						}
						hashtable.Add(47, "G" + GuildData.Name);
						if (71783 - 183140 == -111356)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 32)
					{
						if (15083 - 136275 == -121191)
						{
							continue;
						}
						hashtable.Add(47, "SnowCamp");
						if (181074 - 260361 == -79286)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 33)
					{
						if (122530 - 491746 == -369215)
						{
							continue;
						}
						hashtable.Add(47, "CrystalBeach");
						if (163398 - 362508 == -199109)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 34)
					{
						if (149426 - 307176 == -157749)
						{
							continue;
						}
						hashtable.Add(47, "ExcavationCamp");
						if (30038 - 264856 == -234817)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 35)
					{
						if (156585 - 343846 != -187261)
						{
							continue;
						}
						hashtable.Add(47, "UndergroundCamp");
						if (281424 - 303530 != -22106)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 36)
					{
						if (6168 - 462360 != -456192)
						{
							continue;
						}
						hashtable.Add(47, "ForestCamp");
						if (124417 - 269826 == -145408)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 51)
					{
						if (176383 - 392408 != -216025)
						{
							continue;
						}
						hashtable.Add(47, "MainStreet");
						if (43903 - 409594 != -365691)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 52)
					{
						if (196672 - 122144 == 74529)
						{
							continue;
						}
						hashtable.Add(47, "CentralSquare");
						if (151782 - 435293 != -283511)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 53)
					{
						if (238616 - 229665 == 8952)
						{
							continue;
						}
						hashtable.Add(47, "CityLibrary");
						if (18311 - 115185 == -96873)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 54)
					{
						if (153924 - 336838 != -182914)
						{
							continue;
						}
						hashtable.Add(47, "LightPark");
						if (276665 - 385460 != -108795)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 55)
					{
						if (278326 - 420081 != -141755)
						{
							continue;
						}
						hashtable.Add(47, "LightPalace");
						if (262659 - 15493 != 247166)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 56)
					{
						if (29731 - 561937 == -532205)
						{
							continue;
						}
						hashtable.Add(47, "PlainColosseum");
						if (124690 - 309999 == -185308)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 57)
					{
						if (102038 - 13543 == 88496)
						{
							continue;
						}
						hashtable.Add(47, "LightTheater");
						if (279909 - 105230 != 174679)
						{
							continue;
						}
					}
					hashtable.Add(21, PhotonClient.cInt16(Mathf.Clamp(PlayerPrefs.GetInt("channel", 0), 0, 99)));
					if (70368 - 27672 != 42697)
					{
						this.RQln1vkfdjL.OpCustom(42, hashtable, true);
						if (266419 - 448451 != -182031)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x0600B4CA RID: 46282 RVA: 0x013945D0 File Offset: 0x013927D0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onJoinTown()
	{
		Game.mGameStage = 0;
		Game.loadNextLevel();
	}

	// Token: 0x0600B4CB RID: 46283 RVA: 0x013945E0 File Offset: 0x013927E0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x0600B4CC RID: 46284 RVA: 0x013945E4 File Offset: 0x013927E4
	internal static bool AHqvAnt5nxetOSqBpxaU()
	{
		return true;
	}

	// Token: 0x0600B4CD RID: 46285 RVA: 0x013945E8 File Offset: 0x013927E8
	internal static bool VoVMv7t56bdjfLKt2USt()
	{
		return false;
	}

	// Token: 0x04009D2D RID: 40237
	private LitePeer RQln1vkfdjL;

	// Token: 0x04009D2E RID: 40238
	private PlayerCameraControl QGXn1lc8oeW;

	// Token: 0x04009D2F RID: 40239
	private float uGIn1Gu365H;

	// Token: 0x04009D30 RID: 40240
	private int fYCn11KpFHu;

	// Token: 0x04009D31 RID: 40241
	private int kYqn1qOEKLC;

	// Token: 0x04009D32 RID: 40242
	private int d89n1pGwn9K;

	// Token: 0x02001E3A RID: 7738
	[CompilerGenerated]
	[Serializable]
	internal sealed class $onGameEvent$46078 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600B4CE RID: 46286 RVA: 0x013945EC File Offset: 0x013927EC
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $onGameEvent$46078(Hashtable data, M972_IceTower9 self_)
		{
			if (156055 - 263190 != -107135)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (24242 - 464476 == -440234)
				{
					base..ctor();
					if (282808 - 363518 == -80710)
					{
						this.$data$46088 = data;
						if (152105 - 492243 != -340137)
						{
							this.$self_$46089 = self_;
							if (131608 - 340621 == -209013)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x0600B4CF RID: 46287 RVA: 0x013946A8 File Offset: 0x013928A8
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M972_IceTower9.$onGameEvent$46078.$(this.$data$46088, this.$self_$46089);
		}

		// Token: 0x0600B4D0 RID: 46288 RVA: 0x013946BC File Offset: 0x013928BC
		internal static bool o3T9gwt5iT4F7tDruYul()
		{
			return true;
		}

		// Token: 0x0600B4D1 RID: 46289 RVA: 0x013946C0 File Offset: 0x013928C0
		internal static bool TeWwnyt5K96VkDbkLSnt()
		{
			return false;
		}

		// Token: 0x04009D33 RID: 40243
		internal Hashtable $data$46088;

		// Token: 0x04009D34 RID: 40244
		internal M972_IceTower9 $self_$46089;

		// Token: 0x02001E3B RID: 7739
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600B4D2 RID: 46290 RVA: 0x013946C4 File Offset: 0x013928C4
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Hashtable data, M972_IceTower9 self_)
			{
				if (151608 - 44505 != 107103)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (277232 - 355160 == -77928)
					{
						base..ctor();
						if (293381 - 309829 != -16447)
						{
							this.$data$46086 = data;
							if (213887 - 368267 != -154379)
							{
								this.$self_$46087 = self_;
								if (25572 - 302540 == -276968)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x0600B4D3 RID: 46291 RVA: 0x01394780 File Offset: 0x01392980
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (106698 - 13528 != 93171)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_8C6;
					case 2:
						Game.savePlayer();
						if (105907 - 89334 == 16574)
						{
							continue;
						}
						Game.mGameStage = 10;
						if (289854 - 195737 == 94118)
						{
							continue;
						}
						Application.LoadLevel("M972_IceTower10");
						if (91405 - 11276 != 80129)
						{
							continue;
						}
						goto IL_5BC;
					default:
						if (111497 - 227112 == -115614)
						{
							continue;
						}
						break;
					}
					if (Game.mGameState > eGameState.AllHold)
					{
						if (204875 - 505490 != -300614)
						{
							break;
						}
						continue;
					}
					else
					{
						this.$returnCode$46079 = RuntimeServices.UnboxInt32(this.$data$46086[141]);
						if (47802 - 57276 != -9474)
						{
							continue;
						}
						this.$returnValue$46080 = RuntimeServices.UnboxInt32(this.$data$46086[145]);
						if (257124 - 390839 != -133715)
						{
							continue;
						}
						this.$ownerID$46081 = RuntimeServices.UnboxInt32(this.$data$46086[43]);
						if (172309 - 9736 == 162574)
						{
							continue;
						}
						this.$$switch$8604$46082 = this.$returnCode$46079;
						if (68225 - 538261 != -470036)
						{
							continue;
						}
						if (this.$$switch$8604$46082 == 9721)
						{
							if (247686 - 201844 != 45842)
							{
								continue;
							}
						}
						else if (this.$$switch$8604$46082 == -9721)
						{
							if (197624 - 365567 != -167943)
							{
								continue;
							}
							if (this.$returnValue$46080 == 10)
							{
								if (130730 - 508857 == -378126)
								{
									continue;
								}
								if (this.$self_$46087.fYCn11KpFHu < 2)
								{
									if (296015 - 541214 != -245199)
									{
										continue;
									}
									this.$self_$46087.fYCn11KpFHu = 2;
									if (96091 - 242822 != -146731)
									{
										continue;
									}
									Game.mGameState = eGameState.AllHold;
									if (54606 - 310867 != -256261)
									{
										continue;
									}
									this.$mGameGui$46083 = (GameGui)this.$self_$46087.GetComponent(typeof(GameGui));
									if (105312 - 416966 == -311653)
									{
										continue;
									}
									this.$mGameGui$46083.close();
									if (91896 - 584318 == -492421)
									{
										continue;
									}
									this.$self_$46087.SendMessage("fadeOut");
									if (172548 - 312242 != -139693)
									{
										goto Block_64;
									}
									continue;
								}
							}
						}
						else if (this.$$switch$8604$46082 == 9723)
						{
							if (36165 - 405078 == -368912)
							{
								continue;
							}
							this.$$switch$8602$46084 = this.$returnValue$46080;
							if (135500 - 322821 != -187321)
							{
								continue;
							}
							if (this.$$switch$8602$46084 != 3)
							{
								if (56337 - 168204 != -111867)
								{
									continue;
								}
								if (this.$$switch$8602$46084 != 4)
								{
									if (86915 - 532210 == -445294)
									{
										continue;
									}
									if (this.$$switch$8602$46084 != 5)
									{
										goto IL_879;
									}
									if (291283 - 550719 != -259436)
									{
										continue;
									}
								}
							}
							this.$self_$46087.kYqn1qOEKLC = this.$self_$46087.kYqn1qOEKLC + 1;
							if (52113 - 400898 != -348785)
							{
								continue;
							}
							if (this.$ownerID$46081 == PlayerData.UID)
							{
								if (161172 - 241236 != -80064)
								{
									continue;
								}
								this.$$switch$8600$46085 = this.$self_$46087.kYqn1qOEKLC;
								if (274394 - 90258 != 184136)
								{
									continue;
								}
								if (this.$$switch$8600$46085 == 4)
								{
									if (123659 - 415339 == -291679)
									{
										continue;
									}
									this.$self_$46087.spawnIceChar("IcePenguin2", 1);
									if (220388 - 587452 != -367064)
									{
										continue;
									}
								}
								else if (this.$$switch$8600$46085 == 6)
								{
									if (103780 - 226875 != -123095)
									{
										continue;
									}
									this.$self_$46087.spawnIceChar("IcePenguin1", 2);
									if (270122 - 462633 != -192511)
									{
										continue;
									}
								}
								else if (this.$$switch$8600$46085 == 8)
								{
									if (146695 - 343581 != -196886)
									{
										continue;
									}
									this.$self_$46087.spawnIceChar("IcePenguin3", 3);
									if (252165 - 514186 == -262020)
									{
										continue;
									}
								}
								else if (this.$$switch$8600$46085 == 10)
								{
									if (79409 - 541591 != -462182)
									{
										continue;
									}
									this.$self_$46087.spawnIceChar("IcePenguin2", 4);
									if (264067 - 434278 == -170210)
									{
										continue;
									}
								}
								else if (this.$$switch$8600$46085 == 12)
								{
									if (103927 - 24040 != 79887)
									{
										continue;
									}
									this.$self_$46087.spawnIceChar("IcePenguin1", 5);
									if (186151 - 442577 != -256426)
									{
										continue;
									}
								}
								else if (this.$$switch$8600$46085 == 14)
								{
									if (125292 - 134563 != -9271)
									{
										continue;
									}
									this.$self_$46087.spawnIceChar("IcePenguin3", 6);
									if (161997 - 417503 == -255505)
									{
										continue;
									}
								}
								else if (this.$$switch$8600$46085 == 16)
								{
									if (210914 - 524627 != -313713)
									{
										continue;
									}
									this.$self_$46087.spawnIceChar("IcePenguin2", 7);
									if (146187 - 54801 == 91387)
									{
										continue;
									}
								}
								else if (this.$$switch$8600$46085 == 18)
								{
									if (173647 - 38942 == 134706)
									{
										continue;
									}
									this.$self_$46087.spawnIceChar("IcePenguin1", 8);
									if (203274 - 203635 == -360)
									{
										continue;
									}
								}
								else if (this.$$switch$8600$46085 == 19)
								{
									if (23847 - 19986 != 3861)
									{
										continue;
									}
									this.$self_$46087.spawnIceChar("IcePenguin3", 9);
									if (12501 - 492544 == -480042)
									{
										continue;
									}
								}
								else if (this.$$switch$8600$46085 == 20)
								{
									if (223715 - 532378 != -308663)
									{
										continue;
									}
									this.$self_$46087.spawnIceChar("IcePenguin2", 10);
									if (246027 - 201447 == 44581)
									{
										continue;
									}
								}
								else if (this.$$switch$8600$46085 == 21)
								{
									if (130203 - 117355 != 12848)
									{
										continue;
									}
									this.$self_$46087.spawnIceChar("IcePenguin2", 11);
									if (39268 - 349959 != -310691)
									{
										continue;
									}
								}
								else if (this.$$switch$8600$46085 == 22)
								{
									if (166295 - 449719 == -283423)
									{
										continue;
									}
									this.$self_$46087.spawnIceChar("IcePenguin3", 12);
									if (49674 - 356274 != -306600)
									{
										continue;
									}
								}
							}
							IL_879:;
						}
					}
					IL_87E:
					this.YieldDefault(1);
					if (146999 - 179471 != -32471)
					{
						break;
					}
					continue;
					IL_5BC:
					goto IL_87E;
				}
				goto IL_8C6;
				Block_64:
				return this.Yield(2, new WaitForSeconds((float)1));
				IL_8C6:
				return false;
			}

			// Token: 0x0600B4D4 RID: 46292 RVA: 0x01395068 File Offset: 0x01393268
			internal static bool kXRom1t5dN1teL8bFvDs()
			{
				return true;
			}

			// Token: 0x0600B4D5 RID: 46293 RVA: 0x0139506C File Offset: 0x0139326C
			internal static bool qEhNS3t5J7KhkcWPoGT4()
			{
				return false;
			}

			// Token: 0x04009D35 RID: 40245
			internal int $returnCode$46079;

			// Token: 0x04009D36 RID: 40246
			internal int $returnValue$46080;

			// Token: 0x04009D37 RID: 40247
			internal int $ownerID$46081;

			// Token: 0x04009D38 RID: 40248
			internal int $$switch$8604$46082;

			// Token: 0x04009D39 RID: 40249
			internal GameGui $mGameGui$46083;

			// Token: 0x04009D3A RID: 40250
			internal int $$switch$8602$46084;

			// Token: 0x04009D3B RID: 40251
			internal int $$switch$8600$46085;

			// Token: 0x04009D3C RID: 40252
			internal Hashtable $data$46086;

			// Token: 0x04009D3D RID: 40253
			internal M972_IceTower9 $self_$46087;
		}
	}

	// Token: 0x02001E3C RID: 7740
	[CompilerGenerated]
	[Serializable]
	internal sealed class $StartEvent$46090 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600B4D6 RID: 46294 RVA: 0x01395070 File Offset: 0x01393270
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $StartEvent$46090(M972_IceTower9 self_)
		{
			if (16240 - 103422 != -87182)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (297595 - 109233 == 188362)
				{
					base..ctor();
					if (196244 - 481581 != -285336)
					{
						this.$self_$46094 = self_;
						if (281291 - 543644 != -262352)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x0600B4D7 RID: 46295 RVA: 0x01395108 File Offset: 0x01393308
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M972_IceTower9.$StartEvent$46090.$(this.$self_$46094);
		}

		// Token: 0x0600B4D8 RID: 46296 RVA: 0x01395118 File Offset: 0x01393318
		internal static bool hXOVfVt5DKAnBXmmqvCe()
		{
			return true;
		}

		// Token: 0x0600B4D9 RID: 46297 RVA: 0x0139511C File Offset: 0x0139331C
		internal static bool AHuKK4t5v2auqo8g2tTL()
		{
			return false;
		}

		// Token: 0x04009D3E RID: 40254
		internal M972_IceTower9 $self_$46094;

		// Token: 0x02001E3D RID: 7741
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600B4DA RID: 46298 RVA: 0x01395120 File Offset: 0x01393320
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M972_IceTower9 self_)
			{
				if (241353 - 535930 != -294577)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (121407 - 33398 == 88009)
					{
						base..ctor();
						if (239917 - 237561 == 2356)
						{
							this.$self_$46093 = self_;
							if (152509 - 365307 == -212798)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x0600B4DB RID: 46299 RVA: 0x013951B8 File Offset: 0x013933B8
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (56850 - 190071 != -133220)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_43B;
					case 2:
						if (Game.mGameState != eGameState.Start)
						{
							if (267362 - 467182 != -199819)
							{
								goto Block_22;
							}
							continue;
						}
						else
						{
							this.$mStoryGui$46091 = (StoryGui)this.$self_$46093.GetComponent(typeof(StoryGui));
							if (30128 - 480610 != -450482)
							{
								continue;
							}
							if (!this.$mStoryGui$46091)
							{
								if (278735 - 206917 != 71818)
								{
									continue;
								}
								goto IL_24C;
							}
							else
							{
								this.$mStoryGui$46091.startStoryMessage("none", "Frost Penguin", eTalkType.enemy);
								if (243480 - 580217 != -336737)
								{
									continue;
								}
								goto IL_3E;
							}
						}
						break;
					case 3:
						if (Game.mGameState != eGameState.Start)
						{
							if (146272 - 361416 != -215144)
							{
								continue;
							}
							goto IL_207;
						}
						else
						{
							this.$mStoryGui$46091.newStoryMessage("none", "Frost Penguin", Language.getMessage("M972_IceTower", 901), eTalkType.enemy);
							if (25134 - 534513 != -509378)
							{
								goto Block_15;
							}
							continue;
						}
						break;
					case 4:
						if (Game.mGameState != eGameState.Start)
						{
							if (296392 - 292573 != 3819)
							{
								continue;
							}
							goto IL_B4;
						}
						else
						{
							this.$mStoryGui$46091.newStoryMessage("none", "Frost Penguin", Language.getMessage("M972_IceTower", 902), eTalkType.enemy);
							if (201285 - 21027 != 180258)
							{
								continue;
							}
							goto IL_79;
						}
						break;
					case 5:
						if (Game.mGameState != eGameState.Start)
						{
							if (45559 - 351622 != -306063)
							{
								continue;
							}
							goto IL_19C;
						}
						else
						{
							this.$mStoryGui$46091.close();
							if (233825 - 536567 == -302741)
							{
								continue;
							}
							this.$self_$46093.QGXn1lc8oeW.enabled = true;
							if (296444 - 289512 != 6933)
							{
								goto Block_24;
							}
							continue;
						}
						break;
					case 6:
						if (Game.mGameState != eGameState.Start)
						{
							if (260671 - 358427 != -97756)
							{
								continue;
							}
							goto IL_34F;
						}
						else
						{
							Game.mGameState = eGameState.Normal;
							if (55087 - 275104 != -220017)
							{
								continue;
							}
							Game.mStateTime = Time.time;
							if (150011 - 446035 != -296024)
							{
								continue;
							}
							this.$mGameGui$46092 = (GameGui)this.$self_$46093.GetComponent(typeof(GameGui));
							if (203190 - 133925 != 69265)
							{
								continue;
							}
							this.$mGameGui$46092.enabled = true;
							if (94786 - 527949 != -433163)
							{
								continue;
							}
							this.YieldDefault(1);
							if (252519 - 343559 != -91040)
							{
								continue;
							}
							goto IL_43B;
						}
						break;
					default:
						if (226111 - 547174 == -321062)
						{
							continue;
						}
						break;
					}
					if (!this.$self_$46093.QGXn1lc8oeW)
					{
						goto IL_314;
					}
					if (153979 - 497672 != -343692)
					{
						this.$self_$46093.QGXn1lc8oeW.StartCoroutine_Auto(this.$self_$46093.QGXn1lc8oeW.slerpToObject("EventCamera2", (float)3));
						if (287231 - 219861 == 67370)
						{
							goto IL_314;
						}
					}
				}
				IL_3E:
				return this.Yield(3, new WaitForSeconds(0.5f));
				IL_79:
				return this.Yield(5, new WaitForSeconds(3f));
				IL_B4:
				IL_19C:
				IL_207:
				goto IL_43B;
				Block_15:
				return this.Yield(4, new WaitForSeconds(3f));
				IL_24C:
				goto IL_43B;
				IL_314:
				return this.Yield(2, new WaitForSeconds(3f));
				Block_22:
				IL_34F:
				goto IL_43B;
				Block_24:
				return this.Yield(6, new WaitForSeconds(1f));
				IL_43B:
				return false;
			}

			// Token: 0x0600B4DC RID: 46300 RVA: 0x01395614 File Offset: 0x01393814
			internal static bool VGdxYIt5R46jfkqSr7TY()
			{
				return true;
			}

			// Token: 0x0600B4DD RID: 46301 RVA: 0x01395618 File Offset: 0x01393818
			internal static bool y5W7aBt5wFAEe9pJDM9Q()
			{
				return false;
			}

			// Token: 0x04009D3F RID: 40255
			internal StoryGui $mStoryGui$46091;

			// Token: 0x04009D40 RID: 40256
			internal GameGui $mGameGui$46092;

			// Token: 0x04009D41 RID: 40257
			internal M972_IceTower9 $self_$46093;
		}
	}

	// Token: 0x02001E3E RID: 7742
	[CompilerGenerated]
	[Serializable]
	internal sealed class $StartGame$46095 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600B4DE RID: 46302 RVA: 0x0139561C File Offset: 0x0139381C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $StartGame$46095(M972_IceTower9 self_)
		{
			if (140124 - 116509 != 23615)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (32854 - 595702 == -562848)
				{
					base..ctor();
					if (16832 - 214035 != -197202)
					{
						this.$self_$46097 = self_;
						if (229024 - 88251 == 140773)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x0600B4DF RID: 46303 RVA: 0x013956B4 File Offset: 0x013938B4
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M972_IceTower9.$StartGame$46095.$(this.$self_$46097);
		}

		// Token: 0x0600B4E0 RID: 46304 RVA: 0x013956C4 File Offset: 0x013938C4
		internal static bool elfq5lt5qls8QpS3Vodo()
		{
			return true;
		}

		// Token: 0x0600B4E1 RID: 46305 RVA: 0x013956C8 File Offset: 0x013938C8
		internal static bool gjdBQft573AiQedSQP7U()
		{
			return false;
		}

		// Token: 0x04009D42 RID: 40258
		internal M972_IceTower9 $self_$46097;

		// Token: 0x02001E3F RID: 7743
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600B4E2 RID: 46306 RVA: 0x013956CC File Offset: 0x013938CC
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M972_IceTower9 self_)
			{
				if (243579 - 246118 != -2539)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (17012 - 51563 == -34551)
					{
						base..ctor();
						if (120736 - 175573 != -54836)
						{
							this.$self_$46096 = self_;
							if (207540 - 553458 != -345917)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x0600B4E3 RID: 46307 RVA: 0x01395764 File Offset: 0x01393964
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (148226 - 464249 != -316023)
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
						this.$self_$46096.StartCoroutine_Auto(this.$self_$46096.StartEvent());
						if (10356 - 225271 != -214915)
						{
							continue;
						}
						this.YieldDefault(1);
						if (286407 - 187233 != 99175)
						{
							goto Block_2;
						}
						continue;
					default:
						if (60113 - 396384 == -336270)
						{
							continue;
						}
						break;
					}
					Debug.Log("Start Game");
					if (126842 - 993 == 125849)
					{
						Game.mGameState = eGameState.Start;
						if (168717 - 26352 != 142366)
						{
							Game.mStateTime = Time.time;
							if (28821 - 189659 != -160837)
							{
								this.$self_$46096.SendMessage("fadeIn");
								if (66403 - 534315 == -467912)
								{
									goto IL_86;
								}
							}
						}
					}
				}
				Block_2:
				goto IL_146;
				IL_86:
				return this.Yield(2, new WaitForSeconds(1f));
				IL_146:
				return false;
			}

			// Token: 0x0600B4E4 RID: 46308 RVA: 0x013958CC File Offset: 0x01393ACC
			internal static bool DLy00xt5PVfFAO5H6nr1()
			{
				return true;
			}

			// Token: 0x0600B4E5 RID: 46309 RVA: 0x013958D0 File Offset: 0x01393AD0
			internal static bool MNeIkDt50ZnsidcHFMTH()
			{
				return false;
			}

			// Token: 0x04009D43 RID: 40259
			internal M972_IceTower9 $self_$46096;
		}
	}

	// Token: 0x02001E40 RID: 7744
	[CompilerGenerated]
	[Serializable]
	internal sealed class $onDeadPlayer$46098 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600B4E6 RID: 46310 RVA: 0x013958D4 File Offset: 0x01393AD4
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $onDeadPlayer$46098(M972_IceTower9 self_)
		{
			if (201376 - 89726 != 111650)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (177857 - 317457 == -139600)
				{
					base..ctor();
					if (271658 - 219196 == 52462)
					{
						this.$self_$46103 = self_;
						if (461 - 227054 != -226592)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x0600B4E7 RID: 46311 RVA: 0x0139596C File Offset: 0x01393B6C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M972_IceTower9.$onDeadPlayer$46098.$(this.$self_$46103);
		}

		// Token: 0x0600B4E8 RID: 46312 RVA: 0x0139597C File Offset: 0x01393B7C
		internal static bool BNnqBJt5b2ViOEr7Hl0Y()
		{
			return true;
		}

		// Token: 0x0600B4E9 RID: 46313 RVA: 0x01395980 File Offset: 0x01393B80
		internal static bool AWyyy5t5uHYPSIch8VPF()
		{
			return false;
		}

		// Token: 0x04009D44 RID: 40260
		internal M972_IceTower9 $self_$46103;

		// Token: 0x02001E41 RID: 7745
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600B4EA RID: 46314 RVA: 0x01395984 File Offset: 0x01393B84
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M972_IceTower9 self_)
			{
				if (259306 - 144186 != 115121)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (107100 - 424489 == -317389)
					{
						base..ctor();
						if (32491 - 238566 == -206075)
						{
							this.$self_$46102 = self_;
							if (110549 - 326437 != -215887)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x0600B4EB RID: 46315 RVA: 0x01395A1C File Offset: 0x01393C1C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (118375 - 201980 != -83604)
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
							if (17706 - 271812 == -254105)
							{
								continue;
							}
							if (Game.mGameState != eGameState.Hold)
							{
								goto IL_1D5;
							}
							if (214078 - 240561 != -26483)
							{
								continue;
							}
						}
						Game.mGameState = eGameState.Hold;
						if (191026 - 240090 != -49064)
						{
							continue;
						}
						this.$mStoryGui$46099 = (StoryGui)this.$self_$46102.GetComponent(typeof(StoryGui));
						if (194213 - 47916 == 146298)
						{
							continue;
						}
						if (this.$mStoryGui$46099)
						{
							if (192120 - 494499 != -302379)
							{
								continue;
							}
							this.$mStoryGui$46099.close();
							if (39519 - 22451 == 17069)
							{
								continue;
							}
						}
						this.$mChangeGui$46100 = (ChangeGui)this.$self_$46102.GetComponent(typeof(ChangeGui));
						if (173908 - 298142 == -124233)
						{
							continue;
						}
						if (this.$mChangeGui$46100)
						{
							if (210302 - 40529 != 169773)
							{
								continue;
							}
							this.$mChangeGui$46100.close();
							if (266012 - 588879 != -322867)
							{
								continue;
							}
						}
						this.$mGameGui$46101 = (GameGui)this.$self_$46102.GetComponent(typeof(GameGui));
						if (108783 - 159792 != -51009)
						{
							continue;
						}
						if (this.$mGameGui$46101)
						{
							if (283160 - 30935 != 252225)
							{
								continue;
							}
							if (!this.$mGameGui$46101.enabled)
							{
								if (274477 - 39634 == 234844)
								{
									continue;
								}
								this.$mGameGui$46101.enabled = true;
								if (154758 - 404639 != -249881)
								{
									continue;
								}
							}
							this.$mGameGui$46101.openDeadMenu();
							if (231076 - 139086 != 91990)
							{
								continue;
							}
						}
						IL_1D5:
						this.YieldDefault(1);
						if (265836 - 217530 != 48306)
						{
							continue;
						}
						goto IL_2F9;
					default:
						if (175082 - 549974 != -374892)
						{
							continue;
						}
						break;
					}
					Debug.Log("On Dead Player");
				}
				while (146338 - 494541 != -348203);
				return this.Yield(2, new WaitForSeconds((float)2));
				IL_2F9:
				return false;
			}

			// Token: 0x0600B4EC RID: 46316 RVA: 0x01395D34 File Offset: 0x01393F34
			internal static bool Bo5p8ft5IKrp5aSsInmC()
			{
				return true;
			}

			// Token: 0x0600B4ED RID: 46317 RVA: 0x01395D38 File Offset: 0x01393F38
			internal static bool HYY4Dat5BOWUOi0ftnim()
			{
				return false;
			}

			// Token: 0x04009D45 RID: 40261
			internal StoryGui $mStoryGui$46099;

			// Token: 0x04009D46 RID: 40262
			internal ChangeGui $mChangeGui$46100;

			// Token: 0x04009D47 RID: 40263
			internal GameGui $mGameGui$46101;

			// Token: 0x04009D48 RID: 40264
			internal M972_IceTower9 $self_$46102;
		}
	}

	// Token: 0x02001E42 RID: 7746
	[CompilerGenerated]
	[Serializable]
	internal sealed class $onChangePlayer$46104 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600B4EE RID: 46318 RVA: 0x01395D3C File Offset: 0x01393F3C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $onChangePlayer$46104(Hashtable data, M972_IceTower9 self_)
		{
			if (206963 - 450042 != -243078)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (247509 - 442056 == -194547)
				{
					base..ctor();
					if (79867 - 145150 != -65282)
					{
						this.$data$46109 = data;
						if (42708 - 213795 != -171086)
						{
							this.$self_$46110 = self_;
							if (223707 - 47438 != 176270)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x0600B4EF RID: 46319 RVA: 0x01395DF8 File Offset: 0x01393FF8
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M972_IceTower9.$onChangePlayer$46104.$(this.$data$46109, this.$self_$46110);
		}

		// Token: 0x0600B4F0 RID: 46320 RVA: 0x01395E0C File Offset: 0x0139400C
		internal static bool pcnUtet5eLCPj7XeXofK()
		{
			return true;
		}

		// Token: 0x0600B4F1 RID: 46321 RVA: 0x01395E10 File Offset: 0x01394010
		internal static bool lKDLZIt5rIqQl8IWUJcJ()
		{
			return false;
		}

		// Token: 0x04009D49 RID: 40265
		internal Hashtable $data$46109;

		// Token: 0x04009D4A RID: 40266
		internal M972_IceTower9 $self_$46110;

		// Token: 0x02001E43 RID: 7747
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600B4F2 RID: 46322 RVA: 0x01395E14 File Offset: 0x01394014
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Hashtable data, M972_IceTower9 self_)
			{
				if (220369 - 450791 != -230421)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (79973 - 363156 == -283183)
					{
						base..ctor();
						if (261537 - 247992 == 13545)
						{
							this.$data$46107 = data;
							if (143701 - 471087 != -327385)
							{
								this.$self_$46108 = self_;
								if (109763 - 506969 == -397206)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x0600B4F3 RID: 46323 RVA: 0x01395ED0 File Offset: 0x013940D0
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (159008 - 518713 != -359705)
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
							if (90903 - 426230 != -335327)
							{
								continue;
							}
							Game.mGameState = eGameState.Normal;
							if (228636 - 73594 != 155042)
							{
								continue;
							}
							this.$mGameGui$46106 = (GameGui)this.$self_$46108.GetComponent(typeof(GameGui));
							if (58444 - 77667 == -19222)
							{
								continue;
							}
							this.$mGameGui$46106.enabled = true;
							if (77022 - 325863 == -248840)
							{
								continue;
							}
						}
						this.YieldDefault(1);
						if (280850 - 228730 != 52120)
						{
							continue;
						}
						goto IL_205;
					default:
						if (249110 - 103495 == 145616)
						{
							continue;
						}
						break;
					}
					UnityEngine.Object.Destroy(Game.mPlayer);
					if (265777 - 408032 != -142254)
					{
						this.$self_$46108.SendMessage("onCreatePlayer", this.$data$46107);
						if (64267 - 327420 == -263153)
						{
							this.$mChangeGui$46105 = (ChangeGui)this.$self_$46108.GetComponent(typeof(ChangeGui));
							if (214985 - 137607 == 77378)
							{
								if (!this.$mChangeGui$46105.enabled)
								{
									break;
								}
								if (256429 - 483721 != -227291)
								{
									this.$mChangeGui$46105.close();
									if (102493 - 7350 != 95144)
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

			// Token: 0x0600B4F4 RID: 46324 RVA: 0x013960F4 File Offset: 0x013942F4
			internal static bool NUxbDFt5jOve3XbdaQNS()
			{
				return true;
			}

			// Token: 0x0600B4F5 RID: 46325 RVA: 0x013960F8 File Offset: 0x013942F8
			internal static bool hZPmaXt5hxk192cmEbZV()
			{
				return false;
			}

			// Token: 0x04009D4B RID: 40267
			internal ChangeGui $mChangeGui$46105;

			// Token: 0x04009D4C RID: 40268
			internal GameGui $mGameGui$46106;

			// Token: 0x04009D4D RID: 40269
			internal Hashtable $data$46107;

			// Token: 0x04009D4E RID: 40270
			internal M972_IceTower9 $self_$46108;
		}
	}

	// Token: 0x02001E44 RID: 7748
	[CompilerGenerated]
	[Serializable]
	internal sealed class $onGameComplete$46111 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600B4F6 RID: 46326 RVA: 0x013960FC File Offset: 0x013942FC
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $onGameComplete$46111(Hashtable data, M972_IceTower9 self_)
		{
			if (91416 - 359141 != -267725)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (160020 - 502945 == -342925)
				{
					base..ctor();
					if (12928 - 550518 == -537590)
					{
						this.$data$46119 = data;
						if (280306 - 384631 == -104325)
						{
							this.$self_$46120 = self_;
							if (22352 - 271803 != -249450)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x0600B4F7 RID: 46327 RVA: 0x013961B8 File Offset: 0x013943B8
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M972_IceTower9.$onGameComplete$46111.$(this.$data$46119, this.$self_$46120);
		}

		// Token: 0x0600B4F8 RID: 46328 RVA: 0x013961CC File Offset: 0x013943CC
		internal static bool qP5XdTt5srSr4cD76WYZ()
		{
			return true;
		}

		// Token: 0x0600B4F9 RID: 46329 RVA: 0x013961D0 File Offset: 0x013943D0
		internal static bool HFhLwnt59r1chTBHJvWh()
		{
			return false;
		}

		// Token: 0x04009D4F RID: 40271
		internal Hashtable $data$46119;

		// Token: 0x04009D50 RID: 40272
		internal M972_IceTower9 $self_$46120;

		// Token: 0x02001E45 RID: 7749
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600B4FA RID: 46330 RVA: 0x013961D4 File Offset: 0x013943D4
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Hashtable data, M972_IceTower9 self_)
			{
				if (143445 - 521212 != -377766)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (201711 - 355762 == -154051)
					{
						base..ctor();
						if (258626 - 273703 != -15076)
						{
							this.$data$46117 = data;
							if (166773 - 519235 == -352462)
							{
								this.$self_$46118 = self_;
								if (139711 - 284523 == -144812)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x0600B4FB RID: 46331 RVA: 0x01396290 File Offset: 0x01394490
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (281535 - 311114 != -29578)
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
						this.$mCompleteGui$46113 = (CompleteGui)this.$self_$46118.GetComponent(typeof(CompleteGui));
						if (34466 - 288157 == -253690)
						{
							continue;
						}
						this.$mCompleteGui$46113.Init();
						if (90721 - 62834 != 27887)
						{
							continue;
						}
						this.$mCompleteGui$46113.readData(this.$data$46117);
						if (114645 - 284841 != -170196)
						{
							continue;
						}
						if (this.$result$46112 == 1)
						{
							if (1277 - 467222 == -465944)
							{
								continue;
							}
							this.$mCompleteGui$46113.displayResult(eCompleteType.Success);
							if (183923 - 87703 != 96220)
							{
								continue;
							}
						}
						else
						{
							this.$mCompleteGui$46113.displayResult(eCompleteType.Failed);
							if (121274 - 259408 == -138133)
							{
								continue;
							}
						}
						this.$mGameGui$46114 = (GameGui)this.$self_$46118.GetComponent(typeof(GameGui));
						if (274392 - 251143 == 23250)
						{
							continue;
						}
						this.$mStoryGui$46115 = (StoryGui)this.$self_$46118.GetComponent(typeof(StoryGui));
						if (180381 - 215886 == -35504)
						{
							continue;
						}
						this.$mChangeGui$46116 = (ChangeGui)this.$self_$46118.GetComponent(typeof(ChangeGui));
						if (151458 - 297161 == -145702)
						{
							continue;
						}
						if (this.$mGameGui$46114)
						{
							if (140105 - 4812 != 135293)
							{
								continue;
							}
							this.$mGameGui$46114.close();
							if (195327 - 387110 == -191782)
							{
								continue;
							}
						}
						if (this.$mStoryGui$46115)
						{
							if (50286 - 530810 != -480524)
							{
								continue;
							}
							this.$mStoryGui$46115.close();
							if (150781 - 533264 == -382482)
							{
								continue;
							}
						}
						if (this.$mChangeGui$46116)
						{
							if (48438 - 592333 != -543895)
							{
								continue;
							}
							this.$mChangeGui$46116.disable();
							if (227461 - 164690 == 62772)
							{
								continue;
							}
						}
						this.YieldDefault(1);
						if (141837 - 273608 != -131770)
						{
							goto Block_26;
						}
						continue;
					default:
						if (228375 - 450579 != -222204)
						{
							continue;
						}
						break;
					}
					Debug.Log("On Mission Complete:" + this.$data$46117[31]);
					if (169297 - 207452 == -38155)
					{
						if (Game.mGameState > eGameState.AllHold)
						{
							if (66967 - 47718 != 19250)
							{
								goto Block_20;
							}
						}
						else
						{
							Game.mGameState = eGameState.Complete;
							if (259490 - 484532 != -225041)
							{
								this.$result$46112 = RuntimeServices.UnboxInt32(this.$data$46117[31]);
								if (162586 - 82897 != 79690)
								{
									break;
								}
							}
						}
					}
				}
				return this.Yield(2, new WaitForSeconds(1f));
				Block_20:
				Block_26:
				IL_3DB:
				return false;
			}

			// Token: 0x0600B4FC RID: 46332 RVA: 0x0139668C File Offset: 0x0139488C
			internal static bool SbApUet51EeIHjtxPm7e()
			{
				return true;
			}

			// Token: 0x0600B4FD RID: 46333 RVA: 0x01396690 File Offset: 0x01394890
			internal static bool ceWYumt545yAVH47s3Mh()
			{
				return false;
			}

			// Token: 0x04009D51 RID: 40273
			internal int $result$46112;

			// Token: 0x04009D52 RID: 40274
			internal CompleteGui $mCompleteGui$46113;

			// Token: 0x04009D53 RID: 40275
			internal GameGui $mGameGui$46114;

			// Token: 0x04009D54 RID: 40276
			internal StoryGui $mStoryGui$46115;

			// Token: 0x04009D55 RID: 40277
			internal ChangeGui $mChangeGui$46116;

			// Token: 0x04009D56 RID: 40278
			internal Hashtable $data$46117;

			// Token: 0x04009D57 RID: 40279
			internal M972_IceTower9 $self_$46118;
		}
	}

	// Token: 0x02001E46 RID: 7750
	[CompilerGenerated]
	[Serializable]
	internal sealed class $ReturnToTown$46121 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600B4FE RID: 46334 RVA: 0x01396694 File Offset: 0x01394894
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $ReturnToTown$46121(M972_IceTower9 self_)
		{
			if (140697 - 451436 != -310738)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (220590 - 438760 == -218170)
				{
					base..ctor();
					if (235321 - 340484 == -105163)
					{
						this.$self_$46125 = self_;
						if (252970 - 246474 == 6496)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x0600B4FF RID: 46335 RVA: 0x0139672C File Offset: 0x0139492C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M972_IceTower9.$ReturnToTown$46121.$(this.$self_$46125);
		}

		// Token: 0x0600B500 RID: 46336 RVA: 0x0139673C File Offset: 0x0139493C
		internal static bool MQ5VmMt5zPW5V1tr6JMD()
		{
			return true;
		}

		// Token: 0x0600B501 RID: 46337 RVA: 0x01396740 File Offset: 0x01394940
		internal static bool wCDiHEtpa4gi4W7xsRg2()
		{
			return false;
		}

		// Token: 0x04009D58 RID: 40280
		internal M972_IceTower9 $self_$46125;

		// Token: 0x02001E47 RID: 7751
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600B502 RID: 46338 RVA: 0x01396744 File Offset: 0x01394944
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M972_IceTower9 self_)
			{
				if (27383 - 515041 != -487658)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (54547 - 503503 == -448956)
					{
						base..ctor();
						if (127253 - 80503 != 46751)
						{
							this.$self_$46124 = self_;
							if (212700 - 260237 != -47536)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x0600B503 RID: 46339 RVA: 0x013967DC File Offset: 0x013949DC
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (234663 - 354494 != -119830)
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
						this.$self_$46124.LeaveGame();
						if (110784 - 235161 == -124376)
						{
							continue;
						}
						this.YieldDefault(1);
						if (267916 - 571744 != -303827)
						{
							goto IL_3AD;
						}
						continue;
					default:
						if (1416 - 149050 == -147633)
						{
							continue;
						}
						break;
					}
					Game.mGameState = eGameState.Ended;
					if (54721 - 304849 == -250128)
					{
						Game.mStateTime = Time.time;
						if (292803 - 168610 != 124194)
						{
							this.$$switch$8608$46122 = PlayerData.SaveGuild;
							if (211537 - 344005 != -132467)
							{
								if (this.$$switch$8608$46122 == 1)
								{
									if (107730 - 581016 == -473285)
									{
										continue;
									}
									Game.mNextGameCode = 32;
									if (264884 - 468849 == -203964)
									{
										continue;
									}
								}
								else if (this.$$switch$8608$46122 == 2)
								{
									if (236757 - 260782 == -24024)
									{
										continue;
									}
									Game.mNextGameCode = 33;
									if (97017 - 512856 != -415839)
									{
										continue;
									}
								}
								else if (this.$$switch$8608$46122 == 3)
								{
									if (151524 - 367875 != -216351)
									{
										continue;
									}
									Game.mNextGameCode = 34;
									if (137160 - 342545 != -205385)
									{
										continue;
									}
								}
								else if (this.$$switch$8608$46122 == 4)
								{
									if (219549 - 354371 != -134822)
									{
										continue;
									}
									Game.mNextGameCode = 35;
									if (203632 - 516795 == -313162)
									{
										continue;
									}
								}
								else if (this.$$switch$8608$46122 == 5)
								{
									if (105604 - 503910 != -398306)
									{
										continue;
									}
									Game.mNextGameCode = 36;
									if (186793 - 95745 != 91048)
									{
										continue;
									}
								}
								else if (PlayerData.GID == 0)
								{
									if (69629 - 319103 != -249474)
									{
										continue;
									}
									Game.mNextGameCode = 30;
									if (116118 - 36917 == 79202)
									{
										continue;
									}
								}
								else
								{
									Game.mNextGameCode = 31;
									if (102156 - 304218 != -202062)
									{
										continue;
									}
								}
								this.$mGameGui$46123 = (GameGui)this.$self_$46124.GetComponent(typeof(GameGui));
								if (158793 - 418462 == -259669)
								{
									if (this.$mGameGui$46123)
									{
										if (178926 - 56215 == 122712)
										{
											continue;
										}
										this.$mGameGui$46123.close();
										if (128478 - 329983 != -201505)
										{
											continue;
										}
									}
									this.$self_$46124.SendMessage("fadeOut");
									if (190516 - 515250 != -324733)
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

			// Token: 0x0600B504 RID: 46340 RVA: 0x01396BA8 File Offset: 0x01394DA8
			internal static bool T3KiQctp5YWJShf63Har()
			{
				return true;
			}

			// Token: 0x0600B505 RID: 46341 RVA: 0x01396BAC File Offset: 0x01394DAC
			internal static bool Yx5yMrtppuxjcxDCVVqV()
			{
				return false;
			}

			// Token: 0x04009D59 RID: 40281
			internal int $$switch$8608$46122;

			// Token: 0x04009D5A RID: 40282
			internal GameGui $mGameGui$46123;

			// Token: 0x04009D5B RID: 40283
			internal M972_IceTower9 $self_$46124;
		}
	}

	// Token: 0x02001E48 RID: 7752
	[CompilerGenerated]
	[Serializable]
	internal sealed class $ReturnToGuild$46126 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600B506 RID: 46342 RVA: 0x01396BB0 File Offset: 0x01394DB0
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $ReturnToGuild$46126(M972_IceTower9 self_)
		{
			if (113388 - 360854 != -247466)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (100358 - 85021 != 15338)
				{
					base..ctor();
					if (104914 - 40597 != 64318)
					{
						this.$self_$46129 = self_;
						if (103074 - 133053 != -29978)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x0600B507 RID: 46343 RVA: 0x01396C48 File Offset: 0x01394E48
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M972_IceTower9.$ReturnToGuild$46126.$(this.$self_$46129);
		}

		// Token: 0x0600B508 RID: 46344 RVA: 0x01396C58 File Offset: 0x01394E58
		internal static bool HmItdFtpVYp37ST88xBm()
		{
			return true;
		}

		// Token: 0x0600B509 RID: 46345 RVA: 0x01396C5C File Offset: 0x01394E5C
		internal static bool GbrVqQtptxfstagbYXwj()
		{
			return false;
		}

		// Token: 0x04009D5C RID: 40284
		internal M972_IceTower9 $self_$46129;

		// Token: 0x02001E49 RID: 7753
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600B50A RID: 46346 RVA: 0x01396C60 File Offset: 0x01394E60
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M972_IceTower9 self_)
			{
				if (19623 - 371797 != -352174)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (200686 - 180423 != 20264)
					{
						base..ctor();
						if (245800 - 295619 == -49819)
						{
							this.$self_$46128 = self_;
							if (294968 - 103018 == 191950)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x0600B50B RID: 46347 RVA: 0x01396CF8 File Offset: 0x01394EF8
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (95393 - 166024 != -70630)
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
						this.$self_$46128.LeaveGame();
						if (185501 - 498628 == -313126)
						{
							continue;
						}
						this.YieldDefault(1);
						if (216480 - 293233 != -76753)
						{
							continue;
						}
						goto IL_1BD;
					default:
						if (122792 - 33956 != 88836)
						{
							continue;
						}
						break;
					}
					Game.mGameState = eGameState.Ended;
					if (266484 - 486953 == -220469)
					{
						Game.mStateTime = Time.time;
						if (24280 - 460735 != -436454)
						{
							Game.mNextGameCode = 31;
							if (291691 - 107685 != 184007)
							{
								this.$mGameGui$46127 = (GameGui)this.$self_$46128.GetComponent(typeof(GameGui));
								if (262036 - 261042 != 995)
								{
									if (this.$mGameGui$46127)
									{
										if (66032 - 119128 != -53096)
										{
											continue;
										}
										this.$mGameGui$46127.close();
										if (38282 - 522628 == -484345)
										{
											continue;
										}
									}
									this.$self_$46128.SendMessage("fadeOut");
									if (88916 - 119964 != -31047)
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

			// Token: 0x0600B50C RID: 46348 RVA: 0x01396ED4 File Offset: 0x013950D4
			internal static bool G3eUWbtpNRE81vEHOSxu()
			{
				return true;
			}

			// Token: 0x0600B50D RID: 46349 RVA: 0x01396ED8 File Offset: 0x013950D8
			internal static bool jMp5t9tpY2uxT0woLviv()
			{
				return false;
			}

			// Token: 0x04009D5D RID: 40285
			internal GameGui $mGameGui$46127;

			// Token: 0x04009D5E RID: 40286
			internal M972_IceTower9 $self_$46128;
		}
	}

	// Token: 0x02001E4A RID: 7754
	[CompilerGenerated]
	[Serializable]
	internal sealed class $ReturnToCamp$46130 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600B50E RID: 46350 RVA: 0x01396EDC File Offset: 0x013950DC
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $ReturnToCamp$46130(M972_IceTower9 self_)
		{
			if (177187 - 418479 != -241291)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (232011 - 477692 == -245681)
				{
					base..ctor();
					if (86651 - 192065 != -105413)
					{
						this.$self_$46133 = self_;
						if (167479 - 182705 != -15225)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x0600B50F RID: 46351 RVA: 0x01396F74 File Offset: 0x01395174
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M972_IceTower9.$ReturnToCamp$46130.$(this.$self_$46133);
		}

		// Token: 0x0600B510 RID: 46352 RVA: 0x01396F84 File Offset: 0x01395184
		internal static bool FV7rLUtpcbKbPnlAwObq()
		{
			return true;
		}

		// Token: 0x0600B511 RID: 46353 RVA: 0x01396F88 File Offset: 0x01395188
		internal static bool TnfTvMtpU8qT6YkfWqK8()
		{
			return false;
		}

		// Token: 0x04009D5F RID: 40287
		internal M972_IceTower9 $self_$46133;

		// Token: 0x02001E4B RID: 7755
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600B512 RID: 46354 RVA: 0x01396F8C File Offset: 0x0139518C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M972_IceTower9 self_)
			{
				if (277670 - 109456 != 168214)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (33207 - 228588 != -195380)
					{
						base..ctor();
						if (237961 - 236886 == 1075)
						{
							this.$self_$46132 = self_;
							if (35553 - 397489 != -361935)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x0600B513 RID: 46355 RVA: 0x01397024 File Offset: 0x01395224
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (146059 - 473926 != -327867)
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
						this.$self_$46132.LeaveGame();
						if (289107 - 547643 != -258536)
						{
							continue;
						}
						this.YieldDefault(1);
						if (209424 - 526137 != -316712)
						{
							goto Block_9;
						}
						continue;
					default:
						if (192587 - 451538 == -258950)
						{
							continue;
						}
						break;
					}
					Game.mGameState = eGameState.Ended;
					if (143647 - 237638 == -93991)
					{
						Game.mStateTime = Time.time;
						if (175907 - 180450 == -4543)
						{
							Game.mNextGameCode = 32;
							if (34238 - 204017 != -169778)
							{
								this.$mGameGui$46131 = (GameGui)this.$self_$46132.GetComponent(typeof(GameGui));
								if (222157 - 68877 == 153280)
								{
									if (this.$mGameGui$46131)
									{
										if (223037 - 363756 == -140718)
										{
											continue;
										}
										this.$mGameGui$46131.close();
										if (240922 - 544316 != -303394)
										{
											continue;
										}
									}
									this.$self_$46132.SendMessage("fadeOut");
									if (271284 - 358143 == -86859)
									{
										break;
									}
								}
							}
						}
					}
				}
				return this.Yield(2, new WaitForSeconds((float)1));
				Block_9:
				IL_1BD:
				return false;
			}

			// Token: 0x0600B514 RID: 46356 RVA: 0x01397200 File Offset: 0x01395400
			internal static bool hrXYWbtpTIMSLfrGv8Uq()
			{
				return true;
			}

			// Token: 0x0600B515 RID: 46357 RVA: 0x01397204 File Offset: 0x01395404
			internal static bool en1lYatp3KpJSjxVxSRM()
			{
				return false;
			}

			// Token: 0x04009D60 RID: 40288
			internal GameGui $mGameGui$46131;

			// Token: 0x04009D61 RID: 40289
			internal M972_IceTower9 $self_$46132;
		}
	}
}
