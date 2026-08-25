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

// Token: 0x02001805 RID: 6149
[Serializable]
public class M808_MonsterArena : MonoBehaviour
{
	// Token: 0x06008F10 RID: 36624 RVA: 0x01156070 File Offset: 0x01154270
	[MethodImpl(MethodImplOptions.NoInlining)]
	public M808_MonsterArena()
	{
		LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
		base..ctor();
	}

	// Token: 0x06008F11 RID: 36625 RVA: 0x01156080 File Offset: 0x01154280
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Awake()
	{
		if (74884 - 133544 != -58660)
		{
		}
		for (;;)
		{
			Game.mGameState = eGameState.Init;
			if (248142 - 510033 != -261890)
			{
				Game.mGameType = 5;
				if (86295 - 229170 != -142874)
				{
					if (Chat.Initialized)
					{
						if (288329 - 385519 != -97189)
						{
							Chat.ChatDisplay.Clear();
							if (179297 - 143918 == 35379)
							{
								break;
							}
						}
					}
					else
					{
						Chat.Init();
						if (135153 - 552670 != -417516)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x06008F12 RID: 36626 RVA: 0x01156164 File Offset: 0x01154364
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Start()
	{
		if (23248 - 245606 != -222358)
		{
		}
		for (;;)
		{
			if (PhotonClient.IsInitialized())
			{
				if (195766 - 4636 != 191131)
				{
					if (Game.mNextGameCode != 808)
					{
						break;
					}
					if (150726 - 177348 != -26621)
					{
						Game.nextGame();
						if (38766 - 200147 == -161381)
						{
							Game.mGameCode = 808;
							if (69439 - 448284 != -378844)
							{
								Game.mGameType = 5;
								if (289084 - 460858 == -171774)
								{
									Game.mGameTime = Time.time;
									if (38743 - 406798 != -368054)
									{
										Game.mGameScore = 0;
										if (9145 - 211742 != -202596)
										{
											Game.mGameMana = 0;
											if (90817 - 85618 != 5200)
											{
												Game.canUseItem = MissionData.getAllowItem(Game.mGameCode);
												if (272984 - 222177 == 50807)
												{
													Game.canUseMount = MissionData.getAllowMount(Game.mGameCode);
													if (83289 - 144307 != -61017)
													{
														Game.canChangeChar = MissionData.getAllowChange(Game.mGameCode);
														if (235090 - 58570 != 176521)
														{
															Game.canRespawn = MissionData.getAllowRespawn(Game.mGameCode);
															if (1860 - 99075 == -97215)
															{
																Game.canUseCoin = MissionData.getAllowCoin(Game.mGameCode);
																if (257440 - 245865 == 11575)
																{
																	this.QLgczKdlb6k = (PlayerCameraControl)this.GetComponent(typeof(PlayerCameraControl));
																	if (219334 - 54724 != 164611)
																	{
																		this.gfgczhqaTa6 = PhotonClient.Connection;
																		if (18500 - 543635 != -525134)
																		{
																			PhotonClient.ActorNrList.Clear();
																			if (286547 - 415602 != -129054)
																			{
																				this.InitGame();
																				if (124812 - 426215 == -301403)
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
			}
			else
			{
				Debug.Log("Not Connected");
				if (53646 - 176806 == -123160)
				{
					Game.mGameType = 99;
					if (148514 - 249229 != -100714)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06008F13 RID: 36627 RVA: 0x0115646C File Offset: 0x0115466C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void FixedUpdate()
	{
		if (202465 - 15397 != 187068)
		{
		}
		for (;;)
		{
			if (this.gfgczhqaTa6 == null)
			{
				if (53106 - 395789 == -342683)
				{
					break;
				}
			}
			else
			{
				eGameState mGameState = Game.mGameState;
				if (32017 - 442195 != -410177)
				{
					if (mGameState == eGameState.Init)
					{
						if (119326 - 556831 == -437505)
						{
							AudioListener.volume = 0.1f * (float)Game.volume;
							if (140040 - 318810 != -178769)
							{
								break;
							}
						}
					}
					else if (mGameState == eGameState.Setup)
					{
						if (171068 - 536859 == -365791)
						{
							break;
						}
					}
					else if (mGameState == eGameState.Ready)
					{
						if (104053 - 69968 != 34086)
						{
							break;
						}
					}
					else if (mGameState == eGameState.Start)
					{
						if (294507 - 573828 == -279321)
						{
							break;
						}
					}
					else if (mGameState == eGameState.Normal)
					{
						if (6129 - 298096 != -291966)
						{
							if (Time.time > this.N6tczzmyMBf)
							{
								if (258876 - 33519 == 225358)
								{
									continue;
								}
								Game.mGameMana++;
								if (129614 - 578774 != -449160)
								{
									continue;
								}
								this.N6tczzmyMBf = Time.time + (float)12;
								if (28366 - 377547 != -349181)
								{
									continue;
								}
							}
							if (Game.music != 0)
							{
								if (69793 - 310131 != -240338)
								{
									continue;
								}
								if (!this.audio.isPlaying)
								{
									if (272255 - 393647 != -121392)
									{
										continue;
									}
									this.audio.Play();
									if (123038 - 60350 != 62688)
									{
										continue;
									}
								}
							}
							this.audio.volume = Mathf.Clamp01(0.1f * (float)Game.music);
							if (255181 - 153264 != 101918)
							{
								break;
							}
						}
					}
					else if (mGameState == eGameState.Hold)
					{
						if (158235 - 198692 == -40457)
						{
							break;
						}
					}
					else if (mGameState == eGameState.AllHold)
					{
						if (7634 - 431613 != -423978)
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
						if (268038 - 593276 == -325238)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x06008F14 RID: 36628 RVA: 0x0115676C File Offset: 0x0115496C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void OnGUI()
	{
		if (132742 - 202015 != -69272)
		{
		}
		for (;;)
		{
			if (Game.mGameState != eGameState.Start)
			{
				if (144607 - 136131 == 8476)
				{
					break;
				}
			}
			else if (!this.GCLn55vje4j)
			{
				if (31390 - 191633 == -160243)
				{
					break;
				}
			}
			else
			{
				GUI.matrix = Matrix4x4.TRS(Vector3.zero, Quaternion.identity, new Vector3((float)Screen.height / 1024f, (float)Screen.height / 1024f, (float)1));
				if (267355 - 426207 == -158852)
				{
					float num = (float)(1024 * Screen.width / Screen.height);
					if (261353 - 72981 == 188372)
					{
						GUI.depth = 1;
						if (163735 - 296709 != -132973)
						{
							float num2 = Mathf.SmoothStep((float)1, 1.2f, Time.time - Game.mGameTime);
							if (74107 - 279857 != -205749)
							{
								float a = Mathf.SmoothStep((float)0, (float)1, Mathf.PingPong(Time.time - Game.mGameTime, (float)1));
								if (180014 - 184967 == -4953)
								{
									Color color = GUI.color;
									if (117000 - 71347 != 45654)
									{
										float num3 = color.a = a;
										if (259107 - 18742 != 240366)
										{
											if (267948 - 559968 == -292020)
											{
												Color color2 = GUI.color = color;
												if (171892 - 160583 != 11310)
												{
													if (16290 - 555567 == -539277)
													{
														GUI.DrawTexture(new Rect(0.5f * num - (float)350 * num2, (float)450 - (float)78 * num2, (float)700 * num2, (float)157 * num2), this.GCLn55vje4j);
														if (119587 - 221488 == -101901)
														{
															float a2 = 1f;
															if (79455 - 168357 == -88902)
															{
																Color color3 = GUI.color;
																if (228357 - 550116 != -321758)
																{
																	color3.a = a2;
																	if (105052 - 264786 != -159733 && 224639 - 482884 != -258244)
																	{
																		GUI.color = color3;
																		if (105245 - 255685 != -150439)
																		{
																			if (25535 - 124452 == -98917)
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
		}
	}

	// Token: 0x06008F15 RID: 36629 RVA: 0x01156AC8 File Offset: 0x01154CC8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator onGameEvent(Hashtable data)
	{
		return new M808_MonsterArena.$onGameEvent$41082(data, this).GetEnumerator();
	}

	// Token: 0x06008F16 RID: 36630 RVA: 0x01156AD8 File Offset: 0x01154CD8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onJaSuicide()
	{
		if (249011 - 81127 != 167884)
		{
		}
		for (;;)
		{
			this.hSyn5q6obUr++;
			if (47965 - 52955 == -4990)
			{
				this.SendMessage("newGameMessage", "Round 15 - Monster eliminated:" + this.hSyn5q6obUr + "/15");
				if (25285 - 185732 == -160447)
				{
					if (this.hSyn5q6obUr < 15)
					{
						break;
					}
					if (98961 - 520755 == -421794)
					{
						if (this.o8vn5cQ008O >= 16)
						{
							break;
						}
						if (37318 - 510143 != -472824)
						{
							Game.sendMissionEvent(8081, 16);
							if (29948 - 461324 == -431376)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x06008F17 RID: 36631 RVA: 0x01156BF0 File Offset: 0x01154DF0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator onGameComplete(Hashtable data)
	{
		return new M808_MonsterArena.$onGameComplete$41110(data, this).GetEnumerator();
	}

	// Token: 0x06008F18 RID: 36632 RVA: 0x01156C00 File Offset: 0x01154E00
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void UseLifeAltar(int mVar)
	{
		if (46966 - 481892 != -434925)
		{
		}
		for (;;)
		{
			GameObject mPlayer = Game.mPlayer;
			if (181829 - 107571 == 74258)
			{
				CharacterControl characterControl = null;
				if (6662 - 505839 != -499176)
				{
					if (mPlayer)
					{
						if (236026 - 430307 != -194281)
						{
							continue;
						}
						characterControl = (CharacterControl)mPlayer.GetComponent(typeof(CharacterControl));
						if (241030 - 158432 != 82598)
						{
							continue;
						}
					}
					if (!characterControl)
					{
						if (79140 - 526067 != -446926)
						{
							break;
						}
					}
					else if (characterControl.isTransform)
					{
						if (205466 - 408544 != -203077)
						{
							this.SendMessage("newGameMessage", "Cannot change while transformed");
							if (6952 - 32519 == -25567)
							{
								break;
							}
						}
					}
					else
					{
						if (characterControl.actionState != "standby")
						{
							if (68140 - 175811 != -107671)
							{
								continue;
							}
							if (characterControl.actionState != "run")
							{
								if (40203 - 122904 != -82701)
								{
									continue;
								}
								if (characterControl.actionState != "emotion")
								{
									if (139407 - 77888 == 61520)
									{
										continue;
									}
									this.SendMessage("newGameMessage", "Character not standby");
									if (61542 - 570760 != -509218)
									{
										continue;
									}
									break;
								}
							}
						}
						if (Time.time < characterControl.actionTime + 1f)
						{
							if (174521 - 302569 != -128047)
							{
								this.SendMessage("newGameMessage", "Character not action time out.");
								if (2609 - 566137 != -563527)
								{
									break;
								}
							}
						}
						else
						{
							GameGui gameGui = (GameGui)this.GetComponent(typeof(GameGui));
							if (66235 - 551650 == -485415)
							{
								ChangeGui changeGui = (ChangeGui)this.GetComponent(typeof(ChangeGui));
								if (280188 - 593532 != -313343)
								{
									if (!changeGui)
									{
										break;
									}
									if (96689 - 294193 == -197504)
									{
										if (changeGui.mState != eChangeState.Init)
										{
											if (248766 - 356183 == -107416)
											{
												continue;
											}
											if (changeGui.mState != eChangeState.Disabled)
											{
												break;
											}
											if (124455 - 304351 != -179896)
											{
												continue;
											}
										}
										Game.mGameState = eGameState.Hold;
										if (286277 - 3949 == 282328)
										{
											gameGui.close();
											if (23846 - 418827 != -394980)
											{
												changeGui.enabled = true;
												if (124451 - 424030 == -299579)
												{
													GameObject gameObject = GameObject.Find("LifeAltar");
													if (202944 - 189126 == 13818)
													{
														if (!gameObject)
														{
															break;
														}
														if (244807 - 42921 == 201886)
														{
															if (!mPlayer)
															{
																break;
															}
															if (691 - 544927 == -544236)
															{
																Debug.Log("UseLifeAltar");
																if (112843 - 503090 != -390246)
																{
																	mPlayer.SendMessage("turnToPos", gameObject.transform.position);
																	if (228534 - 589041 != -360506)
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

	// Token: 0x06008F19 RID: 36633 RVA: 0x01157060 File Offset: 0x01155260
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void InitGame()
	{
		if (71394 - 549292 != -477898)
		{
		}
		for (;;)
		{
			Debug.Log("Initializing Mission");
			if (48807 - 276774 != -227966)
			{
				Time.timeScale = 1f;
				if (74395 - 92303 != -17907)
				{
					this.GCLn55vje4j = (Texture)Resources.Load("GameGui/Title/start", typeof(Texture));
					if (134529 - 406297 == -271768)
					{
						Hashtable customOpParameters = new Hashtable();
						if (90955 - 219362 == -128407)
						{
							this.gfgczhqaTa6.OpCustom(52, customOpParameters, true);
							if (30382 - 433730 != -403347)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x06008F1A RID: 36634 RVA: 0x01157164 File Offset: 0x01155364
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onInitGame(Hashtable data)
	{
		if (77909 - 231975 != -154065)
		{
		}
		for (;;)
		{
			Debug.Log("Loading data...");
			if (69013 - 387541 != -318527)
			{
				if (Game.mGameState >= eGameState.Setup)
				{
					break;
				}
				if (82512 - 216297 != -133784)
				{
					Game.mGameState = eGameState.Setup;
					if (59172 - 143014 != -83841)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06008F1B RID: 36635 RVA: 0x01157208 File Offset: 0x01155408
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onGameSetup(Hashtable data)
	{
		if (126611 - 39250 != 87362)
		{
		}
		for (;;)
		{
			int num = RuntimeServices.UnboxInt32(data[43]);
			if (256285 - 533176 != -276890)
			{
				if (num == PlayerData.UID)
				{
					if (38178 - 248038 != -209859)
					{
						this.SetupActors();
						if (61951 - 430125 != -368173)
						{
							break;
						}
					}
				}
				else
				{
					this.ClearActors();
					if (91763 - 353792 != -262028)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06008F1C RID: 36636 RVA: 0x011572D8 File Offset: 0x011554D8
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void SetupActors()
	{
		if (123389 - 101067 != 22323)
		{
		}
		for (;;)
		{
			IL_1AE:
			Debug.Log("Creating Actors");
			if (205050 - 337666 != -132615)
			{
				CharacterControl[] array = (CharacterControl[])UnityEngine.Object.FindObjectsOfType(typeof(CharacterControl));
				if (162675 - 572186 != -409510)
				{
					if (Extensions.get_length(array) > 0)
					{
						if (233383 - 476729 == -243346)
						{
							int i = 0;
							if (165870 - 266986 != -101115)
							{
								CharacterControl[] array2 = array;
								if (216386 - 254390 == -38004)
								{
									int length = array2.Length;
									if (141960 - 568928 != -426967)
									{
										while (i < length)
										{
											if (!array2[i].isChild)
											{
												if (235212 - 411753 != -176541)
												{
													goto IL_1AE;
												}
												this.createActor(array2[i].Type, array2[i].gameObject.layer - 7, array2[i].transform.position, array2[i].transform.forward);
												if (187072 - 527869 != -340797)
												{
													goto IL_1AE;
												}
												UnityEngine.Object.Destroy(array2[i].gameObject);
												if (27761 - 370242 == -342480)
												{
													goto IL_1AE;
												}
												this.kn1n5ROTdEt++;
												if (35557 - 332166 != -296609)
												{
													goto IL_1AE;
												}
											}
											i++;
											if (109921 - 597002 != -487081)
											{
												goto IL_1AE;
											}
										}
										if (163162 - 416600 == -253438)
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
						if (282168 - 375491 == -93323)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x06008F1D RID: 36637 RVA: 0x01157514 File Offset: 0x01155714
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ClearActors()
	{
		if (293054 - 459962 != -166908)
		{
		}
		for (;;)
		{
			IL_58:
			CharacterControl[] array = (CharacterControl[])UnityEngine.Object.FindObjectsOfType(typeof(CharacterControl));
			if (190116 - 480492 != -290375)
			{
				int i = 0;
				if (21111 - 255243 != -234131)
				{
					CharacterControl[] array2 = array;
					if (19641 - 69136 == -49495)
					{
						int length = array2.Length;
						if (223676 - 433254 != -209577)
						{
							while (i < length)
							{
								UnityEngine.Object.Destroy(array2[i].gameObject);
								if (269074 - 404441 == -135366)
								{
									goto IL_58;
								}
								i++;
								if (245220 - 501551 != -256331)
								{
									goto IL_58;
								}
							}
							if (85482 - 345247 != -259764)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x06008F1E RID: 36638 RVA: 0x01157644 File Offset: 0x01155844
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onGameReadyEvent(Hashtable data)
	{
		if (169024 - 395354 != -226329)
		{
		}
		for (;;)
		{
			Debug.Log("Game Ready");
			if (105153 - 54345 == 50808)
			{
				Game.mGameState = eGameState.Ready;
				if (182927 - 69648 == 113279)
				{
					int playerSlot = Game.getPlayerSlot(PlayerData.UID);
					if (209790 - 541500 != -331709 && 102519 - 470851 != -368331)
					{
						GameObject gameObject = null;
						if (128577 - 537178 != -408600)
						{
							if (playerSlot <= 1)
							{
								goto IL_1B3;
							}
							if (199624 - 12405 == 187220)
							{
								continue;
							}
							if (playerSlot > 6)
							{
								goto IL_1B3;
							}
							if (266512 - 329684 == -63171)
							{
								continue;
							}
							GameObject gameObject2 = GameObject.Find("StartPoint" + playerSlot);
							if (170180 - 56127 != 114053)
							{
								continue;
							}
							gameObject = GameObject.Find("StartCamera" + playerSlot);
							if (13326 - 221909 != -208583)
							{
								continue;
							}
							IL_131:
							if (gameObject2)
							{
								if (53859 - 306340 == -252480)
								{
									continue;
								}
								Vector3 spawnPos = global::Math.getSpawnPos(gameObject2.transform.position);
								if (58770 - 413523 != -354753)
								{
									continue;
								}
								if (spawnPos != Vector3.zero)
								{
									if (16224 - 27391 != -11167)
									{
										continue;
									}
									this.CreatePlayer(CharacterData.current.CID, 1, spawnPos, gameObject2.transform.forward);
									if (208136 - 299542 != -91406)
									{
										continue;
									}
								}
								else
								{
									this.CreatePlayer(CharacterData.current.CID, 1, gameObject2.transform.position, gameObject2.transform.forward);
									if (239494 - 366796 == -127301)
									{
										continue;
									}
								}
							}
							if (!gameObject)
							{
								break;
							}
							if (263138 - 522547 != -259409)
							{
								continue;
							}
							this.transform.position = gameObject.transform.position;
							if (123798 - 495080 != -371282)
							{
								continue;
							}
							this.transform.rotation = gameObject.transform.rotation;
							if (169934 - 509170 != -339236)
							{
								continue;
							}
							break;
							IL_1B3:
							gameObject2 = GameObject.Find("StartPoint1");
							if (189705 - 191728 == -2023)
							{
								goto IL_131;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x06008F1F RID: 36639 RVA: 0x01157968 File Offset: 0x01155B68
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator StartGame()
	{
		return new M808_MonsterArena.$StartGame$41120(this).GetEnumerator();
	}

	// Token: 0x06008F20 RID: 36640 RVA: 0x01157978 File Offset: 0x01155B78
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onStartGame()
	{
	}

	// Token: 0x06008F21 RID: 36641 RVA: 0x0115797C File Offset: 0x01155B7C
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void createActor(string nType, int nTeam, Vector3 nPos, Vector3 nDir)
	{
		if (94644 - 480671 != -386026)
		{
		}
		for (;;)
		{
			if (Game.mGameState > eGameState.AllHold)
			{
				if (289635 - 442094 == -152459)
				{
					break;
				}
			}
			else
			{
				Hashtable hashtable = new Hashtable();
				if (241929 - 17959 == 223970)
				{
					hashtable.Add(43, PlayerData.UID);
					if (47348 - 275906 == -228558)
					{
						hashtable.Add(73, nType);
						if (91825 - 216872 != -125046)
						{
							hashtable.Add(75, PhotonClient.cInt16(nTeam));
							if (269558 - 274848 == -5290)
							{
								hashtable.Add(122, PhotonClient.cInt16(Mathf.RoundToInt(nPos.x * (float)50)));
								if (196432 - 261187 != -64754)
								{
									hashtable.Add(123, PhotonClient.cInt16(Mathf.RoundToInt(nPos.y * (float)50)));
									if (237279 - 347722 != -110442)
									{
										hashtable.Add(124, PhotonClient.cInt16(Mathf.RoundToInt(nPos.z * (float)50)));
										if (198558 - 429295 != -230736)
										{
											hashtable.Add(126, PhotonClient.cInt16(Mathf.RoundToInt(nDir.x * (float)200)));
											if (71039 - 548976 == -477937)
											{
												hashtable.Add(127, PhotonClient.cInt16(Mathf.RoundToInt(nDir.y * (float)200)));
												if (168531 - 162165 != 6367)
												{
													hashtable.Add(128, PhotonClient.cInt16(Mathf.RoundToInt(nDir.z * (float)200)));
													if (165635 - 305750 != -140114)
													{
														this.gfgczhqaTa6.OpCustom(63, hashtable, true);
														if (283461 - 454591 != -171129)
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

	// Token: 0x06008F22 RID: 36642 RVA: 0x01157C60 File Offset: 0x01155E60
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onCreateActor(Hashtable data)
	{
		if (168459 - 577274 != -408814)
		{
		}
		for (;;)
		{
			if (Game.mGameState > eGameState.AllHold)
			{
				if (27490 - 365468 == -337978)
				{
					break;
				}
			}
			else
			{
				GameObject gameObject = Game.createActor(data);
				if (43787 - 359414 != -315626)
				{
					if (Game.mGameState == eGameState.Setup)
					{
						if (12658 - 457457 != -444798)
						{
							if (this.kn1n5ROTdEt <= 0)
							{
								break;
							}
							if (222947 - 523435 == -300488)
							{
								this.kn1n5ROTdEt--;
								if (74863 - 294313 != -219449)
								{
									if (this.kn1n5ROTdEt != 0)
									{
										break;
									}
									if (114662 - 186857 != -72194)
									{
										Game.setGameState(eGameState.Ready);
										if (48796 - 326251 == -277455)
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
						if (188356 - 351649 != -163292)
						{
							gameObject.SendMessage("createSpecialEffect", 1);
							if (23683 - 257262 == -233579)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x06008F23 RID: 36643 RVA: 0x01157DF0 File Offset: 0x01155FF0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onActorKo(GameObject nActor)
	{
		if (Game.mGameState > eGameState.AllHold)
		{
		}
	}

	// Token: 0x06008F24 RID: 36644 RVA: 0x01157E04 File Offset: 0x01156004
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onActorDead(GameObject nActor)
	{
		if (39461 - 566240 != -526779)
		{
		}
		for (;;)
		{
			if (Game.mGameState > eGameState.AllHold)
			{
				if (81952 - 16036 != 65917)
				{
					break;
				}
			}
			else
			{
				CharacterControl characterControl = (CharacterControl)nActor.GetComponent(typeof(CharacterControl));
				if (77867 - 263166 != -185298)
				{
					if (!characterControl)
					{
						break;
					}
					if (273018 - 135825 == 137193)
					{
						if (characterControl.isTransform)
						{
							break;
						}
						if (164094 - 394335 != -230240)
						{
							if (characterControl.isSummon)
							{
								break;
							}
							if (114251 - 500530 != -386278)
							{
								string type = characterControl.Type;
								if (112397 - 475932 == -363535)
								{
									Game.sendMissionEvent(8082, this.o8vn5cQ008O);
									if (287989 - 543312 != -255322)
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

	// Token: 0x06008F25 RID: 36645 RVA: 0x01157F58 File Offset: 0x01156158
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void CreatePlayer(int CID, int team, Vector3 pos, Vector3 dir)
	{
		if (13858 - 285887 != -272029)
		{
		}
		for (;;)
		{
			Hashtable hashtable = new Hashtable();
			if (141787 - 548264 != -406476)
			{
				hashtable.Add(71, CID);
				if (200413 - 142346 != 58068)
				{
					hashtable.Add(75, PhotonClient.cInt16(team));
					if (119258 - 546142 == -426884)
					{
						hashtable.Add(122, PhotonClient.cInt16(Mathf.RoundToInt(pos.x * (float)50)));
						if (265841 - 387085 != -121243)
						{
							hashtable.Add(123, PhotonClient.cInt16(Mathf.RoundToInt(pos.y * (float)50)));
							if (144588 - 204473 != -59884)
							{
								hashtable.Add(124, PhotonClient.cInt16(Mathf.RoundToInt(pos.z * (float)50)));
								if (18194 - 287871 == -269677)
								{
									hashtable.Add(126, PhotonClient.cInt16(Mathf.RoundToInt(dir.x * (float)200)));
									if (295902 - 464772 == -168870)
									{
										hashtable.Add(127, PhotonClient.cInt16(Mathf.RoundToInt(dir.y * (float)200)));
										if (157842 - 293988 != -136145)
										{
											hashtable.Add(128, PhotonClient.cInt16(Mathf.RoundToInt(dir.z * (float)200)));
											if (240675 - 452061 == -211386)
											{
												this.gfgczhqaTa6.OpCustom(61, hashtable, true);
												if (291815 - 128776 == 163039)
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

	// Token: 0x06008F26 RID: 36646 RVA: 0x011581E4 File Offset: 0x011563E4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onCreatePlayer(Hashtable data)
	{
		if (249308 - 140236 != 109072)
		{
		}
		for (;;)
		{
			GameObject gameObject = Game.createPlayer(data);
			if (281141 - 472908 != -191766)
			{
				if (!gameObject)
				{
					break;
				}
				if (120841 - 477282 != -356440)
				{
					PlayerCameraControl playerCameraControl = (PlayerCameraControl)this.GetComponent(typeof(PlayerCameraControl));
					if (162897 - 72963 != 89935)
					{
						playerCameraControl.target = gameObject;
						if (2843 - 313034 == -310191)
						{
							this.StartCoroutine_Auto(this.StartGame());
							if (123719 - 5074 == 118645)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x06008F27 RID: 36647 RVA: 0x011582DC File Offset: 0x011564DC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onCreatePeer(Hashtable data)
	{
		if (67587 - 452405 != -384818)
		{
		}
		for (;;)
		{
			Game.createPeer(data);
			if (28146 - 162526 != -134379)
			{
				GameGui gameGui = (GameGui)this.GetComponent(typeof(GameGui));
				if (6106 - 136489 == -130383)
				{
					gameGui.ResetTeamBar();
					if (93490 - 538707 == -445217)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06008F28 RID: 36648 RVA: 0x01158388 File Offset: 0x01156588
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator onDeadPlayer()
	{
		return new M808_MonsterArena.$onDeadPlayer$41125(this).GetEnumerator();
	}

	// Token: 0x06008F29 RID: 36649 RVA: 0x01158398 File Offset: 0x01156598
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onRevivePlayer()
	{
		if (180199 - 29302 != 150897)
		{
		}
		for (;;)
		{
			Debug.Log("On Revive Player");
			if (116259 - 494160 != -377900)
			{
				this.QLgczKdlb6k.target = Game.mPlayer;
				if (133649 - 436845 == -303196)
				{
					this.QLgczKdlb6k.enabled = true;
					if (135919 - 225355 == -89436)
					{
						if (Game.mGameState != eGameState.Normal)
						{
							if (108105 - 483865 != -375760)
							{
								continue;
							}
							if (Game.mGameState != eGameState.Hold)
							{
								break;
							}
							if (278244 - 187013 != 91231)
							{
								continue;
							}
						}
						Game.mGameState = eGameState.Normal;
						if (66303 - 410382 != -344078)
						{
							GameGui gameGui = (GameGui)this.GetComponent(typeof(GameGui));
							if (53427 - 430245 == -376818)
							{
								if (!gameGui)
								{
									break;
								}
								if (173720 - 8910 == 164810)
								{
									gameGui.enabled = true;
									if (138476 - 30594 != 107883)
									{
										gameGui.closeDeadMenu();
										if (235207 - 550284 != -315076)
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

	// Token: 0x06008F2A RID: 36650 RVA: 0x01158544 File Offset: 0x01156744
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onPlayerRelease(GameObject mPlayer)
	{
		if (288191 - 239194 != 48997)
		{
		}
		for (;;)
		{
			Debug.Log("On Release Spirit");
			if (295619 - 250697 == 44922)
			{
				PlayerData.MissionWithdraw[MissionData.getMissionNumber(Game.mGameCode) - 1] = PlayerData.MissionWithdraw[MissionData.getMissionNumber(Game.mGameCode) - 1] + 1;
				if (141642 - 366719 != -225076)
				{
					this.StartCoroutine_Auto(this.ReturnToTown());
					if (150260 - 22380 != 127881)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06008F2B RID: 36651 RVA: 0x01158608 File Offset: 0x01156808
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onDestroyPlayer(Hashtable data)
	{
		if (RuntimeServices.EqualityOperator(data[81], PlayerData.UID))
		{
			Game.mGameState = eGameState.Ended;
		}
	}

	// Token: 0x06008F2C RID: 36652 RVA: 0x01158634 File Offset: 0x01156834
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void ChangePlayer(int nCID)
	{
		if (56243 - 541354 != -485111)
		{
		}
		for (;;)
		{
			int v = Game.mPlayer.layer - 7;
			if (218738 - 228731 != -9992)
			{
				Vector3 position = Game.mPlayer.transform.position;
				if (72406 - 466693 != -394286)
				{
					Vector3 forward = Game.mPlayer.transform.forward;
					if (283791 - 310279 != -26487)
					{
						Hashtable hashtable = new Hashtable();
						if (60181 - 362786 == -302605)
						{
							hashtable.Add(43, PlayerData.UID);
							if (161413 - 256372 != -94958)
							{
								hashtable.Add(71, nCID);
								if (113135 - 7038 == 106097)
								{
									hashtable.Add(75, PhotonClient.cInt16(v));
									if (297584 - 472776 != -175191)
									{
										hashtable.Add(122, PhotonClient.cInt16(Mathf.RoundToInt(position.x * (float)50)));
										if (70982 - 154851 == -83869)
										{
											hashtable.Add(123, PhotonClient.cInt16(Mathf.RoundToInt(position.y * (float)50)));
											if (54424 - 301138 != -246713)
											{
												hashtable.Add(124, PhotonClient.cInt16(Mathf.RoundToInt(position.z * (float)50)));
												if (3176 - 385696 != -382519)
												{
													hashtable.Add(126, PhotonClient.cInt16(Mathf.RoundToInt(forward.x * (float)200)));
													if (169803 - 144247 == 25556)
													{
														hashtable.Add(127, PhotonClient.cInt16(Mathf.RoundToInt(forward.y * (float)200)));
														if (64778 - 355251 != -290472)
														{
															hashtable.Add(128, PhotonClient.cInt16(Mathf.RoundToInt(forward.z * (float)200)));
															if (278390 - 555518 == -277128)
															{
																PhotonClient.Connection.OpCustom(65, hashtable, true);
																if (145401 - 552709 == -407308)
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

	// Token: 0x06008F2D RID: 36653 RVA: 0x01158954 File Offset: 0x01156B54
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator onChangePlayer(Hashtable data)
	{
		return new M808_MonsterArena.$onChangePlayer$41131(data, this).GetEnumerator();
	}

	// Token: 0x06008F2E RID: 36654 RVA: 0x01158964 File Offset: 0x01156B64
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator ReturnToTown()
	{
		return new M808_MonsterArena.$ReturnToTown$41138(this).GetEnumerator();
	}

	// Token: 0x06008F2F RID: 36655 RVA: 0x01158974 File Offset: 0x01156B74
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator ReturnToGuild()
	{
		return new M808_MonsterArena.$ReturnToGuild$41143(this).GetEnumerator();
	}

	// Token: 0x06008F30 RID: 36656 RVA: 0x01158984 File Offset: 0x01156B84
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator ReturnToCamp()
	{
		return new M808_MonsterArena.$ReturnToCamp$41147(this).GetEnumerator();
	}

	// Token: 0x06008F31 RID: 36657 RVA: 0x01158994 File Offset: 0x01156B94
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void LeaveGame()
	{
		if (216299 - 212627 != 3673)
		{
		}
		for (;;)
		{
			Debug.Log("leaving guild");
			if (236922 - 545191 != -308268)
			{
				Hashtable hashtable = new Hashtable();
				if (296593 - 200311 != 96283)
				{
					hashtable.Add(43, PlayerData.UID);
					if (151586 - 457663 != -306076)
					{
						PhotonClient.Connection.OpCustom(54, hashtable, true);
						if (203411 - 584918 != -381506)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x06008F32 RID: 36658 RVA: 0x01158A6C File Offset: 0x01156C6C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onLeaveGame()
	{
		Debug.Log("onLeaveGame");
		this.JoinTown();
	}

	// Token: 0x06008F33 RID: 36659 RVA: 0x01158A80 File Offset: 0x01156C80
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void JoinTown()
	{
		if (204710 - 384160 != -179449)
		{
		}
		for (;;)
		{
			Debug.Log("Joining Town");
			if (269849 - 125999 == 143850)
			{
				Hashtable hashtable = new Hashtable();
				if (60841 - 595569 == -534728)
				{
					if (Game.mNextGameCode == 30)
					{
						if (196275 - 458226 != -261951)
						{
							continue;
						}
						hashtable.Add(47, "NoGuild");
						if (157263 - 472965 != -315702)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 31)
					{
						if (260599 - 482626 == -222026)
						{
							continue;
						}
						hashtable.Add(47, "G" + GuildData.Name);
						if (198188 - 265080 == -66891)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 32)
					{
						if (218889 - 535970 != -317081)
						{
							continue;
						}
						hashtable.Add(47, "SnowCamp");
						if (228768 - 116184 == 112585)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 33)
					{
						if (241483 - 424479 != -182996)
						{
							continue;
						}
						hashtable.Add(47, "CrystalBeach");
						if (197704 - 526508 == -328803)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 34)
					{
						if (199302 - 399896 != -200594)
						{
							continue;
						}
						hashtable.Add(47, "ExcavationCamp");
						if (51367 - 42694 == 8674)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 35)
					{
						if (128969 - 559118 == -430148)
						{
							continue;
						}
						hashtable.Add(47, "UndergroundCamp");
						if (56852 - 116562 == -59709)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 36)
					{
						if (132027 - 219258 != -87231)
						{
							continue;
						}
						hashtable.Add(47, "ForestCamp");
						if (246604 - 557979 != -311375)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 51)
					{
						if (231551 - 249441 != -17890)
						{
							continue;
						}
						hashtable.Add(47, "MainStreet");
						if (117597 - 59303 == 58295)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 52)
					{
						if (68890 - 349040 == -280149)
						{
							continue;
						}
						hashtable.Add(47, "CentralSquare");
						if (210509 - 459139 != -248630)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 53)
					{
						if (95002 - 563163 == -468160)
						{
							continue;
						}
						hashtable.Add(47, "CityLibrary");
						if (247129 - 34277 == 212853)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 54)
					{
						if (278354 - 105911 != 172443)
						{
							continue;
						}
						hashtable.Add(47, "LightPark");
						if (254790 - 33888 != 220902)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 55)
					{
						if (147419 - 588378 != -440959)
						{
							continue;
						}
						hashtable.Add(47, "LightPalace");
						if (238810 - 498775 == -259964)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 56)
					{
						if (15146 - 303438 == -288291)
						{
							continue;
						}
						hashtable.Add(47, "PlainColosseum");
						if (144551 - 38560 == 105992)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 57)
					{
						if (176309 - 77719 == 98591)
						{
							continue;
						}
						hashtable.Add(47, "LightTheater");
						if (120883 - 252730 != -131847)
						{
							continue;
						}
					}
					hashtable.Add(21, PhotonClient.cInt16(Mathf.Clamp(PlayerPrefs.GetInt("channel", 0), 0, 99)));
					if (30991 - 165928 != -134936)
					{
						this.gfgczhqaTa6.OpCustom(42, hashtable, true);
						if (149130 - 574083 == -424953)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x06008F34 RID: 36660 RVA: 0x01159034 File Offset: 0x01157234
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onJoinTown()
	{
		Game.mGameStage = 0;
		Game.loadNextLevel();
	}

	// Token: 0x06008F35 RID: 36661 RVA: 0x01159044 File Offset: 0x01157244
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x06008F36 RID: 36662 RVA: 0x01159048 File Offset: 0x01157248
	internal static bool aOj5XfVQovNpAdeDoGkA()
	{
		return true;
	}

	// Token: 0x06008F37 RID: 36663 RVA: 0x0115904C File Offset: 0x0115724C
	internal static bool aWfgwlVQExnuJedVgdRq()
	{
		return false;
	}

	// Token: 0x040087D5 RID: 34773
	private LitePeer gfgczhqaTa6;

	// Token: 0x040087D6 RID: 34774
	private PlayerCameraControl QLgczKdlb6k;

	// Token: 0x040087D7 RID: 34775
	private float N6tczzmyMBf;

	// Token: 0x040087D8 RID: 34776
	private Texture GCLn55vje4j;

	// Token: 0x040087D9 RID: 34777
	private int o8vn5cQ008O;

	// Token: 0x040087DA RID: 34778
	private int KMxn5nGlCwe;

	// Token: 0x040087DB RID: 34779
	private int hVBn5Qh36s4;

	// Token: 0x040087DC RID: 34780
	private int thLn5e9dgVZ;

	// Token: 0x040087DD RID: 34781
	private int x9rn5IkZJ8O;

	// Token: 0x040087DE RID: 34782
	private int lNBn5JWwUcI;

	// Token: 0x040087DF RID: 34783
	private int UCNn56WBkZZ;

	// Token: 0x040087E0 RID: 34784
	private int o9cn5t79CHe;

	// Token: 0x040087E1 RID: 34785
	private int Fvan5Xr8M3A;

	// Token: 0x040087E2 RID: 34786
	private int SsIn5OTfd8v;

	// Token: 0x040087E3 RID: 34787
	private int NZVn520H3YM;

	// Token: 0x040087E4 RID: 34788
	private int qAWn5viBh4Y;

	// Token: 0x040087E5 RID: 34789
	private int Ulsn5l9UIAA;

	// Token: 0x040087E6 RID: 34790
	private int t7fn5G0XMLk;

	// Token: 0x040087E7 RID: 34791
	private int GhTn51347al;

	// Token: 0x040087E8 RID: 34792
	private int hSyn5q6obUr;

	// Token: 0x040087E9 RID: 34793
	private int iskn5ptHZ7Y;

	// Token: 0x040087EA RID: 34794
	private int kn1n5ROTdEt;

	// Token: 0x02001806 RID: 6150
	[CompilerGenerated]
	[Serializable]
	internal sealed class $onGameEvent$41082 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06008F38 RID: 36664 RVA: 0x01159050 File Offset: 0x01157250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $onGameEvent$41082(Hashtable data, M808_MonsterArena self_)
		{
			if (52873 - 373262 != -320389)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (135917 - 406953 == -271036)
				{
					base..ctor();
					if (113971 - 486583 != -372611)
					{
						this.$data$41108 = data;
						if (245533 - 437398 != -191864)
						{
							this.$self_$41109 = self_;
							if (22360 - 560384 == -538024)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x06008F39 RID: 36665 RVA: 0x0115910C File Offset: 0x0115730C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M808_MonsterArena.$onGameEvent$41082.$(this.$data$41108, this.$self_$41109);
		}

		// Token: 0x06008F3A RID: 36666 RVA: 0x01159120 File Offset: 0x01157320
		internal static bool f81o5nVQ2gLtuBHa2hay()
		{
			return true;
		}

		// Token: 0x06008F3B RID: 36667 RVA: 0x01159124 File Offset: 0x01157324
		internal static bool NOXIEpVQ8TSXpSgFUNJ7()
		{
			return false;
		}

		// Token: 0x040087EB RID: 34795
		internal Hashtable $data$41108;

		// Token: 0x040087EC RID: 34796
		internal M808_MonsterArena $self_$41109;

		// Token: 0x02001807 RID: 6151
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06008F3C RID: 36668 RVA: 0x01159128 File Offset: 0x01157328
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Hashtable data, M808_MonsterArena self_)
			{
				if (229191 - 441808 != -212616)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (31551 - 161506 == -129955)
					{
						base..ctor();
						if (141996 - 16679 == 125317)
						{
							this.$data$41106 = data;
							if (150499 - 387853 != -237353)
							{
								this.$self_$41107 = self_;
								if (227963 - 99364 != 128600)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x06008F3D RID: 36669 RVA: 0x011591E4 File Offset: 0x011573E4
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (203585 - 182354 != 21231)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_7FF1;
					case 2:
						goto IL_5DAF;
					case 3:
						Game.sendMissionEvent(8083, this.$self_$41107.o8vn5cQ008O);
						if (10675 - 589005 != -578329)
						{
							goto IL_31AE;
						}
						continue;
					default:
						if (27284 - 273796 == -246511)
						{
							continue;
						}
						break;
					}
					if (Game.mGameState > eGameState.AllHold)
					{
						if (109945 - 22069 != 87877)
						{
							break;
						}
						continue;
					}
					else
					{
						this.$returnCode$41083 = RuntimeServices.UnboxInt32(this.$data$41106[141]);
						if (283310 - 83618 != 199692)
						{
							continue;
						}
						this.$returnValue$41084 = RuntimeServices.UnboxInt32(this.$data$41106[145]);
						if (227525 - 83936 == 143590)
						{
							continue;
						}
						this.$ownerID$41085 = RuntimeServices.UnboxInt32(this.$data$41106[43]);
						if (171631 - 262299 == -90667)
						{
							continue;
						}
						this.$$switch$7378$41086 = this.$returnCode$41083;
						if (73395 - 14458 != 58937)
						{
							continue;
						}
						if (this.$$switch$7378$41086 == 8081)
						{
							if (97914 - 227857 == -129942)
							{
								continue;
							}
							if (this.$self_$41107.o8vn5cQ008O < this.$returnValue$41084)
							{
								if (214668 - 319002 == -104333)
								{
									continue;
								}
								this.$self_$41107.o8vn5cQ008O = this.$returnValue$41084;
								if (88708 - 312513 == -223804)
								{
									continue;
								}
								if (this.$self_$41107.o8vn5cQ008O == 1)
								{
									goto IL_5DAF;
								}
								if (219623 - 238613 != -18990)
								{
									continue;
								}
								goto IL_5D99;
							}
						}
						else if (this.$$switch$7378$41086 == 8083)
						{
							if (17286 - 543126 != -525840)
							{
								continue;
							}
							Debug.Log("Starting round:" + this.$returnValue$41084);
							if (279294 - 532099 == -252804)
							{
								continue;
							}
						}
						else if (this.$$switch$7378$41086 == -8083)
						{
							if (298494 - 427678 != -129184)
							{
								continue;
							}
							if (PlayerData.UID == this.$ownerID$41085)
							{
								if (196161 - 528533 == -332371)
								{
									continue;
								}
								this.$SpawnPoint1$41089 = GameObject.Find("SpawnPoint1");
								if (45055 - 378849 != -333794)
								{
									continue;
								}
								this.$SpawnPoint2$41090 = GameObject.Find("SpawnPoint2");
								if (159901 - 144825 == 15077)
								{
									continue;
								}
								this.$SpawnPoint3$41091 = GameObject.Find("SpawnPoint3");
								if (92697 - 221414 != -128717)
								{
									continue;
								}
								this.$SpawnPoint4$41092 = GameObject.Find("SpawnPoint4");
								if (169272 - 33249 == 136024)
								{
									continue;
								}
								this.$SpawnPoint5$41093 = GameObject.Find("SpawnPoint5");
								if (267653 - 538715 != -271062)
								{
									continue;
								}
								this.$SpawnPoint6$41094 = GameObject.Find("SpawnPoint6");
								if (126297 - 379652 != -253355)
								{
									continue;
								}
								this.$SpawnPoint7$41095 = GameObject.Find("SpawnPoint7");
								if (166603 - 497888 != -331285)
								{
									continue;
								}
								this.$SpawnPoint8$41096 = GameObject.Find("SpawnPoint8");
								if (265710 - 124590 != 141120)
								{
									continue;
								}
								this.$SpawnPoint9$41097 = GameObject.Find("SpawnPoint9");
								if (179331 - 340621 != -161290)
								{
									continue;
								}
								this.$SpawnPoint10$41098 = GameObject.Find("SpawnPoint10");
								if (27552 - 419409 != -391857)
								{
									continue;
								}
								this.$SpawnPoint11$41099 = GameObject.Find("SpawnPoint11");
								if (155567 - 310708 != -155141)
								{
									continue;
								}
								this.$SpawnPoint12$41100 = GameObject.Find("SpawnPoint12");
								if (888 - 315267 != -314379)
								{
									continue;
								}
								this.$SpawnPoint13$41101 = GameObject.Find("SpawnPoint13");
								if (261082 - 485378 != -224296)
								{
									continue;
								}
								this.$SpawnPoint14$41102 = GameObject.Find("SpawnPoint14");
								if (275746 - 243300 == 32447)
								{
									continue;
								}
								this.$SpawnPoint15$41103 = GameObject.Find("SpawnPoint15");
								if (259954 - 215025 == 44930)
								{
									continue;
								}
								this.$$switch$7374$41104 = this.$returnValue$41084;
								if (258588 - 373684 == -115095)
								{
									continue;
								}
								if (this.$$switch$7374$41104 == 1)
								{
									if (277064 - 291048 == -13983)
									{
										continue;
									}
									Debug.Log("Starting Round 1");
									if (56182 - 409500 == -353317)
									{
										continue;
									}
									if (this.$SpawnPoint1$41089)
									{
										if (138127 - 492506 != -354379)
										{
											continue;
										}
										this.$self_$41107.createActor("LittleFatBug_g", 6, this.$SpawnPoint1$41089.transform.position, this.$SpawnPoint1$41089.transform.forward);
										if (159166 - 2053 != 157113)
										{
											continue;
										}
									}
									if (this.$SpawnPoint2$41090)
									{
										if (278198 - 596874 != -318676)
										{
											continue;
										}
										this.$self_$41107.createActor("LittleFatBug_p", 6, this.$SpawnPoint2$41090.transform.position, this.$SpawnPoint2$41090.transform.forward);
										if (32420 - 518183 != -485763)
										{
											continue;
										}
									}
									if (this.$SpawnPoint3$41091)
									{
										if (234491 - 303849 == -69357)
										{
											continue;
										}
										this.$self_$41107.createActor("LittleFatBug_y", 6, this.$SpawnPoint3$41091.transform.position, this.$SpawnPoint3$41091.transform.forward);
										if (230337 - 467197 != -236860)
										{
											continue;
										}
									}
									if (this.$SpawnPoint4$41092)
									{
										if (45066 - 344180 == -299113)
										{
											continue;
										}
										this.$self_$41107.createActor("LittleFatBug_g", 6, this.$SpawnPoint4$41092.transform.position, this.$SpawnPoint4$41092.transform.forward);
										if (253308 - 208840 != 44468)
										{
											continue;
										}
									}
									if (this.$SpawnPoint5$41093)
									{
										if (20485 - 320194 == -299708)
										{
											continue;
										}
										this.$self_$41107.createActor("LittleFatBug_p", 6, this.$SpawnPoint5$41093.transform.position, this.$SpawnPoint5$41093.transform.forward);
										if (2212 - 471870 == -469657)
										{
											continue;
										}
									}
									if (this.$SpawnPoint6$41094)
									{
										if (57081 - 100877 != -43796)
										{
											continue;
										}
										this.$self_$41107.createActor("LittleFatBug_y", 6, this.$SpawnPoint6$41094.transform.position, this.$SpawnPoint6$41094.transform.forward);
										if (38575 - 440666 == -402090)
										{
											continue;
										}
									}
									if (this.$SpawnPoint7$41095)
									{
										if (277174 - 362338 != -85164)
										{
											continue;
										}
										this.$self_$41107.createActor("FatBug_g", 6, this.$SpawnPoint7$41095.transform.position, this.$SpawnPoint7$41095.transform.forward);
										if (270516 - 93184 == 177333)
										{
											continue;
										}
									}
									if (this.$SpawnPoint8$41096)
									{
										if (198208 - 575661 == -377452)
										{
											continue;
										}
										this.$self_$41107.createActor("FatBug_p", 6, this.$SpawnPoint8$41096.transform.position, this.$SpawnPoint8$41096.transform.forward);
										if (267519 - 202368 != 65151)
										{
											continue;
										}
									}
									if (this.$SpawnPoint10$41098)
									{
										if (293333 - 218807 == 74527)
										{
											continue;
										}
										this.$self_$41107.createActor("FatBug_y", 6, this.$SpawnPoint10$41098.transform.position, this.$SpawnPoint10$41098.transform.forward);
										if (137521 - 564200 != -426679)
										{
											continue;
										}
									}
									if (this.$SpawnPoint11$41099)
									{
										if (116008 - 510340 == -394331)
										{
											continue;
										}
										this.$self_$41107.createActor("FatBug_g", 6, this.$SpawnPoint11$41099.transform.position, this.$SpawnPoint11$41099.transform.forward);
										if (52276 - 437285 != -385009)
										{
											continue;
										}
									}
									if (this.$SpawnPoint12$41100)
									{
										if (93281 - 442974 != -349693)
										{
											continue;
										}
										this.$self_$41107.createActor("FatBug_p", 6, this.$SpawnPoint12$41100.transform.position, this.$SpawnPoint12$41100.transform.forward);
										if (214431 - 124992 != 89439)
										{
											continue;
										}
									}
									if (this.$SpawnPoint14$41102)
									{
										if (280067 - 302485 != -22418)
										{
											continue;
										}
										this.$self_$41107.createActor("FatBug_y", 6, this.$SpawnPoint14$41102.transform.position, this.$SpawnPoint14$41102.transform.forward);
										if (132392 - 269824 == -137431)
										{
											continue;
										}
									}
									if (this.$SpawnPoint15$41103)
									{
										if (157024 - 134178 != 22846)
										{
											continue;
										}
										this.$self_$41107.createActor("LittleFatBug_w", 6, this.$SpawnPoint6$41094.transform.position, this.$SpawnPoint15$41103.transform.forward);
										if (87402 - 142398 == -54995)
										{
											continue;
										}
									}
								}
								else if (this.$$switch$7374$41104 == 2)
								{
									if (250492 - 123835 != 126657)
									{
										continue;
									}
									Debug.Log("Starting Round 2");
									if (189718 - 268766 == -79047)
									{
										continue;
									}
									if (this.$SpawnPoint1$41089)
									{
										if (247068 - 205193 != 41875)
										{
											continue;
										}
										this.$self_$41107.createActor("LeafBug_r", 6, this.$SpawnPoint1$41089.transform.position, this.$SpawnPoint1$41089.transform.forward);
										if (202778 - 505645 == -302866)
										{
											continue;
										}
									}
									if (this.$SpawnPoint2$41090)
									{
										if (204852 - 184340 != 20512)
										{
											continue;
										}
										this.$self_$41107.createActor("FlowerBug_p", 6, this.$SpawnPoint2$41090.transform.position, this.$SpawnPoint2$41090.transform.forward);
										if (94819 - 327985 == -233165)
										{
											continue;
										}
									}
									if (this.$SpawnPoint3$41091)
									{
										if (165532 - 338940 != -173408)
										{
											continue;
										}
										this.$self_$41107.createActor("LeafBug_r", 6, this.$SpawnPoint3$41091.transform.position, this.$SpawnPoint3$41091.transform.forward);
										if (132366 - 576309 != -443943)
										{
											continue;
										}
									}
									if (this.$SpawnPoint4$41092)
									{
										if (23919 - 586586 != -562667)
										{
											continue;
										}
										this.$self_$41107.createActor("FlowerBug_p", 6, this.$SpawnPoint4$41092.transform.position, this.$SpawnPoint4$41092.transform.forward);
										if (121278 - 137502 == -16223)
										{
											continue;
										}
									}
									if (this.$SpawnPoint5$41093)
									{
										if (65055 - 446223 != -381168)
										{
											continue;
										}
										this.$self_$41107.createActor("LeafBug_r", 6, this.$SpawnPoint5$41093.transform.position, this.$SpawnPoint5$41093.transform.forward);
										if (1130 - 101691 != -100561)
										{
											continue;
										}
									}
									if (this.$SpawnPoint6$41094)
									{
										if (104994 - 561019 != -456025)
										{
											continue;
										}
										this.$self_$41107.createActor("FlowerBug_p", 6, this.$SpawnPoint6$41094.transform.position, this.$SpawnPoint6$41094.transform.forward);
										if (276242 - 264996 != 11246)
										{
											continue;
										}
									}
									if (this.$SpawnPoint7$41095)
									{
										if (158903 - 443373 == -284469)
										{
											continue;
										}
										this.$self_$41107.createActor("LeafBug_b", 6, this.$SpawnPoint7$41095.transform.position, this.$SpawnPoint7$41095.transform.forward);
										if (112460 - 40686 == 71775)
										{
											continue;
										}
									}
									if (this.$SpawnPoint8$41096)
									{
										if (108191 - 434200 != -326009)
										{
											continue;
										}
										this.$self_$41107.createActor("FlowerBug_b", 6, this.$SpawnPoint8$41096.transform.position, this.$SpawnPoint8$41096.transform.forward);
										if (61062 - 596657 == -535594)
										{
											continue;
										}
									}
									if (this.$SpawnPoint9$41097)
									{
										if (93128 - 382335 == -289206)
										{
											continue;
										}
										this.$self_$41107.createActor("LeafBug_b", 6, this.$SpawnPoint9$41097.transform.position, this.$SpawnPoint9$41097.transform.forward);
										if (43179 - 402459 != -359280)
										{
											continue;
										}
									}
									if (this.$SpawnPoint10$41098)
									{
										if (275734 - 27646 == 248089)
										{
											continue;
										}
										this.$self_$41107.createActor("FlowerBug_b", 6, this.$SpawnPoint10$41098.transform.position, this.$SpawnPoint10$41098.transform.forward);
										if (34089 - 411313 == -377223)
										{
											continue;
										}
									}
									if (this.$SpawnPoint11$41099)
									{
										if (263424 - 174412 != 89012)
										{
											continue;
										}
										this.$self_$41107.createActor("LeafBug_b", 6, this.$SpawnPoint11$41099.transform.position, this.$SpawnPoint11$41099.transform.forward);
										if (186033 - 112098 == 73936)
										{
											continue;
										}
									}
									if (this.$SpawnPoint12$41100)
									{
										if (70369 - 223655 == -153285)
										{
											continue;
										}
										this.$self_$41107.createActor("FlowerBug_b", 6, this.$SpawnPoint12$41100.transform.position, this.$SpawnPoint12$41100.transform.forward);
										if (42603 - 293059 != -250456)
										{
											continue;
										}
									}
									if (this.$SpawnPoint13$41101)
									{
										if (127691 - 373016 == -245324)
										{
											continue;
										}
										this.$self_$41107.createActor("LeafBug_b", 6, this.$SpawnPoint13$41101.transform.position, this.$SpawnPoint13$41101.transform.forward);
										if (271311 - 145880 != 125431)
										{
											continue;
										}
									}
									if (this.$SpawnPoint14$41102)
									{
										if (231701 - 10767 != 220934)
										{
											continue;
										}
										this.$self_$41107.createActor("FlowerBug_b", 6, this.$SpawnPoint14$41102.transform.position, this.$SpawnPoint14$41102.transform.forward);
										if (88683 - 184219 != -95536)
										{
											continue;
										}
									}
								}
								else if (this.$$switch$7374$41104 == 3)
								{
									if (95884 - 270779 != -174895)
									{
										continue;
									}
									Debug.Log("Starting Round 3");
									if (123626 - 400143 != -276517)
									{
										continue;
									}
									if (this.$SpawnPoint1$41089)
									{
										if (50141 - 429535 != -379394)
										{
											continue;
										}
										this.$self_$41107.createActor("NinjaBug_r", 6, this.$SpawnPoint1$41089.transform.position, this.$SpawnPoint1$41089.transform.forward);
										if (173301 - 574166 != -400865)
										{
											continue;
										}
									}
									if (this.$SpawnPoint2$41090)
									{
										if (282057 - 266996 == 15062)
										{
											continue;
										}
										this.$self_$41107.createActor("NinjaBug_b", 6, this.$SpawnPoint2$41090.transform.position, this.$SpawnPoint2$41090.transform.forward);
										if (237650 - 432270 == -194619)
										{
											continue;
										}
									}
									if (this.$SpawnPoint3$41091)
									{
										if (15584 - 362490 != -346906)
										{
											continue;
										}
										this.$self_$41107.createActor("NinjaBug_g", 6, this.$SpawnPoint3$41091.transform.position, this.$SpawnPoint3$41091.transform.forward);
										if (149706 - 38681 == 111026)
										{
											continue;
										}
									}
									if (this.$SpawnPoint5$41093)
									{
										if (170411 - 39823 != 130588)
										{
											continue;
										}
										this.$self_$41107.createActor("NinjaBug_y", 6, this.$SpawnPoint5$41093.transform.position, this.$SpawnPoint5$41093.transform.forward);
										if (186885 - 207380 == -20494)
										{
											continue;
										}
									}
									if (this.$SpawnPoint6$41094)
									{
										if (283796 - 382418 != -98622)
										{
											continue;
										}
										this.$self_$41107.createActor("NinjaBug_k", 6, this.$SpawnPoint6$41094.transform.position, this.$SpawnPoint6$41094.transform.forward);
										if (149380 - 556081 == -406700)
										{
											continue;
										}
									}
									if (this.$SpawnPoint7$41095)
									{
										if (80536 - 599472 == -518935)
										{
											continue;
										}
										this.$self_$41107.createActor("BanditBug1", 6, this.$SpawnPoint7$41095.transform.position, this.$SpawnPoint7$41095.transform.forward);
										if (247902 - 216322 == 31581)
										{
											continue;
										}
									}
									if (this.$SpawnPoint8$41096)
									{
										if (39437 - 401164 != -361727)
										{
											continue;
										}
										this.$self_$41107.createActor("BanditBug2", 6, this.$SpawnPoint8$41096.transform.position, this.$SpawnPoint8$41096.transform.forward);
										if (1580 - 64144 != -62564)
										{
											continue;
										}
									}
									if (this.$SpawnPoint9$41097)
									{
										if (173829 - 221253 != -47424)
										{
											continue;
										}
										this.$self_$41107.createActor("BanditBug3", 6, this.$SpawnPoint9$41097.transform.position, this.$SpawnPoint9$41097.transform.forward);
										if (31019 - 83742 != -52723)
										{
											continue;
										}
									}
									if (this.$SpawnPoint10$41098)
									{
										if (194468 - 291997 == -97528)
										{
											continue;
										}
										this.$self_$41107.createActor("BanditBug1", 6, this.$SpawnPoint10$41098.transform.position, this.$SpawnPoint10$41098.transform.forward);
										if (185803 - 397214 != -211411)
										{
											continue;
										}
									}
									if (this.$SpawnPoint11$41099)
									{
										if (113214 - 349805 == -236590)
										{
											continue;
										}
										this.$self_$41107.createActor("BanditBug2", 6, this.$SpawnPoint11$41099.transform.position, this.$SpawnPoint11$41099.transform.forward);
										if (64325 - 426848 != -362523)
										{
											continue;
										}
									}
									if (this.$SpawnPoint12$41100)
									{
										if (297836 - 547533 == -249696)
										{
											continue;
										}
										this.$self_$41107.createActor("BanditBug3", 6, this.$SpawnPoint12$41100.transform.position, this.$SpawnPoint12$41100.transform.forward);
										if (241710 - 23524 != 218186)
										{
											continue;
										}
									}
									if (this.$SpawnPoint13$41101)
									{
										if (246811 - 36818 == 209994)
										{
											continue;
										}
										this.$self_$41107.createActor("BanditBug1", 6, this.$SpawnPoint13$41101.transform.position, this.$SpawnPoint13$41101.transform.forward);
										if (122153 - 219244 == -97090)
										{
											continue;
										}
									}
									if (this.$SpawnPoint14$41102)
									{
										if (135945 - 584344 != -448399)
										{
											continue;
										}
										this.$self_$41107.createActor("BanditBug2", 6, this.$SpawnPoint14$41102.transform.position, this.$SpawnPoint14$41102.transform.forward);
										if (35914 - 239467 != -203553)
										{
											continue;
										}
									}
									if (this.$SpawnPoint15$41103)
									{
										if (56739 - 6406 == 50334)
										{
											continue;
										}
										this.$self_$41107.createActor("BanditBug3", 6, this.$SpawnPoint15$41103.transform.position, this.$SpawnPoint15$41103.transform.forward);
										if (28445 - 296775 == -268329)
										{
											continue;
										}
									}
								}
								else if (this.$$switch$7374$41104 == 4)
								{
									if (147145 - 176335 != -29190)
									{
										continue;
									}
									Debug.Log("Starting Round 4");
									if (31187 - 537257 != -506070)
									{
										continue;
									}
									if (this.$SpawnPoint1$41089)
									{
										if (141744 - 327060 == -185315)
										{
											continue;
										}
										this.$self_$41107.createActor("NeedleBug_r", 6, this.$SpawnPoint1$41089.transform.position, this.$SpawnPoint1$41089.transform.forward);
										if (62892 - 543842 != -480950)
										{
											continue;
										}
									}
									if (this.$SpawnPoint2$41090)
									{
										if (202345 - 451386 == -249040)
										{
											continue;
										}
										this.$self_$41107.createActor("NeedleBug_g", 6, this.$SpawnPoint2$41090.transform.position, this.$SpawnPoint2$41090.transform.forward);
										if (186643 - 248768 == -62124)
										{
											continue;
										}
									}
									if (this.$SpawnPoint3$41091)
									{
										if (47071 - 339215 == -292143)
										{
											continue;
										}
										this.$self_$41107.createActor("NeedleBug_o", 6, this.$SpawnPoint3$41091.transform.position, this.$SpawnPoint3$41091.transform.forward);
										if (152475 - 592781 != -440306)
										{
											continue;
										}
									}
									if (this.$SpawnPoint4$41092)
									{
										if (288303 - 338708 != -50405)
										{
											continue;
										}
										this.$self_$41107.createActor("NeedleBug_b", 6, this.$SpawnPoint4$41092.transform.position, this.$SpawnPoint4$41092.transform.forward);
										if (77489 - 345409 == -267919)
										{
											continue;
										}
									}
									if (this.$SpawnPoint5$41093)
									{
										if (175962 - 101537 == 74426)
										{
											continue;
										}
										this.$self_$41107.createActor("NeedleBug_p", 6, this.$SpawnPoint5$41093.transform.position, this.$SpawnPoint5$41093.transform.forward);
										if (68851 - 353249 == -284397)
										{
											continue;
										}
									}
									if (this.$SpawnPoint6$41094)
									{
										if (13084 - 130680 == -117595)
										{
											continue;
										}
										this.$self_$41107.createActor("NeedleBug_k", 6, this.$SpawnPoint6$41094.transform.position, this.$SpawnPoint6$41094.transform.forward);
										if (68539 - 233317 == -164777)
										{
											continue;
										}
									}
									if (this.$SpawnPoint7$41095)
									{
										if (296157 - 80288 == 215870)
										{
											continue;
										}
										this.$self_$41107.createActor("NeedleBug_w", 6, this.$SpawnPoint7$41095.transform.position, this.$SpawnPoint7$41095.transform.forward);
										if (299622 - 466009 == -166386)
										{
											continue;
										}
									}
									if (this.$SpawnPoint8$41096)
									{
										if (270092 - 274872 != -4780)
										{
											continue;
										}
										this.$self_$41107.createActor("NeedleBug_r", 6, this.$SpawnPoint8$41096.transform.position, this.$SpawnPoint8$41096.transform.forward);
										if (96925 - 228619 == -131693)
										{
											continue;
										}
									}
									if (this.$SpawnPoint9$41097)
									{
										if (237526 - 123090 == 114437)
										{
											continue;
										}
										this.$self_$41107.createActor("NeedleBug_g", 6, this.$SpawnPoint9$41097.transform.position, this.$SpawnPoint9$41097.transform.forward);
										if (135145 - 138187 == -3041)
										{
											continue;
										}
									}
									if (this.$SpawnPoint10$41098)
									{
										if (130163 - 311314 == -181150)
										{
											continue;
										}
										this.$self_$41107.createActor("NeedleBug_o", 6, this.$SpawnPoint10$41098.transform.position, this.$SpawnPoint10$41098.transform.forward);
										if (197919 - 194688 == 3232)
										{
											continue;
										}
									}
									if (this.$SpawnPoint11$41099)
									{
										if (205988 - 92702 == 113287)
										{
											continue;
										}
										this.$self_$41107.createActor("NeedleBug_w", 6, this.$SpawnPoint11$41099.transform.position, this.$SpawnPoint11$41099.transform.forward);
										if (210174 - 102596 != 107578)
										{
											continue;
										}
									}
									if (this.$SpawnPoint12$41100)
									{
										if (282585 - 320728 == -38142)
										{
											continue;
										}
										this.$self_$41107.createActor("NeedleBug_b", 6, this.$SpawnPoint12$41100.transform.position, this.$SpawnPoint12$41100.transform.forward);
										if (34138 - 570310 != -536172)
										{
											continue;
										}
									}
									if (this.$SpawnPoint13$41101)
									{
										if (179671 - 323160 != -143489)
										{
											continue;
										}
										this.$self_$41107.createActor("NeedleBug_p", 6, this.$SpawnPoint13$41101.transform.position, this.$SpawnPoint13$41101.transform.forward);
										if (77968 - 201995 != -124027)
										{
											continue;
										}
									}
									if (this.$SpawnPoint14$41102)
									{
										if (181833 - 368316 != -186483)
										{
											continue;
										}
										this.$self_$41107.createActor("NeedleBug_k", 6, this.$SpawnPoint14$41102.transform.position, this.$SpawnPoint14$41102.transform.forward);
										if (239284 - 17826 != 221458)
										{
											continue;
										}
									}
									if (this.$SpawnPoint15$41103)
									{
										if (296838 - 424089 != -127251)
										{
											continue;
										}
										this.$self_$41107.createActor("NeedleBug_w", 6, this.$SpawnPoint15$41103.transform.position, this.$SpawnPoint15$41103.transform.forward);
										if (102218 - 452325 == -350106)
										{
											continue;
										}
									}
								}
								else if (this.$$switch$7374$41104 == 5)
								{
									if (21873 - 323815 != -301942)
									{
										continue;
									}
									Debug.Log("Starting Round 5");
									if (244657 - 338182 != -93525)
									{
										continue;
									}
									if (this.$SpawnPoint7$41095)
									{
										if (207695 - 192080 == 15616)
										{
											continue;
										}
										this.$self_$41107.createActor("RockBug", 6, this.$SpawnPoint7$41095.transform.position, this.$SpawnPoint7$41095.transform.forward);
										if (193108 - 471336 != -278228)
										{
											continue;
										}
									}
									if (this.$SpawnPoint8$41096)
									{
										if (178303 - 275534 == -97230)
										{
											continue;
										}
										this.$self_$41107.createActor("RockBug", 6, this.$SpawnPoint8$41096.transform.position, this.$SpawnPoint8$41096.transform.forward);
										if (265050 - 180958 == 84093)
										{
											continue;
										}
									}
									if (this.$SpawnPoint9$41097)
									{
										if (225807 - 174788 == 51020)
										{
											continue;
										}
										this.$self_$41107.createActor("RockBug", 6, this.$SpawnPoint9$41097.transform.position, this.$SpawnPoint9$41097.transform.forward);
										if (96758 - 40283 != 56475)
										{
											continue;
										}
									}
									if (this.$SpawnPoint10$41098)
									{
										if (38057 - 589271 != -551214)
										{
											continue;
										}
										this.$self_$41107.createActor("RockBug", 6, this.$SpawnPoint10$41098.transform.position, this.$SpawnPoint10$41098.transform.forward);
										if (189662 - 180458 == 9205)
										{
											continue;
										}
									}
									if (this.$SpawnPoint11$41099)
									{
										if (186611 - 593277 != -406666)
										{
											continue;
										}
										this.$self_$41107.createActor("RockBug", 6, this.$SpawnPoint11$41099.transform.position, this.$SpawnPoint11$41099.transform.forward);
										if (44321 - 174761 == -130439)
										{
											continue;
										}
									}
									if (this.$SpawnPoint12$41100)
									{
										if (214231 - 7937 != 206294)
										{
											continue;
										}
										this.$self_$41107.createActor("RockBug", 6, this.$SpawnPoint12$41100.transform.position, this.$SpawnPoint12$41100.transform.forward);
										if (5341 - 486220 != -480879)
										{
											continue;
										}
									}
									if (this.$SpawnPoint13$41101)
									{
										if (134886 - 685 != 134201)
										{
											continue;
										}
										this.$self_$41107.createActor("RockBug", 6, this.$SpawnPoint13$41101.transform.position, this.$SpawnPoint13$41101.transform.forward);
										if (196573 - 14708 == 181866)
										{
											continue;
										}
									}
									if (this.$SpawnPoint14$41102)
									{
										if (63111 - 233625 == -170513)
										{
											continue;
										}
										this.$self_$41107.createActor("RockBug", 6, this.$SpawnPoint14$41102.transform.position, this.$SpawnPoint14$41102.transform.forward);
										if (262320 - 143147 == 119174)
										{
											continue;
										}
									}
								}
								else if (this.$$switch$7374$41104 == 6)
								{
									if (103289 - 157300 == -54010)
									{
										continue;
									}
									Debug.Log("Starting Round 6");
									if (184661 - 538579 != -353918)
									{
										continue;
									}
									if (this.$SpawnPoint1$41089)
									{
										if (127840 - 189147 == -61306)
										{
											continue;
										}
										this.$self_$41107.createActor("PineBug", 6, this.$SpawnPoint1$41089.transform.position, this.$SpawnPoint1$41089.transform.forward);
										if (165866 - 209917 != -44051)
										{
											continue;
										}
									}
									if (this.$SpawnPoint2$41090)
									{
										if (4054 - 520652 != -516598)
										{
											continue;
										}
										this.$self_$41107.createActor("SamuraiBug1", 6, this.$SpawnPoint2$41090.transform.position, this.$SpawnPoint2$41090.transform.forward);
										if (112746 - 486544 == -373797)
										{
											continue;
										}
									}
									if (this.$SpawnPoint3$41091)
									{
										if (58822 - 592618 == -533795)
										{
											continue;
										}
										this.$self_$41107.createActor("ShogunBug", 6, this.$SpawnPoint3$41091.transform.position, this.$SpawnPoint3$41091.transform.forward);
										if (147706 - 458125 != -310419)
										{
											continue;
										}
									}
									if (this.$SpawnPoint4$41092)
									{
										if (257275 - 571130 != -313855)
										{
											continue;
										}
										this.$self_$41107.createActor("PineBug", 6, this.$SpawnPoint4$41092.transform.position, this.$SpawnPoint4$41092.transform.forward);
										if (170788 - 73262 != 97526)
										{
											continue;
										}
									}
									if (this.$SpawnPoint5$41093)
									{
										if (75866 - 136415 != -60549)
										{
											continue;
										}
										this.$self_$41107.createActor("ShogunBug", 6, this.$SpawnPoint5$41093.transform.position, this.$SpawnPoint5$41093.transform.forward);
										if (159628 - 79994 == 79635)
										{
											continue;
										}
									}
									if (this.$SpawnPoint6$41094)
									{
										if (116229 - 189692 != -73463)
										{
											continue;
										}
										this.$self_$41107.createActor("SamuraiBug1", 6, this.$SpawnPoint6$41094.transform.position, this.$SpawnPoint6$41094.transform.forward);
										if (54074 - 135917 == -81842)
										{
											continue;
										}
									}
									if (this.$SpawnPoint8$41096)
									{
										if (100771 - 219151 == -118379)
										{
											continue;
										}
										this.$self_$41107.createActor("SamuraiBug1", 6, this.$SpawnPoint8$41096.transform.position, this.$SpawnPoint8$41096.transform.forward);
										if (199283 - 41430 != 157853)
										{
											continue;
										}
									}
									if (this.$SpawnPoint9$41097)
									{
										if (176026 - 181223 == -5196)
										{
											continue;
										}
										this.$self_$41107.createActor("SamuraiBug1", 6, this.$SpawnPoint9$41097.transform.position, this.$SpawnPoint9$41097.transform.forward);
										if (183840 - 375353 == -191512)
										{
											continue;
										}
									}
									if (this.$SpawnPoint10$41098)
									{
										if (171804 - 25711 == 146094)
										{
											continue;
										}
										this.$self_$41107.createActor("SamuraiBug1", 6, this.$SpawnPoint10$41098.transform.position, this.$SpawnPoint10$41098.transform.forward);
										if (150571 - 476831 != -326260)
										{
											continue;
										}
									}
									if (this.$SpawnPoint11$41099)
									{
										if (143529 - 68111 == 75419)
										{
											continue;
										}
										this.$self_$41107.createActor("SamuraiBug3", 6, this.$SpawnPoint11$41099.transform.position, this.$SpawnPoint11$41099.transform.forward);
										if (78458 - 553553 == -475094)
										{
											continue;
										}
									}
									if (this.$SpawnPoint12$41100)
									{
										if (24220 - 482476 != -458256)
										{
											continue;
										}
										this.$self_$41107.createActor("SamuraiBug3", 6, this.$SpawnPoint12$41100.transform.position, this.$SpawnPoint12$41100.transform.forward);
										if (281492 - 442028 == -160535)
										{
											continue;
										}
									}
									if (this.$SpawnPoint13$41101)
									{
										if (286716 - 407181 != -120465)
										{
											continue;
										}
										this.$self_$41107.createActor("SamuraiBug3", 6, this.$SpawnPoint13$41101.transform.position, this.$SpawnPoint13$41101.transform.forward);
										if (153963 - 92973 != 60990)
										{
											continue;
										}
									}
									if (this.$SpawnPoint14$41102)
									{
										if (70504 - 417033 == -346528)
										{
											continue;
										}
										this.$self_$41107.createActor("SamuraiBug3", 6, this.$SpawnPoint14$41102.transform.position, this.$SpawnPoint14$41102.transform.forward);
										if (161527 - 588492 != -426965)
										{
											continue;
										}
									}
									if (this.$SpawnPoint15$41103)
									{
										if (275961 - 494423 == -218461)
										{
											continue;
										}
										this.$self_$41107.createActor("ShogunBug", 6, this.$SpawnPoint15$41103.transform.position, this.$SpawnPoint15$41103.transform.forward);
										if (200540 - 384549 != -184009)
										{
											continue;
										}
									}
								}
								else if (this.$$switch$7374$41104 == 7)
								{
									if (85313 - 537874 != -452561)
									{
										continue;
									}
									Debug.Log("Starting Round 7");
									if (227011 - 560281 != -333270)
									{
										continue;
									}
									if (this.$SpawnPoint1$41089)
									{
										if (133133 - 26816 != 106317)
										{
											continue;
										}
										this.$self_$41107.createActor("Phoenix1", 6, this.$SpawnPoint1$41089.transform.position, this.$SpawnPoint1$41089.transform.forward);
										if (228927 - 247714 != -18787)
										{
											continue;
										}
									}
									if (this.$SpawnPoint2$41090)
									{
										if (57017 - 143354 != -86337)
										{
											continue;
										}
										this.$self_$41107.createActor("Phoenix2", 6, this.$SpawnPoint2$41090.transform.position, this.$SpawnPoint2$41090.transform.forward);
										if (124372 - 243644 != -119272)
										{
											continue;
										}
									}
									if (this.$SpawnPoint3$41091)
									{
										if (206797 - 501697 == -294899)
										{
											continue;
										}
										this.$self_$41107.createActor("Phoenix3", 6, this.$SpawnPoint3$41091.transform.position, this.$SpawnPoint3$41091.transform.forward);
										if (147818 - 271080 == -123261)
										{
											continue;
										}
									}
									if (this.$SpawnPoint4$41092)
									{
										if (119146 - 16046 != 103100)
										{
											continue;
										}
										this.$self_$41107.createActor("Phoenix4", 6, this.$SpawnPoint4$41092.transform.position, this.$SpawnPoint4$41092.transform.forward);
										if (215209 - 332751 == -117541)
										{
											continue;
										}
									}
									if (this.$SpawnPoint5$41093)
									{
										if (87427 - 505116 == -417688)
										{
											continue;
										}
										this.$self_$41107.createActor("Phoenix3", 6, this.$SpawnPoint5$41093.transform.position, this.$SpawnPoint5$41093.transform.forward);
										if (88285 - 504912 != -416627)
										{
											continue;
										}
									}
									if (this.$SpawnPoint6$41094)
									{
										if (103703 - 382923 == -279219)
										{
											continue;
										}
										this.$self_$41107.createActor("Phoenix2", 6, this.$SpawnPoint6$41094.transform.position, this.$SpawnPoint6$41094.transform.forward);
										if (172289 - 134671 == 37619)
										{
											continue;
										}
									}
									if (this.$SpawnPoint7$41095)
									{
										if (247222 - 251554 != -4332)
										{
											continue;
										}
										this.$self_$41107.createActor("Gadina4", 6, this.$SpawnPoint7$41095.transform.position, this.$SpawnPoint7$41095.transform.forward);
										if (153267 - 534466 != -381199)
										{
											continue;
										}
									}
									if (this.$SpawnPoint8$41096)
									{
										if (284417 - 148993 == 135425)
										{
											continue;
										}
										this.$self_$41107.createActor("Gadina1", 6, this.$SpawnPoint8$41096.transform.position, this.$SpawnPoint8$41096.transform.forward);
										if (18031 - 230637 != -212606)
										{
											continue;
										}
									}
									if (this.$SpawnPoint9$41097)
									{
										if (163541 - 344868 != -181327)
										{
											continue;
										}
										this.$self_$41107.createActor("Gadina2", 6, this.$SpawnPoint9$41097.transform.position, this.$SpawnPoint9$41097.transform.forward);
										if (298438 - 16054 != 282384)
										{
											continue;
										}
									}
									if (this.$SpawnPoint10$41098)
									{
										if (282790 - 210782 != 72008)
										{
											continue;
										}
										this.$self_$41107.createActor("Gadina3", 6, this.$SpawnPoint10$41098.transform.position, this.$SpawnPoint10$41098.transform.forward);
										if (34460 - 246374 != -211914)
										{
											continue;
										}
									}
									if (this.$SpawnPoint11$41099)
									{
										if (209477 - 340071 == -130593)
										{
											continue;
										}
										this.$self_$41107.createActor("Gadina4", 6, this.$SpawnPoint11$41099.transform.position, this.$SpawnPoint11$41099.transform.forward);
										if (264353 - 215289 == 49065)
										{
											continue;
										}
									}
									if (this.$SpawnPoint12$41100)
									{
										if (54134 - 244445 == -190310)
										{
											continue;
										}
										this.$self_$41107.createActor("Gadina3", 6, this.$SpawnPoint12$41100.transform.position, this.$SpawnPoint12$41100.transform.forward);
										if (103352 - 585901 != -482549)
										{
											continue;
										}
									}
									if (this.$SpawnPoint13$41101)
									{
										if (42511 - 568493 != -525982)
										{
											continue;
										}
										this.$self_$41107.createActor("Gadina2", 6, this.$SpawnPoint13$41101.transform.position, this.$SpawnPoint13$41101.transform.forward);
										if (168130 - 371950 != -203820)
										{
											continue;
										}
									}
									if (this.$SpawnPoint14$41102)
									{
										if (260106 - 353039 == -92932)
										{
											continue;
										}
										this.$self_$41107.createActor("Gadina1", 6, this.$SpawnPoint14$41102.transform.position, this.$SpawnPoint14$41102.transform.forward);
										if (129557 - 64747 != 64810)
										{
											continue;
										}
									}
									if (this.$SpawnPoint15$41103)
									{
										if (165587 - 345113 != -179526)
										{
											continue;
										}
										this.$self_$41107.createActor("Phoenix4", 6, this.$SpawnPoint15$41103.transform.position, this.$SpawnPoint15$41103.transform.forward);
										if (251238 - 118546 != 132692)
										{
											continue;
										}
									}
								}
								else if (this.$$switch$7374$41104 == 8)
								{
									if (73810 - 576743 == -502932)
									{
										continue;
									}
									Debug.Log("Starting Round 8");
									if (273493 - 130036 == 143458)
									{
										continue;
									}
									if (this.$SpawnPoint1$41089)
									{
										if (8874 - 530798 == -521923)
										{
											continue;
										}
										this.$self_$41107.createActor("StingBug2_y", 6, this.$SpawnPoint1$41089.transform.position, this.$SpawnPoint1$41089.transform.forward);
										if (287253 - 242922 == 44332)
										{
											continue;
										}
									}
									if (this.$SpawnPoint2$41090)
									{
										if (161599 - 304143 == -142543)
										{
											continue;
										}
										this.$self_$41107.createActor("StingQueen", 6, this.$SpawnPoint2$41090.transform.position, this.$SpawnPoint2$41090.transform.forward);
										if (15311 - 424370 != -409059)
										{
											continue;
										}
									}
									if (this.$SpawnPoint3$41091)
									{
										if (101870 - 517812 == -415941)
										{
											continue;
										}
										this.$self_$41107.createActor("StingBug2_y", 6, this.$SpawnPoint3$41091.transform.position, this.$SpawnPoint3$41091.transform.forward);
										if (168409 - 431182 != -262773)
										{
											continue;
										}
									}
									if (this.$SpawnPoint4$41092)
									{
										if (201826 - 335315 == -133488)
										{
											continue;
										}
										this.$self_$41107.createActor("StingQueen", 6, this.$SpawnPoint4$41092.transform.position, this.$SpawnPoint4$41092.transform.forward);
										if (169439 - 563226 != -393787)
										{
											continue;
										}
									}
									if (this.$SpawnPoint5$41093)
									{
										if (157830 - 382393 != -224563)
										{
											continue;
										}
										this.$self_$41107.createActor("StingBug2_y", 6, this.$SpawnPoint5$41093.transform.position, this.$SpawnPoint5$41093.transform.forward);
										if (50875 - 507323 == -456447)
										{
											continue;
										}
									}
									if (this.$SpawnPoint6$41094)
									{
										if (70061 - 223730 == -153668)
										{
											continue;
										}
										this.$self_$41107.createActor("StingQueen", 6, this.$SpawnPoint6$41094.transform.position, this.$SpawnPoint6$41094.transform.forward);
										if (154057 - 563605 == -409547)
										{
											continue;
										}
									}
									if (this.$SpawnPoint7$41095)
									{
										if (293266 - 477019 == -183752)
										{
											continue;
										}
										this.$self_$41107.createActor("StingBug_g", 6, this.$SpawnPoint7$41095.transform.position, this.$SpawnPoint7$41095.transform.forward);
										if (194742 - 200934 != -6192)
										{
											continue;
										}
									}
									if (this.$SpawnPoint8$41096)
									{
										if (253971 - 34026 != 219945)
										{
											continue;
										}
										this.$self_$41107.createActor("StingBug_g", 6, this.$SpawnPoint8$41096.transform.position, this.$SpawnPoint8$41096.transform.forward);
										if (16140 - 45824 != -29684)
										{
											continue;
										}
									}
									if (this.$SpawnPoint9$41097)
									{
										if (259929 - 599529 == -339599)
										{
											continue;
										}
										this.$self_$41107.createActor("StingBug_r", 6, this.$SpawnPoint9$41097.transform.position, this.$SpawnPoint9$41097.transform.forward);
										if (174639 - 139130 != 35509)
										{
											continue;
										}
									}
									if (this.$SpawnPoint10$41098)
									{
										if (116012 - 454794 != -338782)
										{
											continue;
										}
										this.$self_$41107.createActor("StingBug_r", 6, this.$SpawnPoint10$41098.transform.position, this.$SpawnPoint10$41098.transform.forward);
										if (164263 - 47862 == 116402)
										{
											continue;
										}
									}
									if (this.$SpawnPoint11$41099)
									{
										if (11261 - 515100 != -503839)
										{
											continue;
										}
										this.$self_$41107.createActor("SandBug_r", 6, this.$SpawnPoint11$41099.transform.position, this.$SpawnPoint11$41099.transform.forward);
										if (145482 - 347780 != -202298)
										{
											continue;
										}
									}
									if (this.$SpawnPoint12$41100)
									{
										if (195737 - 571073 == -375335)
										{
											continue;
										}
										this.$self_$41107.createActor("SandBug_b", 6, this.$SpawnPoint12$41100.transform.position, this.$SpawnPoint12$41100.transform.forward);
										if (259635 - 151452 == 108184)
										{
											continue;
										}
									}
									if (this.$SpawnPoint13$41101)
									{
										if (182934 - 118695 != 64239)
										{
											continue;
										}
										this.$self_$41107.createActor("SandBug_k", 6, this.$SpawnPoint13$41101.transform.position, this.$SpawnPoint13$41101.transform.forward);
										if (43711 - 260356 != -216645)
										{
											continue;
										}
									}
									if (this.$SpawnPoint14$41102)
									{
										if (257912 - 370464 == -112551)
										{
											continue;
										}
										this.$self_$41107.createActor("SandBug_k", 6, this.$SpawnPoint14$41102.transform.position, this.$SpawnPoint14$41102.transform.forward);
										if (35147 - 260424 == -225276)
										{
											continue;
										}
									}
								}
								else if (this.$$switch$7374$41104 == 9)
								{
									if (297782 - 45952 == 251831)
									{
										continue;
									}
									Debug.Log("Starting Round 9");
									if (815 - 80517 != -79702)
									{
										continue;
									}
									if (this.$SpawnPoint1$41089)
									{
										if (90806 - 518061 != -427255)
										{
											continue;
										}
										this.$self_$41107.createActor("WormBug", 6, this.$SpawnPoint1$41089.transform.position, this.$SpawnPoint1$41089.transform.forward);
										if (10404 - 403706 == -393301)
										{
											continue;
										}
									}
									if (this.$SpawnPoint2$41090)
									{
										if (151233 - 336245 == -185011)
										{
											continue;
										}
										this.$self_$41107.createActor("WormBug", 6, this.$SpawnPoint2$41090.transform.position, this.$SpawnPoint2$41090.transform.forward);
										if (71121 - 502836 != -431715)
										{
											continue;
										}
									}
									if (this.$SpawnPoint4$41092)
									{
										if (196548 - 71450 != 125098)
										{
											continue;
										}
										this.$self_$41107.createActor("WormBug", 6, this.$SpawnPoint4$41092.transform.position, this.$SpawnPoint4$41092.transform.forward);
										if (52867 - 183188 != -130321)
										{
											continue;
										}
									}
									if (this.$SpawnPoint3$41091)
									{
										if (180765 - 221754 != -40989)
										{
											continue;
										}
										this.$self_$41107.createActor("WormBug_p", 6, this.$SpawnPoint3$41091.transform.position, this.$SpawnPoint3$41091.transform.forward);
										if (278678 - 266955 == 11724)
										{
											continue;
										}
									}
									if (this.$SpawnPoint5$41093)
									{
										if (273206 - 275076 != -1870)
										{
											continue;
										}
										this.$self_$41107.createActor("WormBug", 6, this.$SpawnPoint5$41093.transform.position, this.$SpawnPoint5$41093.transform.forward);
										if (283709 - 29392 == 254318)
										{
											continue;
										}
									}
									if (this.$SpawnPoint6$41094)
									{
										if (286794 - 480742 != -193948)
										{
											continue;
										}
										this.$self_$41107.createActor("WormBug_p", 6, this.$SpawnPoint6$41094.transform.position, this.$SpawnPoint6$41094.transform.forward);
										if (242038 - 531873 != -289835)
										{
											continue;
										}
									}
									if (this.$SpawnPoint7$41095)
									{
										if (252350 - 171191 != 81159)
										{
											continue;
										}
										this.$self_$41107.createActor("FudaBug_b", 6, this.$SpawnPoint7$41095.transform.position, this.$SpawnPoint7$41095.transform.forward);
										if (11036 - 245312 != -234276)
										{
											continue;
										}
									}
									if (this.$SpawnPoint8$41096)
									{
										if (268026 - 423116 == -155089)
										{
											continue;
										}
										this.$self_$41107.createActor("FudaBug_b", 6, this.$SpawnPoint8$41096.transform.position, this.$SpawnPoint8$41096.transform.forward);
										if (211556 - 550408 != -338852)
										{
											continue;
										}
									}
									if (this.$SpawnPoint14$41102)
									{
										if (232225 - 177261 == 54965)
										{
											continue;
										}
										this.$self_$41107.createActor("FudaBug_r", 6, this.$SpawnPoint14$41102.transform.position, this.$SpawnPoint14$41102.transform.forward);
										if (115495 - 581195 == -465699)
										{
											continue;
										}
									}
									if (this.$SpawnPoint10$41098)
									{
										if (113085 - 267022 != -153937)
										{
											continue;
										}
										this.$self_$41107.createActor("FudaBug_r", 6, this.$SpawnPoint10$41098.transform.position, this.$SpawnPoint10$41098.transform.forward);
										if (260796 - 151102 == 109695)
										{
											continue;
										}
									}
								}
								else if (this.$$switch$7374$41104 == 10)
								{
									if (159123 - 17187 == 141937)
									{
										continue;
									}
									Debug.Log("Starting Round 10");
									if (177016 - 206498 != -29482)
									{
										continue;
									}
									if (this.$SpawnPoint2$41090)
									{
										if (274785 - 43252 != 231533)
										{
											continue;
										}
										this.$self_$41107.createActor("Lizard", 6, this.$SpawnPoint2$41090.transform.position, this.$SpawnPoint2$41090.transform.forward);
										if (53998 - 60423 != -6425)
										{
											continue;
										}
									}
									if (this.$SpawnPoint3$41091)
									{
										if (191927 - 107346 != 84581)
										{
											continue;
										}
										this.$self_$41107.createActor("Turtle2", 6, this.$SpawnPoint3$41091.transform.position, this.$SpawnPoint3$41091.transform.forward);
										if (77505 - 508671 == -431165)
										{
											continue;
										}
									}
									if (this.$SpawnPoint5$41093)
									{
										if (294532 - 379961 != -85429)
										{
											continue;
										}
										this.$self_$41107.createActor("Turtle1", 6, this.$SpawnPoint5$41093.transform.position, this.$SpawnPoint5$41093.transform.forward);
										if (205815 - 583652 == -377836)
										{
											continue;
										}
									}
									if (this.$SpawnPoint6$41094)
									{
										if (193093 - 9175 != 183918)
										{
											continue;
										}
										this.$self_$41107.createActor("Alpaca", 6, this.$SpawnPoint6$41094.transform.position, this.$SpawnPoint6$41094.transform.forward);
										if (295773 - 280590 != 15183)
										{
											continue;
										}
									}
									if (this.$SpawnPoint7$41095)
									{
										if (274088 - 116146 == 157943)
										{
											continue;
										}
										this.$self_$41107.createActor("Mupo_g", 6, this.$SpawnPoint7$41095.transform.position, this.$SpawnPoint7$41095.transform.forward);
										if (61537 - 453027 != -391490)
										{
											continue;
										}
									}
									if (this.$SpawnPoint8$41096)
									{
										if (149482 - 195818 != -46336)
										{
											continue;
										}
										this.$self_$41107.createActor("Mupo_g", 6, this.$SpawnPoint8$41096.transform.position, this.$SpawnPoint8$41096.transform.forward);
										if (105896 - 217012 != -111116)
										{
											continue;
										}
									}
									if (this.$SpawnPoint10$41098)
									{
										if (42371 - 349631 == -307259)
										{
											continue;
										}
										this.$self_$41107.createActor("Mupo_r", 6, this.$SpawnPoint10$41098.transform.position, this.$SpawnPoint10$41098.transform.forward);
										if (20816 - 273414 == -252597)
										{
											continue;
										}
									}
									if (this.$SpawnPoint11$41099)
									{
										if (270898 - 554599 != -283701)
										{
											continue;
										}
										this.$self_$41107.createActor("Mupo_r", 6, this.$SpawnPoint11$41099.transform.position, this.$SpawnPoint11$41099.transform.forward);
										if (197549 - 63374 != 134175)
										{
											continue;
										}
									}
									if (this.$SpawnPoint12$41100)
									{
										if (286405 - 465290 != -178885)
										{
											continue;
										}
										this.$self_$41107.createActor("Mupo_r", 6, this.$SpawnPoint12$41100.transform.position, this.$SpawnPoint12$41100.transform.forward);
										if (117909 - 379507 != -261598)
										{
											continue;
										}
									}
									if (this.$SpawnPoint14$41102)
									{
										if (142903 - 564391 == -421487)
										{
											continue;
										}
										this.$self_$41107.createActor("Mupo_g", 6, this.$SpawnPoint14$41102.transform.position, this.$SpawnPoint14$41102.transform.forward);
										if (12119 - 598869 == -586749)
										{
											continue;
										}
									}
								}
								else if (this.$$switch$7374$41104 == 11)
								{
									if (216225 - 37220 == 179006)
									{
										continue;
									}
									Debug.Log("Starting Round 11");
									if (108339 - 598649 != -490310)
									{
										continue;
									}
									if (this.$SpawnPoint1$41089)
									{
										if (268378 - 78397 != 189981)
										{
											continue;
										}
										this.$self_$41107.createActor("Shade3", 6, this.$SpawnPoint1$41089.transform.position, this.$SpawnPoint1$41089.transform.forward);
										if (23960 - 490269 != -466309)
										{
											continue;
										}
									}
									if (this.$SpawnPoint2$41090)
									{
										if (192215 - 75172 == 117044)
										{
											continue;
										}
										this.$self_$41107.createActor("Vizie3", 6, this.$SpawnPoint2$41090.transform.position, this.$SpawnPoint2$41090.transform.forward);
										if (274160 - 291773 != -17613)
										{
											continue;
										}
									}
									if (this.$SpawnPoint3$41091)
									{
										if (250027 - 387050 != -137023)
										{
											continue;
										}
										this.$self_$41107.createActor("Shade3", 6, this.$SpawnPoint3$41091.transform.position, this.$SpawnPoint3$41091.transform.forward);
										if (211488 - 437351 == -225862)
										{
											continue;
										}
									}
									if (this.$SpawnPoint4$41092)
									{
										if (202730 - 512937 == -310206)
										{
											continue;
										}
										this.$self_$41107.createActor("Vizie3", 6, this.$SpawnPoint4$41092.transform.position, this.$SpawnPoint4$41092.transform.forward);
										if (135218 - 92139 != 43079)
										{
											continue;
										}
									}
									if (this.$SpawnPoint5$41093)
									{
										if (278759 - 318516 == -39756)
										{
											continue;
										}
										this.$self_$41107.createActor("Shade3", 6, this.$SpawnPoint5$41093.transform.position, this.$SpawnPoint5$41093.transform.forward);
										if (120030 - 273226 == -153195)
										{
											continue;
										}
									}
									if (this.$SpawnPoint6$41094)
									{
										if (118912 - 251095 != -132183)
										{
											continue;
										}
										this.$self_$41107.createActor("Vizie3", 6, this.$SpawnPoint6$41094.transform.position, this.$SpawnPoint6$41094.transform.forward);
										if (156525 - 90907 != 65618)
										{
											continue;
										}
									}
									if (this.$SpawnPoint7$41095)
									{
										if (121862 - 258756 == -136893)
										{
											continue;
										}
										this.$self_$41107.createActor("Vizie2", 6, this.$SpawnPoint7$41095.transform.position, this.$SpawnPoint7$41095.transform.forward);
										if (11906 - 314853 == -302946)
										{
											continue;
										}
									}
									if (this.$SpawnPoint8$41096)
									{
										if (49974 - 243767 != -193793)
										{
											continue;
										}
										this.$self_$41107.createActor("Shade2", 6, this.$SpawnPoint8$41096.transform.position, this.$SpawnPoint8$41096.transform.forward);
										if (20315 - 46110 == -25794)
										{
											continue;
										}
									}
									if (this.$SpawnPoint9$41097)
									{
										if (228768 - 293940 == -65171)
										{
											continue;
										}
										this.$self_$41107.createActor("Vizie1", 6, this.$SpawnPoint9$41097.transform.position, this.$SpawnPoint9$41097.transform.forward);
										if (142096 - 9227 == 132870)
										{
											continue;
										}
									}
									if (this.$SpawnPoint10$41098)
									{
										if (157904 - 576101 == -418196)
										{
											continue;
										}
										this.$self_$41107.createActor("Shade1", 6, this.$SpawnPoint10$41098.transform.position, this.$SpawnPoint10$41098.transform.forward);
										if (198369 - 512845 != -314476)
										{
											continue;
										}
									}
									if (this.$SpawnPoint11$41099)
									{
										if (282634 - 252494 == 30141)
										{
											continue;
										}
										this.$self_$41107.createActor("Vizie2", 6, this.$SpawnPoint11$41099.transform.position, this.$SpawnPoint11$41099.transform.forward);
										if (295233 - 284386 == 10848)
										{
											continue;
										}
									}
									if (this.$SpawnPoint12$41100)
									{
										if (236894 - 168518 != 68376)
										{
											continue;
										}
										this.$self_$41107.createActor("Shade2", 6, this.$SpawnPoint12$41100.transform.position, this.$SpawnPoint12$41100.transform.forward);
										if (4918 - 593030 != -588112)
										{
											continue;
										}
									}
									if (this.$SpawnPoint13$41101)
									{
										if (35710 - 322384 != -286674)
										{
											continue;
										}
										this.$self_$41107.createActor("Vizie1", 6, this.$SpawnPoint13$41101.transform.position, this.$SpawnPoint13$41101.transform.forward);
										if (41617 - 575324 == -533706)
										{
											continue;
										}
									}
									if (this.$SpawnPoint14$41102)
									{
										if (284986 - 475079 == -190092)
										{
											continue;
										}
										this.$self_$41107.createActor("Shade1", 6, this.$SpawnPoint14$41102.transform.position, this.$SpawnPoint14$41102.transform.forward);
										if (87631 - 132167 != -44536)
										{
											continue;
										}
									}
									if (this.$SpawnPoint15$41103)
									{
										if (9727 - 281345 == -271617)
										{
											continue;
										}
										this.$self_$41107.createActor("Vizie4", 6, this.$SpawnPoint15$41103.transform.position, this.$SpawnPoint15$41103.transform.forward);
										if (179330 - 581519 == -402188)
										{
											continue;
										}
									}
								}
								else if (this.$$switch$7374$41104 == 12)
								{
									if (207754 - 37771 != 169983)
									{
										continue;
									}
									Debug.Log("Starting Round 12");
									if (260397 - 103036 == 157362)
									{
										continue;
									}
									if (this.$SpawnPoint1$41089)
									{
										if (48521 - 194936 != -146415)
										{
											continue;
										}
										this.$self_$41107.createActor("Carron", 6, this.$SpawnPoint1$41089.transform.position, this.$SpawnPoint1$41089.transform.forward);
										if (65567 - 80620 != -15053)
										{
											continue;
										}
									}
									if (this.$SpawnPoint2$41090)
									{
										if (98471 - 597824 == -499352)
										{
											continue;
										}
										this.$self_$41107.createActor("Peppon", 6, this.$SpawnPoint2$41090.transform.position, this.$SpawnPoint2$41090.transform.forward);
										if (107919 - 119625 != -11706)
										{
											continue;
										}
									}
									if (this.$SpawnPoint3$41091)
									{
										if (147635 - 362909 == -215273)
										{
											continue;
										}
										this.$self_$41107.createActor("Cacton", 6, this.$SpawnPoint3$41091.transform.position, this.$SpawnPoint3$41091.transform.forward);
										if (237429 - 256491 != -19062)
										{
											continue;
										}
									}
									if (this.$SpawnPoint5$41093)
									{
										if (115964 - 266768 == -150803)
										{
											continue;
										}
										this.$self_$41107.createActor("Cocon", 6, this.$SpawnPoint5$41093.transform.position, this.$SpawnPoint5$41093.transform.forward);
										if (36786 - 509996 == -473209)
										{
											continue;
										}
									}
									if (this.$SpawnPoint6$41094)
									{
										if (277180 - 492964 == -215783)
										{
											continue;
										}
										this.$self_$41107.createActor("Pumpkon", 6, this.$SpawnPoint6$41094.transform.position, this.$SpawnPoint6$41094.transform.forward);
										if (254724 - 5209 != 249515)
										{
											continue;
										}
									}
									if (this.$SpawnPoint8$41096)
									{
										if (35667 - 98822 == -63154)
										{
											continue;
										}
										this.$self_$41107.createActor("PumpkonKing", 6, this.$SpawnPoint8$41096.transform.position, this.$SpawnPoint8$41096.transform.forward);
										if (231260 - 391540 != -160280)
										{
											continue;
										}
									}
									if (this.$SpawnPoint10$41098)
									{
										if (99836 - 105783 != -5947)
										{
											continue;
										}
										this.$self_$41107.createActor("PumpkonKing", 6, this.$SpawnPoint10$41098.transform.position, this.$SpawnPoint10$41098.transform.forward);
										if (249009 - 31563 != 217446)
										{
											continue;
										}
									}
									if (this.$SpawnPoint12$41100)
									{
										if (249368 - 540596 == -291227)
										{
											continue;
										}
										this.$self_$41107.createActor("PumpkonKing", 6, this.$SpawnPoint12$41100.transform.position, this.$SpawnPoint12$41100.transform.forward);
										if (157009 - 25565 == 131445)
										{
											continue;
										}
									}
									if (this.$SpawnPoint14$41102)
									{
										if (157573 - 511424 != -353851)
										{
											continue;
										}
										this.$self_$41107.createActor("PumpkonKing", 6, this.$SpawnPoint14$41102.transform.position, this.$SpawnPoint14$41102.transform.forward);
										if (2702 - 115529 != -112827)
										{
											continue;
										}
									}
									if (this.$SpawnPoint15$41103)
									{
										if (297884 - 334110 == -36225)
										{
											continue;
										}
										this.$self_$41107.createActor("GoatFarmer", 6, this.$SpawnPoint15$41103.transform.position, this.$SpawnPoint15$41103.transform.forward);
										if (60460 - 158729 != -98269)
										{
											continue;
										}
									}
								}
								else if (this.$$switch$7374$41104 == 13)
								{
									if (277500 - 225653 != 51847)
									{
										continue;
									}
									Debug.Log("Starting Round 13");
									if (6533 - 336009 != -329476)
									{
										continue;
									}
									if (this.$SpawnPoint1$41089)
									{
										if (96643 - 481857 != -385214)
										{
											continue;
										}
										this.$self_$41107.createActor("Ammonite", 6, this.$SpawnPoint1$41089.transform.position, this.$SpawnPoint1$41089.transform.forward);
										if (147703 - 557307 != -409604)
										{
											continue;
										}
									}
									if (this.$SpawnPoint2$41090)
									{
										if (112976 - 180936 != -67960)
										{
											continue;
										}
										this.$self_$41107.createActor("NeonBug", 6, this.$SpawnPoint2$41090.transform.position, this.$SpawnPoint2$41090.transform.forward);
										if (284517 - 494343 != -209826)
										{
											continue;
										}
									}
									if (this.$SpawnPoint3$41091)
									{
										if (88129 - 573551 == -485421)
										{
											continue;
										}
										this.$self_$41107.createActor("Ammonite", 6, this.$SpawnPoint3$41091.transform.position, this.$SpawnPoint3$41091.transform.forward);
										if (142932 - 344981 == -202048)
										{
											continue;
										}
									}
									if (this.$SpawnPoint4$41092)
									{
										if (247147 - 252182 != -5035)
										{
											continue;
										}
										this.$self_$41107.createActor("NeonBug", 6, this.$SpawnPoint4$41092.transform.position, this.$SpawnPoint4$41092.transform.forward);
										if (220106 - 210648 == 9459)
										{
											continue;
										}
									}
									if (this.$SpawnPoint5$41093)
									{
										if (94818 - 267428 != -172610)
										{
											continue;
										}
										this.$self_$41107.createActor("Ammonite", 6, this.$SpawnPoint5$41093.transform.position, this.$SpawnPoint5$41093.transform.forward);
										if (129225 - 276465 == -147239)
										{
											continue;
										}
									}
									if (this.$SpawnPoint6$41094)
									{
										if (204150 - 558904 != -354754)
										{
											continue;
										}
										this.$self_$41107.createActor("NeonBug", 6, this.$SpawnPoint6$41094.transform.position, this.$SpawnPoint6$41094.transform.forward);
										if (41145 - 92110 == -50964)
										{
											continue;
										}
									}
									if (this.$SpawnPoint8$41096)
									{
										if (65775 - 584882 == -519106)
										{
											continue;
										}
										this.$self_$41107.createActor("WaterBug", 6, this.$SpawnPoint8$41096.transform.position, this.$SpawnPoint8$41096.transform.forward);
										if (133588 - 187068 != -53480)
										{
											continue;
										}
									}
									if (this.$SpawnPoint9$41097)
									{
										if (159849 - 33570 != 126279)
										{
											continue;
										}
										this.$self_$41107.createActor("WaterBug", 6, this.$SpawnPoint9$41097.transform.position, this.$SpawnPoint9$41097.transform.forward);
										if (261244 - 251487 != 9757)
										{
											continue;
										}
									}
									if (this.$SpawnPoint10$41098)
									{
										if (8023 - 426425 != -418402)
										{
											continue;
										}
										this.$self_$41107.createActor("WaterBug", 6, this.$SpawnPoint10$41098.transform.position, this.$SpawnPoint10$41098.transform.forward);
										if (142432 - 437930 != -295498)
										{
											continue;
										}
									}
									if (this.$SpawnPoint12$41100)
									{
										if (67658 - 54092 != 13566)
										{
											continue;
										}
										this.$self_$41107.createActor("WaterBug", 6, this.$SpawnPoint12$41100.transform.position, this.$SpawnPoint12$41100.transform.forward);
										if (10779 - 492745 == -481965)
										{
											continue;
										}
									}
									if (this.$SpawnPoint13$41101)
									{
										if (15565 - 343677 == -328111)
										{
											continue;
										}
										this.$self_$41107.createActor("WaterBug", 6, this.$SpawnPoint13$41101.transform.position, this.$SpawnPoint13$41101.transform.forward);
										if (117551 - 97431 != 20120)
										{
											continue;
										}
									}
									if (this.$SpawnPoint14$41102)
									{
										if (29957 - 14761 != 15196)
										{
											continue;
										}
										this.$self_$41107.createActor("WaterBug", 6, this.$SpawnPoint14$41102.transform.position, this.$SpawnPoint14$41102.transform.forward);
										if (83195 - 516631 != -433436)
										{
											continue;
										}
									}
								}
								else if (this.$$switch$7374$41104 == 14)
								{
									if (237580 - 293278 != -55698)
									{
										continue;
									}
									Debug.Log("Starting Round 14");
									if (235650 - 529202 != -293552)
									{
										continue;
									}
									if (this.$SpawnPoint1$41089)
									{
										if (243485 - 417719 != -174234)
										{
											continue;
										}
										this.$self_$41107.createActor("LeoBug_g", 6, this.$SpawnPoint1$41089.transform.position, this.$SpawnPoint1$41089.transform.forward);
										if (86620 - 429457 == -342836)
										{
											continue;
										}
									}
									if (this.$SpawnPoint2$41090)
									{
										if (138329 - 252699 != -114370)
										{
											continue;
										}
										this.$self_$41107.createActor("LeoBug_p", 6, this.$SpawnPoint2$41090.transform.position, this.$SpawnPoint2$41090.transform.forward);
										if (105785 - 281941 == -176155)
										{
											continue;
										}
									}
									if (this.$SpawnPoint3$41091)
									{
										if (18361 - 293985 != -275624)
										{
											continue;
										}
										this.$self_$41107.createActor("LeoBug_g", 6, this.$SpawnPoint3$41091.transform.position, this.$SpawnPoint3$41091.transform.forward);
										if (149979 - 93833 == 56147)
										{
											continue;
										}
									}
									if (this.$SpawnPoint4$41092)
									{
										if (51719 - 333436 == -281716)
										{
											continue;
										}
										this.$self_$41107.createActor("LeoBug_p", 6, this.$SpawnPoint4$41092.transform.position, this.$SpawnPoint4$41092.transform.forward);
										if (202931 - 342224 != -139293)
										{
											continue;
										}
									}
									if (this.$SpawnPoint7$41095)
									{
										if (232637 - 117671 == 114967)
										{
											continue;
										}
										this.$self_$41107.createActor("LionBug_b", 6, this.$SpawnPoint7$41095.transform.position, this.$SpawnPoint7$41095.transform.forward);
										if (193472 - 167144 != 26328)
										{
											continue;
										}
									}
									if (this.$SpawnPoint8$41096)
									{
										if (155813 - 536896 != -381083)
										{
											continue;
										}
										this.$self_$41107.createActor("LionBug_y", 6, this.$SpawnPoint8$41096.transform.position, this.$SpawnPoint8$41096.transform.forward);
										if (6783 - 112088 == -105304)
										{
											continue;
										}
									}
									if (this.$SpawnPoint9$41097)
									{
										if (137668 - 145801 == -8132)
										{
											continue;
										}
										this.$self_$41107.createActor("LionBug_b", 6, this.$SpawnPoint9$41097.transform.position, this.$SpawnPoint9$41097.transform.forward);
										if (107772 - 598568 != -490796)
										{
											continue;
										}
									}
									if (this.$SpawnPoint10$41098)
									{
										if (149654 - 372332 == -222677)
										{
											continue;
										}
										this.$self_$41107.createActor("LionBug_y", 6, this.$SpawnPoint10$41098.transform.position, this.$SpawnPoint10$41098.transform.forward);
										if (236415 - 46110 == 190306)
										{
											continue;
										}
									}
									if (this.$SpawnPoint11$41099)
									{
										if (221841 - 357375 == -135533)
										{
											continue;
										}
										this.$self_$41107.createActor("LionBug_b", 6, this.$SpawnPoint11$41099.transform.position, this.$SpawnPoint11$41099.transform.forward);
										if (88952 - 360009 != -271057)
										{
											continue;
										}
									}
									if (this.$SpawnPoint12$41100)
									{
										if (79763 - 114150 != -34387)
										{
											continue;
										}
										this.$self_$41107.createActor("LionBug_y", 6, this.$SpawnPoint12$41100.transform.position, this.$SpawnPoint12$41100.transform.forward);
										if (181853 - 214823 == -32969)
										{
											continue;
										}
									}
									if (this.$SpawnPoint13$41101)
									{
										if (195015 - 183137 != 11878)
										{
											continue;
										}
										this.$self_$41107.createActor("LionBug_b", 6, this.$SpawnPoint13$41101.transform.position, this.$SpawnPoint13$41101.transform.forward);
										if (241831 - 92236 == 149596)
										{
											continue;
										}
									}
									if (this.$SpawnPoint14$41102)
									{
										if (118336 - 182059 == -63722)
										{
											continue;
										}
										this.$self_$41107.createActor("LionBug_y", 6, this.$SpawnPoint14$41102.transform.position, this.$SpawnPoint14$41102.transform.forward);
										if (76197 - 591163 != -514966)
										{
											continue;
										}
									}
									if (this.$SpawnPoint15$41103)
									{
										if (215324 - 515983 != -300659)
										{
											continue;
										}
										this.$self_$41107.createActor("LionBug_g", 6, this.$SpawnPoint15$41103.transform.position, this.$SpawnPoint15$41103.transform.forward);
										if (185633 - 515379 != -329746)
										{
											continue;
										}
									}
								}
								else if (this.$$switch$7374$41104 == 15)
								{
									if (239449 - 41622 == 197828)
									{
										continue;
									}
									Debug.Log("Starting Round 15");
									if (219836 - 497029 != -277193)
									{
										continue;
									}
									if (this.$SpawnPoint1$41089)
									{
										if (200348 - 410040 != -209692)
										{
											continue;
										}
										this.$self_$41107.createActor("Ja4", 6, this.$SpawnPoint1$41089.transform.position, this.$SpawnPoint1$41089.transform.forward);
										if (204468 - 419620 != -215152)
										{
											continue;
										}
									}
									if (this.$SpawnPoint2$41090)
									{
										if (91557 - 128470 != -36913)
										{
											continue;
										}
										this.$self_$41107.createActor("Ja5", 6, this.$SpawnPoint2$41090.transform.position, this.$SpawnPoint2$41090.transform.forward);
										if (140274 - 112999 != 27275)
										{
											continue;
										}
									}
									if (this.$SpawnPoint3$41091)
									{
										if (183256 - 264984 != -81728)
										{
											continue;
										}
										this.$self_$41107.createActor("Ja5", 6, this.$SpawnPoint3$41091.transform.position, this.$SpawnPoint3$41091.transform.forward);
										if (130374 - 572662 != -442288)
										{
											continue;
										}
									}
									if (this.$SpawnPoint4$41092)
									{
										if (810 - 251715 != -250905)
										{
											continue;
										}
										this.$self_$41107.createActor("Ja4", 6, this.$SpawnPoint4$41092.transform.position, this.$SpawnPoint4$41092.transform.forward);
										if (168467 - 16139 == 152329)
										{
											continue;
										}
									}
									if (this.$SpawnPoint5$41093)
									{
										if (125374 - 579957 == -454582)
										{
											continue;
										}
										this.$self_$41107.createActor("Ja5", 6, this.$SpawnPoint5$41093.transform.position, this.$SpawnPoint5$41093.transform.forward);
										if (6775 - 326965 != -320190)
										{
											continue;
										}
									}
									if (this.$SpawnPoint6$41094)
									{
										if (136062 - 115187 != 20875)
										{
											continue;
										}
										this.$self_$41107.createActor("Ja5", 6, this.$SpawnPoint6$41094.transform.position, this.$SpawnPoint6$41094.transform.forward);
										if (25572 - 435987 != -410415)
										{
											continue;
										}
									}
									if (this.$SpawnPoint7$41095)
									{
										if (218782 - 141425 != 77357)
										{
											continue;
										}
										this.$self_$41107.createActor("Ja1", 6, this.$SpawnPoint7$41095.transform.position, this.$SpawnPoint7$41095.transform.forward);
										if (112659 - 197025 != -84366)
										{
											continue;
										}
									}
									if (this.$SpawnPoint8$41096)
									{
										if (19452 - 240884 != -221432)
										{
											continue;
										}
										this.$self_$41107.createActor("Ja2", 6, this.$SpawnPoint8$41096.transform.position, this.$SpawnPoint8$41096.transform.forward);
										if (191009 - 283330 != -92321)
										{
											continue;
										}
									}
									if (this.$SpawnPoint9$41097)
									{
										if (243964 - 313187 == -69222)
										{
											continue;
										}
										this.$self_$41107.createActor("Ja3", 6, this.$SpawnPoint9$41097.transform.position, this.$SpawnPoint9$41097.transform.forward);
										if (129385 - 470445 != -341060)
										{
											continue;
										}
									}
									if (this.$SpawnPoint10$41098)
									{
										if (295121 - 495998 == -200876)
										{
											continue;
										}
										this.$self_$41107.createActor("Ja4", 6, this.$SpawnPoint10$41098.transform.position, this.$SpawnPoint10$41098.transform.forward);
										if (176359 - 519258 != -342899)
										{
											continue;
										}
									}
									if (this.$SpawnPoint11$41099)
									{
										if (209082 - 504466 == -295383)
										{
											continue;
										}
										this.$self_$41107.createActor("Ja1", 6, this.$SpawnPoint11$41099.transform.position, this.$SpawnPoint12$41100.transform.forward);
										if (19716 - 572417 == -552700)
										{
											continue;
										}
									}
									if (this.$SpawnPoint12$41100)
									{
										if (106907 - 494819 != -387912)
										{
											continue;
										}
										this.$self_$41107.createActor("Ja2", 6, this.$SpawnPoint12$41100.transform.position, this.$SpawnPoint12$41100.transform.forward);
										if (167738 - 18432 != 149306)
										{
											continue;
										}
									}
									if (this.$SpawnPoint13$41101)
									{
										if (251779 - 151566 == 100214)
										{
											continue;
										}
										this.$self_$41107.createActor("Ja3", 6, this.$SpawnPoint13$41101.transform.position, this.$SpawnPoint13$41101.transform.forward);
										if (288823 - 566325 != -277502)
										{
											continue;
										}
									}
									if (this.$SpawnPoint14$41102)
									{
										if (126373 - 110595 != 15778)
										{
											continue;
										}
										this.$self_$41107.createActor("Ja4", 6, this.$SpawnPoint14$41102.transform.position, this.$SpawnPoint14$41102.transform.forward);
										if (260983 - 2635 != 258348)
										{
											continue;
										}
									}
									if (this.$SpawnPoint15$41103)
									{
										if (267669 - 370566 == -102896)
										{
											continue;
										}
										this.$self_$41107.createActor("Ja6", 6, this.$SpawnPoint15$41103.transform.position, this.$SpawnPoint14$41102.transform.forward);
										if (111575 - 567492 == -455916)
										{
											continue;
										}
									}
								}
								else if (this.$$switch$7374$41104 == 16)
								{
									if (90666 - 382354 != -291688)
									{
										continue;
									}
									Debug.Log("Starting Round 16");
									if (32614 - 387440 == -354825)
									{
										continue;
									}
									if (this.$SpawnPoint1$41089)
									{
										if (126632 - 493871 == -367238)
										{
											continue;
										}
										this.$self_$41107.createActor("Liger", 7, this.$SpawnPoint1$41089.transform.position, this.$SpawnPoint1$41089.transform.forward);
										if (154673 - 354292 == -199618)
										{
											continue;
										}
									}
									if (this.$SpawnPoint3$41091)
									{
										if (124991 - 35085 != 89906)
										{
											continue;
										}
										this.$self_$41107.createActor("Falcon", 7, this.$SpawnPoint3$41091.transform.position, this.$SpawnPoint3$41091.transform.forward);
										if (185388 - 421394 != -236006)
										{
											continue;
										}
									}
									if (this.$SpawnPoint5$41093)
									{
										if (272310 - 532646 == -260335)
										{
											continue;
										}
										this.$self_$41107.createActor("Walrus", 7, this.$SpawnPoint5$41093.transform.position, this.$SpawnPoint5$41093.transform.forward);
										if (22196 - 9006 == 13191)
										{
											continue;
										}
									}
									if (this.$SpawnPoint7$41095)
									{
										if (162906 - 71530 != 91376)
										{
											continue;
										}
										this.$self_$41107.createActor("Panther", 7, this.$SpawnPoint7$41095.transform.position, this.$SpawnPoint7$41095.transform.forward);
										if (228016 - 192595 != 35421)
										{
											continue;
										}
									}
									if (this.$SpawnPoint8$41096)
									{
										if (221002 - 547336 == -326333)
										{
											continue;
										}
										this.$self_$41107.createActor("Leopard", 7, this.$SpawnPoint8$41096.transform.position, this.$SpawnPoint8$41096.transform.forward);
										if (214334 - 448182 != -233848)
										{
											continue;
										}
									}
									if (this.$SpawnPoint9$41097)
									{
										if (9130 - 304047 == -294916)
										{
											continue;
										}
										this.$self_$41107.createActor("Panther", 7, this.$SpawnPoint9$41097.transform.position, this.$SpawnPoint9$41097.transform.forward);
										if (163053 - 508469 != -345416)
										{
											continue;
										}
									}
									if (this.$SpawnPoint10$41098)
									{
										if (98351 - 459536 != -361185)
										{
											continue;
										}
										this.$self_$41107.createActor("Leopard", 7, this.$SpawnPoint10$41098.transform.position, this.$SpawnPoint10$41098.transform.forward);
										if (202131 - 354634 != -152503)
										{
											continue;
										}
									}
									if (this.$SpawnPoint11$41099)
									{
										if (247440 - 367553 != -120113)
										{
											continue;
										}
										this.$self_$41107.createActor("Panther", 7, this.$SpawnPoint11$41099.transform.position, this.$SpawnPoint12$41100.transform.forward);
										if (109704 - 448100 == -338395)
										{
											continue;
										}
									}
									if (this.$SpawnPoint12$41100)
									{
										if (136810 - 457902 != -321092)
										{
											continue;
										}
										this.$self_$41107.createActor("Leopard", 7, this.$SpawnPoint12$41100.transform.position, this.$SpawnPoint12$41100.transform.forward);
										if (137685 - 578341 != -440656)
										{
											continue;
										}
									}
									if (this.$SpawnPoint13$41101)
									{
										if (161617 - 44423 != 117194)
										{
											continue;
										}
										this.$self_$41107.createActor("Panther", 7, this.$SpawnPoint13$41101.transform.position, this.$SpawnPoint13$41101.transform.forward);
										if (84428 - 334106 != -249678)
										{
											continue;
										}
									}
									if (this.$SpawnPoint14$41102)
									{
										if (94908 - 161778 == -66869)
										{
											continue;
										}
										this.$self_$41107.createActor("Leopard", 7, this.$SpawnPoint14$41102.transform.position, this.$SpawnPoint14$41102.transform.forward);
										if (161594 - 116143 != 45451)
										{
											continue;
										}
									}
								}
							}
						}
						else if (this.$$switch$7378$41086 == 8082)
						{
							if (171558 - 141462 == 30097)
							{
								continue;
							}
							this.$$switch$7376$41105 = this.$returnValue$41084;
							if (196762 - 72448 == 124315)
							{
								continue;
							}
							if (this.$$switch$7376$41105 == 1)
							{
								if (115646 - 598172 != -482526)
								{
									continue;
								}
								this.$self_$41107.KMxn5nGlCwe = this.$self_$41107.KMxn5nGlCwe + 1;
								if (131554 - 245739 != -114185)
								{
									continue;
								}
								this.$self_$41107.SendMessage("newGameMessage", "Round 1 - Monster eliminated:" + this.$self_$41107.KMxn5nGlCwe + "/13");
								if (288193 - 352047 == -63853)
								{
									continue;
								}
								if (this.$self_$41107.KMxn5nGlCwe >= 13)
								{
									if (19950 - 307155 == -287204)
									{
										continue;
									}
									if (this.$self_$41107.o8vn5cQ008O < 2)
									{
										if (69515 - 59928 != 9587)
										{
											continue;
										}
										Game.sendMissionEvent(8081, 2);
										if (37697 - 348630 != -310933)
										{
											continue;
										}
									}
								}
							}
							else if (this.$$switch$7376$41105 == 2)
							{
								if (139820 - 37260 == 102561)
								{
									continue;
								}
								this.$self_$41107.hVBn5Qh36s4 = this.$self_$41107.hVBn5Qh36s4 + 1;
								if (46113 - 493599 == -447485)
								{
									continue;
								}
								this.$self_$41107.SendMessage("newGameMessage", "Round 2 - Monster eliminated:" + this.$self_$41107.hVBn5Qh36s4 + "/14");
								if (187492 - 275962 != -88470)
								{
									continue;
								}
								if (this.$self_$41107.hVBn5Qh36s4 >= 14)
								{
									if (182296 - 578222 == -395925)
									{
										continue;
									}
									if (this.$self_$41107.o8vn5cQ008O < 3)
									{
										if (5708 - 540979 == -535270)
										{
											continue;
										}
										Game.sendMissionEvent(8081, 3);
										if (38271 - 515963 != -477692)
										{
											continue;
										}
									}
								}
							}
							else if (this.$$switch$7376$41105 == 3)
							{
								if (167677 - 551481 != -383804)
								{
									continue;
								}
								this.$self_$41107.thLn5e9dgVZ = this.$self_$41107.thLn5e9dgVZ + 1;
								if (11349 - 95118 == -83768)
								{
									continue;
								}
								this.$self_$41107.SendMessage("newGameMessage", "Round 3 - Monster eliminated:" + this.$self_$41107.thLn5e9dgVZ + "/14");
								if (299389 - 332108 != -32719)
								{
									continue;
								}
								if (this.$self_$41107.thLn5e9dgVZ >= 14)
								{
									if (264344 - 475140 == -210795)
									{
										continue;
									}
									if (this.$self_$41107.o8vn5cQ008O < 4)
									{
										if (188346 - 505164 != -316818)
										{
											continue;
										}
										Game.sendMissionEvent(8081, 4);
										if (269927 - 334485 != -64558)
										{
											continue;
										}
									}
								}
							}
							else if (this.$$switch$7376$41105 == 4)
							{
								if (76233 - 45963 == 30271)
								{
									continue;
								}
								this.$self_$41107.x9rn5IkZJ8O = this.$self_$41107.x9rn5IkZJ8O + 1;
								if (226744 - 556379 == -329634)
								{
									continue;
								}
								this.$self_$41107.SendMessage("newGameMessage", "Round 4 - Monster eliminated:" + this.$self_$41107.x9rn5IkZJ8O + "/15");
								if (157047 - 408667 == -251619)
								{
									continue;
								}
								if (this.$self_$41107.x9rn5IkZJ8O >= 15)
								{
									if (197671 - 120688 == 76984)
									{
										continue;
									}
									if (this.$self_$41107.o8vn5cQ008O < 5)
									{
										if (36361 - 464583 == -428221)
										{
											continue;
										}
										Game.sendMissionEvent(8081, 5);
										if (235491 - 554089 == -318597)
										{
											continue;
										}
									}
								}
							}
							else if (this.$$switch$7376$41105 == 5)
							{
								if (22692 - 163913 != -141221)
								{
									continue;
								}
								this.$self_$41107.lNBn5JWwUcI = this.$self_$41107.lNBn5JWwUcI + 1;
								if (46511 - 517617 != -471106)
								{
									continue;
								}
								this.$self_$41107.SendMessage("newGameMessage", "Round 5 - Monster eliminated:" + this.$self_$41107.lNBn5JWwUcI + "/8");
								if (284483 - 187936 != 96547)
								{
									continue;
								}
								if (this.$self_$41107.lNBn5JWwUcI >= 8)
								{
									if (260578 - 145374 == 115205)
									{
										continue;
									}
									if (this.$self_$41107.o8vn5cQ008O < 6)
									{
										if (73245 - 5439 == 67807)
										{
											continue;
										}
										Game.sendMissionEvent(8081, 6);
										if (66424 - 8332 == 58093)
										{
											continue;
										}
									}
								}
							}
							else if (this.$$switch$7376$41105 == 6)
							{
								if (29048 - 202085 != -173037)
								{
									continue;
								}
								this.$self_$41107.UCNn56WBkZZ = this.$self_$41107.UCNn56WBkZZ + 1;
								if (279476 - 433434 == -153957)
								{
									continue;
								}
								this.$self_$41107.SendMessage("newGameMessage", "Round 6 - Monster eliminated:" + this.$self_$41107.UCNn56WBkZZ + "/14");
								if (78134 - 173194 == -95059)
								{
									continue;
								}
								if (this.$self_$41107.UCNn56WBkZZ >= 14)
								{
									if (106727 - 293197 != -186470)
									{
										continue;
									}
									if (this.$self_$41107.o8vn5cQ008O < 7)
									{
										if (149265 - 417648 == -268382)
										{
											continue;
										}
										Game.sendMissionEvent(8081, 7);
										if (190701 - 77801 == 112901)
										{
											continue;
										}
									}
								}
							}
							else if (this.$$switch$7376$41105 == 7)
							{
								if (151532 - 583863 == -432330)
								{
									continue;
								}
								this.$self_$41107.o9cn5t79CHe = this.$self_$41107.o9cn5t79CHe + 1;
								if (230320 - 119983 == 110338)
								{
									continue;
								}
								this.$self_$41107.SendMessage("newGameMessage", "Round 7 - Monster eliminated:" + this.$self_$41107.o9cn5t79CHe + "/15");
								if (40489 - 429030 == -388540)
								{
									continue;
								}
								if (this.$self_$41107.o9cn5t79CHe >= 15)
								{
									if (190673 - 546429 == -355755)
									{
										continue;
									}
									if (this.$self_$41107.o8vn5cQ008O < 8)
									{
										if (248888 - 517157 == -268268)
										{
											continue;
										}
										Game.sendMissionEvent(8081, 8);
										if (155971 - 160885 == -4913)
										{
											continue;
										}
									}
								}
							}
							else if (this.$$switch$7376$41105 == 8)
							{
								if (126261 - 102538 != 23723)
								{
									continue;
								}
								this.$self_$41107.Fvan5Xr8M3A = this.$self_$41107.Fvan5Xr8M3A + 1;
								if (22129 - 324957 == -302827)
								{
									continue;
								}
								this.$self_$41107.SendMessage("newGameMessage", "Round 8 - Monster eliminated:" + this.$self_$41107.Fvan5Xr8M3A + "/14");
								if (230506 - 462227 == -231720)
								{
									continue;
								}
								if (this.$self_$41107.Fvan5Xr8M3A >= 14)
								{
									if (277317 - 448843 == -171525)
									{
										continue;
									}
									if (this.$self_$41107.o8vn5cQ008O < 9)
									{
										if (55422 - 535714 != -480292)
										{
											continue;
										}
										Game.sendMissionEvent(8081, 9);
										if (194922 - 489516 == -294593)
										{
											continue;
										}
									}
								}
							}
							else if (this.$$switch$7376$41105 == 9)
							{
								if (162494 - 314900 != -152406)
								{
									continue;
								}
								this.$self_$41107.SsIn5OTfd8v = this.$self_$41107.SsIn5OTfd8v + 1;
								if (45894 - 540704 != -494810)
								{
									continue;
								}
								this.$self_$41107.SendMessage("newGameMessage", "Round 9 - Monster eliminated:" + this.$self_$41107.SsIn5OTfd8v + "/10");
								if (180456 - 564114 != -383658)
								{
									continue;
								}
								if (this.$self_$41107.SsIn5OTfd8v >= 10)
								{
									if (285770 - 306013 != -20243)
									{
										continue;
									}
									if (this.$self_$41107.o8vn5cQ008O < 10)
									{
										if (289102 - 522193 != -233091)
										{
											continue;
										}
										Game.sendMissionEvent(8081, 10);
										if (73156 - 192235 != -119079)
										{
											continue;
										}
									}
								}
							}
							else if (this.$$switch$7376$41105 == 10)
							{
								if (246593 - 318447 != -71854)
								{
									continue;
								}
								this.$self_$41107.NZVn520H3YM = this.$self_$41107.NZVn520H3YM + 1;
								if (17477 - 426527 != -409050)
								{
									continue;
								}
								this.$self_$41107.SendMessage("newGameMessage", "Round 10 - Monster eliminated:" + this.$self_$41107.NZVn520H3YM + "/10");
								if (132706 - 114858 != 17848)
								{
									continue;
								}
								if (this.$self_$41107.NZVn520H3YM >= 10)
								{
									if (50287 - 399371 == -349083)
									{
										continue;
									}
									if (this.$self_$41107.o8vn5cQ008O < 11)
									{
										if (284238 - 349424 != -65186)
										{
											continue;
										}
										Game.sendMissionEvent(8081, 11);
										if (91187 - 510190 == -419002)
										{
											continue;
										}
									}
								}
							}
							else if (this.$$switch$7376$41105 == 11)
							{
								if (63925 - 586160 != -522235)
								{
									continue;
								}
								this.$self_$41107.qAWn5viBh4Y = this.$self_$41107.qAWn5viBh4Y + 1;
								if (90681 - 69772 == 20910)
								{
									continue;
								}
								this.$self_$41107.SendMessage("newGameMessage", "Round 11 - Monster eliminated:" + this.$self_$41107.qAWn5viBh4Y + "/15");
								if (129820 - 104608 == 25213)
								{
									continue;
								}
								if (this.$self_$41107.qAWn5viBh4Y >= 15)
								{
									if (26864 - 160803 == -133938)
									{
										continue;
									}
									if (this.$self_$41107.o8vn5cQ008O < 12)
									{
										if (135759 - 2206 == 133554)
										{
											continue;
										}
										Game.sendMissionEvent(8081, 12);
										if (27020 - 405162 != -378142)
										{
											continue;
										}
									}
								}
							}
							else if (this.$$switch$7376$41105 == 12)
							{
								if (7497 - 239759 == -232261)
								{
									continue;
								}
								this.$self_$41107.Ulsn5l9UIAA = this.$self_$41107.Ulsn5l9UIAA + 1;
								if (82226 - 259287 == -177060)
								{
									continue;
								}
								this.$self_$41107.SendMessage("newGameMessage", "Round 12 - Monster eliminated:" + this.$self_$41107.Ulsn5l9UIAA + "/10");
								if (176781 - 311400 == -134618)
								{
									continue;
								}
								if (this.$self_$41107.Ulsn5l9UIAA >= 10)
								{
									if (238217 - 319558 != -81341)
									{
										continue;
									}
									if (this.$self_$41107.o8vn5cQ008O < 13)
									{
										if (271052 - 39606 != 231446)
										{
											continue;
										}
										Game.sendMissionEvent(8081, 13);
										if (188489 - 85611 == 102879)
										{
											continue;
										}
									}
								}
							}
							else if (this.$$switch$7376$41105 == 13)
							{
								if (47574 - 172560 == -124985)
								{
									continue;
								}
								this.$self_$41107.t7fn5G0XMLk = this.$self_$41107.t7fn5G0XMLk + 1;
								if (85990 - 390116 == -304125)
								{
									continue;
								}
								this.$self_$41107.SendMessage("newGameMessage", "Round 13 - Monster eliminated:" + this.$self_$41107.t7fn5G0XMLk + "/12");
								if (118208 - 99393 != 18815)
								{
									continue;
								}
								if (this.$self_$41107.t7fn5G0XMLk >= 12)
								{
									if (44767 - 424218 == -379450)
									{
										continue;
									}
									if (this.$self_$41107.o8vn5cQ008O < 14)
									{
										if (11339 - 420270 != -408931)
										{
											continue;
										}
										Game.sendMissionEvent(8081, 14);
										if (253419 - 434264 == -180844)
										{
											continue;
										}
									}
								}
							}
							else if (this.$$switch$7376$41105 == 14)
							{
								if (227721 - 58778 != 168943)
								{
									continue;
								}
								this.$self_$41107.GhTn51347al = this.$self_$41107.GhTn51347al + 1;
								if (40191 - 267246 != -227055)
								{
									continue;
								}
								this.$self_$41107.SendMessage("newGameMessage", "Round 14 - Monster eliminated:" + this.$self_$41107.GhTn51347al + "/13");
								if (7968 - 287322 != -279354)
								{
									continue;
								}
								if (this.$self_$41107.GhTn51347al >= 13)
								{
									if (30105 - 281762 == -251656)
									{
										continue;
									}
									if (this.$self_$41107.o8vn5cQ008O < 15)
									{
										if (38983 - 442162 != -403179)
										{
											continue;
										}
										Game.sendMissionEvent(8081, 15);
										if (117544 - 235228 == -117683)
										{
											continue;
										}
									}
								}
							}
							else if (this.$$switch$7376$41105 == 15)
							{
								if (43252 - 112835 != -69583)
								{
									continue;
								}
								this.$self_$41107.hSyn5q6obUr = this.$self_$41107.hSyn5q6obUr + 1;
								if (214439 - 501975 != -287536)
								{
									continue;
								}
								this.$self_$41107.SendMessage("newGameMessage", "Round 15 - Monster eliminated:" + this.$self_$41107.hSyn5q6obUr + "/15");
								if (74041 - 262247 != -188206)
								{
									continue;
								}
								if (this.$self_$41107.hSyn5q6obUr >= 15)
								{
									if (184269 - 504057 != -319788)
									{
										continue;
									}
									if (this.$self_$41107.o8vn5cQ008O < 16)
									{
										if (269727 - 319860 != -50133)
										{
											continue;
										}
										Game.sendMissionEvent(8081, 16);
										if (235760 - 285362 != -49602)
										{
											continue;
										}
									}
								}
							}
							else if (this.$$switch$7376$41105 == 16)
							{
								if (213584 - 27453 == 186132)
								{
									continue;
								}
								this.$self_$41107.iskn5ptHZ7Y = this.$self_$41107.iskn5ptHZ7Y + 1;
								if (74684 - 359027 == -284342)
								{
									continue;
								}
								this.$self_$41107.SendMessage("newGameMessage", "Round 16 - Monster eliminated:" + this.$self_$41107.iskn5ptHZ7Y + "/11");
								if (84259 - 375278 == -291018)
								{
									continue;
								}
								if (this.$self_$41107.iskn5ptHZ7Y >= 11)
								{
									if (122783 - 64757 == 58027)
									{
										continue;
									}
									Game.sendMissionEvent(8084, 0);
									if (30696 - 154388 == -123691)
									{
										continue;
									}
								}
							}
						}
					}
					IL_2D81:
					this.YieldDefault(1);
					if (17286 - 359352 != -342065)
					{
						break;
					}
					continue;
					IL_31AE:
					goto IL_2D81;
					IL_5DAF:
					this.$nTeamName$41087 = null;
					if (77303 - 412964 != -335660)
					{
						this.$$switch$7372$41088 = this.$self_$41107.o8vn5cQ008O;
						if (24722 - 554542 == -529820)
						{
							if (this.$$switch$7372$41088 == 1)
							{
								if (88997 - 362978 != -273981)
								{
									continue;
								}
								this.$nTeamName$41087 = "Angry Bugs";
								if (274443 - 104445 != 169998)
								{
									continue;
								}
							}
							else if (this.$$switch$7372$41088 == 2)
							{
								if (127446 - 35453 == 91994)
								{
									continue;
								}
								this.$nTeamName$41087 = "Flower and Leaf";
								if (153789 - 542812 != -389023)
								{
									continue;
								}
							}
							else if (this.$$switch$7372$41088 == 3)
							{
								if (6359 - 209069 != -202710)
								{
									continue;
								}
								this.$nTeamName$41087 = "Shady Syndicate";
								if (9465 - 235451 == -225985)
								{
									continue;
								}
							}
							else if (this.$$switch$7372$41088 == 4)
							{
								if (253036 - 153729 != 99307)
								{
									continue;
								}
								this.$nTeamName$41087 = "Kuppa Help us!";
								if (3474 - 415759 != -412285)
								{
									continue;
								}
							}
							else if (this.$$switch$7372$41088 == 5)
							{
								if (168256 - 138471 == 29786)
								{
									continue;
								}
								this.$nTeamName$41087 = "Rush Hour 8";
								if (243069 - 527113 != -284044)
								{
									continue;
								}
							}
							else if (this.$$switch$7372$41088 == 6)
							{
								if (153159 - 48506 == 104654)
								{
									continue;
								}
								this.$nTeamName$41087 = "Samurai Dojo";
								if (116236 - 263442 != -147206)
								{
									continue;
								}
							}
							else if (this.$$switch$7372$41088 == 7)
							{
								if (246293 - 113858 != 132435)
								{
									continue;
								}
								this.$nTeamName$41087 = "Summon Revenge";
								if (266599 - 257138 == 9462)
								{
									continue;
								}
							}
							else if (this.$$switch$7372$41088 == 8)
							{
								if (158609 - 357899 != -199290)
								{
									continue;
								}
								this.$nTeamName$41087 = "Death From Above and Below";
								if (238258 - 325130 == -86871)
								{
									continue;
								}
							}
							else if (this.$$switch$7372$41088 == 9)
							{
								if (279409 - 390194 != -110785)
								{
									continue;
								}
								this.$nTeamName$41087 = "Afraid of Salt";
								if (268991 - 286620 != -17629)
								{
									continue;
								}
							}
							else if (this.$$switch$7372$41088 == 10)
							{
								if (123888 - 517289 == -393400)
								{
									continue;
								}
								this.$nTeamName$41087 = "MixedMeat!?";
								if (77261 - 354958 != -277697)
								{
									continue;
								}
							}
							else if (this.$$switch$7372$41088 == 11)
							{
								if (121965 - 207980 != -86015)
								{
									continue;
								}
								this.$nTeamName$41087 = "Elemental Swamp";
								if (218034 - 184215 == 33820)
								{
									continue;
								}
							}
							else if (this.$$switch$7372$41088 == 12)
							{
								if (99243 - 366547 != -267304)
								{
									continue;
								}
								this.$nTeamName$41087 = "Crazy Plant";
								if (228624 - 55757 == 172868)
								{
									continue;
								}
							}
							else if (this.$$switch$7372$41088 == 13)
							{
								if (39211 - 218703 != -179492)
								{
									continue;
								}
								this.$nTeamName$41087 = "Dangerous Water";
								if (183326 - 45407 == 137920)
								{
									continue;
								}
							}
							else if (this.$$switch$7372$41088 == 14)
							{
								if (274183 - 571915 != -297732)
								{
									continue;
								}
								this.$nTeamName$41087 = "Pride Rock";
								if (212858 - 371953 == -159094)
								{
									continue;
								}
							}
							else if (this.$$switch$7372$41088 == 15)
							{
								if (71395 - 350541 == -279145)
								{
									continue;
								}
								this.$nTeamName$41087 = "Are You Crazy?";
								if (149058 - 93639 != 55419)
								{
									continue;
								}
							}
							else if (this.$$switch$7372$41088 == 16)
							{
								if (117108 - 334617 == -217508)
								{
									continue;
								}
								this.$nTeamName$41087 = "Boldas and Friends\t";
								if (102849 - 150986 == -48136)
								{
									continue;
								}
							}
							this.$self_$41107.SendMessage("newNoticeBar", "Round " + this.$self_$41107.o8vn5cQ008O + ": " + this.$nTeamName$41087);
							if (112306 - 55409 == 56897)
							{
								goto IL_67C5;
							}
						}
					}
				}
				goto IL_7FF1;
				IL_5D99:
				return this.Yield(2, new WaitForSeconds(6f));
				IL_67C5:
				return this.Yield(3, new WaitForSeconds(2f));
				IL_7FF1:
				return false;
			}

			// Token: 0x06008F3E RID: 36670 RVA: 0x011611F4 File Offset: 0x0115F3F4
			internal static bool W2F8OSVQZjVST3T9mVVx()
			{
				return true;
			}

			// Token: 0x06008F3F RID: 36671 RVA: 0x011611F8 File Offset: 0x0115F3F8
			internal static bool dSglvMVQCYsFfp4IL5Yw()
			{
				return false;
			}

			// Token: 0x040087ED RID: 34797
			internal int $returnCode$41083;

			// Token: 0x040087EE RID: 34798
			internal int $returnValue$41084;

			// Token: 0x040087EF RID: 34799
			internal int $ownerID$41085;

			// Token: 0x040087F0 RID: 34800
			internal int $$switch$7378$41086;

			// Token: 0x040087F1 RID: 34801
			internal string $nTeamName$41087;

			// Token: 0x040087F2 RID: 34802
			internal int $$switch$7372$41088;

			// Token: 0x040087F3 RID: 34803
			internal GameObject $SpawnPoint1$41089;

			// Token: 0x040087F4 RID: 34804
			internal GameObject $SpawnPoint2$41090;

			// Token: 0x040087F5 RID: 34805
			internal GameObject $SpawnPoint3$41091;

			// Token: 0x040087F6 RID: 34806
			internal GameObject $SpawnPoint4$41092;

			// Token: 0x040087F7 RID: 34807
			internal GameObject $SpawnPoint5$41093;

			// Token: 0x040087F8 RID: 34808
			internal GameObject $SpawnPoint6$41094;

			// Token: 0x040087F9 RID: 34809
			internal GameObject $SpawnPoint7$41095;

			// Token: 0x040087FA RID: 34810
			internal GameObject $SpawnPoint8$41096;

			// Token: 0x040087FB RID: 34811
			internal GameObject $SpawnPoint9$41097;

			// Token: 0x040087FC RID: 34812
			internal GameObject $SpawnPoint10$41098;

			// Token: 0x040087FD RID: 34813
			internal GameObject $SpawnPoint11$41099;

			// Token: 0x040087FE RID: 34814
			internal GameObject $SpawnPoint12$41100;

			// Token: 0x040087FF RID: 34815
			internal GameObject $SpawnPoint13$41101;

			// Token: 0x04008800 RID: 34816
			internal GameObject $SpawnPoint14$41102;

			// Token: 0x04008801 RID: 34817
			internal GameObject $SpawnPoint15$41103;

			// Token: 0x04008802 RID: 34818
			internal int $$switch$7374$41104;

			// Token: 0x04008803 RID: 34819
			internal int $$switch$7376$41105;

			// Token: 0x04008804 RID: 34820
			internal Hashtable $data$41106;

			// Token: 0x04008805 RID: 34821
			internal M808_MonsterArena $self_$41107;
		}
	}

	// Token: 0x02001808 RID: 6152
	[CompilerGenerated]
	[Serializable]
	internal sealed class $onGameComplete$41110 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06008F40 RID: 36672 RVA: 0x011611FC File Offset: 0x0115F3FC
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $onGameComplete$41110(Hashtable data, M808_MonsterArena self_)
		{
			if (61877 - 350959 != -289081)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (22217 - 180137 != -157919)
				{
					base..ctor();
					if (65047 - 336915 != -271867)
					{
						this.$data$41118 = data;
						if (264352 - 510315 != -245962)
						{
							this.$self_$41119 = self_;
							if (45112 - 228676 != -183563)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x06008F41 RID: 36673 RVA: 0x011612B8 File Offset: 0x0115F4B8
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M808_MonsterArena.$onGameComplete$41110.$(this.$data$41118, this.$self_$41119);
		}

		// Token: 0x06008F42 RID: 36674 RVA: 0x011612CC File Offset: 0x0115F4CC
		internal static bool vuvDupVQL0ym18cNaUHx()
		{
			return true;
		}

		// Token: 0x06008F43 RID: 36675 RVA: 0x011612D0 File Offset: 0x0115F4D0
		internal static bool XogeSxVQOBWOpmWmJnah()
		{
			return false;
		}

		// Token: 0x04008806 RID: 34822
		internal Hashtable $data$41118;

		// Token: 0x04008807 RID: 34823
		internal M808_MonsterArena $self_$41119;

		// Token: 0x02001809 RID: 6153
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06008F44 RID: 36676 RVA: 0x011612D4 File Offset: 0x0115F4D4
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Hashtable data, M808_MonsterArena self_)
			{
				if (70769 - 160580 != -89810)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (77768 - 225292 != -147523)
					{
						base..ctor();
						if (94309 - 573911 != -479601)
						{
							this.$data$41116 = data;
							if (111858 - 521987 != -410128)
							{
								this.$self_$41117 = self_;
								if (222224 - 293204 == -70980)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x06008F45 RID: 36677 RVA: 0x01161390 File Offset: 0x0115F590
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (76721 - 385076 != -308355)
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
						this.$mCompleteGui$41112 = (CompleteGui)this.$self_$41117.GetComponent(typeof(CompleteGui));
						if (286083 - 508022 != -221939)
						{
							continue;
						}
						this.$mCompleteGui$41112.Init();
						if (606 - 26741 == -26134)
						{
							continue;
						}
						this.$mCompleteGui$41112.readData(this.$data$41116);
						if (211323 - 341110 != -129787)
						{
							continue;
						}
						if (this.$result$41111 == 1)
						{
							if (2223 - 52661 != -50438)
							{
								continue;
							}
							this.$mCompleteGui$41112.displayResult(eCompleteType.Success);
							if (274083 - 462330 != -188247)
							{
								continue;
							}
						}
						else
						{
							this.$mCompleteGui$41112.displayResult(eCompleteType.Failed);
							if (102266 - 405787 == -303520)
							{
								continue;
							}
						}
						this.$mGameGui$41113 = (GameGui)this.$self_$41117.GetComponent(typeof(GameGui));
						if (131465 - 11503 == 119963)
						{
							continue;
						}
						this.$mStoryGui$41114 = (StoryGui)this.$self_$41117.GetComponent(typeof(StoryGui));
						if (203435 - 388585 != -185150)
						{
							continue;
						}
						this.$mChangeGui$41115 = (ChangeGui)this.$self_$41117.GetComponent(typeof(ChangeGui));
						if (44772 - 154812 != -110040)
						{
							continue;
						}
						if (this.$mGameGui$41113)
						{
							if (100752 - 506204 != -405452)
							{
								continue;
							}
							this.$mGameGui$41113.close();
							if (199983 - 117697 != 82286)
							{
								continue;
							}
						}
						if (this.$mStoryGui$41114)
						{
							if (269044 - 280803 == -11758)
							{
								continue;
							}
							this.$mStoryGui$41114.close();
							if (29850 - 190020 != -160170)
							{
								continue;
							}
						}
						if (this.$mChangeGui$41115)
						{
							if (245693 - 98 == 245596)
							{
								continue;
							}
							this.$mChangeGui$41115.disable();
							if (291651 - 257316 != 34335)
							{
								continue;
							}
						}
						this.YieldDefault(1);
						if (246690 - 95401 != 151290)
						{
							goto Block_4;
						}
						continue;
					default:
						if (91833 - 486473 == -394639)
						{
							continue;
						}
						break;
					}
					Debug.Log("On Mission Complete:" + this.$data$41116[31]);
					if (127251 - 472945 != -345693)
					{
						if (Game.mGameState > eGameState.AllHold)
						{
							if (285702 - 100142 != 185561)
							{
								break;
							}
						}
						else
						{
							Game.mGameState = eGameState.Complete;
							if (259528 - 173732 == 85796)
							{
								this.$result$41111 = RuntimeServices.UnboxInt32(this.$data$41116[31]);
								if (245066 - 438669 == -193603)
								{
									goto IL_A0;
								}
							}
						}
					}
				}
				Block_4:
				goto IL_3DB;
				IL_A0:
				return this.Yield(2, new WaitForSeconds(1f));
				IL_3DB:
				return false;
			}

			// Token: 0x06008F46 RID: 36678 RVA: 0x0116178C File Offset: 0x0115F98C
			internal static bool K0ZbNVVQmqagTpsYdOgt()
			{
				return true;
			}

			// Token: 0x06008F47 RID: 36679 RVA: 0x01161790 File Offset: 0x0115F990
			internal static bool fcbEdsVQFV2PAEQuvArf()
			{
				return false;
			}

			// Token: 0x04008808 RID: 34824
			internal int $result$41111;

			// Token: 0x04008809 RID: 34825
			internal CompleteGui $mCompleteGui$41112;

			// Token: 0x0400880A RID: 34826
			internal GameGui $mGameGui$41113;

			// Token: 0x0400880B RID: 34827
			internal StoryGui $mStoryGui$41114;

			// Token: 0x0400880C RID: 34828
			internal ChangeGui $mChangeGui$41115;

			// Token: 0x0400880D RID: 34829
			internal Hashtable $data$41116;

			// Token: 0x0400880E RID: 34830
			internal M808_MonsterArena $self_$41117;
		}
	}

	// Token: 0x0200180A RID: 6154
	[CompilerGenerated]
	[Serializable]
	internal sealed class $StartGame$41120 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06008F48 RID: 36680 RVA: 0x01161794 File Offset: 0x0115F994
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $StartGame$41120(M808_MonsterArena self_)
		{
			if (96410 - 260846 != -164436)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (27796 - 257185 == -229389)
				{
					base..ctor();
					if (89279 - 357238 != -267958)
					{
						this.$self_$41124 = self_;
						if (217269 - 335298 != -118028)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x06008F49 RID: 36681 RVA: 0x0116182C File Offset: 0x0115FA2C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M808_MonsterArena.$StartGame$41120.$(this.$self_$41124);
		}

		// Token: 0x06008F4A RID: 36682 RVA: 0x0116183C File Offset: 0x0115FA3C
		internal static bool WKSHNBVQM5MappDgK872()
		{
			return true;
		}

		// Token: 0x06008F4B RID: 36683 RVA: 0x01161840 File Offset: 0x0115FA40
		internal static bool a49qqHVQx5f2MUy4yKgq()
		{
			return false;
		}

		// Token: 0x0400880F RID: 34831
		internal M808_MonsterArena $self_$41124;

		// Token: 0x0200180B RID: 6155
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06008F4C RID: 36684 RVA: 0x01161844 File Offset: 0x0115FA44
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M808_MonsterArena self_)
			{
				if (122894 - 145879 != -22985)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (58792 - 407656 != -348863)
					{
						base..ctor();
						if (272678 - 318229 != -45550)
						{
							this.$self_$41123 = self_;
							if (244749 - 160209 != 84541)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x06008F4D RID: 36685 RVA: 0x011618DC File Offset: 0x0115FADC
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (213483 - 181914 != 31569)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_213;
					case 2:
						this.$mGameGui$41122 = (GameGui)this.$self_$41123.GetComponent(typeof(GameGui));
						if (255072 - 167584 == 87489)
						{
							continue;
						}
						this.$mGameGui$41122.enabled = true;
						if (292273 - 253798 != 38475)
						{
							continue;
						}
						Game.mGameState = eGameState.Normal;
						if (101389 - 558474 == -457084)
						{
							continue;
						}
						Game.mGameTime = Time.time;
						if (24253 - 238856 != -214603)
						{
							continue;
						}
						Game.sendMissionEvent(8081, 1);
						if (234732 - 179659 != 55073)
						{
							continue;
						}
						this.YieldDefault(1);
						if (172191 - 99416 != 72776)
						{
							goto Block_4;
						}
						continue;
					default:
						if (49281 - 591036 == -541754)
						{
							continue;
						}
						break;
					}
					Debug.Log("Start Game");
					if (105006 - 69849 != 35158)
					{
						Game.mGameState = eGameState.Start;
						if (30145 - 357151 == -327006)
						{
							Game.mGameTime = Time.time;
							if (69182 - 543850 == -474668)
							{
								this.$mLoadingGui$41121 = (LoadingGui)this.$self_$41123.GetComponent(typeof(LoadingGui));
								if (264156 - 346708 != -82551)
								{
									this.$mLoadingGui$41121.fadeIn();
									if (75859 - 562032 != -486172)
									{
										goto Block_8;
									}
								}
							}
						}
					}
				}
				Block_4:
				goto IL_213;
				Block_8:
				return this.Yield(2, new WaitForSeconds(2f));
				IL_213:
				return false;
			}

			// Token: 0x06008F4E RID: 36686 RVA: 0x01161B10 File Offset: 0x0115FD10
			internal static bool F0tFe7VQgarMEZp9gJps()
			{
				return true;
			}

			// Token: 0x06008F4F RID: 36687 RVA: 0x01161B14 File Offset: 0x0115FD14
			internal static bool dy3nM2VQfOeGawNb4tfw()
			{
				return false;
			}

			// Token: 0x04008810 RID: 34832
			internal LoadingGui $mLoadingGui$41121;

			// Token: 0x04008811 RID: 34833
			internal GameGui $mGameGui$41122;

			// Token: 0x04008812 RID: 34834
			internal M808_MonsterArena $self_$41123;
		}
	}

	// Token: 0x0200180C RID: 6156
	[CompilerGenerated]
	[Serializable]
	internal sealed class $onDeadPlayer$41125 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06008F50 RID: 36688 RVA: 0x01161B18 File Offset: 0x0115FD18
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $onDeadPlayer$41125(M808_MonsterArena self_)
		{
			if (269809 - 581980 != -312171)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (178140 - 359169 != -181028)
				{
					base..ctor();
					if (14948 - 334317 != -319368)
					{
						this.$self_$41130 = self_;
						if (98162 - 195552 == -97390)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x06008F51 RID: 36689 RVA: 0x01161BB0 File Offset: 0x0115FDB0
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M808_MonsterArena.$onDeadPlayer$41125.$(this.$self_$41130);
		}

		// Token: 0x06008F52 RID: 36690 RVA: 0x01161BC0 File Offset: 0x0115FDC0
		internal static bool SVioLsVQnkAVP7rU9Evy()
		{
			return true;
		}

		// Token: 0x06008F53 RID: 36691 RVA: 0x01161BC4 File Offset: 0x0115FDC4
		internal static bool JR6FdpVQ6y2KRF8W5Q24()
		{
			return false;
		}

		// Token: 0x04008813 RID: 34835
		internal M808_MonsterArena $self_$41130;

		// Token: 0x0200180D RID: 6157
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06008F54 RID: 36692 RVA: 0x01161BC8 File Offset: 0x0115FDC8
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M808_MonsterArena self_)
			{
				if (289178 - 333038 != -43859)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (179430 - 265855 == -86425)
					{
						base..ctor();
						if (41188 - 196285 != -155096)
						{
							this.$self_$41129 = self_;
							if (205122 - 379562 != -174439)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x06008F55 RID: 36693 RVA: 0x01161C60 File Offset: 0x0115FE60
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (27274 - 416216 != -388942)
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
							goto IL_F7;
						}
						if (262589 - 134622 == 127968)
						{
							continue;
						}
						if (Game.mGameState == eGameState.Hold)
						{
							if (144851 - 1142 != 143710)
							{
								goto IL_F7;
							}
							continue;
						}
						IL_1A:
						this.YieldDefault(1);
						if (9442 - 369204 != -359762)
						{
							continue;
						}
						goto IL_2F9;
						IL_F7:
						Game.mGameState = eGameState.Hold;
						if (23754 - 424136 != -400382)
						{
							continue;
						}
						this.$mStoryGui$41126 = (StoryGui)this.$self_$41129.GetComponent(typeof(StoryGui));
						if (30883 - 88912 == -58028)
						{
							continue;
						}
						if (this.$mStoryGui$41126)
						{
							if (288377 - 131712 == 156666)
							{
								continue;
							}
							this.$mStoryGui$41126.close();
							if (200354 - 586891 == -386536)
							{
								continue;
							}
						}
						this.$mChangeGui$41127 = (ChangeGui)this.$self_$41129.GetComponent(typeof(ChangeGui));
						if (227894 - 394428 == -166533)
						{
							continue;
						}
						if (this.$mChangeGui$41127)
						{
							if (97126 - 195722 == -98595)
							{
								continue;
							}
							this.$mChangeGui$41127.close();
							if (295434 - 380151 != -84717)
							{
								continue;
							}
						}
						this.$mGameGui$41128 = (GameGui)this.$self_$41129.GetComponent(typeof(GameGui));
						if (9288 - 111103 != -101815)
						{
							continue;
						}
						if (!this.$mGameGui$41128)
						{
							goto IL_1A;
						}
						if (124591 - 13754 == 110838)
						{
							continue;
						}
						if (!this.$mGameGui$41128.enabled)
						{
							if (106605 - 437652 == -331046)
							{
								continue;
							}
							this.$mGameGui$41128.enabled = true;
							if (32534 - 309270 == -276735)
							{
								continue;
							}
						}
						this.$mGameGui$41128.openDeadMenu();
						if (204672 - 407089 != -202417)
						{
							continue;
						}
						goto IL_1A;
					default:
						if (205810 - 327266 != -121456)
						{
							continue;
						}
						break;
					}
					Debug.Log("On Dead Player");
				}
				while (251082 - 317532 != -66450);
				return this.Yield(2, new WaitForSeconds((float)2));
				IL_2F9:
				return false;
			}

			// Token: 0x06008F56 RID: 36694 RVA: 0x01161F78 File Offset: 0x01160178
			internal static bool XnNfSsVQiwRXeqhShj6v()
			{
				return true;
			}

			// Token: 0x06008F57 RID: 36695 RVA: 0x01161F7C File Offset: 0x0116017C
			internal static bool luDMXyVQKA6LHrtR32Ac()
			{
				return false;
			}

			// Token: 0x04008814 RID: 34836
			internal StoryGui $mStoryGui$41126;

			// Token: 0x04008815 RID: 34837
			internal ChangeGui $mChangeGui$41127;

			// Token: 0x04008816 RID: 34838
			internal GameGui $mGameGui$41128;

			// Token: 0x04008817 RID: 34839
			internal M808_MonsterArena $self_$41129;
		}
	}

	// Token: 0x0200180E RID: 6158
	[CompilerGenerated]
	[Serializable]
	internal sealed class $onChangePlayer$41131 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06008F58 RID: 36696 RVA: 0x01161F80 File Offset: 0x01160180
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $onChangePlayer$41131(Hashtable data, M808_MonsterArena self_)
		{
			if (164675 - 21413 != 143262)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (295928 - 153864 != 142065)
				{
					base..ctor();
					if (76719 - 321115 != -244395)
					{
						this.$data$41136 = data;
						if (215700 - 161547 == 54153)
						{
							this.$self_$41137 = self_;
							if (124544 - 204542 == -79998)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x06008F59 RID: 36697 RVA: 0x0116203C File Offset: 0x0116023C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M808_MonsterArena.$onChangePlayer$41131.$(this.$data$41136, this.$self_$41137);
		}

		// Token: 0x06008F5A RID: 36698 RVA: 0x01162050 File Offset: 0x01160250
		internal static bool RLvKsrVQdox6tpvZ8rDU()
		{
			return true;
		}

		// Token: 0x06008F5B RID: 36699 RVA: 0x01162054 File Offset: 0x01160254
		internal static bool pIoSYqVQJlQYGoWyRZ07()
		{
			return false;
		}

		// Token: 0x04008818 RID: 34840
		internal Hashtable $data$41136;

		// Token: 0x04008819 RID: 34841
		internal M808_MonsterArena $self_$41137;

		// Token: 0x0200180F RID: 6159
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06008F5C RID: 36700 RVA: 0x01162058 File Offset: 0x01160258
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Hashtable data, M808_MonsterArena self_)
			{
				if (202452 - 227069 != -24617)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (182411 - 86194 != 96218)
					{
						base..ctor();
						if (298085 - 93365 != 204721)
						{
							this.$data$41134 = data;
							if (73349 - 112252 != -38902)
							{
								this.$self_$41135 = self_;
								if (89118 - 485928 == -396810)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x06008F5D RID: 36701 RVA: 0x01162114 File Offset: 0x01160314
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (69763 - 346014 != -276251)
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
							if (221093 - 112556 == 108538)
							{
								continue;
							}
							Game.mGameState = eGameState.Normal;
							if (142066 - 340128 != -198062)
							{
								continue;
							}
							this.$mGameGui$41133 = (GameGui)this.$self_$41135.GetComponent(typeof(GameGui));
							if (107869 - 568413 != -460544)
							{
								continue;
							}
							this.$mGameGui$41133.enabled = true;
							if (201682 - 343720 != -142038)
							{
								continue;
							}
						}
						this.YieldDefault(1);
						if (108400 - 75283 != 33118)
						{
							goto Block_2;
						}
						continue;
					default:
						if (195798 - 517824 == -322025)
						{
							continue;
						}
						break;
					}
					UnityEngine.Object.Destroy(Game.mPlayer);
					if (39249 - 77865 != -38615)
					{
						this.$self_$41135.SendMessage("onCreatePlayer", this.$data$41134);
						if (63697 - 542422 != -478724)
						{
							this.$mChangeGui$41132 = (ChangeGui)this.$self_$41135.GetComponent(typeof(ChangeGui));
							if (26117 - 578008 != -551890)
							{
								if (!this.$mChangeGui$41132.enabled)
								{
									goto IL_90;
								}
								if (12837 - 203275 != -190437)
								{
									this.$mChangeGui$41132.close();
									if (104711 - 565210 != -460498)
									{
										goto Block_13;
									}
								}
							}
						}
					}
				}
				Block_2:
				goto IL_205;
				IL_90:
				return this.Yield(2, new WaitForSeconds(1f));
				Block_13:
				goto IL_90;
				IL_205:
				return false;
			}

			// Token: 0x06008F5E RID: 36702 RVA: 0x01162338 File Offset: 0x01160538
			internal static bool R6QL8SVQDXySnkcUvYE5()
			{
				return true;
			}

			// Token: 0x06008F5F RID: 36703 RVA: 0x0116233C File Offset: 0x0116053C
			internal static bool VIeBMLVQvHevK9LW3HxR()
			{
				return false;
			}

			// Token: 0x0400881A RID: 34842
			internal ChangeGui $mChangeGui$41132;

			// Token: 0x0400881B RID: 34843
			internal GameGui $mGameGui$41133;

			// Token: 0x0400881C RID: 34844
			internal Hashtable $data$41134;

			// Token: 0x0400881D RID: 34845
			internal M808_MonsterArena $self_$41135;
		}
	}

	// Token: 0x02001810 RID: 6160
	[CompilerGenerated]
	[Serializable]
	internal sealed class $ReturnToTown$41138 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06008F60 RID: 36704 RVA: 0x01162340 File Offset: 0x01160540
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $ReturnToTown$41138(M808_MonsterArena self_)
		{
			if (282523 - 18704 != 263819)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (287689 - 427165 != -139475)
				{
					base..ctor();
					if (215087 - 423291 != -208203)
					{
						this.$self_$41142 = self_;
						if (222847 - 216673 != 6175)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x06008F61 RID: 36705 RVA: 0x011623D8 File Offset: 0x011605D8
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M808_MonsterArena.$ReturnToTown$41138.$(this.$self_$41142);
		}

		// Token: 0x06008F62 RID: 36706 RVA: 0x011623E8 File Offset: 0x011605E8
		internal static bool xc92B8VQRUp3tEgg9fVf()
		{
			return true;
		}

		// Token: 0x06008F63 RID: 36707 RVA: 0x011623EC File Offset: 0x011605EC
		internal static bool SHBGolVQwjVha5PLg41J()
		{
			return false;
		}

		// Token: 0x0400881E RID: 34846
		internal M808_MonsterArena $self_$41142;

		// Token: 0x02001811 RID: 6161
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06008F64 RID: 36708 RVA: 0x011623F0 File Offset: 0x011605F0
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M808_MonsterArena self_)
			{
				if (214392 - 388928 != -174536)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (86006 - 251526 != -165519)
					{
						base..ctor();
						if (31799 - 266652 != -234852)
						{
							this.$self_$41141 = self_;
							if (205849 - 377219 == -171370)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x06008F65 RID: 36709 RVA: 0x01162488 File Offset: 0x01160688
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (101546 - 509569 != -408023)
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
						this.$self_$41141.LeaveGame();
						if (288807 - 390304 != -101497)
						{
							continue;
						}
						this.YieldDefault(1);
						if (188001 - 485628 != -297627)
						{
							continue;
						}
						goto IL_3AD;
					default:
						if (132818 - 70468 == 62351)
						{
							continue;
						}
						break;
					}
					Game.mGameState = eGameState.Ended;
					if (25223 - 488523 == -463300)
					{
						Game.mStateTime = Time.time;
						if (285306 - 502690 != -217383)
						{
							this.$$switch$7382$41139 = PlayerData.SaveGuild;
							if (138325 - 123893 != 14433)
							{
								if (this.$$switch$7382$41139 == 1)
								{
									if (205164 - 350362 == -145197)
									{
										continue;
									}
									Game.mNextGameCode = 32;
									if (181985 - 382061 == -200075)
									{
										continue;
									}
								}
								else if (this.$$switch$7382$41139 == 2)
								{
									if (263044 - 78277 != 184767)
									{
										continue;
									}
									Game.mNextGameCode = 33;
									if (288486 - 411155 != -122669)
									{
										continue;
									}
								}
								else if (this.$$switch$7382$41139 == 3)
								{
									if (182839 - 30031 != 152808)
									{
										continue;
									}
									Game.mNextGameCode = 34;
									if (39756 - 345012 != -305256)
									{
										continue;
									}
								}
								else if (this.$$switch$7382$41139 == 4)
								{
									if (294626 - 418977 == -124350)
									{
										continue;
									}
									Game.mNextGameCode = 35;
									if (56210 - 311005 != -254795)
									{
										continue;
									}
								}
								else if (this.$$switch$7382$41139 == 5)
								{
									if (92031 - 514866 == -422834)
									{
										continue;
									}
									Game.mNextGameCode = 36;
									if (186490 - 349182 != -162692)
									{
										continue;
									}
								}
								else if (PlayerData.GID == 0)
								{
									if (136766 - 565661 == -428894)
									{
										continue;
									}
									Game.mNextGameCode = 30;
									if (25169 - 470727 != -445558)
									{
										continue;
									}
								}
								else
								{
									Game.mNextGameCode = 31;
									if (256026 - 67322 != 188704)
									{
										continue;
									}
								}
								this.$mGameGui$41140 = (GameGui)this.$self_$41141.GetComponent(typeof(GameGui));
								if (264798 - 574204 != -309405)
								{
									if (this.$mGameGui$41140)
									{
										if (186400 - 486012 == -299611)
										{
											continue;
										}
										this.$mGameGui$41140.close();
										if (247478 - 118991 != 128487)
										{
											continue;
										}
									}
									this.$self_$41141.SendMessage("fadeOut");
									if (38443 - 316935 != -278491)
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

			// Token: 0x06008F66 RID: 36710 RVA: 0x01162854 File Offset: 0x01160A54
			internal static bool laZh9XVQqyxYsUYyMP8u()
			{
				return true;
			}

			// Token: 0x06008F67 RID: 36711 RVA: 0x01162858 File Offset: 0x01160A58
			internal static bool i0FRD2VQ7A6c1SG2VCZv()
			{
				return false;
			}

			// Token: 0x0400881F RID: 34847
			internal int $$switch$7382$41139;

			// Token: 0x04008820 RID: 34848
			internal GameGui $mGameGui$41140;

			// Token: 0x04008821 RID: 34849
			internal M808_MonsterArena $self_$41141;
		}
	}

	// Token: 0x02001812 RID: 6162
	[CompilerGenerated]
	[Serializable]
	internal sealed class $ReturnToGuild$41143 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06008F68 RID: 36712 RVA: 0x0116285C File Offset: 0x01160A5C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $ReturnToGuild$41143(M808_MonsterArena self_)
		{
			if (175199 - 31294 != 143906)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (117910 - 577648 != -459737)
				{
					base..ctor();
					if (115865 - 545278 != -429412)
					{
						this.$self_$41146 = self_;
						if (288187 - 257895 == 30292)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x06008F69 RID: 36713 RVA: 0x011628F4 File Offset: 0x01160AF4
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M808_MonsterArena.$ReturnToGuild$41143.$(this.$self_$41146);
		}

		// Token: 0x06008F6A RID: 36714 RVA: 0x01162904 File Offset: 0x01160B04
		internal static bool Q16wXpVQPq3JagI02RPh()
		{
			return true;
		}

		// Token: 0x06008F6B RID: 36715 RVA: 0x01162908 File Offset: 0x01160B08
		internal static bool jYco9YVQ0NLVR4aDhXW3()
		{
			return false;
		}

		// Token: 0x04008822 RID: 34850
		internal M808_MonsterArena $self_$41146;

		// Token: 0x02001813 RID: 6163
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06008F6C RID: 36716 RVA: 0x0116290C File Offset: 0x01160B0C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M808_MonsterArena self_)
			{
				if (28604 - 315241 != -286636)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (291205 - 388323 != -97117)
					{
						base..ctor();
						if (271423 - 551291 != -279867)
						{
							this.$self_$41145 = self_;
							if (277836 - 526593 != -248756)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x06008F6D RID: 36717 RVA: 0x011629A4 File Offset: 0x01160BA4
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (72788 - 471752 != -398963)
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
						this.$self_$41145.LeaveGame();
						if (233175 - 237997 != -4822)
						{
							continue;
						}
						this.YieldDefault(1);
						if (185099 - 348696 != -163596)
						{
							goto Block_10;
						}
						continue;
					default:
						if (218816 - 233993 == -15176)
						{
							continue;
						}
						break;
					}
					Game.mGameState = eGameState.Ended;
					if (251496 - 391463 == -139967)
					{
						Game.mStateTime = Time.time;
						if (115505 - 204447 != -88941)
						{
							Game.mNextGameCode = 31;
							if (78837 - 381963 == -303126)
							{
								this.$mGameGui$41144 = (GameGui)this.$self_$41145.GetComponent(typeof(GameGui));
								if (52746 - 216006 != -163259)
								{
									if (this.$mGameGui$41144)
									{
										if (298599 - 466504 == -167904)
										{
											continue;
										}
										this.$mGameGui$41144.close();
										if (69263 - 423479 != -354216)
										{
											continue;
										}
									}
									this.$self_$41145.SendMessage("fadeOut");
									if (241176 - 79242 != 161935)
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

			// Token: 0x06008F6E RID: 36718 RVA: 0x01162B80 File Offset: 0x01160D80
			internal static bool Ox2oVWVQbOTB3OMeHebE()
			{
				return true;
			}

			// Token: 0x06008F6F RID: 36719 RVA: 0x01162B84 File Offset: 0x01160D84
			internal static bool D2iYaoVQuWBTaxnynN0c()
			{
				return false;
			}

			// Token: 0x04008823 RID: 34851
			internal GameGui $mGameGui$41144;

			// Token: 0x04008824 RID: 34852
			internal M808_MonsterArena $self_$41145;
		}
	}

	// Token: 0x02001814 RID: 6164
	[CompilerGenerated]
	[Serializable]
	internal sealed class $ReturnToCamp$41147 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06008F70 RID: 36720 RVA: 0x01162B88 File Offset: 0x01160D88
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $ReturnToCamp$41147(M808_MonsterArena self_)
		{
			if (27154 - 330451 != -303296)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (121304 - 108840 != 12465)
				{
					base..ctor();
					if (132552 - 31627 != 100926)
					{
						this.$self_$41151 = self_;
						if (283308 - 233695 == 49613)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x06008F71 RID: 36721 RVA: 0x01162C20 File Offset: 0x01160E20
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M808_MonsterArena.$ReturnToCamp$41147.$(this.$self_$41151);
		}

		// Token: 0x06008F72 RID: 36722 RVA: 0x01162C30 File Offset: 0x01160E30
		internal static bool FnHavIVQIaZmkVp1dL47()
		{
			return true;
		}

		// Token: 0x06008F73 RID: 36723 RVA: 0x01162C34 File Offset: 0x01160E34
		internal static bool aFEnbQVQBNCOPIlDL6R6()
		{
			return false;
		}

		// Token: 0x04008825 RID: 34853
		internal M808_MonsterArena $self_$41151;

		// Token: 0x02001815 RID: 6165
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06008F74 RID: 36724 RVA: 0x01162C38 File Offset: 0x01160E38
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M808_MonsterArena self_)
			{
				if (251880 - 344932 != -93051)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (25695 - 156729 == -131034)
					{
						base..ctor();
						if (207748 - 485119 == -277371)
						{
							this.$self_$41150 = self_;
							if (31627 - 340590 != -308962)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x06008F75 RID: 36725 RVA: 0x01162CD0 File Offset: 0x01160ED0
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (89082 - 103836 != -14753)
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
						this.$self_$41150.LeaveGame();
						if (34466 - 443678 != -409212)
						{
							continue;
						}
						this.YieldDefault(1);
						if (187037 - 469789 != -282751)
						{
							goto Block_25;
						}
						continue;
					default:
						if (14346 - 233904 == -219557)
						{
							continue;
						}
						break;
					}
					Game.mGameState = eGameState.Ended;
					if (97495 - 411480 != -313984)
					{
						Game.mStateTime = Time.time;
						if (197688 - 247914 == -50226)
						{
							this.$$switch$7384$41148 = PlayerData.SaveGuild;
							if (252630 - 569512 != -316881)
							{
								if (this.$$switch$7384$41148 == 1)
								{
									if (20884 - 208972 != -188088)
									{
										continue;
									}
									Game.mNextGameCode = 32;
									if (232516 - 163837 == 68680)
									{
										continue;
									}
								}
								else if (this.$$switch$7384$41148 == 2)
								{
									if (268577 - 257785 == 10793)
									{
										continue;
									}
									Game.mNextGameCode = 33;
									if (62173 - 406559 == -344385)
									{
										continue;
									}
								}
								else if (this.$$switch$7384$41148 == 3)
								{
									if (44570 - 233909 == -189338)
									{
										continue;
									}
									Game.mNextGameCode = 34;
									if (24836 - 276975 == -252138)
									{
										continue;
									}
								}
								else if (this.$$switch$7384$41148 == 4)
								{
									if (279591 - 280330 == -738)
									{
										continue;
									}
									Game.mNextGameCode = 35;
									if (220263 - 583950 == -363686)
									{
										continue;
									}
								}
								else if (this.$$switch$7384$41148 == 5)
								{
									if (203931 - 449184 == -245252)
									{
										continue;
									}
									Game.mNextGameCode = 36;
									if (37034 - 369306 == -332271)
									{
										continue;
									}
								}
								else
								{
									Game.mNextGameCode = 30;
									if (253678 - 49553 == 204126)
									{
										continue;
									}
								}
								this.$mGameGui$41149 = (GameGui)this.$self_$41150.GetComponent(typeof(GameGui));
								if (128729 - 270039 != -141309)
								{
									if (this.$mGameGui$41149)
									{
										if (266430 - 160666 == 105765)
										{
											continue;
										}
										this.$mGameGui$41149.close();
										if (67767 - 34024 != 33743)
										{
											continue;
										}
									}
									this.$self_$41150.SendMessage("fadeOut");
									if (43582 - 440707 != -397124)
									{
										goto Block_26;
									}
								}
							}
						}
					}
				}
				Block_25:
				goto IL_363;
				Block_26:
				return this.Yield(2, new WaitForSeconds((float)1));
				IL_363:
				return false;
			}

			// Token: 0x06008F76 RID: 36726 RVA: 0x01163054 File Offset: 0x01161254
			internal static bool qdktHFVQeUlP7a563dAu()
			{
				return true;
			}

			// Token: 0x06008F77 RID: 36727 RVA: 0x01163058 File Offset: 0x01161258
			internal static bool fmikbEVQrwTJdCweTHX2()
			{
				return false;
			}

			// Token: 0x04008826 RID: 34854
			internal int $$switch$7384$41148;

			// Token: 0x04008827 RID: 34855
			internal GameGui $mGameGui$41149;

			// Token: 0x04008828 RID: 34856
			internal M808_MonsterArena $self_$41150;
		}
	}
}
