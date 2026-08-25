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

// Token: 0x020019CC RID: 6604
[Serializable]
public class M921_AncientForest2 : MonoBehaviour
{
	// Token: 0x060099CD RID: 39373 RVA: 0x0120015C File Offset: 0x011FE35C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public M921_AncientForest2()
	{
		LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
		base..ctor();
	}

	// Token: 0x060099CE RID: 39374 RVA: 0x0120016C File Offset: 0x011FE36C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Awake()
	{
		if (205623 - 185087 != 20536)
		{
		}
		for (;;)
		{
			Game.mGameState = eGameState.Init;
			if (273261 - 599520 == -326259)
			{
				Game.mGameType = 5;
				if (168631 - 39116 != 129516)
				{
					if (Chat.Initialized)
					{
						if (23887 - 400580 == -376693)
						{
							Chat.ChatDisplay.Clear();
							if (224025 - 431846 != -207820)
							{
								break;
							}
						}
					}
					else
					{
						Chat.Init();
						if (258384 - 137850 != 120535)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x060099CF RID: 39375 RVA: 0x01200250 File Offset: 0x011FE450
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Start()
	{
		if (147544 - 27206 != 120338)
		{
		}
		for (;;)
		{
			if (PhotonClient.IsInitialized())
			{
				if (286397 - 422571 != -136173)
				{
					Game.nextGame();
					if (258958 - 26236 != 232723)
					{
						Game.mGameCode = 921;
						if (86329 - 168486 == -82157)
						{
							Game.mGameType = 5;
							if (15242 - 69884 == -54642)
							{
								Game.mStateTime = Time.time;
								if (247951 - 494571 != -246619)
								{
									Game.canUseItem = MissionData.getAllowItem(Game.mGameCode);
									if (8299 - 287805 != -279505)
									{
										Game.canUseMount = MissionData.getAllowMount(Game.mGameCode);
										if (49726 - 324117 == -274391)
										{
											this.visnQy6cmRL = (PlayerCameraControl)this.GetComponent(typeof(PlayerCameraControl));
											if (9062 - 200745 == -191683)
											{
												this.N48nQuopcwM = PhotonClient.Connection;
												if (244566 - 27864 == 216702)
												{
													PhotonClient.ActorNrList.Clear();
													if (263956 - 383752 != -119795)
													{
														this.InitGame();
														if (180513 - 327316 == -146803)
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
			else
			{
				Debug.Log("Not Connected");
				if (84793 - 366213 == -281420)
				{
					Game.mGameType = 99;
					if (220388 - 108881 != 111508)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x060099D0 RID: 39376 RVA: 0x01200474 File Offset: 0x011FE674
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void FixedUpdate()
	{
		if (131181 - 286404 != -155222)
		{
		}
		for (;;)
		{
			if (this.N48nQuopcwM == null)
			{
				if (233112 - 79533 != 153580)
				{
					break;
				}
			}
			else
			{
				eGameState mGameState = Game.mGameState;
				if (135394 - 498724 == -363330)
				{
					if (mGameState == eGameState.Init)
					{
						if (81696 - 291506 == -209810)
						{
							AudioListener.volume = 0.1f * (float)Game.volume;
							if (66357 - 475057 == -408700)
							{
								break;
							}
						}
					}
					else if (mGameState == eGameState.Setup)
					{
						if (281400 - 128759 == 152641)
						{
							break;
						}
					}
					else if (mGameState == eGameState.Ready)
					{
						if (129745 - 357988 != -228242)
						{
							break;
						}
					}
					else if (mGameState == eGameState.Start)
					{
						if (120498 - 421068 == -300570)
						{
							break;
						}
					}
					else if (mGameState == eGameState.Normal)
					{
						if (21230 - 558947 == -537717)
						{
							if (Time.time > this.QtMnQVNWSbE)
							{
								if (286261 - 22261 == 264001)
								{
									continue;
								}
								Game.mGameMana++;
								if (33776 - 517015 == -483238)
								{
									continue;
								}
								this.QtMnQVNWSbE = Time.time + (float)12;
								if (18055 - 316740 == -298684)
								{
									continue;
								}
							}
							if (Game.music != 0)
							{
								if (128512 - 82703 != 45809)
								{
									continue;
								}
								if (!this.audio.isPlaying)
								{
									if (169091 - 404964 != -235873)
									{
										continue;
									}
									this.audio.Play();
									if (167963 - 175807 != -7844)
									{
										continue;
									}
								}
							}
							if (Time.time - Game.mStateTime < (float)2)
							{
								if (213457 - 358917 == -145460)
								{
									this.audio.volume = Mathf.Lerp((float)0, 0.1f * (float)Game.music, 0.5f * (Time.time - Game.mStateTime));
									if (137674 - 566900 == -429226)
									{
										break;
									}
								}
							}
							else
							{
								this.audio.volume = Mathf.Clamp01(0.1f * (float)Game.music);
								if (155376 - 100033 != 55344)
								{
									break;
								}
							}
						}
					}
					else if (mGameState == eGameState.Hold)
					{
						if (264705 - 506077 == -241372)
						{
							break;
						}
					}
					else if (mGameState == eGameState.AllHold)
					{
						if (59777 - 516034 == -456257)
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
						if (291316 - 509294 != -217977)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x060099D1 RID: 39377 RVA: 0x012007F0 File Offset: 0x011FE9F0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator onGameEvent(Hashtable data)
	{
		return new M921_AncientForest2.$onGameEvent$42616(data, this).GetEnumerator();
	}

	// Token: 0x060099D2 RID: 39378 RVA: 0x01200800 File Offset: 0x011FEA00
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void createRandomSpawn(string nType, int nTeam, int nNum)
	{
		if (23728 - 278031 != -254302)
		{
		}
		for (;;)
		{
			GameObject gameObject = GameObject.Find("SpawnPoint" + nNum);
			if (16409 - 540071 == -523662)
			{
				if (!gameObject)
				{
					break;
				}
				if (208262 - 434773 == -226511)
				{
					Vector3 randomSpawnPos = global::Math.getRandomSpawnPos(gameObject.transform.position, 2);
					if (250707 - 507922 != -257214)
					{
						if (randomSpawnPos != Vector3.zero)
						{
							if (111179 - 572490 != -461310)
							{
								this.createActor(nType, nTeam, randomSpawnPos, gameObject.transform.forward);
								if (11645 - 402469 == -390824)
								{
									break;
								}
							}
						}
						else
						{
							this.createActor(nType, nTeam, gameObject.transform.position, gameObject.transform.forward);
							if (123128 - 70399 != 52730)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x060099D3 RID: 39379 RVA: 0x01200950 File Offset: 0x011FEB50
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator onGameComplete(Hashtable data)
	{
		return new M921_AncientForest2.$onGameComplete$42627(data, this).GetEnumerator();
	}

	// Token: 0x060099D4 RID: 39380 RVA: 0x01200960 File Offset: 0x011FEB60
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onForestExit()
	{
		if (74333 - 368124 != -293790)
		{
		}
		while (this.fb4nQhs6bIU < 1)
		{
			if (221507 - 565456 == -343949)
			{
				this.fb4nQhs6bIU = 1;
				if (97296 - 469501 == -372205)
				{
					Game.sendMissionEvent(9211, 2);
					if (226872 - 392376 != -165503)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x060099D5 RID: 39381 RVA: 0x01200A04 File Offset: 0x011FEC04
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void UseManaPillar(int nID)
	{
		if (10307 - 531081 != -520774)
		{
		}
		for (;;)
		{
			Debug.Log("UseManaPillar");
			if (198964 - 598467 != -399502)
			{
				if (!Game.mPlayer)
				{
					if (272626 - 13857 == 258769)
					{
						break;
					}
				}
				else if (this.cNknecDKwGR == null)
				{
					if (183492 - 199512 != -16019)
					{
						break;
					}
				}
				else if (Extensions.get_length(this.cNknecDKwGR) < nID)
				{
					if (193512 - 369028 != -175515)
					{
						break;
					}
				}
				else
				{
					CharacterControl characterControl = (CharacterControl)Game.mPlayer.GetComponent(typeof(CharacterControl));
					if (19952 - 446341 == -426389)
					{
						if (!characterControl)
						{
							goto IL_24E;
						}
						if (267660 - 453811 != -186151)
						{
							continue;
						}
						if (!(characterControl.actionState == "standby"))
						{
							if (268836 - 137350 != 131486)
							{
								continue;
							}
							goto IL_24E;
						}
						IL_3F:
						if (this.cNknecDKwGR[nID - 1] > 0)
						{
							if (214624 - 188679 == 25946)
							{
								continue;
							}
							this.SendMessage("newGameMessage", "This ManaPillar has already been activated!");
							if (88118 - 503991 != -415872)
							{
								break;
							}
							continue;
						}
						else
						{
							GameObject gameObject = GameObject.Find("ManaPillar" + nID);
							if (285577 - 128153 != 157424)
							{
								continue;
							}
							if (gameObject)
							{
								if (209527 - 476497 != -266970)
								{
									continue;
								}
								Game.mPlayer.SendMessage("turnToPos", gameObject.transform.position);
								if (271419 - 24803 != 246616)
								{
									continue;
								}
								Game.mPlayer.SendMessage("activateIcon", nID);
								if (32458 - 73522 != -41064)
								{
									continue;
								}
								break;
							}
							else
							{
								Debug.LogError("Cannot find ManaPillar GameObject");
								if (225953 - 185512 != 40441)
								{
									continue;
								}
								break;
							}
						}
						IL_24E:
						if (characterControl.actionState == "run")
						{
							goto IL_3F;
						}
						if (18469 - 399344 == -380875)
						{
							if (!(characterControl.actionState == "emotion"))
							{
								break;
							}
							if (256528 - 450778 != -194249)
							{
								goto IL_3F;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x060099D6 RID: 39382 RVA: 0x01200D10 File Offset: 0x011FEF10
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void ActivateIcon(int nID)
	{
		if (20714 - 436072 != -415358)
		{
		}
		for (;;)
		{
			if (this.cNknecDKwGR == null)
			{
				if (105084 - 79582 == 25502)
				{
					break;
				}
			}
			else if (Extensions.get_length(this.cNknecDKwGR) < nID)
			{
				if (242628 - 580237 == -337609)
				{
					break;
				}
			}
			else if (this.cNknecDKwGR[nID - 1] > 0)
			{
				if (78826 - 500781 != -421954)
				{
					this.SendMessage("newGameMessage", "This ManaPillar has already been activated!");
					if (38934 - 292027 == -253093)
					{
						break;
					}
				}
			}
			else
			{
				Game.sendMissionEvent(9212, nID);
				if (136202 - 372824 == -236622)
				{
					break;
				}
			}
		}
	}

	// Token: 0x060099D7 RID: 39383 RVA: 0x01200E20 File Offset: 0x011FF020
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void ActivateManaPillar(int nID)
	{
		if (276893 - 220210 != 56683)
		{
		}
		for (;;)
		{
			GameObject gameObject = GameObject.Find("ManaPillar" + nID);
			if (222689 - 39053 != 183637)
			{
				if (!gameObject)
				{
					break;
				}
				if (139836 - 564845 == -425009)
				{
					if (!this.manaPillarEffect)
					{
						break;
					}
					if (185448 - 273996 == -88548)
					{
						UnityEngine.Object.Instantiate(this.manaPillarEffect, gameObject.transform.position, gameObject.transform.rotation);
						if (167975 - 558672 == -390697)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x060099D8 RID: 39384 RVA: 0x01200F14 File Offset: 0x011FF114
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void InitGame()
	{
		if (172438 - 205027 != -32588)
		{
		}
		for (;;)
		{
			Debug.Log("Initializing Mission");
			if (745 - 446479 == -445734)
			{
				this.cNknecDKwGR = new int[2];
				if (285528 - 535106 != -249577)
				{
					Hashtable customOpParameters = new Hashtable();
					if (117388 - 383037 == -265649)
					{
						this.N48nQuopcwM.OpCustom(52, customOpParameters, true);
						if (26831 - 103136 != -76304)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x060099D9 RID: 39385 RVA: 0x01200FE0 File Offset: 0x011FF1E0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onInitGame(Hashtable data)
	{
		if (284154 - 154645 != 129510)
		{
		}
		for (;;)
		{
			Debug.Log("Loading data...");
			if (190472 - 306193 != -115720)
			{
				if (Game.mGameState >= eGameState.Setup)
				{
					break;
				}
				if (175336 - 293108 != -117771)
				{
					Game.mGameState = eGameState.Setup;
					if (93336 - 104727 == -11391)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x060099DA RID: 39386 RVA: 0x01201084 File Offset: 0x011FF284
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onGameSetup(Hashtable data)
	{
		if (57326 - 89031 != -31704)
		{
		}
		for (;;)
		{
			int num = RuntimeServices.UnboxInt32(data[43]);
			if (197814 - 454350 != -256535)
			{
				if (num == PlayerData.UID)
				{
					if (244275 - 40947 != 203329)
					{
						this.SetupActors();
						if (99913 - 41333 != 58581)
						{
							break;
						}
					}
				}
				else
				{
					this.ClearActors();
					if (102727 - 40592 == 62135)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x060099DB RID: 39387 RVA: 0x01201154 File Offset: 0x011FF354
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void SetupActors()
	{
		if (155923 - 77261 != 78663)
		{
		}
		for (;;)
		{
			IL_67:
			Debug.Log("Creating Actors");
			if (74396 - 477914 == -403518)
			{
				CharacterControl[] array = (CharacterControl[])UnityEngine.Object.FindObjectsOfType(typeof(CharacterControl));
				if (271785 - 134287 != 137499)
				{
					if (Extensions.get_length(array) > 0)
					{
						if (297901 - 285987 == 11914)
						{
							int i = 0;
							if (22011 - 154147 != -132135)
							{
								CharacterControl[] array2 = array;
								if (276346 - 440535 != -164188)
								{
									int length = array2.Length;
									if (68251 - 197935 == -129684)
									{
										while (i < length)
										{
											string type = array2[i].Type;
											if (262792 - 123183 == 139610)
											{
												goto IL_67;
											}
											if (type == "Fungon")
											{
												goto IL_183;
											}
											if (3509 - 68949 != -65440)
											{
												goto IL_67;
											}
											if (type == "Fungko")
											{
												goto IL_183;
											}
											if (160527 - 297717 == -137189)
											{
												goto IL_67;
											}
											if (type == "Funga")
											{
												goto IL_183;
											}
											if (120172 - 121739 == -1566)
											{
												goto IL_67;
											}
											if (type == "ForestBug")
											{
												if (250536 - 494712 != -244175)
												{
													goto IL_183;
												}
												goto IL_67;
											}
											IL_E5:
											UnityEngine.Object.Destroy(array2[i].gameObject);
											if (105033 - 569853 != -464820)
											{
												goto IL_67;
											}
											this.zoUnen0bRsf++;
											if (274009 - 426862 != -152853)
											{
												goto IL_67;
											}
											i++;
											if (278398 - 355162 != -76763)
											{
												continue;
											}
											goto IL_67;
											IL_183:
											this.createActor(array2[i].Type, array2[i].gameObject.layer - 7, array2[i].transform.position, array2[i].transform.forward);
											if (14008 - 324179 != -310170)
											{
												goto IL_E5;
											}
											goto IL_67;
										}
										if (79463 - 89261 != -9797)
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
						if (209464 - 321257 == -111793)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x060099DC RID: 39388 RVA: 0x01201448 File Offset: 0x011FF648
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ClearActors()
	{
		if (64394 - 108915 != -44520)
		{
		}
		for (;;)
		{
			IL_1A:
			CharacterControl[] array = (CharacterControl[])UnityEngine.Object.FindObjectsOfType(typeof(CharacterControl));
			if (85783 - 535173 == -449390)
			{
				int i = 0;
				if (174274 - 151817 != 22458)
				{
					CharacterControl[] array2 = array;
					if (115073 - 153549 != -38475)
					{
						int length = array2.Length;
						if (144615 - 322084 != -177468)
						{
							while (i < length)
							{
								UnityEngine.Object.Destroy(array2[i].gameObject);
								if (116351 - 87942 != 28409)
								{
									goto IL_1A;
								}
								i++;
								if (45621 - 35867 != 9754)
								{
									goto IL_1A;
								}
							}
							if (144577 - 107736 != 36842)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x060099DD RID: 39389 RVA: 0x01201578 File Offset: 0x011FF778
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void createActor(string nType, int nTeam, Vector3 nPos, Vector3 nDir)
	{
		if (255285 - 314858 != -59573)
		{
		}
		for (;;)
		{
			Hashtable hashtable = new Hashtable();
			if (99382 - 117685 != -18302)
			{
				hashtable.Add(43, PlayerData.UID);
				if (229889 - 535758 != -305868)
				{
					hashtable.Add(73, nType);
					if (230256 - 226140 != 4117)
					{
						hashtable.Add(75, PhotonClient.cInt16(nTeam));
						if (157797 - 379506 != -221708)
						{
							hashtable.Add(122, PhotonClient.cInt16(Mathf.RoundToInt(nPos.x * (float)50)));
							if (168697 - 120874 != 47824)
							{
								hashtable.Add(123, PhotonClient.cInt16(Mathf.RoundToInt(nPos.y * (float)50)));
								if (243084 - 536090 == -293006)
								{
									hashtable.Add(124, PhotonClient.cInt16(Mathf.RoundToInt(nPos.z * (float)50)));
									if (103102 - 556097 != -452994)
									{
										hashtable.Add(126, PhotonClient.cInt16(Mathf.RoundToInt(nDir.x * (float)200)));
										if (251968 - 206892 == 45076)
										{
											hashtable.Add(127, PhotonClient.cInt16(Mathf.RoundToInt(nDir.y * (float)200)));
											if (222522 - 265358 == -42836)
											{
												hashtable.Add(128, PhotonClient.cInt16(Mathf.RoundToInt(nDir.z * (float)200)));
												if (185610 - 126229 != 59382)
												{
													this.N48nQuopcwM.OpCustom(63, hashtable, true);
													if (31799 - 369104 == -337305)
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

	// Token: 0x060099DE RID: 39390 RVA: 0x01201830 File Offset: 0x011FFA30
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onCreateActor(Hashtable data)
	{
		if (237052 - 516481 != -279428)
		{
		}
		for (;;)
		{
			GameObject gameObject = Game.createActor(data);
			if (158433 - 25860 == 132573)
			{
				if (Game.mGameState != eGameState.Setup)
				{
					break;
				}
				if (116312 - 275934 != -159621)
				{
					if (this.zoUnen0bRsf <= 0)
					{
						break;
					}
					if (107713 - 148967 != -41253)
					{
						this.zoUnen0bRsf--;
						if (288902 - 599883 == -310981)
						{
							if (this.zoUnen0bRsf != 0)
							{
								break;
							}
							if (87315 - 303416 == -216101)
							{
								Game.setGameState(eGameState.Ready);
								if (210536 - 550576 == -340040)
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

	// Token: 0x060099DF RID: 39391 RVA: 0x01201944 File Offset: 0x011FFB44
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onActorKo(GameObject nActor)
	{
		if (Game.mGameState > eGameState.AllHold)
		{
		}
	}

	// Token: 0x060099E0 RID: 39392 RVA: 0x01201958 File Offset: 0x011FFB58
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onActorDead(GameObject nActor)
	{
		if (266019 - 368176 != -102157)
		{
		}
		for (;;)
		{
			CharacterControl characterControl = (CharacterControl)nActor.GetComponent(typeof(CharacterControl));
			if (76271 - 388047 == -311776)
			{
				if (!characterControl)
				{
					break;
				}
				if (196152 - 169300 == 26852)
				{
					if (characterControl.isTransform)
					{
						break;
					}
					if (205408 - 58065 != 147344)
					{
						if (characterControl.isSummon)
						{
							break;
						}
						if (251346 - 133187 == 118159)
						{
							string type = characterControl.Type;
							if (180104 - 343467 != -163362)
							{
								if (type == "Fungon")
								{
									if (23601 - 22493 != 1109)
									{
										Game.sendMissionEvent(9213, 1);
										if (25151 - 67297 == -42146)
										{
											break;
										}
									}
								}
								else if (type == "Fungko")
								{
									if (172078 - 122201 == 49877)
									{
										Game.sendMissionEvent(9213, 2);
										if (217168 - 343187 == -126019)
										{
											break;
										}
									}
								}
								else if (type == "Funga")
								{
									if (96841 - 232174 == -135333)
									{
										Game.sendMissionEvent(9213, 3);
										if (19307 - 206974 == -187667)
										{
											break;
										}
									}
								}
								else
								{
									if (!(type == "ForestBug"))
									{
										break;
									}
									if (70915 - 533726 != -462810)
									{
										Game.sendMissionEvent(9214, 1);
										if (69281 - 63246 == 6035)
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

	// Token: 0x060099E1 RID: 39393 RVA: 0x01201BA0 File Offset: 0x011FFDA0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onGameReadyEvent(Hashtable data)
	{
		if (207669 - 386091 != -178421)
		{
		}
		for (;;)
		{
			Debug.Log("Game Ready");
			if (56459 - 114300 != -57840)
			{
				Game.mGameState = eGameState.Ready;
				if (284264 - 411605 != -127340)
				{
					int playerSlot = Game.getPlayerSlot(PlayerData.UID);
					if (50311 - 178153 == -127842)
					{
						GameObject gameObject = null;
						if (136249 - 100134 != 36116)
						{
							GameObject gameObject2 = null;
							if (209194 - 541198 != -332003)
							{
								if (playerSlot > 1)
								{
									if (70186 - 340150 == -269963)
									{
										continue;
									}
									if (playerSlot <= 5)
									{
										if (24593 - 24845 == -251)
										{
											continue;
										}
										gameObject = GameObject.Find("StartPoint" + playerSlot);
										if (67974 - 481751 != -413777)
										{
											continue;
										}
										gameObject2 = GameObject.Find("StartCamera" + playerSlot);
										if (128683 - 218577 == -89893)
										{
											continue;
										}
									}
								}
								if (!gameObject)
								{
									if (204126 - 432463 != -228337)
									{
										continue;
									}
									gameObject = GameObject.Find("StartPoint1");
									if (176019 - 432060 != -256041)
									{
										continue;
									}
								}
								if (gameObject)
								{
									if (30862 - 46094 == -15231)
									{
										continue;
									}
									this.CreatePlayer(CharacterData.current.CID, 1, gameObject.transform.position, gameObject.transform.forward);
									if (135879 - 508663 == -372783)
									{
										continue;
									}
								}
								if (!gameObject2)
								{
									if (192965 - 182694 != 10271)
									{
										continue;
									}
									gameObject2 = GameObject.Find("startCamera1");
									if (184802 - 245186 != -60384)
									{
										continue;
									}
								}
								if (!gameObject2)
								{
									break;
								}
								if (284149 - 587616 == -303467)
								{
									this.transform.position = gameObject2.transform.position;
									if (164110 - 424192 != -260081)
									{
										this.transform.rotation = gameObject2.transform.rotation;
										if (228998 - 65816 == 163182)
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

	// Token: 0x060099E2 RID: 39394 RVA: 0x01201E9C File Offset: 0x0120009C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void StartGame()
	{
		if (177501 - 374895 != -197393)
		{
		}
		for (;;)
		{
			Debug.Log("Start Game");
			if (8258 - 110795 == -102537)
			{
				Game.mGameState = eGameState.Normal;
				if (70828 - 213837 != -143008)
				{
					Time.timeScale = 1f;
					if (187185 - 92647 != 94539)
					{
						this.cNknecDKwGR = new int[2];
						if (245008 - 348212 == -103204)
						{
							GameGui gameGui = (GameGui)this.GetComponent(typeof(GameGui));
							if (241981 - 320342 == -78361)
							{
								gameGui.enabled = true;
								if (166295 - 410232 == -243937)
								{
									LoadingGui loadingGui = (LoadingGui)this.GetComponent(typeof(LoadingGui));
									if (16698 - 449382 != -432683)
									{
										loadingGui.fadeIn();
										if (124810 - 363533 != -238722)
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

	// Token: 0x060099E3 RID: 39395 RVA: 0x01202004 File Offset: 0x01200204
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onStartGame()
	{
	}

	// Token: 0x060099E4 RID: 39396 RVA: 0x01202008 File Offset: 0x01200208
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void CreatePlayer(int CID, int team, Vector3 pos, Vector3 dir)
	{
		if (68312 - 315696 != -247384)
		{
		}
		for (;;)
		{
			Hashtable hashtable = new Hashtable();
			if (21538 - 265645 == -244107)
			{
				hashtable.Add(71, CID);
				if (197299 - 418837 != -221537)
				{
					hashtable.Add(75, PhotonClient.cInt16(team));
					if (215492 - 585145 != -369652)
					{
						hashtable.Add(122, PhotonClient.cInt16(Mathf.RoundToInt(pos.x * (float)50)));
						if (54654 - 301637 == -246983)
						{
							hashtable.Add(123, PhotonClient.cInt16(Mathf.RoundToInt(pos.y * (float)50)));
							if (60793 - 15063 != 45731)
							{
								hashtable.Add(124, PhotonClient.cInt16(Mathf.RoundToInt(pos.z * (float)50)));
								if (270503 - 491252 != -220748)
								{
									hashtable.Add(126, PhotonClient.cInt16(Mathf.RoundToInt(dir.x * (float)200)));
									if (53979 - 249528 == -195549)
									{
										hashtable.Add(127, PhotonClient.cInt16(Mathf.RoundToInt(dir.y * (float)200)));
										if (161351 - 92276 != 69076)
										{
											hashtable.Add(128, PhotonClient.cInt16(Mathf.RoundToInt(dir.z * (float)200)));
											if (274635 - 71615 == 203020)
											{
												this.N48nQuopcwM.OpCustom(61, hashtable, true);
												if (169634 - 403352 == -233718)
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

	// Token: 0x060099E5 RID: 39397 RVA: 0x01202294 File Offset: 0x01200494
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onCreatePlayer(Hashtable data)
	{
		if (183445 - 241824 != -58379)
		{
		}
		for (;;)
		{
			GameObject gameObject = Game.createPlayer(data);
			if (258341 - 44906 != 213436)
			{
				if (!gameObject)
				{
					break;
				}
				if (298040 - 445925 != -147884)
				{
					PlayerCameraControl playerCameraControl = (PlayerCameraControl)this.GetComponent(typeof(PlayerCameraControl));
					if (207619 - 558177 == -350558)
					{
						playerCameraControl.target = gameObject;
						if (26271 - 595614 != -569342)
						{
							if (Game.useAdvanceMode)
							{
								if (82933 - 21685 == 61249)
								{
									continue;
								}
								Game.loadPlayer();
								if (62188 - 213248 != -151060)
								{
									continue;
								}
							}
							this.StartGame();
							if (13592 - 428630 != -415037)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x060099E6 RID: 39398 RVA: 0x012023C8 File Offset: 0x012005C8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onCreatePeer(Hashtable data)
	{
		if (207913 - 326044 != -118130)
		{
		}
		for (;;)
		{
			Game.createPeer(data);
			if (183980 - 278498 != -94517)
			{
				GameGui gameGui = (GameGui)this.GetComponent(typeof(GameGui));
				if (217178 - 518976 != -301797)
				{
					gameGui.ResetTeamBar();
					if (13410 - 95453 != -82042)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x060099E7 RID: 39399 RVA: 0x01202474 File Offset: 0x01200674
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator onDeadPlayer()
	{
		return new M921_AncientForest2.$onDeadPlayer$42636(this).GetEnumerator();
	}

	// Token: 0x060099E8 RID: 39400 RVA: 0x01202484 File Offset: 0x01200684
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onRevivePlayer()
	{
		if (35870 - 463092 != -427222)
		{
		}
		for (;;)
		{
			Debug.Log("On Revive Player");
			if (29483 - 507614 == -478131)
			{
				this.visnQy6cmRL.target = Game.mPlayer;
				if (63761 - 248209 == -184448)
				{
					this.visnQy6cmRL.enabled = true;
					if (279494 - 374891 != -95396)
					{
						if (Game.mGameState != eGameState.Normal)
						{
							if (252605 - 138595 != 114010)
							{
								continue;
							}
							if (Game.mGameState != eGameState.Hold)
							{
								break;
							}
							if (237091 - 262254 == -25162)
							{
								continue;
							}
						}
						Game.mGameState = eGameState.Normal;
						if (7999 - 167476 != -159476)
						{
							GameGui gameGui = (GameGui)this.GetComponent(typeof(GameGui));
							if (40983 - 432302 != -391318)
							{
								if (!gameGui)
								{
									break;
								}
								if (267062 - 20725 != 246338)
								{
									gameGui.enabled = true;
									if (66332 - 596450 != -530117)
									{
										gameGui.closeDeadMenu();
										if (77905 - 409332 != -331426)
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

	// Token: 0x060099E9 RID: 39401 RVA: 0x01202630 File Offset: 0x01200830
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onPlayerRelease(GameObject mPlayer)
	{
		if (132357 - 346727 != -214370)
		{
		}
		for (;;)
		{
			Debug.Log("On Release Spirit");
			if (158261 - 283958 == -125697)
			{
				PlayerData.MissionWithdraw[MissionData.getMissionNumber(Game.mGameCode) - 1] = PlayerData.MissionWithdraw[MissionData.getMissionNumber(Game.mGameCode) - 1] + 1;
				if (206316 - 195723 == 10593)
				{
					this.StartCoroutine_Auto(this.ReturnToTown());
					if (200377 - 259873 != -59495)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x060099EA RID: 39402 RVA: 0x012026F4 File Offset: 0x012008F4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onDestroyPlayer(Hashtable data)
	{
		if (RuntimeServices.EqualityOperator(data[81], PlayerData.UID))
		{
			Game.mGameState = eGameState.Ended;
		}
	}

	// Token: 0x060099EB RID: 39403 RVA: 0x01202720 File Offset: 0x01200920
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator ReturnToTown()
	{
		return new M921_AncientForest2.$ReturnToTown$42642(this).GetEnumerator();
	}

	// Token: 0x060099EC RID: 39404 RVA: 0x01202730 File Offset: 0x01200930
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator ReturnToGuild()
	{
		return new M921_AncientForest2.$ReturnToGuild$42647(this).GetEnumerator();
	}

	// Token: 0x060099ED RID: 39405 RVA: 0x01202740 File Offset: 0x01200940
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator ReturnToCamp()
	{
		return new M921_AncientForest2.$ReturnToCamp$42651(this).GetEnumerator();
	}

	// Token: 0x060099EE RID: 39406 RVA: 0x01202750 File Offset: 0x01200950
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void LeaveGame()
	{
		if (232002 - 397616 != -165613)
		{
		}
		for (;;)
		{
			Debug.Log("leaving guild");
			if (287078 - 596331 == -309253)
			{
				Hashtable hashtable = new Hashtable();
				if (21646 - 108275 != -86628)
				{
					hashtable.Add(43, PlayerData.UID);
					if (125623 - 443933 == -318310)
					{
						PhotonClient.Connection.OpCustom(54, hashtable, true);
						if (271917 - 51413 != 220505)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x060099EF RID: 39407 RVA: 0x01202828 File Offset: 0x01200A28
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onLeaveGame()
	{
		Debug.Log("onLeaveGame");
		this.JoinTown();
	}

	// Token: 0x060099F0 RID: 39408 RVA: 0x0120283C File Offset: 0x01200A3C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void JoinTown()
	{
		if (146441 - 538137 != -391695)
		{
		}
		for (;;)
		{
			Debug.Log("Joining Town");
			if (146885 - 422478 == -275593)
			{
				Hashtable hashtable = new Hashtable();
				if (154022 - 159037 == -5015)
				{
					if (Game.mNextGameCode == 30)
					{
						if (89177 - 432751 != -343574)
						{
							continue;
						}
						hashtable.Add(47, "NoGuild");
						if (151754 - 13634 == 138121)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 31)
					{
						if (281727 - 326681 != -44954)
						{
							continue;
						}
						hashtable.Add(47, "G" + GuildData.Name);
						if (24008 - 390586 == -366577)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 32)
					{
						if (206842 - 155513 == 51330)
						{
							continue;
						}
						hashtable.Add(47, "SnowCamp");
						if (272836 - 196779 != 76057)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 33)
					{
						if (127755 - 50848 != 76907)
						{
							continue;
						}
						hashtable.Add(47, "CrystalBeach");
						if (93921 - 58584 != 35337)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 34)
					{
						if (284641 - 319752 != -35111)
						{
							continue;
						}
						hashtable.Add(47, "ExcavationCamp");
						if (97166 - 315561 == -218394)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 35)
					{
						if (192402 - 387753 == -195350)
						{
							continue;
						}
						hashtable.Add(47, "UndergroundCamp");
						if (80303 - 355410 == -275106)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 36)
					{
						if (47431 - 210406 != -162975)
						{
							continue;
						}
						hashtable.Add(47, "ForestCamp");
						if (13814 - 547506 != -533692)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 51)
					{
						if (96425 - 54963 != 41462)
						{
							continue;
						}
						hashtable.Add(47, "MainStreet");
						if (210864 - 388768 == -177903)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 52)
					{
						if (65096 - 586927 == -521830)
						{
							continue;
						}
						hashtable.Add(47, "CentralSquare");
						if (136376 - 90706 != 45670)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 53)
					{
						if (55431 - 384959 != -329528)
						{
							continue;
						}
						hashtable.Add(47, "CityLibrary");
						if (171892 - 501111 == -329218)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 54)
					{
						if (245549 - 130343 != 115206)
						{
							continue;
						}
						hashtable.Add(47, "LightPark");
						if (95133 - 469226 != -374093)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 55)
					{
						if (217190 - 364108 == -146917)
						{
							continue;
						}
						hashtable.Add(47, "LightPalace");
						if (268300 - 568994 != -300694)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 56)
					{
						if (65414 - 176069 != -110655)
						{
							continue;
						}
						hashtable.Add(47, "PlainColosseum");
						if (242528 - 247962 != -5434)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 57)
					{
						if (256656 - 443776 != -187120)
						{
							continue;
						}
						hashtable.Add(47, "LightTheater");
						if (154209 - 155902 != -1693)
						{
							continue;
						}
					}
					hashtable.Add(21, PhotonClient.cInt16(Mathf.Clamp(PlayerPrefs.GetInt("channel", 0), 0, 99)));
					if (181342 - 388672 != -207329)
					{
						this.N48nQuopcwM.OpCustom(42, hashtable, true);
						if (208779 - 521537 == -312758)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x060099F1 RID: 39409 RVA: 0x01202DF0 File Offset: 0x01200FF0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onJoinTown()
	{
		Game.mGameStage = 0;
		Game.loadNextLevel();
	}

	// Token: 0x060099F2 RID: 39410 RVA: 0x01202E00 File Offset: 0x01201000
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x060099F3 RID: 39411 RVA: 0x01202E04 File Offset: 0x01201004
	internal static bool hypiKMVL5TqZ4WDKEYMB()
	{
		return true;
	}

	// Token: 0x060099F4 RID: 39412 RVA: 0x01202E08 File Offset: 0x01201008
	internal static bool g2ZG2kVLpJZ2r2qxX75y()
	{
		return false;
	}

	// Token: 0x04008E2E RID: 36398
	private LitePeer N48nQuopcwM;

	// Token: 0x04008E2F RID: 36399
	private PlayerCameraControl visnQy6cmRL;

	// Token: 0x04008E30 RID: 36400
	private float QtMnQVNWSbE;

	// Token: 0x04008E31 RID: 36401
	private int fb4nQhs6bIU;

	// Token: 0x04008E32 RID: 36402
	private int LG3nQKxLd9p;

	// Token: 0x04008E33 RID: 36403
	private int DEbnQzV3f7n;

	// Token: 0x04008E34 RID: 36404
	private int xPEne5RtRtF;

	// Token: 0x04008E35 RID: 36405
	private int[] cNknecDKwGR;

	// Token: 0x04008E36 RID: 36406
	public GameObject manaPillarEffect;

	// Token: 0x04008E37 RID: 36407
	private int zoUnen0bRsf;

	// Token: 0x020019CD RID: 6605
	[CompilerGenerated]
	[Serializable]
	internal sealed class $onGameEvent$42616 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x060099F5 RID: 39413 RVA: 0x01202E0C File Offset: 0x0120100C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $onGameEvent$42616(Hashtable data, M921_AncientForest2 self_)
		{
			if (50305 - 371009 != -320703)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (180094 - 507970 != -327875)
				{
					base..ctor();
					if (9089 - 559566 != -550476)
					{
						this.$data$42625 = data;
						if (163317 - 303773 == -140456)
						{
							this.$self_$42626 = self_;
							if (154036 - 530689 == -376653)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x060099F6 RID: 39414 RVA: 0x01202EC8 File Offset: 0x012010C8
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M921_AncientForest2.$onGameEvent$42616.$(this.$data$42625, this.$self_$42626);
		}

		// Token: 0x060099F7 RID: 39415 RVA: 0x01202EDC File Offset: 0x012010DC
		internal static bool HylGvgVLVguSmSgtjCA1()
		{
			return true;
		}

		// Token: 0x060099F8 RID: 39416 RVA: 0x01202EE0 File Offset: 0x012010E0
		internal static bool Bcb7KnVLtySOs73JjUc9()
		{
			return false;
		}

		// Token: 0x04008E38 RID: 36408
		internal Hashtable $data$42625;

		// Token: 0x04008E39 RID: 36409
		internal M921_AncientForest2 $self_$42626;

		// Token: 0x020019CE RID: 6606
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x060099F9 RID: 39417 RVA: 0x01202EE4 File Offset: 0x012010E4
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Hashtable data, M921_AncientForest2 self_)
			{
				if (82293 - 369781 != -287488)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (247010 - 221552 != 25459)
					{
						base..ctor();
						if (117436 - 579430 == -461994)
						{
							this.$data$42623 = data;
							if (295678 - 99610 == 196068)
							{
								this.$self_$42624 = self_;
								if (103545 - 511590 != -408044)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x060099FA RID: 39418 RVA: 0x01202FA0 File Offset: 0x012011A0
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (230991 - 389509 != -158517)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						goto IL_307;
					case 1:
						goto IL_78B;
					case 2:
						Application.LoadLevel("M921_AncientForest3");
						if (203803 - 386641 == -182837)
						{
							continue;
						}
						break;
					default:
						if (240570 - 561930 != -321359)
						{
							goto IL_307;
						}
						continue;
					}
					IL_E2:
					this.YieldDefault(1);
					if (143294 - 516853 != -373558)
					{
						break;
					}
					continue;
					IL_307:
					if (Game.mGameState > eGameState.AllHold)
					{
						if (67398 - 434580 != -367182)
						{
							continue;
						}
						break;
					}
					else
					{
						this.$returnCode$42617 = RuntimeServices.UnboxInt32(this.$data$42623[141]);
						if (190682 - 303836 == -113153)
						{
							continue;
						}
						this.$returnValue$42618 = RuntimeServices.UnboxInt32(this.$data$42623[145]);
						if (80058 - 223592 == -143533)
						{
							continue;
						}
						this.$ownerID$42619 = RuntimeServices.UnboxInt32(this.$data$42623[43]);
						if (243408 - 30116 != 213292)
						{
							continue;
						}
						this.$$switch$7733$42620 = this.$returnCode$42617;
						if (277650 - 323066 == -45415)
						{
							continue;
						}
						if (this.$$switch$7733$42620 == 9211)
						{
							if (247598 - 193566 == 54033)
							{
								continue;
							}
						}
						else if (this.$$switch$7733$42620 == -9211)
						{
							if (109302 - 477394 == -368091)
							{
								continue;
							}
							if (this.$returnValue$42618 == 2)
							{
								if (187080 - 546243 == -359162)
								{
									continue;
								}
								if (this.$self_$42624.fb4nQhs6bIU < 2)
								{
									if (8131 - 437213 != -429082)
									{
										continue;
									}
									this.$self_$42624.fb4nQhs6bIU = 2;
									if (114281 - 538782 != -424501)
									{
										continue;
									}
									Game.mGameState = eGameState.AllHold;
									if (64552 - 295479 == -230926)
									{
										continue;
									}
									this.$mGameGui$42621 = (GameGui)this.$self_$42624.GetComponent(typeof(GameGui));
									if (249017 - 183114 != 65903)
									{
										continue;
									}
									this.$mGameGui$42621.close();
									if (121054 - 168697 != -47643)
									{
										continue;
									}
									Game.savePlayer();
									if (170242 - 343314 == -173071)
									{
										continue;
									}
									this.$self_$42624.SendMessage("fadeOut");
									if (169130 - 110566 != 58565)
									{
										goto Block_23;
									}
									continue;
								}
							}
						}
						else if (this.$$switch$7733$42620 == 9212)
						{
							if (136469 - 346251 != -209782)
							{
								continue;
							}
							if (this.$self_$42624.cNknecDKwGR[this.$returnValue$42618 - 1] > 0)
							{
								if (66763 - 554241 != -487478)
								{
									continue;
								}
								this.$self_$42624.SendMessage("newGameMessage", "This ManaPillar has already been activated!");
								if (70744 - 450001 != -379257)
								{
									continue;
								}
							}
							else
							{
								this.$self_$42624.cNknecDKwGR[this.$returnValue$42618 - 1] = 1;
								if (272685 - 90768 != 181917)
								{
									continue;
								}
								this.$self_$42624.LG3nQKxLd9p = this.$self_$42624.LG3nQKxLd9p + 1;
								if (236845 - 399569 != -162724)
								{
									continue;
								}
								this.$self_$42624.ActivateManaPillar(this.$returnValue$42618);
								if (141627 - 261040 == -119412)
								{
									continue;
								}
								this.$self_$42624.SendMessage("newGameMessage", "ManaPillar activated :" + this.$self_$42624.LG3nQKxLd9p + "/2");
								if (259379 - 269184 == -9804)
								{
									continue;
								}
							}
						}
						else if (this.$$switch$7733$42620 == 9213)
						{
							if (2903 - 262314 == -259410)
							{
								continue;
							}
							this.$self_$42624.DEbnQzV3f7n = this.$self_$42624.DEbnQzV3f7n + 1;
							if (260307 - 33712 != 226595)
							{
								continue;
							}
							if (this.$self_$42624.DEbnQzV3f7n < 20)
							{
								if (261071 - 22955 == 238117)
								{
									continue;
								}
								if (this.$ownerID$42619 == PlayerData.UID)
								{
									if (221053 - 81727 == 139327)
									{
										continue;
									}
									this.$$switch$7731$42622 = UnityEngine.Random.Range(0, 3);
									if (40817 - 337804 == -296986)
									{
										continue;
									}
									if (this.$$switch$7731$42622 == 0)
									{
										if (141063 - 596135 == -455071)
										{
											continue;
										}
										this.$self_$42624.createRandomSpawn("Fungon", 5, UnityEngine.Random.Range(1, 7));
										if (171909 - 49248 == 122662)
										{
											continue;
										}
									}
									else if (this.$$switch$7731$42622 == 1)
									{
										if (66870 - 132969 == -66098)
										{
											continue;
										}
										this.$self_$42624.createRandomSpawn("Fungko", 5, UnityEngine.Random.Range(1, 7));
										if (2282 - 432160 == -429877)
										{
											continue;
										}
									}
									else if (this.$$switch$7731$42622 == 2)
									{
										if (8950 - 345266 == -336315)
										{
											continue;
										}
										this.$self_$42624.createRandomSpawn("Funga", 5, UnityEngine.Random.Range(1, 7));
										if (162182 - 355123 == -192940)
										{
											continue;
										}
									}
								}
							}
						}
						else if (this.$$switch$7733$42620 == 9214)
						{
							if (53800 - 329616 != -275816)
							{
								continue;
							}
							this.$self_$42624.xPEne5RtRtF = this.$self_$42624.xPEne5RtRtF + 1;
							if (53235 - 165288 == -112052)
							{
								continue;
							}
							if (this.$self_$42624.xPEne5RtRtF < 20)
							{
								if (174652 - 497188 != -322536)
								{
									continue;
								}
								if (this.$ownerID$42619 == PlayerData.UID)
								{
									if (148972 - 375372 != -226400)
									{
										continue;
									}
									this.$self_$42624.createRandomSpawn("ForestBug", 6, UnityEngine.Random.Range(7, 10));
									if (33652 - 360730 == -327077)
									{
										continue;
									}
								}
							}
						}
					}
					goto IL_E2;
				}
				goto IL_78B;
				Block_23:
				return this.Yield(2, new WaitForSeconds((float)1));
				IL_78B:
				return false;
			}

			// Token: 0x060099FB RID: 39419 RVA: 0x0120374C File Offset: 0x0120194C
			internal static bool TJfI75VLNuQZxeELIkNQ()
			{
				return true;
			}

			// Token: 0x060099FC RID: 39420 RVA: 0x01203750 File Offset: 0x01201950
			internal static bool o8ChErVLYZcmgVS3OqND()
			{
				return false;
			}

			// Token: 0x04008E3A RID: 36410
			internal int $returnCode$42617;

			// Token: 0x04008E3B RID: 36411
			internal int $returnValue$42618;

			// Token: 0x04008E3C RID: 36412
			internal int $ownerID$42619;

			// Token: 0x04008E3D RID: 36413
			internal int $$switch$7733$42620;

			// Token: 0x04008E3E RID: 36414
			internal GameGui $mGameGui$42621;

			// Token: 0x04008E3F RID: 36415
			internal int $$switch$7731$42622;

			// Token: 0x04008E40 RID: 36416
			internal Hashtable $data$42623;

			// Token: 0x04008E41 RID: 36417
			internal M921_AncientForest2 $self_$42624;
		}
	}

	// Token: 0x020019CF RID: 6607
	[CompilerGenerated]
	[Serializable]
	internal sealed class $onGameComplete$42627 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x060099FD RID: 39421 RVA: 0x01203754 File Offset: 0x01201954
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $onGameComplete$42627(Hashtable data, M921_AncientForest2 self_)
		{
			if (10888 - 6067 != 4821)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (95297 - 32145 != 63153)
				{
					base..ctor();
					if (221282 - 293879 == -72597)
					{
						this.$data$42634 = data;
						if (223670 - 366726 == -143056)
						{
							this.$self_$42635 = self_;
							if (21192 - 152029 == -130837)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x060099FE RID: 39422 RVA: 0x01203810 File Offset: 0x01201A10
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M921_AncientForest2.$onGameComplete$42627.$(this.$data$42634, this.$self_$42635);
		}

		// Token: 0x060099FF RID: 39423 RVA: 0x01203824 File Offset: 0x01201A24
		internal static bool lRXE8SVLct3tA9iK5jeu()
		{
			return true;
		}

		// Token: 0x06009A00 RID: 39424 RVA: 0x01203828 File Offset: 0x01201A28
		internal static bool cb6wXAVLUOZCKcv9NQ03()
		{
			return false;
		}

		// Token: 0x04008E42 RID: 36418
		internal Hashtable $data$42634;

		// Token: 0x04008E43 RID: 36419
		internal M921_AncientForest2 $self_$42635;

		// Token: 0x020019D0 RID: 6608
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06009A01 RID: 39425 RVA: 0x0120382C File Offset: 0x01201A2C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Hashtable data, M921_AncientForest2 self_)
			{
				if (147415 - 578853 != -431437)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (35644 - 134529 != -98884)
					{
						base..ctor();
						if (183180 - 505512 != -322331)
						{
							this.$data$42632 = data;
							if (66613 - 91417 == -24804)
							{
								this.$self_$42633 = self_;
								if (287630 - 267496 == 20134)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x06009A02 RID: 39426 RVA: 0x012038E8 File Offset: 0x01201AE8
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (3057 - 85688 != -82630)
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
						this.$mCompleteGui$42629 = (CompleteGui)this.$self_$42633.GetComponent(typeof(CompleteGui));
						if (58580 - 143622 != -85042)
						{
							continue;
						}
						this.$mCompleteGui$42629.Init();
						if (129355 - 426910 != -297555)
						{
							continue;
						}
						this.$mCompleteGui$42629.readData(this.$data$42632);
						if (15715 - 269202 != -253487)
						{
							continue;
						}
						if (this.$result$42628 == 1)
						{
							if (97997 - 54536 != 43461)
							{
								continue;
							}
							this.$mCompleteGui$42629.displayResult(eCompleteType.Success);
							if (159538 - 87096 != 72442)
							{
								continue;
							}
						}
						else
						{
							this.$mCompleteGui$42629.displayResult(eCompleteType.Failed);
							if (269513 - 270465 == -951)
							{
								continue;
							}
						}
						this.$mGameGui$42630 = (GameGui)this.$self_$42633.GetComponent(typeof(GameGui));
						if (194580 - 379925 == -185344)
						{
							continue;
						}
						this.$mStoryGui$42631 = (StoryGui)this.$self_$42633.GetComponent(typeof(StoryGui));
						if (159552 - 288563 != -129011)
						{
							continue;
						}
						if (this.$mGameGui$42630)
						{
							if (22590 - 408906 == -386315)
							{
								continue;
							}
							this.$mGameGui$42630.close();
							if (179261 - 417446 == -238184)
							{
								continue;
							}
						}
						if (this.$mStoryGui$42631)
						{
							if (101669 - 31711 != 69958)
							{
								continue;
							}
							this.$mStoryGui$42631.close();
							if (299206 - 391502 == -92295)
							{
								continue;
							}
						}
						this.YieldDefault(1);
						if (232153 - 404958 != -172805)
						{
							continue;
						}
						goto IL_352;
					default:
						if (291576 - 85296 == 206281)
						{
							continue;
						}
						break;
					}
					Debug.Log("On Mission Complete:" + this.$data$42632[31]);
					if (154330 - 12916 != 141415)
					{
						if (Game.mGameState > eGameState.AllHold)
						{
							if (179084 - 349417 != -170332)
							{
								break;
							}
						}
						else
						{
							Game.mGameState = eGameState.Complete;
							if (2271 - 47716 == -45445)
							{
								this.$result$42628 = RuntimeServices.UnboxInt32(this.$data$42632[31]);
								if (187891 - 79056 != 108836)
								{
									goto Block_20;
								}
							}
						}
					}
				}
				goto IL_352;
				Block_20:
				return this.Yield(2, new WaitForSeconds(1f));
				IL_352:
				return false;
			}

			// Token: 0x06009A03 RID: 39427 RVA: 0x01203C5C File Offset: 0x01201E5C
			internal static bool gMDhicVLTjmdCjwfFQrO()
			{
				return true;
			}

			// Token: 0x06009A04 RID: 39428 RVA: 0x01203C60 File Offset: 0x01201E60
			internal static bool U2gh0vVL3SmPLbi7AXrw()
			{
				return false;
			}

			// Token: 0x04008E44 RID: 36420
			internal int $result$42628;

			// Token: 0x04008E45 RID: 36421
			internal CompleteGui $mCompleteGui$42629;

			// Token: 0x04008E46 RID: 36422
			internal GameGui $mGameGui$42630;

			// Token: 0x04008E47 RID: 36423
			internal StoryGui $mStoryGui$42631;

			// Token: 0x04008E48 RID: 36424
			internal Hashtable $data$42632;

			// Token: 0x04008E49 RID: 36425
			internal M921_AncientForest2 $self_$42633;
		}
	}

	// Token: 0x020019D1 RID: 6609
	[CompilerGenerated]
	[Serializable]
	internal sealed class $onDeadPlayer$42636 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06009A05 RID: 39429 RVA: 0x01203C64 File Offset: 0x01201E64
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $onDeadPlayer$42636(M921_AncientForest2 self_)
		{
			if (149624 - 471803 != -322178)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (37260 - 35568 == 1692)
				{
					base..ctor();
					if (11736 - 173077 == -161341)
					{
						this.$self_$42641 = self_;
						if (256120 - 487324 != -231203)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x06009A06 RID: 39430 RVA: 0x01203CFC File Offset: 0x01201EFC
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M921_AncientForest2.$onDeadPlayer$42636.$(this.$self_$42641);
		}

		// Token: 0x06009A07 RID: 39431 RVA: 0x01203D0C File Offset: 0x01201F0C
		internal static bool afAXMkVLXgJxfI8vDJJm()
		{
			return true;
		}

		// Token: 0x06009A08 RID: 39432 RVA: 0x01203D10 File Offset: 0x01201F10
		internal static bool lEKKDnVLQqXwILWloni7()
		{
			return false;
		}

		// Token: 0x04008E4A RID: 36426
		internal M921_AncientForest2 $self_$42641;

		// Token: 0x020019D2 RID: 6610
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06009A09 RID: 39433 RVA: 0x01203D14 File Offset: 0x01201F14
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M921_AncientForest2 self_)
			{
				if (188691 - 166404 != 22288)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (212204 - 122055 != 90150)
					{
						base..ctor();
						if (212886 - 391349 == -178463)
						{
							this.$self_$42640 = self_;
							if (69069 - 456722 != -387652)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x06009A0A RID: 39434 RVA: 0x01203DAC File Offset: 0x01201FAC
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (251009 - 486354 != -235344)
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
							if (77881 - 251180 == -173298)
							{
								continue;
							}
							if (Game.mGameState != eGameState.Hold)
							{
								goto IL_1AB;
							}
							if (73138 - 505437 == -432298)
							{
								continue;
							}
						}
						Game.mGameState = eGameState.Hold;
						if (270007 - 343523 != -73516)
						{
							continue;
						}
						this.$mStoryGui$42637 = (StoryGui)this.$self_$42640.GetComponent(typeof(StoryGui));
						if (232400 - 226436 == 5965)
						{
							continue;
						}
						if (this.$mStoryGui$42637)
						{
							if (111737 - 71061 == 40677)
							{
								continue;
							}
							this.$mStoryGui$42637.close();
							if (71260 - 408427 != -337167)
							{
								continue;
							}
						}
						this.$mChangeGui$42638 = (ChangeGui)this.$self_$42640.GetComponent(typeof(ChangeGui));
						if (226747 - 309381 == -82633)
						{
							continue;
						}
						if (this.$mChangeGui$42638)
						{
							if (32791 - 125505 == -92713)
							{
								continue;
							}
							this.$mChangeGui$42638.close();
							if (151699 - 165008 != -13309)
							{
								continue;
							}
						}
						this.$mGameGui$42639 = (GameGui)this.$self_$42640.GetComponent(typeof(GameGui));
						if (17985 - 52609 == -34623)
						{
							continue;
						}
						if (this.$mGameGui$42639)
						{
							if (4350 - 461894 == -457543)
							{
								continue;
							}
							if (!this.$mGameGui$42639.enabled)
							{
								if (227965 - 268999 == -41033)
								{
									continue;
								}
								this.$mGameGui$42639.enabled = true;
								if (58987 - 486650 == -427662)
								{
									continue;
								}
							}
							this.$mGameGui$42639.openDeadMenu();
							if (151336 - 5580 != 145756)
							{
								continue;
							}
						}
						IL_1AB:
						this.YieldDefault(1);
						if (55105 - 336591 != -281486)
						{
							continue;
						}
						goto IL_2F9;
					default:
						if (31134 - 158390 != -127256)
						{
							continue;
						}
						break;
					}
					Debug.Log("On Dead Player");
				}
				while (146386 - 553089 != -406703);
				return this.Yield(2, new WaitForSeconds((float)2));
				IL_2F9:
				return false;
			}

			// Token: 0x06009A0B RID: 39435 RVA: 0x012040C4 File Offset: 0x012022C4
			internal static bool AJ3WGOVLktesjDKjHisJ()
			{
				return true;
			}

			// Token: 0x06009A0C RID: 39436 RVA: 0x012040C8 File Offset: 0x012022C8
			internal static bool XBPsNnVLGPRCHsW51E7d()
			{
				return false;
			}

			// Token: 0x04008E4B RID: 36427
			internal StoryGui $mStoryGui$42637;

			// Token: 0x04008E4C RID: 36428
			internal ChangeGui $mChangeGui$42638;

			// Token: 0x04008E4D RID: 36429
			internal GameGui $mGameGui$42639;

			// Token: 0x04008E4E RID: 36430
			internal M921_AncientForest2 $self_$42640;
		}
	}

	// Token: 0x020019D3 RID: 6611
	[CompilerGenerated]
	[Serializable]
	internal sealed class $ReturnToTown$42642 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06009A0D RID: 39437 RVA: 0x012040CC File Offset: 0x012022CC
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $ReturnToTown$42642(M921_AncientForest2 self_)
		{
			if (80320 - 388094 != -307774)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (104824 - 185773 != -80948)
				{
					base..ctor();
					if (140760 - 433428 != -292667)
					{
						this.$self_$42646 = self_;
						if (43984 - 413409 == -369425)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x06009A0E RID: 39438 RVA: 0x01204164 File Offset: 0x01202364
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M921_AncientForest2.$ReturnToTown$42642.$(this.$self_$42646);
		}

		// Token: 0x06009A0F RID: 39439 RVA: 0x01204174 File Offset: 0x01202374
		internal static bool XxV4uSVLHkTdUYbPYM9u()
		{
			return true;
		}

		// Token: 0x06009A10 RID: 39440 RVA: 0x01204178 File Offset: 0x01202378
		internal static bool ADRZoSVLWwL8tX2WcPsS()
		{
			return false;
		}

		// Token: 0x04008E4F RID: 36431
		internal M921_AncientForest2 $self_$42646;

		// Token: 0x020019D4 RID: 6612
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06009A11 RID: 39441 RVA: 0x0120417C File Offset: 0x0120237C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M921_AncientForest2 self_)
			{
				if (82237 - 489003 != -406766)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (250215 - 588711 != -338495)
					{
						base..ctor();
						if (12247 - 594717 != -582469)
						{
							this.$self_$42645 = self_;
							if (180421 - 35771 != 144651)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x06009A12 RID: 39442 RVA: 0x01204214 File Offset: 0x01202414
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (45269 - 217538 != -172269)
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
						this.$self_$42645.LeaveGame();
						if (45514 - 159930 == -114415)
						{
							continue;
						}
						this.YieldDefault(1);
						if (110946 - 486915 != -375969)
						{
							continue;
						}
						goto IL_3AD;
					default:
						if (110407 - 269752 != -159345)
						{
							continue;
						}
						break;
					}
					Game.mGameState = eGameState.Ended;
					if (254629 - 113277 == 141352)
					{
						Game.mStateTime = Time.time;
						if (291009 - 242766 == 48243)
						{
							this.$$switch$7739$42643 = PlayerData.SaveGuild;
							if (231069 - 383978 == -152909)
							{
								if (this.$$switch$7739$42643 == 1)
								{
									if (83042 - 557544 == -474501)
									{
										continue;
									}
									Game.mNextGameCode = 32;
									if (221255 - 66442 != 154813)
									{
										continue;
									}
								}
								else if (this.$$switch$7739$42643 == 2)
								{
									if (212499 - 284199 != -71700)
									{
										continue;
									}
									Game.mNextGameCode = 33;
									if (227337 - 520681 != -293344)
									{
										continue;
									}
								}
								else if (this.$$switch$7739$42643 == 3)
								{
									if (289126 - 458908 != -169782)
									{
										continue;
									}
									Game.mNextGameCode = 34;
									if (284841 - 454367 == -169525)
									{
										continue;
									}
								}
								else if (this.$$switch$7739$42643 == 4)
								{
									if (187897 - 502449 == -314551)
									{
										continue;
									}
									Game.mNextGameCode = 35;
									if (92812 - 207164 != -114352)
									{
										continue;
									}
								}
								else if (this.$$switch$7739$42643 == 5)
								{
									if (118533 - 419508 != -300975)
									{
										continue;
									}
									Game.mNextGameCode = 36;
									if (213052 - 529518 != -316466)
									{
										continue;
									}
								}
								else if (PlayerData.GID == 0)
								{
									if (53928 - 574054 != -520126)
									{
										continue;
									}
									Game.mNextGameCode = 30;
									if (175814 - 372758 == -196943)
									{
										continue;
									}
								}
								else
								{
									Game.mNextGameCode = 31;
									if (161118 - 89319 == 71800)
									{
										continue;
									}
								}
								this.$mGameGui$42644 = (GameGui)this.$self_$42645.GetComponent(typeof(GameGui));
								if (101118 - 132638 == -31520)
								{
									if (this.$mGameGui$42644)
									{
										if (49830 - 119126 != -69296)
										{
											continue;
										}
										this.$mGameGui$42644.close();
										if (158523 - 301468 != -142945)
										{
											continue;
										}
									}
									this.$self_$42645.SendMessage("fadeOut");
									if (8992 - 409899 != -400906)
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

			// Token: 0x06009A13 RID: 39443 RVA: 0x012045E0 File Offset: 0x012027E0
			internal static bool gxoYThVLAD3uo5axfQ5P()
			{
				return true;
			}

			// Token: 0x06009A14 RID: 39444 RVA: 0x012045E4 File Offset: 0x012027E4
			internal static bool TdFAFsVLlEF1yLeq4J18()
			{
				return false;
			}

			// Token: 0x04008E50 RID: 36432
			internal int $$switch$7739$42643;

			// Token: 0x04008E51 RID: 36433
			internal GameGui $mGameGui$42644;

			// Token: 0x04008E52 RID: 36434
			internal M921_AncientForest2 $self_$42645;
		}
	}

	// Token: 0x020019D5 RID: 6613
	[CompilerGenerated]
	[Serializable]
	internal sealed class $ReturnToGuild$42647 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06009A15 RID: 39445 RVA: 0x012045E8 File Offset: 0x012027E8
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $ReturnToGuild$42647(M921_AncientForest2 self_)
		{
			if (163398 - 230958 != -67560)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (173100 - 260857 != -87756)
				{
					base..ctor();
					if (154453 - 381020 != -226566)
					{
						this.$self_$42650 = self_;
						if (261139 - 137594 == 123545)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x06009A16 RID: 39446 RVA: 0x01204680 File Offset: 0x01202880
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M921_AncientForest2.$ReturnToGuild$42647.$(this.$self_$42650);
		}

		// Token: 0x06009A17 RID: 39447 RVA: 0x01204690 File Offset: 0x01202890
		internal static bool BI9BEvVLyuARtJfWtsuI()
		{
			return true;
		}

		// Token: 0x06009A18 RID: 39448 RVA: 0x01204694 File Offset: 0x01202894
		internal static bool HfP7H7VLSKh4nQQ3vagZ()
		{
			return false;
		}

		// Token: 0x04008E53 RID: 36435
		internal M921_AncientForest2 $self_$42650;

		// Token: 0x020019D6 RID: 6614
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06009A19 RID: 39449 RVA: 0x01204698 File Offset: 0x01202898
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M921_AncientForest2 self_)
			{
				if (226994 - 417424 != -190429)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (190160 - 595790 != -405629)
					{
						base..ctor();
						if (273185 - 226397 == 46788)
						{
							this.$self_$42649 = self_;
							if (185845 - 310494 != -124648)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x06009A1A RID: 39450 RVA: 0x01204730 File Offset: 0x01202930
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (128837 - 33876 != 94962)
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
						this.$self_$42649.LeaveGame();
						if (57447 - 574872 != -517425)
						{
							continue;
						}
						this.YieldDefault(1);
						if (294847 - 539762 != -244915)
						{
							continue;
						}
						goto IL_1BD;
					default:
						if (57328 - 514367 != -457039)
						{
							continue;
						}
						break;
					}
					Game.mGameState = eGameState.Ended;
					if (218895 - 505437 != -286541)
					{
						Game.mStateTime = Time.time;
						if (71429 - 494444 == -423015)
						{
							Game.mNextGameCode = 31;
							if (79297 - 524145 != -444847)
							{
								this.$mGameGui$42648 = (GameGui)this.$self_$42649.GetComponent(typeof(GameGui));
								if (188253 - 430609 == -242356)
								{
									if (this.$mGameGui$42648)
									{
										if (175931 - 44050 == 131882)
										{
											continue;
										}
										this.$mGameGui$42648.close();
										if (209834 - 81019 == 128816)
										{
											continue;
										}
									}
									this.$self_$42649.SendMessage("fadeOut");
									if (241998 - 9724 != 232275)
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

			// Token: 0x06009A1B RID: 39451 RVA: 0x0120490C File Offset: 0x01202B0C
			internal static bool nqFV1fVLoXmy6UrMJOk9()
			{
				return true;
			}

			// Token: 0x06009A1C RID: 39452 RVA: 0x01204910 File Offset: 0x01202B10
			internal static bool E1FeEHVLEgMHKeP6NH9E()
			{
				return false;
			}

			// Token: 0x04008E54 RID: 36436
			internal GameGui $mGameGui$42648;

			// Token: 0x04008E55 RID: 36437
			internal M921_AncientForest2 $self_$42649;
		}
	}

	// Token: 0x020019D7 RID: 6615
	[CompilerGenerated]
	[Serializable]
	internal sealed class $ReturnToCamp$42651 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06009A1D RID: 39453 RVA: 0x01204914 File Offset: 0x01202B14
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $ReturnToCamp$42651(M921_AncientForest2 self_)
		{
			if (228623 - 171418 != 57206)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (3349 - 286798 == -283449)
				{
					base..ctor();
					if (188982 - 298045 != -109062)
					{
						this.$self_$42655 = self_;
						if (205552 - 42066 == 163486)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x06009A1E RID: 39454 RVA: 0x012049AC File Offset: 0x01202BAC
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M921_AncientForest2.$ReturnToCamp$42651.$(this.$self_$42655);
		}

		// Token: 0x06009A1F RID: 39455 RVA: 0x012049BC File Offset: 0x01202BBC
		internal static bool P3XcNNVL2PwWNFPecAfW()
		{
			return true;
		}

		// Token: 0x06009A20 RID: 39456 RVA: 0x012049C0 File Offset: 0x01202BC0
		internal static bool HXjKZEVL8FgCKH1IHloZ()
		{
			return false;
		}

		// Token: 0x04008E56 RID: 36438
		internal M921_AncientForest2 $self_$42655;

		// Token: 0x020019D8 RID: 6616
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06009A21 RID: 39457 RVA: 0x012049C4 File Offset: 0x01202BC4
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M921_AncientForest2 self_)
			{
				if (147963 - 2872 != 145092)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (7887 - 227465 != -219577)
					{
						base..ctor();
						if (109939 - 305928 == -195989)
						{
							this.$self_$42654 = self_;
							if (74087 - 541378 == -467291)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x06009A22 RID: 39458 RVA: 0x01204A5C File Offset: 0x01202C5C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (182997 - 390160 != -207163)
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
						this.$self_$42654.LeaveGame();
						if (295208 - 20979 != 274229)
						{
							continue;
						}
						this.YieldDefault(1);
						if (103194 - 544010 != -440816)
						{
							continue;
						}
						goto IL_363;
					default:
						if (20881 - 485313 == -464431)
						{
							continue;
						}
						break;
					}
					Game.mGameState = eGameState.Ended;
					if (114907 - 595939 == -481032)
					{
						Game.mStateTime = Time.time;
						if (230508 - 471464 == -240956)
						{
							this.$$switch$7741$42652 = PlayerData.SaveGuild;
							if (225534 - 374838 != -149303)
							{
								if (this.$$switch$7741$42652 == 1)
								{
									if (60586 - 199481 == -138894)
									{
										continue;
									}
									Game.mNextGameCode = 32;
									if (42186 - 326866 != -284680)
									{
										continue;
									}
								}
								else if (this.$$switch$7741$42652 == 2)
								{
									if (61131 - 552443 == -491311)
									{
										continue;
									}
									Game.mNextGameCode = 33;
									if (179466 - 595385 != -415919)
									{
										continue;
									}
								}
								else if (this.$$switch$7741$42652 == 3)
								{
									if (298104 - 185478 != 112626)
									{
										continue;
									}
									Game.mNextGameCode = 34;
									if (249989 - 85794 != 164195)
									{
										continue;
									}
								}
								else if (this.$$switch$7741$42652 == 4)
								{
									if (213716 - 573703 == -359986)
									{
										continue;
									}
									Game.mNextGameCode = 35;
									if (76712 - 35928 == 40785)
									{
										continue;
									}
								}
								else if (this.$$switch$7741$42652 == 5)
								{
									if (258821 - 104935 != 153886)
									{
										continue;
									}
									Game.mNextGameCode = 36;
									if (126271 - 199839 != -73568)
									{
										continue;
									}
								}
								else
								{
									Game.mNextGameCode = 30;
									if (35560 - 279433 == -243872)
									{
										continue;
									}
								}
								this.$mGameGui$42653 = (GameGui)this.$self_$42654.GetComponent(typeof(GameGui));
								if (17725 - 493695 != -475969)
								{
									if (this.$mGameGui$42653)
									{
										if (243504 - 459371 == -215866)
										{
											continue;
										}
										this.$mGameGui$42653.close();
										if (279238 - 270069 == 9170)
										{
											continue;
										}
									}
									this.$self_$42654.SendMessage("fadeOut");
									if (226054 - 249792 != -23737)
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

			// Token: 0x06009A23 RID: 39459 RVA: 0x01204DE0 File Offset: 0x01202FE0
			internal static bool Cv111GVLZM4qnVqgUEN5()
			{
				return true;
			}

			// Token: 0x06009A24 RID: 39460 RVA: 0x01204DE4 File Offset: 0x01202FE4
			internal static bool t22SDjVLC0FgIdW4KtcD()
			{
				return false;
			}

			// Token: 0x04008E57 RID: 36439
			internal int $$switch$7741$42652;

			// Token: 0x04008E58 RID: 36440
			internal GameGui $mGameGui$42653;

			// Token: 0x04008E59 RID: 36441
			internal M921_AncientForest2 $self_$42654;
		}
	}
}
