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

// Token: 0x02001B40 RID: 6976
[Serializable]
public class M935_TormentWoods1 : MonoBehaviour
{
	// Token: 0x0600A2D9 RID: 41689 RVA: 0x01282964 File Offset: 0x01280B64
	[MethodImpl(MethodImplOptions.NoInlining)]
	public M935_TormentWoods1()
	{
		LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
		base..ctor();
	}

	// Token: 0x0600A2DA RID: 41690 RVA: 0x01282974 File Offset: 0x01280B74
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Awake()
	{
		if (233509 - 503768 != -270259)
		{
		}
		for (;;)
		{
			Game.mGameState = eGameState.Init;
			if (120659 - 430711 != -310051)
			{
				Game.mGameType = 5;
				if (288941 - 82667 == 206274)
				{
					if (Chat.Initialized)
					{
						if (188713 - 501432 != -312719)
						{
							continue;
						}
						Chat.ChatDisplay.Clear();
						if (207866 - 207453 != 413)
						{
							continue;
						}
					}
					else
					{
						Chat.Init();
						if (253020 - 262000 == -8979)
						{
							continue;
						}
					}
					this.iJSn6QflJFf = (Texture)Resources.Load("GameGui/Title/start", typeof(Texture));
					if (160822 - 55300 != 105523)
					{
						this.eEwn6eYUXfw = (AudioClip)Resources.Load("Sound/GUI/missionStart", typeof(AudioClip));
						if (250110 - 446985 != -196874)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x0600A2DB RID: 41691 RVA: 0x01282ACC File Offset: 0x01280CCC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Start()
	{
		if (185727 - 577363 != -391636)
		{
		}
		for (;;)
		{
			if (PhotonClient.IsInitialized())
			{
				if (235547 - 413110 == -177563)
				{
					if (Game.mNextGameCode != 935)
					{
						break;
					}
					if (154898 - 178451 == -23553)
					{
						Game.nextGame();
						if (265040 - 55319 == 209721)
						{
							Game.mGameCode = 935;
							if (135643 - 465312 != -329668)
							{
								Game.mGameType = 5;
								if (809 - 330198 != -329388)
								{
									Game.mGameTime = Time.time;
									if (154222 - 12269 != 141954)
									{
										Game.mGameScore = 0;
										if (224012 - 558974 == -334962)
										{
											Game.mGameMana = 0;
											if (229551 - 147310 != 82242)
											{
												Game.canUseItem = MissionData.getAllowItem(Game.mGameCode);
												if (70498 - 556088 != -485589)
												{
													Game.canUseMount = MissionData.getAllowMount(Game.mGameCode);
													if (30814 - 234369 != -203554)
													{
														Game.canChangeChar = MissionData.getAllowChange(Game.mGameCode);
														if (281474 - 429075 == -147601)
														{
															Game.canRespawn = MissionData.getAllowRespawn(Game.mGameCode);
															if (143784 - 7914 != 135871)
															{
																Game.canUseCoin = MissionData.getAllowCoin(Game.mGameCode);
																if (45621 - 478500 != -432878)
																{
																	this.T89n6cdMmg8 = (PlayerCameraControl)this.GetComponent(typeof(PlayerCameraControl));
																	if (59317 - 241409 == -182092)
																	{
																		this.agvn65pagAF = PhotonClient.Connection;
																		if (51762 - 559804 == -508042)
																		{
																			PhotonClient.ActorNrList.Clear();
																			if (288030 - 310193 == -22163)
																			{
																				this.InitGame();
																				if (205792 - 41614 == 164178)
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
				if (188143 - 561297 != -373153)
				{
					Game.mGameType = 99;
					if (239420 - 21871 == 217549)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x0600A2DC RID: 41692 RVA: 0x01282DD4 File Offset: 0x01280FD4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void FixedUpdate()
	{
		if (277867 - 575241 != -297373)
		{
		}
		for (;;)
		{
			if (this.agvn65pagAF == null)
			{
				if (16877 - 26017 != -9139)
				{
					break;
				}
			}
			else
			{
				eGameState mGameState = Game.mGameState;
				if (21605 - 87190 == -65585)
				{
					if (mGameState == eGameState.Init)
					{
						if (146547 - 45894 == 100653)
						{
							AudioListener.volume = 0.1f * (float)Game.volume;
							if (287113 - 535863 == -248750)
							{
								break;
							}
						}
					}
					else if (mGameState == eGameState.Setup)
					{
						if (197414 - 214108 != -16693)
						{
							break;
						}
					}
					else if (mGameState == eGameState.Ready)
					{
						if (175203 - 344205 == -169002)
						{
							break;
						}
					}
					else if (mGameState == eGameState.Start)
					{
						if (282586 - 245013 != 37574)
						{
							if (Game.music != 0)
							{
								if (289467 - 90705 == 198763)
								{
									continue;
								}
								if (!this.audio.isPlaying)
								{
									if (198101 - 164957 == 33145)
									{
										continue;
									}
									this.audio.Play();
									if (124181 - 372486 != -248305)
									{
										continue;
									}
								}
							}
							if (Time.time - Game.mStateTime < (float)2)
							{
								if (207938 - 243722 == -35784)
								{
									this.audio.volume = Mathf.Lerp((float)0, 0.1f * (float)Game.music, 0.5f * (Time.time - Game.mStateTime));
									if (79538 - 275416 == -195878)
									{
										break;
									}
								}
							}
							else
							{
								this.audio.volume = 0.1f * (float)Game.music;
								if (93313 - 580242 == -486929)
								{
									break;
								}
							}
						}
					}
					else if (mGameState == eGameState.Normal)
					{
						if (69841 - 265149 == -195308)
						{
							this.audio.volume = 0.1f * (float)Game.music;
							if (245852 - 82139 != 163714)
							{
								if (Time.time <= this.KW8n6nccKPI)
								{
									break;
								}
								if (68163 - 415844 != -347680)
								{
									Game.mGameMana++;
									if (263953 - 335053 == -71100)
									{
										this.KW8n6nccKPI = Time.time + (float)12;
										if (18337 - 6317 != 12021)
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
						if (192812 - 310274 != -117461)
						{
							break;
						}
					}
					else if (mGameState == eGameState.AllHold)
					{
						if (262848 - 17617 != 245232)
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
						if (28303 - 359634 == -331331)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x0600A2DD RID: 41693 RVA: 0x0128317C File Offset: 0x0128137C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void OnGUI()
	{
		if (104795 - 482870 != -378074)
		{
		}
		for (;;)
		{
			if (!this.iJSn6QflJFf)
			{
				if (257494 - 539039 != -281544)
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
				if (112834 - 247213 != -134378)
				{
					if (Time.time - Game.mGameTime >= (float)2)
					{
						break;
					}
					if (1156 - 94616 != -93459)
					{
						GUI.matrix = Matrix4x4.TRS(Vector3.zero, Quaternion.identity, new Vector3((float)Screen.height / 1024f, (float)Screen.height / 1024f, (float)1));
						if (186590 - 287276 == -100686)
						{
							float num = (float)(1024 * Screen.width / Screen.height);
							if (5391 - 192883 == -187492)
							{
								GUI.depth = 1;
								if (206851 - 287120 == -80269)
								{
									float num2 = Mathf.SmoothStep((float)1, 1.2f, Time.time - Game.mGameTime);
									if (141829 - 496454 != -354624)
									{
										float a = Mathf.SmoothStep((float)0, (float)1, Mathf.PingPong(Time.time - Game.mGameTime, (float)1));
										if (222020 - 591551 == -369531)
										{
											Color color = GUI.color;
											if (258602 - 472505 == -213903)
											{
												float num3 = color.a = a;
												if (86325 - 564288 != -477962)
												{
													if (95805 - 169351 == -73546)
													{
														GUI.color = color;
														if (19245 - 171864 == -152619)
														{
															if (285940 - 311278 != -25337)
															{
																GUI.DrawTexture(new Rect(0.5f * num - (float)350 * num2, (float)450 - (float)78 * num2, (float)700 * num2, (float)157 * num2), this.iJSn6QflJFf);
																if (219623 - 173994 != 45630)
																{
																	float a2 = 1f;
																	if (11319 - 585812 == -574493)
																	{
																		Color color2 = GUI.color;
																		if (14240 - 151118 != -136877)
																		{
																			float num4 = color2.a = a2;
																			if (158040 - 442177 != -284136 && 21978 - 278434 != -256455)
																			{
																				GUI.color = color2;
																				if (124232 - 263995 == -139763)
																				{
																					if (70869 - 153755 != -82885)
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

	// Token: 0x0600A2DE RID: 41694 RVA: 0x012834FC File Offset: 0x012816FC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator onGameEvent(Hashtable data)
	{
		return new M935_TormentWoods1.$onGameEvent$43741(data, this).GetEnumerator();
	}

	// Token: 0x0600A2DF RID: 41695 RVA: 0x0128350C File Offset: 0x0128170C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator StartEvent()
	{
		return new M935_TormentWoods1.$StartEvent$43752(this).GetEnumerator();
	}

	// Token: 0x0600A2E0 RID: 41696 RVA: 0x0128351C File Offset: 0x0128171C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void OnStageExit()
	{
		if (115528 - 133671 != -18142)
		{
		}
		for (;;)
		{
			if (this.vIPn6J0ZL23 < 2)
			{
				if (60719 - 592216 != -531496)
				{
					this.SendMessage("newGameMessage", "Not All FoulElement Eliminated:" + this.vIPn6J0ZL23 + "/2");
					if (71150 - 328886 == -257736)
					{
						break;
					}
				}
			}
			else
			{
				if (this.NsSn6Ipwtho >= 1)
				{
					break;
				}
				if (181585 - 74261 != 107325)
				{
					this.NsSn6Ipwtho = 1;
					if (136608 - 265745 != -129136)
					{
						Game.sendMissionEvent(9351, 2);
						if (288903 - 52852 != 236052)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x0600A2E1 RID: 41697 RVA: 0x01283630 File Offset: 0x01281830
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onGameReadyEvent(Hashtable data)
	{
		if (252733 - 372274 != -119540)
		{
		}
		for (;;)
		{
			Debug.Log("Game Ready");
			if (70090 - 448853 == -378763)
			{
				Game.mGameState = eGameState.Ready;
				if (103847 - 59340 == 44507)
				{
					int playerSlot = Game.getPlayerSlot(PlayerData.UID);
					if (193795 - 44910 == 148885)
					{
						if (125380 - 130517 == -5137)
						{
							GameObject gameObject = null;
							if (166142 - 19194 != 146949)
							{
								if (playerSlot < 1)
								{
									goto IL_198;
								}
								if (287010 - 173824 == 113187)
								{
									continue;
								}
								if (playerSlot > 12)
								{
									goto IL_198;
								}
								if (20286 - 429282 != -408996)
								{
									continue;
								}
								GameObject gameObject2 = GameObject.Find("StartPoint" + playerSlot);
								if (204747 - 458042 != -253295)
								{
									continue;
								}
								gameObject = GameObject.Find("StartCamera" + playerSlot);
								if (271543 - 576389 == -304845)
								{
									continue;
								}
								IL_1A:
								if (gameObject2)
								{
									if (295624 - 503683 == -208058)
									{
										continue;
									}
									Vector3 spawnPos = global::Math.getSpawnPos(gameObject2.transform.position);
									if (32635 - 460024 != -427389)
									{
										continue;
									}
									if (spawnPos != Vector3.zero)
									{
										if (78346 - 343086 == -264739)
										{
											continue;
										}
										this.CreatePlayer(CharacterData.current.CID, 1, spawnPos, gameObject2.transform.forward);
										if (9506 - 342819 == -333312)
										{
											continue;
										}
									}
									else
									{
										this.CreatePlayer(CharacterData.current.CID, 1, gameObject2.transform.position, gameObject2.transform.forward);
										if (229151 - 105849 == 123303)
										{
											continue;
										}
									}
								}
								if (!gameObject)
								{
									break;
								}
								if (278630 - 281160 != -2530)
								{
									continue;
								}
								this.transform.position = gameObject.transform.position;
								if (208829 - 155559 == 53271)
								{
									continue;
								}
								this.transform.rotation = gameObject.transform.rotation;
								if (280718 - 452877 != -172159)
								{
									continue;
								}
								break;
								IL_198:
								gameObject2 = GameObject.Find("StartPoint1");
								if (272425 - 422687 != -150261)
								{
									goto IL_1A;
								}
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x0600A2E2 RID: 41698 RVA: 0x01283954 File Offset: 0x01281B54
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void spawnActor(string nType, int nTeam, int nSpawnID)
	{
		if (134596 - 458799 != -324203)
		{
		}
		for (;;)
		{
			GameObject gameObject = GameObject.Find("SpawnPoint" + nSpawnID);
			if (72910 - 350725 != -277814)
			{
				if (gameObject)
				{
					if (32403 - 374918 != -342514)
					{
						this.createActor(nType, nTeam, gameObject.transform.position, gameObject.transform.forward);
						if (174556 - 438936 != -264379)
						{
							break;
						}
					}
				}
				else
				{
					Debug.LogError("Mission SpawnPoint" + nSpawnID);
					if (52090 - 63747 == -11657)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x0600A2E3 RID: 41699 RVA: 0x01283A50 File Offset: 0x01281C50
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void createActor(string nType, int nTeam, Vector3 nPos, Vector3 nDir)
	{
		if (200912 - 395769 != -194857)
		{
		}
		for (;;)
		{
			if (Game.mGameState > eGameState.AllHold)
			{
				if (197253 - 344950 == -147697)
				{
					break;
				}
			}
			else
			{
				Hashtable hashtable = new Hashtable();
				if (252643 - 551640 == -298997)
				{
					hashtable.Add(43, PlayerData.UID);
					if (182156 - 587955 != -405798)
					{
						hashtable.Add(73, nType);
						if (94292 - 178713 == -84421)
						{
							hashtable.Add(75, PhotonClient.cInt16(nTeam));
							if (138614 - 348944 != -210329)
							{
								hashtable.Add(122, PhotonClient.cInt16(Mathf.RoundToInt(nPos.x * (float)50)));
								if (45932 - 54704 == -8772)
								{
									hashtable.Add(123, PhotonClient.cInt16(Mathf.RoundToInt(nPos.y * (float)50)));
									if (86052 - 597609 == -511557)
									{
										hashtable.Add(124, PhotonClient.cInt16(Mathf.RoundToInt(nPos.z * (float)50)));
										if (164835 - 430708 != -265872)
										{
											hashtable.Add(126, PhotonClient.cInt16(Mathf.RoundToInt(nDir.x * (float)200)));
											if (252076 - 69040 == 183036)
											{
												hashtable.Add(127, PhotonClient.cInt16(Mathf.RoundToInt(nDir.y * (float)200)));
												if (11672 - 22184 == -10512)
												{
													hashtable.Add(128, PhotonClient.cInt16(Mathf.RoundToInt(nDir.z * (float)200)));
													if (123817 - 486507 == -362690)
													{
														this.agvn65pagAF.OpCustom(63, hashtable, true);
														if (135680 - 206364 != -70683)
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

	// Token: 0x0600A2E4 RID: 41700 RVA: 0x01283D34 File Offset: 0x01281F34
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onCreateActor(Hashtable data)
	{
		if (163431 - 17004 != 146427)
		{
		}
		for (;;)
		{
			if (Game.mGameState > eGameState.AllHold)
			{
				if (116928 - 209004 == -92076)
				{
					break;
				}
			}
			else
			{
				GameObject gameObject = Game.createActor(data);
				if (193708 - 593340 != -399631)
				{
					if (Game.mGameState == eGameState.Setup)
					{
						if (2183 - 461345 == -459162)
						{
							if (this.GEfn66NlolX <= 0)
							{
								break;
							}
							if (158164 - 259268 != -101103)
							{
								this.GEfn66NlolX--;
								if (262202 - 536063 != -273860)
								{
									if (this.GEfn66NlolX != 0)
									{
										break;
									}
									if (159279 - 411725 != -252445)
									{
										Game.setGameState(eGameState.Ready);
										if (216071 - 242183 == -26112)
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
						if (164036 - 145797 == 18239)
						{
							gameObject.SendMessage("createSpecialEffect", 1);
							if (214862 - 560430 == -345568)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x0600A2E5 RID: 41701 RVA: 0x01283EC4 File Offset: 0x012820C4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onActorKo(GameObject nActor)
	{
		if (Game.mGameState > eGameState.AllHold)
		{
		}
	}

	// Token: 0x0600A2E6 RID: 41702 RVA: 0x01283ED8 File Offset: 0x012820D8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onActorDead(GameObject nActor)
	{
		if (85732 - 248945 != -163213)
		{
		}
		for (;;)
		{
			if (Game.mGameState > eGameState.AllHold)
			{
				if (88690 - 167197 == -78507)
				{
					break;
				}
			}
			else
			{
				CharacterControl characterControl = (CharacterControl)nActor.GetComponent(typeof(CharacterControl));
				if (216625 - 313847 == -97222)
				{
					if (!characterControl)
					{
						break;
					}
					if (38186 - 180604 != -142417)
					{
						if (characterControl.isTransform)
						{
							break;
						}
						if (93156 - 453581 == -360425)
						{
							if (characterControl.isSummon)
							{
								break;
							}
							if (44742 - 361362 == -316620)
							{
								string type = characterControl.Type;
								if (164347 - 513236 != -348888)
								{
									if (!(type == "FoulElement"))
									{
										break;
									}
									if (130247 - 46811 != 83437)
									{
										Game.sendMissionEvent(9353, 1);
										if (143867 - 118191 != 25677)
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

	// Token: 0x0600A2E7 RID: 41703 RVA: 0x01284050 File Offset: 0x01282250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void CreatePlayer(int CID, int team, Vector3 pos, Vector3 dir)
	{
		if (139229 - 347871 != -208642)
		{
		}
		for (;;)
		{
			Hashtable hashtable = new Hashtable();
			if (255809 - 499300 == -243491)
			{
				hashtable.Add(71, CID);
				if (115575 - 556261 != -440685)
				{
					hashtable.Add(75, PhotonClient.cInt16(team));
					if (264231 - 293293 != -29061)
					{
						hashtable.Add(122, PhotonClient.cInt16(Mathf.RoundToInt(pos.x * (float)50)));
						if (247055 - 530757 != -283701)
						{
							hashtable.Add(123, PhotonClient.cInt16(Mathf.RoundToInt(pos.y * (float)50)));
							if (194666 - 535969 == -341303)
							{
								hashtable.Add(124, PhotonClient.cInt16(Mathf.RoundToInt(pos.z * (float)50)));
								if (59015 - 281321 == -222306)
								{
									hashtable.Add(126, PhotonClient.cInt16(Mathf.RoundToInt(dir.x * (float)200)));
									if (229911 - 53424 == 176487)
									{
										hashtable.Add(127, PhotonClient.cInt16(Mathf.RoundToInt(dir.y * (float)200)));
										if (84017 - 11297 != 72721)
										{
											hashtable.Add(128, PhotonClient.cInt16(Mathf.RoundToInt(dir.z * (float)200)));
											if (120631 - 408801 != -288169)
											{
												this.agvn65pagAF.OpCustom(61, hashtable, true);
												if (222962 - 211918 != 11045)
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

	// Token: 0x0600A2E8 RID: 41704 RVA: 0x012842DC File Offset: 0x012824DC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onCreatePlayer(Hashtable data)
	{
		if (265318 - 28469 != 236849)
		{
		}
		for (;;)
		{
			GameObject gameObject = Game.createPlayer(data);
			if (66491 - 534810 != -468318)
			{
				if (!gameObject)
				{
					break;
				}
				if (6937 - 504013 == -497076)
				{
					PlayerCameraControl playerCameraControl = (PlayerCameraControl)this.GetComponent(typeof(PlayerCameraControl));
					if (89947 - 51077 != 38871)
					{
						playerCameraControl.target = gameObject;
						if (125322 - 106480 == 18842)
						{
							if (Game.mGameState < eGameState.Start)
							{
								if (221067 - 223775 != -2707)
								{
									this.StartGame();
									if (160602 - 43769 != 116834)
									{
										break;
									}
								}
							}
							else
							{
								this.onRevivePlayer();
								if (22162 - 589492 == -567330)
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

	// Token: 0x0600A2E9 RID: 41705 RVA: 0x01284418 File Offset: 0x01282618
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onCreatePeer(Hashtable data)
	{
		if (84971 - 277440 != -192468)
		{
		}
		for (;;)
		{
			Game.createPeer(data);
			if (136244 - 108705 == 27539)
			{
				GameGui gameGui = (GameGui)this.GetComponent(typeof(GameGui));
				if (222898 - 493296 == -270398)
				{
					gameGui.ResetTeamBar();
					if (23731 - 29925 == -6194)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x0600A2EA RID: 41706 RVA: 0x012844C4 File Offset: 0x012826C4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator onDeadPlayer()
	{
		return new M935_TormentWoods1.$onDeadPlayer$43758(this).GetEnumerator();
	}

	// Token: 0x0600A2EB RID: 41707 RVA: 0x012844D4 File Offset: 0x012826D4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onRevivePlayer()
	{
		if (137761 - 168131 != -30370)
		{
		}
		for (;;)
		{
			Debug.Log("On Revive Player");
			if (22358 - 46951 == -24593)
			{
				this.T89n6cdMmg8.target = Game.mPlayer;
				if (212281 - 10386 == 201895)
				{
					this.T89n6cdMmg8.enabled = true;
					if (149887 - 541809 != -391921)
					{
						if (Game.mGameState != eGameState.Normal)
						{
							if (162423 - 484635 != -322212)
							{
								continue;
							}
							if (Game.mGameState != eGameState.Hold)
							{
								break;
							}
							if (185698 - 513999 == -328300)
							{
								continue;
							}
						}
						Game.mGameState = eGameState.Normal;
						if (126081 - 166478 != -40396)
						{
							GameGui gameGui = (GameGui)this.GetComponent(typeof(GameGui));
							if (100977 - 326197 == -225220)
							{
								if (!gameGui)
								{
									break;
								}
								if (241865 - 487048 == -245183)
								{
									gameGui.enabled = true;
									if (10582 - 535387 != -524804)
									{
										gameGui.closeDeadMenu();
										if (129539 - 209010 != -79470)
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

	// Token: 0x0600A2EC RID: 41708 RVA: 0x01284680 File Offset: 0x01282880
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onPlayerRelease(GameObject mPlayer)
	{
		if (221417 - 565850 != -344432)
		{
		}
		for (;;)
		{
			Debug.Log("On Release Spirit");
			if (123856 - 220478 != -96621)
			{
				PlayerData.MissionWithdraw[MissionData.getMissionNumber(Game.mGameCode) - 1] = PlayerData.MissionWithdraw[MissionData.getMissionNumber(Game.mGameCode) - 1] + 1;
				if (80446 - 399023 == -318577)
				{
					this.StartCoroutine_Auto(this.ReturnToTown());
					if (63312 - 220795 != -157482)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x0600A2ED RID: 41709 RVA: 0x01284744 File Offset: 0x01282944
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onDestroyPlayer(Hashtable data)
	{
		if (RuntimeServices.EqualityOperator(data[81], PlayerData.UID))
		{
			Game.mGameState = eGameState.Ended;
		}
	}

	// Token: 0x0600A2EE RID: 41710 RVA: 0x01284770 File Offset: 0x01282970
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void ChangePlayer(int nCID)
	{
		if (201532 - 166507 != 35026)
		{
		}
		for (;;)
		{
			int v = Game.mPlayer.layer - 7;
			if (282128 - 337666 != -55537)
			{
				Vector3 position = Game.mPlayer.transform.position;
				if (136532 - 313404 == -176872)
				{
					Vector3 forward = Game.mPlayer.transform.forward;
					if (66621 - 159171 == -92550)
					{
						Hashtable hashtable = new Hashtable();
						if (264785 - 55982 != 208804)
						{
							hashtable.Add(43, PlayerData.UID);
							if (84609 - 118706 != -34096)
							{
								hashtable.Add(71, nCID);
								if (197685 - 290283 != -92597)
								{
									hashtable.Add(75, PhotonClient.cInt16(v));
									if (212816 - 350838 != -138021)
									{
										hashtable.Add(122, PhotonClient.cInt16(Mathf.RoundToInt(position.x * (float)50)));
										if (297080 - 361811 != -64730)
										{
											hashtable.Add(123, PhotonClient.cInt16(Mathf.RoundToInt(position.y * (float)50)));
											if (21538 - 599661 == -578123)
											{
												hashtable.Add(124, PhotonClient.cInt16(Mathf.RoundToInt(position.z * (float)50)));
												if (53793 - 127641 == -73848)
												{
													hashtable.Add(126, PhotonClient.cInt16(Mathf.RoundToInt(forward.x * (float)200)));
													if (21522 - 13070 != 8453)
													{
														hashtable.Add(127, PhotonClient.cInt16(Mathf.RoundToInt(forward.y * (float)200)));
														if (44846 - 509736 == -464890)
														{
															hashtable.Add(128, PhotonClient.cInt16(Mathf.RoundToInt(forward.z * (float)200)));
															if (212434 - 423812 != -211377)
															{
																PhotonClient.Connection.OpCustom(65, hashtable, true);
																if (284024 - 297456 == -13432)
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

	// Token: 0x0600A2EF RID: 41711 RVA: 0x01284A90 File Offset: 0x01282C90
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator onChangePlayer(Hashtable data)
	{
		return new M935_TormentWoods1.$onChangePlayer$43764(data, this).GetEnumerator();
	}

	// Token: 0x0600A2F0 RID: 41712 RVA: 0x01284AA0 File Offset: 0x01282CA0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void InitGame()
	{
		if (184037 - 379080 != -195043)
		{
		}
		for (;;)
		{
			Debug.Log("Initializing Mission");
			if (61075 - 572590 != -511514)
			{
				Time.timeScale = 1f;
				if (294378 - 147988 == 146390)
				{
					Hashtable customOpParameters = new Hashtable();
					if (68606 - 229152 == -160546)
					{
						this.agvn65pagAF.OpCustom(52, customOpParameters, true);
						if (217513 - 514609 != -297095)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x0600A2F1 RID: 41713 RVA: 0x01284B6C File Offset: 0x01282D6C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onInitGame(Hashtable data)
	{
		if (154761 - 585103 != -430342)
		{
		}
		for (;;)
		{
			Debug.Log("Loading data...");
			if (53932 - 100551 == -46619)
			{
				if (Game.mGameState >= eGameState.Setup)
				{
					break;
				}
				if (195449 - 393619 == -198170)
				{
					Game.mGameState = eGameState.Setup;
					if (277218 - 33230 == 243988)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x0600A2F2 RID: 41714 RVA: 0x01284C10 File Offset: 0x01282E10
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onGameSetup(Hashtable data)
	{
		if (129129 - 460469 != -331339)
		{
		}
		for (;;)
		{
			int num = RuntimeServices.UnboxInt32(data[43]);
			if (273060 - 2158 != 270903)
			{
				if (num == PlayerData.UID)
				{
					if (279605 - 42187 != 237419)
					{
						this.SetupActors();
						if (88811 - 232523 != -143711)
						{
							break;
						}
					}
				}
				else
				{
					this.ClearActors();
					if (238744 - 468952 == -230208)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x0600A2F3 RID: 41715 RVA: 0x01284CE0 File Offset: 0x01282EE0
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void SetupActors()
	{
		if (154376 - 8804 != 145573)
		{
		}
		for (;;)
		{
			IL_10A:
			Debug.Log("Creating Actors");
			if (15357 - 259138 != -243780)
			{
				CharacterControl[] array = (CharacterControl[])UnityEngine.Object.FindObjectsOfType(typeof(CharacterControl));
				if (287719 - 108159 != 179561)
				{
					if (Extensions.get_length(array) > 0)
					{
						if (256032 - 11663 == 244369)
						{
							int i = 0;
							if (245510 - 493120 != -247609)
							{
								CharacterControl[] array2 = array;
								if (123987 - 443408 != -319420)
								{
									int length = array2.Length;
									if (134582 - 263992 != -129409)
									{
										while (i < length)
										{
											if (!array2[i].isChild)
											{
												if (69817 - 322009 != -252192)
												{
													goto IL_10A;
												}
												string type = array2[i].Type;
												if (178326 - 142313 != 36013)
												{
													goto IL_10A;
												}
												if (type == "FoulElement")
												{
													if (163285 - 271602 != -108317)
													{
														goto IL_10A;
													}
													this.createActor(array2[i].Type, array2[i].gameObject.layer - 7, array2[i].transform.position, array2[i].transform.forward);
													if (283521 - 470348 != -186827)
													{
														goto IL_10A;
													}
												}
												UnityEngine.Object.Destroy(array2[i].gameObject);
												if (242132 - 441019 != -198887)
												{
													goto IL_10A;
												}
												this.GEfn66NlolX++;
												if (4187 - 131322 == -127134)
												{
													goto IL_10A;
												}
											}
											i++;
											if (87846 - 522045 != -434199)
											{
												goto IL_10A;
											}
										}
										if (178752 - 227666 == -48914)
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
						if (63001 - 538094 != -475092)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x0600A2F4 RID: 41716 RVA: 0x01284F7C File Offset: 0x0128317C
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ClearActors()
	{
		if (126291 - 305106 != -178815)
		{
		}
		for (;;)
		{
			IL_76:
			CharacterControl[] array = (CharacterControl[])UnityEngine.Object.FindObjectsOfType(typeof(CharacterControl));
			if (179864 - 501408 != -321543)
			{
				int i = 0;
				if (202586 - 500548 != -297961)
				{
					CharacterControl[] array2 = array;
					if (276076 - 433755 != -157678)
					{
						int length = array2.Length;
						if (298594 - 438273 == -139679)
						{
							while (i < length)
							{
								UnityEngine.Object.Destroy(array2[i].gameObject);
								if (9617 - 338029 != -328412)
								{
									goto IL_76;
								}
								i++;
								if (37748 - 333409 != -295661)
								{
									goto IL_76;
								}
							}
							if (194177 - 125565 == 68612)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x0600A2F5 RID: 41717 RVA: 0x012850AC File Offset: 0x012832AC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void StartGame()
	{
		if (160623 - 287491 != -126868)
		{
		}
		for (;;)
		{
			Debug.Log("Start Game");
			if (124304 - 234705 != -110400)
			{
				Game.mGameState = eGameState.Start;
				if (253333 - 92252 != 161082)
				{
					Game.mGameTime = Time.time;
					if (97508 - 540063 != -442554)
					{
						Game.mStateTime = Time.time;
						if (72985 - 460298 != -387312)
						{
							this.StartCoroutine_Auto(this.StartEvent());
							if (136517 - 275358 != -138840)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x0600A2F6 RID: 41718 RVA: 0x01285198 File Offset: 0x01283398
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onStartGame()
	{
	}

	// Token: 0x0600A2F7 RID: 41719 RVA: 0x0128519C File Offset: 0x0128339C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator onGameComplete(Hashtable data)
	{
		return new M935_TormentWoods1.$onGameComplete$43771(data, this).GetEnumerator();
	}

	// Token: 0x0600A2F8 RID: 41720 RVA: 0x012851AC File Offset: 0x012833AC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator ReturnToTown()
	{
		return new M935_TormentWoods1.$ReturnToTown$43781(this).GetEnumerator();
	}

	// Token: 0x0600A2F9 RID: 41721 RVA: 0x012851BC File Offset: 0x012833BC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator ReturnToGuild()
	{
		return new M935_TormentWoods1.$ReturnToGuild$43786(this).GetEnumerator();
	}

	// Token: 0x0600A2FA RID: 41722 RVA: 0x012851CC File Offset: 0x012833CC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator ReturnToCamp()
	{
		return new M935_TormentWoods1.$ReturnToCamp$43790(this).GetEnumerator();
	}

	// Token: 0x0600A2FB RID: 41723 RVA: 0x012851DC File Offset: 0x012833DC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void LeaveGame()
	{
		if (276444 - 74311 != 202133)
		{
		}
		for (;;)
		{
			Debug.Log("leaving guild");
			if (7447 - 516854 == -509407)
			{
				Hashtable hashtable = new Hashtable();
				if (46594 - 579417 != -532822)
				{
					hashtable.Add(43, PlayerData.UID);
					if (129579 - 222623 != -93043)
					{
						PhotonClient.Connection.OpCustom(54, hashtable, true);
						if (174597 - 231789 != -57191)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x0600A2FC RID: 41724 RVA: 0x012852B4 File Offset: 0x012834B4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onLeaveGame()
	{
		Debug.Log("onLeaveGame");
		this.JoinTown();
	}

	// Token: 0x0600A2FD RID: 41725 RVA: 0x012852C8 File Offset: 0x012834C8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void JoinTown()
	{
		if (102457 - 82200 != 20258)
		{
		}
		for (;;)
		{
			Debug.Log("Joining Town");
			if (119343 - 155628 != -36284)
			{
				Hashtable hashtable = new Hashtable();
				if (272949 - 137983 == 134966)
				{
					if (Game.mNextGameCode == 30)
					{
						if (140876 - 459783 == -318906)
						{
							continue;
						}
						hashtable.Add(47, "NoGuild");
						if (273427 - 89269 == 184159)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 31)
					{
						if (143822 - 26140 != 117682)
						{
							continue;
						}
						hashtable.Add(47, "G" + GuildData.Name);
						if (146066 - 494295 != -348229)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 32)
					{
						if (210806 - 546243 != -335437)
						{
							continue;
						}
						hashtable.Add(47, "SnowCamp");
						if (284705 - 215036 == 69670)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 33)
					{
						if (192377 - 454600 == -262222)
						{
							continue;
						}
						hashtable.Add(47, "CrystalBeach");
						if (250077 - 142353 == 107725)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 34)
					{
						if (248962 - 118049 == 130914)
						{
							continue;
						}
						hashtable.Add(47, "ExcavationCamp");
						if (91089 - 31923 != 59166)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 35)
					{
						if (94664 - 477920 != -383256)
						{
							continue;
						}
						hashtable.Add(47, "UndergroundCamp");
						if (78079 - 105478 == -27398)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 36)
					{
						if (5928 - 158253 != -152325)
						{
							continue;
						}
						hashtable.Add(47, "ForestCamp");
						if (134146 - 33598 == 100549)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 51)
					{
						if (189534 - 47460 == 142075)
						{
							continue;
						}
						hashtable.Add(47, "MainStreet");
						if (227304 - 309387 != -82083)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 52)
					{
						if (225301 - 436969 == -211667)
						{
							continue;
						}
						hashtable.Add(47, "CentralSquare");
						if (45213 - 544072 == -498858)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 53)
					{
						if (129997 - 527039 != -397042)
						{
							continue;
						}
						hashtable.Add(47, "CityLibrary");
						if (11396 - 47975 == -36578)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 54)
					{
						if (227586 - 17840 == 209747)
						{
							continue;
						}
						hashtable.Add(47, "LightPark");
						if (114720 - 27573 != 87147)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 55)
					{
						if (244987 - 352381 != -107394)
						{
							continue;
						}
						hashtable.Add(47, "LightPalace");
						if (228933 - 226323 != 2610)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 56)
					{
						if (291704 - 529508 == -237803)
						{
							continue;
						}
						hashtable.Add(47, "PlainColosseum");
						if (240509 - 245359 == -4849)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 57)
					{
						if (87302 - 240928 != -153626)
						{
							continue;
						}
						hashtable.Add(47, "LightTheater");
						if (54332 - 370641 == -316308)
						{
							continue;
						}
					}
					hashtable.Add(21, PhotonClient.cInt16(Mathf.Clamp(PlayerPrefs.GetInt("channel", 0), 0, 99)));
					if (112353 - 356428 == -244075)
					{
						this.agvn65pagAF.OpCustom(42, hashtable, true);
						if (225001 - 228679 != -3677)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x0600A2FE RID: 41726 RVA: 0x0128587C File Offset: 0x01283A7C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onJoinTown()
	{
		Game.mGameStage = 0;
		Game.loadNextLevel();
	}

	// Token: 0x0600A2FF RID: 41727 RVA: 0x0128588C File Offset: 0x01283A8C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x0600A300 RID: 41728 RVA: 0x01285890 File Offset: 0x01283A90
	internal static bool o9qJVrVd5AOKSgoknuoS()
	{
		return true;
	}

	// Token: 0x0600A301 RID: 41729 RVA: 0x01285894 File Offset: 0x01283A94
	internal static bool aatG2rVdpTocuxvdjVdX()
	{
		return false;
	}

	// Token: 0x040092C9 RID: 37577
	private LitePeer agvn65pagAF;

	// Token: 0x040092CA RID: 37578
	private PlayerCameraControl T89n6cdMmg8;

	// Token: 0x040092CB RID: 37579
	private float KW8n6nccKPI;

	// Token: 0x040092CC RID: 37580
	private Texture iJSn6QflJFf;

	// Token: 0x040092CD RID: 37581
	private AudioClip eEwn6eYUXfw;

	// Token: 0x040092CE RID: 37582
	private int NsSn6Ipwtho;

	// Token: 0x040092CF RID: 37583
	private int vIPn6J0ZL23;

	// Token: 0x040092D0 RID: 37584
	private int GEfn66NlolX;

	// Token: 0x02001B41 RID: 6977
	[CompilerGenerated]
	[Serializable]
	internal sealed class $onGameEvent$43741 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600A302 RID: 41730 RVA: 0x01285898 File Offset: 0x01283A98
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $onGameEvent$43741(Hashtable data, M935_TormentWoods1 self_)
		{
			if (247668 - 50099 != 197569)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (60961 - 90141 == -29180)
				{
					base..ctor();
					if (121806 - 287753 != -165946)
					{
						this.$data$43750 = data;
						if (253858 - 134019 == 119839)
						{
							this.$self_$43751 = self_;
							if (211995 - 257554 != -45558)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x0600A303 RID: 41731 RVA: 0x01285954 File Offset: 0x01283B54
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M935_TormentWoods1.$onGameEvent$43741.$(this.$data$43750, this.$self_$43751);
		}

		// Token: 0x0600A304 RID: 41732 RVA: 0x01285968 File Offset: 0x01283B68
		internal static bool InBWSuVdVEbxgwqOF7WE()
		{
			return true;
		}

		// Token: 0x0600A305 RID: 41733 RVA: 0x0128596C File Offset: 0x01283B6C
		internal static bool AXWbaCVdtVd718s1uXq5()
		{
			return false;
		}

		// Token: 0x040092D1 RID: 37585
		internal Hashtable $data$43750;

		// Token: 0x040092D2 RID: 37586
		internal M935_TormentWoods1 $self_$43751;

		// Token: 0x02001B42 RID: 6978
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600A306 RID: 41734 RVA: 0x01285970 File Offset: 0x01283B70
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Hashtable data, M935_TormentWoods1 self_)
			{
				if (68722 - 142080 != -73357)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (152439 - 370061 != -217621)
					{
						base..ctor();
						if (33360 - 132871 != -99510)
						{
							this.$data$43748 = data;
							if (244830 - 264280 == -19450)
							{
								this.$self_$43749 = self_;
								if (74797 - 335262 == -260465)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x0600A307 RID: 41735 RVA: 0x01285A2C File Offset: 0x01283C2C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (134198 - 321255 != -187057)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						goto IL_2C5;
					case 1:
						goto IL_571;
					case 2:
						Game.savePlayer();
						if (117399 - 502874 == -385474)
						{
							continue;
						}
						this.$self_$43749.SendMessage("fadeOut");
						if (128242 - 288372 != -160129)
						{
							goto Block_16;
						}
						continue;
					case 3:
						Game.mGameStage = 2;
						if (49317 - 114930 != -65613)
						{
							continue;
						}
						Application.LoadLevel("M935_TormentWoods2");
						if (206967 - 126593 == 80375)
						{
							continue;
						}
						break;
					default:
						if (188547 - 570056 != -381509)
						{
							continue;
						}
						goto IL_2C5;
					}
					IL_15C:
					this.YieldDefault(1);
					if (138339 - 16353 != 121987)
					{
						break;
					}
					continue;
					IL_221:
					goto IL_15C;
					IL_2C5:
					if (Game.mGameState > eGameState.AllHold)
					{
						if (64913 - 415277 == -350364)
						{
							break;
						}
					}
					else
					{
						this.$returnCode$43742 = RuntimeServices.UnboxInt32(this.$data$43748[141]);
						if (234289 - 498998 == -264709)
						{
							this.$returnValue$43743 = RuntimeServices.UnboxInt32(this.$data$43748[145]);
							if (67534 - 351393 != -283858)
							{
								this.$ownerID$43744 = RuntimeServices.UnboxInt32(this.$data$43748[43]);
								if (113998 - 189603 != -75604)
								{
									this.$$switch$8035$43745 = this.$returnCode$43742;
									if (15577 - 203803 == -188226)
									{
										if (this.$$switch$8035$43745 == 9351)
										{
											if (41045 - 276761 != -235715)
											{
												goto IL_15C;
											}
										}
										else if (this.$$switch$8035$43745 == -9351)
										{
											if (255242 - 469936 == -214694)
											{
												if (this.$returnValue$43743 != 2)
												{
													goto IL_221;
												}
												if (16426 - 380717 != -364290)
												{
													if (this.$self_$43749.NsSn6Ipwtho >= 2)
													{
														goto IL_221;
													}
													if (29807 - 123361 != -93553)
													{
														this.$self_$43749.NsSn6Ipwtho = 2;
														if (208774 - 489407 != -280632)
														{
															Game.mGameState = eGameState.AllHold;
															if (197635 - 90495 == 107140)
															{
																this.$self_$43749.T89n6cdMmg8.StartCoroutine_Auto(this.$self_$43749.T89n6cdMmg8.slerpToObject("ExitCamera1", (float)2));
																if (44961 - 449134 != -404172)
																{
																	this.$mGameGui$43746 = (GameGui)this.$self_$43749.GetComponent(typeof(GameGui));
																	if (148545 - 396299 != -247753)
																	{
																		this.$mGameGui$43746.close();
																		if (89794 - 81404 != 8391)
																		{
																			goto Block_31;
																		}
																	}
																}
															}
														}
													}
												}
											}
										}
										else if (this.$$switch$8035$43745 == 9353)
										{
											if (49333 - 297984 != -248650)
											{
												this.$$switch$8033$43747 = this.$returnValue$43743;
												if (99364 - 427978 != -328613)
												{
													if (this.$$switch$8033$43747 == 1)
													{
														if (266650 - 537225 != -270575)
														{
															continue;
														}
														this.$self_$43749.vIPn6J0ZL23 = this.$self_$43749.vIPn6J0ZL23 + 1;
														if (280296 - 207773 != 72523)
														{
															continue;
														}
														Debug.Log("mFoulElementCount:" + this.$self_$43749.vIPn6J0ZL23);
														if (32544 - 320345 == -287800)
														{
															continue;
														}
														this.$self_$43749.SendMessage("newGameMessage", "Mission Objective: FoulElement Eliminated:" + this.$self_$43749.vIPn6J0ZL23 + "/2");
														if (65331 - 17964 != 47367)
														{
															continue;
														}
														Chat.SubmitChat("none", "FoulElement Eliminated:" + this.$self_$43749.vIPn6J0ZL23 + "/2", eChatType.system, eChatMode.system);
														if (251196 - 72427 != 178769)
														{
															continue;
														}
													}
													goto IL_15C;
												}
											}
										}
										else
										{
											Debug.LogError("Warning unknown returnCode:" + this.$returnCode$43742);
											if (104320 - 206377 != -102056)
											{
												goto IL_15C;
											}
										}
									}
								}
							}
						}
					}
				}
				goto IL_571;
				Block_16:
				return this.Yield(3, new WaitForSeconds((float)1));
				goto IL_571;
				Block_31:
				return this.Yield(2, new WaitForSeconds((float)2));
				IL_571:
				return false;
			}

			// Token: 0x0600A308 RID: 41736 RVA: 0x01285FBC File Offset: 0x012841BC
			internal static bool PLcTItVdNGsQe7cBFe7j()
			{
				return true;
			}

			// Token: 0x0600A309 RID: 41737 RVA: 0x01285FC0 File Offset: 0x012841C0
			internal static bool J13AAiVdYiqqFHssLR1L()
			{
				return false;
			}

			// Token: 0x040092D3 RID: 37587
			internal int $returnCode$43742;

			// Token: 0x040092D4 RID: 37588
			internal int $returnValue$43743;

			// Token: 0x040092D5 RID: 37589
			internal int $ownerID$43744;

			// Token: 0x040092D6 RID: 37590
			internal int $$switch$8035$43745;

			// Token: 0x040092D7 RID: 37591
			internal GameGui $mGameGui$43746;

			// Token: 0x040092D8 RID: 37592
			internal int $$switch$8033$43747;

			// Token: 0x040092D9 RID: 37593
			internal Hashtable $data$43748;

			// Token: 0x040092DA RID: 37594
			internal M935_TormentWoods1 $self_$43749;
		}
	}

	// Token: 0x02001B43 RID: 6979
	[CompilerGenerated]
	[Serializable]
	internal sealed class $StartEvent$43752 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600A30A RID: 41738 RVA: 0x01285FC4 File Offset: 0x012841C4
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $StartEvent$43752(M935_TormentWoods1 self_)
		{
			if (212083 - 213870 != -1786)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (125054 - 30174 == 94880)
				{
					base..ctor();
					if (149990 - 389955 != -239964)
					{
						this.$self_$43757 = self_;
						if (121152 - 546147 != -424994)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x0600A30B RID: 41739 RVA: 0x0128605C File Offset: 0x0128425C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M935_TormentWoods1.$StartEvent$43752.$(this.$self_$43757);
		}

		// Token: 0x0600A30C RID: 41740 RVA: 0x0128606C File Offset: 0x0128426C
		internal static bool qq8URsVdcgIGdb0pDbWR()
		{
			return true;
		}

		// Token: 0x0600A30D RID: 41741 RVA: 0x01286070 File Offset: 0x01284270
		internal static bool XmyXQZVdUYFNNxKKOkUA()
		{
			return false;
		}

		// Token: 0x040092DB RID: 37595
		internal M935_TormentWoods1 $self_$43757;

		// Token: 0x02001B44 RID: 6980
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600A30E RID: 41742 RVA: 0x01286074 File Offset: 0x01284274
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M935_TormentWoods1 self_)
			{
				if (73027 - 418620 != -345592)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (243992 - 242481 != 1512)
					{
						base..ctor();
						if (113504 - 58427 != 55078)
						{
							this.$self_$43756 = self_;
							if (96242 - 546325 == -450083)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x0600A30F RID: 41743 RVA: 0x0128610C File Offset: 0x0128430C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (163203 - 448945 != -285741)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_87F;
					case 2:
						if (Game.mGameState != eGameState.Start)
						{
							if (104367 - 444917 != -340549)
							{
								goto Block_21;
							}
							continue;
						}
						else
						{
							this.$mStoryGui$43753 = (StoryGui)this.$self_$43756.GetComponent(typeof(StoryGui));
							if (161076 - 402359 != -241283)
							{
								continue;
							}
							this.$mStoryTimer$43754 = 0f;
							if (181736 - 334295 != -152559)
							{
								continue;
							}
							if (!this.$mStoryGui$43753)
							{
								if (162335 - 432651 != -270315)
								{
									goto Block_17;
								}
								continue;
							}
							else
							{
								this.$mStoryGui$43753.startStoryMessage("RedPanda", "RedPanda", eTalkType.friend);
								if (24007 - 398267 != -374259)
								{
									goto Block_55;
								}
								continue;
							}
						}
						break;
					case 3:
						if (Game.mGameState != eGameState.Start)
						{
							if (224412 - 186749 != 37663)
							{
								continue;
							}
							goto IL_7D0;
						}
						else
						{
							this.$mStoryGui$43753.newStoryMessage("RedPanda", "RedPanda", Language.getMessage("M935_TormentWoods", 101), eTalkType.friend);
							if (153044 - 451510 != -298466)
							{
								continue;
							}
							this.$mStoryTimer$43754 = Time.time + 3.5f;
							if (23536 - 222227 != -198691)
							{
								continue;
							}
							goto IL_161;
						}
						break;
					case 4:
						goto IL_188;
					case 5:
						goto IL_188;
					case 6:
						goto IL_137;
					case 7:
						goto IL_137;
					case 8:
						goto IL_2BA;
					case 9:
						goto IL_2BA;
					case 10:
						goto IL_6EB;
					case 11:
						goto IL_6EB;
					case 12:
						if (Game.mGameState != eGameState.Start)
						{
							if (116135 - 180089 != -63954)
							{
								continue;
							}
							goto IL_1F4;
						}
						else
						{
							this.$mGameGui$43755 = (GameGui)this.$self_$43756.GetComponent(typeof(GameGui));
							if (222498 - 33507 == 188992)
							{
								continue;
							}
							this.$mGameGui$43755.enabled = true;
							if (164913 - 512218 != -347305)
							{
								continue;
							}
							Game.mGameState = eGameState.Normal;
							if (109068 - 70426 != 38642)
							{
								continue;
							}
							Game.mStateTime = Time.time;
							if (112583 - 411047 != -298464)
							{
								continue;
							}
							if (this.$self_$43756.eEwn6eYUXfw)
							{
								if (238897 - 139790 != 99107)
								{
									continue;
								}
								this.$self_$43756.audio.PlayOneShot(this.$self_$43756.eEwn6eYUXfw);
								if (127646 - 284125 != -156479)
								{
									continue;
								}
							}
							this.YieldDefault(1);
							if (33763 - 55854 != -22090)
							{
								goto Block_49;
							}
							continue;
						}
						break;
					default:
						if (231529 - 257617 == -26087)
						{
							continue;
						}
						break;
					}
					Game.mGameState = eGameState.Start;
					if (249297 - 305816 != -56519)
					{
						continue;
					}
					Game.mStateTime = Time.time;
					if (192561 - 410758 != -218197)
					{
						continue;
					}
					this.$self_$43756.T89n6cdMmg8.alignToObject("EventCamera1");
					if (265906 - 470191 != -204285)
					{
						continue;
					}
					this.$self_$43756.SendMessage("fadeIn");
					if (158845 - 84509 != 74337)
					{
						goto Block_47;
					}
					continue;
					IL_2BA:
					if (this.$mStoryTimer$43754 > Time.time)
					{
						if (137868 - 256624 != -118756)
						{
							continue;
						}
						if (!Input.GetKeyDown(KeyCode.Mouse0))
						{
							goto IL_2AD;
						}
						if (106469 - 4364 != 102105)
						{
							continue;
						}
					}
					if (Game.mGameState != eGameState.Start)
					{
						if (110408 - 491645 != -381237)
						{
							continue;
						}
						goto IL_3AF;
					}
					else
					{
						this.$mStoryGui$43753.newStoryMessage("RedPanda", "RedPanda", Language.getMessage("M935_TormentWoods", 104), eTalkType.friend);
						if (233512 - 76018 == 157495)
						{
							continue;
						}
						this.$mStoryTimer$43754 = Time.time + 3f;
						if (147381 - 392444 != -245063)
						{
							continue;
						}
						goto IL_6C2;
					}
					IL_137:
					if (this.$mStoryTimer$43754 > Time.time)
					{
						if (38315 - 173433 == -135117)
						{
							continue;
						}
						if (!Input.GetKeyDown(KeyCode.Mouse0))
						{
							goto IL_12B;
						}
						if (4900 - 423323 == -418422)
						{
							continue;
						}
					}
					if (Game.mGameState != eGameState.Start)
					{
						if (38938 - 203418 != -164479)
						{
							goto Block_38;
						}
						continue;
					}
					else
					{
						this.$mStoryGui$43753.newStoryMessage("RedPanda", "RedPanda", Language.getMessage("M935_TormentWoods", 103), eTalkType.friend);
						if (283206 - 2100 == 281107)
						{
							continue;
						}
						this.$mStoryTimer$43754 = Time.time + 3.5f;
						if (63308 - 366579 != -303270)
						{
							goto Block_34;
						}
						continue;
					}
					IL_188:
					if (this.$mStoryTimer$43754 > Time.time)
					{
						if (171388 - 102732 != 68656)
						{
							continue;
						}
						if (!Input.GetKeyDown(KeyCode.Mouse0))
						{
							goto IL_17C;
						}
						if (168850 - 2670 != 166180)
						{
							continue;
						}
					}
					if (Game.mGameState != eGameState.Start)
					{
						if (286986 - 473984 != -186998)
						{
							continue;
						}
						goto IL_83D;
					}
					else
					{
						this.$mStoryGui$43753.newStoryMessage("RedPanda", "RedPanda", Language.getMessage("M935_TormentWoods", 102), eTalkType.friend);
						if (241940 - 42344 != 199596)
						{
							continue;
						}
						this.$self_$43756.T89n6cdMmg8.StartCoroutine_Auto(this.$self_$43756.T89n6cdMmg8.slerpToObject("EventCamera2", (float)3));
						if (95621 - 138620 == -42998)
						{
							continue;
						}
						this.$mStoryTimer$43754 = Time.time + 3.5f;
						if (297888 - 244369 != 53519)
						{
							continue;
						}
						break;
					}
					IL_6EB:
					if (this.$mStoryTimer$43754 > Time.time)
					{
						if (151942 - 532284 != -380342)
						{
							continue;
						}
						if (!Input.GetKeyDown(KeyCode.Mouse0))
						{
							goto IL_6DE;
						}
						if (25920 - 501537 != -475617)
						{
							continue;
						}
					}
					if (Game.mGameState != eGameState.Start)
					{
						if (11775 - 558451 == -546676)
						{
							goto IL_698;
						}
					}
					else
					{
						this.$mStoryGui$43753.close();
						if (114834 - 21096 == 93738)
						{
							this.$self_$43756.T89n6cdMmg8.enabled = true;
							if (83116 - 505840 == -422724)
							{
								goto IL_794;
							}
						}
					}
				}
				return this.Yield(6, new WaitForSeconds(0.5f));
				IL_12B:
				return this.YieldDefault(7);
				IL_161:
				return this.Yield(4, new WaitForSeconds(0.5f));
				IL_17C:
				return this.YieldDefault(5);
				IL_1F4:
				Block_17:
				goto IL_87F;
				IL_2AD:
				return this.YieldDefault(9);
				Block_21:
				IL_3AF:
				goto IL_87F;
				Block_34:
				return this.Yield(8, new WaitForSeconds(0.5f));
				Block_38:
				goto IL_87F;
				Block_47:
				return this.Yield(2, new WaitForSeconds(2f));
				Block_49:
				IL_698:
				goto IL_87F;
				IL_6C2:
				return this.Yield(10, new WaitForSeconds(0.5f));
				IL_6DE:
				return this.YieldDefault(11);
				Block_55:
				return this.Yield(3, new WaitForSeconds(0.5f));
				IL_794:
				return this.Yield(12, new WaitForSeconds(1f));
				IL_7D0:
				IL_83D:
				IL_87F:
				return false;
			}

			// Token: 0x0600A310 RID: 41744 RVA: 0x012869AC File Offset: 0x01284BAC
			internal static bool Fl1kUxVdTLHgyvt70sZy()
			{
				return true;
			}

			// Token: 0x0600A311 RID: 41745 RVA: 0x012869B0 File Offset: 0x01284BB0
			internal static bool d02K11Vd3h6vflL9gaTg()
			{
				return false;
			}

			// Token: 0x040092DC RID: 37596
			internal StoryGui $mStoryGui$43753;

			// Token: 0x040092DD RID: 37597
			internal float $mStoryTimer$43754;

			// Token: 0x040092DE RID: 37598
			internal GameGui $mGameGui$43755;

			// Token: 0x040092DF RID: 37599
			internal M935_TormentWoods1 $self_$43756;
		}
	}

	// Token: 0x02001B45 RID: 6981
	[CompilerGenerated]
	[Serializable]
	internal sealed class $onDeadPlayer$43758 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600A312 RID: 41746 RVA: 0x012869B4 File Offset: 0x01284BB4
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $onDeadPlayer$43758(M935_TormentWoods1 self_)
		{
			if (244730 - 387385 != -142655)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (267356 - 309687 != -42330)
				{
					base..ctor();
					if (55689 - 557478 != -501788)
					{
						this.$self_$43763 = self_;
						if (207461 - 420890 != -213428)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x0600A313 RID: 41747 RVA: 0x01286A4C File Offset: 0x01284C4C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M935_TormentWoods1.$onDeadPlayer$43758.$(this.$self_$43763);
		}

		// Token: 0x0600A314 RID: 41748 RVA: 0x01286A5C File Offset: 0x01284C5C
		internal static bool ccQ476VdXPWsuyNE7hBS()
		{
			return true;
		}

		// Token: 0x0600A315 RID: 41749 RVA: 0x01286A60 File Offset: 0x01284C60
		internal static bool WVqBnjVdQ5pNQ3FtsCcj()
		{
			return false;
		}

		// Token: 0x040092E0 RID: 37600
		internal M935_TormentWoods1 $self_$43763;

		// Token: 0x02001B46 RID: 6982
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600A316 RID: 41750 RVA: 0x01286A64 File Offset: 0x01284C64
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M935_TormentWoods1 self_)
			{
				if (52072 - 330460 != -278388)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (271275 - 429811 == -158536)
					{
						base..ctor();
						if (233008 - 469495 == -236487)
						{
							this.$self_$43762 = self_;
							if (86387 - 82644 != 3744)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x0600A317 RID: 41751 RVA: 0x01286AFC File Offset: 0x01284CFC
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (194813 - 165584 != 29229)
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
							if (286530 - 422152 == -135621)
							{
								continue;
							}
							if (Game.mGameState != eGameState.Hold)
							{
								goto IL_64;
							}
							if (73821 - 450443 != -376622)
							{
								continue;
							}
						}
						Game.mGameState = eGameState.Hold;
						if (163217 - 150831 != 12386)
						{
							continue;
						}
						this.$mStoryGui$43759 = (StoryGui)this.$self_$43762.GetComponent(typeof(StoryGui));
						if (37720 - 338000 == -300279)
						{
							continue;
						}
						if (this.$mStoryGui$43759)
						{
							if (10983 - 394529 == -383545)
							{
								continue;
							}
							this.$mStoryGui$43759.close();
							if (96872 - 375675 != -278803)
							{
								continue;
							}
						}
						this.$mChangeGui$43760 = (ChangeGui)this.$self_$43762.GetComponent(typeof(ChangeGui));
						if (232016 - 465111 != -233095)
						{
							continue;
						}
						if (this.$mChangeGui$43760)
						{
							if (72132 - 73402 == -1269)
							{
								continue;
							}
							this.$mChangeGui$43760.close();
							if (51770 - 292777 == -241006)
							{
								continue;
							}
						}
						this.$mGameGui$43761 = (GameGui)this.$self_$43762.GetComponent(typeof(GameGui));
						if (98517 - 47712 != 50805)
						{
							continue;
						}
						if (this.$mGameGui$43761)
						{
							if (91912 - 339790 == -247877)
							{
								continue;
							}
							if (!this.$mGameGui$43761.enabled)
							{
								if (232205 - 593381 == -361175)
								{
									continue;
								}
								this.$mGameGui$43761.enabled = true;
								if (93877 - 392952 != -299075)
								{
									continue;
								}
							}
							this.$mGameGui$43761.openDeadMenu();
							if (178880 - 53171 == 125710)
							{
								continue;
							}
						}
						IL_64:
						this.YieldDefault(1);
						if (258471 - 253232 != 5239)
						{
							continue;
						}
						goto IL_2F9;
					default:
						if (265778 - 398032 == -132253)
						{
							continue;
						}
						break;
					}
					Debug.Log("On Dead Player");
				}
				while (167989 - 30853 != 137136);
				return this.Yield(2, new WaitForSeconds((float)2));
				IL_2F9:
				return false;
			}

			// Token: 0x0600A318 RID: 41752 RVA: 0x01286E14 File Offset: 0x01285014
			internal static bool oZxYPjVdkZWfCIb88tDq()
			{
				return true;
			}

			// Token: 0x0600A319 RID: 41753 RVA: 0x01286E18 File Offset: 0x01285018
			internal static bool BXHCjpVdGQSSVOeVyOGB()
			{
				return false;
			}

			// Token: 0x040092E1 RID: 37601
			internal StoryGui $mStoryGui$43759;

			// Token: 0x040092E2 RID: 37602
			internal ChangeGui $mChangeGui$43760;

			// Token: 0x040092E3 RID: 37603
			internal GameGui $mGameGui$43761;

			// Token: 0x040092E4 RID: 37604
			internal M935_TormentWoods1 $self_$43762;
		}
	}

	// Token: 0x02001B47 RID: 6983
	[CompilerGenerated]
	[Serializable]
	internal sealed class $onChangePlayer$43764 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600A31A RID: 41754 RVA: 0x01286E1C File Offset: 0x0128501C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $onChangePlayer$43764(Hashtable data, M935_TormentWoods1 self_)
		{
			if (269298 - 565691 != -296392)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (234278 - 174197 == 60081)
				{
					base..ctor();
					if (294072 - 251323 != 42750)
					{
						this.$data$43769 = data;
						if (91476 - 140654 == -49178)
						{
							this.$self_$43770 = self_;
							if (267371 - 489864 == -222493)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x0600A31B RID: 41755 RVA: 0x01286ED8 File Offset: 0x012850D8
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M935_TormentWoods1.$onChangePlayer$43764.$(this.$data$43769, this.$self_$43770);
		}

		// Token: 0x0600A31C RID: 41756 RVA: 0x01286EEC File Offset: 0x012850EC
		internal static bool Nl3scTVdH7NtQ716FWIe()
		{
			return true;
		}

		// Token: 0x0600A31D RID: 41757 RVA: 0x01286EF0 File Offset: 0x012850F0
		internal static bool vyp1dsVdWs75P97WPWSK()
		{
			return false;
		}

		// Token: 0x040092E5 RID: 37605
		internal Hashtable $data$43769;

		// Token: 0x040092E6 RID: 37606
		internal M935_TormentWoods1 $self_$43770;

		// Token: 0x02001B48 RID: 6984
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600A31E RID: 41758 RVA: 0x01286EF4 File Offset: 0x012850F4
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Hashtable data, M935_TormentWoods1 self_)
			{
				if (28954 - 561701 != -532746)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (162798 - 133302 == 29496)
					{
						base..ctor();
						if (216657 - 254831 == -38174)
						{
							this.$data$43767 = data;
							if (164528 - 132564 != 31965)
							{
								this.$self_$43768 = self_;
								if (164979 - 107923 == 57056)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x0600A31F RID: 41759 RVA: 0x01286FB0 File Offset: 0x012851B0
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (12723 - 19927 != -7204)
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
							if (122855 - 286488 != -163633)
							{
								continue;
							}
							Game.mGameState = eGameState.Normal;
							if (221556 - 238887 != -17331)
							{
								continue;
							}
							this.$mGameGui$43766 = (GameGui)this.$self_$43768.GetComponent(typeof(GameGui));
							if (81350 - 313809 != -232459)
							{
								continue;
							}
							this.$mGameGui$43766.enabled = true;
							if (233086 - 515365 != -282279)
							{
								continue;
							}
						}
						this.YieldDefault(1);
						if (224503 - 176045 != 48459)
						{
							goto Block_6;
						}
						continue;
					default:
						if (253101 - 18526 != 234575)
						{
							continue;
						}
						break;
					}
					UnityEngine.Object.Destroy(Game.mPlayer);
					if (190816 - 382273 != -191456)
					{
						this.$self_$43768.SendMessage("onCreatePlayer", this.$data$43767);
						if (168106 - 333954 == -165848)
						{
							this.$mChangeGui$43765 = (ChangeGui)this.$self_$43768.GetComponent(typeof(ChangeGui));
							if (257091 - 486679 == -229588)
							{
								if (!this.$mChangeGui$43765.enabled)
								{
									break;
								}
								if (71148 - 575885 == -504737)
								{
									this.$mChangeGui$43765.close();
									if (40164 - 402971 != -362806)
									{
										break;
									}
								}
							}
						}
					}
				}
				goto IL_169;
				Block_6:
				goto IL_205;
				IL_169:
				return this.Yield(2, new WaitForSeconds(1f));
				IL_205:
				return false;
			}

			// Token: 0x0600A320 RID: 41760 RVA: 0x012871D4 File Offset: 0x012853D4
			internal static bool zKEy8KVdA4XidyNDoXjG()
			{
				return true;
			}

			// Token: 0x0600A321 RID: 41761 RVA: 0x012871D8 File Offset: 0x012853D8
			internal static bool O9YivUVdlxijc7ZixVw8()
			{
				return false;
			}

			// Token: 0x040092E7 RID: 37607
			internal ChangeGui $mChangeGui$43765;

			// Token: 0x040092E8 RID: 37608
			internal GameGui $mGameGui$43766;

			// Token: 0x040092E9 RID: 37609
			internal Hashtable $data$43767;

			// Token: 0x040092EA RID: 37610
			internal M935_TormentWoods1 $self_$43768;
		}
	}

	// Token: 0x02001B49 RID: 6985
	[CompilerGenerated]
	[Serializable]
	internal sealed class $onGameComplete$43771 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600A322 RID: 41762 RVA: 0x012871DC File Offset: 0x012853DC
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $onGameComplete$43771(Hashtable data, M935_TormentWoods1 self_)
		{
			if (84574 - 276429 != -191854)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (108157 - 170370 == -62213)
				{
					base..ctor();
					if (280777 - 547427 == -266650)
					{
						this.$data$43779 = data;
						if (192607 - 330190 != -137582)
						{
							this.$self_$43780 = self_;
							if (159083 - 598774 == -439691)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x0600A323 RID: 41763 RVA: 0x01287298 File Offset: 0x01285498
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M935_TormentWoods1.$onGameComplete$43771.$(this.$data$43779, this.$self_$43780);
		}

		// Token: 0x0600A324 RID: 41764 RVA: 0x012872AC File Offset: 0x012854AC
		internal static bool Qg0sJqVdyWDr2SCfWq32()
		{
			return true;
		}

		// Token: 0x0600A325 RID: 41765 RVA: 0x012872B0 File Offset: 0x012854B0
		internal static bool R7cXwUVdSBQVWKtoEPtq()
		{
			return false;
		}

		// Token: 0x040092EB RID: 37611
		internal Hashtable $data$43779;

		// Token: 0x040092EC RID: 37612
		internal M935_TormentWoods1 $self_$43780;

		// Token: 0x02001B4A RID: 6986
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600A326 RID: 41766 RVA: 0x012872B4 File Offset: 0x012854B4
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Hashtable data, M935_TormentWoods1 self_)
			{
				if (86862 - 425553 != -338691)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (46183 - 354563 != -308379)
					{
						base..ctor();
						if (172282 - 571865 == -399583)
						{
							this.$data$43777 = data;
							if (6009 - 326084 != -320074)
							{
								this.$self_$43778 = self_;
								if (115257 - 228630 == -113373)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x0600A327 RID: 41767 RVA: 0x01287370 File Offset: 0x01285570
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (211672 - 594874 != -383202)
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
						this.$mCompleteGui$43773 = (CompleteGui)this.$self_$43778.GetComponent(typeof(CompleteGui));
						if (262743 - 186584 == 76160)
						{
							continue;
						}
						this.$mCompleteGui$43773.Init();
						if (47719 - 225094 == -177374)
						{
							continue;
						}
						this.$mCompleteGui$43773.readData(this.$data$43777);
						if (130351 - 305372 != -175021)
						{
							continue;
						}
						if (this.$result$43772 == 1)
						{
							if (56485 - 306303 != -249818)
							{
								continue;
							}
							this.$mCompleteGui$43773.displayResult(eCompleteType.Success);
							if (190052 - 23039 == 167014)
							{
								continue;
							}
						}
						else
						{
							this.$mCompleteGui$43773.displayResult(eCompleteType.Failed);
							if (108099 - 346140 == -238040)
							{
								continue;
							}
						}
						this.$mGameGui$43774 = (GameGui)this.$self_$43778.GetComponent(typeof(GameGui));
						if (150735 - 94714 == 56022)
						{
							continue;
						}
						this.$mStoryGui$43775 = (StoryGui)this.$self_$43778.GetComponent(typeof(StoryGui));
						if (104611 - 516439 != -411828)
						{
							continue;
						}
						this.$mChangeGui$43776 = (ChangeGui)this.$self_$43778.GetComponent(typeof(ChangeGui));
						if (37737 - 221331 != -183594)
						{
							continue;
						}
						if (this.$mGameGui$43774)
						{
							if (136297 - 477054 == -340756)
							{
								continue;
							}
							this.$mGameGui$43774.close();
							if (172638 - 344921 != -172283)
							{
								continue;
							}
						}
						if (this.$mStoryGui$43775)
						{
							if (148431 - 241479 == -93047)
							{
								continue;
							}
							this.$mStoryGui$43775.close();
							if (168187 - 436788 != -268601)
							{
								continue;
							}
						}
						if (this.$mChangeGui$43776)
						{
							if (221100 - 62893 != 158207)
							{
								continue;
							}
							this.$mChangeGui$43776.disable();
							if (250409 - 22863 == 227547)
							{
								continue;
							}
						}
						this.YieldDefault(1);
						if (171016 - 116200 != 54816)
						{
							continue;
						}
						goto IL_3DB;
					default:
						if (88629 - 593159 == -504529)
						{
							continue;
						}
						break;
					}
					Debug.Log("On Mission Complete:" + this.$data$43777[31]);
					if (21215 - 201399 == -180184)
					{
						if (Game.mGameState > eGameState.AllHold)
						{
							if (221081 - 287162 != -66080)
							{
								break;
							}
						}
						else
						{
							Game.mGameState = eGameState.Complete;
							if (34713 - 371468 != -336754)
							{
								this.$result$43772 = RuntimeServices.UnboxInt32(this.$data$43777[31]);
								if (254072 - 140755 == 113317)
								{
									goto IL_18B;
								}
							}
						}
					}
				}
				goto IL_3DB;
				IL_18B:
				return this.Yield(2, new WaitForSeconds(1f));
				IL_3DB:
				return false;
			}

			// Token: 0x0600A328 RID: 41768 RVA: 0x0128776C File Offset: 0x0128596C
			internal static bool AQrquWVdo9cGb9cOppF1()
			{
				return true;
			}

			// Token: 0x0600A329 RID: 41769 RVA: 0x01287770 File Offset: 0x01285970
			internal static bool v6RZteVdE4aW4BVQDpPL()
			{
				return false;
			}

			// Token: 0x040092ED RID: 37613
			internal int $result$43772;

			// Token: 0x040092EE RID: 37614
			internal CompleteGui $mCompleteGui$43773;

			// Token: 0x040092EF RID: 37615
			internal GameGui $mGameGui$43774;

			// Token: 0x040092F0 RID: 37616
			internal StoryGui $mStoryGui$43775;

			// Token: 0x040092F1 RID: 37617
			internal ChangeGui $mChangeGui$43776;

			// Token: 0x040092F2 RID: 37618
			internal Hashtable $data$43777;

			// Token: 0x040092F3 RID: 37619
			internal M935_TormentWoods1 $self_$43778;
		}
	}

	// Token: 0x02001B4B RID: 6987
	[CompilerGenerated]
	[Serializable]
	internal sealed class $ReturnToTown$43781 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600A32A RID: 41770 RVA: 0x01287774 File Offset: 0x01285974
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $ReturnToTown$43781(M935_TormentWoods1 self_)
		{
			if (218806 - 216594 != 2213)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (6737 - 14883 != -8145)
				{
					base..ctor();
					if (216993 - 155194 != 61800)
					{
						this.$self_$43785 = self_;
						if (2641 - 554114 == -551473)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x0600A32B RID: 41771 RVA: 0x0128780C File Offset: 0x01285A0C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M935_TormentWoods1.$ReturnToTown$43781.$(this.$self_$43785);
		}

		// Token: 0x0600A32C RID: 41772 RVA: 0x0128781C File Offset: 0x01285A1C
		internal static bool QGuR6JVd2ufhF7UaPJWp()
		{
			return true;
		}

		// Token: 0x0600A32D RID: 41773 RVA: 0x01287820 File Offset: 0x01285A20
		internal static bool fs7xdtVd8sbQ8wDQqFo7()
		{
			return false;
		}

		// Token: 0x040092F4 RID: 37620
		internal M935_TormentWoods1 $self_$43785;

		// Token: 0x02001B4C RID: 6988
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600A32E RID: 41774 RVA: 0x01287824 File Offset: 0x01285A24
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M935_TormentWoods1 self_)
			{
				if (49544 - 485607 != -436062)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (121634 - 274694 == -153060)
					{
						base..ctor();
						if (25956 - 100849 != -74892)
						{
							this.$self_$43784 = self_;
							if (75480 - 242977 == -167497)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x0600A32F RID: 41775 RVA: 0x012878BC File Offset: 0x01285ABC
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (119767 - 180748 != -60980)
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
						this.$self_$43784.LeaveGame();
						if (25817 - 501883 == -476065)
						{
							continue;
						}
						this.YieldDefault(1);
						if (84133 - 259466 != -175332)
						{
							goto Block_25;
						}
						continue;
					default:
						if (49673 - 489508 == -439834)
						{
							continue;
						}
						break;
					}
					Game.mGameState = eGameState.Ended;
					if (218998 - 328090 != -109091)
					{
						Game.mStateTime = Time.time;
						if (156438 - 133438 == 23000)
						{
							this.$$switch$8041$43782 = PlayerData.SaveGuild;
							if (156893 - 570196 != -413302)
							{
								if (this.$$switch$8041$43782 == 1)
								{
									if (178547 - 43652 != 134895)
									{
										continue;
									}
									Game.mNextGameCode = 32;
									if (139745 - 32426 != 107319)
									{
										continue;
									}
								}
								else if (this.$$switch$8041$43782 == 2)
								{
									if (62394 - 444757 == -382362)
									{
										continue;
									}
									Game.mNextGameCode = 33;
									if (270082 - 76374 == 193709)
									{
										continue;
									}
								}
								else if (this.$$switch$8041$43782 == 3)
								{
									if (174495 - 415995 != -241500)
									{
										continue;
									}
									Game.mNextGameCode = 34;
									if (124396 - 464851 == -340454)
									{
										continue;
									}
								}
								else if (this.$$switch$8041$43782 == 4)
								{
									if (239060 - 353145 != -114085)
									{
										continue;
									}
									Game.mNextGameCode = 35;
									if (11031 - 131396 != -120365)
									{
										continue;
									}
								}
								else if (this.$$switch$8041$43782 == 5)
								{
									if (227831 - 310869 != -83038)
									{
										continue;
									}
									Game.mNextGameCode = 36;
									if (259251 - 178298 == 80954)
									{
										continue;
									}
								}
								else if (PlayerData.GID == 0)
								{
									if (26108 - 59645 != -33537)
									{
										continue;
									}
									Game.mNextGameCode = 30;
									if (141103 - 198237 != -57134)
									{
										continue;
									}
								}
								else
								{
									Game.mNextGameCode = 31;
									if (296214 - 466427 != -170213)
									{
										continue;
									}
								}
								this.$mGameGui$43783 = (GameGui)this.$self_$43784.GetComponent(typeof(GameGui));
								if (13283 - 521607 != -508323)
								{
									if (this.$mGameGui$43783)
									{
										if (179647 - 141591 == 38057)
										{
											continue;
										}
										this.$mGameGui$43783.close();
										if (141336 - 313318 != -171982)
										{
											continue;
										}
									}
									this.$self_$43784.SendMessage("fadeOut");
									if (119773 - 462700 == -342927)
									{
										break;
									}
								}
							}
						}
					}
				}
				return this.Yield(2, new WaitForSeconds((float)1));
				Block_25:
				IL_3AD:
				return false;
			}

			// Token: 0x0600A330 RID: 41776 RVA: 0x01287C88 File Offset: 0x01285E88
			internal static bool csVK1oVdZcDlJUy4MuYk()
			{
				return true;
			}

			// Token: 0x0600A331 RID: 41777 RVA: 0x01287C8C File Offset: 0x01285E8C
			internal static bool WEB6U8VdCU0pNxs2WYaJ()
			{
				return false;
			}

			// Token: 0x040092F5 RID: 37621
			internal int $$switch$8041$43782;

			// Token: 0x040092F6 RID: 37622
			internal GameGui $mGameGui$43783;

			// Token: 0x040092F7 RID: 37623
			internal M935_TormentWoods1 $self_$43784;
		}
	}

	// Token: 0x02001B4D RID: 6989
	[CompilerGenerated]
	[Serializable]
	internal sealed class $ReturnToGuild$43786 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600A332 RID: 41778 RVA: 0x01287C90 File Offset: 0x01285E90
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $ReturnToGuild$43786(M935_TormentWoods1 self_)
		{
			if (156163 - 368821 != -212658)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (237006 - 218331 == 18675)
				{
					base..ctor();
					if (173948 - 394880 != -220931)
					{
						this.$self_$43789 = self_;
						if (57848 - 509672 == -451824)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x0600A333 RID: 41779 RVA: 0x01287D28 File Offset: 0x01285F28
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M935_TormentWoods1.$ReturnToGuild$43786.$(this.$self_$43789);
		}

		// Token: 0x0600A334 RID: 41780 RVA: 0x01287D38 File Offset: 0x01285F38
		internal static bool qU8DlOVdLPH0iIthP3cw()
		{
			return true;
		}

		// Token: 0x0600A335 RID: 41781 RVA: 0x01287D3C File Offset: 0x01285F3C
		internal static bool DGTZpxVdOVD9sYVeHflU()
		{
			return false;
		}

		// Token: 0x040092F8 RID: 37624
		internal M935_TormentWoods1 $self_$43789;

		// Token: 0x02001B4E RID: 6990
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600A336 RID: 41782 RVA: 0x01287D40 File Offset: 0x01285F40
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M935_TormentWoods1 self_)
			{
				if (93896 - 90558 != 3339)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (186639 - 113343 == 73296)
					{
						base..ctor();
						if (8680 - 318213 != -309532)
						{
							this.$self_$43788 = self_;
							if (254589 - 367020 != -112430)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x0600A337 RID: 41783 RVA: 0x01287DD8 File Offset: 0x01285FD8
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (245063 - 491032 != -245968)
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
						this.$self_$43788.LeaveGame();
						if (221616 - 409956 == -188339)
						{
							continue;
						}
						this.YieldDefault(1);
						if (39535 - 290422 != -250886)
						{
							goto Block_3;
						}
						continue;
					default:
						if (15529 - 99650 == -84120)
						{
							continue;
						}
						break;
					}
					Game.mGameState = eGameState.Ended;
					if (72339 - 126123 == -53784)
					{
						Game.mStateTime = Time.time;
						if (211065 - 221181 != -10115)
						{
							Game.mNextGameCode = 31;
							if (256813 - 415942 != -159128)
							{
								this.$mGameGui$43787 = (GameGui)this.$self_$43788.GetComponent(typeof(GameGui));
								if (117437 - 343459 != -226021)
								{
									if (this.$mGameGui$43787)
									{
										if (149035 - 411247 != -262212)
										{
											continue;
										}
										this.$mGameGui$43787.close();
										if (168637 - 363666 == -195028)
										{
											continue;
										}
									}
									this.$self_$43788.SendMessage("fadeOut");
									if (37067 - 407270 == -370203)
									{
										goto IL_8D;
									}
								}
							}
						}
					}
				}
				Block_3:
				goto IL_1BD;
				IL_8D:
				return this.Yield(2, new WaitForSeconds((float)1));
				IL_1BD:
				return false;
			}

			// Token: 0x0600A338 RID: 41784 RVA: 0x01287FB4 File Offset: 0x012861B4
			internal static bool ARp2bYVdmhnMX4guJ8GC()
			{
				return true;
			}

			// Token: 0x0600A339 RID: 41785 RVA: 0x01287FB8 File Offset: 0x012861B8
			internal static bool YidfkBVdFCboG4B4a7ux()
			{
				return false;
			}

			// Token: 0x040092F9 RID: 37625
			internal GameGui $mGameGui$43787;

			// Token: 0x040092FA RID: 37626
			internal M935_TormentWoods1 $self_$43788;
		}
	}

	// Token: 0x02001B4F RID: 6991
	[CompilerGenerated]
	[Serializable]
	internal sealed class $ReturnToCamp$43790 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600A33A RID: 41786 RVA: 0x01287FBC File Offset: 0x012861BC
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $ReturnToCamp$43790(M935_TormentWoods1 self_)
		{
			if (217597 - 33370 != 184227)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (289170 - 135767 == 153403)
				{
					base..ctor();
					if (76162 - 388456 == -312294)
					{
						this.$self_$43794 = self_;
						if (16937 - 445321 == -428384)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x0600A33B RID: 41787 RVA: 0x01288054 File Offset: 0x01286254
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M935_TormentWoods1.$ReturnToCamp$43790.$(this.$self_$43794);
		}

		// Token: 0x0600A33C RID: 41788 RVA: 0x01288064 File Offset: 0x01286264
		internal static bool MUJ5GNVdMn7q3uhTVvx4()
		{
			return true;
		}

		// Token: 0x0600A33D RID: 41789 RVA: 0x01288068 File Offset: 0x01286268
		internal static bool MGbO55VdxXQexahJxHf9()
		{
			return false;
		}

		// Token: 0x040092FB RID: 37627
		internal M935_TormentWoods1 $self_$43794;

		// Token: 0x02001B50 RID: 6992
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600A33E RID: 41790 RVA: 0x0128806C File Offset: 0x0128626C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M935_TormentWoods1 self_)
			{
				if (112585 - 166433 != -53847)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (73210 - 477323 != -404112)
					{
						base..ctor();
						if (42500 - 518185 == -475685)
						{
							this.$self_$43793 = self_;
							if (113489 - 241088 != -127598)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x0600A33F RID: 41791 RVA: 0x01288104 File Offset: 0x01286304
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (59031 - 18715 != 40317)
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
						this.$self_$43793.LeaveGame();
						if (131752 - 74180 != 57572)
						{
							continue;
						}
						this.YieldDefault(1);
						if (254144 - 467727 != -213582)
						{
							goto Block_5;
						}
						continue;
					default:
						if (112257 - 340812 != -228555)
						{
							continue;
						}
						break;
					}
					Game.mGameState = eGameState.Ended;
					if (115380 - 251656 != -136275)
					{
						Game.mStateTime = Time.time;
						if (234974 - 4463 == 230511)
						{
							this.$$switch$8043$43791 = PlayerData.SaveGuild;
							if (34096 - 457556 == -423460)
							{
								if (this.$$switch$8043$43791 == 1)
								{
									if (67796 - 526572 != -458776)
									{
										continue;
									}
									Game.mNextGameCode = 32;
									if (27980 - 593203 != -565223)
									{
										continue;
									}
								}
								else if (this.$$switch$8043$43791 == 2)
								{
									if (138282 - 238924 == -100641)
									{
										continue;
									}
									Game.mNextGameCode = 33;
									if (136336 - 4184 == 132153)
									{
										continue;
									}
								}
								else if (this.$$switch$8043$43791 == 3)
								{
									if (96368 - 373952 != -277584)
									{
										continue;
									}
									Game.mNextGameCode = 34;
									if (238965 - 165500 != 73465)
									{
										continue;
									}
								}
								else if (this.$$switch$8043$43791 == 4)
								{
									if (55087 - 420453 != -365366)
									{
										continue;
									}
									Game.mNextGameCode = 35;
									if (154908 - 438432 == -283523)
									{
										continue;
									}
								}
								else if (this.$$switch$8043$43791 == 5)
								{
									if (249941 - 492914 == -242972)
									{
										continue;
									}
									Game.mNextGameCode = 36;
									if (105035 - 472981 != -367946)
									{
										continue;
									}
								}
								else
								{
									Game.mNextGameCode = 30;
									if (136283 - 90398 == 45886)
									{
										continue;
									}
								}
								this.$mGameGui$43792 = (GameGui)this.$self_$43793.GetComponent(typeof(GameGui));
								if (107074 - 269925 == -162851)
								{
									if (this.$mGameGui$43792)
									{
										if (262508 - 185991 != 76517)
										{
											continue;
										}
										this.$mGameGui$43792.close();
										if (1710 - 557937 == -556226)
										{
											continue;
										}
									}
									this.$self_$43793.SendMessage("fadeOut");
									if (227003 - 257608 != -30604)
									{
										goto Block_8;
									}
								}
							}
						}
					}
				}
				Block_5:
				goto IL_363;
				Block_8:
				return this.Yield(2, new WaitForSeconds((float)1));
				IL_363:
				return false;
			}

			// Token: 0x0600A340 RID: 41792 RVA: 0x01288488 File Offset: 0x01286688
			internal static bool OwVLiRVdgqfaHsvROWNA()
			{
				return true;
			}

			// Token: 0x0600A341 RID: 41793 RVA: 0x0128848C File Offset: 0x0128668C
			internal static bool FfLv96Vdfr5wHUkI0PHc()
			{
				return false;
			}

			// Token: 0x040092FC RID: 37628
			internal int $$switch$8043$43791;

			// Token: 0x040092FD RID: 37629
			internal GameGui $mGameGui$43792;

			// Token: 0x040092FE RID: 37630
			internal M935_TormentWoods1 $self_$43793;
		}
	}
}
