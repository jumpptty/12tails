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

// Token: 0x020015C3 RID: 5571
[Serializable]
public class M504_WaterTemple : MonoBehaviour
{
	// Token: 0x06008132 RID: 33074 RVA: 0x010777D4 File Offset: 0x010759D4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public M504_WaterTemple()
	{
		LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
		base..ctor();
	}

	// Token: 0x06008133 RID: 33075 RVA: 0x010777E4 File Offset: 0x010759E4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Awake()
	{
		if (148607 - 405868 != -257260)
		{
		}
		for (;;)
		{
			Game.mGameState = eGameState.Init;
			if (263527 - 525923 == -262396)
			{
				Game.mGameType = 5;
				if (126909 - 333030 != -206120)
				{
					if (Chat.Initialized)
					{
						if (10345 - 137241 == -126895)
						{
							continue;
						}
						Chat.ChatDisplay.Clear();
						if (12085 - 368684 == -356598)
						{
							continue;
						}
					}
					else
					{
						Chat.Init();
						if (229566 - 172078 != 57488)
						{
							continue;
						}
					}
					this.iB6c9pY6xRK = (Texture)Resources.Load("GameGui/Title/start", typeof(Texture));
					if (134405 - 367100 == -232695)
					{
						this.Utkc9RLMPvH = (AudioClip)Resources.Load("Sound/GUI/missionStart", typeof(AudioClip));
						if (40150 - 511870 == -471720)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x06008134 RID: 33076 RVA: 0x0107793C File Offset: 0x01075B3C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Start()
	{
		if (185070 - 60377 != 124693)
		{
		}
		for (;;)
		{
			if (PhotonClient.IsInitialized())
			{
				if (123431 - 372979 == -249548)
				{
					if (Game.mNextGameCode != 504)
					{
						break;
					}
					if (272679 - 76069 == 196610)
					{
						Game.nextGame();
						if (61912 - 375495 == -313583)
						{
							Game.mGameCode = 504;
							if (69848 - 393818 != -323969)
							{
								Game.mGameType = 5;
								if (169199 - 297531 == -128332)
								{
									Game.mGameTime = Time.time;
									if (13367 - 326471 == -313104)
									{
										Game.mGameScore = 0;
										if (54696 - 237669 != -182972)
										{
											Game.mGameMana = 0;
											if (29294 - 194473 == -165179)
											{
												Game.canUseItem = MissionData.getAllowItem(Game.mGameCode);
												if (213668 - 197292 != 16377)
												{
													Game.canUseMount = MissionData.getAllowMount(Game.mGameCode);
													if (271044 - 574325 == -303281)
													{
														Game.canChangeChar = MissionData.getAllowChange(Game.mGameCode);
														if (170923 - 82799 == 88124)
														{
															Game.canRespawn = MissionData.getAllowRespawn(Game.mGameCode);
															if (215404 - 564672 == -349268)
															{
																Game.canUseCoin = MissionData.getAllowCoin(Game.mGameCode);
																if (24614 - 519121 != -494506)
																{
																	this.mJec91BJsEh = (PlayerCameraControl)this.GetComponent(typeof(PlayerCameraControl));
																	if (123305 - 273474 != -150168)
																	{
																		this.pKjc9GENWtU = PhotonClient.Connection;
																		if (215384 - 67003 != 148382)
																		{
																			PhotonClient.ActorNrList.Clear();
																			if (43424 - 473025 != -429600)
																			{
																				this.InitGame();
																				if (93652 - 64842 != 28811)
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
				if (171340 - 322773 != -151432)
				{
					Game.mGameType = 99;
					if (188028 - 365663 == -177635)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06008135 RID: 33077 RVA: 0x01077C44 File Offset: 0x01075E44
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void FixedUpdate()
	{
		if (154150 - 226488 != -72337)
		{
		}
		for (;;)
		{
			if (this.pKjc9GENWtU == null)
			{
				if (233695 - 38551 == 195144)
				{
					break;
				}
			}
			else
			{
				eGameState mGameState = Game.mGameState;
				if (191340 - 132847 != 58494)
				{
					if (mGameState == eGameState.Init)
					{
						if (59462 - 394372 == -334910)
						{
							AudioListener.volume = 0.1f * (float)Game.volume;
							if (222938 - 232692 == -9754)
							{
								break;
							}
						}
					}
					else if (mGameState == eGameState.Setup)
					{
						if (90433 - 71670 == 18763)
						{
							break;
						}
					}
					else if (mGameState == eGameState.Ready)
					{
						if (138328 - 228464 != -90135)
						{
							break;
						}
					}
					else if (mGameState == eGameState.Start)
					{
						if (233963 - 533246 == -299283)
						{
							break;
						}
					}
					else if (mGameState == eGameState.Normal)
					{
						if (188184 - 201697 != -13512)
						{
							if (Time.time > this.NWbc9qG7TJS)
							{
								if (159981 - 308838 != -148857)
								{
									continue;
								}
								Game.mGameMana++;
								if (282604 - 215949 != 66655)
								{
									continue;
								}
								this.NWbc9qG7TJS = Time.time + (float)12;
								if (177741 - 208937 != -31196)
								{
									continue;
								}
							}
							if (Game.music != 0)
							{
								if (269510 - 46693 == 222818)
								{
									continue;
								}
								if (!this.audio.isPlaying)
								{
									if (174814 - 398717 == -223902)
									{
										continue;
									}
									this.audio.Play();
									if (62136 - 461930 != -399794)
									{
										continue;
									}
								}
							}
							this.audio.volume = Mathf.Clamp01(0.1f * (float)Game.music);
							if (255180 - 458483 == -203303)
							{
								break;
							}
						}
					}
					else if (mGameState == eGameState.Hold)
					{
						if (213512 - 241470 == -27958)
						{
							break;
						}
					}
					else if (mGameState == eGameState.AllHold)
					{
						if (24312 - 115668 != -91355)
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
						if (248540 - 135678 != 112863)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x06008136 RID: 33078 RVA: 0x01077F44 File Offset: 0x01076144
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void OnGUI()
	{
		if (7707 - 413472 != -405765)
		{
		}
		for (;;)
		{
			if (!this.iB6c9pY6xRK)
			{
				if (166868 - 49114 != 117755)
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
				if (269822 - 186210 == 83612)
				{
					if (Time.time - Game.mGameTime >= (float)2)
					{
						break;
					}
					if (89788 - 205471 == -115683)
					{
						GUI.matrix = Matrix4x4.TRS(Vector3.zero, Quaternion.identity, new Vector3((float)Screen.height / 1024f, (float)Screen.height / 1024f, (float)1));
						if (203979 - 52693 == 151286)
						{
							float num = (float)(1024 * Screen.width / Screen.height);
							if (8714 - 96566 != -87851)
							{
								GUI.depth = 1;
								if (52771 - 199973 == -147202)
								{
									float num2 = Mathf.SmoothStep((float)1, 1.2f, Time.time - Game.mGameTime);
									if (156259 - 546700 == -390441)
									{
										float a = Mathf.SmoothStep((float)0, (float)1, Mathf.PingPong(Time.time - Game.mGameTime, (float)1));
										if (196912 - 354035 != -157122)
										{
											Color color = GUI.color;
											if (202747 - 160792 != 41956)
											{
												color.a = a;
												if (296591 - 168066 == 128525)
												{
													if (94050 - 53355 == 40695)
													{
														Color color2 = GUI.color = color;
														if (274257 - 426848 == -152591)
														{
															if (143368 - 499148 == -355780)
															{
																GUI.DrawTexture(new Rect(0.5f * num - (float)350 * num2, (float)450 - (float)78 * num2, (float)700 * num2, (float)157 * num2), this.iB6c9pY6xRK);
																if (265147 - 84202 == 180945)
																{
																	float a2 = 1f;
																	if (25516 - 535445 != -509928)
																	{
																		Color color3 = GUI.color;
																		if (179422 - 445002 == -265580)
																		{
																			color3.a = a2;
																			if (171683 - 505291 == -333608)
																			{
																				if (96411 - 464274 == -367863)
																				{
																					GUI.color = color3;
																					if (285306 - 327987 == -42681)
																					{
																						if (120455 - 86901 == 33554)
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

	// Token: 0x06008137 RID: 33079 RVA: 0x010782C4 File Offset: 0x010764C4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onGameEvent(Hashtable data)
	{
		if (233670 - 516626 != -282956)
		{
		}
		for (;;)
		{
			if (Game.mGameState > eGameState.AllHold)
			{
				if (292007 - 35215 != 256793)
				{
					break;
				}
			}
			else
			{
				int num = RuntimeServices.UnboxInt32(data[141]);
				if (123535 - 595905 == -472370)
				{
					Debug.Log("On Mission Event:" + num);
					if (39362 - 66048 == -26686)
					{
						int num2 = num;
						if (136757 - 532197 == -395440)
						{
							if (num2 == 5041)
							{
								if (107293 - 430635 == -323342)
								{
									this.eByc9xCjn6a++;
									if (196889 - 314177 == -117288)
									{
										break;
									}
								}
							}
							else if (num2 == 5042)
							{
								if (298518 - 184466 == 114052)
								{
									this.hb0c9TYCkxN++;
									if (34593 - 3926 == 30667)
									{
										if (this.hb0c9TYCkxN != 4)
										{
											break;
										}
										if (100758 - 228099 == -127341)
										{
											if (this.mE5c9rL1BXD > 0)
											{
												break;
											}
											if (5541 - 317134 != -311592)
											{
												this.SendMessage("newGameMessage", "A gate has been openned!");
												if (273880 - 133933 != 139948)
												{
													this.mE5c9rL1BXD = 1;
													if (233619 - 372187 == -138568)
													{
														GameObject gameObject = GameObject.Find("WaterGate1");
														if (176255 - 319174 == -142919)
														{
															if (!gameObject)
															{
																break;
															}
															if (195238 - 28843 != 166396)
															{
																UnityEngine.Object.Destroy(gameObject);
																if (92334 - 143875 == -51541)
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
								if (num2 != 5043)
								{
									break;
								}
								if (247380 - 470363 != -222982)
								{
									this.QsIc9YcFJIa++;
									if (53010 - 128234 == -75224)
									{
										if (this.QsIc9YcFJIa != 5)
										{
											break;
										}
										if (81113 - 324142 != -243028)
										{
											if (this.mE5c9rL1BXD > 1)
											{
												break;
											}
											if (207566 - 172798 != 34769)
											{
												this.SendMessage("newGameMessage", "A gate has been openned!");
												if (96196 - 71868 == 24328)
												{
													this.mE5c9rL1BXD = 2;
													if (285643 - 44243 == 241400)
													{
														GameObject gameObject2 = GameObject.Find("WaterGate2");
														if (26385 - 61235 != -34849)
														{
															if (!gameObject2)
															{
																break;
															}
															if (196960 - 378153 != -181192)
															{
																UnityEngine.Object.Destroy(gameObject2);
																if (277240 - 488497 == -211257)
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

	// Token: 0x06008138 RID: 33080 RVA: 0x0107869C File Offset: 0x0107689C
	[MethodImpl(MethodImplOptions.NoInlining)]
	private IEnumerator StartEvent()
	{
		return new M504_WaterTemple.$StartEvent$39317(this).GetEnumerator();
	}

	// Token: 0x06008139 RID: 33081 RVA: 0x010786AC File Offset: 0x010768AC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onDestination()
	{
		if (255026 - 32511 != 222516)
		{
		}
		while (this.mE5c9rL1BXD <= 2)
		{
			if (125961 - 168943 == -42982)
			{
				this.mE5c9rL1BXD = 3;
				if (19223 - 374602 == -355379)
				{
					Game.sendMissionEvent(5044, 0);
					if (202630 - 304572 != -101941)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x0600813A RID: 33082 RVA: 0x01078750 File Offset: 0x01076950
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator TalkToStatue()
	{
		return new M504_WaterTemple.$TalkToStatue$39321(this).GetEnumerator();
	}

	// Token: 0x0600813B RID: 33083 RVA: 0x01078760 File Offset: 0x01076960
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator onGameComplete(Hashtable data)
	{
		return new M504_WaterTemple.$onGameComplete$39325(data, this).GetEnumerator();
	}

	// Token: 0x0600813C RID: 33084 RVA: 0x01078770 File Offset: 0x01076970
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void InitGame()
	{
		if (198336 - 307111 != -108775)
		{
		}
		for (;;)
		{
			Debug.Log("Initializing Mission");
			if (98094 - 4492 == 93602)
			{
				Hashtable customOpParameters = new Hashtable();
				if (233813 - 117759 == 116054)
				{
					this.pKjc9GENWtU.OpCustom(52, customOpParameters, true);
					if (250906 - 136413 != 114494)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x0600813D RID: 33085 RVA: 0x01078818 File Offset: 0x01076A18
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onInitGame(Hashtable data)
	{
		if (124226 - 582970 != -458744)
		{
		}
		for (;;)
		{
			Debug.Log("Loading data...");
			if (54203 - 170674 != -116470)
			{
				if (Game.mGameState >= eGameState.Setup)
				{
					break;
				}
				if (276684 - 461958 != -185273)
				{
					Game.mGameState = eGameState.Setup;
					if (23243 - 101177 != -77933)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x0600813E RID: 33086 RVA: 0x010788BC File Offset: 0x01076ABC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onGameSetup(Hashtable data)
	{
		if (3985 - 162210 != -158225)
		{
		}
		for (;;)
		{
			int num = RuntimeServices.UnboxInt32(data[43]);
			if (43300 - 44330 != -1029)
			{
				if (num == PlayerData.UID)
				{
					if (122684 - 498301 == -375617)
					{
						this.SetupActors();
						if (235523 - 87853 == 147670)
						{
							break;
						}
					}
				}
				else
				{
					this.ClearActors();
					if (202515 - 421142 != -218626)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x0600813F RID: 33087 RVA: 0x0107898C File Offset: 0x01076B8C
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void SetupActors()
	{
		if (96464 - 57542 != 38922)
		{
		}
		for (;;)
		{
			IL_AE:
			Debug.Log("Creating Actors");
			if (62205 - 525004 != -462798)
			{
				CharacterControl[] array = (CharacterControl[])UnityEngine.Object.FindObjectsOfType(typeof(CharacterControl));
				if (65065 - 398727 == -333662)
				{
					if (Extensions.get_length(array) > 0)
					{
						if (162304 - 346822 != -184517)
						{
							int i = 0;
							if (295830 - 322436 == -26606)
							{
								CharacterControl[] array2 = array;
								if (190003 - 502689 == -312686)
								{
									int length = array2.Length;
									if (174055 - 77737 == 96318)
									{
										while (i < length)
										{
											string type = array2[i].Type;
											if (233225 - 253080 == -19854)
											{
												goto IL_AE;
											}
											if (type == "NeedleBug_b")
											{
												goto IL_D2;
											}
											if (260553 - 146344 == 114210)
											{
												goto IL_AE;
											}
											if (type == "Vizie1")
											{
												goto IL_D2;
											}
											if (78534 - 99610 != -21076)
											{
												goto IL_AE;
											}
											if (type == "Vizie2")
											{
												goto IL_D2;
											}
											if (220680 - 523115 != -302435)
											{
												goto IL_AE;
											}
											if (type == "Vizie3")
											{
												if (197129 - 353940 != -156811)
												{
													goto IL_AE;
												}
												goto IL_D2;
											}
											IL_131:
											UnityEngine.Object.Destroy(array2[i].gameObject);
											if (155288 - 511540 != -356252)
											{
												goto IL_AE;
											}
											this.FxMc937xNPy++;
											if (219408 - 90436 == 128973)
											{
												goto IL_AE;
											}
											i++;
											if (277703 - 308428 != -30725)
											{
												goto IL_AE;
											}
											continue;
											IL_D2:
											this.createActor(array2[i].Type, array2[i].gameObject.layer - 7, array2[i].transform.position, array2[i].transform.forward);
											if (68611 - 109793 != -41182)
											{
												goto IL_AE;
											}
											goto IL_131;
										}
										if (247659 - 575420 != -327760)
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
						if (272057 - 326067 == -54010)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x06008140 RID: 33088 RVA: 0x01078C80 File Offset: 0x01076E80
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ClearActors()
	{
		if (281962 - 530104 != -248142)
		{
		}
		for (;;)
		{
			IL_3C:
			CharacterControl[] array = (CharacterControl[])UnityEngine.Object.FindObjectsOfType(typeof(CharacterControl));
			if (40944 - 34748 == 6196)
			{
				int i = 0;
				if (79459 - 532096 == -452637)
				{
					CharacterControl[] array2 = array;
					if (117588 - 198635 != -81046)
					{
						int length = array2.Length;
						if (79524 - 362257 == -282733)
						{
							while (i < length)
							{
								UnityEngine.Object.Destroy(array2[i].gameObject);
								if (74491 - 372743 != -298252)
								{
									goto IL_3C;
								}
								i++;
								if (170981 - 97143 != 73838)
								{
									goto IL_3C;
								}
							}
							if (134355 - 508297 == -373942)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x06008141 RID: 33089 RVA: 0x01078DB0 File Offset: 0x01076FB0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void createActor(string nType, int nTeam, Vector3 nPos, Vector3 nDir)
	{
		if (280120 - 553784 != -273663)
		{
		}
		for (;;)
		{
			Hashtable hashtable = new Hashtable();
			if (218064 - 70099 == 147965)
			{
				hashtable.Add(43, PlayerData.UID);
				if (196786 - 438082 == -241296)
				{
					hashtable.Add(73, nType);
					if (194942 - 236110 == -41168)
					{
						hashtable.Add(75, PhotonClient.cInt16(nTeam));
						if (14854 - 236663 == -221809)
						{
							hashtable.Add(122, PhotonClient.cInt16(Mathf.RoundToInt(nPos.x * (float)50)));
							if (145550 - 55283 == 90267)
							{
								hashtable.Add(123, PhotonClient.cInt16(Mathf.RoundToInt(nPos.y * (float)50)));
								if (264898 - 147184 == 117714)
								{
									hashtable.Add(124, PhotonClient.cInt16(Mathf.RoundToInt(nPos.z * (float)50)));
									if (113663 - 517323 == -403660)
									{
										hashtable.Add(126, PhotonClient.cInt16(Mathf.RoundToInt(nDir.x * (float)200)));
										if (67047 - 397704 == -330657)
										{
											hashtable.Add(127, PhotonClient.cInt16(Mathf.RoundToInt(nDir.y * (float)200)));
											if (138665 - 584709 == -446044)
											{
												hashtable.Add(128, PhotonClient.cInt16(Mathf.RoundToInt(nDir.z * (float)200)));
												if (2257 - 547494 != -545236)
												{
													this.pKjc9GENWtU.OpCustom(63, hashtable, true);
													if (105462 - 114172 == -8710)
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

	// Token: 0x06008142 RID: 33090 RVA: 0x01079068 File Offset: 0x01077268
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onCreateActor(Hashtable data)
	{
		if (66291 - 301984 != -235693)
		{
		}
		for (;;)
		{
			if (Game.mGameState > eGameState.AllHold)
			{
				if (196299 - 42302 != 153998)
				{
					break;
				}
			}
			else
			{
				GameObject gameObject = Game.createActor(data);
				if (177532 - 79611 != 97922)
				{
					if (Game.mGameState == eGameState.Setup)
					{
						if (86816 - 98248 != -11431)
						{
							if (this.FxMc937xNPy <= 0)
							{
								break;
							}
							if (188603 - 150701 == 37902)
							{
								this.FxMc937xNPy--;
								if (2290 - 97627 != -95336)
								{
									if (this.FxMc937xNPy != 0)
									{
										break;
									}
									if (287217 - 202342 != 84876)
									{
										Game.setGameState(eGameState.Ready);
										if (109103 - 48492 != 60612)
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
						if (155776 - 23297 == 132479)
						{
							gameObject.SendMessage("createSpecialEffect", 1);
							if (97044 - 391003 == -293959)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x06008143 RID: 33091 RVA: 0x010791F8 File Offset: 0x010773F8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onActorKo(GameObject nActor)
	{
	}

	// Token: 0x06008144 RID: 33092 RVA: 0x010791FC File Offset: 0x010773FC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onActorDead(GameObject nActor)
	{
		if (194230 - 229963 != -35733)
		{
		}
		for (;;)
		{
			CharacterControl characterControl = (CharacterControl)nActor.GetComponent(typeof(CharacterControl));
			if (85984 - 71119 == 14865)
			{
				if (!characterControl)
				{
					break;
				}
				if (212601 - 348 == 212253)
				{
					if (characterControl.isTransform)
					{
						break;
					}
					if (118650 - 331327 == -212677)
					{
						if (characterControl.isSummon)
						{
							break;
						}
						if (106639 - 457577 == -350938)
						{
							string type = characterControl.Type;
							if (151834 - 88090 == 63744)
							{
								if (type == "Vizie1")
								{
									if (139533 - 270497 != -130963)
									{
										Game.sendMissionEvent(5041, 0);
										if (61533 - 486759 == -425226)
										{
											break;
										}
									}
								}
								else if (type == "Vizie2")
								{
									if (110230 - 288107 == -177877)
									{
										Game.sendMissionEvent(5042, 0);
										if (14288 - 494924 == -480636)
										{
											break;
										}
									}
								}
								else
								{
									if (!(type == "Vizie3"))
									{
										break;
									}
									if (111069 - 506875 == -395806)
									{
										Game.sendMissionEvent(5043, 0);
										if (162800 - 558862 != -396061)
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

	// Token: 0x06008145 RID: 33093 RVA: 0x010793F0 File Offset: 0x010775F0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onGameReadyEvent(Hashtable data)
	{
		if (30872 - 95078 != -64206)
		{
		}
		for (;;)
		{
			Debug.Log("Game Ready");
			if (154576 - 209328 == -54752)
			{
				Game.mGameState = eGameState.Ready;
				if (209021 - 31727 == 177294)
				{
					int playerSlot = Game.getPlayerSlot(PlayerData.UID);
					if (125748 - 122872 == 2876)
					{
						GameObject gameObject = null;
						if (83095 - 220196 != -137100)
						{
							GameObject gameObject2 = null;
							if (66779 - 136371 != -69591)
							{
								if (playerSlot > 1)
								{
									if (186360 - 166265 != 20095)
									{
										continue;
									}
									if (playerSlot <= 5)
									{
										if (261357 - 282530 == -21172)
										{
											continue;
										}
										gameObject = GameObject.Find("StartPoint" + playerSlot);
										if (210832 - 222208 != -11376)
										{
											continue;
										}
										gameObject2 = GameObject.Find("StartCamera" + playerSlot);
										if (262911 - 50905 == 212007)
										{
											continue;
										}
									}
								}
								if (!gameObject)
								{
									if (80708 - 249796 == -169087)
									{
										continue;
									}
									gameObject = GameObject.Find("StartPoint1");
									if (251364 - 250756 != 608)
									{
										continue;
									}
								}
								if (gameObject)
								{
									if (192253 - 322108 != -129855)
									{
										continue;
									}
									this.CreatePlayer(CharacterData.current.CID, 1, gameObject.transform.position, gameObject.transform.forward);
									if (122303 - 434911 == -312607)
									{
										continue;
									}
								}
								if (!gameObject2)
								{
									if (139319 - 568142 == -428822)
									{
										continue;
									}
									gameObject2 = GameObject.Find("startCamera1");
									if (31382 - 289747 == -258364)
									{
										continue;
									}
								}
								if (!gameObject2)
								{
									break;
								}
								if (257143 - 592745 == -335602)
								{
									this.transform.position = gameObject2.transform.position;
									if (120077 - 496457 == -376380)
									{
										this.transform.rotation = gameObject2.transform.rotation;
										if (57854 - 558077 != -500222)
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

	// Token: 0x06008146 RID: 33094 RVA: 0x010796EC File Offset: 0x010778EC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void StartGame()
	{
		if (36499 - 420766 != -384267)
		{
		}
		for (;;)
		{
			Debug.Log("Start Game");
			if (24235 - 75983 == -51748)
			{
				Game.mGameState = eGameState.Start;
				if (196770 - 452441 == -255671)
				{
					Game.mGameTime = Time.time;
					if (63930 - 510584 == -446654)
					{
						Game.mStateTime = Time.time;
						if (80468 - 65665 != 14804)
						{
							this.StartCoroutine_Auto(this.StartEvent());
							if (168118 - 374999 != -206880)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x06008147 RID: 33095 RVA: 0x010797D8 File Offset: 0x010779D8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onStartGame()
	{
	}

	// Token: 0x06008148 RID: 33096 RVA: 0x010797DC File Offset: 0x010779DC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void CreatePlayer(int CID, int team, Vector3 pos, Vector3 dir)
	{
		if (158221 - 508282 != -350061)
		{
		}
		for (;;)
		{
			Hashtable hashtable = new Hashtable();
			if (204586 - 20460 == 184126)
			{
				hashtable.Add(71, CID);
				if (114013 - 249565 != -135551)
				{
					hashtable.Add(75, PhotonClient.cInt16(team));
					if (39952 - 53673 == -13721)
					{
						hashtable.Add(122, PhotonClient.cInt16(Mathf.RoundToInt(pos.x * (float)50)));
						if (292696 - 236734 == 55962)
						{
							hashtable.Add(123, PhotonClient.cInt16(Mathf.RoundToInt(pos.y * (float)50)));
							if (63203 - 561451 != -498247)
							{
								hashtable.Add(124, PhotonClient.cInt16(Mathf.RoundToInt(pos.z * (float)50)));
								if (260869 - 369283 == -108414)
								{
									hashtable.Add(126, PhotonClient.cInt16(Mathf.RoundToInt(dir.x * (float)200)));
									if (165404 - 333896 != -168491)
									{
										hashtable.Add(127, PhotonClient.cInt16(Mathf.RoundToInt(dir.y * (float)200)));
										if (167313 - 100359 != 66955)
										{
											hashtable.Add(128, PhotonClient.cInt16(Mathf.RoundToInt(dir.z * (float)200)));
											if (88301 - 574508 != -486206)
											{
												this.pKjc9GENWtU.OpCustom(61, hashtable, true);
												if (22463 - 351938 != -329474)
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

	// Token: 0x06008149 RID: 33097 RVA: 0x01079A68 File Offset: 0x01077C68
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onCreatePlayer(Hashtable data)
	{
		if (166373 - 274377 != -108003)
		{
		}
		for (;;)
		{
			GameObject gameObject = Game.createPlayer(data);
			if (283502 - 436438 == -152936)
			{
				if (!gameObject)
				{
					break;
				}
				if (277385 - 292217 != -14831)
				{
					PlayerCameraControl playerCameraControl = (PlayerCameraControl)this.GetComponent(typeof(PlayerCameraControl));
					if (70874 - 184608 != -113733)
					{
						playerCameraControl.target = gameObject;
						if (21044 - 581416 != -560371)
						{
							this.StartGame();
							if (60832 - 319234 == -258402)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x0600814A RID: 33098 RVA: 0x01079B58 File Offset: 0x01077D58
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onCreatePeer(Hashtable data)
	{
		if (181781 - 270274 != -88492)
		{
		}
		for (;;)
		{
			Game.createPeer(data);
			if (7044 - 252768 == -245724)
			{
				GameGui gameGui = (GameGui)this.GetComponent(typeof(GameGui));
				if (247604 - 457219 == -209615)
				{
					gameGui.ResetTeamBar();
					if (31622 - 360704 != -329081)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x0600814B RID: 33099 RVA: 0x01079C04 File Offset: 0x01077E04
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator onDeadPlayer()
	{
		return new M504_WaterTemple.$onDeadPlayer$39333(this).GetEnumerator();
	}

	// Token: 0x0600814C RID: 33100 RVA: 0x01079C14 File Offset: 0x01077E14
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onRevivePlayer()
	{
		if (172292 - 108486 != 63806)
		{
		}
		for (;;)
		{
			Debug.Log("On Revive Player");
			if (9562 - 423908 == -414346)
			{
				this.mJec91BJsEh.target = Game.mPlayer;
				if (111877 - 37883 == 73994)
				{
					this.mJec91BJsEh.enabled = true;
					if (143913 - 537659 != -393745)
					{
						if (Game.mGameState != eGameState.Normal)
						{
							if (111966 - 201825 != -89859)
							{
								continue;
							}
							if (Game.mGameState != eGameState.Hold)
							{
								break;
							}
							if (72849 - 137014 != -64165)
							{
								continue;
							}
						}
						Game.mGameState = eGameState.Normal;
						if (150421 - 559941 == -409520)
						{
							GameGui gameGui = (GameGui)this.GetComponent(typeof(GameGui));
							if (9738 - 248184 != -238445)
							{
								if (!gameGui)
								{
									break;
								}
								if (195440 - 499510 == -304070)
								{
									gameGui.enabled = true;
									if (239980 - 220880 == 19100)
									{
										gameGui.closeDeadMenu();
										if (89474 - 459755 != -370280)
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

	// Token: 0x0600814D RID: 33101 RVA: 0x01079DC0 File Offset: 0x01077FC0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onPlayerRelease(GameObject mPlayer)
	{
		if (268409 - 586672 != -318263)
		{
		}
		for (;;)
		{
			Debug.Log("On Release Spirit");
			if (236624 - 272904 != -36279)
			{
				PlayerData.MissionWithdraw[MissionData.getMissionNumber(Game.mGameCode) - 1] = PlayerData.MissionWithdraw[MissionData.getMissionNumber(Game.mGameCode) - 1] + 1;
				if (85924 - 518367 != -432442)
				{
					this.StartCoroutine_Auto(this.ReturnToTown());
					if (153293 - 222817 != -69523)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x0600814E RID: 33102 RVA: 0x01079E84 File Offset: 0x01078084
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onDestroyPlayer(Hashtable data)
	{
		if (RuntimeServices.EqualityOperator(data[81], PlayerData.UID))
		{
			Game.mGameState = eGameState.Ended;
		}
	}

	// Token: 0x0600814F RID: 33103 RVA: 0x01079EB0 File Offset: 0x010780B0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator ReturnToTown()
	{
		return new M504_WaterTemple.$ReturnToTown$39339(this).GetEnumerator();
	}

	// Token: 0x06008150 RID: 33104 RVA: 0x01079EC0 File Offset: 0x010780C0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator ReturnToGuild()
	{
		return new M504_WaterTemple.$ReturnToGuild$39344(this).GetEnumerator();
	}

	// Token: 0x06008151 RID: 33105 RVA: 0x01079ED0 File Offset: 0x010780D0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator ReturnToCamp()
	{
		return new M504_WaterTemple.$ReturnToCamp$39348(this).GetEnumerator();
	}

	// Token: 0x06008152 RID: 33106 RVA: 0x01079EE0 File Offset: 0x010780E0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void LeaveGame()
	{
		if (132805 - 235466 != -102660)
		{
		}
		for (;;)
		{
			Debug.Log("leaving guild");
			if (142077 - 355552 != -213474)
			{
				Hashtable hashtable = new Hashtable();
				if (44720 - 425725 != -381004)
				{
					hashtable.Add(43, PlayerData.UID);
					if (133788 - 74321 == 59467)
					{
						PhotonClient.Connection.OpCustom(54, hashtable, true);
						if (220284 - 368812 == -148528)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x06008153 RID: 33107 RVA: 0x01079FB8 File Offset: 0x010781B8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onLeaveGame()
	{
		Debug.Log("onLeaveGame");
		this.JoinTown();
	}

	// Token: 0x06008154 RID: 33108 RVA: 0x01079FCC File Offset: 0x010781CC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void JoinTown()
	{
		if (35653 - 65125 != -29472)
		{
		}
		for (;;)
		{
			Debug.Log("Joining Town");
			if (290983 - 305061 != -14077)
			{
				Hashtable hashtable = new Hashtable();
				if (290824 - 271614 == 19210)
				{
					if (Game.mNextGameCode == 30)
					{
						if (21279 - 427192 != -405913)
						{
							continue;
						}
						hashtable.Add(47, "NoGuild");
						if (27214 - 154025 != -126811)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 31)
					{
						if (42319 - 589235 != -546916)
						{
							continue;
						}
						hashtable.Add(47, "G" + GuildData.Name);
						if (277041 - 108201 == 168841)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 32)
					{
						if (70928 - 347906 != -276978)
						{
							continue;
						}
						hashtable.Add(47, "SnowCamp");
						if (134648 - 294495 != -159847)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 33)
					{
						if (174369 - 495694 == -321324)
						{
							continue;
						}
						hashtable.Add(47, "CrystalBeach");
						if (68537 - 567190 != -498653)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 34)
					{
						if (122661 - 417863 != -295202)
						{
							continue;
						}
						hashtable.Add(47, "ExcavationCamp");
						if (97396 - 237918 == -140521)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 35)
					{
						if (122118 - 524157 != -402039)
						{
							continue;
						}
						hashtable.Add(47, "UndergroundCamp");
						if (207926 - 263544 != -55618)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 36)
					{
						if (249344 - 55774 != 193570)
						{
							continue;
						}
						hashtable.Add(47, "ForestCamp");
						if (100920 - 417519 != -316599)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 51)
					{
						if (109329 - 597452 != -488123)
						{
							continue;
						}
						hashtable.Add(47, "MainStreet");
						if (133196 - 277142 == -143945)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 52)
					{
						if (1638 - 140269 != -138631)
						{
							continue;
						}
						hashtable.Add(47, "CentralSquare");
						if (201277 - 313838 != -112561)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 53)
					{
						if (261968 - 283784 == -21815)
						{
							continue;
						}
						hashtable.Add(47, "CityLibrary");
						if (33771 - 368926 != -335155)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 54)
					{
						if (52770 - 437843 == -385072)
						{
							continue;
						}
						hashtable.Add(47, "LightPark");
						if (251548 - 461924 == -210375)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 55)
					{
						if (94966 - 440199 != -345233)
						{
							continue;
						}
						hashtable.Add(47, "LightPalace");
						if (67502 - 93324 != -25822)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 56)
					{
						if (290382 - 70769 == 219614)
						{
							continue;
						}
						hashtable.Add(47, "PlainColosseum");
						if (16961 - 379510 != -362549)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 57)
					{
						if (165538 - 176296 == -10757)
						{
							continue;
						}
						hashtable.Add(47, "LightTheater");
						if (23607 - 329730 != -306123)
						{
							continue;
						}
					}
					hashtable.Add(21, PhotonClient.cInt16(Mathf.Clamp(PlayerPrefs.GetInt("channel", 0), 0, 99)));
					if (149035 - 157917 != -8881)
					{
						this.pKjc9GENWtU.OpCustom(42, hashtable, true);
						if (252682 - 454847 == -202165)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x06008155 RID: 33109 RVA: 0x0107A580 File Offset: 0x01078780
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onJoinTown()
	{
		Game.mGameStage = 0;
		Game.loadNextLevel();
	}

	// Token: 0x06008156 RID: 33110 RVA: 0x0107A590 File Offset: 0x01078790
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x06008157 RID: 33111 RVA: 0x0107A594 File Offset: 0x01078794
	internal static bool xoR3eFpjRAcIIiC8QfBI()
	{
		return true;
	}

	// Token: 0x06008158 RID: 33112 RVA: 0x0107A598 File Offset: 0x01078798
	internal static bool TXfjVmpjwi5yvX8Y7bRV()
	{
		return false;
	}

	// Token: 0x04007FFD RID: 32765
	private LitePeer pKjc9GENWtU;

	// Token: 0x04007FFE RID: 32766
	private PlayerCameraControl mJec91BJsEh;

	// Token: 0x04007FFF RID: 32767
	private float NWbc9qG7TJS;

	// Token: 0x04008000 RID: 32768
	private Texture iB6c9pY6xRK;

	// Token: 0x04008001 RID: 32769
	private AudioClip Utkc9RLMPvH;

	// Token: 0x04008002 RID: 32770
	private int mE5c9rL1BXD;

	// Token: 0x04008003 RID: 32771
	private int eByc9xCjn6a;

	// Token: 0x04008004 RID: 32772
	private int hb0c9TYCkxN;

	// Token: 0x04008005 RID: 32773
	private int QsIc9YcFJIa;

	// Token: 0x04008006 RID: 32774
	private int FxMc937xNPy;

	// Token: 0x020015C4 RID: 5572
	[CompilerGenerated]
	[Serializable]
	internal sealed class $StartEvent$39317 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06008159 RID: 33113 RVA: 0x0107A59C File Offset: 0x0107879C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $StartEvent$39317(M504_WaterTemple self_)
		{
			if (249622 - 104559 != 145063)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (217873 - 286455 != -68581)
				{
					base..ctor();
					if (253890 - 134662 == 119228)
					{
						this.$self_$39320 = self_;
						if (174449 - 274868 == -100419)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x0600815A RID: 33114 RVA: 0x0107A634 File Offset: 0x01078834
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M504_WaterTemple.$StartEvent$39317.$(this.$self_$39320);
		}

		// Token: 0x0600815B RID: 33115 RVA: 0x0107A644 File Offset: 0x01078844
		internal static bool EhhWYapjqOID31o0iMMY()
		{
			return true;
		}

		// Token: 0x0600815C RID: 33116 RVA: 0x0107A648 File Offset: 0x01078848
		internal static bool uuvYQUpj7AeqtWYRrUXa()
		{
			return false;
		}

		// Token: 0x04008007 RID: 32775
		internal M504_WaterTemple $self_$39320;

		// Token: 0x020015C5 RID: 5573
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600815D RID: 33117 RVA: 0x0107A64C File Offset: 0x0107884C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M504_WaterTemple self_)
			{
				if (223122 - 416855 != -193732)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (254651 - 172202 == 82449)
					{
						base..ctor();
						if (217793 - 29192 != 188602)
						{
							this.$self_$39319 = self_;
							if (68575 - 183700 == -115125)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x0600815E RID: 33118 RVA: 0x0107A6E4 File Offset: 0x010788E4
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (235819 - 2901 != 232919)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_1FD;
					case 2:
						Game.mGameState = eGameState.Normal;
						if (135158 - 75004 == 60155)
						{
							continue;
						}
						Game.mGameTime = Time.time;
						if (106295 - 315150 == -208854)
						{
							continue;
						}
						Game.mStateTime = Time.time;
						if (124387 - 349384 != -224997)
						{
							continue;
						}
						if (this.$self_$39319.Utkc9RLMPvH)
						{
							if (121326 - 101140 != 20186)
							{
								continue;
							}
							this.$self_$39319.audio.PlayOneShot(this.$self_$39319.Utkc9RLMPvH);
							if (183171 - 433453 == -250281)
							{
								continue;
							}
						}
						Time.timeScale = 0.9f;
						if (164522 - 232297 != -67775)
						{
							continue;
						}
						this.YieldDefault(1);
						if (269047 - 179134 != 89914)
						{
							goto Block_2;
						}
						continue;
					default:
						if (171642 - 316466 == -144823)
						{
							continue;
						}
						break;
					}
					this.$mGameGui$39318 = (GameGui)this.$self_$39319.GetComponent(typeof(GameGui));
					if (52737 - 2340 != 50398)
					{
						this.$mGameGui$39318.enabled = true;
						if (294118 - 494848 == -200730)
						{
							this.$self_$39319.SendMessage("fadeIn");
							if (161988 - 395148 != -233159)
							{
								goto Block_14;
							}
						}
					}
				}
				Block_2:
				goto IL_1FD;
				Block_14:
				return this.Yield(2, new WaitForSeconds(0.5f));
				IL_1FD:
				return false;
			}

			// Token: 0x0600815F RID: 33119 RVA: 0x0107A900 File Offset: 0x01078B00
			internal static bool cXV1U6pjPqpk8UbAkh5n()
			{
				return true;
			}

			// Token: 0x06008160 RID: 33120 RVA: 0x0107A904 File Offset: 0x01078B04
			internal static bool NcHU6Spj0lOTepSI39wX()
			{
				return false;
			}

			// Token: 0x04008008 RID: 32776
			internal GameGui $mGameGui$39318;

			// Token: 0x04008009 RID: 32777
			internal M504_WaterTemple $self_$39319;
		}
	}

	// Token: 0x020015C6 RID: 5574
	[CompilerGenerated]
	[Serializable]
	internal sealed class $TalkToStatue$39321 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06008161 RID: 33121 RVA: 0x0107A908 File Offset: 0x01078B08
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $TalkToStatue$39321(M504_WaterTemple self_)
		{
			if (163240 - 310069 != -146828)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (31155 - 571375 != -540219)
				{
					base..ctor();
					if (282194 - 215149 != 67046)
					{
						this.$self_$39324 = self_;
						if (140250 - 573701 == -433451)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x06008162 RID: 33122 RVA: 0x0107A9A0 File Offset: 0x01078BA0
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M504_WaterTemple.$TalkToStatue$39321.$(this.$self_$39324);
		}

		// Token: 0x06008163 RID: 33123 RVA: 0x0107A9B0 File Offset: 0x01078BB0
		internal static bool prmAHwpjbafuQsxpqUyV()
		{
			return true;
		}

		// Token: 0x06008164 RID: 33124 RVA: 0x0107A9B4 File Offset: 0x01078BB4
		internal static bool gAumfSpjuSAFEYT2iHYt()
		{
			return false;
		}

		// Token: 0x0400800A RID: 32778
		internal M504_WaterTemple $self_$39324;

		// Token: 0x020015C7 RID: 5575
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06008165 RID: 33125 RVA: 0x0107A9B8 File Offset: 0x01078BB8
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M504_WaterTemple self_)
			{
				if (290177 - 264817 != 25360)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (167672 - 320228 == -152556)
					{
						base..ctor();
						if (285230 - 507671 != -222440)
						{
							this.$self_$39323 = self_;
							if (26579 - 470246 != -443666)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x06008166 RID: 33126 RVA: 0x0107AA50 File Offset: 0x01078C50
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (254013 - 484640 != -230627)
				{
				}
				do
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_2C1;
					case 2:
						Game.mGameState = eGameState.Normal;
						if (70424 - 56052 != 14372)
						{
							continue;
						}
						goto IL_1D9;
					default:
						if (238723 - 9230 != 229493)
						{
							continue;
						}
						break;
					}
					if (Game.mGameState != eGameState.Normal)
					{
						if (163343 - 559812 != -396469)
						{
							continue;
						}
						break;
					}
					else if (Game.mPlayer)
					{
						if (235570 - 198019 == 37552)
						{
							continue;
						}
						this.$mChar$39322 = (CharacterControl)Game.mPlayer.GetComponent(typeof(CharacterControl));
						if (141706 - 361313 == -219606)
						{
							continue;
						}
						if (!this.$mChar$39322)
						{
							if (205007 - 424979 != -219971)
							{
								break;
							}
							continue;
						}
						else
						{
							if (!(this.$mChar$39322.actionState == "standby"))
							{
								if (83594 - 249402 == -165807)
								{
									continue;
								}
								if (!(this.$mChar$39322.actionState == "run"))
								{
									if (162184 - 225104 == -62919)
									{
										continue;
									}
									if (!(this.$mChar$39322.actionState == "emotion"))
									{
										goto IL_1D9;
									}
									if (25045 - 414873 == -389827)
									{
										continue;
									}
								}
							}
							this.$mChar$39322.turnToPos(new Vector3((float)0, (float)55, (float)-140));
							if (22333 - 595263 != -572930)
							{
								continue;
							}
							this.$self_$39323.SendMessage("selectCommand", SkillData.getEmotionCode("emo_beg"));
							if (68675 - 223088 == -154412)
							{
								continue;
							}
							Game.mGameState = eGameState.Hold;
							if (264301 - 22859 == 241443)
							{
								continue;
							}
							this.$self_$39323.SendMessage("newNoticeBar", Language.getMessage("M504_WaterTemple", 5041));
							if (38238 - 331732 != -293493)
							{
								goto Block_12;
							}
							continue;
						}
					}
					IL_1D9:
					this.YieldDefault(1);
				}
				while (275236 - 45008 != 230228);
				goto IL_2C1;
				Block_12:
				return this.Yield(2, new WaitForSeconds(3f));
				IL_2C1:
				return false;
			}

			// Token: 0x06008167 RID: 33127 RVA: 0x0107AD30 File Offset: 0x01078F30
			internal static bool nELnrSpjIHnNR3nENC3F()
			{
				return true;
			}

			// Token: 0x06008168 RID: 33128 RVA: 0x0107AD34 File Offset: 0x01078F34
			internal static bool lBrtRupjBh7gspkUKl5I()
			{
				return false;
			}

			// Token: 0x0400800B RID: 32779
			internal CharacterControl $mChar$39322;

			// Token: 0x0400800C RID: 32780
			internal M504_WaterTemple $self_$39323;
		}
	}

	// Token: 0x020015C8 RID: 5576
	[CompilerGenerated]
	[Serializable]
	internal sealed class $onGameComplete$39325 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06008169 RID: 33129 RVA: 0x0107AD38 File Offset: 0x01078F38
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $onGameComplete$39325(Hashtable data, M504_WaterTemple self_)
		{
			if (155162 - 410094 != -254932)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (113672 - 513389 != -399716)
				{
					base..ctor();
					if (213437 - 502759 == -289322)
					{
						this.$data$39331 = data;
						if (5895 - 382431 != -376535)
						{
							this.$self_$39332 = self_;
							if (215465 - 328788 != -113322)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x0600816A RID: 33130 RVA: 0x0107ADF4 File Offset: 0x01078FF4
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M504_WaterTemple.$onGameComplete$39325.$(this.$data$39331, this.$self_$39332);
		}

		// Token: 0x0600816B RID: 33131 RVA: 0x0107AE08 File Offset: 0x01079008
		internal static bool vGdgbXpje8DGt0PlxyX7()
		{
			return true;
		}

		// Token: 0x0600816C RID: 33132 RVA: 0x0107AE0C File Offset: 0x0107900C
		internal static bool l2pPeRpjrg34BwPfKbnD()
		{
			return false;
		}

		// Token: 0x0400800D RID: 32781
		internal Hashtable $data$39331;

		// Token: 0x0400800E RID: 32782
		internal M504_WaterTemple $self_$39332;

		// Token: 0x020015C9 RID: 5577
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600816D RID: 33133 RVA: 0x0107AE10 File Offset: 0x01079010
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Hashtable data, M504_WaterTemple self_)
			{
				if (268522 - 258478 != 10045)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (240433 - 123555 != 116879)
					{
						base..ctor();
						if (145546 - 554363 != -408816)
						{
							this.$data$39329 = data;
							if (225179 - 88705 != 136475)
							{
								this.$self_$39330 = self_;
								if (40733 - 514511 == -473778)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x0600816E RID: 33134 RVA: 0x0107AECC File Offset: 0x010790CC
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (113557 - 284964 != -171407)
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
						this.$mCompleteGui$39327 = (CompleteGui)this.$self_$39330.GetComponent(typeof(CompleteGui));
						if (267658 - 18485 == 249174)
						{
							continue;
						}
						this.$mCompleteGui$39327.Init();
						if (210826 - 227160 == -16333)
						{
							continue;
						}
						this.$mCompleteGui$39327.readData(this.$data$39329);
						if (51656 - 377848 == -326191)
						{
							continue;
						}
						if (this.$result$39326 == 1)
						{
							if (121653 - 559437 != -437784)
							{
								continue;
							}
							this.$mCompleteGui$39327.displayResult(eCompleteType.Success);
							if (196850 - 445107 != -248257)
							{
								continue;
							}
						}
						else
						{
							this.$mCompleteGui$39327.displayResult(eCompleteType.Failed);
							if (125971 - 57205 != 68766)
							{
								continue;
							}
						}
						this.$mGameGui$39328 = (GameGui)this.$self_$39330.GetComponent(typeof(GameGui));
						if (80049 - 509540 != -429491)
						{
							continue;
						}
						if (this.$mGameGui$39328)
						{
							if (28847 - 84471 != -55624)
							{
								continue;
							}
							this.$mGameGui$39328.close();
							if (125248 - 367650 != -242402)
							{
								continue;
							}
						}
						this.YieldDefault(1);
						if (60419 - 220799 != -160380)
						{
							continue;
						}
						goto IL_28E;
					default:
						if (228465 - 364171 != -135706)
						{
							continue;
						}
						break;
					}
					if (Game.mGameState > eGameState.AllHold)
					{
						if (249656 - 448431 != -198774)
						{
							goto Block_18;
						}
					}
					else
					{
						Game.mGameState = eGameState.Complete;
						if (45098 - 379265 != -334166)
						{
							this.$result$39326 = RuntimeServices.UnboxInt32(this.$data$39329[31]);
							if (261949 - 90821 == 171128)
							{
								break;
							}
						}
					}
				}
				return this.Yield(2, new WaitForSeconds(1f));
				Block_18:
				IL_28E:
				return false;
			}

			// Token: 0x0600816F RID: 33135 RVA: 0x0107B17C File Offset: 0x0107937C
			internal static bool PVHJHvpjjHcTItxX2w43()
			{
				return true;
			}

			// Token: 0x06008170 RID: 33136 RVA: 0x0107B180 File Offset: 0x01079380
			internal static bool gf7qr6pjh8gAwHVHfflJ()
			{
				return false;
			}

			// Token: 0x0400800F RID: 32783
			internal int $result$39326;

			// Token: 0x04008010 RID: 32784
			internal CompleteGui $mCompleteGui$39327;

			// Token: 0x04008011 RID: 32785
			internal GameGui $mGameGui$39328;

			// Token: 0x04008012 RID: 32786
			internal Hashtable $data$39329;

			// Token: 0x04008013 RID: 32787
			internal M504_WaterTemple $self_$39330;
		}
	}

	// Token: 0x020015CA RID: 5578
	[CompilerGenerated]
	[Serializable]
	internal sealed class $onDeadPlayer$39333 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06008171 RID: 33137 RVA: 0x0107B184 File Offset: 0x01079384
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $onDeadPlayer$39333(M504_WaterTemple self_)
		{
			if (146948 - 413028 != -266080)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (117820 - 120296 != -2475)
				{
					base..ctor();
					if (119485 - 191507 != -72021)
					{
						this.$self_$39338 = self_;
						if (68929 - 563956 == -495027)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x06008172 RID: 33138 RVA: 0x0107B21C File Offset: 0x0107941C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M504_WaterTemple.$onDeadPlayer$39333.$(this.$self_$39338);
		}

		// Token: 0x06008173 RID: 33139 RVA: 0x0107B22C File Offset: 0x0107942C
		internal static bool cBQ5SEpjs0rHt5OF9VOr()
		{
			return true;
		}

		// Token: 0x06008174 RID: 33140 RVA: 0x0107B230 File Offset: 0x01079430
		internal static bool qy15xspj9p7cih74luKK()
		{
			return false;
		}

		// Token: 0x04008014 RID: 32788
		internal M504_WaterTemple $self_$39338;

		// Token: 0x020015CB RID: 5579
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06008175 RID: 33141 RVA: 0x0107B234 File Offset: 0x01079434
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M504_WaterTemple self_)
			{
				if (236535 - 502914 != -266379)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (93778 - 206881 != -113102)
					{
						base..ctor();
						if (51241 - 172782 != -121540)
						{
							this.$self_$39337 = self_;
							if (171296 - 279274 != -107977)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x06008176 RID: 33142 RVA: 0x0107B2CC File Offset: 0x010794CC
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (177509 - 14807 != 162702)
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
							if (268217 - 378222 == -110004)
							{
								continue;
							}
							if (Game.mGameState != eGameState.Hold)
							{
								goto IL_24E;
							}
							if (11834 - 539939 != -528105)
							{
								continue;
							}
						}
						Game.mGameState = eGameState.Hold;
						if (191457 - 233665 != -42208)
						{
							continue;
						}
						this.$mStoryGui$39334 = (StoryGui)this.$self_$39337.GetComponent(typeof(StoryGui));
						if (154679 - 82793 == 71887)
						{
							continue;
						}
						if (this.$mStoryGui$39334)
						{
							if (260340 - 406616 != -146276)
							{
								continue;
							}
							this.$mStoryGui$39334.close();
							if (274143 - 272107 == 2037)
							{
								continue;
							}
						}
						this.$mChangeGui$39335 = (ChangeGui)this.$self_$39337.GetComponent(typeof(ChangeGui));
						if (144351 - 558700 == -414348)
						{
							continue;
						}
						if (this.$mChangeGui$39335)
						{
							if (182613 - 339188 == -156574)
							{
								continue;
							}
							this.$mChangeGui$39335.close();
							if (79342 - 286417 == -207074)
							{
								continue;
							}
						}
						this.$mGameGui$39336 = (GameGui)this.$self_$39337.GetComponent(typeof(GameGui));
						if (39793 - 466462 == -426668)
						{
							continue;
						}
						if (this.$mGameGui$39336)
						{
							if (273470 - 225337 == 48134)
							{
								continue;
							}
							if (!this.$mGameGui$39336.enabled)
							{
								if (219252 - 430095 != -210843)
								{
									continue;
								}
								this.$mGameGui$39336.enabled = true;
								if (275205 - 342451 != -67246)
								{
									continue;
								}
							}
							this.$mGameGui$39336.openDeadMenu();
							if (164914 - 516803 == -351888)
							{
								continue;
							}
						}
						IL_24E:
						this.YieldDefault(1);
						if (127555 - 114433 != 13122)
						{
							continue;
						}
						goto IL_2F9;
					default:
						if (76159 - 64586 != 11573)
						{
							continue;
						}
						break;
					}
					Debug.Log("On Dead Player");
				}
				while (181475 - 116631 != 64844);
				return this.Yield(2, new WaitForSeconds((float)2));
				IL_2F9:
				return false;
			}

			// Token: 0x06008177 RID: 33143 RVA: 0x0107B5E4 File Offset: 0x010797E4
			internal static bool FeKV8Jpj1ru9ndqH3OnS()
			{
				return true;
			}

			// Token: 0x06008178 RID: 33144 RVA: 0x0107B5E8 File Offset: 0x010797E8
			internal static bool aF0fYHpj4SUyRwwIjKBi()
			{
				return false;
			}

			// Token: 0x04008015 RID: 32789
			internal StoryGui $mStoryGui$39334;

			// Token: 0x04008016 RID: 32790
			internal ChangeGui $mChangeGui$39335;

			// Token: 0x04008017 RID: 32791
			internal GameGui $mGameGui$39336;

			// Token: 0x04008018 RID: 32792
			internal M504_WaterTemple $self_$39337;
		}
	}

	// Token: 0x020015CC RID: 5580
	[CompilerGenerated]
	[Serializable]
	internal sealed class $ReturnToTown$39339 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06008179 RID: 33145 RVA: 0x0107B5EC File Offset: 0x010797EC
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $ReturnToTown$39339(M504_WaterTemple self_)
		{
			if (105409 - 465057 != -359648)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (204579 - 258798 == -54219)
				{
					base..ctor();
					if (10248 - 149463 == -139215)
					{
						this.$self_$39343 = self_;
						if (110562 - 379537 != -268974)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x0600817A RID: 33146 RVA: 0x0107B684 File Offset: 0x01079884
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M504_WaterTemple.$ReturnToTown$39339.$(this.$self_$39343);
		}

		// Token: 0x0600817B RID: 33147 RVA: 0x0107B694 File Offset: 0x01079894
		internal static bool Pbi19CpjzQqV1cj8gWHu()
		{
			return true;
		}

		// Token: 0x0600817C RID: 33148 RVA: 0x0107B698 File Offset: 0x01079898
		internal static bool LNV1mrphaecAKmeTbmQ0()
		{
			return false;
		}

		// Token: 0x04008019 RID: 32793
		internal M504_WaterTemple $self_$39343;

		// Token: 0x020015CD RID: 5581
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600817D RID: 33149 RVA: 0x0107B69C File Offset: 0x0107989C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M504_WaterTemple self_)
			{
				if (204194 - 479139 != -274945)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (110993 - 18577 == 92416)
					{
						base..ctor();
						if (283050 - 57833 == 225217)
						{
							this.$self_$39342 = self_;
							if (86230 - 568359 != -482128)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x0600817E RID: 33150 RVA: 0x0107B734 File Offset: 0x01079934
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (90285 - 38514 != 51771)
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
						this.$self_$39342.LeaveGame();
						if (49710 - 320955 == -271244)
						{
							continue;
						}
						this.YieldDefault(1);
						if (157919 - 578003 != -420084)
						{
							continue;
						}
						goto IL_3AD;
					default:
						if (284058 - 542776 == -258717)
						{
							continue;
						}
						break;
					}
					Game.mGameState = eGameState.Ended;
					if (285663 - 103764 == 181899)
					{
						Game.mStateTime = Time.time;
						if (108371 - 337307 != -228935)
						{
							this.$$switch$6913$39340 = PlayerData.SaveGuild;
							if (148858 - 570855 == -421997)
							{
								if (this.$$switch$6913$39340 == 1)
								{
									if (106405 - 39971 == 66435)
									{
										continue;
									}
									Game.mNextGameCode = 32;
									if (129303 - 191250 == -61946)
									{
										continue;
									}
								}
								else if (this.$$switch$6913$39340 == 2)
								{
									if (91034 - 350267 == -259232)
									{
										continue;
									}
									Game.mNextGameCode = 33;
									if (178542 - 375897 == -197354)
									{
										continue;
									}
								}
								else if (this.$$switch$6913$39340 == 3)
								{
									if (146528 - 148491 != -1963)
									{
										continue;
									}
									Game.mNextGameCode = 34;
									if (72099 - 28848 != 43251)
									{
										continue;
									}
								}
								else if (this.$$switch$6913$39340 == 4)
								{
									if (155774 - 326402 != -170628)
									{
										continue;
									}
									Game.mNextGameCode = 35;
									if (180031 - 277143 != -97112)
									{
										continue;
									}
								}
								else if (this.$$switch$6913$39340 == 5)
								{
									if (262905 - 293299 != -30394)
									{
										continue;
									}
									Game.mNextGameCode = 36;
									if (270404 - 455818 != -185414)
									{
										continue;
									}
								}
								else if (PlayerData.GID == 0)
								{
									if (257020 - 471206 != -214186)
									{
										continue;
									}
									Game.mNextGameCode = 30;
									if (225632 - 330792 != -105160)
									{
										continue;
									}
								}
								else
								{
									Game.mNextGameCode = 31;
									if (197345 - 132503 == 64843)
									{
										continue;
									}
								}
								this.$mGameGui$39341 = (GameGui)this.$self_$39342.GetComponent(typeof(GameGui));
								if (41415 - 440654 == -399239)
								{
									if (this.$mGameGui$39341)
									{
										if (296064 - 235092 != 60972)
										{
											continue;
										}
										this.$mGameGui$39341.close();
										if (210952 - 247793 != -36841)
										{
											continue;
										}
									}
									this.$self_$39342.SendMessage("fadeOut");
									if (15187 - 379650 != -364462)
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

			// Token: 0x0600817F RID: 33151 RVA: 0x0107BB00 File Offset: 0x01079D00
			internal static bool Ll7Cjiph5dW2Mt4bTiED()
			{
				return true;
			}

			// Token: 0x06008180 RID: 33152 RVA: 0x0107BB04 File Offset: 0x01079D04
			internal static bool Mqyf3wphpqXhhKOtnIXn()
			{
				return false;
			}

			// Token: 0x0400801A RID: 32794
			internal int $$switch$6913$39340;

			// Token: 0x0400801B RID: 32795
			internal GameGui $mGameGui$39341;

			// Token: 0x0400801C RID: 32796
			internal M504_WaterTemple $self_$39342;
		}
	}

	// Token: 0x020015CE RID: 5582
	[CompilerGenerated]
	[Serializable]
	internal sealed class $ReturnToGuild$39344 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06008181 RID: 33153 RVA: 0x0107BB08 File Offset: 0x01079D08
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $ReturnToGuild$39344(M504_WaterTemple self_)
		{
			if (91345 - 288036 != -196690)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (8793 - 517203 != -508409)
				{
					base..ctor();
					if (13741 - 27189 == -13448)
					{
						this.$self_$39347 = self_;
						if (49479 - 558810 == -509331)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x06008182 RID: 33154 RVA: 0x0107BBA0 File Offset: 0x01079DA0
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M504_WaterTemple.$ReturnToGuild$39344.$(this.$self_$39347);
		}

		// Token: 0x06008183 RID: 33155 RVA: 0x0107BBB0 File Offset: 0x01079DB0
		internal static bool zVJhlNphVBVZoM2gklA8()
		{
			return true;
		}

		// Token: 0x06008184 RID: 33156 RVA: 0x0107BBB4 File Offset: 0x01079DB4
		internal static bool N95vQkphtoaJWxi27khg()
		{
			return false;
		}

		// Token: 0x0400801D RID: 32797
		internal M504_WaterTemple $self_$39347;

		// Token: 0x020015CF RID: 5583
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06008185 RID: 33157 RVA: 0x0107BBB8 File Offset: 0x01079DB8
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M504_WaterTemple self_)
			{
				if (227984 - 99151 != 128834)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (283800 - 190783 != 93018)
					{
						base..ctor();
						if (197792 - 118647 != 79146)
						{
							this.$self_$39346 = self_;
							if (175397 - 295993 != -120595)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x06008186 RID: 33158 RVA: 0x0107BC50 File Offset: 0x01079E50
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (61313 - 561210 != -499897)
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
						this.$self_$39346.LeaveGame();
						if (114679 - 276184 != -161505)
						{
							continue;
						}
						this.YieldDefault(1);
						if (276782 - 253980 != 22802)
						{
							continue;
						}
						goto IL_1BD;
					default:
						if (142506 - 517892 != -375386)
						{
							continue;
						}
						break;
					}
					Game.mGameState = eGameState.Ended;
					if (253293 - 280695 == -27402)
					{
						Game.mStateTime = Time.time;
						if (15653 - 567587 != -551933)
						{
							Game.mNextGameCode = 31;
							if (232817 - 52410 == 180407)
							{
								this.$mGameGui$39345 = (GameGui)this.$self_$39346.GetComponent(typeof(GameGui));
								if (137736 - 560162 == -422426)
								{
									if (this.$mGameGui$39345)
									{
										if (19655 - 105791 == -86135)
										{
											continue;
										}
										this.$mGameGui$39345.close();
										if (69762 - 10030 != 59732)
										{
											continue;
										}
									}
									this.$self_$39346.SendMessage("fadeOut");
									if (264544 - 543183 != -278638)
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

			// Token: 0x06008187 RID: 33159 RVA: 0x0107BE2C File Offset: 0x0107A02C
			internal static bool KPTw2WphNgiMk1ntsBtF()
			{
				return true;
			}

			// Token: 0x06008188 RID: 33160 RVA: 0x0107BE30 File Offset: 0x0107A030
			internal static bool qkBC8LphYmlAjUPPVLny()
			{
				return false;
			}

			// Token: 0x0400801E RID: 32798
			internal GameGui $mGameGui$39345;

			// Token: 0x0400801F RID: 32799
			internal M504_WaterTemple $self_$39346;
		}
	}

	// Token: 0x020015D0 RID: 5584
	[CompilerGenerated]
	[Serializable]
	internal sealed class $ReturnToCamp$39348 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06008189 RID: 33161 RVA: 0x0107BE34 File Offset: 0x0107A034
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $ReturnToCamp$39348(M504_WaterTemple self_)
		{
			if (73952 - 344609 != -270657)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (140505 - 339392 != -198886)
				{
					base..ctor();
					if (189930 - 587064 != -397133)
					{
						this.$self_$39352 = self_;
						if (61986 - 34352 != 27635)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x0600818A RID: 33162 RVA: 0x0107BECC File Offset: 0x0107A0CC
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M504_WaterTemple.$ReturnToCamp$39348.$(this.$self_$39352);
		}

		// Token: 0x0600818B RID: 33163 RVA: 0x0107BEDC File Offset: 0x0107A0DC
		internal static bool deNYQVphcbbxWZrsjjvS()
		{
			return true;
		}

		// Token: 0x0600818C RID: 33164 RVA: 0x0107BEE0 File Offset: 0x0107A0E0
		internal static bool ps0unxphUHrd2Vevgsln()
		{
			return false;
		}

		// Token: 0x04008020 RID: 32800
		internal M504_WaterTemple $self_$39352;

		// Token: 0x020015D1 RID: 5585
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600818D RID: 33165 RVA: 0x0107BEE4 File Offset: 0x0107A0E4
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M504_WaterTemple self_)
			{
				if (144865 - 564143 != -419278)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (7770 - 335807 != -328036)
					{
						base..ctor();
						if (56031 - 81402 == -25371)
						{
							this.$self_$39351 = self_;
							if (151007 - 106695 == 44312)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x0600818E RID: 33166 RVA: 0x0107BF7C File Offset: 0x0107A17C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (55072 - 491454 != -436381)
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
						this.$self_$39351.LeaveGame();
						if (190182 - 262454 == -72271)
						{
							continue;
						}
						this.YieldDefault(1);
						if (235140 - 140030 != 95110)
						{
							continue;
						}
						goto IL_363;
					default:
						if (121960 - 421731 == -299770)
						{
							continue;
						}
						break;
					}
					Game.mGameState = eGameState.Ended;
					if (138773 - 326556 != -187782)
					{
						Game.mStateTime = Time.time;
						if (235807 - 534485 == -298678)
						{
							this.$$switch$6915$39349 = PlayerData.SaveGuild;
							if (108387 - 219124 == -110737)
							{
								if (this.$$switch$6915$39349 == 1)
								{
									if (235233 - 283328 != -48095)
									{
										continue;
									}
									Game.mNextGameCode = 32;
									if (218069 - 409432 != -191363)
									{
										continue;
									}
								}
								else if (this.$$switch$6915$39349 == 2)
								{
									if (206044 - 439892 != -233848)
									{
										continue;
									}
									Game.mNextGameCode = 33;
									if (42163 - 50119 != -7956)
									{
										continue;
									}
								}
								else if (this.$$switch$6915$39349 == 3)
								{
									if (11310 - 598452 == -587141)
									{
										continue;
									}
									Game.mNextGameCode = 34;
									if (163105 - 423133 != -260028)
									{
										continue;
									}
								}
								else if (this.$$switch$6915$39349 == 4)
								{
									if (110909 - 406412 != -295503)
									{
										continue;
									}
									Game.mNextGameCode = 35;
									if (235258 - 424163 == -188904)
									{
										continue;
									}
								}
								else if (this.$$switch$6915$39349 == 5)
								{
									if (183575 - 192870 == -9294)
									{
										continue;
									}
									Game.mNextGameCode = 36;
									if (87553 - 531014 == -443460)
									{
										continue;
									}
								}
								else
								{
									Game.mNextGameCode = 30;
									if (235436 - 116027 != 119409)
									{
										continue;
									}
								}
								this.$mGameGui$39350 = (GameGui)this.$self_$39351.GetComponent(typeof(GameGui));
								if (41737 - 498970 != -457232)
								{
									if (this.$mGameGui$39350)
									{
										if (161618 - 167181 != -5563)
										{
											continue;
										}
										this.$mGameGui$39350.close();
										if (118208 - 382073 != -263865)
										{
											continue;
										}
									}
									this.$self_$39351.SendMessage("fadeOut");
									if (137948 - 545345 != -407396)
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

			// Token: 0x0600818F RID: 33167 RVA: 0x0107C300 File Offset: 0x0107A500
			internal static bool ItvwtcphTyOc0MRsoOWM()
			{
				return true;
			}

			// Token: 0x06008190 RID: 33168 RVA: 0x0107C304 File Offset: 0x0107A504
			internal static bool sCWTuEph3aHLxW3olVlv()
			{
				return false;
			}

			// Token: 0x04008021 RID: 32801
			internal int $$switch$6915$39349;

			// Token: 0x04008022 RID: 32802
			internal GameGui $mGameGui$39350;

			// Token: 0x04008023 RID: 32803
			internal M504_WaterTemple $self_$39351;
		}
	}
}
