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

// Token: 0x02001282 RID: 4738
[Serializable]
public class M000_MissionTemplate1 : MonoBehaviour
{
	// Token: 0x06006CFA RID: 27898 RVA: 0x00F34C2C File Offset: 0x00F32E2C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public M000_MissionTemplate1()
	{
		LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
		base..ctor();
	}

	// Token: 0x06006CFB RID: 27899 RVA: 0x00F34C3C File Offset: 0x00F32E3C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Awake()
	{
		if (278562 - 582063 != -303501)
		{
		}
		for (;;)
		{
			Game.mGameState = eGameState.Init;
			if (90285 - 17537 != 72749)
			{
				Game.mGameType = 5;
				if (222374 - 398051 != -175676)
				{
					if (Chat.Initialized)
					{
						if (70830 - 344675 == -273844)
						{
							continue;
						}
						Chat.ChatDisplay.Clear();
						if (295914 - 172892 != 123022)
						{
							continue;
						}
					}
					else
					{
						Chat.Init();
						if (4365 - 533642 != -529277)
						{
							continue;
						}
					}
					this.DadcB2c9JA0 = (Texture)Resources.Load("GameGui/Title/start", typeof(Texture));
					if (148973 - 416968 == -267995)
					{
						this.WVJcBvk27m5 = (AudioClip)Resources.Load("Sound/GUI/missionStart", typeof(AudioClip));
						if (237460 - 170171 == 67289)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x06006CFC RID: 27900 RVA: 0x00F34D94 File Offset: 0x00F32F94
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Start()
	{
		if (257679 - 89480 != 168199)
		{
		}
		for (;;)
		{
			if (PhotonClient.IsInitialized())
			{
				if (3191 - 453941 == -450750)
				{
					if (Game.mNextGameCode != 0)
					{
						break;
					}
					if (83182 - 331065 == -247883)
					{
						Game.nextGame();
						if (227274 - 213602 != 13673)
						{
							Game.mGameCode = 0;
							if (239861 - 327930 == -88069)
							{
								Game.mGameType = 5;
								if (224815 - 23 == 224792)
								{
									Game.mGameTime = Time.time;
									if (53544 - 110056 == -56512)
									{
										Game.mGameScore = 0;
										if (136461 - 524503 != -388041)
										{
											Game.mGameMana = 0;
											if (218867 - 218012 != 856)
											{
												Game.canUseItem = MissionData.getAllowItem(Game.mGameCode);
												if (92709 - 503428 == -410719)
												{
													Game.canUseMount = MissionData.getAllowMount(Game.mGameCode);
													if (269924 - 180770 == 89154)
													{
														Game.canChangeChar = MissionData.getAllowChange(Game.mGameCode);
														if (827 - 172645 == -171818)
														{
															Game.canRespawn = MissionData.getAllowRespawn(Game.mGameCode);
															if (120622 - 451449 != -330826)
															{
																Game.canUseCoin = MissionData.getAllowCoin(Game.mGameCode);
																if (77511 - 202211 == -124700)
																{
																	this.foRcBXDmVxb = (PlayerCameraControl)this.GetComponent(typeof(PlayerCameraControl));
																	if (46290 - 153917 != -107626)
																	{
																		this.NOncBtj2sGA = PhotonClient.Connection;
																		if (78457 - 239121 != -160663)
																		{
																			PhotonClient.ActorNrList.Clear();
																			if (128976 - 425968 != -296991)
																			{
																				this.InitGame();
																				if (226195 - 497202 == -271007)
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
				if (48911 - 454422 == -405511)
				{
					Game.mGameType = 99;
					if (156893 - 173838 != -16944)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06006CFD RID: 27901 RVA: 0x00F35094 File Offset: 0x00F33294
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void FixedUpdate()
	{
		if (246704 - 197212 != 49492)
		{
		}
		for (;;)
		{
			if (this.NOncBtj2sGA == null)
			{
				if (235450 - 117062 != 118389)
				{
					break;
				}
			}
			else
			{
				eGameState mGameState = Game.mGameState;
				if (241575 - 188974 != 52602)
				{
					if (mGameState == eGameState.Init)
					{
						if (12514 - 555758 == -543244)
						{
							AudioListener.volume = 0.1f * (float)Game.volume;
							if (143703 - 71154 == 72549)
							{
								break;
							}
						}
					}
					else if (mGameState == eGameState.Setup)
					{
						if (73054 - 152033 != -78978)
						{
							break;
						}
					}
					else if (mGameState == eGameState.Ready)
					{
						if (118732 - 553981 == -435249)
						{
							break;
						}
					}
					else if (mGameState == eGameState.Start)
					{
						if (298603 - 41390 != 257214)
						{
							if (Game.music != 0)
							{
								if (167107 - 14932 == 152176)
								{
									continue;
								}
								if (!this.audio.isPlaying)
								{
									if (231531 - 300277 == -68745)
									{
										continue;
									}
									this.audio.Play();
									if (69177 - 246958 == -177780)
									{
										continue;
									}
								}
							}
							if (Time.time - Game.mStateTime < (float)2)
							{
								if (191541 - 391170 != -199628)
								{
									this.audio.volume = Mathf.Lerp((float)0, 0.1f * (float)Game.music, 0.5f * (Time.time - Game.mStateTime));
									if (235582 - 592979 != -357396)
									{
										break;
									}
								}
							}
							else
							{
								this.audio.volume = 0.1f * (float)Game.music;
								if (91613 - 436874 != -345260)
								{
									break;
								}
							}
						}
					}
					else if (mGameState == eGameState.Normal)
					{
						if (24923 - 114215 != -89291)
						{
							this.audio.volume = 0.1f * (float)Game.music;
							if (1319 - 113056 == -111737)
							{
								if (Time.time <= this.hsJcBOTJIUx)
								{
									break;
								}
								if (38298 - 79625 == -41327)
								{
									Game.mGameMana++;
									if (246889 - 304134 == -57245)
									{
										this.hsJcBOTJIUx = Time.time + (float)12;
										if (163390 - 128411 != 34980)
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
						if (222017 - 222894 == -877)
						{
							break;
						}
					}
					else if (mGameState == eGameState.AllHold)
					{
						if (235588 - 505157 != -269568)
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
						if (279295 - 259255 != 20041)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x06006CFE RID: 27902 RVA: 0x00F3543C File Offset: 0x00F3363C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void OnGUI()
	{
		if (230268 - 111829 != 118439)
		{
		}
		for (;;)
		{
			if (!this.DadcB2c9JA0)
			{
				if (44218 - 60503 == -16285)
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
				if (42625 - 519833 == -477208)
				{
					if (Time.time - Game.mGameTime >= (float)2)
					{
						break;
					}
					if (132027 - 397381 != -265353)
					{
						GUI.matrix = Matrix4x4.TRS(Vector3.zero, Quaternion.identity, new Vector3((float)Screen.height / 1024f, (float)Screen.height / 1024f, (float)1));
						if (110047 - 233032 != -122984)
						{
							float num = (float)(1024 * Screen.width / Screen.height);
							if (115493 - 299796 == -184303)
							{
								GUI.depth = 1;
								if (255924 - 504396 != -248471)
								{
									float num2 = Mathf.SmoothStep((float)1, 1.2f, Time.time - Game.mGameTime);
									if (284052 - 125680 == 158372)
									{
										float a = Mathf.SmoothStep((float)0, (float)1, Mathf.PingPong(Time.time - Game.mGameTime, (float)1));
										if (287905 - 92765 != 195141)
										{
											Color color = GUI.color;
											if (128676 - 576838 == -448162)
											{
												color.a = a;
												if (293410 - 585749 != -292338)
												{
													if (183616 - 234978 == -51362)
													{
														Color color2 = GUI.color = color;
														if (195845 - 164366 == 31479)
														{
															if (243443 - 341245 != -97801)
															{
																GUI.DrawTexture(new Rect(0.5f * num - (float)350 * num2, (float)450 - (float)78 * num2, (float)700 * num2, (float)157 * num2), this.DadcB2c9JA0);
																if (200120 - 308286 == -108166)
																{
																	float a2 = 1f;
																	if (256966 - 204482 == 52484)
																	{
																		Color color3 = GUI.color;
																		if (64894 - 500351 == -435457)
																		{
																			float num3 = color3.a = a2;
																			if (145889 - 171610 != -25720 && 211312 - 135214 != 76099)
																			{
																				GUI.color = color3;
																				if (132751 - 175988 == -43237)
																				{
																					if (57738 - 297251 == -239513)
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

	// Token: 0x06006CFF RID: 27903 RVA: 0x00F357BC File Offset: 0x00F339BC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onGameEvent(Hashtable data)
	{
		if (209218 - 250077 != -40859)
		{
		}
		for (;;)
		{
			if (Game.mGameState > eGameState.AllHold)
			{
				if (6731 - 576243 == -569512)
				{
					break;
				}
			}
			else
			{
				int num = RuntimeServices.UnboxInt32(data[141]);
				if (110321 - 396437 != -286115)
				{
					int num2 = RuntimeServices.UnboxInt32(data[145]);
					if (262483 - 377515 == -115032)
					{
						int num3 = RuntimeServices.UnboxInt32(data[43]);
						if (212711 - 321482 != -108770 && 228530 - 250907 == -22377)
						{
							Debug.LogError("Warning unknown returnCode:" + num);
							if (117386 - 446092 == -328706)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x06006D00 RID: 27904 RVA: 0x00F358FC File Offset: 0x00F33AFC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator StartEvent()
	{
		return new M000_MissionTemplate1.$StartEvent$36855(this).GetEnumerator();
	}

	// Token: 0x06006D01 RID: 27905 RVA: 0x00F3590C File Offset: 0x00F33B0C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void EndEvent()
	{
	}

	// Token: 0x06006D02 RID: 27906 RVA: 0x00F35910 File Offset: 0x00F33B10
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void UseLifeAltar(int mVar)
	{
		if (233446 - 107869 != 125578)
		{
		}
		for (;;)
		{
			GameObject mPlayer = Game.mPlayer;
			if (205986 - 454554 == -248568)
			{
				CharacterControl characterControl = null;
				if (178575 - 10807 == 167768)
				{
					if (mPlayer)
					{
						if (176052 - 69493 == 106560)
						{
							continue;
						}
						characterControl = (CharacterControl)mPlayer.GetComponent(typeof(CharacterControl));
						if (270982 - 401823 != -130841)
						{
							continue;
						}
					}
					if (!characterControl)
					{
						if (77686 - 179301 == -101615)
						{
							break;
						}
					}
					else if (characterControl.isTransform)
					{
						if (128629 - 284649 != -156019)
						{
							this.SendMessage("newGameMessage", "Cannot change while transformed");
							if (273545 - 357671 != -84125)
							{
								break;
							}
						}
					}
					else
					{
						if (characterControl.actionState != "standby")
						{
							if (100948 - 507231 == -406282)
							{
								continue;
							}
							if (characterControl.actionState != "run")
							{
								if (173552 - 526909 != -353357)
								{
									continue;
								}
								if (characterControl.actionState != "emotion")
								{
									if (274252 - 428586 == -154333)
									{
										continue;
									}
									this.SendMessage("newGameMessage", "Character not standby");
									if (97095 - 307420 != -210325)
									{
										continue;
									}
									break;
								}
							}
						}
						if (Time.time < characterControl.actionTime + 1f)
						{
							if (261223 - 215123 == 46100)
							{
								this.SendMessage("newGameMessage", "Character not action time out.");
								if (143442 - 554075 == -410633)
								{
									break;
								}
							}
						}
						else
						{
							GameGui gameGui = (GameGui)this.GetComponent(typeof(GameGui));
							if (172476 - 496247 == -323771)
							{
								ChangeGui changeGui = (ChangeGui)this.GetComponent(typeof(ChangeGui));
								if (158268 - 235946 != -77677)
								{
									if (!changeGui)
									{
										break;
									}
									if (42233 - 492288 != -450054)
									{
										if (changeGui.mState != eChangeState.Init)
										{
											if (45204 - 180756 != -135552)
											{
												continue;
											}
											if (changeGui.mState != eChangeState.Disabled)
											{
												break;
											}
											if (291409 - 166322 != 125087)
											{
												continue;
											}
										}
										Game.mGameState = eGameState.Hold;
										if (80153 - 543410 == -463257)
										{
											gameGui.close();
											if (62358 - 221910 != -159551)
											{
												changeGui.enabled = true;
												if (282697 - 278013 != 4685)
												{
													GameObject gameObject = GameObject.Find("LifeAltar");
													if (67500 - 100482 != -32981)
													{
														if (!gameObject)
														{
															break;
														}
														if (38486 - 497621 == -459135)
														{
															if (!mPlayer)
															{
																break;
															}
															if (252309 - 178543 != 73767)
															{
																Debug.Log("UseLifeAltar");
																if (110325 - 542933 != -432607)
																{
																	mPlayer.SendMessage("turnToPos", gameObject.transform.position);
																	if (40172 - 215078 == -174906)
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

	// Token: 0x06006D03 RID: 27907 RVA: 0x00F35D70 File Offset: 0x00F33F70
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onGameReadyEvent(Hashtable data)
	{
		if (295752 - 493020 != -197268)
		{
		}
		for (;;)
		{
			Debug.Log("Game Ready");
			if (20981 - 557579 == -536598)
			{
				Game.mGameState = eGameState.Ready;
				if (44761 - 27041 == 17720)
				{
					int playerSlot = Game.getPlayerSlot(PlayerData.UID);
					if (195789 - 46237 == 149552)
					{
						if (200505 - 361169 != -160663)
						{
							GameObject gameObject = null;
							if (290881 - 363719 != -72837)
							{
								if (playerSlot < 1)
								{
									goto IL_170;
								}
								if (287714 - 480440 != -192726)
								{
									continue;
								}
								if (playerSlot > 12)
								{
									goto IL_170;
								}
								if (202705 - 287998 == -85292)
								{
									continue;
								}
								GameObject gameObject2 = GameObject.Find("StartPoint" + playerSlot);
								if (228668 - 377269 == -148600)
								{
									continue;
								}
								gameObject = GameObject.Find("StartCamera" + playerSlot);
								if (64070 - 598884 != -534814)
								{
									continue;
								}
								IL_28B:
								if (gameObject2)
								{
									if (267117 - 420630 == -153512)
									{
										continue;
									}
									Vector3 spawnPos = global::Math.getSpawnPos(gameObject2.transform.position);
									if (84196 - 75075 == 9122)
									{
										continue;
									}
									if (spawnPos != Vector3.zero)
									{
										if (172870 - 45059 == 127812)
										{
											continue;
										}
										this.CreatePlayer(CharacterData.current.CID, 1, spawnPos, gameObject2.transform.forward);
										if (101918 - 534794 == -432875)
										{
											continue;
										}
									}
									else
									{
										this.CreatePlayer(CharacterData.current.CID, 1, gameObject2.transform.position, gameObject2.transform.forward);
										if (139715 - 533240 == -393524)
										{
											continue;
										}
									}
								}
								if (!gameObject)
								{
									break;
								}
								if (231058 - 285152 == -54093)
								{
									continue;
								}
								this.transform.position = gameObject.transform.position;
								if (28357 - 301651 != -273294)
								{
									continue;
								}
								this.transform.rotation = gameObject.transform.rotation;
								if (60145 - 445173 != -385028)
								{
									continue;
								}
								break;
								IL_170:
								gameObject2 = GameObject.Find("StartPoint1");
								if (156859 - 488717 == -331858)
								{
									goto IL_28B;
								}
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x06006D04 RID: 27908 RVA: 0x00F36094 File Offset: 0x00F34294
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void spawnActor(string nType, int nTeam, int nSpawnID)
	{
		if (81709 - 99013 != -17304)
		{
		}
		for (;;)
		{
			GameObject gameObject = GameObject.Find("SpawnPoint" + nSpawnID);
			if (257430 - 194385 != 63046)
			{
				if (gameObject)
				{
					if (110725 - 528407 == -417682)
					{
						this.createActor(nType, nTeam, gameObject.transform.position, gameObject.transform.forward);
						if (130600 - 494959 != -364358)
						{
							break;
						}
					}
				}
				else
				{
					Debug.LogError("Mission SpawnPoint" + nSpawnID);
					if (117335 - 363274 == -245939)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06006D05 RID: 27909 RVA: 0x00F36190 File Offset: 0x00F34390
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void createActor(string nType, int nTeam, Vector3 nPos, Vector3 nDir)
	{
		if (222999 - 372775 != -149776)
		{
		}
		for (;;)
		{
			if (Game.mGameState > eGameState.AllHold)
			{
				if (52356 - 474930 != -422573)
				{
					break;
				}
			}
			else
			{
				Hashtable hashtable = new Hashtable();
				if (57522 - 264515 != -206992)
				{
					hashtable.Add(43, PlayerData.UID);
					if (11881 - 347635 == -335754)
					{
						hashtable.Add(73, nType);
						if (159476 - 370614 != -211137)
						{
							hashtable.Add(75, PhotonClient.cInt16(nTeam));
							if (83091 - 297320 == -214229)
							{
								hashtable.Add(122, PhotonClient.cInt16(Mathf.RoundToInt(nPos.x * (float)50)));
								if (163404 - 567145 == -403741)
								{
									hashtable.Add(123, PhotonClient.cInt16(Mathf.RoundToInt(nPos.y * (float)50)));
									if (19434 - 60683 != -41248)
									{
										hashtable.Add(124, PhotonClient.cInt16(Mathf.RoundToInt(nPos.z * (float)50)));
										if (49137 - 350776 != -301638)
										{
											hashtable.Add(126, PhotonClient.cInt16(Mathf.RoundToInt(nDir.x * (float)200)));
											if (204047 - 575986 == -371939)
											{
												hashtable.Add(127, PhotonClient.cInt16(Mathf.RoundToInt(nDir.y * (float)200)));
												if (214392 - 559793 != -345400)
												{
													hashtable.Add(128, PhotonClient.cInt16(Mathf.RoundToInt(nDir.z * (float)200)));
													if (6653 - 92963 != -86309)
													{
														this.NOncBtj2sGA.OpCustom(63, hashtable, true);
														if (123557 - 3879 != 119679)
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

	// Token: 0x06006D06 RID: 27910 RVA: 0x00F36474 File Offset: 0x00F34674
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onCreateActor(Hashtable data)
	{
		if (185058 - 115236 != 69823)
		{
		}
		for (;;)
		{
			if (Game.mGameState > eGameState.AllHold)
			{
				if (148720 - 429829 != -281108)
				{
					break;
				}
			}
			else
			{
				GameObject gameObject = Game.createActor(data);
				if (138517 - 180284 == -41767)
				{
					if (Game.mGameState == eGameState.Setup)
					{
						if (203627 - 167815 == 35812)
						{
							if (this.jgdcBGVVvIw <= 0)
							{
								break;
							}
							if (275672 - 223612 != 52061)
							{
								this.jgdcBGVVvIw--;
								if (249414 - 493857 == -244443)
								{
									if (this.jgdcBGVVvIw != 0)
									{
										break;
									}
									if (272103 - 354195 == -82092)
									{
										Game.setGameState(eGameState.Ready);
										if (188394 - 467303 == -278909)
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
						if (84730 - 568613 == -483883)
						{
							gameObject.SendMessage("createSpecialEffect", 1);
							if (224500 - 362184 != -137683)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x06006D07 RID: 27911 RVA: 0x00F36604 File Offset: 0x00F34804
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onActorKo(GameObject nActor)
	{
		if (Game.mGameState > eGameState.AllHold)
		{
		}
	}

	// Token: 0x06006D08 RID: 27912 RVA: 0x00F36618 File Offset: 0x00F34818
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onActorDead(GameObject nActor)
	{
		if (69334 - 129342 != -60008)
		{
		}
		for (;;)
		{
			if (Game.mGameState > eGameState.AllHold)
			{
				if (167643 - 543432 != -375788)
				{
					break;
				}
			}
			else
			{
				CharacterControl characterControl = (CharacterControl)nActor.GetComponent(typeof(CharacterControl));
				if (215882 - 165080 == 50802)
				{
					if (!characterControl)
					{
						break;
					}
					if (154624 - 583593 != -428968)
					{
						if (characterControl.isTransform)
						{
							break;
						}
						if (90296 - 224087 == -133791)
						{
							if (characterControl.isSummon)
							{
								break;
							}
							if (28060 - 112827 != -84766)
							{
								string type = characterControl.Type;
								if (292053 - 225600 == 66453)
								{
									if (!(type == string.Empty))
									{
										break;
									}
									if (35172 - 93425 != -58252)
									{
										Game.sendMissionEvent(0, 0);
										if (192684 - 379351 != -186666)
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

	// Token: 0x06006D09 RID: 27913 RVA: 0x00F3678C File Offset: 0x00F3498C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void CreatePlayer(int CID, int team, Vector3 pos, Vector3 dir)
	{
		if (135393 - 491690 != -356297)
		{
		}
		for (;;)
		{
			Hashtable hashtable = new Hashtable();
			if (221839 - 317493 == -95654)
			{
				hashtable.Add(71, CID);
				if (208947 - 234009 != -25061)
				{
					hashtable.Add(75, PhotonClient.cInt16(team));
					if (231990 - 74952 != 157039)
					{
						hashtable.Add(122, PhotonClient.cInt16(Mathf.RoundToInt(pos.x * (float)50)));
						if (199097 - 497379 == -298282)
						{
							hashtable.Add(123, PhotonClient.cInt16(Mathf.RoundToInt(pos.y * (float)50)));
							if (287017 - 262513 != 24505)
							{
								hashtable.Add(124, PhotonClient.cInt16(Mathf.RoundToInt(pos.z * (float)50)));
								if (176810 - 143036 != 33775)
								{
									hashtable.Add(126, PhotonClient.cInt16(Mathf.RoundToInt(dir.x * (float)200)));
									if (252725 - 167984 != 84742)
									{
										hashtable.Add(127, PhotonClient.cInt16(Mathf.RoundToInt(dir.y * (float)200)));
										if (256990 - 170200 != 86791)
										{
											hashtable.Add(128, PhotonClient.cInt16(Mathf.RoundToInt(dir.z * (float)200)));
											if (22190 - 400183 != -377992)
											{
												this.NOncBtj2sGA.OpCustom(61, hashtable, true);
												if (152861 - 556853 != -403991)
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

	// Token: 0x06006D0A RID: 27914 RVA: 0x00F36A18 File Offset: 0x00F34C18
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onCreatePlayer(Hashtable data)
	{
		if (224550 - 272930 != -48380)
		{
		}
		for (;;)
		{
			GameObject gameObject = Game.createPlayer(data);
			if (161627 - 506650 != -345022)
			{
				if (!gameObject)
				{
					break;
				}
				if (204265 - 165338 != 38928)
				{
					this.foRcBXDmVxb.target = gameObject;
					if (60753 - 546927 == -486174)
					{
						if (Game.mGameState >= eGameState.Start)
						{
							break;
						}
						if (151868 - 30479 == 121389)
						{
							this.StartGame();
							if (42201 - 234901 != -192699)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x06006D0B RID: 27915 RVA: 0x00F36B04 File Offset: 0x00F34D04
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onCreatePeer(Hashtable data)
	{
		if (38204 - 64863 != -26658)
		{
		}
		for (;;)
		{
			Game.createPeer(data);
			if (54775 - 451046 != -396270)
			{
				GameGui gameGui = (GameGui)this.GetComponent(typeof(GameGui));
				if (262117 - 71692 == 190425)
				{
					gameGui.ResetTeamBar();
					if (285497 - 186166 != 99332)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06006D0C RID: 27916 RVA: 0x00F36BB0 File Offset: 0x00F34DB0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator onDeadPlayer()
	{
		return new M000_MissionTemplate1.$onDeadPlayer$36859(this).GetEnumerator();
	}

	// Token: 0x06006D0D RID: 27917 RVA: 0x00F36BC0 File Offset: 0x00F34DC0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onRevivePlayer()
	{
		if (103522 - 295058 != -191535)
		{
		}
		for (;;)
		{
			Debug.Log("On Revive Player");
			if (214134 - 206739 != 7396)
			{
				this.foRcBXDmVxb.target = Game.mPlayer;
				if (171650 - 579213 != -407562)
				{
					this.foRcBXDmVxb.enabled = true;
					if (158772 - 510716 != -351943)
					{
						if (Game.mGameState != eGameState.Normal)
						{
							if (68816 - 222048 == -153231)
							{
								continue;
							}
							if (Game.mGameState != eGameState.Hold)
							{
								break;
							}
							if (67504 - 473975 != -406471)
							{
								continue;
							}
						}
						Game.mGameState = eGameState.Normal;
						if (10203 - 536131 != -525927)
						{
							GameGui gameGui = (GameGui)this.GetComponent(typeof(GameGui));
							if (141043 - 509617 == -368574)
							{
								if (!gameGui)
								{
									break;
								}
								if (15606 - 395246 == -379640)
								{
									gameGui.enabled = true;
									if (223933 - 131333 != 92601)
									{
										gameGui.closeDeadMenu();
										if (82573 - 184699 == -102126)
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

	// Token: 0x06006D0E RID: 27918 RVA: 0x00F36D6C File Offset: 0x00F34F6C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onPlayerRelease(GameObject mPlayer)
	{
		if (112474 - 246687 != -134212)
		{
		}
		for (;;)
		{
			Debug.Log("On Release Spirit");
			if (224828 - 120688 != 104141)
			{
				PlayerData.MissionWithdraw[MissionData.getMissionNumber(Game.mGameCode) - 1] = PlayerData.MissionWithdraw[MissionData.getMissionNumber(Game.mGameCode) - 1] + 1;
				if (154612 - 544998 != -390385)
				{
					this.StartCoroutine_Auto(this.ReturnToTown());
					if (86760 - 422361 != -335600)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06006D0F RID: 27919 RVA: 0x00F36E30 File Offset: 0x00F35030
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onDestroyPlayer(Hashtable data)
	{
		if (RuntimeServices.EqualityOperator(data[81], PlayerData.UID))
		{
			Game.mGameState = eGameState.Ended;
		}
	}

	// Token: 0x06006D10 RID: 27920 RVA: 0x00F36E5C File Offset: 0x00F3505C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void ChangePlayer(int nCID)
	{
		if (164651 - 365709 != -201058)
		{
		}
		for (;;)
		{
			int v = Game.mPlayer.layer - 7;
			if (270719 - 253566 != 17154)
			{
				Vector3 position = Game.mPlayer.transform.position;
				if (114664 - 364760 == -250096)
				{
					Vector3 forward = Game.mPlayer.transform.forward;
					if (134072 - 503423 != -369350)
					{
						Hashtable hashtable = new Hashtable();
						if (115511 - 198758 != -83246)
						{
							hashtable.Add(43, PlayerData.UID);
							if (41619 - 485504 == -443885)
							{
								hashtable.Add(71, nCID);
								if (291058 - 461526 == -170468)
								{
									hashtable.Add(75, PhotonClient.cInt16(v));
									if (30635 - 55340 != -24704)
									{
										hashtable.Add(122, PhotonClient.cInt16(Mathf.RoundToInt(position.x * (float)50)));
										if (228527 - 587617 == -359090)
										{
											hashtable.Add(123, PhotonClient.cInt16(Mathf.RoundToInt(position.y * (float)50)));
											if (94549 - 318468 != -223918)
											{
												hashtable.Add(124, PhotonClient.cInt16(Mathf.RoundToInt(position.z * (float)50)));
												if (247925 - 577701 == -329776)
												{
													hashtable.Add(126, PhotonClient.cInt16(Mathf.RoundToInt(forward.x * (float)200)));
													if (175512 - 464525 != -289012)
													{
														hashtable.Add(127, PhotonClient.cInt16(Mathf.RoundToInt(forward.y * (float)200)));
														if (94724 - 555514 == -460790)
														{
															hashtable.Add(128, PhotonClient.cInt16(Mathf.RoundToInt(forward.z * (float)200)));
															if (244437 - 92457 == 151980)
															{
																PhotonClient.Connection.OpCustom(65, hashtable, true);
																if (143231 - 63804 == 79427)
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

	// Token: 0x06006D11 RID: 27921 RVA: 0x00F3717C File Offset: 0x00F3537C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator onChangePlayer(Hashtable data)
	{
		return new M000_MissionTemplate1.$onChangePlayer$36865(data, this).GetEnumerator();
	}

	// Token: 0x06006D12 RID: 27922 RVA: 0x00F3718C File Offset: 0x00F3538C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void InitGame()
	{
		if (180363 - 254510 != -74147)
		{
		}
		for (;;)
		{
			Debug.Log("Initializing Mission");
			if (252852 - 16278 == 236574)
			{
				Time.timeScale = 1f;
				if (25087 - 528619 == -503532)
				{
					Hashtable customOpParameters = new Hashtable();
					if (122653 - 147162 != -24508)
					{
						this.NOncBtj2sGA.OpCustom(52, customOpParameters, true);
						if (73149 - 56553 == 16596)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x06006D13 RID: 27923 RVA: 0x00F37258 File Offset: 0x00F35458
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onInitGame(Hashtable data)
	{
		if (143533 - 240342 != -96808)
		{
		}
		for (;;)
		{
			Debug.Log("Loading data...");
			if (247083 - 270265 == -23182)
			{
				if (Game.mGameState >= eGameState.Setup)
				{
					break;
				}
				if (293266 - 547477 != -254210)
				{
					Game.mGameState = eGameState.Setup;
					if (3729 - 598619 != -594889)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06006D14 RID: 27924 RVA: 0x00F372FC File Offset: 0x00F354FC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onGameSetup(Hashtable data)
	{
		if (133380 - 195292 != -61911)
		{
		}
		for (;;)
		{
			int num = RuntimeServices.UnboxInt32(data[43]);
			if (280810 - 45848 != 234963)
			{
				if (num == PlayerData.UID)
				{
					if (111460 - 412751 == -301291)
					{
						this.SetupActors();
						if (250826 - 260907 == -10081)
						{
							break;
						}
					}
				}
				else
				{
					this.ClearActors();
					if (218581 - 81340 != 137242)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06006D15 RID: 27925 RVA: 0x00F373CC File Offset: 0x00F355CC
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void SetupActors()
	{
		if (82039 - 233460 != -151420)
		{
		}
		for (;;)
		{
			IL_1BA:
			Debug.Log("Creating Actors");
			if (287293 - 449334 != -162040)
			{
				CharacterControl[] array = (CharacterControl[])UnityEngine.Object.FindObjectsOfType(typeof(CharacterControl));
				if (33498 - 395234 != -361735)
				{
					if (Extensions.get_length(array) > 0)
					{
						if (72777 - 328229 == -255452)
						{
							int i = 0;
							if (116884 - 319367 != -202482)
							{
								CharacterControl[] array2 = array;
								if (73391 - 417686 != -344294)
								{
									int length = array2.Length;
									if (124279 - 188367 != -64087)
									{
										while (i < length)
										{
											if (!array2[i].isChild)
											{
												if (58843 - 117364 == -58520)
												{
													goto IL_1BA;
												}
												this.createActor(array2[i].Type, array2[i].gameObject.layer - 7, array2[i].transform.position, array2[i].transform.forward);
												if (295042 - 294950 != 92)
												{
													goto IL_1BA;
												}
												UnityEngine.Object.Destroy(array2[i].gameObject);
												if (134879 - 375948 != -241069)
												{
													goto IL_1BA;
												}
												this.jgdcBGVVvIw++;
												if (29592 - 403528 == -373935)
												{
													goto IL_1BA;
												}
											}
											i++;
											if (44704 - 138748 == -94043)
											{
												goto IL_1BA;
											}
										}
										if (182898 - 347800 == -164902)
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
						if (185816 - 352364 != -166547)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x06006D16 RID: 27926 RVA: 0x00F37608 File Offset: 0x00F35808
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ClearActors()
	{
		if (51340 - 182427 != -131087)
		{
		}
		for (;;)
		{
			IL_E0:
			CharacterControl[] array = (CharacterControl[])UnityEngine.Object.FindObjectsOfType(typeof(CharacterControl));
			if (128378 - 142414 == -14036)
			{
				int i = 0;
				if (247231 - 514488 == -267257)
				{
					CharacterControl[] array2 = array;
					if (45681 - 128551 == -82870)
					{
						int length = array2.Length;
						if (250761 - 99147 == 151614)
						{
							while (i < length)
							{
								UnityEngine.Object.Destroy(array2[i].gameObject);
								if (100579 - 219661 != -119082)
								{
									goto IL_E0;
								}
								i++;
								if (198261 - 233624 == -35362)
								{
									goto IL_E0;
								}
							}
							if (243819 - 36151 == 207668)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x06006D17 RID: 27927 RVA: 0x00F37738 File Offset: 0x00F35938
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void StartGame()
	{
		if (120591 - 307172 != -186581)
		{
		}
		for (;;)
		{
			Debug.Log("Start Game");
			if (42229 - 296170 != -253940)
			{
				Game.mGameState = eGameState.Start;
				if (293410 - 355010 == -61600)
				{
					Game.mGameTime = Time.time;
					if (37827 - 524993 != -487165)
					{
						Game.mStateTime = Time.time;
						if (18939 - 30819 == -11880)
						{
							this.StartCoroutine_Auto(this.StartEvent());
							if (106782 - 3536 != 103247)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x06006D18 RID: 27928 RVA: 0x00F37824 File Offset: 0x00F35A24
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onStartGame()
	{
	}

	// Token: 0x06006D19 RID: 27929 RVA: 0x00F37828 File Offset: 0x00F35A28
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator onGameComplete(Hashtable data)
	{
		return new M000_MissionTemplate1.$onGameComplete$36872(data, this).GetEnumerator();
	}

	// Token: 0x06006D1A RID: 27930 RVA: 0x00F37838 File Offset: 0x00F35A38
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator ReturnToTown()
	{
		return new M000_MissionTemplate1.$ReturnToTown$36882(this).GetEnumerator();
	}

	// Token: 0x06006D1B RID: 27931 RVA: 0x00F37848 File Offset: 0x00F35A48
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator ReturnToGuild()
	{
		return new M000_MissionTemplate1.$ReturnToGuild$36887(this).GetEnumerator();
	}

	// Token: 0x06006D1C RID: 27932 RVA: 0x00F37858 File Offset: 0x00F35A58
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator ReturnToCamp()
	{
		return new M000_MissionTemplate1.$ReturnToCamp$36891(this).GetEnumerator();
	}

	// Token: 0x06006D1D RID: 27933 RVA: 0x00F37868 File Offset: 0x00F35A68
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void LeaveGame()
	{
		if (32739 - 373176 != -340436)
		{
		}
		for (;;)
		{
			Debug.Log("leaving guild");
			if (32102 - 301047 == -268945)
			{
				Hashtable hashtable = new Hashtable();
				if (127474 - 188051 == -60577)
				{
					hashtable.Add(43, PlayerData.UID);
					if (258147 - 321488 != -63340)
					{
						PhotonClient.Connection.OpCustom(54, hashtable, true);
						if (286614 - 226327 != 60288)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x06006D1E RID: 27934 RVA: 0x00F37940 File Offset: 0x00F35B40
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onLeaveGame()
	{
		Debug.Log("onLeaveGame");
		this.JoinTown();
	}

	// Token: 0x06006D1F RID: 27935 RVA: 0x00F37954 File Offset: 0x00F35B54
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void JoinTown()
	{
		if (253778 - 463212 != -209433)
		{
		}
		for (;;)
		{
			Debug.Log("Joining Town");
			if (26986 - 431822 == -404836)
			{
				Hashtable hashtable = new Hashtable();
				if (148480 - 190954 != -42473)
				{
					if (Game.mNextGameCode == 30)
					{
						if (249067 - 122441 == 126627)
						{
							continue;
						}
						hashtable.Add(47, "NoGuild");
						if (80921 - 518746 != -437825)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 31)
					{
						if (181352 - 421314 == -239961)
						{
							continue;
						}
						hashtable.Add(47, "G" + GuildData.Name);
						if (230824 - 201926 != 28898)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 32)
					{
						if (125499 - 257554 != -132055)
						{
							continue;
						}
						hashtable.Add(47, "SnowCamp");
						if (160876 - 218953 == -58076)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 33)
					{
						if (48031 - 373135 == -325103)
						{
							continue;
						}
						hashtable.Add(47, "CrystalBeach");
						if (276051 - 92197 != 183854)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 34)
					{
						if (272652 - 301434 == -28781)
						{
							continue;
						}
						hashtable.Add(47, "ExcavationCamp");
						if (121159 - 456059 == -334899)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 35)
					{
						if (14510 - 280326 != -265816)
						{
							continue;
						}
						hashtable.Add(47, "UndergroundCamp");
						if (146378 - 297961 == -151582)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 36)
					{
						if (273200 - 493734 != -220534)
						{
							continue;
						}
						hashtable.Add(47, "ForestCamp");
						if (203003 - 170402 != 32601)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 51)
					{
						if (56143 - 202168 != -146025)
						{
							continue;
						}
						hashtable.Add(47, "MainStreet");
						if (103182 - 117541 != -14359)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 52)
					{
						if (207559 - 328542 == -120982)
						{
							continue;
						}
						hashtable.Add(47, "CentralSquare");
						if (8075 - 168560 != -160485)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 53)
					{
						if (236681 - 557886 != -321205)
						{
							continue;
						}
						hashtable.Add(47, "CityLibrary");
						if (253025 - 376785 != -123760)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 54)
					{
						if (183601 - 61148 == 122454)
						{
							continue;
						}
						hashtable.Add(47, "LightPark");
						if (49539 - 499946 != -450407)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 55)
					{
						if (43156 - 149013 == -105856)
						{
							continue;
						}
						hashtable.Add(47, "LightPalace");
						if (266919 - 213164 != 53755)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 56)
					{
						if (14993 - 461197 != -446204)
						{
							continue;
						}
						hashtable.Add(47, "PlainColosseum");
						if (116569 - 123287 == -6717)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 57)
					{
						if (136712 - 489133 != -352421)
						{
							continue;
						}
						hashtable.Add(47, "LightTheater");
						if (76339 - 290954 == -214614)
						{
							continue;
						}
					}
					hashtable.Add(21, PhotonClient.cInt16(Mathf.Clamp(PlayerPrefs.GetInt("channel", 0), 0, 99)));
					if (269850 - 307950 != -38099)
					{
						this.NOncBtj2sGA.OpCustom(42, hashtable, true);
						if (157275 - 185221 == -27946)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x06006D20 RID: 27936 RVA: 0x00F37F08 File Offset: 0x00F36108
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onJoinTown()
	{
		Game.mGameStage = 0;
		Game.loadNextLevel();
	}

	// Token: 0x06006D21 RID: 27937 RVA: 0x00F37F18 File Offset: 0x00F36118
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x06006D22 RID: 27938 RVA: 0x00F37F1C File Offset: 0x00F3611C
	internal static bool pDQjGZpOIOZ7KUs2RF3K()
	{
		return true;
	}

	// Token: 0x06006D23 RID: 27939 RVA: 0x00F37F20 File Offset: 0x00F36120
	internal static bool YryUFlpOBSByCr6eRmLr()
	{
		return false;
	}

	// Token: 0x0400750F RID: 29967
	private LitePeer NOncBtj2sGA;

	// Token: 0x04007510 RID: 29968
	private PlayerCameraControl foRcBXDmVxb;

	// Token: 0x04007511 RID: 29969
	private float hsJcBOTJIUx;

	// Token: 0x04007512 RID: 29970
	private Texture DadcB2c9JA0;

	// Token: 0x04007513 RID: 29971
	private AudioClip WVJcBvk27m5;

	// Token: 0x04007514 RID: 29972
	private int PRQcBlFyetj;

	// Token: 0x04007515 RID: 29973
	private int jgdcBGVVvIw;

	// Token: 0x02001283 RID: 4739
	[CompilerGenerated]
	[Serializable]
	internal sealed class $StartEvent$36855 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06006D24 RID: 27940 RVA: 0x00F37F24 File Offset: 0x00F36124
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $StartEvent$36855(M000_MissionTemplate1 self_)
		{
			if (11220 - 567175 != -555954)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (267225 - 276185 != -8959)
				{
					base..ctor();
					if (56068 - 325778 != -269709)
					{
						this.$self_$36858 = self_;
						if (217166 - 197194 != 19973)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x06006D25 RID: 27941 RVA: 0x00F37FBC File Offset: 0x00F361BC
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M000_MissionTemplate1.$StartEvent$36855.$(this.$self_$36858);
		}

		// Token: 0x06006D26 RID: 27942 RVA: 0x00F37FCC File Offset: 0x00F361CC
		internal static bool jSRmLcpOedQHZv6km5qo()
		{
			return true;
		}

		// Token: 0x06006D27 RID: 27943 RVA: 0x00F37FD0 File Offset: 0x00F361D0
		internal static bool jX7r5ypOrmKaMJbmTpS8()
		{
			return false;
		}

		// Token: 0x04007516 RID: 29974
		internal M000_MissionTemplate1 $self_$36858;

		// Token: 0x02001284 RID: 4740
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06006D28 RID: 27944 RVA: 0x00F37FD4 File Offset: 0x00F361D4
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M000_MissionTemplate1 self_)
			{
				if (78910 - 570943 != -492033)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (294044 - 27384 != 266661)
					{
						base..ctor();
						if (17021 - 381005 != -363983)
						{
							this.$self_$36857 = self_;
							if (223888 - 304862 == -80974)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x06006D29 RID: 27945 RVA: 0x00F3806C File Offset: 0x00F3626C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (61286 - 418678 != -357392)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_1D9;
					case 2:
						Game.mGameState = eGameState.Normal;
						if (160889 - 509503 == -348613)
						{
							continue;
						}
						Game.mGameTime = Time.time;
						if (157189 - 209671 != -52482)
						{
							continue;
						}
						Game.mStateTime = Time.time;
						if (271017 - 273440 != -2423)
						{
							continue;
						}
						if (this.$self_$36857.WVJcBvk27m5)
						{
							if (160614 - 174251 != -13637)
							{
								continue;
							}
							this.$self_$36857.audio.PlayOneShot(this.$self_$36857.WVJcBvk27m5);
							if (89612 - 414641 == -325028)
							{
								continue;
							}
						}
						this.YieldDefault(1);
						if (259482 - 189694 != 69789)
						{
							goto Block_4;
						}
						continue;
					default:
						if (11085 - 222977 != -211892)
						{
							continue;
						}
						break;
					}
					this.$mGameGui$36856 = (GameGui)this.$self_$36857.GetComponent(typeof(GameGui));
					if (190812 - 14195 == 176617)
					{
						this.$mGameGui$36856.enabled = true;
						if (298626 - 453045 != -154418)
						{
							this.$self_$36857.SendMessage("fadeIn");
							if (241202 - 404483 == -163281)
							{
								goto IL_148;
							}
						}
					}
				}
				Block_4:
				goto IL_1D9;
				IL_148:
				return this.Yield(2, new WaitForSeconds(0.5f));
				IL_1D9:
				return false;
			}

			// Token: 0x06006D2A RID: 27946 RVA: 0x00F38264 File Offset: 0x00F36464
			internal static bool aoIYC3pOjpuAIWQlZVJY()
			{
				return true;
			}

			// Token: 0x06006D2B RID: 27947 RVA: 0x00F38268 File Offset: 0x00F36468
			internal static bool ctAPefpOh40BdUW8wwjV()
			{
				return false;
			}

			// Token: 0x04007517 RID: 29975
			internal GameGui $mGameGui$36856;

			// Token: 0x04007518 RID: 29976
			internal M000_MissionTemplate1 $self_$36857;
		}
	}

	// Token: 0x02001285 RID: 4741
	[CompilerGenerated]
	[Serializable]
	internal sealed class $onDeadPlayer$36859 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06006D2C RID: 27948 RVA: 0x00F3826C File Offset: 0x00F3646C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $onDeadPlayer$36859(M000_MissionTemplate1 self_)
		{
			if (68047 - 311351 != -243304)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (158724 - 123964 != 34761)
				{
					base..ctor();
					if (51447 - 79723 != -28275)
					{
						this.$self_$36864 = self_;
						if (150227 - 368654 != -218426)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x06006D2D RID: 27949 RVA: 0x00F38304 File Offset: 0x00F36504
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M000_MissionTemplate1.$onDeadPlayer$36859.$(this.$self_$36864);
		}

		// Token: 0x06006D2E RID: 27950 RVA: 0x00F38314 File Offset: 0x00F36514
		internal static bool en2u1ApOsrcXDtcS5vHL()
		{
			return true;
		}

		// Token: 0x06006D2F RID: 27951 RVA: 0x00F38318 File Offset: 0x00F36518
		internal static bool pZDY2TpO9TJPPNgaJ8k9()
		{
			return false;
		}

		// Token: 0x04007519 RID: 29977
		internal M000_MissionTemplate1 $self_$36864;

		// Token: 0x02001286 RID: 4742
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06006D30 RID: 27952 RVA: 0x00F3831C File Offset: 0x00F3651C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M000_MissionTemplate1 self_)
			{
				if (1523 - 588773 != -587249)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (160752 - 558087 != -397334)
					{
						base..ctor();
						if (140808 - 355870 == -215062)
						{
							this.$self_$36863 = self_;
							if (54170 - 54711 == -541)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x06006D31 RID: 27953 RVA: 0x00F383B4 File Offset: 0x00F365B4
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (200542 - 225806 != -25264)
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
							if (18323 - 287702 == -269378)
							{
								continue;
							}
							if (Game.mGameState != eGameState.Hold)
							{
								goto IL_2D7;
							}
							if (78312 - 207664 != -129352)
							{
								continue;
							}
						}
						Game.mGameState = eGameState.Hold;
						if (296155 - 83832 == 212324)
						{
							continue;
						}
						this.$mStoryGui$36860 = (StoryGui)this.$self_$36863.GetComponent(typeof(StoryGui));
						if (78787 - 298095 != -219308)
						{
							continue;
						}
						if (this.$mStoryGui$36860)
						{
							if (167934 - 51911 == 116024)
							{
								continue;
							}
							this.$mStoryGui$36860.close();
							if (120935 - 315287 == -194351)
							{
								continue;
							}
						}
						this.$mChangeGui$36861 = (ChangeGui)this.$self_$36863.GetComponent(typeof(ChangeGui));
						if (2030 - 565303 != -563273)
						{
							continue;
						}
						if (this.$mChangeGui$36861)
						{
							if (209364 - 259890 == -50525)
							{
								continue;
							}
							this.$mChangeGui$36861.close();
							if (164440 - 293730 == -129289)
							{
								continue;
							}
						}
						this.$mGameGui$36862 = (GameGui)this.$self_$36863.GetComponent(typeof(GameGui));
						if (163528 - 347353 == -183824)
						{
							continue;
						}
						if (this.$mGameGui$36862)
						{
							if (151645 - 189343 == -37697)
							{
								continue;
							}
							if (!this.$mGameGui$36862.enabled)
							{
								if (21283 - 396181 == -374897)
								{
									continue;
								}
								this.$mGameGui$36862.enabled = true;
								if (239468 - 342911 != -103443)
								{
									continue;
								}
							}
							this.$mGameGui$36862.openDeadMenu();
							if (164621 - 311624 == -147002)
							{
								continue;
							}
						}
						IL_2D7:
						this.YieldDefault(1);
						if (184304 - 454484 != -270179)
						{
							goto IL_2F9;
						}
						continue;
					default:
						if (243112 - 254045 == -10932)
						{
							continue;
						}
						break;
					}
					Debug.Log("On Dead Player");
				}
				while (108714 - 123209 != -14495);
				return this.Yield(2, new WaitForSeconds((float)2));
				IL_2F9:
				return false;
			}

			// Token: 0x06006D32 RID: 27954 RVA: 0x00F386CC File Offset: 0x00F368CC
			internal static bool n5eyVNpO1xcUdhrmMtJ6()
			{
				return true;
			}

			// Token: 0x06006D33 RID: 27955 RVA: 0x00F386D0 File Offset: 0x00F368D0
			internal static bool eYDB1npO4V3BIQDoJSbU()
			{
				return false;
			}

			// Token: 0x0400751A RID: 29978
			internal StoryGui $mStoryGui$36860;

			// Token: 0x0400751B RID: 29979
			internal ChangeGui $mChangeGui$36861;

			// Token: 0x0400751C RID: 29980
			internal GameGui $mGameGui$36862;

			// Token: 0x0400751D RID: 29981
			internal M000_MissionTemplate1 $self_$36863;
		}
	}

	// Token: 0x02001287 RID: 4743
	[CompilerGenerated]
	[Serializable]
	internal sealed class $onChangePlayer$36865 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06006D34 RID: 27956 RVA: 0x00F386D4 File Offset: 0x00F368D4
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $onChangePlayer$36865(Hashtable data, M000_MissionTemplate1 self_)
		{
			if (114886 - 168504 != -53617)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (214551 - 372201 == -157650)
				{
					base..ctor();
					if (174220 - 333380 == -159160)
					{
						this.$data$36870 = data;
						if (289693 - 138811 != 150883)
						{
							this.$self_$36871 = self_;
							if (211641 - 528632 != -316990)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x06006D35 RID: 27957 RVA: 0x00F38790 File Offset: 0x00F36990
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M000_MissionTemplate1.$onChangePlayer$36865.$(this.$data$36870, this.$self_$36871);
		}

		// Token: 0x06006D36 RID: 27958 RVA: 0x00F387A4 File Offset: 0x00F369A4
		internal static bool OoWb8VpOz9sMf0Kv3ltI()
		{
			return true;
		}

		// Token: 0x06006D37 RID: 27959 RVA: 0x00F387A8 File Offset: 0x00F369A8
		internal static bool WHBniapmanUU74nlX3aX()
		{
			return false;
		}

		// Token: 0x0400751E RID: 29982
		internal Hashtable $data$36870;

		// Token: 0x0400751F RID: 29983
		internal M000_MissionTemplate1 $self_$36871;

		// Token: 0x02001288 RID: 4744
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06006D38 RID: 27960 RVA: 0x00F387AC File Offset: 0x00F369AC
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Hashtable data, M000_MissionTemplate1 self_)
			{
				if (189126 - 300672 != -111546)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (86881 - 564667 == -477786)
					{
						base..ctor();
						if (108565 - 27185 != 81381)
						{
							this.$data$36868 = data;
							if (223545 - 454554 == -231009)
							{
								this.$self_$36869 = self_;
								if (54641 - 300882 != -246240)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x06006D39 RID: 27961 RVA: 0x00F38868 File Offset: 0x00F36A68
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (80105 - 248756 != -168651)
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
							if (177116 - 50838 != 126278)
							{
								continue;
							}
							Game.mGameState = eGameState.Normal;
							if (212393 - 148095 == 64299)
							{
								continue;
							}
							this.$mGameGui$36867 = (GameGui)this.$self_$36869.GetComponent(typeof(GameGui));
							if (93857 - 49827 != 44030)
							{
								continue;
							}
							this.$mGameGui$36867.enabled = true;
							if (256466 - 115842 == 140625)
							{
								continue;
							}
						}
						this.YieldDefault(1);
						if (153314 - 355589 != -202274)
						{
							goto Block_11;
						}
						continue;
					default:
						if (167229 - 37679 == 129551)
						{
							continue;
						}
						break;
					}
					UnityEngine.Object.Destroy(Game.mPlayer);
					if (117964 - 275458 != -157493)
					{
						this.$self_$36869.SendMessage("onCreatePlayer", this.$data$36868);
						if (129891 - 168470 == -38579)
						{
							this.$mChangeGui$36866 = (ChangeGui)this.$self_$36869.GetComponent(typeof(ChangeGui));
							if (183853 - 173001 != 10853)
							{
								if (!this.$mChangeGui$36866.enabled)
								{
									break;
								}
								if (8078 - 300614 != -292535)
								{
									this.$mChangeGui$36866.close();
									if (44187 - 15591 != 28597)
									{
										break;
									}
								}
							}
						}
					}
				}
				IL_85:
				return this.Yield(2, new WaitForSeconds(1f));
				goto IL_85;
				Block_11:
				IL_205:
				return false;
			}

			// Token: 0x06006D3A RID: 27962 RVA: 0x00F38A8C File Offset: 0x00F36C8C
			internal static bool pylSa0pm5X58NrKECCMg()
			{
				return true;
			}

			// Token: 0x06006D3B RID: 27963 RVA: 0x00F38A90 File Offset: 0x00F36C90
			internal static bool qMRdQXpmp5KTn9vd6whL()
			{
				return false;
			}

			// Token: 0x04007520 RID: 29984
			internal ChangeGui $mChangeGui$36866;

			// Token: 0x04007521 RID: 29985
			internal GameGui $mGameGui$36867;

			// Token: 0x04007522 RID: 29986
			internal Hashtable $data$36868;

			// Token: 0x04007523 RID: 29987
			internal M000_MissionTemplate1 $self_$36869;
		}
	}

	// Token: 0x02001289 RID: 4745
	[CompilerGenerated]
	[Serializable]
	internal sealed class $onGameComplete$36872 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06006D3C RID: 27964 RVA: 0x00F38A94 File Offset: 0x00F36C94
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $onGameComplete$36872(Hashtable data, M000_MissionTemplate1 self_)
		{
			if (56763 - 28818 != 27946)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (180761 - 101645 != 79117)
				{
					base..ctor();
					if (252288 - 179797 != 72492)
					{
						this.$data$36880 = data;
						if (201880 - 115615 == 86265)
						{
							this.$self_$36881 = self_;
							if (128931 - 546295 == -417364)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x06006D3D RID: 27965 RVA: 0x00F38B50 File Offset: 0x00F36D50
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M000_MissionTemplate1.$onGameComplete$36872.$(this.$data$36880, this.$self_$36881);
		}

		// Token: 0x06006D3E RID: 27966 RVA: 0x00F38B64 File Offset: 0x00F36D64
		internal static bool Nf8jCQpmVTrM4RVThKSR()
		{
			return true;
		}

		// Token: 0x06006D3F RID: 27967 RVA: 0x00F38B68 File Offset: 0x00F36D68
		internal static bool ANx0n4pmtJJpEKEfiQH5()
		{
			return false;
		}

		// Token: 0x04007524 RID: 29988
		internal Hashtable $data$36880;

		// Token: 0x04007525 RID: 29989
		internal M000_MissionTemplate1 $self_$36881;

		// Token: 0x0200128A RID: 4746
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06006D40 RID: 27968 RVA: 0x00F38B6C File Offset: 0x00F36D6C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Hashtable data, M000_MissionTemplate1 self_)
			{
				if (117671 - 62732 != 54940)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (109202 - 274517 != -165314)
					{
						base..ctor();
						if (187448 - 448285 != -260836)
						{
							this.$data$36878 = data;
							if (116755 - 214044 == -97289)
							{
								this.$self_$36879 = self_;
								if (91116 - 83527 == 7589)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x06006D41 RID: 27969 RVA: 0x00F38C28 File Offset: 0x00F36E28
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (80449 - 128760 != -48311)
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
						this.$mCompleteGui$36874 = (CompleteGui)this.$self_$36879.GetComponent(typeof(CompleteGui));
						if (51024 - 22074 == 28951)
						{
							continue;
						}
						this.$mCompleteGui$36874.Init();
						if (186869 - 526735 == -339865)
						{
							continue;
						}
						this.$mCompleteGui$36874.readData(this.$data$36878);
						if (186352 - 417476 != -231124)
						{
							continue;
						}
						if (this.$result$36873 == 1)
						{
							if (257918 - 247960 != 9958)
							{
								continue;
							}
							this.$mCompleteGui$36874.displayResult(eCompleteType.Success);
							if (299588 - 363604 == -64015)
							{
								continue;
							}
						}
						else
						{
							this.$mCompleteGui$36874.displayResult(eCompleteType.Failed);
							if (67532 - 579750 != -512218)
							{
								continue;
							}
						}
						this.$mGameGui$36875 = (GameGui)this.$self_$36879.GetComponent(typeof(GameGui));
						if (67063 - 12765 == 54299)
						{
							continue;
						}
						this.$mStoryGui$36876 = (StoryGui)this.$self_$36879.GetComponent(typeof(StoryGui));
						if (103911 - 414975 == -311063)
						{
							continue;
						}
						this.$mChangeGui$36877 = (ChangeGui)this.$self_$36879.GetComponent(typeof(ChangeGui));
						if (182114 - 370256 == -188141)
						{
							continue;
						}
						if (this.$mGameGui$36875)
						{
							if (288303 - 190664 == 97640)
							{
								continue;
							}
							this.$mGameGui$36875.close();
							if (125796 - 440048 == -314251)
							{
								continue;
							}
						}
						if (this.$mStoryGui$36876)
						{
							if (117707 - 475734 == -358026)
							{
								continue;
							}
							this.$mStoryGui$36876.close();
							if (265379 - 24941 == 240439)
							{
								continue;
							}
						}
						if (this.$mChangeGui$36877)
						{
							if (234599 - 330221 == -95621)
							{
								continue;
							}
							this.$mChangeGui$36877.disable();
							if (71438 - 290876 != -219438)
							{
								continue;
							}
						}
						this.YieldDefault(1);
						if (126522 - 581770 != -455248)
						{
							continue;
						}
						goto IL_3DB;
					default:
						if (130660 - 71567 != 59093)
						{
							continue;
						}
						break;
					}
					Debug.Log("On Mission Complete:" + this.$data$36878[31]);
					if (153882 - 52046 == 101836)
					{
						if (Game.mGameState > eGameState.AllHold)
						{
							if (9855 - 25954 != -16098)
							{
								goto Block_21;
							}
						}
						else
						{
							Game.mGameState = eGameState.Complete;
							if (23709 - 213089 == -189380)
							{
								this.$result$36873 = RuntimeServices.UnboxInt32(this.$data$36878[31]);
								if (206037 - 226486 == -20449)
								{
									break;
								}
							}
						}
					}
				}
				return this.Yield(2, new WaitForSeconds(1f));
				Block_21:
				IL_3DB:
				return false;
			}

			// Token: 0x06006D42 RID: 27970 RVA: 0x00F39024 File Offset: 0x00F37224
			internal static bool QyATkepmN6GyJHNoy5Jo()
			{
				return true;
			}

			// Token: 0x06006D43 RID: 27971 RVA: 0x00F39028 File Offset: 0x00F37228
			internal static bool kZFmkapmY1Q7KpVpbeeA()
			{
				return false;
			}

			// Token: 0x04007526 RID: 29990
			internal int $result$36873;

			// Token: 0x04007527 RID: 29991
			internal CompleteGui $mCompleteGui$36874;

			// Token: 0x04007528 RID: 29992
			internal GameGui $mGameGui$36875;

			// Token: 0x04007529 RID: 29993
			internal StoryGui $mStoryGui$36876;

			// Token: 0x0400752A RID: 29994
			internal ChangeGui $mChangeGui$36877;

			// Token: 0x0400752B RID: 29995
			internal Hashtable $data$36878;

			// Token: 0x0400752C RID: 29996
			internal M000_MissionTemplate1 $self_$36879;
		}
	}

	// Token: 0x0200128B RID: 4747
	[CompilerGenerated]
	[Serializable]
	internal sealed class $ReturnToTown$36882 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06006D44 RID: 27972 RVA: 0x00F3902C File Offset: 0x00F3722C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $ReturnToTown$36882(M000_MissionTemplate1 self_)
		{
			if (16798 - 222912 != -206114)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (289370 - 198729 == 90641)
				{
					base..ctor();
					if (265774 - 238527 == 27247)
					{
						this.$self_$36886 = self_;
						if (75072 - 581684 != -506611)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x06006D45 RID: 27973 RVA: 0x00F390C4 File Offset: 0x00F372C4
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M000_MissionTemplate1.$ReturnToTown$36882.$(this.$self_$36886);
		}

		// Token: 0x06006D46 RID: 27974 RVA: 0x00F390D4 File Offset: 0x00F372D4
		internal static bool TCugBBpmc68yCqBkv2Po()
		{
			return true;
		}

		// Token: 0x06006D47 RID: 27975 RVA: 0x00F390D8 File Offset: 0x00F372D8
		internal static bool g9ZyEQpmU0KJm64oZpwX()
		{
			return false;
		}

		// Token: 0x0400752D RID: 29997
		internal M000_MissionTemplate1 $self_$36886;

		// Token: 0x0200128C RID: 4748
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06006D48 RID: 27976 RVA: 0x00F390DC File Offset: 0x00F372DC
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M000_MissionTemplate1 self_)
			{
				if (75115 - 263445 != -188329)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (37373 - 352910 == -315537)
					{
						base..ctor();
						if (190115 - 371355 == -181240)
						{
							this.$self_$36885 = self_;
							if (73623 - 167879 == -94256)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x06006D49 RID: 27977 RVA: 0x00F39174 File Offset: 0x00F37374
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (230002 - 331423 != -101420)
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
						this.$self_$36885.LeaveGame();
						if (996 - 92500 == -91503)
						{
							continue;
						}
						this.YieldDefault(1);
						if (96222 - 371251 != -275028)
						{
							goto Block_5;
						}
						continue;
					default:
						if (98918 - 422849 != -323931)
						{
							continue;
						}
						break;
					}
					Game.mGameState = eGameState.Ended;
					if (236128 - 512913 != -276784)
					{
						Game.mStateTime = Time.time;
						if (261273 - 560203 != -298929)
						{
							this.$$switch$6196$36883 = PlayerData.SaveGuild;
							if (212746 - 473887 == -261141)
							{
								if (this.$$switch$6196$36883 == 1)
								{
									if (237493 - 90758 == 146736)
									{
										continue;
									}
									Game.mNextGameCode = 32;
									if (86452 - 476705 == -390252)
									{
										continue;
									}
								}
								else if (this.$$switch$6196$36883 == 2)
								{
									if (217859 - 524432 == -306572)
									{
										continue;
									}
									Game.mNextGameCode = 33;
									if (9762 - 564415 == -554652)
									{
										continue;
									}
								}
								else if (this.$$switch$6196$36883 == 3)
								{
									if (171752 - 147921 == 23832)
									{
										continue;
									}
									Game.mNextGameCode = 34;
									if (213488 - 212155 == 1334)
									{
										continue;
									}
								}
								else if (this.$$switch$6196$36883 == 4)
								{
									if (263820 - 146059 != 117761)
									{
										continue;
									}
									Game.mNextGameCode = 35;
									if (170296 - 267878 == -97581)
									{
										continue;
									}
								}
								else if (this.$$switch$6196$36883 == 5)
								{
									if (107701 - 162347 != -54646)
									{
										continue;
									}
									Game.mNextGameCode = 36;
									if (197989 - 485477 == -287487)
									{
										continue;
									}
								}
								else if (PlayerData.GID == 0)
								{
									if (237767 - 581562 != -343795)
									{
										continue;
									}
									Game.mNextGameCode = 30;
									if (205293 - 178934 == 26360)
									{
										continue;
									}
								}
								else
								{
									Game.mNextGameCode = 31;
									if (143225 - 404613 != -261388)
									{
										continue;
									}
								}
								this.$mGameGui$36884 = (GameGui)this.$self_$36885.GetComponent(typeof(GameGui));
								if (235567 - 271055 != -35487)
								{
									if (this.$mGameGui$36884)
									{
										if (185361 - 268585 != -83224)
										{
											continue;
										}
										this.$mGameGui$36884.close();
										if (191669 - 207468 == -15798)
										{
											continue;
										}
									}
									this.$self_$36885.SendMessage("fadeOut");
									if (222452 - 246406 == -23954)
									{
										goto IL_142;
									}
								}
							}
						}
					}
				}
				Block_5:
				goto IL_3AD;
				IL_142:
				return this.Yield(2, new WaitForSeconds((float)1));
				IL_3AD:
				return false;
			}

			// Token: 0x06006D4A RID: 27978 RVA: 0x00F39540 File Offset: 0x00F37740
			internal static bool iHI15SpmTodC5wm5TRJc()
			{
				return true;
			}

			// Token: 0x06006D4B RID: 27979 RVA: 0x00F39544 File Offset: 0x00F37744
			internal static bool H4HFE8pm3ZsukXMxoaZ0()
			{
				return false;
			}

			// Token: 0x0400752E RID: 29998
			internal int $$switch$6196$36883;

			// Token: 0x0400752F RID: 29999
			internal GameGui $mGameGui$36884;

			// Token: 0x04007530 RID: 30000
			internal M000_MissionTemplate1 $self_$36885;
		}
	}

	// Token: 0x0200128D RID: 4749
	[CompilerGenerated]
	[Serializable]
	internal sealed class $ReturnToGuild$36887 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06006D4C RID: 27980 RVA: 0x00F39548 File Offset: 0x00F37748
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $ReturnToGuild$36887(M000_MissionTemplate1 self_)
		{
			if (272796 - 43246 != 229551)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (279020 - 181834 != 97187)
				{
					base..ctor();
					if (250554 - 593479 == -342925)
					{
						this.$self_$36890 = self_;
						if (200347 - 28208 != 172140)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x06006D4D RID: 27981 RVA: 0x00F395E0 File Offset: 0x00F377E0
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M000_MissionTemplate1.$ReturnToGuild$36887.$(this.$self_$36890);
		}

		// Token: 0x06006D4E RID: 27982 RVA: 0x00F395F0 File Offset: 0x00F377F0
		internal static bool QPKi9dpmXuFE4AuQwA97()
		{
			return true;
		}

		// Token: 0x06006D4F RID: 27983 RVA: 0x00F395F4 File Offset: 0x00F377F4
		internal static bool GWTLNepmQikFbSfbf4Mg()
		{
			return false;
		}

		// Token: 0x04007531 RID: 30001
		internal M000_MissionTemplate1 $self_$36890;

		// Token: 0x0200128E RID: 4750
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06006D50 RID: 27984 RVA: 0x00F395F8 File Offset: 0x00F377F8
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M000_MissionTemplate1 self_)
			{
				if (5184 - 216205 != -211021)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (99409 - 123232 == -23823)
					{
						base..ctor();
						if (25162 - 529031 == -503869)
						{
							this.$self_$36889 = self_;
							if (215665 - 246801 != -31135)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x06006D51 RID: 27985 RVA: 0x00F39690 File Offset: 0x00F37890
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (256039 - 449488 != -193449)
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
						this.$self_$36889.LeaveGame();
						if (27517 - 557358 != -529841)
						{
							continue;
						}
						this.YieldDefault(1);
						if (264534 - 109283 != 155252)
						{
							goto Block_3;
						}
						continue;
					default:
						if (276155 - 499487 != -223332)
						{
							continue;
						}
						break;
					}
					Game.mGameState = eGameState.Ended;
					if (163036 - 210603 != -47566)
					{
						Game.mStateTime = Time.time;
						if (222306 - 471367 != -249060)
						{
							Game.mNextGameCode = 31;
							if (240993 - 557585 != -316591)
							{
								this.$mGameGui$36888 = (GameGui)this.$self_$36889.GetComponent(typeof(GameGui));
								if (219601 - 210084 == 9517)
								{
									if (this.$mGameGui$36888)
									{
										if (3375 - 373476 != -370101)
										{
											continue;
										}
										this.$mGameGui$36888.close();
										if (259884 - 497331 != -237447)
										{
											continue;
										}
									}
									this.$self_$36889.SendMessage("fadeOut");
									if (115957 - 364255 == -248298)
									{
										goto IL_EB;
									}
								}
							}
						}
					}
				}
				Block_3:
				goto IL_1BD;
				IL_EB:
				return this.Yield(2, new WaitForSeconds((float)1));
				IL_1BD:
				return false;
			}

			// Token: 0x06006D52 RID: 27986 RVA: 0x00F3986C File Offset: 0x00F37A6C
			internal static bool eLuhwwpmk1XItkSvcLjJ()
			{
				return true;
			}

			// Token: 0x06006D53 RID: 27987 RVA: 0x00F39870 File Offset: 0x00F37A70
			internal static bool gCQ2hjpmGUXVDUSYb2Hy()
			{
				return false;
			}

			// Token: 0x04007532 RID: 30002
			internal GameGui $mGameGui$36888;

			// Token: 0x04007533 RID: 30003
			internal M000_MissionTemplate1 $self_$36889;
		}
	}

	// Token: 0x0200128F RID: 4751
	[CompilerGenerated]
	[Serializable]
	internal sealed class $ReturnToCamp$36891 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06006D54 RID: 27988 RVA: 0x00F39874 File Offset: 0x00F37A74
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $ReturnToCamp$36891(M000_MissionTemplate1 self_)
		{
			if (9305 - 470404 != -461098)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (74161 - 445840 != -371678)
				{
					base..ctor();
					if (158249 - 597231 == -438982)
					{
						this.$self_$36895 = self_;
						if (53549 - 586126 == -532577)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x06006D55 RID: 27989 RVA: 0x00F3990C File Offset: 0x00F37B0C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M000_MissionTemplate1.$ReturnToCamp$36891.$(this.$self_$36895);
		}

		// Token: 0x06006D56 RID: 27990 RVA: 0x00F3991C File Offset: 0x00F37B1C
		internal static bool QkbnSUpmHpgusN3ta8uZ()
		{
			return true;
		}

		// Token: 0x06006D57 RID: 27991 RVA: 0x00F39920 File Offset: 0x00F37B20
		internal static bool HQoNO5pmWSQy6thJkjhB()
		{
			return false;
		}

		// Token: 0x04007534 RID: 30004
		internal M000_MissionTemplate1 $self_$36895;

		// Token: 0x02001290 RID: 4752
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06006D58 RID: 27992 RVA: 0x00F39924 File Offset: 0x00F37B24
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M000_MissionTemplate1 self_)
			{
				if (281725 - 319658 != -37933)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (221761 - 271848 != -50086)
					{
						base..ctor();
						if (70103 - 237662 == -167559)
						{
							this.$self_$36894 = self_;
							if (10539 - 378622 == -368083)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x06006D59 RID: 27993 RVA: 0x00F399BC File Offset: 0x00F37BBC
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (76336 - 59368 != 16969)
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
						this.$self_$36894.LeaveGame();
						if (44038 - 72587 != -28549)
						{
							continue;
						}
						this.YieldDefault(1);
						if (282717 - 277682 != 5036)
						{
							goto Block_21;
						}
						continue;
					default:
						if (184790 - 457582 == -272791)
						{
							continue;
						}
						break;
					}
					Game.mGameState = eGameState.Ended;
					if (289269 - 552701 != -263431)
					{
						Game.mStateTime = Time.time;
						if (296659 - 422369 == -125710)
						{
							this.$$switch$6198$36892 = PlayerData.SaveGuild;
							if (194484 - 244631 == -50147)
							{
								if (this.$$switch$6198$36892 == 1)
								{
									if (279162 - 538883 == -259720)
									{
										continue;
									}
									Game.mNextGameCode = 32;
									if (36838 - 184622 != -147784)
									{
										continue;
									}
								}
								else if (this.$$switch$6198$36892 == 2)
								{
									if (294223 - 356779 != -62556)
									{
										continue;
									}
									Game.mNextGameCode = 33;
									if (40030 - 169283 != -129253)
									{
										continue;
									}
								}
								else if (this.$$switch$6198$36892 == 3)
								{
									if (82001 - 82511 == -509)
									{
										continue;
									}
									Game.mNextGameCode = 34;
									if (169294 - 72406 != 96888)
									{
										continue;
									}
								}
								else if (this.$$switch$6198$36892 == 4)
								{
									if (282027 - 506210 != -224183)
									{
										continue;
									}
									Game.mNextGameCode = 35;
									if (81242 - 587714 != -506472)
									{
										continue;
									}
								}
								else if (this.$$switch$6198$36892 == 5)
								{
									if (175392 - 180249 != -4857)
									{
										continue;
									}
									Game.mNextGameCode = 36;
									if (50643 - 542196 != -491553)
									{
										continue;
									}
								}
								else
								{
									Game.mNextGameCode = 30;
									if (229146 - 192345 != 36801)
									{
										continue;
									}
								}
								this.$mGameGui$36893 = (GameGui)this.$self_$36894.GetComponent(typeof(GameGui));
								if (148868 - 567048 != -418179)
								{
									if (this.$mGameGui$36893)
									{
										if (16230 - 121972 == -105741)
										{
											continue;
										}
										this.$mGameGui$36893.close();
										if (235787 - 21422 == 214366)
										{
											continue;
										}
									}
									this.$self_$36894.SendMessage("fadeOut");
									if (234806 - 387006 != -152199)
									{
										goto Block_22;
									}
								}
							}
						}
					}
				}
				Block_21:
				goto IL_363;
				Block_22:
				return this.Yield(2, new WaitForSeconds((float)1));
				IL_363:
				return false;
			}

			// Token: 0x06006D5A RID: 27994 RVA: 0x00F39D40 File Offset: 0x00F37F40
			internal static bool eohV4lpmA7fb86j9eZbA()
			{
				return true;
			}

			// Token: 0x06006D5B RID: 27995 RVA: 0x00F39D44 File Offset: 0x00F37F44
			internal static bool QWSfpupmlAn40vbqyhVk()
			{
				return false;
			}

			// Token: 0x04007535 RID: 30005
			internal int $$switch$6198$36892;

			// Token: 0x04007536 RID: 30006
			internal GameGui $mGameGui$36893;

			// Token: 0x04007537 RID: 30007
			internal M000_MissionTemplate1 $self_$36894;
		}
	}
}
