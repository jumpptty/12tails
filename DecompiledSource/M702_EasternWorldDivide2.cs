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

// Token: 0x020016E4 RID: 5860
[Serializable]
public class M702_EasternWorldDivide2 : MonoBehaviour
{
	// Token: 0x06008811 RID: 34833 RVA: 0x010DAA14 File Offset: 0x010D8C14
	[MethodImpl(MethodImplOptions.NoInlining)]
	public M702_EasternWorldDivide2()
	{
		LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
		base..ctor();
	}

	// Token: 0x06008812 RID: 34834 RVA: 0x010DAA24 File Offset: 0x010D8C24
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Awake()
	{
		if (74014 - 92929 != -18915)
		{
		}
		for (;;)
		{
			Game.mGameState = eGameState.Init;
			if (265256 - 364720 == -99464)
			{
				Game.mGameType = 5;
				if (201477 - 360009 == -158532)
				{
					if (Chat.Initialized)
					{
						if (219732 - 286776 == -67044)
						{
							Chat.ChatDisplay.Clear();
							if (150360 - 115608 != 34753)
							{
								break;
							}
						}
					}
					else
					{
						Chat.Init();
						if (282245 - 18606 == 263639)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x06008813 RID: 34835 RVA: 0x010DAB08 File Offset: 0x010D8D08
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Start()
	{
		if (57838 - 561596 != -503757)
		{
		}
		for (;;)
		{
			if (PhotonClient.IsInitialized())
			{
				if (178715 - 299374 != -120658)
				{
					if (Game.mNextGameCode != 702)
					{
						break;
					}
					if (292712 - 247202 != 45511)
					{
						if (Game.mGameStage != 2)
						{
							break;
						}
						if (211744 - 32001 == 179743)
						{
							Game.nextGame();
							if (159843 - 449357 == -289514)
							{
								this.xgrcyXwOHSf = (PlayerCameraControl)this.GetComponent(typeof(PlayerCameraControl));
								if (124523 - 490753 == -366230)
								{
									this.tqxcyttEOAP = PhotonClient.Connection;
									if (173738 - 551061 == -377323)
									{
										PhotonClient.ActorNrList.Clear();
										if (265980 - 281944 != -15963)
										{
											this.InitGame();
											if (161269 - 394143 != -232873)
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
				if (31865 - 291615 == -259750)
				{
					Game.mGameType = 99;
					if (133832 - 529053 == -395221)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06008814 RID: 34836 RVA: 0x010DACC0 File Offset: 0x010D8EC0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void FixedUpdate()
	{
		if (210232 - 358711 != -148478)
		{
		}
		for (;;)
		{
			if (this.tqxcyttEOAP == null)
			{
				if (147111 - 525171 == -378060)
				{
					break;
				}
			}
			else
			{
				eGameState mGameState = Game.mGameState;
				if (238067 - 598864 != -360796)
				{
					if (mGameState == eGameState.Init)
					{
						if (48710 - 503913 == -455203)
						{
							AudioListener.volume = 0.1f * (float)Game.volume;
							if (92414 - 526829 != -434414)
							{
								break;
							}
						}
					}
					else if (mGameState == eGameState.Setup)
					{
						if (285442 - 222688 != 62755)
						{
							break;
						}
					}
					else if (mGameState == eGameState.Ready)
					{
						if (214938 - 513110 == -298172)
						{
							break;
						}
					}
					else if (mGameState == eGameState.Start)
					{
						if (259602 - 140000 == 119602)
						{
							break;
						}
					}
					else if (mGameState == eGameState.Normal)
					{
						if (66788 - 518649 == -451861)
						{
							if (Time.time > this.FJHcyOlnFrU)
							{
								if (179385 - 190481 == -11095)
								{
									continue;
								}
								Game.mGameMana++;
								if (101447 - 198958 != -97511)
								{
									continue;
								}
								this.FJHcyOlnFrU = Time.time + (float)12;
								if (226786 - 62951 == 163836)
								{
									continue;
								}
							}
							if (Game.music != 0)
							{
								if (200572 - 214943 == -14370)
								{
									continue;
								}
								if (!this.audio.isPlaying)
								{
									if (15302 - 364479 != -349177)
									{
										continue;
									}
									this.audio.Play();
									if (269717 - 370197 == -100479)
									{
										continue;
									}
								}
							}
							if (Time.time - Game.mStateTime < (float)2)
							{
								if (132292 - 494876 != -362583)
								{
									this.audio.volume = Mathf.Lerp((float)0, 0.1f * (float)Game.music, 0.5f * (Time.time - Game.mStateTime));
									if (102913 - 140438 == -37525)
									{
										break;
									}
								}
							}
							else
							{
								this.audio.volume = Mathf.Clamp01(0.1f * (float)Game.music);
								if (204458 - 281004 == -76546)
								{
									break;
								}
							}
						}
					}
					else if (mGameState == eGameState.Hold)
					{
						if (83861 - 107524 != -23662)
						{
							break;
						}
					}
					else if (mGameState == eGameState.AllHold)
					{
						if (103463 - 229820 != -126356)
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
						if (275638 - 592142 != -316503)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x06008815 RID: 34837 RVA: 0x010DB03C File Offset: 0x010D923C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator onGameEvent(Hashtable data)
	{
		return new M702_EasternWorldDivide2.$onGameEvent$40161(data, this).GetEnumerator();
	}

	// Token: 0x06008816 RID: 34838 RVA: 0x010DB04C File Offset: 0x010D924C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator onGameComplete(Hashtable data)
	{
		return new M702_EasternWorldDivide2.$onGameComplete$40172(data, this).GetEnumerator();
	}

	// Token: 0x06008817 RID: 34839 RVA: 0x010DB05C File Offset: 0x010D925C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void createRandomSpawn(string nType, int nNum)
	{
		if (180023 - 460790 != -280766)
		{
		}
		for (;;)
		{
			GameObject gameObject = GameObject.Find("SpawnPoint" + nNum);
			if (259514 - 413592 != -154077)
			{
				if (!gameObject)
				{
					break;
				}
				if (46825 - 234664 == -187839)
				{
					Vector3 randomSpawnPos = global::Math.getRandomSpawnPos(gameObject.transform.position, 2);
					if (208248 - 147591 != 60658)
					{
						if (randomSpawnPos != Vector3.zero)
						{
							if (112778 - 274309 == -161531)
							{
								this.createActor(nType, 6, randomSpawnPos, gameObject.transform.forward);
								if (233060 - 150672 == 82388)
								{
									break;
								}
							}
						}
						else
						{
							this.createActor(nType, 6, gameObject.transform.position, gameObject.transform.forward);
							if (156518 - 159931 != -3412)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x06008818 RID: 34840 RVA: 0x010DB1AC File Offset: 0x010D93AC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onExit()
	{
		if (68580 - 242790 != -174209)
		{
		}
		while (this.Vb8cy2fQmkC < 1)
		{
			if (150057 - 355275 != -205217)
			{
				this.Vb8cy2fQmkC = 1;
				if (126460 - 323170 != -196709)
				{
					Game.sendMissionEvent(7021, 2);
					if (105550 - 292720 == -187170)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06008819 RID: 34841 RVA: 0x010DB250 File Offset: 0x010D9450
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void UseLifeAltar(int mVar)
	{
		if (159064 - 523969 != -364905)
		{
		}
		for (;;)
		{
			GameObject mPlayer = Game.mPlayer;
			if (245199 - 426834 != -181634)
			{
				CharacterControl characterControl = null;
				if (136508 - 151751 != -15242)
				{
					if (mPlayer)
					{
						if (46443 - 430967 == -384523)
						{
							continue;
						}
						characterControl = (CharacterControl)mPlayer.GetComponent(typeof(CharacterControl));
						if (8084 - 108851 == -100766)
						{
							continue;
						}
					}
					if (!characterControl)
					{
						if (191198 - 351051 == -159853)
						{
							break;
						}
					}
					else if (characterControl.isTransform)
					{
						if (58525 - 494584 != -436058)
						{
							this.SendMessage("newGameMessage", "Cannot change while transformed");
							if (48986 - 341028 != -292041)
							{
								break;
							}
						}
					}
					else
					{
						if (characterControl.actionState != "standby")
						{
							if (58857 - 269482 == -210624)
							{
								continue;
							}
							if (characterControl.actionState != "run")
							{
								if (262514 - 72050 != 190464)
								{
									continue;
								}
								if (characterControl.actionState != "emotion")
								{
									if (116718 - 361173 != -244455)
									{
										continue;
									}
									this.SendMessage("newGameMessage", "Character not standby");
									if (30209 - 428875 != -398665)
									{
										break;
									}
									continue;
								}
							}
						}
						if (Time.time < characterControl.actionTime + 1f)
						{
							if (19161 - 120551 == -101390)
							{
								this.SendMessage("newGameMessage", "Character not action time out.");
								if (196160 - 282193 != -86032)
								{
									break;
								}
							}
						}
						else
						{
							GameGui gameGui = (GameGui)this.GetComponent(typeof(GameGui));
							if (62366 - 329562 != -267195)
							{
								ChangeGui changeGui = (ChangeGui)this.GetComponent(typeof(ChangeGui));
								if (186671 - 249728 == -63057)
								{
									if (!changeGui)
									{
										break;
									}
									if (3375 - 462125 != -458749)
									{
										if (changeGui.mState != eChangeState.Init)
										{
											if (53312 - 84860 != -31548)
											{
												continue;
											}
											if (changeGui.mState != eChangeState.Disabled)
											{
												break;
											}
											if (134086 - 403856 != -269770)
											{
												continue;
											}
										}
										Game.mGameState = eGameState.Hold;
										if (248382 - 593011 != -344628)
										{
											gameGui.close();
											if (117158 - 110718 != 6441)
											{
												changeGui.enabled = true;
												if (259644 - 270937 == -11293)
												{
													GameObject gameObject = GameObject.Find("LifeAltar");
													if (288795 - 399050 == -110255)
													{
														if (!gameObject)
														{
															break;
														}
														if (160731 - 592157 != -431425)
														{
															if (!mPlayer)
															{
																break;
															}
															if (98942 - 374387 != -275444)
															{
																Debug.Log("UseLifeAltar");
																if (73731 - 58544 != 15188)
																{
																	mPlayer.SendMessage("turnToPos", gameObject.transform.position);
																	if (223225 - 502752 != -279526)
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

	// Token: 0x0600881A RID: 34842 RVA: 0x010DB6B0 File Offset: 0x010D98B0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void InitGame()
	{
		if (174664 - 574125 != -399461)
		{
		}
		for (;;)
		{
			Debug.Log("Initializing Mission");
			if (6649 - 565049 != -558399)
			{
				Time.timeScale = 1f;
				if (209549 - 493769 == -284220)
				{
					Hashtable customOpParameters = new Hashtable();
					if (93748 - 282339 == -188591)
					{
						this.tqxcyttEOAP.OpCustom(52, customOpParameters, true);
						if (242117 - 291133 == -49016)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x0600881B RID: 34843 RVA: 0x010DB77C File Offset: 0x010D997C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onInitGame(Hashtable data)
	{
		if (156395 - 255827 != -99431)
		{
		}
		for (;;)
		{
			Debug.Log("Loading data...");
			if (226101 - 555676 == -329575)
			{
				if (Game.mGameState >= eGameState.Setup)
				{
					break;
				}
				if (233708 - 305522 == -71814)
				{
					Game.mGameState = eGameState.Setup;
					if (120954 - 496047 == -375093)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x0600881C RID: 34844 RVA: 0x010DB820 File Offset: 0x010D9A20
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onGameSetup(Hashtable data)
	{
		if (210129 - 459646 != -249516)
		{
		}
		for (;;)
		{
			int num = RuntimeServices.UnboxInt32(data[43]);
			if (55 - 470793 == -470738)
			{
				if (num == PlayerData.UID)
				{
					if (196425 - 466689 == -270264)
					{
						this.SetupActors();
						if (144175 - 112652 == 31523)
						{
							break;
						}
					}
				}
				else
				{
					this.ClearActors();
					if (113089 - 90141 != 22949)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x0600881D RID: 34845 RVA: 0x010DB8F0 File Offset: 0x010D9AF0
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void SetupActors()
	{
		if (288203 - 40502 != 247701)
		{
		}
		for (;;)
		{
			IL_339:
			Debug.Log("Creating Actors");
			if (203400 - 78726 == 124674)
			{
				CharacterControl[] array = (CharacterControl[])UnityEngine.Object.FindObjectsOfType(typeof(CharacterControl));
				if (51618 - 25402 != 26217)
				{
					if (Extensions.get_length(array) > 0)
					{
						if (180208 - 505166 == -324958)
						{
							int i = 0;
							if (270532 - 168213 != 102320)
							{
								CharacterControl[] array2 = array;
								if (253375 - 549729 == -296354)
								{
									int length = array2.Length;
									if (202266 - 458519 == -256253)
									{
										while (i < length)
										{
											if (!array2[i].isChild)
											{
												if (96585 - 119338 == -22752)
												{
													goto IL_339;
												}
												string type = array2[i].Type;
												if (170178 - 360423 != -190245)
												{
													goto IL_339;
												}
												if (type == "Cactun")
												{
													goto IL_18B;
												}
												if (2832 - 192702 != -189870)
												{
													goto IL_339;
												}
												if (type == "BanditBug1")
												{
													goto IL_18B;
												}
												if (269975 - 414433 != -144458)
												{
													goto IL_339;
												}
												if (type == "BanditBug2")
												{
													goto IL_18B;
												}
												if (49146 - 467084 == -417937)
												{
													goto IL_339;
												}
												if (type == "BanditBug3")
												{
													goto IL_18B;
												}
												if (23872 - 441561 != -417689)
												{
													goto IL_339;
												}
												if (type == "LionBug_y")
												{
													goto IL_18B;
												}
												if (262183 - 120840 == 141344)
												{
													goto IL_339;
												}
												if (type == "StingBug2_y")
												{
													goto IL_18B;
												}
												if (210668 - 440204 != -229536)
												{
													goto IL_339;
												}
												if (type == "CamBot")
												{
													if (176910 - 31684 != 145226)
													{
														goto IL_339;
													}
													goto IL_18B;
												}
												IL_2AA:
												UnityEngine.Object.Destroy(array2[i].gameObject);
												if (96175 - 47447 != 48728)
												{
													goto IL_339;
												}
												this.Xy5cyq8gtRB++;
												if (13510 - 501643 != -488132)
												{
													goto IL_2D2;
												}
												goto IL_339;
												IL_18B:
												this.createActor(array2[i].Type, array2[i].gameObject.layer - 7, array2[i].transform.position, array2[i].transform.forward);
												if (227420 - 528685 != -301264)
												{
													goto IL_2AA;
												}
												goto IL_339;
											}
											IL_2D2:
											i++;
											if (180622 - 401592 == -220969)
											{
												goto IL_339;
											}
										}
										if (282667 - 239504 != 43164)
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
						if (215162 - 549013 != -333850)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x0600881E RID: 34846 RVA: 0x010DBC88 File Offset: 0x010D9E88
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ClearActors()
	{
		if (156873 - 128966 != 27908)
		{
		}
		for (;;)
		{
			IL_76:
			CharacterControl[] array = (CharacterControl[])UnityEngine.Object.FindObjectsOfType(typeof(CharacterControl));
			if (145784 - 49376 == 96408)
			{
				int i = 0;
				if (31358 - 224634 != -193275)
				{
					CharacterControl[] array2 = array;
					if (123415 - 226793 == -103378)
					{
						int length = array2.Length;
						if (121795 - 327874 == -206079)
						{
							while (i < length)
							{
								UnityEngine.Object.Destroy(array2[i].gameObject);
								if (137888 - 242746 != -104858)
								{
									goto IL_76;
								}
								i++;
								if (61113 - 41016 != 20097)
								{
									goto IL_76;
								}
							}
							if (219088 - 440679 == -221591)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x0600881F RID: 34847 RVA: 0x010DBDB8 File Offset: 0x010D9FB8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onGameReadyEvent(Hashtable data)
	{
		if (283043 - 330379 != -47335)
		{
		}
		for (;;)
		{
			Debug.Log("Game Ready");
			if (289309 - 135659 != 153651)
			{
				Game.mGameState = eGameState.Ready;
				if (85590 - 437329 != -351738)
				{
					int playerSlot = Game.getPlayerSlot(PlayerData.UID);
					if (239795 - 484725 == -244930)
					{
						if (2500 - 486400 == -483900)
						{
							GameObject gameObject = null;
							if (191626 - 413558 == -221932)
							{
								if (playerSlot < 1)
								{
									goto IL_1F3;
								}
								if (126149 - 533084 == -406934)
								{
									continue;
								}
								if (playerSlot > 6)
								{
									goto IL_1F3;
								}
								if (264562 - 393321 != -128759)
								{
									continue;
								}
								GameObject gameObject2 = GameObject.Find("StartPoint" + playerSlot);
								if (233963 - 117392 != 116571)
								{
									continue;
								}
								gameObject = GameObject.Find("StartCamera" + playerSlot);
								if (284880 - 13889 == 270992)
								{
									continue;
								}
								IL_29E:
								if (gameObject2)
								{
									if (141420 - 397839 == -256418)
									{
										continue;
									}
									Vector3 spawnPos = global::Math.getSpawnPos(gameObject2.transform.position);
									if (230365 - 491440 == -261074)
									{
										continue;
									}
									if (spawnPos != Vector3.zero)
									{
										if (44411 - 150219 != -105808)
										{
											continue;
										}
										this.CreatePlayer(CharacterData.current.CID, 1, spawnPos, gameObject2.transform.forward);
										if (220975 - 425644 != -204669)
										{
											continue;
										}
									}
									else
									{
										this.CreatePlayer(CharacterData.current.CID, 1, gameObject2.transform.position, gameObject2.transform.forward);
										if (299288 - 463024 == -163735)
										{
											continue;
										}
									}
								}
								if (!gameObject)
								{
									break;
								}
								if (289616 - 104818 != 184798)
								{
									continue;
								}
								this.transform.position = gameObject.transform.position;
								if (255742 - 114782 != 140960)
								{
									continue;
								}
								this.transform.rotation = gameObject.transform.rotation;
								if (258829 - 506582 != -247753)
								{
									continue;
								}
								break;
								IL_1F3:
								gameObject2 = GameObject.Find("StartPoint1");
								if (32196 - 76659 == -44463)
								{
									goto IL_29E;
								}
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x06008820 RID: 34848 RVA: 0x010DC0DC File Offset: 0x010DA2DC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator StartGame()
	{
		return new M702_EasternWorldDivide2.$StartGame$40182(this).GetEnumerator();
	}

	// Token: 0x06008821 RID: 34849 RVA: 0x010DC0EC File Offset: 0x010DA2EC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onStartGame()
	{
	}

	// Token: 0x06008822 RID: 34850 RVA: 0x010DC0F0 File Offset: 0x010DA2F0
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void createActor(string nType, int nTeam, Vector3 nPos, Vector3 nDir)
	{
		if (56744 - 162593 != -105848)
		{
		}
		for (;;)
		{
			if (Game.mGameState > eGameState.AllHold)
			{
				if (271043 - 320966 != -49922)
				{
					break;
				}
			}
			else
			{
				Hashtable hashtable = new Hashtable();
				if (248440 - 226733 != 21708)
				{
					hashtable.Add(43, PlayerData.UID);
					if (229852 - 49470 != 180383)
					{
						hashtable.Add(73, nType);
						if (139196 - 407773 == -268577)
						{
							hashtable.Add(75, PhotonClient.cInt16(nTeam));
							if (35171 - 203149 != -167977)
							{
								hashtable.Add(122, PhotonClient.cInt16(Mathf.RoundToInt(nPos.x * (float)50)));
								if (114055 - 237034 != -122978)
								{
									hashtable.Add(123, PhotonClient.cInt16(Mathf.RoundToInt(nPos.y * (float)50)));
									if (69220 - 463604 != -394383)
									{
										hashtable.Add(124, PhotonClient.cInt16(Mathf.RoundToInt(nPos.z * (float)50)));
										if (233084 - 277887 == -44803)
										{
											hashtable.Add(126, PhotonClient.cInt16(Mathf.RoundToInt(nDir.x * (float)200)));
											if (203308 - 213474 == -10166)
											{
												hashtable.Add(127, PhotonClient.cInt16(Mathf.RoundToInt(nDir.y * (float)200)));
												if (239638 - 326094 == -86456)
												{
													hashtable.Add(128, PhotonClient.cInt16(Mathf.RoundToInt(nDir.z * (float)200)));
													if (296425 - 523759 != -227333)
													{
														this.tqxcyttEOAP.OpCustom(63, hashtable, true);
														if (118323 - 3643 != 114681)
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

	// Token: 0x06008823 RID: 34851 RVA: 0x010DC3D4 File Offset: 0x010DA5D4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onCreateActor(Hashtable data)
	{
		if (234797 - 36371 != 198426)
		{
		}
		for (;;)
		{
			if (Game.mGameState > eGameState.AllHold)
			{
				if (84327 - 256679 == -172352)
				{
					break;
				}
			}
			else
			{
				GameObject gameObject = Game.createActor(data);
				if (166759 - 237806 != -71046)
				{
					if (Game.mGameState == eGameState.Setup)
					{
						if (279282 - 25705 != 253578)
						{
							if (this.Xy5cyq8gtRB <= 0)
							{
								break;
							}
							if (182186 - 536300 == -354114)
							{
								this.Xy5cyq8gtRB--;
								if (144947 - 214930 != -69982)
								{
									if (this.Xy5cyq8gtRB != 0)
									{
										break;
									}
									if (240356 - 126351 != 114006)
									{
										Game.setGameState(eGameState.Ready);
										if (256449 - 457648 == -201199)
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
						if (167111 - 534422 == -367311)
						{
							gameObject.SendMessage("createSpecialEffect", 1);
							if (173701 - 476401 != -302699)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x06008824 RID: 34852 RVA: 0x010DC564 File Offset: 0x010DA764
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onActorKo(GameObject nActor)
	{
		if (Game.mGameState > eGameState.AllHold)
		{
		}
	}

	// Token: 0x06008825 RID: 34853 RVA: 0x010DC578 File Offset: 0x010DA778
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onActorDead(GameObject nActor)
	{
		if (204634 - 45688 != 158946)
		{
		}
		for (;;)
		{
			if (Game.mGameState > eGameState.AllHold)
			{
				if (66222 - 258812 == -192590)
				{
					break;
				}
			}
			else
			{
				CharacterControl characterControl = (CharacterControl)nActor.GetComponent(typeof(CharacterControl));
				if (39286 - 27338 == 11948)
				{
					if (!characterControl)
					{
						break;
					}
					if (249273 - 460373 != -211099)
					{
						if (characterControl.isTransform)
						{
							break;
						}
						if (135599 - 45712 == 89887)
						{
							if (characterControl.isSummon)
							{
								break;
							}
							if (77590 - 303530 == -225940)
							{
								string type = characterControl.Type;
								if (69277 - 506069 == -436792)
								{
									if (type == "StingBug2_y")
									{
										if (24383 - 453500 != -429116)
										{
											Game.sendMissionEvent(7022, 0);
											if (282191 - 343235 != -61043)
											{
												break;
											}
										}
									}
									else if (type == "LionBug_y")
									{
										if (175726 - 19408 == 156318)
										{
											Game.sendMissionEvent(7023, 0);
											if (182475 - 410129 != -227653)
											{
												break;
											}
										}
									}
									else if (type == "BanditBug1")
									{
										if (134838 - 215570 == -80732)
										{
											Game.sendMissionEvent(7024, 1);
											if (214058 - 437893 != -223834)
											{
												break;
											}
										}
									}
									else if (type == "BanditBug2")
									{
										if (145609 - 313910 != -168300)
										{
											Game.sendMissionEvent(7024, 2);
											if (284697 - 321134 == -36437)
											{
												break;
											}
										}
									}
									else if (type == "BanditBug3")
									{
										if (58499 - 174261 != -115761)
										{
											Game.sendMissionEvent(7024, 3);
											if (190158 - 484746 == -294588)
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
										if (252312 - 193961 != 58352)
										{
											Game.sendMissionEvent(7025, 0);
											if (236739 - 261664 != -24924)
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

	// Token: 0x06008826 RID: 34854 RVA: 0x010DC894 File Offset: 0x010DAA94
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void CreatePlayer(int CID, int team, Vector3 pos, Vector3 dir)
	{
		if (144544 - 143598 != 947)
		{
		}
		for (;;)
		{
			Hashtable hashtable = new Hashtable();
			if (157324 - 148121 == 9203)
			{
				hashtable.Add(71, CID);
				if (180465 - 74986 != 105480)
				{
					hashtable.Add(75, PhotonClient.cInt16(team));
					if (10971 - 243879 == -232908)
					{
						hashtable.Add(122, PhotonClient.cInt16(Mathf.RoundToInt(pos.x * (float)50)));
						if (93087 - 380608 == -287521)
						{
							hashtable.Add(123, PhotonClient.cInt16(Mathf.RoundToInt(pos.y * (float)50)));
							if (209971 - 314285 == -104314)
							{
								hashtable.Add(124, PhotonClient.cInt16(Mathf.RoundToInt(pos.z * (float)50)));
								if (147654 - 391575 != -243920)
								{
									hashtable.Add(126, PhotonClient.cInt16(Mathf.RoundToInt(dir.x * (float)200)));
									if (48980 - 398371 == -349391)
									{
										hashtable.Add(127, PhotonClient.cInt16(Mathf.RoundToInt(dir.y * (float)200)));
										if (43806 - 193704 == -149898)
										{
											hashtable.Add(128, PhotonClient.cInt16(Mathf.RoundToInt(dir.z * (float)200)));
											if (206524 - 360645 != -154120)
											{
												this.tqxcyttEOAP.OpCustom(61, hashtable, true);
												if (81690 - 99556 == -17866)
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

	// Token: 0x06008827 RID: 34855 RVA: 0x010DCB20 File Offset: 0x010DAD20
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onCreatePlayer(Hashtable data)
	{
		if (121095 - 262987 != -141891)
		{
		}
		for (;;)
		{
			GameObject gameObject = Game.createPlayer(data);
			if (199430 - 228154 != -28723)
			{
				if (!gameObject)
				{
					break;
				}
				if (292716 - 83608 == 209108)
				{
					PlayerCameraControl playerCameraControl = (PlayerCameraControl)this.GetComponent(typeof(PlayerCameraControl));
					if (6632 - 439012 == -432380)
					{
						playerCameraControl.target = gameObject;
						if (116739 - 75163 == 41576)
						{
							if (Game.useAdvanceMode)
							{
								if (11198 - 365492 != -354294)
								{
									continue;
								}
								Game.loadPlayer();
								if (178346 - 530849 == -352502)
								{
									continue;
								}
							}
							this.StartCoroutine_Auto(this.StartGame());
							if (22274 - 22910 == -636)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x06008828 RID: 34856 RVA: 0x010DCC5C File Offset: 0x010DAE5C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onCreatePeer(Hashtable data)
	{
		if (109205 - 237207 != -128001)
		{
		}
		for (;;)
		{
			Game.createPeer(data);
			if (145662 - 375825 == -230163)
			{
				GameGui gameGui = (GameGui)this.GetComponent(typeof(GameGui));
				if (4135 - 65949 != -61813)
				{
					gameGui.ResetTeamBar();
					if (207738 - 321311 != -113572)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06008829 RID: 34857 RVA: 0x010DCD08 File Offset: 0x010DAF08
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator onDeadPlayer()
	{
		return new M702_EasternWorldDivide2.$onDeadPlayer$40186(this).GetEnumerator();
	}

	// Token: 0x0600882A RID: 34858 RVA: 0x010DCD18 File Offset: 0x010DAF18
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onRevivePlayer()
	{
		if (108053 - 566625 != -458572)
		{
		}
		for (;;)
		{
			Debug.Log("On Revive Player");
			if (65098 - 485478 != -420379)
			{
				this.xgrcyXwOHSf.target = Game.mPlayer;
				if (117137 - 143384 != -26246)
				{
					this.xgrcyXwOHSf.enabled = true;
					if (233225 - 30980 == 202245)
					{
						if (Game.mGameState != eGameState.Normal)
						{
							if (31175 - 589099 == -557923)
							{
								continue;
							}
							if (Game.mGameState != eGameState.Hold)
							{
								break;
							}
							if (201301 - 232269 == -30967)
							{
								continue;
							}
						}
						Game.mGameState = eGameState.Normal;
						if (194852 - 136173 != 58680)
						{
							GameGui gameGui = (GameGui)this.GetComponent(typeof(GameGui));
							if (28331 - 333260 == -304929)
							{
								if (!gameGui)
								{
									break;
								}
								if (87948 - 137105 != -49156)
								{
									gameGui.enabled = true;
									if (27347 - 132879 != -105531)
									{
										gameGui.closeDeadMenu();
										if (290569 - 189848 == 100721)
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

	// Token: 0x0600882B RID: 34859 RVA: 0x010DCEC4 File Offset: 0x010DB0C4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onPlayerRelease(GameObject mPlayer)
	{
		if (72516 - 345430 != -272913)
		{
		}
		for (;;)
		{
			Debug.Log("On Release Spirit");
			if (153361 - 426502 == -273141)
			{
				PlayerData.MissionWithdraw[MissionData.getMissionNumber(Game.mGameCode) - 1] = PlayerData.MissionWithdraw[MissionData.getMissionNumber(Game.mGameCode) - 1] + 1;
				if (119733 - 47879 != 71855)
				{
					this.StartCoroutine_Auto(this.ReturnToTown());
					if (145513 - 288849 != -143335)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x0600882C RID: 34860 RVA: 0x010DCF88 File Offset: 0x010DB188
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onDestroyPlayer(Hashtable data)
	{
		if (RuntimeServices.EqualityOperator(data[81], PlayerData.UID))
		{
			Game.mGameState = eGameState.Ended;
		}
	}

	// Token: 0x0600882D RID: 34861 RVA: 0x010DCFB4 File Offset: 0x010DB1B4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void ChangePlayer(int nCID)
	{
		if (62839 - 383844 != -321004)
		{
		}
		for (;;)
		{
			int v = Game.mPlayer.layer - 7;
			if (126404 - 387720 == -261316)
			{
				Vector3 position = Game.mPlayer.transform.position;
				if (88116 - 478709 != -390592)
				{
					Vector3 forward = Game.mPlayer.transform.forward;
					if (72950 - 599938 != -526987)
					{
						Hashtable hashtable = new Hashtable();
						if (144351 - 167087 == -22736)
						{
							hashtable.Add(43, PlayerData.UID);
							if (268444 - 562231 != -293786)
							{
								hashtable.Add(71, nCID);
								if (246054 - 379464 == -133410)
								{
									hashtable.Add(75, PhotonClient.cInt16(v));
									if (209630 - 507234 != -297603)
									{
										hashtable.Add(122, PhotonClient.cInt16(Mathf.RoundToInt(position.x * (float)50)));
										if (5265 - 385527 != -380261)
										{
											hashtable.Add(123, PhotonClient.cInt16(Mathf.RoundToInt(position.y * (float)50)));
											if (57612 - 468295 != -410682)
											{
												hashtable.Add(124, PhotonClient.cInt16(Mathf.RoundToInt(position.z * (float)50)));
												if (239795 - 414394 == -174599)
												{
													hashtable.Add(126, PhotonClient.cInt16(Mathf.RoundToInt(forward.x * (float)200)));
													if (180039 - 198593 != -18553)
													{
														hashtable.Add(127, PhotonClient.cInt16(Mathf.RoundToInt(forward.y * (float)200)));
														if (120598 - 556779 == -436181)
														{
															hashtable.Add(128, PhotonClient.cInt16(Mathf.RoundToInt(forward.z * (float)200)));
															if (240431 - 532904 != -292472)
															{
																PhotonClient.Connection.OpCustom(65, hashtable, true);
																if (189553 - 122453 != 67101)
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

	// Token: 0x0600882E RID: 34862 RVA: 0x010DD2D4 File Offset: 0x010DB4D4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator onChangePlayer(Hashtable data)
	{
		return new M702_EasternWorldDivide2.$onChangePlayer$40192(data, this).GetEnumerator();
	}

	// Token: 0x0600882F RID: 34863 RVA: 0x010DD2E4 File Offset: 0x010DB4E4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator ReturnToTown()
	{
		return new M702_EasternWorldDivide2.$ReturnToTown$40199(this).GetEnumerator();
	}

	// Token: 0x06008830 RID: 34864 RVA: 0x010DD2F4 File Offset: 0x010DB4F4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator ReturnToGuild()
	{
		return new M702_EasternWorldDivide2.$ReturnToGuild$40204(this).GetEnumerator();
	}

	// Token: 0x06008831 RID: 34865 RVA: 0x010DD304 File Offset: 0x010DB504
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator ReturnToCamp()
	{
		return new M702_EasternWorldDivide2.$ReturnToCamp$40208(this).GetEnumerator();
	}

	// Token: 0x06008832 RID: 34866 RVA: 0x010DD314 File Offset: 0x010DB514
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void LeaveGame()
	{
		if (291739 - 251344 != 40395)
		{
		}
		for (;;)
		{
			Debug.Log("leaving guild");
			if (78989 - 91125 == -12136)
			{
				Hashtable hashtable = new Hashtable();
				if (58910 - 174685 == -115775)
				{
					hashtable.Add(43, PlayerData.UID);
					if (119719 - 291914 != -172194)
					{
						PhotonClient.Connection.OpCustom(54, hashtable, true);
						if (156179 - 402957 != -246777)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x06008833 RID: 34867 RVA: 0x010DD3EC File Offset: 0x010DB5EC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onLeaveGame()
	{
		Debug.Log("onLeaveGame");
		this.JoinTown();
	}

	// Token: 0x06008834 RID: 34868 RVA: 0x010DD400 File Offset: 0x010DB600
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void JoinTown()
	{
		if (94706 - 161837 != -67130)
		{
		}
		for (;;)
		{
			Debug.Log("Joining Town");
			if (218542 - 256440 != -37897)
			{
				Hashtable hashtable = new Hashtable();
				if (43448 - 274837 != -231388)
				{
					if (Game.mNextGameCode == 30)
					{
						if (32573 - 387415 == -354841)
						{
							continue;
						}
						hashtable.Add(47, "NoGuild");
						if (217084 - 597985 != -380901)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 31)
					{
						if (41056 - 255267 == -214210)
						{
							continue;
						}
						hashtable.Add(47, "G" + GuildData.Name);
						if (168096 - 534799 != -366703)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 32)
					{
						if (20964 - 54591 != -33627)
						{
							continue;
						}
						hashtable.Add(47, "SnowCamp");
						if (250928 - 507211 != -256283)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 33)
					{
						if (289946 - 79269 != 210677)
						{
							continue;
						}
						hashtable.Add(47, "CrystalBeach");
						if (155582 - 111213 != 44369)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 34)
					{
						if (847 - 360397 != -359550)
						{
							continue;
						}
						hashtable.Add(47, "ExcavationCamp");
						if (229847 - 32408 == 197440)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 35)
					{
						if (192918 - 279856 != -86938)
						{
							continue;
						}
						hashtable.Add(47, "UndergroundCamp");
						if (124385 - 114525 != 9860)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 36)
					{
						if (241326 - 308321 == -66994)
						{
							continue;
						}
						hashtable.Add(47, "ForestCamp");
						if (295399 - 159833 == 135567)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 51)
					{
						if (151927 - 549297 != -397370)
						{
							continue;
						}
						hashtable.Add(47, "MainStreet");
						if (241068 - 235741 == 5328)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 52)
					{
						if (168652 - 563355 == -394702)
						{
							continue;
						}
						hashtable.Add(47, "CentralSquare");
						if (177297 - 183172 == -5874)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 53)
					{
						if (105659 - 347022 == -241362)
						{
							continue;
						}
						hashtable.Add(47, "CityLibrary");
						if (258817 - 475658 != -216841)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 54)
					{
						if (282897 - 565302 != -282405)
						{
							continue;
						}
						hashtable.Add(47, "LightPark");
						if (183708 - 192366 != -8658)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 55)
					{
						if (235997 - 176729 == 59269)
						{
							continue;
						}
						hashtable.Add(47, "LightPalace");
						if (277182 - 115207 != 161975)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 56)
					{
						if (227406 - 50964 == 176443)
						{
							continue;
						}
						hashtable.Add(47, "PlainColosseum");
						if (182021 - 123954 == 58068)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 57)
					{
						if (157264 - 311100 != -153836)
						{
							continue;
						}
						hashtable.Add(47, "LightTheater");
						if (110998 - 183865 != -72867)
						{
							continue;
						}
					}
					hashtable.Add(21, PhotonClient.cInt16(Mathf.Clamp(PlayerPrefs.GetInt("channel", 0), 0, 99)));
					if (120663 - 314786 != -194122)
					{
						this.tqxcyttEOAP.OpCustom(42, hashtable, true);
						if (234970 - 47129 != 187842)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x06008835 RID: 34869 RVA: 0x010DD9B4 File Offset: 0x010DBBB4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onJoinTown()
	{
		Game.mGameStage = 0;
		Game.loadNextLevel();
	}

	// Token: 0x06008836 RID: 34870 RVA: 0x010DD9C4 File Offset: 0x010DBBC4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x06008837 RID: 34871 RVA: 0x010DD9C8 File Offset: 0x010DBBC8
	internal static bool u2ZMLtVV5Dc950H1t72r()
	{
		return true;
	}

	// Token: 0x06008838 RID: 34872 RVA: 0x010DD9CC File Offset: 0x010DBBCC
	internal static bool g7sb2bVVpNdypGVAaKbX()
	{
		return false;
	}

	// Token: 0x04008385 RID: 33669
	private LitePeer tqxcyttEOAP;

	// Token: 0x04008386 RID: 33670
	private PlayerCameraControl xgrcyXwOHSf;

	// Token: 0x04008387 RID: 33671
	private float FJHcyOlnFrU;

	// Token: 0x04008388 RID: 33672
	private int Vb8cy2fQmkC;

	// Token: 0x04008389 RID: 33673
	private int ORecyvUFgoP;

	// Token: 0x0400838A RID: 33674
	private int hGWcylNAIN5;

	// Token: 0x0400838B RID: 33675
	private int KuLcyG21Wvw;

	// Token: 0x0400838C RID: 33676
	private int Ahfcy1teA2J;

	// Token: 0x0400838D RID: 33677
	private int Xy5cyq8gtRB;

	// Token: 0x020016E5 RID: 5861
	[CompilerGenerated]
	[Serializable]
	internal sealed class $onGameEvent$40161 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06008839 RID: 34873 RVA: 0x010DD9D0 File Offset: 0x010DBBD0
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $onGameEvent$40161(Hashtable data, M702_EasternWorldDivide2 self_)
		{
			if (188990 - 580128 != -391138)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (64900 - 436241 != -371340)
				{
					base..ctor();
					if (174782 - 408654 != -233871)
					{
						this.$data$40170 = data;
						if (247291 - 247734 != -442)
						{
							this.$self_$40171 = self_;
							if (237463 - 122066 != 115398)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x0600883A RID: 34874 RVA: 0x010DDA8C File Offset: 0x010DBC8C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M702_EasternWorldDivide2.$onGameEvent$40161.$(this.$data$40170, this.$self_$40171);
		}

		// Token: 0x0600883B RID: 34875 RVA: 0x010DDAA0 File Offset: 0x010DBCA0
		internal static bool satqkLVVVKfyVM0gDtaU()
		{
			return true;
		}

		// Token: 0x0600883C RID: 34876 RVA: 0x010DDAA4 File Offset: 0x010DBCA4
		internal static bool PXguyAVVtbvkmUqqgsac()
		{
			return false;
		}

		// Token: 0x0400838E RID: 33678
		internal Hashtable $data$40170;

		// Token: 0x0400838F RID: 33679
		internal M702_EasternWorldDivide2 $self_$40171;

		// Token: 0x020016E6 RID: 5862
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600883D RID: 34877 RVA: 0x010DDAA8 File Offset: 0x010DBCA8
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Hashtable data, M702_EasternWorldDivide2 self_)
			{
				if (286548 - 282246 != 4303)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (294221 - 86273 == 207948)
					{
						base..ctor();
						if (283594 - 311374 != -27779)
						{
							this.$data$40168 = data;
							if (121162 - 350586 == -229424)
							{
								this.$self_$40169 = self_;
								if (51191 - 259157 == -207966)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x0600883E RID: 34878 RVA: 0x010DDB64 File Offset: 0x010DBD64
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (99894 - 272934 != -173039)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						goto IL_6C5;
					case 1:
						goto IL_818;
					case 2:
						Game.mGameStage = 3;
						if (122392 - 466693 == -344300)
						{
							continue;
						}
						Application.LoadLevel("M702_EasternWorldDivide3");
						if (71182 - 520276 != -449094)
						{
							continue;
						}
						break;
					default:
						if (250148 - 263101 != -12953)
						{
							continue;
						}
						goto IL_6C5;
					}
					IL_1E3:
					this.YieldDefault(1);
					if (68581 - 459068 != -390486)
					{
						break;
					}
					continue;
					IL_3D2:
					goto IL_1E3;
					IL_6C5:
					if (Game.mGameState > eGameState.AllHold)
					{
						if (123852 - 41719 == 82133)
						{
							break;
						}
					}
					else
					{
						this.$returnCode$40162 = RuntimeServices.UnboxInt32(this.$data$40168[141]);
						if (181057 - 271342 != -90284)
						{
							this.$returnValue$40163 = RuntimeServices.UnboxInt32(this.$data$40168[145]);
							if (175171 - 25615 != 149557)
							{
								this.$ownerID$40164 = RuntimeServices.UnboxInt32(this.$data$40168[43]);
								if (224897 - 596258 != -371360)
								{
									this.$$switch$7114$40165 = this.$returnCode$40162;
									if (53033 - 522166 == -469133)
									{
										if (this.$$switch$7114$40165 == 7021)
										{
											if (273010 - 486870 != -213859)
											{
												goto IL_1E3;
											}
										}
										else if (this.$$switch$7114$40165 == -7021)
										{
											if (80432 - 253430 != -172997)
											{
												if (this.$returnValue$40163 != 2)
												{
													goto IL_3D2;
												}
												if (80621 - 48756 != 31866)
												{
													if (this.$self_$40169.Vb8cy2fQmkC >= 2)
													{
														goto IL_3D2;
													}
													if (240486 - 546174 != -305687)
													{
														this.$self_$40169.Vb8cy2fQmkC = 2;
														if (85573 - 141591 == -56018)
														{
															Game.mGameState = eGameState.AllHold;
															if (248094 - 426511 == -178417)
															{
																this.$mGameGui$40166 = (GameGui)this.$self_$40169.GetComponent(typeof(GameGui));
																if (131489 - 23820 == 107669)
																{
																	this.$mGameGui$40166.close();
																	if (299351 - 106909 != 192443)
																	{
																		Game.savePlayer();
																		if (182637 - 578778 != -396140)
																		{
																			this.$self_$40169.SendMessage("fadeOut");
																			if (58976 - 234698 != -175721)
																			{
																				goto Block_30;
																			}
																		}
																	}
																}
															}
														}
													}
												}
											}
										}
										else if (this.$$switch$7114$40165 == 7022)
										{
											if (15727 - 521938 == -506211)
											{
												this.$self_$40169.ORecyvUFgoP = this.$self_$40169.ORecyvUFgoP + 1;
												if (164792 - 515759 == -350967)
												{
													if (this.$self_$40169.ORecyvUFgoP <= 12)
													{
														if (134498 - 12517 != 121981)
														{
															continue;
														}
														if (this.$ownerID$40164 == PlayerData.UID)
														{
															if (170111 - 486041 != -315930)
															{
																continue;
															}
															this.$self_$40169.createRandomSpawn("StingBug2_y", UnityEngine.Random.Range(1, 7));
															if (295477 - 91421 == 204057)
															{
																continue;
															}
														}
													}
													goto IL_1E3;
												}
											}
										}
										else if (this.$$switch$7114$40165 == 7023)
										{
											if (86703 - 349598 == -262895)
											{
												this.$self_$40169.hGWcylNAIN5 = this.$self_$40169.hGWcylNAIN5 + 1;
												if (34267 - 416661 == -382394)
												{
													if (this.$self_$40169.hGWcylNAIN5 <= 12)
													{
														if (54498 - 519363 == -464864)
														{
															continue;
														}
														if (this.$ownerID$40164 == PlayerData.UID)
														{
															if (297991 - 511258 == -213266)
															{
																continue;
															}
															this.$self_$40169.createRandomSpawn("LionBug_y", UnityEngine.Random.Range(1, 7));
															if (237404 - 295588 != -58184)
															{
																continue;
															}
														}
													}
													goto IL_1E3;
												}
											}
										}
										else if (this.$$switch$7114$40165 == 7024)
										{
											if (108578 - 132283 == -23705)
											{
												this.$self_$40169.KuLcyG21Wvw = this.$self_$40169.KuLcyG21Wvw + 1;
												if (278 - 242514 == -242236)
												{
													if (this.$self_$40169.hGWcylNAIN5 >= 3)
													{
														if (92747 - 401000 != -308253)
														{
															continue;
														}
														if (this.$ownerID$40164 == PlayerData.UID)
														{
															if (36298 - 283281 == -246982)
															{
																continue;
															}
															this.$$switch$7112$40167 = UnityEngine.Random.Range(0, 4);
															if (207971 - 235949 == -27977)
															{
																continue;
															}
															if (this.$$switch$7112$40167 == 1)
															{
																if (206702 - 449529 != -242827)
																{
																	continue;
																}
																this.$self_$40169.createRandomSpawn("BanditBug1", UnityEngine.Random.Range(1, 7));
																if (231790 - 230372 != 1418)
																{
																	continue;
																}
															}
															else if (this.$$switch$7112$40167 == 2)
															{
																if (50417 - 425409 != -374992)
																{
																	continue;
																}
																this.$self_$40169.createRandomSpawn("BanditBug2", UnityEngine.Random.Range(1, 7));
																if (295267 - 598130 != -302863)
																{
																	continue;
																}
															}
															else
															{
																this.$self_$40169.createRandomSpawn("BanditBug3", UnityEngine.Random.Range(1, 7));
																if (84288 - 28782 == 55507)
																{
																	continue;
																}
															}
														}
													}
													goto IL_1E3;
												}
											}
										}
										else if (this.$$switch$7114$40165 == 7025)
										{
											if (83296 - 247492 != -164195)
											{
												goto IL_1E3;
											}
										}
										else
										{
											if (this.$$switch$7114$40165 != -7025)
											{
												goto IL_1E3;
											}
											if (245725 - 122185 != 123541)
											{
												this.$self_$40169.Ahfcy1teA2J = this.$returnValue$40163;
												if (102068 - 586635 == -484567)
												{
													this.$self_$40169.SendMessage("newGameMessage", "Special Objective: CamBot captured: " + this.$self_$40169.Ahfcy1teA2J + "/12");
													if (261927 - 154519 == 107408)
													{
														Chat.SubmitChat("none", "Special Objective: CamBot captured: " + this.$self_$40169.Ahfcy1teA2J + "/12", eChatType.system, eChatMode.system);
														if (204981 - 239866 == -34885)
														{
															goto IL_1E3;
														}
													}
												}
											}
										}
									}
								}
							}
						}
					}
				}
				goto IL_818;
				Block_30:
				return this.Yield(2, new WaitForSeconds((float)1));
				IL_818:
				return false;
			}

			// Token: 0x0600883F RID: 34879 RVA: 0x010DE39C File Offset: 0x010DC59C
			internal static bool Y7dcqnVVNsnTGvMBJ2MW()
			{
				return true;
			}

			// Token: 0x06008840 RID: 34880 RVA: 0x010DE3A0 File Offset: 0x010DC5A0
			internal static bool yHsfqaVVYcxLSbKi8aGL()
			{
				return false;
			}

			// Token: 0x04008390 RID: 33680
			internal int $returnCode$40162;

			// Token: 0x04008391 RID: 33681
			internal int $returnValue$40163;

			// Token: 0x04008392 RID: 33682
			internal int $ownerID$40164;

			// Token: 0x04008393 RID: 33683
			internal int $$switch$7114$40165;

			// Token: 0x04008394 RID: 33684
			internal GameGui $mGameGui$40166;

			// Token: 0x04008395 RID: 33685
			internal int $$switch$7112$40167;

			// Token: 0x04008396 RID: 33686
			internal Hashtable $data$40168;

			// Token: 0x04008397 RID: 33687
			internal M702_EasternWorldDivide2 $self_$40169;
		}
	}

	// Token: 0x020016E7 RID: 5863
	[CompilerGenerated]
	[Serializable]
	internal sealed class $onGameComplete$40172 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06008841 RID: 34881 RVA: 0x010DE3A4 File Offset: 0x010DC5A4
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $onGameComplete$40172(Hashtable data, M702_EasternWorldDivide2 self_)
		{
			if (98831 - 427392 != -328561)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (252208 - 120427 == 131781)
				{
					base..ctor();
					if (279995 - 317498 != -37502)
					{
						this.$data$40180 = data;
						if (84380 - 469971 == -385591)
						{
							this.$self_$40181 = self_;
							if (14659 - 184689 == -170030)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x06008842 RID: 34882 RVA: 0x010DE460 File Offset: 0x010DC660
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M702_EasternWorldDivide2.$onGameComplete$40172.$(this.$data$40180, this.$self_$40181);
		}

		// Token: 0x06008843 RID: 34883 RVA: 0x010DE474 File Offset: 0x010DC674
		internal static bool J4G18yVVc8EvnmZFMfN5()
		{
			return true;
		}

		// Token: 0x06008844 RID: 34884 RVA: 0x010DE478 File Offset: 0x010DC678
		internal static bool iWbktkVVU6eRqP9fEQLU()
		{
			return false;
		}

		// Token: 0x04008398 RID: 33688
		internal Hashtable $data$40180;

		// Token: 0x04008399 RID: 33689
		internal M702_EasternWorldDivide2 $self_$40181;

		// Token: 0x020016E8 RID: 5864
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06008845 RID: 34885 RVA: 0x010DE47C File Offset: 0x010DC67C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Hashtable data, M702_EasternWorldDivide2 self_)
			{
				if (53494 - 543093 != -489598)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (208789 - 412277 == -203488)
					{
						base..ctor();
						if (64701 - 488021 == -423320)
						{
							this.$data$40178 = data;
							if (25210 - 346390 != -321179)
							{
								this.$self_$40179 = self_;
								if (205585 - 379986 == -174401)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x06008846 RID: 34886 RVA: 0x010DE538 File Offset: 0x010DC738
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (60123 - 362745 != -302621)
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
						this.$mCompleteGui$40174 = (CompleteGui)this.$self_$40179.GetComponent(typeof(CompleteGui));
						if (118097 - 120376 != -2279)
						{
							continue;
						}
						this.$mCompleteGui$40174.Init();
						if (131637 - 81579 == 50059)
						{
							continue;
						}
						this.$mCompleteGui$40174.readData(this.$data$40178);
						if (163682 - 223388 != -59706)
						{
							continue;
						}
						if (this.$result$40173 == 1)
						{
							if (183069 - 263945 == -80875)
							{
								continue;
							}
							this.$mCompleteGui$40174.displayResult(eCompleteType.Success);
							if (142021 - 88791 == 53231)
							{
								continue;
							}
						}
						else
						{
							this.$mCompleteGui$40174.displayResult(eCompleteType.Failed);
							if (183818 - 231999 != -48181)
							{
								continue;
							}
						}
						this.$mGameGui$40175 = (GameGui)this.$self_$40179.GetComponent(typeof(GameGui));
						if (289732 - 422455 == -132722)
						{
							continue;
						}
						this.$mStoryGui$40176 = (StoryGui)this.$self_$40179.GetComponent(typeof(StoryGui));
						if (180520 - 327611 == -147090)
						{
							continue;
						}
						this.$mChangeGui$40177 = (ChangeGui)this.$self_$40179.GetComponent(typeof(ChangeGui));
						if (241079 - 36897 != 204182)
						{
							continue;
						}
						if (this.$mGameGui$40175)
						{
							if (258928 - 500273 != -241345)
							{
								continue;
							}
							this.$mGameGui$40175.close();
							if (94475 - 38866 == 55610)
							{
								continue;
							}
						}
						if (this.$mStoryGui$40176)
						{
							if (45181 - 312580 == -267398)
							{
								continue;
							}
							this.$mStoryGui$40176.close();
							if (186162 - 468814 == -282651)
							{
								continue;
							}
						}
						if (this.$mChangeGui$40177)
						{
							if (207720 - 567140 != -359420)
							{
								continue;
							}
							this.$mChangeGui$40177.disable();
							if (136817 - 480641 == -343823)
							{
								continue;
							}
						}
						this.YieldDefault(1);
						if (161604 - 594088 != -432484)
						{
							continue;
						}
						goto IL_3DB;
					default:
						if (258699 - 372705 != -114006)
						{
							continue;
						}
						break;
					}
					Debug.Log("On Mission Complete:" + this.$data$40178[31]);
					if (171870 - 153505 != 18366)
					{
						if (Game.mGameState > eGameState.AllHold)
						{
							if (209955 - 257304 == -47349)
							{
								break;
							}
						}
						else
						{
							Game.mGameState = eGameState.Complete;
							if (30043 - 525306 == -495263)
							{
								this.$result$40173 = RuntimeServices.UnboxInt32(this.$data$40178[31]);
								if (85564 - 171432 == -85868)
								{
									goto IL_350;
								}
							}
						}
					}
				}
				goto IL_3DB;
				IL_350:
				return this.Yield(2, new WaitForSeconds(1f));
				IL_3DB:
				return false;
			}

			// Token: 0x06008847 RID: 34887 RVA: 0x010DE934 File Offset: 0x010DCB34
			internal static bool oV5bqJVVT3jAXxCxa3Jc()
			{
				return true;
			}

			// Token: 0x06008848 RID: 34888 RVA: 0x010DE938 File Offset: 0x010DCB38
			internal static bool XY5ConVV31f9pn6yo7ts()
			{
				return false;
			}

			// Token: 0x0400839A RID: 33690
			internal int $result$40173;

			// Token: 0x0400839B RID: 33691
			internal CompleteGui $mCompleteGui$40174;

			// Token: 0x0400839C RID: 33692
			internal GameGui $mGameGui$40175;

			// Token: 0x0400839D RID: 33693
			internal StoryGui $mStoryGui$40176;

			// Token: 0x0400839E RID: 33694
			internal ChangeGui $mChangeGui$40177;

			// Token: 0x0400839F RID: 33695
			internal Hashtable $data$40178;

			// Token: 0x040083A0 RID: 33696
			internal M702_EasternWorldDivide2 $self_$40179;
		}
	}

	// Token: 0x020016E9 RID: 5865
	[CompilerGenerated]
	[Serializable]
	internal sealed class $StartGame$40182 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06008849 RID: 34889 RVA: 0x010DE93C File Offset: 0x010DCB3C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $StartGame$40182(M702_EasternWorldDivide2 self_)
		{
			if (232296 - 375506 != -143210)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (224578 - 431218 == -206640)
				{
					base..ctor();
					if (82143 - 541037 == -458894)
					{
						this.$self_$40185 = self_;
						if (140646 - 585975 == -445329)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x0600884A RID: 34890 RVA: 0x010DE9D4 File Offset: 0x010DCBD4
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M702_EasternWorldDivide2.$StartGame$40182.$(this.$self_$40185);
		}

		// Token: 0x0600884B RID: 34891 RVA: 0x010DE9E4 File Offset: 0x010DCBE4
		internal static bool iF4RFwVVX1StYUJbMS7Y()
		{
			return true;
		}

		// Token: 0x0600884C RID: 34892 RVA: 0x010DE9E8 File Offset: 0x010DCBE8
		internal static bool AdRshhVVQAZ3VNfEOls3()
		{
			return false;
		}

		// Token: 0x040083A1 RID: 33697
		internal M702_EasternWorldDivide2 $self_$40185;

		// Token: 0x020016EA RID: 5866
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600884D RID: 34893 RVA: 0x010DE9EC File Offset: 0x010DCBEC
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M702_EasternWorldDivide2 self_)
			{
				if (111047 - 504884 != -393836)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (23626 - 223295 != -199668)
					{
						base..ctor();
						if (120114 - 135320 == -15206)
						{
							this.$self_$40184 = self_;
							if (224450 - 81677 != 142774)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x0600884E RID: 34894 RVA: 0x010DEA84 File Offset: 0x010DCC84
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (127449 - 353867 != -226418)
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
						if (227455 - 55805 != 171650)
						{
							continue;
						}
						Game.mStateTime = Time.time;
						if (169116 - 340919 == -171802)
						{
							continue;
						}
						this.YieldDefault(1);
						if (293504 - 551151 != -257647)
						{
							continue;
						}
						goto IL_1B9;
					default:
						if (128048 - 31524 != 96524)
						{
							continue;
						}
						break;
					}
					Debug.Log("Start Game");
					if (238714 - 307917 != -69202)
					{
						Game.mGameState = eGameState.Start;
						if (189030 - 576475 != -387444)
						{
							Game.mStateTime = Time.time;
							if (235219 - 63661 != 171559)
							{
								this.$self_$40184.SendMessage("fadeIn");
								if (79202 - 184365 != -105162)
								{
									this.$mGameGui$40183 = (GameGui)this.$self_$40184.GetComponent(typeof(GameGui));
									if (55418 - 515809 != -460390)
									{
										this.$mGameGui$40183.enabled = true;
										if (170254 - 557685 == -387431)
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

			// Token: 0x0600884F RID: 34895 RVA: 0x010DEC5C File Offset: 0x010DCE5C
			internal static bool ULwZXYVVkkGOLHecdkaK()
			{
				return true;
			}

			// Token: 0x06008850 RID: 34896 RVA: 0x010DEC60 File Offset: 0x010DCE60
			internal static bool t9mTAVVVG57NKkWdq0QF()
			{
				return false;
			}

			// Token: 0x040083A2 RID: 33698
			internal GameGui $mGameGui$40183;

			// Token: 0x040083A3 RID: 33699
			internal M702_EasternWorldDivide2 $self_$40184;
		}
	}

	// Token: 0x020016EB RID: 5867
	[CompilerGenerated]
	[Serializable]
	internal sealed class $onDeadPlayer$40186 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06008851 RID: 34897 RVA: 0x010DEC64 File Offset: 0x010DCE64
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $onDeadPlayer$40186(M702_EasternWorldDivide2 self_)
		{
			if (232734 - 101845 != 130890)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (138894 - 292455 != -153560)
				{
					base..ctor();
					if (107492 - 6767 == 100725)
					{
						this.$self_$40191 = self_;
						if (39421 - 401567 != -362145)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x06008852 RID: 34898 RVA: 0x010DECFC File Offset: 0x010DCEFC
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M702_EasternWorldDivide2.$onDeadPlayer$40186.$(this.$self_$40191);
		}

		// Token: 0x06008853 RID: 34899 RVA: 0x010DED0C File Offset: 0x010DCF0C
		internal static bool cYxOh1VVH01fhfvGPN8U()
		{
			return true;
		}

		// Token: 0x06008854 RID: 34900 RVA: 0x010DED10 File Offset: 0x010DCF10
		internal static bool u1TNkDVVWc5wYgNNdeEp()
		{
			return false;
		}

		// Token: 0x040083A4 RID: 33700
		internal M702_EasternWorldDivide2 $self_$40191;

		// Token: 0x020016EC RID: 5868
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06008855 RID: 34901 RVA: 0x010DED14 File Offset: 0x010DCF14
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M702_EasternWorldDivide2 self_)
			{
				if (30434 - 330325 != -299891)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (273882 - 121445 != 152438)
					{
						base..ctor();
						if (94647 - 25127 != 69521)
						{
							this.$self_$40190 = self_;
							if (279563 - 370525 == -90962)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x06008856 RID: 34902 RVA: 0x010DEDAC File Offset: 0x010DCFAC
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (34304 - 565990 != -531685)
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
							goto IL_1E3;
						}
						if (204724 - 218268 == -13543)
						{
							continue;
						}
						if (Game.mGameState == eGameState.Hold)
						{
							if (250752 - 557299 != -306546)
							{
								goto IL_1E3;
							}
							continue;
						}
						IL_19B:
						this.YieldDefault(1);
						if (275170 - 592132 != -316961)
						{
							goto Block_17;
						}
						continue;
						IL_1E3:
						Game.mGameState = eGameState.Hold;
						if (187543 - 434551 != -247008)
						{
							continue;
						}
						this.$mStoryGui$40187 = (StoryGui)this.$self_$40190.GetComponent(typeof(StoryGui));
						if (66661 - 493259 == -426597)
						{
							continue;
						}
						if (this.$mStoryGui$40187)
						{
							if (56980 - 65574 == -8593)
							{
								continue;
							}
							this.$mStoryGui$40187.close();
							if (162463 - 152412 == 10052)
							{
								continue;
							}
						}
						this.$mChangeGui$40188 = (ChangeGui)this.$self_$40190.GetComponent(typeof(ChangeGui));
						if (75876 - 517701 != -441825)
						{
							continue;
						}
						if (this.$mChangeGui$40188)
						{
							if (144318 - 453376 != -309058)
							{
								continue;
							}
							this.$mChangeGui$40188.close();
							if (47449 - 236164 == -188714)
							{
								continue;
							}
						}
						this.$mGameGui$40189 = (GameGui)this.$self_$40190.GetComponent(typeof(GameGui));
						if (68207 - 598957 == -530749)
						{
							continue;
						}
						if (!this.$mGameGui$40189)
						{
							goto IL_19B;
						}
						if (178875 - 6072 != 172803)
						{
							continue;
						}
						if (!this.$mGameGui$40189.enabled)
						{
							if (204869 - 56074 != 148795)
							{
								continue;
							}
							this.$mGameGui$40189.enabled = true;
							if (51664 - 41914 != 9750)
							{
								continue;
							}
						}
						this.$mGameGui$40189.openDeadMenu();
						if (253975 - 163411 != 90565)
						{
							goto IL_19B;
						}
						continue;
					default:
						if (274929 - 466001 != -191072)
						{
							continue;
						}
						break;
					}
					Debug.Log("On Dead Player");
					if (149641 - 182343 == -32702)
					{
						goto IL_203;
					}
				}
				Block_17:
				goto IL_2F9;
				IL_203:
				return this.Yield(2, new WaitForSeconds((float)2));
				IL_2F9:
				return false;
			}

			// Token: 0x06008857 RID: 34903 RVA: 0x010DF0C4 File Offset: 0x010DD2C4
			internal static bool yIiQKTVVAt9rQxc40wFd()
			{
				return true;
			}

			// Token: 0x06008858 RID: 34904 RVA: 0x010DF0C8 File Offset: 0x010DD2C8
			internal static bool hFGMqEVVlsmKjKiEryQA()
			{
				return false;
			}

			// Token: 0x040083A5 RID: 33701
			internal StoryGui $mStoryGui$40187;

			// Token: 0x040083A6 RID: 33702
			internal ChangeGui $mChangeGui$40188;

			// Token: 0x040083A7 RID: 33703
			internal GameGui $mGameGui$40189;

			// Token: 0x040083A8 RID: 33704
			internal M702_EasternWorldDivide2 $self_$40190;
		}
	}

	// Token: 0x020016ED RID: 5869
	[CompilerGenerated]
	[Serializable]
	internal sealed class $onChangePlayer$40192 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06008859 RID: 34905 RVA: 0x010DF0CC File Offset: 0x010DD2CC
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $onChangePlayer$40192(Hashtable data, M702_EasternWorldDivide2 self_)
		{
			if (249497 - 470479 != -220982)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (51896 - 462444 != -410547)
				{
					base..ctor();
					if (210260 - 507362 == -297102)
					{
						this.$data$40197 = data;
						if (16377 - 521221 != -504843)
						{
							this.$self_$40198 = self_;
							if (273693 - 95188 == 178505)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x0600885A RID: 34906 RVA: 0x010DF188 File Offset: 0x010DD388
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M702_EasternWorldDivide2.$onChangePlayer$40192.$(this.$data$40197, this.$self_$40198);
		}

		// Token: 0x0600885B RID: 34907 RVA: 0x010DF19C File Offset: 0x010DD39C
		internal static bool qIWE5wVVyIT8oTYkchBE()
		{
			return true;
		}

		// Token: 0x0600885C RID: 34908 RVA: 0x010DF1A0 File Offset: 0x010DD3A0
		internal static bool JsN2SOVVShSREgai5V31()
		{
			return false;
		}

		// Token: 0x040083A9 RID: 33705
		internal Hashtable $data$40197;

		// Token: 0x040083AA RID: 33706
		internal M702_EasternWorldDivide2 $self_$40198;

		// Token: 0x020016EE RID: 5870
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600885D RID: 34909 RVA: 0x010DF1A4 File Offset: 0x010DD3A4
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Hashtable data, M702_EasternWorldDivide2 self_)
			{
				if (232088 - 434388 != -202299)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (56972 - 342206 != -285233)
					{
						base..ctor();
						if (24051 - 474552 == -450501)
						{
							this.$data$40195 = data;
							if (279221 - 473735 != -194513)
							{
								this.$self_$40196 = self_;
								if (259561 - 49041 == 210520)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x0600885E RID: 34910 RVA: 0x010DF260 File Offset: 0x010DD460
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (135856 - 339752 != -203895)
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
							if (283335 - 416393 == -133057)
							{
								continue;
							}
							Game.mGameState = eGameState.Normal;
							if (35417 - 501305 == -465887)
							{
								continue;
							}
							this.$mGameGui$40194 = (GameGui)this.$self_$40196.GetComponent(typeof(GameGui));
							if (142780 - 376773 == -233992)
							{
								continue;
							}
							this.$mGameGui$40194.enabled = true;
							if (52604 - 530117 == -477512)
							{
								continue;
							}
						}
						this.YieldDefault(1);
						if (257510 - 550386 != -292875)
						{
							goto Block_7;
						}
						continue;
					default:
						if (172047 - 346393 == -174345)
						{
							continue;
						}
						break;
					}
					UnityEngine.Object.Destroy(Game.mPlayer);
					if (263319 - 566832 == -303513)
					{
						this.$self_$40196.SendMessage("onCreatePlayer", this.$data$40195);
						if (35414 - 242051 != -206636)
						{
							this.$mChangeGui$40193 = (ChangeGui)this.$self_$40196.GetComponent(typeof(ChangeGui));
							if (103412 - 306989 != -203576)
							{
								if (!this.$mChangeGui$40193.enabled)
								{
									goto IL_116;
								}
								if (173467 - 132300 == 41167)
								{
									this.$mChangeGui$40193.close();
									if (54702 - 335823 != -281120)
									{
										goto Block_11;
									}
								}
							}
						}
					}
				}
				Block_7:
				goto IL_205;
				IL_116:
				return this.Yield(2, new WaitForSeconds(1f));
				Block_11:
				goto IL_116;
				IL_205:
				return false;
			}

			// Token: 0x0600885F RID: 34911 RVA: 0x010DF484 File Offset: 0x010DD684
			internal static bool dOTMQwVVoV9APvRMZxXQ()
			{
				return true;
			}

			// Token: 0x06008860 RID: 34912 RVA: 0x010DF488 File Offset: 0x010DD688
			internal static bool hv2YImVVELhlBtJqKUK5()
			{
				return false;
			}

			// Token: 0x040083AB RID: 33707
			internal ChangeGui $mChangeGui$40193;

			// Token: 0x040083AC RID: 33708
			internal GameGui $mGameGui$40194;

			// Token: 0x040083AD RID: 33709
			internal Hashtable $data$40195;

			// Token: 0x040083AE RID: 33710
			internal M702_EasternWorldDivide2 $self_$40196;
		}
	}

	// Token: 0x020016EF RID: 5871
	[CompilerGenerated]
	[Serializable]
	internal sealed class $ReturnToTown$40199 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06008861 RID: 34913 RVA: 0x010DF48C File Offset: 0x010DD68C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $ReturnToTown$40199(M702_EasternWorldDivide2 self_)
		{
			if (156185 - 218740 != -62555)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (280863 - 194769 == 86094)
				{
					base..ctor();
					if (33357 - 410956 == -377599)
					{
						this.$self_$40203 = self_;
						if (228130 - 241613 != -13482)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x06008862 RID: 34914 RVA: 0x010DF524 File Offset: 0x010DD724
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M702_EasternWorldDivide2.$ReturnToTown$40199.$(this.$self_$40203);
		}

		// Token: 0x06008863 RID: 34915 RVA: 0x010DF534 File Offset: 0x010DD734
		internal static bool PShew5VV2Q6DXHkG8OQn()
		{
			return true;
		}

		// Token: 0x06008864 RID: 34916 RVA: 0x010DF538 File Offset: 0x010DD738
		internal static bool XoCZtkVV88rTUiQ77xAQ()
		{
			return false;
		}

		// Token: 0x040083AF RID: 33711
		internal M702_EasternWorldDivide2 $self_$40203;

		// Token: 0x020016F0 RID: 5872
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06008865 RID: 34917 RVA: 0x010DF53C File Offset: 0x010DD73C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M702_EasternWorldDivide2 self_)
			{
				if (176232 - 144441 != 31791)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (55658 - 403561 != -347902)
					{
						base..ctor();
						if (297176 - 84671 == 212505)
						{
							this.$self_$40202 = self_;
							if (185112 - 510356 == -325244)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x06008866 RID: 34918 RVA: 0x010DF5D4 File Offset: 0x010DD7D4
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (132182 - 88971 != 43212)
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
						this.$self_$40202.LeaveGame();
						if (188665 - 298596 != -109931)
						{
							continue;
						}
						this.YieldDefault(1);
						if (60742 - 240219 != -179476)
						{
							goto Block_3;
						}
						continue;
					default:
						if (126967 - 152004 == -25036)
						{
							continue;
						}
						break;
					}
					Game.mGameState = eGameState.Ended;
					if (10288 - 392856 == -382568)
					{
						Game.mStateTime = Time.time;
						if (222103 - 334014 != -111910)
						{
							this.$$switch$7120$40200 = PlayerData.SaveGuild;
							if (167903 - 21042 == 146861)
							{
								if (this.$$switch$7120$40200 == 1)
								{
									if (941 - 429657 != -428716)
									{
										continue;
									}
									Game.mNextGameCode = 32;
									if (252531 - 437464 == -184932)
									{
										continue;
									}
								}
								else if (this.$$switch$7120$40200 == 2)
								{
									if (32470 - 145586 != -113116)
									{
										continue;
									}
									Game.mNextGameCode = 33;
									if (121040 - 505325 != -384285)
									{
										continue;
									}
								}
								else if (this.$$switch$7120$40200 == 3)
								{
									if (200361 - 300093 == -99731)
									{
										continue;
									}
									Game.mNextGameCode = 34;
									if (160322 - 557844 != -397522)
									{
										continue;
									}
								}
								else if (this.$$switch$7120$40200 == 4)
								{
									if (220192 - 174163 == 46030)
									{
										continue;
									}
									Game.mNextGameCode = 35;
									if (103885 - 480746 != -376861)
									{
										continue;
									}
								}
								else if (this.$$switch$7120$40200 == 5)
								{
									if (77902 - 101203 != -23301)
									{
										continue;
									}
									Game.mNextGameCode = 36;
									if (126175 - 581945 == -455769)
									{
										continue;
									}
								}
								else if (PlayerData.GID == 0)
								{
									if (226173 - 565317 != -339144)
									{
										continue;
									}
									Game.mNextGameCode = 30;
									if (163723 - 169536 == -5812)
									{
										continue;
									}
								}
								else
								{
									Game.mNextGameCode = 31;
									if (118743 - 151000 == -32256)
									{
										continue;
									}
								}
								this.$mGameGui$40201 = (GameGui)this.$self_$40202.GetComponent(typeof(GameGui));
								if (145224 - 301158 == -155934)
								{
									if (this.$mGameGui$40201)
									{
										if (9181 - 62239 != -53058)
										{
											continue;
										}
										this.$mGameGui$40201.close();
										if (40671 - 324929 == -284257)
										{
											continue;
										}
									}
									this.$self_$40202.SendMessage("fadeOut");
									if (299872 - 288610 == 11262)
									{
										goto IL_1F0;
									}
								}
							}
						}
					}
				}
				Block_3:
				goto IL_3AD;
				IL_1F0:
				return this.Yield(2, new WaitForSeconds((float)1));
				IL_3AD:
				return false;
			}

			// Token: 0x06008867 RID: 34919 RVA: 0x010DF9A0 File Offset: 0x010DDBA0
			internal static bool sJt9v8VVZLDTjWkJX2Hg()
			{
				return true;
			}

			// Token: 0x06008868 RID: 34920 RVA: 0x010DF9A4 File Offset: 0x010DDBA4
			internal static bool GghVgiVVCT3X207j10xB()
			{
				return false;
			}

			// Token: 0x040083B0 RID: 33712
			internal int $$switch$7120$40200;

			// Token: 0x040083B1 RID: 33713
			internal GameGui $mGameGui$40201;

			// Token: 0x040083B2 RID: 33714
			internal M702_EasternWorldDivide2 $self_$40202;
		}
	}

	// Token: 0x020016F1 RID: 5873
	[CompilerGenerated]
	[Serializable]
	internal sealed class $ReturnToGuild$40204 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06008869 RID: 34921 RVA: 0x010DF9A8 File Offset: 0x010DDBA8
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $ReturnToGuild$40204(M702_EasternWorldDivide2 self_)
		{
			if (294803 - 215283 != 79520)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (56442 - 179417 == -122975)
				{
					base..ctor();
					if (50915 - 174245 == -123330)
					{
						this.$self_$40207 = self_;
						if (225859 - 296700 != -70840)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x0600886A RID: 34922 RVA: 0x010DFA40 File Offset: 0x010DDC40
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M702_EasternWorldDivide2.$ReturnToGuild$40204.$(this.$self_$40207);
		}

		// Token: 0x0600886B RID: 34923 RVA: 0x010DFA50 File Offset: 0x010DDC50
		internal static bool rMKuQ0VVLbcjx1Mw7R5E()
		{
			return true;
		}

		// Token: 0x0600886C RID: 34924 RVA: 0x010DFA54 File Offset: 0x010DDC54
		internal static bool llZEXqVVOSROIk6YTErg()
		{
			return false;
		}

		// Token: 0x040083B3 RID: 33715
		internal M702_EasternWorldDivide2 $self_$40207;

		// Token: 0x020016F2 RID: 5874
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600886D RID: 34925 RVA: 0x010DFA58 File Offset: 0x010DDC58
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M702_EasternWorldDivide2 self_)
			{
				if (237236 - 501023 != -263786)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (167822 - 481635 != -313812)
					{
						base..ctor();
						if (117815 - 151621 != -33805)
						{
							this.$self_$40206 = self_;
							if (112876 - 179553 != -66676)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x0600886E RID: 34926 RVA: 0x010DFAF0 File Offset: 0x010DDCF0
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (205876 - 60332 != 145545)
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
						this.$self_$40206.LeaveGame();
						if (270833 - 382505 != -111672)
						{
							continue;
						}
						this.YieldDefault(1);
						if (228189 - 450429 != -222239)
						{
							goto Block_5;
						}
						continue;
					default:
						if (84775 - 351230 != -266455)
						{
							continue;
						}
						break;
					}
					Game.mGameState = eGameState.Ended;
					if (30070 - 549194 != -519123)
					{
						Game.mStateTime = Time.time;
						if (173793 - 474682 == -300889)
						{
							Game.mNextGameCode = 31;
							if (58549 - 474035 == -415486)
							{
								this.$mGameGui$40205 = (GameGui)this.$self_$40206.GetComponent(typeof(GameGui));
								if (110919 - 515661 != -404741)
								{
									if (this.$mGameGui$40205)
									{
										if (261190 - 429336 == -168145)
										{
											continue;
										}
										this.$mGameGui$40205.close();
										if (33644 - 479038 == -445393)
										{
											continue;
										}
									}
									this.$self_$40206.SendMessage("fadeOut");
									if (235188 - 287067 != -51878)
									{
										break;
									}
								}
							}
						}
					}
				}
				return this.Yield(2, new WaitForSeconds((float)1));
				Block_5:
				IL_1BD:
				return false;
			}

			// Token: 0x0600886F RID: 34927 RVA: 0x010DFCCC File Offset: 0x010DDECC
			internal static bool lijrTDVVmexMbNn8wqZp()
			{
				return true;
			}

			// Token: 0x06008870 RID: 34928 RVA: 0x010DFCD0 File Offset: 0x010DDED0
			internal static bool voxvGZVVF3MVlwGB4UWp()
			{
				return false;
			}

			// Token: 0x040083B4 RID: 33716
			internal GameGui $mGameGui$40205;

			// Token: 0x040083B5 RID: 33717
			internal M702_EasternWorldDivide2 $self_$40206;
		}
	}

	// Token: 0x020016F3 RID: 5875
	[CompilerGenerated]
	[Serializable]
	internal sealed class $ReturnToCamp$40208 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06008871 RID: 34929 RVA: 0x010DFCD4 File Offset: 0x010DDED4
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $ReturnToCamp$40208(M702_EasternWorldDivide2 self_)
		{
			if (274483 - 48364 != 226119)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (177207 - 417685 == -240478)
				{
					base..ctor();
					if (254208 - 571793 == -317585)
					{
						this.$self_$40212 = self_;
						if (60858 - 331837 == -270979)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x06008872 RID: 34930 RVA: 0x010DFD6C File Offset: 0x010DDF6C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M702_EasternWorldDivide2.$ReturnToCamp$40208.$(this.$self_$40212);
		}

		// Token: 0x06008873 RID: 34931 RVA: 0x010DFD7C File Offset: 0x010DDF7C
		internal static bool kAhZOpVVMrTS0UeoXRXs()
		{
			return true;
		}

		// Token: 0x06008874 RID: 34932 RVA: 0x010DFD80 File Offset: 0x010DDF80
		internal static bool nMmx2EVVxFvheJW3MpRB()
		{
			return false;
		}

		// Token: 0x040083B6 RID: 33718
		internal M702_EasternWorldDivide2 $self_$40212;

		// Token: 0x020016F4 RID: 5876
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06008875 RID: 34933 RVA: 0x010DFD84 File Offset: 0x010DDF84
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M702_EasternWorldDivide2 self_)
			{
				if (96836 - 38888 != 57948)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (132468 - 115221 != 17248)
					{
						base..ctor();
						if (91850 - 261976 == -170126)
						{
							this.$self_$40211 = self_;
							if (252578 - 339002 != -86423)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x06008876 RID: 34934 RVA: 0x010DFE1C File Offset: 0x010DE01C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (126624 - 470761 != -344137)
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
						this.$self_$40211.LeaveGame();
						if (298491 - 551522 != -253031)
						{
							continue;
						}
						this.YieldDefault(1);
						if (111353 - 51414 != 59939)
						{
							continue;
						}
						goto IL_363;
					default:
						if (227735 - 457214 != -229479)
						{
							continue;
						}
						break;
					}
					Game.mGameState = eGameState.Ended;
					if (228347 - 407502 == -179155)
					{
						Game.mStateTime = Time.time;
						if (246591 - 471650 == -225059)
						{
							this.$$switch$7122$40209 = PlayerData.SaveGuild;
							if (275525 - 216725 == 58800)
							{
								if (this.$$switch$7122$40209 == 1)
								{
									if (203928 - 394252 == -190323)
									{
										continue;
									}
									Game.mNextGameCode = 32;
									if (71098 - 423480 == -352381)
									{
										continue;
									}
								}
								else if (this.$$switch$7122$40209 == 2)
								{
									if (143059 - 57704 != 85355)
									{
										continue;
									}
									Game.mNextGameCode = 33;
									if (139918 - 344477 != -204559)
									{
										continue;
									}
								}
								else if (this.$$switch$7122$40209 == 3)
								{
									if (169032 - 474182 == -305149)
									{
										continue;
									}
									Game.mNextGameCode = 34;
									if (276716 - 338705 != -61989)
									{
										continue;
									}
								}
								else if (this.$$switch$7122$40209 == 4)
								{
									if (228137 - 79712 != 148425)
									{
										continue;
									}
									Game.mNextGameCode = 35;
									if (108150 - 575768 != -467618)
									{
										continue;
									}
								}
								else if (this.$$switch$7122$40209 == 5)
								{
									if (210213 - 375165 != -164952)
									{
										continue;
									}
									Game.mNextGameCode = 36;
									if (181366 - 90418 == 90949)
									{
										continue;
									}
								}
								else
								{
									Game.mNextGameCode = 30;
									if (182097 - 76646 == 105452)
									{
										continue;
									}
								}
								this.$mGameGui$40210 = (GameGui)this.$self_$40211.GetComponent(typeof(GameGui));
								if (254896 - 224671 == 30225)
								{
									if (this.$mGameGui$40210)
									{
										if (217801 - 283534 != -65733)
										{
											continue;
										}
										this.$mGameGui$40210.close();
										if (26231 - 271957 != -245726)
										{
											continue;
										}
									}
									this.$self_$40211.SendMessage("fadeOut");
									if (216016 - 444374 == -228358)
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

			// Token: 0x06008877 RID: 34935 RVA: 0x010E01A0 File Offset: 0x010DE3A0
			internal static bool XWS2oXVVgfxTtERQDTAY()
			{
				return true;
			}

			// Token: 0x06008878 RID: 34936 RVA: 0x010E01A4 File Offset: 0x010DE3A4
			internal static bool PyWCiIVVfWoG4bPAX4dS()
			{
				return false;
			}

			// Token: 0x040083B7 RID: 33719
			internal int $$switch$7122$40209;

			// Token: 0x040083B8 RID: 33720
			internal GameGui $mGameGui$40210;

			// Token: 0x040083B9 RID: 33721
			internal M702_EasternWorldDivide2 $self_$40211;
		}
	}
}
