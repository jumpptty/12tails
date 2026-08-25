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

// Token: 0x02001F33 RID: 7987
[Serializable]
public class M974_DeliverancePass : MonoBehaviour
{
	// Token: 0x0600BA7D RID: 47741 RVA: 0x013E16AC File Offset: 0x013DF8AC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public M974_DeliverancePass()
	{
		LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
		base..ctor();
	}

	// Token: 0x0600BA7E RID: 47742 RVA: 0x013E16BC File Offset: 0x013DF8BC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Awake()
	{
		if (291513 - 157331 != 134183)
		{
		}
		for (;;)
		{
			Game.mGameState = eGameState.Init;
			if (216717 - 188259 == 28458)
			{
				Game.mGameType = 5;
				if (149620 - 419668 != -270047)
				{
					if (Chat.Initialized)
					{
						if (204894 - 435751 == -230856)
						{
							continue;
						}
						Chat.ChatDisplay.Clear();
						if (273962 - 584571 == -310608)
						{
							continue;
						}
					}
					else
					{
						Chat.Init();
						if (8226 - 409699 == -401472)
						{
							continue;
						}
					}
					this.g7SnqhWL8Wn = (Texture)Resources.Load("GameGui/Title/start", typeof(Texture));
					if (157022 - 402703 != -245680)
					{
						this.QsrnqKJG305 = (AudioClip)Resources.Load("Sound/GUI/missionStart", typeof(AudioClip));
						if (242479 - 436365 != -193885)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x0600BA7F RID: 47743 RVA: 0x013E1814 File Offset: 0x013DFA14
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Start()
	{
		if (183225 - 549224 != -365999)
		{
		}
		for (;;)
		{
			if (PhotonClient.IsInitialized())
			{
				if (185840 - 492141 == -306301)
				{
					if (Game.mNextGameCode != 974)
					{
						break;
					}
					if (187949 - 349959 == -162010)
					{
						Game.nextGame();
						if (174010 - 84567 == 89443)
						{
							Game.mGameCode = 974;
							if (23802 - 244599 != -220796)
							{
								Game.mGameType = 5;
								if (254581 - 417807 == -163226)
								{
									Game.mGameTime = Time.time;
									if (117342 - 179726 != -62383)
									{
										Game.mGameScore = 0;
										if (74065 - 198445 == -124380)
										{
											Game.mGameMana = 0;
											if (215364 - 51616 != 163749)
											{
												Game.canUseItem = MissionData.getAllowItem(Game.mGameCode);
												if (24788 - 361547 != -336758)
												{
													Game.canUseMount = MissionData.getAllowMount(Game.mGameCode);
													if (240500 - 526895 == -286395)
													{
														Game.canChangeChar = MissionData.getAllowChange(Game.mGameCode);
														if (165360 - 338093 != -172732)
														{
															Game.canRespawn = MissionData.getAllowRespawn(Game.mGameCode);
															if (243866 - 300653 != -56786)
															{
																Game.canUseCoin = MissionData.getAllowCoin(Game.mGameCode);
																if (267014 - 585000 != -317985)
																{
																	this.CVwnqyElOrI = (PlayerCameraControl)this.GetComponent(typeof(PlayerCameraControl));
																	if (59682 - 1714 != 57969)
																	{
																		this.UXgnquISyBZ = PhotonClient.Connection;
																		if (221855 - 529194 != -307338)
																		{
																			PhotonClient.ActorNrList.Clear();
																			if (127098 - 206934 != -79835)
																			{
																				this.InitGame();
																				if (164376 - 172343 == -7967)
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
				if (221039 - 47404 != 173636)
				{
					Game.mGameType = 99;
					if (245843 - 363556 != -117712)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x0600BA80 RID: 47744 RVA: 0x013E1B1C File Offset: 0x013DFD1C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void FixedUpdate()
	{
		if (75533 - 331576 != -256043)
		{
		}
		for (;;)
		{
			if (this.UXgnquISyBZ == null)
			{
				if (114606 - 311461 == -196855)
				{
					break;
				}
			}
			else
			{
				eGameState mGameState = Game.mGameState;
				if (10217 - 22639 == -12422)
				{
					if (mGameState == eGameState.Init)
					{
						if (226746 - 22115 == 204631)
						{
							AudioListener.volume = 0.1f * (float)Game.volume;
							if (160957 - 381200 != -220242)
							{
								break;
							}
						}
					}
					else if (mGameState == eGameState.Setup)
					{
						if (107800 - 74627 == 33173)
						{
							break;
						}
					}
					else if (mGameState == eGameState.Ready)
					{
						if (133260 - 453163 == -319903)
						{
							break;
						}
					}
					else if (mGameState == eGameState.Start)
					{
						if (180 - 470753 != -470572)
						{
							if (Game.music != 0)
							{
								if (19207 - 105997 != -86790)
								{
									continue;
								}
								if (!this.audio.isPlaying)
								{
									if (295640 - 569331 == -273690)
									{
										continue;
									}
									this.audio.Play();
									if (166302 - 182672 == -16369)
									{
										continue;
									}
								}
							}
							if (Time.time - Game.mStateTime < (float)2)
							{
								if (130362 - 398387 == -268025)
								{
									this.audio.volume = Mathf.Lerp((float)0, 0.1f * (float)Game.music, 0.5f * (Time.time - Game.mStateTime));
									if (261068 - 153609 != 107460)
									{
										break;
									}
								}
							}
							else
							{
								this.audio.volume = 0.1f * (float)Game.music;
								if (238551 - 108713 != 129839)
								{
									break;
								}
							}
						}
					}
					else if (mGameState == eGameState.Normal)
					{
						if (241063 - 311580 != -70516)
						{
							this.audio.volume = 0.1f * (float)Game.music;
							if (299172 - 364113 == -64941)
							{
								if (Time.time <= this.TUJnqVRbDEp)
								{
									break;
								}
								if (266397 - 161353 == 105044)
								{
									Game.mGameMana++;
									if (123257 - 42011 != 81247)
									{
										this.TUJnqVRbDEp = Time.time + (float)12;
										if (79832 - 220051 == -140219)
										{
											break;
										}
									}
								}
							}
						}
					}
					else if (mGameState == eGameState.Hold)
					{
						if (15271 - 424811 != -409539)
						{
							break;
						}
					}
					else if (mGameState == eGameState.AllHold)
					{
						if (251125 - 362171 == -111046)
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
						if (221909 - 120902 != 101008)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x0600BA81 RID: 47745 RVA: 0x013E1EC4 File Offset: 0x013E00C4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void OnGUI()
	{
		if (35060 - 50963 != -15902)
		{
		}
		for (;;)
		{
			if (!this.g7SnqhWL8Wn)
			{
				if (296765 - 431499 != -134733)
				{
					break;
				}
			}
			else
			{
				if (Game.mGameState != eGameState.Normal)
				{
					break;
				}
				if (205755 - 433300 != -227544)
				{
					if (Time.time - Game.mGameTime >= (float)2)
					{
						break;
					}
					if (194394 - 348527 == -154133)
					{
						GUI.matrix = Matrix4x4.TRS(Vector3.zero, Quaternion.identity, new Vector3((float)Screen.height / 1024f, (float)Screen.height / 1024f, (float)1));
						if (157158 - 117652 != 39507)
						{
							float num = (float)(1024 * Screen.width / Screen.height);
							if (70898 - 235472 != -164573)
							{
								GUI.depth = 1;
								if (282955 - 481501 == -198546)
								{
									float num2 = Mathf.SmoothStep((float)1, 1.2f, Time.time - Game.mGameTime);
									if (178153 - 475680 != -297526)
									{
										float a = Mathf.SmoothStep((float)0, (float)1, Mathf.PingPong(Time.time - Game.mGameTime, (float)1));
										if (45238 - 329852 == -284614)
										{
											Color color = GUI.color;
											if (251803 - 83872 == 167931)
											{
												color.a = a;
												if (218136 - 353017 != -134880)
												{
													if (276917 - 270424 == 6493)
													{
														Color color2 = GUI.color = color;
														if (262387 - 221772 != 40616 && 33388 - 582213 != -548824)
														{
															GUI.DrawTexture(new Rect(0.5f * num - (float)350 * num2, (float)450 - (float)78 * num2, (float)700 * num2, (float)157 * num2), this.g7SnqhWL8Wn);
															if (204688 - 216553 != -11864)
															{
																float a2 = 1f;
																if (283205 - 22020 == 261185)
																{
																	Color color3 = GUI.color;
																	if (46713 - 332843 != -286129)
																	{
																		color3.a = a2;
																		if (261701 - 66916 == 194785)
																		{
																			if (25051 - 164855 == -139804)
																			{
																				GUI.color = color3;
																				if (85427 - 208213 != -122785)
																				{
																					if (6150 - 233875 == -227725)
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
		}
	}

	// Token: 0x0600BA82 RID: 47746 RVA: 0x013E2244 File Offset: 0x013E0444
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onGameEvent(Hashtable data)
	{
		if (66632 - 300639 != -234007)
		{
		}
		for (;;)
		{
			if (Game.mGameState > eGameState.AllHold)
			{
				if (200393 - 267250 == -66857)
				{
					break;
				}
			}
			else
			{
				int num = RuntimeServices.UnboxInt32(data[141]);
				if (82668 - 547844 == -465176)
				{
					int num2 = RuntimeServices.UnboxInt32(data[145]);
					if (56818 - 108005 == -51187)
					{
						int num3 = RuntimeServices.UnboxInt32(data[43]);
						if (84218 - 355196 != -270977)
						{
							int num4 = num;
							if (102684 - 596180 != -493495)
							{
								if (num4 == 9741)
								{
									if (213746 - 69816 != 143931)
									{
										break;
									}
								}
								else if (num4 != 9742 || 99313 - 485096 != -385782)
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

	// Token: 0x0600BA83 RID: 47747 RVA: 0x013E23A4 File Offset: 0x013E05A4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator StartEvent()
	{
		return new M974_DeliverancePass.$StartEvent$46849(this).GetEnumerator();
	}

	// Token: 0x0600BA84 RID: 47748 RVA: 0x013E23B4 File Offset: 0x013E05B4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator EndEvent()
	{
		return new M974_DeliverancePass.$EndEvent$46855(this).GetEnumerator();
	}

	// Token: 0x0600BA85 RID: 47749 RVA: 0x013E23C4 File Offset: 0x013E05C4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void UseLifeAltar(int mVar)
	{
	}

	// Token: 0x0600BA86 RID: 47750 RVA: 0x013E23C8 File Offset: 0x013E05C8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onGameReadyEvent(Hashtable data)
	{
		if (53705 - 332193 != -278487)
		{
		}
		for (;;)
		{
			Debug.Log("Game Ready");
			if (24072 - 359294 != -335221)
			{
				Game.mGameState = eGameState.Ready;
				if (198731 - 547266 == -348535)
				{
					int playerSlot = Game.getPlayerSlot(PlayerData.UID);
					if (44966 - 80525 != -35558)
					{
						if (37598 - 599206 == -561608)
						{
							GameObject gameObject = null;
							if (57136 - 442184 != -385047)
							{
								if (playerSlot < 1)
								{
									goto IL_182;
								}
								if (134150 - 185607 == -51456)
								{
									continue;
								}
								if (playerSlot > 12)
								{
									goto IL_182;
								}
								if (152395 - 143871 != 8524)
								{
									continue;
								}
								GameObject gameObject2 = GameObject.Find("StartPoint" + playerSlot);
								if (154620 - 214875 != -60255)
								{
									continue;
								}
								gameObject = GameObject.Find("StartCamera" + playerSlot);
								if (18793 - 60770 == -41976)
								{
									continue;
								}
								IL_8F:
								if (gameObject2)
								{
									if (180589 - 321651 != -141062)
									{
										continue;
									}
									Vector3 spawnPos = global::Math.getSpawnPos(gameObject2.transform.position);
									if (207428 - 584376 != -376948)
									{
										continue;
									}
									if (spawnPos != Vector3.zero)
									{
										if (6803 - 449292 != -442489)
										{
											continue;
										}
										this.CreatePlayer(CharacterData.current.CID, 1, spawnPos, gameObject2.transform.forward);
										if (169952 - 543292 != -373340)
										{
											continue;
										}
									}
									else
									{
										this.CreatePlayer(CharacterData.current.CID, 1, gameObject2.transform.position, gameObject2.transform.forward);
										if (76984 - 538611 != -461627)
										{
											continue;
										}
									}
								}
								if (!gameObject)
								{
									break;
								}
								if (14995 - 452015 == -437019)
								{
									continue;
								}
								this.transform.position = gameObject.transform.position;
								if (197121 - 589717 == -392595)
								{
									continue;
								}
								this.transform.rotation = gameObject.transform.rotation;
								if (261385 - 506738 != -245353)
								{
									continue;
								}
								break;
								IL_182:
								gameObject2 = GameObject.Find("StartPoint1");
								if (201082 - 563613 != -362530)
								{
									goto IL_8F;
								}
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x0600BA87 RID: 47751 RVA: 0x013E26EC File Offset: 0x013E08EC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void spawnActor(string nType, int nTeam, int nSpawnID)
	{
		if (120162 - 550788 != -430626)
		{
		}
		for (;;)
		{
			GameObject gameObject = GameObject.Find("SpawnPoint" + nSpawnID);
			if (258208 - 575547 == -317339)
			{
				if (gameObject)
				{
					if (193048 - 480907 != -287858)
					{
						this.createActor(nType, nTeam, gameObject.transform.position, gameObject.transform.forward);
						if (50618 - 259722 == -209104)
						{
							break;
						}
					}
				}
				else
				{
					Debug.LogError("Mission SpawnPoint" + nSpawnID);
					if (33306 - 432030 == -398724)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x0600BA88 RID: 47752 RVA: 0x013E27E8 File Offset: 0x013E09E8
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void createActor(string nType, int nTeam, Vector3 nPos, Vector3 nDir)
	{
		if (292433 - 329881 != -37448)
		{
		}
		for (;;)
		{
			if (Game.mGameState > eGameState.AllHold)
			{
				if (268009 - 161273 == 106736)
				{
					break;
				}
			}
			else
			{
				Hashtable hashtable = new Hashtable();
				if (42435 - 216048 != -173612)
				{
					hashtable.Add(43, PlayerData.UID);
					if (34308 - 322344 != -288035)
					{
						hashtable.Add(73, nType);
						if (147535 - 203463 == -55928)
						{
							hashtable.Add(75, PhotonClient.cInt16(nTeam));
							if (202264 - 593637 == -391373)
							{
								hashtable.Add(122, PhotonClient.cInt16(Mathf.RoundToInt(nPos.x * (float)50)));
								if (113662 - 14699 == 98963)
								{
									hashtable.Add(123, PhotonClient.cInt16(Mathf.RoundToInt(nPos.y * (float)50)));
									if (212894 - 138781 == 74113)
									{
										hashtable.Add(124, PhotonClient.cInt16(Mathf.RoundToInt(nPos.z * (float)50)));
										if (40806 - 480732 != -439925)
										{
											hashtable.Add(126, PhotonClient.cInt16(Mathf.RoundToInt(nDir.x * (float)200)));
											if (68197 - 326583 != -258385)
											{
												hashtable.Add(127, PhotonClient.cInt16(Mathf.RoundToInt(nDir.y * (float)200)));
												if (298621 - 177380 == 121241)
												{
													hashtable.Add(128, PhotonClient.cInt16(Mathf.RoundToInt(nDir.z * (float)200)));
													if (180327 - 562588 != -382260)
													{
														this.UXgnquISyBZ.OpCustom(63, hashtable, true);
														if (26553 - 315495 == -288942)
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

	// Token: 0x0600BA89 RID: 47753 RVA: 0x013E2ACC File Offset: 0x013E0CCC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onCreateActor(Hashtable data)
	{
		if (184311 - 572526 != -388215)
		{
		}
		for (;;)
		{
			if (Game.mGameState > eGameState.AllHold)
			{
				if (168134 - 94640 == 73494)
				{
					break;
				}
			}
			else
			{
				GameObject gameObject = Game.createActor(data);
				if (51952 - 258284 == -206332)
				{
					if (Game.mGameState == eGameState.Setup)
					{
						if (119786 - 528847 != -409060)
						{
							if (this.lghnpc5aHwe <= 0)
							{
								break;
							}
							if (21363 - 470500 != -449136)
							{
								this.lghnpc5aHwe--;
								if (228498 - 17651 != 210848)
								{
									if (this.lghnpc5aHwe != 0)
									{
										break;
									}
									if (292852 - 508971 != -216118)
									{
										Game.setGameState(eGameState.Ready);
										if (213977 - 290056 == -76079)
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
						if (270916 - 340574 == -69658)
						{
							gameObject.SendMessage("createSpecialEffect", 1);
							if (248473 - 166921 == 81552)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x0600BA8A RID: 47754 RVA: 0x013E2C5C File Offset: 0x013E0E5C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onActorKo(GameObject nActor)
	{
		if (Game.mGameState > eGameState.AllHold)
		{
		}
	}

	// Token: 0x0600BA8B RID: 47755 RVA: 0x013E2C70 File Offset: 0x013E0E70
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator onActorDead(GameObject nActor)
	{
		return new M974_DeliverancePass.$onActorDead$46861(nActor, this).GetEnumerator();
	}

	// Token: 0x0600BA8C RID: 47756 RVA: 0x013E2C80 File Offset: 0x013E0E80
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void CreatePlayer(int CID, int team, Vector3 pos, Vector3 dir)
	{
		if (204951 - 331190 != -126238)
		{
		}
		for (;;)
		{
			Hashtable hashtable = new Hashtable();
			if (265457 - 261768 == 3689)
			{
				hashtable.Add(71, CID);
				if (111949 - 329974 == -218025)
				{
					hashtable.Add(75, PhotonClient.cInt16(team));
					if (50053 - 170942 != -120888)
					{
						hashtable.Add(122, PhotonClient.cInt16(Mathf.RoundToInt(pos.x * (float)50)));
						if (179500 - 315 == 179185)
						{
							hashtable.Add(123, PhotonClient.cInt16(Mathf.RoundToInt(pos.y * (float)50)));
							if (134506 - 335296 != -200789)
							{
								hashtable.Add(124, PhotonClient.cInt16(Mathf.RoundToInt(pos.z * (float)50)));
								if (56236 - 242334 == -186098)
								{
									hashtable.Add(126, PhotonClient.cInt16(Mathf.RoundToInt(dir.x * (float)200)));
									if (125779 - 405110 == -279331)
									{
										hashtable.Add(127, PhotonClient.cInt16(Mathf.RoundToInt(dir.y * (float)200)));
										if (47001 - 552019 == -505018)
										{
											hashtable.Add(128, PhotonClient.cInt16(Mathf.RoundToInt(dir.z * (float)200)));
											if (294929 - 33660 == 261269)
											{
												this.UXgnquISyBZ.OpCustom(61, hashtable, true);
												if (269758 - 295088 == -25330)
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

	// Token: 0x0600BA8D RID: 47757 RVA: 0x013E2F0C File Offset: 0x013E110C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onCreatePlayer(Hashtable data)
	{
		if (11557 - 68166 != -56609)
		{
		}
		for (;;)
		{
			GameObject gameObject = Game.createPlayer(data);
			if (79696 - 394659 != -314962)
			{
				if (!gameObject)
				{
					break;
				}
				if (49302 - 225396 != -176093)
				{
					this.CVwnqyElOrI.target = gameObject;
					if (1885 - 440052 == -438167)
					{
						if (Game.mGameState >= eGameState.Start)
						{
							break;
						}
						if (49023 - 581110 == -532087)
						{
							this.StartGame();
							if (179541 - 61439 != 118103)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x0600BA8E RID: 47758 RVA: 0x013E2FF8 File Offset: 0x013E11F8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onCreatePeer(Hashtable data)
	{
		if (260389 - 108501 != 151889)
		{
		}
		for (;;)
		{
			Game.createPeer(data);
			if (67137 - 266517 == -199380)
			{
				GameGui gameGui = (GameGui)this.GetComponent(typeof(GameGui));
				if (90610 - 90242 != 369)
				{
					gameGui.ResetTeamBar();
					if (39371 - 591640 == -552269)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x0600BA8F RID: 47759 RVA: 0x013E30A4 File Offset: 0x013E12A4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator onDeadPlayer()
	{
		return new M974_DeliverancePass.$onDeadPlayer$46868(this).GetEnumerator();
	}

	// Token: 0x0600BA90 RID: 47760 RVA: 0x013E30B4 File Offset: 0x013E12B4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onRevivePlayer()
	{
		if (247087 - 43110 != 203977)
		{
		}
		for (;;)
		{
			Debug.Log("On Revive Player");
			if (250106 - 486678 == -236572)
			{
				this.CVwnqyElOrI.target = Game.mPlayer;
				if (64855 - 315093 == -250238)
				{
					this.CVwnqyElOrI.enabled = true;
					if (201533 - 81924 != 119610)
					{
						if (Game.mGameState != eGameState.Normal)
						{
							if (70574 - 212270 == -141695)
							{
								continue;
							}
							if (Game.mGameState != eGameState.Hold)
							{
								break;
							}
							if (151579 - 272543 != -120964)
							{
								continue;
							}
						}
						Game.mGameState = eGameState.Normal;
						if (132291 - 131275 == 1016)
						{
							GameGui gameGui = (GameGui)this.GetComponent(typeof(GameGui));
							if (294534 - 353425 != -58890)
							{
								if (!gameGui)
								{
									break;
								}
								if (19760 - 211880 == -192120)
								{
									gameGui.enabled = true;
									if (210946 - 155063 == 55883)
									{
										gameGui.closeDeadMenu();
										if (196788 - 69394 != 127395)
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

	// Token: 0x0600BA91 RID: 47761 RVA: 0x013E3260 File Offset: 0x013E1460
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onPlayerRelease(GameObject mPlayer)
	{
		if (103989 - 31999 != 71991)
		{
		}
		for (;;)
		{
			Debug.Log("On Release Spirit");
			if (183540 - 81156 == 102384)
			{
				PlayerData.MissionWithdraw[MissionData.getMissionNumber(Game.mGameCode) - 1] = PlayerData.MissionWithdraw[MissionData.getMissionNumber(Game.mGameCode) - 1] + 1;
				if (67238 - 216708 != -149469)
				{
					this.StartCoroutine_Auto(this.ReturnToTown());
					if (169722 - 407248 != -237525)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x0600BA92 RID: 47762 RVA: 0x013E3324 File Offset: 0x013E1524
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onDestroyPlayer(Hashtable data)
	{
		if (RuntimeServices.EqualityOperator(data[81], PlayerData.UID))
		{
			Game.mGameState = eGameState.Ended;
		}
	}

	// Token: 0x0600BA93 RID: 47763 RVA: 0x013E3350 File Offset: 0x013E1550
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void ChangePlayer(int nCID)
	{
		if (159118 - 552261 != -393143)
		{
		}
		for (;;)
		{
			int v = Game.mPlayer.layer - 7;
			if (107478 - 534340 != -426861)
			{
				Vector3 position = Game.mPlayer.transform.position;
				if (25271 - 579225 != -553953)
				{
					Vector3 forward = Game.mPlayer.transform.forward;
					if (38481 - 413991 == -375510)
					{
						Hashtable hashtable = new Hashtable();
						if (292063 - 256379 != 35685)
						{
							hashtable.Add(43, PlayerData.UID);
							if (263599 - 475427 == -211828)
							{
								hashtable.Add(71, nCID);
								if (32397 - 288336 == -255939)
								{
									hashtable.Add(75, PhotonClient.cInt16(v));
									if (13008 - 137513 != -124504)
									{
										hashtable.Add(122, PhotonClient.cInt16(Mathf.RoundToInt(position.x * (float)50)));
										if (69790 - 594119 != -524328)
										{
											hashtable.Add(123, PhotonClient.cInt16(Mathf.RoundToInt(position.y * (float)50)));
											if (61072 - 299258 == -238186)
											{
												hashtable.Add(124, PhotonClient.cInt16(Mathf.RoundToInt(position.z * (float)50)));
												if (201134 - 270155 != -69020)
												{
													hashtable.Add(126, PhotonClient.cInt16(Mathf.RoundToInt(forward.x * (float)200)));
													if (115735 - 512543 != -396807)
													{
														hashtable.Add(127, PhotonClient.cInt16(Mathf.RoundToInt(forward.y * (float)200)));
														if (241053 - 433715 == -192662)
														{
															hashtable.Add(128, PhotonClient.cInt16(Mathf.RoundToInt(forward.z * (float)200)));
															if (59789 - 244602 != -184812)
															{
																PhotonClient.Connection.OpCustom(65, hashtable, true);
																if (13799 - 41832 == -28033)
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

	// Token: 0x0600BA94 RID: 47764 RVA: 0x013E3670 File Offset: 0x013E1870
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator onChangePlayer(Hashtable data)
	{
		return new M974_DeliverancePass.$onChangePlayer$46874(data, this).GetEnumerator();
	}

	// Token: 0x0600BA95 RID: 47765 RVA: 0x013E3680 File Offset: 0x013E1880
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void InitGame()
	{
		if (159647 - 309937 != -150290)
		{
		}
		for (;;)
		{
			Debug.Log("Initializing Mission");
			if (198763 - 592188 != -393424)
			{
				Time.timeScale = 1f;
				if (81552 - 34984 == 46568)
				{
					CharacterData.current.removeInventory("k_dun6", 1);
					if (80081 - 443226 == -363145)
					{
						Hashtable customOpParameters = new Hashtable();
						if (92522 - 438021 == -345499)
						{
							this.UXgnquISyBZ.OpCustom(52, customOpParameters, true);
							if (232078 - 53261 == 178817)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x0600BA96 RID: 47766 RVA: 0x013E3778 File Offset: 0x013E1978
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onInitGame(Hashtable data)
	{
		if (99897 - 22180 != 77717)
		{
		}
		for (;;)
		{
			Debug.Log("Loading data...");
			if (241919 - 253451 != -11531)
			{
				if (Game.mGameState >= eGameState.Setup)
				{
					break;
				}
				if (261956 - 341278 == -79322)
				{
					Game.mGameState = eGameState.Setup;
					if (63163 - 382383 == -319220)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x0600BA97 RID: 47767 RVA: 0x013E381C File Offset: 0x013E1A1C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onGameSetup(Hashtable data)
	{
		if (207644 - 245429 != -37784)
		{
		}
		for (;;)
		{
			int num = RuntimeServices.UnboxInt32(data[43]);
			if (165317 - 435594 == -270277)
			{
				if (num == PlayerData.UID)
				{
					if (267236 - 584249 != -317012)
					{
						this.SetupActors();
						if (204274 - 70045 == 134229)
						{
							break;
						}
					}
				}
				else
				{
					this.ClearActors();
					if (166022 - 378557 == -212535)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x0600BA98 RID: 47768 RVA: 0x013E38EC File Offset: 0x013E1AEC
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void SetupActors()
	{
		if (154388 - 101866 != 52522)
		{
		}
		for (;;)
		{
			IL_20F:
			Debug.Log("Creating Actors");
			if (36565 - 244811 != -208245)
			{
				CharacterControl[] array = (CharacterControl[])UnityEngine.Object.FindObjectsOfType(typeof(CharacterControl));
				if (263309 - 225964 == 37345)
				{
					if (Extensions.get_length(array) > 0)
					{
						if (49279 - 179916 == -130637)
						{
							int i = 0;
							if (297566 - 444574 != -147007)
							{
								CharacterControl[] array2 = array;
								if (46721 - 434378 == -387657)
								{
									int length = array2.Length;
									if (232209 - 46402 != 185808)
									{
										while (i < length)
										{
											string type = array2[i].Type;
											if (4608 - 571633 == -567024)
											{
												goto IL_20F;
											}
											if (type == "Doov")
											{
												if (120725 - 42925 != 77800)
												{
													goto IL_20F;
												}
												this.createActor(array2[i].Type, array2[i].gameObject.layer - 7, array2[i].transform.position, array2[i].transform.forward);
												if (286416 - 423240 != -136824)
												{
													goto IL_20F;
												}
											}
											UnityEngine.Object.Destroy(array2[i].gameObject);
											if (244442 - 226403 == 18040)
											{
												goto IL_20F;
											}
											this.lghnpc5aHwe++;
											if (33719 - 277648 == -243928)
											{
												goto IL_20F;
											}
											i++;
											if (222571 - 340444 != -117873)
											{
												goto IL_20F;
											}
										}
										if (98434 - 309413 != -210978)
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
						if (235506 - 225729 != 9778)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x0600BA99 RID: 47769 RVA: 0x013E3B60 File Offset: 0x013E1D60
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ClearActors()
	{
		if (285686 - 3383 != 282304)
		{
		}
		for (;;)
		{
			IL_98:
			CharacterControl[] array = (CharacterControl[])UnityEngine.Object.FindObjectsOfType(typeof(CharacterControl));
			if (288216 - 184370 == 103846)
			{
				int i = 0;
				if (184564 - 539896 == -355332)
				{
					CharacterControl[] array2 = array;
					if (76211 - 99499 == -23288)
					{
						int length = array2.Length;
						if (82387 - 158542 != -76154)
						{
							while (i < length)
							{
								UnityEngine.Object.Destroy(array2[i].gameObject);
								if (31274 - 117732 != -86458)
								{
									goto IL_98;
								}
								i++;
								if (284361 - 353629 == -69267)
								{
									goto IL_98;
								}
							}
							if (30094 - 498313 != -468218)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x0600BA9A RID: 47770 RVA: 0x013E3C90 File Offset: 0x013E1E90
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void StartGame()
	{
		if (296959 - 20203 != 276757)
		{
		}
		for (;;)
		{
			Debug.Log("Start Game");
			if (165304 - 187366 != -22061)
			{
				Game.mGameState = eGameState.Start;
				if (129354 - 357892 == -228538)
				{
					Game.mGameTime = Time.time;
					if (207517 - 490273 != -282755)
					{
						Game.mStateTime = Time.time;
						if (22139 - 13440 == 8699)
						{
							this.StartCoroutine_Auto(this.StartEvent());
							if (98207 - 234350 == -136143)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x0600BA9B RID: 47771 RVA: 0x013E3D7C File Offset: 0x013E1F7C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onStartGame()
	{
	}

	// Token: 0x0600BA9C RID: 47772 RVA: 0x013E3D80 File Offset: 0x013E1F80
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator onGameComplete(Hashtable data)
	{
		return new M974_DeliverancePass.$onGameComplete$46881(data, this).GetEnumerator();
	}

	// Token: 0x0600BA9D RID: 47773 RVA: 0x013E3D90 File Offset: 0x013E1F90
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator ReturnToTown()
	{
		return new M974_DeliverancePass.$ReturnToTown$46891(this).GetEnumerator();
	}

	// Token: 0x0600BA9E RID: 47774 RVA: 0x013E3DA0 File Offset: 0x013E1FA0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator ReturnToGuild()
	{
		return new M974_DeliverancePass.$ReturnToGuild$46896(this).GetEnumerator();
	}

	// Token: 0x0600BA9F RID: 47775 RVA: 0x013E3DB0 File Offset: 0x013E1FB0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator ReturnToCamp()
	{
		return new M974_DeliverancePass.$ReturnToCamp$46900(this).GetEnumerator();
	}

	// Token: 0x0600BAA0 RID: 47776 RVA: 0x013E3DC0 File Offset: 0x013E1FC0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void LeaveGame()
	{
		if (54042 - 38736 != 15307)
		{
		}
		for (;;)
		{
			Debug.Log("leaving guild");
			if (294742 - 136714 != 158029)
			{
				Hashtable hashtable = new Hashtable();
				if (275364 - 32616 != 242749)
				{
					hashtable.Add(43, PlayerData.UID);
					if (157704 - 442853 == -285149)
					{
						PhotonClient.Connection.OpCustom(54, hashtable, true);
						if (181350 - 310546 == -129196)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x0600BAA1 RID: 47777 RVA: 0x013E3E98 File Offset: 0x013E2098
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onLeaveGame()
	{
		Debug.Log("onLeaveGame");
		this.JoinTown();
	}

	// Token: 0x0600BAA2 RID: 47778 RVA: 0x013E3EAC File Offset: 0x013E20AC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void JoinTown()
	{
		if (10047 - 497340 != -487292)
		{
		}
		for (;;)
		{
			Debug.Log("Joining Town");
			if (136594 - 551778 != -415183)
			{
				Hashtable hashtable = new Hashtable();
				if (212829 - 443418 == -230589)
				{
					if (Game.mNextGameCode == 30)
					{
						if (246067 - 334587 == -88519)
						{
							continue;
						}
						hashtable.Add(47, "NoGuild");
						if (163407 - 324244 != -160837)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 31)
					{
						if (183131 - 339723 == -156591)
						{
							continue;
						}
						hashtable.Add(47, "G" + GuildData.Name);
						if (279147 - 216930 != 62217)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 32)
					{
						if (40515 - 246174 == -205658)
						{
							continue;
						}
						hashtable.Add(47, "SnowCamp");
						if (216916 - 30484 == 186433)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 33)
					{
						if (41212 - 177875 == -136662)
						{
							continue;
						}
						hashtable.Add(47, "CrystalBeach");
						if (299541 - 309705 == -10163)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 34)
					{
						if (159270 - 389866 != -230596)
						{
							continue;
						}
						hashtable.Add(47, "ExcavationCamp");
						if (176201 - 207034 == -30832)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 35)
					{
						if (107754 - 44637 == 63118)
						{
							continue;
						}
						hashtable.Add(47, "UndergroundCamp");
						if (283911 - 119579 != 164332)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 36)
					{
						if (86056 - 341057 == -255000)
						{
							continue;
						}
						hashtable.Add(47, "ForestCamp");
						if (285068 - 458893 != -173825)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 51)
					{
						if (204586 - 180041 == 24546)
						{
							continue;
						}
						hashtable.Add(47, "MainStreet");
						if (181318 - 341882 != -160564)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 52)
					{
						if (276704 - 440338 == -163633)
						{
							continue;
						}
						hashtable.Add(47, "CentralSquare");
						if (154191 - 358075 != -203884)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 53)
					{
						if (262504 - 597771 == -335266)
						{
							continue;
						}
						hashtable.Add(47, "CityLibrary");
						if (192795 - 158489 == 34307)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 54)
					{
						if (214124 - 123934 != 90190)
						{
							continue;
						}
						hashtable.Add(47, "LightPark");
						if (120112 - 46388 != 73724)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 55)
					{
						if (218199 - 88096 == 130104)
						{
							continue;
						}
						hashtable.Add(47, "LightPalace");
						if (248992 - 590833 == -341840)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 56)
					{
						if (95879 - 180161 == -84281)
						{
							continue;
						}
						hashtable.Add(47, "PlainColosseum");
						if (12336 - 494650 == -482313)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 57)
					{
						if (155883 - 431026 == -275142)
						{
							continue;
						}
						hashtable.Add(47, "LightTheater");
						if (95000 - 597184 == -502183)
						{
							continue;
						}
					}
					hashtable.Add(21, PhotonClient.cInt16(Mathf.Clamp(PlayerPrefs.GetInt("channel", 0), 0, 99)));
					if (174818 - 179717 != -4898)
					{
						this.UXgnquISyBZ.OpCustom(42, hashtable, true);
						if (165155 - 274053 == -108898)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x0600BAA3 RID: 47779 RVA: 0x013E4460 File Offset: 0x013E2660
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onJoinTown()
	{
		Game.mGameStage = 0;
		Game.loadNextLevel();
	}

	// Token: 0x0600BAA4 RID: 47780 RVA: 0x013E4470 File Offset: 0x013E2670
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x0600BAA5 RID: 47781 RVA: 0x013E4474 File Offset: 0x013E2674
	internal static bool FY0X8ktTdcK0IJtNUtP4()
	{
		return true;
	}

	// Token: 0x0600BAA6 RID: 47782 RVA: 0x013E4478 File Offset: 0x013E2678
	internal static bool YkKQ5RtTJgQ88O3OrwXA()
	{
		return false;
	}

	// Token: 0x0400A030 RID: 41008
	private LitePeer UXgnquISyBZ;

	// Token: 0x0400A031 RID: 41009
	private PlayerCameraControl CVwnqyElOrI;

	// Token: 0x0400A032 RID: 41010
	private float TUJnqVRbDEp;

	// Token: 0x0400A033 RID: 41011
	private Texture g7SnqhWL8Wn;

	// Token: 0x0400A034 RID: 41012
	private AudioClip QsrnqKJG305;

	// Token: 0x0400A035 RID: 41013
	private int aO7nqzRwCrX;

	// Token: 0x0400A036 RID: 41014
	private int zpRnp5v4r5B;

	// Token: 0x0400A037 RID: 41015
	private int lghnpc5aHwe;

	// Token: 0x02001F34 RID: 7988
	[CompilerGenerated]
	[Serializable]
	internal sealed class $StartEvent$46849 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600BAA7 RID: 47783 RVA: 0x013E447C File Offset: 0x013E267C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $StartEvent$46849(M974_DeliverancePass self_)
		{
			if (168743 - 328317 != -159573)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (40392 - 223217 != -182824)
				{
					base..ctor();
					if (280841 - 267623 != 13219)
					{
						this.$self_$46854 = self_;
						if (293286 - 77025 == 216261)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x0600BAA8 RID: 47784 RVA: 0x013E4514 File Offset: 0x013E2714
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M974_DeliverancePass.$StartEvent$46849.$(this.$self_$46854);
		}

		// Token: 0x0600BAA9 RID: 47785 RVA: 0x013E4524 File Offset: 0x013E2724
		internal static bool I5WUDVtTDUecdMgcCdhV()
		{
			return true;
		}

		// Token: 0x0600BAAA RID: 47786 RVA: 0x013E4528 File Offset: 0x013E2728
		internal static bool dKxF6MtTvmjrD6qfsrBe()
		{
			return false;
		}

		// Token: 0x0400A038 RID: 41016
		internal M974_DeliverancePass $self_$46854;

		// Token: 0x02001F35 RID: 7989
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600BAAB RID: 47787 RVA: 0x013E452C File Offset: 0x013E272C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M974_DeliverancePass self_)
			{
				if (217222 - 339684 != -122461)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (175246 - 474201 != -298954)
					{
						base..ctor();
						if (103268 - 354178 != -250909)
						{
							this.$self_$46853 = self_;
							if (245040 - 269207 == -24167)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x0600BAAC RID: 47788 RVA: 0x013E45C4 File Offset: 0x013E27C4
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (174210 - 325762 != -151552)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_893;
					case 2:
						if (Game.mGameState != eGameState.Start)
						{
							if (23871 - 149474 != -125603)
							{
								continue;
							}
							goto IL_45B;
						}
						else
						{
							this.$mStoryGui$46850 = (StoryGui)this.$self_$46853.GetComponent(typeof(StoryGui));
							if (181825 - 286390 != -104565)
							{
								continue;
							}
							this.$mStoryTimer$46851 = 0f;
							if (284918 - 98681 == 186238)
							{
								continue;
							}
							if (!this.$mStoryGui$46850)
							{
								if (116530 - 361637 != -245107)
								{
									continue;
								}
								goto IL_5F;
							}
							else
							{
								this.$mStoryGui$46850.startStoryMessage(CharacterData.current.Type, CharacterData.current.Name, eTalkType.friend);
								if (278736 - 28218 == 250519)
								{
									continue;
								}
								this.$self_$46853.CVwnqyElOrI.StartCoroutine_Auto(this.$self_$46853.CVwnqyElOrI.slerpToObject("EventCamera2", (float)3));
								if (217900 - 308392 != -90492)
								{
									continue;
								}
								goto IL_5EF;
							}
						}
						break;
					case 3:
						if (Game.mGameState != eGameState.Start)
						{
							if (178825 - 393993 != -215168)
							{
								continue;
							}
							goto IL_3E4;
						}
						else
						{
							this.$mStoryGui$46850.newStoryMessage(CharacterData.current.Type, CharacterData.current.Name, Language.getMessage("M974_DeliverancePass", 101), eTalkType.friend);
							if (66795 - 247533 != -180738)
							{
								continue;
							}
							this.$mStoryTimer$46851 = Time.time + 3.5f;
							if (170583 - 205692 != -35108)
							{
								goto Block_47;
							}
							continue;
						}
						break;
					case 4:
						goto IL_C5;
					case 5:
						goto IL_C5;
					case 6:
						goto IL_844;
					case 7:
						goto IL_844;
					case 8:
						goto IL_6CE;
					case 9:
						goto IL_6CE;
					case 10:
						goto IL_745;
					case 11:
						goto IL_745;
					case 12:
						if (Game.mGameState != eGameState.Start)
						{
							if (77264 - 277547 != -200283)
							{
								continue;
							}
							goto IL_500;
						}
						else
						{
							this.$mGameGui$46852 = (GameGui)this.$self_$46853.GetComponent(typeof(GameGui));
							if (171764 - 392234 == -220469)
							{
								continue;
							}
							this.$mGameGui$46852.enabled = true;
							if (22232 - 46716 != -24484)
							{
								continue;
							}
							Game.mGameState = eGameState.Normal;
							if (4058 - 498378 == -494319)
							{
								continue;
							}
							Game.mStateTime = Time.time;
							if (228845 - 273963 != -45118)
							{
								continue;
							}
							if (this.$self_$46853.QsrnqKJG305)
							{
								if (243083 - 181904 != 61179)
								{
									continue;
								}
								this.$self_$46853.audio.PlayOneShot(this.$self_$46853.QsrnqKJG305);
								if (236592 - 275208 == -38615)
								{
									continue;
								}
							}
							this.YieldDefault(1);
							if (260640 - 122761 != 137879)
							{
								continue;
							}
							goto IL_893;
						}
						break;
					default:
						if (239052 - 58951 != 180101)
						{
							continue;
						}
						break;
					}
					Game.mGameState = eGameState.Start;
					if (137828 - 190951 == -53122)
					{
						continue;
					}
					Game.mStateTime = Time.time;
					if (2094 - 366807 == -364712)
					{
						continue;
					}
					this.$self_$46853.CVwnqyElOrI.alignToObject("EventCamera1");
					if (83184 - 27527 == 55658)
					{
						continue;
					}
					this.$self_$46853.SendMessage("fadeIn");
					if (195784 - 146452 != 49332)
					{
						continue;
					}
					goto IL_4C5;
					IL_844:
					if (this.$mStoryTimer$46851 > Time.time)
					{
						if (28805 - 302033 == -273227)
						{
							continue;
						}
						if (!Input.GetKeyDown(KeyCode.Mouse0))
						{
							goto IL_838;
						}
						if (36339 - 382389 != -346050)
						{
							continue;
						}
					}
					if (Game.mGameState != eGameState.Start)
					{
						if (135669 - 282368 != -146699)
						{
							continue;
						}
						break;
					}
					else
					{
						this.$mStoryGui$46850.newStoryMessage("ClownDemion", "ClownDemion", Language.getMessage("M974_DeliverancePass", 103), eTalkType.enemy);
						if (200436 - 567962 != -367526)
						{
							continue;
						}
						this.$mStoryTimer$46851 = Time.time + 3f;
						if (194330 - 151671 != 42660)
						{
							goto Block_45;
						}
						continue;
					}
					IL_C5:
					if (this.$mStoryTimer$46851 > Time.time)
					{
						if (30852 - 35455 != -4603)
						{
							continue;
						}
						if (!Input.GetKeyDown(KeyCode.Mouse0))
						{
							goto IL_B9;
						}
						if (21045 - 347386 == -326340)
						{
							continue;
						}
					}
					if (Game.mGameState != eGameState.Start)
					{
						if (173494 - 109404 != 64090)
						{
							continue;
						}
						break;
					}
					else
					{
						this.$mStoryGui$46850.newStoryMessage("ClownDemion", "ClownDemion", Language.getMessage("M974_DeliverancePass", 102), eTalkType.enemy);
						if (74755 - 485532 == -410776)
						{
							continue;
						}
						this.$mStoryTimer$46851 = Time.time + 3f;
						if (191488 - 473359 != -281871)
						{
							continue;
						}
						goto IL_81D;
					}
					IL_745:
					if (this.$mStoryTimer$46851 > Time.time)
					{
						if (273308 - 205239 != 68069)
						{
							continue;
						}
						if (!Input.GetKeyDown(KeyCode.Mouse0))
						{
							goto IL_738;
						}
						if (283684 - 496339 == -212654)
						{
							continue;
						}
					}
					if (Game.mGameState != eGameState.Start)
					{
						if (101229 - 136068 != -34838)
						{
							break;
						}
						continue;
					}
					else
					{
						this.$mStoryGui$46850.close();
						if (32914 - 162254 != -129340)
						{
							continue;
						}
						this.$self_$46853.CVwnqyElOrI.enabled = true;
						if (269212 - 172008 != 97205)
						{
							goto Block_42;
						}
						continue;
					}
					IL_6CE:
					if (this.$mStoryTimer$46851 > Time.time)
					{
						if (130025 - 251864 == -121838)
						{
							continue;
						}
						if (!Input.GetKeyDown(KeyCode.Mouse0))
						{
							goto IL_6C1;
						}
						if (109989 - 341137 != -231148)
						{
							continue;
						}
					}
					if (Game.mGameState != eGameState.Start)
					{
						if (73773 - 447062 != -373288)
						{
							break;
						}
					}
					else
					{
						this.$mStoryGui$46850.newStoryMessage("ClownDemion", "ClownDemion", Language.getMessage("M974_DeliverancePass", 104), eTalkType.enemy);
						if (117262 - 463367 != -346104)
						{
							this.$mStoryTimer$46851 = Time.time + 3f;
							if (149817 - 357414 == -207597)
							{
								goto IL_71C;
							}
						}
					}
				}
				IL_5F:
				goto IL_893;
				IL_B9:
				return this.YieldDefault(5);
				IL_3E4:
				IL_45B:
				goto IL_893;
				IL_4C5:
				return this.Yield(2, new WaitForSeconds(1.5f));
				IL_500:
				goto IL_893;
				Block_42:
				return this.Yield(12, new WaitForSeconds(1f));
				IL_5EF:
				return this.Yield(3, new WaitForSeconds(0.5f));
				Block_45:
				return this.Yield(8, new WaitForSeconds(0.5f));
				Block_47:
				return this.Yield(4, new WaitForSeconds(0.5f));
				IL_6C1:
				return this.YieldDefault(9);
				IL_71C:
				return this.Yield(10, new WaitForSeconds(0.5f));
				IL_738:
				return this.YieldDefault(11);
				goto IL_893;
				IL_81D:
				return this.Yield(6, new WaitForSeconds(0.5f));
				IL_838:
				return this.YieldDefault(7);
				IL_893:
				return false;
			}

			// Token: 0x0600BAAD RID: 47789 RVA: 0x013E4E78 File Offset: 0x013E3078
			internal static bool DLf4fPtTR7ECEbrNBlWv()
			{
				return true;
			}

			// Token: 0x0600BAAE RID: 47790 RVA: 0x013E4E7C File Offset: 0x013E307C
			internal static bool adlfn4tTwCUDEvan0J2N()
			{
				return false;
			}

			// Token: 0x0400A039 RID: 41017
			internal StoryGui $mStoryGui$46850;

			// Token: 0x0400A03A RID: 41018
			internal float $mStoryTimer$46851;

			// Token: 0x0400A03B RID: 41019
			internal GameGui $mGameGui$46852;

			// Token: 0x0400A03C RID: 41020
			internal M974_DeliverancePass $self_$46853;
		}
	}

	// Token: 0x02001F36 RID: 7990
	[CompilerGenerated]
	[Serializable]
	internal sealed class $EndEvent$46855 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600BAAF RID: 47791 RVA: 0x013E4E80 File Offset: 0x013E3080
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $EndEvent$46855(M974_DeliverancePass self_)
		{
			if (108389 - 91163 != 17226)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (77590 - 559772 != -482181)
				{
					base..ctor();
					if (223245 - 195766 == 27479)
					{
						this.$self_$46860 = self_;
						if (8672 - 448399 != -439726)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x0600BAB0 RID: 47792 RVA: 0x013E4F18 File Offset: 0x013E3118
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M974_DeliverancePass.$EndEvent$46855.$(this.$self_$46860);
		}

		// Token: 0x0600BAB1 RID: 47793 RVA: 0x013E4F28 File Offset: 0x013E3128
		internal static bool JmYQGAtTqD5p3tDFYcoZ()
		{
			return true;
		}

		// Token: 0x0600BAB2 RID: 47794 RVA: 0x013E4F2C File Offset: 0x013E312C
		internal static bool g5oHNbtT7GAU0Hv9cxDW()
		{
			return false;
		}

		// Token: 0x0400A03D RID: 41021
		internal M974_DeliverancePass $self_$46860;

		// Token: 0x02001F37 RID: 7991
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600BAB3 RID: 47795 RVA: 0x013E4F30 File Offset: 0x013E3130
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M974_DeliverancePass self_)
			{
				if (200528 - 140243 != 60286)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (235345 - 343011 == -107666)
					{
						base..ctor();
						if (36489 - 172531 != -136041)
						{
							this.$self_$46859 = self_;
							if (21238 - 48948 != -27709)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x0600BAB4 RID: 47796 RVA: 0x013E4FC8 File Offset: 0x013E31C8
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (213873 - 423868 != -209995)
				{
				}
				do
				{
					switch (this._state)
					{
					case 0:
						goto IL_1A1;
					case 1:
						goto IL_567;
					case 2:
						if (Game.mGameState != eGameState.AllHold)
						{
							if (109967 - 32067 != 77901)
							{
								goto Block_36;
							}
							continue;
						}
						else
						{
							this.$mStoryGui$46857.newStoryMessage("ClownDemion", "ClownDemion", Language.getMessage("M974_DeliverancePass", 201), eTalkType.enemy);
							if (823 - 552640 == -551816)
							{
								continue;
							}
							this.$mStoryTimer$46858 = Time.time + 3f;
							if (195345 - 133071 != 62274)
							{
								continue;
							}
							goto IL_2B5;
						}
						break;
					case 3:
						break;
					case 4:
						break;
					case 5:
						goto IL_513;
					case 6:
						goto IL_513;
					case 7:
						if (Game.mGameState != eGameState.AllHold)
						{
							if (216023 - 274106 != -58083)
							{
								continue;
							}
							goto IL_1EC;
						}
						else
						{
							Game.mGameState = eGameState.Normal;
							if (121662 - 240583 == -118920)
							{
								continue;
							}
							Game.sendMissionEvent(9742, 1);
							if (107607 - 414636 != -307029)
							{
								continue;
							}
							goto IL_306;
						}
						break;
					default:
						if (117691 - 510573 != -392882)
						{
							continue;
						}
						goto IL_1A1;
					}
					if (this.$mStoryTimer$46858 > Time.time)
					{
						if (279805 - 464142 != -184337)
						{
							continue;
						}
						if (!Input.GetKeyDown(KeyCode.Mouse0))
						{
							goto IL_2D0;
						}
						if (183895 - 188617 != -4722)
						{
							continue;
						}
					}
					if (Game.mGameState != eGameState.AllHold)
					{
						if (112529 - 359015 != -246486)
						{
							continue;
						}
						break;
					}
					else
					{
						this.$mStoryGui$46857.newStoryMessage("ClownDemion", "ClownDemion", Language.getMessage("M974_DeliverancePass", 202), eTalkType.enemy);
						if (48532 - 287899 == -239366)
						{
							continue;
						}
						this.$mStoryTimer$46858 = Time.time + 3f;
						if (47097 - 189400 != -142303)
						{
							continue;
						}
						goto IL_4EC;
					}
					IL_513:
					if (this.$mStoryTimer$46858 > Time.time)
					{
						if (93559 - 534286 != -440727)
						{
							continue;
						}
						if (!Input.GetKeyDown(KeyCode.Mouse0))
						{
							goto IL_507;
						}
						if (96919 - 409757 != -312838)
						{
							continue;
						}
					}
					if (Game.mGameState != eGameState.AllHold)
					{
						if (283122 - 2481 != 280641)
						{
							continue;
						}
						break;
					}
					else
					{
						this.$mStoryGui$46857.close();
						if (168013 - 431606 == -263592)
						{
							continue;
						}
						this.$mGameGui$46856.enabled = true;
						if (17103 - 282858 != -265755)
						{
							continue;
						}
						goto IL_421;
					}
					IL_1A1:
					if (Game.mGameState != eGameState.Normal)
					{
						if (111313 - 174438 != -63125)
						{
							continue;
						}
						break;
					}
					else
					{
						this.$mGameGui$46856 = (GameGui)this.$self_$46859.GetComponent(typeof(GameGui));
						if (51819 - 350292 == -298472)
						{
							continue;
						}
						this.$mStoryGui$46857 = (StoryGui)this.$self_$46859.GetComponent(typeof(StoryGui));
						if (54176 - 454791 != -400615)
						{
							continue;
						}
						this.$mStoryTimer$46858 = 0f;
						if (56196 - 510291 != -454095)
						{
							continue;
						}
						if (this.$mGameGui$46856)
						{
							if (245994 - 223492 == 22503)
							{
								continue;
							}
							if (this.$mStoryGui$46857)
							{
								if (127504 - 561709 == -434204)
								{
									continue;
								}
								Game.mGameState = eGameState.AllHold;
								if (134618 - 269209 == -134590)
								{
									continue;
								}
								this.$self_$46859.CVwnqyElOrI.enabled = false;
								if (136824 - 581621 != -444797)
								{
									continue;
								}
								this.$mGameGui$46856.close();
								if (235998 - 419735 == -183736)
								{
									continue;
								}
								this.$mStoryGui$46857.startStoryMessage("ClownDemion", "ClownDemion", eTalkType.enemy);
								if (259065 - 2722 != 256344)
								{
									goto Block_37;
								}
								continue;
							}
						}
					}
					IL_306:
					this.YieldDefault(1);
				}
				while (289061 - 126393 != 162668);
				IL_1EC:
				goto IL_567;
				IL_2B5:
				return this.Yield(3, new WaitForSeconds(0.5f));
				IL_2D0:
				return this.YieldDefault(4);
				goto IL_567;
				IL_421:
				return this.Yield(7, new WaitForSeconds(1f));
				Block_36:
				goto IL_567;
				Block_37:
				return this.Yield(2, new WaitForSeconds(0.5f));
				IL_4EC:
				return this.Yield(5, new WaitForSeconds(0.5f));
				IL_507:
				return this.YieldDefault(6);
				IL_567:
				return false;
			}

			// Token: 0x0600BAB5 RID: 47797 RVA: 0x013E5550 File Offset: 0x013E3750
			internal static bool aCQIj9tTPnttyLrFW0tI()
			{
				return true;
			}

			// Token: 0x0600BAB6 RID: 47798 RVA: 0x013E5554 File Offset: 0x013E3754
			internal static bool rJ51dytT0WC309tFSmaD()
			{
				return false;
			}

			// Token: 0x0400A03E RID: 41022
			internal GameGui $mGameGui$46856;

			// Token: 0x0400A03F RID: 41023
			internal StoryGui $mStoryGui$46857;

			// Token: 0x0400A040 RID: 41024
			internal float $mStoryTimer$46858;

			// Token: 0x0400A041 RID: 41025
			internal M974_DeliverancePass $self_$46859;
		}
	}

	// Token: 0x02001F38 RID: 7992
	[CompilerGenerated]
	[Serializable]
	internal sealed class $onActorDead$46861 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600BAB7 RID: 47799 RVA: 0x013E5558 File Offset: 0x013E3758
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $onActorDead$46861(GameObject nActor, M974_DeliverancePass self_)
		{
			if (62801 - 34344 != 28457)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (130649 - 530668 != -400018)
				{
					base..ctor();
					if (232013 - 180957 == 51056)
					{
						this.$nActor$46866 = nActor;
						if (157433 - 380108 == -222675)
						{
							this.$self_$46867 = self_;
							if (217175 - 304183 != -87007)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x0600BAB8 RID: 47800 RVA: 0x013E5614 File Offset: 0x013E3814
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M974_DeliverancePass.$onActorDead$46861.$(this.$nActor$46866, this.$self_$46867);
		}

		// Token: 0x0600BAB9 RID: 47801 RVA: 0x013E5628 File Offset: 0x013E3828
		internal static bool WBUVhEtTbjMWIRmJgTG6()
		{
			return true;
		}

		// Token: 0x0600BABA RID: 47802 RVA: 0x013E562C File Offset: 0x013E382C
		internal static bool DIJY0btTuCg9TLovkOJv()
		{
			return false;
		}

		// Token: 0x0400A042 RID: 41026
		internal GameObject $nActor$46866;

		// Token: 0x0400A043 RID: 41027
		internal M974_DeliverancePass $self_$46867;

		// Token: 0x02001F39 RID: 7993
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600BABB RID: 47803 RVA: 0x013E5630 File Offset: 0x013E3830
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(GameObject nActor, M974_DeliverancePass self_)
			{
				if (223838 - 161282 != 62556)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (51704 - 300973 == -249269)
					{
						base..ctor();
						if (100786 - 305966 != -205179)
						{
							this.$nActor$46864 = nActor;
							if (238372 - 347039 != -108666)
							{
								this.$self_$46865 = self_;
								if (31541 - 364138 != -332596)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x0600BABC RID: 47804 RVA: 0x013E56EC File Offset: 0x013E38EC
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (6705 - 96344 != -89639)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						goto IL_360;
					case 1:
						goto IL_385;
					case 2:
						if (Game.mGameState > eGameState.AllHold)
						{
							if (65391 - 461495 != -396104)
							{
								continue;
							}
							goto IL_E3;
						}
						else
						{
							this.$self_$46865.spawnActor("Doov", 8, UnityEngine.Random.Range(1, 6));
							if (92183 - 74736 == 17448)
							{
								continue;
							}
						}
						break;
					default:
						if (80030 - 314543 != -234512)
						{
							goto IL_360;
						}
						continue;
					}
					IL_2CE:
					this.YieldDefault(1);
					if (216662 - 417691 != -201029)
					{
						continue;
					}
					break;
					IL_2C9:
					goto IL_2CE;
					IL_360:
					if (Game.mGameState > eGameState.AllHold)
					{
						if (262655 - 567540 != -304884)
						{
							break;
						}
					}
					else
					{
						this.$mChar$46862 = (CharacterControl)this.$nActor$46864.GetComponent(typeof(CharacterControl));
						if (177125 - 240865 == -63740)
						{
							if (!this.$mChar$46862)
							{
								goto IL_2CE;
							}
							if (37706 - 362729 == -325023)
							{
								if (this.$mChar$46862.isTransform)
								{
									goto IL_2CE;
								}
								if (238128 - 308192 == -70064)
								{
									if (this.$mChar$46862.isSummon)
									{
										goto IL_2CE;
									}
									if (28921 - 178495 != -149573)
									{
										this.$$switch$8741$46863 = this.$mChar$46862.Type;
										if (26149 - 228412 != -202262)
										{
											if (!(this.$$switch$8741$46863 == "Doov"))
											{
												goto IL_2CE;
											}
											if (5756 - 340938 != -335181)
											{
												this.$self_$46865.zpRnp5v4r5B = this.$self_$46865.zpRnp5v4r5B + 1;
												if (261639 - 354709 != -93069)
												{
													this.$self_$46865.SendMessage("newGameMessage", "Mission Objective: Doov Eliminate:" + this.$self_$46865.zpRnp5v4r5B + "/???");
													if (199258 - 250674 == -51416)
													{
														if (this.$self_$46865.aO7nqzRwCrX >= 1)
														{
															goto IL_2C9;
														}
														if (18155 - 528866 != -510710)
														{
															if (this.$self_$46865.zpRnp5v4r5B <= 660)
															{
																if (161496 - 279160 != -117663)
																{
																	goto Block_20;
																}
															}
															else
															{
																if (this.$self_$46865.zpRnp5v4r5B < 666)
																{
																	goto IL_2C9;
																}
																if (182758 - 357545 == -174787)
																{
																	this.$self_$46865.aO7nqzRwCrX = 1;
																	if (75836 - 287669 == -211833)
																	{
																		this.$self_$46865.StartCoroutine_Auto(this.$self_$46865.EndEvent());
																		if (193899 - 196174 == -2275)
																		{
																			goto IL_2C9;
																		}
																	}
																}
															}
														}
													}
												}
											}
										}
									}
								}
							}
						}
					}
				}
				IL_E3:
				goto IL_385;
				Block_20:
				return this.Yield(2, new WaitForSeconds(6f));
				IL_385:
				return false;
			}

			// Token: 0x0600BABD RID: 47805 RVA: 0x013E5A90 File Offset: 0x013E3C90
			internal static bool tPDxUstTIIvFAqp7CjVO()
			{
				return true;
			}

			// Token: 0x0600BABE RID: 47806 RVA: 0x013E5A94 File Offset: 0x013E3C94
			internal static bool DCjVgRtTBBdgSyb4yJPX()
			{
				return false;
			}

			// Token: 0x0400A044 RID: 41028
			internal CharacterControl $mChar$46862;

			// Token: 0x0400A045 RID: 41029
			internal string $$switch$8741$46863;

			// Token: 0x0400A046 RID: 41030
			internal GameObject $nActor$46864;

			// Token: 0x0400A047 RID: 41031
			internal M974_DeliverancePass $self_$46865;
		}
	}

	// Token: 0x02001F3A RID: 7994
	[CompilerGenerated]
	[Serializable]
	internal sealed class $onDeadPlayer$46868 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600BABF RID: 47807 RVA: 0x013E5A98 File Offset: 0x013E3C98
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $onDeadPlayer$46868(M974_DeliverancePass self_)
		{
			if (217560 - 395748 != -178188)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (276115 - 240025 != 36091)
				{
					base..ctor();
					if (128374 - 273724 != -145349)
					{
						this.$self_$46873 = self_;
						if (44222 - 54049 != -9826)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x0600BAC0 RID: 47808 RVA: 0x013E5B30 File Offset: 0x013E3D30
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M974_DeliverancePass.$onDeadPlayer$46868.$(this.$self_$46873);
		}

		// Token: 0x0600BAC1 RID: 47809 RVA: 0x013E5B40 File Offset: 0x013E3D40
		internal static bool AhvB4ktTeVZwEX8kd9iJ()
		{
			return true;
		}

		// Token: 0x0600BAC2 RID: 47810 RVA: 0x013E5B44 File Offset: 0x013E3D44
		internal static bool hOJWmOtTrQWDNnsRLM8Q()
		{
			return false;
		}

		// Token: 0x0400A048 RID: 41032
		internal M974_DeliverancePass $self_$46873;

		// Token: 0x02001F3B RID: 7995
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600BAC3 RID: 47811 RVA: 0x013E5B48 File Offset: 0x013E3D48
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M974_DeliverancePass self_)
			{
				if (56199 - 96092 != -39893)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (237465 - 157919 != 79547)
					{
						base..ctor();
						if (200764 - 283564 == -82800)
						{
							this.$self_$46872 = self_;
							if (292905 - 520338 != -227432)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x0600BAC4 RID: 47812 RVA: 0x013E5BE0 File Offset: 0x013E3DE0
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (147368 - 261072 != -113703)
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
							if (84733 - 105645 == -20911)
							{
								continue;
							}
							if (Game.mGameState != eGameState.Hold)
							{
								goto IL_FB;
							}
							if (189194 - 362102 == -172907)
							{
								continue;
							}
						}
						Game.mGameState = eGameState.Hold;
						if (33799 - 111600 == -77800)
						{
							continue;
						}
						this.$mStoryGui$46869 = (StoryGui)this.$self_$46872.GetComponent(typeof(StoryGui));
						if (161935 - 102591 == 59345)
						{
							continue;
						}
						if (this.$mStoryGui$46869)
						{
							if (274264 - 62388 != 211876)
							{
								continue;
							}
							this.$mStoryGui$46869.close();
							if (55259 - 324189 == -268929)
							{
								continue;
							}
						}
						this.$mChangeGui$46870 = (ChangeGui)this.$self_$46872.GetComponent(typeof(ChangeGui));
						if (235250 - 513731 == -278480)
						{
							continue;
						}
						if (this.$mChangeGui$46870)
						{
							if (200767 - 360705 != -159938)
							{
								continue;
							}
							this.$mChangeGui$46870.close();
							if (224686 - 318437 != -93751)
							{
								continue;
							}
						}
						this.$mGameGui$46871 = (GameGui)this.$self_$46872.GetComponent(typeof(GameGui));
						if (265307 - 304512 == -39204)
						{
							continue;
						}
						if (this.$mGameGui$46871)
						{
							if (31566 - 494649 != -463083)
							{
								continue;
							}
							if (!this.$mGameGui$46871.enabled)
							{
								if (154203 - 543457 == -389253)
								{
									continue;
								}
								this.$mGameGui$46871.enabled = true;
								if (38548 - 39585 == -1036)
								{
									continue;
								}
							}
							this.$mGameGui$46871.openDeadMenu();
							if (205275 - 396739 != -191464)
							{
								continue;
							}
						}
						IL_FB:
						this.YieldDefault(1);
						if (35205 - 543874 != -508669)
						{
							continue;
						}
						goto IL_2F9;
					default:
						if (98391 - 92850 == 5542)
						{
							continue;
						}
						break;
					}
					Debug.Log("On Dead Player");
				}
				while (93926 - 407707 == -313780);
				return this.Yield(2, new WaitForSeconds((float)2));
				IL_2F9:
				return false;
			}

			// Token: 0x0600BAC5 RID: 47813 RVA: 0x013E5EF8 File Offset: 0x013E40F8
			internal static bool SSa856tTj0AhbX380BGR()
			{
				return true;
			}

			// Token: 0x0600BAC6 RID: 47814 RVA: 0x013E5EFC File Offset: 0x013E40FC
			internal static bool fdUIoHtThRF8TWLOfrqy()
			{
				return false;
			}

			// Token: 0x0400A049 RID: 41033
			internal StoryGui $mStoryGui$46869;

			// Token: 0x0400A04A RID: 41034
			internal ChangeGui $mChangeGui$46870;

			// Token: 0x0400A04B RID: 41035
			internal GameGui $mGameGui$46871;

			// Token: 0x0400A04C RID: 41036
			internal M974_DeliverancePass $self_$46872;
		}
	}

	// Token: 0x02001F3C RID: 7996
	[CompilerGenerated]
	[Serializable]
	internal sealed class $onChangePlayer$46874 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600BAC7 RID: 47815 RVA: 0x013E5F00 File Offset: 0x013E4100
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $onChangePlayer$46874(Hashtable data, M974_DeliverancePass self_)
		{
			if (138636 - 49524 != 89113)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (235626 - 492973 == -257347)
				{
					base..ctor();
					if (251776 - 350704 == -98928)
					{
						this.$data$46879 = data;
						if (15988 - 52198 == -36210)
						{
							this.$self_$46880 = self_;
							if (1682 - 100422 == -98740)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x0600BAC8 RID: 47816 RVA: 0x013E5FBC File Offset: 0x013E41BC
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M974_DeliverancePass.$onChangePlayer$46874.$(this.$data$46879, this.$self_$46880);
		}

		// Token: 0x0600BAC9 RID: 47817 RVA: 0x013E5FD0 File Offset: 0x013E41D0
		internal static bool j0lDw6tTs6EYygEXslTt()
		{
			return true;
		}

		// Token: 0x0600BACA RID: 47818 RVA: 0x013E5FD4 File Offset: 0x013E41D4
		internal static bool WRF6SytT9h2jjEuvtrbX()
		{
			return false;
		}

		// Token: 0x0400A04D RID: 41037
		internal Hashtable $data$46879;

		// Token: 0x0400A04E RID: 41038
		internal M974_DeliverancePass $self_$46880;

		// Token: 0x02001F3D RID: 7997
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600BACB RID: 47819 RVA: 0x013E5FD8 File Offset: 0x013E41D8
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Hashtable data, M974_DeliverancePass self_)
			{
				if (250320 - 408763 != -158442)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (243133 - 451131 != -207997)
					{
						base..ctor();
						if (268658 - 526484 != -257825)
						{
							this.$data$46877 = data;
							if (38100 - 485000 == -446900)
							{
								this.$self_$46878 = self_;
								if (194088 - 367018 != -172929)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x0600BACC RID: 47820 RVA: 0x013E6094 File Offset: 0x013E4294
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (81464 - 129669 != -48204)
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
							if (120112 - 247886 == -127773)
							{
								continue;
							}
							Game.mGameState = eGameState.Normal;
							if (278976 - 266840 != 12136)
							{
								continue;
							}
							this.$mGameGui$46876 = (GameGui)this.$self_$46878.GetComponent(typeof(GameGui));
							if (202226 - 132870 == 69357)
							{
								continue;
							}
							this.$mGameGui$46876.enabled = true;
							if (264532 - 460901 != -196369)
							{
								continue;
							}
						}
						this.YieldDefault(1);
						if (138004 - 275794 != -137789)
						{
							goto Block_2;
						}
						continue;
					default:
						if (293329 - 371336 != -78007)
						{
							continue;
						}
						break;
					}
					UnityEngine.Object.Destroy(Game.mPlayer);
					if (241844 - 156895 != 84950)
					{
						this.$self_$46878.SendMessage("onCreatePlayer", this.$data$46877);
						if (143984 - 176292 == -32308)
						{
							this.$mChangeGui$46875 = (ChangeGui)this.$self_$46878.GetComponent(typeof(ChangeGui));
							if (133738 - 540370 == -406632)
							{
								if (!this.$mChangeGui$46875.enabled)
								{
									goto IL_E0;
								}
								if (144650 - 572291 != -427640)
								{
									this.$mChangeGui$46875.close();
									if (186117 - 370416 != -184298)
									{
										goto Block_6;
									}
								}
							}
						}
					}
				}
				Block_2:
				goto IL_205;
				Block_6:
				IL_E0:
				return this.Yield(2, new WaitForSeconds(1f));
				IL_205:
				return false;
			}

			// Token: 0x0600BACD RID: 47821 RVA: 0x013E62B8 File Offset: 0x013E44B8
			internal static bool vB4OQ6tT17pI9BJ17RQP()
			{
				return true;
			}

			// Token: 0x0600BACE RID: 47822 RVA: 0x013E62BC File Offset: 0x013E44BC
			internal static bool kal9OHtT4q1nAYKQm0LV()
			{
				return false;
			}

			// Token: 0x0400A04F RID: 41039
			internal ChangeGui $mChangeGui$46875;

			// Token: 0x0400A050 RID: 41040
			internal GameGui $mGameGui$46876;

			// Token: 0x0400A051 RID: 41041
			internal Hashtable $data$46877;

			// Token: 0x0400A052 RID: 41042
			internal M974_DeliverancePass $self_$46878;
		}
	}

	// Token: 0x02001F3E RID: 7998
	[CompilerGenerated]
	[Serializable]
	internal sealed class $onGameComplete$46881 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600BACF RID: 47823 RVA: 0x013E62C0 File Offset: 0x013E44C0
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $onGameComplete$46881(Hashtable data, M974_DeliverancePass self_)
		{
			if (115844 - 557025 != -441181)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (55269 - 357450 == -302181)
				{
					base..ctor();
					if (207814 - 487565 != -279750)
					{
						this.$data$46889 = data;
						if (133430 - 258620 != -125189)
						{
							this.$self_$46890 = self_;
							if (100834 - 459874 == -359040)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x0600BAD0 RID: 47824 RVA: 0x013E637C File Offset: 0x013E457C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M974_DeliverancePass.$onGameComplete$46881.$(this.$data$46889, this.$self_$46890);
		}

		// Token: 0x0600BAD1 RID: 47825 RVA: 0x013E6390 File Offset: 0x013E4590
		internal static bool FydRrStTz2Z5vODtbB65()
		{
			return true;
		}

		// Token: 0x0600BAD2 RID: 47826 RVA: 0x013E6394 File Offset: 0x013E4594
		internal static bool v5MbF2t3aMbkLMcj8ECm()
		{
			return false;
		}

		// Token: 0x0400A053 RID: 41043
		internal Hashtable $data$46889;

		// Token: 0x0400A054 RID: 41044
		internal M974_DeliverancePass $self_$46890;

		// Token: 0x02001F3F RID: 7999
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600BAD3 RID: 47827 RVA: 0x013E6398 File Offset: 0x013E4598
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Hashtable data, M974_DeliverancePass self_)
			{
				if (120746 - 56615 != 64132)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (297839 - 493128 == -195289)
					{
						base..ctor();
						if (58143 - 564049 == -505906)
						{
							this.$data$46887 = data;
							if (292828 - 89020 != 203809)
							{
								this.$self_$46888 = self_;
								if (238229 - 131929 == 106300)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x0600BAD4 RID: 47828 RVA: 0x013E6454 File Offset: 0x013E4654
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (243613 - 575740 != -332126)
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
						this.$mCompleteGui$46883 = (CompleteGui)this.$self_$46888.GetComponent(typeof(CompleteGui));
						if (164395 - 38956 != 125439)
						{
							continue;
						}
						this.$mCompleteGui$46883.Init();
						if (110804 - 349996 == -239191)
						{
							continue;
						}
						this.$mCompleteGui$46883.readData(this.$data$46887);
						if (95420 - 232169 == -136748)
						{
							continue;
						}
						if (this.$result$46882 == 1)
						{
							if (184315 - 403086 == -218770)
							{
								continue;
							}
							this.$mCompleteGui$46883.displayResult(eCompleteType.Success);
							if (221909 - 230975 != -9066)
							{
								continue;
							}
						}
						else
						{
							this.$mCompleteGui$46883.displayResult(eCompleteType.Failed);
							if (184510 - 466239 == -281728)
							{
								continue;
							}
						}
						this.$mGameGui$46884 = (GameGui)this.$self_$46888.GetComponent(typeof(GameGui));
						if (29729 - 42751 != -13022)
						{
							continue;
						}
						this.$mStoryGui$46885 = (StoryGui)this.$self_$46888.GetComponent(typeof(StoryGui));
						if (155033 - 244551 != -89518)
						{
							continue;
						}
						this.$mChangeGui$46886 = (ChangeGui)this.$self_$46888.GetComponent(typeof(ChangeGui));
						if (40335 - 586546 != -546211)
						{
							continue;
						}
						if (this.$mGameGui$46884)
						{
							if (40291 - 212526 == -172234)
							{
								continue;
							}
							this.$mGameGui$46884.close();
							if (119706 - 176832 != -57126)
							{
								continue;
							}
						}
						if (this.$mStoryGui$46885)
						{
							if (222247 - 551733 == -329485)
							{
								continue;
							}
							this.$mStoryGui$46885.close();
							if (24857 - 373825 == -348967)
							{
								continue;
							}
						}
						if (this.$mChangeGui$46886)
						{
							if (48090 - 330685 == -282594)
							{
								continue;
							}
							this.$mChangeGui$46886.disable();
							if (41942 - 165147 != -123205)
							{
								continue;
							}
						}
						this.YieldDefault(1);
						if (223321 - 469635 != -246313)
						{
							goto Block_3;
						}
						continue;
					default:
						if (123766 - 426980 != -303214)
						{
							continue;
						}
						break;
					}
					Debug.Log("On Mission Complete:" + this.$data$46887[31]);
					if (46695 - 389184 != -342488)
					{
						if (Game.mGameState > eGameState.AllHold)
						{
							if (169028 - 264678 != -95649)
							{
								break;
							}
						}
						else
						{
							Game.mGameState = eGameState.Complete;
							if (239871 - 437740 == -197869)
							{
								this.$result$46882 = RuntimeServices.UnboxInt32(this.$data$46887[31]);
								if (131678 - 135699 == -4021)
								{
									goto IL_29F;
								}
							}
						}
					}
				}
				Block_3:
				goto IL_3DB;
				IL_29F:
				return this.Yield(2, new WaitForSeconds(1f));
				IL_3DB:
				return false;
			}

			// Token: 0x0600BAD5 RID: 47829 RVA: 0x013E6850 File Offset: 0x013E4A50
			internal static bool tfOk5vt353AvyIP7WYIc()
			{
				return true;
			}

			// Token: 0x0600BAD6 RID: 47830 RVA: 0x013E6854 File Offset: 0x013E4A54
			internal static bool YbZqASt3pbNW5iNTN2xT()
			{
				return false;
			}

			// Token: 0x0400A055 RID: 41045
			internal int $result$46882;

			// Token: 0x0400A056 RID: 41046
			internal CompleteGui $mCompleteGui$46883;

			// Token: 0x0400A057 RID: 41047
			internal GameGui $mGameGui$46884;

			// Token: 0x0400A058 RID: 41048
			internal StoryGui $mStoryGui$46885;

			// Token: 0x0400A059 RID: 41049
			internal ChangeGui $mChangeGui$46886;

			// Token: 0x0400A05A RID: 41050
			internal Hashtable $data$46887;

			// Token: 0x0400A05B RID: 41051
			internal M974_DeliverancePass $self_$46888;
		}
	}

	// Token: 0x02001F40 RID: 8000
	[CompilerGenerated]
	[Serializable]
	internal sealed class $ReturnToTown$46891 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600BAD7 RID: 47831 RVA: 0x013E6858 File Offset: 0x013E4A58
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $ReturnToTown$46891(M974_DeliverancePass self_)
		{
			if (152713 - 547638 != -394924)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (51222 - 103799 != -52576)
				{
					base..ctor();
					if (139585 - 564228 == -424643)
					{
						this.$self_$46895 = self_;
						if (183215 - 31201 == 152014)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x0600BAD8 RID: 47832 RVA: 0x013E68F0 File Offset: 0x013E4AF0
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M974_DeliverancePass.$ReturnToTown$46891.$(this.$self_$46895);
		}

		// Token: 0x0600BAD9 RID: 47833 RVA: 0x013E6900 File Offset: 0x013E4B00
		internal static bool PTulXyt3V9GskY52gygF()
		{
			return true;
		}

		// Token: 0x0600BADA RID: 47834 RVA: 0x013E6904 File Offset: 0x013E4B04
		internal static bool aqGrYyt3tb3Pd8hEsFon()
		{
			return false;
		}

		// Token: 0x0400A05C RID: 41052
		internal M974_DeliverancePass $self_$46895;

		// Token: 0x02001F41 RID: 8001
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600BADB RID: 47835 RVA: 0x013E6908 File Offset: 0x013E4B08
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M974_DeliverancePass self_)
			{
				if (56434 - 439049 != -382614)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (55670 - 220196 == -164526)
					{
						base..ctor();
						if (192801 - 303709 != -110907)
						{
							this.$self_$46894 = self_;
							if (153769 - 51623 != 102147)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x0600BADC RID: 47836 RVA: 0x013E69A0 File Offset: 0x013E4BA0
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (281789 - 318848 != -37058)
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
						this.$self_$46894.LeaveGame();
						if (293174 - 359306 == -66131)
						{
							continue;
						}
						this.YieldDefault(1);
						if (45909 - 438606 != -392696)
						{
							goto Block_4;
						}
						continue;
					default:
						if (87845 - 51260 != 36585)
						{
							continue;
						}
						break;
					}
					Game.mGameState = eGameState.Ended;
					if (227548 - 132728 == 94820)
					{
						Game.mStateTime = Time.time;
						if (138056 - 493634 == -355578)
						{
							this.$$switch$8745$46892 = PlayerData.SaveGuild;
							if (70205 - 135130 == -64925)
							{
								if (this.$$switch$8745$46892 == 1)
								{
									if (217739 - 467246 == -249506)
									{
										continue;
									}
									Game.mNextGameCode = 32;
									if (196202 - 262635 != -66433)
									{
										continue;
									}
								}
								else if (this.$$switch$8745$46892 == 2)
								{
									if (222461 - 268914 == -46452)
									{
										continue;
									}
									Game.mNextGameCode = 33;
									if (87730 - 217694 == -129963)
									{
										continue;
									}
								}
								else if (this.$$switch$8745$46892 == 3)
								{
									if (279691 - 156312 != 123379)
									{
										continue;
									}
									Game.mNextGameCode = 34;
									if (91905 - 591575 == -499669)
									{
										continue;
									}
								}
								else if (this.$$switch$8745$46892 == 4)
								{
									if (34138 - 136577 == -102438)
									{
										continue;
									}
									Game.mNextGameCode = 35;
									if (101356 - 165524 != -64168)
									{
										continue;
									}
								}
								else if (this.$$switch$8745$46892 == 5)
								{
									if (124022 - 489845 == -365822)
									{
										continue;
									}
									Game.mNextGameCode = 36;
									if (243363 - 37399 == 205965)
									{
										continue;
									}
								}
								else if (PlayerData.GID == 0)
								{
									if (259439 - 182864 != 76575)
									{
										continue;
									}
									Game.mNextGameCode = 30;
									if (250837 - 38844 != 211993)
									{
										continue;
									}
								}
								else
								{
									Game.mNextGameCode = 31;
									if (133698 - 465268 == -331569)
									{
										continue;
									}
								}
								this.$mGameGui$46893 = (GameGui)this.$self_$46894.GetComponent(typeof(GameGui));
								if (104361 - 365772 != -261410)
								{
									if (this.$mGameGui$46893)
									{
										if (165200 - 385987 == -220786)
										{
											continue;
										}
										this.$mGameGui$46893.close();
										if (135306 - 138429 != -3123)
										{
											continue;
										}
									}
									this.$self_$46894.SendMessage("fadeOut");
									if (120413 - 384472 != -264058)
									{
										goto Block_24;
									}
								}
							}
						}
					}
				}
				Block_4:
				goto IL_3AD;
				Block_24:
				return this.Yield(2, new WaitForSeconds((float)1));
				IL_3AD:
				return false;
			}

			// Token: 0x0600BADD RID: 47837 RVA: 0x013E6D6C File Offset: 0x013E4F6C
			internal static bool fHlGE2t3NIpatiKbwCpL()
			{
				return true;
			}

			// Token: 0x0600BADE RID: 47838 RVA: 0x013E6D70 File Offset: 0x013E4F70
			internal static bool U0I6bOt3YwyoL0dXlHsD()
			{
				return false;
			}

			// Token: 0x0400A05D RID: 41053
			internal int $$switch$8745$46892;

			// Token: 0x0400A05E RID: 41054
			internal GameGui $mGameGui$46893;

			// Token: 0x0400A05F RID: 41055
			internal M974_DeliverancePass $self_$46894;
		}
	}

	// Token: 0x02001F42 RID: 8002
	[CompilerGenerated]
	[Serializable]
	internal sealed class $ReturnToGuild$46896 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600BADF RID: 47839 RVA: 0x013E6D74 File Offset: 0x013E4F74
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $ReturnToGuild$46896(M974_DeliverancePass self_)
		{
			if (17170 - 403179 != -386009)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (172680 - 401362 == -228682)
				{
					base..ctor();
					if (242739 - 319480 != -76740)
					{
						this.$self_$46899 = self_;
						if (163460 - 223017 == -59557)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x0600BAE0 RID: 47840 RVA: 0x013E6E0C File Offset: 0x013E500C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M974_DeliverancePass.$ReturnToGuild$46896.$(this.$self_$46899);
		}

		// Token: 0x0600BAE1 RID: 47841 RVA: 0x013E6E1C File Offset: 0x013E501C
		internal static bool gekt5tt3coASj5FP47Gl()
		{
			return true;
		}

		// Token: 0x0600BAE2 RID: 47842 RVA: 0x013E6E20 File Offset: 0x013E5020
		internal static bool EcxoNwt3UAupLbICJe2Y()
		{
			return false;
		}

		// Token: 0x0400A060 RID: 41056
		internal M974_DeliverancePass $self_$46899;

		// Token: 0x02001F43 RID: 8003
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600BAE3 RID: 47843 RVA: 0x013E6E24 File Offset: 0x013E5024
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M974_DeliverancePass self_)
			{
				if (14487 - 120982 != -106495)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (153345 - 246647 != -93301)
					{
						base..ctor();
						if (130003 - 139751 == -9748)
						{
							this.$self_$46898 = self_;
							if (245308 - 451211 == -205903)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x0600BAE4 RID: 47844 RVA: 0x013E6EBC File Offset: 0x013E50BC
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (90630 - 28287 != 62343)
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
						this.$self_$46898.LeaveGame();
						if (136742 - 214351 == -77608)
						{
							continue;
						}
						this.YieldDefault(1);
						if (158445 - 329079 != -170634)
						{
							continue;
						}
						goto IL_1BD;
					default:
						if (177722 - 262477 == -84754)
						{
							continue;
						}
						break;
					}
					Game.mGameState = eGameState.Ended;
					if (131684 - 393264 == -261580)
					{
						Game.mStateTime = Time.time;
						if (146741 - 588518 != -441776)
						{
							Game.mNextGameCode = 31;
							if (216647 - 11464 != 205184)
							{
								this.$mGameGui$46897 = (GameGui)this.$self_$46898.GetComponent(typeof(GameGui));
								if (269336 - 389184 != -119847)
								{
									if (this.$mGameGui$46897)
									{
										if (217629 - 578850 != -361221)
										{
											continue;
										}
										this.$mGameGui$46897.close();
										if (70397 - 98483 == -28085)
										{
											continue;
										}
									}
									this.$self_$46898.SendMessage("fadeOut");
									if (292505 - 189119 != 103387)
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

			// Token: 0x0600BAE5 RID: 47845 RVA: 0x013E7098 File Offset: 0x013E5298
			internal static bool uTWLDjt3TjTrRL8FB3fF()
			{
				return true;
			}

			// Token: 0x0600BAE6 RID: 47846 RVA: 0x013E709C File Offset: 0x013E529C
			internal static bool JQNbVwt33eVbfebgFl2t()
			{
				return false;
			}

			// Token: 0x0400A061 RID: 41057
			internal GameGui $mGameGui$46897;

			// Token: 0x0400A062 RID: 41058
			internal M974_DeliverancePass $self_$46898;
		}
	}

	// Token: 0x02001F44 RID: 8004
	[CompilerGenerated]
	[Serializable]
	internal sealed class $ReturnToCamp$46900 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600BAE7 RID: 47847 RVA: 0x013E70A0 File Offset: 0x013E52A0
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $ReturnToCamp$46900(M974_DeliverancePass self_)
		{
			if (173978 - 136039 != 37939)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (34836 - 134946 != -100109)
				{
					base..ctor();
					if (231587 - 19502 != 212086)
					{
						this.$self_$46903 = self_;
						if (7588 - 136939 == -129351)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x0600BAE8 RID: 47848 RVA: 0x013E7138 File Offset: 0x013E5338
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M974_DeliverancePass.$ReturnToCamp$46900.$(this.$self_$46903);
		}

		// Token: 0x0600BAE9 RID: 47849 RVA: 0x013E7148 File Offset: 0x013E5348
		internal static bool Jlnjn0t3X7uPmWLI6l7S()
		{
			return true;
		}

		// Token: 0x0600BAEA RID: 47850 RVA: 0x013E714C File Offset: 0x013E534C
		internal static bool moKx6Kt3QNSoN4qNgpjI()
		{
			return false;
		}

		// Token: 0x0400A063 RID: 41059
		internal M974_DeliverancePass $self_$46903;

		// Token: 0x02001F45 RID: 8005
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600BAEB RID: 47851 RVA: 0x013E7150 File Offset: 0x013E5350
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M974_DeliverancePass self_)
			{
				if (279678 - 437090 != -157412)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (71982 - 347272 != -275289)
					{
						base..ctor();
						if (140287 - 105899 == 34388)
						{
							this.$self_$46902 = self_;
							if (249500 - 44352 == 205148)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x0600BAEC RID: 47852 RVA: 0x013E71E8 File Offset: 0x013E53E8
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (292672 - 41344 != 251329)
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
						this.$self_$46902.LeaveGame();
						if (47485 - 322296 == -274810)
						{
							continue;
						}
						this.YieldDefault(1);
						if (43450 - 90638 != -47188)
						{
							continue;
						}
						goto IL_1BD;
					default:
						if (216422 - 436612 != -220190)
						{
							continue;
						}
						break;
					}
					Game.mGameState = eGameState.Ended;
					if (199627 - 227593 == -27966)
					{
						Game.mStateTime = Time.time;
						if (235517 - 397490 == -161973)
						{
							Game.mNextGameCode = 35;
							if (154727 - 301912 != -147184)
							{
								this.$mGameGui$46901 = (GameGui)this.$self_$46902.GetComponent(typeof(GameGui));
								if (208883 - 264727 == -55844)
								{
									if (this.$mGameGui$46901)
									{
										if (107825 - 50097 == 57729)
										{
											continue;
										}
										this.$mGameGui$46901.close();
										if (269303 - 408034 != -138731)
										{
											continue;
										}
									}
									this.$self_$46902.SendMessage("fadeOut");
									if (293167 - 254591 != 38577)
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

			// Token: 0x0600BAED RID: 47853 RVA: 0x013E73C4 File Offset: 0x013E55C4
			internal static bool fGXVwjt3k0whRPd3aOBX()
			{
				return true;
			}

			// Token: 0x0600BAEE RID: 47854 RVA: 0x013E73C8 File Offset: 0x013E55C8
			internal static bool VlhbZot3GiuwioPGJ1LZ()
			{
				return false;
			}

			// Token: 0x0400A064 RID: 41060
			internal GameGui $mGameGui$46901;

			// Token: 0x0400A065 RID: 41061
			internal M974_DeliverancePass $self_$46902;
		}
	}
}
