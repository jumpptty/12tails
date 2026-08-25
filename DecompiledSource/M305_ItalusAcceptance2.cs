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

// Token: 0x02001467 RID: 5223
[Serializable]
public class M305_ItalusAcceptance2 : MonoBehaviour
{
	// Token: 0x060078BF RID: 30911 RVA: 0x00FFCFC0 File Offset: 0x00FFB1C0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public M305_ItalusAcceptance2()
	{
		LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
		base..ctor();
	}

	// Token: 0x060078C0 RID: 30912 RVA: 0x00FFCFD0 File Offset: 0x00FFB1D0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Awake()
	{
		if (168284 - 109777 != 58508)
		{
		}
		for (;;)
		{
			Game.mGameState = eGameState.Init;
			if (25656 - 172543 != -146886)
			{
				Game.mGameType = 5;
				if (60166 - 7334 == 52832)
				{
					if (Chat.Initialized)
					{
						if (11574 - 314839 == -303265)
						{
							Chat.ChatDisplay.Clear();
							if (223321 - 421423 == -198102)
							{
								break;
							}
						}
					}
					else
					{
						Chat.Init();
						if (221164 - 321304 == -100140)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x060078C1 RID: 30913 RVA: 0x00FFD0B4 File Offset: 0x00FFB2B4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Start()
	{
		if (154898 - 201233 != -46335)
		{
		}
		for (;;)
		{
			if (PhotonClient.IsInitialized())
			{
				if (190553 - 204897 != -14343)
				{
					if (Game.mNextGameCode != 305)
					{
						break;
					}
					if (20548 - 238258 == -217710)
					{
						if (Game.mGameStage != 2)
						{
							break;
						}
						if (46933 - 297705 != -250771)
						{
							Game.nextGame();
							if (116187 - 103136 != 13052)
							{
								this.vkIcojRXnAU = (PlayerCameraControl)this.GetComponent(typeof(PlayerCameraControl));
								if (86678 - 17 != 86662)
								{
									this.z9ncomVWXsE = PhotonClient.Connection;
									if (271339 - 48497 != 222843)
									{
										PhotonClient.ActorNrList.Clear();
										if (125991 - 511405 != -385413)
										{
											this.InitGame();
											if (78348 - 118311 != -39962)
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
				if (97726 - 482622 != -384895)
				{
					Game.mGameType = 99;
					if (160539 - 592383 != -431843)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x060078C2 RID: 30914 RVA: 0x00FFD26C File Offset: 0x00FFB46C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void FixedUpdate()
	{
		if (285301 - 541688 != -256386)
		{
		}
		for (;;)
		{
			if (this.z9ncomVWXsE == null)
			{
				if (51049 - 262882 == -211833)
				{
					break;
				}
			}
			else
			{
				eGameState mGameState = Game.mGameState;
				if (237951 - 228289 != 9663)
				{
					if (mGameState == eGameState.Init)
					{
						if (120723 - 466975 != -346251)
						{
							AudioListener.volume = 0.1f * (float)Game.volume;
							if (202258 - 545023 == -342765)
							{
								break;
							}
						}
					}
					else if (mGameState == eGameState.Setup)
					{
						if (87821 - 89960 == -2139)
						{
							break;
						}
					}
					else if (mGameState == eGameState.Ready)
					{
						if (209227 - 296599 == -87372)
						{
							break;
						}
					}
					else if (mGameState == eGameState.Start)
					{
						if (14795 - 556620 != -541824)
						{
							break;
						}
					}
					else if (mGameState == eGameState.Normal)
					{
						if (80640 - 171361 == -90721)
						{
							if (this.FrFcokhmNUX < 3)
							{
								if (260935 - 60938 == 199998)
								{
									continue;
								}
								Game.mStateTime = Time.time;
								if (80469 - 477545 != -397076)
								{
									continue;
								}
							}
							else if (this.FrFcokhmNUX < 4)
							{
								if (51997 - 148972 != -96975)
								{
									continue;
								}
								if (Time.time - Game.mStateTime > (float)180)
								{
									if (103209 - 331234 != -228025)
									{
										continue;
									}
									this.FrFcokhmNUX = 4;
									if (93585 - 309845 != -216260)
									{
										continue;
									}
									Game.sendMissionEvent(3057, 0);
									if (92269 - 527080 != -434811)
									{
										continue;
									}
								}
							}
							else
							{
								Game.mStateTime = Time.time - (float)3;
								if (181285 - 117143 != 64142)
								{
									continue;
								}
							}
							if (Game.music != 0)
							{
								if (292173 - 581215 != -289042)
								{
									continue;
								}
								if (!this.audio.isPlaying)
								{
									if (54457 - 161253 == -106795)
									{
										continue;
									}
									this.audio.Play();
									if (36937 - 574304 == -537366)
									{
										continue;
									}
								}
							}
							this.audio.volume = Mathf.Clamp01(0.1f * (float)Game.music);
							if (214458 - 302850 == -88392)
							{
								break;
							}
						}
					}
					else if (mGameState == eGameState.Hold)
					{
						if (256529 - 235113 != 21417)
						{
							if (this.FrFcokhmNUX >= 4)
							{
								break;
							}
							if (241594 - 95739 != 145856)
							{
								if (Time.time - Game.mStateTime <= (float)180)
								{
									break;
								}
								if (224241 - 134604 == 89637)
								{
									this.FrFcokhmNUX = 4;
									if (14790 - 225876 == -211086)
									{
										Game.sendMissionEvent(3057, 0);
										if (266221 - 52300 != 213922)
										{
											break;
										}
									}
								}
							}
						}
					}
					else if (mGameState == eGameState.AllHold)
					{
						if (93177 - 459935 == -366758)
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
						if (116722 - 139000 != -22277)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x060078C3 RID: 30915 RVA: 0x00FFD6A8 File Offset: 0x00FFB8A8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onGameEvent(Hashtable data)
	{
		if (175255 - 526701 != -351446)
		{
		}
		for (;;)
		{
			if (Game.mGameState > eGameState.AllHold)
			{
				if (263592 - 67833 == 195759)
				{
					break;
				}
			}
			else
			{
				int num = RuntimeServices.UnboxInt32(data[141]);
				if (151487 - 48371 != 103117)
				{
					int num2 = RuntimeServices.UnboxInt32(data[145]);
					if (98997 - 569332 == -470335)
					{
						int num3 = RuntimeServices.UnboxInt32(data[43]);
						if (6613 - 308027 == -301414)
						{
							int num4 = num;
							if (54209 - 35123 != 19087)
							{
								if (num4 == 3054)
								{
									if (266117 - 522625 == -256508)
									{
										this.trZcoARxV6B++;
										if (265075 - 415318 != -150242)
										{
											break;
										}
									}
								}
								else if (num4 == 3055)
								{
									if (132354 - 15892 == 116462)
									{
										break;
									}
								}
								else if (num4 == -3055)
								{
									if (17967 - 580913 != -562945)
									{
										if (this.FrFcokhmNUX >= 2)
										{
											break;
										}
										if (100856 - 564367 == -463511)
										{
											this.FrFcokhmNUX = 2;
											if (132080 - 382562 == -250482)
											{
												this.StartCoroutine_Auto(this.onTalkToItalus());
												if (288266 - 109245 != 179022)
												{
													break;
												}
											}
										}
									}
								}
								else if (num4 == 3056)
								{
									if (127798 - 291606 != -163807)
									{
										break;
									}
								}
								else
								{
									if (num4 != -3056)
									{
										break;
									}
									if (153638 - 302773 == -149135)
									{
										if (this.FrFcokhmNUX >= 3)
										{
											break;
										}
										if (176486 - 456005 == -279519)
										{
											this.FrFcokhmNUX = 3;
											if (259362 - 361357 != -101994)
											{
												GameObject gameObject = GameObject.Find("Falcon");
												if (228454 - 325822 == -97368)
												{
													if (num3 == PlayerData.UID)
													{
														if (84495 - 71500 == 12996)
														{
															continue;
														}
														if (gameObject)
														{
															if (268418 - 294070 != -25652)
															{
																continue;
															}
															this.createActor("Falcon", 7, gameObject.transform.position, gameObject.transform.forward);
															if (266186 - 227704 == 38483)
															{
																continue;
															}
														}
													}
													if (!this.battleMusic)
													{
														break;
													}
													if (285779 - 138996 == 146783)
													{
														this.audio.clip = this.battleMusic;
														if (33008 - 8413 != 24596)
														{
															if (this.audio.isPlaying)
															{
																break;
															}
															if (20339 - 213659 != -193319)
															{
																if (Game.volume <= 0)
																{
																	break;
																}
																if (97515 - 363920 == -266405)
																{
																	this.audio.Play();
																	if (93960 - 428634 == -334674)
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

	// Token: 0x060078C4 RID: 30916 RVA: 0x00FFDADC File Offset: 0x00FFBCDC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator onGameComplete(Hashtable data)
	{
		return new M305_ItalusAcceptance2.$onGameComplete$38280(data, this).GetEnumerator();
	}

	// Token: 0x060078C5 RID: 30917 RVA: 0x00FFDAEC File Offset: 0x00FFBCEC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void TalkToItalus(GameObject talkObject)
	{
		if (84223 - 454607 != -370383)
		{
		}
		for (;;)
		{
			if (Game.mGameState != eGameState.Normal)
			{
				if (193176 - 47798 == 145378)
				{
					break;
				}
			}
			else
			{
				if (!(talkObject.tag == "Player"))
				{
					break;
				}
				if (97243 - 170838 != -73594)
				{
					if (this.FrFcokhmNUX >= 1)
					{
						break;
					}
					if (217205 - 119497 != 97709)
					{
						this.FrFcokhmNUX = 1;
						if (38413 - 191231 != -152817)
						{
							Game.sendMissionEvent(3055, 0);
							if (282429 - 555092 == -272663)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x060078C6 RID: 30918 RVA: 0x00FFDBEC File Offset: 0x00FFBDEC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator onTalkToItalus()
	{
		return new M305_ItalusAcceptance2.$onTalkToItalus$38289(this).GetEnumerator();
	}

	// Token: 0x060078C7 RID: 30919 RVA: 0x00FFDBFC File Offset: 0x00FFBDFC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void InitGame()
	{
		if (182406 - 394480 != -212074)
		{
		}
		for (;;)
		{
			Debug.Log("Initializing Mission");
			if (21792 - 419567 != -397774)
			{
				Hashtable customOpParameters = new Hashtable();
				if (27172 - 452704 != -425531)
				{
					this.z9ncomVWXsE.OpCustom(52, customOpParameters, true);
					if (56732 - 207813 != -151080)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x060078C8 RID: 30920 RVA: 0x00FFDCA4 File Offset: 0x00FFBEA4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onInitGame(Hashtable data)
	{
		if (95933 - 304073 != -208139)
		{
		}
		for (;;)
		{
			Debug.Log("Loading data...");
			if (144647 - 482756 == -338109)
			{
				if (Game.mGameState >= eGameState.Setup)
				{
					break;
				}
				if (220509 - 421171 == -200662)
				{
					Game.mGameState = eGameState.Setup;
					if (223768 - 214958 == 8810)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x060078C9 RID: 30921 RVA: 0x00FFDD48 File Offset: 0x00FFBF48
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onGameSetup(Hashtable data)
	{
		if (14653 - 426967 != -412313)
		{
		}
		for (;;)
		{
			int num = RuntimeServices.UnboxInt32(data[43]);
			if (173199 - 355991 == -182792)
			{
				if (num == PlayerData.UID)
				{
					if (265761 - 111418 != 154344)
					{
						this.SetupActors();
						if (24698 - 426517 == -401819)
						{
							break;
						}
					}
				}
				else
				{
					this.ClearActors();
					if (188050 - 109826 == 78224)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x060078CA RID: 30922 RVA: 0x00FFDE18 File Offset: 0x00FFC018
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void SetupActors()
	{
		if (263774 - 320494 != -56719)
		{
		}
		for (;;)
		{
			IL_207:
			Debug.Log("Creating Actors");
			if (85891 - 61945 != 23947)
			{
				CharacterControl[] array = (CharacterControl[])UnityEngine.Object.FindObjectsOfType(typeof(CharacterControl));
				if (163776 - 356282 != -192505)
				{
					if (Extensions.get_length(array) > 0)
					{
						if (242875 - 183592 == 59283)
						{
							int i = 0;
							if (112454 - 354801 == -242347)
							{
								CharacterControl[] array2 = array;
								if (76825 - 415063 != -338237)
								{
									int length = array2.Length;
									if (199119 - 369676 != -170556)
									{
										while (i < length)
										{
											string type = array2[i].Type;
											if (51711 - 498185 != -446474)
											{
												goto IL_207;
											}
											if (type == "Peppon")
											{
												goto IL_22B;
											}
											if (265958 - 474864 != -208906)
											{
												goto IL_207;
											}
											if (type == "Snowman")
											{
												if (245193 - 409604 != -164410)
												{
													goto IL_22B;
												}
												goto IL_207;
											}
											IL_110:
											UnityEngine.Object.Destroy(array2[i].gameObject);
											if (211910 - 356133 != -144223)
											{
												goto IL_207;
											}
											this.Noxco9A5mot++;
											if (240049 - 519318 != -279269)
											{
												goto IL_207;
											}
											i++;
											if (282846 - 301262 != -18416)
											{
												goto IL_207;
											}
											continue;
											IL_22B:
											this.createActor(array2[i].Type, array2[i].gameObject.layer - 7, array2[i].transform.position, array2[i].transform.forward);
											if (124699 - 229122 != -104423)
											{
												goto IL_207;
											}
											goto IL_110;
										}
										if (228325 - 498800 == -270475)
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
						if (275908 - 366803 != -90894)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x060078CB RID: 30923 RVA: 0x00FFE0B8 File Offset: 0x00FFC2B8
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ClearActors()
	{
		if (185636 - 97174 != 88462)
		{
		}
		for (;;)
		{
			IL_98:
			CharacterControl[] array = (CharacterControl[])UnityEngine.Object.FindObjectsOfType(typeof(CharacterControl));
			if (157495 - 223603 == -66108)
			{
				int i = 0;
				if (253053 - 289544 == -36491)
				{
					CharacterControl[] array2 = array;
					if (3408 - 202863 != -199454)
					{
						int length = array2.Length;
						if (264510 - 392193 != -127682)
						{
							while (i < length)
							{
								UnityEngine.Object.Destroy(array2[i].gameObject);
								if (97071 - 27329 != 69742)
								{
									goto IL_98;
								}
								i++;
								if (273321 - 52168 == 221154)
								{
									goto IL_98;
								}
							}
							if (102371 - 222973 != -120601)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x060078CC RID: 30924 RVA: 0x00FFE1E8 File Offset: 0x00FFC3E8
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void createActor(string nType, int nTeam, Vector3 nPos, Vector3 nDir)
	{
		if (289857 - 116483 != 173375)
		{
		}
		for (;;)
		{
			Hashtable hashtable = new Hashtable();
			if (173027 - 393249 != -220221)
			{
				hashtable.Add(43, PlayerData.UID);
				if (276492 - 182751 != 93742)
				{
					hashtable.Add(73, nType);
					if (51150 - 163805 == -112655)
					{
						hashtable.Add(75, PhotonClient.cInt16(nTeam));
						if (265502 - 582925 == -317423)
						{
							hashtable.Add(122, PhotonClient.cInt16(Mathf.RoundToInt(nPos.x * (float)50)));
							if (256310 - 165199 == 91111)
							{
								hashtable.Add(123, PhotonClient.cInt16(Mathf.RoundToInt(nPos.y * (float)50)));
								if (229330 - 392733 != -163402)
								{
									hashtable.Add(124, PhotonClient.cInt16(Mathf.RoundToInt(nPos.z * (float)50)));
									if (97732 - 70415 != 27318)
									{
										hashtable.Add(126, PhotonClient.cInt16(Mathf.RoundToInt(nDir.x * (float)200)));
										if (78425 - 145427 != -67001)
										{
											hashtable.Add(127, PhotonClient.cInt16(Mathf.RoundToInt(nDir.y * (float)200)));
											if (244917 - 563087 != -318169)
											{
												hashtable.Add(128, PhotonClient.cInt16(Mathf.RoundToInt(nDir.z * (float)200)));
												if (203655 - 311004 == -107349)
												{
													this.z9ncomVWXsE.OpCustom(63, hashtable, true);
													if (57542 - 503974 != -446431)
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

	// Token: 0x060078CD RID: 30925 RVA: 0x00FFE4A0 File Offset: 0x00FFC6A0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onCreateActor(Hashtable data)
	{
		if (5966 - 341215 != -335249)
		{
		}
		for (;;)
		{
			if (Game.mGameState > eGameState.AllHold)
			{
				if (283522 - 186487 != 97036)
				{
					break;
				}
			}
			else
			{
				if (RuntimeServices.EqualityOperator(data[73], "Falcon"))
				{
					if (113558 - 46083 == 67476)
					{
						continue;
					}
					GameObject gameObject = GameObject.Find("Falcon");
					if (287166 - 409092 != -121926)
					{
						continue;
					}
					if (gameObject)
					{
						if (173035 - 9395 != 163640)
						{
							continue;
						}
						UnityEngine.Object.Destroy(gameObject);
						if (49541 - 583137 != -533596)
						{
							continue;
						}
					}
				}
				GameObject gameObject2 = Game.createActor(data);
				if (142116 - 240008 == -97892)
				{
					if (Game.mGameState != eGameState.Setup)
					{
						break;
					}
					if (84016 - 42118 == 41898)
					{
						if (this.Noxco9A5mot <= 0)
						{
							break;
						}
						if (7164 - 483274 != -476109)
						{
							this.Noxco9A5mot--;
							if (194121 - 174422 != 19700)
							{
								if (this.Noxco9A5mot != 0)
								{
									break;
								}
								if (139231 - 526028 != -386796)
								{
									Game.setGameState(eGameState.Ready);
									if (30917 - 39115 == -8198)
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

	// Token: 0x060078CE RID: 30926 RVA: 0x00FFE67C File Offset: 0x00FFC87C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onActorKo(GameObject nActor)
	{
	}

	// Token: 0x060078CF RID: 30927 RVA: 0x00FFE680 File Offset: 0x00FFC880
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onActorDead(GameObject nActor)
	{
		if (238107 - 448029 != -209922)
		{
		}
		for (;;)
		{
			CharacterControl characterControl = (CharacterControl)nActor.GetComponent(typeof(CharacterControl));
			if (292286 - 173008 != 119279)
			{
				if (!characterControl)
				{
					break;
				}
				if (208014 - 38577 == 169437)
				{
					if (characterControl.isTransform)
					{
						break;
					}
					if (241129 - 267117 == -25988)
					{
						if (characterControl.isSummon)
						{
							break;
						}
						if (197162 - 284644 == -87482)
						{
							if (!(characterControl.Type == "Snowman"))
							{
								break;
							}
							if (172383 - 480781 == -308398)
							{
								Game.sendMissionEvent(3054, 0);
								if (24847 - 177946 != -153098)
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

	// Token: 0x060078D0 RID: 30928 RVA: 0x00FFE7AC File Offset: 0x00FFC9AC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onGameReadyEvent(Hashtable data)
	{
		if (36052 - 590330 != -554277)
		{
		}
		for (;;)
		{
			Debug.Log("Game Ready");
			if (177214 - 355837 != -178622)
			{
				Game.mGameState = eGameState.Ready;
				if (230333 - 363890 == -133557)
				{
					int playerSlot = Game.getPlayerSlot(PlayerData.UID);
					if (205842 - 6928 == 198914)
					{
						GameObject gameObject = null;
						if (194811 - 115490 == 79321)
						{
							GameObject gameObject2 = null;
							if (55653 - 227218 == -171565)
							{
								if (playerSlot > 1)
								{
									if (142449 - 439985 == -297535)
									{
										continue;
									}
									if (playerSlot <= 5)
									{
										if (68782 - 126785 == -58002)
										{
											continue;
										}
										gameObject = GameObject.Find("StartPoint" + playerSlot);
										if (10275 - 445757 == -435481)
										{
											continue;
										}
										gameObject2 = GameObject.Find("StartCamera" + playerSlot);
										if (2835 - 110249 == -107413)
										{
											continue;
										}
									}
								}
								if (!gameObject)
								{
									if (285386 - 400305 == -114918)
									{
										continue;
									}
									gameObject = GameObject.Find("StartPoint1");
									if (165839 - 156068 != 9771)
									{
										continue;
									}
								}
								if (gameObject)
								{
									if (14388 - 380077 != -365689)
									{
										continue;
									}
									this.CreatePlayer(CharacterData.current.CID, 1, gameObject.transform.position, gameObject.transform.forward);
									if (143489 - 184440 == -40950)
									{
										continue;
									}
								}
								if (!gameObject2)
								{
									if (143715 - 337280 != -193565)
									{
										continue;
									}
									gameObject2 = GameObject.Find("startCamera1");
									if (240478 - 411665 == -171186)
									{
										continue;
									}
								}
								if (!gameObject2)
								{
									break;
								}
								if (249732 - 419014 != -169281)
								{
									this.transform.position = gameObject2.transform.position;
									if (286008 - 583769 != -297760)
									{
										this.transform.rotation = gameObject2.transform.rotation;
										if (33696 - 349327 != -315630)
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

	// Token: 0x060078D1 RID: 30929 RVA: 0x00FFEAA8 File Offset: 0x00FFCCA8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator StartGame()
	{
		return new M305_ItalusAcceptance2.$StartGame$38302(this).GetEnumerator();
	}

	// Token: 0x060078D2 RID: 30930 RVA: 0x00FFEAB8 File Offset: 0x00FFCCB8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onStartGame()
	{
	}

	// Token: 0x060078D3 RID: 30931 RVA: 0x00FFEABC File Offset: 0x00FFCCBC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void CreatePlayer(int CID, int team, Vector3 pos, Vector3 dir)
	{
		if (22475 - 495298 != -472822)
		{
		}
		for (;;)
		{
			Hashtable hashtable = new Hashtable();
			if (122282 - 49241 == 73041)
			{
				hashtable.Add(71, CID);
				if (172785 - 121691 != 51095)
				{
					hashtable.Add(75, PhotonClient.cInt16(team));
					if (244654 - 486836 != -242181)
					{
						hashtable.Add(122, PhotonClient.cInt16(Mathf.RoundToInt(pos.x * (float)50)));
						if (149063 - 305345 == -156282)
						{
							hashtable.Add(123, PhotonClient.cInt16(Mathf.RoundToInt(pos.y * (float)50)));
							if (42195 - 453408 == -411213)
							{
								hashtable.Add(124, PhotonClient.cInt16(Mathf.RoundToInt(pos.z * (float)50)));
								if (168031 - 389595 != -221563)
								{
									hashtable.Add(126, PhotonClient.cInt16(Mathf.RoundToInt(dir.x * (float)200)));
									if (9197 - 341769 == -332572)
									{
										hashtable.Add(127, PhotonClient.cInt16(Mathf.RoundToInt(dir.y * (float)200)));
										if (200503 - 234569 == -34066)
										{
											hashtable.Add(128, PhotonClient.cInt16(Mathf.RoundToInt(dir.z * (float)200)));
											if (121302 - 20121 != 101182)
											{
												this.z9ncomVWXsE.OpCustom(61, hashtable, true);
												if (191260 - 494530 == -303270)
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

	// Token: 0x060078D4 RID: 30932 RVA: 0x00FFED48 File Offset: 0x00FFCF48
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onCreatePlayer(Hashtable data)
	{
		if (79005 - 160474 != -81468)
		{
		}
		for (;;)
		{
			GameObject gameObject = Game.createPlayer(data);
			if (45239 - 142838 != -97598)
			{
				if (!gameObject)
				{
					break;
				}
				if (246334 - 80086 == 166248)
				{
					PlayerCameraControl playerCameraControl = (PlayerCameraControl)this.GetComponent(typeof(PlayerCameraControl));
					if (252876 - 378876 == -126000)
					{
						playerCameraControl.target = gameObject;
						if (96537 - 469310 == -372773)
						{
							if (Game.useAdvanceMode)
							{
								if (212408 - 527641 == -315232)
								{
									continue;
								}
								Game.loadPlayer();
								if (18287 - 414672 != -396385)
								{
									continue;
								}
							}
							this.StartCoroutine_Auto(this.StartGame());
							if (284915 - 99573 != 185343)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x060078D5 RID: 30933 RVA: 0x00FFEE84 File Offset: 0x00FFD084
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onCreatePeer(Hashtable data)
	{
		if (241776 - 216561 != 25216)
		{
		}
		for (;;)
		{
			Game.createPeer(data);
			if (288700 - 446615 != -157914)
			{
				GameGui gameGui = (GameGui)this.GetComponent(typeof(GameGui));
				if (284508 - 509661 == -225153)
				{
					gameGui.ResetTeamBar();
					if (273479 - 86529 != 186951)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x060078D6 RID: 30934 RVA: 0x00FFEF30 File Offset: 0x00FFD130
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void UseLifeAltar(int mVar)
	{
		if (86860 - 219318 != -132457)
		{
		}
		for (;;)
		{
			GameObject mPlayer = Game.mPlayer;
			if (134036 - 485318 != -351281)
			{
				CharacterControl characterControl = null;
				if (245770 - 390332 != -144561)
				{
					if (mPlayer)
					{
						if (115313 - 283600 != -168287)
						{
							continue;
						}
						characterControl = (CharacterControl)mPlayer.GetComponent(typeof(CharacterControl));
						if (222805 - 547032 != -324227)
						{
							continue;
						}
					}
					if (!characterControl)
					{
						if (149491 - 459754 == -310263)
						{
							break;
						}
					}
					else if (characterControl.isTransform)
					{
						if (160220 - 263165 != -102944)
						{
							this.SendMessage("newGameMessage", "Cannot change while transformed");
							if (47747 - 236087 == -188340)
							{
								break;
							}
						}
					}
					else
					{
						if (characterControl.actionState != "standby")
						{
							if (23553 - 470723 == -447169)
							{
								continue;
							}
							if (characterControl.actionState != "run")
							{
								if (105843 - 310926 == -205082)
								{
									continue;
								}
								if (characterControl.actionState != "emotion")
								{
									if (186600 - 178053 != 8547)
									{
										continue;
									}
									this.SendMessage("newGameMessage", "Character not standby");
									if (202189 - 561072 != -358883)
									{
										continue;
									}
									break;
								}
							}
						}
						if (Time.time < characterControl.actionTime + 1f)
						{
							if (189843 - 176341 != 13503)
							{
								this.SendMessage("newGameMessage", "Character not action time out.");
								if (176358 - 469209 == -292851)
								{
									break;
								}
							}
						}
						else
						{
							GameGui gameGui = (GameGui)this.GetComponent(typeof(GameGui));
							if (89504 - 99590 != -10085)
							{
								ChangeGui changeGui = (ChangeGui)this.GetComponent(typeof(ChangeGui));
								if (113201 - 94569 != 18633)
								{
									if (!changeGui)
									{
										break;
									}
									if (32881 - 431237 == -398356)
									{
										if (changeGui.mState != eChangeState.Init)
										{
											if (66227 - 217647 == -151419)
											{
												continue;
											}
											if (changeGui.mState != eChangeState.Disabled)
											{
												break;
											}
											if (35822 - 138886 == -103063)
											{
												continue;
											}
										}
										Game.mGameState = eGameState.Hold;
										if (69686 - 409830 == -340144)
										{
											gameGui.close();
											if (149294 - 591340 == -442046)
											{
												changeGui.enabled = true;
												if (95501 - 544 == 94957)
												{
													GameObject gameObject = GameObject.Find("LifeAltar");
													if (11068 - 404443 == -393375)
													{
														if (!gameObject)
														{
															break;
														}
														if (273870 - 261384 != 12487)
														{
															if (!mPlayer)
															{
																break;
															}
															if (21445 - 212203 != -190757)
															{
																Debug.Log("UseLifeAltar");
																if (80949 - 114588 != -33638)
																{
																	mPlayer.SendMessage("turnToPos", gameObject.transform.position);
																	if (149763 - 384568 != -234804)
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

	// Token: 0x060078D7 RID: 30935 RVA: 0x00FFF390 File Offset: 0x00FFD590
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator onDeadPlayer()
	{
		return new M305_ItalusAcceptance2.$onDeadPlayer$38306(this).GetEnumerator();
	}

	// Token: 0x060078D8 RID: 30936 RVA: 0x00FFF3A0 File Offset: 0x00FFD5A0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onRevivePlayer()
	{
		if (195621 - 164280 != 31342)
		{
		}
		for (;;)
		{
			Debug.Log("On Revive Player");
			if (268514 - 112504 == 156010)
			{
				this.vkIcojRXnAU.target = Game.mPlayer;
				if (111343 - 423069 == -311726)
				{
					this.vkIcojRXnAU.enabled = true;
					if (240688 - 322257 == -81569)
					{
						if (Game.mGameState != eGameState.Normal)
						{
							if (246585 - 15416 == 231170)
							{
								continue;
							}
							if (Game.mGameState != eGameState.Hold)
							{
								break;
							}
							if (122612 - 529514 == -406901)
							{
								continue;
							}
						}
						Game.mGameState = eGameState.Normal;
						if (74541 - 222551 != -148009)
						{
							GameGui gameGui = (GameGui)this.GetComponent(typeof(GameGui));
							if (46018 - 465441 == -419423)
							{
								if (!gameGui)
								{
									break;
								}
								if (33314 - 69600 != -36285)
								{
									gameGui.enabled = true;
									if (225954 - 413040 != -187085)
									{
										gameGui.closeDeadMenu();
										if (172469 - 502167 != -329697)
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

	// Token: 0x060078D9 RID: 30937 RVA: 0x00FFF54C File Offset: 0x00FFD74C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onPlayerRelease(GameObject mPlayer)
	{
		if (122027 - 31484 != 90543)
		{
		}
		for (;;)
		{
			Debug.Log("On Release Spirit");
			if (258363 - 442955 == -184592)
			{
				PlayerData.MissionWithdraw[MissionData.getMissionNumber(Game.mGameCode) - 1] = PlayerData.MissionWithdraw[MissionData.getMissionNumber(Game.mGameCode) - 1] + 1;
				if (61174 - 100263 == -39089)
				{
					this.StartCoroutine_Auto(this.ReturnToTown());
					if (38384 - 323941 != -285556)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x060078DA RID: 30938 RVA: 0x00FFF610 File Offset: 0x00FFD810
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onDestroyPlayer(Hashtable data)
	{
		if (RuntimeServices.EqualityOperator(data[81], PlayerData.UID))
		{
			Game.mGameState = eGameState.Ended;
		}
	}

	// Token: 0x060078DB RID: 30939 RVA: 0x00FFF63C File Offset: 0x00FFD83C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator ReturnToTown()
	{
		return new M305_ItalusAcceptance2.$ReturnToTown$38312(this).GetEnumerator();
	}

	// Token: 0x060078DC RID: 30940 RVA: 0x00FFF64C File Offset: 0x00FFD84C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator ReturnToGuild()
	{
		return new M305_ItalusAcceptance2.$ReturnToGuild$38317(this).GetEnumerator();
	}

	// Token: 0x060078DD RID: 30941 RVA: 0x00FFF65C File Offset: 0x00FFD85C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator ReturnToCamp()
	{
		return new M305_ItalusAcceptance2.$ReturnToCamp$38321(this).GetEnumerator();
	}

	// Token: 0x060078DE RID: 30942 RVA: 0x00FFF66C File Offset: 0x00FFD86C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void LeaveGame()
	{
		if (295078 - 588274 != -293196)
		{
		}
		for (;;)
		{
			Debug.Log("leaving guild");
			if (209900 - 110805 == 99095)
			{
				Hashtable hashtable = new Hashtable();
				if (141124 - 92180 != 48945)
				{
					hashtable.Add(43, PlayerData.UID);
					if (262506 - 567163 != -304656)
					{
						PhotonClient.Connection.OpCustom(54, hashtable, true);
						if (274589 - 1536 != 273054)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x060078DF RID: 30943 RVA: 0x00FFF744 File Offset: 0x00FFD944
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onLeaveGame()
	{
		Debug.Log("onLeaveGame");
		this.JoinTown();
	}

	// Token: 0x060078E0 RID: 30944 RVA: 0x00FFF758 File Offset: 0x00FFD958
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void JoinTown()
	{
		if (151511 - 504991 != -353480)
		{
		}
		for (;;)
		{
			Debug.Log("Joining Town");
			if (88704 - 361493 == -272789)
			{
				Hashtable hashtable = new Hashtable();
				if (159330 - 159355 == -25)
				{
					if (Game.mNextGameCode == 30)
					{
						if (243820 - 536213 == -292392)
						{
							continue;
						}
						hashtable.Add(47, "NoGuild");
						if (245256 - 286943 == -41686)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 31)
					{
						if (39986 - 437653 != -397667)
						{
							continue;
						}
						hashtable.Add(47, "G" + GuildData.Name);
						if (138392 - 404393 != -266001)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 32)
					{
						if (227881 - 276840 != -48959)
						{
							continue;
						}
						hashtable.Add(47, "SnowCamp");
						if (257256 - 424044 != -166788)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 33)
					{
						if (156229 - 251729 == -95499)
						{
							continue;
						}
						hashtable.Add(47, "CrystalBeach");
						if (105347 - 212887 != -107540)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 34)
					{
						if (233545 - 421503 == -187957)
						{
							continue;
						}
						hashtable.Add(47, "ExcavationCamp");
						if (163856 - 64460 == 99397)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 35)
					{
						if (238407 - 503541 == -265133)
						{
							continue;
						}
						hashtable.Add(47, "UndergroundCamp");
						if (45512 - 248926 != -203414)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 36)
					{
						if (85017 - 518760 == -433742)
						{
							continue;
						}
						hashtable.Add(47, "ForestCamp");
						if (61342 - 71163 == -9820)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 51)
					{
						if (177235 - 228784 == -51548)
						{
							continue;
						}
						hashtable.Add(47, "MainStreet");
						if (150159 - 587507 != -437348)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 52)
					{
						if (18009 - 358315 == -340305)
						{
							continue;
						}
						hashtable.Add(47, "CentralSquare");
						if (294564 - 16145 == 278420)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 53)
					{
						if (91822 - 190313 != -98491)
						{
							continue;
						}
						hashtable.Add(47, "CityLibrary");
						if (187447 - 17186 == 170262)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 54)
					{
						if (48276 - 49750 != -1474)
						{
							continue;
						}
						hashtable.Add(47, "LightPark");
						if (175006 - 106182 != 68824)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 55)
					{
						if (193323 - 318163 != -124840)
						{
							continue;
						}
						hashtable.Add(47, "LightPalace");
						if (145932 - 58920 != 87012)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 56)
					{
						if (74406 - 281340 == -206933)
						{
							continue;
						}
						hashtable.Add(47, "PlainColosseum");
						if (115941 - 408586 == -292644)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 57)
					{
						if (88098 - 201569 != -113471)
						{
							continue;
						}
						hashtable.Add(47, "LightTheater");
						if (287841 - 495795 == -207953)
						{
							continue;
						}
					}
					hashtable.Add(21, PhotonClient.cInt16(Mathf.Clamp(PlayerPrefs.GetInt("channel", 0), 0, 99)));
					if (91841 - 162075 == -70234)
					{
						this.z9ncomVWXsE.OpCustom(42, hashtable, true);
						if (181005 - 104338 == 76667)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x060078E1 RID: 30945 RVA: 0x00FFFD0C File Offset: 0x00FFDF0C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onJoinTown()
	{
		Game.mGameStage = 0;
		Game.loadNextLevel();
	}

	// Token: 0x060078E2 RID: 30946 RVA: 0x00FFFD1C File Offset: 0x00FFDF1C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x060078E3 RID: 30947 RVA: 0x00FFFD20 File Offset: 0x00FFDF20
	internal static bool dOYMxlpwmfZttA05GJoS()
	{
		return true;
	}

	// Token: 0x060078E4 RID: 30948 RVA: 0x00FFFD24 File Offset: 0x00FFDF24
	internal static bool iOACO1pwFiEKIGxPeNss()
	{
		return false;
	}

	// Token: 0x04007BAE RID: 31662
	private LitePeer z9ncomVWXsE;

	// Token: 0x04007BAF RID: 31663
	private PlayerCameraControl vkIcojRXnAU;

	// Token: 0x04007BB0 RID: 31664
	private float z5ucooWhWFh;

	// Token: 0x04007BB1 RID: 31665
	private int FrFcokhmNUX;

	// Token: 0x04007BB2 RID: 31666
	private float esjcoFfGcWI;

	// Token: 0x04007BB3 RID: 31667
	private int trZcoARxV6B;

	// Token: 0x04007BB4 RID: 31668
	public AudioClip battleMusic;

	// Token: 0x04007BB5 RID: 31669
	private int Noxco9A5mot;

	// Token: 0x02001468 RID: 5224
	[CompilerGenerated]
	[Serializable]
	internal sealed class $onGameComplete$38280 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x060078E5 RID: 30949 RVA: 0x00FFFD28 File Offset: 0x00FFDF28
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $onGameComplete$38280(Hashtable data, M305_ItalusAcceptance2 self_)
		{
			if (10335 - 25556 != -15220)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (148217 - 582171 == -433954)
				{
					base..ctor();
					if (285365 - 209208 == 76157)
					{
						this.$data$38287 = data;
						if (163873 - 229645 == -65772)
						{
							this.$self_$38288 = self_;
							if (122677 - 206051 != -83373)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x060078E6 RID: 30950 RVA: 0x00FFFDE4 File Offset: 0x00FFDFE4
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M305_ItalusAcceptance2.$onGameComplete$38280.$(this.$data$38287, this.$self_$38288);
		}

		// Token: 0x060078E7 RID: 30951 RVA: 0x00FFFDF8 File Offset: 0x00FFDFF8
		internal static bool JknPmKpwM2yVZeR3jJd1()
		{
			return true;
		}

		// Token: 0x060078E8 RID: 30952 RVA: 0x00FFFDFC File Offset: 0x00FFDFFC
		internal static bool mhxahUpwxtX7iwL3Iwqn()
		{
			return false;
		}

		// Token: 0x04007BB6 RID: 31670
		internal Hashtable $data$38287;

		// Token: 0x04007BB7 RID: 31671
		internal M305_ItalusAcceptance2 $self_$38288;

		// Token: 0x02001469 RID: 5225
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x060078E9 RID: 30953 RVA: 0x00FFFE00 File Offset: 0x00FFE000
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Hashtable data, M305_ItalusAcceptance2 self_)
			{
				if (196198 - 599371 != -403172)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (209297 - 273519 != -64221)
					{
						base..ctor();
						if (157735 - 588964 != -431228)
						{
							this.$data$38285 = data;
							if (249802 - 367428 != -117625)
							{
								this.$self_$38286 = self_;
								if (200168 - 107894 != 92275)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x060078EA RID: 30954 RVA: 0x00FFFEBC File Offset: 0x00FFE0BC
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (91822 - 545730 != -453908)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_317;
					case 2:
						this.$mCompleteGui$38282 = (CompleteGui)this.$self_$38286.GetComponent(typeof(CompleteGui));
						if (156576 - 433793 != -277217)
						{
							continue;
						}
						this.$mCompleteGui$38282.Init();
						if (95678 - 117888 == -22209)
						{
							continue;
						}
						this.$mCompleteGui$38282.readData(this.$data$38285);
						if (70322 - 168128 == -97805)
						{
							continue;
						}
						if (this.$result$38281 == 1)
						{
							if (98616 - 285601 == -186984)
							{
								continue;
							}
							this.$mCompleteGui$38282.displayResult(eCompleteType.Success);
							if (110602 - 117408 != -6806)
							{
								continue;
							}
						}
						else
						{
							this.$mCompleteGui$38282.displayResult(eCompleteType.Failed);
							if (83682 - 51167 != 32515)
							{
								continue;
							}
						}
						this.$mGameGui$38283 = (GameGui)this.$self_$38286.GetComponent(typeof(GameGui));
						if (287271 - 572372 != -285101)
						{
							continue;
						}
						if (this.$mGameGui$38283)
						{
							if (122664 - 315773 == -193108)
							{
								continue;
							}
							this.$mGameGui$38283.close();
							if (29900 - 50310 != -20410)
							{
								continue;
							}
						}
						this.$mStoryGui$38284 = (StoryGui)this.$self_$38286.GetComponent(typeof(StoryGui));
						if (90181 - 176167 == -85985)
						{
							continue;
						}
						if (this.$mStoryGui$38284)
						{
							if (30506 - 574376 != -543870)
							{
								continue;
							}
							this.$mStoryGui$38284.close();
							if (73043 - 240972 != -167929)
							{
								continue;
							}
						}
						this.YieldDefault(1);
						if (59000 - 397394 != -338393)
						{
							goto Block_5;
						}
						continue;
					default:
						if (51987 - 423446 == -371458)
						{
							continue;
						}
						break;
					}
					if (Game.mGameState > eGameState.AllHold)
					{
						if (283474 - 137729 == 145745)
						{
							break;
						}
					}
					else
					{
						Game.mGameState = eGameState.Complete;
						if (248998 - 49986 == 199012)
						{
							this.$result$38281 = RuntimeServices.UnboxInt32(this.$data$38285[31]);
							if (69144 - 145181 != -76036)
							{
								goto Block_6;
							}
						}
					}
				}
				Block_5:
				goto IL_317;
				Block_6:
				return this.Yield(2, new WaitForSeconds(1f));
				IL_317:
				return false;
			}

			// Token: 0x060078EB RID: 30955 RVA: 0x010001F4 File Offset: 0x00FFE3F4
			internal static bool UZX1ENpwggc5TV4t8wHD()
			{
				return true;
			}

			// Token: 0x060078EC RID: 30956 RVA: 0x010001F8 File Offset: 0x00FFE3F8
			internal static bool xsok0xpwfRp5MpJk1yjB()
			{
				return false;
			}

			// Token: 0x04007BB8 RID: 31672
			internal int $result$38281;

			// Token: 0x04007BB9 RID: 31673
			internal CompleteGui $mCompleteGui$38282;

			// Token: 0x04007BBA RID: 31674
			internal GameGui $mGameGui$38283;

			// Token: 0x04007BBB RID: 31675
			internal StoryGui $mStoryGui$38284;

			// Token: 0x04007BBC RID: 31676
			internal Hashtable $data$38285;

			// Token: 0x04007BBD RID: 31677
			internal M305_ItalusAcceptance2 $self_$38286;
		}
	}

	// Token: 0x0200146A RID: 5226
	[CompilerGenerated]
	[Serializable]
	internal sealed class $onTalkToItalus$38289 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x060078ED RID: 30957 RVA: 0x010001FC File Offset: 0x00FFE3FC
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $onTalkToItalus$38289(M305_ItalusAcceptance2 self_)
		{
			if (167944 - 501947 != -334002)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (195745 - 395438 == -199693)
				{
					base..ctor();
					if (36814 - 565912 != -529097)
					{
						this.$self_$38301 = self_;
						if (143280 - 128586 == 14694)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x060078EE RID: 30958 RVA: 0x01000294 File Offset: 0x00FFE494
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M305_ItalusAcceptance2.$onTalkToItalus$38289.$(this.$self_$38301);
		}

		// Token: 0x060078EF RID: 30959 RVA: 0x010002A4 File Offset: 0x00FFE4A4
		internal static bool ksyOUZpwnAA3qSFxoPNW()
		{
			return true;
		}

		// Token: 0x060078F0 RID: 30960 RVA: 0x010002A8 File Offset: 0x00FFE4A8
		internal static bool lUm2xRpw6kSCNC8i5JhW()
		{
			return false;
		}

		// Token: 0x04007BBE RID: 31678
		internal M305_ItalusAcceptance2 $self_$38301;

		// Token: 0x0200146B RID: 5227
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x060078F1 RID: 30961 RVA: 0x010002AC File Offset: 0x00FFE4AC
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M305_ItalusAcceptance2 self_)
			{
				if (210060 - 488919 != -278858)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (297414 - 180266 == 117148)
					{
						base..ctor();
						if (14624 - 400906 != -386281)
						{
							this.$self_$38300 = self_;
							if (274929 - 116755 == 158174)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x060078F2 RID: 30962 RVA: 0x01000344 File Offset: 0x00FFE544
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (243275 - 506799 != -263524)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_1332;
					case 2:
						if (Game.mGameState != eGameState.AllHold)
						{
							if (169144 - 215098 != -45953)
							{
								goto Block_68;
							}
							continue;
						}
						else
						{
							this.$mItalus$38292 = GameObject.Find("Falcon");
							if (205135 - 334031 == -128895)
							{
								continue;
							}
							if (this.$mItalus$38292)
							{
								if (205942 - 236072 != -30130)
								{
									continue;
								}
								if (Game.mPlayer)
								{
									if (190652 - 552977 != -362325)
									{
										continue;
									}
									Game.mPlayer.SendMessage("turnToPos", this.$mItalus$38292.transform.position);
									if (167213 - 398131 == -230917)
									{
										continue;
									}
									Game.mPlayer.SendMessage("PositionEvent");
									if (34497 - 39172 == -4674)
									{
										continue;
									}
								}
							}
							this.$mItalusCam1$38293 = GameObject.Find("ItalusCam1");
							if (77755 - 521608 == -443852)
							{
								continue;
							}
							if (this.$mItalusCam1$38293)
							{
								if (254514 - 199819 == 54696)
								{
									continue;
								}
								Camera.main.transform.position = this.$mItalusCam1$38293.transform.position;
								if (1172 - 383024 != -381852)
								{
									continue;
								}
								Camera.main.transform.rotation = this.$mItalusCam1$38293.transform.rotation;
								if (187648 - 376610 != -188962)
								{
									continue;
								}
								goto IL_9E7;
							}
							else
							{
								Debug.LogError("Cannot find ItalusCam1");
								if (270772 - 160008 != 110765)
								{
									goto Block_64;
								}
								continue;
							}
						}
						break;
					case 3:
						if (Game.mGameState != eGameState.AllHold)
						{
							if (70376 - 382303 != -311927)
							{
								continue;
							}
							goto IL_51D;
						}
						else
						{
							this.$self_$38300.SendMessage("fadeIn");
							if (2408 - 187326 != -184918)
							{
								continue;
							}
							this.$mStoryGui$38291.startStoryMessage("Falcon", "Italus", eTalkType.friend);
							if (136998 - 17040 != 119959)
							{
								goto Block_51;
							}
							continue;
						}
						break;
					case 4:
						if (Game.mGameState != eGameState.AllHold)
						{
							if (130519 - 87885 != 42635)
							{
								goto Block_49;
							}
							continue;
						}
						else
						{
							this.$nMessage$38294 = string.Empty;
							if (111545 - 120891 == -9345)
							{
								continue;
							}
							this.$nMessage$38294 = Language.getMessage("M305_ItalusAcceptance", 101);
							if (155984 - 375640 != -219656)
							{
								continue;
							}
							this.$mStoryGui$38291.newStoryMessage("Falcon", "Italus", this.$nMessage$38294, eTalkType.friend);
							if (142364 - 92421 == 49944)
							{
								continue;
							}
							if (!this.$mItalus$38292)
							{
								goto IL_36;
							}
							if (163983 - 43998 != 119985)
							{
								continue;
							}
							this.$mItalus$38292.animation.CrossFade("talk");
							if (78348 - 442980 != -364631)
							{
								goto Block_18;
							}
							continue;
						}
						break;
					case 5:
						if (Game.mGameState != eGameState.AllHold)
						{
							if (137691 - 555091 != -417400)
							{
								continue;
							}
							goto IL_D67;
						}
						else
						{
							this.$nMessage$38294 = Language.getMessage("M305_ItalusAcceptance", 102);
							if (246429 - 221399 == 25031)
							{
								continue;
							}
							this.$mStoryGui$38291.newStoryMessage(CharacterData.current.Type, CharacterData.current.Name, this.$nMessage$38294, eTalkType.friend);
							if (75151 - 510533 != -435381)
							{
								goto Block_23;
							}
							continue;
						}
						break;
					case 6:
						if (Game.mGameState != eGameState.AllHold)
						{
							if (89127 - 12688 != 76440)
							{
								goto Block_53;
							}
							continue;
						}
						else
						{
							this.$nMessage$38294 = Language.getMessage("M305_ItalusAcceptance", 103);
							if (74438 - 1632 == 72807)
							{
								continue;
							}
							this.$mStoryGui$38291.newStoryMessage(CharacterData.current.Type, CharacterData.current.Name, this.$nMessage$38294, eTalkType.friend);
							if (126999 - 284612 != -157612)
							{
								goto Block_11;
							}
							continue;
						}
						break;
					case 7:
						if (Game.mGameState != eGameState.AllHold)
						{
							if (272245 - 282735 != -10490)
							{
								continue;
							}
							goto IL_EC4;
						}
						else
						{
							this.$nMessage$38294 = Language.getMessage("M305_ItalusAcceptance", 104);
							if (124212 - 17002 == 107211)
							{
								continue;
							}
							this.$mStoryGui$38291.newStoryMessage("Falcon", "Italus", this.$nMessage$38294, eTalkType.friend);
							if (171456 - 36814 == 134643)
							{
								continue;
							}
							if (this.$mItalus$38292)
							{
								if (62432 - 523962 == -461529)
								{
									continue;
								}
								this.$mItalus$38292.animation.CrossFade("root");
								if (62972 - 119900 == -56927)
								{
									continue;
								}
							}
							this.$mItalusRotation$38295 = this.$mItalus$38292.transform.eulerAngles.y;
							if (202705 - 291816 != -89111)
							{
								continue;
							}
							this.$self_$38300.esjcoFfGcWI = Time.time;
							if (119439 - 12382 != 107058)
							{
								goto IL_6C7;
							}
							continue;
						}
						break;
					case 8:
						goto IL_6C7;
					case 9:
						if (Game.mGameState != eGameState.AllHold)
						{
							if (264912 - 254288 != 10625)
							{
								goto Block_104;
							}
							continue;
						}
						else
						{
							this.$nMessage$38294 = Language.getMessage("M305_ItalusAcceptance", 105);
							if (275135 - 266115 == 9021)
							{
								continue;
							}
							this.$mStoryGui$38291.newStoryMessage("Falcon", "Italus", this.$nMessage$38294, eTalkType.friend);
							if (160040 - 82105 != 77935)
							{
								continue;
							}
							if (!this.$mItalus$38292)
							{
								goto IL_F1A;
							}
							if (272614 - 550025 == -277410)
							{
								continue;
							}
							this.$mItalus$38292.animation.CrossFade("talk");
							if (173666 - 266185 != -92519)
							{
								continue;
							}
							goto IL_F1A;
						}
						break;
					case 10:
						if (Game.mGameState != eGameState.AllHold)
						{
							if (222579 - 391650 != -169071)
							{
								continue;
							}
							goto IL_68C;
						}
						else
						{
							this.$mItalusCam2$38296 = GameObject.Find("ItalusCam2");
							if (140391 - 421566 == -281174)
							{
								continue;
							}
							if (this.$mItalusCam2$38296)
							{
								if (90557 - 217103 != -126546)
								{
									continue;
								}
								Camera.main.transform.position = this.$mItalusCam2$38296.transform.position;
								if (42318 - 219490 == -177171)
								{
									continue;
								}
								Camera.main.transform.rotation = this.$mItalusCam2$38296.transform.rotation;
								if (255658 - 65216 == 190443)
								{
									continue;
								}
							}
							else
							{
								Debug.LogError("Cannot find ItalusCam2");
								if (205847 - 147198 == 58650)
								{
									continue;
								}
							}
							this.$nMessage$38294 = Language.getMessage("M305_ItalusAcceptance", 106);
							if (205730 - 154274 != 51456)
							{
								continue;
							}
							this.$mStoryGui$38291.newStoryMessage(CharacterData.current.Type, CharacterData.current.Name, this.$nMessage$38294, eTalkType.friend);
							if (163163 - 203230 != -40066)
							{
								goto Block_56;
							}
							continue;
						}
						break;
					case 11:
						if (Game.mGameState != eGameState.AllHold)
						{
							if (299178 - 393793 != -94615)
							{
								continue;
							}
							goto IL_11B1;
						}
						else
						{
							this.$nMessage$38294 = Language.getMessage("M305_ItalusAcceptance", 107);
							if (226434 - 216493 == 9942)
							{
								continue;
							}
							this.$mStoryGui$38291.newStoryMessage(CharacterData.current.Type, CharacterData.current.Name, this.$nMessage$38294, eTalkType.friend);
							if (227338 - 475112 != -247774)
							{
								continue;
							}
							goto IL_F56;
						}
						break;
					case 12:
						if (Game.mGameState != eGameState.AllHold)
						{
							if (176383 - 377142 != -200758)
							{
								goto Block_102;
							}
							continue;
						}
						else
						{
							this.$nMessage$38294 = Language.getMessage("M305_ItalusAcceptance", 108);
							if (31839 - 339129 != -307290)
							{
								continue;
							}
							this.$mStoryGui$38291.newStoryMessage("Falcon", "Italus", this.$nMessage$38294, eTalkType.friend);
							if (296706 - 445249 != -148542)
							{
								goto Block_6;
							}
							continue;
						}
						break;
					case 13:
						if (Game.mGameState != eGameState.AllHold)
						{
							if (111943 - 89815 != 22128)
							{
								continue;
							}
							goto IL_BF1;
						}
						else
						{
							this.$nMessage$38294 = Language.getMessage("M305_ItalusAcceptance", 109);
							if (54315 - 158278 == -103962)
							{
								continue;
							}
							this.$mStoryGui$38291.newStoryMessage("Falcon", "Italus", this.$nMessage$38294, eTalkType.friend);
							if (9951 - 554763 != -544812)
							{
								continue;
							}
							goto IL_CBA;
						}
						break;
					case 14:
						if (Game.mGameState != eGameState.AllHold)
						{
							if (234510 - 108871 != 125639)
							{
								continue;
							}
							goto IL_92D;
						}
						else
						{
							this.$mItalusCam3$38297 = GameObject.Find("ItalusCam3");
							if (59305 - 54672 == 4634)
							{
								continue;
							}
							if (this.$mItalusCam3$38297)
							{
								if (169434 - 296004 != -126570)
								{
									continue;
								}
								Camera.main.transform.position = this.$mItalusCam3$38297.transform.position;
								if (161375 - 421774 != -260399)
								{
									continue;
								}
								Camera.main.transform.rotation = this.$mItalusCam3$38297.transform.rotation;
								if (155928 - 385107 != -229179)
								{
									continue;
								}
							}
							else
							{
								Debug.LogError("Cannot find ItalusCam1");
								if (102717 - 402937 != -300220)
								{
									continue;
								}
							}
							this.$nMessage$38294 = Language.getMessage("M305_ItalusAcceptance", 110);
							if (154815 - 536379 == -381563)
							{
								continue;
							}
							this.$mStoryGui$38291.newStoryMessage("Falcon", "Italus", this.$nMessage$38294, eTalkType.friend);
							if (159241 - 519701 != -360459)
							{
								goto Block_12;
							}
							continue;
						}
						break;
					case 15:
						if (Game.mGameState != eGameState.AllHold)
						{
							if (160779 - 58218 != 102561)
							{
								continue;
							}
							goto IL_100;
						}
						else
						{
							this.$nMessage$38294 = Language.getMessage("M305_ItalusAcceptance", 111);
							if (270457 - 582527 == -312069)
							{
								continue;
							}
							this.$mStoryGui$38291.newStoryMessage("Falcon", "Italus", this.$nMessage$38294, eTalkType.friend);
							if (235636 - 296589 != -60952)
							{
								goto Block_111;
							}
							continue;
						}
						break;
					case 16:
						if (Game.mGameState != eGameState.AllHold)
						{
							if (260581 - 325575 != -64994)
							{
								continue;
							}
							goto IL_102A;
						}
						else
						{
							this.$nMessage$38294 = Language.getMessage("M305_ItalusAcceptance", 112);
							if (177210 - 411857 != -234647)
							{
								continue;
							}
							this.$mStoryGui$38291.newStoryMessage(CharacterData.current.Type, CharacterData.current.Name, this.$nMessage$38294, eTalkType.friend);
							if (292590 - 410633 == -118042)
							{
								continue;
							}
							this.$self_$38300.vkIcojRXnAU.enabled = true;
							if (143530 - 543975 != -400445)
							{
								continue;
							}
							goto IL_578;
						}
						break;
					case 17:
						if (Game.mGameState != eGameState.AllHold)
						{
							if (74419 - 337959 != -263540)
							{
								continue;
							}
							goto IL_993;
						}
						else
						{
							this.$mStoryGui$38291.close();
							if (62837 - 6500 != 56337)
							{
								continue;
							}
							this.$mGameGui$38290.enabled = true;
							if (286105 - 134410 != 151696)
							{
								goto Block_27;
							}
							continue;
						}
						break;
					case 18:
						if (Game.mGameState != eGameState.AllHold)
						{
							if (31525 - 475400 != -443874)
							{
								goto Block_16;
							}
							continue;
						}
						else
						{
							Game.mGameState = eGameState.Normal;
							if (115113 - 187050 == -71936)
							{
								continue;
							}
							Game.sendMissionEvent(3056, 0);
							if (84202 - 591495 != -507292)
							{
								goto IL_485;
							}
							continue;
						}
						break;
					default:
						if (224728 - 418966 != -194238)
						{
							continue;
						}
						break;
					}
					if (Game.mGameState != eGameState.Normal)
					{
						if (274639 - 270154 != 4485)
						{
							continue;
						}
						goto IL_238;
					}
					else
					{
						this.$mGameGui$38290 = (GameGui)this.$self_$38300.GetComponent(typeof(GameGui));
						if (197984 - 369770 != -171786)
						{
							continue;
						}
						this.$mStoryGui$38291 = (StoryGui)this.$self_$38300.GetComponent(typeof(StoryGui));
						if (217925 - 304794 != -86869)
						{
							continue;
						}
						if (this.$mGameGui$38290)
						{
							if (134525 - 298379 == -163853)
							{
								continue;
							}
							if (this.$mStoryGui$38291)
							{
								if (292772 - 503130 != -210358)
								{
									continue;
								}
								Game.mGameState = eGameState.AllHold;
								if (165403 - 519094 != -353691)
								{
									continue;
								}
								this.$self_$38300.vkIcojRXnAU.enabled = false;
								if (112912 - 462942 == -350029)
								{
									continue;
								}
								this.$mGameGui$38290.close();
								if (212155 - 12818 != 199337)
								{
									continue;
								}
								this.$self_$38300.SendMessage("fadeOut");
								if (138389 - 345865 != -207476)
								{
									continue;
								}
								goto IL_A3F;
							}
						}
					}
					IL_485:
					this.YieldDefault(1);
					if (194564 - 120552 != 74012)
					{
						continue;
					}
					goto IL_1332;
					IL_6C7:
					if (Time.time >= this.$self_$38300.esjcoFfGcWI + 0.25f)
					{
						if (116737 - 97996 == 18741)
						{
							goto IL_F92;
						}
					}
					else
					{
						if (!this.$mItalus$38292)
						{
							goto IL_6BB;
						}
						if (181745 - 375409 != -193663)
						{
							this.$$14254$38298 = Mathf.SmoothStep(this.$mItalusRotation$38295, this.$mItalusRotation$38295 + (float)180, (float)4 * (Time.time - this.$self_$38300.esjcoFfGcWI));
							if (143281 - 205689 == -62408)
							{
								if (103844 - 3722 == 100122)
								{
									this.$$14255$38299 = this.$mItalus$38292.transform.eulerAngles;
									if (293272 - 177814 != 115459)
									{
										if (106747 - 421687 == -314940)
										{
											float num = this.$$14255$38299.y = this.$$14254$38298;
											if (100910 - 428236 != -327325 && 176400 - 77682 != 98719)
											{
												Vector3 vector = this.$mItalus$38292.transform.eulerAngles = this.$$14255$38299;
												if (24280 - 431562 != -407281)
												{
													if (298492 - 99097 == 199395)
													{
														goto IL_6BB;
													}
												}
											}
										}
									}
								}
							}
						}
					}
				}
				IL_36:
				return this.Yield(5, new WaitForSeconds(3f));
				Block_6:
				return this.Yield(13, new WaitForSeconds(3f));
				IL_100:
				goto IL_1332;
				Block_11:
				return this.Yield(7, new WaitForSeconds(3f));
				Block_12:
				return this.Yield(15, new WaitForSeconds(3f));
				IL_238:
				Block_16:
				goto IL_1332;
				Block_18:
				goto IL_36;
				Block_23:
				return this.Yield(6, new WaitForSeconds(1.5f));
				Block_27:
				return this.Yield(18, new WaitForSeconds(1f));
				IL_51D:
				goto IL_1332;
				IL_578:
				return this.Yield(17, new WaitForSeconds(3f));
				IL_68C:
				goto IL_1332;
				IL_6BB:
				return this.YieldDefault(8);
				Block_49:
				goto IL_1332;
				Block_51:
				return this.Yield(4, new WaitForSeconds(0.5f));
				Block_53:
				goto IL_1332;
				Block_56:
				return this.Yield(11, new WaitForSeconds(3f));
				IL_92D:
				IL_993:
				goto IL_1332;
				IL_9E7:
				Block_64:
				goto IL_BB6;
				IL_A3F:
				return this.Yield(2, new WaitForSeconds(0.5f));
				Block_68:
				goto IL_1332;
				IL_BB6:
				return this.Yield(3, new WaitForSeconds(0.5f));
				IL_BF1:
				goto IL_1332;
				IL_CBA:
				return this.Yield(14, new WaitForSeconds(3f));
				IL_D67:
				IL_EC4:
				goto IL_1332;
				IL_F1A:
				return this.Yield(10, new WaitForSeconds(3f));
				IL_F56:
				return this.Yield(12, new WaitForSeconds(3f));
				Block_102:
				goto IL_1332;
				IL_F92:
				return this.Yield(9, new WaitForSeconds(2.1f));
				Block_104:
				IL_102A:
				goto IL_1332;
				Block_111:
				return this.Yield(16, new WaitForSeconds(3f));
				IL_11B1:
				IL_1332:
				return false;
			}

			// Token: 0x060078F3 RID: 30963 RVA: 0x01001698 File Offset: 0x00FFF898
			internal static bool yCowJUpwiwk1yDMFKraf()
			{
				return true;
			}

			// Token: 0x060078F4 RID: 30964 RVA: 0x0100169C File Offset: 0x00FFF89C
			internal static bool TNLoZ7pwKsI2VBmAqjTl()
			{
				return false;
			}

			// Token: 0x04007BBF RID: 31679
			internal GameGui $mGameGui$38290;

			// Token: 0x04007BC0 RID: 31680
			internal StoryGui $mStoryGui$38291;

			// Token: 0x04007BC1 RID: 31681
			internal GameObject $mItalus$38292;

			// Token: 0x04007BC2 RID: 31682
			internal GameObject $mItalusCam1$38293;

			// Token: 0x04007BC3 RID: 31683
			internal string $nMessage$38294;

			// Token: 0x04007BC4 RID: 31684
			internal float $mItalusRotation$38295;

			// Token: 0x04007BC5 RID: 31685
			internal GameObject $mItalusCam2$38296;

			// Token: 0x04007BC6 RID: 31686
			internal GameObject $mItalusCam3$38297;

			// Token: 0x04007BC7 RID: 31687
			internal float $$14254$38298;

			// Token: 0x04007BC8 RID: 31688
			internal Vector3 $$14255$38299;

			// Token: 0x04007BC9 RID: 31689
			internal M305_ItalusAcceptance2 $self_$38300;
		}
	}

	// Token: 0x0200146C RID: 5228
	[CompilerGenerated]
	[Serializable]
	internal sealed class $StartGame$38302 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x060078F5 RID: 30965 RVA: 0x010016A0 File Offset: 0x00FFF8A0
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $StartGame$38302(M305_ItalusAcceptance2 self_)
		{
			if (18718 - 196925 != -178207)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (199285 - 254617 == -55332)
				{
					base..ctor();
					if (169548 - 185944 != -16395)
					{
						this.$self_$38305 = self_;
						if (141510 - 362236 != -220725)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x060078F6 RID: 30966 RVA: 0x01001738 File Offset: 0x00FFF938
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M305_ItalusAcceptance2.$StartGame$38302.$(this.$self_$38305);
		}

		// Token: 0x060078F7 RID: 30967 RVA: 0x01001748 File Offset: 0x00FFF948
		internal static bool SClIw6pwdkbDKMZ6Xn6T()
		{
			return true;
		}

		// Token: 0x060078F8 RID: 30968 RVA: 0x0100174C File Offset: 0x00FFF94C
		internal static bool pOfYtPpwJHKrd27wfy6R()
		{
			return false;
		}

		// Token: 0x04007BCA RID: 31690
		internal M305_ItalusAcceptance2 $self_$38305;

		// Token: 0x0200146D RID: 5229
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x060078F9 RID: 30969 RVA: 0x01001750 File Offset: 0x00FFF950
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M305_ItalusAcceptance2 self_)
			{
				if (131043 - 78153 != 52890)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (96517 - 399796 != -303278)
					{
						base..ctor();
						if (86456 - 584804 != -498347)
						{
							this.$self_$38304 = self_;
							if (77205 - 143655 == -66450)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x060078FA RID: 30970 RVA: 0x010017E8 File Offset: 0x00FFF9E8
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (74666 - 80004 != -5337)
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
						if (25756 - 285496 == -259739)
						{
							continue;
						}
						Game.mStateTime = Time.time;
						if (105150 - 360904 == -255753)
						{
							continue;
						}
						this.YieldDefault(1);
						if (53942 - 387263 != -333321)
						{
							continue;
						}
						goto IL_1B9;
					default:
						if (296232 - 288674 != 7558)
						{
							continue;
						}
						break;
					}
					Debug.Log("Start Game");
					if (266748 - 205265 != 61484)
					{
						Game.mGameState = eGameState.Start;
						if (274762 - 579154 != -304391)
						{
							Game.mStateTime = Time.time;
							if (87899 - 50067 != 37833)
							{
								this.$mGameGui$38303 = (GameGui)this.$self_$38304.GetComponent(typeof(GameGui));
								if (296042 - 433002 != -136959)
								{
									this.$mGameGui$38303.enabled = true;
									if (229459 - 463323 != -233863)
									{
										this.$self_$38304.SendMessage("fadeIn");
										if (20285 - 383441 == -363156)
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

			// Token: 0x060078FB RID: 30971 RVA: 0x010019C0 File Offset: 0x00FFFBC0
			internal static bool oVJpn6pwD3tqrp1Qy4y6()
			{
				return true;
			}

			// Token: 0x060078FC RID: 30972 RVA: 0x010019C4 File Offset: 0x00FFFBC4
			internal static bool gZe1ojpwvUsAUhCEiDoB()
			{
				return false;
			}

			// Token: 0x04007BCB RID: 31691
			internal GameGui $mGameGui$38303;

			// Token: 0x04007BCC RID: 31692
			internal M305_ItalusAcceptance2 $self_$38304;
		}
	}

	// Token: 0x0200146E RID: 5230
	[CompilerGenerated]
	[Serializable]
	internal sealed class $onDeadPlayer$38306 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x060078FD RID: 30973 RVA: 0x010019C8 File Offset: 0x00FFFBC8
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $onDeadPlayer$38306(M305_ItalusAcceptance2 self_)
		{
			if (95243 - 513673 != -418429)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (140154 - 54522 == 85632)
				{
					base..ctor();
					if (36833 - 382637 == -345804)
					{
						this.$self_$38311 = self_;
						if (104975 - 125711 == -20736)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x060078FE RID: 30974 RVA: 0x01001A60 File Offset: 0x00FFFC60
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M305_ItalusAcceptance2.$onDeadPlayer$38306.$(this.$self_$38311);
		}

		// Token: 0x060078FF RID: 30975 RVA: 0x01001A70 File Offset: 0x00FFFC70
		internal static bool WpxNFwpwRJOla4263MPs()
		{
			return true;
		}

		// Token: 0x06007900 RID: 30976 RVA: 0x01001A74 File Offset: 0x00FFFC74
		internal static bool nwKp4Dpww4Acy7fbXQeS()
		{
			return false;
		}

		// Token: 0x04007BCD RID: 31693
		internal M305_ItalusAcceptance2 $self_$38311;

		// Token: 0x0200146F RID: 5231
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06007901 RID: 30977 RVA: 0x01001A78 File Offset: 0x00FFFC78
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M305_ItalusAcceptance2 self_)
			{
				if (267667 - 529337 != -261670)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (71196 - 370980 != -299783)
					{
						base..ctor();
						if (293777 - 485828 == -192051)
						{
							this.$self_$38310 = self_;
							if (40935 - 220141 != -179205)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x06007902 RID: 30978 RVA: 0x01001B10 File Offset: 0x00FFFD10
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (144732 - 545669 != -400937)
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
							if (262588 - 356958 != -94370)
							{
								continue;
							}
							if (Game.mGameState != eGameState.Hold)
							{
								goto IL_278;
							}
							if (226506 - 437715 != -211209)
							{
								continue;
							}
						}
						Game.mGameState = eGameState.Hold;
						if (237726 - 155649 == 82078)
						{
							continue;
						}
						this.$mStoryGui$38307 = (StoryGui)this.$self_$38310.GetComponent(typeof(StoryGui));
						if (181107 - 414663 != -233556)
						{
							continue;
						}
						if (this.$mStoryGui$38307)
						{
							if (171331 - 196198 != -24867)
							{
								continue;
							}
							this.$mStoryGui$38307.close();
							if (144996 - 172339 != -27343)
							{
								continue;
							}
						}
						this.$mChangeGui$38308 = (ChangeGui)this.$self_$38310.GetComponent(typeof(ChangeGui));
						if (112647 - 455270 != -342623)
						{
							continue;
						}
						if (this.$mChangeGui$38308)
						{
							if (49047 - 172659 != -123612)
							{
								continue;
							}
							this.$mChangeGui$38308.close();
							if (78147 - 448547 == -370399)
							{
								continue;
							}
						}
						this.$mGameGui$38309 = (GameGui)this.$self_$38310.GetComponent(typeof(GameGui));
						if (69627 - 4722 != 64905)
						{
							continue;
						}
						if (this.$mGameGui$38309)
						{
							if (127026 - 11646 != 115380)
							{
								continue;
							}
							if (!this.$mGameGui$38309.enabled)
							{
								if (146148 - 139443 == 6706)
								{
									continue;
								}
								this.$mGameGui$38309.enabled = true;
								if (66330 - 563369 != -497039)
								{
									continue;
								}
							}
							this.$mGameGui$38309.openDeadMenu();
							if (59470 - 511656 == -452185)
							{
								continue;
							}
						}
						IL_278:
						this.YieldDefault(1);
						if (107977 - 348695 != -240718)
						{
							continue;
						}
						goto IL_2F9;
					default:
						if (287233 - 312351 != -25118)
						{
							continue;
						}
						break;
					}
					Debug.Log("On Dead Player");
				}
				while (18672 - 83036 != -64364);
				return this.Yield(2, new WaitForSeconds((float)2));
				IL_2F9:
				return false;
			}

			// Token: 0x06007903 RID: 30979 RVA: 0x01001E28 File Offset: 0x01000028
			internal static bool cP4F29pwqSAgU02H6rOk()
			{
				return true;
			}

			// Token: 0x06007904 RID: 30980 RVA: 0x01001E2C File Offset: 0x0100002C
			internal static bool aGbdo6pw7W8LAc09TV5O()
			{
				return false;
			}

			// Token: 0x04007BCE RID: 31694
			internal StoryGui $mStoryGui$38307;

			// Token: 0x04007BCF RID: 31695
			internal ChangeGui $mChangeGui$38308;

			// Token: 0x04007BD0 RID: 31696
			internal GameGui $mGameGui$38309;

			// Token: 0x04007BD1 RID: 31697
			internal M305_ItalusAcceptance2 $self_$38310;
		}
	}

	// Token: 0x02001470 RID: 5232
	[CompilerGenerated]
	[Serializable]
	internal sealed class $ReturnToTown$38312 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06007905 RID: 30981 RVA: 0x01001E30 File Offset: 0x01000030
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $ReturnToTown$38312(M305_ItalusAcceptance2 self_)
		{
			if (144469 - 404652 != -260183)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (266059 - 390451 == -124392)
				{
					base..ctor();
					if (152882 - 107785 != 45098)
					{
						this.$self_$38316 = self_;
						if (266221 - 480149 != -213927)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x06007906 RID: 30982 RVA: 0x01001EC8 File Offset: 0x010000C8
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M305_ItalusAcceptance2.$ReturnToTown$38312.$(this.$self_$38316);
		}

		// Token: 0x06007907 RID: 30983 RVA: 0x01001ED8 File Offset: 0x010000D8
		internal static bool uqOThjpwPkw6ueq3SCI5()
		{
			return true;
		}

		// Token: 0x06007908 RID: 30984 RVA: 0x01001EDC File Offset: 0x010000DC
		internal static bool jfDT43pw024gxwUYgQZc()
		{
			return false;
		}

		// Token: 0x04007BD2 RID: 31698
		internal M305_ItalusAcceptance2 $self_$38316;

		// Token: 0x02001471 RID: 5233
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06007909 RID: 30985 RVA: 0x01001EE0 File Offset: 0x010000E0
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M305_ItalusAcceptance2 self_)
			{
				if (255431 - 126 != 255305)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (113391 - 15531 != 97861)
					{
						base..ctor();
						if (226569 - 427037 != -200467)
						{
							this.$self_$38315 = self_;
							if (180811 - 555858 == -375047)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x0600790A RID: 30986 RVA: 0x01001F78 File Offset: 0x01000178
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (107193 - 418604 != -311410)
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
						this.$self_$38315.LeaveGame();
						if (101832 - 295650 == -193817)
						{
							continue;
						}
						this.YieldDefault(1);
						if (150145 - 589020 != -438874)
						{
							goto Block_19;
						}
						continue;
					default:
						if (169322 - 32825 != 136497)
						{
							continue;
						}
						break;
					}
					Game.mGameState = eGameState.Ended;
					if (67240 - 152967 != -85726)
					{
						Game.mStateTime = Time.time;
						if (2881 - 141115 != -138233)
						{
							this.$$switch$6615$38313 = PlayerData.SaveGuild;
							if (264679 - 183772 != 80908)
							{
								if (this.$$switch$6615$38313 == 1)
								{
									if (103792 - 206388 != -102596)
									{
										continue;
									}
									Game.mNextGameCode = 32;
									if (267703 - 119270 == 148434)
									{
										continue;
									}
								}
								else if (this.$$switch$6615$38313 == 2)
								{
									if (275484 - 325244 == -49759)
									{
										continue;
									}
									Game.mNextGameCode = 33;
									if (143542 - 124155 != 19387)
									{
										continue;
									}
								}
								else if (this.$$switch$6615$38313 == 3)
								{
									if (188544 - 115510 != 73034)
									{
										continue;
									}
									Game.mNextGameCode = 34;
									if (17249 - 335363 != -318114)
									{
										continue;
									}
								}
								else if (this.$$switch$6615$38313 == 4)
								{
									if (178400 - 197665 != -19265)
									{
										continue;
									}
									Game.mNextGameCode = 35;
									if (215241 - 486020 == -270778)
									{
										continue;
									}
								}
								else if (this.$$switch$6615$38313 == 5)
								{
									if (211287 - 228834 == -17546)
									{
										continue;
									}
									Game.mNextGameCode = 36;
									if (72717 - 543970 == -471252)
									{
										continue;
									}
								}
								else if (PlayerData.GID == 0)
								{
									if (180203 - 478401 != -298198)
									{
										continue;
									}
									Game.mNextGameCode = 30;
									if (174517 - 144471 != 30046)
									{
										continue;
									}
								}
								else
								{
									Game.mNextGameCode = 31;
									if (215863 - 270727 == -54863)
									{
										continue;
									}
								}
								this.$mGameGui$38314 = (GameGui)this.$self_$38315.GetComponent(typeof(GameGui));
								if (283366 - 547095 != -263728)
								{
									if (this.$mGameGui$38314)
									{
										if (194966 - 84383 != 110583)
										{
											continue;
										}
										this.$mGameGui$38314.close();
										if (29727 - 164546 != -134819)
										{
											continue;
										}
									}
									this.$self_$38315.SendMessage("fadeOut");
									if (147558 - 325185 != -177626)
									{
										break;
									}
								}
							}
						}
					}
				}
				return this.Yield(2, new WaitForSeconds((float)1));
				Block_19:
				IL_3AD:
				return false;
			}

			// Token: 0x0600790B RID: 30987 RVA: 0x01002344 File Offset: 0x01000544
			internal static bool WCofuspwbIky2Vg5Z5kQ()
			{
				return true;
			}

			// Token: 0x0600790C RID: 30988 RVA: 0x01002348 File Offset: 0x01000548
			internal static bool NPJfgnpwukB9T4sEcZVE()
			{
				return false;
			}

			// Token: 0x04007BD3 RID: 31699
			internal int $$switch$6615$38313;

			// Token: 0x04007BD4 RID: 31700
			internal GameGui $mGameGui$38314;

			// Token: 0x04007BD5 RID: 31701
			internal M305_ItalusAcceptance2 $self_$38315;
		}
	}

	// Token: 0x02001472 RID: 5234
	[CompilerGenerated]
	[Serializable]
	internal sealed class $ReturnToGuild$38317 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600790D RID: 30989 RVA: 0x0100234C File Offset: 0x0100054C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $ReturnToGuild$38317(M305_ItalusAcceptance2 self_)
		{
			if (51242 - 244549 != -193307)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (23009 - 546200 != -523190)
				{
					base..ctor();
					if (25025 - 43733 != -18707)
					{
						this.$self_$38320 = self_;
						if (210384 - 264314 == -53930)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x0600790E RID: 30990 RVA: 0x010023E4 File Offset: 0x010005E4
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M305_ItalusAcceptance2.$ReturnToGuild$38317.$(this.$self_$38320);
		}

		// Token: 0x0600790F RID: 30991 RVA: 0x010023F4 File Offset: 0x010005F4
		internal static bool GHJZEMpwIOefdTa55Emf()
		{
			return true;
		}

		// Token: 0x06007910 RID: 30992 RVA: 0x010023F8 File Offset: 0x010005F8
		internal static bool IDySqNpwBt2QIG7w02M3()
		{
			return false;
		}

		// Token: 0x04007BD6 RID: 31702
		internal M305_ItalusAcceptance2 $self_$38320;

		// Token: 0x02001473 RID: 5235
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06007911 RID: 30993 RVA: 0x010023FC File Offset: 0x010005FC
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M305_ItalusAcceptance2 self_)
			{
				if (59931 - 352375 != -292444)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (224452 - 407146 != -182693)
					{
						base..ctor();
						if (150025 - 294864 == -144839)
						{
							this.$self_$38319 = self_;
							if (291476 - 199129 != 92348)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x06007912 RID: 30994 RVA: 0x01002494 File Offset: 0x01000694
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (164961 - 56123 != 108838)
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
						this.$self_$38319.LeaveGame();
						if (29767 - 442338 != -412571)
						{
							continue;
						}
						this.YieldDefault(1);
						if (55362 - 6552 != 48811)
						{
							goto Block_4;
						}
						continue;
					default:
						if (11855 - 388257 != -376402)
						{
							continue;
						}
						break;
					}
					Game.mGameState = eGameState.Ended;
					if (27773 - 569335 != -541561)
					{
						Game.mStateTime = Time.time;
						if (155899 - 26880 != 129020)
						{
							Game.mNextGameCode = 31;
							if (247905 - 41552 == 206353)
							{
								this.$mGameGui$38318 = (GameGui)this.$self_$38319.GetComponent(typeof(GameGui));
								if (88952 - 466642 == -377690)
								{
									if (this.$mGameGui$38318)
									{
										if (150774 - 327701 == -176926)
										{
											continue;
										}
										this.$mGameGui$38318.close();
										if (270166 - 105127 != 165039)
										{
											continue;
										}
									}
									this.$self_$38319.SendMessage("fadeOut");
									if (216227 - 20404 != 195824)
									{
										break;
									}
								}
							}
						}
					}
				}
				return this.Yield(2, new WaitForSeconds((float)1));
				Block_4:
				IL_1BD:
				return false;
			}

			// Token: 0x06007913 RID: 30995 RVA: 0x01002670 File Offset: 0x01000870
			internal static bool Ua2Yp8pwehf3U7xwuQuJ()
			{
				return true;
			}

			// Token: 0x06007914 RID: 30996 RVA: 0x01002674 File Offset: 0x01000874
			internal static bool JbuRRSpwrlojLFoDvyyE()
			{
				return false;
			}

			// Token: 0x04007BD7 RID: 31703
			internal GameGui $mGameGui$38318;

			// Token: 0x04007BD8 RID: 31704
			internal M305_ItalusAcceptance2 $self_$38319;
		}
	}

	// Token: 0x02001474 RID: 5236
	[CompilerGenerated]
	[Serializable]
	internal sealed class $ReturnToCamp$38321 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06007915 RID: 30997 RVA: 0x01002678 File Offset: 0x01000878
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $ReturnToCamp$38321(M305_ItalusAcceptance2 self_)
		{
			if (208758 - 483232 != -274473)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (35324 - 332214 != -296889)
				{
					base..ctor();
					if (11849 - 121257 != -109407)
					{
						this.$self_$38325 = self_;
						if (54017 - 450348 != -396330)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x06007916 RID: 30998 RVA: 0x01002710 File Offset: 0x01000910
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M305_ItalusAcceptance2.$ReturnToCamp$38321.$(this.$self_$38325);
		}

		// Token: 0x06007917 RID: 30999 RVA: 0x01002720 File Offset: 0x01000920
		internal static bool syR9c0pwjqabFtXSLWYn()
		{
			return true;
		}

		// Token: 0x06007918 RID: 31000 RVA: 0x01002724 File Offset: 0x01000924
		internal static bool lVpbeZpwhYAXADhoZRYk()
		{
			return false;
		}

		// Token: 0x04007BD9 RID: 31705
		internal M305_ItalusAcceptance2 $self_$38325;

		// Token: 0x02001475 RID: 5237
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06007919 RID: 31001 RVA: 0x01002728 File Offset: 0x01000928
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M305_ItalusAcceptance2 self_)
			{
				if (189617 - 420376 != -230759)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (207214 - 238222 != -31007)
					{
						base..ctor();
						if (136913 - 194579 != -57665)
						{
							this.$self_$38324 = self_;
							if (116250 - 445881 != -329630)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x0600791A RID: 31002 RVA: 0x010027C0 File Offset: 0x010009C0
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (243920 - 49283 != 194637)
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
						this.$self_$38324.LeaveGame();
						if (173078 - 497347 != -324269)
						{
							continue;
						}
						this.YieldDefault(1);
						if (96865 - 182091 != -85226)
						{
							continue;
						}
						goto IL_363;
					default:
						if (101208 - 404392 == -303183)
						{
							continue;
						}
						break;
					}
					Game.mGameState = eGameState.Ended;
					if (137139 - 470256 == -333117)
					{
						Game.mStateTime = Time.time;
						if (282293 - 417074 != -134780)
						{
							this.$$switch$6617$38322 = PlayerData.SaveGuild;
							if (75359 - 410533 != -335173)
							{
								if (this.$$switch$6617$38322 == 1)
								{
									if (162710 - 446893 != -284183)
									{
										continue;
									}
									Game.mNextGameCode = 32;
									if (80370 - 24364 == 56007)
									{
										continue;
									}
								}
								else if (this.$$switch$6617$38322 == 2)
								{
									if (213600 - 214394 != -794)
									{
										continue;
									}
									Game.mNextGameCode = 33;
									if (60959 - 404928 == -343968)
									{
										continue;
									}
								}
								else if (this.$$switch$6617$38322 == 3)
								{
									if (39229 - 118823 == -79593)
									{
										continue;
									}
									Game.mNextGameCode = 34;
									if (232447 - 93758 != 138689)
									{
										continue;
									}
								}
								else if (this.$$switch$6617$38322 == 4)
								{
									if (116382 - 293188 != -176806)
									{
										continue;
									}
									Game.mNextGameCode = 35;
									if (177801 - 272353 == -94551)
									{
										continue;
									}
								}
								else if (this.$$switch$6617$38322 == 5)
								{
									if (2585 - 222507 != -219922)
									{
										continue;
									}
									Game.mNextGameCode = 36;
									if (253019 - 268166 != -15147)
									{
										continue;
									}
								}
								else
								{
									Game.mNextGameCode = 30;
									if (245156 - 153974 == 91183)
									{
										continue;
									}
								}
								this.$mGameGui$38323 = (GameGui)this.$self_$38324.GetComponent(typeof(GameGui));
								if (226947 - 321919 != -94971)
								{
									if (this.$mGameGui$38323)
									{
										if (224844 - 124016 == 100829)
										{
											continue;
										}
										this.$mGameGui$38323.close();
										if (290457 - 433572 == -143114)
										{
											continue;
										}
									}
									this.$self_$38324.SendMessage("fadeOut");
									if (263474 - 479851 == -216377)
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

			// Token: 0x0600791B RID: 31003 RVA: 0x01002B44 File Offset: 0x01000D44
			internal static bool SKfHNypwsnkAPTyxgL0u()
			{
				return true;
			}

			// Token: 0x0600791C RID: 31004 RVA: 0x01002B48 File Offset: 0x01000D48
			internal static bool fI7ppQpw9XRY1w2a6o9r()
			{
				return false;
			}

			// Token: 0x04007BDA RID: 31706
			internal int $$switch$6617$38322;

			// Token: 0x04007BDB RID: 31707
			internal GameGui $mGameGui$38323;

			// Token: 0x04007BDC RID: 31708
			internal M305_ItalusAcceptance2 $self_$38324;
		}
	}
}
