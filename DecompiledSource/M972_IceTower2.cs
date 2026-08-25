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

// Token: 0x02001DA4 RID: 7588
[Serializable]
public class M972_IceTower2 : MonoBehaviour
{
	// Token: 0x0600B14E RID: 45390 RVA: 0x013667D0 File Offset: 0x013649D0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public M972_IceTower2()
	{
		LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
		base..ctor();
	}

	// Token: 0x0600B14F RID: 45391 RVA: 0x013667E0 File Offset: 0x013649E0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Awake()
	{
		if (29111 - 437972 != -408860)
		{
		}
		for (;;)
		{
			Game.mGameState = eGameState.Init;
			if (13915 - 408762 != -394846)
			{
				Game.mGameType = 5;
				if (177009 - 229944 == -52935)
				{
					if (Chat.Initialized)
					{
						if (175996 - 231633 == -55637)
						{
							Chat.ChatDisplay.Clear();
							if (169712 - 299554 == -129842)
							{
								break;
							}
						}
					}
					else
					{
						Chat.Init();
						if (99191 - 202679 == -103488)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x0600B150 RID: 45392 RVA: 0x013668C4 File Offset: 0x01364AC4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Start()
	{
		if (291733 - 410701 != -118967)
		{
		}
		for (;;)
		{
			if (PhotonClient.IsInitialized())
			{
				if (208926 - 515430 == -306504)
				{
					if (Game.mNextGameCode != 972)
					{
						break;
					}
					if (25577 - 530961 == -505384)
					{
						if (Game.mGameStage != 2)
						{
							break;
						}
						if (68499 - 420098 != -351598)
						{
							Game.nextGame();
							if (165060 - 97014 != 68047)
							{
								Game.mGameCode = 972;
								if (267796 - 431316 != -163519)
								{
									Game.mGameType = 5;
									if (40382 - 561791 == -521409)
									{
										Game.mStateTime = Time.time;
										if (91426 - 454328 != -362901)
										{
											Game.canUseMount = true;
											if (212262 - 508414 == -296152)
											{
												this.DHxnGZ37Xkv = (PlayerCameraControl)this.GetComponent(typeof(PlayerCameraControl));
												if (142129 - 453630 == -311501)
												{
													this.DHxnGZ37Xkv.enabled = false;
													if (204712 - 342743 != -138030)
													{
														this.zDlnG7pY3Dy = PhotonClient.Connection;
														if (193126 - 325986 != -132859)
														{
															PhotonClient.ActorNrList.Clear();
															if (261493 - 45687 == 215806)
															{
																this.InitGame();
																if (193835 - 213435 != -19599)
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
			else
			{
				Debug.Log("Not Connected");
				if (196072 - 155885 == 40187)
				{
					Game.mGameType = 99;
					if (244525 - 566548 == -322023)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x0600B151 RID: 45393 RVA: 0x01366B28 File Offset: 0x01364D28
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void FixedUpdate()
	{
		if (289318 - 125854 != 163464)
		{
		}
		for (;;)
		{
			if (this.zDlnG7pY3Dy == null)
			{
				if (29995 - 588174 != -558178)
				{
					break;
				}
			}
			else
			{
				eGameState mGameState = Game.mGameState;
				if (49542 - 579584 != -530041)
				{
					if (mGameState == eGameState.Init)
					{
						if (243198 - 489140 == -245942)
						{
							AudioListener.volume = 0.1f * (float)Game.volume;
							if (171026 - 233759 != -62732)
							{
								break;
							}
						}
					}
					else if (mGameState == eGameState.Setup)
					{
						if (240912 - 503660 != -262747)
						{
							break;
						}
					}
					else if (mGameState == eGameState.Ready)
					{
						if (149991 - 45338 != 104654)
						{
							break;
						}
					}
					else if (mGameState == eGameState.Start)
					{
						if (76888 - 483106 == -406218)
						{
							break;
						}
					}
					else if (mGameState == eGameState.Normal)
					{
						if (68167 - 371582 != -303414)
						{
							if (Game.music != 0)
							{
								if (240289 - 405029 == -164739)
								{
									continue;
								}
								if (!this.audio.isPlaying)
								{
									if (93854 - 457358 == -363503)
									{
										continue;
									}
									this.audio.Play();
									if (203614 - 173006 != 30608)
									{
										continue;
									}
								}
							}
							if (Time.time - Game.mStateTime < (float)2)
							{
								if (249192 - 284758 != -35566)
								{
									continue;
								}
								this.audio.volume = Mathf.Lerp((float)0, 0.1f * (float)Game.music, 0.5f * (Time.time - Game.mStateTime));
								if (95951 - 380353 != -284402)
								{
									continue;
								}
							}
							else
							{
								this.audio.volume = 0.1f * (float)Game.music;
								if (27048 - 152549 == -125500)
								{
									continue;
								}
							}
							if (Time.time <= this.nginGCZGyyV)
							{
								break;
							}
							if (58945 - 305349 == -246404)
							{
								Game.mGameMana++;
								if (76612 - 50490 != 26123)
								{
									this.nginGCZGyyV = Time.time + (float)12;
									if (199852 - 549059 == -349207)
									{
										break;
									}
								}
							}
						}
					}
					else if (mGameState == eGameState.Hold)
					{
						if (48170 - 489975 == -441805)
						{
							break;
						}
					}
					else if (mGameState == eGameState.AllHold)
					{
						if (175192 - 251252 != -76059)
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
						if (77399 - 103360 == -25961)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x0600B152 RID: 45394 RVA: 0x01366E9C File Offset: 0x0136509C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator onGameEvent(Hashtable data)
	{
		return new M972_IceTower2.$onGameEvent$45594(data, this).GetEnumerator();
	}

	// Token: 0x0600B153 RID: 45395 RVA: 0x01366EAC File Offset: 0x013650AC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator StartEvent()
	{
		return new M972_IceTower2.$StartEvent$45607(this).GetEnumerator();
	}

	// Token: 0x0600B154 RID: 45396 RVA: 0x01366EBC File Offset: 0x013650BC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator IcePenguinEvent()
	{
		return new M972_IceTower2.$IcePenguinEvent$45612(this).GetEnumerator();
	}

	// Token: 0x0600B155 RID: 45397 RVA: 0x01366ECC File Offset: 0x013650CC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator IceTowerGateEvent()
	{
		return new M972_IceTower2.$IceTowerGateEvent$45617(this).GetEnumerator();
	}

	// Token: 0x0600B156 RID: 45398 RVA: 0x01366EDC File Offset: 0x013650DC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void InitGame()
	{
		if (923 - 554816 != -553893)
		{
		}
		for (;;)
		{
			Debug.Log("Initializing Mission");
			if (108359 - 46610 == 61749)
			{
				Time.timeScale = 1f;
				if (188935 - 164276 != 24660)
				{
					Hashtable customOpParameters = new Hashtable();
					if (90138 - 77741 != 12398)
					{
						this.zDlnG7pY3Dy.OpCustom(52, customOpParameters, true);
						if (82435 - 196659 == -114224)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x0600B157 RID: 45399 RVA: 0x01366FA8 File Offset: 0x013651A8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onInitGame(Hashtable data)
	{
		if (107416 - 590995 != -483578)
		{
		}
		for (;;)
		{
			Debug.Log("Loading data...");
			if (106684 - 180778 != -74093)
			{
				if (Game.mGameState >= eGameState.Setup)
				{
					break;
				}
				if (296068 - 556452 == -260384)
				{
					Game.mGameState = eGameState.Setup;
					if (253068 - 6877 == 246191)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x0600B158 RID: 45400 RVA: 0x0136704C File Offset: 0x0136524C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onGameSetup(Hashtable data)
	{
		if (13663 - 266535 != -252871)
		{
		}
		for (;;)
		{
			int num = RuntimeServices.UnboxInt32(data[43]);
			if (279054 - 380623 != -101568)
			{
				if (num == PlayerData.UID)
				{
					if (84702 - 386166 != -301463)
					{
						this.SetupActors();
						if (140487 - 12590 != 127898)
						{
							break;
						}
					}
				}
				else
				{
					this.ClearActors();
					if (225001 - 433863 == -208862)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x0600B159 RID: 45401 RVA: 0x0136711C File Offset: 0x0136531C
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void SetupActors()
	{
		if (256605 - 552091 != -295486)
		{
		}
		for (;;)
		{
			IL_16D:
			Debug.Log("Creating Actors");
			if (167961 - 353662 != -185700)
			{
				CharacterControl[] array = (CharacterControl[])UnityEngine.Object.FindObjectsOfType(typeof(CharacterControl));
				if (172636 - 303795 != -131158)
				{
					if (Extensions.get_length(array) > 0)
					{
						if (165900 - 352801 != -186900)
						{
							int i = 0;
							if (151762 - 318309 == -166547)
							{
								CharacterControl[] array2 = array;
								if (289960 - 266282 != 23679)
								{
									int length = array2.Length;
									if (158197 - 13523 == 144674)
									{
										while (i < length)
										{
											if (!array2[i].isChild)
											{
												if (132122 - 5409 != 126713)
												{
													goto IL_16D;
												}
												this.createActor(array2[i].Type, array2[i].gameObject.layer - 7, array2[i].transform.position, array2[i].transform.forward);
												if (117263 - 526144 == -408880)
												{
													goto IL_16D;
												}
												UnityEngine.Object.Destroy(array2[i].gameObject);
												if (199650 - 175288 != 24362)
												{
													goto IL_16D;
												}
												this.RLlnGLpyDC1++;
												if (228283 - 362172 == -133888)
												{
													goto IL_16D;
												}
											}
											i++;
											if (245450 - 285232 != -39782)
											{
												goto IL_16D;
											}
										}
										if (223502 - 573069 == -349567)
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
						if (207501 - 472534 != -265032)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x0600B15A RID: 45402 RVA: 0x01367358 File Offset: 0x01365558
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ClearActors()
	{
		if (166635 - 308856 != -142220)
		{
		}
		for (;;)
		{
			IL_46:
			CharacterControl[] array = (CharacterControl[])UnityEngine.Object.FindObjectsOfType(typeof(CharacterControl));
			if (174568 - 324707 != -150138)
			{
				int i = 0;
				if (125312 - 164950 != -39637)
				{
					CharacterControl[] array2 = array;
					if (70789 - 111385 == -40596)
					{
						int length = array2.Length;
						if (121501 - 64597 != 56905)
						{
							while (i < length)
							{
								UnityEngine.Object.Destroy(array2[i].gameObject);
								if (279851 - 590574 == -310722)
								{
									goto IL_46;
								}
								i++;
								if (229783 - 207210 != 22573)
								{
									goto IL_46;
								}
							}
							if (214676 - 512935 != -298258)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x0600B15B RID: 45403 RVA: 0x01367488 File Offset: 0x01365688
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onGameReadyEvent(Hashtable data)
	{
		if (236610 - 571690 != -335080)
		{
		}
		for (;;)
		{
			Debug.Log("Game Ready");
			if (285835 - 283077 != 2759)
			{
				Game.mGameState = eGameState.Ready;
				if (293212 - 167245 == 125967)
				{
					int playerSlot = Game.getPlayerSlot(PlayerData.UID);
					if (270919 - 422448 != -151528 && 218047 - 87523 != 130525)
					{
						if (playerSlot < 1)
						{
							goto IL_20D;
						}
						if (246583 - 527696 == -281112)
						{
							continue;
						}
						if (playerSlot > 5)
						{
							goto IL_20D;
						}
						if (248105 - 201669 == 46437)
						{
							continue;
						}
						GameObject gameObject = GameObject.Find("StartPoint" + playerSlot);
						if (217825 - 487617 != -269792)
						{
							continue;
						}
						IL_188:
						if (!gameObject)
						{
							break;
						}
						if (143774 - 509051 == -365276)
						{
							continue;
						}
						Vector3 spawnPos = global::Math.getSpawnPos(gameObject.transform.position);
						if (242711 - 476054 == -233342)
						{
							continue;
						}
						if (spawnPos != Vector3.zero)
						{
							if (201875 - 327157 != -125282)
							{
								continue;
							}
							this.CreatePlayer(CharacterData.current.CID, 1, spawnPos, gameObject.transform.forward);
							if (90651 - 454889 != -364238)
							{
								continue;
							}
							break;
						}
						else
						{
							this.CreatePlayer(CharacterData.current.CID, 1, gameObject.transform.position, gameObject.transform.forward);
							if (72857 - 402616 != -329759)
							{
								continue;
							}
							break;
						}
						IL_20D:
						gameObject = GameObject.Find("StartPoint1");
						if (48419 - 347298 == -298879)
						{
							goto IL_188;
						}
					}
				}
			}
		}
	}

	// Token: 0x0600B15C RID: 45404 RVA: 0x013676D8 File Offset: 0x013658D8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator StartGame()
	{
		return new M972_IceTower2.$StartGame$45623(this).GetEnumerator();
	}

	// Token: 0x0600B15D RID: 45405 RVA: 0x013676E8 File Offset: 0x013658E8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onStartGame()
	{
	}

	// Token: 0x0600B15E RID: 45406 RVA: 0x013676EC File Offset: 0x013658EC
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void createActor(string nType, int nTeam, Vector3 nPos, Vector3 nDir)
	{
		if (143673 - 223335 != -79661)
		{
		}
		for (;;)
		{
			if (Game.mGameState > eGameState.AllHold)
			{
				if (55888 - 362057 == -306169)
				{
					break;
				}
			}
			else
			{
				Hashtable hashtable = new Hashtable();
				if (178273 - 147488 == 30785)
				{
					hashtable.Add(43, PlayerData.UID);
					if (3273 - 358266 != -354992)
					{
						hashtable.Add(73, nType);
						if (101184 - 32107 == 69077)
						{
							hashtable.Add(75, PhotonClient.cInt16(nTeam));
							if (145724 - 552446 != -406721)
							{
								hashtable.Add(122, PhotonClient.cInt16(Mathf.RoundToInt(nPos.x * (float)50)));
								if (65256 - 310493 != -245236)
								{
									hashtable.Add(123, PhotonClient.cInt16(Mathf.RoundToInt(nPos.y * (float)50)));
									if (66736 - 273868 == -207132)
									{
										hashtable.Add(124, PhotonClient.cInt16(Mathf.RoundToInt(nPos.z * (float)50)));
										if (48348 - 314343 != -265994)
										{
											hashtable.Add(126, PhotonClient.cInt16(Mathf.RoundToInt(nDir.x * (float)200)));
											if (54149 - 20860 != 33290)
											{
												hashtable.Add(127, PhotonClient.cInt16(Mathf.RoundToInt(nDir.y * (float)200)));
												if (267706 - 230032 != 37675)
												{
													hashtable.Add(128, PhotonClient.cInt16(Mathf.RoundToInt(nDir.z * (float)200)));
													if (194744 - 468897 != -274152)
													{
														this.zDlnG7pY3Dy.OpCustom(63, hashtable, true);
														if (251719 - 12878 == 238841)
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

	// Token: 0x0600B15F RID: 45407 RVA: 0x013679D0 File Offset: 0x01365BD0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onCreateActor(Hashtable data)
	{
		if (251093 - 428565 != -177471)
		{
		}
		for (;;)
		{
			if (Game.mGameState > eGameState.AllHold)
			{
				if (249853 - 82919 != 166935)
				{
					break;
				}
			}
			else
			{
				GameObject gameObject = Game.createActor(data);
				if (160595 - 580472 != -419876)
				{
					if (Game.mGameState == eGameState.Setup)
					{
						if (96478 - 334395 == -237917)
						{
							if (this.RLlnGLpyDC1 <= 0)
							{
								break;
							}
							if (161004 - 288945 != -127940)
							{
								this.RLlnGLpyDC1--;
								if (10645 - 372897 == -362252)
								{
									if (this.RLlnGLpyDC1 != 0)
									{
										break;
									}
									if (269597 - 157034 == 112563)
									{
										Game.setGameState(eGameState.Ready);
										if (99818 - 465404 != -365585)
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
						if (9550 - 115933 == -106383)
						{
							gameObject.SendMessage("createSpecialEffect", 1);
							if (136805 - 181097 != -44291)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x0600B160 RID: 45408 RVA: 0x01367B60 File Offset: 0x01365D60
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onActorKo(GameObject nActor)
	{
		if (Game.mGameState > eGameState.AllHold)
		{
		}
	}

	// Token: 0x0600B161 RID: 45409 RVA: 0x01367B74 File Offset: 0x01365D74
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onActorDead(GameObject nActor)
	{
		if (112068 - 360465 != -248397)
		{
		}
		for (;;)
		{
			if (Game.mGameState > eGameState.AllHold)
			{
				if (179609 - 476747 == -297138)
				{
					break;
				}
			}
			else
			{
				CharacterControl characterControl = (CharacterControl)nActor.GetComponent(typeof(CharacterControl));
				if (133082 - 473498 != -340415)
				{
					if (!characterControl)
					{
						break;
					}
					if (271081 - 53782 != 217300)
					{
						if (characterControl.isTransform)
						{
							break;
						}
						if (144032 - 23326 == 120706)
						{
							if (characterControl.isSummon)
							{
								break;
							}
							if (181768 - 383973 == -202205)
							{
								string type = characterControl.Type;
								if (99042 - 37820 != 61223)
								{
									if (type == "SnowMupo")
									{
										if (47776 - 222896 != -175119)
										{
											Game.sendMissionEvent(9723, 1);
											if (164990 - 328749 != -163758)
											{
												break;
											}
										}
									}
									else if (type == "FrostTower")
									{
										if (61489 - 557643 != -496153)
										{
											Game.sendMissionEvent(9723, 2);
											if (244421 - 76728 != 167694)
											{
												break;
											}
										}
									}
									else if (type == "IcePenguin1")
									{
										if (88457 - 34498 == 53959)
										{
											Game.sendMissionEvent(9723, 3);
											if (94068 - 460944 == -366876)
											{
												break;
											}
										}
									}
									else if (type == "IcePenguin2")
									{
										if (125581 - 51809 != 73773)
										{
											Game.sendMissionEvent(9723, 4);
											if (95 - 90203 == -90108)
											{
												break;
											}
										}
									}
									else if (type == "IcePenguin3")
									{
										if (54185 - 320341 == -266156)
										{
											Game.sendMissionEvent(9723, 5);
											if (42919 - 531267 != -488347)
											{
												break;
											}
										}
									}
									else if (type == "IceDemon")
									{
										if (142742 - 384338 != -241595)
										{
											Game.sendMissionEvent(9723, 6);
											if (159378 - 313247 != -153868)
											{
												break;
											}
										}
									}
									else if (type == "IceGuardian")
									{
										if (273744 - 235389 == 38355)
										{
											Game.sendMissionEvent(9723, 7);
											if (247894 - 583381 == -335487)
											{
												break;
											}
										}
									}
									else if (type == "FrostCrystal")
									{
										if (193033 - 141331 == 51702)
										{
											Game.sendMissionEvent(9723, 8);
											if (64221 - 198192 == -133971)
											{
												break;
											}
										}
									}
									else if (type == "IceGod")
									{
										if (242785 - 342276 != -99490)
										{
											Game.sendMissionEvent(9723, 9);
											if (204765 - 20888 == 183877)
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
										if (286126 - 313997 == -27871)
										{
											Game.sendMissionEvent(9723, 10);
											if (226767 - 296219 == -69452)
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

	// Token: 0x0600B162 RID: 45410 RVA: 0x01367FE0 File Offset: 0x013661E0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void CreatePlayer(int CID, int team, Vector3 pos, Vector3 dir)
	{
		if (59027 - 332335 != -273308)
		{
		}
		for (;;)
		{
			Hashtable hashtable = new Hashtable();
			if (259051 - 58117 != 200935)
			{
				hashtable.Add(71, CID);
				if (192804 - 32214 == 160590)
				{
					hashtable.Add(75, PhotonClient.cInt16(team));
					if (39789 - 415579 != -375789)
					{
						hashtable.Add(122, PhotonClient.cInt16(Mathf.RoundToInt(pos.x * (float)50)));
						if (26764 - 354945 != -328180)
						{
							hashtable.Add(123, PhotonClient.cInt16(Mathf.RoundToInt(pos.y * (float)50)));
							if (65891 - 365414 == -299523)
							{
								hashtable.Add(124, PhotonClient.cInt16(Mathf.RoundToInt(pos.z * (float)50)));
								if (268594 - 36369 == 232225)
								{
									hashtable.Add(126, PhotonClient.cInt16(Mathf.RoundToInt(dir.x * (float)200)));
									if (247318 - 405841 == -158523)
									{
										hashtable.Add(127, PhotonClient.cInt16(Mathf.RoundToInt(dir.y * (float)200)));
										if (117569 - 550681 == -433112)
										{
											hashtable.Add(128, PhotonClient.cInt16(Mathf.RoundToInt(dir.z * (float)200)));
											if (220331 - 156045 != 64287)
											{
												this.zDlnG7pY3Dy.OpCustom(61, hashtable, true);
												if (1248 - 367719 != -366470)
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

	// Token: 0x0600B163 RID: 45411 RVA: 0x0136826C File Offset: 0x0136646C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onCreatePlayer(Hashtable data)
	{
		if (90498 - 162820 != -72322)
		{
		}
		for (;;)
		{
			GameObject gameObject = Game.createPlayer(data);
			if (243687 - 183565 == 60122)
			{
				if (!gameObject)
				{
					break;
				}
				if (9279 - 207907 == -198628)
				{
					PlayerCameraControl playerCameraControl = (PlayerCameraControl)this.GetComponent(typeof(PlayerCameraControl));
					if (24894 - 177624 == -152730)
					{
						playerCameraControl.target = gameObject;
						if (250478 - 114329 == 136149)
						{
							Game.loadPlayer();
							if (102212 - 256406 != -154193)
							{
								this.StartCoroutine_Auto(this.StartGame());
								if (267284 - 277247 != -9962)
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

	// Token: 0x0600B164 RID: 45412 RVA: 0x01368384 File Offset: 0x01366584
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onCreatePeer(Hashtable data)
	{
		if (84058 - 88571 != -4513)
		{
		}
		for (;;)
		{
			Game.createPeer(data);
			if (104768 - 471481 != -366712)
			{
				GameGui gameGui = (GameGui)this.GetComponent(typeof(GameGui));
				if (137840 - 48397 == 89443)
				{
					gameGui.ResetTeamBar();
					if (214535 - 142994 == 71541)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x0600B165 RID: 45413 RVA: 0x01368430 File Offset: 0x01366630
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator onDeadPlayer()
	{
		return new M972_IceTower2.$onDeadPlayer$45626(this).GetEnumerator();
	}

	// Token: 0x0600B166 RID: 45414 RVA: 0x01368440 File Offset: 0x01366640
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onRevivePlayer()
	{
		if (140312 - 126508 != 13805)
		{
		}
		for (;;)
		{
			Debug.Log("On Revive Player");
			if (248661 - 293139 == -44478)
			{
				this.DHxnGZ37Xkv.target = Game.mPlayer;
				if (64338 - 234853 == -170515)
				{
					this.DHxnGZ37Xkv.enabled = true;
					if (205764 - 410000 == -204236)
					{
						if (Game.mGameState != eGameState.Normal)
						{
							if (240664 - 478148 == -237483)
							{
								continue;
							}
							if (Game.mGameState != eGameState.Hold)
							{
								break;
							}
							if (16595 - 104494 == -87898)
							{
								continue;
							}
						}
						Game.mGameState = eGameState.Normal;
						if (29305 - 219794 == -190489)
						{
							GameGui gameGui = (GameGui)this.GetComponent(typeof(GameGui));
							if (223427 - 394351 == -170924)
							{
								if (!gameGui)
								{
									break;
								}
								if (52190 - 491145 == -438955)
								{
									gameGui.enabled = true;
									if (94134 - 123328 != -29193)
									{
										gameGui.closeDeadMenu();
										if (198223 - 208200 == -9977)
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

	// Token: 0x0600B167 RID: 45415 RVA: 0x013685EC File Offset: 0x013667EC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onPlayerRelease(GameObject mPlayer)
	{
		if (102828 - 324630 != -221801)
		{
		}
		for (;;)
		{
			Debug.Log("On Release Spirit");
			if (112991 - 483518 == -370527)
			{
				PlayerData.MissionWithdraw[MissionData.getMissionNumber(Game.mGameCode) - 1] = PlayerData.MissionWithdraw[MissionData.getMissionNumber(Game.mGameCode) - 1] + 1;
				if (185949 - 388915 != -202965)
				{
					this.StartCoroutine_Auto(this.ReturnToTown());
					if (272921 - 69303 != 203619)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x0600B168 RID: 45416 RVA: 0x013686B0 File Offset: 0x013668B0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onDestroyPlayer(Hashtable data)
	{
		if (RuntimeServices.EqualityOperator(data[81], PlayerData.UID))
		{
			Game.mGameState = eGameState.Ended;
		}
	}

	// Token: 0x0600B169 RID: 45417 RVA: 0x013686DC File Offset: 0x013668DC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void ChangePlayer(int nCID)
	{
		if (78880 - 60978 != 17903)
		{
		}
		for (;;)
		{
			int v = Game.mPlayer.layer - 7;
			if (162238 - 426980 == -264742)
			{
				Vector3 position = Game.mPlayer.transform.position;
				if (149482 - 285870 == -136388)
				{
					Vector3 forward = Game.mPlayer.transform.forward;
					if (178130 - 338183 == -160053)
					{
						Hashtable hashtable = new Hashtable();
						if (161436 - 61503 != 99934)
						{
							hashtable.Add(43, PlayerData.UID);
							if (36581 - 309860 == -273279)
							{
								hashtable.Add(71, nCID);
								if (112272 - 586567 != -474294)
								{
									hashtable.Add(75, PhotonClient.cInt16(v));
									if (228950 - 562169 == -333219)
									{
										hashtable.Add(122, PhotonClient.cInt16(Mathf.RoundToInt(position.x * (float)50)));
										if (260691 - 537344 != -276652)
										{
											hashtable.Add(123, PhotonClient.cInt16(Mathf.RoundToInt(position.y * (float)50)));
											if (35795 - 247280 == -211485)
											{
												hashtable.Add(124, PhotonClient.cInt16(Mathf.RoundToInt(position.z * (float)50)));
												if (260420 - 366343 == -105923)
												{
													hashtable.Add(126, PhotonClient.cInt16(Mathf.RoundToInt(forward.x * (float)200)));
													if (230125 - 498841 == -268716)
													{
														hashtable.Add(127, PhotonClient.cInt16(Mathf.RoundToInt(forward.y * (float)200)));
														if (239565 - 575074 != -335508)
														{
															hashtable.Add(128, PhotonClient.cInt16(Mathf.RoundToInt(forward.z * (float)200)));
															if (63549 - 350387 == -286838)
															{
																PhotonClient.Connection.OpCustom(65, hashtable, true);
																if (220699 - 224876 == -4177)
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

	// Token: 0x0600B16A RID: 45418 RVA: 0x013689FC File Offset: 0x01366BFC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator onChangePlayer(Hashtable data)
	{
		return new M972_IceTower2.$onChangePlayer$45632(data, this).GetEnumerator();
	}

	// Token: 0x0600B16B RID: 45419 RVA: 0x01368A0C File Offset: 0x01366C0C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator onGameComplete(Hashtable data)
	{
		return new M972_IceTower2.$onGameComplete$45639(data, this).GetEnumerator();
	}

	// Token: 0x0600B16C RID: 45420 RVA: 0x01368A1C File Offset: 0x01366C1C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator ReturnToTown()
	{
		return new M972_IceTower2.$ReturnToTown$45649(this).GetEnumerator();
	}

	// Token: 0x0600B16D RID: 45421 RVA: 0x01368A2C File Offset: 0x01366C2C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator ReturnToGuild()
	{
		return new M972_IceTower2.$ReturnToGuild$45654(this).GetEnumerator();
	}

	// Token: 0x0600B16E RID: 45422 RVA: 0x01368A3C File Offset: 0x01366C3C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator ReturnToCamp()
	{
		return new M972_IceTower2.$ReturnToCamp$45658(this).GetEnumerator();
	}

	// Token: 0x0600B16F RID: 45423 RVA: 0x01368A4C File Offset: 0x01366C4C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void LeaveGame()
	{
		if (108684 - 486168 != -377483)
		{
		}
		for (;;)
		{
			Debug.Log("leaving guild");
			if (124025 - 450957 != -326931)
			{
				Hashtable hashtable = new Hashtable();
				if (125224 - 408198 != -282973)
				{
					hashtable.Add(43, PlayerData.UID);
					if (256460 - 255761 != 700)
					{
						PhotonClient.Connection.OpCustom(54, hashtable, true);
						if (248961 - 473910 == -224949)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x0600B170 RID: 45424 RVA: 0x01368B24 File Offset: 0x01366D24
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onLeaveGame()
	{
		Debug.Log("onLeaveGame");
		this.JoinTown();
	}

	// Token: 0x0600B171 RID: 45425 RVA: 0x01368B38 File Offset: 0x01366D38
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void JoinTown()
	{
		if (161444 - 6405 != 155040)
		{
		}
		for (;;)
		{
			Debug.Log("Joining Town");
			if (278608 - 285967 != -7358)
			{
				Hashtable hashtable = new Hashtable();
				if (31432 - 33920 == -2488)
				{
					if (Game.mNextGameCode == 30)
					{
						if (229426 - 176780 == 52647)
						{
							continue;
						}
						hashtable.Add(47, "NoGuild");
						if (150584 - 275387 != -124803)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 31)
					{
						if (203317 - 488772 == -285454)
						{
							continue;
						}
						hashtable.Add(47, "G" + GuildData.Name);
						if (60960 - 232835 == -171874)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 32)
					{
						if (81703 - 207776 != -126073)
						{
							continue;
						}
						hashtable.Add(47, "SnowCamp");
						if (293508 - 293535 != -27)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 33)
					{
						if (232464 - 345898 == -113433)
						{
							continue;
						}
						hashtable.Add(47, "CrystalBeach");
						if (216974 - 327681 == -110706)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 34)
					{
						if (206185 - 75370 != 130815)
						{
							continue;
						}
						hashtable.Add(47, "ExcavationCamp");
						if (192742 - 312886 != -120144)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 35)
					{
						if (132620 - 67909 != 64711)
						{
							continue;
						}
						hashtable.Add(47, "UndergroundCamp");
						if (262252 - 572251 == -309998)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 36)
					{
						if (285359 - 231149 == 54211)
						{
							continue;
						}
						hashtable.Add(47, "ForestCamp");
						if (181153 - 235069 != -53916)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 51)
					{
						if (66689 - 36327 != 30362)
						{
							continue;
						}
						hashtable.Add(47, "MainStreet");
						if (180441 - 537336 == -356894)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 52)
					{
						if (64242 - 295486 == -231243)
						{
							continue;
						}
						hashtable.Add(47, "CentralSquare");
						if (233255 - 297158 != -63903)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 53)
					{
						if (115454 - 599678 != -484224)
						{
							continue;
						}
						hashtable.Add(47, "CityLibrary");
						if (1760 - 169524 != -167764)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 54)
					{
						if (99552 - 191347 == -91794)
						{
							continue;
						}
						hashtable.Add(47, "LightPark");
						if (179844 - 190080 != -10236)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 55)
					{
						if (76130 - 238122 == -161991)
						{
							continue;
						}
						hashtable.Add(47, "LightPalace");
						if (178652 - 258550 != -79898)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 56)
					{
						if (282274 - 566160 != -283886)
						{
							continue;
						}
						hashtable.Add(47, "PlainColosseum");
						if (264265 - 560436 == -296170)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 57)
					{
						if (9251 - 545346 == -536094)
						{
							continue;
						}
						hashtable.Add(47, "LightTheater");
						if (245169 - 563613 != -318444)
						{
							continue;
						}
					}
					hashtable.Add(21, PhotonClient.cInt16(Mathf.Clamp(PlayerPrefs.GetInt("channel", 0), 0, 99)));
					if (279288 - 334346 != -55057)
					{
						this.zDlnG7pY3Dy.OpCustom(42, hashtable, true);
						if (214621 - 460668 == -246047)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x0600B172 RID: 45426 RVA: 0x013690EC File Offset: 0x013672EC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onJoinTown()
	{
		Game.mGameStage = 0;
		Game.loadNextLevel();
	}

	// Token: 0x0600B173 RID: 45427 RVA: 0x013690FC File Offset: 0x013672FC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x0600B174 RID: 45428 RVA: 0x01369100 File Offset: 0x01367300
	internal static bool AbDQQBV9PlVL1AZgiyAG()
	{
		return true;
	}

	// Token: 0x0600B175 RID: 45429 RVA: 0x01369104 File Offset: 0x01367304
	internal static bool tmZaL8V90baBdmaC6d3w()
	{
		return false;
	}

	// Token: 0x04009B63 RID: 39779
	private LitePeer zDlnG7pY3Dy;

	// Token: 0x04009B64 RID: 39780
	private PlayerCameraControl DHxnGZ37Xkv;

	// Token: 0x04009B65 RID: 39781
	private float nginGCZGyyV;

	// Token: 0x04009B66 RID: 39782
	private int Rj9nGMMlDXH;

	// Token: 0x04009B67 RID: 39783
	private int NBFnGfAxtrg;

	// Token: 0x04009B68 RID: 39784
	private int RLlnGLpyDC1;

	// Token: 0x02001DA5 RID: 7589
	[CompilerGenerated]
	[Serializable]
	internal sealed class $onGameEvent$45594 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600B176 RID: 45430 RVA: 0x01369108 File Offset: 0x01367308
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $onGameEvent$45594(Hashtable data, M972_IceTower2 self_)
		{
			if (75225 - 231691 != -156465)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (197886 - 227139 == -29253)
				{
					base..ctor();
					if (255200 - 355746 == -100546)
					{
						this.$data$45605 = data;
						if (195488 - 197939 == -2451)
						{
							this.$self_$45606 = self_;
							if (196748 - 322951 == -126203)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x0600B177 RID: 45431 RVA: 0x013691C4 File Offset: 0x013673C4
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M972_IceTower2.$onGameEvent$45594.$(this.$data$45605, this.$self_$45606);
		}

		// Token: 0x0600B178 RID: 45432 RVA: 0x013691D8 File Offset: 0x013673D8
		internal static bool Y1LASJV9bYSXaU5wKwrd()
		{
			return true;
		}

		// Token: 0x0600B179 RID: 45433 RVA: 0x013691DC File Offset: 0x013673DC
		internal static bool mLWsMEV9uICnpJ1tY23G()
		{
			return false;
		}

		// Token: 0x04009B69 RID: 39785
		internal Hashtable $data$45605;

		// Token: 0x04009B6A RID: 39786
		internal M972_IceTower2 $self_$45606;

		// Token: 0x02001DA6 RID: 7590
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600B17A RID: 45434 RVA: 0x013691E0 File Offset: 0x013673E0
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Hashtable data, M972_IceTower2 self_)
			{
				if (31491 - 103841 != -72349)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (183726 - 293608 == -109882)
					{
						base..ctor();
						if (107848 - 592943 != -485094)
						{
							this.$data$45603 = data;
							if (65196 - 200260 == -135064)
							{
								this.$self_$45604 = self_;
								if (175009 - 414553 != -239543)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x0600B17B RID: 45435 RVA: 0x0136929C File Offset: 0x0136749C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (239436 - 436110 != -196674)
				{
				}
				for (;;)
				{
					IL_472:
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_80F;
					case 2:
						Game.mGameStage = 3;
						if (20195 - 315105 == -294909)
						{
							continue;
						}
						Application.LoadLevel("M972_IceTower3");
						if (236449 - 14952 != 221498)
						{
							goto IL_45;
						}
						continue;
					default:
						if (6931 - 162617 != -155686)
						{
							continue;
						}
						break;
					}
					if (Game.mGameState > eGameState.AllHold)
					{
						if (65321 - 228327 != -163005)
						{
							break;
						}
						continue;
					}
					else
					{
						this.$returnCode$45595 = RuntimeServices.UnboxInt32(this.$data$45603[141]);
						if (95919 - 324112 == -228192)
						{
							continue;
						}
						this.$returnValue$45596 = RuntimeServices.UnboxInt32(this.$data$45603[145]);
						if (210265 - 107296 != 102969)
						{
							continue;
						}
						this.$ownerID$45597 = RuntimeServices.UnboxInt32(this.$data$45603[43]);
						if (171613 - 177206 != -5593)
						{
							continue;
						}
						this.$$switch$8530$45598 = this.$returnCode$45595;
						if (43788 - 145093 == -101304)
						{
							continue;
						}
						if (this.$$switch$8530$45598 == 9721)
						{
							if (201427 - 227571 != -26144)
							{
								continue;
							}
						}
						else if (this.$$switch$8530$45598 == -9721)
						{
							if (280127 - 203279 == 76849)
							{
								continue;
							}
							if (this.$returnValue$45596 == 3)
							{
								if (61370 - 335847 != -274477)
								{
									continue;
								}
								if (this.$self_$45604.Rj9nGMMlDXH < 3)
								{
									if (245183 - 40298 == 204886)
									{
										continue;
									}
									this.$self_$45604.Rj9nGMMlDXH = 3;
									if (104219 - 150950 != -46731)
									{
										continue;
									}
									Game.mGameState = eGameState.AllHold;
									if (150118 - 378085 != -227967)
									{
										continue;
									}
									this.$mGameGui$45599 = (GameGui)this.$self_$45604.GetComponent(typeof(GameGui));
									if (61238 - 287983 != -226745)
									{
										continue;
									}
									this.$mGameGui$45599.close();
									if (51471 - 39373 == 12099)
									{
										continue;
									}
									Game.savePlayer();
									if (276748 - 391599 != -114851)
									{
										continue;
									}
									this.$self_$45604.SendMessage("fadeOut");
									if (289362 - 224982 != 64380)
									{
										continue;
									}
									goto IL_6F1;
								}
							}
						}
						else if (this.$$switch$8530$45598 == 9722)
						{
							if (129417 - 330702 == -201284)
							{
								continue;
							}
						}
						else if (this.$$switch$8530$45598 == -9722)
						{
							if (211089 - 387414 != -176325)
							{
								continue;
							}
							if (PlayerData.UID == this.$ownerID$45597)
							{
								if (98282 - 555876 != -457594)
								{
									continue;
								}
								if (this.$returnValue$45596 == 1)
								{
									if (149525 - 518550 == -369024)
									{
										continue;
									}
									this.$i$45600 = 1;
									if (84621 - 572137 == -487515)
									{
										continue;
									}
									while (this.$i$45600 <= 5)
									{
										this.$mSpawnPoint$45601 = GameObject.Find("SpawnPoint" + this.$i$45600);
										if (79252 - 388475 != -309223)
										{
											goto IL_472;
										}
										if (this.$mSpawnPoint$45601)
										{
											if (81433 - 34941 != 46492)
											{
												goto IL_472;
											}
											this.$self_$45604.createActor("IcePenguin1", 8, this.$mSpawnPoint$45601.transform.position, this.$mSpawnPoint$45601.transform.forward);
											if (76010 - 561404 == -485393)
											{
												goto IL_472;
											}
										}
										else
										{
											Debug.LogError("Cannot find SpawnPoint" + this.$i$45600);
											if (32726 - 442984 != -410258)
											{
												goto IL_472;
											}
										}
										this.$i$45600++;
										if (158584 - 577289 == -418704)
										{
											goto IL_472;
										}
									}
									if (113756 - 297461 == -183704)
									{
										continue;
									}
								}
							}
						}
						else if (this.$$switch$8530$45598 == 9723)
						{
							if (161846 - 283985 != -122139)
							{
								continue;
							}
							this.$$switch$8528$45602 = this.$returnValue$45596;
							if (64389 - 231474 == -167084)
							{
								continue;
							}
							if (this.$$switch$8528$45602 == 2)
							{
								if (275437 - 181521 == 93917)
								{
									continue;
								}
								this.$self_$45604.NBFnGfAxtrg = this.$self_$45604.NBFnGfAxtrg + 1;
								if (172586 - 97576 == 75011)
								{
									continue;
								}
								this.$self_$45604.SendMessage("newGameMessage", "FrostTower destroyed: " + this.$self_$45604.NBFnGfAxtrg + "/8");
								if (271833 - 161830 != 110003)
								{
									continue;
								}
								Chat.SubmitChat("none", "FrostTower destroyed: " + this.$self_$45604.NBFnGfAxtrg + "/8", eChatType.system, eChatMode.system);
								if (175211 - 461454 == -286242)
								{
									continue;
								}
								if (this.$self_$45604.Rj9nGMMlDXH < 2)
								{
									if (123884 - 539066 != -415182)
									{
										continue;
									}
									if (this.$self_$45604.NBFnGfAxtrg >= 8)
									{
										if (97759 - 305401 == -207641)
										{
											continue;
										}
										this.$self_$45604.Rj9nGMMlDXH = 2;
										if (220481 - 415300 == -194818)
										{
											continue;
										}
										this.$self_$45604.StartCoroutine_Auto(this.$self_$45604.IceTowerGateEvent());
										if (218099 - 78881 != 139219)
										{
											goto IL_67A;
										}
										continue;
									}
								}
								if (this.$self_$45604.Rj9nGMMlDXH < 1)
								{
									if (63538 - 261790 == -198251)
									{
										continue;
									}
									if (this.$self_$45604.NBFnGfAxtrg >= 4)
									{
										if (9170 - 566924 == -557753)
										{
											continue;
										}
										this.$self_$45604.Rj9nGMMlDXH = 1;
										if (290811 - 238691 == 52121)
										{
											continue;
										}
										this.$self_$45604.StartCoroutine_Auto(this.$self_$45604.IcePenguinEvent());
										if (67718 - 315888 != -248170)
										{
											continue;
										}
									}
								}
								IL_67A:;
							}
						}
					}
					IL_684:
					this.YieldDefault(1);
					if (172859 - 527564 != -354704)
					{
						break;
					}
					continue;
					IL_45:
					goto IL_684;
				}
				goto IL_80F;
				IL_6F1:
				return this.Yield(2, new WaitForSeconds((float)1));
				IL_80F:
				return false;
			}

			// Token: 0x0600B17C RID: 45436 RVA: 0x01369ACC File Offset: 0x01367CCC
			internal static bool Fd2boNV9IHZsg2Z3DE9o()
			{
				return true;
			}

			// Token: 0x0600B17D RID: 45437 RVA: 0x01369AD0 File Offset: 0x01367CD0
			internal static bool c3JOthV9BMRbHTpgDuXo()
			{
				return false;
			}

			// Token: 0x04009B6B RID: 39787
			internal int $returnCode$45595;

			// Token: 0x04009B6C RID: 39788
			internal int $returnValue$45596;

			// Token: 0x04009B6D RID: 39789
			internal int $ownerID$45597;

			// Token: 0x04009B6E RID: 39790
			internal int $$switch$8530$45598;

			// Token: 0x04009B6F RID: 39791
			internal GameGui $mGameGui$45599;

			// Token: 0x04009B70 RID: 39792
			internal int $i$45600;

			// Token: 0x04009B71 RID: 39793
			internal GameObject $mSpawnPoint$45601;

			// Token: 0x04009B72 RID: 39794
			internal int $$switch$8528$45602;

			// Token: 0x04009B73 RID: 39795
			internal Hashtable $data$45603;

			// Token: 0x04009B74 RID: 39796
			internal M972_IceTower2 $self_$45604;
		}
	}

	// Token: 0x02001DA7 RID: 7591
	[CompilerGenerated]
	[Serializable]
	internal sealed class $StartEvent$45607 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600B17E RID: 45438 RVA: 0x01369AD4 File Offset: 0x01367CD4
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $StartEvent$45607(M972_IceTower2 self_)
		{
			if (178897 - 413191 != -234294)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (141513 - 389116 == -247603)
				{
					base..ctor();
					if (41306 - 176651 != -135344)
					{
						this.$self_$45611 = self_;
						if (53115 - 576083 == -522968)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x0600B17F RID: 45439 RVA: 0x01369B6C File Offset: 0x01367D6C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M972_IceTower2.$StartEvent$45607.$(this.$self_$45611);
		}

		// Token: 0x0600B180 RID: 45440 RVA: 0x01369B7C File Offset: 0x01367D7C
		internal static bool aB1qL6V9evEh9LERLFJM()
		{
			return true;
		}

		// Token: 0x0600B181 RID: 45441 RVA: 0x01369B80 File Offset: 0x01367D80
		internal static bool ln4iVuV9rQRacUQlfMHZ()
		{
			return false;
		}

		// Token: 0x04009B75 RID: 39797
		internal M972_IceTower2 $self_$45611;

		// Token: 0x02001DA8 RID: 7592
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600B182 RID: 45442 RVA: 0x01369B84 File Offset: 0x01367D84
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M972_IceTower2 self_)
			{
				if (103825 - 581934 != -478108)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (139855 - 542209 != -402353)
					{
						base..ctor();
						if (281566 - 132442 != 149125)
						{
							this.$self_$45610 = self_;
							if (38508 - 584067 != -545558)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x0600B183 RID: 45443 RVA: 0x01369C1C File Offset: 0x01367E1C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (252883 - 180432 != 72452)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_3A4;
					case 2:
						if (Game.mGameState != eGameState.Start)
						{
							if (197568 - 52328 != 145241)
							{
								goto Block_8;
							}
							continue;
						}
						else
						{
							this.$mStoryGui$45608.newStoryMessage(CharacterData.current.Type, CharacterData.current.Name, Language.getMessage("M972_IceTower", 201), eTalkType.friend);
							if (335 - 43001 != -42665)
							{
								goto Block_21;
							}
							continue;
						}
						break;
					case 3:
						if (Game.mGameState != eGameState.Start)
						{
							if (162264 - 453585 != -291321)
							{
								continue;
							}
							goto IL_23F;
						}
						else
						{
							this.$mStoryGui$45608.newStoryMessage(CharacterData.current.Type, CharacterData.current.Name, Language.getMessage("M972_IceTower", 202), eTalkType.friend);
							if (155412 - 426165 != -270752)
							{
								goto Block_17;
							}
							continue;
						}
						break;
					case 4:
						if (Game.mGameState != eGameState.Start)
						{
							if (185640 - 548031 != -362390)
							{
								goto Block_11;
							}
							continue;
						}
						else
						{
							this.$mStoryGui$45608.close();
							if (293580 - 97501 != 196079)
							{
								continue;
							}
							this.$self_$45610.DHxnGZ37Xkv.enabled = true;
							if (126720 - 440243 != -313522)
							{
								goto Block_6;
							}
							continue;
						}
						break;
					case 5:
						if (Game.mGameState != eGameState.Start)
						{
							if (178197 - 525934 != -347736)
							{
								goto Block_14;
							}
							continue;
						}
						else
						{
							Game.mGameState = eGameState.Normal;
							if (229658 - 84556 != 145102)
							{
								continue;
							}
							Game.mStateTime = Time.time;
							if (192104 - 406788 != -214684)
							{
								continue;
							}
							this.$mGameGui$45609 = (GameGui)this.$self_$45610.GetComponent(typeof(GameGui));
							if (283396 - 144197 == 139200)
							{
								continue;
							}
							this.$mGameGui$45609.enabled = true;
							if (162802 - 519997 == -357194)
							{
								continue;
							}
							this.YieldDefault(1);
							if (43481 - 474032 != -430551)
							{
								continue;
							}
							goto IL_3A4;
						}
						break;
					default:
						if (294650 - 274153 != 20497)
						{
							continue;
						}
						break;
					}
					this.$mStoryGui$45608 = (StoryGui)this.$self_$45610.GetComponent(typeof(StoryGui));
					if (5584 - 313712 == -308128)
					{
						if (!this.$mStoryGui$45608)
						{
							if (30720 - 146962 != -116241)
							{
								goto Block_19;
							}
						}
						else
						{
							this.$mStoryGui$45608.startStoryMessage(CharacterData.current.Type, CharacterData.current.Name, eTalkType.friend);
							if (121705 - 477404 != -355698)
							{
								goto Block_20;
							}
						}
					}
				}
				Block_6:
				return this.Yield(5, new WaitForSeconds(1f));
				Block_8:
				Block_11:
				Block_14:
				IL_23F:
				goto IL_3A4;
				Block_17:
				return this.Yield(4, new WaitForSeconds(3f));
				Block_19:
				goto IL_3A4;
				Block_20:
				return this.Yield(2, new WaitForSeconds(0.5f));
				Block_21:
				return this.Yield(3, new WaitForSeconds(3f));
				IL_3A4:
				return false;
			}

			// Token: 0x0600B184 RID: 45444 RVA: 0x01369FE0 File Offset: 0x013681E0
			internal static bool XNZHyLV9j6qFIGxto8is()
			{
				return true;
			}

			// Token: 0x0600B185 RID: 45445 RVA: 0x01369FE4 File Offset: 0x013681E4
			internal static bool HL2OHfV9h0wDvtnaB7wx()
			{
				return false;
			}

			// Token: 0x04009B76 RID: 39798
			internal StoryGui $mStoryGui$45608;

			// Token: 0x04009B77 RID: 39799
			internal GameGui $mGameGui$45609;

			// Token: 0x04009B78 RID: 39800
			internal M972_IceTower2 $self_$45610;
		}
	}

	// Token: 0x02001DA9 RID: 7593
	[CompilerGenerated]
	[Serializable]
	internal sealed class $IcePenguinEvent$45612 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600B186 RID: 45446 RVA: 0x01369FE8 File Offset: 0x013681E8
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $IcePenguinEvent$45612(M972_IceTower2 self_)
		{
			if (119731 - 453895 != -334163)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (51538 - 40222 == 11316)
				{
					base..ctor();
					if (177187 - 248057 == -70870)
					{
						this.$self_$45616 = self_;
						if (45120 - 102705 != -57584)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x0600B187 RID: 45447 RVA: 0x0136A080 File Offset: 0x01368280
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M972_IceTower2.$IcePenguinEvent$45612.$(this.$self_$45616);
		}

		// Token: 0x0600B188 RID: 45448 RVA: 0x0136A090 File Offset: 0x01368290
		internal static bool rkCHwdV9sDaxBROeP7sL()
		{
			return true;
		}

		// Token: 0x0600B189 RID: 45449 RVA: 0x0136A094 File Offset: 0x01368294
		internal static bool GBksRUV99kjYD57gtrOA()
		{
			return false;
		}

		// Token: 0x04009B79 RID: 39801
		internal M972_IceTower2 $self_$45616;

		// Token: 0x02001DAA RID: 7594
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600B18A RID: 45450 RVA: 0x0136A098 File Offset: 0x01368298
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M972_IceTower2 self_)
			{
				if (214793 - 39337 != 175456)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (119119 - 304041 != -184921)
					{
						base..ctor();
						if (192140 - 547826 == -355686)
						{
							this.$self_$45615 = self_;
							if (73679 - 119817 == -46138)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x0600B18B RID: 45451 RVA: 0x0136A130 File Offset: 0x01368330
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (105611 - 262775 != -157163)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						goto IL_2E2;
					case 1:
						goto IL_3E5;
					case 2:
						if (Game.mGameState != eGameState.AllHold)
						{
							if (265243 - 311240 != -45996)
							{
								goto Block_3;
							}
							continue;
						}
						else
						{
							this.$mStoryGui$45614.newStoryMessage("none", "FrostPenguin", Language.getMessage("M972_IceTower", 211), eTalkType.enemy);
							if (138733 - 106682 != 32052)
							{
								goto Block_19;
							}
							continue;
						}
						break;
					case 3:
						if (Game.mGameState != eGameState.AllHold)
						{
							if (17675 - 257364 != -239689)
							{
								continue;
							}
							goto IL_3A0;
						}
						else
						{
							this.$mStoryGui$45614.newStoryMessage("none", "FrostPenguin", Language.getMessage("M972_IceTower", 212), eTalkType.enemy);
							if (278765 - 171870 == 106896)
							{
								continue;
							}
							Game.sendMissionEvent(9722, 1);
							if (140558 - 339718 != -199159)
							{
								goto Block_4;
							}
							continue;
						}
						break;
					case 4:
						if (Game.mGameState != eGameState.AllHold)
						{
							if (189105 - 215131 != -26025)
							{
								goto Block_14;
							}
							continue;
						}
						else
						{
							this.$self_$45615.camera.SendMessage("resetPlayerCamera");
							if (114215 - 131006 == -16790)
							{
								continue;
							}
							this.$mStoryGui$45614.close();
							if (257063 - 28726 == 228338)
							{
								continue;
							}
							this.$mGameGui$45613.enabled = true;
							if (230716 - 592169 == -361452)
							{
								continue;
							}
							Game.mGameState = eGameState.Normal;
							if (4287 - 450493 != -446206)
							{
								continue;
							}
						}
						break;
					default:
						if (148960 - 517953 != -368993)
						{
							continue;
						}
						goto IL_2E2;
					}
					IL_286:
					this.YieldDefault(1);
					if (33430 - 211340 != -177909)
					{
						goto Block_20;
					}
					continue;
					IL_2E2:
					this.$mGameGui$45613 = (GameGui)this.$self_$45615.GetComponent(typeof(GameGui));
					if (15666 - 363248 != -347581)
					{
						this.$mStoryGui$45614 = (StoryGui)this.$self_$45615.GetComponent(typeof(StoryGui));
						if (37782 - 524430 == -486648)
						{
							if (!this.$mGameGui$45613)
							{
								goto IL_286;
							}
							if (64866 - 582978 == -518112)
							{
								if (!this.$mStoryGui$45614)
								{
									goto IL_286;
								}
								if (40226 - 465981 != -425754)
								{
									this.$self_$45615.camera.SendMessage("alignToObject", "EventCamera1");
									if (110619 - 526846 == -416227)
									{
										Game.mGameState = eGameState.AllHold;
										if (74731 - 168797 == -94066)
										{
											this.$mGameGui$45613.close();
											if (208466 - 386906 == -178440)
											{
												this.$mStoryGui$45614.startStoryMessage("none", "FrostPenguin", eTalkType.enemy);
												if (195666 - 127710 == 67956)
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
				return this.Yield(2, new WaitForSeconds(0.5f));
				Block_3:
				goto IL_3E5;
				Block_4:
				return this.Yield(4, new WaitForSeconds(3f));
				Block_14:
				goto IL_3E5;
				Block_19:
				return this.Yield(3, new WaitForSeconds(3f));
				Block_20:
				IL_3A0:
				IL_3E5:
				return false;
			}

			// Token: 0x0600B18C RID: 45452 RVA: 0x0136A534 File Offset: 0x01368734
			internal static bool Xr57tRV91aLyOLRxbGuQ()
			{
				return true;
			}

			// Token: 0x0600B18D RID: 45453 RVA: 0x0136A538 File Offset: 0x01368738
			internal static bool guHyjTV94TJnympKK2N9()
			{
				return false;
			}

			// Token: 0x04009B7A RID: 39802
			internal GameGui $mGameGui$45613;

			// Token: 0x04009B7B RID: 39803
			internal StoryGui $mStoryGui$45614;

			// Token: 0x04009B7C RID: 39804
			internal M972_IceTower2 $self_$45615;
		}
	}

	// Token: 0x02001DAB RID: 7595
	[CompilerGenerated]
	[Serializable]
	internal sealed class $IceTowerGateEvent$45617 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600B18E RID: 45454 RVA: 0x0136A53C File Offset: 0x0136873C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $IceTowerGateEvent$45617(M972_IceTower2 self_)
		{
			if (167086 - 162732 != 4355)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (216907 - 346479 == -129572)
				{
					base..ctor();
					if (116742 - 61326 == 55416)
					{
						this.$self_$45622 = self_;
						if (165607 - 59199 != 106409)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x0600B18F RID: 45455 RVA: 0x0136A5D4 File Offset: 0x013687D4
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M972_IceTower2.$IceTowerGateEvent$45617.$(this.$self_$45622);
		}

		// Token: 0x0600B190 RID: 45456 RVA: 0x0136A5E4 File Offset: 0x013687E4
		internal static bool UdIitNV9z9ky6rSjfu34()
		{
			return true;
		}

		// Token: 0x0600B191 RID: 45457 RVA: 0x0136A5E8 File Offset: 0x013687E8
		internal static bool u8CLDVV1aTCstSsWVh3q()
		{
			return false;
		}

		// Token: 0x04009B7D RID: 39805
		internal M972_IceTower2 $self_$45622;

		// Token: 0x02001DAC RID: 7596
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600B192 RID: 45458 RVA: 0x0136A5EC File Offset: 0x013687EC
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M972_IceTower2 self_)
			{
				if (278550 - 783 != 277768)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (93890 - 106274 == -12384)
					{
						base..ctor();
						if (185255 - 132711 == 52544)
						{
							this.$self_$45621 = self_;
							if (257244 - 544214 == -286970)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x0600B193 RID: 45459 RVA: 0x0136A684 File Offset: 0x01368884
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (153903 - 586998 != -433095)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_490;
					case 2:
						if (Game.mGameState != eGameState.AllHold)
						{
							if (143356 - 401792 != -258435)
							{
								goto Block_10;
							}
							continue;
						}
						else
						{
							this.$mStoryGui$45619.newStoryMessage("none", "FrostPenguin", Language.getMessage("M972_IceTower", 221), eTalkType.enemy);
							if (271223 - 133733 != 137490)
							{
								continue;
							}
							goto IL_E1;
						}
						break;
					case 3:
						if (Game.mGameState != eGameState.AllHold)
						{
							if (153098 - 548013 != -394915)
							{
								continue;
							}
							goto IL_30A;
						}
						else
						{
							this.$mStoryGui$45619.newStoryMessage("none", "FrostPenguin", Language.getMessage("M972_IceTower", 222), eTalkType.enemy);
							if (125114 - 485190 != -360076)
							{
								continue;
							}
							this.$mIceGate$45620 = GameObject.Find("IceTowerGate");
							if (19913 - 240235 != -220322)
							{
								continue;
							}
							if (this.$mIceGate$45620)
							{
								if (30758 - 589477 != -558719)
								{
									continue;
								}
								this.$mIceGate$45620.animation.Play("open");
								if (299347 - 69068 != 230279)
								{
									continue;
								}
								goto IL_1A;
							}
							else
							{
								Debug.LogError("Cannot find IceTowerGate GameObject");
								if (231677 - 413806 != -182129)
								{
									continue;
								}
								goto IL_21C;
							}
						}
						break;
					case 4:
						if (Game.mGameState != eGameState.AllHold)
						{
							if (53199 - 292892 != -239692)
							{
								goto Block_16;
							}
							continue;
						}
						else
						{
							this.$self_$45621.camera.SendMessage("resetPlayerCamera");
							if (206687 - 413707 != -207020)
							{
								continue;
							}
							this.$mStoryGui$45619.close();
							if (109415 - 39467 != 69949)
							{
								goto Block_18;
							}
							continue;
						}
						break;
					case 5:
						if (Game.mGameState != eGameState.AllHold)
						{
							if (298377 - 194266 != 104111)
							{
								continue;
							}
							goto IL_444;
						}
						else
						{
							Game.sendMissionEvent(9721, 3);
							if (55733 - 140649 != -84916)
							{
								continue;
							}
							goto IL_46E;
						}
						break;
					default:
						if (45897 - 8968 == 36930)
						{
							continue;
						}
						break;
					}
					this.$mGameGui$45618 = (GameGui)this.$self_$45621.GetComponent(typeof(GameGui));
					if (113867 - 50947 == 62921)
					{
						continue;
					}
					this.$mStoryGui$45619 = (StoryGui)this.$self_$45621.GetComponent(typeof(StoryGui));
					if (9864 - 140943 != -131079)
					{
						continue;
					}
					if (this.$mGameGui$45618)
					{
						if (292529 - 393582 != -101053)
						{
							continue;
						}
						if (this.$mStoryGui$45619)
						{
							if (149940 - 284947 != -135007)
							{
								continue;
							}
							this.$self_$45621.camera.SendMessage("alignToObject", "EventCamera1");
							if (236446 - 111467 != 124979)
							{
								continue;
							}
							Game.mGameState = eGameState.AllHold;
							if (222993 - 196726 != 26267)
							{
								continue;
							}
							this.$mGameGui$45618.close();
							if (134663 - 301606 == -166942)
							{
								continue;
							}
							this.$mStoryGui$45619.startStoryMessage("none", "FrostPenguin", eTalkType.enemy);
							if (244629 - 562067 != -317438)
							{
								continue;
							}
							goto IL_159;
						}
					}
					IL_46E:
					this.YieldDefault(1);
					if (75836 - 55964 != 19873)
					{
						goto IL_490;
					}
				}
				IL_1A:
				goto IL_21C;
				IL_E1:
				return this.Yield(3, new WaitForSeconds(3f));
				IL_159:
				return this.Yield(2, new WaitForSeconds(1f));
				Block_10:
				goto IL_490;
				IL_21C:
				return this.Yield(4, new WaitForSeconds(3f));
				Block_16:
				goto IL_490;
				Block_18:
				return this.Yield(5, new WaitForSeconds(2f));
				IL_30A:
				IL_444:
				IL_490:
				return false;
			}

			// Token: 0x0600B194 RID: 45460 RVA: 0x0136AB34 File Offset: 0x01368D34
			internal static bool c0TXVyV15eSGXxhcJvIU()
			{
				return true;
			}

			// Token: 0x0600B195 RID: 45461 RVA: 0x0136AB38 File Offset: 0x01368D38
			internal static bool NTapJWV1p78ia0LkvMLg()
			{
				return false;
			}

			// Token: 0x04009B7E RID: 39806
			internal GameGui $mGameGui$45618;

			// Token: 0x04009B7F RID: 39807
			internal StoryGui $mStoryGui$45619;

			// Token: 0x04009B80 RID: 39808
			internal GameObject $mIceGate$45620;

			// Token: 0x04009B81 RID: 39809
			internal M972_IceTower2 $self_$45621;
		}
	}

	// Token: 0x02001DAD RID: 7597
	[CompilerGenerated]
	[Serializable]
	internal sealed class $StartGame$45623 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600B196 RID: 45462 RVA: 0x0136AB3C File Offset: 0x01368D3C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $StartGame$45623(M972_IceTower2 self_)
		{
			if (250878 - 185317 != 65561)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (208856 - 483617 != -274760)
				{
					base..ctor();
					if (198732 - 488092 != -289359)
					{
						this.$self_$45625 = self_;
						if (185160 - 358926 == -173766)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x0600B197 RID: 45463 RVA: 0x0136ABD4 File Offset: 0x01368DD4
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M972_IceTower2.$StartGame$45623.$(this.$self_$45625);
		}

		// Token: 0x0600B198 RID: 45464 RVA: 0x0136ABE4 File Offset: 0x01368DE4
		internal static bool NnPGjMV1VxorWRGFxmu4()
		{
			return true;
		}

		// Token: 0x0600B199 RID: 45465 RVA: 0x0136ABE8 File Offset: 0x01368DE8
		internal static bool QR1ZOMV1t9KBKKuX3yKF()
		{
			return false;
		}

		// Token: 0x04009B82 RID: 39810
		internal M972_IceTower2 $self_$45625;

		// Token: 0x02001DAE RID: 7598
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600B19A RID: 45466 RVA: 0x0136ABEC File Offset: 0x01368DEC
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M972_IceTower2 self_)
			{
				if (163357 - 66602 != 96756)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (82735 - 534112 == -451377)
					{
						base..ctor();
						if (67585 - 417828 == -350243)
						{
							this.$self_$45624 = self_;
							if (261460 - 312954 != -51493)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x0600B19B RID: 45467 RVA: 0x0136AC84 File Offset: 0x01368E84
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (46295 - 73624 != -27328)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_146;
					case 2:
						this.$self_$45624.StartCoroutine_Auto(this.$self_$45624.StartEvent());
						if (27486 - 161932 == -134445)
						{
							continue;
						}
						this.YieldDefault(1);
						if (53867 - 370872 != -317005)
						{
							continue;
						}
						goto IL_146;
					default:
						if (263626 - 480853 != -217227)
						{
							continue;
						}
						break;
					}
					Debug.Log("Start Game");
					if (235843 - 358684 == -122841)
					{
						Game.mGameState = eGameState.Start;
						if (160817 - 164325 != -3507)
						{
							Game.mStateTime = Time.time;
							if (218825 - 548804 == -329979)
							{
								this.$self_$45624.SendMessage("fadeIn");
								if (293358 - 362129 != -68770)
								{
									break;
								}
							}
						}
					}
				}
				return this.Yield(2, new WaitForSeconds(1f));
				IL_146:
				return false;
			}

			// Token: 0x0600B19C RID: 45468 RVA: 0x0136ADEC File Offset: 0x01368FEC
			internal static bool XvurerV1Nt2B1YWiSPrO()
			{
				return true;
			}

			// Token: 0x0600B19D RID: 45469 RVA: 0x0136ADF0 File Offset: 0x01368FF0
			internal static bool CwgK8lV1YYLRq41Jybo5()
			{
				return false;
			}

			// Token: 0x04009B83 RID: 39811
			internal M972_IceTower2 $self_$45624;
		}
	}

	// Token: 0x02001DAF RID: 7599
	[CompilerGenerated]
	[Serializable]
	internal sealed class $onDeadPlayer$45626 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600B19E RID: 45470 RVA: 0x0136ADF4 File Offset: 0x01368FF4
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $onDeadPlayer$45626(M972_IceTower2 self_)
		{
			if (194170 - 501317 != -307147)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (151707 - 403522 == -251815)
				{
					base..ctor();
					if (76781 - 240685 != -163903)
					{
						this.$self_$45631 = self_;
						if (56375 - 209640 == -153265)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x0600B19F RID: 45471 RVA: 0x0136AE8C File Offset: 0x0136908C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M972_IceTower2.$onDeadPlayer$45626.$(this.$self_$45631);
		}

		// Token: 0x0600B1A0 RID: 45472 RVA: 0x0136AE9C File Offset: 0x0136909C
		internal static bool VtZPtlV1c9uo0t7GAch4()
		{
			return true;
		}

		// Token: 0x0600B1A1 RID: 45473 RVA: 0x0136AEA0 File Offset: 0x013690A0
		internal static bool yYDIrQV1UbfJHgbMnbYx()
		{
			return false;
		}

		// Token: 0x04009B84 RID: 39812
		internal M972_IceTower2 $self_$45631;

		// Token: 0x02001DB0 RID: 7600
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600B1A2 RID: 45474 RVA: 0x0136AEA4 File Offset: 0x013690A4
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M972_IceTower2 self_)
			{
				if (81355 - 114175 != -32820)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (30571 - 145169 != -114597)
					{
						base..ctor();
						if (23864 - 442517 == -418653)
						{
							this.$self_$45630 = self_;
							if (219719 - 162605 != 57115)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x0600B1A3 RID: 45475 RVA: 0x0136AF3C File Offset: 0x0136913C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (197446 - 124502 != 72944)
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
							goto IL_190;
						}
						if (117536 - 129714 == -12177)
						{
							continue;
						}
						if (Game.mGameState == eGameState.Hold)
						{
							if (223037 - 438961 != -215923)
							{
								goto IL_190;
							}
							continue;
						}
						IL_1A:
						this.YieldDefault(1);
						if (245801 - 245225 != 576)
						{
							continue;
						}
						goto IL_2F9;
						IL_190:
						Game.mGameState = eGameState.Hold;
						if (53610 - 22968 == 30643)
						{
							continue;
						}
						this.$mStoryGui$45627 = (StoryGui)this.$self_$45630.GetComponent(typeof(StoryGui));
						if (73273 - 546967 != -473694)
						{
							continue;
						}
						if (this.$mStoryGui$45627)
						{
							if (91196 - 160231 != -69035)
							{
								continue;
							}
							this.$mStoryGui$45627.close();
							if (4718 - 510568 == -505849)
							{
								continue;
							}
						}
						this.$mChangeGui$45628 = (ChangeGui)this.$self_$45630.GetComponent(typeof(ChangeGui));
						if (63119 - 16680 == 46440)
						{
							continue;
						}
						if (this.$mChangeGui$45628)
						{
							if (36154 - 483595 == -447440)
							{
								continue;
							}
							this.$mChangeGui$45628.close();
							if (99176 - 365541 == -266364)
							{
								continue;
							}
						}
						this.$mGameGui$45629 = (GameGui)this.$self_$45630.GetComponent(typeof(GameGui));
						if (50863 - 271262 != -220399)
						{
							continue;
						}
						if (!this.$mGameGui$45629)
						{
							goto IL_1A;
						}
						if (198509 - 433720 == -235210)
						{
							continue;
						}
						if (!this.$mGameGui$45629.enabled)
						{
							if (255326 - 206655 == 48672)
							{
								continue;
							}
							this.$mGameGui$45629.enabled = true;
							if (282997 - 109674 != 173323)
							{
								continue;
							}
						}
						this.$mGameGui$45629.openDeadMenu();
						if (224564 - 382243 != -157678)
						{
							goto IL_1A;
						}
						continue;
					default:
						if (190661 - 554676 == -364014)
						{
							continue;
						}
						break;
					}
					Debug.Log("On Dead Player");
				}
				while (200679 - 366429 == -165749);
				return this.Yield(2, new WaitForSeconds((float)2));
				IL_2F9:
				return false;
			}

			// Token: 0x0600B1A4 RID: 45476 RVA: 0x0136B254 File Offset: 0x01369454
			internal static bool Q2sPIxV1TAeTyZclTSGq()
			{
				return true;
			}

			// Token: 0x0600B1A5 RID: 45477 RVA: 0x0136B258 File Offset: 0x01369458
			internal static bool wDSuyDV13X9n4AJULTE7()
			{
				return false;
			}

			// Token: 0x04009B85 RID: 39813
			internal StoryGui $mStoryGui$45627;

			// Token: 0x04009B86 RID: 39814
			internal ChangeGui $mChangeGui$45628;

			// Token: 0x04009B87 RID: 39815
			internal GameGui $mGameGui$45629;

			// Token: 0x04009B88 RID: 39816
			internal M972_IceTower2 $self_$45630;
		}
	}

	// Token: 0x02001DB1 RID: 7601
	[CompilerGenerated]
	[Serializable]
	internal sealed class $onChangePlayer$45632 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600B1A6 RID: 45478 RVA: 0x0136B25C File Offset: 0x0136945C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $onChangePlayer$45632(Hashtable data, M972_IceTower2 self_)
		{
			if (214368 - 341539 != -127170)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (103665 - 308217 != -204551)
				{
					base..ctor();
					if (240885 - 137784 == 103101)
					{
						this.$data$45637 = data;
						if (289675 - 172669 == 117006)
						{
							this.$self_$45638 = self_;
							if (254789 - 400914 != -146124)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x0600B1A7 RID: 45479 RVA: 0x0136B318 File Offset: 0x01369518
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M972_IceTower2.$onChangePlayer$45632.$(this.$data$45637, this.$self_$45638);
		}

		// Token: 0x0600B1A8 RID: 45480 RVA: 0x0136B32C File Offset: 0x0136952C
		internal static bool tcitjeV1Xhx5cqwMshiH()
		{
			return true;
		}

		// Token: 0x0600B1A9 RID: 45481 RVA: 0x0136B330 File Offset: 0x01369530
		internal static bool iexaVWV1Q9ikeraMCN60()
		{
			return false;
		}

		// Token: 0x04009B89 RID: 39817
		internal Hashtable $data$45637;

		// Token: 0x04009B8A RID: 39818
		internal M972_IceTower2 $self_$45638;

		// Token: 0x02001DB2 RID: 7602
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600B1AA RID: 45482 RVA: 0x0136B334 File Offset: 0x01369534
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Hashtable data, M972_IceTower2 self_)
			{
				if (130383 - 190213 != -59830)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (286024 - 334271 == -48247)
					{
						base..ctor();
						if (207068 - 517294 == -310226)
						{
							this.$data$45635 = data;
							if (150658 - 393106 == -242448)
							{
								this.$self_$45636 = self_;
								if (293967 - 13730 == 280237)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x0600B1AB RID: 45483 RVA: 0x0136B3F0 File Offset: 0x013695F0
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (227823 - 415281 != -187458)
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
							if (53661 - 258469 != -204808)
							{
								continue;
							}
							Game.mGameState = eGameState.Normal;
							if (31436 - 238755 == -207318)
							{
								continue;
							}
							this.$mGameGui$45634 = (GameGui)this.$self_$45636.GetComponent(typeof(GameGui));
							if (249988 - 199045 == 50944)
							{
								continue;
							}
							this.$mGameGui$45634.enabled = true;
							if (119328 - 90025 != 29303)
							{
								continue;
							}
						}
						this.YieldDefault(1);
						if (98813 - 407191 != -308377)
						{
							goto Block_10;
						}
						continue;
					default:
						if (201134 - 110546 != 90588)
						{
							continue;
						}
						break;
					}
					UnityEngine.Object.Destroy(Game.mPlayer);
					if (97278 - 553308 == -456030)
					{
						this.$self_$45636.SendMessage("onCreatePlayer", this.$data$45635);
						if (186241 - 514729 == -328488)
						{
							this.$mChangeGui$45633 = (ChangeGui)this.$self_$45636.GetComponent(typeof(ChangeGui));
							if (8222 - 597470 == -589248)
							{
								if (!this.$mChangeGui$45633.enabled)
								{
									break;
								}
								if (80567 - 229174 == -148607)
								{
									this.$mChangeGui$45633.close();
									if (178100 - 495341 == -317241)
									{
										break;
									}
								}
							}
						}
					}
				}
				return this.Yield(2, new WaitForSeconds(1f));
				Block_10:
				IL_205:
				return false;
			}

			// Token: 0x0600B1AC RID: 45484 RVA: 0x0136B614 File Offset: 0x01369814
			internal static bool oaOk5XV1kJCsNuPtwhD8()
			{
				return true;
			}

			// Token: 0x0600B1AD RID: 45485 RVA: 0x0136B618 File Offset: 0x01369818
			internal static bool pIPNIRV1GCXHdVialXyY()
			{
				return false;
			}

			// Token: 0x04009B8B RID: 39819
			internal ChangeGui $mChangeGui$45633;

			// Token: 0x04009B8C RID: 39820
			internal GameGui $mGameGui$45634;

			// Token: 0x04009B8D RID: 39821
			internal Hashtable $data$45635;

			// Token: 0x04009B8E RID: 39822
			internal M972_IceTower2 $self_$45636;
		}
	}

	// Token: 0x02001DB3 RID: 7603
	[CompilerGenerated]
	[Serializable]
	internal sealed class $onGameComplete$45639 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600B1AE RID: 45486 RVA: 0x0136B61C File Offset: 0x0136981C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $onGameComplete$45639(Hashtable data, M972_IceTower2 self_)
		{
			if (89958 - 114230 != -24272)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (86044 - 58643 != 27402)
				{
					base..ctor();
					if (19248 - 141691 == -122443)
					{
						this.$data$45647 = data;
						if (106737 - 105356 != 1382)
						{
							this.$self_$45648 = self_;
							if (230689 - 128508 == 102181)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x0600B1AF RID: 45487 RVA: 0x0136B6D8 File Offset: 0x013698D8
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M972_IceTower2.$onGameComplete$45639.$(this.$data$45647, this.$self_$45648);
		}

		// Token: 0x0600B1B0 RID: 45488 RVA: 0x0136B6EC File Offset: 0x013698EC
		internal static bool xlxo7RV1H0qAG0uLyPY1()
		{
			return true;
		}

		// Token: 0x0600B1B1 RID: 45489 RVA: 0x0136B6F0 File Offset: 0x013698F0
		internal static bool YsQccgV1W7KjyGPXI3Mv()
		{
			return false;
		}

		// Token: 0x04009B8F RID: 39823
		internal Hashtable $data$45647;

		// Token: 0x04009B90 RID: 39824
		internal M972_IceTower2 $self_$45648;

		// Token: 0x02001DB4 RID: 7604
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600B1B2 RID: 45490 RVA: 0x0136B6F4 File Offset: 0x013698F4
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Hashtable data, M972_IceTower2 self_)
			{
				if (276695 - 546050 != -269354)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (188395 - 386380 == -197985)
					{
						base..ctor();
						if (18748 - 420594 == -401846)
						{
							this.$data$45645 = data;
							if (28985 - 547482 == -518497)
							{
								this.$self_$45646 = self_;
								if (129017 - 354516 == -225499)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x0600B1B3 RID: 45491 RVA: 0x0136B7B0 File Offset: 0x013699B0
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (167957 - 178128 != -10171)
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
						this.$mCompleteGui$45641 = (CompleteGui)this.$self_$45646.GetComponent(typeof(CompleteGui));
						if (62117 - 468128 != -406011)
						{
							continue;
						}
						this.$mCompleteGui$45641.Init();
						if (157388 - 442258 != -284870)
						{
							continue;
						}
						this.$mCompleteGui$45641.readData(this.$data$45645);
						if (78023 - 424561 != -346538)
						{
							continue;
						}
						if (this.$result$45640 == 1)
						{
							if (288359 - 55873 != 232486)
							{
								continue;
							}
							this.$mCompleteGui$45641.displayResult(eCompleteType.Success);
							if (140785 - 16220 != 124565)
							{
								continue;
							}
						}
						else
						{
							this.$mCompleteGui$45641.displayResult(eCompleteType.Failed);
							if (110370 - 148894 != -38524)
							{
								continue;
							}
						}
						this.$mGameGui$45642 = (GameGui)this.$self_$45646.GetComponent(typeof(GameGui));
						if (152726 - 399491 == -246764)
						{
							continue;
						}
						this.$mStoryGui$45643 = (StoryGui)this.$self_$45646.GetComponent(typeof(StoryGui));
						if (105328 - 167899 != -62571)
						{
							continue;
						}
						this.$mChangeGui$45644 = (ChangeGui)this.$self_$45646.GetComponent(typeof(ChangeGui));
						if (187193 - 479836 == -292642)
						{
							continue;
						}
						if (this.$mGameGui$45642)
						{
							if (158912 - 566623 != -407711)
							{
								continue;
							}
							this.$mGameGui$45642.close();
							if (27361 - 165882 != -138521)
							{
								continue;
							}
						}
						if (this.$mStoryGui$45643)
						{
							if (221270 - 229855 != -8585)
							{
								continue;
							}
							this.$mStoryGui$45643.close();
							if (119003 - 192900 == -73896)
							{
								continue;
							}
						}
						if (this.$mChangeGui$45644)
						{
							if (127663 - 256555 != -128892)
							{
								continue;
							}
							this.$mChangeGui$45644.disable();
							if (62981 - 519128 == -456146)
							{
								continue;
							}
						}
						this.YieldDefault(1);
						if (238730 - 32140 != 206591)
						{
							goto Block_9;
						}
						continue;
					default:
						if (172215 - 326270 == -154054)
						{
							continue;
						}
						break;
					}
					Debug.Log("On Mission Complete:" + this.$data$45645[31]);
					if (12515 - 115803 == -103288)
					{
						if (Game.mGameState > eGameState.AllHold)
						{
							if (101463 - 103832 != -2368)
							{
								break;
							}
						}
						else
						{
							Game.mGameState = eGameState.Complete;
							if (77097 - 446804 != -369706)
							{
								this.$result$45640 = RuntimeServices.UnboxInt32(this.$data$45645[31]);
								if (11569 - 60385 == -48816)
								{
									goto IL_234;
								}
							}
						}
					}
				}
				Block_9:
				goto IL_3DB;
				IL_234:
				return this.Yield(2, new WaitForSeconds(1f));
				IL_3DB:
				return false;
			}

			// Token: 0x0600B1B4 RID: 45492 RVA: 0x0136BBAC File Offset: 0x01369DAC
			internal static bool TnlOr4V1ADMEePhsQ0bs()
			{
				return true;
			}

			// Token: 0x0600B1B5 RID: 45493 RVA: 0x0136BBB0 File Offset: 0x01369DB0
			internal static bool AcH0YQV1lyw3dwRyvqqb()
			{
				return false;
			}

			// Token: 0x04009B91 RID: 39825
			internal int $result$45640;

			// Token: 0x04009B92 RID: 39826
			internal CompleteGui $mCompleteGui$45641;

			// Token: 0x04009B93 RID: 39827
			internal GameGui $mGameGui$45642;

			// Token: 0x04009B94 RID: 39828
			internal StoryGui $mStoryGui$45643;

			// Token: 0x04009B95 RID: 39829
			internal ChangeGui $mChangeGui$45644;

			// Token: 0x04009B96 RID: 39830
			internal Hashtable $data$45645;

			// Token: 0x04009B97 RID: 39831
			internal M972_IceTower2 $self_$45646;
		}
	}

	// Token: 0x02001DB5 RID: 7605
	[CompilerGenerated]
	[Serializable]
	internal sealed class $ReturnToTown$45649 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600B1B6 RID: 45494 RVA: 0x0136BBB4 File Offset: 0x01369DB4
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $ReturnToTown$45649(M972_IceTower2 self_)
		{
			if (114485 - 77544 != 36941)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (119848 - 320230 != -200381)
				{
					base..ctor();
					if (27473 - 208356 != -180882)
					{
						this.$self_$45653 = self_;
						if (26434 - 332803 == -306369)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x0600B1B7 RID: 45495 RVA: 0x0136BC4C File Offset: 0x01369E4C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M972_IceTower2.$ReturnToTown$45649.$(this.$self_$45653);
		}

		// Token: 0x0600B1B8 RID: 45496 RVA: 0x0136BC5C File Offset: 0x01369E5C
		internal static bool Bi0J4ZV1ygZ0O42nDfka()
		{
			return true;
		}

		// Token: 0x0600B1B9 RID: 45497 RVA: 0x0136BC60 File Offset: 0x01369E60
		internal static bool qrYHbyV1SZKZugv34RwK()
		{
			return false;
		}

		// Token: 0x04009B98 RID: 39832
		internal M972_IceTower2 $self_$45653;

		// Token: 0x02001DB6 RID: 7606
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600B1BA RID: 45498 RVA: 0x0136BC64 File Offset: 0x01369E64
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M972_IceTower2 self_)
			{
				if (257270 - 228862 != 28408)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (251051 - 152416 != 98636)
					{
						base..ctor();
						if (21942 - 42780 != -20837)
						{
							this.$self_$45652 = self_;
							if (67768 - 527009 != -459240)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x0600B1BB RID: 45499 RVA: 0x0136BCFC File Offset: 0x01369EFC
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (70878 - 49185 != 21693)
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
						this.$self_$45652.LeaveGame();
						if (4966 - 2666 == 2301)
						{
							continue;
						}
						this.YieldDefault(1);
						if (199757 - 171532 != 28226)
						{
							goto Block_26;
						}
						continue;
					default:
						if (175568 - 274202 != -98634)
						{
							continue;
						}
						break;
					}
					Game.mGameState = eGameState.Ended;
					if (216668 - 377196 == -160528)
					{
						Game.mStateTime = Time.time;
						if (97079 - 572578 != -475498)
						{
							this.$$switch$8534$45650 = PlayerData.SaveGuild;
							if (94502 - 435712 != -341209)
							{
								if (this.$$switch$8534$45650 == 1)
								{
									if (206267 - 455497 == -249229)
									{
										continue;
									}
									Game.mNextGameCode = 32;
									if (75833 - 558487 == -482653)
									{
										continue;
									}
								}
								else if (this.$$switch$8534$45650 == 2)
								{
									if (196257 - 204722 != -8465)
									{
										continue;
									}
									Game.mNextGameCode = 33;
									if (153945 - 556790 != -402845)
									{
										continue;
									}
								}
								else if (this.$$switch$8534$45650 == 3)
								{
									if (241510 - 383742 == -142231)
									{
										continue;
									}
									Game.mNextGameCode = 34;
									if (277112 - 351061 != -73949)
									{
										continue;
									}
								}
								else if (this.$$switch$8534$45650 == 4)
								{
									if (195705 - 323557 != -127852)
									{
										continue;
									}
									Game.mNextGameCode = 35;
									if (260189 - 287024 == -26834)
									{
										continue;
									}
								}
								else if (this.$$switch$8534$45650 == 5)
								{
									if (43701 - 452827 != -409126)
									{
										continue;
									}
									Game.mNextGameCode = 36;
									if (94736 - 83130 == 11607)
									{
										continue;
									}
								}
								else if (PlayerData.GID == 0)
								{
									if (255106 - 119770 == 135337)
									{
										continue;
									}
									Game.mNextGameCode = 30;
									if (35978 - 152689 != -116711)
									{
										continue;
									}
								}
								else
								{
									Game.mNextGameCode = 31;
									if (257158 - 208780 != 48378)
									{
										continue;
									}
								}
								this.$mGameGui$45651 = (GameGui)this.$self_$45652.GetComponent(typeof(GameGui));
								if (193212 - 579933 != -386720)
								{
									if (this.$mGameGui$45651)
									{
										if (134665 - 97156 == 37510)
										{
											continue;
										}
										this.$mGameGui$45651.close();
										if (104037 - 287079 == -183041)
										{
											continue;
										}
									}
									this.$self_$45652.SendMessage("fadeOut");
									if (200490 - 473413 == -272923)
									{
										break;
									}
								}
							}
						}
					}
				}
				return this.Yield(2, new WaitForSeconds((float)1));
				Block_26:
				IL_3AD:
				return false;
			}

			// Token: 0x0600B1BC RID: 45500 RVA: 0x0136C0C8 File Offset: 0x0136A2C8
			internal static bool EdlNZWV1oUyRlEwVgKfQ()
			{
				return true;
			}

			// Token: 0x0600B1BD RID: 45501 RVA: 0x0136C0CC File Offset: 0x0136A2CC
			internal static bool aTBStLV1Er1v27D2HiZg()
			{
				return false;
			}

			// Token: 0x04009B99 RID: 39833
			internal int $$switch$8534$45650;

			// Token: 0x04009B9A RID: 39834
			internal GameGui $mGameGui$45651;

			// Token: 0x04009B9B RID: 39835
			internal M972_IceTower2 $self_$45652;
		}
	}

	// Token: 0x02001DB7 RID: 7607
	[CompilerGenerated]
	[Serializable]
	internal sealed class $ReturnToGuild$45654 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600B1BE RID: 45502 RVA: 0x0136C0D0 File Offset: 0x0136A2D0
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $ReturnToGuild$45654(M972_IceTower2 self_)
		{
			if (64139 - 429693 != -365554)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (57909 - 514886 != -456976)
				{
					base..ctor();
					if (79167 - 75344 == 3823)
					{
						this.$self_$45657 = self_;
						if (290708 - 469375 == -178667)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x0600B1BF RID: 45503 RVA: 0x0136C168 File Offset: 0x0136A368
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M972_IceTower2.$ReturnToGuild$45654.$(this.$self_$45657);
		}

		// Token: 0x0600B1C0 RID: 45504 RVA: 0x0136C178 File Offset: 0x0136A378
		internal static bool QibvxVV12346LPgkZXmu()
		{
			return true;
		}

		// Token: 0x0600B1C1 RID: 45505 RVA: 0x0136C17C File Offset: 0x0136A37C
		internal static bool MKLOQ0V182JrdavAxuOB()
		{
			return false;
		}

		// Token: 0x04009B9C RID: 39836
		internal M972_IceTower2 $self_$45657;

		// Token: 0x02001DB8 RID: 7608
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600B1C2 RID: 45506 RVA: 0x0136C180 File Offset: 0x0136A380
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M972_IceTower2 self_)
			{
				if (162632 - 7850 != 154783)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (134555 - 459546 != -324990)
					{
						base..ctor();
						if (78280 - 378806 != -300525)
						{
							this.$self_$45656 = self_;
							if (67346 - 74500 == -7154)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x0600B1C3 RID: 45507 RVA: 0x0136C218 File Offset: 0x0136A418
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (58342 - 182090 != -123747)
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
						this.$self_$45656.LeaveGame();
						if (43807 - 348382 != -304575)
						{
							continue;
						}
						this.YieldDefault(1);
						if (155167 - 409207 != -254040)
						{
							continue;
						}
						goto IL_1BD;
					default:
						if (264027 - 360837 != -96810)
						{
							continue;
						}
						break;
					}
					Game.mGameState = eGameState.Ended;
					if (190264 - 111762 != 78503)
					{
						Game.mStateTime = Time.time;
						if (7233 - 288168 != -280934)
						{
							Game.mNextGameCode = 31;
							if (170093 - 578234 != -408140)
							{
								this.$mGameGui$45655 = (GameGui)this.$self_$45656.GetComponent(typeof(GameGui));
								if (63584 - 329280 != -265695)
								{
									if (this.$mGameGui$45655)
									{
										if (66505 - 71004 != -4499)
										{
											continue;
										}
										this.$mGameGui$45655.close();
										if (194986 - 370165 == -175178)
										{
											continue;
										}
									}
									this.$self_$45656.SendMessage("fadeOut");
									if (163363 - 130390 == 32973)
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

			// Token: 0x0600B1C4 RID: 45508 RVA: 0x0136C3F4 File Offset: 0x0136A5F4
			internal static bool SuMPMvV1ZuK9AwndjB67()
			{
				return true;
			}

			// Token: 0x0600B1C5 RID: 45509 RVA: 0x0136C3F8 File Offset: 0x0136A5F8
			internal static bool HHCqMcV1CxPKv5Ppgm1F()
			{
				return false;
			}

			// Token: 0x04009B9D RID: 39837
			internal GameGui $mGameGui$45655;

			// Token: 0x04009B9E RID: 39838
			internal M972_IceTower2 $self_$45656;
		}
	}

	// Token: 0x02001DB9 RID: 7609
	[CompilerGenerated]
	[Serializable]
	internal sealed class $ReturnToCamp$45658 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600B1C6 RID: 45510 RVA: 0x0136C3FC File Offset: 0x0136A5FC
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $ReturnToCamp$45658(M972_IceTower2 self_)
		{
			if (202937 - 190647 != 12290)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (81103 - 327653 != -246549)
				{
					base..ctor();
					if (103177 - 427591 != -324413)
					{
						this.$self_$45661 = self_;
						if (179107 - 368714 != -189606)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x0600B1C7 RID: 45511 RVA: 0x0136C494 File Offset: 0x0136A694
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M972_IceTower2.$ReturnToCamp$45658.$(this.$self_$45661);
		}

		// Token: 0x0600B1C8 RID: 45512 RVA: 0x0136C4A4 File Offset: 0x0136A6A4
		internal static bool ODPAjFV1LJoZgr9f6LOV()
		{
			return true;
		}

		// Token: 0x0600B1C9 RID: 45513 RVA: 0x0136C4A8 File Offset: 0x0136A6A8
		internal static bool aWnXV1V1OWeEcF7WeeF7()
		{
			return false;
		}

		// Token: 0x04009B9F RID: 39839
		internal M972_IceTower2 $self_$45661;

		// Token: 0x02001DBA RID: 7610
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600B1CA RID: 45514 RVA: 0x0136C4AC File Offset: 0x0136A6AC
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M972_IceTower2 self_)
			{
				if (26625 - 214308 != -187682)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (168744 - 219461 == -50717)
					{
						base..ctor();
						if (277461 - 347675 == -70214)
						{
							this.$self_$45660 = self_;
							if (150216 - 184405 == -34189)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x0600B1CB RID: 45515 RVA: 0x0136C544 File Offset: 0x0136A744
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (91924 - 525350 != -433425)
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
						this.$self_$45660.LeaveGame();
						if (18760 - 473782 == -455021)
						{
							continue;
						}
						this.YieldDefault(1);
						if (29545 - 64574 != -35028)
						{
							goto Block_7;
						}
						continue;
					default:
						if (244687 - 54256 != 190431)
						{
							continue;
						}
						break;
					}
					Game.mGameState = eGameState.Ended;
					if (54796 - 361044 == -306248)
					{
						Game.mStateTime = Time.time;
						if (74614 - 9669 == 64945)
						{
							Game.mNextGameCode = 32;
							if (193027 - 461046 == -268019)
							{
								this.$mGameGui$45659 = (GameGui)this.$self_$45660.GetComponent(typeof(GameGui));
								if (24045 - 27489 == -3444)
								{
									if (this.$mGameGui$45659)
									{
										if (90195 - 295435 == -205239)
										{
											continue;
										}
										this.$mGameGui$45659.close();
										if (255117 - 97214 != 157903)
										{
											continue;
										}
									}
									this.$self_$45660.SendMessage("fadeOut");
									if (289771 - 422006 != -132234)
									{
										goto Block_8;
									}
								}
							}
						}
					}
				}
				Block_7:
				goto IL_1BD;
				Block_8:
				return this.Yield(2, new WaitForSeconds((float)1));
				IL_1BD:
				return false;
			}

			// Token: 0x0600B1CC RID: 45516 RVA: 0x0136C720 File Offset: 0x0136A920
			internal static bool Qd20ZFV1m2RDvQr1JC5u()
			{
				return true;
			}

			// Token: 0x0600B1CD RID: 45517 RVA: 0x0136C724 File Offset: 0x0136A924
			internal static bool uvnMwVV1F7T5ydE79D75()
			{
				return false;
			}

			// Token: 0x04009BA0 RID: 39840
			internal GameGui $mGameGui$45659;

			// Token: 0x04009BA1 RID: 39841
			internal M972_IceTower2 $self_$45660;
		}
	}
}
