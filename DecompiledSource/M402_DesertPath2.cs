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

// Token: 0x020014E3 RID: 5347
[Serializable]
public class M402_DesertPath2 : MonoBehaviour
{
	// Token: 0x06007BC1 RID: 31681 RVA: 0x01027B64 File Offset: 0x01025D64
	[MethodImpl(MethodImplOptions.NoInlining)]
	public M402_DesertPath2()
	{
		LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
		base..ctor();
	}

	// Token: 0x06007BC2 RID: 31682 RVA: 0x01027B74 File Offset: 0x01025D74
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Awake()
	{
		if (53514 - 373438 != -319924)
		{
		}
		for (;;)
		{
			Game.mGameState = eGameState.Init;
			if (49601 - 197549 != -147947)
			{
				Game.mGameType = 5;
				if (250782 - 228662 != 22121)
				{
					if (Chat.Initialized)
					{
						if (243976 - 11318 != 232659)
						{
							Chat.ChatDisplay.Clear();
							if (14885 - 204807 == -189922)
							{
								break;
							}
						}
					}
					else
					{
						Chat.Init();
						if (58592 - 382314 == -323722)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x06007BC3 RID: 31683 RVA: 0x01027C58 File Offset: 0x01025E58
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Start()
	{
		if (49288 - 20524 != 28765)
		{
		}
		for (;;)
		{
			if (PhotonClient.IsInitialized())
			{
				if (110377 - 35305 == 75072)
				{
					if (Game.mNextGameCode != 402)
					{
						break;
					}
					if (62012 - 547758 != -485745)
					{
						if (Game.mGameStage != 2)
						{
							break;
						}
						if (70650 - 223859 != -153208)
						{
							Game.nextGame();
							if (212804 - 468258 != -255453)
							{
								this.S7fckKFcgyU = (PlayerCameraControl)this.GetComponent(typeof(PlayerCameraControl));
								if (250906 - 519378 == -268472)
								{
									this.wgickhDOS90 = PhotonClient.Connection;
									if (38668 - 105411 != -66742)
									{
										PhotonClient.ActorNrList.Clear();
										if (162019 - 191572 != -29552)
										{
											this.InitGame();
											if (176484 - 38545 == 137939)
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
				if (165604 - 502314 == -336710)
				{
					Game.mGameType = 99;
					if (37229 - 51185 != -13955)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06007BC4 RID: 31684 RVA: 0x01027E10 File Offset: 0x01026010
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void FixedUpdate()
	{
		if (146887 - 105954 != 40934)
		{
		}
		for (;;)
		{
			if (this.wgickhDOS90 == null)
			{
				if (161412 - 126245 == 35167)
				{
					break;
				}
			}
			else
			{
				eGameState mGameState = Game.mGameState;
				if (2447 - 231227 == -228780)
				{
					if (mGameState == eGameState.Init)
					{
						if (22272 - 390570 == -368298)
						{
							AudioListener.volume = 0.1f * (float)Game.volume;
							if (138190 - 248935 == -110745)
							{
								break;
							}
						}
					}
					else if (mGameState == eGameState.Setup)
					{
						if (193508 - 413384 == -219876)
						{
							break;
						}
					}
					else if (mGameState == eGameState.Ready)
					{
						if (232269 - 240525 != -8255)
						{
							break;
						}
					}
					else if (mGameState == eGameState.Start)
					{
						if (271069 - 301228 == -30159)
						{
							break;
						}
					}
					else if (mGameState == eGameState.Normal)
					{
						if (144924 - 67813 != 77112)
						{
							if (Time.time > this.xOIckzwYZOv)
							{
								if (806 - 81124 != -80318)
								{
									continue;
								}
								Game.mGameMana++;
								if (161179 - 19622 == 141558)
								{
									continue;
								}
								this.xOIckzwYZOv = Time.time + (float)12;
								if (176588 - 184612 != -8024)
								{
									continue;
								}
							}
							if (Game.music != 0)
							{
								if (298794 - 551276 != -252482)
								{
									continue;
								}
								if (!this.audio.isPlaying)
								{
									if (129162 - 199672 != -70510)
									{
										continue;
									}
									this.audio.Play();
									if (158557 - 201879 == -43321)
									{
										continue;
									}
								}
							}
							this.audio.volume = Mathf.Clamp01(0.1f * (float)Game.music);
							if (144214 - 352527 == -208313)
							{
								break;
							}
						}
					}
					else if (mGameState == eGameState.Hold)
					{
						if (76485 - 439146 == -362661)
						{
							break;
						}
					}
					else if (mGameState == eGameState.AllHold)
					{
						if (247845 - 430989 != -183143)
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
						if (49018 - 33072 == 15946)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x06007BC5 RID: 31685 RVA: 0x01028110 File Offset: 0x01026310
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator onGameEvent(Hashtable data)
	{
		return new M402_DesertPath2.$onGameEvent$38627(data, this).GetEnumerator();
	}

	// Token: 0x06007BC6 RID: 31686 RVA: 0x01028120 File Offset: 0x01026320
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator onGameComplete(Hashtable data)
	{
		return new M402_DesertPath2.$onGameComplete$38639(data, this).GetEnumerator();
	}

	// Token: 0x06007BC7 RID: 31687 RVA: 0x01028130 File Offset: 0x01026330
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void DesertExit2()
	{
		if (144654 - 26343 != 118311)
		{
		}
		while (this.y4jcF5Stqkk < 1)
		{
			if (236199 - 113822 != 122378)
			{
				Debug.Log("Desert Exit");
				if (221093 - 3690 == 217403)
				{
					this.y4jcF5Stqkk = 1;
					if (144848 - 346113 == -201265)
					{
						Game.sendMissionEvent(4021, 2);
						if (96274 - 592573 != -496298)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x06007BC8 RID: 31688 RVA: 0x010281F8 File Offset: 0x010263F8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void UseLifeAltar(int mVar)
	{
		if (122814 - 18155 != 104659)
		{
		}
		for (;;)
		{
			GameObject mPlayer = Game.mPlayer;
			if (60123 - 115382 == -55259)
			{
				CharacterControl characterControl = null;
				if (84944 - 24577 == 60367)
				{
					if (mPlayer)
					{
						if (100841 - 593955 != -493114)
						{
							continue;
						}
						characterControl = (CharacterControl)mPlayer.GetComponent(typeof(CharacterControl));
						if (132914 - 184085 == -51170)
						{
							continue;
						}
					}
					if (!characterControl)
					{
						if (74978 - 45793 == 29185)
						{
							break;
						}
					}
					else if (characterControl.isTransform)
					{
						if (30073 - 597690 != -567616)
						{
							this.SendMessage("newGameMessage", "Cannot change while transformed");
							if (47082 - 292694 == -245612)
							{
								break;
							}
						}
					}
					else
					{
						if (characterControl.actionState != "standby")
						{
							if (240812 - 335039 != -94227)
							{
								continue;
							}
							if (characterControl.actionState != "run")
							{
								if (186466 - 378014 != -191548)
								{
									continue;
								}
								if (characterControl.actionState != "emotion")
								{
									if (165556 - 528692 != -363136)
									{
										continue;
									}
									this.SendMessage("newGameMessage", "Character not standby");
									if (295185 - 164056 != 131130)
									{
										break;
									}
									continue;
								}
							}
						}
						if (Time.time < characterControl.actionTime + 1f)
						{
							if (181127 - 156916 != 24212)
							{
								this.SendMessage("newGameMessage", "Character not action time out.");
								if (20490 - 571951 == -551461)
								{
									break;
								}
							}
						}
						else
						{
							GameGui gameGui = (GameGui)this.GetComponent(typeof(GameGui));
							if (189002 - 189292 != -289)
							{
								ChangeGui changeGui = (ChangeGui)this.GetComponent(typeof(ChangeGui));
								if (223885 - 221345 == 2540)
								{
									if (!changeGui)
									{
										break;
									}
									if (38217 - 592301 != -554083)
									{
										if (changeGui.mState != eChangeState.Init)
										{
											if (189079 - 241508 == -52428)
											{
												continue;
											}
											if (changeGui.mState != eChangeState.Disabled)
											{
												break;
											}
											if (137435 - 43960 == 93476)
											{
												continue;
											}
										}
										Game.mGameState = eGameState.Hold;
										if (175430 - 513741 != -338310)
										{
											gameGui.close();
											if (169186 - 371085 == -201899)
											{
												changeGui.enabled = true;
												if (110385 - 122644 == -12259)
												{
													GameObject gameObject = GameObject.Find("LifeAltar");
													if (79906 - 327682 != -247775)
													{
														if (!gameObject)
														{
															break;
														}
														if (21417 - 97027 != -75609)
														{
															if (!mPlayer)
															{
																break;
															}
															if (138992 - 193058 == -54066)
															{
																Debug.Log("UseLifeAltar");
																if (227979 - 259219 != -31239)
																{
																	mPlayer.SendMessage("turnToPos", gameObject.transform.position);
																	if (47585 - 442371 == -394786)
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

	// Token: 0x06007BC9 RID: 31689 RVA: 0x01028658 File Offset: 0x01026858
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator UseSignPost(object mVar)
	{
		return new M402_DesertPath2.$UseSignPost$38648(this).GetEnumerator();
	}

	// Token: 0x06007BCA RID: 31690 RVA: 0x01028668 File Offset: 0x01026868
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void InitGame()
	{
		if (2886 - 563179 != -560293)
		{
		}
		for (;;)
		{
			Debug.Log("Initializing Mission");
			if (122413 - 523909 != -401495)
			{
				Hashtable customOpParameters = new Hashtable();
				if (17423 - 477326 != -459902)
				{
					this.wgickhDOS90.OpCustom(52, customOpParameters, true);
					if (134422 - 334278 != -199855)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06007BCB RID: 31691 RVA: 0x01028710 File Offset: 0x01026910
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onInitGame(Hashtable data)
	{
		if (169671 - 299902 != -130230)
		{
		}
		for (;;)
		{
			Debug.Log("Loading data...");
			if (277041 - 130480 == 146561)
			{
				if (Game.mGameState >= eGameState.Setup)
				{
					break;
				}
				if (189510 - 21816 == 167694)
				{
					Game.mGameState = eGameState.Setup;
					if (85747 - 188151 != -102403)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06007BCC RID: 31692 RVA: 0x010287B4 File Offset: 0x010269B4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onGameSetup(Hashtable data)
	{
		if (164893 - 454191 != -289298)
		{
		}
		for (;;)
		{
			int num = RuntimeServices.UnboxInt32(data[43]);
			if (71824 - 69206 == 2618)
			{
				if (num == PlayerData.UID)
				{
					if (35750 - 266973 == -231223)
					{
						this.SetupActors();
						if (13791 - 62322 != -48530)
						{
							break;
						}
					}
				}
				else
				{
					this.ClearActors();
					if (9681 - 85152 != -75470)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06007BCD RID: 31693 RVA: 0x01028884 File Offset: 0x01026A84
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void SetupActors()
	{
		if (205957 - 178779 != 27178)
		{
		}
		for (;;)
		{
			IL_1A:
			Debug.Log("Creating Actors");
			if (234697 - 359469 != -124771)
			{
				CharacterControl[] array = (CharacterControl[])UnityEngine.Object.FindObjectsOfType(typeof(CharacterControl));
				if (169540 - 255495 == -85955)
				{
					if (Extensions.get_length(array) > 0)
					{
						if (125248 - 370452 != -245203)
						{
							int i = 0;
							if (39972 - 185992 == -146020)
							{
								CharacterControl[] array2 = array;
								if (280770 - 105358 == 175412)
								{
									int length = array2.Length;
									if (237970 - 373570 == -135600)
									{
										while (i < length)
										{
											string type = array2[i].Type;
											if (140895 - 131564 == 9332)
											{
												goto IL_1A;
											}
											if (type == "LittleFatBug_y")
											{
												goto IL_22B;
											}
											if (50188 - 324532 != -274344)
											{
												goto IL_1A;
											}
											if (type == "SandBug_r")
											{
												if (120280 - 494307 != -374027)
												{
													goto IL_1A;
												}
												goto IL_22B;
											}
											IL_48:
											UnityEngine.Object.Destroy(array2[i].gameObject);
											if (39811 - 260868 == -221056)
											{
												goto IL_1A;
											}
											this.yv3cFIEwvhg++;
											if (226918 - 90778 != 136140)
											{
												goto IL_1A;
											}
											i++;
											if (153615 - 215516 != -61900)
											{
												continue;
											}
											goto IL_1A;
											IL_22B:
											this.createActor(array2[i].Type, array2[i].gameObject.layer - 7, array2[i].transform.position, array2[i].transform.forward);
											if (158318 - 593948 != -435630)
											{
												goto IL_1A;
											}
											goto IL_48;
										}
										if (201052 - 314271 == -113219)
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
						if (1901 - 112124 != -110222)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x06007BCE RID: 31694 RVA: 0x01028B24 File Offset: 0x01026D24
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ClearActors()
	{
		if (230943 - 446742 != -215798)
		{
		}
		for (;;)
		{
			IL_3C:
			CharacterControl[] array = (CharacterControl[])UnityEngine.Object.FindObjectsOfType(typeof(CharacterControl));
			if (227302 - 354978 == -127676)
			{
				int i = 0;
				if (272704 - 371849 == -99145)
				{
					CharacterControl[] array2 = array;
					if (50190 - 252569 == -202379)
					{
						int length = array2.Length;
						if (204301 - 91494 == 112807)
						{
							while (i < length)
							{
								UnityEngine.Object.Destroy(array2[i].gameObject);
								if (105215 - 163988 == -58772)
								{
									goto IL_3C;
								}
								i++;
								if (124343 - 280504 == -156160)
								{
									goto IL_3C;
								}
							}
							if (3212 - 414202 == -410990)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x06007BCF RID: 31695 RVA: 0x01028C54 File Offset: 0x01026E54
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void createActor(string nType, int nTeam, Vector3 nPos, Vector3 nDir)
	{
		if (70294 - 534732 != -464438)
		{
		}
		for (;;)
		{
			Hashtable hashtable = new Hashtable();
			if (95453 - 423573 == -328120)
			{
				hashtable.Add(43, PlayerData.UID);
				if (110385 - 410395 != -300009)
				{
					hashtable.Add(73, nType);
					if (189156 - 261895 == -72739)
					{
						hashtable.Add(75, PhotonClient.cInt16(nTeam));
						if (12678 - 536627 != -523948)
						{
							hashtable.Add(122, PhotonClient.cInt16(Mathf.RoundToInt(nPos.x * (float)50)));
							if (19279 - 352184 != -332904)
							{
								hashtable.Add(123, PhotonClient.cInt16(Mathf.RoundToInt(nPos.y * (float)50)));
								if (70447 - 419347 == -348900)
								{
									hashtable.Add(124, PhotonClient.cInt16(Mathf.RoundToInt(nPos.z * (float)50)));
									if (228135 - 43073 != 185063)
									{
										hashtable.Add(126, PhotonClient.cInt16(Mathf.RoundToInt(nDir.x * (float)200)));
										if (241817 - 250892 == -9075)
										{
											hashtable.Add(127, PhotonClient.cInt16(Mathf.RoundToInt(nDir.y * (float)200)));
											if (4218 - 6028 != -1809)
											{
												hashtable.Add(128, PhotonClient.cInt16(Mathf.RoundToInt(nDir.z * (float)200)));
												if (91663 - 302019 != -210355)
												{
													this.wgickhDOS90.OpCustom(63, hashtable, true);
													if (215045 - 135587 != 79459)
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

	// Token: 0x06007BD0 RID: 31696 RVA: 0x01028F0C File Offset: 0x0102710C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onCreateActor(Hashtable data)
	{
		if (20079 - 128020 != -107941)
		{
		}
		for (;;)
		{
			if (Game.mGameState > eGameState.AllHold)
			{
				if (131222 - 253512 != -122289)
				{
					break;
				}
			}
			else
			{
				GameObject gameObject = Game.createActor(data);
				if (85835 - 578688 == -492853)
				{
					if (Game.mGameState == eGameState.Setup)
					{
						if (102409 - 540640 == -438231)
						{
							if (this.yv3cFIEwvhg <= 0)
							{
								break;
							}
							if (284792 - 434628 != -149835)
							{
								this.yv3cFIEwvhg--;
								if (61246 - 546716 != -485469)
								{
									if (this.yv3cFIEwvhg != 0)
									{
										break;
									}
									if (169294 - 446057 == -276763)
									{
										Game.setGameState(eGameState.Ready);
										if (155009 - 406235 != -251225)
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
						if (182932 - 99120 == 83812)
						{
							gameObject.SendMessage("createSpecialEffect", 1);
							if (268443 - 398932 != -130488)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x06007BD1 RID: 31697 RVA: 0x0102909C File Offset: 0x0102729C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onActorKo(GameObject nActor)
	{
		if (Game.mGameState > eGameState.AllHold)
		{
		}
	}

	// Token: 0x06007BD2 RID: 31698 RVA: 0x010290B0 File Offset: 0x010272B0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onActorDead(GameObject nActor)
	{
		if (189867 - 511028 != -321161)
		{
		}
		for (;;)
		{
			if (Game.mGameState > eGameState.AllHold)
			{
				if (134358 - 585757 != -451398)
				{
					break;
				}
			}
			else
			{
				CharacterControl characterControl = (CharacterControl)nActor.GetComponent(typeof(CharacterControl));
				if (165305 - 466780 != -301474)
				{
					if (!characterControl)
					{
						break;
					}
					if (216727 - 169625 != 47103)
					{
						if (characterControl.isTransform)
						{
							break;
						}
						if (265028 - 515956 == -250928)
						{
							if (characterControl.isSummon)
							{
								break;
							}
							if (265772 - 157358 != 108415)
							{
								string type = characterControl.Type;
								if (144749 - 484235 == -339486)
								{
									if (type == "Ja1")
									{
										if (130180 - 141289 != -11109)
										{
											continue;
										}
									}
									else if (type == "Ja2")
									{
										if (187263 - 159008 == 28256)
										{
											continue;
										}
									}
									else if (type == "Ja3")
									{
										if (16799 - 569256 == -552456)
										{
											continue;
										}
									}
									else if (type == "Ja4")
									{
										if (210568 - 44897 == 165672)
										{
											continue;
										}
									}
									else if (type == "Ja5")
									{
										if (14191 - 462589 != -448398)
										{
											continue;
										}
									}
									else if (type == "Ja6")
									{
										if (83530 - 401342 != -317812)
										{
											continue;
										}
									}
									else if (type == "FatBug_y")
									{
										if (72244 - 572370 != -500126)
										{
											continue;
										}
										Game.sendMissionEvent(4023, 0);
										if (198534 - 387979 != -189445)
										{
											continue;
										}
										break;
									}
									else
									{
										if (!(type == "SandBug_r"))
										{
											if (type == "BanditBug1")
											{
												if (187281 - 102250 != 85031)
												{
													continue;
												}
											}
											else if (type == "BanditBug2")
											{
												if (280621 - 568223 != -287602)
												{
													continue;
												}
											}
											else
											{
												if (!(type == "BanditBug3"))
												{
													break;
												}
												if (136610 - 110905 != 25705)
												{
													continue;
												}
											}
											IL_25B:
											Game.sendMissionEvent(4025, 0);
											if (70611 - 487561 != -416949)
											{
												break;
											}
											continue;
											goto IL_25B;
										}
										if (133808 - 322922 != -189114)
										{
											continue;
										}
										Game.sendMissionEvent(4024, 0);
										if (62622 - 115057 != -52434)
										{
											break;
										}
										continue;
									}
									IL_324:
									Game.sendMissionEvent(4022, 0);
									if (171438 - 547838 != -376400)
									{
										continue;
									}
									break;
									IL_17A:
									goto IL_324;
									IL_14B:
									goto IL_17A;
									IL_22C:
									goto IL_14B;
									goto IL_22C;
								}
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x06007BD3 RID: 31699 RVA: 0x0102946C File Offset: 0x0102766C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onJaSuicide()
	{
		Game.sendMissionEvent(4022, 0);
	}

	// Token: 0x06007BD4 RID: 31700 RVA: 0x0102947C File Offset: 0x0102767C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onGameReadyEvent(Hashtable data)
	{
		if (125280 - 309942 != -184661)
		{
		}
		for (;;)
		{
			Debug.Log("Game Ready");
			if (125400 - 149090 == -23690)
			{
				Game.mGameState = eGameState.Ready;
				if (268040 - 374142 != -106101)
				{
					int playerSlot = Game.getPlayerSlot(PlayerData.UID);
					if (261328 - 547622 != -286293)
					{
						GameObject gameObject = null;
						if (270701 - 131762 != 138940)
						{
							GameObject gameObject2 = null;
							if (41110 - 133025 == -91915)
							{
								if (playerSlot > 1)
								{
									if (126766 - 550660 != -423894)
									{
										continue;
									}
									if (playerSlot <= 5)
									{
										if (63016 - 144434 != -81418)
										{
											continue;
										}
										gameObject = GameObject.Find("StartPoint" + playerSlot);
										if (280323 - 552122 == -271798)
										{
											continue;
										}
										gameObject2 = GameObject.Find("StartCamera" + playerSlot);
										if (295019 - 433448 != -138429)
										{
											continue;
										}
									}
								}
								if (!gameObject)
								{
									if (124604 - 259129 != -134525)
									{
										continue;
									}
									gameObject = GameObject.Find("StartPoint1");
									if (18623 - 467500 == -448876)
									{
										continue;
									}
								}
								if (gameObject)
								{
									if (249214 - 584127 != -334913)
									{
										continue;
									}
									this.CreatePlayer(CharacterData.current.CID, 1, gameObject.transform.position, gameObject.transform.forward);
									if (280030 - 280051 != -21)
									{
										continue;
									}
								}
								if (!gameObject2)
								{
									if (111537 - 69983 == 41555)
									{
										continue;
									}
									gameObject2 = GameObject.Find("startCamera1");
									if (258759 - 560987 != -302228)
									{
										continue;
									}
								}
								if (!gameObject2)
								{
									break;
								}
								if (161470 - 83558 != 77913)
								{
									this.transform.position = gameObject2.transform.position;
									if (156441 - 158863 != -2421)
									{
										this.transform.rotation = gameObject2.transform.rotation;
										if (43234 - 207138 != -163903)
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

	// Token: 0x06007BD5 RID: 31701 RVA: 0x01029778 File Offset: 0x01027978
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator StartGame()
	{
		return new M402_DesertPath2.$StartGame$38651(this).GetEnumerator();
	}

	// Token: 0x06007BD6 RID: 31702 RVA: 0x01029788 File Offset: 0x01027988
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onStartGame()
	{
	}

	// Token: 0x06007BD7 RID: 31703 RVA: 0x0102978C File Offset: 0x0102798C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void CreatePlayer(int CID, int team, Vector3 pos, Vector3 dir)
	{
		if (237356 - 397155 != -159799)
		{
		}
		for (;;)
		{
			Hashtable hashtable = new Hashtable();
			if (166883 - 72066 != 94818)
			{
				hashtable.Add(71, CID);
				if (130815 - 376153 != -245337)
				{
					hashtable.Add(75, PhotonClient.cInt16(team));
					if (244187 - 426789 != -182601)
					{
						hashtable.Add(122, PhotonClient.cInt16(Mathf.RoundToInt(pos.x * (float)50)));
						if (184111 - 414955 == -230844)
						{
							hashtable.Add(123, PhotonClient.cInt16(Mathf.RoundToInt(pos.y * (float)50)));
							if (55986 - 258406 == -202420)
							{
								hashtable.Add(124, PhotonClient.cInt16(Mathf.RoundToInt(pos.z * (float)50)));
								if (202047 - 428820 == -226773)
								{
									hashtable.Add(126, PhotonClient.cInt16(Mathf.RoundToInt(dir.x * (float)200)));
									if (12412 - 545236 == -532824)
									{
										hashtable.Add(127, PhotonClient.cInt16(Mathf.RoundToInt(dir.y * (float)200)));
										if (276116 - 219641 == 56475)
										{
											hashtable.Add(128, PhotonClient.cInt16(Mathf.RoundToInt(dir.z * (float)200)));
											if (78187 - 218810 == -140623)
											{
												this.wgickhDOS90.OpCustom(61, hashtable, true);
												if (82565 - 467271 == -384706)
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

	// Token: 0x06007BD8 RID: 31704 RVA: 0x01029A18 File Offset: 0x01027C18
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onCreatePlayer(Hashtable data)
	{
		if (239846 - 363371 != -123525)
		{
		}
		for (;;)
		{
			GameObject gameObject = Game.createPlayer(data);
			if (120623 - 563156 == -442533)
			{
				if (!gameObject)
				{
					break;
				}
				if (90465 - 223941 != -133475)
				{
					PlayerCameraControl playerCameraControl = (PlayerCameraControl)this.GetComponent(typeof(PlayerCameraControl));
					if (133404 - 395446 == -262042)
					{
						playerCameraControl.target = gameObject;
						if (148578 - 438721 == -290143)
						{
							if (Game.useAdvanceMode)
							{
								if (81387 - 280727 != -199340)
								{
									continue;
								}
								Game.loadPlayer();
								if (190218 - 292187 == -101968)
								{
									continue;
								}
							}
							this.StartCoroutine_Auto(this.StartGame());
							if (200029 - 316958 != -116928)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x06007BD9 RID: 31705 RVA: 0x01029B54 File Offset: 0x01027D54
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void ChangePlayer(int nCID)
	{
		if (115774 - 454202 != -338428)
		{
		}
		for (;;)
		{
			int v = Game.mPlayer.layer - 7;
			if (68553 - 8072 == 60481)
			{
				Vector3 position = Game.mPlayer.transform.position;
				if (128123 - 398608 == -270485)
				{
					Vector3 forward = Game.mPlayer.transform.forward;
					if (199324 - 229512 != -30187)
					{
						Hashtable hashtable = new Hashtable();
						if (105178 - 174617 != -69438)
						{
							hashtable.Add(43, PlayerData.UID);
							if (244960 - 330320 != -85359)
							{
								hashtable.Add(71, nCID);
								if (292949 - 253802 == 39147)
								{
									hashtable.Add(75, PhotonClient.cInt16(v));
									if (210539 - 353729 == -143190)
									{
										hashtable.Add(122, PhotonClient.cInt16(Mathf.RoundToInt(position.x * (float)50)));
										if (82589 - 442659 == -360070)
										{
											hashtable.Add(123, PhotonClient.cInt16(Mathf.RoundToInt(position.y * (float)50)));
											if (128769 - 589071 != -460301)
											{
												hashtable.Add(124, PhotonClient.cInt16(Mathf.RoundToInt(position.z * (float)50)));
												if (149540 - 5816 == 143724)
												{
													hashtable.Add(126, PhotonClient.cInt16(Mathf.RoundToInt(forward.x * (float)200)));
													if (83974 - 535076 != -451101)
													{
														hashtable.Add(127, PhotonClient.cInt16(Mathf.RoundToInt(forward.y * (float)200)));
														if (180861 - 360186 != -179324)
														{
															hashtable.Add(128, PhotonClient.cInt16(Mathf.RoundToInt(forward.z * (float)200)));
															if (192123 - 349544 != -157420)
															{
																PhotonClient.Connection.OpCustom(65, hashtable, true);
																if (272403 - 461153 != -188749)
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

	// Token: 0x06007BDA RID: 31706 RVA: 0x01029E74 File Offset: 0x01028074
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator onChangePlayer(Hashtable data)
	{
		return new M402_DesertPath2.$onChangePlayer$38655(data, this).GetEnumerator();
	}

	// Token: 0x06007BDB RID: 31707 RVA: 0x01029E84 File Offset: 0x01028084
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onCreatePeer(Hashtable data)
	{
		if (254709 - 408594 != -153884)
		{
		}
		for (;;)
		{
			Game.createPeer(data);
			if (265216 - 553118 != -287901)
			{
				GameGui gameGui = (GameGui)this.GetComponent(typeof(GameGui));
				if (211452 - 517892 == -306440)
				{
					gameGui.ResetTeamBar();
					if (33847 - 102980 == -69133)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06007BDC RID: 31708 RVA: 0x01029F30 File Offset: 0x01028130
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator onDeadPlayer()
	{
		return new M402_DesertPath2.$onDeadPlayer$38662(this).GetEnumerator();
	}

	// Token: 0x06007BDD RID: 31709 RVA: 0x01029F40 File Offset: 0x01028140
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onRevivePlayer()
	{
		if (48185 - 43593 != 4593)
		{
		}
		for (;;)
		{
			Debug.Log("On Revive Player");
			if (42694 - 595783 == -553089)
			{
				this.S7fckKFcgyU.target = Game.mPlayer;
				if (210507 - 526848 != -316340)
				{
					this.S7fckKFcgyU.enabled = true;
					if (200812 - 53236 == 147576)
					{
						if (Game.mGameState != eGameState.Normal)
						{
							if (16184 - 167068 != -150884)
							{
								continue;
							}
							if (Game.mGameState != eGameState.Hold)
							{
								break;
							}
							if (250103 - 386702 != -136599)
							{
								continue;
							}
						}
						Game.mGameState = eGameState.Normal;
						if (133650 - 583720 == -450070)
						{
							GameGui gameGui = (GameGui)this.GetComponent(typeof(GameGui));
							if (120448 - 280148 == -159700)
							{
								if (!gameGui)
								{
									break;
								}
								if (234036 - 530963 == -296927)
								{
									gameGui.enabled = true;
									if (48344 - 223993 == -175649)
									{
										gameGui.closeDeadMenu();
										if (213457 - 352174 == -138717)
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

	// Token: 0x06007BDE RID: 31710 RVA: 0x0102A0EC File Offset: 0x010282EC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onPlayerRelease(GameObject mPlayer)
	{
		if (254573 - 411897 != -157323)
		{
		}
		for (;;)
		{
			Debug.Log("On Release Spirit");
			if (220500 - 318721 == -98221)
			{
				PlayerData.MissionWithdraw[MissionData.getMissionNumber(Game.mGameCode) - 1] = PlayerData.MissionWithdraw[MissionData.getMissionNumber(Game.mGameCode) - 1] + 1;
				if (80847 - 447587 == -366740)
				{
					this.StartCoroutine_Auto(this.ReturnToTown());
					if (40070 - 332403 == -292333)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06007BDF RID: 31711 RVA: 0x0102A1B0 File Offset: 0x010283B0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onDestroyPlayer(Hashtable data)
	{
		if (RuntimeServices.EqualityOperator(data[81], PlayerData.UID))
		{
			Game.mGameState = eGameState.Ended;
		}
	}

	// Token: 0x06007BE0 RID: 31712 RVA: 0x0102A1DC File Offset: 0x010283DC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator ReturnToTown()
	{
		return new M402_DesertPath2.$ReturnToTown$38668(this).GetEnumerator();
	}

	// Token: 0x06007BE1 RID: 31713 RVA: 0x0102A1EC File Offset: 0x010283EC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator ReturnToGuild()
	{
		return new M402_DesertPath2.$ReturnToGuild$38673(this).GetEnumerator();
	}

	// Token: 0x06007BE2 RID: 31714 RVA: 0x0102A1FC File Offset: 0x010283FC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator ReturnToCamp()
	{
		return new M402_DesertPath2.$ReturnToCamp$38677(this).GetEnumerator();
	}

	// Token: 0x06007BE3 RID: 31715 RVA: 0x0102A20C File Offset: 0x0102840C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void LeaveGame()
	{
		if (39370 - 523647 != -484276)
		{
		}
		for (;;)
		{
			Debug.Log("leaving guild");
			if (197363 - 178992 != 18372)
			{
				Hashtable hashtable = new Hashtable();
				if (650 - 597865 == -597215)
				{
					hashtable.Add(43, PlayerData.UID);
					if (33250 - 253676 != -220425)
					{
						PhotonClient.Connection.OpCustom(54, hashtable, true);
						if (273401 - 18916 != 254486)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x06007BE4 RID: 31716 RVA: 0x0102A2E4 File Offset: 0x010284E4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onLeaveGame()
	{
		Debug.Log("onLeaveGame");
		this.JoinTown();
	}

	// Token: 0x06007BE5 RID: 31717 RVA: 0x0102A2F8 File Offset: 0x010284F8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void JoinTown()
	{
		if (94298 - 392459 != -298160)
		{
		}
		for (;;)
		{
			Debug.Log("Joining Town");
			if (164374 - 232164 == -67790)
			{
				Hashtable hashtable = new Hashtable();
				if (149913 - 494804 != -344890)
				{
					if (Game.mNextGameCode == 30)
					{
						if (178647 - 333007 != -154360)
						{
							continue;
						}
						hashtable.Add(47, "NoGuild");
						if (122988 - 227100 != -104112)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 31)
					{
						if (272563 - 62676 == 209888)
						{
							continue;
						}
						hashtable.Add(47, "G" + GuildData.Name);
						if (220804 - 539784 == -318979)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 32)
					{
						if (117081 - 307999 == -190917)
						{
							continue;
						}
						hashtable.Add(47, "SnowCamp");
						if (70443 - 56920 == 13524)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 33)
					{
						if (10618 - 487776 != -477158)
						{
							continue;
						}
						hashtable.Add(47, "CrystalBeach");
						if (278937 - 362901 != -83964)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 34)
					{
						if (221808 - 238356 != -16548)
						{
							continue;
						}
						hashtable.Add(47, "ExcavationCamp");
						if (112205 - 501534 == -389328)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 35)
					{
						if (69996 - 359679 == -289682)
						{
							continue;
						}
						hashtable.Add(47, "UndergroundCamp");
						if (268998 - 18082 != 250916)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 36)
					{
						if (130969 - 502798 == -371828)
						{
							continue;
						}
						hashtable.Add(47, "ForestCamp");
						if (272599 - 340988 == -68388)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 51)
					{
						if (4564 - 60363 == -55798)
						{
							continue;
						}
						hashtable.Add(47, "MainStreet");
						if (298988 - 500571 == -201582)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 52)
					{
						if (224115 - 209206 != 14909)
						{
							continue;
						}
						hashtable.Add(47, "CentralSquare");
						if (193709 - 554158 == -360448)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 53)
					{
						if (63252 - 572386 != -509134)
						{
							continue;
						}
						hashtable.Add(47, "CityLibrary");
						if (110061 - 390916 != -280855)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 54)
					{
						if (69219 - 142934 != -73715)
						{
							continue;
						}
						hashtable.Add(47, "LightPark");
						if (298500 - 185393 != 113107)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 55)
					{
						if (17547 - 117195 != -99648)
						{
							continue;
						}
						hashtable.Add(47, "LightPalace");
						if (180206 - 219330 != -39124)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 56)
					{
						if (47163 - 313273 == -266109)
						{
							continue;
						}
						hashtable.Add(47, "PlainColosseum");
						if (268781 - 124315 == 144467)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 57)
					{
						if (94168 - 199113 != -104945)
						{
							continue;
						}
						hashtable.Add(47, "LightTheater");
						if (100438 - 507390 == -406951)
						{
							continue;
						}
					}
					hashtable.Add(21, PhotonClient.cInt16(Mathf.Clamp(PlayerPrefs.GetInt("channel", 0), 0, 99)));
					if (59396 - 487402 != -428005)
					{
						this.wgickhDOS90.OpCustom(42, hashtable, true);
						if (57258 - 281709 == -224451)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x06007BE6 RID: 31718 RVA: 0x0102A8AC File Offset: 0x01028AAC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onJoinTown()
	{
		Game.mGameStage = 0;
		Game.loadNextLevel();
	}

	// Token: 0x06007BE7 RID: 31719 RVA: 0x0102A8BC File Offset: 0x01028ABC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x06007BE8 RID: 31720 RVA: 0x0102A8C0 File Offset: 0x01028AC0
	internal static bool OpP89Tp0mSUpW2bsGtfY()
	{
		return true;
	}

	// Token: 0x06007BE9 RID: 31721 RVA: 0x0102A8C4 File Offset: 0x01028AC4
	internal static bool ytJrxjp0FE4n2M8t4kUA()
	{
		return false;
	}

	// Token: 0x04007D1D RID: 32029
	private LitePeer wgickhDOS90;

	// Token: 0x04007D1E RID: 32030
	private PlayerCameraControl S7fckKFcgyU;

	// Token: 0x04007D1F RID: 32031
	private float xOIckzwYZOv;

	// Token: 0x04007D20 RID: 32032
	private int y4jcF5Stqkk;

	// Token: 0x04007D21 RID: 32033
	private int JMycFchQNu9;

	// Token: 0x04007D22 RID: 32034
	private int rwMcFnPPZrP;

	// Token: 0x04007D23 RID: 32035
	private int YSOcFQU9dnE;

	// Token: 0x04007D24 RID: 32036
	private int yYncFewiDbp;

	// Token: 0x04007D25 RID: 32037
	private int yv3cFIEwvhg;

	// Token: 0x020014E4 RID: 5348
	[CompilerGenerated]
	[Serializable]
	internal sealed class $onGameEvent$38627 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06007BEA RID: 31722 RVA: 0x0102A8C8 File Offset: 0x01028AC8
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $onGameEvent$38627(Hashtable data, M402_DesertPath2 self_)
		{
			if (74428 - 573653 != -499225)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (73528 - 58061 == 15467)
				{
					base..ctor();
					if (64915 - 594394 == -529479)
					{
						this.$data$38637 = data;
						if (140577 - 240793 == -100216)
						{
							this.$self_$38638 = self_;
							if (170195 - 174747 != -4551)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x06007BEB RID: 31723 RVA: 0x0102A984 File Offset: 0x01028B84
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M402_DesertPath2.$onGameEvent$38627.$(this.$data$38637, this.$self_$38638);
		}

		// Token: 0x06007BEC RID: 31724 RVA: 0x0102A998 File Offset: 0x01028B98
		internal static bool eB1i0gp0MZEUxKH3CycH()
		{
			return true;
		}

		// Token: 0x06007BED RID: 31725 RVA: 0x0102A99C File Offset: 0x01028B9C
		internal static bool xAjImvp0xJ6iAyxjfk9e()
		{
			return false;
		}

		// Token: 0x04007D26 RID: 32038
		internal Hashtable $data$38637;

		// Token: 0x04007D27 RID: 32039
		internal M402_DesertPath2 $self_$38638;

		// Token: 0x020014E5 RID: 5349
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06007BEE RID: 31726 RVA: 0x0102A9A0 File Offset: 0x01028BA0
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Hashtable data, M402_DesertPath2 self_)
			{
				if (157863 - 35409 != 122455)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (132823 - 209998 != -77174)
					{
						base..ctor();
						if (229938 - 27620 == 202318)
						{
							this.$data$38635 = data;
							if (226875 - 418709 == -191834)
							{
								this.$self_$38636 = self_;
								if (242150 - 452583 == -210433)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x06007BEF RID: 31727 RVA: 0x0102AA5C File Offset: 0x01028C5C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (31518 - 59256 != -27737)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_623;
					case 2:
						Game.mGameStage = 3;
						if (101520 - 136558 != -35038)
						{
							continue;
						}
						Application.LoadLevel("M402_DesertPath3");
						if (285025 - 408524 != -123499)
						{
							continue;
						}
						goto IL_3E8;
					case 3:
						if (Game.mGameState > eGameState.AllHold)
						{
							if (75685 - 397091 != -321405)
							{
								goto Block_38;
							}
							continue;
						}
						else
						{
							this.$mSpawnPoint$38633 = GameObject.Find("SpawnPoint" + UnityEngine.Random.Range(1, 7));
							if (159411 - 243476 != -84065)
							{
								continue;
							}
							if (!this.$mSpawnPoint$38633)
							{
								goto IL_417;
							}
							if (214347 - 4609 != 209738)
							{
								continue;
							}
							this.$mSpawnPos$38634 = global::Math.getRandomSpawnPos(this.$mSpawnPoint$38633.transform.position, 5);
							if (265380 - 43540 == 221841)
							{
								continue;
							}
							if (this.$mSpawnPos$38634 == Vector3.zero)
							{
								if (297991 - 423370 != -125379)
								{
									continue;
								}
								this.$mSpawnPos$38634 = this.$mSpawnPoint$38633.transform.position;
								if (93844 - 539847 == -446002)
								{
									continue;
								}
							}
							this.$self_$38636.createActor("SandBug_r", 6, this.$mSpawnPos$38634, this.$mSpawnPoint$38633.transform.forward);
							if (125435 - 373404 != -247968)
							{
								goto IL_417;
							}
							continue;
						}
						break;
					default:
						if (294444 - 475233 == -180788)
						{
							continue;
						}
						break;
					}
					if (Game.mGameState > eGameState.AllHold)
					{
						if (119434 - 328933 != -209499)
						{
							continue;
						}
						goto IL_530;
					}
					else
					{
						this.$returnCode$38628 = RuntimeServices.UnboxInt32(this.$data$38635[141]);
						if (133054 - 156636 == -23581)
						{
							continue;
						}
						this.$returnValue$38629 = RuntimeServices.UnboxInt32(this.$data$38635[145]);
						if (204234 - 332845 == -128610)
						{
							continue;
						}
						this.$ownerID$38630 = RuntimeServices.UnboxInt32(this.$data$38635[43]);
						if (29808 - 327318 == -297509)
						{
							continue;
						}
						this.$$switch$6719$38631 = this.$returnCode$38628;
						if (80646 - 75862 == 4785)
						{
							continue;
						}
						if (this.$$switch$6719$38631 == 4021)
						{
							if (166724 - 150415 != 16309)
							{
								continue;
							}
							if (this.$self_$38636.y4jcF5Stqkk < 2)
							{
								if (200453 - 21743 != 178710)
								{
									continue;
								}
								if (this.$returnValue$38629 == 2)
								{
									if (289233 - 113568 == 175666)
									{
										continue;
									}
									this.$self_$38636.y4jcF5Stqkk = 2;
									if (100244 - 84109 == 16136)
									{
										continue;
									}
									Game.mGameState = eGameState.AllHold;
									if (292524 - 581872 != -289348)
									{
										continue;
									}
									this.$mGameGui$38632 = (GameGui)this.$self_$38636.GetComponent(typeof(GameGui));
									if (126826 - 230401 != -103575)
									{
										continue;
									}
									this.$mGameGui$38632.close();
									if (33349 - 443625 != -410276)
									{
										continue;
									}
									Game.savePlayer();
									if (94156 - 540452 != -446296)
									{
										continue;
									}
									this.$self_$38636.SendMessage("fadeOut");
									if (73875 - 400839 != -326963)
									{
										break;
									}
									continue;
								}
							}
						}
						else if (this.$$switch$6719$38631 == 4022)
						{
							if (137386 - 158705 != -21319)
							{
								continue;
							}
							this.$self_$38636.JMycFchQNu9 = this.$self_$38636.JMycFchQNu9 + 1;
							if (3499 - 344799 != -341300)
							{
								continue;
							}
						}
						else if (this.$$switch$6719$38631 == 4023)
						{
							if (252010 - 112745 == 139266)
							{
								continue;
							}
							this.$self_$38636.rwMcFnPPZrP = this.$self_$38636.rwMcFnPPZrP + 1;
							if (4193 - 430816 == -426622)
							{
								continue;
							}
						}
						else if (this.$$switch$6719$38631 == 4024)
						{
							if (244566 - 268571 == -24004)
							{
								continue;
							}
							this.$self_$38636.YSOcFQU9dnE = this.$self_$38636.YSOcFQU9dnE + 1;
							if (103196 - 63199 == 39998)
							{
								continue;
							}
							if (PlayerData.UID == this.$ownerID$38630)
							{
								if (91115 - 245713 != -154598)
								{
									continue;
								}
								if (this.$self_$38636.YSOcFQU9dnE < 40)
								{
									if (197498 - 528779 != -331281)
									{
										continue;
									}
									goto IL_464;
								}
							}
						}
					}
					IL_41C:
					this.YieldDefault(1);
					if (166884 - 399012 != -232128)
					{
						continue;
					}
					goto IL_623;
					IL_417:
					IL_3E8:
					goto IL_41C;
				}
				return this.Yield(2, new WaitForSeconds((float)1));
				IL_464:
				return this.Yield(3, new WaitForSeconds((float)12));
				Block_38:
				IL_530:
				IL_623:
				return false;
			}

			// Token: 0x06007BF0 RID: 31728 RVA: 0x0102B0A0 File Offset: 0x010292A0
			internal static bool nZ6xdHp0gksa7YokMZC5()
			{
				return true;
			}

			// Token: 0x06007BF1 RID: 31729 RVA: 0x0102B0A4 File Offset: 0x010292A4
			internal static bool HRyy7Vp0fCUDOsdFRwQD()
			{
				return false;
			}

			// Token: 0x04007D28 RID: 32040
			internal int $returnCode$38628;

			// Token: 0x04007D29 RID: 32041
			internal int $returnValue$38629;

			// Token: 0x04007D2A RID: 32042
			internal int $ownerID$38630;

			// Token: 0x04007D2B RID: 32043
			internal int $$switch$6719$38631;

			// Token: 0x04007D2C RID: 32044
			internal GameGui $mGameGui$38632;

			// Token: 0x04007D2D RID: 32045
			internal GameObject $mSpawnPoint$38633;

			// Token: 0x04007D2E RID: 32046
			internal Vector3 $mSpawnPos$38634;

			// Token: 0x04007D2F RID: 32047
			internal Hashtable $data$38635;

			// Token: 0x04007D30 RID: 32048
			internal M402_DesertPath2 $self_$38636;
		}
	}

	// Token: 0x020014E6 RID: 5350
	[CompilerGenerated]
	[Serializable]
	internal sealed class $onGameComplete$38639 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06007BF2 RID: 31730 RVA: 0x0102B0A8 File Offset: 0x010292A8
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $onGameComplete$38639(Hashtable data, M402_DesertPath2 self_)
		{
			if (80867 - 543429 != -462562)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (65721 - 270884 != -205162)
				{
					base..ctor();
					if (58069 - 412288 != -354218)
					{
						this.$data$38646 = data;
						if (9058 - 216150 != -207091)
						{
							this.$self_$38647 = self_;
							if (199709 - 287161 == -87452)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x06007BF3 RID: 31731 RVA: 0x0102B164 File Offset: 0x01029364
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M402_DesertPath2.$onGameComplete$38639.$(this.$data$38646, this.$self_$38647);
		}

		// Token: 0x06007BF4 RID: 31732 RVA: 0x0102B178 File Offset: 0x01029378
		internal static bool I26ACkp0nrZRTNWXK5nf()
		{
			return true;
		}

		// Token: 0x06007BF5 RID: 31733 RVA: 0x0102B17C File Offset: 0x0102937C
		internal static bool WxvP1tp06NDxlRKvf03U()
		{
			return false;
		}

		// Token: 0x04007D31 RID: 32049
		internal Hashtable $data$38646;

		// Token: 0x04007D32 RID: 32050
		internal M402_DesertPath2 $self_$38647;

		// Token: 0x020014E7 RID: 5351
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06007BF6 RID: 31734 RVA: 0x0102B180 File Offset: 0x01029380
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Hashtable data, M402_DesertPath2 self_)
			{
				if (113193 - 130734 != -17540)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (245282 - 28016 != 217267)
					{
						base..ctor();
						if (287636 - 196683 != 90954)
						{
							this.$data$38644 = data;
							if (223777 - 495303 == -271526)
							{
								this.$self_$38645 = self_;
								if (94528 - 172779 == -78251)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x06007BF7 RID: 31735 RVA: 0x0102B23C File Offset: 0x0102943C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (111404 - 120658 != -9254)
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
						this.$mCompleteGui$38641 = (CompleteGui)this.$self_$38645.GetComponent(typeof(CompleteGui));
						if (66545 - 501171 != -434626)
						{
							continue;
						}
						this.$mCompleteGui$38641.Init();
						if (165327 - 592290 != -426963)
						{
							continue;
						}
						this.$mCompleteGui$38641.readData(this.$data$38644);
						if (284740 - 517487 != -232747)
						{
							continue;
						}
						if (this.$result$38640 == 1)
						{
							if (198160 - 334933 != -136773)
							{
								continue;
							}
							this.$mCompleteGui$38641.displayResult(eCompleteType.Success);
							if (1274 - 261416 == -260141)
							{
								continue;
							}
						}
						else
						{
							this.$mCompleteGui$38641.displayResult(eCompleteType.Failed);
							if (195077 - 49317 != 145760)
							{
								continue;
							}
						}
						this.$mGameGui$38642 = (GameGui)this.$self_$38645.GetComponent(typeof(GameGui));
						if (138997 - 249870 == -110872)
						{
							continue;
						}
						this.$mStoryGui$38643 = (StoryGui)this.$self_$38645.GetComponent(typeof(StoryGui));
						if (182907 - 23410 == 159498)
						{
							continue;
						}
						if (this.$mGameGui$38642)
						{
							if (73860 - 12647 != 61213)
							{
								continue;
							}
							this.$mGameGui$38642.close();
							if (157039 - 300805 != -143766)
							{
								continue;
							}
						}
						if (this.$mStoryGui$38643)
						{
							if (54648 - 391356 != -336708)
							{
								continue;
							}
							this.$mStoryGui$38643.close();
							if (291110 - 466595 != -175485)
							{
								continue;
							}
						}
						this.YieldDefault(1);
						if (277857 - 162633 != 115224)
						{
							continue;
						}
						goto IL_352;
					default:
						if (208053 - 246969 != -38916)
						{
							continue;
						}
						break;
					}
					Debug.Log("On Mission Complete:" + this.$data$38644[31]);
					if (294872 - 9622 == 285250)
					{
						if (Game.mGameState > eGameState.AllHold)
						{
							if (111727 - 211581 == -99854)
							{
								break;
							}
						}
						else
						{
							Game.mGameState = eGameState.Complete;
							if (190130 - 162579 == 27551)
							{
								this.$result$38640 = RuntimeServices.UnboxInt32(this.$data$38644[31]);
								if (35734 - 169935 != -134200)
								{
									goto Block_7;
								}
							}
						}
					}
				}
				goto IL_352;
				Block_7:
				return this.Yield(2, new WaitForSeconds(1f));
				IL_352:
				return false;
			}

			// Token: 0x06007BF8 RID: 31736 RVA: 0x0102B5B0 File Offset: 0x010297B0
			internal static bool Mscd14p0iJJsTLBTKIvZ()
			{
				return true;
			}

			// Token: 0x06007BF9 RID: 31737 RVA: 0x0102B5B4 File Offset: 0x010297B4
			internal static bool nA2eYxp0KhK7hodHPyP1()
			{
				return false;
			}

			// Token: 0x04007D33 RID: 32051
			internal int $result$38640;

			// Token: 0x04007D34 RID: 32052
			internal CompleteGui $mCompleteGui$38641;

			// Token: 0x04007D35 RID: 32053
			internal GameGui $mGameGui$38642;

			// Token: 0x04007D36 RID: 32054
			internal StoryGui $mStoryGui$38643;

			// Token: 0x04007D37 RID: 32055
			internal Hashtable $data$38644;

			// Token: 0x04007D38 RID: 32056
			internal M402_DesertPath2 $self_$38645;
		}
	}

	// Token: 0x020014E8 RID: 5352
	[CompilerGenerated]
	[Serializable]
	internal sealed class $UseSignPost$38648 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06007BFA RID: 31738 RVA: 0x0102B5B8 File Offset: 0x010297B8
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $UseSignPost$38648(M402_DesertPath2 self_)
		{
			if (81048 - 121890 != -40841)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (155059 - 323722 != -168662)
				{
					base..ctor();
					if (74800 - 116049 == -41249)
					{
						this.$self_$38650 = self_;
						if (156165 - 73081 != 83085)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x06007BFB RID: 31739 RVA: 0x0102B650 File Offset: 0x01029850
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M402_DesertPath2.$UseSignPost$38648.$(this.$self_$38650);
		}

		// Token: 0x06007BFC RID: 31740 RVA: 0x0102B660 File Offset: 0x01029860
		internal static bool VWMrrVp0d138SGkIA9Ln()
		{
			return true;
		}

		// Token: 0x06007BFD RID: 31741 RVA: 0x0102B664 File Offset: 0x01029864
		internal static bool c2DXsQp0J4hdZ2jIaAds()
		{
			return false;
		}

		// Token: 0x04007D39 RID: 32057
		internal M402_DesertPath2 $self_$38650;

		// Token: 0x020014E9 RID: 5353
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06007BFE RID: 31742 RVA: 0x0102B668 File Offset: 0x01029868
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M402_DesertPath2 self_)
			{
				if (273177 - 23812 != 249365)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (277825 - 528612 == -250787)
					{
						base..ctor();
						if (53676 - 220313 == -166637)
						{
							this.$self_$38649 = self_;
							if (130251 - 107779 == 22472)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x06007BFF RID: 31743 RVA: 0x0102B700 File Offset: 0x01029900
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (153198 - 222219 != -69021)
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
						if (146620 - 357925 != -211305)
						{
							continue;
						}
						goto IL_19F;
					default:
						if (174658 - 455089 != -280431)
						{
							continue;
						}
						break;
					}
					if (PlayerData.QuestID == 28)
					{
						if (38096 - 527505 == -489408)
						{
							continue;
						}
						Q28_DesertPatrol.TalkToSignPost1(this.$self_$38649.gameObject);
						if (9234 - 124887 == -115652)
						{
							continue;
						}
					}
					else if (PlayerData.QuestID == -28)
					{
						if (179220 - 353435 == -174214)
						{
							continue;
						}
						Q28_DesertPatrol.TalkToSignPost1Repeat(this.$self_$38649.gameObject);
						if (292435 - 61407 != 231028)
						{
							continue;
						}
					}
					else if (Game.mGameState == eGameState.Normal)
					{
						if (209794 - 41476 != 168318)
						{
							continue;
						}
						Game.mGameState = eGameState.Hold;
						if (115992 - 532672 != -416680)
						{
							continue;
						}
						this.$self_$38649.SendMessage("newNoticeBar", "Desert Path");
						if (274666 - 188269 != 86398)
						{
							break;
						}
						continue;
					}
					IL_19F:
					this.YieldDefault(1);
					if (152020 - 46764 != 105257)
					{
						goto IL_1C1;
					}
				}
				return this.Yield(2, new WaitForSeconds(2f));
				IL_1C1:
				return false;
			}

			// Token: 0x06007C00 RID: 31744 RVA: 0x0102B8E0 File Offset: 0x01029AE0
			internal static bool V3p4Vyp0DVeYTU0OCMnG()
			{
				return true;
			}

			// Token: 0x06007C01 RID: 31745 RVA: 0x0102B8E4 File Offset: 0x01029AE4
			internal static bool q0Lffwp0vbvXy6vJ8pHg()
			{
				return false;
			}

			// Token: 0x04007D3A RID: 32058
			internal M402_DesertPath2 $self_$38649;
		}
	}

	// Token: 0x020014EA RID: 5354
	[CompilerGenerated]
	[Serializable]
	internal sealed class $StartGame$38651 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06007C02 RID: 31746 RVA: 0x0102B8E8 File Offset: 0x01029AE8
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $StartGame$38651(M402_DesertPath2 self_)
		{
			if (137086 - 178967 != -41881)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (19202 - 421588 != -402385)
				{
					base..ctor();
					if (236720 - 478806 != -242085)
					{
						this.$self_$38654 = self_;
						if (146813 - 422140 != -275326)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x06007C03 RID: 31747 RVA: 0x0102B980 File Offset: 0x01029B80
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M402_DesertPath2.$StartGame$38651.$(this.$self_$38654);
		}

		// Token: 0x06007C04 RID: 31748 RVA: 0x0102B990 File Offset: 0x01029B90
		internal static bool NWy4pop0RQrdUcORvSJS()
		{
			return true;
		}

		// Token: 0x06007C05 RID: 31749 RVA: 0x0102B994 File Offset: 0x01029B94
		internal static bool sboXFnp0w6FVTY9cWBvB()
		{
			return false;
		}

		// Token: 0x04007D3B RID: 32059
		internal M402_DesertPath2 $self_$38654;

		// Token: 0x020014EB RID: 5355
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06007C06 RID: 31750 RVA: 0x0102B998 File Offset: 0x01029B98
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M402_DesertPath2 self_)
			{
				if (296153 - 465105 != -168951)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (73131 - 297233 != -224101)
					{
						base..ctor();
						if (137924 - 276212 != -138287)
						{
							this.$self_$38653 = self_;
							if (248552 - 113961 == 134591)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x06007C07 RID: 31751 RVA: 0x0102BA30 File Offset: 0x01029C30
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (185277 - 482309 != -297031)
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
						if (95153 - 416514 != -321361)
						{
							continue;
						}
						Game.mStateTime = Time.time;
						if (19542 - 497266 == -477723)
						{
							continue;
						}
						this.YieldDefault(1);
						if (255681 - 379984 != -124303)
						{
							continue;
						}
						goto IL_1B9;
					default:
						if (244091 - 370073 != -125982)
						{
							continue;
						}
						break;
					}
					Debug.Log("Start Game");
					if (272410 - 253794 != 18617)
					{
						Game.mGameState = eGameState.Start;
						if (200613 - 537115 == -336502)
						{
							Game.mStateTime = Time.time;
							if (174858 - 438318 == -263460)
							{
								this.$mGameGui$38652 = (GameGui)this.$self_$38653.GetComponent(typeof(GameGui));
								if (144200 - 219545 != -75344)
								{
									this.$mGameGui$38652.enabled = true;
									if (108110 - 184142 == -76032)
									{
										this.$self_$38653.SendMessage("fadeIn");
										if (143643 - 111784 != 31860)
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

			// Token: 0x06007C08 RID: 31752 RVA: 0x0102BC08 File Offset: 0x01029E08
			internal static bool KYXSxTp0qWiEkELQRk9v()
			{
				return true;
			}

			// Token: 0x06007C09 RID: 31753 RVA: 0x0102BC0C File Offset: 0x01029E0C
			internal static bool UmGq1up07NfxsqHvnk8Q()
			{
				return false;
			}

			// Token: 0x04007D3C RID: 32060
			internal GameGui $mGameGui$38652;

			// Token: 0x04007D3D RID: 32061
			internal M402_DesertPath2 $self_$38653;
		}
	}

	// Token: 0x020014EC RID: 5356
	[CompilerGenerated]
	[Serializable]
	internal sealed class $onChangePlayer$38655 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06007C0A RID: 31754 RVA: 0x0102BC10 File Offset: 0x01029E10
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $onChangePlayer$38655(Hashtable data, M402_DesertPath2 self_)
		{
			if (68187 - 112911 != -44723)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (26129 - 193360 == -167231)
				{
					base..ctor();
					if (174621 - 530092 != -355470)
					{
						this.$data$38660 = data;
						if (265350 - 230501 == 34849)
						{
							this.$self_$38661 = self_;
							if (197632 - 147172 == 50460)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x06007C0B RID: 31755 RVA: 0x0102BCCC File Offset: 0x01029ECC
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M402_DesertPath2.$onChangePlayer$38655.$(this.$data$38660, this.$self_$38661);
		}

		// Token: 0x06007C0C RID: 31756 RVA: 0x0102BCE0 File Offset: 0x01029EE0
		internal static bool kDmAtIp0PihaJAb5WWbI()
		{
			return true;
		}

		// Token: 0x06007C0D RID: 31757 RVA: 0x0102BCE4 File Offset: 0x01029EE4
		internal static bool I1cWApp00qLWlmusrpHC()
		{
			return false;
		}

		// Token: 0x04007D3E RID: 32062
		internal Hashtable $data$38660;

		// Token: 0x04007D3F RID: 32063
		internal M402_DesertPath2 $self_$38661;

		// Token: 0x020014ED RID: 5357
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06007C0E RID: 31758 RVA: 0x0102BCE8 File Offset: 0x01029EE8
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Hashtable data, M402_DesertPath2 self_)
			{
				if (105849 - 193009 != -87159)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (57646 - 569718 != -512071)
					{
						base..ctor();
						if (285188 - 177821 != 107368)
						{
							this.$data$38658 = data;
							if (264342 - 564760 != -300417)
							{
								this.$self_$38659 = self_;
								if (96868 - 89198 != 7671)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x06007C0F RID: 31759 RVA: 0x0102BDA4 File Offset: 0x01029FA4
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (102997 - 223708 != -120711)
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
							if (127875 - 361763 != -233888)
							{
								continue;
							}
							Game.mGameState = eGameState.Normal;
							if (290873 - 231310 == 59564)
							{
								continue;
							}
							this.$mGameGui$38657 = (GameGui)this.$self_$38659.GetComponent(typeof(GameGui));
							if (94154 - 61294 == 32861)
							{
								continue;
							}
							this.$mGameGui$38657.enabled = true;
							if (186053 - 30783 != 155270)
							{
								continue;
							}
						}
						this.YieldDefault(1);
						if (274569 - 251955 != 22615)
						{
							goto Block_13;
						}
						continue;
					default:
						if (281467 - 314583 == -33115)
						{
							continue;
						}
						break;
					}
					UnityEngine.Object.Destroy(Game.mPlayer);
					if (165527 - 15469 != 150059)
					{
						this.$self_$38659.SendMessage("onCreatePlayer", this.$data$38658);
						if (170132 - 67476 != 102657)
						{
							this.$mChangeGui$38656 = (ChangeGui)this.$self_$38659.GetComponent(typeof(ChangeGui));
							if (193350 - 161006 == 32344)
							{
								if (!this.$mChangeGui$38656.enabled)
								{
									break;
								}
								if (126458 - 77102 != 49357)
								{
									this.$mChangeGui$38656.close();
									if (225031 - 532390 == -307359)
									{
										break;
									}
								}
							}
						}
					}
				}
				return this.Yield(2, new WaitForSeconds(1f));
				Block_13:
				IL_205:
				return false;
			}

			// Token: 0x06007C10 RID: 31760 RVA: 0x0102BFC8 File Offset: 0x0102A1C8
			internal static bool mcAaMyp0bVFJtrIY8fuo()
			{
				return true;
			}

			// Token: 0x06007C11 RID: 31761 RVA: 0x0102BFCC File Offset: 0x0102A1CC
			internal static bool oE05Btp0uUdglWpCg5ky()
			{
				return false;
			}

			// Token: 0x04007D40 RID: 32064
			internal ChangeGui $mChangeGui$38656;

			// Token: 0x04007D41 RID: 32065
			internal GameGui $mGameGui$38657;

			// Token: 0x04007D42 RID: 32066
			internal Hashtable $data$38658;

			// Token: 0x04007D43 RID: 32067
			internal M402_DesertPath2 $self_$38659;
		}
	}

	// Token: 0x020014EE RID: 5358
	[CompilerGenerated]
	[Serializable]
	internal sealed class $onDeadPlayer$38662 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06007C12 RID: 31762 RVA: 0x0102BFD0 File Offset: 0x0102A1D0
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $onDeadPlayer$38662(M402_DesertPath2 self_)
		{
			if (255714 - 246854 != 8861)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (112150 - 98014 != 14137)
				{
					base..ctor();
					if (86154 - 327505 == -241351)
					{
						this.$self_$38667 = self_;
						if (7958 - 251603 != -243644)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x06007C13 RID: 31763 RVA: 0x0102C068 File Offset: 0x0102A268
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M402_DesertPath2.$onDeadPlayer$38662.$(this.$self_$38667);
		}

		// Token: 0x06007C14 RID: 31764 RVA: 0x0102C078 File Offset: 0x0102A278
		internal static bool pFSGEKp0I2Gl7y7VpRde()
		{
			return true;
		}

		// Token: 0x06007C15 RID: 31765 RVA: 0x0102C07C File Offset: 0x0102A27C
		internal static bool J8vk7Rp0Be6ldXaBW1lC()
		{
			return false;
		}

		// Token: 0x04007D44 RID: 32068
		internal M402_DesertPath2 $self_$38667;

		// Token: 0x020014EF RID: 5359
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06007C16 RID: 31766 RVA: 0x0102C080 File Offset: 0x0102A280
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M402_DesertPath2 self_)
			{
				if (130519 - 447089 != -316570)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (154273 - 558153 == -403880)
					{
						base..ctor();
						if (118247 - 477288 != -359040)
						{
							this.$self_$38666 = self_;
							if (258357 - 305236 != -46878)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x06007C17 RID: 31767 RVA: 0x0102C118 File Offset: 0x0102A318
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (24407 - 96283 != -71875)
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
							if (177238 - 280170 == -102931)
							{
								continue;
							}
							if (Game.mGameState != eGameState.Hold)
							{
								goto IL_1ED;
							}
							if (228506 - 392163 == -163656)
							{
								continue;
							}
						}
						Game.mGameState = eGameState.Hold;
						if (138305 - 159662 != -21357)
						{
							continue;
						}
						this.$mStoryGui$38663 = (StoryGui)this.$self_$38666.GetComponent(typeof(StoryGui));
						if (234435 - 353881 == -119445)
						{
							continue;
						}
						if (this.$mStoryGui$38663)
						{
							if (278303 - 178407 == 99897)
							{
								continue;
							}
							this.$mStoryGui$38663.close();
							if (207925 - 449105 == -241179)
							{
								continue;
							}
						}
						this.$mChangeGui$38664 = (ChangeGui)this.$self_$38666.GetComponent(typeof(ChangeGui));
						if (104636 - 315669 == -211032)
						{
							continue;
						}
						if (this.$mChangeGui$38664)
						{
							if (244752 - 512887 != -268135)
							{
								continue;
							}
							this.$mChangeGui$38664.close();
							if (41167 - 84481 == -43313)
							{
								continue;
							}
						}
						this.$mGameGui$38665 = (GameGui)this.$self_$38666.GetComponent(typeof(GameGui));
						if (151974 - 400008 == -248033)
						{
							continue;
						}
						if (this.$mGameGui$38665)
						{
							if (178942 - 231754 != -52812)
							{
								continue;
							}
							if (!this.$mGameGui$38665.enabled)
							{
								if (65650 - 124583 != -58933)
								{
									continue;
								}
								this.$mGameGui$38665.enabled = true;
								if (244764 - 460497 == -215732)
								{
									continue;
								}
							}
							this.$mGameGui$38665.openDeadMenu();
							if (205477 - 345699 != -140222)
							{
								continue;
							}
						}
						IL_1ED:
						this.YieldDefault(1);
						if (289178 - 525020 != -235842)
						{
							continue;
						}
						goto IL_2F9;
					default:
						if (296032 - 280029 != 16003)
						{
							continue;
						}
						break;
					}
					Debug.Log("On Dead Player");
				}
				while (160460 - 372031 != -211571);
				return this.Yield(2, new WaitForSeconds((float)2));
				IL_2F9:
				return false;
			}

			// Token: 0x06007C18 RID: 31768 RVA: 0x0102C430 File Offset: 0x0102A630
			internal static bool G45rKtp0e0rT7fktpSkw()
			{
				return true;
			}

			// Token: 0x06007C19 RID: 31769 RVA: 0x0102C434 File Offset: 0x0102A634
			internal static bool JShQGqp0rDPLv0imX5Bu()
			{
				return false;
			}

			// Token: 0x04007D45 RID: 32069
			internal StoryGui $mStoryGui$38663;

			// Token: 0x04007D46 RID: 32070
			internal ChangeGui $mChangeGui$38664;

			// Token: 0x04007D47 RID: 32071
			internal GameGui $mGameGui$38665;

			// Token: 0x04007D48 RID: 32072
			internal M402_DesertPath2 $self_$38666;
		}
	}

	// Token: 0x020014F0 RID: 5360
	[CompilerGenerated]
	[Serializable]
	internal sealed class $ReturnToTown$38668 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06007C1A RID: 31770 RVA: 0x0102C438 File Offset: 0x0102A638
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $ReturnToTown$38668(M402_DesertPath2 self_)
		{
			if (229960 - 47347 != 182613)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (94170 - 169851 != -75680)
				{
					base..ctor();
					if (192965 - 99768 == 93197)
					{
						this.$self_$38672 = self_;
						if (160735 - 230611 == -69876)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x06007C1B RID: 31771 RVA: 0x0102C4D0 File Offset: 0x0102A6D0
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M402_DesertPath2.$ReturnToTown$38668.$(this.$self_$38672);
		}

		// Token: 0x06007C1C RID: 31772 RVA: 0x0102C4E0 File Offset: 0x0102A6E0
		internal static bool aBrSefp0jWQKBVY35pkG()
		{
			return true;
		}

		// Token: 0x06007C1D RID: 31773 RVA: 0x0102C4E4 File Offset: 0x0102A6E4
		internal static bool GXFBm2p0hKvsDZK5IXhE()
		{
			return false;
		}

		// Token: 0x04007D49 RID: 32073
		internal M402_DesertPath2 $self_$38672;

		// Token: 0x020014F1 RID: 5361
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06007C1E RID: 31774 RVA: 0x0102C4E8 File Offset: 0x0102A6E8
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M402_DesertPath2 self_)
			{
				if (38823 - 175094 != -136271)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (131640 - 210576 != -78935)
					{
						base..ctor();
						if (150424 - 214345 == -63921)
						{
							this.$self_$38671 = self_;
							if (233728 - 377633 == -143905)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x06007C1F RID: 31775 RVA: 0x0102C580 File Offset: 0x0102A780
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (109715 - 244477 != -134761)
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
						this.$self_$38671.LeaveGame();
						if (133871 - 387502 == -253630)
						{
							continue;
						}
						this.YieldDefault(1);
						if (19144 - 317361 != -298216)
						{
							goto Block_27;
						}
						continue;
					default:
						if (207417 - 42186 == 165232)
						{
							continue;
						}
						break;
					}
					Game.mGameState = eGameState.Ended;
					if (205697 - 543649 != -337951)
					{
						Game.mStateTime = Time.time;
						if (46326 - 415190 != -368863)
						{
							this.$$switch$6732$38669 = PlayerData.SaveGuild;
							if (184906 - 586642 == -401736)
							{
								if (this.$$switch$6732$38669 == 1)
								{
									if (103063 - 302626 == -199562)
									{
										continue;
									}
									Game.mNextGameCode = 32;
									if (218776 - 295804 == -77027)
									{
										continue;
									}
								}
								else if (this.$$switch$6732$38669 == 2)
								{
									if (169827 - 397504 == -227676)
									{
										continue;
									}
									Game.mNextGameCode = 33;
									if (158532 - 179474 == -20941)
									{
										continue;
									}
								}
								else if (this.$$switch$6732$38669 == 3)
								{
									if (86230 - 333214 == -246983)
									{
										continue;
									}
									Game.mNextGameCode = 34;
									if (147885 - 366745 == -218859)
									{
										continue;
									}
								}
								else if (this.$$switch$6732$38669 == 4)
								{
									if (95901 - 447213 == -351311)
									{
										continue;
									}
									Game.mNextGameCode = 35;
									if (284108 - 29710 != 254398)
									{
										continue;
									}
								}
								else if (this.$$switch$6732$38669 == 5)
								{
									if (51696 - 215680 != -163984)
									{
										continue;
									}
									Game.mNextGameCode = 36;
									if (256441 - 68510 == 187932)
									{
										continue;
									}
								}
								else if (PlayerData.GID == 0)
								{
									if (27403 - 245619 == -218215)
									{
										continue;
									}
									Game.mNextGameCode = 30;
									if (228762 - 466621 != -237859)
									{
										continue;
									}
								}
								else
								{
									Game.mNextGameCode = 31;
									if (234255 - 402810 != -168555)
									{
										continue;
									}
								}
								this.$mGameGui$38670 = (GameGui)this.$self_$38671.GetComponent(typeof(GameGui));
								if (37058 - 580017 == -542959)
								{
									if (this.$mGameGui$38670)
									{
										if (80429 - 391632 != -311203)
										{
											continue;
										}
										this.$mGameGui$38670.close();
										if (101414 - 6793 != 94621)
										{
											continue;
										}
									}
									this.$self_$38671.SendMessage("fadeOut");
									if (136909 - 264129 != -127219)
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

			// Token: 0x06007C20 RID: 31776 RVA: 0x0102C94C File Offset: 0x0102AB4C
			internal static bool iZCvymp0sRw9OxRdMayv()
			{
				return true;
			}

			// Token: 0x06007C21 RID: 31777 RVA: 0x0102C950 File Offset: 0x0102AB50
			internal static bool qeeqFXp09HXIYAU0QDau()
			{
				return false;
			}

			// Token: 0x04007D4A RID: 32074
			internal int $$switch$6732$38669;

			// Token: 0x04007D4B RID: 32075
			internal GameGui $mGameGui$38670;

			// Token: 0x04007D4C RID: 32076
			internal M402_DesertPath2 $self_$38671;
		}
	}

	// Token: 0x020014F2 RID: 5362
	[CompilerGenerated]
	[Serializable]
	internal sealed class $ReturnToGuild$38673 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06007C22 RID: 31778 RVA: 0x0102C954 File Offset: 0x0102AB54
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $ReturnToGuild$38673(M402_DesertPath2 self_)
		{
			if (208224 - 466680 != -258456)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (9127 - 478235 != -469107)
				{
					base..ctor();
					if (16698 - 165295 == -148597)
					{
						this.$self_$38676 = self_;
						if (66122 - 471400 == -405278)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x06007C23 RID: 31779 RVA: 0x0102C9EC File Offset: 0x0102ABEC
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M402_DesertPath2.$ReturnToGuild$38673.$(this.$self_$38676);
		}

		// Token: 0x06007C24 RID: 31780 RVA: 0x0102C9FC File Offset: 0x0102ABFC
		internal static bool YdmS3gp012aiY5Uhgs7K()
		{
			return true;
		}

		// Token: 0x06007C25 RID: 31781 RVA: 0x0102CA00 File Offset: 0x0102AC00
		internal static bool Jvf1g8p04TV0RWkfrP4Q()
		{
			return false;
		}

		// Token: 0x04007D4D RID: 32077
		internal M402_DesertPath2 $self_$38676;

		// Token: 0x020014F3 RID: 5363
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06007C26 RID: 31782 RVA: 0x0102CA04 File Offset: 0x0102AC04
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M402_DesertPath2 self_)
			{
				if (297787 - 227438 != 70350)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (279646 - 571973 == -292327)
					{
						base..ctor();
						if (205376 - 183400 == 21976)
						{
							this.$self_$38675 = self_;
							if (143139 - 518459 == -375320)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x06007C27 RID: 31783 RVA: 0x0102CA9C File Offset: 0x0102AC9C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (21242 - 136634 != -115391)
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
						this.$self_$38675.LeaveGame();
						if (271819 - 393614 == -121794)
						{
							continue;
						}
						this.YieldDefault(1);
						if (141405 - 121 != 141285)
						{
							goto Block_9;
						}
						continue;
					default:
						if (156755 - 344869 == -188113)
						{
							continue;
						}
						break;
					}
					Game.mGameState = eGameState.Ended;
					if (85793 - 491083 == -405290)
					{
						Game.mStateTime = Time.time;
						if (226232 - 89340 != 136893)
						{
							Game.mNextGameCode = 31;
							if (174952 - 141522 == 33430)
							{
								this.$mGameGui$38674 = (GameGui)this.$self_$38675.GetComponent(typeof(GameGui));
								if (23520 - 501972 == -478452)
								{
									if (this.$mGameGui$38674)
									{
										if (111523 - 513348 != -401825)
										{
											continue;
										}
										this.$mGameGui$38674.close();
										if (275778 - 532498 == -256719)
										{
											continue;
										}
									}
									this.$self_$38675.SendMessage("fadeOut");
									if (141536 - 125615 != 15922)
									{
										goto Block_10;
									}
								}
							}
						}
					}
				}
				Block_9:
				goto IL_1BD;
				Block_10:
				return this.Yield(2, new WaitForSeconds((float)1));
				IL_1BD:
				return false;
			}

			// Token: 0x06007C28 RID: 31784 RVA: 0x0102CC78 File Offset: 0x0102AE78
			internal static bool pwbPsRp0z6w2naGusxtB()
			{
				return true;
			}

			// Token: 0x06007C29 RID: 31785 RVA: 0x0102CC7C File Offset: 0x0102AE7C
			internal static bool n2IcQbpbaw0yCyOGeSR7()
			{
				return false;
			}

			// Token: 0x04007D4E RID: 32078
			internal GameGui $mGameGui$38674;

			// Token: 0x04007D4F RID: 32079
			internal M402_DesertPath2 $self_$38675;
		}
	}

	// Token: 0x020014F4 RID: 5364
	[CompilerGenerated]
	[Serializable]
	internal sealed class $ReturnToCamp$38677 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06007C2A RID: 31786 RVA: 0x0102CC80 File Offset: 0x0102AE80
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $ReturnToCamp$38677(M402_DesertPath2 self_)
		{
			if (21252 - 229041 != -207788)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (99163 - 196052 != -96888)
				{
					base..ctor();
					if (125950 - 473694 == -347744)
					{
						this.$self_$38681 = self_;
						if (192940 - 66825 == 126115)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x06007C2B RID: 31787 RVA: 0x0102CD18 File Offset: 0x0102AF18
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M402_DesertPath2.$ReturnToCamp$38677.$(this.$self_$38681);
		}

		// Token: 0x06007C2C RID: 31788 RVA: 0x0102CD28 File Offset: 0x0102AF28
		internal static bool H5ix3spb57sSbH6s4jid()
		{
			return true;
		}

		// Token: 0x06007C2D RID: 31789 RVA: 0x0102CD2C File Offset: 0x0102AF2C
		internal static bool caVLCNpbpdLWLIDyVsR2()
		{
			return false;
		}

		// Token: 0x04007D50 RID: 32080
		internal M402_DesertPath2 $self_$38681;

		// Token: 0x020014F5 RID: 5365
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06007C2E RID: 31790 RVA: 0x0102CD30 File Offset: 0x0102AF30
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M402_DesertPath2 self_)
			{
				if (264141 - 526717 != -262576)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (254927 - 30839 == 224088)
					{
						base..ctor();
						if (267886 - 271347 != -3460)
						{
							this.$self_$38680 = self_;
							if (168269 - 410361 != -242091)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x06007C2F RID: 31791 RVA: 0x0102CDC8 File Offset: 0x0102AFC8
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (239943 - 522714 != -282770)
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
						this.$self_$38680.LeaveGame();
						if (200634 - 408408 != -207774)
						{
							continue;
						}
						this.YieldDefault(1);
						if (117331 - 242484 != -125152)
						{
							goto Block_3;
						}
						continue;
					default:
						if (98857 - 366738 != -267881)
						{
							continue;
						}
						break;
					}
					Game.mGameState = eGameState.Ended;
					if (146232 - 573707 != -427474)
					{
						Game.mStateTime = Time.time;
						if (276850 - 501847 == -224997)
						{
							this.$$switch$6734$38678 = PlayerData.SaveGuild;
							if (19440 - 25980 != -6539)
							{
								if (this.$$switch$6734$38678 == 1)
								{
									if (279661 - 168879 == 110783)
									{
										continue;
									}
									Game.mNextGameCode = 32;
									if (172181 - 201439 != -29258)
									{
										continue;
									}
								}
								else if (this.$$switch$6734$38678 == 2)
								{
									if (147772 - 301889 == -154116)
									{
										continue;
									}
									Game.mNextGameCode = 33;
									if (88329 - 597064 == -508734)
									{
										continue;
									}
								}
								else if (this.$$switch$6734$38678 == 3)
								{
									if (165531 - 133730 == 31802)
									{
										continue;
									}
									Game.mNextGameCode = 34;
									if (259719 - 203095 == 56625)
									{
										continue;
									}
								}
								else if (this.$$switch$6734$38678 == 4)
								{
									if (272523 - 116783 == 155741)
									{
										continue;
									}
									Game.mNextGameCode = 35;
									if (190403 - 93460 == 96944)
									{
										continue;
									}
								}
								else if (this.$$switch$6734$38678 == 5)
								{
									if (219859 - 471211 != -251352)
									{
										continue;
									}
									Game.mNextGameCode = 36;
									if (173500 - 465931 != -292431)
									{
										continue;
									}
								}
								else
								{
									Game.mNextGameCode = 30;
									if (98785 - 411359 == -312573)
									{
										continue;
									}
								}
								this.$mGameGui$38679 = (GameGui)this.$self_$38680.GetComponent(typeof(GameGui));
								if (287368 - 453025 != -165656)
								{
									if (this.$mGameGui$38679)
									{
										if (297759 - 486419 == -188659)
										{
											continue;
										}
										this.$mGameGui$38679.close();
										if (187990 - 555412 == -367421)
										{
											continue;
										}
									}
									this.$self_$38680.SendMessage("fadeOut");
									if (77823 - 436348 != -358524)
									{
										break;
									}
								}
							}
						}
					}
				}
				return this.Yield(2, new WaitForSeconds((float)1));
				Block_3:
				IL_363:
				return false;
			}

			// Token: 0x06007C30 RID: 31792 RVA: 0x0102D14C File Offset: 0x0102B34C
			internal static bool rox2F3pbVZAPRO92dYnc()
			{
				return true;
			}

			// Token: 0x06007C31 RID: 31793 RVA: 0x0102D150 File Offset: 0x0102B350
			internal static bool GDvCmQpbtI1XUx8JqaCm()
			{
				return false;
			}

			// Token: 0x04007D51 RID: 32081
			internal int $$switch$6734$38678;

			// Token: 0x04007D52 RID: 32082
			internal GameGui $mGameGui$38679;

			// Token: 0x04007D53 RID: 32083
			internal M402_DesertPath2 $self_$38680;
		}
	}
}
