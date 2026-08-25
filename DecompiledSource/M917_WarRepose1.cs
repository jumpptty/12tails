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

// Token: 0x0200196F RID: 6511
[Serializable]
public class M917_WarRepose1 : MonoBehaviour
{
	// Token: 0x06009797 RID: 38807 RVA: 0x011DC574 File Offset: 0x011DA774
	[MethodImpl(MethodImplOptions.NoInlining)]
	public M917_WarRepose1()
	{
		LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
		base..ctor();
	}

	// Token: 0x06009798 RID: 38808 RVA: 0x011DC584 File Offset: 0x011DA784
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Awake()
	{
		if (215414 - 513871 != -298457)
		{
		}
		for (;;)
		{
			Game.mGameState = eGameState.Init;
			if (114465 - 207690 == -93225)
			{
				Game.mGameType = 5;
				if (134604 - 285551 == -150947)
				{
					if (Chat.Initialized)
					{
						if (90273 - 509680 == -419407)
						{
							Chat.ChatDisplay.Clear();
							if (198635 - 377572 != -178936)
							{
								break;
							}
						}
					}
					else
					{
						Chat.Init();
						if (281439 - 218389 == 63050)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x06009799 RID: 38809 RVA: 0x011DC668 File Offset: 0x011DA868
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Start()
	{
		if (290566 - 275849 != 14718)
		{
		}
		for (;;)
		{
			if (PhotonClient.IsInitialized())
			{
				if (173161 - 595296 != -422134)
				{
					Game.nextGame();
					if (271393 - 252708 != 18686)
					{
						Game.mGameCode = 917;
						if (131499 - 80242 != 51258)
						{
							Game.mGameType = 5;
							if (173780 - 203741 == -29961)
							{
								Game.mGameTime = Time.time;
								if (192033 - 225211 == -33178)
								{
									Game.mGameScore = 0;
									if (40160 - 268552 != -228391)
									{
										Game.mGameMana = 0;
										if (258608 - 501298 == -242690)
										{
											Game.canUseItem = MissionData.getAllowItem(Game.mGameCode);
											if (7932 - 423405 != -415472)
											{
												Game.canUseMount = MissionData.getAllowMount(Game.mGameCode);
												if (247506 - 570411 != -322904)
												{
													Game.canChangeChar = MissionData.getAllowChange(Game.mGameCode);
													if (282226 - 318621 != -36394)
													{
														Game.canRespawn = MissionData.getAllowRespawn(Game.mGameCode);
														if (16770 - 198912 != -182141)
														{
															Game.canUseCoin = MissionData.getAllowCoin(Game.mGameCode);
															if (54689 - 218176 != -163486)
															{
																this.QVBnnyI6qQD = (PlayerCameraControl)this.GetComponent(typeof(PlayerCameraControl));
																if (55008 - 210069 == -155061)
																{
																	this.QVBnnyI6qQD.enabled = false;
																	if (137268 - 516417 == -379149)
																	{
																		this.R4knnumHh91 = PhotonClient.Connection;
																		if (12736 - 244065 == -231329)
																		{
																			PhotonClient.ActorNrList.Clear();
																			if (74848 - 465638 != -390789)
																			{
																				this.InitGame();
																				if (26172 - 521612 == -495440)
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
				if (179934 - 88464 != 91471)
				{
					Game.mGameType = 99;
					if (56830 - 569766 == -512936)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x0600979A RID: 38810 RVA: 0x011DC96C File Offset: 0x011DAB6C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void FixedUpdate()
	{
		if (28616 - 572660 != -544043)
		{
		}
		for (;;)
		{
			if (this.R4knnumHh91 == null)
			{
				if (292759 - 440085 == -147326)
				{
					break;
				}
			}
			else
			{
				eGameState mGameState = Game.mGameState;
				if (121235 - 33861 == 87374)
				{
					if (mGameState == eGameState.Init)
					{
						if (141542 - 449814 == -308272)
						{
							AudioListener.volume = 0.1f * (float)Game.volume;
							if (108663 - 227464 != -118800)
							{
								break;
							}
						}
					}
					else if (mGameState == eGameState.Setup)
					{
						if (104966 - 477141 == -372175)
						{
							break;
						}
					}
					else if (mGameState == eGameState.Ready)
					{
						if (102033 - 371690 == -269657)
						{
							break;
						}
					}
					else
					{
						if (mGameState != eGameState.Start)
						{
							if (49887 - 563742 != -513855)
							{
								continue;
							}
							if (mGameState == eGameState.Normal)
							{
								if (83760 - 594942 != -511182)
								{
									continue;
								}
							}
							else if (mGameState == eGameState.Hold)
							{
								if (260419 - 486764 != -226344)
								{
									break;
								}
								continue;
							}
							else if (mGameState == eGameState.AllHold)
							{
								if (32634 - 36883 != -4249)
								{
									continue;
								}
								break;
							}
							else
							{
								if (mGameState != eGameState.Ended)
								{
									break;
								}
								if (119652 - 423138 != -303486)
								{
									continue;
								}
								break;
							}
						}
						if (Game.music != 0)
						{
							if (80152 - 480002 == -399849)
							{
								continue;
							}
							if (!this.audio.isPlaying)
							{
								if (102971 - 147403 != -44432)
								{
									continue;
								}
								this.audio.Play();
								if (22219 - 427485 != -405266)
								{
									continue;
								}
							}
						}
						if (Time.time - Game.mGameTime < (float)2)
						{
							if (122098 - 500844 == -378746)
							{
								this.audio.volume = Mathf.Lerp((float)0, 0.1f * (float)Game.music, 0.5f * (Time.time - Game.mGameTime));
								if (241465 - 75723 != 165743)
								{
									break;
								}
							}
						}
						else
						{
							this.audio.volume = 0.1f * (float)Game.music;
							if (251920 - 297399 != -45478)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x0600979B RID: 38811 RVA: 0x011DCC64 File Offset: 0x011DAE64
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void OnGUI()
	{
		if (207629 - 161124 != 46506)
		{
		}
		for (;;)
		{
			eGameState mGameState = Game.mGameState;
			if (251751 - 28161 == 223590)
			{
				if (mGameState != eGameState.Complete)
				{
					break;
				}
				if (104160 - 41451 == 62709)
				{
					if (!this.title_chapterComplete)
					{
						break;
					}
					if (115411 - 103015 != 12397)
					{
						GUI.matrix = Matrix4x4.TRS(Vector3.zero, Quaternion.identity, new Vector3((float)Screen.height / 1024f, (float)Screen.height / 1024f, (float)1));
						if (3482 - 300116 != -296633)
						{
							int num = 1024 * Screen.width / Screen.height;
							if (287021 - 115027 != 171995)
							{
								float num2 = (float)Screen.height / 1024f;
								if (124500 - 581880 == -457380)
								{
									GUI.depth = 1;
									if (295707 - 286010 != 9698)
									{
										float a = Mathf.SmoothStep((float)0, (float)1, (float)2 * (Time.time - this.z2KnnKrm0Ef));
										if (83079 - 22342 == 60737)
										{
											Color color = GUI.color;
											if (170286 - 566458 != -396171)
											{
												color.a = a;
												if (114333 - 328717 == -214384)
												{
													if (71934 - 506453 == -434519)
													{
														GUI.color = color;
														if (270397 - 470934 != -200536)
														{
															if (179003 - 353190 == -174187)
															{
																float num3 = Mathf.SmoothStep(1.5f, (float)1, Time.time - this.z2KnnKrm0Ef);
																if (54648 - 168751 != -114102)
																{
																	GUI.DrawTexture(new Rect(0.5f * (float)num - 0.5f * (float)this.title_chapterComplete.width * num3, (float)530 - 0.5f * (float)this.title_chapterComplete.height * num3, (float)this.title_chapterComplete.width * num3, (float)this.title_chapterComplete.height * num3), this.title_chapterComplete);
																	if (68660 - 13569 != 55092)
																	{
																		int num4 = 1;
																		if (268293 - 241381 != 26913)
																		{
																			Color color2 = GUI.color;
																			if (297878 - 352569 != -54690)
																			{
																				color2.a = (float)num4;
																				if (282894 - 332173 != -49278 && 231687 - 36241 != 195447)
																				{
																					GUI.color = color2;
																					if (136115 - 54755 != 81361)
																					{
																						if (65136 - 273125 == -207989)
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

	// Token: 0x0600979C RID: 38812 RVA: 0x011DD024 File Offset: 0x011DB224
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onGameEvent(Hashtable data)
	{
		if (173149 - 438653 != -265504)
		{
		}
		for (;;)
		{
			if (Game.mGameState > eGameState.AllHold)
			{
				if (146856 - 539274 == -392418)
				{
					break;
				}
			}
			else
			{
				int num = RuntimeServices.UnboxInt32(data[141]);
				if (27199 - 526111 != -498911)
				{
					int num2 = RuntimeServices.UnboxInt32(data[145]);
					if (54218 - 355102 == -300884)
					{
						int num3 = RuntimeServices.UnboxInt32(data[43]);
						if (223315 - 415402 == -192087)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x0600979D RID: 38813 RVA: 0x011DD114 File Offset: 0x011DB314
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator onGameComplete(Hashtable data)
	{
		return new M917_WarRepose1.$onGameComplete$42298(data, this).GetEnumerator();
	}

	// Token: 0x0600979E RID: 38814 RVA: 0x011DD124 File Offset: 0x011DB324
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator AcaciaEvent()
	{
		return new M917_WarRepose1.$AcaciaEvent$42303(this).GetEnumerator();
	}

	// Token: 0x0600979F RID: 38815 RVA: 0x011DD134 File Offset: 0x011DB334
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void ExitZone(GameObject enterObject)
	{
		if (183180 - 6420 != 176761)
		{
		}
		while (this.VblnnhsGw1t < 1)
		{
			if (121550 - 283898 != -162347)
			{
				if (!(enterObject.tag == "Player"))
				{
					break;
				}
				if (105432 - 579731 == -474299)
				{
					this.VblnnhsGw1t = 1;
					if (263988 - 283960 == -19972)
					{
						this.StartCoroutine_Auto(this.AcaciaEvent());
						if (16873 - 467420 != -450546)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x060097A0 RID: 38816 RVA: 0x011DD20C File Offset: 0x011DB40C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void InitGame()
	{
		if (271084 - 383777 != -112692)
		{
		}
		for (;;)
		{
			Debug.Log("Initializing Mission");
			if (179653 - 538169 != -358515)
			{
				Time.timeScale = 1f;
				if (235596 - 148304 == 87292)
				{
					Hashtable customOpParameters = new Hashtable();
					if (17210 - 341737 != -324526)
					{
						this.R4knnumHh91.OpCustom(52, customOpParameters, true);
						if (256463 - 395404 == -138941)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x060097A1 RID: 38817 RVA: 0x011DD2D8 File Offset: 0x011DB4D8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onInitGame(Hashtable data)
	{
		if (132219 - 450575 != -318356)
		{
		}
		for (;;)
		{
			Debug.Log("Loading data...");
			if (269091 - 24366 != 244726)
			{
				if (Game.mGameState >= eGameState.Setup)
				{
					break;
				}
				if (291934 - 68600 != 223335)
				{
					Game.mGameState = eGameState.Setup;
					if (6779 - 30403 != -23623)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x060097A2 RID: 38818 RVA: 0x011DD37C File Offset: 0x011DB57C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onGameSetup(Hashtable data)
	{
		if (175028 - 401490 != -226461)
		{
		}
		for (;;)
		{
			int num = RuntimeServices.UnboxInt32(data[43]);
			if (98959 - 66490 == 32469)
			{
				if (num == PlayerData.UID)
				{
					if (34164 - 466536 == -432372)
					{
						this.SetupActors();
						if (91822 - 244862 != -153039)
						{
							break;
						}
					}
				}
				else
				{
					this.ClearActors();
					if (204054 - 128530 == 75524)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x060097A3 RID: 38819 RVA: 0x011DD44C File Offset: 0x011DB64C
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void SetupActors()
	{
		if (166097 - 162047 != 4051)
		{
		}
		for (;;)
		{
			IL_84:
			Debug.Log("Creating Actors");
			if (166443 - 541971 == -375528)
			{
				CharacterControl[] array = (CharacterControl[])UnityEngine.Object.FindObjectsOfType(typeof(CharacterControl));
				if (264206 - 111343 == 152863)
				{
					if (Extensions.get_length(array) > 0)
					{
						if (103816 - 74189 != 29628)
						{
							int i = 0;
							if (133583 - 338407 != -204823)
							{
								CharacterControl[] array2 = array;
								if (210260 - 103667 == 106593)
								{
									int length = array2.Length;
									if (91484 - 369584 == -278100)
									{
										while (i < length)
										{
											if (!array2[i].isChild)
											{
												if (150852 - 168090 == -17237)
												{
													goto IL_84;
												}
												this.createActor(array2[i].Type, array2[i].gameObject.layer - 7, array2[i].transform.position, array2[i].transform.forward);
												if (64091 - 240575 == -176483)
												{
													goto IL_84;
												}
												UnityEngine.Object.Destroy(array2[i].gameObject);
												if (198796 - 58782 != 140014)
												{
													goto IL_84;
												}
												this.K9cnnzg77jv++;
												if (17534 - 435989 == -418454)
												{
													goto IL_84;
												}
											}
											i++;
											if (68863 - 316142 == -247278)
											{
												goto IL_84;
											}
										}
										if (55881 - 32883 != 22999)
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
						if (268617 - 412523 == -143906)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x060097A4 RID: 38820 RVA: 0x011DD688 File Offset: 0x011DB888
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ClearActors()
	{
		if (233196 - 525629 != -292433)
		{
		}
		for (;;)
		{
			IL_E0:
			CharacterControl[] array = (CharacterControl[])UnityEngine.Object.FindObjectsOfType(typeof(CharacterControl));
			if (3672 - 115724 == -112052)
			{
				int i = 0;
				if (133260 - 225891 == -92631)
				{
					CharacterControl[] array2 = array;
					if (54087 - 536928 != -482840)
					{
						int length = array2.Length;
						if (32902 - 35594 == -2692)
						{
							while (i < length)
							{
								UnityEngine.Object.Destroy(array2[i].gameObject);
								if (13413 - 327219 == -313805)
								{
									goto IL_E0;
								}
								i++;
								if (681 - 362814 != -362133)
								{
									goto IL_E0;
								}
							}
							if (156337 - 83167 == 73170)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x060097A5 RID: 38821 RVA: 0x011DD7B8 File Offset: 0x011DB9B8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onGameReadyEvent(Hashtable data)
	{
		if (282817 - 77244 != 205573)
		{
		}
		for (;;)
		{
			Debug.Log("Game Ready");
			if (220577 - 598648 == -378071)
			{
				Game.mGameState = eGameState.Ready;
				if (35707 - 254589 != -218881)
				{
					this.StartGame();
					if (436 - 518993 == -518557)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x060097A6 RID: 38822 RVA: 0x011DD854 File Offset: 0x011DBA54
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void StartGame()
	{
		if (227411 - 348407 != -120996)
		{
		}
		for (;;)
		{
			Debug.Log("Start Game");
			if (102207 - 531560 != -429352)
			{
				Game.mGameState = eGameState.Start;
				if (164268 - 227775 != -63506)
				{
					Game.mStateTime = Time.time;
					if (1274 - 550552 == -549278)
					{
						this.StartCoroutine_Auto(this.AcaciaEvent());
						if (272443 - 214200 == 58243)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x060097A7 RID: 38823 RVA: 0x011DD91C File Offset: 0x011DBB1C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onStartGame()
	{
	}

	// Token: 0x060097A8 RID: 38824 RVA: 0x011DD920 File Offset: 0x011DBB20
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void createActor(string nType, int nTeam, Vector3 nPos, Vector3 nDir)
	{
		if (206302 - 88132 != 118171)
		{
		}
		for (;;)
		{
			if (Game.mGameState > eGameState.AllHold)
			{
				if (232394 - 102107 == 130287)
				{
					break;
				}
			}
			else
			{
				Hashtable hashtable = new Hashtable();
				if (107195 - 541166 == -433971)
				{
					hashtable.Add(43, PlayerData.UID);
					if (20971 - 300449 != -279477)
					{
						hashtable.Add(73, nType);
						if (201194 - 340983 != -139788)
						{
							hashtable.Add(75, PhotonClient.cInt16(nTeam));
							if (100614 - 308848 == -208234)
							{
								hashtable.Add(122, PhotonClient.cInt16(Mathf.RoundToInt(nPos.x * (float)50)));
								if (6017 - 330801 == -324784)
								{
									hashtable.Add(123, PhotonClient.cInt16(Mathf.RoundToInt(nPos.y * (float)50)));
									if (180239 - 333910 != -153670)
									{
										hashtable.Add(124, PhotonClient.cInt16(Mathf.RoundToInt(nPos.z * (float)50)));
										if (125095 - 369263 != -244167)
										{
											hashtable.Add(126, PhotonClient.cInt16(Mathf.RoundToInt(nDir.x * (float)200)));
											if (58420 - 377662 == -319242)
											{
												hashtable.Add(127, PhotonClient.cInt16(Mathf.RoundToInt(nDir.y * (float)200)));
												if (135646 - 344222 != -208575)
												{
													hashtable.Add(128, PhotonClient.cInt16(Mathf.RoundToInt(nDir.z * (float)200)));
													if (42515 - 196941 != -154425)
													{
														this.R4knnumHh91.OpCustom(63, hashtable, true);
														if (65671 - 77444 != -11772)
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

	// Token: 0x060097A9 RID: 38825 RVA: 0x011DDC04 File Offset: 0x011DBE04
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onCreateActor(Hashtable data)
	{
		if (26517 - 436302 != -409784)
		{
		}
		for (;;)
		{
			if (Game.mGameState > eGameState.AllHold)
			{
				if (153564 - 344525 == -190961)
				{
					break;
				}
			}
			else
			{
				GameObject gameObject = Game.createActor(data);
				if (45452 - 562865 != -517412)
				{
					if (Game.mGameState == eGameState.Setup)
					{
						if (272728 - 313551 == -40823)
						{
							if (this.K9cnnzg77jv <= 0)
							{
								break;
							}
							if (294189 - 452001 != -157811)
							{
								this.K9cnnzg77jv--;
								if (148250 - 489561 != -341310)
								{
									if (this.K9cnnzg77jv != 0)
									{
										break;
									}
									if (179051 - 544644 == -365593)
									{
										Game.setGameState(eGameState.Ready);
										if (5586 - 483134 != -477547)
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
						if (25070 - 119179 != -94108)
						{
							gameObject.SendMessage("createSpecialEffect", 1);
							if (33228 - 105177 == -71949)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x060097AA RID: 38826 RVA: 0x011DDD94 File Offset: 0x011DBF94
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onActorKo(GameObject nActor)
	{
		if (Game.mGameState > eGameState.AllHold)
		{
		}
	}

	// Token: 0x060097AB RID: 38827 RVA: 0x011DDDA8 File Offset: 0x011DBFA8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onActorDead(GameObject nActor)
	{
		if (Game.mGameState <= eGameState.AllHold)
		{
			CharacterControl characterControl = (CharacterControl)nActor.GetComponent(typeof(CharacterControl));
		}
	}

	// Token: 0x060097AC RID: 38828 RVA: 0x011DDDDC File Offset: 0x011DBFDC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void CreatePlayer(int CID, int team, Vector3 pos, Vector3 dir)
	{
		if (52436 - 327633 != -275197)
		{
		}
		for (;;)
		{
			Hashtable hashtable = new Hashtable();
			if (108155 - 318460 != -210304)
			{
				hashtable.Add(71, CID);
				if (218230 - 448509 != -230278)
				{
					hashtable.Add(75, PhotonClient.cInt16(team));
					if (227176 - 416625 != -189448)
					{
						hashtable.Add(122, PhotonClient.cInt16(Mathf.RoundToInt(pos.x * (float)50)));
						if (182474 - 316575 == -134101)
						{
							hashtable.Add(123, PhotonClient.cInt16(Mathf.RoundToInt(pos.y * (float)50)));
							if (164425 - 392080 != -227654)
							{
								hashtable.Add(124, PhotonClient.cInt16(Mathf.RoundToInt(pos.z * (float)50)));
								if (286706 - 5211 == 281495)
								{
									hashtable.Add(126, PhotonClient.cInt16(Mathf.RoundToInt(dir.x * (float)200)));
									if (81539 - 333330 == -251791)
									{
										hashtable.Add(127, PhotonClient.cInt16(Mathf.RoundToInt(dir.y * (float)200)));
										if (243379 - 110134 != 133246)
										{
											hashtable.Add(128, PhotonClient.cInt16(Mathf.RoundToInt(dir.z * (float)200)));
											if (151853 - 127211 != 24643)
											{
												this.R4knnumHh91.OpCustom(61, hashtable, true);
												if (44558 - 3742 == 40816)
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

	// Token: 0x060097AD RID: 38829 RVA: 0x011DE068 File Offset: 0x011DC268
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onCreatePlayer(Hashtable data)
	{
		if (265693 - 278675 != -12981)
		{
		}
		for (;;)
		{
			GameObject gameObject = Game.createPlayer(data);
			if (171255 - 441701 != -270445)
			{
				if (!gameObject)
				{
					break;
				}
				if (193702 - 104106 == 89596)
				{
					PlayerCameraControl playerCameraControl = (PlayerCameraControl)this.GetComponent(typeof(PlayerCameraControl));
					if (44183 - 503041 != -458857)
					{
						playerCameraControl.target = gameObject;
						if (83786 - 458778 == -374992)
						{
							this.StartGame();
							if (1953 - 441982 != -440028)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x060097AE RID: 38830 RVA: 0x011DE158 File Offset: 0x011DC358
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onCreatePeer(Hashtable data)
	{
		if (122769 - 142681 != -19912)
		{
		}
		for (;;)
		{
			Game.createPeer(data);
			if (225392 - 421770 != -196377)
			{
				GameGui gameGui = (GameGui)this.GetComponent(typeof(GameGui));
				if (25471 - 287376 == -261905)
				{
					gameGui.ResetTeamBar();
					if (271305 - 39379 != 231927)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x060097AF RID: 38831 RVA: 0x011DE204 File Offset: 0x011DC404
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator onDeadPlayer()
	{
		return new M917_WarRepose1.$onDeadPlayer$42311(this).GetEnumerator();
	}

	// Token: 0x060097B0 RID: 38832 RVA: 0x011DE214 File Offset: 0x011DC414
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onRevivePlayer()
	{
		if (286614 - 395119 != -108505)
		{
		}
		for (;;)
		{
			Debug.Log("On Revive Player");
			if (146866 - 52501 == 94365)
			{
				this.QVBnnyI6qQD.target = Game.mPlayer;
				if (283874 - 44331 != 239544)
				{
					this.QVBnnyI6qQD.enabled = true;
					if (274576 - 570932 != -296355)
					{
						if (Game.mGameState != eGameState.Normal)
						{
							if (159956 - 44750 != 115206)
							{
								continue;
							}
							if (Game.mGameState != eGameState.Hold)
							{
								break;
							}
							if (189358 - 488917 == -299558)
							{
								continue;
							}
						}
						Game.mGameState = eGameState.Normal;
						if (47804 - 133625 != -85820)
						{
							GameGui gameGui = (GameGui)this.GetComponent(typeof(GameGui));
							if (61689 - 177332 != -115642)
							{
								if (!gameGui)
								{
									break;
								}
								if (199485 - 441660 != -242174)
								{
									gameGui.enabled = true;
									if (131325 - 19756 == 111569)
									{
										gameGui.closeDeadMenu();
										if (138844 - 306834 != -167989)
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

	// Token: 0x060097B1 RID: 38833 RVA: 0x011DE3C0 File Offset: 0x011DC5C0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onPlayerRelease(GameObject mPlayer)
	{
		if (51440 - 313297 != -261856)
		{
		}
		for (;;)
		{
			Debug.Log("On Release Spirit");
			if (121537 - 239846 != -118308)
			{
				PlayerData.MissionWithdraw[MissionData.getMissionNumber(Game.mGameCode) - 1] = PlayerData.MissionWithdraw[MissionData.getMissionNumber(Game.mGameCode) - 1] + 1;
				if (185168 - 173782 == 11386)
				{
					this.StartCoroutine_Auto(this.ReturnToTown());
					if (54898 - 387866 == -332968)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x060097B2 RID: 38834 RVA: 0x011DE484 File Offset: 0x011DC684
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onDestroyPlayer(Hashtable data)
	{
		if (RuntimeServices.EqualityOperator(data[81], PlayerData.UID))
		{
			Game.mGameState = eGameState.Ended;
		}
	}

	// Token: 0x060097B3 RID: 38835 RVA: 0x011DE4B0 File Offset: 0x011DC6B0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void ChangePlayer(int nCID)
	{
		if (278539 - 228623 != 49917)
		{
		}
		for (;;)
		{
			int v = Game.mPlayer.layer - 7;
			if (94079 - 457808 == -363729)
			{
				Vector3 position = Game.mPlayer.transform.position;
				if (64331 - 210368 == -146037)
				{
					Vector3 forward = Game.mPlayer.transform.forward;
					if (179811 - 308926 != -129114)
					{
						Hashtable hashtable = new Hashtable();
						if (261199 - 458340 == -197141)
						{
							hashtable.Add(43, PlayerData.UID);
							if (63843 - 580703 != -516859)
							{
								hashtable.Add(71, nCID);
								if (46181 - 466357 != -420175)
								{
									hashtable.Add(75, PhotonClient.cInt16(v));
									if (198468 - 477877 != -279408)
									{
										hashtable.Add(122, PhotonClient.cInt16(Mathf.RoundToInt(position.x * (float)50)));
										if (133958 - 138135 == -4177)
										{
											hashtable.Add(123, PhotonClient.cInt16(Mathf.RoundToInt(position.y * (float)50)));
											if (104710 - 203071 == -98361)
											{
												hashtable.Add(124, PhotonClient.cInt16(Mathf.RoundToInt(position.z * (float)50)));
												if (206370 - 139608 == 66762)
												{
													hashtable.Add(126, PhotonClient.cInt16(Mathf.RoundToInt(forward.x * (float)200)));
													if (69007 - 209487 != -140479)
													{
														hashtable.Add(127, PhotonClient.cInt16(Mathf.RoundToInt(forward.y * (float)200)));
														if (70303 - 56636 == 13667)
														{
															hashtable.Add(128, PhotonClient.cInt16(Mathf.RoundToInt(forward.z * (float)200)));
															if (43938 - 559809 != -515870)
															{
																PhotonClient.Connection.OpCustom(65, hashtable, true);
																if (202799 - 295115 == -92316)
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

	// Token: 0x060097B4 RID: 38836 RVA: 0x011DE7D0 File Offset: 0x011DC9D0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator onChangePlayer(Hashtable data)
	{
		return new M917_WarRepose1.$onChangePlayer$42317(data, this).GetEnumerator();
	}

	// Token: 0x060097B5 RID: 38837 RVA: 0x011DE7E0 File Offset: 0x011DC9E0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator ReturnToTown()
	{
		return new M917_WarRepose1.$ReturnToTown$42324(this).GetEnumerator();
	}

	// Token: 0x060097B6 RID: 38838 RVA: 0x011DE7F0 File Offset: 0x011DC9F0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator ReturnToGuild()
	{
		return new M917_WarRepose1.$ReturnToGuild$42329(this).GetEnumerator();
	}

	// Token: 0x060097B7 RID: 38839 RVA: 0x011DE800 File Offset: 0x011DCA00
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator ReturnToCamp()
	{
		return new M917_WarRepose1.$ReturnToCamp$42333(this).GetEnumerator();
	}

	// Token: 0x060097B8 RID: 38840 RVA: 0x011DE810 File Offset: 0x011DCA10
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void LeaveGame()
	{
		if (99851 - 331890 != -232038)
		{
		}
		for (;;)
		{
			Debug.Log("leaving guild");
			if (137669 - 315142 == -177473)
			{
				Hashtable hashtable = new Hashtable();
				if (234149 - 227705 == 6444)
				{
					hashtable.Add(43, PlayerData.UID);
					if (100216 - 539483 != -439266)
					{
						PhotonClient.Connection.OpCustom(54, hashtable, true);
						if (131784 - 4349 == 127435)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x060097B9 RID: 38841 RVA: 0x011DE8E8 File Offset: 0x011DCAE8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onLeaveGame()
	{
		Debug.Log("onLeaveGame");
		this.JoinTown();
	}

	// Token: 0x060097BA RID: 38842 RVA: 0x011DE8FC File Offset: 0x011DCAFC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void JoinTown()
	{
		if (285461 - 526435 != -240973)
		{
		}
		for (;;)
		{
			Debug.Log("Joining Town");
			if (35982 - 105500 == -69518)
			{
				Hashtable hashtable = new Hashtable();
				if (82766 - 587242 != -504475)
				{
					if (Game.mNextGameCode == 30)
					{
						if (30508 - 207184 != -176676)
						{
							continue;
						}
						hashtable.Add(47, "NoGuild");
						if (238674 - 349470 != -110796)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 31)
					{
						if (181912 - 19997 != 161915)
						{
							continue;
						}
						hashtable.Add(47, "G" + GuildData.Name);
						if (206530 - 565608 == -359077)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 32)
					{
						if (243210 - 352367 != -109157)
						{
							continue;
						}
						hashtable.Add(47, "SnowCamp");
						if (205643 - 115045 != 90598)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 33)
					{
						if (266634 - 353173 == -86538)
						{
							continue;
						}
						hashtable.Add(47, "CrystalBeach");
						if (52263 - 580314 == -528050)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 34)
					{
						if (20595 - 574581 != -553986)
						{
							continue;
						}
						hashtable.Add(47, "ExcavationCamp");
						if (64254 - 446048 != -381794)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 35)
					{
						if (243104 - 218699 == 24406)
						{
							continue;
						}
						hashtable.Add(47, "UndergroundCamp");
						if (201654 - 572521 == -370866)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 36)
					{
						if (1913 - 32623 != -30710)
						{
							continue;
						}
						hashtable.Add(47, "ForestCamp");
						if (166162 - 306485 != -140323)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 51)
					{
						if (278372 - 122849 != 155523)
						{
							continue;
						}
						hashtable.Add(47, "MainStreet");
						if (263937 - 202635 != 61302)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 52)
					{
						if (30493 - 102768 == -72274)
						{
							continue;
						}
						hashtable.Add(47, "CentralSquare");
						if (3362 - 120535 != -117173)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 53)
					{
						if (226521 - 116736 != 109785)
						{
							continue;
						}
						hashtable.Add(47, "CityLibrary");
						if (73529 - 368574 == -295044)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 54)
					{
						if (235445 - 1611 != 233834)
						{
							continue;
						}
						hashtable.Add(47, "LightPark");
						if (9092 - 300228 != -291136)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 55)
					{
						if (234037 - 492261 == -258223)
						{
							continue;
						}
						hashtable.Add(47, "LightPalace");
						if (30758 - 262160 != -231402)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 56)
					{
						if (142002 - 356255 != -214253)
						{
							continue;
						}
						hashtable.Add(47, "PlainColosseum");
						if (128248 - 269772 == -141523)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 57)
					{
						if (201691 - 159146 != 42545)
						{
							continue;
						}
						hashtable.Add(47, "LightTheater");
						if (163993 - 465233 != -301240)
						{
							continue;
						}
					}
					hashtable.Add(21, PhotonClient.cInt16(Mathf.Clamp(PlayerPrefs.GetInt("channel", 0), 0, 99)));
					if (43546 - 94401 == -50855)
					{
						this.R4knnumHh91.OpCustom(42, hashtable, true);
						if (17854 - 253241 != -235386)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x060097BB RID: 38843 RVA: 0x011DEEB0 File Offset: 0x011DD0B0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onJoinTown()
	{
		Game.mGameStage = 0;
		Game.loadNextLevel();
	}

	// Token: 0x060097BC RID: 38844 RVA: 0x011DEEC0 File Offset: 0x011DD0C0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x060097BD RID: 38845 RVA: 0x011DEEC4 File Offset: 0x011DD0C4
	internal static bool nuGAKyV85HI3fC8KaJXy()
	{
		return true;
	}

	// Token: 0x060097BE RID: 38846 RVA: 0x011DEEC8 File Offset: 0x011DD0C8
	internal static bool soP5BbV8pLJlIWSE753V()
	{
		return false;
	}

	// Token: 0x04008CBA RID: 36026
	private LitePeer R4knnumHh91;

	// Token: 0x04008CBB RID: 36027
	private PlayerCameraControl QVBnnyI6qQD;

	// Token: 0x04008CBC RID: 36028
	private float jnWnnVq3jGV;

	// Token: 0x04008CBD RID: 36029
	public Texture title_chapterComplete;

	// Token: 0x04008CBE RID: 36030
	private int VblnnhsGw1t;

	// Token: 0x04008CBF RID: 36031
	private float z2KnnKrm0Ef;

	// Token: 0x04008CC0 RID: 36032
	public GameObject luminousDawn;

	// Token: 0x04008CC1 RID: 36033
	public AudioClip luminousDawn_vc;

	// Token: 0x04008CC2 RID: 36034
	private int K9cnnzg77jv;

	// Token: 0x02001970 RID: 6512
	[CompilerGenerated]
	[Serializable]
	internal sealed class $onGameComplete$42298 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x060097BF RID: 38847 RVA: 0x011DEECC File Offset: 0x011DD0CC
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $onGameComplete$42298(Hashtable data, M917_WarRepose1 self_)
		{
			if (116375 - 167881 != -51505)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (217841 - 409580 == -191739)
				{
					base..ctor();
					if (151102 - 56537 == 94565)
					{
						this.$data$42301 = data;
						if (63744 - 114605 == -50861)
						{
							this.$self_$42302 = self_;
							if (170569 - 329462 == -158893)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x060097C0 RID: 38848 RVA: 0x011DEF88 File Offset: 0x011DD188
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M917_WarRepose1.$onGameComplete$42298.$(this.$data$42301, this.$self_$42302);
		}

		// Token: 0x060097C1 RID: 38849 RVA: 0x011DEF9C File Offset: 0x011DD19C
		internal static bool pQDevVV8VDX8BrDI8pHM()
		{
			return true;
		}

		// Token: 0x060097C2 RID: 38850 RVA: 0x011DEFA0 File Offset: 0x011DD1A0
		internal static bool FrNVymV8tyHQV5y7tDND()
		{
			return false;
		}

		// Token: 0x04008CC3 RID: 36035
		internal Hashtable $data$42301;

		// Token: 0x04008CC4 RID: 36036
		internal M917_WarRepose1 $self_$42302;

		// Token: 0x02001971 RID: 6513
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x060097C3 RID: 38851 RVA: 0x011DEFA4 File Offset: 0x011DD1A4
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Hashtable data, M917_WarRepose1 self_)
			{
				if (231500 - 94283 != 137217)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (64483 - 345535 != -281051)
					{
						base..ctor();
						if (98014 - 189403 != -91388)
						{
							this.$data$42299 = data;
							if (2529 - 182803 == -180274)
							{
								this.$self_$42300 = self_;
								if (138510 - 114750 != 23761)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x060097C4 RID: 38852 RVA: 0x011DF060 File Offset: 0x011DD260
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (211014 - 245344 != -34329)
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
						this.$self_$42300.SendMessage("fadeOut");
						if (192310 - 130059 != 62251)
						{
							continue;
						}
						this.$self_$42300.StartCoroutine_Auto(this.$self_$42300.ReturnToTown());
						if (172912 - 525416 == -352503)
						{
							continue;
						}
						this.YieldDefault(1);
						if (69043 - 456649 != -387605)
						{
							goto Block_6;
						}
						continue;
					default:
						if (64740 - 12340 == 52401)
						{
							continue;
						}
						break;
					}
					Debug.Log("OnGameComplete:" + this.$data$42299[31]);
					if (159623 - 171556 != -11932)
					{
						if (Game.mGameState > eGameState.AllHold)
						{
							if (26780 - 104145 != -77364)
							{
								break;
							}
						}
						else
						{
							Game.mGameState = eGameState.Complete;
							if (212368 - 262743 == -50375)
							{
								this.$self_$42300.VblnnhsGw1t = 2;
								if (236055 - 433841 != -197785)
								{
									this.$self_$42300.z2KnnKrm0Ef = Time.time;
									if (94007 - 525160 != -431152)
									{
										goto Block_7;
									}
								}
							}
						}
					}
				}
				Block_6:
				goto IL_1B3;
				Block_7:
				return this.Yield(2, new WaitForSeconds(4f));
				IL_1B3:
				return false;
			}

			// Token: 0x060097C5 RID: 38853 RVA: 0x011DF234 File Offset: 0x011DD434
			internal static bool po0rUJV8NmCdy8iwQ05H()
			{
				return true;
			}

			// Token: 0x060097C6 RID: 38854 RVA: 0x011DF238 File Offset: 0x011DD438
			internal static bool aCMdVOV8Y5jTCDw9Zvuy()
			{
				return false;
			}

			// Token: 0x04008CC5 RID: 36037
			internal Hashtable $data$42299;

			// Token: 0x04008CC6 RID: 36038
			internal M917_WarRepose1 $self_$42300;
		}
	}

	// Token: 0x02001972 RID: 6514
	[CompilerGenerated]
	[Serializable]
	internal sealed class $AcaciaEvent$42303 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x060097C7 RID: 38855 RVA: 0x011DF23C File Offset: 0x011DD43C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $AcaciaEvent$42303(M917_WarRepose1 self_)
		{
			if (111757 - 259480 != -147723)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (86610 - 581664 == -495054)
				{
					base..ctor();
					if (143641 - 263429 != -119787)
					{
						this.$self_$42310 = self_;
						if (7410 - 537173 == -529763)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x060097C8 RID: 38856 RVA: 0x011DF2D4 File Offset: 0x011DD4D4
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M917_WarRepose1.$AcaciaEvent$42303.$(this.$self_$42310);
		}

		// Token: 0x060097C9 RID: 38857 RVA: 0x011DF2E4 File Offset: 0x011DD4E4
		internal static bool WKfguHV8cewFJqNUQQvE()
		{
			return true;
		}

		// Token: 0x060097CA RID: 38858 RVA: 0x011DF2E8 File Offset: 0x011DD4E8
		internal static bool vunVCXV8UhD7uwRWEjLH()
		{
			return false;
		}

		// Token: 0x04008CC7 RID: 36039
		internal M917_WarRepose1 $self_$42310;

		// Token: 0x02001973 RID: 6515
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x060097CB RID: 38859 RVA: 0x011DF2EC File Offset: 0x011DD4EC
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M917_WarRepose1 self_)
			{
				if (19130 - 377339 != -358209)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (32605 - 345575 != -312969)
					{
						base..ctor();
						if (223645 - 118562 == 105083)
						{
							this.$self_$42309 = self_;
							if (272619 - 354226 != -81606)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x060097CC RID: 38860 RVA: 0x011DF384 File Offset: 0x011DD584
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (150756 - 488229 != -337473)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						goto IL_FA8;
					case 1:
						goto IL_1F35;
					case 2:
						if (Game.mGameState != eGameState.Start)
						{
							if (48899 - 546077 != -497177)
							{
								goto Block_48;
							}
							continue;
						}
						else
						{
							this.$mStoryTimer$42308 = 0f;
							if (4750 - 598605 == -593854)
							{
								continue;
							}
							this.$mStoryGui$42307.startStoryMessage("Walrus", "Reggu", eTalkType.friend);
							if (150323 - 553084 != -402761)
							{
								continue;
							}
							goto IL_A96;
						}
						break;
					case 3:
						if (Game.mGameState != eGameState.Start)
						{
							if (101016 - 532872 != -431855)
							{
								goto Block_77;
							}
							continue;
						}
						else
						{
							this.$mStoryGui$42307.newStoryMessage("Walrus", "Reggu", Language.getMessage("M917_WarRepose", 1001), eTalkType.friend);
							if (244663 - 67764 != 176899)
							{
								continue;
							}
							this.$mStoryTimer$42308 = Time.time + 4f;
							if (208362 - 213574 != -5211)
							{
								goto Block_101;
							}
							continue;
						}
						break;
					case 4:
						goto IL_811;
					case 5:
						goto IL_811;
					case 6:
						goto IL_1C5D;
					case 7:
						goto IL_1C5D;
					case 8:
						goto IL_6EB;
					case 9:
						goto IL_6EB;
					case 10:
						goto IL_D2C;
					case 11:
						goto IL_D2C;
					case 12:
						goto IL_BFB;
					case 13:
						goto IL_BFB;
					case 14:
						goto IL_90E;
					case 15:
						goto IL_90E;
					case 16:
						goto IL_1301;
					case 17:
						goto IL_1301;
					case 18:
						goto IL_1354;
					case 19:
						goto IL_1354;
					case 20:
						break;
					case 21:
						break;
					case 22:
						goto IL_15A8;
					case 23:
						goto IL_15A8;
					case 24:
						goto IL_73E;
					case 25:
						goto IL_73E;
					case 26:
						goto IL_7C0;
					case 27:
						goto IL_7C0;
					case 28:
						goto IL_EB8;
					case 29:
						goto IL_EB8;
					case 30:
						goto IL_391;
					case 31:
						goto IL_391;
					case 32:
						if (Game.mGameState != eGameState.Start)
						{
							if (123470 - 115923 != 7547)
							{
								continue;
							}
							goto IL_5DB;
						}
						else
						{
							if (!this.$mLightGod$42304)
							{
								goto IL_E1E;
							}
							if (180538 - 55700 == 124839)
							{
								continue;
							}
							this.$mLightGod$42304.animation.CrossFade("cast");
							if (181717 - 281366 != -99649)
							{
								continue;
							}
							this.$mLightGod$42304.animation.wrapMode = WrapMode.Once;
							if (203438 - 417784 == -214345)
							{
								continue;
							}
							if (this.$self_$42309.luminousDawn)
							{
								if (1466 - 228363 != -226897)
								{
									continue;
								}
								UnityEngine.Object.Instantiate(this.$self_$42309.luminousDawn, this.$mLightGod$42304.transform.position, this.$mLightGod$42304.transform.rotation);
								if (278610 - 559895 != -281285)
								{
									continue;
								}
							}
							else
							{
								Debug.LogError("Missing luminousDawn effect");
								if (141928 - 260965 != -119037)
								{
									continue;
								}
							}
							if (PlayerPrefs.GetInt("nvoice", 1) == 0)
							{
								goto IL_E1E;
							}
							if (79723 - 511378 != -431655)
							{
								continue;
							}
							if (this.$self_$42309.luminousDawn_vc)
							{
								if (218158 - 452463 == -234304)
								{
									continue;
								}
								this.$self_$42309.audio.PlayOneShot(this.$self_$42309.luminousDawn_vc);
								if (149324 - 335678 != -186354)
								{
									continue;
								}
								goto IL_69A;
							}
							else
							{
								Debug.LogError("Cannot find luminousDawn voice");
								if (249699 - 472911 != -223211)
								{
									goto Block_51;
								}
								continue;
							}
						}
						break;
					case 33:
						if (Game.mGameState != eGameState.Start)
						{
							if (294179 - 419501 != -125322)
							{
								continue;
							}
							goto IL_1060;
						}
						else
						{
							this.$self_$42309.SendMessage("fadeOut");
							if (167332 - 130117 != 37216)
							{
								goto Block_120;
							}
							continue;
						}
						break;
					case 34:
						if (Game.mGameState != eGameState.Start)
						{
							if (171221 - 182627 != -11405)
							{
								goto Block_127;
							}
							continue;
						}
						else
						{
							if (this.$mLightGod$42304)
							{
								if (91517 - 8095 == 83423)
								{
									continue;
								}
								this.$mLightGod$42304.animation.CrossFade("root");
								if (177034 - 64940 == 112095)
								{
									continue;
								}
								this.$mLightGod$42304.animation.wrapMode = WrapMode.Loop;
								if (115170 - 286762 != -171592)
								{
									continue;
								}
							}
							this.$self_$42309.SendMessage("fadeIn");
							if (19485 - 173304 != -153819)
							{
								continue;
							}
							goto IL_1AAB;
						}
						break;
					case 35:
						if (Game.mGameState != eGameState.Start)
						{
							if (38880 - 128250 != -89370)
							{
								continue;
							}
							goto IL_E5A;
						}
						else
						{
							this.$mStoryGui$42307.startStoryMessage("Walrus", "Reggu", eTalkType.friend);
							if (241975 - 308013 != -66038)
							{
								continue;
							}
							goto IL_1A6F;
						}
						break;
					case 36:
						if (Game.mGameState != eGameState.Start)
						{
							if (103409 - 274187 != -170777)
							{
								goto Block_194;
							}
							continue;
						}
						else
						{
							this.$mStoryGui$42307.newStoryMessage("Walrus", "Reggu", Language.getMessage("M917_WarRepose", 1015), eTalkType.friend);
							if (173920 - 143053 != 30867)
							{
								continue;
							}
							this.$mStoryTimer$42308 = Time.time + 4f;
							if (214178 - 246338 != -32160)
							{
								continue;
							}
							goto IL_199E;
						}
						break;
					case 37:
						goto IL_19C7;
					case 38:
						goto IL_19C7;
					case 39:
						goto IL_533;
					case 40:
						goto IL_533;
					case 41:
						goto IL_5B1;
					case 42:
						goto IL_5B1;
					case 43:
						if (Game.mGameState != eGameState.Start)
						{
							if (23173 - 346001 != -322827)
							{
								goto Block_114;
							}
							continue;
						}
						else
						{
							this.$self_$42309.SendMessage("fadeOut");
							if (21664 - 119710 != -98045)
							{
								goto Block_63;
							}
							continue;
						}
						break;
					case 44:
						if (Game.mGameState != eGameState.Start)
						{
							if (4936 - 569691 != -564755)
							{
								continue;
							}
							goto IL_1CFB;
						}
						else
						{
							Game.sendMissionEvent(9171, 1);
							if (177203 - 76118 == 101086)
							{
								continue;
							}
							Application.LoadLevel("M917_WarRepose2");
							if (88350 - 251858 != -163507)
							{
								goto IL_43F;
							}
							continue;
						}
						break;
					default:
						if (267770 - 185460 != 82310)
						{
							continue;
						}
						goto IL_FA8;
					}
					if (this.$mStoryTimer$42308 > Time.time)
					{
						if (159250 - 484833 != -325583)
						{
							continue;
						}
						if (!Input.GetKeyDown(KeyCode.Mouse0))
						{
							goto IL_331;
						}
						if (19904 - 413932 == -394027)
						{
							continue;
						}
					}
					if (Game.mGameState != eGameState.Start)
					{
						if (92579 - 447155 != -354576)
						{
							continue;
						}
						break;
					}
					else
					{
						this.$mStoryGui$42307.newStoryMessage("LightGod", "Alcacia", Language.getMessage("M917_WarRepose", 1010), eTalkType.friend);
						if (184436 - 496064 != -311628)
						{
							continue;
						}
						this.$mStoryTimer$42308 = Time.time + 4f;
						if (36466 - 349948 == -313481)
						{
							continue;
						}
						if (!this.$mLightGod$42304)
						{
							goto IL_157F;
						}
						if (187431 - 264591 == -77159)
						{
							continue;
						}
						this.$mLightGod$42304.animation.CrossFade("talk");
						if (105549 - 182638 != -77089)
						{
							continue;
						}
						goto IL_157F;
					}
					IL_6EB:
					if (this.$mStoryTimer$42308 > Time.time)
					{
						if (174214 - 384398 == -210183)
						{
							continue;
						}
						if (!Input.GetKeyDown(KeyCode.Mouse0))
						{
							goto IL_6DE;
						}
						if (108621 - 310966 == -202344)
						{
							continue;
						}
					}
					if (Game.mGameState != eGameState.Start)
					{
						if (168379 - 204946 != -36566)
						{
							break;
						}
						continue;
					}
					else
					{
						this.$mStoryGui$42307.newStoryMessage("LightGod", "Alcacia", Language.getMessage("M917_WarRepose", 1004), eTalkType.friend);
						if (64410 - 451304 != -386894)
						{
							continue;
						}
						this.$mStoryTimer$42308 = Time.time + 4f;
						if (12474 - 327810 == -315335)
						{
							continue;
						}
						if (!this.$mLightGod$42304)
						{
							goto IL_D03;
						}
						if (45405 - 9406 == 36000)
						{
							continue;
						}
						this.$mLightGod$42304.animation.CrossFade("root");
						if (95642 - 336408 != -240765)
						{
							goto Block_75;
						}
						continue;
					}
					IL_1354:
					if (this.$mStoryTimer$42308 > Time.time)
					{
						if (283654 - 330933 != -47279)
						{
							continue;
						}
						if (!Input.GetKeyDown(KeyCode.Mouse0))
						{
							goto IL_1347;
						}
						if (204409 - 130703 != 73706)
						{
							continue;
						}
					}
					if (Game.mGameState != eGameState.Start)
					{
						if (25298 - 500879 != -475580)
						{
							break;
						}
						continue;
					}
					else
					{
						this.$mStoryGui$42307.newStoryMessage("LightGod", "Alcacia", Language.getMessage("M917_WarRepose", 1009), eTalkType.friend);
						if (101909 - 580287 != -478378)
						{
							continue;
						}
						this.$mStoryTimer$42308 = Time.time + 4f;
						if (263861 - 11264 != 252597)
						{
							continue;
						}
						if (!this.$mWalrus$42305)
						{
							goto IL_315;
						}
						if (237850 - 227028 == 10823)
						{
							continue;
						}
						this.$mWalrus$42305.animation.CrossFade("root");
						if (126876 - 70249 != 56628)
						{
							goto Block_174;
						}
						continue;
					}
					IL_BFB:
					if (this.$mStoryTimer$42308 > Time.time)
					{
						if (112737 - 192720 != -79983)
						{
							continue;
						}
						if (!Input.GetKeyDown(KeyCode.Mouse0))
						{
							goto IL_BEE;
						}
						if (297163 - 5197 == 291967)
						{
							continue;
						}
					}
					if (Game.mGameState != eGameState.Start)
					{
						if (173586 - 476470 != -302884)
						{
							continue;
						}
						break;
					}
					else
					{
						this.$mStoryGui$42307.newStoryMessage("LightGod", "Alcacia", Language.getMessage("M917_WarRepose", 1006), eTalkType.friend);
						if (23966 - 311842 == -287875)
						{
							continue;
						}
						this.$mStoryTimer$42308 = Time.time + 4f;
						if (237963 - 159117 != 78847)
						{
							goto Block_134;
						}
						continue;
					}
					IL_73E:
					if (this.$mStoryTimer$42308 > Time.time)
					{
						if (93071 - 256055 == -162983)
						{
							continue;
						}
						if (!Input.GetKeyDown(KeyCode.Mouse0))
						{
							goto IL_731;
						}
						if (164835 - 369686 != -204851)
						{
							continue;
						}
					}
					if (Game.mGameState != eGameState.Start)
					{
						if (105811 - 341143 != -235332)
						{
							continue;
						}
						break;
					}
					else
					{
						this.$mStoryGui$42307.newStoryMessage("Walrus", "Reggu", Language.getMessage("M917_WarRepose", 1012), eTalkType.friend);
						if (198869 - 387408 != -188539)
						{
							continue;
						}
						this.$mStoryTimer$42308 = Time.time + 4f;
						if (190905 - 352946 == -162040)
						{
							continue;
						}
						if (!this.$mWalrus$42305)
						{
							goto IL_797;
						}
						if (221850 - 75823 == 146028)
						{
							continue;
						}
						this.$mWalrus$42305.animation.CrossFade("talk");
						if (60906 - 565265 != -504358)
						{
							goto Block_199;
						}
						continue;
					}
					IL_391:
					if (this.$mStoryTimer$42308 > Time.time)
					{
						if (100699 - 183003 == -82303)
						{
							continue;
						}
						if (!Input.GetKeyDown(KeyCode.Mouse0))
						{
							goto IL_384;
						}
						if (11484 - 105927 != -94443)
						{
							continue;
						}
					}
					if (Game.mGameState != eGameState.Start)
					{
						if (21093 - 296393 != -275300)
						{
							continue;
						}
						break;
					}
					else
					{
						this.$mStoryGui$42307.close();
						if (186362 - 267073 != -80711)
						{
							continue;
						}
						if (!this.$mWalrus$42305)
						{
							goto IL_173C;
						}
						if (163319 - 108866 != 54453)
						{
							continue;
						}
						this.$mWalrus$42305.transform.rotation = this.$mWalrusDir$42306;
						if (99616 - 121675 != -22059)
						{
							continue;
						}
						goto IL_173C;
					}
					IL_43F:
					this.YieldDefault(1);
					if (90520 - 88897 != 1623)
					{
						continue;
					}
					break;
					IL_533:
					if (this.$mStoryTimer$42308 > Time.time)
					{
						if (280042 - 56958 != 223084)
						{
							continue;
						}
						if (!Input.GetKeyDown(KeyCode.Mouse0))
						{
							goto IL_526;
						}
						if (177954 - 434191 == -256236)
						{
							continue;
						}
					}
					if (Game.mGameState != eGameState.Start)
					{
						if (244164 - 340885 != -96721)
						{
							continue;
						}
						break;
					}
					else
					{
						this.$mStoryGui$42307.newStoryMessage("LightGod", "Alcacia", Language.getMessage("M917_WarRepose", 1017), eTalkType.friend);
						if (102027 - 193832 == -91804)
						{
							continue;
						}
						this.$mStoryTimer$42308 = Time.time + 4f;
						if (43926 - 569543 != -525616)
						{
							goto Block_81;
						}
						continue;
					}
					IL_5B1:
					if (this.$mStoryTimer$42308 > Time.time)
					{
						if (285180 - 18933 == 266248)
						{
							continue;
						}
						if (!Input.GetKeyDown(KeyCode.Mouse0))
						{
							goto IL_5A4;
						}
						if (108611 - 285953 != -177342)
						{
							continue;
						}
					}
					if (Game.mGameState != eGameState.Start)
					{
						if (232931 - 560627 != -327696)
						{
							continue;
						}
						break;
					}
					else
					{
						this.$mStoryGui$42307.close();
						if (197923 - 175982 != 21941)
						{
							continue;
						}
						goto IL_F6C;
					}
					IL_7C0:
					if (this.$mStoryTimer$42308 > Time.time)
					{
						if (206714 - 170612 == 36103)
						{
							continue;
						}
						if (!Input.GetKeyDown(KeyCode.Mouse0))
						{
							goto IL_7B3;
						}
						if (199365 - 115126 != 84239)
						{
							continue;
						}
					}
					if (Game.mGameState != eGameState.Start)
					{
						if (191545 - 580165 != -388619)
						{
							break;
						}
						continue;
					}
					else
					{
						this.$mStoryGui$42307.newStoryMessage("LightGod", "Alcacia", Language.getMessage("M917_WarRepose", 1013), eTalkType.friend);
						if (284098 - 483481 == -199382)
						{
							continue;
						}
						this.$mStoryTimer$42308 = Time.time + 4f;
						if (92125 - 484571 == -392445)
						{
							continue;
						}
						if (!this.$mWalrus$42305)
						{
							goto IL_E8F;
						}
						if (243012 - 247811 == -4798)
						{
							continue;
						}
						this.$mWalrus$42305.animation.CrossFade("root");
						if (87952 - 270589 != -182637)
						{
							continue;
						}
						goto IL_E8F;
					}
					IL_811:
					if (this.$mStoryTimer$42308 > Time.time)
					{
						if (201613 - 266089 == -64475)
						{
							continue;
						}
						if (!Input.GetKeyDown(KeyCode.Mouse0))
						{
							goto IL_805;
						}
						if (47127 - 516541 == -469413)
						{
							continue;
						}
					}
					if (Game.mGameState != eGameState.Start)
					{
						if (263004 - 264287 != -1283)
						{
							continue;
						}
						break;
					}
					else
					{
						this.$mStoryGui$42307.newStoryMessage("LightGod", "Alcacia", Language.getMessage("M917_WarRepose", 1002), eTalkType.friend);
						if (151285 - 38146 != 113139)
						{
							continue;
						}
						this.$mStoryTimer$42308 = Time.time + 4f;
						if (210613 - 572069 == -361455)
						{
							continue;
						}
						if (!this.$mLightGod$42304)
						{
							goto IL_1C36;
						}
						if (178772 - 525224 != -346452)
						{
							continue;
						}
						this.$mLightGod$42304.animation.CrossFade("talk");
						if (203382 - 221036 != -17654)
						{
							continue;
						}
						goto IL_1C36;
					}
					IL_90E:
					if (this.$mStoryTimer$42308 > Time.time)
					{
						if (195964 - 43007 != 152957)
						{
							continue;
						}
						if (!Input.GetKeyDown(KeyCode.Mouse0))
						{
							goto IL_901;
						}
						if (16273 - 233716 == -217442)
						{
							continue;
						}
					}
					if (Game.mGameState != eGameState.Start)
					{
						if (192986 - 416135 != -223149)
						{
							continue;
						}
						break;
					}
					else
					{
						this.$mStoryGui$42307.newStoryMessage("Walrus", "Reggu", Language.getMessage("M917_WarRepose", 1007), eTalkType.friend);
						if (231770 - 47711 == 184060)
						{
							continue;
						}
						this.$mStoryTimer$42308 = Time.time + 4f;
						if (163828 - 284553 != -120725)
						{
							continue;
						}
						if (!this.$mWalrus$42305)
						{
							goto IL_12D8;
						}
						if (67644 - 497409 != -429765)
						{
							continue;
						}
						this.$mWalrus$42305.animation.CrossFade("talk");
						if (145174 - 327068 != -181894)
						{
							continue;
						}
						this.$mWalrus$42305.transform.rotation = Quaternion.LookRotation(global::Math.vFlat(this.$mLightGod$42304.transform.position - this.$mWalrus$42305.transform.position));
						if (95230 - 87170 != 8060)
						{
							continue;
						}
						goto IL_12D8;
					}
					IL_1C5D:
					if (this.$mStoryTimer$42308 > Time.time)
					{
						if (13867 - 477015 == -463147)
						{
							continue;
						}
						if (!Input.GetKeyDown(KeyCode.Mouse0))
						{
							goto IL_1C51;
						}
						if (150440 - 78521 != 71919)
						{
							continue;
						}
					}
					if (Game.mGameState != eGameState.Start)
					{
						if (105705 - 512248 != -406543)
						{
							continue;
						}
						break;
					}
					else
					{
						this.$mStoryGui$42307.newStoryMessage("LightGod", "Alcacia", Language.getMessage("M917_WarRepose", 1003), eTalkType.friend);
						if (133891 - 425125 != -291234)
						{
							continue;
						}
						this.$mStoryTimer$42308 = Time.time + 4f;
						if (229827 - 447759 != -217931)
						{
							goto Block_70;
						}
						continue;
					}
					IL_19C7:
					if (this.$mStoryTimer$42308 > Time.time)
					{
						if (272895 - 152081 == 120815)
						{
							continue;
						}
						if (!Input.GetKeyDown(KeyCode.Mouse0))
						{
							goto IL_19BA;
						}
						if (252122 - 468555 != -216433)
						{
							continue;
						}
					}
					if (Game.mGameState != eGameState.Start)
					{
						if (205469 - 189317 != 16152)
						{
							continue;
						}
						break;
					}
					else
					{
						this.$mStoryGui$42307.newStoryMessage("Walrus", "Reggu", Language.getMessage("M917_WarRepose", 1016), eTalkType.friend);
						if (77619 - 165660 != -88041)
						{
							continue;
						}
						this.$mStoryTimer$42308 = Time.time + 4f;
						if (58121 - 343040 != -284918)
						{
							goto Block_71;
						}
						continue;
					}
					IL_FA8:
					this.$mLightGod$42304 = GameObject.Find("LightGod");
					if (236533 - 505898 != -269365)
					{
						continue;
					}
					this.$mWalrus$42305 = GameObject.Find("Walrus");
					if (140879 - 29990 != 110889)
					{
						continue;
					}
					this.$mWalrusDir$42306 = this.$mWalrus$42305.transform.rotation;
					if (165890 - 171986 == -6095)
					{
						continue;
					}
					this.$mStoryGui$42307 = (StoryGui)this.$self_$42309.GetComponent(typeof(StoryGui));
					if (166906 - 283644 == -116737)
					{
						continue;
					}
					if (!this.$mStoryGui$42307)
					{
						if (90320 - 399022 == -308701)
						{
							continue;
						}
						Debug.LogError("Missing StoryGui Component");
						if (71719 - 540652 != -468933)
						{
							continue;
						}
						goto IL_43F;
					}
					else
					{
						Game.mGameState = eGameState.Start;
						if (73429 - 357892 != -284463)
						{
							continue;
						}
						Game.mStateTime = Time.time;
						if (231212 - 444441 == -213228)
						{
							continue;
						}
						this.$self_$42309.QVBnnyI6qQD.alignToObject("EventCamera1");
						if (13255 - 392475 != -379220)
						{
							continue;
						}
						this.$self_$42309.SendMessage("fadeIn");
						if (83094 - 112903 == -29808)
						{
							continue;
						}
						this.$self_$42309.QVBnnyI6qQD.StartCoroutine_Auto(this.$self_$42309.QVBnnyI6qQD.slerpToObject("EventCamera2", (float)2));
						if (108341 - 210808 != -102466)
						{
							goto Block_220;
						}
						continue;
					}
					IL_D2C:
					if (this.$mStoryTimer$42308 > Time.time)
					{
						if (257122 - 242576 != 14546)
						{
							continue;
						}
						if (!Input.GetKeyDown(KeyCode.Mouse0))
						{
							goto IL_D1F;
						}
						if (51040 - 439350 != -388310)
						{
							continue;
						}
					}
					if (Game.mGameState != eGameState.Start)
					{
						if (18501 - 199768 != -181266)
						{
							break;
						}
						continue;
					}
					else
					{
						this.$mStoryGui$42307.newStoryMessage("LightGod", "Alcacia", Language.getMessage("M917_WarRepose", 1005), eTalkType.friend);
						if (90467 - 33261 == 57207)
						{
							continue;
						}
						this.$mStoryTimer$42308 = Time.time + 4f;
						if (288833 - 107025 != 181808)
						{
							continue;
						}
						goto IL_BD2;
					}
					IL_EB8:
					if (this.$mStoryTimer$42308 > Time.time)
					{
						if (188264 - 316098 != -127834)
						{
							continue;
						}
						if (!Input.GetKeyDown(KeyCode.Mouse0))
						{
							goto IL_EAB;
						}
						if (228218 - 200383 == 27836)
						{
							continue;
						}
					}
					if (Game.mGameState != eGameState.Start)
					{
						if (237251 - 567140 != -329888)
						{
							break;
						}
						continue;
					}
					else
					{
						this.$mStoryGui$42307.newStoryMessage("LightGod", "Alcacia", Language.getMessage("M917_WarRepose", 1014), eTalkType.friend);
						if (70741 - 198360 == -127618)
						{
							continue;
						}
						this.$mStoryTimer$42308 = Time.time + 2f;
						if (134579 - 375175 == -240595)
						{
							continue;
						}
						if (!this.$mLightGod$42304)
						{
							goto IL_368;
						}
						if (67999 - 567223 != -499224)
						{
							continue;
						}
						this.$mLightGod$42304.animation.CrossFade("command");
						if (216450 - 427183 != -210733)
						{
							continue;
						}
						goto IL_368;
					}
					IL_1301:
					if (this.$mStoryTimer$42308 > Time.time)
					{
						if (215293 - 589460 != -374167)
						{
							continue;
						}
						if (!Input.GetKeyDown(KeyCode.Mouse0))
						{
							goto IL_12F4;
						}
						if (215420 - 444069 == -228648)
						{
							continue;
						}
					}
					if (Game.mGameState != eGameState.Start)
					{
						if (127513 - 150088 != -22574)
						{
							break;
						}
						continue;
					}
					else
					{
						this.$mStoryGui$42307.newStoryMessage("Walrus", "Reggu", Language.getMessage("M917_WarRepose", 1008), eTalkType.friend);
						if (34401 - 34134 == 268)
						{
							continue;
						}
						this.$mStoryTimer$42308 = Time.time + 4f;
						if (268155 - 78248 != 189908)
						{
							goto Block_65;
						}
						continue;
					}
					IL_15A8:
					if (this.$mStoryTimer$42308 > Time.time)
					{
						if (22365 - 459601 == -437235)
						{
							continue;
						}
						if (!Input.GetKeyDown(KeyCode.Mouse0))
						{
							goto IL_159B;
						}
						if (242792 - 268787 != -25995)
						{
							continue;
						}
					}
					if (Game.mGameState != eGameState.Start)
					{
						if (171493 - 99858 != 71636)
						{
							break;
						}
					}
					else
					{
						this.$mStoryGui$42307.newStoryMessage("LightGod", "Alcacia", Language.getMessage("M917_WarRepose", 1011), eTalkType.friend);
						if (234359 - 561579 != -327219)
						{
							this.$mStoryTimer$42308 = Time.time + 4f;
							if (106317 - 285916 != -179598)
							{
								if (!this.$mLightGod$42304)
								{
									goto IL_715;
								}
								if (5941 - 342529 != -336587)
								{
									this.$mLightGod$42304.animation.CrossFade("root");
									if (37388 - 326124 != -288735)
									{
										goto Block_27;
									}
								}
							}
						}
					}
				}
				goto IL_1F35;
				Block_27:
				goto IL_715;
				IL_315:
				return this.Yield(20, new WaitForSeconds(0.5f));
				IL_331:
				return this.YieldDefault(21);
				IL_368:
				return this.Yield(30, new WaitForSeconds(0.5f));
				IL_384:
				return this.YieldDefault(31);
				IL_526:
				return this.YieldDefault(40);
				IL_5A4:
				return this.YieldDefault(42);
				IL_5DB:
				Block_48:
				goto IL_1F35;
				IL_69A:
				Block_51:
				goto IL_E1E;
				IL_6DE:
				return this.YieldDefault(9);
				IL_715:
				return this.Yield(24, new WaitForSeconds(0.5f));
				IL_731:
				return this.YieldDefault(25);
				IL_797:
				return this.Yield(26, new WaitForSeconds(0.5f));
				IL_7B3:
				return this.YieldDefault(27);
				IL_805:
				return this.YieldDefault(5);
				Block_63:
				return this.Yield(44, new WaitForSeconds(1f));
				Block_65:
				return this.Yield(18, new WaitForSeconds(0.5f));
				IL_901:
				return this.YieldDefault(15);
				Block_70:
				return this.Yield(8, new WaitForSeconds(0.5f));
				Block_71:
				return this.Yield(39, new WaitForSeconds(0.5f));
				Block_75:
				goto IL_D03;
				IL_A96:
				return this.Yield(3, new WaitForSeconds(0.5f));
				Block_77:
				goto IL_1F35;
				Block_81:
				return this.Yield(41, new WaitForSeconds(0.5f));
				IL_BD2:
				return this.Yield(12, new WaitForSeconds(0.5f));
				IL_BEE:
				return this.YieldDefault(13);
				goto IL_1F35;
				IL_D03:
				return this.Yield(10, new WaitForSeconds(0.5f));
				IL_D1F:
				return this.YieldDefault(11);
				goto IL_1F35;
				Block_101:
				return this.Yield(4, new WaitForSeconds(0.5f));
				IL_E1E:
				return this.Yield(33, new WaitForSeconds(2f));
				IL_E5A:
				goto IL_1F35;
				IL_E8F:
				return this.Yield(28, new WaitForSeconds(0.5f));
				IL_EAB:
				return this.YieldDefault(29);
				goto IL_1F35;
				IL_F6C:
				return this.Yield(43, new WaitForSeconds(0.5f));
				Block_114:
				IL_1060:
				goto IL_1F35;
				Block_120:
				return this.Yield(34, new WaitForSeconds(0.6f));
				Block_127:
				goto IL_1F35;
				Block_134:
				return this.Yield(14, new WaitForSeconds(0.5f));
				goto IL_1F35;
				IL_12D8:
				return this.Yield(16, new WaitForSeconds(0.5f));
				IL_12F4:
				return this.YieldDefault(17);
				IL_1347:
				return this.YieldDefault(19);
				goto IL_1F35;
				IL_157F:
				return this.Yield(22, new WaitForSeconds(0.5f));
				IL_159B:
				return this.YieldDefault(23);
				IL_173C:
				return this.Yield(32, new WaitForSeconds(0.5f));
				Block_174:
				goto IL_315;
				goto IL_1F35;
				IL_199E:
				return this.Yield(37, new WaitForSeconds(0.5f));
				IL_19BA:
				return this.YieldDefault(38);
				IL_1A6F:
				return this.Yield(36, new WaitForSeconds(0.5f));
				Block_194:
				goto IL_1F35;
				IL_1AAB:
				return this.Yield(35, new WaitForSeconds(0.5f));
				Block_199:
				goto IL_797;
				goto IL_1F35;
				IL_1C36:
				return this.Yield(6, new WaitForSeconds(0.5f));
				IL_1C51:
				return this.YieldDefault(7);
				IL_1CFB:
				goto IL_1F35;
				Block_220:
				return this.Yield(2, new WaitForSeconds(2f));
				IL_1F35:
				return false;
			}

			// Token: 0x060097CD RID: 38861 RVA: 0x011E12D8 File Offset: 0x011DF4D8
			internal static bool W75xCHV8TECrXQpsVd7I()
			{
				return true;
			}

			// Token: 0x060097CE RID: 38862 RVA: 0x011E12DC File Offset: 0x011DF4DC
			internal static bool WY9CveV83hrcJDCMydnE()
			{
				return false;
			}

			// Token: 0x04008CC8 RID: 36040
			internal GameObject $mLightGod$42304;

			// Token: 0x04008CC9 RID: 36041
			internal GameObject $mWalrus$42305;

			// Token: 0x04008CCA RID: 36042
			internal Quaternion $mWalrusDir$42306;

			// Token: 0x04008CCB RID: 36043
			internal StoryGui $mStoryGui$42307;

			// Token: 0x04008CCC RID: 36044
			internal float $mStoryTimer$42308;

			// Token: 0x04008CCD RID: 36045
			internal M917_WarRepose1 $self_$42309;
		}
	}

	// Token: 0x02001974 RID: 6516
	[CompilerGenerated]
	[Serializable]
	internal sealed class $onDeadPlayer$42311 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x060097CF RID: 38863 RVA: 0x011E12E0 File Offset: 0x011DF4E0
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $onDeadPlayer$42311(M917_WarRepose1 self_)
		{
			if (161300 - 444032 != -282731)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (14636 - 377274 == -362638)
				{
					base..ctor();
					if (189954 - 160182 == 29772)
					{
						this.$self_$42316 = self_;
						if (101282 - 123747 != -22464)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x060097D0 RID: 38864 RVA: 0x011E1378 File Offset: 0x011DF578
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M917_WarRepose1.$onDeadPlayer$42311.$(this.$self_$42316);
		}

		// Token: 0x060097D1 RID: 38865 RVA: 0x011E1388 File Offset: 0x011DF588
		internal static bool VWRvaMV8XfNaKcZJ2So5()
		{
			return true;
		}

		// Token: 0x060097D2 RID: 38866 RVA: 0x011E138C File Offset: 0x011DF58C
		internal static bool QQSMrKV8QKq4FhrSKm0e()
		{
			return false;
		}

		// Token: 0x04008CCE RID: 36046
		internal M917_WarRepose1 $self_$42316;

		// Token: 0x02001975 RID: 6517
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x060097D3 RID: 38867 RVA: 0x011E1390 File Offset: 0x011DF590
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M917_WarRepose1 self_)
			{
				if (120768 - 181634 != -60865)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (284198 - 542818 == -258620)
					{
						base..ctor();
						if (207442 - 230508 != -23065)
						{
							this.$self_$42315 = self_;
							if (162294 - 73852 != 88443)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x060097D4 RID: 38868 RVA: 0x011E1428 File Offset: 0x011DF628
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (26409 - 75024 != -48615)
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
							goto IL_2D9;
						}
						if (218197 - 368282 != -150085)
						{
							continue;
						}
						if (Game.mGameState == eGameState.Hold)
						{
							if (250663 - 527019 != -276356)
							{
								continue;
							}
							goto IL_2D9;
						}
						IL_1E8:
						this.YieldDefault(1);
						if (95414 - 463575 != -368160)
						{
							goto Block_18;
						}
						continue;
						IL_2D9:
						Game.mGameState = eGameState.Hold;
						if (20163 - 576038 == -555874)
						{
							continue;
						}
						this.$mStoryGui$42312 = (StoryGui)this.$self_$42315.GetComponent(typeof(StoryGui));
						if (290029 - 150291 != 139738)
						{
							continue;
						}
						if (this.$mStoryGui$42312)
						{
							if (215714 - 378874 != -163160)
							{
								continue;
							}
							this.$mStoryGui$42312.close();
							if (225873 - 536252 == -310378)
							{
								continue;
							}
						}
						this.$mChangeGui$42313 = (ChangeGui)this.$self_$42315.GetComponent(typeof(ChangeGui));
						if (33988 - 101912 == -67923)
						{
							continue;
						}
						if (this.$mChangeGui$42313)
						{
							if (118355 - 298658 != -180303)
							{
								continue;
							}
							this.$mChangeGui$42313.close();
							if (267091 - 296280 != -29189)
							{
								continue;
							}
						}
						this.$mGameGui$42314 = (GameGui)this.$self_$42315.GetComponent(typeof(GameGui));
						if (185537 - 100677 == 84861)
						{
							continue;
						}
						if (!this.$mGameGui$42314)
						{
							goto IL_1E8;
						}
						if (204211 - 397351 == -193139)
						{
							continue;
						}
						if (!this.$mGameGui$42314.enabled)
						{
							if (83533 - 597636 == -514102)
							{
								continue;
							}
							this.$mGameGui$42314.enabled = true;
							if (165657 - 324682 == -159024)
							{
								continue;
							}
						}
						this.$mGameGui$42314.openDeadMenu();
						if (248331 - 440883 != -192552)
						{
							continue;
						}
						goto IL_1E8;
					default:
						if (33645 - 154429 != -120784)
						{
							continue;
						}
						break;
					}
					Debug.Log("On Dead Player");
				}
				while (129094 - 520011 == -390916);
				return this.Yield(2, new WaitForSeconds((float)2));
				Block_18:
				IL_2F9:
				return false;
			}

			// Token: 0x060097D5 RID: 38869 RVA: 0x011E1740 File Offset: 0x011DF940
			internal static bool cxQT49V8kmslSxrmKKPg()
			{
				return true;
			}

			// Token: 0x060097D6 RID: 38870 RVA: 0x011E1744 File Offset: 0x011DF944
			internal static bool xwFRXXV8GGthtenL0mLt()
			{
				return false;
			}

			// Token: 0x04008CCF RID: 36047
			internal StoryGui $mStoryGui$42312;

			// Token: 0x04008CD0 RID: 36048
			internal ChangeGui $mChangeGui$42313;

			// Token: 0x04008CD1 RID: 36049
			internal GameGui $mGameGui$42314;

			// Token: 0x04008CD2 RID: 36050
			internal M917_WarRepose1 $self_$42315;
		}
	}

	// Token: 0x02001976 RID: 6518
	[CompilerGenerated]
	[Serializable]
	internal sealed class $onChangePlayer$42317 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x060097D7 RID: 38871 RVA: 0x011E1748 File Offset: 0x011DF948
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $onChangePlayer$42317(Hashtable data, M917_WarRepose1 self_)
		{
			if (176932 - 104266 != 72666)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (60039 - 296854 == -236815)
				{
					base..ctor();
					if (293787 - 52104 == 241683)
					{
						this.$data$42322 = data;
						if (157560 - 549765 != -392204)
						{
							this.$self_$42323 = self_;
							if (204798 - 422121 != -217322)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x060097D8 RID: 38872 RVA: 0x011E1804 File Offset: 0x011DFA04
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M917_WarRepose1.$onChangePlayer$42317.$(this.$data$42322, this.$self_$42323);
		}

		// Token: 0x060097D9 RID: 38873 RVA: 0x011E1818 File Offset: 0x011DFA18
		internal static bool oOB612V8HtitRmbMyPLX()
		{
			return true;
		}

		// Token: 0x060097DA RID: 38874 RVA: 0x011E181C File Offset: 0x011DFA1C
		internal static bool VYP4IXV8WsfoDAYCC4cE()
		{
			return false;
		}

		// Token: 0x04008CD3 RID: 36051
		internal Hashtable $data$42322;

		// Token: 0x04008CD4 RID: 36052
		internal M917_WarRepose1 $self_$42323;

		// Token: 0x02001977 RID: 6519
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x060097DB RID: 38875 RVA: 0x011E1820 File Offset: 0x011DFA20
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Hashtable data, M917_WarRepose1 self_)
			{
				if (256978 - 158594 != 98384)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (67902 - 406197 == -338295)
					{
						base..ctor();
						if (292552 - 182236 == 110316)
						{
							this.$data$42320 = data;
							if (202626 - 294365 == -91739)
							{
								this.$self_$42321 = self_;
								if (86811 - 387405 != -300593)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x060097DC RID: 38876 RVA: 0x011E18DC File Offset: 0x011DFADC
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (250357 - 102518 != 147840)
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
							if (123427 - 41520 == 81908)
							{
								continue;
							}
							Game.mGameState = eGameState.Normal;
							if (189005 - 196653 == -7647)
							{
								continue;
							}
							this.$mGameGui$42319 = (GameGui)this.$self_$42321.GetComponent(typeof(GameGui));
							if (82915 - 379630 != -296715)
							{
								continue;
							}
							this.$mGameGui$42319.enabled = true;
							if (69556 - 272244 != -202688)
							{
								continue;
							}
						}
						this.YieldDefault(1);
						if (179893 - 273505 != -93611)
						{
							goto Block_12;
						}
						continue;
					default:
						if (283458 - 148170 != 135288)
						{
							continue;
						}
						break;
					}
					UnityEngine.Object.Destroy(Game.mPlayer);
					if (266272 - 16871 == 249401)
					{
						this.$self_$42321.SendMessage("onCreatePlayer", this.$data$42320);
						if (269547 - 459518 == -189971)
						{
							this.$mChangeGui$42318 = (ChangeGui)this.$self_$42321.GetComponent(typeof(ChangeGui));
							if (147380 - 314327 != -166946)
							{
								if (!this.$mChangeGui$42318.enabled)
								{
									break;
								}
								if (475 - 230897 != -230421)
								{
									this.$mChangeGui$42318.close();
									if (101686 - 244091 != -142404)
									{
										break;
									}
								}
							}
						}
					}
				}
				IL_105:
				return this.Yield(2, new WaitForSeconds(1f));
				goto IL_105;
				Block_12:
				IL_205:
				return false;
			}

			// Token: 0x060097DD RID: 38877 RVA: 0x011E1B00 File Offset: 0x011DFD00
			internal static bool YckxM7V8Awu9AXtxF55Z()
			{
				return true;
			}

			// Token: 0x060097DE RID: 38878 RVA: 0x011E1B04 File Offset: 0x011DFD04
			internal static bool BkLxREV8lpkU3I0CY5Tm()
			{
				return false;
			}

			// Token: 0x04008CD5 RID: 36053
			internal ChangeGui $mChangeGui$42318;

			// Token: 0x04008CD6 RID: 36054
			internal GameGui $mGameGui$42319;

			// Token: 0x04008CD7 RID: 36055
			internal Hashtable $data$42320;

			// Token: 0x04008CD8 RID: 36056
			internal M917_WarRepose1 $self_$42321;
		}
	}

	// Token: 0x02001978 RID: 6520
	[CompilerGenerated]
	[Serializable]
	internal sealed class $ReturnToTown$42324 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x060097DF RID: 38879 RVA: 0x011E1B08 File Offset: 0x011DFD08
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $ReturnToTown$42324(M917_WarRepose1 self_)
		{
			if (214722 - 231553 != -16831)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (164894 - 554759 == -389865)
				{
					base..ctor();
					if (217592 - 360242 == -142650)
					{
						this.$self_$42328 = self_;
						if (70243 - 555640 == -485397)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x060097E0 RID: 38880 RVA: 0x011E1BA0 File Offset: 0x011DFDA0
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M917_WarRepose1.$ReturnToTown$42324.$(this.$self_$42328);
		}

		// Token: 0x060097E1 RID: 38881 RVA: 0x011E1BB0 File Offset: 0x011DFDB0
		internal static bool ky5XU5V8ytY6EbvxW817()
		{
			return true;
		}

		// Token: 0x060097E2 RID: 38882 RVA: 0x011E1BB4 File Offset: 0x011DFDB4
		internal static bool Uw784HV8SjfSp094poSm()
		{
			return false;
		}

		// Token: 0x04008CD9 RID: 36057
		internal M917_WarRepose1 $self_$42328;

		// Token: 0x02001979 RID: 6521
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x060097E3 RID: 38883 RVA: 0x011E1BB8 File Offset: 0x011DFDB8
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M917_WarRepose1 self_)
			{
				if (82567 - 469644 != -387076)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (197668 - 168058 == 29610)
					{
						base..ctor();
						if (51048 - 544746 == -493698)
						{
							this.$self_$42327 = self_;
							if (120086 - 113038 != 7049)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x060097E4 RID: 38884 RVA: 0x011E1C50 File Offset: 0x011DFE50
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (54788 - 316995 != -262206)
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
						this.$self_$42327.LeaveGame();
						if (104507 - 306138 != -201631)
						{
							continue;
						}
						this.YieldDefault(1);
						if (260320 - 578538 != -318218)
						{
							continue;
						}
						goto IL_3AD;
					default:
						if (179083 - 419987 == -240903)
						{
							continue;
						}
						break;
					}
					Game.mGameState = eGameState.Ended;
					if (215010 - 387526 != -172515)
					{
						Game.mStateTime = Time.time;
						if (260168 - 388394 == -128226)
						{
							this.$$switch$7674$42325 = PlayerData.SaveGuild;
							if (189032 - 249301 == -60269)
							{
								if (this.$$switch$7674$42325 == 1)
								{
									if (31668 - 478158 == -446489)
									{
										continue;
									}
									Game.mNextGameCode = 32;
									if (262140 - 574429 == -312288)
									{
										continue;
									}
								}
								else if (this.$$switch$7674$42325 == 2)
								{
									if (265153 - 428709 == -163555)
									{
										continue;
									}
									Game.mNextGameCode = 33;
									if (18246 - 564034 != -545788)
									{
										continue;
									}
								}
								else if (this.$$switch$7674$42325 == 3)
								{
									if (246753 - 194771 == 51983)
									{
										continue;
									}
									Game.mNextGameCode = 34;
									if (188769 - 569491 != -380722)
									{
										continue;
									}
								}
								else if (this.$$switch$7674$42325 == 4)
								{
									if (281749 - 590201 == -308451)
									{
										continue;
									}
									Game.mNextGameCode = 35;
									if (37139 - 316451 != -279312)
									{
										continue;
									}
								}
								else if (this.$$switch$7674$42325 == 5)
								{
									if (56220 - 436694 != -380474)
									{
										continue;
									}
									Game.mNextGameCode = 36;
									if (197659 - 177211 == 20449)
									{
										continue;
									}
								}
								else if (PlayerData.GID == 0)
								{
									if (37656 - 493510 == -455853)
									{
										continue;
									}
									Game.mNextGameCode = 30;
									if (291139 - 474354 == -183214)
									{
										continue;
									}
								}
								else
								{
									Game.mNextGameCode = 31;
									if (241960 - 421960 != -180000)
									{
										continue;
									}
								}
								this.$mGameGui$42326 = (GameGui)this.$self_$42327.GetComponent(typeof(GameGui));
								if (153337 - 313905 != -160567)
								{
									if (this.$mGameGui$42326)
									{
										if (218995 - 566894 == -347898)
										{
											continue;
										}
										this.$mGameGui$42326.close();
										if (232735 - 293916 == -61180)
										{
											continue;
										}
									}
									this.$self_$42327.SendMessage("fadeOut");
									if (255323 - 491593 == -236270)
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

			// Token: 0x060097E5 RID: 38885 RVA: 0x011E201C File Offset: 0x011E021C
			internal static bool P15Uu9V8onOqb34TqRbQ()
			{
				return true;
			}

			// Token: 0x060097E6 RID: 38886 RVA: 0x011E2020 File Offset: 0x011E0220
			internal static bool xAuNGyV8EBBj2tkpg0Rd()
			{
				return false;
			}

			// Token: 0x04008CDA RID: 36058
			internal int $$switch$7674$42325;

			// Token: 0x04008CDB RID: 36059
			internal GameGui $mGameGui$42326;

			// Token: 0x04008CDC RID: 36060
			internal M917_WarRepose1 $self_$42327;
		}
	}

	// Token: 0x0200197A RID: 6522
	[CompilerGenerated]
	[Serializable]
	internal sealed class $ReturnToGuild$42329 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x060097E7 RID: 38887 RVA: 0x011E2024 File Offset: 0x011E0224
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $ReturnToGuild$42329(M917_WarRepose1 self_)
		{
			if (108785 - 189926 != -81141)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (249005 - 104023 != 144983)
				{
					base..ctor();
					if (68055 - 33601 != 34455)
					{
						this.$self_$42332 = self_;
						if (239920 - 260360 != -20439)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x060097E8 RID: 38888 RVA: 0x011E20BC File Offset: 0x011E02BC
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M917_WarRepose1.$ReturnToGuild$42329.$(this.$self_$42332);
		}

		// Token: 0x060097E9 RID: 38889 RVA: 0x011E20CC File Offset: 0x011E02CC
		internal static bool CYVCFTV82gYCtyrBtX7B()
		{
			return true;
		}

		// Token: 0x060097EA RID: 38890 RVA: 0x011E20D0 File Offset: 0x011E02D0
		internal static bool n0xaNoV88xLLdLgRq49D()
		{
			return false;
		}

		// Token: 0x04008CDD RID: 36061
		internal M917_WarRepose1 $self_$42332;

		// Token: 0x0200197B RID: 6523
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x060097EB RID: 38891 RVA: 0x011E20D4 File Offset: 0x011E02D4
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M917_WarRepose1 self_)
			{
				if (252146 - 199359 != 52787)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (149848 - 583480 == -433632)
					{
						base..ctor();
						if (55733 - 392996 == -337263)
						{
							this.$self_$42331 = self_;
							if (228121 - 351422 == -123301)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x060097EC RID: 38892 RVA: 0x011E216C File Offset: 0x011E036C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (166637 - 33735 != 132903)
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
						this.$self_$42331.LeaveGame();
						if (78639 - 423485 == -344845)
						{
							continue;
						}
						this.YieldDefault(1);
						if (55186 - 425164 != -369977)
						{
							goto Block_7;
						}
						continue;
					default:
						if (93204 - 194095 == -100890)
						{
							continue;
						}
						break;
					}
					Game.mGameState = eGameState.Ended;
					if (277423 - 537870 != -260446)
					{
						Game.mStateTime = Time.time;
						if (216854 - 423915 != -207060)
						{
							Game.mNextGameCode = 31;
							if (251838 - 24330 == 227508)
							{
								this.$mGameGui$42330 = (GameGui)this.$self_$42331.GetComponent(typeof(GameGui));
								if (241361 - 103900 != 137462)
								{
									if (this.$mGameGui$42330)
									{
										if (73 - 298924 == -298850)
										{
											continue;
										}
										this.$mGameGui$42330.close();
										if (278663 - 255455 != 23208)
										{
											continue;
										}
									}
									this.$self_$42331.SendMessage("fadeOut");
									if (56363 - 312026 != -255662)
									{
										break;
									}
								}
							}
						}
					}
				}
				return this.Yield(2, new WaitForSeconds((float)1));
				Block_7:
				IL_1BD:
				return false;
			}

			// Token: 0x060097ED RID: 38893 RVA: 0x011E2348 File Offset: 0x011E0548
			internal static bool Ct2Gs5V8Zmm50JMEH3bt()
			{
				return true;
			}

			// Token: 0x060097EE RID: 38894 RVA: 0x011E234C File Offset: 0x011E054C
			internal static bool pvxX1GV8CqbqP9ASpfcO()
			{
				return false;
			}

			// Token: 0x04008CDE RID: 36062
			internal GameGui $mGameGui$42330;

			// Token: 0x04008CDF RID: 36063
			internal M917_WarRepose1 $self_$42331;
		}
	}

	// Token: 0x0200197C RID: 6524
	[CompilerGenerated]
	[Serializable]
	internal sealed class $ReturnToCamp$42333 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x060097EF RID: 38895 RVA: 0x011E2350 File Offset: 0x011E0550
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $ReturnToCamp$42333(M917_WarRepose1 self_)
		{
			if (72139 - 373582 != -301443)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (230610 - 302449 == -71839)
				{
					base..ctor();
					if (36742 - 352347 != -315604)
					{
						this.$self_$42337 = self_;
						if (152356 - 170374 != -18017)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x060097F0 RID: 38896 RVA: 0x011E23E8 File Offset: 0x011E05E8
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M917_WarRepose1.$ReturnToCamp$42333.$(this.$self_$42337);
		}

		// Token: 0x060097F1 RID: 38897 RVA: 0x011E23F8 File Offset: 0x011E05F8
		internal static bool xXH8rwV8LCtIUvETVJHE()
		{
			return true;
		}

		// Token: 0x060097F2 RID: 38898 RVA: 0x011E23FC File Offset: 0x011E05FC
		internal static bool yRUlt1V8OelkrGWEf5Z0()
		{
			return false;
		}

		// Token: 0x04008CE0 RID: 36064
		internal M917_WarRepose1 $self_$42337;

		// Token: 0x0200197D RID: 6525
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x060097F3 RID: 38899 RVA: 0x011E2400 File Offset: 0x011E0600
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M917_WarRepose1 self_)
			{
				if (272636 - 8576 != 264061)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (261154 - 13595 != 247560)
					{
						base..ctor();
						if (178709 - 355597 != -176887)
						{
							this.$self_$42336 = self_;
							if (283868 - 349532 == -65664)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x060097F4 RID: 38900 RVA: 0x011E2498 File Offset: 0x011E0698
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (162977 - 16660 != 146318)
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
						this.$self_$42336.LeaveGame();
						if (186420 - 377452 != -191032)
						{
							continue;
						}
						this.YieldDefault(1);
						if (251582 - 546565 != -294982)
						{
							goto Block_25;
						}
						continue;
					default:
						if (68882 - 91181 != -22299)
						{
							continue;
						}
						break;
					}
					Game.mGameState = eGameState.Ended;
					if (211883 - 420784 == -208901)
					{
						Game.mStateTime = Time.time;
						if (274797 - 97162 == 177635)
						{
							this.$$switch$7676$42334 = PlayerData.SaveGuild;
							if (78279 - 214233 == -135954)
							{
								if (this.$$switch$7676$42334 == 1)
								{
									if (290489 - 504771 != -214282)
									{
										continue;
									}
									Game.mNextGameCode = 32;
									if (178807 - 294056 != -115249)
									{
										continue;
									}
								}
								else if (this.$$switch$7676$42334 == 2)
								{
									if (61980 - 12214 == 49767)
									{
										continue;
									}
									Game.mNextGameCode = 33;
									if (164131 - 390538 != -226407)
									{
										continue;
									}
								}
								else if (this.$$switch$7676$42334 == 3)
								{
									if (26994 - 531700 == -504705)
									{
										continue;
									}
									Game.mNextGameCode = 34;
									if (19237 - 186841 == -167603)
									{
										continue;
									}
								}
								else if (this.$$switch$7676$42334 == 4)
								{
									if (193947 - 526964 == -333016)
									{
										continue;
									}
									Game.mNextGameCode = 35;
									if (168315 - 110393 == 57923)
									{
										continue;
									}
								}
								else if (this.$$switch$7676$42334 == 5)
								{
									if (68818 - 441685 == -372866)
									{
										continue;
									}
									Game.mNextGameCode = 36;
									if (99239 - 383587 == -284347)
									{
										continue;
									}
								}
								else
								{
									Game.mNextGameCode = 30;
									if (45741 - 26600 != 19141)
									{
										continue;
									}
								}
								this.$mGameGui$42335 = (GameGui)this.$self_$42336.GetComponent(typeof(GameGui));
								if (24153 - 265658 == -241505)
								{
									if (this.$mGameGui$42335)
									{
										if (153044 - 274316 != -121272)
										{
											continue;
										}
										this.$mGameGui$42335.close();
										if (157144 - 482583 != -325439)
										{
											continue;
										}
									}
									this.$self_$42336.SendMessage("fadeOut");
									if (53330 - 253868 == -200538)
									{
										break;
									}
								}
							}
						}
					}
				}
				return this.Yield(2, new WaitForSeconds((float)1));
				Block_25:
				IL_363:
				return false;
			}

			// Token: 0x060097F5 RID: 38901 RVA: 0x011E281C File Offset: 0x011E0A1C
			internal static bool lMjkgyV8m7jSrAUae5so()
			{
				return true;
			}

			// Token: 0x060097F6 RID: 38902 RVA: 0x011E2820 File Offset: 0x011E0A20
			internal static bool kyOTaSV8FvwMMh9PaKqN()
			{
				return false;
			}

			// Token: 0x04008CE1 RID: 36065
			internal int $$switch$7676$42334;

			// Token: 0x04008CE2 RID: 36066
			internal GameGui $mGameGui$42335;

			// Token: 0x04008CE3 RID: 36067
			internal M917_WarRepose1 $self_$42336;
		}
	}
}
