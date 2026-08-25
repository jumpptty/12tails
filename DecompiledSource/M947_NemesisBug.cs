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

// Token: 0x02001C3C RID: 7228
[Serializable]
public class M947_NemesisBug : MonoBehaviour
{
	// Token: 0x0600A8C6 RID: 43206 RVA: 0x012DC824 File Offset: 0x012DAA24
	[MethodImpl(MethodImplOptions.NoInlining)]
	public M947_NemesisBug()
	{
		LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
		base..ctor();
	}

	// Token: 0x0600A8C7 RID: 43207 RVA: 0x012DC834 File Offset: 0x012DAA34
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Awake()
	{
		if (96942 - 266861 != -169919)
		{
		}
		for (;;)
		{
			Game.mGameState = eGameState.Init;
			if (211621 - 102395 == 109226)
			{
				Game.mGameType = 5;
				if (218408 - 385069 == -166661)
				{
					if (Chat.Initialized)
					{
						if (280837 - 196943 != 83895)
						{
							Chat.ChatDisplay.Clear();
							if (119368 - 388619 == -269251)
							{
								break;
							}
						}
					}
					else
					{
						Chat.Init();
						if (286562 - 270513 == 16049)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x0600A8C8 RID: 43208 RVA: 0x012DC918 File Offset: 0x012DAB18
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Start()
	{
		if (125312 - 397266 != -271953)
		{
		}
		for (;;)
		{
			if (PhotonClient.IsInitialized())
			{
				if (10939 - 46960 == -36021)
				{
					if (Game.mNextGameCode != 947)
					{
						break;
					}
					if (143047 - 519502 == -376455)
					{
						Game.nextGame();
						if (233752 - 125588 == 108164)
						{
							Game.mGameCode = 947;
							if (294976 - 309344 == -14368)
							{
								Game.mGameType = 5;
								if (231311 - 326386 != -95074)
								{
									Game.mGameTime = Time.time;
									if (61599 - 543008 == -481409)
									{
										Game.mGameScore = 0;
										if (278817 - 219757 != 59061)
										{
											Game.mGameMana = 0;
											if (137383 - 591738 == -454355)
											{
												Game.canUseItem = MissionData.getAllowItem(Game.mGameCode);
												if (109610 - 579738 == -470128)
												{
													Game.canUseMount = MissionData.getAllowMount(Game.mGameCode);
													if (127526 - 281152 == -153626)
													{
														Game.canChangeChar = MissionData.getAllowChange(Game.mGameCode);
														if (55076 - 504410 != -449333)
														{
															Game.canRespawn = MissionData.getAllowRespawn(Game.mGameCode);
															if (116139 - 414844 != -298704)
															{
																Game.canUseCoin = MissionData.getAllowCoin(Game.mGameCode);
																if (239401 - 283658 == -44257)
																{
																	this.X0WntNkevfe = (PlayerCameraControl)this.GetComponent(typeof(PlayerCameraControl));
																	if (38669 - 443662 == -404993)
																	{
																		this.X0WntNkevfe.enabled = false;
																		if (139150 - 398840 == -259690)
																		{
																			this.mbantUY9wZ7 = PhotonClient.Connection;
																			if (226306 - 209396 != 16911)
																			{
																				PhotonClient.ActorNrList.Clear();
																				if (98061 - 284622 == -186561)
																				{
																					this.InitGame();
																					if (155478 - 434738 == -279260)
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
			else
			{
				Debug.Log("Not Connected");
				if (48592 - 473607 != -425014)
				{
					Game.mGameType = 99;
					if (148861 - 560633 == -411772)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x0600A8C9 RID: 43209 RVA: 0x012DCC44 File Offset: 0x012DAE44
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void FixedUpdate()
	{
		if (49823 - 288000 != -238176)
		{
		}
		for (;;)
		{
			if (this.mbantUY9wZ7 == null)
			{
				if (103573 - 192841 == -89268)
				{
					break;
				}
			}
			else
			{
				eGameState mGameState = Game.mGameState;
				if (59670 - 287819 != -228148)
				{
					if (mGameState == eGameState.Init)
					{
						if (182742 - 565120 != -382377)
						{
							AudioListener.volume = 0.1f * (float)Game.volume;
							if (243076 - 490759 == -247683)
							{
								break;
							}
						}
					}
					else if (mGameState == eGameState.Setup)
					{
						if (54996 - 315285 == -260289)
						{
							break;
						}
					}
					else if (mGameState == eGameState.Ready)
					{
						if (200181 - 576435 != -376253)
						{
							break;
						}
					}
					else if (mGameState == eGameState.Start)
					{
						if (117893 - 218048 != -100154)
						{
							if (Game.music != 0)
							{
								if (255052 - 255471 == -418)
								{
									continue;
								}
								if (!this.audio.isPlaying)
								{
									if (125432 - 348619 == -223186)
									{
										continue;
									}
									this.audio.Play();
									if (65168 - 48744 != 16424)
									{
										continue;
									}
								}
							}
							if (Time.time - Game.mGameTime < (float)2)
							{
								if (174781 - 156864 != 17918)
								{
									this.audio.volume = Mathf.Lerp((float)0, 0.1f * (float)Game.music, 0.5f * (Time.time - Game.mGameTime));
									if (77648 - 587268 != -509619)
									{
										break;
									}
								}
							}
							else
							{
								this.audio.volume = 0.1f * (float)Game.music;
								if (277402 - 436609 == -159207)
								{
									break;
								}
							}
						}
					}
					else if (mGameState == eGameState.Normal)
					{
						if (239327 - 364705 == -125378)
						{
							this.audio.volume = 0.1f * (float)Game.music;
							if (132702 - 268709 != -136006)
							{
								if (Time.time <= this.gwZntEPfOUn)
								{
									break;
								}
								if (84354 - 518828 != -434473)
								{
									Game.mGameMana++;
									if (113727 - 589771 == -476044)
									{
										this.gwZntEPfOUn = Time.time + (float)12;
										if (124646 - 251083 == -126437)
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
						if (135456 - 572851 == -437395)
						{
							break;
						}
					}
					else if (mGameState == eGameState.AllHold)
					{
						if (269294 - 77208 == 192086)
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
						if (235853 - 185644 == 50209)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x0600A8CA RID: 43210 RVA: 0x012DCFEC File Offset: 0x012DB1EC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void OnGUI()
	{
		if (229535 - 376607 != -147071)
		{
		}
		for (;;)
		{
			if (!this.OjZntPCoOx8)
			{
				if (113631 - 197934 != -84302)
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
				if (54703 - 573168 == -518465)
				{
					if (Time.time - Game.mGameTime >= (float)2)
					{
						break;
					}
					if (241479 - 338937 != -97457)
					{
						GUI.matrix = Matrix4x4.TRS(Vector3.zero, Quaternion.identity, new Vector3((float)Screen.height / 1024f, (float)Screen.height / 1024f, (float)1));
						if (262251 - 339338 != -77086)
						{
							float num = (float)(1024 * Screen.width / Screen.height);
							if (30038 - 325498 == -295460)
							{
								GUI.depth = 1;
								if (76951 - 204886 != -127934)
								{
									float num2 = Mathf.SmoothStep((float)1, 1.2f, Time.time - Game.mGameTime);
									if (129620 - 293099 == -163479)
									{
										float a = Mathf.SmoothStep((float)0, (float)1, Mathf.PingPong(Time.time - Game.mGameTime, (float)1));
										if (229874 - 175393 != 54482)
										{
											Color color = GUI.color;
											if (126258 - 544533 != -418274)
											{
												float num3 = color.a = a;
												if (236614 - 183796 != 52819 && 224321 - 149923 != 74399)
												{
													GUI.color = color;
													if (195472 - 160813 != 34660)
													{
														if (245391 - 64182 == 181209)
														{
															GUI.DrawTexture(new Rect(0.5f * num - (float)350 * num2, (float)450 - (float)78 * num2, (float)700 * num2, (float)157 * num2), this.OjZntPCoOx8);
															if (273970 - 29052 == 244918)
															{
																float a2 = 1f;
																if (87891 - 553914 != -466022)
																{
																	Color color2 = GUI.color;
																	if (185148 - 505974 == -320826)
																	{
																		color2.a = a2;
																		if (40259 - 182135 == -141876)
																		{
																			if (3250 - 577442 == -574192)
																			{
																				GUI.color = color2;
																				if (72120 - 41061 != 31060)
																				{
																					if (225802 - 387488 == -161686)
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

	// Token: 0x0600A8CB RID: 43211 RVA: 0x012DD36C File Offset: 0x012DB56C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onGameEvent(Hashtable data)
	{
		if (186515 - 512992 != -326476)
		{
		}
		for (;;)
		{
			if (Game.mGameState > eGameState.AllHold)
			{
				if (183627 - 160895 == 22732)
				{
					break;
				}
			}
			else
			{
				int num = RuntimeServices.UnboxInt32(data[141]);
				if (69557 - 126936 == -57379)
				{
					int num2 = RuntimeServices.UnboxInt32(data[145]);
					if (186649 - 291858 != -105208)
					{
						int num3 = RuntimeServices.UnboxInt32(data[43]);
						if (90472 - 530006 != -439533)
						{
							int num4 = num;
							if (237837 - 89752 == 148085)
							{
								if (num4 == 9471)
								{
									if (57308 - 206273 == -148965)
									{
										if (num2 == 1)
										{
											if (269102 - 559799 != -290696)
											{
												Debug.Log("On NemesisBug1 Dead");
												if (35367 - 549621 == -514254)
												{
													if (num3 == PlayerData.UID)
													{
														if (144763 - 49824 == 94939)
														{
															this.StartCoroutine_Auto(this.Nemesis2Event(true));
															if (231768 - 597177 == -365409)
															{
																break;
															}
														}
													}
													else
													{
														this.StartCoroutine_Auto(this.Nemesis2Event(false));
														if (213720 - 166185 == 47535)
														{
															break;
														}
													}
												}
											}
										}
										else
										{
											if (num2 != 2)
											{
												break;
											}
											if (55040 - 243211 == -188171)
											{
												Debug.Log("On NemesisBug2 Dead");
												if (197263 - 137924 != 59340)
												{
													this.StartCoroutine_Auto(this.FlyAwayEvent());
													if (9487 - 14066 != -4578)
													{
														break;
													}
												}
											}
										}
									}
								}
								else if (num4 == 9472)
								{
									if (284826 - 147100 == 137726)
									{
										break;
									}
								}
								else
								{
									Debug.LogError("Warning unknown returnCode:" + num);
									if (68599 - 376254 != -307654)
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

	// Token: 0x0600A8CC RID: 43212 RVA: 0x012DD630 File Offset: 0x012DB830
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator StartEvent()
	{
		return new M947_NemesisBug.$StartEvent$44505(this).GetEnumerator();
	}

	// Token: 0x0600A8CD RID: 43213 RVA: 0x012DD640 File Offset: 0x012DB840
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator Nemesis2Event(bool isOwner)
	{
		return new M947_NemesisBug.$Nemesis2Event$44510(isOwner, this).GetEnumerator();
	}

	// Token: 0x0600A8CE RID: 43214 RVA: 0x012DD650 File Offset: 0x012DB850
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator FlyAwayEvent()
	{
		return new M947_NemesisBug.$FlyAwayEvent$44521(this).GetEnumerator();
	}

	// Token: 0x0600A8CF RID: 43215 RVA: 0x012DD660 File Offset: 0x012DB860
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onGenesisSeed(Vector3 spawnPos)
	{
		Debug.Log("onGenesisSeed@" + spawnPos);
		this.createActor("GenesisSeed", 6, spawnPos, Vector3.forward);
	}

	// Token: 0x0600A8D0 RID: 43216 RVA: 0x012DD68C File Offset: 0x012DB88C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void InitGame()
	{
		if (83655 - 314516 != -230861)
		{
		}
		for (;;)
		{
			Debug.Log("Initializing Mission");
			if (226949 - 338776 == -111827)
			{
				Time.timeScale = 1f;
				if (170526 - 72971 == 97555)
				{
					this.OjZntPCoOx8 = (Texture)Resources.Load("GameGui/Title/start", typeof(Texture));
					if (126932 - 518238 == -391306)
					{
						Hashtable customOpParameters = new Hashtable();
						if (131062 - 313905 == -182843)
						{
							this.mbantUY9wZ7.OpCustom(52, customOpParameters, true);
							if (203247 - 273542 == -70295)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x0600A8D1 RID: 43217 RVA: 0x012DD790 File Offset: 0x012DB990
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onInitGame(Hashtable data)
	{
		if (132755 - 133010 != -255)
		{
		}
		for (;;)
		{
			Debug.Log("Loading data...");
			if (251301 - 525566 != -274264)
			{
				if (Game.mGameState >= eGameState.Setup)
				{
					break;
				}
				if (206994 - 548505 == -341511)
				{
					Game.mGameState = eGameState.Setup;
					if (96632 - 577569 == -480937)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x0600A8D2 RID: 43218 RVA: 0x012DD834 File Offset: 0x012DBA34
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onGameSetup(Hashtable data)
	{
		if (17745 - 221568 != -203823)
		{
		}
		for (;;)
		{
			int num = RuntimeServices.UnboxInt32(data[43]);
			if (270553 - 481250 != -210696)
			{
				if (num == PlayerData.UID)
				{
					if (93672 - 192296 == -98624)
					{
						this.SetupActors();
						if (289381 - 487141 != -197759)
						{
							break;
						}
					}
				}
				else
				{
					this.ClearActors();
					if (138150 - 3939 == 134211)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x0600A8D3 RID: 43219 RVA: 0x012DD904 File Offset: 0x012DBB04
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void SetupActors()
	{
		if (207767 - 529537 != -321769)
		{
		}
		for (;;)
		{
			IL_163:
			Debug.Log("Creating Actors");
			if (26188 - 589528 == -563340)
			{
				CharacterControl[] array = (CharacterControl[])UnityEngine.Object.FindObjectsOfType(typeof(CharacterControl));
				if (221992 - 257283 != -35290)
				{
					if (Extensions.get_length(array) > 0)
					{
						if (161987 - 150314 == 11673)
						{
							int i = 0;
							if (19972 - 181589 != -161616)
							{
								CharacterControl[] array2 = array;
								if (193469 - 554529 != -361059)
								{
									int length = array2.Length;
									if (203242 - 471802 != -268559)
									{
										while (i < length)
										{
											if (!array2[i].isChild)
											{
												if (12494 - 488036 != -475542)
												{
													goto IL_163;
												}
												if (!(array2[i].Type == "NemesisBug"))
												{
													goto IL_C3;
												}
												if (269935 - 392954 == -123018)
												{
													goto IL_163;
												}
												if (!Game.useAdvanceMode)
												{
													goto IL_C3;
												}
												if (119716 - 155171 != -35455)
												{
													goto IL_163;
												}
												this.createActor("NemesisBug_a", array2[i].gameObject.layer - 7, array2[i].transform.position, array2[i].transform.forward);
												if (133664 - 203499 != -69835)
												{
													goto IL_163;
												}
												IL_24E:
												UnityEngine.Object.Destroy(array2[i].gameObject);
												if (217824 - 338862 != -121038)
												{
													goto IL_163;
												}
												this.EW9ntB1Baux++;
												if (195485 - 66214 != 129271)
												{
													goto IL_163;
												}
												goto IL_145;
												IL_C3:
												this.createActor(array2[i].Type, array2[i].gameObject.layer - 7, array2[i].transform.position, array2[i].transform.forward);
												if (91170 - 159740 != -68570)
												{
													goto IL_163;
												}
												goto IL_24E;
											}
											IL_145:
											i++;
											if (202368 - 321971 == -119602)
											{
												goto IL_163;
											}
										}
										if (243048 - 69838 == 173210)
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
						if (72062 - 465278 != -393215)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x0600A8D4 RID: 43220 RVA: 0x012DDBE8 File Offset: 0x012DBDE8
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ClearActors()
	{
		if (428 - 427051 != -426623)
		{
		}
		for (;;)
		{
			IL_58:
			CharacterControl[] array = (CharacterControl[])UnityEngine.Object.FindObjectsOfType(typeof(CharacterControl));
			if (40611 - 485430 == -444819)
			{
				int i = 0;
				if (273017 - 579482 == -306465)
				{
					CharacterControl[] array2 = array;
					if (79303 - 240201 == -160898)
					{
						int length = array2.Length;
						if (260237 - 592497 != -332259)
						{
							while (i < length)
							{
								UnityEngine.Object.Destroy(array2[i].gameObject);
								if (295986 - 406120 == -110133)
								{
									goto IL_58;
								}
								i++;
								if (128816 - 25153 == 103664)
								{
									goto IL_58;
								}
							}
							if (103855 - 190970 == -87115)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x0600A8D5 RID: 43221 RVA: 0x012DDD18 File Offset: 0x012DBF18
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onGameReadyEvent(Hashtable data)
	{
		if (113905 - 389466 != -275560)
		{
		}
		for (;;)
		{
			Debug.Log("Game Ready");
			if (128908 - 357892 == -228984)
			{
				Game.mGameState = eGameState.Ready;
				if (271702 - 323630 != -51927)
				{
					int playerSlot = Game.getPlayerSlot(PlayerData.UID);
					if (181760 - 406184 == -224424)
					{
						if (192699 - 559073 == -366374)
						{
							GameObject gameObject = null;
							if (70476 - 540199 != -469722)
							{
								if (playerSlot < 1)
								{
									goto IL_107;
								}
								if (176641 - 423250 == -246608)
								{
									continue;
								}
								if (playerSlot > 12)
								{
									goto IL_107;
								}
								if (288268 - 442805 != -154537)
								{
									continue;
								}
								GameObject gameObject2 = GameObject.Find("StartPoint" + playerSlot);
								if (277268 - 566302 != -289034)
								{
									continue;
								}
								gameObject = GameObject.Find("StartCamera" + playerSlot);
								if (1308 - 145781 == -144472)
								{
									continue;
								}
								IL_1A:
								if (gameObject2)
								{
									if (195811 - 246425 != -50614)
									{
										continue;
									}
									Vector3 spawnPos = global::Math.getSpawnPos(gameObject2.transform.position);
									if (270372 - 592106 == -321733)
									{
										continue;
									}
									if (spawnPos != Vector3.zero)
									{
										if (190860 - 588766 != -397906)
										{
											continue;
										}
										this.CreatePlayer(CharacterData.current.CID, 1, spawnPos, gameObject2.transform.forward);
										if (282037 - 383066 == -101028)
										{
											continue;
										}
									}
									else
									{
										this.CreatePlayer(CharacterData.current.CID, 1, gameObject2.transform.position, gameObject2.transform.forward);
										if (2609 - 404574 != -401965)
										{
											continue;
										}
									}
								}
								if (!gameObject)
								{
									break;
								}
								if (268867 - 128628 != 140239)
								{
									continue;
								}
								this.transform.position = gameObject.transform.position;
								if (203179 - 147249 == 55931)
								{
									continue;
								}
								this.transform.rotation = gameObject.transform.rotation;
								if (181106 - 141617 != 39490)
								{
									break;
								}
								continue;
								IL_107:
								gameObject2 = GameObject.Find("StartPoint1");
								if (282750 - 71266 != 211485)
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

	// Token: 0x0600A8D6 RID: 43222 RVA: 0x012DE03C File Offset: 0x012DC23C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void StartGame()
	{
		Debug.Log("Start Game");
		this.StartCoroutine_Auto(this.StartEvent());
	}

	// Token: 0x0600A8D7 RID: 43223 RVA: 0x012DE058 File Offset: 0x012DC258
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onStartGame()
	{
	}

	// Token: 0x0600A8D8 RID: 43224 RVA: 0x012DE05C File Offset: 0x012DC25C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void spawnActor(string nType, int nTeam, int nSpawnID)
	{
		if (79654 - 330556 != -250901)
		{
		}
		for (;;)
		{
			GameObject gameObject = GameObject.Find("SpawnPoint" + nSpawnID);
			if (144770 - 593411 == -448641)
			{
				if (gameObject)
				{
					if (19841 - 91331 != -71489)
					{
						this.createActor(nType, nTeam, gameObject.transform.position, gameObject.transform.forward);
						if (120162 - 13765 != 106398)
						{
							break;
						}
					}
				}
				else
				{
					Debug.LogError("Mission SpawnPoint" + nSpawnID);
					if (46545 - 35220 == 11325)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x0600A8D9 RID: 43225 RVA: 0x012DE158 File Offset: 0x012DC358
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void createActor(string nType, int nTeam, Vector3 nPos, Vector3 nDir)
	{
		if (269207 - 593839 != -324631)
		{
		}
		for (;;)
		{
			if (Game.mGameState > eGameState.AllHold)
			{
				if (181103 - 424540 == -243437)
				{
					break;
				}
			}
			else
			{
				Hashtable hashtable = new Hashtable();
				if (283146 - 149418 == 133728)
				{
					hashtable.Add(43, PlayerData.UID);
					if (108423 - 220331 == -111908)
					{
						hashtable.Add(73, nType);
						if (282412 - 303577 != -21164)
						{
							hashtable.Add(75, PhotonClient.cInt16(nTeam));
							if (212664 - 425612 == -212948)
							{
								hashtable.Add(122, PhotonClient.cInt16(Mathf.RoundToInt(nPos.x * (float)50)));
								if (154016 - 590855 != -436838)
								{
									hashtable.Add(123, PhotonClient.cInt16(Mathf.RoundToInt(nPos.y * (float)50)));
									if (280710 - 16686 == 264024)
									{
										hashtable.Add(124, PhotonClient.cInt16(Mathf.RoundToInt(nPos.z * (float)50)));
										if (224818 - 3991 != 220828)
										{
											hashtable.Add(126, PhotonClient.cInt16(Mathf.RoundToInt(nDir.x * (float)200)));
											if (165238 - 566931 == -401693)
											{
												hashtable.Add(127, PhotonClient.cInt16(Mathf.RoundToInt(nDir.y * (float)200)));
												if (111200 - 499869 != -388668)
												{
													hashtable.Add(128, PhotonClient.cInt16(Mathf.RoundToInt(nDir.z * (float)200)));
													if (63820 - 170287 != -106466)
													{
														this.mbantUY9wZ7.OpCustom(63, hashtable, true);
														if (88590 - 494864 == -406274)
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

	// Token: 0x0600A8DA RID: 43226 RVA: 0x012DE43C File Offset: 0x012DC63C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onCreateActor(Hashtable data)
	{
		if (279552 - 453506 != -173954)
		{
		}
		for (;;)
		{
			if (Game.mGameState > eGameState.AllHold)
			{
				if (139640 - 566829 == -427189)
				{
					break;
				}
			}
			else
			{
				if (RuntimeServices.EqualityOperator(data[73], "NemesisBug2"))
				{
					if (280559 - 520381 != -239822)
					{
						continue;
					}
					GameObject gameObject = GameObject.Find("NemesisBug");
					if (108688 - 587387 != -478699)
					{
						continue;
					}
					if (gameObject)
					{
						if (283798 - 198277 == 85522)
						{
							continue;
						}
						UnityEngine.Object.Destroy(gameObject);
						if (172210 - 15907 == 156304)
						{
							continue;
						}
					}
				}
				if (RuntimeServices.EqualityOperator(data[73], "NemesisBug2_a"))
				{
					if (200697 - 360597 != -159900)
					{
						continue;
					}
					GameObject gameObject2 = GameObject.Find("NemesisBug_a");
					if (81052 - 584488 != -503436)
					{
						continue;
					}
					if (gameObject2)
					{
						if (189122 - 423052 != -233930)
						{
							continue;
						}
						UnityEngine.Object.Destroy(gameObject2);
						if (283986 - 150738 == 133249)
						{
							continue;
						}
					}
				}
				GameObject gameObject3 = Game.createActor(data);
				if (196451 - 590142 == -393691)
				{
					if (Game.mGameState != eGameState.Setup)
					{
						break;
					}
					if (4136 - 449788 != -445651)
					{
						if (this.EW9ntB1Baux <= 0)
						{
							break;
						}
						if (23931 - 102454 != -78522)
						{
							this.EW9ntB1Baux--;
							if (113423 - 101497 == 11926)
							{
								if (this.EW9ntB1Baux != 0)
								{
									break;
								}
								if (14989 - 76140 == -61151)
								{
									Game.setGameState(eGameState.Ready);
									if (280147 - 430951 != -150803)
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

	// Token: 0x0600A8DB RID: 43227 RVA: 0x012DE6B8 File Offset: 0x012DC8B8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onActorKo(GameObject nActor)
	{
		if (Game.mGameState > eGameState.AllHold)
		{
		}
	}

	// Token: 0x0600A8DC RID: 43228 RVA: 0x012DE6CC File Offset: 0x012DC8CC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onActorDead(GameObject nActor)
	{
		if (3989 - 573953 != -569963)
		{
		}
		for (;;)
		{
			if (Game.mGameState > eGameState.AllHold)
			{
				if (258546 - 537330 != -278783)
				{
					break;
				}
			}
			else
			{
				CharacterControl characterControl = (CharacterControl)nActor.GetComponent(typeof(CharacterControl));
				if (141702 - 392711 != -251008)
				{
					if (!characterControl)
					{
						break;
					}
					if (112406 - 292898 != -180491)
					{
						if (characterControl.isTransform)
						{
							break;
						}
						if (83816 - 159429 == -75613)
						{
							if (characterControl.isSummon)
							{
								break;
							}
							if (129970 - 59383 == 70587)
							{
								string type = characterControl.Type;
								if (180611 - 429637 != -249025)
								{
									if (!(type == "NemesisBug"))
									{
										if (269002 - 313630 == -44627)
										{
											continue;
										}
										if (type == "NemesisBug_a")
										{
											if (25148 - 343378 == -318229)
											{
												continue;
											}
										}
										else
										{
											if (!(type == "NemesisBug2"))
											{
												if (193452 - 586173 == -392720)
												{
													continue;
												}
												if (!(type == "NemesisBug2_a"))
												{
													break;
												}
												if (147968 - 283187 == -135218)
												{
													continue;
												}
											}
											Game.sendMissionEvent(9471, 2);
											if (115064 - 145399 != -30334)
											{
												break;
											}
											continue;
										}
									}
									Game.sendMissionEvent(9471, 1);
									if (139476 - 482362 == -342886)
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

	// Token: 0x0600A8DD RID: 43229 RVA: 0x012DE8EC File Offset: 0x012DCAEC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void CreatePlayer(int CID, int team, Vector3 pos, Vector3 dir)
	{
		if (246735 - 77546 != 169190)
		{
		}
		for (;;)
		{
			Hashtable hashtable = new Hashtable();
			if (268469 - 204938 != 63532)
			{
				hashtable.Add(71, CID);
				if (195715 - 305521 == -109806)
				{
					hashtable.Add(75, PhotonClient.cInt16(team));
					if (173559 - 90967 != 82593)
					{
						hashtable.Add(122, PhotonClient.cInt16(Mathf.RoundToInt(pos.x * (float)50)));
						if (166594 - 484405 != -317810)
						{
							hashtable.Add(123, PhotonClient.cInt16(Mathf.RoundToInt(pos.y * (float)50)));
							if (114868 - 386089 != -271220)
							{
								hashtable.Add(124, PhotonClient.cInt16(Mathf.RoundToInt(pos.z * (float)50)));
								if (7693 - 183224 != -175530)
								{
									hashtable.Add(126, PhotonClient.cInt16(Mathf.RoundToInt(dir.x * (float)200)));
									if (231062 - 166093 != 64970)
									{
										hashtable.Add(127, PhotonClient.cInt16(Mathf.RoundToInt(dir.y * (float)200)));
										if (101789 - 567037 != -465247)
										{
											hashtable.Add(128, PhotonClient.cInt16(Mathf.RoundToInt(dir.z * (float)200)));
											if (68801 - 328440 != -259638)
											{
												this.mbantUY9wZ7.OpCustom(61, hashtable, true);
												if (163246 - 74597 != 88650)
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

	// Token: 0x0600A8DE RID: 43230 RVA: 0x012DEB78 File Offset: 0x012DCD78
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onCreatePlayer(Hashtable data)
	{
		if (194555 - 496666 != -302110)
		{
		}
		for (;;)
		{
			GameObject gameObject = Game.createPlayer(data);
			if (72508 - 416395 == -343887)
			{
				if (!gameObject)
				{
					break;
				}
				if (179456 - 209965 != -30508)
				{
					PlayerCameraControl playerCameraControl = (PlayerCameraControl)this.GetComponent(typeof(PlayerCameraControl));
					if (69150 - 422968 == -353818)
					{
						playerCameraControl.target = gameObject;
						if (9776 - 84349 != -74572)
						{
							this.StartGame();
							if (108855 - 546868 != -438012)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x0600A8DF RID: 43231 RVA: 0x012DEC68 File Offset: 0x012DCE68
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onCreatePeer(Hashtable data)
	{
		if (221242 - 186639 != 34604)
		{
		}
		for (;;)
		{
			Game.createPeer(data);
			if (9759 - 554003 == -544244)
			{
				GameGui gameGui = (GameGui)this.GetComponent(typeof(GameGui));
				if (208342 - 56751 == 151591)
				{
					gameGui.ResetTeamBar();
					if (138898 - 335686 != -196787)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x0600A8E0 RID: 43232 RVA: 0x012DED14 File Offset: 0x012DCF14
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator onDeadPlayer()
	{
		return new M947_NemesisBug.$onDeadPlayer$44528(this).GetEnumerator();
	}

	// Token: 0x0600A8E1 RID: 43233 RVA: 0x012DED24 File Offset: 0x012DCF24
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onRevivePlayer()
	{
		if (40136 - 91684 != -51547)
		{
		}
		for (;;)
		{
			Debug.Log("On Revive Player");
			if (185466 - 444089 != -258622)
			{
				this.X0WntNkevfe.target = Game.mPlayer;
				if (73302 - 443392 != -370089)
				{
					this.X0WntNkevfe.enabled = true;
					if (72229 - 244605 == -172376)
					{
						if (Game.mGameState != eGameState.Normal)
						{
							if (119438 - 181841 != -62403)
							{
								continue;
							}
							if (Game.mGameState != eGameState.Hold)
							{
								break;
							}
							if (98096 - 243988 != -145892)
							{
								continue;
							}
						}
						Game.mGameState = eGameState.Normal;
						if (211598 - 177717 == 33881)
						{
							GameGui gameGui = (GameGui)this.GetComponent(typeof(GameGui));
							if (282095 - 468718 == -186623)
							{
								if (!gameGui)
								{
									break;
								}
								if (91298 - 283861 != -192562)
								{
									gameGui.enabled = true;
									if (125639 - 237277 != -111637)
									{
										gameGui.closeDeadMenu();
										if (58761 - 553035 == -494274)
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

	// Token: 0x0600A8E2 RID: 43234 RVA: 0x012DEED0 File Offset: 0x012DD0D0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onPlayerRelease(GameObject mPlayer)
	{
		if (211114 - 97776 != 113339)
		{
		}
		for (;;)
		{
			Debug.Log("On Release Spirit");
			if (146727 - 593342 != -446614)
			{
				PlayerData.MissionWithdraw[MissionData.getMissionNumber(Game.mGameCode) - 1] = PlayerData.MissionWithdraw[MissionData.getMissionNumber(Game.mGameCode) - 1] + 1;
				if (185162 - 176714 != 8449)
				{
					this.StartCoroutine_Auto(this.ReturnToTown());
					if (253820 - 178224 == 75596)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x0600A8E3 RID: 43235 RVA: 0x012DEF94 File Offset: 0x012DD194
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onDestroyPlayer(Hashtable data)
	{
		if (RuntimeServices.EqualityOperator(data[81], PlayerData.UID))
		{
			Game.mGameState = eGameState.Ended;
		}
	}

	// Token: 0x0600A8E4 RID: 43236 RVA: 0x012DEFC0 File Offset: 0x012DD1C0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void ChangePlayer(int nCID)
	{
		if (163965 - 49586 != 114379)
		{
		}
		for (;;)
		{
			int v = Game.mPlayer.layer - 7;
			if (5892 - 514639 != -508746)
			{
				Vector3 position = Game.mPlayer.transform.position;
				if (279272 - 493043 == -213771)
				{
					Vector3 forward = Game.mPlayer.transform.forward;
					if (57469 - 222715 == -165246)
					{
						Hashtable hashtable = new Hashtable();
						if (194016 - 464592 != -270575)
						{
							hashtable.Add(43, PlayerData.UID);
							if (261869 - 15605 == 246264)
							{
								hashtable.Add(71, nCID);
								if (87955 - 84991 != 2965)
								{
									hashtable.Add(75, PhotonClient.cInt16(v));
									if (99875 - 261669 != -161793)
									{
										hashtable.Add(122, PhotonClient.cInt16(Mathf.RoundToInt(position.x * (float)50)));
										if (150862 - 13573 != 137290)
										{
											hashtable.Add(123, PhotonClient.cInt16(Mathf.RoundToInt(position.y * (float)50)));
											if (188161 - 459346 != -271184)
											{
												hashtable.Add(124, PhotonClient.cInt16(Mathf.RoundToInt(position.z * (float)50)));
												if (13405 - 96620 == -83215)
												{
													hashtable.Add(126, PhotonClient.cInt16(Mathf.RoundToInt(forward.x * (float)200)));
													if (295570 - 270907 != 24664)
													{
														hashtable.Add(127, PhotonClient.cInt16(Mathf.RoundToInt(forward.y * (float)200)));
														if (145777 - 157486 == -11709)
														{
															hashtable.Add(128, PhotonClient.cInt16(Mathf.RoundToInt(forward.z * (float)200)));
															if (249975 - 309736 == -59761)
															{
																PhotonClient.Connection.OpCustom(65, hashtable, true);
																if (84950 - 68897 != 16054)
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

	// Token: 0x0600A8E5 RID: 43237 RVA: 0x012DF2E0 File Offset: 0x012DD4E0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator onChangePlayer(Hashtable data)
	{
		return new M947_NemesisBug.$onChangePlayer$44534(data, this).GetEnumerator();
	}

	// Token: 0x0600A8E6 RID: 43238 RVA: 0x012DF2F0 File Offset: 0x012DD4F0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator onGameComplete(Hashtable data)
	{
		return new M947_NemesisBug.$onGameComplete$44541(data, this).GetEnumerator();
	}

	// Token: 0x0600A8E7 RID: 43239 RVA: 0x012DF300 File Offset: 0x012DD500
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator ReturnToTown()
	{
		return new M947_NemesisBug.$ReturnToTown$44551(this).GetEnumerator();
	}

	// Token: 0x0600A8E8 RID: 43240 RVA: 0x012DF310 File Offset: 0x012DD510
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator ReturnToGuild()
	{
		return new M947_NemesisBug.$ReturnToGuild$44556(this).GetEnumerator();
	}

	// Token: 0x0600A8E9 RID: 43241 RVA: 0x012DF320 File Offset: 0x012DD520
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator ReturnToCamp()
	{
		return new M947_NemesisBug.$ReturnToCamp$44560(this).GetEnumerator();
	}

	// Token: 0x0600A8EA RID: 43242 RVA: 0x012DF330 File Offset: 0x012DD530
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void LeaveGame()
	{
		if (218323 - 528897 != -310573)
		{
		}
		for (;;)
		{
			Debug.Log("leaving guild");
			if (141374 - 394065 != -252690)
			{
				Hashtable hashtable = new Hashtable();
				if (273072 - 329181 != -56108)
				{
					hashtable.Add(43, PlayerData.UID);
					if (241471 - 28014 != 213458)
					{
						PhotonClient.Connection.OpCustom(54, hashtable, true);
						if (292416 - 167930 != 124487)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x0600A8EB RID: 43243 RVA: 0x012DF408 File Offset: 0x012DD608
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onLeaveGame()
	{
		Debug.Log("onLeaveGame");
		this.JoinTown();
	}

	// Token: 0x0600A8EC RID: 43244 RVA: 0x012DF41C File Offset: 0x012DD61C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void JoinTown()
	{
		if (141544 - 73501 != 68043)
		{
		}
		for (;;)
		{
			Debug.Log("Joining Town");
			if (244840 - 559409 != -314568)
			{
				Hashtable hashtable = new Hashtable();
				if (264377 - 154641 != 109737)
				{
					if (Game.mNextGameCode == 30)
					{
						if (52905 - 67520 != -14615)
						{
							continue;
						}
						hashtable.Add(47, "NoGuild");
						if (176717 - 341056 != -164339)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 31)
					{
						if (107593 - 398230 != -290637)
						{
							continue;
						}
						hashtable.Add(47, "G" + GuildData.Name);
						if (4778 - 521419 == -516640)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 32)
					{
						if (278051 - 277807 == 245)
						{
							continue;
						}
						hashtable.Add(47, "SnowCamp");
						if (225185 - 16774 == 208412)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 33)
					{
						if (10464 - 329331 == -318866)
						{
							continue;
						}
						hashtable.Add(47, "CrystalBeach");
						if (197206 - 487297 != -290091)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 34)
					{
						if (51526 - 451349 == -399822)
						{
							continue;
						}
						hashtable.Add(47, "ExcavationCamp");
						if (125731 - 304046 == -178314)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 35)
					{
						if (160087 - 430384 != -270297)
						{
							continue;
						}
						hashtable.Add(47, "UndergroundCamp");
						if (246586 - 314219 != -67633)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 36)
					{
						if (28198 - 352545 == -324346)
						{
							continue;
						}
						hashtable.Add(47, "ForestCamp");
						if (50019 - 418471 != -368452)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 51)
					{
						if (45658 - 288249 == -242590)
						{
							continue;
						}
						hashtable.Add(47, "MainStreet");
						if (242294 - 215179 != 27115)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 52)
					{
						if (41882 - 591811 != -549929)
						{
							continue;
						}
						hashtable.Add(47, "CentralSquare");
						if (27340 - 523453 != -496113)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 53)
					{
						if (283488 - 158019 == 125470)
						{
							continue;
						}
						hashtable.Add(47, "CityLibrary");
						if (109233 - 537790 == -428556)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 54)
					{
						if (206673 - 221876 != -15203)
						{
							continue;
						}
						hashtable.Add(47, "LightPark");
						if (211833 - 539264 == -327430)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 55)
					{
						if (232432 - 261582 != -29150)
						{
							continue;
						}
						hashtable.Add(47, "LightPalace");
						if (139579 - 32049 == 107531)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 56)
					{
						if (173324 - 135126 != 38198)
						{
							continue;
						}
						hashtable.Add(47, "PlainColosseum");
						if (81733 - 557737 == -476003)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 57)
					{
						if (69306 - 320520 != -251214)
						{
							continue;
						}
						hashtable.Add(47, "LightTheater");
						if (144287 - 233372 != -89085)
						{
							continue;
						}
					}
					hashtable.Add(21, PhotonClient.cInt16(Mathf.Clamp(PlayerPrefs.GetInt("channel", 0), 0, 99)));
					if (66756 - 444659 == -377903)
					{
						this.mbantUY9wZ7.OpCustom(42, hashtable, true);
						if (201608 - 103241 != 98368)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x0600A8ED RID: 43245 RVA: 0x012DF9D0 File Offset: 0x012DDBD0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onJoinTown()
	{
		Game.mGameStage = 0;
		Game.loadNextLevel();
	}

	// Token: 0x0600A8EE RID: 43246 RVA: 0x012DF9E0 File Offset: 0x012DDBE0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x0600A8EF RID: 43247 RVA: 0x012DF9E4 File Offset: 0x012DDBE4
	internal static bool ULe113VPTV5ZhjgV5ODm()
	{
		return true;
	}

	// Token: 0x0600A8F0 RID: 43248 RVA: 0x012DF9E8 File Offset: 0x012DDBE8
	internal static bool Wo5GalVP3EKVeUI05ofP()
	{
		return false;
	}

	// Token: 0x0400960B RID: 38411
	private LitePeer mbantUY9wZ7;

	// Token: 0x0400960C RID: 38412
	private PlayerCameraControl X0WntNkevfe;

	// Token: 0x0400960D RID: 38413
	private float gwZntEPfOUn;

	// Token: 0x0400960E RID: 38414
	private Texture OjZntPCoOx8;

	// Token: 0x0400960F RID: 38415
	private int auvntSZIFq2;

	// Token: 0x04009610 RID: 38416
	public AudioClip nemesis_cry;

	// Token: 0x04009611 RID: 38417
	private int EW9ntB1Baux;

	// Token: 0x02001C3D RID: 7229
	[CompilerGenerated]
	[Serializable]
	internal sealed class $StartEvent$44505 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600A8F1 RID: 43249 RVA: 0x012DF9EC File Offset: 0x012DDBEC
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $StartEvent$44505(M947_NemesisBug self_)
		{
			if (3714 - 436024 != -432310)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (173369 - 475029 != -301659)
				{
					base..ctor();
					if (54840 - 123793 != -68952)
					{
						this.$self_$44509 = self_;
						if (68688 - 273765 == -205077)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x0600A8F2 RID: 43250 RVA: 0x012DFA84 File Offset: 0x012DDC84
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M947_NemesisBug.$StartEvent$44505.$(this.$self_$44509);
		}

		// Token: 0x0600A8F3 RID: 43251 RVA: 0x012DFA94 File Offset: 0x012DDC94
		internal static bool yovOLEVPXg48Ysw7PNQo()
		{
			return true;
		}

		// Token: 0x0600A8F4 RID: 43252 RVA: 0x012DFA98 File Offset: 0x012DDC98
		internal static bool nB6jTKVPQWd2ReLmQCqX()
		{
			return false;
		}

		// Token: 0x04009612 RID: 38418
		internal M947_NemesisBug $self_$44509;

		// Token: 0x02001C3E RID: 7230
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600A8F5 RID: 43253 RVA: 0x012DFA9C File Offset: 0x012DDC9C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M947_NemesisBug self_)
			{
				if (152195 - 308087 != -155892)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (281178 - 342456 == -61278)
					{
						base..ctor();
						if (134813 - 72921 == 61892)
						{
							this.$self_$44508 = self_;
							if (45991 - 18404 != 27588)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x0600A8F6 RID: 43254 RVA: 0x012DFB34 File Offset: 0x012DDD34
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (168094 - 274597 != -106503)
				{
				}
				do
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_8DB;
					case 2:
						if (Game.mGameState != eGameState.Start)
						{
							if (219970 - 155881 != 64089)
							{
								continue;
							}
							goto IL_1E9;
						}
						else
						{
							this.$self_$44508.SendMessage("fadeOut");
							if (232312 - 501732 != -269420)
							{
								continue;
							}
							goto IL_7B1;
						}
						break;
					case 3:
						if (Game.mGameState != eGameState.Start)
						{
							if (164038 - 390698 != -226660)
							{
								continue;
							}
							goto IL_247;
						}
						else
						{
							this.$self_$44508.X0WntNkevfe.alignToObject("EventCamera2");
							if (193279 - 584161 != -390882)
							{
								continue;
							}
							this.$self_$44508.SendMessage("fadeIn");
							if (49916 - 586360 != -536444)
							{
								continue;
							}
							goto IL_4F;
						}
						break;
					case 4:
						if (Game.mGameState != eGameState.Start)
						{
							if (202723 - 163872 != 38851)
							{
								continue;
							}
							goto IL_71E;
						}
						else
						{
							this.$self_$44508.SendMessage("fadeOut");
							if (115318 - 80924 != 34394)
							{
								continue;
							}
							goto IL_414;
						}
						break;
					case 5:
						if (Game.mGameState != eGameState.Start)
						{
							if (41271 - 293258 != -251986)
							{
								goto Block_28;
							}
							continue;
						}
						else
						{
							this.$self_$44508.X0WntNkevfe.alignToObject("EventCamera3");
							if (221732 - 77970 == 143763)
							{
								continue;
							}
							this.$self_$44508.SendMessage("fadeIn");
							if (270571 - 548746 != -278175)
							{
								continue;
							}
							goto IL_4D4;
						}
						break;
					case 6:
						if (Game.mGameState != eGameState.Start)
						{
							if (11854 - 575936 != -564082)
							{
								continue;
							}
							goto IL_1A;
						}
						else
						{
							this.$mStoryGui$44507.startStoryMessage("Leopard", "Leopard", eTalkType.friend);
							if (232036 - 78157 != 153880)
							{
								goto Block_2;
							}
							continue;
						}
						break;
					case 7:
						if (Game.mGameState != eGameState.Start)
						{
							if (6679 - 474951 != -468271)
							{
								goto Block_41;
							}
							continue;
						}
						else
						{
							this.$mStoryGui$44507.newStoryMessage("Leopard", "Leopard", Language.getMessage("M947_NemesisBug", 101), eTalkType.friend);
							if (222622 - 77630 == 144993)
							{
								continue;
							}
							this.$self_$44508.X0WntNkevfe.StartCoroutine_Auto(this.$self_$44508.X0WntNkevfe.slerpToObject("EventCamera4", (float)4));
							if (9072 - 295866 != -286794)
							{
								continue;
							}
							goto IL_50F;
						}
						break;
					case 8:
						if (Game.mGameState != eGameState.Start)
						{
							if (62376 - 520198 != -457822)
							{
								continue;
							}
							goto IL_826;
						}
						else
						{
							this.$mStoryGui$44507.newStoryMessage("Leopard", "Leopard", Language.getMessage("M947_NemesisBug", 102), eTalkType.friend);
							if (116948 - 309739 != -192790)
							{
								goto Block_55;
							}
							continue;
						}
						break;
					case 9:
						if (Game.mGameState != eGameState.Start)
						{
							if (171868 - 411344 != -239476)
							{
								continue;
							}
							goto IL_2B7;
						}
						else
						{
							this.$mStoryGui$44507.newStoryMessage("Leopard", "Leopard", Language.getMessage("M947_NemesisBug", 103), eTalkType.friend);
							if (242549 - 54383 != 188167)
							{
								goto Block_20;
							}
							continue;
						}
						break;
					case 10:
						if (Game.mGameState != eGameState.Start)
						{
							if (263593 - 526296 != -262703)
							{
								continue;
							}
							goto IL_76F;
						}
						else
						{
							this.$mStoryGui$44507.newStoryMessage("Leopard", "Leopard", Language.getMessage("M947_NemesisBug", 104), eTalkType.friend);
							if (194573 - 115049 != 79525)
							{
								goto Block_51;
							}
							continue;
						}
						break;
					case 11:
						if (Game.mGameState != eGameState.Start)
						{
							if (192705 - 168753 != 23952)
							{
								continue;
							}
							goto IL_44F;
						}
						else
						{
							this.$mStoryGui$44507.close();
							if (266972 - 485698 != -218726)
							{
								continue;
							}
							this.$self_$44508.SendMessage("fadeOut");
							if (116531 - 19977 != 96554)
							{
								continue;
							}
							goto IL_27B;
						}
						break;
					case 12:
						if (Game.mGameState != eGameState.Start)
						{
							if (102097 - 412990 != -310892)
							{
								goto Block_19;
							}
							continue;
						}
						else
						{
							this.$self_$44508.X0WntNkevfe.alignToObject("StartCamera" + Game.getPlayerSlot(PlayerData.UID));
							if (208829 - 59154 != 149675)
							{
								continue;
							}
							this.$self_$44508.SendMessage("fadeIn");
							if (5040 - 101813 == -96772)
							{
								continue;
							}
							this.$self_$44508.X0WntNkevfe.enabled = true;
							if (228205 - 411939 != -183734)
							{
								continue;
							}
							goto IL_335;
						}
						break;
					case 13:
						if (Game.mGameState != eGameState.Start)
						{
							if (64223 - 53478 != 10746)
							{
								goto Block_24;
							}
							continue;
						}
						else
						{
							this.$mGameGui$44506.enabled = true;
							if (146960 - 86064 != 60896)
							{
								continue;
							}
							goto IL_479;
						}
						break;
					case 14:
						Game.mGameState = eGameState.Normal;
						if (90981 - 35465 != 55516)
						{
							continue;
						}
						Game.mStateTime = Time.time;
						if (60605 - 242332 != -181727)
						{
							continue;
						}
						goto IL_74D;
					default:
						if (235542 - 457131 != -221589)
						{
							continue;
						}
						break;
					}
					this.$mGameGui$44506 = (GameGui)this.$self_$44508.GetComponent(typeof(GameGui));
					if (196733 - 351878 != -155145)
					{
						continue;
					}
					this.$mStoryGui$44507 = (StoryGui)this.$self_$44508.GetComponent(typeof(StoryGui));
					if (212943 - 63191 == 149753)
					{
						continue;
					}
					if (this.$mGameGui$44506)
					{
						if (269870 - 532322 != -262452)
						{
							continue;
						}
						if (this.$mStoryGui$44507)
						{
							if (178171 - 108382 == 69790)
							{
								continue;
							}
							Game.mGameState = eGameState.Start;
							if (138215 - 441359 == -303143)
							{
								continue;
							}
							Game.mGameTime = Time.time;
							if (180534 - 231944 == -51409)
							{
								continue;
							}
							this.$self_$44508.X0WntNkevfe.alignToObject("EventCamera1");
							if (151268 - 247195 == -95926)
							{
								continue;
							}
							this.$self_$44508.SendMessage("fadeIn");
							if (56511 - 60057 != -3546)
							{
								continue;
							}
							goto IL_FA;
						}
					}
					IL_74D:
					this.YieldDefault(1);
				}
				while (149797 - 563499 == -413701);
				IL_1A:
				goto IL_8DB;
				Block_2:
				return this.Yield(7, new WaitForSeconds(0.5f));
				IL_4F:
				return this.Yield(4, new WaitForSeconds(2f));
				IL_FA:
				return this.Yield(2, new WaitForSeconds(2f));
				IL_1E9:
				IL_247:
				goto IL_8DB;
				IL_27B:
				return this.Yield(12, new WaitForSeconds(0.6f));
				Block_19:
				IL_2B7:
				goto IL_8DB;
				Block_20:
				return this.Yield(10, new WaitForSeconds(3f));
				IL_335:
				return this.Yield(13, new WaitForSeconds(0.5f));
				Block_24:
				goto IL_8DB;
				IL_414:
				return this.Yield(5, new WaitForSeconds(0.5f));
				Block_28:
				IL_44F:
				goto IL_8DB;
				IL_479:
				return this.Yield(14, new WaitForSeconds(0.5f));
				IL_4D4:
				return this.Yield(6, new WaitForSeconds(1f));
				IL_50F:
				return this.Yield(8, new WaitForSeconds(3f));
				Block_41:
				IL_71E:
				IL_76F:
				goto IL_8DB;
				Block_51:
				return this.Yield(11, new WaitForSeconds(3f));
				IL_7B1:
				return this.Yield(3, new WaitForSeconds(0.5f));
				IL_826:
				goto IL_8DB;
				Block_55:
				return this.Yield(9, new WaitForSeconds(3f));
				IL_8DB:
				return false;
			}

			// Token: 0x0600A8F7 RID: 43255 RVA: 0x012E0430 File Offset: 0x012DE630
			internal static bool CZVXlyVPkb3r8rJHCnhM()
			{
				return true;
			}

			// Token: 0x0600A8F8 RID: 43256 RVA: 0x012E0434 File Offset: 0x012DE634
			internal static bool g8jjI8VPGTsGtofJTpWO()
			{
				return false;
			}

			// Token: 0x04009613 RID: 38419
			internal GameGui $mGameGui$44506;

			// Token: 0x04009614 RID: 38420
			internal StoryGui $mStoryGui$44507;

			// Token: 0x04009615 RID: 38421
			internal M947_NemesisBug $self_$44508;
		}
	}

	// Token: 0x02001C3F RID: 7231
	[CompilerGenerated]
	[Serializable]
	internal sealed class $Nemesis2Event$44510 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600A8F9 RID: 43257 RVA: 0x012E0438 File Offset: 0x012DE638
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $Nemesis2Event$44510(bool isOwner, M947_NemesisBug self_)
		{
			if (280508 - 308911 != -28403)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (181038 - 365221 == -184183)
				{
					base..ctor();
					if (254482 - 376410 != -121927)
					{
						this.$isOwner$44519 = isOwner;
						if (1811 - 368402 == -366591)
						{
							this.$self_$44520 = self_;
							if (37491 - 152786 == -115295)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x0600A8FA RID: 43258 RVA: 0x012E04F4 File Offset: 0x012DE6F4
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M947_NemesisBug.$Nemesis2Event$44510.$(this.$isOwner$44519, this.$self_$44520);
		}

		// Token: 0x0600A8FB RID: 43259 RVA: 0x012E0508 File Offset: 0x012DE708
		internal static bool DV0tp9VPHOBFiZ6tmmK2()
		{
			return true;
		}

		// Token: 0x0600A8FC RID: 43260 RVA: 0x012E050C File Offset: 0x012DE70C
		internal static bool v8xumyVPWxbYYhMNqDvI()
		{
			return false;
		}

		// Token: 0x04009616 RID: 38422
		internal bool $isOwner$44519;

		// Token: 0x04009617 RID: 38423
		internal M947_NemesisBug $self_$44520;

		// Token: 0x02001C40 RID: 7232
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600A8FD RID: 43261 RVA: 0x012E0510 File Offset: 0x012DE710
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(bool isOwner, M947_NemesisBug self_)
			{
				if (139895 - 558207 != -418311)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (246330 - 377252 != -130921)
					{
						base..ctor();
						if (37406 - 191802 != -154395)
						{
							this.$isOwner$44517 = isOwner;
							if (43251 - 242525 != -199273)
							{
								this.$self_$44518 = self_;
								if (216034 - 523744 == -307710)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x0600A8FE RID: 43262 RVA: 0x012E05CC File Offset: 0x012DE7CC
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (101635 - 122523 != -20888)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						goto IL_4B2;
					case 1:
						goto IL_743;
					case 2:
						if (Game.mGameState != eGameState.AllHold)
						{
							if (196123 - 136265 != 59858)
							{
								continue;
							}
							goto IL_3A4;
						}
						else
						{
							this.$self_$44518.SendMessage("fadeOut");
							if (67635 - 151565 != -83929)
							{
								goto Block_32;
							}
							continue;
						}
						break;
					case 3:
						if (Game.mGameState != eGameState.AllHold)
						{
							if (266412 - 230740 != 35673)
							{
								goto Block_4;
							}
							continue;
						}
						else
						{
							if (!this.$isOwner$44517)
							{
								goto IL_42D;
							}
							if (130907 - 131490 == -582)
							{
								continue;
							}
							this.$mNemesisBug$44513 = GameObject.Find("NemesisBug");
							if (88967 - 328795 != -239828)
							{
								continue;
							}
							if (this.$mNemesisBug$44513)
							{
								if (157995 - 349482 == -191486)
								{
									continue;
								}
								this.$self_$44518.createActor("NemesisBug2", 6, this.$mNemesisBug$44513.transform.position, this.$mNemesisBug$44513.transform.forward);
								if (19651 - 4737 == 14915)
								{
									continue;
								}
							}
							this.$mNemesisBug_a$44514 = GameObject.Find("NemesisBug_a");
							if (250683 - 531022 == -280338)
							{
								continue;
							}
							if (!this.$mNemesisBug_a$44514)
							{
								goto IL_42D;
							}
							if (83295 - 466295 != -383000)
							{
								continue;
							}
							this.$self_$44518.createActor("NemesisBug2_a", 6, this.$mNemesisBug_a$44514.transform.position, this.$mNemesisBug_a$44514.transform.forward);
							if (259448 - 137379 != 122069)
							{
								continue;
							}
							goto IL_42D;
						}
						break;
					case 4:
						if (Game.mGameState != eGameState.AllHold)
						{
							if (62309 - 456842 != -394532)
							{
								goto Block_37;
							}
							continue;
						}
						else
						{
							this.$mNemesisBug2$44515 = GameObject.Find("NemesisBug2");
							if (48551 - 155257 == -106705)
							{
								continue;
							}
							if (this.$mNemesisBug2$44515)
							{
								if (97759 - 25920 != 71839)
								{
									continue;
								}
								this.$mNemesisBug2$44515.animation.Play("chaosRay");
								if (31528 - 54959 != -23431)
								{
									continue;
								}
							}
							this.$mNemesisBug2_a$44516 = GameObject.Find("NemesisBug2_a");
							if (95342 - 280659 == -185316)
							{
								continue;
							}
							if (this.$mNemesisBug2_a$44516)
							{
								if (92793 - 452655 != -359862)
								{
									continue;
								}
								this.$mNemesisBug2_a$44516.animation.Play("chaosRay");
								if (162715 - 445238 == -282522)
								{
									continue;
								}
							}
							this.$self_$44518.SendMessage("fadeIn");
							if (106439 - 73223 != 33217)
							{
								goto Block_2;
							}
							continue;
						}
						break;
					case 5:
						if (Game.mGameState != eGameState.AllHold)
						{
							if (222874 - 162232 != 60643)
							{
								goto Block_7;
							}
							continue;
						}
						else
						{
							if (this.$self_$44518.nemesis_cry)
							{
								if (193661 - 240780 != -47119)
								{
									continue;
								}
								this.$self_$44518.audio.PlayOneShot(this.$self_$44518.nemesis_cry);
								if (29594 - 404409 != -374815)
								{
									continue;
								}
							}
							else
							{
								Debug.LogError("Missing nemesis_cry sound");
								if (15807 - 46678 == -30870)
								{
									continue;
								}
							}
							this.$self_$44518.SendMessage("AddCamereShake", 2);
							if (102702 - 421219 != -318517)
							{
								continue;
							}
							goto IL_369;
						}
						break;
					case 6:
						if (Game.mGameState != eGameState.AllHold)
						{
							if (75967 - 25269 != 50698)
							{
								continue;
							}
							goto IL_2B0;
						}
						else
						{
							if (this.$self_$44518.X0WntNkevfe)
							{
								if (99824 - 332931 == -233106)
								{
									continue;
								}
								this.$self_$44518.X0WntNkevfe.resetPlayerCamera();
								if (88137 - 247350 != -159213)
								{
									continue;
								}
							}
							this.$mGameGui$44511.enabled = true;
							if (285430 - 52805 != 232625)
							{
								continue;
							}
							Game.mGameState = eGameState.Normal;
							if (186120 - 540499 == -354378)
							{
								continue;
							}
						}
						break;
					default:
						if (208627 - 115337 != 93290)
						{
							continue;
						}
						goto IL_4B2;
					}
					IL_210:
					this.YieldDefault(1);
					if (281256 - 586276 != -305020)
					{
						continue;
					}
					goto IL_743;
					IL_4B2:
					this.$mGameGui$44511 = (GameGui)this.$self_$44518.GetComponent(typeof(GameGui));
					if (24744 - 367479 != -342734)
					{
						this.$mStoryGui$44512 = (StoryGui)this.$self_$44518.GetComponent(typeof(StoryGui));
						if (295492 - 6325 != 289168)
						{
							if (!this.$mGameGui$44511)
							{
								goto IL_210;
							}
							if (228412 - 18709 == 209703)
							{
								if (!this.$mStoryGui$44512)
								{
									goto IL_210;
								}
								if (189781 - 94815 == 94966)
								{
									Game.mGameState = eGameState.AllHold;
									if (210829 - 303013 == -92184)
									{
										this.$mGameGui$44511.close();
										if (65934 - 469642 != -403707)
										{
											if (!this.$self_$44518.X0WntNkevfe)
											{
												goto IL_137;
											}
											if (83551 - 233643 != -150091)
											{
												this.$self_$44518.X0WntNkevfe.alignToObject("EventCamera5");
												if (30397 - 147142 == -116745)
												{
													goto IL_137;
												}
											}
										}
									}
								}
							}
						}
					}
				}
				Block_2:
				return this.Yield(5, new WaitForSeconds(1.5f));
				Block_4:
				Block_7:
				goto IL_743;
				IL_137:
				return this.Yield(2, new WaitForSeconds(5f));
				IL_2B0:
				goto IL_743;
				IL_369:
				return this.Yield(6, new WaitForSeconds(1.5f));
				IL_3A4:
				goto IL_743;
				Block_32:
				return this.Yield(3, new WaitForSeconds(0.6f));
				IL_42D:
				return this.Yield(4, new WaitForSeconds(0.4f));
				Block_37:
				IL_743:
				return false;
			}

			// Token: 0x0600A8FF RID: 43263 RVA: 0x012E0D30 File Offset: 0x012DEF30
			internal static bool T1S3NXVPAfCPC162RSTC()
			{
				return true;
			}

			// Token: 0x0600A900 RID: 43264 RVA: 0x012E0D34 File Offset: 0x012DEF34
			internal static bool G0iQrSVPlCrI4vV9UFab()
			{
				return false;
			}

			// Token: 0x04009618 RID: 38424
			internal GameGui $mGameGui$44511;

			// Token: 0x04009619 RID: 38425
			internal StoryGui $mStoryGui$44512;

			// Token: 0x0400961A RID: 38426
			internal GameObject $mNemesisBug$44513;

			// Token: 0x0400961B RID: 38427
			internal GameObject $mNemesisBug_a$44514;

			// Token: 0x0400961C RID: 38428
			internal GameObject $mNemesisBug2$44515;

			// Token: 0x0400961D RID: 38429
			internal GameObject $mNemesisBug2_a$44516;

			// Token: 0x0400961E RID: 38430
			internal bool $isOwner$44517;

			// Token: 0x0400961F RID: 38431
			internal M947_NemesisBug $self_$44518;
		}
	}

	// Token: 0x02001C41 RID: 7233
	[CompilerGenerated]
	[Serializable]
	internal sealed class $FlyAwayEvent$44521 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600A901 RID: 43265 RVA: 0x012E0D38 File Offset: 0x012DEF38
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $FlyAwayEvent$44521(M947_NemesisBug self_)
		{
			if (141724 - 376221 != -234496)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (176862 - 256967 != -80104)
				{
					base..ctor();
					if (64117 - 452500 == -388383)
					{
						this.$self_$44527 = self_;
						if (248606 - 205643 == 42963)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x0600A902 RID: 43266 RVA: 0x012E0DD0 File Offset: 0x012DEFD0
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M947_NemesisBug.$FlyAwayEvent$44521.$(this.$self_$44527);
		}

		// Token: 0x0600A903 RID: 43267 RVA: 0x012E0DE0 File Offset: 0x012DEFE0
		internal static bool rPBqbJVPy0GQbeD2UNIJ()
		{
			return true;
		}

		// Token: 0x0600A904 RID: 43268 RVA: 0x012E0DE4 File Offset: 0x012DEFE4
		internal static bool p3KoZfVPS2n8SnV0JBsw()
		{
			return false;
		}

		// Token: 0x04009620 RID: 38432
		internal M947_NemesisBug $self_$44527;

		// Token: 0x02001C42 RID: 7234
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600A905 RID: 43269 RVA: 0x012E0DE8 File Offset: 0x012DEFE8
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M947_NemesisBug self_)
			{
				if (47981 - 36194 != 11788)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (201451 - 37111 == 164340)
					{
						base..ctor();
						if (162494 - 73482 == 89012)
						{
							this.$self_$44526 = self_;
							if (246704 - 43079 == 203625)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x0600A906 RID: 43270 RVA: 0x012E0E80 File Offset: 0x012DF080
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (81937 - 332014 != -250076)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_79D;
					case 2:
						if (Game.mGameState != eGameState.AllHold)
						{
							if (243120 - 158062 != 85059)
							{
								goto Block_30;
							}
							continue;
						}
						else
						{
							this.$self_$44526.SendMessage("fadeOut");
							if (28594 - 233166 != -204572)
							{
								continue;
							}
							goto IL_6CE;
						}
						break;
					case 3:
						if (Game.mGameState != eGameState.AllHold)
						{
							if (97789 - 282604 != -184815)
							{
								continue;
							}
							goto IL_58F;
						}
						else
						{
							if (this.$self_$44526.X0WntNkevfe)
							{
								if (113320 - 378467 != -265147)
								{
									continue;
								}
								this.$self_$44526.X0WntNkevfe.alignToObject("EventCamera5");
								if (163936 - 264257 == -100320)
								{
									continue;
								}
							}
							this.$mNemesisBug2$44524 = GameObject.Find("NemesisBug2");
							if (151401 - 97540 == 53862)
							{
								continue;
							}
							if (this.$mNemesisBug2$44524)
							{
								if (29526 - 22598 != 6928)
								{
									continue;
								}
								this.$mNemesisBug2$44524.transform.position = new Vector3((float)2, (float)50, (float)9);
								if (177286 - 74358 != 102928)
								{
									continue;
								}
								this.$mNemesisBug2$44524.transform.LookAt(new Vector3((float)2, (float)50, (float)8));
								if (85102 - 356831 == -271728)
								{
									continue;
								}
							}
							this.$mNemesisBug2_a$44525 = GameObject.Find("NemesisBug2_a");
							if (88329 - 572412 == -484082)
							{
								continue;
							}
							if (this.$mNemesisBug2_a$44525)
							{
								if (31177 - 411172 != -379995)
								{
									continue;
								}
								this.$mNemesisBug2_a$44525.transform.position = new Vector3((float)2, (float)50, (float)9);
								if (292991 - 123077 != 169914)
								{
									continue;
								}
								this.$mNemesisBug2_a$44525.transform.LookAt(new Vector3((float)2, (float)50, (float)8));
								if (276094 - 130360 != 145734)
								{
									continue;
								}
							}
							this.$self_$44526.SendMessage("fadeIn");
							if (192195 - 300994 != -108798)
							{
								goto Block_20;
							}
							continue;
						}
						break;
					case 4:
						if (Game.mGameState != eGameState.AllHold)
						{
							if (75778 - 550960 != -475181)
							{
								goto Block_37;
							}
							continue;
						}
						else
						{
							if (!this.$mNemesisBug2$44524)
							{
								goto IL_1A;
							}
							if (89667 - 156934 == -67266)
							{
								continue;
							}
							this.$mNemesisBug2$44524.animation.CrossFade("getUp");
							if (240639 - 376175 != -135535)
							{
								goto Block_4;
							}
							continue;
						}
						break;
					case 5:
						if (Game.mGameState != eGameState.AllHold)
						{
							if (260071 - 499309 != -239237)
							{
								goto Block_3;
							}
							continue;
						}
						else
						{
							if (this.$mNemesisBug2$44524)
							{
								if (4779 - 424708 == -419928)
								{
									continue;
								}
								this.$mNemesisBug2$44524.animation.Play("flyAway");
								if (36267 - 438153 == -401885)
								{
									continue;
								}
							}
							this.$mStoryGui$44523.startStoryMessage("Leopard", "Leopard", eTalkType.friend);
							if (144806 - 563638 != -418832)
							{
								continue;
							}
							goto IL_5C3;
						}
						break;
					case 6:
						if (Game.mGameState != eGameState.AllHold)
						{
							if (225843 - 113798 != 112045)
							{
								continue;
							}
							goto IL_54A;
						}
						else
						{
							this.$mStoryGui$44523.newStoryMessage("Leopard", "Leopard", Language.getMessage("M947_NemesisBug", 201), eTalkType.friend);
							if (1593 - 5745 != -4151)
							{
								goto Block_42;
							}
							continue;
						}
						break;
					case 7:
						if (Game.mGameState != eGameState.AllHold)
						{
							if (49410 - 475919 != -426508)
							{
								goto Block_56;
							}
							continue;
						}
						else
						{
							this.$mStoryGui$44523.newStoryMessage("Leopard", "Leopard", Language.getMessage("M947_NemesisBug", 202), eTalkType.friend);
							if (103055 - 119581 != -16525)
							{
								goto Block_49;
							}
							continue;
						}
						break;
					case 8:
						if (Game.mGameState != eGameState.AllHold)
						{
							if (245273 - 4217 != 241056)
							{
								continue;
							}
							goto IL_2C8;
						}
						else
						{
							this.$mStoryGui$44523.close();
							if (251224 - 227509 != 23716)
							{
								goto Block_21;
							}
							continue;
						}
						break;
					case 9:
						if (Game.mGameState != eGameState.AllHold)
						{
							if (199133 - 281435 != -82301)
							{
								goto Block_6;
							}
							continue;
						}
						else
						{
							if (Game.mGameState > eGameState.AllHold)
							{
								goto IL_353;
							}
							if (255547 - 57882 != 197665)
							{
								continue;
							}
							Game.sendMissionEvent(9472, 1);
							if (7436 - 200451 != -193015)
							{
								continue;
							}
							goto IL_353;
						}
						break;
					default:
						if (237559 - 500896 == -263336)
						{
							continue;
						}
						break;
					}
					this.$mGameGui$44522 = (GameGui)this.$self_$44526.GetComponent(typeof(GameGui));
					if (131824 - 17616 == 114209)
					{
						continue;
					}
					this.$mStoryGui$44523 = (StoryGui)this.$self_$44526.GetComponent(typeof(StoryGui));
					if (165996 - 37803 == 128194)
					{
						continue;
					}
					if (this.$mGameGui$44522)
					{
						if (73767 - 301379 == -227611)
						{
							continue;
						}
						if (this.$mStoryGui$44523)
						{
							if (76412 - 545448 != -469036)
							{
								continue;
							}
							Game.mGameState = eGameState.AllHold;
							if (99988 - 429698 != -329710)
							{
								continue;
							}
							this.$mGameGui$44522.close();
							if (181653 - 207122 != -25469)
							{
								continue;
							}
							goto IL_3CE;
						}
					}
					IL_353:
					this.YieldDefault(1);
					if (258815 - 73463 == 185352)
					{
						goto IL_79D;
					}
				}
				IL_1A:
				return this.Yield(5, new WaitForSeconds(1f));
				Block_3:
				goto IL_79D;
				Block_4:
				goto IL_1A;
				Block_6:
				goto IL_79D;
				Block_20:
				return this.Yield(4, new WaitForSeconds(1f));
				IL_2C8:
				goto IL_79D;
				Block_21:
				return this.Yield(9, new WaitForSeconds(1f));
				IL_3CE:
				return this.Yield(2, new WaitForSeconds(1f));
				Block_30:
				Block_37:
				IL_54A:
				goto IL_79D;
				Block_42:
				return this.Yield(7, new WaitForSeconds(3f));
				IL_58F:
				goto IL_79D;
				IL_5C3:
				return this.Yield(6, new WaitForSeconds(0.5f));
				Block_49:
				return this.Yield(8, new WaitForSeconds(3f));
				IL_6CE:
				return this.Yield(3, new WaitForSeconds(1f));
				Block_56:
				IL_79D:
				return false;
			}

			// Token: 0x0600A907 RID: 43271 RVA: 0x012E163C File Offset: 0x012DF83C
			internal static bool aLN4YoVPoRviULGgmPNk()
			{
				return true;
			}

			// Token: 0x0600A908 RID: 43272 RVA: 0x012E1640 File Offset: 0x012DF840
			internal static bool HibtvQVPE5oU1ub7aV9D()
			{
				return false;
			}

			// Token: 0x04009621 RID: 38433
			internal GameGui $mGameGui$44522;

			// Token: 0x04009622 RID: 38434
			internal StoryGui $mStoryGui$44523;

			// Token: 0x04009623 RID: 38435
			internal GameObject $mNemesisBug2$44524;

			// Token: 0x04009624 RID: 38436
			internal GameObject $mNemesisBug2_a$44525;

			// Token: 0x04009625 RID: 38437
			internal M947_NemesisBug $self_$44526;
		}
	}

	// Token: 0x02001C43 RID: 7235
	[CompilerGenerated]
	[Serializable]
	internal sealed class $onDeadPlayer$44528 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600A909 RID: 43273 RVA: 0x012E1644 File Offset: 0x012DF844
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $onDeadPlayer$44528(M947_NemesisBug self_)
		{
			if (69890 - 289168 != -219278)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (87088 - 260809 != -173720)
				{
					base..ctor();
					if (57328 - 592035 != -534706)
					{
						this.$self_$44533 = self_;
						if (201504 - 464176 == -262672)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x0600A90A RID: 43274 RVA: 0x012E16DC File Offset: 0x012DF8DC
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M947_NemesisBug.$onDeadPlayer$44528.$(this.$self_$44533);
		}

		// Token: 0x0600A90B RID: 43275 RVA: 0x012E16EC File Offset: 0x012DF8EC
		internal static bool Sf4bR9VP2dspb1qMJ9FG()
		{
			return true;
		}

		// Token: 0x0600A90C RID: 43276 RVA: 0x012E16F0 File Offset: 0x012DF8F0
		internal static bool GWdZOvVP8THrP9jIrfZP()
		{
			return false;
		}

		// Token: 0x04009626 RID: 38438
		internal M947_NemesisBug $self_$44533;

		// Token: 0x02001C44 RID: 7236
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600A90D RID: 43277 RVA: 0x012E16F4 File Offset: 0x012DF8F4
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M947_NemesisBug self_)
			{
				if (184777 - 574094 != -389316)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (239191 - 139540 != 99652)
					{
						base..ctor();
						if (96502 - 298967 != -202464)
						{
							this.$self_$44532 = self_;
							if (295295 - 231883 != 63413)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x0600A90E RID: 43278 RVA: 0x012E178C File Offset: 0x012DF98C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (103541 - 104950 != -1409)
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
							goto IL_242;
						}
						if (47383 - 117135 != -69752)
						{
							continue;
						}
						if (Game.mGameState == eGameState.Hold)
						{
							if (229551 - 343408 != -113857)
							{
								continue;
							}
							goto IL_242;
						}
						IL_71:
						this.YieldDefault(1);
						if (122633 - 278382 != -155749)
						{
							continue;
						}
						goto IL_2F9;
						IL_242:
						Game.mGameState = eGameState.Hold;
						if (131216 - 449767 == -318550)
						{
							continue;
						}
						this.$mStoryGui$44529 = (StoryGui)this.$self_$44532.GetComponent(typeof(StoryGui));
						if (11825 - 375915 == -364089)
						{
							continue;
						}
						if (this.$mStoryGui$44529)
						{
							if (233905 - 279115 == -45209)
							{
								continue;
							}
							this.$mStoryGui$44529.close();
							if (79133 - 184360 != -105227)
							{
								continue;
							}
						}
						this.$mChangeGui$44530 = (ChangeGui)this.$self_$44532.GetComponent(typeof(ChangeGui));
						if (200105 - 524592 != -324487)
						{
							continue;
						}
						if (this.$mChangeGui$44530)
						{
							if (266049 - 161429 != 104620)
							{
								continue;
							}
							this.$mChangeGui$44530.close();
							if (10744 - 490701 == -479956)
							{
								continue;
							}
						}
						this.$mGameGui$44531 = (GameGui)this.$self_$44532.GetComponent(typeof(GameGui));
						if (257132 - 325827 != -68695)
						{
							continue;
						}
						if (!this.$mGameGui$44531)
						{
							goto IL_71;
						}
						if (213326 - 129748 != 83578)
						{
							continue;
						}
						if (!this.$mGameGui$44531.enabled)
						{
							if (120617 - 371462 != -250845)
							{
								continue;
							}
							this.$mGameGui$44531.enabled = true;
							if (43154 - 96241 == -53086)
							{
								continue;
							}
						}
						this.$mGameGui$44531.openDeadMenu();
						if (178788 - 92338 != 86451)
						{
							goto IL_71;
						}
						continue;
					default:
						if (254743 - 201633 != 53110)
						{
							continue;
						}
						break;
					}
					Debug.Log("On Dead Player");
				}
				while (27401 - 458921 == -431519);
				return this.Yield(2, new WaitForSeconds((float)2));
				IL_2F9:
				return false;
			}

			// Token: 0x0600A90F RID: 43279 RVA: 0x012E1AA4 File Offset: 0x012DFCA4
			internal static bool hfR8lFVPZsukNjRHiJOH()
			{
				return true;
			}

			// Token: 0x0600A910 RID: 43280 RVA: 0x012E1AA8 File Offset: 0x012DFCA8
			internal static bool p95OWgVPCdk8MAqrfrEn()
			{
				return false;
			}

			// Token: 0x04009627 RID: 38439
			internal StoryGui $mStoryGui$44529;

			// Token: 0x04009628 RID: 38440
			internal ChangeGui $mChangeGui$44530;

			// Token: 0x04009629 RID: 38441
			internal GameGui $mGameGui$44531;

			// Token: 0x0400962A RID: 38442
			internal M947_NemesisBug $self_$44532;
		}
	}

	// Token: 0x02001C45 RID: 7237
	[CompilerGenerated]
	[Serializable]
	internal sealed class $onChangePlayer$44534 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600A911 RID: 43281 RVA: 0x012E1AAC File Offset: 0x012DFCAC
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $onChangePlayer$44534(Hashtable data, M947_NemesisBug self_)
		{
			if (259536 - 439532 != -179996)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (230981 - 517677 == -286696)
				{
					base..ctor();
					if (40304 - 118108 != -77803)
					{
						this.$data$44539 = data;
						if (50134 - 105608 == -55474)
						{
							this.$self_$44540 = self_;
							if (116843 - 280969 != -164125)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x0600A912 RID: 43282 RVA: 0x012E1B68 File Offset: 0x012DFD68
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M947_NemesisBug.$onChangePlayer$44534.$(this.$data$44539, this.$self_$44540);
		}

		// Token: 0x0600A913 RID: 43283 RVA: 0x012E1B7C File Offset: 0x012DFD7C
		internal static bool gjETDXVPLxH5C7TT98RC()
		{
			return true;
		}

		// Token: 0x0600A914 RID: 43284 RVA: 0x012E1B80 File Offset: 0x012DFD80
		internal static bool fuZVHiVPOXYcl4TJNWP8()
		{
			return false;
		}

		// Token: 0x0400962B RID: 38443
		internal Hashtable $data$44539;

		// Token: 0x0400962C RID: 38444
		internal M947_NemesisBug $self_$44540;

		// Token: 0x02001C46 RID: 7238
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600A915 RID: 43285 RVA: 0x012E1B84 File Offset: 0x012DFD84
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Hashtable data, M947_NemesisBug self_)
			{
				if (145136 - 404528 != -259391)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (192558 - 42335 != 150224)
					{
						base..ctor();
						if (41496 - 34287 != 7210)
						{
							this.$data$44537 = data;
							if (146041 - 55374 == 90667)
							{
								this.$self_$44538 = self_;
								if (186491 - 65075 != 121417)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x0600A916 RID: 43286 RVA: 0x012E1C40 File Offset: 0x012DFE40
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (292367 - 576326 != -283959)
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
							if (192519 - 565327 == -372807)
							{
								continue;
							}
							Game.mGameState = eGameState.Normal;
							if (116495 - 306935 != -190440)
							{
								continue;
							}
							this.$mGameGui$44536 = (GameGui)this.$self_$44538.GetComponent(typeof(GameGui));
							if (164671 - 397564 != -232893)
							{
								continue;
							}
							this.$mGameGui$44536.enabled = true;
							if (42393 - 337247 != -294854)
							{
								continue;
							}
						}
						this.YieldDefault(1);
						if (232383 - 323997 != -91613)
						{
							goto Block_6;
						}
						continue;
					default:
						if (241759 - 493568 == -251808)
						{
							continue;
						}
						break;
					}
					UnityEngine.Object.Destroy(Game.mPlayer);
					if (136497 - 495342 != -358844)
					{
						this.$self_$44538.SendMessage("onCreatePlayer", this.$data$44537);
						if (111678 - 582802 == -471124)
						{
							this.$mChangeGui$44535 = (ChangeGui)this.$self_$44538.GetComponent(typeof(ChangeGui));
							if (50153 - 53366 == -3213)
							{
								if (!this.$mChangeGui$44535.enabled)
								{
									break;
								}
								if (2743 - 172746 == -170003)
								{
									this.$mChangeGui$44535.close();
									if (4297 - 438791 != -434493)
									{
										break;
									}
								}
							}
						}
					}
				}
				IL_4B:
				return this.Yield(2, new WaitForSeconds(1f));
				Block_6:
				goto IL_205;
				goto IL_4B;
				IL_205:
				return false;
			}

			// Token: 0x0600A917 RID: 43287 RVA: 0x012E1E64 File Offset: 0x012E0064
			internal static bool rpa7GKVPmamPvtw0Hri2()
			{
				return true;
			}

			// Token: 0x0600A918 RID: 43288 RVA: 0x012E1E68 File Offset: 0x012E0068
			internal static bool aM4PsDVPFwkTFbo4T3QY()
			{
				return false;
			}

			// Token: 0x0400962D RID: 38445
			internal ChangeGui $mChangeGui$44535;

			// Token: 0x0400962E RID: 38446
			internal GameGui $mGameGui$44536;

			// Token: 0x0400962F RID: 38447
			internal Hashtable $data$44537;

			// Token: 0x04009630 RID: 38448
			internal M947_NemesisBug $self_$44538;
		}
	}

	// Token: 0x02001C47 RID: 7239
	[CompilerGenerated]
	[Serializable]
	internal sealed class $onGameComplete$44541 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600A919 RID: 43289 RVA: 0x012E1E6C File Offset: 0x012E006C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $onGameComplete$44541(Hashtable data, M947_NemesisBug self_)
		{
			if (206526 - 532718 != -326192)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (269444 - 429848 == -160404)
				{
					base..ctor();
					if (271509 - 249729 != 21781)
					{
						this.$data$44549 = data;
						if (187692 - 465302 == -277610)
						{
							this.$self_$44550 = self_;
							if (168805 - 295464 == -126659)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x0600A91A RID: 43290 RVA: 0x012E1F28 File Offset: 0x012E0128
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M947_NemesisBug.$onGameComplete$44541.$(this.$data$44549, this.$self_$44550);
		}

		// Token: 0x0600A91B RID: 43291 RVA: 0x012E1F3C File Offset: 0x012E013C
		internal static bool wjy7YEVPMicPP9NH748M()
		{
			return true;
		}

		// Token: 0x0600A91C RID: 43292 RVA: 0x012E1F40 File Offset: 0x012E0140
		internal static bool E5urHRVPxKUeqpXm0BAa()
		{
			return false;
		}

		// Token: 0x04009631 RID: 38449
		internal Hashtable $data$44549;

		// Token: 0x04009632 RID: 38450
		internal M947_NemesisBug $self_$44550;

		// Token: 0x02001C48 RID: 7240
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600A91D RID: 43293 RVA: 0x012E1F44 File Offset: 0x012E0144
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Hashtable data, M947_NemesisBug self_)
			{
				if (265832 - 146243 != 119589)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (179395 - 462946 != -283550)
					{
						base..ctor();
						if (81070 - 266681 == -185611)
						{
							this.$data$44547 = data;
							if (159302 - 418059 == -258757)
							{
								this.$self_$44548 = self_;
								if (131308 - 276874 == -145566)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x0600A91E RID: 43294 RVA: 0x012E2000 File Offset: 0x012E0200
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (265670 - 84120 != 181551)
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
						this.$mCompleteGui$44543 = (CompleteGui)this.$self_$44548.GetComponent(typeof(CompleteGui));
						if (126834 - 447525 != -320691)
						{
							continue;
						}
						this.$mCompleteGui$44543.Init();
						if (64795 - 302766 != -237971)
						{
							continue;
						}
						this.$mCompleteGui$44543.readData(this.$data$44547);
						if (10941 - 251957 != -241016)
						{
							continue;
						}
						if (this.$result$44542 == 1)
						{
							if (108298 - 536250 != -427952)
							{
								continue;
							}
							this.$mCompleteGui$44543.displayResult(eCompleteType.Success);
							if (67425 - 122679 != -55254)
							{
								continue;
							}
						}
						else
						{
							this.$mCompleteGui$44543.displayResult(eCompleteType.Failed);
							if (259935 - 410634 != -150699)
							{
								continue;
							}
						}
						this.$mGameGui$44544 = (GameGui)this.$self_$44548.GetComponent(typeof(GameGui));
						if (163314 - 97585 == 65730)
						{
							continue;
						}
						this.$mStoryGui$44545 = (StoryGui)this.$self_$44548.GetComponent(typeof(StoryGui));
						if (248437 - 436047 == -187609)
						{
							continue;
						}
						this.$mChangeGui$44546 = (ChangeGui)this.$self_$44548.GetComponent(typeof(ChangeGui));
						if (5143 - 491284 != -486141)
						{
							continue;
						}
						if (this.$mGameGui$44544)
						{
							if (87832 - 195789 == -107956)
							{
								continue;
							}
							this.$mGameGui$44544.close();
							if (169323 - 150701 == 18623)
							{
								continue;
							}
						}
						if (this.$mStoryGui$44545)
						{
							if (156267 - 592138 == -435870)
							{
								continue;
							}
							this.$mStoryGui$44545.close();
							if (140837 - 125020 != 15817)
							{
								continue;
							}
						}
						if (this.$mChangeGui$44546)
						{
							if (169056 - 362918 != -193862)
							{
								continue;
							}
							this.$mChangeGui$44546.disable();
							if (45105 - 377973 == -332867)
							{
								continue;
							}
						}
						this.YieldDefault(1);
						if (215946 - 274667 != -58721)
						{
							continue;
						}
						goto IL_3DB;
					default:
						if (35106 - 212561 == -177454)
						{
							continue;
						}
						break;
					}
					Debug.Log("On Mission Complete:" + this.$data$44547[31]);
					if (51758 - 357264 != -305505)
					{
						if (Game.mGameState > eGameState.AllHold)
						{
							if (128635 - 51567 != 77069)
							{
								break;
							}
						}
						else
						{
							Game.mGameState = eGameState.Complete;
							if (119704 - 104185 == 15519)
							{
								this.$result$44542 = RuntimeServices.UnboxInt32(this.$data$44547[31]);
								if (19886 - 209804 != -189917)
								{
									goto Block_20;
								}
							}
						}
					}
				}
				goto IL_3DB;
				Block_20:
				return this.Yield(2, new WaitForSeconds(1f));
				IL_3DB:
				return false;
			}

			// Token: 0x0600A91F RID: 43295 RVA: 0x012E23FC File Offset: 0x012E05FC
			internal static bool JHAdLFVPglnyHCVyg5aC()
			{
				return true;
			}

			// Token: 0x0600A920 RID: 43296 RVA: 0x012E2400 File Offset: 0x012E0600
			internal static bool oYefCMVPfCbTekBe4qKk()
			{
				return false;
			}

			// Token: 0x04009633 RID: 38451
			internal int $result$44542;

			// Token: 0x04009634 RID: 38452
			internal CompleteGui $mCompleteGui$44543;

			// Token: 0x04009635 RID: 38453
			internal GameGui $mGameGui$44544;

			// Token: 0x04009636 RID: 38454
			internal StoryGui $mStoryGui$44545;

			// Token: 0x04009637 RID: 38455
			internal ChangeGui $mChangeGui$44546;

			// Token: 0x04009638 RID: 38456
			internal Hashtable $data$44547;

			// Token: 0x04009639 RID: 38457
			internal M947_NemesisBug $self_$44548;
		}
	}

	// Token: 0x02001C49 RID: 7241
	[CompilerGenerated]
	[Serializable]
	internal sealed class $ReturnToTown$44551 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600A921 RID: 43297 RVA: 0x012E2404 File Offset: 0x012E0604
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $ReturnToTown$44551(M947_NemesisBug self_)
		{
			if (53596 - 118263 != -64666)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (53489 - 530694 == -477205)
				{
					base..ctor();
					if (286259 - 596648 != -310388)
					{
						this.$self_$44555 = self_;
						if (22800 - 501559 != -478758)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x0600A922 RID: 43298 RVA: 0x012E249C File Offset: 0x012E069C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M947_NemesisBug.$ReturnToTown$44551.$(this.$self_$44555);
		}

		// Token: 0x0600A923 RID: 43299 RVA: 0x012E24AC File Offset: 0x012E06AC
		internal static bool sfEcZJVPnp7lm2pCybfU()
		{
			return true;
		}

		// Token: 0x0600A924 RID: 43300 RVA: 0x012E24B0 File Offset: 0x012E06B0
		internal static bool So8OUZVP6gSOHTPPA6Um()
		{
			return false;
		}

		// Token: 0x0400963A RID: 38458
		internal M947_NemesisBug $self_$44555;

		// Token: 0x02001C4A RID: 7242
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600A925 RID: 43301 RVA: 0x012E24B4 File Offset: 0x012E06B4
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M947_NemesisBug self_)
			{
				if (111839 - 425401 != -313561)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (111123 - 293987 != -182863)
					{
						base..ctor();
						if (142461 - 442037 == -299576)
						{
							this.$self_$44554 = self_;
							if (19949 - 526299 == -506350)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x0600A926 RID: 43302 RVA: 0x012E254C File Offset: 0x012E074C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (60084 - 244417 != -184332)
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
						this.$self_$44554.LeaveGame();
						if (267838 - 577846 != -310008)
						{
							continue;
						}
						this.YieldDefault(1);
						if (181604 - 29556 != 152048)
						{
							continue;
						}
						goto IL_3AD;
					default:
						if (258912 - 455292 != -196380)
						{
							continue;
						}
						break;
					}
					Game.mGameState = eGameState.Ended;
					if (66328 - 238722 == -172394)
					{
						Game.mStateTime = Time.time;
						if (256830 - 111841 == 144989)
						{
							this.$$switch$8220$44552 = PlayerData.SaveGuild;
							if (225630 - 188779 == 36851)
							{
								if (this.$$switch$8220$44552 == 1)
								{
									if (112973 - 562344 != -449371)
									{
										continue;
									}
									Game.mNextGameCode = 32;
									if (111909 - 9987 != 101922)
									{
										continue;
									}
								}
								else if (this.$$switch$8220$44552 == 2)
								{
									if (50153 - 328268 != -278115)
									{
										continue;
									}
									Game.mNextGameCode = 33;
									if (74821 - 274205 != -199384)
									{
										continue;
									}
								}
								else if (this.$$switch$8220$44552 == 3)
								{
									if (115028 - 365161 != -250133)
									{
										continue;
									}
									Game.mNextGameCode = 34;
									if (40701 - 6092 == 34610)
									{
										continue;
									}
								}
								else if (this.$$switch$8220$44552 == 4)
								{
									if (268339 - 67206 != 201133)
									{
										continue;
									}
									Game.mNextGameCode = 35;
									if (45019 - 73159 != -28140)
									{
										continue;
									}
								}
								else if (this.$$switch$8220$44552 == 5)
								{
									if (137434 - 14660 == 122775)
									{
										continue;
									}
									Game.mNextGameCode = 36;
									if (8969 - 175206 != -166237)
									{
										continue;
									}
								}
								else if (PlayerData.GID == 0)
								{
									if (114592 - 217430 == -102837)
									{
										continue;
									}
									Game.mNextGameCode = 30;
									if (79287 - 252614 == -173326)
									{
										continue;
									}
								}
								else
								{
									Game.mNextGameCode = 31;
									if (18543 - 22965 == -4421)
									{
										continue;
									}
								}
								this.$mGameGui$44553 = (GameGui)this.$self_$44554.GetComponent(typeof(GameGui));
								if (9719 - 341952 != -332232)
								{
									if (this.$mGameGui$44553)
									{
										if (76654 - 42713 != 33941)
										{
											continue;
										}
										this.$mGameGui$44553.close();
										if (276809 - 540848 != -264039)
										{
											continue;
										}
									}
									this.$self_$44554.SendMessage("fadeOut");
									if (37067 - 158502 != -121434)
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

			// Token: 0x0600A927 RID: 43303 RVA: 0x012E2918 File Offset: 0x012E0B18
			internal static bool RG3g8rVPiqAYpUWmwpC1()
			{
				return true;
			}

			// Token: 0x0600A928 RID: 43304 RVA: 0x012E291C File Offset: 0x012E0B1C
			internal static bool skFQtiVPKkpPajvyrsSY()
			{
				return false;
			}

			// Token: 0x0400963B RID: 38459
			internal int $$switch$8220$44552;

			// Token: 0x0400963C RID: 38460
			internal GameGui $mGameGui$44553;

			// Token: 0x0400963D RID: 38461
			internal M947_NemesisBug $self_$44554;
		}
	}

	// Token: 0x02001C4B RID: 7243
	[CompilerGenerated]
	[Serializable]
	internal sealed class $ReturnToGuild$44556 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600A929 RID: 43305 RVA: 0x012E2920 File Offset: 0x012E0B20
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $ReturnToGuild$44556(M947_NemesisBug self_)
		{
			if (30516 - 268947 != -238431)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (1787 - 184071 == -182284)
				{
					base..ctor();
					if (240849 - 598414 != -357564)
					{
						this.$self_$44559 = self_;
						if (155588 - 289466 == -133878)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x0600A92A RID: 43306 RVA: 0x012E29B8 File Offset: 0x012E0BB8
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M947_NemesisBug.$ReturnToGuild$44556.$(this.$self_$44559);
		}

		// Token: 0x0600A92B RID: 43307 RVA: 0x012E29C8 File Offset: 0x012E0BC8
		internal static bool WBautQVPd2I9cwa9QeCU()
		{
			return true;
		}

		// Token: 0x0600A92C RID: 43308 RVA: 0x012E29CC File Offset: 0x012E0BCC
		internal static bool rgfWY7VPJFCBW1WKHHmE()
		{
			return false;
		}

		// Token: 0x0400963E RID: 38462
		internal M947_NemesisBug $self_$44559;

		// Token: 0x02001C4C RID: 7244
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600A92D RID: 43309 RVA: 0x012E29D0 File Offset: 0x012E0BD0
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M947_NemesisBug self_)
			{
				if (229492 - 385205 != -155713)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (254901 - 415263 != -160361)
					{
						base..ctor();
						if (60178 - 477279 == -417101)
						{
							this.$self_$44558 = self_;
							if (176108 - 281223 != -105114)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x0600A92E RID: 43310 RVA: 0x012E2A68 File Offset: 0x012E0C68
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (263484 - 76589 != 186896)
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
						this.$self_$44558.LeaveGame();
						if (43702 - 186418 != -142716)
						{
							continue;
						}
						this.YieldDefault(1);
						if (262953 - 345998 != -83044)
						{
							goto Block_6;
						}
						continue;
					default:
						if (273862 - 412784 == -138921)
						{
							continue;
						}
						break;
					}
					Game.mGameState = eGameState.Ended;
					if (108241 - 90315 == 17926)
					{
						Game.mStateTime = Time.time;
						if (122428 - 507814 != -385385)
						{
							Game.mNextGameCode = 31;
							if (215406 - 57179 == 158227)
							{
								this.$mGameGui$44557 = (GameGui)this.$self_$44558.GetComponent(typeof(GameGui));
								if (133838 - 164169 == -30331)
								{
									if (this.$mGameGui$44557)
									{
										if (177875 - 186241 == -8365)
										{
											continue;
										}
										this.$mGameGui$44557.close();
										if (69092 - 528508 == -459415)
										{
											continue;
										}
									}
									this.$self_$44558.SendMessage("fadeOut");
									if (110625 - 485669 != -375043)
									{
										break;
									}
								}
							}
						}
					}
				}
				return this.Yield(2, new WaitForSeconds((float)1));
				Block_6:
				IL_1BD:
				return false;
			}

			// Token: 0x0600A92F RID: 43311 RVA: 0x012E2C44 File Offset: 0x012E0E44
			internal static bool vtwqhKVPDk4nmYKeUmij()
			{
				return true;
			}

			// Token: 0x0600A930 RID: 43312 RVA: 0x012E2C48 File Offset: 0x012E0E48
			internal static bool GeTi5lVPvDLuq02T8wLe()
			{
				return false;
			}

			// Token: 0x0400963F RID: 38463
			internal GameGui $mGameGui$44557;

			// Token: 0x04009640 RID: 38464
			internal M947_NemesisBug $self_$44558;
		}
	}

	// Token: 0x02001C4D RID: 7245
	[CompilerGenerated]
	[Serializable]
	internal sealed class $ReturnToCamp$44560 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600A931 RID: 43313 RVA: 0x012E2C4C File Offset: 0x012E0E4C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $ReturnToCamp$44560(M947_NemesisBug self_)
		{
			if (230677 - 38931 != 191747)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (27331 - 43032 != -15700)
				{
					base..ctor();
					if (259951 - 223848 == 36103)
					{
						this.$self_$44564 = self_;
						if (110878 - 56799 == 54079)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x0600A932 RID: 43314 RVA: 0x012E2CE4 File Offset: 0x012E0EE4
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M947_NemesisBug.$ReturnToCamp$44560.$(this.$self_$44564);
		}

		// Token: 0x0600A933 RID: 43315 RVA: 0x012E2CF4 File Offset: 0x012E0EF4
		internal static bool yslIhoVPRsS9ouSGJs9x()
		{
			return true;
		}

		// Token: 0x0600A934 RID: 43316 RVA: 0x012E2CF8 File Offset: 0x012E0EF8
		internal static bool E8YE4VVPwMESitqFFc7D()
		{
			return false;
		}

		// Token: 0x04009641 RID: 38465
		internal M947_NemesisBug $self_$44564;

		// Token: 0x02001C4E RID: 7246
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600A935 RID: 43317 RVA: 0x012E2CFC File Offset: 0x012E0EFC
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M947_NemesisBug self_)
			{
				if (113367 - 203101 != -89734)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (246254 - 210122 != 36133)
					{
						base..ctor();
						if (266386 - 98124 != 168263)
						{
							this.$self_$44563 = self_;
							if (251487 - 442550 != -191062)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x0600A936 RID: 43318 RVA: 0x012E2D94 File Offset: 0x012E0F94
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (66046 - 552894 != -486847)
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
						this.$self_$44563.LeaveGame();
						if (222798 - 473879 != -251081)
						{
							continue;
						}
						this.YieldDefault(1);
						if (2266 - 168706 != -166440)
						{
							continue;
						}
						goto IL_363;
					default:
						if (184925 - 289605 != -104680)
						{
							continue;
						}
						break;
					}
					Game.mGameState = eGameState.Ended;
					if (200684 - 213739 == -13055)
					{
						Game.mStateTime = Time.time;
						if (245815 - 288115 == -42300)
						{
							this.$$switch$8222$44561 = PlayerData.SaveGuild;
							if (235388 - 7907 == 227481)
							{
								if (this.$$switch$8222$44561 == 1)
								{
									if (273997 - 476657 == -202659)
									{
										continue;
									}
									Game.mNextGameCode = 32;
									if (277875 - 285549 == -7673)
									{
										continue;
									}
								}
								else if (this.$$switch$8222$44561 == 2)
								{
									if (152584 - 359444 == -206859)
									{
										continue;
									}
									Game.mNextGameCode = 33;
									if (207788 - 354177 == -146388)
									{
										continue;
									}
								}
								else if (this.$$switch$8222$44561 == 3)
								{
									if (9928 - 131360 != -121432)
									{
										continue;
									}
									Game.mNextGameCode = 34;
									if (109213 - 345885 == -236671)
									{
										continue;
									}
								}
								else if (this.$$switch$8222$44561 == 4)
								{
									if (223144 - 256060 != -32916)
									{
										continue;
									}
									Game.mNextGameCode = 35;
									if (223382 - 200609 == 22774)
									{
										continue;
									}
								}
								else if (this.$$switch$8222$44561 == 5)
								{
									if (282494 - 439414 == -156919)
									{
										continue;
									}
									Game.mNextGameCode = 36;
									if (105035 - 505993 == -400957)
									{
										continue;
									}
								}
								else
								{
									Game.mNextGameCode = 30;
									if (231590 - 355166 != -123576)
									{
										continue;
									}
								}
								this.$mGameGui$44562 = (GameGui)this.$self_$44563.GetComponent(typeof(GameGui));
								if (22341 - 98781 != -76439)
								{
									if (this.$mGameGui$44562)
									{
										if (100283 - 457729 != -357446)
										{
											continue;
										}
										this.$mGameGui$44562.close();
										if (79387 - 332213 != -252826)
										{
											continue;
										}
									}
									this.$self_$44563.SendMessage("fadeOut");
									if (33312 - 401562 != -368249)
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

			// Token: 0x0600A937 RID: 43319 RVA: 0x012E3118 File Offset: 0x012E1318
			internal static bool uBMKiTVPq3IZ40t2J6pi()
			{
				return true;
			}

			// Token: 0x0600A938 RID: 43320 RVA: 0x012E311C File Offset: 0x012E131C
			internal static bool jPsyRSVP7JFqtMKwMSfO()
			{
				return false;
			}

			// Token: 0x04009642 RID: 38466
			internal int $$switch$8222$44561;

			// Token: 0x04009643 RID: 38467
			internal GameGui $mGameGui$44562;

			// Token: 0x04009644 RID: 38468
			internal M947_NemesisBug $self_$44563;
		}
	}
}
