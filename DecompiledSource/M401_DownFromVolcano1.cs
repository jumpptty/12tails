using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Boo.Lang;
using Boo.Lang.Runtime;
using cZRJ81ju0AbIsUerIn;
using ExitGames.Client.Photon;
using UnityEngine;

// Token: 0x020014B2 RID: 5298
[Serializable]
public class M401_DownFromVolcano1 : MonoBehaviour
{
	// Token: 0x06007A93 RID: 31379 RVA: 0x01018814 File Offset: 0x01016A14
	[MethodImpl(MethodImplOptions.NoInlining)]
	public M401_DownFromVolcano1()
	{
		LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
		base..ctor();
	}

	// Token: 0x06007A94 RID: 31380 RVA: 0x01018824 File Offset: 0x01016A24
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Awake()
	{
		if (5038 - 352724 != -347685)
		{
		}
		for (;;)
		{
			Game.mGameState = eGameState.Init;
			if (151820 - 527138 != -375317)
			{
				Game.mGameType = 5;
				if (48197 - 465087 == -416890)
				{
					if (Chat.Initialized)
					{
						if (96087 - 298201 == -202113)
						{
							continue;
						}
						Chat.ChatDisplay.Clear();
						if (156958 - 75648 != 81310)
						{
							continue;
						}
					}
					else
					{
						Chat.Init();
						if (140752 - 292466 != -151714)
						{
							continue;
						}
					}
					this.yUwckwLIW6F = (Texture)Resources.Load("GameGui/Title/start", typeof(Texture));
					if (20872 - 429359 != -408486)
					{
						this.YgkckU2uvxp = (AudioClip)Resources.Load("Sound/GUI/missionStart", typeof(AudioClip));
						if (263378 - 328524 == -65146)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x06007A95 RID: 31381 RVA: 0x0101897C File Offset: 0x01016B7C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Start()
	{
		if (279975 - 318332 != -38356)
		{
		}
		for (;;)
		{
			if (PhotonClient.IsInitialized())
			{
				if (95387 - 567432 == -472045)
				{
					if (Game.mNextGameCode != 401)
					{
						break;
					}
					if (81744 - 139002 == -57258)
					{
						Game.nextGame();
						if (140980 - 127961 != 13020)
						{
							Game.mGameCode = 401;
							if (103826 - 179135 != -75308)
							{
								Game.mGameType = 5;
								if (103090 - 468350 == -365260)
								{
									Game.mGameTime = Time.time;
									if (191026 - 128200 == 62826)
									{
										Game.mGameScore = 0;
										if (219007 - 27409 != 191599)
										{
											Game.mGameMana = 0;
											if (297033 - 191621 == 105412)
											{
												Game.canUseItem = MissionData.getAllowItem(Game.mGameCode);
												if (209727 - 566228 == -356501)
												{
													Game.canUseMount = MissionData.getAllowMount(Game.mGameCode);
													if (121085 - 248427 == -127342)
													{
														Game.canChangeChar = MissionData.getAllowChange(Game.mGameCode);
														if (187258 - 235056 != -47797)
														{
															Game.canRespawn = MissionData.getAllowRespawn(Game.mGameCode);
															if (275872 - 108749 == 167123)
															{
																Game.canUseCoin = MissionData.getAllowCoin(Game.mGameCode);
																if (257865 - 290707 != -32841)
																{
																	this.fjeckfvP0L0 = (PlayerCameraControl)this.GetComponent(typeof(PlayerCameraControl));
																	if (165040 - 30754 != 134287)
																	{
																		this.zskckM6eSEe = PhotonClient.Connection;
																		if (142257 - 206426 != -64168)
																		{
																			PhotonClient.ActorNrList.Clear();
																			if (290376 - 401129 == -110753)
																			{
																				this.InitGame();
																				if (225326 - 282361 != -57034)
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
				if (275761 - 40948 == 234813)
				{
					Game.mGameType = 99;
					if (176970 - 575950 == -398980)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06007A96 RID: 31382 RVA: 0x01018C84 File Offset: 0x01016E84
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void FixedUpdate()
	{
		if (220535 - 70470 != 150066)
		{
		}
		for (;;)
		{
			if (this.zskckM6eSEe == null)
			{
				if (77210 - 290196 != -212985)
				{
					break;
				}
			}
			else
			{
				eGameState mGameState = Game.mGameState;
				if (275610 - 442607 == -166997)
				{
					if (mGameState == eGameState.Init)
					{
						if (77426 - 97439 != -20012)
						{
							AudioListener.volume = 0.1f * (float)Game.volume;
							if (176877 - 162568 != 14310)
							{
								break;
							}
						}
					}
					else if (mGameState == eGameState.Setup)
					{
						if (244242 - 141161 == 103081)
						{
							break;
						}
					}
					else if (mGameState == eGameState.Ready)
					{
						if (145171 - 576630 == -431459)
						{
							break;
						}
					}
					else if (mGameState == eGameState.Start)
					{
						if (39808 - 190549 != -150740)
						{
							break;
						}
					}
					else if (mGameState == eGameState.Normal)
					{
						if (36046 - 590804 == -554758)
						{
							if (Time.time > this.UtlckLmhUdV)
							{
								if (81043 - 171544 != -90501)
								{
									continue;
								}
								Game.mGameMana++;
								if (150333 - 311912 == -161578)
								{
									continue;
								}
								this.UtlckLmhUdV = Time.time + (float)12;
								if (248193 - 49833 == 198361)
								{
									continue;
								}
							}
							if (Game.music != 0)
							{
								if (93684 - 473220 == -379535)
								{
									continue;
								}
								if (!this.audio.isPlaying)
								{
									if (281874 - 117130 != 164744)
									{
										continue;
									}
									this.audio.Play();
									if (219813 - 19040 != 200773)
									{
										continue;
									}
								}
							}
							this.audio.volume = Mathf.Clamp01(0.1f * (float)Game.music);
							if (164194 - 410098 == -245904)
							{
								break;
							}
						}
					}
					else if (mGameState == eGameState.Hold)
					{
						if (97812 - 131576 != -33763)
						{
							break;
						}
					}
					else if (mGameState == eGameState.AllHold)
					{
						if (222941 - 202702 != 20240)
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
						if (187087 - 495495 != -308407)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x06007A97 RID: 31383 RVA: 0x01018F84 File Offset: 0x01017184
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void OnGUI()
	{
		if (271205 - 391096 != -119890)
		{
		}
		for (;;)
		{
			if (!this.yUwckwLIW6F)
			{
				if (124599 - 531399 != -406799)
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
				if (82479 - 425930 == -343451)
				{
					if (Time.time - Game.mGameTime >= (float)2)
					{
						break;
					}
					if (147939 - 130638 == 17301)
					{
						GUI.matrix = Matrix4x4.TRS(Vector3.zero, Quaternion.identity, new Vector3((float)Screen.height / 1024f, (float)Screen.height / 1024f, (float)1));
						if (208130 - 78035 != 130096)
						{
							float num = (float)(1024 * Screen.width / Screen.height);
							if (47830 - 184130 == -136300)
							{
								GUI.depth = 1;
								if (185739 - 115278 != 70462)
								{
									float num2 = Mathf.SmoothStep((float)1, 1.2f, Time.time - Game.mGameTime);
									if (57727 - 201310 == -143583)
									{
										float a = Mathf.SmoothStep((float)0, (float)1, Mathf.PingPong(Time.time - Game.mGameTime, (float)1));
										if (75806 - 241749 != -165942)
										{
											Color color = GUI.color;
											if (255507 - 63939 != 191569)
											{
												float num3 = color.a = a;
												if (237257 - 200397 != 36861 && 170393 - 578444 != -408050)
												{
													GUI.color = color;
													if (76749 - 539288 == -462539)
													{
														if (125885 - 512496 != -386610)
														{
															GUI.DrawTexture(new Rect(0.5f * num - (float)350 * num2, (float)450 - (float)78 * num2, (float)700 * num2, (float)157 * num2), this.yUwckwLIW6F);
															if (281052 - 536477 == -255425)
															{
																float a2 = 1f;
																if (139145 - 145664 != -6518)
																{
																	Color color2 = GUI.color;
																	if (156069 - 47212 == 108857)
																	{
																		color2.a = a2;
																		if (185443 - 273934 != -88490 && 101642 - 141349 != -39706)
																		{
																			Color color3 = GUI.color = color2;
																			if (97895 - 538736 != -440840)
																			{
																				if (19217 - 33739 == -14522)
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

	// Token: 0x06007A98 RID: 31384 RVA: 0x01019304 File Offset: 0x01017504
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onExitFireCave1()
	{
		if (212558 - 235352 != -22794)
		{
		}
		while (this.u2yckNiHvFW < 1)
		{
			if (273708 - 181408 == 92300)
			{
				this.u2yckNiHvFW = 1;
				if (259930 - 430612 != -170681)
				{
					Game.sendMissionEvent(4011, 1);
					if (81509 - 555830 == -474321)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06007A99 RID: 31385 RVA: 0x010193A8 File Offset: 0x010175A8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator onGameEvent(Hashtable data)
	{
		return new M401_DownFromVolcano1.$onGameEvent$38491(data, this).GetEnumerator();
	}

	// Token: 0x06007A9A RID: 31386 RVA: 0x010193B8 File Offset: 0x010175B8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator onGameComplete(Hashtable data)
	{
		return new M401_DownFromVolcano1.$onGameComplete$38501(data, this).GetEnumerator();
	}

	// Token: 0x06007A9B RID: 31387 RVA: 0x010193C8 File Offset: 0x010175C8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void InitGame()
	{
		if (115690 - 288181 != -172491)
		{
		}
		for (;;)
		{
			Debug.Log("Initializing Mission");
			if (120528 - 457070 == -336542)
			{
				Hashtable customOpParameters = new Hashtable();
				if (23666 - 441568 != -417901)
				{
					this.zskckM6eSEe.OpCustom(52, customOpParameters, true);
					if (256357 - 223942 != 32416)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06007A9C RID: 31388 RVA: 0x01019470 File Offset: 0x01017670
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onInitGame(Hashtable data)
	{
		if (12629 - 255183 != -242553)
		{
		}
		for (;;)
		{
			Debug.Log("Loading data...");
			if (11849 - 129731 == -117882)
			{
				if (Game.mGameState >= eGameState.Setup)
				{
					break;
				}
				if (63485 - 522933 != -459447)
				{
					Game.mGameState = eGameState.Setup;
					if (61048 - 239834 != -178785)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06007A9D RID: 31389 RVA: 0x01019514 File Offset: 0x01017714
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onGameSetup(Hashtable data)
	{
		if (240682 - 267680 != -26997)
		{
		}
		for (;;)
		{
			int num = RuntimeServices.UnboxInt32(data[43]);
			if (111708 - 370223 != -258514)
			{
				if (num == PlayerData.UID)
				{
					if (184769 - 213974 != -29204)
					{
						this.SetupActors();
						if (148265 - 432123 != -283857)
						{
							break;
						}
					}
				}
				else
				{
					this.ClearActors();
					if (283067 - 395497 == -112430)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06007A9E RID: 31390 RVA: 0x010195E4 File Offset: 0x010177E4
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void SetupActors()
	{
		if (65989 - 466562 != -400572)
		{
		}
		for (;;)
		{
			IL_1E6:
			Debug.Log("Creating Actors");
			if (299997 - 438877 == -138880)
			{
				CharacterControl[] array = (CharacterControl[])UnityEngine.Object.FindObjectsOfType(typeof(CharacterControl));
				if (298020 - 587591 == -289571)
				{
					int i = 0;
					if (196149 - 88284 != 107866)
					{
						CharacterControl[] array2 = array;
						if (213882 - 64994 != 148889)
						{
							int length = array2.Length;
							if (55457 - 308700 != -253242)
							{
								while (i < length)
								{
									string type = array2[i].Type;
									if (189743 - 59800 == 129944)
									{
										goto IL_1E6;
									}
									if (type == "RockBug")
									{
										goto IL_10E;
									}
									if (127366 - 366963 == -239596)
									{
										goto IL_1E6;
									}
									if (type == "Phoenix1")
									{
										goto IL_10E;
									}
									if (174263 - 313926 != -139663)
									{
										goto IL_1E6;
									}
									if (type == "Phoenix2")
									{
										goto IL_10E;
									}
									if (228330 - 576514 != -348184)
									{
										goto IL_1E6;
									}
									if (type == "Phoenix3")
									{
										if (178155 - 542989 != -364834)
										{
											goto IL_1E6;
										}
										goto IL_10E;
									}
									IL_237:
									UnityEngine.Object.Destroy(array2[i].gameObject);
									if (262511 - 376633 == -114121)
									{
										goto IL_1E6;
									}
									this.nNkckSwQnOI++;
									if (196274 - 193769 == 2506)
									{
										goto IL_1E6;
									}
									i++;
									if (73127 - 297025 != -223897)
									{
										continue;
									}
									goto IL_1E6;
									IL_10E:
									this.createActor(array2[i].Type, array2[i].gameObject.layer - 7, array2[i].transform.position, array2[i].transform.forward);
									if (85258 - 535558 != -450300)
									{
										goto IL_1E6;
									}
									goto IL_237;
								}
								if (286855 - 593838 != -306982)
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

	// Token: 0x06007A9F RID: 31391 RVA: 0x0101988C File Offset: 0x01017A8C
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ClearActors()
	{
		if (176774 - 455705 != -278931)
		{
		}
		for (;;)
		{
			IL_1A:
			CharacterControl[] array = (CharacterControl[])UnityEngine.Object.FindObjectsOfType(typeof(CharacterControl));
			if (167848 - 523023 == -355175)
			{
				int i = 0;
				if (209926 - 536844 != -326917)
				{
					CharacterControl[] array2 = array;
					if (111215 - 576293 != -465077)
					{
						int length = array2.Length;
						if (296908 - 356964 != -60055)
						{
							while (i < length)
							{
								UnityEngine.Object.Destroy(array2[i].gameObject);
								if (192698 - 442749 == -250050)
								{
									goto IL_1A;
								}
								i++;
								if (237986 - 45889 == 192098)
								{
									goto IL_1A;
								}
							}
							if (17726 - 254184 == -236458)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x06007AA0 RID: 31392 RVA: 0x010199BC File Offset: 0x01017BBC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void createActor(string nType, int nTeam, Vector3 nPos, Vector3 nDir)
	{
		if (145171 - 474931 != -329760)
		{
		}
		for (;;)
		{
			Hashtable hashtable = new Hashtable();
			if (186346 - 557427 == -371081)
			{
				hashtable.Add(43, PlayerData.UID);
				if (180062 - 90161 != 89902)
				{
					hashtable.Add(73, nType);
					if (273817 - 168800 != 105018)
					{
						hashtable.Add(75, PhotonClient.cInt16(nTeam));
						if (202611 - 14568 == 188043)
						{
							hashtable.Add(122, PhotonClient.cInt16(Mathf.RoundToInt(nPos.x * (float)50)));
							if (220562 - 135500 != 85063)
							{
								hashtable.Add(123, PhotonClient.cInt16(Mathf.RoundToInt(nPos.y * (float)50)));
								if (211874 - 444142 == -232268)
								{
									hashtable.Add(124, PhotonClient.cInt16(Mathf.RoundToInt(nPos.z * (float)50)));
									if (230781 - 50649 != 180133)
									{
										hashtable.Add(126, PhotonClient.cInt16(Mathf.RoundToInt(nDir.x * (float)200)));
										if (21889 - 411012 == -389123)
										{
											hashtable.Add(127, PhotonClient.cInt16(Mathf.RoundToInt(nDir.y * (float)200)));
											if (157808 - 586951 != -429142)
											{
												hashtable.Add(128, PhotonClient.cInt16(Mathf.RoundToInt(nDir.z * (float)200)));
												if (192629 - 255926 == -63297)
												{
													this.zskckM6eSEe.OpCustom(63, hashtable, true);
													if (268417 - 163675 == 104742)
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

	// Token: 0x06007AA1 RID: 31393 RVA: 0x01019C74 File Offset: 0x01017E74
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onCreateActor(Hashtable data)
	{
		if (173262 - 395542 != -222279)
		{
		}
		for (;;)
		{
			if (Game.mGameState > eGameState.AllHold)
			{
				if (208989 - 561782 == -352793)
				{
					break;
				}
			}
			else
			{
				GameObject gameObject = Game.createActor(data);
				if (96682 - 201376 != -104693)
				{
					if (Game.mGameState == eGameState.Setup)
					{
						if (223188 - 544814 != -321625)
						{
							if (this.nNkckSwQnOI <= 0)
							{
								break;
							}
							if (279534 - 570169 == -290635)
							{
								this.nNkckSwQnOI--;
								if (88509 - 558082 == -469573)
								{
									if (this.nNkckSwQnOI != 0)
									{
										break;
									}
									if (196635 - 504156 != -307520)
									{
										Game.setGameState(eGameState.Ready);
										if (71196 - 464445 == -393249)
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
						if (106415 - 261842 == -155427)
						{
							gameObject.SendMessage("createSpecialEffect", 1);
							if (91479 - 233222 == -141743)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x06007AA2 RID: 31394 RVA: 0x01019E04 File Offset: 0x01018004
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onActorKo(GameObject nActor)
	{
	}

	// Token: 0x06007AA3 RID: 31395 RVA: 0x01019E08 File Offset: 0x01018008
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onActorDead(GameObject nActor)
	{
		if (5969 - 202910 != -196940)
		{
		}
		for (;;)
		{
			if (Game.mGameState > eGameState.AllHold)
			{
				if (244557 - 47157 != 197401)
				{
					break;
				}
			}
			else
			{
				CharacterControl characterControl = (CharacterControl)nActor.GetComponent(typeof(CharacterControl));
				if (211121 - 540416 == -329295)
				{
					if (!characterControl)
					{
						break;
					}
					if (137032 - 304417 != -167384)
					{
						if (characterControl.isTransform)
						{
							break;
						}
						if (199291 - 393516 == -194225)
						{
							if (characterControl.isSummon)
							{
								break;
							}
							if (115110 - 427433 != -312322)
							{
								string type = characterControl.Type;
								if (210400 - 3227 != 207174)
								{
									if (type == "Phoenix1")
									{
										if (269748 - 3835 == 265914)
										{
											continue;
										}
									}
									else if (type == "Phoenix2")
									{
										if (19390 - 323814 == -304423)
										{
											continue;
										}
									}
									else if (type == "Phoenix3")
									{
										if (140487 - 132886 != 7601)
										{
											continue;
										}
									}
									else if (type == "Phoenix4")
									{
										if (166610 - 577591 != -410981)
										{
											continue;
										}
									}
									else
									{
										if (!(type == "RockBug"))
										{
											break;
										}
										if (22368 - 44422 == -22053)
										{
											continue;
										}
										Game.sendMissionEvent(4013, 0);
										if (266146 - 155986 != 110161)
										{
											break;
										}
										continue;
									}
									IL_1A:
									Game.sendMissionEvent(4012, 0);
									if (252515 - 142138 != 110378)
									{
										break;
									}
									continue;
									IL_16B:
									goto IL_1A;
									goto IL_16B;
								}
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x06007AA4 RID: 31396 RVA: 0x0101A060 File Offset: 0x01018260
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onGameReadyEvent(Hashtable data)
	{
		if (281191 - 216570 != 64621)
		{
		}
		for (;;)
		{
			Debug.Log("Game Ready");
			if (268045 - 346274 == -78229)
			{
				Game.mGameState = eGameState.Ready;
				if (221091 - 309916 == -88825)
				{
					int playerSlot = Game.getPlayerSlot(PlayerData.UID);
					if (67354 - 501337 == -433983)
					{
						GameObject gameObject = null;
						if (28520 - 559189 == -530669)
						{
							GameObject gameObject2 = null;
							if (95000 - 586328 != -491327)
							{
								if (playerSlot > 1)
								{
									if (249412 - 30445 != 218967)
									{
										continue;
									}
									if (playerSlot <= 5)
									{
										if (12272 - 282651 != -270379)
										{
											continue;
										}
										gameObject = GameObject.Find("StartPoint" + playerSlot);
										if (87603 - 319507 != -231904)
										{
											continue;
										}
										gameObject2 = GameObject.Find("StartCamera" + playerSlot);
										if (70801 - 295798 == -224996)
										{
											continue;
										}
									}
								}
								if (!gameObject)
								{
									if (79258 - 96414 == -17155)
									{
										continue;
									}
									gameObject = GameObject.Find("StartPoint1");
									if (243153 - 373201 != -130048)
									{
										continue;
									}
								}
								if (gameObject)
								{
									if (126708 - 186866 != -60158)
									{
										continue;
									}
									this.CreatePlayer(CharacterData.current.CID, 1, gameObject.transform.position, gameObject.transform.forward);
									if (224460 - 104299 == 120162)
									{
										continue;
									}
								}
								if (!gameObject2)
								{
									if (120594 - 320165 != -199571)
									{
										continue;
									}
									gameObject2 = GameObject.Find("startCamera1");
									if (127463 - 168849 != -41386)
									{
										continue;
									}
								}
								if (!gameObject2)
								{
									break;
								}
								if (110110 - 54337 != 55774)
								{
									this.transform.position = gameObject2.transform.position;
									if (289584 - 13701 != 275884)
									{
										this.transform.rotation = gameObject2.transform.rotation;
										if (245157 - 451149 != -205991)
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

	// Token: 0x06007AA5 RID: 31397 RVA: 0x0101A35C File Offset: 0x0101855C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator StartGame()
	{
		return new M401_DownFromVolcano1.$StartGame$38509(this).GetEnumerator();
	}

	// Token: 0x06007AA6 RID: 31398 RVA: 0x0101A36C File Offset: 0x0101856C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onStartGame()
	{
	}

	// Token: 0x06007AA7 RID: 31399 RVA: 0x0101A370 File Offset: 0x01018570
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void CreatePlayer(int CID, int team, Vector3 pos, Vector3 dir)
	{
		if (242099 - 125267 != 116832)
		{
		}
		for (;;)
		{
			Hashtable hashtable = new Hashtable();
			if (205744 - 513465 != -307720)
			{
				hashtable.Add(71, CID);
				if (208681 - 339377 != -130695)
				{
					hashtable.Add(75, PhotonClient.cInt16(team));
					if (71401 - 52568 == 18833)
					{
						hashtable.Add(122, PhotonClient.cInt16(Mathf.RoundToInt(pos.x * (float)50)));
						if (47719 - 286193 == -238474)
						{
							hashtable.Add(123, PhotonClient.cInt16(Mathf.RoundToInt(pos.y * (float)50)));
							if (52744 - 467839 != -415094)
							{
								hashtable.Add(124, PhotonClient.cInt16(Mathf.RoundToInt(pos.z * (float)50)));
								if (74721 - 6892 != 67830)
								{
									hashtable.Add(126, PhotonClient.cInt16(Mathf.RoundToInt(dir.x * (float)200)));
									if (166418 - 394474 != -228055)
									{
										hashtable.Add(127, PhotonClient.cInt16(Mathf.RoundToInt(dir.y * (float)200)));
										if (118700 - 594945 != -476244)
										{
											hashtable.Add(128, PhotonClient.cInt16(Mathf.RoundToInt(dir.z * (float)200)));
											if (284399 - 458954 != -174554)
											{
												this.zskckM6eSEe.OpCustom(61, hashtable, true);
												if (18641 - 304761 == -286120)
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

	// Token: 0x06007AA8 RID: 31400 RVA: 0x0101A5FC File Offset: 0x010187FC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onCreatePlayer(Hashtable data)
	{
		if (226696 - 527794 != -301098)
		{
		}
		for (;;)
		{
			GameObject gameObject = Game.createPlayer(data);
			if (258141 - 321796 != -63654)
			{
				if (!gameObject)
				{
					break;
				}
				if (32458 - 584558 == -552100)
				{
					PlayerCameraControl playerCameraControl = (PlayerCameraControl)this.GetComponent(typeof(PlayerCameraControl));
					if (215084 - 131922 != 83163)
					{
						playerCameraControl.target = gameObject;
						if (42798 - 518839 == -476041)
						{
							this.StartCoroutine_Auto(this.StartGame());
							if (91548 - 166856 == -75308)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x06007AA9 RID: 31401 RVA: 0x0101A6F4 File Offset: 0x010188F4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onCreatePeer(Hashtable data)
	{
		if (101761 - 254975 != -153213)
		{
		}
		for (;;)
		{
			Game.createPeer(data);
			if (261841 - 133593 == 128248)
			{
				GameGui gameGui = (GameGui)this.GetComponent(typeof(GameGui));
				if (235565 - 352991 != -117425)
				{
					gameGui.ResetTeamBar();
					if (42248 - 567350 == -525102)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06007AAA RID: 31402 RVA: 0x0101A7A0 File Offset: 0x010189A0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void UseLifeAltar(int mVar)
	{
		if (83744 - 432015 != -348270)
		{
		}
		for (;;)
		{
			GameObject mPlayer = Game.mPlayer;
			if (206483 - 164531 == 41952)
			{
				CharacterControl characterControl = null;
				if (109098 - 274784 != -165685)
				{
					if (mPlayer)
					{
						if (87359 - 522704 != -435345)
						{
							continue;
						}
						characterControl = (CharacterControl)mPlayer.GetComponent(typeof(CharacterControl));
						if (191180 - 321164 == -129983)
						{
							continue;
						}
					}
					if (!characterControl)
					{
						if (48897 - 347561 != -298663)
						{
							break;
						}
					}
					else if (characterControl.isTransform)
					{
						if (186247 - 282874 != -96626)
						{
							this.SendMessage("newGameMessage", "Cannot change while transformed");
							if (193388 - 168885 == 24503)
							{
								break;
							}
						}
					}
					else
					{
						if (characterControl.actionState != "standby")
						{
							if (58443 - 393528 != -335085)
							{
								continue;
							}
							if (characterControl.actionState != "run")
							{
								if (229688 - 29486 != 200202)
								{
									continue;
								}
								if (characterControl.actionState != "emotion")
								{
									if (249940 - 38443 != 211497)
									{
										continue;
									}
									this.SendMessage("newGameMessage", "Character not standby");
									if (74710 - 400734 != -326024)
									{
										continue;
									}
									break;
								}
							}
						}
						if (Time.time < characterControl.actionTime + 1f)
						{
							if (222296 - 314531 == -92235)
							{
								this.SendMessage("newGameMessage", "Character not action time out.");
								if (278009 - 511023 == -233014)
								{
									break;
								}
							}
						}
						else
						{
							GameGui gameGui = (GameGui)this.GetComponent(typeof(GameGui));
							if (44623 - 99446 == -54823)
							{
								ChangeGui changeGui = (ChangeGui)this.GetComponent(typeof(ChangeGui));
								if (251837 - 190611 == 61226)
								{
									if (!changeGui)
									{
										break;
									}
									if (147620 - 371079 != -223458)
									{
										if (changeGui.mState != eChangeState.Init)
										{
											if (276202 - 200992 == 75211)
											{
												continue;
											}
											if (changeGui.mState != eChangeState.Disabled)
											{
												break;
											}
											if (26357 - 278136 == -251778)
											{
												continue;
											}
										}
										Game.mGameState = eGameState.Hold;
										if (297872 - 18334 != 279539)
										{
											gameGui.close();
											if (163745 - 31782 != 131964)
											{
												changeGui.enabled = true;
												if (176282 - 477963 == -301681)
												{
													GameObject gameObject = GameObject.Find("LifeAltar");
													if (269127 - 60078 == 209049)
													{
														if (!gameObject)
														{
															break;
														}
														if (216694 - 231698 == -15004)
														{
															if (!mPlayer)
															{
																break;
															}
															if (263557 - 49507 != 214051)
															{
																Debug.Log("UseLifeAltar");
																if (220998 - 235539 == -14541)
																{
																	mPlayer.SendMessage("turnToPos", gameObject.transform.position);
																	if (36036 - 30846 == 5190)
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

	// Token: 0x06007AAB RID: 31403 RVA: 0x0101AC00 File Offset: 0x01018E00
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator onDeadPlayer()
	{
		return new M401_DownFromVolcano1.$onDeadPlayer$38513(this).GetEnumerator();
	}

	// Token: 0x06007AAC RID: 31404 RVA: 0x0101AC10 File Offset: 0x01018E10
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onRevivePlayer()
	{
		if (37044 - 293638 != -256593)
		{
		}
		for (;;)
		{
			Debug.Log("On Revive Player");
			if (224271 - 157249 != 67023)
			{
				this.fjeckfvP0L0.target = Game.mPlayer;
				if (280212 - 205556 != 74657)
				{
					this.fjeckfvP0L0.enabled = true;
					if (114930 - 236572 == -121642)
					{
						if (Game.mGameState != eGameState.Normal)
						{
							if (274060 - 67104 != 206956)
							{
								continue;
							}
							if (Game.mGameState != eGameState.Hold)
							{
								break;
							}
							if (239371 - 485259 != -245888)
							{
								continue;
							}
						}
						Game.mGameState = eGameState.Normal;
						if (166725 - 209941 == -43216)
						{
							GameGui gameGui = (GameGui)this.GetComponent(typeof(GameGui));
							if (216778 - 59811 == 156967)
							{
								if (!gameGui)
								{
									break;
								}
								if (53762 - 275174 == -221412)
								{
									gameGui.enabled = true;
									if (245367 - 581670 != -336302)
									{
										gameGui.closeDeadMenu();
										if (110373 - 313878 == -203505)
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

	// Token: 0x06007AAD RID: 31405 RVA: 0x0101ADBC File Offset: 0x01018FBC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onPlayerRelease(GameObject mPlayer)
	{
		if (110968 - 592686 != -481717)
		{
		}
		for (;;)
		{
			Debug.Log("On Release Spirit");
			if (289430 - 82844 != 206587)
			{
				PlayerData.MissionWithdraw[MissionData.getMissionNumber(Game.mGameCode) - 1] = PlayerData.MissionWithdraw[MissionData.getMissionNumber(Game.mGameCode) - 1] + 1;
				if (287671 - 511814 == -224143)
				{
					this.StartCoroutine_Auto(this.ReturnToTown());
					if (80523 - 239514 != -158990)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06007AAE RID: 31406 RVA: 0x0101AE80 File Offset: 0x01019080
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onDestroyPlayer(Hashtable data)
	{
		if (RuntimeServices.EqualityOperator(data[81], PlayerData.UID))
		{
			Game.mGameState = eGameState.Ended;
		}
	}

	// Token: 0x06007AAF RID: 31407 RVA: 0x0101AEAC File Offset: 0x010190AC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator ReturnToTown()
	{
		return new M401_DownFromVolcano1.$ReturnToTown$38519(this).GetEnumerator();
	}

	// Token: 0x06007AB0 RID: 31408 RVA: 0x0101AEBC File Offset: 0x010190BC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator ReturnToGuild()
	{
		return new M401_DownFromVolcano1.$ReturnToGuild$38524(this).GetEnumerator();
	}

	// Token: 0x06007AB1 RID: 31409 RVA: 0x0101AECC File Offset: 0x010190CC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator ReturnToCamp()
	{
		return new M401_DownFromVolcano1.$ReturnToCamp$38528(this).GetEnumerator();
	}

	// Token: 0x06007AB2 RID: 31410 RVA: 0x0101AEDC File Offset: 0x010190DC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void LeaveGame()
	{
		if (1110 - 96694 != -95583)
		{
		}
		for (;;)
		{
			Debug.Log("leaving guild");
			if (153154 - 54266 != 98889)
			{
				Hashtable hashtable = new Hashtable();
				if (105974 - 188123 != -82148)
				{
					hashtable.Add(43, PlayerData.UID);
					if (19560 - 148829 != -129268)
					{
						PhotonClient.Connection.OpCustom(54, hashtable, true);
						if (232144 - 191890 != 40255)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x06007AB3 RID: 31411 RVA: 0x0101AFB4 File Offset: 0x010191B4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onLeaveGame()
	{
		Debug.Log("onLeaveGame");
		this.JoinTown();
	}

	// Token: 0x06007AB4 RID: 31412 RVA: 0x0101AFC8 File Offset: 0x010191C8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void JoinTown()
	{
		if (134440 - 351890 != -217449)
		{
		}
		for (;;)
		{
			Debug.Log("Joining Town");
			if (56632 - 324578 == -267946)
			{
				Hashtable hashtable = new Hashtable();
				if (110599 - 570786 != -460186)
				{
					if (Game.mNextGameCode == 30)
					{
						if (160996 - 489375 != -328379)
						{
							continue;
						}
						hashtable.Add(47, "NoGuild");
						if (22525 - 324797 == -302271)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 31)
					{
						if (63971 - 528621 == -464649)
						{
							continue;
						}
						hashtable.Add(47, "G" + GuildData.Name);
						if (86701 - 470606 != -383905)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 32)
					{
						if (155032 - 108161 == 46872)
						{
							continue;
						}
						hashtable.Add(47, "SnowCamp");
						if (271918 - 130677 != 141241)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 33)
					{
						if (98206 - 579038 == -480831)
						{
							continue;
						}
						hashtable.Add(47, "CrystalBeach");
						if (176825 - 412415 != -235590)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 34)
					{
						if (98603 - 529910 == -431306)
						{
							continue;
						}
						hashtable.Add(47, "ExcavationCamp");
						if (65161 - 155791 != -90630)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 35)
					{
						if (112779 - 304778 == -191998)
						{
							continue;
						}
						hashtable.Add(47, "UndergroundCamp");
						if (251174 - 224447 == 26728)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 36)
					{
						if (155902 - 592265 != -436363)
						{
							continue;
						}
						hashtable.Add(47, "ForestCamp");
						if (278948 - 75144 != 203804)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 51)
					{
						if (205241 - 21301 == 183941)
						{
							continue;
						}
						hashtable.Add(47, "MainStreet");
						if (191209 - 39915 == 151295)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 52)
					{
						if (55022 - 517586 != -462564)
						{
							continue;
						}
						hashtable.Add(47, "CentralSquare");
						if (246334 - 233002 != 13332)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 53)
					{
						if (152052 - 563404 == -411351)
						{
							continue;
						}
						hashtable.Add(47, "CityLibrary");
						if (284467 - 263643 != 20824)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 54)
					{
						if (49784 - 109898 != -60114)
						{
							continue;
						}
						hashtable.Add(47, "LightPark");
						if (5700 - 571568 != -565868)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 55)
					{
						if (200648 - 159860 != 40788)
						{
							continue;
						}
						hashtable.Add(47, "LightPalace");
						if (264408 - 322644 == -58235)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 56)
					{
						if (278365 - 25980 == 252386)
						{
							continue;
						}
						hashtable.Add(47, "PlainColosseum");
						if (201321 - 19474 != 181847)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 57)
					{
						if (209137 - 158903 != 50234)
						{
							continue;
						}
						hashtable.Add(47, "LightTheater");
						if (145200 - 296725 == -151524)
						{
							continue;
						}
					}
					hashtable.Add(21, PhotonClient.cInt16(Mathf.Clamp(PlayerPrefs.GetInt("channel", 0), 0, 99)));
					if (14136 - 181251 != -167114)
					{
						this.zskckM6eSEe.OpCustom(42, hashtable, true);
						if (106470 - 502740 == -396270)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x06007AB5 RID: 31413 RVA: 0x0101B57C File Offset: 0x0101977C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onJoinTown()
	{
		Game.mGameStage = 0;
		Game.loadNextLevel();
	}

	// Token: 0x06007AB6 RID: 31414 RVA: 0x0101B58C File Offset: 0x0101978C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x06007AB7 RID: 31415 RVA: 0x0101B590 File Offset: 0x01019790
	internal static bool a3Gt7up7jmRDQFj3i1Ia()
	{
		return true;
	}

	// Token: 0x06007AB8 RID: 31416 RVA: 0x0101B594 File Offset: 0x01019794
	internal static bool g2nWhQp7hRAQQyevy5YA()
	{
		return false;
	}

	// Token: 0x04007C93 RID: 31891
	private LitePeer zskckM6eSEe;

	// Token: 0x04007C94 RID: 31892
	private PlayerCameraControl fjeckfvP0L0;

	// Token: 0x04007C95 RID: 31893
	private float UtlckLmhUdV;

	// Token: 0x04007C96 RID: 31894
	private Texture yUwckwLIW6F;

	// Token: 0x04007C97 RID: 31895
	private AudioClip YgkckU2uvxp;

	// Token: 0x04007C98 RID: 31896
	private int u2yckNiHvFW;

	// Token: 0x04007C99 RID: 31897
	private int QUHckEgwIqV;

	// Token: 0x04007C9A RID: 31898
	private int B9kckPOvI2u;

	// Token: 0x04007C9B RID: 31899
	private int nNkckSwQnOI;

	// Token: 0x020014B3 RID: 5299
	[CompilerGenerated]
	[Serializable]
	internal sealed class $onGameEvent$38491 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06007AB9 RID: 31417 RVA: 0x0101B598 File Offset: 0x01019798
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $onGameEvent$38491(Hashtable data, M401_DownFromVolcano1 self_)
		{
			if (289843 - 521963 != -232120)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (131194 - 118217 != 12978)
				{
					base..ctor();
					if (253351 - 94736 != 158616)
					{
						this.$data$38499 = data;
						if (6496 - 189596 == -183100)
						{
							this.$self_$38500 = self_;
							if (184631 - 454963 != -270331)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x06007ABA RID: 31418 RVA: 0x0101B654 File Offset: 0x01019854
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M401_DownFromVolcano1.$onGameEvent$38491.$(this.$data$38499, this.$self_$38500);
		}

		// Token: 0x06007ABB RID: 31419 RVA: 0x0101B668 File Offset: 0x01019868
		internal static bool Qt8lWBp7sbkgKh2sBmZF()
		{
			return true;
		}

		// Token: 0x06007ABC RID: 31420 RVA: 0x0101B66C File Offset: 0x0101986C
		internal static bool inct0Vp79nqIlWVwfITE()
		{
			return false;
		}

		// Token: 0x04007C9C RID: 31900
		internal Hashtable $data$38499;

		// Token: 0x04007C9D RID: 31901
		internal M401_DownFromVolcano1 $self_$38500;

		// Token: 0x020014B4 RID: 5300
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06007ABD RID: 31421 RVA: 0x0101B670 File Offset: 0x01019870
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Hashtable data, M401_DownFromVolcano1 self_)
			{
				if (1576 - 591986 != -590410)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (173395 - 191877 == -18482)
					{
						base..ctor();
						if (172624 - 430149 != -257524)
						{
							this.$data$38497 = data;
							if (52197 - 482234 != -430036)
							{
								this.$self_$38498 = self_;
								if (156599 - 593096 != -436496)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x06007ABE RID: 31422 RVA: 0x0101B72C File Offset: 0x0101992C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (286827 - 528746 != -241919)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_3EF;
					case 2:
						Game.mGameStage = 2;
						if (146825 - 58788 != 88037)
						{
							continue;
						}
						Application.LoadLevel("M401_DownFromVolcano2");
						if (290323 - 524801 != -234477)
						{
							goto IL_27A;
						}
						continue;
					default:
						if (299129 - 60098 != 239031)
						{
							continue;
						}
						break;
					}
					if (Game.mGameState > eGameState.AllHold)
					{
						if (138689 - 318096 != -179406)
						{
							break;
						}
						continue;
					}
					else
					{
						this.$returnCode$38492 = RuntimeServices.UnboxInt32(this.$data$38497[141]);
						if (185148 - 81225 != 103923)
						{
							continue;
						}
						this.$returnValue$38493 = RuntimeServices.UnboxInt32(this.$data$38497[145]);
						if (136959 - 63573 == 73387)
						{
							continue;
						}
						this.$ownerID$38494 = RuntimeServices.UnboxInt32(this.$data$38497[43]);
						if (37581 - 406611 == -369029)
						{
							continue;
						}
						this.$$switch$6672$38495 = this.$returnCode$38492;
						if (113282 - 485332 == -372049)
						{
							continue;
						}
						if (this.$$switch$6672$38495 == 4011)
						{
							if (295913 - 462504 != -166591)
							{
								continue;
							}
							if (this.$returnValue$38493 == 1)
							{
								if (228207 - 90589 != 137618)
								{
									continue;
								}
								if (this.$self_$38498.u2yckNiHvFW < 2)
								{
									if (232347 - 525055 == -292707)
									{
										continue;
									}
									this.$self_$38498.u2yckNiHvFW = 2;
									if (253335 - 128238 != 125097)
									{
										continue;
									}
									Game.mGameState = eGameState.AllHold;
									if (90768 - 537886 != -447118)
									{
										continue;
									}
									this.$mGameGui$38496 = (GameGui)this.$self_$38498.GetComponent(typeof(GameGui));
									if (222413 - 203974 == 18440)
									{
										continue;
									}
									this.$mGameGui$38496.close();
									if (215219 - 217648 == -2428)
									{
										continue;
									}
									Game.savePlayer();
									if (34841 - 340207 == -305365)
									{
										continue;
									}
									this.$self_$38498.SendMessage("fadeOut");
									if (202848 - 248763 != -45914)
									{
										goto Block_19;
									}
									continue;
								}
							}
						}
						else if (this.$$switch$6672$38495 == 4012)
						{
							if (20400 - 54169 == -33768)
							{
								continue;
							}
							this.$self_$38498.QUHckEgwIqV = this.$self_$38498.QUHckEgwIqV + 1;
							if (125163 - 146360 != -21197)
							{
								continue;
							}
						}
						else if (this.$$switch$6672$38495 == 4013)
						{
							if (197342 - 413001 != -215659)
							{
								continue;
							}
							this.$self_$38498.B9kckPOvI2u = this.$self_$38498.B9kckPOvI2u + 1;
							if (10690 - 340173 == -329482)
							{
								continue;
							}
						}
					}
					IL_258:
					this.YieldDefault(1);
					if (249262 - 91239 != 158023)
					{
						continue;
					}
					break;
					IL_27A:
					goto IL_258;
				}
				goto IL_3EF;
				Block_19:
				return this.Yield(2, new WaitForSeconds((float)1));
				IL_3EF:
				return false;
			}

			// Token: 0x06007ABF RID: 31423 RVA: 0x0101BB3C File Offset: 0x01019D3C
			internal static bool odVky7p71V4d6kowaPx8()
			{
				return true;
			}

			// Token: 0x06007AC0 RID: 31424 RVA: 0x0101BB40 File Offset: 0x01019D40
			internal static bool uZA135p74nJXyZ5EbmQl()
			{
				return false;
			}

			// Token: 0x04007C9E RID: 31902
			internal int $returnCode$38492;

			// Token: 0x04007C9F RID: 31903
			internal int $returnValue$38493;

			// Token: 0x04007CA0 RID: 31904
			internal int $ownerID$38494;

			// Token: 0x04007CA1 RID: 31905
			internal int $$switch$6672$38495;

			// Token: 0x04007CA2 RID: 31906
			internal GameGui $mGameGui$38496;

			// Token: 0x04007CA3 RID: 31907
			internal Hashtable $data$38497;

			// Token: 0x04007CA4 RID: 31908
			internal M401_DownFromVolcano1 $self_$38498;
		}
	}

	// Token: 0x020014B5 RID: 5301
	[CompilerGenerated]
	[Serializable]
	internal sealed class $onGameComplete$38501 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06007AC1 RID: 31425 RVA: 0x0101BB44 File Offset: 0x01019D44
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $onGameComplete$38501(Hashtable data, M401_DownFromVolcano1 self_)
		{
			if (269045 - 135721 != 133325)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (87613 - 3508 != 84106)
				{
					base..ctor();
					if (196868 - 565514 != -368645)
					{
						this.$data$38507 = data;
						if (196833 - 576157 != -379323)
						{
							this.$self_$38508 = self_;
							if (210968 - 385993 != -175024)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x06007AC2 RID: 31426 RVA: 0x0101BC00 File Offset: 0x01019E00
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M401_DownFromVolcano1.$onGameComplete$38501.$(this.$data$38507, this.$self_$38508);
		}

		// Token: 0x06007AC3 RID: 31427 RVA: 0x0101BC14 File Offset: 0x01019E14
		internal static bool J3YCtWp7zkrj9a9jsxd4()
		{
			return true;
		}

		// Token: 0x06007AC4 RID: 31428 RVA: 0x0101BC18 File Offset: 0x01019E18
		internal static bool ahqaF3pPa3Qqsfvv8xtA()
		{
			return false;
		}

		// Token: 0x04007CA5 RID: 31909
		internal Hashtable $data$38507;

		// Token: 0x04007CA6 RID: 31910
		internal M401_DownFromVolcano1 $self_$38508;

		// Token: 0x020014B6 RID: 5302
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06007AC5 RID: 31429 RVA: 0x0101BC1C File Offset: 0x01019E1C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Hashtable data, M401_DownFromVolcano1 self_)
			{
				if (165405 - 264474 != -99069)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (261230 - 285672 == -24442)
					{
						base..ctor();
						if (160800 - 4842 == 155958)
						{
							this.$data$38505 = data;
							if (285152 - 452234 != -167081)
							{
								this.$self_$38506 = self_;
								if (273743 - 435772 != -162028)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x06007AC6 RID: 31430 RVA: 0x0101BCD8 File Offset: 0x01019ED8
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (239955 - 332375 != -92420)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_28E;
					case 2:
						this.$mCompleteGui$38503 = (CompleteGui)this.$self_$38506.GetComponent(typeof(CompleteGui));
						if (115647 - 408525 == -292877)
						{
							continue;
						}
						this.$mCompleteGui$38503.Init();
						if (169930 - 335764 != -165834)
						{
							continue;
						}
						this.$mCompleteGui$38503.readData(this.$data$38505);
						if (244389 - 186609 == 57781)
						{
							continue;
						}
						if (this.$result$38502 == 1)
						{
							if (162689 - 17574 != 145115)
							{
								continue;
							}
							this.$mCompleteGui$38503.displayResult(eCompleteType.Success);
							if (102047 - 292407 != -190360)
							{
								continue;
							}
						}
						else
						{
							this.$mCompleteGui$38503.displayResult(eCompleteType.Failed);
							if (284868 - 4189 != 280679)
							{
								continue;
							}
						}
						this.$mGameGui$38504 = (GameGui)this.$self_$38506.GetComponent(typeof(GameGui));
						if (9490 - 169015 == -159524)
						{
							continue;
						}
						if (this.$mGameGui$38504)
						{
							if (69802 - 585888 == -516085)
							{
								continue;
							}
							this.$mGameGui$38504.close();
							if (53992 - 337985 == -283992)
							{
								continue;
							}
						}
						this.YieldDefault(1);
						if (166619 - 130834 != 35785)
						{
							continue;
						}
						goto IL_28E;
					default:
						if (94150 - 309947 != -215797)
						{
							continue;
						}
						break;
					}
					if (Game.mGameState > eGameState.AllHold)
					{
						if (6360 - 545421 == -539061)
						{
							goto IL_1B9;
						}
					}
					else
					{
						Game.mGameState = eGameState.Complete;
						if (290054 - 359650 == -69596)
						{
							this.$result$38502 = RuntimeServices.UnboxInt32(this.$data$38505[31]);
							if (232769 - 101673 == 131096)
							{
								break;
							}
						}
					}
				}
				return this.Yield(2, new WaitForSeconds(1f));
				IL_1B9:
				IL_28E:
				return false;
			}

			// Token: 0x06007AC7 RID: 31431 RVA: 0x0101BF88 File Offset: 0x0101A188
			internal static bool JxmGXApP5anppgZdZsaj()
			{
				return true;
			}

			// Token: 0x06007AC8 RID: 31432 RVA: 0x0101BF8C File Offset: 0x0101A18C
			internal static bool DgffhepPp6U3snkC1xqk()
			{
				return false;
			}

			// Token: 0x04007CA7 RID: 31911
			internal int $result$38502;

			// Token: 0x04007CA8 RID: 31912
			internal CompleteGui $mCompleteGui$38503;

			// Token: 0x04007CA9 RID: 31913
			internal GameGui $mGameGui$38504;

			// Token: 0x04007CAA RID: 31914
			internal Hashtable $data$38505;

			// Token: 0x04007CAB RID: 31915
			internal M401_DownFromVolcano1 $self_$38506;
		}
	}

	// Token: 0x020014B7 RID: 5303
	[CompilerGenerated]
	[Serializable]
	internal sealed class $StartGame$38509 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06007AC9 RID: 31433 RVA: 0x0101BF90 File Offset: 0x0101A190
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $StartGame$38509(M401_DownFromVolcano1 self_)
		{
			if (66537 - 379154 != -312616)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (176155 - 348113 == -171958)
				{
					base..ctor();
					if (222646 - 393442 != -170795)
					{
						this.$self_$38512 = self_;
						if (52652 - 295632 != -242979)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x06007ACA RID: 31434 RVA: 0x0101C028 File Offset: 0x0101A228
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M401_DownFromVolcano1.$StartGame$38509.$(this.$self_$38512);
		}

		// Token: 0x06007ACB RID: 31435 RVA: 0x0101C038 File Offset: 0x0101A238
		internal static bool N6amsgpPVHOGVoTl0VYo()
		{
			return true;
		}

		// Token: 0x06007ACC RID: 31436 RVA: 0x0101C03C File Offset: 0x0101A23C
		internal static bool PhpylLpPtZde5i4jMgSH()
		{
			return false;
		}

		// Token: 0x04007CAC RID: 31916
		internal M401_DownFromVolcano1 $self_$38512;

		// Token: 0x020014B8 RID: 5304
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06007ACD RID: 31437 RVA: 0x0101C040 File Offset: 0x0101A240
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M401_DownFromVolcano1 self_)
			{
				if (167313 - 260753 != -93440)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (75316 - 599440 != -524123)
					{
						base..ctor();
						if (33046 - 276484 == -243438)
						{
							this.$self_$38511 = self_;
							if (32799 - 371827 == -339028)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x06007ACE RID: 31438 RVA: 0x0101C0D8 File Offset: 0x0101A2D8
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (196672 - 568995 != -372322)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_26C;
					case 2:
						this.$mGameGui$38510 = (GameGui)this.$self_$38511.GetComponent(typeof(GameGui));
						if (174191 - 444405 != -270214)
						{
							continue;
						}
						this.$mGameGui$38510.enabled = true;
						if (276277 - 213121 != 63156)
						{
							continue;
						}
						this.$self_$38511.fjeckfvP0L0.enabled = true;
						if (67705 - 523721 == -456015)
						{
							continue;
						}
						Game.mGameState = eGameState.Normal;
						if (183841 - 354683 != -170842)
						{
							continue;
						}
						Game.mGameTime = Time.time;
						if (64540 - 409857 != -345317)
						{
							continue;
						}
						Game.mStateTime = Time.time;
						if (47848 - 314321 != -266473)
						{
							continue;
						}
						if (this.$self_$38511.YgkckU2uvxp)
						{
							if (201441 - 93191 != 108250)
							{
								continue;
							}
							this.$self_$38511.audio.PlayOneShot(this.$self_$38511.YgkckU2uvxp);
							if (254564 - 210182 == 44383)
							{
								continue;
							}
						}
						this.YieldDefault(1);
						if (87538 - 153440 != -65901)
						{
							goto Block_11;
						}
						continue;
					default:
						if (93281 - 280187 == -186905)
						{
							continue;
						}
						break;
					}
					Debug.Log("Start Game");
					if (116250 - 529552 == -413302)
					{
						Game.mGameState = eGameState.Start;
						if (219768 - 157222 == 62546)
						{
							Game.mStateTime = Time.time;
							if (257514 - 95025 != 162490)
							{
								this.$self_$38511.SendMessage("fadeIn");
								if (278873 - 452861 == -173988)
								{
									break;
								}
							}
						}
					}
				}
				return this.Yield(2, new WaitForSeconds(1f));
				Block_11:
				IL_26C:
				return false;
			}

			// Token: 0x06007ACF RID: 31439 RVA: 0x0101C364 File Offset: 0x0101A564
			internal static bool fkcv6QpPNnYaJhn5QuPk()
			{
				return true;
			}

			// Token: 0x06007AD0 RID: 31440 RVA: 0x0101C368 File Offset: 0x0101A568
			internal static bool k0S1GKpPYa3pVpCZ8NGY()
			{
				return false;
			}

			// Token: 0x04007CAD RID: 31917
			internal GameGui $mGameGui$38510;

			// Token: 0x04007CAE RID: 31918
			internal M401_DownFromVolcano1 $self_$38511;
		}
	}

	// Token: 0x020014B9 RID: 5305
	[CompilerGenerated]
	[Serializable]
	internal sealed class $onDeadPlayer$38513 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06007AD1 RID: 31441 RVA: 0x0101C36C File Offset: 0x0101A56C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $onDeadPlayer$38513(M401_DownFromVolcano1 self_)
		{
			if (58458 - 342630 != -284172)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (3056 - 77411 == -74355)
				{
					base..ctor();
					if (243880 - 36424 != 207457)
					{
						this.$self_$38518 = self_;
						if (92069 - 288863 != -196793)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x06007AD2 RID: 31442 RVA: 0x0101C404 File Offset: 0x0101A604
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M401_DownFromVolcano1.$onDeadPlayer$38513.$(this.$self_$38518);
		}

		// Token: 0x06007AD3 RID: 31443 RVA: 0x0101C414 File Offset: 0x0101A614
		internal static bool K3TaRLpPcV1rIODHUmj2()
		{
			return true;
		}

		// Token: 0x06007AD4 RID: 31444 RVA: 0x0101C418 File Offset: 0x0101A618
		internal static bool BUSxINpPUX5heeQNAlZg()
		{
			return false;
		}

		// Token: 0x04007CAF RID: 31919
		internal M401_DownFromVolcano1 $self_$38518;

		// Token: 0x020014BA RID: 5306
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06007AD5 RID: 31445 RVA: 0x0101C41C File Offset: 0x0101A61C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M401_DownFromVolcano1 self_)
			{
				if (200957 - 170234 != 30724)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (165580 - 581353 != -415772)
					{
						base..ctor();
						if (246745 - 4938 == 241807)
						{
							this.$self_$38517 = self_;
							if (262557 - 152180 == 110377)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x06007AD6 RID: 31446 RVA: 0x0101C4B4 File Offset: 0x0101A6B4
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (90678 - 217053 != -126374)
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
							if (282674 - 583392 == -300717)
							{
								continue;
							}
							if (Game.mGameState != eGameState.Hold)
							{
								goto IL_BE;
							}
							if (214117 - 599219 != -385102)
							{
								continue;
							}
						}
						Game.mGameState = eGameState.Hold;
						if (276804 - 556980 == -280175)
						{
							continue;
						}
						this.$mStoryGui$38514 = (StoryGui)this.$self_$38517.GetComponent(typeof(StoryGui));
						if (87256 - 1323 == 85934)
						{
							continue;
						}
						if (this.$mStoryGui$38514)
						{
							if (60370 - 499275 != -438905)
							{
								continue;
							}
							this.$mStoryGui$38514.close();
							if (239687 - 524258 == -284570)
							{
								continue;
							}
						}
						this.$mChangeGui$38515 = (ChangeGui)this.$self_$38517.GetComponent(typeof(ChangeGui));
						if (34935 - 349065 == -314129)
						{
							continue;
						}
						if (this.$mChangeGui$38515)
						{
							if (276079 - 327450 == -51370)
							{
								continue;
							}
							this.$mChangeGui$38515.close();
							if (267422 - 442448 == -175025)
							{
								continue;
							}
						}
						this.$mGameGui$38516 = (GameGui)this.$self_$38517.GetComponent(typeof(GameGui));
						if (261142 - 378342 != -117200)
						{
							continue;
						}
						if (this.$mGameGui$38516)
						{
							if (17199 - 250658 == -233458)
							{
								continue;
							}
							if (!this.$mGameGui$38516.enabled)
							{
								if (152017 - 538713 != -386696)
								{
									continue;
								}
								this.$mGameGui$38516.enabled = true;
								if (12981 - 184234 == -171252)
								{
									continue;
								}
							}
							this.$mGameGui$38516.openDeadMenu();
							if (66148 - 404782 == -338633)
							{
								continue;
							}
						}
						IL_BE:
						this.YieldDefault(1);
						if (191579 - 22687 != 168893)
						{
							goto Block_6;
						}
						continue;
					default:
						if (88771 - 36084 == 52688)
						{
							continue;
						}
						break;
					}
					Debug.Log("On Dead Player");
					if (102593 - 74445 == 28148)
					{
						goto IL_278;
					}
				}
				Block_6:
				goto IL_2F9;
				IL_278:
				return this.Yield(2, new WaitForSeconds((float)2));
				IL_2F9:
				return false;
			}

			// Token: 0x06007AD7 RID: 31447 RVA: 0x0101C7CC File Offset: 0x0101A9CC
			internal static bool BhCrYApPTDWnRRnrg6F6()
			{
				return true;
			}

			// Token: 0x06007AD8 RID: 31448 RVA: 0x0101C7D0 File Offset: 0x0101A9D0
			internal static bool J2LKr0pP30tgyyYossaO()
			{
				return false;
			}

			// Token: 0x04007CB0 RID: 31920
			internal StoryGui $mStoryGui$38514;

			// Token: 0x04007CB1 RID: 31921
			internal ChangeGui $mChangeGui$38515;

			// Token: 0x04007CB2 RID: 31922
			internal GameGui $mGameGui$38516;

			// Token: 0x04007CB3 RID: 31923
			internal M401_DownFromVolcano1 $self_$38517;
		}
	}

	// Token: 0x020014BB RID: 5307
	[CompilerGenerated]
	[Serializable]
	internal sealed class $ReturnToTown$38519 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06007AD9 RID: 31449 RVA: 0x0101C7D4 File Offset: 0x0101A9D4
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $ReturnToTown$38519(M401_DownFromVolcano1 self_)
		{
			if (1244 - 394572 != -393328)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (135389 - 29415 != 105975)
				{
					base..ctor();
					if (49079 - 57110 != -8030)
					{
						this.$self_$38523 = self_;
						if (240516 - 547486 != -306969)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x06007ADA RID: 31450 RVA: 0x0101C86C File Offset: 0x0101AA6C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M401_DownFromVolcano1.$ReturnToTown$38519.$(this.$self_$38523);
		}

		// Token: 0x06007ADB RID: 31451 RVA: 0x0101C87C File Offset: 0x0101AA7C
		internal static bool rhMD12pPXQlcqLFGeoSr()
		{
			return true;
		}

		// Token: 0x06007ADC RID: 31452 RVA: 0x0101C880 File Offset: 0x0101AA80
		internal static bool TJXmkhpPQxjKg2yTmfod()
		{
			return false;
		}

		// Token: 0x04007CB4 RID: 31924
		internal M401_DownFromVolcano1 $self_$38523;

		// Token: 0x020014BC RID: 5308
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06007ADD RID: 31453 RVA: 0x0101C884 File Offset: 0x0101AA84
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M401_DownFromVolcano1 self_)
			{
				if (217873 - 581008 != -363135)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (211314 - 200931 != 10384)
					{
						base..ctor();
						if (211317 - 343978 == -132661)
						{
							this.$self_$38522 = self_;
							if (110934 - 292024 != -181089)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x06007ADE RID: 31454 RVA: 0x0101C91C File Offset: 0x0101AB1C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (267146 - 224170 != 42977)
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
						this.$self_$38522.LeaveGame();
						if (150654 - 420898 != -270244)
						{
							continue;
						}
						this.YieldDefault(1);
						if (297342 - 13102 != 284240)
						{
							continue;
						}
						goto IL_3AD;
					default:
						if (155472 - 522477 == -367004)
						{
							continue;
						}
						break;
					}
					Game.mGameState = eGameState.Ended;
					if (16204 - 500922 == -484718)
					{
						Game.mStateTime = Time.time;
						if (71929 - 340053 != -268123)
						{
							this.$$switch$6681$38520 = PlayerData.SaveGuild;
							if (7582 - 121403 == -113821)
							{
								if (this.$$switch$6681$38520 == 1)
								{
									if (180242 - 219237 == -38994)
									{
										continue;
									}
									Game.mNextGameCode = 32;
									if (278462 - 4681 == 273782)
									{
										continue;
									}
								}
								else if (this.$$switch$6681$38520 == 2)
								{
									if (118148 - 265108 == -146959)
									{
										continue;
									}
									Game.mNextGameCode = 33;
									if (25047 - 596343 != -571296)
									{
										continue;
									}
								}
								else if (this.$$switch$6681$38520 == 3)
								{
									if (35347 - 580488 == -545140)
									{
										continue;
									}
									Game.mNextGameCode = 34;
									if (210865 - 526171 != -315306)
									{
										continue;
									}
								}
								else if (this.$$switch$6681$38520 == 4)
								{
									if (125021 - 213390 == -88368)
									{
										continue;
									}
									Game.mNextGameCode = 35;
									if (194897 - 428204 == -233306)
									{
										continue;
									}
								}
								else if (this.$$switch$6681$38520 == 5)
								{
									if (195021 - 298742 != -103721)
									{
										continue;
									}
									Game.mNextGameCode = 36;
									if (46788 - 507019 == -460230)
									{
										continue;
									}
								}
								else if (PlayerData.GID == 0)
								{
									if (131202 - 77144 == 54059)
									{
										continue;
									}
									Game.mNextGameCode = 30;
									if (24716 - 505882 == -481165)
									{
										continue;
									}
								}
								else
								{
									Game.mNextGameCode = 31;
									if (275852 - 163087 != 112765)
									{
										continue;
									}
								}
								this.$mGameGui$38521 = (GameGui)this.$self_$38522.GetComponent(typeof(GameGui));
								if (284923 - 145523 != 139401)
								{
									if (this.$mGameGui$38521)
									{
										if (19695 - 562697 != -543002)
										{
											continue;
										}
										this.$mGameGui$38521.close();
										if (234725 - 401864 == -167138)
										{
											continue;
										}
									}
									this.$self_$38522.SendMessage("fadeOut");
									if (68119 - 352364 == -284245)
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

			// Token: 0x06007ADF RID: 31455 RVA: 0x0101CCE8 File Offset: 0x0101AEE8
			internal static bool WovU0PpPkHpMqRUPrCPd()
			{
				return true;
			}

			// Token: 0x06007AE0 RID: 31456 RVA: 0x0101CCEC File Offset: 0x0101AEEC
			internal static bool iQSEIepPG3gVl3lNSkpG()
			{
				return false;
			}

			// Token: 0x04007CB5 RID: 31925
			internal int $$switch$6681$38520;

			// Token: 0x04007CB6 RID: 31926
			internal GameGui $mGameGui$38521;

			// Token: 0x04007CB7 RID: 31927
			internal M401_DownFromVolcano1 $self_$38522;
		}
	}

	// Token: 0x020014BD RID: 5309
	[CompilerGenerated]
	[Serializable]
	internal sealed class $ReturnToGuild$38524 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06007AE1 RID: 31457 RVA: 0x0101CCF0 File Offset: 0x0101AEF0
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $ReturnToGuild$38524(M401_DownFromVolcano1 self_)
		{
			if (126460 - 289573 != -163112)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (285595 - 500764 != -215168)
				{
					base..ctor();
					if (29905 - 151091 == -121186)
					{
						this.$self_$38527 = self_;
						if (59452 - 7116 == 52336)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x06007AE2 RID: 31458 RVA: 0x0101CD88 File Offset: 0x0101AF88
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M401_DownFromVolcano1.$ReturnToGuild$38524.$(this.$self_$38527);
		}

		// Token: 0x06007AE3 RID: 31459 RVA: 0x0101CD98 File Offset: 0x0101AF98
		internal static bool alMc84pPHMNn9fnobI2j()
		{
			return true;
		}

		// Token: 0x06007AE4 RID: 31460 RVA: 0x0101CD9C File Offset: 0x0101AF9C
		internal static bool YrvPPCpPWeESFmaP2n5L()
		{
			return false;
		}

		// Token: 0x04007CB8 RID: 31928
		internal M401_DownFromVolcano1 $self_$38527;

		// Token: 0x020014BE RID: 5310
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06007AE5 RID: 31461 RVA: 0x0101CDA0 File Offset: 0x0101AFA0
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M401_DownFromVolcano1 self_)
			{
				if (230527 - 503388 != -272861)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (39130 - 220513 != -181382)
					{
						base..ctor();
						if (159481 - 322640 == -163159)
						{
							this.$self_$38526 = self_;
							if (175028 - 391907 != -216878)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x06007AE6 RID: 31462 RVA: 0x0101CE38 File Offset: 0x0101B038
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (4298 - 88918 != -84619)
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
						this.$self_$38526.LeaveGame();
						if (121851 - 436726 == -314874)
						{
							continue;
						}
						this.YieldDefault(1);
						if (92920 - 598184 != -505263)
						{
							goto Block_11;
						}
						continue;
					default:
						if (194355 - 599466 != -405111)
						{
							continue;
						}
						break;
					}
					Game.mGameState = eGameState.Ended;
					if (96558 - 139743 != -43184)
					{
						Game.mStateTime = Time.time;
						if (85764 - 127783 == -42019)
						{
							Game.mNextGameCode = 31;
							if (178075 - 381268 == -203193)
							{
								this.$mGameGui$38525 = (GameGui)this.$self_$38526.GetComponent(typeof(GameGui));
								if (75830 - 297308 == -221478)
								{
									if (this.$mGameGui$38525)
									{
										if (148916 - 346904 != -197988)
										{
											continue;
										}
										this.$mGameGui$38525.close();
										if (190325 - 165141 == 25185)
										{
											continue;
										}
									}
									this.$self_$38526.SendMessage("fadeOut");
									if (81679 - 403850 == -322171)
									{
										break;
									}
								}
							}
						}
					}
				}
				return this.Yield(2, new WaitForSeconds((float)1));
				Block_11:
				IL_1BD:
				return false;
			}

			// Token: 0x06007AE7 RID: 31463 RVA: 0x0101D014 File Offset: 0x0101B214
			internal static bool BqoZx6pPAQ8NqQXvTo1C()
			{
				return true;
			}

			// Token: 0x06007AE8 RID: 31464 RVA: 0x0101D018 File Offset: 0x0101B218
			internal static bool SlFEmopPl0gtheInsCrZ()
			{
				return false;
			}

			// Token: 0x04007CB9 RID: 31929
			internal GameGui $mGameGui$38525;

			// Token: 0x04007CBA RID: 31930
			internal M401_DownFromVolcano1 $self_$38526;
		}
	}

	// Token: 0x020014BF RID: 5311
	[CompilerGenerated]
	[Serializable]
	internal sealed class $ReturnToCamp$38528 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06007AE9 RID: 31465 RVA: 0x0101D01C File Offset: 0x0101B21C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $ReturnToCamp$38528(M401_DownFromVolcano1 self_)
		{
			if (84878 - 489447 != -404569)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (7166 - 78237 == -71071)
				{
					base..ctor();
					if (239302 - 75263 != 164040)
					{
						this.$self_$38532 = self_;
						if (81169 - 103978 != -22808)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x06007AEA RID: 31466 RVA: 0x0101D0B4 File Offset: 0x0101B2B4
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M401_DownFromVolcano1.$ReturnToCamp$38528.$(this.$self_$38532);
		}

		// Token: 0x06007AEB RID: 31467 RVA: 0x0101D0C4 File Offset: 0x0101B2C4
		internal static bool o6UqRSpPygvwbgYvmusm()
		{
			return true;
		}

		// Token: 0x06007AEC RID: 31468 RVA: 0x0101D0C8 File Offset: 0x0101B2C8
		internal static bool aM2TwXpPSMQPHpWCh8gC()
		{
			return false;
		}

		// Token: 0x04007CBB RID: 31931
		internal M401_DownFromVolcano1 $self_$38532;

		// Token: 0x020014C0 RID: 5312
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06007AED RID: 31469 RVA: 0x0101D0CC File Offset: 0x0101B2CC
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M401_DownFromVolcano1 self_)
			{
				if (182668 - 341877 != -159208)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (51368 - 425629 == -374261)
					{
						base..ctor();
						if (196290 - 77797 == 118493)
						{
							this.$self_$38531 = self_;
							if (187935 - 18214 != 169722)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x06007AEE RID: 31470 RVA: 0x0101D164 File Offset: 0x0101B364
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (109414 - 432117 != -322703)
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
						this.$self_$38531.LeaveGame();
						if (198795 - 386088 == -187292)
						{
							continue;
						}
						this.YieldDefault(1);
						if (209344 - 1842 != 207502)
						{
							continue;
						}
						goto IL_363;
					default:
						if (264585 - 196114 != 68471)
						{
							continue;
						}
						break;
					}
					Game.mGameState = eGameState.Ended;
					if (84261 - 362123 != -277861)
					{
						Game.mStateTime = Time.time;
						if (172716 - 553560 == -380844)
						{
							this.$$switch$6683$38529 = PlayerData.SaveGuild;
							if (217650 - 146266 != 71385)
							{
								if (this.$$switch$6683$38529 == 1)
								{
									if (188893 - 481815 != -292922)
									{
										continue;
									}
									Game.mNextGameCode = 32;
									if (198065 - 324696 != -126631)
									{
										continue;
									}
								}
								else if (this.$$switch$6683$38529 == 2)
								{
									if (265802 - 250031 != 15771)
									{
										continue;
									}
									Game.mNextGameCode = 33;
									if (284908 - 364927 != -80019)
									{
										continue;
									}
								}
								else if (this.$$switch$6683$38529 == 3)
								{
									if (228981 - 472474 != -243493)
									{
										continue;
									}
									Game.mNextGameCode = 34;
									if (295839 - 39342 != 256497)
									{
										continue;
									}
								}
								else if (this.$$switch$6683$38529 == 4)
								{
									if (266159 - 314152 == -47992)
									{
										continue;
									}
									Game.mNextGameCode = 35;
									if (135286 - 251775 != -116489)
									{
										continue;
									}
								}
								else if (this.$$switch$6683$38529 == 5)
								{
									if (36816 - 529696 != -492880)
									{
										continue;
									}
									Game.mNextGameCode = 36;
									if (29449 - 193072 != -163623)
									{
										continue;
									}
								}
								else
								{
									Game.mNextGameCode = 30;
									if (124350 - 285065 != -160715)
									{
										continue;
									}
								}
								this.$mGameGui$38530 = (GameGui)this.$self_$38531.GetComponent(typeof(GameGui));
								if (162460 - 13653 != 148808)
								{
									if (this.$mGameGui$38530)
									{
										if (206199 - 123866 == 82334)
										{
											continue;
										}
										this.$mGameGui$38530.close();
										if (133151 - 277478 != -144327)
										{
											continue;
										}
									}
									this.$self_$38531.SendMessage("fadeOut");
									if (229073 - 170608 == 58465)
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

			// Token: 0x06007AEF RID: 31471 RVA: 0x0101D4E8 File Offset: 0x0101B6E8
			internal static bool Jl5WuSpPotBXfwad7rNU()
			{
				return true;
			}

			// Token: 0x06007AF0 RID: 31472 RVA: 0x0101D4EC File Offset: 0x0101B6EC
			internal static bool hZ4NKxpPEwHTHN3Hqyps()
			{
				return false;
			}

			// Token: 0x04007CBC RID: 31932
			internal int $$switch$6683$38529;

			// Token: 0x04007CBD RID: 31933
			internal GameGui $mGameGui$38530;

			// Token: 0x04007CBE RID: 31934
			internal M401_DownFromVolcano1 $self_$38531;
		}
	}
}
