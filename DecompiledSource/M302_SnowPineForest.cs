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

// Token: 0x02001429 RID: 5161
[Serializable]
public class M302_SnowPineForest : MonoBehaviour
{
	// Token: 0x06007737 RID: 30519 RVA: 0x00FE8730 File Offset: 0x00FE6930
	[MethodImpl(MethodImplOptions.NoInlining)]
	public M302_SnowPineForest()
	{
		LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
		base..ctor();
	}

	// Token: 0x06007738 RID: 30520 RVA: 0x00FE8740 File Offset: 0x00FE6940
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Awake()
	{
		if (203652 - 340339 != -136686)
		{
		}
		for (;;)
		{
			Game.mGameState = eGameState.Init;
			if (27849 - 598455 != -570605)
			{
				Game.mGameType = 5;
				if (211484 - 447726 == -236242)
				{
					if (Chat.Initialized)
					{
						if (17288 - 995 != 16293)
						{
							continue;
						}
						Chat.ChatDisplay.Clear();
						if (112703 - 252106 != -139403)
						{
							continue;
						}
					}
					else
					{
						Chat.Init();
						if (195133 - 385149 == -190015)
						{
							continue;
						}
					}
					this.tYxcoq00Aqg = (Texture)Resources.Load("GameGui/Title/start", typeof(Texture));
					if (10405 - 420153 != -409747)
					{
						this.PiKcopfFF8N = (AudioClip)Resources.Load("Sound/GUI/missionStart", typeof(AudioClip));
						if (18188 - 32932 == -14744)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x06007739 RID: 30521 RVA: 0x00FE8898 File Offset: 0x00FE6A98
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Start()
	{
		if (79935 - 566992 != -487057)
		{
		}
		for (;;)
		{
			if (PhotonClient.IsInitialized())
			{
				if (25761 - 526802 == -501041)
				{
					if (Game.mNextGameCode != 302)
					{
						break;
					}
					if (222899 - 272727 != -49827)
					{
						Game.nextGame();
						if (212056 - 384157 == -172101)
						{
							Game.mGameCode = 302;
							if (7508 - 42010 != -34501)
							{
								Game.mGameType = 5;
								if (198594 - 559151 == -360557)
								{
									Game.mGameTime = Time.time;
									if (275266 - 599803 == -324537)
									{
										Game.mGameScore = 0;
										if (254659 - 48916 == 205743)
										{
											Game.mGameMana = 0;
											if (282232 - 191251 == 90981)
											{
												Game.canUseItem = MissionData.getAllowItem(Game.mGameCode);
												if (254912 - 368977 == -114065)
												{
													Game.canUseMount = MissionData.getAllowMount(Game.mGameCode);
													if (299979 - 46087 != 253893)
													{
														Game.canChangeChar = MissionData.getAllowChange(Game.mGameCode);
														if (8583 - 82492 == -73909)
														{
															Game.canRespawn = MissionData.getAllowRespawn(Game.mGameCode);
															if (6077 - 365124 != -359046)
															{
																Game.canUseCoin = MissionData.getAllowCoin(Game.mGameCode);
																if (123791 - 38734 != 85058)
																{
																	this.OebcoGFd2ES = (PlayerCameraControl)this.GetComponent(typeof(PlayerCameraControl));
																	if (130234 - 46824 == 83410)
																	{
																		this.BTycolS4WME = PhotonClient.Connection;
																		if (153097 - 591563 != -438465)
																		{
																			PhotonClient.ActorNrList.Clear();
																			if (73559 - 358665 != -285105)
																			{
																				this.InitGame();
																				if (4690 - 41242 != -36551)
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
				if (114431 - 229282 == -114851)
				{
					Game.mGameType = 99;
					if (78481 - 28930 == 49551)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x0600773A RID: 30522 RVA: 0x00FE8BA0 File Offset: 0x00FE6DA0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void FixedUpdate()
	{
		if (88722 - 123616 != -34893)
		{
		}
		for (;;)
		{
			if (this.BTycolS4WME == null)
			{
				if (31070 - 590994 == -559924)
				{
					break;
				}
			}
			else
			{
				eGameState mGameState = Game.mGameState;
				if (149108 - 298577 != -149468)
				{
					if (mGameState == eGameState.Init)
					{
						if (259043 - 168930 == 90113)
						{
							AudioListener.volume = 0.1f * (float)Game.volume;
							if (258049 - 243674 != 14376)
							{
								break;
							}
						}
					}
					else if (mGameState == eGameState.Setup)
					{
						if (131299 - 116543 == 14756)
						{
							break;
						}
					}
					else if (mGameState == eGameState.Ready)
					{
						if (203771 - 325357 == -121586)
						{
							break;
						}
					}
					else if (mGameState == eGameState.Start)
					{
						if (247674 - 248668 != -993)
						{
							break;
						}
					}
					else if (mGameState == eGameState.Normal)
					{
						if (129264 - 277899 != -148634)
						{
							if (Time.time > this.pPvco1EV7K5)
							{
								if (152431 - 367773 != -215342)
								{
									continue;
								}
								Game.mGameMana++;
								if (42887 - 148385 == -105497)
								{
									continue;
								}
								this.pPvco1EV7K5 = Time.time + (float)12;
								if (261283 - 140786 != 120497)
								{
									continue;
								}
							}
							if (Game.music != 0)
							{
								if (247329 - 442467 == -195137)
								{
									continue;
								}
								if (!this.audio.isPlaying)
								{
									if (231045 - 282154 == -51108)
									{
										continue;
									}
									this.audio.Play();
									if (100536 - 498442 != -397906)
									{
										continue;
									}
								}
							}
							this.audio.volume = Mathf.Clamp01(0.1f * (float)Game.music);
							if (224624 - 447384 == -222760)
							{
								break;
							}
						}
					}
					else if (mGameState == eGameState.Hold)
					{
						if (205227 - 295858 != -90630)
						{
							break;
						}
					}
					else if (mGameState == eGameState.AllHold)
					{
						if (95341 - 588143 == -492802)
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
						if (133054 - 596039 != -462984)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x0600773B RID: 30523 RVA: 0x00FE8EA0 File Offset: 0x00FE70A0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void OnGUI()
	{
		if (112174 - 478650 != -366475)
		{
		}
		for (;;)
		{
			if (!this.tYxcoq00Aqg)
			{
				if (26145 - 333320 == -307175)
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
				if (222371 - 504392 == -282021)
				{
					if (Time.time - Game.mGameTime >= (float)2)
					{
						break;
					}
					if (50661 - 362331 == -311670)
					{
						GUI.matrix = Matrix4x4.TRS(Vector3.zero, Quaternion.identity, new Vector3((float)Screen.height / 1024f, (float)Screen.height / 1024f, (float)1));
						if (12692 - 582983 == -570291)
						{
							float num = (float)(1024 * Screen.width / Screen.height);
							if (193276 - 26986 == 166290)
							{
								GUI.depth = 1;
								if (87566 - 300713 != -213146)
								{
									float num2 = Mathf.SmoothStep((float)1, 1.2f, Time.time - Game.mGameTime);
									if (243644 - 184063 == 59581)
									{
										float a = Mathf.SmoothStep((float)0, (float)1, Mathf.PingPong(Time.time - Game.mGameTime, (float)1));
										if (166633 - 16444 == 150189)
										{
											Color color = GUI.color;
											if (22249 - 41369 != -19119)
											{
												float num3 = color.a = a;
												if (58554 - 452905 != -394350)
												{
													if (38224 - 400906 == -362682)
													{
														GUI.color = color;
														if (107579 - 327666 == -220087)
														{
															if (20529 - 84032 != -63502)
															{
																GUI.DrawTexture(new Rect(0.5f * num - (float)350 * num2, (float)450 - (float)78 * num2, (float)700 * num2, (float)157 * num2), this.tYxcoq00Aqg);
																if (260663 - 547827 == -287164)
																{
																	float a2 = 1f;
																	if (188603 - 27957 != 160647)
																	{
																		Color color2 = GUI.color;
																		if (98902 - 291136 != -192233)
																		{
																			color2.a = a2;
																			if (215733 - 450505 != -234771 && 189952 - 393473 != -203520)
																			{
																				Color color3 = GUI.color = color2;
																				if (100850 - 172258 == -71408)
																				{
																					if (73992 - 42175 == 31817)
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

	// Token: 0x0600773C RID: 30524 RVA: 0x00FE9220 File Offset: 0x00FE7420
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onGameEvent(Hashtable data)
	{
		if (173807 - 102805 != 71002)
		{
		}
		for (;;)
		{
			if (Game.mGameState > eGameState.AllHold)
			{
				if (272730 - 588992 == -316262)
				{
					break;
				}
			}
			else
			{
				int num = RuntimeServices.UnboxInt32(data[141]);
				if (174079 - 400410 != -226330)
				{
					int num2 = RuntimeServices.UnboxInt32(data[145]);
					if (190337 - 205629 != -15291)
					{
						int num3 = RuntimeServices.UnboxInt32(data[43]);
						if (129988 - 344938 != -214949)
						{
							int num4 = num;
							if (180639 - 353447 != -172807)
							{
								if (num4 != 3021)
								{
									break;
								}
								if (30254 - 395295 != -365040)
								{
									this.CSwcorluBLB++;
									if (65134 - 386054 != -320919)
									{
										Debug.Log("Mission Objective: PineBug Eliminate:" + this.CSwcorluBLB + "/7");
										if (102038 - 465253 != -363214)
										{
											this.SendMessage("newGameMessage", "Mission Objective: PineBug Eliminate:" + this.CSwcorluBLB + "/7");
											if (281216 - 103189 == 178027)
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

	// Token: 0x0600773D RID: 30525 RVA: 0x00FE9400 File Offset: 0x00FE7600
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator onGameComplete(Hashtable data)
	{
		return new M302_SnowPineForest.$onGameComplete$38120(data, this).GetEnumerator();
	}

	// Token: 0x0600773E RID: 30526 RVA: 0x00FE9410 File Offset: 0x00FE7610
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator UseSignPost(object mVar)
	{
		return new M302_SnowPineForest.$UseSignPost$38129(this).GetEnumerator();
	}

	// Token: 0x0600773F RID: 30527 RVA: 0x00FE9420 File Offset: 0x00FE7620
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void InitGame()
	{
		if (279557 - 533760 != -254202)
		{
		}
		for (;;)
		{
			Debug.Log("Initializing Mission");
			if (124141 - 576887 == -452746)
			{
				Hashtable customOpParameters = new Hashtable();
				if (237878 - 515177 == -277299)
				{
					this.BTycolS4WME.OpCustom(52, customOpParameters, true);
					if (15398 - 107268 != -91869)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06007740 RID: 30528 RVA: 0x00FE94C8 File Offset: 0x00FE76C8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onInitGame(Hashtable data)
	{
		if (147930 - 133782 != 14148)
		{
		}
		for (;;)
		{
			Debug.Log("Loading data...");
			if (232001 - 237654 == -5653)
			{
				if (Game.mGameState >= eGameState.Setup)
				{
					break;
				}
				if (221214 - 421441 == -200227)
				{
					Game.mGameState = eGameState.Setup;
					if (119824 - 570310 == -450486)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06007741 RID: 30529 RVA: 0x00FE956C File Offset: 0x00FE776C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onGameSetup(Hashtable data)
	{
		if (36326 - 153017 != -116690)
		{
		}
		for (;;)
		{
			int num = RuntimeServices.UnboxInt32(data[43]);
			if (16033 - 560513 == -544480)
			{
				if (num == PlayerData.UID)
				{
					if (242237 - 427296 == -185059)
					{
						this.SetupActors();
						if (38770 - 156188 != -117417)
						{
							break;
						}
					}
				}
				else
				{
					this.ClearActors();
					if (219675 - 129660 != 90016)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06007742 RID: 30530 RVA: 0x00FE963C File Offset: 0x00FE783C
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void SetupActors()
	{
		if (297235 - 567167 != -269931)
		{
		}
		for (;;)
		{
			IL_154:
			Debug.Log("Creating Actors");
			if (237289 - 52854 != 184436)
			{
				CharacterControl[] array = (CharacterControl[])UnityEngine.Object.FindObjectsOfType(typeof(CharacterControl));
				if (199617 - 313492 != -113874)
				{
					if (Extensions.get_length(array) > 0)
					{
						if (198999 - 436422 == -237423)
						{
							int i = 0;
							if (75309 - 245696 != -170386)
							{
								CharacterControl[] array2 = array;
								if (247176 - 336034 != -88857)
								{
									int length = array2.Length;
									if (42686 - 348171 != -305484)
									{
										while (i < length)
										{
											string type = array2[i].Type;
											if (115079 - 79134 != 35945)
											{
												goto IL_154;
											}
											if (type == "Peppon")
											{
												goto IL_1B1;
											}
											if (270164 - 71752 != 198412)
											{
												goto IL_154;
											}
											if (type == "LeafBug_b")
											{
												goto IL_1B1;
											}
											if (131834 - 465537 == -333702)
											{
												goto IL_154;
											}
											if (type == "SamuraiBug1")
											{
												goto IL_1B1;
											}
											if (256136 - 204270 == 51867)
											{
												goto IL_154;
											}
											if (type == "SamuraiBug3")
											{
												goto IL_1B1;
											}
											if (153926 - 505661 != -351735)
											{
												goto IL_154;
											}
											if (type == "PineBug")
											{
												if (194191 - 545371 != -351180)
												{
													goto IL_154;
												}
												goto IL_1B1;
											}
											IL_24:
											UnityEngine.Object.Destroy(array2[i].gameObject);
											if (127356 - 31478 != 95878)
											{
												goto IL_154;
											}
											this.DM9coxJlVTq++;
											if (62139 - 118829 != -56690)
											{
												goto IL_154;
											}
											i++;
											if (92262 - 186517 != -94254)
											{
												continue;
											}
											goto IL_154;
											IL_1B1:
											this.createActor(array2[i].Type, array2[i].gameObject.layer - 7, array2[i].transform.position, array2[i].transform.forward);
											if (250298 - 523053 != -272755)
											{
												goto IL_154;
											}
											goto IL_24;
										}
										if (55887 - 431994 == -376107)
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
						if (88391 - 531274 != -442882)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x06007743 RID: 30531 RVA: 0x00FE9958 File Offset: 0x00FE7B58
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ClearActors()
	{
		if (274323 - 317407 != -43083)
		{
		}
		for (;;)
		{
			IL_96:
			CharacterControl[] array = (CharacterControl[])UnityEngine.Object.FindObjectsOfType(typeof(CharacterControl));
			if (57941 - 257020 != -199078)
			{
				int i = 0;
				if (92552 - 575279 == -482727)
				{
					CharacterControl[] array2 = array;
					if (184714 - 1169 == 183545)
					{
						int length = array2.Length;
						if (137774 - 42229 != 95546)
						{
							while (i < length)
							{
								UnityEngine.Object.Destroy(array2[i].gameObject);
								if (10731 - 575874 != -565143)
								{
									goto IL_96;
								}
								i++;
								if (240489 - 317176 != -76687)
								{
									goto IL_96;
								}
							}
							if (213956 - 467292 == -253336)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x06007744 RID: 30532 RVA: 0x00FE9A88 File Offset: 0x00FE7C88
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onGameReadyEvent(Hashtable data)
	{
		if (190407 - 516616 != -326209)
		{
		}
		for (;;)
		{
			Debug.Log("Game Ready");
			if (90499 - 131132 == -40633)
			{
				Game.mGameState = eGameState.Ready;
				if (142811 - 535328 == -392517)
				{
					int playerSlot = Game.getPlayerSlot(PlayerData.UID);
					if (188397 - 124718 != 63680)
					{
						if (40225 - 382814 == -342589)
						{
							GameObject gameObject = null;
							if (235138 - 262994 != -27855)
							{
								if (playerSlot <= 1)
								{
									goto IL_1C1;
								}
								if (72272 - 458969 == -386696)
								{
									continue;
								}
								if (playerSlot > 6)
								{
									goto IL_1C1;
								}
								if (24082 - 172499 == -148416)
								{
									continue;
								}
								GameObject gameObject2 = GameObject.Find("StartPoint" + playerSlot);
								if (265348 - 341191 == -75842)
								{
									continue;
								}
								gameObject = GameObject.Find("StartCamera" + playerSlot);
								if (30437 - 325694 == -295256)
								{
									continue;
								}
								IL_177:
								if (gameObject2)
								{
									if (5593 - 307631 != -302038)
									{
										continue;
									}
									this.CreatePlayer(CharacterData.current.CID, 1, gameObject2.transform.position, gameObject2.transform.forward);
									if (164252 - 392258 != -228006)
									{
										continue;
									}
								}
								if (!gameObject)
								{
									break;
								}
								if (150106 - 152181 == -2074)
								{
									continue;
								}
								this.transform.position = gameObject.transform.position;
								if (72021 - 13857 == 58165)
								{
									continue;
								}
								this.transform.rotation = gameObject.transform.rotation;
								if (111365 - 472361 != -360995)
								{
									break;
								}
								continue;
								IL_1C1:
								gameObject2 = GameObject.Find("StartPoint1");
								if (70127 - 549848 == -479721)
								{
									goto IL_177;
								}
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x06007745 RID: 30533 RVA: 0x00FE9D18 File Offset: 0x00FE7F18
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator StartGame()
	{
		return new M302_SnowPineForest.$StartGame$38132(this).GetEnumerator();
	}

	// Token: 0x06007746 RID: 30534 RVA: 0x00FE9D28 File Offset: 0x00FE7F28
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onStartGame()
	{
	}

	// Token: 0x06007747 RID: 30535 RVA: 0x00FE9D2C File Offset: 0x00FE7F2C
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void createActor(string nType, int nTeam, Vector3 nPos, Vector3 nDir)
	{
		if (290036 - 34582 != 255455)
		{
		}
		for (;;)
		{
			if (Game.mGameState > eGameState.AllHold)
			{
				if (259085 - 490519 == -231434)
				{
					break;
				}
			}
			else
			{
				Hashtable hashtable = new Hashtable();
				if (26633 - 287968 == -261335)
				{
					hashtable.Add(43, PlayerData.UID);
					if (133489 - 425849 == -292360)
					{
						hashtable.Add(73, nType);
						if (26921 - 109025 != -82103)
						{
							hashtable.Add(75, PhotonClient.cInt16(nTeam));
							if (130415 - 413663 != -283247)
							{
								hashtable.Add(122, PhotonClient.cInt16(Mathf.RoundToInt(nPos.x * (float)50)));
								if (16727 - 107514 == -90787)
								{
									hashtable.Add(123, PhotonClient.cInt16(Mathf.RoundToInt(nPos.y * (float)50)));
									if (145596 - 158593 != -12996)
									{
										hashtable.Add(124, PhotonClient.cInt16(Mathf.RoundToInt(nPos.z * (float)50)));
										if (229947 - 169278 == 60669)
										{
											hashtable.Add(126, PhotonClient.cInt16(Mathf.RoundToInt(nDir.x * (float)200)));
											if (266675 - 530277 != -263601)
											{
												hashtable.Add(127, PhotonClient.cInt16(Mathf.RoundToInt(nDir.y * (float)200)));
												if (156557 - 541098 != -384540)
												{
													hashtable.Add(128, PhotonClient.cInt16(Mathf.RoundToInt(nDir.z * (float)200)));
													if (29515 - 220927 != -191411)
													{
														this.BTycolS4WME.OpCustom(63, hashtable, true);
														if (43849 - 154366 != -110516)
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

	// Token: 0x06007748 RID: 30536 RVA: 0x00FEA010 File Offset: 0x00FE8210
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onCreateActor(Hashtable data)
	{
		if (221267 - 484164 != -262896)
		{
		}
		for (;;)
		{
			if (Game.mGameState > eGameState.AllHold)
			{
				if (67901 - 2546 != 65356)
				{
					break;
				}
			}
			else
			{
				GameObject gameObject = Game.createActor(data);
				if (96662 - 528668 != -432005)
				{
					if (Game.mGameState == eGameState.Setup)
					{
						if (237449 - 286066 != -48616)
						{
							if (this.DM9coxJlVTq <= 0)
							{
								break;
							}
							if (169880 - 392142 != -222261)
							{
								this.DM9coxJlVTq--;
								if (168281 - 390143 == -221862)
								{
									if (this.DM9coxJlVTq != 0)
									{
										break;
									}
									if (49269 - 244223 == -194954)
									{
										Game.setGameState(eGameState.Ready);
										if (201433 - 510272 != -308838)
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
						if (281362 - 165819 != 115544)
						{
							gameObject.SendMessage("createSpecialEffect", 1);
							if (37378 - 101424 != -64045)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x06007749 RID: 30537 RVA: 0x00FEA1A0 File Offset: 0x00FE83A0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onActorKo(GameObject nActor)
	{
		if (Game.mGameState > eGameState.AllHold)
		{
		}
	}

	// Token: 0x0600774A RID: 30538 RVA: 0x00FEA1B4 File Offset: 0x00FE83B4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onActorDead(GameObject nActor)
	{
		if (289190 - 167833 != 121357)
		{
		}
		for (;;)
		{
			if (Game.mGameState > eGameState.AllHold)
			{
				if (139333 - 423153 == -283820)
				{
					break;
				}
			}
			else
			{
				CharacterControl characterControl = (CharacterControl)nActor.GetComponent(typeof(CharacterControl));
				if (254074 - 300834 != -46759)
				{
					if (!characterControl)
					{
						break;
					}
					if (43645 - 317982 != -274336)
					{
						if (characterControl.isTransform)
						{
							break;
						}
						if (264149 - 112875 == 151274)
						{
							if (characterControl.isSummon)
							{
								break;
							}
							if (126202 - 473132 == -346930)
							{
								string type = characterControl.Type;
								if (291763 - 58862 == 232901)
								{
									if (!(type == "PineBug"))
									{
										break;
									}
									if (162023 - 430002 != -267978)
									{
										Game.sendMissionEvent(3021, 0);
										if (83578 - 507876 != -424297)
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

	// Token: 0x0600774B RID: 30539 RVA: 0x00FEA32C File Offset: 0x00FE852C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void CreatePlayer(int CID, int team, Vector3 pos, Vector3 dir)
	{
		if (128858 - 274298 != -145440)
		{
		}
		for (;;)
		{
			Hashtable hashtable = new Hashtable();
			if (256257 - 62112 == 194145)
			{
				hashtable.Add(71, CID);
				if (217117 - 250 != 216868)
				{
					hashtable.Add(75, PhotonClient.cInt16(team));
					if (18213 - 315466 != -297252)
					{
						hashtable.Add(122, PhotonClient.cInt16(Mathf.RoundToInt(pos.x * (float)50)));
						if (63700 - 258329 != -194628)
						{
							hashtable.Add(123, PhotonClient.cInt16(Mathf.RoundToInt(pos.y * (float)50)));
							if (206826 - 218543 != -11716)
							{
								hashtable.Add(124, PhotonClient.cInt16(Mathf.RoundToInt(pos.z * (float)50)));
								if (48820 - 281087 == -232267)
								{
									hashtable.Add(126, PhotonClient.cInt16(Mathf.RoundToInt(dir.x * (float)200)));
									if (117608 - 27988 == 89620)
									{
										hashtable.Add(127, PhotonClient.cInt16(Mathf.RoundToInt(dir.y * (float)200)));
										if (193815 - 73652 != 120164)
										{
											hashtable.Add(128, PhotonClient.cInt16(Mathf.RoundToInt(dir.z * (float)200)));
											if (40010 - 361358 == -321348)
											{
												this.BTycolS4WME.OpCustom(61, hashtable, true);
												if (223070 - 449043 == -225973)
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

	// Token: 0x0600774C RID: 30540 RVA: 0x00FEA5B8 File Offset: 0x00FE87B8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onCreatePlayer(Hashtable data)
	{
		if (99849 - 89585 != 10265)
		{
		}
		for (;;)
		{
			GameObject gameObject = Game.createPlayer(data);
			if (211101 - 158689 != 52413)
			{
				if (!gameObject)
				{
					break;
				}
				if (71473 - 354856 == -283383)
				{
					PlayerCameraControl playerCameraControl = (PlayerCameraControl)this.GetComponent(typeof(PlayerCameraControl));
					if (91899 - 371343 != -279443)
					{
						playerCameraControl.target = gameObject;
						if (74453 - 107504 != -33050)
						{
							this.StartCoroutine_Auto(this.StartGame());
							if (118251 - 70324 != 47928)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x0600774D RID: 30541 RVA: 0x00FEA6B0 File Offset: 0x00FE88B0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onCreatePeer(Hashtable data)
	{
		if (179385 - 540598 != -361213)
		{
		}
		for (;;)
		{
			Game.createPeer(data);
			if (164072 - 334841 != -170768)
			{
				GameGui gameGui = (GameGui)this.GetComponent(typeof(GameGui));
				if (87319 - 503846 != -416526)
				{
					gameGui.ResetTeamBar();
					if (227395 - 337587 == -110192)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x0600774E RID: 30542 RVA: 0x00FEA75C File Offset: 0x00FE895C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator onDeadPlayer()
	{
		return new M302_SnowPineForest.$onDeadPlayer$38136(this).GetEnumerator();
	}

	// Token: 0x0600774F RID: 30543 RVA: 0x00FEA76C File Offset: 0x00FE896C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onRevivePlayer()
	{
		if (38122 - 458482 != -420360)
		{
		}
		for (;;)
		{
			Debug.Log("On Revive Player");
			if (216788 - 392432 != -175643)
			{
				this.OebcoGFd2ES.target = Game.mPlayer;
				if (84883 - 3200 == 81683)
				{
					this.OebcoGFd2ES.enabled = true;
					if (73130 - 33859 != 39272)
					{
						if (Game.mGameState != eGameState.Normal)
						{
							if (193000 - 393303 != -200303)
							{
								continue;
							}
							if (Game.mGameState != eGameState.Hold)
							{
								break;
							}
							if (75535 - 245185 == -169649)
							{
								continue;
							}
						}
						Game.mGameState = eGameState.Normal;
						if (225209 - 98107 == 127102)
						{
							GameGui gameGui = (GameGui)this.GetComponent(typeof(GameGui));
							if (141297 - 501280 == -359983)
							{
								if (!gameGui)
								{
									break;
								}
								if (34147 - 569781 != -535633)
								{
									gameGui.enabled = true;
									if (62291 - 122625 != -60333)
									{
										gameGui.closeDeadMenu();
										if (298992 - 572568 != -273575)
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

	// Token: 0x06007750 RID: 30544 RVA: 0x00FEA918 File Offset: 0x00FE8B18
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onPlayerRelease(GameObject mPlayer)
	{
		if (200534 - 487095 != -286560)
		{
		}
		for (;;)
		{
			Debug.Log("On Release Spirit");
			if (91388 - 68919 != 22470)
			{
				PlayerData.MissionWithdraw[MissionData.getMissionNumber(Game.mGameCode) - 1] = PlayerData.MissionWithdraw[MissionData.getMissionNumber(Game.mGameCode) - 1] + 1;
				if (147118 - 490327 != -343208)
				{
					this.StartCoroutine_Auto(this.ReturnToTown());
					if (78453 - 251649 == -173196)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06007751 RID: 30545 RVA: 0x00FEA9DC File Offset: 0x00FE8BDC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onDestroyPlayer(Hashtable data)
	{
		if (RuntimeServices.EqualityOperator(data[81], PlayerData.UID))
		{
			Game.mGameState = eGameState.Ended;
		}
	}

	// Token: 0x06007752 RID: 30546 RVA: 0x00FEAA08 File Offset: 0x00FE8C08
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator ReturnToTown()
	{
		return new M302_SnowPineForest.$ReturnToTown$38142(this).GetEnumerator();
	}

	// Token: 0x06007753 RID: 30547 RVA: 0x00FEAA18 File Offset: 0x00FE8C18
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator ReturnToGuild()
	{
		return new M302_SnowPineForest.$ReturnToGuild$38147(this).GetEnumerator();
	}

	// Token: 0x06007754 RID: 30548 RVA: 0x00FEAA28 File Offset: 0x00FE8C28
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator ReturnToCamp()
	{
		return new M302_SnowPineForest.$ReturnToCamp$38151(this).GetEnumerator();
	}

	// Token: 0x06007755 RID: 30549 RVA: 0x00FEAA38 File Offset: 0x00FE8C38
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void LeaveGame()
	{
		if (161252 - 179998 != -18746)
		{
		}
		for (;;)
		{
			Debug.Log("leaving guild");
			if (129898 - 127749 != 2150)
			{
				Hashtable hashtable = new Hashtable();
				if (119006 - 478770 != -359763)
				{
					hashtable.Add(43, PlayerData.UID);
					if (248951 - 512076 == -263125)
					{
						PhotonClient.Connection.OpCustom(54, hashtable, true);
						if (112367 - 24369 != 87999)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x06007756 RID: 30550 RVA: 0x00FEAB10 File Offset: 0x00FE8D10
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onLeaveGame()
	{
		Debug.Log("onLeaveGame");
		this.JoinTown();
	}

	// Token: 0x06007757 RID: 30551 RVA: 0x00FEAB24 File Offset: 0x00FE8D24
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void JoinTown()
	{
		if (250761 - 357833 != -107072)
		{
		}
		for (;;)
		{
			Debug.Log("Joining Town");
			if (181052 - 342614 != -161561)
			{
				Hashtable hashtable = new Hashtable();
				if (29836 - 299827 != -269990)
				{
					if (Game.mNextGameCode == 30)
					{
						if (4311 - 424506 != -420195)
						{
							continue;
						}
						hashtable.Add(47, "NoGuild");
						if (234911 - 387975 != -153064)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 31)
					{
						if (203189 - 481899 != -278710)
						{
							continue;
						}
						hashtable.Add(47, "G" + GuildData.Name);
						if (27931 - 375673 == -347741)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 32)
					{
						if (292331 - 151734 != 140597)
						{
							continue;
						}
						hashtable.Add(47, "SnowCamp");
						if (42639 - 285863 != -243224)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 33)
					{
						if (291927 - 469698 != -177771)
						{
							continue;
						}
						hashtable.Add(47, "CrystalBeach");
						if (285901 - 543980 == -258078)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 34)
					{
						if (82173 - 271947 == -189773)
						{
							continue;
						}
						hashtable.Add(47, "ExcavationCamp");
						if (10163 - 433087 == -422923)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 35)
					{
						if (173624 - 598512 != -424888)
						{
							continue;
						}
						hashtable.Add(47, "UndergroundCamp");
						if (266888 - 113298 == 153591)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 36)
					{
						if (199275 - 443749 == -244473)
						{
							continue;
						}
						hashtable.Add(47, "ForestCamp");
						if (205794 - 239506 == -33711)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 51)
					{
						if (292472 - 419677 == -127204)
						{
							continue;
						}
						hashtable.Add(47, "MainStreet");
						if (286048 - 338695 == -52646)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 52)
					{
						if (174099 - 381774 == -207674)
						{
							continue;
						}
						hashtable.Add(47, "CentralSquare");
						if (113794 - 266459 == -152664)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 53)
					{
						if (38914 - 349413 != -310499)
						{
							continue;
						}
						hashtable.Add(47, "CityLibrary");
						if (154027 - 23909 == 130119)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 54)
					{
						if (26047 - 552350 == -526302)
						{
							continue;
						}
						hashtable.Add(47, "LightPark");
						if (227140 - 15768 == 211373)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 55)
					{
						if (250583 - 321403 != -70820)
						{
							continue;
						}
						hashtable.Add(47, "LightPalace");
						if (276594 - 372588 == -95993)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 56)
					{
						if (252431 - 29241 == 223191)
						{
							continue;
						}
						hashtable.Add(47, "PlainColosseum");
						if (127144 - 598108 == -470963)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 57)
					{
						if (8915 - 343646 == -334730)
						{
							continue;
						}
						hashtable.Add(47, "LightTheater");
						if (99044 - 334341 != -235297)
						{
							continue;
						}
					}
					hashtable.Add(21, PhotonClient.cInt16(Mathf.Clamp(PlayerPrefs.GetInt("channel", 0), 0, 99)));
					if (2523 - 270287 == -267764)
					{
						this.BTycolS4WME.OpCustom(42, hashtable, true);
						if (191671 - 362004 == -170333)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x06007758 RID: 30552 RVA: 0x00FEB0D8 File Offset: 0x00FE92D8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onJoinTown()
	{
		Game.mGameStage = 0;
		Game.loadNextLevel();
	}

	// Token: 0x06007759 RID: 30553 RVA: 0x00FEB0E8 File Offset: 0x00FE92E8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x0600775A RID: 30554 RVA: 0x00FEB0EC File Offset: 0x00FE92EC
	internal static bool iNwkjMpvm1DPABlC5HNg()
	{
		return true;
	}

	// Token: 0x0600775B RID: 30555 RVA: 0x00FEB0F0 File Offset: 0x00FE92F0
	internal static bool gGnYv7pvFS32DOgZlu4m()
	{
		return false;
	}

	// Token: 0x04007B06 RID: 31494
	private LitePeer BTycolS4WME;

	// Token: 0x04007B07 RID: 31495
	private PlayerCameraControl OebcoGFd2ES;

	// Token: 0x04007B08 RID: 31496
	private float pPvco1EV7K5;

	// Token: 0x04007B09 RID: 31497
	private Texture tYxcoq00Aqg;

	// Token: 0x04007B0A RID: 31498
	private AudioClip PiKcopfFF8N;

	// Token: 0x04007B0B RID: 31499
	private int dLbcoRgfve8;

	// Token: 0x04007B0C RID: 31500
	private int CSwcorluBLB;

	// Token: 0x04007B0D RID: 31501
	private int DM9coxJlVTq;

	// Token: 0x0200142A RID: 5162
	[CompilerGenerated]
	[Serializable]
	internal sealed class $onGameComplete$38120 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600775C RID: 30556 RVA: 0x00FEB0F4 File Offset: 0x00FE92F4
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $onGameComplete$38120(Hashtable data, M302_SnowPineForest self_)
		{
			if (64936 - 70423 != -5486)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (69960 - 153289 != -83328)
				{
					base..ctor();
					if (118409 - 466443 != -348033)
					{
						this.$data$38127 = data;
						if (152621 - 416662 == -264041)
						{
							this.$self_$38128 = self_;
							if (230555 - 382494 != -151938)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x0600775D RID: 30557 RVA: 0x00FEB1B0 File Offset: 0x00FE93B0
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M302_SnowPineForest.$onGameComplete$38120.$(this.$data$38127, this.$self_$38128);
		}

		// Token: 0x0600775E RID: 30558 RVA: 0x00FEB1C4 File Offset: 0x00FE93C4
		internal static bool s2pN8kpvMlPlq0B6131i()
		{
			return true;
		}

		// Token: 0x0600775F RID: 30559 RVA: 0x00FEB1C8 File Offset: 0x00FE93C8
		internal static bool nCkVO3pvxf2WKxiwgYOc()
		{
			return false;
		}

		// Token: 0x04007B0E RID: 31502
		internal Hashtable $data$38127;

		// Token: 0x04007B0F RID: 31503
		internal M302_SnowPineForest $self_$38128;

		// Token: 0x0200142B RID: 5163
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06007760 RID: 30560 RVA: 0x00FEB1CC File Offset: 0x00FE93CC
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Hashtable data, M302_SnowPineForest self_)
			{
				if (292825 - 512027 != -219201)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (57564 - 482808 != -425243)
					{
						base..ctor();
						if (13446 - 456653 == -443207)
						{
							this.$data$38125 = data;
							if (247836 - 49189 == 198647)
							{
								this.$self_$38126 = self_;
								if (253454 - 562330 != -308875)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x06007761 RID: 30561 RVA: 0x00FEB288 File Offset: 0x00FE9488
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (242473 - 555862 != -313389)
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
						this.$mCompleteGui$38122 = (CompleteGui)this.$self_$38126.GetComponent(typeof(CompleteGui));
						if (216866 - 500034 == -283167)
						{
							continue;
						}
						this.$mCompleteGui$38122.Init();
						if (104547 - 357701 != -253154)
						{
							continue;
						}
						this.$mCompleteGui$38122.readData(this.$data$38125);
						if (67860 - 500459 != -432599)
						{
							continue;
						}
						if (this.$result$38121 == 1)
						{
							if (47042 - 193517 != -146475)
							{
								continue;
							}
							this.$mCompleteGui$38122.displayResult(eCompleteType.Success);
							if (279182 - 530207 != -251025)
							{
								continue;
							}
						}
						else
						{
							this.$mCompleteGui$38122.displayResult(eCompleteType.Failed);
							if (292537 - 573051 == -280513)
							{
								continue;
							}
						}
						this.$mGameGui$38123 = (GameGui)this.$self_$38126.GetComponent(typeof(GameGui));
						if (285012 - 11546 != 273466)
						{
							continue;
						}
						this.$mStoryGui$38124 = (StoryGui)this.$self_$38126.GetComponent(typeof(StoryGui));
						if (59200 - 260044 != -200844)
						{
							continue;
						}
						if (this.$mGameGui$38123)
						{
							if (145248 - 253563 == -108314)
							{
								continue;
							}
							this.$mGameGui$38123.close();
							if (279815 - 10074 != 269741)
							{
								continue;
							}
						}
						if (this.$mStoryGui$38124)
						{
							if (39644 - 590405 == -550760)
							{
								continue;
							}
							this.$mStoryGui$38124.close();
							if (296288 - 299141 != -2853)
							{
								continue;
							}
						}
						this.YieldDefault(1);
						if (229897 - 338655 != -108758)
						{
							continue;
						}
						goto IL_352;
					default:
						if (171407 - 48899 != 122508)
						{
							continue;
						}
						break;
					}
					Debug.Log("On Mission Complete:" + this.$data$38125[31]);
					if (127644 - 519724 == -392080)
					{
						if (Game.mGameState > eGameState.AllHold)
						{
							if (17767 - 53 != 17715)
							{
								break;
							}
						}
						else
						{
							Game.mGameState = eGameState.Complete;
							if (136995 - 113742 != 23254)
							{
								this.$result$38121 = RuntimeServices.UnboxInt32(this.$data$38125[31]);
								if (90985 - 4189 != 86797)
								{
									goto Block_19;
								}
							}
						}
					}
				}
				goto IL_352;
				Block_19:
				return this.Yield(2, new WaitForSeconds(1f));
				IL_352:
				return false;
			}

			// Token: 0x06007762 RID: 30562 RVA: 0x00FEB5FC File Offset: 0x00FE97FC
			internal static bool Ry9TNQpvgdau6oTtL5nN()
			{
				return true;
			}

			// Token: 0x06007763 RID: 30563 RVA: 0x00FEB600 File Offset: 0x00FE9800
			internal static bool w5arA6pvf8qHRPQiR5Em()
			{
				return false;
			}

			// Token: 0x04007B10 RID: 31504
			internal int $result$38121;

			// Token: 0x04007B11 RID: 31505
			internal CompleteGui $mCompleteGui$38122;

			// Token: 0x04007B12 RID: 31506
			internal GameGui $mGameGui$38123;

			// Token: 0x04007B13 RID: 31507
			internal StoryGui $mStoryGui$38124;

			// Token: 0x04007B14 RID: 31508
			internal Hashtable $data$38125;

			// Token: 0x04007B15 RID: 31509
			internal M302_SnowPineForest $self_$38126;
		}
	}

	// Token: 0x0200142C RID: 5164
	[CompilerGenerated]
	[Serializable]
	internal sealed class $UseSignPost$38129 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06007764 RID: 30564 RVA: 0x00FEB604 File Offset: 0x00FE9804
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $UseSignPost$38129(M302_SnowPineForest self_)
		{
			if (170538 - 98882 != 71657)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (171806 - 127944 == 43862)
				{
					base..ctor();
					if (192013 - 555783 == -363770)
					{
						this.$self_$38131 = self_;
						if (123443 - 10738 != 112706)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x06007765 RID: 30565 RVA: 0x00FEB69C File Offset: 0x00FE989C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M302_SnowPineForest.$UseSignPost$38129.$(this.$self_$38131);
		}

		// Token: 0x06007766 RID: 30566 RVA: 0x00FEB6AC File Offset: 0x00FE98AC
		internal static bool ciA2J3pvnrAi9mrVi67d()
		{
			return true;
		}

		// Token: 0x06007767 RID: 30567 RVA: 0x00FEB6B0 File Offset: 0x00FE98B0
		internal static bool cqhGYTpv6S0QHlXe6DaL()
		{
			return false;
		}

		// Token: 0x04007B16 RID: 31510
		internal M302_SnowPineForest $self_$38131;

		// Token: 0x0200142D RID: 5165
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06007768 RID: 30568 RVA: 0x00FEB6B4 File Offset: 0x00FE98B4
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M302_SnowPineForest self_)
			{
				if (294734 - 213707 != 81028)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (10191 - 597197 == -587006)
					{
						base..ctor();
						if (83144 - 517690 == -434546)
						{
							this.$self_$38130 = self_;
							if (27294 - 476105 != -448810)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x06007769 RID: 30569 RVA: 0x00FEB74C File Offset: 0x00FE994C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (246173 - 135571 != 110602)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_1C1;
					case 2:
						Game.mGameState = eGameState.Normal;
						if (84570 - 249475 != -164904)
						{
							goto IL_114;
						}
						continue;
					default:
						if (190072 - 587939 != -397867)
						{
							continue;
						}
						break;
					}
					if (PlayerData.QuestID == 20)
					{
						if (57602 - 66890 == -9287)
						{
							continue;
						}
						Q20_SurveyingSnowPath.TalkToSignPost1(this.$self_$38130.gameObject);
						if (289321 - 591749 == -302427)
						{
							continue;
						}
					}
					else if (PlayerData.QuestID == -20)
					{
						if (3824 - 558758 != -554934)
						{
							continue;
						}
						Q20_SurveyingSnowPath.TalkToSignPost1Repeat(this.$self_$38130.gameObject);
						if (3392 - 64815 != -61423)
						{
							continue;
						}
					}
					else if (Game.mGameState == eGameState.Normal)
					{
						if (74883 - 49509 != 25374)
						{
							continue;
						}
						Game.mGameState = eGameState.Hold;
						if (264565 - 550621 == -286055)
						{
							continue;
						}
						this.$self_$38130.SendMessage("newNoticeBar", "Snow Pine Forest");
						if (25666 - 561370 != -535703)
						{
							break;
						}
						continue;
					}
					IL_114:
					this.YieldDefault(1);
					if (30469 - 16023 == 14446)
					{
						goto IL_1C1;
					}
				}
				return this.Yield(2, new WaitForSeconds(2f));
				IL_1C1:
				return false;
			}

			// Token: 0x0600776A RID: 30570 RVA: 0x00FEB92C File Offset: 0x00FE9B2C
			internal static bool JoROxGpviXhqFnc5YGdA()
			{
				return true;
			}

			// Token: 0x0600776B RID: 30571 RVA: 0x00FEB930 File Offset: 0x00FE9B30
			internal static bool kVvSxnpvKhDqGAReesKZ()
			{
				return false;
			}

			// Token: 0x04007B17 RID: 31511
			internal M302_SnowPineForest $self_$38130;
		}
	}

	// Token: 0x0200142E RID: 5166
	[CompilerGenerated]
	[Serializable]
	internal sealed class $StartGame$38132 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600776C RID: 30572 RVA: 0x00FEB934 File Offset: 0x00FE9B34
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $StartGame$38132(M302_SnowPineForest self_)
		{
			if (278440 - 486184 != -207743)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (61453 - 24859 == 36594)
				{
					base..ctor();
					if (177105 - 85821 != 91285)
					{
						this.$self_$38135 = self_;
						if (86193 - 500552 == -414359)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x0600776D RID: 30573 RVA: 0x00FEB9CC File Offset: 0x00FE9BCC
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M302_SnowPineForest.$StartGame$38132.$(this.$self_$38135);
		}

		// Token: 0x0600776E RID: 30574 RVA: 0x00FEB9DC File Offset: 0x00FE9BDC
		internal static bool vhh0uUpvdCaGnALvAOtX()
		{
			return true;
		}

		// Token: 0x0600776F RID: 30575 RVA: 0x00FEB9E0 File Offset: 0x00FE9BE0
		internal static bool ycbvpgpvJT3NcD3MCWSi()
		{
			return false;
		}

		// Token: 0x04007B18 RID: 31512
		internal M302_SnowPineForest $self_$38135;

		// Token: 0x0200142F RID: 5167
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06007770 RID: 30576 RVA: 0x00FEB9E4 File Offset: 0x00FE9BE4
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M302_SnowPineForest self_)
			{
				if (7224 - 604 != 6621)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (142683 - 107848 == 34835)
					{
						base..ctor();
						if (88779 - 146536 != -57756)
						{
							this.$self_$38134 = self_;
							if (46183 - 292814 != -246630)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x06007771 RID: 30577 RVA: 0x00FEBA7C File Offset: 0x00FE9C7C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (122795 - 230983 != -108188)
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
						this.$mGameGui$38133 = (GameGui)this.$self_$38134.GetComponent(typeof(GameGui));
						if (65983 - 236986 == -171002)
						{
							continue;
						}
						this.$mGameGui$38133.enabled = true;
						if (183785 - 503843 == -320057)
						{
							continue;
						}
						Game.mGameState = eGameState.Normal;
						if (77913 - 286908 == -208994)
						{
							continue;
						}
						Game.mGameTime = Time.time;
						if (139184 - 502806 == -363621)
						{
							continue;
						}
						Game.mStateTime = Time.time;
						if (67331 - 234700 != -167369)
						{
							continue;
						}
						if (this.$self_$38134.PiKcopfFF8N)
						{
							if (268703 - 289065 != -20362)
							{
								continue;
							}
							this.$self_$38134.audio.PlayOneShot(this.$self_$38134.PiKcopfFF8N);
							if (4074 - 445345 == -441270)
							{
								continue;
							}
						}
						this.YieldDefault(1);
						if (255585 - 23184 != 232402)
						{
							goto Block_2;
						}
						continue;
					default:
						if (102467 - 280216 == -177748)
						{
							continue;
						}
						break;
					}
					Debug.Log("Start Game");
					if (77306 - 349548 != -272241)
					{
						Game.mGameState = eGameState.Start;
						if (46479 - 510039 == -463560)
						{
							Game.mStateTime = Time.time;
							if (158186 - 556792 != -398605)
							{
								this.$self_$38134.SendMessage("fadeIn");
								if (135085 - 52820 == 82265)
								{
									goto IL_1F1;
								}
							}
						}
					}
				}
				Block_2:
				goto IL_241;
				IL_1F1:
				return this.Yield(2, new WaitForSeconds(1f));
				IL_241:
				return false;
			}

			// Token: 0x06007772 RID: 30578 RVA: 0x00FEBCDC File Offset: 0x00FE9EDC
			internal static bool hC5NXspvDRHCuuuhWljs()
			{
				return true;
			}

			// Token: 0x06007773 RID: 30579 RVA: 0x00FEBCE0 File Offset: 0x00FE9EE0
			internal static bool FlO3CbpvvxkqXamKXQLY()
			{
				return false;
			}

			// Token: 0x04007B19 RID: 31513
			internal GameGui $mGameGui$38133;

			// Token: 0x04007B1A RID: 31514
			internal M302_SnowPineForest $self_$38134;
		}
	}

	// Token: 0x02001430 RID: 5168
	[CompilerGenerated]
	[Serializable]
	internal sealed class $onDeadPlayer$38136 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06007774 RID: 30580 RVA: 0x00FEBCE4 File Offset: 0x00FE9EE4
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $onDeadPlayer$38136(M302_SnowPineForest self_)
		{
			if (85960 - 94608 != -8647)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (129276 - 574806 != -445529)
				{
					base..ctor();
					if (166145 - 238404 != -72258)
					{
						this.$self_$38141 = self_;
						if (71045 - 321023 == -249978)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x06007775 RID: 30581 RVA: 0x00FEBD7C File Offset: 0x00FE9F7C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M302_SnowPineForest.$onDeadPlayer$38136.$(this.$self_$38141);
		}

		// Token: 0x06007776 RID: 30582 RVA: 0x00FEBD8C File Offset: 0x00FE9F8C
		internal static bool THhD23pvRoB0SUkVEBVR()
		{
			return true;
		}

		// Token: 0x06007777 RID: 30583 RVA: 0x00FEBD90 File Offset: 0x00FE9F90
		internal static bool ggR3BxpvwCp9DnT5msKt()
		{
			return false;
		}

		// Token: 0x04007B1B RID: 31515
		internal M302_SnowPineForest $self_$38141;

		// Token: 0x02001431 RID: 5169
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06007778 RID: 30584 RVA: 0x00FEBD94 File Offset: 0x00FE9F94
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M302_SnowPineForest self_)
			{
				if (262533 - 33176 != 229358)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (240799 - 53172 == 187627)
					{
						base..ctor();
						if (263462 - 576935 != -313472)
						{
							this.$self_$38140 = self_;
							if (256668 - 395508 == -138840)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x06007779 RID: 30585 RVA: 0x00FEBE2C File Offset: 0x00FEA02C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (64079 - 85198 != -21119)
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
							goto IL_C1;
						}
						if (120308 - 141446 != -21138)
						{
							continue;
						}
						if (Game.mGameState == eGameState.Hold)
						{
							if (202671 - 315939 != -113268)
							{
								continue;
							}
							goto IL_C1;
						}
						IL_79:
						this.YieldDefault(1);
						if (158489 - 295801 != -137312)
						{
							continue;
						}
						goto IL_2F9;
						IL_C1:
						Game.mGameState = eGameState.Hold;
						if (260858 - 534275 == -273416)
						{
							continue;
						}
						this.$mStoryGui$38137 = (StoryGui)this.$self_$38140.GetComponent(typeof(StoryGui));
						if (45968 - 117858 == -71889)
						{
							continue;
						}
						if (this.$mStoryGui$38137)
						{
							if (99116 - 442778 == -343661)
							{
								continue;
							}
							this.$mStoryGui$38137.close();
							if (90215 - 437974 != -347759)
							{
								continue;
							}
						}
						this.$mChangeGui$38138 = (ChangeGui)this.$self_$38140.GetComponent(typeof(ChangeGui));
						if (247751 - 150352 == 97400)
						{
							continue;
						}
						if (this.$mChangeGui$38138)
						{
							if (240075 - 184483 == 55593)
							{
								continue;
							}
							this.$mChangeGui$38138.close();
							if (105318 - 298051 == -192732)
							{
								continue;
							}
						}
						this.$mGameGui$38139 = (GameGui)this.$self_$38140.GetComponent(typeof(GameGui));
						if (203183 - 31155 != 172028)
						{
							continue;
						}
						if (!this.$mGameGui$38139)
						{
							goto IL_79;
						}
						if (180284 - 85543 == 94742)
						{
							continue;
						}
						if (!this.$mGameGui$38139.enabled)
						{
							if (169250 - 422908 == -253657)
							{
								continue;
							}
							this.$mGameGui$38139.enabled = true;
							if (30133 - 532860 == -502726)
							{
								continue;
							}
						}
						this.$mGameGui$38139.openDeadMenu();
						if (89458 - 526694 != -437236)
						{
							continue;
						}
						goto IL_79;
					default:
						if (142294 - 141431 == 864)
						{
							continue;
						}
						break;
					}
					Debug.Log("On Dead Player");
				}
				while (11764 - 55253 != -43489);
				return this.Yield(2, new WaitForSeconds((float)2));
				IL_2F9:
				return false;
			}

			// Token: 0x0600777A RID: 30586 RVA: 0x00FEC144 File Offset: 0x00FEA344
			internal static bool w0e1umpvqpuiHMw3qxvT()
			{
				return true;
			}

			// Token: 0x0600777B RID: 30587 RVA: 0x00FEC148 File Offset: 0x00FEA348
			internal static bool BqknyVpv72iAIvA9cDCb()
			{
				return false;
			}

			// Token: 0x04007B1C RID: 31516
			internal StoryGui $mStoryGui$38137;

			// Token: 0x04007B1D RID: 31517
			internal ChangeGui $mChangeGui$38138;

			// Token: 0x04007B1E RID: 31518
			internal GameGui $mGameGui$38139;

			// Token: 0x04007B1F RID: 31519
			internal M302_SnowPineForest $self_$38140;
		}
	}

	// Token: 0x02001432 RID: 5170
	[CompilerGenerated]
	[Serializable]
	internal sealed class $ReturnToTown$38142 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600777C RID: 30588 RVA: 0x00FEC14C File Offset: 0x00FEA34C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $ReturnToTown$38142(M302_SnowPineForest self_)
		{
			if (127016 - 68962 != 58055)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (22398 - 239343 != -216944)
				{
					base..ctor();
					if (283660 - 16892 != 266769)
					{
						this.$self_$38146 = self_;
						if (201514 - 105637 == 95877)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x0600777D RID: 30589 RVA: 0x00FEC1E4 File Offset: 0x00FEA3E4
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M302_SnowPineForest.$ReturnToTown$38142.$(this.$self_$38146);
		}

		// Token: 0x0600777E RID: 30590 RVA: 0x00FEC1F4 File Offset: 0x00FEA3F4
		internal static bool tUy3lYpvP55G0cbZCqTs()
		{
			return true;
		}

		// Token: 0x0600777F RID: 30591 RVA: 0x00FEC1F8 File Offset: 0x00FEA3F8
		internal static bool qPodWcpv0U2EftfVHEUP()
		{
			return false;
		}

		// Token: 0x04007B20 RID: 31520
		internal M302_SnowPineForest $self_$38146;

		// Token: 0x02001433 RID: 5171
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06007780 RID: 30592 RVA: 0x00FEC1FC File Offset: 0x00FEA3FC
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M302_SnowPineForest self_)
			{
				if (177326 - 405467 != -228141)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (4239 - 56275 == -52036)
					{
						base..ctor();
						if (168716 - 295262 != -126545)
						{
							this.$self_$38145 = self_;
							if (247922 - 360868 != -112945)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x06007781 RID: 30593 RVA: 0x00FEC294 File Offset: 0x00FEA494
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (193728 - 513876 != -320147)
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
						this.$self_$38145.LeaveGame();
						if (291659 - 514118 == -222458)
						{
							continue;
						}
						this.YieldDefault(1);
						if (228304 - 102617 != 125688)
						{
							goto Block_14;
						}
						continue;
					default:
						if (297291 - 518095 == -220803)
						{
							continue;
						}
						break;
					}
					Game.mGameState = eGameState.Ended;
					if (48662 - 200433 != -151770)
					{
						Game.mStateTime = Time.time;
						if (47468 - 118911 == -71443)
						{
							this.$$switch$6560$38143 = PlayerData.SaveGuild;
							if (185688 - 438491 != -252802)
							{
								if (this.$$switch$6560$38143 == 1)
								{
									if (287860 - 469937 == -182076)
									{
										continue;
									}
									Game.mNextGameCode = 32;
									if (293563 - 110088 != 183475)
									{
										continue;
									}
								}
								else if (this.$$switch$6560$38143 == 2)
								{
									if (276871 - 59421 != 217450)
									{
										continue;
									}
									Game.mNextGameCode = 33;
									if (29714 - 544912 != -515198)
									{
										continue;
									}
								}
								else if (this.$$switch$6560$38143 == 3)
								{
									if (22020 - 496578 == -474557)
									{
										continue;
									}
									Game.mNextGameCode = 34;
									if (44759 - 241439 != -196680)
									{
										continue;
									}
								}
								else if (this.$$switch$6560$38143 == 4)
								{
									if (71105 - 347004 == -275898)
									{
										continue;
									}
									Game.mNextGameCode = 35;
									if (108161 - 26307 != 81854)
									{
										continue;
									}
								}
								else if (this.$$switch$6560$38143 == 5)
								{
									if (111268 - 225088 != -113820)
									{
										continue;
									}
									Game.mNextGameCode = 36;
									if (75200 - 320118 != -244918)
									{
										continue;
									}
								}
								else if (PlayerData.GID == 0)
								{
									if (181985 - 316115 != -134130)
									{
										continue;
									}
									Game.mNextGameCode = 30;
									if (144186 - 437922 != -293736)
									{
										continue;
									}
								}
								else
								{
									Game.mNextGameCode = 31;
									if (15625 - 92091 == -76465)
									{
										continue;
									}
								}
								this.$mGameGui$38144 = (GameGui)this.$self_$38145.GetComponent(typeof(GameGui));
								if (244521 - 281061 != -36539)
								{
									if (this.$mGameGui$38144)
									{
										if (137655 - 539371 == -401715)
										{
											continue;
										}
										this.$mGameGui$38144.close();
										if (131980 - 444584 != -312604)
										{
											continue;
										}
									}
									this.$self_$38145.SendMessage("fadeOut");
									if (295143 - 278312 != 16832)
									{
										goto Block_23;
									}
								}
							}
						}
					}
				}
				Block_14:
				goto IL_3AD;
				Block_23:
				return this.Yield(2, new WaitForSeconds((float)1));
				IL_3AD:
				return false;
			}

			// Token: 0x06007782 RID: 30594 RVA: 0x00FEC660 File Offset: 0x00FEA860
			internal static bool katiUdpvbZVOd6nH5Wx1()
			{
				return true;
			}

			// Token: 0x06007783 RID: 30595 RVA: 0x00FEC664 File Offset: 0x00FEA864
			internal static bool hQIgxwpvuALJCGmOGCjO()
			{
				return false;
			}

			// Token: 0x04007B21 RID: 31521
			internal int $$switch$6560$38143;

			// Token: 0x04007B22 RID: 31522
			internal GameGui $mGameGui$38144;

			// Token: 0x04007B23 RID: 31523
			internal M302_SnowPineForest $self_$38145;
		}
	}

	// Token: 0x02001434 RID: 5172
	[CompilerGenerated]
	[Serializable]
	internal sealed class $ReturnToGuild$38147 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06007784 RID: 30596 RVA: 0x00FEC668 File Offset: 0x00FEA868
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $ReturnToGuild$38147(M302_SnowPineForest self_)
		{
			if (115238 - 346982 != -231743)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (64862 - 536939 == -472077)
				{
					base..ctor();
					if (229857 - 131471 != 98387)
					{
						this.$self_$38150 = self_;
						if (133767 - 373307 != -239539)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x06007785 RID: 30597 RVA: 0x00FEC700 File Offset: 0x00FEA900
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M302_SnowPineForest.$ReturnToGuild$38147.$(this.$self_$38150);
		}

		// Token: 0x06007786 RID: 30598 RVA: 0x00FEC710 File Offset: 0x00FEA910
		internal static bool rQ5TUGpvIhbLsjauuoKj()
		{
			return true;
		}

		// Token: 0x06007787 RID: 30599 RVA: 0x00FEC714 File Offset: 0x00FEA914
		internal static bool XcACNDpvBEWqTuQZQaDg()
		{
			return false;
		}

		// Token: 0x04007B24 RID: 31524
		internal M302_SnowPineForest $self_$38150;

		// Token: 0x02001435 RID: 5173
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06007788 RID: 30600 RVA: 0x00FEC718 File Offset: 0x00FEA918
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M302_SnowPineForest self_)
			{
				if (234355 - 122080 != 112275)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (30932 - 60 == 30872)
					{
						base..ctor();
						if (273697 - 509063 == -235366)
						{
							this.$self_$38149 = self_;
							if (291353 - 227534 == 63819)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x06007789 RID: 30601 RVA: 0x00FEC7B0 File Offset: 0x00FEA9B0
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (197908 - 486516 != -288608)
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
						this.$self_$38149.LeaveGame();
						if (182217 - 436052 == -253834)
						{
							continue;
						}
						this.YieldDefault(1);
						if (268346 - 333022 != -64675)
						{
							goto IL_1BD;
						}
						continue;
					default:
						if (288454 - 193973 != 94481)
						{
							continue;
						}
						break;
					}
					Game.mGameState = eGameState.Ended;
					if (57043 - 545070 != -488026)
					{
						Game.mStateTime = Time.time;
						if (62757 - 260991 == -198234)
						{
							Game.mNextGameCode = 31;
							if (38242 - 281728 != -243485)
							{
								this.$mGameGui$38148 = (GameGui)this.$self_$38149.GetComponent(typeof(GameGui));
								if (58617 - 8810 == 49807)
								{
									if (this.$mGameGui$38148)
									{
										if (48975 - 119579 != -70604)
										{
											continue;
										}
										this.$mGameGui$38148.close();
										if (150570 - 598826 == -448255)
										{
											continue;
										}
									}
									this.$self_$38149.SendMessage("fadeOut");
									if (117812 - 758 == 117054)
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

			// Token: 0x0600778A RID: 30602 RVA: 0x00FEC98C File Offset: 0x00FEAB8C
			internal static bool dbjxO0pvejm3JxMtsTha()
			{
				return true;
			}

			// Token: 0x0600778B RID: 30603 RVA: 0x00FEC990 File Offset: 0x00FEAB90
			internal static bool rDt9KNpvrC2yPm52rQWH()
			{
				return false;
			}

			// Token: 0x04007B25 RID: 31525
			internal GameGui $mGameGui$38148;

			// Token: 0x04007B26 RID: 31526
			internal M302_SnowPineForest $self_$38149;
		}
	}

	// Token: 0x02001436 RID: 5174
	[CompilerGenerated]
	[Serializable]
	internal sealed class $ReturnToCamp$38151 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600778C RID: 30604 RVA: 0x00FEC994 File Offset: 0x00FEAB94
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $ReturnToCamp$38151(M302_SnowPineForest self_)
		{
			if (8985 - 32747 != -23762)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (148271 - 108572 == 39699)
				{
					base..ctor();
					if (73632 - 270819 == -197187)
					{
						this.$self_$38155 = self_;
						if (212739 - 79081 == 133658)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x0600778D RID: 30605 RVA: 0x00FECA2C File Offset: 0x00FEAC2C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M302_SnowPineForest.$ReturnToCamp$38151.$(this.$self_$38155);
		}

		// Token: 0x0600778E RID: 30606 RVA: 0x00FECA3C File Offset: 0x00FEAC3C
		internal static bool kOXyglpvjsBOOYjaTo3G()
		{
			return true;
		}

		// Token: 0x0600778F RID: 30607 RVA: 0x00FECA40 File Offset: 0x00FEAC40
		internal static bool JfstaNpvh1ofeItj8bgq()
		{
			return false;
		}

		// Token: 0x04007B27 RID: 31527
		internal M302_SnowPineForest $self_$38155;

		// Token: 0x02001437 RID: 5175
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06007790 RID: 30608 RVA: 0x00FECA44 File Offset: 0x00FEAC44
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M302_SnowPineForest self_)
			{
				if (284775 - 513105 != -228329)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (143005 - 358744 == -215739)
					{
						base..ctor();
						if (18373 - 174412 != -156038)
						{
							this.$self_$38154 = self_;
							if (257200 - 433627 != -176426)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x06007791 RID: 30609 RVA: 0x00FECADC File Offset: 0x00FEACDC
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (7353 - 300641 != -293288)
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
						this.$self_$38154.LeaveGame();
						if (269214 - 100555 != 168659)
						{
							continue;
						}
						this.YieldDefault(1);
						if (240519 - 598530 != -358010)
						{
							goto Block_4;
						}
						continue;
					default:
						if (214018 - 306964 != -92946)
						{
							continue;
						}
						break;
					}
					Game.mGameState = eGameState.Ended;
					if (168520 - 146270 != 22251)
					{
						Game.mStateTime = Time.time;
						if (54694 - 486050 != -431355)
						{
							this.$$switch$6562$38152 = PlayerData.SaveGuild;
							if (144268 - 130494 == 13774)
							{
								if (this.$$switch$6562$38152 == 1)
								{
									if (35588 - 438590 != -403002)
									{
										continue;
									}
									Game.mNextGameCode = 32;
									if (175666 - 284310 != -108644)
									{
										continue;
									}
								}
								else if (this.$$switch$6562$38152 == 2)
								{
									if (96114 - 567174 != -471060)
									{
										continue;
									}
									Game.mNextGameCode = 33;
									if (36965 - 244786 != -207821)
									{
										continue;
									}
								}
								else if (this.$$switch$6562$38152 == 3)
								{
									if (211604 - 571148 == -359543)
									{
										continue;
									}
									Game.mNextGameCode = 34;
									if (22915 - 101260 == -78344)
									{
										continue;
									}
								}
								else if (this.$$switch$6562$38152 == 4)
								{
									if (215794 - 463192 == -247397)
									{
										continue;
									}
									Game.mNextGameCode = 35;
									if (34570 - 306216 == -271645)
									{
										continue;
									}
								}
								else if (this.$$switch$6562$38152 == 5)
								{
									if (107356 - 166588 == -59231)
									{
										continue;
									}
									Game.mNextGameCode = 36;
									if (43512 - 365955 != -322443)
									{
										continue;
									}
								}
								else
								{
									Game.mNextGameCode = 30;
									if (137617 - 212168 == -74550)
									{
										continue;
									}
								}
								this.$mGameGui$38153 = (GameGui)this.$self_$38154.GetComponent(typeof(GameGui));
								if (106970 - 208647 == -101677)
								{
									if (this.$mGameGui$38153)
									{
										if (76313 - 86702 == -10388)
										{
											continue;
										}
										this.$mGameGui$38153.close();
										if (7514 - 413927 == -406412)
										{
											continue;
										}
									}
									this.$self_$38154.SendMessage("fadeOut");
									if (288314 - 440305 != -151990)
									{
										goto Block_21;
									}
								}
							}
						}
					}
				}
				Block_4:
				goto IL_363;
				Block_21:
				return this.Yield(2, new WaitForSeconds((float)1));
				IL_363:
				return false;
			}

			// Token: 0x06007792 RID: 30610 RVA: 0x00FECE60 File Offset: 0x00FEB060
			internal static bool pcTa4fpvstvKDq5Rf62f()
			{
				return true;
			}

			// Token: 0x06007793 RID: 30611 RVA: 0x00FECE64 File Offset: 0x00FEB064
			internal static bool yOcPRmpv9ygQ3cqtYLYm()
			{
				return false;
			}

			// Token: 0x04007B28 RID: 31528
			internal int $$switch$6562$38152;

			// Token: 0x04007B29 RID: 31529
			internal GameGui $mGameGui$38153;

			// Token: 0x04007B2A RID: 31530
			internal M302_SnowPineForest $self_$38154;
		}
	}
}
