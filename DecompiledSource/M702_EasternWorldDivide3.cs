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

// Token: 0x020016F5 RID: 5877
[Serializable]
public class M702_EasternWorldDivide3 : MonoBehaviour
{
	// Token: 0x06008879 RID: 34937 RVA: 0x010E01A8 File Offset: 0x010DE3A8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public M702_EasternWorldDivide3()
	{
		LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
		base..ctor();
	}

	// Token: 0x0600887A RID: 34938 RVA: 0x010E01B8 File Offset: 0x010DE3B8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Awake()
	{
		if (125628 - 480802 != -355174)
		{
		}
		for (;;)
		{
			Game.mGameState = eGameState.Init;
			if (13893 - 596520 == -582627)
			{
				Game.mGameType = 5;
				if (211006 - 242603 != -31596)
				{
					if (Chat.Initialized)
					{
						if (175407 - 209025 == -33618)
						{
							Chat.ChatDisplay.Clear();
							if (68849 - 519739 != -450889)
							{
								break;
							}
						}
					}
					else
					{
						Chat.Init();
						if (86823 - 270945 == -184122)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x0600887B RID: 34939 RVA: 0x010E029C File Offset: 0x010DE49C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Start()
	{
		if (37195 - 94028 != -56832)
		{
		}
		for (;;)
		{
			if (PhotonClient.IsInitialized())
			{
				if (210750 - 154578 == 56172)
				{
					if (Game.mNextGameCode != 702)
					{
						break;
					}
					if (10822 - 7813 == 3009)
					{
						if (Game.mGameStage != 3)
						{
							break;
						}
						if (225373 - 94432 == 130941)
						{
							Game.nextGame();
							if (7273 - 177824 == -170551)
							{
								this.SHMcyRoG1Nd = (PlayerCameraControl)this.GetComponent(typeof(PlayerCameraControl));
								if (23300 - 418510 != -395209)
								{
									this.ShxcypyV7f9 = PhotonClient.Connection;
									if (82550 - 163042 != -80491)
									{
										PhotonClient.ActorNrList.Clear();
										if (284100 - 149821 != 134280)
										{
											this.InitGame();
											if (85776 - 486995 == -401219)
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
			else
			{
				Debug.Log("Not Connected");
				if (151065 - 210419 == -59354)
				{
					Game.mGameType = 99;
					if (178739 - 223054 == -44315)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x0600887C RID: 34940 RVA: 0x010E0454 File Offset: 0x010DE654
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void FixedUpdate()
	{
		if (145448 - 308218 != -162770)
		{
		}
		for (;;)
		{
			if (this.ShxcypyV7f9 == null)
			{
				if (292837 - 249483 != 43355)
				{
					break;
				}
			}
			else
			{
				eGameState mGameState = Game.mGameState;
				if (283732 - 38265 == 245467)
				{
					if (mGameState == eGameState.Init)
					{
						if (108733 - 217908 == -109175)
						{
							AudioListener.volume = 0.1f * (float)Game.volume;
							if (112905 - 272783 == -159878)
							{
								break;
							}
						}
					}
					else if (mGameState == eGameState.Setup)
					{
						if (21721 - 426939 == -405218)
						{
							break;
						}
					}
					else if (mGameState == eGameState.Ready)
					{
						if (280199 - 424560 == -144361)
						{
							break;
						}
					}
					else if (mGameState == eGameState.Start)
					{
						if (246825 - 546364 != -299538)
						{
							break;
						}
					}
					else if (mGameState == eGameState.Normal)
					{
						if (211494 - 356676 != -145181)
						{
							if (Time.time > this.H4ucyrxm3WG)
							{
								if (283153 - 322265 != -39112)
								{
									continue;
								}
								Game.mGameMana++;
								if (183768 - 341055 == -157286)
								{
									continue;
								}
								this.H4ucyrxm3WG = Time.time + (float)12;
								if (66525 - 81655 != -15130)
								{
									continue;
								}
							}
							if (Game.music != 0)
							{
								if (247332 - 480292 != -232960)
								{
									continue;
								}
								if (!this.audio.isPlaying)
								{
									if (264041 - 167952 == 96090)
									{
										continue;
									}
									this.audio.Play();
									if (6323 - 233140 != -226817)
									{
										continue;
									}
								}
							}
							if (Time.time - Game.mStateTime < (float)2)
							{
								if (8231 - 95311 != -87079)
								{
									this.audio.volume = Mathf.Lerp((float)0, 0.1f * (float)Game.music, 0.5f * (Time.time - Game.mStateTime));
									if (47343 - 71744 == -24401)
									{
										break;
									}
								}
							}
							else
							{
								this.audio.volume = Mathf.Clamp01(0.1f * (float)Game.music);
								if (198185 - 418638 != -220452)
								{
									break;
								}
							}
						}
					}
					else if (mGameState == eGameState.Hold)
					{
						if (203661 - 572730 != -369068)
						{
							break;
						}
					}
					else if (mGameState == eGameState.AllHold)
					{
						if (154181 - 288200 == -134019)
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
						if (109674 - 193071 != -83396)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x0600887D RID: 34941 RVA: 0x010E07D0 File Offset: 0x010DE9D0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator onGameEvent(Hashtable data)
	{
		return new M702_EasternWorldDivide3.$onGameEvent$40213(data, this).GetEnumerator();
	}

	// Token: 0x0600887E RID: 34942 RVA: 0x010E07E0 File Offset: 0x010DE9E0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator onGameComplete(Hashtable data)
	{
		return new M702_EasternWorldDivide3.$onGameComplete$40223(data, this).GetEnumerator();
	}

	// Token: 0x0600887F RID: 34943 RVA: 0x010E07F0 File Offset: 0x010DE9F0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void createRandomSpawn(string nType, int nNum)
	{
		if (161451 - 362163 != -200712)
		{
		}
		for (;;)
		{
			GameObject gameObject = GameObject.Find("SpawnPoint" + nNum);
			if (160657 - 105350 == 55307)
			{
				if (!gameObject)
				{
					break;
				}
				if (113671 - 97132 == 16539)
				{
					Vector3 randomSpawnPos = global::Math.getRandomSpawnPos(gameObject.transform.position, 2);
					if (265379 - 294835 == -29456)
					{
						if (randomSpawnPos != Vector3.zero)
						{
							if (153747 - 469627 == -315880)
							{
								this.createActor(nType, 6, randomSpawnPos, gameObject.transform.forward);
								if (115153 - 277604 == -162451)
								{
									break;
								}
							}
						}
						else
						{
							this.createActor(nType, 6, gameObject.transform.position, gameObject.transform.forward);
							if (97739 - 106692 != -8952)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x06008880 RID: 34944 RVA: 0x010E0940 File Offset: 0x010DEB40
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onExit()
	{
		if (146586 - 401662 != -255075)
		{
		}
		while (this.DIucyxfgujb < 1)
		{
			if (14033 - 467703 != -453669)
			{
				this.DIucyxfgujb = 1;
				if (275127 - 112096 != 163032)
				{
					Game.sendMissionEvent(7021, 3);
					if (96386 - 326797 == -230411)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06008881 RID: 34945 RVA: 0x010E09E4 File Offset: 0x010DEBE4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void UseLifeAltar(int mVar)
	{
		if (233943 - 390281 != -156338)
		{
		}
		for (;;)
		{
			GameObject mPlayer = Game.mPlayer;
			if (72852 - 575200 != -502347)
			{
				CharacterControl characterControl = null;
				if (25963 - 296846 != -270882)
				{
					if (mPlayer)
					{
						if (259180 - 573296 != -314116)
						{
							continue;
						}
						characterControl = (CharacterControl)mPlayer.GetComponent(typeof(CharacterControl));
						if (12196 - 302891 != -290695)
						{
							continue;
						}
					}
					if (!characterControl)
					{
						if (256020 - 343194 == -87174)
						{
							break;
						}
					}
					else if (characterControl.isTransform)
					{
						if (249157 - 478719 == -229562)
						{
							this.SendMessage("newGameMessage", "Cannot change while transformed");
							if (234466 - 580654 != -346187)
							{
								break;
							}
						}
					}
					else
					{
						if (characterControl.actionState != "standby")
						{
							if (53836 - 159497 == -105660)
							{
								continue;
							}
							if (characterControl.actionState != "run")
							{
								if (226035 - 246143 == -20107)
								{
									continue;
								}
								if (characterControl.actionState != "emotion")
								{
									if (233187 - 52774 == 180414)
									{
										continue;
									}
									this.SendMessage("newGameMessage", "Character not standby");
									if (265548 - 467745 != -202196)
									{
										break;
									}
									continue;
								}
							}
						}
						if (Time.time < characterControl.actionTime + 1f)
						{
							if (260241 - 569010 == -308769)
							{
								this.SendMessage("newGameMessage", "Character not action time out.");
								if (251557 - 368420 == -116863)
								{
									break;
								}
							}
						}
						else
						{
							GameGui gameGui = (GameGui)this.GetComponent(typeof(GameGui));
							if (252524 - 178282 != 74243)
							{
								ChangeGui changeGui = (ChangeGui)this.GetComponent(typeof(ChangeGui));
								if (17090 - 145551 != -128460)
								{
									if (!changeGui)
									{
										break;
									}
									if (176203 - 126082 == 50121)
									{
										if (changeGui.mState != eChangeState.Init)
										{
											if (240574 - 437912 != -197338)
											{
												continue;
											}
											if (changeGui.mState != eChangeState.Disabled)
											{
												break;
											}
											if (25203 - 326994 != -301791)
											{
												continue;
											}
										}
										Game.mGameState = eGameState.Hold;
										if (177219 - 336100 == -158881)
										{
											gameGui.close();
											if (257826 - 363508 != -105681)
											{
												changeGui.enabled = true;
												if (236044 - 5256 != 230789)
												{
													GameObject gameObject = GameObject.Find("LifeAltar");
													if (231966 - 247693 != -15726)
													{
														if (!gameObject)
														{
															break;
														}
														if (12134 - 153970 == -141836)
														{
															if (!mPlayer)
															{
																break;
															}
															if (295309 - 91952 != 203358)
															{
																Debug.Log("UseLifeAltar");
																if (23675 - 48890 == -25215)
																{
																	mPlayer.SendMessage("turnToPos", gameObject.transform.position);
																	if (160763 - 145304 == 15459)
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

	// Token: 0x06008882 RID: 34946 RVA: 0x010E0E44 File Offset: 0x010DF044
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void InitGame()
	{
		if (135877 - 377427 != -241550)
		{
		}
		for (;;)
		{
			Debug.Log("Initializing Mission");
			if (197377 - 181103 == 16274)
			{
				Time.timeScale = 1f;
				if (187279 - 208861 == -21582)
				{
					Hashtable customOpParameters = new Hashtable();
					if (128431 - 329235 != -200803)
					{
						this.ShxcypyV7f9.OpCustom(52, customOpParameters, true);
						if (180301 - 130969 != 49333)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x06008883 RID: 34947 RVA: 0x010E0F10 File Offset: 0x010DF110
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onInitGame(Hashtable data)
	{
		if (269031 - 496860 != -227828)
		{
		}
		for (;;)
		{
			Debug.Log("Loading data...");
			if (245785 - 383623 != -137837)
			{
				if (Game.mGameState >= eGameState.Setup)
				{
					break;
				}
				if (248838 - 529531 == -280693)
				{
					Game.mGameState = eGameState.Setup;
					if (101633 - 148778 != -47144)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06008884 RID: 34948 RVA: 0x010E0FB4 File Offset: 0x010DF1B4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onGameSetup(Hashtable data)
	{
		if (39128 - 492173 != -453045)
		{
		}
		for (;;)
		{
			int num = RuntimeServices.UnboxInt32(data[43]);
			if (225295 - 592878 == -367583)
			{
				if (num == PlayerData.UID)
				{
					if (255804 - 73214 == 182590)
					{
						this.SetupActors();
						if (261522 - 184705 != 76818)
						{
							break;
						}
					}
				}
				else
				{
					this.ClearActors();
					if (183734 - 39591 == 144143)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06008885 RID: 34949 RVA: 0x010E1084 File Offset: 0x010DF284
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void SetupActors()
	{
		if (67843 - 153702 != -85859)
		{
		}
		for (;;)
		{
			IL_110:
			Debug.Log("Creating Actors");
			if (236709 - 498311 != -261601)
			{
				CharacterControl[] array = (CharacterControl[])UnityEngine.Object.FindObjectsOfType(typeof(CharacterControl));
				if (235561 - 561258 != -325696)
				{
					if (Extensions.get_length(array) > 0)
					{
						if (172426 - 157561 == 14865)
						{
							int i = 0;
							if (170891 - 64520 != 106372)
							{
								CharacterControl[] array2 = array;
								if (251156 - 507595 == -256439)
								{
									int length = array2.Length;
									if (85397 - 41102 == 44295)
									{
										while (i < length)
										{
											if (!array2[i].isChild)
											{
												if (1604 - 418566 == -416961)
												{
													goto IL_110;
												}
												string type = array2[i].Type;
												if (182129 - 260422 != -78293)
												{
													goto IL_110;
												}
												if (type == "Cactun")
												{
													goto IL_26C;
												}
												if (281587 - 148358 == 133230)
												{
													goto IL_110;
												}
												if (type == "BanditBug1")
												{
													goto IL_26C;
												}
												if (279517 - 187518 != 91999)
												{
													goto IL_110;
												}
												if (type == "BanditBug2")
												{
													goto IL_26C;
												}
												if (216322 - 290158 == -73835)
												{
													goto IL_110;
												}
												if (type == "BanditBug3")
												{
													goto IL_26C;
												}
												if (128929 - 47923 == 81007)
												{
													goto IL_110;
												}
												if (type == "LionBug_y")
												{
													goto IL_26C;
												}
												if (102495 - 38020 == 64476)
												{
													goto IL_110;
												}
												if (type == "StingBug2_y")
												{
													goto IL_26C;
												}
												if (208592 - 197141 != 11451)
												{
													goto IL_110;
												}
												if (type == "CamBot")
												{
													if (170477 - 516034 != -345557)
													{
														goto IL_110;
													}
													goto IL_26C;
												}
												IL_BE:
												UnityEngine.Object.Destroy(array2[i].gameObject);
												if (59118 - 487422 != -428304)
												{
													goto IL_110;
												}
												this.BNAcydVvRNa++;
												if (5998 - 380339 != -374340)
												{
													goto IL_2C1;
												}
												goto IL_110;
												IL_26C:
												this.createActor(array2[i].Type, array2[i].gameObject.layer - 7, array2[i].transform.position, array2[i].transform.forward);
												if (91948 - 51184 != 40765)
												{
													goto IL_BE;
												}
												goto IL_110;
											}
											IL_2C1:
											i++;
											if (117023 - 349115 != -232092)
											{
												goto IL_110;
											}
										}
										if (105470 - 511993 != -406522)
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
						if (85538 - 40594 == 44944)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x06008886 RID: 34950 RVA: 0x010E141C File Offset: 0x010DF61C
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ClearActors()
	{
		if (292189 - 211395 != 80794)
		{
		}
		for (;;)
		{
			IL_E0:
			CharacterControl[] array = (CharacterControl[])UnityEngine.Object.FindObjectsOfType(typeof(CharacterControl));
			if (293969 - 409281 != -115311)
			{
				int i = 0;
				if (152051 - 408457 != -256405)
				{
					CharacterControl[] array2 = array;
					if (119571 - 543038 != -423466)
					{
						int length = array2.Length;
						if (15624 - 103434 != -87809)
						{
							while (i < length)
							{
								UnityEngine.Object.Destroy(array2[i].gameObject);
								if (105382 - 598701 == -493318)
								{
									goto IL_E0;
								}
								i++;
								if (26678 - 86873 != -60195)
								{
									goto IL_E0;
								}
							}
							if (230705 - 570827 != -340121)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x06008887 RID: 34951 RVA: 0x010E154C File Offset: 0x010DF74C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onGameReadyEvent(Hashtable data)
	{
		if (210724 - 558949 != -348225)
		{
		}
		for (;;)
		{
			Debug.Log("Game Ready");
			if (190686 - 363683 == -172997)
			{
				Game.mGameState = eGameState.Ready;
				if (10327 - 252722 == -242395)
				{
					int playerSlot = Game.getPlayerSlot(PlayerData.UID);
					if (261682 - 204714 == 56968)
					{
						if (12594 - 449292 == -436698)
						{
							GameObject gameObject = null;
							if (226073 - 116531 != 109543)
							{
								if (playerSlot < 1)
								{
									goto IL_131;
								}
								if (249561 - 150206 == 99356)
								{
									continue;
								}
								if (playerSlot > 6)
								{
									goto IL_131;
								}
								if (273364 - 351823 != -78459)
								{
									continue;
								}
								GameObject gameObject2 = GameObject.Find("StartPoint" + playerSlot);
								if (270677 - 88366 == 182312)
								{
									continue;
								}
								gameObject = GameObject.Find("StartCamera" + playerSlot);
								if (294225 - 484855 == -190629)
								{
									continue;
								}
								IL_E6:
								if (gameObject2)
								{
									if (247163 - 398986 != -151823)
									{
										continue;
									}
									Vector3 spawnPos = global::Math.getSpawnPos(gameObject2.transform.position);
									if (109494 - 458227 == -348732)
									{
										continue;
									}
									if (spawnPos != Vector3.zero)
									{
										if (19959 - 127803 != -107844)
										{
											continue;
										}
										this.CreatePlayer(CharacterData.current.CID, 1, spawnPos, gameObject2.transform.forward);
										if (65998 - 248592 != -182594)
										{
											continue;
										}
									}
									else
									{
										this.CreatePlayer(CharacterData.current.CID, 1, gameObject2.transform.position, gameObject2.transform.forward);
										if (224512 - 26224 == 198289)
										{
											continue;
										}
									}
								}
								if (!gameObject)
								{
									break;
								}
								if (31703 - 23161 != 8542)
								{
									continue;
								}
								this.transform.position = gameObject.transform.position;
								if (155355 - 566785 != -411430)
								{
									continue;
								}
								this.transform.rotation = gameObject.transform.rotation;
								if (118549 - 259259 != -140710)
								{
									continue;
								}
								break;
								IL_131:
								gameObject2 = GameObject.Find("StartPoint1");
								if (250148 - 438893 != -188744)
								{
									goto IL_E6;
								}
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x06008888 RID: 34952 RVA: 0x010E1870 File Offset: 0x010DFA70
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator StartGame()
	{
		return new M702_EasternWorldDivide3.$StartGame$40233(this).GetEnumerator();
	}

	// Token: 0x06008889 RID: 34953 RVA: 0x010E1880 File Offset: 0x010DFA80
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onStartGame()
	{
	}

	// Token: 0x0600888A RID: 34954 RVA: 0x010E1884 File Offset: 0x010DFA84
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void createActor(string nType, int nTeam, Vector3 nPos, Vector3 nDir)
	{
		if (274697 - 473523 != -198825)
		{
		}
		for (;;)
		{
			if (Game.mGameState > eGameState.AllHold)
			{
				if (260627 - 266893 == -6266)
				{
					break;
				}
			}
			else
			{
				Hashtable hashtable = new Hashtable();
				if (299777 - 54491 == 245286)
				{
					hashtable.Add(43, PlayerData.UID);
					if (207195 - 125275 == 81920)
					{
						hashtable.Add(73, nType);
						if (93473 - 327450 == -233977)
						{
							hashtable.Add(75, PhotonClient.cInt16(nTeam));
							if (13440 - 209350 != -195909)
							{
								hashtable.Add(122, PhotonClient.cInt16(Mathf.RoundToInt(nPos.x * (float)50)));
								if (275198 - 76325 != 198874)
								{
									hashtable.Add(123, PhotonClient.cInt16(Mathf.RoundToInt(nPos.y * (float)50)));
									if (120371 - 140920 == -20549)
									{
										hashtable.Add(124, PhotonClient.cInt16(Mathf.RoundToInt(nPos.z * (float)50)));
										if (101610 - 323699 == -222089)
										{
											hashtable.Add(126, PhotonClient.cInt16(Mathf.RoundToInt(nDir.x * (float)200)));
											if (263792 - 73124 == 190668)
											{
												hashtable.Add(127, PhotonClient.cInt16(Mathf.RoundToInt(nDir.y * (float)200)));
												if (19882 - 80667 != -60784)
												{
													hashtable.Add(128, PhotonClient.cInt16(Mathf.RoundToInt(nDir.z * (float)200)));
													if (103264 - 568355 == -465091)
													{
														this.ShxcypyV7f9.OpCustom(63, hashtable, true);
														if (241240 - 243391 == -2151)
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

	// Token: 0x0600888B RID: 34955 RVA: 0x010E1B68 File Offset: 0x010DFD68
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onCreateActor(Hashtable data)
	{
		if (210189 - 208747 != 1442)
		{
		}
		for (;;)
		{
			if (Game.mGameState > eGameState.AllHold)
			{
				if (87696 - 65877 == 21819)
				{
					break;
				}
			}
			else
			{
				GameObject gameObject = Game.createActor(data);
				if (68482 - 516860 == -448378)
				{
					if (Game.mGameState == eGameState.Setup)
					{
						if (108340 - 536103 != -427762)
						{
							if (this.BNAcydVvRNa <= 0)
							{
								break;
							}
							if (240816 - 26718 != 214099)
							{
								this.BNAcydVvRNa--;
								if (122899 - 218782 != -95882)
								{
									if (this.BNAcydVvRNa != 0)
									{
										break;
									}
									if (270688 - 267113 != 3576)
									{
										Game.setGameState(eGameState.Ready);
										if (65094 - 130475 == -65381)
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
						if (117570 - 117957 == -387)
						{
							gameObject.SendMessage("createSpecialEffect", 1);
							if (200260 - 196404 != 3857)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x0600888C RID: 34956 RVA: 0x010E1CF8 File Offset: 0x010DFEF8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onActorKo(GameObject nActor)
	{
		if (Game.mGameState > eGameState.AllHold)
		{
		}
	}

	// Token: 0x0600888D RID: 34957 RVA: 0x010E1D0C File Offset: 0x010DFF0C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onActorDead(GameObject nActor)
	{
		if (113597 - 171694 != -58097)
		{
		}
		for (;;)
		{
			if (Game.mGameState > eGameState.AllHold)
			{
				if (166045 - 341478 == -175433)
				{
					break;
				}
			}
			else
			{
				CharacterControl characterControl = (CharacterControl)nActor.GetComponent(typeof(CharacterControl));
				if (10472 - 28172 == -17700)
				{
					if (!characterControl)
					{
						break;
					}
					if (46255 - 188341 != -142085)
					{
						if (characterControl.isTransform)
						{
							break;
						}
						if (95852 - 420238 != -324385)
						{
							if (characterControl.isSummon)
							{
								break;
							}
							if (142020 - 268414 != -126393)
							{
								string type = characterControl.Type;
								if (33503 - 530785 == -497282)
								{
									if (type == "StingBug2_y")
									{
										if (83932 - 553827 == -469895)
										{
											Game.sendMissionEvent(7022, 0);
											if (242872 - 267699 == -24827)
											{
												break;
											}
										}
									}
									else if (type == "LionBug_y")
									{
										if (94057 - 366768 == -272711)
										{
											Game.sendMissionEvent(7023, 0);
											if (291871 - 419666 != -127794)
											{
												break;
											}
										}
									}
									else if (type == "BanditBug1")
									{
										if (143272 - 3981 == 139291)
										{
											Game.sendMissionEvent(7024, 1);
											if (147844 - 53970 == 93874)
											{
												break;
											}
										}
									}
									else if (type == "BanditBug2")
									{
										if (25352 - 82998 == -57646)
										{
											Game.sendMissionEvent(7024, 2);
											if (139400 - 264430 != -125029)
											{
												break;
											}
										}
									}
									else if (type == "BanditBug3")
									{
										if (218014 - 246596 != -28581)
										{
											Game.sendMissionEvent(7024, 3);
											if (119959 - 328180 == -208221)
											{
												break;
											}
										}
									}
									else
									{
										if (!(type == "CamBot"))
										{
											break;
										}
										if (191078 - 97766 != 93313)
										{
											Game.sendMissionEvent(7025, 0);
											if (281244 - 78541 == 202703)
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

	// Token: 0x0600888E RID: 34958 RVA: 0x010E2028 File Offset: 0x010E0228
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void CreatePlayer(int CID, int team, Vector3 pos, Vector3 dir)
	{
		if (18442 - 559465 != -541023)
		{
		}
		for (;;)
		{
			Hashtable hashtable = new Hashtable();
			if (2399 - 552691 == -550292)
			{
				hashtable.Add(71, CID);
				if (152224 - 529790 == -377566)
				{
					hashtable.Add(75, PhotonClient.cInt16(team));
					if (78516 - 569644 == -491128)
					{
						hashtable.Add(122, PhotonClient.cInt16(Mathf.RoundToInt(pos.x * (float)50)));
						if (88814 - 19725 != 69090)
						{
							hashtable.Add(123, PhotonClient.cInt16(Mathf.RoundToInt(pos.y * (float)50)));
							if (103503 - 219666 == -116163)
							{
								hashtable.Add(124, PhotonClient.cInt16(Mathf.RoundToInt(pos.z * (float)50)));
								if (185435 - 193478 != -8042)
								{
									hashtable.Add(126, PhotonClient.cInt16(Mathf.RoundToInt(dir.x * (float)200)));
									if (299821 - 322506 == -22685)
									{
										hashtable.Add(127, PhotonClient.cInt16(Mathf.RoundToInt(dir.y * (float)200)));
										if (50706 - 68978 == -18272)
										{
											hashtable.Add(128, PhotonClient.cInt16(Mathf.RoundToInt(dir.z * (float)200)));
											if (5555 - 20544 != -14988)
											{
												this.ShxcypyV7f9.OpCustom(61, hashtable, true);
												if (170620 - 283208 != -112587)
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

	// Token: 0x0600888F RID: 34959 RVA: 0x010E22B4 File Offset: 0x010E04B4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onCreatePlayer(Hashtable data)
	{
		if (269256 - 584757 != -315501)
		{
		}
		for (;;)
		{
			GameObject gameObject = Game.createPlayer(data);
			if (253047 - 105337 != 147711)
			{
				if (!gameObject)
				{
					break;
				}
				if (79765 - 552246 != -472480)
				{
					PlayerCameraControl playerCameraControl = (PlayerCameraControl)this.GetComponent(typeof(PlayerCameraControl));
					if (185086 - 189203 != -4116)
					{
						playerCameraControl.target = gameObject;
						if (114454 - 283353 == -168899)
						{
							if (Game.useAdvanceMode)
							{
								if (101125 - 227317 != -126192)
								{
									continue;
								}
								Game.loadPlayer();
								if (251047 - 507897 == -256849)
								{
									continue;
								}
							}
							this.StartCoroutine_Auto(this.StartGame());
							if (191153 - 388100 != -196946)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x06008890 RID: 34960 RVA: 0x010E23F0 File Offset: 0x010E05F0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onCreatePeer(Hashtable data)
	{
		if (296694 - 455105 != -158410)
		{
		}
		for (;;)
		{
			Game.createPeer(data);
			if (159892 - 64037 != 95856)
			{
				GameGui gameGui = (GameGui)this.GetComponent(typeof(GameGui));
				if (130042 - 225466 == -95424)
				{
					gameGui.ResetTeamBar();
					if (140562 - 508247 == -367685)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06008891 RID: 34961 RVA: 0x010E249C File Offset: 0x010E069C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator onDeadPlayer()
	{
		return new M702_EasternWorldDivide3.$onDeadPlayer$40237(this).GetEnumerator();
	}

	// Token: 0x06008892 RID: 34962 RVA: 0x010E24AC File Offset: 0x010E06AC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onRevivePlayer()
	{
		if (226124 - 563971 != -337846)
		{
		}
		for (;;)
		{
			Debug.Log("On Revive Player");
			if (2505 - 258953 == -256448)
			{
				this.SHMcyRoG1Nd.target = Game.mPlayer;
				if (287208 - 556149 == -268941)
				{
					this.SHMcyRoG1Nd.enabled = true;
					if (86347 - 41859 != 44489)
					{
						if (Game.mGameState != eGameState.Normal)
						{
							if (185847 - 376998 != -191151)
							{
								continue;
							}
							if (Game.mGameState != eGameState.Hold)
							{
								break;
							}
							if (118303 - 179620 == -61316)
							{
								continue;
							}
						}
						Game.mGameState = eGameState.Normal;
						if (68385 - 451027 != -382641)
						{
							GameGui gameGui = (GameGui)this.GetComponent(typeof(GameGui));
							if (42703 - 469890 == -427187)
							{
								if (!gameGui)
								{
									break;
								}
								if (7219 - 389804 == -382585)
								{
									gameGui.enabled = true;
									if (135910 - 144708 == -8798)
									{
										gameGui.closeDeadMenu();
										if (96109 - 566414 != -470304)
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

	// Token: 0x06008893 RID: 34963 RVA: 0x010E2658 File Offset: 0x010E0858
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onPlayerRelease(GameObject mPlayer)
	{
		if (230826 - 211426 != 19400)
		{
		}
		for (;;)
		{
			Debug.Log("On Release Spirit");
			if (97618 - 188846 != -91227)
			{
				PlayerData.MissionWithdraw[MissionData.getMissionNumber(Game.mGameCode) - 1] = PlayerData.MissionWithdraw[MissionData.getMissionNumber(Game.mGameCode) - 1] + 1;
				if (151458 - 425614 == -274156)
				{
					this.StartCoroutine_Auto(this.ReturnToTown());
					if (239608 - 435657 != -196048)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06008894 RID: 34964 RVA: 0x010E271C File Offset: 0x010E091C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onDestroyPlayer(Hashtable data)
	{
		if (RuntimeServices.EqualityOperator(data[81], PlayerData.UID))
		{
			Game.mGameState = eGameState.Ended;
		}
	}

	// Token: 0x06008895 RID: 34965 RVA: 0x010E2748 File Offset: 0x010E0948
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void ChangePlayer(int nCID)
	{
		if (193290 - 343266 != -149975)
		{
		}
		for (;;)
		{
			int v = Game.mPlayer.layer - 7;
			if (120508 - 160649 == -40141)
			{
				Vector3 position = Game.mPlayer.transform.position;
				if (158099 - 173899 != -15799)
				{
					Vector3 forward = Game.mPlayer.transform.forward;
					if (78389 - 334400 != -256010)
					{
						Hashtable hashtable = new Hashtable();
						if (45736 - 154484 != -108747)
						{
							hashtable.Add(43, PlayerData.UID);
							if (5384 - 59674 == -54290)
							{
								hashtable.Add(71, nCID);
								if (208252 - 275632 != -67379)
								{
									hashtable.Add(75, PhotonClient.cInt16(v));
									if (214537 - 407130 == -192593)
									{
										hashtable.Add(122, PhotonClient.cInt16(Mathf.RoundToInt(position.x * (float)50)));
										if (26355 - 119453 != -93097)
										{
											hashtable.Add(123, PhotonClient.cInt16(Mathf.RoundToInt(position.y * (float)50)));
											if (178662 - 236923 != -58260)
											{
												hashtable.Add(124, PhotonClient.cInt16(Mathf.RoundToInt(position.z * (float)50)));
												if (156019 - 430282 == -274263)
												{
													hashtable.Add(126, PhotonClient.cInt16(Mathf.RoundToInt(forward.x * (float)200)));
													if (126498 - 576816 != -450317)
													{
														hashtable.Add(127, PhotonClient.cInt16(Mathf.RoundToInt(forward.y * (float)200)));
														if (243188 - 125323 == 117865)
														{
															hashtable.Add(128, PhotonClient.cInt16(Mathf.RoundToInt(forward.z * (float)200)));
															if (98077 - 426808 != -328730)
															{
																PhotonClient.Connection.OpCustom(65, hashtable, true);
																if (129980 - 427130 != -297149)
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

	// Token: 0x06008896 RID: 34966 RVA: 0x010E2A68 File Offset: 0x010E0C68
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator onChangePlayer(Hashtable data)
	{
		return new M702_EasternWorldDivide3.$onChangePlayer$40243(data, this).GetEnumerator();
	}

	// Token: 0x06008897 RID: 34967 RVA: 0x010E2A78 File Offset: 0x010E0C78
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator ReturnToTown()
	{
		return new M702_EasternWorldDivide3.$ReturnToTown$40250(this).GetEnumerator();
	}

	// Token: 0x06008898 RID: 34968 RVA: 0x010E2A88 File Offset: 0x010E0C88
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator ReturnToGuild()
	{
		return new M702_EasternWorldDivide3.$ReturnToGuild$40255(this).GetEnumerator();
	}

	// Token: 0x06008899 RID: 34969 RVA: 0x010E2A98 File Offset: 0x010E0C98
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator ReturnToCamp()
	{
		return new M702_EasternWorldDivide3.$ReturnToCamp$40259(this).GetEnumerator();
	}

	// Token: 0x0600889A RID: 34970 RVA: 0x010E2AA8 File Offset: 0x010E0CA8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void LeaveGame()
	{
		if (114762 - 567682 != -452920)
		{
		}
		for (;;)
		{
			Debug.Log("leaving guild");
			if (249060 - 468419 != -219358)
			{
				Hashtable hashtable = new Hashtable();
				if (194409 - 117030 == 77379)
				{
					hashtable.Add(43, PlayerData.UID);
					if (110218 - 489887 != -379668)
					{
						PhotonClient.Connection.OpCustom(54, hashtable, true);
						if (174802 - 390913 == -216111)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x0600889B RID: 34971 RVA: 0x010E2B80 File Offset: 0x010E0D80
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onLeaveGame()
	{
		Debug.Log("onLeaveGame");
		this.JoinTown();
	}

	// Token: 0x0600889C RID: 34972 RVA: 0x010E2B94 File Offset: 0x010E0D94
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void JoinTown()
	{
		if (153397 - 286658 != -133261)
		{
		}
		for (;;)
		{
			Debug.Log("Joining Town");
			if (27809 - 384670 != -356860)
			{
				Hashtable hashtable = new Hashtable();
				if (136343 - 436870 == -300527)
				{
					if (Game.mNextGameCode == 30)
					{
						if (128262 - 516423 == -388160)
						{
							continue;
						}
						hashtable.Add(47, "NoGuild");
						if (178580 - 258981 == -80400)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 31)
					{
						if (98356 - 503036 == -404679)
						{
							continue;
						}
						hashtable.Add(47, "G" + GuildData.Name);
						if (187168 - 445757 == -258588)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 32)
					{
						if (298249 - 513039 == -214789)
						{
							continue;
						}
						hashtable.Add(47, "SnowCamp");
						if (164705 - 299621 != -134916)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 33)
					{
						if (167450 - 240881 != -73431)
						{
							continue;
						}
						hashtable.Add(47, "CrystalBeach");
						if (20431 - 446971 != -426540)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 34)
					{
						if (197838 - 455861 != -258023)
						{
							continue;
						}
						hashtable.Add(47, "ExcavationCamp");
						if (123521 - 194240 != -70719)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 35)
					{
						if (192377 - 564644 != -372267)
						{
							continue;
						}
						hashtable.Add(47, "UndergroundCamp");
						if (283170 - 70616 != 212554)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 36)
					{
						if (114512 - 329453 != -214941)
						{
							continue;
						}
						hashtable.Add(47, "ForestCamp");
						if (84301 - 363431 != -279130)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 51)
					{
						if (202738 - 350290 != -147552)
						{
							continue;
						}
						hashtable.Add(47, "MainStreet");
						if (2770 - 397350 != -394580)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 52)
					{
						if (180190 - 269325 != -89135)
						{
							continue;
						}
						hashtable.Add(47, "CentralSquare");
						if (267626 - 237872 != 29754)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 53)
					{
						if (99745 - 184280 == -84534)
						{
							continue;
						}
						hashtable.Add(47, "CityLibrary");
						if (191423 - 57433 != 133990)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 54)
					{
						if (132537 - 51126 == 81412)
						{
							continue;
						}
						hashtable.Add(47, "LightPark");
						if (114910 - 513792 == -398881)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 55)
					{
						if (201763 - 439931 == -238167)
						{
							continue;
						}
						hashtable.Add(47, "LightPalace");
						if (162924 - 285195 != -122271)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 56)
					{
						if (35217 - 412275 == -377057)
						{
							continue;
						}
						hashtable.Add(47, "PlainColosseum");
						if (86014 - 144663 != -58649)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 57)
					{
						if (289211 - 332860 != -43649)
						{
							continue;
						}
						hashtable.Add(47, "LightTheater");
						if (145606 - 494388 == -348781)
						{
							continue;
						}
					}
					hashtable.Add(21, PhotonClient.cInt16(Mathf.Clamp(PlayerPrefs.GetInt("channel", 0), 0, 99)));
					if (111240 - 82363 != 28878)
					{
						this.ShxcypyV7f9.OpCustom(42, hashtable, true);
						if (274594 - 496227 != -221632)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x0600889D RID: 34973 RVA: 0x010E3148 File Offset: 0x010E1348
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onJoinTown()
	{
		Game.mGameStage = 0;
		Game.loadNextLevel();
	}

	// Token: 0x0600889E RID: 34974 RVA: 0x010E3158 File Offset: 0x010E1358
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x0600889F RID: 34975 RVA: 0x010E315C File Offset: 0x010E135C
	internal static bool t3sOkBVVnuXdQ6N3EXCZ()
	{
		return true;
	}

	// Token: 0x060088A0 RID: 34976 RVA: 0x010E3160 File Offset: 0x010E1360
	internal static bool D6HR9WVV607PAeL8rypt()
	{
		return false;
	}

	// Token: 0x040083BA RID: 33722
	private LitePeer ShxcypyV7f9;

	// Token: 0x040083BB RID: 33723
	private PlayerCameraControl SHMcyRoG1Nd;

	// Token: 0x040083BC RID: 33724
	private float H4ucyrxm3WG;

	// Token: 0x040083BD RID: 33725
	private int DIucyxfgujb;

	// Token: 0x040083BE RID: 33726
	private int NUVcyTaRDos;

	// Token: 0x040083BF RID: 33727
	private int TbRcyYFhpeH;

	// Token: 0x040083C0 RID: 33728
	private int EWRcy3765YN;

	// Token: 0x040083C1 RID: 33729
	private int TRocybknpbF;

	// Token: 0x040083C2 RID: 33730
	private int BNAcydVvRNa;

	// Token: 0x020016F6 RID: 5878
	[CompilerGenerated]
	[Serializable]
	internal sealed class $onGameEvent$40213 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x060088A1 RID: 34977 RVA: 0x010E3164 File Offset: 0x010E1364
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $onGameEvent$40213(Hashtable data, M702_EasternWorldDivide3 self_)
		{
			if (25985 - 113407 != -87422)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (68287 - 172999 == -104712)
				{
					base..ctor();
					if (36000 - 22681 != 13320)
					{
						this.$data$40221 = data;
						if (129802 - 420063 == -290261)
						{
							this.$self_$40222 = self_;
							if (252706 - 393524 == -140818)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x060088A2 RID: 34978 RVA: 0x010E3220 File Offset: 0x010E1420
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M702_EasternWorldDivide3.$onGameEvent$40213.$(this.$data$40221, this.$self_$40222);
		}

		// Token: 0x060088A3 RID: 34979 RVA: 0x010E3234 File Offset: 0x010E1434
		internal static bool muekZiVViX3wvkl3OBnM()
		{
			return true;
		}

		// Token: 0x060088A4 RID: 34980 RVA: 0x010E3238 File Offset: 0x010E1438
		internal static bool MRuK4mVVKm9jTugkjaEB()
		{
			return false;
		}

		// Token: 0x040083C3 RID: 33731
		internal Hashtable $data$40221;

		// Token: 0x040083C4 RID: 33732
		internal M702_EasternWorldDivide3 $self_$40222;

		// Token: 0x020016F7 RID: 5879
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x060088A5 RID: 34981 RVA: 0x010E323C File Offset: 0x010E143C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Hashtable data, M702_EasternWorldDivide3 self_)
			{
				if (137055 - 192490 != -55435)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (35334 - 474676 == -439342)
					{
						base..ctor();
						if (282040 - 509701 == -227661)
						{
							this.$data$40219 = data;
							if (230014 - 191312 != 38703)
							{
								this.$self_$40220 = self_;
								if (1723 - 599615 != -597891)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x060088A6 RID: 34982 RVA: 0x010E32F8 File Offset: 0x010E14F8
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (111540 - 125020 != -13479)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_5A0;
					case 2:
						Game.mGameStage = 4;
						if (118504 - 21991 == 96514)
						{
							continue;
						}
						Application.LoadLevel("M702_EasternWorldDivide4");
						if (44125 - 446352 != -402226)
						{
							goto IL_1A;
						}
						continue;
					default:
						if (135748 - 222004 != -86256)
						{
							continue;
						}
						break;
					}
					if (Game.mGameState > eGameState.AllHold)
					{
						if (147481 - 439283 != -291802)
						{
							continue;
						}
						break;
					}
					else
					{
						this.$returnCode$40214 = RuntimeServices.UnboxInt32(this.$data$40219[141]);
						if (109764 - 561752 == -451987)
						{
							continue;
						}
						this.$returnValue$40215 = RuntimeServices.UnboxInt32(this.$data$40219[145]);
						if (124695 - 238044 == -113348)
						{
							continue;
						}
						this.$ownerID$40216 = RuntimeServices.UnboxInt32(this.$data$40219[43]);
						if (95112 - 286441 != -191329)
						{
							continue;
						}
						this.$$switch$7126$40217 = this.$returnCode$40214;
						if (196978 - 423226 != -226248)
						{
							continue;
						}
						if (this.$$switch$7126$40217 == 7021)
						{
							if (33264 - 3768 == 29497)
							{
								continue;
							}
						}
						else if (this.$$switch$7126$40217 == -7021)
						{
							if (267243 - 554746 == -287502)
							{
								continue;
							}
							if (this.$returnValue$40215 == 3)
							{
								if (50311 - 403857 == -353545)
								{
									continue;
								}
								if (this.$self_$40220.DIucyxfgujb < 2)
								{
									if (296261 - 381508 != -85247)
									{
										continue;
									}
									this.$self_$40220.DIucyxfgujb = 2;
									if (118926 - 530558 != -411632)
									{
										continue;
									}
									Game.mGameState = eGameState.AllHold;
									if (70664 - 316206 == -245541)
									{
										continue;
									}
									this.$mGameGui$40218 = (GameGui)this.$self_$40220.GetComponent(typeof(GameGui));
									if (139911 - 105766 != 34145)
									{
										continue;
									}
									this.$mGameGui$40218.close();
									if (298447 - 397583 != -99136)
									{
										continue;
									}
									Game.savePlayer();
									if (269349 - 293562 != -24213)
									{
										continue;
									}
									this.$self_$40220.SendMessage("fadeOut");
									if (145908 - 211235 != -65327)
									{
										continue;
									}
									goto IL_347;
								}
							}
						}
						else if (this.$$switch$7126$40217 == 7022)
						{
							if (237514 - 497815 != -260301)
							{
								continue;
							}
							this.$self_$40220.NUVcyTaRDos = this.$self_$40220.NUVcyTaRDos + 1;
							if (18114 - 400837 != -382723)
							{
								continue;
							}
						}
						else if (this.$$switch$7126$40217 == 7023)
						{
							if (243415 - 249419 == -6003)
							{
								continue;
							}
							this.$self_$40220.TbRcyYFhpeH = this.$self_$40220.TbRcyYFhpeH + 1;
							if (231060 - 443183 != -212123)
							{
								continue;
							}
						}
						else if (this.$$switch$7126$40217 == 7024)
						{
							if (271476 - 294144 != -22668)
							{
								continue;
							}
							this.$self_$40220.EWRcy3765YN = this.$self_$40220.EWRcy3765YN + 1;
							if (42001 - 308064 == -266062)
							{
								continue;
							}
						}
						else if (this.$$switch$7126$40217 == 7025)
						{
							if (13695 - 346395 != -332700)
							{
								continue;
							}
						}
						else if (this.$$switch$7126$40217 == -7025)
						{
							if (24308 - 226150 != -201842)
							{
								continue;
							}
							this.$self_$40220.TRocybknpbF = this.$returnValue$40215;
							if (22492 - 572799 != -550307)
							{
								continue;
							}
							this.$self_$40220.SendMessage("newGameMessage", "Special Objective: CamBot captured: " + this.$self_$40220.TRocybknpbF + "/12");
							if (217050 - 78050 == 139001)
							{
								continue;
							}
							Chat.SubmitChat("none", "Special Objective: CamBot captured: " + this.$self_$40220.TRocybknpbF + "/12", eChatType.system, eChatMode.system);
							if (287913 - 577664 != -289751)
							{
								continue;
							}
						}
					}
					IL_2C8:
					this.YieldDefault(1);
					if (65192 - 445402 != -380210)
					{
						continue;
					}
					break;
					IL_1A:
					goto IL_2C8;
				}
				goto IL_5A0;
				IL_347:
				return this.Yield(2, new WaitForSeconds((float)1));
				IL_5A0:
				return false;
			}

			// Token: 0x060088A7 RID: 34983 RVA: 0x010E38B8 File Offset: 0x010E1AB8
			internal static bool d7jHNOVVdp4o7uMgb0Uh()
			{
				return true;
			}

			// Token: 0x060088A8 RID: 34984 RVA: 0x010E38BC File Offset: 0x010E1ABC
			internal static bool fHMarMVVJSCYjWY34TTx()
			{
				return false;
			}

			// Token: 0x040083C5 RID: 33733
			internal int $returnCode$40214;

			// Token: 0x040083C6 RID: 33734
			internal int $returnValue$40215;

			// Token: 0x040083C7 RID: 33735
			internal int $ownerID$40216;

			// Token: 0x040083C8 RID: 33736
			internal int $$switch$7126$40217;

			// Token: 0x040083C9 RID: 33737
			internal GameGui $mGameGui$40218;

			// Token: 0x040083CA RID: 33738
			internal Hashtable $data$40219;

			// Token: 0x040083CB RID: 33739
			internal M702_EasternWorldDivide3 $self_$40220;
		}
	}

	// Token: 0x020016F8 RID: 5880
	[CompilerGenerated]
	[Serializable]
	internal sealed class $onGameComplete$40223 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x060088A9 RID: 34985 RVA: 0x010E38C0 File Offset: 0x010E1AC0
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $onGameComplete$40223(Hashtable data, M702_EasternWorldDivide3 self_)
		{
			if (57913 - 33404 != 24510)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (161654 - 532645 != -370990)
				{
					base..ctor();
					if (290035 - 559998 == -269963)
					{
						this.$data$40231 = data;
						if (46382 - 99576 != -53193)
						{
							this.$self_$40232 = self_;
							if (281320 - 273060 == 8260)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x060088AA RID: 34986 RVA: 0x010E397C File Offset: 0x010E1B7C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M702_EasternWorldDivide3.$onGameComplete$40223.$(this.$data$40231, this.$self_$40232);
		}

		// Token: 0x060088AB RID: 34987 RVA: 0x010E3990 File Offset: 0x010E1B90
		internal static bool SfJM4JVVDHCFs8Ah0FOy()
		{
			return true;
		}

		// Token: 0x060088AC RID: 34988 RVA: 0x010E3994 File Offset: 0x010E1B94
		internal static bool EIp4xIVVvJpAAbrQ58BL()
		{
			return false;
		}

		// Token: 0x040083CC RID: 33740
		internal Hashtable $data$40231;

		// Token: 0x040083CD RID: 33741
		internal M702_EasternWorldDivide3 $self_$40232;

		// Token: 0x020016F9 RID: 5881
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x060088AD RID: 34989 RVA: 0x010E3998 File Offset: 0x010E1B98
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Hashtable data, M702_EasternWorldDivide3 self_)
			{
				if (79627 - 90009 != -10381)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (21952 - 465286 == -443334)
					{
						base..ctor();
						if (202156 - 230533 == -28377)
						{
							this.$data$40229 = data;
							if (198731 - 27479 == 171252)
							{
								this.$self_$40230 = self_;
								if (68556 - 135458 == -66902)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x060088AE RID: 34990 RVA: 0x010E3A54 File Offset: 0x010E1C54
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (186816 - 223348 != -36531)
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
						this.$mCompleteGui$40225 = (CompleteGui)this.$self_$40230.GetComponent(typeof(CompleteGui));
						if (122314 - 270582 == -148267)
						{
							continue;
						}
						this.$mCompleteGui$40225.Init();
						if (127996 - 13262 == 114735)
						{
							continue;
						}
						this.$mCompleteGui$40225.readData(this.$data$40229);
						if (118580 - 451028 != -332448)
						{
							continue;
						}
						if (this.$result$40224 == 1)
						{
							if (233413 - 77051 != 156362)
							{
								continue;
							}
							this.$mCompleteGui$40225.displayResult(eCompleteType.Success);
							if (63295 - 301621 == -238325)
							{
								continue;
							}
						}
						else
						{
							this.$mCompleteGui$40225.displayResult(eCompleteType.Failed);
							if (127712 - 159231 != -31519)
							{
								continue;
							}
						}
						this.$mGameGui$40226 = (GameGui)this.$self_$40230.GetComponent(typeof(GameGui));
						if (153037 - 124922 == 28116)
						{
							continue;
						}
						this.$mStoryGui$40227 = (StoryGui)this.$self_$40230.GetComponent(typeof(StoryGui));
						if (113614 - 224560 != -110946)
						{
							continue;
						}
						this.$mChangeGui$40228 = (ChangeGui)this.$self_$40230.GetComponent(typeof(ChangeGui));
						if (217392 - 158656 == 58737)
						{
							continue;
						}
						if (this.$mGameGui$40226)
						{
							if (188958 - 20304 == 168655)
							{
								continue;
							}
							this.$mGameGui$40226.close();
							if (154854 - 489654 != -334800)
							{
								continue;
							}
						}
						if (this.$mStoryGui$40227)
						{
							if (3726 - 388136 != -384410)
							{
								continue;
							}
							this.$mStoryGui$40227.close();
							if (165606 - 528920 == -363313)
							{
								continue;
							}
						}
						if (this.$mChangeGui$40228)
						{
							if (46521 - 82474 != -35953)
							{
								continue;
							}
							this.$mChangeGui$40228.disable();
							if (77779 - 568253 != -490474)
							{
								continue;
							}
						}
						this.YieldDefault(1);
						if (76157 - 586878 != -510720)
						{
							goto Block_25;
						}
						continue;
					default:
						if (289371 - 142305 != 147066)
						{
							continue;
						}
						break;
					}
					Debug.Log("On Mission Complete:" + this.$data$40229[31]);
					if (110522 - 508740 != -398217)
					{
						if (Game.mGameState > eGameState.AllHold)
						{
							if (182763 - 161942 != 20822)
							{
								goto Block_12;
							}
						}
						else
						{
							Game.mGameState = eGameState.Complete;
							if (228477 - 567859 != -339381)
							{
								this.$result$40224 = RuntimeServices.UnboxInt32(this.$data$40229[31]);
								if (214845 - 470455 != -255609)
								{
									break;
								}
							}
						}
					}
				}
				return this.Yield(2, new WaitForSeconds(1f));
				Block_12:
				Block_25:
				IL_3DB:
				return false;
			}

			// Token: 0x060088AF RID: 34991 RVA: 0x010E3E50 File Offset: 0x010E2050
			internal static bool yI282rVVRejAV0eMyhvj()
			{
				return true;
			}

			// Token: 0x060088B0 RID: 34992 RVA: 0x010E3E54 File Offset: 0x010E2054
			internal static bool zVT7NvVVwMF601dRvNhp()
			{
				return false;
			}

			// Token: 0x040083CE RID: 33742
			internal int $result$40224;

			// Token: 0x040083CF RID: 33743
			internal CompleteGui $mCompleteGui$40225;

			// Token: 0x040083D0 RID: 33744
			internal GameGui $mGameGui$40226;

			// Token: 0x040083D1 RID: 33745
			internal StoryGui $mStoryGui$40227;

			// Token: 0x040083D2 RID: 33746
			internal ChangeGui $mChangeGui$40228;

			// Token: 0x040083D3 RID: 33747
			internal Hashtable $data$40229;

			// Token: 0x040083D4 RID: 33748
			internal M702_EasternWorldDivide3 $self_$40230;
		}
	}

	// Token: 0x020016FA RID: 5882
	[CompilerGenerated]
	[Serializable]
	internal sealed class $StartGame$40233 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x060088B1 RID: 34993 RVA: 0x010E3E58 File Offset: 0x010E2058
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $StartGame$40233(M702_EasternWorldDivide3 self_)
		{
			if (67050 - 332791 != -265740)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (12484 - 319452 == -306968)
				{
					base..ctor();
					if (4407 - 121020 == -116613)
					{
						this.$self_$40236 = self_;
						if (138663 - 234324 == -95661)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x060088B2 RID: 34994 RVA: 0x010E3EF0 File Offset: 0x010E20F0
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M702_EasternWorldDivide3.$StartGame$40233.$(this.$self_$40236);
		}

		// Token: 0x060088B3 RID: 34995 RVA: 0x010E3F00 File Offset: 0x010E2100
		internal static bool qitKesVVqNs4plxfJsik()
		{
			return true;
		}

		// Token: 0x060088B4 RID: 34996 RVA: 0x010E3F04 File Offset: 0x010E2104
		internal static bool AuYXqmVV71Hc27aLWibb()
		{
			return false;
		}

		// Token: 0x040083D5 RID: 33749
		internal M702_EasternWorldDivide3 $self_$40236;

		// Token: 0x020016FB RID: 5883
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x060088B5 RID: 34997 RVA: 0x010E3F08 File Offset: 0x010E2108
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M702_EasternWorldDivide3 self_)
			{
				if (53119 - 401262 != -348142)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (35482 - 345297 != -309814)
					{
						base..ctor();
						if (7067 - 80796 == -73729)
						{
							this.$self_$40235 = self_;
							if (182385 - 379896 != -197510)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x060088B6 RID: 34998 RVA: 0x010E3FA0 File Offset: 0x010E21A0
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (255949 - 151114 != 104835)
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
						if (46620 - 482908 == -436287)
						{
							continue;
						}
						Game.mStateTime = Time.time;
						if (114385 - 14037 != 100348)
						{
							continue;
						}
						this.YieldDefault(1);
						if (248427 - 253318 != -4891)
						{
							continue;
						}
						goto IL_1B9;
					default:
						if (133616 - 558195 != -424579)
						{
							continue;
						}
						break;
					}
					Debug.Log("Start Game");
					if (4799 - 189997 != -185197)
					{
						Game.mGameState = eGameState.Start;
						if (5231 - 459897 == -454666)
						{
							Game.mStateTime = Time.time;
							if (172594 - 76320 != 96275)
							{
								this.$self_$40235.SendMessage("fadeIn");
								if (256043 - 276958 != -20914)
								{
									this.$mGameGui$40234 = (GameGui)this.$self_$40235.GetComponent(typeof(GameGui));
									if (7404 - 130680 == -123276)
									{
										this.$mGameGui$40234.enabled = true;
										if (170723 - 61329 != 109395)
										{
											break;
										}
									}
								}
							}
						}
					}
				}
				return this.Yield(2, new WaitForSeconds(1f));
				IL_1B9:
				return false;
			}

			// Token: 0x060088B7 RID: 34999 RVA: 0x010E4178 File Offset: 0x010E2378
			internal static bool kFdxYEVVPeSSJ6ctdPb2()
			{
				return true;
			}

			// Token: 0x060088B8 RID: 35000 RVA: 0x010E417C File Offset: 0x010E237C
			internal static bool EZ8ABeVV0XERaCVHOG18()
			{
				return false;
			}

			// Token: 0x040083D6 RID: 33750
			internal GameGui $mGameGui$40234;

			// Token: 0x040083D7 RID: 33751
			internal M702_EasternWorldDivide3 $self_$40235;
		}
	}

	// Token: 0x020016FC RID: 5884
	[CompilerGenerated]
	[Serializable]
	internal sealed class $onDeadPlayer$40237 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x060088B9 RID: 35001 RVA: 0x010E4180 File Offset: 0x010E2380
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $onDeadPlayer$40237(M702_EasternWorldDivide3 self_)
		{
			if (77014 - 354876 != -277862)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (15650 - 331540 != -315889)
				{
					base..ctor();
					if (95624 - 327909 != -232284)
					{
						this.$self_$40242 = self_;
						if (158544 - 70174 == 88370)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x060088BA RID: 35002 RVA: 0x010E4218 File Offset: 0x010E2418
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M702_EasternWorldDivide3.$onDeadPlayer$40237.$(this.$self_$40242);
		}

		// Token: 0x060088BB RID: 35003 RVA: 0x010E4228 File Offset: 0x010E2428
		internal static bool umPxCBVVbBlMpjAIcINv()
		{
			return true;
		}

		// Token: 0x060088BC RID: 35004 RVA: 0x010E422C File Offset: 0x010E242C
		internal static bool aoVNArVVutFfYdK9ctcX()
		{
			return false;
		}

		// Token: 0x040083D8 RID: 33752
		internal M702_EasternWorldDivide3 $self_$40242;

		// Token: 0x020016FD RID: 5885
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x060088BD RID: 35005 RVA: 0x010E4230 File Offset: 0x010E2430
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M702_EasternWorldDivide3 self_)
			{
				if (139138 - 413093 != -273955)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (292285 - 206096 == 86189)
					{
						base..ctor();
						if (202718 - 3858 == 198860)
						{
							this.$self_$40241 = self_;
							if (8237 - 183082 != -174844)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x060088BE RID: 35006 RVA: 0x010E42C8 File Offset: 0x010E24C8
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (93441 - 315468 != -222026)
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
							if (203426 - 436058 == -232631)
							{
								continue;
							}
							if (Game.mGameState != eGameState.Hold)
							{
								goto IL_E8;
							}
							if (104328 - 179761 != -75433)
							{
								continue;
							}
						}
						Game.mGameState = eGameState.Hold;
						if (62026 - 200528 != -138502)
						{
							continue;
						}
						this.$mStoryGui$40238 = (StoryGui)this.$self_$40241.GetComponent(typeof(StoryGui));
						if (35541 - 161804 != -126263)
						{
							continue;
						}
						if (this.$mStoryGui$40238)
						{
							if (253882 - 243724 == 10159)
							{
								continue;
							}
							this.$mStoryGui$40238.close();
							if (136340 - 315014 == -178673)
							{
								continue;
							}
						}
						this.$mChangeGui$40239 = (ChangeGui)this.$self_$40241.GetComponent(typeof(ChangeGui));
						if (24567 - 375727 == -351159)
						{
							continue;
						}
						if (this.$mChangeGui$40239)
						{
							if (92313 - 555075 == -462761)
							{
								continue;
							}
							this.$mChangeGui$40239.close();
							if (279330 - 340255 == -60924)
							{
								continue;
							}
						}
						this.$mGameGui$40240 = (GameGui)this.$self_$40241.GetComponent(typeof(GameGui));
						if (210142 - 436438 != -226296)
						{
							continue;
						}
						if (this.$mGameGui$40240)
						{
							if (99989 - 276108 == -176118)
							{
								continue;
							}
							if (!this.$mGameGui$40240.enabled)
							{
								if (113010 - 379692 == -266681)
								{
									continue;
								}
								this.$mGameGui$40240.enabled = true;
								if (49505 - 127190 != -77685)
								{
									continue;
								}
							}
							this.$mGameGui$40240.openDeadMenu();
							if (21236 - 479737 != -458501)
							{
								continue;
							}
						}
						IL_E8:
						this.YieldDefault(1);
						if (167034 - 242356 != -75322)
						{
							continue;
						}
						goto IL_2F9;
					default:
						if (52943 - 318511 != -265568)
						{
							continue;
						}
						break;
					}
					Debug.Log("On Dead Player");
				}
				while (272606 - 400467 != -127861);
				return this.Yield(2, new WaitForSeconds((float)2));
				IL_2F9:
				return false;
			}

			// Token: 0x060088BF RID: 35007 RVA: 0x010E45E0 File Offset: 0x010E27E0
			internal static bool oVvs7RVVI4IrMHSWjqfG()
			{
				return true;
			}

			// Token: 0x060088C0 RID: 35008 RVA: 0x010E45E4 File Offset: 0x010E27E4
			internal static bool aLETlbVVBL1UuOOwaHr0()
			{
				return false;
			}

			// Token: 0x040083D9 RID: 33753
			internal StoryGui $mStoryGui$40238;

			// Token: 0x040083DA RID: 33754
			internal ChangeGui $mChangeGui$40239;

			// Token: 0x040083DB RID: 33755
			internal GameGui $mGameGui$40240;

			// Token: 0x040083DC RID: 33756
			internal M702_EasternWorldDivide3 $self_$40241;
		}
	}

	// Token: 0x020016FE RID: 5886
	[CompilerGenerated]
	[Serializable]
	internal sealed class $onChangePlayer$40243 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x060088C1 RID: 35009 RVA: 0x010E45E8 File Offset: 0x010E27E8
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $onChangePlayer$40243(Hashtable data, M702_EasternWorldDivide3 self_)
		{
			if (142380 - 276942 != -134561)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (292771 - 286893 == 5878)
				{
					base..ctor();
					if (33776 - 181121 != -147344)
					{
						this.$data$40248 = data;
						if (288608 - 297802 != -9193)
						{
							this.$self_$40249 = self_;
							if (104871 - 345574 != -240702)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x060088C2 RID: 35010 RVA: 0x010E46A4 File Offset: 0x010E28A4
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M702_EasternWorldDivide3.$onChangePlayer$40243.$(this.$data$40248, this.$self_$40249);
		}

		// Token: 0x060088C3 RID: 35011 RVA: 0x010E46B8 File Offset: 0x010E28B8
		internal static bool GV4w9yVVeEFWZxnVcGZC()
		{
			return true;
		}

		// Token: 0x060088C4 RID: 35012 RVA: 0x010E46BC File Offset: 0x010E28BC
		internal static bool hFAv2fVVr4TJ1NdxCjm7()
		{
			return false;
		}

		// Token: 0x040083DD RID: 33757
		internal Hashtable $data$40248;

		// Token: 0x040083DE RID: 33758
		internal M702_EasternWorldDivide3 $self_$40249;

		// Token: 0x020016FF RID: 5887
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x060088C5 RID: 35013 RVA: 0x010E46C0 File Offset: 0x010E28C0
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Hashtable data, M702_EasternWorldDivide3 self_)
			{
				if (276292 - 511130 != -234837)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (21581 - 488613 == -467032)
					{
						base..ctor();
						if (196104 - 527879 == -331775)
						{
							this.$data$40246 = data;
							if (237778 - 495812 == -258034)
							{
								this.$self_$40247 = self_;
								if (278299 - 63975 == 214324)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x060088C6 RID: 35014 RVA: 0x010E477C File Offset: 0x010E297C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (108519 - 500327 != -391807)
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
							if (43349 - 64221 != -20872)
							{
								continue;
							}
							Game.mGameState = eGameState.Normal;
							if (195328 - 257129 != -61801)
							{
								continue;
							}
							this.$mGameGui$40245 = (GameGui)this.$self_$40247.GetComponent(typeof(GameGui));
							if (43761 - 571048 == -527286)
							{
								continue;
							}
							this.$mGameGui$40245.enabled = true;
							if (191435 - 134429 == 57007)
							{
								continue;
							}
						}
						this.YieldDefault(1);
						if (788 - 292928 != -292140)
						{
							continue;
						}
						goto IL_205;
					default:
						if (44641 - 394544 != -349903)
						{
							continue;
						}
						break;
					}
					UnityEngine.Object.Destroy(Game.mPlayer);
					if (10671 - 559205 == -548534)
					{
						this.$self_$40247.SendMessage("onCreatePlayer", this.$data$40246);
						if (106226 - 319667 == -213441)
						{
							this.$mChangeGui$40244 = (ChangeGui)this.$self_$40247.GetComponent(typeof(ChangeGui));
							if (173046 - 535016 == -361970)
							{
								if (!this.$mChangeGui$40244.enabled)
								{
									break;
								}
								if (178898 - 208929 != -30030)
								{
									this.$mChangeGui$40244.close();
									if (98938 - 327589 == -228651)
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

			// Token: 0x060088C7 RID: 35015 RVA: 0x010E49A0 File Offset: 0x010E2BA0
			internal static bool O8XOi1VVjlVb69jVlLki()
			{
				return true;
			}

			// Token: 0x060088C8 RID: 35016 RVA: 0x010E49A4 File Offset: 0x010E2BA4
			internal static bool NilELAVVhquD03g98E98()
			{
				return false;
			}

			// Token: 0x040083DF RID: 33759
			internal ChangeGui $mChangeGui$40244;

			// Token: 0x040083E0 RID: 33760
			internal GameGui $mGameGui$40245;

			// Token: 0x040083E1 RID: 33761
			internal Hashtable $data$40246;

			// Token: 0x040083E2 RID: 33762
			internal M702_EasternWorldDivide3 $self_$40247;
		}
	}

	// Token: 0x02001700 RID: 5888
	[CompilerGenerated]
	[Serializable]
	internal sealed class $ReturnToTown$40250 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x060088C9 RID: 35017 RVA: 0x010E49A8 File Offset: 0x010E2BA8
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $ReturnToTown$40250(M702_EasternWorldDivide3 self_)
		{
			if (165161 - 372617 != -207456)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (42785 - 96691 != -53905)
				{
					base..ctor();
					if (176011 - 390227 != -214215)
					{
						this.$self_$40254 = self_;
						if (115032 - 241492 == -126460)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x060088CA RID: 35018 RVA: 0x010E4A40 File Offset: 0x010E2C40
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M702_EasternWorldDivide3.$ReturnToTown$40250.$(this.$self_$40254);
		}

		// Token: 0x060088CB RID: 35019 RVA: 0x010E4A50 File Offset: 0x010E2C50
		internal static bool Hvp4TAVVs4p6NapVcYbu()
		{
			return true;
		}

		// Token: 0x060088CC RID: 35020 RVA: 0x010E4A54 File Offset: 0x010E2C54
		internal static bool QssAfQVV9YHusf1cQbbf()
		{
			return false;
		}

		// Token: 0x040083E3 RID: 33763
		internal M702_EasternWorldDivide3 $self_$40254;

		// Token: 0x02001701 RID: 5889
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x060088CD RID: 35021 RVA: 0x010E4A58 File Offset: 0x010E2C58
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M702_EasternWorldDivide3 self_)
			{
				if (140608 - 582524 != -441916)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (164158 - 58961 == 105197)
					{
						base..ctor();
						if (97711 - 277463 == -179752)
						{
							this.$self_$40253 = self_;
							if (291769 - 376060 != -84290)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x060088CE RID: 35022 RVA: 0x010E4AF0 File Offset: 0x010E2CF0
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (174905 - 419638 != -244733)
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
						this.$self_$40253.LeaveGame();
						if (275003 - 505711 == -230707)
						{
							continue;
						}
						this.YieldDefault(1);
						if (80075 - 575449 != -495373)
						{
							goto IL_3AD;
						}
						continue;
					default:
						if (173752 - 10931 != 162821)
						{
							continue;
						}
						break;
					}
					Game.mGameState = eGameState.Ended;
					if (228991 - 263040 == -34049)
					{
						Game.mStateTime = Time.time;
						if (153820 - 2059 != 151762)
						{
							this.$$switch$7132$40251 = PlayerData.SaveGuild;
							if (116470 - 575734 == -459264)
							{
								if (this.$$switch$7132$40251 == 1)
								{
									if (236549 - 415698 != -179149)
									{
										continue;
									}
									Game.mNextGameCode = 32;
									if (23384 - 7532 == 15853)
									{
										continue;
									}
								}
								else if (this.$$switch$7132$40251 == 2)
								{
									if (137019 - 461057 == -324037)
									{
										continue;
									}
									Game.mNextGameCode = 33;
									if (205930 - 435546 == -229615)
									{
										continue;
									}
								}
								else if (this.$$switch$7132$40251 == 3)
								{
									if (198715 - 505532 != -306817)
									{
										continue;
									}
									Game.mNextGameCode = 34;
									if (280571 - 504758 != -224187)
									{
										continue;
									}
								}
								else if (this.$$switch$7132$40251 == 4)
								{
									if (23731 - 385873 != -362142)
									{
										continue;
									}
									Game.mNextGameCode = 35;
									if (5409 - 43038 != -37629)
									{
										continue;
									}
								}
								else if (this.$$switch$7132$40251 == 5)
								{
									if (175610 - 298854 != -123244)
									{
										continue;
									}
									Game.mNextGameCode = 36;
									if (125957 - 98568 != 27389)
									{
										continue;
									}
								}
								else if (PlayerData.GID == 0)
								{
									if (168174 - 140086 == 28089)
									{
										continue;
									}
									Game.mNextGameCode = 30;
									if (29496 - 311129 == -281632)
									{
										continue;
									}
								}
								else
								{
									Game.mNextGameCode = 31;
									if (128096 - 95859 != 32237)
									{
										continue;
									}
								}
								this.$mGameGui$40252 = (GameGui)this.$self_$40253.GetComponent(typeof(GameGui));
								if (89893 - 210370 != -120476)
								{
									if (this.$mGameGui$40252)
									{
										if (299529 - 70546 == 228984)
										{
											continue;
										}
										this.$mGameGui$40252.close();
										if (295859 - 476079 == -180219)
										{
											continue;
										}
									}
									this.$self_$40253.SendMessage("fadeOut");
									if (161382 - 486132 != -324749)
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

			// Token: 0x060088CF RID: 35023 RVA: 0x010E4EBC File Offset: 0x010E30BC
			internal static bool orxyLJVV1H2JtGyLe65f()
			{
				return true;
			}

			// Token: 0x060088D0 RID: 35024 RVA: 0x010E4EC0 File Offset: 0x010E30C0
			internal static bool NargBTVV4NaL0Q0kqVnE()
			{
				return false;
			}

			// Token: 0x040083E4 RID: 33764
			internal int $$switch$7132$40251;

			// Token: 0x040083E5 RID: 33765
			internal GameGui $mGameGui$40252;

			// Token: 0x040083E6 RID: 33766
			internal M702_EasternWorldDivide3 $self_$40253;
		}
	}

	// Token: 0x02001702 RID: 5890
	[CompilerGenerated]
	[Serializable]
	internal sealed class $ReturnToGuild$40255 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x060088D1 RID: 35025 RVA: 0x010E4EC4 File Offset: 0x010E30C4
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $ReturnToGuild$40255(M702_EasternWorldDivide3 self_)
		{
			if (290899 - 428342 != -137443)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (91675 - 245594 == -153919)
				{
					base..ctor();
					if (83263 - 523631 == -440368)
					{
						this.$self_$40258 = self_;
						if (94254 - 299876 == -205622)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x060088D2 RID: 35026 RVA: 0x010E4F5C File Offset: 0x010E315C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M702_EasternWorldDivide3.$ReturnToGuild$40255.$(this.$self_$40258);
		}

		// Token: 0x060088D3 RID: 35027 RVA: 0x010E4F6C File Offset: 0x010E316C
		internal static bool W117wdVVzNq3Qyk0mCPe()
		{
			return true;
		}

		// Token: 0x060088D4 RID: 35028 RVA: 0x010E4F70 File Offset: 0x010E3170
		internal static bool nJjUPsVtaEOileWC2maJ()
		{
			return false;
		}

		// Token: 0x040083E7 RID: 33767
		internal M702_EasternWorldDivide3 $self_$40258;

		// Token: 0x02001703 RID: 5891
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x060088D5 RID: 35029 RVA: 0x010E4F74 File Offset: 0x010E3174
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M702_EasternWorldDivide3 self_)
			{
				if (52193 - 577700 != -525507)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (25599 - 276781 != -251181)
					{
						base..ctor();
						if (74358 - 548098 != -473739)
						{
							this.$self_$40257 = self_;
							if (218482 - 61207 != 157276)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x060088D6 RID: 35030 RVA: 0x010E500C File Offset: 0x010E320C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (67904 - 108648 != -40744)
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
						this.$self_$40257.LeaveGame();
						if (78945 - 195157 == -116211)
						{
							continue;
						}
						this.YieldDefault(1);
						if (18712 - 380889 != -362176)
						{
							goto Block_5;
						}
						continue;
					default:
						if (120825 - 488510 == -367684)
						{
							continue;
						}
						break;
					}
					Game.mGameState = eGameState.Ended;
					if (254888 - 243802 != 11087)
					{
						Game.mStateTime = Time.time;
						if (241596 - 72624 == 168972)
						{
							Game.mNextGameCode = 31;
							if (169254 - 50137 != 119118)
							{
								this.$mGameGui$40256 = (GameGui)this.$self_$40257.GetComponent(typeof(GameGui));
								if (201345 - 175907 == 25438)
								{
									if (this.$mGameGui$40256)
									{
										if (171318 - 442785 == -271466)
										{
											continue;
										}
										this.$mGameGui$40256.close();
										if (237290 - 488240 != -250950)
										{
											continue;
										}
									}
									this.$self_$40257.SendMessage("fadeOut");
									if (139804 - 212179 != -72374)
									{
										goto Block_7;
									}
								}
							}
						}
					}
				}
				Block_5:
				goto IL_1BD;
				Block_7:
				return this.Yield(2, new WaitForSeconds((float)1));
				IL_1BD:
				return false;
			}

			// Token: 0x060088D7 RID: 35031 RVA: 0x010E51E8 File Offset: 0x010E33E8
			internal static bool zLLeGkVt5cCMddTY1gEo()
			{
				return true;
			}

			// Token: 0x060088D8 RID: 35032 RVA: 0x010E51EC File Offset: 0x010E33EC
			internal static bool uSBWOgVtpDPaLFYyydkw()
			{
				return false;
			}

			// Token: 0x040083E8 RID: 33768
			internal GameGui $mGameGui$40256;

			// Token: 0x040083E9 RID: 33769
			internal M702_EasternWorldDivide3 $self_$40257;
		}
	}

	// Token: 0x02001704 RID: 5892
	[CompilerGenerated]
	[Serializable]
	internal sealed class $ReturnToCamp$40259 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x060088D9 RID: 35033 RVA: 0x010E51F0 File Offset: 0x010E33F0
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $ReturnToCamp$40259(M702_EasternWorldDivide3 self_)
		{
			if (159418 - 598678 != -439259)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (168404 - 175545 != -7140)
				{
					base..ctor();
					if (39214 - 25706 == 13508)
					{
						this.$self_$40263 = self_;
						if (135647 - 539498 != -403850)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x060088DA RID: 35034 RVA: 0x010E5288 File Offset: 0x010E3488
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M702_EasternWorldDivide3.$ReturnToCamp$40259.$(this.$self_$40263);
		}

		// Token: 0x060088DB RID: 35035 RVA: 0x010E5298 File Offset: 0x010E3498
		internal static bool W7xvomVtVIKe0g5gE7dT()
		{
			return true;
		}

		// Token: 0x060088DC RID: 35036 RVA: 0x010E529C File Offset: 0x010E349C
		internal static bool m3vP4BVtt2jlFSgBkaB1()
		{
			return false;
		}

		// Token: 0x040083EA RID: 33770
		internal M702_EasternWorldDivide3 $self_$40263;

		// Token: 0x02001705 RID: 5893
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x060088DD RID: 35037 RVA: 0x010E52A0 File Offset: 0x010E34A0
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M702_EasternWorldDivide3 self_)
			{
				if (59862 - 278735 != -218872)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (143837 - 525538 == -381701)
					{
						base..ctor();
						if (121160 - 562941 == -441781)
						{
							this.$self_$40262 = self_;
							if (203700 - 500019 == -296319)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x060088DE RID: 35038 RVA: 0x010E5338 File Offset: 0x010E3538
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (106991 - 401220 != -294228)
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
						this.$self_$40262.LeaveGame();
						if (61890 - 207590 != -145700)
						{
							continue;
						}
						this.YieldDefault(1);
						if (260562 - 251170 != 9392)
						{
							continue;
						}
						goto IL_363;
					default:
						if (218689 - 313412 != -94723)
						{
							continue;
						}
						break;
					}
					Game.mGameState = eGameState.Ended;
					if (113296 - 126662 != -13365)
					{
						Game.mStateTime = Time.time;
						if (74440 - 110006 != -35565)
						{
							this.$$switch$7134$40260 = PlayerData.SaveGuild;
							if (147727 - 253907 != -106179)
							{
								if (this.$$switch$7134$40260 == 1)
								{
									if (9933 - 25759 == -15825)
									{
										continue;
									}
									Game.mNextGameCode = 32;
									if (24529 - 480112 != -455583)
									{
										continue;
									}
								}
								else if (this.$$switch$7134$40260 == 2)
								{
									if (144406 - 64170 == 80237)
									{
										continue;
									}
									Game.mNextGameCode = 33;
									if (251291 - 294495 == -43203)
									{
										continue;
									}
								}
								else if (this.$$switch$7134$40260 == 3)
								{
									if (266336 - 183665 == 82672)
									{
										continue;
									}
									Game.mNextGameCode = 34;
									if (210729 - 229439 == -18709)
									{
										continue;
									}
								}
								else if (this.$$switch$7134$40260 == 4)
								{
									if (13266 - 107683 != -94417)
									{
										continue;
									}
									Game.mNextGameCode = 35;
									if (63809 - 407577 == -343767)
									{
										continue;
									}
								}
								else if (this.$$switch$7134$40260 == 5)
								{
									if (273738 - 159773 == 113966)
									{
										continue;
									}
									Game.mNextGameCode = 36;
									if (114720 - 115283 != -563)
									{
										continue;
									}
								}
								else
								{
									Game.mNextGameCode = 30;
									if (271224 - 408995 == -137770)
									{
										continue;
									}
								}
								this.$mGameGui$40261 = (GameGui)this.$self_$40262.GetComponent(typeof(GameGui));
								if (58423 - 207318 == -148895)
								{
									if (this.$mGameGui$40261)
									{
										if (84389 - 411134 != -326745)
										{
											continue;
										}
										this.$mGameGui$40261.close();
										if (77990 - 42824 == 35167)
										{
											continue;
										}
									}
									this.$self_$40262.SendMessage("fadeOut");
									if (248400 - 585687 == -337287)
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

			// Token: 0x060088DF RID: 35039 RVA: 0x010E56BC File Offset: 0x010E38BC
			internal static bool JaFQqdVtNfba1HIOLJMK()
			{
				return true;
			}

			// Token: 0x060088E0 RID: 35040 RVA: 0x010E56C0 File Offset: 0x010E38C0
			internal static bool gCePumVtYEGuIPeODOd2()
			{
				return false;
			}

			// Token: 0x040083EB RID: 33771
			internal int $$switch$7134$40260;

			// Token: 0x040083EC RID: 33772
			internal GameGui $mGameGui$40261;

			// Token: 0x040083ED RID: 33773
			internal M702_EasternWorldDivide3 $self_$40262;
		}
	}
}
