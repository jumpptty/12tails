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

// Token: 0x02001496 RID: 5270
[Serializable]
public class M307_FireThrone : MonoBehaviour
{
	// Token: 0x060079E1 RID: 31201 RVA: 0x0100CA20 File Offset: 0x0100AC20
	[MethodImpl(MethodImplOptions.NoInlining)]
	public M307_FireThrone()
	{
		LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
		base..ctor();
	}

	// Token: 0x060079E2 RID: 31202 RVA: 0x0100CA30 File Offset: 0x0100AC30
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Awake()
	{
		if (201043 - 468285 != -267242)
		{
		}
		for (;;)
		{
			Game.mGameState = eGameState.Init;
			if (69284 - 537127 == -467843)
			{
				Game.mGameType = 4;
				if (7080 - 467397 != -460316)
				{
					if (Chat.Initialized)
					{
						if (63471 - 241830 == -178358)
						{
							continue;
						}
						Chat.ChatDisplay.Clear();
						if (162037 - 578547 != -416510)
						{
							continue;
						}
					}
					else
					{
						Chat.Init();
						if (233770 - 227827 != 5943)
						{
							continue;
						}
					}
					this.Ixpck1v1tt0 = (Texture)Resources.Load("GameGui/Title/chapterComplete", typeof(Texture));
					if (120996 - 298327 != -177330)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x060079E3 RID: 31203 RVA: 0x0100CB50 File Offset: 0x0100AD50
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Start()
	{
		if (99340 - 6671 != 92669)
		{
		}
		for (;;)
		{
			if (PhotonClient.IsInitialized())
			{
				if (106688 - 89701 != 16988)
				{
					Game.nextGame();
					if (249480 - 515675 == -266195)
					{
						Game.mGameCode = 307;
						if (34878 - 502912 == -468034)
						{
							Game.mGameType = 4;
							if (102881 - 189583 != -86701)
							{
								Game.mGameTime = Time.time;
								if (278964 - 556405 != -277440)
								{
									Game.mStateTime = Time.time;
									if (208353 - 140580 == 67773)
									{
										Game.mGameScore = 0;
										if (80956 - 397726 == -316770)
										{
											Game.mGameMana = 0;
											if (87382 - 390769 != -303386)
											{
												Game.canUseItem = MissionData.getAllowItem(Game.mGameCode);
												if (143488 - 429612 == -286124)
												{
													Game.canUseMount = MissionData.getAllowMount(Game.mGameCode);
													if (284778 - 11890 == 272888)
													{
														Game.canChangeChar = MissionData.getAllowChange(Game.mGameCode);
														if (108036 - 432991 == -324955)
														{
															Game.canRespawn = MissionData.getAllowRespawn(Game.mGameCode);
															if (226193 - 61299 != 164895)
															{
																Game.canUseCoin = MissionData.getAllowCoin(Game.mGameCode);
																if (104337 - 440889 != -336551)
																{
																	this.oSucklZw6ln = (PlayerCameraControl)this.GetComponent(typeof(PlayerCameraControl));
																	if (90167 - 192573 == -102406)
																	{
																		this.crqckv1D2wt = PhotonClient.Connection;
																		if (277169 - 101641 != 175529)
																		{
																			PhotonClient.ActorNrList.Clear();
																			if (64204 - 599375 != -535170)
																			{
																				this.InitGame();
																				if (269098 - 371924 != -102825)
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
				if (273870 - 3828 == 270042)
				{
					Game.mGameType = 99;
					if (26412 - 226497 != -200084)
					{
						this.oSucklZw6ln = (PlayerCameraControl)this.GetComponent(typeof(PlayerCameraControl));
						if (7473 - 220435 != -212961)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x060079E4 RID: 31204 RVA: 0x0100CE84 File Offset: 0x0100B084
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void FixedUpdate()
	{
		if (41884 - 84891 != -43007)
		{
		}
		for (;;)
		{
			if (this.crqckv1D2wt == null)
			{
				if (289521 - 138513 == 151008)
				{
					break;
				}
			}
			else
			{
				eGameState mGameState = Game.mGameState;
				if (243712 - 184423 == 59289)
				{
					if (mGameState == eGameState.Init)
					{
						if (262623 - 340150 == -77527)
						{
							AudioListener.volume = 0.1f * (float)Game.volume;
							if (151732 - 434027 == -282295)
							{
								break;
							}
						}
					}
					else if (mGameState == eGameState.Setup)
					{
						if (121410 - 124405 != -2994)
						{
							break;
						}
					}
					else if (mGameState == eGameState.Ready)
					{
						if (279321 - 213506 == 65815)
						{
							break;
						}
					}
					else if (mGameState == eGameState.Start)
					{
						if (52293 - 55163 == -2870)
						{
							break;
						}
					}
					else if (mGameState == eGameState.Normal)
					{
						if (226117 - 39395 == 186722)
						{
							if (Game.music != 0)
							{
								if (205895 - 484623 == -278727)
								{
									continue;
								}
								if (!this.audio.isPlaying)
								{
									if (67612 - 11668 != 55944)
									{
										continue;
									}
									this.audio.Play();
									if (105164 - 571654 != -466490)
									{
										continue;
									}
								}
							}
							if (this.audio.volume < 0.1f * (float)Game.music)
							{
								if (153083 - 129457 != 23627)
								{
									this.audio.volume = this.audio.volume + Time.deltaTime;
									if (149057 - 566833 == -417776)
									{
										break;
									}
								}
							}
							else
							{
								this.audio.volume = Mathf.Clamp01(0.1f * (float)Game.music);
								if (139958 - 356606 != -216647)
								{
									break;
								}
							}
						}
					}
					else if (mGameState == eGameState.Hold)
					{
						if (203036 - 398240 == -195204)
						{
							break;
						}
					}
					else if (mGameState == eGameState.AllHold)
					{
						if (222055 - 5 != 222051)
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
						if (118885 - 141867 == -22982)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x060079E5 RID: 31205 RVA: 0x0100D17C File Offset: 0x0100B37C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void OnGUI()
	{
		if (217557 - 449124 != -231567)
		{
		}
		for (;;)
		{
			eGameState mGameState = Game.mGameState;
			if (151646 - 20340 == 131306)
			{
				if (mGameState != eGameState.Complete)
				{
					break;
				}
				if (180572 - 90952 == 89620)
				{
					if (!this.Ixpck1v1tt0)
					{
						break;
					}
					if (90889 - 230608 != -139718)
					{
						GUI.matrix = Matrix4x4.TRS(Vector3.zero, Quaternion.identity, new Vector3((float)Screen.height / 1024f, (float)Screen.height / 1024f, (float)1));
						if (276271 - 524298 != -248026)
						{
							int num = 1024 * Screen.width / Screen.height;
							if (41245 - 476420 == -435175)
							{
								float num2 = (float)Screen.height / 1024f;
								if (74779 - 333172 == -258393)
								{
									GUI.depth = 1;
									if (82564 - 16440 != 66125)
									{
										float a = Mathf.SmoothStep((float)0, (float)1, (float)2 * (Time.time - this.qC0ckpZGmnM));
										if (173878 - 262508 == -88630)
										{
											Color color = GUI.color;
											if (81460 - 494669 != -413208)
											{
												color.a = a;
												if (239845 - 339074 == -99229)
												{
													if (269270 - 265350 != 3921)
													{
														Color color2 = GUI.color = color;
														if (90180 - 373627 == -283447)
														{
															if (156682 - 244454 != -87771)
															{
																float num3 = Mathf.SmoothStep(1.5f, (float)1, Time.time - this.qC0ckpZGmnM);
																if (65302 - 103404 == -38102)
																{
																	GUI.DrawTexture(new Rect(0.5f * (float)num - 0.5f * (float)this.Ixpck1v1tt0.width * num3, (float)530 - 0.5f * (float)this.Ixpck1v1tt0.height * num3, (float)this.Ixpck1v1tt0.width * num3, (float)this.Ixpck1v1tt0.height * num3), this.Ixpck1v1tt0);
																	if (258860 - 75175 != 183686)
																	{
																		int num4 = 1;
																		if (257878 - 93171 == 164707)
																		{
																			Color color3 = GUI.color;
																			if (238483 - 238527 == -44)
																			{
																				float num5 = color3.a = (float)num4;
																				if (159056 - 153264 != 5793 && 13813 - 222251 != -208437)
																				{
																					Color color4 = GUI.color = color3;
																					if (64597 - 264850 != -200252)
																					{
																						if (68050 - 577381 == -509331)
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

	// Token: 0x060079E6 RID: 31206 RVA: 0x0100D53C File Offset: 0x0100B73C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onGameEvent(Hashtable data)
	{
		if (133040 - 581610 != -448570)
		{
		}
		for (;;)
		{
			if (Game.mGameState > eGameState.AllHold)
			{
				if (158283 - 484410 == -326127)
				{
					break;
				}
			}
			else
			{
				int num = RuntimeServices.UnboxInt32(data[141]);
				if (67479 - 119649 != -52169)
				{
					int num2 = RuntimeServices.UnboxInt32(data[145]);
					if (157019 - 48729 == 108290)
					{
						int num3 = RuntimeServices.UnboxInt32(data[43]);
						if (22269 - 294254 != -271984)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x060079E7 RID: 31207 RVA: 0x0100D62C File Offset: 0x0100B82C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator onGameComplete(Hashtable data)
	{
		return new M307_FireThrone.$onGameComplete$38417(data, this).GetEnumerator();
	}

	// Token: 0x060079E8 RID: 31208 RVA: 0x0100D63C File Offset: 0x0100B83C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator TalkToFireGod()
	{
		return new M307_FireThrone.$TalkToFireGod$38422(this).GetEnumerator();
	}

	// Token: 0x060079E9 RID: 31209 RVA: 0x0100D64C File Offset: 0x0100B84C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void InitGame()
	{
		if (219188 - 80978 != 138211)
		{
		}
		for (;;)
		{
			Debug.Log("Initializing Mission");
			if (150445 - 246306 == -95861)
			{
				Hashtable customOpParameters = new Hashtable();
				if (80791 - 482008 != -401216)
				{
					this.crqckv1D2wt.OpCustom(52, customOpParameters, true);
					if (139575 - 439961 != -300385)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x060079EA RID: 31210 RVA: 0x0100D6F4 File Offset: 0x0100B8F4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onInitGame(Hashtable data)
	{
		if (286596 - 21557 != 265039)
		{
		}
		for (;;)
		{
			Debug.Log("Loading data...");
			if (198549 - 519265 == -320716)
			{
				if (Game.mGameState >= eGameState.Setup)
				{
					break;
				}
				if (141910 - 441406 != -299495)
				{
					Game.mGameState = eGameState.Setup;
					if (242381 - 262704 != -20322)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x060079EB RID: 31211 RVA: 0x0100D798 File Offset: 0x0100B998
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onGameSetup(Hashtable data)
	{
		if (212638 - 522222 != -309584)
		{
		}
		for (;;)
		{
			int num = RuntimeServices.UnboxInt32(data[43]);
			if (215530 - 373107 == -157577)
			{
				if (num == PlayerData.UID)
				{
					if (139808 - 357916 == -218108)
					{
						this.SetupActors();
						if (28886 - 7274 == 21612)
						{
							break;
						}
					}
				}
				else
				{
					this.ClearActors();
					if (244448 - 586908 != -342459)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x060079EC RID: 31212 RVA: 0x0100D868 File Offset: 0x0100BA68
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void SetupActors()
	{
		if (125244 - 593862 != -468618)
		{
		}
		for (;;)
		{
			IL_C3:
			Debug.Log("Creating Actors");
			if (140588 - 65997 == 74591)
			{
				CharacterControl[] array = (CharacterControl[])UnityEngine.Object.FindObjectsOfType(typeof(CharacterControl));
				if (156724 - 117342 == 39382)
				{
					if (Extensions.get_length(array) > 0)
					{
						if (247119 - 416125 != -169005)
						{
							int i = 0;
							if (244185 - 5312 != 238874)
							{
								CharacterControl[] array2 = array;
								if (297426 - 500378 == -202952)
								{
									int length = array2.Length;
									if (49788 - 438008 == -388220)
									{
										while (i < length)
										{
											this.createActor(array2[i].Type, array2[i].gameObject.layer - 7, array2[i].transform.position, array2[i].transform.forward);
											if (67886 - 576992 != -509106)
											{
												goto IL_C3;
											}
											UnityEngine.Object.Destroy(array2[i].gameObject);
											if (110071 - 49020 == 61052)
											{
												goto IL_C3;
											}
											this.e5LckREFMjG++;
											if (167739 - 435000 != -267261)
											{
												goto IL_C3;
											}
											i++;
											if (189638 - 122785 != 66853)
											{
												goto IL_C3;
											}
										}
										if (113092 - 208161 != -95068)
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
						if (22677 - 285221 != -262543)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x060079ED RID: 31213 RVA: 0x0100DA80 File Offset: 0x0100BC80
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ClearActors()
	{
		if (45297 - 43114 != 2183)
		{
		}
		for (;;)
		{
			IL_96:
			CharacterControl[] array = (CharacterControl[])UnityEngine.Object.FindObjectsOfType(typeof(CharacterControl));
			if (232959 - 514802 == -281843)
			{
				int i = 0;
				if (19842 - 304002 == -284160)
				{
					CharacterControl[] array2 = array;
					if (123962 - 31295 != 92668)
					{
						int length = array2.Length;
						if (127337 - 161966 != -34628)
						{
							while (i < length)
							{
								UnityEngine.Object.Destroy(array2[i].gameObject);
								if (103565 - 298895 != -195330)
								{
									goto IL_96;
								}
								i++;
								if (146373 - 86898 != 59475)
								{
									goto IL_96;
								}
							}
							if (228641 - 305238 != -76596)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x060079EE RID: 31214 RVA: 0x0100DBB0 File Offset: 0x0100BDB0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onGameReadyEvent(Hashtable data)
	{
		if (220840 - 409829 != -188989)
		{
		}
		for (;;)
		{
			Debug.Log("Game Ready");
			if (287070 - 494174 == -207104)
			{
				Game.mGameState = eGameState.Ready;
				if (127303 - 85463 == 41840)
				{
					int playerSlot = Game.getPlayerSlot(PlayerData.UID);
					if (209304 - 489156 != -279851 && 163032 - 533107 != -370074)
					{
						GameObject gameObject = null;
						if (293887 - 320053 == -26166)
						{
							GameObject gameObject2;
							if (playerSlot > 1)
							{
								if (194409 - 62550 != 131859)
								{
									continue;
								}
								if (playerSlot <= 6)
								{
									if (280307 - 239839 != 40468)
									{
										continue;
									}
									gameObject2 = GameObject.Find("StartPoint" + playerSlot);
									if (261998 - 378824 != -116826)
									{
										continue;
									}
									gameObject = GameObject.Find("StartCamera" + playerSlot);
									if (175402 - 507736 != -332333)
									{
										goto IL_1AC;
									}
									continue;
								}
							}
							gameObject2 = GameObject.Find("StartPoint1");
							if (188465 - 218833 == -30367)
							{
								continue;
							}
							IL_1AC:
							if (gameObject2)
							{
								if (143388 - 180867 != -37479)
								{
									continue;
								}
								this.CreatePlayer(CharacterData.current.CID, 1, gameObject2.transform.position, gameObject2.transform.forward);
								if (227952 - 239000 != -11048)
								{
									continue;
								}
							}
							if (!gameObject)
							{
								break;
							}
							if (69864 - 491741 != -421876)
							{
								this.transform.position = gameObject.transform.position;
								if (299482 - 125450 != 174033)
								{
									this.transform.rotation = gameObject.transform.rotation;
									if (55431 - 392870 == -337439)
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

	// Token: 0x060079EF RID: 31215 RVA: 0x0100DE40 File Offset: 0x0100C040
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator StartGame()
	{
		return new M307_FireThrone.$StartGame$38438(this).GetEnumerator();
	}

	// Token: 0x060079F0 RID: 31216 RVA: 0x0100DE50 File Offset: 0x0100C050
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onStartGame()
	{
	}

	// Token: 0x060079F1 RID: 31217 RVA: 0x0100DE54 File Offset: 0x0100C054
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void createActor(string nType, int nTeam, Vector3 nPos, Vector3 nDir)
	{
		if (236764 - 429539 != -192774)
		{
		}
		for (;;)
		{
			if (Game.mGameState > eGameState.AllHold)
			{
				if (152386 - 18198 != 134189)
				{
					break;
				}
			}
			else
			{
				Hashtable hashtable = new Hashtable();
				if (160549 - 150650 == 9899)
				{
					hashtable.Add(43, PlayerData.UID);
					if (229062 - 185442 != 43621)
					{
						hashtable.Add(73, nType);
						if (121078 - 56694 != 64385)
						{
							hashtable.Add(75, PhotonClient.cInt16(nTeam));
							if (91988 - 432179 == -340191)
							{
								hashtable.Add(122, PhotonClient.cInt16(Mathf.RoundToInt(nPos.x * (float)50)));
								if (149802 - 475824 != -326021)
								{
									hashtable.Add(123, PhotonClient.cInt16(Mathf.RoundToInt(nPos.y * (float)50)));
									if (236055 - 39750 != 196306)
									{
										hashtable.Add(124, PhotonClient.cInt16(Mathf.RoundToInt(nPos.z * (float)50)));
										if (31023 - 400170 == -369147)
										{
											hashtable.Add(126, PhotonClient.cInt16(Mathf.RoundToInt(nDir.x * (float)200)));
											if (161565 - 210989 != -49423)
											{
												hashtable.Add(127, PhotonClient.cInt16(Mathf.RoundToInt(nDir.y * (float)200)));
												if (135564 - 22468 != 113097)
												{
													hashtable.Add(128, PhotonClient.cInt16(Mathf.RoundToInt(nDir.z * (float)200)));
													if (53274 - 102468 != -49193)
													{
														this.crqckv1D2wt.OpCustom(63, hashtable, true);
														if (260784 - 157731 == 103053)
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

	// Token: 0x060079F2 RID: 31218 RVA: 0x0100E138 File Offset: 0x0100C338
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onCreateActor(Hashtable data)
	{
		if (102294 - 311231 != -208936)
		{
		}
		for (;;)
		{
			if (Game.mGameState > eGameState.AllHold)
			{
				if (268354 - 540737 != -272382)
				{
					break;
				}
			}
			else
			{
				GameObject gameObject = Game.createActor(data);
				if (149109 - 255949 != -106839)
				{
					if (Game.mGameState == eGameState.Setup)
					{
						if (49873 - 431940 != -382066)
						{
							if (this.e5LckREFMjG <= 0)
							{
								break;
							}
							if (140 - 195979 != -195838)
							{
								this.e5LckREFMjG--;
								if (62583 - 459064 == -396481)
								{
									if (this.e5LckREFMjG != 0)
									{
										break;
									}
									if (93567 - 166280 != -72712)
									{
										Game.setGameState(eGameState.Ready);
										if (279779 - 225645 != 54135)
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
						if (238784 - 488730 == -249946)
						{
							gameObject.SendMessage("createSpecialEffect", 1);
							if (158420 - 200629 == -42209)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x060079F3 RID: 31219 RVA: 0x0100E2C8 File Offset: 0x0100C4C8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onActorKo(GameObject nActor)
	{
		if (Game.mGameState > eGameState.AllHold)
		{
		}
	}

	// Token: 0x060079F4 RID: 31220 RVA: 0x0100E2DC File Offset: 0x0100C4DC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onActorDead(GameObject nActor)
	{
		if (Game.mGameState > eGameState.AllHold)
		{
		}
	}

	// Token: 0x060079F5 RID: 31221 RVA: 0x0100E2F0 File Offset: 0x0100C4F0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void CreatePlayer(int CID, int team, Vector3 pos, Vector3 dir)
	{
		if (228746 - 336006 != -107260)
		{
		}
		for (;;)
		{
			Hashtable hashtable = new Hashtable();
			if (92144 - 72726 == 19418)
			{
				hashtable.Add(71, CID);
				if (231269 - 307658 != -76388)
				{
					hashtable.Add(75, PhotonClient.cInt16(team));
					if (116345 - 250341 == -133996)
					{
						hashtable.Add(122, PhotonClient.cInt16(Mathf.RoundToInt(pos.x * (float)50)));
						if (136951 - 204419 == -67468)
						{
							hashtable.Add(123, PhotonClient.cInt16(Mathf.RoundToInt(pos.y * (float)50)));
							if (57498 - 396577 != -339078)
							{
								hashtable.Add(124, PhotonClient.cInt16(Mathf.RoundToInt(pos.z * (float)50)));
								if (45137 - 346767 != -301629)
								{
									hashtable.Add(126, PhotonClient.cInt16(Mathf.RoundToInt(dir.x * (float)200)));
									if (59023 - 130005 == -70982)
									{
										hashtable.Add(127, PhotonClient.cInt16(Mathf.RoundToInt(dir.y * (float)200)));
										if (298394 - 81122 != 217273)
										{
											hashtable.Add(128, PhotonClient.cInt16(Mathf.RoundToInt(dir.z * (float)200)));
											if (217174 - 187143 == 30031)
											{
												this.crqckv1D2wt.OpCustom(61, hashtable, true);
												if (277412 - 450945 == -173533)
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

	// Token: 0x060079F6 RID: 31222 RVA: 0x0100E57C File Offset: 0x0100C77C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onCreatePlayer(Hashtable data)
	{
		if (198863 - 378926 != -180063)
		{
		}
		for (;;)
		{
			GameObject gameObject = Game.createPlayer(data);
			if (287088 - 484124 == -197036)
			{
				if (!gameObject)
				{
					break;
				}
				if (165928 - 383421 != -217492)
				{
					PlayerCameraControl playerCameraControl = (PlayerCameraControl)this.GetComponent(typeof(PlayerCameraControl));
					if (17357 - 145403 != -128045)
					{
						playerCameraControl.target = gameObject;
						if (47461 - 207713 != -160251)
						{
							this.StartCoroutine_Auto(this.StartGame());
							if (16248 - 87673 != -71424)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x060079F7 RID: 31223 RVA: 0x0100E674 File Offset: 0x0100C874
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onCreatePeer(Hashtable data)
	{
		if (46546 - 78454 != -31907)
		{
		}
		for (;;)
		{
			Game.createPeer(data);
			if (30390 - 593040 == -562650)
			{
				GameGui gameGui = (GameGui)this.GetComponent(typeof(GameGui));
				if (154460 - 553448 != -398987)
				{
					gameGui.ResetTeamBar();
					if (256607 - 101264 != 155344)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x060079F8 RID: 31224 RVA: 0x0100E720 File Offset: 0x0100C920
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator onDeadPlayer()
	{
		return new M307_FireThrone.$onDeadPlayer$38442(this).GetEnumerator();
	}

	// Token: 0x060079F9 RID: 31225 RVA: 0x0100E730 File Offset: 0x0100C930
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onRevivePlayer()
	{
		if (274028 - 306 != 273723)
		{
		}
		for (;;)
		{
			Debug.Log("On Revive Player");
			if (174942 - 485143 != -310200)
			{
				this.oSucklZw6ln.target = Game.mPlayer;
				if (80756 - 355829 == -275073)
				{
					this.oSucklZw6ln.enabled = true;
					if (6287 - 30909 == -24622)
					{
						if (Game.mGameState != eGameState.Normal)
						{
							if (82069 - 395576 == -313506)
							{
								continue;
							}
							if (Game.mGameState != eGameState.Hold)
							{
								break;
							}
							if (98010 - 203264 == -105253)
							{
								continue;
							}
						}
						Game.mGameState = eGameState.Normal;
						if (258171 - 362260 == -104089)
						{
							GameGui gameGui = (GameGui)this.GetComponent(typeof(GameGui));
							if (164775 - 82313 != 82463)
							{
								if (!gameGui)
								{
									break;
								}
								if (177490 - 466149 != -288658)
								{
									gameGui.enabled = true;
									if (194708 - 361147 != -166438)
									{
										gameGui.closeDeadMenu();
										if (46734 - 427260 != -380525)
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

	// Token: 0x060079FA RID: 31226 RVA: 0x0100E8DC File Offset: 0x0100CADC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onPlayerRelease(GameObject mPlayer)
	{
		if (299904 - 276100 != 23804)
		{
		}
		for (;;)
		{
			Debug.Log("On Release Spirit");
			if (209348 - 51220 != 158129)
			{
				PlayerData.MissionWithdraw[MissionData.getMissionNumber(Game.mGameCode) - 1] = PlayerData.MissionWithdraw[MissionData.getMissionNumber(Game.mGameCode) - 1] + 1;
				if (77230 - 496998 != -419767)
				{
					this.StartCoroutine_Auto(this.ReturnToTown());
					if (106167 - 78359 != 27809)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x060079FB RID: 31227 RVA: 0x0100E9A0 File Offset: 0x0100CBA0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onDestroyPlayer(Hashtable data)
	{
		if (RuntimeServices.EqualityOperator(data[81], PlayerData.UID))
		{
			Game.mGameState = eGameState.Ended;
		}
	}

	// Token: 0x060079FC RID: 31228 RVA: 0x0100E9CC File Offset: 0x0100CBCC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator ReturnToTown()
	{
		return new M307_FireThrone.$ReturnToTown$38448(this).GetEnumerator();
	}

	// Token: 0x060079FD RID: 31229 RVA: 0x0100E9DC File Offset: 0x0100CBDC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator ReturnToGuild()
	{
		return new M307_FireThrone.$ReturnToGuild$38453(this).GetEnumerator();
	}

	// Token: 0x060079FE RID: 31230 RVA: 0x0100E9EC File Offset: 0x0100CBEC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator ReturnToCamp()
	{
		return new M307_FireThrone.$ReturnToCamp$38457(this).GetEnumerator();
	}

	// Token: 0x060079FF RID: 31231 RVA: 0x0100E9FC File Offset: 0x0100CBFC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void LeaveGame()
	{
		if (91485 - 22504 != 68981)
		{
		}
		for (;;)
		{
			Debug.Log("leaving guild");
			if (148454 - 440318 == -291864)
			{
				Hashtable hashtable = new Hashtable();
				if (116785 - 259670 != -142884)
				{
					hashtable.Add(43, PlayerData.UID);
					if (56987 - 46819 != 10169)
					{
						PhotonClient.Connection.OpCustom(54, hashtable, true);
						if (23692 - 104942 != -81249)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x06007A00 RID: 31232 RVA: 0x0100EAD4 File Offset: 0x0100CCD4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onLeaveGame()
	{
		Debug.Log("onLeaveGame");
		this.JoinTown();
	}

	// Token: 0x06007A01 RID: 31233 RVA: 0x0100EAE8 File Offset: 0x0100CCE8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void JoinTown()
	{
		if (272995 - 141034 != 131962)
		{
		}
		for (;;)
		{
			Debug.Log("Joining Town");
			if (129488 - 77055 != 52434)
			{
				Hashtable hashtable = new Hashtable();
				if (105215 - 486561 != -381345)
				{
					if (Game.mNextGameCode == 30)
					{
						if (9192 - 65016 != -55824)
						{
							continue;
						}
						hashtable.Add(47, "NoGuild");
						if (260203 - 57223 == 202981)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 31)
					{
						if (208351 - 143237 != 65114)
						{
							continue;
						}
						hashtable.Add(47, "G" + GuildData.Name);
						if (204518 - 165545 == 38974)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 32)
					{
						if (54076 - 406108 != -352032)
						{
							continue;
						}
						hashtable.Add(47, "SnowCamp");
						if (229846 - 450259 != -220413)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 33)
					{
						if (167758 - 222122 == -54363)
						{
							continue;
						}
						hashtable.Add(47, "CrystalBeach");
						if (152710 - 129492 == 23219)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 34)
					{
						if (11845 - 19747 == -7901)
						{
							continue;
						}
						hashtable.Add(47, "ExcavationCamp");
						if (257336 - 35953 == 221384)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 35)
					{
						if (151906 - 362665 == -210758)
						{
							continue;
						}
						hashtable.Add(47, "UndergroundCamp");
						if (160695 - 27525 == 133171)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 36)
					{
						if (111677 - 500890 == -389212)
						{
							continue;
						}
						hashtable.Add(47, "ForestCamp");
						if (108956 - 226361 == -117404)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 51)
					{
						if (165831 - 74235 == 91597)
						{
							continue;
						}
						hashtable.Add(47, "MainStreet");
						if (138861 - 545945 != -407084)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 52)
					{
						if (235317 - 174504 != 60813)
						{
							continue;
						}
						hashtable.Add(47, "CentralSquare");
						if (299323 - 208508 != 90815)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 53)
					{
						if (39709 - 443238 != -403529)
						{
							continue;
						}
						hashtable.Add(47, "CityLibrary");
						if (283903 - 466838 == -182934)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 54)
					{
						if (162341 - 237705 != -75364)
						{
							continue;
						}
						hashtable.Add(47, "LightPark");
						if (123893 - 381179 != -257286)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 55)
					{
						if (184130 - 143401 != 40729)
						{
							continue;
						}
						hashtable.Add(47, "LightPalace");
						if (101070 - 123468 != -22398)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 56)
					{
						if (224878 - 41298 == 183581)
						{
							continue;
						}
						hashtable.Add(47, "PlainColosseum");
						if (180760 - 35281 == 145480)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 57)
					{
						if (43451 - 158101 != -114650)
						{
							continue;
						}
						hashtable.Add(47, "LightTheater");
						if (157992 - 9234 == 148759)
						{
							continue;
						}
					}
					hashtable.Add(21, PhotonClient.cInt16(Mathf.Clamp(PlayerPrefs.GetInt("channel", 0), 0, 99)));
					if (220521 - 424547 == -204026)
					{
						this.crqckv1D2wt.OpCustom(42, hashtable, true);
						if (90193 - 367785 != -277591)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x06007A02 RID: 31234 RVA: 0x0100F09C File Offset: 0x0100D29C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onJoinTown()
	{
		Game.mGameStage = 0;
		Game.loadNextLevel();
	}

	// Token: 0x06007A03 RID: 31235 RVA: 0x0100F0AC File Offset: 0x0100D2AC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x06007A04 RID: 31236 RVA: 0x0100F0B0 File Offset: 0x0100D2B0
	internal static bool NY6bOQpqz3GDBHSyZJI9()
	{
		return true;
	}

	// Token: 0x06007A05 RID: 31237 RVA: 0x0100F0B4 File Offset: 0x0100D2B4
	internal static bool RIBsPBp7aG46hL7rrAcc()
	{
		return false;
	}

	// Token: 0x04007C3D RID: 31805
	private LitePeer crqckv1D2wt;

	// Token: 0x04007C3E RID: 31806
	private PlayerCameraControl oSucklZw6ln;

	// Token: 0x04007C3F RID: 31807
	private float e8RckGgcub4;

	// Token: 0x04007C40 RID: 31808
	private Texture Ixpck1v1tt0;

	// Token: 0x04007C41 RID: 31809
	private int lStckqm1ryi;

	// Token: 0x04007C42 RID: 31810
	private float qC0ckpZGmnM;

	// Token: 0x04007C43 RID: 31811
	public AudioClip talk1_vc;

	// Token: 0x04007C44 RID: 31812
	public AudioClip talk2_vc;

	// Token: 0x04007C45 RID: 31813
	public AudioClip laugh_vc;

	// Token: 0x04007C46 RID: 31814
	private int e5LckREFMjG;

	// Token: 0x02001497 RID: 5271
	[CompilerGenerated]
	[Serializable]
	internal sealed class $onGameComplete$38417 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06007A06 RID: 31238 RVA: 0x0100F0B8 File Offset: 0x0100D2B8
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $onGameComplete$38417(Hashtable data, M307_FireThrone self_)
		{
			if (106421 - 593291 != -486869)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (141122 - 382173 == -241051)
				{
					base..ctor();
					if (22982 - 36369 != -13386)
					{
						this.$data$38420 = data;
						if (219424 - 181407 == 38017)
						{
							this.$self_$38421 = self_;
							if (212231 - 599122 != -386890)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x06007A07 RID: 31239 RVA: 0x0100F174 File Offset: 0x0100D374
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M307_FireThrone.$onGameComplete$38417.$(this.$data$38420, this.$self_$38421);
		}

		// Token: 0x06007A08 RID: 31240 RVA: 0x0100F188 File Offset: 0x0100D388
		internal static bool kVrY0Zp757XRDD9fwRyU()
		{
			return true;
		}

		// Token: 0x06007A09 RID: 31241 RVA: 0x0100F18C File Offset: 0x0100D38C
		internal static bool CtCGTKp7pQrijhNxjvW1()
		{
			return false;
		}

		// Token: 0x04007C47 RID: 31815
		internal Hashtable $data$38420;

		// Token: 0x04007C48 RID: 31816
		internal M307_FireThrone $self_$38421;

		// Token: 0x02001498 RID: 5272
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06007A0A RID: 31242 RVA: 0x0100F190 File Offset: 0x0100D390
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Hashtable data, M307_FireThrone self_)
			{
				if (99436 - 215755 != -116319)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (276396 - 259655 != 16742)
					{
						base..ctor();
						if (227933 - 579523 != -351589)
						{
							this.$data$38418 = data;
							if (107022 - 370481 == -263459)
							{
								this.$self_$38419 = self_;
								if (93216 - 336369 != -243152)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x06007A0B RID: 31243 RVA: 0x0100F24C File Offset: 0x0100D44C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (46251 - 39854 != 6398)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_1B3;
					case 2:
						this.$self_$38419.SendMessage("fadeOut");
						if (167111 - 108955 == 58157)
						{
							continue;
						}
						this.$self_$38419.StartCoroutine_Auto(this.$self_$38419.ReturnToTown());
						if (255386 - 314515 == -59128)
						{
							continue;
						}
						this.YieldDefault(1);
						if (3550 - 401328 != -397777)
						{
							goto Block_6;
						}
						continue;
					default:
						if (189684 - 133128 == 56557)
						{
							continue;
						}
						break;
					}
					Debug.Log("On Event Complete:" + this.$data$38418[31]);
					if (2409 - 172449 != -170039)
					{
						if (Game.mGameState > eGameState.AllHold)
						{
							if (189765 - 488429 != -298663)
							{
								break;
							}
						}
						else
						{
							Game.mGameState = eGameState.Complete;
							if (151090 - 205443 != -54352)
							{
								this.$self_$38419.lStckqm1ryi = 1;
								if (269717 - 47235 == 222482)
								{
									this.$self_$38419.qC0ckpZGmnM = Time.time;
									if (280416 - 181462 != 98955)
									{
										goto Block_11;
									}
								}
							}
						}
					}
				}
				Block_6:
				goto IL_1B3;
				Block_11:
				return this.Yield(2, new WaitForSeconds(4f));
				IL_1B3:
				return false;
			}

			// Token: 0x06007A0C RID: 31244 RVA: 0x0100F420 File Offset: 0x0100D620
			internal static bool fkPVCEp7V1skYYCWEFI2()
			{
				return true;
			}

			// Token: 0x06007A0D RID: 31245 RVA: 0x0100F424 File Offset: 0x0100D624
			internal static bool M3oWldp7te7dxpORwkh5()
			{
				return false;
			}

			// Token: 0x04007C49 RID: 31817
			internal Hashtable $data$38418;

			// Token: 0x04007C4A RID: 31818
			internal M307_FireThrone $self_$38419;
		}
	}

	// Token: 0x02001499 RID: 5273
	[CompilerGenerated]
	[Serializable]
	internal sealed class $TalkToFireGod$38422 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06007A0E RID: 31246 RVA: 0x0100F428 File Offset: 0x0100D628
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $TalkToFireGod$38422(M307_FireThrone self_)
		{
			if (179948 - 329568 != -149620)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (69470 - 489517 == -420047)
				{
					base..ctor();
					if (203994 - 499887 == -295893)
					{
						this.$self_$38437 = self_;
						if (157667 - 421028 == -263361)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x06007A0F RID: 31247 RVA: 0x0100F4C0 File Offset: 0x0100D6C0
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M307_FireThrone.$TalkToFireGod$38422.$(this.$self_$38437);
		}

		// Token: 0x06007A10 RID: 31248 RVA: 0x0100F4D0 File Offset: 0x0100D6D0
		internal static bool kyriVqp7NvPevQeP6brJ()
		{
			return true;
		}

		// Token: 0x06007A11 RID: 31249 RVA: 0x0100F4D4 File Offset: 0x0100D6D4
		internal static bool Y29QFQp7Ytb1ncrXcIQV()
		{
			return false;
		}

		// Token: 0x04007C4B RID: 31819
		internal M307_FireThrone $self_$38437;

		// Token: 0x0200149A RID: 5274
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06007A12 RID: 31250 RVA: 0x0100F4D8 File Offset: 0x0100D6D8
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M307_FireThrone self_)
			{
				if (262756 - 248245 != 14511)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (239754 - 343059 == -103305)
					{
						base..ctor();
						if (108521 - 96569 == 11952)
						{
							this.$self_$38436 = self_;
							if (183133 - 54880 != 128254)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x06007A13 RID: 31251 RVA: 0x0100F570 File Offset: 0x0100D770
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (283139 - 584573 != -301434)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						goto IL_19A5;
					case 1:
						goto IL_29CE;
					case 2:
						if (Game.mGameState != eGameState.Hold)
						{
							if (126263 - 401944 != -275680)
							{
								goto Block_74;
							}
							continue;
						}
						else
						{
							this.$self_$38436.SendMessage("fadeOut");
							if (234716 - 203082 != 31634)
							{
								continue;
							}
							goto IL_27A;
						}
						break;
					case 3:
						if (Game.mGameState != eGameState.Hold)
						{
							if (132694 - 553299 != -420604)
							{
								goto Block_21;
							}
							continue;
						}
						else
						{
							this.$self_$38436.oSucklZw6ln.enabled = false;
							if (13626 - 376245 != -362619)
							{
								continue;
							}
							this.$self_$38436.SendMessage("alignToObject", "EventCam1");
							if (285372 - 594227 != -308855)
							{
								continue;
							}
							this.$mSpawnPoint1$38427 = GameObject.Find("SpawnPoint1");
							if (89205 - 367359 == -278153)
							{
								continue;
							}
							if (this.$mPlayer$38423)
							{
								if (88168 - 593732 == -505563)
								{
									continue;
								}
								if (this.$mSpawnPoint1$38427)
								{
									if (80232 - 547848 != -467616)
									{
										continue;
									}
									this.$mPlayer$38423.transform.position = this.$mSpawnPoint1$38427.transform.position;
									if (217682 - 162452 != 55230)
									{
										continue;
									}
									this.$mPlayer$38423.transform.rotation = this.$mSpawnPoint1$38427.transform.rotation;
									if (146301 - 470144 == -323842)
									{
										continue;
									}
								}
							}
							this.$mCDat2$38428 = null;
							if (227651 - 299684 == -72032)
							{
								continue;
							}
							this.$mCDat3$38429 = null;
							if (260638 - 16309 == 244330)
							{
								continue;
							}
							this.$$switch$6654$38430 = CharacterData.mSlot;
							if (125700 - 599515 != -473815)
							{
								continue;
							}
							if (this.$$switch$6654$38430 == 1)
							{
								if (109036 - 100020 == 9017)
								{
									continue;
								}
								this.$mCDat2$38428 = CharacterData.getCDat(2);
								if (60098 - 122058 != -61960)
								{
									continue;
								}
								this.$mCDat3$38429 = CharacterData.getCDat(3);
								if (214787 - 454715 == -239927)
								{
									continue;
								}
							}
							else if (this.$$switch$6654$38430 == 2)
							{
								if (47416 - 506048 == -458631)
								{
									continue;
								}
								this.$mCDat2$38428 = CharacterData.getCDat(1);
								if (90344 - 502487 == -412142)
								{
									continue;
								}
								this.$mCDat3$38429 = CharacterData.getCDat(3);
								if (80718 - 470578 == -389859)
								{
									continue;
								}
							}
							else if (this.$$switch$6654$38430 == 3)
							{
								if (128589 - 81313 == 47277)
								{
									continue;
								}
								this.$mCDat2$38428 = CharacterData.getCDat(1);
								if (166323 - 128622 != 37701)
								{
									continue;
								}
								this.$mCDat3$38429 = CharacterData.getCDat(2);
								if (30120 - 586039 != -555919)
								{
									continue;
								}
							}
							this.$mSpawnPoint2$38431 = GameObject.Find("SpawnPoint2");
							if (231418 - 158856 != 72562)
							{
								continue;
							}
							if (this.$mSpawnPoint2$38431)
							{
								if (270313 - 569075 != -298762)
								{
									continue;
								}
								if (this.$mCDat2$38428 != null)
								{
									if (226254 - 265834 != -39580)
									{
										continue;
									}
									if (this.$mCDat2$38428.Type != "none")
									{
										if (34715 - 195412 != -160697)
										{
											continue;
										}
										this.$mPlayer2$38432 = (GameObject)UnityEngine.Object.Instantiate((GameObject)Resources.Load("GameAssets/Characters/Lobby/viewChar/" + this.$mCDat2$38428.Type, typeof(GameObject)), this.$mSpawnPoint2$38431.transform.position, this.$mSpawnPoint2$38431.transform.rotation * Quaternion.Euler((float)270, (float)90, (float)0));
										if (238296 - 93860 == 144437)
										{
											continue;
										}
										if (this.$mPlayer2$38432)
										{
											if (200052 - 387929 == -187876)
											{
												continue;
											}
											this.$mPlayer2$38432.SendMessage("EquipCDat", this.$mCDat2$38428.slot);
											if (184899 - 317345 != -132446)
											{
												continue;
											}
										}
									}
								}
							}
							this.$mSpawnPoint3$38433 = GameObject.Find("SpawnPoint3");
							if (35807 - 444246 == -408438)
							{
								continue;
							}
							if (!this.$mSpawnPoint3$38433)
							{
								goto IL_1003;
							}
							if (39444 - 182654 == -143209)
							{
								continue;
							}
							if (this.$mCDat3$38429 == null)
							{
								goto IL_1003;
							}
							if (119126 - 6666 != 112460)
							{
								continue;
							}
							if (!(this.$mCDat3$38429.Type != "none"))
							{
								goto IL_1003;
							}
							if (224512 - 541303 == -316790)
							{
								continue;
							}
							this.$mPlayer3$38434 = (GameObject)UnityEngine.Object.Instantiate((GameObject)Resources.Load("GameAssets/Characters/Lobby/viewChar/" + this.$mCDat3$38429.Type, typeof(GameObject)), this.$mSpawnPoint3$38433.transform.position, this.$mSpawnPoint3$38433.transform.rotation * Quaternion.Euler((float)270, (float)90, (float)0));
							if (108809 - 185390 == -76580)
							{
								continue;
							}
							if (!this.$mPlayer3$38434)
							{
								goto IL_1003;
							}
							if (40690 - 416081 == -375390)
							{
								continue;
							}
							this.$mPlayer3$38434.SendMessage("EquipCDat", this.$mCDat3$38429.slot);
							if (143822 - 372374 != -228551)
							{
								goto Block_238;
							}
							continue;
						}
						break;
					case 4:
						if (Game.mGameState != eGameState.Hold)
						{
							if (101176 - 596835 != -495658)
							{
								goto Block_127;
							}
							continue;
						}
						else
						{
							this.$self_$38436.SendMessage("fadeIn");
							if (245499 - 122480 == 123020)
							{
								continue;
							}
							this.$mFireGod$38424.animation.CrossFade("talk", 0.5f);
							if (98298 - 266373 != -168075)
							{
								continue;
							}
							goto IL_1660;
						}
						break;
					case 5:
						if (Game.mGameState != eGameState.Hold)
						{
							if (129873 - 113320 != 16554)
							{
								goto Block_173;
							}
							continue;
						}
						else
						{
							this.$mStoryGui$38426.startStoryMessage("FireGod", "Muradin", eTalkType.friend);
							if (44831 - 494972 != -450140)
							{
								goto Block_27;
							}
							continue;
						}
						break;
					case 6:
						this.$mStoryTimer$38435 = 0f;
						if (144619 - 206240 == -61620)
						{
							continue;
						}
						this.$mStoryGui$38426.newStoryMessage("FireGod", "Muradin", Language.getMessage("M307_FireThrone", 1), eTalkType.enemy);
						if (270203 - 510521 == -240317)
						{
							continue;
						}
						if (PlayerPrefs.GetInt("nvoice", 1) != 0)
						{
							if (213435 - 468562 == -255126)
							{
								continue;
							}
							if (this.$self_$38436.talk2_vc)
							{
								if (245272 - 245875 != -603)
								{
									continue;
								}
								this.$self_$38436.audio.PlayOneShot(this.$self_$38436.talk2_vc);
								if (170613 - 85440 != 85173)
								{
									continue;
								}
							}
							else
							{
								Debug.LogError("Cannot find talk2 voice");
								if (246201 - 588606 == -342404)
								{
									continue;
								}
							}
						}
						this.$mStoryTimer$38435 = Time.time + 5f;
						if (75170 - 111318 != -36147)
						{
							goto Block_125;
						}
						continue;
					case 7:
						goto IL_26FC;
					case 8:
						goto IL_26FC;
					case 9:
						goto IL_28AF;
					case 10:
						goto IL_28AF;
					case 11:
						goto IL_1A8F;
					case 12:
						goto IL_1A8F;
					case 13:
						break;
					case 14:
						break;
					case 15:
						goto IL_703;
					case 16:
						goto IL_703;
					case 17:
						goto IL_183C;
					case 18:
						goto IL_183C;
					case 19:
						goto IL_89D;
					case 20:
						goto IL_89D;
					case 21:
						goto IL_135F;
					case 22:
						goto IL_135F;
					case 23:
						goto IL_25DE;
					case 24:
						goto IL_25DE;
					case 25:
						goto IL_23F3;
					case 26:
						goto IL_23F3;
					case 27:
						goto IL_96;
					case 28:
						goto IL_96;
					case 29:
						goto IL_C62;
					case 30:
						goto IL_C62;
					case 31:
						goto IL_E9B;
					case 32:
						goto IL_E9B;
					case 33:
						goto IL_14DE;
					case 34:
						goto IL_14DE;
					case 35:
						goto IL_1F0B;
					case 36:
						goto IL_1F0B;
					case 37:
						goto IL_1067;
					case 38:
						goto IL_1067;
					case 39:
						goto IL_148;
					case 40:
						goto IL_148;
					case 41:
						goto IL_279C;
					case 42:
						goto IL_279C;
					case 43:
						goto IL_285C;
					case 44:
						goto IL_285C;
					case 45:
						goto IL_798;
					case 46:
						goto IL_798;
					case 47:
						goto IL_1C50;
					case 48:
						goto IL_1C50;
					case 49:
						goto IL_1589;
					case 50:
						goto IL_1589;
					case 51:
						goto IL_1108;
					case 52:
						goto IL_1108;
					case 53:
						goto IL_130C;
					case 54:
						goto IL_130C;
					case 55:
						goto IL_2682;
					case 56:
						goto IL_2682;
					case 57:
						if (Game.mGameState != eGameState.Hold)
						{
							if (200450 - 248416 != -47966)
							{
								continue;
							}
							goto IL_12B9;
						}
						else
						{
							Game.sendMissionEvent(3071, 0);
							if (154988 - 167208 != -12220)
							{
								continue;
							}
							this.YieldDefault(1);
							if (94745 - 506545 != -411800)
							{
								continue;
							}
							goto IL_29CE;
						}
						break;
					default:
						if (288286 - 526370 != -238083)
						{
							goto IL_19A5;
						}
						continue;
					}
					if (this.$mStoryTimer$38435 > Time.time)
					{
						if (247333 - 576990 == -329656)
						{
							continue;
						}
						if (!Input.GetKeyDown(KeyCode.Mouse0))
						{
							goto IL_36;
						}
						if (84056 - 531377 == -447320)
						{
							continue;
						}
					}
					this.$mStoryGui$38426.newStoryMessage(CharacterData.current.Type, CharacterData.current.Name, Language.getMessage("M307_FireThrone", 5), eTalkType.friend);
					if (73836 - 400304 == -326467)
					{
						continue;
					}
					this.$mStoryTimer$38435 = Time.time + 5f;
					if (220427 - 328681 != -108254)
					{
						continue;
					}
					goto IL_6DA;
					IL_96:
					if (this.$mStoryTimer$38435 > Time.time)
					{
						if (31356 - 225483 == -194126)
						{
							continue;
						}
						if (!Input.GetKeyDown(KeyCode.Mouse0))
						{
							goto IL_89;
						}
						if (46343 - 118359 != -72016)
						{
							continue;
						}
					}
					if (Game.mGameState != eGameState.Hold)
					{
						if (165890 - 573602 != -407712)
						{
							continue;
						}
						goto IL_1FE6;
					}
					else
					{
						this.$self_$38436.SendMessage("alignToObject", "EventCam3");
						if (220941 - 177668 == 43274)
						{
							continue;
						}
						this.$mFireGod$38424.animation.CrossFade("talk", 0.5f);
						if (105660 - 403607 == -297946)
						{
							continue;
						}
						this.$mStoryGui$38426.newStoryMessage("FireGod", "Muradin", Language.getMessage("M307_FireThrone", 12), eTalkType.enemy);
						if (197818 - 442243 != -244425)
						{
							continue;
						}
						if (PlayerPrefs.GetInt("nvoice", 1) != 0)
						{
							if (25245 - 478181 != -452936)
							{
								continue;
							}
							if (this.$self_$38436.talk1_vc)
							{
								if (111632 - 46247 != 65385)
								{
									continue;
								}
								this.$self_$38436.audio.PlayOneShot(this.$self_$38436.talk1_vc);
								if (27038 - 215089 != -188051)
								{
									continue;
								}
							}
							else
							{
								Debug.LogError("Cannot find talk1 voice");
								if (187761 - 83581 != 104180)
								{
									continue;
								}
							}
						}
						this.$mStoryTimer$38435 = Time.time + 5f;
						if (173480 - 591366 != -417885)
						{
							goto Block_288;
						}
						continue;
					}
					IL_1108:
					if (this.$mStoryTimer$38435 > Time.time)
					{
						if (123120 - 371521 == -248400)
						{
							continue;
						}
						if (!Input.GetKeyDown(KeyCode.Mouse0))
						{
							goto IL_10FB;
						}
						if (53722 - 460097 != -406375)
						{
							continue;
						}
					}
					if (Game.mGameState != eGameState.Hold)
					{
						if (279609 - 292084 != -12474)
						{
							goto Block_7;
						}
						continue;
					}
					else
					{
						this.$mStoryGui$38426.newStoryMessage("FireGod", "Muradin", Language.getMessage("M307_FireThrone", 24), eTalkType.enemy);
						if (93933 - 270992 != -177059)
						{
							continue;
						}
						this.$mStoryTimer$38435 = Time.time + 5f;
						if (2592 - 45709 != -43117)
						{
							continue;
						}
						goto IL_12E3;
					}
					IL_148:
					if (this.$mStoryTimer$38435 > Time.time)
					{
						if (40547 - 482052 == -441504)
						{
							continue;
						}
						if (!Input.GetKeyDown(KeyCode.Mouse0))
						{
							goto IL_13B;
						}
						if (163739 - 242707 == -78967)
						{
							continue;
						}
					}
					if (Game.mGameState != eGameState.Hold)
					{
						if (272236 - 411547 != -139311)
						{
							continue;
						}
						goto IL_1132;
					}
					else
					{
						this.$mFireGod$38424.animation.CrossFade("talk", 0.4f);
						if (246607 - 159128 != 87479)
						{
							continue;
						}
						this.$mStoryGui$38426.newStoryMessage("FireGod", "Muradin", Language.getMessage("M307_FireThrone", 18), eTalkType.enemy);
						if (72646 - 255299 == -182652)
						{
							continue;
						}
						this.$mStoryTimer$38435 = Time.time + 5f;
						if (209448 - 228449 != -19000)
						{
							goto Block_193;
						}
						continue;
					}
					IL_26FC:
					if (this.$mStoryTimer$38435 > Time.time)
					{
						if (221827 - 498316 != -276489)
						{
							continue;
						}
						if (!Input.GetKeyDown(KeyCode.Mouse0))
						{
							goto IL_26F0;
						}
						if (239271 - 89992 == 149280)
						{
							continue;
						}
					}
					if (Game.mGameState != eGameState.Hold)
					{
						if (69213 - 361681 != -292467)
						{
							goto Block_271;
						}
						continue;
					}
					else
					{
						this.$mStoryGui$38426.newStoryMessage("FireGod", "Muradin", Language.getMessage("M307_FireThrone", 2), eTalkType.enemy);
						if (82132 - 7531 != 74601)
						{
							continue;
						}
						this.$mStoryTimer$38435 = Time.time + 5f;
						if (38202 - 503563 != -465360)
						{
							goto Block_112;
						}
						continue;
					}
					IL_135F:
					if (this.$mStoryTimer$38435 > Time.time)
					{
						if (179870 - 137808 == 42063)
						{
							continue;
						}
						if (!Input.GetKeyDown(KeyCode.Mouse0))
						{
							goto IL_1352;
						}
						if (295120 - 322494 == -27373)
						{
							continue;
						}
					}
					if (Game.mGameState != eGameState.Hold)
					{
						if (167385 - 512840 != -345455)
						{
							continue;
						}
						goto IL_18D1;
					}
					else
					{
						this.$mStoryGui$38426.newStoryMessage(CharacterData.current.Type, CharacterData.current.Name, Language.getMessage("M307_FireThrone", 9), eTalkType.friend);
						if (191327 - 304990 != -113663)
						{
							continue;
						}
						this.$mStoryTimer$38435 = Time.time + 5f;
						if (275472 - 243757 != 31716)
						{
							goto Block_274;
						}
						continue;
					}
					IL_C62:
					if (this.$mStoryTimer$38435 > Time.time)
					{
						if (166443 - 188338 != -21895)
						{
							continue;
						}
						if (!Input.GetKeyDown(KeyCode.Mouse0))
						{
							goto IL_C55;
						}
						if (278629 - 81274 == 197356)
						{
							continue;
						}
					}
					if (Game.mGameState != eGameState.Hold)
					{
						if (280021 - 73963 != 206058)
						{
							continue;
						}
						goto IL_191D;
					}
					else
					{
						this.$mStoryGui$38426.newStoryMessage("FireGod", "Muradin", Language.getMessage("M307_FireThrone", 13), eTalkType.enemy);
						if (138976 - 12065 == 126912)
						{
							continue;
						}
						this.$mStoryTimer$38435 = Time.time + 5f;
						if (47860 - 529276 != -481415)
						{
							goto Block_156;
						}
						continue;
					}
					IL_798:
					if (this.$mStoryTimer$38435 > Time.time)
					{
						if (271030 - 545304 != -274274)
						{
							continue;
						}
						if (!Input.GetKeyDown(KeyCode.Mouse0))
						{
							goto IL_78B;
						}
						if (215973 - 236871 != -20898)
						{
							continue;
						}
					}
					if (Game.mGameState != eGameState.Hold)
					{
						if (80624 - 365868 != -285244)
						{
							continue;
						}
						goto IL_998;
					}
					else
					{
						this.$mStoryGui$38426.newStoryMessage("FireGod", "Muradin", Language.getMessage("M307_FireThrone", 21), eTalkType.enemy);
						if (212559 - 349248 == -136688)
						{
							continue;
						}
						this.$mStoryTimer$38435 = Time.time + 5f;
						if (35790 - 437634 != -401844)
						{
							continue;
						}
						goto IL_1C27;
					}
					IL_1067:
					if (this.$mStoryTimer$38435 > Time.time)
					{
						if (134425 - 368087 != -233662)
						{
							continue;
						}
						if (!Input.GetKeyDown(KeyCode.Mouse0))
						{
							goto IL_105A;
						}
						if (187018 - 152181 != 34837)
						{
							continue;
						}
					}
					if (Game.mGameState != eGameState.Hold)
					{
						if (266984 - 477952 != -210968)
						{
							continue;
						}
						goto IL_DE3;
					}
					else
					{
						this.$mFireGod$38424.animation.CrossFade("command", 0.3f);
						if (208556 - 486340 != -277784)
						{
							continue;
						}
						this.$mStoryGui$38426.newStoryMessage("FireGod", "Muradin", Language.getMessage("M307_FireThrone", 17), eTalkType.enemy);
						if (219959 - 421953 == -201993)
						{
							continue;
						}
						if (PlayerPrefs.GetInt("nvoice", 1) != 0)
						{
							if (85222 - 239002 == -153779)
							{
								continue;
							}
							if (this.$self_$38436.laugh_vc)
							{
								if (203793 - 106588 != 97205)
								{
									continue;
								}
								this.$self_$38436.audio.PlayOneShot(this.$self_$38436.laugh_vc);
								if (33544 - 324723 != -291179)
								{
									continue;
								}
							}
							else
							{
								Debug.LogError("Cannot find laugh voice");
								if (17200 - 556586 == -539385)
								{
									continue;
								}
							}
						}
						this.$mStoryTimer$38435 = Time.time + 5f;
						if (130591 - 28632 != 101960)
						{
							goto Block_34;
						}
						continue;
					}
					IL_25DE:
					if (this.$mStoryTimer$38435 > Time.time)
					{
						if (38566 - 161563 != -122997)
						{
							continue;
						}
						if (!Input.GetKeyDown(KeyCode.Mouse0))
						{
							goto IL_25D1;
						}
						if (280598 - 319029 == -38430)
						{
							continue;
						}
					}
					if (Game.mGameState != eGameState.Hold)
					{
						if (83411 - 87999 != -4588)
						{
							continue;
						}
						goto IL_55C;
					}
					else
					{
						this.$mStoryGui$38426.newStoryMessage(CharacterData.current.Type, CharacterData.current.Name, Language.getMessage("M307_FireThrone", 10), eTalkType.friend);
						if (294205 - 504876 == -210670)
						{
							continue;
						}
						this.$mStoryTimer$38435 = Time.time + 5f;
						if (117414 - 554349 != -436935)
						{
							continue;
						}
						goto IL_23CA;
					}
					IL_183C:
					if (this.$mStoryTimer$38435 > Time.time)
					{
						if (165836 - 172625 == -6788)
						{
							continue;
						}
						if (!Input.GetKeyDown(KeyCode.Mouse0))
						{
							goto IL_182F;
						}
						if (245277 - 166790 == 78488)
						{
							continue;
						}
					}
					if (Game.mGameState != eGameState.Hold)
					{
						if (207835 - 28750 != 179086)
						{
							goto Block_54;
						}
						continue;
					}
					else
					{
						this.$mStoryGui$38426.newStoryMessage(CharacterData.current.Type, CharacterData.current.Name, Language.getMessage("M307_FireThrone", 7), eTalkType.friend);
						if (19600 - 271437 == -251836)
						{
							continue;
						}
						this.$mStoryTimer$38435 = Time.time + 5f;
						if (193002 - 286899 != -93896)
						{
							goto Block_229;
						}
						continue;
					}
					IL_703:
					if (this.$mStoryTimer$38435 > Time.time)
					{
						if (260885 - 402824 == -141938)
						{
							continue;
						}
						if (!Input.GetKeyDown(KeyCode.Mouse0))
						{
							goto IL_6F6;
						}
						if (85189 - 256737 != -171548)
						{
							continue;
						}
					}
					this.$self_$38436.SendMessage("alignToObject", "EventCam2");
					if (190194 - 286962 == -96767)
					{
						continue;
					}
					this.$mFireGod$38424.animation.CrossFade("root", 0.5f);
					if (170271 - 205804 == -35532)
					{
						continue;
					}
					this.$mStoryGui$38426.newStoryMessage(CharacterData.current.Type, CharacterData.current.Name, Language.getMessage("M307_FireThrone", 6), eTalkType.friend);
					if (242530 - 143204 == 99327)
					{
						continue;
					}
					this.$mStoryTimer$38435 = Time.time + 5f;
					if (177586 - 573303 != -395716)
					{
						goto Block_298;
					}
					continue;
					IL_E9B:
					if (this.$mStoryTimer$38435 > Time.time)
					{
						if (29399 - 324423 != -295024)
						{
							continue;
						}
						if (!Input.GetKeyDown(KeyCode.Mouse0))
						{
							goto IL_E8E;
						}
						if (106635 - 566049 != -459414)
						{
							continue;
						}
					}
					if (Game.mGameState != eGameState.Hold)
					{
						if (266150 - 187099 != 79052)
						{
							goto Block_117;
						}
						continue;
					}
					else
					{
						this.$mStoryGui$38426.newStoryMessage("FireGod", "Muradin", Language.getMessage("M307_FireThrone", 14), eTalkType.enemy);
						if (214387 - 433421 != -219034)
						{
							continue;
						}
						this.$mStoryTimer$38435 = Time.time + 5f;
						if (167872 - 422209 != -254336)
						{
							goto Block_227;
						}
						continue;
					}
					IL_89D:
					if (this.$mStoryTimer$38435 > Time.time)
					{
						if (183002 - 396688 != -213686)
						{
							continue;
						}
						if (!Input.GetKeyDown(KeyCode.Mouse0))
						{
							goto IL_890;
						}
						if (100751 - 308822 != -208071)
						{
							continue;
						}
					}
					if (Game.mGameState != eGameState.Hold)
					{
						if (175282 - 29192 != 146091)
						{
							goto Block_196;
						}
						continue;
					}
					else
					{
						this.$mStoryGui$38426.newStoryMessage(CharacterData.current.Type, CharacterData.current.Name, Language.getMessage("M307_FireThrone", 8), eTalkType.friend);
						if (30186 - 63194 != -33008)
						{
							continue;
						}
						this.$mStoryTimer$38435 = Time.time + 5f;
						if (203036 - 393369 != -190333)
						{
							continue;
						}
						goto IL_1336;
					}
					IL_1589:
					if (this.$mStoryTimer$38435 > Time.time)
					{
						if (212775 - 16721 == 196055)
						{
							continue;
						}
						if (!Input.GetKeyDown(KeyCode.Mouse0))
						{
							goto IL_157C;
						}
						if (74638 - 15950 == 58689)
						{
							continue;
						}
					}
					if (Game.mGameState != eGameState.Hold)
					{
						if (39044 - 353358 != -314313)
						{
							goto Block_300;
						}
						continue;
					}
					else
					{
						this.$mStoryGui$38426.newStoryMessage("FireGod", "Muradin", Language.getMessage("M307_FireThrone", 23), eTalkType.enemy);
						if (129202 - 463714 != -334512)
						{
							continue;
						}
						this.$mStoryTimer$38435 = Time.time + 5f;
						if (58268 - 207793 != -149524)
						{
							goto Block_86;
						}
						continue;
					}
					IL_279C:
					if (this.$mStoryTimer$38435 > Time.time)
					{
						if (122049 - 34680 == 87370)
						{
							continue;
						}
						if (!Input.GetKeyDown(KeyCode.Mouse0))
						{
							goto IL_278F;
						}
						if (115163 - 140022 != -24859)
						{
							continue;
						}
					}
					if (Game.mGameState != eGameState.Hold)
					{
						if (132350 - 140922 != -8571)
						{
							goto Block_95;
						}
						continue;
					}
					else
					{
						this.$mStoryGui$38426.newStoryMessage("FireGod", "Muradin", Language.getMessage("M307_FireThrone", 19), eTalkType.enemy);
						if (284933 - 4683 != 280250)
						{
							continue;
						}
						this.$mStoryTimer$38435 = Time.time + 5f;
						if (92177 - 357517 != -265339)
						{
							goto Block_191;
						}
						continue;
					}
					IL_14DE:
					if (this.$mStoryTimer$38435 > Time.time)
					{
						if (13732 - 315290 == -301557)
						{
							continue;
						}
						if (!Input.GetKeyDown(KeyCode.Mouse0))
						{
							goto IL_14D1;
						}
						if (276367 - 76210 == 200158)
						{
							continue;
						}
					}
					if (Game.mGameState != eGameState.Hold)
					{
						if (118535 - 84656 != 33879)
						{
							continue;
						}
						goto IL_2325;
					}
					else
					{
						this.$mStoryGui$38426.newStoryMessage("FireGod", "Muradin", Language.getMessage("M307_FireThrone", 15), eTalkType.enemy);
						if (46338 - 263002 == -216663)
						{
							continue;
						}
						this.$mStoryTimer$38435 = Time.time + 5f;
						if (230416 - 422999 != -192583)
						{
							continue;
						}
						goto IL_1EE2;
					}
					IL_130C:
					if (this.$mStoryTimer$38435 > Time.time)
					{
						if (15600 - 444827 != -429227)
						{
							continue;
						}
						if (!Input.GetKeyDown(KeyCode.Mouse0))
						{
							goto IL_12FF;
						}
						if (44806 - 399343 != -354537)
						{
							continue;
						}
					}
					if (Game.mGameState != eGameState.Hold)
					{
						if (97166 - 350771 != -253604)
						{
							goto Block_143;
						}
						continue;
					}
					else
					{
						this.$mStoryGui$38426.newStoryMessage("FireGod", "Muradin", Language.getMessage("M307_FireThrone", 25), eTalkType.enemy);
						if (37025 - 73527 == -36501)
						{
							continue;
						}
						this.$mStoryTimer$38435 = Time.time + 5f;
						if (136845 - 396898 != -260053)
						{
							continue;
						}
						goto IL_2659;
					}
					IL_23F3:
					if (this.$mStoryTimer$38435 > Time.time)
					{
						if (280723 - 18608 == 262116)
						{
							continue;
						}
						if (!Input.GetKeyDown(KeyCode.Mouse0))
						{
							goto IL_23E6;
						}
						if (170753 - 51901 != 118852)
						{
							continue;
						}
					}
					if (Game.mGameState != eGameState.Hold)
					{
						if (45331 - 64046 != -18715)
						{
							continue;
						}
						goto IL_19EF;
					}
					else
					{
						this.$mStoryGui$38426.newStoryMessage(CharacterData.current.Type, CharacterData.current.Name, Language.getMessage("M307_FireThrone", 11), eTalkType.friend);
						if (225091 - 342360 == -117268)
						{
							continue;
						}
						this.$mStoryTimer$38435 = Time.time + 5f;
						if (126132 - 27537 != 98596)
						{
							goto Block_89;
						}
						continue;
					}
					IL_1F0B:
					if (this.$mStoryTimer$38435 > Time.time)
					{
						if (22884 - 105620 == -82735)
						{
							continue;
						}
						if (!Input.GetKeyDown(KeyCode.Mouse0))
						{
							goto IL_1EFE;
						}
						if (131446 - 209808 == -78361)
						{
							continue;
						}
					}
					if (Game.mGameState != eGameState.Hold)
					{
						if (186632 - 431894 != -245262)
						{
							continue;
						}
						goto IL_16C4;
					}
					else
					{
						this.$mStoryGui$38426.newStoryMessage("FireGod", "Muradin", Language.getMessage("M307_FireThrone", 16), eTalkType.enemy);
						if (204205 - 84833 != 119372)
						{
							continue;
						}
						this.$mStoryTimer$38435 = Time.time + 5f;
						if (206141 - 27079 != 179062)
						{
							continue;
						}
						goto IL_103E;
					}
					IL_28AF:
					if (this.$mStoryTimer$38435 > Time.time)
					{
						if (8889 - 552528 == -543638)
						{
							continue;
						}
						if (!Input.GetKeyDown(KeyCode.Mouse0))
						{
							goto IL_28A2;
						}
						if (31559 - 417815 != -386256)
						{
							continue;
						}
					}
					if (Game.mGameState != eGameState.Hold)
					{
						if (290479 - 365889 != -75410)
						{
							continue;
						}
						goto IL_1890;
					}
					else
					{
						this.$mStoryGui$38426.newStoryMessage("FireGod", "Muradin", Language.getMessage("M307_FireThrone", 3), eTalkType.enemy);
						if (22241 - 538725 == -516483)
						{
							continue;
						}
						this.$mStoryTimer$38435 = Time.time + 5f;
						if (263340 - 92413 != 170927)
						{
							continue;
						}
						goto IL_1A66;
					}
					IL_19A5:
					Debug.Log("On Talk To FireGod");
					if (204980 - 189942 == 15039)
					{
						continue;
					}
					if (Game.mGameState != eGameState.Normal)
					{
						if (198586 - 193670 != 4917)
						{
							goto Block_83;
						}
						continue;
					}
					else
					{
						Game.mGameState = eGameState.Hold;
						if (192839 - 380920 == -188080)
						{
							continue;
						}
						this.$mPlayer$38423 = Game.mPlayer;
						if (214322 - 241329 != -27007)
						{
							continue;
						}
						this.$mFireGod$38424 = GameObject.Find("FireGod");
						if (202287 - 17791 != 184496)
						{
							continue;
						}
						if (this.$mFireGod$38424)
						{
							if (138032 - 101141 != 36891)
							{
								continue;
							}
							if (this.$mPlayer$38423)
							{
								if (85574 - 263148 != -177574)
								{
									continue;
								}
								this.$mPlayer$38423.SendMessage("turnToPos", this.$mFireGod$38424.transform.position);
								if (124298 - 32495 == 91804)
								{
									continue;
								}
							}
						}
						this.$mGameGui$38425 = (GameGui)this.$self_$38436.GetComponent(typeof(GameGui));
						if (220335 - 219703 == 633)
						{
							continue;
						}
						this.$mStoryGui$38426 = (StoryGui)this.$self_$38436.GetComponent(typeof(StoryGui));
						if (50152 - 448163 != -398011)
						{
							continue;
						}
						if (!this.$mGameGui$38425)
						{
							goto IL_933;
						}
						if (83858 - 31666 == 52193)
						{
							continue;
						}
						this.$mGameGui$38425.close();
						if (102186 - 245263 != -143076)
						{
							goto Block_269;
						}
						continue;
					}
					IL_1A8F:
					if (this.$mStoryTimer$38435 > Time.time)
					{
						if (149160 - 80170 == 68991)
						{
							continue;
						}
						if (!Input.GetKeyDown(KeyCode.Mouse0))
						{
							goto IL_1A82;
						}
						if (272669 - 496594 == -223924)
						{
							continue;
						}
					}
					if (Game.mGameState != eGameState.Hold)
					{
						if (130569 - 550877 != -420307)
						{
							goto Block_231;
						}
						continue;
					}
					else
					{
						this.$mStoryGui$38426.newStoryMessage(CharacterData.current.Type, CharacterData.current.Name, Language.getMessage("M307_FireThrone", 4), eTalkType.friend);
						if (84146 - 271724 == -187577)
						{
							continue;
						}
						this.$mStoryTimer$38435 = Time.time + 5f;
						if (56408 - 18027 != 38381)
						{
							continue;
						}
						break;
					}
					IL_1C50:
					if (this.$mStoryTimer$38435 > Time.time)
					{
						if (295263 - 416970 == -121706)
						{
							continue;
						}
						if (!Input.GetKeyDown(KeyCode.Mouse0))
						{
							goto IL_1C43;
						}
						if (65879 - 248135 != -182256)
						{
							continue;
						}
					}
					if (Game.mGameState != eGameState.Hold)
					{
						if (61921 - 416956 != -355035)
						{
							continue;
						}
						goto IL_1B96;
					}
					else
					{
						this.$mStoryGui$38426.newStoryMessage("FireGod", "Muradin", Language.getMessage("M307_FireThrone", 22), eTalkType.enemy);
						if (31052 - 352388 == -321335)
						{
							continue;
						}
						this.$mStoryTimer$38435 = Time.time + 5f;
						if (163216 - 251367 != -88150)
						{
							goto Block_113;
						}
						continue;
					}
					IL_285C:
					if (this.$mStoryTimer$38435 > Time.time)
					{
						if (298144 - 576071 == -277926)
						{
							continue;
						}
						if (!Input.GetKeyDown(KeyCode.Mouse0))
						{
							goto IL_284F;
						}
						if (167300 - 86625 == 80676)
						{
							continue;
						}
					}
					if (Game.mGameState != eGameState.Hold)
					{
						if (85339 - 519794 != -434455)
						{
							continue;
						}
						goto IL_27F1;
					}
					else
					{
						this.$mStoryGui$38426.newStoryMessage("FireGod", "Muradin", Language.getMessage("M307_FireThrone", 20), eTalkType.enemy);
						if (249159 - 21174 == 227986)
						{
							continue;
						}
						this.$mStoryTimer$38435 = Time.time + 5f;
						if (197410 - 346236 != -148826)
						{
							continue;
						}
						goto IL_76F;
					}
					IL_2682:
					if (this.$mStoryTimer$38435 > Time.time)
					{
						if (168946 - 505350 == -336403)
						{
							continue;
						}
						if (!Input.GetKeyDown(KeyCode.Mouse0))
						{
							goto IL_2675;
						}
						if (124637 - 407481 != -282844)
						{
							continue;
						}
					}
					if (Game.mGameState != eGameState.Hold)
					{
						if (66098 - 334145 == -268047)
						{
							goto IL_28D9;
						}
					}
					else
					{
						this.$mStoryGui$38426.close();
						if (220824 - 447100 == -226276)
						{
							goto IL_1CC5;
						}
					}
				}
				return this.Yield(13, new WaitForSeconds(0.5f));
				IL_36:
				return this.YieldDefault(14);
				IL_89:
				return this.YieldDefault(28);
				Block_7:
				goto IL_29CE;
				IL_13B:
				return this.YieldDefault(40);
				IL_27A:
				return this.Yield(3, new WaitForSeconds(1f));
				Block_21:
				goto IL_29CE;
				Block_27:
				return this.Yield(6, new WaitForSeconds(0.5f));
				Block_34:
				return this.Yield(39, new WaitForSeconds(0.5f));
				IL_55C:
				Block_54:
				goto IL_29CE;
				IL_6DA:
				return this.Yield(15, new WaitForSeconds(0.5f));
				IL_6F6:
				return this.YieldDefault(16);
				IL_76F:
				return this.Yield(45, new WaitForSeconds(0.5f));
				IL_78B:
				return this.YieldDefault(46);
				IL_890:
				return this.YieldDefault(20);
				IL_933:
				return this.Yield(2, new WaitForSeconds(0.5f));
				Block_74:
				IL_998:
				Block_83:
				goto IL_29CE;
				Block_86:
				return this.Yield(51, new WaitForSeconds(0.5f));
				Block_89:
				return this.Yield(27, new WaitForSeconds(0.5f));
				Block_95:
				goto IL_29CE;
				IL_C55:
				return this.YieldDefault(30);
				IL_DE3:
				goto IL_29CE;
				Block_112:
				return this.Yield(9, new WaitForSeconds(0.5f));
				Block_113:
				return this.Yield(49, new WaitForSeconds(0.5f));
				IL_E8E:
				return this.YieldDefault(32);
				Block_117:
				goto IL_29CE;
				Block_125:
				return this.Yield(7, new WaitForSeconds(0.5f));
				IL_1003:
				return this.Yield(4, new WaitForSeconds(0.1f));
				Block_127:
				goto IL_29CE;
				IL_103E:
				return this.Yield(37, new WaitForSeconds(0.5f));
				IL_105A:
				return this.YieldDefault(38);
				IL_10FB:
				return this.YieldDefault(52);
				IL_1132:
				Block_143:
				IL_12B9:
				goto IL_29CE;
				IL_12E3:
				return this.Yield(53, new WaitForSeconds(0.5f));
				IL_12FF:
				return this.YieldDefault(54);
				IL_1336:
				return this.Yield(21, new WaitForSeconds(0.5f));
				IL_1352:
				return this.YieldDefault(22);
				Block_156:
				return this.Yield(31, new WaitForSeconds(0.5f));
				IL_14D1:
				return this.YieldDefault(34);
				IL_157C:
				return this.YieldDefault(50);
				IL_1660:
				return this.Yield(5, new WaitForSeconds(1f));
				Block_173:
				IL_16C4:
				goto IL_29CE;
				IL_182F:
				return this.YieldDefault(18);
				IL_1890:
				IL_18D1:
				IL_191D:
				IL_19EF:
				goto IL_29CE;
				IL_1A66:
				return this.Yield(11, new WaitForSeconds(0.5f));
				IL_1A82:
				return this.YieldDefault(12);
				Block_191:
				return this.Yield(43, new WaitForSeconds(0.5f));
				Block_193:
				return this.Yield(41, new WaitForSeconds(0.5f));
				Block_196:
				IL_1B96:
				goto IL_29CE;
				IL_1C27:
				return this.Yield(47, new WaitForSeconds(0.5f));
				IL_1C43:
				return this.YieldDefault(48);
				IL_1CC5:
				return this.Yield(57, new WaitForSeconds(1f));
				IL_1EE2:
				return this.Yield(35, new WaitForSeconds(0.5f));
				IL_1EFE:
				return this.YieldDefault(36);
				IL_1FE6:
				goto IL_29CE;
				Block_227:
				return this.Yield(33, new WaitForSeconds(0.5f));
				Block_229:
				return this.Yield(19, new WaitForSeconds(0.5f));
				Block_231:
				goto IL_29CE;
				Block_238:
				goto IL_1003;
				IL_2325:
				goto IL_29CE;
				IL_23CA:
				return this.Yield(25, new WaitForSeconds(0.5f));
				IL_23E6:
				return this.YieldDefault(26);
				Block_269:
				goto IL_933;
				Block_271:
				goto IL_29CE;
				IL_25D1:
				return this.YieldDefault(24);
				Block_274:
				return this.Yield(23, new WaitForSeconds(0.5f));
				IL_2659:
				return this.Yield(55, new WaitForSeconds(0.5f));
				IL_2675:
				return this.YieldDefault(56);
				IL_26F0:
				return this.YieldDefault(8);
				IL_278F:
				return this.YieldDefault(42);
				Block_288:
				return this.Yield(29, new WaitForSeconds(0.5f));
				IL_27F1:
				goto IL_29CE;
				IL_284F:
				return this.YieldDefault(44);
				IL_28A2:
				return this.YieldDefault(10);
				IL_28D9:
				goto IL_29CE;
				Block_298:
				return this.Yield(17, new WaitForSeconds(0.5f));
				Block_300:
				IL_29CE:
				return false;
			}

			// Token: 0x06007A14 RID: 31252 RVA: 0x01011F60 File Offset: 0x01010160
			internal static bool UAVEuip7cbot1G0q2sn0()
			{
				return true;
			}

			// Token: 0x06007A15 RID: 31253 RVA: 0x01011F64 File Offset: 0x01010164
			internal static bool iW2TIQp7UqQHFJv6xwnL()
			{
				return false;
			}

			// Token: 0x04007C4C RID: 31820
			internal GameObject $mPlayer$38423;

			// Token: 0x04007C4D RID: 31821
			internal GameObject $mFireGod$38424;

			// Token: 0x04007C4E RID: 31822
			internal GameGui $mGameGui$38425;

			// Token: 0x04007C4F RID: 31823
			internal StoryGui $mStoryGui$38426;

			// Token: 0x04007C50 RID: 31824
			internal GameObject $mSpawnPoint1$38427;

			// Token: 0x04007C51 RID: 31825
			internal CharacterDataClass $mCDat2$38428;

			// Token: 0x04007C52 RID: 31826
			internal CharacterDataClass $mCDat3$38429;

			// Token: 0x04007C53 RID: 31827
			internal int $$switch$6654$38430;

			// Token: 0x04007C54 RID: 31828
			internal GameObject $mSpawnPoint2$38431;

			// Token: 0x04007C55 RID: 31829
			internal GameObject $mPlayer2$38432;

			// Token: 0x04007C56 RID: 31830
			internal GameObject $mSpawnPoint3$38433;

			// Token: 0x04007C57 RID: 31831
			internal GameObject $mPlayer3$38434;

			// Token: 0x04007C58 RID: 31832
			internal float $mStoryTimer$38435;

			// Token: 0x04007C59 RID: 31833
			internal M307_FireThrone $self_$38436;
		}
	}

	// Token: 0x0200149B RID: 5275
	[CompilerGenerated]
	[Serializable]
	internal sealed class $StartGame$38438 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06007A16 RID: 31254 RVA: 0x01011F68 File Offset: 0x01010168
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $StartGame$38438(M307_FireThrone self_)
		{
			if (137442 - 189644 != -52201)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (222290 - 333869 == -111579)
				{
					base..ctor();
					if (123801 - 200750 == -76949)
					{
						this.$self_$38441 = self_;
						if (286862 - 436502 != -149639)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x06007A17 RID: 31255 RVA: 0x01012000 File Offset: 0x01010200
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M307_FireThrone.$StartGame$38438.$(this.$self_$38441);
		}

		// Token: 0x06007A18 RID: 31256 RVA: 0x01012010 File Offset: 0x01010210
		internal static bool TqimXap7TMI9e4pdkS6y()
		{
			return true;
		}

		// Token: 0x06007A19 RID: 31257 RVA: 0x01012014 File Offset: 0x01010214
		internal static bool xq7MKjp73HZftbdk7I3V()
		{
			return false;
		}

		// Token: 0x04007C5A RID: 31834
		internal M307_FireThrone $self_$38441;

		// Token: 0x0200149C RID: 5276
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06007A1A RID: 31258 RVA: 0x01012018 File Offset: 0x01010218
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M307_FireThrone self_)
			{
				if (293794 - 494439 != -200645)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (42368 - 290954 != -248585)
					{
						base..ctor();
						if (241261 - 496945 != -255683)
						{
							this.$self_$38440 = self_;
							if (111778 - 337624 == -225846)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x06007A1B RID: 31259 RVA: 0x010120B0 File Offset: 0x010102B0
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (264135 - 317104 != -52968)
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
						if (32736 - 101771 != -69035)
						{
							continue;
						}
						Game.mStateTime = Time.time;
						if (74504 - 220966 != -146462)
						{
							continue;
						}
						this.YieldDefault(1);
						if (50733 - 326285 != -275551)
						{
							goto Block_4;
						}
						continue;
					default:
						if (289716 - 141074 == 148643)
						{
							continue;
						}
						break;
					}
					Debug.Log("Start Game");
					if (113734 - 214882 == -101148)
					{
						Game.mGameState = eGameState.Start;
						if (60840 - 148768 == -87928)
						{
							Game.mStateTime = Time.time;
							if (284993 - 346973 != -61979)
							{
								this.$mGameGui$38439 = (GameGui)this.$self_$38440.GetComponent(typeof(GameGui));
								if (16986 - 267704 != -250717)
								{
									this.$mGameGui$38439.enabled = true;
									if (161653 - 266383 == -104730)
									{
										this.$self_$38440.SendMessage("fadeIn");
										if (246516 - 498437 == -251921)
										{
											goto IL_13B;
										}
									}
								}
							}
						}
					}
				}
				Block_4:
				goto IL_1B9;
				IL_13B:
				return this.Yield(2, new WaitForSeconds(0.5f));
				IL_1B9:
				return false;
			}

			// Token: 0x06007A1C RID: 31260 RVA: 0x01012288 File Offset: 0x01010488
			internal static bool B0ZWG3p7XAZ3rKg3CAkp()
			{
				return true;
			}

			// Token: 0x06007A1D RID: 31261 RVA: 0x0101228C File Offset: 0x0101048C
			internal static bool PcM0gip7QJZaDGc3tOAV()
			{
				return false;
			}

			// Token: 0x04007C5B RID: 31835
			internal GameGui $mGameGui$38439;

			// Token: 0x04007C5C RID: 31836
			internal M307_FireThrone $self_$38440;
		}
	}

	// Token: 0x0200149D RID: 5277
	[CompilerGenerated]
	[Serializable]
	internal sealed class $onDeadPlayer$38442 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06007A1E RID: 31262 RVA: 0x01012290 File Offset: 0x01010490
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $onDeadPlayer$38442(M307_FireThrone self_)
		{
			if (277723 - 501975 != -224252)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (25653 - 47197 != -21543)
				{
					base..ctor();
					if (39592 - 48050 == -8458)
					{
						this.$self_$38447 = self_;
						if (228874 - 401799 != -172924)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x06007A1F RID: 31263 RVA: 0x01012328 File Offset: 0x01010528
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M307_FireThrone.$onDeadPlayer$38442.$(this.$self_$38447);
		}

		// Token: 0x06007A20 RID: 31264 RVA: 0x01012338 File Offset: 0x01010538
		internal static bool m5gWfXp7khdi2JQ9rnVr()
		{
			return true;
		}

		// Token: 0x06007A21 RID: 31265 RVA: 0x0101233C File Offset: 0x0101053C
		internal static bool cXJLxLp7GmtPI16ukIhx()
		{
			return false;
		}

		// Token: 0x04007C5D RID: 31837
		internal M307_FireThrone $self_$38447;

		// Token: 0x0200149E RID: 5278
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06007A22 RID: 31266 RVA: 0x01012340 File Offset: 0x01010540
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M307_FireThrone self_)
			{
				if (283412 - 122850 != 160563)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (99759 - 240747 != -140987)
					{
						base..ctor();
						if (87271 - 56570 != 30702)
						{
							this.$self_$38446 = self_;
							if (64669 - 433975 == -369306)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x06007A23 RID: 31267 RVA: 0x010123D8 File Offset: 0x010105D8
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (175185 - 460605 != -285420)
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
						if (Game.mGameState == eGameState.Normal)
						{
							goto IL_174;
						}
						if (173369 - 374593 == -201223)
						{
							continue;
						}
						if (Game.mGameState == eGameState.Hold)
						{
							if (143821 - 227487 != -83666)
							{
								continue;
							}
							goto IL_174;
						}
						IL_D9:
						this.YieldDefault(1);
						if (211845 - 213657 != -1811)
						{
							goto Block_7;
						}
						continue;
						IL_174:
						Game.mGameState = eGameState.Hold;
						if (228645 - 250544 == -21898)
						{
							continue;
						}
						this.$mStoryGui$38443 = (StoryGui)this.$self_$38446.GetComponent(typeof(StoryGui));
						if (131583 - 191668 == -60084)
						{
							continue;
						}
						if (this.$mStoryGui$38443)
						{
							if (115757 - 197035 == -81277)
							{
								continue;
							}
							this.$mStoryGui$38443.close();
							if (196275 - 585178 == -388902)
							{
								continue;
							}
						}
						this.$mChangeGui$38444 = (ChangeGui)this.$self_$38446.GetComponent(typeof(ChangeGui));
						if (50246 - 237653 == -187406)
						{
							continue;
						}
						if (this.$mChangeGui$38444)
						{
							if (252884 - 581568 != -328684)
							{
								continue;
							}
							this.$mChangeGui$38444.close();
							if (289904 - 291640 != -1736)
							{
								continue;
							}
						}
						this.$mGameGui$38445 = (GameGui)this.$self_$38446.GetComponent(typeof(GameGui));
						if (51987 - 469160 != -417173)
						{
							continue;
						}
						if (!this.$mGameGui$38445)
						{
							goto IL_D9;
						}
						if (83216 - 332149 != -248933)
						{
							continue;
						}
						if (!this.$mGameGui$38445.enabled)
						{
							if (13208 - 212415 == -199206)
							{
								continue;
							}
							this.$mGameGui$38445.enabled = true;
							if (14605 - 107430 == -92824)
							{
								continue;
							}
						}
						this.$mGameGui$38445.openDeadMenu();
						if (142615 - 454147 != -311531)
						{
							goto IL_D9;
						}
						continue;
					default:
						if (252352 - 407375 != -155023)
						{
							continue;
						}
						break;
					}
					Debug.Log("On Dead Player");
					if (49680 - 167371 != -117690)
					{
						goto Block_20;
					}
				}
				Block_7:
				goto IL_2F9;
				Block_20:
				return this.Yield(2, new WaitForSeconds((float)2));
				IL_2F9:
				return false;
			}

			// Token: 0x06007A24 RID: 31268 RVA: 0x010126F0 File Offset: 0x010108F0
			internal static bool YrFoekp7H2eDkpFaShrD()
			{
				return true;
			}

			// Token: 0x06007A25 RID: 31269 RVA: 0x010126F4 File Offset: 0x010108F4
			internal static bool dbMHK2p7W4iyLd0mIyKN()
			{
				return false;
			}

			// Token: 0x04007C5E RID: 31838
			internal StoryGui $mStoryGui$38443;

			// Token: 0x04007C5F RID: 31839
			internal ChangeGui $mChangeGui$38444;

			// Token: 0x04007C60 RID: 31840
			internal GameGui $mGameGui$38445;

			// Token: 0x04007C61 RID: 31841
			internal M307_FireThrone $self_$38446;
		}
	}

	// Token: 0x0200149F RID: 5279
	[CompilerGenerated]
	[Serializable]
	internal sealed class $ReturnToTown$38448 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06007A26 RID: 31270 RVA: 0x010126F8 File Offset: 0x010108F8
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $ReturnToTown$38448(M307_FireThrone self_)
		{
			if (193596 - 92312 != 101284)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (255485 - 525290 != -269804)
				{
					base..ctor();
					if (115598 - 388967 == -273369)
					{
						this.$self_$38452 = self_;
						if (8723 - 158910 == -150187)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x06007A27 RID: 31271 RVA: 0x01012790 File Offset: 0x01010990
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M307_FireThrone.$ReturnToTown$38448.$(this.$self_$38452);
		}

		// Token: 0x06007A28 RID: 31272 RVA: 0x010127A0 File Offset: 0x010109A0
		internal static bool LBMQ3Op7Acjlh460M8AG()
		{
			return true;
		}

		// Token: 0x06007A29 RID: 31273 RVA: 0x010127A4 File Offset: 0x010109A4
		internal static bool kik89pp7llygrHUphFMV()
		{
			return false;
		}

		// Token: 0x04007C62 RID: 31842
		internal M307_FireThrone $self_$38452;

		// Token: 0x020014A0 RID: 5280
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06007A2A RID: 31274 RVA: 0x010127A8 File Offset: 0x010109A8
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M307_FireThrone self_)
			{
				if (190842 - 149641 != 41201)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (39028 - 189679 == -150651)
					{
						base..ctor();
						if (51507 - 234690 == -183183)
						{
							this.$self_$38451 = self_;
							if (185072 - 97711 != 87362)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x06007A2B RID: 31275 RVA: 0x01012840 File Offset: 0x01010A40
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (226457 - 110685 != 115772)
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
						this.$self_$38451.LeaveGame();
						if (10146 - 10569 == -422)
						{
							continue;
						}
						this.YieldDefault(1);
						if (174440 - 510851 != -336410)
						{
							goto Block_27;
						}
						continue;
					default:
						if (178254 - 402259 != -224005)
						{
							continue;
						}
						break;
					}
					Game.mGameState = eGameState.Ended;
					if (105177 - 80072 != 25106)
					{
						Game.mStateTime = Time.time;
						if (22509 - 170192 == -147683)
						{
							this.$$switch$6656$38449 = PlayerData.SaveGuild;
							if (141348 - 458710 != -317361)
							{
								if (this.$$switch$6656$38449 == 1)
								{
									if (116860 - 574603 == -457742)
									{
										continue;
									}
									Game.mNextGameCode = 32;
									if (48444 - 336970 != -288526)
									{
										continue;
									}
								}
								else if (this.$$switch$6656$38449 == 2)
								{
									if (210659 - 106989 == 103671)
									{
										continue;
									}
									Game.mNextGameCode = 33;
									if (53134 - 313478 != -260344)
									{
										continue;
									}
								}
								else if (this.$$switch$6656$38449 == 3)
								{
									if (101774 - 451716 != -349942)
									{
										continue;
									}
									Game.mNextGameCode = 34;
									if (210279 - 84332 == 125948)
									{
										continue;
									}
								}
								else if (this.$$switch$6656$38449 == 4)
								{
									if (164968 - 442746 == -277777)
									{
										continue;
									}
									Game.mNextGameCode = 35;
									if (82158 - 538983 == -456824)
									{
										continue;
									}
								}
								else if (this.$$switch$6656$38449 == 5)
								{
									if (35102 - 313923 == -278820)
									{
										continue;
									}
									Game.mNextGameCode = 36;
									if (239639 - 268115 != -28476)
									{
										continue;
									}
								}
								else if (PlayerData.GID == 0)
								{
									if (229541 - 595758 == -366216)
									{
										continue;
									}
									Game.mNextGameCode = 30;
									if (61123 - 580398 != -519275)
									{
										continue;
									}
								}
								else
								{
									Game.mNextGameCode = 31;
									if (11125 - 282293 != -271168)
									{
										continue;
									}
								}
								this.$mGameGui$38450 = (GameGui)this.$self_$38451.GetComponent(typeof(GameGui));
								if (162790 - 263054 == -100264)
								{
									if (this.$mGameGui$38450)
									{
										if (244225 - 26234 != 217991)
										{
											continue;
										}
										this.$mGameGui$38450.close();
										if (107272 - 424826 != -317554)
										{
											continue;
										}
									}
									this.$self_$38451.SendMessage("fadeOut");
									if (223051 - 400977 != -177925)
									{
										break;
									}
								}
							}
						}
					}
				}
				return this.Yield(2, new WaitForSeconds((float)1));
				Block_27:
				IL_3AD:
				return false;
			}

			// Token: 0x06007A2C RID: 31276 RVA: 0x01012C0C File Offset: 0x01010E0C
			internal static bool j2BVqEp7yUeAJfFpleYI()
			{
				return true;
			}

			// Token: 0x06007A2D RID: 31277 RVA: 0x01012C10 File Offset: 0x01010E10
			internal static bool LbOfRJp7SiH69TMgHgvc()
			{
				return false;
			}

			// Token: 0x04007C63 RID: 31843
			internal int $$switch$6656$38449;

			// Token: 0x04007C64 RID: 31844
			internal GameGui $mGameGui$38450;

			// Token: 0x04007C65 RID: 31845
			internal M307_FireThrone $self_$38451;
		}
	}

	// Token: 0x020014A1 RID: 5281
	[CompilerGenerated]
	[Serializable]
	internal sealed class $ReturnToGuild$38453 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06007A2E RID: 31278 RVA: 0x01012C14 File Offset: 0x01010E14
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $ReturnToGuild$38453(M307_FireThrone self_)
		{
			if (1292 - 4587 != -3295)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (227194 - 44672 != 182523)
				{
					base..ctor();
					if (297749 - 461947 == -164198)
					{
						this.$self_$38456 = self_;
						if (226402 - 366533 == -140131)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x06007A2F RID: 31279 RVA: 0x01012CAC File Offset: 0x01010EAC
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M307_FireThrone.$ReturnToGuild$38453.$(this.$self_$38456);
		}

		// Token: 0x06007A30 RID: 31280 RVA: 0x01012CBC File Offset: 0x01010EBC
		internal static bool pGt3YJp7ok48pCaHY5cq()
		{
			return true;
		}

		// Token: 0x06007A31 RID: 31281 RVA: 0x01012CC0 File Offset: 0x01010EC0
		internal static bool yuL7DVp7E686CkdHSrWh()
		{
			return false;
		}

		// Token: 0x04007C66 RID: 31846
		internal M307_FireThrone $self_$38456;

		// Token: 0x020014A2 RID: 5282
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06007A32 RID: 31282 RVA: 0x01012CC4 File Offset: 0x01010EC4
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M307_FireThrone self_)
			{
				if (79307 - 506251 != -426943)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (237224 - 559405 != -322180)
					{
						base..ctor();
						if (270188 - 221653 != 48536)
						{
							this.$self_$38455 = self_;
							if (87551 - 490193 == -402642)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x06007A33 RID: 31283 RVA: 0x01012D5C File Offset: 0x01010F5C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (137134 - 41761 != 95373)
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
						this.$self_$38455.LeaveGame();
						if (265702 - 167787 == 97916)
						{
							continue;
						}
						this.YieldDefault(1);
						if (186526 - 375059 != -188533)
						{
							continue;
						}
						goto IL_1BD;
					default:
						if (156403 - 519496 != -363093)
						{
							continue;
						}
						break;
					}
					Game.mGameState = eGameState.Ended;
					if (28355 - 100260 != -71904)
					{
						Game.mStateTime = Time.time;
						if (170628 - 65606 == 105022)
						{
							Game.mNextGameCode = 31;
							if (57036 - 267298 != -210261)
							{
								this.$mGameGui$38454 = (GameGui)this.$self_$38455.GetComponent(typeof(GameGui));
								if (257578 - 428674 == -171096)
								{
									if (this.$mGameGui$38454)
									{
										if (257560 - 241320 != 16240)
										{
											continue;
										}
										this.$mGameGui$38454.close();
										if (227732 - 222237 != 5495)
										{
											continue;
										}
									}
									this.$self_$38455.SendMessage("fadeOut");
									if (281591 - 350413 == -68822)
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

			// Token: 0x06007A34 RID: 31284 RVA: 0x01012F38 File Offset: 0x01011138
			internal static bool IIplOUp724t5BaMIyFyO()
			{
				return true;
			}

			// Token: 0x06007A35 RID: 31285 RVA: 0x01012F3C File Offset: 0x0101113C
			internal static bool dJaP1mp78HwalLQ8yTbR()
			{
				return false;
			}

			// Token: 0x04007C67 RID: 31847
			internal GameGui $mGameGui$38454;

			// Token: 0x04007C68 RID: 31848
			internal M307_FireThrone $self_$38455;
		}
	}

	// Token: 0x020014A3 RID: 5283
	[CompilerGenerated]
	[Serializable]
	internal sealed class $ReturnToCamp$38457 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06007A36 RID: 31286 RVA: 0x01012F40 File Offset: 0x01011140
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $ReturnToCamp$38457(M307_FireThrone self_)
		{
			if (192082 - 110218 != 81864)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (226582 - 103106 == 123476)
				{
					base..ctor();
					if (247870 - 517791 != -269920)
					{
						this.$self_$38461 = self_;
						if (276614 - 73349 != 203266)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x06007A37 RID: 31287 RVA: 0x01012FD8 File Offset: 0x010111D8
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M307_FireThrone.$ReturnToCamp$38457.$(this.$self_$38461);
		}

		// Token: 0x06007A38 RID: 31288 RVA: 0x01012FE8 File Offset: 0x010111E8
		internal static bool P835bYp7ZgybNC0sYyqm()
		{
			return true;
		}

		// Token: 0x06007A39 RID: 31289 RVA: 0x01012FEC File Offset: 0x010111EC
		internal static bool gvPTSEp7CWWq80Y25w0X()
		{
			return false;
		}

		// Token: 0x04007C69 RID: 31849
		internal M307_FireThrone $self_$38461;

		// Token: 0x020014A4 RID: 5284
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06007A3A RID: 31290 RVA: 0x01012FF0 File Offset: 0x010111F0
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M307_FireThrone self_)
			{
				if (151406 - 305619 != -154212)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (259986 - 460390 != -200403)
					{
						base..ctor();
						if (263952 - 536192 != -272239)
						{
							this.$self_$38460 = self_;
							if (166442 - 312933 != -146490)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x06007A3B RID: 31291 RVA: 0x01013088 File Offset: 0x01011288
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (113245 - 262321 != -149075)
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
						this.$self_$38460.LeaveGame();
						if (200163 - 501691 != -301528)
						{
							continue;
						}
						this.YieldDefault(1);
						if (261041 - 16215 != 244827)
						{
							goto Block_17;
						}
						continue;
					default:
						if (208895 - 461153 != -252258)
						{
							continue;
						}
						break;
					}
					Game.mGameState = eGameState.Ended;
					if (119298 - 510102 == -390804)
					{
						Game.mStateTime = Time.time;
						if (99406 - 206527 != -107120)
						{
							this.$$switch$6658$38458 = PlayerData.SaveGuild;
							if (211140 - 292762 == -81622)
							{
								if (this.$$switch$6658$38458 == 1)
								{
									if (298148 - 96156 != 201992)
									{
										continue;
									}
									Game.mNextGameCode = 32;
									if (102763 - 573690 == -470926)
									{
										continue;
									}
								}
								else if (this.$$switch$6658$38458 == 2)
								{
									if (183095 - 155489 != 27606)
									{
										continue;
									}
									Game.mNextGameCode = 33;
									if (179687 - 549650 != -369963)
									{
										continue;
									}
								}
								else if (this.$$switch$6658$38458 == 3)
								{
									if (52371 - 72012 == -19640)
									{
										continue;
									}
									Game.mNextGameCode = 34;
									if (205014 - 9984 != 195030)
									{
										continue;
									}
								}
								else if (this.$$switch$6658$38458 == 4)
								{
									if (4774 - 136060 != -131286)
									{
										continue;
									}
									Game.mNextGameCode = 35;
									if (44151 - 431439 == -387287)
									{
										continue;
									}
								}
								else if (this.$$switch$6658$38458 == 5)
								{
									if (43241 - 247087 != -203846)
									{
										continue;
									}
									Game.mNextGameCode = 36;
									if (231827 - 488423 == -256595)
									{
										continue;
									}
								}
								else
								{
									Game.mNextGameCode = 30;
									if (38023 - 298549 != -260526)
									{
										continue;
									}
								}
								this.$mGameGui$38459 = (GameGui)this.$self_$38460.GetComponent(typeof(GameGui));
								if (294389 - 173415 == 120974)
								{
									if (this.$mGameGui$38459)
									{
										if (103499 - 40089 == 63411)
										{
											continue;
										}
										this.$mGameGui$38459.close();
										if (62908 - 529954 != -467046)
										{
											continue;
										}
									}
									this.$self_$38460.SendMessage("fadeOut");
									if (236529 - 334069 != -97539)
									{
										break;
									}
								}
							}
						}
					}
				}
				return this.Yield(2, new WaitForSeconds((float)1));
				Block_17:
				IL_363:
				return false;
			}

			// Token: 0x06007A3C RID: 31292 RVA: 0x0101340C File Offset: 0x0101160C
			internal static bool fSD6xCp7LC1pmfDPGVRA()
			{
				return true;
			}

			// Token: 0x06007A3D RID: 31293 RVA: 0x01013410 File Offset: 0x01011610
			internal static bool yEOwayp7OPnsyAd315Pl()
			{
				return false;
			}

			// Token: 0x04007C6A RID: 31850
			internal int $$switch$6658$38458;

			// Token: 0x04007C6B RID: 31851
			internal GameGui $mGameGui$38459;

			// Token: 0x04007C6C RID: 31852
			internal M307_FireThrone $self_$38460;
		}
	}
}
