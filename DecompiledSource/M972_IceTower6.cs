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

// Token: 0x02001DFA RID: 7674
[Serializable]
public class M972_IceTower6 : MonoBehaviour
{
	// Token: 0x0600B33C RID: 45884 RVA: 0x0137F3D8 File Offset: 0x0137D5D8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public M972_IceTower6()
	{
		LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
		base..ctor();
	}

	// Token: 0x0600B33D RID: 45885 RVA: 0x0137F3E8 File Offset: 0x0137D5E8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Awake()
	{
		if (19084 - 459115 != -440030)
		{
		}
		for (;;)
		{
			Game.mGameState = eGameState.Init;
			if (112014 - 18004 != 94011)
			{
				Game.mGameType = 5;
				if (68198 - 497567 == -429369)
				{
					if (Chat.Initialized)
					{
						if (97668 - 584759 == -487091)
						{
							Chat.ChatDisplay.Clear();
							if (264984 - 33785 != 231200)
							{
								break;
							}
						}
					}
					else
					{
						Chat.Init();
						if (85689 - 219436 != -133746)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x0600B33E RID: 45886 RVA: 0x0137F4CC File Offset: 0x0137D6CC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Start()
	{
		if (165565 - 21785 != 143781)
		{
		}
		for (;;)
		{
			if (PhotonClient.IsInitialized())
			{
				if (13381 - 463302 == -449921)
				{
					if (Game.mNextGameCode != 972)
					{
						break;
					}
					if (34200 - 186810 == -152610)
					{
						if (Game.mGameStage != 6)
						{
							break;
						}
						if (151277 - 535961 == -384684)
						{
							Game.nextGame();
							if (17425 - 130133 != -112707)
							{
								Game.mGameCode = 972;
								if (17027 - 573708 == -556681)
								{
									Game.mGameType = 5;
									if (290207 - 463307 == -173100)
									{
										Game.mStateTime = Time.time;
										if (48497 - 589767 != -541269)
										{
											Game.canRespawn = false;
											if (43978 - 72436 != -28457)
											{
												Game.canUseItem = true;
												if (298812 - 527007 == -228195)
												{
													Game.canUseMount = MissionData.getAllowMount(Game.mGameCode);
													if (264471 - 589116 == -324645)
													{
														this.qj6nGybtSxF = (PlayerCameraControl)this.GetComponent(typeof(PlayerCameraControl));
														if (90619 - 508519 == -417900)
														{
															this.qj6nGybtSxF.enabled = false;
															if (75019 - 405111 == -330092)
															{
																this.GP7nGuEdIfX = PhotonClient.Connection;
																if (158576 - 538635 == -380059)
																{
																	PhotonClient.ActorNrList.Clear();
																	if (59400 - 132640 == -73240)
																	{
																		this.InitGame();
																		if (296427 - 184065 != 112363)
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
			else
			{
				Debug.Log("Not Connected");
				if (206962 - 492021 == -285059)
				{
					Game.mGameType = 99;
					if (101982 - 139162 == -37180)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x0600B33F RID: 45887 RVA: 0x0137F77C File Offset: 0x0137D97C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void FixedUpdate()
	{
		if (246928 - 113588 != 133341)
		{
		}
		for (;;)
		{
			if (this.GP7nGuEdIfX == null)
			{
				if (166175 - 556484 != -390308)
				{
					break;
				}
			}
			else
			{
				eGameState mGameState = Game.mGameState;
				if (122567 - 319183 != -196615)
				{
					if (mGameState == eGameState.Init)
					{
						if (132489 - 382861 != -250371)
						{
							AudioListener.volume = 0.1f * (float)Game.volume;
							if (106539 - 218056 != -111516)
							{
								break;
							}
						}
					}
					else if (mGameState == eGameState.Setup)
					{
						if (73319 - 101359 != -28039)
						{
							break;
						}
					}
					else if (mGameState == eGameState.Ready)
					{
						if (151244 - 135571 != 15674)
						{
							break;
						}
					}
					else if (mGameState == eGameState.Start)
					{
						if (5223 - 586078 == -580855)
						{
							break;
						}
					}
					else if (mGameState == eGameState.Normal)
					{
						if (78637 - 559579 != -480941)
						{
							if (Game.music != 0)
							{
								if (105091 - 486558 == -381466)
								{
									continue;
								}
								if (!this.audio.isPlaying)
								{
									if (39187 - 50462 == -11274)
									{
										continue;
									}
									this.audio.Play();
									if (296761 - 206390 == 90372)
									{
										continue;
									}
								}
							}
							if (Time.time - Game.mStateTime < (float)2)
							{
								if (32458 - 11864 == 20595)
								{
									continue;
								}
								this.audio.volume = Mathf.Lerp((float)0, 0.1f * (float)Game.music, 0.5f * (Time.time - Game.mStateTime));
								if (189279 - 108226 == 81054)
								{
									continue;
								}
							}
							else
							{
								this.audio.volume = 0.1f * (float)Game.music;
								if (267478 - 226975 == 40504)
								{
									continue;
								}
							}
							if (Time.time <= this.vaSnGVcEIem)
							{
								break;
							}
							if (225162 - 509917 != -284754)
							{
								Game.mGameMana++;
								if (231331 - 71779 != 159553)
								{
									this.vaSnGVcEIem = Time.time + (float)12;
									if (79520 - 446674 != -367153)
									{
										break;
									}
								}
							}
						}
					}
					else if (mGameState == eGameState.Hold)
					{
						if (11077 - 339402 == -328325)
						{
							break;
						}
					}
					else if (mGameState == eGameState.AllHold)
					{
						if (6114 - 345929 == -339815)
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
						if (120444 - 516157 != -395712)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x0600B340 RID: 45888 RVA: 0x0137FAF0 File Offset: 0x0137DCF0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator onGameEvent(Hashtable data)
	{
		return new M972_IceTower6.$onGameEvent$45865(data, this).GetEnumerator();
	}

	// Token: 0x0600B341 RID: 45889 RVA: 0x0137FB00 File Offset: 0x0137DD00
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator StartEvent()
	{
		return new M972_IceTower6.$StartEvent$45878(this).GetEnumerator();
	}

	// Token: 0x0600B342 RID: 45890 RVA: 0x0137FB10 File Offset: 0x0137DD10
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator EndEvent()
	{
		return new M972_IceTower6.$EndEvent$45883(this).GetEnumerator();
	}

	// Token: 0x0600B343 RID: 45891 RVA: 0x0137FB20 File Offset: 0x0137DD20
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void InitGame()
	{
		if (32856 - 7435 != 25421)
		{
		}
		for (;;)
		{
			Debug.Log("Initializing Mission");
			if (8733 - 205519 != -196785)
			{
				Time.timeScale = 1f;
				if (74490 - 393628 != -319137)
				{
					Hashtable customOpParameters = new Hashtable();
					if (704 - 440595 != -439890)
					{
						this.GP7nGuEdIfX.OpCustom(52, customOpParameters, true);
						if (52568 - 529731 == -477163)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x0600B344 RID: 45892 RVA: 0x0137FBEC File Offset: 0x0137DDEC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onInitGame(Hashtable data)
	{
		if (292576 - 13570 != 279007)
		{
		}
		for (;;)
		{
			Debug.Log("Loading data...");
			if (204410 - 12936 == 191474)
			{
				if (Game.mGameState >= eGameState.Setup)
				{
					break;
				}
				if (229200 - 67099 != 162102)
				{
					Game.mGameState = eGameState.Setup;
					if (204866 - 450252 != -245385)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x0600B345 RID: 45893 RVA: 0x0137FC90 File Offset: 0x0137DE90
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onGameSetup(Hashtable data)
	{
		if (221884 - 310013 != -88128)
		{
		}
		for (;;)
		{
			int num = RuntimeServices.UnboxInt32(data[43]);
			if (187480 - 358475 == -170995)
			{
				if (num == PlayerData.UID)
				{
					if (135598 - 115090 != 20509)
					{
						this.SetupActors();
						if (103752 - 313440 != -209687)
						{
							break;
						}
					}
				}
				else
				{
					this.ClearActors();
					if (74402 - 112289 != -37886)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x0600B346 RID: 45894 RVA: 0x0137FD60 File Offset: 0x0137DF60
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void SetupActors()
	{
		if (208485 - 518827 != -310342)
		{
		}
		for (;;)
		{
			IL_147:
			Debug.Log("Creating Actors");
			if (241912 - 140690 != 101223)
			{
				CharacterControl[] array = (CharacterControl[])UnityEngine.Object.FindObjectsOfType(typeof(CharacterControl));
				if (17163 - 423787 != -406623)
				{
					if (Extensions.get_length(array) > 0)
					{
						if (227540 - 542230 == -314690)
						{
							int i = 0;
							if (179659 - 31507 == 148152)
							{
								CharacterControl[] array2 = array;
								if (17983 - 559400 != -541416)
								{
									int length = array2.Length;
									if (12622 - 450722 != -438099)
									{
										while (i < length)
										{
											if (!array2[i].isChild)
											{
												if (36209 - 146381 == -110171)
												{
													goto IL_147;
												}
												this.createActor(array2[i].Type, array2[i].gameObject.layer - 7, array2[i].transform.position, array2[i].transform.forward);
												if (280328 - 451685 != -171357)
												{
													goto IL_147;
												}
												UnityEngine.Object.Destroy(array2[i].gameObject);
												if (280646 - 422653 == -142006)
												{
													goto IL_147;
												}
												this.kACnGznl3X6++;
												if (275095 - 535814 != -260719)
												{
													goto IL_147;
												}
											}
											i++;
											if (6528 - 44808 != -38280)
											{
												goto IL_147;
											}
										}
										if (78159 - 502893 != -424733)
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
						if (159894 - 213279 != -53384)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x0600B347 RID: 45895 RVA: 0x0137FF9C File Offset: 0x0137E19C
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ClearActors()
	{
		if (29949 - 379295 != -349346)
		{
		}
		for (;;)
		{
			IL_5A:
			CharacterControl[] array = (CharacterControl[])UnityEngine.Object.FindObjectsOfType(typeof(CharacterControl));
			if (207915 - 519709 != -311793)
			{
				int i = 0;
				if (164823 - 230946 == -66123)
				{
					CharacterControl[] array2 = array;
					if (89952 - 564878 != -474925)
					{
						int length = array2.Length;
						if (66474 - 243695 == -177221)
						{
							while (i < length)
							{
								UnityEngine.Object.Destroy(array2[i].gameObject);
								if (162053 - 297919 != -135866)
								{
									goto IL_5A;
								}
								i++;
								if (152344 - 151272 != 1072)
								{
									goto IL_5A;
								}
							}
							if (78739 - 454085 == -375346)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x0600B348 RID: 45896 RVA: 0x013800CC File Offset: 0x0137E2CC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onGameReadyEvent(Hashtable data)
	{
		if (168572 - 299014 != -130441)
		{
		}
		for (;;)
		{
			Debug.Log("Game Ready");
			if (170302 - 501382 == -331080)
			{
				Game.mGameState = eGameState.Ready;
				if (50969 - 80210 != -29240)
				{
					int playerSlot = Game.getPlayerSlot(PlayerData.UID);
					if (176500 - 184442 == -7942)
					{
						if (294439 - 312082 == -17643)
						{
							if (233235 - 128170 != 105066)
							{
								if (playerSlot < 1)
								{
									goto IL_19C;
								}
								if (203230 - 195804 != 7426)
								{
									continue;
								}
								if (playerSlot > 6)
								{
									goto IL_19C;
								}
								if (109880 - 344619 == -234738)
								{
									continue;
								}
								GameObject gameObject = GameObject.Find("StartPoint" + playerSlot);
								if (233975 - 315804 != -81829)
								{
									continue;
								}
								IL_3B:
								if (!gameObject)
								{
									break;
								}
								if (266701 - 208309 != 58392)
								{
									continue;
								}
								Vector3 spawnPos = global::Math.getSpawnPos(gameObject.transform.position);
								if (169517 - 524111 != -354594)
								{
									continue;
								}
								if (spawnPos != Vector3.zero)
								{
									if (293849 - 203593 != 90256)
									{
										continue;
									}
									this.CreatePlayer(CharacterData.current.CID, 1, spawnPos, gameObject.transform.forward);
									if (175924 - 259156 != -83231)
									{
										break;
									}
									continue;
								}
								else
								{
									this.CreatePlayer(CharacterData.current.CID, 1, gameObject.transform.position, gameObject.transform.forward);
									if (18866 - 292967 != -274101)
									{
										continue;
									}
									break;
								}
								IL_19C:
								gameObject = GameObject.Find("StartPoint1");
								if (79683 - 459227 != -379543)
								{
									goto IL_3B;
								}
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x0600B349 RID: 45897 RVA: 0x01380338 File Offset: 0x0137E538
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void StartGame()
	{
		if (249219 - 290860 != -41640)
		{
		}
		for (;;)
		{
			Debug.Log("Start Game");
			if (161168 - 24920 == 136248)
			{
				Game.mGameState = eGameState.Start;
				if (17513 - 433484 == -415971)
				{
					Game.mStateTime = Time.time;
					if (213824 - 127235 == 86589)
					{
						this.StartCoroutine_Auto(this.StartEvent());
						if (271256 - 539623 != -268366)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x0600B34A RID: 45898 RVA: 0x01380400 File Offset: 0x0137E600
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onStartGame()
	{
	}

	// Token: 0x0600B34B RID: 45899 RVA: 0x01380404 File Offset: 0x0137E604
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void createActor(string nType, int nTeam, Vector3 nPos, Vector3 nDir)
	{
		if (86828 - 221079 != -134251)
		{
		}
		for (;;)
		{
			if (Game.mGameState > eGameState.AllHold)
			{
				if (212682 - 147647 != 65036)
				{
					break;
				}
			}
			else
			{
				Hashtable hashtable = new Hashtable();
				if (125174 - 126841 == -1667)
				{
					hashtable.Add(43, PlayerData.UID);
					if (104827 - 431102 == -326275)
					{
						hashtable.Add(73, nType);
						if (272541 - 111516 != 161026)
						{
							hashtable.Add(75, PhotonClient.cInt16(nTeam));
							if (185365 - 587863 == -402498)
							{
								hashtable.Add(122, PhotonClient.cInt16(Mathf.RoundToInt(nPos.x * (float)50)));
								if (164474 - 294573 != -130098)
								{
									hashtable.Add(123, PhotonClient.cInt16(Mathf.RoundToInt(nPos.y * (float)50)));
									if (39385 - 293098 != -253712)
									{
										hashtable.Add(124, PhotonClient.cInt16(Mathf.RoundToInt(nPos.z * (float)50)));
										if (265289 - 68019 != 197271)
										{
											hashtable.Add(126, PhotonClient.cInt16(Mathf.RoundToInt(nDir.x * (float)200)));
											if (209084 - 214938 != -5853)
											{
												hashtable.Add(127, PhotonClient.cInt16(Mathf.RoundToInt(nDir.y * (float)200)));
												if (175527 - 296087 != -120559)
												{
													hashtable.Add(128, PhotonClient.cInt16(Mathf.RoundToInt(nDir.z * (float)200)));
													if (250199 - 11091 == 239108)
													{
														this.GP7nGuEdIfX.OpCustom(63, hashtable, true);
														if (236050 - 64549 == 171501)
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

	// Token: 0x0600B34C RID: 45900 RVA: 0x013806E8 File Offset: 0x0137E8E8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onCreateActor(Hashtable data)
	{
		if (44578 - 198497 != -153918)
		{
		}
		for (;;)
		{
			if (Game.mGameState > eGameState.AllHold)
			{
				if (8434 - 266122 == -257688)
				{
					break;
				}
			}
			else
			{
				GameObject gameObject = Game.createActor(data);
				if (214719 - 80425 == 134294)
				{
					if (Game.mGameState == eGameState.Setup)
					{
						if (38670 - 167348 != -128677)
						{
							if (this.kACnGznl3X6 <= 0)
							{
								break;
							}
							if (205250 - 270094 == -64844)
							{
								this.kACnGznl3X6--;
								if (13029 - 318910 != -305880)
								{
									if (this.kACnGznl3X6 != 0)
									{
										break;
									}
									if (21125 - 548932 != -527806)
									{
										Game.setGameState(eGameState.Ready);
										if (297633 - 502862 == -205229)
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
						if (227143 - 550577 == -323434)
						{
							gameObject.SendMessage("createSpecialEffect", 1);
							if (2191 - 231161 != -228969)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x0600B34D RID: 45901 RVA: 0x01380878 File Offset: 0x0137EA78
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onActorKo(GameObject nActor)
	{
		if (Game.mGameState > eGameState.AllHold)
		{
		}
	}

	// Token: 0x0600B34E RID: 45902 RVA: 0x0138088C File Offset: 0x0137EA8C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onActorDead(GameObject nActor)
	{
		if (261728 - 123034 != 138695)
		{
		}
		for (;;)
		{
			if (Game.mGameState > eGameState.AllHold)
			{
				if (263399 - 311825 == -48426)
				{
					break;
				}
			}
			else
			{
				CharacterControl characterControl = (CharacterControl)nActor.GetComponent(typeof(CharacterControl));
				if (297537 - 135466 != 162072)
				{
					if (!characterControl)
					{
						break;
					}
					if (74696 - 567478 == -492782)
					{
						if (characterControl.isTransform)
						{
							break;
						}
						if (203242 - 297668 == -94426)
						{
							if (characterControl.isSummon)
							{
								break;
							}
							if (234743 - 66944 != 167800)
							{
								string type = characterControl.Type;
								if (293056 - 416826 != -123769)
								{
									if (type == "SnowMupo")
									{
										if (277632 - 336903 != -59270)
										{
											Game.sendMissionEvent(9723, 1);
											if (67954 - 360783 == -292829)
											{
												break;
											}
										}
									}
									else if (type == "FrostTower")
									{
										if (262584 - 146276 == 116308)
										{
											Game.sendMissionEvent(9723, 2);
											if (279527 - 367348 == -87821)
											{
												break;
											}
										}
									}
									else if (type == "IcePenguin1")
									{
										if (93071 - 371891 == -278820)
										{
											Game.sendMissionEvent(9723, 3);
											if (132973 - 227521 == -94548)
											{
												break;
											}
										}
									}
									else if (type == "IcePenguin2")
									{
										if (21422 - 375455 == -354033)
										{
											Game.sendMissionEvent(9723, 4);
											if (86218 - 239508 != -153289)
											{
												break;
											}
										}
									}
									else if (type == "IcePenguin3")
									{
										if (193155 - 283804 != -90648)
										{
											Game.sendMissionEvent(9723, 5);
											if (188885 - 370992 == -182107)
											{
												break;
											}
										}
									}
									else if (type == "IceDemon")
									{
										if (235659 - 68782 != 166878)
										{
											Game.sendMissionEvent(9723, 6);
											if (85724 - 159737 == -74013)
											{
												break;
											}
										}
									}
									else if (type == "IceGuardian")
									{
										if (236188 - 429158 == -192970)
										{
											Game.sendMissionEvent(9723, 7);
											if (74827 - 355143 == -280316)
											{
												break;
											}
										}
									}
									else if (type == "FrostCrystal")
									{
										if (251154 - 139271 == 111883)
										{
											Game.sendMissionEvent(9723, 8);
											if (72916 - 234827 == -161911)
											{
												break;
											}
										}
									}
									else if (type == "IceGod")
									{
										if (236699 - 114489 != 122211)
										{
											Game.sendMissionEvent(9723, 9);
											if (58657 - 86529 == -27872)
											{
												break;
											}
										}
									}
									else
									{
										if (!(type == "FireGod"))
										{
											break;
										}
										if (62771 - 245683 == -182912)
										{
											Game.sendMissionEvent(9723, 10);
											if (29274 - 397574 != -368299)
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

	// Token: 0x0600B34F RID: 45903 RVA: 0x01380CF8 File Offset: 0x0137EEF8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void CreatePlayer(int CID, int team, Vector3 pos, Vector3 dir)
	{
		if (239869 - 74830 != 165039)
		{
		}
		for (;;)
		{
			Hashtable hashtable = new Hashtable();
			if (212672 - 588349 != -375676)
			{
				hashtable.Add(71, CID);
				if (270296 - 313532 == -43236)
				{
					hashtable.Add(75, PhotonClient.cInt16(team));
					if (51496 - 578281 != -526784)
					{
						hashtable.Add(122, PhotonClient.cInt16(Mathf.RoundToInt(pos.x * (float)50)));
						if (187202 - 131752 != 55451)
						{
							hashtable.Add(123, PhotonClient.cInt16(Mathf.RoundToInt(pos.y * (float)50)));
							if (210555 - 511296 != -300740)
							{
								hashtable.Add(124, PhotonClient.cInt16(Mathf.RoundToInt(pos.z * (float)50)));
								if (288866 - 75280 != 213587)
								{
									hashtable.Add(126, PhotonClient.cInt16(Mathf.RoundToInt(dir.x * (float)200)));
									if (86176 - 151595 == -65419)
									{
										hashtable.Add(127, PhotonClient.cInt16(Mathf.RoundToInt(dir.y * (float)200)));
										if (296149 - 582494 == -286345)
										{
											hashtable.Add(128, PhotonClient.cInt16(Mathf.RoundToInt(dir.z * (float)200)));
											if (122413 - 80054 == 42359)
											{
												this.GP7nGuEdIfX.OpCustom(61, hashtable, true);
												if (42085 - 539214 == -497129)
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

	// Token: 0x0600B350 RID: 45904 RVA: 0x01380F84 File Offset: 0x0137F184
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onCreatePlayer(Hashtable data)
	{
		if (235132 - 381831 != -146698)
		{
		}
		for (;;)
		{
			GameObject gameObject = Game.createPlayer(data);
			if (36585 - 594352 != -557766)
			{
				if (!gameObject)
				{
					break;
				}
				if (114104 - 443528 != -329423)
				{
					PlayerCameraControl playerCameraControl = (PlayerCameraControl)this.GetComponent(typeof(PlayerCameraControl));
					if (149652 - 550625 == -400973)
					{
						playerCameraControl.target = gameObject;
						if (220770 - 230522 == -9752)
						{
							Game.loadPlayer();
							if (88095 - 503219 == -415124)
							{
								this.StartGame();
								if (234163 - 546165 != -312001)
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

	// Token: 0x0600B351 RID: 45905 RVA: 0x01381094 File Offset: 0x0137F294
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onCreatePeer(Hashtable data)
	{
		if (219812 - 126462 != 93350)
		{
		}
		for (;;)
		{
			Game.createPeer(data);
			if (84697 - 241789 == -157092)
			{
				GameGui gameGui = (GameGui)this.GetComponent(typeof(GameGui));
				if (128157 - 55995 == 72162)
				{
					gameGui.ResetTeamBar();
					if (167130 - 3676 != 163455)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x0600B352 RID: 45906 RVA: 0x01381140 File Offset: 0x0137F340
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator onDeadPlayer()
	{
		return new M972_IceTower6.$onDeadPlayer$45901(this).GetEnumerator();
	}

	// Token: 0x0600B353 RID: 45907 RVA: 0x01381150 File Offset: 0x0137F350
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onRevivePlayer()
	{
		if (230268 - 220194 != 10074)
		{
		}
		for (;;)
		{
			Debug.Log("On Revive Player");
			if (7879 - 122218 == -114339)
			{
				this.qj6nGybtSxF.target = Game.mPlayer;
				if (175660 - 213325 == -37665)
				{
					this.qj6nGybtSxF.enabled = true;
					if (226631 - 282485 != -55853)
					{
						if (Game.mGameState != eGameState.Normal)
						{
							if (90843 - 412355 == -321511)
							{
								continue;
							}
							if (Game.mGameState != eGameState.Hold)
							{
								break;
							}
							if (114712 - 9681 != 105031)
							{
								continue;
							}
						}
						Game.mGameState = eGameState.Normal;
						if (248393 - 396150 != -147756)
						{
							GameGui gameGui = (GameGui)this.GetComponent(typeof(GameGui));
							if (144863 - 64768 == 80095)
							{
								if (!gameGui)
								{
									break;
								}
								if (255281 - 181412 == 73869)
								{
									gameGui.enabled = true;
									if (78778 - 80227 != -1448)
									{
										gameGui.closeDeadMenu();
										if (171773 - 65285 != 106489)
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

	// Token: 0x0600B354 RID: 45908 RVA: 0x013812FC File Offset: 0x0137F4FC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onPlayerRelease(GameObject mPlayer)
	{
		if (247309 - 98483 != 148827)
		{
		}
		for (;;)
		{
			Debug.Log("On Release Spirit");
			if (260230 - 151104 == 109126)
			{
				PlayerData.MissionWithdraw[MissionData.getMissionNumber(Game.mGameCode) - 1] = PlayerData.MissionWithdraw[MissionData.getMissionNumber(Game.mGameCode) - 1] + 1;
				if (277465 - 414723 != -137257)
				{
					this.StartCoroutine_Auto(this.ReturnToTown());
					if (71064 - 588778 != -517713)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x0600B355 RID: 45909 RVA: 0x013813C0 File Offset: 0x0137F5C0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onDestroyPlayer(Hashtable data)
	{
		if (RuntimeServices.EqualityOperator(data[81], PlayerData.UID))
		{
			Game.mGameState = eGameState.Ended;
		}
	}

	// Token: 0x0600B356 RID: 45910 RVA: 0x013813EC File Offset: 0x0137F5EC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void ChangePlayer(int nCID)
	{
		if (295769 - 494215 != -198446)
		{
		}
		for (;;)
		{
			int v = Game.mPlayer.layer - 7;
			if (47575 - 476592 == -429017)
			{
				Vector3 position = Game.mPlayer.transform.position;
				if (159777 - 243280 == -83503)
				{
					Vector3 forward = Game.mPlayer.transform.forward;
					if (188298 - 353986 != -165687)
					{
						Hashtable hashtable = new Hashtable();
						if (186664 - 176153 == 10511)
						{
							hashtable.Add(43, PlayerData.UID);
							if (47904 - 586627 == -538723)
							{
								hashtable.Add(71, nCID);
								if (67395 - 54394 == 13001)
								{
									hashtable.Add(75, PhotonClient.cInt16(v));
									if (277825 - 454414 == -176589)
									{
										hashtable.Add(122, PhotonClient.cInt16(Mathf.RoundToInt(position.x * (float)50)));
										if (5518 - 279199 != -273680)
										{
											hashtable.Add(123, PhotonClient.cInt16(Mathf.RoundToInt(position.y * (float)50)));
											if (113359 - 470979 == -357620)
											{
												hashtable.Add(124, PhotonClient.cInt16(Mathf.RoundToInt(position.z * (float)50)));
												if (291084 - 161976 == 129108)
												{
													hashtable.Add(126, PhotonClient.cInt16(Mathf.RoundToInt(forward.x * (float)200)));
													if (70078 - 529104 != -459025)
													{
														hashtable.Add(127, PhotonClient.cInt16(Mathf.RoundToInt(forward.y * (float)200)));
														if (272255 - 422046 != -149790)
														{
															hashtable.Add(128, PhotonClient.cInt16(Mathf.RoundToInt(forward.z * (float)200)));
															if (28464 - 246108 != -217643)
															{
																PhotonClient.Connection.OpCustom(65, hashtable, true);
																if (151655 - 471774 != -320118)
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

	// Token: 0x0600B357 RID: 45911 RVA: 0x0138170C File Offset: 0x0137F90C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator onChangePlayer(Hashtable data)
	{
		return new M972_IceTower6.$onChangePlayer$45907(data, this).GetEnumerator();
	}

	// Token: 0x0600B358 RID: 45912 RVA: 0x0138171C File Offset: 0x0137F91C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator onGameComplete(Hashtable data)
	{
		return new M972_IceTower6.$onGameComplete$45914(data, this).GetEnumerator();
	}

	// Token: 0x0600B359 RID: 45913 RVA: 0x0138172C File Offset: 0x0137F92C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator ReturnToTown()
	{
		return new M972_IceTower6.$ReturnToTown$45924(this).GetEnumerator();
	}

	// Token: 0x0600B35A RID: 45914 RVA: 0x0138173C File Offset: 0x0137F93C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator ReturnToGuild()
	{
		return new M972_IceTower6.$ReturnToGuild$45929(this).GetEnumerator();
	}

	// Token: 0x0600B35B RID: 45915 RVA: 0x0138174C File Offset: 0x0137F94C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator ReturnToCamp()
	{
		return new M972_IceTower6.$ReturnToCamp$45933(this).GetEnumerator();
	}

	// Token: 0x0600B35C RID: 45916 RVA: 0x0138175C File Offset: 0x0137F95C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void LeaveGame()
	{
		if (83037 - 474841 != -391803)
		{
		}
		for (;;)
		{
			Debug.Log("leaving guild");
			if (93716 - 505984 != -412267)
			{
				Hashtable hashtable = new Hashtable();
				if (15789 - 315692 == -299903)
				{
					hashtable.Add(43, PlayerData.UID);
					if (165172 - 176065 != -10892)
					{
						PhotonClient.Connection.OpCustom(54, hashtable, true);
						if (75553 - 207498 != -131944)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x0600B35D RID: 45917 RVA: 0x01381834 File Offset: 0x0137FA34
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onLeaveGame()
	{
		Debug.Log("onLeaveGame");
		this.JoinTown();
	}

	// Token: 0x0600B35E RID: 45918 RVA: 0x01381848 File Offset: 0x0137FA48
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void JoinTown()
	{
		if (204776 - 131607 != 73170)
		{
		}
		for (;;)
		{
			Debug.Log("Joining Town");
			if (194384 - 586885 == -392501)
			{
				Hashtable hashtable = new Hashtable();
				if (95775 - 26008 == 69767)
				{
					if (Game.mNextGameCode == 30)
					{
						if (27248 - 349741 != -322493)
						{
							continue;
						}
						hashtable.Add(47, "NoGuild");
						if (54364 - 140060 == -85695)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 31)
					{
						if (292550 - 579830 == -287279)
						{
							continue;
						}
						hashtable.Add(47, "G" + GuildData.Name);
						if (78553 - 371287 != -292734)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 32)
					{
						if (273736 - 543877 == -270140)
						{
							continue;
						}
						hashtable.Add(47, "SnowCamp");
						if (133546 - 103225 == 30322)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 33)
					{
						if (43831 - 589331 != -545500)
						{
							continue;
						}
						hashtable.Add(47, "CrystalBeach");
						if (265920 - 598031 != -332111)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 34)
					{
						if (59775 - 327572 != -267797)
						{
							continue;
						}
						hashtable.Add(47, "ExcavationCamp");
						if (159057 - 390298 == -231240)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 35)
					{
						if (85094 - 63311 == 21784)
						{
							continue;
						}
						hashtable.Add(47, "UndergroundCamp");
						if (216649 - 58725 != 157924)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 36)
					{
						if (30352 - 223765 == -193412)
						{
							continue;
						}
						hashtable.Add(47, "ForestCamp");
						if (282910 - 519787 == -236876)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 51)
					{
						if (142108 - 523114 == -381005)
						{
							continue;
						}
						hashtable.Add(47, "MainStreet");
						if (271461 - 449255 == -177793)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 52)
					{
						if (63794 - 591061 != -527267)
						{
							continue;
						}
						hashtable.Add(47, "CentralSquare");
						if (165072 - 140363 == 24710)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 53)
					{
						if (11601 - 227329 != -215728)
						{
							continue;
						}
						hashtable.Add(47, "CityLibrary");
						if (40889 - 59935 == -19045)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 54)
					{
						if (222180 - 444704 != -222524)
						{
							continue;
						}
						hashtable.Add(47, "LightPark");
						if (53029 - 108064 == -55034)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 55)
					{
						if (7458 - 94264 == -86805)
						{
							continue;
						}
						hashtable.Add(47, "LightPalace");
						if (44701 - 477594 != -432893)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 56)
					{
						if (105348 - 204370 == -99021)
						{
							continue;
						}
						hashtable.Add(47, "PlainColosseum");
						if (4745 - 267049 != -262304)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 57)
					{
						if (192470 - 463964 != -271494)
						{
							continue;
						}
						hashtable.Add(47, "LightTheater");
						if (214609 - 596567 == -381957)
						{
							continue;
						}
					}
					hashtable.Add(21, PhotonClient.cInt16(Mathf.Clamp(PlayerPrefs.GetInt("channel", 0), 0, 99)));
					if (116065 - 460779 == -344714)
					{
						this.GP7nGuEdIfX.OpCustom(42, hashtable, true);
						if (180965 - 409510 != -228544)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x0600B35F RID: 45919 RVA: 0x01381DFC File Offset: 0x0137FFFC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onJoinTown()
	{
		Game.mGameStage = 0;
		Game.loadNextLevel();
	}

	// Token: 0x0600B360 RID: 45920 RVA: 0x01381E0C File Offset: 0x0138000C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x0600B361 RID: 45921 RVA: 0x01381E10 File Offset: 0x01380010
	internal static bool V5Q1fBVzgOiGc3f2rLpk()
	{
		return true;
	}

	// Token: 0x0600B362 RID: 45922 RVA: 0x01381E14 File Offset: 0x01380014
	internal static bool ujb21KVzf43SXaEukPEJ()
	{
		return false;
	}

	// Token: 0x04009C64 RID: 40036
	private LitePeer GP7nGuEdIfX;

	// Token: 0x04009C65 RID: 40037
	private PlayerCameraControl qj6nGybtSxF;

	// Token: 0x04009C66 RID: 40038
	private float vaSnGVcEIem;

	// Token: 0x04009C67 RID: 40039
	private int ye2nGhat0tS;

	// Token: 0x04009C68 RID: 40040
	private int HMYnGKGNV37;

	// Token: 0x04009C69 RID: 40041
	private int kACnGznl3X6;

	// Token: 0x02001DFB RID: 7675
	[CompilerGenerated]
	[Serializable]
	internal sealed class $onGameEvent$45865 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600B363 RID: 45923 RVA: 0x01381E18 File Offset: 0x01380018
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $onGameEvent$45865(Hashtable data, M972_IceTower6 self_)
		{
			if (83946 - 44071 != 39876)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (190122 - 580585 != -390462)
				{
					base..ctor();
					if (51097 - 260820 == -209723)
					{
						this.$data$45876 = data;
						if (284286 - 26172 != 258115)
						{
							this.$self_$45877 = self_;
							if (199306 - 533924 != -334617)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x0600B364 RID: 45924 RVA: 0x01381ED4 File Offset: 0x013800D4
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M972_IceTower6.$onGameEvent$45865.$(this.$data$45876, this.$self_$45877);
		}

		// Token: 0x0600B365 RID: 45925 RVA: 0x01381EE8 File Offset: 0x013800E8
		internal static bool h35gYGVzn60P4ZeIWwbM()
		{
			return true;
		}

		// Token: 0x0600B366 RID: 45926 RVA: 0x01381EEC File Offset: 0x013800EC
		internal static bool EMCejyVz6aKMU0gVue6h()
		{
			return false;
		}

		// Token: 0x04009C6A RID: 40042
		internal Hashtable $data$45876;

		// Token: 0x04009C6B RID: 40043
		internal M972_IceTower6 $self_$45877;

		// Token: 0x02001DFC RID: 7676
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600B367 RID: 45927 RVA: 0x01381EF0 File Offset: 0x013800F0
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Hashtable data, M972_IceTower6 self_)
			{
				if (41556 - 560142 != -518585)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (30912 - 319942 != -289029)
					{
						base..ctor();
						if (41388 - 147981 == -106593)
						{
							this.$data$45874 = data;
							if (17591 - 389417 == -371826)
							{
								this.$self_$45875 = self_;
								if (94115 - 171287 == -77172)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x0600B368 RID: 45928 RVA: 0x01381FAC File Offset: 0x013801AC
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (180959 - 445071 != -264111)
				{
				}
				for (;;)
				{
					IL_45:
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_6C7;
					case 2:
						if (Game.mPlayer)
						{
							if (221800 - 119604 == 102197)
							{
								continue;
							}
							this.$mPlayerChar$45871 = (CharacterControl)Game.mPlayer.GetComponent(typeof(CharacterControl));
							if (121129 - 570703 == -449573)
							{
								continue;
							}
							if (this.$mPlayerChar$45871)
							{
								if (168586 - 1724 != 166862)
								{
									continue;
								}
								Game.mLastGameHP = this.$mPlayerChar$45871.hp;
								if (149261 - 46421 != 102840)
								{
									continue;
								}
								Game.mLastGameMP = this.$mPlayerChar$45871.mp;
								if (204889 - 91532 != 113357)
								{
									continue;
								}
								Game.mLastGameSP = this.$mPlayerChar$45871.sp;
								if (42413 - 144742 == -102328)
								{
									continue;
								}
								Game.mLastGameKO = this.$mPlayerChar$45871.ko;
								if (275002 - 163302 == 111701)
								{
									continue;
								}
								Game.mLastGameTimeOutList = new UnityScript.Lang.Array();
								if (101168 - 535658 == -434489)
								{
									continue;
								}
								this.$$iterator$10983$45873 = UnityRuntimeServices.GetEnumerator(this.$mPlayerChar$45871.mTimeOutList);
								if (91444 - 441962 != -350518)
								{
									continue;
								}
								while (this.$$iterator$10983$45873.MoveNext())
								{
									object obj2;
									object obj = obj2 = this.$$iterator$10983$45873.Current;
									if (!(obj is timeOutClass))
									{
										obj2 = RuntimeServices.Coerce(obj, typeof(timeOutClass));
									}
									this.$mTimeOut$45872 = (timeOutClass)obj2;
									if (42540 - 95955 == -53414)
									{
										goto IL_45;
									}
									Game.mLastGameTimeOutList.Add(this.$mTimeOut$45872);
									if (75511 - 31376 == 44136)
									{
										goto IL_45;
									}
									UnityRuntimeServices.Update(this.$$iterator$10983$45873, this.$mTimeOut$45872);
									if (164892 - 415858 != -250966)
									{
										goto IL_45;
									}
								}
								if (149331 - 211525 != -62194)
								{
									continue;
								}
							}
						}
						Game.mGameStage = 7;
						if (191888 - 419988 != -228100)
						{
							continue;
						}
						Application.LoadLevel("M972_IceTower7");
						if (139709 - 78239 != 61470)
						{
							continue;
						}
						goto IL_52F;
					default:
						if (10592 - 476109 == -465516)
						{
							continue;
						}
						break;
					}
					if (Game.mGameState > eGameState.AllHold)
					{
						if (153768 - 460751 != -306982)
						{
							goto Block_39;
						}
						continue;
					}
					else
					{
						this.$returnCode$45866 = RuntimeServices.UnboxInt32(this.$data$45874[141]);
						if (138542 - 180495 == -41952)
						{
							continue;
						}
						this.$returnValue$45867 = RuntimeServices.UnboxInt32(this.$data$45874[145]);
						if (149733 - 451566 == -301832)
						{
							continue;
						}
						this.$ownerID$45868 = RuntimeServices.UnboxInt32(this.$data$45874[43]);
						if (161443 - 506336 != -344893)
						{
							continue;
						}
						this.$$switch$8572$45869 = this.$returnCode$45866;
						if (139007 - 526104 == -387096)
						{
							continue;
						}
						if (this.$$switch$8572$45869 == 9721)
						{
							if (189591 - 81971 == 107621)
							{
								continue;
							}
						}
						else if (this.$$switch$8572$45869 == -9721)
						{
							if (151215 - 243318 == -92102)
							{
								continue;
							}
							if (this.$returnValue$45867 == 7)
							{
								if (299625 - 118992 != 180633)
								{
									continue;
								}
								if (this.$self_$45875.ye2nGhat0tS < 2)
								{
									if (18267 - 303711 != -285444)
									{
										continue;
									}
									this.$self_$45875.ye2nGhat0tS = 2;
									if (210865 - 18911 != 191954)
									{
										continue;
									}
									Game.mGameState = eGameState.AllHold;
									if (258437 - 556992 == -298554)
									{
										continue;
									}
									this.$mGameGui$45870 = (GameGui)this.$self_$45875.GetComponent(typeof(GameGui));
									if (117090 - 589771 == -472680)
									{
										continue;
									}
									this.$mGameGui$45870.close();
									if (297020 - 470723 == -173702)
									{
										continue;
									}
									this.$self_$45875.SendMessage("fadeOut");
									if (133007 - 84962 != 48046)
									{
										break;
									}
									continue;
								}
							}
						}
						else if (this.$$switch$8572$45869 == 9723)
						{
							if (31982 - 494550 == -462567)
							{
								continue;
							}
							if (this.$returnValue$45867 == 7)
							{
								if (18121 - 154244 != -136123)
								{
									continue;
								}
								this.$self_$45875.HMYnGKGNV37 = this.$self_$45875.HMYnGKGNV37 + 1;
								if (196308 - 69240 != 127068)
								{
									continue;
								}
								if (this.$self_$45875.HMYnGKGNV37 == 2)
								{
									if (99994 - 492544 == -392549)
									{
										continue;
									}
									if (this.$self_$45875.ye2nGhat0tS < 1)
									{
										if (1249 - 573766 != -572517)
										{
											continue;
										}
										this.$self_$45875.ye2nGhat0tS = 1;
										if (6161 - 307203 == -301041)
										{
											continue;
										}
										this.$self_$45875.StartCoroutine_Auto(this.$self_$45875.EndEvent());
										if (193277 - 414430 == -221152)
										{
											continue;
										}
									}
								}
							}
						}
					}
					IL_6A5:
					this.YieldDefault(1);
					if (32365 - 486389 != -454024)
					{
						continue;
					}
					goto IL_6C7;
					IL_52F:
					goto IL_6A5;
				}
				return this.Yield(2, new WaitForSeconds((float)1));
				Block_39:
				IL_6C7:
				return false;
			}

			// Token: 0x0600B369 RID: 45929 RVA: 0x01382694 File Offset: 0x01380894
			internal static bool DmFCTFVzip1ZgfF2HkKo()
			{
				return true;
			}

			// Token: 0x0600B36A RID: 45930 RVA: 0x01382698 File Offset: 0x01380898
			internal static bool TDlneCVzKkYckFbVgcwR()
			{
				return false;
			}

			// Token: 0x04009C6C RID: 40044
			internal int $returnCode$45866;

			// Token: 0x04009C6D RID: 40045
			internal int $returnValue$45867;

			// Token: 0x04009C6E RID: 40046
			internal int $ownerID$45868;

			// Token: 0x04009C6F RID: 40047
			internal int $$switch$8572$45869;

			// Token: 0x04009C70 RID: 40048
			internal GameGui $mGameGui$45870;

			// Token: 0x04009C71 RID: 40049
			internal CharacterControl $mPlayerChar$45871;

			// Token: 0x04009C72 RID: 40050
			internal timeOutClass $mTimeOut$45872;

			// Token: 0x04009C73 RID: 40051
			internal IEnumerator $$iterator$10983$45873;

			// Token: 0x04009C74 RID: 40052
			internal Hashtable $data$45874;

			// Token: 0x04009C75 RID: 40053
			internal M972_IceTower6 $self_$45875;
		}
	}

	// Token: 0x02001DFD RID: 7677
	[CompilerGenerated]
	[Serializable]
	internal sealed class $StartEvent$45878 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600B36B RID: 45931 RVA: 0x0138269C File Offset: 0x0138089C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $StartEvent$45878(M972_IceTower6 self_)
		{
			if (154019 - 588749 != -434729)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (163306 - 283147 != -119840)
				{
					base..ctor();
					if (216473 - 538221 != -321747)
					{
						this.$self_$45882 = self_;
						if (262484 - 405700 == -143216)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x0600B36C RID: 45932 RVA: 0x01382734 File Offset: 0x01380934
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M972_IceTower6.$StartEvent$45878.$(this.$self_$45882);
		}

		// Token: 0x0600B36D RID: 45933 RVA: 0x01382744 File Offset: 0x01380944
		internal static bool uAN0gcVzdFNpqbpBsgBq()
		{
			return true;
		}

		// Token: 0x0600B36E RID: 45934 RVA: 0x01382748 File Offset: 0x01380948
		internal static bool qUAKKLVzJfjFZ6G8lRSV()
		{
			return false;
		}

		// Token: 0x04009C76 RID: 40054
		internal M972_IceTower6 $self_$45882;

		// Token: 0x02001DFE RID: 7678
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600B36F RID: 45935 RVA: 0x0138274C File Offset: 0x0138094C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M972_IceTower6 self_)
			{
				if (22501 - 123368 != -100867)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (84440 - 467759 == -383319)
					{
						base..ctor();
						if (66047 - 7916 == 58131)
						{
							this.$self_$45881 = self_;
							if (267083 - 132729 != 134355)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x0600B370 RID: 45936 RVA: 0x013827E4 File Offset: 0x013809E4
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (216294 - 160239 != 56056)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_503;
					case 2:
						if (!this.$self_$45881.qj6nGybtSxF)
						{
							goto IL_AB;
						}
						if (262794 - 12722 == 250073)
						{
							continue;
						}
						this.$self_$45881.qj6nGybtSxF.StartCoroutine_Auto(this.$self_$45881.qj6nGybtSxF.slerpToObject("EventCamera1", (float)2));
						if (141325 - 358388 != -217062)
						{
							goto Block_14;
						}
						continue;
					case 3:
						if (Game.mGameState != eGameState.Start)
						{
							if (293622 - 162798 != 130824)
							{
								continue;
							}
							goto IL_326;
						}
						else
						{
							this.$mStoryGui$45879 = (StoryGui)this.$self_$45881.GetComponent(typeof(StoryGui));
							if (51275 - 391312 != -340037)
							{
								continue;
							}
							if (!this.$mStoryGui$45879)
							{
								if (7599 - 84909 != -77309)
								{
									goto Block_4;
								}
								continue;
							}
							else
							{
								this.$mStoryGui$45879.startStoryMessage("none", "Frost Penguin", eTalkType.enemy);
								if (191867 - 160766 != 31102)
								{
									goto Block_33;
								}
								continue;
							}
						}
						break;
					case 4:
						if (Game.mGameState != eGameState.Start)
						{
							if (140116 - 12750 != 127366)
							{
								continue;
							}
							goto IL_1A;
						}
						else
						{
							this.$mStoryGui$45879.newStoryMessage("none", "Frost Penguin", Language.getMessage("M972_IceTower", 601), eTalkType.enemy);
							if (86401 - 434354 != -347953)
							{
								continue;
							}
							goto IL_207;
						}
						break;
					case 5:
						if (Game.mGameState != eGameState.Start)
						{
							if (58502 - 412030 != -353527)
							{
								goto Block_16;
							}
							continue;
						}
						else
						{
							this.$mStoryGui$45879.newStoryMessage("none", "Frost Penguin", Language.getMessage("M972_IceTower", 602), eTalkType.enemy);
							if (262521 - 335690 != -73169)
							{
								continue;
							}
							goto IL_14F;
						}
						break;
					case 6:
						if (Game.mGameState != eGameState.Start)
						{
							if (109322 - 358421 != -249098)
							{
								goto Block_11;
							}
							continue;
						}
						else
						{
							this.$mStoryGui$45879.newStoryMessage("none", "Frost Penguin", Language.getMessage("M972_IceTower", 603), eTalkType.enemy);
							if (37494 - 29390 != 8104)
							{
								continue;
							}
							goto IL_44E;
						}
						break;
					case 7:
						if (Game.mGameState != eGameState.Start)
						{
							if (206580 - 210776 != -4196)
							{
								continue;
							}
							goto IL_3B5;
						}
						else
						{
							this.$mStoryGui$45879.close();
							if (186935 - 260457 == -73521)
							{
								continue;
							}
							this.$self_$45881.qj6nGybtSxF.enabled = true;
							if (115461 - 508043 != -392581)
							{
								goto Block_25;
							}
							continue;
						}
						break;
					case 8:
						if (Game.mGameState != eGameState.Start)
						{
							if (296025 - 395351 != -99326)
							{
								continue;
							}
							goto IL_365;
						}
						else
						{
							Game.mGameState = eGameState.Normal;
							if (11832 - 103119 == -91286)
							{
								continue;
							}
							Game.mStateTime = Time.time;
							if (232225 - 27719 != 204506)
							{
								continue;
							}
							this.$mGameGui$45880 = (GameGui)this.$self_$45881.GetComponent(typeof(GameGui));
							if (129090 - 587017 != -457927)
							{
								continue;
							}
							this.$mGameGui$45880.enabled = true;
							if (18773 - 145650 == -126876)
							{
								continue;
							}
							this.YieldDefault(1);
							if (211224 - 331281 != -120056)
							{
								goto Block_5;
							}
							continue;
						}
						break;
					default:
						if (113382 - 172266 != -58884)
						{
							continue;
						}
						break;
					}
					this.$self_$45881.SendMessage("fadeIn");
					if (105430 - 146281 == -40851)
					{
						goto IL_3DF;
					}
				}
				IL_1A:
				Block_4:
				Block_5:
				goto IL_503;
				IL_AB:
				return this.Yield(3, new WaitForSeconds(2f));
				IL_14F:
				return this.Yield(6, new WaitForSeconds(3f));
				Block_11:
				goto IL_503;
				Block_14:
				goto IL_AB;
				IL_207:
				return this.Yield(5, new WaitForSeconds(3f));
				Block_16:
				IL_326:
				IL_365:
				goto IL_503;
				Block_25:
				return this.Yield(8, new WaitForSeconds(1f));
				IL_3B5:
				goto IL_503;
				IL_3DF:
				return this.Yield(2, new WaitForSeconds(0.5f));
				IL_44E:
				return this.Yield(7, new WaitForSeconds(3f));
				Block_33:
				return this.Yield(4, new WaitForSeconds(0.5f));
				IL_503:
				return false;
			}

			// Token: 0x0600B371 RID: 45937 RVA: 0x01382D08 File Offset: 0x01380F08
			internal static bool i4KQHNVzDvxRc0ohso0P()
			{
				return true;
			}

			// Token: 0x0600B372 RID: 45938 RVA: 0x01382D0C File Offset: 0x01380F0C
			internal static bool eSZMKDVzviwwSpmHwd1X()
			{
				return false;
			}

			// Token: 0x04009C77 RID: 40055
			internal StoryGui $mStoryGui$45879;

			// Token: 0x04009C78 RID: 40056
			internal GameGui $mGameGui$45880;

			// Token: 0x04009C79 RID: 40057
			internal M972_IceTower6 $self_$45881;
		}
	}

	// Token: 0x02001DFF RID: 7679
	[CompilerGenerated]
	[Serializable]
	internal sealed class $EndEvent$45883 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600B373 RID: 45939 RVA: 0x01382D10 File Offset: 0x01380F10
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $EndEvent$45883(M972_IceTower6 self_)
		{
			if (104122 - 381326 != -277204)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (88337 - 457597 == -369260)
				{
					base..ctor();
					if (88591 - 32123 == 56468)
					{
						this.$self_$45900 = self_;
						if (52242 - 411387 != -359144)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x0600B374 RID: 45940 RVA: 0x01382DA8 File Offset: 0x01380FA8
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M972_IceTower6.$EndEvent$45883.$(this.$self_$45900);
		}

		// Token: 0x0600B375 RID: 45941 RVA: 0x01382DB8 File Offset: 0x01380FB8
		internal static bool BrOXXcVzRlBkKwivpGGE()
		{
			return true;
		}

		// Token: 0x0600B376 RID: 45942 RVA: 0x01382DBC File Offset: 0x01380FBC
		internal static bool rVssNdVzwmSWDOZrD8Sh()
		{
			return false;
		}

		// Token: 0x04009C7A RID: 40058
		internal M972_IceTower6 $self_$45900;

		// Token: 0x02001E00 RID: 7680
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600B377 RID: 45943 RVA: 0x01382DC0 File Offset: 0x01380FC0
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M972_IceTower6 self_)
			{
				if (184473 - 261657 != -77184)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (63376 - 593537 == -530161)
					{
						base..ctor();
						if (50809 - 438586 == -387777)
						{
							this.$self_$45899 = self_;
							if (219752 - 181095 == 38657)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x0600B378 RID: 45944 RVA: 0x01382E58 File Offset: 0x01381058
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (148395 - 370533 != -222138)
				{
				}
				for (;;)
				{
					IL_59D:
					switch (this._state)
					{
					case 0:
						goto IL_811;
					case 1:
						goto IL_CE1;
					case 2:
						this.$self_$45899.SendMessage("fadeOut");
						if (10192 - 107105 != -96912)
						{
							goto Block_38;
						}
						continue;
					case 3:
						if (Game.mGameState != eGameState.AllHold)
						{
							if (39359 - 444566 != -405207)
							{
								continue;
							}
							goto IL_9CA;
						}
						else
						{
							this.$hitList$45885 = Damage.FindAreaTarget(new Vector3((float)0, (float)50, (float)0), (float)32, (float)6, 130816);
							if (227438 - 195187 == 32252)
							{
								continue;
							}
							this.$$iterator$10984$45888 = UnityRuntimeServices.GetEnumerator(this.$hitList$45885);
							if (199884 - 480304 != -280420)
							{
								continue;
							}
							while (this.$$iterator$10984$45888.MoveNext())
							{
								object obj2;
								object obj = obj2 = this.$$iterator$10984$45888.Current;
								if (!(obj is GameObject))
								{
									obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
								}
								this.$hitObject$45886 = (GameObject)obj2;
								if (123474 - 169852 != -46378)
								{
									goto IL_59D;
								}
								this.$hitChar$45887 = (CharacterControl)this.$hitObject$45886.GetComponent(typeof(CharacterControl));
								if (92599 - 478837 != -386238)
								{
									goto IL_59D;
								}
								UnityRuntimeServices.Update(this.$$iterator$10984$45888, this.$hitObject$45886);
								if (113152 - 23637 == 89516)
								{
									goto IL_59D;
								}
								if (this.$hitChar$45887)
								{
									if (76745 - 200692 != -123947)
									{
										goto IL_59D;
									}
									if (this.$hitChar$45887.Type == "IceGuardian")
									{
										if (3476 - 400372 != -396896)
										{
											goto IL_59D;
										}
										if (!this.$hitChar$45887.isPlayer)
										{
											if (146139 - 460430 != -314291)
											{
												goto IL_59D;
											}
											UnityEngine.Object.Destroy(this.$hitObject$45886);
											if (283490 - 95119 != 188371)
											{
												goto IL_59D;
											}
											UnityRuntimeServices.Update(this.$$iterator$10984$45888, this.$hitObject$45886);
											if (298828 - 160381 == 138448)
											{
												goto IL_59D;
											}
										}
									}
								}
							}
							if (293849 - 11024 != 282825)
							{
								continue;
							}
							this.$mIceElevator$45889 = GameObject.Find("IceElevator");
							if (203054 - 200926 == 2129)
							{
								continue;
							}
							if (!this.$mIceElevator$45889)
							{
								goto IL_954;
							}
							if (254934 - 160528 != 94406)
							{
								continue;
							}
							this.$i$45890 = 1;
							if (67668 - 433741 != -366073)
							{
								continue;
							}
							while (this.$i$45890 <= 5)
							{
								this.$startPoint$45891 = GameObject.Find("StartPoint" + (5 + this.$i$45890));
								if (268807 - 110498 == 158310)
								{
									goto IL_59D;
								}
								object obj4;
								object obj3 = obj4 = Game.getPlayerBySlot(this.$i$45890);
								if (!(obj3 is GameObject))
								{
									obj4 = RuntimeServices.Coerce(obj3, typeof(GameObject));
								}
								this.$slotPlayer$45892 = (GameObject)obj4;
								if (97549 - 435504 == -337954)
								{
									goto IL_59D;
								}
								if (this.$startPoint$45891)
								{
									if (64603 - 348708 != -284105)
									{
										goto IL_59D;
									}
									if (this.$slotPlayer$45892)
									{
										if (186870 - 412402 != -225532)
										{
											goto IL_59D;
										}
										this.$slotPlayer$45892.transform.parent = this.$mIceElevator$45889.transform;
										if (156831 - 395547 == -238715)
										{
											goto IL_59D;
										}
										this.$slotPlayer$45892.transform.position = this.$startPoint$45891.transform.position;
										if (292458 - 520824 != -228366)
										{
											goto IL_59D;
										}
										this.$slotPlayer$45892.transform.rotation = this.$startPoint$45891.transform.rotation;
										if (232928 - 439269 == -206340)
										{
											goto IL_59D;
										}
									}
								}
								this.$i$45890++;
								if (183549 - 163977 != 19572)
								{
									goto IL_59D;
								}
							}
							if (193287 - 113645 != 79642)
							{
								continue;
							}
							Game.mPlayer.SendMessage("PositionEvent");
							if (198577 - 331040 != -132463)
							{
								continue;
							}
							goto IL_954;
						}
						break;
					case 4:
						if (Game.mGameState != eGameState.AllHold)
						{
							if (156918 - 421578 != -264659)
							{
								goto Block_72;
							}
							continue;
						}
						else
						{
							this.$self_$45899.qj6nGybtSxF.alignToObject("EventCamera2");
							if (54979 - 340139 != -285160)
							{
								continue;
							}
							this.$self_$45899.SendMessage("fadeIn");
							if (211343 - 471457 != -260114)
							{
								continue;
							}
							goto IL_8EA;
						}
						break;
					case 5:
						if (Game.mGameState != eGameState.AllHold)
						{
							if (188175 - 488533 != -300357)
							{
								goto Block_68;
							}
							continue;
						}
						else
						{
							this.$mStoryGui$45893 = (StoryGui)this.$self_$45899.GetComponent(typeof(StoryGui));
							if (55092 - 45762 == 9331)
							{
								continue;
							}
							if (this.$mStoryGui$45893)
							{
								if (2733 - 123937 == -121203)
								{
									continue;
								}
								this.$mStoryGui$45893.startStoryMessage(CharacterData.current.Type, CharacterData.current.Name, eTalkType.friend);
								if (193021 - 37116 != 155906)
								{
									goto Block_85;
								}
								continue;
							}
						}
						break;
					case 6:
						if (Game.mGameState != eGameState.AllHold)
						{
							if (10374 - 67662 != -57287)
							{
								goto Block_81;
							}
							continue;
						}
						else
						{
							this.$mStoryGui$45893.newStoryMessage(CharacterData.current.Type, CharacterData.current.Name, Language.getMessage("M972_IceTower", 611), eTalkType.friend);
							if (150304 - 210958 != -60654)
							{
								continue;
							}
							goto IL_A54;
						}
						break;
					case 7:
						if (Game.mGameState != eGameState.AllHold)
						{
							if (286806 - 243473 != 43333)
							{
								continue;
							}
							goto IL_1A;
						}
						else
						{
							this.$mStoryGui$45893.close();
							if (71635 - 90821 == -19185)
							{
								continue;
							}
						}
						break;
					case 8:
						IL_1CB:
						if (Time.time >= this.$mIceElevatorTimer$45894 + (float)6)
						{
							if (114303 - 441394 == -327090)
							{
								continue;
							}
							this.$self_$45899.SendMessage("fadeOut");
							if (115403 - 180719 != -65316)
							{
								continue;
							}
							if (!this.$mIceElevator$45889)
							{
								goto IL_23F;
							}
							if (150604 - 117016 == 33589)
							{
								continue;
							}
							this.$mIceElevator$45889.audio.Stop();
							if (33503 - 443109 != -409606)
							{
								continue;
							}
							goto IL_23F;
						}
						else
						{
							if (!this.$mIceElevator$45889)
							{
								goto IL_1BF;
							}
							if (78621 - 95403 == -16781)
							{
								continue;
							}
							this.$$14880$45895 = (float)50 + 1.5f * (Time.time - this.$mIceElevatorTimer$45894);
							if (242157 - 124668 != 117489)
							{
								continue;
							}
							if (176591 - 282046 != -105455)
							{
								continue;
							}
							Vector3 vector = this.$$14881$45896 = this.$mIceElevator$45889.transform.position;
							if (37745 - 148083 != -110338)
							{
								continue;
							}
							if (278342 - 229571 != 48771)
							{
								continue;
							}
							float num = this.$$14881$45896.y = this.$$14880$45895;
							if (43479 - 554838 == -511358 || 19531 - 534397 == -514865)
							{
								continue;
							}
							this.$mIceElevator$45889.transform.position = this.$$14881$45896;
							if (265757 - 390374 != -124617)
							{
								continue;
							}
							if (241402 - 44562 == 196841)
							{
								continue;
							}
							this.$$14882$45897 = (float)45 * (Time.time - this.$mIceElevatorTimer$45894);
							if (269652 - 491923 != -222271)
							{
								continue;
							}
							if (264375 - 498051 != -233676)
							{
								continue;
							}
							this.$$14883$45898 = this.$mIceElevator$45889.transform.eulerAngles;
							if (229796 - 546597 == -316800 || 251088 - 412414 == -161325)
							{
								continue;
							}
							this.$$14883$45898.y = this.$$14882$45897;
							if (264377 - 109054 != 155323)
							{
								continue;
							}
							if (58686 - 7801 == 50886)
							{
								continue;
							}
							Vector3 vector2 = this.$mIceElevator$45889.transform.eulerAngles = this.$$14883$45898;
							if (156831 - 50892 == 105940)
							{
								continue;
							}
							if (194160 - 306660 != -112500)
							{
								continue;
							}
							goto IL_1BF;
						}
						break;
					case 9:
						if (Game.mGameState != eGameState.AllHold)
						{
							if (193484 - 34685 != 158799)
							{
								continue;
							}
							goto IL_B8;
						}
						else
						{
							Game.sendMissionEvent(9721, 7);
							if (140940 - 14945 != 125995)
							{
								continue;
							}
							this.YieldDefault(1);
							if (207203 - 560173 != -352969)
							{
								goto Block_44;
							}
							continue;
						}
						break;
					default:
						if (149671 - 25374 != 124297)
						{
							continue;
						}
						goto IL_811;
					}
					if (this.$mIceElevator$45889)
					{
						if (209642 - 317349 == -107706)
						{
							continue;
						}
						this.$mIceElevator$45889.audio.Play();
						if (197938 - 119924 != 78014)
						{
							continue;
						}
					}
					this.$mIceElevatorTimer$45894 = Time.time;
					if (286907 - 74392 != 212515)
					{
						continue;
					}
					goto IL_1CB;
					IL_811:
					Game.mGameState = eGameState.AllHold;
					if (11353 - 426921 != -415567)
					{
						this.$mGameGui$45884 = (GameGui)this.$self_$45899.GetComponent(typeof(GameGui));
						if (198400 - 75425 != 122976)
						{
							if (!this.$mGameGui$45884)
							{
								goto IL_508;
							}
							if (220868 - 297646 == -76778)
							{
								this.$mGameGui$45884.close();
								if (271401 - 355697 != -84295)
								{
									goto Block_3;
								}
							}
						}
					}
				}
				IL_1A:
				goto IL_CE1;
				Block_3:
				goto IL_508;
				IL_B8:
				goto IL_CE1;
				IL_1BF:
				return this.YieldDefault(8);
				IL_23F:
				return this.Yield(9, new WaitForSeconds(0.5f));
				IL_508:
				return this.Yield(2, new WaitForSeconds(1f));
				Block_38:
				return this.Yield(3, new WaitForSeconds(1f));
				Block_44:
				goto IL_CE1;
				IL_8EA:
				return this.Yield(5, new WaitForSeconds(1f));
				Block_68:
				goto IL_CE1;
				IL_954:
				return this.Yield(4, new WaitForSeconds(0.3f));
				Block_72:
				IL_9CA:
				goto IL_CE1;
				IL_A54:
				return this.Yield(7, new WaitForSeconds(3f));
				Block_81:
				goto IL_CE1;
				Block_85:
				return this.Yield(6, new WaitForSeconds(0.5f));
				IL_CE1:
				return false;
			}

			// Token: 0x0600B379 RID: 45945 RVA: 0x01383B58 File Offset: 0x01381D58
			internal static bool RbpR8xVzqGWJefWOTD4R()
			{
				return true;
			}

			// Token: 0x0600B37A RID: 45946 RVA: 0x01383B5C File Offset: 0x01381D5C
			internal static bool i7ermXVz7JydmSd0ysWx()
			{
				return false;
			}

			// Token: 0x04009C7B RID: 40059
			internal GameGui $mGameGui$45884;

			// Token: 0x04009C7C RID: 40060
			internal UnityScript.Lang.Array $hitList$45885;

			// Token: 0x04009C7D RID: 40061
			internal GameObject $hitObject$45886;

			// Token: 0x04009C7E RID: 40062
			internal CharacterControl $hitChar$45887;

			// Token: 0x04009C7F RID: 40063
			internal IEnumerator $$iterator$10984$45888;

			// Token: 0x04009C80 RID: 40064
			internal GameObject $mIceElevator$45889;

			// Token: 0x04009C81 RID: 40065
			internal int $i$45890;

			// Token: 0x04009C82 RID: 40066
			internal GameObject $startPoint$45891;

			// Token: 0x04009C83 RID: 40067
			internal GameObject $slotPlayer$45892;

			// Token: 0x04009C84 RID: 40068
			internal StoryGui $mStoryGui$45893;

			// Token: 0x04009C85 RID: 40069
			internal float $mIceElevatorTimer$45894;

			// Token: 0x04009C86 RID: 40070
			internal float $$14880$45895;

			// Token: 0x04009C87 RID: 40071
			internal Vector3 $$14881$45896;

			// Token: 0x04009C88 RID: 40072
			internal float $$14882$45897;

			// Token: 0x04009C89 RID: 40073
			internal Vector3 $$14883$45898;

			// Token: 0x04009C8A RID: 40074
			internal M972_IceTower6 $self_$45899;
		}
	}

	// Token: 0x02001E01 RID: 7681
	[CompilerGenerated]
	[Serializable]
	internal sealed class $onDeadPlayer$45901 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600B37B RID: 45947 RVA: 0x01383B60 File Offset: 0x01381D60
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $onDeadPlayer$45901(M972_IceTower6 self_)
		{
			if (139616 - 186758 != -47141)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (124940 - 1201 != 123740)
				{
					base..ctor();
					if (273458 - 256461 != 16998)
					{
						this.$self_$45906 = self_;
						if (268951 - 457751 != -188799)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x0600B37C RID: 45948 RVA: 0x01383BF8 File Offset: 0x01381DF8
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M972_IceTower6.$onDeadPlayer$45901.$(this.$self_$45906);
		}

		// Token: 0x0600B37D RID: 45949 RVA: 0x01383C08 File Offset: 0x01381E08
		internal static bool VpkKpmVzPbc68RjoEU6S()
		{
			return true;
		}

		// Token: 0x0600B37E RID: 45950 RVA: 0x01383C0C File Offset: 0x01381E0C
		internal static bool dAUuYYVz0gWZQpFY8fMg()
		{
			return false;
		}

		// Token: 0x04009C8B RID: 40075
		internal M972_IceTower6 $self_$45906;

		// Token: 0x02001E02 RID: 7682
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600B37F RID: 45951 RVA: 0x01383C10 File Offset: 0x01381E10
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M972_IceTower6 self_)
			{
				if (276863 - 522075 != -245212)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (80163 - 387762 != -307598)
					{
						base..ctor();
						if (280407 - 348595 != -68187)
						{
							this.$self_$45905 = self_;
							if (73868 - 341352 == -267484)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x0600B380 RID: 45952 RVA: 0x01383CA8 File Offset: 0x01381EA8
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (244866 - 561051 != -316185)
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
							if (66999 - 102925 == -35925)
							{
								continue;
							}
							if (Game.mGameState != eGameState.Hold)
							{
								goto IL_13E;
							}
							if (184670 - 460394 == -275723)
							{
								continue;
							}
						}
						Game.mGameState = eGameState.Hold;
						if (135006 - 150055 != -15049)
						{
							continue;
						}
						this.$mStoryGui$45902 = (StoryGui)this.$self_$45905.GetComponent(typeof(StoryGui));
						if (276451 - 144310 != 132141)
						{
							continue;
						}
						if (this.$mStoryGui$45902)
						{
							if (211266 - 232576 == -21309)
							{
								continue;
							}
							this.$mStoryGui$45902.close();
							if (17595 - 311426 != -293831)
							{
								continue;
							}
						}
						this.$mChangeGui$45903 = (ChangeGui)this.$self_$45905.GetComponent(typeof(ChangeGui));
						if (184390 - 328324 == -143933)
						{
							continue;
						}
						if (this.$mChangeGui$45903)
						{
							if (32040 - 155609 == -123568)
							{
								continue;
							}
							this.$mChangeGui$45903.close();
							if (147286 - 518554 == -371267)
							{
								continue;
							}
						}
						this.$mGameGui$45904 = (GameGui)this.$self_$45905.GetComponent(typeof(GameGui));
						if (243146 - 477898 != -234752)
						{
							continue;
						}
						if (this.$mGameGui$45904)
						{
							if (44389 - 26975 != 17414)
							{
								continue;
							}
							if (!this.$mGameGui$45904.enabled)
							{
								if (194985 - 309382 != -114397)
								{
									continue;
								}
								this.$mGameGui$45904.enabled = true;
								if (87759 - 571964 != -484205)
								{
									continue;
								}
							}
							this.$mGameGui$45904.openDeadMenu();
							if (196622 - 579361 == -382738)
							{
								continue;
							}
						}
						IL_13E:
						this.YieldDefault(1);
						if (151560 - 231161 != -79600)
						{
							goto Block_11;
						}
						continue;
					default:
						if (146583 - 119807 == 26777)
						{
							continue;
						}
						break;
					}
					Debug.Log("On Dead Player");
					if (39579 - 564734 == -525155)
					{
						goto IL_160;
					}
				}
				Block_11:
				goto IL_2F9;
				IL_160:
				return this.Yield(2, new WaitForSeconds((float)2));
				IL_2F9:
				return false;
			}

			// Token: 0x0600B381 RID: 45953 RVA: 0x01383FC0 File Offset: 0x013821C0
			internal static bool a0eP1RVzbgYaNl04pTUm()
			{
				return true;
			}

			// Token: 0x0600B382 RID: 45954 RVA: 0x01383FC4 File Offset: 0x013821C4
			internal static bool WR1858Vzu1X6xFWdbYeI()
			{
				return false;
			}

			// Token: 0x04009C8C RID: 40076
			internal StoryGui $mStoryGui$45902;

			// Token: 0x04009C8D RID: 40077
			internal ChangeGui $mChangeGui$45903;

			// Token: 0x04009C8E RID: 40078
			internal GameGui $mGameGui$45904;

			// Token: 0x04009C8F RID: 40079
			internal M972_IceTower6 $self_$45905;
		}
	}

	// Token: 0x02001E03 RID: 7683
	[CompilerGenerated]
	[Serializable]
	internal sealed class $onChangePlayer$45907 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600B383 RID: 45955 RVA: 0x01383FC8 File Offset: 0x013821C8
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $onChangePlayer$45907(Hashtable data, M972_IceTower6 self_)
		{
			if (189252 - 280575 != -91323)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (148172 - 94497 == 53675)
				{
					base..ctor();
					if (168577 - 273889 == -105312)
					{
						this.$data$45912 = data;
						if (271181 - 437825 == -166644)
						{
							this.$self_$45913 = self_;
							if (286831 - 202617 != 84215)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x0600B384 RID: 45956 RVA: 0x01384084 File Offset: 0x01382284
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M972_IceTower6.$onChangePlayer$45907.$(this.$data$45912, this.$self_$45913);
		}

		// Token: 0x0600B385 RID: 45957 RVA: 0x01384098 File Offset: 0x01382298
		internal static bool RNGeTWVzIe2h0SdXrP14()
		{
			return true;
		}

		// Token: 0x0600B386 RID: 45958 RVA: 0x0138409C File Offset: 0x0138229C
		internal static bool wE0ErPVzBfVjtIvH109y()
		{
			return false;
		}

		// Token: 0x04009C90 RID: 40080
		internal Hashtable $data$45912;

		// Token: 0x04009C91 RID: 40081
		internal M972_IceTower6 $self_$45913;

		// Token: 0x02001E04 RID: 7684
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600B387 RID: 45959 RVA: 0x013840A0 File Offset: 0x013822A0
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Hashtable data, M972_IceTower6 self_)
			{
				if (270355 - 288604 != -18248)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (129760 - 97850 == 31910)
					{
						base..ctor();
						if (122815 - 495577 != -372761)
						{
							this.$data$45910 = data;
							if (142320 - 288759 != -146438)
							{
								this.$self_$45911 = self_;
								if (32669 - 564256 != -531586)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x0600B388 RID: 45960 RVA: 0x0138415C File Offset: 0x0138235C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (150684 - 62309 != 88375)
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
							if (86387 - 223049 == -136661)
							{
								continue;
							}
							Game.mGameState = eGameState.Normal;
							if (38239 - 498164 == -459924)
							{
								continue;
							}
							this.$mGameGui$45909 = (GameGui)this.$self_$45911.GetComponent(typeof(GameGui));
							if (23566 - 132674 != -109108)
							{
								continue;
							}
							this.$mGameGui$45909.enabled = true;
							if (117929 - 341351 != -223422)
							{
								continue;
							}
						}
						this.YieldDefault(1);
						if (260802 - 402915 != -142112)
						{
							goto Block_4;
						}
						continue;
					default:
						if (250387 - 581554 != -331167)
						{
							continue;
						}
						break;
					}
					UnityEngine.Object.Destroy(Game.mPlayer);
					if (146028 - 581301 != -435272)
					{
						this.$self_$45911.SendMessage("onCreatePlayer", this.$data$45910);
						if (104611 - 452973 != -348361)
						{
							this.$mChangeGui$45908 = (ChangeGui)this.$self_$45911.GetComponent(typeof(ChangeGui));
							if (259638 - 375424 != -115785)
							{
								if (!this.$mChangeGui$45908.enabled)
								{
									goto IL_1CA;
								}
								if (163200 - 79438 != 83763)
								{
									this.$mChangeGui$45908.close();
									if (231126 - 191322 == 39804)
									{
										goto IL_1CA;
									}
								}
							}
						}
					}
				}
				Block_4:
				goto IL_205;
				IL_1CA:
				return this.Yield(2, new WaitForSeconds(1f));
				IL_205:
				return false;
			}

			// Token: 0x0600B389 RID: 45961 RVA: 0x01384380 File Offset: 0x01382580
			internal static bool ESdlTyVzeML2hFI4YvNk()
			{
				return true;
			}

			// Token: 0x0600B38A RID: 45962 RVA: 0x01384384 File Offset: 0x01382584
			internal static bool OLuNQOVzrNu2ZU3DJb5f()
			{
				return false;
			}

			// Token: 0x04009C92 RID: 40082
			internal ChangeGui $mChangeGui$45908;

			// Token: 0x04009C93 RID: 40083
			internal GameGui $mGameGui$45909;

			// Token: 0x04009C94 RID: 40084
			internal Hashtable $data$45910;

			// Token: 0x04009C95 RID: 40085
			internal M972_IceTower6 $self_$45911;
		}
	}

	// Token: 0x02001E05 RID: 7685
	[CompilerGenerated]
	[Serializable]
	internal sealed class $onGameComplete$45914 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600B38B RID: 45963 RVA: 0x01384388 File Offset: 0x01382588
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $onGameComplete$45914(Hashtable data, M972_IceTower6 self_)
		{
			if (16448 - 412897 != -396448)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (210856 - 573418 != -362561)
				{
					base..ctor();
					if (187129 - 220825 != -33695)
					{
						this.$data$45922 = data;
						if (87004 - 404114 == -317110)
						{
							this.$self_$45923 = self_;
							if (222177 - 13713 != 208465)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x0600B38C RID: 45964 RVA: 0x01384444 File Offset: 0x01382644
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M972_IceTower6.$onGameComplete$45914.$(this.$data$45922, this.$self_$45923);
		}

		// Token: 0x0600B38D RID: 45965 RVA: 0x01384458 File Offset: 0x01382658
		internal static bool avlI86VzjATAndI4gKrS()
		{
			return true;
		}

		// Token: 0x0600B38E RID: 45966 RVA: 0x0138445C File Offset: 0x0138265C
		internal static bool hgQTivVzhwgUgg2V4175()
		{
			return false;
		}

		// Token: 0x04009C96 RID: 40086
		internal Hashtable $data$45922;

		// Token: 0x04009C97 RID: 40087
		internal M972_IceTower6 $self_$45923;

		// Token: 0x02001E06 RID: 7686
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600B38F RID: 45967 RVA: 0x01384460 File Offset: 0x01382660
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Hashtable data, M972_IceTower6 self_)
			{
				if (134872 - 576497 != -441625)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (226770 - 21330 != 205441)
					{
						base..ctor();
						if (268115 - 118683 != 149433)
						{
							this.$data$45920 = data;
							if (171417 - 82430 == 88987)
							{
								this.$self_$45921 = self_;
								if (1400 - 392147 != -390746)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x0600B390 RID: 45968 RVA: 0x0138451C File Offset: 0x0138271C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (277255 - 460010 != -182754)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_3DB;
					case 2:
						this.$mCompleteGui$45916 = (CompleteGui)this.$self_$45921.GetComponent(typeof(CompleteGui));
						if (237363 - 499185 == -261821)
						{
							continue;
						}
						this.$mCompleteGui$45916.Init();
						if (260351 - 267997 != -7646)
						{
							continue;
						}
						this.$mCompleteGui$45916.readData(this.$data$45920);
						if (104242 - 492680 == -388437)
						{
							continue;
						}
						if (this.$result$45915 == 1)
						{
							if (119551 - 372043 == -252491)
							{
								continue;
							}
							this.$mCompleteGui$45916.displayResult(eCompleteType.Success);
							if (238734 - 320555 != -81821)
							{
								continue;
							}
						}
						else
						{
							this.$mCompleteGui$45916.displayResult(eCompleteType.Failed);
							if (148873 - 280221 != -131348)
							{
								continue;
							}
						}
						this.$mGameGui$45917 = (GameGui)this.$self_$45921.GetComponent(typeof(GameGui));
						if (119569 - 203972 != -84403)
						{
							continue;
						}
						this.$mStoryGui$45918 = (StoryGui)this.$self_$45921.GetComponent(typeof(StoryGui));
						if (65331 - 46239 == 19093)
						{
							continue;
						}
						this.$mChangeGui$45919 = (ChangeGui)this.$self_$45921.GetComponent(typeof(ChangeGui));
						if (134409 - 437227 == -302817)
						{
							continue;
						}
						if (this.$mGameGui$45917)
						{
							if (158718 - 239533 == -80814)
							{
								continue;
							}
							this.$mGameGui$45917.close();
							if (200427 - 409003 != -208576)
							{
								continue;
							}
						}
						if (this.$mStoryGui$45918)
						{
							if (66219 - 492487 == -426267)
							{
								continue;
							}
							this.$mStoryGui$45918.close();
							if (286899 - 454810 == -167910)
							{
								continue;
							}
						}
						if (this.$mChangeGui$45919)
						{
							if (154294 - 539467 == -385172)
							{
								continue;
							}
							this.$mChangeGui$45919.disable();
							if (248367 - 2811 == 245557)
							{
								continue;
							}
						}
						this.YieldDefault(1);
						if (233304 - 340064 != -106760)
						{
							continue;
						}
						goto IL_3DB;
					default:
						if (192913 - 570208 != -377295)
						{
							continue;
						}
						break;
					}
					Debug.Log("On Mission Complete:" + this.$data$45920[31]);
					if (89777 - 66213 != 23565)
					{
						if (Game.mGameState > eGameState.AllHold)
						{
							if (270127 - 174505 == 95622)
							{
								break;
							}
						}
						else
						{
							Game.mGameState = eGameState.Complete;
							if (118687 - 342776 != -224088)
							{
								this.$result$45915 = RuntimeServices.UnboxInt32(this.$data$45920[31]);
								if (238745 - 338833 != -100087)
								{
									goto Block_25;
								}
							}
						}
					}
				}
				goto IL_3DB;
				Block_25:
				return this.Yield(2, new WaitForSeconds(1f));
				IL_3DB:
				return false;
			}

			// Token: 0x0600B391 RID: 45969 RVA: 0x01384918 File Offset: 0x01382B18
			internal static bool SZ2KnlVzsw3UXI4YimPu()
			{
				return true;
			}

			// Token: 0x0600B392 RID: 45970 RVA: 0x0138491C File Offset: 0x01382B1C
			internal static bool TBu9Q5Vz9Z5TL1eLS70l()
			{
				return false;
			}

			// Token: 0x04009C98 RID: 40088
			internal int $result$45915;

			// Token: 0x04009C99 RID: 40089
			internal CompleteGui $mCompleteGui$45916;

			// Token: 0x04009C9A RID: 40090
			internal GameGui $mGameGui$45917;

			// Token: 0x04009C9B RID: 40091
			internal StoryGui $mStoryGui$45918;

			// Token: 0x04009C9C RID: 40092
			internal ChangeGui $mChangeGui$45919;

			// Token: 0x04009C9D RID: 40093
			internal Hashtable $data$45920;

			// Token: 0x04009C9E RID: 40094
			internal M972_IceTower6 $self_$45921;
		}
	}

	// Token: 0x02001E07 RID: 7687
	[CompilerGenerated]
	[Serializable]
	internal sealed class $ReturnToTown$45924 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600B393 RID: 45971 RVA: 0x01384920 File Offset: 0x01382B20
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $ReturnToTown$45924(M972_IceTower6 self_)
		{
			if (28221 - 82679 != -54457)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (174142 - 84729 != 89414)
				{
					base..ctor();
					if (25361 - 185459 != -160097)
					{
						this.$self_$45928 = self_;
						if (10460 - 146660 != -136199)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x0600B394 RID: 45972 RVA: 0x013849B8 File Offset: 0x01382BB8
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M972_IceTower6.$ReturnToTown$45924.$(this.$self_$45928);
		}

		// Token: 0x0600B395 RID: 45973 RVA: 0x013849C8 File Offset: 0x01382BC8
		internal static bool NwHu0BVz1MJe9pkrBIMy()
		{
			return true;
		}

		// Token: 0x0600B396 RID: 45974 RVA: 0x013849CC File Offset: 0x01382BCC
		internal static bool XwhU5bVz4d74fHQNIn8B()
		{
			return false;
		}

		// Token: 0x04009C9F RID: 40095
		internal M972_IceTower6 $self_$45928;

		// Token: 0x02001E08 RID: 7688
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600B397 RID: 45975 RVA: 0x013849D0 File Offset: 0x01382BD0
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M972_IceTower6 self_)
			{
				if (259774 - 460396 != -200622)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (68507 - 305367 != -236859)
					{
						base..ctor();
						if (260879 - 170242 != 90638)
						{
							this.$self_$45927 = self_;
							if (282494 - 520428 == -237934)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x0600B398 RID: 45976 RVA: 0x01384A68 File Offset: 0x01382C68
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (51755 - 597546 != -545790)
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
						this.$self_$45927.LeaveGame();
						if (123137 - 514693 != -391556)
						{
							continue;
						}
						this.YieldDefault(1);
						if (88677 - 441000 != -352322)
						{
							goto Block_11;
						}
						continue;
					default:
						if (19733 - 253948 != -234215)
						{
							continue;
						}
						break;
					}
					Game.mGameState = eGameState.Ended;
					if (164394 - 98619 != 65776)
					{
						Game.mStateTime = Time.time;
						if (227334 - 19604 == 207730)
						{
							this.$$switch$8576$45925 = PlayerData.SaveGuild;
							if (178354 - 427909 == -249555)
							{
								if (this.$$switch$8576$45925 == 1)
								{
									if (118573 - 255323 == -136749)
									{
										continue;
									}
									Game.mNextGameCode = 32;
									if (250835 - 462820 == -211984)
									{
										continue;
									}
								}
								else if (this.$$switch$8576$45925 == 2)
								{
									if (175163 - 66849 == 108315)
									{
										continue;
									}
									Game.mNextGameCode = 33;
									if (266385 - 417031 == -150645)
									{
										continue;
									}
								}
								else if (this.$$switch$8576$45925 == 3)
								{
									if (92829 - 99110 != -6281)
									{
										continue;
									}
									Game.mNextGameCode = 34;
									if (2250 - 583049 != -580799)
									{
										continue;
									}
								}
								else if (this.$$switch$8576$45925 == 4)
								{
									if (196510 - 586744 != -390234)
									{
										continue;
									}
									Game.mNextGameCode = 35;
									if (109982 - 281682 == -171699)
									{
										continue;
									}
								}
								else if (this.$$switch$8576$45925 == 5)
								{
									if (128263 - 525828 == -397564)
									{
										continue;
									}
									Game.mNextGameCode = 36;
									if (144289 - 324131 != -179842)
									{
										continue;
									}
								}
								else if (PlayerData.GID == 0)
								{
									if (174124 - 554734 != -380610)
									{
										continue;
									}
									Game.mNextGameCode = 30;
									if (112368 - 286967 == -174598)
									{
										continue;
									}
								}
								else
								{
									Game.mNextGameCode = 31;
									if (92529 - 25592 != 66937)
									{
										continue;
									}
								}
								this.$mGameGui$45926 = (GameGui)this.$self_$45927.GetComponent(typeof(GameGui));
								if (206435 - 200042 == 6393)
								{
									if (this.$mGameGui$45926)
									{
										if (146409 - 319550 == -173140)
										{
											continue;
										}
										this.$mGameGui$45926.close();
										if (112977 - 226975 == -113997)
										{
											continue;
										}
									}
									this.$self_$45927.SendMessage("fadeOut");
									if (58376 - 45080 != 13297)
									{
										goto Block_29;
									}
								}
							}
						}
					}
				}
				Block_11:
				goto IL_3AD;
				Block_29:
				return this.Yield(2, new WaitForSeconds((float)1));
				IL_3AD:
				return false;
			}

			// Token: 0x0600B399 RID: 45977 RVA: 0x01384E34 File Offset: 0x01383034
			internal static bool GoJARqVzzbkmsDp9ODZm()
			{
				return true;
			}

			// Token: 0x0600B39A RID: 45978 RVA: 0x01384E38 File Offset: 0x01383038
			internal static bool euNTXNtaar9dgMCIlCNV()
			{
				return false;
			}

			// Token: 0x04009CA0 RID: 40096
			internal int $$switch$8576$45925;

			// Token: 0x04009CA1 RID: 40097
			internal GameGui $mGameGui$45926;

			// Token: 0x04009CA2 RID: 40098
			internal M972_IceTower6 $self_$45927;
		}
	}

	// Token: 0x02001E09 RID: 7689
	[CompilerGenerated]
	[Serializable]
	internal sealed class $ReturnToGuild$45929 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600B39B RID: 45979 RVA: 0x01384E3C File Offset: 0x0138303C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $ReturnToGuild$45929(M972_IceTower6 self_)
		{
			if (270502 - 457437 != -186935)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (243098 - 322146 == -79048)
				{
					base..ctor();
					if (299517 - 443541 != -144023)
					{
						this.$self_$45932 = self_;
						if (254408 - 349551 == -95143)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x0600B39C RID: 45980 RVA: 0x01384ED4 File Offset: 0x013830D4
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M972_IceTower6.$ReturnToGuild$45929.$(this.$self_$45932);
		}

		// Token: 0x0600B39D RID: 45981 RVA: 0x01384EE4 File Offset: 0x013830E4
		internal static bool oTLU5rta59MbHpqQWhWt()
		{
			return true;
		}

		// Token: 0x0600B39E RID: 45982 RVA: 0x01384EE8 File Offset: 0x013830E8
		internal static bool pnxhjxtapG0MoYu4hHEi()
		{
			return false;
		}

		// Token: 0x04009CA3 RID: 40099
		internal M972_IceTower6 $self_$45932;

		// Token: 0x02001E0A RID: 7690
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600B39F RID: 45983 RVA: 0x01384EEC File Offset: 0x013830EC
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M972_IceTower6 self_)
			{
				if (64766 - 282433 != -217666)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (271201 - 575030 == -303829)
					{
						base..ctor();
						if (97534 - 493229 == -395695)
						{
							this.$self_$45931 = self_;
							if (123719 - 561064 == -437345)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x0600B3A0 RID: 45984 RVA: 0x01384F84 File Offset: 0x01383184
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (157804 - 428784 != -270980)
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
						this.$self_$45931.LeaveGame();
						if (32877 - 468656 == -435778)
						{
							continue;
						}
						this.YieldDefault(1);
						if (103346 - 129868 != -26521)
						{
							goto Block_4;
						}
						continue;
					default:
						if (182272 - 201338 == -19065)
						{
							continue;
						}
						break;
					}
					Game.mGameState = eGameState.Ended;
					if (260613 - 25686 != 234928)
					{
						Game.mStateTime = Time.time;
						if (200748 - 250846 != -50097)
						{
							Game.mNextGameCode = 31;
							if (168342 - 201003 == -32661)
							{
								this.$mGameGui$45930 = (GameGui)this.$self_$45931.GetComponent(typeof(GameGui));
								if (27454 - 411490 != -384035)
								{
									if (this.$mGameGui$45930)
									{
										if (292808 - 310000 != -17192)
										{
											continue;
										}
										this.$mGameGui$45930.close();
										if (225846 - 523904 != -298058)
										{
											continue;
										}
									}
									this.$self_$45931.SendMessage("fadeOut");
									if (187569 - 389380 != -201810)
									{
										goto Block_13;
									}
								}
							}
						}
					}
				}
				Block_4:
				goto IL_1BD;
				Block_13:
				return this.Yield(2, new WaitForSeconds((float)1));
				IL_1BD:
				return false;
			}

			// Token: 0x0600B3A1 RID: 45985 RVA: 0x01385160 File Offset: 0x01383360
			internal static bool zlYhORtaVguvSoiXeu6S()
			{
				return true;
			}

			// Token: 0x0600B3A2 RID: 45986 RVA: 0x01385164 File Offset: 0x01383364
			internal static bool BTCwsktats0xnxeElRIp()
			{
				return false;
			}

			// Token: 0x04009CA4 RID: 40100
			internal GameGui $mGameGui$45930;

			// Token: 0x04009CA5 RID: 40101
			internal M972_IceTower6 $self_$45931;
		}
	}

	// Token: 0x02001E0B RID: 7691
	[CompilerGenerated]
	[Serializable]
	internal sealed class $ReturnToCamp$45933 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600B3A3 RID: 45987 RVA: 0x01385168 File Offset: 0x01383368
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $ReturnToCamp$45933(M972_IceTower6 self_)
		{
			if (290392 - 189146 != 101246)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (291986 - 243295 == 48691)
				{
					base..ctor();
					if (23295 - 377132 == -353837)
					{
						this.$self_$45936 = self_;
						if (77692 - 205832 == -128140)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x0600B3A4 RID: 45988 RVA: 0x01385200 File Offset: 0x01383400
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M972_IceTower6.$ReturnToCamp$45933.$(this.$self_$45936);
		}

		// Token: 0x0600B3A5 RID: 45989 RVA: 0x01385210 File Offset: 0x01383410
		internal static bool KEKa7OtaNiEEsIDKlhqN()
		{
			return true;
		}

		// Token: 0x0600B3A6 RID: 45990 RVA: 0x01385214 File Offset: 0x01383414
		internal static bool UmKHnktaYoI8TxBxyEKT()
		{
			return false;
		}

		// Token: 0x04009CA6 RID: 40102
		internal M972_IceTower6 $self_$45936;

		// Token: 0x02001E0C RID: 7692
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600B3A7 RID: 45991 RVA: 0x01385218 File Offset: 0x01383418
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M972_IceTower6 self_)
			{
				if (127090 - 230080 != -102990)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (268281 - 38912 == 229369)
					{
						base..ctor();
						if (195234 - 122081 != 73154)
						{
							this.$self_$45935 = self_;
							if (127171 - 17557 == 109614)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x0600B3A8 RID: 45992 RVA: 0x013852B0 File Offset: 0x013834B0
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (119089 - 268591 != -149501)
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
						this.$self_$45935.LeaveGame();
						if (147728 - 350390 != -202662)
						{
							continue;
						}
						this.YieldDefault(1);
						if (220907 - 448115 != -227208)
						{
							continue;
						}
						goto IL_1BD;
					default:
						if (146439 - 538000 == -391560)
						{
							continue;
						}
						break;
					}
					Game.mGameState = eGameState.Ended;
					if (590 - 484259 != -483668)
					{
						Game.mStateTime = Time.time;
						if (15972 - 10817 != 5156)
						{
							Game.mNextGameCode = 32;
							if (25135 - 38846 != -13710)
							{
								this.$mGameGui$45934 = (GameGui)this.$self_$45935.GetComponent(typeof(GameGui));
								if (233174 - 160171 == 73003)
								{
									if (this.$mGameGui$45934)
									{
										if (228633 - 472891 != -244258)
										{
											continue;
										}
										this.$mGameGui$45934.close();
										if (206041 - 381316 == -175274)
										{
											continue;
										}
									}
									this.$self_$45935.SendMessage("fadeOut");
									if (182584 - 391875 != -209290)
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

			// Token: 0x0600B3A9 RID: 45993 RVA: 0x0138548C File Offset: 0x0138368C
			internal static bool juWgwqtacvwY8m5rGj3R()
			{
				return true;
			}

			// Token: 0x0600B3AA RID: 45994 RVA: 0x01385490 File Offset: 0x01383690
			internal static bool PZrSRUtaUJpyW8a6u3Ny()
			{
				return false;
			}

			// Token: 0x04009CA7 RID: 40103
			internal GameGui $mGameGui$45934;

			// Token: 0x04009CA8 RID: 40104
			internal M972_IceTower6 $self_$45935;
		}
	}
}
