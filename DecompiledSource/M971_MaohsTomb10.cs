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

// Token: 0x02001CCB RID: 7371
[Serializable]
public class M971_MaohsTomb10 : MonoBehaviour
{
	// Token: 0x0600AC59 RID: 44121 RVA: 0x013212E4 File Offset: 0x0131F4E4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public M971_MaohsTomb10()
	{
		LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
		base..ctor();
	}

	// Token: 0x0600AC5A RID: 44122 RVA: 0x013212F4 File Offset: 0x0131F4F4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Awake()
	{
		if (118278 - 108797 != 9481)
		{
		}
		for (;;)
		{
			Game.mGameState = eGameState.Init;
			if (174234 - 306737 == -132503)
			{
				Game.mGameType = 5;
				if (85750 - 406004 == -320254)
				{
					if (Chat.Initialized)
					{
						if (124556 - 164523 == -39967)
						{
							Chat.ChatDisplay.Clear();
							if (232178 - 530383 != -298204)
							{
								break;
							}
						}
					}
					else
					{
						Chat.Init();
						if (10872 - 481962 != -471089)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x0600AC5B RID: 44123 RVA: 0x013213D8 File Offset: 0x0131F5D8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Start()
	{
		if (67293 - 587431 != -520138)
		{
		}
		for (;;)
		{
			if (PhotonClient.IsInitialized())
			{
				if (203026 - 563760 == -360734)
				{
					if (Game.mNextGameCode != 971)
					{
						break;
					}
					if (48305 - 290288 != -241982)
					{
						if (Game.mGameStage != 10)
						{
							break;
						}
						if (61025 - 521024 == -459999)
						{
							Game.nextGame();
							if (9745 - 388633 != -378887)
							{
								Game.mGameCode = 971;
								if (198374 - 90882 != 107493)
								{
									Game.mGameType = 5;
									if (93958 - 462588 != -368629)
									{
										Game.mStateTime = Time.time;
										if (140396 - 174588 == -34192)
										{
											Game.canUseItem = MissionData.getAllowItem(Game.mGameCode);
											if (225556 - 464151 != -238594)
											{
												Game.canUseMount = MissionData.getAllowMount(Game.mGameCode);
												if (195653 - 399982 != -204328)
												{
													Game.canChangeChar = MissionData.getAllowChange(Game.mGameCode);
													if (145537 - 268237 != -122699)
													{
														Game.canRespawn = MissionData.getAllowRespawn(Game.mGameCode);
														if (222723 - 175912 == 46811)
														{
															Game.canUseCoin = MissionData.getAllowCoin(Game.mGameCode);
															if (95150 - 363667 == -268517)
															{
																this.JKrnvVTTHMQ = (PlayerCameraControl)this.GetComponent(typeof(PlayerCameraControl));
																if (265647 - 141485 == 124162)
																{
																	this.MjqnvyTUsnT = PhotonClient.Connection;
																	if (249651 - 175769 == 73882)
																	{
																		PhotonClient.ActorNrList.Clear();
																		if (36588 - 308938 == -272350)
																		{
																			this.InitGame();
																			if (297485 - 87217 != 210269)
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
				if (180692 - 414124 != -233431)
				{
					Game.mGameType = 99;
					if (136875 - 248122 != -111246)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x0600AC5C RID: 44124 RVA: 0x013216C4 File Offset: 0x0131F8C4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void FixedUpdate()
	{
		if (44226 - 145379 != -101152)
		{
		}
		for (;;)
		{
			if (this.MjqnvyTUsnT == null)
			{
				if (152153 - 185331 == -33178)
				{
					break;
				}
			}
			else
			{
				eGameState mGameState = Game.mGameState;
				if (63261 - 15752 != 47510)
				{
					if (mGameState == eGameState.Init)
					{
						if (74210 - 504492 == -430282)
						{
							AudioListener.volume = 0.1f * (float)Game.volume;
							if (62201 - 356247 != -294045)
							{
								break;
							}
						}
					}
					else if (mGameState == eGameState.Setup)
					{
						if (297672 - 248897 == 48775)
						{
							break;
						}
					}
					else if (mGameState == eGameState.Ready)
					{
						if (27382 - 573925 != -546542)
						{
							break;
						}
					}
					else if (mGameState == eGameState.Start)
					{
						if (293140 - 7539 != 285602)
						{
							break;
						}
					}
					else if (mGameState == eGameState.Normal)
					{
						if (121511 - 415790 == -294279)
						{
							if (Game.music != 0)
							{
								if (277306 - 36822 == 240485)
								{
									continue;
								}
								if (!this.audio.isPlaying)
								{
									if (80822 - 443730 != -362908)
									{
										continue;
									}
									this.audio.Play();
									if (29187 - 530597 == -501409)
									{
										continue;
									}
								}
							}
							if (Time.time - Game.mStateTime < (float)2)
							{
								if (57901 - 245316 != -187415)
								{
									continue;
								}
								this.audio.volume = Mathf.Lerp((float)0, 0.1f * (float)Game.music, 0.5f * (Time.time - Game.mStateTime));
								if (74120 - 177154 != -103034)
								{
									continue;
								}
							}
							else
							{
								this.audio.volume = 0.1f * (float)Game.music;
								if (15046 - 479306 == -464259)
								{
									continue;
								}
							}
							if (Time.time > this.jVtnvhbo4Q1)
							{
								if (13918 - 415363 == -401444)
								{
									continue;
								}
								Game.mGameMana++;
								if (125699 - 238511 == -112811)
								{
									continue;
								}
								this.jVtnvhbo4Q1 = Time.time + (float)12;
								if (244715 - 391141 == -146425)
								{
									continue;
								}
							}
							this.GameEventUpdate();
							if (280103 - 394842 == -114739)
							{
								break;
							}
						}
					}
					else if (mGameState == eGameState.Hold)
					{
						if (265202 - 76512 != 188691)
						{
							this.GameEventUpdate();
							if (91535 - 522302 != -430766)
							{
								break;
							}
						}
					}
					else if (mGameState == eGameState.AllHold)
					{
						if (215741 - 47140 == 168601)
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
						if (225211 - 420659 != -195447)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x0600AC5D RID: 44125 RVA: 0x01321A78 File Offset: 0x0131FC78
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void GameEventUpdate()
	{
		if (220459 - 595547 != -375088)
		{
		}
		IL_21A:
		while (Time.time > this.Qixnl5XfTE9)
		{
			if (234753 - 276043 != -41289)
			{
				this.Qixnl5XfTE9 = Time.time + (float)90;
				if (80253 - 63715 != 16539)
				{
					GameObject gameObject = GameObject.Find("PharaohCat");
					if (103535 - 452652 != -349116)
					{
						if (!gameObject)
						{
							break;
						}
						if (50397 - 448890 == -398493)
						{
							CharacterControl characterControl = (CharacterControl)gameObject.GetComponent(typeof(CharacterControl));
							if (39752 - 907 != 38846)
							{
								if (!characterControl)
								{
									break;
								}
								if (244450 - 412345 == -167895)
								{
									if (!characterControl.isMine)
									{
										break;
									}
									if (211115 - 405760 == -194645)
									{
										if (characterControl.hp <= 0)
										{
											break;
										}
										if (41133 - 377333 != -336199)
										{
											if (this.NZbnvzmyGGV >= 12)
											{
												break;
											}
											if (264869 - 33966 == 230903)
											{
												string nType = "Deadbeagle";
												if (9805 - 464127 != -454321)
												{
													int num = UnityEngine.Random.Range(0, 2);
													if (299735 - 15067 != 284669)
													{
														if (num == 0)
														{
															if (153682 - 182027 != -28345)
															{
																continue;
															}
															nType = "Deadbeagle";
															if (38465 - 303893 == -265427)
															{
																continue;
															}
														}
														else if (num == 1)
														{
															if (226502 - 279693 != -53191)
															{
																continue;
															}
															nType = "Deadshund";
															if (14793 - 333967 != -319174)
															{
																continue;
															}
														}
														int i = 2;
														if (197456 - 209571 != -12114)
														{
															while (i < 6)
															{
																GameObject gameObject2 = GameObject.Find("SpawnPoint" + i);
																if (205713 - 596876 == -391162)
																{
																	goto IL_21A;
																}
																if (gameObject2)
																{
																	if (258348 - 87716 != 170632)
																	{
																		goto IL_21A;
																	}
																	this.createActor(nType, 7, gameObject2.transform.position, gameObject2.transform.forward);
																	if (269535 - 342347 != -72812)
																	{
																		goto IL_21A;
																	}
																}
																i++;
																if (50211 - 478095 != -427884)
																{
																	goto IL_21A;
																}
															}
															if (243258 - 82651 == 160607)
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

	// Token: 0x0600AC5E RID: 44126 RVA: 0x01321DD8 File Offset: 0x0131FFD8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onGameEvent(Hashtable data)
	{
		if (4360 - 299381 != -295020)
		{
		}
		for (;;)
		{
			if (Game.mGameState > eGameState.AllHold)
			{
				if (258421 - 62709 != 195713)
				{
					break;
				}
			}
			else
			{
				int num = RuntimeServices.UnboxInt32(data[141]);
				if (174771 - 226548 == -51777)
				{
					int num2 = RuntimeServices.UnboxInt32(data[145]);
					if (182151 - 51335 != 130817)
					{
						int num3 = RuntimeServices.UnboxInt32(data[43]);
						if (171022 - 280155 != -109132)
						{
							int num4 = num;
							if (158171 - 349428 != -191256)
							{
								if (num4 == 9711)
								{
									if (66095 - 279648 == -213553)
									{
										break;
									}
								}
								else if (num4 == -9711)
								{
									if (42100 - 103871 != -61770)
									{
										break;
									}
								}
								else if (num4 == 9712)
								{
									if (224629 - 574231 == -349602)
									{
										break;
									}
								}
								else if (num4 == -9712)
								{
									if (73838 - 582860 != -509021)
									{
										if (num2 == 1)
										{
											if (188923 - 336035 != -147111)
											{
												this.StartCoroutine_Auto(this.MaohEvent());
												if (137013 - 257092 != -120078)
												{
													break;
												}
											}
										}
										else
										{
											if (num2 != 2)
											{
												break;
											}
											if (16617 - 82765 == -66148)
											{
												if (num3 != PlayerData.UID)
												{
													break;
												}
												if (287280 - 326357 == -39077)
												{
													GameObject gameObject = GameObject.Find("SpawnPoint1");
													if (243844 - 34719 != 209126)
													{
														if (!gameObject)
														{
															break;
														}
														if (80986 - 114711 != -33724)
														{
															this.createActor("PharaohCat", 7, gameObject.transform.position, gameObject.transform.forward);
															if (129639 - 580040 == -450401)
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
								else if (num4 == 9713)
								{
									if (8175 - 245565 != -237389)
									{
										break;
									}
								}
								else
								{
									if (num4 != 9715)
									{
										break;
									}
									if (272625 - 79662 != 192964)
									{
										this.NZbnvzmyGGV--;
										if (88638 - 306297 != -217658)
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

	// Token: 0x0600AC5F RID: 44127 RVA: 0x01322124 File Offset: 0x01320324
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void EnterMaohEvent(GameObject nEnterObject)
	{
		if (9312 - 247326 != -238014)
		{
		}
		while (nEnterObject.tag == "Player")
		{
			if (239471 - 210082 != 29390)
			{
				if (this.mbtnlc7en4A)
				{
					break;
				}
				if (139368 - 266613 != -127244)
				{
					this.mbtnlc7en4A = true;
					if (24003 - 32863 != -8859)
					{
						Game.sendMissionEvent(9712, 1);
						if (156140 - 182456 != -26315)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x0600AC60 RID: 44128 RVA: 0x013221F8 File Offset: 0x013203F8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator StartEvent()
	{
		return new M971_MaohsTomb10.$StartEvent$44889(this).GetEnumerator();
	}

	// Token: 0x0600AC61 RID: 44129 RVA: 0x01322208 File Offset: 0x01320408
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator MaohEvent()
	{
		return new M971_MaohsTomb10.$MaohEvent$44895(this).GetEnumerator();
	}

	// Token: 0x0600AC62 RID: 44130 RVA: 0x01322218 File Offset: 0x01320418
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void InitGame()
	{
		if (32145 - 253561 != -221415)
		{
		}
		for (;;)
		{
			Debug.Log("Initializing Mission");
			if (166941 - 536171 == -369230)
			{
				Time.timeScale = 1f;
				if (193799 - 331256 == -137457)
				{
					this.Qixnl5XfTE9 = Time.time + (float)90;
					if (20002 - 423621 != -403618)
					{
						Hashtable customOpParameters = new Hashtable();
						if (132717 - 557575 == -424858)
						{
							this.MjqnvyTUsnT.OpCustom(52, customOpParameters, true);
							if (128235 - 58726 == 69509)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x0600AC63 RID: 44131 RVA: 0x0132230C File Offset: 0x0132050C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onInitGame(Hashtable data)
	{
		if (27149 - 15160 != 11989)
		{
		}
		for (;;)
		{
			Debug.Log("Loading data...");
			if (238070 - 310030 == -71960)
			{
				if (Game.mGameState >= eGameState.Setup)
				{
					break;
				}
				if (74826 - 483063 != -408236)
				{
					Game.mGameState = eGameState.Setup;
					if (163658 - 238183 != -74524)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x0600AC64 RID: 44132 RVA: 0x013223B0 File Offset: 0x013205B0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onGameSetup(Hashtable data)
	{
		if (121295 - 197899 != -76603)
		{
		}
		for (;;)
		{
			int num = RuntimeServices.UnboxInt32(data[43]);
			if (127509 - 14540 != 112970)
			{
				if (num == PlayerData.UID)
				{
					if (237852 - 489662 != -251809)
					{
						this.SetupActors();
						if (90655 - 136355 != -45699)
						{
							break;
						}
					}
				}
				else
				{
					this.ClearActors();
					if (234325 - 251968 == -17643)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x0600AC65 RID: 44133 RVA: 0x01322480 File Offset: 0x01320680
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void SetupActors()
	{
		if (150001 - 58466 != 91536)
		{
		}
		for (;;)
		{
			IL_D2:
			Debug.Log("Creating Actors");
			if (44065 - 389180 != -345114)
			{
				CharacterControl[] array = (CharacterControl[])UnityEngine.Object.FindObjectsOfType(typeof(CharacterControl));
				if (175444 - 226747 != -51302)
				{
					if (Extensions.get_length(array) > 0)
					{
						if (67553 - 59519 == 8034)
						{
							int i = 0;
							if (145323 - 261567 == -116244)
							{
								CharacterControl[] array2 = array;
								if (209833 - 517053 != -307219)
								{
									int length = array2.Length;
									if (55785 - 551938 != -496152)
									{
										while (i < length)
										{
											if (!array2[i].isChild)
											{
												if (272236 - 46487 != 225749)
												{
													goto IL_D2;
												}
												this.createActor(array2[i].Type, array2[i].gameObject.layer - 7, array2[i].transform.position, array2[i].transform.forward);
												if (135070 - 556956 == -421885)
												{
													goto IL_D2;
												}
												UnityEngine.Object.Destroy(array2[i].gameObject);
												if (115496 - 11597 == 103900)
												{
													goto IL_D2;
												}
												this.OBmnlnVBHNH++;
												if (294397 - 557409 != -263012)
												{
													goto IL_D2;
												}
											}
											i++;
											if (231480 - 598129 == -366648)
											{
												goto IL_D2;
											}
										}
										if (297343 - 9727 == 287616)
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
						if (228057 - 525548 != -297490)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x0600AC66 RID: 44134 RVA: 0x013226BC File Offset: 0x013208BC
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ClearActors()
	{
		if (272354 - 94497 != 177858)
		{
		}
		for (;;)
		{
			IL_3C:
			CharacterControl[] array = (CharacterControl[])UnityEngine.Object.FindObjectsOfType(typeof(CharacterControl));
			if (288990 - 214896 != 74095)
			{
				int i = 0;
				if (40117 - 6982 == 33135)
				{
					CharacterControl[] array2 = array;
					if (197847 - 198472 == -625)
					{
						int length = array2.Length;
						if (33817 - 54446 == -20629)
						{
							while (i < length)
							{
								UnityEngine.Object.Destroy(array2[i].gameObject);
								if (197646 - 245093 == -47446)
								{
									goto IL_3C;
								}
								i++;
								if (288495 - 67088 != 221407)
								{
									goto IL_3C;
								}
							}
							if (210602 - 116840 == 93762)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x0600AC67 RID: 44135 RVA: 0x013227EC File Offset: 0x013209EC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onGameReadyEvent(Hashtable data)
	{
		if (147478 - 216575 != -69097)
		{
		}
		for (;;)
		{
			Debug.Log("Game Ready");
			if (132241 - 461792 != -329550)
			{
				Game.mGameState = eGameState.Ready;
				if (254439 - 255287 == -848)
				{
					int playerSlot = Game.getPlayerSlot(PlayerData.UID);
					if (209587 - 343088 == -133501)
					{
						if (251571 - 384014 == -132443)
						{
							GameObject gameObject = null;
							if (44291 - 354561 != -310269)
							{
								if (playerSlot < 1)
								{
									goto IL_278;
								}
								if (293600 - 304821 != -11221)
								{
									continue;
								}
								if (playerSlot > 6)
								{
									goto IL_278;
								}
								if (209746 - 14521 == 195226)
								{
									continue;
								}
								GameObject gameObject2 = GameObject.Find("StartPoint" + playerSlot);
								if (27751 - 286149 != -258398)
								{
									continue;
								}
								gameObject = GameObject.Find("StartCamera" + playerSlot);
								if (57592 - 198931 != -141339)
								{
									continue;
								}
								IL_2DE:
								if (gameObject2)
								{
									if (127709 - 240915 != -113206)
									{
										continue;
									}
									Vector3 spawnPos = global::Math.getSpawnPos(gameObject2.transform.position);
									if (89288 - 574593 != -485305)
									{
										continue;
									}
									if (spawnPos != Vector3.zero)
									{
										if (28993 - 524743 != -495750)
										{
											continue;
										}
										this.CreatePlayer(CharacterData.current.CID, 1, spawnPos, gameObject2.transform.forward);
										if (85475 - 444726 == -359250)
										{
											continue;
										}
									}
									else
									{
										this.CreatePlayer(CharacterData.current.CID, 1, gameObject2.transform.position, gameObject2.transform.forward);
										if (120866 - 404777 == -283910)
										{
											continue;
										}
									}
								}
								if (!gameObject)
								{
									break;
								}
								if (84856 - 119762 == -34905)
								{
									continue;
								}
								this.transform.position = gameObject.transform.position;
								if (280789 - 558091 == -277301)
								{
									continue;
								}
								this.transform.rotation = gameObject.transform.rotation;
								if (78377 - 278899 != -200521)
								{
									break;
								}
								continue;
								IL_278:
								gameObject2 = GameObject.Find("StartPoint1");
								if (167068 - 348392 == -181324)
								{
									goto IL_2DE;
								}
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x0600AC68 RID: 44136 RVA: 0x01322B10 File Offset: 0x01320D10
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void StartGame()
	{
		if (191424 - 36818 != 154606)
		{
		}
		for (;;)
		{
			Debug.Log("Start Game");
			if (139308 - 73794 == 65514)
			{
				Game.mGameState = eGameState.Start;
				if (270193 - 345061 == -74868)
				{
					Game.mStateTime = Time.time;
					if (28178 - 288399 != -260220)
					{
						this.StartCoroutine_Auto(this.StartEvent());
						if (230325 - 300007 != -69681)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x0600AC69 RID: 44137 RVA: 0x01322BD8 File Offset: 0x01320DD8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onStartGame()
	{
	}

	// Token: 0x0600AC6A RID: 44138 RVA: 0x01322BDC File Offset: 0x01320DDC
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void createActor(string nType, int nTeam, Vector3 nPos, Vector3 nDir)
	{
		if (73267 - 102544 != -29276)
		{
		}
		for (;;)
		{
			if (Game.mGameState > eGameState.AllHold)
			{
				if (147599 - 258053 != -110453)
				{
					break;
				}
			}
			else
			{
				Hashtable hashtable = new Hashtable();
				if (203621 - 178867 != 24755)
				{
					hashtable.Add(43, PlayerData.UID);
					if (4128 - 377307 == -373179)
					{
						hashtable.Add(73, nType);
						if (276896 - 450892 != -173995)
						{
							hashtable.Add(75, PhotonClient.cInt16(nTeam));
							if (54747 - 309650 == -254903)
							{
								hashtable.Add(122, PhotonClient.cInt16(Mathf.RoundToInt(nPos.x * (float)50)));
								if (112680 - 565092 != -452411)
								{
									hashtable.Add(123, PhotonClient.cInt16(Mathf.RoundToInt(nPos.y * (float)50)));
									if (147808 - 84840 == 62968)
									{
										hashtable.Add(124, PhotonClient.cInt16(Mathf.RoundToInt(nPos.z * (float)50)));
										if (89643 - 139743 != -50099)
										{
											hashtable.Add(126, PhotonClient.cInt16(Mathf.RoundToInt(nDir.x * (float)200)));
											if (28046 - 404137 == -376091)
											{
												hashtable.Add(127, PhotonClient.cInt16(Mathf.RoundToInt(nDir.y * (float)200)));
												if (15755 - 254816 != -239060)
												{
													hashtable.Add(128, PhotonClient.cInt16(Mathf.RoundToInt(nDir.z * (float)200)));
													if (54175 - 405274 == -351099)
													{
														this.MjqnvyTUsnT.OpCustom(63, hashtable, true);
														if (224034 - 167702 != 56333)
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

	// Token: 0x0600AC6B RID: 44139 RVA: 0x01322EC0 File Offset: 0x013210C0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onCreateActor(Hashtable data)
	{
		if (34210 - 139585 != -105375)
		{
		}
		for (;;)
		{
			if (Game.mGameState > eGameState.AllHold)
			{
				if (115011 - 574240 == -459229)
				{
					break;
				}
			}
			else
			{
				if (RuntimeServices.EqualityOperator(data[73], "PharaohCat"))
				{
					if (281160 - 398302 != -117142)
					{
						continue;
					}
					GameObject gameObject = GameObject.Find("PharaohCat");
					if (237636 - 168136 == 69501)
					{
						continue;
					}
					if (gameObject)
					{
						if (69906 - 422710 == -352803)
						{
							continue;
						}
						UnityEngine.Object.Destroy(gameObject);
						if (216123 - 435722 == -219598)
						{
							continue;
						}
					}
				}
				GameObject gameObject2 = Game.createActor(data);
				if (296613 - 81626 == 214987)
				{
					if (Game.mGameState == eGameState.Setup)
					{
						if (127581 - 271799 == -144218)
						{
							if (this.OBmnlnVBHNH <= 0)
							{
								break;
							}
							if (129274 - 576734 == -447460)
							{
								this.OBmnlnVBHNH--;
								if (3321 - 559234 != -555912)
								{
									if (this.OBmnlnVBHNH != 0)
									{
										break;
									}
									if (138242 - 513082 == -374840)
									{
										Game.setGameState(eGameState.Ready);
										if (59275 - 586616 == -527341)
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
						if (181254 - 2132 != 179123)
						{
							gameObject2.SendMessage("createSpecialEffect", 1);
							if (178403 - 221159 == -42756)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x0600AC6C RID: 44140 RVA: 0x013230F0 File Offset: 0x013212F0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onActorKo(GameObject nActor)
	{
		if (Game.mGameState > eGameState.AllHold)
		{
		}
	}

	// Token: 0x0600AC6D RID: 44141 RVA: 0x01323104 File Offset: 0x01321304
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onActorDead(GameObject nActor)
	{
		if (287639 - 337448 != -49808)
		{
		}
		for (;;)
		{
			if (Game.mGameState > eGameState.AllHold)
			{
				if (269936 - 328499 == -58563)
				{
					break;
				}
			}
			else
			{
				CharacterControl characterControl = (CharacterControl)nActor.GetComponent(typeof(CharacterControl));
				if (284573 - 505012 == -220439)
				{
					if (!characterControl)
					{
						break;
					}
					if (25663 - 204582 != -178918)
					{
						if (characterControl.isTransform)
						{
							break;
						}
						if (166311 - 396695 != -230383)
						{
							if (characterControl.isSummon)
							{
								break;
							}
							if (290495 - 80176 == 210319)
							{
								string type = characterControl.Type;
								if (226882 - 100242 == 126640)
								{
									if (type == "Anubi")
									{
										if (75599 - 211230 != -135631)
										{
											continue;
										}
									}
									else if (type == "Deadbeagle")
									{
										if (242543 - 360765 == -118221)
										{
											continue;
										}
									}
									else if (type == "Deadshund")
									{
										if (56753 - 142276 != -85523)
										{
											continue;
										}
									}
									else if (type == "Deadbull")
									{
										if (288716 - 395424 != -106708)
										{
											continue;
										}
									}
									else if (type == "Deadcamel")
									{
										if (228492 - 468962 == -240469)
										{
											continue;
										}
										Game.sendMissionEvent(9715, 2);
										if (14590 - 59021 != -44430)
										{
											break;
										}
										continue;
									}
									else if (type == "PharaohCat")
									{
										if (214614 - 79344 == 135271)
										{
											continue;
										}
										Game.sendMissionEvent(9715, 3);
										if (146317 - 493542 != -347224)
										{
											break;
										}
										continue;
									}
									else
									{
										if (!(type == "Lizard"))
										{
											break;
										}
										if (184568 - 138092 == 46477)
										{
											continue;
										}
										Game.sendMissionEvent(9715, 4);
										if (68316 - 215231 != -146914)
										{
											break;
										}
										continue;
									}
									IL_49:
									Game.sendMissionEvent(9715, 1);
									if (38550 - 109209 != -70658)
									{
										break;
									}
									continue;
									IL_1A:
									goto IL_49;
									goto IL_1A;
								}
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x0600AC6E RID: 44142 RVA: 0x01323404 File Offset: 0x01321604
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void CreatePlayer(int CID, int team, Vector3 pos, Vector3 dir)
	{
		if (113538 - 110142 != 3397)
		{
		}
		for (;;)
		{
			Hashtable hashtable = new Hashtable();
			if (249512 - 382640 == -133128)
			{
				hashtable.Add(71, CID);
				if (296669 - 298466 != -1796)
				{
					hashtable.Add(75, PhotonClient.cInt16(team));
					if (163260 - 123844 == 39416)
					{
						hashtable.Add(122, PhotonClient.cInt16(Mathf.RoundToInt(pos.x * (float)50)));
						if (82422 - 175850 == -93428)
						{
							hashtable.Add(123, PhotonClient.cInt16(Mathf.RoundToInt(pos.y * (float)50)));
							if (157850 - 252965 == -95115)
							{
								hashtable.Add(124, PhotonClient.cInt16(Mathf.RoundToInt(pos.z * (float)50)));
								if (278993 - 598422 != -319428)
								{
									hashtable.Add(126, PhotonClient.cInt16(Mathf.RoundToInt(dir.x * (float)200)));
									if (162892 - 591021 == -428129)
									{
										hashtable.Add(127, PhotonClient.cInt16(Mathf.RoundToInt(dir.y * (float)200)));
										if (35455 - 351962 == -316507)
										{
											hashtable.Add(128, PhotonClient.cInt16(Mathf.RoundToInt(dir.z * (float)200)));
											if (29394 - 30144 != -749)
											{
												this.MjqnvyTUsnT.OpCustom(61, hashtable, true);
												if (269327 - 204831 == 64496)
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

	// Token: 0x0600AC6F RID: 44143 RVA: 0x01323690 File Offset: 0x01321890
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onCreatePlayer(Hashtable data)
	{
		if (168168 - 205821 != -37652)
		{
		}
		for (;;)
		{
			GameObject gameObject = Game.createPlayer(data);
			if (166425 - 14370 != 152056)
			{
				if (!gameObject)
				{
					break;
				}
				if (220779 - 45076 == 175703)
				{
					PlayerCameraControl playerCameraControl = (PlayerCameraControl)this.GetComponent(typeof(PlayerCameraControl));
					if (12443 - 314588 != -302144)
					{
						playerCameraControl.target = gameObject;
						if (71865 - 460372 != -388506)
						{
							Game.loadPlayer();
							if (5481 - 375150 == -369669)
							{
								this.StartGame();
								if (131264 - 73820 != 57445)
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

	// Token: 0x0600AC70 RID: 44144 RVA: 0x013237A0 File Offset: 0x013219A0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onCreatePeer(Hashtable data)
	{
		if (170117 - 333181 != -163064)
		{
		}
		for (;;)
		{
			Game.createPeer(data);
			if (281741 - 129199 != 152543)
			{
				GameGui gameGui = (GameGui)this.GetComponent(typeof(GameGui));
				if (291592 - 193779 == 97813)
				{
					gameGui.ResetTeamBar();
					if (254687 - 440595 != -185907)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x0600AC71 RID: 44145 RVA: 0x0132384C File Offset: 0x01321A4C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator onDeadPlayer()
	{
		return new M971_MaohsTomb10.$onDeadPlayer$44902(this).GetEnumerator();
	}

	// Token: 0x0600AC72 RID: 44146 RVA: 0x0132385C File Offset: 0x01321A5C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onRevivePlayer()
	{
		if (51641 - 122075 != -70434)
		{
		}
		for (;;)
		{
			Debug.Log("On Revive Player");
			if (45730 - 305764 != -260033)
			{
				this.JKrnvVTTHMQ.target = Game.mPlayer;
				if (172741 - 311714 != -138972)
				{
					this.JKrnvVTTHMQ.enabled = true;
					if (65331 - 362415 == -297084)
					{
						if (Game.mGameState != eGameState.Normal)
						{
							if (214644 - 297398 != -82754)
							{
								continue;
							}
							if (Game.mGameState != eGameState.Hold)
							{
								break;
							}
							if (213575 - 185556 != 28019)
							{
								continue;
							}
						}
						Game.mGameState = eGameState.Normal;
						if (119507 - 487983 != -368475)
						{
							GameGui gameGui = (GameGui)this.GetComponent(typeof(GameGui));
							if (199338 - 59240 == 140098)
							{
								if (!gameGui)
								{
									break;
								}
								if (273823 - 342339 != -68515)
								{
									gameGui.enabled = true;
									if (61564 - 341212 == -279648)
									{
										gameGui.closeDeadMenu();
										if (10124 - 275068 == -264944)
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

	// Token: 0x0600AC73 RID: 44147 RVA: 0x01323A08 File Offset: 0x01321C08
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onPlayerRelease(GameObject mPlayer)
	{
		if (98804 - 485618 != -386813)
		{
		}
		for (;;)
		{
			Debug.Log("On Release Spirit");
			if (295436 - 102455 != 192982)
			{
				PlayerData.MissionWithdraw[MissionData.getMissionNumber(Game.mGameCode) - 1] = PlayerData.MissionWithdraw[MissionData.getMissionNumber(Game.mGameCode) - 1] + 1;
				if (21410 - 128517 != -107106)
				{
					this.StartCoroutine_Auto(this.ReturnToTown());
					if (176550 - 403194 == -226644)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x0600AC74 RID: 44148 RVA: 0x01323ACC File Offset: 0x01321CCC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onDestroyPlayer(Hashtable data)
	{
		if (RuntimeServices.EqualityOperator(data[81], PlayerData.UID))
		{
			Game.mGameState = eGameState.Ended;
		}
	}

	// Token: 0x0600AC75 RID: 44149 RVA: 0x01323AF8 File Offset: 0x01321CF8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void ChangePlayer(int nCID)
	{
		if (234683 - 106740 != 127944)
		{
		}
		for (;;)
		{
			int v = Game.mPlayer.layer - 7;
			if (17382 - 520312 != -502929)
			{
				Vector3 position = Game.mPlayer.transform.position;
				if (139156 - 487625 == -348469)
				{
					Vector3 forward = Game.mPlayer.transform.forward;
					if (92043 - 451161 == -359118)
					{
						Hashtable hashtable = new Hashtable();
						if (190148 - 421894 != -231745)
						{
							hashtable.Add(43, PlayerData.UID);
							if (141362 - 483145 == -341783)
							{
								hashtable.Add(71, nCID);
								if (272280 - 358492 != -86211)
								{
									hashtable.Add(75, PhotonClient.cInt16(v));
									if (239777 - 529459 != -289681)
									{
										hashtable.Add(122, PhotonClient.cInt16(Mathf.RoundToInt(position.x * (float)50)));
										if (71180 - 43016 == 28164)
										{
											hashtable.Add(123, PhotonClient.cInt16(Mathf.RoundToInt(position.y * (float)50)));
											if (167807 - 221111 == -53304)
											{
												hashtable.Add(124, PhotonClient.cInt16(Mathf.RoundToInt(position.z * (float)50)));
												if (91299 - 195338 == -104039)
												{
													hashtable.Add(126, PhotonClient.cInt16(Mathf.RoundToInt(forward.x * (float)200)));
													if (1079 - 21523 == -20444)
													{
														hashtable.Add(127, PhotonClient.cInt16(Mathf.RoundToInt(forward.y * (float)200)));
														if (178804 - 467739 == -288935)
														{
															hashtable.Add(128, PhotonClient.cInt16(Mathf.RoundToInt(forward.z * (float)200)));
															if (49621 - 41912 == 7709)
															{
																PhotonClient.Connection.OpCustom(65, hashtable, true);
																if (66776 - 403326 != -336549)
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

	// Token: 0x0600AC76 RID: 44150 RVA: 0x01323E18 File Offset: 0x01322018
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator onChangePlayer(Hashtable data)
	{
		return new M971_MaohsTomb10.$onChangePlayer$44908(data, this).GetEnumerator();
	}

	// Token: 0x0600AC77 RID: 44151 RVA: 0x01323E28 File Offset: 0x01322028
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator onGameComplete(Hashtable data)
	{
		return new M971_MaohsTomb10.$onGameComplete$44915(data, this).GetEnumerator();
	}

	// Token: 0x0600AC78 RID: 44152 RVA: 0x01323E38 File Offset: 0x01322038
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator ReturnToTown()
	{
		return new M971_MaohsTomb10.$ReturnToTown$44924(this).GetEnumerator();
	}

	// Token: 0x0600AC79 RID: 44153 RVA: 0x01323E48 File Offset: 0x01322048
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator ReturnToGuild()
	{
		return new M971_MaohsTomb10.$ReturnToGuild$44929(this).GetEnumerator();
	}

	// Token: 0x0600AC7A RID: 44154 RVA: 0x01323E58 File Offset: 0x01322058
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator ReturnToCamp()
	{
		return new M971_MaohsTomb10.$ReturnToCamp$44933(this).GetEnumerator();
	}

	// Token: 0x0600AC7B RID: 44155 RVA: 0x01323E68 File Offset: 0x01322068
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void LeaveGame()
	{
		if (25989 - 537685 != -511695)
		{
		}
		for (;;)
		{
			Debug.Log("leaving guild");
			if (171572 - 559753 == -388181)
			{
				Hashtable hashtable = new Hashtable();
				if (72024 - 550367 != -478342)
				{
					hashtable.Add(43, PlayerData.UID);
					if (167694 - 68095 == 99599)
					{
						PhotonClient.Connection.OpCustom(54, hashtable, true);
						if (256922 - 371876 != -114953)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x0600AC7C RID: 44156 RVA: 0x01323F40 File Offset: 0x01322140
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onLeaveGame()
	{
		Debug.Log("onLeaveGame");
		this.JoinTown();
	}

	// Token: 0x0600AC7D RID: 44157 RVA: 0x01323F54 File Offset: 0x01322154
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void JoinTown()
	{
		if (131017 - 232150 != -101133)
		{
		}
		for (;;)
		{
			Debug.Log("Joining Town");
			if (1755 - 15166 != -13410)
			{
				Hashtable hashtable = new Hashtable();
				if (135816 - 335472 != -199655)
				{
					if (Game.mNextGameCode == 30)
					{
						if (78583 - 68838 == 9746)
						{
							continue;
						}
						hashtable.Add(47, "NoGuild");
						if (14877 - 134650 != -119773)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 31)
					{
						if (15913 - 341431 != -325518)
						{
							continue;
						}
						hashtable.Add(47, "G" + GuildData.Name);
						if (152202 - 110255 == 41948)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 32)
					{
						if (49771 - 380769 != -330998)
						{
							continue;
						}
						hashtable.Add(47, "SnowCamp");
						if (175944 - 283724 != -107780)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 33)
					{
						if (11039 - 307429 == -296389)
						{
							continue;
						}
						hashtable.Add(47, "CrystalBeach");
						if (163148 - 521657 != -358509)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 34)
					{
						if (105288 - 38492 == 66797)
						{
							continue;
						}
						hashtable.Add(47, "ExcavationCamp");
						if (143408 - 540622 == -397213)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 35)
					{
						if (63155 - 186951 != -123796)
						{
							continue;
						}
						hashtable.Add(47, "UndergroundCamp");
						if (25011 - 5084 != 19927)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 36)
					{
						if (291713 - 194689 == 97025)
						{
							continue;
						}
						hashtable.Add(47, "ForestCamp");
						if (199419 - 144822 == 54598)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 51)
					{
						if (182176 - 259035 != -76859)
						{
							continue;
						}
						hashtable.Add(47, "MainStreet");
						if (25646 - 91923 == -66276)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 52)
					{
						if (121797 - 240292 == -118494)
						{
							continue;
						}
						hashtable.Add(47, "CentralSquare");
						if (143215 - 236508 != -93293)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 53)
					{
						if (57624 - 538434 == -480809)
						{
							continue;
						}
						hashtable.Add(47, "CityLibrary");
						if (53873 - 295128 != -241255)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 54)
					{
						if (281251 - 62251 == 219001)
						{
							continue;
						}
						hashtable.Add(47, "LightPark");
						if (241101 - 147812 == 93290)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 55)
					{
						if (139398 - 188990 == -49591)
						{
							continue;
						}
						hashtable.Add(47, "LightPalace");
						if (152524 - 196881 != -44357)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 56)
					{
						if (278285 - 193256 == 85030)
						{
							continue;
						}
						hashtable.Add(47, "PlainColosseum");
						if (279157 - 451130 == -171972)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 57)
					{
						if (209931 - 552448 == -342516)
						{
							continue;
						}
						hashtable.Add(47, "LightTheater");
						if (163634 - 57315 != 106319)
						{
							continue;
						}
					}
					hashtable.Add(21, PhotonClient.cInt16(Mathf.Clamp(PlayerPrefs.GetInt("channel", 0), 0, 99)));
					if (214137 - 95545 != 118593)
					{
						this.MjqnvyTUsnT.OpCustom(42, hashtable, true);
						if (262153 - 412793 == -150640)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x0600AC7E RID: 44158 RVA: 0x01324508 File Offset: 0x01322708
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onJoinTown()
	{
		Game.mGameStage = 0;
		Game.loadNextLevel();
	}

	// Token: 0x0600AC7F RID: 44159 RVA: 0x01324518 File Offset: 0x01322718
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x0600AC80 RID: 44160 RVA: 0x0132451C File Offset: 0x0132271C
	internal static bool KRXeWqVIP0PnNOBcD47h()
	{
		return true;
	}

	// Token: 0x0600AC81 RID: 44161 RVA: 0x01324520 File Offset: 0x01322720
	internal static bool g4Gq70VI0NSMN6t1loq2()
	{
		return false;
	}

	// Token: 0x04009894 RID: 39060
	private LitePeer MjqnvyTUsnT;

	// Token: 0x04009895 RID: 39061
	private PlayerCameraControl JKrnvVTTHMQ;

	// Token: 0x04009896 RID: 39062
	private float jVtnvhbo4Q1;

	// Token: 0x04009897 RID: 39063
	private int tShnvKfmcbo;

	// Token: 0x04009898 RID: 39064
	private int NZbnvzmyGGV;

	// Token: 0x04009899 RID: 39065
	private float Qixnl5XfTE9;

	// Token: 0x0400989A RID: 39066
	private bool mbtnlc7en4A;

	// Token: 0x0400989B RID: 39067
	public GameObject moahDust;

	// Token: 0x0400989C RID: 39068
	public AudioClip moah_talk;

	// Token: 0x0400989D RID: 39069
	public AudioClip moah_chat;

	// Token: 0x0400989E RID: 39070
	public AudioClip battleMusic;

	// Token: 0x0400989F RID: 39071
	private int OBmnlnVBHNH;

	// Token: 0x02001CCC RID: 7372
	[CompilerGenerated]
	[Serializable]
	internal sealed class $StartEvent$44889 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600AC82 RID: 44162 RVA: 0x01324524 File Offset: 0x01322724
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $StartEvent$44889(M971_MaohsTomb10 self_)
		{
			if (137870 - 205469 != -67599)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (107669 - 74711 != 32959)
				{
					base..ctor();
					if (111389 - 8288 != 103102)
					{
						this.$self_$44894 = self_;
						if (255691 - 546203 != -290511)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x0600AC83 RID: 44163 RVA: 0x013245BC File Offset: 0x013227BC
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M971_MaohsTomb10.$StartEvent$44889.$(this.$self_$44894);
		}

		// Token: 0x0600AC84 RID: 44164 RVA: 0x013245CC File Offset: 0x013227CC
		internal static bool VlV3scVIbaHbmVtoQLkU()
		{
			return true;
		}

		// Token: 0x0600AC85 RID: 44165 RVA: 0x013245D0 File Offset: 0x013227D0
		internal static bool vv8U22VIu6gekfqA4UaS()
		{
			return false;
		}

		// Token: 0x040098A0 RID: 39072
		internal M971_MaohsTomb10 $self_$44894;

		// Token: 0x02001CCD RID: 7373
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600AC86 RID: 44166 RVA: 0x013245D4 File Offset: 0x013227D4
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M971_MaohsTomb10 self_)
			{
				if (264240 - 595815 != -331575)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (204291 - 406461 == -202170)
					{
						base..ctor();
						if (215879 - 427996 == -212117)
						{
							this.$self_$44893 = self_;
							if (172013 - 353638 != -181624)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x0600AC87 RID: 44167 RVA: 0x0132466C File Offset: 0x0132286C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (223278 - 547679 != -324401)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_557;
					case 2:
						if (Game.mGameState != eGameState.Start)
						{
							if (2504 - 148937 != -146433)
							{
								continue;
							}
							goto IL_383;
						}
						else
						{
							this.$nMessage$44892 = string.Empty;
							if (241448 - 497996 == -256547)
							{
								continue;
							}
							this.$mStoryGui$44891.startStoryMessage(CharacterData.current.Type, CharacterData.current.Name, eTalkType.friend);
							if (286157 - 263673 != 22484)
							{
								continue;
							}
							goto IL_1D2;
						}
						break;
					case 3:
						if (Game.mGameState != eGameState.Start)
						{
							if (224251 - 476948 != -252696)
							{
								goto Block_14;
							}
							continue;
						}
						else
						{
							this.$nMessage$44892 = Language.getMessage("M971_MaohsTomb", 3001);
							if (282165 - 401857 != -119692)
							{
								continue;
							}
							this.$mStoryGui$44891.newStoryMessage(CharacterData.current.Type, CharacterData.current.Name, this.$nMessage$44892, eTalkType.friend);
							if (55916 - 373950 != -318034)
							{
								continue;
							}
							goto IL_41B;
						}
						break;
					case 4:
						if (Game.mGameState != eGameState.Start)
						{
							if (53178 - 436555 != -383377)
							{
								continue;
							}
							goto IL_4BF;
						}
						else
						{
							this.$self_$44893.SendMessage("alignToObject", "StartCamera2");
							if (283110 - 498885 == -215774)
							{
								continue;
							}
							this.$nMessage$44892 = Language.getMessage("M971_MaohsTomb", 3002);
							if (54241 - 256084 == -201842)
							{
								continue;
							}
							this.$mStoryGui$44891.newStoryMessage(CharacterData.current.Type, CharacterData.current.Name, this.$nMessage$44892, eTalkType.friend);
							if (261215 - 439190 != -177974)
							{
								goto Block_6;
							}
							continue;
						}
						break;
					case 5:
						if (Game.mGameState != eGameState.Start)
						{
							if (59276 - 502154 != -442878)
							{
								continue;
							}
							goto IL_4F3;
						}
						else
						{
							this.$mStoryGui$44891.close();
							if (243762 - 177933 == 65830)
							{
								continue;
							}
							this.$self_$44893.JKrnvVTTHMQ.enabled = true;
							if (232421 - 6996 != 225425)
							{
								continue;
							}
							this.$self_$44893.JKrnvVTTHMQ.specialTarget = null;
							if (66708 - 200444 != -133735)
							{
								goto Block_12;
							}
							continue;
						}
						break;
					case 6:
						if (Game.mGameState != eGameState.Start)
						{
							if (285888 - 411736 != -125848)
							{
								continue;
							}
							goto IL_136;
						}
						else
						{
							Game.mGameState = eGameState.Normal;
							if (144867 - 76474 != 68393)
							{
								continue;
							}
							Game.mStateTime = Time.time;
							if (283387 - 298320 != -14933)
							{
								continue;
							}
							Time.timeScale = 1f;
							if (297790 - 356847 == -59056)
							{
								continue;
							}
							this.$mGameGui$44890.enabled = true;
							if (158021 - 346766 != -188745)
							{
								continue;
							}
							this.$self_$44893.JKrnvVTTHMQ.enabled = true;
							if (215036 - 570188 == -355151)
							{
								continue;
							}
							this.YieldDefault(1);
							if (277845 - 392337 != -114492)
							{
								continue;
							}
							goto IL_557;
						}
						break;
					default:
						if (6060 - 313431 == -307370)
						{
							continue;
						}
						break;
					}
					this.$mGameGui$44890 = (GameGui)this.$self_$44893.GetComponent(typeof(GameGui));
					if (29476 - 291537 != -262060)
					{
						this.$mStoryGui$44891 = (StoryGui)this.$self_$44893.GetComponent(typeof(StoryGui));
						if (147425 - 222662 != -75236)
						{
							this.$self_$44893.JKrnvVTTHMQ.enabled = false;
							if (135563 - 230852 != -95288)
							{
								this.$self_$44893.SendMessage("alignToObject", "StartCamera1");
								if (161473 - 322539 != -161065)
								{
									this.$self_$44893.SendMessage("fadeIn");
									if (148427 - 384585 != -236157)
									{
										goto Block_11;
									}
								}
							}
						}
					}
				}
				Block_6:
				return this.Yield(5, new WaitForSeconds(3f));
				IL_136:
				goto IL_557;
				Block_11:
				return this.Yield(2, new WaitForSeconds(1f));
				Block_12:
				return this.Yield(6, new WaitForSeconds(0.5f));
				IL_1D2:
				return this.Yield(3, new WaitForSeconds(1f));
				Block_14:
				IL_383:
				goto IL_557;
				IL_41B:
				return this.Yield(4, new WaitForSeconds(3f));
				IL_4BF:
				IL_4F3:
				IL_557:
				return false;
			}

			// Token: 0x0600AC88 RID: 44168 RVA: 0x01324BE4 File Offset: 0x01322DE4
			internal static bool fkIVtoVIIL4BXD5lOvkm()
			{
				return true;
			}

			// Token: 0x0600AC89 RID: 44169 RVA: 0x01324BE8 File Offset: 0x01322DE8
			internal static bool sESP4uVIBVDhnVUN5Sa4()
			{
				return false;
			}

			// Token: 0x040098A1 RID: 39073
			internal GameGui $mGameGui$44890;

			// Token: 0x040098A2 RID: 39074
			internal StoryGui $mStoryGui$44891;

			// Token: 0x040098A3 RID: 39075
			internal string $nMessage$44892;

			// Token: 0x040098A4 RID: 39076
			internal M971_MaohsTomb10 $self_$44893;
		}
	}

	// Token: 0x02001CCE RID: 7374
	[CompilerGenerated]
	[Serializable]
	internal sealed class $MaohEvent$44895 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600AC8A RID: 44170 RVA: 0x01324BEC File Offset: 0x01322DEC
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $MaohEvent$44895(M971_MaohsTomb10 self_)
		{
			if (8184 - 174494 != -166310)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (159330 - 228883 == -69553)
				{
					base..ctor();
					if (202144 - 360472 == -158328)
					{
						this.$self_$44901 = self_;
						if (163285 - 524974 == -361689)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x0600AC8B RID: 44171 RVA: 0x01324C84 File Offset: 0x01322E84
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M971_MaohsTomb10.$MaohEvent$44895.$(this.$self_$44901);
		}

		// Token: 0x0600AC8C RID: 44172 RVA: 0x01324C94 File Offset: 0x01322E94
		internal static bool h3RFgtVIeJFHioaj5a59()
		{
			return true;
		}

		// Token: 0x0600AC8D RID: 44173 RVA: 0x01324C98 File Offset: 0x01322E98
		internal static bool U562mqVIrEF4fGlHQs3P()
		{
			return false;
		}

		// Token: 0x040098A5 RID: 39077
		internal M971_MaohsTomb10 $self_$44901;

		// Token: 0x02001CCF RID: 7375
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600AC8E RID: 44174 RVA: 0x01324C9C File Offset: 0x01322E9C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M971_MaohsTomb10 self_)
			{
				if (76069 - 56422 != 19647)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (32305 - 52265 == -19960)
					{
						base..ctor();
						if (46231 - 429477 == -383246)
						{
							this.$self_$44900 = self_;
							if (263451 - 219856 == 43595)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x0600AC8F RID: 44175 RVA: 0x01324D34 File Offset: 0x01322F34
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (4552 - 401895 != -397343)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						goto IL_7CD;
					case 1:
						goto IL_E7F;
					case 2:
						if (Game.mGameState != eGameState.AllHold)
						{
							if (116777 - 330279 != -213501)
							{
								goto Block_21;
							}
							continue;
						}
						else
						{
							this.$nMessage$44899 = string.Empty;
							if (225772 - 340351 != -114579)
							{
								continue;
							}
							this.$mStoryGui$44898.startStoryMessage("PharaohCat_d", "???", eTalkType.enemy);
							if (204666 - 95183 != 109484)
							{
								goto Block_55;
							}
							continue;
						}
						break;
					case 3:
						if (Game.mGameState != eGameState.AllHold)
						{
							if (203116 - 119669 != 83448)
							{
								goto Block_35;
							}
							continue;
						}
						else
						{
							this.$nMessage$44899 = Language.getMessage("M971_MaohsTomb", 4001);
							if (240543 - 590171 != -349628)
							{
								continue;
							}
							this.$mStoryGui$44898.newStoryMessage("PharaohCat_d", "???", this.$nMessage$44899, eTalkType.enemy);
							if (76762 - 352986 != -276224)
							{
								continue;
							}
							if (PlayerPrefs.GetInt("nvoice", 1) == 0)
							{
								goto IL_1A2;
							}
							if (111562 - 54947 == 56616)
							{
								continue;
							}
							if (this.$self_$44900.moah_talk)
							{
								if (31558 - 515928 == -484369)
								{
									continue;
								}
								this.$self_$44900.audio.PlayOneShot(this.$self_$44900.moah_talk);
								if (38654 - 198494 != -159839)
								{
									goto Block_88;
								}
								continue;
							}
							else
							{
								Debug.LogError("Cannot find moah talk voice");
								if (29691 - 513326 != -483635)
								{
									continue;
								}
								goto IL_1A2;
							}
						}
						break;
					case 4:
						if (Game.mGameState != eGameState.AllHold)
						{
							if (189078 - 27001 != 162078)
							{
								goto Block_13;
							}
							continue;
						}
						else
						{
							this.$nMessage$44899 = Language.getMessage("M971_MaohsTomb", 4002);
							if (123036 - 35299 != 87737)
							{
								continue;
							}
							this.$mStoryGui$44898.newStoryMessage(CharacterData.current.Type, CharacterData.current.Name, this.$nMessage$44899, eTalkType.friend);
							if (183868 - 59576 != 124293)
							{
								goto Block_9;
							}
							continue;
						}
						break;
					case 5:
						if (Game.mGameState != eGameState.AllHold)
						{
							if (230780 - 254240 != -23459)
							{
								goto Block_86;
							}
							continue;
						}
						else
						{
							this.$self_$44900.JKrnvVTTHMQ.enabled = false;
							if (33329 - 411041 == -377711)
							{
								continue;
							}
							this.$self_$44900.SendMessage("alignToObject", "EventCamera1");
							if (25760 - 334585 == -308824)
							{
								continue;
							}
							this.$mStoryGui$44898.blank();
							if (208011 - 297520 == -89508)
							{
								continue;
							}
							if (!this.$mPharaohCat$44896)
							{
								goto IL_A0F;
							}
							if (69478 - 336641 != -267163)
							{
								continue;
							}
							this.$mPharaohCat$44896.transform.position = new Vector3((float)0, (float)54, (float)15);
							if (80870 - 112939 == -32068)
							{
								continue;
							}
							this.$mPharaohCat$44896.animation.Play("circlePillar");
							if (122370 - 134086 != -11716)
							{
								continue;
							}
							if (!this.$self_$44900.moahDust)
							{
								goto IL_A0F;
							}
							if (3274 - 23989 == -20714)
							{
								continue;
							}
							UnityEngine.Object.Instantiate(this.$self_$44900.moahDust, new Vector3((float)0, (float)54, (float)15), Quaternion.identity);
							if (218363 - 534143 != -315780)
							{
								continue;
							}
							goto IL_A0F;
						}
						break;
					case 6:
						if (Game.mGameState != eGameState.AllHold)
						{
							if (253573 - 491305 != -237731)
							{
								goto Block_73;
							}
							continue;
						}
						else
						{
							if (this.$mPharaohCat$44896)
							{
								if (223273 - 245934 == -22660)
								{
									continue;
								}
								this.$mPharaohCat$44896.animation.CrossFade("root");
								if (206726 - 133494 == 73233)
								{
									continue;
								}
							}
							this.$nMessage$44899 = Language.getMessage("M971_MaohsTomb", 4003);
							if (25668 - 536058 == -510389)
							{
								continue;
							}
							this.$mStoryGui$44898.newStoryMessage("PharaohCat", "Maoh", this.$nMessage$44899, eTalkType.enemy);
							if (8800 - 97199 == -88398)
							{
								continue;
							}
							if (PlayerPrefs.GetInt("nvoice", 1) == 0)
							{
								goto IL_704;
							}
							if (230734 - 504112 == -273377)
							{
								continue;
							}
							if (this.$self_$44900.moah_chat)
							{
								if (183799 - 290972 == -107172)
								{
									continue;
								}
								this.$self_$44900.audio.PlayOneShot(this.$self_$44900.moah_chat);
								if (209098 - 343354 != -134255)
								{
									goto Block_60;
								}
								continue;
							}
							else
							{
								Debug.LogError("Cannot find moah chat voice");
								if (196356 - 238079 != -41723)
								{
									continue;
								}
								goto IL_704;
							}
						}
						break;
					case 7:
						if (Game.mGameState != eGameState.AllHold)
						{
							if (141499 - 399817 != -258317)
							{
								goto Block_51;
							}
							continue;
						}
						else
						{
							this.$nMessage$44899 = Language.getMessage("M971_MaohsTomb", 4004);
							if (61820 - 423840 == -362019)
							{
								continue;
							}
							this.$mStoryGui$44898.newStoryMessage(CharacterData.current.Type, CharacterData.current.Name, this.$nMessage$44899, eTalkType.friend);
							if (160460 - 437873 != -277413)
							{
								continue;
							}
							goto IL_269;
						}
						break;
					case 8:
						if (Game.mGameState != eGameState.AllHold)
						{
							if (23483 - 573584 != -550101)
							{
								continue;
							}
							goto IL_59D;
						}
						else
						{
							this.$nMessage$44899 = Language.getMessage("M971_MaohsTomb", 4005);
							if (138697 - 118928 != 19769)
							{
								continue;
							}
							this.$mStoryGui$44898.newStoryMessage("PharaohCat", "Maoh", this.$nMessage$44899, eTalkType.enemy);
							if (27172 - 428222 != -401049)
							{
								goto Block_63;
							}
							continue;
						}
						break;
					case 9:
						if (Game.mGameState != eGameState.AllHold)
						{
							if (125049 - 7210 != 117840)
							{
								goto Block_65;
							}
							continue;
						}
						else
						{
							this.$nMessage$44899 = Language.getMessage("M971_MaohsTomb", 4006);
							if (261929 - 57013 == 204917)
							{
								continue;
							}
							this.$mStoryGui$44898.newStoryMessage("PharaohCat", "Maoh", this.$nMessage$44899, eTalkType.enemy);
							if (29310 - 518969 != -489659)
							{
								continue;
							}
							goto IL_B0F;
						}
						break;
					case 10:
						if (Game.mGameState != eGameState.AllHold)
						{
							if (181769 - 348837 != -167067)
							{
								goto Block_80;
							}
							continue;
						}
						else
						{
							this.$nMessage$44899 = Language.getMessage("M971_MaohsTomb", 4007);
							if (224183 - 463698 == -239514)
							{
								continue;
							}
							this.$mStoryGui$44898.newStoryMessage(CharacterData.current.Type, CharacterData.current.Name, this.$nMessage$44899, eTalkType.friend);
							if (186472 - 178587 != 7885)
							{
								continue;
							}
							goto IL_C79;
						}
						break;
					case 11:
						if (Game.mGameState != eGameState.AllHold)
						{
							if (214008 - 498715 != -284706)
							{
								goto Block_91;
							}
							continue;
						}
						else
						{
							this.$nMessage$44899 = Language.getMessage("M971_MaohsTomb", 4008);
							if (32098 - 214078 == -181979)
							{
								continue;
							}
							this.$mStoryGui$44898.newStoryMessage("PharaohCat", "Maoh", this.$nMessage$44899, eTalkType.enemy);
							if (98211 - 202140 != -103929)
							{
								continue;
							}
							if (PlayerPrefs.GetInt("nvoice", 1) == 0)
							{
								goto IL_B75;
							}
							if (205412 - 323336 != -117924)
							{
								continue;
							}
							if (this.$self_$44900.moah_talk)
							{
								if (248913 - 120412 == 128502)
								{
									continue;
								}
								this.$self_$44900.audio.PlayOneShot(this.$self_$44900.moah_talk);
								if (227502 - 205739 != 21764)
								{
									goto Block_94;
								}
								continue;
							}
							else
							{
								Debug.LogError("Cannot find moah talk voice");
								if (243757 - 17121 != 226637)
								{
									goto Block_93;
								}
								continue;
							}
						}
						break;
					case 12:
						if (Game.mGameState != eGameState.AllHold)
						{
							if (131771 - 404099 != -272327)
							{
								goto Block_84;
							}
							continue;
						}
						else
						{
							this.$mStoryGui$44898.close();
							if (150049 - 226710 != -76661)
							{
								continue;
							}
							this.$self_$44900.JKrnvVTTHMQ.enabled = true;
							if (271770 - 115101 != 156669)
							{
								continue;
							}
							this.$self_$44900.JKrnvVTTHMQ.specialTarget = null;
							if (212021 - 64374 != 147647)
							{
								continue;
							}
							goto IL_413;
						}
						break;
					case 13:
						if (Game.mGameState != eGameState.AllHold)
						{
							if (162019 - 210331 != -48312)
							{
								continue;
							}
							goto IL_9DB;
						}
						else
						{
							if (this.$self_$44900.battleMusic)
							{
								if (286205 - 267734 != 18471)
								{
									continue;
								}
								this.$self_$44900.audio.clip = this.$self_$44900.battleMusic;
								if (22366 - 121653 != -99287)
								{
									continue;
								}
								this.$self_$44900.audio.Play();
								if (68663 - 359857 != -291194)
								{
									continue;
								}
							}
							Game.mGameState = eGameState.Normal;
							if (221339 - 134287 != 87052)
							{
								continue;
							}
							Game.mStateTime = Time.time;
							if (190269 - 67025 != 123244)
							{
								continue;
							}
							Time.timeScale = 1f;
							if (18630 - 175903 == -157272)
							{
								continue;
							}
							this.$mGameGui$44897.enabled = true;
							if (101816 - 280932 != -179116)
							{
								continue;
							}
							this.$self_$44900.JKrnvVTTHMQ.enabled = true;
							if (46098 - 225932 == -179833)
							{
								continue;
							}
							Game.sendMissionEvent(9712, 2);
							if (87401 - 523632 != -436231)
							{
								continue;
							}
						}
						break;
					default:
						if (89541 - 210954 != -121413)
						{
							continue;
						}
						goto IL_7CD;
					}
					IL_3CC:
					this.YieldDefault(1);
					if (13183 - 544238 != -531055)
					{
						continue;
					}
					goto IL_E7F;
					IL_7CD:
					this.$self_$44900.mbtnlc7en4A = true;
					if (239643 - 462180 != -222536)
					{
						this.$mPharaohCat$44896 = GameObject.Find("PharaohCat");
						if (173024 - 398059 == -225035)
						{
							this.$mGameGui$44897 = (GameGui)this.$self_$44900.GetComponent(typeof(GameGui));
							if (58843 - 333161 == -274318)
							{
								this.$mStoryGui$44898 = (StoryGui)this.$self_$44900.GetComponent(typeof(StoryGui));
								if (58658 - 425372 == -366714)
								{
									if (!this.$mGameGui$44897)
									{
										goto IL_3CC;
									}
									if (170819 - 496083 != -325263)
									{
										if (!this.$mStoryGui$44898)
										{
											goto IL_3CC;
										}
										if (115146 - 492570 == -377424)
										{
											Game.mGameState = eGameState.AllHold;
											if (141000 - 27902 != 113099)
											{
												this.$mGameGui$44897.close();
												if (292249 - 39568 == 252681)
												{
													goto IL_2A4;
												}
											}
										}
									}
								}
							}
						}
					}
				}
				Block_9:
				return this.Yield(5, new WaitForSeconds(2f));
				IL_1A2:
				return this.Yield(4, new WaitForSeconds(3f));
				Block_13:
				goto IL_E7F;
				IL_269:
				return this.Yield(8, new WaitForSeconds(3f));
				IL_2A4:
				return this.Yield(2, new WaitForSeconds(1f));
				Block_21:
				goto IL_E7F;
				IL_413:
				return this.Yield(13, new WaitForSeconds(0.5f));
				Block_35:
				IL_59D:
				goto IL_E7F;
				IL_704:
				return this.Yield(7, new WaitForSeconds(3f));
				Block_51:
				goto IL_E7F;
				Block_55:
				return this.Yield(3, new WaitForSeconds(0.5f));
				Block_60:
				goto IL_704;
				Block_63:
				return this.Yield(9, new WaitForSeconds(3f));
				Block_65:
				IL_9DB:
				goto IL_E7F;
				IL_A0F:
				return this.Yield(6, new WaitForSeconds(1.3f));
				Block_73:
				goto IL_E7F;
				IL_B0F:
				return this.Yield(10, new WaitForSeconds(3f));
				Block_80:
				goto IL_E7F;
				IL_B75:
				return this.Yield(12, new WaitForSeconds(3f));
				Block_84:
				Block_86:
				goto IL_E7F;
				Block_88:
				goto IL_1A2;
				IL_C79:
				return this.Yield(11, new WaitForSeconds(3f));
				Block_91:
				goto IL_E7F;
				Block_93:
				Block_94:
				goto IL_B75;
				IL_E7F:
				return false;
			}

			// Token: 0x0600AC90 RID: 44176 RVA: 0x01325BD4 File Offset: 0x01323DD4
			internal static bool jB6UEXVIjaNx7TpP7qNl()
			{
				return true;
			}

			// Token: 0x0600AC91 RID: 44177 RVA: 0x01325BD8 File Offset: 0x01323DD8
			internal static bool KKUI4iVIh59RLZELcULC()
			{
				return false;
			}

			// Token: 0x040098A6 RID: 39078
			internal GameObject $mPharaohCat$44896;

			// Token: 0x040098A7 RID: 39079
			internal GameGui $mGameGui$44897;

			// Token: 0x040098A8 RID: 39080
			internal StoryGui $mStoryGui$44898;

			// Token: 0x040098A9 RID: 39081
			internal string $nMessage$44899;

			// Token: 0x040098AA RID: 39082
			internal M971_MaohsTomb10 $self_$44900;
		}
	}

	// Token: 0x02001CD0 RID: 7376
	[CompilerGenerated]
	[Serializable]
	internal sealed class $onDeadPlayer$44902 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600AC92 RID: 44178 RVA: 0x01325BDC File Offset: 0x01323DDC
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $onDeadPlayer$44902(M971_MaohsTomb10 self_)
		{
			if (14296 - 326530 != -312233)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (253905 - 182578 == 71327)
				{
					base..ctor();
					if (114053 - 554791 != -440737)
					{
						this.$self_$44907 = self_;
						if (214477 - 178755 == 35722)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x0600AC93 RID: 44179 RVA: 0x01325C74 File Offset: 0x01323E74
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M971_MaohsTomb10.$onDeadPlayer$44902.$(this.$self_$44907);
		}

		// Token: 0x0600AC94 RID: 44180 RVA: 0x01325C84 File Offset: 0x01323E84
		internal static bool DpF6ojVIsbnOGt8tDno4()
		{
			return true;
		}

		// Token: 0x0600AC95 RID: 44181 RVA: 0x01325C88 File Offset: 0x01323E88
		internal static bool ig1gs4VI9l9T40OXZVjQ()
		{
			return false;
		}

		// Token: 0x040098AB RID: 39083
		internal M971_MaohsTomb10 $self_$44907;

		// Token: 0x02001CD1 RID: 7377
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600AC96 RID: 44182 RVA: 0x01325C8C File Offset: 0x01323E8C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M971_MaohsTomb10 self_)
			{
				if (292563 - 227989 != 64575)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (2729 - 454070 != -451340)
					{
						base..ctor();
						if (107497 - 581261 == -473764)
						{
							this.$self_$44906 = self_;
							if (45911 - 388922 == -343011)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x0600AC97 RID: 44183 RVA: 0x01325D24 File Offset: 0x01323F24
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (244631 - 350970 != -106339)
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
							if (218000 - 75371 != 142629)
							{
								continue;
							}
							if (Game.mGameState != eGameState.Hold)
							{
								goto IL_249;
							}
							if (249659 - 208841 == 40819)
							{
								continue;
							}
						}
						Game.mGameState = eGameState.Hold;
						if (62310 - 435799 == -373488)
						{
							continue;
						}
						this.$mStoryGui$44903 = (StoryGui)this.$self_$44906.GetComponent(typeof(StoryGui));
						if (104470 - 29112 == 75359)
						{
							continue;
						}
						if (this.$mStoryGui$44903)
						{
							if (170810 - 541422 == -370611)
							{
								continue;
							}
							this.$mStoryGui$44903.close();
							if (10016 - 322693 != -312677)
							{
								continue;
							}
						}
						this.$mChangeGui$44904 = (ChangeGui)this.$self_$44906.GetComponent(typeof(ChangeGui));
						if (38932 - 169050 == -130117)
						{
							continue;
						}
						if (this.$mChangeGui$44904)
						{
							if (223827 - 207615 != 16212)
							{
								continue;
							}
							this.$mChangeGui$44904.close();
							if (100846 - 53748 == 47099)
							{
								continue;
							}
						}
						this.$mGameGui$44905 = (GameGui)this.$self_$44906.GetComponent(typeof(GameGui));
						if (142825 - 216422 != -73597)
						{
							continue;
						}
						if (this.$mGameGui$44905)
						{
							if (58415 - 186959 == -128543)
							{
								continue;
							}
							if (!this.$mGameGui$44905.enabled)
							{
								if (299343 - 15034 != 284309)
								{
									continue;
								}
								this.$mGameGui$44905.enabled = true;
								if (187312 - 534602 == -347289)
								{
									continue;
								}
							}
							this.$mGameGui$44905.openDeadMenu();
							if (3043 - 88697 != -85654)
							{
								continue;
							}
						}
						IL_249:
						this.YieldDefault(1);
						if (93645 - 327669 != -234023)
						{
							goto Block_19;
						}
						continue;
					default:
						if (232700 - 44668 != 188032)
						{
							continue;
						}
						break;
					}
					Debug.Log("On Dead Player");
				}
				while (191194 - 573793 == -382598);
				return this.Yield(2, new WaitForSeconds((float)2));
				Block_19:
				IL_2F9:
				return false;
			}

			// Token: 0x0600AC98 RID: 44184 RVA: 0x0132603C File Offset: 0x0132423C
			internal static bool Jw1SLhVI16mBQXW9SXdb()
			{
				return true;
			}

			// Token: 0x0600AC99 RID: 44185 RVA: 0x01326040 File Offset: 0x01324240
			internal static bool hSg176VI4CZXoCWrj388()
			{
				return false;
			}

			// Token: 0x040098AC RID: 39084
			internal StoryGui $mStoryGui$44903;

			// Token: 0x040098AD RID: 39085
			internal ChangeGui $mChangeGui$44904;

			// Token: 0x040098AE RID: 39086
			internal GameGui $mGameGui$44905;

			// Token: 0x040098AF RID: 39087
			internal M971_MaohsTomb10 $self_$44906;
		}
	}

	// Token: 0x02001CD2 RID: 7378
	[CompilerGenerated]
	[Serializable]
	internal sealed class $onChangePlayer$44908 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600AC9A RID: 44186 RVA: 0x01326044 File Offset: 0x01324244
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $onChangePlayer$44908(Hashtable data, M971_MaohsTomb10 self_)
		{
			if (133949 - 283331 != -149381)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (91346 - 195266 == -103920)
				{
					base..ctor();
					if (222927 - 248585 != -25657)
					{
						this.$data$44913 = data;
						if (246317 - 423082 == -176765)
						{
							this.$self_$44914 = self_;
							if (171901 - 467649 != -295747)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x0600AC9B RID: 44187 RVA: 0x01326100 File Offset: 0x01324300
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M971_MaohsTomb10.$onChangePlayer$44908.$(this.$data$44913, this.$self_$44914);
		}

		// Token: 0x0600AC9C RID: 44188 RVA: 0x01326114 File Offset: 0x01324314
		internal static bool E4qmEMVIzdF8W6tqHbbP()
		{
			return true;
		}

		// Token: 0x0600AC9D RID: 44189 RVA: 0x01326118 File Offset: 0x01324318
		internal static bool r2hXYtVBabSYG9i1gviC()
		{
			return false;
		}

		// Token: 0x040098B0 RID: 39088
		internal Hashtable $data$44913;

		// Token: 0x040098B1 RID: 39089
		internal M971_MaohsTomb10 $self_$44914;

		// Token: 0x02001CD3 RID: 7379
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600AC9E RID: 44190 RVA: 0x0132611C File Offset: 0x0132431C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Hashtable data, M971_MaohsTomb10 self_)
			{
				if (226788 - 245780 != -18992)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (265787 - 54716 == 211071)
					{
						base..ctor();
						if (229986 - 196907 == 33079)
						{
							this.$data$44911 = data;
							if (117760 - 394352 == -276592)
							{
								this.$self_$44912 = self_;
								if (109384 - 487872 == -378488)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x0600AC9F RID: 44191 RVA: 0x013261D8 File Offset: 0x013243D8
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (273479 - 498981 != -225501)
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
							if (151186 - 106714 == 44473)
							{
								continue;
							}
							Game.mGameState = eGameState.Normal;
							if (111927 - 465611 != -353684)
							{
								continue;
							}
							this.$mGameGui$44910 = (GameGui)this.$self_$44912.GetComponent(typeof(GameGui));
							if (6148 - 158840 != -152692)
							{
								continue;
							}
							this.$mGameGui$44910.enabled = true;
							if (88923 - 422334 != -333411)
							{
								continue;
							}
						}
						this.YieldDefault(1);
						if (41191 - 237938 != -196747)
						{
							continue;
						}
						goto IL_205;
					default:
						if (123385 - 271717 == -148331)
						{
							continue;
						}
						break;
					}
					UnityEngine.Object.Destroy(Game.mPlayer);
					if (152076 - 432462 == -280386)
					{
						this.$self_$44912.SendMessage("onCreatePlayer", this.$data$44911);
						if (156682 - 98264 == 58418)
						{
							this.$mChangeGui$44909 = (ChangeGui)this.$self_$44912.GetComponent(typeof(ChangeGui));
							if (63372 - 105934 == -42562)
							{
								if (!this.$mChangeGui$44909.enabled)
								{
									break;
								}
								if (79984 - 553133 != -473148)
								{
									this.$mChangeGui$44909.close();
									if (169663 - 494647 != -324983)
									{
										break;
									}
								}
							}
						}
					}
				}
				IL_82:
				return this.Yield(2, new WaitForSeconds(1f));
				goto IL_82;
				IL_205:
				return false;
			}

			// Token: 0x0600ACA0 RID: 44192 RVA: 0x013263FC File Offset: 0x013245FC
			internal static bool HfeIITVB5rxhDTtUqfVJ()
			{
				return true;
			}

			// Token: 0x0600ACA1 RID: 44193 RVA: 0x01326400 File Offset: 0x01324600
			internal static bool NaTxUOVBpgRoL0jyQnAm()
			{
				return false;
			}

			// Token: 0x040098B2 RID: 39090
			internal ChangeGui $mChangeGui$44909;

			// Token: 0x040098B3 RID: 39091
			internal GameGui $mGameGui$44910;

			// Token: 0x040098B4 RID: 39092
			internal Hashtable $data$44911;

			// Token: 0x040098B5 RID: 39093
			internal M971_MaohsTomb10 $self_$44912;
		}
	}

	// Token: 0x02001CD4 RID: 7380
	[CompilerGenerated]
	[Serializable]
	internal sealed class $onGameComplete$44915 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600ACA2 RID: 44194 RVA: 0x01326404 File Offset: 0x01324604
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $onGameComplete$44915(Hashtable data, M971_MaohsTomb10 self_)
		{
			if (277097 - 47538 != 229559)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (275782 - 375196 != -99413)
				{
					base..ctor();
					if (35866 - 208642 == -172776)
					{
						this.$data$44922 = data;
						if (118739 - 382810 != -264070)
						{
							this.$self_$44923 = self_;
							if (114563 - 369043 == -254480)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x0600ACA3 RID: 44195 RVA: 0x013264C0 File Offset: 0x013246C0
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M971_MaohsTomb10.$onGameComplete$44915.$(this.$data$44922, this.$self_$44923);
		}

		// Token: 0x0600ACA4 RID: 44196 RVA: 0x013264D4 File Offset: 0x013246D4
		internal static bool YaNdlpVBVuDghywNAkYj()
		{
			return true;
		}

		// Token: 0x0600ACA5 RID: 44197 RVA: 0x013264D8 File Offset: 0x013246D8
		internal static bool zkhnMbVBtDmMbDWaunaw()
		{
			return false;
		}

		// Token: 0x040098B6 RID: 39094
		internal Hashtable $data$44922;

		// Token: 0x040098B7 RID: 39095
		internal M971_MaohsTomb10 $self_$44923;

		// Token: 0x02001CD5 RID: 7381
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600ACA6 RID: 44198 RVA: 0x013264DC File Offset: 0x013246DC
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Hashtable data, M971_MaohsTomb10 self_)
			{
				if (169429 - 512519 != -343089)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (23508 - 89542 == -66034)
					{
						base..ctor();
						if (18365 - 225632 == -207267)
						{
							this.$data$44920 = data;
							if (74598 - 261682 == -187084)
							{
								this.$self_$44921 = self_;
								if (98863 - 95240 != 3624)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x0600ACA7 RID: 44199 RVA: 0x01326598 File Offset: 0x01324798
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (213401 - 211775 != 1626)
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
						this.$mCompleteGui$44917 = (CompleteGui)this.$self_$44921.GetComponent(typeof(CompleteGui));
						if (179185 - 414307 != -235122)
						{
							continue;
						}
						this.$mCompleteGui$44917.Init();
						if (227109 - 237237 == -10127)
						{
							continue;
						}
						this.$mCompleteGui$44917.readData(this.$data$44920);
						if (37121 - 434561 != -397440)
						{
							continue;
						}
						if (this.$result$44916 == 1)
						{
							if (225091 - 425463 == -200371)
							{
								continue;
							}
							this.$mCompleteGui$44917.displayResult(eCompleteType.Success);
							if (36351 - 298043 == -261691)
							{
								continue;
							}
						}
						else
						{
							this.$mCompleteGui$44917.displayResult(eCompleteType.Failed);
							if (96493 - 238753 != -142260)
							{
								continue;
							}
						}
						this.$mGameGui$44918 = (GameGui)this.$self_$44921.GetComponent(typeof(GameGui));
						if (152863 - 250580 == -97716)
						{
							continue;
						}
						this.$mStoryGui$44919 = (StoryGui)this.$self_$44921.GetComponent(typeof(StoryGui));
						if (83540 - 183504 != -99964)
						{
							continue;
						}
						if (this.$mGameGui$44918)
						{
							if (100496 - 224181 == -123684)
							{
								continue;
							}
							this.$mGameGui$44918.close();
							if (238274 - 340618 == -102343)
							{
								continue;
							}
						}
						if (this.$mStoryGui$44919)
						{
							if (85353 - 67312 != 18041)
							{
								continue;
							}
							this.$mStoryGui$44919.close();
							if (73051 - 514042 == -440990)
							{
								continue;
							}
						}
						this.YieldDefault(1);
						if (7299 - 325559 != -318259)
						{
							goto Block_15;
						}
						continue;
					default:
						if (90054 - 97198 != -7144)
						{
							continue;
						}
						break;
					}
					Debug.Log("On Mission Complete:" + this.$data$44920[31]);
					if (203775 - 88174 == 115601)
					{
						if (Game.mGameState > eGameState.AllHold)
						{
							if (220148 - 28892 == 191256)
							{
								break;
							}
						}
						else
						{
							Game.mGameState = eGameState.Complete;
							if (159270 - 521318 == -362048)
							{
								this.$result$44916 = RuntimeServices.UnboxInt32(this.$data$44920[31]);
								if (189336 - 260126 != -70789)
								{
									goto Block_16;
								}
							}
						}
					}
				}
				Block_15:
				goto IL_352;
				Block_16:
				return this.Yield(2, new WaitForSeconds(1f));
				IL_352:
				return false;
			}

			// Token: 0x0600ACA8 RID: 44200 RVA: 0x0132690C File Offset: 0x01324B0C
			internal static bool QgNEAVVBNGwb2KM3seHR()
			{
				return true;
			}

			// Token: 0x0600ACA9 RID: 44201 RVA: 0x01326910 File Offset: 0x01324B10
			internal static bool g0ccjQVBYqcNko3Urch3()
			{
				return false;
			}

			// Token: 0x040098B8 RID: 39096
			internal int $result$44916;

			// Token: 0x040098B9 RID: 39097
			internal CompleteGui $mCompleteGui$44917;

			// Token: 0x040098BA RID: 39098
			internal GameGui $mGameGui$44918;

			// Token: 0x040098BB RID: 39099
			internal StoryGui $mStoryGui$44919;

			// Token: 0x040098BC RID: 39100
			internal Hashtable $data$44920;

			// Token: 0x040098BD RID: 39101
			internal M971_MaohsTomb10 $self_$44921;
		}
	}

	// Token: 0x02001CD6 RID: 7382
	[CompilerGenerated]
	[Serializable]
	internal sealed class $ReturnToTown$44924 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600ACAA RID: 44202 RVA: 0x01326914 File Offset: 0x01324B14
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $ReturnToTown$44924(M971_MaohsTomb10 self_)
		{
			if (143256 - 301804 != -158547)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (122112 - 536403 == -414291)
				{
					base..ctor();
					if (105851 - 406061 != -300209)
					{
						this.$self_$44928 = self_;
						if (202316 - 252603 == -50287)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x0600ACAB RID: 44203 RVA: 0x013269AC File Offset: 0x01324BAC
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M971_MaohsTomb10.$ReturnToTown$44924.$(this.$self_$44928);
		}

		// Token: 0x0600ACAC RID: 44204 RVA: 0x013269BC File Offset: 0x01324BBC
		internal static bool QGITcmVBcuURntYgv4TC()
		{
			return true;
		}

		// Token: 0x0600ACAD RID: 44205 RVA: 0x013269C0 File Offset: 0x01324BC0
		internal static bool El2jyEVBUrfoOWN0qyZK()
		{
			return false;
		}

		// Token: 0x040098BE RID: 39102
		internal M971_MaohsTomb10 $self_$44928;

		// Token: 0x02001CD7 RID: 7383
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600ACAE RID: 44206 RVA: 0x013269C4 File Offset: 0x01324BC4
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M971_MaohsTomb10 self_)
			{
				if (239012 - 37692 != 201321)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (183600 - 597760 == -414160)
					{
						base..ctor();
						if (38248 - 517961 != -479712)
						{
							this.$self_$44927 = self_;
							if (119342 - 221654 != -102311)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x0600ACAF RID: 44207 RVA: 0x01326A5C File Offset: 0x01324C5C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (68958 - 577529 != -508571)
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
						this.$self_$44927.LeaveGame();
						if (179245 - 325886 != -146641)
						{
							continue;
						}
						this.YieldDefault(1);
						if (173906 - 396938 != -223031)
						{
							goto Block_24;
						}
						continue;
					default:
						if (77707 - 438588 != -360881)
						{
							continue;
						}
						break;
					}
					Game.mGameState = eGameState.Ended;
					if (20278 - 95646 != -75367)
					{
						Game.mStateTime = Time.time;
						if (16148 - 270471 == -254323)
						{
							this.$$switch$8373$44925 = PlayerData.SaveGuild;
							if (50171 - 58738 != -8566)
							{
								if (this.$$switch$8373$44925 == 1)
								{
									if (258675 - 280287 == -21611)
									{
										continue;
									}
									Game.mNextGameCode = 32;
									if (143396 - 156620 == -13223)
									{
										continue;
									}
								}
								else if (this.$$switch$8373$44925 == 2)
								{
									if (268467 - 274592 != -6125)
									{
										continue;
									}
									Game.mNextGameCode = 33;
									if (86098 - 41956 != 44142)
									{
										continue;
									}
								}
								else if (this.$$switch$8373$44925 == 3)
								{
									if (38225 - 407476 == -369250)
									{
										continue;
									}
									Game.mNextGameCode = 34;
									if (232597 - 49606 != 182991)
									{
										continue;
									}
								}
								else if (this.$$switch$8373$44925 == 4)
								{
									if (183816 - 315070 == -131253)
									{
										continue;
									}
									Game.mNextGameCode = 35;
									if (235073 - 336414 != -101341)
									{
										continue;
									}
								}
								else if (this.$$switch$8373$44925 == 5)
								{
									if (78630 - 183823 == -105192)
									{
										continue;
									}
									Game.mNextGameCode = 36;
									if (266255 - 243812 != 22443)
									{
										continue;
									}
								}
								else if (PlayerData.GID == 0)
								{
									if (28568 - 210745 == -182176)
									{
										continue;
									}
									Game.mNextGameCode = 30;
									if (65650 - 92026 == -26375)
									{
										continue;
									}
								}
								else
								{
									Game.mNextGameCode = 31;
									if (22188 - 18345 == 3844)
									{
										continue;
									}
								}
								this.$mGameGui$44926 = (GameGui)this.$self_$44927.GetComponent(typeof(GameGui));
								if (53986 - 163018 != -109031)
								{
									if (this.$mGameGui$44926)
									{
										if (150139 - 82453 != 67686)
										{
											continue;
										}
										this.$mGameGui$44926.close();
										if (290552 - 311665 == -21112)
										{
											continue;
										}
									}
									this.$self_$44927.SendMessage("fadeOut");
									if (241387 - 440041 == -198654)
									{
										goto IL_2E7;
									}
								}
							}
						}
					}
				}
				Block_24:
				goto IL_3AD;
				IL_2E7:
				return this.Yield(2, new WaitForSeconds((float)1));
				IL_3AD:
				return false;
			}

			// Token: 0x0600ACB0 RID: 44208 RVA: 0x01326E28 File Offset: 0x01325028
			internal static bool kljbifVBTQIIFSRSQc9Q()
			{
				return true;
			}

			// Token: 0x0600ACB1 RID: 44209 RVA: 0x01326E2C File Offset: 0x0132502C
			internal static bool uUnXhYVB3BbyjnOX32Yy()
			{
				return false;
			}

			// Token: 0x040098BF RID: 39103
			internal int $$switch$8373$44925;

			// Token: 0x040098C0 RID: 39104
			internal GameGui $mGameGui$44926;

			// Token: 0x040098C1 RID: 39105
			internal M971_MaohsTomb10 $self_$44927;
		}
	}

	// Token: 0x02001CD8 RID: 7384
	[CompilerGenerated]
	[Serializable]
	internal sealed class $ReturnToGuild$44929 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600ACB2 RID: 44210 RVA: 0x01326E30 File Offset: 0x01325030
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $ReturnToGuild$44929(M971_MaohsTomb10 self_)
		{
			if (272899 - 497173 != -224273)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (26008 - 4104 != 21905)
				{
					base..ctor();
					if (34546 - 315511 == -280965)
					{
						this.$self_$44932 = self_;
						if (137944 - 446584 == -308640)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x0600ACB3 RID: 44211 RVA: 0x01326EC8 File Offset: 0x013250C8
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M971_MaohsTomb10.$ReturnToGuild$44929.$(this.$self_$44932);
		}

		// Token: 0x0600ACB4 RID: 44212 RVA: 0x01326ED8 File Offset: 0x013250D8
		internal static bool xIHEFJVBX9vsRlRixff1()
		{
			return true;
		}

		// Token: 0x0600ACB5 RID: 44213 RVA: 0x01326EDC File Offset: 0x013250DC
		internal static bool PpL0cmVBQJDyMNtPJJD8()
		{
			return false;
		}

		// Token: 0x040098C2 RID: 39106
		internal M971_MaohsTomb10 $self_$44932;

		// Token: 0x02001CD9 RID: 7385
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600ACB6 RID: 44214 RVA: 0x01326EE0 File Offset: 0x013250E0
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M971_MaohsTomb10 self_)
			{
				if (203765 - 186294 != 17472)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (29562 - 446482 != -416919)
					{
						base..ctor();
						if (100277 - 308338 != -208060)
						{
							this.$self_$44931 = self_;
							if (82790 - 368247 == -285457)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x0600ACB7 RID: 44215 RVA: 0x01326F78 File Offset: 0x01325178
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (187929 - 539092 != -351162)
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
						this.$self_$44931.LeaveGame();
						if (45411 - 157604 != -112193)
						{
							continue;
						}
						this.YieldDefault(1);
						if (294001 - 517962 != -223960)
						{
							goto Block_9;
						}
						continue;
					default:
						if (133671 - 143967 == -10295)
						{
							continue;
						}
						break;
					}
					Game.mGameState = eGameState.Ended;
					if (200442 - 191298 == 9144)
					{
						Game.mStateTime = Time.time;
						if (245217 - 80623 != 164595)
						{
							Game.mNextGameCode = 31;
							if (125345 - 448040 == -322695)
							{
								this.$mGameGui$44930 = (GameGui)this.$self_$44931.GetComponent(typeof(GameGui));
								if (127362 - 429125 == -301763)
								{
									if (this.$mGameGui$44930)
									{
										if (61900 - 105833 == -43932)
										{
											continue;
										}
										this.$mGameGui$44930.close();
										if (4385 - 386672 == -382286)
										{
											continue;
										}
									}
									this.$self_$44931.SendMessage("fadeOut");
									if (84400 - 436694 == -352294)
									{
										goto IL_185;
									}
								}
							}
						}
					}
				}
				Block_9:
				goto IL_1BD;
				IL_185:
				return this.Yield(2, new WaitForSeconds((float)1));
				IL_1BD:
				return false;
			}

			// Token: 0x0600ACB8 RID: 44216 RVA: 0x01327154 File Offset: 0x01325354
			internal static bool KB5Cd3VBkCfTkdL3SYwL()
			{
				return true;
			}

			// Token: 0x0600ACB9 RID: 44217 RVA: 0x01327158 File Offset: 0x01325358
			internal static bool Gr0wWNVBGHbARc7qOhR4()
			{
				return false;
			}

			// Token: 0x040098C3 RID: 39107
			internal GameGui $mGameGui$44930;

			// Token: 0x040098C4 RID: 39108
			internal M971_MaohsTomb10 $self_$44931;
		}
	}

	// Token: 0x02001CDA RID: 7386
	[CompilerGenerated]
	[Serializable]
	internal sealed class $ReturnToCamp$44933 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600ACBA RID: 44218 RVA: 0x0132715C File Offset: 0x0132535C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $ReturnToCamp$44933(M971_MaohsTomb10 self_)
		{
			if (185846 - 356845 != -170998)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (25665 - 144663 == -118998)
				{
					base..ctor();
					if (185981 - 448776 == -262795)
					{
						this.$self_$44937 = self_;
						if (24636 - 101822 != -77185)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x0600ACBB RID: 44219 RVA: 0x013271F4 File Offset: 0x013253F4
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M971_MaohsTomb10.$ReturnToCamp$44933.$(this.$self_$44937);
		}

		// Token: 0x0600ACBC RID: 44220 RVA: 0x01327204 File Offset: 0x01325404
		internal static bool VDtEjAVBH0JGdYPNbpM8()
		{
			return true;
		}

		// Token: 0x0600ACBD RID: 44221 RVA: 0x01327208 File Offset: 0x01325408
		internal static bool ndu4H9VBWVpAuDHPvvnr()
		{
			return false;
		}

		// Token: 0x040098C5 RID: 39109
		internal M971_MaohsTomb10 $self_$44937;

		// Token: 0x02001CDB RID: 7387
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600ACBE RID: 44222 RVA: 0x0132720C File Offset: 0x0132540C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M971_MaohsTomb10 self_)
			{
				if (54441 - 191054 != -136613)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (177514 - 73704 != 103811)
					{
						base..ctor();
						if (287673 - 428458 != -140784)
						{
							this.$self_$44936 = self_;
							if (109319 - 266701 != -157381)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x0600ACBF RID: 44223 RVA: 0x013272A4 File Offset: 0x013254A4
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (23576 - 170079 != -146503)
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
						this.$self_$44936.LeaveGame();
						if (164877 - 445098 == -280220)
						{
							continue;
						}
						this.YieldDefault(1);
						if (205948 - 405066 != -199117)
						{
							goto Block_19;
						}
						continue;
					default:
						if (258241 - 140433 != 117808)
						{
							continue;
						}
						break;
					}
					Game.mGameState = eGameState.Ended;
					if (55838 - 74646 == -18808)
					{
						Game.mStateTime = Time.time;
						if (178698 - 356593 != -177894)
						{
							this.$$switch$8375$44934 = PlayerData.SaveGuild;
							if (182553 - 550965 != -368411)
							{
								if (this.$$switch$8375$44934 == 1)
								{
									if (67907 - 358163 == -290255)
									{
										continue;
									}
									Game.mNextGameCode = 32;
									if (85830 - 536649 != -450819)
									{
										continue;
									}
								}
								else if (this.$$switch$8375$44934 == 2)
								{
									if (267372 - 158733 != 108639)
									{
										continue;
									}
									Game.mNextGameCode = 33;
									if (188031 - 14991 == 173041)
									{
										continue;
									}
								}
								else if (this.$$switch$8375$44934 == 3)
								{
									if (52010 - 104455 != -52445)
									{
										continue;
									}
									Game.mNextGameCode = 34;
									if (116953 - 151441 == -34487)
									{
										continue;
									}
								}
								else if (this.$$switch$8375$44934 == 4)
								{
									if (90503 - 168986 != -78483)
									{
										continue;
									}
									Game.mNextGameCode = 35;
									if (250185 - 184586 != 65599)
									{
										continue;
									}
								}
								else if (this.$$switch$8375$44934 == 5)
								{
									if (143319 - 153690 != -10371)
									{
										continue;
									}
									Game.mNextGameCode = 36;
									if (125909 - 275469 == -149559)
									{
										continue;
									}
								}
								else
								{
									Game.mNextGameCode = 30;
									if (148885 - 374257 != -225372)
									{
										continue;
									}
								}
								this.$mGameGui$44935 = (GameGui)this.$self_$44936.GetComponent(typeof(GameGui));
								if (8231 - 69373 == -61142)
								{
									if (this.$mGameGui$44935)
									{
										if (217990 - 335808 != -117818)
										{
											continue;
										}
										this.$mGameGui$44935.close();
										if (215859 - 85657 == 130203)
										{
											continue;
										}
									}
									this.$self_$44936.SendMessage("fadeOut");
									if (107434 - 285894 == -178460)
									{
										break;
									}
								}
							}
						}
					}
				}
				return this.Yield(2, new WaitForSeconds((float)1));
				Block_19:
				IL_363:
				return false;
			}

			// Token: 0x0600ACC0 RID: 44224 RVA: 0x01327628 File Offset: 0x01325828
			internal static bool fufe24VBAXJemkOXTvXT()
			{
				return true;
			}

			// Token: 0x0600ACC1 RID: 44225 RVA: 0x0132762C File Offset: 0x0132582C
			internal static bool YRTdSUVBlRGBMdqcxy0i()
			{
				return false;
			}

			// Token: 0x040098C6 RID: 39110
			internal int $$switch$8375$44934;

			// Token: 0x040098C7 RID: 39111
			internal GameGui $mGameGui$44935;

			// Token: 0x040098C8 RID: 39112
			internal M971_MaohsTomb10 $self_$44936;
		}
	}
}
