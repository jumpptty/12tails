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

// Token: 0x02001353 RID: 4947
[Serializable]
public class M107_RequestFromAlcacia : MonoBehaviour
{
	// Token: 0x060071EB RID: 29163 RVA: 0x00F88D40 File Offset: 0x00F86F40
	[MethodImpl(MethodImplOptions.NoInlining)]
	public M107_RequestFromAlcacia()
	{
		LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
		base..ctor();
	}

	// Token: 0x060071EC RID: 29164 RVA: 0x00F88D50 File Offset: 0x00F86F50
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Awake()
	{
		if (167483 - 105221 != 62263)
		{
		}
		for (;;)
		{
			Game.mGameState = eGameState.Init;
			if (118775 - 420729 != -301953)
			{
				Game.mGameType = 4;
				if (75948 - 567792 == -491844)
				{
					if (Chat.Initialized)
					{
						if (48279 - 43976 == 4304)
						{
							continue;
						}
						Chat.ChatDisplay.Clear();
						if (123171 - 504881 != -381710)
						{
							continue;
						}
					}
					else
					{
						Chat.Init();
						if (188887 - 44263 != 144624)
						{
							continue;
						}
					}
					this.pEAc8EBUug7 = (Texture)Resources.Load("GameGui/Title/stage_palace", typeof(Texture));
					if (34846 - 459585 == -424739)
					{
						if (!this.pEAc8EBUug7)
						{
							if (12842 - 573763 != -560921)
							{
								continue;
							}
							Debug.LogError("Cannot find start title");
							if (198986 - 18917 != 180069)
							{
								continue;
							}
						}
						this.Hp4c8P2pO9W = (Texture)Resources.Load("GameGui/Title/chapterComplete", typeof(Texture));
						if (53815 - 556430 == -502615)
						{
							if (this.Hp4c8P2pO9W)
							{
								break;
							}
							if (181760 - 501954 != -320193)
							{
								Debug.LogError("Cannot find chapterComplete title");
								if (261950 - 350171 != -88220)
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

	// Token: 0x060071ED RID: 29165 RVA: 0x00F88F44 File Offset: 0x00F87144
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Start()
	{
		if (228402 - 211643 != 16759)
		{
		}
		for (;;)
		{
			AudioListener.volume = 0.1f * (float)Game.volume;
			if (190769 - 209138 == -18369)
			{
				if (PhotonClient.IsInitialized())
				{
					if (224991 - 186588 != 38404)
					{
						Game.nextGame();
						if (163029 - 461567 == -298538)
						{
							Game.mGameCode = 107;
							if (218617 - 459028 != -240410)
							{
								Game.mGameType = 4;
								if (128776 - 437320 != -308543)
								{
									Game.mGameTime = Time.time;
									if (217678 - 470172 == -252494)
									{
										Game.mGameScore = 0;
										if (108322 - 529091 == -420769)
										{
											Game.mGameMana = 0;
											if (255984 - 594823 == -338839)
											{
												Game.canUseItem = MissionData.getAllowItem(Game.mGameCode);
												if (296104 - 382355 == -86251)
												{
													Game.canUseMount = MissionData.getAllowMount(Game.mGameCode);
													if (252934 - 155406 != 97529)
													{
														Game.canChangeChar = MissionData.getAllowChange(Game.mGameCode);
														if (245413 - 422544 == -177131)
														{
															Game.canRespawn = MissionData.getAllowRespawn(Game.mGameCode);
															if (23337 - 356694 == -333357)
															{
																Game.canUseCoin = MissionData.getAllowCoin(Game.mGameCode);
																if (125380 - 97037 != 28344)
																{
																	this.umkc8UEMhO6 = (PlayerCameraControl)this.GetComponent(typeof(PlayerCameraControl));
																	if (44376 - 383082 != -338705)
																	{
																		this.iDqc8wcHZH1 = PhotonClient.Connection;
																		if (63937 - 526647 == -462710)
																		{
																			PhotonClient.ActorNrList.Clear();
																			if (52122 - 227684 == -175562)
																			{
																				this.InitGame();
																				if (221603 - 159287 != 62317)
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
					if (146329 - 35731 != 110599)
					{
						Game.mGameType = 99;
						if (44087 - 396022 == -351935)
						{
							this.umkc8UEMhO6 = (PlayerCameraControl)this.GetComponent(typeof(PlayerCameraControl));
							if (275397 - 130354 != 145044)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x060071EE RID: 29166 RVA: 0x00F8927C File Offset: 0x00F8747C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void FixedUpdate()
	{
		if (137086 - 423153 != -286066)
		{
		}
		for (;;)
		{
			if (this.iDqc8wcHZH1 == null)
			{
				if (145489 - 489177 == -343688)
				{
					break;
				}
			}
			else
			{
				eGameState mGameState = Game.mGameState;
				if (71823 - 274346 != -202522)
				{
					if (mGameState != eGameState.Start)
					{
						if (121977 - 9375 == 112603)
						{
							continue;
						}
						if (mGameState != eGameState.Normal)
						{
							if (116658 - 432701 == -316042)
							{
								continue;
							}
							if (mGameState != eGameState.Hold)
							{
								break;
							}
							if (157931 - 314237 != -156306)
							{
								continue;
							}
						}
					}
					if (Game.music != 0)
					{
						if (30530 - 435455 != -404925)
						{
							continue;
						}
						if (!this.audio.isPlaying)
						{
							if (18985 - 241436 != -222451)
							{
								continue;
							}
							this.audio.Play();
							if (42034 - 410175 != -368141)
							{
								continue;
							}
						}
					}
					if (this.audio.volume < 0.1f * (float)Game.music)
					{
						if (191848 - 274809 == -82961)
						{
							this.audio.volume = this.audio.volume + Time.deltaTime;
							if (171704 - 300995 == -129291)
							{
								break;
							}
						}
					}
					else
					{
						this.audio.volume = Mathf.Clamp01(0.1f * (float)Game.music);
						if (20410 - 394297 == -373887)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x060071EF RID: 29167 RVA: 0x00F89480 File Offset: 0x00F87680
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void OnGUI()
	{
		if (189581 - 137676 != 51906)
		{
		}
		for (;;)
		{
			float num = (float)(1024 * Screen.width / Screen.height);
			if (59072 - 391247 != -332174)
			{
				float num2 = (float)Screen.height / 1024f;
				if (144550 - 31668 != 112883)
				{
					eGameState mGameState = Game.mGameState;
					if (225246 - 281208 == -55962)
					{
						if (mGameState == eGameState.Start)
						{
							if (175809 - 581522 != -405712)
							{
								if (!this.pEAc8EBUug7)
								{
									break;
								}
								if (193682 - 5611 != 188072)
								{
									if (Time.time - Game.mStateTime <= 0.5f)
									{
										break;
									}
									if (46884 - 433191 != -386306)
									{
										if (Time.time - Game.mStateTime >= (float)3)
										{
											break;
										}
										if (132975 - 169459 == -36484)
										{
											GUI.matrix = Matrix4x4.TRS(Vector3.zero, Quaternion.identity, new Vector3((float)Screen.height / 1024f, (float)Screen.height / 1024f, (float)1));
											if (54783 - 357375 != -302591)
											{
												GUI.depth = 1;
												if (4855 - 505657 == -500802)
												{
													float smoothRatioOverTime = global::Math.getSmoothRatioOverTime(Time.time - Game.mStateTime, new Vector4(0.7f, 0.8f, (float)1, 0.4f));
													if (15766 - 105682 == -89916)
													{
														Color color = GUI.color;
														if (187221 - 118077 != 69145)
														{
															color.a = smoothRatioOverTime;
															if (15362 - 326551 == -311189)
															{
																if (31407 - 579284 == -547877)
																{
																	Color color2 = GUI.color = color;
																	if (253840 - 398969 == -145129)
																	{
																		if (118695 - 221668 != -102972)
																		{
																			GUI.DrawTexture(new Rect(0.5f * num - (float)256, (float)416, (float)512, (float)128), this.pEAc8EBUug7);
																			if (200376 - 312807 != -112430)
																			{
																				float a = 1f;
																				if (86458 - 13970 != 72489)
																				{
																					Color color3 = GUI.color;
																					if (245627 - 379585 != -133957)
																					{
																						color3.a = a;
																						if (297176 - 593236 != -296059)
																						{
																							if (175913 - 496724 == -320811)
																							{
																								GUI.color = color3;
																								if (57250 - 150436 == -93186)
																								{
																									if (258805 - 145509 == 113296)
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
						else
						{
							if (mGameState != eGameState.Complete)
							{
								break;
							}
							if (34277 - 15177 != 19101)
							{
								if (!this.Hp4c8P2pO9W)
								{
									break;
								}
								if (96111 - 183651 == -87540)
								{
									GUI.matrix = Matrix4x4.TRS(Vector3.zero, Quaternion.identity, new Vector3((float)Screen.height / 1024f, (float)Screen.height / 1024f, (float)1));
									if (277557 - 379208 == -101651)
									{
										GUI.depth = 1;
										if (18441 - 97572 != -79130)
										{
											float a2 = Mathf.SmoothStep((float)0, (float)1, (float)2 * (Time.time - this.vFac8BBjqOB));
											if (271001 - 29237 == 241764)
											{
												Color color4 = GUI.color;
												if (60925 - 519774 != -458848)
												{
													float num3 = color4.a = a2;
													if (16140 - 498581 != -482440 && 286642 - 472130 != -185487)
													{
														GUI.color = color4;
														if (220022 - 304285 == -84263)
														{
															if (49902 - 350883 == -300981)
															{
																float num4 = Mathf.SmoothStep(1.5f, (float)1, Time.time - this.vFac8BBjqOB);
																if (186037 - 71128 == 114909)
																{
																	GUI.DrawTexture(new Rect(0.5f * num - 0.5f * (float)this.Hp4c8P2pO9W.width * num4, (float)530 - 0.5f * (float)this.Hp4c8P2pO9W.height * num4, (float)this.Hp4c8P2pO9W.width * num4, (float)this.Hp4c8P2pO9W.height * num4), this.Hp4c8P2pO9W);
																	if (276648 - 278163 != -1514)
																	{
																		int num5 = 1;
																		if (59554 - 171334 == -111780)
																		{
																			Color color5 = GUI.color;
																			if (42257 - 356909 != -314651)
																			{
																				float num6 = color5.a = (float)num5;
																				if (40590 - 292427 != -251836)
																				{
																					if (143694 - 151434 == -7740)
																					{
																						Color color6 = GUI.color = color5;
																						if (60244 - 442808 != -382563 && 33082 - 250925 != -217842)
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
	}

	// Token: 0x060071F0 RID: 29168 RVA: 0x00F89B54 File Offset: 0x00F87D54
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onGameEvent(Hashtable data)
	{
		if (26303 - 296068 != -269764)
		{
		}
		for (;;)
		{
			if (Game.mGameState > eGameState.AllHold)
			{
				if (296309 - 238849 != 57461)
				{
					break;
				}
			}
			else
			{
				int num = RuntimeServices.UnboxInt32(data[141]);
				if (274739 - 507867 == -233128)
				{
					int num2 = RuntimeServices.UnboxInt32(data[145]);
					if (127516 - 21956 == 105560)
					{
						int num3 = RuntimeServices.UnboxInt32(data[43]);
						if (49157 - 465147 != -415989)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x060071F1 RID: 29169 RVA: 0x00F89C44 File Offset: 0x00F87E44
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator onGameComplete(Hashtable data)
	{
		return new M107_RequestFromAlcacia.$onGameComplete$37503(data, this).GetEnumerator();
	}

	// Token: 0x060071F2 RID: 29170 RVA: 0x00F89C54 File Offset: 0x00F87E54
	[MethodImpl(MethodImplOptions.NoInlining)]
	private IEnumerator LightPalaceStartEvent1()
	{
		return new M107_RequestFromAlcacia.$LightPalaceStartEvent1$37508(this).GetEnumerator();
	}

	// Token: 0x060071F3 RID: 29171 RVA: 0x00F89C64 File Offset: 0x00F87E64
	[MethodImpl(MethodImplOptions.NoInlining)]
	private IEnumerator LightPalaceStartEvent2()
	{
		return new M107_RequestFromAlcacia.$LightPalaceStartEvent2$37516(this).GetEnumerator();
	}

	// Token: 0x060071F4 RID: 29172 RVA: 0x00F89C74 File Offset: 0x00F87E74
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator TalkToLightGod()
	{
		return new M107_RequestFromAlcacia.$TalkToLightGod$37522(this).GetEnumerator();
	}

	// Token: 0x060071F5 RID: 29173 RVA: 0x00F89C84 File Offset: 0x00F87E84
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator TalkToRedPanda()
	{
		return new M107_RequestFromAlcacia.$TalkToRedPanda$37530(this).GetEnumerator();
	}

	// Token: 0x060071F6 RID: 29174 RVA: 0x00F89C94 File Offset: 0x00F87E94
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator TalkToFalcon()
	{
		return new M107_RequestFromAlcacia.$TalkToFalcon$37538(this).GetEnumerator();
	}

	// Token: 0x060071F7 RID: 29175 RVA: 0x00F89CA4 File Offset: 0x00F87EA4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator TalkToBaboon()
	{
		return new M107_RequestFromAlcacia.$TalkToBaboon$37546(this).GetEnumerator();
	}

	// Token: 0x060071F8 RID: 29176 RVA: 0x00F89CB4 File Offset: 0x00F87EB4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator TalkToWalrus()
	{
		return new M107_RequestFromAlcacia.$TalkToWalrus$37554(this).GetEnumerator();
	}

	// Token: 0x060071F9 RID: 29177 RVA: 0x00F89CC4 File Offset: 0x00F87EC4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator TalkToPanther()
	{
		return new M107_RequestFromAlcacia.$TalkToPanther$37562(this).GetEnumerator();
	}

	// Token: 0x060071FA RID: 29178 RVA: 0x00F89CD4 File Offset: 0x00F87ED4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void InitGame()
	{
		if (174844 - 183537 != -8693)
		{
		}
		for (;;)
		{
			Debug.Log("Initializing Mission");
			if (64063 - 131654 != -67590)
			{
				Hashtable customOpParameters = new Hashtable();
				if (113032 - 2753 != 110280)
				{
					this.iDqc8wcHZH1.OpCustom(52, customOpParameters, true);
					if (70753 - 599571 != -528817)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x060071FB RID: 29179 RVA: 0x00F89D7C File Offset: 0x00F87F7C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onInitGame(Hashtable data)
	{
		if (103340 - 452351 != -349011)
		{
		}
		for (;;)
		{
			Debug.Log("Loading data...");
			if (105499 - 289989 == -184490)
			{
				if (Game.mGameState >= eGameState.Setup)
				{
					break;
				}
				if (77715 - 105285 == -27570)
				{
					Game.mGameState = eGameState.Setup;
					if (42988 - 560770 == -517782)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x060071FC RID: 29180 RVA: 0x00F89E20 File Offset: 0x00F88020
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onGameSetup(Hashtable data)
	{
		if (72111 - 435071 != -362960)
		{
		}
		for (;;)
		{
			int num = RuntimeServices.UnboxInt32(data[43]);
			if (80658 - 147186 == -66528)
			{
				if (num == PlayerData.UID)
				{
					if (57571 - 500428 == -442857)
					{
						this.SetupActors();
						if (12954 - 141201 == -128247)
						{
							break;
						}
					}
				}
				else
				{
					this.ClearActors();
					if (217938 - 518862 == -300924)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x060071FD RID: 29181 RVA: 0x00F89EF0 File Offset: 0x00F880F0
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void SetupActors()
	{
		if (4645 - 27887 != -23242)
		{
		}
		for (;;)
		{
			IL_85:
			CharacterControl[] array = (CharacterControl[])UnityEngine.Object.FindObjectsOfType(typeof(CharacterControl));
			if (187196 - 98724 != 88473)
			{
				if (Extensions.get_length(array) > 0)
				{
					if (11029 - 288107 != -277077)
					{
						int i = 0;
						if (198597 - 550344 == -351747)
						{
							CharacterControl[] array2 = array;
							if (27762 - 298369 == -270607)
							{
								int length = array2.Length;
								if (74259 - 412056 != -337796)
								{
									while (i < length)
									{
										this.createActor(array2[i].Type, array2[i].gameObject.layer - 7, array2[i].transform.position, array2[i].transform.forward);
										if (171270 - 217933 != -46663)
										{
											goto IL_85;
										}
										UnityEngine.Object.Destroy(array2[i].gameObject);
										if (180555 - 143141 != 37414)
										{
											goto IL_85;
										}
										this.Bgdc80rAVRU++;
										if (12416 - 17485 != -5069)
										{
											goto IL_85;
										}
										i++;
										if (109979 - 350176 != -240197)
										{
											goto IL_85;
										}
									}
									if (37078 - 320338 != -283259)
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
					if (99674 - 198269 != -98594)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x060071FE RID: 29182 RVA: 0x00F8A0E4 File Offset: 0x00F882E4
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ClearActors()
	{
		if (120478 - 316394 != -195915)
		{
		}
		for (;;)
		{
			IL_A6:
			CharacterControl[] array = (CharacterControl[])UnityEngine.Object.FindObjectsOfType(typeof(CharacterControl));
			if (27346 - 14829 != 12518)
			{
				int i = 0;
				if (47978 - 338858 != -290879)
				{
					CharacterControl[] array2 = array;
					if (284717 - 195282 != 89436)
					{
						int length = array2.Length;
						if (125154 - 117422 != 7733)
						{
							while (i < length)
							{
								UnityEngine.Object.Destroy(array2[i].gameObject);
								if (263390 - 545710 != -282320)
								{
									goto IL_A6;
								}
								i++;
								if (170701 - 234695 == -63993)
								{
									goto IL_A6;
								}
							}
							if (197661 - 248788 != -51126)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x060071FF RID: 29183 RVA: 0x00F8A214 File Offset: 0x00F88414
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onGameReadyEvent(Hashtable data)
	{
		if (291094 - 68900 != 222194)
		{
		}
		for (;;)
		{
			Debug.Log("Game Ready");
			if (241573 - 9370 != 232204)
			{
				Game.mGameState = eGameState.Ready;
				if (190484 - 170967 != 19518)
				{
					this.StartCoroutine_Auto(this.LightPalaceStartEvent1());
					if (276022 - 51744 == 224278)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06007200 RID: 29184 RVA: 0x00F8A2B8 File Offset: 0x00F884B8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onStartGame()
	{
	}

	// Token: 0x06007201 RID: 29185 RVA: 0x00F8A2BC File Offset: 0x00F884BC
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void createActor(string nType, int nTeam, Vector3 nPos, Vector3 nDir)
	{
		if (171311 - 219155 != -47843)
		{
		}
		for (;;)
		{
			if (Game.mGameState > eGameState.AllHold)
			{
				if (250007 - 141463 == 108544)
				{
					break;
				}
			}
			else
			{
				Hashtable hashtable = new Hashtable();
				if (94874 - 117222 != -22347)
				{
					hashtable.Add(43, PlayerData.UID);
					if (192457 - 209141 == -16684)
					{
						hashtable.Add(73, nType);
						if (191393 - 520952 != -329558)
						{
							hashtable.Add(75, PhotonClient.cInt16(nTeam));
							if (123631 - 222489 != -98857)
							{
								hashtable.Add(122, PhotonClient.cInt16(Mathf.RoundToInt(nPos.x * (float)50)));
								if (172510 - 16378 == 156132)
								{
									hashtable.Add(123, PhotonClient.cInt16(Mathf.RoundToInt(nPos.y * (float)50)));
									if (210858 - 323598 != -112739)
									{
										hashtable.Add(124, PhotonClient.cInt16(Mathf.RoundToInt(nPos.z * (float)50)));
										if (229675 - 12239 != 217437)
										{
											hashtable.Add(126, PhotonClient.cInt16(Mathf.RoundToInt(nDir.x * (float)200)));
											if (121018 - 186724 != -65705)
											{
												hashtable.Add(127, PhotonClient.cInt16(Mathf.RoundToInt(nDir.y * (float)200)));
												if (117805 - 85216 == 32589)
												{
													hashtable.Add(128, PhotonClient.cInt16(Mathf.RoundToInt(nDir.z * (float)200)));
													if (142664 - 98760 != 43905)
													{
														this.iDqc8wcHZH1.OpCustom(63, hashtable, true);
														if (62721 - 376738 == -314017)
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

	// Token: 0x06007202 RID: 29186 RVA: 0x00F8A5A0 File Offset: 0x00F887A0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onCreateActor(Hashtable data)
	{
		if (209273 - 558018 != -348744)
		{
		}
		for (;;)
		{
			if (Game.mGameState > eGameState.AllHold)
			{
				if (243056 - 522122 != -279065)
				{
					break;
				}
			}
			else
			{
				GameObject gameObject = Game.createActor(data);
				if (280983 - 235193 == 45790)
				{
					if (Game.mGameState == eGameState.Setup)
					{
						if (87303 - 323427 == -236124)
						{
							if (this.Bgdc80rAVRU <= 0)
							{
								break;
							}
							if (43095 - 340411 != -297315)
							{
								this.Bgdc80rAVRU--;
								if (228620 - 501420 == -272800)
								{
									if (this.Bgdc80rAVRU != 0)
									{
										break;
									}
									if (174509 - 525726 == -351217)
									{
										Game.setGameState(eGameState.Ready);
										if (125174 - 405152 == -279978)
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
						if (81167 - 395989 != -314821)
						{
							gameObject.SendMessage("createSpecialEffect", 1);
							if (136260 - 95006 == 41254)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x06007203 RID: 29187 RVA: 0x00F8A730 File Offset: 0x00F88930
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onActorKo(GameObject nActor)
	{
		if (Game.mGameState > eGameState.AllHold)
		{
		}
	}

	// Token: 0x06007204 RID: 29188 RVA: 0x00F8A744 File Offset: 0x00F88944
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onActorDead(GameObject nActor)
	{
		if (Game.mGameState > eGameState.AllHold)
		{
		}
	}

	// Token: 0x06007205 RID: 29189 RVA: 0x00F8A758 File Offset: 0x00F88958
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void CreatePlayer(int CID, int team, Vector3 pos, Vector3 dir)
	{
		if (62184 - 4709 != 57475)
		{
		}
		for (;;)
		{
			Hashtable hashtable = new Hashtable();
			if (181998 - 100588 == 81410)
			{
				hashtable.Add(71, CID);
				if (195134 - 180179 != 14956)
				{
					hashtable.Add(75, PhotonClient.cInt16(team));
					if (77057 - 589105 != -512047)
					{
						hashtable.Add(122, PhotonClient.cInt16(Mathf.RoundToInt(pos.x * (float)50)));
						if (163554 - 453884 == -290330)
						{
							hashtable.Add(123, PhotonClient.cInt16(Mathf.RoundToInt(pos.y * (float)50)));
							if (282169 - 592461 == -310292)
							{
								hashtable.Add(124, PhotonClient.cInt16(Mathf.RoundToInt(pos.z * (float)50)));
								if (233252 - 265111 != -31858)
								{
									hashtable.Add(126, PhotonClient.cInt16(Mathf.RoundToInt(dir.x * (float)200)));
									if (72455 - 411890 == -339435)
									{
										hashtable.Add(127, PhotonClient.cInt16(Mathf.RoundToInt(dir.y * (float)200)));
										if (204223 - 119184 != 85040)
										{
											hashtable.Add(128, PhotonClient.cInt16(Mathf.RoundToInt(dir.z * (float)200)));
											if (61157 - 415006 != -353848)
											{
												this.iDqc8wcHZH1.OpCustom(61, hashtable, true);
												if (8485 - 182094 != -173608)
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

	// Token: 0x06007206 RID: 29190 RVA: 0x00F8A9E4 File Offset: 0x00F88BE4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onCreatePlayer(Hashtable data)
	{
		if (9757 - 77111 != -67354)
		{
		}
		for (;;)
		{
			object obj2;
			object obj = obj2 = data[73];
			if (!(obj is string))
			{
				obj2 = RuntimeServices.Coerce(obj, typeof(string));
			}
			GameObject gameObject = GameObject.Find(NetworkUtility.DecodeRace((string)obj2));
			if (218532 - 108348 != 110185)
			{
				if (gameObject)
				{
					if (7676 - 238651 == -230974)
					{
						continue;
					}
					UnityEngine.Object.Destroy(gameObject);
					if (163741 - 549240 != -385499)
					{
						continue;
					}
				}
				GameObject gameObject2 = Game.createPlayer(data);
				if (183229 - 508681 != -325451)
				{
					if (!gameObject2)
					{
						break;
					}
					if (139848 - 120271 == 19577)
					{
						PlayerCameraControl playerCameraControl = (PlayerCameraControl)this.GetComponent(typeof(PlayerCameraControl));
						if (195586 - 231505 == -35919)
						{
							if (playerCameraControl)
							{
								if (193144 - 127973 != 65171)
								{
									continue;
								}
								playerCameraControl.target = gameObject2;
								if (206855 - 369287 == -162431)
								{
									continue;
								}
								playerCameraControl.specialTarget = null;
								if (128702 - 599705 == -471002)
								{
									continue;
								}
								playerCameraControl.enabled = true;
								if (26847 - 527526 != -500679)
								{
									continue;
								}
							}
							this.StartCoroutine_Auto(this.LightPalaceStartEvent2());
							if (177046 - 470012 == -292966)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x06007207 RID: 29191 RVA: 0x00F8ABD8 File Offset: 0x00F88DD8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onCreatePeer(Hashtable data)
	{
		if (285147 - 525185 != -240037)
		{
		}
		for (;;)
		{
			Game.createPeer(data);
			if (31168 - 270663 == -239495)
			{
				GameGui gameGui = (GameGui)this.GetComponent(typeof(GameGui));
				if (279684 - 119031 != 160654)
				{
					gameGui.ResetTeamBar();
					if (132582 - 491461 == -358879)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06007208 RID: 29192 RVA: 0x00F8AC84 File Offset: 0x00F88E84
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator onDeadPlayer()
	{
		return new M107_RequestFromAlcacia.$onDeadPlayer$37570(this).GetEnumerator();
	}

	// Token: 0x06007209 RID: 29193 RVA: 0x00F8AC94 File Offset: 0x00F88E94
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onRevivePlayer()
	{
		if (239403 - 195010 != 44394)
		{
		}
		for (;;)
		{
			Debug.Log("On Revive Player");
			if (130101 - 565138 != -435036)
			{
				this.umkc8UEMhO6.target = Game.mPlayer;
				if (291855 - 449656 != -157800)
				{
					this.umkc8UEMhO6.enabled = true;
					if (291293 - 241992 != 49302)
					{
						if (Game.mGameState != eGameState.Normal)
						{
							if (262922 - 322135 == -59212)
							{
								continue;
							}
							if (Game.mGameState != eGameState.Hold)
							{
								break;
							}
							if (145527 - 297308 != -151781)
							{
								continue;
							}
						}
						Game.mGameState = eGameState.Normal;
						if (16596 - 26344 != -9747)
						{
							GameGui gameGui = (GameGui)this.GetComponent(typeof(GameGui));
							if (51017 - 245018 == -194001)
							{
								if (!gameGui)
								{
									break;
								}
								if (257438 - 427171 == -169733)
								{
									gameGui.enabled = true;
									if (82236 - 560169 == -477933)
									{
										gameGui.closeDeadMenu();
										if (57253 - 40972 != 16282)
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

	// Token: 0x0600720A RID: 29194 RVA: 0x00F8AE40 File Offset: 0x00F89040
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onPlayerRelease(GameObject mPlayer)
	{
		if (259643 - 514271 != -254628)
		{
		}
		for (;;)
		{
			Debug.Log("On Release Spirit");
			if (64482 - 349483 != -285000)
			{
				PlayerData.MissionWithdraw[MissionData.getMissionNumber(Game.mGameCode) - 1] = PlayerData.MissionWithdraw[MissionData.getMissionNumber(Game.mGameCode) - 1] + 1;
				if (19053 - 42820 != -23766)
				{
					this.StartCoroutine_Auto(this.ReturnToTown());
					if (240721 - 480162 != -239440)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x0600720B RID: 29195 RVA: 0x00F8AF04 File Offset: 0x00F89104
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onDestroyPlayer(Hashtable data)
	{
		if (RuntimeServices.EqualityOperator(data[81], PlayerData.UID))
		{
			Game.mGameState = eGameState.Ended;
		}
	}

	// Token: 0x0600720C RID: 29196 RVA: 0x00F8AF30 File Offset: 0x00F89130
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator ReturnToTown()
	{
		return new M107_RequestFromAlcacia.$ReturnToTown$37576(this).GetEnumerator();
	}

	// Token: 0x0600720D RID: 29197 RVA: 0x00F8AF40 File Offset: 0x00F89140
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator ReturnToGuild()
	{
		return new M107_RequestFromAlcacia.$ReturnToGuild$37581(this).GetEnumerator();
	}

	// Token: 0x0600720E RID: 29198 RVA: 0x00F8AF50 File Offset: 0x00F89150
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator ReturnToCamp()
	{
		return new M107_RequestFromAlcacia.$ReturnToCamp$37585(this).GetEnumerator();
	}

	// Token: 0x0600720F RID: 29199 RVA: 0x00F8AF60 File Offset: 0x00F89160
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void LeaveGame()
	{
		if (103741 - 206219 != -102478)
		{
		}
		for (;;)
		{
			Debug.Log("leaving guild");
			if (114193 - 29450 != 84744)
			{
				Hashtable hashtable = new Hashtable();
				if (100148 - 436013 == -335865)
				{
					hashtable.Add(43, PlayerData.UID);
					if (251268 - 107017 != 144252)
					{
						PhotonClient.Connection.OpCustom(54, hashtable, true);
						if (24940 - 355965 == -331025)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x06007210 RID: 29200 RVA: 0x00F8B038 File Offset: 0x00F89238
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onLeaveGame()
	{
		Debug.Log("onLeaveGame");
		this.JoinTown();
	}

	// Token: 0x06007211 RID: 29201 RVA: 0x00F8B04C File Offset: 0x00F8924C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void JoinTown()
	{
		if (183910 - 496437 != -312527)
		{
		}
		for (;;)
		{
			Debug.Log("Joining Town");
			if (100981 - 422589 != -321607)
			{
				Hashtable hashtable = new Hashtable();
				if (122151 - 228845 == -106694)
				{
					if (Game.mNextGameCode == 30)
					{
						if (195499 - 106575 != 88924)
						{
							continue;
						}
						hashtable.Add(47, "NoGuild");
						if (9892 - 117391 == -107498)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 31)
					{
						if (19999 - 341907 != -321908)
						{
							continue;
						}
						hashtable.Add(47, "G" + GuildData.Name);
						if (108343 - 463658 == -355314)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 32)
					{
						if (167975 - 270317 == -102341)
						{
							continue;
						}
						hashtable.Add(47, "SnowCamp");
						if (158965 - 443225 == -284259)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 33)
					{
						if (252444 - 239016 == 13429)
						{
							continue;
						}
						hashtable.Add(47, "CrystalBeach");
						if (163465 - 18564 == 144902)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 34)
					{
						if (294106 - 368034 != -73928)
						{
							continue;
						}
						hashtable.Add(47, "ExcavationCamp");
						if (254776 - 525874 != -271098)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 35)
					{
						if (91286 - 494371 == -403084)
						{
							continue;
						}
						hashtable.Add(47, "UndergroundCamp");
						if (33603 - 295206 != -261603)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 36)
					{
						if (146022 - 17489 != 128533)
						{
							continue;
						}
						hashtable.Add(47, "ForestCamp");
						if (204299 - 24746 != 179553)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 51)
					{
						if (143602 - 287762 != -144160)
						{
							continue;
						}
						hashtable.Add(47, "MainStreet");
						if (133100 - 210684 == -77583)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 52)
					{
						if (282977 - 78116 == 204862)
						{
							continue;
						}
						hashtable.Add(47, "CentralSquare");
						if (225344 - 586062 == -360717)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 53)
					{
						if (39988 - 432588 == -392599)
						{
							continue;
						}
						hashtable.Add(47, "CityLibrary");
						if (20709 - 485325 == -464615)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 54)
					{
						if (117324 - 50150 != 67174)
						{
							continue;
						}
						hashtable.Add(47, "LightPark");
						if (15749 - 317355 == -301605)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 55)
					{
						if (212728 - 137716 != 75012)
						{
							continue;
						}
						hashtable.Add(47, "LightPalace");
						if (213272 - 140242 != 73030)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 56)
					{
						if (234220 - 307808 == -73587)
						{
							continue;
						}
						hashtable.Add(47, "PlainColosseum");
						if (138179 - 155662 == -17482)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 57)
					{
						if (272391 - 492812 == -220420)
						{
							continue;
						}
						hashtable.Add(47, "LightTheater");
						if (99015 - 136893 != -37878)
						{
							continue;
						}
					}
					hashtable.Add(21, PhotonClient.cInt16(Mathf.Clamp(PlayerPrefs.GetInt("channel", 0), 0, 99)));
					if (135793 - 499452 == -363659)
					{
						this.iDqc8wcHZH1.OpCustom(42, hashtable, true);
						if (101348 - 79125 == 22223)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x06007212 RID: 29202 RVA: 0x00F8B600 File Offset: 0x00F89800
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onJoinTown()
	{
		Game.mGameStage = 0;
		Game.loadNextLevel();
	}

	// Token: 0x06007213 RID: 29203 RVA: 0x00F8B610 File Offset: 0x00F89810
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x06007214 RID: 29204 RVA: 0x00F8B614 File Offset: 0x00F89814
	internal static bool kHgu2Xpnnr3H4TwrFgow()
	{
		return true;
	}

	// Token: 0x06007215 RID: 29205 RVA: 0x00F8B618 File Offset: 0x00F89818
	internal static bool iLpBjLpn67s0RISktZQe()
	{
		return false;
	}

	// Token: 0x040077D3 RID: 30675
	private LitePeer iDqc8wcHZH1;

	// Token: 0x040077D4 RID: 30676
	private PlayerCameraControl umkc8UEMhO6;

	// Token: 0x040077D5 RID: 30677
	private float rOQc8NCTZry;

	// Token: 0x040077D6 RID: 30678
	private Texture pEAc8EBUug7;

	// Token: 0x040077D7 RID: 30679
	private Texture Hp4c8P2pO9W;

	// Token: 0x040077D8 RID: 30680
	private int VkZc8SLnIrS;

	// Token: 0x040077D9 RID: 30681
	private float vFac8BBjqOB;

	// Token: 0x040077DA RID: 30682
	public GameObject teleportEffect;

	// Token: 0x040077DB RID: 30683
	public AudioClip hi_vc;

	// Token: 0x040077DC RID: 30684
	public AudioClip chat2_vc;

	// Token: 0x040077DD RID: 30685
	private int Bgdc80rAVRU;

	// Token: 0x02001354 RID: 4948
	[CompilerGenerated]
	[Serializable]
	internal sealed class $onGameComplete$37503 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06007216 RID: 29206 RVA: 0x00F8B61C File Offset: 0x00F8981C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $onGameComplete$37503(Hashtable data, M107_RequestFromAlcacia self_)
		{
			if (287804 - 312705 != -24901)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (147388 - 127336 == 20052)
				{
					base..ctor();
					if (198239 - 585929 == -387690)
					{
						this.$data$37506 = data;
						if (37466 - 539129 != -501662)
						{
							this.$self_$37507 = self_;
							if (69423 - 528522 == -459099)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x06007217 RID: 29207 RVA: 0x00F8B6D8 File Offset: 0x00F898D8
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M107_RequestFromAlcacia.$onGameComplete$37503.$(this.$data$37506, this.$self_$37507);
		}

		// Token: 0x06007218 RID: 29208 RVA: 0x00F8B6EC File Offset: 0x00F898EC
		internal static bool CuVJCEpnid7rC2KnpgNJ()
		{
			return true;
		}

		// Token: 0x06007219 RID: 29209 RVA: 0x00F8B6F0 File Offset: 0x00F898F0
		internal static bool dvnEiApnKOqqOcX8vE0T()
		{
			return false;
		}

		// Token: 0x040077DE RID: 30686
		internal Hashtable $data$37506;

		// Token: 0x040077DF RID: 30687
		internal M107_RequestFromAlcacia $self_$37507;

		// Token: 0x02001355 RID: 4949
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600721A RID: 29210 RVA: 0x00F8B6F4 File Offset: 0x00F898F4
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Hashtable data, M107_RequestFromAlcacia self_)
			{
				if (130302 - 311612 != -181310)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (211298 - 194347 == 16951)
					{
						base..ctor();
						if (285788 - 115342 != 170447)
						{
							this.$data$37504 = data;
							if (226390 - 472292 != -245901)
							{
								this.$self_$37505 = self_;
								if (144373 - 467092 != -322718)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x0600721B RID: 29211 RVA: 0x00F8B7B0 File Offset: 0x00F899B0
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (115828 - 369850 != -254022)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_1B3;
					case 2:
						this.$self_$37505.SendMessage("fadeOut");
						if (130675 - 11083 != 119592)
						{
							continue;
						}
						this.$self_$37505.StartCoroutine_Auto(this.$self_$37505.ReturnToTown());
						if (57197 - 173896 != -116699)
						{
							continue;
						}
						this.YieldDefault(1);
						if (168868 - 503554 != -334686)
						{
							continue;
						}
						goto IL_1B3;
					default:
						if (137886 - 410958 == -273071)
						{
							continue;
						}
						break;
					}
					Debug.Log("On Event Complete:" + this.$data$37504[31]);
					if (96597 - 245293 != -148695)
					{
						if (Game.mGameState > eGameState.AllHold)
						{
							if (167901 - 420490 != -252588)
							{
								goto Block_7;
							}
						}
						else
						{
							Game.mGameState = eGameState.Complete;
							if (23179 - 395338 == -372159)
							{
								this.$self_$37505.VkZc8SLnIrS = 1;
								if (261140 - 564009 != -302868)
								{
									this.$self_$37505.vFac8BBjqOB = Time.time;
									if (10896 - 226129 != -215232)
									{
										break;
									}
								}
							}
						}
					}
				}
				return this.Yield(2, new WaitForSeconds(4f));
				Block_7:
				IL_1B3:
				return false;
			}

			// Token: 0x0600721C RID: 29212 RVA: 0x00F8B984 File Offset: 0x00F89B84
			internal static bool w7xIVapndsoZ4i3kRMp5()
			{
				return true;
			}

			// Token: 0x0600721D RID: 29213 RVA: 0x00F8B988 File Offset: 0x00F89B88
			internal static bool P87QGqpnJ3ketloUYW9D()
			{
				return false;
			}

			// Token: 0x040077E0 RID: 30688
			internal Hashtable $data$37504;

			// Token: 0x040077E1 RID: 30689
			internal M107_RequestFromAlcacia $self_$37505;
		}
	}

	// Token: 0x02001356 RID: 4950
	[CompilerGenerated]
	[Serializable]
	internal sealed class $LightPalaceStartEvent1$37508 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600721E RID: 29214 RVA: 0x00F8B98C File Offset: 0x00F89B8C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $LightPalaceStartEvent1$37508(M107_RequestFromAlcacia self_)
		{
			if (89694 - 123950 != -34256)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (76180 - 155576 != -79395)
				{
					base..ctor();
					if (34659 - 192478 != -157818)
					{
						this.$self_$37515 = self_;
						if (208834 - 123610 != 85225)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x0600721F RID: 29215 RVA: 0x00F8BA24 File Offset: 0x00F89C24
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M107_RequestFromAlcacia.$LightPalaceStartEvent1$37508.$(this.$self_$37515);
		}

		// Token: 0x06007220 RID: 29216 RVA: 0x00F8BA34 File Offset: 0x00F89C34
		internal static bool paIABxpnDNoI8v3g6jwc()
		{
			return true;
		}

		// Token: 0x06007221 RID: 29217 RVA: 0x00F8BA38 File Offset: 0x00F89C38
		internal static bool MnSVsppnv1oqbbTuExht()
		{
			return false;
		}

		// Token: 0x040077E2 RID: 30690
		internal M107_RequestFromAlcacia $self_$37515;

		// Token: 0x02001357 RID: 4951
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06007222 RID: 29218 RVA: 0x00F8BA3C File Offset: 0x00F89C3C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M107_RequestFromAlcacia self_)
			{
				if (106554 - 353969 != -247414)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (198051 - 364585 != -166533)
					{
						base..ctor();
						if (176180 - 131372 != 44809)
						{
							this.$self_$37514 = self_;
							if (103202 - 272800 == -169598)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x06007223 RID: 29219 RVA: 0x00F8BAD4 File Offset: 0x00F89CD4
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (276851 - 411302 != -134450)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						goto IL_2E8;
					case 1:
						goto IL_502;
					case 2:
						if (Game.mGameState != eGameState.Start)
						{
							if (186716 - 91581 != 95136)
							{
								goto Block_25;
							}
							continue;
						}
						else
						{
							this.$self_$37514.SendMessage("fadeOut");
							if (136711 - 182584 != -45872)
							{
								goto Block_33;
							}
							continue;
						}
						break;
					case 3:
						if (Game.mGameState != eGameState.Start)
						{
							if (99861 - 239879 != -140018)
							{
								continue;
							}
							goto IL_44;
						}
						break;
					default:
						if (238408 - 520550 != -282141)
						{
							goto IL_2E8;
						}
						continue;
					}
					IL_9B:
					this.$startPoint$37512 = GameObject.Find("StartPoint1");
					if (270558 - 125752 == 144807)
					{
						continue;
					}
					this.$startCamera$37513 = GameObject.Find("StartCamera1");
					if (111776 - 437285 != -325509)
					{
						continue;
					}
					if (this.$startCamera$37513)
					{
						if (120665 - 127161 != -6496)
						{
							continue;
						}
						this.$self_$37514.transform.position = this.$startCamera$37513.transform.position;
						if (285440 - 101632 == 183809)
						{
							continue;
						}
						this.$self_$37514.transform.rotation = this.$startCamera$37513.transform.rotation;
						if (84359 - 109664 == -25304)
						{
							continue;
						}
					}
					if (this.$startPoint$37512)
					{
						if (121046 - 462333 != -341287)
						{
							continue;
						}
						this.$self_$37514.CreatePlayer(CharacterData.current.CID, 1, this.$startPoint$37512.transform.position, this.$startPoint$37512.transform.forward);
						if (180272 - 396153 != -215881)
						{
							continue;
						}
					}
					else
					{
						Debug.Log("Error: Startpoint not found");
						if (113577 - 191821 == -78243)
						{
							continue;
						}
					}
					this.YieldDefault(1);
					if (115798 - 207882 != -92084)
					{
						continue;
					}
					break;
					IL_2E8:
					Game.mGameState = eGameState.Start;
					if (153632 - 454545 == -300913)
					{
						Game.mStateTime = Time.time;
						if (70173 - 268141 == -197968)
						{
							this.$mEventCamera1$37509 = GameObject.Find("EventCamera1");
							if (176059 - 375019 != -198959)
							{
								this.$mEventCamera2$37510 = GameObject.Find("EventCamera2");
								if (185364 - 559284 == -373920)
								{
									if (this.$mEventCamera1$37509)
									{
										if (18655 - 590687 == -572031)
										{
											continue;
										}
										if (this.$mEventCamera2$37510)
										{
											if (25052 - 150653 == -125600)
											{
												continue;
											}
											this.$self_$37514.transform.position = this.$mEventCamera1$37509.transform.position;
											if (274637 - 581624 != -306987)
											{
												continue;
											}
											this.$self_$37514.transform.rotation = this.$mEventCamera1$37509.transform.rotation;
											if (184264 - 402582 != -218318)
											{
												continue;
											}
											this.$mPlayerCameraControl$37511 = (PlayerCameraControl)this.$self_$37514.GetComponent(typeof(PlayerCameraControl));
											if (276766 - 358673 == -81906)
											{
												continue;
											}
											if (this.$mPlayerCameraControl$37511)
											{
												if (38655 - 396207 == -357551)
												{
													continue;
												}
												this.$mPlayerCameraControl$37511.StartCoroutine_Auto(this.$mPlayerCameraControl$37511.slerpToObject("EventCamera2", 2f));
												if (155429 - 164101 == -8671)
												{
													continue;
												}
											}
											this.$self_$37514.SendMessage("fadeIn");
											if (162626 - 74515 != 88111)
											{
												continue;
											}
											goto IL_35C;
										}
									}
									Debug.LogError("Cannot find EventCamera1 or EventCamera2");
									if (19300 - 594798 != -575497)
									{
										goto IL_9B;
									}
								}
							}
						}
					}
				}
				IL_44:
				goto IL_502;
				IL_35C:
				return this.Yield(2, new WaitForSeconds(3f));
				Block_25:
				goto IL_502;
				Block_33:
				return this.Yield(3, new WaitForSeconds(1f));
				IL_502:
				return false;
			}

			// Token: 0x06007224 RID: 29220 RVA: 0x00F8BFF8 File Offset: 0x00F8A1F8
			internal static bool gkNKtDpnRmIhxFvk6YTD()
			{
				return true;
			}

			// Token: 0x06007225 RID: 29221 RVA: 0x00F8BFFC File Offset: 0x00F8A1FC
			internal static bool rW3CbcpnwG4pI0OMYP6A()
			{
				return false;
			}

			// Token: 0x040077E3 RID: 30691
			internal GameObject $mEventCamera1$37509;

			// Token: 0x040077E4 RID: 30692
			internal GameObject $mEventCamera2$37510;

			// Token: 0x040077E5 RID: 30693
			internal PlayerCameraControl $mPlayerCameraControl$37511;

			// Token: 0x040077E6 RID: 30694
			internal GameObject $startPoint$37512;

			// Token: 0x040077E7 RID: 30695
			internal GameObject $startCamera$37513;

			// Token: 0x040077E8 RID: 30696
			internal M107_RequestFromAlcacia $self_$37514;
		}
	}

	// Token: 0x02001358 RID: 4952
	[CompilerGenerated]
	[Serializable]
	internal sealed class $LightPalaceStartEvent2$37516 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06007226 RID: 29222 RVA: 0x00F8C000 File Offset: 0x00F8A200
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $LightPalaceStartEvent2$37516(M107_RequestFromAlcacia self_)
		{
			if (261600 - 112168 != 149433)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (148854 - 286599 != -137744)
				{
					base..ctor();
					if (235618 - 364994 == -129376)
					{
						this.$self_$37521 = self_;
						if (113166 - 498901 == -385735)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x06007227 RID: 29223 RVA: 0x00F8C098 File Offset: 0x00F8A298
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M107_RequestFromAlcacia.$LightPalaceStartEvent2$37516.$(this.$self_$37521);
		}

		// Token: 0x06007228 RID: 29224 RVA: 0x00F8C0A8 File Offset: 0x00F8A2A8
		internal static bool e5lVEhpnqut1nUfDWbOF()
		{
			return true;
		}

		// Token: 0x06007229 RID: 29225 RVA: 0x00F8C0AC File Offset: 0x00F8A2AC
		internal static bool uMsK3Epn7Ba5i9afYN0G()
		{
			return false;
		}

		// Token: 0x040077E9 RID: 30697
		internal M107_RequestFromAlcacia $self_$37521;

		// Token: 0x02001359 RID: 4953
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600722A RID: 29226 RVA: 0x00F8C0B0 File Offset: 0x00F8A2B0
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M107_RequestFromAlcacia self_)
			{
				if (233155 - 54100 != 179056)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (147095 - 54316 == 92779)
					{
						base..ctor();
						if (80076 - 44411 == 35665)
						{
							this.$self_$37520 = self_;
							if (268967 - 18194 != 250774)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x0600722B RID: 29227 RVA: 0x00F8C148 File Offset: 0x00F8A348
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (97485 - 516873 != -419387)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						goto IL_333;
					case 1:
						goto IL_8A7;
					case 2:
						if (Game.mGameState != eGameState.Hold)
						{
							if (102043 - 112510 != -10466)
							{
								goto Block_31;
							}
							continue;
						}
						else
						{
							if (this.$self_$37520.teleportEffect)
							{
								if (49125 - 528394 != -479269)
								{
									continue;
								}
								if (Game.mPlayer)
								{
									if (110542 - 100459 != 10083)
									{
										continue;
									}
									UnityEngine.Object.Instantiate(this.$self_$37520.teleportEffect, Game.mPlayer.transform.position, Quaternion.identity);
									if (236112 - 126341 == 109772)
									{
										continue;
									}
								}
							}
							this.$self_$37520.SendMessage("fadeIn");
							if (157738 - 349521 != -191783)
							{
								continue;
							}
							goto IL_72B;
						}
						break;
					case 3:
						if (Game.mGameState != eGameState.Hold)
						{
							if (52326 - 297149 != -244823)
							{
								continue;
							}
							goto IL_1E7;
						}
						else
						{
							this.$mStoryGui$37517 = (StoryGui)this.$self_$37520.GetComponent(typeof(StoryGui));
							if (103567 - 155083 != -51516)
							{
								continue;
							}
							this.$mStoryGui$37517.startStoryMessage("RedPanda", "RedPanda", eTalkType.friend);
							if (268476 - 432582 != -164105)
							{
								goto Block_32;
							}
							continue;
						}
						break;
					case 4:
						if (Game.mGameState != eGameState.Hold)
						{
							if (272776 - 452052 != -179276)
							{
								continue;
							}
							goto IL_37D;
						}
						else
						{
							this.$mStoryTimer$37518 = 0f;
							if (293200 - 121891 != 171309)
							{
								continue;
							}
							this.$mStoryGui$37517.newStoryMessage("RedPanda", "Red Panda", Language.getMessage("M107_RequestFromAlcacia", 101), eTalkType.friend);
							if (59142 - 219613 != -160471)
							{
								continue;
							}
							this.$mStoryTimer$37518 = Time.time + 5f;
							if (152258 - 30080 != 122179)
							{
								goto Block_2;
							}
							continue;
						}
						break;
					case 5:
						goto IL_4F3;
					case 6:
						goto IL_4F3;
					case 7:
						break;
					case 8:
						break;
					case 9:
						goto IL_1BD;
					case 10:
						goto IL_1BD;
					case 11:
						goto IL_571;
					case 12:
						goto IL_571;
					case 13:
						if (Game.mGameState != eGameState.Hold)
						{
							if (132735 - 82597 != 50139)
							{
								goto Block_4;
							}
							continue;
						}
						else
						{
							this.$mGameGui$37519 = (GameGui)this.$self_$37520.GetComponent(typeof(GameGui));
							if (122951 - 137552 == -14600)
							{
								continue;
							}
							this.$mGameGui$37519.enabled = true;
							if (19660 - 79623 != -59963)
							{
								continue;
							}
							this.$self_$37520.umkc8UEMhO6.enabled = true;
							if (290771 - 520723 != -229952)
							{
								continue;
							}
							goto IL_268;
						}
						break;
					case 14:
						if (Game.mGameState != eGameState.Hold)
						{
							if (149359 - 281598 != -132238)
							{
								goto Block_19;
							}
							continue;
						}
						else
						{
							Game.mGameState = eGameState.Normal;
							if (259918 - 6997 != 252921)
							{
								continue;
							}
							this.YieldDefault(1);
							if (110610 - 532786 != -422175)
							{
								goto Block_28;
							}
							continue;
						}
						break;
					default:
						if (134307 - 379468 != -245160)
						{
							goto IL_333;
						}
						continue;
					}
					if (this.$mStoryTimer$37518 > Time.time)
					{
						if (83746 - 170631 == -86884)
						{
							continue;
						}
						if (!Input.GetKeyDown(KeyCode.Mouse0))
						{
							goto IL_871;
						}
						if (49393 - 510661 != -461268)
						{
							continue;
						}
					}
					if (Game.mGameState != eGameState.Hold)
					{
						if (146713 - 237008 != -90295)
						{
							continue;
						}
						goto IL_3F5;
					}
					else
					{
						this.$mStoryGui$37517.newStoryMessage("RedPanda", "Red Panda", Language.getMessage("M107_RequestFromAlcacia", 103), eTalkType.friend);
						if (269749 - 26750 != 242999)
						{
							continue;
						}
						this.$mStoryTimer$37518 = Time.time + 5f;
						if (260541 - 162872 != 97669)
						{
							continue;
						}
						goto IL_194;
					}
					IL_1BD:
					if (this.$mStoryTimer$37518 > Time.time)
					{
						if (60540 - 182644 == -122103)
						{
							continue;
						}
						if (!Input.GetKeyDown(KeyCode.Mouse0))
						{
							goto IL_1B0;
						}
						if (172190 - 549994 != -377804)
						{
							continue;
						}
					}
					if (Game.mGameState != eGameState.Hold)
					{
						if (95157 - 449277 != -354120)
						{
							continue;
						}
						goto IL_226;
					}
					else
					{
						this.$mStoryGui$37517.newStoryMessage("RedPanda", "Red Panda", Language.getMessage("M107_RequestFromAlcacia", 104), eTalkType.friend);
						if (4341 - 483593 == -479251)
						{
							continue;
						}
						this.$mStoryTimer$37518 = Time.time + 5f;
						if (287780 - 197409 != 90371)
						{
							continue;
						}
						goto IL_548;
					}
					IL_4F3:
					if (this.$mStoryTimer$37518 > Time.time)
					{
						if (34411 - 580706 != -546295)
						{
							continue;
						}
						if (!Input.GetKeyDown(KeyCode.Mouse0))
						{
							goto IL_4E7;
						}
						if (27530 - 528995 == -501464)
						{
							continue;
						}
					}
					if (Game.mGameState != eGameState.Hold)
					{
						if (106729 - 440898 != -334168)
						{
							goto Block_22;
						}
						continue;
					}
					else
					{
						this.$mStoryGui$37517.newStoryMessage("RedPanda", "Red Panda", Language.getMessage("M107_RequestFromAlcacia", 102), eTalkType.friend);
						if (55225 - 559759 != -504534)
						{
							continue;
						}
						this.$mStoryTimer$37518 = Time.time + 5f;
						if (75338 - 257976 != -182638)
						{
							continue;
						}
						goto IL_856;
					}
					IL_333:
					Game.mGameState = eGameState.Hold;
					if (182441 - 130302 == 52140)
					{
						continue;
					}
					Game.mStateTime = Time.time;
					if (29011 - 572918 != -543907)
					{
						continue;
					}
					this.$self_$37520.SendMessage("alignToObject", "EventCam0");
					if (95686 - 161423 != -65736)
					{
						goto Block_56;
					}
					continue;
					IL_571:
					if (this.$mStoryTimer$37518 > Time.time)
					{
						if (11705 - 243939 == -232233)
						{
							continue;
						}
						if (!Input.GetKeyDown(KeyCode.Mouse0))
						{
							goto IL_564;
						}
						if (159028 - 241863 != -82835)
						{
							continue;
						}
					}
					if (Game.mGameState != eGameState.Hold)
					{
						if (200802 - 337034 == -136232)
						{
							goto IL_4A2;
						}
					}
					else
					{
						this.$mStoryGui$37517.close();
						if (249979 - 410726 != -160746)
						{
							goto Block_33;
						}
					}
				}
				Block_2:
				return this.Yield(5, new WaitForSeconds(1f));
				Block_4:
				goto IL_8A7;
				IL_194:
				return this.Yield(9, new WaitForSeconds(0.5f));
				IL_1B0:
				return this.YieldDefault(10);
				IL_1E7:
				IL_226:
				goto IL_8A7;
				IL_268:
				return this.Yield(14, new WaitForSeconds(1f));
				Block_19:
				Block_22:
				IL_37D:
				Block_28:
				IL_3F5:
				Block_31:
				goto IL_8A7;
				Block_32:
				return this.Yield(4, new WaitForSeconds(0.5f));
				IL_4A2:
				goto IL_8A7;
				Block_33:
				return this.Yield(13, new WaitForSeconds(0.5f));
				IL_4E7:
				return this.YieldDefault(6);
				IL_548:
				return this.Yield(11, new WaitForSeconds(0.5f));
				IL_564:
				return this.YieldDefault(12);
				IL_72B:
				return this.Yield(3, new WaitForSeconds(2f));
				Block_56:
				return this.Yield(2, new WaitForSeconds(0.5f));
				IL_856:
				return this.Yield(7, new WaitForSeconds(0.5f));
				IL_871:
				return this.YieldDefault(8);
				IL_8A7:
				return false;
			}

			// Token: 0x0600722C RID: 29228 RVA: 0x00F8CA10 File Offset: 0x00F8AC10
			internal static bool KtG0EppnPVpCPGahELv8()
			{
				return true;
			}

			// Token: 0x0600722D RID: 29229 RVA: 0x00F8CA14 File Offset: 0x00F8AC14
			internal static bool ajfYZvpn0j7K6EFWUTcv()
			{
				return false;
			}

			// Token: 0x040077EA RID: 30698
			internal StoryGui $mStoryGui$37517;

			// Token: 0x040077EB RID: 30699
			internal float $mStoryTimer$37518;

			// Token: 0x040077EC RID: 30700
			internal GameGui $mGameGui$37519;

			// Token: 0x040077ED RID: 30701
			internal M107_RequestFromAlcacia $self_$37520;
		}
	}

	// Token: 0x0200135A RID: 4954
	[CompilerGenerated]
	[Serializable]
	internal sealed class $TalkToLightGod$37522 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600722E RID: 29230 RVA: 0x00F8CA18 File Offset: 0x00F8AC18
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $TalkToLightGod$37522(M107_RequestFromAlcacia self_)
		{
			if (122881 - 472217 != -349335)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (5451 - 420673 == -415222)
				{
					base..ctor();
					if (253858 - 551010 == -297152)
					{
						this.$self_$37529 = self_;
						if (210598 - 248258 == -37660)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x0600722F RID: 29231 RVA: 0x00F8CAB0 File Offset: 0x00F8ACB0
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M107_RequestFromAlcacia.$TalkToLightGod$37522.$(this.$self_$37529);
		}

		// Token: 0x06007230 RID: 29232 RVA: 0x00F8CAC0 File Offset: 0x00F8ACC0
		internal static bool urCCC0pnbgn0GphUIroM()
		{
			return true;
		}

		// Token: 0x06007231 RID: 29233 RVA: 0x00F8CAC4 File Offset: 0x00F8ACC4
		internal static bool uXjmvDpnurJalWA21216()
		{
			return false;
		}

		// Token: 0x040077EE RID: 30702
		internal M107_RequestFromAlcacia $self_$37529;

		// Token: 0x0200135B RID: 4955
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06007232 RID: 29234 RVA: 0x00F8CAC8 File Offset: 0x00F8ACC8
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M107_RequestFromAlcacia self_)
			{
				if (293080 - 214437 != 78643)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (89768 - 272017 == -182249)
					{
						base..ctor();
						if (154046 - 73917 == 80129)
						{
							this.$self_$37528 = self_;
							if (185491 - 304939 != -119447)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x06007233 RID: 29235 RVA: 0x00F8CB60 File Offset: 0x00F8AD60
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (215445 - 338852 != -123406)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						goto IL_6C4;
					case 1:
						goto IL_2633;
					case 2:
						if (Game.mGameState != eGameState.Hold)
						{
							if (166477 - 244021 != -77544)
							{
								continue;
							}
							goto IL_AFD;
						}
						else
						{
							this.$self_$37528.SendMessage("fadeOut");
							if (284427 - 735 != 283692)
							{
								continue;
							}
							goto IL_2488;
						}
						break;
					case 3:
						if (Game.mGameState != eGameState.Hold)
						{
							if (67393 - 289748 != -222355)
							{
								continue;
							}
							goto IL_956;
						}
						else
						{
							this.$self_$37528.umkc8UEMhO6.enabled = false;
							if (254398 - 568664 != -314266)
							{
								continue;
							}
							this.$self_$37528.SendMessage("alignToObject", "EventCam1");
							if (79817 - 106136 != -26319)
							{
								continue;
							}
							goto IL_19AA;
						}
						break;
					case 4:
						if (Game.mGameState != eGameState.Hold)
						{
							if (75390 - 539072 != -463682)
							{
								continue;
							}
							goto IL_C90;
						}
						else
						{
							this.$self_$37528.SendMessage("fadeIn");
							if (160902 - 231330 != -70428)
							{
								continue;
							}
							goto IL_2555;
						}
						break;
					case 5:
						if (Game.mGameState != eGameState.Hold)
						{
							if (70648 - 508866 != -438218)
							{
								continue;
							}
							goto IL_1F2C;
						}
						else
						{
							this.$mStoryGui$37526.startStoryMessage("LightGod", "Alcacia", eTalkType.friend);
							if (182286 - 556730 != -374443)
							{
								goto Block_230;
							}
							continue;
						}
						break;
					case 6:
						this.$mStoryTimer$37527 = 0f;
						if (175977 - 235637 != -59660)
						{
							continue;
						}
						this.$mLightGod$37524.animation.CrossFade("talk", 0.2f);
						if (180189 - 210289 != -30100)
						{
							continue;
						}
						this.$mStoryGui$37526.newStoryMessage("LightGod", "Alcacia", Language.getMessage("M107_RequestFromAlcacia", 1), eTalkType.friend);
						if (205425 - 110584 == 94842)
						{
							continue;
						}
						if (PlayerPrefs.GetInt("nvoice", 1) != 0)
						{
							if (257379 - 98752 != 158627)
							{
								continue;
							}
							if (this.$self_$37528.hi_vc)
							{
								if (55897 - 595493 == -539595)
								{
									continue;
								}
								this.$self_$37528.audio.PlayOneShot(this.$self_$37528.hi_vc);
								if (193797 - 67477 != 126320)
								{
									continue;
								}
							}
							else
							{
								Debug.LogError("Cannot find hi voice");
								if (206669 - 551465 == -344795)
								{
									continue;
								}
							}
						}
						this.$mStoryTimer$37527 = Time.time + 5f;
						if (11549 - 237138 != -225589)
						{
							continue;
						}
						goto IL_547;
					case 7:
						goto IL_56E;
					case 8:
						goto IL_56E;
					case 9:
						goto IL_217D;
					case 10:
						goto IL_217D;
					case 11:
						goto IL_1345;
					case 12:
						goto IL_1345;
					case 13:
						goto IL_1508;
					case 14:
						goto IL_1508;
					case 15:
						goto IL_2087;
					case 16:
						goto IL_2087;
					case 17:
						goto IL_1FB5;
					case 18:
						goto IL_1FB5;
					case 19:
						goto IL_11BC;
					case 20:
						goto IL_11BC;
					case 21:
						goto IL_1169;
					case 22:
						goto IL_1169;
					case 23:
						goto IL_2314;
					case 24:
						goto IL_2314;
					case 25:
						break;
					case 26:
						break;
					case 27:
						goto IL_1A5C;
					case 28:
						goto IL_1A5C;
					case 29:
						goto IL_21F5;
					case 30:
						goto IL_21F5;
					case 31:
						goto IL_2296;
					case 32:
						goto IL_2296;
					case 33:
						goto IL_1848;
					case 34:
						goto IL_1848;
					case 35:
						goto IL_1957;
					case 36:
						goto IL_1957;
					case 37:
						goto IL_73A;
					case 38:
						goto IL_73A;
					case 39:
						goto IL_62D;
					case 40:
						goto IL_62D;
					case 41:
						goto IL_17F5;
					case 42:
						goto IL_17F5;
					case 43:
						goto IL_2367;
					case 44:
						goto IL_2367;
					case 45:
						goto IL_884;
					case 46:
						goto IL_884;
					case 47:
						goto IL_390;
					case 48:
						goto IL_390;
					case 49:
						goto IL_12F2;
					case 50:
						goto IL_12F2;
					case 51:
						goto IL_A92;
					case 52:
						goto IL_A92;
					case 53:
						goto IL_245E;
					case 54:
						goto IL_245E;
					case 55:
						goto IL_1CD2;
					case 56:
						goto IL_1CD2;
					case 57:
						goto IL_1251;
					case 58:
						goto IL_1251;
					case 59:
						goto IL_FA8;
					case 60:
						goto IL_FA8;
					case 61:
						goto IL_212A;
					case 62:
						goto IL_212A;
					case 63:
						if (Game.mGameState != eGameState.Hold)
						{
							if (116941 - 331932 != -214990)
							{
								goto Block_83;
							}
							continue;
						}
						else
						{
							Game.sendMissionEvent(1071, 0);
							if (233902 - 579153 == -345250)
							{
								continue;
							}
							this.YieldDefault(1);
							if (108301 - 221538 != -113237)
							{
								continue;
							}
							goto IL_2633;
						}
						break;
					default:
						if (282745 - 300784 != -18039)
						{
							continue;
						}
						goto IL_6C4;
					}
					if (this.$mStoryTimer$37527 > Time.time)
					{
						if (7468 - 455029 != -447561)
						{
							continue;
						}
						if (!Input.GetKeyDown(KeyCode.Mouse0))
						{
							goto IL_BB;
						}
						if (57946 - 476664 != -418718)
						{
							continue;
						}
					}
					if (Game.mGameState != eGameState.Hold)
					{
						if (63295 - 346719 != -283423)
						{
							break;
						}
						continue;
					}
					else
					{
						this.$mStoryGui$37526.newStoryMessage("WaterGod", "Alcacia", Language.getMessage("M107_RequestFromAlcacia", 11), eTalkType.friend);
						if (112809 - 187208 == -74398)
						{
							continue;
						}
						this.$mStoryTimer$37527 = Time.time + 5f;
						if (50180 - 203673 != -153493)
						{
							continue;
						}
						goto IL_1A33;
					}
					IL_2367:
					if (this.$mStoryTimer$37527 > Time.time)
					{
						if (248533 - 345380 != -96847)
						{
							continue;
						}
						if (!Input.GetKeyDown(KeyCode.Mouse0))
						{
							goto IL_235A;
						}
						if (3905 - 265964 == -262058)
						{
							continue;
						}
					}
					if (Game.mGameState != eGameState.Hold)
					{
						if (176498 - 148358 != 28141)
						{
							break;
						}
						continue;
					}
					else
					{
						this.$mStoryGui$37526.newStoryMessage("LightGod", "Alcacia", Language.getMessage("M107_RequestFromAlcacia", 20), eTalkType.friend);
						if (3276 - 263337 != -260061)
						{
							continue;
						}
						this.$mStoryTimer$37527 = Time.time + 5f;
						if (59802 - 258615 != -198812)
						{
							goto Block_92;
						}
						continue;
					}
					IL_1A5C:
					if (this.$mStoryTimer$37527 > Time.time)
					{
						if (250668 - 262195 == -11526)
						{
							continue;
						}
						if (!Input.GetKeyDown(KeyCode.Mouse0))
						{
							goto IL_1A4F;
						}
						if (63987 - 510274 == -446286)
						{
							continue;
						}
					}
					if (Game.mGameState != eGameState.Hold)
					{
						if (42977 - 454349 != -411371)
						{
							break;
						}
						continue;
					}
					else
					{
						this.$mStoryGui$37526.newStoryMessage("ShadowGod", "Alcacia", Language.getMessage("M107_RequestFromAlcacia", 12), eTalkType.friend);
						if (274302 - 403196 != -128894)
						{
							continue;
						}
						this.$mStoryTimer$37527 = Time.time + 5f;
						if (3908 - 286223 != -282315)
						{
							continue;
						}
						goto IL_21CC;
					}
					IL_1CD2:
					if (this.$mStoryTimer$37527 > Time.time)
					{
						if (128741 - 312704 == -183962)
						{
							continue;
						}
						if (!Input.GetKeyDown(KeyCode.Mouse0))
						{
							goto IL_1CC5;
						}
						if (198715 - 61008 != 137707)
						{
							continue;
						}
					}
					if (Game.mGameState != eGameState.Hold)
					{
						if (221970 - 311348 != -89378)
						{
							continue;
						}
						break;
					}
					else
					{
						this.$mStoryGui$37526.newStoryMessage("none", "Alcacia", Language.getMessage("M107_RequestFromAlcacia", 26), eTalkType.friend);
						if (255339 - 126696 != 128643)
						{
							continue;
						}
						this.$mStoryTimer$37527 = Time.time + 5f;
						if (269177 - 77353 != 191825)
						{
							goto Block_170;
						}
						continue;
					}
					IL_21F5:
					if (this.$mStoryTimer$37527 > Time.time)
					{
						if (21826 - 448027 != -426201)
						{
							continue;
						}
						if (!Input.GetKeyDown(KeyCode.Mouse0))
						{
							goto IL_21E8;
						}
						if (169063 - 306501 == -137437)
						{
							continue;
						}
					}
					if (Game.mGameState != eGameState.Hold)
					{
						if (162856 - 147835 != 15022)
						{
							break;
						}
						continue;
					}
					else
					{
						this.$mStoryGui$37526.newStoryMessage("LightGod", "Alcacia", Language.getMessage("M107_RequestFromAlcacia", 13), eTalkType.friend);
						if (279360 - 376817 != -97457)
						{
							continue;
						}
						this.$mStoryTimer$37527 = Time.time + 5f;
						if (48837 - 519051 != -470213)
						{
							goto Block_240;
						}
						continue;
					}
					IL_2314:
					if (this.$mStoryTimer$37527 > Time.time)
					{
						if (277819 - 58778 == 219042)
						{
							continue;
						}
						if (!Input.GetKeyDown(KeyCode.Mouse0))
						{
							goto IL_2307;
						}
						if (159923 - 564876 == -404952)
						{
							continue;
						}
					}
					if (Game.mGameState != eGameState.Hold)
					{
						if (214361 - 300821 != -86459)
						{
							break;
						}
						continue;
					}
					else
					{
						this.$mStoryGui$37526.newStoryMessage("WindGod", "Alcacia", Language.getMessage("M107_RequestFromAlcacia", 10), eTalkType.friend);
						if (110707 - 427627 == -316919)
						{
							continue;
						}
						this.$mStoryTimer$37527 = Time.time + 5f;
						if (32353 - 314915 != -282562)
						{
							continue;
						}
						goto IL_9F;
					}
					IL_2087:
					if (this.$mStoryTimer$37527 > Time.time)
					{
						if (38040 - 352786 != -314746)
						{
							continue;
						}
						if (!Input.GetKeyDown(KeyCode.Mouse0))
						{
							goto IL_207A;
						}
						if (209411 - 80151 == 129261)
						{
							continue;
						}
					}
					if (Game.mGameState != eGameState.Hold)
					{
						if (188859 - 317516 != -128657)
						{
							continue;
						}
						break;
					}
					else
					{
						this.$mStoryGui$37526.newStoryMessage("LightGod", "Alcacia", Language.getMessage("M107_RequestFromAlcacia", 6), eTalkType.friend);
						if (128910 - 319529 == -190618)
						{
							continue;
						}
						this.$mStoryTimer$37527 = Time.time + 5f;
						if (255878 - 421196 != -165318)
						{
							continue;
						}
						goto IL_1F8C;
					}
					IL_17F5:
					if (this.$mStoryTimer$37527 > Time.time)
					{
						if (277495 - 290964 != -13469)
						{
							continue;
						}
						if (!Input.GetKeyDown(KeyCode.Mouse0))
						{
							goto IL_17E8;
						}
						if (141359 - 476058 != -334699)
						{
							continue;
						}
					}
					if (Game.mGameState != eGameState.Hold)
					{
						if (298669 - 309381 != -10712)
						{
							continue;
						}
						break;
					}
					else
					{
						this.$mStoryGui$37526.newStoryMessage("LightGod", "Alcacia", Language.getMessage("M107_RequestFromAlcacia", 19), eTalkType.friend);
						if (155611 - 337664 != -182053)
						{
							continue;
						}
						this.$mStoryTimer$37527 = Time.time + 5f;
						if (94055 - 364586 != -270530)
						{
							goto Block_237;
						}
						continue;
					}
					IL_884:
					if (this.$mStoryTimer$37527 > Time.time)
					{
						if (291487 - 325752 != -34265)
						{
							continue;
						}
						if (!Input.GetKeyDown(KeyCode.Mouse0))
						{
							goto IL_877;
						}
						if (250303 - 485802 == -235498)
						{
							continue;
						}
					}
					if (Game.mGameState != eGameState.Hold)
					{
						if (248451 - 444783 != -196332)
						{
							continue;
						}
						break;
					}
					else
					{
						this.$mStoryGui$37526.newStoryMessage("LightGod", "Alcacia", Language.getMessage("M107_RequestFromAlcacia", 21), eTalkType.friend);
						if (99718 - 351597 == -251878)
						{
							continue;
						}
						this.$mStoryTimer$37527 = Time.time + 5f;
						if (292554 - 45024 != 247531)
						{
							goto Block_89;
						}
						continue;
					}
					IL_390:
					if (this.$mStoryTimer$37527 > Time.time)
					{
						if (89086 - 358266 != -269180)
						{
							continue;
						}
						if (!Input.GetKeyDown(KeyCode.Mouse0))
						{
							goto IL_383;
						}
						if (258465 - 437138 == -178672)
						{
							continue;
						}
					}
					if (Game.mGameState != eGameState.Hold)
					{
						if (41312 - 325283 != -283971)
						{
							continue;
						}
						break;
					}
					else
					{
						this.$self_$37528.SendMessage("alignToObject", "EventCam3");
						if (186301 - 436634 == -250332)
						{
							continue;
						}
						this.$mLightGod$37524.animation.CrossFade("command", 0.2f);
						if (13892 - 160022 == -146129)
						{
							continue;
						}
						this.$mStoryGui$37526.newStoryMessage("none", "Alcacia", Language.getMessage("M107_RequestFromAlcacia", 22), eTalkType.friend);
						if (95534 - 328768 != -233234)
						{
							continue;
						}
						this.$mStoryTimer$37527 = Time.time + 5f;
						if (44069 - 214397 != -170328)
						{
							continue;
						}
						goto IL_12C9;
					}
					IL_12F2:
					if (this.$mStoryTimer$37527 > Time.time)
					{
						if (92258 - 421641 != -329383)
						{
							continue;
						}
						if (!Input.GetKeyDown(KeyCode.Mouse0))
						{
							goto IL_12E5;
						}
						if (2982 - 366493 == -363510)
						{
							continue;
						}
					}
					if (Game.mGameState != eGameState.Hold)
					{
						if (77582 - 66309 != 11274)
						{
							break;
						}
						continue;
					}
					else
					{
						this.$mStoryGui$37526.newStoryMessage("none", "Alcacia", Language.getMessage("M107_RequestFromAlcacia", 23), eTalkType.friend);
						if (206314 - 192785 == 13530)
						{
							continue;
						}
						this.$mStoryTimer$37527 = Time.time + 5f;
						if (183202 - 217481 != -34278)
						{
							goto Block_272;
						}
						continue;
					}
					IL_A92:
					if (this.$mStoryTimer$37527 > Time.time)
					{
						if (198645 - 373869 == -175223)
						{
							continue;
						}
						if (!Input.GetKeyDown(KeyCode.Mouse0))
						{
							goto IL_A85;
						}
						if (294575 - 165849 != 128726)
						{
							continue;
						}
					}
					if (Game.mGameState != eGameState.Hold)
					{
						if (293275 - 577034 != -283759)
						{
							continue;
						}
						break;
					}
					else
					{
						this.$mStoryGui$37526.newStoryMessage("none", "Alcacia", Language.getMessage("M107_RequestFromAlcacia", 24), eTalkType.friend);
						if (231658 - 90336 != 141322)
						{
							continue;
						}
						this.$mStoryTimer$37527 = Time.time + 5f;
						if (58314 - 314595 != -256280)
						{
							goto Block_32;
						}
						continue;
					}
					IL_1169:
					if (this.$mStoryTimer$37527 > Time.time)
					{
						if (201007 - 215756 != -14749)
						{
							continue;
						}
						if (!Input.GetKeyDown(KeyCode.Mouse0))
						{
							goto IL_115C;
						}
						if (131174 - 563416 == -432241)
						{
							continue;
						}
					}
					if (Game.mGameState != eGameState.Hold)
					{
						if (126715 - 296211 != -169496)
						{
							continue;
						}
						break;
					}
					else
					{
						this.$mStoryGui$37526.newStoryMessage("EarthGod", "Alcacia", Language.getMessage("M107_RequestFromAlcacia", 9), eTalkType.friend);
						if (86012 - 93801 != -7789)
						{
							continue;
						}
						this.$mStoryTimer$37527 = Time.time + 5f;
						if (42307 - 153821 != -111513)
						{
							goto Block_109;
						}
						continue;
					}
					IL_FA8:
					if (this.$mStoryTimer$37527 > Time.time)
					{
						if (297177 - 96312 != 200865)
						{
							continue;
						}
						if (!Input.GetKeyDown(KeyCode.Mouse0))
						{
							goto IL_F9B;
						}
						if (140177 - 113024 == 27154)
						{
							continue;
						}
					}
					if (Game.mGameState != eGameState.Hold)
					{
						if (286810 - 269728 != 17082)
						{
							continue;
						}
						break;
					}
					else
					{
						this.$mStoryGui$37526.newStoryMessage("none", "Alcacia", Language.getMessage("M107_RequestFromAlcacia", 28), eTalkType.friend);
						if (1825 - 1735 != 90)
						{
							continue;
						}
						if (PlayerPrefs.GetInt("nvoice", 1) != 0)
						{
							if (32970 - 244005 != -211035)
							{
								continue;
							}
							if (this.$self_$37528.chat2_vc)
							{
								if (284122 - 591172 != -307050)
								{
									continue;
								}
								this.$self_$37528.audio.PlayOneShot(this.$self_$37528.chat2_vc);
								if (123672 - 16793 == 106880)
								{
									continue;
								}
							}
							else
							{
								Debug.LogError("Cannot find chat2 voice");
								if (138828 - 208365 == -69536)
								{
									continue;
								}
							}
						}
						this.$mStoryTimer$37527 = Time.time + 5f;
						if (67157 - 568149 != -500991)
						{
							goto Block_101;
						}
						continue;
					}
					IL_56E:
					if (this.$mStoryTimer$37527 > Time.time)
					{
						if (34552 - 479184 != -444632)
						{
							continue;
						}
						if (!Input.GetKeyDown(KeyCode.Mouse0))
						{
							goto IL_562;
						}
						if (117966 - 356647 != -238681)
						{
							continue;
						}
					}
					if (Game.mGameState != eGameState.Hold)
					{
						if (28229 - 107414 != -79185)
						{
							continue;
						}
						break;
					}
					else
					{
						this.$mStoryGui$37526.newStoryMessage("LightGod", "Alcacia", Language.getMessage("M107_RequestFromAlcacia", 2), eTalkType.friend);
						if (136191 - 513088 != -376897)
						{
							continue;
						}
						this.$mStoryTimer$37527 = Time.time + 5f;
						if (259526 - 45570 != 213957)
						{
							goto Block_45;
						}
						continue;
					}
					IL_1848:
					if (this.$mStoryTimer$37527 > Time.time)
					{
						if (126497 - 510627 != -384130)
						{
							continue;
						}
						if (!Input.GetKeyDown(KeyCode.Mouse0))
						{
							goto IL_183B;
						}
						if (241611 - 98169 == 143443)
						{
							continue;
						}
					}
					if (Game.mGameState != eGameState.Hold)
					{
						if (4824 - 407726 != -402901)
						{
							break;
						}
						continue;
					}
					else
					{
						this.$mStoryGui$37526.newStoryMessage("LightGod", "Alcacia", Language.getMessage("M107_RequestFromAlcacia", 15), eTalkType.friend);
						if (176106 - 294956 != -118850)
						{
							continue;
						}
						this.$mStoryTimer$37527 = Time.time + 5f;
						if (128856 - 457049 != -328192)
						{
							goto Block_116;
						}
						continue;
					}
					IL_62D:
					if (this.$mStoryTimer$37527 > Time.time)
					{
						if (120926 - 488992 != -368066)
						{
							continue;
						}
						if (!Input.GetKeyDown(KeyCode.Mouse0))
						{
							goto IL_620;
						}
						if (12870 - 551864 != -538994)
						{
							continue;
						}
					}
					if (Game.mGameState != eGameState.Hold)
					{
						if (187158 - 170739 != 16420)
						{
							break;
						}
						continue;
					}
					else
					{
						this.$mStoryGui$37526.newStoryMessage("LightGod", "Alcacia", Language.getMessage("M107_RequestFromAlcacia", 18), eTalkType.friend);
						if (159161 - 420744 == -261582)
						{
							continue;
						}
						this.$mStoryTimer$37527 = Time.time + 5f;
						if (18108 - 8645 != 9464)
						{
							goto Block_231;
						}
						continue;
					}
					IL_6C4:
					Debug.Log("On Talk To LightGod");
					if (190680 - 243497 != -52817)
					{
						continue;
					}
					if (Game.mGameState != eGameState.Normal)
					{
						if (198059 - 446314 != -248254)
						{
							break;
						}
						continue;
					}
					else
					{
						Game.mGameState = eGameState.Hold;
						if (24246 - 402793 != -378547)
						{
							continue;
						}
						this.$mPlayer$37523 = Game.mPlayer;
						if (259160 - 178194 == 80967)
						{
							continue;
						}
						this.$mLightGod$37524 = GameObject.Find("LightGod");
						if (271205 - 19737 == 251469)
						{
							continue;
						}
						if (this.$mLightGod$37524)
						{
							if (68319 - 413130 == -344810)
							{
								continue;
							}
							if (this.$mPlayer$37523)
							{
								if (283317 - 408672 != -125355)
								{
									continue;
								}
								this.$mPlayer$37523.SendMessage("turnToPos", this.$mLightGod$37524.transform.position);
								if (10244 - 542793 == -532548)
								{
									continue;
								}
							}
						}
						this.$mGameGui$37525 = (GameGui)this.$self_$37528.GetComponent(typeof(GameGui));
						if (173168 - 273617 != -100449)
						{
							continue;
						}
						this.$mStoryGui$37526 = (StoryGui)this.$self_$37528.GetComponent(typeof(StoryGui));
						if (56312 - 321599 == -265286)
						{
							continue;
						}
						if (!this.$mGameGui$37525)
						{
							goto IL_1D43;
						}
						if (203950 - 568920 == -364969)
						{
							continue;
						}
						this.$mGameGui$37525.close();
						if (62377 - 504631 != -442254)
						{
							continue;
						}
						goto IL_1D43;
					}
					IL_217D:
					if (this.$mStoryTimer$37527 > Time.time)
					{
						if (172511 - 592224 != -419713)
						{
							continue;
						}
						if (!Input.GetKeyDown(KeyCode.Mouse0))
						{
							goto IL_2170;
						}
						if (163156 - 429996 == -266839)
						{
							continue;
						}
					}
					if (Game.mGameState != eGameState.Hold)
					{
						if (103142 - 7936 != 95207)
						{
							break;
						}
						continue;
					}
					else
					{
						this.$mStoryGui$37526.newStoryMessage("LightGod", "Alcacia", Language.getMessage("M107_RequestFromAlcacia", 3), eTalkType.friend);
						if (144385 - 141746 == 2640)
						{
							continue;
						}
						this.$mStoryTimer$37527 = Time.time + 5f;
						if (175149 - 158376 != 16774)
						{
							goto Block_198;
						}
						continue;
					}
					IL_73A:
					if (this.$mStoryTimer$37527 > Time.time)
					{
						if (152407 - 307438 != -155031)
						{
							continue;
						}
						if (!Input.GetKeyDown(KeyCode.Mouse0))
						{
							goto IL_72D;
						}
						if (193182 - 204089 != -10907)
						{
							continue;
						}
					}
					if (Game.mGameState != eGameState.Hold)
					{
						if (93307 - 76264 != 17043)
						{
							continue;
						}
						break;
					}
					else
					{
						this.$mStoryGui$37526.newStoryMessage("LightGod", "Alcacia", Language.getMessage("M107_RequestFromAlcacia", 17), eTalkType.friend);
						if (51901 - 356895 != -304994)
						{
							continue;
						}
						this.$mStoryTimer$37527 = Time.time + 5f;
						if (39490 - 157348 != -117858)
						{
							continue;
						}
						goto IL_604;
					}
					IL_212A:
					if (this.$mStoryTimer$37527 > Time.time)
					{
						if (86369 - 13587 != 72782)
						{
							continue;
						}
						if (!Input.GetKeyDown(KeyCode.Mouse0))
						{
							goto IL_211D;
						}
						if (84809 - 371399 != -286590)
						{
							continue;
						}
					}
					if (Game.mGameState != eGameState.Hold)
					{
						if (30214 - 392564 != -362350)
						{
							continue;
						}
						break;
					}
					else
					{
						this.$mLightGod$37524.animation.CrossFade("root", 0.2f);
						if (213892 - 554935 != -341043)
						{
							continue;
						}
						this.$mStoryGui$37526.close();
						if (99423 - 471696 != -372273)
						{
							continue;
						}
						goto IL_B76;
					}
					IL_2296:
					if (this.$mStoryTimer$37527 > Time.time)
					{
						if (61373 - 281964 == -220590)
						{
							continue;
						}
						if (!Input.GetKeyDown(KeyCode.Mouse0))
						{
							goto IL_2289;
						}
						if (66727 - 572099 == -505371)
						{
							continue;
						}
					}
					if (Game.mGameState != eGameState.Hold)
					{
						if (79043 - 592253 != -513210)
						{
							continue;
						}
						break;
					}
					else
					{
						this.$self_$37528.SendMessage("alignToObject", "EventCam2");
						if (127490 - 425998 != -298508)
						{
							continue;
						}
						this.$mLightGod$37524.animation.CrossFade("root", 0.2f);
						if (264424 - 513948 != -249524)
						{
							continue;
						}
						this.$mStoryGui$37526.newStoryMessage("LightGod", "Alcacia", Language.getMessage("M107_RequestFromAlcacia", 14), eTalkType.friend);
						if (189045 - 231906 == -42860)
						{
							continue;
						}
						this.$mStoryTimer$37527 = Time.time + 5f;
						if (53704 - 517 != 53187)
						{
							continue;
						}
						goto IL_181F;
					}
					IL_1345:
					if (this.$mStoryTimer$37527 > Time.time)
					{
						if (282341 - 497233 != -214892)
						{
							continue;
						}
						if (!Input.GetKeyDown(KeyCode.Mouse0))
						{
							goto IL_1338;
						}
						if (35581 - 368113 == -332531)
						{
							continue;
						}
					}
					if (Game.mGameState != eGameState.Hold)
					{
						if (229596 - 136413 != 93184)
						{
							break;
						}
						continue;
					}
					else
					{
						this.$mStoryGui$37526.newStoryMessage("LightGod", "Alcacia", Language.getMessage("M107_RequestFromAlcacia", 4), eTalkType.friend);
						if (5713 - 392734 != -387021)
						{
							continue;
						}
						this.$mStoryTimer$37527 = Time.time + 5f;
						if (238181 - 486252 != -248070)
						{
							goto Block_62;
						}
						continue;
					}
					IL_245E:
					if (this.$mStoryTimer$37527 > Time.time)
					{
						if (284152 - 512511 != -228359)
						{
							continue;
						}
						if (!Input.GetKeyDown(KeyCode.Mouse0))
						{
							goto IL_2451;
						}
						if (264109 - 454898 != -190789)
						{
							continue;
						}
					}
					if (Game.mGameState != eGameState.Hold)
					{
						if (131595 - 256904 != -125308)
						{
							break;
						}
						continue;
					}
					else
					{
						this.$mStoryGui$37526.newStoryMessage("none", "Alcacia", Language.getMessage("M107_RequestFromAlcacia", 25), eTalkType.friend);
						if (112326 - 273929 == -161602)
						{
							continue;
						}
						this.$mStoryTimer$37527 = Time.time + 5f;
						if (211869 - 85369 != 126500)
						{
							continue;
						}
						goto IL_1CA9;
					}
					IL_11BC:
					if (this.$mStoryTimer$37527 > Time.time)
					{
						if (169754 - 565398 != -395644)
						{
							continue;
						}
						if (!Input.GetKeyDown(KeyCode.Mouse0))
						{
							goto IL_11AF;
						}
						if (137234 - 134833 != 2401)
						{
							continue;
						}
					}
					if (Game.mGameState != eGameState.Hold)
					{
						if (139970 - 506761 != -366790)
						{
							break;
						}
						continue;
					}
					else
					{
						this.$mStoryGui$37526.newStoryMessage("FireGod", "Alcacia", Language.getMessage("M107_RequestFromAlcacia", 8), eTalkType.friend);
						if (292498 - 23385 != 269113)
						{
							continue;
						}
						this.$mStoryTimer$37527 = Time.time + 5f;
						if (133815 - 152346 != -18530)
						{
							goto Block_260;
						}
						continue;
					}
					IL_1508:
					if (this.$mStoryTimer$37527 > Time.time)
					{
						if (106414 - 253217 != -146803)
						{
							continue;
						}
						if (!Input.GetKeyDown(KeyCode.Mouse0))
						{
							goto IL_14FB;
						}
						if (224620 - 340520 == -115899)
						{
							continue;
						}
					}
					if (Game.mGameState != eGameState.Hold)
					{
						if (159791 - 223107 != -63316)
						{
							continue;
						}
						break;
					}
					else
					{
						this.$mStoryGui$37526.newStoryMessage("LightGod", "Alcacia", Language.getMessage("M107_RequestFromAlcacia", 5), eTalkType.friend);
						if (169700 - 486567 != -316867)
						{
							continue;
						}
						this.$mStoryTimer$37527 = Time.time + 5f;
						if (70246 - 501895 != -431648)
						{
							goto Block_255;
						}
						continue;
					}
					IL_1251:
					if (this.$mStoryTimer$37527 > Time.time)
					{
						if (55244 - 222957 == -167712)
						{
							continue;
						}
						if (!Input.GetKeyDown(KeyCode.Mouse0))
						{
							goto IL_1244;
						}
						if (250300 - 509787 == -259486)
						{
							continue;
						}
					}
					if (Game.mGameState != eGameState.Hold)
					{
						if (281325 - 344772 != -63447)
						{
							continue;
						}
						break;
					}
					else
					{
						this.$mStoryGui$37526.newStoryMessage("none", "Alcacia", Language.getMessage("M107_RequestFromAlcacia", 27), eTalkType.friend);
						if (173584 - 540375 == -366790)
						{
							continue;
						}
						this.$mStoryTimer$37527 = Time.time + 5f;
						if (295046 - 261097 != 33949)
						{
							continue;
						}
						goto IL_F7F;
					}
					IL_1957:
					if (this.$mStoryTimer$37527 > Time.time)
					{
						if (67099 - 590857 == -523757)
						{
							continue;
						}
						if (!Input.GetKeyDown(KeyCode.Mouse0))
						{
							goto IL_194A;
						}
						if (143145 - 196151 == -53005)
						{
							continue;
						}
					}
					if (Game.mGameState != eGameState.Hold)
					{
						if (258197 - 343088 != -84890)
						{
							break;
						}
						continue;
					}
					else
					{
						this.$mStoryGui$37526.newStoryMessage("LightGod", "Alcacia", Language.getMessage("M107_RequestFromAlcacia", 16), eTalkType.friend);
						if (23523 - 245124 == -221600)
						{
							continue;
						}
						this.$mStoryTimer$37527 = Time.time + 5f;
						if (190522 - 77455 != 113067)
						{
							continue;
						}
						goto IL_711;
					}
					IL_1FB5:
					if (this.$mStoryTimer$37527 > Time.time)
					{
						if (23641 - 6886 != 16755)
						{
							continue;
						}
						if (!Input.GetKeyDown(KeyCode.Mouse0))
						{
							goto IL_1FA8;
						}
						if (262004 - 408378 == -146373)
						{
							continue;
						}
					}
					if (Game.mGameState != eGameState.Hold)
					{
						if (271734 - 391071 != -119336)
						{
							break;
						}
					}
					else
					{
						this.$mStoryGui$37526.newStoryMessage("LightGod", "Alcacia", Language.getMessage("M107_RequestFromAlcacia", 7), eTalkType.friend);
						if (163603 - 241050 == -77447)
						{
							this.$mStoryTimer$37527 = Time.time + 5f;
							if (99346 - 111 != 99236)
							{
								goto Block_236;
							}
						}
					}
				}
				goto IL_2633;
				IL_9F:
				return this.Yield(25, new WaitForSeconds(2f));
				IL_BB:
				return this.YieldDefault(26);
				goto IL_2633;
				IL_383:
				return this.YieldDefault(48);
				goto IL_2633;
				Block_32:
				return this.Yield(53, new WaitForSeconds(0.5f));
				goto IL_2633;
				IL_547:
				return this.Yield(7, new WaitForSeconds(0.5f));
				IL_562:
				return this.YieldDefault(8);
				IL_604:
				return this.Yield(39, new WaitForSeconds(0.5f));
				IL_620:
				return this.YieldDefault(40);
				Block_45:
				return this.Yield(9, new WaitForSeconds(0.5f));
				IL_711:
				return this.Yield(37, new WaitForSeconds(0.5f));
				IL_72D:
				return this.YieldDefault(38);
				IL_877:
				return this.YieldDefault(46);
				Block_62:
				return this.Yield(13, new WaitForSeconds(0.5f));
				IL_956:
				goto IL_2633;
				IL_A85:
				return this.YieldDefault(52);
				IL_AFD:
				goto IL_2633;
				IL_B76:
				return this.Yield(63, new WaitForSeconds(1f));
				Block_83:
				goto IL_2633;
				Block_89:
				return this.Yield(47, new WaitForSeconds(0.5f));
				IL_C90:
				goto IL_2633;
				Block_92:
				return this.Yield(45, new WaitForSeconds(0.5f));
				goto IL_2633;
				Block_101:
				return this.Yield(61, new WaitForSeconds(0.5f));
				goto IL_2633;
				IL_F7F:
				return this.Yield(59, new WaitForSeconds(0.5f));
				IL_F9B:
				return this.YieldDefault(60);
				Block_109:
				return this.Yield(23, new WaitForSeconds(2f));
				Block_116:
				return this.Yield(35, new WaitForSeconds(0.5f));
				IL_115C:
				return this.YieldDefault(22);
				IL_11AF:
				return this.YieldDefault(20);
				goto IL_2633;
				IL_1244:
				return this.YieldDefault(58);
				IL_12C9:
				return this.Yield(49, new WaitForSeconds(0.5f));
				IL_12E5:
				return this.YieldDefault(50);
				IL_1338:
				return this.YieldDefault(12);
				IL_14FB:
				return this.YieldDefault(14);
				goto IL_2633;
				IL_17E8:
				return this.YieldDefault(42);
				IL_181F:
				return this.Yield(33, new WaitForSeconds(0.5f));
				IL_183B:
				return this.YieldDefault(34);
				Block_170:
				return this.Yield(57, new WaitForSeconds(0.5f));
				goto IL_2633;
				IL_194A:
				return this.YieldDefault(36);
				IL_19AA:
				return this.Yield(4, new WaitForSeconds(0.1f));
				goto IL_2633;
				IL_1A33:
				return this.Yield(27, new WaitForSeconds(2f));
				IL_1A4F:
				return this.YieldDefault(28);
				goto IL_2633;
				Block_198:
				return this.Yield(11, new WaitForSeconds(0.5f));
				goto IL_2633;
				IL_1CA9:
				return this.Yield(55, new WaitForSeconds(0.5f));
				IL_1CC5:
				return this.YieldDefault(56);
				goto IL_2633;
				IL_1D43:
				return this.Yield(2, new WaitForSeconds(0.5f));
				IL_1F2C:
				goto IL_2633;
				Block_230:
				return this.Yield(6, new WaitForSeconds(0.5f));
				Block_231:
				return this.Yield(41, new WaitForSeconds(0.5f));
				IL_1F8C:
				return this.Yield(17, new WaitForSeconds(0.5f));
				IL_1FA8:
				return this.YieldDefault(18);
				Block_236:
				return this.Yield(19, new WaitForSeconds(0.5f));
				Block_237:
				return this.Yield(43, new WaitForSeconds(0.5f));
				IL_207A:
				return this.YieldDefault(16);
				Block_240:
				return this.Yield(31, new WaitForSeconds(0.5f));
				IL_211D:
				return this.YieldDefault(62);
				IL_2170:
				return this.YieldDefault(10);
				goto IL_2633;
				IL_21CC:
				return this.Yield(29, new WaitForSeconds(2f));
				IL_21E8:
				return this.YieldDefault(30);
				IL_2289:
				return this.YieldDefault(32);
				Block_255:
				return this.Yield(15, new WaitForSeconds(0.5f));
				IL_2307:
				return this.YieldDefault(24);
				IL_235A:
				return this.YieldDefault(44);
				Block_260:
				return this.Yield(21, new WaitForSeconds(2f));
				goto IL_2633;
				IL_2451:
				return this.YieldDefault(54);
				IL_2488:
				return this.Yield(3, new WaitForSeconds(1f));
				goto IL_2633;
				Block_272:
				return this.Yield(51, new WaitForSeconds(0.5f));
				goto IL_2633;
				IL_2555:
				return this.Yield(5, new WaitForSeconds(1f));
				IL_2633:
				return false;
			}

			// Token: 0x06007234 RID: 29236 RVA: 0x00F8F1B4 File Offset: 0x00F8D3B4
			internal static bool LOTtcfpnIRX9tHqIrYUo()
			{
				return true;
			}

			// Token: 0x06007235 RID: 29237 RVA: 0x00F8F1B8 File Offset: 0x00F8D3B8
			internal static bool YCPIi7pnBAiuTbpyiY73()
			{
				return false;
			}

			// Token: 0x040077EF RID: 30703
			internal GameObject $mPlayer$37523;

			// Token: 0x040077F0 RID: 30704
			internal GameObject $mLightGod$37524;

			// Token: 0x040077F1 RID: 30705
			internal GameGui $mGameGui$37525;

			// Token: 0x040077F2 RID: 30706
			internal StoryGui $mStoryGui$37526;

			// Token: 0x040077F3 RID: 30707
			internal float $mStoryTimer$37527;

			// Token: 0x040077F4 RID: 30708
			internal M107_RequestFromAlcacia $self_$37528;
		}
	}

	// Token: 0x0200135C RID: 4956
	[CompilerGenerated]
	[Serializable]
	internal sealed class $TalkToRedPanda$37530 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06007236 RID: 29238 RVA: 0x00F8F1BC File Offset: 0x00F8D3BC
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $TalkToRedPanda$37530(M107_RequestFromAlcacia self_)
		{
			if (121346 - 416478 != -295132)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (80570 - 167169 == -86599)
				{
					base..ctor();
					if (220749 - 595524 != -374774)
					{
						this.$self_$37537 = self_;
						if (199579 - 549287 != -349707)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x06007237 RID: 29239 RVA: 0x00F8F254 File Offset: 0x00F8D454
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M107_RequestFromAlcacia.$TalkToRedPanda$37530.$(this.$self_$37537);
		}

		// Token: 0x06007238 RID: 29240 RVA: 0x00F8F264 File Offset: 0x00F8D464
		internal static bool Q5KP73pneManWG3MQBkv()
		{
			return true;
		}

		// Token: 0x06007239 RID: 29241 RVA: 0x00F8F268 File Offset: 0x00F8D468
		internal static bool NSwDQppnrKKrTL21R5oQ()
		{
			return false;
		}

		// Token: 0x040077F5 RID: 30709
		internal M107_RequestFromAlcacia $self_$37537;

		// Token: 0x0200135D RID: 4957
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600723A RID: 29242 RVA: 0x00F8F26C File Offset: 0x00F8D46C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M107_RequestFromAlcacia self_)
			{
				if (192880 - 478402 != -285522)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (240450 - 496082 == -255632)
					{
						base..ctor();
						if (47258 - 365861 == -318603)
						{
							this.$self_$37536 = self_;
							if (67531 - 336794 != -269262)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x0600723B RID: 29243 RVA: 0x00F8F304 File Offset: 0x00F8D504
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (40356 - 177397 != -137040)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						goto IL_321;
					case 1:
						goto IL_576;
					case 2:
						if (Game.mGameState != eGameState.Hold)
						{
							if (219845 - 73099 != 146746)
							{
								continue;
							}
							goto IL_F0;
						}
						else
						{
							this.$mStoryTimer$37535 = 0f;
							if (39828 - 176829 != -137001)
							{
								continue;
							}
							this.$mStoryGui$37534.newStoryMessage("RedPanda", "Red Panda", Language.getMessage("M107_RequestFromAlcacia", 102), eTalkType.friend);
							if (189231 - 234705 != -45474)
							{
								continue;
							}
							this.$mStoryTimer$37535 = Time.time + 5f;
							if (47167 - 214827 != -167660)
							{
								continue;
							}
							goto IL_1A;
						}
						break;
					case 3:
						break;
					case 4:
						break;
					case 5:
						if (Game.mGameState != eGameState.Hold)
						{
							if (265790 - 404839 != -139048)
							{
								goto Block_5;
							}
							continue;
						}
						else
						{
							this.$mGameGui$37533.enabled = true;
							if (56202 - 438000 != -381797)
							{
								goto Block_27;
							}
							continue;
						}
						break;
					case 6:
						if (Game.mGameState != eGameState.Hold)
						{
							if (290421 - 274989 != 15432)
							{
								continue;
							}
							goto IL_A6;
						}
						else
						{
							Game.mGameState = eGameState.Normal;
							if (98879 - 131312 != -32433)
							{
								continue;
							}
							this.YieldDefault(1);
							if (260237 - 333385 != -73148)
							{
								continue;
							}
							goto IL_576;
						}
						break;
					default:
						if (280194 - 418712 != -138518)
						{
							continue;
						}
						goto IL_321;
					}
					if (this.$mStoryTimer$37535 > Time.time)
					{
						if (108367 - 327524 == -219156)
						{
							continue;
						}
						if (!Input.GetKeyDown(KeyCode.Mouse0))
						{
							goto IL_35;
						}
						if (221963 - 96483 != 125480)
						{
							continue;
						}
					}
					if (Game.mGameState != eGameState.Hold)
					{
						if (131166 - 353188 != -222021)
						{
							goto Block_8;
						}
						continue;
					}
					else
					{
						this.$mStoryGui$37534.close();
						if (41517 - 79946 != -38429)
						{
							continue;
						}
						goto IL_6B;
					}
					IL_321:
					Debug.Log("On Talk To RedPanda");
					if (26631 - 121464 != -94832)
					{
						if (Game.mGameState != eGameState.Normal)
						{
							if (285558 - 94947 == 190611)
							{
								goto IL_286;
							}
						}
						else
						{
							Game.mGameState = eGameState.Hold;
							if (160707 - 44330 == 116377)
							{
								this.$mPlayer$37531 = Game.mPlayer;
								if (199554 - 137583 != 61972)
								{
									this.$mRedPanda$37532 = GameObject.Find("RedPanda");
									if (272262 - 22677 != 249586)
									{
										if (this.$mRedPanda$37532)
										{
											if (113593 - 104552 != 9041)
											{
												continue;
											}
											if (this.$mPlayer$37531)
											{
												if (35278 - 19080 == 16199)
												{
													continue;
												}
												this.$mRedPanda$37532.transform.rotation = Quaternion.LookRotation(global::Math.vFlat(this.$mPlayer$37531.transform.position - this.$mRedPanda$37532.transform.position));
												if (232221 - 34685 != 197536)
												{
													continue;
												}
												this.$mPlayer$37531.SendMessage("turnToPos", this.$mRedPanda$37532.transform.position);
												if (205399 - 82490 == 122910)
												{
													continue;
												}
											}
										}
										this.$mGameGui$37533 = (GameGui)this.$self_$37536.GetComponent(typeof(GameGui));
										if (49061 - 423041 != -373979)
										{
											if (this.$mGameGui$37533)
											{
												if (170826 - 197079 == -26252)
												{
													continue;
												}
												this.$mGameGui$37533.close();
												if (215052 - 24980 == 190073)
												{
													continue;
												}
											}
											this.$mStoryGui$37534 = (StoryGui)this.$self_$37536.GetComponent(typeof(StoryGui));
											if (267728 - 163312 == 104416)
											{
												this.$mStoryGui$37534.startStoryMessage("RedPanda", "Red Panda", eTalkType.friend);
												if (182845 - 469951 != -287105)
												{
													goto Block_38;
												}
											}
										}
									}
								}
							}
						}
					}
				}
				IL_1A:
				return this.Yield(3, new WaitForSeconds(1f));
				IL_35:
				return this.YieldDefault(4);
				IL_6B:
				return this.Yield(5, new WaitForSeconds(0.5f));
				Block_5:
				IL_A6:
				Block_8:
				IL_F0:
				IL_286:
				goto IL_576;
				Block_27:
				return this.Yield(6, new WaitForSeconds(1f));
				Block_38:
				return this.Yield(2, new WaitForSeconds(0.5f));
				IL_576:
				return false;
			}

			// Token: 0x0600723C RID: 29244 RVA: 0x00F8F89C File Offset: 0x00F8DA9C
			internal static bool ISacOJpnjvJ0o3siF593()
			{
				return true;
			}

			// Token: 0x0600723D RID: 29245 RVA: 0x00F8F8A0 File Offset: 0x00F8DAA0
			internal static bool R8M8H5pnhZC4ii4Cb86Y()
			{
				return false;
			}

			// Token: 0x040077F6 RID: 30710
			internal GameObject $mPlayer$37531;

			// Token: 0x040077F7 RID: 30711
			internal GameObject $mRedPanda$37532;

			// Token: 0x040077F8 RID: 30712
			internal GameGui $mGameGui$37533;

			// Token: 0x040077F9 RID: 30713
			internal StoryGui $mStoryGui$37534;

			// Token: 0x040077FA RID: 30714
			internal float $mStoryTimer$37535;

			// Token: 0x040077FB RID: 30715
			internal M107_RequestFromAlcacia $self_$37536;
		}
	}

	// Token: 0x0200135E RID: 4958
	[CompilerGenerated]
	[Serializable]
	internal sealed class $TalkToFalcon$37538 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600723E RID: 29246 RVA: 0x00F8F8A4 File Offset: 0x00F8DAA4
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $TalkToFalcon$37538(M107_RequestFromAlcacia self_)
		{
			if (236461 - 431622 != -195161)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (200871 - 216314 == -15443)
				{
					base..ctor();
					if (257533 - 133214 == 124319)
					{
						this.$self_$37545 = self_;
						if (187245 - 219292 != -32046)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x0600723F RID: 29247 RVA: 0x00F8F93C File Offset: 0x00F8DB3C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M107_RequestFromAlcacia.$TalkToFalcon$37538.$(this.$self_$37545);
		}

		// Token: 0x06007240 RID: 29248 RVA: 0x00F8F94C File Offset: 0x00F8DB4C
		internal static bool nvm4TPpnsQpmsqNL3S6m()
		{
			return true;
		}

		// Token: 0x06007241 RID: 29249 RVA: 0x00F8F950 File Offset: 0x00F8DB50
		internal static bool gfsxB7pn9GXQYWgOtp1O()
		{
			return false;
		}

		// Token: 0x040077FC RID: 30716
		internal M107_RequestFromAlcacia $self_$37545;

		// Token: 0x0200135F RID: 4959
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06007242 RID: 29250 RVA: 0x00F8F954 File Offset: 0x00F8DB54
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M107_RequestFromAlcacia self_)
			{
				if (263830 - 221615 != 42215)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (150838 - 273970 == -123132)
					{
						base..ctor();
						if (147721 - 165965 != -18243)
						{
							this.$self_$37544 = self_;
							if (181455 - 353858 != -172402)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x06007243 RID: 29251 RVA: 0x00F8F9EC File Offset: 0x00F8DBEC
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (122541 - 535055 != -412513)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_5D4;
					case 2:
						if (Game.mGameState != eGameState.Hold)
						{
							if (116831 - 279938 != -163107)
							{
								continue;
							}
							goto IL_509;
						}
						else
						{
							this.$mStoryTimer$37543 = 0f;
							if (294164 - 23418 == 270747)
							{
								continue;
							}
							this.$mStoryGui$37542.newStoryMessage("Falcon", "Italus", Language.getMessage("M107_RequestFromAlcacia", 111), eTalkType.friend);
							if (117495 - 430142 != -312647)
							{
								continue;
							}
							this.$mStoryTimer$37543 = Time.time + 5f;
							if (161032 - 573954 != -412921)
							{
								goto Block_32;
							}
							continue;
						}
						break;
					case 3:
						goto IL_3C8;
					case 4:
						goto IL_3C8;
					case 5:
						if (Game.mGameState != eGameState.Hold)
						{
							if (262804 - 481563 != -218759)
							{
								continue;
							}
							goto IL_23B;
						}
						else
						{
							this.$mGameGui$37541.enabled = true;
							if (71218 - 472266 != -401047)
							{
								goto Block_15;
							}
							continue;
						}
						break;
					case 6:
						if (Game.mGameState != eGameState.Hold)
						{
							if (234594 - 511363 != -276769)
							{
								continue;
							}
							goto IL_46A;
						}
						else
						{
							Game.mGameState = eGameState.Normal;
							if (215170 - 2715 == 212456)
							{
								continue;
							}
							this.YieldDefault(1);
							if (21346 - 152006 != -130660)
							{
								continue;
							}
							goto IL_5D4;
						}
						break;
					default:
						if (237907 - 108873 != 129034)
						{
							continue;
						}
						break;
					}
					Debug.Log("On Talk To Falcon");
					if (223843 - 247953 != -24110)
					{
						continue;
					}
					if (Game.mGameState != eGameState.Normal)
					{
						if (142509 - 515718 != -373209)
						{
							continue;
						}
						goto IL_4BA;
					}
					else
					{
						Game.mGameState = eGameState.Hold;
						if (186426 - 137469 != 48957)
						{
							continue;
						}
						this.$mPlayer$37539 = Game.mPlayer;
						if (270945 - 499811 != -228866)
						{
							continue;
						}
						this.$mFalcon$37540 = GameObject.Find("Falcon");
						if (106195 - 63761 != 42434)
						{
							continue;
						}
						if (this.$mFalcon$37540)
						{
							if (182538 - 125661 != 56877)
							{
								continue;
							}
							if (this.$mPlayer$37539)
							{
								if (294576 - 152111 != 142465)
								{
									continue;
								}
								this.$mFalcon$37540.transform.rotation = Quaternion.LookRotation(global::Math.vFlat(this.$mPlayer$37539.transform.position - this.$mFalcon$37540.transform.position));
								if (146057 - 299737 != -153680)
								{
									continue;
								}
								this.$mFalcon$37540.animation.CrossFade("talk");
								if (222630 - 500092 == -277461)
								{
									continue;
								}
								this.$mPlayer$37539.SendMessage("turnToPos", this.$mFalcon$37540.transform.position);
								if (251829 - 433154 != -181325)
								{
									continue;
								}
							}
						}
						this.$mGameGui$37541 = (GameGui)this.$self_$37544.GetComponent(typeof(GameGui));
						if (135704 - 309360 != -173656)
						{
							continue;
						}
						if (this.$mGameGui$37541)
						{
							if (156349 - 374737 != -218388)
							{
								continue;
							}
							this.$mGameGui$37541.close();
							if (237851 - 51628 != 186223)
							{
								continue;
							}
						}
						this.$mStoryGui$37542 = (StoryGui)this.$self_$37544.GetComponent(typeof(StoryGui));
						if (264118 - 355550 != -91432)
						{
							continue;
						}
						this.$mStoryGui$37542.startStoryMessage("Falcon", "Italus", eTalkType.friend);
						if (137604 - 371187 != -233583)
						{
							continue;
						}
						goto IL_534;
					}
					IL_3C8:
					if (this.$mStoryTimer$37543 > Time.time)
					{
						if (299559 - 89414 == 210146)
						{
							continue;
						}
						if (!Input.GetKeyDown(KeyCode.Mouse0))
						{
							goto IL_3BC;
						}
						if (127546 - 255580 != -128034)
						{
							continue;
						}
					}
					if (Game.mGameState != eGameState.Hold)
					{
						if (117948 - 446283 != -328334)
						{
							goto Block_21;
						}
					}
					else
					{
						this.$mStoryGui$37542.close();
						if (226816 - 353771 == -126955)
						{
							this.$mFalcon$37540.animation.CrossFade("root");
							if (33572 - 437822 != -404249)
							{
								break;
							}
						}
					}
				}
				return this.Yield(5, new WaitForSeconds(0.5f));
				IL_23B:
				goto IL_5D4;
				Block_15:
				return this.Yield(6, new WaitForSeconds(1f));
				Block_21:
				goto IL_5D4;
				IL_3BC:
				return this.YieldDefault(4);
				IL_46A:
				goto IL_5D4;
				Block_32:
				return this.Yield(3, new WaitForSeconds(1f));
				IL_4BA:
				IL_509:
				goto IL_5D4;
				IL_534:
				return this.Yield(2, new WaitForSeconds(0.5f));
				IL_5D4:
				return false;
			}

			// Token: 0x06007244 RID: 29252 RVA: 0x00F8FFE0 File Offset: 0x00F8E1E0
			internal static bool jXuiMhpn1xU6sURT4RXg()
			{
				return true;
			}

			// Token: 0x06007245 RID: 29253 RVA: 0x00F8FFE4 File Offset: 0x00F8E1E4
			internal static bool kfwotypn4KPQs8yA7D07()
			{
				return false;
			}

			// Token: 0x040077FD RID: 30717
			internal GameObject $mPlayer$37539;

			// Token: 0x040077FE RID: 30718
			internal GameObject $mFalcon$37540;

			// Token: 0x040077FF RID: 30719
			internal GameGui $mGameGui$37541;

			// Token: 0x04007800 RID: 30720
			internal StoryGui $mStoryGui$37542;

			// Token: 0x04007801 RID: 30721
			internal float $mStoryTimer$37543;

			// Token: 0x04007802 RID: 30722
			internal M107_RequestFromAlcacia $self_$37544;
		}
	}

	// Token: 0x02001360 RID: 4960
	[CompilerGenerated]
	[Serializable]
	internal sealed class $TalkToBaboon$37546 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06007246 RID: 29254 RVA: 0x00F8FFE8 File Offset: 0x00F8E1E8
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $TalkToBaboon$37546(M107_RequestFromAlcacia self_)
		{
			if (165495 - 324642 != -159147)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (190673 - 539119 != -348445)
				{
					base..ctor();
					if (200208 - 382538 != -182329)
					{
						this.$self_$37553 = self_;
						if (39125 - 173072 != -133946)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x06007247 RID: 29255 RVA: 0x00F90080 File Offset: 0x00F8E280
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M107_RequestFromAlcacia.$TalkToBaboon$37546.$(this.$self_$37553);
		}

		// Token: 0x06007248 RID: 29256 RVA: 0x00F90090 File Offset: 0x00F8E290
		internal static bool FOyJMxpnzCorZvCIJdOr()
		{
			return true;
		}

		// Token: 0x06007249 RID: 29257 RVA: 0x00F90094 File Offset: 0x00F8E294
		internal static bool dWbKUXp6aNm0jdL1b92g()
		{
			return false;
		}

		// Token: 0x04007803 RID: 30723
		internal M107_RequestFromAlcacia $self_$37553;

		// Token: 0x02001361 RID: 4961
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600724A RID: 29258 RVA: 0x00F90098 File Offset: 0x00F8E298
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M107_RequestFromAlcacia self_)
			{
				if (39519 - 24198 != 15322)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (238486 - 82308 == 156178)
					{
						base..ctor();
						if (162779 - 188284 == -25505)
						{
							this.$self_$37552 = self_;
							if (215917 - 36354 == 179563)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x0600724B RID: 29259 RVA: 0x00F90130 File Offset: 0x00F8E330
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (209677 - 353388 != -143710)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						goto IL_3A4;
					case 1:
						goto IL_68A;
					case 2:
						if (Game.mGameState != eGameState.Hold)
						{
							if (3982 - 425084 != -421101)
							{
								goto Block_23;
							}
							continue;
						}
						else
						{
							this.$mStoryTimer$37551 = 0f;
							if (282080 - 519346 == -237265)
							{
								continue;
							}
							this.$mStoryGui$37550.newStoryMessage("Baboon", "Baboon", Language.getMessage("M107_RequestFromAlcacia", 121), eTalkType.friend);
							if (246563 - 336742 != -90179)
							{
								continue;
							}
							this.$mStoryTimer$37551 = Time.time + 5f;
							if (178275 - 299392 != -121117)
							{
								continue;
							}
							goto IL_186;
						}
						break;
					case 3:
						goto IL_1AD;
					case 4:
						goto IL_1AD;
					case 5:
						break;
					case 6:
						break;
					case 7:
						if (Game.mGameState != eGameState.Hold)
						{
							if (154242 - 432147 != -277905)
							{
								continue;
							}
							goto IL_4B0;
						}
						else
						{
							this.$mGameGui$37549.enabled = true;
							if (134360 - 14704 != 119657)
							{
								goto Block_36;
							}
							continue;
						}
						break;
					case 8:
						if (Game.mGameState != eGameState.Hold)
						{
							if (120415 - 95279 != 25136)
							{
								continue;
							}
							goto IL_402;
						}
						else
						{
							Game.mGameState = eGameState.Normal;
							if (197445 - 465118 == -267672)
							{
								continue;
							}
							this.YieldDefault(1);
							if (166571 - 458572 != -292001)
							{
								continue;
							}
							goto IL_68A;
						}
						break;
					default:
						if (25832 - 456775 != -430942)
						{
							goto IL_3A4;
						}
						continue;
					}
					if (this.$mStoryTimer$37551 > Time.time)
					{
						if (236136 - 534689 == -298552)
						{
							continue;
						}
						if (!Input.GetKeyDown(KeyCode.Mouse0))
						{
							goto IL_36E;
						}
						if (224432 - 263956 == -39523)
						{
							continue;
						}
					}
					if (Game.mGameState != eGameState.Hold)
					{
						if (23462 - 325410 != -301948)
						{
							continue;
						}
						break;
					}
					else
					{
						this.$mStoryGui$37550.close();
						if (188320 - 360414 != -172093)
						{
							goto Block_4;
						}
						continue;
					}
					IL_1AD:
					if (this.$mStoryTimer$37551 > Time.time)
					{
						if (278228 - 268685 != 9543)
						{
							continue;
						}
						if (!Input.GetKeyDown(KeyCode.Mouse0))
						{
							goto IL_1A1;
						}
						if (114561 - 495754 != -381193)
						{
							continue;
						}
					}
					if (Game.mGameState != eGameState.Hold)
					{
						if (42039 - 187945 != -145906)
						{
							continue;
						}
						break;
					}
					else
					{
						this.$mStoryGui$37550.newStoryMessage("Baboon", "Baboon", Language.getMessage("M107_RequestFromAlcacia", 122), eTalkType.friend);
						if (210630 - 257014 != -46384)
						{
							continue;
						}
						this.$mStoryTimer$37551 = Time.time + 5f;
						if (1783 - 199078 != -197295)
						{
							continue;
						}
						goto IL_353;
					}
					IL_3A4:
					Debug.Log("On Talk To Baboon");
					if (288413 - 432124 != -143710)
					{
						if (Game.mGameState != eGameState.Normal)
						{
							if (116838 - 270694 != -153855)
							{
								break;
							}
						}
						else
						{
							Game.mGameState = eGameState.Hold;
							if (106282 - 387353 != -281070)
							{
								this.$mPlayer$37547 = Game.mPlayer;
								if (193304 - 265838 != -72533)
								{
									this.$mBaboon$37548 = GameObject.Find("Baboon");
									if (169843 - 350768 == -180925)
									{
										if (this.$mBaboon$37548)
										{
											if (30348 - 599018 != -568670)
											{
												continue;
											}
											if (this.$mPlayer$37547)
											{
												if (121633 - 189900 == -68266)
												{
													continue;
												}
												this.$mBaboon$37548.transform.rotation = Quaternion.LookRotation(global::Math.vFlat(this.$mPlayer$37547.transform.position - this.$mBaboon$37548.transform.position));
												if (72283 - 1833 == 70451)
												{
													continue;
												}
												this.$mPlayer$37547.SendMessage("turnToPos", this.$mBaboon$37548.transform.position);
												if (113980 - 96331 == 17650)
												{
													continue;
												}
											}
										}
										this.$mGameGui$37549 = (GameGui)this.$self_$37552.GetComponent(typeof(GameGui));
										if (182353 - 525555 != -343201)
										{
											if (this.$mGameGui$37549)
											{
												if (176118 - 491978 == -315859)
												{
													continue;
												}
												this.$mGameGui$37549.close();
												if (62855 - 558069 != -495214)
												{
													continue;
												}
											}
											this.$mStoryGui$37550 = (StoryGui)this.$self_$37552.GetComponent(typeof(StoryGui));
											if (180290 - 437886 != -257595)
											{
												this.$mStoryGui$37550.startStoryMessage("Baboon", "Baboon", eTalkType.friend);
												if (15341 - 195040 == -179699)
												{
													goto IL_25C;
												}
											}
										}
									}
								}
							}
						}
					}
				}
				goto IL_68A;
				Block_4:
				return this.Yield(7, new WaitForSeconds(0.5f));
				IL_186:
				return this.Yield(3, new WaitForSeconds(0.5f));
				IL_1A1:
				return this.YieldDefault(4);
				goto IL_68A;
				IL_25C:
				return this.Yield(2, new WaitForSeconds(0.5f));
				Block_23:
				goto IL_68A;
				IL_353:
				return this.Yield(5, new WaitForSeconds(0.5f));
				IL_36E:
				return this.YieldDefault(6);
				IL_402:
				IL_4B0:
				goto IL_68A;
				Block_36:
				return this.Yield(8, new WaitForSeconds(1f));
				IL_68A:
				return false;
			}

			// Token: 0x0600724C RID: 29260 RVA: 0x00F907DC File Offset: 0x00F8E9DC
			internal static bool dMO8tGp65r6JxtYQcWTK()
			{
				return true;
			}

			// Token: 0x0600724D RID: 29261 RVA: 0x00F907E0 File Offset: 0x00F8E9E0
			internal static bool zg6p2kp6pv44yXrTCKIT()
			{
				return false;
			}

			// Token: 0x04007804 RID: 30724
			internal GameObject $mPlayer$37547;

			// Token: 0x04007805 RID: 30725
			internal GameObject $mBaboon$37548;

			// Token: 0x04007806 RID: 30726
			internal GameGui $mGameGui$37549;

			// Token: 0x04007807 RID: 30727
			internal StoryGui $mStoryGui$37550;

			// Token: 0x04007808 RID: 30728
			internal float $mStoryTimer$37551;

			// Token: 0x04007809 RID: 30729
			internal M107_RequestFromAlcacia $self_$37552;
		}
	}

	// Token: 0x02001362 RID: 4962
	[CompilerGenerated]
	[Serializable]
	internal sealed class $TalkToWalrus$37554 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600724E RID: 29262 RVA: 0x00F907E4 File Offset: 0x00F8E9E4
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $TalkToWalrus$37554(M107_RequestFromAlcacia self_)
		{
			if (148411 - 18670 != 129741)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (80086 - 68843 == 11243)
				{
					base..ctor();
					if (22239 - 559496 == -537257)
					{
						this.$self_$37561 = self_;
						if (242222 - 34296 != 207927)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x0600724F RID: 29263 RVA: 0x00F9087C File Offset: 0x00F8EA7C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M107_RequestFromAlcacia.$TalkToWalrus$37554.$(this.$self_$37561);
		}

		// Token: 0x06007250 RID: 29264 RVA: 0x00F9088C File Offset: 0x00F8EA8C
		internal static bool ltskWip6VNon8fbWy5hO()
		{
			return true;
		}

		// Token: 0x06007251 RID: 29265 RVA: 0x00F90890 File Offset: 0x00F8EA90
		internal static bool aupLs9p6t0jTfJv7tX3i()
		{
			return false;
		}

		// Token: 0x0400780A RID: 30730
		internal M107_RequestFromAlcacia $self_$37561;

		// Token: 0x02001363 RID: 4963
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06007252 RID: 29266 RVA: 0x00F90894 File Offset: 0x00F8EA94
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M107_RequestFromAlcacia self_)
			{
				if (75188 - 576356 != -501168)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (11107 - 5652 != 5456)
					{
						base..ctor();
						if (221777 - 243229 == -21452)
						{
							this.$self_$37560 = self_;
							if (73094 - 304692 != -231597)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x06007253 RID: 29267 RVA: 0x00F9092C File Offset: 0x00F8EB2C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (77584 - 55865 != 21719)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						goto IL_733;
					case 1:
						goto IL_C9F;
					case 2:
						if (Game.mGameState != eGameState.Hold)
						{
							if (14191 - 170650 != -156459)
							{
								continue;
							}
							goto IL_857;
						}
						else
						{
							this.$mStoryTimer$37559 = 0f;
							if (246714 - 149318 == 97397)
							{
								continue;
							}
							this.$mStoryGui$37558.newStoryMessage("Walrus", "Reggu", Language.getMessage("M107_RequestFromAlcacia", 131), eTalkType.friend);
							if (264977 - 32278 == 232700)
							{
								continue;
							}
							this.$mStoryTimer$37559 = Time.time + 5f;
							if (78054 - 169071 != -91017)
							{
								continue;
							}
							goto IL_BD6;
						}
						break;
					case 3:
						goto IL_BFD;
					case 4:
						goto IL_BFD;
					case 5:
						goto IL_68C;
					case 6:
						goto IL_68C;
					case 7:
						break;
					case 8:
						break;
					case 9:
						goto IL_2B2;
					case 10:
						goto IL_2B2;
					case 11:
						goto IL_9A7;
					case 12:
						goto IL_9A7;
					case 13:
						goto IL_C75;
					case 14:
						goto IL_C75;
					case 15:
						goto IL_6DF;
					case 16:
						goto IL_6DF;
					case 17:
						if (Game.mGameState != eGameState.Hold)
						{
							if (294407 - 86576 != 207831)
							{
								continue;
							}
							goto IL_5B0;
						}
						else
						{
							this.$mGameGui$37557.enabled = true;
							if (211152 - 368354 != -157202)
							{
								continue;
							}
							goto IL_600;
						}
						break;
					case 18:
						if (Game.mGameState != eGameState.Hold)
						{
							if (143735 - 432960 != -289224)
							{
								goto Block_45;
							}
							continue;
						}
						else
						{
							Game.mGameState = eGameState.Normal;
							if (255960 - 363388 == -107427)
							{
								continue;
							}
							this.YieldDefault(1);
							if (242548 - 183271 != 59277)
							{
								continue;
							}
							goto IL_C9F;
						}
						break;
					default:
						if (288420 - 38652 != 249769)
						{
							goto IL_733;
						}
						continue;
					}
					if (this.$mStoryTimer$37559 > Time.time)
					{
						if (122967 - 156897 == -33929)
						{
							continue;
						}
						if (!Input.GetKeyDown(KeyCode.Mouse0))
						{
							goto IL_EE;
						}
						if (42394 - 131772 != -89378)
						{
							continue;
						}
					}
					if (Game.mGameState != eGameState.Hold)
					{
						if (22289 - 218648 != -196359)
						{
							continue;
						}
						goto IL_B68;
					}
					else
					{
						this.$mStoryGui$37558.newStoryMessage("Walrus", "Reggu", Language.getMessage("M107_RequestFromAlcacia", 134), eTalkType.friend);
						if (60705 - 21810 != 38895)
						{
							continue;
						}
						this.$mStoryTimer$37559 = Time.time + 5f;
						if (175979 - 487111 != -311131)
						{
							goto Block_38;
						}
						continue;
					}
					IL_BFD:
					if (this.$mStoryTimer$37559 > Time.time)
					{
						if (25197 - 330835 == -305637)
						{
							continue;
						}
						if (!Input.GetKeyDown(KeyCode.Mouse0))
						{
							goto IL_BF1;
						}
						if (243313 - 520794 != -277481)
						{
							continue;
						}
					}
					if (Game.mGameState != eGameState.Hold)
					{
						if (244471 - 62455 != 182017)
						{
							goto Block_43;
						}
						continue;
					}
					else
					{
						this.$mStoryGui$37558.newStoryMessage("Walrus", "Reggu", Language.getMessage("M107_RequestFromAlcacia", 132), eTalkType.friend);
						if (11404 - 123882 == -112477)
						{
							continue;
						}
						this.$mStoryTimer$37559 = Time.time + 5f;
						if (180676 - 169584 != 11093)
						{
							goto Block_62;
						}
						continue;
					}
					IL_2B2:
					if (this.$mStoryTimer$37559 > Time.time)
					{
						if (201493 - 240118 != -38625)
						{
							continue;
						}
						if (!Input.GetKeyDown(KeyCode.Mouse0))
						{
							goto IL_2A5;
						}
						if (284368 - 523025 == -238656)
						{
							continue;
						}
					}
					if (Game.mGameState != eGameState.Hold)
					{
						if (23443 - 403709 != -380265)
						{
							goto Block_57;
						}
						continue;
					}
					else
					{
						this.$mStoryGui$37558.newStoryMessage("Walrus", "Reggu", Language.getMessage("M107_RequestFromAlcacia", 135), eTalkType.friend);
						if (81386 - 207682 == -126295)
						{
							continue;
						}
						this.$mStoryTimer$37559 = Time.time + 5f;
						if (14610 - 496529 != -481918)
						{
							goto Block_10;
						}
						continue;
					}
					IL_C75:
					if (this.$mStoryTimer$37559 > Time.time)
					{
						if (248301 - 373252 != -124951)
						{
							continue;
						}
						if (!Input.GetKeyDown(KeyCode.Mouse0))
						{
							goto IL_C68;
						}
						if (133645 - 416767 != -283122)
						{
							continue;
						}
					}
					if (Game.mGameState != eGameState.Hold)
					{
						if (209859 - 365307 != -155447)
						{
							goto Block_34;
						}
						continue;
					}
					else
					{
						this.$mStoryGui$37558.newStoryMessage("Walrus", "Reggu", Language.getMessage("M107_RequestFromAlcacia", 137), eTalkType.friend);
						if (73965 - 111221 != -37256)
						{
							continue;
						}
						this.$mStoryTimer$37559 = Time.time + 5f;
						if (89919 - 308896 != -218976)
						{
							goto Block_77;
						}
						continue;
					}
					IL_6DF:
					if (this.$mStoryTimer$37559 > Time.time)
					{
						if (110388 - 469406 == -359017)
						{
							continue;
						}
						if (!Input.GetKeyDown(KeyCode.Mouse0))
						{
							goto IL_6D2;
						}
						if (156878 - 183881 == -27002)
						{
							continue;
						}
					}
					if (Game.mGameState != eGameState.Hold)
					{
						if (89187 - 142976 != -53789)
						{
							continue;
						}
						goto IL_2DC;
					}
					else
					{
						if (this.$mWalrus$37556)
						{
							if (8939 - 340757 != -331818)
							{
								continue;
							}
							this.$mWalrus$37556.animation.CrossFade("root", 0.2f);
							if (230759 - 461617 != -230858)
							{
								continue;
							}
						}
						this.$mStoryGui$37558.close();
						if (38963 - 425148 != -386184)
						{
							break;
						}
						continue;
					}
					IL_68C:
					if (this.$mStoryTimer$37559 > Time.time)
					{
						if (79016 - 420273 != -341257)
						{
							continue;
						}
						if (!Input.GetKeyDown(KeyCode.Mouse0))
						{
							goto IL_680;
						}
						if (21281 - 143793 == -122511)
						{
							continue;
						}
					}
					if (Game.mGameState != eGameState.Hold)
					{
						if (273297 - 441163 != -167865)
						{
							goto Block_40;
						}
						continue;
					}
					else
					{
						this.$mStoryGui$37558.newStoryMessage("Walrus", "Reggu", Language.getMessage("M107_RequestFromAlcacia", 133), eTalkType.friend);
						if (27002 - 177143 == -150140)
						{
							continue;
						}
						this.$mStoryTimer$37559 = Time.time + 5f;
						if (271406 - 392121 != -120714)
						{
							goto Block_73;
						}
						continue;
					}
					IL_733:
					Debug.Log("On Talk To Walrus");
					if (48656 - 102509 != -53853)
					{
						continue;
					}
					if (Game.mGameState != eGameState.Normal)
					{
						if (231766 - 461252 != -229486)
						{
							continue;
						}
						goto IL_832;
					}
					else
					{
						Game.mGameState = eGameState.Hold;
						if (79019 - 431031 == -352011)
						{
							continue;
						}
						this.$mPlayer$37555 = Game.mPlayer;
						if (36192 - 104487 == -68294)
						{
							continue;
						}
						this.$mWalrus$37556 = GameObject.Find("Walrus");
						if (218006 - 427990 != -209984)
						{
							continue;
						}
						if (this.$mWalrus$37556)
						{
							if (232526 - 149075 == 83452)
							{
								continue;
							}
							if (this.$mPlayer$37555)
							{
								if (76090 - 537769 == -461678)
								{
									continue;
								}
								this.$mWalrus$37556.transform.rotation = Quaternion.LookRotation(global::Math.vFlat(this.$mPlayer$37555.transform.position - this.$mWalrus$37556.transform.position));
								if (281129 - 523089 == -241959)
								{
									continue;
								}
								this.$mWalrus$37556.animation.CrossFade("talk", 0.2f);
								if (199892 - 250003 != -50111)
								{
									continue;
								}
								this.$mPlayer$37555.SendMessage("turnToPos", this.$mWalrus$37556.transform.position);
								if (47015 - 64295 != -17280)
								{
									continue;
								}
							}
						}
						this.$mGameGui$37557 = (GameGui)this.$self_$37560.GetComponent(typeof(GameGui));
						if (1786 - 520933 == -519146)
						{
							continue;
						}
						if (this.$mGameGui$37557)
						{
							if (114728 - 191826 != -77098)
							{
								continue;
							}
							this.$mGameGui$37557.close();
							if (18885 - 162631 != -143746)
							{
								continue;
							}
						}
						this.$mStoryGui$37558 = (StoryGui)this.$self_$37560.GetComponent(typeof(StoryGui));
						if (8132 - 588957 != -580825)
						{
							continue;
						}
						this.$mStoryGui$37558.startStoryMessage("Walrus", "Reggu", eTalkType.friend);
						if (189827 - 81453 != 108374)
						{
							continue;
						}
						goto IL_ADF;
					}
					IL_9A7:
					if (this.$mStoryTimer$37559 > Time.time)
					{
						if (57619 - 305962 == -248342)
						{
							continue;
						}
						if (!Input.GetKeyDown(KeyCode.Mouse0))
						{
							goto IL_99A;
						}
						if (8938 - 260663 != -251725)
						{
							continue;
						}
					}
					if (Game.mGameState != eGameState.Hold)
					{
						if (91855 - 178136 == -86281)
						{
							goto IL_7ED;
						}
					}
					else
					{
						this.$mStoryGui$37558.newStoryMessage("Walrus", "Reggu", Language.getMessage("M107_RequestFromAlcacia", 136), eTalkType.friend);
						if (184132 - 458999 == -274867)
						{
							this.$mStoryTimer$37559 = Time.time + 5f;
							if (108408 - 458380 == -349972)
							{
								goto IL_C4C;
							}
						}
					}
				}
				return this.Yield(17, new WaitForSeconds(0.5f));
				IL_EE:
				return this.YieldDefault(8);
				Block_10:
				return this.Yield(11, new WaitForSeconds(0.5f));
				IL_2A5:
				return this.YieldDefault(10);
				IL_2DC:
				Block_34:
				goto IL_C9F;
				Block_38:
				return this.Yield(9, new WaitForSeconds(0.5f));
				Block_40:
				IL_5B0:
				Block_43:
				goto IL_C9F;
				IL_600:
				return this.Yield(18, new WaitForSeconds(1f));
				Block_45:
				goto IL_C9F;
				IL_680:
				return this.YieldDefault(6);
				IL_6D2:
				return this.YieldDefault(16);
				Block_57:
				IL_7ED:
				IL_832:
				IL_857:
				goto IL_C9F;
				Block_62:
				return this.Yield(5, new WaitForSeconds(0.5f));
				IL_99A:
				return this.YieldDefault(12);
				Block_73:
				return this.Yield(7, new WaitForSeconds(0.5f));
				Block_77:
				return this.Yield(15, new WaitForSeconds(0.5f));
				IL_ADF:
				return this.Yield(2, new WaitForSeconds(0.5f));
				IL_B68:
				goto IL_C9F;
				IL_BD6:
				return this.Yield(3, new WaitForSeconds(0.5f));
				IL_BF1:
				return this.YieldDefault(4);
				IL_C4C:
				return this.Yield(13, new WaitForSeconds(0.5f));
				IL_C68:
				return this.YieldDefault(14);
				IL_C9F:
				return false;
			}

			// Token: 0x06007254 RID: 29268 RVA: 0x00F915EC File Offset: 0x00F8F7EC
			internal static bool WN6cNTp6N0Z6atcsnGA3()
			{
				return true;
			}

			// Token: 0x06007255 RID: 29269 RVA: 0x00F915F0 File Offset: 0x00F8F7F0
			internal static bool xbpyb9p6YEi7hLpdTK3s()
			{
				return false;
			}

			// Token: 0x0400780B RID: 30731
			internal GameObject $mPlayer$37555;

			// Token: 0x0400780C RID: 30732
			internal GameObject $mWalrus$37556;

			// Token: 0x0400780D RID: 30733
			internal GameGui $mGameGui$37557;

			// Token: 0x0400780E RID: 30734
			internal StoryGui $mStoryGui$37558;

			// Token: 0x0400780F RID: 30735
			internal float $mStoryTimer$37559;

			// Token: 0x04007810 RID: 30736
			internal M107_RequestFromAlcacia $self_$37560;
		}
	}

	// Token: 0x02001364 RID: 4964
	[CompilerGenerated]
	[Serializable]
	internal sealed class $TalkToPanther$37562 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06007256 RID: 29270 RVA: 0x00F915F4 File Offset: 0x00F8F7F4
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $TalkToPanther$37562(M107_RequestFromAlcacia self_)
		{
			if (290525 - 453888 != -163363)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (36189 - 434597 == -398408)
				{
					base..ctor();
					if (38364 - 121752 != -83387)
					{
						this.$self_$37569 = self_;
						if (262350 - 59483 == 202867)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x06007257 RID: 29271 RVA: 0x00F9168C File Offset: 0x00F8F88C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M107_RequestFromAlcacia.$TalkToPanther$37562.$(this.$self_$37569);
		}

		// Token: 0x06007258 RID: 29272 RVA: 0x00F9169C File Offset: 0x00F8F89C
		internal static bool fbtahEp6cHI5XwqMN0sk()
		{
			return true;
		}

		// Token: 0x06007259 RID: 29273 RVA: 0x00F916A0 File Offset: 0x00F8F8A0
		internal static bool drsuEJp6Ue1dgC26gvkg()
		{
			return false;
		}

		// Token: 0x04007811 RID: 30737
		internal M107_RequestFromAlcacia $self_$37569;

		// Token: 0x02001365 RID: 4965
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600725A RID: 29274 RVA: 0x00F916A4 File Offset: 0x00F8F8A4
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M107_RequestFromAlcacia self_)
			{
				if (169157 - 492200 != -323042)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (164081 - 513271 != -349189)
					{
						base..ctor();
						if (103493 - 572195 != -468701)
						{
							this.$self_$37568 = self_;
							if (175427 - 169958 == 5469)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x0600725B RID: 29275 RVA: 0x00F9173C File Offset: 0x00F8F93C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (193070 - 246557 != -53486)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_528;
					case 2:
						if (Game.mGameState != eGameState.Hold)
						{
							if (111328 - 562197 != -450868)
							{
								goto Block_27;
							}
							continue;
						}
						else
						{
							this.$mStoryTimer$37567 = 0f;
							if (99089 - 24902 != 74187)
							{
								continue;
							}
							this.$mStoryGui$37566.newStoryMessage("none", "Panther", Language.getMessage("M107_RequestFromAlcacia", 141 + UnityEngine.Random.Range(0, 2)), eTalkType.friend);
							if (163231 - 403899 == -240667)
							{
								continue;
							}
							this.$mStoryTimer$37567 = Time.time + 5f;
							if (145023 - 381436 != -236412)
							{
								goto Block_32;
							}
							continue;
						}
						break;
					case 3:
						goto IL_95;
					case 4:
						goto IL_95;
					case 5:
						if (Game.mGameState != eGameState.Hold)
						{
							if (28605 - 460180 != -431575)
							{
								continue;
							}
							goto IL_4FD;
						}
						else
						{
							this.$mGameGui$37565.enabled = true;
							if (294559 - 384639 != -90080)
							{
								continue;
							}
							goto IL_1E4;
						}
						break;
					case 6:
						if (Game.mGameState != eGameState.Hold)
						{
							if (179797 - 433979 != -254182)
							{
								continue;
							}
							goto IL_490;
						}
						else
						{
							Game.mGameState = eGameState.Normal;
							if (121895 - 362932 != -241037)
							{
								continue;
							}
							this.YieldDefault(1);
							if (222544 - 577464 != -354919)
							{
								goto Block_11;
							}
							continue;
						}
						break;
					default:
						if (69271 - 358827 != -289556)
						{
							continue;
						}
						break;
					}
					Debug.Log("On Talk To Panther");
					if (112739 - 449087 == -336347)
					{
						continue;
					}
					if (Game.mGameState != eGameState.Normal)
					{
						if (33797 - 520111 != -486314)
						{
							continue;
						}
						goto IL_25E;
					}
					else
					{
						Game.mGameState = eGameState.Hold;
						if (292822 - 218794 != 74028)
						{
							continue;
						}
						this.$mPlayer$37563 = Game.mPlayer;
						if (175732 - 257474 != -81742)
						{
							continue;
						}
						this.$mPanther$37564 = GameObject.Find("Panther");
						if (7618 - 135625 != -128007)
						{
							continue;
						}
						if (this.$mPanther$37564)
						{
							if (287745 - 571106 != -283361)
							{
								continue;
							}
							if (this.$mPlayer$37563)
							{
								if (67862 - 361435 == -293572)
								{
									continue;
								}
								this.$mPlayer$37563.SendMessage("turnToPos", this.$mPanther$37564.transform.position);
								if (61137 - 169532 == -108394)
								{
									continue;
								}
							}
						}
						this.$mGameGui$37565 = (GameGui)this.$self_$37568.GetComponent(typeof(GameGui));
						if (82610 - 104005 == -21394)
						{
							continue;
						}
						if (this.$mGameGui$37565)
						{
							if (218960 - 36780 != 182180)
							{
								continue;
							}
							this.$mGameGui$37565.close();
							if (282232 - 332863 == -50630)
							{
								continue;
							}
						}
						this.$mStoryGui$37566 = (StoryGui)this.$self_$37568.GetComponent(typeof(StoryGui));
						if (24613 - 189353 == -164739)
						{
							continue;
						}
						this.$mStoryGui$37566.startStoryMessage("none", "Panther", eTalkType.friend);
						if (27928 - 10011 != 17917)
						{
							continue;
						}
						goto IL_388;
					}
					IL_95:
					if (this.$mStoryTimer$37567 > Time.time)
					{
						if (176543 - 550080 != -373537)
						{
							continue;
						}
						if (!Input.GetKeyDown(KeyCode.Mouse0))
						{
							break;
						}
						if (298844 - 219020 != 79824)
						{
							continue;
						}
					}
					if (Game.mGameState != eGameState.Hold)
					{
						if (86069 - 400817 != -314747)
						{
							goto Block_21;
						}
					}
					else
					{
						this.$mStoryGui$37566.close();
						if (289916 - 105201 != 184716)
						{
							goto Block_33;
						}
					}
				}
				return this.YieldDefault(4);
				Block_11:
				goto IL_528;
				IL_1E4:
				return this.Yield(6, new WaitForSeconds(1f));
				IL_25E:
				Block_21:
				goto IL_528;
				IL_388:
				return this.Yield(2, new WaitForSeconds(0.5f));
				Block_27:
				goto IL_528;
				Block_32:
				return this.Yield(3, new WaitForSeconds(1f));
				Block_33:
				return this.Yield(5, new WaitForSeconds(0.5f));
				IL_490:
				IL_4FD:
				IL_528:
				return false;
			}

			// Token: 0x0600725C RID: 29276 RVA: 0x00F91C84 File Offset: 0x00F8FE84
			internal static bool lHkFG2p6Tx657cLWFcaZ()
			{
				return true;
			}

			// Token: 0x0600725D RID: 29277 RVA: 0x00F91C88 File Offset: 0x00F8FE88
			internal static bool gYkMAkp63SPTyloDJf8J()
			{
				return false;
			}

			// Token: 0x04007812 RID: 30738
			internal GameObject $mPlayer$37563;

			// Token: 0x04007813 RID: 30739
			internal GameObject $mPanther$37564;

			// Token: 0x04007814 RID: 30740
			internal GameGui $mGameGui$37565;

			// Token: 0x04007815 RID: 30741
			internal StoryGui $mStoryGui$37566;

			// Token: 0x04007816 RID: 30742
			internal float $mStoryTimer$37567;

			// Token: 0x04007817 RID: 30743
			internal M107_RequestFromAlcacia $self_$37568;
		}
	}

	// Token: 0x02001366 RID: 4966
	[CompilerGenerated]
	[Serializable]
	internal sealed class $onDeadPlayer$37570 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600725E RID: 29278 RVA: 0x00F91C8C File Offset: 0x00F8FE8C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $onDeadPlayer$37570(M107_RequestFromAlcacia self_)
		{
			if (37815 - 8529 != 29287)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (132462 - 281029 != -148566)
				{
					base..ctor();
					if (165215 - 436699 != -271483)
					{
						this.$self_$37575 = self_;
						if (152890 - 491115 == -338225)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x0600725F RID: 29279 RVA: 0x00F91D24 File Offset: 0x00F8FF24
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M107_RequestFromAlcacia.$onDeadPlayer$37570.$(this.$self_$37575);
		}

		// Token: 0x06007260 RID: 29280 RVA: 0x00F91D34 File Offset: 0x00F8FF34
		internal static bool PcYRoUp6X7lK1NP3jmHl()
		{
			return true;
		}

		// Token: 0x06007261 RID: 29281 RVA: 0x00F91D38 File Offset: 0x00F8FF38
		internal static bool tgKpIBp6QDhZyWYfv92F()
		{
			return false;
		}

		// Token: 0x04007818 RID: 30744
		internal M107_RequestFromAlcacia $self_$37575;

		// Token: 0x02001367 RID: 4967
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06007262 RID: 29282 RVA: 0x00F91D3C File Offset: 0x00F8FF3C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M107_RequestFromAlcacia self_)
			{
				if (195197 - 247956 != -52759)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (241504 - 533139 == -291635)
					{
						base..ctor();
						if (147369 - 57755 == 89614)
						{
							this.$self_$37574 = self_;
							if (284340 - 312591 != -28250)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x06007263 RID: 29283 RVA: 0x00F91DD4 File Offset: 0x00F8FFD4
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (289847 - 156438 != 133410)
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
							if (31848 - 244967 != -213119)
							{
								continue;
							}
							if (Game.mGameState != eGameState.Hold)
							{
								goto IL_249;
							}
							if (254234 - 409285 == -155050)
							{
								continue;
							}
						}
						Game.mGameState = eGameState.Hold;
						if (58876 - 283886 != -225010)
						{
							continue;
						}
						this.$mStoryGui$37571 = (StoryGui)this.$self_$37574.GetComponent(typeof(StoryGui));
						if (817 - 516542 != -515725)
						{
							continue;
						}
						if (this.$mStoryGui$37571)
						{
							if (4042 - 352441 == -348398)
							{
								continue;
							}
							this.$mStoryGui$37571.close();
							if (138474 - 553829 == -415354)
							{
								continue;
							}
						}
						this.$mChangeGui$37572 = (ChangeGui)this.$self_$37574.GetComponent(typeof(ChangeGui));
						if (169132 - 424408 != -255276)
						{
							continue;
						}
						if (this.$mChangeGui$37572)
						{
							if (6930 - 18867 == -11936)
							{
								continue;
							}
							this.$mChangeGui$37572.close();
							if (51186 - 297952 == -246765)
							{
								continue;
							}
						}
						this.$mGameGui$37573 = (GameGui)this.$self_$37574.GetComponent(typeof(GameGui));
						if (175481 - 490084 == -314602)
						{
							continue;
						}
						if (this.$mGameGui$37573)
						{
							if (97384 - 117431 != -20047)
							{
								continue;
							}
							if (!this.$mGameGui$37573.enabled)
							{
								if (19367 - 342887 == -323519)
								{
									continue;
								}
								this.$mGameGui$37573.enabled = true;
								if (114244 - 165288 == -51043)
								{
									continue;
								}
							}
							this.$mGameGui$37573.openDeadMenu();
							if (236385 - 184441 != 51944)
							{
								continue;
							}
						}
						IL_249:
						this.YieldDefault(1);
						if (296129 - 331171 != -35041)
						{
							goto Block_19;
						}
						continue;
					default:
						if (102900 - 40824 == 62077)
						{
							continue;
						}
						break;
					}
					Debug.Log("On Dead Player");
					if (285717 - 493002 == -207285)
					{
						goto IL_290;
					}
				}
				Block_19:
				goto IL_2F9;
				IL_290:
				return this.Yield(2, new WaitForSeconds((float)2));
				IL_2F9:
				return false;
			}

			// Token: 0x06007264 RID: 29284 RVA: 0x00F920EC File Offset: 0x00F902EC
			internal static bool eBP6IWp6ko94pLDpABla()
			{
				return true;
			}

			// Token: 0x06007265 RID: 29285 RVA: 0x00F920F0 File Offset: 0x00F902F0
			internal static bool XYSTg6p6GJjBEelCSJtg()
			{
				return false;
			}

			// Token: 0x04007819 RID: 30745
			internal StoryGui $mStoryGui$37571;

			// Token: 0x0400781A RID: 30746
			internal ChangeGui $mChangeGui$37572;

			// Token: 0x0400781B RID: 30747
			internal GameGui $mGameGui$37573;

			// Token: 0x0400781C RID: 30748
			internal M107_RequestFromAlcacia $self_$37574;
		}
	}

	// Token: 0x02001368 RID: 4968
	[CompilerGenerated]
	[Serializable]
	internal sealed class $ReturnToTown$37576 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06007266 RID: 29286 RVA: 0x00F920F4 File Offset: 0x00F902F4
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $ReturnToTown$37576(M107_RequestFromAlcacia self_)
		{
			if (159200 - 321789 != -162588)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (45080 - 257962 != -212881)
				{
					base..ctor();
					if (211596 - 106199 == 105397)
					{
						this.$self_$37580 = self_;
						if (1610 - 474627 == -473017)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x06007267 RID: 29287 RVA: 0x00F9218C File Offset: 0x00F9038C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M107_RequestFromAlcacia.$ReturnToTown$37576.$(this.$self_$37580);
		}

		// Token: 0x06007268 RID: 29288 RVA: 0x00F9219C File Offset: 0x00F9039C
		internal static bool jCdbotp6HYwkXvgGZvuZ()
		{
			return true;
		}

		// Token: 0x06007269 RID: 29289 RVA: 0x00F921A0 File Offset: 0x00F903A0
		internal static bool CMxmQ3p6WGbF8tt4Md4o()
		{
			return false;
		}

		// Token: 0x0400781D RID: 30749
		internal M107_RequestFromAlcacia $self_$37580;

		// Token: 0x02001369 RID: 4969
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600726A RID: 29290 RVA: 0x00F921A4 File Offset: 0x00F903A4
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M107_RequestFromAlcacia self_)
			{
				if (295659 - 31487 != 264173)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (82094 - 536165 != -454070)
					{
						base..ctor();
						if (256770 - 567801 == -311031)
						{
							this.$self_$37579 = self_;
							if (108327 - 235754 != -127426)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x0600726B RID: 29291 RVA: 0x00F9223C File Offset: 0x00F9043C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (145861 - 174112 != -28250)
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
						this.$self_$37579.LeaveGame();
						if (278793 - 581144 != -302351)
						{
							continue;
						}
						this.YieldDefault(1);
						if (34012 - 475727 != -441715)
						{
							continue;
						}
						goto IL_3AD;
					default:
						if (260142 - 74726 != 185416)
						{
							continue;
						}
						break;
					}
					Game.mGameState = eGameState.Ended;
					if (47076 - 45885 != 1192)
					{
						Game.mStateTime = Time.time;
						if (213258 - 591453 != -378194)
						{
							this.$$switch$6342$37577 = PlayerData.SaveGuild;
							if (190805 - 484485 != -293679)
							{
								if (this.$$switch$6342$37577 == 1)
								{
									if (76446 - 271798 != -195352)
									{
										continue;
									}
									Game.mNextGameCode = 32;
									if (156604 - 87093 == 69512)
									{
										continue;
									}
								}
								else if (this.$$switch$6342$37577 == 2)
								{
									if (159620 - 65104 != 94516)
									{
										continue;
									}
									Game.mNextGameCode = 33;
									if (272328 - 482743 == -210414)
									{
										continue;
									}
								}
								else if (this.$$switch$6342$37577 == 3)
								{
									if (220729 - 180599 != 40130)
									{
										continue;
									}
									Game.mNextGameCode = 34;
									if (68102 - 223453 == -155350)
									{
										continue;
									}
								}
								else if (this.$$switch$6342$37577 == 4)
								{
									if (61020 - 541606 == -480585)
									{
										continue;
									}
									Game.mNextGameCode = 35;
									if (94614 - 572319 == -477704)
									{
										continue;
									}
								}
								else if (this.$$switch$6342$37577 == 5)
								{
									if (127408 - 515090 != -387682)
									{
										continue;
									}
									Game.mNextGameCode = 36;
									if (78421 - 544281 != -465860)
									{
										continue;
									}
								}
								else if (PlayerData.GID == 0)
								{
									if (40827 - 136876 == -96048)
									{
										continue;
									}
									Game.mNextGameCode = 30;
									if (132939 - 538711 == -405771)
									{
										continue;
									}
								}
								else
								{
									Game.mNextGameCode = 31;
									if (26499 - 559984 != -533485)
									{
										continue;
									}
								}
								this.$mGameGui$37578 = (GameGui)this.$self_$37579.GetComponent(typeof(GameGui));
								if (161845 - 288129 == -126284)
								{
									if (this.$mGameGui$37578)
									{
										if (273185 - 447450 != -174265)
										{
											continue;
										}
										this.$mGameGui$37578.close();
										if (233520 - 522205 != -288685)
										{
											continue;
										}
									}
									this.$self_$37579.SendMessage("fadeOut");
									if (176447 - 286568 != -110120)
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

			// Token: 0x0600726C RID: 29292 RVA: 0x00F92608 File Offset: 0x00F90808
			internal static bool rXatfxp6AgBrpLrX5HVB()
			{
				return true;
			}

			// Token: 0x0600726D RID: 29293 RVA: 0x00F9260C File Offset: 0x00F9080C
			internal static bool g4kCS7p6lT4nW3Abf09X()
			{
				return false;
			}

			// Token: 0x0400781E RID: 30750
			internal int $$switch$6342$37577;

			// Token: 0x0400781F RID: 30751
			internal GameGui $mGameGui$37578;

			// Token: 0x04007820 RID: 30752
			internal M107_RequestFromAlcacia $self_$37579;
		}
	}

	// Token: 0x0200136A RID: 4970
	[CompilerGenerated]
	[Serializable]
	internal sealed class $ReturnToGuild$37581 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600726E RID: 29294 RVA: 0x00F92610 File Offset: 0x00F90810
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $ReturnToGuild$37581(M107_RequestFromAlcacia self_)
		{
			if (205289 - 150470 != 54820)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (116845 - 441283 == -324438)
				{
					base..ctor();
					if (160162 - 154094 != 6069)
					{
						this.$self_$37584 = self_;
						if (43236 - 482028 == -438792)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x0600726F RID: 29295 RVA: 0x00F926A8 File Offset: 0x00F908A8
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M107_RequestFromAlcacia.$ReturnToGuild$37581.$(this.$self_$37584);
		}

		// Token: 0x06007270 RID: 29296 RVA: 0x00F926B8 File Offset: 0x00F908B8
		internal static bool QPyuHnp6yew7NWaj7PV0()
		{
			return true;
		}

		// Token: 0x06007271 RID: 29297 RVA: 0x00F926BC File Offset: 0x00F908BC
		internal static bool g6bxgNp6So1lbsxqPmKW()
		{
			return false;
		}

		// Token: 0x04007821 RID: 30753
		internal M107_RequestFromAlcacia $self_$37584;

		// Token: 0x0200136B RID: 4971
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06007272 RID: 29298 RVA: 0x00F926C0 File Offset: 0x00F908C0
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M107_RequestFromAlcacia self_)
			{
				if (121579 - 136446 != -14867)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (18784 - 323709 != -304924)
					{
						base..ctor();
						if (298029 - 492465 != -194435)
						{
							this.$self_$37583 = self_;
							if (45811 - 199556 == -153745)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x06007273 RID: 29299 RVA: 0x00F92758 File Offset: 0x00F90958
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (167745 - 493197 != -325451)
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
						this.$self_$37583.LeaveGame();
						if (68171 - 552628 != -484457)
						{
							continue;
						}
						this.YieldDefault(1);
						if (202067 - 577907 != -375840)
						{
							continue;
						}
						goto IL_1BD;
					default:
						if (114128 - 474981 == -360852)
						{
							continue;
						}
						break;
					}
					Game.mGameState = eGameState.Ended;
					if (63483 - 175726 != -112242)
					{
						Game.mStateTime = Time.time;
						if (121697 - 113016 == 8681)
						{
							Game.mNextGameCode = 31;
							if (290230 - 209542 == 80688)
							{
								this.$mGameGui$37582 = (GameGui)this.$self_$37583.GetComponent(typeof(GameGui));
								if (80838 - 592189 == -511351)
								{
									if (this.$mGameGui$37582)
									{
										if (242358 - 190026 != 52332)
										{
											continue;
										}
										this.$mGameGui$37582.close();
										if (100978 - 59813 != 41165)
										{
											continue;
										}
									}
									this.$self_$37583.SendMessage("fadeOut");
									if (207038 - 447250 == -240212)
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

			// Token: 0x06007274 RID: 29300 RVA: 0x00F92934 File Offset: 0x00F90B34
			internal static bool PqHHacp6oCPHEFkZb9Rx()
			{
				return true;
			}

			// Token: 0x06007275 RID: 29301 RVA: 0x00F92938 File Offset: 0x00F90B38
			internal static bool n5W6jCp6EcF4EaHdWxkD()
			{
				return false;
			}

			// Token: 0x04007822 RID: 30754
			internal GameGui $mGameGui$37582;

			// Token: 0x04007823 RID: 30755
			internal M107_RequestFromAlcacia $self_$37583;
		}
	}

	// Token: 0x0200136C RID: 4972
	[CompilerGenerated]
	[Serializable]
	internal sealed class $ReturnToCamp$37585 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06007276 RID: 29302 RVA: 0x00F9293C File Offset: 0x00F90B3C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $ReturnToCamp$37585(M107_RequestFromAlcacia self_)
		{
			if (36273 - 563660 != -527387)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (260598 - 226954 == 33644)
				{
					base..ctor();
					if (185570 - 163528 != 22043)
					{
						this.$self_$37589 = self_;
						if (118898 - 95458 == 23440)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x06007277 RID: 29303 RVA: 0x00F929D4 File Offset: 0x00F90BD4
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M107_RequestFromAlcacia.$ReturnToCamp$37585.$(this.$self_$37589);
		}

		// Token: 0x06007278 RID: 29304 RVA: 0x00F929E4 File Offset: 0x00F90BE4
		internal static bool NXMeI2p62XJoL4R8TL1i()
		{
			return true;
		}

		// Token: 0x06007279 RID: 29305 RVA: 0x00F929E8 File Offset: 0x00F90BE8
		internal static bool cHSU4lp68s3rHcLMv9J4()
		{
			return false;
		}

		// Token: 0x04007824 RID: 30756
		internal M107_RequestFromAlcacia $self_$37589;

		// Token: 0x0200136D RID: 4973
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600727A RID: 29306 RVA: 0x00F929EC File Offset: 0x00F90BEC
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M107_RequestFromAlcacia self_)
			{
				if (182822 - 204997 != -22175)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (277739 - 228083 == 49656)
					{
						base..ctor();
						if (53676 - 471104 == -417428)
						{
							this.$self_$37588 = self_;
							if (153382 - 459246 != -305863)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x0600727B RID: 29307 RVA: 0x00F92A84 File Offset: 0x00F90C84
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (75402 - 599000 != -523597)
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
						this.$self_$37588.LeaveGame();
						if (266721 - 394409 != -127688)
						{
							continue;
						}
						this.YieldDefault(1);
						if (156419 - 424066 != -267646)
						{
							goto Block_28;
						}
						continue;
					default:
						if (276578 - 257437 == 19142)
						{
							continue;
						}
						break;
					}
					Game.mGameState = eGameState.Ended;
					if (211689 - 156331 != 55359)
					{
						Game.mStateTime = Time.time;
						if (127759 - 587485 == -459726)
						{
							this.$$switch$6344$37586 = PlayerData.SaveGuild;
							if (45202 - 240145 != -194942)
							{
								if (this.$$switch$6344$37586 == 1)
								{
									if (170840 - 80321 != 90519)
									{
										continue;
									}
									Game.mNextGameCode = 32;
									if (136628 - 378664 != -242036)
									{
										continue;
									}
								}
								else if (this.$$switch$6344$37586 == 2)
								{
									if (124669 - 394951 != -270282)
									{
										continue;
									}
									Game.mNextGameCode = 33;
									if (2031 - 285222 != -283191)
									{
										continue;
									}
								}
								else if (this.$$switch$6344$37586 == 3)
								{
									if (152390 - 219398 != -67008)
									{
										continue;
									}
									Game.mNextGameCode = 34;
									if (185072 - 187009 != -1937)
									{
										continue;
									}
								}
								else if (this.$$switch$6344$37586 == 4)
								{
									if (85678 - 435698 != -350020)
									{
										continue;
									}
									Game.mNextGameCode = 35;
									if (52538 - 307186 != -254648)
									{
										continue;
									}
								}
								else if (this.$$switch$6344$37586 == 5)
								{
									if (27541 - 342681 == -315139)
									{
										continue;
									}
									Game.mNextGameCode = 36;
									if (11579 - 65202 != -53623)
									{
										continue;
									}
								}
								else
								{
									Game.mNextGameCode = 30;
									if (275910 - 560344 == -284433)
									{
										continue;
									}
								}
								this.$mGameGui$37587 = (GameGui)this.$self_$37588.GetComponent(typeof(GameGui));
								if (5647 - 235370 != -229722)
								{
									if (this.$mGameGui$37587)
									{
										if (110120 - 500345 == -390224)
										{
											continue;
										}
										this.$mGameGui$37587.close();
										if (63652 - 400438 != -336786)
										{
											continue;
										}
									}
									this.$self_$37588.SendMessage("fadeOut");
									if (42101 - 369435 == -327334)
									{
										break;
									}
								}
							}
						}
					}
				}
				return this.Yield(2, new WaitForSeconds((float)1));
				Block_28:
				IL_363:
				return false;
			}

			// Token: 0x0600727C RID: 29308 RVA: 0x00F92E08 File Offset: 0x00F91008
			internal static bool tctctip6ZuiyXbdxkui1()
			{
				return true;
			}

			// Token: 0x0600727D RID: 29309 RVA: 0x00F92E0C File Offset: 0x00F9100C
			internal static bool qtBlrip6C0B3cyAiLykW()
			{
				return false;
			}

			// Token: 0x04007825 RID: 30757
			internal int $$switch$6344$37586;

			// Token: 0x04007826 RID: 30758
			internal GameGui $mGameGui$37587;

			// Token: 0x04007827 RID: 30759
			internal M107_RequestFromAlcacia $self_$37588;
		}
	}
}
