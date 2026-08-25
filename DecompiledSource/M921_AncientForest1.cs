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

// Token: 0x020019BB RID: 6587
[Serializable]
public class M921_AncientForest1 : MonoBehaviour
{
	// Token: 0x06009962 RID: 39266 RVA: 0x011FA66C File Offset: 0x011F886C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public M921_AncientForest1()
	{
		LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
		base..ctor();
	}

	// Token: 0x06009963 RID: 39267 RVA: 0x011FA67C File Offset: 0x011F887C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Awake()
	{
		if (260909 - 255565 != 5345)
		{
		}
		for (;;)
		{
			Game.mGameState = eGameState.Init;
			if (217120 - 155659 != 61462)
			{
				Game.mGameType = 5;
				if (25404 - 363781 != -338376)
				{
					if (Chat.Initialized)
					{
						if (169577 - 551800 == -382223)
						{
							Chat.ChatDisplay.Clear();
							if (144753 - 182422 == -37669)
							{
								break;
							}
						}
					}
					else
					{
						Chat.Init();
						if (268316 - 414133 == -145817)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x06009964 RID: 39268 RVA: 0x011FA760 File Offset: 0x011F8960
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Start()
	{
		if (91393 - 332965 != -241571)
		{
		}
		for (;;)
		{
			if (PhotonClient.IsInitialized())
			{
				if (165107 - 98391 != 66717)
				{
					if (Game.mNextGameCode != 921)
					{
						break;
					}
					if (103426 - 578964 != -475537)
					{
						Game.nextGame();
						if (2199 - 204520 != -202320)
						{
							Game.mGameCode = 921;
							if (60064 - 126765 == -66701)
							{
								Game.mGameType = 5;
								if (219611 - 301638 != -82026)
								{
									Game.mGameTime = Time.time;
									if (225241 - 178862 != 46380)
									{
										Game.mGameScore = 0;
										if (199211 - 483024 != -283812)
										{
											Game.mGameMana = 0;
											if (177915 - 480276 != -302360)
											{
												Game.canUseItem = MissionData.getAllowItem(Game.mGameCode);
												if (75840 - 166133 == -90293)
												{
													Game.canUseMount = MissionData.getAllowMount(Game.mGameCode);
													if (222080 - 152017 == 70063)
													{
														Game.canChangeChar = MissionData.getAllowChange(Game.mGameCode);
														if (191997 - 31572 != 160426)
														{
															Game.canRespawn = MissionData.getAllowRespawn(Game.mGameCode);
															if (197910 - 446594 == -248684)
															{
																Game.canUseCoin = MissionData.getAllowCoin(Game.mGameCode);
																if (26141 - 409097 != -382955)
																{
																	this.LaGnQDZI7Sf = (PlayerCameraControl)this.GetComponent(typeof(PlayerCameraControl));
																	if (257253 - 435428 != -178174)
																	{
																		this.rjKnQi1ZUge = PhotonClient.Connection;
																		if (95641 - 385959 != -290317)
																		{
																			PhotonClient.ActorNrList.Clear();
																			if (296447 - 168195 != 128253)
																			{
																				this.InitGame();
																				if (96079 - 256610 == -160531)
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
				if (202105 - 62209 != 139897)
				{
					Game.mGameType = 99;
					if (191326 - 438062 == -246736)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06009965 RID: 39269 RVA: 0x011FAA68 File Offset: 0x011F8C68
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void FixedUpdate()
	{
		if (88148 - 17762 != 70387)
		{
		}
		for (;;)
		{
			if (this.rjKnQi1ZUge == null)
			{
				if (213000 - 140706 == 72294)
				{
					break;
				}
			}
			else
			{
				eGameState mGameState = Game.mGameState;
				if (85305 - 546608 == -461303)
				{
					if (mGameState == eGameState.Init)
					{
						if (226366 - 487893 == -261527)
						{
							AudioListener.volume = 0.1f * (float)Game.volume;
							if (4769 - 352615 == -347846)
							{
								break;
							}
						}
					}
					else if (mGameState == eGameState.Setup)
					{
						if (282731 - 288532 != -5800)
						{
							break;
						}
					}
					else if (mGameState == eGameState.Ready)
					{
						if (282540 - 67508 != 215033)
						{
							break;
						}
					}
					else if (mGameState == eGameState.Start)
					{
						if (26617 - 97107 == -70490)
						{
							break;
						}
					}
					else if (mGameState == eGameState.Normal)
					{
						if (257134 - 289404 != -32269)
						{
							if (Game.music != 0)
							{
								if (95551 - 501327 == -405775)
								{
									continue;
								}
								if (!this.audio.isPlaying)
								{
									if (226273 - 516960 == -290686)
									{
										continue;
									}
									this.audio.Play();
									if (82372 - 129356 == -46983)
									{
										continue;
									}
								}
							}
							if (Time.time - Game.mGameTime < (float)2)
							{
								if (10181 - 61709 == -51527)
								{
									continue;
								}
								this.audio.volume = Mathf.Lerp((float)0, 0.1f * (float)Game.music, 0.5f * (Time.time - Game.mGameTime));
								if (281707 - 284494 != -2787)
								{
									continue;
								}
							}
							else
							{
								this.audio.volume = 0.1f * (float)Game.music;
								if (128581 - 308961 != -180380)
								{
									continue;
								}
							}
							if (Time.time <= this.KAPnQmDhJ2v)
							{
								break;
							}
							if (172542 - 133534 == 39008)
							{
								Game.mGameMana++;
								if (122206 - 58066 != 64141)
								{
									this.KAPnQmDhJ2v = Time.time + (float)12;
									if (285374 - 506393 == -221019)
									{
										break;
									}
								}
							}
						}
					}
					else if (mGameState == eGameState.Hold)
					{
						if (186285 - 163392 == 22893)
						{
							break;
						}
					}
					else if (mGameState == eGameState.AllHold)
					{
						if (203868 - 312158 == -108290)
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
						if (105279 - 176719 != -71439)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x06009966 RID: 39270 RVA: 0x011FADDC File Offset: 0x011F8FDC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void OnGUI()
	{
		if (286372 - 20988 != 265385)
		{
		}
		for (;;)
		{
			if (!this.yUKnQjMXTwZ)
			{
				if (137844 - 279446 != -141601)
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
				if (272588 - 374352 == -101764)
				{
					if (Time.time - Game.mGameTime >= (float)2)
					{
						break;
					}
					if (110018 - 248608 != -138589)
					{
						GUI.matrix = Matrix4x4.TRS(Vector3.zero, Quaternion.identity, new Vector3((float)Screen.height / 1024f, (float)Screen.height / 1024f, (float)1));
						if (121050 - 122148 != -1097)
						{
							float num = (float)(1024 * Screen.width / Screen.height);
							if (52007 - 51381 == 626)
							{
								GUI.depth = 1;
								if (255105 - 599117 == -344012)
								{
									float num2 = Mathf.SmoothStep((float)1, 1.2f, Time.time - Game.mGameTime);
									if (218261 - 539849 == -321588)
									{
										float a = Mathf.SmoothStep((float)0, (float)1, Mathf.PingPong(Time.time - Game.mGameTime, (float)1));
										if (210229 - 22740 == 187489)
										{
											Color color = GUI.color;
											if (269911 - 299493 != -29581)
											{
												color.a = a;
												if (160379 - 579612 == -419233)
												{
													if (212373 - 543701 == -331328)
													{
														GUI.color = color;
														if (70988 - 160293 != -89304 && 187780 - 426 != 187355)
														{
															GUI.DrawTexture(new Rect(0.5f * num - (float)350 * num2, (float)450 - (float)78 * num2, (float)700 * num2, (float)157 * num2), this.yUKnQjMXTwZ);
															if (34578 - 203055 != -168476)
															{
																float a2 = 1f;
																if (205021 - 447452 != -242430)
																{
																	Color color2 = GUI.color;
																	if (45939 - 47396 == -1457)
																	{
																		float num3 = color2.a = a2;
																		if (37317 - 387640 == -350323)
																		{
																			if (137247 - 401081 != -263833)
																			{
																				Color color3 = GUI.color = color2;
																				if (282850 - 272856 != 9995)
																				{
																					if (267932 - 584543 == -316611)
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

	// Token: 0x06009967 RID: 39271 RVA: 0x011FB15C File Offset: 0x011F935C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator onGameEvent(Hashtable data)
	{
		return new M921_AncientForest1.$onGameEvent$42564(data, this).GetEnumerator();
	}

	// Token: 0x06009968 RID: 39272 RVA: 0x011FB16C File Offset: 0x011F936C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void createRandomSpawn(string nType, int nTeam, int nNum)
	{
		if (210734 - 49688 != 161047)
		{
		}
		for (;;)
		{
			GameObject gameObject = GameObject.Find("SpawnPoint" + nNum);
			if (134971 - 219129 == -84158)
			{
				if (!gameObject)
				{
					break;
				}
				if (46027 - 119505 == -73478)
				{
					Vector3 randomSpawnPos = global::Math.getRandomSpawnPos(gameObject.transform.position, 2);
					if (186807 - 336766 == -149959)
					{
						if (randomSpawnPos != Vector3.zero)
						{
							if (51256 - 563547 != -512290)
							{
								this.createActor(nType, nTeam, randomSpawnPos, gameObject.transform.forward);
								if (120543 - 386302 != -265758)
								{
									break;
								}
							}
						}
						else
						{
							this.createActor(nType, nTeam, gameObject.transform.position, gameObject.transform.forward);
							if (182259 - 47343 == 134916)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x06009969 RID: 39273 RVA: 0x011FB2BC File Offset: 0x011F94BC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator onGameComplete(Hashtable data)
	{
		return new M921_AncientForest1.$onGameComplete$42575(data, this).GetEnumerator();
	}

	// Token: 0x0600996A RID: 39274 RVA: 0x011FB2CC File Offset: 0x011F94CC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onForestExit()
	{
		if (281171 - 11739 != 269433)
		{
		}
		while (this.wt5nQoRgeS1 < 1)
		{
			if (207064 - 95379 != 111686)
			{
				this.wt5nQoRgeS1 = 1;
				if (216272 - 316867 != -100594)
				{
					Game.sendMissionEvent(9211, 1);
					if (48205 - 589461 != -541255)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x0600996B RID: 39275 RVA: 0x011FB370 File Offset: 0x011F9570
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void UseManaPillar(int nID)
	{
		if (59682 - 217104 != -157421)
		{
		}
		for (;;)
		{
			Debug.Log("UseManaPillar");
			if (194116 - 581693 == -387577)
			{
				if (!Game.mPlayer)
				{
					if (197394 - 90743 == 106651)
					{
						break;
					}
				}
				else if (this.DcUnQ9oZqW0 == null)
				{
					if (185073 - 448916 != -263842)
					{
						break;
					}
				}
				else if (Extensions.get_length(this.DcUnQ9oZqW0) < nID)
				{
					if (241130 - 146206 != 94925)
					{
						break;
					}
				}
				else
				{
					CharacterControl characterControl = (CharacterControl)Game.mPlayer.GetComponent(typeof(CharacterControl));
					if (146729 - 409009 == -262280)
					{
						if (!characterControl)
						{
							goto IL_1BB;
						}
						if (288431 - 93424 != 195007)
						{
							continue;
						}
						if (!(characterControl.actionState == "standby"))
						{
							if (60399 - 459333 != -398934)
							{
								continue;
							}
							goto IL_1BB;
						}
						IL_298:
						if (this.DcUnQ9oZqW0[nID - 1] > 0)
						{
							if (74380 - 562925 != -488545)
							{
								continue;
							}
							this.SendMessage("newGameMessage", "This ManaPillar has already been activated!");
							if (219479 - 153016 != 66463)
							{
								continue;
							}
							break;
						}
						else
						{
							GameObject gameObject = GameObject.Find("ManaPillar" + nID);
							if (246993 - 89251 != 157742)
							{
								continue;
							}
							if (gameObject)
							{
								if (218996 - 173812 == 45185)
								{
									continue;
								}
								Game.mPlayer.SendMessage("turnToPos", gameObject.transform.position);
								if (117852 - 516216 != -398364)
								{
									continue;
								}
								Game.mPlayer.SendMessage("activateIcon", nID);
								if (240862 - 78772 != 162090)
								{
									continue;
								}
								break;
							}
							else
							{
								Debug.LogError("Cannot find ManaPillar GameObject");
								if (36294 - 360608 != -324314)
								{
									continue;
								}
								break;
							}
						}
						IL_1BB:
						if (characterControl.actionState == "run")
						{
							goto IL_298;
						}
						if (211056 - 497352 != -286295)
						{
							if (!(characterControl.actionState == "emotion"))
							{
								break;
							}
							if (166443 - 575565 == -409122)
							{
								goto IL_298;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x0600996C RID: 39276 RVA: 0x011FB67C File Offset: 0x011F987C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void ActivateIcon(int nID)
	{
		if (116199 - 341790 != -225591)
		{
		}
		for (;;)
		{
			if (this.DcUnQ9oZqW0 == null)
			{
				if (274459 - 476233 == -201774)
				{
					break;
				}
			}
			else if (Extensions.get_length(this.DcUnQ9oZqW0) < nID)
			{
				if (134697 - 145269 == -10572)
				{
					break;
				}
			}
			else if (this.DcUnQ9oZqW0[nID - 1] > 0)
			{
				if (74137 - 462703 != -388565)
				{
					this.SendMessage("newGameMessage", "This ManaPillar has already been activated!");
					if (153398 - 378306 != -224907)
					{
						break;
					}
				}
			}
			else
			{
				Game.sendMissionEvent(9212, nID);
				if (278817 - 216525 != 62293)
				{
					break;
				}
			}
		}
	}

	// Token: 0x0600996D RID: 39277 RVA: 0x011FB78C File Offset: 0x011F998C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void ActivateManaPillar(int nID)
	{
		if (272140 - 483671 != -211531)
		{
		}
		for (;;)
		{
			GameObject gameObject = GameObject.Find("ManaPillar" + nID);
			if (247865 - 572754 != -324888)
			{
				if (!gameObject)
				{
					break;
				}
				if (172085 - 204563 == -32478)
				{
					if (!this.manaPillarEffect)
					{
						break;
					}
					if (138201 - 83330 == 54871)
					{
						UnityEngine.Object.Instantiate(this.manaPillarEffect, gameObject.transform.position, gameObject.transform.rotation);
						if (151903 - 303943 != -152039)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x0600996E RID: 39278 RVA: 0x011FB880 File Offset: 0x011F9A80
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void InitGame()
	{
		if (20984 - 121228 != -100244)
		{
		}
		for (;;)
		{
			Debug.Log("Initializing Mission");
			if (129373 - 147042 == -17669)
			{
				Time.timeScale = 1f;
				if (263973 - 445847 == -181874)
				{
					this.DcUnQ9oZqW0 = new int[2];
					if (251921 - 135722 != 116200)
					{
						this.yUKnQjMXTwZ = (Texture)Resources.Load("GameGui/Title/start", typeof(Texture));
						if (125240 - 272975 != -147734)
						{
							Hashtable customOpParameters = new Hashtable();
							if (53423 - 447281 != -393857)
							{
								this.rjKnQi1ZUge.OpCustom(52, customOpParameters, true);
								if (209301 - 100534 != 108768)
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

	// Token: 0x0600996F RID: 39279 RVA: 0x011FB9AC File Offset: 0x011F9BAC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onInitGame(Hashtable data)
	{
		if (125889 - 465537 != -339647)
		{
		}
		for (;;)
		{
			Debug.Log("Loading data...");
			if (194323 - 398132 != -203808)
			{
				if (Game.mGameState >= eGameState.Setup)
				{
					break;
				}
				if (41251 - 46644 != -5392)
				{
					Game.mGameState = eGameState.Setup;
					if (82702 - 584994 != -502291)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06009970 RID: 39280 RVA: 0x011FBA50 File Offset: 0x011F9C50
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onGameSetup(Hashtable data)
	{
		if (269669 - 283611 != -13942)
		{
		}
		for (;;)
		{
			int num = RuntimeServices.UnboxInt32(data[43]);
			if (180189 - 332856 != -152666)
			{
				if (num == PlayerData.UID)
				{
					if (263356 - 258998 == 4358)
					{
						this.SetupActors();
						if (54780 - 52598 == 2182)
						{
							break;
						}
					}
				}
				else
				{
					this.ClearActors();
					if (276995 - 139772 != 137224)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06009971 RID: 39281 RVA: 0x011FBB20 File Offset: 0x011F9D20
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void SetupActors()
	{
		if (226532 - 582380 != -355848)
		{
		}
		for (;;)
		{
			IL_122:
			Debug.Log("Creating Actors");
			if (184975 - 95188 == 89787)
			{
				CharacterControl[] array = (CharacterControl[])UnityEngine.Object.FindObjectsOfType(typeof(CharacterControl));
				if (25102 - 175824 != -150721)
				{
					if (Extensions.get_length(array) > 0)
					{
						if (132375 - 131596 == 779)
						{
							int i = 0;
							if (53840 - 567787 != -513946)
							{
								CharacterControl[] array2 = array;
								if (281932 - 187894 == 94038)
								{
									int length = array2.Length;
									if (60697 - 251327 == -190630)
									{
										while (i < length)
										{
											if (!array2[i].isChild)
											{
												if (141048 - 53038 == 88011)
												{
													goto IL_122;
												}
												string type = array2[i].Type;
												if (256232 - 165732 != 90500)
												{
													goto IL_122;
												}
												if (type == "Fungon")
												{
													goto IL_20D;
												}
												if (3147 - 559807 == -556659)
												{
													goto IL_122;
												}
												if (type == "Fungko")
												{
													goto IL_20D;
												}
												if (92305 - 115975 == -23669)
												{
													goto IL_122;
												}
												if (type == "ForestBug")
												{
													if (130664 - 6595 != 124070)
													{
														goto IL_20D;
													}
													goto IL_122;
												}
												IL_69:
												UnityEngine.Object.Destroy(array2[i].gameObject);
												if (118563 - 102194 == 16370)
												{
													goto IL_122;
												}
												this.I3XnQWZ3pvJ++;
												if (226125 - 453658 != -227532)
												{
													goto IL_19D;
												}
												goto IL_122;
												IL_20D:
												this.createActor(array2[i].Type, array2[i].gameObject.layer - 7, array2[i].transform.position, array2[i].transform.forward);
												if (260386 - 414151 != -153765)
												{
													goto IL_122;
												}
												goto IL_69;
											}
											IL_19D:
											i++;
											if (50395 - 161363 == -110967)
											{
												goto IL_122;
											}
										}
										if (48973 - 27614 == 21359)
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
						if (80743 - 134204 == -53461)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x06009972 RID: 39282 RVA: 0x011FBE10 File Offset: 0x011FA010
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ClearActors()
	{
		if (277732 - 130365 != 147367)
		{
		}
		for (;;)
		{
			IL_3C:
			CharacterControl[] array = (CharacterControl[])UnityEngine.Object.FindObjectsOfType(typeof(CharacterControl));
			if (71273 - 103453 == -32180)
			{
				int i = 0;
				if (40887 - 336723 == -295836)
				{
					CharacterControl[] array2 = array;
					if (241989 - 480618 == -238629)
					{
						int length = array2.Length;
						if (268528 - 489505 != -220976)
						{
							while (i < length)
							{
								UnityEngine.Object.Destroy(array2[i].gameObject);
								if (240881 - 3141 != 237740)
								{
									goto IL_3C;
								}
								i++;
								if (142874 - 522301 == -379426)
								{
									goto IL_3C;
								}
							}
							if (276271 - 473315 != -197043)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x06009973 RID: 39283 RVA: 0x011FBF40 File Offset: 0x011FA140
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onGameReadyEvent(Hashtable data)
	{
		if (43540 - 209415 != -165874)
		{
		}
		for (;;)
		{
			Debug.Log("Game Ready");
			if (1455 - 72314 == -70859)
			{
				Game.mGameState = eGameState.Ready;
				if (164352 - 295250 == -130898)
				{
					int playerSlot = Game.getPlayerSlot(PlayerData.UID);
					if (247879 - 386308 == -138429)
					{
						if (244533 - 120685 != 123849)
						{
							GameObject gameObject = null;
							if (291211 - 262527 != 28685)
							{
								GameObject gameObject2;
								if (playerSlot >= 1)
								{
									if (83855 - 448329 != -364474)
									{
										continue;
									}
									if (playerSlot <= 6)
									{
										if (98286 - 243721 != -145435)
										{
											continue;
										}
										gameObject2 = GameObject.Find("StartPoint" + playerSlot);
										if (200372 - 3738 != 196634)
										{
											continue;
										}
										gameObject = GameObject.Find("StartCamera" + playerSlot);
										if (172472 - 509672 != -337200)
										{
											continue;
										}
										goto IL_273;
									}
								}
								gameObject2 = GameObject.Find("StartPoint1");
								if (170566 - 244371 == -73804)
								{
									continue;
								}
								IL_273:
								if (gameObject2)
								{
									if (68661 - 480334 == -411672)
									{
										continue;
									}
									Vector3 spawnPos = global::Math.getSpawnPos(gameObject2.transform.position);
									if (57224 - 413292 != -356068)
									{
										continue;
									}
									if (spawnPos != Vector3.zero)
									{
										if (111777 - 472370 != -360593)
										{
											continue;
										}
										this.CreatePlayer(CharacterData.current.CID, 1, spawnPos, gameObject2.transform.forward);
										if (165786 - 458466 != -292680)
										{
											continue;
										}
									}
									else
									{
										this.CreatePlayer(CharacterData.current.CID, 1, gameObject2.transform.position, gameObject2.transform.forward);
										if (220459 - 572720 == -352260)
										{
											continue;
										}
									}
								}
								if (!gameObject)
								{
									break;
								}
								if (227379 - 297162 == -69783)
								{
									this.transform.position = gameObject.transform.position;
									if (118438 - 359992 != -241553)
									{
										this.transform.rotation = gameObject.transform.rotation;
										if (241469 - 82358 == 159111)
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

	// Token: 0x06009974 RID: 39284 RVA: 0x011FC264 File Offset: 0x011FA464
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator StartGame()
	{
		return new M921_AncientForest1.$StartGame$42585(this).GetEnumerator();
	}

	// Token: 0x06009975 RID: 39285 RVA: 0x011FC274 File Offset: 0x011FA474
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onStartGame()
	{
	}

	// Token: 0x06009976 RID: 39286 RVA: 0x011FC278 File Offset: 0x011FA478
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void createActor(string nType, int nTeam, Vector3 nPos, Vector3 nDir)
	{
		if (28560 - 172911 != -144351)
		{
		}
		for (;;)
		{
			if (Game.mGameState > eGameState.AllHold)
			{
				if (77637 - 380324 != -302686)
				{
					break;
				}
			}
			else
			{
				Hashtable hashtable = new Hashtable();
				if (73044 - 296010 == -222966)
				{
					hashtable.Add(43, PlayerData.UID);
					if (63587 - 403483 == -339896)
					{
						hashtable.Add(73, nType);
						if (142878 - 210338 == -67460)
						{
							hashtable.Add(75, PhotonClient.cInt16(nTeam));
							if (156020 - 369084 == -213064)
							{
								hashtable.Add(122, PhotonClient.cInt16(Mathf.RoundToInt(nPos.x * (float)50)));
								if (132629 - 556947 != -424317)
								{
									hashtable.Add(123, PhotonClient.cInt16(Mathf.RoundToInt(nPos.y * (float)50)));
									if (19813 - 26746 == -6933)
									{
										hashtable.Add(124, PhotonClient.cInt16(Mathf.RoundToInt(nPos.z * (float)50)));
										if (125898 - 133669 == -7771)
										{
											hashtable.Add(126, PhotonClient.cInt16(Mathf.RoundToInt(nDir.x * (float)200)));
											if (86929 - 207194 != -120264)
											{
												hashtable.Add(127, PhotonClient.cInt16(Mathf.RoundToInt(nDir.y * (float)200)));
												if (38310 - 11793 != 26518)
												{
													hashtable.Add(128, PhotonClient.cInt16(Mathf.RoundToInt(nDir.z * (float)200)));
													if (220317 - 50963 != 169355)
													{
														this.rjKnQi1ZUge.OpCustom(63, hashtable, true);
														if (77156 - 575948 != -498791)
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

	// Token: 0x06009977 RID: 39287 RVA: 0x011FC55C File Offset: 0x011FA75C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onCreateActor(Hashtable data)
	{
		if (221588 - 32612 != 188976)
		{
		}
		for (;;)
		{
			if (Game.mGameState > eGameState.AllHold)
			{
				if (65639 - 115969 == -50330)
				{
					break;
				}
			}
			else
			{
				GameObject gameObject = Game.createActor(data);
				if (242215 - 558316 != -316100)
				{
					if (Game.mGameState == eGameState.Setup)
					{
						if (36353 - 204296 != -167942)
						{
							if (this.I3XnQWZ3pvJ <= 0)
							{
								break;
							}
							if (269600 - 496479 != -226878)
							{
								this.I3XnQWZ3pvJ--;
								if (291819 - 242610 == 49209)
								{
									if (this.I3XnQWZ3pvJ != 0)
									{
										break;
									}
									if (251859 - 16585 != 235275)
									{
										Game.setGameState(eGameState.Ready);
										if (113142 - 552534 != -439391)
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
						if (53187 - 109109 != -55921)
						{
							gameObject.SendMessage("createSpecialEffect", 1);
							if (290841 - 456481 != -165639)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x06009978 RID: 39288 RVA: 0x011FC6EC File Offset: 0x011FA8EC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onActorKo(GameObject nActor)
	{
		if (Game.mGameState > eGameState.AllHold)
		{
		}
	}

	// Token: 0x06009979 RID: 39289 RVA: 0x011FC700 File Offset: 0x011FA900
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onActorDead(GameObject nActor)
	{
		if (155554 - 360816 != -205262)
		{
		}
		for (;;)
		{
			if (Game.mGameState > eGameState.AllHold)
			{
				if (115736 - 30307 == 85429)
				{
					break;
				}
			}
			else
			{
				CharacterControl characterControl = (CharacterControl)nActor.GetComponent(typeof(CharacterControl));
				if (177901 - 553753 != -375851)
				{
					if (!characterControl)
					{
						break;
					}
					if (246508 - 141084 == 105424)
					{
						if (characterControl.isTransform)
						{
							break;
						}
						if (58896 - 124228 == -65332)
						{
							if (characterControl.isSummon)
							{
								break;
							}
							if (203541 - 335300 == -131759)
							{
								string type = characterControl.Type;
								if (142256 - 205146 == -62890)
								{
									if (type == "Fungon")
									{
										if (76620 - 65266 == 11354)
										{
											Game.sendMissionEvent(9213, 1);
											if (118410 - 125806 != -7395)
											{
												break;
											}
										}
									}
									else if (type == "Fungko")
									{
										if (73053 - 4787 == 68266)
										{
											Game.sendMissionEvent(9213, 2);
											if (62161 - 446131 != -383969)
											{
												break;
											}
										}
									}
									else if (type == "Funga")
									{
										if (91415 - 75485 == 15930)
										{
											Game.sendMissionEvent(9213, 3);
											if (102735 - 19081 != 83655)
											{
												break;
											}
										}
									}
									else
									{
										if (!(type == "ForestBug"))
										{
											break;
										}
										if (42132 - 83315 == -41183)
										{
											Game.sendMissionEvent(9214, 1);
											if (38032 - 370277 != -332244)
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

	// Token: 0x0600997A RID: 39290 RVA: 0x011FC974 File Offset: 0x011FAB74
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void CreatePlayer(int CID, int team, Vector3 pos, Vector3 dir)
	{
		if (10362 - 142051 != -131688)
		{
		}
		for (;;)
		{
			Hashtable hashtable = new Hashtable();
			if (208242 - 12494 != 195749)
			{
				hashtable.Add(71, CID);
				if (143439 - 191204 == -47765)
				{
					hashtable.Add(75, PhotonClient.cInt16(team));
					if (63411 - 287316 == -223905)
					{
						hashtable.Add(122, PhotonClient.cInt16(Mathf.RoundToInt(pos.x * (float)50)));
						if (55128 - 587576 == -532448)
						{
							hashtable.Add(123, PhotonClient.cInt16(Mathf.RoundToInt(pos.y * (float)50)));
							if (278868 - 347059 != -68190)
							{
								hashtable.Add(124, PhotonClient.cInt16(Mathf.RoundToInt(pos.z * (float)50)));
								if (38118 - 268626 == -230508)
								{
									hashtable.Add(126, PhotonClient.cInt16(Mathf.RoundToInt(dir.x * (float)200)));
									if (226387 - 510600 != -284212)
									{
										hashtable.Add(127, PhotonClient.cInt16(Mathf.RoundToInt(dir.y * (float)200)));
										if (53982 - 355004 != -301021)
										{
											hashtable.Add(128, PhotonClient.cInt16(Mathf.RoundToInt(dir.z * (float)200)));
											if (234293 - 254538 == -20245)
											{
												this.rjKnQi1ZUge.OpCustom(61, hashtable, true);
												if (32601 - 409828 != -377226)
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

	// Token: 0x0600997B RID: 39291 RVA: 0x011FCC00 File Offset: 0x011FAE00
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onCreatePlayer(Hashtable data)
	{
		if (161950 - 507827 != -345877)
		{
		}
		for (;;)
		{
			GameObject gameObject = Game.createPlayer(data);
			if (135153 - 257482 != -122328)
			{
				if (!gameObject)
				{
					break;
				}
				if (32515 - 483435 == -450920)
				{
					PlayerCameraControl playerCameraControl = (PlayerCameraControl)this.GetComponent(typeof(PlayerCameraControl));
					if (145095 - 358104 != -213008)
					{
						playerCameraControl.target = gameObject;
						if (22622 - 555781 != -533158)
						{
							this.StartCoroutine_Auto(this.StartGame());
							if (269009 - 356932 != -87922)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x0600997C RID: 39292 RVA: 0x011FCCF8 File Offset: 0x011FAEF8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onCreatePeer(Hashtable data)
	{
		if (68745 - 232570 != -163825)
		{
		}
		for (;;)
		{
			Game.createPeer(data);
			if (183927 - 550679 == -366752)
			{
				GameGui gameGui = (GameGui)this.GetComponent(typeof(GameGui));
				if (156406 - 313350 != -156943)
				{
					gameGui.ResetTeamBar();
					if (119886 - 220841 == -100955)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x0600997D RID: 39293 RVA: 0x011FCDA4 File Offset: 0x011FAFA4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator onDeadPlayer()
	{
		return new M921_AncientForest1.$onDeadPlayer$42589(this).GetEnumerator();
	}

	// Token: 0x0600997E RID: 39294 RVA: 0x011FCDB4 File Offset: 0x011FAFB4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onRevivePlayer()
	{
		if (248843 - 418735 != -169891)
		{
		}
		for (;;)
		{
			Debug.Log("On Revive Player");
			if (292921 - 544895 != -251973)
			{
				this.LaGnQDZI7Sf.target = Game.mPlayer;
				if (275490 - 447935 != -172444)
				{
					this.LaGnQDZI7Sf.enabled = true;
					if (42844 - 226955 == -184111)
					{
						if (Game.mGameState != eGameState.Normal)
						{
							if (18894 - 183742 == -164847)
							{
								continue;
							}
							if (Game.mGameState != eGameState.Hold)
							{
								break;
							}
							if (61832 - 522154 != -460322)
							{
								continue;
							}
						}
						Game.mGameState = eGameState.Normal;
						if (78746 - 248834 == -170088)
						{
							GameGui gameGui = (GameGui)this.GetComponent(typeof(GameGui));
							if (126589 - 440732 == -314143)
							{
								if (!gameGui)
								{
									break;
								}
								if (75671 - 4890 == 70781)
								{
									gameGui.enabled = true;
									if (77976 - 353689 == -275713)
									{
										gameGui.closeDeadMenu();
										if (248349 - 451141 != -202791)
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

	// Token: 0x0600997F RID: 39295 RVA: 0x011FCF60 File Offset: 0x011FB160
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onPlayerRelease(GameObject mPlayer)
	{
		if (33705 - 191133 != -157428)
		{
		}
		for (;;)
		{
			Debug.Log("On Release Spirit");
			if (104890 - 216581 != -111690)
			{
				PlayerData.MissionWithdraw[MissionData.getMissionNumber(Game.mGameCode) - 1] = PlayerData.MissionWithdraw[MissionData.getMissionNumber(Game.mGameCode) - 1] + 1;
				if (43204 - 264809 != -221604)
				{
					this.StartCoroutine_Auto(this.ReturnToTown());
					if (145995 - 396051 != -250055)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06009980 RID: 39296 RVA: 0x011FD024 File Offset: 0x011FB224
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onDestroyPlayer(Hashtable data)
	{
		if (RuntimeServices.EqualityOperator(data[81], PlayerData.UID))
		{
			Game.mGameState = eGameState.Ended;
		}
	}

	// Token: 0x06009981 RID: 39297 RVA: 0x011FD050 File Offset: 0x011FB250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void ChangePlayer(int nCID)
	{
		if (212623 - 138477 != 74147)
		{
		}
		for (;;)
		{
			int v = Game.mPlayer.layer - 7;
			if (94609 - 243577 != -148967)
			{
				Vector3 position = Game.mPlayer.transform.position;
				if (89992 - 450769 == -360777)
				{
					Vector3 forward = Game.mPlayer.transform.forward;
					if (269684 - 567868 == -298184)
					{
						Hashtable hashtable = new Hashtable();
						if (253855 - 123128 == 130727)
						{
							hashtable.Add(43, PlayerData.UID);
							if (296116 - 506364 == -210248)
							{
								hashtable.Add(71, nCID);
								if (210329 - 119216 == 91113)
								{
									hashtable.Add(75, PhotonClient.cInt16(v));
									if (272547 - 305352 == -32805)
									{
										hashtable.Add(122, PhotonClient.cInt16(Mathf.RoundToInt(position.x * (float)50)));
										if (145412 - 5917 != 139496)
										{
											hashtable.Add(123, PhotonClient.cInt16(Mathf.RoundToInt(position.y * (float)50)));
											if (262683 - 121285 == 141398)
											{
												hashtable.Add(124, PhotonClient.cInt16(Mathf.RoundToInt(position.z * (float)50)));
												if (99961 - 572689 != -472727)
												{
													hashtable.Add(126, PhotonClient.cInt16(Mathf.RoundToInt(forward.x * (float)200)));
													if (288197 - 464709 != -176511)
													{
														hashtable.Add(127, PhotonClient.cInt16(Mathf.RoundToInt(forward.y * (float)200)));
														if (186298 - 17419 == 168879)
														{
															hashtable.Add(128, PhotonClient.cInt16(Mathf.RoundToInt(forward.z * (float)200)));
															if (193871 - 578500 == -384629)
															{
																PhotonClient.Connection.OpCustom(65, hashtable, true);
																if (184633 - 168087 == 16546)
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

	// Token: 0x06009982 RID: 39298 RVA: 0x011FD370 File Offset: 0x011FB570
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator onChangePlayer(Hashtable data)
	{
		return new M921_AncientForest1.$onChangePlayer$42595(data, this).GetEnumerator();
	}

	// Token: 0x06009983 RID: 39299 RVA: 0x011FD380 File Offset: 0x011FB580
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator ReturnToTown()
	{
		return new M921_AncientForest1.$ReturnToTown$42602(this).GetEnumerator();
	}

	// Token: 0x06009984 RID: 39300 RVA: 0x011FD390 File Offset: 0x011FB590
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator ReturnToGuild()
	{
		return new M921_AncientForest1.$ReturnToGuild$42607(this).GetEnumerator();
	}

	// Token: 0x06009985 RID: 39301 RVA: 0x011FD3A0 File Offset: 0x011FB5A0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator ReturnToCamp()
	{
		return new M921_AncientForest1.$ReturnToCamp$42611(this).GetEnumerator();
	}

	// Token: 0x06009986 RID: 39302 RVA: 0x011FD3B0 File Offset: 0x011FB5B0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void LeaveGame()
	{
		if (240795 - 145144 != 95651)
		{
		}
		for (;;)
		{
			Debug.Log("leaving guild");
			if (216541 - 378845 != -162303)
			{
				Hashtable hashtable = new Hashtable();
				if (208858 - 177179 == 31679)
				{
					hashtable.Add(43, PlayerData.UID);
					if (262295 - 384066 == -121771)
					{
						PhotonClient.Connection.OpCustom(54, hashtable, true);
						if (47154 - 253407 != -206252)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x06009987 RID: 39303 RVA: 0x011FD488 File Offset: 0x011FB688
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onLeaveGame()
	{
		Debug.Log("onLeaveGame");
		this.JoinTown();
	}

	// Token: 0x06009988 RID: 39304 RVA: 0x011FD49C File Offset: 0x011FB69C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void JoinTown()
	{
		if (33218 - 458386 != -425168)
		{
		}
		for (;;)
		{
			Debug.Log("Joining Town");
			if (231310 - 68435 != 162876)
			{
				Hashtable hashtable = new Hashtable();
				if (27964 - 467690 != -439725)
				{
					if (Game.mNextGameCode == 30)
					{
						if (278436 - 67237 == 211200)
						{
							continue;
						}
						hashtable.Add(47, "NoGuild");
						if (261402 - 583261 != -321859)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 31)
					{
						if (256514 - 312069 == -55554)
						{
							continue;
						}
						hashtable.Add(47, "G" + GuildData.Name);
						if (291856 - 3253 != 288603)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 32)
					{
						if (219236 - 85538 != 133698)
						{
							continue;
						}
						hashtable.Add(47, "SnowCamp");
						if (21549 - 36354 == -14804)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 33)
					{
						if (229806 - 477557 != -247751)
						{
							continue;
						}
						hashtable.Add(47, "CrystalBeach");
						if (37306 - 49975 != -12669)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 34)
					{
						if (244718 - 231110 != 13608)
						{
							continue;
						}
						hashtable.Add(47, "ExcavationCamp");
						if (16486 - 160034 != -143548)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 35)
					{
						if (110707 - 519173 != -408466)
						{
							continue;
						}
						hashtable.Add(47, "UndergroundCamp");
						if (63953 - 399887 != -335934)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 36)
					{
						if (109757 - 595024 == -485266)
						{
							continue;
						}
						hashtable.Add(47, "ForestCamp");
						if (223591 - 385901 != -162310)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 51)
					{
						if (262518 - 144691 == 117828)
						{
							continue;
						}
						hashtable.Add(47, "MainStreet");
						if (187147 - 221433 != -34286)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 52)
					{
						if (118316 - 257420 != -139104)
						{
							continue;
						}
						hashtable.Add(47, "CentralSquare");
						if (158574 - 204174 != -45600)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 53)
					{
						if (105944 - 197803 != -91859)
						{
							continue;
						}
						hashtable.Add(47, "CityLibrary");
						if (78251 - 89414 != -11163)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 54)
					{
						if (117794 - 55785 == 62010)
						{
							continue;
						}
						hashtable.Add(47, "LightPark");
						if (292329 - 433987 == -141657)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 55)
					{
						if (188305 - 589757 != -401452)
						{
							continue;
						}
						hashtable.Add(47, "LightPalace");
						if (192357 - 313422 == -121064)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 56)
					{
						if (1038 - 331714 == -330675)
						{
							continue;
						}
						hashtable.Add(47, "PlainColosseum");
						if (221770 - 400678 != -178908)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 57)
					{
						if (49706 - 230086 == -180379)
						{
							continue;
						}
						hashtable.Add(47, "LightTheater");
						if (278773 - 346847 == -68073)
						{
							continue;
						}
					}
					hashtable.Add(21, PhotonClient.cInt16(Mathf.Clamp(PlayerPrefs.GetInt("channel", 0), 0, 99)));
					if (178800 - 253534 == -74734)
					{
						this.rjKnQi1ZUge.OpCustom(42, hashtable, true);
						if (81915 - 150956 != -69040)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x06009989 RID: 39305 RVA: 0x011FDA50 File Offset: 0x011FBC50
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onJoinTown()
	{
		Game.mGameStage = 0;
		Game.loadNextLevel();
	}

	// Token: 0x0600998A RID: 39306 RVA: 0x011FDA60 File Offset: 0x011FBC60
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x0600998B RID: 39307 RVA: 0x011FDA64 File Offset: 0x011FBC64
	internal static bool mDqLPEVCmdTxWqh3gGb4()
	{
		return true;
	}

	// Token: 0x0600998C RID: 39308 RVA: 0x011FDA68 File Offset: 0x011FBC68
	internal static bool zD6uNMVCFQg4pcbb0qek()
	{
		return false;
	}

	// Token: 0x04008DF7 RID: 36343
	private LitePeer rjKnQi1ZUge;

	// Token: 0x04008DF8 RID: 36344
	private PlayerCameraControl LaGnQDZI7Sf;

	// Token: 0x04008DF9 RID: 36345
	private float KAPnQmDhJ2v;

	// Token: 0x04008DFA RID: 36346
	private Texture yUKnQjMXTwZ;

	// Token: 0x04008DFB RID: 36347
	private int wt5nQoRgeS1;

	// Token: 0x04008DFC RID: 36348
	private int GhTnQkyF30R;

	// Token: 0x04008DFD RID: 36349
	private int DKCnQFtyuVZ;

	// Token: 0x04008DFE RID: 36350
	private int NE4nQAWWjyS;

	// Token: 0x04008DFF RID: 36351
	private int[] DcUnQ9oZqW0;

	// Token: 0x04008E00 RID: 36352
	public GameObject manaPillarEffect;

	// Token: 0x04008E01 RID: 36353
	private int I3XnQWZ3pvJ;

	// Token: 0x020019BC RID: 6588
	[CompilerGenerated]
	[Serializable]
	internal sealed class $onGameEvent$42564 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600998D RID: 39309 RVA: 0x011FDA6C File Offset: 0x011FBC6C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $onGameEvent$42564(Hashtable data, M921_AncientForest1 self_)
		{
			if (228069 - 530813 != -302744)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (148143 - 185161 == -37018)
				{
					base..ctor();
					if (262338 - 576041 != -313702)
					{
						this.$data$42573 = data;
						if (176527 - 406598 == -230071)
						{
							this.$self_$42574 = self_;
							if (121102 - 541942 != -420839)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x0600998E RID: 39310 RVA: 0x011FDB28 File Offset: 0x011FBD28
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M921_AncientForest1.$onGameEvent$42564.$(this.$data$42573, this.$self_$42574);
		}

		// Token: 0x0600998F RID: 39311 RVA: 0x011FDB3C File Offset: 0x011FBD3C
		internal static bool KPAn7qVCMxYwGgkumEk9()
		{
			return true;
		}

		// Token: 0x06009990 RID: 39312 RVA: 0x011FDB40 File Offset: 0x011FBD40
		internal static bool p2ZUAhVCxEh7IhNjp6ei()
		{
			return false;
		}

		// Token: 0x04008E02 RID: 36354
		internal Hashtable $data$42573;

		// Token: 0x04008E03 RID: 36355
		internal M921_AncientForest1 $self_$42574;

		// Token: 0x020019BD RID: 6589
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06009991 RID: 39313 RVA: 0x011FDB44 File Offset: 0x011FBD44
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Hashtable data, M921_AncientForest1 self_)
			{
				if (38084 - 123613 != -85529)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (240992 - 40790 != 200203)
					{
						base..ctor();
						if (23738 - 573950 == -550212)
						{
							this.$data$42571 = data;
							if (137825 - 254545 == -116720)
							{
								this.$self_$42572 = self_;
								if (151592 - 55975 == 95617)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x06009992 RID: 39314 RVA: 0x011FDC00 File Offset: 0x011FBE00
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (66377 - 242544 != -176167)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						goto IL_561;
					case 1:
						goto IL_72E;
					case 2:
						Application.LoadLevel("M921_AncientForest2");
						if (125191 - 414128 == -288936)
						{
							continue;
						}
						break;
					default:
						if (79859 - 220337 != -140477)
						{
							goto IL_561;
						}
						continue;
					}
					IL_209:
					this.YieldDefault(1);
					if (102703 - 512773 != -410070)
					{
						continue;
					}
					break;
					IL_37A:
					goto IL_209;
					IL_561:
					if (Game.mGameState > eGameState.AllHold)
					{
						if (119549 - 33571 == 85978)
						{
							break;
						}
					}
					else
					{
						this.$returnCode$42565 = RuntimeServices.UnboxInt32(this.$data$42571[141]);
						if (254704 - 377577 != -122872)
						{
							this.$returnValue$42566 = RuntimeServices.UnboxInt32(this.$data$42571[145]);
							if (204882 - 448570 != -243687)
							{
								this.$ownerID$42567 = RuntimeServices.UnboxInt32(this.$data$42571[43]);
								if (66059 - 142936 == -76877)
								{
									this.$$switch$7719$42568 = this.$returnCode$42565;
									if (135579 - 445194 == -309615)
									{
										if (this.$$switch$7719$42568 == 9211)
										{
											if (258029 - 79329 != 178701)
											{
												goto IL_209;
											}
										}
										else if (this.$$switch$7719$42568 == -9211)
										{
											if (196139 - 2316 != 193824)
											{
												if (this.$returnValue$42566 != 1)
												{
													goto IL_37A;
												}
												if (24645 - 171673 == -147028)
												{
													if (this.$self_$42572.wt5nQoRgeS1 >= 2)
													{
														goto IL_37A;
													}
													if (179688 - 419999 == -240311)
													{
														this.$self_$42572.wt5nQoRgeS1 = 2;
														if (27834 - 80384 != -52549)
														{
															Game.mGameState = eGameState.AllHold;
															if (203741 - 447755 != -244013)
															{
																this.$mGameGui$42569 = (GameGui)this.$self_$42572.GetComponent(typeof(GameGui));
																if (256977 - 397069 == -140092)
																{
																	this.$mGameGui$42569.close();
																	if (26433 - 303416 != -276982)
																	{
																		Game.savePlayer();
																		if (269654 - 313763 != -44108)
																		{
																			this.$self_$42572.SendMessage("fadeOut");
																			if (67805 - 16195 == 51610)
																			{
																				goto IL_4B7;
																			}
																		}
																	}
																}
															}
														}
													}
												}
											}
										}
										else if (this.$$switch$7719$42568 == 9212)
										{
											if (164143 - 163073 == 1070)
											{
												if (this.$self_$42572.DcUnQ9oZqW0[this.$returnValue$42566 - 1] > 0)
												{
													if (209460 - 417697 == -208236)
													{
														continue;
													}
													this.$self_$42572.SendMessage("newGameMessage", "This ManaPillar has already been activated!");
													if (235235 - 337676 == -102440)
													{
														continue;
													}
												}
												else
												{
													this.$self_$42572.DcUnQ9oZqW0[this.$returnValue$42566 - 1] = 1;
													if (158064 - 407935 != -249871)
													{
														continue;
													}
													this.$self_$42572.GhTnQkyF30R = this.$self_$42572.GhTnQkyF30R + 1;
													if (194321 - 104643 != 89678)
													{
														continue;
													}
													this.$self_$42572.ActivateManaPillar(this.$returnValue$42566);
													if (258744 - 547533 != -288789)
													{
														continue;
													}
													this.$self_$42572.SendMessage("newGameMessage", "ManaPillar activated :" + this.$self_$42572.GhTnQkyF30R + "/2");
													if (132505 - 564410 != -431905)
													{
														continue;
													}
												}
												goto IL_209;
											}
										}
										else if (this.$$switch$7719$42568 == 9213)
										{
											if (105540 - 437492 == -331952)
											{
												this.$self_$42572.DKCnQFtyuVZ = this.$self_$42572.DKCnQFtyuVZ + 1;
												if (230689 - 532700 == -302011)
												{
													if (this.$self_$42572.DKCnQFtyuVZ < 20)
													{
														if (130708 - 294607 == -163898)
														{
															continue;
														}
														if (this.$ownerID$42567 == PlayerData.UID)
														{
															if (78318 - 226392 != -148074)
															{
																continue;
															}
															this.$$switch$7717$42570 = UnityEngine.Random.Range(0, 2);
															if (196231 - 158383 != 37848)
															{
																continue;
															}
															if (this.$$switch$7717$42570 == 0)
															{
																if (200301 - 354607 != -154306)
																{
																	continue;
																}
																this.$self_$42572.createRandomSpawn("Fungon", 5, UnityEngine.Random.Range(1, 7));
																if (284885 - 142800 == 142086)
																{
																	continue;
																}
															}
															else if (this.$$switch$7717$42570 == 1)
															{
																if (136639 - 201757 != -65118)
																{
																	continue;
																}
																this.$self_$42572.createRandomSpawn("Fungko", 5, UnityEngine.Random.Range(1, 7));
																if (215004 - 20753 == 194252)
																{
																	continue;
																}
															}
														}
													}
													goto IL_209;
												}
											}
										}
										else
										{
											if (this.$$switch$7719$42568 != 9214)
											{
												goto IL_209;
											}
											if (87802 - 147981 == -60179)
											{
												this.$self_$42572.NE4nQAWWjyS = this.$self_$42572.NE4nQAWWjyS + 1;
												if (79538 - 262011 == -182473)
												{
													if (this.$self_$42572.NE4nQAWWjyS < 20)
													{
														if (136311 - 476297 == -339985)
														{
															continue;
														}
														if (this.$ownerID$42567 == PlayerData.UID)
														{
															if (210833 - 176077 != 34756)
															{
																continue;
															}
															this.$self_$42572.createRandomSpawn("ForestBug", 6, UnityEngine.Random.Range(7, 10));
															if (87858 - 412650 == -324791)
															{
																continue;
															}
														}
													}
													goto IL_209;
												}
											}
										}
									}
								}
							}
						}
					}
				}
				goto IL_72E;
				IL_4B7:
				return this.Yield(2, new WaitForSeconds((float)1));
				IL_72E:
				return false;
			}

			// Token: 0x06009993 RID: 39315 RVA: 0x011FE350 File Offset: 0x011FC550
			internal static bool qXOdr0VCgHHLgAZNRjYk()
			{
				return true;
			}

			// Token: 0x06009994 RID: 39316 RVA: 0x011FE354 File Offset: 0x011FC554
			internal static bool msXnIDVCfQANllxWOhl3()
			{
				return false;
			}

			// Token: 0x04008E04 RID: 36356
			internal int $returnCode$42565;

			// Token: 0x04008E05 RID: 36357
			internal int $returnValue$42566;

			// Token: 0x04008E06 RID: 36358
			internal int $ownerID$42567;

			// Token: 0x04008E07 RID: 36359
			internal int $$switch$7719$42568;

			// Token: 0x04008E08 RID: 36360
			internal GameGui $mGameGui$42569;

			// Token: 0x04008E09 RID: 36361
			internal int $$switch$7717$42570;

			// Token: 0x04008E0A RID: 36362
			internal Hashtable $data$42571;

			// Token: 0x04008E0B RID: 36363
			internal M921_AncientForest1 $self_$42572;
		}
	}

	// Token: 0x020019BE RID: 6590
	[CompilerGenerated]
	[Serializable]
	internal sealed class $onGameComplete$42575 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06009995 RID: 39317 RVA: 0x011FE358 File Offset: 0x011FC558
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $onGameComplete$42575(Hashtable data, M921_AncientForest1 self_)
		{
			if (263806 - 135708 != 128098)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (142227 - 271334 != -129106)
				{
					base..ctor();
					if (185389 - 52737 != 132653)
					{
						this.$data$42583 = data;
						if (66088 - 148429 != -82340)
						{
							this.$self_$42584 = self_;
							if (131659 - 232619 != -100959)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x06009996 RID: 39318 RVA: 0x011FE414 File Offset: 0x011FC614
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M921_AncientForest1.$onGameComplete$42575.$(this.$data$42583, this.$self_$42584);
		}

		// Token: 0x06009997 RID: 39319 RVA: 0x011FE428 File Offset: 0x011FC628
		internal static bool gc9Rj1VCn1O7YsTRRD36()
		{
			return true;
		}

		// Token: 0x06009998 RID: 39320 RVA: 0x011FE42C File Offset: 0x011FC62C
		internal static bool foW54XVC6vmZXhhTsi8A()
		{
			return false;
		}

		// Token: 0x04008E0C RID: 36364
		internal Hashtable $data$42583;

		// Token: 0x04008E0D RID: 36365
		internal M921_AncientForest1 $self_$42584;

		// Token: 0x020019BF RID: 6591
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06009999 RID: 39321 RVA: 0x011FE430 File Offset: 0x011FC630
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Hashtable data, M921_AncientForest1 self_)
			{
				if (76659 - 51837 != 24822)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (290300 - 532944 == -242644)
					{
						base..ctor();
						if (87926 - 276107 != -188180)
						{
							this.$data$42581 = data;
							if (101366 - 83712 == 17654)
							{
								this.$self_$42582 = self_;
								if (15034 - 385258 != -370223)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x0600999A RID: 39322 RVA: 0x011FE4EC File Offset: 0x011FC6EC
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (73008 - 88272 != -15263)
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
						this.$mCompleteGui$42577 = (CompleteGui)this.$self_$42582.GetComponent(typeof(CompleteGui));
						if (51555 - 349585 != -298030)
						{
							continue;
						}
						this.$mCompleteGui$42577.Init();
						if (155587 - 215791 == -60203)
						{
							continue;
						}
						this.$mCompleteGui$42577.readData(this.$data$42581);
						if (254427 - 284175 != -29748)
						{
							continue;
						}
						if (this.$result$42576 == 1)
						{
							if (273494 - 497272 != -223778)
							{
								continue;
							}
							this.$mCompleteGui$42577.displayResult(eCompleteType.Success);
							if (183613 - 286440 == -102826)
							{
								continue;
							}
						}
						else
						{
							this.$mCompleteGui$42577.displayResult(eCompleteType.Failed);
							if (117734 - 303909 != -186175)
							{
								continue;
							}
						}
						this.$mGameGui$42578 = (GameGui)this.$self_$42582.GetComponent(typeof(GameGui));
						if (70929 - 534848 == -463918)
						{
							continue;
						}
						this.$mStoryGui$42579 = (StoryGui)this.$self_$42582.GetComponent(typeof(StoryGui));
						if (219064 - 412711 == -193646)
						{
							continue;
						}
						this.$mChangeGui$42580 = (ChangeGui)this.$self_$42582.GetComponent(typeof(ChangeGui));
						if (171190 - 195294 != -24104)
						{
							continue;
						}
						if (this.$mGameGui$42578)
						{
							if (202864 - 351697 == -148832)
							{
								continue;
							}
							this.$mGameGui$42578.close();
							if (295911 - 419364 == -123452)
							{
								continue;
							}
						}
						if (this.$mStoryGui$42579)
						{
							if (121168 - 332464 == -211295)
							{
								continue;
							}
							this.$mStoryGui$42579.close();
							if (31525 - 190824 == -159298)
							{
								continue;
							}
						}
						if (this.$mChangeGui$42580)
						{
							if (268857 - 471609 == -202751)
							{
								continue;
							}
							this.$mChangeGui$42580.disable();
							if (95668 - 492460 != -396792)
							{
								continue;
							}
						}
						this.YieldDefault(1);
						if (149935 - 129754 != 20181)
						{
							continue;
						}
						goto IL_3DB;
					default:
						if (43926 - 293804 == -249877)
						{
							continue;
						}
						break;
					}
					Debug.Log("On Mission Complete:" + this.$data$42581[31]);
					if (81021 - 445959 != -364937)
					{
						if (Game.mGameState > eGameState.AllHold)
						{
							if (73612 - 228186 != -154573)
							{
								goto Block_20;
							}
						}
						else
						{
							Game.mGameState = eGameState.Complete;
							if (292405 - 151162 == 141243)
							{
								this.$result$42576 = RuntimeServices.UnboxInt32(this.$data$42581[31]);
								if (166433 - 187648 == -21215)
								{
									break;
								}
							}
						}
					}
				}
				return this.Yield(2, new WaitForSeconds(1f));
				Block_20:
				IL_3DB:
				return false;
			}

			// Token: 0x0600999B RID: 39323 RVA: 0x011FE8E8 File Offset: 0x011FCAE8
			internal static bool rTQSRFVCiMjIpR8IfYGc()
			{
				return true;
			}

			// Token: 0x0600999C RID: 39324 RVA: 0x011FE8EC File Offset: 0x011FCAEC
			internal static bool a535ylVCKsoF7l4BTOJh()
			{
				return false;
			}

			// Token: 0x04008E0E RID: 36366
			internal int $result$42576;

			// Token: 0x04008E0F RID: 36367
			internal CompleteGui $mCompleteGui$42577;

			// Token: 0x04008E10 RID: 36368
			internal GameGui $mGameGui$42578;

			// Token: 0x04008E11 RID: 36369
			internal StoryGui $mStoryGui$42579;

			// Token: 0x04008E12 RID: 36370
			internal ChangeGui $mChangeGui$42580;

			// Token: 0x04008E13 RID: 36371
			internal Hashtable $data$42581;

			// Token: 0x04008E14 RID: 36372
			internal M921_AncientForest1 $self_$42582;
		}
	}

	// Token: 0x020019C0 RID: 6592
	[CompilerGenerated]
	[Serializable]
	internal sealed class $StartGame$42585 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600999D RID: 39325 RVA: 0x011FE8F0 File Offset: 0x011FCAF0
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $StartGame$42585(M921_AncientForest1 self_)
		{
			if (175681 - 259246 != -83565)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (31957 - 521658 == -489701)
				{
					base..ctor();
					if (44438 - 48858 != -4419)
					{
						this.$self_$42588 = self_;
						if (257555 - 383969 != -126413)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x0600999E RID: 39326 RVA: 0x011FE988 File Offset: 0x011FCB88
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M921_AncientForest1.$StartGame$42585.$(this.$self_$42588);
		}

		// Token: 0x0600999F RID: 39327 RVA: 0x011FE998 File Offset: 0x011FCB98
		internal static bool aHUusBVCdI02HhhX6xSu()
		{
			return true;
		}

		// Token: 0x060099A0 RID: 39328 RVA: 0x011FE99C File Offset: 0x011FCB9C
		internal static bool uCAJaCVCJih46LtIkhRX()
		{
			return false;
		}

		// Token: 0x04008E15 RID: 36373
		internal M921_AncientForest1 $self_$42588;

		// Token: 0x020019C1 RID: 6593
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x060099A1 RID: 39329 RVA: 0x011FE9A0 File Offset: 0x011FCBA0
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M921_AncientForest1 self_)
			{
				if (264024 - 28060 != 235964)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (14022 - 329942 == -315920)
					{
						base..ctor();
						if (278900 - 219171 != 59730)
						{
							this.$self_$42587 = self_;
							if (262006 - 466149 == -204143)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x060099A2 RID: 39330 RVA: 0x011FEA38 File Offset: 0x011FCC38
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (45627 - 196628 != -151001)
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
						if (152129 - 63102 != 89027)
						{
							continue;
						}
						Game.mGameTime = Time.time;
						if (204505 - 393223 == -188717)
						{
							continue;
						}
						this.YieldDefault(1);
						if (24345 - 403585 != -379240)
						{
							continue;
						}
						goto IL_1B9;
					default:
						if (198594 - 570373 != -371779)
						{
							continue;
						}
						break;
					}
					Debug.Log("Start Game");
					if (217564 - 407691 == -190127)
					{
						Game.mGameState = eGameState.Start;
						if (21963 - 348463 == -326500)
						{
							Game.mGameTime = Time.time;
							if (221180 - 224203 == -3023)
							{
								this.$mGameGui$42586 = (GameGui)this.$self_$42587.GetComponent(typeof(GameGui));
								if (247341 - 306361 == -59020)
								{
									this.$mGameGui$42586.enabled = true;
									if (182517 - 482639 == -300122)
									{
										this.$self_$42587.SendMessage("fadeIn");
										if (77907 - 86818 == -8911)
										{
											break;
										}
									}
								}
							}
						}
					}
				}
				return this.Yield(2, new WaitForSeconds(0.5f));
				IL_1B9:
				return false;
			}

			// Token: 0x060099A3 RID: 39331 RVA: 0x011FEC10 File Offset: 0x011FCE10
			internal static bool hQUgPUVCDId0K3dGuZ6G()
			{
				return true;
			}

			// Token: 0x060099A4 RID: 39332 RVA: 0x011FEC14 File Offset: 0x011FCE14
			internal static bool teI91RVCv7dnslMgxipH()
			{
				return false;
			}

			// Token: 0x04008E16 RID: 36374
			internal GameGui $mGameGui$42586;

			// Token: 0x04008E17 RID: 36375
			internal M921_AncientForest1 $self_$42587;
		}
	}

	// Token: 0x020019C2 RID: 6594
	[CompilerGenerated]
	[Serializable]
	internal sealed class $onDeadPlayer$42589 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x060099A5 RID: 39333 RVA: 0x011FEC18 File Offset: 0x011FCE18
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $onDeadPlayer$42589(M921_AncientForest1 self_)
		{
			if (88047 - 491192 != -403144)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (15169 - 204199 == -189030)
				{
					base..ctor();
					if (38850 - 381235 != -342384)
					{
						this.$self_$42594 = self_;
						if (160786 - 340374 == -179588)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x060099A6 RID: 39334 RVA: 0x011FECB0 File Offset: 0x011FCEB0
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M921_AncientForest1.$onDeadPlayer$42589.$(this.$self_$42594);
		}

		// Token: 0x060099A7 RID: 39335 RVA: 0x011FECC0 File Offset: 0x011FCEC0
		internal static bool A7C20YVCRt5ebeivlOVX()
		{
			return true;
		}

		// Token: 0x060099A8 RID: 39336 RVA: 0x011FECC4 File Offset: 0x011FCEC4
		internal static bool a0RQttVCwJkbcobp9glt()
		{
			return false;
		}

		// Token: 0x04008E18 RID: 36376
		internal M921_AncientForest1 $self_$42594;

		// Token: 0x020019C3 RID: 6595
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x060099A9 RID: 39337 RVA: 0x011FECC8 File Offset: 0x011FCEC8
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M921_AncientForest1 self_)
			{
				if (245324 - 250119 != -4794)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (161429 - 359857 == -198428)
					{
						base..ctor();
						if (202748 - 81061 != 121688)
						{
							this.$self_$42593 = self_;
							if (240833 - 281595 == -40762)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x060099AA RID: 39338 RVA: 0x011FED60 File Offset: 0x011FCF60
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (258820 - 393968 != -135148)
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
							goto IL_1F6;
						}
						if (149834 - 507427 == -357592)
						{
							continue;
						}
						if (Game.mGameState == eGameState.Hold)
						{
							if (61826 - 354560 != -292734)
							{
								continue;
							}
							goto IL_1F6;
						}
						IL_A1:
						this.YieldDefault(1);
						if (25112 - 522871 != -497758)
						{
							goto Block_7;
						}
						continue;
						IL_1F6:
						Game.mGameState = eGameState.Hold;
						if (145103 - 218070 == -72966)
						{
							continue;
						}
						this.$mStoryGui$42590 = (StoryGui)this.$self_$42593.GetComponent(typeof(StoryGui));
						if (281776 - 60565 != 221211)
						{
							continue;
						}
						if (this.$mStoryGui$42590)
						{
							if (150794 - 544434 == -393639)
							{
								continue;
							}
							this.$mStoryGui$42590.close();
							if (213831 - 214620 == -788)
							{
								continue;
							}
						}
						this.$mChangeGui$42591 = (ChangeGui)this.$self_$42593.GetComponent(typeof(ChangeGui));
						if (225238 - 424385 != -199147)
						{
							continue;
						}
						if (this.$mChangeGui$42591)
						{
							if (266537 - 305394 == -38856)
							{
								continue;
							}
							this.$mChangeGui$42591.close();
							if (202897 - 451473 != -248576)
							{
								continue;
							}
						}
						this.$mGameGui$42592 = (GameGui)this.$self_$42593.GetComponent(typeof(GameGui));
						if (247889 - 234070 == 13820)
						{
							continue;
						}
						if (!this.$mGameGui$42592)
						{
							goto IL_A1;
						}
						if (143623 - 549013 != -405390)
						{
							continue;
						}
						if (!this.$mGameGui$42592.enabled)
						{
							if (78241 - 184728 == -106486)
							{
								continue;
							}
							this.$mGameGui$42592.enabled = true;
							if (272801 - 326056 == -53254)
							{
								continue;
							}
						}
						this.$mGameGui$42592.openDeadMenu();
						if (268972 - 221661 != 47312)
						{
							goto IL_A1;
						}
						continue;
					default:
						if (265444 - 522585 != -257141)
						{
							continue;
						}
						break;
					}
					Debug.Log("On Dead Player");
				}
				while (216521 - 156241 != 60280);
				return this.Yield(2, new WaitForSeconds((float)2));
				Block_7:
				IL_2F9:
				return false;
			}

			// Token: 0x060099AB RID: 39339 RVA: 0x011FF078 File Offset: 0x011FD278
			internal static bool AhgHudVCqsKyJmxHYMn1()
			{
				return true;
			}

			// Token: 0x060099AC RID: 39340 RVA: 0x011FF07C File Offset: 0x011FD27C
			internal static bool LgagtOVC7lDTxmSANFHS()
			{
				return false;
			}

			// Token: 0x04008E19 RID: 36377
			internal StoryGui $mStoryGui$42590;

			// Token: 0x04008E1A RID: 36378
			internal ChangeGui $mChangeGui$42591;

			// Token: 0x04008E1B RID: 36379
			internal GameGui $mGameGui$42592;

			// Token: 0x04008E1C RID: 36380
			internal M921_AncientForest1 $self_$42593;
		}
	}

	// Token: 0x020019C4 RID: 6596
	[CompilerGenerated]
	[Serializable]
	internal sealed class $onChangePlayer$42595 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x060099AD RID: 39341 RVA: 0x011FF080 File Offset: 0x011FD280
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $onChangePlayer$42595(Hashtable data, M921_AncientForest1 self_)
		{
			if (243555 - 355702 != -112146)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (232799 - 386246 == -153447)
				{
					base..ctor();
					if (177379 - 260855 != -83475)
					{
						this.$data$42600 = data;
						if (110296 - 79515 == 30781)
						{
							this.$self_$42601 = self_;
							if (70245 - 339562 != -269316)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x060099AE RID: 39342 RVA: 0x011FF13C File Offset: 0x011FD33C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M921_AncientForest1.$onChangePlayer$42595.$(this.$data$42600, this.$self_$42601);
		}

		// Token: 0x060099AF RID: 39343 RVA: 0x011FF150 File Offset: 0x011FD350
		internal static bool WMX5F2VCP7DxdAK0mC4j()
		{
			return true;
		}

		// Token: 0x060099B0 RID: 39344 RVA: 0x011FF154 File Offset: 0x011FD354
		internal static bool SWOtk7VC003HrqUKJWim()
		{
			return false;
		}

		// Token: 0x04008E1D RID: 36381
		internal Hashtable $data$42600;

		// Token: 0x04008E1E RID: 36382
		internal M921_AncientForest1 $self_$42601;

		// Token: 0x020019C5 RID: 6597
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x060099B1 RID: 39345 RVA: 0x011FF158 File Offset: 0x011FD358
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Hashtable data, M921_AncientForest1 self_)
			{
				if (285344 - 545065 != -259720)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (63029 - 122434 == -59405)
					{
						base..ctor();
						if (87306 - 132776 == -45470)
						{
							this.$data$42598 = data;
							if (225835 - 321017 == -95182)
							{
								this.$self_$42599 = self_;
								if (11843 - 281519 == -269676)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x060099B2 RID: 39346 RVA: 0x011FF214 File Offset: 0x011FD414
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (19281 - 570607 != -551325)
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
							if (49625 - 554426 != -504801)
							{
								continue;
							}
							Game.mGameState = eGameState.Normal;
							if (174322 - 283806 != -109484)
							{
								continue;
							}
							this.$mGameGui$42597 = (GameGui)this.$self_$42599.GetComponent(typeof(GameGui));
							if (192677 - 138579 != 54098)
							{
								continue;
							}
							this.$mGameGui$42597.enabled = true;
							if (285007 - 36791 != 248216)
							{
								continue;
							}
						}
						this.YieldDefault(1);
						if (297781 - 399421 != -101639)
						{
							goto Block_12;
						}
						continue;
					default:
						if (65303 - 316165 != -250862)
						{
							continue;
						}
						break;
					}
					UnityEngine.Object.Destroy(Game.mPlayer);
					if (217240 - 152277 == 64963)
					{
						this.$self_$42599.SendMessage("onCreatePlayer", this.$data$42598);
						if (281782 - 183711 == 98071)
						{
							this.$mChangeGui$42596 = (ChangeGui)this.$self_$42599.GetComponent(typeof(ChangeGui));
							if (8917 - 198032 == -189115)
							{
								if (!this.$mChangeGui$42596.enabled)
								{
									break;
								}
								if (65620 - 490789 != -425168)
								{
									this.$mChangeGui$42596.close();
									if (207050 - 265551 != -58500)
									{
										break;
									}
								}
							}
						}
					}
				}
				goto IL_1CA;
				Block_12:
				goto IL_205;
				IL_1CA:
				return this.Yield(2, new WaitForSeconds(1f));
				IL_205:
				return false;
			}

			// Token: 0x060099B3 RID: 39347 RVA: 0x011FF438 File Offset: 0x011FD638
			internal static bool WQyD7dVCbVQ74vhLo0Mo()
			{
				return true;
			}

			// Token: 0x060099B4 RID: 39348 RVA: 0x011FF43C File Offset: 0x011FD63C
			internal static bool tkWhygVCueqEGWnKO5WY()
			{
				return false;
			}

			// Token: 0x04008E1F RID: 36383
			internal ChangeGui $mChangeGui$42596;

			// Token: 0x04008E20 RID: 36384
			internal GameGui $mGameGui$42597;

			// Token: 0x04008E21 RID: 36385
			internal Hashtable $data$42598;

			// Token: 0x04008E22 RID: 36386
			internal M921_AncientForest1 $self_$42599;
		}
	}

	// Token: 0x020019C6 RID: 6598
	[CompilerGenerated]
	[Serializable]
	internal sealed class $ReturnToTown$42602 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x060099B5 RID: 39349 RVA: 0x011FF440 File Offset: 0x011FD640
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $ReturnToTown$42602(M921_AncientForest1 self_)
		{
			if (139306 - 504354 != -365048)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (127190 - 534545 != -407354)
				{
					base..ctor();
					if (154561 - 393379 == -238818)
					{
						this.$self_$42606 = self_;
						if (291230 - 210335 == 80895)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x060099B6 RID: 39350 RVA: 0x011FF4D8 File Offset: 0x011FD6D8
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M921_AncientForest1.$ReturnToTown$42602.$(this.$self_$42606);
		}

		// Token: 0x060099B7 RID: 39351 RVA: 0x011FF4E8 File Offset: 0x011FD6E8
		internal static bool QqI037VCIwFsJGR5yUuS()
		{
			return true;
		}

		// Token: 0x060099B8 RID: 39352 RVA: 0x011FF4EC File Offset: 0x011FD6EC
		internal static bool PBJbf7VCBpk77xewHZJX()
		{
			return false;
		}

		// Token: 0x04008E23 RID: 36387
		internal M921_AncientForest1 $self_$42606;

		// Token: 0x020019C7 RID: 6599
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x060099B9 RID: 39353 RVA: 0x011FF4F0 File Offset: 0x011FD6F0
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M921_AncientForest1 self_)
			{
				if (15110 - 476181 != -461071)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (95855 - 287747 != -191891)
					{
						base..ctor();
						if (20934 - 78488 == -57554)
						{
							this.$self_$42605 = self_;
							if (216935 - 151500 != 65436)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x060099BA RID: 39354 RVA: 0x011FF588 File Offset: 0x011FD788
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (228168 - 491757 != -263589)
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
						this.$self_$42605.LeaveGame();
						if (34241 - 111656 == -77414)
						{
							continue;
						}
						this.YieldDefault(1);
						if (225670 - 69184 != 156486)
						{
							continue;
						}
						goto IL_3AD;
					default:
						if (127749 - 35198 == 92552)
						{
							continue;
						}
						break;
					}
					Game.mGameState = eGameState.Ended;
					if (131640 - 16460 != 115181)
					{
						Game.mStateTime = Time.time;
						if (250295 - 33874 != 216422)
						{
							this.$$switch$7725$42603 = PlayerData.SaveGuild;
							if (291994 - 305950 != -13955)
							{
								if (this.$$switch$7725$42603 == 1)
								{
									if (211844 - 48509 == 163336)
									{
										continue;
									}
									Game.mNextGameCode = 32;
									if (44198 - 378064 != -333866)
									{
										continue;
									}
								}
								else if (this.$$switch$7725$42603 == 2)
								{
									if (31906 - 318571 == -286664)
									{
										continue;
									}
									Game.mNextGameCode = 33;
									if (18478 - 462357 == -443878)
									{
										continue;
									}
								}
								else if (this.$$switch$7725$42603 == 3)
								{
									if (265625 - 471356 == -205730)
									{
										continue;
									}
									Game.mNextGameCode = 34;
									if (99797 - 525472 == -425674)
									{
										continue;
									}
								}
								else if (this.$$switch$7725$42603 == 4)
								{
									if (227324 - 517618 != -290294)
									{
										continue;
									}
									Game.mNextGameCode = 35;
									if (222399 - 379143 != -156744)
									{
										continue;
									}
								}
								else if (this.$$switch$7725$42603 == 5)
								{
									if (27847 - 350015 != -322168)
									{
										continue;
									}
									Game.mNextGameCode = 36;
									if (245099 - 516222 == -271122)
									{
										continue;
									}
								}
								else if (PlayerData.GID == 0)
								{
									if (231702 - 82478 != 149224)
									{
										continue;
									}
									Game.mNextGameCode = 30;
									if (64085 - 114859 != -50774)
									{
										continue;
									}
								}
								else
								{
									Game.mNextGameCode = 31;
									if (54855 - 237736 != -182881)
									{
										continue;
									}
								}
								this.$mGameGui$42604 = (GameGui)this.$self_$42605.GetComponent(typeof(GameGui));
								if (69459 - 260127 != -190667)
								{
									if (this.$mGameGui$42604)
									{
										if (233058 - 491582 == -258523)
										{
											continue;
										}
										this.$mGameGui$42604.close();
										if (288133 - 116259 == 171875)
										{
											continue;
										}
									}
									this.$self_$42605.SendMessage("fadeOut");
									if (156403 - 331184 != -174780)
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

			// Token: 0x060099BB RID: 39355 RVA: 0x011FF954 File Offset: 0x011FDB54
			internal static bool JdHE73VCeAkjYBPJAcKL()
			{
				return true;
			}

			// Token: 0x060099BC RID: 39356 RVA: 0x011FF958 File Offset: 0x011FDB58
			internal static bool H7HhcvVCrZFHceU3k0uw()
			{
				return false;
			}

			// Token: 0x04008E24 RID: 36388
			internal int $$switch$7725$42603;

			// Token: 0x04008E25 RID: 36389
			internal GameGui $mGameGui$42604;

			// Token: 0x04008E26 RID: 36390
			internal M921_AncientForest1 $self_$42605;
		}
	}

	// Token: 0x020019C8 RID: 6600
	[CompilerGenerated]
	[Serializable]
	internal sealed class $ReturnToGuild$42607 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x060099BD RID: 39357 RVA: 0x011FF95C File Offset: 0x011FDB5C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $ReturnToGuild$42607(M921_AncientForest1 self_)
		{
			if (194779 - 425044 != -230264)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (65695 - 108083 == -42388)
				{
					base..ctor();
					if (66548 - 291874 != -225325)
					{
						this.$self_$42610 = self_;
						if (196116 - 489785 == -293669)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x060099BE RID: 39358 RVA: 0x011FF9F4 File Offset: 0x011FDBF4
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M921_AncientForest1.$ReturnToGuild$42607.$(this.$self_$42610);
		}

		// Token: 0x060099BF RID: 39359 RVA: 0x011FFA04 File Offset: 0x011FDC04
		internal static bool d90eg6VCjvbKIQWgNkIl()
		{
			return true;
		}

		// Token: 0x060099C0 RID: 39360 RVA: 0x011FFA08 File Offset: 0x011FDC08
		internal static bool agHp5cVChvrY0GbVZebw()
		{
			return false;
		}

		// Token: 0x04008E27 RID: 36391
		internal M921_AncientForest1 $self_$42610;

		// Token: 0x020019C9 RID: 6601
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x060099C1 RID: 39361 RVA: 0x011FFA0C File Offset: 0x011FDC0C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M921_AncientForest1 self_)
			{
				if (115135 - 468457 != -353322)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (35510 - 300299 == -264789)
					{
						base..ctor();
						if (132002 - 11881 != 120122)
						{
							this.$self_$42609 = self_;
							if (6804 - 204944 == -198140)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x060099C2 RID: 39362 RVA: 0x011FFAA4 File Offset: 0x011FDCA4
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (211633 - 71451 != 140182)
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
						this.$self_$42609.LeaveGame();
						if (145328 - 333684 != -188356)
						{
							continue;
						}
						this.YieldDefault(1);
						if (95245 - 127459 != -32213)
						{
							goto Block_7;
						}
						continue;
					default:
						if (179900 - 553720 != -373820)
						{
							continue;
						}
						break;
					}
					Game.mGameState = eGameState.Ended;
					if (26711 - 339531 != -312819)
					{
						Game.mStateTime = Time.time;
						if (80461 - 25358 != 55104)
						{
							Game.mNextGameCode = 31;
							if (74577 - 119155 != -44577)
							{
								this.$mGameGui$42608 = (GameGui)this.$self_$42609.GetComponent(typeof(GameGui));
								if (163992 - 397466 == -233474)
								{
									if (this.$mGameGui$42608)
									{
										if (73052 - 115713 == -42660)
										{
											continue;
										}
										this.$mGameGui$42608.close();
										if (72130 - 413695 == -341564)
										{
											continue;
										}
									}
									this.$self_$42609.SendMessage("fadeOut");
									if (128411 - 133262 != -4850)
									{
										goto Block_13;
									}
								}
							}
						}
					}
				}
				Block_7:
				goto IL_1BD;
				Block_13:
				return this.Yield(2, new WaitForSeconds((float)1));
				IL_1BD:
				return false;
			}

			// Token: 0x060099C3 RID: 39363 RVA: 0x011FFC80 File Offset: 0x011FDE80
			internal static bool WBIjo9VCshJbA47K2WQs()
			{
				return true;
			}

			// Token: 0x060099C4 RID: 39364 RVA: 0x011FFC84 File Offset: 0x011FDE84
			internal static bool EICLgTVC92luQ13Ki0HC()
			{
				return false;
			}

			// Token: 0x04008E28 RID: 36392
			internal GameGui $mGameGui$42608;

			// Token: 0x04008E29 RID: 36393
			internal M921_AncientForest1 $self_$42609;
		}
	}

	// Token: 0x020019CA RID: 6602
	[CompilerGenerated]
	[Serializable]
	internal sealed class $ReturnToCamp$42611 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x060099C5 RID: 39365 RVA: 0x011FFC88 File Offset: 0x011FDE88
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $ReturnToCamp$42611(M921_AncientForest1 self_)
		{
			if (123753 - 255078 != -131324)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (111708 - 537453 != -425744)
				{
					base..ctor();
					if (11069 - 483969 != -472899)
					{
						this.$self_$42615 = self_;
						if (80200 - 518184 == -437984)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x060099C6 RID: 39366 RVA: 0x011FFD20 File Offset: 0x011FDF20
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M921_AncientForest1.$ReturnToCamp$42611.$(this.$self_$42615);
		}

		// Token: 0x060099C7 RID: 39367 RVA: 0x011FFD30 File Offset: 0x011FDF30
		internal static bool p8E28qVC1n6aEjLqSpKU()
		{
			return true;
		}

		// Token: 0x060099C8 RID: 39368 RVA: 0x011FFD34 File Offset: 0x011FDF34
		internal static bool x86h3WVC4ntNb4GflmoI()
		{
			return false;
		}

		// Token: 0x04008E2A RID: 36394
		internal M921_AncientForest1 $self_$42615;

		// Token: 0x020019CB RID: 6603
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x060099C9 RID: 39369 RVA: 0x011FFD38 File Offset: 0x011FDF38
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M921_AncientForest1 self_)
			{
				if (141989 - 383969 != -241980)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (8361 - 114631 == -106270)
					{
						base..ctor();
						if (167458 - 368826 != -201367)
						{
							this.$self_$42614 = self_;
							if (156207 - 84892 == 71315)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x060099CA RID: 39370 RVA: 0x011FFDD0 File Offset: 0x011FDFD0
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (84628 - 218733 != -134104)
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
						this.$self_$42614.LeaveGame();
						if (78892 - 58754 == 20139)
						{
							continue;
						}
						this.YieldDefault(1);
						if (268747 - 122882 != 145866)
						{
							goto Block_12;
						}
						continue;
					default:
						if (166137 - 298985 != -132848)
						{
							continue;
						}
						break;
					}
					Game.mGameState = eGameState.Ended;
					if (28448 - 449138 == -420690)
					{
						Game.mStateTime = Time.time;
						if (74437 - 42538 != 31900)
						{
							this.$$switch$7727$42612 = PlayerData.SaveGuild;
							if (189520 - 429549 == -240029)
							{
								if (this.$$switch$7727$42612 == 1)
								{
									if (38085 - 175688 != -137603)
									{
										continue;
									}
									Game.mNextGameCode = 32;
									if (69026 - 537142 != -468116)
									{
										continue;
									}
								}
								else if (this.$$switch$7727$42612 == 2)
								{
									if (196980 - 401864 == -204883)
									{
										continue;
									}
									Game.mNextGameCode = 33;
									if (61252 - 102099 == -40846)
									{
										continue;
									}
								}
								else if (this.$$switch$7727$42612 == 3)
								{
									if (95127 - 158983 == -63855)
									{
										continue;
									}
									Game.mNextGameCode = 34;
									if (279220 - 507373 == -228152)
									{
										continue;
									}
								}
								else if (this.$$switch$7727$42612 == 4)
								{
									if (190503 - 243812 == -53308)
									{
										continue;
									}
									Game.mNextGameCode = 35;
									if (128142 - 186755 == -58612)
									{
										continue;
									}
								}
								else if (this.$$switch$7727$42612 == 5)
								{
									if (126938 - 472291 == -345352)
									{
										continue;
									}
									Game.mNextGameCode = 36;
									if (232906 - 138663 != 94243)
									{
										continue;
									}
								}
								else
								{
									Game.mNextGameCode = 30;
									if (246235 - 553403 != -307168)
									{
										continue;
									}
								}
								this.$mGameGui$42613 = (GameGui)this.$self_$42614.GetComponent(typeof(GameGui));
								if (71322 - 55079 == 16243)
								{
									if (this.$mGameGui$42613)
									{
										if (176276 - 183627 == -7350)
										{
											continue;
										}
										this.$mGameGui$42613.close();
										if (25389 - 530907 == -505517)
										{
											continue;
										}
									}
									this.$self_$42614.SendMessage("fadeOut");
									if (260672 - 359416 != -98743)
									{
										break;
									}
								}
							}
						}
					}
				}
				return this.Yield(2, new WaitForSeconds((float)1));
				Block_12:
				IL_363:
				return false;
			}

			// Token: 0x060099CB RID: 39371 RVA: 0x01200154 File Offset: 0x011FE354
			internal static bool DATFnIVCzVPw05In3lkv()
			{
				return true;
			}

			// Token: 0x060099CC RID: 39372 RVA: 0x01200158 File Offset: 0x011FE358
			internal static bool aEoKphVLaXbemwx17FPf()
			{
				return false;
			}

			// Token: 0x04008E2B RID: 36395
			internal int $$switch$7727$42612;

			// Token: 0x04008E2C RID: 36396
			internal GameGui $mGameGui$42613;

			// Token: 0x04008E2D RID: 36397
			internal M921_AncientForest1 $self_$42614;
		}
	}
}
