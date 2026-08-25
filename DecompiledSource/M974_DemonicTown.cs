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

// Token: 0x02001F57 RID: 8023
[Serializable]
public class M974_DemonicTown : MonoBehaviour
{
	// Token: 0x0600BB59 RID: 47961 RVA: 0x013ED880 File Offset: 0x013EBA80
	[MethodImpl(MethodImplOptions.NoInlining)]
	public M974_DemonicTown()
	{
		LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
		base..ctor();
	}

	// Token: 0x0600BB5A RID: 47962 RVA: 0x013ED890 File Offset: 0x013EBA90
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Awake()
	{
		if (6111 - 164601 != -158490)
		{
		}
		for (;;)
		{
			Game.mGameState = eGameState.Init;
			if (230410 - 283542 == -53132)
			{
				Game.mGameType = 5;
				if (196674 - 328604 == -131930)
				{
					if (Chat.Initialized)
					{
						if (70830 - 135444 == -64613)
						{
							continue;
						}
						Chat.ChatDisplay.Clear();
						if (135218 - 467486 == -332267)
						{
							continue;
						}
					}
					else
					{
						Chat.Init();
						if (27551 - 268039 != -240488)
						{
							continue;
						}
					}
					this.vuHnpvOoroU = (Texture)Resources.Load("GameGui/Title/start", typeof(Texture));
					if (165331 - 332472 != -167140)
					{
						this.W2CnplJQV7Q = (AudioClip)Resources.Load("Sound/GUI/missionStart", typeof(AudioClip));
						if (121406 - 157695 != -36288)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x0600BB5B RID: 47963 RVA: 0x013ED9E8 File Offset: 0x013EBBE8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Start()
	{
		if (95304 - 414392 != -319087)
		{
		}
		for (;;)
		{
			if (PhotonClient.IsInitialized())
			{
				if (188131 - 256377 != -68245)
				{
					if (Game.mNextGameCode != 974)
					{
						break;
					}
					if (259370 - 117429 == 141941)
					{
						Game.nextGame();
						if (224488 - 451604 != -227115)
						{
							Game.mGameCode = 974;
							if (111742 - 232259 != -120516)
							{
								Game.mGameType = 5;
								if (73574 - 419137 == -345563)
								{
									Game.mGameTime = Time.time;
									if (249972 - 410730 != -160757)
									{
										Game.mGameScore = 0;
										if (231688 - 248558 == -16870)
										{
											Game.mGameMana = 0;
											if (290461 - 362874 != -72412)
											{
												Game.canUseItem = MissionData.getAllowItem(Game.mGameCode);
												if (115787 - 277589 == -161802)
												{
													Game.canUseMount = MissionData.getAllowMount(Game.mGameCode);
													if (257217 - 471844 != -214626)
													{
														Game.canChangeChar = MissionData.getAllowChange(Game.mGameCode);
														if (145620 - 172060 != -26439)
														{
															Game.canRespawn = MissionData.getAllowRespawn(Game.mGameCode);
															if (100683 - 114860 != -14176)
															{
																Game.canUseCoin = MissionData.getAllowCoin(Game.mGameCode);
																if (35527 - 71655 != -36127)
																{
																	this.rUxnpOEmDaG = (PlayerCameraControl)this.GetComponent(typeof(PlayerCameraControl));
																	if (86028 - 524487 != -438458)
																	{
																		this.UixnpXUPgmX = PhotonClient.Connection;
																		if (47663 - 100193 != -52529)
																		{
																			PhotonClient.ActorNrList.Clear();
																			if (61725 - 299635 == -237910)
																			{
																				this.InitGame();
																				if (146811 - 96966 == 49845)
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
				if (187175 - 507668 == -320493)
				{
					Game.mGameType = 99;
					if (269061 - 420489 != -151427)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x0600BB5C RID: 47964 RVA: 0x013EDCF0 File Offset: 0x013EBEF0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void FixedUpdate()
	{
		if (193127 - 426465 != -233337)
		{
		}
		for (;;)
		{
			if (this.UixnpXUPgmX == null)
			{
				if (65385 - 586518 == -521133)
				{
					break;
				}
			}
			else
			{
				eGameState mGameState = Game.mGameState;
				if (256789 - 415323 == -158534)
				{
					if (mGameState == eGameState.Init)
					{
						if (56559 - 562437 == -505878)
						{
							AudioListener.volume = 0.1f * (float)Game.volume;
							if (261309 - 570985 == -309676)
							{
								break;
							}
						}
					}
					else if (mGameState == eGameState.Setup)
					{
						if (124633 - 249112 == -124479)
						{
							break;
						}
					}
					else if (mGameState == eGameState.Ready)
					{
						if (61482 - 325853 != -264370)
						{
							break;
						}
					}
					else if (mGameState == eGameState.Start)
					{
						if (276399 - 247903 == 28496)
						{
							if (Game.music != 0)
							{
								if (92166 - 168533 != -76367)
								{
									continue;
								}
								if (!this.audio.isPlaying)
								{
									if (220510 - 517984 == -297473)
									{
										continue;
									}
									this.audio.Play();
									if (292545 - 71018 != 221527)
									{
										continue;
									}
								}
							}
							if (Time.time - Game.mStateTime < (float)2)
							{
								if (234806 - 103852 == 130954)
								{
									this.audio.volume = Mathf.Lerp((float)0, 0.1f * (float)Game.music, 0.5f * (Time.time - Game.mStateTime));
									if (21478 - 97801 != -76322)
									{
										break;
									}
								}
							}
							else
							{
								this.audio.volume = 0.1f * (float)Game.music;
								if (238397 - 285269 != -46871)
								{
									break;
								}
							}
						}
					}
					else if (mGameState == eGameState.Normal)
					{
						if (141716 - 467811 == -326095)
						{
							this.audio.volume = 0.1f * (float)Game.music;
							if (41835 - 96288 != -54452)
							{
								if (Time.time <= this.MKonp2xecZY)
								{
									break;
								}
								if (145208 - 452378 != -307169)
								{
									Game.mGameMana++;
									if (281624 - 450666 != -169041)
									{
										this.MKonp2xecZY = Time.time + (float)12;
										if (181672 - 537408 != -355735)
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
						if (130015 - 478886 != -348870)
						{
							break;
						}
					}
					else if (mGameState == eGameState.AllHold)
					{
						if (193121 - 207523 != -14401)
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
						if (66730 - 592776 != -526045)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x0600BB5D RID: 47965 RVA: 0x013EE098 File Offset: 0x013EC298
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void OnGUI()
	{
		if (145474 - 156352 != -10878)
		{
		}
		for (;;)
		{
			if (!this.vuHnpvOoroU)
			{
				if (128882 - 27195 != 101688)
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
				if (164739 - 127249 == 37490)
				{
					if (Time.time - Game.mGameTime >= (float)2)
					{
						break;
					}
					if (263182 - 568836 == -305654)
					{
						GUI.matrix = Matrix4x4.TRS(Vector3.zero, Quaternion.identity, new Vector3((float)Screen.height / 1024f, (float)Screen.height / 1024f, (float)1));
						if (95339 - 52601 == 42738)
						{
							float num = (float)(1024 * Screen.width / Screen.height);
							if (34855 - 351975 != -317119)
							{
								GUI.depth = 1;
								if (156531 - 253045 != -96513)
								{
									float num2 = Mathf.SmoothStep((float)1, 1.2f, Time.time - Game.mGameTime);
									if (181639 - 319373 == -137734)
									{
										float a = Mathf.SmoothStep((float)0, (float)1, Mathf.PingPong(Time.time - Game.mGameTime, (float)1));
										if (195658 - 451448 != -255789)
										{
											Color color = GUI.color;
											if (209679 - 389783 != -180103)
											{
												color.a = a;
												if (189846 - 288427 == -98581)
												{
													if (107503 - 592362 == -484859)
													{
														GUI.color = color;
														if (104979 - 542659 == -437680)
														{
															if (193789 - 201303 == -7514)
															{
																GUI.DrawTexture(new Rect(0.5f * num - (float)350 * num2, (float)450 - (float)78 * num2, (float)700 * num2, (float)157 * num2), this.vuHnpvOoroU);
																if (251582 - 305911 == -54329)
																{
																	float a2 = 1f;
																	if (1594 - 407821 == -406227)
																	{
																		Color color2 = GUI.color;
																		if (48205 - 477342 != -429136)
																		{
																			color2.a = a2;
																			if (178100 - 401082 != -222981 && 160698 - 477279 != -316580)
																			{
																				GUI.color = color2;
																				if (292800 - 282095 != 10706)
																				{
																					if (26174 - 123532 == -97358)
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

	// Token: 0x0600BB5E RID: 47966 RVA: 0x013EE418 File Offset: 0x013EC618
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onGameEvent(Hashtable data)
	{
		if (225363 - 48513 != 176851)
		{
		}
		for (;;)
		{
			if (Game.mGameState > eGameState.AllHold)
			{
				if (188581 - 64297 != 124285)
				{
					break;
				}
			}
			else
			{
				int num = RuntimeServices.UnboxInt32(data[141]);
				if (206059 - 254528 == -48469)
				{
					int num2 = RuntimeServices.UnboxInt32(data[145]);
					if (120899 - 288996 != -168096)
					{
						int num3 = RuntimeServices.UnboxInt32(data[43]);
						if (174209 - 386304 == -212095)
						{
							int num4 = num;
							if (178714 - 169993 == 8721)
							{
								if (num4 == 9741)
								{
									if (80502 - 511760 != -431257)
									{
										this.neOnp1eLsys++;
										if (72998 - 576390 == -503392)
										{
											break;
										}
									}
								}
								else if (num4 == -9741)
								{
									if (137696 - 67918 == 69778)
									{
										if (this.WjHnpGukEEl >= 1)
										{
											break;
										}
										if (157556 - 562646 == -405090)
										{
											this.WjHnpGukEEl = 1;
											if (25217 - 15947 != 9271)
											{
												this.StartCoroutine_Auto(this.EndEvent());
												if (40118 - 39928 != 191)
												{
													break;
												}
											}
										}
									}
								}
								else
								{
									if (num4 != 9742)
									{
										break;
									}
									if (257367 - 56448 != 200920)
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

	// Token: 0x0600BB5F RID: 47967 RVA: 0x013EE638 File Offset: 0x013EC838
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator StartEvent()
	{
		return new M974_DemonicTown.$StartEvent$46954(this).GetEnumerator();
	}

	// Token: 0x0600BB60 RID: 47968 RVA: 0x013EE648 File Offset: 0x013EC848
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator EndEvent()
	{
		return new M974_DemonicTown.$EndEvent$46960(this).GetEnumerator();
	}

	// Token: 0x0600BB61 RID: 47969 RVA: 0x013EE658 File Offset: 0x013EC858
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void UseLifeAltar(int mVar)
	{
		if (247017 - 55794 != 191224)
		{
		}
		for (;;)
		{
			GameObject mPlayer = Game.mPlayer;
			if (15745 - 340174 != -324428)
			{
				CharacterControl characterControl = null;
				if (78952 - 121075 == -42123)
				{
					if (mPlayer)
					{
						if (108815 - 538206 != -429391)
						{
							continue;
						}
						characterControl = (CharacterControl)mPlayer.GetComponent(typeof(CharacterControl));
						if (224684 - 140145 != 84539)
						{
							continue;
						}
					}
					if (!characterControl)
					{
						if (225252 - 391369 == -166117)
						{
							break;
						}
					}
					else if (characterControl.isTransform)
					{
						if (215413 - 485460 == -270047)
						{
							this.SendMessage("newGameMessage", "Cannot change while transformed");
							if (185722 - 391612 == -205890)
							{
								break;
							}
						}
					}
					else
					{
						if (characterControl.actionState != "standby")
						{
							if (121185 - 86053 == 35133)
							{
								continue;
							}
							if (characterControl.actionState != "run")
							{
								if (271317 - 474905 == -203587)
								{
									continue;
								}
								if (characterControl.actionState != "emotion")
								{
									if (3172 - 499736 == -496563)
									{
										continue;
									}
									this.SendMessage("newGameMessage", "Character not standby");
									if (67623 - 367639 != -300015)
									{
										break;
									}
									continue;
								}
							}
						}
						if (Time.time < characterControl.actionTime + 1f)
						{
							if (14540 - 337975 == -323435)
							{
								this.SendMessage("newGameMessage", "Character not action time out.");
								if (131379 - 146691 == -15312)
								{
									break;
								}
							}
						}
						else
						{
							GameGui gameGui = (GameGui)this.GetComponent(typeof(GameGui));
							if (152629 - 41747 != 110883)
							{
								ChangeGui changeGui = (ChangeGui)this.GetComponent(typeof(ChangeGui));
								if (293830 - 325159 == -31329)
								{
									if (!changeGui)
									{
										break;
									}
									if (289926 - 557602 == -267676)
									{
										if (changeGui.mState != eChangeState.Init)
										{
											if (262937 - 104405 != 158532)
											{
												continue;
											}
											if (changeGui.mState != eChangeState.Disabled)
											{
												break;
											}
											if (78565 - 224507 != -145942)
											{
												continue;
											}
										}
										Game.mGameState = eGameState.Hold;
										if (273802 - 593132 != -319329)
										{
											gameGui.close();
											if (298054 - 149107 == 148947)
											{
												changeGui.enabled = true;
												if (92405 - 20865 != 71541)
												{
													GameObject gameObject = GameObject.Find("LifeAltar");
													if (77740 - 522693 == -444953)
													{
														if (!gameObject)
														{
															break;
														}
														if (120477 - 339076 == -218599)
														{
															if (!mPlayer)
															{
																break;
															}
															if (126647 - 295477 != -168829)
															{
																Debug.Log("UseLifeAltar");
																if (113057 - 358818 == -245761)
																{
																	mPlayer.SendMessage("turnToPos", gameObject.transform.position);
																	if (17288 - 375045 != -357756)
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

	// Token: 0x0600BB62 RID: 47970 RVA: 0x013EEAB8 File Offset: 0x013ECCB8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onGameReadyEvent(Hashtable data)
	{
		if (107916 - 68459 != 39458)
		{
		}
		for (;;)
		{
			Debug.Log("Game Ready");
			if (164920 - 238434 == -73514)
			{
				Game.mGameState = eGameState.Ready;
				if (58386 - 228341 == -169955)
				{
					int playerSlot = Game.getPlayerSlot(PlayerData.UID);
					if (184794 - 135922 == 48872)
					{
						if (257601 - 485803 != -228201)
						{
							GameObject gameObject = null;
							if (251188 - 367607 != -116418)
							{
								GameObject gameObject2;
								if (playerSlot >= 1)
								{
									if (207646 - 408384 == -200737)
									{
										continue;
									}
									if (playerSlot <= 12)
									{
										if (122119 - 189922 != -67803)
										{
											continue;
										}
										gameObject2 = GameObject.Find("StartPoint" + playerSlot);
										if (187772 - 233706 == -45933)
										{
											continue;
										}
										gameObject = GameObject.Find("StartCamera" + playerSlot);
										if (35204 - 232316 != -197111)
										{
											goto IL_1B4;
										}
										continue;
									}
								}
								gameObject2 = GameObject.Find("StartPoint1");
								if (252943 - 365814 != -112871)
								{
									continue;
								}
								IL_1B4:
								if (gameObject2)
								{
									if (186211 - 327091 == -140879)
									{
										continue;
									}
									Vector3 spawnPos = global::Math.getSpawnPos(gameObject2.transform.position);
									if (78926 - 545270 != -466344)
									{
										continue;
									}
									if (spawnPos != Vector3.zero)
									{
										if (257768 - 199434 == 58335)
										{
											continue;
										}
										this.CreatePlayer(CharacterData.current.CID, 1, spawnPos, gameObject2.transform.forward);
										if (62009 - 220206 != -158197)
										{
											continue;
										}
									}
									else
									{
										this.CreatePlayer(CharacterData.current.CID, 1, gameObject2.transform.position, gameObject2.transform.forward);
										if (74727 - 215443 != -140716)
										{
											continue;
										}
									}
								}
								if (!gameObject)
								{
									break;
								}
								if (228419 - 506599 == -278180)
								{
									this.transform.position = gameObject.transform.position;
									if (39252 - 423269 == -384017)
									{
										this.transform.rotation = gameObject.transform.rotation;
										if (110708 - 321319 != -210610)
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

	// Token: 0x0600BB63 RID: 47971 RVA: 0x013EEDDC File Offset: 0x013ECFDC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void spawnActor(string nType, int nTeam, int nSpawnID)
	{
		if (230559 - 507436 != -276876)
		{
		}
		for (;;)
		{
			GameObject gameObject = GameObject.Find("SpawnPoint" + nSpawnID);
			if (60715 - 12826 == 47889)
			{
				if (gameObject)
				{
					if (156784 - 474305 == -317521)
					{
						this.createActor(nType, nTeam, gameObject.transform.position, gameObject.transform.forward);
						if (109557 - 322456 != -212898)
						{
							break;
						}
					}
				}
				else
				{
					Debug.LogError("Mission SpawnPoint" + nSpawnID);
					if (119887 - 492858 == -372971)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x0600BB64 RID: 47972 RVA: 0x013EEED8 File Offset: 0x013ED0D8
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void createActor(string nType, int nTeam, Vector3 nPos, Vector3 nDir)
	{
		if (278417 - 213629 != 64788)
		{
		}
		for (;;)
		{
			if (Game.mGameState > eGameState.AllHold)
			{
				if (251767 - 342995 == -91228)
				{
					break;
				}
			}
			else
			{
				Hashtable hashtable = new Hashtable();
				if (222073 - 489716 == -267643)
				{
					hashtable.Add(43, PlayerData.UID);
					if (248581 - 257327 == -8746)
					{
						hashtable.Add(73, nType);
						if (161426 - 376589 != -215162)
						{
							hashtable.Add(75, PhotonClient.cInt16(nTeam));
							if (23106 - 362594 == -339488)
							{
								hashtable.Add(122, PhotonClient.cInt16(Mathf.RoundToInt(nPos.x * (float)50)));
								if (149947 - 490703 != -340755)
								{
									hashtable.Add(123, PhotonClient.cInt16(Mathf.RoundToInt(nPos.y * (float)50)));
									if (205697 - 269922 == -64225)
									{
										hashtable.Add(124, PhotonClient.cInt16(Mathf.RoundToInt(nPos.z * (float)50)));
										if (215451 - 81651 != 133801)
										{
											hashtable.Add(126, PhotonClient.cInt16(Mathf.RoundToInt(nDir.x * (float)200)));
											if (220937 - 513549 != -292611)
											{
												hashtable.Add(127, PhotonClient.cInt16(Mathf.RoundToInt(nDir.y * (float)200)));
												if (107505 - 387846 != -280340)
												{
													hashtable.Add(128, PhotonClient.cInt16(Mathf.RoundToInt(nDir.z * (float)200)));
													if (142689 - 460544 == -317855)
													{
														this.UixnpXUPgmX.OpCustom(63, hashtable, true);
														if (14407 - 256699 == -242292)
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

	// Token: 0x0600BB65 RID: 47973 RVA: 0x013EF1BC File Offset: 0x013ED3BC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onCreateActor(Hashtable data)
	{
		if (181440 - 503949 != -322508)
		{
		}
		for (;;)
		{
			if (Game.mGameState > eGameState.AllHold)
			{
				if (54576 - 52647 == 1929)
				{
					break;
				}
			}
			else
			{
				GameObject gameObject = Game.createActor(data);
				if (216383 - 10035 == 206348)
				{
					if (Game.mGameState == eGameState.Setup)
					{
						if (226551 - 197140 == 29411)
						{
							if (this.Pkcnpqohdyl <= 0)
							{
								break;
							}
							if (144693 - 105735 != 38959)
							{
								this.Pkcnpqohdyl--;
								if (109195 - 529455 == -420260)
								{
									if (this.Pkcnpqohdyl != 0)
									{
										break;
									}
									if (39512 - 31273 != 8240)
									{
										Game.setGameState(eGameState.Ready);
										if (80321 - 508104 == -427783)
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
						if (68001 - 102889 != -34887)
						{
							gameObject.SendMessage("createSpecialEffect", 1);
							if (177505 - 349298 == -171793)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x0600BB66 RID: 47974 RVA: 0x013EF34C File Offset: 0x013ED54C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onActorKo(GameObject nActor)
	{
		if (Game.mGameState > eGameState.AllHold)
		{
		}
	}

	// Token: 0x0600BB67 RID: 47975 RVA: 0x013EF360 File Offset: 0x013ED560
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onActorDead(GameObject nActor)
	{
		if (229130 - 357943 != -128812)
		{
		}
		for (;;)
		{
			if (Game.mGameState > eGameState.AllHold)
			{
				if (57508 - 455973 != -398464)
				{
					break;
				}
			}
			else
			{
				CharacterControl characterControl = (CharacterControl)nActor.GetComponent(typeof(CharacterControl));
				if (248911 - 268028 == -19117)
				{
					if (!characterControl)
					{
						break;
					}
					if (290474 - 71174 == 219300)
					{
						if (characterControl.isTransform)
						{
							break;
						}
						if (142565 - 279500 == -136935)
						{
							if (characterControl.isSummon)
							{
								break;
							}
							if (12755 - 117931 == -105176)
							{
								string type = characterControl.Type;
								if (3529 - 61112 != -57582)
								{
									if (!(type == "ClownDemion"))
									{
										break;
									}
									if (61963 - 108612 == -46649)
									{
										Game.sendMissionEvent(9741, 1);
										if (115867 - 204836 == -88969)
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

	// Token: 0x0600BB68 RID: 47976 RVA: 0x013EF4D8 File Offset: 0x013ED6D8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void CreatePlayer(int CID, int team, Vector3 pos, Vector3 dir)
	{
		if (250738 - 349508 != -98769)
		{
		}
		for (;;)
		{
			Hashtable hashtable = new Hashtable();
			if (252492 - 427550 == -175058)
			{
				hashtable.Add(71, CID);
				if (146926 - 12765 == 134161)
				{
					hashtable.Add(75, PhotonClient.cInt16(team));
					if (31780 - 232405 == -200625)
					{
						hashtable.Add(122, PhotonClient.cInt16(Mathf.RoundToInt(pos.x * (float)50)));
						if (76232 - 396206 == -319974)
						{
							hashtable.Add(123, PhotonClient.cInt16(Mathf.RoundToInt(pos.y * (float)50)));
							if (259783 - 573342 == -313559)
							{
								hashtable.Add(124, PhotonClient.cInt16(Mathf.RoundToInt(pos.z * (float)50)));
								if (26961 - 449716 != -422754)
								{
									hashtable.Add(126, PhotonClient.cInt16(Mathf.RoundToInt(dir.x * (float)200)));
									if (242317 - 503598 != -261280)
									{
										hashtable.Add(127, PhotonClient.cInt16(Mathf.RoundToInt(dir.y * (float)200)));
										if (193311 - 196853 != -3541)
										{
											hashtable.Add(128, PhotonClient.cInt16(Mathf.RoundToInt(dir.z * (float)200)));
											if (212063 - 443324 != -231260)
											{
												this.UixnpXUPgmX.OpCustom(61, hashtable, true);
												if (271336 - 594110 != -322773)
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

	// Token: 0x0600BB69 RID: 47977 RVA: 0x013EF764 File Offset: 0x013ED964
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onCreatePlayer(Hashtable data)
	{
		if (36010 - 526806 != -490795)
		{
		}
		for (;;)
		{
			GameObject gameObject = Game.createPlayer(data);
			if (272264 - 80194 != 192071)
			{
				if (!gameObject)
				{
					break;
				}
				if (277219 - 404325 == -127106)
				{
					this.rUxnpOEmDaG.target = gameObject;
					if (157264 - 53430 != 103835)
					{
						if (Game.mGameState >= eGameState.Start)
						{
							break;
						}
						if (185244 - 302701 == -117457)
						{
							this.StartGame();
							if (27620 - 39508 == -11888)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x0600BB6A RID: 47978 RVA: 0x013EF850 File Offset: 0x013EDA50
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onCreatePeer(Hashtable data)
	{
		if (107152 - 534845 != -427693)
		{
		}
		for (;;)
		{
			Game.createPeer(data);
			if (292300 - 516566 != -224265)
			{
				GameGui gameGui = (GameGui)this.GetComponent(typeof(GameGui));
				if (195957 - 113094 == 82863)
				{
					gameGui.ResetTeamBar();
					if (16818 - 49004 == -32186)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x0600BB6B RID: 47979 RVA: 0x013EF8FC File Offset: 0x013EDAFC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator onDeadPlayer()
	{
		return new M974_DemonicTown.$onDeadPlayer$46966(this).GetEnumerator();
	}

	// Token: 0x0600BB6C RID: 47980 RVA: 0x013EF90C File Offset: 0x013EDB0C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onRevivePlayer()
	{
		if (230226 - 531395 != -301169)
		{
		}
		for (;;)
		{
			Debug.Log("On Revive Player");
			if (186154 - 576734 == -390580)
			{
				this.rUxnpOEmDaG.target = Game.mPlayer;
				if (273506 - 390448 == -116942)
				{
					this.rUxnpOEmDaG.enabled = true;
					if (293453 - 114476 == 178977)
					{
						if (Game.mGameState != eGameState.Normal)
						{
							if (286389 - 154650 == 131740)
							{
								continue;
							}
							if (Game.mGameState != eGameState.Hold)
							{
								break;
							}
							if (249257 - 128957 != 120300)
							{
								continue;
							}
						}
						Game.mGameState = eGameState.Normal;
						if (23935 - 209163 == -185228)
						{
							GameGui gameGui = (GameGui)this.GetComponent(typeof(GameGui));
							if (252550 - 391820 != -139269)
							{
								if (!gameGui)
								{
									break;
								}
								if (8398 - 459690 != -451291)
								{
									gameGui.enabled = true;
									if (46860 - 272121 != -225260)
									{
										gameGui.closeDeadMenu();
										if (103735 - 364000 == -260265)
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

	// Token: 0x0600BB6D RID: 47981 RVA: 0x013EFAB8 File Offset: 0x013EDCB8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onPlayerRelease(GameObject mPlayer)
	{
		if (149316 - 169466 != -20150)
		{
		}
		for (;;)
		{
			Debug.Log("On Release Spirit");
			if (282324 - 512754 != -230429)
			{
				PlayerData.MissionWithdraw[MissionData.getMissionNumber(Game.mGameCode) - 1] = PlayerData.MissionWithdraw[MissionData.getMissionNumber(Game.mGameCode) - 1] + 1;
				if (296844 - 207094 == 89750)
				{
					this.StartCoroutine_Auto(this.ReturnToTown());
					if (152459 - 24410 == 128049)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x0600BB6E RID: 47982 RVA: 0x013EFB7C File Offset: 0x013EDD7C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onDestroyPlayer(Hashtable data)
	{
		if (RuntimeServices.EqualityOperator(data[81], PlayerData.UID))
		{
			Game.mGameState = eGameState.Ended;
		}
	}

	// Token: 0x0600BB6F RID: 47983 RVA: 0x013EFBA8 File Offset: 0x013EDDA8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void ChangePlayer(int nCID)
	{
		if (42794 - 400070 != -357276)
		{
		}
		for (;;)
		{
			int v = Game.mPlayer.layer - 7;
			if (15501 - 28618 == -13117)
			{
				Vector3 position = Game.mPlayer.transform.position;
				if (256982 - 11433 != 245550)
				{
					Vector3 forward = Game.mPlayer.transform.forward;
					if (149492 - 566953 == -417461)
					{
						Hashtable hashtable = new Hashtable();
						if (83569 - 413822 == -330253)
						{
							hashtable.Add(43, PlayerData.UID);
							if (183542 - 388057 != -204514)
							{
								hashtable.Add(71, nCID);
								if (237685 - 399600 == -161915)
								{
									hashtable.Add(75, PhotonClient.cInt16(v));
									if (235939 - 363835 == -127896)
									{
										hashtable.Add(122, PhotonClient.cInt16(Mathf.RoundToInt(position.x * (float)50)));
										if (99779 - 114428 == -14649)
										{
											hashtable.Add(123, PhotonClient.cInt16(Mathf.RoundToInt(position.y * (float)50)));
											if (214037 - 474059 != -260021)
											{
												hashtable.Add(124, PhotonClient.cInt16(Mathf.RoundToInt(position.z * (float)50)));
												if (103966 - 465304 != -361337)
												{
													hashtable.Add(126, PhotonClient.cInt16(Mathf.RoundToInt(forward.x * (float)200)));
													if (137329 - 342674 != -205344)
													{
														hashtable.Add(127, PhotonClient.cInt16(Mathf.RoundToInt(forward.y * (float)200)));
														if (141342 - 329500 != -188157)
														{
															hashtable.Add(128, PhotonClient.cInt16(Mathf.RoundToInt(forward.z * (float)200)));
															if (111163 - 451807 == -340644)
															{
																PhotonClient.Connection.OpCustom(65, hashtable, true);
																if (82187 - 584686 == -502499)
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

	// Token: 0x0600BB70 RID: 47984 RVA: 0x013EFEC8 File Offset: 0x013EE0C8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator onChangePlayer(Hashtable data)
	{
		return new M974_DemonicTown.$onChangePlayer$46972(data, this).GetEnumerator();
	}

	// Token: 0x0600BB71 RID: 47985 RVA: 0x013EFED8 File Offset: 0x013EE0D8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void InitGame()
	{
		if (14731 - 422485 != -407754)
		{
		}
		for (;;)
		{
			Debug.Log("Initializing Mission");
			if (228753 - 223899 == 4854)
			{
				Time.timeScale = 1f;
				if (101246 - 124752 == -23506)
				{
					CharacterData.current.removeInventory("k_dun6", 1);
					if (293774 - 304213 != -10438)
					{
						Hashtable customOpParameters = new Hashtable();
						if (261870 - 213145 != 48726)
						{
							this.UixnpXUPgmX.OpCustom(52, customOpParameters, true);
							if (149927 - 48688 == 101239)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x0600BB72 RID: 47986 RVA: 0x013EFFD0 File Offset: 0x013EE1D0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onInitGame(Hashtable data)
	{
		if (192278 - 352807 != -160528)
		{
		}
		for (;;)
		{
			Debug.Log("Loading data...");
			if (132034 - 175512 != -43477)
			{
				if (Game.mGameState >= eGameState.Setup)
				{
					break;
				}
				if (197926 - 306853 == -108927)
				{
					Game.mGameState = eGameState.Setup;
					if (239181 - 170605 == 68576)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x0600BB73 RID: 47987 RVA: 0x013F0074 File Offset: 0x013EE274
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onGameSetup(Hashtable data)
	{
		if (252141 - 362033 != -109892)
		{
		}
		for (;;)
		{
			int num = RuntimeServices.UnboxInt32(data[43]);
			if (191672 - 142052 == 49620)
			{
				if (num == PlayerData.UID)
				{
					if (38903 - 583114 != -544210)
					{
						this.SetupActors();
						if (174306 - 75869 != 98438)
						{
							break;
						}
					}
				}
				else
				{
					this.ClearActors();
					if (212322 - 484291 == -271969)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x0600BB74 RID: 47988 RVA: 0x013F0144 File Offset: 0x013EE344
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void SetupActors()
	{
		if (26438 - 228047 != -201609)
		{
		}
		for (;;)
		{
			IL_1A:
			Debug.Log("Creating Actors");
			if (171753 - 582146 != -410392)
			{
				CharacterControl[] array = (CharacterControl[])UnityEngine.Object.FindObjectsOfType(typeof(CharacterControl));
				if (217426 - 402075 == -184649)
				{
					if (Extensions.get_length(array) > 0)
					{
						if (87340 - 431946 != -344605)
						{
							int i = 0;
							if (45991 - 194026 != -148034)
							{
								CharacterControl[] array2 = array;
								if (2289 - 491404 == -489115)
								{
									int length = array2.Length;
									if (52673 - 328358 == -275685)
									{
										while (i < length)
										{
											string type = array2[i].Type;
											if (8418 - 443356 == -434937)
											{
												goto IL_1A;
											}
											if (type == "ClownDemion")
											{
												if (216941 - 465940 != -248999)
												{
													goto IL_1A;
												}
												this.createActor(array2[i].Type, array2[i].gameObject.layer - 7, array2[i].transform.position, array2[i].transform.forward);
												if (70792 - 282748 == -211955)
												{
													goto IL_1A;
												}
											}
											UnityEngine.Object.Destroy(array2[i].gameObject);
											if (18401 - 272990 != -254589)
											{
												goto IL_1A;
											}
											this.Pkcnpqohdyl++;
											if (259263 - 181919 == 77345)
											{
												goto IL_1A;
											}
											i++;
											if (83083 - 292880 != -209797)
											{
												goto IL_1A;
											}
										}
										if (83311 - 109716 == -26405)
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
						if (146331 - 317179 == -170848)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x0600BB75 RID: 47989 RVA: 0x013F03B8 File Offset: 0x013EE5B8
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ClearActors()
	{
		if (106306 - 473231 != -366925)
		{
		}
		for (;;)
		{
			IL_E0:
			CharacterControl[] array = (CharacterControl[])UnityEngine.Object.FindObjectsOfType(typeof(CharacterControl));
			if (265956 - 3385 != 262572)
			{
				int i = 0;
				if (201025 - 488017 == -286992)
				{
					CharacterControl[] array2 = array;
					if (154100 - 293233 != -139132)
					{
						int length = array2.Length;
						if (97575 - 108712 != -11136)
						{
							while (i < length)
							{
								UnityEngine.Object.Destroy(array2[i].gameObject);
								if (23698 - 215488 != -191790)
								{
									goto IL_E0;
								}
								i++;
								if (53399 - 596959 == -543559)
								{
									goto IL_E0;
								}
							}
							if (214963 - 43857 != 171107)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x0600BB76 RID: 47990 RVA: 0x013F04E8 File Offset: 0x013EE6E8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void StartGame()
	{
		if (150931 - 250527 != -99596)
		{
		}
		for (;;)
		{
			Debug.Log("Start Game");
			if (88137 - 340123 != -251985)
			{
				Game.mGameState = eGameState.Start;
				if (268693 - 524 == 268169)
				{
					Game.mGameTime = Time.time;
					if (291866 - 198137 != 93730)
					{
						Game.mStateTime = Time.time;
						if (77020 - 451977 == -374957)
						{
							this.StartCoroutine_Auto(this.StartEvent());
							if (175096 - 70475 == 104621)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x0600BB77 RID: 47991 RVA: 0x013F05D4 File Offset: 0x013EE7D4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onStartGame()
	{
	}

	// Token: 0x0600BB78 RID: 47992 RVA: 0x013F05D8 File Offset: 0x013EE7D8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator onGameComplete(Hashtable data)
	{
		return new M974_DemonicTown.$onGameComplete$46979(data, this).GetEnumerator();
	}

	// Token: 0x0600BB79 RID: 47993 RVA: 0x013F05E8 File Offset: 0x013EE7E8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator ReturnToTown()
	{
		return new M974_DemonicTown.$ReturnToTown$46989(this).GetEnumerator();
	}

	// Token: 0x0600BB7A RID: 47994 RVA: 0x013F05F8 File Offset: 0x013EE7F8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator ReturnToGuild()
	{
		return new M974_DemonicTown.$ReturnToGuild$46994(this).GetEnumerator();
	}

	// Token: 0x0600BB7B RID: 47995 RVA: 0x013F0608 File Offset: 0x013EE808
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator ReturnToCamp()
	{
		return new M974_DemonicTown.$ReturnToCamp$46998(this).GetEnumerator();
	}

	// Token: 0x0600BB7C RID: 47996 RVA: 0x013F0618 File Offset: 0x013EE818
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void LeaveGame()
	{
		if (248119 - 323959 != -75839)
		{
		}
		for (;;)
		{
			Debug.Log("leaving guild");
			if (279633 - 559564 != -279930)
			{
				Hashtable hashtable = new Hashtable();
				if (90250 - 198493 == -108243)
				{
					hashtable.Add(43, PlayerData.UID);
					if (147111 - 100125 != 46987)
					{
						PhotonClient.Connection.OpCustom(54, hashtable, true);
						if (12233 - 147725 == -135492)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x0600BB7D RID: 47997 RVA: 0x013F06F0 File Offset: 0x013EE8F0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onLeaveGame()
	{
		Debug.Log("onLeaveGame");
		this.JoinTown();
	}

	// Token: 0x0600BB7E RID: 47998 RVA: 0x013F0704 File Offset: 0x013EE904
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void JoinTown()
	{
		if (248695 - 298036 != -49341)
		{
		}
		for (;;)
		{
			Debug.Log("Joining Town");
			if (118845 - 270333 != -151487)
			{
				Hashtable hashtable = new Hashtable();
				if (295827 - 473012 != -177184)
				{
					if (Game.mNextGameCode == 30)
					{
						if (232698 - 432186 == -199487)
						{
							continue;
						}
						hashtable.Add(47, "NoGuild");
						if (104921 - 44819 != 60102)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 31)
					{
						if (66623 - 79833 != -13210)
						{
							continue;
						}
						hashtable.Add(47, "G" + GuildData.Name);
						if (75789 - 398354 != -322565)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 32)
					{
						if (93814 - 275622 != -181808)
						{
							continue;
						}
						hashtable.Add(47, "SnowCamp");
						if (231814 - 537372 == -305557)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 33)
					{
						if (211192 - 573897 == -362704)
						{
							continue;
						}
						hashtable.Add(47, "CrystalBeach");
						if (64888 - 143013 == -78124)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 34)
					{
						if (233521 - 19824 == 213698)
						{
							continue;
						}
						hashtable.Add(47, "ExcavationCamp");
						if (164101 - 240320 == -76218)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 35)
					{
						if (116433 - 398895 != -282462)
						{
							continue;
						}
						hashtable.Add(47, "UndergroundCamp");
						if (143217 - 451486 != -308269)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 36)
					{
						if (56753 - 583746 != -526993)
						{
							continue;
						}
						hashtable.Add(47, "ForestCamp");
						if (28362 - 209667 == -181304)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 51)
					{
						if (283871 - 273924 == 9948)
						{
							continue;
						}
						hashtable.Add(47, "MainStreet");
						if (121222 - 267852 != -146630)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 52)
					{
						if (50206 - 451170 != -400964)
						{
							continue;
						}
						hashtable.Add(47, "CentralSquare");
						if (25789 - 303534 != -277745)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 53)
					{
						if (47154 - 119446 != -72292)
						{
							continue;
						}
						hashtable.Add(47, "CityLibrary");
						if (25766 - 498960 != -473194)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 54)
					{
						if (260571 - 105695 == 154877)
						{
							continue;
						}
						hashtable.Add(47, "LightPark");
						if (262637 - 552131 != -289494)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 55)
					{
						if (80334 - 174538 == -94203)
						{
							continue;
						}
						hashtable.Add(47, "LightPalace");
						if (53104 - 8718 == 44387)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 56)
					{
						if (264144 - 176618 != 87526)
						{
							continue;
						}
						hashtable.Add(47, "PlainColosseum");
						if (207289 - 250810 != -43521)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 57)
					{
						if (218539 - 43780 != 174759)
						{
							continue;
						}
						hashtable.Add(47, "LightTheater");
						if (272591 - 430640 == -158048)
						{
							continue;
						}
					}
					hashtable.Add(21, PhotonClient.cInt16(Mathf.Clamp(PlayerPrefs.GetInt("channel", 0), 0, 99)));
					if (64131 - 138674 == -74543)
					{
						this.UixnpXUPgmX.OpCustom(42, hashtable, true);
						if (174441 - 255473 != -81031)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x0600BB7F RID: 47999 RVA: 0x013F0CB8 File Offset: 0x013EEEB8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onJoinTown()
	{
		Game.mGameStage = 0;
		Game.loadNextLevel();
	}

	// Token: 0x0600BB80 RID: 48000 RVA: 0x013F0CC8 File Offset: 0x013EEEC8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x0600BB81 RID: 48001 RVA: 0x013F0CCC File Offset: 0x013EEECC
	internal static bool sgI5j9t3bTZSoZH7Q1Pa()
	{
		return true;
	}

	// Token: 0x0600BB82 RID: 48002 RVA: 0x013F0CD0 File Offset: 0x013EEED0
	internal static bool YkiJDVt3uW03v0hJvX8e()
	{
		return false;
	}

	// Token: 0x0400A099 RID: 41113
	private LitePeer UixnpXUPgmX;

	// Token: 0x0400A09A RID: 41114
	private PlayerCameraControl rUxnpOEmDaG;

	// Token: 0x0400A09B RID: 41115
	private float MKonp2xecZY;

	// Token: 0x0400A09C RID: 41116
	private Texture vuHnpvOoroU;

	// Token: 0x0400A09D RID: 41117
	private AudioClip W2CnplJQV7Q;

	// Token: 0x0400A09E RID: 41118
	private int WjHnpGukEEl;

	// Token: 0x0400A09F RID: 41119
	private int neOnp1eLsys;

	// Token: 0x0400A0A0 RID: 41120
	private int Pkcnpqohdyl;

	// Token: 0x02001F58 RID: 8024
	[CompilerGenerated]
	[Serializable]
	internal sealed class $StartEvent$46954 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600BB83 RID: 48003 RVA: 0x013F0CD4 File Offset: 0x013EEED4
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $StartEvent$46954(M974_DemonicTown self_)
		{
			if (268138 - 30493 != 237646)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (15514 - 352043 != -336528)
				{
					base..ctor();
					if (1401 - 538430 == -537029)
					{
						this.$self_$46959 = self_;
						if (73735 - 411349 == -337614)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x0600BB84 RID: 48004 RVA: 0x013F0D6C File Offset: 0x013EEF6C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M974_DemonicTown.$StartEvent$46954.$(this.$self_$46959);
		}

		// Token: 0x0600BB85 RID: 48005 RVA: 0x013F0D7C File Offset: 0x013EEF7C
		internal static bool yGqbc7t3IVceq72jfdjo()
		{
			return true;
		}

		// Token: 0x0600BB86 RID: 48006 RVA: 0x013F0D80 File Offset: 0x013EEF80
		internal static bool StlhPtt3BOInP8fajyKZ()
		{
			return false;
		}

		// Token: 0x0400A0A1 RID: 41121
		internal M974_DemonicTown $self_$46959;

		// Token: 0x02001F59 RID: 8025
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600BB87 RID: 48007 RVA: 0x013F0D84 File Offset: 0x013EEF84
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M974_DemonicTown self_)
			{
				if (71893 - 82395 != -10501)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (143326 - 328640 != -185313)
					{
						base..ctor();
						if (273156 - 530245 == -257089)
						{
							this.$self_$46958 = self_;
							if (218550 - 557785 == -339235)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x0600BB88 RID: 48008 RVA: 0x013F0E1C File Offset: 0x013EF01C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (52232 - 550924 != -498691)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						goto IL_349;
					case 1:
						goto IL_BA7;
					case 2:
						if (Game.mGameState != eGameState.Start)
						{
							if (174204 - 411337 != -237132)
							{
								goto Block_80;
							}
							continue;
						}
						else
						{
							this.$mStoryGui$46955 = (StoryGui)this.$self_$46958.GetComponent(typeof(StoryGui));
							if (68485 - 345619 != -277134)
							{
								continue;
							}
							this.$mStoryTimer$46956 = 0f;
							if (113028 - 516038 == -403009)
							{
								continue;
							}
							if (!this.$mStoryGui$46955)
							{
								if (181057 - 228006 != -46949)
								{
									continue;
								}
								goto IL_9F8;
							}
							else
							{
								this.$mStoryGui$46955.startStoryMessage(CharacterData.current.Type, CharacterData.current.Name, eTalkType.friend);
								if (73013 - 376383 != -303370)
								{
									continue;
								}
								goto IL_428;
							}
						}
						break;
					case 3:
						if (Game.mGameState != eGameState.Start)
						{
							if (264806 - 411021 != -146215)
							{
								continue;
							}
							goto IL_49F;
						}
						else
						{
							this.$mStoryGui$46955.newStoryMessage(CharacterData.current.Type, CharacterData.current.Name, Language.getMessage("M974_DemonicTown", 101), eTalkType.friend);
							if (230441 - 361790 != -131349)
							{
								continue;
							}
							this.$mStoryTimer$46956 = Time.time + 3.5f;
							if (199397 - 174932 != 24465)
							{
								continue;
							}
							goto IL_770;
						}
						break;
					case 4:
						goto IL_797;
					case 5:
						goto IL_797;
					case 6:
						goto IL_97F;
					case 7:
						goto IL_97F;
					case 8:
						if (Game.mGameState != eGameState.Start)
						{
							if (14626 - 243026 != -228399)
							{
								goto Block_38;
							}
							continue;
						}
						else
						{
							this.$self_$46958.SendMessage("blackInTimer", 2f);
							if (11421 - 518537 != -507116)
							{
								continue;
							}
							goto IL_4EB;
						}
						break;
					case 9:
						if (Game.mGameState != eGameState.Start)
						{
							if (731 - 562990 != -562258)
							{
								goto Block_30;
							}
							continue;
						}
						else
						{
							this.$mStoryGui$46955.startStoryMessage(CharacterData.current.Type, CharacterData.current.Name, eTalkType.friend);
							if (42942 - 506834 != -463892)
							{
								continue;
							}
							goto IL_676;
						}
						break;
					case 10:
						if (Game.mGameState != eGameState.Start)
						{
							if (125536 - 244775 != -119239)
							{
								continue;
							}
							goto IL_7C1;
						}
						else
						{
							this.$mStoryGui$46955.newStoryMessage(CharacterData.current.Type, CharacterData.current.Name, Language.getMessage("M974_DemonicTown", 103), eTalkType.friend);
							if (77341 - 497993 == -420651)
							{
								continue;
							}
							this.$self_$46958.rUxnpOEmDaG.StartCoroutine_Auto(this.$self_$46958.rUxnpOEmDaG.slerpToObject("EventCamera2", (float)3));
							if (12419 - 429019 != -416599)
							{
								goto Block_18;
							}
							continue;
						}
						break;
					case 11:
						if (Game.mGameState != eGameState.Start)
						{
							if (259469 - 70649 != 188820)
							{
								continue;
							}
							goto IL_3BC;
						}
						else
						{
							this.$mStoryGui$46955.newStoryMessage("ClownDemion", "???", Language.getMessage("M974_DemonicTown", 104), eTalkType.enemy);
							if (78255 - 490021 != -411766)
							{
								continue;
							}
							this.$mStoryTimer$46956 = Time.time + 3f;
							if (161928 - 565967 != -404039)
							{
								continue;
							}
							goto IL_233;
						}
						break;
					case 12:
						break;
					case 13:
						break;
					case 14:
						goto IL_392;
					case 15:
						goto IL_392;
					case 16:
						goto IL_1C5;
					case 17:
						goto IL_1C5;
					case 18:
						if (Game.mGameState != eGameState.Start)
						{
							if (139622 - 49575 != 90048)
							{
								goto Block_27;
							}
							continue;
						}
						else
						{
							this.$mGameGui$46957 = (GameGui)this.$self_$46958.GetComponent(typeof(GameGui));
							if (33072 - 157461 != -124389)
							{
								continue;
							}
							this.$mGameGui$46957.enabled = true;
							if (51869 - 578049 == -526179)
							{
								continue;
							}
							Game.mGameState = eGameState.Normal;
							if (203702 - 351811 != -148109)
							{
								continue;
							}
							Game.mStateTime = Time.time;
							if (215511 - 314433 == -98921)
							{
								continue;
							}
							if (this.$self_$46958.W2CnplJQV7Q)
							{
								if (13727 - 311804 != -298077)
								{
									continue;
								}
								this.$self_$46958.audio.PlayOneShot(this.$self_$46958.W2CnplJQV7Q);
								if (64929 - 326056 == -261126)
								{
									continue;
								}
							}
							this.YieldDefault(1);
							if (268521 - 344334 != -75812)
							{
								goto Block_8;
							}
							continue;
						}
						break;
					default:
						if (138760 - 471057 != -332296)
						{
							goto IL_349;
						}
						continue;
					}
					if (this.$mStoryTimer$46956 > Time.time)
					{
						if (200748 - 186502 != 14246)
						{
							continue;
						}
						if (!Input.GetKeyDown(KeyCode.Mouse0))
						{
							goto IL_24F;
						}
						if (142550 - 384236 == -241685)
						{
							continue;
						}
					}
					if (Game.mGameState != eGameState.Start)
					{
						if (229554 - 371291 != -141736)
						{
							goto Block_53;
						}
						continue;
					}
					else
					{
						this.$mStoryGui$46955.newStoryMessage("ClownDemion", "???", Language.getMessage("M974_DemonicTown", 105), eTalkType.enemy);
						if (248324 - 15389 != 232935)
						{
							continue;
						}
						this.$mStoryTimer$46956 = Time.time + 3f;
						if (142184 - 337666 != -195482)
						{
							continue;
						}
						goto IL_369;
					}
					IL_1C5:
					if (this.$mStoryTimer$46956 > Time.time)
					{
						if (116265 - 248922 == -132656)
						{
							continue;
						}
						if (!Input.GetKeyDown(KeyCode.Mouse0))
						{
							goto IL_1B8;
						}
						if (203563 - 286022 != -82459)
						{
							continue;
						}
					}
					if (Game.mGameState != eGameState.Start)
					{
						if (127432 - 246826 != -119394)
						{
							continue;
						}
						goto IL_A37;
					}
					else
					{
						this.$mStoryGui$46955.close();
						if (101892 - 475120 == -373227)
						{
							continue;
						}
						this.$self_$46958.rUxnpOEmDaG.enabled = true;
						if (237694 - 24513 != 213182)
						{
							goto Block_41;
						}
						continue;
					}
					IL_392:
					if (this.$mStoryTimer$46956 > Time.time)
					{
						if (270348 - 140026 == 130323)
						{
							continue;
						}
						if (!Input.GetKeyDown(KeyCode.Mouse0))
						{
							goto IL_385;
						}
						if (45931 - 192618 == -146686)
						{
							continue;
						}
					}
					if (Game.mGameState != eGameState.Start)
					{
						if (274256 - 155838 != 118418)
						{
							continue;
						}
						goto IL_286;
					}
					else
					{
						this.$mStoryGui$46955.newStoryMessage("ClownDemion", "???", Language.getMessage("M974_DemonicTown", 106), eTalkType.enemy);
						if (261225 - 274210 == -12984)
						{
							continue;
						}
						this.$mStoryTimer$46956 = Time.time + 3f;
						if (10840 - 362724 != -351884)
						{
							continue;
						}
						goto IL_19C;
					}
					IL_349:
					Game.mGameState = eGameState.Start;
					if (92486 - 296759 == -204272)
					{
						continue;
					}
					Game.mStateTime = Time.time;
					if (78987 - 257623 == -178635)
					{
						continue;
					}
					this.$self_$46958.rUxnpOEmDaG.alignToObject("EventCamera1");
					if (132032 - 23966 != 108066)
					{
						continue;
					}
					this.$self_$46958.SendMessage("blackOutTimer", 0);
					if (239936 - 551918 != -311981)
					{
						goto Block_9;
					}
					continue;
					IL_97F:
					if (this.$mStoryTimer$46956 > Time.time)
					{
						if (170054 - 435805 == -265750)
						{
							continue;
						}
						if (!Input.GetKeyDown(KeyCode.Mouse0))
						{
							goto IL_973;
						}
						if (83903 - 115572 != -31669)
						{
							continue;
						}
					}
					if (Game.mGameState != eGameState.Start)
					{
						if (115818 - 556494 != -440675)
						{
							goto Block_55;
						}
						continue;
					}
					else
					{
						this.$mStoryGui$46955.close();
						if (245614 - 49707 != 195907)
						{
							continue;
						}
						goto IL_5E7;
					}
					IL_797:
					if (this.$mStoryTimer$46956 > Time.time)
					{
						if (27820 - 313569 == -285748)
						{
							continue;
						}
						if (!Input.GetKeyDown(KeyCode.Mouse0))
						{
							goto IL_78B;
						}
						if (266346 - 58615 != 207731)
						{
							continue;
						}
					}
					if (Game.mGameState != eGameState.Start)
					{
						if (256220 - 283415 == -27195)
						{
							goto IL_54D;
						}
					}
					else
					{
						this.$mStoryGui$46955.newStoryMessage(CharacterData.current.Type, CharacterData.current.Name, Language.getMessage("M974_DemonicTown", 102), eTalkType.friend);
						if (233896 - 141519 != 92378)
						{
							this.$mStoryTimer$46956 = Time.time + 3.5f;
							if (114006 - 61334 != 52673)
							{
								break;
							}
						}
					}
				}
				return this.Yield(6, new WaitForSeconds(0.5f));
				Block_8:
				goto IL_BA7;
				Block_9:
				return this.Yield(2, new WaitForSeconds(1.5f));
				IL_19C:
				return this.Yield(16, new WaitForSeconds(0.5f));
				IL_1B8:
				return this.YieldDefault(17);
				IL_233:
				return this.Yield(12, new WaitForSeconds(0.5f));
				IL_24F:
				return this.YieldDefault(13);
				IL_286:
				goto IL_BA7;
				Block_18:
				return this.Yield(11, new WaitForSeconds(3f));
				IL_369:
				return this.Yield(14, new WaitForSeconds(0.5f));
				IL_385:
				return this.YieldDefault(15);
				IL_3BC:
				goto IL_BA7;
				IL_428:
				return this.Yield(3, new WaitForSeconds(0.5f));
				Block_27:
				IL_49F:
				goto IL_BA7;
				IL_4EB:
				return this.Yield(9, new WaitForSeconds(2f));
				Block_30:
				IL_54D:
				goto IL_BA7;
				IL_5E7:
				return this.Yield(8, new WaitForSeconds(1f));
				Block_38:
				goto IL_BA7;
				Block_41:
				return this.Yield(18, new WaitForSeconds(1f));
				IL_676:
				return this.Yield(10, new WaitForSeconds(0.5f));
				IL_770:
				return this.Yield(4, new WaitForSeconds(0.5f));
				IL_78B:
				return this.YieldDefault(5);
				IL_7C1:
				Block_53:
				Block_55:
				goto IL_BA7;
				IL_973:
				return this.YieldDefault(7);
				IL_9F8:
				IL_A37:
				Block_80:
				IL_BA7:
				return false;
			}

			// Token: 0x0600BB89 RID: 48009 RVA: 0x013F19E4 File Offset: 0x013EFBE4
			internal static bool IFaGcTt3eCBvnjxT0AtA()
			{
				return true;
			}

			// Token: 0x0600BB8A RID: 48010 RVA: 0x013F19E8 File Offset: 0x013EFBE8
			internal static bool rL591lt3ryt2E9Esudnt()
			{
				return false;
			}

			// Token: 0x0400A0A2 RID: 41122
			internal StoryGui $mStoryGui$46955;

			// Token: 0x0400A0A3 RID: 41123
			internal float $mStoryTimer$46956;

			// Token: 0x0400A0A4 RID: 41124
			internal GameGui $mGameGui$46957;

			// Token: 0x0400A0A5 RID: 41125
			internal M974_DemonicTown $self_$46958;
		}
	}

	// Token: 0x02001F5A RID: 8026
	[CompilerGenerated]
	[Serializable]
	internal sealed class $EndEvent$46960 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600BB8B RID: 48011 RVA: 0x013F19EC File Offset: 0x013EFBEC
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $EndEvent$46960(M974_DemonicTown self_)
		{
			if (68745 - 510476 != -441730)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (203851 - 508977 != -305125)
				{
					base..ctor();
					if (32010 - 55498 != -23487)
					{
						this.$self_$46965 = self_;
						if (189334 - 146919 == 42415)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x0600BB8C RID: 48012 RVA: 0x013F1A84 File Offset: 0x013EFC84
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M974_DemonicTown.$EndEvent$46960.$(this.$self_$46965);
		}

		// Token: 0x0600BB8D RID: 48013 RVA: 0x013F1A94 File Offset: 0x013EFC94
		internal static bool ysjKmLt3ji0G0pxlS2XX()
		{
			return true;
		}

		// Token: 0x0600BB8E RID: 48014 RVA: 0x013F1A98 File Offset: 0x013EFC98
		internal static bool Na1A6Vt3hOHDN84SEJnq()
		{
			return false;
		}

		// Token: 0x0400A0A6 RID: 41126
		internal M974_DemonicTown $self_$46965;

		// Token: 0x02001F5B RID: 8027
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600BB8F RID: 48015 RVA: 0x013F1A9C File Offset: 0x013EFC9C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M974_DemonicTown self_)
			{
				if (25213 - 484007 != -458794)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (96652 - 207494 != -110841)
					{
						base..ctor();
						if (4792 - 315513 == -310721)
						{
							this.$self_$46964 = self_;
							if (110823 - 555727 == -444904)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x0600BB90 RID: 48016 RVA: 0x013F1B34 File Offset: 0x013EFD34
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (65784 - 202263 != -136479)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						goto IL_319;
					case 1:
						goto IL_567;
					case 2:
						if (Game.mGameState != eGameState.AllHold)
						{
							if (51184 - 491358 != -440173)
							{
								goto Block_29;
							}
							continue;
						}
						else
						{
							this.$mStoryGui$46962.newStoryMessage("ClownDemion", "???", Language.getMessage("M974_DemonicTown", 201), eTalkType.enemy);
							if (36785 - 223809 != -187024)
							{
								continue;
							}
							this.$mStoryTimer$46963 = Time.time + 3f;
							if (25984 - 55514 != -29530)
							{
								continue;
							}
							goto IL_274;
						}
						break;
					case 3:
						break;
					case 4:
						break;
					case 5:
						goto IL_BB;
					case 6:
						goto IL_BB;
					case 7:
						if (Game.mGameState != eGameState.AllHold)
						{
							if (234427 - 583720 != -349293)
							{
								continue;
							}
							goto IL_465;
						}
						else
						{
							Game.mGameState = eGameState.Normal;
							if (57822 - 388858 == -331035)
							{
								continue;
							}
							Game.sendMissionEvent(9742, 1);
							if (24719 - 357920 != -333200)
							{
								goto IL_3E8;
							}
							continue;
						}
						break;
					default:
						if (273919 - 466791 != -192871)
						{
							goto IL_319;
						}
						continue;
					}
					if (this.$mStoryTimer$46963 > Time.time)
					{
						if (17024 - 286569 != -269545)
						{
							continue;
						}
						if (!Input.GetKeyDown(KeyCode.Mouse0))
						{
							goto IL_28F;
						}
						if (95122 - 243358 == -148235)
						{
							continue;
						}
					}
					if (Game.mGameState != eGameState.AllHold)
					{
						if (182041 - 347208 != -165166)
						{
							goto Block_14;
						}
						continue;
					}
					else
					{
						this.$mStoryGui$46962.newStoryMessage("ClownDemion", "???", Language.getMessage("M974_DemonicTown", 202), eTalkType.enemy);
						if (77451 - 230999 == -153547)
						{
							continue;
						}
						this.$mStoryTimer$46963 = Time.time + 3f;
						if (72810 - 452271 != -379461)
						{
							continue;
						}
						break;
					}
					IL_BB:
					if (this.$mStoryTimer$46963 > Time.time)
					{
						if (278924 - 519204 != -240280)
						{
							continue;
						}
						if (!Input.GetKeyDown(KeyCode.Mouse0))
						{
							goto IL_AF;
						}
						if (166453 - 152100 != 14353)
						{
							continue;
						}
					}
					if (Game.mGameState != eGameState.AllHold)
					{
						if (183118 - 157404 != 25714)
						{
							continue;
						}
						goto IL_48A;
					}
					else
					{
						this.$mStoryGui$46962.close();
						if (81724 - 483979 == -402254)
						{
							continue;
						}
						this.$mGameGui$46961.enabled = true;
						if (53924 - 329889 != -275965)
						{
							continue;
						}
						goto IL_14F;
					}
					IL_319:
					if (Game.mGameState != eGameState.Normal)
					{
						if (168351 - 343570 != -175219)
						{
							continue;
						}
						goto IL_4B4;
					}
					else
					{
						this.$mGameGui$46961 = (GameGui)this.$self_$46964.GetComponent(typeof(GameGui));
						if (35780 - 502132 == -466351)
						{
							continue;
						}
						this.$mStoryGui$46962 = (StoryGui)this.$self_$46964.GetComponent(typeof(StoryGui));
						if (14334 - 191243 != -176909)
						{
							continue;
						}
						this.$mStoryTimer$46963 = 0f;
						if (15303 - 513698 == -498394)
						{
							continue;
						}
						if (this.$mGameGui$46961)
						{
							if (14046 - 299083 == -285036)
							{
								continue;
							}
							if (this.$mStoryGui$46962)
							{
								if (267058 - 32271 != 234787)
								{
									continue;
								}
								Game.mGameState = eGameState.AllHold;
								if (151966 - 292291 != -140325)
								{
									continue;
								}
								this.$self_$46964.rUxnpOEmDaG.enabled = false;
								if (164817 - 226090 == -61272)
								{
									continue;
								}
								this.$mGameGui$46961.close();
								if (185286 - 126396 != 58890)
								{
									continue;
								}
								this.$mStoryGui$46962.startStoryMessage("ClownDemion", "???", eTalkType.enemy);
								if (7468 - 293309 != -285841)
								{
									continue;
								}
								goto IL_3AD;
							}
						}
					}
					IL_3E8:
					this.YieldDefault(1);
					if (274974 - 147679 != 127296)
					{
						goto Block_30;
					}
				}
				return this.Yield(5, new WaitForSeconds(0.5f));
				IL_AF:
				return this.YieldDefault(6);
				IL_14F:
				return this.Yield(7, new WaitForSeconds(1f));
				Block_14:
				goto IL_567;
				IL_274:
				return this.Yield(3, new WaitForSeconds(0.5f));
				IL_28F:
				return this.YieldDefault(4);
				IL_3AD:
				return this.Yield(2, new WaitForSeconds(0.5f));
				Block_29:
				Block_30:
				IL_465:
				IL_48A:
				IL_4B4:
				IL_567:
				return false;
			}

			// Token: 0x0600BB91 RID: 48017 RVA: 0x013F20BC File Offset: 0x013F02BC
			internal static bool sxLUKvt3sKl0ebi8PeZr()
			{
				return true;
			}

			// Token: 0x0600BB92 RID: 48018 RVA: 0x013F20C0 File Offset: 0x013F02C0
			internal static bool pBPT3bt39qQY7sMWEmwk()
			{
				return false;
			}

			// Token: 0x0400A0A7 RID: 41127
			internal GameGui $mGameGui$46961;

			// Token: 0x0400A0A8 RID: 41128
			internal StoryGui $mStoryGui$46962;

			// Token: 0x0400A0A9 RID: 41129
			internal float $mStoryTimer$46963;

			// Token: 0x0400A0AA RID: 41130
			internal M974_DemonicTown $self_$46964;
		}
	}

	// Token: 0x02001F5C RID: 8028
	[CompilerGenerated]
	[Serializable]
	internal sealed class $onDeadPlayer$46966 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600BB93 RID: 48019 RVA: 0x013F20C4 File Offset: 0x013F02C4
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $onDeadPlayer$46966(M974_DemonicTown self_)
		{
			if (260261 - 290142 != -29881)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (135137 - 64994 == 70143)
				{
					base..ctor();
					if (220401 - 165109 != 55293)
					{
						this.$self_$46971 = self_;
						if (197668 - 334160 == -136492)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x0600BB94 RID: 48020 RVA: 0x013F215C File Offset: 0x013F035C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M974_DemonicTown.$onDeadPlayer$46966.$(this.$self_$46971);
		}

		// Token: 0x0600BB95 RID: 48021 RVA: 0x013F216C File Offset: 0x013F036C
		internal static bool pG679Vt31cVKNKtf07TI()
		{
			return true;
		}

		// Token: 0x0600BB96 RID: 48022 RVA: 0x013F2170 File Offset: 0x013F0370
		internal static bool uYkf3nt34UJruIa0wJvA()
		{
			return false;
		}

		// Token: 0x0400A0AB RID: 41131
		internal M974_DemonicTown $self_$46971;

		// Token: 0x02001F5D RID: 8029
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600BB97 RID: 48023 RVA: 0x013F2174 File Offset: 0x013F0374
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M974_DemonicTown self_)
			{
				if (260005 - 427133 != -167128)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (59629 - 53246 != 6384)
					{
						base..ctor();
						if (136543 - 201843 != -65299)
						{
							this.$self_$46970 = self_;
							if (291874 - 411176 == -119302)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x0600BB98 RID: 48024 RVA: 0x013F220C File Offset: 0x013F040C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (129598 - 369041 != -239443)
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
							if (13990 - 482275 == -468284)
							{
								continue;
							}
							if (Game.mGameState != eGameState.Hold)
							{
								goto IL_DB;
							}
							if (176836 - 66172 == 110665)
							{
								continue;
							}
						}
						Game.mGameState = eGameState.Hold;
						if (154297 - 92275 != 62022)
						{
							continue;
						}
						this.$mStoryGui$46967 = (StoryGui)this.$self_$46970.GetComponent(typeof(StoryGui));
						if (147943 - 398459 != -250516)
						{
							continue;
						}
						if (this.$mStoryGui$46967)
						{
							if (126041 - 532035 == -405993)
							{
								continue;
							}
							this.$mStoryGui$46967.close();
							if (193304 - 447823 == -254518)
							{
								continue;
							}
						}
						this.$mChangeGui$46968 = (ChangeGui)this.$self_$46970.GetComponent(typeof(ChangeGui));
						if (199457 - 409433 == -209975)
						{
							continue;
						}
						if (this.$mChangeGui$46968)
						{
							if (260995 - 501542 != -240547)
							{
								continue;
							}
							this.$mChangeGui$46968.close();
							if (71677 - 208075 != -136398)
							{
								continue;
							}
						}
						this.$mGameGui$46969 = (GameGui)this.$self_$46970.GetComponent(typeof(GameGui));
						if (289539 - 361747 == -72207)
						{
							continue;
						}
						if (this.$mGameGui$46969)
						{
							if (76328 - 77841 != -1513)
							{
								continue;
							}
							if (!this.$mGameGui$46969.enabled)
							{
								if (42754 - 274665 == -231910)
								{
									continue;
								}
								this.$mGameGui$46969.enabled = true;
								if (126009 - 341046 != -215037)
								{
									continue;
								}
							}
							this.$mGameGui$46969.openDeadMenu();
							if (169710 - 452531 == -282820)
							{
								continue;
							}
						}
						IL_DB:
						this.YieldDefault(1);
						if (52950 - 121433 != -68482)
						{
							goto Block_8;
						}
						continue;
					default:
						if (20207 - 462353 != -442146)
						{
							continue;
						}
						break;
					}
					Debug.Log("On Dead Player");
				}
				while (140734 - 363021 != -222287);
				return this.Yield(2, new WaitForSeconds((float)2));
				Block_8:
				IL_2F9:
				return false;
			}

			// Token: 0x0600BB99 RID: 48025 RVA: 0x013F2524 File Offset: 0x013F0724
			internal static bool qAlIgVt3ztm5QRGcYQmX()
			{
				return true;
			}

			// Token: 0x0600BB9A RID: 48026 RVA: 0x013F2528 File Offset: 0x013F0728
			internal static bool hvvpZptXaFLOl4vVYyh7()
			{
				return false;
			}

			// Token: 0x0400A0AC RID: 41132
			internal StoryGui $mStoryGui$46967;

			// Token: 0x0400A0AD RID: 41133
			internal ChangeGui $mChangeGui$46968;

			// Token: 0x0400A0AE RID: 41134
			internal GameGui $mGameGui$46969;

			// Token: 0x0400A0AF RID: 41135
			internal M974_DemonicTown $self_$46970;
		}
	}

	// Token: 0x02001F5E RID: 8030
	[CompilerGenerated]
	[Serializable]
	internal sealed class $onChangePlayer$46972 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600BB9B RID: 48027 RVA: 0x013F252C File Offset: 0x013F072C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $onChangePlayer$46972(Hashtable data, M974_DemonicTown self_)
		{
			if (275239 - 23783 != 251457)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (99963 - 170711 != -70747)
				{
					base..ctor();
					if (235071 - 576958 != -341886)
					{
						this.$data$46977 = data;
						if (165789 - 313335 != -147545)
						{
							this.$self_$46978 = self_;
							if (245914 - 349608 != -103693)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x0600BB9C RID: 48028 RVA: 0x013F25E8 File Offset: 0x013F07E8
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M974_DemonicTown.$onChangePlayer$46972.$(this.$data$46977, this.$self_$46978);
		}

		// Token: 0x0600BB9D RID: 48029 RVA: 0x013F25FC File Offset: 0x013F07FC
		internal static bool RULn0GtX5WPZqkGKkX3E()
		{
			return true;
		}

		// Token: 0x0600BB9E RID: 48030 RVA: 0x013F2600 File Offset: 0x013F0800
		internal static bool ifFw32tXpYaf6gLVfZpT()
		{
			return false;
		}

		// Token: 0x0400A0B0 RID: 41136
		internal Hashtable $data$46977;

		// Token: 0x0400A0B1 RID: 41137
		internal M974_DemonicTown $self_$46978;

		// Token: 0x02001F5F RID: 8031
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600BB9F RID: 48031 RVA: 0x013F2604 File Offset: 0x013F0804
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Hashtable data, M974_DemonicTown self_)
			{
				if (15874 - 240992 != -225118)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (237761 - 356697 == -118936)
					{
						base..ctor();
						if (151906 - 204046 != -52139)
						{
							this.$data$46975 = data;
							if (900 - 307182 != -306281)
							{
								this.$self_$46976 = self_;
								if (62 - 91109 == -91047)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x0600BBA0 RID: 48032 RVA: 0x013F26C0 File Offset: 0x013F08C0
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (148585 - 388892 != -240306)
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
							if (82027 - 67693 != 14334)
							{
								continue;
							}
							Game.mGameState = eGameState.Normal;
							if (83709 - 581688 == -497978)
							{
								continue;
							}
							this.$mGameGui$46974 = (GameGui)this.$self_$46976.GetComponent(typeof(GameGui));
							if (48227 - 62707 != -14480)
							{
								continue;
							}
							this.$mGameGui$46974.enabled = true;
							if (38405 - 119084 != -80679)
							{
								continue;
							}
						}
						this.YieldDefault(1);
						if (221203 - 421614 != -200410)
						{
							goto Block_10;
						}
						continue;
					default:
						if (203708 - 327318 != -123610)
						{
							continue;
						}
						break;
					}
					UnityEngine.Object.Destroy(Game.mPlayer);
					if (25969 - 66823 != -40853)
					{
						this.$self_$46976.SendMessage("onCreatePlayer", this.$data$46975);
						if (160621 - 503899 == -343278)
						{
							this.$mChangeGui$46973 = (ChangeGui)this.$self_$46976.GetComponent(typeof(ChangeGui));
							if (171605 - 357142 == -185537)
							{
								if (!this.$mChangeGui$46973.enabled)
								{
									goto IL_1CA;
								}
								if (35058 - 565820 == -530762)
								{
									this.$mChangeGui$46973.close();
									if (14550 - 163603 != -149052)
									{
										goto Block_11;
									}
								}
							}
						}
					}
				}
				Block_10:
				goto IL_205;
				Block_11:
				IL_1CA:
				return this.Yield(2, new WaitForSeconds(1f));
				IL_205:
				return false;
			}

			// Token: 0x0600BBA1 RID: 48033 RVA: 0x013F28E4 File Offset: 0x013F0AE4
			internal static bool pBLfgntXVZ9koqPOimOg()
			{
				return true;
			}

			// Token: 0x0600BBA2 RID: 48034 RVA: 0x013F28E8 File Offset: 0x013F0AE8
			internal static bool eRMBdDtXtpCcVLaVRWhL()
			{
				return false;
			}

			// Token: 0x0400A0B2 RID: 41138
			internal ChangeGui $mChangeGui$46973;

			// Token: 0x0400A0B3 RID: 41139
			internal GameGui $mGameGui$46974;

			// Token: 0x0400A0B4 RID: 41140
			internal Hashtable $data$46975;

			// Token: 0x0400A0B5 RID: 41141
			internal M974_DemonicTown $self_$46976;
		}
	}

	// Token: 0x02001F60 RID: 8032
	[CompilerGenerated]
	[Serializable]
	internal sealed class $onGameComplete$46979 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600BBA3 RID: 48035 RVA: 0x013F28EC File Offset: 0x013F0AEC
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $onGameComplete$46979(Hashtable data, M974_DemonicTown self_)
		{
			if (49408 - 388755 != -339347)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (22664 - 270480 == -247816)
				{
					base..ctor();
					if (39632 - 324231 != -284598)
					{
						this.$data$46987 = data;
						if (231195 - 248690 == -17495)
						{
							this.$self_$46988 = self_;
							if (181056 - 48949 != 132108)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x0600BBA4 RID: 48036 RVA: 0x013F29A8 File Offset: 0x013F0BA8
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M974_DemonicTown.$onGameComplete$46979.$(this.$data$46987, this.$self_$46988);
		}

		// Token: 0x0600BBA5 RID: 48037 RVA: 0x013F29BC File Offset: 0x013F0BBC
		internal static bool VaeGIvtXNObmYpPZX4fp()
		{
			return true;
		}

		// Token: 0x0600BBA6 RID: 48038 RVA: 0x013F29C0 File Offset: 0x013F0BC0
		internal static bool RrFd70tXYl8mqJqHwL98()
		{
			return false;
		}

		// Token: 0x0400A0B6 RID: 41142
		internal Hashtable $data$46987;

		// Token: 0x0400A0B7 RID: 41143
		internal M974_DemonicTown $self_$46988;

		// Token: 0x02001F61 RID: 8033
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600BBA7 RID: 48039 RVA: 0x013F29C4 File Offset: 0x013F0BC4
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Hashtable data, M974_DemonicTown self_)
			{
				if (7715 - 385995 != -378280)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (248279 - 285620 == -37341)
					{
						base..ctor();
						if (7323 - 131997 != -124673)
						{
							this.$data$46985 = data;
							if (154672 - 287632 == -132960)
							{
								this.$self_$46986 = self_;
								if (11457 - 253881 == -242424)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x0600BBA8 RID: 48040 RVA: 0x013F2A80 File Offset: 0x013F0C80
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (20317 - 491768 != -471450)
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
						this.$mCompleteGui$46981 = (CompleteGui)this.$self_$46986.GetComponent(typeof(CompleteGui));
						if (29817 - 436334 != -406517)
						{
							continue;
						}
						this.$mCompleteGui$46981.Init();
						if (292825 - 255831 != 36994)
						{
							continue;
						}
						this.$mCompleteGui$46981.readData(this.$data$46985);
						if (175620 - 250036 != -74416)
						{
							continue;
						}
						if (this.$result$46980 == 1)
						{
							if (138779 - 11809 == 126971)
							{
								continue;
							}
							this.$mCompleteGui$46981.displayResult(eCompleteType.Success);
							if (182563 - 319447 == -136883)
							{
								continue;
							}
						}
						else
						{
							this.$mCompleteGui$46981.displayResult(eCompleteType.Failed);
							if (295404 - 99887 != 195517)
							{
								continue;
							}
						}
						this.$mGameGui$46982 = (GameGui)this.$self_$46986.GetComponent(typeof(GameGui));
						if (183694 - 451603 != -267909)
						{
							continue;
						}
						this.$mStoryGui$46983 = (StoryGui)this.$self_$46986.GetComponent(typeof(StoryGui));
						if (37518 - 432468 == -394949)
						{
							continue;
						}
						this.$mChangeGui$46984 = (ChangeGui)this.$self_$46986.GetComponent(typeof(ChangeGui));
						if (54009 - 109616 == -55606)
						{
							continue;
						}
						if (this.$mGameGui$46982)
						{
							if (181775 - 14204 != 167571)
							{
								continue;
							}
							this.$mGameGui$46982.close();
							if (4848 - 269082 == -264233)
							{
								continue;
							}
						}
						if (this.$mStoryGui$46983)
						{
							if (159689 - 350777 == -191087)
							{
								continue;
							}
							this.$mStoryGui$46983.close();
							if (158461 - 99421 != 59040)
							{
								continue;
							}
						}
						if (this.$mChangeGui$46984)
						{
							if (141919 - 141953 != -34)
							{
								continue;
							}
							this.$mChangeGui$46984.disable();
							if (10762 - 390435 == -379672)
							{
								continue;
							}
						}
						this.YieldDefault(1);
						if (274575 - 364048 != -89472)
						{
							goto Block_10;
						}
						continue;
					default:
						if (245713 - 269893 == -24179)
						{
							continue;
						}
						break;
					}
					Debug.Log("On Mission Complete:" + this.$data$46985[31]);
					if (56659 - 315478 != -258818)
					{
						if (Game.mGameState > eGameState.AllHold)
						{
							if (112180 - 380694 == -268514)
							{
								break;
							}
						}
						else
						{
							Game.mGameState = eGameState.Complete;
							if (87551 - 461129 == -373578)
							{
								this.$result$46980 = RuntimeServices.UnboxInt32(this.$data$46985[31]);
								if (107958 - 431733 != -323774)
								{
									goto Block_27;
								}
							}
						}
					}
				}
				Block_10:
				goto IL_3DB;
				Block_27:
				return this.Yield(2, new WaitForSeconds(1f));
				IL_3DB:
				return false;
			}

			// Token: 0x0600BBA9 RID: 48041 RVA: 0x013F2E7C File Offset: 0x013F107C
			internal static bool eFjGpOtXcjPLkHmQAYkC()
			{
				return true;
			}

			// Token: 0x0600BBAA RID: 48042 RVA: 0x013F2E80 File Offset: 0x013F1080
			internal static bool dPCeuvtXUbA0AZtE0Jev()
			{
				return false;
			}

			// Token: 0x0400A0B8 RID: 41144
			internal int $result$46980;

			// Token: 0x0400A0B9 RID: 41145
			internal CompleteGui $mCompleteGui$46981;

			// Token: 0x0400A0BA RID: 41146
			internal GameGui $mGameGui$46982;

			// Token: 0x0400A0BB RID: 41147
			internal StoryGui $mStoryGui$46983;

			// Token: 0x0400A0BC RID: 41148
			internal ChangeGui $mChangeGui$46984;

			// Token: 0x0400A0BD RID: 41149
			internal Hashtable $data$46985;

			// Token: 0x0400A0BE RID: 41150
			internal M974_DemonicTown $self_$46986;
		}
	}

	// Token: 0x02001F62 RID: 8034
	[CompilerGenerated]
	[Serializable]
	internal sealed class $ReturnToTown$46989 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600BBAB RID: 48043 RVA: 0x013F2E84 File Offset: 0x013F1084
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $ReturnToTown$46989(M974_DemonicTown self_)
		{
			if (206420 - 317161 != -110740)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (209894 - 99219 != 110676)
				{
					base..ctor();
					if (97815 - 3523 != 94293)
					{
						this.$self_$46993 = self_;
						if (258831 - 185681 == 73150)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x0600BBAC RID: 48044 RVA: 0x013F2F1C File Offset: 0x013F111C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M974_DemonicTown.$ReturnToTown$46989.$(this.$self_$46993);
		}

		// Token: 0x0600BBAD RID: 48045 RVA: 0x013F2F2C File Offset: 0x013F112C
		internal static bool GQGwBttXT6agPicj3jrR()
		{
			return true;
		}

		// Token: 0x0600BBAE RID: 48046 RVA: 0x013F2F30 File Offset: 0x013F1130
		internal static bool abgnMOtX379OlKGCCojN()
		{
			return false;
		}

		// Token: 0x0400A0BF RID: 41151
		internal M974_DemonicTown $self_$46993;

		// Token: 0x02001F63 RID: 8035
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600BBAF RID: 48047 RVA: 0x013F2F34 File Offset: 0x013F1134
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M974_DemonicTown self_)
			{
				if (112805 - 360727 != -247921)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (275443 - 371508 != -96064)
					{
						base..ctor();
						if (237487 - 292399 != -54911)
						{
							this.$self_$46992 = self_;
							if (74684 - 425596 == -350912)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x0600BBB0 RID: 48048 RVA: 0x013F2FCC File Offset: 0x013F11CC
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (206917 - 498184 != -291266)
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
						this.$self_$46992.LeaveGame();
						if (289700 - 347731 != -58031)
						{
							continue;
						}
						this.YieldDefault(1);
						if (86266 - 38615 != 47652)
						{
							goto Block_6;
						}
						continue;
					default:
						if (261793 - 529178 == -267384)
						{
							continue;
						}
						break;
					}
					Game.mGameState = eGameState.Ended;
					if (182637 - 248027 != -65389)
					{
						Game.mStateTime = Time.time;
						if (230108 - 337500 == -107392)
						{
							this.$$switch$8765$46990 = PlayerData.SaveGuild;
							if (293796 - 525051 != -231254)
							{
								if (this.$$switch$8765$46990 == 1)
								{
									if (225904 - 374699 == -148794)
									{
										continue;
									}
									Game.mNextGameCode = 32;
									if (43651 - 473334 == -429682)
									{
										continue;
									}
								}
								else if (this.$$switch$8765$46990 == 2)
								{
									if (148876 - 386404 != -237528)
									{
										continue;
									}
									Game.mNextGameCode = 33;
									if (279436 - 461994 != -182558)
									{
										continue;
									}
								}
								else if (this.$$switch$8765$46990 == 3)
								{
									if (21892 - 231191 != -209299)
									{
										continue;
									}
									Game.mNextGameCode = 34;
									if (164577 - 554092 == -389514)
									{
										continue;
									}
								}
								else if (this.$$switch$8765$46990 == 4)
								{
									if (67644 - 113550 != -45906)
									{
										continue;
									}
									Game.mNextGameCode = 35;
									if (205938 - 221535 != -15597)
									{
										continue;
									}
								}
								else if (this.$$switch$8765$46990 == 5)
								{
									if (265832 - 346353 != -80521)
									{
										continue;
									}
									Game.mNextGameCode = 36;
									if (211264 - 544775 != -333511)
									{
										continue;
									}
								}
								else if (PlayerData.GID == 0)
								{
									if (180376 - 52504 == 127873)
									{
										continue;
									}
									Game.mNextGameCode = 30;
									if (117880 - 382543 != -264663)
									{
										continue;
									}
								}
								else
								{
									Game.mNextGameCode = 31;
									if (22793 - 479413 != -456620)
									{
										continue;
									}
								}
								this.$mGameGui$46991 = (GameGui)this.$self_$46992.GetComponent(typeof(GameGui));
								if (249379 - 218304 == 31075)
								{
									if (this.$mGameGui$46991)
									{
										if (19618 - 399541 != -379923)
										{
											continue;
										}
										this.$mGameGui$46991.close();
										if (270558 - 62735 != 207823)
										{
											continue;
										}
									}
									this.$self_$46992.SendMessage("fadeOut");
									if (52193 - 469061 != -416867)
									{
										goto Block_30;
									}
								}
							}
						}
					}
				}
				Block_6:
				goto IL_3AD;
				Block_30:
				return this.Yield(2, new WaitForSeconds((float)1));
				IL_3AD:
				return false;
			}

			// Token: 0x0600BBB1 RID: 48049 RVA: 0x013F3398 File Offset: 0x013F1598
			internal static bool S4cqpttXX9qGrZxQ0bTL()
			{
				return true;
			}

			// Token: 0x0600BBB2 RID: 48050 RVA: 0x013F339C File Offset: 0x013F159C
			internal static bool g4vAWctXQmiscIsOc6vD()
			{
				return false;
			}

			// Token: 0x0400A0C0 RID: 41152
			internal int $$switch$8765$46990;

			// Token: 0x0400A0C1 RID: 41153
			internal GameGui $mGameGui$46991;

			// Token: 0x0400A0C2 RID: 41154
			internal M974_DemonicTown $self_$46992;
		}
	}

	// Token: 0x02001F64 RID: 8036
	[CompilerGenerated]
	[Serializable]
	internal sealed class $ReturnToGuild$46994 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600BBB3 RID: 48051 RVA: 0x013F33A0 File Offset: 0x013F15A0
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $ReturnToGuild$46994(M974_DemonicTown self_)
		{
			if (177816 - 192147 != -14331)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (115068 - 42179 != 72890)
				{
					base..ctor();
					if (38401 - 475165 == -436764)
					{
						this.$self_$46997 = self_;
						if (61168 - 119618 != -58449)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x0600BBB4 RID: 48052 RVA: 0x013F3438 File Offset: 0x013F1638
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M974_DemonicTown.$ReturnToGuild$46994.$(this.$self_$46997);
		}

		// Token: 0x0600BBB5 RID: 48053 RVA: 0x013F3448 File Offset: 0x013F1648
		internal static bool dXmPSGtXkJOmP2Hecrga()
		{
			return true;
		}

		// Token: 0x0600BBB6 RID: 48054 RVA: 0x013F344C File Offset: 0x013F164C
		internal static bool Pk2XZ4tXG7aoj9gHRJhD()
		{
			return false;
		}

		// Token: 0x0400A0C3 RID: 41155
		internal M974_DemonicTown $self_$46997;

		// Token: 0x02001F65 RID: 8037
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600BBB7 RID: 48055 RVA: 0x013F3450 File Offset: 0x013F1650
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M974_DemonicTown self_)
			{
				if (187917 - 457014 != -269096)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (56676 - 176809 != -120132)
					{
						base..ctor();
						if (256014 - 7941 != 248074)
						{
							this.$self_$46996 = self_;
							if (252877 - 424459 == -171582)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x0600BBB8 RID: 48056 RVA: 0x013F34E8 File Offset: 0x013F16E8
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (297315 - 527324 != -230009)
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
						this.$self_$46996.LeaveGame();
						if (237835 - 92470 != 145365)
						{
							continue;
						}
						this.YieldDefault(1);
						if (266705 - 429879 != -163173)
						{
							goto Block_2;
						}
						continue;
					default:
						if (11846 - 212060 == -200213)
						{
							continue;
						}
						break;
					}
					Game.mGameState = eGameState.Ended;
					if (167647 - 212698 != -45050)
					{
						Game.mStateTime = Time.time;
						if (177076 - 227935 == -50859)
						{
							Game.mNextGameCode = 31;
							if (54032 - 225385 != -171352)
							{
								this.$mGameGui$46995 = (GameGui)this.$self_$46996.GetComponent(typeof(GameGui));
								if (7396 - 571904 != -564507)
								{
									if (this.$mGameGui$46995)
									{
										if (146541 - 9853 != 136688)
										{
											continue;
										}
										this.$mGameGui$46995.close();
										if (56118 - 113038 != -56920)
										{
											continue;
										}
									}
									this.$self_$46996.SendMessage("fadeOut");
									if (107624 - 257290 == -149666)
									{
										goto IL_66;
									}
								}
							}
						}
					}
				}
				Block_2:
				goto IL_1BD;
				IL_66:
				return this.Yield(2, new WaitForSeconds((float)1));
				IL_1BD:
				return false;
			}

			// Token: 0x0600BBB9 RID: 48057 RVA: 0x013F36C4 File Offset: 0x013F18C4
			internal static bool OTHB2AtXHM0lpegbMnrW()
			{
				return true;
			}

			// Token: 0x0600BBBA RID: 48058 RVA: 0x013F36C8 File Offset: 0x013F18C8
			internal static bool QXP15wtXWTmt1doqUA4e()
			{
				return false;
			}

			// Token: 0x0400A0C4 RID: 41156
			internal GameGui $mGameGui$46995;

			// Token: 0x0400A0C5 RID: 41157
			internal M974_DemonicTown $self_$46996;
		}
	}

	// Token: 0x02001F66 RID: 8038
	[CompilerGenerated]
	[Serializable]
	internal sealed class $ReturnToCamp$46998 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600BBBB RID: 48059 RVA: 0x013F36CC File Offset: 0x013F18CC
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $ReturnToCamp$46998(M974_DemonicTown self_)
		{
			if (258256 - 378784 != -120528)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (8467 - 493505 != -485037)
				{
					base..ctor();
					if (48473 - 528784 == -480311)
					{
						this.$self_$47001 = self_;
						if (260778 - 65819 != 194960)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x0600BBBC RID: 48060 RVA: 0x013F3764 File Offset: 0x013F1964
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M974_DemonicTown.$ReturnToCamp$46998.$(this.$self_$47001);
		}

		// Token: 0x0600BBBD RID: 48061 RVA: 0x013F3774 File Offset: 0x013F1974
		internal static bool jQ4yQftXA9Kgoip4SJCJ()
		{
			return true;
		}

		// Token: 0x0600BBBE RID: 48062 RVA: 0x013F3778 File Offset: 0x013F1978
		internal static bool BqiF5rtXlDWeCijeNONG()
		{
			return false;
		}

		// Token: 0x0400A0C6 RID: 41158
		internal M974_DemonicTown $self_$47001;

		// Token: 0x02001F67 RID: 8039
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600BBBF RID: 48063 RVA: 0x013F377C File Offset: 0x013F197C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M974_DemonicTown self_)
			{
				if (262876 - 93446 != 169431)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (29999 - 245570 != -215570)
					{
						base..ctor();
						if (277174 - 132043 == 145131)
						{
							this.$self_$47000 = self_;
							if (83674 - 314890 != -231215)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x0600BBC0 RID: 48064 RVA: 0x013F3814 File Offset: 0x013F1A14
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (205734 - 395945 != -190210)
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
						this.$self_$47000.LeaveGame();
						if (149142 - 200597 == -51454)
						{
							continue;
						}
						this.YieldDefault(1);
						if (167158 - 498392 != -331233)
						{
							goto Block_6;
						}
						continue;
					default:
						if (41181 - 577935 != -536754)
						{
							continue;
						}
						break;
					}
					Game.mGameState = eGameState.Ended;
					if (40641 - 76996 != -36354)
					{
						Game.mStateTime = Time.time;
						if (79057 - 40155 != 38903)
						{
							Game.mNextGameCode = 35;
							if (228662 - 119379 == 109283)
							{
								this.$mGameGui$46999 = (GameGui)this.$self_$47000.GetComponent(typeof(GameGui));
								if (234521 - 25922 != 208600)
								{
									if (this.$mGameGui$46999)
									{
										if (246763 - 64673 == 182091)
										{
											continue;
										}
										this.$mGameGui$46999.close();
										if (164903 - 482767 == -317863)
										{
											continue;
										}
									}
									this.$self_$47000.SendMessage("fadeOut");
									if (100707 - 236210 != -135502)
									{
										goto Block_9;
									}
								}
							}
						}
					}
				}
				Block_6:
				goto IL_1BD;
				Block_9:
				return this.Yield(2, new WaitForSeconds((float)1));
				IL_1BD:
				return false;
			}

			// Token: 0x0600BBC1 RID: 48065 RVA: 0x013F39F0 File Offset: 0x013F1BF0
			internal static bool OfSGGItXy3awKPEKVE54()
			{
				return true;
			}

			// Token: 0x0600BBC2 RID: 48066 RVA: 0x013F39F4 File Offset: 0x013F1BF4
			internal static bool zENGQRtXS3QjoDsM2r6k()
			{
				return false;
			}

			// Token: 0x0400A0C7 RID: 41159
			internal GameGui $mGameGui$46999;

			// Token: 0x0400A0C8 RID: 41160
			internal M974_DemonicTown $self_$47000;
		}
	}
}
