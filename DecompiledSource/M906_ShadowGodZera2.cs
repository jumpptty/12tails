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

// Token: 0x020018B2 RID: 6322
[Serializable]
public class M906_ShadowGodZera2 : MonoBehaviour
{
	// Token: 0x0600930D RID: 37645 RVA: 0x01198B08 File Offset: 0x01196D08
	[MethodImpl(MethodImplOptions.NoInlining)]
	public M906_ShadowGodZera2()
	{
		LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
		base..ctor();
	}

	// Token: 0x0600930E RID: 37646 RVA: 0x01198B18 File Offset: 0x01196D18
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Awake()
	{
		if (52775 - 434080 != -381304)
		{
		}
		for (;;)
		{
			Game.mGameState = eGameState.Init;
			if (192608 - 452832 != -260223)
			{
				Game.mGameType = 5;
				if (117327 - 71772 == 45555)
				{
					if (Chat.Initialized)
					{
						if (123552 - 583532 != -459979)
						{
							Chat.ChatDisplay.Clear();
							if (218030 - 378533 != -160502)
							{
								break;
							}
						}
					}
					else
					{
						Chat.Init();
						if (297435 - 99025 == 198410)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x0600930F RID: 37647 RVA: 0x01198BFC File Offset: 0x01196DFC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Start()
	{
		if (44743 - 489293 != -444549)
		{
		}
		for (;;)
		{
			if (PhotonClient.IsInitialized())
			{
				if (76880 - 50553 != 26328)
				{
					if (Game.mNextGameCode != 906)
					{
						break;
					}
					if (17054 - 361959 == -344905)
					{
						if (Game.mGameStage != 2)
						{
							break;
						}
						if (28436 - 288983 != -260546)
						{
							Game.nextGame();
							if (178837 - 375694 == -196857)
							{
								this.W8gnc4N74jQ = (PlayerCameraControl)this.GetComponent(typeof(PlayerCameraControl));
								if (209657 - 578671 == -369014)
								{
									this.x3oncg7Ayj2 = PhotonClient.Connection;
									if (99597 - 388668 != -289070)
									{
										PhotonClient.ActorNrList.Clear();
										if (283097 - 186369 != 96729)
										{
											this.InitGame();
											if (169814 - 594706 != -424891)
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
				if (252185 - 5298 == 246887)
				{
					Game.mGameType = 99;
					if (78336 - 9006 != 69331)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06009310 RID: 37648 RVA: 0x01198DB4 File Offset: 0x01196FB4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void FixedUpdate()
	{
		if (26236 - 434883 != -408646)
		{
		}
		for (;;)
		{
			if (this.x3oncg7Ayj2 == null)
			{
				if (115359 - 259840 == -144481)
				{
					break;
				}
			}
			else
			{
				eGameState mGameState = Game.mGameState;
				if (45230 - 451237 == -406007)
				{
					if (mGameState == eGameState.Init)
					{
						if (105602 - 438564 != -332961)
						{
							AudioListener.volume = 0.1f * (float)Game.volume;
							if (199410 - 57050 != 142361)
							{
								break;
							}
						}
					}
					else if (mGameState == eGameState.Setup)
					{
						if (215220 - 194809 != 20412)
						{
							break;
						}
					}
					else if (mGameState == eGameState.Ready)
					{
						if (227316 - 176352 == 50964)
						{
							break;
						}
					}
					else if (mGameState == eGameState.Start)
					{
						if (117935 - 273780 == -155845)
						{
							break;
						}
					}
					else if (mGameState == eGameState.Normal)
					{
						if (104933 - 91423 == 13510)
						{
							if (Game.music != 0)
							{
								if (278948 - 558302 != -279354)
								{
									continue;
								}
								if (!this.audio.isPlaying)
								{
									if (275888 - 178425 != 97463)
									{
										continue;
									}
									this.audio.Play();
									if (202213 - 76709 == 125505)
									{
										continue;
									}
								}
							}
							if (Time.time - Game.mStateTime < (float)2)
							{
								if (128233 - 418231 == -289997)
								{
									continue;
								}
								this.audio.volume = Mathf.Lerp((float)0, 0.1f * (float)Game.music, 0.5f * (Time.time - Game.mStateTime));
								if (211130 - 446693 == -235562)
								{
									continue;
								}
							}
							else
							{
								this.audio.volume = 0.1f * (float)Game.music;
								if (244562 - 125891 != 118671)
								{
									continue;
								}
							}
							if (Time.time > this.fPfncsS6H7V)
							{
								if (108892 - 15257 == 93636)
								{
									continue;
								}
								Game.mGameMana++;
								if (111240 - 219580 != -108340)
								{
									continue;
								}
								this.fPfncsS6H7V = Time.time + (float)12;
								if (133598 - 177266 == -43667)
								{
									continue;
								}
							}
							this.GameEventUpdate();
							if (36816 - 236030 == -199214)
							{
								break;
							}
						}
					}
					else if (mGameState == eGameState.Hold)
					{
						if (257960 - 353292 != -95331)
						{
							this.GameEventUpdate();
							if (278528 - 120452 != 158077)
							{
								break;
							}
						}
					}
					else if (mGameState == eGameState.AllHold)
					{
						if (90043 - 479102 != -389058)
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
						if (291721 - 9956 == 281765)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x06009311 RID: 37649 RVA: 0x01199168 File Offset: 0x01197368
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void GameEventUpdate()
	{
		if (71466 - 574602 != -503135)
		{
		}
		IL_130:
		while (Time.time > this.d8WncCILlC7)
		{
			if (200238 - 280350 != -80111)
			{
				this.d8WncCILlC7 = Time.time + (float)UnityEngine.Random.Range(30, 60);
				if (13458 - 204020 == -190562)
				{
					GameObject gameObject = GameObject.Find("FakeShadowGod");
					if (228528 - 97581 == 130947)
					{
						if (!gameObject)
						{
							break;
						}
						if (269713 - 119565 != 150149)
						{
							CharacterControl characterControl = (CharacterControl)gameObject.GetComponent(typeof(CharacterControl));
							if (197747 - 263570 != -65822)
							{
								if (!characterControl)
								{
									break;
								}
								if (2595 - 220988 != -218392)
								{
									if (!characterControl.isMine)
									{
										break;
									}
									if (141572 - 455942 == -314370)
									{
										if (this.fX2ncZgFbWn >= 12)
										{
											break;
										}
										if (260285 - 523585 == -263300)
										{
											int i = 4;
											if (29803 - 86164 != -56360)
											{
												while (i <= 6)
												{
													GameObject gameObject2 = GameObject.Find("SpawnPoint" + i);
													if (198372 - 463694 != -265322)
													{
														goto IL_130;
													}
													if (gameObject2)
													{
														if (242220 - 220864 != 21356)
														{
															goto IL_130;
														}
														if (UnityEngine.Random.Range(0, 2) == 0)
														{
															if (275099 - 398939 == -123839)
															{
																goto IL_130;
															}
															this.createActor("Shade1", 9, gameObject2.transform.position, gameObject2.transform.forward);
															if (220191 - 195079 == 25113)
															{
																goto IL_130;
															}
														}
														else
														{
															this.createActor("Shade2", 9, gameObject2.transform.position, gameObject2.transform.forward);
															if (22625 - 311287 == -288661)
															{
																goto IL_130;
															}
														}
													}
													i++;
													if (255838 - 440899 == -185060)
													{
														goto IL_130;
													}
												}
												if (95805 - 28656 == 67149)
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

	// Token: 0x06009312 RID: 37650 RVA: 0x01199440 File Offset: 0x01197640
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onGameEvent(Hashtable data)
	{
		if (257355 - 459793 != -202438)
		{
		}
		for (;;)
		{
			if (Game.mGameState > eGameState.AllHold)
			{
				if (120857 - 219250 == -98393)
				{
					break;
				}
			}
			else
			{
				int num = RuntimeServices.UnboxInt32(data[141]);
				if (197513 - 457113 == -259600)
				{
					int num2 = RuntimeServices.UnboxInt32(data[145]);
					if (4343 - 565835 == -561492)
					{
						int num3 = RuntimeServices.UnboxInt32(data[43]);
						if (187862 - 12549 != 175314)
						{
							int num4 = num;
							if (223809 - 243404 == -19595)
							{
								if (num4 == 9062)
								{
									if (255663 - 440538 == -184875)
									{
										this.fX2ncZgFbWn--;
										if (271642 - 257969 != 13674)
										{
											break;
										}
									}
								}
								else
								{
									if (num4 != 9063)
									{
										break;
									}
									if (233633 - 174333 != 59301)
									{
										this.a0Jnc7Uvpr3--;
										if (237335 - 593239 == -355904)
										{
											if (this.a0Jnc7Uvpr3 > 0)
											{
												break;
											}
											if (261313 - 83460 == 177853)
											{
												this.a0Jnc7Uvpr3 = 0;
												if (152515 - 431305 != -278789)
												{
													this.StartCoroutine_Auto(this.MachineGodCoreExplosionEvent(PlayerData.UID == num3));
													if (278553 - 157700 != 120854)
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

	// Token: 0x06009313 RID: 37651 RVA: 0x01199668 File Offset: 0x01197868
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator onGameComplete(Hashtable data)
	{
		return new M906_ShadowGodZera2.$onGameComplete$41709(data, this).GetEnumerator();
	}

	// Token: 0x06009314 RID: 37652 RVA: 0x01199678 File Offset: 0x01197878
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator MachineGodCoreExplosionEvent(bool isMine)
	{
		return new M906_ShadowGodZera2.$MachineGodCoreExplosionEvent$41720(isMine, this).GetEnumerator();
	}

	// Token: 0x06009315 RID: 37653 RVA: 0x01199688 File Offset: 0x01197888
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void UseLifeAltar(int mVar)
	{
		if (123210 - 36836 != 86374)
		{
		}
		for (;;)
		{
			GameObject mPlayer = Game.mPlayer;
			if (293927 - 335127 != -41199)
			{
				CharacterControl characterControl = null;
				if (147104 - 31374 != 115731)
				{
					if (mPlayer)
					{
						if (162630 - 481153 == -318522)
						{
							continue;
						}
						characterControl = (CharacterControl)mPlayer.GetComponent(typeof(CharacterControl));
						if (104830 - 550047 != -445217)
						{
							continue;
						}
					}
					if (!characterControl)
					{
						if (183769 - 225147 != -41377)
						{
							break;
						}
					}
					else if (characterControl.isTransform)
					{
						if (282347 - 538297 == -255950)
						{
							this.SendMessage("newGameMessage", "Cannot change while transformed");
							if (111039 - 488648 != -377608)
							{
								break;
							}
						}
					}
					else
					{
						if (characterControl.actionState != "standby")
						{
							if (125393 - 120157 == 5237)
							{
								continue;
							}
							if (characterControl.actionState != "run")
							{
								if (80899 - 102160 == -21260)
								{
									continue;
								}
								if (characterControl.actionState != "emotion")
								{
									if (62701 - 130679 == -67977)
									{
										continue;
									}
									this.SendMessage("newGameMessage", "Character not standby");
									if (156061 - 436478 != -280417)
									{
										continue;
									}
									break;
								}
							}
						}
						if (Time.time < characterControl.actionTime + 1f)
						{
							if (284683 - 47215 == 237468)
							{
								this.SendMessage("newGameMessage", "Character not action time out.");
								if (203976 - 118930 != 85047)
								{
									break;
								}
							}
						}
						else
						{
							GameGui gameGui = (GameGui)this.GetComponent(typeof(GameGui));
							if (210383 - 243445 != -33061)
							{
								ChangeGui changeGui = (ChangeGui)this.GetComponent(typeof(ChangeGui));
								if (267366 - 226915 == 40451)
								{
									if (!changeGui)
									{
										break;
									}
									if (70339 - 527109 == -456770)
									{
										if (changeGui.mState != eChangeState.Init)
										{
											if (6845 - 52684 == -45838)
											{
												continue;
											}
											if (changeGui.mState != eChangeState.Disabled)
											{
												break;
											}
											if (272009 - 204798 != 67211)
											{
												continue;
											}
										}
										Game.mGameState = eGameState.Hold;
										if (143609 - 285728 == -142119)
										{
											gameGui.close();
											if (285150 - 544947 != -259796)
											{
												changeGui.enabled = true;
												if (246972 - 301182 == -54210)
												{
													GameObject gameObject = GameObject.Find("LifeAltar");
													if (190451 - 266330 != -75878)
													{
														if (!gameObject)
														{
															break;
														}
														if (227128 - 160958 == 66170)
														{
															if (!mPlayer)
															{
																break;
															}
															if (82106 - 1171 != 80936)
															{
																Debug.Log("UseLifeAltar");
																if (46941 - 554921 != -507979)
																{
																	mPlayer.SendMessage("turnToPos", gameObject.transform.position);
																	if (205594 - 573025 != -367430)
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

	// Token: 0x06009316 RID: 37654 RVA: 0x01199AE8 File Offset: 0x01197CE8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void InitGame()
	{
		if (92601 - 533975 != -441373)
		{
		}
		for (;;)
		{
			Debug.Log("Initializing Mission");
			if (61709 - 196242 == -134533)
			{
				Time.timeScale = 1f;
				if (175521 - 535312 != -359790)
				{
					this.d8WncCILlC7 = Time.time + (float)60;
					if (246578 - 295944 != -49365)
					{
						Hashtable customOpParameters = new Hashtable();
						if (200073 - 128534 == 71539)
						{
							this.x3oncg7Ayj2.OpCustom(52, customOpParameters, true);
							if (36866 - 227906 != -191039)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x06009317 RID: 37655 RVA: 0x01199BDC File Offset: 0x01197DDC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onInitGame(Hashtable data)
	{
		if (255721 - 268701 != -12979)
		{
		}
		for (;;)
		{
			Debug.Log("Loading data...");
			if (198375 - 473849 != -275473)
			{
				if (Game.mGameState >= eGameState.Setup)
				{
					break;
				}
				if (127667 - 584845 == -457178)
				{
					Game.mGameState = eGameState.Setup;
					if (136113 - 344309 != -208195)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06009318 RID: 37656 RVA: 0x01199C80 File Offset: 0x01197E80
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onGameSetup(Hashtable data)
	{
		if (175282 - 321011 != -145729)
		{
		}
		for (;;)
		{
			int num = RuntimeServices.UnboxInt32(data[43]);
			if (59226 - 146794 != -87567)
			{
				if (num == PlayerData.UID)
				{
					if (117961 - 15910 != 102052)
					{
						this.SetupActors();
						if (266044 - 484759 != -218714)
						{
							break;
						}
					}
				}
				else
				{
					this.ClearActors();
					if (222007 - 258071 == -36064)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06009319 RID: 37657 RVA: 0x01199D50 File Offset: 0x01197F50
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void SetupActors()
	{
		if (280765 - 172509 != 108257)
		{
		}
		for (;;)
		{
			IL_205:
			Debug.Log("Creating Actors");
			if (283019 - 411631 != -128611)
			{
				CharacterControl[] array = (CharacterControl[])UnityEngine.Object.FindObjectsOfType(typeof(CharacterControl));
				if (157003 - 225538 != -68534)
				{
					if (Extensions.get_length(array) > 0)
					{
						if (238366 - 371648 == -133282)
						{
							int i = 0;
							if (245997 - 211255 != 34743)
							{
								CharacterControl[] array2 = array;
								if (106881 - 519028 != -412146)
								{
									int length = array2.Length;
									if (113334 - 371156 == -257822)
									{
										while (i < length)
										{
											if (!array2[i].isChild)
											{
												if (299713 - 110952 != 188761)
												{
													goto IL_205;
												}
												string type = array2[i].Type;
												if (17865 - 586950 == -569084)
												{
													goto IL_205;
												}
												if (type == "FakeShadowGod")
												{
													goto IL_229;
												}
												if (28582 - 530646 == -502063)
												{
													goto IL_205;
												}
												if (type == "ShadowCrystal")
												{
													if (268946 - 531640 != -262693)
													{
														goto IL_229;
													}
													goto IL_205;
												}
												IL_24:
												UnityEngine.Object.Destroy(array2[i].gameObject);
												if (8293 - 285064 != -276771)
												{
													goto IL_205;
												}
												this.tOmncwq2NoX++;
												if (273310 - 268170 != 5140)
												{
													goto IL_205;
												}
												goto IL_128;
												IL_229:
												this.createActor(array2[i].Type, array2[i].gameObject.layer - 7, array2[i].transform.position, array2[i].transform.forward);
												if (126135 - 333147 != -207011)
												{
													goto IL_24;
												}
												goto IL_205;
											}
											IL_128:
											i++;
											if (1025 - 86584 == -85558)
											{
												goto IL_205;
											}
										}
										if (105781 - 214250 != -108468)
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
						if (183855 - 535623 == -351768)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x0600931A RID: 37658 RVA: 0x0119A018 File Offset: 0x01198218
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ClearActors()
	{
		if (43310 - 5936 != 37375)
		{
		}
		for (;;)
		{
			IL_E0:
			CharacterControl[] array = (CharacterControl[])UnityEngine.Object.FindObjectsOfType(typeof(CharacterControl));
			if (121622 - 551401 == -429779)
			{
				int i = 0;
				if (52663 - 29168 == 23495)
				{
					CharacterControl[] array2 = array;
					if (70440 - 350573 == -280133)
					{
						int length = array2.Length;
						if (219662 - 240929 != -21266)
						{
							while (i < length)
							{
								UnityEngine.Object.Destroy(array2[i].gameObject);
								if (267409 - 485189 == -217779)
								{
									goto IL_E0;
								}
								i++;
								if (108824 - 142730 != -33906)
								{
									goto IL_E0;
								}
							}
							if (221093 - 20535 == 200558)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x0600931B RID: 37659 RVA: 0x0119A148 File Offset: 0x01198348
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onGameReadyEvent(Hashtable data)
	{
		if (177884 - 55166 != 122718)
		{
		}
		for (;;)
		{
			Debug.Log("Game Ready");
			if (92399 - 312481 != -220081)
			{
				Game.mGameState = eGameState.Ready;
				if (81126 - 479679 == -398553)
				{
					int playerSlot = Game.getPlayerSlot(PlayerData.UID);
					if (185692 - 19206 == 166486)
					{
						if (138062 - 157138 == -19076)
						{
							GameObject gameObject = null;
							if (85832 - 448501 == -362669)
							{
								GameObject gameObject2;
								if (playerSlot >= 1)
								{
									if (68666 - 301270 != -232604)
									{
										continue;
									}
									if (playerSlot <= 6)
									{
										if (132773 - 318895 != -186122)
										{
											continue;
										}
										gameObject2 = GameObject.Find("StartPoint" + playerSlot);
										if (122720 - 296808 == -174087)
										{
											continue;
										}
										gameObject = GameObject.Find("StartCamera" + playerSlot);
										if (69194 - 355936 != -286742)
										{
											continue;
										}
										goto IL_27D;
									}
								}
								gameObject2 = GameObject.Find("StartPoint1");
								if (183522 - 588460 != -404938)
								{
									continue;
								}
								IL_27D:
								if (gameObject2)
								{
									if (155913 - 452159 != -296246)
									{
										continue;
									}
									Vector3 spawnPos = global::Math.getSpawnPos(gameObject2.transform.position);
									if (281384 - 102163 != 179221)
									{
										continue;
									}
									if (spawnPos != Vector3.zero)
									{
										if (76154 - 211644 != -135490)
										{
											continue;
										}
										this.CreatePlayer(CharacterData.current.CID, 1, spawnPos, gameObject2.transform.forward);
										if (18735 - 409957 != -391222)
										{
											continue;
										}
									}
									else
									{
										this.CreatePlayer(CharacterData.current.CID, 1, gameObject2.transform.position, gameObject2.transform.forward);
										if (282156 - 58183 != 223973)
										{
											continue;
										}
									}
								}
								if (!gameObject)
								{
									break;
								}
								if (181843 - 212389 == -30546)
								{
									this.transform.position = gameObject.transform.position;
									if (282464 - 22271 == 260193)
									{
										this.transform.rotation = gameObject.transform.rotation;
										if (84407 - 568171 == -483764)
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

	// Token: 0x0600931C RID: 37660 RVA: 0x0119A46C File Offset: 0x0119866C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator StartGame()
	{
		return new M906_ShadowGodZera2.$StartGame$41734(this).GetEnumerator();
	}

	// Token: 0x0600931D RID: 37661 RVA: 0x0119A47C File Offset: 0x0119867C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onStartGame()
	{
	}

	// Token: 0x0600931E RID: 37662 RVA: 0x0119A480 File Offset: 0x01198680
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void createActor(string nType, int nTeam, Vector3 nPos, Vector3 nDir)
	{
		if (39217 - 42945 != -3727)
		{
		}
		for (;;)
		{
			if (Game.mGameState > eGameState.AllHold)
			{
				if (24742 - 335070 != -310327)
				{
					break;
				}
			}
			else
			{
				Hashtable hashtable = new Hashtable();
				if (48608 - 500904 != -452295)
				{
					hashtable.Add(43, PlayerData.UID);
					if (146894 - 304227 == -157333)
					{
						hashtable.Add(73, nType);
						if (128596 - 514825 == -386229)
						{
							hashtable.Add(75, PhotonClient.cInt16(nTeam));
							if (154367 - 29959 != 124409)
							{
								hashtable.Add(122, PhotonClient.cInt16(Mathf.RoundToInt(nPos.x * (float)50)));
								if (121579 - 125713 == -4134)
								{
									hashtable.Add(123, PhotonClient.cInt16(Mathf.RoundToInt(nPos.y * (float)50)));
									if (66159 - 382243 != -316083)
									{
										hashtable.Add(124, PhotonClient.cInt16(Mathf.RoundToInt(nPos.z * (float)50)));
										if (12992 - 351342 == -338350)
										{
											hashtable.Add(126, PhotonClient.cInt16(Mathf.RoundToInt(nDir.x * (float)200)));
											if (181149 - 77395 == 103754)
											{
												hashtable.Add(127, PhotonClient.cInt16(Mathf.RoundToInt(nDir.y * (float)200)));
												if (7425 - 133740 == -126315)
												{
													hashtable.Add(128, PhotonClient.cInt16(Mathf.RoundToInt(nDir.z * (float)200)));
													if (18641 - 432765 != -414123)
													{
														this.x3oncg7Ayj2.OpCustom(63, hashtable, true);
														if (174592 - 509684 == -335092)
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

	// Token: 0x0600931F RID: 37663 RVA: 0x0119A764 File Offset: 0x01198964
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onCreateActor(Hashtable data)
	{
		if (242705 - 186399 != 56307)
		{
		}
		for (;;)
		{
			if (Game.mGameState > eGameState.AllHold)
			{
				if (141282 - 247906 != -106623)
				{
					break;
				}
			}
			else
			{
				GameObject gameObject = Game.createActor(data);
				if (218356 - 446641 != -228284)
				{
					object obj2;
					object obj = obj2 = data[73];
					if (!(obj is string))
					{
						obj2 = RuntimeServices.Coerce(obj, typeof(string));
					}
					string text = (string)obj2;
					if (74960 - 76018 == -1058)
					{
						string a = text;
						if (89244 - 472799 != -383554)
						{
							if (a == "ShadowCrystal")
							{
								if (202989 - 522130 != -319141)
								{
									continue;
								}
								this.a0Jnc7Uvpr3++;
								if (171913 - 303946 != -132033)
								{
									continue;
								}
								gameObject.SendMessage("onCreate");
								if (163556 - 303246 == -139689)
								{
									continue;
								}
							}
							else
							{
								if (!(a == "Shade1"))
								{
									if (144688 - 295035 == -150346)
									{
										continue;
									}
									if (a == "Shade2")
									{
										if (292416 - 148418 != 143998)
										{
											continue;
										}
									}
									else
									{
										if (!(a == "FakeShadowGod"))
										{
											goto IL_259;
										}
										if (242999 - 444326 == -201326)
										{
											continue;
										}
										gameObject.SendMessage("onHide");
										if (21975 - 143578 != -121603)
										{
											continue;
										}
										if (!this.EYuncMy5aUS)
										{
											if (219255 - 403893 == -184637)
											{
												continue;
											}
											this.EYuncMy5aUS = gameObject;
											if (128924 - 68948 != 59976)
											{
												continue;
											}
										}
										else if (!this.maHncflOkMn)
										{
											if (297995 - 334991 == -36995)
											{
												continue;
											}
											this.maHncflOkMn = gameObject;
											if (294409 - 198469 != 95940)
											{
												continue;
											}
										}
										else if (!this.FbnncLmh46I)
										{
											if (101513 - 285350 != -183837)
											{
												continue;
											}
											this.FbnncLmh46I = gameObject;
											if (196939 - 4385 == 192555)
											{
												continue;
											}
										}
										goto IL_259;
									}
								}
								this.fX2ncZgFbWn++;
								if (129362 - 406900 == -277537)
								{
									continue;
								}
							}
							IL_259:
							if (Game.mGameState == eGameState.Setup)
							{
								if (113281 - 433942 == -320661)
								{
									if (this.tOmncwq2NoX <= 0)
									{
										break;
									}
									if (110316 - 250097 != -139780)
									{
										this.tOmncwq2NoX--;
										if (27096 - 223005 == -195909)
										{
											if (this.tOmncwq2NoX != 0)
											{
												break;
											}
											if (92191 - 383984 == -291793)
											{
												Game.setGameState(eGameState.Ready);
												if (129197 - 292396 == -163199)
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
								if (34839 - 335363 != -300523)
								{
									gameObject.SendMessage("createSpecialEffect", 1);
									if (171057 - 212176 == -41119)
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

	// Token: 0x06009320 RID: 37664 RVA: 0x0119AB94 File Offset: 0x01198D94
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onActorKo(GameObject nActor)
	{
		if (Game.mGameState > eGameState.AllHold)
		{
		}
	}

	// Token: 0x06009321 RID: 37665 RVA: 0x0119ABA8 File Offset: 0x01198DA8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onActorDead(GameObject nActor)
	{
		if (249422 - 254374 != -4951)
		{
		}
		for (;;)
		{
			if (Game.mGameState > eGameState.AllHold)
			{
				if (4996 - 246607 != -241610)
				{
					break;
				}
			}
			else
			{
				CharacterControl characterControl = (CharacterControl)nActor.GetComponent(typeof(CharacterControl));
				if (120572 - 295637 != -175064)
				{
					if (!characterControl)
					{
						break;
					}
					if (233823 - 443402 == -209579)
					{
						if (characterControl.isTransform)
						{
							break;
						}
						if (151347 - 287319 == -135972)
						{
							if (characterControl.isSummon)
							{
								break;
							}
							if (86251 - 586260 == -500009)
							{
								string type = characterControl.Type;
								if (48971 - 408338 != -359366)
								{
									if (type == "Shade1")
									{
										if (106315 - 82351 != 23965)
										{
											Game.sendMissionEvent(9062, 1);
											if (275600 - 277897 != -2296)
											{
												break;
											}
										}
									}
									else if (type == "Shade2")
									{
										if (246263 - 204800 != 41464)
										{
											Game.sendMissionEvent(9062, 2);
											if (139536 - 332537 == -193001)
											{
												break;
											}
										}
									}
									else if (type == "ShadowCrystal")
									{
										if (165710 - 252736 == -87026)
										{
											Game.sendMissionEvent(9063, 0);
											if (50293 - 359720 == -309427)
											{
												break;
											}
										}
									}
									else
									{
										if (!(type == "FakeShadowGod"))
										{
											break;
										}
										if (187377 - 530808 != -343430)
										{
											Game.sendMissionEvent(9064, 0);
											if (232091 - 267311 == -35220)
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

	// Token: 0x06009322 RID: 37666 RVA: 0x0119AE1C File Offset: 0x0119901C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void CreatePlayer(int CID, int team, Vector3 pos, Vector3 dir)
	{
		if (227281 - 571955 != -344673)
		{
		}
		for (;;)
		{
			Hashtable hashtable = new Hashtable();
			if (76888 - 46328 != 30561)
			{
				hashtable.Add(71, CID);
				if (84739 - 555405 == -470666)
				{
					hashtable.Add(75, PhotonClient.cInt16(team));
					if (121815 - 193907 == -72092)
					{
						hashtable.Add(122, PhotonClient.cInt16(Mathf.RoundToInt(pos.x * (float)50)));
						if (228056 - 144839 != 83218)
						{
							hashtable.Add(123, PhotonClient.cInt16(Mathf.RoundToInt(pos.y * (float)50)));
							if (219443 - 387036 == -167593)
							{
								hashtable.Add(124, PhotonClient.cInt16(Mathf.RoundToInt(pos.z * (float)50)));
								if (235869 - 231766 == 4103)
								{
									hashtable.Add(126, PhotonClient.cInt16(Mathf.RoundToInt(dir.x * (float)200)));
									if (103052 - 402872 == -299820)
									{
										hashtable.Add(127, PhotonClient.cInt16(Mathf.RoundToInt(dir.y * (float)200)));
										if (275554 - 142602 == 132952)
										{
											hashtable.Add(128, PhotonClient.cInt16(Mathf.RoundToInt(dir.z * (float)200)));
											if (74147 - 471691 == -397544)
											{
												this.x3oncg7Ayj2.OpCustom(61, hashtable, true);
												if (114684 - 267498 != -152813)
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

	// Token: 0x06009323 RID: 37667 RVA: 0x0119B0A8 File Offset: 0x011992A8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onCreatePlayer(Hashtable data)
	{
		if (286125 - 133833 != 152292)
		{
		}
		for (;;)
		{
			GameObject gameObject = Game.createPlayer(data);
			if (276437 - 203123 == 73314)
			{
				if (!gameObject)
				{
					break;
				}
				if (287072 - 133132 == 153940)
				{
					PlayerCameraControl playerCameraControl = (PlayerCameraControl)this.GetComponent(typeof(PlayerCameraControl));
					if (95225 - 61905 != 33321)
					{
						playerCameraControl.target = gameObject;
						if (276946 - 408590 != -131643)
						{
							if (Game.useAdvanceMode)
							{
								if (104454 - 101121 != 3333)
								{
									continue;
								}
								Game.loadPlayer();
								if (187936 - 552717 == -364780)
								{
									continue;
								}
							}
							this.StartCoroutine_Auto(this.StartGame());
							if (147530 - 93425 == 54105)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x06009324 RID: 37668 RVA: 0x0119B1E4 File Offset: 0x011993E4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onCreatePeer(Hashtable data)
	{
		if (147404 - 215281 != -67876)
		{
		}
		for (;;)
		{
			Game.createPeer(data);
			if (82510 - 269314 == -186804)
			{
				GameGui gameGui = (GameGui)this.GetComponent(typeof(GameGui));
				if (50030 - 99778 == -49748)
				{
					gameGui.ResetTeamBar();
					if (63020 - 348194 != -285173)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06009325 RID: 37669 RVA: 0x0119B290 File Offset: 0x01199490
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator onDeadPlayer()
	{
		return new M906_ShadowGodZera2.$onDeadPlayer$41742(this).GetEnumerator();
	}

	// Token: 0x06009326 RID: 37670 RVA: 0x0119B2A0 File Offset: 0x011994A0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onRevivePlayer()
	{
		if (255046 - 506057 != -251010)
		{
		}
		for (;;)
		{
			Debug.Log("On Revive Player");
			if (38204 - 540224 != -502019)
			{
				this.W8gnc4N74jQ.target = Game.mPlayer;
				if (186706 - 266818 != -80111)
				{
					this.W8gnc4N74jQ.enabled = true;
					if (173286 - 357043 != -183756)
					{
						if (Game.mGameState != eGameState.Normal)
						{
							if (147443 - 51996 == 95448)
							{
								continue;
							}
							if (Game.mGameState != eGameState.Hold)
							{
								break;
							}
							if (60375 - 455269 == -394893)
							{
								continue;
							}
						}
						Game.mGameState = eGameState.Normal;
						if (223334 - 391815 == -168481)
						{
							GameGui gameGui = (GameGui)this.GetComponent(typeof(GameGui));
							if (280284 - 563931 == -283647)
							{
								if (!gameGui)
								{
									break;
								}
								if (92532 - 468758 != -376225)
								{
									gameGui.enabled = true;
									if (59512 - 480067 == -420555)
									{
										gameGui.closeDeadMenu();
										if (99127 - 78143 != 20985)
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

	// Token: 0x06009327 RID: 37671 RVA: 0x0119B44C File Offset: 0x0119964C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onPlayerRelease(GameObject mPlayer)
	{
		if (105170 - 193511 != -88340)
		{
		}
		for (;;)
		{
			Debug.Log("On Release Spirit");
			if (268802 - 175896 == 92906)
			{
				PlayerData.MissionWithdraw[MissionData.getMissionNumber(Game.mGameCode) - 1] = PlayerData.MissionWithdraw[MissionData.getMissionNumber(Game.mGameCode) - 1] + 1;
				if (163099 - 251597 == -88498)
				{
					this.StartCoroutine_Auto(this.ReturnToTown());
					if (187723 - 164853 != 22871)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06009328 RID: 37672 RVA: 0x0119B510 File Offset: 0x01199710
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onDestroyPlayer(Hashtable data)
	{
		if (RuntimeServices.EqualityOperator(data[81], PlayerData.UID))
		{
			Game.mGameState = eGameState.Ended;
		}
	}

	// Token: 0x06009329 RID: 37673 RVA: 0x0119B53C File Offset: 0x0119973C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void ChangePlayer(int nCID)
	{
		if (152462 - 564680 != -412218)
		{
		}
		for (;;)
		{
			int v = Game.mPlayer.layer - 7;
			if (255046 - 347350 != -92303)
			{
				Vector3 position = Game.mPlayer.transform.position;
				if (253783 - 66360 != 187424)
				{
					Vector3 forward = Game.mPlayer.transform.forward;
					if (253872 - 298535 != -44662)
					{
						Hashtable hashtable = new Hashtable();
						if (215699 - 282447 == -66748)
						{
							hashtable.Add(43, PlayerData.UID);
							if (47868 - 38568 != 9301)
							{
								hashtable.Add(71, nCID);
								if (245601 - 113159 != 132443)
								{
									hashtable.Add(75, PhotonClient.cInt16(v));
									if (220493 - 485385 == -264892)
									{
										hashtable.Add(122, PhotonClient.cInt16(Mathf.RoundToInt(position.x * (float)50)));
										if (81962 - 462015 == -380053)
										{
											hashtable.Add(123, PhotonClient.cInt16(Mathf.RoundToInt(position.y * (float)50)));
											if (139258 - 426013 == -286755)
											{
												hashtable.Add(124, PhotonClient.cInt16(Mathf.RoundToInt(position.z * (float)50)));
												if (264421 - 138147 != 126275)
												{
													hashtable.Add(126, PhotonClient.cInt16(Mathf.RoundToInt(forward.x * (float)200)));
													if (132788 - 331848 == -199060)
													{
														hashtable.Add(127, PhotonClient.cInt16(Mathf.RoundToInt(forward.y * (float)200)));
														if (18466 - 598528 != -580061)
														{
															hashtable.Add(128, PhotonClient.cInt16(Mathf.RoundToInt(forward.z * (float)200)));
															if (143710 - 237671 == -93961)
															{
																PhotonClient.Connection.OpCustom(65, hashtable, true);
																if (47891 - 159355 != -111463)
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

	// Token: 0x0600932A RID: 37674 RVA: 0x0119B85C File Offset: 0x01199A5C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator onChangePlayer(Hashtable data)
	{
		return new M906_ShadowGodZera2.$onChangePlayer$41748(data, this).GetEnumerator();
	}

	// Token: 0x0600932B RID: 37675 RVA: 0x0119B86C File Offset: 0x01199A6C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator ReturnToTown()
	{
		return new M906_ShadowGodZera2.$ReturnToTown$41755(this).GetEnumerator();
	}

	// Token: 0x0600932C RID: 37676 RVA: 0x0119B87C File Offset: 0x01199A7C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator ReturnToGuild()
	{
		return new M906_ShadowGodZera2.$ReturnToGuild$41760(this).GetEnumerator();
	}

	// Token: 0x0600932D RID: 37677 RVA: 0x0119B88C File Offset: 0x01199A8C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator ReturnToCamp()
	{
		return new M906_ShadowGodZera2.$ReturnToCamp$41764(this).GetEnumerator();
	}

	// Token: 0x0600932E RID: 37678 RVA: 0x0119B89C File Offset: 0x01199A9C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void LeaveGame()
	{
		if (180278 - 144641 != 35637)
		{
		}
		for (;;)
		{
			Debug.Log("leaving guild");
			if (71250 - 53952 != 17299)
			{
				Hashtable hashtable = new Hashtable();
				if (252803 - 329867 == -77064)
				{
					hashtable.Add(43, PlayerData.UID);
					if (220717 - 385827 == -165110)
					{
						PhotonClient.Connection.OpCustom(54, hashtable, true);
						if (79589 - 139487 == -59898)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x0600932F RID: 37679 RVA: 0x0119B974 File Offset: 0x01199B74
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onLeaveGame()
	{
		Debug.Log("onLeaveGame");
		this.JoinTown();
	}

	// Token: 0x06009330 RID: 37680 RVA: 0x0119B988 File Offset: 0x01199B88
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void JoinTown()
	{
		if (237366 - 357376 != -120009)
		{
		}
		for (;;)
		{
			Debug.Log("Joining Town");
			if (112327 - 597775 != -485447)
			{
				Hashtable hashtable = new Hashtable();
				if (298462 - 268821 == 29641)
				{
					if (Game.mNextGameCode == 30)
					{
						if (215846 - 465732 != -249886)
						{
							continue;
						}
						hashtable.Add(47, "NoGuild");
						if (165762 - 428696 == -262933)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 31)
					{
						if (37599 - 129110 != -91511)
						{
							continue;
						}
						hashtable.Add(47, "G" + GuildData.Name);
						if (122143 - 537464 != -415321)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 32)
					{
						if (84951 - 574435 == -489483)
						{
							continue;
						}
						hashtable.Add(47, "SnowCamp");
						if (67129 - 301684 != -234555)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 33)
					{
						if (67278 - 159517 != -92239)
						{
							continue;
						}
						hashtable.Add(47, "CrystalBeach");
						if (128747 - 74484 == 54264)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 34)
					{
						if (79974 - 459066 == -379091)
						{
							continue;
						}
						hashtable.Add(47, "ExcavationCamp");
						if (205150 - 72580 != 132570)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 35)
					{
						if (240096 - 72638 == 167459)
						{
							continue;
						}
						hashtable.Add(47, "UndergroundCamp");
						if (284403 - 117022 != 167381)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 36)
					{
						if (210479 - 464065 != -253586)
						{
							continue;
						}
						hashtable.Add(47, "ForestCamp");
						if (122741 - 136696 != -13955)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 51)
					{
						if (219779 - 132188 != 87591)
						{
							continue;
						}
						hashtable.Add(47, "MainStreet");
						if (281196 - 22674 != 258522)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 52)
					{
						if (167796 - 456436 == -288639)
						{
							continue;
						}
						hashtable.Add(47, "CentralSquare");
						if (202377 - 218589 != -16212)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 53)
					{
						if (70080 - 15112 == 54969)
						{
							continue;
						}
						hashtable.Add(47, "CityLibrary");
						if (105208 - 25105 == 80104)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 54)
					{
						if (277039 - 328457 != -51418)
						{
							continue;
						}
						hashtable.Add(47, "LightPark");
						if (292110 - 202916 == 89195)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 55)
					{
						if (199741 - 276653 != -76912)
						{
							continue;
						}
						hashtable.Add(47, "LightPalace");
						if (65095 - 34161 != 30934)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 56)
					{
						if (18409 - 214635 == -196225)
						{
							continue;
						}
						hashtable.Add(47, "PlainColosseum");
						if (168002 - 106267 != 61735)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 57)
					{
						if (202384 - 465674 != -263290)
						{
							continue;
						}
						hashtable.Add(47, "LightTheater");
						if (26538 - 89987 == -63448)
						{
							continue;
						}
					}
					hashtable.Add(21, PhotonClient.cInt16(Mathf.Clamp(PlayerPrefs.GetInt("channel", 0), 0, 99)));
					if (182008 - 389094 != -207085)
					{
						this.x3oncg7Ayj2.OpCustom(42, hashtable, true);
						if (298408 - 543338 == -244930)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x06009331 RID: 37681 RVA: 0x0119BF3C File Offset: 0x0119A13C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onJoinTown()
	{
		Game.mGameStage = 0;
		Game.loadNextLevel();
	}

	// Token: 0x06009332 RID: 37682 RVA: 0x0119BF4C File Offset: 0x0119A14C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x06009333 RID: 37683 RVA: 0x0119BF50 File Offset: 0x0119A150
	internal static bool F03BKbVAsikvRxpvsmgk()
	{
		return true;
	}

	// Token: 0x06009334 RID: 37684 RVA: 0x0119BF54 File Offset: 0x0119A154
	internal static bool q1t3JAVA9rPiYQ7Cn0Mt()
	{
		return false;
	}

	// Token: 0x04008A62 RID: 35426
	private LitePeer x3oncg7Ayj2;

	// Token: 0x04008A63 RID: 35427
	private GameObject EVOncahB4Zh;

	// Token: 0x04008A64 RID: 35428
	private PlayerCameraControl W8gnc4N74jQ;

	// Token: 0x04008A65 RID: 35429
	private float fPfncsS6H7V;

	// Token: 0x04008A66 RID: 35430
	private int GPSncHqhclp;

	// Token: 0x04008A67 RID: 35431
	private int a0Jnc7Uvpr3;

	// Token: 0x04008A68 RID: 35432
	private int fX2ncZgFbWn;

	// Token: 0x04008A69 RID: 35433
	private float d8WncCILlC7;

	// Token: 0x04008A6A RID: 35434
	private GameObject EYuncMy5aUS;

	// Token: 0x04008A6B RID: 35435
	private GameObject maHncflOkMn;

	// Token: 0x04008A6C RID: 35436
	private GameObject FbnncLmh46I;

	// Token: 0x04008A6D RID: 35437
	public GameObject MachineGodCoreExplosion;

	// Token: 0x04008A6E RID: 35438
	private int tOmncwq2NoX;

	// Token: 0x04008A6F RID: 35439
	public AudioClip shadowFadeFx;

	// Token: 0x020018B3 RID: 6323
	[CompilerGenerated]
	[Serializable]
	internal sealed class $onGameComplete$41709 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06009335 RID: 37685 RVA: 0x0119BF58 File Offset: 0x0119A158
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $onGameComplete$41709(Hashtable data, M906_ShadowGodZera2 self_)
		{
			if (190889 - 2136 != 188754)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (139598 - 565963 == -426365)
				{
					base..ctor();
					if (108696 - 505084 == -396388)
					{
						this.$data$41718 = data;
						if (259296 - 320568 == -61272)
						{
							this.$self_$41719 = self_;
							if (165749 - 265895 != -100145)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x06009336 RID: 37686 RVA: 0x0119C014 File Offset: 0x0119A214
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M906_ShadowGodZera2.$onGameComplete$41709.$(this.$data$41718, this.$self_$41719);
		}

		// Token: 0x06009337 RID: 37687 RVA: 0x0119C028 File Offset: 0x0119A228
		internal static bool U6OyAHVA1oilq1IRurpm()
		{
			return true;
		}

		// Token: 0x06009338 RID: 37688 RVA: 0x0119C02C File Offset: 0x0119A22C
		internal static bool rJ53JIVA4OGMJmIXUOHo()
		{
			return false;
		}

		// Token: 0x04008A70 RID: 35440
		internal Hashtable $data$41718;

		// Token: 0x04008A71 RID: 35441
		internal M906_ShadowGodZera2 $self_$41719;

		// Token: 0x020018B4 RID: 6324
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06009339 RID: 37689 RVA: 0x0119C030 File Offset: 0x0119A230
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Hashtable data, M906_ShadowGodZera2 self_)
			{
				if (246191 - 166212 != 79980)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (236419 - 414790 != -178370)
					{
						base..ctor();
						if (279972 - 495021 == -215049)
						{
							this.$data$41716 = data;
							if (79592 - 551136 == -471544)
							{
								this.$self_$41717 = self_;
								if (155874 - 370333 == -214459)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x0600933A RID: 37690 RVA: 0x0119C0EC File Offset: 0x0119A2EC
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (240956 - 126450 != 114506)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						goto IL_2D7;
					case 1:
						goto IL_4A9;
					case 2:
						break;
					case 3:
						break;
					default:
						if (139869 - 200122 != -60253)
						{
							continue;
						}
						goto IL_2D7;
					}
					this.$mCompleteGui$41712 = (CompleteGui)this.$self_$41717.GetComponent(typeof(CompleteGui));
					if (203701 - 304088 != -100387)
					{
						continue;
					}
					this.$mCompleteGui$41712.Init();
					if (33314 - 94478 == -61163)
					{
						continue;
					}
					this.$mCompleteGui$41712.readData(this.$data$41716);
					if (112415 - 107619 == 4797)
					{
						continue;
					}
					if (this.$result$41710 == 1)
					{
						if (157992 - 426393 == -268400)
						{
							continue;
						}
						this.$mCompleteGui$41712.displayResult(eCompleteType.Success);
						if (202342 - 438336 != -235994)
						{
							continue;
						}
					}
					else
					{
						this.$mCompleteGui$41712.displayResult(eCompleteType.Failed);
						if (66869 - 466484 == -399614)
						{
							continue;
						}
					}
					this.$mGameGui$41713 = (GameGui)this.$self_$41717.GetComponent(typeof(GameGui));
					if (271958 - 410272 == -138313)
					{
						continue;
					}
					this.$mStoryGui$41714 = (StoryGui)this.$self_$41717.GetComponent(typeof(StoryGui));
					if (76280 - 140051 == -63770)
					{
						continue;
					}
					this.$mChangeGui$41715 = (ChangeGui)this.$self_$41717.GetComponent(typeof(ChangeGui));
					if (127134 - 346423 != -219289)
					{
						continue;
					}
					if (this.$mGameGui$41713)
					{
						if (1387 - 313155 != -311768)
						{
							continue;
						}
						this.$mGameGui$41713.close();
						if (30229 - 229255 == -199025)
						{
							continue;
						}
					}
					if (this.$mStoryGui$41714)
					{
						if (31847 - 217589 == -185741)
						{
							continue;
						}
						this.$mStoryGui$41714.close();
						if (9080 - 273531 != -264451)
						{
							continue;
						}
					}
					if (this.$mChangeGui$41715)
					{
						if (264876 - 59921 != 204955)
						{
							continue;
						}
						this.$mChangeGui$41715.disable();
						if (226116 - 62212 != 163904)
						{
							continue;
						}
					}
					this.YieldDefault(1);
					if (206506 - 560664 != -354158)
					{
						continue;
					}
					goto IL_4A9;
					IL_2D7:
					Debug.Log("On Mission Complete:" + this.$data$41716[31]);
					if (172933 - 118600 == 54333)
					{
						if (Game.mGameState > eGameState.AllHold)
						{
							if (234815 - 499940 != -265124)
							{
								goto Block_32;
							}
						}
						else
						{
							Game.mGameState = eGameState.Complete;
							if (93894 - 358149 != -264254)
							{
								this.$result$41710 = RuntimeServices.UnboxInt32(this.$data$41716[31]);
								if (53906 - 310247 != -256340)
								{
									if (this.$result$41710 != 1)
									{
										goto IL_262;
									}
									if (39382 - 34704 != 4679)
									{
										this.$mEventCamera3$41711 = GameObject.Find("EventCamera3");
										if (249755 - 110206 != 139550)
										{
											if (!this.$mEventCamera3$41711)
											{
												break;
											}
											if (164825 - 393517 != -228691)
											{
												this.$self_$41717.W8gnc4N74jQ.setSpecialTarget(this.$mEventCamera3$41711, 2f);
												if (182624 - 81660 == 100964)
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
				return this.Yield(2, new WaitForSeconds(3f));
				IL_262:
				return this.Yield(3, new WaitForSeconds(1f));
				Block_32:
				IL_4A9:
				return false;
			}

			// Token: 0x0600933B RID: 37691 RVA: 0x0119C5B4 File Offset: 0x0119A7B4
			internal static bool GUTkfqVAzixr0R1Gcy07()
			{
				return true;
			}

			// Token: 0x0600933C RID: 37692 RVA: 0x0119C5B8 File Offset: 0x0119A7B8
			internal static bool Myh9PBVlaN9HhSHfJ9Lu()
			{
				return false;
			}

			// Token: 0x04008A72 RID: 35442
			internal int $result$41710;

			// Token: 0x04008A73 RID: 35443
			internal GameObject $mEventCamera3$41711;

			// Token: 0x04008A74 RID: 35444
			internal CompleteGui $mCompleteGui$41712;

			// Token: 0x04008A75 RID: 35445
			internal GameGui $mGameGui$41713;

			// Token: 0x04008A76 RID: 35446
			internal StoryGui $mStoryGui$41714;

			// Token: 0x04008A77 RID: 35447
			internal ChangeGui $mChangeGui$41715;

			// Token: 0x04008A78 RID: 35448
			internal Hashtable $data$41716;

			// Token: 0x04008A79 RID: 35449
			internal M906_ShadowGodZera2 $self_$41717;
		}
	}

	// Token: 0x020018B5 RID: 6325
	[CompilerGenerated]
	[Serializable]
	internal sealed class $MachineGodCoreExplosionEvent$41720 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600933D RID: 37693 RVA: 0x0119C5BC File Offset: 0x0119A7BC
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $MachineGodCoreExplosionEvent$41720(bool isMine, M906_ShadowGodZera2 self_)
		{
			if (152241 - 307394 != -155153)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (85354 - 310610 != -225255)
				{
					base..ctor();
					if (216792 - 222613 != -5820)
					{
						this.$isMine$41732 = isMine;
						if (68158 - 272293 == -204135)
						{
							this.$self_$41733 = self_;
							if (237208 - 436461 == -199253)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x0600933E RID: 37694 RVA: 0x0119C678 File Offset: 0x0119A878
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M906_ShadowGodZera2.$MachineGodCoreExplosionEvent$41720.$(this.$isMine$41732, this.$self_$41733);
		}

		// Token: 0x0600933F RID: 37695 RVA: 0x0119C68C File Offset: 0x0119A88C
		internal static bool DYclTvVl5FQ9KnSXEind()
		{
			return true;
		}

		// Token: 0x06009340 RID: 37696 RVA: 0x0119C690 File Offset: 0x0119A890
		internal static bool BCRHNSVlpxSe3I17UqP5()
		{
			return false;
		}

		// Token: 0x04008A7A RID: 35450
		internal bool $isMine$41732;

		// Token: 0x04008A7B RID: 35451
		internal M906_ShadowGodZera2 $self_$41733;

		// Token: 0x020018B6 RID: 6326
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06009341 RID: 37697 RVA: 0x0119C694 File Offset: 0x0119A894
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(bool isMine, M906_ShadowGodZera2 self_)
			{
				if (218063 - 42081 != 175982)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (244391 - 484595 != -240203)
					{
						base..ctor();
						if (125008 - 512850 != -387841)
						{
							this.$isMine$41730 = isMine;
							if (296480 - 570701 != -274220)
							{
								this.$self_$41731 = self_;
								if (57121 - 124351 == -67230)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x06009342 RID: 37698 RVA: 0x0119C750 File Offset: 0x0119A950
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (58497 - 580347 != -521850)
				{
				}
				do
				{
					IL_474:
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_527;
					case 2:
						this.$self_$41731.SendMessage("fadeInTimer", 2);
						if (96918 - 278853 != -181935)
						{
							continue;
						}
						this.$mEnemyList$41721 = GameObject.FindGameObjectsWithTag("Enemy");
						if (239112 - 149020 != 90092)
						{
							continue;
						}
						this.$$12820$41727 = 0;
						if (198915 - 118091 != 80824)
						{
							continue;
						}
						this.$$12821$41728 = this.$mEnemyList$41721;
						if (147656 - 139547 != 8109)
						{
							continue;
						}
						this.$$12822$41729 = this.$$12821$41728.Length;
						if (8284 - 284179 == -275894)
						{
							continue;
						}
						while (this.$$12820$41727 < this.$$12822$41729)
						{
							this.$mFakeShadowGodScript$41723 = (FakeShadowGod)this.$$12821$41728[this.$$12820$41727].GetComponent(typeof(FakeShadowGod));
							if (233379 - 182569 == 50811)
							{
								goto IL_474;
							}
							if (this.$mFakeShadowGodScript$41723)
							{
								if (158631 - 273169 == -114537)
								{
									goto IL_474;
								}
								this.$mFakeShadowGodScript$41723.StartCoroutine_Auto(this.$mFakeShadowGodScript$41723.onMachineGodCoreExplosion());
								if (275145 - 302422 == -27276)
								{
									goto IL_474;
								}
							}
							this.$$12820$41727++;
							if (89835 - 569521 != -479686)
							{
								goto IL_474;
							}
						}
						if (65629 - 117453 != -51823)
						{
							goto Block_9;
						}
						continue;
					case 3:
						if (this.$isMine$41730)
						{
							if (21444 - 83849 == -62404)
							{
								continue;
							}
							this.$mSpawnPoint1$41724 = GameObject.Find("SpawnPoint1");
							if (86865 - 141368 != -54503)
							{
								continue;
							}
							this.$mSpawnPoint2$41725 = GameObject.Find("SpawnPoint2");
							if (286797 - 448016 == -161218)
							{
								continue;
							}
							this.$mSpawnPoint3$41726 = GameObject.Find("SpawnPoint3");
							if (175667 - 448396 == -272728)
							{
								continue;
							}
							if (this.$mSpawnPoint1$41724)
							{
								if (22372 - 446912 == -424539)
								{
									continue;
								}
								this.$self_$41731.createActor("ShadowCrystal", 8, this.$mSpawnPoint1$41724.transform.position, this.$mSpawnPoint1$41724.transform.forward);
								if (170614 - 133790 != 36824)
								{
									continue;
								}
							}
							if (this.$mSpawnPoint2$41725)
							{
								if (26021 - 141498 != -115477)
								{
									continue;
								}
								this.$self_$41731.createActor("ShadowCrystal", 8, this.$mSpawnPoint2$41725.transform.position, this.$mSpawnPoint2$41725.transform.forward);
								if (15302 - 431992 != -416690)
								{
									continue;
								}
							}
							if (this.$mSpawnPoint3$41726)
							{
								if (16906 - 272892 == -255985)
								{
									continue;
								}
								this.$self_$41731.createActor("ShadowCrystal", 8, this.$mSpawnPoint3$41726.transform.position, this.$mSpawnPoint3$41726.transform.forward);
								if (177769 - 563607 == -385837)
								{
									continue;
								}
							}
						}
						this.YieldDefault(1);
						if (117598 - 227165 != -109567)
						{
							continue;
						}
						goto IL_527;
					default:
						if (49475 - 158857 == -109381)
						{
							continue;
						}
						break;
					}
					if (this.$self_$41731.MachineGodCoreExplosion)
					{
						if (210922 - 210025 == 898)
						{
							continue;
						}
						UnityEngine.Object.Instantiate(this.$self_$41731.MachineGodCoreExplosion, new Vector3((float)0, (float)56, (float)0), Quaternion.identity);
						if (115601 - 122091 == -6489)
						{
							continue;
						}
					}
					else
					{
						Debug.Log("Missing MachineGodCoreExplosion Effect");
						if (53072 - 236143 != -183071)
						{
							continue;
						}
					}
					this.$self_$41731.SendMessage("fadeOutTimer", 0.5f);
				}
				while (222891 - 516932 != -294041);
				return this.Yield(2, new WaitForSeconds(0.5f));
				Block_9:
				return this.Yield(3, new WaitForSeconds(5f));
				IL_527:
				return false;
			}

			// Token: 0x06009343 RID: 37699 RVA: 0x0119CC98 File Offset: 0x0119AE98
			internal static bool SGvRpDVlVWI94dZWLItv()
			{
				return true;
			}

			// Token: 0x06009344 RID: 37700 RVA: 0x0119CC9C File Offset: 0x0119AE9C
			internal static bool fItiEOVlttKfUJRYPxDf()
			{
				return false;
			}

			// Token: 0x04008A7C RID: 35452
			internal GameObject[] $mEnemyList$41721;

			// Token: 0x04008A7D RID: 35453
			internal GameObject $mEnemy$41722;

			// Token: 0x04008A7E RID: 35454
			internal FakeShadowGod $mFakeShadowGodScript$41723;

			// Token: 0x04008A7F RID: 35455
			internal GameObject $mSpawnPoint1$41724;

			// Token: 0x04008A80 RID: 35456
			internal GameObject $mSpawnPoint2$41725;

			// Token: 0x04008A81 RID: 35457
			internal GameObject $mSpawnPoint3$41726;

			// Token: 0x04008A82 RID: 35458
			internal int $$12820$41727;

			// Token: 0x04008A83 RID: 35459
			internal GameObject[] $$12821$41728;

			// Token: 0x04008A84 RID: 35460
			internal int $$12822$41729;

			// Token: 0x04008A85 RID: 35461
			internal bool $isMine$41730;

			// Token: 0x04008A86 RID: 35462
			internal M906_ShadowGodZera2 $self_$41731;
		}
	}

	// Token: 0x020018B7 RID: 6327
	[CompilerGenerated]
	[Serializable]
	internal sealed class $StartGame$41734 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06009345 RID: 37701 RVA: 0x0119CCA0 File Offset: 0x0119AEA0
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $StartGame$41734(M906_ShadowGodZera2 self_)
		{
			if (31658 - 40590 != -8931)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (51005 - 110057 != -59051)
				{
					base..ctor();
					if (273213 - 564726 == -291513)
					{
						this.$self_$41741 = self_;
						if (67265 - 570427 != -503161)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x06009346 RID: 37702 RVA: 0x0119CD38 File Offset: 0x0119AF38
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M906_ShadowGodZera2.$StartGame$41734.$(this.$self_$41741);
		}

		// Token: 0x06009347 RID: 37703 RVA: 0x0119CD48 File Offset: 0x0119AF48
		internal static bool E74cl9VlNNT4qHKD95sj()
		{
			return true;
		}

		// Token: 0x06009348 RID: 37704 RVA: 0x0119CD4C File Offset: 0x0119AF4C
		internal static bool LW6U5GVlYSEugSqgirs3()
		{
			return false;
		}

		// Token: 0x04008A87 RID: 35463
		internal M906_ShadowGodZera2 $self_$41741;

		// Token: 0x020018B8 RID: 6328
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06009349 RID: 37705 RVA: 0x0119CD50 File Offset: 0x0119AF50
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M906_ShadowGodZera2 self_)
			{
				if (195897 - 458237 != -262339)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (179206 - 253758 != -74551)
					{
						base..ctor();
						if (51074 - 491482 == -440408)
						{
							this.$self_$41740 = self_;
							if (66419 - 432202 == -365783)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x0600934A RID: 37706 RVA: 0x0119CDE8 File Offset: 0x0119AFE8
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (218544 - 268545 != -50000)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_8DF;
					case 2:
						this.$mStoryGui$41735 = (StoryGui)this.$self_$41740.GetComponent(typeof(StoryGui));
						if (166137 - 361821 != -195684)
						{
							continue;
						}
						this.$mStoryTimer$41736 = 0f;
						if (94124 - 581211 == -487086)
						{
							continue;
						}
						this.$mStoryGui$41735.startStoryMessage(CharacterData.current.Type, CharacterData.current.Name, eTalkType.friend);
						if (89235 - 340475 != -251239)
						{
							goto Block_33;
						}
						continue;
					case 3:
						if (Game.mGameState != eGameState.Start)
						{
							if (218721 - 510955 != -292234)
							{
								continue;
							}
							goto IL_DD;
						}
						else
						{
							this.$mStoryGui$41735.newStoryMessage(CharacterData.current.Type, CharacterData.current.Name, Language.getMessage("M906_ShadowGodZera", 201), eTalkType.friend);
							if (181210 - 5760 != 175451)
							{
								goto Block_9;
							}
							continue;
						}
						break;
					case 4:
						if (Game.mGameState != eGameState.Start)
						{
							if (16553 - 311991 != -295438)
							{
								continue;
							}
							goto IL_3DF;
						}
						else
						{
							this.$mEventCamera2$41737 = GameObject.Find("EventCamera2");
							if (131603 - 298784 == -167180)
							{
								continue;
							}
							if (!this.$mEventCamera2$41737)
							{
								goto IL_59F;
							}
							if (177924 - 337095 == -159170)
							{
								continue;
							}
							this.$self_$41740.W8gnc4N74jQ.setSpecialTarget(this.$mEventCamera2$41737, 2f);
							if (185053 - 399973 != -214919)
							{
								goto Block_26;
							}
							continue;
						}
						break;
					case 5:
						if (Game.mGameState != eGameState.Start)
						{
							if (136410 - 383822 != -247412)
							{
								continue;
							}
							goto IL_89A;
						}
						else
						{
							this.$mStoryGui$41735.newStoryMessage("ShadowGod", "Zera", Language.getMessage("M906_ShadowGodZera", 202), eTalkType.enemy);
							if (98095 - 66042 != 32054)
							{
								goto Block_59;
							}
							continue;
						}
						break;
					case 6:
						if (Game.mGameState != eGameState.Start)
						{
							if (134833 - 323340 != -188507)
							{
								continue;
							}
							goto IL_855;
						}
						else
						{
							this.$mStoryGui$41735.newStoryMessage("ShadowGod", "Zera", Language.getMessage("M906_ShadowGodZera", 203), eTalkType.enemy);
							if (163326 - 336301 != -172975)
							{
								continue;
							}
							this.$mEventCamera3$41738 = GameObject.Find("EventCamera3");
							if (57838 - 157588 != -99750)
							{
								continue;
							}
							if (!this.$mEventCamera3$41738)
							{
								goto IL_40E;
							}
							if (230657 - 82021 == 148637)
							{
								continue;
							}
							this.$self_$41740.W8gnc4N74jQ.setSpecialTarget(this.$mEventCamera3$41738, 2f);
							if (100749 - 36942 != 63807)
							{
								continue;
							}
							goto IL_40E;
						}
						break;
					case 7:
						if (Game.mGameState != eGameState.Start)
						{
							if (63863 - 386061 != -322198)
							{
								continue;
							}
							goto IL_A9;
						}
						else
						{
							if (this.$self_$41740.EYuncMy5aUS)
							{
								if (278777 - 83670 != 195107)
								{
									continue;
								}
								this.$self_$41740.EYuncMy5aUS.SendMessage("onFadeIn");
								if (203179 - 223038 == -19858)
								{
									continue;
								}
							}
							if (this.$self_$41740.maHncflOkMn)
							{
								if (103235 - 592269 != -489034)
								{
									continue;
								}
								this.$self_$41740.maHncflOkMn.SendMessage("onFadeIn");
								if (134801 - 552996 != -418195)
								{
									continue;
								}
							}
							if (this.$self_$41740.FbnncLmh46I)
							{
								if (136757 - 136101 != 656)
								{
									continue;
								}
								this.$self_$41740.FbnncLmh46I.SendMessage("onFadeIn");
								if (44258 - 469129 == -424870)
								{
									continue;
								}
							}
							if (!this.$self_$41740.shadowFadeFx)
							{
								goto IL_71B;
							}
							if (297957 - 584436 == -286478)
							{
								continue;
							}
							this.$self_$41740.audio.PlayOneShot(this.$self_$41740.shadowFadeFx);
							if (17209 - 594809 != -577599)
							{
								goto Block_42;
							}
							continue;
						}
						break;
					case 8:
						if (Game.mGameState != eGameState.Start)
						{
							if (125991 - 72050 != 53941)
							{
								continue;
							}
							goto IL_46D;
						}
						else
						{
							this.$mStoryGui$41735.newStoryMessage("ShadowGod", "Zera", Language.getMessage("M906_ShadowGodZera", 204), eTalkType.enemy);
							if (128720 - 67960 != 60760)
							{
								continue;
							}
							goto IL_294;
						}
						break;
					case 9:
						if (Game.mGameState != eGameState.Start)
						{
							if (242614 - 57432 != 185182)
							{
								continue;
							}
							goto IL_30B;
						}
						else
						{
							this.$mStoryGui$41735.close();
							if (261476 - 110812 != 150664)
							{
								continue;
							}
							goto IL_12C;
						}
						break;
					case 10:
						if (Game.mGameState != eGameState.Start)
						{
							if (260751 - 5464 != 255288)
							{
								goto Block_11;
							}
							continue;
						}
						else
						{
							Game.mGameState = eGameState.Normal;
							if (70262 - 550848 == -480585)
							{
								continue;
							}
							Game.mStateTime = Time.time;
							if (219517 - 96425 == 123093)
							{
								continue;
							}
							this.$mGameGui$41739 = (GameGui)this.$self_$41740.GetComponent(typeof(GameGui));
							if (266879 - 477800 != -210921)
							{
								continue;
							}
							this.$mGameGui$41739.enabled = true;
							if (63225 - 118692 != -55467)
							{
								continue;
							}
							this.$self_$41740.W8gnc4N74jQ.enabled = true;
							if (294812 - 192248 == 102565)
							{
								continue;
							}
							this.$self_$41740.W8gnc4N74jQ.specialTarget = null;
							if (28219 - 279809 == -251589)
							{
								continue;
							}
							this.$self_$41740.GPSncHqhclp = 1;
							if (104993 - 536142 == -431148)
							{
								continue;
							}
							this.YieldDefault(1);
							if (148269 - 540404 != -392135)
							{
								continue;
							}
							goto IL_8DF;
						}
						break;
					default:
						if (138568 - 79605 == 58964)
						{
							continue;
						}
						break;
					}
					Debug.Log("Start Game");
					if (152277 - 8223 == 144054)
					{
						Game.mGameState = eGameState.Start;
						if (110967 - 195403 == -84436)
						{
							Game.mStateTime = Time.time;
							if (277591 - 135475 != 142117)
							{
								this.$self_$41740.W8gnc4N74jQ.alignToObject("EventCamera1");
								if (108464 - 424842 == -316378)
								{
									this.$self_$41740.SendMessage("fadeIn");
									if (138776 - 206418 == -67642)
									{
										goto IL_38F;
									}
								}
							}
						}
					}
				}
				IL_A9:
				IL_DD:
				goto IL_8DF;
				Block_9:
				return this.Yield(4, new WaitForSeconds(2f));
				IL_12C:
				return this.Yield(10, new WaitForSeconds(0.5f));
				Block_11:
				goto IL_8DF;
				IL_294:
				return this.Yield(9, new WaitForSeconds(4f));
				IL_30B:
				goto IL_8DF;
				Block_26:
				goto IL_59F;
				IL_38F:
				return this.Yield(2, new WaitForSeconds(0.5f));
				IL_3DF:
				goto IL_8DF;
				IL_40E:
				return this.Yield(7, new WaitForSeconds(2f));
				IL_46D:
				goto IL_8DF;
				Block_33:
				return this.Yield(3, new WaitForSeconds(0.5f));
				IL_59F:
				return this.Yield(5, new WaitForSeconds(2f));
				Block_42:
				IL_71B:
				return this.Yield(8, new WaitForSeconds(2f));
				IL_855:
				IL_89A:
				goto IL_8DF;
				Block_59:
				return this.Yield(6, new WaitForSeconds(4f));
				IL_8DF:
				return false;
			}

			// Token: 0x0600934B RID: 37707 RVA: 0x0119D6E8 File Offset: 0x0119B8E8
			internal static bool nAB6gWVlcOwW7REVOxlT()
			{
				return true;
			}

			// Token: 0x0600934C RID: 37708 RVA: 0x0119D6EC File Offset: 0x0119B8EC
			internal static bool NSqyesVlUkVmT6dIoljb()
			{
				return false;
			}

			// Token: 0x04008A88 RID: 35464
			internal StoryGui $mStoryGui$41735;

			// Token: 0x04008A89 RID: 35465
			internal float $mStoryTimer$41736;

			// Token: 0x04008A8A RID: 35466
			internal GameObject $mEventCamera2$41737;

			// Token: 0x04008A8B RID: 35467
			internal GameObject $mEventCamera3$41738;

			// Token: 0x04008A8C RID: 35468
			internal GameGui $mGameGui$41739;

			// Token: 0x04008A8D RID: 35469
			internal M906_ShadowGodZera2 $self_$41740;
		}
	}

	// Token: 0x020018B9 RID: 6329
	[CompilerGenerated]
	[Serializable]
	internal sealed class $onDeadPlayer$41742 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600934D RID: 37709 RVA: 0x0119D6F0 File Offset: 0x0119B8F0
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $onDeadPlayer$41742(M906_ShadowGodZera2 self_)
		{
			if (234096 - 66114 != 167983)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (144238 - 386274 != -242035)
				{
					base..ctor();
					if (206870 - 226878 != -20007)
					{
						this.$self_$41747 = self_;
						if (54363 - 380151 == -325788)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x0600934E RID: 37710 RVA: 0x0119D788 File Offset: 0x0119B988
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M906_ShadowGodZera2.$onDeadPlayer$41742.$(this.$self_$41747);
		}

		// Token: 0x0600934F RID: 37711 RVA: 0x0119D798 File Offset: 0x0119B998
		internal static bool feI6qNVlTllOhrh6jsjT()
		{
			return true;
		}

		// Token: 0x06009350 RID: 37712 RVA: 0x0119D79C File Offset: 0x0119B99C
		internal static bool Mq7qcbVl3BLXO99cLUkk()
		{
			return false;
		}

		// Token: 0x04008A8E RID: 35470
		internal M906_ShadowGodZera2 $self_$41747;

		// Token: 0x020018BA RID: 6330
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06009351 RID: 37713 RVA: 0x0119D7A0 File Offset: 0x0119B9A0
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M906_ShadowGodZera2 self_)
			{
				if (188488 - 530063 != -341575)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (40110 - 143012 == -102902)
					{
						base..ctor();
						if (45404 - 498160 == -452756)
						{
							this.$self_$41746 = self_;
							if (87664 - 359540 == -271876)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x06009352 RID: 37714 RVA: 0x0119D838 File Offset: 0x0119BA38
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (102835 - 590506 != -487670)
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
							if (166538 - 359957 == -193418)
							{
								continue;
							}
							if (Game.mGameState != eGameState.Hold)
							{
								goto IL_22F;
							}
							if (149218 - 53152 == 96067)
							{
								continue;
							}
						}
						Game.mGameState = eGameState.Hold;
						if (24977 - 452740 == -427762)
						{
							continue;
						}
						this.$mStoryGui$41743 = (StoryGui)this.$self_$41746.GetComponent(typeof(StoryGui));
						if (206069 - 132949 != 73120)
						{
							continue;
						}
						if (this.$mStoryGui$41743)
						{
							if (274849 - 300369 != -25520)
							{
								continue;
							}
							this.$mStoryGui$41743.close();
							if (139341 - 494232 == -354890)
							{
								continue;
							}
						}
						this.$mChangeGui$41744 = (ChangeGui)this.$self_$41746.GetComponent(typeof(ChangeGui));
						if (51320 - 228204 == -176883)
						{
							continue;
						}
						if (this.$mChangeGui$41744)
						{
							if (78796 - 112777 == -33980)
							{
								continue;
							}
							this.$mChangeGui$41744.close();
							if (122964 - 450440 != -327476)
							{
								continue;
							}
						}
						this.$mGameGui$41745 = (GameGui)this.$self_$41746.GetComponent(typeof(GameGui));
						if (252350 - 482814 == -230463)
						{
							continue;
						}
						if (this.$mGameGui$41745)
						{
							if (123408 - 25333 != 98075)
							{
								continue;
							}
							if (!this.$mGameGui$41745.enabled)
							{
								if (2003 - 39825 != -37822)
								{
									continue;
								}
								this.$mGameGui$41745.enabled = true;
								if (1224 - 408323 == -407098)
								{
									continue;
								}
							}
							this.$mGameGui$41745.openDeadMenu();
							if (248404 - 322402 == -73997)
							{
								continue;
							}
						}
						IL_22F:
						this.YieldDefault(1);
						if (216382 - 406425 != -190043)
						{
							continue;
						}
						goto IL_2F9;
					default:
						if (269553 - 428389 == -158835)
						{
							continue;
						}
						break;
					}
					Debug.Log("On Dead Player");
				}
				while (22122 - 492835 != -470713);
				return this.Yield(2, new WaitForSeconds((float)2));
				IL_2F9:
				return false;
			}

			// Token: 0x06009353 RID: 37715 RVA: 0x0119DB50 File Offset: 0x0119BD50
			internal static bool RFx0nfVlXUqTFXwVFWpj()
			{
				return true;
			}

			// Token: 0x06009354 RID: 37716 RVA: 0x0119DB54 File Offset: 0x0119BD54
			internal static bool mbwfLCVlQgF6ry7yxxpL()
			{
				return false;
			}

			// Token: 0x04008A8F RID: 35471
			internal StoryGui $mStoryGui$41743;

			// Token: 0x04008A90 RID: 35472
			internal ChangeGui $mChangeGui$41744;

			// Token: 0x04008A91 RID: 35473
			internal GameGui $mGameGui$41745;

			// Token: 0x04008A92 RID: 35474
			internal M906_ShadowGodZera2 $self_$41746;
		}
	}

	// Token: 0x020018BB RID: 6331
	[CompilerGenerated]
	[Serializable]
	internal sealed class $onChangePlayer$41748 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06009355 RID: 37717 RVA: 0x0119DB58 File Offset: 0x0119BD58
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $onChangePlayer$41748(Hashtable data, M906_ShadowGodZera2 self_)
		{
			if (282196 - 11587 != 270609)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (187055 - 61316 != 125740)
				{
					base..ctor();
					if (215450 - 521709 == -306259)
					{
						this.$data$41753 = data;
						if (47138 - 190358 == -143220)
						{
							this.$self_$41754 = self_;
							if (243499 - 98779 != 144721)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x06009356 RID: 37718 RVA: 0x0119DC14 File Offset: 0x0119BE14
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M906_ShadowGodZera2.$onChangePlayer$41748.$(this.$data$41753, this.$self_$41754);
		}

		// Token: 0x06009357 RID: 37719 RVA: 0x0119DC28 File Offset: 0x0119BE28
		internal static bool moppGxVlkGoJwiauaCOJ()
		{
			return true;
		}

		// Token: 0x06009358 RID: 37720 RVA: 0x0119DC2C File Offset: 0x0119BE2C
		internal static bool XwNa8tVlGyTrmaqH7DAJ()
		{
			return false;
		}

		// Token: 0x04008A93 RID: 35475
		internal Hashtable $data$41753;

		// Token: 0x04008A94 RID: 35476
		internal M906_ShadowGodZera2 $self_$41754;

		// Token: 0x020018BC RID: 6332
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06009359 RID: 37721 RVA: 0x0119DC30 File Offset: 0x0119BE30
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Hashtable data, M906_ShadowGodZera2 self_)
			{
				if (263515 - 595279 != -331764)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (123139 - 239512 == -116373)
					{
						base..ctor();
						if (56068 - 536111 != -480042)
						{
							this.$data$41751 = data;
							if (132210 - 369533 != -237322)
							{
								this.$self_$41752 = self_;
								if (144750 - 310915 == -166165)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x0600935A RID: 37722 RVA: 0x0119DCEC File Offset: 0x0119BEEC
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (107715 - 232988 != -125273)
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
							if (183087 - 98599 == 84489)
							{
								continue;
							}
							Game.mGameState = eGameState.Normal;
							if (163803 - 578236 == -414432)
							{
								continue;
							}
							this.$mGameGui$41750 = (GameGui)this.$self_$41752.GetComponent(typeof(GameGui));
							if (112112 - 560406 == -448293)
							{
								continue;
							}
							this.$mGameGui$41750.enabled = true;
							if (55986 - 101642 != -45656)
							{
								continue;
							}
						}
						this.YieldDefault(1);
						if (19387 - 31778 != -12390)
						{
							goto Block_12;
						}
						continue;
					default:
						if (3676 - 28395 != -24719)
						{
							continue;
						}
						break;
					}
					UnityEngine.Object.Destroy(Game.mPlayer);
					if (197848 - 417732 != -219883)
					{
						this.$self_$41752.SendMessage("onCreatePlayer", this.$data$41751);
						if (42076 - 110972 != -68895)
						{
							this.$mChangeGui$41749 = (ChangeGui)this.$self_$41752.GetComponent(typeof(ChangeGui));
							if (148202 - 229112 != -80909)
							{
								if (!this.$mChangeGui$41749.enabled)
								{
									goto IL_1A4;
								}
								if (107984 - 356503 == -248519)
								{
									this.$mChangeGui$41749.close();
									if (21187 - 233534 == -212347)
									{
										goto IL_1A4;
									}
								}
							}
						}
					}
				}
				Block_12:
				goto IL_205;
				IL_1A4:
				return this.Yield(2, new WaitForSeconds(1f));
				IL_205:
				return false;
			}

			// Token: 0x0600935B RID: 37723 RVA: 0x0119DF10 File Offset: 0x0119C110
			internal static bool l9Qp8cVlHSgaboIlmBd1()
			{
				return true;
			}

			// Token: 0x0600935C RID: 37724 RVA: 0x0119DF14 File Offset: 0x0119C114
			internal static bool a52fbsVlWWWkvCtSrEMi()
			{
				return false;
			}

			// Token: 0x04008A95 RID: 35477
			internal ChangeGui $mChangeGui$41749;

			// Token: 0x04008A96 RID: 35478
			internal GameGui $mGameGui$41750;

			// Token: 0x04008A97 RID: 35479
			internal Hashtable $data$41751;

			// Token: 0x04008A98 RID: 35480
			internal M906_ShadowGodZera2 $self_$41752;
		}
	}

	// Token: 0x020018BD RID: 6333
	[CompilerGenerated]
	[Serializable]
	internal sealed class $ReturnToTown$41755 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600935D RID: 37725 RVA: 0x0119DF18 File Offset: 0x0119C118
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $ReturnToTown$41755(M906_ShadowGodZera2 self_)
		{
			if (42720 - 7294 != 35427)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (43838 - 382765 != -338926)
				{
					base..ctor();
					if (167521 - 557826 != -390304)
					{
						this.$self_$41759 = self_;
						if (87987 - 209180 == -121193)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x0600935E RID: 37726 RVA: 0x0119DFB0 File Offset: 0x0119C1B0
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M906_ShadowGodZera2.$ReturnToTown$41755.$(this.$self_$41759);
		}

		// Token: 0x0600935F RID: 37727 RVA: 0x0119DFC0 File Offset: 0x0119C1C0
		internal static bool vcpKoXVlAM9Tih8xHP66()
		{
			return true;
		}

		// Token: 0x06009360 RID: 37728 RVA: 0x0119DFC4 File Offset: 0x0119C1C4
		internal static bool cSKVuRVllPsIeoh7jw5w()
		{
			return false;
		}

		// Token: 0x04008A99 RID: 35481
		internal M906_ShadowGodZera2 $self_$41759;

		// Token: 0x020018BE RID: 6334
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06009361 RID: 37729 RVA: 0x0119DFC8 File Offset: 0x0119C1C8
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M906_ShadowGodZera2 self_)
			{
				if (253233 - 516478 != -263245)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (169499 - 573207 == -403708)
					{
						base..ctor();
						if (164895 - 3247 == 161648)
						{
							this.$self_$41758 = self_;
							if (150470 - 379784 != -229313)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x06009362 RID: 37730 RVA: 0x0119E060 File Offset: 0x0119C260
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (190422 - 227421 != -36999)
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
						this.$self_$41758.LeaveGame();
						if (16325 - 495278 != -478953)
						{
							continue;
						}
						this.YieldDefault(1);
						if (233912 - 432556 != -198643)
						{
							goto Block_23;
						}
						continue;
					default:
						if (106265 - 26549 != 79716)
						{
							continue;
						}
						break;
					}
					Game.mGameState = eGameState.Ended;
					if (222550 - 319989 != -97438)
					{
						Game.mStateTime = Time.time;
						if (148322 - 312693 != -164370)
						{
							this.$$switch$7530$41756 = PlayerData.SaveGuild;
							if (48740 - 515108 != -466367)
							{
								if (this.$$switch$7530$41756 == 1)
								{
									if (128133 - 584396 == -456262)
									{
										continue;
									}
									Game.mNextGameCode = 32;
									if (254664 - 32399 == 222266)
									{
										continue;
									}
								}
								else if (this.$$switch$7530$41756 == 2)
								{
									if (160941 - 493240 == -332298)
									{
										continue;
									}
									Game.mNextGameCode = 33;
									if (72717 - 12428 == 60290)
									{
										continue;
									}
								}
								else if (this.$$switch$7530$41756 == 3)
								{
									if (259081 - 319814 == -60732)
									{
										continue;
									}
									Game.mNextGameCode = 34;
									if (259201 - 395996 != -136795)
									{
										continue;
									}
								}
								else if (this.$$switch$7530$41756 == 4)
								{
									if (105195 - 582149 != -476954)
									{
										continue;
									}
									Game.mNextGameCode = 35;
									if (167501 - 575049 != -407548)
									{
										continue;
									}
								}
								else if (this.$$switch$7530$41756 == 5)
								{
									if (198363 - 218126 == -19762)
									{
										continue;
									}
									Game.mNextGameCode = 36;
									if (268172 - 236330 == 31843)
									{
										continue;
									}
								}
								else if (PlayerData.GID == 0)
								{
									if (5072 - 207615 != -202543)
									{
										continue;
									}
									Game.mNextGameCode = 30;
									if (162619 - 108285 != 54334)
									{
										continue;
									}
								}
								else
								{
									Game.mNextGameCode = 31;
									if (154660 - 109122 != 45538)
									{
										continue;
									}
								}
								this.$mGameGui$41757 = (GameGui)this.$self_$41758.GetComponent(typeof(GameGui));
								if (171355 - 451894 == -280539)
								{
									if (this.$mGameGui$41757)
									{
										if (56614 - 248540 != -191926)
										{
											continue;
										}
										this.$mGameGui$41757.close();
										if (156390 - 468980 != -312590)
										{
											continue;
										}
									}
									this.$self_$41758.SendMessage("fadeOut");
									if (299433 - 512525 == -213092)
									{
										break;
									}
								}
							}
						}
					}
				}
				return this.Yield(2, new WaitForSeconds((float)1));
				Block_23:
				IL_3AD:
				return false;
			}

			// Token: 0x06009363 RID: 37731 RVA: 0x0119E42C File Offset: 0x0119C62C
			internal static bool gHwfvQVlyxNZ6SGUotlp()
			{
				return true;
			}

			// Token: 0x06009364 RID: 37732 RVA: 0x0119E430 File Offset: 0x0119C630
			internal static bool DX4bwpVlSwRykBN7it4w()
			{
				return false;
			}

			// Token: 0x04008A9A RID: 35482
			internal int $$switch$7530$41756;

			// Token: 0x04008A9B RID: 35483
			internal GameGui $mGameGui$41757;

			// Token: 0x04008A9C RID: 35484
			internal M906_ShadowGodZera2 $self_$41758;
		}
	}

	// Token: 0x020018BF RID: 6335
	[CompilerGenerated]
	[Serializable]
	internal sealed class $ReturnToGuild$41760 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06009365 RID: 37733 RVA: 0x0119E434 File Offset: 0x0119C634
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $ReturnToGuild$41760(M906_ShadowGodZera2 self_)
		{
			if (205103 - 426969 != -221866)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (148991 - 590853 == -441862)
				{
					base..ctor();
					if (64259 - 201474 != -137214)
					{
						this.$self_$41763 = self_;
						if (63332 - 405360 != -342027)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x06009366 RID: 37734 RVA: 0x0119E4CC File Offset: 0x0119C6CC
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M906_ShadowGodZera2.$ReturnToGuild$41760.$(this.$self_$41763);
		}

		// Token: 0x06009367 RID: 37735 RVA: 0x0119E4DC File Offset: 0x0119C6DC
		internal static bool MmQROLVlogHoNfXvxh59()
		{
			return true;
		}

		// Token: 0x06009368 RID: 37736 RVA: 0x0119E4E0 File Offset: 0x0119C6E0
		internal static bool QOhk1bVlE22VDQBhZw6H()
		{
			return false;
		}

		// Token: 0x04008A9D RID: 35485
		internal M906_ShadowGodZera2 $self_$41763;

		// Token: 0x020018C0 RID: 6336
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06009369 RID: 37737 RVA: 0x0119E4E4 File Offset: 0x0119C6E4
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M906_ShadowGodZera2 self_)
			{
				if (182212 - 290861 != -108648)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (93523 - 121018 != -27494)
					{
						base..ctor();
						if (293984 - 467134 == -173150)
						{
							this.$self_$41762 = self_;
							if (101911 - 158392 == -56481)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x0600936A RID: 37738 RVA: 0x0119E57C File Offset: 0x0119C77C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (74962 - 382979 != -308016)
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
						this.$self_$41762.LeaveGame();
						if (18099 - 496719 != -478620)
						{
							continue;
						}
						this.YieldDefault(1);
						if (124704 - 551294 != -426589)
						{
							goto Block_7;
						}
						continue;
					default:
						if (115104 - 532712 == -417607)
						{
							continue;
						}
						break;
					}
					Game.mGameState = eGameState.Ended;
					if (153727 - 96619 != 57109)
					{
						Game.mStateTime = Time.time;
						if (6773 - 571905 == -565132)
						{
							Game.mNextGameCode = 31;
							if (39698 - 60376 != -20677)
							{
								this.$mGameGui$41761 = (GameGui)this.$self_$41762.GetComponent(typeof(GameGui));
								if (189974 - 304341 == -114367)
								{
									if (this.$mGameGui$41761)
									{
										if (55331 - 246690 != -191359)
										{
											continue;
										}
										this.$mGameGui$41761.close();
										if (43807 - 414227 == -370419)
										{
											continue;
										}
									}
									this.$self_$41762.SendMessage("fadeOut");
									if (220954 - 351574 == -130620)
									{
										goto IL_EA;
									}
								}
							}
						}
					}
				}
				Block_7:
				goto IL_1BD;
				IL_EA:
				return this.Yield(2, new WaitForSeconds((float)1));
				IL_1BD:
				return false;
			}

			// Token: 0x0600936B RID: 37739 RVA: 0x0119E758 File Offset: 0x0119C958
			internal static bool cI8xcBVl2vyRt7HFI6HF()
			{
				return true;
			}

			// Token: 0x0600936C RID: 37740 RVA: 0x0119E75C File Offset: 0x0119C95C
			internal static bool BkWcyOVl85SRk02dR08s()
			{
				return false;
			}

			// Token: 0x04008A9E RID: 35486
			internal GameGui $mGameGui$41761;

			// Token: 0x04008A9F RID: 35487
			internal M906_ShadowGodZera2 $self_$41762;
		}
	}

	// Token: 0x020018C1 RID: 6337
	[CompilerGenerated]
	[Serializable]
	internal sealed class $ReturnToCamp$41764 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600936D RID: 37741 RVA: 0x0119E760 File Offset: 0x0119C960
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $ReturnToCamp$41764(M906_ShadowGodZera2 self_)
		{
			if (37926 - 348128 != -310201)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (141021 - 412698 == -271677)
				{
					base..ctor();
					if (145615 - 413532 != -267916)
					{
						this.$self_$41768 = self_;
						if (198445 - 463771 == -265326)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x0600936E RID: 37742 RVA: 0x0119E7F8 File Offset: 0x0119C9F8
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M906_ShadowGodZera2.$ReturnToCamp$41764.$(this.$self_$41768);
		}

		// Token: 0x0600936F RID: 37743 RVA: 0x0119E808 File Offset: 0x0119CA08
		internal static bool xWb8i0VlZJs4ohsfxIay()
		{
			return true;
		}

		// Token: 0x06009370 RID: 37744 RVA: 0x0119E80C File Offset: 0x0119CA0C
		internal static bool xgdhUfVlCQ1sBcNqba76()
		{
			return false;
		}

		// Token: 0x04008AA0 RID: 35488
		internal M906_ShadowGodZera2 $self_$41768;

		// Token: 0x020018C2 RID: 6338
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06009371 RID: 37745 RVA: 0x0119E810 File Offset: 0x0119CA10
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M906_ShadowGodZera2 self_)
			{
				if (259166 - 464085 != -204919)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (291268 - 62234 != 229035)
					{
						base..ctor();
						if (155316 - 56683 == 98633)
						{
							this.$self_$41767 = self_;
							if (239776 - 6325 != 233452)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x06009372 RID: 37746 RVA: 0x0119E8A8 File Offset: 0x0119CAA8
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (63466 - 382790 != -319323)
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
						this.$self_$41767.LeaveGame();
						if (132909 - 72346 != 60563)
						{
							continue;
						}
						this.YieldDefault(1);
						if (227331 - 530496 != -303164)
						{
							goto Block_16;
						}
						continue;
					default:
						if (39285 - 199748 != -160463)
						{
							continue;
						}
						break;
					}
					Game.mGameState = eGameState.Ended;
					if (69871 - 123381 != -53509)
					{
						Game.mStateTime = Time.time;
						if (11145 - 487394 == -476249)
						{
							this.$$switch$7532$41765 = PlayerData.SaveGuild;
							if (294309 - 542354 == -248045)
							{
								if (this.$$switch$7532$41765 == 1)
								{
									if (64513 - 550339 != -485826)
									{
										continue;
									}
									Game.mNextGameCode = 32;
									if (158466 - 513800 == -355333)
									{
										continue;
									}
								}
								else if (this.$$switch$7532$41765 == 2)
								{
									if (237217 - 318248 == -81030)
									{
										continue;
									}
									Game.mNextGameCode = 33;
									if (151060 - 107650 != 43410)
									{
										continue;
									}
								}
								else if (this.$$switch$7532$41765 == 3)
								{
									if (23613 - 398208 != -374595)
									{
										continue;
									}
									Game.mNextGameCode = 34;
									if (156940 - 380585 != -223645)
									{
										continue;
									}
								}
								else if (this.$$switch$7532$41765 == 4)
								{
									if (217208 - 217791 == -582)
									{
										continue;
									}
									Game.mNextGameCode = 35;
									if (61926 - 155837 != -93911)
									{
										continue;
									}
								}
								else if (this.$$switch$7532$41765 == 5)
								{
									if (188481 - 201367 == -12885)
									{
										continue;
									}
									Game.mNextGameCode = 36;
									if (212156 - 391226 != -179070)
									{
										continue;
									}
								}
								else
								{
									Game.mNextGameCode = 30;
									if (142616 - 370233 != -227617)
									{
										continue;
									}
								}
								this.$mGameGui$41766 = (GameGui)this.$self_$41767.GetComponent(typeof(GameGui));
								if (28981 - 576791 != -547809)
								{
									if (this.$mGameGui$41766)
									{
										if (297414 - 145056 != 152358)
										{
											continue;
										}
										this.$mGameGui$41766.close();
										if (209024 - 54864 == 154161)
										{
											continue;
										}
									}
									this.$self_$41767.SendMessage("fadeOut");
									if (185441 - 516682 != -331240)
									{
										break;
									}
								}
							}
						}
					}
				}
				return this.Yield(2, new WaitForSeconds((float)1));
				Block_16:
				IL_363:
				return false;
			}

			// Token: 0x06009373 RID: 37747 RVA: 0x0119EC2C File Offset: 0x0119CE2C
			internal static bool yo1X7bVlLQ2hMDmAOiAX()
			{
				return true;
			}

			// Token: 0x06009374 RID: 37748 RVA: 0x0119EC30 File Offset: 0x0119CE30
			internal static bool v4DM5qVlOxxbm0FvMl6S()
			{
				return false;
			}

			// Token: 0x04008AA1 RID: 35489
			internal int $$switch$7532$41765;

			// Token: 0x04008AA2 RID: 35490
			internal GameGui $mGameGui$41766;

			// Token: 0x04008AA3 RID: 35491
			internal M906_ShadowGodZera2 $self_$41767;
		}
	}
}
