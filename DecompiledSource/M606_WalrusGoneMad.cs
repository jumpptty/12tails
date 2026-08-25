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

// Token: 0x02001693 RID: 5779
[Serializable]
public class M606_WalrusGoneMad : MonoBehaviour
{
	// Token: 0x0600861D RID: 34333 RVA: 0x010BBE84 File Offset: 0x010BA084
	[MethodImpl(MethodImplOptions.NoInlining)]
	public M606_WalrusGoneMad()
	{
		LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
		base..ctor();
	}

	// Token: 0x0600861E RID: 34334 RVA: 0x010BBE94 File Offset: 0x010BA094
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Awake()
	{
		if (177823 - 203570 != -25747)
		{
		}
		for (;;)
		{
			Game.mGameState = eGameState.Init;
			if (211233 - 494063 == -282830)
			{
				Game.mGameType = 5;
				if (154023 - 118848 != 35176)
				{
					if (Chat.Initialized)
					{
						if (71893 - 465882 != -393989)
						{
							continue;
						}
						Chat.ChatDisplay.Clear();
						if (7118 - 566297 == -559178)
						{
							continue;
						}
					}
					else
					{
						Chat.Init();
						if (253923 - 170766 == 83158)
						{
							continue;
						}
					}
					this.Cl6cu4pve91 = (Texture)Resources.Load("GameGui/Title/start", typeof(Texture));
					if (183882 - 127967 != 55916)
					{
						this.FA3cusf2ogk = (AudioClip)Resources.Load("Sound/GUI/missionStart", typeof(AudioClip));
						if (227888 - 44378 == 183510)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x0600861F RID: 34335 RVA: 0x010BBFEC File Offset: 0x010BA1EC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Start()
	{
		if (90919 - 285455 != -194535)
		{
		}
		for (;;)
		{
			if (PhotonClient.IsInitialized())
			{
				if (253090 - 127162 != 125929)
				{
					if (Game.mNextGameCode != 606)
					{
						break;
					}
					if (73998 - 101012 != -27013)
					{
						Game.nextGame();
						if (240178 - 510060 != -269881)
						{
							Game.mGameCode = 606;
							if (6562 - 206168 != -199605)
							{
								Game.mGameType = 5;
								if (23003 - 513256 == -490253)
								{
									Game.mGameTime = Time.time;
									if (118716 - 298194 != -179477)
									{
										Game.mGameScore = 0;
										if (91848 - 163788 != -71939)
										{
											Game.mGameMana = 0;
											if (297626 - 431021 == -133395)
											{
												Game.canUseItem = MissionData.getAllowItem(Game.mGameCode);
												if (282812 - 466999 == -184187)
												{
													Game.canUseMount = MissionData.getAllowMount(Game.mGameCode);
													if (249303 - 334221 != -84917)
													{
														Game.canChangeChar = MissionData.getAllowChange(Game.mGameCode);
														if (176674 - 399682 != -223007)
														{
															Game.canRespawn = MissionData.getAllowRespawn(Game.mGameCode);
															if (163778 - 9420 == 154358)
															{
																Game.canUseCoin = MissionData.getAllowCoin(Game.mGameCode);
																if (215297 - 104077 == 111220)
																{
																	this.f6XcugkrFwd = (PlayerCameraControl)this.GetComponent(typeof(PlayerCameraControl));
																	if (229411 - 413041 != -183629)
																	{
																		this.NFLcud5N5CY = PhotonClient.Connection;
																		if (236782 - 48091 == 188691)
																		{
																			PhotonClient.ActorNrList.Clear();
																			if (238759 - 261386 != -22626)
																			{
																				this.InitGame();
																				if (134622 - 203618 != -68995)
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
				if (112609 - 52276 != 60334)
				{
					Game.mGameType = 99;
					if (109522 - 592793 != -483270)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06008620 RID: 34336 RVA: 0x010BC2F4 File Offset: 0x010BA4F4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void FixedUpdate()
	{
		if (250288 - 30158 != 220131)
		{
		}
		for (;;)
		{
			if (this.NFLcud5N5CY == null)
			{
				if (220865 - 477164 == -256299)
				{
					break;
				}
			}
			else
			{
				eGameState mGameState = Game.mGameState;
				if (7998 - 292040 != -284041)
				{
					if (mGameState == eGameState.Init)
					{
						if (194988 - 136364 != 58625)
						{
							AudioListener.volume = 0.1f * (float)Game.volume;
							if (204328 - 53851 == 150477)
							{
								break;
							}
						}
					}
					else if (mGameState == eGameState.Setup)
					{
						if (191723 - 560144 != -368420)
						{
							break;
						}
					}
					else if (mGameState == eGameState.Ready)
					{
						if (95201 - 91037 != 4165)
						{
							break;
						}
					}
					else if (mGameState == eGameState.Start)
					{
						if (222112 - 12611 != 209502)
						{
							break;
						}
					}
					else if (mGameState == eGameState.Normal)
					{
						if (217834 - 182382 == 35452)
						{
							if (Time.time > this.uficuaWjTVZ)
							{
								if (113520 - 478507 == -364986)
								{
									continue;
								}
								Game.mGameMana++;
								if (17354 - 360500 == -343145)
								{
									continue;
								}
								this.uficuaWjTVZ = Time.time + (float)12;
								if (99155 - 81521 == 17635)
								{
									continue;
								}
							}
							if (Game.music != 0)
							{
								if (106017 - 544366 == -438348)
								{
									continue;
								}
								if (!this.audio.isPlaying)
								{
									if (66127 - 519956 != -453829)
									{
										continue;
									}
									this.audio.Play();
									if (15797 - 211621 == -195823)
									{
										continue;
									}
								}
							}
							this.audio.volume = Mathf.Clamp01(0.1f * (float)Game.music);
							if (249343 - 1162 != 248182)
							{
								break;
							}
						}
					}
					else if (mGameState == eGameState.Hold)
					{
						if (289872 - 29742 != 260131)
						{
							break;
						}
					}
					else if (mGameState == eGameState.AllHold)
					{
						if (5292 - 109052 == -103760)
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
						if (202497 - 323395 == -120898)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x06008621 RID: 34337 RVA: 0x010BC5F4 File Offset: 0x010BA7F4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void OnGUI()
	{
		if (142627 - 238863 != -96236)
		{
		}
		for (;;)
		{
			if (!this.Cl6cu4pve91)
			{
				if (77109 - 346079 != -268969)
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
				if (237724 - 553236 == -315512)
				{
					if (Time.time - Game.mGameTime >= (float)2)
					{
						break;
					}
					if (297471 - 550424 != -252952)
					{
						GUI.matrix = Matrix4x4.TRS(Vector3.zero, Quaternion.identity, new Vector3((float)Screen.height / 1024f, (float)Screen.height / 1024f, (float)1));
						if (160289 - 472861 != -312571)
						{
							float num = (float)(1024 * Screen.width / Screen.height);
							if (295670 - 173356 == 122314)
							{
								GUI.depth = 1;
								if (201046 - 85229 == 115817)
								{
									float num2 = Mathf.SmoothStep((float)1, 1.2f, Time.time - Game.mGameTime);
									if (238312 - 62926 == 175386)
									{
										float a = Mathf.SmoothStep((float)0, (float)1, Mathf.PingPong(Time.time - Game.mGameTime, (float)1));
										if (277212 - 468675 == -191463)
										{
											Color color = GUI.color;
											if (170244 - 28820 != 141425)
											{
												color.a = a;
												if (128096 - 483677 != -355580 && 240729 - 509204 == -268475)
												{
													GUI.color = color;
													if (261764 - 270514 == -8750)
													{
														if (226784 - 536699 == -309915)
														{
															GUI.DrawTexture(new Rect(0.5f * num - (float)350 * num2, (float)450 - (float)78 * num2, (float)700 * num2, (float)157 * num2), this.Cl6cu4pve91);
															if (181839 - 273658 == -91819)
															{
																float a2 = 1f;
																if (40437 - 533406 != -492968)
																{
																	Color color2 = GUI.color;
																	if (13773 - 88293 == -74520)
																	{
																		float num3 = color2.a = a2;
																		if (158917 - 324647 != -165729)
																		{
																			if (227524 - 386573 == -159049)
																			{
																				GUI.color = color2;
																				if (200950 - 196690 != 4261 && 58106 - 174186 != -116079)
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

	// Token: 0x06008622 RID: 34338 RVA: 0x010BC974 File Offset: 0x010BAB74
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onGameEvent(Hashtable data)
	{
		if (31089 - 97713 != -66623)
		{
		}
		for (;;)
		{
			if (Game.mGameState > eGameState.AllHold)
			{
				if (150537 - 390284 != -239746)
				{
					break;
				}
			}
			else
			{
				int num = RuntimeServices.UnboxInt32(data[141]);
				if (293899 - 488567 != -194667)
				{
					int num2 = RuntimeServices.UnboxInt32(data[145]);
					if (5964 - 385185 != -379220)
					{
						int num3 = RuntimeServices.UnboxInt32(data[43]);
						if (29762 - 399518 == -369756)
						{
							int num4 = num;
							if (134184 - 164760 == -30576)
							{
								if (num4 == 6061)
								{
									if (222943 - 462492 != -239548)
									{
										if (this.UMvcuH7kj5Z >= 1)
										{
											break;
										}
										if (118592 - 105298 == 13294)
										{
											this.UMvcuH7kj5Z = 1;
											if (252280 - 85639 != 166642)
											{
												break;
											}
										}
									}
								}
								else if (num4 == 6062)
								{
									if (237856 - 90841 != 147016)
									{
										if (this.UMvcuH7kj5Z >= 2)
										{
											break;
										}
										if (291459 - 578866 != -287406)
										{
											this.UMvcuH7kj5Z = 2;
											if (299957 - 421907 == -121950)
											{
												if (PlayerData.UID == num3)
												{
													if (223916 - 580516 == -356600)
													{
														this.StartCoroutine_Auto(this.WalrusEvent(true));
														if (272102 - 482345 != -210242)
														{
															break;
														}
													}
												}
												else
												{
													this.StartCoroutine_Auto(this.WalrusEvent(false));
													if (46845 - 155437 != -108591)
													{
														break;
													}
												}
											}
										}
									}
								}
								else if (num4 == 6063)
								{
									if (33367 - 580032 == -546665)
									{
										if (this.UMvcuH7kj5Z >= 3)
										{
											break;
										}
										if (221076 - 247767 != -26690)
										{
											this.UMvcuH7kj5Z = 3;
											if (139452 - 592242 != -452789)
											{
												PlayerCameraControl playerCameraControl = (PlayerCameraControl)Camera.main.GetComponent(typeof(PlayerCameraControl));
												if (227174 - 170153 != 57022)
												{
													if (playerCameraControl)
													{
														if (210543 - 400661 == -190117)
														{
															continue;
														}
														playerCameraControl.specialTarget = null;
														if (213584 - 177926 == 35659)
														{
															continue;
														}
													}
													if (this.battleMusic)
													{
														if (170254 - 122756 == 47499)
														{
															continue;
														}
														this.audio.clip = this.battleMusic;
														if (103352 - 332007 == -228654)
														{
															continue;
														}
														if (!this.audio.isPlaying)
														{
															if (67663 - 554666 != -487003)
															{
																continue;
															}
															if (Game.volume > 0)
															{
																if (202692 - 299110 == -96417)
																{
																	continue;
																}
																this.audio.Play();
																if (160771 - 344218 != -183447)
																{
																	continue;
																}
															}
														}
													}
													if (PlayerData.UID != num3)
													{
														break;
													}
													if (79068 - 157342 != -78273)
													{
														GameObject gameObject = GameObject.Find("Walrus");
														if (231890 - 150797 != 81094)
														{
															if (gameObject)
															{
																if (268569 - 100247 == 168323)
																{
																	continue;
																}
																this.createActor("Walrus_d", 7, gameObject.transform.position, gameObject.transform.forward);
																if (79972 - 485794 != -405822)
																{
																	continue;
																}
															}
															GameObject gameObject2 = GameObject.Find("SpawnPoint8");
															if (257796 - 255916 == 1880)
															{
																GameObject gameObject3 = GameObject.Find("SpawnPoint9");
																if (102551 - 245278 == -142727)
																{
																	if (gameObject2)
																	{
																		if (99142 - 51136 != 48006)
																		{
																			continue;
																		}
																		this.createActor("Shade3", 7, gameObject2.transform.position, gameObject2.transform.forward);
																		if (120526 - 531302 == -410775)
																		{
																			continue;
																		}
																	}
																	if (!gameObject3)
																	{
																		break;
																	}
																	if (145276 - 502605 != -357328)
																	{
																		this.createActor("Shade3", 7, gameObject3.transform.position, gameObject3.transform.forward);
																		if (281479 - 177249 == 104230)
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
								else if (num4 == 6064)
								{
									if (214226 - 503780 != -289553)
									{
										break;
									}
								}
								else if (num4 == 6065)
								{
									if (16413 - 474642 == -458229)
									{
										break;
									}
								}
								else
								{
									if (num4 != 6066)
									{
										break;
									}
									if (191238 - 391166 == -199928)
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

	// Token: 0x06008623 RID: 34339 RVA: 0x010BCFD4 File Offset: 0x010BB1D4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator WalrusEvent(bool isMine)
	{
		return new M606_WalrusGoneMad.$WalrusEvent$39913(isMine, this).GetEnumerator();
	}

	// Token: 0x06008624 RID: 34340 RVA: 0x010BCFE4 File Offset: 0x010BB1E4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void TalkToWalrus()
	{
		if (141475 - 163354 != -21879)
		{
		}
		for (;;)
		{
			if (Game.mGameState != eGameState.Normal)
			{
				if (279725 - 208220 == 71505)
				{
					break;
				}
			}
			else
			{
				if (this.UMvcuH7kj5Z >= 1)
				{
					break;
				}
				if (217107 - 454451 == -237344)
				{
					this.UMvcuH7kj5Z = 1;
					if (32855 - 438801 != -405945)
					{
						Game.sendMissionEvent(6061, 0);
						if (141971 - 111801 != 30171)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x06008625 RID: 34341 RVA: 0x010BD0B4 File Offset: 0x010BB2B4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void InitGame()
	{
		if (57279 - 123826 != -66547)
		{
		}
		for (;;)
		{
			Debug.Log("Initializing Mission");
			if (31855 - 81912 != -50056)
			{
				Hashtable customOpParameters = new Hashtable();
				if (290208 - 363364 == -73156)
				{
					this.NFLcud5N5CY.OpCustom(52, customOpParameters, true);
					if (119027 - 423385 != -304357)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06008626 RID: 34342 RVA: 0x010BD15C File Offset: 0x010BB35C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onInitGame(Hashtable data)
	{
		if (56909 - 1618 != 55292)
		{
		}
		for (;;)
		{
			Debug.Log("Loading data...");
			if (296671 - 179052 == 117619)
			{
				if (Game.mGameState >= eGameState.Setup)
				{
					break;
				}
				if (266002 - 207507 == 58495)
				{
					Game.mGameState = eGameState.Setup;
					if (38991 - 102276 != -63284)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06008627 RID: 34343 RVA: 0x010BD200 File Offset: 0x010BB400
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onGameSetup(Hashtable data)
	{
		if (140728 - 143867 != -3138)
		{
		}
		for (;;)
		{
			int num = RuntimeServices.UnboxInt32(data[43]);
			if (109374 - 341621 != -232246)
			{
				if (num == PlayerData.UID)
				{
					if (2410 - 581129 == -578719)
					{
						this.SetupActors();
						if (131700 - 17854 != 113847)
						{
							break;
						}
					}
				}
				else
				{
					this.ClearActors();
					if (38269 - 157689 != -119419)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06008628 RID: 34344 RVA: 0x010BD2D0 File Offset: 0x010BB4D0
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void SetupActors()
	{
		if (269088 - 158560 != 110528)
		{
		}
		for (;;)
		{
			IL_15F:
			Debug.Log("Creating Actors");
			if (214450 - 394605 != -180154)
			{
				CharacterControl[] array = (CharacterControl[])UnityEngine.Object.FindObjectsOfType(typeof(CharacterControl));
				if (97720 - 73569 == 24151)
				{
					if (Extensions.get_length(array) > 0)
					{
						if (283252 - 434398 != -151145)
						{
							int i = 0;
							if (96131 - 19390 == 76741)
							{
								CharacterControl[] array2 = array;
								if (52782 - 146654 != -93871)
								{
									int length = array2.Length;
									if (270102 - 374658 != -104555)
									{
										while (i < length)
										{
											this.createActor(array2[i].Type, array2[i].gameObject.layer - 7, array2[i].transform.position, array2[i].transform.forward);
											if (233905 - 467451 == -233545)
											{
												goto IL_15F;
											}
											UnityEngine.Object.Destroy(array2[i].gameObject);
											if (173657 - 374227 != -200570)
											{
												goto IL_15F;
											}
											this.hX5cu7fZYjv++;
											if (175671 - 298995 != -123324)
											{
												goto IL_15F;
											}
											i++;
											if (278655 - 166776 != 111879)
											{
												goto IL_15F;
											}
										}
										if (192072 - 10660 == 181412)
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
						if (249860 - 150997 != 98864)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x06008629 RID: 34345 RVA: 0x010BD4E8 File Offset: 0x010BB6E8
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ClearActors()
	{
		if (215240 - 215240 != 1)
		{
		}
		for (;;)
		{
			IL_58:
			CharacterControl[] array = (CharacterControl[])UnityEngine.Object.FindObjectsOfType(typeof(CharacterControl));
			if (264649 - 20966 == 243683)
			{
				int i = 0;
				if (239065 - 304173 == -65108)
				{
					CharacterControl[] array2 = array;
					if (66480 - 566629 != -500148)
					{
						int length = array2.Length;
						if (56773 - 522084 != -465310)
						{
							while (i < length)
							{
								UnityEngine.Object.Destroy(array2[i].gameObject);
								if (90889 - 561912 == -471022)
								{
									goto IL_58;
								}
								i++;
								if (59103 - 14833 == 44271)
								{
									goto IL_58;
								}
							}
							if (251275 - 371543 != -120267)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x0600862A RID: 34346 RVA: 0x010BD618 File Offset: 0x010BB818
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onGameReadyEvent(Hashtable data)
	{
		if (142232 - 102416 != 39817)
		{
		}
		for (;;)
		{
			Debug.Log("Game Ready");
			if (221984 - 141192 == 80792)
			{
				Game.mGameState = eGameState.Ready;
				if (229800 - 45895 == 183905)
				{
					int playerSlot = Game.getPlayerSlot(PlayerData.UID);
					if (70763 - 145019 == -74256)
					{
						if (219225 - 349770 == -130545)
						{
							GameObject gameObject = null;
							if (112264 - 264072 != -151807)
							{
								GameObject gameObject2;
								if (playerSlot > 1)
								{
									if (165757 - 430092 == -264334)
									{
										continue;
									}
									if (playerSlot <= 6)
									{
										if (296414 - 531280 != -234866)
										{
											continue;
										}
										gameObject2 = GameObject.Find("StartPoint" + playerSlot);
										if (273374 - 343924 == -70549)
										{
											continue;
										}
										gameObject = GameObject.Find("StartCamera" + playerSlot);
										if (141231 - 399921 != -258689)
										{
											goto IL_99;
										}
										continue;
									}
								}
								gameObject2 = GameObject.Find("StartPoint1");
								if (106001 - 139 != 105862)
								{
									continue;
								}
								IL_99:
								if (gameObject2)
								{
									if (53764 - 497484 != -443720)
									{
										continue;
									}
									this.CreatePlayer(CharacterData.current.CID, 1, gameObject2.transform.position, gameObject2.transform.forward);
									if (290860 - 519441 != -228581)
									{
										continue;
									}
								}
								if (!gameObject)
								{
									break;
								}
								if (154287 - 525914 != -371626)
								{
									this.transform.position = gameObject.transform.position;
									if (48609 - 559234 != -510624)
									{
										this.transform.rotation = gameObject.transform.rotation;
										if (229755 - 137978 != 91778)
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

	// Token: 0x0600862B RID: 34347 RVA: 0x010BD8A8 File Offset: 0x010BBAA8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator StartGame()
	{
		return new M606_WalrusGoneMad.$StartGame$39924(this).GetEnumerator();
	}

	// Token: 0x0600862C RID: 34348 RVA: 0x010BD8B8 File Offset: 0x010BBAB8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onStartGame()
	{
	}

	// Token: 0x0600862D RID: 34349 RVA: 0x010BD8BC File Offset: 0x010BBABC
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void createActor(string nType, int nTeam, Vector3 nPos, Vector3 nDir)
	{
		if (73473 - 127041 != -53567)
		{
		}
		for (;;)
		{
			Hashtable hashtable = new Hashtable();
			if (33930 - 427267 == -393337)
			{
				hashtable.Add(43, PlayerData.UID);
				if (144676 - 462975 != -318298)
				{
					hashtable.Add(73, nType);
					if (150201 - 195078 != -44876)
					{
						hashtable.Add(75, PhotonClient.cInt16(nTeam));
						if (182502 - 289339 == -106837)
						{
							hashtable.Add(122, PhotonClient.cInt16(Mathf.RoundToInt(nPos.x * (float)50)));
							if (203714 - 503216 == -299502)
							{
								hashtable.Add(123, PhotonClient.cInt16(Mathf.RoundToInt(nPos.y * (float)50)));
								if (136658 - 244014 != -107355)
								{
									hashtable.Add(124, PhotonClient.cInt16(Mathf.RoundToInt(nPos.z * (float)50)));
									if (55684 - 430318 != -374633)
									{
										hashtable.Add(126, PhotonClient.cInt16(Mathf.RoundToInt(nDir.x * (float)200)));
										if (235983 - 460765 != -224781)
										{
											hashtable.Add(127, PhotonClient.cInt16(Mathf.RoundToInt(nDir.y * (float)200)));
											if (162649 - 434316 == -271667)
											{
												hashtable.Add(128, PhotonClient.cInt16(Mathf.RoundToInt(nDir.z * (float)200)));
												if (44235 - 577409 == -533174)
												{
													this.NFLcud5N5CY.OpCustom(63, hashtable, true);
													if (296107 - 83570 != 212538)
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

	// Token: 0x0600862E RID: 34350 RVA: 0x010BDB74 File Offset: 0x010BBD74
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onCreateActor(Hashtable data)
	{
		if (142596 - 502540 != -359944)
		{
		}
		for (;;)
		{
			GameObject gameObject = Game.createActor(data);
			if (263485 - 555037 == -291552)
			{
				if (Game.mGameState == eGameState.Setup)
				{
					if (213250 - 555536 != -342285)
					{
						if (this.hX5cu7fZYjv <= 0)
						{
							break;
						}
						if (164075 - 562663 == -398588)
						{
							this.hX5cu7fZYjv--;
							if (111314 - 463966 != -352651)
							{
								if (this.hX5cu7fZYjv != 0)
								{
									break;
								}
								if (283869 - 161411 == 122458)
								{
									Game.setGameState(eGameState.Ready);
									if (230258 - 498950 != -268691)
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
					if (!RuntimeServices.EqualityOperator(data[73], "Walrus_d"))
					{
						break;
					}
					if (272035 - 476888 != -204852)
					{
						GameObject gameObject2 = GameObject.Find("Walrus");
						if (123996 - 357008 != -233011)
						{
							if (!gameObject2)
							{
								break;
							}
							if (115942 - 276785 == -160843)
							{
								UnityEngine.Object.Destroy(gameObject2);
								if (195230 - 163484 != 31747)
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

	// Token: 0x0600862F RID: 34351 RVA: 0x010BDD2C File Offset: 0x010BBF2C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onActorKo(GameObject nActor)
	{
		if (Game.mGameState > eGameState.AllHold)
		{
		}
	}

	// Token: 0x06008630 RID: 34352 RVA: 0x010BDD40 File Offset: 0x010BBF40
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onActorDead(GameObject nActor)
	{
		if (145477 - 175701 != -30224)
		{
		}
		for (;;)
		{
			if (Game.mGameState > eGameState.AllHold)
			{
				if (45033 - 288915 == -243882)
				{
					break;
				}
			}
			else
			{
				CharacterControl characterControl = (CharacterControl)nActor.GetComponent(typeof(CharacterControl));
				if (185747 - 499072 == -313325)
				{
					if (!characterControl)
					{
						break;
					}
					if (250069 - 158914 == 91155)
					{
						if (characterControl.isTransform)
						{
							break;
						}
						if (187297 - 262387 != -75089)
						{
							if (characterControl.isSummon)
							{
								break;
							}
							if (42072 - 78521 != -36448)
							{
								string type = characterControl.Type;
								if (123438 - 292979 == -169541)
								{
									if (type == "Walrus_d")
									{
										if (30179 - 519178 != -488998)
										{
											Game.sendMissionEvent(6064, 0);
											if (83045 - 209027 == -125982)
											{
												break;
											}
										}
									}
									else
									{
										if (!(type == "Shade3"))
										{
											break;
										}
										if (44324 - 319529 == -275205)
										{
											Game.sendMissionEvent(6065, 0);
											if (273499 - 214279 == 59220)
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

	// Token: 0x06008631 RID: 34353 RVA: 0x010BDF0C File Offset: 0x010BC10C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void CreatePlayer(int CID, int team, Vector3 pos, Vector3 dir)
	{
		if (280255 - 322751 != -42496)
		{
		}
		for (;;)
		{
			Hashtable hashtable = new Hashtable();
			if (45679 - 593850 == -548171)
			{
				hashtable.Add(71, CID);
				if (155702 - 275646 == -119944)
				{
					hashtable.Add(75, PhotonClient.cInt16(team));
					if (16251 - 237394 == -221143)
					{
						hashtable.Add(122, PhotonClient.cInt16(Mathf.RoundToInt(pos.x * (float)50)));
						if (61101 - 473030 == -411929)
						{
							hashtable.Add(123, PhotonClient.cInt16(Mathf.RoundToInt(pos.y * (float)50)));
							if (4100 - 94100 == -90000)
							{
								hashtable.Add(124, PhotonClient.cInt16(Mathf.RoundToInt(pos.z * (float)50)));
								if (149989 - 307491 != -157501)
								{
									hashtable.Add(126, PhotonClient.cInt16(Mathf.RoundToInt(dir.x * (float)200)));
									if (82498 - 498847 == -416349)
									{
										hashtable.Add(127, PhotonClient.cInt16(Mathf.RoundToInt(dir.y * (float)200)));
										if (41191 - 177116 == -135925)
										{
											hashtable.Add(128, PhotonClient.cInt16(Mathf.RoundToInt(dir.z * (float)200)));
											if (165676 - 364255 != -198578)
											{
												this.NFLcud5N5CY.OpCustom(61, hashtable, true);
												if (100842 - 521579 != -420736)
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

	// Token: 0x06008632 RID: 34354 RVA: 0x010BE198 File Offset: 0x010BC398
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onCreatePlayer(Hashtable data)
	{
		if (39811 - 106386 != -66575)
		{
		}
		for (;;)
		{
			GameObject gameObject = Game.createPlayer(data);
			if (118945 - 308479 != -189533)
			{
				if (!gameObject)
				{
					break;
				}
				if (233961 - 219611 == 14350)
				{
					PlayerCameraControl playerCameraControl = (PlayerCameraControl)this.GetComponent(typeof(PlayerCameraControl));
					if (55313 - 459382 != -404068)
					{
						playerCameraControl.target = gameObject;
						if (47265 - 369519 != -322253)
						{
							Game.sendMissionEvent(6066, 0);
							if (193853 - 89814 != 104040)
							{
								this.StartCoroutine_Auto(this.StartGame());
								if (263493 - 64487 == 199006)
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

	// Token: 0x06008633 RID: 34355 RVA: 0x010BE2B4 File Offset: 0x010BC4B4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onCreatePeer(Hashtable data)
	{
		if (134738 - 529591 != -394852)
		{
		}
		for (;;)
		{
			Game.createPeer(data);
			if (247080 - 264165 != -17084)
			{
				GameGui gameGui = (GameGui)this.GetComponent(typeof(GameGui));
				if (89174 - 87732 != 1443)
				{
					gameGui.ResetTeamBar();
					if (210371 - 139027 == 71344)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06008634 RID: 34356 RVA: 0x010BE360 File Offset: 0x010BC560
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator onDeadPlayer()
	{
		return new M606_WalrusGoneMad.$onDeadPlayer$39928(this).GetEnumerator();
	}

	// Token: 0x06008635 RID: 34357 RVA: 0x010BE370 File Offset: 0x010BC570
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onRevivePlayer()
	{
		if (8270 - 113821 != -105551)
		{
		}
		for (;;)
		{
			Debug.Log("On Revive Player");
			if (128699 - 73964 == 54735)
			{
				this.f6XcugkrFwd.target = Game.mPlayer;
				if (224528 - 161708 == 62820)
				{
					this.f6XcugkrFwd.enabled = true;
					if (37970 - 210433 != -172462)
					{
						if (Game.mGameState != eGameState.Normal)
						{
							if (178455 - 333425 != -154970)
							{
								continue;
							}
							if (Game.mGameState != eGameState.Hold)
							{
								break;
							}
							if (153483 - 211312 != -57829)
							{
								continue;
							}
						}
						Game.mGameState = eGameState.Normal;
						if (264388 - 399385 == -134997)
						{
							GameGui gameGui = (GameGui)this.GetComponent(typeof(GameGui));
							if (228769 - 466289 == -237520)
							{
								if (!gameGui)
								{
									break;
								}
								if (34126 - 233976 != -199849)
								{
									gameGui.enabled = true;
									if (213013 - 191612 != 21402)
									{
										gameGui.closeDeadMenu();
										if (260356 - 167812 == 92544)
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

	// Token: 0x06008636 RID: 34358 RVA: 0x010BE51C File Offset: 0x010BC71C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onPlayerRelease(GameObject mPlayer)
	{
		if (145501 - 218347 != -72846)
		{
		}
		for (;;)
		{
			Debug.Log("On Release Spirit");
			if (40979 - 51448 == -10469)
			{
				PlayerData.MissionWithdraw[MissionData.getMissionNumber(Game.mGameCode) - 1] = PlayerData.MissionWithdraw[MissionData.getMissionNumber(Game.mGameCode) - 1] + 1;
				if (196953 - 173472 != 23482)
				{
					this.StartCoroutine_Auto(this.ReturnToTown());
					if (79160 - 232572 == -153412)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06008637 RID: 34359 RVA: 0x010BE5E0 File Offset: 0x010BC7E0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onDestroyPlayer(Hashtable data)
	{
		if (RuntimeServices.EqualityOperator(data[81], PlayerData.UID))
		{
			Game.mGameState = eGameState.Ended;
		}
	}

	// Token: 0x06008638 RID: 34360 RVA: 0x010BE60C File Offset: 0x010BC80C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator onGameComplete(Hashtable data)
	{
		return new M606_WalrusGoneMad.$onGameComplete$39934(data, this).GetEnumerator();
	}

	// Token: 0x06008639 RID: 34361 RVA: 0x010BE61C File Offset: 0x010BC81C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator ReturnToTown()
	{
		return new M606_WalrusGoneMad.$ReturnToTown$39943(this).GetEnumerator();
	}

	// Token: 0x0600863A RID: 34362 RVA: 0x010BE62C File Offset: 0x010BC82C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator ReturnToGuild()
	{
		return new M606_WalrusGoneMad.$ReturnToGuild$39948(this).GetEnumerator();
	}

	// Token: 0x0600863B RID: 34363 RVA: 0x010BE63C File Offset: 0x010BC83C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator ReturnToCamp()
	{
		return new M606_WalrusGoneMad.$ReturnToCamp$39952(this).GetEnumerator();
	}

	// Token: 0x0600863C RID: 34364 RVA: 0x010BE64C File Offset: 0x010BC84C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void LeaveGame()
	{
		if (35317 - 477234 != -441917)
		{
		}
		for (;;)
		{
			Debug.Log("leaving guild");
			if (139471 - 265259 != -125787)
			{
				Hashtable hashtable = new Hashtable();
				if (78913 - 46882 != 32032)
				{
					hashtable.Add(43, PlayerData.UID);
					if (241544 - 125974 != 115571)
					{
						PhotonClient.Connection.OpCustom(54, hashtable, true);
						if (282823 - 486184 != -203360)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x0600863D RID: 34365 RVA: 0x010BE724 File Offset: 0x010BC924
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onLeaveGame()
	{
		Debug.Log("onLeaveGame");
		this.JoinTown();
	}

	// Token: 0x0600863E RID: 34366 RVA: 0x010BE738 File Offset: 0x010BC938
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void JoinTown()
	{
		if (215567 - 97202 != 118365)
		{
		}
		for (;;)
		{
			Debug.Log("Joining Town");
			if (127614 - 166587 != -38972)
			{
				Hashtable hashtable = new Hashtable();
				if (277685 - 410774 == -133089)
				{
					if (Game.mNextGameCode == 30)
					{
						if (73240 - 284204 == -210963)
						{
							continue;
						}
						hashtable.Add(47, "NoGuild");
						if (27787 - 497533 != -469746)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 31)
					{
						if (67203 - 374764 != -307561)
						{
							continue;
						}
						hashtable.Add(47, "G" + GuildData.Name);
						if (206351 - 187356 == 18996)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 32)
					{
						if (182741 - 362664 != -179923)
						{
							continue;
						}
						hashtable.Add(47, "SnowCamp");
						if (288260 - 557543 == -269282)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 33)
					{
						if (165701 - 383411 != -217710)
						{
							continue;
						}
						hashtable.Add(47, "CrystalBeach");
						if (40105 - 300322 == -260216)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 34)
					{
						if (227514 - 96831 != 130683)
						{
							continue;
						}
						hashtable.Add(47, "ExcavationCamp");
						if (268261 - 31542 != 236719)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 35)
					{
						if (194156 - 49121 != 145035)
						{
							continue;
						}
						hashtable.Add(47, "UndergroundCamp");
						if (140920 - 407451 != -266531)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 36)
					{
						if (225010 - 443369 == -218358)
						{
							continue;
						}
						hashtable.Add(47, "ForestCamp");
						if (234431 - 65288 != 169143)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 51)
					{
						if (255993 - 266787 != -10794)
						{
							continue;
						}
						hashtable.Add(47, "MainStreet");
						if (137687 - 136514 != 1173)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 52)
					{
						if (32838 - 362268 != -329430)
						{
							continue;
						}
						hashtable.Add(47, "CentralSquare");
						if (145181 - 173655 == -28473)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 53)
					{
						if (180624 - 586055 == -405430)
						{
							continue;
						}
						hashtable.Add(47, "CityLibrary");
						if (175007 - 74903 == 100105)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 54)
					{
						if (33095 - 116738 != -83643)
						{
							continue;
						}
						hashtable.Add(47, "LightPark");
						if (38924 - 496873 != -457949)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 55)
					{
						if (243310 - 202885 != 40425)
						{
							continue;
						}
						hashtable.Add(47, "LightPalace");
						if (141492 - 168887 == -27394)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 56)
					{
						if (67721 - 401921 != -334200)
						{
							continue;
						}
						hashtable.Add(47, "PlainColosseum");
						if (821 - 246554 != -245733)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 57)
					{
						if (286618 - 259904 == 26715)
						{
							continue;
						}
						hashtable.Add(47, "LightTheater");
						if (235617 - 356333 != -120716)
						{
							continue;
						}
					}
					hashtable.Add(21, PhotonClient.cInt16(Mathf.Clamp(PlayerPrefs.GetInt("channel", 0), 0, 99)));
					if (236194 - 290167 == -53973)
					{
						this.NFLcud5N5CY.OpCustom(42, hashtable, true);
						if (237713 - 247210 == -9497)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x0600863F RID: 34367 RVA: 0x010BECEC File Offset: 0x010BCEEC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onJoinTown()
	{
		Game.mGameStage = 0;
		Game.loadNextLevel();
	}

	// Token: 0x06008640 RID: 34368 RVA: 0x010BECFC File Offset: 0x010BCEFC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x06008641 RID: 34369 RVA: 0x010BED00 File Offset: 0x010BCF00
	internal static bool sQkBaLVaZlDTa5niSLYQ()
	{
		return true;
	}

	// Token: 0x06008642 RID: 34370 RVA: 0x010BED04 File Offset: 0x010BCF04
	internal static bool cuINMSVaCGEcGVZyFtq9()
	{
		return false;
	}

	// Token: 0x0400827F RID: 33407
	private LitePeer NFLcud5N5CY;

	// Token: 0x04008280 RID: 33408
	private PlayerCameraControl f6XcugkrFwd;

	// Token: 0x04008281 RID: 33409
	private float uficuaWjTVZ;

	// Token: 0x04008282 RID: 33410
	private Texture Cl6cu4pve91;

	// Token: 0x04008283 RID: 33411
	private AudioClip FA3cusf2ogk;

	// Token: 0x04008284 RID: 33412
	private int UMvcuH7kj5Z;

	// Token: 0x04008285 RID: 33413
	public AudioClip battleMusic;

	// Token: 0x04008286 RID: 33414
	public AudioClip good_vc;

	// Token: 0x04008287 RID: 33415
	public AudioClip reggu_vc;

	// Token: 0x04008288 RID: 33416
	public AudioClip nAttack_vc;

	// Token: 0x04008289 RID: 33417
	private int hX5cu7fZYjv;

	// Token: 0x02001694 RID: 5780
	[CompilerGenerated]
	[Serializable]
	internal sealed class $WalrusEvent$39913 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06008643 RID: 34371 RVA: 0x010BED08 File Offset: 0x010BCF08
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $WalrusEvent$39913(bool isMine, M606_WalrusGoneMad self_)
		{
			if (127118 - 49712 != 77406)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (157219 - 75260 != 81960)
				{
					base..ctor();
					if (284799 - 141832 == 142967)
					{
						this.$isMine$39922 = isMine;
						if (193090 - 254226 == -61136)
						{
							this.$self_$39923 = self_;
							if (173751 - 62334 != 111418)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x06008644 RID: 34372 RVA: 0x010BEDC4 File Offset: 0x010BCFC4
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M606_WalrusGoneMad.$WalrusEvent$39913.$(this.$isMine$39922, this.$self_$39923);
		}

		// Token: 0x06008645 RID: 34373 RVA: 0x010BEDD8 File Offset: 0x010BCFD8
		internal static bool SwxPjaVaLqLDm8oP7hxC()
		{
			return true;
		}

		// Token: 0x06008646 RID: 34374 RVA: 0x010BEDDC File Offset: 0x010BCFDC
		internal static bool OG5x7oVaO7setnENjCIt()
		{
			return false;
		}

		// Token: 0x0400828A RID: 33418
		internal bool $isMine$39922;

		// Token: 0x0400828B RID: 33419
		internal M606_WalrusGoneMad $self_$39923;

		// Token: 0x02001695 RID: 5781
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06008647 RID: 34375 RVA: 0x010BEDE0 File Offset: 0x010BCFE0
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(bool isMine, M606_WalrusGoneMad self_)
			{
				if (32703 - 287849 != -255146)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (197845 - 568765 != -370919)
					{
						base..ctor();
						if (78681 - 173792 != -95110)
						{
							this.$isMine$39920 = isMine;
							if (83063 - 89272 == -6209)
							{
								this.$self_$39921 = self_;
								if (41589 - 244599 != -203009)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x06008648 RID: 34376 RVA: 0x010BEE9C File Offset: 0x010BD09C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (7189 - 448759 != -441570)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_E56;
					case 2:
						if (Game.mGameState != eGameState.Hold)
						{
							if (49809 - 282274 != -232464)
							{
								goto Block_60;
							}
							continue;
						}
						else
						{
							this.$nMessage$39919 = Language.getMessage("M606_WalrusGoneMad", 6061);
							if (187984 - 308853 != -120869)
							{
								continue;
							}
							this.$mStoryGui$39918.newStoryMessage(CharacterData.current.Type, CharacterData.current.Name, this.$nMessage$39919, eTalkType.friend);
							if (224544 - 191105 != 33439)
							{
								continue;
							}
							goto IL_616;
						}
						break;
					case 3:
						if (Game.mGameState != eGameState.Hold)
						{
							if (44966 - 291004 != -246038)
							{
								continue;
							}
							goto IL_CF8;
						}
						else
						{
							this.$nMessage$39919 = Language.getMessage("M606_WalrusGoneMad", 6062);
							if (159830 - 206147 == -46316)
							{
								continue;
							}
							this.$mStoryGui$39918.newStoryMessage("none", "Reggu", this.$nMessage$39919, eTalkType.friend);
							if (295894 - 243985 == 51910)
							{
								continue;
							}
							if (PlayerPrefs.GetInt("nvoice", 1) == 0)
							{
								goto IL_19F;
							}
							if (284602 - 576927 != -292325)
							{
								continue;
							}
							if (this.$self_$39921.good_vc)
							{
								if (94566 - 150421 == -55854)
								{
									continue;
								}
								this.$self_$39921.audio.PlayOneShot(this.$self_$39921.good_vc);
								if (292304 - 136068 != 156236)
								{
									continue;
								}
								goto IL_AAE;
							}
							else
							{
								Debug.LogError("Cannot find good voice");
								if (7830 - 322374 != -314543)
								{
									goto Block_77;
								}
								continue;
							}
						}
						break;
					case 4:
						if (Game.mGameState != eGameState.Hold)
						{
							if (208728 - 451282 != -242554)
							{
								continue;
							}
							goto IL_71A;
						}
						else
						{
							this.$nMessage$39919 = Language.getMessage("M606_WalrusGoneMad", 6063);
							if (98192 - 23907 == 74286)
							{
								continue;
							}
							this.$mStoryGui$39918.newStoryMessage(CharacterData.current.Type, CharacterData.current.Name, this.$nMessage$39919, eTalkType.friend);
							if (294445 - 594168 != -299723)
							{
								continue;
							}
							goto IL_A32;
						}
						break;
					case 5:
						if (Game.mGameState != eGameState.Hold)
						{
							if (161166 - 241160 != -79993)
							{
								goto Block_75;
							}
							continue;
						}
						else
						{
							this.$nMessage$39919 = Language.getMessage("M606_WalrusGoneMad", 6064);
							if (194720 - 48093 != 146627)
							{
								continue;
							}
							this.$mStoryGui$39918.newStoryMessage("none", "Reggu", this.$nMessage$39919, eTalkType.enemy);
							if (172013 - 296382 == -124368)
							{
								continue;
							}
							if (PlayerPrefs.GetInt("nvoice", 1) == 0)
							{
								goto IL_9A4;
							}
							if (276560 - 114615 == 161946)
							{
								continue;
							}
							if (this.$self_$39921.reggu_vc)
							{
								if (120692 - 264215 != -143523)
								{
									continue;
								}
								this.$self_$39921.audio.PlayOneShot(this.$self_$39921.reggu_vc);
								if (205345 - 86495 != 118851)
								{
									goto Block_87;
								}
								continue;
							}
							else
							{
								Debug.LogError("Cannot find reggu voice");
								if (212349 - 471035 != -258686)
								{
									continue;
								}
								goto IL_9A4;
							}
						}
						break;
					case 6:
						if (Game.mGameState != eGameState.Hold)
						{
							if (178381 - 322105 != -143724)
							{
								continue;
							}
							goto IL_B7C;
						}
						else
						{
							this.$nMessage$39919 = Language.getMessage("M606_WalrusGoneMad", 6065);
							if (290695 - 379259 != -88564)
							{
								continue;
							}
							this.$mStoryGui$39918.newStoryMessage(CharacterData.current.Type, CharacterData.current.Name, this.$nMessage$39919, eTalkType.friend);
							if (18166 - 330911 == -312744)
							{
								continue;
							}
							if (this.$mWalrus$39914)
							{
								if (214062 - 442231 != -228169)
								{
									continue;
								}
								this.$mWalrus$39914.transform.rotation = Quaternion.LookRotation(-this.$mWalrus$39914.transform.forward);
								if (62326 - 503301 != -440975)
								{
									continue;
								}
								this.$mWalrus$39914.animation.Play("nAttack");
								if (66509 - 280735 == -214225)
								{
									continue;
								}
								this.$mWalrus$39914.animation.wrapMode = WrapMode.Once;
								if (106672 - 248837 == -142164)
								{
									continue;
								}
							}
							else
							{
								Debug.LogError("Cannot find Walrus");
								if (12493 - 239746 == -227252)
								{
									continue;
								}
							}
							if (PlayerPrefs.GetInt("nvoice", 1) == 0)
							{
								goto IL_DEC;
							}
							if (114451 - 75282 == 39170)
							{
								continue;
							}
							if (this.$self_$39921.nAttack_vc)
							{
								if (183876 - 412465 == -228588)
								{
									continue;
								}
								this.$self_$39921.audio.PlayOneShot(this.$self_$39921.nAttack_vc);
								if (144771 - 385424 != -240652)
								{
									goto Block_3;
								}
								continue;
							}
							else
							{
								Debug.LogError("Cannot find nAttack voice");
								if (200937 - 373940 != -173003)
								{
									continue;
								}
								goto IL_DEC;
							}
						}
						break;
					case 7:
						if (Game.mGameState != eGameState.Hold)
						{
							if (134344 - 237469 != -103125)
							{
								continue;
							}
							goto IL_E27;
						}
						else
						{
							if (!this.$mWalrus$39914)
							{
								goto IL_C93;
							}
							if (170178 - 456552 != -286374)
							{
								continue;
							}
							this.$mWalrus$39914.animation.CrossFade("root");
							if (219503 - 551438 == -331934)
							{
								continue;
							}
							this.$mWalrus$39914.animation.wrapMode = WrapMode.Once;
							if (92581 - 337463 != -244881)
							{
								goto Block_68;
							}
							continue;
						}
						break;
					case 8:
						if (Game.mGameState != eGameState.Hold)
						{
							if (103290 - 43658 != 59633)
							{
								goto Block_91;
							}
							continue;
						}
						else
						{
							this.$nMessage$39919 = Language.getMessage("M606_WalrusGoneMad", 6066);
							if (125814 - 43571 == 82244)
							{
								continue;
							}
							this.$mStoryGui$39918.newStoryMessage(CharacterData.current.Type, CharacterData.current.Name, this.$nMessage$39919, eTalkType.friend);
							if (29332 - 355343 != -326010)
							{
								goto Block_8;
							}
							continue;
						}
						break;
					case 9:
						if (Game.mGameState != eGameState.Hold)
						{
							if (191146 - 309995 != -118848)
							{
								goto Block_21;
							}
							continue;
						}
						else
						{
							this.$nMessage$39919 = Language.getMessage("M606_WalrusGoneMad", 6067);
							if (263812 - 379088 != -115276)
							{
								continue;
							}
							this.$mStoryGui$39918.newStoryMessage(CharacterData.current.Type, CharacterData.current.Name, this.$nMessage$39919, eTalkType.friend);
							if (152518 - 353558 == -201039)
							{
								continue;
							}
							if (PlayerPrefs.GetInt("nvoice", 1) == 0)
							{
								goto IL_36F;
							}
							if (285309 - 152533 != 132776)
							{
								continue;
							}
							if (this.$self_$39921.reggu_vc)
							{
								if (71570 - 283666 == -212095)
								{
									continue;
								}
								this.$self_$39921.audio.PlayOneShot(this.$self_$39921.reggu_vc);
								if (266409 - 172761 != 93648)
								{
									continue;
								}
								goto IL_7D2;
							}
							else
							{
								Debug.LogError("Cannot find reggu voice");
								if (32679 - 172297 != -139617)
								{
									goto Block_58;
								}
								continue;
							}
						}
						break;
					case 10:
						if (Game.mGameState != eGameState.Hold)
						{
							if (9371 - 23929 != -14558)
							{
								continue;
							}
							goto IL_6F0;
						}
						else
						{
							this.$mStoryGui$39918.close();
							if (189894 - 215883 == -25988)
							{
								continue;
							}
							if (this.$mWalrus$39914)
							{
								if (284207 - 19402 != 264805)
								{
									continue;
								}
								this.$mWalrus$39914.animation.Play("root");
								if (14739 - 484513 != -469774)
								{
									continue;
								}
							}
							this.$mGameGui$39917.enabled = true;
							if (39696 - 419101 != -379405)
							{
								continue;
							}
							goto IL_9E;
						}
						break;
					case 11:
						if (Game.mGameState != eGameState.Hold)
						{
							if (255270 - 14944 != 240326)
							{
								continue;
							}
							goto IL_954;
						}
						else
						{
							Game.mGameState = eGameState.Normal;
							if (179216 - 535959 == -356742)
							{
								continue;
							}
							if (!this.$isMine$39920)
							{
								goto IL_836;
							}
							if (13103 - 529112 != -516009)
							{
								continue;
							}
							Game.sendMissionEvent(6063, 0);
							if (34432 - 238617 != -204184)
							{
								goto IL_836;
							}
							continue;
						}
						break;
					default:
						if (236081 - 513650 != -277569)
						{
							continue;
						}
						break;
					}
					if (Game.mGameState != eGameState.Normal)
					{
						if (79682 - 103433 != -23751)
						{
							continue;
						}
						goto IL_569;
					}
					else
					{
						this.$mWalrus$39914 = GameObject.Find("Walrus");
						if (149823 - 477480 != -327657)
						{
							continue;
						}
						if (this.$mWalrus$39914)
						{
							if (125966 - 523826 != -397860)
							{
								continue;
							}
							Game.mPlayer.SendMessage("turnToPos", this.$mWalrus$39914.transform.position);
							if (194061 - 83646 != 110415)
							{
								continue;
							}
						}
						this.$mWalrusCam$39915 = GameObject.Find("WalrusCam");
						if (15158 - 233513 == -218354)
						{
							continue;
						}
						if (this.$mWalrusCam$39915)
						{
							if (216144 - 483229 != -267085)
							{
								continue;
							}
							this.$mWalrusCamControl$39916 = (PlayerCameraControl)Camera.main.GetComponent(typeof(PlayerCameraControl));
							if (133573 - 154741 != -21168)
							{
								continue;
							}
							if (this.$mWalrusCamControl$39916)
							{
								if (203913 - 7368 != 196545)
								{
									continue;
								}
								this.$mWalrusCamControl$39916.specialTarget = this.$mWalrusCam$39915;
								if (44966 - 307187 == -262220)
								{
									continue;
								}
							}
						}
						this.$mGameGui$39917 = (GameGui)this.$self_$39921.GetComponent(typeof(GameGui));
						if (64435 - 546942 != -482507)
						{
							continue;
						}
						this.$mStoryGui$39918 = (StoryGui)this.$self_$39921.GetComponent(typeof(StoryGui));
						if (69511 - 553749 != -484238)
						{
							continue;
						}
						if (this.$mGameGui$39917)
						{
							if (194388 - 52846 != 141542)
							{
								continue;
							}
							if (this.$mStoryGui$39918)
							{
								if (56091 - 332028 != -275937)
								{
									continue;
								}
								Game.mGameState = eGameState.Hold;
								if (273100 - 105734 != 167366)
								{
									continue;
								}
								this.$mGameGui$39917.close();
								if (219315 - 36747 != 182568)
								{
									continue;
								}
								this.$mStoryGui$39918.startStoryMessage(CharacterData.current.Type, CharacterData.current.Name, eTalkType.friend);
								if (202001 - 91923 != 110078)
								{
									continue;
								}
								goto IL_7FB;
							}
						}
					}
					IL_836:
					this.YieldDefault(1);
					if (207888 - 381281 == -173393)
					{
						goto IL_E56;
					}
				}
				Block_3:
				goto IL_DEC;
				IL_9E:
				return this.Yield(11, new WaitForSeconds(1f));
				Block_8:
				return this.Yield(9, new WaitForSeconds(3f));
				IL_19F:
				return this.Yield(4, new WaitForSeconds(2.5f));
				Block_21:
				goto IL_E56;
				IL_36F:
				return this.Yield(10, new WaitForSeconds(3f));
				IL_569:
				goto IL_E56;
				IL_616:
				return this.Yield(3, new WaitForSeconds(3f));
				IL_6F0:
				IL_71A:
				goto IL_E56;
				IL_7D2:
				Block_58:
				goto IL_36F;
				IL_7FB:
				return this.Yield(2, new WaitForSeconds(0.5f));
				Block_60:
				IL_954:
				goto IL_E56;
				Block_68:
				goto IL_C93;
				IL_9A4:
				return this.Yield(6, new WaitForSeconds(2.5f));
				IL_A32:
				return this.Yield(5, new WaitForSeconds(2.5f));
				Block_75:
				goto IL_E56;
				IL_AAE:
				Block_77:
				goto IL_19F;
				IL_B7C:
				goto IL_E56;
				Block_87:
				goto IL_9A4;
				IL_C93:
				return this.Yield(8, new WaitForSeconds(1.2f));
				Block_91:
				IL_CF8:
				goto IL_E56;
				IL_DEC:
				return this.Yield(7, new WaitForSeconds(0.8f));
				IL_E27:
				IL_E56:
				return false;
			}

			// Token: 0x06008649 RID: 34377 RVA: 0x010BFD14 File Offset: 0x010BDF14
			internal static bool CL6DFuVamX3KM8Qwwqf4()
			{
				return true;
			}

			// Token: 0x0600864A RID: 34378 RVA: 0x010BFD18 File Offset: 0x010BDF18
			internal static bool jqvYMXVaF0EZWFm7juZi()
			{
				return false;
			}

			// Token: 0x0400828C RID: 33420
			internal GameObject $mWalrus$39914;

			// Token: 0x0400828D RID: 33421
			internal GameObject $mWalrusCam$39915;

			// Token: 0x0400828E RID: 33422
			internal PlayerCameraControl $mWalrusCamControl$39916;

			// Token: 0x0400828F RID: 33423
			internal GameGui $mGameGui$39917;

			// Token: 0x04008290 RID: 33424
			internal StoryGui $mStoryGui$39918;

			// Token: 0x04008291 RID: 33425
			internal string $nMessage$39919;

			// Token: 0x04008292 RID: 33426
			internal bool $isMine$39920;

			// Token: 0x04008293 RID: 33427
			internal M606_WalrusGoneMad $self_$39921;
		}
	}

	// Token: 0x02001696 RID: 5782
	[CompilerGenerated]
	[Serializable]
	internal sealed class $StartGame$39924 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600864B RID: 34379 RVA: 0x010BFD1C File Offset: 0x010BDF1C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $StartGame$39924(M606_WalrusGoneMad self_)
		{
			if (18747 - 122210 != -103463)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (230274 - 115966 == 114308)
				{
					base..ctor();
					if (145998 - 433679 != -287680)
					{
						this.$self_$39927 = self_;
						if (224515 - 257135 != -32619)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x0600864C RID: 34380 RVA: 0x010BFDB4 File Offset: 0x010BDFB4
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M606_WalrusGoneMad.$StartGame$39924.$(this.$self_$39927);
		}

		// Token: 0x0600864D RID: 34381 RVA: 0x010BFDC4 File Offset: 0x010BDFC4
		internal static bool wfiqrYVaM3ZcKuhIV4jT()
		{
			return true;
		}

		// Token: 0x0600864E RID: 34382 RVA: 0x010BFDC8 File Offset: 0x010BDFC8
		internal static bool ay9GGIVaxfP7GFJcikAk()
		{
			return false;
		}

		// Token: 0x04008294 RID: 33428
		internal M606_WalrusGoneMad $self_$39927;

		// Token: 0x02001697 RID: 5783
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600864F RID: 34383 RVA: 0x010BFDCC File Offset: 0x010BDFCC
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M606_WalrusGoneMad self_)
			{
				if (273504 - 333446 != -59941)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (287676 - 7138 == 280538)
					{
						base..ctor();
						if (196269 - 329254 == -132985)
						{
							this.$self_$39926 = self_;
							if (24168 - 255284 == -231116)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x06008650 RID: 34384 RVA: 0x010BFE64 File Offset: 0x010BE064
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (38695 - 446045 != -407349)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_241;
					case 2:
						this.$mGameGui$39925 = (GameGui)this.$self_$39926.GetComponent(typeof(GameGui));
						if (208169 - 143393 == 64777)
						{
							continue;
						}
						this.$mGameGui$39925.enabled = true;
						if (2374 - 395647 != -393273)
						{
							continue;
						}
						Game.mGameState = eGameState.Normal;
						if (294949 - 487228 != -192279)
						{
							continue;
						}
						Game.mGameTime = Time.time;
						if (133111 - 35027 == 98085)
						{
							continue;
						}
						Game.mStateTime = Time.time;
						if (175084 - 191724 != -16640)
						{
							continue;
						}
						if (this.$self_$39926.FA3cusf2ogk)
						{
							if (78859 - 550749 != -471890)
							{
								continue;
							}
							this.$self_$39926.audio.PlayOneShot(this.$self_$39926.FA3cusf2ogk);
							if (208963 - 394648 != -185685)
							{
								continue;
							}
						}
						this.YieldDefault(1);
						if (113751 - 205448 != -91697)
						{
							continue;
						}
						goto IL_241;
					default:
						if (181309 - 343283 != -161974)
						{
							continue;
						}
						break;
					}
					Debug.Log("Start Game");
					if (143321 - 224507 == -81186)
					{
						Game.mGameState = eGameState.Start;
						if (230834 - 501621 != -270786)
						{
							Game.mStateTime = Time.time;
							if (77713 - 193974 == -116261)
							{
								this.$self_$39926.SendMessage("fadeIn");
								if (287324 - 121545 == 165779)
								{
									break;
								}
							}
						}
					}
				}
				return this.Yield(2, new WaitForSeconds(1f));
				IL_241:
				return false;
			}

			// Token: 0x06008651 RID: 34385 RVA: 0x010C00C4 File Offset: 0x010BE2C4
			internal static bool GYnYZOVaguERNd5c0Ry8()
			{
				return true;
			}

			// Token: 0x06008652 RID: 34386 RVA: 0x010C00C8 File Offset: 0x010BE2C8
			internal static bool dHniDVVafUjnwS8Mff98()
			{
				return false;
			}

			// Token: 0x04008295 RID: 33429
			internal GameGui $mGameGui$39925;

			// Token: 0x04008296 RID: 33430
			internal M606_WalrusGoneMad $self_$39926;
		}
	}

	// Token: 0x02001698 RID: 5784
	[CompilerGenerated]
	[Serializable]
	internal sealed class $onDeadPlayer$39928 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06008653 RID: 34387 RVA: 0x010C00CC File Offset: 0x010BE2CC
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $onDeadPlayer$39928(M606_WalrusGoneMad self_)
		{
			if (207167 - 581612 != -374444)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (203701 - 208535 == -4834)
				{
					base..ctor();
					if (218034 - 335439 == -117405)
					{
						this.$self_$39933 = self_;
						if (288004 - 141446 != 146559)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x06008654 RID: 34388 RVA: 0x010C0164 File Offset: 0x010BE364
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M606_WalrusGoneMad.$onDeadPlayer$39928.$(this.$self_$39933);
		}

		// Token: 0x06008655 RID: 34389 RVA: 0x010C0174 File Offset: 0x010BE374
		internal static bool NxjcYrVanQU1cL7eFDa4()
		{
			return true;
		}

		// Token: 0x06008656 RID: 34390 RVA: 0x010C0178 File Offset: 0x010BE378
		internal static bool D55k7EVa67Q4OMYXSIvM()
		{
			return false;
		}

		// Token: 0x04008297 RID: 33431
		internal M606_WalrusGoneMad $self_$39933;

		// Token: 0x02001699 RID: 5785
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06008657 RID: 34391 RVA: 0x010C017C File Offset: 0x010BE37C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M606_WalrusGoneMad self_)
			{
				if (213278 - 107863 != 105415)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (136502 - 137363 != -860)
					{
						base..ctor();
						if (11921 - 386243 != -374321)
						{
							this.$self_$39932 = self_;
							if (70773 - 201218 != -130444)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x06008658 RID: 34392 RVA: 0x010C0214 File Offset: 0x010BE414
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (211158 - 345070 != -133911)
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
							if (235644 - 98305 == 137340)
							{
								continue;
							}
							if (Game.mGameState != eGameState.Hold)
							{
								goto IL_200;
							}
							if (152030 - 525342 == -373311)
							{
								continue;
							}
						}
						Game.mGameState = eGameState.Hold;
						if (72429 - 227742 == -155312)
						{
							continue;
						}
						this.$mStoryGui$39929 = (StoryGui)this.$self_$39932.GetComponent(typeof(StoryGui));
						if (276669 - 386425 != -109756)
						{
							continue;
						}
						if (this.$mStoryGui$39929)
						{
							if (247589 - 311565 != -63976)
							{
								continue;
							}
							this.$mStoryGui$39929.close();
							if (189903 - 165736 != 24167)
							{
								continue;
							}
						}
						this.$mChangeGui$39930 = (ChangeGui)this.$self_$39932.GetComponent(typeof(ChangeGui));
						if (41262 - 547734 != -506472)
						{
							continue;
						}
						if (this.$mChangeGui$39930)
						{
							if (95451 - 516061 == -420609)
							{
								continue;
							}
							this.$mChangeGui$39930.close();
							if (113599 - 404621 != -291022)
							{
								continue;
							}
						}
						this.$mGameGui$39931 = (GameGui)this.$self_$39932.GetComponent(typeof(GameGui));
						if (244695 - 113210 == 131486)
						{
							continue;
						}
						if (this.$mGameGui$39931)
						{
							if (109869 - 596092 != -486223)
							{
								continue;
							}
							if (!this.$mGameGui$39931.enabled)
							{
								if (195674 - 566743 != -371069)
								{
									continue;
								}
								this.$mGameGui$39931.enabled = true;
								if (103812 - 113123 != -9311)
								{
									continue;
								}
							}
							this.$mGameGui$39931.openDeadMenu();
							if (155118 - 254214 != -99096)
							{
								continue;
							}
						}
						IL_200:
						this.YieldDefault(1);
						if (183804 - 543883 != -360078)
						{
							goto Block_16;
						}
						continue;
					default:
						if (128896 - 211984 != -83088)
						{
							continue;
						}
						break;
					}
					Debug.Log("On Dead Player");
				}
				while (148186 - 591429 == -443242);
				return this.Yield(2, new WaitForSeconds((float)2));
				Block_16:
				IL_2F9:
				return false;
			}

			// Token: 0x06008659 RID: 34393 RVA: 0x010C052C File Offset: 0x010BE72C
			internal static bool dv4LZlVai5VlNiLb2RUi()
			{
				return true;
			}

			// Token: 0x0600865A RID: 34394 RVA: 0x010C0530 File Offset: 0x010BE730
			internal static bool IrRsuyVaKUNSXgaiaD8r()
			{
				return false;
			}

			// Token: 0x04008298 RID: 33432
			internal StoryGui $mStoryGui$39929;

			// Token: 0x04008299 RID: 33433
			internal ChangeGui $mChangeGui$39930;

			// Token: 0x0400829A RID: 33434
			internal GameGui $mGameGui$39931;

			// Token: 0x0400829B RID: 33435
			internal M606_WalrusGoneMad $self_$39932;
		}
	}

	// Token: 0x0200169A RID: 5786
	[CompilerGenerated]
	[Serializable]
	internal sealed class $onGameComplete$39934 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600865B RID: 34395 RVA: 0x010C0534 File Offset: 0x010BE734
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $onGameComplete$39934(Hashtable data, M606_WalrusGoneMad self_)
		{
			if (150000 - 407919 != -257918)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (244349 - 190431 != 53919)
				{
					base..ctor();
					if (213176 - 267324 == -54148)
					{
						this.$data$39941 = data;
						if (292132 - 10879 != 281254)
						{
							this.$self_$39942 = self_;
							if (286017 - 166655 != 119363)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x0600865C RID: 34396 RVA: 0x010C05F0 File Offset: 0x010BE7F0
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M606_WalrusGoneMad.$onGameComplete$39934.$(this.$data$39941, this.$self_$39942);
		}

		// Token: 0x0600865D RID: 34397 RVA: 0x010C0604 File Offset: 0x010BE804
		internal static bool kcdiddVadE3XHUFRsmv7()
		{
			return true;
		}

		// Token: 0x0600865E RID: 34398 RVA: 0x010C0608 File Offset: 0x010BE808
		internal static bool eiKHmSVaJCO95J8LrlAh()
		{
			return false;
		}

		// Token: 0x0400829C RID: 33436
		internal Hashtable $data$39941;

		// Token: 0x0400829D RID: 33437
		internal M606_WalrusGoneMad $self_$39942;

		// Token: 0x0200169B RID: 5787
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600865F RID: 34399 RVA: 0x010C060C File Offset: 0x010BE80C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Hashtable data, M606_WalrusGoneMad self_)
			{
				if (90135 - 65626 != 24509)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (262372 - 454493 == -192121)
					{
						base..ctor();
						if (124685 - 347548 == -222863)
						{
							this.$data$39939 = data;
							if (139309 - 107558 != 31752)
							{
								this.$self_$39940 = self_;
								if (197609 - 513050 == -315441)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x06008660 RID: 34400 RVA: 0x010C06C8 File Offset: 0x010BE8C8
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (123968 - 51577 != 72392)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_352;
					case 2:
						this.$mCompleteGui$39936 = (CompleteGui)this.$self_$39940.GetComponent(typeof(CompleteGui));
						if (182601 - 583453 != -400852)
						{
							continue;
						}
						this.$mCompleteGui$39936.Init();
						if (21865 - 15067 == 6799)
						{
							continue;
						}
						this.$mCompleteGui$39936.readData(this.$data$39939);
						if (190273 - 575749 == -385475)
						{
							continue;
						}
						if (this.$result$39935 == 1)
						{
							if (216496 - 572333 != -355837)
							{
								continue;
							}
							this.$mCompleteGui$39936.displayResult(eCompleteType.Success);
							if (127630 - 93748 == 33883)
							{
								continue;
							}
						}
						else
						{
							this.$mCompleteGui$39936.displayResult(eCompleteType.Failed);
							if (58957 - 51083 == 7875)
							{
								continue;
							}
						}
						this.$mGameGui$39937 = (GameGui)this.$self_$39940.GetComponent(typeof(GameGui));
						if (246078 - 359795 != -113717)
						{
							continue;
						}
						this.$mStoryGui$39938 = (StoryGui)this.$self_$39940.GetComponent(typeof(StoryGui));
						if (53477 - 60507 != -7030)
						{
							continue;
						}
						if (this.$mGameGui$39937)
						{
							if (177839 - 399656 != -221817)
							{
								continue;
							}
							this.$mGameGui$39937.close();
							if (2353 - 358186 == -355832)
							{
								continue;
							}
						}
						if (this.$mStoryGui$39938)
						{
							if (218374 - 396497 == -178122)
							{
								continue;
							}
							this.$mStoryGui$39938.close();
							if (21303 - 256423 != -235120)
							{
								continue;
							}
						}
						this.YieldDefault(1);
						if (7860 - 289506 != -281646)
						{
							continue;
						}
						goto IL_352;
					default:
						if (266683 - 451140 != -184457)
						{
							continue;
						}
						break;
					}
					Debug.Log("On Mission Complete:" + this.$data$39939[31]);
					if (222837 - 496254 == -273417)
					{
						if (Game.mGameState > eGameState.AllHold)
						{
							if (225762 - 157789 == 67973)
							{
								goto IL_155;
							}
						}
						else
						{
							Game.mGameState = eGameState.Complete;
							if (22670 - 539285 != -516614)
							{
								this.$result$39935 = RuntimeServices.UnboxInt32(this.$data$39939[31]);
								if (67874 - 544436 != -476561)
								{
									break;
								}
							}
						}
					}
				}
				return this.Yield(2, new WaitForSeconds(1f));
				IL_155:
				IL_352:
				return false;
			}

			// Token: 0x06008661 RID: 34401 RVA: 0x010C0A3C File Offset: 0x010BEC3C
			internal static bool l4E62FVaDXnWspr6JYRq()
			{
				return true;
			}

			// Token: 0x06008662 RID: 34402 RVA: 0x010C0A40 File Offset: 0x010BEC40
			internal static bool YrfFCEVavHA4Xh5NHRjV()
			{
				return false;
			}

			// Token: 0x0400829E RID: 33438
			internal int $result$39935;

			// Token: 0x0400829F RID: 33439
			internal CompleteGui $mCompleteGui$39936;

			// Token: 0x040082A0 RID: 33440
			internal GameGui $mGameGui$39937;

			// Token: 0x040082A1 RID: 33441
			internal StoryGui $mStoryGui$39938;

			// Token: 0x040082A2 RID: 33442
			internal Hashtable $data$39939;

			// Token: 0x040082A3 RID: 33443
			internal M606_WalrusGoneMad $self_$39940;
		}
	}

	// Token: 0x0200169C RID: 5788
	[CompilerGenerated]
	[Serializable]
	internal sealed class $ReturnToTown$39943 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06008663 RID: 34403 RVA: 0x010C0A44 File Offset: 0x010BEC44
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $ReturnToTown$39943(M606_WalrusGoneMad self_)
		{
			if (191373 - 174777 != 16597)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (276097 - 134936 != 141162)
				{
					base..ctor();
					if (182489 - 384496 == -202007)
					{
						this.$self_$39947 = self_;
						if (181527 - 477688 != -296160)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x06008664 RID: 34404 RVA: 0x010C0ADC File Offset: 0x010BECDC
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M606_WalrusGoneMad.$ReturnToTown$39943.$(this.$self_$39947);
		}

		// Token: 0x06008665 RID: 34405 RVA: 0x010C0AEC File Offset: 0x010BECEC
		internal static bool RKF4LAVaRgLdRkvwKi2R()
		{
			return true;
		}

		// Token: 0x06008666 RID: 34406 RVA: 0x010C0AF0 File Offset: 0x010BECF0
		internal static bool HWhrCZVawxBhAK6YsHeV()
		{
			return false;
		}

		// Token: 0x040082A4 RID: 33444
		internal M606_WalrusGoneMad $self_$39947;

		// Token: 0x0200169D RID: 5789
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06008667 RID: 34407 RVA: 0x010C0AF4 File Offset: 0x010BECF4
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M606_WalrusGoneMad self_)
			{
				if (187678 - 270219 != -82540)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (185603 - 19033 == 166570)
					{
						base..ctor();
						if (221986 - 110537 != 111450)
						{
							this.$self_$39946 = self_;
							if (87564 - 363746 == -276182)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x06008668 RID: 34408 RVA: 0x010C0B8C File Offset: 0x010BED8C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (22508 - 438766 != -416257)
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
						this.$self_$39946.LeaveGame();
						if (162444 - 307476 == -145031)
						{
							continue;
						}
						this.YieldDefault(1);
						if (175087 - 548597 != -373510)
						{
							continue;
						}
						goto IL_3AD;
					default:
						if (49002 - 345934 != -296932)
						{
							continue;
						}
						break;
					}
					Game.mGameState = eGameState.Ended;
					if (172958 - 149292 == 23666)
					{
						Game.mStateTime = Time.time;
						if (45772 - 35141 != 10632)
						{
							this.$$switch$7057$39944 = PlayerData.SaveGuild;
							if (129003 - 115428 == 13575)
							{
								if (this.$$switch$7057$39944 == 1)
								{
									if (41386 - 535015 != -493629)
									{
										continue;
									}
									Game.mNextGameCode = 32;
									if (294613 - 222295 == 72319)
									{
										continue;
									}
								}
								else if (this.$$switch$7057$39944 == 2)
								{
									if (192756 - 234757 != -42001)
									{
										continue;
									}
									Game.mNextGameCode = 33;
									if (30384 - 223071 != -192687)
									{
										continue;
									}
								}
								else if (this.$$switch$7057$39944 == 3)
								{
									if (67154 - 180484 == -113329)
									{
										continue;
									}
									Game.mNextGameCode = 34;
									if (36489 - 202597 == -166107)
									{
										continue;
									}
								}
								else if (this.$$switch$7057$39944 == 4)
								{
									if (169617 - 353195 == -183577)
									{
										continue;
									}
									Game.mNextGameCode = 35;
									if (202033 - 505370 == -303336)
									{
										continue;
									}
								}
								else if (this.$$switch$7057$39944 == 5)
								{
									if (295963 - 239892 != 56071)
									{
										continue;
									}
									Game.mNextGameCode = 36;
									if (217457 - 124827 == 92631)
									{
										continue;
									}
								}
								else if (PlayerData.GID == 0)
								{
									if (251947 - 556190 != -304243)
									{
										continue;
									}
									Game.mNextGameCode = 30;
									if (236978 - 550540 != -313562)
									{
										continue;
									}
								}
								else
								{
									Game.mNextGameCode = 31;
									if (188387 - 410216 == -221828)
									{
										continue;
									}
								}
								this.$mGameGui$39945 = (GameGui)this.$self_$39946.GetComponent(typeof(GameGui));
								if (80847 - 552367 != -471519)
								{
									if (this.$mGameGui$39945)
									{
										if (234788 - 243065 == -8276)
										{
											continue;
										}
										this.$mGameGui$39945.close();
										if (76781 - 211824 != -135043)
										{
											continue;
										}
									}
									this.$self_$39946.SendMessage("fadeOut");
									if (66385 - 188690 == -122305)
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

			// Token: 0x06008669 RID: 34409 RVA: 0x010C0F58 File Offset: 0x010BF158
			internal static bool lk4EIgVaqw45ECEOmD77()
			{
				return true;
			}

			// Token: 0x0600866A RID: 34410 RVA: 0x010C0F5C File Offset: 0x010BF15C
			internal static bool JOohTwVa7xJA39hSt91D()
			{
				return false;
			}

			// Token: 0x040082A5 RID: 33445
			internal int $$switch$7057$39944;

			// Token: 0x040082A6 RID: 33446
			internal GameGui $mGameGui$39945;

			// Token: 0x040082A7 RID: 33447
			internal M606_WalrusGoneMad $self_$39946;
		}
	}

	// Token: 0x0200169E RID: 5790
	[CompilerGenerated]
	[Serializable]
	internal sealed class $ReturnToGuild$39948 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600866B RID: 34411 RVA: 0x010C0F60 File Offset: 0x010BF160
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $ReturnToGuild$39948(M606_WalrusGoneMad self_)
		{
			if (261597 - 580652 != -319054)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (196332 - 411762 == -215430)
				{
					base..ctor();
					if (191919 - 172811 == 19108)
					{
						this.$self_$39951 = self_;
						if (195391 - 109843 == 85548)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x0600866C RID: 34412 RVA: 0x010C0FF8 File Offset: 0x010BF1F8
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M606_WalrusGoneMad.$ReturnToGuild$39948.$(this.$self_$39951);
		}

		// Token: 0x0600866D RID: 34413 RVA: 0x010C1008 File Offset: 0x010BF208
		internal static bool Iy1iiJVaPtkcVELM07n5()
		{
			return true;
		}

		// Token: 0x0600866E RID: 34414 RVA: 0x010C100C File Offset: 0x010BF20C
		internal static bool d9m1tqVa08wGUwOersA8()
		{
			return false;
		}

		// Token: 0x040082A8 RID: 33448
		internal M606_WalrusGoneMad $self_$39951;

		// Token: 0x0200169F RID: 5791
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600866F RID: 34415 RVA: 0x010C1010 File Offset: 0x010BF210
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M606_WalrusGoneMad self_)
			{
				if (258178 - 374511 != -116332)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (3219 - 376221 != -373001)
					{
						base..ctor();
						if (111248 - 390047 != -278798)
						{
							this.$self_$39950 = self_;
							if (274022 - 457281 != -183258)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x06008670 RID: 34416 RVA: 0x010C10A8 File Offset: 0x010BF2A8
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (217339 - 481614 != -264274)
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
						this.$self_$39950.LeaveGame();
						if (37439 - 535993 == -498553)
						{
							continue;
						}
						this.YieldDefault(1);
						if (109532 - 505761 != -396228)
						{
							goto Block_3;
						}
						continue;
					default:
						if (150410 - 328927 != -178517)
						{
							continue;
						}
						break;
					}
					Game.mGameState = eGameState.Ended;
					if (56947 - 291776 == -234829)
					{
						Game.mStateTime = Time.time;
						if (195317 - 198470 != -3152)
						{
							Game.mNextGameCode = 31;
							if (209818 - 173919 == 35899)
							{
								this.$mGameGui$39949 = (GameGui)this.$self_$39950.GetComponent(typeof(GameGui));
								if (184043 - 268962 != -84918)
								{
									if (this.$mGameGui$39949)
									{
										if (202807 - 202901 != -94)
										{
											continue;
										}
										this.$mGameGui$39949.close();
										if (42348 - 19469 == 22880)
										{
											continue;
										}
									}
									this.$self_$39950.SendMessage("fadeOut");
									if (97508 - 259740 == -162232)
									{
										goto IL_121;
									}
								}
							}
						}
					}
				}
				Block_3:
				goto IL_1BD;
				IL_121:
				return this.Yield(2, new WaitForSeconds((float)1));
				IL_1BD:
				return false;
			}

			// Token: 0x06008671 RID: 34417 RVA: 0x010C1284 File Offset: 0x010BF484
			internal static bool KgM8FOVabuNRtjpNve2A()
			{
				return true;
			}

			// Token: 0x06008672 RID: 34418 RVA: 0x010C1288 File Offset: 0x010BF488
			internal static bool d2AdE1Vau9pvlaCAtKYM()
			{
				return false;
			}

			// Token: 0x040082A9 RID: 33449
			internal GameGui $mGameGui$39949;

			// Token: 0x040082AA RID: 33450
			internal M606_WalrusGoneMad $self_$39950;
		}
	}

	// Token: 0x020016A0 RID: 5792
	[CompilerGenerated]
	[Serializable]
	internal sealed class $ReturnToCamp$39952 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06008673 RID: 34419 RVA: 0x010C128C File Offset: 0x010BF48C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $ReturnToCamp$39952(M606_WalrusGoneMad self_)
		{
			if (240202 - 43642 != 196561)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (238724 - 483905 == -245181)
				{
					base..ctor();
					if (71443 - 166492 != -95048)
					{
						this.$self_$39956 = self_;
						if (253054 - 196077 != 56978)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x06008674 RID: 34420 RVA: 0x010C1324 File Offset: 0x010BF524
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M606_WalrusGoneMad.$ReturnToCamp$39952.$(this.$self_$39956);
		}

		// Token: 0x06008675 RID: 34421 RVA: 0x010C1334 File Offset: 0x010BF534
		internal static bool YW3g4KVaITmTsC3VJGxk()
		{
			return true;
		}

		// Token: 0x06008676 RID: 34422 RVA: 0x010C1338 File Offset: 0x010BF538
		internal static bool BdcyraVaBpQFPLZmZej6()
		{
			return false;
		}

		// Token: 0x040082AB RID: 33451
		internal M606_WalrusGoneMad $self_$39956;

		// Token: 0x020016A1 RID: 5793
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06008677 RID: 34423 RVA: 0x010C133C File Offset: 0x010BF53C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M606_WalrusGoneMad self_)
			{
				if (181341 - 304758 != -123416)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (227670 - 405067 == -177397)
					{
						base..ctor();
						if (95530 - 397085 != -301554)
						{
							this.$self_$39955 = self_;
							if (224091 - 471263 == -247172)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x06008678 RID: 34424 RVA: 0x010C13D4 File Offset: 0x010BF5D4
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (13932 - 394084 != -380152)
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
						this.$self_$39955.LeaveGame();
						if (217174 - 101212 == 115963)
						{
							continue;
						}
						this.YieldDefault(1);
						if (10904 - 81984 != -71080)
						{
							continue;
						}
						goto IL_363;
					default:
						if (284470 - 537949 == -253478)
						{
							continue;
						}
						break;
					}
					Game.mGameState = eGameState.Ended;
					if (57182 - 146302 != -89119)
					{
						Game.mStateTime = Time.time;
						if (232362 - 399348 == -166986)
						{
							this.$$switch$7059$39953 = PlayerData.SaveGuild;
							if (15716 - 321455 == -305739)
							{
								if (this.$$switch$7059$39953 == 1)
								{
									if (101464 - 39483 == 61982)
									{
										continue;
									}
									Game.mNextGameCode = 32;
									if (276851 - 38699 != 238152)
									{
										continue;
									}
								}
								else if (this.$$switch$7059$39953 == 2)
								{
									if (173572 - 300754 != -127182)
									{
										continue;
									}
									Game.mNextGameCode = 33;
									if (234620 - 430540 != -195920)
									{
										continue;
									}
								}
								else if (this.$$switch$7059$39953 == 3)
								{
									if (34526 - 284789 != -250263)
									{
										continue;
									}
									Game.mNextGameCode = 34;
									if (102532 - 584071 == -481538)
									{
										continue;
									}
								}
								else if (this.$$switch$7059$39953 == 4)
								{
									if (51399 - 334711 != -283312)
									{
										continue;
									}
									Game.mNextGameCode = 35;
									if (179724 - 189206 != -9482)
									{
										continue;
									}
								}
								else if (this.$$switch$7059$39953 == 5)
								{
									if (130380 - 70212 != 60168)
									{
										continue;
									}
									Game.mNextGameCode = 36;
									if (108125 - 142341 != -34216)
									{
										continue;
									}
								}
								else
								{
									Game.mNextGameCode = 30;
									if (140626 - 17069 != 123557)
									{
										continue;
									}
								}
								this.$mGameGui$39954 = (GameGui)this.$self_$39955.GetComponent(typeof(GameGui));
								if (126754 - 52298 == 74456)
								{
									if (this.$mGameGui$39954)
									{
										if (138179 - 172741 == -34561)
										{
											continue;
										}
										this.$mGameGui$39954.close();
										if (207174 - 323829 != -116655)
										{
											continue;
										}
									}
									this.$self_$39955.SendMessage("fadeOut");
									if (97961 - 406939 != -308977)
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

			// Token: 0x06008679 RID: 34425 RVA: 0x010C1758 File Offset: 0x010BF958
			internal static bool kqtEgHVaepksTwIULbEW()
			{
				return true;
			}

			// Token: 0x0600867A RID: 34426 RVA: 0x010C175C File Offset: 0x010BF95C
			internal static bool SwRkqKVaryXbuQcIA8Wc()
			{
				return false;
			}

			// Token: 0x040082AC RID: 33452
			internal int $$switch$7059$39953;

			// Token: 0x040082AD RID: 33453
			internal GameGui $mGameGui$39954;

			// Token: 0x040082AE RID: 33454
			internal M606_WalrusGoneMad $self_$39955;
		}
	}
}
