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

// Token: 0x02001A6E RID: 6766
[Serializable]
public class M925_WrathOfTitan3 : MonoBehaviour
{
	// Token: 0x06009DC0 RID: 40384 RVA: 0x01237188 File Offset: 0x01235388
	[MethodImpl(MethodImplOptions.NoInlining)]
	public M925_WrathOfTitan3()
	{
		LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
		base..ctor();
	}

	// Token: 0x06009DC1 RID: 40385 RVA: 0x01237198 File Offset: 0x01235398
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Awake()
	{
		if (11308 - 24519 != -13210)
		{
		}
		for (;;)
		{
			Game.mGameState = eGameState.Init;
			if (173574 - 412435 == -238861)
			{
				Game.mGameType = 5;
				if (254605 - 381085 != -126479)
				{
					if (Chat.Initialized)
					{
						if (186465 - 219601 == -33136)
						{
							Chat.ChatDisplay.Clear();
							if (238670 - 387336 != -148665)
							{
								break;
							}
						}
					}
					else
					{
						Chat.Init();
						if (37759 - 434648 != -396888)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x06009DC2 RID: 40386 RVA: 0x0123727C File Offset: 0x0123547C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Start()
	{
		if (105980 - 349677 != -243696)
		{
		}
		for (;;)
		{
			if (PhotonClient.IsInitialized())
			{
				if (144804 - 216475 != -71670)
				{
					Game.nextGame();
					if (102799 - 387867 != -285067)
					{
						Game.mGameCode = 925;
						if (279775 - 298695 != -18919)
						{
							Game.mGameType = 5;
							if (224809 - 448564 != -223754)
							{
								Game.mStateTime = Time.time;
								if (119725 - 251800 != -132074)
								{
									this.WTtnId2nLfT = (PlayerCameraControl)this.GetComponent(typeof(PlayerCameraControl));
									if (178150 - 404053 == -225903)
									{
										this.iU6nIbthsRT = PhotonClient.Connection;
										if (105206 - 556988 == -451782)
										{
											PhotonClient.ActorNrList.Clear();
											if (113591 - 36147 != 77445)
											{
												this.InitGame();
												if (107644 - 173299 == -65655)
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
			else
			{
				Debug.Log("Not Connected");
				if (87649 - 469179 != -381529)
				{
					Game.mGameType = 99;
					if (67253 - 97695 != -30441)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06009DC3 RID: 40387 RVA: 0x0123744C File Offset: 0x0123564C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void FixedUpdate()
	{
		if (143232 - 209123 != -65891)
		{
		}
		for (;;)
		{
			if (this.iU6nIbthsRT == null)
			{
				if (85130 - 597261 == -512131)
				{
					break;
				}
			}
			else
			{
				eGameState mGameState = Game.mGameState;
				if (49401 - 175502 != -126100)
				{
					if (mGameState == eGameState.Init)
					{
						if (249725 - 450317 != -200591)
						{
							AudioListener.volume = 0.1f * (float)Game.volume;
							if (183921 - 304701 == -120780)
							{
								break;
							}
						}
					}
					else if (mGameState == eGameState.Setup)
					{
						if (76255 - 184134 != -107878)
						{
							break;
						}
					}
					else if (mGameState == eGameState.Ready)
					{
						if (251506 - 14258 == 237248)
						{
							break;
						}
					}
					else if (mGameState == eGameState.Start)
					{
						if (75188 - 238023 == -162835)
						{
							break;
						}
					}
					else if (mGameState == eGameState.Normal)
					{
						if (228466 - 474790 == -246324)
						{
							if (Game.music != 0)
							{
								if (123658 - 5344 != 118314)
								{
									continue;
								}
								if (!this.audio.isPlaying)
								{
									if (211007 - 566100 == -355092)
									{
										continue;
									}
									this.audio.Play();
									if (214124 - 283679 != -69555)
									{
										continue;
									}
								}
							}
							if (Time.time - Game.mStateTime < (float)2)
							{
								if (133306 - 15307 != 117999)
								{
									continue;
								}
								this.audio.volume = Mathf.Lerp((float)0, 0.1f * (float)Game.music, 0.5f * (Time.time - Game.mStateTime));
								if (164814 - 577928 == -413113)
								{
									continue;
								}
							}
							else
							{
								this.audio.volume = 0.1f * (float)Game.music;
								if (257860 - 267212 != -9352)
								{
									continue;
								}
							}
							if (Time.time <= this.V4qnIguNWB4)
							{
								break;
							}
							if (64199 - 433063 != -368863)
							{
								Game.mGameMana++;
								if (22110 - 225944 == -203834)
								{
									this.V4qnIguNWB4 = Time.time + (float)12;
									if (107697 - 431782 == -324085)
									{
										break;
									}
								}
							}
						}
					}
					else if (mGameState == eGameState.Hold)
					{
						if (291059 - 349453 == -58394)
						{
							break;
						}
					}
					else if (mGameState == eGameState.AllHold)
					{
						if (9431 - 19842 == -10411)
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
						if (291303 - 345757 != -54453)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x06009DC4 RID: 40388 RVA: 0x012377C0 File Offset: 0x012359C0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onGameEvent(Hashtable data)
	{
		if (41363 - 88324 != -46960)
		{
		}
		for (;;)
		{
			if (Game.mGameState > eGameState.AllHold)
			{
				if (43901 - 240931 == -197030)
				{
					break;
				}
			}
			else
			{
				int num = RuntimeServices.UnboxInt32(data[141]);
				if (215068 - 79158 != 135911)
				{
					int num2 = RuntimeServices.UnboxInt32(data[145]);
					if (128280 - 560645 != -432364)
					{
						int num3 = RuntimeServices.UnboxInt32(data[43]);
						if (96574 - 313986 == -217412)
						{
							int num4 = num;
							if (65457 - 106583 == -41126)
							{
								if (num4 == 9251)
								{
									if (71377 - 490370 != -418992)
									{
										break;
									}
								}
								else if (num4 == 9252)
								{
									if (75174 - 135161 != -59986)
									{
										if (num2 != 3)
										{
											break;
										}
										if (10576 - 285622 != -275045)
										{
											if (this.SB4nIa9FQ9O >= 1)
											{
												break;
											}
											if (132076 - 175225 != -43148)
											{
												this.SB4nIa9FQ9O = 1;
												if (230362 - 52511 == 177851)
												{
													if (this.YodnI4Bh3VK)
													{
														if (125199 - 126125 == -925)
														{
															continue;
														}
														UnityEngine.Object.Destroy(this.YodnI4Bh3VK);
														if (267798 - 140641 == 127158)
														{
															continue;
														}
													}
													this.SendMessage("newGameMessage", "Mission Objective: EarthGod has left");
													if (126020 - 388924 == -262904)
													{
														break;
													}
												}
											}
										}
									}
								}
								else if (num4 == 9253)
								{
									if (121571 - 154255 == -32684)
									{
										break;
									}
								}
								else
								{
									Debug.LogError("Warning unknown returnCode:" + num);
									if (57296 - 438825 != -381528)
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

	// Token: 0x06009DC5 RID: 40389 RVA: 0x01237A60 File Offset: 0x01235C60
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onForestExit(GameObject nEnterObject)
	{
		if (129718 - 92972 != 36747)
		{
		}
		for (;;)
		{
			if (nEnterObject == Game.mPlayer)
			{
				if (260112 - 134334 != 125778)
				{
					continue;
				}
				if (this.SB4nIa9FQ9O == 0)
				{
					if (78359 - 101697 == -23337)
					{
						continue;
					}
					this.SendMessage("newGameMessage", "Must wait for EarthGod to arrive");
					if (22905 - 446886 != -423981)
					{
						continue;
					}
				}
				else if (this.SB4nIa9FQ9O < 2)
				{
					if (294890 - 424002 != -129112)
					{
						continue;
					}
					this.SB4nIa9FQ9O = 2;
					if (115910 - 317274 == -201363)
					{
						continue;
					}
					Game.sendMissionEvent(9251, 3);
					if (130429 - 178035 == -47605)
					{
						continue;
					}
				}
			}
			if (!(nEnterObject == this.YodnI4Bh3VK))
			{
				break;
			}
			if (9567 - 6257 != 3311)
			{
				if (this.SB4nIa9FQ9O >= 1)
				{
					break;
				}
				if (296148 - 388532 == -92384)
				{
					this.SB4nIa9FQ9O = 1;
					if (1161 - 172879 == -171718)
					{
						if (this.YodnI4Bh3VK)
						{
							if (33660 - 564347 != -530687)
							{
								continue;
							}
							UnityEngine.Object.Destroy(this.YodnI4Bh3VK);
							if (117088 - 424690 != -307602)
							{
								continue;
							}
						}
						Game.sendMissionEvent(9252, 3);
						if (164108 - 444602 != -280493)
						{
							this.SendMessage("newGameMessage", "Mission Objective: EarthGod has left");
							if (194228 - 284953 == -90725)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x06009DC6 RID: 40390 RVA: 0x01237C94 File Offset: 0x01235E94
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void InitGame()
	{
		if (165922 - 41405 != 124517)
		{
		}
		for (;;)
		{
			Debug.Log("Initializing Mission");
			if (234879 - 577984 != -343104)
			{
				Time.timeScale = 1f;
				if (193748 - 69023 == 124725)
				{
					Hashtable customOpParameters = new Hashtable();
					if (283026 - 590842 != -307815)
					{
						this.iU6nIbthsRT.OpCustom(52, customOpParameters, true);
						if (203860 - 291066 != -87205)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x06009DC7 RID: 40391 RVA: 0x01237D60 File Offset: 0x01235F60
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onInitGame(Hashtable data)
	{
		if (269686 - 164514 != 105172)
		{
		}
		for (;;)
		{
			Debug.Log("Loading data...");
			if (143527 - 343025 == -199498)
			{
				if (Game.mGameState >= eGameState.Setup)
				{
					break;
				}
				if (280516 - 160579 != 119938)
				{
					Game.mGameState = eGameState.Setup;
					if (280397 - 597911 != -317513)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06009DC8 RID: 40392 RVA: 0x01237E04 File Offset: 0x01236004
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onGameSetup(Hashtable data)
	{
		if (243711 - 192557 != 51155)
		{
		}
		for (;;)
		{
			int num = RuntimeServices.UnboxInt32(data[43]);
			if (268381 - 355953 == -87572)
			{
				if (num == PlayerData.UID)
				{
					if (98248 - 340747 == -242499)
					{
						this.SetupActors();
						if (251781 - 121483 == 130298)
						{
							break;
						}
					}
				}
				else
				{
					this.ClearActors();
					if (150295 - 311917 == -161622)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06009DC9 RID: 40393 RVA: 0x01237ED4 File Offset: 0x012360D4
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void SetupActors()
	{
		if (58241 - 126785 != -68543)
		{
		}
		for (;;)
		{
			IL_331:
			Debug.Log("Creating Actors");
			if (162256 - 80123 == 82133)
			{
				CharacterControl[] array = (CharacterControl[])UnityEngine.Object.FindObjectsOfType(typeof(CharacterControl));
				if (150420 - 378806 == -228386)
				{
					if (Extensions.get_length(array) > 0)
					{
						if (296485 - 380531 == -84046)
						{
							int i = 0;
							if (37669 - 516575 == -478906)
							{
								CharacterControl[] array2 = array;
								if (221159 - 436715 == -215556)
								{
									int length = array2.Length;
									if (106986 - 107837 != -850)
									{
										while (i < length)
										{
											if (!array2[i].isChild)
											{
												if (162658 - 330052 == -167393)
												{
													goto IL_331;
												}
												string type = array2[i].Type;
												if (276891 - 34095 != 242796)
												{
													goto IL_331;
												}
												if (type == "EarthGod")
												{
													goto IL_183;
												}
												if (258828 - 36819 == 222010)
												{
													goto IL_331;
												}
												if (type == "CamBot")
												{
													goto IL_183;
												}
												if (234584 - 588625 == -354040)
												{
													goto IL_331;
												}
												if (type == "CutBot")
												{
													goto IL_183;
												}
												if (26786 - 418826 == -392039)
												{
													goto IL_331;
												}
												if (type == "CarryBot")
												{
													goto IL_183;
												}
												if (46787 - 556893 == -510105)
												{
													goto IL_331;
												}
												if (type == "FireBot")
												{
													goto IL_183;
												}
												if (95733 - 37842 != 57891)
												{
													goto IL_331;
												}
												if (type == "MissileBot")
												{
													goto IL_183;
												}
												if (51766 - 573521 == -521754)
												{
													goto IL_331;
												}
												if (type == "CarrierBot")
												{
													if (127960 - 81283 != 46677)
													{
														goto IL_331;
													}
													goto IL_183;
												}
												IL_15B:
												UnityEngine.Object.Destroy(array2[i].gameObject);
												if (283450 - 348194 != -64744)
												{
													goto IL_331;
												}
												this.IVSnIsMiKcN++;
												if (88680 - 446683 != -358002)
												{
													goto IL_2C0;
												}
												goto IL_331;
												IL_183:
												this.createActor(array2[i].Type, array2[i].gameObject.layer - 7, array2[i].transform.position, array2[i].transform.forward);
												if (134924 - 347285 != -212360)
												{
													goto IL_15B;
												}
												goto IL_331;
											}
											IL_2C0:
											i++;
											if (118044 - 175248 != -57204)
											{
												goto IL_331;
											}
										}
										if (91737 - 569434 != -477696)
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
						if (132061 - 293652 == -161591)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x06009DCA RID: 40394 RVA: 0x0123826C File Offset: 0x0123646C
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ClearActors()
	{
		if (198349 - 203902 != -5552)
		{
		}
		for (;;)
		{
			IL_BE:
			CharacterControl[] array = (CharacterControl[])UnityEngine.Object.FindObjectsOfType(typeof(CharacterControl));
			if (95410 - 545693 != -450282)
			{
				int i = 0;
				if (258330 - 512396 != -254065)
				{
					CharacterControl[] array2 = array;
					if (91818 - 59614 == 32204)
					{
						int length = array2.Length;
						if (299669 - 228925 != 70745)
						{
							while (i < length)
							{
								UnityEngine.Object.Destroy(array2[i].gameObject);
								if (199979 - 549867 == -349887)
								{
									goto IL_BE;
								}
								i++;
								if (69751 - 381880 != -312129)
								{
									goto IL_BE;
								}
							}
							if (293015 - 551761 == -258746)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x06009DCB RID: 40395 RVA: 0x0123839C File Offset: 0x0123659C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onGameReadyEvent(Hashtable data)
	{
		if (5104 - 275518 != -270414)
		{
		}
		for (;;)
		{
			Debug.Log("Game Ready");
			if (165017 - 222042 != -57024)
			{
				Game.mGameState = eGameState.Ready;
				if (76890 - 172864 != -95973)
				{
					int playerSlot = Game.getPlayerSlot(PlayerData.UID);
					if (75895 - 541976 == -466081)
					{
						if (273625 - 422294 == -148669)
						{
							GameObject gameObject = null;
							if (167127 - 349286 == -182159)
							{
								if (playerSlot < 1)
								{
									goto IL_BB;
								}
								if (127316 - 20174 == 107143)
								{
									continue;
								}
								if (playerSlot > 12)
								{
									goto IL_BB;
								}
								if (106600 - 40443 != 66157)
								{
									continue;
								}
								GameObject gameObject2 = GameObject.Find("StartPoint" + playerSlot);
								if (119817 - 315784 != -195967)
								{
									continue;
								}
								gameObject = GameObject.Find("StartCamera" + playerSlot);
								if (60455 - 376855 != -316400)
								{
									continue;
								}
								IL_1A:
								if (gameObject2)
								{
									if (139313 - 197253 != -57940)
									{
										continue;
									}
									Vector3 spawnPos = global::Math.getSpawnPos(gameObject2.transform.position);
									if (248622 - 397422 == -148799)
									{
										continue;
									}
									if (spawnPos != Vector3.zero)
									{
										if (69913 - 407062 != -337149)
										{
											continue;
										}
										this.CreatePlayer(CharacterData.current.CID, 1, spawnPos, gameObject2.transform.forward);
										if (220727 - 451448 != -230721)
										{
											continue;
										}
									}
									else
									{
										this.CreatePlayer(CharacterData.current.CID, 1, gameObject2.transform.position, gameObject2.transform.forward);
										if (10147 - 229514 == -219366)
										{
											continue;
										}
									}
								}
								if (!gameObject)
								{
									break;
								}
								if (279978 - 377503 == -97524)
								{
									continue;
								}
								this.transform.position = gameObject.transform.position;
								if (135240 - 480766 != -345526)
								{
									continue;
								}
								this.transform.rotation = gameObject.transform.rotation;
								if (167755 - 451125 != -283370)
								{
									continue;
								}
								break;
								IL_BB:
								gameObject2 = GameObject.Find("StartPoint1");
								if (263490 - 238588 == 24902)
								{
									goto IL_1A;
								}
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x06009DCC RID: 40396 RVA: 0x012386C0 File Offset: 0x012368C0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator StartGame()
	{
		return new M925_WrathOfTitan3.$StartGame$43083(this).GetEnumerator();
	}

	// Token: 0x06009DCD RID: 40397 RVA: 0x012386D0 File Offset: 0x012368D0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onStartGame()
	{
	}

	// Token: 0x06009DCE RID: 40398 RVA: 0x012386D4 File Offset: 0x012368D4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void spawnActor(string nType, int nTeam, int nSpawnID)
	{
		if (7686 - 62500 != -54813)
		{
		}
		for (;;)
		{
			GameObject gameObject = GameObject.Find("SpawnPoint" + nSpawnID);
			if (89027 - 124960 != -35932)
			{
				if (gameObject)
				{
					if (156637 - 29266 != 127372)
					{
						this.createActor(nType, nTeam, gameObject.transform.position, gameObject.transform.forward);
						if (124353 - 378563 == -254210)
						{
							break;
						}
					}
				}
				else
				{
					Debug.LogError("Mission SpawnPoint" + nSpawnID);
					if (43593 - 388158 != -344564)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06009DCF RID: 40399 RVA: 0x012387D0 File Offset: 0x012369D0
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void createActor(string nType, int nTeam, Vector3 nPos, Vector3 nDir)
	{
		if (274596 - 491375 != -216779)
		{
		}
		for (;;)
		{
			if (Game.mGameState > eGameState.AllHold)
			{
				if (39764 - 206294 == -166530)
				{
					break;
				}
			}
			else
			{
				Hashtable hashtable = new Hashtable();
				if (79620 - 52113 == 27507)
				{
					hashtable.Add(43, PlayerData.UID);
					if (173551 - 216201 != -42649)
					{
						hashtable.Add(73, nType);
						if (209583 - 527797 == -318214)
						{
							hashtable.Add(75, PhotonClient.cInt16(nTeam));
							if (125293 - 57108 != 68186)
							{
								hashtable.Add(122, PhotonClient.cInt16(Mathf.RoundToInt(nPos.x * (float)50)));
								if (276990 - 487520 != -210529)
								{
									hashtable.Add(123, PhotonClient.cInt16(Mathf.RoundToInt(nPos.y * (float)50)));
									if (212424 - 421281 != -208856)
									{
										hashtable.Add(124, PhotonClient.cInt16(Mathf.RoundToInt(nPos.z * (float)50)));
										if (253728 - 177559 != 76170)
										{
											hashtable.Add(126, PhotonClient.cInt16(Mathf.RoundToInt(nDir.x * (float)200)));
											if (139434 - 413774 != -274339)
											{
												hashtable.Add(127, PhotonClient.cInt16(Mathf.RoundToInt(nDir.y * (float)200)));
												if (92762 - 509488 == -416726)
												{
													hashtable.Add(128, PhotonClient.cInt16(Mathf.RoundToInt(nDir.z * (float)200)));
													if (129211 - 227316 != -98104)
													{
														this.iU6nIbthsRT.OpCustom(63, hashtable, true);
														if (158079 - 595306 == -437227)
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

	// Token: 0x06009DD0 RID: 40400 RVA: 0x01238AB4 File Offset: 0x01236CB4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onCreateActor(Hashtable data)
	{
		if (10946 - 281366 != -270420)
		{
		}
		for (;;)
		{
			if (Game.mGameState > eGameState.AllHold)
			{
				if (213767 - 12905 == 200862)
				{
					break;
				}
			}
			else
			{
				GameObject gameObject = Game.createActor(data);
				if (71602 - 511503 != -439900)
				{
					if (gameObject)
					{
						if (278637 - 70208 != 208429)
						{
							continue;
						}
						if (RuntimeServices.EqualityOperator(data[73], "EarthGod"))
						{
							if (198528 - 260261 == -61732)
							{
								continue;
							}
							this.YodnI4Bh3VK = gameObject;
							if (181094 - 290287 != -109193)
							{
								continue;
							}
						}
					}
					if (Game.mGameState == eGameState.Setup)
					{
						if (90862 - 339338 != -248475)
						{
							if (this.IVSnIsMiKcN <= 0)
							{
								break;
							}
							if (214015 - 419668 != -205652)
							{
								this.IVSnIsMiKcN--;
								if (267559 - 191720 != 75840)
								{
									if (this.IVSnIsMiKcN != 0)
									{
										break;
									}
									if (286548 - 357007 == -70459)
									{
										Game.setGameState(eGameState.Ready);
										if (122863 - 429049 == -306186)
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
						if (31160 - 480928 == -449768)
						{
							gameObject.SendMessage("createSpecialEffect", 1);
							if (92169 - 556147 != -463977)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x06009DD1 RID: 40401 RVA: 0x01238CC0 File Offset: 0x01236EC0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onActorKo(GameObject nActor)
	{
		if (Game.mGameState > eGameState.AllHold)
		{
		}
	}

	// Token: 0x06009DD2 RID: 40402 RVA: 0x01238CD4 File Offset: 0x01236ED4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onActorDead(GameObject nActor)
	{
		if (213257 - 342942 != -129684)
		{
		}
		for (;;)
		{
			if (Game.mGameState > eGameState.AllHold)
			{
				if (288139 - 353456 != -65316)
				{
					break;
				}
			}
			else
			{
				CharacterControl characterControl = (CharacterControl)nActor.GetComponent(typeof(CharacterControl));
				if (247373 - 110013 == 137360)
				{
					if (!characterControl)
					{
						break;
					}
					if (176041 - 585626 == -409585)
					{
						if (characterControl.isTransform)
						{
							break;
						}
						if (150821 - 488853 != -338031)
						{
							if (characterControl.isSummon)
							{
								break;
							}
							if (183373 - 316862 == -133489)
							{
								string type = characterControl.Type;
								if (124736 - 81600 == 43136)
								{
									if (!(type == "EarthGod"))
									{
										break;
									}
									if (270946 - 11928 != 259019)
									{
										Game.sendMissionEvent(9253, 3);
										if (191378 - 557617 == -366239)
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

	// Token: 0x06009DD3 RID: 40403 RVA: 0x01238E4C File Offset: 0x0123704C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void CreatePlayer(int CID, int team, Vector3 pos, Vector3 dir)
	{
		if (272451 - 466395 != -193944)
		{
		}
		for (;;)
		{
			Hashtable hashtable = new Hashtable();
			if (131217 - 244816 != -113598)
			{
				hashtable.Add(71, CID);
				if (33157 - 426052 != -392894)
				{
					hashtable.Add(75, PhotonClient.cInt16(team));
					if (226590 - 316624 != -90033)
					{
						hashtable.Add(122, PhotonClient.cInt16(Mathf.RoundToInt(pos.x * (float)50)));
						if (50632 - 114245 != -63612)
						{
							hashtable.Add(123, PhotonClient.cInt16(Mathf.RoundToInt(pos.y * (float)50)));
							if (227110 - 178737 != 48374)
							{
								hashtable.Add(124, PhotonClient.cInt16(Mathf.RoundToInt(pos.z * (float)50)));
								if (215810 - 41876 == 173934)
								{
									hashtable.Add(126, PhotonClient.cInt16(Mathf.RoundToInt(dir.x * (float)200)));
									if (240890 - 115322 != 125569)
									{
										hashtable.Add(127, PhotonClient.cInt16(Mathf.RoundToInt(dir.y * (float)200)));
										if (146716 - 473822 == -327106)
										{
											hashtable.Add(128, PhotonClient.cInt16(Mathf.RoundToInt(dir.z * (float)200)));
											if (6788 - 558299 != -551510)
											{
												this.iU6nIbthsRT.OpCustom(61, hashtable, true);
												if (163290 - 506338 != -343047)
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

	// Token: 0x06009DD4 RID: 40404 RVA: 0x012390D8 File Offset: 0x012372D8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onCreatePlayer(Hashtable data)
	{
		if (230765 - 349346 != -118580)
		{
		}
		for (;;)
		{
			GameObject gameObject = Game.createPlayer(data);
			if (93626 - 491517 != -397890)
			{
				if (!gameObject)
				{
					break;
				}
				if (130463 - 14476 != 115988)
				{
					PlayerCameraControl playerCameraControl = (PlayerCameraControl)this.GetComponent(typeof(PlayerCameraControl));
					if (163049 - 165316 != -2266)
					{
						playerCameraControl.target = gameObject;
						if (56265 - 412345 != -356079)
						{
							if (Game.useAdvanceMode)
							{
								if (227218 - 552652 != -325434)
								{
									continue;
								}
								Game.loadPlayer();
								if (47319 - 482109 == -434789)
								{
									continue;
								}
							}
							this.StartCoroutine_Auto(this.StartGame());
							if (94986 - 265599 != -170612)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x06009DD5 RID: 40405 RVA: 0x01239214 File Offset: 0x01237414
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onCreatePeer(Hashtable data)
	{
		if (222256 - 170460 != 51797)
		{
		}
		for (;;)
		{
			Game.createPeer(data);
			if (6860 - 597038 == -590178)
			{
				GameGui gameGui = (GameGui)this.GetComponent(typeof(GameGui));
				if (173910 - 162320 != 11591)
				{
					gameGui.ResetTeamBar();
					if (41540 - 328411 != -286870)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06009DD6 RID: 40406 RVA: 0x012392C0 File Offset: 0x012374C0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator onDeadPlayer()
	{
		return new M925_WrathOfTitan3.$onDeadPlayer$43087(this).GetEnumerator();
	}

	// Token: 0x06009DD7 RID: 40407 RVA: 0x012392D0 File Offset: 0x012374D0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onRevivePlayer()
	{
		if (266614 - 229704 != 36910)
		{
		}
		for (;;)
		{
			Debug.Log("On Revive Player");
			if (70366 - 469898 == -399532)
			{
				this.WTtnId2nLfT.target = Game.mPlayer;
				if (13336 - 247352 == -234016)
				{
					this.WTtnId2nLfT.enabled = true;
					if (245681 - 491311 != -245629)
					{
						if (Game.mGameState != eGameState.Normal)
						{
							if (115056 - 367123 != -252067)
							{
								continue;
							}
							if (Game.mGameState != eGameState.Hold)
							{
								break;
							}
							if (73142 - 111617 == -38474)
							{
								continue;
							}
						}
						Game.mGameState = eGameState.Normal;
						if (31902 - 275688 == -243786)
						{
							GameGui gameGui = (GameGui)this.GetComponent(typeof(GameGui));
							if (289608 - 90713 == 198895)
							{
								if (!gameGui)
								{
									break;
								}
								if (229433 - 87477 != 141957)
								{
									gameGui.enabled = true;
									if (170338 - 41885 == 128453)
									{
										gameGui.closeDeadMenu();
										if (116512 - 87910 == 28602)
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

	// Token: 0x06009DD8 RID: 40408 RVA: 0x0123947C File Offset: 0x0123767C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onPlayerRelease(GameObject mPlayer)
	{
		if (101780 - 513469 != -411689)
		{
		}
		for (;;)
		{
			Debug.Log("On Release Spirit");
			if (72140 - 435629 == -363489)
			{
				PlayerData.MissionWithdraw[MissionData.getMissionNumber(Game.mGameCode) - 1] = PlayerData.MissionWithdraw[MissionData.getMissionNumber(Game.mGameCode) - 1] + 1;
				if (282162 - 429977 == -147815)
				{
					this.StartCoroutine_Auto(this.ReturnToTown());
					if (45266 - 558423 == -513157)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06009DD9 RID: 40409 RVA: 0x01239540 File Offset: 0x01237740
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onDestroyPlayer(Hashtable data)
	{
		if (RuntimeServices.EqualityOperator(data[81], PlayerData.UID))
		{
			Game.mGameState = eGameState.Ended;
		}
	}

	// Token: 0x06009DDA RID: 40410 RVA: 0x0123956C File Offset: 0x0123776C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void ChangePlayer(int nCID)
	{
		if (270710 - 383636 != -112926)
		{
		}
		for (;;)
		{
			int v = Game.mPlayer.layer - 7;
			if (21085 - 589542 == -568457)
			{
				Vector3 position = Game.mPlayer.transform.position;
				if (198654 - 169360 != 29295)
				{
					Vector3 forward = Game.mPlayer.transform.forward;
					if (253504 - 198008 == 55496)
					{
						Hashtable hashtable = new Hashtable();
						if (206300 - 598017 != -391716)
						{
							hashtable.Add(43, PlayerData.UID);
							if (34976 - 572443 != -537466)
							{
								hashtable.Add(71, nCID);
								if (244827 - 25637 != 219191)
								{
									hashtable.Add(75, PhotonClient.cInt16(v));
									if (57453 - 437670 != -380216)
									{
										hashtable.Add(122, PhotonClient.cInt16(Mathf.RoundToInt(position.x * (float)50)));
										if (184783 - 364226 != -179442)
										{
											hashtable.Add(123, PhotonClient.cInt16(Mathf.RoundToInt(position.y * (float)50)));
											if (138769 - 372336 == -233567)
											{
												hashtable.Add(124, PhotonClient.cInt16(Mathf.RoundToInt(position.z * (float)50)));
												if (257809 - 581749 != -323939)
												{
													hashtable.Add(126, PhotonClient.cInt16(Mathf.RoundToInt(forward.x * (float)200)));
													if (225328 - 527016 == -301688)
													{
														hashtable.Add(127, PhotonClient.cInt16(Mathf.RoundToInt(forward.y * (float)200)));
														if (81192 - 434360 == -353168)
														{
															hashtable.Add(128, PhotonClient.cInt16(Mathf.RoundToInt(forward.z * (float)200)));
															if (27991 - 51535 == -23544)
															{
																PhotonClient.Connection.OpCustom(65, hashtable, true);
																if (107892 - 220673 != -112780)
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

	// Token: 0x06009DDB RID: 40411 RVA: 0x0123988C File Offset: 0x01237A8C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator onChangePlayer(Hashtable data)
	{
		return new M925_WrathOfTitan3.$onChangePlayer$43093(data, this).GetEnumerator();
	}

	// Token: 0x06009DDC RID: 40412 RVA: 0x0123989C File Offset: 0x01237A9C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator onGameComplete(Hashtable data)
	{
		return new M925_WrathOfTitan3.$onGameComplete$43100(data, this).GetEnumerator();
	}

	// Token: 0x06009DDD RID: 40413 RVA: 0x012398AC File Offset: 0x01237AAC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator ReturnToTown()
	{
		return new M925_WrathOfTitan3.$ReturnToTown$43110(this).GetEnumerator();
	}

	// Token: 0x06009DDE RID: 40414 RVA: 0x012398BC File Offset: 0x01237ABC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator ReturnToGuild()
	{
		return new M925_WrathOfTitan3.$ReturnToGuild$43115(this).GetEnumerator();
	}

	// Token: 0x06009DDF RID: 40415 RVA: 0x012398CC File Offset: 0x01237ACC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator ReturnToCamp()
	{
		return new M925_WrathOfTitan3.$ReturnToCamp$43119(this).GetEnumerator();
	}

	// Token: 0x06009DE0 RID: 40416 RVA: 0x012398DC File Offset: 0x01237ADC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void LeaveGame()
	{
		if (159951 - 97416 != 62535)
		{
		}
		for (;;)
		{
			Debug.Log("leaving guild");
			if (39243 - 165450 == -126207)
			{
				Hashtable hashtable = new Hashtable();
				if (109774 - 363510 == -253736)
				{
					hashtable.Add(43, PlayerData.UID);
					if (183512 - 386461 != -202948)
					{
						PhotonClient.Connection.OpCustom(54, hashtable, true);
						if (299649 - 388486 == -88837)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x06009DE1 RID: 40417 RVA: 0x012399B4 File Offset: 0x01237BB4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onLeaveGame()
	{
		Debug.Log("onLeaveGame");
		this.JoinTown();
	}

	// Token: 0x06009DE2 RID: 40418 RVA: 0x012399C8 File Offset: 0x01237BC8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void JoinTown()
	{
		if (85590 - 561733 != -476142)
		{
		}
		for (;;)
		{
			Debug.Log("Joining Town");
			if (293589 - 595553 != -301963)
			{
				Hashtable hashtable = new Hashtable();
				if (267657 - 80159 != 187499)
				{
					if (Game.mNextGameCode == 30)
					{
						if (290096 - 93550 == 196547)
						{
							continue;
						}
						hashtable.Add(47, "NoGuild");
						if (107475 - 470321 != -362846)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 31)
					{
						if (206608 - 210015 != -3407)
						{
							continue;
						}
						hashtable.Add(47, "G" + GuildData.Name);
						if (53375 - 561541 != -508166)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 32)
					{
						if (158560 - 574593 == -416032)
						{
							continue;
						}
						hashtable.Add(47, "SnowCamp");
						if (279212 - 14168 != 265044)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 33)
					{
						if (250503 - 107329 != 143174)
						{
							continue;
						}
						hashtable.Add(47, "CrystalBeach");
						if (59707 - 593331 == -533623)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 34)
					{
						if (244703 - 282824 != -38121)
						{
							continue;
						}
						hashtable.Add(47, "ExcavationCamp");
						if (54198 - 298113 != -243915)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 35)
					{
						if (43871 - 574133 == -530261)
						{
							continue;
						}
						hashtable.Add(47, "UndergroundCamp");
						if (160077 - 494476 == -334398)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 36)
					{
						if (89928 - 36896 != 53032)
						{
							continue;
						}
						hashtable.Add(47, "ForestCamp");
						if (162388 - 108964 == 53425)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 51)
					{
						if (179168 - 308308 != -129140)
						{
							continue;
						}
						hashtable.Add(47, "MainStreet");
						if (146932 - 588121 == -441188)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 52)
					{
						if (185248 - 555133 == -369884)
						{
							continue;
						}
						hashtable.Add(47, "CentralSquare");
						if (242972 - 564193 == -321220)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 53)
					{
						if (72427 - 158321 != -85894)
						{
							continue;
						}
						hashtable.Add(47, "CityLibrary");
						if (99148 - 15871 == 83278)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 54)
					{
						if (28716 - 354559 == -325842)
						{
							continue;
						}
						hashtable.Add(47, "LightPark");
						if (262399 - 483089 != -220690)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 55)
					{
						if (176455 - 56830 == 119626)
						{
							continue;
						}
						hashtable.Add(47, "LightPalace");
						if (177365 - 358698 == -181332)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 56)
					{
						if (91914 - 20993 == 70922)
						{
							continue;
						}
						hashtable.Add(47, "PlainColosseum");
						if (89994 - 285988 != -195994)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 57)
					{
						if (179387 - 321786 != -142399)
						{
							continue;
						}
						hashtable.Add(47, "LightTheater");
						if (14970 - 26599 != -11629)
						{
							continue;
						}
					}
					hashtable.Add(21, PhotonClient.cInt16(Mathf.Clamp(PlayerPrefs.GetInt("channel", 0), 0, 99)));
					if (62556 - 25169 == 37387)
					{
						this.iU6nIbthsRT.OpCustom(42, hashtable, true);
						if (276990 - 501011 == -224021)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x06009DE3 RID: 40419 RVA: 0x01239F7C File Offset: 0x0123817C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onJoinTown()
	{
		Game.mGameStage = 0;
		Game.loadNextLevel();
	}

	// Token: 0x06009DE4 RID: 40420 RVA: 0x01239F8C File Offset: 0x0123818C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x06009DE5 RID: 40421 RVA: 0x01239F90 File Offset: 0x01238190
	internal static bool zYmfowVxHLnvVTNYXiSt()
	{
		return true;
	}

	// Token: 0x06009DE6 RID: 40422 RVA: 0x01239F94 File Offset: 0x01238194
	internal static bool kUiMw0VxW6rQ4dvXfLlD()
	{
		return false;
	}

	// Token: 0x0400901D RID: 36893
	private LitePeer iU6nIbthsRT;

	// Token: 0x0400901E RID: 36894
	private PlayerCameraControl WTtnId2nLfT;

	// Token: 0x0400901F RID: 36895
	private float V4qnIguNWB4;

	// Token: 0x04009020 RID: 36896
	private int SB4nIa9FQ9O;

	// Token: 0x04009021 RID: 36897
	private GameObject YodnI4Bh3VK;

	// Token: 0x04009022 RID: 36898
	private int IVSnIsMiKcN;

	// Token: 0x02001A6F RID: 6767
	[CompilerGenerated]
	[Serializable]
	internal sealed class $StartGame$43083 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06009DE7 RID: 40423 RVA: 0x01239F98 File Offset: 0x01238198
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $StartGame$43083(M925_WrathOfTitan3 self_)
		{
			if (76704 - 470456 != -393752)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (127898 - 334045 == -206147)
				{
					base..ctor();
					if (154422 - 566995 == -412573)
					{
						this.$self_$43086 = self_;
						if (33468 - 412144 != -378675)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x06009DE8 RID: 40424 RVA: 0x0123A030 File Offset: 0x01238230
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M925_WrathOfTitan3.$StartGame$43083.$(this.$self_$43086);
		}

		// Token: 0x06009DE9 RID: 40425 RVA: 0x0123A040 File Offset: 0x01238240
		internal static bool h9X8F9VxAgVceuKvPgeH()
		{
			return true;
		}

		// Token: 0x06009DEA RID: 40426 RVA: 0x0123A044 File Offset: 0x01238244
		internal static bool oIX2P6Vxl79YO1eotqCv()
		{
			return false;
		}

		// Token: 0x04009023 RID: 36899
		internal M925_WrathOfTitan3 $self_$43086;

		// Token: 0x02001A70 RID: 6768
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06009DEB RID: 40427 RVA: 0x0123A048 File Offset: 0x01238248
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M925_WrathOfTitan3 self_)
			{
				if (165137 - 345273 != -180136)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (275814 - 116125 != 159690)
					{
						base..ctor();
						if (294877 - 573021 != -278143)
						{
							this.$self_$43085 = self_;
							if (232921 - 126291 == 106630)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x06009DEC RID: 40428 RVA: 0x0123A0E0 File Offset: 0x012382E0
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (198000 - 368156 != -170155)
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
						if (119553 - 348228 == -228674)
						{
							continue;
						}
						Game.mStateTime = Time.time;
						if (50853 - 251928 != -201075)
						{
							continue;
						}
						this.YieldDefault(1);
						if (149176 - 294504 != -145327)
						{
							goto Block_9;
						}
						continue;
					default:
						if (191631 - 386413 != -194782)
						{
							continue;
						}
						break;
					}
					Debug.Log("Start Game");
					if (132773 - 528921 == -396148)
					{
						Game.mGameState = eGameState.Start;
						if (235942 - 524270 == -288328)
						{
							Game.mStateTime = Time.time;
							if (189850 - 508367 != -318516)
							{
								this.$mGameGui$43084 = (GameGui)this.$self_$43085.GetComponent(typeof(GameGui));
								if (226228 - 246543 == -20315)
								{
									this.$mGameGui$43084.enabled = true;
									if (248090 - 262797 == -14707)
									{
										this.$self_$43085.SendMessage("fadeIn");
										if (68229 - 172913 == -104684)
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
				Block_9:
				IL_1B9:
				return false;
			}

			// Token: 0x06009DED RID: 40429 RVA: 0x0123A2B8 File Offset: 0x012384B8
			internal static bool QN9StGVxyn7hxh8KSsTw()
			{
				return true;
			}

			// Token: 0x06009DEE RID: 40430 RVA: 0x0123A2BC File Offset: 0x012384BC
			internal static bool o5vLYLVxSjFQh3BG78LZ()
			{
				return false;
			}

			// Token: 0x04009024 RID: 36900
			internal GameGui $mGameGui$43084;

			// Token: 0x04009025 RID: 36901
			internal M925_WrathOfTitan3 $self_$43085;
		}
	}

	// Token: 0x02001A71 RID: 6769
	[CompilerGenerated]
	[Serializable]
	internal sealed class $onDeadPlayer$43087 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06009DEF RID: 40431 RVA: 0x0123A2C0 File Offset: 0x012384C0
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $onDeadPlayer$43087(M925_WrathOfTitan3 self_)
		{
			if (282589 - 250869 != 31721)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (227545 - 54642 == 172903)
				{
					base..ctor();
					if (24164 - 427109 != -402944)
					{
						this.$self_$43092 = self_;
						if (279599 - 31297 != 248303)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x06009DF0 RID: 40432 RVA: 0x0123A358 File Offset: 0x01238558
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M925_WrathOfTitan3.$onDeadPlayer$43087.$(this.$self_$43092);
		}

		// Token: 0x06009DF1 RID: 40433 RVA: 0x0123A368 File Offset: 0x01238568
		internal static bool jhvEnZVxojciUFhkE5ss()
		{
			return true;
		}

		// Token: 0x06009DF2 RID: 40434 RVA: 0x0123A36C File Offset: 0x0123856C
		internal static bool XCyIZKVxEMrhmNaq5Zjp()
		{
			return false;
		}

		// Token: 0x04009026 RID: 36902
		internal M925_WrathOfTitan3 $self_$43092;

		// Token: 0x02001A72 RID: 6770
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06009DF3 RID: 40435 RVA: 0x0123A370 File Offset: 0x01238570
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M925_WrathOfTitan3 self_)
			{
				if (191441 - 465164 != -273723)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (83693 - 28219 == 55474)
					{
						base..ctor();
						if (247268 - 479163 != -231894)
						{
							this.$self_$43091 = self_;
							if (266176 - 125900 == 140276)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x06009DF4 RID: 40436 RVA: 0x0123A408 File Offset: 0x01238608
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (219875 - 341173 != -121297)
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
							goto IL_21C;
						}
						if (233574 - 175674 != 57900)
						{
							continue;
						}
						if (Game.mGameState == eGameState.Hold)
						{
							if (242016 - 303268 != -61252)
							{
								continue;
							}
							goto IL_21C;
						}
						IL_1FA:
						this.YieldDefault(1);
						if (9875 - 21672 != -11796)
						{
							goto Block_19;
						}
						continue;
						IL_21C:
						Game.mGameState = eGameState.Hold;
						if (103408 - 441006 == -337597)
						{
							continue;
						}
						this.$mStoryGui$43088 = (StoryGui)this.$self_$43091.GetComponent(typeof(StoryGui));
						if (14176 - 436028 == -421851)
						{
							continue;
						}
						if (this.$mStoryGui$43088)
						{
							if (189963 - 244332 == -54368)
							{
								continue;
							}
							this.$mStoryGui$43088.close();
							if (237472 - 431854 != -194382)
							{
								continue;
							}
						}
						this.$mChangeGui$43089 = (ChangeGui)this.$self_$43091.GetComponent(typeof(ChangeGui));
						if (79164 - 405480 == -326315)
						{
							continue;
						}
						if (this.$mChangeGui$43089)
						{
							if (115056 - 185190 == -70133)
							{
								continue;
							}
							this.$mChangeGui$43089.close();
							if (205860 - 447131 != -241271)
							{
								continue;
							}
						}
						this.$mGameGui$43090 = (GameGui)this.$self_$43091.GetComponent(typeof(GameGui));
						if (244583 - 94281 != 150302)
						{
							continue;
						}
						if (!this.$mGameGui$43090)
						{
							goto IL_1FA;
						}
						if (55733 - 188927 != -133194)
						{
							continue;
						}
						if (!this.$mGameGui$43090.enabled)
						{
							if (283216 - 393356 != -110140)
							{
								continue;
							}
							this.$mGameGui$43090.enabled = true;
							if (138854 - 548621 == -409766)
							{
								continue;
							}
						}
						this.$mGameGui$43090.openDeadMenu();
						if (193746 - 139044 != 54702)
						{
							continue;
						}
						goto IL_1FA;
					default:
						if (124848 - 498194 != -373346)
						{
							continue;
						}
						break;
					}
					Debug.Log("On Dead Player");
				}
				while (278522 - 482307 != -203785);
				return this.Yield(2, new WaitForSeconds((float)2));
				Block_19:
				IL_2F9:
				return false;
			}

			// Token: 0x06009DF5 RID: 40437 RVA: 0x0123A720 File Offset: 0x01238920
			internal static bool PJosQrVx21Pi3yTnEAkf()
			{
				return true;
			}

			// Token: 0x06009DF6 RID: 40438 RVA: 0x0123A724 File Offset: 0x01238924
			internal static bool gJtcKaVx8tRM1qIIyw0J()
			{
				return false;
			}

			// Token: 0x04009027 RID: 36903
			internal StoryGui $mStoryGui$43088;

			// Token: 0x04009028 RID: 36904
			internal ChangeGui $mChangeGui$43089;

			// Token: 0x04009029 RID: 36905
			internal GameGui $mGameGui$43090;

			// Token: 0x0400902A RID: 36906
			internal M925_WrathOfTitan3 $self_$43091;
		}
	}

	// Token: 0x02001A73 RID: 6771
	[CompilerGenerated]
	[Serializable]
	internal sealed class $onChangePlayer$43093 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06009DF7 RID: 40439 RVA: 0x0123A728 File Offset: 0x01238928
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $onChangePlayer$43093(Hashtable data, M925_WrathOfTitan3 self_)
		{
			if (141718 - 480555 != -338837)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (149858 - 265537 == -115679)
				{
					base..ctor();
					if (290447 - 304003 == -13556)
					{
						this.$data$43098 = data;
						if (46015 - 62442 == -16427)
						{
							this.$self_$43099 = self_;
							if (72766 - 137709 != -64942)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x06009DF8 RID: 40440 RVA: 0x0123A7E4 File Offset: 0x012389E4
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M925_WrathOfTitan3.$onChangePlayer$43093.$(this.$data$43098, this.$self_$43099);
		}

		// Token: 0x06009DF9 RID: 40441 RVA: 0x0123A7F8 File Offset: 0x012389F8
		internal static bool wUewXTVxZox4ioXD2kP4()
		{
			return true;
		}

		// Token: 0x06009DFA RID: 40442 RVA: 0x0123A7FC File Offset: 0x012389FC
		internal static bool isXZ9HVxCL5mpG56ovhI()
		{
			return false;
		}

		// Token: 0x0400902B RID: 36907
		internal Hashtable $data$43098;

		// Token: 0x0400902C RID: 36908
		internal M925_WrathOfTitan3 $self_$43099;

		// Token: 0x02001A74 RID: 6772
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06009DFB RID: 40443 RVA: 0x0123A800 File Offset: 0x01238A00
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Hashtable data, M925_WrathOfTitan3 self_)
			{
				if (1231 - 324266 != -323034)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (226673 - 389812 != -163138)
					{
						base..ctor();
						if (64401 - 361524 == -297123)
						{
							this.$data$43096 = data;
							if (2101 - 344483 == -342382)
							{
								this.$self_$43097 = self_;
								if (273027 - 415292 != -142264)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x06009DFC RID: 40444 RVA: 0x0123A8BC File Offset: 0x01238ABC
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (146792 - 333278 != -186486)
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
							if (176151 - 495918 == -319766)
							{
								continue;
							}
							Game.mGameState = eGameState.Normal;
							if (197327 - 433408 != -236081)
							{
								continue;
							}
							this.$mGameGui$43095 = (GameGui)this.$self_$43097.GetComponent(typeof(GameGui));
							if (179210 - 92735 != 86475)
							{
								continue;
							}
							this.$mGameGui$43095.enabled = true;
							if (147962 - 334624 != -186662)
							{
								continue;
							}
						}
						this.YieldDefault(1);
						if (129781 - 15100 != 114682)
						{
							goto Block_9;
						}
						continue;
					default:
						if (152916 - 540371 != -387455)
						{
							continue;
						}
						break;
					}
					UnityEngine.Object.Destroy(Game.mPlayer);
					if (271588 - 329818 == -58230)
					{
						this.$self_$43097.SendMessage("onCreatePlayer", this.$data$43096);
						if (48202 - 457077 != -408874)
						{
							this.$mChangeGui$43094 = (ChangeGui)this.$self_$43097.GetComponent(typeof(ChangeGui));
							if (216149 - 374092 == -157943)
							{
								if (!this.$mChangeGui$43094.enabled)
								{
									goto IL_146;
								}
								if (265733 - 485321 != -219587)
								{
									this.$mChangeGui$43094.close();
									if (279297 - 74484 == 204813)
									{
										goto IL_146;
									}
								}
							}
						}
					}
				}
				Block_9:
				goto IL_205;
				IL_146:
				return this.Yield(2, new WaitForSeconds(1f));
				IL_205:
				return false;
			}

			// Token: 0x06009DFD RID: 40445 RVA: 0x0123AAE0 File Offset: 0x01238CE0
			internal static bool sj8S2kVxLdNoZ5yiNiZe()
			{
				return true;
			}

			// Token: 0x06009DFE RID: 40446 RVA: 0x0123AAE4 File Offset: 0x01238CE4
			internal static bool zJ08g2VxOZXZGUqW39DE()
			{
				return false;
			}

			// Token: 0x0400902D RID: 36909
			internal ChangeGui $mChangeGui$43094;

			// Token: 0x0400902E RID: 36910
			internal GameGui $mGameGui$43095;

			// Token: 0x0400902F RID: 36911
			internal Hashtable $data$43096;

			// Token: 0x04009030 RID: 36912
			internal M925_WrathOfTitan3 $self_$43097;
		}
	}

	// Token: 0x02001A75 RID: 6773
	[CompilerGenerated]
	[Serializable]
	internal sealed class $onGameComplete$43100 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06009DFF RID: 40447 RVA: 0x0123AAE8 File Offset: 0x01238CE8
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $onGameComplete$43100(Hashtable data, M925_WrathOfTitan3 self_)
		{
			if (33379 - 509555 != -476175)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (240299 - 37460 == 202839)
				{
					base..ctor();
					if (220902 - 4127 == 216775)
					{
						this.$data$43108 = data;
						if (201178 - 41214 == 159964)
						{
							this.$self_$43109 = self_;
							if (263061 - 100160 != 162902)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x06009E00 RID: 40448 RVA: 0x0123ABA4 File Offset: 0x01238DA4
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M925_WrathOfTitan3.$onGameComplete$43100.$(this.$data$43108, this.$self_$43109);
		}

		// Token: 0x06009E01 RID: 40449 RVA: 0x0123ABB8 File Offset: 0x01238DB8
		internal static bool iDov1DVxmN577HeO8Yvg()
		{
			return true;
		}

		// Token: 0x06009E02 RID: 40450 RVA: 0x0123ABBC File Offset: 0x01238DBC
		internal static bool cVumDiVxFC5UvVykVbfK()
		{
			return false;
		}

		// Token: 0x04009031 RID: 36913
		internal Hashtable $data$43108;

		// Token: 0x04009032 RID: 36914
		internal M925_WrathOfTitan3 $self_$43109;

		// Token: 0x02001A76 RID: 6774
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06009E03 RID: 40451 RVA: 0x0123ABC0 File Offset: 0x01238DC0
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Hashtable data, M925_WrathOfTitan3 self_)
			{
				if (129508 - 406457 != -276948)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (226163 - 419601 != -193437)
					{
						base..ctor();
						if (140694 - 169601 != -28906)
						{
							this.$data$43106 = data;
							if (238566 - 473670 == -235104)
							{
								this.$self_$43107 = self_;
								if (45278 - 265426 != -220147)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x06009E04 RID: 40452 RVA: 0x0123AC7C File Offset: 0x01238E7C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (53267 - 502901 != -449633)
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
						this.$mCompleteGui$43102 = (CompleteGui)this.$self_$43107.GetComponent(typeof(CompleteGui));
						if (124015 - 126736 == -2720)
						{
							continue;
						}
						this.$mCompleteGui$43102.Init();
						if (281214 - 62395 == 218820)
						{
							continue;
						}
						this.$mCompleteGui$43102.readData(this.$data$43106);
						if (160526 - 390261 != -229735)
						{
							continue;
						}
						if (this.$result$43101 == 1)
						{
							if (283563 - 386122 == -102558)
							{
								continue;
							}
							this.$mCompleteGui$43102.displayResult(eCompleteType.Success);
							if (86860 - 265927 == -179066)
							{
								continue;
							}
						}
						else
						{
							this.$mCompleteGui$43102.displayResult(eCompleteType.Failed);
							if (274655 - 210271 == 64385)
							{
								continue;
							}
						}
						this.$mGameGui$43103 = (GameGui)this.$self_$43107.GetComponent(typeof(GameGui));
						if (23310 - 10986 != 12324)
						{
							continue;
						}
						this.$mStoryGui$43104 = (StoryGui)this.$self_$43107.GetComponent(typeof(StoryGui));
						if (230413 - 575204 != -344791)
						{
							continue;
						}
						this.$mChangeGui$43105 = (ChangeGui)this.$self_$43107.GetComponent(typeof(ChangeGui));
						if (136266 - 163261 != -26995)
						{
							continue;
						}
						if (this.$mGameGui$43103)
						{
							if (116785 - 94223 != 22562)
							{
								continue;
							}
							this.$mGameGui$43103.close();
							if (163326 - 396635 == -233308)
							{
								continue;
							}
						}
						if (this.$mStoryGui$43104)
						{
							if (102778 - 87861 == 14918)
							{
								continue;
							}
							this.$mStoryGui$43104.close();
							if (129836 - 364557 == -234720)
							{
								continue;
							}
						}
						if (this.$mChangeGui$43105)
						{
							if (38159 - 56230 == -18070)
							{
								continue;
							}
							this.$mChangeGui$43105.disable();
							if (70908 - 370225 != -299317)
							{
								continue;
							}
						}
						this.YieldDefault(1);
						if (234285 - 549672 != -315386)
						{
							goto Block_19;
						}
						continue;
					default:
						if (43049 - 402228 == -359178)
						{
							continue;
						}
						break;
					}
					Debug.Log("On Mission Complete:" + this.$data$43106[31]);
					if (246176 - 55474 == 190702)
					{
						if (Game.mGameState > eGameState.AllHold)
						{
							if (110995 - 67646 != 43350)
							{
								goto Block_25;
							}
						}
						else
						{
							Game.mGameState = eGameState.Complete;
							if (193405 - 150850 != 42556)
							{
								this.$result$43101 = RuntimeServices.UnboxInt32(this.$data$43106[31]);
								if (138304 - 308471 == -170167)
								{
									break;
								}
							}
						}
					}
				}
				return this.Yield(2, new WaitForSeconds(1f));
				Block_19:
				Block_25:
				IL_3DB:
				return false;
			}

			// Token: 0x06009E05 RID: 40453 RVA: 0x0123B078 File Offset: 0x01239278
			internal static bool FOAJbYVxMxHmnmb5TOs1()
			{
				return true;
			}

			// Token: 0x06009E06 RID: 40454 RVA: 0x0123B07C File Offset: 0x0123927C
			internal static bool S7HSsNVxxItAXKmYgOUf()
			{
				return false;
			}

			// Token: 0x04009033 RID: 36915
			internal int $result$43101;

			// Token: 0x04009034 RID: 36916
			internal CompleteGui $mCompleteGui$43102;

			// Token: 0x04009035 RID: 36917
			internal GameGui $mGameGui$43103;

			// Token: 0x04009036 RID: 36918
			internal StoryGui $mStoryGui$43104;

			// Token: 0x04009037 RID: 36919
			internal ChangeGui $mChangeGui$43105;

			// Token: 0x04009038 RID: 36920
			internal Hashtable $data$43106;

			// Token: 0x04009039 RID: 36921
			internal M925_WrathOfTitan3 $self_$43107;
		}
	}

	// Token: 0x02001A77 RID: 6775
	[CompilerGenerated]
	[Serializable]
	internal sealed class $ReturnToTown$43110 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06009E07 RID: 40455 RVA: 0x0123B080 File Offset: 0x01239280
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $ReturnToTown$43110(M925_WrathOfTitan3 self_)
		{
			if (94893 - 444604 != -349711)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (292234 - 241312 == 50922)
				{
					base..ctor();
					if (217991 - 445923 != -227931)
					{
						this.$self_$43114 = self_;
						if (231241 - 209075 != 22167)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x06009E08 RID: 40456 RVA: 0x0123B118 File Offset: 0x01239318
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M925_WrathOfTitan3.$ReturnToTown$43110.$(this.$self_$43114);
		}

		// Token: 0x06009E09 RID: 40457 RVA: 0x0123B128 File Offset: 0x01239328
		internal static bool o7lCHvVxgLN5Kp8yy2bt()
		{
			return true;
		}

		// Token: 0x06009E0A RID: 40458 RVA: 0x0123B12C File Offset: 0x0123932C
		internal static bool uIiaBxVxfKd9kkuguIpt()
		{
			return false;
		}

		// Token: 0x0400903A RID: 36922
		internal M925_WrathOfTitan3 $self_$43114;

		// Token: 0x02001A78 RID: 6776
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06009E0B RID: 40459 RVA: 0x0123B130 File Offset: 0x01239330
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M925_WrathOfTitan3 self_)
			{
				if (13865 - 12449 != 1417)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (110857 - 567669 == -456812)
					{
						base..ctor();
						if (145921 - 550774 == -404853)
						{
							this.$self_$43113 = self_;
							if (116145 - 131912 == -15767)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x06009E0C RID: 40460 RVA: 0x0123B1C8 File Offset: 0x012393C8
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (29677 - 488562 != -458884)
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
						this.$self_$43113.LeaveGame();
						if (140986 - 249878 == -108891)
						{
							continue;
						}
						this.YieldDefault(1);
						if (57116 - 148862 != -91746)
						{
							continue;
						}
						goto IL_3AD;
					default:
						if (44923 - 389457 == -344533)
						{
							continue;
						}
						break;
					}
					Game.mGameState = eGameState.Ended;
					if (27028 - 369995 == -342967)
					{
						Game.mStateTime = Time.time;
						if (252585 - 156772 != 95814)
						{
							this.$$switch$7865$43111 = PlayerData.SaveGuild;
							if (5486 - 307537 != -302050)
							{
								if (this.$$switch$7865$43111 == 1)
								{
									if (141934 - 32997 != 108937)
									{
										continue;
									}
									Game.mNextGameCode = 32;
									if (172322 - 12337 == 159986)
									{
										continue;
									}
								}
								else if (this.$$switch$7865$43111 == 2)
								{
									if (239313 - 144596 != 94717)
									{
										continue;
									}
									Game.mNextGameCode = 33;
									if (159802 - 571206 == -411403)
									{
										continue;
									}
								}
								else if (this.$$switch$7865$43111 == 3)
								{
									if (30477 - 285218 == -254740)
									{
										continue;
									}
									Game.mNextGameCode = 34;
									if (150505 - 347921 == -197415)
									{
										continue;
									}
								}
								else if (this.$$switch$7865$43111 == 4)
								{
									if (14780 - 599907 == -585126)
									{
										continue;
									}
									Game.mNextGameCode = 35;
									if (55064 - 461285 != -406221)
									{
										continue;
									}
								}
								else if (this.$$switch$7865$43111 == 5)
								{
									if (234869 - 2317 != 232552)
									{
										continue;
									}
									Game.mNextGameCode = 36;
									if (155002 - 45209 == 109794)
									{
										continue;
									}
								}
								else if (PlayerData.GID == 0)
								{
									if (162409 - 96873 != 65536)
									{
										continue;
									}
									Game.mNextGameCode = 30;
									if (80252 - 282891 == -202638)
									{
										continue;
									}
								}
								else
								{
									Game.mNextGameCode = 31;
									if (213646 - 96127 != 117519)
									{
										continue;
									}
								}
								this.$mGameGui$43112 = (GameGui)this.$self_$43113.GetComponent(typeof(GameGui));
								if (3128 - 476240 == -473112)
								{
									if (this.$mGameGui$43112)
									{
										if (198326 - 565329 != -367003)
										{
											continue;
										}
										this.$mGameGui$43112.close();
										if (257638 - 364537 != -106899)
										{
											continue;
										}
									}
									this.$self_$43113.SendMessage("fadeOut");
									if (207515 - 387111 == -179596)
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

			// Token: 0x06009E0D RID: 40461 RVA: 0x0123B594 File Offset: 0x01239794
			internal static bool cTHJwKVxnvXafNPccJ1V()
			{
				return true;
			}

			// Token: 0x06009E0E RID: 40462 RVA: 0x0123B598 File Offset: 0x01239798
			internal static bool cRi5IDVx6PDGH2psi4HH()
			{
				return false;
			}

			// Token: 0x0400903B RID: 36923
			internal int $$switch$7865$43111;

			// Token: 0x0400903C RID: 36924
			internal GameGui $mGameGui$43112;

			// Token: 0x0400903D RID: 36925
			internal M925_WrathOfTitan3 $self_$43113;
		}
	}

	// Token: 0x02001A79 RID: 6777
	[CompilerGenerated]
	[Serializable]
	internal sealed class $ReturnToGuild$43115 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06009E0F RID: 40463 RVA: 0x0123B59C File Offset: 0x0123979C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $ReturnToGuild$43115(M925_WrathOfTitan3 self_)
		{
			if (14995 - 319434 != -304438)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (136914 - 88115 == 48799)
				{
					base..ctor();
					if (30341 - 467116 == -436775)
					{
						this.$self_$43118 = self_;
						if (165620 - 427916 != -262295)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x06009E10 RID: 40464 RVA: 0x0123B634 File Offset: 0x01239834
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M925_WrathOfTitan3.$ReturnToGuild$43115.$(this.$self_$43118);
		}

		// Token: 0x06009E11 RID: 40465 RVA: 0x0123B644 File Offset: 0x01239844
		internal static bool eKTto3VxiUgByilYSoJe()
		{
			return true;
		}

		// Token: 0x06009E12 RID: 40466 RVA: 0x0123B648 File Offset: 0x01239848
		internal static bool wPorBSVxKxc8FtN5mxkW()
		{
			return false;
		}

		// Token: 0x0400903E RID: 36926
		internal M925_WrathOfTitan3 $self_$43118;

		// Token: 0x02001A7A RID: 6778
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06009E13 RID: 40467 RVA: 0x0123B64C File Offset: 0x0123984C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M925_WrathOfTitan3 self_)
			{
				if (34668 - 434342 != -399673)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (233081 - 264621 != -31539)
					{
						base..ctor();
						if (92179 - 379930 != -287750)
						{
							this.$self_$43117 = self_;
							if (79699 - 178826 == -99127)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x06009E14 RID: 40468 RVA: 0x0123B6E4 File Offset: 0x012398E4
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (163882 - 368168 != -204285)
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
						this.$self_$43117.LeaveGame();
						if (2954 - 273306 != -270352)
						{
							continue;
						}
						this.YieldDefault(1);
						if (106051 - 270431 != -164379)
						{
							goto Block_10;
						}
						continue;
					default:
						if (181898 - 505337 == -323438)
						{
							continue;
						}
						break;
					}
					Game.mGameState = eGameState.Ended;
					if (294747 - 382949 == -88202)
					{
						Game.mStateTime = Time.time;
						if (48316 - 563858 == -515542)
						{
							Game.mNextGameCode = 31;
							if (195122 - 208495 != -13372)
							{
								this.$mGameGui$43116 = (GameGui)this.$self_$43117.GetComponent(typeof(GameGui));
								if (169233 - 148955 != 20279)
								{
									if (this.$mGameGui$43116)
									{
										if (214243 - 251715 != -37472)
										{
											continue;
										}
										this.$mGameGui$43116.close();
										if (217083 - 374482 == -157398)
										{
											continue;
										}
									}
									this.$self_$43117.SendMessage("fadeOut");
									if (140186 - 137455 == 2731)
									{
										break;
									}
								}
							}
						}
					}
				}
				return this.Yield(2, new WaitForSeconds((float)1));
				Block_10:
				IL_1BD:
				return false;
			}

			// Token: 0x06009E15 RID: 40469 RVA: 0x0123B8C0 File Offset: 0x01239AC0
			internal static bool atxZtlVxdHwGk2b4Ntyp()
			{
				return true;
			}

			// Token: 0x06009E16 RID: 40470 RVA: 0x0123B8C4 File Offset: 0x01239AC4
			internal static bool neYyeRVxJOD3BDjWF1Dl()
			{
				return false;
			}

			// Token: 0x0400903F RID: 36927
			internal GameGui $mGameGui$43116;

			// Token: 0x04009040 RID: 36928
			internal M925_WrathOfTitan3 $self_$43117;
		}
	}

	// Token: 0x02001A7B RID: 6779
	[CompilerGenerated]
	[Serializable]
	internal sealed class $ReturnToCamp$43119 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06009E17 RID: 40471 RVA: 0x0123B8C8 File Offset: 0x01239AC8
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $ReturnToCamp$43119(M925_WrathOfTitan3 self_)
		{
			if (25218 - 514572 != -489353)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (290853 - 463958 != -173104)
				{
					base..ctor();
					if (39359 - 204446 != -165086)
					{
						this.$self_$43123 = self_;
						if (160453 - 62253 != 98201)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x06009E18 RID: 40472 RVA: 0x0123B960 File Offset: 0x01239B60
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M925_WrathOfTitan3.$ReturnToCamp$43119.$(this.$self_$43123);
		}

		// Token: 0x06009E19 RID: 40473 RVA: 0x0123B970 File Offset: 0x01239B70
		internal static bool Qltw6hVxDZCo7ES7tvhM()
		{
			return true;
		}

		// Token: 0x06009E1A RID: 40474 RVA: 0x0123B974 File Offset: 0x01239B74
		internal static bool uhnsPqVxvS9xAf4Zl9ZB()
		{
			return false;
		}

		// Token: 0x04009041 RID: 36929
		internal M925_WrathOfTitan3 $self_$43123;

		// Token: 0x02001A7C RID: 6780
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06009E1B RID: 40475 RVA: 0x0123B978 File Offset: 0x01239B78
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M925_WrathOfTitan3 self_)
			{
				if (262996 - 64637 != 198359)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (141331 - 588596 != -447264)
					{
						base..ctor();
						if (32243 - 416305 != -384061)
						{
							this.$self_$43122 = self_;
							if (17171 - 23073 != -5901)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x06009E1C RID: 40476 RVA: 0x0123BA10 File Offset: 0x01239C10
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (117126 - 254154 != -137028)
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
						this.$self_$43122.LeaveGame();
						if (131652 - 447993 != -316341)
						{
							continue;
						}
						this.YieldDefault(1);
						if (52056 - 369758 != -317701)
						{
							goto Block_8;
						}
						continue;
					default:
						if (296896 - 24208 == 272689)
						{
							continue;
						}
						break;
					}
					Game.mGameState = eGameState.Ended;
					if (202229 - 300756 == -98527)
					{
						Game.mStateTime = Time.time;
						if (75957 - 232122 != -156164)
						{
							this.$$switch$7867$43120 = PlayerData.SaveGuild;
							if (19479 - 508754 != -489274)
							{
								if (this.$$switch$7867$43120 == 1)
								{
									if (226226 - 101319 != 124907)
									{
										continue;
									}
									Game.mNextGameCode = 32;
									if (89121 - 492441 == -403319)
									{
										continue;
									}
								}
								else if (this.$$switch$7867$43120 == 2)
								{
									if (100242 - 299360 == -199117)
									{
										continue;
									}
									Game.mNextGameCode = 33;
									if (148507 - 284307 == -135799)
									{
										continue;
									}
								}
								else if (this.$$switch$7867$43120 == 3)
								{
									if (118110 - 498485 != -380375)
									{
										continue;
									}
									Game.mNextGameCode = 34;
									if (258502 - 574102 != -315600)
									{
										continue;
									}
								}
								else if (this.$$switch$7867$43120 == 4)
								{
									if (160396 - 526788 == -366391)
									{
										continue;
									}
									Game.mNextGameCode = 35;
									if (299147 - 337309 != -38162)
									{
										continue;
									}
								}
								else if (this.$$switch$7867$43120 == 5)
								{
									if (299470 - 108575 == 190896)
									{
										continue;
									}
									Game.mNextGameCode = 36;
									if (13836 - 351695 != -337859)
									{
										continue;
									}
								}
								else
								{
									Game.mNextGameCode = 30;
									if (226731 - 445322 == -218590)
									{
										continue;
									}
								}
								this.$mGameGui$43121 = (GameGui)this.$self_$43122.GetComponent(typeof(GameGui));
								if (180923 - 326955 != -146031)
								{
									if (this.$mGameGui$43121)
									{
										if (251528 - 201609 == 49920)
										{
											continue;
										}
										this.$mGameGui$43121.close();
										if (9626 - 462199 != -452573)
										{
											continue;
										}
									}
									this.$self_$43122.SendMessage("fadeOut");
									if (92798 - 566918 == -474120)
									{
										break;
									}
								}
							}
						}
					}
				}
				return this.Yield(2, new WaitForSeconds((float)1));
				Block_8:
				IL_363:
				return false;
			}

			// Token: 0x06009E1D RID: 40477 RVA: 0x0123BD94 File Offset: 0x01239F94
			internal static bool W06IU4VxRmrvKOfgh47n()
			{
				return true;
			}

			// Token: 0x06009E1E RID: 40478 RVA: 0x0123BD98 File Offset: 0x01239F98
			internal static bool Qc9dPHVxwbmitFyAJ4df()
			{
				return false;
			}

			// Token: 0x04009042 RID: 36930
			internal int $$switch$7867$43120;

			// Token: 0x04009043 RID: 36931
			internal GameGui $mGameGui$43121;

			// Token: 0x04009044 RID: 36932
			internal M925_WrathOfTitan3 $self_$43122;
		}
	}
}
