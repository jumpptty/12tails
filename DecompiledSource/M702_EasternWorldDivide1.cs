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

// Token: 0x020016D1 RID: 5841
[Serializable]
public class M702_EasternWorldDivide1 : MonoBehaviour
{
	// Token: 0x0600879F RID: 34719 RVA: 0x010D4828 File Offset: 0x010D2A28
	[MethodImpl(MethodImplOptions.NoInlining)]
	public M702_EasternWorldDivide1()
	{
		LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
		base..ctor();
	}

	// Token: 0x060087A0 RID: 34720 RVA: 0x010D4838 File Offset: 0x010D2A38
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Awake()
	{
		if (250298 - 327445 != -77146)
		{
		}
		for (;;)
		{
			Game.mGameState = eGameState.Init;
			if (111537 - 145368 != -33830)
			{
				Game.mGameType = 5;
				if (116438 - 191377 != -74938)
				{
					if (Chat.Initialized)
					{
						if (127173 - 554943 != -427769)
						{
							Chat.ChatDisplay.Clear();
							if (52628 - 253417 == -200789)
							{
								break;
							}
						}
					}
					else
					{
						Chat.Init();
						if (244951 - 438521 == -193570)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x060087A1 RID: 34721 RVA: 0x010D491C File Offset: 0x010D2B1C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Start()
	{
		if (258370 - 557231 != -298861)
		{
		}
		for (;;)
		{
			if (PhotonClient.IsInitialized())
			{
				if (231706 - 503292 != -271585)
				{
					if (Game.mNextGameCode != 702)
					{
						break;
					}
					if (65990 - 122222 != -56231)
					{
						Game.nextGame();
						if (69128 - 294142 != -225013)
						{
							Game.mGameCode = 702;
							if (135953 - 385100 != -249146)
							{
								Game.mGameType = 5;
								if (8547 - 248020 == -239473)
								{
									Game.mGameTime = Time.time;
									if (104390 - 16332 == 88058)
									{
										Game.mGameScore = 0;
										if (69304 - 450906 == -381602)
										{
											Game.mGameMana = 0;
											if (292848 - 518647 != -225798)
											{
												Game.canUseItem = MissionData.getAllowItem(Game.mGameCode);
												if (96922 - 315357 != -218434)
												{
													Game.canUseMount = MissionData.getAllowMount(Game.mGameCode);
													if (288348 - 31149 != 257200)
													{
														Game.canChangeChar = MissionData.getAllowChange(Game.mGameCode);
														if (288725 - 278718 == 10007)
														{
															Game.canRespawn = MissionData.getAllowRespawn(Game.mGameCode);
															if (66831 - 469685 != -402853)
															{
																Game.canUseCoin = MissionData.getAllowCoin(Game.mGameCode);
																if (136690 - 279589 == -142899)
																{
																	this.MWlcuKYm1gD = (PlayerCameraControl)this.GetComponent(typeof(PlayerCameraControl));
																	if (183992 - 480178 == -296186)
																	{
																		this.LE1cuhfPZpq = PhotonClient.Connection;
																		if (263354 - 268456 == -5102)
																		{
																			PhotonClient.ActorNrList.Clear();
																			if (135480 - 164968 == -29488)
																			{
																				this.InitGame();
																				if (278922 - 292481 != -13558)
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
				if (91087 - 448696 != -357608)
				{
					Game.mGameType = 99;
					if (173883 - 23676 == 150207)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x060087A2 RID: 34722 RVA: 0x010D4C24 File Offset: 0x010D2E24
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void FixedUpdate()
	{
		if (20348 - 427116 != -406767)
		{
		}
		for (;;)
		{
			if (this.LE1cuhfPZpq == null)
			{
				if (5621 - 592846 != -587224)
				{
					break;
				}
			}
			else
			{
				eGameState mGameState = Game.mGameState;
				if (238325 - 339160 == -100835)
				{
					if (mGameState == eGameState.Init)
					{
						if (245380 - 533263 == -287883)
						{
							AudioListener.volume = 0.1f * (float)Game.volume;
							if (39443 - 489190 == -449747)
							{
								break;
							}
						}
					}
					else if (mGameState == eGameState.Setup)
					{
						if (32517 - 298593 != -266075)
						{
							break;
						}
					}
					else if (mGameState == eGameState.Ready)
					{
						if (189311 - 165661 != 23651)
						{
							break;
						}
					}
					else if (mGameState == eGameState.Start)
					{
						if (168481 - 263922 != -95440)
						{
							break;
						}
					}
					else if (mGameState == eGameState.Normal)
					{
						if (201381 - 35641 != 165741)
						{
							if (Game.music != 0)
							{
								if (241942 - 389540 != -147598)
								{
									continue;
								}
								if (!this.audio.isPlaying)
								{
									if (193931 - 457332 == -263400)
									{
										continue;
									}
									this.audio.Play();
									if (78570 - 35464 != 43106)
									{
										continue;
									}
								}
							}
							if (Time.time - Game.mGameTime < (float)2)
							{
								if (95407 - 182002 != -86595)
								{
									continue;
								}
								this.audio.volume = Mathf.Lerp((float)0, 0.1f * (float)Game.music, 0.5f * (Time.time - Game.mGameTime));
								if (245108 - 489976 == -244867)
								{
									continue;
								}
							}
							else
							{
								this.audio.volume = 0.1f * (float)Game.music;
								if (37459 - 322966 != -285507)
								{
									continue;
								}
							}
							if (Time.time <= this.GLscuzr3EK5)
							{
								break;
							}
							if (39504 - 315651 != -276146)
							{
								Game.mGameMana++;
								if (46887 - 390028 != -343140)
								{
									this.GLscuzr3EK5 = Time.time + (float)12;
									if (252291 - 546946 != -294654)
									{
										break;
									}
								}
							}
						}
					}
					else if (mGameState == eGameState.Hold)
					{
						if (75589 - 509807 != -434217)
						{
							break;
						}
					}
					else if (mGameState == eGameState.AllHold)
					{
						if (225476 - 312733 == -87257)
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
						if (164555 - 31788 != 132768)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x060087A3 RID: 34723 RVA: 0x010D4F98 File Offset: 0x010D3198
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void OnGUI()
	{
		if (287528 - 389470 != -101942)
		{
		}
		for (;;)
		{
			if (!this.hSxcy5gFWUE)
			{
				if (133883 - 211719 == -77836)
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
				if (240081 - 160804 == 79277)
				{
					if (Time.time - Game.mGameTime >= (float)2)
					{
						break;
					}
					if (24004 - 104502 == -80498)
					{
						GUI.matrix = Matrix4x4.TRS(Vector3.zero, Quaternion.identity, new Vector3((float)Screen.height / 1024f, (float)Screen.height / 1024f, (float)1));
						if (186955 - 197668 == -10713)
						{
							float num = (float)(1024 * Screen.width / Screen.height);
							if (57739 - 547325 == -489586)
							{
								GUI.depth = 1;
								if (269819 - 590971 != -321151)
								{
									float num2 = Mathf.SmoothStep((float)1, 1.2f, Time.time - Game.mGameTime);
									if (205766 - 415375 != -209608)
									{
										float a = Mathf.SmoothStep((float)0, (float)1, Mathf.PingPong(Time.time - Game.mGameTime, (float)1));
										if (149617 - 231582 != -81964)
										{
											Color color = GUI.color;
											if (18523 - 45800 != -27276)
											{
												color.a = a;
												if (81849 - 149511 != -67661 && 26663 - 338069 != -311405)
												{
													GUI.color = color;
													if (13768 - 64094 == -50326)
													{
														if (7423 - 569965 != -562541)
														{
															GUI.DrawTexture(new Rect(0.5f * num - (float)350 * num2, (float)450 - (float)78 * num2, (float)700 * num2, (float)157 * num2), this.hSxcy5gFWUE);
															if (14671 - 391676 != -377004)
															{
																float a2 = 1f;
																if (227750 - 546972 != -319221)
																{
																	Color color2 = GUI.color;
																	if (6049 - 3588 == 2461)
																	{
																		float num3 = color2.a = a2;
																		if (162400 - 460620 == -298220)
																		{
																			if (204069 - 305292 == -101223)
																			{
																				GUI.color = color2;
																				if (178080 - 88170 != 89911)
																				{
																					if (38330 - 11222 == 27108)
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

	// Token: 0x060087A4 RID: 34724 RVA: 0x010D5318 File Offset: 0x010D3518
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator onGameEvent(Hashtable data)
	{
		return new M702_EasternWorldDivide1.$onGameEvent$40099(data, this).GetEnumerator();
	}

	// Token: 0x060087A5 RID: 34725 RVA: 0x010D5328 File Offset: 0x010D3528
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator onGameComplete(Hashtable data)
	{
		return new M702_EasternWorldDivide1.$onGameComplete$40109(data, this).GetEnumerator();
	}

	// Token: 0x060087A6 RID: 34726 RVA: 0x010D5338 File Offset: 0x010D3538
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void createRandomSpawn(string nType, int nNum)
	{
		if (296827 - 525421 != -228594)
		{
		}
		for (;;)
		{
			GameObject gameObject = GameObject.Find("SpawnPoint" + nNum);
			if (195999 - 30663 == 165336)
			{
				if (!gameObject)
				{
					break;
				}
				if (51699 - 336185 == -284486)
				{
					Vector3 randomSpawnPos = global::Math.getRandomSpawnPos(gameObject.transform.position, 2);
					if (125784 - 397140 != -271355)
					{
						if (randomSpawnPos != Vector3.zero)
						{
							if (219500 - 226722 == -7222)
							{
								this.createActor(nType, 6, randomSpawnPos, gameObject.transform.forward);
								if (183412 - 195371 != -11958)
								{
									break;
								}
							}
						}
						else
						{
							this.createActor(nType, 6, gameObject.transform.position, gameObject.transform.forward);
							if (220973 - 133502 == 87471)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x060087A7 RID: 34727 RVA: 0x010D5488 File Offset: 0x010D3688
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator TalkToRedPanda()
	{
		return new M702_EasternWorldDivide1.$TalkToRedPanda$40119(this).GetEnumerator();
	}

	// Token: 0x060087A8 RID: 34728 RVA: 0x010D5498 File Offset: 0x010D3698
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onExit()
	{
		if (138802 - 208603 != -69801)
		{
		}
		while (this.T9icycKGZXX < 1)
		{
			if (241066 - 124932 == 116134)
			{
				this.T9icycKGZXX = 1;
				if (233978 - 384755 != -150776)
				{
					Game.sendMissionEvent(7021, 1);
					if (109650 - 490838 == -381188)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x060087A9 RID: 34729 RVA: 0x010D553C File Offset: 0x010D373C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void UseLifeAltar(int mVar)
	{
		if (28276 - 66398 != -38122)
		{
		}
		for (;;)
		{
			GameObject mPlayer = Game.mPlayer;
			if (163395 - 361711 == -198316)
			{
				CharacterControl characterControl = null;
				if (50916 - 494932 != -444015)
				{
					if (mPlayer)
					{
						if (236312 - 273941 != -37629)
						{
							continue;
						}
						characterControl = (CharacterControl)mPlayer.GetComponent(typeof(CharacterControl));
						if (252052 - 88523 != 163529)
						{
							continue;
						}
					}
					if (!characterControl)
					{
						if (254836 - 383403 != -128566)
						{
							break;
						}
					}
					else if (characterControl.isTransform)
					{
						if (292502 - 335876 == -43374)
						{
							this.SendMessage("newGameMessage", "Cannot change while transformed");
							if (226527 - 545678 == -319151)
							{
								break;
							}
						}
					}
					else
					{
						if (characterControl.actionState != "standby")
						{
							if (155487 - 96091 == 59397)
							{
								continue;
							}
							if (characterControl.actionState != "run")
							{
								if (193428 - 200594 == -7165)
								{
									continue;
								}
								if (characterControl.actionState != "emotion")
								{
									if (97910 - 332838 != -234928)
									{
										continue;
									}
									this.SendMessage("newGameMessage", "Character not standby");
									if (203459 - 360283 != -156823)
									{
										break;
									}
									continue;
								}
							}
						}
						if (Time.time < characterControl.actionTime + 1f)
						{
							if (3661 - 216238 != -212576)
							{
								this.SendMessage("newGameMessage", "Character not action time out.");
								if (91534 - 418431 != -326896)
								{
									break;
								}
							}
						}
						else
						{
							GameGui gameGui = (GameGui)this.GetComponent(typeof(GameGui));
							if (86789 - 537067 == -450278)
							{
								ChangeGui changeGui = (ChangeGui)this.GetComponent(typeof(ChangeGui));
								if (103086 - 243149 != -140062)
								{
									if (!changeGui)
									{
										break;
									}
									if (69952 - 489145 == -419193)
									{
										if (changeGui.mState != eChangeState.Init)
										{
											if (108775 - 555819 == -447043)
											{
												continue;
											}
											if (changeGui.mState != eChangeState.Disabled)
											{
												break;
											}
											if (288788 - 134915 != 153873)
											{
												continue;
											}
										}
										Game.mGameState = eGameState.Hold;
										if (76932 - 451041 == -374109)
										{
											gameGui.close();
											if (254981 - 398185 != -143203)
											{
												changeGui.enabled = true;
												if (12807 - 298500 == -285693)
												{
													GameObject gameObject = GameObject.Find("LifeAltar");
													if (259461 - 434660 == -175199)
													{
														if (!gameObject)
														{
															break;
														}
														if (6720 - 357074 != -350353)
														{
															if (!mPlayer)
															{
																break;
															}
															if (50731 - 485276 == -434545)
															{
																Debug.Log("UseLifeAltar");
																if (147121 - 9210 == 137911)
																{
																	mPlayer.SendMessage("turnToPos", gameObject.transform.position);
																	if (267 - 84969 == -84702)
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

	// Token: 0x060087AA RID: 34730 RVA: 0x010D599C File Offset: 0x010D3B9C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void InitGame()
	{
		if (265641 - 249990 != 15651)
		{
		}
		for (;;)
		{
			Debug.Log("Initializing Mission");
			if (123698 - 588417 != -464718)
			{
				Time.timeScale = 1f;
				if (281911 - 549496 == -267585)
				{
					this.hSxcy5gFWUE = (Texture)Resources.Load("GameGui/Title/start", typeof(Texture));
					if (42910 - 188581 != -145670)
					{
						Hashtable customOpParameters = new Hashtable();
						if (70304 - 559203 != -488898)
						{
							this.LE1cuhfPZpq.OpCustom(52, customOpParameters, true);
							if (261972 - 54871 != 207102)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x060087AB RID: 34731 RVA: 0x010D5AA0 File Offset: 0x010D3CA0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onInitGame(Hashtable data)
	{
		if (225356 - 455394 != -230038)
		{
		}
		for (;;)
		{
			Debug.Log("Loading data...");
			if (74845 - 339624 != -264778)
			{
				if (Game.mGameState >= eGameState.Setup)
				{
					break;
				}
				if (190003 - 260013 != -70009)
				{
					Game.mGameState = eGameState.Setup;
					if (229627 - 280753 == -51126)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x060087AC RID: 34732 RVA: 0x010D5B44 File Offset: 0x010D3D44
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onGameSetup(Hashtable data)
	{
		if (141251 - 112312 != 28940)
		{
		}
		for (;;)
		{
			int num = RuntimeServices.UnboxInt32(data[43]);
			if (92145 - 265868 != -173722)
			{
				if (num == PlayerData.UID)
				{
					if (123637 - 104713 != 18925)
					{
						this.SetupActors();
						if (7811 - 241212 != -233400)
						{
							break;
						}
					}
				}
				else
				{
					this.ClearActors();
					if (243568 - 365396 != -121827)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x060087AD RID: 34733 RVA: 0x010D5C14 File Offset: 0x010D3E14
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void SetupActors()
	{
		if (60741 - 395119 != -334378)
		{
		}
		for (;;)
		{
			IL_1D3:
			Debug.Log("Creating Actors");
			if (269353 - 296882 == -27529)
			{
				CharacterControl[] array = (CharacterControl[])UnityEngine.Object.FindObjectsOfType(typeof(CharacterControl));
				if (61387 - 59755 != 1633)
				{
					if (Extensions.get_length(array) > 0)
					{
						if (81120 - 233979 != -152858)
						{
							int i = 0;
							if (175548 - 56049 == 119499)
							{
								CharacterControl[] array2 = array;
								if (213916 - 173644 == 40272)
								{
									int length = array2.Length;
									if (61503 - 503800 != -442296)
									{
										while (i < length)
										{
											if (!array2[i].isChild)
											{
												if (207931 - 215568 == -7636)
												{
													goto IL_1D3;
												}
												string type = array2[i].Type;
												if (27886 - 515897 == -488010)
												{
													goto IL_1D3;
												}
												if (type == "Cactun")
												{
													goto IL_105;
												}
												if (65174 - 297321 == -232146)
												{
													goto IL_1D3;
												}
												if (type == "BanditBug1")
												{
													goto IL_105;
												}
												if (173241 - 185803 == -12561)
												{
													goto IL_1D3;
												}
												if (type == "BanditBug2")
												{
													goto IL_105;
												}
												if (9622 - 118390 != -108768)
												{
													goto IL_1D3;
												}
												if (type == "BanditBug3")
												{
													goto IL_105;
												}
												if (263941 - 208821 == 55121)
												{
													goto IL_1D3;
												}
												if (type == "LionBug_y")
												{
													goto IL_105;
												}
												if (276822 - 511790 == -234967)
												{
													goto IL_1D3;
												}
												if (type == "StingBug2_y")
												{
													goto IL_105;
												}
												if (188448 - 322017 == -133568)
												{
													goto IL_1D3;
												}
												if (type == "CamBot")
												{
													if (206073 - 281155 != -75082)
													{
														goto IL_1D3;
													}
													goto IL_105;
												}
												IL_352:
												UnityEngine.Object.Destroy(array2[i].gameObject);
												if (61335 - 580351 != -519016)
												{
													goto IL_1D3;
												}
												this.jMRcy6GlDtF++;
												if (33893 - 371345 != -337451)
												{
													goto IL_2DC;
												}
												goto IL_1D3;
												IL_105:
												this.createActor(array2[i].Type, array2[i].gameObject.layer - 7, array2[i].transform.position, array2[i].transform.forward);
												if (64739 - 192697 != -127958)
												{
													goto IL_1D3;
												}
												goto IL_352;
											}
											IL_2DC:
											i++;
											if (78862 - 147229 != -68367)
											{
												goto IL_1D3;
											}
										}
										if (105578 - 162078 != -56499)
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
						if (30102 - 592721 == -562619)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x060087AE RID: 34734 RVA: 0x010D5FAC File Offset: 0x010D41AC
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ClearActors()
	{
		if (177658 - 528415 != -350757)
		{
		}
		for (;;)
		{
			IL_1A:
			CharacterControl[] array = (CharacterControl[])UnityEngine.Object.FindObjectsOfType(typeof(CharacterControl));
			if (250980 - 339692 != -88711)
			{
				int i = 0;
				if (116679 - 547369 == -430690)
				{
					CharacterControl[] array2 = array;
					if (290187 - 67658 != 222530)
					{
						int length = array2.Length;
						if (273635 - 66466 == 207169)
						{
							while (i < length)
							{
								UnityEngine.Object.Destroy(array2[i].gameObject);
								if (224210 - 195185 != 29025)
								{
									goto IL_1A;
								}
								i++;
								if (220771 - 359865 != -139094)
								{
									goto IL_1A;
								}
							}
							if (291313 - 240213 == 51100)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x060087AF RID: 34735 RVA: 0x010D60DC File Offset: 0x010D42DC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onGameReadyEvent(Hashtable data)
	{
		if (292265 - 15824 != 276442)
		{
		}
		for (;;)
		{
			Debug.Log("Game Ready");
			if (257635 - 41678 == 215957)
			{
				Game.mGameState = eGameState.Ready;
				if (91559 - 223897 != -132337)
				{
					int playerSlot = Game.getPlayerSlot(PlayerData.UID);
					if (162885 - 487191 != -324305)
					{
						if (217168 - 459444 == -242276)
						{
							GameObject gameObject = null;
							if (149196 - 184274 == -35078)
							{
								if (playerSlot < 1)
								{
									goto IL_249;
								}
								if (231950 - 146181 != 85769)
								{
									continue;
								}
								if (playerSlot > 6)
								{
									goto IL_249;
								}
								if (168598 - 132917 != 35681)
								{
									continue;
								}
								GameObject gameObject2 = GameObject.Find("StartPoint" + playerSlot);
								if (85025 - 113551 != -28526)
								{
									continue;
								}
								gameObject = GameObject.Find("StartCamera" + playerSlot);
								if (243576 - 576884 != -333308)
								{
									continue;
								}
								IL_26E:
								if (gameObject2)
								{
									if (160725 - 412465 != -251740)
									{
										continue;
									}
									Vector3 spawnPos = global::Math.getSpawnPos(gameObject2.transform.position);
									if (152777 - 117531 == 35247)
									{
										continue;
									}
									if (spawnPos != Vector3.zero)
									{
										if (104367 - 111308 == -6940)
										{
											continue;
										}
										this.CreatePlayer(CharacterData.current.CID, 1, spawnPos, gameObject2.transform.forward);
										if (82913 - 238049 == -155135)
										{
											continue;
										}
									}
									else
									{
										this.CreatePlayer(CharacterData.current.CID, 1, gameObject2.transform.position, gameObject2.transform.forward);
										if (214931 - 578868 != -363937)
										{
											continue;
										}
									}
								}
								if (!gameObject)
								{
									break;
								}
								if (84299 - 423401 == -339101)
								{
									continue;
								}
								this.transform.position = gameObject.transform.position;
								if (21938 - 110272 != -88334)
								{
									continue;
								}
								this.transform.rotation = gameObject.transform.rotation;
								if (230926 - 51250 != 179676)
								{
									continue;
								}
								break;
								IL_249:
								gameObject2 = GameObject.Find("StartPoint1");
								if (115323 - 294360 != -179036)
								{
									goto IL_26E;
								}
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x060087B0 RID: 34736 RVA: 0x010D6400 File Offset: 0x010D4600
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator StartGame()
	{
		return new M702_EasternWorldDivide1.$StartGame$40130(this).GetEnumerator();
	}

	// Token: 0x060087B1 RID: 34737 RVA: 0x010D6410 File Offset: 0x010D4610
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onStartGame()
	{
	}

	// Token: 0x060087B2 RID: 34738 RVA: 0x010D6414 File Offset: 0x010D4614
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void createActor(string nType, int nTeam, Vector3 nPos, Vector3 nDir)
	{
		if (69524 - 242171 != -172647)
		{
		}
		for (;;)
		{
			if (Game.mGameState > eGameState.AllHold)
			{
				if (1174 - 388338 != -387163)
				{
					break;
				}
			}
			else
			{
				Hashtable hashtable = new Hashtable();
				if (249241 - 489691 != -240449)
				{
					hashtable.Add(43, PlayerData.UID);
					if (186640 - 130703 == 55937)
					{
						hashtable.Add(73, nType);
						if (164886 - 113452 == 51434)
						{
							hashtable.Add(75, PhotonClient.cInt16(nTeam));
							if (128826 - 150120 != -21293)
							{
								hashtable.Add(122, PhotonClient.cInt16(Mathf.RoundToInt(nPos.x * (float)50)));
								if (58396 - 95071 != -36674)
								{
									hashtable.Add(123, PhotonClient.cInt16(Mathf.RoundToInt(nPos.y * (float)50)));
									if (96944 - 463066 != -366121)
									{
										hashtable.Add(124, PhotonClient.cInt16(Mathf.RoundToInt(nPos.z * (float)50)));
										if (65607 - 399551 != -333943)
										{
											hashtable.Add(126, PhotonClient.cInt16(Mathf.RoundToInt(nDir.x * (float)200)));
											if (294656 - 104331 == 190325)
											{
												hashtable.Add(127, PhotonClient.cInt16(Mathf.RoundToInt(nDir.y * (float)200)));
												if (159215 - 581545 != -422329)
												{
													hashtable.Add(128, PhotonClient.cInt16(Mathf.RoundToInt(nDir.z * (float)200)));
													if (138038 - 64525 == 73513)
													{
														this.LE1cuhfPZpq.OpCustom(63, hashtable, true);
														if (70266 - 57404 == 12862)
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

	// Token: 0x060087B3 RID: 34739 RVA: 0x010D66F8 File Offset: 0x010D48F8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onCreateActor(Hashtable data)
	{
		if (137739 - 572717 != -434978)
		{
		}
		for (;;)
		{
			if (Game.mGameState > eGameState.AllHold)
			{
				if (132079 - 171485 == -39406)
				{
					break;
				}
			}
			else
			{
				GameObject gameObject = Game.createActor(data);
				if (274632 - 119133 != 155500)
				{
					if (Game.mGameState == eGameState.Setup)
					{
						if (98877 - 256433 != -157555)
						{
							if (this.jMRcy6GlDtF <= 0)
							{
								break;
							}
							if (271325 - 417362 == -146037)
							{
								this.jMRcy6GlDtF--;
								if (159494 - 109501 == 49993)
								{
									if (this.jMRcy6GlDtF != 0)
									{
										break;
									}
									if (195542 - 596978 != -401435)
									{
										Game.setGameState(eGameState.Ready);
										if (238902 - 327435 != -88532)
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
						if (272055 - 478069 == -206014)
						{
							gameObject.SendMessage("createSpecialEffect", 1);
							if (133942 - 375182 == -241240)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x060087B4 RID: 34740 RVA: 0x010D6888 File Offset: 0x010D4A88
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onActorKo(GameObject nActor)
	{
		if (Game.mGameState > eGameState.AllHold)
		{
		}
	}

	// Token: 0x060087B5 RID: 34741 RVA: 0x010D689C File Offset: 0x010D4A9C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onActorDead(GameObject nActor)
	{
		if (161347 - 383713 != -222366)
		{
		}
		for (;;)
		{
			if (Game.mGameState > eGameState.AllHold)
			{
				if (63824 - 472297 != -408472)
				{
					break;
				}
			}
			else
			{
				CharacterControl characterControl = (CharacterControl)nActor.GetComponent(typeof(CharacterControl));
				if (110369 - 517700 == -407331)
				{
					if (!characterControl)
					{
						break;
					}
					if (57935 - 62656 != -4720)
					{
						if (characterControl.isTransform)
						{
							break;
						}
						if (264805 - 188683 == 76122)
						{
							if (characterControl.isSummon)
							{
								break;
							}
							if (108037 - 579 == 107458)
							{
								string type = characterControl.Type;
								if (74337 - 549957 != -475619)
								{
									if (type == "StingBug2_y")
									{
										if (149945 - 132190 != 17756)
										{
											Game.sendMissionEvent(7022, 0);
											if (250656 - 122113 == 128543)
											{
												break;
											}
										}
									}
									else if (type == "LionBug_y")
									{
										if (123252 - 360581 != -237328)
										{
											Game.sendMissionEvent(7023, 0);
											if (107103 - 197788 != -90684)
											{
												break;
											}
										}
									}
									else if (type == "BanditBug1")
									{
										if (48952 - 215336 != -166383)
										{
											Game.sendMissionEvent(7024, 1);
											if (100098 - 194866 != -94767)
											{
												break;
											}
										}
									}
									else if (type == "BanditBug2")
									{
										if (951 - 6757 != -5805)
										{
											Game.sendMissionEvent(7024, 2);
											if (179971 - 542531 != -362559)
											{
												break;
											}
										}
									}
									else if (type == "BanditBug3")
									{
										if (190293 - 376766 == -186473)
										{
											Game.sendMissionEvent(7024, 3);
											if (128709 - 516607 == -387898)
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
										if (273272 - 105307 != 167966)
										{
											Game.sendMissionEvent(7025, 0);
											if (109324 - 145593 == -36269)
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

	// Token: 0x060087B6 RID: 34742 RVA: 0x010D6BB8 File Offset: 0x010D4DB8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void CreatePlayer(int CID, int team, Vector3 pos, Vector3 dir)
	{
		if (89279 - 200559 != -111280)
		{
		}
		for (;;)
		{
			Hashtable hashtable = new Hashtable();
			if (153124 - 424459 != -271334)
			{
				hashtable.Add(71, CID);
				if (125660 - 441954 != -316293)
				{
					hashtable.Add(75, PhotonClient.cInt16(team));
					if (63314 - 311097 == -247783)
					{
						hashtable.Add(122, PhotonClient.cInt16(Mathf.RoundToInt(pos.x * (float)50)));
						if (133157 - 291124 == -157967)
						{
							hashtable.Add(123, PhotonClient.cInt16(Mathf.RoundToInt(pos.y * (float)50)));
							if (14123 - 281603 != -267479)
							{
								hashtable.Add(124, PhotonClient.cInt16(Mathf.RoundToInt(pos.z * (float)50)));
								if (4438 - 236347 == -231909)
								{
									hashtable.Add(126, PhotonClient.cInt16(Mathf.RoundToInt(dir.x * (float)200)));
									if (124071 - 91048 != 33024)
									{
										hashtable.Add(127, PhotonClient.cInt16(Mathf.RoundToInt(dir.y * (float)200)));
										if (194513 - 121540 == 72973)
										{
											hashtable.Add(128, PhotonClient.cInt16(Mathf.RoundToInt(dir.z * (float)200)));
											if (145698 - 133480 == 12218)
											{
												this.LE1cuhfPZpq.OpCustom(61, hashtable, true);
												if (69221 - 536331 == -467110)
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

	// Token: 0x060087B7 RID: 34743 RVA: 0x010D6E44 File Offset: 0x010D5044
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onCreatePlayer(Hashtable data)
	{
		if (190532 - 162970 != 27563)
		{
		}
		for (;;)
		{
			GameObject gameObject = Game.createPlayer(data);
			if (73391 - 112156 != -38764)
			{
				if (!gameObject)
				{
					break;
				}
				if (112950 - 214875 != -101924)
				{
					PlayerCameraControl playerCameraControl = (PlayerCameraControl)this.GetComponent(typeof(PlayerCameraControl));
					if (183438 - 562493 == -379055)
					{
						playerCameraControl.target = gameObject;
						if (49379 - 570991 == -521612)
						{
							this.StartCoroutine_Auto(this.StartGame());
							if (177577 - 388459 == -210882)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x060087B8 RID: 34744 RVA: 0x010D6F3C File Offset: 0x010D513C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onCreatePeer(Hashtable data)
	{
		if (30910 - 479219 != -448309)
		{
		}
		for (;;)
		{
			Game.createPeer(data);
			if (165817 - 347678 != -181860)
			{
				GameGui gameGui = (GameGui)this.GetComponent(typeof(GameGui));
				if (125012 - 70230 == 54782)
				{
					gameGui.ResetTeamBar();
					if (209273 - 418713 != -209439)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x060087B9 RID: 34745 RVA: 0x010D6FE8 File Offset: 0x010D51E8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator onDeadPlayer()
	{
		return new M702_EasternWorldDivide1.$onDeadPlayer$40134(this).GetEnumerator();
	}

	// Token: 0x060087BA RID: 34746 RVA: 0x010D6FF8 File Offset: 0x010D51F8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onRevivePlayer()
	{
		if (120279 - 276955 != -156676)
		{
		}
		for (;;)
		{
			Debug.Log("On Revive Player");
			if (41370 - 223687 != -182316)
			{
				this.MWlcuKYm1gD.target = Game.mPlayer;
				if (133098 - 146686 != -13587)
				{
					this.MWlcuKYm1gD.enabled = true;
					if (238985 - 87298 == 151687)
					{
						if (Game.mGameState != eGameState.Normal)
						{
							if (153081 - 113324 != 39757)
							{
								continue;
							}
							if (Game.mGameState != eGameState.Hold)
							{
								break;
							}
							if (91502 - 460752 != -369250)
							{
								continue;
							}
						}
						Game.mGameState = eGameState.Normal;
						if (240107 - 99978 != 140130)
						{
							GameGui gameGui = (GameGui)this.GetComponent(typeof(GameGui));
							if (48280 - 465757 != -417476)
							{
								if (!gameGui)
								{
									break;
								}
								if (115430 - 496871 == -381441)
								{
									gameGui.enabled = true;
									if (167379 - 555796 == -388417)
									{
										gameGui.closeDeadMenu();
										if (275054 - 450258 == -175204)
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

	// Token: 0x060087BB RID: 34747 RVA: 0x010D71A4 File Offset: 0x010D53A4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onPlayerRelease(GameObject mPlayer)
	{
		if (221640 - 545904 != -324263)
		{
		}
		for (;;)
		{
			Debug.Log("On Release Spirit");
			if (289528 - 212228 != 77301)
			{
				PlayerData.MissionWithdraw[MissionData.getMissionNumber(Game.mGameCode) - 1] = PlayerData.MissionWithdraw[MissionData.getMissionNumber(Game.mGameCode) - 1] + 1;
				if (164876 - 585566 == -420690)
				{
					this.StartCoroutine_Auto(this.ReturnToTown());
					if (128859 - 260452 == -131593)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x060087BC RID: 34748 RVA: 0x010D7268 File Offset: 0x010D5468
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onDestroyPlayer(Hashtable data)
	{
		if (RuntimeServices.EqualityOperator(data[81], PlayerData.UID))
		{
			Game.mGameState = eGameState.Ended;
		}
	}

	// Token: 0x060087BD RID: 34749 RVA: 0x010D7294 File Offset: 0x010D5494
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void ChangePlayer(int nCID)
	{
		if (154199 - 117032 != 37167)
		{
		}
		for (;;)
		{
			int v = Game.mPlayer.layer - 7;
			if (184193 - 423784 == -239591)
			{
				Vector3 position = Game.mPlayer.transform.position;
				if (74258 - 479399 == -405141)
				{
					Vector3 forward = Game.mPlayer.transform.forward;
					if (275506 - 88068 == 187438)
					{
						Hashtable hashtable = new Hashtable();
						if (242650 - 557286 == -314636)
						{
							hashtable.Add(43, PlayerData.UID);
							if (142090 - 472507 != -330416)
							{
								hashtable.Add(71, nCID);
								if (90331 - 125615 != -35283)
								{
									hashtable.Add(75, PhotonClient.cInt16(v));
									if (68982 - 518807 != -449824)
									{
										hashtable.Add(122, PhotonClient.cInt16(Mathf.RoundToInt(position.x * (float)50)));
										if (84530 - 372930 != -288399)
										{
											hashtable.Add(123, PhotonClient.cInt16(Mathf.RoundToInt(position.y * (float)50)));
											if (13847 - 196483 == -182636)
											{
												hashtable.Add(124, PhotonClient.cInt16(Mathf.RoundToInt(position.z * (float)50)));
												if (7750 - 324220 != -316469)
												{
													hashtable.Add(126, PhotonClient.cInt16(Mathf.RoundToInt(forward.x * (float)200)));
													if (229802 - 100274 != 129529)
													{
														hashtable.Add(127, PhotonClient.cInt16(Mathf.RoundToInt(forward.y * (float)200)));
														if (241227 - 453763 != -212535)
														{
															hashtable.Add(128, PhotonClient.cInt16(Mathf.RoundToInt(forward.z * (float)200)));
															if (240029 - 471201 == -231172)
															{
																PhotonClient.Connection.OpCustom(65, hashtable, true);
																if (292375 - 411185 == -118810)
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

	// Token: 0x060087BE RID: 34750 RVA: 0x010D75B4 File Offset: 0x010D57B4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator onChangePlayer(Hashtable data)
	{
		return new M702_EasternWorldDivide1.$onChangePlayer$40140(data, this).GetEnumerator();
	}

	// Token: 0x060087BF RID: 34751 RVA: 0x010D75C4 File Offset: 0x010D57C4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator ReturnToTown()
	{
		return new M702_EasternWorldDivide1.$ReturnToTown$40147(this).GetEnumerator();
	}

	// Token: 0x060087C0 RID: 34752 RVA: 0x010D75D4 File Offset: 0x010D57D4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator ReturnToGuild()
	{
		return new M702_EasternWorldDivide1.$ReturnToGuild$40152(this).GetEnumerator();
	}

	// Token: 0x060087C1 RID: 34753 RVA: 0x010D75E4 File Offset: 0x010D57E4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator ReturnToCamp()
	{
		return new M702_EasternWorldDivide1.$ReturnToCamp$40156(this).GetEnumerator();
	}

	// Token: 0x060087C2 RID: 34754 RVA: 0x010D75F4 File Offset: 0x010D57F4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void LeaveGame()
	{
		if (151417 - 271512 != -120095)
		{
		}
		for (;;)
		{
			Debug.Log("leaving guild");
			if (8374 - 101119 != -92744)
			{
				Hashtable hashtable = new Hashtable();
				if (253652 - 573374 == -319722)
				{
					hashtable.Add(43, PlayerData.UID);
					if (220103 - 585092 == -364989)
					{
						PhotonClient.Connection.OpCustom(54, hashtable, true);
						if (278989 - 466285 != -187295)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x060087C3 RID: 34755 RVA: 0x010D76CC File Offset: 0x010D58CC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onLeaveGame()
	{
		Debug.Log("onLeaveGame");
		this.JoinTown();
	}

	// Token: 0x060087C4 RID: 34756 RVA: 0x010D76E0 File Offset: 0x010D58E0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void JoinTown()
	{
		if (209545 - 48223 != 161322)
		{
		}
		for (;;)
		{
			Debug.Log("Joining Town");
			if (30390 - 501182 == -470792)
			{
				Hashtable hashtable = new Hashtable();
				if (230294 - 402929 != -172634)
				{
					if (Game.mNextGameCode == 30)
					{
						if (216629 - 209953 != 6676)
						{
							continue;
						}
						hashtable.Add(47, "NoGuild");
						if (153390 - 542536 != -389146)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 31)
					{
						if (288555 - 191901 == 96655)
						{
							continue;
						}
						hashtable.Add(47, "G" + GuildData.Name);
						if (246077 - 582955 == -336877)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 32)
					{
						if (280591 - 512194 != -231603)
						{
							continue;
						}
						hashtable.Add(47, "SnowCamp");
						if (293176 - 354428 != -61252)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 33)
					{
						if (131315 - 527184 == -395868)
						{
							continue;
						}
						hashtable.Add(47, "CrystalBeach");
						if (73187 - 141820 != -68633)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 34)
					{
						if (115853 - 592884 != -477031)
						{
							continue;
						}
						hashtable.Add(47, "ExcavationCamp");
						if (118967 - 532952 != -413985)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 35)
					{
						if (203147 - 561534 != -358387)
						{
							continue;
						}
						hashtable.Add(47, "UndergroundCamp");
						if (219515 - 467969 == -248453)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 36)
					{
						if (69859 - 35690 != 34169)
						{
							continue;
						}
						hashtable.Add(47, "ForestCamp");
						if (53569 - 565860 != -512291)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 51)
					{
						if (140949 - 540415 == -399465)
						{
							continue;
						}
						hashtable.Add(47, "MainStreet");
						if (159021 - 469967 == -310945)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 52)
					{
						if (130391 - 299580 != -169189)
						{
							continue;
						}
						hashtable.Add(47, "CentralSquare");
						if (104673 - 48504 != 56169)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 53)
					{
						if (246912 - 65293 != 181619)
						{
							continue;
						}
						hashtable.Add(47, "CityLibrary");
						if (145236 - 148861 != -3625)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 54)
					{
						if (56315 - 115069 != -58754)
						{
							continue;
						}
						hashtable.Add(47, "LightPark");
						if (215420 - 573095 == -357674)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 55)
					{
						if (126184 - 166665 == -40480)
						{
							continue;
						}
						hashtable.Add(47, "LightPalace");
						if (288133 - 575840 != -287707)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 56)
					{
						if (193948 - 404214 == -210265)
						{
							continue;
						}
						hashtable.Add(47, "PlainColosseum");
						if (260973 - 296784 != -35811)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 57)
					{
						if (114655 - 98763 == 15893)
						{
							continue;
						}
						hashtable.Add(47, "LightTheater");
						if (76712 - 354172 == -277459)
						{
							continue;
						}
					}
					hashtable.Add(21, PhotonClient.cInt16(Mathf.Clamp(PlayerPrefs.GetInt("channel", 0), 0, 99)));
					if (180836 - 250156 == -69320)
					{
						this.LE1cuhfPZpq.OpCustom(42, hashtable, true);
						if (56507 - 102056 != -45548)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x060087C5 RID: 34757 RVA: 0x010D7C94 File Offset: 0x010D5E94
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onJoinTown()
	{
		Game.mGameStage = 0;
		Game.loadNextLevel();
	}

	// Token: 0x060087C6 RID: 34758 RVA: 0x010D7CA4 File Offset: 0x010D5EA4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x060087C7 RID: 34759 RVA: 0x010D7CA8 File Offset: 0x010D5EA8
	internal static bool nW4jREVpZtPLMphYI9P3()
	{
		return true;
	}

	// Token: 0x060087C8 RID: 34760 RVA: 0x010D7CAC File Offset: 0x010D5EAC
	internal static bool A5R9EXVpCMTttaec4W4y()
	{
		return false;
	}

	// Token: 0x04008345 RID: 33605
	private LitePeer LE1cuhfPZpq;

	// Token: 0x04008346 RID: 33606
	private PlayerCameraControl MWlcuKYm1gD;

	// Token: 0x04008347 RID: 33607
	private float GLscuzr3EK5;

	// Token: 0x04008348 RID: 33608
	private Texture hSxcy5gFWUE;

	// Token: 0x04008349 RID: 33609
	private int T9icycKGZXX;

	// Token: 0x0400834A RID: 33610
	private int Oflcynm3Uts;

	// Token: 0x0400834B RID: 33611
	private int ff5cyQOdN0c;

	// Token: 0x0400834C RID: 33612
	private int GQfcyebLyqX;

	// Token: 0x0400834D RID: 33613
	private int aHBcyIkFm10;

	// Token: 0x0400834E RID: 33614
	private int rorcyJ0Qq7f;

	// Token: 0x0400834F RID: 33615
	private int jMRcy6GlDtF;

	// Token: 0x020016D2 RID: 5842
	[CompilerGenerated]
	[Serializable]
	internal sealed class $onGameEvent$40099 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x060087C9 RID: 34761 RVA: 0x010D7CB0 File Offset: 0x010D5EB0
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $onGameEvent$40099(Hashtable data, M702_EasternWorldDivide1 self_)
		{
			if (130874 - 423236 != -292362)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (125722 - 249172 != -123449)
				{
					base..ctor();
					if (167773 - 393527 != -225753)
					{
						this.$data$40107 = data;
						if (244421 - 23835 != 220587)
						{
							this.$self_$40108 = self_;
							if (209324 - 574466 == -365142)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x060087CA RID: 34762 RVA: 0x010D7D6C File Offset: 0x010D5F6C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M702_EasternWorldDivide1.$onGameEvent$40099.$(this.$data$40107, this.$self_$40108);
		}

		// Token: 0x060087CB RID: 34763 RVA: 0x010D7D80 File Offset: 0x010D5F80
		internal static bool qSr8fvVpL8jTC1exEJD1()
		{
			return true;
		}

		// Token: 0x060087CC RID: 34764 RVA: 0x010D7D84 File Offset: 0x010D5F84
		internal static bool i605ipVpOq3oO8pJ8d6F()
		{
			return false;
		}

		// Token: 0x04008350 RID: 33616
		internal Hashtable $data$40107;

		// Token: 0x04008351 RID: 33617
		internal M702_EasternWorldDivide1 $self_$40108;

		// Token: 0x020016D3 RID: 5843
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x060087CD RID: 34765 RVA: 0x010D7D88 File Offset: 0x010D5F88
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Hashtable data, M702_EasternWorldDivide1 self_)
			{
				if (94124 - 34477 != 59648)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (2338 - 523300 != -520961)
					{
						base..ctor();
						if (185351 - 244978 != -59626)
						{
							this.$data$40105 = data;
							if (292835 - 118091 == 174744)
							{
								this.$self_$40106 = self_;
								if (203538 - 155508 != 48031)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x060087CE RID: 34766 RVA: 0x010D7E44 File Offset: 0x010D6044
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (66496 - 567638 != -501142)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_6AC;
					case 2:
						Game.mGameStage = 2;
						if (141218 - 468205 != -326987)
						{
							continue;
						}
						Application.LoadLevel("M702_EasternWorldDivide2");
						if (211243 - 450758 != -239515)
						{
							continue;
						}
						goto IL_40;
					default:
						if (42404 - 560964 != -518560)
						{
							continue;
						}
						break;
					}
					if (Game.mGameState > eGameState.AllHold)
					{
						if (297889 - 378046 != -80157)
						{
							continue;
						}
						goto IL_66D;
					}
					else
					{
						this.$returnCode$40100 = RuntimeServices.UnboxInt32(this.$data$40105[141]);
						if (17346 - 243227 != -225881)
						{
							continue;
						}
						this.$returnValue$40101 = RuntimeServices.UnboxInt32(this.$data$40105[145]);
						if (162706 - 559157 != -396451)
						{
							continue;
						}
						this.$ownerID$40102 = RuntimeServices.UnboxInt32(this.$data$40105[43]);
						if (66353 - 28697 != 37656)
						{
							continue;
						}
						this.$$switch$7098$40103 = this.$returnCode$40100;
						if (241485 - 34149 == 207337)
						{
							continue;
						}
						if (this.$$switch$7098$40103 == 7021)
						{
							if (85279 - 32447 != 52832)
							{
								continue;
							}
						}
						else if (this.$$switch$7098$40103 == -7021)
						{
							if (207025 - 494321 != -287296)
							{
								continue;
							}
							if (this.$returnValue$40101 == 1)
							{
								if (63875 - 478229 == -414353)
								{
									continue;
								}
								if (this.$self_$40106.T9icycKGZXX < 2)
								{
									if (254764 - 526598 == -271833)
									{
										continue;
									}
									this.$self_$40106.T9icycKGZXX = 2;
									if (92981 - 391100 == -298118)
									{
										continue;
									}
									Game.mGameState = eGameState.AllHold;
									if (29359 - 355353 == -325993)
									{
										continue;
									}
									this.$mGameGui$40104 = (GameGui)this.$self_$40106.GetComponent(typeof(GameGui));
									if (226438 - 425695 != -199257)
									{
										continue;
									}
									this.$mGameGui$40104.close();
									if (55635 - 146836 != -91201)
									{
										continue;
									}
									Game.savePlayer();
									if (84604 - 395605 != -311001)
									{
										continue;
									}
									this.$self_$40106.SendMessage("fadeOut");
									if (291984 - 75893 != 216091)
									{
										continue;
									}
									break;
								}
							}
						}
						else if (this.$$switch$7098$40103 == 7022)
						{
							if (206975 - 45513 == 161463)
							{
								continue;
							}
							this.$self_$40106.Oflcynm3Uts = this.$self_$40106.Oflcynm3Uts + 1;
							if (77879 - 1705 == 76175)
							{
								continue;
							}
							if (this.$self_$40106.Oflcynm3Uts >= 3)
							{
								if (83565 - 404391 == -320825)
								{
									continue;
								}
								if (this.$ownerID$40102 == PlayerData.UID)
								{
									if (179511 - 390791 == -211279)
									{
										continue;
									}
									this.$self_$40106.createRandomSpawn("StingBug2_y", UnityEngine.Random.Range(1, 7));
									if (99887 - 436199 == -336311)
									{
										continue;
									}
								}
							}
						}
						else if (this.$$switch$7098$40103 == 7023)
						{
							if (235260 - 288599 != -53339)
							{
								continue;
							}
							this.$self_$40106.ff5cyQOdN0c = this.$self_$40106.ff5cyQOdN0c + 1;
							if (55236 - 555186 == -499949)
							{
								continue;
							}
							if (this.$self_$40106.ff5cyQOdN0c >= 2)
							{
								if (230264 - 599241 != -368977)
								{
									continue;
								}
								if (this.$ownerID$40102 == PlayerData.UID)
								{
									if (283694 - 467476 == -183781)
									{
										continue;
									}
									this.$self_$40106.createRandomSpawn("LionBug_y", UnityEngine.Random.Range(1, 7));
									if (93475 - 42630 == 50846)
									{
										continue;
									}
								}
							}
						}
						else if (this.$$switch$7098$40103 == 7024)
						{
							if (93604 - 78016 == 15589)
							{
								continue;
							}
							this.$self_$40106.GQfcyebLyqX = this.$self_$40106.GQfcyebLyqX + 1;
							if (243913 - 371278 != -127365)
							{
								continue;
							}
						}
						else if (this.$$switch$7098$40103 == 7025)
						{
							if (291144 - 124224 != 166920)
							{
								continue;
							}
						}
						else if (this.$$switch$7098$40103 == -7025)
						{
							if (270984 - 348753 != -77769)
							{
								continue;
							}
							this.$self_$40106.aHBcyIkFm10 = this.$returnValue$40101;
							if (165848 - 300538 != -134690)
							{
								continue;
							}
							this.$self_$40106.SendMessage("newGameMessage", "Special Objective: CamBot captured: " + this.$self_$40106.aHBcyIkFm10 + "/12");
							if (162453 - 129680 == 32774)
							{
								continue;
							}
							Chat.SubmitChat("none", "Special Objective: CamBot captured: " + this.$self_$40106.aHBcyIkFm10 + "/12", eChatType.system, eChatMode.system);
							if (143493 - 575884 == -432390)
							{
								continue;
							}
						}
					}
					IL_5BC:
					this.YieldDefault(1);
					if (194017 - 176191 != 17827)
					{
						goto Block_46;
					}
					continue;
					IL_40:
					goto IL_5BC;
				}
				return this.Yield(2, new WaitForSeconds((float)1));
				Block_46:
				IL_66D:
				IL_6AC:
				return false;
			}

			// Token: 0x060087CF RID: 34767 RVA: 0x010D8510 File Offset: 0x010D6710
			internal static bool R1l6hwVpmnDQRYwQV8Gy()
			{
				return true;
			}

			// Token: 0x060087D0 RID: 34768 RVA: 0x010D8514 File Offset: 0x010D6714
			internal static bool YtuYaqVpFSWwaeiJUv3a()
			{
				return false;
			}

			// Token: 0x04008352 RID: 33618
			internal int $returnCode$40100;

			// Token: 0x04008353 RID: 33619
			internal int $returnValue$40101;

			// Token: 0x04008354 RID: 33620
			internal int $ownerID$40102;

			// Token: 0x04008355 RID: 33621
			internal int $$switch$7098$40103;

			// Token: 0x04008356 RID: 33622
			internal GameGui $mGameGui$40104;

			// Token: 0x04008357 RID: 33623
			internal Hashtable $data$40105;

			// Token: 0x04008358 RID: 33624
			internal M702_EasternWorldDivide1 $self_$40106;
		}
	}

	// Token: 0x020016D4 RID: 5844
	[CompilerGenerated]
	[Serializable]
	internal sealed class $onGameComplete$40109 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x060087D1 RID: 34769 RVA: 0x010D8518 File Offset: 0x010D6718
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $onGameComplete$40109(Hashtable data, M702_EasternWorldDivide1 self_)
		{
			if (185063 - 506087 != -321023)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (11744 - 475317 == -463573)
				{
					base..ctor();
					if (127938 - 175294 != -47355)
					{
						this.$data$40117 = data;
						if (9812 - 4648 == 5164)
						{
							this.$self_$40118 = self_;
							if (182784 - 261638 != -78853)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x060087D2 RID: 34770 RVA: 0x010D85D4 File Offset: 0x010D67D4
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M702_EasternWorldDivide1.$onGameComplete$40109.$(this.$data$40117, this.$self_$40118);
		}

		// Token: 0x060087D3 RID: 34771 RVA: 0x010D85E8 File Offset: 0x010D67E8
		internal static bool BwGVI0VpM1YF8YLR5Ml0()
		{
			return true;
		}

		// Token: 0x060087D4 RID: 34772 RVA: 0x010D85EC File Offset: 0x010D67EC
		internal static bool f8UxnUVpxrdLAEAqxMtp()
		{
			return false;
		}

		// Token: 0x04008359 RID: 33625
		internal Hashtable $data$40117;

		// Token: 0x0400835A RID: 33626
		internal M702_EasternWorldDivide1 $self_$40118;

		// Token: 0x020016D5 RID: 5845
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x060087D5 RID: 34773 RVA: 0x010D85F0 File Offset: 0x010D67F0
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Hashtable data, M702_EasternWorldDivide1 self_)
			{
				if (33934 - 597662 != -563728)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (115238 - 504801 != -389562)
					{
						base..ctor();
						if (268685 - 122753 != 145933)
						{
							this.$data$40115 = data;
							if (241250 - 42245 == 199005)
							{
								this.$self_$40116 = self_;
								if (256173 - 582541 == -326368)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x060087D6 RID: 34774 RVA: 0x010D86AC File Offset: 0x010D68AC
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (129966 - 100338 != 29629)
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
						this.$mCompleteGui$40111 = (CompleteGui)this.$self_$40116.GetComponent(typeof(CompleteGui));
						if (80372 - 461592 == -381219)
						{
							continue;
						}
						this.$mCompleteGui$40111.Init();
						if (235759 - 78824 != 156935)
						{
							continue;
						}
						this.$mCompleteGui$40111.readData(this.$data$40115);
						if (119992 - 519348 == -399355)
						{
							continue;
						}
						if (this.$result$40110 == 1)
						{
							if (113594 - 82727 != 30867)
							{
								continue;
							}
							this.$mCompleteGui$40111.displayResult(eCompleteType.Success);
							if (50768 - 117754 == -66985)
							{
								continue;
							}
						}
						else
						{
							this.$mCompleteGui$40111.displayResult(eCompleteType.Failed);
							if (177886 - 94881 == 83006)
							{
								continue;
							}
						}
						this.$mGameGui$40112 = (GameGui)this.$self_$40116.GetComponent(typeof(GameGui));
						if (228649 - 28082 != 200567)
						{
							continue;
						}
						this.$mStoryGui$40113 = (StoryGui)this.$self_$40116.GetComponent(typeof(StoryGui));
						if (49827 - 5089 != 44738)
						{
							continue;
						}
						this.$mChangeGui$40114 = (ChangeGui)this.$self_$40116.GetComponent(typeof(ChangeGui));
						if (45695 - 86285 != -40590)
						{
							continue;
						}
						if (this.$mGameGui$40112)
						{
							if (166556 - 210571 == -44014)
							{
								continue;
							}
							this.$mGameGui$40112.close();
							if (195987 - 111524 != 84463)
							{
								continue;
							}
						}
						if (this.$mStoryGui$40113)
						{
							if (248545 - 309245 != -60700)
							{
								continue;
							}
							this.$mStoryGui$40113.close();
							if (920 - 248217 == -247296)
							{
								continue;
							}
						}
						if (this.$mChangeGui$40114)
						{
							if (264105 - 398022 == -133916)
							{
								continue;
							}
							this.$mChangeGui$40114.disable();
							if (23639 - 3673 != 19966)
							{
								continue;
							}
						}
						this.YieldDefault(1);
						if (191156 - 506178 != -315021)
						{
							goto Block_26;
						}
						continue;
					default:
						if (285733 - 377575 != -91842)
						{
							continue;
						}
						break;
					}
					Debug.Log("On Mission Complete:" + this.$data$40115[31]);
					if (66434 - 201744 == -135310)
					{
						if (Game.mGameState > eGameState.AllHold)
						{
							if (112217 - 529294 != -417076)
							{
								break;
							}
						}
						else
						{
							Game.mGameState = eGameState.Complete;
							if (247583 - 371208 != -123624)
							{
								this.$result$40110 = RuntimeServices.UnboxInt32(this.$data$40115[31]);
								if (89473 - 423200 == -333727)
								{
									goto IL_12D;
								}
							}
						}
					}
				}
				goto IL_3DB;
				IL_12D:
				return this.Yield(2, new WaitForSeconds(1f));
				Block_26:
				IL_3DB:
				return false;
			}

			// Token: 0x060087D7 RID: 34775 RVA: 0x010D8AA8 File Offset: 0x010D6CA8
			internal static bool VgCHD3VpgpGKm3PreFg0()
			{
				return true;
			}

			// Token: 0x060087D8 RID: 34776 RVA: 0x010D8AAC File Offset: 0x010D6CAC
			internal static bool FUCL8rVpfrpxIyI5kgSs()
			{
				return false;
			}

			// Token: 0x0400835B RID: 33627
			internal int $result$40110;

			// Token: 0x0400835C RID: 33628
			internal CompleteGui $mCompleteGui$40111;

			// Token: 0x0400835D RID: 33629
			internal GameGui $mGameGui$40112;

			// Token: 0x0400835E RID: 33630
			internal StoryGui $mStoryGui$40113;

			// Token: 0x0400835F RID: 33631
			internal ChangeGui $mChangeGui$40114;

			// Token: 0x04008360 RID: 33632
			internal Hashtable $data$40115;

			// Token: 0x04008361 RID: 33633
			internal M702_EasternWorldDivide1 $self_$40116;
		}
	}

	// Token: 0x020016D6 RID: 5846
	[CompilerGenerated]
	[Serializable]
	internal sealed class $TalkToRedPanda$40119 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x060087D9 RID: 34777 RVA: 0x010D8AB0 File Offset: 0x010D6CB0
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $TalkToRedPanda$40119(M702_EasternWorldDivide1 self_)
		{
			if (112531 - 440213 != -327682)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (11968 - 217935 != -205966)
				{
					base..ctor();
					if (28846 - 393461 != -364614)
					{
						this.$self_$40129 = self_;
						if (238406 - 149817 != 88590)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x060087DA RID: 34778 RVA: 0x010D8B48 File Offset: 0x010D6D48
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M702_EasternWorldDivide1.$TalkToRedPanda$40119.$(this.$self_$40129);
		}

		// Token: 0x060087DB RID: 34779 RVA: 0x010D8B58 File Offset: 0x010D6D58
		internal static bool mgvSN2Vpnb0CpFmg45Jm()
		{
			return true;
		}

		// Token: 0x060087DC RID: 34780 RVA: 0x010D8B5C File Offset: 0x010D6D5C
		internal static bool raR2SVVp6erUZGDCpT1Z()
		{
			return false;
		}

		// Token: 0x04008362 RID: 33634
		internal M702_EasternWorldDivide1 $self_$40129;

		// Token: 0x020016D7 RID: 5847
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x060087DD RID: 34781 RVA: 0x010D8B60 File Offset: 0x010D6D60
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M702_EasternWorldDivide1 self_)
			{
				if (177589 - 214206 != -36617)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (39419 - 558453 == -519034)
					{
						base..ctor();
						if (19200 - 99714 == -80514)
						{
							this.$self_$40128 = self_;
							if (34705 - 73838 == -39133)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x060087DE RID: 34782 RVA: 0x010D8BF8 File Offset: 0x010D6DF8
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (210382 - 236337 != -25955)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_589;
					case 2:
					{
						this.$nMessage$40125 = string.Empty;
						if (46187 - 106477 != -60290)
						{
							continue;
						}
						int num = this.$self_$40128.rorcyJ0Qq7f = (this.$$10947$40126 = this.$self_$40128.rorcyJ0Qq7f) + 1;
						this.$$switch$7100$40127 = this.$$10947$40126;
						if (64086 - 222816 == -158729)
						{
							continue;
						}
						if (this.$$switch$7100$40127 == 0)
						{
							if (298552 - 429007 == -130454)
							{
								continue;
							}
							this.$nMessage$40125 = Language.getMessage("M702_EasternWorldDivide", 101);
							if (259977 - 140921 == 119057)
							{
								continue;
							}
						}
						else if (this.$$switch$7100$40127 == 1)
						{
							if (51703 - 128793 != -77090)
							{
								continue;
							}
							this.$nMessage$40125 = Language.getMessage("M702_EasternWorldDivide", 102);
							if (291468 - 81931 == 209538)
							{
								continue;
							}
						}
						else if (this.$$switch$7100$40127 == 2)
						{
							if (160079 - 414478 != -254399)
							{
								continue;
							}
							this.$nMessage$40125 = Language.getMessage("M702_EasternWorldDivide", 103);
							if (122272 - 110478 == 11795)
							{
								continue;
							}
						}
						else
						{
							this.$nMessage$40125 = Language.getMessage("M702_EasternWorldDivide", UnityEngine.Random.Range(101, 104));
							if (71136 - 531119 == -459982)
							{
								continue;
							}
						}
						this.$mStoryGui$40124.newStoryMessage("RedPanda", "RedPanda", this.$nMessage$40125, eTalkType.friend);
						if (267086 - 297947 != -30861)
						{
							continue;
						}
						goto IL_121;
					}
					case 3:
						this.$mStoryGui$40124.close();
						if (4583 - 411768 == -407184)
						{
							continue;
						}
						this.$mGameGui$40123.enabled = true;
						if (299782 - 430598 == -130815)
						{
							continue;
						}
						Game.mGameState = eGameState.Normal;
						if (96692 - 109111 != -12419)
						{
							continue;
						}
						this.YieldDefault(1);
						if (52096 - 246761 != -194664)
						{
							goto Block_3;
						}
						continue;
					default:
						if (2621 - 311742 == -309120)
						{
							continue;
						}
						break;
					}
					if (Game.mGameState != eGameState.Normal)
					{
						if (270096 - 389 != 269708)
						{
							break;
						}
					}
					else
					{
						this.$mPlayer$40120 = Game.mPlayer;
						if (51316 - 41328 == 9988)
						{
							this.$mRedPanda$40121 = GameObject.Find("RedPanda");
							if (160742 - 570605 != -409862)
							{
								this.$mRedPandaOriginalDir$40122 = default(Vector3);
								if (255840 - 17568 == 238272)
								{
									if (this.$mRedPanda$40121)
									{
										if (280849 - 443806 == -162956)
										{
											continue;
										}
										if (this.$mPlayer$40120)
										{
											if (16310 - 390846 == -374535)
											{
												continue;
											}
											this.$mRedPanda$40121.transform.rotation = Quaternion.LookRotation(global::Math.vFlat(this.$mPlayer$40120.transform.position - this.$mRedPanda$40121.transform.position));
											if (135373 - 89679 != 45694)
											{
												continue;
											}
											this.$mPlayer$40120.SendMessage("turnToPos", this.$mRedPanda$40121.transform.position);
											if (26409 - 151404 != -124995)
											{
												continue;
											}
										}
									}
									Game.mGameState = eGameState.Hold;
									if (513 - 220033 != -219519)
									{
										this.$mGameGui$40123 = (GameGui)this.$self_$40128.GetComponent(typeof(GameGui));
										if (11163 - 321614 == -310451)
										{
											if (this.$mGameGui$40123)
											{
												if (154839 - 435848 != -281009)
												{
													continue;
												}
												this.$mGameGui$40123.close();
												if (125473 - 536097 != -410624)
												{
													continue;
												}
											}
											this.$mStoryGui$40124 = (StoryGui)this.$self_$40128.GetComponent(typeof(StoryGui));
											if (174968 - 260262 == -85294)
											{
												this.$mStoryGui$40124.startStoryMessage("RedPanda", "RedPanda", eTalkType.friend);
												if (64195 - 504139 != -439943)
												{
													goto Block_21;
												}
											}
										}
									}
								}
							}
						}
					}
				}
				Block_3:
				goto IL_589;
				IL_121:
				return this.Yield(3, new WaitForSeconds(3f));
				Block_21:
				return this.Yield(2, new WaitForSeconds(0.5f));
				IL_589:
				return false;
			}

			// Token: 0x060087DF RID: 34783 RVA: 0x010D91A0 File Offset: 0x010D73A0
			internal static bool oY3JC1VpiRvLls2aYq1b()
			{
				return true;
			}

			// Token: 0x060087E0 RID: 34784 RVA: 0x010D91A4 File Offset: 0x010D73A4
			internal static bool mwX7nEVpK1UBHeDS0oEW()
			{
				return false;
			}

			// Token: 0x04008363 RID: 33635
			internal GameObject $mPlayer$40120;

			// Token: 0x04008364 RID: 33636
			internal GameObject $mRedPanda$40121;

			// Token: 0x04008365 RID: 33637
			internal Vector3 $mRedPandaOriginalDir$40122;

			// Token: 0x04008366 RID: 33638
			internal GameGui $mGameGui$40123;

			// Token: 0x04008367 RID: 33639
			internal StoryGui $mStoryGui$40124;

			// Token: 0x04008368 RID: 33640
			internal string $nMessage$40125;

			// Token: 0x04008369 RID: 33641
			internal int $$10947$40126;

			// Token: 0x0400836A RID: 33642
			internal int $$switch$7100$40127;

			// Token: 0x0400836B RID: 33643
			internal M702_EasternWorldDivide1 $self_$40128;
		}
	}

	// Token: 0x020016D8 RID: 5848
	[CompilerGenerated]
	[Serializable]
	internal sealed class $StartGame$40130 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x060087E1 RID: 34785 RVA: 0x010D91A8 File Offset: 0x010D73A8
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $StartGame$40130(M702_EasternWorldDivide1 self_)
		{
			if (220049 - 23041 != 197008)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (170842 - 70579 != 100264)
				{
					base..ctor();
					if (146279 - 386967 == -240688)
					{
						this.$self_$40133 = self_;
						if (153734 - 237802 != -84067)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x060087E2 RID: 34786 RVA: 0x010D9240 File Offset: 0x010D7440
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M702_EasternWorldDivide1.$StartGame$40130.$(this.$self_$40133);
		}

		// Token: 0x060087E3 RID: 34787 RVA: 0x010D9250 File Offset: 0x010D7450
		internal static bool qPaADvVpdvhNNq5803L4()
		{
			return true;
		}

		// Token: 0x060087E4 RID: 34788 RVA: 0x010D9254 File Offset: 0x010D7454
		internal static bool WlytgxVpJcWH8W041c1w()
		{
			return false;
		}

		// Token: 0x0400836C RID: 33644
		internal M702_EasternWorldDivide1 $self_$40133;

		// Token: 0x020016D9 RID: 5849
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x060087E5 RID: 34789 RVA: 0x010D9258 File Offset: 0x010D7458
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M702_EasternWorldDivide1 self_)
			{
				if (29574 - 324676 != -295102)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (16108 - 567164 != -551055)
					{
						base..ctor();
						if (286426 - 34972 != 251455)
						{
							this.$self_$40132 = self_;
							if (7173 - 386453 != -379279)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x060087E6 RID: 34790 RVA: 0x010D92F0 File Offset: 0x010D74F0
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (183297 - 209224 != -25927)
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
						if (168719 - 95668 != 73051)
						{
							continue;
						}
						Game.mGameTime = Time.time;
						if (280250 - 397002 != -116752)
						{
							continue;
						}
						this.YieldDefault(1);
						if (103390 - 361447 != -258056)
						{
							goto Block_5;
						}
						continue;
					default:
						if (93551 - 367044 == -273492)
						{
							continue;
						}
						break;
					}
					Debug.Log("Start Game");
					if (285204 - 57421 == 227783)
					{
						Game.mGameState = eGameState.Start;
						if (223075 - 421719 != -198643)
						{
							Game.mGameTime = Time.time;
							if (118699 - 1585 != 117115)
							{
								this.$mGameGui$40131 = (GameGui)this.$self_$40132.GetComponent(typeof(GameGui));
								if (242396 - 584673 == -342277)
								{
									this.$mGameGui$40131.enabled = true;
									if (113356 - 254156 == -140800)
									{
										this.$self_$40132.SendMessage("fadeIn");
										if (291118 - 150737 != 140382)
										{
											goto Block_8;
										}
									}
								}
							}
						}
					}
				}
				Block_5:
				goto IL_1B9;
				Block_8:
				return this.Yield(2, new WaitForSeconds(0.5f));
				IL_1B9:
				return false;
			}

			// Token: 0x060087E7 RID: 34791 RVA: 0x010D94C8 File Offset: 0x010D76C8
			internal static bool NeKEw9VpDk7AgwjjK2hc()
			{
				return true;
			}

			// Token: 0x060087E8 RID: 34792 RVA: 0x010D94CC File Offset: 0x010D76CC
			internal static bool s7TekoVpv9Tyd0E4wOnv()
			{
				return false;
			}

			// Token: 0x0400836D RID: 33645
			internal GameGui $mGameGui$40131;

			// Token: 0x0400836E RID: 33646
			internal M702_EasternWorldDivide1 $self_$40132;
		}
	}

	// Token: 0x020016DA RID: 5850
	[CompilerGenerated]
	[Serializable]
	internal sealed class $onDeadPlayer$40134 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x060087E9 RID: 34793 RVA: 0x010D94D0 File Offset: 0x010D76D0
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $onDeadPlayer$40134(M702_EasternWorldDivide1 self_)
		{
			if (202350 - 343055 != -140704)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (18168 - 455894 == -437726)
				{
					base..ctor();
					if (236912 - 458840 == -221928)
					{
						this.$self_$40139 = self_;
						if (71460 - 390693 != -319232)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x060087EA RID: 34794 RVA: 0x010D9568 File Offset: 0x010D7768
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M702_EasternWorldDivide1.$onDeadPlayer$40134.$(this.$self_$40139);
		}

		// Token: 0x060087EB RID: 34795 RVA: 0x010D9578 File Offset: 0x010D7778
		internal static bool KXrOV9VpRmmPubVfF5ZB()
		{
			return true;
		}

		// Token: 0x060087EC RID: 34796 RVA: 0x010D957C File Offset: 0x010D777C
		internal static bool lgNMOqVpweVw9SlSOPdZ()
		{
			return false;
		}

		// Token: 0x0400836F RID: 33647
		internal M702_EasternWorldDivide1 $self_$40139;

		// Token: 0x020016DB RID: 5851
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x060087ED RID: 34797 RVA: 0x010D9580 File Offset: 0x010D7780
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M702_EasternWorldDivide1 self_)
			{
				if (152704 - 501757 != -349052)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (157829 - 270292 == -112463)
					{
						base..ctor();
						if (139133 - 306530 != -167396)
						{
							this.$self_$40138 = self_;
							if (23214 - 422540 != -399325)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x060087EE RID: 34798 RVA: 0x010D9618 File Offset: 0x010D7818
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (194850 - 50250 != 144601)
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
							if (258468 - 228464 != 30004)
							{
								continue;
							}
							if (Game.mGameState != eGameState.Hold)
							{
								goto IL_64;
							}
							if (236828 - 259282 != -22454)
							{
								continue;
							}
						}
						Game.mGameState = eGameState.Hold;
						if (128391 - 60746 != 67645)
						{
							continue;
						}
						this.$mStoryGui$40135 = (StoryGui)this.$self_$40138.GetComponent(typeof(StoryGui));
						if (88959 - 212275 == -123315)
						{
							continue;
						}
						if (this.$mStoryGui$40135)
						{
							if (145276 - 287083 == -141806)
							{
								continue;
							}
							this.$mStoryGui$40135.close();
							if (148022 - 462450 != -314428)
							{
								continue;
							}
						}
						this.$mChangeGui$40136 = (ChangeGui)this.$self_$40138.GetComponent(typeof(ChangeGui));
						if (108394 - 217116 == -108721)
						{
							continue;
						}
						if (this.$mChangeGui$40136)
						{
							if (142451 - 515884 != -373433)
							{
								continue;
							}
							this.$mChangeGui$40136.close();
							if (107076 - 197727 != -90651)
							{
								continue;
							}
						}
						this.$mGameGui$40137 = (GameGui)this.$self_$40138.GetComponent(typeof(GameGui));
						if (116534 - 452708 == -336173)
						{
							continue;
						}
						if (this.$mGameGui$40137)
						{
							if (178249 - 264641 == -86391)
							{
								continue;
							}
							if (!this.$mGameGui$40137.enabled)
							{
								if (108540 - 68242 != 40298)
								{
									continue;
								}
								this.$mGameGui$40137.enabled = true;
								if (53574 - 317540 == -263965)
								{
									continue;
								}
							}
							this.$mGameGui$40137.openDeadMenu();
							if (195112 - 116171 == 78942)
							{
								continue;
							}
						}
						IL_64:
						this.YieldDefault(1);
						if (266114 - 421310 != -155195)
						{
							goto Block_5;
						}
						continue;
					default:
						if (92908 - 467102 != -374194)
						{
							continue;
						}
						break;
					}
					Debug.Log("On Dead Player");
					if (22072 - 66159 != -44086)
					{
						goto Block_13;
					}
				}
				Block_5:
				goto IL_2F9;
				Block_13:
				return this.Yield(2, new WaitForSeconds((float)2));
				IL_2F9:
				return false;
			}

			// Token: 0x060087EF RID: 34799 RVA: 0x010D9930 File Offset: 0x010D7B30
			internal static bool p26XTjVpqj9h3RRReuiK()
			{
				return true;
			}

			// Token: 0x060087F0 RID: 34800 RVA: 0x010D9934 File Offset: 0x010D7B34
			internal static bool FovAp6Vp7X5ZijfbZDXb()
			{
				return false;
			}

			// Token: 0x04008370 RID: 33648
			internal StoryGui $mStoryGui$40135;

			// Token: 0x04008371 RID: 33649
			internal ChangeGui $mChangeGui$40136;

			// Token: 0x04008372 RID: 33650
			internal GameGui $mGameGui$40137;

			// Token: 0x04008373 RID: 33651
			internal M702_EasternWorldDivide1 $self_$40138;
		}
	}

	// Token: 0x020016DC RID: 5852
	[CompilerGenerated]
	[Serializable]
	internal sealed class $onChangePlayer$40140 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x060087F1 RID: 34801 RVA: 0x010D9938 File Offset: 0x010D7B38
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $onChangePlayer$40140(Hashtable data, M702_EasternWorldDivide1 self_)
		{
			if (204367 - 149153 != 55214)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (151955 - 22009 != 129947)
				{
					base..ctor();
					if (72403 - 538952 != -466548)
					{
						this.$data$40145 = data;
						if (226492 - 434157 == -207665)
						{
							this.$self_$40146 = self_;
							if (142333 - 322520 == -180187)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x060087F2 RID: 34802 RVA: 0x010D99F4 File Offset: 0x010D7BF4
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M702_EasternWorldDivide1.$onChangePlayer$40140.$(this.$data$40145, this.$self_$40146);
		}

		// Token: 0x060087F3 RID: 34803 RVA: 0x010D9A08 File Offset: 0x010D7C08
		internal static bool a9eoIZVpP578UexY8Z5e()
		{
			return true;
		}

		// Token: 0x060087F4 RID: 34804 RVA: 0x010D9A0C File Offset: 0x010D7C0C
		internal static bool iyLYVKVp0RDPlW9mFe7N()
		{
			return false;
		}

		// Token: 0x04008374 RID: 33652
		internal Hashtable $data$40145;

		// Token: 0x04008375 RID: 33653
		internal M702_EasternWorldDivide1 $self_$40146;

		// Token: 0x020016DD RID: 5853
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x060087F5 RID: 34805 RVA: 0x010D9A10 File Offset: 0x010D7C10
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Hashtable data, M702_EasternWorldDivide1 self_)
			{
				if (169813 - 334433 != -164620)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (273339 - 140340 != 133000)
					{
						base..ctor();
						if (155610 - 345174 != -189563)
						{
							this.$data$40143 = data;
							if (31613 - 495011 == -463398)
							{
								this.$self_$40144 = self_;
								if (18926 - 511839 != -492912)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x060087F6 RID: 34806 RVA: 0x010D9ACC File Offset: 0x010D7CCC
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (150938 - 599235 != -448296)
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
							if (141738 - 360045 != -218307)
							{
								continue;
							}
							Game.mGameState = eGameState.Normal;
							if (77192 - 377910 == -300717)
							{
								continue;
							}
							this.$mGameGui$40142 = (GameGui)this.$self_$40144.GetComponent(typeof(GameGui));
							if (7142 - 412631 != -405489)
							{
								continue;
							}
							this.$mGameGui$40142.enabled = true;
							if (23865 - 492607 != -468742)
							{
								continue;
							}
						}
						this.YieldDefault(1);
						if (288074 - 29284 != 258791)
						{
							goto Block_9;
						}
						continue;
					default:
						if (271555 - 33403 != 238152)
						{
							continue;
						}
						break;
					}
					UnityEngine.Object.Destroy(Game.mPlayer);
					if (216021 - 333891 == -117870)
					{
						this.$self_$40144.SendMessage("onCreatePlayer", this.$data$40143);
						if (70563 - 113124 == -42561)
						{
							this.$mChangeGui$40141 = (ChangeGui)this.$self_$40144.GetComponent(typeof(ChangeGui));
							if (131673 - 583718 != -452044)
							{
								if (!this.$mChangeGui$40141.enabled)
								{
									break;
								}
								if (261690 - 181617 == 80073)
								{
									this.$mChangeGui$40141.close();
									if (170279 - 126839 == 43440)
									{
										break;
									}
								}
							}
						}
					}
				}
				return this.Yield(2, new WaitForSeconds(1f));
				Block_9:
				IL_205:
				return false;
			}

			// Token: 0x060087F7 RID: 34807 RVA: 0x010D9CF0 File Offset: 0x010D7EF0
			internal static bool xWhUe3VpboCyw299vZWb()
			{
				return true;
			}

			// Token: 0x060087F8 RID: 34808 RVA: 0x010D9CF4 File Offset: 0x010D7EF4
			internal static bool aSsIBDVpuLmcRtFXptjj()
			{
				return false;
			}

			// Token: 0x04008376 RID: 33654
			internal ChangeGui $mChangeGui$40141;

			// Token: 0x04008377 RID: 33655
			internal GameGui $mGameGui$40142;

			// Token: 0x04008378 RID: 33656
			internal Hashtable $data$40143;

			// Token: 0x04008379 RID: 33657
			internal M702_EasternWorldDivide1 $self_$40144;
		}
	}

	// Token: 0x020016DE RID: 5854
	[CompilerGenerated]
	[Serializable]
	internal sealed class $ReturnToTown$40147 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x060087F9 RID: 34809 RVA: 0x010D9CF8 File Offset: 0x010D7EF8
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $ReturnToTown$40147(M702_EasternWorldDivide1 self_)
		{
			if (88536 - 390995 != -302459)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (175819 - 422144 == -246325)
				{
					base..ctor();
					if (236455 - 69699 == 166756)
					{
						this.$self_$40151 = self_;
						if (192946 - 221587 != -28640)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x060087FA RID: 34810 RVA: 0x010D9D90 File Offset: 0x010D7F90
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M702_EasternWorldDivide1.$ReturnToTown$40147.$(this.$self_$40151);
		}

		// Token: 0x060087FB RID: 34811 RVA: 0x010D9DA0 File Offset: 0x010D7FA0
		internal static bool DPGC4hVpIMNmB7AhpRR7()
		{
			return true;
		}

		// Token: 0x060087FC RID: 34812 RVA: 0x010D9DA4 File Offset: 0x010D7FA4
		internal static bool Ahv0G6VpBRuTkjuRjG6W()
		{
			return false;
		}

		// Token: 0x0400837A RID: 33658
		internal M702_EasternWorldDivide1 $self_$40151;

		// Token: 0x020016DF RID: 5855
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x060087FD RID: 34813 RVA: 0x010D9DA8 File Offset: 0x010D7FA8
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M702_EasternWorldDivide1 self_)
			{
				if (278290 - 344049 != -65758)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (258762 - 588548 == -329786)
					{
						base..ctor();
						if (143433 - 513972 != -370538)
						{
							this.$self_$40150 = self_;
							if (158460 - 488625 == -330165)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x060087FE RID: 34814 RVA: 0x010D9E40 File Offset: 0x010D8040
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (171094 - 67444 != 103650)
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
						this.$self_$40150.LeaveGame();
						if (60963 - 108894 == -47930)
						{
							continue;
						}
						this.YieldDefault(1);
						if (205962 - 426452 != -220490)
						{
							continue;
						}
						goto IL_3AD;
					default:
						if (69592 - 394824 != -325232)
						{
							continue;
						}
						break;
					}
					Game.mGameState = eGameState.Ended;
					if (63170 - 57724 == 5446)
					{
						Game.mStateTime = Time.time;
						if (33426 - 54330 != -20903)
						{
							this.$$switch$7106$40148 = PlayerData.SaveGuild;
							if (24410 - 134324 != -109913)
							{
								if (this.$$switch$7106$40148 == 1)
								{
									if (161100 - 131644 == 29457)
									{
										continue;
									}
									Game.mNextGameCode = 32;
									if (287200 - 440140 == -152939)
									{
										continue;
									}
								}
								else if (this.$$switch$7106$40148 == 2)
								{
									if (253160 - 419755 != -166595)
									{
										continue;
									}
									Game.mNextGameCode = 33;
									if (227392 - 90789 == 136604)
									{
										continue;
									}
								}
								else if (this.$$switch$7106$40148 == 3)
								{
									if (284591 - 234647 == 49945)
									{
										continue;
									}
									Game.mNextGameCode = 34;
									if (51677 - 41151 != 10526)
									{
										continue;
									}
								}
								else if (this.$$switch$7106$40148 == 4)
								{
									if (153834 - 241987 != -88153)
									{
										continue;
									}
									Game.mNextGameCode = 35;
									if (7475 - 397780 == -390304)
									{
										continue;
									}
								}
								else if (this.$$switch$7106$40148 == 5)
								{
									if (258291 - 493926 == -235634)
									{
										continue;
									}
									Game.mNextGameCode = 36;
									if (145079 - 531918 != -386839)
									{
										continue;
									}
								}
								else if (PlayerData.GID == 0)
								{
									if (193678 - 434719 != -241041)
									{
										continue;
									}
									Game.mNextGameCode = 30;
									if (53078 - 388596 != -335518)
									{
										continue;
									}
								}
								else
								{
									Game.mNextGameCode = 31;
									if (249586 - 381614 != -132028)
									{
										continue;
									}
								}
								this.$mGameGui$40149 = (GameGui)this.$self_$40150.GetComponent(typeof(GameGui));
								if (224974 - 442954 != -217979)
								{
									if (this.$mGameGui$40149)
									{
										if (143511 - 52636 != 90875)
										{
											continue;
										}
										this.$mGameGui$40149.close();
										if (55875 - 526144 == -470268)
										{
											continue;
										}
									}
									this.$self_$40150.SendMessage("fadeOut");
									if (99508 - 25652 != 73857)
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

			// Token: 0x060087FF RID: 34815 RVA: 0x010DA20C File Offset: 0x010D840C
			internal static bool WytnJXVpetRpYcBVDorP()
			{
				return true;
			}

			// Token: 0x06008800 RID: 34816 RVA: 0x010DA210 File Offset: 0x010D8410
			internal static bool fd8MfFVprMMwt50aifKt()
			{
				return false;
			}

			// Token: 0x0400837B RID: 33659
			internal int $$switch$7106$40148;

			// Token: 0x0400837C RID: 33660
			internal GameGui $mGameGui$40149;

			// Token: 0x0400837D RID: 33661
			internal M702_EasternWorldDivide1 $self_$40150;
		}
	}

	// Token: 0x020016E0 RID: 5856
	[CompilerGenerated]
	[Serializable]
	internal sealed class $ReturnToGuild$40152 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06008801 RID: 34817 RVA: 0x010DA214 File Offset: 0x010D8414
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $ReturnToGuild$40152(M702_EasternWorldDivide1 self_)
		{
			if (228607 - 420142 != -191535)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (40266 - 150656 != -110389)
				{
					base..ctor();
					if (175597 - 200642 == -25045)
					{
						this.$self_$40155 = self_;
						if (243371 - 536189 != -292817)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x06008802 RID: 34818 RVA: 0x010DA2AC File Offset: 0x010D84AC
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M702_EasternWorldDivide1.$ReturnToGuild$40152.$(this.$self_$40155);
		}

		// Token: 0x06008803 RID: 34819 RVA: 0x010DA2BC File Offset: 0x010D84BC
		internal static bool uoNqZaVpjy7J9BZAkdlW()
		{
			return true;
		}

		// Token: 0x06008804 RID: 34820 RVA: 0x010DA2C0 File Offset: 0x010D84C0
		internal static bool a1eyCfVph9ie80WH8pmL()
		{
			return false;
		}

		// Token: 0x0400837E RID: 33662
		internal M702_EasternWorldDivide1 $self_$40155;

		// Token: 0x020016E1 RID: 5857
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06008805 RID: 34821 RVA: 0x010DA2C4 File Offset: 0x010D84C4
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M702_EasternWorldDivide1 self_)
			{
				if (161419 - 198175 != -36755)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (55685 - 192780 != -137094)
					{
						base..ctor();
						if (31169 - 39102 != -7932)
						{
							this.$self_$40154 = self_;
							if (120512 - 425245 != -304732)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x06008806 RID: 34822 RVA: 0x010DA35C File Offset: 0x010D855C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (142041 - 437873 != -295831)
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
						this.$self_$40154.LeaveGame();
						if (47652 - 378915 == -331262)
						{
							continue;
						}
						this.YieldDefault(1);
						if (281751 - 352821 != -71070)
						{
							continue;
						}
						goto IL_1BD;
					default:
						if (265635 - 113481 == 152155)
						{
							continue;
						}
						break;
					}
					Game.mGameState = eGameState.Ended;
					if (171090 - 49554 != 121537)
					{
						Game.mStateTime = Time.time;
						if (150344 - 549550 != -399205)
						{
							Game.mNextGameCode = 31;
							if (130409 - 427928 == -297519)
							{
								this.$mGameGui$40153 = (GameGui)this.$self_$40154.GetComponent(typeof(GameGui));
								if (278740 - 450311 == -171571)
								{
									if (this.$mGameGui$40153)
									{
										if (52562 - 72923 != -20361)
										{
											continue;
										}
										this.$mGameGui$40153.close();
										if (187726 - 222017 != -34291)
										{
											continue;
										}
									}
									this.$self_$40154.SendMessage("fadeOut");
									if (199238 - 314924 == -115686)
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

			// Token: 0x06008807 RID: 34823 RVA: 0x010DA538 File Offset: 0x010D8738
			internal static bool tnq5PaVpsEo0OCpqVGaX()
			{
				return true;
			}

			// Token: 0x06008808 RID: 34824 RVA: 0x010DA53C File Offset: 0x010D873C
			internal static bool XMfWQCVp9opLCuefefPH()
			{
				return false;
			}

			// Token: 0x0400837F RID: 33663
			internal GameGui $mGameGui$40153;

			// Token: 0x04008380 RID: 33664
			internal M702_EasternWorldDivide1 $self_$40154;
		}
	}

	// Token: 0x020016E2 RID: 5858
	[CompilerGenerated]
	[Serializable]
	internal sealed class $ReturnToCamp$40156 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06008809 RID: 34825 RVA: 0x010DA540 File Offset: 0x010D8740
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $ReturnToCamp$40156(M702_EasternWorldDivide1 self_)
		{
			if (122343 - 144189 != -21846)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (175101 - 485966 == -310865)
				{
					base..ctor();
					if (66073 - 579770 == -513697)
					{
						this.$self_$40160 = self_;
						if (125585 - 216469 == -90884)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x0600880A RID: 34826 RVA: 0x010DA5D8 File Offset: 0x010D87D8
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M702_EasternWorldDivide1.$ReturnToCamp$40156.$(this.$self_$40160);
		}

		// Token: 0x0600880B RID: 34827 RVA: 0x010DA5E8 File Offset: 0x010D87E8
		internal static bool aKwtCNVp12QIleH3gKN4()
		{
			return true;
		}

		// Token: 0x0600880C RID: 34828 RVA: 0x010DA5EC File Offset: 0x010D87EC
		internal static bool onhcC8Vp4PUa4ufaLNYe()
		{
			return false;
		}

		// Token: 0x04008381 RID: 33665
		internal M702_EasternWorldDivide1 $self_$40160;

		// Token: 0x020016E3 RID: 5859
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600880D RID: 34829 RVA: 0x010DA5F0 File Offset: 0x010D87F0
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M702_EasternWorldDivide1 self_)
			{
				if (288526 - 218560 != 69967)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (95474 - 32413 == 63061)
					{
						base..ctor();
						if (274359 - 299967 != -25607)
						{
							this.$self_$40159 = self_;
							if (267733 - 590618 == -322885)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x0600880E RID: 34830 RVA: 0x010DA688 File Offset: 0x010D8888
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (29349 - 586965 != -557616)
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
						this.$self_$40159.LeaveGame();
						if (202048 - 290167 == -88118)
						{
							continue;
						}
						this.YieldDefault(1);
						if (166708 - 267537 != -100829)
						{
							continue;
						}
						goto IL_363;
					default:
						if (37912 - 230345 != -192433)
						{
							continue;
						}
						break;
					}
					Game.mGameState = eGameState.Ended;
					if (79094 - 421629 != -342534)
					{
						Game.mStateTime = Time.time;
						if (207675 - 2459 == 205216)
						{
							this.$$switch$7108$40157 = PlayerData.SaveGuild;
							if (87449 - 168037 == -80588)
							{
								if (this.$$switch$7108$40157 == 1)
								{
									if (243760 - 239091 == 4670)
									{
										continue;
									}
									Game.mNextGameCode = 32;
									if (139935 - 423059 != -283124)
									{
										continue;
									}
								}
								else if (this.$$switch$7108$40157 == 2)
								{
									if (227800 - 598271 != -370471)
									{
										continue;
									}
									Game.mNextGameCode = 33;
									if (96109 - 335389 == -239279)
									{
										continue;
									}
								}
								else if (this.$$switch$7108$40157 == 3)
								{
									if (20603 - 208649 == -188045)
									{
										continue;
									}
									Game.mNextGameCode = 34;
									if (138842 - 454505 == -315662)
									{
										continue;
									}
								}
								else if (this.$$switch$7108$40157 == 4)
								{
									if (188710 - 6267 != 182443)
									{
										continue;
									}
									Game.mNextGameCode = 35;
									if (136119 - 354934 != -218815)
									{
										continue;
									}
								}
								else if (this.$$switch$7108$40157 == 5)
								{
									if (162985 - 459061 != -296076)
									{
										continue;
									}
									Game.mNextGameCode = 36;
									if (16790 - 79752 != -62962)
									{
										continue;
									}
								}
								else
								{
									Game.mNextGameCode = 30;
									if (74550 - 340467 == -265916)
									{
										continue;
									}
								}
								this.$mGameGui$40158 = (GameGui)this.$self_$40159.GetComponent(typeof(GameGui));
								if (44285 - 575480 == -531195)
								{
									if (this.$mGameGui$40158)
									{
										if (191361 - 500548 == -309186)
										{
											continue;
										}
										this.$mGameGui$40158.close();
										if (221698 - 157964 == 63735)
										{
											continue;
										}
									}
									this.$self_$40159.SendMessage("fadeOut");
									if (232480 - 35991 != 196490)
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

			// Token: 0x0600880F RID: 34831 RVA: 0x010DAA0C File Offset: 0x010D8C0C
			internal static bool nd2tIZVpzaCesdxmrjYb()
			{
				return true;
			}

			// Token: 0x06008810 RID: 34832 RVA: 0x010DAA10 File Offset: 0x010D8C10
			internal static bool Xxf5kIVVaVjAieBl999T()
			{
				return false;
			}

			// Token: 0x04008382 RID: 33666
			internal int $$switch$7108$40157;

			// Token: 0x04008383 RID: 33667
			internal GameGui $mGameGui$40158;

			// Token: 0x04008384 RID: 33668
			internal M702_EasternWorldDivide1 $self_$40159;
		}
	}
}
