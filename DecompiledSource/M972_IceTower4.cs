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

// Token: 0x02001DD0 RID: 7632
[Serializable]
public class M972_IceTower4 : MonoBehaviour
{
	// Token: 0x0600B24A RID: 45642 RVA: 0x013733A8 File Offset: 0x013715A8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public M972_IceTower4()
	{
		LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
		base..ctor();
	}

	// Token: 0x0600B24B RID: 45643 RVA: 0x013733B8 File Offset: 0x013715B8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Awake()
	{
		if (33775 - 589875 != -556099)
		{
		}
		for (;;)
		{
			Game.mGameState = eGameState.Init;
			if (124627 - 538495 != -413867)
			{
				Game.mGameType = 5;
				if (56087 - 336361 != -280273)
				{
					if (Chat.Initialized)
					{
						if (79765 - 336279 != -256513)
						{
							Chat.ChatDisplay.Clear();
							if (150110 - 180878 != -30767)
							{
								break;
							}
						}
					}
					else
					{
						Chat.Init();
						if (16044 - 178633 != -162588)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x0600B24C RID: 45644 RVA: 0x0137349C File Offset: 0x0137169C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Start()
	{
		if (205185 - 320359 != -115173)
		{
		}
		for (;;)
		{
			if (PhotonClient.IsInitialized())
			{
				if (14705 - 59519 != -44813)
				{
					if (Game.mNextGameCode != 972)
					{
						break;
					}
					if (121883 - 17366 == 104517)
					{
						if (Game.mGameStage != 4)
						{
							break;
						}
						if (158095 - 525447 != -367351)
						{
							Game.nextGame();
							if (67752 - 590727 == -522975)
							{
								Game.mGameCode = 972;
								if (181711 - 86088 == 95623)
								{
									Game.mGameType = 5;
									if (6807 - 534552 == -527745)
									{
										Game.mStateTime = Time.time;
										if (54575 - 193820 != -139244)
										{
											Game.canUseMount = false;
											if (253733 - 240934 != 12800)
											{
												this.mLJnG8rKkfw = (PlayerCameraControl)this.GetComponent(typeof(PlayerCameraControl));
												if (91970 - 414823 == -322853)
												{
													this.i1QnG0S6G5w = PhotonClient.Connection;
													if (42354 - 421231 == -378877)
													{
														PhotonClient.ActorNrList.Clear();
														if (41510 - 82365 == -40855)
														{
															this.InitGame();
															if (96793 - 41828 != 54966)
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
			else
			{
				Debug.Log("Not Connected");
				if (33625 - 322646 != -289020)
				{
					Game.mGameType = 99;
					if (199982 - 140215 != 59768)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x0600B24D RID: 45645 RVA: 0x013736DC File Offset: 0x013718DC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void FixedUpdate()
	{
		if (239444 - 164947 != 74498)
		{
		}
		for (;;)
		{
			if (this.i1QnG0S6G5w == null)
			{
				if (87620 - 69962 == 17658)
				{
					break;
				}
			}
			else
			{
				eGameState mGameState = Game.mGameState;
				if (79972 - 93974 != -14001)
				{
					if (mGameState == eGameState.Init)
					{
						if (291193 - 183237 == 107956)
						{
							AudioListener.volume = 0.1f * (float)Game.volume;
							if (221214 - 385477 == -164263)
							{
								break;
							}
						}
					}
					else if (mGameState == eGameState.Setup)
					{
						if (167930 - 51419 == 116511)
						{
							break;
						}
					}
					else if (mGameState == eGameState.Ready)
					{
						if (83277 - 408891 != -325613)
						{
							break;
						}
					}
					else if (mGameState == eGameState.Start)
					{
						if (83384 - 307968 != -224583)
						{
							break;
						}
					}
					else if (mGameState == eGameState.Normal)
					{
						if (201628 - 506053 == -304425)
						{
							if (Game.music != 0)
							{
								if (188218 - 296629 == -108410)
								{
									continue;
								}
								if (!this.audio.isPlaying)
								{
									if (73532 - 282389 != -208857)
									{
										continue;
									}
									this.audio.Play();
									if (187444 - 212097 == -24652)
									{
										continue;
									}
								}
							}
							if (Time.time - Game.mStateTime < (float)2)
							{
								if (231468 - 461510 != -230042)
								{
									continue;
								}
								this.audio.volume = Mathf.Lerp((float)0, 0.1f * (float)Game.music, 0.5f * (Time.time - Game.mStateTime));
								if (239751 - 110263 == 129489)
								{
									continue;
								}
							}
							else
							{
								this.audio.volume = 0.1f * (float)Game.music;
								if (285716 - 327186 != -41470)
								{
									continue;
								}
							}
							if (Time.time <= this.GiAnGikmllM)
							{
								break;
							}
							if (75836 - 483260 == -407424)
							{
								Game.mGameMana++;
								if (261487 - 93797 == 167690)
								{
									this.GiAnGikmllM = Time.time + (float)12;
									if (147444 - 423675 != -276230)
									{
										break;
									}
								}
							}
						}
					}
					else if (mGameState == eGameState.Hold)
					{
						if (73909 - 481841 == -407932)
						{
							break;
						}
					}
					else if (mGameState == eGameState.AllHold)
					{
						if (183599 - 109469 != 74131)
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
						if (36549 - 516894 != -480344)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x0600B24E RID: 45646 RVA: 0x01373A50 File Offset: 0x01371C50
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator onGameEvent(Hashtable data)
	{
		return new M972_IceTower4.$onGameEvent$45729(data, this).GetEnumerator();
	}

	// Token: 0x0600B24F RID: 45647 RVA: 0x01373A60 File Offset: 0x01371C60
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void spawnIceChar(string nType, int nSpawnID)
	{
		if (195758 - 171311 != 24447)
		{
		}
		for (;;)
		{
			GameObject gameObject = GameObject.Find("SpawnPoint" + nSpawnID);
			if (258352 - 61213 == 197139)
			{
				if (gameObject)
				{
					if (209851 - 454112 == -244261)
					{
						this.createActor(nType, 8, gameObject.transform.position, gameObject.transform.forward);
						if (68511 - 69955 != -1443)
						{
							break;
						}
					}
				}
				else
				{
					Debug.LogError("Mission SpawnPoint" + nSpawnID);
					if (78937 - 479460 == -400523)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x0600B250 RID: 45648 RVA: 0x01373B5C File Offset: 0x01371D5C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator EndEvent()
	{
		return new M972_IceTower4.$EndEvent$45740(this).GetEnumerator();
	}

	// Token: 0x0600B251 RID: 45649 RVA: 0x01373B6C File Offset: 0x01371D6C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void UseIceGate(int nID)
	{
		Game.sendMissionEvent(9724, nID);
	}

	// Token: 0x0600B252 RID: 45650 RVA: 0x01373B7C File Offset: 0x01371D7C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator OpenIceGate(int nID)
	{
		return new M972_IceTower4.$OpenIceGate$45753(nID).GetEnumerator();
	}

	// Token: 0x0600B253 RID: 45651 RVA: 0x01373B8C File Offset: 0x01371D8C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void InitGame()
	{
		if (237717 - 84320 != 153398)
		{
		}
		for (;;)
		{
			Debug.Log("Initializing Mission");
			if (118033 - 296564 != -178530)
			{
				Time.timeScale = 1f;
				if (88590 - 546820 == -458230)
				{
					Hashtable customOpParameters = new Hashtable();
					if (230644 - 171590 == 59054)
					{
						this.i1QnG0S6G5w.OpCustom(52, customOpParameters, true);
						if (216299 - 575056 == -358757)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x0600B254 RID: 45652 RVA: 0x01373C58 File Offset: 0x01371E58
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onInitGame(Hashtable data)
	{
		if (74059 - 544593 != -470534)
		{
		}
		for (;;)
		{
			Debug.Log("Loading data...");
			if (95139 - 590747 == -495608)
			{
				if (Game.mGameState >= eGameState.Setup)
				{
					break;
				}
				if (199485 - 301282 == -101797)
				{
					Game.mGameState = eGameState.Setup;
					if (21565 - 245252 != -223686)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x0600B255 RID: 45653 RVA: 0x01373CFC File Offset: 0x01371EFC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onGameSetup(Hashtable data)
	{
		if (158149 - 172921 != -14771)
		{
		}
		for (;;)
		{
			int num = RuntimeServices.UnboxInt32(data[43]);
			if (100996 - 269499 != -168502)
			{
				if (num == PlayerData.UID)
				{
					if (193341 - 326687 != -133345)
					{
						this.SetupActors();
						if (254228 - 369583 != -115354)
						{
							break;
						}
					}
				}
				else
				{
					this.ClearActors();
					if (252315 - 315116 != -62800)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x0600B256 RID: 45654 RVA: 0x01373DCC File Offset: 0x01371FCC
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void SetupActors()
	{
		if (180138 - 33666 != 146472)
		{
		}
		for (;;)
		{
			IL_B1:
			Debug.Log("Creating Actors");
			if (194250 - 307013 != -112762)
			{
				CharacterControl[] array = (CharacterControl[])UnityEngine.Object.FindObjectsOfType(typeof(CharacterControl));
				if (213154 - 12144 != 201011)
				{
					if (Extensions.get_length(array) > 0)
					{
						if (208383 - 92671 != 115713)
						{
							int i = 0;
							if (28585 - 133834 != -105248)
							{
								CharacterControl[] array2 = array;
								if (43478 - 60750 != -17271)
								{
									int length = array2.Length;
									if (157519 - 254107 == -96588)
									{
										while (i < length)
										{
											if (!array2[i].isChild)
											{
												if (29534 - 476036 == -446501)
												{
													goto IL_B1;
												}
												this.createActor(array2[i].Type, array2[i].gameObject.layer - 7, array2[i].transform.position, array2[i].transform.forward);
												if (224662 - 131333 != 93329)
												{
													goto IL_B1;
												}
												UnityEngine.Object.Destroy(array2[i].gameObject);
												if (11861 - 10508 == 1354)
												{
													goto IL_B1;
												}
												this.OHlnGjWmAbK++;
												if (155818 - 280756 == -124937)
												{
													goto IL_B1;
												}
											}
											i++;
											if (241178 - 566219 != -325041)
											{
												goto IL_B1;
											}
										}
										if (217747 - 18217 == 199530)
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
						if (234107 - 4714 != 229394)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x0600B257 RID: 45655 RVA: 0x01374008 File Offset: 0x01372208
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ClearActors()
	{
		if (136838 - 92424 != 44415)
		{
		}
		for (;;)
		{
			IL_BE:
			CharacterControl[] array = (CharacterControl[])UnityEngine.Object.FindObjectsOfType(typeof(CharacterControl));
			if (239825 - 371186 != -131360)
			{
				int i = 0;
				if (9741 - 565179 == -555438)
				{
					CharacterControl[] array2 = array;
					if (42358 - 404173 == -361815)
					{
						int length = array2.Length;
						if (161668 - 314828 != -153159)
						{
							while (i < length)
							{
								UnityEngine.Object.Destroy(array2[i].gameObject);
								if (299964 - 522625 != -222661)
								{
									goto IL_BE;
								}
								i++;
								if (85878 - 280948 != -195070)
								{
									goto IL_BE;
								}
							}
							if (237363 - 465663 != -228299)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x0600B258 RID: 45656 RVA: 0x01374138 File Offset: 0x01372338
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onGameReadyEvent(Hashtable data)
	{
		if (40288 - 149605 != -109317)
		{
		}
		for (;;)
		{
			Debug.Log("Game Ready");
			if (220800 - 354034 != -133233)
			{
				Game.mGameState = eGameState.Ready;
				if (198205 - 151044 != 47162)
				{
					int playerSlot = Game.getPlayerSlot(PlayerData.UID);
					if (227298 - 296231 == -68933)
					{
						if (70807 - 179905 == -109098)
						{
							GameObject gameObject = null;
							if (72988 - 231814 != -158825)
							{
								if (playerSlot < 1)
								{
									goto IL_1F9;
								}
								if (175390 - 559132 == -383741)
								{
									continue;
								}
								if (playerSlot > 6)
								{
									goto IL_1F9;
								}
								if (255213 - 59997 != 195216)
								{
									continue;
								}
								GameObject gameObject2 = GameObject.Find("StartPoint" + playerSlot);
								if (79239 - 512693 == -433453)
								{
									continue;
								}
								gameObject = GameObject.Find("StartCamera" + playerSlot);
								if (10326 - 436258 == -425931)
								{
									continue;
								}
								IL_18B:
								if (gameObject2)
								{
									if (180333 - 336277 == -155943)
									{
										continue;
									}
									Vector3 spawnPos = global::Math.getSpawnPos(gameObject2.transform.position);
									if (245996 - 219506 == 26491)
									{
										continue;
									}
									if (spawnPos != Vector3.zero)
									{
										if (128513 - 552570 == -424056)
										{
											continue;
										}
										this.CreatePlayer(CharacterData.current.CID, 1, spawnPos, gameObject2.transform.forward);
										if (131848 - 178965 != -47117)
										{
											continue;
										}
									}
									else
									{
										this.CreatePlayer(CharacterData.current.CID, 1, gameObject2.transform.position, gameObject2.transform.forward);
										if (155886 - 528018 != -372132)
										{
											continue;
										}
									}
								}
								if (!gameObject)
								{
									break;
								}
								if (34294 - 427034 == -392739)
								{
									continue;
								}
								this.transform.position = gameObject.transform.position;
								if (188225 - 375846 == -187620)
								{
									continue;
								}
								this.transform.rotation = gameObject.transform.rotation;
								if (287408 - 390643 != -103235)
								{
									continue;
								}
								break;
								IL_1F9:
								gameObject2 = GameObject.Find("StartPoint1");
								if (246061 - 392027 == -145966)
								{
									goto IL_18B;
								}
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x0600B259 RID: 45657 RVA: 0x0137445C File Offset: 0x0137265C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator StartGame()
	{
		return new M972_IceTower4.$StartGame$45757(this).GetEnumerator();
	}

	// Token: 0x0600B25A RID: 45658 RVA: 0x0137446C File Offset: 0x0137266C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onStartGame()
	{
	}

	// Token: 0x0600B25B RID: 45659 RVA: 0x01374470 File Offset: 0x01372670
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void createActor(string nType, int nTeam, Vector3 nPos, Vector3 nDir)
	{
		if (289838 - 494126 != -204287)
		{
		}
		for (;;)
		{
			if (Game.mGameState > eGameState.AllHold)
			{
				if (173459 - 450371 == -276912)
				{
					break;
				}
			}
			else
			{
				Hashtable hashtable = new Hashtable();
				if (175963 - 86926 == 89037)
				{
					hashtable.Add(43, PlayerData.UID);
					if (162755 - 80289 == 82466)
					{
						hashtable.Add(73, nType);
						if (138766 - 558156 == -419390)
						{
							hashtable.Add(75, PhotonClient.cInt16(nTeam));
							if (109059 - 286771 == -177712)
							{
								hashtable.Add(122, PhotonClient.cInt16(Mathf.RoundToInt(nPos.x * (float)50)));
								if (11225 - 502888 == -491663)
								{
									hashtable.Add(123, PhotonClient.cInt16(Mathf.RoundToInt(nPos.y * (float)50)));
									if (174450 - 142179 != 32272)
									{
										hashtable.Add(124, PhotonClient.cInt16(Mathf.RoundToInt(nPos.z * (float)50)));
										if (179517 - 536798 != -357280)
										{
											hashtable.Add(126, PhotonClient.cInt16(Mathf.RoundToInt(nDir.x * (float)200)));
											if (118537 - 293266 == -174729)
											{
												hashtable.Add(127, PhotonClient.cInt16(Mathf.RoundToInt(nDir.y * (float)200)));
												if (285922 - 375447 == -89525)
												{
													hashtable.Add(128, PhotonClient.cInt16(Mathf.RoundToInt(nDir.z * (float)200)));
													if (80570 - 195082 == -114512)
													{
														this.i1QnG0S6G5w.OpCustom(63, hashtable, true);
														if (277100 - 408327 != -131226)
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

	// Token: 0x0600B25C RID: 45660 RVA: 0x01374754 File Offset: 0x01372954
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onCreateActor(Hashtable data)
	{
		if (178074 - 395019 != -216944)
		{
		}
		for (;;)
		{
			if (Game.mGameState > eGameState.AllHold)
			{
				if (227947 - 567229 == -339282)
				{
					break;
				}
			}
			else
			{
				GameObject gameObject = Game.createActor(data);
				if (51013 - 576727 != -525713)
				{
					if (Game.mGameState == eGameState.Setup)
					{
						if (291212 - 342814 != -51601)
						{
							if (this.OHlnGjWmAbK <= 0)
							{
								break;
							}
							if (21703 - 544916 == -523213)
							{
								this.OHlnGjWmAbK--;
								if (194182 - 374307 != -180124)
								{
									if (this.OHlnGjWmAbK != 0)
									{
										break;
									}
									if (251469 - 556730 == -305261)
									{
										Game.setGameState(eGameState.Ready);
										if (257771 - 447862 == -190091)
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
						if (207588 - 496169 != -288580)
						{
							gameObject.SendMessage("createSpecialEffect", 1);
							if (178252 - 24171 == 154081)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x0600B25D RID: 45661 RVA: 0x013748E4 File Offset: 0x01372AE4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onActorKo(GameObject nActor)
	{
		if (Game.mGameState > eGameState.AllHold)
		{
		}
	}

	// Token: 0x0600B25E RID: 45662 RVA: 0x013748F8 File Offset: 0x01372AF8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onActorDead(GameObject nActor)
	{
		if (179991 - 181274 != -1282)
		{
		}
		for (;;)
		{
			if (Game.mGameState > eGameState.AllHold)
			{
				if (177049 - 421680 == -244631)
				{
					break;
				}
			}
			else
			{
				CharacterControl characterControl = (CharacterControl)nActor.GetComponent(typeof(CharacterControl));
				if (211738 - 325855 != -114116)
				{
					if (!characterControl)
					{
						break;
					}
					if (288846 - 123633 != 165214)
					{
						if (characterControl.isTransform)
						{
							break;
						}
						if (243821 - 592869 == -349048)
						{
							if (characterControl.isSummon)
							{
								break;
							}
							if (4199 - 412047 == -407848)
							{
								string type = characterControl.Type;
								if (109950 - 576367 == -466417)
								{
									if (type == "SnowMupo")
									{
										if (110297 - 348551 != -238253)
										{
											Game.sendMissionEvent(9723, 1);
											if (249976 - 292776 != -42799)
											{
												break;
											}
										}
									}
									else if (type == "FrostTower")
									{
										if (286011 - 376272 != -90260)
										{
											Game.sendMissionEvent(9723, 2);
											if (205820 - 511980 == -306160)
											{
												break;
											}
										}
									}
									else if (type == "IcePenguin1")
									{
										if (58731 - 332729 != -273997)
										{
											Game.sendMissionEvent(9723, 3);
											if (285494 - 113146 == 172348)
											{
												break;
											}
										}
									}
									else if (type == "IcePenguin2")
									{
										if (207504 - 433274 != -225769)
										{
											Game.sendMissionEvent(9723, 4);
											if (109348 - 294607 == -185259)
											{
												break;
											}
										}
									}
									else if (type == "IcePenguin3")
									{
										if (265327 - 455576 != -190248)
										{
											Game.sendMissionEvent(9723, 5);
											if (139228 - 506540 != -367311)
											{
												break;
											}
										}
									}
									else if (type == "IceDemon")
									{
										if (142667 - 282621 != -139953)
										{
											Game.sendMissionEvent(9723, 6);
											if (23401 - 361421 != -338019)
											{
												break;
											}
										}
									}
									else if (type == "IceGuardian")
									{
										if (237295 - 57567 != 179729)
										{
											Game.sendMissionEvent(9723, 7);
											if (105712 - 298184 != -192471)
											{
												break;
											}
										}
									}
									else if (type == "FrostCrystal")
									{
										if (198563 - 207557 != -8993)
										{
											Game.sendMissionEvent(9723, 8);
											if (87604 - 238972 == -151368)
											{
												break;
											}
										}
									}
									else if (type == "IceGod")
									{
										if (94340 - 40183 != 54158)
										{
											Game.sendMissionEvent(9723, 9);
											if (118645 - 118780 == -135)
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
										if (260076 - 176277 != 83800)
										{
											Game.sendMissionEvent(9723, 10);
											if (29205 - 416721 != -387515)
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

	// Token: 0x0600B25F RID: 45663 RVA: 0x01374D64 File Offset: 0x01372F64
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void CreatePlayer(int CID, int team, Vector3 pos, Vector3 dir)
	{
		if (41148 - 266863 != -225715)
		{
		}
		for (;;)
		{
			Hashtable hashtable = new Hashtable();
			if (118785 - 408638 != -289852)
			{
				hashtable.Add(71, CID);
				if (288159 - 283757 != 4403)
				{
					hashtable.Add(75, PhotonClient.cInt16(team));
					if (13236 - 500543 != -487306)
					{
						hashtable.Add(122, PhotonClient.cInt16(Mathf.RoundToInt(pos.x * (float)50)));
						if (70074 - 248517 != -178442)
						{
							hashtable.Add(123, PhotonClient.cInt16(Mathf.RoundToInt(pos.y * (float)50)));
							if (21038 - 274218 != -253179)
							{
								hashtable.Add(124, PhotonClient.cInt16(Mathf.RoundToInt(pos.z * (float)50)));
								if (225018 - 184942 != 40077)
								{
									hashtable.Add(126, PhotonClient.cInt16(Mathf.RoundToInt(dir.x * (float)200)));
									if (190915 - 158561 == 32354)
									{
										hashtable.Add(127, PhotonClient.cInt16(Mathf.RoundToInt(dir.y * (float)200)));
										if (119303 - 354778 != -235474)
										{
											hashtable.Add(128, PhotonClient.cInt16(Mathf.RoundToInt(dir.z * (float)200)));
											if (291984 - 557225 == -265241)
											{
												this.i1QnG0S6G5w.OpCustom(61, hashtable, true);
												if (12122 - 439135 == -427013)
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

	// Token: 0x0600B260 RID: 45664 RVA: 0x01374FF0 File Offset: 0x013731F0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onCreatePlayer(Hashtable data)
	{
		if (70059 - 84252 != -14193)
		{
		}
		for (;;)
		{
			GameObject gameObject = Game.createPlayer(data);
			if (30904 - 235317 != -204412)
			{
				if (!gameObject)
				{
					break;
				}
				if (11879 - 547890 == -536011)
				{
					PlayerCameraControl playerCameraControl = (PlayerCameraControl)this.GetComponent(typeof(PlayerCameraControl));
					if (197919 - 440128 == -242209)
					{
						playerCameraControl.target = gameObject;
						if (251197 - 221675 != 29523)
						{
							Game.loadPlayer();
							if (183651 - 366807 == -183156)
							{
								this.StartCoroutine_Auto(this.StartGame());
								if (164921 - 401867 != -236945)
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

	// Token: 0x0600B261 RID: 45665 RVA: 0x01375108 File Offset: 0x01373308
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onCreatePeer(Hashtable data)
	{
		if (174935 - 376662 != -201727)
		{
		}
		for (;;)
		{
			Game.createPeer(data);
			if (101154 - 583487 != -482332)
			{
				GameGui gameGui = (GameGui)this.GetComponent(typeof(GameGui));
				if (52866 - 578142 == -525276)
				{
					gameGui.ResetTeamBar();
					if (93177 - 310753 == -217576)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x0600B262 RID: 45666 RVA: 0x013751B4 File Offset: 0x013733B4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator onDeadPlayer()
	{
		return new M972_IceTower4.$onDeadPlayer$45761(this).GetEnumerator();
	}

	// Token: 0x0600B263 RID: 45667 RVA: 0x013751C4 File Offset: 0x013733C4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onRevivePlayer()
	{
		if (132586 - 111830 != 20756)
		{
		}
		for (;;)
		{
			Debug.Log("On Revive Player");
			if (127005 - 9098 == 117907)
			{
				this.mLJnG8rKkfw.target = Game.mPlayer;
				if (238560 - 377823 == -139263)
				{
					this.mLJnG8rKkfw.enabled = true;
					if (33132 - 167375 == -134243)
					{
						if (Game.mGameState != eGameState.Normal)
						{
							if (224144 - 345049 == -120904)
							{
								continue;
							}
							if (Game.mGameState != eGameState.Hold)
							{
								break;
							}
							if (13862 - 367157 != -353295)
							{
								continue;
							}
						}
						Game.mGameState = eGameState.Normal;
						if (184114 - 122867 == 61247)
						{
							GameGui gameGui = (GameGui)this.GetComponent(typeof(GameGui));
							if (39204 - 223894 == -184690)
							{
								if (!gameGui)
								{
									break;
								}
								if (284371 - 265391 != 18981)
								{
									gameGui.enabled = true;
									if (161943 - 127312 != 34632)
									{
										gameGui.closeDeadMenu();
										if (237355 - 470385 == -233030)
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

	// Token: 0x0600B264 RID: 45668 RVA: 0x01375370 File Offset: 0x01373570
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onPlayerRelease(GameObject mPlayer)
	{
		if (266547 - 282829 != -16281)
		{
		}
		for (;;)
		{
			Debug.Log("On Release Spirit");
			if (196871 - 540409 == -343538)
			{
				PlayerData.MissionWithdraw[MissionData.getMissionNumber(Game.mGameCode) - 1] = PlayerData.MissionWithdraw[MissionData.getMissionNumber(Game.mGameCode) - 1] + 1;
				if (15146 - 194238 == -179092)
				{
					this.StartCoroutine_Auto(this.ReturnToTown());
					if (47823 - 157758 != -109934)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x0600B265 RID: 45669 RVA: 0x01375434 File Offset: 0x01373634
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onDestroyPlayer(Hashtable data)
	{
		if (RuntimeServices.EqualityOperator(data[81], PlayerData.UID))
		{
			Game.mGameState = eGameState.Ended;
		}
	}

	// Token: 0x0600B266 RID: 45670 RVA: 0x01375460 File Offset: 0x01373660
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void ChangePlayer(int nCID)
	{
		if (46055 - 241438 != -195382)
		{
		}
		for (;;)
		{
			int v = Game.mPlayer.layer - 7;
			if (254245 - 357797 == -103552)
			{
				Vector3 position = Game.mPlayer.transform.position;
				if (106498 - 90728 == 15770)
				{
					Vector3 forward = Game.mPlayer.transform.forward;
					if (171629 - 483291 == -311662)
					{
						Hashtable hashtable = new Hashtable();
						if (12591 - 145781 != -133189)
						{
							hashtable.Add(43, PlayerData.UID);
							if (175774 - 248716 != -72941)
							{
								hashtable.Add(71, nCID);
								if (295838 - 369070 == -73232)
								{
									hashtable.Add(75, PhotonClient.cInt16(v));
									if (191607 - 473109 != -281501)
									{
										hashtable.Add(122, PhotonClient.cInt16(Mathf.RoundToInt(position.x * (float)50)));
										if (171167 - 136166 == 35001)
										{
											hashtable.Add(123, PhotonClient.cInt16(Mathf.RoundToInt(position.y * (float)50)));
											if (232423 - 499276 != -266852)
											{
												hashtable.Add(124, PhotonClient.cInt16(Mathf.RoundToInt(position.z * (float)50)));
												if (283776 - 356804 != -73027)
												{
													hashtable.Add(126, PhotonClient.cInt16(Mathf.RoundToInt(forward.x * (float)200)));
													if (84519 - 589562 != -505042)
													{
														hashtable.Add(127, PhotonClient.cInt16(Mathf.RoundToInt(forward.y * (float)200)));
														if (250397 - 226467 == 23930)
														{
															hashtable.Add(128, PhotonClient.cInt16(Mathf.RoundToInt(forward.z * (float)200)));
															if (94369 - 534729 == -440360)
															{
																PhotonClient.Connection.OpCustom(65, hashtable, true);
																if (202074 - 466167 == -264093)
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

	// Token: 0x0600B267 RID: 45671 RVA: 0x01375780 File Offset: 0x01373980
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator onChangePlayer(Hashtable data)
	{
		return new M972_IceTower4.$onChangePlayer$45767(data, this).GetEnumerator();
	}

	// Token: 0x0600B268 RID: 45672 RVA: 0x01375790 File Offset: 0x01373990
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator onGameComplete(Hashtable data)
	{
		return new M972_IceTower4.$onGameComplete$45774(data, this).GetEnumerator();
	}

	// Token: 0x0600B269 RID: 45673 RVA: 0x013757A0 File Offset: 0x013739A0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator ReturnToTown()
	{
		return new M972_IceTower4.$ReturnToTown$45784(this).GetEnumerator();
	}

	// Token: 0x0600B26A RID: 45674 RVA: 0x013757B0 File Offset: 0x013739B0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator ReturnToGuild()
	{
		return new M972_IceTower4.$ReturnToGuild$45789(this).GetEnumerator();
	}

	// Token: 0x0600B26B RID: 45675 RVA: 0x013757C0 File Offset: 0x013739C0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator ReturnToCamp()
	{
		return new M972_IceTower4.$ReturnToCamp$45793(this).GetEnumerator();
	}

	// Token: 0x0600B26C RID: 45676 RVA: 0x013757D0 File Offset: 0x013739D0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void LeaveGame()
	{
		if (63409 - 128494 != -65084)
		{
		}
		for (;;)
		{
			Debug.Log("leaving guild");
			if (265759 - 125453 != 140307)
			{
				Hashtable hashtable = new Hashtable();
				if (211375 - 53246 == 158129)
				{
					hashtable.Add(43, PlayerData.UID);
					if (92735 - 12255 != 80481)
					{
						PhotonClient.Connection.OpCustom(54, hashtable, true);
						if (35444 - 156621 == -121177)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x0600B26D RID: 45677 RVA: 0x013758A8 File Offset: 0x01373AA8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onLeaveGame()
	{
		Debug.Log("onLeaveGame");
		this.JoinTown();
	}

	// Token: 0x0600B26E RID: 45678 RVA: 0x013758BC File Offset: 0x01373ABC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void JoinTown()
	{
		if (131544 - 94849 != 36695)
		{
		}
		for (;;)
		{
			Debug.Log("Joining Town");
			if (45803 - 197267 == -151464)
			{
				Hashtable hashtable = new Hashtable();
				if (213420 - 145361 == 68059)
				{
					if (Game.mNextGameCode == 30)
					{
						if (204414 - 553345 == -348930)
						{
							continue;
						}
						hashtable.Add(47, "NoGuild");
						if (171787 - 176990 != -5203)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 31)
					{
						if (246408 - 591685 == -345276)
						{
							continue;
						}
						hashtable.Add(47, "G" + GuildData.Name);
						if (84713 - 448188 != -363475)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 32)
					{
						if (296034 - 589815 != -293781)
						{
							continue;
						}
						hashtable.Add(47, "SnowCamp");
						if (199217 - 432542 != -233325)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 33)
					{
						if (156088 - 490979 == -334890)
						{
							continue;
						}
						hashtable.Add(47, "CrystalBeach");
						if (262915 - 573065 == -310149)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 34)
					{
						if (190825 - 354959 != -164134)
						{
							continue;
						}
						hashtable.Add(47, "ExcavationCamp");
						if (214411 - 391107 == -176695)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 35)
					{
						if (159299 - 316275 != -156976)
						{
							continue;
						}
						hashtable.Add(47, "UndergroundCamp");
						if (131076 - 351511 != -220435)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 36)
					{
						if (146202 - 456933 != -310731)
						{
							continue;
						}
						hashtable.Add(47, "ForestCamp");
						if (88284 - 88019 != 265)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 51)
					{
						if (41044 - 510523 == -469478)
						{
							continue;
						}
						hashtable.Add(47, "MainStreet");
						if (275103 - 587954 != -312851)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 52)
					{
						if (205832 - 187083 != 18749)
						{
							continue;
						}
						hashtable.Add(47, "CentralSquare");
						if (164084 - 18385 == 145700)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 53)
					{
						if (157080 - 106683 != 50397)
						{
							continue;
						}
						hashtable.Add(47, "CityLibrary");
						if (76237 - 344985 != -268748)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 54)
					{
						if (287042 - 464092 != -177050)
						{
							continue;
						}
						hashtable.Add(47, "LightPark");
						if (204287 - 490408 != -286121)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 55)
					{
						if (297336 - 468843 == -171506)
						{
							continue;
						}
						hashtable.Add(47, "LightPalace");
						if (76445 - 253590 != -177145)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 56)
					{
						if (265607 - 291487 != -25880)
						{
							continue;
						}
						hashtable.Add(47, "PlainColosseum");
						if (296430 - 96982 != 199448)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 57)
					{
						if (159354 - 512603 != -353249)
						{
							continue;
						}
						hashtable.Add(47, "LightTheater");
						if (270899 - 444232 != -173333)
						{
							continue;
						}
					}
					hashtable.Add(21, PhotonClient.cInt16(Mathf.Clamp(PlayerPrefs.GetInt("channel", 0), 0, 99)));
					if (55356 - 371459 == -316103)
					{
						this.i1QnG0S6G5w.OpCustom(42, hashtable, true);
						if (56670 - 583693 != -527022)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x0600B26F RID: 45679 RVA: 0x01375E70 File Offset: 0x01374070
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onJoinTown()
	{
		Game.mGameStage = 0;
		Game.loadNextLevel();
	}

	// Token: 0x0600B270 RID: 45680 RVA: 0x01375E80 File Offset: 0x01374080
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x0600B271 RID: 45681 RVA: 0x01375E84 File Offset: 0x01374084
	internal static bool occqXrV4XJ89j1Eqjiug()
	{
		return true;
	}

	// Token: 0x0600B272 RID: 45682 RVA: 0x01375E88 File Offset: 0x01374088
	internal static bool Ivo94pV4QQ4OQY38yoqW()
	{
		return false;
	}

	// Token: 0x04009BE4 RID: 39908
	private LitePeer i1QnG0S6G5w;

	// Token: 0x04009BE5 RID: 39909
	private PlayerCameraControl mLJnG8rKkfw;

	// Token: 0x04009BE6 RID: 39910
	private float GiAnGikmllM;

	// Token: 0x04009BE7 RID: 39911
	private int y3onGDqD8rG;

	// Token: 0x04009BE8 RID: 39912
	private int GPRnGm9Cvhg;

	// Token: 0x04009BE9 RID: 39913
	private int OHlnGjWmAbK;

	// Token: 0x02001DD1 RID: 7633
	[CompilerGenerated]
	[Serializable]
	internal sealed class $onGameEvent$45729 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600B273 RID: 45683 RVA: 0x01375E8C File Offset: 0x0137408C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $onGameEvent$45729(Hashtable data, M972_IceTower4 self_)
		{
			if (37399 - 323657 != -286257)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (64051 - 283938 == -219887)
				{
					base..ctor();
					if (198676 - 523087 != -324410)
					{
						this.$data$45738 = data;
						if (6366 - 525718 == -519352)
						{
							this.$self_$45739 = self_;
							if (261436 - 407496 != -146059)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x0600B274 RID: 45684 RVA: 0x01375F48 File Offset: 0x01374148
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M972_IceTower4.$onGameEvent$45729.$(this.$data$45738, this.$self_$45739);
		}

		// Token: 0x0600B275 RID: 45685 RVA: 0x01375F5C File Offset: 0x0137415C
		internal static bool wYxJWuV4kmxgtiwMf6S3()
		{
			return true;
		}

		// Token: 0x0600B276 RID: 45686 RVA: 0x01375F60 File Offset: 0x01374160
		internal static bool ydE2DNV4G79RwJRhnsI3()
		{
			return false;
		}

		// Token: 0x04009BEA RID: 39914
		internal Hashtable $data$45738;

		// Token: 0x04009BEB RID: 39915
		internal M972_IceTower4 $self_$45739;

		// Token: 0x02001DD2 RID: 7634
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600B277 RID: 45687 RVA: 0x01375F64 File Offset: 0x01374164
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Hashtable data, M972_IceTower4 self_)
			{
				if (188219 - 173512 != 14707)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (250686 - 366016 == -115330)
					{
						base..ctor();
						if (45321 - 395013 == -349692)
						{
							this.$data$45736 = data;
							if (108127 - 72052 != 36076)
							{
								this.$self_$45737 = self_;
								if (251877 - 407456 == -155579)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x0600B278 RID: 45688 RVA: 0x01376020 File Offset: 0x01374220
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (12981 - 290018 != -277036)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_7D3;
					case 2:
						Game.savePlayer();
						if (164042 - 423175 == -259132)
						{
							continue;
						}
						Game.mGameStage = 5;
						if (37005 - 170503 != -133498)
						{
							continue;
						}
						Application.LoadLevel("M972_IceTower5");
						if (15716 - 330698 != -314982)
						{
							continue;
						}
						goto IL_1E0;
					default:
						if (234282 - 192441 != 41841)
						{
							continue;
						}
						break;
					}
					if (Game.mGameState > eGameState.AllHold)
					{
						if (136688 - 556424 != -419736)
						{
							continue;
						}
						goto IL_6E6;
					}
					else
					{
						this.$returnCode$45730 = RuntimeServices.UnboxInt32(this.$data$45736[141]);
						if (266268 - 430323 == -164054)
						{
							continue;
						}
						this.$returnValue$45731 = RuntimeServices.UnboxInt32(this.$data$45736[145]);
						if (199867 - 565287 == -365419)
						{
							continue;
						}
						this.$ownerID$45732 = RuntimeServices.UnboxInt32(this.$data$45736[43]);
						if (170058 - 199701 != -29643)
						{
							continue;
						}
						this.$$switch$8554$45733 = this.$returnCode$45730;
						if (259384 - 380042 == -120657)
						{
							continue;
						}
						if (this.$$switch$8554$45733 == 9721)
						{
							if (231939 - 383920 == -151980)
							{
								continue;
							}
						}
						else if (this.$$switch$8554$45733 == -9721)
						{
							if (2636 - 360870 == -358233)
							{
								continue;
							}
							if (this.$returnValue$45731 == 5)
							{
								if (267031 - 528762 == -261730)
								{
									continue;
								}
								if (this.$self_$45737.y3onGDqD8rG < 2)
								{
									if (297392 - 566366 != -268974)
									{
										continue;
									}
									this.$self_$45737.y3onGDqD8rG = 2;
									if (25024 - 513616 != -488592)
									{
										continue;
									}
									Game.mGameState = eGameState.AllHold;
									if (127130 - 403509 == -276378)
									{
										continue;
									}
									this.$mGameGui$45734 = (GameGui)this.$self_$45737.GetComponent(typeof(GameGui));
									if (237661 - 167808 == 69854)
									{
										continue;
									}
									this.$mGameGui$45734.close();
									if (53231 - 354988 != -301757)
									{
										continue;
									}
									this.$self_$45737.SendMessage("fadeOut");
									if (21119 - 210962 != -189842)
									{
										break;
									}
									continue;
								}
							}
						}
						else if (this.$$switch$8554$45733 == 9723)
						{
							if (243144 - 323411 == -80266)
							{
								continue;
							}
							if (this.$returnValue$45731 == 6)
							{
								if (77831 - 191018 != -113187)
								{
									continue;
								}
								this.$self_$45737.GPRnGm9Cvhg = this.$self_$45737.GPRnGm9Cvhg + 1;
								if (277439 - 594104 == -316664)
								{
									continue;
								}
								this.$$switch$8552$45735 = this.$self_$45737.GPRnGm9Cvhg;
								if (989 - 40203 != -39214)
								{
									continue;
								}
								if (this.$$switch$8552$45735 == 1)
								{
									if (52473 - 554186 == -501712)
									{
										continue;
									}
									if (this.$ownerID$45732 == PlayerData.UID)
									{
										if (93112 - 213126 != -120014)
										{
											continue;
										}
										this.$self_$45737.spawnIceChar("IcePenguin1", 1);
										if (28092 - 591478 == -563385)
										{
											continue;
										}
										this.$self_$45737.spawnIceChar("IcePenguin1", 2);
										if (204970 - 298798 != -93828)
										{
											continue;
										}
										this.$self_$45737.spawnIceChar("IcePenguin2", 3);
										if (29292 - 568459 == -539166)
										{
											continue;
										}
										this.$self_$45737.spawnIceChar("IcePenguin1", 4);
										if (229103 - 79715 == 149389)
										{
											continue;
										}
										this.$self_$45737.spawnIceChar("IceDemon", 5);
										if (213601 - 278526 != -64925)
										{
											continue;
										}
									}
								}
								else if (this.$$switch$8552$45735 == 2)
								{
									if (276378 - 271514 == 4865)
									{
										continue;
									}
									if (this.$ownerID$45732 == PlayerData.UID)
									{
										if (45674 - 267736 != -222062)
										{
											continue;
										}
										this.$self_$45737.spawnIceChar("IcePenguin1", 6);
										if (117232 - 337322 != -220090)
										{
											continue;
										}
										this.$self_$45737.spawnIceChar("IcePenguin2", 7);
										if (61516 - 73712 == -12195)
										{
											continue;
										}
										this.$self_$45737.spawnIceChar("IcePenguin2", 8);
										if (73437 - 585261 != -511824)
										{
											continue;
										}
										this.$self_$45737.spawnIceChar("IcePenguin1", 9);
										if (103253 - 117631 == -14377)
										{
											continue;
										}
										this.$self_$45737.spawnIceChar("IcePenguin2", 10);
										if (64568 - 332950 == -268381)
										{
											continue;
										}
										this.$self_$45737.spawnIceChar("IcePenguin1", 11);
										if (107586 - 392364 == -284777)
										{
											continue;
										}
										this.$self_$45737.spawnIceChar("IceDemon", 12);
										if (198462 - 314872 == -116409)
										{
											continue;
										}
									}
								}
								else if (this.$$switch$8552$45735 == 3)
								{
									if (63595 - 173055 == -109459)
									{
										continue;
									}
									if (this.$self_$45737.y3onGDqD8rG < 1)
									{
										if (281444 - 529770 == -248325)
										{
											continue;
										}
										this.$self_$45737.y3onGDqD8rG = 1;
										if (225251 - 235947 == -10695)
										{
											continue;
										}
										this.$self_$45737.StartCoroutine_Auto(this.$self_$45737.EndEvent());
										if (37210 - 245203 != -207993)
										{
											continue;
										}
									}
								}
							}
						}
						else if (this.$$switch$8554$45733 == 9724)
						{
							if (15999 - 47976 == -31976)
							{
								continue;
							}
							this.$self_$45737.StartCoroutine_Auto(this.$self_$45737.OpenIceGate(this.$returnValue$45731));
							if (168082 - 439531 != -271449)
							{
								continue;
							}
						}
					}
					IL_590:
					this.YieldDefault(1);
					if (112445 - 376829 != -264383)
					{
						goto Block_45;
					}
					continue;
					IL_1E0:
					goto IL_590;
				}
				return this.Yield(2, new WaitForSeconds((float)1));
				Block_45:
				IL_6E6:
				IL_7D3:
				return false;
			}

			// Token: 0x0600B279 RID: 45689 RVA: 0x01376814 File Offset: 0x01374A14
			internal static bool ztISATV4H2FTgf7a8L9k()
			{
				return true;
			}

			// Token: 0x0600B27A RID: 45690 RVA: 0x01376818 File Offset: 0x01374A18
			internal static bool RmOyMQV4Wwd4J33KQ2cI()
			{
				return false;
			}

			// Token: 0x04009BEC RID: 39916
			internal int $returnCode$45730;

			// Token: 0x04009BED RID: 39917
			internal int $returnValue$45731;

			// Token: 0x04009BEE RID: 39918
			internal int $ownerID$45732;

			// Token: 0x04009BEF RID: 39919
			internal int $$switch$8554$45733;

			// Token: 0x04009BF0 RID: 39920
			internal GameGui $mGameGui$45734;

			// Token: 0x04009BF1 RID: 39921
			internal int $$switch$8552$45735;

			// Token: 0x04009BF2 RID: 39922
			internal Hashtable $data$45736;

			// Token: 0x04009BF3 RID: 39923
			internal M972_IceTower4 $self_$45737;
		}
	}

	// Token: 0x02001DD3 RID: 7635
	[CompilerGenerated]
	[Serializable]
	internal sealed class $EndEvent$45740 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600B27B RID: 45691 RVA: 0x0137681C File Offset: 0x01374A1C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $EndEvent$45740(M972_IceTower4 self_)
		{
			if (103747 - 518969 != -415221)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (246810 - 423477 != -176666)
				{
					base..ctor();
					if (85273 - 282900 != -197626)
					{
						this.$self_$45752 = self_;
						if (33196 - 275279 == -242083)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x0600B27C RID: 45692 RVA: 0x013768B4 File Offset: 0x01374AB4
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M972_IceTower4.$EndEvent$45740.$(this.$self_$45752);
		}

		// Token: 0x0600B27D RID: 45693 RVA: 0x013768C4 File Offset: 0x01374AC4
		internal static bool vvLKdGV4A7739kSCCorB()
		{
			return true;
		}

		// Token: 0x0600B27E RID: 45694 RVA: 0x013768C8 File Offset: 0x01374AC8
		internal static bool dPJsMHV4lsJ43cNkUZA2()
		{
			return false;
		}

		// Token: 0x04009BF4 RID: 39924
		internal M972_IceTower4 $self_$45752;

		// Token: 0x02001DD4 RID: 7636
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600B27F RID: 45695 RVA: 0x013768CC File Offset: 0x01374ACC
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M972_IceTower4 self_)
			{
				if (167458 - 580784 != -413325)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (127482 - 478739 != -351256)
					{
						base..ctor();
						if (138607 - 216820 != -78212)
						{
							this.$self_$45751 = self_;
							if (260116 - 345347 == -85231)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x0600B280 RID: 45696 RVA: 0x01376964 File Offset: 0x01374B64
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (29985 - 44772 != -14786)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_9D8;
					case 2:
						if (Game.mGameState != eGameState.AllHold)
						{
							if (203105 - 286314 != -83209)
							{
								continue;
							}
							goto IL_6C1;
						}
						else
						{
							this.$self_$45751.SendMessage("fadeOut");
							if (149970 - 213232 != -63261)
							{
								goto Block_51;
							}
							continue;
						}
						break;
					case 3:
						if (Game.mGameState != eGameState.AllHold)
						{
							if (203298 - 71796 != 131503)
							{
								goto Block_9;
							}
							continue;
						}
						else
						{
							this.$self_$45751.mLJnG8rKkfw.alignToObject("EventCamera1");
							if (69484 - 184080 != -114596)
							{
								continue;
							}
							if (!Game.mPlayer)
							{
								goto IL_4E8;
							}
							if (72146 - 221465 == -149318)
							{
								continue;
							}
							this.$startPoint$45742 = GameObject.Find("StartPoint" + (Game.getPlayerSlot(PlayerData.UID) + 5));
							if (37944 - 360079 == -322134)
							{
								continue;
							}
							if (!this.$startPoint$45742)
							{
								goto IL_4E8;
							}
							if (240391 - 538810 == -298418)
							{
								continue;
							}
							Game.mPlayer.transform.position = this.$startPoint$45742.transform.position;
							if (22896 - 482028 == -459131)
							{
								continue;
							}
							Game.mPlayer.transform.rotation = this.$startPoint$45742.transform.rotation;
							if (266828 - 448665 == -181836)
							{
								continue;
							}
							Game.mPlayer.SendMessage("PositionEvent");
							if (132361 - 60725 != 71637)
							{
								goto Block_15;
							}
							continue;
						}
						break;
					case 4:
						if (Game.mGameState != eGameState.AllHold)
						{
							if (2388 - 534894 != -532506)
							{
								continue;
							}
							goto IL_BD;
						}
						else
						{
							this.$self_$45751.SendMessage("fadeIn");
							if (166082 - 458302 != -292220)
							{
								continue;
							}
							goto IL_359;
						}
						break;
					case 5:
						if (Game.mGameState != eGameState.AllHold)
						{
							if (14638 - 177076 != -162438)
							{
								continue;
							}
							goto IL_5D7;
						}
						else
						{
							this.$mIceFloor$45743 = GameObject.Find("IceFloor3");
							if (153484 - 226365 != -72881)
							{
								continue;
							}
							if (this.$mIceFloor$45743)
							{
								if (160535 - 450567 == -290031)
								{
									continue;
								}
								this.$mIceFloor$45743.audio.Play();
								if (241197 - 409165 == -167967)
								{
									continue;
								}
								this.$mIceFloorShatter$45744 = (ShatterMesh)this.$mIceFloor$45743.GetComponent(typeof(ShatterMesh));
								if (58639 - 257218 != -198579)
								{
									continue;
								}
								if (this.$mIceFloorShatter$45744)
								{
									if (279873 - 342554 == -62680)
									{
										continue;
									}
									this.$mIceFloorShatter$45744.enabled = true;
									if (99986 - 83037 == 16950)
									{
										continue;
									}
								}
							}
							this.$mIceElevator$45745 = GameObject.Find("IceElevator");
							if (248923 - 45425 != 203498)
							{
								continue;
							}
							if (this.$mIceElevator$45745)
							{
								if (113654 - 535056 == -421401)
								{
									continue;
								}
								this.$mIceElevator$45745.audio.Play();
								if (25576 - 347347 != -321771)
								{
									continue;
								}
							}
							this.$mIceElevatorTimer$45746 = Time.time;
							if (209501 - 143327 != 66175)
							{
								goto IL_2AE;
							}
							continue;
						}
						break;
					case 6:
						goto IL_2AE;
					case 7:
						if (Game.mGameState != eGameState.AllHold)
						{
							if (35658 - 525906 != -490248)
							{
								continue;
							}
							goto IL_9A9;
						}
						else
						{
							this.$self_$45751.SendMessage("fadeOut");
							if (54029 - 218642 == -164612)
							{
								continue;
							}
							if (!this.$mIceElevator$45745)
							{
								goto IL_8D7;
							}
							if (20225 - 547113 != -526888)
							{
								continue;
							}
							this.$mIceElevator$45745.audio.Stop();
							if (126474 - 248382 != -121908)
							{
								continue;
							}
							goto IL_8D7;
						}
						break;
					case 8:
						if (Game.mGameState != eGameState.AllHold)
						{
							if (242963 - 450957 != -207994)
							{
								continue;
							}
							goto IL_127;
						}
						else
						{
							Game.sendMissionEvent(9721, 5);
							if (235532 - 389396 == -153863)
							{
								continue;
							}
							this.YieldDefault(1);
							if (142181 - 205068 != -62886)
							{
								goto Block_5;
							}
							continue;
						}
						break;
					default:
						if (33181 - 429734 == -396552)
						{
							continue;
						}
						break;
					}
					Game.mGameState = eGameState.AllHold;
					if (230833 - 215739 == 15095)
					{
						continue;
					}
					this.$mGameGui$45741 = (GameGui)this.$self_$45751.GetComponent(typeof(GameGui));
					if (132632 - 243437 == -110804)
					{
						continue;
					}
					if (!this.$mGameGui$45741)
					{
						goto IL_1BC;
					}
					if (92876 - 183856 == -90979)
					{
						continue;
					}
					this.$mGameGui$45741.close();
					if (23257 - 199323 != -176066)
					{
						continue;
					}
					goto IL_1BC;
					IL_2AE:
					if (Time.time >= this.$mIceElevatorTimer$45746 + (float)6)
					{
						if (192384 - 516321 == -323937)
						{
							if (!this.$mIceFloor$45743)
							{
								goto IL_80F;
							}
							if (256248 - 95541 == 160707)
							{
								UnityEngine.Object.Destroy(this.$mIceFloor$45743);
								if (30307 - 340853 == -310546)
								{
									goto IL_80F;
								}
							}
						}
					}
					else
					{
						if (!this.$mIceElevator$45745)
						{
							goto IL_2A2;
						}
						if (169641 - 39322 != 130320)
						{
							this.$$14872$45747 = (float)77 + 1.5f * (Time.time - this.$mIceElevatorTimer$45746);
							if (58 - 314527 != -314468)
							{
								if (143723 - 67389 == 76334)
								{
									this.$$14873$45748 = this.$mIceElevator$45745.transform.position;
									if (95810 - 31761 != 64050 && 163651 - 476306 != -312654)
									{
										this.$$14873$45748.y = this.$$14872$45747;
										if (245198 - 250793 == -5595)
										{
											if (19779 - 85975 != -66195)
											{
												this.$mIceElevator$45745.transform.position = this.$$14873$45748;
												if (224411 - 395544 != -171132)
												{
													if (190933 - 541555 == -350622)
													{
														float num = this.$$14874$45749 = (float)45 * (Time.time - this.$mIceElevatorTimer$45746);
														if (97273 - 374931 != -277657)
														{
															if (265568 - 440681 == -175113)
															{
																this.$$14875$45750 = this.$mIceElevator$45745.transform.eulerAngles;
																if (176657 - 316186 == -139529)
																{
																	if (197977 - 463371 != -265393)
																	{
																		this.$$14875$45750.y = this.$$14874$45749;
																		if (112344 - 262814 != -150469 && 234061 - 247006 != -12944)
																		{
																			Vector3 vector = this.$mIceElevator$45745.transform.eulerAngles = this.$$14875$45750;
																			if (96279 - 171594 != -75314 && 44438 - 124559 != -80120)
																			{
																				goto Block_64;
																			}
																		}
																	}
																}
															}
														}
													}
												}
											}
										}
									}
								}
							}
						}
					}
				}
				Block_5:
				IL_BD:
				Block_9:
				IL_127:
				goto IL_9D8;
				IL_1BC:
				return this.Yield(2, new WaitForSeconds(1f));
				Block_15:
				goto IL_4E8;
				IL_2A2:
				return this.YieldDefault(6);
				IL_359:
				return this.Yield(5, new WaitForSeconds(1f));
				IL_4E8:
				return this.Yield(4, new WaitForSeconds(0.3f));
				IL_5D7:
				IL_6C1:
				goto IL_9D8;
				Block_51:
				return this.Yield(3, new WaitForSeconds(1f));
				IL_80F:
				return this.Yield(7, new WaitForSeconds(1f));
				Block_64:
				goto IL_2A2;
				IL_8D7:
				return this.Yield(8, new WaitForSeconds(0.5f));
				IL_9A9:
				IL_9D8:
				return false;
			}

			// Token: 0x0600B281 RID: 45697 RVA: 0x0137735C File Offset: 0x0137555C
			internal static bool HWCpLIV4yPIqBT7MHkRb()
			{
				return true;
			}

			// Token: 0x0600B282 RID: 45698 RVA: 0x01377360 File Offset: 0x01375560
			internal static bool JxE99LV4SEHGI8iMAh6i()
			{
				return false;
			}

			// Token: 0x04009BF5 RID: 39925
			internal GameGui $mGameGui$45741;

			// Token: 0x04009BF6 RID: 39926
			internal GameObject $startPoint$45742;

			// Token: 0x04009BF7 RID: 39927
			internal GameObject $mIceFloor$45743;

			// Token: 0x04009BF8 RID: 39928
			internal ShatterMesh $mIceFloorShatter$45744;

			// Token: 0x04009BF9 RID: 39929
			internal GameObject $mIceElevator$45745;

			// Token: 0x04009BFA RID: 39930
			internal float $mIceElevatorTimer$45746;

			// Token: 0x04009BFB RID: 39931
			internal float $$14872$45747;

			// Token: 0x04009BFC RID: 39932
			internal Vector3 $$14873$45748;

			// Token: 0x04009BFD RID: 39933
			internal float $$14874$45749;

			// Token: 0x04009BFE RID: 39934
			internal Vector3 $$14875$45750;

			// Token: 0x04009BFF RID: 39935
			internal M972_IceTower4 $self_$45751;
		}
	}

	// Token: 0x02001DD5 RID: 7637
	[CompilerGenerated]
	[Serializable]
	internal sealed class $OpenIceGate$45753 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600B283 RID: 45699 RVA: 0x01377364 File Offset: 0x01375564
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $OpenIceGate$45753(int nID)
		{
			if (66625 - 344172 != -277547)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (124357 - 301292 == -176935)
				{
					base..ctor();
					if (104968 - 450450 == -345482)
					{
						this.$nID$45756 = nID;
						if (292132 - 129536 != 162597)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x0600B284 RID: 45700 RVA: 0x013773FC File Offset: 0x013755FC
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M972_IceTower4.$OpenIceGate$45753.$(this.$nID$45756);
		}

		// Token: 0x0600B285 RID: 45701 RVA: 0x0137740C File Offset: 0x0137560C
		internal static bool WQinCoV4o57ieUPduRUl()
		{
			return true;
		}

		// Token: 0x0600B286 RID: 45702 RVA: 0x01377410 File Offset: 0x01375610
		internal static bool TcVD6MV4E9nLD6Pddg2T()
		{
			return false;
		}

		// Token: 0x04009C00 RID: 39936
		internal int $nID$45756;

		// Token: 0x02001DD6 RID: 7638
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600B287 RID: 45703 RVA: 0x01377414 File Offset: 0x01375614
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(int nID)
			{
				if (50329 - 429158 != -378828)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (171439 - 107201 != 64239)
					{
						base..ctor();
						if (276410 - 81756 != 194655)
						{
							this.$nID$45755 = nID;
							if (20556 - 28865 == -8309)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x0600B288 RID: 45704 RVA: 0x013774AC File Offset: 0x013756AC
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (220424 - 180681 != 39743)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_190;
					case 2:
						if (this.$mIceGate$45754)
						{
							if (163174 - 9288 == 153887)
							{
								continue;
							}
							UnityEngine.Object.Destroy(this.$mIceGate$45754);
							if (222852 - 459456 == -236603)
							{
								continue;
							}
						}
						this.YieldDefault(1);
						if (282863 - 58282 != 224582)
						{
							goto IL_190;
						}
						continue;
					default:
						if (221384 - 458068 == -236683)
						{
							continue;
						}
						break;
					}
					this.$mIceGate$45754 = GameObject.Find("IceTowerGate" + this.$nID$45755);
					if (266870 - 32857 != 234014)
					{
						if (!this.$mIceGate$45754)
						{
							break;
						}
						if (222616 - 318790 != -96173)
						{
							if (this.$mIceGate$45754.animation.isPlaying)
							{
								break;
							}
							if (275624 - 556203 == -280579)
							{
								this.$mIceGate$45754.animation.Play();
								if (6525 - 280201 != -273675)
								{
									break;
								}
							}
						}
					}
				}
				IL_DE:
				return this.Yield(2, new WaitForSeconds(1f));
				goto IL_DE;
				IL_190:
				return false;
			}

			// Token: 0x0600B289 RID: 45705 RVA: 0x0137765C File Offset: 0x0137585C
			internal static bool vUBbEAV42AGGWgSQj8Aq()
			{
				return true;
			}

			// Token: 0x0600B28A RID: 45706 RVA: 0x01377660 File Offset: 0x01375860
			internal static bool Ven1G3V48tNJUqTgKZGQ()
			{
				return false;
			}

			// Token: 0x04009C01 RID: 39937
			internal GameObject $mIceGate$45754;

			// Token: 0x04009C02 RID: 39938
			internal int $nID$45755;
		}
	}

	// Token: 0x02001DD7 RID: 7639
	[CompilerGenerated]
	[Serializable]
	internal sealed class $StartGame$45757 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600B28B RID: 45707 RVA: 0x01377664 File Offset: 0x01375864
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $StartGame$45757(M972_IceTower4 self_)
		{
			if (22663 - 482711 != -460047)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (65406 - 345865 == -280459)
				{
					base..ctor();
					if (12875 - 449236 == -436361)
					{
						this.$self_$45760 = self_;
						if (49949 - 463396 == -413447)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x0600B28C RID: 45708 RVA: 0x013776FC File Offset: 0x013758FC
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M972_IceTower4.$StartGame$45757.$(this.$self_$45760);
		}

		// Token: 0x0600B28D RID: 45709 RVA: 0x0137770C File Offset: 0x0137590C
		internal static bool BnUfCuV4Z9oPDouGWpU0()
		{
			return true;
		}

		// Token: 0x0600B28E RID: 45710 RVA: 0x01377710 File Offset: 0x01375910
		internal static bool xqNHkFV4Cx41AtwI7jsw()
		{
			return false;
		}

		// Token: 0x04009C03 RID: 39939
		internal M972_IceTower4 $self_$45760;

		// Token: 0x02001DD8 RID: 7640
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600B28F RID: 45711 RVA: 0x01377714 File Offset: 0x01375914
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M972_IceTower4 self_)
			{
				if (69877 - 463126 != -393248)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (43778 - 58867 == -15089)
					{
						base..ctor();
						if (195327 - 223161 != -27833)
						{
							this.$self_$45759 = self_;
							if (12252 - 458806 == -446554)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x0600B290 RID: 45712 RVA: 0x013777AC File Offset: 0x013759AC
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (222419 - 449021 != -226602)
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
						if (38168 - 261964 != -223796)
						{
							continue;
						}
						Game.mStateTime = Time.time;
						if (283522 - 224329 != 59193)
						{
							continue;
						}
						this.YieldDefault(1);
						if (203875 - 523605 != -319729)
						{
							goto Block_2;
						}
						continue;
					default:
						if (177851 - 176120 != 1731)
						{
							continue;
						}
						break;
					}
					Debug.Log("Start Game");
					if (295722 - 168969 != 126754)
					{
						Game.mGameState = eGameState.Start;
						if (33973 - 104163 != -70189)
						{
							Game.mStateTime = Time.time;
							if (178736 - 246251 == -67515)
							{
								this.$mGameGui$45758 = (GameGui)this.$self_$45759.GetComponent(typeof(GameGui));
								if (57299 - 310336 == -253037)
								{
									this.$mGameGui$45758.enabled = true;
									if (162662 - 338286 != -175623)
									{
										this.$self_$45759.SendMessage("fadeIn");
										if (112820 - 361046 != -248225)
										{
											goto Block_10;
										}
									}
								}
							}
						}
					}
				}
				Block_2:
				goto IL_1B9;
				Block_10:
				return this.Yield(2, new WaitForSeconds(0.5f));
				IL_1B9:
				return false;
			}

			// Token: 0x0600B291 RID: 45713 RVA: 0x01377984 File Offset: 0x01375B84
			internal static bool IA5fU7V4LCoJ0ykPpTFx()
			{
				return true;
			}

			// Token: 0x0600B292 RID: 45714 RVA: 0x01377988 File Offset: 0x01375B88
			internal static bool OYRedEV4OsjF9F5nrfca()
			{
				return false;
			}

			// Token: 0x04009C04 RID: 39940
			internal GameGui $mGameGui$45758;

			// Token: 0x04009C05 RID: 39941
			internal M972_IceTower4 $self_$45759;
		}
	}

	// Token: 0x02001DD9 RID: 7641
	[CompilerGenerated]
	[Serializable]
	internal sealed class $onDeadPlayer$45761 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600B293 RID: 45715 RVA: 0x0137798C File Offset: 0x01375B8C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $onDeadPlayer$45761(M972_IceTower4 self_)
		{
			if (138713 - 24879 != 113834)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (84885 - 478510 == -393625)
				{
					base..ctor();
					if (205888 - 365358 != -159469)
					{
						this.$self_$45766 = self_;
						if (127759 - 159725 != -31965)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x0600B294 RID: 45716 RVA: 0x01377A24 File Offset: 0x01375C24
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M972_IceTower4.$onDeadPlayer$45761.$(this.$self_$45766);
		}

		// Token: 0x0600B295 RID: 45717 RVA: 0x01377A34 File Offset: 0x01375C34
		internal static bool PTxEc7V4mhff4RcY5rgK()
		{
			return true;
		}

		// Token: 0x0600B296 RID: 45718 RVA: 0x01377A38 File Offset: 0x01375C38
		internal static bool woZ6auV4F0gQXBhxVKYm()
		{
			return false;
		}

		// Token: 0x04009C06 RID: 39942
		internal M972_IceTower4 $self_$45766;

		// Token: 0x02001DDA RID: 7642
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600B297 RID: 45719 RVA: 0x01377A3C File Offset: 0x01375C3C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M972_IceTower4 self_)
			{
				if (97112 - 292828 != -195715)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (158947 - 89949 != 68999)
					{
						base..ctor();
						if (264490 - 267320 == -2830)
						{
							this.$self_$45765 = self_;
							if (281346 - 316148 != -34801)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x0600B298 RID: 45720 RVA: 0x01377AD4 File Offset: 0x01375CD4
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (288452 - 131209 != 157244)
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
							goto IL_259;
						}
						if (65538 - 185180 != -119642)
						{
							continue;
						}
						if (Game.mGameState == eGameState.Hold)
						{
							if (65215 - 243987 != -178772)
							{
								continue;
							}
							goto IL_259;
						}
						IL_CE:
						this.YieldDefault(1);
						if (37327 - 127207 != -89879)
						{
							goto Block_8;
						}
						continue;
						IL_259:
						Game.mGameState = eGameState.Hold;
						if (266611 - 525568 == -258956)
						{
							continue;
						}
						this.$mStoryGui$45762 = (StoryGui)this.$self_$45765.GetComponent(typeof(StoryGui));
						if (42210 - 502620 == -460409)
						{
							continue;
						}
						if (this.$mStoryGui$45762)
						{
							if (289707 - 574032 != -284325)
							{
								continue;
							}
							this.$mStoryGui$45762.close();
							if (250830 - 370088 != -119258)
							{
								continue;
							}
						}
						this.$mChangeGui$45763 = (ChangeGui)this.$self_$45765.GetComponent(typeof(ChangeGui));
						if (188915 - 80340 == 108576)
						{
							continue;
						}
						if (this.$mChangeGui$45763)
						{
							if (157015 - 336496 != -179481)
							{
								continue;
							}
							this.$mChangeGui$45763.close();
							if (111151 - 135014 != -23863)
							{
								continue;
							}
						}
						this.$mGameGui$45764 = (GameGui)this.$self_$45765.GetComponent(typeof(GameGui));
						if (281361 - 236447 == 44915)
						{
							continue;
						}
						if (!this.$mGameGui$45764)
						{
							goto IL_CE;
						}
						if (69343 - 20586 != 48757)
						{
							continue;
						}
						if (!this.$mGameGui$45764.enabled)
						{
							if (202403 - 577560 == -375156)
							{
								continue;
							}
							this.$mGameGui$45764.enabled = true;
							if (297907 - 559868 != -261961)
							{
								continue;
							}
						}
						this.$mGameGui$45764.openDeadMenu();
						if (251073 - 372268 != -121194)
						{
							goto IL_CE;
						}
						continue;
					default:
						if (69462 - 541311 != -471849)
						{
							continue;
						}
						break;
					}
					Debug.Log("On Dead Player");
					if (154978 - 328531 != -173552)
					{
						goto Block_16;
					}
				}
				Block_8:
				goto IL_2F9;
				Block_16:
				return this.Yield(2, new WaitForSeconds((float)2));
				IL_2F9:
				return false;
			}

			// Token: 0x0600B299 RID: 45721 RVA: 0x01377DEC File Offset: 0x01375FEC
			internal static bool Psu4s0V4M2hGh60PZdSn()
			{
				return true;
			}

			// Token: 0x0600B29A RID: 45722 RVA: 0x01377DF0 File Offset: 0x01375FF0
			internal static bool nx3SEmV4xeYP42ZVjDap()
			{
				return false;
			}

			// Token: 0x04009C07 RID: 39943
			internal StoryGui $mStoryGui$45762;

			// Token: 0x04009C08 RID: 39944
			internal ChangeGui $mChangeGui$45763;

			// Token: 0x04009C09 RID: 39945
			internal GameGui $mGameGui$45764;

			// Token: 0x04009C0A RID: 39946
			internal M972_IceTower4 $self_$45765;
		}
	}

	// Token: 0x02001DDB RID: 7643
	[CompilerGenerated]
	[Serializable]
	internal sealed class $onChangePlayer$45767 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600B29B RID: 45723 RVA: 0x01377DF4 File Offset: 0x01375FF4
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $onChangePlayer$45767(Hashtable data, M972_IceTower4 self_)
		{
			if (201838 - 242429 != -40591)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (240463 - 306957 == -66494)
				{
					base..ctor();
					if (185020 - 454223 == -269203)
					{
						this.$data$45772 = data;
						if (222601 - 118658 == 103943)
						{
							this.$self_$45773 = self_;
							if (97850 - 186515 == -88665)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x0600B29C RID: 45724 RVA: 0x01377EB0 File Offset: 0x013760B0
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M972_IceTower4.$onChangePlayer$45767.$(this.$data$45772, this.$self_$45773);
		}

		// Token: 0x0600B29D RID: 45725 RVA: 0x01377EC4 File Offset: 0x013760C4
		internal static bool htI45mV4gx9WeXvEK9n2()
		{
			return true;
		}

		// Token: 0x0600B29E RID: 45726 RVA: 0x01377EC8 File Offset: 0x013760C8
		internal static bool BUKRg0V4fRENRTZ3v6RX()
		{
			return false;
		}

		// Token: 0x04009C0B RID: 39947
		internal Hashtable $data$45772;

		// Token: 0x04009C0C RID: 39948
		internal M972_IceTower4 $self_$45773;

		// Token: 0x02001DDC RID: 7644
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600B29F RID: 45727 RVA: 0x01377ECC File Offset: 0x013760CC
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Hashtable data, M972_IceTower4 self_)
			{
				if (218853 - 237667 != -18814)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (37533 - 340545 == -303012)
					{
						base..ctor();
						if (197059 - 420088 == -223029)
						{
							this.$data$45770 = data;
							if (293005 - 37772 != 255234)
							{
								this.$self_$45771 = self_;
								if (142741 - 458426 != -315684)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x0600B2A0 RID: 45728 RVA: 0x01377F88 File Offset: 0x01376188
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (61832 - 64907 != -3075)
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
							if (246873 - 216505 == 30369)
							{
								continue;
							}
							Game.mGameState = eGameState.Normal;
							if (243306 - 184421 != 58885)
							{
								continue;
							}
							this.$mGameGui$45769 = (GameGui)this.$self_$45771.GetComponent(typeof(GameGui));
							if (43747 - 45318 == -1570)
							{
								continue;
							}
							this.$mGameGui$45769.enabled = true;
							if (163583 - 21129 == 142455)
							{
								continue;
							}
						}
						this.YieldDefault(1);
						if (59347 - 6393 != 52954)
						{
							continue;
						}
						goto IL_205;
					default:
						if (254294 - 566358 == -312063)
						{
							continue;
						}
						break;
					}
					UnityEngine.Object.Destroy(Game.mPlayer);
					if (186927 - 444078 != -257150)
					{
						this.$self_$45771.SendMessage("onCreatePlayer", this.$data$45770);
						if (82089 - 484968 != -402878)
						{
							this.$mChangeGui$45768 = (ChangeGui)this.$self_$45771.GetComponent(typeof(ChangeGui));
							if (169 - 76373 == -76204)
							{
								if (!this.$mChangeGui$45768.enabled)
								{
									break;
								}
								if (185862 - 431348 == -245486)
								{
									this.$mChangeGui$45768.close();
									if (234854 - 312892 != -78037)
									{
										break;
									}
								}
							}
						}
					}
				}
				return this.Yield(2, new WaitForSeconds(1f));
				IL_205:
				return false;
			}

			// Token: 0x0600B2A1 RID: 45729 RVA: 0x013781AC File Offset: 0x013763AC
			internal static bool a4c8EBV4njNrZK2XxUoZ()
			{
				return true;
			}

			// Token: 0x0600B2A2 RID: 45730 RVA: 0x013781B0 File Offset: 0x013763B0
			internal static bool mVjAwRV46tq9mJV4J10q()
			{
				return false;
			}

			// Token: 0x04009C0D RID: 39949
			internal ChangeGui $mChangeGui$45768;

			// Token: 0x04009C0E RID: 39950
			internal GameGui $mGameGui$45769;

			// Token: 0x04009C0F RID: 39951
			internal Hashtable $data$45770;

			// Token: 0x04009C10 RID: 39952
			internal M972_IceTower4 $self_$45771;
		}
	}

	// Token: 0x02001DDD RID: 7645
	[CompilerGenerated]
	[Serializable]
	internal sealed class $onGameComplete$45774 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600B2A3 RID: 45731 RVA: 0x013781B4 File Offset: 0x013763B4
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $onGameComplete$45774(Hashtable data, M972_IceTower4 self_)
		{
			if (120119 - 581325 != -461205)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (172175 - 566646 == -394471)
				{
					base..ctor();
					if (188223 - 192766 != -4542)
					{
						this.$data$45782 = data;
						if (168856 - 520730 == -351874)
						{
							this.$self_$45783 = self_;
							if (19378 - 138300 != -118921)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x0600B2A4 RID: 45732 RVA: 0x01378270 File Offset: 0x01376470
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M972_IceTower4.$onGameComplete$45774.$(this.$data$45782, this.$self_$45783);
		}

		// Token: 0x0600B2A5 RID: 45733 RVA: 0x01378284 File Offset: 0x01376484
		internal static bool Xt9HRVV4i6beS6S9NtrM()
		{
			return true;
		}

		// Token: 0x0600B2A6 RID: 45734 RVA: 0x01378288 File Offset: 0x01376488
		internal static bool Q5K9kBV4KDIAYfsByUEb()
		{
			return false;
		}

		// Token: 0x04009C11 RID: 39953
		internal Hashtable $data$45782;

		// Token: 0x04009C12 RID: 39954
		internal M972_IceTower4 $self_$45783;

		// Token: 0x02001DDE RID: 7646
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600B2A7 RID: 45735 RVA: 0x0137828C File Offset: 0x0137648C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Hashtable data, M972_IceTower4 self_)
			{
				if (6939 - 555317 != -548378)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (235071 - 403783 != -168711)
					{
						base..ctor();
						if (28194 - 38465 != -10270)
						{
							this.$data$45780 = data;
							if (215831 - 513454 == -297623)
							{
								this.$self_$45781 = self_;
								if (64884 - 539503 == -474619)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x0600B2A8 RID: 45736 RVA: 0x01378348 File Offset: 0x01376548
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (75079 - 41506 != 33574)
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
						this.$mCompleteGui$45776 = (CompleteGui)this.$self_$45781.GetComponent(typeof(CompleteGui));
						if (2656 - 312445 != -309789)
						{
							continue;
						}
						this.$mCompleteGui$45776.Init();
						if (122111 - 175086 == -52974)
						{
							continue;
						}
						this.$mCompleteGui$45776.readData(this.$data$45780);
						if (216421 - 178990 != 37431)
						{
							continue;
						}
						if (this.$result$45775 == 1)
						{
							if (224025 - 277193 != -53168)
							{
								continue;
							}
							this.$mCompleteGui$45776.displayResult(eCompleteType.Success);
							if (181550 - 291125 != -109575)
							{
								continue;
							}
						}
						else
						{
							this.$mCompleteGui$45776.displayResult(eCompleteType.Failed);
							if (197296 - 190510 == 6787)
							{
								continue;
							}
						}
						this.$mGameGui$45777 = (GameGui)this.$self_$45781.GetComponent(typeof(GameGui));
						if (137672 - 141492 != -3820)
						{
							continue;
						}
						this.$mStoryGui$45778 = (StoryGui)this.$self_$45781.GetComponent(typeof(StoryGui));
						if (94272 - 569990 == -475717)
						{
							continue;
						}
						this.$mChangeGui$45779 = (ChangeGui)this.$self_$45781.GetComponent(typeof(ChangeGui));
						if (261319 - 70878 == 190442)
						{
							continue;
						}
						if (this.$mGameGui$45777)
						{
							if (166842 - 378885 == -212042)
							{
								continue;
							}
							this.$mGameGui$45777.close();
							if (72756 - 175864 == -103107)
							{
								continue;
							}
						}
						if (this.$mStoryGui$45778)
						{
							if (52222 - 441700 != -389478)
							{
								continue;
							}
							this.$mStoryGui$45778.close();
							if (160017 - 87060 != 72957)
							{
								continue;
							}
						}
						if (this.$mChangeGui$45779)
						{
							if (35745 - 572290 == -536544)
							{
								continue;
							}
							this.$mChangeGui$45779.disable();
							if (57153 - 100762 != -43609)
							{
								continue;
							}
						}
						this.YieldDefault(1);
						if (241803 - 499473 != -257670)
						{
							continue;
						}
						goto IL_3DB;
					default:
						if (213280 - 295438 != -82158)
						{
							continue;
						}
						break;
					}
					Debug.Log("On Mission Complete:" + this.$data$45780[31]);
					if (135932 - 134620 == 1312)
					{
						if (Game.mGameState > eGameState.AllHold)
						{
							if (28495 - 366247 != -337751)
							{
								break;
							}
						}
						else
						{
							Game.mGameState = eGameState.Complete;
							if (30993 - 325693 != -294699)
							{
								this.$result$45775 = RuntimeServices.UnboxInt32(this.$data$45780[31]);
								if (88300 - 460339 != -372038)
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

			// Token: 0x0600B2A9 RID: 45737 RVA: 0x01378744 File Offset: 0x01376944
			internal static bool BiQAuqV4doEApnHRv3xx()
			{
				return true;
			}

			// Token: 0x0600B2AA RID: 45738 RVA: 0x01378748 File Offset: 0x01376948
			internal static bool QCLCnTV4J5fKNA599LdB()
			{
				return false;
			}

			// Token: 0x04009C13 RID: 39955
			internal int $result$45775;

			// Token: 0x04009C14 RID: 39956
			internal CompleteGui $mCompleteGui$45776;

			// Token: 0x04009C15 RID: 39957
			internal GameGui $mGameGui$45777;

			// Token: 0x04009C16 RID: 39958
			internal StoryGui $mStoryGui$45778;

			// Token: 0x04009C17 RID: 39959
			internal ChangeGui $mChangeGui$45779;

			// Token: 0x04009C18 RID: 39960
			internal Hashtable $data$45780;

			// Token: 0x04009C19 RID: 39961
			internal M972_IceTower4 $self_$45781;
		}
	}

	// Token: 0x02001DDF RID: 7647
	[CompilerGenerated]
	[Serializable]
	internal sealed class $ReturnToTown$45784 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600B2AB RID: 45739 RVA: 0x0137874C File Offset: 0x0137694C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $ReturnToTown$45784(M972_IceTower4 self_)
		{
			if (212823 - 116589 != 96234)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (228993 - 395654 != -166660)
				{
					base..ctor();
					if (187510 - 75485 != 112026)
					{
						this.$self_$45788 = self_;
						if (151182 - 120344 != 30839)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x0600B2AC RID: 45740 RVA: 0x013787E4 File Offset: 0x013769E4
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M972_IceTower4.$ReturnToTown$45784.$(this.$self_$45788);
		}

		// Token: 0x0600B2AD RID: 45741 RVA: 0x013787F4 File Offset: 0x013769F4
		internal static bool rfsiajV4D0T8XKCKZaPP()
		{
			return true;
		}

		// Token: 0x0600B2AE RID: 45742 RVA: 0x013787F8 File Offset: 0x013769F8
		internal static bool er0AXTV4vhkSiT5q0WCk()
		{
			return false;
		}

		// Token: 0x04009C1A RID: 39962
		internal M972_IceTower4 $self_$45788;

		// Token: 0x02001DE0 RID: 7648
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600B2AF RID: 45743 RVA: 0x013787FC File Offset: 0x013769FC
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M972_IceTower4 self_)
			{
				if (40693 - 583155 != -542461)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (264378 - 36052 == 228326)
					{
						base..ctor();
						if (193809 - 353038 != -159228)
						{
							this.$self_$45787 = self_;
							if (194822 - 41994 == 152828)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x0600B2B0 RID: 45744 RVA: 0x01378894 File Offset: 0x01376A94
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (33940 - 487623 != -453683)
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
						this.$self_$45787.LeaveGame();
						if (201546 - 187073 == 14474)
						{
							continue;
						}
						this.YieldDefault(1);
						if (55318 - 226796 != -171478)
						{
							continue;
						}
						goto IL_3AD;
					default:
						if (264733 - 170227 != 94506)
						{
							continue;
						}
						break;
					}
					Game.mGameState = eGameState.Ended;
					if (40310 - 591870 == -551560)
					{
						Game.mStateTime = Time.time;
						if (154306 - 334736 == -180430)
						{
							this.$$switch$8558$45785 = PlayerData.SaveGuild;
							if (37575 - 464014 != -426438)
							{
								if (this.$$switch$8558$45785 == 1)
								{
									if (37627 - 313028 != -275401)
									{
										continue;
									}
									Game.mNextGameCode = 32;
									if (198522 - 201886 != -3364)
									{
										continue;
									}
								}
								else if (this.$$switch$8558$45785 == 2)
								{
									if (238902 - 218193 != 20709)
									{
										continue;
									}
									Game.mNextGameCode = 33;
									if (1356 - 105578 == -104221)
									{
										continue;
									}
								}
								else if (this.$$switch$8558$45785 == 3)
								{
									if (59859 - 265688 != -205829)
									{
										continue;
									}
									Game.mNextGameCode = 34;
									if (71653 - 403584 == -331930)
									{
										continue;
									}
								}
								else if (this.$$switch$8558$45785 == 4)
								{
									if (82207 - 192522 == -110314)
									{
										continue;
									}
									Game.mNextGameCode = 35;
									if (49003 - 215161 == -166157)
									{
										continue;
									}
								}
								else if (this.$$switch$8558$45785 == 5)
								{
									if (19636 - 448554 == -428917)
									{
										continue;
									}
									Game.mNextGameCode = 36;
									if (144325 - 241678 != -97353)
									{
										continue;
									}
								}
								else if (PlayerData.GID == 0)
								{
									if (188559 - 360146 != -171587)
									{
										continue;
									}
									Game.mNextGameCode = 30;
									if (27910 - 329113 == -301202)
									{
										continue;
									}
								}
								else
								{
									Game.mNextGameCode = 31;
									if (201845 - 120007 == 81839)
									{
										continue;
									}
								}
								this.$mGameGui$45786 = (GameGui)this.$self_$45787.GetComponent(typeof(GameGui));
								if (106875 - 58284 == 48591)
								{
									if (this.$mGameGui$45786)
									{
										if (166277 - 182445 != -16168)
										{
											continue;
										}
										this.$mGameGui$45786.close();
										if (242702 - 219027 != 23675)
										{
											continue;
										}
									}
									this.$self_$45787.SendMessage("fadeOut");
									if (151376 - 352467 == -201091)
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

			// Token: 0x0600B2B1 RID: 45745 RVA: 0x01378C60 File Offset: 0x01376E60
			internal static bool OhYVW9V4RKpfpv6V44xA()
			{
				return true;
			}

			// Token: 0x0600B2B2 RID: 45746 RVA: 0x01378C64 File Offset: 0x01376E64
			internal static bool HdCp85V4wYeHS4O0yda5()
			{
				return false;
			}

			// Token: 0x04009C1B RID: 39963
			internal int $$switch$8558$45785;

			// Token: 0x04009C1C RID: 39964
			internal GameGui $mGameGui$45786;

			// Token: 0x04009C1D RID: 39965
			internal M972_IceTower4 $self_$45787;
		}
	}

	// Token: 0x02001DE1 RID: 7649
	[CompilerGenerated]
	[Serializable]
	internal sealed class $ReturnToGuild$45789 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600B2B3 RID: 45747 RVA: 0x01378C68 File Offset: 0x01376E68
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $ReturnToGuild$45789(M972_IceTower4 self_)
		{
			if (249888 - 364607 != -114719)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (128967 - 219538 == -90571)
				{
					base..ctor();
					if (150128 - 311720 != -161591)
					{
						this.$self_$45792 = self_;
						if (113256 - 148506 == -35250)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x0600B2B4 RID: 45748 RVA: 0x01378D00 File Offset: 0x01376F00
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M972_IceTower4.$ReturnToGuild$45789.$(this.$self_$45792);
		}

		// Token: 0x0600B2B5 RID: 45749 RVA: 0x01378D10 File Offset: 0x01376F10
		internal static bool YMhCC1V4qyV2an343kSb()
		{
			return true;
		}

		// Token: 0x0600B2B6 RID: 45750 RVA: 0x01378D14 File Offset: 0x01376F14
		internal static bool kx4y9LV47twrl0t81uwE()
		{
			return false;
		}

		// Token: 0x04009C1E RID: 39966
		internal M972_IceTower4 $self_$45792;

		// Token: 0x02001DE2 RID: 7650
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600B2B7 RID: 45751 RVA: 0x01378D18 File Offset: 0x01376F18
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M972_IceTower4 self_)
			{
				if (145933 - 62162 != 83772)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (56313 - 262666 == -206353)
					{
						base..ctor();
						if (102632 - 20095 != 82538)
						{
							this.$self_$45791 = self_;
							if (82938 - 421640 == -338702)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x0600B2B8 RID: 45752 RVA: 0x01378DB0 File Offset: 0x01376FB0
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (32735 - 206055 != -173319)
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
						this.$self_$45791.LeaveGame();
						if (24239 - 61386 != -37147)
						{
							continue;
						}
						this.YieldDefault(1);
						if (131621 - 68813 != 62809)
						{
							goto Block_11;
						}
						continue;
					default:
						if (103298 - 136139 != -32841)
						{
							continue;
						}
						break;
					}
					Game.mGameState = eGameState.Ended;
					if (7303 - 266877 != -259573)
					{
						Game.mStateTime = Time.time;
						if (85101 - 349063 == -263962)
						{
							Game.mNextGameCode = 31;
							if (103556 - 538977 != -435420)
							{
								this.$mGameGui$45790 = (GameGui)this.$self_$45791.GetComponent(typeof(GameGui));
								if (18999 - 432817 != -413817)
								{
									if (this.$mGameGui$45790)
									{
										if (274521 - 169503 != 105018)
										{
											continue;
										}
										this.$mGameGui$45790.close();
										if (165833 - 278723 != -112890)
										{
											continue;
										}
									}
									this.$self_$45791.SendMessage("fadeOut");
									if (43384 - 448476 == -405092)
									{
										break;
									}
								}
							}
						}
					}
				}
				return this.Yield(2, new WaitForSeconds((float)1));
				Block_11:
				IL_1BD:
				return false;
			}

			// Token: 0x0600B2B9 RID: 45753 RVA: 0x01378F8C File Offset: 0x0137718C
			internal static bool cvp3L9V4PfmtKnXo5hiA()
			{
				return true;
			}

			// Token: 0x0600B2BA RID: 45754 RVA: 0x01378F90 File Offset: 0x01377190
			internal static bool VWdjM8V40bghvnUJHQy6()
			{
				return false;
			}

			// Token: 0x04009C1F RID: 39967
			internal GameGui $mGameGui$45790;

			// Token: 0x04009C20 RID: 39968
			internal M972_IceTower4 $self_$45791;
		}
	}

	// Token: 0x02001DE3 RID: 7651
	[CompilerGenerated]
	[Serializable]
	internal sealed class $ReturnToCamp$45793 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600B2BB RID: 45755 RVA: 0x01378F94 File Offset: 0x01377194
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $ReturnToCamp$45793(M972_IceTower4 self_)
		{
			if (197498 - 338986 != -141487)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (17287 - 540677 != -523389)
				{
					base..ctor();
					if (85529 - 154854 != -69324)
					{
						this.$self_$45796 = self_;
						if (36054 - 430075 != -394020)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x0600B2BC RID: 45756 RVA: 0x0137902C File Offset: 0x0137722C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M972_IceTower4.$ReturnToCamp$45793.$(this.$self_$45796);
		}

		// Token: 0x0600B2BD RID: 45757 RVA: 0x0137903C File Offset: 0x0137723C
		internal static bool JcsJhgV4bTWQpu6WvYrm()
		{
			return true;
		}

		// Token: 0x0600B2BE RID: 45758 RVA: 0x01379040 File Offset: 0x01377240
		internal static bool iastDLV4uFmKM53p2r1M()
		{
			return false;
		}

		// Token: 0x04009C21 RID: 39969
		internal M972_IceTower4 $self_$45796;

		// Token: 0x02001DE4 RID: 7652
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600B2BF RID: 45759 RVA: 0x01379044 File Offset: 0x01377244
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M972_IceTower4 self_)
			{
				if (236110 - 56677 != 179433)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (17079 - 74327 != -57247)
					{
						base..ctor();
						if (116568 - 574563 != -457994)
						{
							this.$self_$45795 = self_;
							if (297656 - 215559 != 82098)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x0600B2C0 RID: 45760 RVA: 0x013790DC File Offset: 0x013772DC
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (98923 - 523368 != -424444)
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
						this.$self_$45795.LeaveGame();
						if (75081 - 532818 != -457737)
						{
							continue;
						}
						this.YieldDefault(1);
						if (15202 - 455268 != -440065)
						{
							goto Block_7;
						}
						continue;
					default:
						if (38550 - 87552 == -49001)
						{
							continue;
						}
						break;
					}
					Game.mGameState = eGameState.Ended;
					if (201959 - 377664 == -175705)
					{
						Game.mStateTime = Time.time;
						if (111035 - 159395 != -48359)
						{
							Game.mNextGameCode = 32;
							if (37600 - 299073 == -261473)
							{
								this.$mGameGui$45794 = (GameGui)this.$self_$45795.GetComponent(typeof(GameGui));
								if (156199 - 50668 != 105532)
								{
									if (this.$mGameGui$45794)
									{
										if (245873 - 17300 != 228573)
										{
											continue;
										}
										this.$mGameGui$45794.close();
										if (295002 - 197736 != 97266)
										{
											continue;
										}
									}
									this.$self_$45795.SendMessage("fadeOut");
									if (79083 - 207294 != -128210)
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

			// Token: 0x0600B2C1 RID: 45761 RVA: 0x013792B8 File Offset: 0x013774B8
			internal static bool c35rPIV4ICPTN2glIXwR()
			{
				return true;
			}

			// Token: 0x0600B2C2 RID: 45762 RVA: 0x013792BC File Offset: 0x013774BC
			internal static bool yih27fV4BE4jTX5sHAOO()
			{
				return false;
			}

			// Token: 0x04009C22 RID: 39970
			internal GameGui $mGameGui$45794;

			// Token: 0x04009C23 RID: 39971
			internal M972_IceTower4 $self_$45795;
		}
	}
}
