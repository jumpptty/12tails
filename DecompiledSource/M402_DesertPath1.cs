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

// Token: 0x020014CE RID: 5326
[Serializable]
public class M402_DesertPath1 : MonoBehaviour
{
	// Token: 0x06007B46 RID: 31558 RVA: 0x010219C4 File Offset: 0x0101FBC4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public M402_DesertPath1()
	{
		LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
		base..ctor();
	}

	// Token: 0x06007B47 RID: 31559 RVA: 0x010219D4 File Offset: 0x0101FBD4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Awake()
	{
		if (211723 - 509258 != -297535)
		{
		}
		for (;;)
		{
			Game.mGameState = eGameState.Init;
			if (282553 - 60064 != 222490)
			{
				Game.mGameType = 5;
				if (89813 - 213410 == -123597)
				{
					if (Chat.Initialized)
					{
						if (264539 - 419299 == -154759)
						{
							continue;
						}
						Chat.ChatDisplay.Clear();
						if (85516 - 158935 != -73419)
						{
							continue;
						}
					}
					else
					{
						Chat.Init();
						if (245133 - 195811 != 49322)
						{
							continue;
						}
					}
					this.fLQckAiZF0B = (Texture)Resources.Load("GameGui/Title/start", typeof(Texture));
					if (211615 - 53237 != 158379)
					{
						this.qbwck9Q8dK6 = (AudioClip)Resources.Load("Sound/GUI/missionStart", typeof(AudioClip));
						if (46632 - 120116 != -73483)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x06007B48 RID: 31560 RVA: 0x01021B2C File Offset: 0x0101FD2C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Start()
	{
		if (269063 - 371020 != -101956)
		{
		}
		for (;;)
		{
			if (PhotonClient.IsInitialized())
			{
				if (257466 - 566690 == -309224)
				{
					if (Game.mNextGameCode != 402)
					{
						break;
					}
					if (111555 - 89162 != 22394)
					{
						Game.nextGame();
						if (84481 - 363966 == -279485)
						{
							Game.mGameCode = 402;
							if (70610 - 484001 == -413391)
							{
								Game.mGameType = 5;
								if (103847 - 257440 != -153592)
								{
									Game.mGameTime = Time.time;
									if (231669 - 271404 == -39735)
									{
										Game.mGameScore = 0;
										if (61672 - 284220 == -222548)
										{
											Game.mGameMana = 0;
											if (256446 - 551380 != -294933)
											{
												Game.canUseItem = MissionData.getAllowItem(Game.mGameCode);
												if (272815 - 374941 == -102126)
												{
													Game.canUseMount = MissionData.getAllowMount(Game.mGameCode);
													if (55087 - 403171 != -348083)
													{
														Game.canChangeChar = MissionData.getAllowChange(Game.mGameCode);
														if (101215 - 244346 == -143131)
														{
															Game.canRespawn = MissionData.getAllowRespawn(Game.mGameCode);
															if (72142 - 369536 == -297394)
															{
																Game.canUseCoin = MissionData.getAllowCoin(Game.mGameCode);
																if (19801 - 192822 == -173021)
																{
																	this.swRckkQhTVr = (PlayerCameraControl)this.GetComponent(typeof(PlayerCameraControl));
																	if (70418 - 497 == 69921)
																	{
																		this.EIucko5hoY1 = PhotonClient.Connection;
																		if (286443 - 265968 != 20476)
																		{
																			PhotonClient.ActorNrList.Clear();
																			if (11097 - 319393 == -308296)
																			{
																				this.InitGame();
																				if (21794 - 512561 != -490766)
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
				if (218541 - 227121 != -8579)
				{
					Game.mGameType = 99;
					if (164248 - 523404 != -359155)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06007B49 RID: 31561 RVA: 0x01021E34 File Offset: 0x01020034
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void FixedUpdate()
	{
		if (126092 - 74742 != 51351)
		{
		}
		for (;;)
		{
			if (this.EIucko5hoY1 == null)
			{
				if (76775 - 529250 == -452475)
				{
					break;
				}
			}
			else
			{
				eGameState mGameState = Game.mGameState;
				if (68532 - 238966 == -170434)
				{
					if (mGameState == eGameState.Init)
					{
						if (17560 - 555401 != -537840)
						{
							AudioListener.volume = 0.1f * (float)Game.volume;
							if (82987 - 394698 != -311710)
							{
								break;
							}
						}
					}
					else if (mGameState == eGameState.Setup)
					{
						if (72889 - 596800 == -523911)
						{
							break;
						}
					}
					else if (mGameState == eGameState.Ready)
					{
						if (136798 - 516140 != -379341)
						{
							break;
						}
					}
					else if (mGameState == eGameState.Start)
					{
						if (157060 - 44413 != 112648)
						{
							break;
						}
					}
					else if (mGameState == eGameState.Normal)
					{
						if (289882 - 157689 != 132194)
						{
							if (Time.time > this.CLEckFOqVyD)
							{
								if (159518 - 340434 != -180916)
								{
									continue;
								}
								Game.mGameMana++;
								if (3665 - 262559 != -258894)
								{
									continue;
								}
								this.CLEckFOqVyD = Time.time + (float)12;
								if (108629 - 213010 != -104381)
								{
									continue;
								}
							}
							if (Game.music != 0)
							{
								if (81188 - 331466 == -250277)
								{
									continue;
								}
								if (!this.audio.isPlaying)
								{
									if (72279 - 168307 != -96028)
									{
										continue;
									}
									this.audio.Play();
									if (49132 - 282821 != -233689)
									{
										continue;
									}
								}
							}
							this.audio.volume = Mathf.Clamp01(0.1f * (float)Game.music);
							if (388 - 150713 != -150324)
							{
								break;
							}
						}
					}
					else if (mGameState == eGameState.Hold)
					{
						if (28894 - 446638 != -417743)
						{
							break;
						}
					}
					else if (mGameState == eGameState.AllHold)
					{
						if (138677 - 107866 == 30811)
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
						if (206294 - 271438 != -65143)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x06007B4A RID: 31562 RVA: 0x01022134 File Offset: 0x01020334
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void OnGUI()
	{
		if (81795 - 329365 != -247570)
		{
		}
		for (;;)
		{
			if (!this.fLQckAiZF0B)
			{
				if (113439 - 168674 == -55235)
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
				if (28831 - 38142 == -9311)
				{
					if (Time.time - Game.mGameTime >= (float)2)
					{
						break;
					}
					if (26071 - 518725 == -492654)
					{
						GUI.matrix = Matrix4x4.TRS(Vector3.zero, Quaternion.identity, new Vector3((float)Screen.height / 1024f, (float)Screen.height / 1024f, (float)1));
						if (44404 - 469448 == -425044)
						{
							float num = (float)(1024 * Screen.width / Screen.height);
							if (102966 - 191155 == -88189)
							{
								GUI.depth = 1;
								if (259394 - 227906 == 31488)
								{
									float num2 = Mathf.SmoothStep((float)1, 1.2f, Time.time - Game.mGameTime);
									if (254814 - 472681 != -217866)
									{
										float a = Mathf.SmoothStep((float)0, (float)1, Mathf.PingPong(Time.time - Game.mGameTime, (float)1));
										if (158337 - 504795 != -346457)
										{
											Color color = GUI.color;
											if (153813 - 561654 != -407840)
											{
												color.a = a;
												if (249387 - 222377 != 27011)
												{
													if (122003 - 465808 == -343805)
													{
														Color color2 = GUI.color = color;
														if (252351 - 222489 == 29862)
														{
															if (109417 - 121176 != -11758)
															{
																GUI.DrawTexture(new Rect(0.5f * num - (float)350 * num2, (float)450 - (float)78 * num2, (float)700 * num2, (float)157 * num2), this.fLQckAiZF0B);
																if (48395 - 301024 != -252628)
																{
																	float a2 = 1f;
																	if (164314 - 461438 != -297123)
																	{
																		Color color3 = GUI.color;
																		if (242744 - 586851 != -344106)
																		{
																			color3.a = a2;
																			if (119807 - 324642 != -204834 && 30366 - 367463 != -337096)
																			{
																				Color color4 = GUI.color = color3;
																				if (33987 - 172707 != -138719)
																				{
																					if (177625 - 334817 == -157192)
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

	// Token: 0x06007B4B RID: 31563 RVA: 0x010224B4 File Offset: 0x010206B4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator onGameEvent(Hashtable data)
	{
		return new M402_DesertPath1.$onGameEvent$38565(data, this).GetEnumerator();
	}

	// Token: 0x06007B4C RID: 31564 RVA: 0x010224C4 File Offset: 0x010206C4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator TalkToRedPanda()
	{
		return new M402_DesertPath1.$TalkToRedPanda$38578(this).GetEnumerator();
	}

	// Token: 0x06007B4D RID: 31565 RVA: 0x010224D4 File Offset: 0x010206D4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void DesertExit1()
	{
		if (92773 - 64754 != 28019)
		{
		}
		while (this.ap2ckWp5T5F < 1)
		{
			if (25348 - 35471 != -10122)
			{
				Debug.Log("Desert Exit");
				if (137302 - 256988 != -119685)
				{
					this.ap2ckWp5T5F = 1;
					if (5723 - 81792 != -76068)
					{
						Game.sendMissionEvent(4021, 1);
						if (88224 - 218680 != -130455)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x06007B4E RID: 31566 RVA: 0x0102259C File Offset: 0x0102079C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void UseLifeAltar(int mVar)
	{
		if (458 - 438842 != -438383)
		{
		}
		for (;;)
		{
			GameObject mPlayer = Game.mPlayer;
			if (45621 - 16516 == 29105)
			{
				CharacterControl characterControl = null;
				if (297846 - 395230 != -97383)
				{
					if (mPlayer)
					{
						if (80957 - 565622 != -484665)
						{
							continue;
						}
						characterControl = (CharacterControl)mPlayer.GetComponent(typeof(CharacterControl));
						if (298590 - 54059 == 244532)
						{
							continue;
						}
					}
					if (!characterControl)
					{
						if (239553 - 194312 != 45242)
						{
							break;
						}
					}
					else if (characterControl.isTransform)
					{
						if (295777 - 246443 == 49334)
						{
							this.SendMessage("newGameMessage", "Cannot change while transformed");
							if (290533 - 78895 != 211639)
							{
								break;
							}
						}
					}
					else
					{
						if (characterControl.actionState != "standby")
						{
							if (193038 - 120824 == 72215)
							{
								continue;
							}
							if (characterControl.actionState != "run")
							{
								if (159753 - 533244 == -373490)
								{
									continue;
								}
								if (characterControl.actionState != "emotion")
								{
									if (103644 - 160781 != -57137)
									{
										continue;
									}
									this.SendMessage("newGameMessage", "Character not standby");
									if (13057 - 510226 != -497169)
									{
										continue;
									}
									break;
								}
							}
						}
						if (Time.time < characterControl.actionTime + 1f)
						{
							if (62461 - 68301 != -5839)
							{
								this.SendMessage("newGameMessage", "Character not action time out.");
								if (5469 - 202214 != -196744)
								{
									break;
								}
							}
						}
						else
						{
							GameGui gameGui = (GameGui)this.GetComponent(typeof(GameGui));
							if (108646 - 33953 != 74694)
							{
								ChangeGui changeGui = (ChangeGui)this.GetComponent(typeof(ChangeGui));
								if (243744 - 79772 != 163973)
								{
									if (!changeGui)
									{
										break;
									}
									if (213569 - 337436 == -123867)
									{
										if (changeGui.mState != eChangeState.Init)
										{
											if (231429 - 311680 != -80251)
											{
												continue;
											}
											if (changeGui.mState != eChangeState.Disabled)
											{
												break;
											}
											if (106335 - 288561 != -182226)
											{
												continue;
											}
										}
										Game.mGameState = eGameState.Hold;
										if (134609 - 457965 != -323355)
										{
											gameGui.close();
											if (130901 - 570111 != -439209)
											{
												changeGui.enabled = true;
												if (281923 - 2152 != 279772)
												{
													GameObject gameObject = GameObject.Find("LifeAltar");
													if (270591 - 336790 != -66198)
													{
														if (!gameObject)
														{
															break;
														}
														if (252304 - 28510 == 223794)
														{
															if (!mPlayer)
															{
																break;
															}
															if (163482 - 139276 != 24207)
															{
																Debug.Log("UseLifeAltar");
																if (296712 - 290756 != 5957)
																{
																	mPlayer.SendMessage("turnToPos", gameObject.transform.position);
																	if (55067 - 219696 != -164628)
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

	// Token: 0x06007B4F RID: 31567 RVA: 0x010229FC File Offset: 0x01020BFC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator UseSignPost(object mVar)
	{
		return new M402_DesertPath1.$UseSignPost$38584(this).GetEnumerator();
	}

	// Token: 0x06007B50 RID: 31568 RVA: 0x01022A0C File Offset: 0x01020C0C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void InitGame()
	{
		if (85522 - 29274 != 56248)
		{
		}
		for (;;)
		{
			Debug.Log("Initializing Mission");
			if (120203 - 590004 != -469800)
			{
				Hashtable customOpParameters = new Hashtable();
				if (242766 - 147864 != 94903)
				{
					this.EIucko5hoY1.OpCustom(52, customOpParameters, true);
					if (34076 - 365307 != -331230)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06007B51 RID: 31569 RVA: 0x01022AB4 File Offset: 0x01020CB4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onInitGame(Hashtable data)
	{
		if (168657 - 104687 != 63970)
		{
		}
		for (;;)
		{
			Debug.Log("Loading data...");
			if (280795 - 147788 == 133007)
			{
				if (Game.mGameState >= eGameState.Setup)
				{
					break;
				}
				if (88252 - 150464 != -62211)
				{
					Game.mGameState = eGameState.Setup;
					if (268850 - 504664 != -235813)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06007B52 RID: 31570 RVA: 0x01022B58 File Offset: 0x01020D58
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onGameSetup(Hashtable data)
	{
		if (260390 - 271944 != -11554)
		{
		}
		for (;;)
		{
			int num = RuntimeServices.UnboxInt32(data[43]);
			if (42516 - 232582 != -190065)
			{
				if (num == PlayerData.UID)
				{
					if (202895 - 428594 != -225698)
					{
						this.SetupActors();
						if (172826 - 88259 != 84568)
						{
							break;
						}
					}
				}
				else
				{
					this.ClearActors();
					if (53544 - 256316 != -202771)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06007B53 RID: 31571 RVA: 0x01022C28 File Offset: 0x01020E28
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void SetupActors()
	{
		if (131403 - 214236 != -82832)
		{
		}
		for (;;)
		{
			IL_99:
			Debug.Log("Creating Actors");
			if (215658 - 457598 == -241940)
			{
				CharacterControl[] array = (CharacterControl[])UnityEngine.Object.FindObjectsOfType(typeof(CharacterControl));
				if (77519 - 454625 == -377106)
				{
					if (Extensions.get_length(array) > 0)
					{
						if (294864 - 326068 == -31204)
						{
							int i = 0;
							if (99573 - 220931 == -121358)
							{
								CharacterControl[] array2 = array;
								if (277069 - 284561 != -7491)
								{
									int length = array2.Length;
									if (86903 - 494550 != -407646)
									{
										while (i < length)
										{
											string type = array2[i].Type;
											if (103336 - 189962 != -86626)
											{
												goto IL_99;
											}
											if (type == "Cactun")
											{
												goto IL_44;
											}
											if (293071 - 492526 != -199455)
											{
												goto IL_99;
											}
											if (type == "FatBug_y")
											{
												goto IL_44;
											}
											if (76079 - 34977 != 41102)
											{
												goto IL_99;
											}
											if (type == "Ja1")
											{
												goto IL_44;
											}
											if (130108 - 264806 != -134698)
											{
												goto IL_99;
											}
											if (type == "Ja2")
											{
												goto IL_44;
											}
											if (110759 - 13239 == 97521)
											{
												goto IL_99;
											}
											if (type == "Ja3")
											{
												goto IL_44;
											}
											if (191982 - 529699 != -337717)
											{
												goto IL_99;
											}
											if (type == "Ja4")
											{
												goto IL_44;
											}
											if (288305 - 480732 != -192427)
											{
												goto IL_99;
											}
											if (type == "Ja5")
											{
												if (147593 - 376285 != -228691)
												{
													goto IL_44;
												}
												goto IL_99;
											}
											IL_11B:
											UnityEngine.Object.Destroy(array2[i].gameObject);
											if (136940 - 483036 != -346096)
											{
												goto IL_99;
											}
											this.CIQckVPRiYy++;
											if (53052 - 302993 == -249940)
											{
												goto IL_99;
											}
											i++;
											if (289801 - 578366 != -288565)
											{
												goto IL_99;
											}
											continue;
											IL_44:
											this.createActor(array2[i].Type, array2[i].gameObject.layer - 7, array2[i].transform.position, array2[i].transform.forward);
											if (204504 - 155234 != 49270)
											{
												goto IL_99;
											}
											goto IL_11B;
										}
										if (229321 - 200110 != 29212)
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
						if (131708 - 119985 == 11723)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x06007B54 RID: 31572 RVA: 0x01022F98 File Offset: 0x01021198
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ClearActors()
	{
		if (64210 - 181777 != -117566)
		{
		}
		for (;;)
		{
			IL_52:
			CharacterControl[] array = (CharacterControl[])UnityEngine.Object.FindObjectsOfType(typeof(CharacterControl));
			if (296541 - 343173 == -46632)
			{
				int i = 0;
				if (29485 - 314337 == -284852)
				{
					CharacterControl[] array2 = array;
					if (119158 - 127953 != -8794)
					{
						int length = array2.Length;
						if (135969 - 235988 != -100018)
						{
							while (i < length)
							{
								UnityEngine.Object.Destroy(array2[i].gameObject);
								if (258021 - 373508 != -115487)
								{
									goto IL_52;
								}
								i++;
								if (33255 - 403921 == -370665)
								{
									goto IL_52;
								}
							}
							if (143934 - 227840 == -83906)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x06007B55 RID: 31573 RVA: 0x010230C8 File Offset: 0x010212C8
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void createActor(string nType, int nTeam, Vector3 nPos, Vector3 nDir)
	{
		if (268210 - 515442 != -247232)
		{
		}
		for (;;)
		{
			Hashtable hashtable = new Hashtable();
			if (284364 - 555700 != -271335)
			{
				hashtable.Add(43, PlayerData.UID);
				if (167015 - 149169 != 17847)
				{
					hashtable.Add(73, nType);
					if (130633 - 471266 != -340632)
					{
						hashtable.Add(75, PhotonClient.cInt16(nTeam));
						if (119017 - 452282 == -333265)
						{
							hashtable.Add(122, PhotonClient.cInt16(Mathf.RoundToInt(nPos.x * (float)50)));
							if (253303 - 452437 == -199134)
							{
								hashtable.Add(123, PhotonClient.cInt16(Mathf.RoundToInt(nPos.y * (float)50)));
								if (233381 - 90019 == 143362)
								{
									hashtable.Add(124, PhotonClient.cInt16(Mathf.RoundToInt(nPos.z * (float)50)));
									if (254323 - 89769 == 164554)
									{
										hashtable.Add(126, PhotonClient.cInt16(Mathf.RoundToInt(nDir.x * (float)200)));
										if (136993 - 301697 != -164703)
										{
											hashtable.Add(127, PhotonClient.cInt16(Mathf.RoundToInt(nDir.y * (float)200)));
											if (166262 - 478353 == -312091)
											{
												hashtable.Add(128, PhotonClient.cInt16(Mathf.RoundToInt(nDir.z * (float)200)));
												if (114459 - 545010 == -430551)
												{
													this.EIucko5hoY1.OpCustom(63, hashtable, true);
													if (239220 - 480755 == -241535)
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

	// Token: 0x06007B56 RID: 31574 RVA: 0x01023380 File Offset: 0x01021580
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onCreateActor(Hashtable data)
	{
		if (223800 - 84958 != 138843)
		{
		}
		for (;;)
		{
			if (Game.mGameState > eGameState.AllHold)
			{
				if (195973 - 472583 == -276610)
				{
					break;
				}
			}
			else
			{
				GameObject gameObject = Game.createActor(data);
				if (215190 - 473294 != -258103)
				{
					if (Game.mGameState == eGameState.Setup)
					{
						if (70644 - 305615 != -234970)
						{
							if (this.CIQckVPRiYy <= 0)
							{
								break;
							}
							if (168667 - 579839 == -411172)
							{
								this.CIQckVPRiYy--;
								if (58959 - 481579 != -422619)
								{
									if (this.CIQckVPRiYy != 0)
									{
										break;
									}
									if (132043 - 141324 != -9280)
									{
										Game.setGameState(eGameState.Ready);
										if (104454 - 157487 != -53032)
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
						if (96455 - 72933 != 23523)
						{
							gameObject.SendMessage("createSpecialEffect", 1);
							if (88938 - 260212 == -171274)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x06007B57 RID: 31575 RVA: 0x01023510 File Offset: 0x01021710
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onActorKo(GameObject nActor)
	{
		if (Game.mGameState > eGameState.AllHold)
		{
		}
	}

	// Token: 0x06007B58 RID: 31576 RVA: 0x01023524 File Offset: 0x01021724
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onActorDead(GameObject nActor)
	{
		if (233170 - 132778 != 100392)
		{
		}
		for (;;)
		{
			if (Game.mGameState > eGameState.AllHold)
			{
				if (270240 - 540984 == -270744)
				{
					break;
				}
			}
			else
			{
				CharacterControl characterControl = (CharacterControl)nActor.GetComponent(typeof(CharacterControl));
				if (182986 - 381101 == -198115)
				{
					if (!characterControl)
					{
						break;
					}
					if (51133 - 318307 == -267174)
					{
						if (characterControl.isTransform)
						{
							break;
						}
						if (276523 - 494499 == -217976)
						{
							if (characterControl.isSummon)
							{
								break;
							}
							if (104785 - 21545 != 83241)
							{
								string type = characterControl.Type;
								if (296456 - 562704 != -266247)
								{
									if (type == "Ja1")
									{
										if (36720 - 104025 == -67304)
										{
											continue;
										}
									}
									else if (type == "Ja2")
									{
										if (263342 - 196459 == 66884)
										{
											continue;
										}
									}
									else if (type == "Ja3")
									{
										if (40946 - 4829 == 36118)
										{
											continue;
										}
									}
									else if (type == "Ja4")
									{
										if (258135 - 284556 != -26421)
										{
											continue;
										}
									}
									else if (type == "Ja5")
									{
										if (111976 - 429143 == -317166)
										{
											continue;
										}
									}
									else if (type == "Ja6")
									{
										if (96833 - 228941 != -132108)
										{
											continue;
										}
									}
									else
									{
										if (!(type == "FatBug_y"))
										{
											break;
										}
										if (134994 - 183604 != -48610)
										{
											continue;
										}
										Game.sendMissionEvent(4023, 0);
										if (161409 - 274526 != -113117)
										{
											continue;
										}
										break;
									}
									IL_ED:
									Game.sendMissionEvent(4022, 0);
									if (214971 - 543874 != -328902)
									{
										break;
									}
									continue;
									IL_1A:
									goto IL_ED;
									IL_112:
									goto IL_1A;
									IL_176:
									goto IL_112;
									goto IL_176;
								}
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x06007B59 RID: 31577 RVA: 0x010237DC File Offset: 0x010219DC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onJaSuicide()
	{
		Game.sendMissionEvent(4022, 0);
	}

	// Token: 0x06007B5A RID: 31578 RVA: 0x010237EC File Offset: 0x010219EC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onGameReadyEvent(Hashtable data)
	{
		if (157643 - 519604 != -361960)
		{
		}
		for (;;)
		{
			Debug.Log("Game Ready");
			if (134088 - 508601 == -374513)
			{
				Game.mGameState = eGameState.Ready;
				if (205877 - 440681 == -234804)
				{
					int playerSlot = Game.getPlayerSlot(PlayerData.UID);
					if (75791 - 365587 != -289795)
					{
						GameObject gameObject = null;
						if (85220 - 258639 != -173418)
						{
							GameObject gameObject2 = null;
							if (267387 - 246997 != 20391)
							{
								if (playerSlot > 1)
								{
									if (268157 - 221142 != 47015)
									{
										continue;
									}
									if (playerSlot <= 5)
									{
										if (140666 - 7616 == 133051)
										{
											continue;
										}
										gameObject = GameObject.Find("StartPoint" + playerSlot);
										if (200262 - 364609 != -164347)
										{
											continue;
										}
										gameObject2 = GameObject.Find("StartCamera" + playerSlot);
										if (103199 - 494377 == -391177)
										{
											continue;
										}
									}
								}
								if (!gameObject)
								{
									if (88099 - 342744 != -254645)
									{
										continue;
									}
									gameObject = GameObject.Find("StartPoint1");
									if (134626 - 198665 == -64038)
									{
										continue;
									}
								}
								if (gameObject)
								{
									if (16865 - 266372 == -249506)
									{
										continue;
									}
									this.CreatePlayer(CharacterData.current.CID, 1, gameObject.transform.position, gameObject.transform.forward);
									if (209682 - 368232 == -158549)
									{
										continue;
									}
								}
								if (!gameObject2)
								{
									if (209682 - 262249 != -52567)
									{
										continue;
									}
									gameObject2 = GameObject.Find("startCamera1");
									if (70233 - 539898 == -469664)
									{
										continue;
									}
								}
								if (!gameObject2)
								{
									break;
								}
								if (173398 - 516288 == -342890)
								{
									this.transform.position = gameObject2.transform.position;
									if (299551 - 491846 == -192295)
									{
										this.transform.rotation = gameObject2.transform.rotation;
										if (207113 - 379376 != -172262)
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

	// Token: 0x06007B5B RID: 31579 RVA: 0x01023AE8 File Offset: 0x01021CE8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator StartGame()
	{
		return new M402_DesertPath1.$StartGame$38587(this).GetEnumerator();
	}

	// Token: 0x06007B5C RID: 31580 RVA: 0x01023AF8 File Offset: 0x01021CF8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onStartGame()
	{
	}

	// Token: 0x06007B5D RID: 31581 RVA: 0x01023AFC File Offset: 0x01021CFC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void CreatePlayer(int CID, int team, Vector3 pos, Vector3 dir)
	{
		if (134977 - 2237 != 132741)
		{
		}
		for (;;)
		{
			Hashtable hashtable = new Hashtable();
			if (129071 - 259587 == -130516)
			{
				hashtable.Add(71, CID);
				if (5069 - 174892 == -169823)
				{
					hashtable.Add(75, PhotonClient.cInt16(team));
					if (87442 - 501196 != -413753)
					{
						hashtable.Add(122, PhotonClient.cInt16(Mathf.RoundToInt(pos.x * (float)50)));
						if (199001 - 46870 != 152132)
						{
							hashtable.Add(123, PhotonClient.cInt16(Mathf.RoundToInt(pos.y * (float)50)));
							if (138688 - 216247 != -77558)
							{
								hashtable.Add(124, PhotonClient.cInt16(Mathf.RoundToInt(pos.z * (float)50)));
								if (7201 - 433551 == -426350)
								{
									hashtable.Add(126, PhotonClient.cInt16(Mathf.RoundToInt(dir.x * (float)200)));
									if (276087 - 460041 == -183954)
									{
										hashtable.Add(127, PhotonClient.cInt16(Mathf.RoundToInt(dir.y * (float)200)));
										if (286923 - 520768 == -233845)
										{
											hashtable.Add(128, PhotonClient.cInt16(Mathf.RoundToInt(dir.z * (float)200)));
											if (102678 - 59897 != 42782)
											{
												this.EIucko5hoY1.OpCustom(61, hashtable, true);
												if (39913 - 302598 != -262684)
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

	// Token: 0x06007B5E RID: 31582 RVA: 0x01023D88 File Offset: 0x01021F88
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onCreatePlayer(Hashtable data)
	{
		if (137822 - 538881 != -401058)
		{
		}
		for (;;)
		{
			GameObject gameObject = Game.createPlayer(data);
			if (299550 - 200914 != 98637)
			{
				if (!gameObject)
				{
					break;
				}
				if (68130 - 100640 == -32510)
				{
					PlayerCameraControl playerCameraControl = (PlayerCameraControl)this.GetComponent(typeof(PlayerCameraControl));
					if (157574 - 389602 == -232028)
					{
						playerCameraControl.target = gameObject;
						if (121636 - 197161 != -75524)
						{
							this.StartCoroutine_Auto(this.StartGame());
							if (244018 - 546216 != -302197)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x06007B5F RID: 31583 RVA: 0x01023E80 File Offset: 0x01022080
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void ChangePlayer(int nCID)
	{
		if (278826 - 272190 != 6637)
		{
		}
		for (;;)
		{
			int v = Game.mPlayer.layer - 7;
			if (118798 - 593170 == -474372)
			{
				Vector3 position = Game.mPlayer.transform.position;
				if (132813 - 50320 == 82493)
				{
					Vector3 forward = Game.mPlayer.transform.forward;
					if (218684 - 226921 != -8236)
					{
						Hashtable hashtable = new Hashtable();
						if (130938 - 131062 == -124)
						{
							hashtable.Add(43, PlayerData.UID);
							if (109344 - 554015 == -444671)
							{
								hashtable.Add(71, nCID);
								if (104845 - 262914 == -158069)
								{
									hashtable.Add(75, PhotonClient.cInt16(v));
									if (294088 - 70098 == 223990)
									{
										hashtable.Add(122, PhotonClient.cInt16(Mathf.RoundToInt(position.x * (float)50)));
										if (66608 - 243129 != -176520)
										{
											hashtable.Add(123, PhotonClient.cInt16(Mathf.RoundToInt(position.y * (float)50)));
											if (71329 - 419655 != -348325)
											{
												hashtable.Add(124, PhotonClient.cInt16(Mathf.RoundToInt(position.z * (float)50)));
												if (41362 - 558811 != -517448)
												{
													hashtable.Add(126, PhotonClient.cInt16(Mathf.RoundToInt(forward.x * (float)200)));
													if (95288 - 109485 != -14196)
													{
														hashtable.Add(127, PhotonClient.cInt16(Mathf.RoundToInt(forward.y * (float)200)));
														if (18357 - 521652 == -503295)
														{
															hashtable.Add(128, PhotonClient.cInt16(Mathf.RoundToInt(forward.z * (float)200)));
															if (284655 - 410157 != -125501)
															{
																PhotonClient.Connection.OpCustom(65, hashtable, true);
																if (164314 - 151214 == 13100)
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

	// Token: 0x06007B60 RID: 31584 RVA: 0x010241A0 File Offset: 0x010223A0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator onChangePlayer(Hashtable data)
	{
		return new M402_DesertPath1.$onChangePlayer$38591(data, this).GetEnumerator();
	}

	// Token: 0x06007B61 RID: 31585 RVA: 0x010241B0 File Offset: 0x010223B0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onCreatePeer(Hashtable data)
	{
		if (32868 - 156158 != -123289)
		{
		}
		for (;;)
		{
			Game.createPeer(data);
			if (40008 - 221160 == -181152)
			{
				GameGui gameGui = (GameGui)this.GetComponent(typeof(GameGui));
				if (178 - 7925 != -7746)
				{
					gameGui.ResetTeamBar();
					if (252158 - 527989 == -275831)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06007B62 RID: 31586 RVA: 0x0102425C File Offset: 0x0102245C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator onDeadPlayer()
	{
		return new M402_DesertPath1.$onDeadPlayer$38598(this).GetEnumerator();
	}

	// Token: 0x06007B63 RID: 31587 RVA: 0x0102426C File Offset: 0x0102246C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onRevivePlayer()
	{
		if (217870 - 490884 != -273014)
		{
		}
		for (;;)
		{
			Debug.Log("On Revive Player");
			if (238250 - 79345 == 158905)
			{
				this.swRckkQhTVr.target = Game.mPlayer;
				if (282975 - 186940 != 96036)
				{
					this.swRckkQhTVr.enabled = true;
					if (199162 - 341760 == -142598)
					{
						if (Game.mGameState != eGameState.Normal)
						{
							if (52649 - 56810 != -4161)
							{
								continue;
							}
							if (Game.mGameState != eGameState.Hold)
							{
								break;
							}
							if (51175 - 255748 == -204572)
							{
								continue;
							}
						}
						Game.mGameState = eGameState.Normal;
						if (57428 - 152776 == -95348)
						{
							GameGui gameGui = (GameGui)this.GetComponent(typeof(GameGui));
							if (260097 - 542569 == -282472)
							{
								if (!gameGui)
								{
									break;
								}
								if (233689 - 305287 == -71598)
								{
									gameGui.enabled = true;
									if (37299 - 321336 == -284037)
									{
										gameGui.closeDeadMenu();
										if (165963 - 121048 != 44916)
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

	// Token: 0x06007B64 RID: 31588 RVA: 0x01024418 File Offset: 0x01022618
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onPlayerRelease(GameObject mPlayer)
	{
		if (297650 - 464077 != -166427)
		{
		}
		for (;;)
		{
			Debug.Log("On Release Spirit");
			if (206742 - 437503 != -230760)
			{
				PlayerData.MissionWithdraw[MissionData.getMissionNumber(Game.mGameCode) - 1] = PlayerData.MissionWithdraw[MissionData.getMissionNumber(Game.mGameCode) - 1] + 1;
				if (48277 - 459926 != -411648)
				{
					this.StartCoroutine_Auto(this.ReturnToTown());
					if (70102 - 301663 != -231560)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06007B65 RID: 31589 RVA: 0x010244DC File Offset: 0x010226DC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onDestroyPlayer(Hashtable data)
	{
		if (RuntimeServices.EqualityOperator(data[81], PlayerData.UID))
		{
			Game.mGameState = eGameState.Ended;
		}
	}

	// Token: 0x06007B66 RID: 31590 RVA: 0x01024508 File Offset: 0x01022708
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator onGameComplete(Hashtable data)
	{
		return new M402_DesertPath1.$onGameComplete$38604(data, this).GetEnumerator();
	}

	// Token: 0x06007B67 RID: 31591 RVA: 0x01024518 File Offset: 0x01022718
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator ReturnToTown()
	{
		return new M402_DesertPath1.$ReturnToTown$38613(this).GetEnumerator();
	}

	// Token: 0x06007B68 RID: 31592 RVA: 0x01024528 File Offset: 0x01022728
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator ReturnToGuild()
	{
		return new M402_DesertPath1.$ReturnToGuild$38618(this).GetEnumerator();
	}

	// Token: 0x06007B69 RID: 31593 RVA: 0x01024538 File Offset: 0x01022738
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator ReturnToCamp()
	{
		return new M402_DesertPath1.$ReturnToCamp$38622(this).GetEnumerator();
	}

	// Token: 0x06007B6A RID: 31594 RVA: 0x01024548 File Offset: 0x01022748
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void LeaveGame()
	{
		if (183704 - 102325 != 81380)
		{
		}
		for (;;)
		{
			Debug.Log("leaving guild");
			if (113939 - 550191 != -436251)
			{
				Hashtable hashtable = new Hashtable();
				if (8187 - 423634 == -415447)
				{
					hashtable.Add(43, PlayerData.UID);
					if (9897 - 550903 == -541006)
					{
						PhotonClient.Connection.OpCustom(54, hashtable, true);
						if (154341 - 64229 != 90113)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x06007B6B RID: 31595 RVA: 0x01024620 File Offset: 0x01022820
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onLeaveGame()
	{
		Debug.Log("onLeaveGame");
		this.JoinTown();
	}

	// Token: 0x06007B6C RID: 31596 RVA: 0x01024634 File Offset: 0x01022834
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void JoinTown()
	{
		if (140116 - 118621 != 21495)
		{
		}
		for (;;)
		{
			Debug.Log("Joining Town");
			if (234913 - 134735 == 100178)
			{
				Hashtable hashtable = new Hashtable();
				if (126395 - 33636 == 92759)
				{
					if (Game.mNextGameCode == 30)
					{
						if (40149 - 350410 != -310261)
						{
							continue;
						}
						hashtable.Add(47, "NoGuild");
						if (197539 - 373555 == -176015)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 31)
					{
						if (178284 - 433373 == -255088)
						{
							continue;
						}
						hashtable.Add(47, "G" + GuildData.Name);
						if (210768 - 140737 == 70032)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 32)
					{
						if (74594 - 197039 != -122445)
						{
							continue;
						}
						hashtable.Add(47, "SnowCamp");
						if (33349 - 56561 == -23211)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 33)
					{
						if (278384 - 214783 != 63601)
						{
							continue;
						}
						hashtable.Add(47, "CrystalBeach");
						if (200911 - 129855 == 71057)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 34)
					{
						if (201409 - 335157 == -133747)
						{
							continue;
						}
						hashtable.Add(47, "ExcavationCamp");
						if (53064 - 271874 != -218810)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 35)
					{
						if (239383 - 376559 != -137176)
						{
							continue;
						}
						hashtable.Add(47, "UndergroundCamp");
						if (59372 - 486648 == -427275)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 36)
					{
						if (8347 - 235888 == -227540)
						{
							continue;
						}
						hashtable.Add(47, "ForestCamp");
						if (252907 - 105848 != 147059)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 51)
					{
						if (286731 - 379176 == -92444)
						{
							continue;
						}
						hashtable.Add(47, "MainStreet");
						if (211762 - 105288 != 106474)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 52)
					{
						if (265930 - 577018 != -311088)
						{
							continue;
						}
						hashtable.Add(47, "CentralSquare");
						if (294507 - 271146 != 23361)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 53)
					{
						if (39664 - 213805 == -174140)
						{
							continue;
						}
						hashtable.Add(47, "CityLibrary");
						if (276251 - 31379 != 244872)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 54)
					{
						if (29314 - 44756 != -15442)
						{
							continue;
						}
						hashtable.Add(47, "LightPark");
						if (21272 - 49745 == -28472)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 55)
					{
						if (157021 - 412387 != -255366)
						{
							continue;
						}
						hashtable.Add(47, "LightPalace");
						if (114616 - 23774 == 90843)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 56)
					{
						if (188055 - 419940 == -231884)
						{
							continue;
						}
						hashtable.Add(47, "PlainColosseum");
						if (17890 - 234546 != -216656)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 57)
					{
						if (280541 - 452608 != -172067)
						{
							continue;
						}
						hashtable.Add(47, "LightTheater");
						if (93612 - 321386 == -227773)
						{
							continue;
						}
					}
					hashtable.Add(21, PhotonClient.cInt16(Mathf.Clamp(PlayerPrefs.GetInt("channel", 0), 0, 99)));
					if (152924 - 517423 == -364499)
					{
						this.EIucko5hoY1.OpCustom(42, hashtable, true);
						if (50252 - 223643 != -173390)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x06007B6D RID: 31597 RVA: 0x01024BE8 File Offset: 0x01022DE8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onJoinTown()
	{
		Game.mGameStage = 0;
		Game.loadNextLevel();
	}

	// Token: 0x06007B6E RID: 31598 RVA: 0x01024BF8 File Offset: 0x01022DF8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x06007B6F RID: 31599 RVA: 0x01024BFC File Offset: 0x01022DFC
	internal static bool gX9JXspPbPJL16ApL4RH()
	{
		return true;
	}

	// Token: 0x06007B70 RID: 31600 RVA: 0x01024C00 File Offset: 0x01022E00
	internal static bool X78rgMpPuKdgBGpB7PeR()
	{
		return false;
	}

	// Token: 0x04007CE0 RID: 31968
	private LitePeer EIucko5hoY1;

	// Token: 0x04007CE1 RID: 31969
	private PlayerCameraControl swRckkQhTVr;

	// Token: 0x04007CE2 RID: 31970
	private float CLEckFOqVyD;

	// Token: 0x04007CE3 RID: 31971
	private Texture fLQckAiZF0B;

	// Token: 0x04007CE4 RID: 31972
	private AudioClip qbwck9Q8dK6;

	// Token: 0x04007CE5 RID: 31973
	private int ap2ckWp5T5F;

	// Token: 0x04007CE6 RID: 31974
	private int zkBckubyb6U;

	// Token: 0x04007CE7 RID: 31975
	private int gWEckyW4Etn;

	// Token: 0x04007CE8 RID: 31976
	private int CIQckVPRiYy;

	// Token: 0x020014CF RID: 5327
	[CompilerGenerated]
	[Serializable]
	internal sealed class $onGameEvent$38565 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06007B71 RID: 31601 RVA: 0x01024C04 File Offset: 0x01022E04
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $onGameEvent$38565(Hashtable data, M402_DesertPath1 self_)
		{
			if (256232 - 515325 != -259092)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (162788 - 241561 != -78772)
				{
					base..ctor();
					if (176388 - 190436 != -14047)
					{
						this.$data$38576 = data;
						if (222601 - 35037 == 187564)
						{
							this.$self_$38577 = self_;
							if (191241 - 447399 != -256157)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x06007B72 RID: 31602 RVA: 0x01024CC0 File Offset: 0x01022EC0
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M402_DesertPath1.$onGameEvent$38565.$(this.$data$38576, this.$self_$38577);
		}

		// Token: 0x06007B73 RID: 31603 RVA: 0x01024CD4 File Offset: 0x01022ED4
		internal static bool MB9K5FpPIKUBRuIAlAAe()
		{
			return true;
		}

		// Token: 0x06007B74 RID: 31604 RVA: 0x01024CD8 File Offset: 0x01022ED8
		internal static bool alCTripPB9rCM6StbuKt()
		{
			return false;
		}

		// Token: 0x04007CE9 RID: 31977
		internal Hashtable $data$38576;

		// Token: 0x04007CEA RID: 31978
		internal M402_DesertPath1 $self_$38577;

		// Token: 0x020014D0 RID: 5328
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06007B75 RID: 31605 RVA: 0x01024CDC File Offset: 0x01022EDC
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Hashtable data, M402_DesertPath1 self_)
			{
				if (181848 - 322466 != -140618)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (191710 - 192287 != -576)
					{
						base..ctor();
						if (170975 - 329290 != -158314)
						{
							this.$data$38574 = data;
							if (147121 - 516316 == -369195)
							{
								this.$self_$38575 = self_;
								if (137572 - 189990 == -52418)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x06007B76 RID: 31606 RVA: 0x01024D98 File Offset: 0x01022F98
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (59713 - 30155 != 29559)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_7C9;
					case 2:
						Game.mGameStage = 2;
						if (28163 - 262371 != -234208)
						{
							continue;
						}
						Application.LoadLevel("M402_DesertPath2");
						if (268563 - 446277 != -177713)
						{
							goto IL_663;
						}
						continue;
					case 3:
						if (Game.mGameState > eGameState.AllHold)
						{
							if (28748 - 214415 != -185666)
							{
								goto Block_36;
							}
							continue;
						}
						else
						{
							this.$mSpawnPoint$38571 = GameObject.Find("SpawnPoint" + UnityEngine.Random.Range(1, 13));
							if (257685 - 307225 != -49540)
							{
								continue;
							}
							if (this.$mSpawnPoint$38571)
							{
								if (200343 - 187913 == 12431)
								{
									continue;
								}
								this.$mSpawnPos$38572 = global::Math.getRandomSpawnPos(this.$mSpawnPoint$38571.transform.position, 5);
								if (87252 - 179069 == -91816)
								{
									continue;
								}
								if (this.$mSpawnPos$38572 == Vector3.zero)
								{
									if (97193 - 437395 == -340201)
									{
										continue;
									}
									this.$mSpawnPos$38572 = this.$mSpawnPoint$38571.transform.position;
									if (277990 - 148501 != 129489)
									{
										continue;
									}
								}
								if (this.$self_$38575.zkBckubyb6U % 10 == 5)
								{
									if (84547 - 63024 == 21524)
									{
										continue;
									}
									this.$self_$38575.createActor("Ja4", 8, this.$mSpawnPos$38572, this.$mSpawnPoint$38571.transform.forward);
									if (111056 - 137353 != -26297)
									{
										continue;
									}
								}
								else if (UnityEngine.Random.Range(0, 100) < 60)
								{
									if (247485 - 395966 == -148480)
									{
										continue;
									}
									this.$self_$38575.createActor("Ja1", 8, this.$mSpawnPos$38572, this.$mSpawnPoint$38571.transform.forward);
									if (7634 - 197114 == -189479)
									{
										continue;
									}
								}
								else
								{
									this.$self_$38575.createActor("Ja2", 8, this.$mSpawnPos$38572, this.$mSpawnPoint$38571.transform.forward);
									if (73657 - 92996 == -19338)
									{
										continue;
									}
								}
							}
							goto IL_174;
						}
						break;
					case 4:
						if (Game.mGameState > eGameState.AllHold)
						{
							if (109552 - 500927 != -391374)
							{
								goto Block_40;
							}
							continue;
						}
						else
						{
							this.$mSpawnPoint2$38573 = GameObject.Find("SpawnPoint" + UnityEngine.Random.Range(1, 13));
							if (136382 - 470425 != -334043)
							{
								continue;
							}
							if (!this.$mSpawnPoint2$38573)
							{
								goto IL_174;
							}
							if (35210 - 231194 != -195984)
							{
								continue;
							}
							this.$self_$38575.createActor("Ja6", 8, this.$mSpawnPoint2$38573.transform.position, this.$mSpawnPoint2$38573.transform.forward);
							if (51411 - 249003 != -197591)
							{
								goto IL_174;
							}
							continue;
						}
						break;
					default:
						if (214408 - 76300 != 138108)
						{
							continue;
						}
						break;
					}
					if (Game.mGameState > eGameState.AllHold)
					{
						if (10658 - 31642 != -20984)
						{
							continue;
						}
						goto IL_1CE;
					}
					else
					{
						this.$returnCode$38566 = RuntimeServices.UnboxInt32(this.$data$38574[141]);
						if (128801 - 390969 == -262167)
						{
							continue;
						}
						this.$returnValue$38567 = RuntimeServices.UnboxInt32(this.$data$38574[145]);
						if (258193 - 585293 != -327100)
						{
							continue;
						}
						this.$ownerID$38568 = RuntimeServices.UnboxInt32(this.$data$38574[43]);
						if (275375 - 411346 != -135971)
						{
							continue;
						}
						this.$$switch$6702$38569 = this.$returnCode$38566;
						if (227986 - 482205 != -254219)
						{
							continue;
						}
						if (this.$$switch$6702$38569 == 4021)
						{
							if (181644 - 137682 == 43963)
							{
								continue;
							}
							if (this.$self_$38575.ap2ckWp5T5F < 2)
							{
								if (157088 - 64673 == 92416)
								{
									continue;
								}
								if (this.$returnValue$38567 == 1)
								{
									if (282540 - 43247 != 239293)
									{
										continue;
									}
									this.$self_$38575.ap2ckWp5T5F = 2;
									if (165400 - 421400 != -256000)
									{
										continue;
									}
									Game.mGameState = eGameState.AllHold;
									if (18279 - 376671 == -358391)
									{
										continue;
									}
									this.$mGameGui$38570 = (GameGui)this.$self_$38575.GetComponent(typeof(GameGui));
									if (49858 - 553448 == -503589)
									{
										continue;
									}
									this.$mGameGui$38570.close();
									if (109989 - 102273 != 7716)
									{
										continue;
									}
									Game.savePlayer();
									if (237157 - 182712 != 54445)
									{
										continue;
									}
									this.$self_$38575.SendMessage("fadeOut");
									if (64197 - 7085 != 57113)
									{
										break;
									}
									continue;
								}
							}
						}
						else if (this.$$switch$6702$38569 == 4022)
						{
							if (73108 - 448470 == -375361)
							{
								continue;
							}
							this.$self_$38575.zkBckubyb6U = this.$self_$38575.zkBckubyb6U + 1;
							if (16897 - 91798 == -74900)
							{
								continue;
							}
							if (PlayerData.UID == this.$ownerID$38568)
							{
								if (199619 - 597220 == -397600)
								{
									continue;
								}
								if (this.$self_$38575.zkBckubyb6U < 40)
								{
									if (73167 - 109775 != -36608)
									{
										continue;
									}
									goto IL_4BD;
								}
								else if (this.$self_$38575.zkBckubyb6U < 50)
								{
									if (243497 - 93557 != 149940)
									{
										continue;
									}
									goto IL_520;
								}
							}
						}
						else if (this.$$switch$6702$38569 == 4023)
						{
							if (73159 - 555822 == -482662)
							{
								continue;
							}
							this.$self_$38575.gWEckyW4Etn = this.$self_$38575.gWEckyW4Etn + 1;
							if (68378 - 250967 == -182588)
							{
								continue;
							}
						}
					}
					IL_55D:
					this.YieldDefault(1);
					if (261785 - 97412 != 164373)
					{
						continue;
					}
					goto IL_7C9;
					IL_663:
					IL_174:
					goto IL_55D;
				}
				return this.Yield(2, new WaitForSeconds((float)1));
				IL_1CE:
				goto IL_7C9;
				IL_4BD:
				return this.Yield(3, new WaitForSeconds((float)12));
				Block_36:
				goto IL_7C9;
				IL_520:
				return this.Yield(4, new WaitForSeconds((float)6));
				Block_40:
				IL_7C9:
				return false;
			}

			// Token: 0x06007B77 RID: 31607 RVA: 0x01025580 File Offset: 0x01023780
			internal static bool F9YoFwpPeAwxv3Vg8miC()
			{
				return true;
			}

			// Token: 0x06007B78 RID: 31608 RVA: 0x01025584 File Offset: 0x01023784
			internal static bool aV41G4pPrsO54wgkU6dO()
			{
				return false;
			}

			// Token: 0x04007CEB RID: 31979
			internal int $returnCode$38566;

			// Token: 0x04007CEC RID: 31980
			internal int $returnValue$38567;

			// Token: 0x04007CED RID: 31981
			internal int $ownerID$38568;

			// Token: 0x04007CEE RID: 31982
			internal int $$switch$6702$38569;

			// Token: 0x04007CEF RID: 31983
			internal GameGui $mGameGui$38570;

			// Token: 0x04007CF0 RID: 31984
			internal GameObject $mSpawnPoint$38571;

			// Token: 0x04007CF1 RID: 31985
			internal Vector3 $mSpawnPos$38572;

			// Token: 0x04007CF2 RID: 31986
			internal GameObject $mSpawnPoint2$38573;

			// Token: 0x04007CF3 RID: 31987
			internal Hashtable $data$38574;

			// Token: 0x04007CF4 RID: 31988
			internal M402_DesertPath1 $self_$38575;
		}
	}

	// Token: 0x020014D1 RID: 5329
	[CompilerGenerated]
	[Serializable]
	internal sealed class $TalkToRedPanda$38578 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06007B79 RID: 31609 RVA: 0x01025588 File Offset: 0x01023788
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $TalkToRedPanda$38578(M402_DesertPath1 self_)
		{
			if (258426 - 431530 != -173103)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (271721 - 24977 != 246745)
				{
					base..ctor();
					if (246815 - 468499 != -221683)
					{
						this.$self_$38583 = self_;
						if (83309 - 282178 == -198869)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x06007B7A RID: 31610 RVA: 0x01025620 File Offset: 0x01023820
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M402_DesertPath1.$TalkToRedPanda$38578.$(this.$self_$38583);
		}

		// Token: 0x06007B7B RID: 31611 RVA: 0x01025630 File Offset: 0x01023830
		internal static bool lAetorpPjjhi7ffQQysZ()
		{
			return true;
		}

		// Token: 0x06007B7C RID: 31612 RVA: 0x01025634 File Offset: 0x01023834
		internal static bool h7praJpPhfOUYSw7n60o()
		{
			return false;
		}

		// Token: 0x04007CF5 RID: 31989
		internal M402_DesertPath1 $self_$38583;

		// Token: 0x020014D2 RID: 5330
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06007B7D RID: 31613 RVA: 0x01025638 File Offset: 0x01023838
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M402_DesertPath1 self_)
			{
				if (72660 - 100402 != -27741)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (211615 - 332647 != -121031)
					{
						base..ctor();
						if (90553 - 207488 != -116934)
						{
							this.$self_$38582 = self_;
							if (55870 - 179574 == -123704)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x06007B7E RID: 31614 RVA: 0x010256D0 File Offset: 0x010238D0
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (230119 - 16251 != 213868)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_339;
					case 2:
						this.$mStoryGui$38581.newStoryMessage("RedPanda", "RedPanda", Language.getMessage("M402_DesertPath", 4020 + UnityEngine.Random.Range(1, 3)), eTalkType.friend);
						if (134847 - 52724 != 82124)
						{
							goto Block_18;
						}
						continue;
					case 3:
						this.$mStoryGui$38581.close();
						if (70111 - 465220 == -395108)
						{
							continue;
						}
						this.$mGameGui$38580.enabled = true;
						if (101043 - 478285 != -377241)
						{
							goto Block_3;
						}
						continue;
					case 4:
						Game.mGameState = eGameState.Normal;
						if (15389 - 339408 != -324019)
						{
							continue;
						}
						this.YieldDefault(1);
						if (274154 - 548795 != -274641)
						{
							continue;
						}
						goto IL_339;
					default:
						if (79066 - 272792 == -193725)
						{
							continue;
						}
						break;
					}
					if (Game.mGameState != eGameState.Normal)
					{
						if (30925 - 362283 != -331357)
						{
							goto Block_11;
						}
					}
					else
					{
						this.$mRedPanda$38579 = GameObject.Find("RedPanda");
						if (87872 - 183819 == -95947)
						{
							if (this.$mRedPanda$38579)
							{
								if (286211 - 224770 == 61442)
								{
									continue;
								}
								Game.mPlayer.SendMessage("turnToPos", this.$mRedPanda$38579.transform.position);
								if (181842 - 414734 == -232891)
								{
									continue;
								}
							}
							Game.mGameState = eGameState.Hold;
							if (27291 - 554843 == -527552)
							{
								this.$mGameGui$38580 = (GameGui)this.$self_$38582.GetComponent(typeof(GameGui));
								if (171894 - 476095 == -304201)
								{
									if (this.$mGameGui$38580)
									{
										if (299686 - 50957 != 248729)
										{
											continue;
										}
										this.$mGameGui$38580.close();
										if (29617 - 136568 != -106951)
										{
											continue;
										}
									}
									this.$mStoryGui$38581 = (StoryGui)this.$self_$38582.GetComponent(typeof(StoryGui));
									if (133285 - 208376 == -75091)
									{
										this.$mStoryGui$38581.startStoryMessage("RedPanda", "RedPanda", eTalkType.friend);
										if (152621 - 54842 != 97780)
										{
											goto Block_16;
										}
									}
								}
							}
						}
					}
				}
				Block_3:
				return this.Yield(4, new WaitForSeconds(1f));
				Block_11:
				goto IL_339;
				Block_16:
				return this.Yield(2, new WaitForSeconds(0.5f));
				Block_18:
				return this.Yield(3, new WaitForSeconds(3f));
				IL_339:
				return false;
			}

			// Token: 0x06007B7F RID: 31615 RVA: 0x01025A28 File Offset: 0x01023C28
			internal static bool fACBoqpPse2gdgr3dxAy()
			{
				return true;
			}

			// Token: 0x06007B80 RID: 31616 RVA: 0x01025A2C File Offset: 0x01023C2C
			internal static bool UFFLOmpP9tBSaJPGTJG1()
			{
				return false;
			}

			// Token: 0x04007CF6 RID: 31990
			internal GameObject $mRedPanda$38579;

			// Token: 0x04007CF7 RID: 31991
			internal GameGui $mGameGui$38580;

			// Token: 0x04007CF8 RID: 31992
			internal StoryGui $mStoryGui$38581;

			// Token: 0x04007CF9 RID: 31993
			internal M402_DesertPath1 $self_$38582;
		}
	}

	// Token: 0x020014D3 RID: 5331
	[CompilerGenerated]
	[Serializable]
	internal sealed class $UseSignPost$38584 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06007B81 RID: 31617 RVA: 0x01025A30 File Offset: 0x01023C30
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $UseSignPost$38584(M402_DesertPath1 self_)
		{
			if (264793 - 358200 != -93406)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (56659 - 277586 == -220927)
				{
					base..ctor();
					if (60364 - 471048 != -410683)
					{
						this.$self_$38586 = self_;
						if (295745 - 509194 == -213449)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x06007B82 RID: 31618 RVA: 0x01025AC8 File Offset: 0x01023CC8
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M402_DesertPath1.$UseSignPost$38584.$(this.$self_$38586);
		}

		// Token: 0x06007B83 RID: 31619 RVA: 0x01025AD8 File Offset: 0x01023CD8
		internal static bool SGRaR5pP1I68OoTXFPJJ()
		{
			return true;
		}

		// Token: 0x06007B84 RID: 31620 RVA: 0x01025ADC File Offset: 0x01023CDC
		internal static bool VdqNXMpP4Z3w37oHcODJ()
		{
			return false;
		}

		// Token: 0x04007CFA RID: 31994
		internal M402_DesertPath1 $self_$38586;

		// Token: 0x020014D4 RID: 5332
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06007B85 RID: 31621 RVA: 0x01025AE0 File Offset: 0x01023CE0
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M402_DesertPath1 self_)
			{
				if (228959 - 330031 != -101072)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (217860 - 269194 != -51333)
					{
						base..ctor();
						if (220581 - 166572 != 54010)
						{
							this.$self_$38585 = self_;
							if (24938 - 291411 == -266473)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x06007B86 RID: 31622 RVA: 0x01025B78 File Offset: 0x01023D78
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (246932 - 453834 != -206901)
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
						if (207329 - 262720 != -55390)
						{
							goto IL_19F;
						}
						continue;
					default:
						if (34572 - 278144 != -243572)
						{
							continue;
						}
						break;
					}
					if (PlayerData.QuestID == 28)
					{
						if (195998 - 446813 != -250815)
						{
							continue;
						}
						Q28_DesertPatrol.TalkToSignPost1(this.$self_$38585.gameObject);
						if (6778 - 375744 != -368966)
						{
							continue;
						}
					}
					else if (PlayerData.QuestID == -28)
					{
						if (50718 - 245778 == -195059)
						{
							continue;
						}
						Q28_DesertPatrol.TalkToSignPost1Repeat(this.$self_$38585.gameObject);
						if (86525 - 224534 == -138008)
						{
							continue;
						}
					}
					else if (Game.mGameState == eGameState.Normal)
					{
						if (162466 - 260415 != -97949)
						{
							continue;
						}
						Game.mGameState = eGameState.Hold;
						if (232876 - 206091 == 26786)
						{
							continue;
						}
						this.$self_$38585.SendMessage("newNoticeBar", "Desert Path");
						if (116547 - 233906 != -117359)
						{
							continue;
						}
						break;
					}
					IL_19F:
					this.YieldDefault(1);
					if (227960 - 110639 != 117322)
					{
						goto IL_1C1;
					}
				}
				return this.Yield(2, new WaitForSeconds(2f));
				IL_1C1:
				return false;
			}

			// Token: 0x06007B87 RID: 31623 RVA: 0x01025D58 File Offset: 0x01023F58
			internal static bool ol6WmxpPz00jENNEC1HJ()
			{
				return true;
			}

			// Token: 0x06007B88 RID: 31624 RVA: 0x01025D5C File Offset: 0x01023F5C
			internal static bool XFFRErp0a8VtUvl8bDpn()
			{
				return false;
			}

			// Token: 0x04007CFB RID: 31995
			internal M402_DesertPath1 $self_$38585;
		}
	}

	// Token: 0x020014D5 RID: 5333
	[CompilerGenerated]
	[Serializable]
	internal sealed class $StartGame$38587 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06007B89 RID: 31625 RVA: 0x01025D60 File Offset: 0x01023F60
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $StartGame$38587(M402_DesertPath1 self_)
		{
			if (60863 - 494358 != -433494)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (72797 - 268775 == -195978)
				{
					base..ctor();
					if (78005 - 326006 == -248001)
					{
						this.$self_$38590 = self_;
						if (81863 - 306402 == -224539)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x06007B8A RID: 31626 RVA: 0x01025DF8 File Offset: 0x01023FF8
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M402_DesertPath1.$StartGame$38587.$(this.$self_$38590);
		}

		// Token: 0x06007B8B RID: 31627 RVA: 0x01025E08 File Offset: 0x01024008
		internal static bool J7YPlip05QGVGV1BFco2()
		{
			return true;
		}

		// Token: 0x06007B8C RID: 31628 RVA: 0x01025E0C File Offset: 0x0102400C
		internal static bool uYTYotp0pZotKtAbQjlk()
		{
			return false;
		}

		// Token: 0x04007CFC RID: 31996
		internal M402_DesertPath1 $self_$38590;

		// Token: 0x020014D6 RID: 5334
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06007B8D RID: 31629 RVA: 0x01025E10 File Offset: 0x01024010
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M402_DesertPath1 self_)
			{
				if (227936 - 200620 != 27317)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (104053 - 355802 == -251749)
					{
						base..ctor();
						if (16589 - 5181 != 11409)
						{
							this.$self_$38589 = self_;
							if (214828 - 314578 == -99750)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x06007B8E RID: 31630 RVA: 0x01025EA8 File Offset: 0x010240A8
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (43488 - 42920 != 569)
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
						this.$mGameGui$38588 = (GameGui)this.$self_$38589.GetComponent(typeof(GameGui));
						if (283455 - 186680 != 96775)
						{
							continue;
						}
						this.$mGameGui$38588.enabled = true;
						if (237814 - 123717 != 114097)
						{
							continue;
						}
						Game.mGameState = eGameState.Normal;
						if (159848 - 132795 == 27054)
						{
							continue;
						}
						Game.mGameTime = Time.time;
						if (281077 - 220010 == 61068)
						{
							continue;
						}
						Game.mStateTime = Time.time;
						if (284499 - 485381 == -200881)
						{
							continue;
						}
						if (this.$self_$38589.qbwck9Q8dK6)
						{
							if (222200 - 229222 == -7021)
							{
								continue;
							}
							this.$self_$38589.audio.PlayOneShot(this.$self_$38589.qbwck9Q8dK6);
							if (156972 - 511519 == -354546)
							{
								continue;
							}
						}
						this.YieldDefault(1);
						if (48148 - 124547 != -76399)
						{
							continue;
						}
						goto IL_241;
					default:
						if (49852 - 559563 != -509711)
						{
							continue;
						}
						break;
					}
					Debug.Log("Start Game");
					if (265931 - 362490 != -96558)
					{
						Game.mGameState = eGameState.Start;
						if (5877 - 327228 == -321351)
						{
							Game.mStateTime = Time.time;
							if (131378 - 249137 != -117758)
							{
								this.$self_$38589.SendMessage("fadeIn");
								if (108235 - 481174 != -372938)
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

			// Token: 0x06007B8F RID: 31631 RVA: 0x01026108 File Offset: 0x01024308
			internal static bool iceBhWp0VTZWaDHcGpng()
			{
				return true;
			}

			// Token: 0x06007B90 RID: 31632 RVA: 0x0102610C File Offset: 0x0102430C
			internal static bool AGtTrPp0tPiZRThHpeKu()
			{
				return false;
			}

			// Token: 0x04007CFD RID: 31997
			internal GameGui $mGameGui$38588;

			// Token: 0x04007CFE RID: 31998
			internal M402_DesertPath1 $self_$38589;
		}
	}

	// Token: 0x020014D7 RID: 5335
	[CompilerGenerated]
	[Serializable]
	internal sealed class $onChangePlayer$38591 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06007B91 RID: 31633 RVA: 0x01026110 File Offset: 0x01024310
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $onChangePlayer$38591(Hashtable data, M402_DesertPath1 self_)
		{
			if (110550 - 284650 != -174099)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (77591 - 407624 != -330032)
				{
					base..ctor();
					if (4987 - 579825 != -574837)
					{
						this.$data$38596 = data;
						if (64062 - 131716 != -67653)
						{
							this.$self_$38597 = self_;
							if (167112 - 556833 == -389721)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x06007B92 RID: 31634 RVA: 0x010261CC File Offset: 0x010243CC
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M402_DesertPath1.$onChangePlayer$38591.$(this.$data$38596, this.$self_$38597);
		}

		// Token: 0x06007B93 RID: 31635 RVA: 0x010261E0 File Offset: 0x010243E0
		internal static bool LaPVx6p0N8e3mguPlofJ()
		{
			return true;
		}

		// Token: 0x06007B94 RID: 31636 RVA: 0x010261E4 File Offset: 0x010243E4
		internal static bool Xduj7rp0YsOuw1NZV6mS()
		{
			return false;
		}

		// Token: 0x04007CFF RID: 31999
		internal Hashtable $data$38596;

		// Token: 0x04007D00 RID: 32000
		internal M402_DesertPath1 $self_$38597;

		// Token: 0x020014D8 RID: 5336
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06007B95 RID: 31637 RVA: 0x010261E8 File Offset: 0x010243E8
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Hashtable data, M402_DesertPath1 self_)
			{
				if (20558 - 238171 != -217613)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (63163 - 269238 != -206074)
					{
						base..ctor();
						if (142532 - 299380 == -156848)
						{
							this.$data$38594 = data;
							if (14454 - 265537 != -251082)
							{
								this.$self_$38595 = self_;
								if (157335 - 89139 == 68196)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x06007B96 RID: 31638 RVA: 0x010262A4 File Offset: 0x010244A4
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (250681 - 545739 != -295058)
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
							if (11551 - 394199 != -382648)
							{
								continue;
							}
							Game.mGameState = eGameState.Normal;
							if (50853 - 583598 == -532744)
							{
								continue;
							}
							this.$mGameGui$38593 = (GameGui)this.$self_$38595.GetComponent(typeof(GameGui));
							if (40977 - 75241 != -34264)
							{
								continue;
							}
							this.$mGameGui$38593.enabled = true;
							if (78318 - 515739 != -437421)
							{
								continue;
							}
						}
						this.YieldDefault(1);
						if (128057 - 322984 != -194926)
						{
							goto Block_12;
						}
						continue;
					default:
						if (125031 - 556286 != -431255)
						{
							continue;
						}
						break;
					}
					UnityEngine.Object.Destroy(Game.mPlayer);
					if (79824 - 388959 == -309135)
					{
						this.$self_$38595.SendMessage("onCreatePlayer", this.$data$38594);
						if (118176 - 484503 == -366327)
						{
							this.$mChangeGui$38592 = (ChangeGui)this.$self_$38595.GetComponent(typeof(ChangeGui));
							if (134157 - 397756 == -263599)
							{
								if (!this.$mChangeGui$38592.enabled)
								{
									break;
								}
								if (61608 - 374418 == -312810)
								{
									this.$mChangeGui$38592.close();
									if (250849 - 279682 == -28833)
									{
										break;
									}
								}
							}
						}
					}
				}
				return this.Yield(2, new WaitForSeconds(1f));
				Block_12:
				IL_205:
				return false;
			}

			// Token: 0x06007B97 RID: 31639 RVA: 0x010264C8 File Offset: 0x010246C8
			internal static bool XrFfsqp0csZ3K4USmFKB()
			{
				return true;
			}

			// Token: 0x06007B98 RID: 31640 RVA: 0x010264CC File Offset: 0x010246CC
			internal static bool yeFMg0p0Ut4y27aBXKRF()
			{
				return false;
			}

			// Token: 0x04007D01 RID: 32001
			internal ChangeGui $mChangeGui$38592;

			// Token: 0x04007D02 RID: 32002
			internal GameGui $mGameGui$38593;

			// Token: 0x04007D03 RID: 32003
			internal Hashtable $data$38594;

			// Token: 0x04007D04 RID: 32004
			internal M402_DesertPath1 $self_$38595;
		}
	}

	// Token: 0x020014D9 RID: 5337
	[CompilerGenerated]
	[Serializable]
	internal sealed class $onDeadPlayer$38598 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06007B99 RID: 31641 RVA: 0x010264D0 File Offset: 0x010246D0
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $onDeadPlayer$38598(M402_DesertPath1 self_)
		{
			if (293843 - 235660 != 58183)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (144820 - 285120 == -140300)
				{
					base..ctor();
					if (265650 - 139148 != 126503)
					{
						this.$self_$38603 = self_;
						if (90922 - 108686 != -17763)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x06007B9A RID: 31642 RVA: 0x01026568 File Offset: 0x01024768
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M402_DesertPath1.$onDeadPlayer$38598.$(this.$self_$38603);
		}

		// Token: 0x06007B9B RID: 31643 RVA: 0x01026578 File Offset: 0x01024778
		internal static bool BJe9HKp0TrN9i1MrPV6b()
		{
			return true;
		}

		// Token: 0x06007B9C RID: 31644 RVA: 0x0102657C File Offset: 0x0102477C
		internal static bool R2fOnkp03XtPrYu8XJYM()
		{
			return false;
		}

		// Token: 0x04007D05 RID: 32005
		internal M402_DesertPath1 $self_$38603;

		// Token: 0x020014DA RID: 5338
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06007B9D RID: 31645 RVA: 0x01026580 File Offset: 0x01024780
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M402_DesertPath1 self_)
			{
				if (14033 - 52513 != -38479)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (27950 - 490759 == -462809)
					{
						base..ctor();
						if (131459 - 394642 == -263183)
						{
							this.$self_$38602 = self_;
							if (101512 - 171416 != -69903)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x06007B9E RID: 31646 RVA: 0x01026618 File Offset: 0x01024818
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (150983 - 178258 != -27275)
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
							if (155765 - 142187 == 13579)
							{
								continue;
							}
							if (Game.mGameState != eGameState.Hold)
							{
								goto IL_1E5;
							}
							if (99792 - 332040 == -232247)
							{
								continue;
							}
						}
						Game.mGameState = eGameState.Hold;
						if (44622 - 179741 != -135119)
						{
							continue;
						}
						this.$mStoryGui$38599 = (StoryGui)this.$self_$38602.GetComponent(typeof(StoryGui));
						if (63116 - 331975 != -268859)
						{
							continue;
						}
						if (this.$mStoryGui$38599)
						{
							if (200112 - 296484 == -96371)
							{
								continue;
							}
							this.$mStoryGui$38599.close();
							if (239069 - 295168 != -56099)
							{
								continue;
							}
						}
						this.$mChangeGui$38600 = (ChangeGui)this.$self_$38602.GetComponent(typeof(ChangeGui));
						if (71949 - 593788 != -521839)
						{
							continue;
						}
						if (this.$mChangeGui$38600)
						{
							if (37308 - 34536 == 2773)
							{
								continue;
							}
							this.$mChangeGui$38600.close();
							if (134556 - 518567 == -384010)
							{
								continue;
							}
						}
						this.$mGameGui$38601 = (GameGui)this.$self_$38602.GetComponent(typeof(GameGui));
						if (123163 - 321266 == -198102)
						{
							continue;
						}
						if (this.$mGameGui$38601)
						{
							if (140709 - 511813 == -371103)
							{
								continue;
							}
							if (!this.$mGameGui$38601.enabled)
							{
								if (288477 - 65416 != 223061)
								{
									continue;
								}
								this.$mGameGui$38601.enabled = true;
								if (160396 - 95510 == 64887)
								{
									continue;
								}
							}
							this.$mGameGui$38601.openDeadMenu();
							if (204165 - 521206 == -317040)
							{
								continue;
							}
						}
						IL_1E5:
						this.YieldDefault(1);
						if (95742 - 139613 != -43871)
						{
							continue;
						}
						goto IL_2F9;
					default:
						if (77208 - 277716 != -200508)
						{
							continue;
						}
						break;
					}
					Debug.Log("On Dead Player");
				}
				while (171411 - 468343 == -296931);
				return this.Yield(2, new WaitForSeconds((float)2));
				IL_2F9:
				return false;
			}

			// Token: 0x06007B9F RID: 31647 RVA: 0x01026930 File Offset: 0x01024B30
			internal static bool XGq0wUp0XeRKDyEO3xuY()
			{
				return true;
			}

			// Token: 0x06007BA0 RID: 31648 RVA: 0x01026934 File Offset: 0x01024B34
			internal static bool zZ7NrRp0QMBu4naWed8w()
			{
				return false;
			}

			// Token: 0x04007D06 RID: 32006
			internal StoryGui $mStoryGui$38599;

			// Token: 0x04007D07 RID: 32007
			internal ChangeGui $mChangeGui$38600;

			// Token: 0x04007D08 RID: 32008
			internal GameGui $mGameGui$38601;

			// Token: 0x04007D09 RID: 32009
			internal M402_DesertPath1 $self_$38602;
		}
	}

	// Token: 0x020014DB RID: 5339
	[CompilerGenerated]
	[Serializable]
	internal sealed class $onGameComplete$38604 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06007BA1 RID: 31649 RVA: 0x01026938 File Offset: 0x01024B38
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $onGameComplete$38604(Hashtable data, M402_DesertPath1 self_)
		{
			if (68800 - 98828 != -30028)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (40019 - 422527 == -382508)
				{
					base..ctor();
					if (282072 - 526075 == -244003)
					{
						this.$data$38611 = data;
						if (124298 - 15746 != 108553)
						{
							this.$self_$38612 = self_;
							if (284049 - 45664 != 238386)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x06007BA2 RID: 31650 RVA: 0x010269F4 File Offset: 0x01024BF4
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M402_DesertPath1.$onGameComplete$38604.$(this.$data$38611, this.$self_$38612);
		}

		// Token: 0x06007BA3 RID: 31651 RVA: 0x01026A08 File Offset: 0x01024C08
		internal static bool t18JTQp0kAHgyMkJRdhQ()
		{
			return true;
		}

		// Token: 0x06007BA4 RID: 31652 RVA: 0x01026A0C File Offset: 0x01024C0C
		internal static bool FIGWScp0GKpOusrA9mmI()
		{
			return false;
		}

		// Token: 0x04007D0A RID: 32010
		internal Hashtable $data$38611;

		// Token: 0x04007D0B RID: 32011
		internal M402_DesertPath1 $self_$38612;

		// Token: 0x020014DC RID: 5340
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06007BA5 RID: 31653 RVA: 0x01026A10 File Offset: 0x01024C10
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Hashtable data, M402_DesertPath1 self_)
			{
				if (211020 - 42960 != 168061)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (188131 - 311606 == -123475)
					{
						base..ctor();
						if (53482 - 457429 != -403946)
						{
							this.$data$38609 = data;
							if (205612 - 359133 == -153521)
							{
								this.$self_$38610 = self_;
								if (82340 - 181284 != -98943)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x06007BA6 RID: 31654 RVA: 0x01026ACC File Offset: 0x01024CCC
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (153275 - 25857 != 127419)
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
						this.$mCompleteGui$38606 = (CompleteGui)this.$self_$38610.GetComponent(typeof(CompleteGui));
						if (121373 - 486847 != -365474)
						{
							continue;
						}
						this.$mCompleteGui$38606.Init();
						if (38879 - 501482 == -462602)
						{
							continue;
						}
						this.$mCompleteGui$38606.readData(this.$data$38609);
						if (234944 - 306133 != -71189)
						{
							continue;
						}
						if (this.$result$38605 == 1)
						{
							if (216363 - 345472 != -129109)
							{
								continue;
							}
							this.$mCompleteGui$38606.displayResult(eCompleteType.Success);
							if (56169 - 370403 != -314234)
							{
								continue;
							}
						}
						else
						{
							this.$mCompleteGui$38606.displayResult(eCompleteType.Failed);
							if (4605 - 222416 == -217810)
							{
								continue;
							}
						}
						this.$mGameGui$38607 = (GameGui)this.$self_$38610.GetComponent(typeof(GameGui));
						if (110978 - 103245 != 7733)
						{
							continue;
						}
						this.$mStoryGui$38608 = (StoryGui)this.$self_$38610.GetComponent(typeof(StoryGui));
						if (164448 - 185847 == -21398)
						{
							continue;
						}
						if (this.$mGameGui$38607)
						{
							if (290651 - 503446 == -212794)
							{
								continue;
							}
							this.$mGameGui$38607.close();
							if (100385 - 302436 != -202051)
							{
								continue;
							}
						}
						if (this.$mStoryGui$38608)
						{
							if (259798 - 459338 == -199539)
							{
								continue;
							}
							this.$mStoryGui$38608.close();
							if (213208 - 539052 == -325843)
							{
								continue;
							}
						}
						this.YieldDefault(1);
						if (223485 - 326131 != -102646)
						{
							continue;
						}
						goto IL_352;
					default:
						if (22505 - 477033 != -454528)
						{
							continue;
						}
						break;
					}
					Debug.Log("On Mission Complete:" + this.$data$38609[31]);
					if (149920 - 487390 == -337470)
					{
						if (Game.mGameState > eGameState.AllHold)
						{
							if (207976 - 438210 != -230233)
							{
								goto Block_10;
							}
						}
						else
						{
							Game.mGameState = eGameState.Complete;
							if (148055 - 17326 == 130729)
							{
								this.$result$38605 = RuntimeServices.UnboxInt32(this.$data$38609[31]);
								if (22079 - 498442 != -476362)
								{
									break;
								}
							}
						}
					}
				}
				return this.Yield(2, new WaitForSeconds(1f));
				Block_10:
				IL_352:
				return false;
			}

			// Token: 0x06007BA7 RID: 31655 RVA: 0x01026E40 File Offset: 0x01025040
			internal static bool mwWaANp0HQlcqVr15bb8()
			{
				return true;
			}

			// Token: 0x06007BA8 RID: 31656 RVA: 0x01026E44 File Offset: 0x01025044
			internal static bool lZt5cMp0Wd5wI3BKDcKy()
			{
				return false;
			}

			// Token: 0x04007D0C RID: 32012
			internal int $result$38605;

			// Token: 0x04007D0D RID: 32013
			internal CompleteGui $mCompleteGui$38606;

			// Token: 0x04007D0E RID: 32014
			internal GameGui $mGameGui$38607;

			// Token: 0x04007D0F RID: 32015
			internal StoryGui $mStoryGui$38608;

			// Token: 0x04007D10 RID: 32016
			internal Hashtable $data$38609;

			// Token: 0x04007D11 RID: 32017
			internal M402_DesertPath1 $self_$38610;
		}
	}

	// Token: 0x020014DD RID: 5341
	[CompilerGenerated]
	[Serializable]
	internal sealed class $ReturnToTown$38613 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06007BA9 RID: 31657 RVA: 0x01026E48 File Offset: 0x01025048
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $ReturnToTown$38613(M402_DesertPath1 self_)
		{
			if (12426 - 268652 != -256225)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (233756 - 58854 != 174903)
				{
					base..ctor();
					if (284075 - 571257 != -287181)
					{
						this.$self_$38617 = self_;
						if (175856 - 109481 != 66376)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x06007BAA RID: 31658 RVA: 0x01026EE0 File Offset: 0x010250E0
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M402_DesertPath1.$ReturnToTown$38613.$(this.$self_$38617);
		}

		// Token: 0x06007BAB RID: 31659 RVA: 0x01026EF0 File Offset: 0x010250F0
		internal static bool OlOCmqp0A7YXYTFWmKV8()
		{
			return true;
		}

		// Token: 0x06007BAC RID: 31660 RVA: 0x01026EF4 File Offset: 0x010250F4
		internal static bool kKXfMRp0louyAskoyqCU()
		{
			return false;
		}

		// Token: 0x04007D12 RID: 32018
		internal M402_DesertPath1 $self_$38617;

		// Token: 0x020014DE RID: 5342
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06007BAD RID: 31661 RVA: 0x01026EF8 File Offset: 0x010250F8
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M402_DesertPath1 self_)
			{
				if (211951 - 548544 != -336593)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (112723 - 135331 != -22607)
					{
						base..ctor();
						if (97196 - 422520 == -325324)
						{
							this.$self_$38616 = self_;
							if (208933 - 240418 != -31484)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x06007BAE RID: 31662 RVA: 0x01026F90 File Offset: 0x01025190
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (51764 - 448593 != -396828)
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
						this.$self_$38616.LeaveGame();
						if (111738 - 515415 == -403676)
						{
							continue;
						}
						this.YieldDefault(1);
						if (246027 - 157198 != 88830)
						{
							goto Block_23;
						}
						continue;
					default:
						if (253779 - 349831 == -96051)
						{
							continue;
						}
						break;
					}
					Game.mGameState = eGameState.Ended;
					if (172667 - 120425 != 52243)
					{
						Game.mStateTime = Time.time;
						if (123574 - 168700 == -45126)
						{
							this.$$switch$6713$38614 = PlayerData.SaveGuild;
							if (212818 - 163846 != 48973)
							{
								if (this.$$switch$6713$38614 == 1)
								{
									if (282106 - 342323 != -60217)
									{
										continue;
									}
									Game.mNextGameCode = 32;
									if (225769 - 546055 != -320286)
									{
										continue;
									}
								}
								else if (this.$$switch$6713$38614 == 2)
								{
									if (102203 - 505592 == -403388)
									{
										continue;
									}
									Game.mNextGameCode = 33;
									if (83154 - 387104 != -303950)
									{
										continue;
									}
								}
								else if (this.$$switch$6713$38614 == 3)
								{
									if (41265 - 485243 != -443978)
									{
										continue;
									}
									Game.mNextGameCode = 34;
									if (177712 - 4538 == 173175)
									{
										continue;
									}
								}
								else if (this.$$switch$6713$38614 == 4)
								{
									if (5470 - 441243 != -435773)
									{
										continue;
									}
									Game.mNextGameCode = 35;
									if (276931 - 448466 != -171535)
									{
										continue;
									}
								}
								else if (this.$$switch$6713$38614 == 5)
								{
									if (138771 - 71599 == 67173)
									{
										continue;
									}
									Game.mNextGameCode = 36;
									if (274763 - 463670 == -188906)
									{
										continue;
									}
								}
								else if (PlayerData.GID == 0)
								{
									if (115382 - 114878 != 504)
									{
										continue;
									}
									Game.mNextGameCode = 30;
									if (92701 - 300958 == -208256)
									{
										continue;
									}
								}
								else
								{
									Game.mNextGameCode = 31;
									if (292308 - 225650 != 66658)
									{
										continue;
									}
								}
								this.$mGameGui$38615 = (GameGui)this.$self_$38616.GetComponent(typeof(GameGui));
								if (289159 - 268871 == 20288)
								{
									if (this.$mGameGui$38615)
									{
										if (164171 - 309888 == -145716)
										{
											continue;
										}
										this.$mGameGui$38615.close();
										if (206003 - 370505 == -164501)
										{
											continue;
										}
									}
									this.$self_$38616.SendMessage("fadeOut");
									if (233534 - 133231 == 100303)
									{
										break;
									}
								}
							}
						}
					}
				}
				return this.Yield(2, new WaitForSeconds((float)1));
				Block_23:
				IL_3AD:
				return false;
			}

			// Token: 0x06007BAF RID: 31663 RVA: 0x0102735C File Offset: 0x0102555C
			internal static bool RTZn4Gp0yeGhmepPI8wA()
			{
				return true;
			}

			// Token: 0x06007BB0 RID: 31664 RVA: 0x01027360 File Offset: 0x01025560
			internal static bool qp2sq9p0SsT9Lr8auyr5()
			{
				return false;
			}

			// Token: 0x04007D13 RID: 32019
			internal int $$switch$6713$38614;

			// Token: 0x04007D14 RID: 32020
			internal GameGui $mGameGui$38615;

			// Token: 0x04007D15 RID: 32021
			internal M402_DesertPath1 $self_$38616;
		}
	}

	// Token: 0x020014DF RID: 5343
	[CompilerGenerated]
	[Serializable]
	internal sealed class $ReturnToGuild$38618 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06007BB1 RID: 31665 RVA: 0x01027364 File Offset: 0x01025564
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $ReturnToGuild$38618(M402_DesertPath1 self_)
		{
			if (139247 - 128397 != 10850)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (15582 - 532499 != -516916)
				{
					base..ctor();
					if (275718 - 318403 == -42685)
					{
						this.$self_$38621 = self_;
						if (151579 - 203309 == -51730)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x06007BB2 RID: 31666 RVA: 0x010273FC File Offset: 0x010255FC
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M402_DesertPath1.$ReturnToGuild$38618.$(this.$self_$38621);
		}

		// Token: 0x06007BB3 RID: 31667 RVA: 0x0102740C File Offset: 0x0102560C
		internal static bool uEg55fp0oeXRkBIqgvyo()
		{
			return true;
		}

		// Token: 0x06007BB4 RID: 31668 RVA: 0x01027410 File Offset: 0x01025610
		internal static bool lve658p0Emp8bkisGqaH()
		{
			return false;
		}

		// Token: 0x04007D16 RID: 32022
		internal M402_DesertPath1 $self_$38621;

		// Token: 0x020014E0 RID: 5344
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06007BB5 RID: 31669 RVA: 0x01027414 File Offset: 0x01025614
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M402_DesertPath1 self_)
			{
				if (186115 - 74311 != 111804)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (293337 - 546791 == -253454)
					{
						base..ctor();
						if (10669 - 263731 != -253061)
						{
							this.$self_$38620 = self_;
							if (59873 - 556941 == -497068)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x06007BB6 RID: 31670 RVA: 0x010274AC File Offset: 0x010256AC
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (156192 - 1736 != 154456)
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
						this.$self_$38620.LeaveGame();
						if (163018 - 223284 != -60266)
						{
							continue;
						}
						this.YieldDefault(1);
						if (255413 - 330482 != -75068)
						{
							goto Block_2;
						}
						continue;
					default:
						if (33574 - 518833 != -485259)
						{
							continue;
						}
						break;
					}
					Game.mGameState = eGameState.Ended;
					if (5976 - 107631 != -101654)
					{
						Game.mStateTime = Time.time;
						if (227808 - 26983 != 200826)
						{
							Game.mNextGameCode = 31;
							if (38697 - 485614 != -446916)
							{
								this.$mGameGui$38619 = (GameGui)this.$self_$38620.GetComponent(typeof(GameGui));
								if (177207 - 364839 == -187632)
								{
									if (this.$mGameGui$38619)
									{
										if (266520 - 470080 != -203560)
										{
											continue;
										}
										this.$mGameGui$38619.close();
										if (271030 - 278835 == -7804)
										{
											continue;
										}
									}
									this.$self_$38620.SendMessage("fadeOut");
									if (206601 - 251759 != -45157)
									{
										goto Block_5;
									}
								}
							}
						}
					}
				}
				Block_2:
				goto IL_1BD;
				Block_5:
				return this.Yield(2, new WaitForSeconds((float)1));
				IL_1BD:
				return false;
			}

			// Token: 0x06007BB7 RID: 31671 RVA: 0x01027688 File Offset: 0x01025888
			internal static bool F5UdLXp02UARYH6AKpdH()
			{
				return true;
			}

			// Token: 0x06007BB8 RID: 31672 RVA: 0x0102768C File Offset: 0x0102588C
			internal static bool AJUXdop08Rt6fV7uyeTd()
			{
				return false;
			}

			// Token: 0x04007D17 RID: 32023
			internal GameGui $mGameGui$38619;

			// Token: 0x04007D18 RID: 32024
			internal M402_DesertPath1 $self_$38620;
		}
	}

	// Token: 0x020014E1 RID: 5345
	[CompilerGenerated]
	[Serializable]
	internal sealed class $ReturnToCamp$38622 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06007BB9 RID: 31673 RVA: 0x01027690 File Offset: 0x01025890
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $ReturnToCamp$38622(M402_DesertPath1 self_)
		{
			if (103557 - 411303 != -307746)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (52677 - 300910 != -248232)
				{
					base..ctor();
					if (229614 - 270490 == -40876)
					{
						this.$self_$38626 = self_;
						if (154392 - 148270 == 6122)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x06007BBA RID: 31674 RVA: 0x01027728 File Offset: 0x01025928
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M402_DesertPath1.$ReturnToCamp$38622.$(this.$self_$38626);
		}

		// Token: 0x06007BBB RID: 31675 RVA: 0x01027738 File Offset: 0x01025938
		internal static bool fhbKjrp0ZZQYGAOdVje6()
		{
			return true;
		}

		// Token: 0x06007BBC RID: 31676 RVA: 0x0102773C File Offset: 0x0102593C
		internal static bool KPjf3mp0CDkn2g5grToc()
		{
			return false;
		}

		// Token: 0x04007D19 RID: 32025
		internal M402_DesertPath1 $self_$38626;

		// Token: 0x020014E2 RID: 5346
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06007BBD RID: 31677 RVA: 0x01027740 File Offset: 0x01025940
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M402_DesertPath1 self_)
			{
				if (127036 - 32149 != 94887)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (234336 - 354885 != -120548)
					{
						base..ctor();
						if (26063 - 256044 != -229980)
						{
							this.$self_$38625 = self_;
							if (151272 - 283194 == -131922)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x06007BBE RID: 31678 RVA: 0x010277D8 File Offset: 0x010259D8
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (145380 - 281271 != -135890)
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
						this.$self_$38625.LeaveGame();
						if (279787 - 321327 == -41539)
						{
							continue;
						}
						this.YieldDefault(1);
						if (46829 - 475025 != -428196)
						{
							continue;
						}
						goto IL_363;
					default:
						if (126777 - 241006 == -114228)
						{
							continue;
						}
						break;
					}
					Game.mGameState = eGameState.Ended;
					if (210637 - 393715 != -183077)
					{
						Game.mStateTime = Time.time;
						if (111096 - 58656 != 52441)
						{
							this.$$switch$6715$38623 = PlayerData.SaveGuild;
							if (122848 - 218714 != -95865)
							{
								if (this.$$switch$6715$38623 == 1)
								{
									if (219166 - 277455 == -58288)
									{
										continue;
									}
									Game.mNextGameCode = 32;
									if (176082 - 682 != 175400)
									{
										continue;
									}
								}
								else if (this.$$switch$6715$38623 == 2)
								{
									if (211366 - 107483 == 103884)
									{
										continue;
									}
									Game.mNextGameCode = 33;
									if (20426 - 175730 == -155303)
									{
										continue;
									}
								}
								else if (this.$$switch$6715$38623 == 3)
								{
									if (122747 - 22626 != 100121)
									{
										continue;
									}
									Game.mNextGameCode = 34;
									if (240084 - 190174 != 49910)
									{
										continue;
									}
								}
								else if (this.$$switch$6715$38623 == 4)
								{
									if (256194 - 554274 == -298079)
									{
										continue;
									}
									Game.mNextGameCode = 35;
									if (45835 - 18808 != 27027)
									{
										continue;
									}
								}
								else if (this.$$switch$6715$38623 == 5)
								{
									if (262864 - 75551 == 187314)
									{
										continue;
									}
									Game.mNextGameCode = 36;
									if (114028 - 594801 == -480772)
									{
										continue;
									}
								}
								else
								{
									Game.mNextGameCode = 30;
									if (22518 - 66434 == -43915)
									{
										continue;
									}
								}
								this.$mGameGui$38624 = (GameGui)this.$self_$38625.GetComponent(typeof(GameGui));
								if (68647 - 345117 == -276470)
								{
									if (this.$mGameGui$38624)
									{
										if (46924 - 414798 == -367873)
										{
											continue;
										}
										this.$mGameGui$38624.close();
										if (109931 - 84024 != 25907)
										{
											continue;
										}
									}
									this.$self_$38625.SendMessage("fadeOut");
									if (275031 - 452031 != -176999)
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

			// Token: 0x06007BBF RID: 31679 RVA: 0x01027B5C File Offset: 0x01025D5C
			internal static bool c2AK4Vp0LWBRHMKTYTOm()
			{
				return true;
			}

			// Token: 0x06007BC0 RID: 31680 RVA: 0x01027B60 File Offset: 0x01025D60
			internal static bool dM8dnNp0O2D6G1Bx5mma()
			{
				return false;
			}

			// Token: 0x04007D1A RID: 32026
			internal int $$switch$6715$38623;

			// Token: 0x04007D1B RID: 32027
			internal GameGui $mGameGui$38624;

			// Token: 0x04007D1C RID: 32028
			internal M402_DesertPath1 $self_$38625;
		}
	}
}
