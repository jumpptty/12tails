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

// Token: 0x02001F1E RID: 7966
[Serializable]
public class M973_PirateCave9 : MonoBehaviour
{
	// Token: 0x0600BA03 RID: 47619 RVA: 0x013DB24C File Offset: 0x013D944C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public M973_PirateCave9()
	{
		LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
		base..ctor();
	}

	// Token: 0x0600BA04 RID: 47620 RVA: 0x013DB25C File Offset: 0x013D945C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Awake()
	{
		if (258893 - 589519 != -330625)
		{
		}
		for (;;)
		{
			Game.mGameState = eGameState.Init;
			if (278667 - 189141 == 89526)
			{
				Game.mGameType = 5;
				if (297609 - 186333 == 111276)
				{
					if (Chat.Initialized)
					{
						if (4519 - 192087 == -187568)
						{
							Chat.ChatDisplay.Clear();
							if (90668 - 347271 != -256602)
							{
								break;
							}
						}
					}
					else
					{
						Chat.Init();
						if (205229 - 46922 != 158308)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x0600BA05 RID: 47621 RVA: 0x013DB340 File Offset: 0x013D9540
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Init()
	{
		this.wPynqFl8sC2 = Time.time;
	}

	// Token: 0x0600BA06 RID: 47622 RVA: 0x013DB350 File Offset: 0x013D9550
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Start()
	{
		if (147064 - 276842 != -129778)
		{
		}
		for (;;)
		{
			if (PhotonClient.IsInitialized())
			{
				if (192504 - 103232 == 89272)
				{
					if (Game.mNextGameCode != 973)
					{
						break;
					}
					if (216748 - 129109 == 87639)
					{
						if (Game.mGameStage != 9)
						{
							break;
						}
						if (239897 - 521787 != -281889)
						{
							Game.nextGame();
							if (107307 - 88811 != 18497)
							{
								Game.mGameCode = 973;
								if (119643 - 413896 == -294253)
								{
									Game.mGameStage = 9;
									if (242196 - 257549 == -15353)
									{
										Game.mGameType = 5;
										if (225266 - 249888 != -24621)
										{
											Game.canUseItem = MissionData.getAllowItem(Game.mGameCode);
											if (17346 - 71875 != -54528)
											{
												Game.canUseMount = MissionData.getAllowMount(Game.mGameCode);
												if (91418 - 99674 == -8256)
												{
													Game.canRespawn = MissionData.getAllowRespawn(Game.mGameCode);
													if (46220 - 292371 != -246150)
													{
														this.RAInqj5bxtb = (PlayerCameraControl)this.GetComponent(typeof(PlayerCameraControl));
														if (262958 - 151112 != 111847)
														{
															this.G6unqmwygDr = PhotonClient.Connection;
															if (75668 - 304022 == -228354)
															{
																PhotonClient.ActorNrList.Clear();
																if (129634 - 375681 != -246046)
																{
																	this.InitGame();
																	if (206627 - 91943 == 114684)
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
			else
			{
				Debug.Log("Not Connected");
				if (205038 - 325945 == -120907)
				{
					Game.mGameType = 99;
					if (9836 - 66469 != -56632)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x0600BA07 RID: 47623 RVA: 0x013DB5E8 File Offset: 0x013D97E8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void FixedUpdate()
	{
		if (289225 - 479741 != -190516)
		{
		}
		for (;;)
		{
			if (this.G6unqmwygDr == null)
			{
				if (100612 - 493219 == -392607)
				{
					break;
				}
			}
			else
			{
				eGameState mGameState = Game.mGameState;
				if (154694 - 20930 == 133764)
				{
					if (mGameState == eGameState.Init)
					{
						if (98767 - 517277 == -418509)
						{
							continue;
						}
						AudioListener.volume = 0.1f * (float)Game.volume;
						if (277082 - 584209 != -307127)
						{
							continue;
						}
					}
					else if (mGameState == eGameState.Setup)
					{
						if (236996 - 401170 != -164174)
						{
							continue;
						}
					}
					else if (mGameState == eGameState.Ready)
					{
						if (288995 - 514850 == -225854)
						{
							continue;
						}
					}
					else if (mGameState == eGameState.Start)
					{
						if (263496 - 581243 == -317746)
						{
							continue;
						}
						if (Game.music != 0)
						{
							if (141546 - 201525 == -59978)
							{
								continue;
							}
							if (!this.audio.isPlaying)
							{
								if (206985 - 301561 == -94575)
								{
									continue;
								}
								this.audio.Play();
								if (76075 - 573173 == -497097)
								{
									continue;
								}
							}
						}
						if (Time.time - Game.mStateTime < (float)2)
						{
							if (102392 - 153594 == -51201)
							{
								continue;
							}
							this.audio.volume = Mathf.Lerp((float)0, 0.1f * (float)Game.music, 0.5f * (Time.time - Game.mStateTime));
							if (40949 - 326705 != -285756)
							{
								continue;
							}
						}
						else
						{
							this.audio.volume = 0.1f * (float)Game.music;
							if (246630 - 295221 != -48591)
							{
								continue;
							}
						}
					}
					else if (mGameState == eGameState.Normal)
					{
						if (240604 - 422325 != -181721)
						{
							continue;
						}
						this.audio.volume = 0.1f * (float)Game.music;
						if (273382 - 380291 == -106908)
						{
							continue;
						}
						if (Time.time > this.TFinqopBJxp)
						{
							if (298720 - 215730 != 82990)
							{
								continue;
							}
							Game.mGameMana++;
							if (270644 - 214694 != 55950)
							{
								continue;
							}
							this.TFinqopBJxp = Time.time + (float)12;
							if (208494 - 484287 == -275792)
							{
								continue;
							}
							Chat.SubmitChat("Red Claw", Language.getMessage("M973_PirateCave", UnityEngine.Random.Range(911, 929)), eChatType.npc, eChatMode.system);
							if (276504 - 22310 == 254195)
							{
								continue;
							}
						}
					}
					else if (mGameState == eGameState.Hold)
					{
						if (254975 - 395424 != -140449)
						{
							continue;
						}
					}
					else if (mGameState == eGameState.AllHold)
					{
						if (83361 - 144126 != -60765)
						{
							continue;
						}
					}
					else if (mGameState == eGameState.Ended)
					{
						if (279670 - 443650 == -163979)
						{
							continue;
						}
					}
					if (this.mPirateCaveExit)
					{
						if (88760 - 370093 == -281332)
						{
							continue;
						}
						if (this.wPynqFl8sC2 > (float)0)
						{
							if (126974 - 503527 == -376552)
							{
								continue;
							}
							float z = Mathf.Clamp((float)6 * (Time.time - this.wPynqFl8sC2), (float)0, (float)1800);
							if (16167 - 416263 == -400095)
							{
								continue;
							}
							Vector3 position = this.mPirateCaveExit.position;
							if (236469 - 363569 != -127100)
							{
								continue;
							}
							position.z = z;
							if (54365 - 400758 != -346393)
							{
								continue;
							}
							if (287347 - 582847 != -295500)
							{
								continue;
							}
							this.mPirateCaveExit.position = position;
							if (274916 - 445897 != -170981)
							{
								continue;
							}
							if (111986 - 276678 == -164691)
							{
								continue;
							}
						}
					}
					if (this.ssbnqkburby >= 1)
					{
						break;
					}
					if (113997 - 154405 != -40407)
					{
						if (Time.time - this.wPynqFl8sC2 <= (float)300)
						{
							break;
						}
						if (187062 - 465580 != -278517)
						{
							this.ssbnqkburby = 1;
							if (219067 - 90332 == 128735)
							{
								Game.sendMissionEvent(9732, 1);
								if (100680 - 257937 == -157257)
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

	// Token: 0x0600BA08 RID: 47624 RVA: 0x013DBBA4 File Offset: 0x013D9DA4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator onGameEvent(Hashtable data)
	{
		return new M973_PirateCave9.$onGameEvent$46786(data, this).GetEnumerator();
	}

	// Token: 0x0600BA09 RID: 47625 RVA: 0x013DBBB4 File Offset: 0x013D9DB4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator StartEvent()
	{
		return new M973_PirateCave9.$StartEvent$46797(this).GetEnumerator();
	}

	// Token: 0x0600BA0A RID: 47626 RVA: 0x013DBBC4 File Offset: 0x013D9DC4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator WinEvent()
	{
		return new M973_PirateCave9.$WinEvent$46803(this).GetEnumerator();
	}

	// Token: 0x0600BA0B RID: 47627 RVA: 0x013DBBD4 File Offset: 0x013D9DD4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator LoseEvent()
	{
		return new M973_PirateCave9.$LoseEvent$46808(this).GetEnumerator();
	}

	// Token: 0x0600BA0C RID: 47628 RVA: 0x013DBBE4 File Offset: 0x013D9DE4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void InitGame()
	{
		if (273644 - 416098 != -142454)
		{
		}
		for (;;)
		{
			Debug.Log("Initializing Mission");
			if (83439 - 437304 == -353865)
			{
				Time.timeScale = 1f;
				if (207178 - 249877 != -42698)
				{
					Hashtable customOpParameters = new Hashtable();
					if (231914 - 84068 != 147847)
					{
						this.G6unqmwygDr.OpCustom(52, customOpParameters, true);
						if (284360 - 12422 == 271938)
						{
							this.Init();
							if (213174 - 290093 == -76919)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x0600BA0D RID: 47629 RVA: 0x013DBCD0 File Offset: 0x013D9ED0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onInitGame(Hashtable data)
	{
		if (207354 - 39011 != 168343)
		{
		}
		for (;;)
		{
			Debug.Log("Loading data...");
			if (290119 - 481339 != -191219)
			{
				if (Game.mGameState >= eGameState.Setup)
				{
					break;
				}
				if (173066 - 547085 == -374019)
				{
					Game.mGameState = eGameState.Setup;
					if (114581 - 327727 == -213146)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x0600BA0E RID: 47630 RVA: 0x013DBD74 File Offset: 0x013D9F74
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onGameSetup(Hashtable data)
	{
		if (206696 - 24411 != 182285)
		{
		}
		for (;;)
		{
			int num = RuntimeServices.UnboxInt32(data[43]);
			if (116052 - 506666 != -390613)
			{
				if (num == PlayerData.UID)
				{
					if (246820 - 563383 == -316563)
					{
						this.SetupActors();
						if (78614 - 237162 != -158547)
						{
							break;
						}
					}
				}
				else
				{
					this.ClearActors();
					if (258752 - 119787 == 138965)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x0600BA0F RID: 47631 RVA: 0x013DBE44 File Offset: 0x013DA044
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void SetupActors()
	{
		if (274673 - 418449 != -143775)
		{
		}
		for (;;)
		{
			IL_D2:
			Debug.Log("Creating Actors");
			if (246994 - 80032 == 166962)
			{
				CharacterControl[] array = (CharacterControl[])UnityEngine.Object.FindObjectsOfType(typeof(CharacterControl));
				if (259123 - 97622 == 161501)
				{
					if (Extensions.get_length(array) > 0)
					{
						if (154592 - 406803 != -252210)
						{
							int i = 0;
							if (280520 - 127387 == 153133)
							{
								CharacterControl[] array2 = array;
								if (41781 - 473370 != -431588)
								{
									int length = array2.Length;
									if (84805 - 192316 != -107510)
									{
										while (i < length)
										{
											if (!array2[i].isChild)
											{
												if (20115 - 429689 == -409573)
												{
													goto IL_D2;
												}
												this.createActor(array2[i].Type, array2[i].gameObject.layer - 7, array2[i].transform.position, array2[i].transform.forward);
												if (252087 - 350074 != -97987)
												{
													goto IL_D2;
												}
												UnityEngine.Object.Destroy(array2[i].gameObject);
												if (200933 - 351891 != -150958)
												{
													goto IL_D2;
												}
												this.UjUnqWtMGgR++;
												if (28399 - 16729 != 11670)
												{
													goto IL_D2;
												}
											}
											i++;
											if (212836 - 271618 != -58782)
											{
												goto IL_D2;
											}
										}
										if (178164 - 515135 != -336970)
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
						if (248371 - 32900 == 215471)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x0600BA10 RID: 47632 RVA: 0x013DC080 File Offset: 0x013DA280
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ClearActors()
	{
		if (260166 - 254352 != 5815)
		{
		}
		for (;;)
		{
			IL_86:
			CharacterControl[] array = (CharacterControl[])UnityEngine.Object.FindObjectsOfType(typeof(CharacterControl));
			if (133504 - 446706 != -313201)
			{
				int i = 0;
				if (265771 - 564749 == -298978)
				{
					CharacterControl[] array2 = array;
					if (251569 - 231537 == 20032)
					{
						int length = array2.Length;
						if (182634 - 109309 != 73326)
						{
							while (i < length)
							{
								UnityEngine.Object.Destroy(array2[i].gameObject);
								if (217790 - 548969 == -331178)
								{
									goto IL_86;
								}
								i++;
								if (254626 - 389779 != -135153)
								{
									goto IL_86;
								}
							}
							if (4761 - 366815 == -362054)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x0600BA11 RID: 47633 RVA: 0x013DC1B0 File Offset: 0x013DA3B0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onGameReadyEvent(Hashtable data)
	{
		if (145985 - 299063 != -153077)
		{
		}
		for (;;)
		{
			Debug.Log("Game Ready");
			if (232853 - 80961 == 151892)
			{
				Game.mGameState = eGameState.Ready;
				if (257542 - 303234 == -45692)
				{
					int playerSlot = Game.getPlayerSlot(PlayerData.UID);
					if (247025 - 75902 == 171123)
					{
						if (266846 - 256233 == 10613)
						{
							GameObject gameObject = null;
							if (26707 - 222401 != -195693)
							{
								if (playerSlot < 1)
								{
									goto IL_1C8;
								}
								if (68885 - 299416 != -230531)
								{
									continue;
								}
								if (playerSlot > 5)
								{
									goto IL_1C8;
								}
								if (51526 - 192546 == -141019)
								{
									continue;
								}
								GameObject gameObject2 = GameObject.Find("StartPoint" + playerSlot);
								if (123928 - 308021 == -184092)
								{
									continue;
								}
								gameObject = GameObject.Find("StartCamera" + playerSlot);
								if (253769 - 419076 != -165307)
								{
									continue;
								}
								IL_1ED:
								if (gameObject2)
								{
									if (262242 - 497191 != -234949)
									{
										continue;
									}
									Vector3 spawnPos = global::Math.getSpawnPos(gameObject2.transform.position);
									if (151023 - 228277 != -77254)
									{
										continue;
									}
									if (spawnPos != Vector3.zero)
									{
										if (231697 - 433605 != -201908)
										{
											continue;
										}
										this.CreatePlayer(CharacterData.current.CID, 1, spawnPos, gameObject2.transform.forward);
										if (142113 - 13602 != 128511)
										{
											continue;
										}
									}
									else
									{
										this.CreatePlayer(CharacterData.current.CID, 1, gameObject2.transform.position, gameObject2.transform.forward);
										if (153048 - 494995 != -341947)
										{
											continue;
										}
									}
								}
								if (!gameObject)
								{
									break;
								}
								if (163686 - 507075 != -343389)
								{
									continue;
								}
								this.transform.position = gameObject.transform.position;
								if (293001 - 73562 != 219439)
								{
									continue;
								}
								this.transform.rotation = gameObject.transform.rotation;
								if (266871 - 77412 != 189460)
								{
									break;
								}
								continue;
								IL_1C8:
								gameObject2 = GameObject.Find("StartPoint1");
								if (164286 - 117283 != 47004)
								{
									goto IL_1ED;
								}
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x0600BA12 RID: 47634 RVA: 0x013DC4D4 File Offset: 0x013DA6D4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void StartGame()
	{
		if (218837 - 581256 != -362419)
		{
		}
		for (;;)
		{
			Debug.Log("Start Game");
			if (213145 - 531095 != -317949)
			{
				Game.mGameState = eGameState.Start;
				if (28115 - 418042 != -389926)
				{
					Game.mStateTime = Time.time;
					if (199609 - 196872 == 2737)
					{
						this.StartCoroutine_Auto(this.StartEvent());
						if (286163 - 572088 != -285924)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x0600BA13 RID: 47635 RVA: 0x013DC59C File Offset: 0x013DA79C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onStartGame()
	{
	}

	// Token: 0x0600BA14 RID: 47636 RVA: 0x013DC5A0 File Offset: 0x013DA7A0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void spawnActor(string nType, int nTeam, int nSpawnID)
	{
		if (150814 - 263600 != -112786)
		{
		}
		for (;;)
		{
			GameObject gameObject = GameObject.Find("SpawnPoint" + nSpawnID);
			if (132559 - 226506 != -93946)
			{
				if (gameObject)
				{
					if (267630 - 236197 == 31433)
					{
						this.createActor(nType, nTeam, gameObject.transform.position, gameObject.transform.forward);
						if (119912 - 310407 != -190494)
						{
							break;
						}
					}
				}
				else
				{
					Debug.LogError("Mission SpawnPoint" + nSpawnID);
					if (242068 - 119969 == 122099)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x0600BA15 RID: 47637 RVA: 0x013DC69C File Offset: 0x013DA89C
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void createActor(string nType, int nTeam, Vector3 nPos, Vector3 nDir)
	{
		if (161490 - 277473 != -115983)
		{
		}
		for (;;)
		{
			if (Game.mGameState > eGameState.AllHold)
			{
				if (212595 - 179463 != 33133)
				{
					break;
				}
			}
			else
			{
				Hashtable hashtable = new Hashtable();
				if (226468 - 93477 != 132992)
				{
					hashtable.Add(43, PlayerData.UID);
					if (241537 - 19567 == 221970)
					{
						hashtable.Add(73, nType);
						if (104911 - 267696 != -162784)
						{
							hashtable.Add(75, PhotonClient.cInt16(nTeam));
							if (263024 - 321904 == -58880)
							{
								hashtable.Add(122, PhotonClient.cInt16(Mathf.RoundToInt(nPos.x * (float)50)));
								if (104175 - 105165 != -989)
								{
									hashtable.Add(123, PhotonClient.cInt16(Mathf.RoundToInt(nPos.y * (float)50)));
									if (138970 - 11196 != 127775)
									{
										hashtable.Add(124, PhotonClient.cInt16(Mathf.RoundToInt(nPos.z * (float)50)));
										if (220149 - 282821 == -62672)
										{
											hashtable.Add(126, PhotonClient.cInt16(Mathf.RoundToInt(nDir.x * (float)200)));
											if (48197 - 263506 != -215308)
											{
												hashtable.Add(127, PhotonClient.cInt16(Mathf.RoundToInt(nDir.y * (float)200)));
												if (191934 - 306604 != -114669)
												{
													hashtable.Add(128, PhotonClient.cInt16(Mathf.RoundToInt(nDir.z * (float)200)));
													if (81629 - 381575 == -299946)
													{
														this.G6unqmwygDr.OpCustom(63, hashtable, true);
														if (176775 - 343173 == -166398)
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

	// Token: 0x0600BA16 RID: 47638 RVA: 0x013DC980 File Offset: 0x013DAB80
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onCreateActor(Hashtable data)
	{
		if (278963 - 316214 != -37250)
		{
		}
		for (;;)
		{
			if (Game.mGameState > eGameState.AllHold)
			{
				if (25272 - 370386 != -345113)
				{
					break;
				}
			}
			else
			{
				GameObject gameObject = Game.createActor(data);
				if (281275 - 233057 != 48219)
				{
					if (Game.mGameState == eGameState.Setup)
					{
						if (202078 - 267124 == -65046)
						{
							if (this.UjUnqWtMGgR <= 0)
							{
								break;
							}
							if (78959 - 251551 == -172592)
							{
								this.UjUnqWtMGgR--;
								if (66562 - 294002 == -227440)
								{
									if (this.UjUnqWtMGgR != 0)
									{
										break;
									}
									if (143738 - 88468 == 55270)
									{
										Game.setGameState(eGameState.Ready);
										if (258726 - 539465 == -280739)
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
						if (104466 - 432309 != -327842)
						{
							gameObject.SendMessage("createSpecialEffect", 1);
							if (19629 - 228422 != -208792)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x0600BA17 RID: 47639 RVA: 0x013DCB10 File Offset: 0x013DAD10
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onActorKo(GameObject nActor)
	{
		if (Game.mGameState > eGameState.AllHold)
		{
		}
	}

	// Token: 0x0600BA18 RID: 47640 RVA: 0x013DCB24 File Offset: 0x013DAD24
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onActorDead(GameObject nActor)
	{
		if (40032 - 558980 != -518948)
		{
		}
		for (;;)
		{
			if (Game.mGameState > eGameState.AllHold)
			{
				if (157325 - 557542 == -400217)
				{
					break;
				}
			}
			else
			{
				CharacterControl characterControl = (CharacterControl)nActor.GetComponent(typeof(CharacterControl));
				if (53408 - 394256 == -340848)
				{
					if (!characterControl)
					{
						break;
					}
					if (197101 - 70919 != 126183)
					{
						if (characterControl.isTransform)
						{
							break;
						}
						if (76491 - 230936 != -154444)
						{
							if (characterControl.isSummon)
							{
								break;
							}
							if (163719 - 538487 != -374767)
							{
								string type = characterControl.Type;
								if (203941 - 330189 == -126248)
								{
									if (type == "PirateFish")
									{
										if (137136 - 540020 != -402883)
										{
											Game.sendMissionEvent(9734, 3);
											if (242292 - 347093 != -104800)
											{
												break;
											}
										}
									}
									else if (type == "PirateCrawfish")
									{
										if (108594 - 373937 != -265342)
										{
											Game.sendMissionEvent(9734, 4);
											if (275901 - 529338 == -253437)
											{
												break;
											}
										}
									}
									else if (type == "ZombieFish")
									{
										if (147115 - 550863 != -403747)
										{
											Game.sendMissionEvent(9734, 5);
											if (240096 - 599833 == -359737)
											{
												break;
											}
										}
									}
									else if (type == "ZombieCrawfish")
									{
										if (144338 - 432717 != -288378)
										{
											Game.sendMissionEvent(9734, 6);
											if (122825 - 175819 != -52993)
											{
												break;
											}
										}
									}
									else if (type == "PandoraBug")
									{
										if (123483 - 293328 == -169845)
										{
											Game.sendMissionEvent(9734, 7);
											if (182347 - 21769 != 160579)
											{
												break;
											}
										}
									}
									else
									{
										if (!(type == "CaptainCrab"))
										{
											break;
										}
										if (5748 - 178443 != -172694)
										{
											Game.sendMissionEvent(9734, 8);
											if (283229 - 476192 != -192962)
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

	// Token: 0x0600BA19 RID: 47641 RVA: 0x013DCE40 File Offset: 0x013DB040
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void CreatePlayer(int CID, int team, Vector3 pos, Vector3 dir)
	{
		if (77262 - 554601 != -477338)
		{
		}
		for (;;)
		{
			Hashtable hashtable = new Hashtable();
			if (241331 - 597934 == -356603)
			{
				hashtable.Add(71, CID);
				if (291997 - 173389 != 118609)
				{
					hashtable.Add(75, PhotonClient.cInt16(team));
					if (263152 - 166928 != 96225)
					{
						hashtable.Add(122, PhotonClient.cInt16(Mathf.RoundToInt(pos.x * (float)50)));
						if (38730 - 424924 == -386194)
						{
							hashtable.Add(123, PhotonClient.cInt16(Mathf.RoundToInt(pos.y * (float)50)));
							if (141854 - 148817 != -6962)
							{
								hashtable.Add(124, PhotonClient.cInt16(Mathf.RoundToInt(pos.z * (float)50)));
								if (39890 - 145755 == -105865)
								{
									hashtable.Add(126, PhotonClient.cInt16(Mathf.RoundToInt(dir.x * (float)200)));
									if (71703 - 181247 == -109544)
									{
										hashtable.Add(127, PhotonClient.cInt16(Mathf.RoundToInt(dir.y * (float)200)));
										if (138691 - 126117 == 12574)
										{
											hashtable.Add(128, PhotonClient.cInt16(Mathf.RoundToInt(dir.z * (float)200)));
											if (41412 - 357249 == -315837)
											{
												this.G6unqmwygDr.OpCustom(61, hashtable, true);
												if (141975 - 557213 == -415238)
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

	// Token: 0x0600BA1A RID: 47642 RVA: 0x013DD0CC File Offset: 0x013DB2CC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onCreatePlayer(Hashtable data)
	{
		if (23938 - 468136 != -444198)
		{
		}
		for (;;)
		{
			GameObject gameObject = Game.createPlayer(data);
			if (160132 - 578069 != -417936)
			{
				if (!gameObject)
				{
					break;
				}
				if (131130 - 474767 == -343637)
				{
					PlayerCameraControl playerCameraControl = (PlayerCameraControl)this.GetComponent(typeof(PlayerCameraControl));
					if (24201 - 198960 != -174758)
					{
						playerCameraControl.target = gameObject;
						if (260235 - 594461 != -334225)
						{
							Game.loadPlayer();
							if (298812 - 394387 == -95575)
							{
								this.StartGame();
								if (218624 - 377742 != -159117)
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

	// Token: 0x0600BA1B RID: 47643 RVA: 0x013DD1DC File Offset: 0x013DB3DC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onCreatePeer(Hashtable data)
	{
		if (200505 - 271362 != -70856)
		{
		}
		for (;;)
		{
			Game.createPeer(data);
			if (217887 - 512252 != -294364)
			{
				GameGui gameGui = (GameGui)this.GetComponent(typeof(GameGui));
				if (169630 - 206498 == -36868)
				{
					gameGui.ResetTeamBar();
					if (114728 - 568914 == -454186)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x0600BA1C RID: 47644 RVA: 0x013DD288 File Offset: 0x013DB488
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator onDeadPlayer()
	{
		return new M973_PirateCave9.$onDeadPlayer$46813(this).GetEnumerator();
	}

	// Token: 0x0600BA1D RID: 47645 RVA: 0x013DD298 File Offset: 0x013DB498
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onRevivePlayer()
	{
		if (81623 - 42964 != 38660)
		{
		}
		for (;;)
		{
			Debug.Log("On Revive Player");
			if (170499 - 534013 == -363514)
			{
				this.RAInqj5bxtb.target = Game.mPlayer;
				if (66014 - 208708 != -142693)
				{
					this.RAInqj5bxtb.enabled = true;
					if (201699 - 141799 != 59901)
					{
						if (Game.mGameState != eGameState.Normal)
						{
							if (261617 - 366906 == -105288)
							{
								continue;
							}
							if (Game.mGameState != eGameState.Hold)
							{
								break;
							}
							if (138189 - 189775 != -51586)
							{
								continue;
							}
						}
						Game.mGameState = eGameState.Normal;
						if (149501 - 199197 == -49696)
						{
							GameGui gameGui = (GameGui)this.GetComponent(typeof(GameGui));
							if (184881 - 287231 == -102350)
							{
								if (!gameGui)
								{
									break;
								}
								if (150609 - 141999 == 8610)
								{
									gameGui.enabled = true;
									if (289862 - 223993 != 65870)
									{
										gameGui.closeDeadMenu();
										if (76329 - 290693 == -214364)
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

	// Token: 0x0600BA1E RID: 47646 RVA: 0x013DD444 File Offset: 0x013DB644
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onPlayerRelease(GameObject mPlayer)
	{
		if (50709 - 222498 != -171789)
		{
		}
		for (;;)
		{
			Debug.Log("On Release Spirit");
			if (142148 - 299845 != -157696)
			{
				PlayerData.MissionWithdraw[MissionData.getMissionNumber(Game.mGameCode) - 1] = PlayerData.MissionWithdraw[MissionData.getMissionNumber(Game.mGameCode) - 1] + 1;
				if (268388 - 589153 != -320764)
				{
					this.StartCoroutine_Auto(this.ReturnToTown());
					if (46928 - 597285 == -550357)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x0600BA1F RID: 47647 RVA: 0x013DD508 File Offset: 0x013DB708
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onDestroyPlayer(Hashtable data)
	{
		if (RuntimeServices.EqualityOperator(data[81], PlayerData.UID))
		{
			Game.mGameState = eGameState.Ended;
		}
	}

	// Token: 0x0600BA20 RID: 47648 RVA: 0x013DD534 File Offset: 0x013DB734
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void ChangePlayer(int nCID)
	{
		if (168038 - 58572 != 109466)
		{
		}
		for (;;)
		{
			int v = Game.mPlayer.layer - 7;
			if (137290 - 520461 != -383170)
			{
				Vector3 position = Game.mPlayer.transform.position;
				if (67420 - 262689 != -195268)
				{
					Vector3 forward = Game.mPlayer.transform.forward;
					if (17720 - 279098 != -261377)
					{
						Hashtable hashtable = new Hashtable();
						if (199896 - 218484 == -18588)
						{
							hashtable.Add(43, PlayerData.UID);
							if (110701 - 201500 == -90799)
							{
								hashtable.Add(71, nCID);
								if (243498 - 95715 == 147783)
								{
									hashtable.Add(75, PhotonClient.cInt16(v));
									if (214778 - 115844 == 98934)
									{
										hashtable.Add(122, PhotonClient.cInt16(Mathf.RoundToInt(position.x * (float)50)));
										if (189097 - 110342 == 78755)
										{
											hashtable.Add(123, PhotonClient.cInt16(Mathf.RoundToInt(position.y * (float)50)));
											if (245047 - 351563 != -106515)
											{
												hashtable.Add(124, PhotonClient.cInt16(Mathf.RoundToInt(position.z * (float)50)));
												if (168867 - 368207 != -199339)
												{
													hashtable.Add(126, PhotonClient.cInt16(Mathf.RoundToInt(forward.x * (float)200)));
													if (18700 - 195628 != -176927)
													{
														hashtable.Add(127, PhotonClient.cInt16(Mathf.RoundToInt(forward.y * (float)200)));
														if (53112 - 323920 != -270807)
														{
															hashtable.Add(128, PhotonClient.cInt16(Mathf.RoundToInt(forward.z * (float)200)));
															if (238552 - 268400 != -29847)
															{
																PhotonClient.Connection.OpCustom(65, hashtable, true);
																if (47580 - 243553 != -195972)
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

	// Token: 0x0600BA21 RID: 47649 RVA: 0x013DD854 File Offset: 0x013DBA54
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator onChangePlayer(Hashtable data)
	{
		return new M973_PirateCave9.$onChangePlayer$46819(data, this).GetEnumerator();
	}

	// Token: 0x0600BA22 RID: 47650 RVA: 0x013DD864 File Offset: 0x013DBA64
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator onGameComplete(Hashtable data)
	{
		return new M973_PirateCave9.$onGameComplete$46826(data, this).GetEnumerator();
	}

	// Token: 0x0600BA23 RID: 47651 RVA: 0x013DD874 File Offset: 0x013DBA74
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator ReturnToTown()
	{
		return new M973_PirateCave9.$ReturnToTown$46836(this).GetEnumerator();
	}

	// Token: 0x0600BA24 RID: 47652 RVA: 0x013DD884 File Offset: 0x013DBA84
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator ReturnToGuild()
	{
		return new M973_PirateCave9.$ReturnToGuild$46841(this).GetEnumerator();
	}

	// Token: 0x0600BA25 RID: 47653 RVA: 0x013DD894 File Offset: 0x013DBA94
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator ReturnToCamp()
	{
		return new M973_PirateCave9.$ReturnToCamp$46845(this).GetEnumerator();
	}

	// Token: 0x0600BA26 RID: 47654 RVA: 0x013DD8A4 File Offset: 0x013DBAA4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void LeaveGame()
	{
		if (41255 - 274376 != -233121)
		{
		}
		for (;;)
		{
			Debug.Log("leaving guild");
			if (203114 - 105955 != 97160)
			{
				Hashtable hashtable = new Hashtable();
				if (97936 - 241504 == -143568)
				{
					hashtable.Add(43, PlayerData.UID);
					if (121066 - 378251 == -257185)
					{
						PhotonClient.Connection.OpCustom(54, hashtable, true);
						if (35237 - 6746 == 28491)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x0600BA27 RID: 47655 RVA: 0x013DD97C File Offset: 0x013DBB7C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onLeaveGame()
	{
		Debug.Log("onLeaveGame");
		this.JoinTown();
	}

	// Token: 0x0600BA28 RID: 47656 RVA: 0x013DD990 File Offset: 0x013DBB90
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void JoinTown()
	{
		if (107933 - 311008 != -203075)
		{
		}
		for (;;)
		{
			Debug.Log("Joining Town");
			if (227013 - 186292 == 40721)
			{
				Hashtable hashtable = new Hashtable();
				if (53967 - 188800 != -134832)
				{
					if (Game.mNextGameCode == 30)
					{
						if (262840 - 388473 != -125633)
						{
							continue;
						}
						hashtable.Add(47, "NoGuild");
						if (35063 - 408407 != -373344)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 31)
					{
						if (106540 - 61645 != 44895)
						{
							continue;
						}
						hashtable.Add(47, "G" + GuildData.Name);
						if (93881 - 211200 != -117319)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 32)
					{
						if (222700 - 23857 == 198844)
						{
							continue;
						}
						hashtable.Add(47, "SnowCamp");
						if (235183 - 140125 != 95058)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 33)
					{
						if (214607 - 586577 == -371969)
						{
							continue;
						}
						hashtable.Add(47, "CrystalBeach");
						if (47438 - 344557 != -297119)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 34)
					{
						if (50034 - 513764 == -463729)
						{
							continue;
						}
						hashtable.Add(47, "ExcavationCamp");
						if (291541 - 157591 == 133951)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 35)
					{
						if (3252 - 439286 == -436033)
						{
							continue;
						}
						hashtable.Add(47, "UndergroundCamp");
						if (281771 - 454421 == -172649)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 36)
					{
						if (290845 - 318733 == -27887)
						{
							continue;
						}
						hashtable.Add(47, "ForestCamp");
						if (258966 - 392957 == -133990)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 51)
					{
						if (249577 - 545620 != -296043)
						{
							continue;
						}
						hashtable.Add(47, "MainStreet");
						if (172442 - 335705 == -163262)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 52)
					{
						if (41155 - 310221 == -269065)
						{
							continue;
						}
						hashtable.Add(47, "CentralSquare");
						if (170260 - 165084 != 5176)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 53)
					{
						if (116227 - 441059 == -324831)
						{
							continue;
						}
						hashtable.Add(47, "CityLibrary");
						if (65676 - 100179 != -34503)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 54)
					{
						if (174853 - 579769 != -404916)
						{
							continue;
						}
						hashtable.Add(47, "LightPark");
						if (145147 - 166873 == -21725)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 55)
					{
						if (258689 - 283678 == -24988)
						{
							continue;
						}
						hashtable.Add(47, "LightPalace");
						if (81735 - 234568 != -152833)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 56)
					{
						if (79860 - 587001 == -507140)
						{
							continue;
						}
						hashtable.Add(47, "PlainColosseum");
						if (195705 - 486430 == -290724)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 57)
					{
						if (71493 - 371816 != -300323)
						{
							continue;
						}
						hashtable.Add(47, "LightTheater");
						if (211952 - 357010 == -145057)
						{
							continue;
						}
					}
					hashtable.Add(21, PhotonClient.cInt16(Mathf.Clamp(PlayerPrefs.GetInt("channel", 0), 0, 99)));
					if (101299 - 36555 != 64745)
					{
						this.G6unqmwygDr.OpCustom(42, hashtable, true);
						if (205957 - 268019 != -62061)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x0600BA29 RID: 47657 RVA: 0x013DDF44 File Offset: 0x013DC144
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onJoinTown()
	{
		Game.mGameStage = 0;
		Game.loadNextLevel();
	}

	// Token: 0x0600BA2A RID: 47658 RVA: 0x013DDF54 File Offset: 0x013DC154
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x0600BA2B RID: 47659 RVA: 0x013DDF58 File Offset: 0x013DC158
	internal static bool wigKrItU1XHnNvi8fThJ()
	{
		return true;
	}

	// Token: 0x0600BA2C RID: 47660 RVA: 0x013DDF5C File Offset: 0x013DC15C
	internal static bool ktAOJstU4AHa6Lgjasy1()
	{
		return false;
	}

	// Token: 0x04009FF2 RID: 40946
	private LitePeer G6unqmwygDr;

	// Token: 0x04009FF3 RID: 40947
	private PlayerCameraControl RAInqj5bxtb;

	// Token: 0x04009FF4 RID: 40948
	private float TFinqopBJxp;

	// Token: 0x04009FF5 RID: 40949
	private int ssbnqkburby;

	// Token: 0x04009FF6 RID: 40950
	private float wPynqFl8sC2;

	// Token: 0x04009FF7 RID: 40951
	private int LYZnqAsQeEM;

	// Token: 0x04009FF8 RID: 40952
	private int scNnq9MsNeG;

	// Token: 0x04009FF9 RID: 40953
	public Transform mPirateCaveExit;

	// Token: 0x04009FFA RID: 40954
	private int UjUnqWtMGgR;

	// Token: 0x02001F1F RID: 7967
	[CompilerGenerated]
	[Serializable]
	internal sealed class $onGameEvent$46786 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600BA2D RID: 47661 RVA: 0x013DDF60 File Offset: 0x013DC160
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $onGameEvent$46786(Hashtable data, M973_PirateCave9 self_)
		{
			if (127202 - 479294 != -352092)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (114107 - 194095 == -79988)
				{
					base..ctor();
					if (162169 - 42518 != 119652)
					{
						this.$data$46795 = data;
						if (45826 - 435375 == -389549)
						{
							this.$self_$46796 = self_;
							if (269009 - 47732 == 221277)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x0600BA2E RID: 47662 RVA: 0x013DE01C File Offset: 0x013DC21C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M973_PirateCave9.$onGameEvent$46786.$(this.$data$46795, this.$self_$46796);
		}

		// Token: 0x0600BA2F RID: 47663 RVA: 0x013DE030 File Offset: 0x013DC230
		internal static bool PVUDVxtUzVI72W2KU8AN()
		{
			return true;
		}

		// Token: 0x0600BA30 RID: 47664 RVA: 0x013DE034 File Offset: 0x013DC234
		internal static bool lR4hCUtTadMQrarp6EeZ()
		{
			return false;
		}

		// Token: 0x04009FFB RID: 40955
		internal Hashtable $data$46795;

		// Token: 0x04009FFC RID: 40956
		internal M973_PirateCave9 $self_$46796;

		// Token: 0x02001F20 RID: 7968
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600BA31 RID: 47665 RVA: 0x013DE038 File Offset: 0x013DC238
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Hashtable data, M973_PirateCave9 self_)
			{
				if (80175 - 474023 != -393848)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (217902 - 398230 != -180327)
					{
						base..ctor();
						if (188115 - 347513 == -159398)
						{
							this.$data$46793 = data;
							if (205072 - 143100 != 61973)
							{
								this.$self_$46794 = self_;
								if (108273 - 17544 == 90729)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x0600BA32 RID: 47666 RVA: 0x013DE0F4 File Offset: 0x013DC2F4
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (93769 - 362443 != -268673)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						goto IL_416;
					case 1:
						goto IL_805;
					case 2:
						Game.savePlayer();
						if (199023 - 147851 == 51173)
						{
							continue;
						}
						if (this.$returnValue$46788 == 10)
						{
							if (165509 - 333798 != -168289)
							{
								continue;
							}
							Game.mGameStage = 10;
							if (269980 - 325405 == -55424)
							{
								continue;
							}
							Application.LoadLevel("M973_PirateCave10");
							if (252422 - 77016 == 175407)
							{
								continue;
							}
						}
						else
						{
							Game.mGameStage = 11;
							if (17138 - 554107 == -536968)
							{
								continue;
							}
							Application.LoadLevel("M973_PirateCave11");
							if (196824 - 396181 == -199356)
							{
								continue;
							}
						}
						break;
					case 3:
						if (Game.mGameState != eGameState.Normal)
						{
							if (187817 - 284942 != -97124)
							{
								goto Block_61;
							}
							continue;
						}
						else if (UnityEngine.Random.Range(0, 100) < 60)
						{
							if (108577 - 505574 == -396996)
							{
								continue;
							}
							this.$self_$46794.spawnActor("ZombieFish", 7, UnityEngine.Random.Range(0, 10));
							if (166013 - 544846 == -378832)
							{
								continue;
							}
						}
						else
						{
							this.$self_$46794.spawnActor("ZombieCrawfish", 7, UnityEngine.Random.Range(0, 10));
							if (45895 - 586939 != -541044)
							{
								continue;
							}
						}
						break;
					default:
						if (18234 - 291182 != -272947)
						{
							goto IL_416;
						}
						continue;
					}
					IL_1F:
					this.YieldDefault(1);
					if (271988 - 167429 != 104560)
					{
						break;
					}
					continue;
					IL_416:
					if (Game.mGameState > eGameState.AllHold)
					{
						if (145394 - 19433 != 125961)
						{
							continue;
						}
						break;
					}
					else
					{
						this.$returnCode$46787 = RuntimeServices.UnboxInt32(this.$data$46793[141]);
						if (150407 - 257141 != -106734)
						{
							continue;
						}
						this.$returnValue$46788 = RuntimeServices.UnboxInt32(this.$data$46793[145]);
						if (251190 - 339816 == -88625)
						{
							continue;
						}
						this.$ownerID$46789 = RuntimeServices.UnboxInt32(this.$data$46793[43]);
						if (44769 - 139760 == -94990)
						{
							continue;
						}
						this.$$switch$8731$46790 = this.$returnCode$46787;
						if (95250 - 505558 == -410307)
						{
							continue;
						}
						if (this.$$switch$8731$46790 == 9731)
						{
							if (153759 - 554656 != -400897)
							{
								continue;
							}
						}
						else if (this.$$switch$8731$46790 == -9731)
						{
							if (253029 - 595477 != -342448)
							{
								continue;
							}
							if (this.$self_$46794.ssbnqkburby < 2)
							{
								if (200884 - 87736 == 113149)
								{
									continue;
								}
								this.$self_$46794.ssbnqkburby = 2;
								if (277747 - 59987 == 217761)
								{
									continue;
								}
								Game.mGameState = eGameState.AllHold;
								if (65467 - 480649 == -415181)
								{
									continue;
								}
								this.$mGameGui$46791 = (GameGui)this.$self_$46794.GetComponent(typeof(GameGui));
								if (192807 - 284498 == -91690)
								{
									continue;
								}
								this.$mGameGui$46791.close();
								if (292873 - 226992 == 65882)
								{
									continue;
								}
								this.$self_$46794.SendMessage("fadeOut");
								if (56491 - 341421 != -284929)
								{
									goto Block_23;
								}
								continue;
							}
						}
						else if (this.$$switch$8731$46790 == 9732)
						{
							if (84583 - 172740 == -88156)
							{
								continue;
							}
						}
						else if (this.$$switch$8731$46790 == -9732)
						{
							if (180200 - 442601 != -262401)
							{
								continue;
							}
							if (this.$self_$46794.ssbnqkburby < 2)
							{
								if (52414 - 371377 == -318962)
								{
									continue;
								}
								if (this.$returnValue$46788 == 1)
								{
									if (27896 - 549919 != -522023)
									{
										continue;
									}
									this.$self_$46794.ssbnqkburby = 2;
									if (67342 - 150087 != -82745)
									{
										continue;
									}
									this.$self_$46794.StartCoroutine_Auto(this.$self_$46794.LoseEvent());
									if (236077 - 172737 != 63340)
									{
										continue;
									}
								}
							}
						}
						else if (this.$$switch$8731$46790 == 9734)
						{
							if (23956 - 158652 == -134695)
							{
								continue;
							}
							this.$$switch$8729$46792 = this.$returnValue$46788;
							if (274894 - 274742 != 152)
							{
								continue;
							}
							if (this.$$switch$8729$46792 != 5)
							{
								if (87185 - 145183 != -57998)
								{
									continue;
								}
								if (this.$$switch$8729$46792 == 6)
								{
									if (133450 - 47637 != 85813)
									{
										continue;
									}
								}
								else
								{
									if (this.$$switch$8729$46792 != 8)
									{
										goto IL_156;
									}
									if (33989 - 252523 != -218534)
									{
										continue;
									}
									this.$self_$46794.scNnq9MsNeG = this.$self_$46794.scNnq9MsNeG + 1;
									if (68572 - 108171 != -39599)
									{
										continue;
									}
									if (this.$self_$46794.ssbnqkburby < 1)
									{
										if (5484 - 76921 != -71437)
										{
											continue;
										}
										this.$self_$46794.ssbnqkburby = 1;
										if (260799 - 401866 == -141066)
										{
											continue;
										}
										this.$self_$46794.StartCoroutine_Auto(this.$self_$46794.WinEvent());
										if (210717 - 20725 == 189993)
										{
											continue;
										}
									}
									goto IL_156;
								}
							}
							this.$self_$46794.LYZnqAsQeEM = this.$self_$46794.LYZnqAsQeEM + 1;
							if (28955 - 256113 != -227158)
							{
								continue;
							}
							Debug.Log("Zombie Eliminate: " + this.$self_$46794.LYZnqAsQeEM);
							if (147895 - 480160 != -332265)
							{
								continue;
							}
							if (PlayerData.UID == this.$ownerID$46789)
							{
								if (17081 - 494289 != -477208)
								{
									continue;
								}
								if (this.$self_$46794.LYZnqAsQeEM < 12)
								{
									if (64004 - 386076 != -322072)
									{
										continue;
									}
									goto IL_747;
								}
							}
						}
						else
						{
							Debug.LogError("Warning unknown returnCode:" + this.$returnCode$46787);
							if (107659 - 355298 == -247638)
							{
								continue;
							}
						}
					}
					IL_156:
					goto IL_1F;
				}
				goto IL_805;
				Block_23:
				return this.Yield(2, new WaitForSeconds((float)1));
				IL_747:
				return this.Yield(3, new WaitForSeconds(12f));
				Block_61:
				IL_805:
				return false;
			}

			// Token: 0x0600BA33 RID: 47667 RVA: 0x013DE918 File Offset: 0x013DCB18
			internal static bool AXA37AtT590rtf6GLACZ()
			{
				return true;
			}

			// Token: 0x0600BA34 RID: 47668 RVA: 0x013DE91C File Offset: 0x013DCB1C
			internal static bool P3QP4NtTp54EqGQuCZGy()
			{
				return false;
			}

			// Token: 0x04009FFD RID: 40957
			internal int $returnCode$46787;

			// Token: 0x04009FFE RID: 40958
			internal int $returnValue$46788;

			// Token: 0x04009FFF RID: 40959
			internal int $ownerID$46789;

			// Token: 0x0400A000 RID: 40960
			internal int $$switch$8731$46790;

			// Token: 0x0400A001 RID: 40961
			internal GameGui $mGameGui$46791;

			// Token: 0x0400A002 RID: 40962
			internal int $$switch$8729$46792;

			// Token: 0x0400A003 RID: 40963
			internal Hashtable $data$46793;

			// Token: 0x0400A004 RID: 40964
			internal M973_PirateCave9 $self_$46794;
		}
	}

	// Token: 0x02001F21 RID: 7969
	[CompilerGenerated]
	[Serializable]
	internal sealed class $StartEvent$46797 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600BA35 RID: 47669 RVA: 0x013DE920 File Offset: 0x013DCB20
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $StartEvent$46797(M973_PirateCave9 self_)
		{
			if (56621 - 547139 != -490518)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (31017 - 384032 != -353014)
				{
					base..ctor();
					if (220433 - 58700 == 161733)
					{
						this.$self_$46802 = self_;
						if (94926 - 131964 != -37037)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x0600BA36 RID: 47670 RVA: 0x013DE9B8 File Offset: 0x013DCBB8
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M973_PirateCave9.$StartEvent$46797.$(this.$self_$46802);
		}

		// Token: 0x0600BA37 RID: 47671 RVA: 0x013DE9C8 File Offset: 0x013DCBC8
		internal static bool crxQWptTVVPA9Tw5IoxZ()
		{
			return true;
		}

		// Token: 0x0600BA38 RID: 47672 RVA: 0x013DE9CC File Offset: 0x013DCBCC
		internal static bool ubVJPetTtNZjrK0pAYqt()
		{
			return false;
		}

		// Token: 0x0400A005 RID: 40965
		internal M973_PirateCave9 $self_$46802;

		// Token: 0x02001F22 RID: 7970
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600BA39 RID: 47673 RVA: 0x013DE9D0 File Offset: 0x013DCBD0
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M973_PirateCave9 self_)
			{
				if (15962 - 325611 != -309648)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (248562 - 77129 == 171433)
					{
						base..ctor();
						if (41479 - 103229 == -61750)
						{
							this.$self_$46801 = self_;
							if (105814 - 192042 != -86227)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x0600BA3A RID: 47674 RVA: 0x013DEA68 File Offset: 0x013DCC68
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (288492 - 398840 != -110347)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_526;
					case 2:
						if (Game.mGameState != eGameState.Start)
						{
							if (31871 - 344548 != -312676)
							{
								goto Block_13;
							}
							continue;
						}
						else
						{
							this.$mStoryGui$46798 = (StoryGui)this.$self_$46801.GetComponent(typeof(StoryGui));
							if (139990 - 597937 == -457946)
							{
								continue;
							}
							this.$mStoryTimer$46799 = 0f;
							if (155883 - 207880 == -51996)
							{
								continue;
							}
							if (!this.$mStoryGui$46798)
							{
								goto IL_27C;
							}
							if (292008 - 201293 == 90716)
							{
								continue;
							}
							this.$mStoryGui$46798.startStoryMessage(CharacterData.current.Type, CharacterData.current.Name, eTalkType.friend);
							if (283520 - 286914 != -3394)
							{
								continue;
							}
							goto IL_472;
						}
						break;
					case 3:
						if (Game.mGameState != eGameState.Start)
						{
							if (83552 - 130311 != -46758)
							{
								goto Block_30;
							}
							continue;
						}
						else
						{
							this.$mStoryGui$46798.newStoryMessage(CharacterData.current.Type, CharacterData.current.Name, Language.getMessage("M973_PirateCave", 901), eTalkType.friend);
							if (97319 - 275817 != -178497)
							{
								goto Block_33;
							}
							continue;
						}
						break;
					case 4:
						if (Game.mGameState != eGameState.Start)
						{
							if (235035 - 466417 != -231382)
							{
								continue;
							}
							goto IL_B7;
						}
						else
						{
							this.$mStoryGui$46798.newStoryMessage(CharacterData.current.Type, CharacterData.current.Name, Language.getMessage("M973_PirateCave", 902), eTalkType.friend);
							if (234439 - 303505 != -69066)
							{
								continue;
							}
							goto IL_437;
						}
						break;
					case 5:
						if (Game.mGameState != eGameState.Start)
						{
							if (103854 - 527855 != -424000)
							{
								goto Block_28;
							}
							continue;
						}
						else
						{
							this.$mStoryGui$46798.close();
							if (30902 - 431993 != -401091)
							{
								continue;
							}
							goto IL_3FC;
						}
						break;
					case 6:
						if (Game.mGameState == eGameState.Start)
						{
							goto IL_27C;
						}
						if (2326 - 555558 != -553232)
						{
							continue;
						}
						goto IL_277;
					case 7:
						if (Game.mGameState != eGameState.Start)
						{
							if (60909 - 495078 != -434169)
							{
								continue;
							}
							goto IL_2B7;
						}
						else
						{
							this.$mGameGui$46800 = (GameGui)this.$self_$46801.GetComponent(typeof(GameGui));
							if (153560 - 296828 == -143267)
							{
								continue;
							}
							this.$mGameGui$46800.enabled = true;
							if (71931 - 566730 == -494798)
							{
								continue;
							}
							this.$self_$46801.RAInqj5bxtb.enabled = true;
							if (270562 - 500854 != -230292)
							{
								continue;
							}
							goto IL_106;
						}
						break;
					case 8:
						Game.mGameState = eGameState.Normal;
						if (133544 - 369070 == -235525)
						{
							continue;
						}
						Game.mStateTime = Time.time;
						if (141700 - 378323 != -236623)
						{
							continue;
						}
						this.YieldDefault(1);
						if (117492 - 175409 != -57917)
						{
							continue;
						}
						goto IL_526;
					default:
						if (162986 - 28187 == 134800)
						{
							continue;
						}
						break;
					}
					Debug.Log("StartEvent");
					if (33248 - 148013 == -114765)
					{
						this.$self_$46801.RAInqj5bxtb.alignToObject("EventCamera1");
						if (184360 - 283979 != -99618)
						{
							this.$self_$46801.SendMessage("fadeIn");
							if (11431 - 10288 != 1144)
							{
								this.$self_$46801.RAInqj5bxtb.StartCoroutine_Auto(this.$self_$46801.RAInqj5bxtb.slerpToObject("EventCamera2", (float)3));
								if (104270 - 211689 != -107418)
								{
									goto Block_19;
								}
							}
						}
					}
				}
				IL_B7:
				goto IL_526;
				IL_106:
				return this.Yield(8, new WaitForSeconds(0.5f));
				Block_13:
				IL_277:
				goto IL_526;
				IL_27C:
				return this.Yield(7, new WaitForSeconds(0.5f));
				IL_2B7:
				goto IL_526;
				Block_19:
				return this.Yield(2, new WaitForSeconds(2f));
				IL_3FC:
				return this.Yield(6, new WaitForSeconds(0.5f));
				IL_437:
				return this.Yield(5, new WaitForSeconds(3f));
				Block_28:
				goto IL_526;
				IL_472:
				return this.Yield(3, new WaitForSeconds(0.5f));
				Block_30:
				goto IL_526;
				Block_33:
				return this.Yield(4, new WaitForSeconds(3f));
				IL_526:
				return false;
			}

			// Token: 0x0600BA3B RID: 47675 RVA: 0x013DEFB0 File Offset: 0x013DD1B0
			internal static bool YHKQCktTN6QKOGZivQA3()
			{
				return true;
			}

			// Token: 0x0600BA3C RID: 47676 RVA: 0x013DEFB4 File Offset: 0x013DD1B4
			internal static bool GUARMTtTYMWrJlwnEoAF()
			{
				return false;
			}

			// Token: 0x0400A006 RID: 40966
			internal StoryGui $mStoryGui$46798;

			// Token: 0x0400A007 RID: 40967
			internal float $mStoryTimer$46799;

			// Token: 0x0400A008 RID: 40968
			internal GameGui $mGameGui$46800;

			// Token: 0x0400A009 RID: 40969
			internal M973_PirateCave9 $self_$46801;
		}
	}

	// Token: 0x02001F23 RID: 7971
	[CompilerGenerated]
	[Serializable]
	internal sealed class $WinEvent$46803 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600BA3D RID: 47677 RVA: 0x013DEFB8 File Offset: 0x013DD1B8
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $WinEvent$46803(M973_PirateCave9 self_)
		{
			if (294399 - 418330 != -123931)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (102781 - 261307 == -158526)
				{
					base..ctor();
					if (105156 - 398227 != -293070)
					{
						this.$self_$46807 = self_;
						if (3364 - 313197 != -309832)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x0600BA3E RID: 47678 RVA: 0x013DF050 File Offset: 0x013DD250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M973_PirateCave9.$WinEvent$46803.$(this.$self_$46807);
		}

		// Token: 0x0600BA3F RID: 47679 RVA: 0x013DF060 File Offset: 0x013DD260
		internal static bool VvANKJtTc5Uh0FbFcyPH()
		{
			return true;
		}

		// Token: 0x0600BA40 RID: 47680 RVA: 0x013DF064 File Offset: 0x013DD264
		internal static bool FHeZastTUkKmZt7ix618()
		{
			return false;
		}

		// Token: 0x0400A00A RID: 40970
		internal M973_PirateCave9 $self_$46807;

		// Token: 0x02001F24 RID: 7972
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600BA41 RID: 47681 RVA: 0x013DF068 File Offset: 0x013DD268
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M973_PirateCave9 self_)
			{
				if (192817 - 170725 != 22093)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (225729 - 97217 != 128513)
					{
						base..ctor();
						if (92315 - 271886 == -179571)
						{
							this.$self_$46806 = self_;
							if (196100 - 515816 == -319716)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x0600BA42 RID: 47682 RVA: 0x013DF100 File Offset: 0x013DD300
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (277298 - 154794 != 122504)
				{
				}
				do
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_570;
					case 2:
						if (Game.mGameState != eGameState.AllHold)
						{
							if (294388 - 246074 != 48315)
							{
								goto Block_21;
							}
							continue;
						}
						else
						{
							this.$self_$46806.SendMessage("fadeOut");
							if (109734 - 54611 != 55123)
							{
								continue;
							}
							goto IL_3EF;
						}
						break;
					case 3:
						if (Game.mGameState != eGameState.AllHold)
						{
							if (77912 - 3435 != 74477)
							{
								continue;
							}
							goto IL_500;
						}
						else
						{
							this.$self_$46806.RAInqj5bxtb.alignToObject("EventCamera3");
							if (95688 - 571339 != -475650)
							{
								goto Block_34;
							}
							continue;
						}
						break;
					case 4:
						if (Game.mGameState != eGameState.AllHold)
						{
							if (117130 - 36141 != 80990)
							{
								goto Block_8;
							}
							continue;
						}
						else
						{
							this.$self_$46806.SendMessage("fadeIn");
							if (143217 - 311924 != -168707)
							{
								continue;
							}
							goto IL_1FA;
						}
						break;
					case 5:
						this.$mStoryGui$46805 = (StoryGui)this.$self_$46806.GetComponent(typeof(StoryGui));
						if (9538 - 454240 != -444702)
						{
							continue;
						}
						if (!this.$mStoryGui$46805)
						{
							goto IL_44A;
						}
						if (230560 - 493876 != -263316)
						{
							continue;
						}
						this.$mStoryGui$46805.startStoryMessage("CaptainCrab", "Red Claw", eTalkType.enemy);
						if (137526 - 163381 != -25854)
						{
							goto Block_13;
						}
						continue;
					case 6:
						if (Game.mGameState != eGameState.AllHold)
						{
							if (64958 - 364000 != -299041)
							{
								goto Block_5;
							}
							continue;
						}
						else
						{
							this.$mStoryGui$46805.newStoryMessage("CaptainCrab", "Red Claw", Language.getMessage("M973_PirateCave", 931), eTalkType.enemy);
							if (82889 - 6248 != 76642)
							{
								goto Block_19;
							}
							continue;
						}
						break;
					case 7:
						if (Game.mGameState != eGameState.AllHold)
						{
							if (232916 - 213067 != 19849)
							{
								continue;
							}
							goto IL_49;
						}
						else
						{
							this.$mStoryGui$46805.newStoryMessage("CaptainCrab", "Red Claw", Language.getMessage("M973_PirateCave", 932), eTalkType.enemy);
							if (74266 - 569121 != -494854)
							{
								goto Block_3;
							}
							continue;
						}
						break;
					case 8:
						if (Game.mGameState != eGameState.AllHold)
						{
							if (217477 - 287992 != -70515)
							{
								continue;
							}
							goto IL_29B;
						}
						else
						{
							this.$mStoryGui$46805.newStoryMessage("CaptainCrab", "Red Claw", Language.getMessage("M973_PirateCave", 933), eTalkType.enemy);
							if (159997 - 349244 != -189246)
							{
								goto Block_16;
							}
							continue;
						}
						break;
					case 9:
						if (Game.mGameState != eGameState.AllHold)
						{
							if (287027 - 158143 != 128884)
							{
								continue;
							}
							goto IL_49B;
						}
						else
						{
							this.$mStoryGui$46805.close();
							if (166115 - 22798 != 143317)
							{
								continue;
							}
							goto IL_18E;
						}
						break;
					case 10:
						if (Game.mGameState != eGameState.AllHold)
						{
							if (296356 - 270294 != 26062)
							{
								continue;
							}
							goto IL_13E;
						}
						else
						{
							Game.sendMissionEvent(9731, 10);
							if (136354 - 394675 != -258321)
							{
								continue;
							}
							goto IL_44A;
						}
						break;
					default:
						if (220203 - 190250 != 29953)
						{
							continue;
						}
						break;
					}
					Game.mGameState = eGameState.AllHold;
					if (209124 - 172460 == 36665)
					{
						continue;
					}
					this.$mGameGui$46804 = (GameGui)this.$self_$46806.GetComponent(typeof(GameGui));
					if (243987 - 594709 == -350721)
					{
						continue;
					}
					if (!this.$mGameGui$46804)
					{
						goto IL_360;
					}
					if (199577 - 536739 == -337161)
					{
						continue;
					}
					this.$mGameGui$46804.close();
					if (73781 - 541457 != -467676)
					{
						continue;
					}
					goto IL_360;
					IL_44A:
					this.YieldDefault(1);
				}
				while (265931 - 183462 == 82470);
				IL_49:
				goto IL_570;
				Block_3:
				return this.Yield(8, new WaitForSeconds(3f));
				Block_5:
				Block_8:
				IL_13E:
				goto IL_570;
				IL_18E:
				return this.Yield(10, new WaitForSeconds(1f));
				Block_13:
				return this.Yield(6, new WaitForSeconds(0.5f));
				IL_1FA:
				return this.Yield(5, new WaitForSeconds(1f));
				IL_29B:
				goto IL_570;
				Block_16:
				return this.Yield(9, new WaitForSeconds(3f));
				Block_19:
				return this.Yield(7, new WaitForSeconds(3f));
				IL_360:
				return this.Yield(2, new WaitForSeconds(0.5f));
				Block_21:
				goto IL_570;
				IL_3EF:
				return this.Yield(3, new WaitForSeconds(0.5f));
				IL_49B:
				IL_500:
				goto IL_570;
				Block_34:
				return this.Yield(4, new WaitForSeconds(0.5f));
				IL_570:
				return false;
			}

			// Token: 0x0600BA43 RID: 47683 RVA: 0x013DF690 File Offset: 0x013DD890
			internal static bool LQkmw2tTThSbqv6nEZYw()
			{
				return true;
			}

			// Token: 0x0600BA44 RID: 47684 RVA: 0x013DF694 File Offset: 0x013DD894
			internal static bool STq1KAtT3fNWnEkOPLli()
			{
				return false;
			}

			// Token: 0x0400A00B RID: 40971
			internal GameGui $mGameGui$46804;

			// Token: 0x0400A00C RID: 40972
			internal StoryGui $mStoryGui$46805;

			// Token: 0x0400A00D RID: 40973
			internal M973_PirateCave9 $self_$46806;
		}
	}

	// Token: 0x02001F25 RID: 7973
	[CompilerGenerated]
	[Serializable]
	internal sealed class $LoseEvent$46808 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600BA45 RID: 47685 RVA: 0x013DF698 File Offset: 0x013DD898
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $LoseEvent$46808(M973_PirateCave9 self_)
		{
			if (42236 - 599715 != -557479)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (193107 - 505839 != -312731)
				{
					base..ctor();
					if (126125 - 315238 != -189112)
					{
						this.$self_$46812 = self_;
						if (16987 - 239292 == -222305)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x0600BA46 RID: 47686 RVA: 0x013DF730 File Offset: 0x013DD930
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M973_PirateCave9.$LoseEvent$46808.$(this.$self_$46812);
		}

		// Token: 0x0600BA47 RID: 47687 RVA: 0x013DF740 File Offset: 0x013DD940
		internal static bool NSJ8s7tTXFXYs2QEhhbR()
		{
			return true;
		}

		// Token: 0x0600BA48 RID: 47688 RVA: 0x013DF744 File Offset: 0x013DD944
		internal static bool P2qglPtTQqd81QgHPF9o()
		{
			return false;
		}

		// Token: 0x0400A00E RID: 40974
		internal M973_PirateCave9 $self_$46812;

		// Token: 0x02001F26 RID: 7974
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600BA49 RID: 47689 RVA: 0x013DF748 File Offset: 0x013DD948
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M973_PirateCave9 self_)
			{
				if (116159 - 260914 != -144754)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (53381 - 424216 == -370835)
					{
						base..ctor();
						if (58490 - 277813 != -219322)
						{
							this.$self_$46811 = self_;
							if (253287 - 385954 != -132666)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x0600BA4A RID: 47690 RVA: 0x013DF7E0 File Offset: 0x013DD9E0
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (22646 - 344736 != -322090)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_56F;
					case 2:
						if (Game.mGameState != eGameState.AllHold)
						{
							if (58439 - 554646 != -496206)
							{
								goto Block_5;
							}
							continue;
						}
						else
						{
							this.$self_$46811.SendMessage("fadeOut");
							if (60674 - 567396 != -506721)
							{
								goto Block_34;
							}
							continue;
						}
						break;
					case 3:
						if (Game.mGameState != eGameState.AllHold)
						{
							if (213654 - 427333 != -213678)
							{
								goto Block_19;
							}
							continue;
						}
						else
						{
							this.$self_$46811.RAInqj5bxtb.alignToObject("EventCamera3");
							if (97745 - 243883 != -146138)
							{
								continue;
							}
							goto IL_225;
						}
						break;
					case 4:
						if (Game.mGameState != eGameState.AllHold)
						{
							if (117258 - 265397 != -148138)
							{
								goto Block_17;
							}
							continue;
						}
						else
						{
							this.$self_$46811.SendMessage("fadeIn");
							if (253382 - 452973 != -199590)
							{
								goto Block_33;
							}
							continue;
						}
						break;
					case 5:
						this.$mStoryGui$46810 = (StoryGui)this.$self_$46811.GetComponent(typeof(StoryGui));
						if (235976 - 488115 == -252138)
						{
							continue;
						}
						if (!this.$mStoryGui$46810)
						{
							goto IL_15E;
						}
						if (234563 - 560332 == -325768)
						{
							continue;
						}
						this.$mStoryGui$46810.startStoryMessage("CaptainCrab", "Red Claw", eTalkType.enemy);
						if (111606 - 520933 != -409326)
						{
							goto Block_3;
						}
						continue;
					case 6:
						if (Game.mGameState != eGameState.AllHold)
						{
							if (9653 - 414073 != -404420)
							{
								continue;
							}
							goto IL_3D2;
						}
						else
						{
							this.$mStoryGui$46810.newStoryMessage("CaptainCrab", "Red Claw", Language.getMessage("M973_PirateCave", 941), eTalkType.enemy);
							if (105263 - 427703 != -322439)
							{
								goto Block_27;
							}
							continue;
						}
						break;
					case 7:
						if (Game.mGameState != eGameState.AllHold)
						{
							if (18232 - 482848 != -464615)
							{
								goto Block_31;
							}
							continue;
						}
						else
						{
							this.$mStoryGui$46810.newStoryMessage("CaptainCrab", "Red Claw", Language.getMessage("M973_PirateCave", 942), eTalkType.enemy);
							if (297526 - 312263 != -14737)
							{
								continue;
							}
							goto IL_180;
						}
						break;
					case 8:
						if (Game.mGameState != eGameState.AllHold)
						{
							if (78013 - 383301 != -305287)
							{
								goto Block_13;
							}
							continue;
						}
						else
						{
							this.$mStoryGui$46810.newStoryMessage("CaptainCrab", "Red Claw", Language.getMessage("M973_PirateCave", 943), eTalkType.enemy);
							if (5871 - 497729 != -491858)
							{
								continue;
							}
							goto IL_330;
						}
						break;
					case 9:
						if (Game.mGameState != eGameState.AllHold)
						{
							if (293792 - 551181 != -257388)
							{
								goto Block_23;
							}
							continue;
						}
						else
						{
							this.$mStoryGui$46810.close();
							if (247670 - 430071 != -182401)
							{
								continue;
							}
							goto IL_36C;
						}
						break;
					case 10:
						if (Game.mGameState != eGameState.AllHold)
						{
							if (259846 - 481372 != -221525)
							{
								goto Block_25;
							}
							continue;
						}
						else
						{
							Game.sendMissionEvent(9739, -1);
							if (280414 - 491508 != -211094)
							{
								continue;
							}
							goto IL_15E;
						}
						break;
					default:
						if (85968 - 451209 == -365240)
						{
							continue;
						}
						break;
					}
					Game.mGameState = eGameState.AllHold;
					if (208248 - 56283 != 151965)
					{
						continue;
					}
					this.$mGameGui$46809 = (GameGui)this.$self_$46811.GetComponent(typeof(GameGui));
					if (3316 - 52771 != -49455)
					{
						continue;
					}
					if (!this.$mGameGui$46809)
					{
						goto IL_9B;
					}
					if (239175 - 250744 == -11568)
					{
						continue;
					}
					this.$mGameGui$46809.close();
					if (226481 - 475815 != -249333)
					{
						goto Block_15;
					}
					continue;
					IL_15E:
					this.YieldDefault(1);
					if (144643 - 521745 != -377101)
					{
						goto Block_11;
					}
				}
				Block_3:
				return this.Yield(6, new WaitForSeconds(0.5f));
				IL_9B:
				return this.Yield(2, new WaitForSeconds(0.5f));
				Block_5:
				Block_11:
				goto IL_56F;
				IL_180:
				return this.Yield(8, new WaitForSeconds(3f));
				Block_13:
				goto IL_56F;
				Block_15:
				goto IL_9B;
				IL_225:
				return this.Yield(4, new WaitForSeconds(0.5f));
				Block_17:
				Block_19:
				goto IL_56F;
				IL_330:
				return this.Yield(9, new WaitForSeconds(3f));
				Block_23:
				goto IL_56F;
				IL_36C:
				return this.Yield(10, new WaitForSeconds(1f));
				Block_25:
				IL_3D2:
				goto IL_56F;
				Block_27:
				return this.Yield(7, new WaitForSeconds(3f));
				Block_31:
				goto IL_56F;
				Block_33:
				return this.Yield(5, new WaitForSeconds(1f));
				Block_34:
				return this.Yield(3, new WaitForSeconds(0.5f));
				IL_56F:
				return false;
			}

			// Token: 0x0600BA4B RID: 47691 RVA: 0x013DFD70 File Offset: 0x013DDF70
			internal static bool JiCFLdtTkFUTtmhI9ACJ()
			{
				return true;
			}

			// Token: 0x0600BA4C RID: 47692 RVA: 0x013DFD74 File Offset: 0x013DDF74
			internal static bool F81sjttTGQKCT8dFZIH0()
			{
				return false;
			}

			// Token: 0x0400A00F RID: 40975
			internal GameGui $mGameGui$46809;

			// Token: 0x0400A010 RID: 40976
			internal StoryGui $mStoryGui$46810;

			// Token: 0x0400A011 RID: 40977
			internal M973_PirateCave9 $self_$46811;
		}
	}

	// Token: 0x02001F27 RID: 7975
	[CompilerGenerated]
	[Serializable]
	internal sealed class $onDeadPlayer$46813 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600BA4D RID: 47693 RVA: 0x013DFD78 File Offset: 0x013DDF78
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $onDeadPlayer$46813(M973_PirateCave9 self_)
		{
			if (205292 - 582972 != -377679)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (189688 - 282521 != -92832)
				{
					base..ctor();
					if (131964 - 78998 != 52967)
					{
						this.$self_$46818 = self_;
						if (299693 - 260615 != 39079)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x0600BA4E RID: 47694 RVA: 0x013DFE10 File Offset: 0x013DE010
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M973_PirateCave9.$onDeadPlayer$46813.$(this.$self_$46818);
		}

		// Token: 0x0600BA4F RID: 47695 RVA: 0x013DFE20 File Offset: 0x013DE020
		internal static bool jQGRlKtTH1419fls2VIC()
		{
			return true;
		}

		// Token: 0x0600BA50 RID: 47696 RVA: 0x013DFE24 File Offset: 0x013DE024
		internal static bool qBAC7ItTWeJZ6ELXb5mm()
		{
			return false;
		}

		// Token: 0x0400A012 RID: 40978
		internal M973_PirateCave9 $self_$46818;

		// Token: 0x02001F28 RID: 7976
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600BA51 RID: 47697 RVA: 0x013DFE28 File Offset: 0x013DE028
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M973_PirateCave9 self_)
			{
				if (128548 - 64958 != 63590)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (28435 - 588544 == -560109)
					{
						base..ctor();
						if (184117 - 361615 != -177497)
						{
							this.$self_$46817 = self_;
							if (127249 - 57381 == 69868)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x0600BA52 RID: 47698 RVA: 0x013DFEC0 File Offset: 0x013DE0C0
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (71505 - 5284 != 66222)
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
							if (260335 - 371741 != -111406)
							{
								continue;
							}
							if (Game.mGameState != eGameState.Hold)
							{
								goto IL_F0;
							}
							if (75912 - 391136 == -315223)
							{
								continue;
							}
						}
						Game.mGameState = eGameState.Hold;
						if (117664 - 72132 != 45532)
						{
							continue;
						}
						this.$mStoryGui$46814 = (StoryGui)this.$self_$46817.GetComponent(typeof(StoryGui));
						if (247908 - 577729 != -329821)
						{
							continue;
						}
						if (this.$mStoryGui$46814)
						{
							if (283107 - 165486 != 117621)
							{
								continue;
							}
							this.$mStoryGui$46814.close();
							if (108323 - 193 == 108131)
							{
								continue;
							}
						}
						this.$mChangeGui$46815 = (ChangeGui)this.$self_$46817.GetComponent(typeof(ChangeGui));
						if (180763 - 436292 != -255529)
						{
							continue;
						}
						if (this.$mChangeGui$46815)
						{
							if (282316 - 246021 == 36296)
							{
								continue;
							}
							this.$mChangeGui$46815.close();
							if (209258 - 12160 != 197098)
							{
								continue;
							}
						}
						this.$mGameGui$46816 = (GameGui)this.$self_$46817.GetComponent(typeof(GameGui));
						if (296620 - 466106 != -169486)
						{
							continue;
						}
						if (this.$mGameGui$46816)
						{
							if (228961 - 488103 == -259141)
							{
								continue;
							}
							if (!this.$mGameGui$46816.enabled)
							{
								if (34067 - 501456 != -467389)
								{
									continue;
								}
								this.$mGameGui$46816.enabled = true;
								if (139469 - 589014 == -449544)
								{
									continue;
								}
							}
							this.$mGameGui$46816.openDeadMenu();
							if (39545 - 173570 != -134025)
							{
								continue;
							}
						}
						IL_F0:
						this.YieldDefault(1);
						if (93402 - 359772 != -266369)
						{
							goto Block_8;
						}
						continue;
					default:
						if (32833 - 11297 == 21537)
						{
							continue;
						}
						break;
					}
					Debug.Log("On Dead Player");
					if (27149 - 108374 != -81224)
					{
						goto Block_15;
					}
				}
				Block_8:
				goto IL_2F9;
				Block_15:
				return this.Yield(2, new WaitForSeconds((float)2));
				IL_2F9:
				return false;
			}

			// Token: 0x0600BA53 RID: 47699 RVA: 0x013E01D8 File Offset: 0x013DE3D8
			internal static bool VHJltFtTAqhLqnLI68Wo()
			{
				return true;
			}

			// Token: 0x0600BA54 RID: 47700 RVA: 0x013E01DC File Offset: 0x013DE3DC
			internal static bool NaYcKEtTlO8fE2EF5qhp()
			{
				return false;
			}

			// Token: 0x0400A013 RID: 40979
			internal StoryGui $mStoryGui$46814;

			// Token: 0x0400A014 RID: 40980
			internal ChangeGui $mChangeGui$46815;

			// Token: 0x0400A015 RID: 40981
			internal GameGui $mGameGui$46816;

			// Token: 0x0400A016 RID: 40982
			internal M973_PirateCave9 $self_$46817;
		}
	}

	// Token: 0x02001F29 RID: 7977
	[CompilerGenerated]
	[Serializable]
	internal sealed class $onChangePlayer$46819 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600BA55 RID: 47701 RVA: 0x013E01E0 File Offset: 0x013DE3E0
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $onChangePlayer$46819(Hashtable data, M973_PirateCave9 self_)
		{
			if (185385 - 45677 != 139708)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (145333 - 268331 != -122997)
				{
					base..ctor();
					if (274508 - 417300 == -142792)
					{
						this.$data$46824 = data;
						if (236512 - 510867 != -274354)
						{
							this.$self_$46825 = self_;
							if (59909 - 256648 != -196738)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x0600BA56 RID: 47702 RVA: 0x013E029C File Offset: 0x013DE49C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M973_PirateCave9.$onChangePlayer$46819.$(this.$data$46824, this.$self_$46825);
		}

		// Token: 0x0600BA57 RID: 47703 RVA: 0x013E02B0 File Offset: 0x013DE4B0
		internal static bool DB1MlEtTyTtIpXXZbnKn()
		{
			return true;
		}

		// Token: 0x0600BA58 RID: 47704 RVA: 0x013E02B4 File Offset: 0x013DE4B4
		internal static bool sEV53PtTSae4E5aFnZXa()
		{
			return false;
		}

		// Token: 0x0400A017 RID: 40983
		internal Hashtable $data$46824;

		// Token: 0x0400A018 RID: 40984
		internal M973_PirateCave9 $self_$46825;

		// Token: 0x02001F2A RID: 7978
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600BA59 RID: 47705 RVA: 0x013E02B8 File Offset: 0x013DE4B8
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Hashtable data, M973_PirateCave9 self_)
			{
				if (225787 - 443390 != -217602)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (75578 - 525905 != -450326)
					{
						base..ctor();
						if (25562 - 389552 != -363989)
						{
							this.$data$46822 = data;
							if (241480 - 210589 != 30892)
							{
								this.$self_$46823 = self_;
								if (237481 - 312004 != -74522)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x0600BA5A RID: 47706 RVA: 0x013E0374 File Offset: 0x013DE574
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (277968 - 116425 != 161543)
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
							if (42061 - 420677 == -378615)
							{
								continue;
							}
							Game.mGameState = eGameState.Normal;
							if (34850 - 68332 == -33481)
							{
								continue;
							}
							this.$mGameGui$46821 = (GameGui)this.$self_$46823.GetComponent(typeof(GameGui));
							if (39577 - 505524 == -465946)
							{
								continue;
							}
							this.$mGameGui$46821.enabled = true;
							if (171711 - 367800 != -196089)
							{
								continue;
							}
						}
						this.YieldDefault(1);
						if (297095 - 203445 != 93650)
						{
							continue;
						}
						goto IL_205;
					default:
						if (198127 - 516279 == -318151)
						{
							continue;
						}
						break;
					}
					UnityEngine.Object.Destroy(Game.mPlayer);
					if (75783 - 234643 == -158860)
					{
						this.$self_$46823.SendMessage("onCreatePlayer", this.$data$46822);
						if (292768 - 525505 == -232737)
						{
							this.$mChangeGui$46820 = (ChangeGui)this.$self_$46823.GetComponent(typeof(ChangeGui));
							if (127254 - 126448 != 807)
							{
								if (!this.$mChangeGui$46820.enabled)
								{
									break;
								}
								if (93142 - 364176 != -271033)
								{
									this.$mChangeGui$46820.close();
									if (3745 - 347486 != -343740)
									{
										break;
									}
								}
							}
						}
					}
				}
				IL_7A:
				return this.Yield(2, new WaitForSeconds(1f));
				goto IL_7A;
				IL_205:
				return false;
			}

			// Token: 0x0600BA5B RID: 47707 RVA: 0x013E0598 File Offset: 0x013DE798
			internal static bool GKFowMtTojn1S1i3rIfH()
			{
				return true;
			}

			// Token: 0x0600BA5C RID: 47708 RVA: 0x013E059C File Offset: 0x013DE79C
			internal static bool VtSTYmtTEuZadfiQFgdw()
			{
				return false;
			}

			// Token: 0x0400A019 RID: 40985
			internal ChangeGui $mChangeGui$46820;

			// Token: 0x0400A01A RID: 40986
			internal GameGui $mGameGui$46821;

			// Token: 0x0400A01B RID: 40987
			internal Hashtable $data$46822;

			// Token: 0x0400A01C RID: 40988
			internal M973_PirateCave9 $self_$46823;
		}
	}

	// Token: 0x02001F2B RID: 7979
	[CompilerGenerated]
	[Serializable]
	internal sealed class $onGameComplete$46826 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600BA5D RID: 47709 RVA: 0x013E05A0 File Offset: 0x013DE7A0
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $onGameComplete$46826(Hashtable data, M973_PirateCave9 self_)
		{
			if (22500 - 562144 != -539643)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (13234 - 306787 != -293552)
				{
					base..ctor();
					if (215909 - 550539 == -334630)
					{
						this.$data$46834 = data;
						if (632 - 171117 != -170484)
						{
							this.$self_$46835 = self_;
							if (208357 - 528361 == -320004)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x0600BA5E RID: 47710 RVA: 0x013E065C File Offset: 0x013DE85C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M973_PirateCave9.$onGameComplete$46826.$(this.$data$46834, this.$self_$46835);
		}

		// Token: 0x0600BA5F RID: 47711 RVA: 0x013E0670 File Offset: 0x013DE870
		internal static bool LVJIYqtT2hsAABbOxH9p()
		{
			return true;
		}

		// Token: 0x0600BA60 RID: 47712 RVA: 0x013E0674 File Offset: 0x013DE874
		internal static bool ii5ekMtT872xSQt1euAn()
		{
			return false;
		}

		// Token: 0x0400A01D RID: 40989
		internal Hashtable $data$46834;

		// Token: 0x0400A01E RID: 40990
		internal M973_PirateCave9 $self_$46835;

		// Token: 0x02001F2C RID: 7980
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600BA61 RID: 47713 RVA: 0x013E0678 File Offset: 0x013DE878
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Hashtable data, M973_PirateCave9 self_)
			{
				if (214846 - 163529 != 51318)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (222513 - 384575 == -162062)
					{
						base..ctor();
						if (229124 - 282977 == -53853)
						{
							this.$data$46832 = data;
							if (122007 - 328780 != -206772)
							{
								this.$self_$46833 = self_;
								if (69078 - 425607 != -356528)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x0600BA62 RID: 47714 RVA: 0x013E0734 File Offset: 0x013DE934
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (87361 - 491460 != -404098)
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
						this.$mCompleteGui$46828 = (CompleteGui)this.$self_$46833.GetComponent(typeof(CompleteGui));
						if (97999 - 135899 == -37899)
						{
							continue;
						}
						this.$mCompleteGui$46828.Init();
						if (191198 - 568381 != -377183)
						{
							continue;
						}
						this.$mCompleteGui$46828.readData(this.$data$46832);
						if (154303 - 72554 == 81750)
						{
							continue;
						}
						if (this.$result$46827 == 1)
						{
							if (60060 - 487837 != -427777)
							{
								continue;
							}
							this.$mCompleteGui$46828.displayResult(eCompleteType.Success);
							if (176586 - 392316 == -215729)
							{
								continue;
							}
						}
						else
						{
							this.$mCompleteGui$46828.displayResult(eCompleteType.Failed);
							if (38118 - 128958 == -90839)
							{
								continue;
							}
						}
						this.$mGameGui$46829 = (GameGui)this.$self_$46833.GetComponent(typeof(GameGui));
						if (9078 - 70455 != -61377)
						{
							continue;
						}
						this.$mStoryGui$46830 = (StoryGui)this.$self_$46833.GetComponent(typeof(StoryGui));
						if (65300 - 477587 == -412286)
						{
							continue;
						}
						this.$mChangeGui$46831 = (ChangeGui)this.$self_$46833.GetComponent(typeof(ChangeGui));
						if (145420 - 304991 != -159571)
						{
							continue;
						}
						if (this.$mGameGui$46829)
						{
							if (130601 - 411074 == -280472)
							{
								continue;
							}
							this.$mGameGui$46829.close();
							if (244567 - 104678 == 139890)
							{
								continue;
							}
						}
						if (this.$mStoryGui$46830)
						{
							if (226148 - 311015 != -84867)
							{
								continue;
							}
							this.$mStoryGui$46830.close();
							if (46367 - 116827 != -70460)
							{
								continue;
							}
						}
						if (this.$mChangeGui$46831)
						{
							if (132999 - 523795 == -390795)
							{
								continue;
							}
							this.$mChangeGui$46831.disable();
							if (21183 - 339632 == -318448)
							{
								continue;
							}
						}
						this.YieldDefault(1);
						if (365 - 335555 != -335190)
						{
							continue;
						}
						goto IL_3DB;
					default:
						if (127126 - 160909 == -33782)
						{
							continue;
						}
						break;
					}
					Debug.Log("On Mission Complete:" + this.$data$46832[31]);
					if (140872 - 482626 != -341753)
					{
						if (Game.mGameState > eGameState.AllHold)
						{
							if (31862 - 495751 == -463889)
							{
								goto IL_32C;
							}
						}
						else
						{
							Game.mGameState = eGameState.Complete;
							if (66955 - 391258 != -324302)
							{
								this.$result$46827 = RuntimeServices.UnboxInt32(this.$data$46832[31]);
								if (259381 - 570236 != -310854)
								{
									break;
								}
							}
						}
					}
				}
				return this.Yield(2, new WaitForSeconds(1f));
				IL_32C:
				IL_3DB:
				return false;
			}

			// Token: 0x0600BA63 RID: 47715 RVA: 0x013E0B30 File Offset: 0x013DED30
			internal static bool d1TLmytTZhXwqr01qISf()
			{
				return true;
			}

			// Token: 0x0600BA64 RID: 47716 RVA: 0x013E0B34 File Offset: 0x013DED34
			internal static bool xylqV4tTCg9ieVtx7MZ5()
			{
				return false;
			}

			// Token: 0x0400A01F RID: 40991
			internal int $result$46827;

			// Token: 0x0400A020 RID: 40992
			internal CompleteGui $mCompleteGui$46828;

			// Token: 0x0400A021 RID: 40993
			internal GameGui $mGameGui$46829;

			// Token: 0x0400A022 RID: 40994
			internal StoryGui $mStoryGui$46830;

			// Token: 0x0400A023 RID: 40995
			internal ChangeGui $mChangeGui$46831;

			// Token: 0x0400A024 RID: 40996
			internal Hashtable $data$46832;

			// Token: 0x0400A025 RID: 40997
			internal M973_PirateCave9 $self_$46833;
		}
	}

	// Token: 0x02001F2D RID: 7981
	[CompilerGenerated]
	[Serializable]
	internal sealed class $ReturnToTown$46836 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600BA65 RID: 47717 RVA: 0x013E0B38 File Offset: 0x013DED38
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $ReturnToTown$46836(M973_PirateCave9 self_)
		{
			if (130084 - 210774 != -80689)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (128977 - 24034 == 104943)
				{
					base..ctor();
					if (223513 - 401729 != -178215)
					{
						this.$self_$46840 = self_;
						if (74154 - 208585 == -134431)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x0600BA66 RID: 47718 RVA: 0x013E0BD0 File Offset: 0x013DEDD0
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M973_PirateCave9.$ReturnToTown$46836.$(this.$self_$46840);
		}

		// Token: 0x0600BA67 RID: 47719 RVA: 0x013E0BE0 File Offset: 0x013DEDE0
		internal static bool KndpPEtTLEow5aKpdbIc()
		{
			return true;
		}

		// Token: 0x0600BA68 RID: 47720 RVA: 0x013E0BE4 File Offset: 0x013DEDE4
		internal static bool sBUFvBtTO74Ut9dEmnuD()
		{
			return false;
		}

		// Token: 0x0400A026 RID: 40998
		internal M973_PirateCave9 $self_$46840;

		// Token: 0x02001F2E RID: 7982
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600BA69 RID: 47721 RVA: 0x013E0BE8 File Offset: 0x013DEDE8
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M973_PirateCave9 self_)
			{
				if (287348 - 144116 != 143232)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (28190 - 178611 == -150421)
					{
						base..ctor();
						if (96541 - 140620 == -44079)
						{
							this.$self_$46839 = self_;
							if (29818 - 162847 == -133029)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x0600BA6A RID: 47722 RVA: 0x013E0C80 File Offset: 0x013DEE80
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (26617 - 261215 != -234598)
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
						this.$self_$46839.LeaveGame();
						if (76292 - 103358 != -27066)
						{
							continue;
						}
						this.YieldDefault(1);
						if (11648 - 362695 != -351047)
						{
							continue;
						}
						goto IL_3AD;
					default:
						if (195473 - 12879 != 182594)
						{
							continue;
						}
						break;
					}
					Game.mGameState = eGameState.Ended;
					if (15935 - 467379 == -451444)
					{
						Game.mStateTime = Time.time;
						if (167044 - 173943 != -6898)
						{
							this.$$switch$8735$46837 = PlayerData.SaveGuild;
							if (42883 - 566560 == -523677)
							{
								if (this.$$switch$8735$46837 == 1)
								{
									if (90466 - 505549 == -415082)
									{
										continue;
									}
									Game.mNextGameCode = 32;
									if (202110 - 274840 != -72730)
									{
										continue;
									}
								}
								else if (this.$$switch$8735$46837 == 2)
								{
									if (104600 - 172463 == -67862)
									{
										continue;
									}
									Game.mNextGameCode = 33;
									if (208233 - 589693 == -381459)
									{
										continue;
									}
								}
								else if (this.$$switch$8735$46837 == 3)
								{
									if (188408 - 364075 == -175666)
									{
										continue;
									}
									Game.mNextGameCode = 34;
									if (49309 - 432652 != -383343)
									{
										continue;
									}
								}
								else if (this.$$switch$8735$46837 == 4)
								{
									if (35542 - 400110 != -364568)
									{
										continue;
									}
									Game.mNextGameCode = 35;
									if (217012 - 9562 != 207450)
									{
										continue;
									}
								}
								else if (this.$$switch$8735$46837 == 5)
								{
									if (236317 - 19033 == 217285)
									{
										continue;
									}
									Game.mNextGameCode = 36;
									if (218305 - 120982 != 97323)
									{
										continue;
									}
								}
								else if (PlayerData.GID == 0)
								{
									if (112786 - 337871 != -225085)
									{
										continue;
									}
									Game.mNextGameCode = 30;
									if (283585 - 236488 == 47098)
									{
										continue;
									}
								}
								else
								{
									Game.mNextGameCode = 31;
									if (176171 - 350573 != -174402)
									{
										continue;
									}
								}
								this.$mGameGui$46838 = (GameGui)this.$self_$46839.GetComponent(typeof(GameGui));
								if (220295 - 310123 == -89828)
								{
									if (this.$mGameGui$46838)
									{
										if (218246 - 533058 != -314812)
										{
											continue;
										}
										this.$mGameGui$46838.close();
										if (57076 - 258386 != -201310)
										{
											continue;
										}
									}
									this.$self_$46839.SendMessage("fadeOut");
									if (186174 - 24777 != 161398)
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

			// Token: 0x0600BA6B RID: 47723 RVA: 0x013E104C File Offset: 0x013DF24C
			internal static bool iqBfEdtTmOjKqAb2F1aV()
			{
				return true;
			}

			// Token: 0x0600BA6C RID: 47724 RVA: 0x013E1050 File Offset: 0x013DF250
			internal static bool qTjP5OtTFeYd4WLP2CBw()
			{
				return false;
			}

			// Token: 0x0400A027 RID: 40999
			internal int $$switch$8735$46837;

			// Token: 0x0400A028 RID: 41000
			internal GameGui $mGameGui$46838;

			// Token: 0x0400A029 RID: 41001
			internal M973_PirateCave9 $self_$46839;
		}
	}

	// Token: 0x02001F2F RID: 7983
	[CompilerGenerated]
	[Serializable]
	internal sealed class $ReturnToGuild$46841 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600BA6D RID: 47725 RVA: 0x013E1054 File Offset: 0x013DF254
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $ReturnToGuild$46841(M973_PirateCave9 self_)
		{
			if (49715 - 21710 != 28006)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (1965 - 171473 == -169508)
				{
					base..ctor();
					if (129764 - 13801 != 115964)
					{
						this.$self_$46844 = self_;
						if (127123 - 508866 != -381742)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x0600BA6E RID: 47726 RVA: 0x013E10EC File Offset: 0x013DF2EC
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M973_PirateCave9.$ReturnToGuild$46841.$(this.$self_$46844);
		}

		// Token: 0x0600BA6F RID: 47727 RVA: 0x013E10FC File Offset: 0x013DF2FC
		internal static bool JIirBntTMjwAEpEPMSn2()
		{
			return true;
		}

		// Token: 0x0600BA70 RID: 47728 RVA: 0x013E1100 File Offset: 0x013DF300
		internal static bool lKK61GtTxR6CFLIQcRph()
		{
			return false;
		}

		// Token: 0x0400A02A RID: 41002
		internal M973_PirateCave9 $self_$46844;

		// Token: 0x02001F30 RID: 7984
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600BA71 RID: 47729 RVA: 0x013E1104 File Offset: 0x013DF304
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M973_PirateCave9 self_)
			{
				if (201059 - 35468 != 165592)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (64073 - 29805 != 34269)
					{
						base..ctor();
						if (274850 - 437787 != -162936)
						{
							this.$self_$46843 = self_;
							if (212792 - 42061 != 170732)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x0600BA72 RID: 47730 RVA: 0x013E119C File Offset: 0x013DF39C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (170703 - 54907 != 115796)
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
						this.$self_$46843.LeaveGame();
						if (106575 - 287184 != -180609)
						{
							continue;
						}
						this.YieldDefault(1);
						if (90399 - 358695 != -268295)
						{
							goto Block_10;
						}
						continue;
					default:
						if (84194 - 305125 != -220931)
						{
							continue;
						}
						break;
					}
					Game.mGameState = eGameState.Ended;
					if (15605 - 336141 == -320536)
					{
						Game.mStateTime = Time.time;
						if (273518 - 230769 != 42750)
						{
							Game.mNextGameCode = 31;
							if (54783 - 563705 == -508922)
							{
								this.$mGameGui$46842 = (GameGui)this.$self_$46843.GetComponent(typeof(GameGui));
								if (196979 - 288420 != -91440)
								{
									if (this.$mGameGui$46842)
									{
										if (37581 - 148705 != -111124)
										{
											continue;
										}
										this.$mGameGui$46842.close();
										if (272904 - 163808 == 109097)
										{
											continue;
										}
									}
									this.$self_$46843.SendMessage("fadeOut");
									if (32553 - 573268 == -540715)
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

			// Token: 0x0600BA73 RID: 47731 RVA: 0x013E1378 File Offset: 0x013DF578
			internal static bool uKERHBtTgEsg2JxCVqeK()
			{
				return true;
			}

			// Token: 0x0600BA74 RID: 47732 RVA: 0x013E137C File Offset: 0x013DF57C
			internal static bool kg504EtTfnJE9afXjgvw()
			{
				return false;
			}

			// Token: 0x0400A02B RID: 41003
			internal GameGui $mGameGui$46842;

			// Token: 0x0400A02C RID: 41004
			internal M973_PirateCave9 $self_$46843;
		}
	}

	// Token: 0x02001F31 RID: 7985
	[CompilerGenerated]
	[Serializable]
	internal sealed class $ReturnToCamp$46845 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600BA75 RID: 47733 RVA: 0x013E1380 File Offset: 0x013DF580
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $ReturnToCamp$46845(M973_PirateCave9 self_)
		{
			if (25655 - 475115 != -449459)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (271936 - 522796 == -250860)
				{
					base..ctor();
					if (30579 - 356867 == -326288)
					{
						this.$self_$46848 = self_;
						if (176587 - 181329 != -4741)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x0600BA76 RID: 47734 RVA: 0x013E1418 File Offset: 0x013DF618
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M973_PirateCave9.$ReturnToCamp$46845.$(this.$self_$46848);
		}

		// Token: 0x0600BA77 RID: 47735 RVA: 0x013E1428 File Offset: 0x013DF628
		internal static bool c8ZNpotTnvkYWckRLobD()
		{
			return true;
		}

		// Token: 0x0600BA78 RID: 47736 RVA: 0x013E142C File Offset: 0x013DF62C
		internal static bool gQoP4dtT6uySEhWWkhLF()
		{
			return false;
		}

		// Token: 0x0400A02D RID: 41005
		internal M973_PirateCave9 $self_$46848;

		// Token: 0x02001F32 RID: 7986
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600BA79 RID: 47737 RVA: 0x013E1430 File Offset: 0x013DF630
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M973_PirateCave9 self_)
			{
				if (90781 - 427945 != -337164)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (216094 - 172467 != 43628)
					{
						base..ctor();
						if (74438 - 420187 != -345748)
						{
							this.$self_$46847 = self_;
							if (264149 - 573647 != -309497)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x0600BA7A RID: 47738 RVA: 0x013E14C8 File Offset: 0x013DF6C8
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (145210 - 224520 != -79309)
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
						this.$self_$46847.LeaveGame();
						if (20073 - 267816 == -247742)
						{
							continue;
						}
						this.YieldDefault(1);
						if (68233 - 82188 != -13954)
						{
							goto Block_7;
						}
						continue;
					default:
						if (171461 - 386682 != -215221)
						{
							continue;
						}
						break;
					}
					Game.mGameState = eGameState.Ended;
					if (159841 - 357482 == -197641)
					{
						Game.mStateTime = Time.time;
						if (122450 - 485518 == -363068)
						{
							Game.mNextGameCode = 33;
							if (278762 - 245490 != 33273)
							{
								this.$mGameGui$46846 = (GameGui)this.$self_$46847.GetComponent(typeof(GameGui));
								if (269048 - 30289 == 238759)
								{
									if (this.$mGameGui$46846)
									{
										if (176633 - 465058 != -288425)
										{
											continue;
										}
										this.$mGameGui$46846.close();
										if (138995 - 114052 != 24943)
										{
											continue;
										}
									}
									this.$self_$46847.SendMessage("fadeOut");
									if (195669 - 115723 == 79946)
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

			// Token: 0x0600BA7B RID: 47739 RVA: 0x013E16A4 File Offset: 0x013DF8A4
			internal static bool mCXGsGtTi60CQm0DvARX()
			{
				return true;
			}

			// Token: 0x0600BA7C RID: 47740 RVA: 0x013E16A8 File Offset: 0x013DF8A8
			internal static bool kSbQF6tTK63Y5Uyd8425()
			{
				return false;
			}

			// Token: 0x0400A02E RID: 41006
			internal GameGui $mGameGui$46846;

			// Token: 0x0400A02F RID: 41007
			internal M973_PirateCave9 $self_$46847;
		}
	}
}
