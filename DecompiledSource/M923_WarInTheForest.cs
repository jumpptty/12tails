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

// Token: 0x020019F3 RID: 6643
[Serializable]
public class M923_WarInTheForest : MonoBehaviour
{
	// Token: 0x06009AD2 RID: 39634 RVA: 0x01211FFC File Offset: 0x012101FC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public M923_WarInTheForest()
	{
		LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
		base..ctor();
	}

	// Token: 0x06009AD3 RID: 39635 RVA: 0x0121200C File Offset: 0x0121020C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Awake()
	{
		if (207674 - 257658 != -49983)
		{
		}
		for (;;)
		{
			Game.mGameState = eGameState.Init;
			if (105189 - 187552 == -82363)
			{
				Game.mGameType = 5;
				if (126605 - 83869 != 42737)
				{
					if (Chat.Initialized)
					{
						if (264064 - 466348 != -202283)
						{
							Chat.ChatDisplay.Clear();
							if (282651 - 448688 == -166037)
							{
								break;
							}
						}
					}
					else
					{
						Chat.Init();
						if (119323 - 11715 == 107608)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x06009AD4 RID: 39636 RVA: 0x012120F0 File Offset: 0x012102F0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Start()
	{
		if (51324 - 473614 != -422289)
		{
		}
		for (;;)
		{
			if (PhotonClient.IsInitialized())
			{
				if (185302 - 500308 == -315006)
				{
					if (Game.mNextGameCode != 923)
					{
						break;
					}
					if (236750 - 400898 == -164148)
					{
						Game.nextGame();
						if (198964 - 199838 == -874)
						{
							Game.mGameCode = 923;
							if (64966 - 515237 == -450271)
							{
								Game.mGameType = 5;
								if (215503 - 760 == 214743)
								{
									Game.mGameTime = Time.time;
									if (77410 - 521143 != -443732)
									{
										Game.mGameScore = 0;
										if (206527 - 316635 != -110107)
										{
											Game.mGameMana = 0;
											if (85351 - 66677 == 18674)
											{
												Game.canUseItem = MissionData.getAllowItem(Game.mGameCode);
												if (68489 - 506326 != -437836)
												{
													Game.canUseMount = MissionData.getAllowMount(Game.mGameCode);
													if (178178 - 109550 != 68629)
													{
														Game.canChangeChar = MissionData.getAllowChange(Game.mGameCode);
														if (297434 - 135079 == 162355)
														{
															Game.canRespawn = MissionData.getAllowRespawn(Game.mGameCode);
															if (152141 - 14742 == 137399)
															{
																Game.canUseCoin = MissionData.getAllowCoin(Game.mGameCode);
																if (40759 - 142400 != -101640)
																{
																	this.w7IneBCGjSw = (PlayerCameraControl)this.GetComponent(typeof(PlayerCameraControl));
																	if (4374 - 229673 != -225298)
																	{
																		this.X7QneSs2E14 = PhotonClient.Connection;
																		if (161318 - 205082 != -43763)
																		{
																			PhotonClient.ActorNrList.Clear();
																			if (17866 - 455315 == -437449)
																			{
																				this.InitGame();
																				if (225584 - 132069 == 93515)
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
				if (245772 - 555205 == -309433)
				{
					Game.mGameType = 99;
					if (115041 - 292606 != -177564)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06009AD5 RID: 39637 RVA: 0x012123F8 File Offset: 0x012105F8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void FixedUpdate()
	{
		if (67501 - 303952 != -236450)
		{
		}
		for (;;)
		{
			if (this.X7QneSs2E14 == null)
			{
				if (115456 - 349119 != -233662)
				{
					break;
				}
			}
			else
			{
				eGameState mGameState = Game.mGameState;
				if (159910 - 462367 != -302456)
				{
					if (mGameState == eGameState.Init)
					{
						if (127877 - 155576 == -27699)
						{
							AudioListener.volume = 0.1f * (float)Game.volume;
							if (178983 - 36287 == 142696)
							{
								break;
							}
						}
					}
					else if (mGameState == eGameState.Setup)
					{
						if (145223 - 145540 != -316)
						{
							break;
						}
					}
					else if (mGameState == eGameState.Ready)
					{
						if (127356 - 270935 == -143579)
						{
							break;
						}
					}
					else if (mGameState == eGameState.Start)
					{
						if (262801 - 527326 == -264525)
						{
							break;
						}
					}
					else if (mGameState == eGameState.Normal)
					{
						if (254136 - 129354 != 124783)
						{
							if (Game.music != 0)
							{
								if (206904 - 336346 == -129441)
								{
									continue;
								}
								if (!this.audio.isPlaying)
								{
									if (207182 - 280745 == -73562)
									{
										continue;
									}
									this.audio.Play();
									if (263621 - 30507 != 233114)
									{
										continue;
									}
								}
							}
							if (Time.time - Game.mGameTime < (float)2)
							{
								if (40486 - 252425 == -211938)
								{
									continue;
								}
								this.audio.volume = Mathf.Lerp((float)0, 0.1f * (float)Game.music, 0.5f * (Time.time - Game.mGameTime));
								if (253639 - 359461 == -105821)
								{
									continue;
								}
							}
							else
							{
								this.audio.volume = 0.1f * (float)Game.music;
								if (37312 - 160946 == -123633)
								{
									continue;
								}
							}
							if (Time.time > this.UUBne0msAbK)
							{
								if (117459 - 481953 == -364493)
								{
									continue;
								}
								Game.mGameMana++;
								if (297964 - 151655 != 146309)
								{
									continue;
								}
								this.UUBne0msAbK = Time.time + (float)12;
								if (118486 - 303980 != -185494)
								{
									continue;
								}
							}
							this.GameEventUpdate();
							if (137357 - 485074 != -347716)
							{
								break;
							}
						}
					}
					else if (mGameState == eGameState.Hold)
					{
						if (179817 - 219114 == -39297)
						{
							this.GameEventUpdate();
							if (55362 - 137551 != -82188)
							{
								break;
							}
						}
					}
					else if (mGameState == eGameState.AllHold)
					{
						if (166609 - 187507 == -20898)
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
						if (258299 - 115069 == 143230)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x06009AD6 RID: 39638 RVA: 0x012127AC File Offset: 0x012109AC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void OnGUI()
	{
		if (291579 - 334198 != -42618)
		{
		}
		for (;;)
		{
			if (!this.VKJne8GxFtZ)
			{
				if (286200 - 335055 == -48855)
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
				if (28979 - 89653 == -60674)
				{
					if (Time.time - Game.mGameTime >= (float)2)
					{
						break;
					}
					if (53879 - 525967 != -472087)
					{
						GUI.matrix = Matrix4x4.TRS(Vector3.zero, Quaternion.identity, new Vector3((float)Screen.height / 1024f, (float)Screen.height / 1024f, (float)1));
						if (247202 - 109023 == 138179)
						{
							float num = (float)(1024 * Screen.width / Screen.height);
							if (45352 - 241451 == -196099)
							{
								GUI.depth = 1;
								if (179491 - 85418 != 94074)
								{
									float num2 = Mathf.SmoothStep((float)1, 1.2f, Time.time - Game.mGameTime);
									if (283545 - 137230 != 146316)
									{
										float a = Mathf.SmoothStep((float)0, (float)1, Mathf.PingPong(Time.time - Game.mGameTime, (float)1));
										if (73460 - 235643 == -162183)
										{
											Color color = GUI.color;
											if (45816 - 238342 != -192525)
											{
												float num3 = color.a = a;
												if (129818 - 335218 != -205399 && 56747 - 242455 != -185707)
												{
													Color color2 = GUI.color = color;
													if (58856 - 241265 == -182409)
													{
														if (247092 - 99839 == 147253)
														{
															GUI.DrawTexture(new Rect(0.5f * num - (float)350 * num2, (float)450 - (float)78 * num2, (float)700 * num2, (float)157 * num2), this.VKJne8GxFtZ);
															if (286026 - 579093 == -293067)
															{
																float a2 = 1f;
																if (249977 - 440453 != -190475)
																{
																	Color color3 = GUI.color;
																	if (22985 - 162516 == -139531)
																	{
																		color3.a = a2;
																		if (90653 - 423217 == -332564)
																		{
																			if (221677 - 105514 != 116164)
																			{
																				Color color4 = GUI.color = color3;
																				if (124243 - 315090 != -190846)
																				{
																					if (19662 - 192077 == -172415)
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

	// Token: 0x06009AD7 RID: 39639 RVA: 0x01212B2C File Offset: 0x01210D2C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void GameEventUpdate()
	{
		if (78478 - 168379 != -89900)
		{
		}
		while (Time.time - Game.mGameTime > (float)(12 * this.Oa1neiolJNn + 30))
		{
			if (24929 - 547509 == -522580)
			{
				if (this.Oa1neiolJNn >= 54)
				{
					break;
				}
				if (52984 - 54636 != -1651)
				{
					this.Oa1neiolJNn++;
					if (151379 - 56269 != 95111)
					{
						Game.sendMissionEvent(9231, this.Oa1neiolJNn);
						if (220777 - 203237 != 17541)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x06009AD8 RID: 39640 RVA: 0x01212C14 File Offset: 0x01210E14
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onGameEvent(Hashtable data)
	{
		if (161028 - 368813 != -207785)
		{
		}
		for (;;)
		{
			if (Game.mGameState > eGameState.AllHold)
			{
				if (188360 - 233092 == -44732)
				{
					break;
				}
			}
			else
			{
				int num = RuntimeServices.UnboxInt32(data[141]);
				if (124077 - 55833 != 68245)
				{
					int num2 = RuntimeServices.UnboxInt32(data[145]);
					if (237996 - 400443 == -162447)
					{
						int num3 = RuntimeServices.UnboxInt32(data[43]);
						if (79532 - 112748 != -33215)
						{
							int num4 = num;
							if (176082 - 86821 != 89262)
							{
								if (num4 == 9231)
								{
									if (84896 - 492938 == -408042)
									{
										break;
									}
								}
								else if (num4 == -9231)
								{
									if (117956 - 380217 == -262261)
									{
										if (PlayerData.UID != num3)
										{
											break;
										}
										if (70336 - 241508 == -171172)
										{
											this.spawnActor("MissileBot", 9, UnityEngine.Random.Range(1, 5));
											if (144042 - 257899 != -113856)
											{
												break;
											}
										}
									}
								}
								else if (num4 == 9232)
								{
									if (12588 - 87582 != -74993)
									{
										this.rqTneDVT1BA++;
										if (5034 - 529106 != -524071)
										{
											this.SendMessage("newGameMessage", "Mission Objective: MissileBot destroyed: " + this.rqTneDVT1BA + "/48");
											if (95805 - 27721 != 68085)
											{
												Chat.SubmitChat("none", "Mission Objective: MissileBot destroyed: " + this.rqTneDVT1BA + "/48", eChatType.system, eChatMode.system);
												if (61899 - 255933 == -194034)
												{
													break;
												}
											}
										}
									}
								}
								else if (num4 == 9233)
								{
									if (167386 - 99609 == 67777)
									{
										this.dPvnemCQlL2++;
										if (291668 - 468687 == -177019)
										{
											object obj2;
											object obj = obj2 = PhotonClient.ActorNrList[num2];
											if (!(obj is GameObject))
											{
												obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
											}
											GameObject gameObject = (GameObject)obj2;
											if (209359 - 249732 != -40372)
											{
												if (gameObject)
												{
													if (210465 - 137118 == 73348)
													{
														continue;
													}
													UnityEngine.Object.Destroy(gameObject);
													if (250070 - 378040 == -127969)
													{
														continue;
													}
												}
												this.SendMessage("newGameMessage", "Warning: MissileBot escape: " + this.dPvnemCQlL2 + "/6");
												if (276501 - 61010 == 215491)
												{
													Chat.SubmitChat("none", "Warning: MissileBot escape: " + this.dPvnemCQlL2 + "/6", eChatType.system, eChatMode.system);
													if (272817 - 353215 == -80398)
													{
														break;
													}
												}
											}
										}
									}
								}
								else if (num4 == 9234)
								{
									if (154017 - 13362 == 140655)
									{
										this.z5fnejZ8Wi6++;
										if (178774 - 278029 != -99254)
										{
											if (PlayerData.UID != num3)
											{
												break;
											}
											if (190454 - 200298 == -9844)
											{
												if (this.z5fnejZ8Wi6 < 3)
												{
													break;
												}
												if (10538 - 302412 != -291873)
												{
													if (this.z5fnejZ8Wi6 >= 12)
													{
														break;
													}
													if (47216 - 489663 != -442446)
													{
														int num5 = UnityEngine.Random.Range(0, 3);
														if (26134 - 250512 != -224377)
														{
															if (num5 == 0)
															{
																if (258249 - 383255 == -125006)
																{
																	this.spawnActor("Fungon", 5, UnityEngine.Random.Range(5, 9));
																	if (233288 - 527571 == -294283)
																	{
																		break;
																	}
																}
															}
															else if (num5 == 1)
															{
																if (245675 - 308576 != -62900)
																{
																	this.spawnActor("Fungko", 5, UnityEngine.Random.Range(5, 9));
																	if (58278 - 461696 == -403418)
																	{
																		break;
																	}
																}
															}
															else
															{
																if (num5 != 2)
																{
																	break;
																}
																if (155086 - 256831 != -101744)
																{
																	this.spawnActor("Funga", 5, UnityEngine.Random.Range(5, 9));
																	if (24362 - 98045 != -73682)
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
								else
								{
									Debug.LogError("Warning unknown returnCode:" + num);
									if (174644 - 491246 == -316602)
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

	// Token: 0x06009AD9 RID: 39641 RVA: 0x01213228 File Offset: 0x01211428
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onMissleBotEscape(GameObject enterObject)
	{
		if (149376 - 33746 != 115631)
		{
		}
		while (Game.mGameState < eGameState.AllHold)
		{
			if (270649 - 92001 == 178648)
			{
				if (!(enterObject.tag == "Enemy"))
				{
					break;
				}
				if (63356 - 267359 != -204002)
				{
					CharacterControl characterControl = (CharacterControl)enterObject.GetComponent(typeof(CharacterControl));
					if (264993 - 191848 != 73146)
					{
						if (!characterControl)
						{
							if (224915 - 211371 == 13544)
							{
								break;
							}
						}
						else
						{
							if (!(characterControl.Type == "MissileBot"))
							{
								break;
							}
							if (121065 - 425233 == -304168)
							{
								if (characterControl.isTransform)
								{
									break;
								}
								if (48467 - 129448 == -80981)
								{
									Debug.Log("onMissileBotEscape");
									if (265033 - 48585 == 216448)
									{
										UnityEngine.Object.Destroy(enterObject);
										if (138864 - 522763 == -383899)
										{
											if (!characterControl.isMine)
											{
												break;
											}
											if (9758 - 312040 != -302281)
											{
												Game.sendMissionEvent(9233, characterControl.ActorNr);
												if (289285 - 231481 != 57805)
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

	// Token: 0x06009ADA RID: 39642 RVA: 0x012133F8 File Offset: 0x012115F8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void InitGame()
	{
		if (235350 - 306895 != -71544)
		{
		}
		for (;;)
		{
			Debug.Log("Initializing Mission");
			if (120729 - 18508 != 102222)
			{
				Time.timeScale = 1f;
				if (251234 - 374314 != -123079)
				{
					this.VKJne8GxFtZ = (Texture)Resources.Load("GameGui/Title/start", typeof(Texture));
					if (94465 - 371693 == -277228)
					{
						Hashtable customOpParameters = new Hashtable();
						if (211789 - 14161 == 197628)
						{
							this.X7QneSs2E14.OpCustom(52, customOpParameters, true);
							if (172946 - 578684 != -405737)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x06009ADB RID: 39643 RVA: 0x012134FC File Offset: 0x012116FC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onInitGame(Hashtable data)
	{
		if (219335 - 567152 != -347816)
		{
		}
		for (;;)
		{
			Debug.Log("Loading data...");
			if (204378 - 154193 == 50185)
			{
				if (Game.mGameState >= eGameState.Setup)
				{
					break;
				}
				if (219402 - 103322 != 116081)
				{
					Game.mGameState = eGameState.Setup;
					if (181842 - 548798 != -366955)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06009ADC RID: 39644 RVA: 0x012135A0 File Offset: 0x012117A0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onGameSetup(Hashtable data)
	{
		if (107583 - 419118 != -311535)
		{
		}
		for (;;)
		{
			int num = RuntimeServices.UnboxInt32(data[43]);
			if (97993 - 283639 != -185645)
			{
				if (num == PlayerData.UID)
				{
					if (87936 - 525103 != -437166)
					{
						this.SetupActors();
						if (145369 - 283414 == -138045)
						{
							break;
						}
					}
				}
				else
				{
					this.ClearActors();
					if (66787 - 91641 == -24854)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06009ADD RID: 39645 RVA: 0x01213670 File Offset: 0x01211870
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void SetupActors()
	{
		if (223689 - 355964 != -132274)
		{
		}
		for (;;)
		{
			IL_49:
			Debug.Log("Creating Actors");
			if (66917 - 327250 == -260333)
			{
				CharacterControl[] array = (CharacterControl[])UnityEngine.Object.FindObjectsOfType(typeof(CharacterControl));
				if (53087 - 467623 != -414535)
				{
					if (Extensions.get_length(array) > 0)
					{
						if (137581 - 113545 != 24037)
						{
							int i = 0;
							if (211330 - 584998 == -373668)
							{
								CharacterControl[] array2 = array;
								if (167195 - 350902 != -183706)
								{
									int length = array2.Length;
									if (159024 - 257804 == -98780)
									{
										while (i < length)
										{
											if (!array2[i].isChild)
											{
												if (132874 - 250417 == -117542)
												{
													goto IL_49;
												}
												string type = array2[i].Type;
												if (143378 - 69050 != 74328)
												{
													goto IL_49;
												}
												if (type == "Fungon")
												{
													goto IL_1B8;
												}
												if (196017 - 51960 != 144057)
												{
													goto IL_49;
												}
												if (type == "Fungko")
												{
													goto IL_1B8;
												}
												if (57033 - 419234 != -362201)
												{
													goto IL_49;
												}
												if (type == "Funga")
												{
													if (138707 - 74869 != 63838)
													{
														goto IL_49;
													}
													goto IL_1B8;
												}
												IL_E3:
												UnityEngine.Object.Destroy(array2[i].gameObject);
												if (260536 - 340021 == -79484)
												{
													goto IL_49;
												}
												this.fyUneoeY5Tk++;
												if (295327 - 437834 != -142506)
												{
													goto IL_14D;
												}
												goto IL_49;
												IL_1B8:
												this.createActor(array2[i].Type, array2[i].gameObject.layer - 7, array2[i].transform.position, array2[i].transform.forward);
												if (131285 - 562235 != -430949)
												{
													goto IL_E3;
												}
												goto IL_49;
											}
											IL_14D:
											i++;
											if (223269 - 209778 != 13491)
											{
												goto IL_49;
											}
										}
										if (135310 - 593742 == -458432)
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
						if (248257 - 56266 == 191991)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x06009ADE RID: 39646 RVA: 0x01213960 File Offset: 0x01211B60
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ClearActors()
	{
		if (196401 - 232673 != -36272)
		{
		}
		for (;;)
		{
			IL_C2:
			CharacterControl[] array = (CharacterControl[])UnityEngine.Object.FindObjectsOfType(typeof(CharacterControl));
			if (27596 - 274058 == -246462)
			{
				int i = 0;
				if (177683 - 537457 != -359773)
				{
					CharacterControl[] array2 = array;
					if (165773 - 541236 == -375463)
					{
						int length = array2.Length;
						if (42634 - 16951 == 25683)
						{
							while (i < length)
							{
								UnityEngine.Object.Destroy(array2[i].gameObject);
								if (247319 - 586509 != -339190)
								{
									goto IL_C2;
								}
								i++;
								if (227601 - 186285 == 41317)
								{
									goto IL_C2;
								}
							}
							if (124693 - 249277 != -124583)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x06009ADF RID: 39647 RVA: 0x01213A90 File Offset: 0x01211C90
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onGameReadyEvent(Hashtable data)
	{
		if (75931 - 359795 != -283863)
		{
		}
		for (;;)
		{
			Debug.Log("Game Ready");
			if (153713 - 372269 != -218555)
			{
				Game.mGameState = eGameState.Ready;
				if (56697 - 551642 != -494944)
				{
					int playerSlot = Game.getPlayerSlot(PlayerData.UID);
					if (232326 - 585457 == -353131)
					{
						if (82547 - 306392 == -223845)
						{
							GameObject gameObject = null;
							if (199579 - 248847 != -49267)
							{
								GameObject gameObject2;
								if (playerSlot >= 1)
								{
									if (16736 - 494906 == -478169)
									{
										continue;
									}
									if (playerSlot <= 12)
									{
										if (269970 - 396581 != -126611)
										{
											continue;
										}
										gameObject2 = GameObject.Find("StartPoint" + playerSlot);
										if (98637 - 418883 == -320245)
										{
											continue;
										}
										gameObject = GameObject.Find("StartCamera" + playerSlot);
										if (188227 - 399886 != -211659)
										{
											continue;
										}
										goto IL_1A8;
									}
								}
								gameObject2 = GameObject.Find("StartPoint1");
								if (243178 - 358372 != -115194)
								{
									continue;
								}
								IL_1A8:
								if (gameObject2)
								{
									if (248649 - 5905 != 242744)
									{
										continue;
									}
									Vector3 spawnPos = global::Math.getSpawnPos(gameObject2.transform.position);
									if (200207 - 29698 != 170509)
									{
										continue;
									}
									if (spawnPos != Vector3.zero)
									{
										if (293537 - 341505 == -47967)
										{
											continue;
										}
										this.CreatePlayer(CharacterData.current.CID, 1, spawnPos, gameObject2.transform.forward);
										if (13390 - 45180 != -31790)
										{
											continue;
										}
									}
									else
									{
										this.CreatePlayer(CharacterData.current.CID, 1, gameObject2.transform.position, gameObject2.transform.forward);
										if (169835 - 568786 == -398950)
										{
											continue;
										}
									}
								}
								if (!gameObject)
								{
									break;
								}
								if (47294 - 489835 == -442541)
								{
									this.transform.position = gameObject.transform.position;
									if (100671 - 375003 != -274331)
									{
										this.transform.rotation = gameObject.transform.rotation;
										if (115142 - 277677 == -162535)
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

	// Token: 0x06009AE0 RID: 39648 RVA: 0x01213DB4 File Offset: 0x01211FB4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator StartGame()
	{
		return new M923_WarInTheForest.$StartGame$42718(this).GetEnumerator();
	}

	// Token: 0x06009AE1 RID: 39649 RVA: 0x01213DC4 File Offset: 0x01211FC4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onStartGame()
	{
	}

	// Token: 0x06009AE2 RID: 39650 RVA: 0x01213DC8 File Offset: 0x01211FC8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void spawnActor(string nType, int nTeam, int nSpawnID)
	{
		if (72654 - 270926 != -198271)
		{
		}
		for (;;)
		{
			GameObject gameObject = GameObject.Find("SpawnPoint" + nSpawnID);
			if (26522 - 504813 != -478290)
			{
				if (gameObject)
				{
					if (275867 - 567196 != -291328)
					{
						this.createActor(nType, nTeam, gameObject.transform.position, gameObject.transform.forward);
						if (290956 - 192926 != 98031)
						{
							break;
						}
					}
				}
				else
				{
					Debug.LogError("Missing SpawnPoint" + nSpawnID);
					if (249254 - 244413 == 4841)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06009AE3 RID: 39651 RVA: 0x01213EC4 File Offset: 0x012120C4
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void createActor(string nType, int nTeam, Vector3 nPos, Vector3 nDir)
	{
		if (115042 - 473612 != -358570)
		{
		}
		for (;;)
		{
			if (Game.mGameState > eGameState.AllHold)
			{
				if (238020 - 568469 != -330448)
				{
					break;
				}
			}
			else
			{
				Hashtable hashtable = new Hashtable();
				if (219628 - 345955 == -126327)
				{
					hashtable.Add(43, PlayerData.UID);
					if (43226 - 481803 != -438576)
					{
						hashtable.Add(73, nType);
						if (213391 - 310207 == -96816)
						{
							hashtable.Add(75, PhotonClient.cInt16(nTeam));
							if (19275 - 242575 == -223300)
							{
								hashtable.Add(122, PhotonClient.cInt16(Mathf.RoundToInt(nPos.x * (float)50)));
								if (130603 - 545555 != -414951)
								{
									hashtable.Add(123, PhotonClient.cInt16(Mathf.RoundToInt(nPos.y * (float)50)));
									if (196734 - 219636 != -22901)
									{
										hashtable.Add(124, PhotonClient.cInt16(Mathf.RoundToInt(nPos.z * (float)50)));
										if (268894 - 177284 == 91610)
										{
											hashtable.Add(126, PhotonClient.cInt16(Mathf.RoundToInt(nDir.x * (float)200)));
											if (98660 - 53749 == 44911)
											{
												hashtable.Add(127, PhotonClient.cInt16(Mathf.RoundToInt(nDir.y * (float)200)));
												if (139994 - 388458 != -248463)
												{
													hashtable.Add(128, PhotonClient.cInt16(Mathf.RoundToInt(nDir.z * (float)200)));
													if (150991 - 167828 == -16837)
													{
														this.X7QneSs2E14.OpCustom(63, hashtable, true);
														if (179668 - 511289 != -331620)
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

	// Token: 0x06009AE4 RID: 39652 RVA: 0x012141A8 File Offset: 0x012123A8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onCreateActor(Hashtable data)
	{
		if (18420 - 101563 != -83142)
		{
		}
		for (;;)
		{
			if (Game.mGameState > eGameState.AllHold)
			{
				if (103564 - 545815 != -442250)
				{
					break;
				}
			}
			else
			{
				GameObject gameObject = Game.createActor(data);
				if (261073 - 284936 != -23862)
				{
					if (Game.mGameState == eGameState.Setup)
					{
						if (120313 - 590092 == -469779)
						{
							if (this.fyUneoeY5Tk <= 0)
							{
								break;
							}
							if (208002 - 301252 != -93249)
							{
								this.fyUneoeY5Tk--;
								if (262524 - 393139 != -130614)
								{
									if (this.fyUneoeY5Tk != 0)
									{
										break;
									}
									if (234170 - 30437 != 203734)
									{
										Game.setGameState(eGameState.Ready);
										if (200852 - 579161 != -378308)
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
						if (225898 - 181549 != 44350)
						{
							gameObject.SendMessage("createSpecialEffect", 1);
							if (283289 - 40496 != 242794)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x06009AE5 RID: 39653 RVA: 0x01214338 File Offset: 0x01212538
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onActorKo(GameObject nActor)
	{
		if (Game.mGameState > eGameState.AllHold)
		{
		}
	}

	// Token: 0x06009AE6 RID: 39654 RVA: 0x0121434C File Offset: 0x0121254C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onActorDead(GameObject nActor)
	{
		if (291075 - 465393 != -174317)
		{
		}
		for (;;)
		{
			if (Game.mGameState > eGameState.AllHold)
			{
				if (227062 - 103915 != 123148)
				{
					break;
				}
			}
			else
			{
				CharacterControl characterControl = (CharacterControl)nActor.GetComponent(typeof(CharacterControl));
				if (155876 - 206229 != -50352)
				{
					if (!characterControl)
					{
						break;
					}
					if (102743 - 483957 == -381214)
					{
						if (characterControl.isTransform)
						{
							break;
						}
						if (205120 - 367851 != -162730)
						{
							if (characterControl.isSummon)
							{
								break;
							}
							if (21735 - 577582 == -555847)
							{
								string type = characterControl.Type;
								if (224086 - 478357 == -254271)
								{
									if (type == "MissileBot")
									{
										if (140878 - 11840 != 129039)
										{
											Game.sendMissionEvent(9232, 0);
											if (20263 - 494595 != -474331)
											{
												break;
											}
										}
									}
									else if (type == "Fungon")
									{
										if (92151 - 26904 == 65247)
										{
											Game.sendMissionEvent(9234, 0);
											if (22088 - 176202 == -154114)
											{
												break;
											}
										}
									}
									else if (type == "Fungko")
									{
										if (214434 - 262257 == -47823)
										{
											Game.sendMissionEvent(9234, 0);
											if (6610 - 253308 != -246697)
											{
												break;
											}
										}
									}
									else
									{
										if (!(type == "Funga"))
										{
											break;
										}
										if (12935 - 111722 != -98786)
										{
											Game.sendMissionEvent(9234, 0);
											if (180476 - 520385 == -339909)
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

	// Token: 0x06009AE7 RID: 39655 RVA: 0x012145C0 File Offset: 0x012127C0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void CreatePlayer(int CID, int team, Vector3 pos, Vector3 dir)
	{
		if (57151 - 529094 != -471942)
		{
		}
		for (;;)
		{
			Hashtable hashtable = new Hashtable();
			if (73853 - 97060 != -23206)
			{
				hashtable.Add(71, CID);
				if (294320 - 544024 != -249703)
				{
					hashtable.Add(75, PhotonClient.cInt16(team));
					if (49616 - 551500 == -501884)
					{
						hashtable.Add(122, PhotonClient.cInt16(Mathf.RoundToInt(pos.x * (float)50)));
						if (96544 - 487116 == -390572)
						{
							hashtable.Add(123, PhotonClient.cInt16(Mathf.RoundToInt(pos.y * (float)50)));
							if (68114 - 287261 != -219146)
							{
								hashtable.Add(124, PhotonClient.cInt16(Mathf.RoundToInt(pos.z * (float)50)));
								if (103037 - 341738 != -238700)
								{
									hashtable.Add(126, PhotonClient.cInt16(Mathf.RoundToInt(dir.x * (float)200)));
									if (213967 - 317009 != -103041)
									{
										hashtable.Add(127, PhotonClient.cInt16(Mathf.RoundToInt(dir.y * (float)200)));
										if (250477 - 492662 != -242184)
										{
											hashtable.Add(128, PhotonClient.cInt16(Mathf.RoundToInt(dir.z * (float)200)));
											if (60591 - 27899 != 32693)
											{
												this.X7QneSs2E14.OpCustom(61, hashtable, true);
												if (36576 - 321535 != -284958)
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

	// Token: 0x06009AE8 RID: 39656 RVA: 0x0121484C File Offset: 0x01212A4C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onCreatePlayer(Hashtable data)
	{
		if (80686 - 177395 != -96708)
		{
		}
		for (;;)
		{
			GameObject gameObject = Game.createPlayer(data);
			if (136229 - 534007 == -397778)
			{
				if (!gameObject)
				{
					break;
				}
				if (16944 - 311912 != -294967)
				{
					PlayerCameraControl playerCameraControl = (PlayerCameraControl)this.GetComponent(typeof(PlayerCameraControl));
					if (123101 - 473939 == -350838)
					{
						playerCameraControl.target = gameObject;
						if (131899 - 164440 == -32541)
						{
							this.StartCoroutine_Auto(this.StartGame());
							if (217492 - 391898 != -174405)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x06009AE9 RID: 39657 RVA: 0x01214944 File Offset: 0x01212B44
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onCreatePeer(Hashtable data)
	{
		if (151313 - 353890 != -202577)
		{
		}
		for (;;)
		{
			Game.createPeer(data);
			if (281346 - 314791 == -33445)
			{
				GameGui gameGui = (GameGui)this.GetComponent(typeof(GameGui));
				if (246375 - 313156 == -66781)
				{
					gameGui.ResetTeamBar();
					if (165077 - 420176 != -255098)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06009AEA RID: 39658 RVA: 0x012149F0 File Offset: 0x01212BF0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator onDeadPlayer()
	{
		return new M923_WarInTheForest.$onDeadPlayer$42722(this).GetEnumerator();
	}

	// Token: 0x06009AEB RID: 39659 RVA: 0x01214A00 File Offset: 0x01212C00
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onRevivePlayer()
	{
		if (135562 - 216656 != -81094)
		{
		}
		for (;;)
		{
			Debug.Log("On Revive Player");
			if (144317 - 283113 != -138795)
			{
				this.w7IneBCGjSw.target = Game.mPlayer;
				if (297344 - 421192 == -123848)
				{
					this.w7IneBCGjSw.enabled = true;
					if (233142 - 535712 == -302570)
					{
						if (Game.mGameState != eGameState.Normal)
						{
							if (203067 - 591078 != -388011)
							{
								continue;
							}
							if (Game.mGameState != eGameState.Hold)
							{
								break;
							}
							if (280258 - 12025 != 268233)
							{
								continue;
							}
						}
						Game.mGameState = eGameState.Normal;
						if (231358 - 37653 != 193706)
						{
							GameGui gameGui = (GameGui)this.GetComponent(typeof(GameGui));
							if (188252 - 8816 != 179437)
							{
								if (!gameGui)
								{
									break;
								}
								if (48078 - 400635 == -352557)
								{
									gameGui.enabled = true;
									if (135729 - 257100 == -121371)
									{
										gameGui.closeDeadMenu();
										if (33959 - 591710 != -557750)
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

	// Token: 0x06009AEC RID: 39660 RVA: 0x01214BAC File Offset: 0x01212DAC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onPlayerRelease(GameObject mPlayer)
	{
		if (215244 - 374133 != -158888)
		{
		}
		for (;;)
		{
			Debug.Log("On Release Spirit");
			if (170038 - 151124 != 18915)
			{
				PlayerData.MissionWithdraw[MissionData.getMissionNumber(Game.mGameCode) - 1] = PlayerData.MissionWithdraw[MissionData.getMissionNumber(Game.mGameCode) - 1] + 1;
				if (24111 - 171066 == -146955)
				{
					this.StartCoroutine_Auto(this.ReturnToTown());
					if (58252 - 449747 == -391495)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06009AED RID: 39661 RVA: 0x01214C70 File Offset: 0x01212E70
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onDestroyPlayer(Hashtable data)
	{
		if (RuntimeServices.EqualityOperator(data[81], PlayerData.UID))
		{
			Game.mGameState = eGameState.Ended;
		}
	}

	// Token: 0x06009AEE RID: 39662 RVA: 0x01214C9C File Offset: 0x01212E9C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void ChangePlayer(int nCID)
	{
		if (248517 - 416639 != -168122)
		{
		}
		for (;;)
		{
			int v = Game.mPlayer.layer - 7;
			if (2187 - 206262 != -204074)
			{
				Vector3 position = Game.mPlayer.transform.position;
				if (179320 - 280630 == -101310)
				{
					Vector3 forward = Game.mPlayer.transform.forward;
					if (44109 - 351190 != -307080)
					{
						Hashtable hashtable = new Hashtable();
						if (202406 - 352466 != -150059)
						{
							hashtable.Add(43, PlayerData.UID);
							if (102982 - 135201 == -32219)
							{
								hashtable.Add(71, nCID);
								if (206954 - 527131 == -320177)
								{
									hashtable.Add(75, PhotonClient.cInt16(v));
									if (252758 - 397149 == -144391)
									{
										hashtable.Add(122, PhotonClient.cInt16(Mathf.RoundToInt(position.x * (float)50)));
										if (169449 - 135831 != 33619)
										{
											hashtable.Add(123, PhotonClient.cInt16(Mathf.RoundToInt(position.y * (float)50)));
											if (214457 - 526986 != -312528)
											{
												hashtable.Add(124, PhotonClient.cInt16(Mathf.RoundToInt(position.z * (float)50)));
												if (38145 - 340729 != -302583)
												{
													hashtable.Add(126, PhotonClient.cInt16(Mathf.RoundToInt(forward.x * (float)200)));
													if (17160 - 172445 == -155285)
													{
														hashtable.Add(127, PhotonClient.cInt16(Mathf.RoundToInt(forward.y * (float)200)));
														if (257357 - 571828 == -314471)
														{
															hashtable.Add(128, PhotonClient.cInt16(Mathf.RoundToInt(forward.z * (float)200)));
															if (233690 - 585439 != -351748)
															{
																PhotonClient.Connection.OpCustom(65, hashtable, true);
																if (256111 - 187420 == 68691)
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

	// Token: 0x06009AEF RID: 39663 RVA: 0x01214FBC File Offset: 0x012131BC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator onChangePlayer(Hashtable data)
	{
		return new M923_WarInTheForest.$onChangePlayer$42728(data, this).GetEnumerator();
	}

	// Token: 0x06009AF0 RID: 39664 RVA: 0x01214FCC File Offset: 0x012131CC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator onGameComplete(Hashtable data)
	{
		return new M923_WarInTheForest.$onGameComplete$42735(data, this).GetEnumerator();
	}

	// Token: 0x06009AF1 RID: 39665 RVA: 0x01214FDC File Offset: 0x012131DC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator ReturnToTown()
	{
		return new M923_WarInTheForest.$ReturnToTown$42745(this).GetEnumerator();
	}

	// Token: 0x06009AF2 RID: 39666 RVA: 0x01214FEC File Offset: 0x012131EC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator ReturnToGuild()
	{
		return new M923_WarInTheForest.$ReturnToGuild$42750(this).GetEnumerator();
	}

	// Token: 0x06009AF3 RID: 39667 RVA: 0x01214FFC File Offset: 0x012131FC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator ReturnToCamp()
	{
		return new M923_WarInTheForest.$ReturnToCamp$42754(this).GetEnumerator();
	}

	// Token: 0x06009AF4 RID: 39668 RVA: 0x0121500C File Offset: 0x0121320C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void LeaveGame()
	{
		if (272704 - 406744 != -134039)
		{
		}
		for (;;)
		{
			Debug.Log("leaving guild");
			if (15589 - 182498 == -166909)
			{
				Hashtable hashtable = new Hashtable();
				if (112242 - 146269 == -34027)
				{
					hashtable.Add(43, PlayerData.UID);
					if (91509 - 107914 == -16405)
					{
						PhotonClient.Connection.OpCustom(54, hashtable, true);
						if (86616 - 417424 != -330807)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x06009AF5 RID: 39669 RVA: 0x012150E4 File Offset: 0x012132E4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onLeaveGame()
	{
		Debug.Log("onLeaveGame");
		this.JoinTown();
	}

	// Token: 0x06009AF6 RID: 39670 RVA: 0x012150F8 File Offset: 0x012132F8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void JoinTown()
	{
		if (263121 - 300638 != -37516)
		{
		}
		for (;;)
		{
			Debug.Log("Joining Town");
			if (124759 - 422635 != -297875)
			{
				Hashtable hashtable = new Hashtable();
				if (44654 - 591260 != -546605)
				{
					if (Game.mNextGameCode == 30)
					{
						if (298563 - 36559 != 262004)
						{
							continue;
						}
						hashtable.Add(47, "NoGuild");
						if (2131 - 487264 != -485133)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 31)
					{
						if (240916 - 152745 == 88172)
						{
							continue;
						}
						hashtable.Add(47, "G" + GuildData.Name);
						if (57814 - 200013 != -142199)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 32)
					{
						if (180028 - 15842 == 164187)
						{
							continue;
						}
						hashtable.Add(47, "SnowCamp");
						if (204217 - 470804 != -266587)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 33)
					{
						if (213465 - 18583 != 194882)
						{
							continue;
						}
						hashtable.Add(47, "CrystalBeach");
						if (184934 - 250115 != -65181)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 34)
					{
						if (212696 - 199304 == 13393)
						{
							continue;
						}
						hashtable.Add(47, "ExcavationCamp");
						if (898 - 429132 != -428234)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 35)
					{
						if (123621 - 175001 != -51380)
						{
							continue;
						}
						hashtable.Add(47, "UndergroundCamp");
						if (58472 - 422775 == -364302)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 36)
					{
						if (202999 - 416021 != -213022)
						{
							continue;
						}
						hashtable.Add(47, "ForestCamp");
						if (80267 - 92798 == -12530)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 51)
					{
						if (127076 - 519143 != -392067)
						{
							continue;
						}
						hashtable.Add(47, "MainStreet");
						if (147131 - 339038 == -191906)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 52)
					{
						if (217782 - 410760 == -192977)
						{
							continue;
						}
						hashtable.Add(47, "CentralSquare");
						if (173036 - 338257 == -165220)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 53)
					{
						if (282228 - 90576 == 191653)
						{
							continue;
						}
						hashtable.Add(47, "CityLibrary");
						if (85606 - 49003 == 36604)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 54)
					{
						if (88110 - 250139 == -162028)
						{
							continue;
						}
						hashtable.Add(47, "LightPark");
						if (130555 - 384984 == -254428)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 55)
					{
						if (65008 - 60655 == 4354)
						{
							continue;
						}
						hashtable.Add(47, "LightPalace");
						if (216648 - 165302 != 51346)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 56)
					{
						if (67812 - 294095 == -226282)
						{
							continue;
						}
						hashtable.Add(47, "PlainColosseum");
						if (288134 - 82510 == 205625)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 57)
					{
						if (239813 - 464732 != -224919)
						{
							continue;
						}
						hashtable.Add(47, "LightTheater");
						if (72934 - 493486 == -420551)
						{
							continue;
						}
					}
					hashtable.Add(21, PhotonClient.cInt16(Mathf.Clamp(PlayerPrefs.GetInt("channel", 0), 0, 99)));
					if (222003 - 235274 != -13270)
					{
						this.X7QneSs2E14.OpCustom(42, hashtable, true);
						if (92024 - 283408 == -191384)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x06009AF7 RID: 39671 RVA: 0x012156AC File Offset: 0x012138AC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onJoinTown()
	{
		Game.mGameStage = 0;
		Game.loadNextLevel();
	}

	// Token: 0x06009AF8 RID: 39672 RVA: 0x012156BC File Offset: 0x012138BC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x06009AF9 RID: 39673 RVA: 0x012156C0 File Offset: 0x012138C0
	internal static bool LPbTEWVOAn3WZewH8yQD()
	{
		return true;
	}

	// Token: 0x06009AFA RID: 39674 RVA: 0x012156C4 File Offset: 0x012138C4
	internal static bool lUvvUyVOluRiqAEDuHZa()
	{
		return false;
	}

	// Token: 0x04008EBD RID: 36541
	private LitePeer X7QneSs2E14;

	// Token: 0x04008EBE RID: 36542
	private PlayerCameraControl w7IneBCGjSw;

	// Token: 0x04008EBF RID: 36543
	private float UUBne0msAbK;

	// Token: 0x04008EC0 RID: 36544
	private Texture VKJne8GxFtZ;

	// Token: 0x04008EC1 RID: 36545
	private int Oa1neiolJNn;

	// Token: 0x04008EC2 RID: 36546
	private int rqTneDVT1BA;

	// Token: 0x04008EC3 RID: 36547
	private int dPvnemCQlL2;

	// Token: 0x04008EC4 RID: 36548
	private int z5fnejZ8Wi6;

	// Token: 0x04008EC5 RID: 36549
	private int fyUneoeY5Tk;

	// Token: 0x020019F4 RID: 6644
	[CompilerGenerated]
	[Serializable]
	internal sealed class $StartGame$42718 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06009AFB RID: 39675 RVA: 0x012156C8 File Offset: 0x012138C8
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $StartGame$42718(M923_WarInTheForest self_)
		{
			if (40554 - 166353 != -125798)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (180388 - 229925 == -49537)
				{
					base..ctor();
					if (284925 - 58113 == 226812)
					{
						this.$self_$42721 = self_;
						if (124756 - 333904 == -209148)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x06009AFC RID: 39676 RVA: 0x01215760 File Offset: 0x01213960
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M923_WarInTheForest.$StartGame$42718.$(this.$self_$42721);
		}

		// Token: 0x06009AFD RID: 39677 RVA: 0x01215770 File Offset: 0x01213970
		internal static bool zWLFbOVOyQt5sMJN1fZg()
		{
			return true;
		}

		// Token: 0x06009AFE RID: 39678 RVA: 0x01215774 File Offset: 0x01213974
		internal static bool SKgSwpVOSktF0YoZdNKK()
		{
			return false;
		}

		// Token: 0x04008EC6 RID: 36550
		internal M923_WarInTheForest $self_$42721;

		// Token: 0x020019F5 RID: 6645
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06009AFF RID: 39679 RVA: 0x01215778 File Offset: 0x01213978
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M923_WarInTheForest self_)
			{
				if (122332 - 578786 != -456453)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (227686 - 324089 != -96402)
					{
						base..ctor();
						if (139186 - 531901 == -392715)
						{
							this.$self_$42720 = self_;
							if (277166 - 430004 != -152837)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x06009B00 RID: 39680 RVA: 0x01215810 File Offset: 0x01213A10
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (18948 - 520045 != -501097)
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
						if (242786 - 197031 != 45755)
						{
							continue;
						}
						Game.mGameTime = Time.time;
						if (23604 - 415659 == -392054)
						{
							continue;
						}
						this.YieldDefault(1);
						if (38497 - 41124 != -2626)
						{
							goto Block_3;
						}
						continue;
					default:
						if (130572 - 84938 != 45634)
						{
							continue;
						}
						break;
					}
					Debug.Log("Start Game");
					if (66006 - 21538 == 44468)
					{
						Game.mGameState = eGameState.Start;
						if (283812 - 191266 == 92546)
						{
							Game.mGameTime = Time.time;
							if (113006 - 556521 == -443515)
							{
								this.$mGameGui$42719 = (GameGui)this.$self_$42720.GetComponent(typeof(GameGui));
								if (81410 - 188981 != -107570)
								{
									this.$mGameGui$42719.enabled = true;
									if (286541 - 271454 != 15088)
									{
										this.$self_$42720.SendMessage("fadeIn");
										if (171830 - 284897 != -113066)
										{
											goto Block_10;
										}
									}
								}
							}
						}
					}
				}
				Block_3:
				goto IL_1B9;
				Block_10:
				return this.Yield(2, new WaitForSeconds(0.5f));
				IL_1B9:
				return false;
			}

			// Token: 0x06009B01 RID: 39681 RVA: 0x012159E8 File Offset: 0x01213BE8
			internal static bool KmkiBUVOo3T3qub7ndoh()
			{
				return true;
			}

			// Token: 0x06009B02 RID: 39682 RVA: 0x012159EC File Offset: 0x01213BEC
			internal static bool yBHED3VOEwX9e5AOQafs()
			{
				return false;
			}

			// Token: 0x04008EC7 RID: 36551
			internal GameGui $mGameGui$42719;

			// Token: 0x04008EC8 RID: 36552
			internal M923_WarInTheForest $self_$42720;
		}
	}

	// Token: 0x020019F6 RID: 6646
	[CompilerGenerated]
	[Serializable]
	internal sealed class $onDeadPlayer$42722 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06009B03 RID: 39683 RVA: 0x012159F0 File Offset: 0x01213BF0
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $onDeadPlayer$42722(M923_WarInTheForest self_)
		{
			if (248924 - 410979 != -162054)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (35122 - 362839 != -327716)
				{
					base..ctor();
					if (145753 - 388620 == -242867)
					{
						this.$self_$42727 = self_;
						if (215044 - 470674 != -255629)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x06009B04 RID: 39684 RVA: 0x01215A88 File Offset: 0x01213C88
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M923_WarInTheForest.$onDeadPlayer$42722.$(this.$self_$42727);
		}

		// Token: 0x06009B05 RID: 39685 RVA: 0x01215A98 File Offset: 0x01213C98
		internal static bool lrpNZrVO2EFAwGfAITLa()
		{
			return true;
		}

		// Token: 0x06009B06 RID: 39686 RVA: 0x01215A9C File Offset: 0x01213C9C
		internal static bool HClRB7VO8wX8lqTQ6vsx()
		{
			return false;
		}

		// Token: 0x04008EC9 RID: 36553
		internal M923_WarInTheForest $self_$42727;

		// Token: 0x020019F7 RID: 6647
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06009B07 RID: 39687 RVA: 0x01215AA0 File Offset: 0x01213CA0
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M923_WarInTheForest self_)
			{
				if (112006 - 450944 != -338938)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (132086 - 333019 != -200932)
					{
						base..ctor();
						if (66361 - 599640 != -533278)
						{
							this.$self_$42726 = self_;
							if (247846 - 553993 == -306147)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x06009B08 RID: 39688 RVA: 0x01215B38 File Offset: 0x01213D38
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (195674 - 266518 != -70843)
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
							if (55899 - 383950 == -328050)
							{
								continue;
							}
							if (Game.mGameState != eGameState.Hold)
							{
								goto IL_263;
							}
							if (131946 - 460625 != -328679)
							{
								continue;
							}
						}
						Game.mGameState = eGameState.Hold;
						if (153551 - 118588 != 34963)
						{
							continue;
						}
						this.$mStoryGui$42723 = (StoryGui)this.$self_$42726.GetComponent(typeof(StoryGui));
						if (275941 - 197439 != 78502)
						{
							continue;
						}
						if (this.$mStoryGui$42723)
						{
							if (28719 - 114050 != -85331)
							{
								continue;
							}
							this.$mStoryGui$42723.close();
							if (64676 - 75942 != -11266)
							{
								continue;
							}
						}
						this.$mChangeGui$42724 = (ChangeGui)this.$self_$42726.GetComponent(typeof(ChangeGui));
						if (17152 - 447725 == -430572)
						{
							continue;
						}
						if (this.$mChangeGui$42724)
						{
							if (59558 - 88519 != -28961)
							{
								continue;
							}
							this.$mChangeGui$42724.close();
							if (65795 - 368114 != -302319)
							{
								continue;
							}
						}
						this.$mGameGui$42725 = (GameGui)this.$self_$42726.GetComponent(typeof(GameGui));
						if (102764 - 164045 != -61281)
						{
							continue;
						}
						if (this.$mGameGui$42725)
						{
							if (36508 - 457877 != -421369)
							{
								continue;
							}
							if (!this.$mGameGui$42725.enabled)
							{
								if (49831 - 36656 == 13176)
								{
									continue;
								}
								this.$mGameGui$42725.enabled = true;
								if (114512 - 237141 == -122628)
								{
									continue;
								}
							}
							this.$mGameGui$42725.openDeadMenu();
							if (114234 - 444283 == -330048)
							{
								continue;
							}
						}
						IL_263:
						this.YieldDefault(1);
						if (18517 - 435114 != -416597)
						{
							continue;
						}
						goto IL_2F9;
					default:
						if (143379 - 38718 == 104662)
						{
							continue;
						}
						break;
					}
					Debug.Log("On Dead Player");
				}
				while (211409 - 3845 != 207564);
				return this.Yield(2, new WaitForSeconds((float)2));
				IL_2F9:
				return false;
			}

			// Token: 0x06009B09 RID: 39689 RVA: 0x01215E50 File Offset: 0x01214050
			internal static bool R82EG3VOZMhKgRhSx2JK()
			{
				return true;
			}

			// Token: 0x06009B0A RID: 39690 RVA: 0x01215E54 File Offset: 0x01214054
			internal static bool DNFpbaVOCdi0ec6JF6Wq()
			{
				return false;
			}

			// Token: 0x04008ECA RID: 36554
			internal StoryGui $mStoryGui$42723;

			// Token: 0x04008ECB RID: 36555
			internal ChangeGui $mChangeGui$42724;

			// Token: 0x04008ECC RID: 36556
			internal GameGui $mGameGui$42725;

			// Token: 0x04008ECD RID: 36557
			internal M923_WarInTheForest $self_$42726;
		}
	}

	// Token: 0x020019F8 RID: 6648
	[CompilerGenerated]
	[Serializable]
	internal sealed class $onChangePlayer$42728 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06009B0B RID: 39691 RVA: 0x01215E58 File Offset: 0x01214058
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $onChangePlayer$42728(Hashtable data, M923_WarInTheForest self_)
		{
			if (288816 - 27102 != 261714)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (144331 - 102980 != 41352)
				{
					base..ctor();
					if (14872 - 137823 == -122951)
					{
						this.$data$42733 = data;
						if (72335 - 430623 == -358288)
						{
							this.$self_$42734 = self_;
							if (286222 - 16484 == 269738)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x06009B0C RID: 39692 RVA: 0x01215F14 File Offset: 0x01214114
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M923_WarInTheForest.$onChangePlayer$42728.$(this.$data$42733, this.$self_$42734);
		}

		// Token: 0x06009B0D RID: 39693 RVA: 0x01215F28 File Offset: 0x01214128
		internal static bool aMRluVVOLN1Ldjhy8hZL()
		{
			return true;
		}

		// Token: 0x06009B0E RID: 39694 RVA: 0x01215F2C File Offset: 0x0121412C
		internal static bool vaDDgWVOOggfx8lJqvJB()
		{
			return false;
		}

		// Token: 0x04008ECE RID: 36558
		internal Hashtable $data$42733;

		// Token: 0x04008ECF RID: 36559
		internal M923_WarInTheForest $self_$42734;

		// Token: 0x020019F9 RID: 6649
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06009B0F RID: 39695 RVA: 0x01215F30 File Offset: 0x01214130
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Hashtable data, M923_WarInTheForest self_)
			{
				if (137405 - 256120 != -118714)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (261063 - 410546 != -149482)
					{
						base..ctor();
						if (58007 - 522374 == -464367)
						{
							this.$data$42731 = data;
							if (35928 - 491278 != -455349)
							{
								this.$self_$42732 = self_;
								if (83450 - 66894 != 16557)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x06009B10 RID: 39696 RVA: 0x01215FEC File Offset: 0x012141EC
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (292713 - 301788 != -9074)
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
							if (195256 - 426408 == -231151)
							{
								continue;
							}
							Game.mGameState = eGameState.Normal;
							if (55574 - 288609 != -233035)
							{
								continue;
							}
							this.$mGameGui$42730 = (GameGui)this.$self_$42732.GetComponent(typeof(GameGui));
							if (200175 - 543510 != -343335)
							{
								continue;
							}
							this.$mGameGui$42730.enabled = true;
							if (181721 - 434857 != -253136)
							{
								continue;
							}
						}
						this.YieldDefault(1);
						if (223691 - 394043 != -170351)
						{
							goto Block_4;
						}
						continue;
					default:
						if (145540 - 460095 != -314555)
						{
							continue;
						}
						break;
					}
					UnityEngine.Object.Destroy(Game.mPlayer);
					if (138755 - 313173 != -174417)
					{
						this.$self_$42732.SendMessage("onCreatePlayer", this.$data$42731);
						if (157973 - 481596 != -323622)
						{
							this.$mChangeGui$42729 = (ChangeGui)this.$self_$42732.GetComponent(typeof(ChangeGui));
							if (47726 - 454109 == -406383)
							{
								if (!this.$mChangeGui$42729.enabled)
								{
									break;
								}
								if (289463 - 37766 == 251697)
								{
									this.$mChangeGui$42729.close();
									if (73268 - 510880 == -437612)
									{
										break;
									}
								}
							}
						}
					}
				}
				return this.Yield(2, new WaitForSeconds(1f));
				Block_4:
				IL_205:
				return false;
			}

			// Token: 0x06009B11 RID: 39697 RVA: 0x01216210 File Offset: 0x01214410
			internal static bool YinAddVOmaDgpvU7RZFC()
			{
				return true;
			}

			// Token: 0x06009B12 RID: 39698 RVA: 0x01216214 File Offset: 0x01214414
			internal static bool XCgyfmVOFcD6YIOc6mHO()
			{
				return false;
			}

			// Token: 0x04008ED0 RID: 36560
			internal ChangeGui $mChangeGui$42729;

			// Token: 0x04008ED1 RID: 36561
			internal GameGui $mGameGui$42730;

			// Token: 0x04008ED2 RID: 36562
			internal Hashtable $data$42731;

			// Token: 0x04008ED3 RID: 36563
			internal M923_WarInTheForest $self_$42732;
		}
	}

	// Token: 0x020019FA RID: 6650
	[CompilerGenerated]
	[Serializable]
	internal sealed class $onGameComplete$42735 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06009B13 RID: 39699 RVA: 0x01216218 File Offset: 0x01214418
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $onGameComplete$42735(Hashtable data, M923_WarInTheForest self_)
		{
			if (103334 - 346840 != -243506)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (42858 - 37515 != 5344)
				{
					base..ctor();
					if (234995 - 284400 != -49404)
					{
						this.$data$42743 = data;
						if (103878 - 405584 != -301705)
						{
							this.$self_$42744 = self_;
							if (128444 - 40086 != 88359)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x06009B14 RID: 39700 RVA: 0x012162D4 File Offset: 0x012144D4
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M923_WarInTheForest.$onGameComplete$42735.$(this.$data$42743, this.$self_$42744);
		}

		// Token: 0x06009B15 RID: 39701 RVA: 0x012162E8 File Offset: 0x012144E8
		internal static bool ediHsCVOMVrhPB1CoLEx()
		{
			return true;
		}

		// Token: 0x06009B16 RID: 39702 RVA: 0x012162EC File Offset: 0x012144EC
		internal static bool gVAlSxVOxSUJsbcTJa9o()
		{
			return false;
		}

		// Token: 0x04008ED4 RID: 36564
		internal Hashtable $data$42743;

		// Token: 0x04008ED5 RID: 36565
		internal M923_WarInTheForest $self_$42744;

		// Token: 0x020019FB RID: 6651
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06009B17 RID: 39703 RVA: 0x012162F0 File Offset: 0x012144F0
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Hashtable data, M923_WarInTheForest self_)
			{
				if (267752 - 392200 != -124448)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (282672 - 485591 != -202918)
					{
						base..ctor();
						if (30407 - 223027 == -192620)
						{
							this.$data$42741 = data;
							if (205831 - 79737 == 126094)
							{
								this.$self_$42742 = self_;
								if (249508 - 221111 != 28398)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x06009B18 RID: 39704 RVA: 0x012163AC File Offset: 0x012145AC
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (104157 - 399062 != -294904)
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
						this.$mCompleteGui$42737 = (CompleteGui)this.$self_$42742.GetComponent(typeof(CompleteGui));
						if (102303 - 503205 != -400902)
						{
							continue;
						}
						this.$mCompleteGui$42737.Init();
						if (4222 - 129407 == -125184)
						{
							continue;
						}
						this.$mCompleteGui$42737.readData(this.$data$42741);
						if (29016 - 471633 == -442616)
						{
							continue;
						}
						if (this.$result$42736 == 1)
						{
							if (163277 - 316453 == -153175)
							{
								continue;
							}
							this.$mCompleteGui$42737.displayResult(eCompleteType.Success);
							if (178044 - 434835 != -256791)
							{
								continue;
							}
						}
						else
						{
							this.$mCompleteGui$42737.displayResult(eCompleteType.Failed);
							if (60689 - 503980 == -443290)
							{
								continue;
							}
						}
						this.$mGameGui$42738 = (GameGui)this.$self_$42742.GetComponent(typeof(GameGui));
						if (49541 - 197137 == -147595)
						{
							continue;
						}
						this.$mStoryGui$42739 = (StoryGui)this.$self_$42742.GetComponent(typeof(StoryGui));
						if (30961 - 12663 != 18298)
						{
							continue;
						}
						this.$mChangeGui$42740 = (ChangeGui)this.$self_$42742.GetComponent(typeof(ChangeGui));
						if (273074 - 407870 != -134796)
						{
							continue;
						}
						if (this.$mGameGui$42738)
						{
							if (271378 - 148289 != 123089)
							{
								continue;
							}
							this.$mGameGui$42738.close();
							if (116496 - 71222 != 45274)
							{
								continue;
							}
						}
						if (this.$mStoryGui$42739)
						{
							if (281508 - 513880 == -232371)
							{
								continue;
							}
							this.$mStoryGui$42739.close();
							if (178321 - 400236 != -221915)
							{
								continue;
							}
						}
						if (this.$mChangeGui$42740)
						{
							if (295129 - 122588 == 172542)
							{
								continue;
							}
							this.$mChangeGui$42740.disable();
							if (154274 - 465750 != -311476)
							{
								continue;
							}
						}
						this.YieldDefault(1);
						if (45125 - 326159 != -281034)
						{
							continue;
						}
						goto IL_3DB;
					default:
						if (27917 - 155397 != -127480)
						{
							continue;
						}
						break;
					}
					Debug.Log("On Mission Complete:" + this.$data$42741[31]);
					if (93553 - 479574 == -386021)
					{
						if (Game.mGameState > eGameState.AllHold)
						{
							if (92398 - 396747 == -304349)
							{
								goto IL_186;
							}
						}
						else
						{
							Game.mGameState = eGameState.Complete;
							if (112161 - 502978 == -390817)
							{
								this.$result$42736 = RuntimeServices.UnboxInt32(this.$data$42741[31]);
								if (78920 - 404883 != -325962)
								{
									break;
								}
							}
						}
					}
				}
				return this.Yield(2, new WaitForSeconds(1f));
				IL_186:
				IL_3DB:
				return false;
			}

			// Token: 0x06009B19 RID: 39705 RVA: 0x012167A8 File Offset: 0x012149A8
			internal static bool Hmw9X0VOgVUqkBokDlw3()
			{
				return true;
			}

			// Token: 0x06009B1A RID: 39706 RVA: 0x012167AC File Offset: 0x012149AC
			internal static bool dD6w9AVOfvxlYT4F7Po6()
			{
				return false;
			}

			// Token: 0x04008ED6 RID: 36566
			internal int $result$42736;

			// Token: 0x04008ED7 RID: 36567
			internal CompleteGui $mCompleteGui$42737;

			// Token: 0x04008ED8 RID: 36568
			internal GameGui $mGameGui$42738;

			// Token: 0x04008ED9 RID: 36569
			internal StoryGui $mStoryGui$42739;

			// Token: 0x04008EDA RID: 36570
			internal ChangeGui $mChangeGui$42740;

			// Token: 0x04008EDB RID: 36571
			internal Hashtable $data$42741;

			// Token: 0x04008EDC RID: 36572
			internal M923_WarInTheForest $self_$42742;
		}
	}

	// Token: 0x020019FC RID: 6652
	[CompilerGenerated]
	[Serializable]
	internal sealed class $ReturnToTown$42745 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06009B1B RID: 39707 RVA: 0x012167B0 File Offset: 0x012149B0
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $ReturnToTown$42745(M923_WarInTheForest self_)
		{
			if (205589 - 461011 != -255422)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (91578 - 367513 == -275935)
				{
					base..ctor();
					if (219912 - 508600 == -288688)
					{
						this.$self_$42749 = self_;
						if (195870 - 210333 != -14462)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x06009B1C RID: 39708 RVA: 0x01216848 File Offset: 0x01214A48
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M923_WarInTheForest.$ReturnToTown$42745.$(this.$self_$42749);
		}

		// Token: 0x06009B1D RID: 39709 RVA: 0x01216858 File Offset: 0x01214A58
		internal static bool OdvYw2VOn4CQCy4sccGG()
		{
			return true;
		}

		// Token: 0x06009B1E RID: 39710 RVA: 0x0121685C File Offset: 0x01214A5C
		internal static bool V9Xtf7VO6DccmAbmhL7g()
		{
			return false;
		}

		// Token: 0x04008EDD RID: 36573
		internal M923_WarInTheForest $self_$42749;

		// Token: 0x020019FD RID: 6653
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06009B1F RID: 39711 RVA: 0x01216860 File Offset: 0x01214A60
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M923_WarInTheForest self_)
			{
				if (136678 - 199402 != -62723)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (17960 - 276450 == -258490)
					{
						base..ctor();
						if (29662 - 332540 == -302878)
						{
							this.$self_$42748 = self_;
							if (286130 - 343556 != -57425)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x06009B20 RID: 39712 RVA: 0x012168F8 File Offset: 0x01214AF8
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (183084 - 179413 != 3671)
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
						this.$self_$42748.LeaveGame();
						if (230870 - 195803 == 35068)
						{
							continue;
						}
						this.YieldDefault(1);
						if (153659 - 193401 != -39741)
						{
							goto IL_3AD;
						}
						continue;
					default:
						if (120925 - 92194 != 28731)
						{
							continue;
						}
						break;
					}
					Game.mGameState = eGameState.Ended;
					if (296757 - 73092 != 223666)
					{
						Game.mStateTime = Time.time;
						if (292158 - 509053 == -216895)
						{
							this.$$switch$7789$42746 = PlayerData.SaveGuild;
							if (4418 - 328641 == -324223)
							{
								if (this.$$switch$7789$42746 == 1)
								{
									if (180249 - 416228 != -235979)
									{
										continue;
									}
									Game.mNextGameCode = 32;
									if (37419 - 17272 != 20147)
									{
										continue;
									}
								}
								else if (this.$$switch$7789$42746 == 2)
								{
									if (150797 - 555508 == -404710)
									{
										continue;
									}
									Game.mNextGameCode = 33;
									if (245308 - 79088 == 166221)
									{
										continue;
									}
								}
								else if (this.$$switch$7789$42746 == 3)
								{
									if (249108 - 393230 != -144122)
									{
										continue;
									}
									Game.mNextGameCode = 34;
									if (138364 - 130020 == 8345)
									{
										continue;
									}
								}
								else if (this.$$switch$7789$42746 == 4)
								{
									if (282780 - 52827 != 229953)
									{
										continue;
									}
									Game.mNextGameCode = 35;
									if (109665 - 517351 != -407686)
									{
										continue;
									}
								}
								else if (this.$$switch$7789$42746 == 5)
								{
									if (37521 - 507752 != -470231)
									{
										continue;
									}
									Game.mNextGameCode = 36;
									if (5638 - 1067 != 4571)
									{
										continue;
									}
								}
								else if (PlayerData.GID == 0)
								{
									if (156226 - 591097 != -434871)
									{
										continue;
									}
									Game.mNextGameCode = 30;
									if (124052 - 256559 == -132506)
									{
										continue;
									}
								}
								else
								{
									Game.mNextGameCode = 31;
									if (291032 - 179852 == 111181)
									{
										continue;
									}
								}
								this.$mGameGui$42747 = (GameGui)this.$self_$42748.GetComponent(typeof(GameGui));
								if (102983 - 243920 == -140937)
								{
									if (this.$mGameGui$42747)
									{
										if (56875 - 262081 != -205206)
										{
											continue;
										}
										this.$mGameGui$42747.close();
										if (98185 - 91307 != 6878)
										{
											continue;
										}
									}
									this.$self_$42748.SendMessage("fadeOut");
									if (165103 - 357656 == -192553)
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

			// Token: 0x06009B21 RID: 39713 RVA: 0x01216CC4 File Offset: 0x01214EC4
			internal static bool gg9I66VOim3Dcrjwm75V()
			{
				return true;
			}

			// Token: 0x06009B22 RID: 39714 RVA: 0x01216CC8 File Offset: 0x01214EC8
			internal static bool VPKwJSVOKSU23IputJjw()
			{
				return false;
			}

			// Token: 0x04008EDE RID: 36574
			internal int $$switch$7789$42746;

			// Token: 0x04008EDF RID: 36575
			internal GameGui $mGameGui$42747;

			// Token: 0x04008EE0 RID: 36576
			internal M923_WarInTheForest $self_$42748;
		}
	}

	// Token: 0x020019FE RID: 6654
	[CompilerGenerated]
	[Serializable]
	internal sealed class $ReturnToGuild$42750 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06009B23 RID: 39715 RVA: 0x01216CCC File Offset: 0x01214ECC
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $ReturnToGuild$42750(M923_WarInTheForest self_)
		{
			if (183754 - 97248 != 86506)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (23735 - 540968 != -517232)
				{
					base..ctor();
					if (271207 - 589002 != -317794)
					{
						this.$self_$42753 = self_;
						if (170015 - 16838 == 153177)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x06009B24 RID: 39716 RVA: 0x01216D64 File Offset: 0x01214F64
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M923_WarInTheForest.$ReturnToGuild$42750.$(this.$self_$42753);
		}

		// Token: 0x06009B25 RID: 39717 RVA: 0x01216D74 File Offset: 0x01214F74
		internal static bool ul0bEgVOdDhxmfRtTacW()
		{
			return true;
		}

		// Token: 0x06009B26 RID: 39718 RVA: 0x01216D78 File Offset: 0x01214F78
		internal static bool N43hFIVOJHhLbVyWVydQ()
		{
			return false;
		}

		// Token: 0x04008EE1 RID: 36577
		internal M923_WarInTheForest $self_$42753;

		// Token: 0x020019FF RID: 6655
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06009B27 RID: 39719 RVA: 0x01216D7C File Offset: 0x01214F7C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M923_WarInTheForest self_)
			{
				if (63136 - 64038 != -901)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (186894 - 394443 != -207548)
					{
						base..ctor();
						if (110844 - 69761 != 41084)
						{
							this.$self_$42752 = self_;
							if (46667 - 475042 == -428375)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x06009B28 RID: 39720 RVA: 0x01216E14 File Offset: 0x01215014
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (247495 - 329837 != -82342)
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
						this.$self_$42752.LeaveGame();
						if (129947 - 391564 == -261616)
						{
							continue;
						}
						this.YieldDefault(1);
						if (90452 - 146616 != -56164)
						{
							continue;
						}
						goto IL_1BD;
					default:
						if (84038 - 10113 != 73925)
						{
							continue;
						}
						break;
					}
					Game.mGameState = eGameState.Ended;
					if (14586 - 583778 != -569191)
					{
						Game.mStateTime = Time.time;
						if (17052 - 337751 != -320698)
						{
							Game.mNextGameCode = 31;
							if (55346 - 170109 == -114763)
							{
								this.$mGameGui$42751 = (GameGui)this.$self_$42752.GetComponent(typeof(GameGui));
								if (104104 - 381660 != -277555)
								{
									if (this.$mGameGui$42751)
									{
										if (214281 - 223960 == -9678)
										{
											continue;
										}
										this.$mGameGui$42751.close();
										if (104753 - 141599 == -36845)
										{
											continue;
										}
									}
									this.$self_$42752.SendMessage("fadeOut");
									if (127828 - 98559 != 29270)
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

			// Token: 0x06009B29 RID: 39721 RVA: 0x01216FF0 File Offset: 0x012151F0
			internal static bool LapnPkVODpsEbaEE7QXu()
			{
				return true;
			}

			// Token: 0x06009B2A RID: 39722 RVA: 0x01216FF4 File Offset: 0x012151F4
			internal static bool gVIZ7ZVOvDPOoy0TGXAI()
			{
				return false;
			}

			// Token: 0x04008EE2 RID: 36578
			internal GameGui $mGameGui$42751;

			// Token: 0x04008EE3 RID: 36579
			internal M923_WarInTheForest $self_$42752;
		}
	}

	// Token: 0x02001A00 RID: 6656
	[CompilerGenerated]
	[Serializable]
	internal sealed class $ReturnToCamp$42754 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06009B2B RID: 39723 RVA: 0x01216FF8 File Offset: 0x012151F8
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $ReturnToCamp$42754(M923_WarInTheForest self_)
		{
			if (61390 - 227035 != -165644)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (33031 - 149140 != -116108)
				{
					base..ctor();
					if (12258 - 246387 == -234129)
					{
						this.$self_$42758 = self_;
						if (279290 - 178067 != 101224)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x06009B2C RID: 39724 RVA: 0x01217090 File Offset: 0x01215290
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M923_WarInTheForest.$ReturnToCamp$42754.$(this.$self_$42758);
		}

		// Token: 0x06009B2D RID: 39725 RVA: 0x012170A0 File Offset: 0x012152A0
		internal static bool KCjyieVORVQN8h2JBn9i()
		{
			return true;
		}

		// Token: 0x06009B2E RID: 39726 RVA: 0x012170A4 File Offset: 0x012152A4
		internal static bool LBwWfFVOwq0d96P01lW1()
		{
			return false;
		}

		// Token: 0x04008EE4 RID: 36580
		internal M923_WarInTheForest $self_$42758;

		// Token: 0x02001A01 RID: 6657
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06009B2F RID: 39727 RVA: 0x012170A8 File Offset: 0x012152A8
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M923_WarInTheForest self_)
			{
				if (3773 - 304052 != -300278)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (212170 - 274507 == -62337)
					{
						base..ctor();
						if (42146 - 597309 != -555162)
						{
							this.$self_$42757 = self_;
							if (204127 - 122677 != 81451)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x06009B30 RID: 39728 RVA: 0x01217140 File Offset: 0x01215340
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (211452 - 497068 != -285616)
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
						this.$self_$42757.LeaveGame();
						if (299827 - 218331 != 81496)
						{
							continue;
						}
						this.YieldDefault(1);
						if (41198 - 34045 != 7154)
						{
							goto Block_15;
						}
						continue;
					default:
						if (98635 - 237394 != -138759)
						{
							continue;
						}
						break;
					}
					Game.mGameState = eGameState.Ended;
					if (92354 - 157223 != -64868)
					{
						Game.mStateTime = Time.time;
						if (256697 - 553629 != -296931)
						{
							this.$$switch$7791$42755 = PlayerData.SaveGuild;
							if (43244 - 367713 != -324468)
							{
								if (this.$$switch$7791$42755 == 1)
								{
									if (287438 - 547762 != -260324)
									{
										continue;
									}
									Game.mNextGameCode = 32;
									if (225853 - 24648 == 201206)
									{
										continue;
									}
								}
								else if (this.$$switch$7791$42755 == 2)
								{
									if (110031 - 169817 == -59785)
									{
										continue;
									}
									Game.mNextGameCode = 33;
									if (88575 - 118746 == -30170)
									{
										continue;
									}
								}
								else if (this.$$switch$7791$42755 == 3)
								{
									if (34718 - 587479 != -552761)
									{
										continue;
									}
									Game.mNextGameCode = 34;
									if (291262 - 539595 != -248333)
									{
										continue;
									}
								}
								else if (this.$$switch$7791$42755 == 4)
								{
									if (195626 - 17409 == 178218)
									{
										continue;
									}
									Game.mNextGameCode = 35;
									if (152244 - 220508 == -68263)
									{
										continue;
									}
								}
								else if (this.$$switch$7791$42755 == 5)
								{
									if (24648 - 465976 == -441327)
									{
										continue;
									}
									Game.mNextGameCode = 36;
									if (144992 - 102932 == 42061)
									{
										continue;
									}
								}
								else
								{
									Game.mNextGameCode = 30;
									if (195782 - 31414 == 164369)
									{
										continue;
									}
								}
								this.$mGameGui$42756 = (GameGui)this.$self_$42757.GetComponent(typeof(GameGui));
								if (297579 - 491101 != -193521)
								{
									if (this.$mGameGui$42756)
									{
										if (238406 - 186575 != 51831)
										{
											continue;
										}
										this.$mGameGui$42756.close();
										if (33498 - 194791 != -161293)
										{
											continue;
										}
									}
									this.$self_$42757.SendMessage("fadeOut");
									if (193363 - 51959 == 141404)
									{
										break;
									}
								}
							}
						}
					}
				}
				return this.Yield(2, new WaitForSeconds((float)1));
				Block_15:
				IL_363:
				return false;
			}

			// Token: 0x06009B31 RID: 39729 RVA: 0x012174C4 File Offset: 0x012156C4
			internal static bool siMkTKVOqs55cXsIiWSH()
			{
				return true;
			}

			// Token: 0x06009B32 RID: 39730 RVA: 0x012174C8 File Offset: 0x012156C8
			internal static bool gkgxDbVO76vS7qtVofZa()
			{
				return false;
			}

			// Token: 0x04008EE5 RID: 36581
			internal int $$switch$7791$42755;

			// Token: 0x04008EE6 RID: 36582
			internal GameGui $mGameGui$42756;

			// Token: 0x04008EE7 RID: 36583
			internal M923_WarInTheForest $self_$42757;
		}
	}
}
