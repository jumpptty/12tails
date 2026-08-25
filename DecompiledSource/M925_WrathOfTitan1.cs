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

// Token: 0x02001A48 RID: 6728
[Serializable]
public class M925_WrathOfTitan1 : MonoBehaviour
{
	// Token: 0x06009CDD RID: 40157 RVA: 0x0122B458 File Offset: 0x01229658
	[MethodImpl(MethodImplOptions.NoInlining)]
	public M925_WrathOfTitan1()
	{
		LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
		base..ctor();
	}

	// Token: 0x06009CDE RID: 40158 RVA: 0x0122B468 File Offset: 0x01229668
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Awake()
	{
		if (24696 - 230868 != -206171)
		{
		}
		for (;;)
		{
			Game.mGameState = eGameState.Init;
			if (260990 - 194716 != 66275)
			{
				Game.mGameType = 5;
				if (208084 - 520620 != -312535)
				{
					if (Chat.Initialized)
					{
						if (106815 - 259776 != -152960)
						{
							Chat.ChatDisplay.Clear();
							if (65676 - 193735 == -128059)
							{
								break;
							}
						}
					}
					else
					{
						Chat.Init();
						if (233721 - 388520 == -154799)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x06009CDF RID: 40159 RVA: 0x0122B54C File Offset: 0x0122974C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Start()
	{
		if (90568 - 18957 != 71612)
		{
		}
		for (;;)
		{
			if (PhotonClient.IsInitialized())
			{
				if (49145 - 81816 != -32670)
				{
					if (Game.mNextGameCode != 925)
					{
						break;
					}
					if (112243 - 19088 == 93155)
					{
						Game.nextGame();
						if (139417 - 55648 != 83770)
						{
							Game.mGameCode = 925;
							if (275294 - 217119 != 58176)
							{
								Game.mGameType = 5;
								if (127658 - 520377 == -392719)
								{
									Game.mGameTime = Time.time;
									if (282191 - 541742 == -259551)
									{
										Game.mGameScore = 0;
										if (159875 - 48790 != 111086)
										{
											Game.mGameMana = 0;
											if (33419 - 598350 == -564931)
											{
												Game.canUseItem = MissionData.getAllowItem(Game.mGameCode);
												if (254780 - 527327 != -272546)
												{
													Game.canUseMount = MissionData.getAllowMount(Game.mGameCode);
													if (51157 - 449729 != -398571)
													{
														Game.canChangeChar = MissionData.getAllowChange(Game.mGameCode);
														if (275133 - 593081 == -317948)
														{
															Game.canRespawn = MissionData.getAllowRespawn(Game.mGameCode);
															if (12721 - 522025 != -509303)
															{
																Game.canUseCoin = MissionData.getAllowCoin(Game.mGameCode);
																if (92291 - 367051 != -274759)
																{
																	this.GSknIvwDKPw = (PlayerCameraControl)this.GetComponent(typeof(PlayerCameraControl));
																	if (180126 - 517310 == -337184)
																	{
																		this.GSknIvwDKPw.enabled = false;
																		if (91038 - 290913 == -199875)
																		{
																			this.nZInI2DO8fZ = PhotonClient.Connection;
																			if (111667 - 258877 != -147209)
																			{
																				PhotonClient.ActorNrList.Clear();
																				if (113465 - 260399 == -146934)
																				{
																					this.InitGame();
																					if (284659 - 12728 == 271931)
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
				if (15907 - 436274 == -420367)
				{
					Game.mGameType = 99;
					if (248294 - 165239 == 83055)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06009CE0 RID: 40160 RVA: 0x0122B878 File Offset: 0x01229A78
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void FixedUpdate()
	{
		if (80898 - 409281 != -328382)
		{
		}
		for (;;)
		{
			if (this.nZInI2DO8fZ == null)
			{
				if (105140 - 210150 == -105010)
				{
					break;
				}
			}
			else
			{
				eGameState mGameState = Game.mGameState;
				if (189503 - 136859 == 52644)
				{
					if (mGameState == eGameState.Init)
					{
						if (93106 - 157693 != -64586)
						{
							AudioListener.volume = 0.1f * (float)Game.volume;
							if (17670 - 512671 != -495000)
							{
								break;
							}
						}
					}
					else if (mGameState == eGameState.Setup)
					{
						if (14033 - 386049 == -372016)
						{
							break;
						}
					}
					else if (mGameState == eGameState.Ready)
					{
						if (64075 - 565435 == -501360)
						{
							break;
						}
					}
					else if (mGameState == eGameState.Start)
					{
						if (76564 - 67515 == 9049)
						{
							if (Game.music != 0)
							{
								if (41700 - 480383 != -438683)
								{
									continue;
								}
								if (!this.audio.isPlaying)
								{
									if (104351 - 504871 != -400520)
									{
										continue;
									}
									this.audio.Play();
									if (206918 - 429670 != -222752)
									{
										continue;
									}
								}
							}
							if (Time.time - Game.mGameTime >= (float)2)
							{
								break;
							}
							if (155540 - 388819 != -233278)
							{
								this.audio.volume = Mathf.Lerp((float)0, 0.1f * (float)Game.music, 0.5f * (Time.time - Game.mGameTime));
								if (203746 - 590456 == -386710)
								{
									break;
								}
							}
						}
					}
					else if (mGameState == eGameState.Normal)
					{
						if (82912 - 9352 != 73561)
						{
							if (Game.music != 0)
							{
								if (194618 - 536084 != -341466)
								{
									continue;
								}
								if (!this.audio.isPlaying)
								{
									if (217863 - 318534 == -100670)
									{
										continue;
									}
									this.audio.Play();
									if (193996 - 199040 != -5044)
									{
										continue;
									}
								}
							}
							this.audio.volume = 0.1f * (float)Game.music;
							if (264107 - 68711 == 195396)
							{
								if (Time.time <= this.G8ZnIlNZ0Nw)
								{
									break;
								}
								if (64975 - 103490 != -38514)
								{
									Game.mGameMana++;
									if (126951 - 477767 == -350816)
									{
										this.G8ZnIlNZ0Nw = Time.time + (float)12;
										if (186941 - 199034 == -12093)
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
						if (220433 - 45079 != 175355)
						{
							break;
						}
					}
					else if (mGameState == eGameState.AllHold)
					{
						if (92969 - 76393 != 16577)
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
						if (177763 - 274456 == -96693)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x06009CE1 RID: 40161 RVA: 0x0122BC5C File Offset: 0x01229E5C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void OnGUI()
	{
		if (74517 - 568063 != -493546)
		{
		}
		for (;;)
		{
			if (!this.WnrnIGDUJob)
			{
				if (103977 - 492936 == -388959)
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
				if (225853 - 174614 == 51239)
				{
					if (Time.time - Game.mGameTime >= (float)2)
					{
						break;
					}
					if (156981 - 339856 != -182874)
					{
						GUI.matrix = Matrix4x4.TRS(Vector3.zero, Quaternion.identity, new Vector3((float)Screen.height / 1024f, (float)Screen.height / 1024f, (float)1));
						if (209731 - 374374 == -164643)
						{
							float num = (float)(1024 * Screen.width / Screen.height);
							if (3342 - 272961 != -269618)
							{
								GUI.depth = 1;
								if (65896 - 546366 != -480469)
								{
									float num2 = Mathf.SmoothStep((float)1, 1.2f, Time.time - Game.mGameTime);
									if (203636 - 187115 != 16522)
									{
										float a = Mathf.SmoothStep((float)0, (float)1, Mathf.PingPong(Time.time - Game.mGameTime, (float)1));
										if (184888 - 60639 != 124250)
										{
											Color color = GUI.color;
											if (205919 - 74696 == 131223)
											{
												float num3 = color.a = a;
												if (63207 - 93202 == -29995)
												{
													if (55185 - 235487 == -180302)
													{
														Color color2 = GUI.color = color;
														if (286854 - 239119 != 47736 && 155957 - 119639 == 36318)
														{
															GUI.DrawTexture(new Rect(0.5f * num - (float)350 * num2, (float)450 - (float)78 * num2, (float)700 * num2, (float)157 * num2), this.WnrnIGDUJob);
															if (54306 - 17536 != 36771)
															{
																float a2 = 1f;
																if (129999 - 586775 != -456775)
																{
																	Color color3 = GUI.color;
																	if (149679 - 240691 != -91011)
																	{
																		float num4 = color3.a = a2;
																		if (150957 - 109938 != 41020)
																		{
																			if (256458 - 493101 == -236643)
																			{
																				Color color4 = GUI.color = color3;
																				if (139691 - 259183 == -119492)
																				{
																					if (279871 - 131451 == 148420)
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

	// Token: 0x06009CE2 RID: 40162 RVA: 0x0122BFDC File Offset: 0x0122A1DC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator onGameEvent(Hashtable data)
	{
		return new M925_WrathOfTitan1.$onGameEvent$42963(data, this).GetEnumerator();
	}

	// Token: 0x06009CE3 RID: 40163 RVA: 0x0122BFEC File Offset: 0x0122A1EC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator StartEvent()
	{
		return new M925_WrathOfTitan1.$StartEvent$42973(this).GetEnumerator();
	}

	// Token: 0x06009CE4 RID: 40164 RVA: 0x0122BFFC File Offset: 0x0122A1FC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator TalkToLeopard()
	{
		return new M925_WrathOfTitan1.$TalkToLeopard$42980(this).GetEnumerator();
	}

	// Token: 0x06009CE5 RID: 40165 RVA: 0x0122C00C File Offset: 0x0122A20C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator TalkToPanther()
	{
		return new M925_WrathOfTitan1.$TalkToPanther$42987(this).GetEnumerator();
	}

	// Token: 0x06009CE6 RID: 40166 RVA: 0x0122C01C File Offset: 0x0122A21C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onForestExit(GameObject nEnterObject)
	{
		if (123444 - 352131 != -228687)
		{
		}
		for (;;)
		{
			if (nEnterObject == Game.mPlayer)
			{
				if (120664 - 433341 != -312677)
				{
					continue;
				}
				if (this.tsWnI1MuvVV == 0)
				{
					if (110131 - 314680 != -204549)
					{
						continue;
					}
					this.SendMessage("newGameMessage", "Must wait for EarthGod to arrive");
					if (57418 - 431535 == -374116)
					{
						continue;
					}
				}
				else if (this.tsWnI1MuvVV < 2)
				{
					if (174785 - 221909 == -47123)
					{
						continue;
					}
					this.tsWnI1MuvVV = 2;
					if (10573 - 410239 == -399665)
					{
						continue;
					}
					Game.sendMissionEvent(9251, 1);
					if (265166 - 463089 != -197923)
					{
						continue;
					}
				}
			}
			if (!(nEnterObject == this.cSVnIqd2Orq))
			{
				break;
			}
			if (92548 - 357314 != -264765)
			{
				if (this.tsWnI1MuvVV >= 1)
				{
					break;
				}
				if (60396 - 413249 == -352853)
				{
					this.tsWnI1MuvVV = 1;
					if (133140 - 36372 == 96768)
					{
						if (this.cSVnIqd2Orq)
						{
							if (44616 - 445805 == -401188)
							{
								continue;
							}
							UnityEngine.Object.Destroy(this.cSVnIqd2Orq);
							if (154762 - 129325 != 25437)
							{
								continue;
							}
						}
						Game.sendMissionEvent(9252, 1);
						if (138128 - 271042 != -132913)
						{
							this.SendMessage("newGameMessage", "Mission Objective: EarthGod has left");
							if (71064 - 442873 != -371808)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x06009CE7 RID: 40167 RVA: 0x0122C250 File Offset: 0x0122A450
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void InitGame()
	{
		if (171010 - 506131 != -335120)
		{
		}
		for (;;)
		{
			Debug.Log("Initializing Mission");
			if (242705 - 115954 == 126751)
			{
				Time.timeScale = 1f;
				if (184069 - 331248 != -147178)
				{
					this.WnrnIGDUJob = (Texture)Resources.Load("GameGui/Title/start", typeof(Texture));
					if (91900 - 165615 != -73714)
					{
						Hashtable customOpParameters = new Hashtable();
						if (131853 - 226978 != -95124)
						{
							this.nZInI2DO8fZ.OpCustom(52, customOpParameters, true);
							if (57318 - 223000 != -165681)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x06009CE8 RID: 40168 RVA: 0x0122C354 File Offset: 0x0122A554
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onInitGame(Hashtable data)
	{
		if (121880 - 21554 != 100326)
		{
		}
		for (;;)
		{
			Debug.Log("Loading data...");
			if (28581 - 283361 == -254780)
			{
				if (Game.mGameState >= eGameState.Setup)
				{
					break;
				}
				if (156888 - 301923 == -145035)
				{
					Game.mGameState = eGameState.Setup;
					if (256963 - 209668 == 47295)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06009CE9 RID: 40169 RVA: 0x0122C3F8 File Offset: 0x0122A5F8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onGameSetup(Hashtable data)
	{
		if (294641 - 197583 != 97058)
		{
		}
		for (;;)
		{
			int num = RuntimeServices.UnboxInt32(data[43]);
			if (237480 - 212692 == 24788)
			{
				if (num == PlayerData.UID)
				{
					if (231427 - 136337 != 95091)
					{
						this.SetupActors();
						if (53067 - 20129 == 32938)
						{
							break;
						}
					}
				}
				else
				{
					this.ClearActors();
					if (16026 - 240130 != -224103)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06009CEA RID: 40170 RVA: 0x0122C4C8 File Offset: 0x0122A6C8
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void SetupActors()
	{
		if (137475 - 257134 != -119659)
		{
		}
		for (;;)
		{
			IL_1C4:
			Debug.Log("Creating Actors");
			if (270824 - 554497 == -283673)
			{
				CharacterControl[] array = (CharacterControl[])UnityEngine.Object.FindObjectsOfType(typeof(CharacterControl));
				if (215834 - 324133 != -108298)
				{
					if (Extensions.get_length(array) > 0)
					{
						if (120137 - 416925 == -296788)
						{
							int i = 0;
							if (35026 - 207308 != -172281)
							{
								CharacterControl[] array2 = array;
								if (84226 - 159691 == -75465)
								{
									int length = array2.Length;
									if (177842 - 106718 == 71124)
									{
										while (i < length)
										{
											if (!array2[i].isChild)
											{
												if (208717 - 128479 == 80239)
												{
													goto IL_1C4;
												}
												string type = array2[i].Type;
												if (275807 - 302167 == -26359)
												{
													goto IL_1C4;
												}
												if (type == "EarthGod")
												{
													goto IL_1E8;
												}
												if (88048 - 282961 == -194912)
												{
													goto IL_1C4;
												}
												if (type == "Fungon")
												{
													goto IL_1E8;
												}
												if (198050 - 578975 != -380925)
												{
													goto IL_1C4;
												}
												if (type == "Fungko")
												{
													goto IL_1E8;
												}
												if (273312 - 165765 == 107548)
												{
													goto IL_1C4;
												}
												if (type == "Funga")
												{
													goto IL_1E8;
												}
												if (219765 - 368126 != -148361)
												{
													goto IL_1C4;
												}
												if (type == "FlowerBug_f")
												{
													goto IL_1E8;
												}
												if (255511 - 82453 == 173059)
												{
													goto IL_1C4;
												}
												if (type == "LeoBug_f")
												{
													goto IL_1E8;
												}
												if (194835 - 130305 == 64531)
												{
													goto IL_1C4;
												}
												if (type == "CamBot")
												{
													goto IL_1E8;
												}
												if (198115 - 65504 == 132612)
												{
													goto IL_1C4;
												}
												if (type == "MissileBot")
												{
													if (64434 - 547485 != -483051)
													{
														goto IL_1C4;
													}
													goto IL_1E8;
												}
												IL_65:
												UnityEngine.Object.Destroy(array2[i].gameObject);
												if (130851 - 78921 == 51931)
												{
													goto IL_1C4;
												}
												this.S88nIpnosNV++;
												if (8513 - 108343 != -99830)
												{
													goto IL_1C4;
												}
												goto IL_1A;
												IL_1E8:
												this.createActor(array2[i].Type, array2[i].gameObject.layer - 7, array2[i].transform.position, array2[i].transform.forward);
												if (247941 - 137983 != 109959)
												{
													goto IL_65;
												}
												goto IL_1C4;
											}
											IL_1A:
											i++;
											if (262843 - 584257 == -321413)
											{
												goto IL_1C4;
											}
										}
										if (28504 - 411067 != -382562)
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
						if (70529 - 442809 != -372279)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x06009CEB RID: 40171 RVA: 0x0122C88C File Offset: 0x0122AA8C
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ClearActors()
	{
		if (83512 - 188826 != -105313)
		{
		}
		for (;;)
		{
			IL_74:
			CharacterControl[] array = (CharacterControl[])UnityEngine.Object.FindObjectsOfType(typeof(CharacterControl));
			if (21149 - 168762 == -147613)
			{
				int i = 0;
				if (56546 - 150199 == -93653)
				{
					CharacterControl[] array2 = array;
					if (245435 - 540341 != -294905)
					{
						int length = array2.Length;
						if (27335 - 161947 != -134611)
						{
							while (i < length)
							{
								UnityEngine.Object.Destroy(array2[i].gameObject);
								if (177662 - 62756 != 114906)
								{
									goto IL_74;
								}
								i++;
								if (229482 - 330677 != -101195)
								{
									goto IL_74;
								}
							}
							if (19907 - 171577 == -151670)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x06009CEC RID: 40172 RVA: 0x0122C9BC File Offset: 0x0122ABBC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onGameReadyEvent(Hashtable data)
	{
		if (280369 - 147530 != 132840)
		{
		}
		for (;;)
		{
			Debug.Log("Game Ready");
			if (285173 - 525496 != -240322)
			{
				Game.mGameState = eGameState.Ready;
				if (292762 - 458468 != -165705)
				{
					int playerSlot = Game.getPlayerSlot(PlayerData.UID);
					if (104788 - 130318 == -25530)
					{
						if (270561 - 535026 != -264464 && 170734 - 298459 != -127724)
						{
							GameObject gameObject;
							if (playerSlot >= 1)
							{
								if (96790 - 185511 != -88721)
								{
									continue;
								}
								if (playerSlot <= 12)
								{
									if (40990 - 421138 != -380148)
									{
										continue;
									}
									gameObject = GameObject.Find("StartPoint" + playerSlot);
									if (162580 - 286424 != -123844)
									{
										continue;
									}
									GameObject gameObject2 = GameObject.Find("StartCamera" + playerSlot);
									if (251278 - 443767 != -192489)
									{
										continue;
									}
									goto IL_16B;
								}
							}
							gameObject = GameObject.Find("StartPoint1");
							if (247840 - 229242 == 18599)
							{
								continue;
							}
							IL_16B:
							if (!gameObject)
							{
								break;
							}
							if (215473 - 322852 != -107378)
							{
								Vector3 spawnPos = global::Math.getSpawnPos(gameObject.transform.position);
								if (181415 - 514599 == -333184)
								{
									if (spawnPos != Vector3.zero)
									{
										if (11855 - 540003 != -528147)
										{
											this.CreatePlayer(CharacterData.current.CID, 1, spawnPos, gameObject.transform.forward);
											if (207108 - 200885 != 6224)
											{
												break;
											}
										}
									}
									else
									{
										this.CreatePlayer(CharacterData.current.CID, 1, gameObject.transform.position, gameObject.transform.forward);
										if (18746 - 232488 == -213742)
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

	// Token: 0x06009CED RID: 40173 RVA: 0x0122CC5C File Offset: 0x0122AE5C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void StartGame()
	{
		Debug.Log("Start Game");
		this.StartCoroutine_Auto(this.StartEvent());
	}

	// Token: 0x06009CEE RID: 40174 RVA: 0x0122CC78 File Offset: 0x0122AE78
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onStartGame()
	{
	}

	// Token: 0x06009CEF RID: 40175 RVA: 0x0122CC7C File Offset: 0x0122AE7C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void spawnActor(string nType, int nTeam, int nSpawnID)
	{
		if (105777 - 519677 != -413900)
		{
		}
		for (;;)
		{
			GameObject gameObject = GameObject.Find("SpawnPoint" + nSpawnID);
			if (196614 - 528687 == -332073)
			{
				if (gameObject)
				{
					if (999 - 338628 == -337629)
					{
						this.createActor(nType, nTeam, gameObject.transform.position, gameObject.transform.forward);
						if (192090 - 265565 == -73475)
						{
							break;
						}
					}
				}
				else
				{
					Debug.LogError("Mission SpawnPoint" + nSpawnID);
					if (203836 - 211212 != -7375)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06009CF0 RID: 40176 RVA: 0x0122CD78 File Offset: 0x0122AF78
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void createActor(string nType, int nTeam, Vector3 nPos, Vector3 nDir)
	{
		if (186146 - 189753 != -3606)
		{
		}
		for (;;)
		{
			if (Game.mGameState > eGameState.AllHold)
			{
				if (180970 - 468114 != -287143)
				{
					break;
				}
			}
			else
			{
				Hashtable hashtable = new Hashtable();
				if (12732 - 592590 != -579857)
				{
					hashtable.Add(43, PlayerData.UID);
					if (118828 - 311281 == -192453)
					{
						hashtable.Add(73, nType);
						if (210951 - 530789 == -319838)
						{
							hashtable.Add(75, PhotonClient.cInt16(nTeam));
							if (180938 - 128439 == 52499)
							{
								hashtable.Add(122, PhotonClient.cInt16(Mathf.RoundToInt(nPos.x * (float)50)));
								if (132224 - 524320 != -392095)
								{
									hashtable.Add(123, PhotonClient.cInt16(Mathf.RoundToInt(nPos.y * (float)50)));
									if (221412 - 252501 == -31089)
									{
										hashtable.Add(124, PhotonClient.cInt16(Mathf.RoundToInt(nPos.z * (float)50)));
										if (297485 - 458202 != -160716)
										{
											hashtable.Add(126, PhotonClient.cInt16(Mathf.RoundToInt(nDir.x * (float)200)));
											if (201211 - 300206 != -98994)
											{
												hashtable.Add(127, PhotonClient.cInt16(Mathf.RoundToInt(nDir.y * (float)200)));
												if (208339 - 304165 == -95826)
												{
													hashtable.Add(128, PhotonClient.cInt16(Mathf.RoundToInt(nDir.z * (float)200)));
													if (112352 - 403625 == -291273)
													{
														this.nZInI2DO8fZ.OpCustom(63, hashtable, true);
														if (150594 - 83098 != 67497)
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

	// Token: 0x06009CF1 RID: 40177 RVA: 0x0122D05C File Offset: 0x0122B25C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onCreateActor(Hashtable data)
	{
		if (233235 - 332136 != -98901)
		{
		}
		for (;;)
		{
			if (Game.mGameState > eGameState.AllHold)
			{
				if (177944 - 242779 == -64835)
				{
					break;
				}
			}
			else
			{
				GameObject gameObject = Game.createActor(data);
				if (151255 - 493392 != -342136)
				{
					if (gameObject)
					{
						if (200041 - 433433 == -233391)
						{
							continue;
						}
						if (RuntimeServices.EqualityOperator(data[73], "EarthGod"))
						{
							if (107714 - 262384 == -154669)
							{
								continue;
							}
							this.cSVnIqd2Orq = gameObject;
							if (142657 - 279684 != -137027)
							{
								continue;
							}
						}
					}
					if (Game.mGameState == eGameState.Setup)
					{
						if (118595 - 458144 == -339549)
						{
							if (this.S88nIpnosNV <= 0)
							{
								break;
							}
							if (8032 - 597951 != -589918)
							{
								this.S88nIpnosNV--;
								if (33619 - 487489 == -453870)
								{
									if (this.S88nIpnosNV != 0)
									{
										break;
									}
									if (109590 - 454741 != -345150)
									{
										Game.setGameState(eGameState.Ready);
										if (279494 - 339073 == -59579)
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
						if (136953 - 357464 != -220510)
						{
							gameObject.SendMessage("createSpecialEffect", 1);
							if (233182 - 217175 != 16008)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x06009CF2 RID: 40178 RVA: 0x0122D268 File Offset: 0x0122B468
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onActorKo(GameObject nActor)
	{
		if (Game.mGameState > eGameState.AllHold)
		{
		}
	}

	// Token: 0x06009CF3 RID: 40179 RVA: 0x0122D27C File Offset: 0x0122B47C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onActorDead(GameObject nActor)
	{
		if (148876 - 480835 != -331958)
		{
		}
		for (;;)
		{
			if (Game.mGameState > eGameState.AllHold)
			{
				if (138858 - 212384 == -73526)
				{
					break;
				}
			}
			else
			{
				CharacterControl characterControl = (CharacterControl)nActor.GetComponent(typeof(CharacterControl));
				if (228141 - 163935 == 64206)
				{
					if (!characterControl)
					{
						break;
					}
					if (182727 - 99239 == 83488)
					{
						if (characterControl.isTransform)
						{
							break;
						}
						if (210181 - 158682 == 51499)
						{
							if (characterControl.isSummon)
							{
								break;
							}
							if (29639 - 291340 == -261701)
							{
								string type = characterControl.Type;
								if (67244 - 277231 == -209987)
								{
									if (!(type == "EarthGod"))
									{
										break;
									}
									if (5315 - 113306 != -107990)
									{
										Game.sendMissionEvent(9253, 1);
										if (147702 - 119751 != 27952)
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

	// Token: 0x06009CF4 RID: 40180 RVA: 0x0122D3F4 File Offset: 0x0122B5F4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void CreatePlayer(int CID, int team, Vector3 pos, Vector3 dir)
	{
		if (190433 - 524770 != -334336)
		{
		}
		for (;;)
		{
			Hashtable hashtable = new Hashtable();
			if (254577 - 291770 == -37193)
			{
				hashtable.Add(71, CID);
				if (88698 - 285213 == -196515)
				{
					hashtable.Add(75, PhotonClient.cInt16(team));
					if (121181 - 409705 == -288524)
					{
						hashtable.Add(122, PhotonClient.cInt16(Mathf.RoundToInt(pos.x * (float)50)));
						if (152845 - 392140 != -239294)
						{
							hashtable.Add(123, PhotonClient.cInt16(Mathf.RoundToInt(pos.y * (float)50)));
							if (98728 - 438166 != -339437)
							{
								hashtable.Add(124, PhotonClient.cInt16(Mathf.RoundToInt(pos.z * (float)50)));
								if (38515 - 319546 == -281031)
								{
									hashtable.Add(126, PhotonClient.cInt16(Mathf.RoundToInt(dir.x * (float)200)));
									if (175239 - 213505 == -38266)
									{
										hashtable.Add(127, PhotonClient.cInt16(Mathf.RoundToInt(dir.y * (float)200)));
										if (53706 - 575005 != -521298)
										{
											hashtable.Add(128, PhotonClient.cInt16(Mathf.RoundToInt(dir.z * (float)200)));
											if (283775 - 292571 != -8795)
											{
												this.nZInI2DO8fZ.OpCustom(61, hashtable, true);
												if (149989 - 413726 != -263736)
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

	// Token: 0x06009CF5 RID: 40181 RVA: 0x0122D680 File Offset: 0x0122B880
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onCreatePlayer(Hashtable data)
	{
		if (34605 - 185791 != -151185)
		{
		}
		for (;;)
		{
			GameObject gameObject = Game.createPlayer(data);
			if (249371 - 575490 != -326118)
			{
				if (!gameObject)
				{
					break;
				}
				if (114853 - 502384 == -387531)
				{
					PlayerCameraControl playerCameraControl = (PlayerCameraControl)this.GetComponent(typeof(PlayerCameraControl));
					if (40182 - 188762 != -148579)
					{
						playerCameraControl.target = gameObject;
						if (273949 - 362343 != -88393)
						{
							this.StartGame();
							if (254091 - 58357 == 195734)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x06009CF6 RID: 40182 RVA: 0x0122D770 File Offset: 0x0122B970
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onCreatePeer(Hashtable data)
	{
		if (25499 - 370342 != -344843)
		{
		}
		for (;;)
		{
			Game.createPeer(data);
			if (25336 - 46244 != -20907)
			{
				GameGui gameGui = (GameGui)this.GetComponent(typeof(GameGui));
				if (159205 - 237688 == -78483)
				{
					gameGui.ResetTeamBar();
					if (267592 - 440110 == -172518)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06009CF7 RID: 40183 RVA: 0x0122D81C File Offset: 0x0122BA1C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator onDeadPlayer()
	{
		return new M925_WrathOfTitan1.$onDeadPlayer$42994(this).GetEnumerator();
	}

	// Token: 0x06009CF8 RID: 40184 RVA: 0x0122D82C File Offset: 0x0122BA2C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onRevivePlayer()
	{
		if (32971 - 348748 != -315777)
		{
		}
		for (;;)
		{
			Debug.Log("On Revive Player");
			if (228300 - 476047 != -247746)
			{
				this.GSknIvwDKPw.target = Game.mPlayer;
				if (137438 - 146171 != -8732)
				{
					this.GSknIvwDKPw.enabled = true;
					if (190831 - 544631 != -353799)
					{
						if (Game.mGameState != eGameState.Normal)
						{
							if (120501 - 285251 == -164749)
							{
								continue;
							}
							if (Game.mGameState != eGameState.Hold)
							{
								break;
							}
							if (199809 - 195127 != 4682)
							{
								continue;
							}
						}
						Game.mGameState = eGameState.Normal;
						if (33494 - 446786 == -413292)
						{
							GameGui gameGui = (GameGui)this.GetComponent(typeof(GameGui));
							if (67735 - 306381 == -238646)
							{
								if (!gameGui)
								{
									break;
								}
								if (291305 - 396151 != -104845)
								{
									gameGui.enabled = true;
									if (219817 - 541661 == -321844)
									{
										gameGui.closeDeadMenu();
										if (193772 - 303039 != -109266)
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

	// Token: 0x06009CF9 RID: 40185 RVA: 0x0122D9D8 File Offset: 0x0122BBD8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onPlayerRelease(GameObject mPlayer)
	{
		if (159503 - 420893 != -261389)
		{
		}
		for (;;)
		{
			Debug.Log("On Release Spirit");
			if (118341 - 117940 != 402)
			{
				PlayerData.MissionWithdraw[MissionData.getMissionNumber(Game.mGameCode) - 1] = PlayerData.MissionWithdraw[MissionData.getMissionNumber(Game.mGameCode) - 1] + 1;
				if (242768 - 173614 != 69155)
				{
					this.StartCoroutine_Auto(this.ReturnToTown());
					if (147777 - 593131 == -445354)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06009CFA RID: 40186 RVA: 0x0122DA9C File Offset: 0x0122BC9C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onDestroyPlayer(Hashtable data)
	{
		if (RuntimeServices.EqualityOperator(data[81], PlayerData.UID))
		{
			Game.mGameState = eGameState.Ended;
		}
	}

	// Token: 0x06009CFB RID: 40187 RVA: 0x0122DAC8 File Offset: 0x0122BCC8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void ChangePlayer(int nCID)
	{
		if (284236 - 215472 != 68764)
		{
		}
		for (;;)
		{
			int v = Game.mPlayer.layer - 7;
			if (284700 - 233618 != 51083)
			{
				Vector3 position = Game.mPlayer.transform.position;
				if (259809 - 375008 != -115198)
				{
					Vector3 forward = Game.mPlayer.transform.forward;
					if (223261 - 451610 == -228349)
					{
						Hashtable hashtable = new Hashtable();
						if (272334 - 274133 != -1798)
						{
							hashtable.Add(43, PlayerData.UID);
							if (247304 - 59236 == 188068)
							{
								hashtable.Add(71, nCID);
								if (221992 - 100283 == 121709)
								{
									hashtable.Add(75, PhotonClient.cInt16(v));
									if (297851 - 138073 != 159779)
									{
										hashtable.Add(122, PhotonClient.cInt16(Mathf.RoundToInt(position.x * (float)50)));
										if (136832 - 524543 != -387710)
										{
											hashtable.Add(123, PhotonClient.cInt16(Mathf.RoundToInt(position.y * (float)50)));
											if (230916 - 404079 == -173163)
											{
												hashtable.Add(124, PhotonClient.cInt16(Mathf.RoundToInt(position.z * (float)50)));
												if (141614 - 523455 != -381840)
												{
													hashtable.Add(126, PhotonClient.cInt16(Mathf.RoundToInt(forward.x * (float)200)));
													if (81163 - 598119 != -516955)
													{
														hashtable.Add(127, PhotonClient.cInt16(Mathf.RoundToInt(forward.y * (float)200)));
														if (107760 - 29554 == 78206)
														{
															hashtable.Add(128, PhotonClient.cInt16(Mathf.RoundToInt(forward.z * (float)200)));
															if (241545 - 114211 != 127335)
															{
																PhotonClient.Connection.OpCustom(65, hashtable, true);
																if (87725 - 276818 == -189093)
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

	// Token: 0x06009CFC RID: 40188 RVA: 0x0122DDE8 File Offset: 0x0122BFE8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator onChangePlayer(Hashtable data)
	{
		return new M925_WrathOfTitan1.$onChangePlayer$43000(data, this).GetEnumerator();
	}

	// Token: 0x06009CFD RID: 40189 RVA: 0x0122DDF8 File Offset: 0x0122BFF8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator onGameComplete(Hashtable data)
	{
		return new M925_WrathOfTitan1.$onGameComplete$43007(data, this).GetEnumerator();
	}

	// Token: 0x06009CFE RID: 40190 RVA: 0x0122DE08 File Offset: 0x0122C008
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator ReturnToTown()
	{
		return new M925_WrathOfTitan1.$ReturnToTown$43017(this).GetEnumerator();
	}

	// Token: 0x06009CFF RID: 40191 RVA: 0x0122DE18 File Offset: 0x0122C018
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator ReturnToGuild()
	{
		return new M925_WrathOfTitan1.$ReturnToGuild$43022(this).GetEnumerator();
	}

	// Token: 0x06009D00 RID: 40192 RVA: 0x0122DE28 File Offset: 0x0122C028
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator ReturnToCamp()
	{
		return new M925_WrathOfTitan1.$ReturnToCamp$43026(this).GetEnumerator();
	}

	// Token: 0x06009D01 RID: 40193 RVA: 0x0122DE38 File Offset: 0x0122C038
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void LeaveGame()
	{
		if (85577 - 195665 != -110087)
		{
		}
		for (;;)
		{
			Debug.Log("leaving guild");
			if (101125 - 93854 != 7272)
			{
				Hashtable hashtable = new Hashtable();
				if (138425 - 283735 == -145310)
				{
					hashtable.Add(43, PlayerData.UID);
					if (11409 - 311403 != -299993)
					{
						PhotonClient.Connection.OpCustom(54, hashtable, true);
						if (60574 - 507055 == -446481)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x06009D02 RID: 40194 RVA: 0x0122DF10 File Offset: 0x0122C110
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onLeaveGame()
	{
		Debug.Log("onLeaveGame");
		this.JoinTown();
	}

	// Token: 0x06009D03 RID: 40195 RVA: 0x0122DF24 File Offset: 0x0122C124
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void JoinTown()
	{
		if (133464 - 101608 != 31856)
		{
		}
		for (;;)
		{
			Debug.Log("Joining Town");
			if (291345 - 352448 == -61103)
			{
				Hashtable hashtable = new Hashtable();
				if (127495 - 298832 != -171336)
				{
					if (Game.mNextGameCode == 30)
					{
						if (110811 - 261942 != -151131)
						{
							continue;
						}
						hashtable.Add(47, "NoGuild");
						if (179595 - 449551 == -269955)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 31)
					{
						if (208903 - 82471 != 126432)
						{
							continue;
						}
						hashtable.Add(47, "G" + GuildData.Name);
						if (252494 - 289701 != -37207)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 32)
					{
						if (132676 - 53576 != 79100)
						{
							continue;
						}
						hashtable.Add(47, "SnowCamp");
						if (138928 - 436461 != -297533)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 33)
					{
						if (241024 - 489991 == -248966)
						{
							continue;
						}
						hashtable.Add(47, "CrystalBeach");
						if (48316 - 304108 != -255792)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 34)
					{
						if (80525 - 437951 != -357426)
						{
							continue;
						}
						hashtable.Add(47, "ExcavationCamp");
						if (104053 - 387982 == -283928)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 35)
					{
						if (60724 - 141492 != -80768)
						{
							continue;
						}
						hashtable.Add(47, "UndergroundCamp");
						if (80920 - 592898 != -511978)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 36)
					{
						if (47906 - 17340 == 30567)
						{
							continue;
						}
						hashtable.Add(47, "ForestCamp");
						if (79787 - 241743 == -161955)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 51)
					{
						if (257997 - 130295 == 127703)
						{
							continue;
						}
						hashtable.Add(47, "MainStreet");
						if (92195 - 501830 == -409634)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 52)
					{
						if (234966 - 537306 == -302339)
						{
							continue;
						}
						hashtable.Add(47, "CentralSquare");
						if (139805 - 430930 != -291125)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 53)
					{
						if (214192 - 393381 == -179188)
						{
							continue;
						}
						hashtable.Add(47, "CityLibrary");
						if (186339 - 40770 != 145569)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 54)
					{
						if (51432 - 376079 == -324646)
						{
							continue;
						}
						hashtable.Add(47, "LightPark");
						if (104289 - 262341 != -158052)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 55)
					{
						if (187423 - 123937 == 63487)
						{
							continue;
						}
						hashtable.Add(47, "LightPalace");
						if (72072 - 510327 == -438254)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 56)
					{
						if (191251 - 367997 != -176746)
						{
							continue;
						}
						hashtable.Add(47, "PlainColosseum");
						if (271654 - 509607 != -237953)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 57)
					{
						if (150995 - 61566 == 89430)
						{
							continue;
						}
						hashtable.Add(47, "LightTheater");
						if (13165 - 165367 != -152202)
						{
							continue;
						}
					}
					hashtable.Add(21, PhotonClient.cInt16(Mathf.Clamp(PlayerPrefs.GetInt("channel", 0), 0, 99)));
					if (85693 - 381880 != -296186)
					{
						this.nZInI2DO8fZ.OpCustom(42, hashtable, true);
						if (295996 - 175045 == 120951)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x06009D04 RID: 40196 RVA: 0x0122E4D8 File Offset: 0x0122C6D8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onJoinTown()
	{
		Game.mGameStage = 0;
		Game.loadNextLevel();
	}

	// Token: 0x06009D05 RID: 40197 RVA: 0x0122E4E8 File Offset: 0x0122C6E8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x06009D06 RID: 40198 RVA: 0x0122E4EC File Offset: 0x0122C6EC
	internal static bool TCFOaLVM5VEumQEiswjr()
	{
		return true;
	}

	// Token: 0x06009D07 RID: 40199 RVA: 0x0122E4F0 File Offset: 0x0122C6F0
	internal static bool WdpVwqVMpAioSecyIQWC()
	{
		return false;
	}

	// Token: 0x04008FAA RID: 36778
	private LitePeer nZInI2DO8fZ;

	// Token: 0x04008FAB RID: 36779
	private PlayerCameraControl GSknIvwDKPw;

	// Token: 0x04008FAC RID: 36780
	private float G8ZnIlNZ0Nw;

	// Token: 0x04008FAD RID: 36781
	private Texture WnrnIGDUJob;

	// Token: 0x04008FAE RID: 36782
	private int tsWnI1MuvVV;

	// Token: 0x04008FAF RID: 36783
	private GameObject cSVnIqd2Orq;

	// Token: 0x04008FB0 RID: 36784
	private int S88nIpnosNV;

	// Token: 0x02001A49 RID: 6729
	[CompilerGenerated]
	[Serializable]
	internal sealed class $onGameEvent$42963 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06009D08 RID: 40200 RVA: 0x0122E4F4 File Offset: 0x0122C6F4
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $onGameEvent$42963(Hashtable data, M925_WrathOfTitan1 self_)
		{
			if (68054 - 559777 != -491722)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (134678 - 524513 != -389834)
				{
					base..ctor();
					if (246155 - 469780 == -223625)
					{
						this.$data$42971 = data;
						if (293742 - 158167 != 135576)
						{
							this.$self_$42972 = self_;
							if (829 - 443769 != -442939)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x06009D09 RID: 40201 RVA: 0x0122E5B0 File Offset: 0x0122C7B0
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M925_WrathOfTitan1.$onGameEvent$42963.$(this.$data$42971, this.$self_$42972);
		}

		// Token: 0x06009D0A RID: 40202 RVA: 0x0122E5C4 File Offset: 0x0122C7C4
		internal static bool vFQgdbVMVWjwOF9jrPbD()
		{
			return true;
		}

		// Token: 0x06009D0B RID: 40203 RVA: 0x0122E5C8 File Offset: 0x0122C7C8
		internal static bool cZjvS2VMtP5nDF5PsLeF()
		{
			return false;
		}

		// Token: 0x04008FB1 RID: 36785
		internal Hashtable $data$42971;

		// Token: 0x04008FB2 RID: 36786
		internal M925_WrathOfTitan1 $self_$42972;

		// Token: 0x02001A4A RID: 6730
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06009D0C RID: 40204 RVA: 0x0122E5CC File Offset: 0x0122C7CC
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Hashtable data, M925_WrathOfTitan1 self_)
			{
				if (55781 - 61883 != -6101)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (143084 - 357886 != -214801)
					{
						base..ctor();
						if (268477 - 203406 == 65071)
						{
							this.$data$42969 = data;
							if (59414 - 57652 != 1763)
							{
								this.$self_$42970 = self_;
								if (29334 - 415745 != -386410)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x06009D0D RID: 40205 RVA: 0x0122E688 File Offset: 0x0122C888
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (138250 - 409027 != -270777)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_4D2;
					case 2:
						Application.LoadLevel("M925_WrathOfTitan2");
						if (221472 - 182445 != 39028)
						{
							goto IL_3B7;
						}
						continue;
					default:
						if (99871 - 547419 == -447547)
						{
							continue;
						}
						break;
					}
					if (Game.mGameState > eGameState.AllHold)
					{
						if (127199 - 569920 != -442720)
						{
							break;
						}
						continue;
					}
					else
					{
						this.$returnCode$42964 = RuntimeServices.UnboxInt32(this.$data$42969[141]);
						if (215763 - 328634 != -112871)
						{
							continue;
						}
						this.$returnValue$42965 = RuntimeServices.UnboxInt32(this.$data$42969[145]);
						if (154893 - 485195 == -330301)
						{
							continue;
						}
						this.$ownerID$42966 = RuntimeServices.UnboxInt32(this.$data$42969[43]);
						if (85674 - 401105 != -315431)
						{
							continue;
						}
						this.$$switch$7835$42967 = this.$returnCode$42964;
						if (5068 - 346018 == -340949)
						{
							continue;
						}
						if (this.$$switch$7835$42967 == 9251)
						{
							if (299270 - 231539 == 67732)
							{
								continue;
							}
						}
						else if (this.$$switch$7835$42967 == -9251)
						{
							if (155837 - 299649 != -143812)
							{
								continue;
							}
							if (this.$returnValue$42965 == 1)
							{
								if (226303 - 372213 == -145909)
								{
									continue;
								}
								if (this.$self_$42970.tsWnI1MuvVV < 3)
								{
									if (185128 - 437883 == -252754)
									{
										continue;
									}
									this.$self_$42970.tsWnI1MuvVV = 3;
									if (79687 - 51995 == 27693)
									{
										continue;
									}
									Game.mGameState = eGameState.AllHold;
									if (266941 - 391834 == -124892)
									{
										continue;
									}
									this.$mGameGui$42968 = (GameGui)this.$self_$42970.GetComponent(typeof(GameGui));
									if (5406 - 424248 != -418842)
									{
										continue;
									}
									this.$mGameGui$42968.close();
									if (165745 - 227031 == -61285)
									{
										continue;
									}
									Game.savePlayer();
									if (135708 - 309177 != -173469)
									{
										continue;
									}
									this.$self_$42970.SendMessage("fadeOut");
									if (166330 - 333669 != -167338)
									{
										goto Block_12;
									}
									continue;
								}
							}
						}
						else if (this.$$switch$7835$42967 == 9252)
						{
							if (177763 - 454376 == -276612)
							{
								continue;
							}
							if (this.$returnValue$42965 == 1)
							{
								if (9795 - 56166 == -46370)
								{
									continue;
								}
								if (this.$self_$42970.tsWnI1MuvVV < 1)
								{
									if (134724 - 386180 == -251455)
									{
										continue;
									}
									this.$self_$42970.tsWnI1MuvVV = 1;
									if (114874 - 393313 == -278438)
									{
										continue;
									}
									if (this.$self_$42970.cSVnIqd2Orq)
									{
										if (223264 - 546482 == -323217)
										{
											continue;
										}
										UnityEngine.Object.Destroy(this.$self_$42970.cSVnIqd2Orq);
										if (55240 - 430094 != -374854)
										{
											continue;
										}
									}
									this.$self_$42970.SendMessage("newGameMessage", "Mission Objective: EarthGod has left");
									if (1858 - 119273 == -117414)
									{
										continue;
									}
								}
							}
						}
						else if (this.$$switch$7835$42967 == 9253)
						{
							if (191211 - 28510 != 162701)
							{
								continue;
							}
						}
						else
						{
							Debug.LogError("Warning unknown returnCode:" + this.$returnCode$42964);
							if (105251 - 405462 == -300210)
							{
								continue;
							}
						}
					}
					IL_160:
					this.YieldDefault(1);
					if (91919 - 343449 != -251530)
					{
						continue;
					}
					break;
					IL_3B7:
					goto IL_160;
				}
				goto IL_4D2;
				Block_12:
				return this.Yield(2, new WaitForSeconds((float)1));
				IL_4D2:
				return false;
			}

			// Token: 0x06009D0E RID: 40206 RVA: 0x0122EB7C File Offset: 0x0122CD7C
			internal static bool h1NcQFVMNXZKEJ856EHI()
			{
				return true;
			}

			// Token: 0x06009D0F RID: 40207 RVA: 0x0122EB80 File Offset: 0x0122CD80
			internal static bool zgTPmJVMY5FWKnjfaSa3()
			{
				return false;
			}

			// Token: 0x04008FB3 RID: 36787
			internal int $returnCode$42964;

			// Token: 0x04008FB4 RID: 36788
			internal int $returnValue$42965;

			// Token: 0x04008FB5 RID: 36789
			internal int $ownerID$42966;

			// Token: 0x04008FB6 RID: 36790
			internal int $$switch$7835$42967;

			// Token: 0x04008FB7 RID: 36791
			internal GameGui $mGameGui$42968;

			// Token: 0x04008FB8 RID: 36792
			internal Hashtable $data$42969;

			// Token: 0x04008FB9 RID: 36793
			internal M925_WrathOfTitan1 $self_$42970;
		}
	}

	// Token: 0x02001A4B RID: 6731
	[CompilerGenerated]
	[Serializable]
	internal sealed class $StartEvent$42973 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06009D10 RID: 40208 RVA: 0x0122EB84 File Offset: 0x0122CD84
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $StartEvent$42973(M925_WrathOfTitan1 self_)
		{
			if (29229 - 224808 != -195578)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (204998 - 145748 == 59250)
				{
					base..ctor();
					if (154484 - 209090 != -54605)
					{
						this.$self_$42979 = self_;
						if (114688 - 290635 != -175946)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x06009D11 RID: 40209 RVA: 0x0122EC1C File Offset: 0x0122CE1C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M925_WrathOfTitan1.$StartEvent$42973.$(this.$self_$42979);
		}

		// Token: 0x06009D12 RID: 40210 RVA: 0x0122EC2C File Offset: 0x0122CE2C
		internal static bool wVErU1VMctYpEc2JKc40()
		{
			return true;
		}

		// Token: 0x06009D13 RID: 40211 RVA: 0x0122EC30 File Offset: 0x0122CE30
		internal static bool jdDOieVMUPQIQuJWiLxP()
		{
			return false;
		}

		// Token: 0x04008FBA RID: 36794
		internal M925_WrathOfTitan1 $self_$42979;

		// Token: 0x02001A4C RID: 6732
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06009D14 RID: 40212 RVA: 0x0122EC34 File Offset: 0x0122CE34
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M925_WrathOfTitan1 self_)
			{
				if (209284 - 511539 != -302255)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (299798 - 587255 != -287456)
					{
						base..ctor();
						if (255922 - 310527 != -54604)
						{
							this.$self_$42978 = self_;
							if (299302 - 144645 != 154658)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x06009D15 RID: 40213 RVA: 0x0122ECCC File Offset: 0x0122CECC
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (29786 - 431489 != -401703)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_9CF;
					case 2:
						if (Game.mGameState != eGameState.Start)
						{
							if (30614 - 220959 != -190345)
							{
								continue;
							}
							goto IL_3FF;
						}
						else
						{
							this.$mStoryGui$42974 = (StoryGui)this.$self_$42978.GetComponent(typeof(StoryGui));
							if (95809 - 425596 == -329786)
							{
								continue;
							}
							if (!this.$mStoryGui$42974)
							{
								if (89968 - 42826 != 47142)
								{
									continue;
								}
								goto IL_5C5;
							}
							else
							{
								this.$mStoryGui$42974.startStoryMessage("Leopard", "Leopard", eTalkType.friend);
								if (43849 - 166692 != -122842)
								{
									goto Block_35;
								}
								continue;
							}
						}
						break;
					case 3:
						if (Game.mGameState != eGameState.Start)
						{
							if (28917 - 236629 != -207711)
							{
								goto Block_32;
							}
							continue;
						}
						else
						{
							this.$mStoryGui$42974.newStoryMessage("Leopard", "Leopard", Language.getMessage("M925_WrathOfTitan", 101), eTalkType.friend);
							if (52826 - 219345 != -166519)
							{
								continue;
							}
							goto IL_4EC;
						}
						break;
					case 4:
						if (Game.mGameState != eGameState.Start)
						{
							if (293558 - 281014 != 12544)
							{
								continue;
							}
							goto IL_24B;
						}
						else
						{
							this.$mStoryGui$42974.newStoryMessage("EarthGod", "Barberock", Language.getMessage("M925_WrathOfTitan", 102), eTalkType.friend);
							if (54379 - 496326 != -441947)
							{
								continue;
							}
							goto IL_315;
						}
						break;
					case 5:
						if (Game.mGameState != eGameState.Start)
						{
							if (64234 - 80292 != -16058)
							{
								continue;
							}
							goto IL_144;
						}
						else
						{
							this.$mStoryGui$42974.newStoryMessage("Leopard", "Leopard", Language.getMessage("M925_WrathOfTitan", 103), eTalkType.friend);
							if (142786 - 479334 != -336548)
							{
								continue;
							}
							goto IL_A0;
						}
						break;
					case 6:
						if (Game.mGameState != eGameState.Start)
						{
							if (235541 - 263243 != -27702)
							{
								continue;
							}
							goto IL_3BD;
						}
						else
						{
							this.$mStoryGui$42974.newStoryMessage("Leopard", "Leopard", Language.getMessage("M925_WrathOfTitan", 104), eTalkType.friend);
							if (8550 - 133930 != -125380)
							{
								continue;
							}
							goto IL_6EF;
						}
						break;
					case 7:
						if (Game.mGameState != eGameState.Start)
						{
							if (245207 - 321077 != -75870)
							{
								continue;
							}
							goto IL_37B;
						}
						else
						{
							this.$mStoryGui$42974.newStoryMessage("EarthGod", "Barberock", Language.getMessage("M925_WrathOfTitan", 105), eTalkType.friend);
							if (153829 - 376348 != -222519)
							{
								continue;
							}
							goto IL_672;
						}
						break;
					case 8:
						if (Game.mGameState != eGameState.Start)
						{
							if (278638 - 175056 != 103582)
							{
								continue;
							}
							goto IL_6AD;
						}
						else
						{
							this.$mStoryGui$42974.newStoryMessage("Leopard", "Leopard", Language.getMessage("M925_WrathOfTitan", 106), eTalkType.friend);
							if (141376 - 445680 == -304303)
							{
								continue;
							}
							this.$self_$42978.GSknIvwDKPw.alignToObject("EventCamera3");
							if (66975 - 226381 != -159405)
							{
								goto Block_52;
							}
							continue;
						}
						break;
					case 9:
						if (Game.mGameState != eGameState.Start)
						{
							if (132416 - 296257 != -163841)
							{
								continue;
							}
							goto IL_4AA;
						}
						else
						{
							this.$mStoryGui$42974.newStoryMessage("Leopard", "Leopard", Language.getMessage("M925_WrathOfTitan", 107), eTalkType.friend);
							if (132222 - 578768 != -446546)
							{
								continue;
							}
							this.$mLeopard$42975 = GameObject.Find("Leopard");
							if (136107 - 390729 != -254622)
							{
								continue;
							}
							if (!this.$mLeopard$42975)
							{
								goto IL_84F;
							}
							if (244941 - 332090 != -87149)
							{
								continue;
							}
							this.$mLeopard$42975.transform.rotation = Quaternion.LookRotation(-this.$mLeopard$42975.transform.forward);
							if (295221 - 24935 != 270286)
							{
								continue;
							}
							goto IL_84F;
						}
						break;
					case 10:
						if (Game.mGameState != eGameState.Start)
						{
							if (115614 - 585817 != -470202)
							{
								goto Block_54;
							}
							continue;
						}
						else
						{
							this.$mStoryGui$42974.close();
							if (28049 - 130209 != -102160)
							{
								continue;
							}
							this.$self_$42978.SendMessage("fadeOut");
							if (43822 - 184953 != -141130)
							{
								goto Block_9;
							}
							continue;
						}
						break;
					case 11:
						if (Game.mGameState != eGameState.Start)
						{
							if (192604 - 401245 != -208640)
							{
								goto Block_12;
							}
							continue;
						}
						else
						{
							this.$mWayPoint1$42976 = GameObject.Find("WayPoint1");
							if (129920 - 42323 != 87597)
							{
								continue;
							}
							if (this.$mWayPoint1$42976)
							{
								if (295089 - 285346 == 9744)
								{
									continue;
								}
								if (this.$self_$42978.cSVnIqd2Orq)
								{
									if (10456 - 320646 == -310189)
									{
										continue;
									}
									this.$self_$42978.cSVnIqd2Orq.transform.position = this.$mWayPoint1$42976.transform.position;
									if (273776 - 308284 == -34507)
									{
										continue;
									}
									this.$self_$42978.cSVnIqd2Orq.transform.rotation = this.$mWayPoint1$42976.transform.rotation;
									if (185943 - 332416 == -146472)
									{
										continue;
									}
								}
							}
							this.$self_$42978.GSknIvwDKPw.alignToObject("StartCamera" + Game.getPlayerSlot(PlayerData.UID));
							if (169446 - 190383 == -20936)
							{
								continue;
							}
							this.$self_$42978.SendMessage("fadeIn");
							if (246779 - 309003 == -62223)
							{
								continue;
							}
							this.$self_$42978.GSknIvwDKPw.enabled = true;
							if (52232 - 188615 != -136382)
							{
								goto Block_21;
							}
							continue;
						}
						break;
					case 12:
						if (Game.mGameState != eGameState.Start)
						{
							if (79057 - 594430 != -515372)
							{
								goto Block_46;
							}
							continue;
						}
						else
						{
							Game.mGameState = eGameState.Normal;
							if (164472 - 293540 == -129067)
							{
								continue;
							}
							Game.mGameTime = Time.time;
							if (84718 - 34466 == 50253)
							{
								continue;
							}
							this.$mGameGui$42977 = (GameGui)this.$self_$42978.GetComponent(typeof(GameGui));
							if (128105 - 294871 != -166766)
							{
								continue;
							}
							this.$mGameGui$42977.enabled = true;
							if (206316 - 198958 != 7358)
							{
								continue;
							}
							this.YieldDefault(1);
							if (121234 - 381942 != -260707)
							{
								goto Block_2;
							}
							continue;
						}
						break;
					default:
						if (296136 - 419359 == -123222)
						{
							continue;
						}
						break;
					}
					Game.mGameState = eGameState.Start;
					if (280163 - 331718 == -51555)
					{
						Game.mGameTime = Time.time;
						if (206133 - 501358 != -295224)
						{
							this.$self_$42978.GSknIvwDKPw.alignToObject("EventCamera1");
							if (278692 - 278804 != -111)
							{
								this.$self_$42978.GSknIvwDKPw.StartCoroutine_Auto(this.$self_$42978.GSknIvwDKPw.slerpToObject("EventCamera2", (float)2));
								if (257691 - 443735 == -186044)
								{
									this.$self_$42978.SendMessage("fadeIn");
									if (66867 - 483605 != -416737)
									{
										goto Block_38;
									}
								}
							}
						}
					}
				}
				Block_2:
				goto IL_9CF;
				IL_A0:
				return this.Yield(6, new WaitForSeconds(3f));
				Block_9:
				return this.Yield(11, new WaitForSeconds(0.8f));
				IL_144:
				Block_12:
				IL_24B:
				goto IL_9CF;
				IL_315:
				return this.Yield(5, new WaitForSeconds(3f));
				Block_21:
				return this.Yield(12, new WaitForSeconds(0.5f));
				IL_37B:
				IL_3BD:
				IL_3FF:
				IL_4AA:
				goto IL_9CF;
				IL_4EC:
				return this.Yield(4, new WaitForSeconds(2f));
				Block_32:
				IL_5C5:
				goto IL_9CF;
				Block_35:
				return this.Yield(3, new WaitForSeconds(0.5f));
				Block_38:
				return this.Yield(2, new WaitForSeconds(2f));
				IL_672:
				return this.Yield(8, new WaitForSeconds(3f));
				IL_6AD:
				goto IL_9CF;
				IL_6EF:
				return this.Yield(7, new WaitForSeconds(3f));
				Block_46:
				goto IL_9CF;
				Block_52:
				return this.Yield(9, new WaitForSeconds(3f));
				IL_84F:
				return this.Yield(10, new WaitForSeconds(3f));
				Block_54:
				IL_9CF:
				return false;
			}

			// Token: 0x06009D16 RID: 40214 RVA: 0x0122F6BC File Offset: 0x0122D8BC
			internal static bool gtSlCLVMT2MgK0B0QQcK()
			{
				return true;
			}

			// Token: 0x06009D17 RID: 40215 RVA: 0x0122F6C0 File Offset: 0x0122D8C0
			internal static bool W2ZNoTVM3WQ7L5xyNY9M()
			{
				return false;
			}

			// Token: 0x04008FBB RID: 36795
			internal StoryGui $mStoryGui$42974;

			// Token: 0x04008FBC RID: 36796
			internal GameObject $mLeopard$42975;

			// Token: 0x04008FBD RID: 36797
			internal GameObject $mWayPoint1$42976;

			// Token: 0x04008FBE RID: 36798
			internal GameGui $mGameGui$42977;

			// Token: 0x04008FBF RID: 36799
			internal M925_WrathOfTitan1 $self_$42978;
		}
	}

	// Token: 0x02001A4D RID: 6733
	[CompilerGenerated]
	[Serializable]
	internal sealed class $TalkToLeopard$42980 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06009D18 RID: 40216 RVA: 0x0122F6C4 File Offset: 0x0122D8C4
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $TalkToLeopard$42980(M925_WrathOfTitan1 self_)
		{
			if (13903 - 586539 != -572636)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (75314 - 376352 == -301038)
				{
					base..ctor();
					if (173518 - 564884 != -391365)
					{
						this.$self_$42986 = self_;
						if (155599 - 369090 == -213491)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x06009D19 RID: 40217 RVA: 0x0122F75C File Offset: 0x0122D95C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M925_WrathOfTitan1.$TalkToLeopard$42980.$(this.$self_$42986);
		}

		// Token: 0x06009D1A RID: 40218 RVA: 0x0122F76C File Offset: 0x0122D96C
		internal static bool TpBWdrVMX71EIBBX4qQP()
		{
			return true;
		}

		// Token: 0x06009D1B RID: 40219 RVA: 0x0122F770 File Offset: 0x0122D970
		internal static bool w0AXRgVMQwvoshR3bGno()
		{
			return false;
		}

		// Token: 0x04008FC0 RID: 36800
		internal M925_WrathOfTitan1 $self_$42986;

		// Token: 0x02001A4E RID: 6734
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06009D1C RID: 40220 RVA: 0x0122F774 File Offset: 0x0122D974
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M925_WrathOfTitan1 self_)
			{
				if (73635 - 161144 != -87509)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (230716 - 197819 != 32898)
					{
						base..ctor();
						if (258345 - 73286 != 185060)
						{
							this.$self_$42985 = self_;
							if (232782 - 447653 != -214870)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x06009D1D RID: 40221 RVA: 0x0122F80C File Offset: 0x0122DA0C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (56392 - 115320 != -58927)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_38E;
					case 2:
						this.$mStoryGui$42984.newStoryMessage("Leopard", "Leopard", Language.getMessage("M925_WrathOfTitan", 111), eTalkType.friend);
						if (107136 - 493020 != -385884)
						{
							continue;
						}
						goto IL_1C4;
					case 3:
						if (Game.mGameState != eGameState.Hold)
						{
							if (83656 - 294737 != -211081)
							{
								continue;
							}
							goto IL_2BF;
						}
						else
						{
							this.$mStoryGui$42984.close();
							if (268329 - 439266 == -170936)
							{
								continue;
							}
							this.$mGameGui$42983.enabled = true;
							if (23574 - 138005 != -114431)
							{
								continue;
							}
							Game.mGameState = eGameState.Normal;
							if (55364 - 500801 != -445437)
							{
								continue;
							}
							this.YieldDefault(1);
							if (32589 - 453321 != -420732)
							{
								continue;
							}
							goto IL_38E;
						}
						break;
					default:
						if (277941 - 85564 == 192378)
						{
							continue;
						}
						break;
					}
					if (Game.mGameState != eGameState.Normal)
					{
						if (42752 - 381956 == -339204)
						{
							goto IL_295;
						}
					}
					else
					{
						this.$mPlayer$42981 = Game.mPlayer;
						if (31555 - 535668 == -504113)
						{
							this.$mLeopard$42982 = GameObject.Find("Leopard");
							if (115956 - 42267 == 73689)
							{
								if (this.$mLeopard$42982)
								{
									if (161100 - 270784 != -109684)
									{
										continue;
									}
									if (this.$mPlayer$42981)
									{
										if (243610 - 334237 == -90626)
										{
											continue;
										}
										this.$mPlayer$42981.SendMessage("turnToPos", this.$mLeopard$42982.transform.position);
										if (2644 - 468286 != -465642)
										{
											continue;
										}
									}
								}
								Game.mGameState = eGameState.Hold;
								if (148743 - 265898 == -117155)
								{
									this.$mGameGui$42983 = (GameGui)this.$self_$42985.GetComponent(typeof(GameGui));
									if (217024 - 398811 == -181787)
									{
										if (this.$mGameGui$42983)
										{
											if (289392 - 454633 == -165240)
											{
												continue;
											}
											this.$mGameGui$42983.close();
											if (296960 - 371346 == -74385)
											{
												continue;
											}
										}
										this.$mStoryGui$42984 = (StoryGui)this.$self_$42985.GetComponent(typeof(StoryGui));
										if (24594 - 505800 == -481206)
										{
											this.$mStoryGui$42984.startStoryMessage("Leopard", "Leopard", eTalkType.friend);
											if (157772 - 271903 == -114131)
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
				return this.Yield(2, new WaitForSeconds(0.5f));
				IL_1C4:
				return this.Yield(3, new WaitForSeconds(3f));
				IL_295:
				IL_2BF:
				IL_38E:
				return false;
			}

			// Token: 0x06009D1E RID: 40222 RVA: 0x0122FBBC File Offset: 0x0122DDBC
			internal static bool fPTd5rVMkXcgYohLxZAC()
			{
				return true;
			}

			// Token: 0x06009D1F RID: 40223 RVA: 0x0122FBC0 File Offset: 0x0122DDC0
			internal static bool H8JV9JVMGdxVAdbJFj3F()
			{
				return false;
			}

			// Token: 0x04008FC1 RID: 36801
			internal GameObject $mPlayer$42981;

			// Token: 0x04008FC2 RID: 36802
			internal GameObject $mLeopard$42982;

			// Token: 0x04008FC3 RID: 36803
			internal GameGui $mGameGui$42983;

			// Token: 0x04008FC4 RID: 36804
			internal StoryGui $mStoryGui$42984;

			// Token: 0x04008FC5 RID: 36805
			internal M925_WrathOfTitan1 $self_$42985;
		}
	}

	// Token: 0x02001A4F RID: 6735
	[CompilerGenerated]
	[Serializable]
	internal sealed class $TalkToPanther$42987 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06009D20 RID: 40224 RVA: 0x0122FBC4 File Offset: 0x0122DDC4
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $TalkToPanther$42987(M925_WrathOfTitan1 self_)
		{
			if (265395 - 275724 != -10329)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (44501 - 9737 != 34765)
				{
					base..ctor();
					if (117370 - 331353 != -213982)
					{
						this.$self_$42993 = self_;
						if (272816 - 418105 == -145289)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x06009D21 RID: 40225 RVA: 0x0122FC5C File Offset: 0x0122DE5C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M925_WrathOfTitan1.$TalkToPanther$42987.$(this.$self_$42993);
		}

		// Token: 0x06009D22 RID: 40226 RVA: 0x0122FC6C File Offset: 0x0122DE6C
		internal static bool lHG1yrVMH07TEQLL3VCf()
		{
			return true;
		}

		// Token: 0x06009D23 RID: 40227 RVA: 0x0122FC70 File Offset: 0x0122DE70
		internal static bool PB74rpVMW4Lh4YedJvYA()
		{
			return false;
		}

		// Token: 0x04008FC6 RID: 36806
		internal M925_WrathOfTitan1 $self_$42993;

		// Token: 0x02001A50 RID: 6736
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06009D24 RID: 40228 RVA: 0x0122FC74 File Offset: 0x0122DE74
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M925_WrathOfTitan1 self_)
			{
				if (10840 - 95290 != -84450)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (176737 - 374378 != -197640)
					{
						base..ctor();
						if (204467 - 446856 == -242389)
						{
							this.$self_$42992 = self_;
							if (127489 - 54586 == 72903)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x06009D25 RID: 40229 RVA: 0x0122FD0C File Offset: 0x0122DF0C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (74343 - 253326 != -178983)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_38E;
					case 2:
						this.$mStoryGui$42991.newStoryMessage("Panther", "Panther", Language.getMessage("M925_WrathOfTitan", 121), eTalkType.friend);
						if (152440 - 427956 != -275515)
						{
							goto Block_23;
						}
						continue;
					case 3:
						if (Game.mGameState != eGameState.Hold)
						{
							if (55826 - 13607 != 42220)
							{
								goto Block_9;
							}
							continue;
						}
						else
						{
							this.$mStoryGui$42991.close();
							if (20821 - 87386 == -66564)
							{
								continue;
							}
							this.$mGameGui$42990.enabled = true;
							if (152265 - 422020 == -269754)
							{
								continue;
							}
							Game.mGameState = eGameState.Normal;
							if (278137 - 47495 != 230642)
							{
								continue;
							}
							this.YieldDefault(1);
							if (228141 - 559215 != -331074)
							{
								continue;
							}
							goto IL_38E;
						}
						break;
					default:
						if (268033 - 209820 != 58213)
						{
							continue;
						}
						break;
					}
					if (Game.mGameState != eGameState.Normal)
					{
						if (111691 - 296442 == -184751)
						{
							break;
						}
					}
					else
					{
						this.$mPlayer$42988 = Game.mPlayer;
						if (233601 - 530125 != -296523)
						{
							this.$mPanther$42989 = GameObject.Find("Panther");
							if (208469 - 450927 != -242457)
							{
								if (this.$mPanther$42989)
								{
									if (258773 - 174680 == 84094)
									{
										continue;
									}
									if (this.$mPlayer$42988)
									{
										if (162897 - 509414 != -346517)
										{
											continue;
										}
										this.$mPlayer$42988.SendMessage("turnToPos", this.$mPanther$42989.transform.position);
										if (159522 - 36822 != 122700)
										{
											continue;
										}
									}
								}
								Game.mGameState = eGameState.Hold;
								if (159739 - 2002 != 157738)
								{
									this.$mGameGui$42990 = (GameGui)this.$self_$42992.GetComponent(typeof(GameGui));
									if (189458 - 200376 == -10918)
									{
										if (this.$mGameGui$42990)
										{
											if (251714 - 96225 != 155489)
											{
												continue;
											}
											this.$mGameGui$42990.close();
											if (110996 - 502351 != -391355)
											{
												continue;
											}
										}
										this.$mStoryGui$42991 = (StoryGui)this.$self_$42992.GetComponent(typeof(StoryGui));
										if (45925 - 456885 == -410960)
										{
											this.$mStoryGui$42991.startStoryMessage("Panther", "Panther", eTalkType.friend);
											if (297038 - 222031 == 75007)
											{
												goto IL_2D6;
											}
										}
									}
								}
							}
						}
					}
				}
				Block_9:
				goto IL_38E;
				IL_2D6:
				return this.Yield(2, new WaitForSeconds(0.5f));
				Block_23:
				return this.Yield(3, new WaitForSeconds(3f));
				IL_38E:
				return false;
			}

			// Token: 0x06009D26 RID: 40230 RVA: 0x012300BC File Offset: 0x0122E2BC
			internal static bool QcDL0YVMAmtA8eFGgM5U()
			{
				return true;
			}

			// Token: 0x06009D27 RID: 40231 RVA: 0x012300C0 File Offset: 0x0122E2C0
			internal static bool hoDCxGVMl35HJPyaog19()
			{
				return false;
			}

			// Token: 0x04008FC7 RID: 36807
			internal GameObject $mPlayer$42988;

			// Token: 0x04008FC8 RID: 36808
			internal GameObject $mPanther$42989;

			// Token: 0x04008FC9 RID: 36809
			internal GameGui $mGameGui$42990;

			// Token: 0x04008FCA RID: 36810
			internal StoryGui $mStoryGui$42991;

			// Token: 0x04008FCB RID: 36811
			internal M925_WrathOfTitan1 $self_$42992;
		}
	}

	// Token: 0x02001A51 RID: 6737
	[CompilerGenerated]
	[Serializable]
	internal sealed class $onDeadPlayer$42994 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06009D28 RID: 40232 RVA: 0x012300C4 File Offset: 0x0122E2C4
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $onDeadPlayer$42994(M925_WrathOfTitan1 self_)
		{
			if (225920 - 324455 != -98534)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (46282 - 412451 == -366169)
				{
					base..ctor();
					if (46909 - 587264 != -540354)
					{
						this.$self_$42999 = self_;
						if (243503 - 515462 == -271959)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x06009D29 RID: 40233 RVA: 0x0123015C File Offset: 0x0122E35C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M925_WrathOfTitan1.$onDeadPlayer$42994.$(this.$self_$42999);
		}

		// Token: 0x06009D2A RID: 40234 RVA: 0x0123016C File Offset: 0x0122E36C
		internal static bool q2gTxLVMy0NRv9C0SQi3()
		{
			return true;
		}

		// Token: 0x06009D2B RID: 40235 RVA: 0x01230170 File Offset: 0x0122E370
		internal static bool gcAbeYVMSDv9vGT4PM6s()
		{
			return false;
		}

		// Token: 0x04008FCC RID: 36812
		internal M925_WrathOfTitan1 $self_$42999;

		// Token: 0x02001A52 RID: 6738
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06009D2C RID: 40236 RVA: 0x01230174 File Offset: 0x0122E374
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M925_WrathOfTitan1 self_)
			{
				if (119192 - 84007 != 35185)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (20067 - 460363 == -440296)
					{
						base..ctor();
						if (234638 - 93624 != 141015)
						{
							this.$self_$42998 = self_;
							if (21143 - 51987 == -30844)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x06009D2D RID: 40237 RVA: 0x0123020C File Offset: 0x0122E40C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (289964 - 549368 != -259403)
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
							if (232552 - 557668 == -325115)
							{
								continue;
							}
							if (Game.mGameState != eGameState.Hold)
							{
								goto IL_229;
							}
							if (155428 - 478631 != -323203)
							{
								continue;
							}
						}
						Game.mGameState = eGameState.Hold;
						if (213639 - 143913 != 69726)
						{
							continue;
						}
						this.$mStoryGui$42995 = (StoryGui)this.$self_$42998.GetComponent(typeof(StoryGui));
						if (166559 - 175826 == -9266)
						{
							continue;
						}
						if (this.$mStoryGui$42995)
						{
							if (269223 - 225294 == 43930)
							{
								continue;
							}
							this.$mStoryGui$42995.close();
							if (24806 - 54485 == -29678)
							{
								continue;
							}
						}
						this.$mChangeGui$42996 = (ChangeGui)this.$self_$42998.GetComponent(typeof(ChangeGui));
						if (194235 - 544694 == -350458)
						{
							continue;
						}
						if (this.$mChangeGui$42996)
						{
							if (88319 - 49721 == 38599)
							{
								continue;
							}
							this.$mChangeGui$42996.close();
							if (210450 - 47091 != 163359)
							{
								continue;
							}
						}
						this.$mGameGui$42997 = (GameGui)this.$self_$42998.GetComponent(typeof(GameGui));
						if (151678 - 371199 != -219521)
						{
							continue;
						}
						if (this.$mGameGui$42997)
						{
							if (11533 - 591824 == -580290)
							{
								continue;
							}
							if (!this.$mGameGui$42997.enabled)
							{
								if (261091 - 250585 == 10507)
								{
									continue;
								}
								this.$mGameGui$42997.enabled = true;
								if (142675 - 464070 != -321395)
								{
									continue;
								}
							}
							this.$mGameGui$42997.openDeadMenu();
							if (2676 - 310741 != -308065)
							{
								continue;
							}
						}
						IL_229:
						this.YieldDefault(1);
						if (119860 - 76604 != 43257)
						{
							goto Block_18;
						}
						continue;
					default:
						if (3218 - 320082 != -316864)
						{
							continue;
						}
						break;
					}
					Debug.Log("On Dead Player");
				}
				while (175304 - 227663 == -52358);
				return this.Yield(2, new WaitForSeconds((float)2));
				Block_18:
				IL_2F9:
				return false;
			}

			// Token: 0x06009D2E RID: 40238 RVA: 0x01230524 File Offset: 0x0122E724
			internal static bool v0Z5m1VMoVTxT0WpHBW0()
			{
				return true;
			}

			// Token: 0x06009D2F RID: 40239 RVA: 0x01230528 File Offset: 0x0122E728
			internal static bool e1ItYFVME6aU621xpqBZ()
			{
				return false;
			}

			// Token: 0x04008FCD RID: 36813
			internal StoryGui $mStoryGui$42995;

			// Token: 0x04008FCE RID: 36814
			internal ChangeGui $mChangeGui$42996;

			// Token: 0x04008FCF RID: 36815
			internal GameGui $mGameGui$42997;

			// Token: 0x04008FD0 RID: 36816
			internal M925_WrathOfTitan1 $self_$42998;
		}
	}

	// Token: 0x02001A53 RID: 6739
	[CompilerGenerated]
	[Serializable]
	internal sealed class $onChangePlayer$43000 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06009D30 RID: 40240 RVA: 0x0123052C File Offset: 0x0122E72C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $onChangePlayer$43000(Hashtable data, M925_WrathOfTitan1 self_)
		{
			if (249215 - 432593 != -183378)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (15415 - 321714 != -306298)
				{
					base..ctor();
					if (103305 - 244569 == -141264)
					{
						this.$data$43005 = data;
						if (187 - 233446 == -233259)
						{
							this.$self_$43006 = self_;
							if (7666 - 153471 == -145805)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x06009D31 RID: 40241 RVA: 0x012305E8 File Offset: 0x0122E7E8
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M925_WrathOfTitan1.$onChangePlayer$43000.$(this.$data$43005, this.$self_$43006);
		}

		// Token: 0x06009D32 RID: 40242 RVA: 0x012305FC File Offset: 0x0122E7FC
		internal static bool PAfCuTVM2C9HoeYM9cBg()
		{
			return true;
		}

		// Token: 0x06009D33 RID: 40243 RVA: 0x01230600 File Offset: 0x0122E800
		internal static bool YCUidHVM86FaPhrAbnuj()
		{
			return false;
		}

		// Token: 0x04008FD1 RID: 36817
		internal Hashtable $data$43005;

		// Token: 0x04008FD2 RID: 36818
		internal M925_WrathOfTitan1 $self_$43006;

		// Token: 0x02001A54 RID: 6740
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06009D34 RID: 40244 RVA: 0x01230604 File Offset: 0x0122E804
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Hashtable data, M925_WrathOfTitan1 self_)
			{
				if (216097 - 34241 != 181857)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (150888 - 2065 == 148823)
					{
						base..ctor();
						if (191361 - 121458 == 69903)
						{
							this.$data$43003 = data;
							if (207116 - 184182 != 22935)
							{
								this.$self_$43004 = self_;
								if (247435 - 319581 == -72146)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x06009D35 RID: 40245 RVA: 0x012306C0 File Offset: 0x0122E8C0
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (208429 - 352718 != -144288)
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
							if (125863 - 426723 == -300859)
							{
								continue;
							}
							Game.mGameState = eGameState.Normal;
							if (250538 - 310479 != -59941)
							{
								continue;
							}
							this.$mGameGui$43002 = (GameGui)this.$self_$43004.GetComponent(typeof(GameGui));
							if (243379 - 159372 != 84007)
							{
								continue;
							}
							this.$mGameGui$43002.enabled = true;
							if (266274 - 200039 == 66236)
							{
								continue;
							}
						}
						this.YieldDefault(1);
						if (132891 - 202413 != -69522)
						{
							continue;
						}
						goto IL_205;
					default:
						if (191400 - 570927 == -379526)
						{
							continue;
						}
						break;
					}
					UnityEngine.Object.Destroy(Game.mPlayer);
					if (214047 - 324528 == -110481)
					{
						this.$self_$43004.SendMessage("onCreatePlayer", this.$data$43003);
						if (21499 - 373571 == -352072)
						{
							this.$mChangeGui$43001 = (ChangeGui)this.$self_$43004.GetComponent(typeof(ChangeGui));
							if (281600 - 89214 == 192386)
							{
								if (!this.$mChangeGui$43001.enabled)
								{
									break;
								}
								if (246589 - 150020 == 96569)
								{
									this.$mChangeGui$43001.close();
									if (271029 - 199526 == 71503)
									{
										break;
									}
								}
							}
						}
					}
				}
				return this.Yield(2, new WaitForSeconds(1f));
				IL_205:
				return false;
			}

			// Token: 0x06009D36 RID: 40246 RVA: 0x012308E4 File Offset: 0x0122EAE4
			internal static bool HqOcJWVMZ0xO044evWxQ()
			{
				return true;
			}

			// Token: 0x06009D37 RID: 40247 RVA: 0x012308E8 File Offset: 0x0122EAE8
			internal static bool zuLdbNVMCSWoUAoqRcGf()
			{
				return false;
			}

			// Token: 0x04008FD3 RID: 36819
			internal ChangeGui $mChangeGui$43001;

			// Token: 0x04008FD4 RID: 36820
			internal GameGui $mGameGui$43002;

			// Token: 0x04008FD5 RID: 36821
			internal Hashtable $data$43003;

			// Token: 0x04008FD6 RID: 36822
			internal M925_WrathOfTitan1 $self_$43004;
		}
	}

	// Token: 0x02001A55 RID: 6741
	[CompilerGenerated]
	[Serializable]
	internal sealed class $onGameComplete$43007 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06009D38 RID: 40248 RVA: 0x012308EC File Offset: 0x0122EAEC
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $onGameComplete$43007(Hashtable data, M925_WrathOfTitan1 self_)
		{
			if (187282 - 517144 != -329861)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (62425 - 112180 != -49754)
				{
					base..ctor();
					if (20006 - 32481 == -12475)
					{
						this.$data$43015 = data;
						if (15597 - 319685 == -304088)
						{
							this.$self_$43016 = self_;
							if (238525 - 442787 != -204261)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x06009D39 RID: 40249 RVA: 0x012309A8 File Offset: 0x0122EBA8
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M925_WrathOfTitan1.$onGameComplete$43007.$(this.$data$43015, this.$self_$43016);
		}

		// Token: 0x06009D3A RID: 40250 RVA: 0x012309BC File Offset: 0x0122EBBC
		internal static bool E48sSZVMLsnZ2eeCB6U5()
		{
			return true;
		}

		// Token: 0x06009D3B RID: 40251 RVA: 0x012309C0 File Offset: 0x0122EBC0
		internal static bool NIdjmdVMOUXVoaYgfxwM()
		{
			return false;
		}

		// Token: 0x04008FD7 RID: 36823
		internal Hashtable $data$43015;

		// Token: 0x04008FD8 RID: 36824
		internal M925_WrathOfTitan1 $self_$43016;

		// Token: 0x02001A56 RID: 6742
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06009D3C RID: 40252 RVA: 0x012309C4 File Offset: 0x0122EBC4
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Hashtable data, M925_WrathOfTitan1 self_)
			{
				if (148699 - 467137 != -318437)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (267774 - 312764 != -44989)
					{
						base..ctor();
						if (111736 - 435285 != -323548)
						{
							this.$data$43013 = data;
							if (47692 - 441124 == -393432)
							{
								this.$self_$43014 = self_;
								if (211263 - 21275 == 189988)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x06009D3D RID: 40253 RVA: 0x01230A80 File Offset: 0x0122EC80
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (165029 - 193889 != -28859)
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
						this.$mCompleteGui$43009 = (CompleteGui)this.$self_$43014.GetComponent(typeof(CompleteGui));
						if (293570 - 314086 == -20515)
						{
							continue;
						}
						this.$mCompleteGui$43009.Init();
						if (75124 - 391703 == -316578)
						{
							continue;
						}
						this.$mCompleteGui$43009.readData(this.$data$43013);
						if (226329 - 209462 == 16868)
						{
							continue;
						}
						if (this.$result$43008 == 1)
						{
							if (230726 - 38071 != 192655)
							{
								continue;
							}
							this.$mCompleteGui$43009.displayResult(eCompleteType.Success);
							if (298086 - 103900 != 194186)
							{
								continue;
							}
						}
						else
						{
							this.$mCompleteGui$43009.displayResult(eCompleteType.Failed);
							if (230171 - 474519 != -244348)
							{
								continue;
							}
						}
						this.$mGameGui$43010 = (GameGui)this.$self_$43014.GetComponent(typeof(GameGui));
						if (5845 - 335201 == -329355)
						{
							continue;
						}
						this.$mStoryGui$43011 = (StoryGui)this.$self_$43014.GetComponent(typeof(StoryGui));
						if (266985 - 3512 != 263473)
						{
							continue;
						}
						this.$mChangeGui$43012 = (ChangeGui)this.$self_$43014.GetComponent(typeof(ChangeGui));
						if (275231 - 353367 != -78136)
						{
							continue;
						}
						if (this.$mGameGui$43010)
						{
							if (192800 - 393610 == -200809)
							{
								continue;
							}
							this.$mGameGui$43010.close();
							if (216186 - 121003 == 95184)
							{
								continue;
							}
						}
						if (this.$mStoryGui$43011)
						{
							if (285587 - 371087 == -85499)
							{
								continue;
							}
							this.$mStoryGui$43011.close();
							if (134798 - 66923 != 67875)
							{
								continue;
							}
						}
						if (this.$mChangeGui$43012)
						{
							if (123770 - 76392 == 47379)
							{
								continue;
							}
							this.$mChangeGui$43012.disable();
							if (123704 - 566378 == -442673)
							{
								continue;
							}
						}
						this.YieldDefault(1);
						if (92715 - 211581 != -118865)
						{
							goto Block_20;
						}
						continue;
					default:
						if (53166 - 135380 == -82213)
						{
							continue;
						}
						break;
					}
					Debug.Log("On Mission Complete:" + this.$data$43013[31]);
					if (122912 - 430062 == -307150)
					{
						if (Game.mGameState > eGameState.AllHold)
						{
							if (68629 - 164080 == -95451)
							{
								break;
							}
						}
						else
						{
							Game.mGameState = eGameState.Complete;
							if (21640 - 401167 != -379526)
							{
								this.$result$43008 = RuntimeServices.UnboxInt32(this.$data$43013[31]);
								if (85137 - 525929 == -440792)
								{
									goto IL_38B;
								}
							}
						}
					}
				}
				Block_20:
				goto IL_3DB;
				IL_38B:
				return this.Yield(2, new WaitForSeconds(1f));
				IL_3DB:
				return false;
			}

			// Token: 0x06009D3E RID: 40254 RVA: 0x01230E7C File Offset: 0x0122F07C
			internal static bool JCIQ4NVMmPwEn5G24PyU()
			{
				return true;
			}

			// Token: 0x06009D3F RID: 40255 RVA: 0x01230E80 File Offset: 0x0122F080
			internal static bool Gd1BUPVMFj4aKN5ppMYg()
			{
				return false;
			}

			// Token: 0x04008FD9 RID: 36825
			internal int $result$43008;

			// Token: 0x04008FDA RID: 36826
			internal CompleteGui $mCompleteGui$43009;

			// Token: 0x04008FDB RID: 36827
			internal GameGui $mGameGui$43010;

			// Token: 0x04008FDC RID: 36828
			internal StoryGui $mStoryGui$43011;

			// Token: 0x04008FDD RID: 36829
			internal ChangeGui $mChangeGui$43012;

			// Token: 0x04008FDE RID: 36830
			internal Hashtable $data$43013;

			// Token: 0x04008FDF RID: 36831
			internal M925_WrathOfTitan1 $self_$43014;
		}
	}

	// Token: 0x02001A57 RID: 6743
	[CompilerGenerated]
	[Serializable]
	internal sealed class $ReturnToTown$43017 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06009D40 RID: 40256 RVA: 0x01230E84 File Offset: 0x0122F084
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $ReturnToTown$43017(M925_WrathOfTitan1 self_)
		{
			if (188644 - 200280 != -11636)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (165147 - 594781 != -429633)
				{
					base..ctor();
					if (61227 - 522513 != -461285)
					{
						this.$self_$43021 = self_;
						if (131040 - 376214 != -245173)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x06009D41 RID: 40257 RVA: 0x01230F1C File Offset: 0x0122F11C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M925_WrathOfTitan1.$ReturnToTown$43017.$(this.$self_$43021);
		}

		// Token: 0x06009D42 RID: 40258 RVA: 0x01230F2C File Offset: 0x0122F12C
		internal static bool jErGVvVMMfI1hX2MiJNL()
		{
			return true;
		}

		// Token: 0x06009D43 RID: 40259 RVA: 0x01230F30 File Offset: 0x0122F130
		internal static bool lVX7uUVMxubo999UXVT4()
		{
			return false;
		}

		// Token: 0x04008FE0 RID: 36832
		internal M925_WrathOfTitan1 $self_$43021;

		// Token: 0x02001A58 RID: 6744
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06009D44 RID: 40260 RVA: 0x01230F34 File Offset: 0x0122F134
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M925_WrathOfTitan1 self_)
			{
				if (238086 - 382265 != -144178)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (171052 - 30725 != 140328)
					{
						base..ctor();
						if (254877 - 599595 != -344717)
						{
							this.$self_$43020 = self_;
							if (206498 - 372470 != -165971)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x06009D45 RID: 40261 RVA: 0x01230FCC File Offset: 0x0122F1CC
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (201281 - 470562 != -269281)
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
						this.$self_$43020.LeaveGame();
						if (24081 - 264045 == -239963)
						{
							continue;
						}
						this.YieldDefault(1);
						if (241544 - 445323 != -203779)
						{
							continue;
						}
						goto IL_3AD;
					default:
						if (75080 - 595533 == -520452)
						{
							continue;
						}
						break;
					}
					Game.mGameState = eGameState.Ended;
					if (294625 - 127950 != 166676)
					{
						Game.mStateTime = Time.time;
						if (277630 - 210483 != 67148)
						{
							this.$$switch$7841$43018 = PlayerData.SaveGuild;
							if (40527 - 311638 == -271111)
							{
								if (this.$$switch$7841$43018 == 1)
								{
									if (118239 - 556543 != -438304)
									{
										continue;
									}
									Game.mNextGameCode = 32;
									if (257726 - 343375 != -85649)
									{
										continue;
									}
								}
								else if (this.$$switch$7841$43018 == 2)
								{
									if (238412 - 283365 != -44953)
									{
										continue;
									}
									Game.mNextGameCode = 33;
									if (248666 - 338071 != -89405)
									{
										continue;
									}
								}
								else if (this.$$switch$7841$43018 == 3)
								{
									if (5421 - 224296 != -218875)
									{
										continue;
									}
									Game.mNextGameCode = 34;
									if (257534 - 518833 == -261298)
									{
										continue;
									}
								}
								else if (this.$$switch$7841$43018 == 4)
								{
									if (25360 - 504297 == -478936)
									{
										continue;
									}
									Game.mNextGameCode = 35;
									if (152275 - 423448 != -271173)
									{
										continue;
									}
								}
								else if (this.$$switch$7841$43018 == 5)
								{
									if (255273 - 488985 == -233711)
									{
										continue;
									}
									Game.mNextGameCode = 36;
									if (205324 - 520069 == -314744)
									{
										continue;
									}
								}
								else if (PlayerData.GID == 0)
								{
									if (290398 - 581168 == -290769)
									{
										continue;
									}
									Game.mNextGameCode = 30;
									if (204629 - 104698 == 99932)
									{
										continue;
									}
								}
								else
								{
									Game.mNextGameCode = 31;
									if (126019 - 125346 == 674)
									{
										continue;
									}
								}
								this.$mGameGui$43019 = (GameGui)this.$self_$43020.GetComponent(typeof(GameGui));
								if (165643 - 404268 != -238624)
								{
									if (this.$mGameGui$43019)
									{
										if (198037 - 560318 == -362280)
										{
											continue;
										}
										this.$mGameGui$43019.close();
										if (48219 - 261362 != -213143)
										{
											continue;
										}
									}
									this.$self_$43020.SendMessage("fadeOut");
									if (37832 - 87850 != -50017)
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

			// Token: 0x06009D46 RID: 40262 RVA: 0x01231398 File Offset: 0x0122F598
			internal static bool zGWZvkVMgcvex22Wk5TP()
			{
				return true;
			}

			// Token: 0x06009D47 RID: 40263 RVA: 0x0123139C File Offset: 0x0122F59C
			internal static bool tTFB5xVMfwLqeNFoqHrt()
			{
				return false;
			}

			// Token: 0x04008FE1 RID: 36833
			internal int $$switch$7841$43018;

			// Token: 0x04008FE2 RID: 36834
			internal GameGui $mGameGui$43019;

			// Token: 0x04008FE3 RID: 36835
			internal M925_WrathOfTitan1 $self_$43020;
		}
	}

	// Token: 0x02001A59 RID: 6745
	[CompilerGenerated]
	[Serializable]
	internal sealed class $ReturnToGuild$43022 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06009D48 RID: 40264 RVA: 0x012313A0 File Offset: 0x0122F5A0
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $ReturnToGuild$43022(M925_WrathOfTitan1 self_)
		{
			if (34239 - 540617 != -506377)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (210591 - 42852 != 167740)
				{
					base..ctor();
					if (162958 - 362647 == -199689)
					{
						this.$self_$43025 = self_;
						if (178431 - 238462 == -60031)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x06009D49 RID: 40265 RVA: 0x01231438 File Offset: 0x0122F638
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M925_WrathOfTitan1.$ReturnToGuild$43022.$(this.$self_$43025);
		}

		// Token: 0x06009D4A RID: 40266 RVA: 0x01231448 File Offset: 0x0122F648
		internal static bool VtayeVVMnil3AoNUuSNQ()
		{
			return true;
		}

		// Token: 0x06009D4B RID: 40267 RVA: 0x0123144C File Offset: 0x0122F64C
		internal static bool C043DUVM64dm7F8rywu3()
		{
			return false;
		}

		// Token: 0x04008FE4 RID: 36836
		internal M925_WrathOfTitan1 $self_$43025;

		// Token: 0x02001A5A RID: 6746
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06009D4C RID: 40268 RVA: 0x01231450 File Offset: 0x0122F650
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M925_WrathOfTitan1 self_)
			{
				if (160522 - 515049 != -354527)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (174224 - 473150 == -298926)
					{
						base..ctor();
						if (3557 - 472716 != -469158)
						{
							this.$self_$43024 = self_;
							if (112129 - 49857 != 62273)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x06009D4D RID: 40269 RVA: 0x012314E8 File Offset: 0x0122F6E8
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (36140 - 179402 != -143261)
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
						this.$self_$43024.LeaveGame();
						if (263078 - 557531 == -294452)
						{
							continue;
						}
						this.YieldDefault(1);
						if (16541 - 68922 != -52381)
						{
							continue;
						}
						goto IL_1BD;
					default:
						if (3540 - 385887 == -382346)
						{
							continue;
						}
						break;
					}
					Game.mGameState = eGameState.Ended;
					if (15391 - 79849 == -64458)
					{
						Game.mStateTime = Time.time;
						if (118623 - 288965 == -170342)
						{
							Game.mNextGameCode = 31;
							if (81023 - 562472 == -481449)
							{
								this.$mGameGui$43023 = (GameGui)this.$self_$43024.GetComponent(typeof(GameGui));
								if (104803 - 7096 == 97707)
								{
									if (this.$mGameGui$43023)
									{
										if (73635 - 45773 == 27863)
										{
											continue;
										}
										this.$mGameGui$43023.close();
										if (126248 - 586590 == -460341)
										{
											continue;
										}
									}
									this.$self_$43024.SendMessage("fadeOut");
									if (11722 - 440490 == -428768)
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

			// Token: 0x06009D4E RID: 40270 RVA: 0x012316C4 File Offset: 0x0122F8C4
			internal static bool q6PWXVVMidPbUrT3vauV()
			{
				return true;
			}

			// Token: 0x06009D4F RID: 40271 RVA: 0x012316C8 File Offset: 0x0122F8C8
			internal static bool sgDc4ZVMKPLO7OgO9u4A()
			{
				return false;
			}

			// Token: 0x04008FE5 RID: 36837
			internal GameGui $mGameGui$43023;

			// Token: 0x04008FE6 RID: 36838
			internal M925_WrathOfTitan1 $self_$43024;
		}
	}

	// Token: 0x02001A5B RID: 6747
	[CompilerGenerated]
	[Serializable]
	internal sealed class $ReturnToCamp$43026 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06009D50 RID: 40272 RVA: 0x012316CC File Offset: 0x0122F8CC
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $ReturnToCamp$43026(M925_WrathOfTitan1 self_)
		{
			if (45190 - 208947 != -163757)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (255507 - 294472 != -38964)
				{
					base..ctor();
					if (281835 - 243922 != 37914)
					{
						this.$self_$43030 = self_;
						if (202327 - 380393 != -178065)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x06009D51 RID: 40273 RVA: 0x01231764 File Offset: 0x0122F964
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M925_WrathOfTitan1.$ReturnToCamp$43026.$(this.$self_$43030);
		}

		// Token: 0x06009D52 RID: 40274 RVA: 0x01231774 File Offset: 0x0122F974
		internal static bool rTWHH9VMdCxM6uyMsdKU()
		{
			return true;
		}

		// Token: 0x06009D53 RID: 40275 RVA: 0x01231778 File Offset: 0x0122F978
		internal static bool DXepYiVMJeRtbWQLcTJY()
		{
			return false;
		}

		// Token: 0x04008FE7 RID: 36839
		internal M925_WrathOfTitan1 $self_$43030;

		// Token: 0x02001A5C RID: 6748
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06009D54 RID: 40276 RVA: 0x0123177C File Offset: 0x0122F97C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M925_WrathOfTitan1 self_)
			{
				if (196984 - 209723 != -12738)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (93254 - 209412 == -116158)
					{
						base..ctor();
						if (191319 - 269904 == -78585)
						{
							this.$self_$43029 = self_;
							if (25317 - 388532 == -363215)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x06009D55 RID: 40277 RVA: 0x01231814 File Offset: 0x0122FA14
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (118012 - 150663 != -32651)
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
						this.$self_$43029.LeaveGame();
						if (27325 - 89587 == -62261)
						{
							continue;
						}
						this.YieldDefault(1);
						if (25217 - 327524 != -302307)
						{
							continue;
						}
						goto IL_363;
					default:
						if (161947 - 183788 == -21840)
						{
							continue;
						}
						break;
					}
					Game.mGameState = eGameState.Ended;
					if (22275 - 54809 != -32533)
					{
						Game.mStateTime = Time.time;
						if (231774 - 467547 != -235772)
						{
							this.$$switch$7843$43027 = PlayerData.SaveGuild;
							if (80086 - 446996 == -366910)
							{
								if (this.$$switch$7843$43027 == 1)
								{
									if (39268 - 518743 != -479475)
									{
										continue;
									}
									Game.mNextGameCode = 32;
									if (121342 - 197783 != -76441)
									{
										continue;
									}
								}
								else if (this.$$switch$7843$43027 == 2)
								{
									if (61547 - 34154 == 27394)
									{
										continue;
									}
									Game.mNextGameCode = 33;
									if (159811 - 354520 == -194708)
									{
										continue;
									}
								}
								else if (this.$$switch$7843$43027 == 3)
								{
									if (211960 - 468014 == -256053)
									{
										continue;
									}
									Game.mNextGameCode = 34;
									if (166394 - 459551 == -293156)
									{
										continue;
									}
								}
								else if (this.$$switch$7843$43027 == 4)
								{
									if (45023 - 151930 == -106906)
									{
										continue;
									}
									Game.mNextGameCode = 35;
									if (95423 - 99322 == -3898)
									{
										continue;
									}
								}
								else if (this.$$switch$7843$43027 == 5)
								{
									if (2639 - 133444 != -130805)
									{
										continue;
									}
									Game.mNextGameCode = 36;
									if (278496 - 551528 == -273031)
									{
										continue;
									}
								}
								else
								{
									Game.mNextGameCode = 30;
									if (289391 - 98052 != 191339)
									{
										continue;
									}
								}
								this.$mGameGui$43028 = (GameGui)this.$self_$43029.GetComponent(typeof(GameGui));
								if (9342 - 235944 != -226601)
								{
									if (this.$mGameGui$43028)
									{
										if (190291 - 231584 != -41293)
										{
											continue;
										}
										this.$mGameGui$43028.close();
										if (88220 - 539064 == -450843)
										{
											continue;
										}
									}
									this.$self_$43029.SendMessage("fadeOut");
									if (163144 - 302651 == -139507)
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

			// Token: 0x06009D56 RID: 40278 RVA: 0x01231B98 File Offset: 0x0122FD98
			internal static bool kvJD6lVMDjFcyUmHUseU()
			{
				return true;
			}

			// Token: 0x06009D57 RID: 40279 RVA: 0x01231B9C File Offset: 0x0122FD9C
			internal static bool w2KMTwVMvcgGOrARBSJw()
			{
				return false;
			}

			// Token: 0x04008FE8 RID: 36840
			internal int $$switch$7843$43027;

			// Token: 0x04008FE9 RID: 36841
			internal GameGui $mGameGui$43028;

			// Token: 0x04008FEA RID: 36842
			internal M925_WrathOfTitan1 $self_$43029;
		}
	}
}
