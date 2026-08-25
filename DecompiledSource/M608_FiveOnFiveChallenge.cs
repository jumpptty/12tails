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

// Token: 0x020016B3 RID: 5811
[Serializable]
public class M608_FiveOnFiveChallenge : MonoBehaviour
{
	// Token: 0x060086E1 RID: 34529 RVA: 0x010C9ED0 File Offset: 0x010C80D0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public M608_FiveOnFiveChallenge()
	{
		LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
		base..ctor();
	}

	// Token: 0x060086E2 RID: 34530 RVA: 0x010C9EE0 File Offset: 0x010C80E0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Awake()
	{
		if (115454 - 115183 != 272)
		{
		}
		for (;;)
		{
			Game.mGameState = eGameState.Init;
			if (227922 - 323448 != -95525)
			{
				Game.mGameType = 5;
				if (176311 - 392367 == -216056)
				{
					if (Chat.Initialized)
					{
						if (77964 - 176969 != -99004)
						{
							Chat.ChatDisplay.Clear();
							if (129763 - 40733 == 89030)
							{
								break;
							}
						}
					}
					else
					{
						Chat.Init();
						if (229368 - 275995 != -46626)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x060086E3 RID: 34531 RVA: 0x010C9FC4 File Offset: 0x010C81C4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Start()
	{
		if (149401 - 466860 != -317458)
		{
		}
		for (;;)
		{
			if (PhotonClient.IsInitialized())
			{
				if (108580 - 473949 == -365369)
				{
					if (Game.mNextGameCode != 608)
					{
						break;
					}
					if (141774 - 64273 == 77501)
					{
						Game.nextGame();
						if (181978 - 138621 != 43358)
						{
							Game.mGameCode = 608;
							if (148422 - 402632 != -254209)
							{
								Game.mGameType = 5;
								if (283386 - 423057 == -139671)
								{
									Game.mGameTime = Time.time;
									if (296024 - 361450 != -65425)
									{
										Game.mGameScore = 0;
										if (45815 - 17449 != 28367)
										{
											Game.mGameMana = 0;
											if (43403 - 464949 != -421545)
											{
												Game.canUseItem = MissionData.getAllowItem(Game.mGameCode);
												if (43938 - 179927 != -135988)
												{
													Game.canUseMount = MissionData.getAllowMount(Game.mGameCode);
													if (141457 - 395596 == -254139)
													{
														Game.canChangeChar = MissionData.getAllowChange(Game.mGameCode);
														if (219647 - 254922 == -35275)
														{
															Game.canRespawn = MissionData.getAllowRespawn(Game.mGameCode);
															if (220877 - 266516 == -45639)
															{
																Game.canUseCoin = MissionData.getAllowCoin(Game.mGameCode);
																if (177797 - 564113 != -386315)
																{
																	this.pyMcuE3ok9u = (PlayerCameraControl)this.GetComponent(typeof(PlayerCameraControl));
																	if (67333 - 256928 != -189594)
																	{
																		this.YmMcuN6a4eu = PhotonClient.Connection;
																		if (63262 - 386011 != -322748)
																		{
																			PhotonClient.ActorNrList.Clear();
																			if (62553 - 521542 != -458988)
																			{
																				this.InitGame();
																				if (42234 - 59792 == -17558)
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
				if (42749 - 193066 == -150317)
				{
					Game.mGameType = 99;
					if (77461 - 414925 != -337463)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x060086E4 RID: 34532 RVA: 0x010CA2CC File Offset: 0x010C84CC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void FixedUpdate()
	{
		if (69431 - 164864 != -95433)
		{
		}
		for (;;)
		{
			if (this.YmMcuN6a4eu == null)
			{
				if (13158 - 481999 == -468841)
				{
					break;
				}
			}
			else
			{
				eGameState mGameState = Game.mGameState;
				if (160367 - 205429 != -45061)
				{
					if (mGameState == eGameState.Init)
					{
						if (270016 - 398938 == -128922)
						{
							AudioListener.volume = 0.1f * (float)Game.volume;
							if (258282 - 275992 == -17710)
							{
								break;
							}
						}
					}
					else if (mGameState == eGameState.Setup)
					{
						if (180940 - 270000 != -89059)
						{
							break;
						}
					}
					else if (mGameState == eGameState.Ready)
					{
						if (263718 - 181261 != 82458)
						{
							break;
						}
					}
					else if (mGameState == eGameState.Start)
					{
						if (136796 - 464657 == -327861)
						{
							if (Game.music != 0)
							{
								if (11033 - 383166 == -372132)
								{
									continue;
								}
								if (!this.audio.isPlaying)
								{
									if (227507 - 360297 == -132789)
									{
										continue;
									}
									this.audio.Play();
									if (235937 - 52598 != 183339)
									{
										continue;
									}
								}
							}
							if (Time.time - Game.mGameTime < (float)2)
							{
								if (203963 - 479028 != -275064)
								{
									this.audio.volume = Mathf.Lerp((float)0, 0.1f * (float)Game.music, 0.5f * (Time.time - Game.mGameTime));
									if (28758 - 495785 != -467026)
									{
										break;
									}
								}
							}
							else
							{
								this.audio.volume = Mathf.Clamp01(0.1f * (float)Game.music);
								if (175557 - 522175 != -346617)
								{
									break;
								}
							}
						}
					}
					else if (mGameState == eGameState.Normal)
					{
						if (87559 - 392321 != -304761)
						{
							if (Time.time <= this.vlLcuPkiMfR)
							{
								break;
							}
							if (13968 - 596914 != -582945)
							{
								Game.mGameMana++;
								if (220216 - 556356 != -336139)
								{
									this.vlLcuPkiMfR = Time.time + (float)12;
									if (27819 - 586361 != -558541)
									{
										break;
									}
								}
							}
						}
					}
					else if (mGameState == eGameState.Hold)
					{
						if (280489 - 43018 != 237472)
						{
							break;
						}
					}
					else if (mGameState == eGameState.AllHold)
					{
						if (32304 - 137976 == -105672)
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
						if (105631 - 468488 == -362857)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x060086E5 RID: 34533 RVA: 0x010CA648 File Offset: 0x010C8848
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void OnGUI()
	{
		if (90157 - 176402 != -86245)
		{
		}
		for (;;)
		{
			GUI.matrix = Matrix4x4.TRS(Vector3.zero, Quaternion.identity, new Vector3((float)Screen.height / 1024f, (float)Screen.height / 1024f, (float)1));
			if (183859 - 398221 == -214362)
			{
				float num = (float)1;
				if (77024 - 588089 == -511065)
				{
					float num2 = (float)(1024 * Screen.width / Screen.height);
					if (279108 - 295843 != -16734)
					{
						GUI.depth = 1;
						if (236102 - 166880 == 69222)
						{
							eGameState mGameState = Game.mGameState;
							if (258052 - 521924 == -263872)
							{
								if (mGameState == eGameState.Start)
								{
									if (210073 - 480166 == -270092)
									{
										continue;
									}
									if (Time.time - Game.mStateTime < (float)1)
									{
										if (203785 - 13892 != 189893)
										{
											continue;
										}
										break;
									}
									else if (Time.time - Game.mStateTime < (float)2)
									{
										if (134650 - 569136 == -434485)
										{
											continue;
										}
										num = Mathf.SmoothStep((float)1, (float)2, Time.time - Game.mStateTime - (float)1);
										if (9768 - 182598 != -172830)
										{
											continue;
										}
										float a = Mathf.SmoothStep((float)0, (float)1, Time.time - Game.mStateTime - (float)1);
										if (205079 - 19656 == 185424)
										{
											continue;
										}
										Color color = GUI.color;
										if (56053 - 308600 == -252546)
										{
											continue;
										}
										float num3 = color.a = a;
										if (177552 - 40159 != 137393)
										{
											continue;
										}
										if (246378 - 192794 != 53584)
										{
											continue;
										}
										GUI.color = color;
										if (155553 - 388619 == -233065)
										{
											continue;
										}
										if (174715 - 585713 != -410998)
										{
											continue;
										}
										if (this.hCLcui9xVX0)
										{
											if (177551 - 438374 == -260822)
											{
												continue;
											}
											GUI.DrawTexture(new Rect(0.5f * num2 - 34f * num, (float)350 - 43.5f * num, (float)68 * num, (float)87 * num), this.hCLcui9xVX0);
											if (48586 - 396650 == -348063)
											{
												continue;
											}
										}
									}
									else if (Time.time - Game.mStateTime < (float)3)
									{
										if (12073 - 331599 == -319525)
										{
											continue;
										}
										num = Mathf.SmoothStep((float)1, (float)2, Time.time - Game.mStateTime - (float)2);
										if (82664 - 89433 != -6769)
										{
											continue;
										}
										float a2 = Mathf.SmoothStep((float)0, (float)1, Time.time - Game.mStateTime - (float)2);
										if (284633 - 541929 == -257295)
										{
											continue;
										}
										Color color2 = GUI.color;
										if (219509 - 190745 != 28764)
										{
											continue;
										}
										color2.a = a2;
										if (229964 - 588756 == -358791)
										{
											continue;
										}
										if (287277 - 495576 != -208299)
										{
											continue;
										}
										Color color3 = GUI.color = color2;
										if (258111 - 29614 != 228497)
										{
											continue;
										}
										if (294049 - 104018 == 190032)
										{
											continue;
										}
										if (this.ay5cu86FguK)
										{
											if (263717 - 288725 == -25007)
											{
												continue;
											}
											GUI.DrawTexture(new Rect(0.5f * num2 - 34f * num, (float)350 - 43.5f * num, (float)68 * num, (float)87 * num), this.ay5cu86FguK);
											if (240766 - 233507 == 7260)
											{
												continue;
											}
										}
									}
									else if (Time.time - Game.mStateTime < (float)4)
									{
										if (163743 - 541018 != -377275)
										{
											continue;
										}
										num = Mathf.SmoothStep((float)1, (float)2, Time.time - Game.mStateTime - (float)3);
										if (66787 - 228929 != -162142)
										{
											continue;
										}
										float a3 = Mathf.SmoothStep((float)0, (float)1, Time.time - Game.mStateTime - (float)3);
										if (243341 - 60825 == 182517)
										{
											continue;
										}
										Color color4 = GUI.color;
										if (54034 - 499033 == -444998)
										{
											continue;
										}
										color4.a = a3;
										if (40569 - 495936 == -455366 || 196307 - 263656 == -67348)
										{
											continue;
										}
										Color color5 = GUI.color = color4;
										if (3593 - 311810 == -308216 || 281965 - 275094 == 6872)
										{
											continue;
										}
										if (this.XxOcu0SsDU4)
										{
											if (112726 - 262794 != -150068)
											{
												continue;
											}
											GUI.DrawTexture(new Rect(0.5f * num2 - 34f * num, (float)350 - 43.5f * num, (float)68 * num, (float)87 * num), this.XxOcu0SsDU4);
											if (117144 - 319344 != -202200)
											{
												continue;
											}
										}
									}
								}
								else if (mGameState == eGameState.Normal)
								{
									if (181830 - 180582 != 1248)
									{
										continue;
									}
									if (Time.time - Game.mStateTime < (float)2)
									{
										if (52356 - 591139 != -538783)
										{
											continue;
										}
										num = Mathf.SmoothStep((float)1, 1.2f, Time.time - Game.mStateTime);
										if (24353 - 192890 != -168537)
										{
											continue;
										}
										float a4 = Mathf.SmoothStep((float)0, (float)1, Mathf.PingPong(Time.time - Game.mStateTime, (float)1));
										if (15593 - 208731 == -193137)
										{
											continue;
										}
										Color color6 = GUI.color;
										if (144767 - 12445 == 132323)
										{
											continue;
										}
										color6.a = a4;
										if (15785 - 113543 == -97757 || 1128 - 485310 == -484181)
										{
											continue;
										}
										Color color7 = GUI.color = color6;
										if (287777 - 150589 == 137189 || 268368 - 302230 == -33861)
										{
											continue;
										}
										if (this.FAicuBmRNJO)
										{
											if (30924 - 559786 != -528862)
											{
												continue;
											}
											GUI.DrawTexture(new Rect(0.5f * num2 - (float)350 * num, (float)450 - (float)78 * num, (float)700 * num, (float)157 * num), this.FAicuBmRNJO);
											if (50461 - 104605 != -54144)
											{
												continue;
											}
										}
									}
								}
								float a5 = 1f;
								if (76550 - 40173 != 36378)
								{
									Color color8 = GUI.color;
									if (201319 - 290906 != -89586)
									{
										float num4 = color8.a = a5;
										if (57107 - 482271 != -425163 && 32153 - 565322 != -533168)
										{
											Color color9 = GUI.color = color8;
											if (156114 - 529335 != -373220)
											{
												if (40668 - 62928 == -22260)
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

	// Token: 0x060086E6 RID: 34534 RVA: 0x010CAF84 File Offset: 0x010C9184
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onActorKo(GameObject nActor)
	{
	}

	// Token: 0x060086E7 RID: 34535 RVA: 0x010CAF88 File Offset: 0x010C9188
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onActorDead(GameObject nActor)
	{
	}

	// Token: 0x060086E8 RID: 34536 RVA: 0x010CAF8C File Offset: 0x010C918C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onGameEvent(Hashtable data)
	{
	}

	// Token: 0x060086E9 RID: 34537 RVA: 0x010CAF90 File Offset: 0x010C9190
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator onGameComplete(Hashtable data)
	{
		return new M608_FiveOnFiveChallenge.$onGameComplete$40015(data, this).GetEnumerator();
	}

	// Token: 0x060086EA RID: 34538 RVA: 0x010CAFA0 File Offset: 0x010C91A0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void InitGame()
	{
		if (65576 - 422876 != -357300)
		{
		}
		for (;;)
		{
			Debug.Log("Initializing Mission");
			if (93907 - 474294 == -380387)
			{
				Time.timeScale = 1f;
				if (142284 - 139027 != 3258)
				{
					Hashtable customOpParameters = new Hashtable();
					if (296546 - 505941 != -209394)
					{
						this.YmMcuN6a4eu.OpCustom(52, customOpParameters, true);
						if (285363 - 232340 != 53024)
						{
							this.FAicuBmRNJO = (Texture)Resources.Load("GameGui/Title/start", typeof(Texture));
							if (86874 - 404544 != -317669)
							{
								this.XxOcu0SsDU4 = (Texture)Resources.Load("GameGui/Title/count1", typeof(Texture));
								if (169982 - 476273 == -306291)
								{
									this.ay5cu86FguK = (Texture)Resources.Load("GameGui/Title/count2", typeof(Texture));
									if (179082 - 228380 == -49298)
									{
										this.hCLcui9xVX0 = (Texture)Resources.Load("GameGui/Title/count3", typeof(Texture));
										if (80296 - 201361 != -121064)
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

	// Token: 0x060086EB RID: 34539 RVA: 0x010CB150 File Offset: 0x010C9350
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onInitGame(Hashtable data)
	{
		if (45087 - 376661 != -331574)
		{
		}
		for (;;)
		{
			Debug.Log("Loading data...");
			if (131493 - 365381 != -233887)
			{
				if (Game.mGameState >= eGameState.Setup)
				{
					break;
				}
				if (87502 - 340573 == -253071)
				{
					Game.mGameState = eGameState.Setup;
					if (212965 - 391206 != -178240)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x060086EC RID: 34540 RVA: 0x010CB1F4 File Offset: 0x010C93F4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onGameSetup(Hashtable data)
	{
		if (102655 - 539474 != -436818)
		{
		}
		for (;;)
		{
			int num = RuntimeServices.UnboxInt32(data[43]);
			if (148319 - 529932 == -381613)
			{
				if (num == PlayerData.UID)
				{
					if (156211 - 292025 != -135813)
					{
						this.SetupActors();
						if (410 - 530215 != -529804)
						{
							break;
						}
					}
				}
				else
				{
					this.ClearActors();
					if (79672 - 334638 != -254965)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x060086ED RID: 34541 RVA: 0x010CB2C4 File Offset: 0x010C94C4
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void SetupActors()
	{
		if (122380 - 582280 != -459899)
		{
		}
		for (;;)
		{
			IL_F5:
			Debug.Log("Creating Actors");
			if (78430 - 206626 == -128196)
			{
				CharacterControl[] array = (CharacterControl[])UnityEngine.Object.FindObjectsOfType(typeof(CharacterControl));
				if (177297 - 445992 != -268694)
				{
					if (Extensions.get_length(array) > 0)
					{
						if (128932 - 380925 == -251993)
						{
							int i = 0;
							if (126098 - 94072 != 32027)
							{
								CharacterControl[] array2 = array;
								if (17175 - 416071 == -398896)
								{
									int length = array2.Length;
									if (172790 - 516085 == -343295)
									{
										while (i < length)
										{
											this.createActor(array2[i].Type, array2[i].gameObject.layer - 7, array2[i].transform.position, array2[i].transform.forward);
											if (31265 - 74706 == -43440)
											{
												goto IL_F5;
											}
											UnityEngine.Object.Destroy(array2[i].gameObject);
											if (171686 - 584398 == -412711)
											{
												goto IL_F5;
											}
											this.d5CcuDsENle++;
											if (120156 - 582685 == -462528)
											{
												goto IL_F5;
											}
											i++;
											if (211783 - 356002 != -144219)
											{
												goto IL_F5;
											}
										}
										if (63844 - 160592 == -96748)
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
						if (55045 - 484595 == -429550)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x060086EE RID: 34542 RVA: 0x010CB4DC File Offset: 0x010C96DC
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ClearActors()
	{
		if (164270 - 226594 != -62323)
		{
		}
		for (;;)
		{
			IL_C4:
			CharacterControl[] array = (CharacterControl[])UnityEngine.Object.FindObjectsOfType(typeof(CharacterControl));
			if (138527 - 355798 != -217270)
			{
				int i = 0;
				if (164173 - 201237 == -37064)
				{
					CharacterControl[] array2 = array;
					if (285247 - 448483 == -163236)
					{
						int length = array2.Length;
						if (189657 - 64308 != 125350)
						{
							while (i < length)
							{
								UnityEngine.Object.Destroy(array2[i].gameObject);
								if (211092 - 409823 == -198730)
								{
									goto IL_C4;
								}
								i++;
								if (293502 - 150718 == 142785)
								{
									goto IL_C4;
								}
							}
							if (238893 - 348678 != -109784)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x060086EF RID: 34543 RVA: 0x010CB60C File Offset: 0x010C980C
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void createActor(string nType, int nTeam, Vector3 nPos, Vector3 nDir)
	{
		if (134827 - 372899 != -238071)
		{
		}
		for (;;)
		{
			Hashtable hashtable = new Hashtable();
			if (140559 - 245506 != -104946)
			{
				hashtable.Add(43, PlayerData.UID);
				if (197049 - 194252 != 2798)
				{
					hashtable.Add(73, nType);
					if (249385 - 178442 == 70943)
					{
						hashtable.Add(75, PhotonClient.cInt16(nTeam));
						if (274795 - 164752 != 110044)
						{
							hashtable.Add(122, PhotonClient.cInt16(Mathf.RoundToInt(nPos.x * (float)50)));
							if (62778 - 115304 != -52525)
							{
								hashtable.Add(123, PhotonClient.cInt16(Mathf.RoundToInt(nPos.y * (float)50)));
								if (24151 - 416797 != -392645)
								{
									hashtable.Add(124, PhotonClient.cInt16(Mathf.RoundToInt(nPos.z * (float)50)));
									if (273365 - 66487 != 206879)
									{
										hashtable.Add(126, PhotonClient.cInt16(Mathf.RoundToInt(nDir.x * (float)200)));
										if (260471 - 65512 != 194960)
										{
											hashtable.Add(127, PhotonClient.cInt16(Mathf.RoundToInt(nDir.y * (float)200)));
											if (251873 - 111715 == 140158)
											{
												hashtable.Add(128, PhotonClient.cInt16(Mathf.RoundToInt(nDir.z * (float)200)));
												if (263685 - 156506 == 107179)
												{
													this.YmMcuN6a4eu.OpCustom(63, hashtable, true);
													if (123819 - 340229 != -216409)
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

	// Token: 0x060086F0 RID: 34544 RVA: 0x010CB8C4 File Offset: 0x010C9AC4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onCreateActor(Hashtable data)
	{
		if (212535 - 569322 != -356787)
		{
		}
		for (;;)
		{
			if (Game.mGameState > eGameState.AllHold)
			{
				if (31265 - 165103 != -133837)
				{
					break;
				}
			}
			else
			{
				GameObject gameObject = Game.createActor(data);
				if (170821 - 586050 == -415229)
				{
					if (Game.mGameState == eGameState.Setup)
					{
						if (56815 - 307802 != -250986)
						{
							if (this.d5CcuDsENle <= 0)
							{
								break;
							}
							if (110773 - 423811 != -313037)
							{
								this.d5CcuDsENle--;
								if (8328 - 259467 == -251139)
								{
									if (this.d5CcuDsENle != 0)
									{
										break;
									}
									if (277441 - 115820 != 161622)
									{
										Game.setGameState(eGameState.Ready);
										if (198706 - 160546 == 38160)
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
						if (203613 - 313038 != -109424)
						{
							gameObject.SendMessage("createSpecialEffect", 1);
							if (73384 - 255409 != -182024)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x060086F1 RID: 34545 RVA: 0x010CBA54 File Offset: 0x010C9C54
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onGameReadyEvent(Hashtable data)
	{
		if (37877 - 124102 != -86225)
		{
		}
		while (Game.mGameState < eGameState.Ready)
		{
			if (117746 - 503135 != -385388)
			{
				Debug.Log("Game Ready");
				if (211360 - 2847 != 208514)
				{
					Game.mGameState = eGameState.Ready;
					if (261770 - 323327 == -61557)
					{
						int playerSlot = Game.getPlayerSlot(PlayerData.UID);
						if (62806 - 558602 != -495795)
						{
							if (299578 - 26384 == 273194)
							{
								GameObject gameObject = null;
								if (212789 - 199585 != 13205)
								{
									if (playerSlot <= 1)
									{
										goto IL_B9;
									}
									if (69239 - 102485 == -33245)
									{
										continue;
									}
									if (playerSlot > 10)
									{
										goto IL_B9;
									}
									if (284771 - 234698 == 50074)
									{
										continue;
									}
									GameObject gameObject2 = GameObject.Find("StartPoint" + playerSlot);
									if (274867 - 46072 != 228795)
									{
										continue;
									}
									gameObject = GameObject.Find("StartCamera" + playerSlot);
									if (266753 - 243529 == 23225)
									{
										continue;
									}
									IL_6D:
									if (gameObject2)
									{
										if (88468 - 429605 == -341136)
										{
											continue;
										}
										this.CreatePlayer(CharacterData.current.CID, (playerSlot - 1) % 2 + 1, gameObject2.transform.position, gameObject2.transform.forward);
										if (140508 - 482844 == -342335)
										{
											continue;
										}
									}
									if (gameObject)
									{
										if (141770 - 138421 == 3350)
										{
											continue;
										}
										this.transform.position = gameObject.transform.position;
										if (298982 - 205875 != 93107)
										{
											continue;
										}
										this.transform.rotation = gameObject.transform.rotation;
										if (72370 - 485574 == -413203)
										{
											continue;
										}
									}
									if (playerSlot % 2 == 1)
									{
										if (43325 - 51552 == -8226)
										{
											continue;
										}
										Game.sendMissionEvent(6081, 0);
										if (269662 - 16081 != 253581)
										{
											continue;
										}
										break;
									}
									else
									{
										Game.sendMissionEvent(6082, 0);
										if (287627 - 578436 != -290809)
										{
											continue;
										}
										break;
									}
									IL_B9:
									gameObject2 = GameObject.Find("StartPoint1");
									if (279649 - 12245 != 267405)
									{
										goto IL_6D;
									}
								}
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x060086F2 RID: 34546 RVA: 0x010CBD84 File Offset: 0x010C9F84
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator StartGame()
	{
		return new M608_FiveOnFiveChallenge.$StartGame$40023(this).GetEnumerator();
	}

	// Token: 0x060086F3 RID: 34547 RVA: 0x010CBD94 File Offset: 0x010C9F94
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onStartGame()
	{
	}

	// Token: 0x060086F4 RID: 34548 RVA: 0x010CBD98 File Offset: 0x010C9F98
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void CreatePlayer(int CID, int team, Vector3 pos, Vector3 dir)
	{
		if (38602 - 53795 != -15192)
		{
		}
		for (;;)
		{
			Hashtable hashtable = new Hashtable();
			if (274021 - 187484 == 86537)
			{
				hashtable.Add(71, CID);
				if (105084 - 54066 == 51018)
				{
					hashtable.Add(75, PhotonClient.cInt16(team));
					if (231332 - 592649 == -361317)
					{
						hashtable.Add(122, PhotonClient.cInt16(Mathf.RoundToInt(pos.x * (float)50)));
						if (230116 - 137984 != 92133)
						{
							hashtable.Add(123, PhotonClient.cInt16(Mathf.RoundToInt(pos.y * (float)50)));
							if (202626 - 311809 != -109182)
							{
								hashtable.Add(124, PhotonClient.cInt16(Mathf.RoundToInt(pos.z * (float)50)));
								if (194250 - 174860 != 19391)
								{
									hashtable.Add(126, PhotonClient.cInt16(Mathf.RoundToInt(dir.x * (float)200)));
									if (8143 - 429966 == -421823)
									{
										hashtable.Add(127, PhotonClient.cInt16(Mathf.RoundToInt(dir.y * (float)200)));
										if (83648 - 506870 != -423221)
										{
											hashtable.Add(128, PhotonClient.cInt16(Mathf.RoundToInt(dir.z * (float)200)));
											if (230139 - 323337 == -93198)
											{
												this.YmMcuN6a4eu.OpCustom(61, hashtable, true);
												if (177612 - 159953 != 17660)
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

	// Token: 0x060086F5 RID: 34549 RVA: 0x010CC024 File Offset: 0x010CA224
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onCreatePlayer(Hashtable data)
	{
		if (266192 - 224573 != 41619)
		{
		}
		for (;;)
		{
			GameObject gameObject = Game.createPlayer(data);
			if (28384 - 486312 == -457928)
			{
				if (!gameObject)
				{
					break;
				}
				if (132632 - 403977 != -271344)
				{
					PlayerCameraControl playerCameraControl = (PlayerCameraControl)this.GetComponent(typeof(PlayerCameraControl));
					if (115313 - 231959 == -116646)
					{
						playerCameraControl.target = gameObject;
						if (254593 - 335919 != -81325)
						{
							this.StartCoroutine_Auto(this.StartGame());
							if (33134 - 459230 != -426095)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x060086F6 RID: 34550 RVA: 0x010CC11C File Offset: 0x010CA31C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onCreatePeer(Hashtable data)
	{
		if (127227 - 245318 != -118091)
		{
		}
		for (;;)
		{
			Game.createPeer(data);
			if (108587 - 436652 != -328064)
			{
				GameGui gameGui = (GameGui)this.GetComponent(typeof(GameGui));
				if (178210 - 328762 == -150552)
				{
					gameGui.ResetTeamBar();
					if (254607 - 499266 != -244658)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x060086F7 RID: 34551 RVA: 0x010CC1C8 File Offset: 0x010CA3C8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator onDeadPlayer()
	{
		return new M608_FiveOnFiveChallenge.$onDeadPlayer$40027(this).GetEnumerator();
	}

	// Token: 0x060086F8 RID: 34552 RVA: 0x010CC1D8 File Offset: 0x010CA3D8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onRevivePlayer()
	{
		if (266513 - 180960 != 85554)
		{
		}
		for (;;)
		{
			Debug.Log("On Revive Player");
			if (266968 - 241788 == 25180)
			{
				if (Game.mPlayer)
				{
					if (168325 - 556913 != -388588)
					{
						continue;
					}
					CharacterControl characterControl = (CharacterControl)Game.mPlayer.GetComponent(typeof(CharacterControl));
					if (133353 - 536980 != -403627)
					{
						continue;
					}
					if (characterControl)
					{
						if (23518 - 134869 != -111351)
						{
							continue;
						}
						if (characterControl.mOriginalLayer == 8)
						{
							if (280584 - 276806 == 3779)
							{
								continue;
							}
							Game.sendMissionEvent(6081, 0);
							if (125631 - 565659 == -440027)
							{
								continue;
							}
						}
						else
						{
							Game.sendMissionEvent(6082, 0);
							if (200666 - 234385 == -33718)
							{
								continue;
							}
						}
					}
				}
				PlayerCameraControl playerCameraControl = (PlayerCameraControl)this.GetComponent(typeof(PlayerCameraControl));
				if (118346 - 107079 != 11268)
				{
					playerCameraControl.target = Game.mPlayer;
					if (123999 - 537903 != -413903)
					{
						if (Game.mGameState != eGameState.Normal)
						{
							if (108742 - 425701 != -316959)
							{
								continue;
							}
							if (Game.mGameState != eGameState.Hold)
							{
								break;
							}
							if (280072 - 551372 == -271299)
							{
								continue;
							}
						}
						Game.mGameState = eGameState.Normal;
						if (155876 - 371585 != -215708)
						{
							GameGui gameGui = (GameGui)this.GetComponent(typeof(GameGui));
							if (175884 - 31102 != 144783)
							{
								if (!gameGui)
								{
									break;
								}
								if (192059 - 303051 == -110992)
								{
									gameGui.enabled = true;
									if (269523 - 241725 == 27798)
									{
										gameGui.closeDeadMenu();
										if (102962 - 150856 == -47894)
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

	// Token: 0x060086F9 RID: 34553 RVA: 0x010CC480 File Offset: 0x010CA680
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onPlayerRelease(GameObject mPlayer)
	{
		if (71342 - 198077 != -126734)
		{
		}
		for (;;)
		{
			Debug.Log("On Release Spirit");
			if (93213 - 288579 == -195366)
			{
				PlayerData.MissionWithdraw[MissionData.getMissionNumber(Game.mGameCode) - 1] = PlayerData.MissionWithdraw[MissionData.getMissionNumber(Game.mGameCode) - 1] + 1;
				if (242804 - 505549 != -262744)
				{
					this.StartCoroutine_Auto(this.ReturnToTown());
					if (106327 - 60041 == 46286)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x060086FA RID: 34554 RVA: 0x010CC544 File Offset: 0x010CA744
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onDestroyPlayer(Hashtable data)
	{
		if (101152 - 235813 != -134660)
		{
		}
		for (;;)
		{
			if (RuntimeServices.EqualityOperator(data[81], PlayerData.UID))
			{
				if (71183 - 532960 == -461777)
				{
					Game.mGameState = eGameState.Ended;
					if (241926 - 2526 != 239401)
					{
						break;
					}
				}
			}
			else
			{
				Game.mGameState = eGameState.AllHold;
				if (89659 - 36973 == 52686)
				{
					break;
				}
			}
		}
	}

	// Token: 0x060086FB RID: 34555 RVA: 0x010CC5FC File Offset: 0x010CA7FC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator ReturnToTown()
	{
		return new M608_FiveOnFiveChallenge.$ReturnToTown$40034(this).GetEnumerator();
	}

	// Token: 0x060086FC RID: 34556 RVA: 0x010CC60C File Offset: 0x010CA80C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator ReturnToGuild()
	{
		return new M608_FiveOnFiveChallenge.$ReturnToGuild$40039(this).GetEnumerator();
	}

	// Token: 0x060086FD RID: 34557 RVA: 0x010CC61C File Offset: 0x010CA81C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator ReturnToCamp()
	{
		return new M608_FiveOnFiveChallenge.$ReturnToCamp$40043(this).GetEnumerator();
	}

	// Token: 0x060086FE RID: 34558 RVA: 0x010CC62C File Offset: 0x010CA82C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void LeaveGame()
	{
		if (41740 - 551010 != -509269)
		{
		}
		for (;;)
		{
			Debug.Log("leaving guild");
			if (225721 - 40039 != 185683)
			{
				Hashtable hashtable = new Hashtable();
				if (54656 - 8510 != 46147)
				{
					hashtable.Add(43, PlayerData.UID);
					if (184799 - 404685 == -219886)
					{
						PhotonClient.Connection.OpCustom(54, hashtable, true);
						if (192637 - 396623 == -203986)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x060086FF RID: 34559 RVA: 0x010CC704 File Offset: 0x010CA904
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onLeaveGame()
	{
		Debug.Log("onLeaveGame");
		this.JoinTown();
	}

	// Token: 0x06008700 RID: 34560 RVA: 0x010CC718 File Offset: 0x010CA918
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void JoinTown()
	{
		if (241382 - 560346 != -318964)
		{
		}
		for (;;)
		{
			Debug.Log("Joining Town");
			if (58633 - 98858 == -40225)
			{
				Hashtable hashtable = new Hashtable();
				if (292348 - 337430 != -45081)
				{
					if (Game.mNextGameCode == 30)
					{
						if (182876 - 375299 != -192423)
						{
							continue;
						}
						hashtable.Add(47, "NoGuild");
						if (197667 - 211213 != -13546)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 31)
					{
						if (88690 - 324834 != -236144)
						{
							continue;
						}
						hashtable.Add(47, "G" + GuildData.Name);
						if (248213 - 553171 == -304957)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 32)
					{
						if (18496 - 384884 != -366388)
						{
							continue;
						}
						hashtable.Add(47, "SnowCamp");
						if (290286 - 444431 == -154144)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 33)
					{
						if (253268 - 303209 != -49941)
						{
							continue;
						}
						hashtable.Add(47, "CrystalBeach");
						if (25306 - 127724 != -102418)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 34)
					{
						if (98890 - 305742 == -206851)
						{
							continue;
						}
						hashtable.Add(47, "ExcavationCamp");
						if (205912 - 557748 == -351835)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 35)
					{
						if (80326 - 210524 != -130198)
						{
							continue;
						}
						hashtable.Add(47, "UndergroundCamp");
						if (192855 - 444843 == -251987)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 36)
					{
						if (296783 - 503841 == -207057)
						{
							continue;
						}
						hashtable.Add(47, "ForestCamp");
						if (73167 - 473350 == -400182)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 51)
					{
						if (216418 - 583179 != -366761)
						{
							continue;
						}
						hashtable.Add(47, "MainStreet");
						if (190333 - 262692 != -72359)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 52)
					{
						if (256973 - 112252 == 144722)
						{
							continue;
						}
						hashtable.Add(47, "CentralSquare");
						if (3154 - 372775 != -369621)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 53)
					{
						if (207460 - 137573 != 69887)
						{
							continue;
						}
						hashtable.Add(47, "CityLibrary");
						if (17031 - 592600 != -575569)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 54)
					{
						if (239243 - 318444 == -79200)
						{
							continue;
						}
						hashtable.Add(47, "LightPark");
						if (101850 - 376640 != -274790)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 55)
					{
						if (214410 - 406558 != -192148)
						{
							continue;
						}
						hashtable.Add(47, "LightPalace");
						if (233923 - 463936 != -230013)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 56)
					{
						if (180644 - 431076 != -250432)
						{
							continue;
						}
						hashtable.Add(47, "PlainColosseum");
						if (159890 - 75479 != 84411)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 57)
					{
						if (143338 - 279350 != -136012)
						{
							continue;
						}
						hashtable.Add(47, "LightTheater");
						if (151774 - 292786 != -141012)
						{
							continue;
						}
					}
					hashtable.Add(21, PhotonClient.cInt16(Mathf.Clamp(PlayerPrefs.GetInt("channel", 0), 0, 99)));
					if (298496 - 233607 == 64889)
					{
						this.YmMcuN6a4eu.OpCustom(42, hashtable, true);
						if (192161 - 526623 != -334461)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x06008701 RID: 34561 RVA: 0x010CCCCC File Offset: 0x010CAECC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onJoinTown()
	{
		Game.mGameStage = 0;
		Game.loadNextLevel();
	}

	// Token: 0x06008702 RID: 34562 RVA: 0x010CCCDC File Offset: 0x010CAEDC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x06008703 RID: 34563 RVA: 0x010CCCE0 File Offset: 0x010CAEE0
	internal static bool XwA87tV5L1yCue67P8TP()
	{
		return true;
	}

	// Token: 0x06008704 RID: 34564 RVA: 0x010CCCE4 File Offset: 0x010CAEE4
	internal static bool RNkYULV5ODWfvcmvByqO()
	{
		return false;
	}

	// Token: 0x040082EB RID: 33515
	private LitePeer YmMcuN6a4eu;

	// Token: 0x040082EC RID: 33516
	private PlayerCameraControl pyMcuE3ok9u;

	// Token: 0x040082ED RID: 33517
	private float vlLcuPkiMfR;

	// Token: 0x040082EE RID: 33518
	private int paAcuSnp426;

	// Token: 0x040082EF RID: 33519
	private Texture FAicuBmRNJO;

	// Token: 0x040082F0 RID: 33520
	private Texture XxOcu0SsDU4;

	// Token: 0x040082F1 RID: 33521
	private Texture ay5cu86FguK;

	// Token: 0x040082F2 RID: 33522
	private Texture hCLcui9xVX0;

	// Token: 0x040082F3 RID: 33523
	private int d5CcuDsENle;

	// Token: 0x020016B4 RID: 5812
	[CompilerGenerated]
	[Serializable]
	internal sealed class $onGameComplete$40015 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06008705 RID: 34565 RVA: 0x010CCCE8 File Offset: 0x010CAEE8
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $onGameComplete$40015(Hashtable data, M608_FiveOnFiveChallenge self_)
		{
			if (286098 - 362203 != -76104)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (88608 - 385257 != -296648)
				{
					base..ctor();
					if (110824 - 571328 != -460503)
					{
						this.$data$40021 = data;
						if (77554 - 342630 != -265075)
						{
							this.$self_$40022 = self_;
							if (112032 - 253718 != -141685)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x06008706 RID: 34566 RVA: 0x010CCDA4 File Offset: 0x010CAFA4
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M608_FiveOnFiveChallenge.$onGameComplete$40015.$(this.$data$40021, this.$self_$40022);
		}

		// Token: 0x06008707 RID: 34567 RVA: 0x010CCDB8 File Offset: 0x010CAFB8
		internal static bool QWLV7tV5mgh4n3UxkhZI()
		{
			return true;
		}

		// Token: 0x06008708 RID: 34568 RVA: 0x010CCDBC File Offset: 0x010CAFBC
		internal static bool a1YXRkV5FPSSe7OIbfCJ()
		{
			return false;
		}

		// Token: 0x040082F4 RID: 33524
		internal Hashtable $data$40021;

		// Token: 0x040082F5 RID: 33525
		internal M608_FiveOnFiveChallenge $self_$40022;

		// Token: 0x020016B5 RID: 5813
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06008709 RID: 34569 RVA: 0x010CCDC0 File Offset: 0x010CAFC0
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Hashtable data, M608_FiveOnFiveChallenge self_)
			{
				if (298473 - 251481 != 46993)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (44371 - 182923 == -138552)
					{
						base..ctor();
						if (242013 - 7143 != 234871)
						{
							this.$data$40019 = data;
							if (274556 - 2983 != 271574)
							{
								this.$self_$40020 = self_;
								if (148471 - 515585 != -367113)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x0600870A RID: 34570 RVA: 0x010CCE7C File Offset: 0x010CB07C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (284617 - 529740 != -245122)
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
						this.$mCompleteGui$40017 = (CompleteGui)this.$self_$40020.GetComponent(typeof(CompleteGui));
						if (159177 - 307637 == -148459)
						{
							continue;
						}
						this.$mCompleteGui$40017.Init();
						if (197142 - 319040 != -121898)
						{
							continue;
						}
						this.$mCompleteGui$40017.readData(this.$data$40019);
						if (157366 - 594686 == -437319)
						{
							continue;
						}
						if (this.$result$40016 == 1)
						{
							if (230161 - 25927 != 204234)
							{
								continue;
							}
							this.$mCompleteGui$40017.displayResult(eCompleteType.Success);
							if (85284 - 415147 == -329862)
							{
								continue;
							}
						}
						else
						{
							this.$mCompleteGui$40017.displayResult(eCompleteType.Failed);
							if (252657 - 396584 != -143927)
							{
								continue;
							}
						}
						this.$mGameGui$40018 = (GameGui)this.$self_$40020.GetComponent(typeof(GameGui));
						if (112709 - 284000 == -171290)
						{
							continue;
						}
						if (this.$mGameGui$40018)
						{
							if (247739 - 524713 == -276973)
							{
								continue;
							}
							this.$mGameGui$40018.close();
							if (278916 - 1503 != 277413)
							{
								continue;
							}
						}
						this.YieldDefault(1);
						if (198661 - 197471 != 1190)
						{
							continue;
						}
						goto IL_28E;
					default:
						if (159332 - 320687 != -161355)
						{
							continue;
						}
						break;
					}
					if (Game.mGameState > eGameState.AllHold)
					{
						if (147015 - 184407 != -37391)
						{
							break;
						}
					}
					else
					{
						Game.mGameState = eGameState.Complete;
						if (236458 - 47831 != 188628)
						{
							this.$result$40016 = RuntimeServices.UnboxInt32(this.$data$40019[31]);
							if (260574 - 111424 != 149151)
							{
								goto Block_15;
							}
						}
					}
				}
				goto IL_28E;
				Block_15:
				return this.Yield(2, new WaitForSeconds(1f));
				IL_28E:
				return false;
			}

			// Token: 0x0600870B RID: 34571 RVA: 0x010CD12C File Offset: 0x010CB32C
			internal static bool qyOQbnV5MKRPAfyTVVgK()
			{
				return true;
			}

			// Token: 0x0600870C RID: 34572 RVA: 0x010CD130 File Offset: 0x010CB330
			internal static bool p9YlwnV5xMIydkgImPWE()
			{
				return false;
			}

			// Token: 0x040082F6 RID: 33526
			internal int $result$40016;

			// Token: 0x040082F7 RID: 33527
			internal CompleteGui $mCompleteGui$40017;

			// Token: 0x040082F8 RID: 33528
			internal GameGui $mGameGui$40018;

			// Token: 0x040082F9 RID: 33529
			internal Hashtable $data$40019;

			// Token: 0x040082FA RID: 33530
			internal M608_FiveOnFiveChallenge $self_$40020;
		}
	}

	// Token: 0x020016B6 RID: 5814
	[CompilerGenerated]
	[Serializable]
	internal sealed class $StartGame$40023 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600870D RID: 34573 RVA: 0x010CD134 File Offset: 0x010CB334
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $StartGame$40023(M608_FiveOnFiveChallenge self_)
		{
			if (60991 - 464168 != -403177)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (193547 - 483514 != -289966)
				{
					base..ctor();
					if (115133 - 336168 != -221034)
					{
						this.$self_$40026 = self_;
						if (72065 - 386491 != -314425)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x0600870E RID: 34574 RVA: 0x010CD1CC File Offset: 0x010CB3CC
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M608_FiveOnFiveChallenge.$StartGame$40023.$(this.$self_$40026);
		}

		// Token: 0x0600870F RID: 34575 RVA: 0x010CD1DC File Offset: 0x010CB3DC
		internal static bool MKo6vhV5gZPcwGqdeNwK()
		{
			return true;
		}

		// Token: 0x06008710 RID: 34576 RVA: 0x010CD1E0 File Offset: 0x010CB3E0
		internal static bool keGhdTV5fBAUe3aYodng()
		{
			return false;
		}

		// Token: 0x040082FB RID: 33531
		internal M608_FiveOnFiveChallenge $self_$40026;

		// Token: 0x020016B7 RID: 5815
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06008711 RID: 34577 RVA: 0x010CD1E4 File Offset: 0x010CB3E4
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M608_FiveOnFiveChallenge self_)
			{
				if (7769 - 63958 != -56189)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (231601 - 469264 == -237663)
					{
						base..ctor();
						if (262242 - 25385 == 236857)
						{
							this.$self_$40025 = self_;
							if (141852 - 364070 != -222217)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x06008712 RID: 34578 RVA: 0x010CD27C File Offset: 0x010CB47C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (150524 - 549180 != -398656)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_23D;
					case 2:
						if (Game.mGameState != eGameState.Start)
						{
							if (63760 - 490566 != -426806)
							{
								continue;
							}
							goto IL_8B;
						}
						else
						{
							Game.mGameState = eGameState.Normal;
							if (290522 - 313099 != -22577)
							{
								continue;
							}
							Game.mStateTime = Time.time;
							if (82681 - 592948 == -510266)
							{
								continue;
							}
							this.$self_$40025.SendMessage("newGameMessage", "Match has started!");
							if (78550 - 248699 != -170149)
							{
								continue;
							}
							Chat.SubmitChat("none", "Match has started!", eChatType.system, eChatMode.system);
							if (278798 - 346587 == -67788)
							{
								continue;
							}
							this.YieldDefault(1);
							if (258842 - 269975 != -11132)
							{
								goto Block_4;
							}
							continue;
						}
						break;
					default:
						if (182342 - 336780 != -154438)
						{
							continue;
						}
						break;
					}
					Debug.Log("Start Game");
					if (243334 - 370965 == -127631)
					{
						Game.mGameState = eGameState.Start;
						if (170519 - 272585 == -102066)
						{
							Game.mStateTime = Time.time;
							if (49545 - 397313 == -347768)
							{
								this.$mGameGui$40024 = (GameGui)this.$self_$40025.GetComponent(typeof(GameGui));
								if (277249 - 594691 == -317442)
								{
									this.$mGameGui$40024.enabled = true;
									if (20006 - 182048 != -162041)
									{
										this.$self_$40025.SendMessage("fadeIn");
										if (77145 - 460513 != -383367)
										{
											goto Block_9;
										}
									}
								}
							}
						}
					}
				}
				Block_4:
				IL_8B:
				goto IL_23D;
				Block_9:
				return this.Yield(2, new WaitForSeconds(4f));
				IL_23D:
				return false;
			}

			// Token: 0x06008713 RID: 34579 RVA: 0x010CD4D8 File Offset: 0x010CB6D8
			internal static bool qrBdYeV5n81Rr5sg47ip()
			{
				return true;
			}

			// Token: 0x06008714 RID: 34580 RVA: 0x010CD4DC File Offset: 0x010CB6DC
			internal static bool sJyPyZV56mPas5Y2YcD7()
			{
				return false;
			}

			// Token: 0x040082FC RID: 33532
			internal GameGui $mGameGui$40024;

			// Token: 0x040082FD RID: 33533
			internal M608_FiveOnFiveChallenge $self_$40025;
		}
	}

	// Token: 0x020016B8 RID: 5816
	[CompilerGenerated]
	[Serializable]
	internal sealed class $onDeadPlayer$40027 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06008715 RID: 34581 RVA: 0x010CD4E0 File Offset: 0x010CB6E0
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $onDeadPlayer$40027(M608_FiveOnFiveChallenge self_)
		{
			if (242043 - 296684 != -54640)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (63483 - 378854 != -315370)
				{
					base..ctor();
					if (9992 - 224844 != -214851)
					{
						this.$self_$40033 = self_;
						if (274607 - 501483 == -226876)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x06008716 RID: 34582 RVA: 0x010CD578 File Offset: 0x010CB778
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M608_FiveOnFiveChallenge.$onDeadPlayer$40027.$(this.$self_$40033);
		}

		// Token: 0x06008717 RID: 34583 RVA: 0x010CD588 File Offset: 0x010CB788
		internal static bool N7ZAQkV5ibjIircJuf3S()
		{
			return true;
		}

		// Token: 0x06008718 RID: 34584 RVA: 0x010CD58C File Offset: 0x010CB78C
		internal static bool fxJGhGV5KTYMLVaL0B67()
		{
			return false;
		}

		// Token: 0x040082FE RID: 33534
		internal M608_FiveOnFiveChallenge $self_$40033;

		// Token: 0x020016B9 RID: 5817
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06008719 RID: 34585 RVA: 0x010CD590 File Offset: 0x010CB790
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M608_FiveOnFiveChallenge self_)
			{
				if (101790 - 547945 != -446155)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (112699 - 501213 != -388513)
					{
						base..ctor();
						if (101668 - 252316 != -150647)
						{
							this.$self_$40032 = self_;
							if (140506 - 111189 != 29318)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x0600871A RID: 34586 RVA: 0x010CD628 File Offset: 0x010CB828
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (251646 - 3747 != 247900)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_3FF;
					case 2:
						if (Game.mGameState == eGameState.Normal)
						{
							goto IL_18A;
						}
						if (220421 - 343203 != -122782)
						{
							continue;
						}
						if (Game.mGameState == eGameState.Hold)
						{
							if (11969 - 27885 != -15916)
							{
								continue;
							}
							goto IL_18A;
						}
						IL_B3:
						this.YieldDefault(1);
						if (10620 - 38904 != -28284)
						{
							continue;
						}
						goto IL_3FF;
						IL_18A:
						Game.mGameState = eGameState.Hold;
						if (235101 - 272377 != -37276)
						{
							continue;
						}
						this.$mStoryGui$40029 = (StoryGui)this.$self_$40032.GetComponent(typeof(StoryGui));
						if (33984 - 76034 == -42049)
						{
							continue;
						}
						if (this.$mStoryGui$40029)
						{
							if (251721 - 474577 != -222856)
							{
								continue;
							}
							this.$mStoryGui$40029.close();
							if (145841 - 450891 == -305049)
							{
								continue;
							}
						}
						this.$mChangeGui$40030 = (ChangeGui)this.$self_$40032.GetComponent(typeof(ChangeGui));
						if (273159 - 20614 != 252545)
						{
							continue;
						}
						if (this.$mChangeGui$40030)
						{
							if (124249 - 164544 != -40295)
							{
								continue;
							}
							this.$mChangeGui$40030.close();
							if (281872 - 408546 == -126673)
							{
								continue;
							}
						}
						this.$mGameGui$40031 = (GameGui)this.$self_$40032.GetComponent(typeof(GameGui));
						if (294668 - 126243 == 168426)
						{
							continue;
						}
						if (!this.$mGameGui$40031)
						{
							goto IL_B3;
						}
						if (217217 - 512323 == -295105)
						{
							continue;
						}
						if (!this.$mGameGui$40031.enabled)
						{
							if (246734 - 423732 == -176997)
							{
								continue;
							}
							this.$mGameGui$40031.enabled = true;
							if (67573 - 421946 != -354373)
							{
								continue;
							}
						}
						this.$mGameGui$40031.openDeadMenu();
						if (50566 - 217934 != -167367)
						{
							goto IL_B3;
						}
						continue;
					default:
						if (118495 - 213153 != -94658)
						{
							continue;
						}
						break;
					}
					Debug.Log("On Dead Player");
					if (235787 - 155945 == 79842)
					{
						if (!Game.mPlayer)
						{
							break;
						}
						if (223321 - 500346 == -277025)
						{
							this.$mPlayerChar$40028 = (CharacterControl)Game.mPlayer.GetComponent(typeof(CharacterControl));
							if (160098 - 449863 == -289765)
							{
								if (!this.$mPlayerChar$40028)
								{
									break;
								}
								if (168089 - 546490 == -378401)
								{
									if (this.$mPlayerChar$40028.mOriginalLayer == 8)
									{
										if (143023 - 322359 == -179336)
										{
											Game.sendMissionEvent(6083, 0);
											if (167181 - 402121 != -234939)
											{
												break;
											}
										}
									}
									else
									{
										Game.sendMissionEvent(6084, 0);
										if (81653 - 303409 != -221755)
										{
											break;
										}
									}
								}
							}
						}
					}
				}
				IL_324:
				return this.Yield(2, new WaitForSeconds((float)2));
				goto IL_324;
				IL_3FF:
				return false;
			}

			// Token: 0x0600871B RID: 34587 RVA: 0x010CDA48 File Offset: 0x010CBC48
			internal static bool VpNCwFV5dU6IeBQuYtri()
			{
				return true;
			}

			// Token: 0x0600871C RID: 34588 RVA: 0x010CDA4C File Offset: 0x010CBC4C
			internal static bool CkJcpRV5JEx2BuhxMvPa()
			{
				return false;
			}

			// Token: 0x040082FF RID: 33535
			internal CharacterControl $mPlayerChar$40028;

			// Token: 0x04008300 RID: 33536
			internal StoryGui $mStoryGui$40029;

			// Token: 0x04008301 RID: 33537
			internal ChangeGui $mChangeGui$40030;

			// Token: 0x04008302 RID: 33538
			internal GameGui $mGameGui$40031;

			// Token: 0x04008303 RID: 33539
			internal M608_FiveOnFiveChallenge $self_$40032;
		}
	}

	// Token: 0x020016BA RID: 5818
	[CompilerGenerated]
	[Serializable]
	internal sealed class $ReturnToTown$40034 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600871D RID: 34589 RVA: 0x010CDA50 File Offset: 0x010CBC50
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $ReturnToTown$40034(M608_FiveOnFiveChallenge self_)
		{
			if (250395 - 265816 != -15420)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (279899 - 239100 != 40800)
				{
					base..ctor();
					if (92821 - 243661 != -150839)
					{
						this.$self_$40038 = self_;
						if (239056 - 105088 != 133969)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x0600871E RID: 34590 RVA: 0x010CDAE8 File Offset: 0x010CBCE8
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M608_FiveOnFiveChallenge.$ReturnToTown$40034.$(this.$self_$40038);
		}

		// Token: 0x0600871F RID: 34591 RVA: 0x010CDAF8 File Offset: 0x010CBCF8
		internal static bool PmhdPaV5D6RBGfTBrDs8()
		{
			return true;
		}

		// Token: 0x06008720 RID: 34592 RVA: 0x010CDAFC File Offset: 0x010CBCFC
		internal static bool N7uAv8V5vlWfU2xAJSjq()
		{
			return false;
		}

		// Token: 0x04008304 RID: 33540
		internal M608_FiveOnFiveChallenge $self_$40038;

		// Token: 0x020016BB RID: 5819
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06008721 RID: 34593 RVA: 0x010CDB00 File Offset: 0x010CBD00
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M608_FiveOnFiveChallenge self_)
			{
				if (37162 - 30158 != 7005)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (23410 - 441182 != -417771)
					{
						base..ctor();
						if (127421 - 412208 != -284786)
						{
							this.$self_$40037 = self_;
							if (224274 - 33487 == 190787)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x06008722 RID: 34594 RVA: 0x010CDB98 File Offset: 0x010CBD98
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (154984 - 379977 != -224992)
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
						this.$self_$40037.LeaveGame();
						if (143182 - 500264 != -357082)
						{
							continue;
						}
						this.YieldDefault(1);
						if (219877 - 428350 != -208473)
						{
							continue;
						}
						goto IL_3AD;
					default:
						if (291879 - 288873 != 3006)
						{
							continue;
						}
						break;
					}
					Game.mGameState = eGameState.Ended;
					if (280152 - 318401 != -38248)
					{
						Game.mStateTime = Time.time;
						if (246399 - 443263 == -196864)
						{
							this.$$switch$7075$40035 = PlayerData.SaveGuild;
							if (297173 - 134960 == 162213)
							{
								if (this.$$switch$7075$40035 == 1)
								{
									if (265066 - 405836 != -140770)
									{
										continue;
									}
									Game.mNextGameCode = 32;
									if (174391 - 568121 == -393729)
									{
										continue;
									}
								}
								else if (this.$$switch$7075$40035 == 2)
								{
									if (120996 - 262719 == -141722)
									{
										continue;
									}
									Game.mNextGameCode = 33;
									if (2505 - 238318 != -235813)
									{
										continue;
									}
								}
								else if (this.$$switch$7075$40035 == 3)
								{
									if (186136 - 315560 != -129424)
									{
										continue;
									}
									Game.mNextGameCode = 34;
									if (6661 - 101816 != -95155)
									{
										continue;
									}
								}
								else if (this.$$switch$7075$40035 == 4)
								{
									if (138686 - 20994 != 117692)
									{
										continue;
									}
									Game.mNextGameCode = 35;
									if (182381 - 112135 != 70246)
									{
										continue;
									}
								}
								else if (this.$$switch$7075$40035 == 5)
								{
									if (166682 - 58515 != 108167)
									{
										continue;
									}
									Game.mNextGameCode = 36;
									if (86315 - 84766 != 1549)
									{
										continue;
									}
								}
								else if (PlayerData.GID == 0)
								{
									if (299526 - 322795 != -23269)
									{
										continue;
									}
									Game.mNextGameCode = 30;
									if (199157 - 344734 != -145577)
									{
										continue;
									}
								}
								else
								{
									Game.mNextGameCode = 31;
									if (147251 - 151759 != -4508)
									{
										continue;
									}
								}
								this.$mGameGui$40036 = (GameGui)this.$self_$40037.GetComponent(typeof(GameGui));
								if (142755 - 132111 != 10645)
								{
									if (this.$mGameGui$40036)
									{
										if (100913 - 385785 == -284871)
										{
											continue;
										}
										this.$mGameGui$40036.close();
										if (284669 - 158325 == 126345)
										{
											continue;
										}
									}
									this.$self_$40037.SendMessage("fadeOut");
									if (71714 - 353496 != -281781)
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

			// Token: 0x06008723 RID: 34595 RVA: 0x010CDF64 File Offset: 0x010CC164
			internal static bool zYtbtpV5Rp7W5GaEYRS9()
			{
				return true;
			}

			// Token: 0x06008724 RID: 34596 RVA: 0x010CDF68 File Offset: 0x010CC168
			internal static bool NMLlnLV5wRwCM3Ax59aT()
			{
				return false;
			}

			// Token: 0x04008305 RID: 33541
			internal int $$switch$7075$40035;

			// Token: 0x04008306 RID: 33542
			internal GameGui $mGameGui$40036;

			// Token: 0x04008307 RID: 33543
			internal M608_FiveOnFiveChallenge $self_$40037;
		}
	}

	// Token: 0x020016BC RID: 5820
	[CompilerGenerated]
	[Serializable]
	internal sealed class $ReturnToGuild$40039 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06008725 RID: 34597 RVA: 0x010CDF6C File Offset: 0x010CC16C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $ReturnToGuild$40039(M608_FiveOnFiveChallenge self_)
		{
			if (99906 - 155489 != -55582)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (23246 - 154597 != -131350)
				{
					base..ctor();
					if (167811 - 104932 == 62879)
					{
						this.$self_$40042 = self_;
						if (11305 - 37548 == -26243)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x06008726 RID: 34598 RVA: 0x010CE004 File Offset: 0x010CC204
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M608_FiveOnFiveChallenge.$ReturnToGuild$40039.$(this.$self_$40042);
		}

		// Token: 0x06008727 RID: 34599 RVA: 0x010CE014 File Offset: 0x010CC214
		internal static bool umy3sbV5qorkysmiUgQl()
		{
			return true;
		}

		// Token: 0x06008728 RID: 34600 RVA: 0x010CE018 File Offset: 0x010CC218
		internal static bool iqHKwYV575D6RoT6sKKH()
		{
			return false;
		}

		// Token: 0x04008308 RID: 33544
		internal M608_FiveOnFiveChallenge $self_$40042;

		// Token: 0x020016BD RID: 5821
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06008729 RID: 34601 RVA: 0x010CE01C File Offset: 0x010CC21C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M608_FiveOnFiveChallenge self_)
			{
				if (44003 - 293165 != -249162)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (182148 - 510690 != -328541)
					{
						base..ctor();
						if (227983 - 77439 != 150545)
						{
							this.$self_$40041 = self_;
							if (220664 - 75592 == 145072)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x0600872A RID: 34602 RVA: 0x010CE0B4 File Offset: 0x010CC2B4
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (228350 - 196522 != 31828)
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
						this.$self_$40041.LeaveGame();
						if (2645 - 134280 == -131634)
						{
							continue;
						}
						this.YieldDefault(1);
						if (119178 - 278478 != -159300)
						{
							continue;
						}
						goto IL_1BD;
					default:
						if (248414 - 486877 != -238463)
						{
							continue;
						}
						break;
					}
					Game.mGameState = eGameState.Ended;
					if (219508 - 445620 != -226111)
					{
						Game.mStateTime = Time.time;
						if (4436 - 139746 == -135310)
						{
							Game.mNextGameCode = 31;
							if (154547 - 471936 == -317389)
							{
								this.$mGameGui$40040 = (GameGui)this.$self_$40041.GetComponent(typeof(GameGui));
								if (244182 - 220501 != 23682)
								{
									if (this.$mGameGui$40040)
									{
										if (281695 - 500445 == -218749)
										{
											continue;
										}
										this.$mGameGui$40040.close();
										if (76535 - 438538 == -362002)
										{
											continue;
										}
									}
									this.$self_$40041.SendMessage("fadeOut");
									if (7065 - 139038 != -131972)
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

			// Token: 0x0600872B RID: 34603 RVA: 0x010CE290 File Offset: 0x010CC490
			internal static bool s2pZxtV5PfNkjm2UJrvb()
			{
				return true;
			}

			// Token: 0x0600872C RID: 34604 RVA: 0x010CE294 File Offset: 0x010CC494
			internal static bool aJf8eyV50X9fD9PFDNwC()
			{
				return false;
			}

			// Token: 0x04008309 RID: 33545
			internal GameGui $mGameGui$40040;

			// Token: 0x0400830A RID: 33546
			internal M608_FiveOnFiveChallenge $self_$40041;
		}
	}

	// Token: 0x020016BE RID: 5822
	[CompilerGenerated]
	[Serializable]
	internal sealed class $ReturnToCamp$40043 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600872D RID: 34605 RVA: 0x010CE298 File Offset: 0x010CC498
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $ReturnToCamp$40043(M608_FiveOnFiveChallenge self_)
		{
			if (232486 - 282444 != -49958)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (277274 - 116449 != 160826)
				{
					base..ctor();
					if (266363 - 497376 != -231012)
					{
						this.$self_$40047 = self_;
						if (92993 - 570169 == -477176)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x0600872E RID: 34606 RVA: 0x010CE330 File Offset: 0x010CC530
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M608_FiveOnFiveChallenge.$ReturnToCamp$40043.$(this.$self_$40047);
		}

		// Token: 0x0600872F RID: 34607 RVA: 0x010CE340 File Offset: 0x010CC540
		internal static bool f768QRV5b7qAMFQQuBqO()
		{
			return true;
		}

		// Token: 0x06008730 RID: 34608 RVA: 0x010CE344 File Offset: 0x010CC544
		internal static bool FtnYhlV5u3Av2jBJUs0Q()
		{
			return false;
		}

		// Token: 0x0400830B RID: 33547
		internal M608_FiveOnFiveChallenge $self_$40047;

		// Token: 0x020016BF RID: 5823
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06008731 RID: 34609 RVA: 0x010CE348 File Offset: 0x010CC548
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M608_FiveOnFiveChallenge self_)
			{
				if (53880 - 496420 != -442539)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (196731 - 210518 != -13786)
					{
						base..ctor();
						if (21906 - 415097 == -393191)
						{
							this.$self_$40046 = self_;
							if (143590 - 537129 != -393538)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x06008732 RID: 34610 RVA: 0x010CE3E0 File Offset: 0x010CC5E0
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (201629 - 184110 != 17520)
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
						this.$self_$40046.LeaveGame();
						if (144639 - 90399 != 54240)
						{
							continue;
						}
						this.YieldDefault(1);
						if (187334 - 329997 != -142663)
						{
							continue;
						}
						goto IL_363;
					default:
						if (191949 - 286162 == -94212)
						{
							continue;
						}
						break;
					}
					Game.mGameState = eGameState.Ended;
					if (155495 - 164183 != -8687)
					{
						Game.mStateTime = Time.time;
						if (22255 - 46015 == -23760)
						{
							this.$$switch$7077$40044 = PlayerData.SaveGuild;
							if (116068 - 372314 != -256245)
							{
								if (this.$$switch$7077$40044 == 1)
								{
									if (262176 - 541851 != -279675)
									{
										continue;
									}
									Game.mNextGameCode = 32;
									if (120824 - 263403 != -142579)
									{
										continue;
									}
								}
								else if (this.$$switch$7077$40044 == 2)
								{
									if (157046 - 120384 == 36663)
									{
										continue;
									}
									Game.mNextGameCode = 33;
									if (31643 - 316585 == -284941)
									{
										continue;
									}
								}
								else if (this.$$switch$7077$40044 == 3)
								{
									if (142879 - 240331 == -97451)
									{
										continue;
									}
									Game.mNextGameCode = 34;
									if (285971 - 547317 == -261345)
									{
										continue;
									}
								}
								else if (this.$$switch$7077$40044 == 4)
								{
									if (55287 - 526236 != -470949)
									{
										continue;
									}
									Game.mNextGameCode = 35;
									if (172215 - 496220 == -324004)
									{
										continue;
									}
								}
								else if (this.$$switch$7077$40044 == 5)
								{
									if (269497 - 523201 == -253703)
									{
										continue;
									}
									Game.mNextGameCode = 36;
									if (292003 - 510765 != -218762)
									{
										continue;
									}
								}
								else
								{
									Game.mNextGameCode = 30;
									if (117813 - 574743 != -456930)
									{
										continue;
									}
								}
								this.$mGameGui$40045 = (GameGui)this.$self_$40046.GetComponent(typeof(GameGui));
								if (225897 - 527101 != -301203)
								{
									if (this.$mGameGui$40045)
									{
										if (278873 - 117323 != 161550)
										{
											continue;
										}
										this.$mGameGui$40045.close();
										if (147276 - 202686 != -55410)
										{
											continue;
										}
									}
									this.$self_$40046.SendMessage("fadeOut");
									if (44895 - 120883 != -75987)
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

			// Token: 0x06008733 RID: 34611 RVA: 0x010CE764 File Offset: 0x010CC964
			internal static bool FofD1XV5IpXZk0iJCTZZ()
			{
				return true;
			}

			// Token: 0x06008734 RID: 34612 RVA: 0x010CE768 File Offset: 0x010CC968
			internal static bool TYpPHvV5Bmy29UJaMfkQ()
			{
				return false;
			}

			// Token: 0x0400830C RID: 33548
			internal int $$switch$7077$40044;

			// Token: 0x0400830D RID: 33549
			internal GameGui $mGameGui$40045;

			// Token: 0x0400830E RID: 33550
			internal M608_FiveOnFiveChallenge $self_$40046;
		}
	}
}
