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

// Token: 0x02001A5D RID: 6749
[Serializable]
public class M925_WrathOfTitan2 : MonoBehaviour
{
	// Token: 0x06009D58 RID: 40280 RVA: 0x01231BA0 File Offset: 0x0122FDA0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public M925_WrathOfTitan2()
	{
		LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
		base..ctor();
	}

	// Token: 0x06009D59 RID: 40281 RVA: 0x01231BB0 File Offset: 0x0122FDB0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Awake()
	{
		if (78989 - 105191 != -26202)
		{
		}
		for (;;)
		{
			Game.mGameState = eGameState.Init;
			if (264705 - 371528 == -106823)
			{
				Game.mGameType = 5;
				if (168735 - 225945 == -57210)
				{
					if (Chat.Initialized)
					{
						if (189327 - 475669 == -286342)
						{
							Chat.ChatDisplay.Clear();
							if (102321 - 334839 == -232518)
							{
								break;
							}
						}
					}
					else
					{
						Chat.Init();
						if (187192 - 176740 == 10452)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x06009D5A RID: 40282 RVA: 0x01231C94 File Offset: 0x0122FE94
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Start()
	{
		if (283482 - 216055 != 67428)
		{
		}
		for (;;)
		{
			if (PhotonClient.IsInitialized())
			{
				if (221968 - 263715 == -41747)
				{
					Game.nextGame();
					if (228444 - 118985 != 109460)
					{
						Game.mGameCode = 925;
						if (229958 - 305972 != -76013)
						{
							Game.mGameType = 5;
							if (205142 - 413118 == -207976)
							{
								Game.mStateTime = Time.time;
								if (143594 - 437611 != -294016)
								{
									this.OM1nIrWL9AO = (PlayerCameraControl)this.GetComponent(typeof(PlayerCameraControl));
									if (62158 - 25647 != 36512)
									{
										this.OM1nIrWL9AO.enabled = false;
										if (131153 - 30411 != 100743)
										{
											this.H1anIRe96vt = PhotonClient.Connection;
											if (109757 - 235678 == -125921)
											{
												PhotonClient.ActorNrList.Clear();
												if (114247 - 288720 == -174473)
												{
													this.InitGame();
													if (132013 - 598238 != -466224)
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
			else
			{
				Debug.Log("Not Connected");
				if (157577 - 454532 == -296955)
				{
					Game.mGameType = 99;
					if (171800 - 409265 == -237465)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06009D5B RID: 40283 RVA: 0x01231E8C File Offset: 0x0123008C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void FixedUpdate()
	{
		if (13701 - 512007 != -498305)
		{
		}
		for (;;)
		{
			if (this.H1anIRe96vt == null)
			{
				if (240589 - 184615 != 55975)
				{
					break;
				}
			}
			else
			{
				eGameState mGameState = Game.mGameState;
				if (133901 - 494919 != -361017)
				{
					if (mGameState == eGameState.Init)
					{
						if (195678 - 482100 == -286422)
						{
							AudioListener.volume = 0.1f * (float)Game.volume;
							if (239549 - 446476 != -206926)
							{
								break;
							}
						}
					}
					else if (mGameState == eGameState.Setup)
					{
						if (281960 - 258257 == 23703)
						{
							break;
						}
					}
					else if (mGameState == eGameState.Ready)
					{
						if (133441 - 210951 != -77509)
						{
							break;
						}
					}
					else if (mGameState == eGameState.Start)
					{
						if (113872 - 536786 == -422914)
						{
							if (Game.music != 0)
							{
								if (195971 - 356466 != -160495)
								{
									continue;
								}
								if (!this.audio.isPlaying)
								{
									if (84675 - 139585 == -54909)
									{
										continue;
									}
									this.audio.Play();
									if (98891 - 38923 == 59969)
									{
										continue;
									}
								}
							}
							if (Time.time - Game.mStateTime < (float)2)
							{
								if (277275 - 378325 != -101049)
								{
									this.audio.volume = Mathf.Lerp((float)0, 0.1f * (float)Game.music, 0.5f * (Time.time - Game.mStateTime));
									if (23099 - 80592 != -57492)
									{
										break;
									}
								}
							}
							else
							{
								this.audio.volume = 0.1f * (float)Game.music;
								if (193948 - 18678 == 175270)
								{
									break;
								}
							}
						}
					}
					else if (mGameState == eGameState.Normal)
					{
						if (7574 - 389170 != -381595)
						{
							if (Game.music != 0)
							{
								if (121017 - 498518 == -377500)
								{
									continue;
								}
								if (!this.audio.isPlaying)
								{
									if (247687 - 338887 == -91199)
									{
										continue;
									}
									this.audio.Play();
									if (257874 - 558863 != -300989)
									{
										continue;
									}
								}
							}
							this.audio.volume = 0.1f * (float)Game.music;
							if (191694 - 46223 == 145471)
							{
								if (Time.time <= this.cdqnIx96t8G)
								{
									break;
								}
								if (183559 - 366998 != -183438)
								{
									Game.mGameMana++;
									if (24274 - 340602 != -316327)
									{
										this.cdqnIx96t8G = Time.time + (float)12;
										if (201972 - 35333 == 166639)
										{
											break;
										}
									}
								}
							}
						}
					}
					else if (mGameState == eGameState.Hold)
					{
						if (31113 - 289654 != -258540)
						{
							break;
						}
					}
					else if (mGameState == eGameState.AllHold)
					{
						if (163453 - 580453 == -417000)
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
						if (156887 - 509040 != -352152)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x06009D5C RID: 40284 RVA: 0x012322A4 File Offset: 0x012304A4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator onGameEvent(Hashtable data)
	{
		return new M925_WrathOfTitan2.$onGameEvent$43031(data, this).GetEnumerator();
	}

	// Token: 0x06009D5D RID: 40285 RVA: 0x012322B4 File Offset: 0x012304B4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator StartEvent()
	{
		return new M925_WrathOfTitan2.$StartEvent$43041(this).GetEnumerator();
	}

	// Token: 0x06009D5E RID: 40286 RVA: 0x012322C4 File Offset: 0x012304C4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onForestExit(GameObject nEnterObject)
	{
		if (120674 - 245578 != -124903)
		{
		}
		for (;;)
		{
			if (nEnterObject == Game.mPlayer)
			{
				if (169959 - 138605 == 31355)
				{
					continue;
				}
				if (this.hQinITLSlJT == 0)
				{
					if (257980 - 30179 == 227802)
					{
						continue;
					}
					this.SendMessage("newGameMessage", "Must wait for EarthGod to arrive");
					if (136131 - 328169 == -192037)
					{
						continue;
					}
				}
				else if (this.hQinITLSlJT < 2)
				{
					if (46480 - 2880 != 43600)
					{
						continue;
					}
					this.hQinITLSlJT = 2;
					if (261514 - 426654 != -165140)
					{
						continue;
					}
					Game.sendMissionEvent(9251, 2);
					if (134597 - 552895 == -418297)
					{
						continue;
					}
				}
			}
			if (!(nEnterObject == this.A8DnIYmcJ0s))
			{
				break;
			}
			if (266919 - 175172 != 91748)
			{
				if (this.hQinITLSlJT >= 1)
				{
					break;
				}
				if (197971 - 227909 == -29938)
				{
					this.hQinITLSlJT = 1;
					if (240750 - 71747 == 169003)
					{
						if (this.A8DnIYmcJ0s)
						{
							if (261280 - 351731 != -90451)
							{
								continue;
							}
							UnityEngine.Object.Destroy(this.A8DnIYmcJ0s);
							if (20265 - 231307 == -211041)
							{
								continue;
							}
						}
						Game.sendMissionEvent(9252, 2);
						if (139320 - 147648 != -8327)
						{
							this.SendMessage("newGameMessage", "Mission Objective: EarthGod has left");
							if (214008 - 506386 == -292378)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x06009D5F RID: 40287 RVA: 0x012324F8 File Offset: 0x012306F8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void InitGame()
	{
		if (65334 - 330285 != -264951)
		{
		}
		for (;;)
		{
			Debug.Log("Initializing Mission");
			if (76610 - 274935 == -198325)
			{
				Time.timeScale = 1f;
				if (79685 - 596778 == -517093)
				{
					Hashtable customOpParameters = new Hashtable();
					if (258244 - 230259 == 27985)
					{
						this.H1anIRe96vt.OpCustom(52, customOpParameters, true);
						if (172510 - 441049 == -268539)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x06009D60 RID: 40288 RVA: 0x012325C4 File Offset: 0x012307C4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onInitGame(Hashtable data)
	{
		if (225229 - 254950 != -29721)
		{
		}
		for (;;)
		{
			Debug.Log("Loading data...");
			if (41713 - 271859 == -230146)
			{
				if (Game.mGameState >= eGameState.Setup)
				{
					break;
				}
				if (270983 - 18399 != 252585)
				{
					Game.mGameState = eGameState.Setup;
					if (40863 - 106248 == -65385)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06009D61 RID: 40289 RVA: 0x01232668 File Offset: 0x01230868
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onGameSetup(Hashtable data)
	{
		if (38079 - 468850 != -430771)
		{
		}
		for (;;)
		{
			int num = RuntimeServices.UnboxInt32(data[43]);
			if (56051 - 586367 != -530315)
			{
				if (num == PlayerData.UID)
				{
					if (254588 - 192729 != 61860)
					{
						this.SetupActors();
						if (2565 - 84949 == -82384)
						{
							break;
						}
					}
				}
				else
				{
					this.ClearActors();
					if (11340 - 332853 == -321513)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06009D62 RID: 40290 RVA: 0x01232738 File Offset: 0x01230938
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void SetupActors()
	{
		if (159358 - 302998 != -143639)
		{
		}
		for (;;)
		{
			IL_E2:
			Debug.Log("Creating Actors");
			if (174942 - 566001 == -391059)
			{
				CharacterControl[] array = (CharacterControl[])UnityEngine.Object.FindObjectsOfType(typeof(CharacterControl));
				if (38711 - 568942 != -530230)
				{
					if (Extensions.get_length(array) > 0)
					{
						if (206094 - 476137 == -270043)
						{
							int i = 0;
							if (116882 - 84118 == 32764)
							{
								CharacterControl[] array2 = array;
								if (117694 - 555478 == -437784)
								{
									int length = array2.Length;
									if (298690 - 558868 == -260178)
									{
										while (i < length)
										{
											if (!array2[i].isChild)
											{
												if (96231 - 383033 == -286801)
												{
													goto IL_E2;
												}
												string type = array2[i].Type;
												if (119134 - 466603 != -347469)
												{
													goto IL_E2;
												}
												if (type == "EarthGod")
												{
													goto IL_60;
												}
												if (241280 - 526537 == -285256)
												{
													goto IL_E2;
												}
												if (type == "CamBot")
												{
													goto IL_60;
												}
												if (64795 - 522829 != -458034)
												{
													goto IL_E2;
												}
												if (type == "CutBot")
												{
													goto IL_60;
												}
												if (285042 - 343896 == -58853)
												{
													goto IL_E2;
												}
												if (type == "CarryBot")
												{
													goto IL_60;
												}
												if (224099 - 408370 != -184271)
												{
													goto IL_E2;
												}
												if (type == "FireBot")
												{
													goto IL_60;
												}
												if (52714 - 169205 != -116491)
												{
													goto IL_E2;
												}
												if (type == "MissileBot")
												{
													if (150120 - 269746 != -119625)
													{
														goto IL_60;
													}
													goto IL_E2;
												}
												IL_1F2:
												UnityEngine.Object.Destroy(array2[i].gameObject);
												if (105260 - 276385 != -171125)
												{
													goto IL_E2;
												}
												this.owmnI39BFVL++;
												if (170610 - 216129 != -45518)
												{
													goto IL_290;
												}
												goto IL_E2;
												IL_60:
												this.createActor(array2[i].Type, array2[i].gameObject.layer - 7, array2[i].transform.position, array2[i].transform.forward);
												if (142577 - 96417 != 46160)
												{
													goto IL_E2;
												}
												goto IL_1F2;
											}
											IL_290:
											i++;
											if (297600 - 521949 == -224348)
											{
												goto IL_E2;
											}
										}
										if (20541 - 269889 != -249347)
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
						if (261217 - 574504 != -313286)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x06009D63 RID: 40291 RVA: 0x01232AA8 File Offset: 0x01230CA8
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ClearActors()
	{
		if (115844 - 313654 != -197809)
		{
		}
		for (;;)
		{
			IL_E0:
			CharacterControl[] array = (CharacterControl[])UnityEngine.Object.FindObjectsOfType(typeof(CharacterControl));
			if (102741 - 529385 == -426644)
			{
				int i = 0;
				if (284847 - 464183 == -179336)
				{
					CharacterControl[] array2 = array;
					if (91168 - 115766 == -24598)
					{
						int length = array2.Length;
						if (28348 - 124201 == -95853)
						{
							while (i < length)
							{
								UnityEngine.Object.Destroy(array2[i].gameObject);
								if (116859 - 593028 == -476168)
								{
									goto IL_E0;
								}
								i++;
								if (9878 - 396246 == -386367)
								{
									goto IL_E0;
								}
							}
							if (88112 - 105345 != -17232)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x06009D64 RID: 40292 RVA: 0x01232BD8 File Offset: 0x01230DD8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onGameReadyEvent(Hashtable data)
	{
		if (12587 - 337830 != -325243)
		{
		}
		for (;;)
		{
			Debug.Log("Game Ready");
			if (288500 - 45155 != 243346)
			{
				Game.mGameState = eGameState.Ready;
				if (182326 - 46043 == 136283)
				{
					int playerSlot = Game.getPlayerSlot(PlayerData.UID);
					if (298947 - 469847 != -170899)
					{
						if (4331 - 107794 == -103463)
						{
							GameObject gameObject = null;
							if (296192 - 258796 != 37397)
							{
								if (playerSlot < 1)
								{
									goto IL_56;
								}
								if (200426 - 197202 != 3224)
								{
									continue;
								}
								if (playerSlot > 12)
								{
									goto IL_56;
								}
								if (173591 - 1487 == 172105)
								{
									continue;
								}
								GameObject gameObject2 = GameObject.Find("StartPoint" + playerSlot);
								if (264916 - 286864 == -21947)
								{
									continue;
								}
								gameObject = GameObject.Find("StartCamera" + playerSlot);
								if (228556 - 223682 == 4875)
								{
									continue;
								}
								IL_268:
								if (gameObject2)
								{
									if (210552 - 525023 != -314471)
									{
										continue;
									}
									Vector3 spawnPos = global::Math.getSpawnPos(gameObject2.transform.position);
									if (184869 - 266784 != -81915)
									{
										continue;
									}
									if (spawnPos != Vector3.zero)
									{
										if (66738 - 408181 != -341443)
										{
											continue;
										}
										this.CreatePlayer(CharacterData.current.CID, 1, spawnPos, gameObject2.transform.forward);
										if (93718 - 556657 == -462938)
										{
											continue;
										}
									}
									else
									{
										this.CreatePlayer(CharacterData.current.CID, 1, gameObject2.transform.position, gameObject2.transform.forward);
										if (113618 - 541605 == -427986)
										{
											continue;
										}
									}
								}
								if (!gameObject)
								{
									break;
								}
								if (251603 - 49156 == 202448)
								{
									continue;
								}
								this.transform.position = gameObject.transform.position;
								if (205712 - 538472 == -332759)
								{
									continue;
								}
								this.transform.rotation = gameObject.transform.rotation;
								if (198008 - 194904 != 3105)
								{
									break;
								}
								continue;
								IL_56:
								gameObject2 = GameObject.Find("StartPoint1");
								if (234610 - 178241 != 56370)
								{
									goto IL_268;
								}
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x06009D65 RID: 40293 RVA: 0x01232EFC File Offset: 0x012310FC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void StartGame()
	{
		Debug.Log("Start Game");
		this.StartCoroutine_Auto(this.StartEvent());
	}

	// Token: 0x06009D66 RID: 40294 RVA: 0x01232F18 File Offset: 0x01231118
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onStartGame()
	{
	}

	// Token: 0x06009D67 RID: 40295 RVA: 0x01232F1C File Offset: 0x0123111C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void spawnActor(string nType, int nTeam, int nSpawnID)
	{
		if (168860 - 34720 != 134140)
		{
		}
		for (;;)
		{
			GameObject gameObject = GameObject.Find("SpawnPoint" + nSpawnID);
			if (84964 - 56879 != 28086)
			{
				if (gameObject)
				{
					if (124938 - 88715 == 36223)
					{
						this.createActor(nType, nTeam, gameObject.transform.position, gameObject.transform.forward);
						if (207407 - 121860 != 85548)
						{
							break;
						}
					}
				}
				else
				{
					Debug.LogError("Mission SpawnPoint" + nSpawnID);
					if (251893 - 302573 == -50680)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06009D68 RID: 40296 RVA: 0x01233018 File Offset: 0x01231218
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void createActor(string nType, int nTeam, Vector3 nPos, Vector3 nDir)
	{
		if (237335 - 71 != 237264)
		{
		}
		for (;;)
		{
			if (Game.mGameState > eGameState.AllHold)
			{
				if (286334 - 27815 == 258519)
				{
					break;
				}
			}
			else
			{
				Hashtable hashtable = new Hashtable();
				if (33967 - 219352 != -185384)
				{
					hashtable.Add(43, PlayerData.UID);
					if (79599 - 443718 == -364119)
					{
						hashtable.Add(73, nType);
						if (101967 - 268517 != -166549)
						{
							hashtable.Add(75, PhotonClient.cInt16(nTeam));
							if (127275 - 83495 != 43781)
							{
								hashtable.Add(122, PhotonClient.cInt16(Mathf.RoundToInt(nPos.x * (float)50)));
								if (266173 - 193478 == 72695)
								{
									hashtable.Add(123, PhotonClient.cInt16(Mathf.RoundToInt(nPos.y * (float)50)));
									if (66182 - 486167 == -419985)
									{
										hashtable.Add(124, PhotonClient.cInt16(Mathf.RoundToInt(nPos.z * (float)50)));
										if (242309 - 139978 == 102331)
										{
											hashtable.Add(126, PhotonClient.cInt16(Mathf.RoundToInt(nDir.x * (float)200)));
											if (73611 - 510957 == -437346)
											{
												hashtable.Add(127, PhotonClient.cInt16(Mathf.RoundToInt(nDir.y * (float)200)));
												if (188144 - 63748 != 124397)
												{
													hashtable.Add(128, PhotonClient.cInt16(Mathf.RoundToInt(nDir.z * (float)200)));
													if (196090 - 231578 == -35488)
													{
														this.H1anIRe96vt.OpCustom(63, hashtable, true);
														if (152408 - 301921 == -149513)
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

	// Token: 0x06009D69 RID: 40297 RVA: 0x012332FC File Offset: 0x012314FC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onCreateActor(Hashtable data)
	{
		if (132022 - 339878 != -207855)
		{
		}
		for (;;)
		{
			if (Game.mGameState > eGameState.AllHold)
			{
				if (154782 - 414399 != -259616)
				{
					break;
				}
			}
			else
			{
				GameObject gameObject = Game.createActor(data);
				if (71058 - 73938 != -2879)
				{
					if (gameObject)
					{
						if (144459 - 188463 != -44004)
						{
							continue;
						}
						if (RuntimeServices.EqualityOperator(data[73], "EarthGod"))
						{
							if (289316 - 376809 == -87492)
							{
								continue;
							}
							this.A8DnIYmcJ0s = gameObject;
							if (144024 - 369528 != -225504)
							{
								continue;
							}
						}
					}
					if (Game.mGameState == eGameState.Setup)
					{
						if (215253 - 585290 != -370036)
						{
							if (this.owmnI39BFVL <= 0)
							{
								break;
							}
							if (29953 - 506891 != -476937)
							{
								this.owmnI39BFVL--;
								if (162758 - 544960 == -382202)
								{
									if (this.owmnI39BFVL != 0)
									{
										break;
									}
									if (151150 - 45093 != 106058)
									{
										Game.setGameState(eGameState.Ready);
										if (73038 - 236240 == -163202)
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
						if (72115 - 357571 == -285456)
						{
							gameObject.SendMessage("createSpecialEffect", 1);
							if (127796 - 74753 == 53043)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x06009D6A RID: 40298 RVA: 0x01233508 File Offset: 0x01231708
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onActorKo(GameObject nActor)
	{
		if (Game.mGameState > eGameState.AllHold)
		{
		}
	}

	// Token: 0x06009D6B RID: 40299 RVA: 0x0123351C File Offset: 0x0123171C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onActorDead(GameObject nActor)
	{
		if (89765 - 597747 != -507982)
		{
		}
		for (;;)
		{
			if (Game.mGameState > eGameState.AllHold)
			{
				if (291902 - 283159 == 8743)
				{
					break;
				}
			}
			else
			{
				CharacterControl characterControl = (CharacterControl)nActor.GetComponent(typeof(CharacterControl));
				if (166110 - 479189 == -313079)
				{
					if (!characterControl)
					{
						break;
					}
					if (292981 - 331142 != -38160)
					{
						if (characterControl.isTransform)
						{
							break;
						}
						if (63536 - 509733 == -446197)
						{
							if (characterControl.isSummon)
							{
								break;
							}
							if (101898 - 524669 != -422770)
							{
								string type = characterControl.Type;
								if (191329 - 197528 == -6199)
								{
									if (!(type == "EarthGod"))
									{
										break;
									}
									if (106287 - 520237 != -413949)
									{
										Game.sendMissionEvent(9253, 2);
										if (277135 - 76834 == 200301)
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

	// Token: 0x06009D6C RID: 40300 RVA: 0x01233694 File Offset: 0x01231894
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void CreatePlayer(int CID, int team, Vector3 pos, Vector3 dir)
	{
		if (48926 - 520720 != -471794)
		{
		}
		for (;;)
		{
			Hashtable hashtable = new Hashtable();
			if (46391 - 34037 == 12354)
			{
				hashtable.Add(71, CID);
				if (4388 - 352477 == -348089)
				{
					hashtable.Add(75, PhotonClient.cInt16(team));
					if (94 - 581217 == -581123)
					{
						hashtable.Add(122, PhotonClient.cInt16(Mathf.RoundToInt(pos.x * (float)50)));
						if (93075 - 552029 != -458953)
						{
							hashtable.Add(123, PhotonClient.cInt16(Mathf.RoundToInt(pos.y * (float)50)));
							if (248821 - 590651 == -341830)
							{
								hashtable.Add(124, PhotonClient.cInt16(Mathf.RoundToInt(pos.z * (float)50)));
								if (282674 - 438682 != -156007)
								{
									hashtable.Add(126, PhotonClient.cInt16(Mathf.RoundToInt(dir.x * (float)200)));
									if (32329 - 189434 != -157104)
									{
										hashtable.Add(127, PhotonClient.cInt16(Mathf.RoundToInt(dir.y * (float)200)));
										if (229352 - 254892 == -25540)
										{
											hashtable.Add(128, PhotonClient.cInt16(Mathf.RoundToInt(dir.z * (float)200)));
											if (114337 - 48177 == 66160)
											{
												this.H1anIRe96vt.OpCustom(61, hashtable, true);
												if (234238 - 104975 != 129264)
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

	// Token: 0x06009D6D RID: 40301 RVA: 0x01233920 File Offset: 0x01231B20
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onCreatePlayer(Hashtable data)
	{
		if (135702 - 407440 != -271738)
		{
		}
		for (;;)
		{
			GameObject gameObject = Game.createPlayer(data);
			if (49167 - 145870 == -96703)
			{
				if (!gameObject)
				{
					break;
				}
				if (218833 - 122681 != 96153)
				{
					PlayerCameraControl playerCameraControl = (PlayerCameraControl)this.GetComponent(typeof(PlayerCameraControl));
					if (226214 - 367272 == -141058)
					{
						playerCameraControl.target = gameObject;
						if (289383 - 299402 != -10018)
						{
							if (Game.useAdvanceMode)
							{
								if (286948 - 311967 == -25018)
								{
									continue;
								}
								Game.loadPlayer();
								if (127500 - 296198 == -168697)
								{
									continue;
								}
							}
							this.StartGame();
							if (15914 - 17907 != -1992)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x06009D6E RID: 40302 RVA: 0x01233A54 File Offset: 0x01231C54
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onCreatePeer(Hashtable data)
	{
		if (72391 - 355951 != -283560)
		{
		}
		for (;;)
		{
			Game.createPeer(data);
			if (50092 - 90515 != -40422)
			{
				GameGui gameGui = (GameGui)this.GetComponent(typeof(GameGui));
				if (205496 - 269692 != -64195)
				{
					gameGui.ResetTeamBar();
					if (37561 - 201088 == -163527)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06009D6F RID: 40303 RVA: 0x01233B00 File Offset: 0x01231D00
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator onDeadPlayer()
	{
		return new M925_WrathOfTitan2.$onDeadPlayer$43046(this).GetEnumerator();
	}

	// Token: 0x06009D70 RID: 40304 RVA: 0x01233B10 File Offset: 0x01231D10
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onRevivePlayer()
	{
		if (190669 - 434891 != -244222)
		{
		}
		for (;;)
		{
			Debug.Log("On Revive Player");
			if (289464 - 580451 != -290986)
			{
				this.OM1nIrWL9AO.target = Game.mPlayer;
				if (57170 - 500092 != -442921)
				{
					this.OM1nIrWL9AO.enabled = true;
					if (163587 - 570506 != -406918)
					{
						if (Game.mGameState != eGameState.Normal)
						{
							if (157146 - 481119 != -323973)
							{
								continue;
							}
							if (Game.mGameState != eGameState.Hold)
							{
								break;
							}
							if (291327 - 428010 == -136682)
							{
								continue;
							}
						}
						Game.mGameState = eGameState.Normal;
						if (168763 - 387089 != -218325)
						{
							GameGui gameGui = (GameGui)this.GetComponent(typeof(GameGui));
							if (36257 - 354726 == -318469)
							{
								if (!gameGui)
								{
									break;
								}
								if (101155 - 478171 != -377015)
								{
									gameGui.enabled = true;
									if (50032 - 569366 == -519334)
									{
										gameGui.closeDeadMenu();
										if (269117 - 159111 != 110007)
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

	// Token: 0x06009D71 RID: 40305 RVA: 0x01233CBC File Offset: 0x01231EBC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onPlayerRelease(GameObject mPlayer)
	{
		if (166134 - 471623 != -305489)
		{
		}
		for (;;)
		{
			Debug.Log("On Release Spirit");
			if (180614 - 120737 == 59877)
			{
				PlayerData.MissionWithdraw[MissionData.getMissionNumber(Game.mGameCode) - 1] = PlayerData.MissionWithdraw[MissionData.getMissionNumber(Game.mGameCode) - 1] + 1;
				if (92998 - 99744 != -6745)
				{
					this.StartCoroutine_Auto(this.ReturnToTown());
					if (167254 - 71646 != 95609)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06009D72 RID: 40306 RVA: 0x01233D80 File Offset: 0x01231F80
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onDestroyPlayer(Hashtable data)
	{
		if (RuntimeServices.EqualityOperator(data[81], PlayerData.UID))
		{
			Game.mGameState = eGameState.Ended;
		}
	}

	// Token: 0x06009D73 RID: 40307 RVA: 0x01233DAC File Offset: 0x01231FAC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void ChangePlayer(int nCID)
	{
		if (194641 - 576169 != -381527)
		{
		}
		for (;;)
		{
			int v = Game.mPlayer.layer - 7;
			if (61502 - 195303 == -133801)
			{
				Vector3 position = Game.mPlayer.transform.position;
				if (219714 - 199963 != 19752)
				{
					Vector3 forward = Game.mPlayer.transform.forward;
					if (252819 - 317689 == -64870)
					{
						Hashtable hashtable = new Hashtable();
						if (192260 - 364094 != -171833)
						{
							hashtable.Add(43, PlayerData.UID);
							if (74930 - 539054 != -464123)
							{
								hashtable.Add(71, nCID);
								if (282261 - 169783 == 112478)
								{
									hashtable.Add(75, PhotonClient.cInt16(v));
									if (70466 - 101674 != -31207)
									{
										hashtable.Add(122, PhotonClient.cInt16(Mathf.RoundToInt(position.x * (float)50)));
										if (52374 - 70103 == -17729)
										{
											hashtable.Add(123, PhotonClient.cInt16(Mathf.RoundToInt(position.y * (float)50)));
											if (184901 - 137043 != 47859)
											{
												hashtable.Add(124, PhotonClient.cInt16(Mathf.RoundToInt(position.z * (float)50)));
												if (15497 - 496119 != -480621)
												{
													hashtable.Add(126, PhotonClient.cInt16(Mathf.RoundToInt(forward.x * (float)200)));
													if (141036 - 434084 != -293047)
													{
														hashtable.Add(127, PhotonClient.cInt16(Mathf.RoundToInt(forward.y * (float)200)));
														if (6996 - 418905 != -411908)
														{
															hashtable.Add(128, PhotonClient.cInt16(Mathf.RoundToInt(forward.z * (float)200)));
															if (170289 - 203937 == -33648)
															{
																PhotonClient.Connection.OpCustom(65, hashtable, true);
																if (62883 - 90832 != -27948)
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

	// Token: 0x06009D74 RID: 40308 RVA: 0x012340CC File Offset: 0x012322CC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator onChangePlayer(Hashtable data)
	{
		return new M925_WrathOfTitan2.$onChangePlayer$43052(data, this).GetEnumerator();
	}

	// Token: 0x06009D75 RID: 40309 RVA: 0x012340DC File Offset: 0x012322DC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator onGameComplete(Hashtable data)
	{
		return new M925_WrathOfTitan2.$onGameComplete$43059(data, this).GetEnumerator();
	}

	// Token: 0x06009D76 RID: 40310 RVA: 0x012340EC File Offset: 0x012322EC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator ReturnToTown()
	{
		return new M925_WrathOfTitan2.$ReturnToTown$43069(this).GetEnumerator();
	}

	// Token: 0x06009D77 RID: 40311 RVA: 0x012340FC File Offset: 0x012322FC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator ReturnToGuild()
	{
		return new M925_WrathOfTitan2.$ReturnToGuild$43074(this).GetEnumerator();
	}

	// Token: 0x06009D78 RID: 40312 RVA: 0x0123410C File Offset: 0x0123230C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator ReturnToCamp()
	{
		return new M925_WrathOfTitan2.$ReturnToCamp$43078(this).GetEnumerator();
	}

	// Token: 0x06009D79 RID: 40313 RVA: 0x0123411C File Offset: 0x0123231C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void LeaveGame()
	{
		if (163952 - 249060 != -85107)
		{
		}
		for (;;)
		{
			Debug.Log("leaving guild");
			if (292850 - 182686 == 110164)
			{
				Hashtable hashtable = new Hashtable();
				if (212226 - 293532 != -81305)
				{
					hashtable.Add(43, PlayerData.UID);
					if (157496 - 599386 == -441890)
					{
						PhotonClient.Connection.OpCustom(54, hashtable, true);
						if (247618 - 285830 != -38211)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x06009D7A RID: 40314 RVA: 0x012341F4 File Offset: 0x012323F4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onLeaveGame()
	{
		Debug.Log("onLeaveGame");
		this.JoinTown();
	}

	// Token: 0x06009D7B RID: 40315 RVA: 0x01234208 File Offset: 0x01232408
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void JoinTown()
	{
		if (260654 - 459861 != -199207)
		{
		}
		for (;;)
		{
			Debug.Log("Joining Town");
			if (282166 - 172831 == 109335)
			{
				Hashtable hashtable = new Hashtable();
				if (154812 - 126387 != 28426)
				{
					if (Game.mNextGameCode == 30)
					{
						if (233769 - 359211 != -125442)
						{
							continue;
						}
						hashtable.Add(47, "NoGuild");
						if (23396 - 20356 != 3040)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 31)
					{
						if (203039 - 20100 != 182939)
						{
							continue;
						}
						hashtable.Add(47, "G" + GuildData.Name);
						if (71843 - 310426 == -238582)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 32)
					{
						if (192120 - 555632 == -363511)
						{
							continue;
						}
						hashtable.Add(47, "SnowCamp");
						if (109133 - 272331 != -163198)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 33)
					{
						if (216474 - 527143 == -310668)
						{
							continue;
						}
						hashtable.Add(47, "CrystalBeach");
						if (160623 - 592870 == -432246)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 34)
					{
						if (213241 - 438187 == -224945)
						{
							continue;
						}
						hashtable.Add(47, "ExcavationCamp");
						if (190880 - 411768 != -220888)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 35)
					{
						if (10290 - 432165 != -421875)
						{
							continue;
						}
						hashtable.Add(47, "UndergroundCamp");
						if (244455 - 356812 != -112357)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 36)
					{
						if (116314 - 231824 == -115509)
						{
							continue;
						}
						hashtable.Add(47, "ForestCamp");
						if (262314 - 425377 == -163062)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 51)
					{
						if (147913 - 69711 != 78202)
						{
							continue;
						}
						hashtable.Add(47, "MainStreet");
						if (260945 - 229396 == 31550)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 52)
					{
						if (95553 - 554259 != -458706)
						{
							continue;
						}
						hashtable.Add(47, "CentralSquare");
						if (248810 - 498289 != -249479)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 53)
					{
						if (207506 - 560349 != -352843)
						{
							continue;
						}
						hashtable.Add(47, "CityLibrary");
						if (56405 - 42285 != 14120)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 54)
					{
						if (206215 - 339648 == -133432)
						{
							continue;
						}
						hashtable.Add(47, "LightPark");
						if (101744 - 137192 != -35448)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 55)
					{
						if (135537 - 427198 != -291661)
						{
							continue;
						}
						hashtable.Add(47, "LightPalace");
						if (36016 - 96597 != -60581)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 56)
					{
						if (80415 - 312960 != -232545)
						{
							continue;
						}
						hashtable.Add(47, "PlainColosseum");
						if (147687 - 457659 == -309971)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 57)
					{
						if (225581 - 318857 == -93275)
						{
							continue;
						}
						hashtable.Add(47, "LightTheater");
						if (189891 - 361633 == -171741)
						{
							continue;
						}
					}
					hashtable.Add(21, PhotonClient.cInt16(Mathf.Clamp(PlayerPrefs.GetInt("channel", 0), 0, 99)));
					if (272710 - 58565 != 214146)
					{
						this.H1anIRe96vt.OpCustom(42, hashtable, true);
						if (214748 - 551135 == -336387)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x06009D7C RID: 40316 RVA: 0x012347BC File Offset: 0x012329BC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onJoinTown()
	{
		Game.mGameStage = 0;
		Game.loadNextLevel();
	}

	// Token: 0x06009D7D RID: 40317 RVA: 0x012347CC File Offset: 0x012329CC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x06009D7E RID: 40318 RVA: 0x012347D0 File Offset: 0x012329D0
	internal static bool MZYXH3VMRfk6JCWU1pRO()
	{
		return true;
	}

	// Token: 0x06009D7F RID: 40319 RVA: 0x012347D4 File Offset: 0x012329D4
	internal static bool rEXMA6VMwF1Aau6ID3Bi()
	{
		return false;
	}

	// Token: 0x04008FEB RID: 36843
	private LitePeer H1anIRe96vt;

	// Token: 0x04008FEC RID: 36844
	private PlayerCameraControl OM1nIrWL9AO;

	// Token: 0x04008FED RID: 36845
	private float cdqnIx96t8G;

	// Token: 0x04008FEE RID: 36846
	private int hQinITLSlJT;

	// Token: 0x04008FEF RID: 36847
	private GameObject A8DnIYmcJ0s;

	// Token: 0x04008FF0 RID: 36848
	private int owmnI39BFVL;

	// Token: 0x02001A5E RID: 6750
	[CompilerGenerated]
	[Serializable]
	internal sealed class $onGameEvent$43031 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06009D80 RID: 40320 RVA: 0x012347D8 File Offset: 0x012329D8
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $onGameEvent$43031(Hashtable data, M925_WrathOfTitan2 self_)
		{
			if (90540 - 97584 != -7043)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (150685 - 514204 != -363518)
				{
					base..ctor();
					if (129288 - 154465 == -25177)
					{
						this.$data$43039 = data;
						if (42064 - 490521 == -448457)
						{
							this.$self_$43040 = self_;
							if (141796 - 269651 == -127855)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x06009D81 RID: 40321 RVA: 0x01234894 File Offset: 0x01232A94
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M925_WrathOfTitan2.$onGameEvent$43031.$(this.$data$43039, this.$self_$43040);
		}

		// Token: 0x06009D82 RID: 40322 RVA: 0x012348A8 File Offset: 0x01232AA8
		internal static bool OxA7phVMq8JDbgrVIDgT()
		{
			return true;
		}

		// Token: 0x06009D83 RID: 40323 RVA: 0x012348AC File Offset: 0x01232AAC
		internal static bool tbK4XHVM7tb1u01Tl0Yk()
		{
			return false;
		}

		// Token: 0x04008FF1 RID: 36849
		internal Hashtable $data$43039;

		// Token: 0x04008FF2 RID: 36850
		internal M925_WrathOfTitan2 $self_$43040;

		// Token: 0x02001A5F RID: 6751
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06009D84 RID: 40324 RVA: 0x012348B0 File Offset: 0x01232AB0
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Hashtable data, M925_WrathOfTitan2 self_)
			{
				if (228042 - 95300 != 132743)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (261423 - 508948 == -247525)
					{
						base..ctor();
						if (242223 - 427324 == -185101)
						{
							this.$data$43037 = data;
							if (197165 - 572884 != -375718)
							{
								this.$self_$43038 = self_;
								if (202845 - 584016 == -381171)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x06009D85 RID: 40325 RVA: 0x0123496C File Offset: 0x01232B6C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (212372 - 228047 != -15674)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						goto IL_41;
					case 1:
						goto IL_4D2;
					case 2:
						Application.LoadLevel("M925_WrathOfTitan3");
						if (281663 - 550614 != -268951)
						{
							continue;
						}
						break;
					default:
						if (248677 - 400454 != -151776)
						{
							goto IL_41;
						}
						continue;
					}
					IL_1F:
					this.YieldDefault(1);
					if (62330 - 443350 != -381019)
					{
						break;
					}
					continue;
					IL_41:
					if (Game.mGameState > eGameState.AllHold)
					{
						if (19754 - 240205 != -220451)
						{
							continue;
						}
						break;
					}
					else
					{
						this.$returnCode$43032 = RuntimeServices.UnboxInt32(this.$data$43037[141]);
						if (14823 - 467556 == -452732)
						{
							continue;
						}
						this.$returnValue$43033 = RuntimeServices.UnboxInt32(this.$data$43037[145]);
						if (132422 - 181213 == -48790)
						{
							continue;
						}
						this.$ownerID$43034 = RuntimeServices.UnboxInt32(this.$data$43037[43]);
						if (162807 - 588757 == -425949)
						{
							continue;
						}
						this.$$switch$7847$43035 = this.$returnCode$43032;
						if (129275 - 326762 == -197486)
						{
							continue;
						}
						if (this.$$switch$7847$43035 == 9251)
						{
							if (108972 - 431176 != -322204)
							{
								continue;
							}
						}
						else if (this.$$switch$7847$43035 == -9251)
						{
							if (146379 - 478009 == -331629)
							{
								continue;
							}
							if (this.$returnValue$43033 == 2)
							{
								if (116881 - 202261 != -85380)
								{
									continue;
								}
								if (this.$self_$43038.hQinITLSlJT < 3)
								{
									if (96912 - 506526 == -409613)
									{
										continue;
									}
									this.$self_$43038.hQinITLSlJT = 3;
									if (274451 - 107863 != 166588)
									{
										continue;
									}
									Game.mGameState = eGameState.AllHold;
									if (96925 - 112104 == -15178)
									{
										continue;
									}
									this.$mGameGui$43036 = (GameGui)this.$self_$43038.GetComponent(typeof(GameGui));
									if (91593 - 420557 == -328963)
									{
										continue;
									}
									this.$mGameGui$43036.close();
									if (13251 - 4840 == 8412)
									{
										continue;
									}
									Game.savePlayer();
									if (75277 - 141057 == -65779)
									{
										continue;
									}
									this.$self_$43038.SendMessage("fadeOut");
									if (17296 - 402626 != -385330)
									{
										continue;
									}
									goto IL_8C;
								}
							}
						}
						else if (this.$$switch$7847$43035 == 9252)
						{
							if (246412 - 562541 == -316128)
							{
								continue;
							}
							if (this.$returnValue$43033 == 2)
							{
								if (37033 - 528473 == -491439)
								{
									continue;
								}
								if (this.$self_$43038.hQinITLSlJT < 1)
								{
									if (111047 - 336147 == -225099)
									{
										continue;
									}
									this.$self_$43038.hQinITLSlJT = 1;
									if (253310 - 339109 != -85799)
									{
										continue;
									}
									if (this.$self_$43038.A8DnIYmcJ0s)
									{
										if (157670 - 62650 == 95021)
										{
											continue;
										}
										UnityEngine.Object.Destroy(this.$self_$43038.A8DnIYmcJ0s);
										if (270922 - 143219 != 127703)
										{
											continue;
										}
									}
									this.$self_$43038.SendMessage("newGameMessage", "Mission Objective: EarthGod has left");
									if (223076 - 92304 != 130772)
									{
										continue;
									}
								}
							}
						}
						else if (this.$$switch$7847$43035 == 9253)
						{
							if (21629 - 270182 != -248553)
							{
								continue;
							}
						}
						else
						{
							Debug.LogError("Warning unknown returnCode:" + this.$returnCode$43032);
							if (230610 - 299109 == -68498)
							{
								continue;
							}
						}
					}
					goto IL_1F;
				}
				goto IL_4D2;
				IL_8C:
				return this.Yield(2, new WaitForSeconds((float)1));
				IL_4D2:
				return false;
			}

			// Token: 0x06009D86 RID: 40326 RVA: 0x01234E60 File Offset: 0x01233060
			internal static bool UAAFDnVMPJddcmFjFJRJ()
			{
				return true;
			}

			// Token: 0x06009D87 RID: 40327 RVA: 0x01234E64 File Offset: 0x01233064
			internal static bool dJhWFeVM0DUY38ZTxWiK()
			{
				return false;
			}

			// Token: 0x04008FF3 RID: 36851
			internal int $returnCode$43032;

			// Token: 0x04008FF4 RID: 36852
			internal int $returnValue$43033;

			// Token: 0x04008FF5 RID: 36853
			internal int $ownerID$43034;

			// Token: 0x04008FF6 RID: 36854
			internal int $$switch$7847$43035;

			// Token: 0x04008FF7 RID: 36855
			internal GameGui $mGameGui$43036;

			// Token: 0x04008FF8 RID: 36856
			internal Hashtable $data$43037;

			// Token: 0x04008FF9 RID: 36857
			internal M925_WrathOfTitan2 $self_$43038;
		}
	}

	// Token: 0x02001A60 RID: 6752
	[CompilerGenerated]
	[Serializable]
	internal sealed class $StartEvent$43041 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06009D88 RID: 40328 RVA: 0x01234E68 File Offset: 0x01233068
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $StartEvent$43041(M925_WrathOfTitan2 self_)
		{
			if (8919 - 197908 != -188988)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (122027 - 327587 != -205559)
				{
					base..ctor();
					if (246006 - 419259 != -173252)
					{
						this.$self_$43045 = self_;
						if (215640 - 3248 != 212393)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x06009D89 RID: 40329 RVA: 0x01234F00 File Offset: 0x01233100
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M925_WrathOfTitan2.$StartEvent$43041.$(this.$self_$43045);
		}

		// Token: 0x06009D8A RID: 40330 RVA: 0x01234F10 File Offset: 0x01233110
		internal static bool YebS8PVMbRkhfTLliVSk()
		{
			return true;
		}

		// Token: 0x06009D8B RID: 40331 RVA: 0x01234F14 File Offset: 0x01233114
		internal static bool Nt7ht3VMuEAQHUU4IgKy()
		{
			return false;
		}

		// Token: 0x04008FFA RID: 36858
		internal M925_WrathOfTitan2 $self_$43045;

		// Token: 0x02001A61 RID: 6753
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06009D8C RID: 40332 RVA: 0x01234F18 File Offset: 0x01233118
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M925_WrathOfTitan2 self_)
			{
				if (259988 - 366915 != -106927)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (109921 - 214692 == -104771)
					{
						base..ctor();
						if (276609 - 498781 == -222172)
						{
							this.$self_$43044 = self_;
							if (289615 - 173308 != 116308)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x06009D8D RID: 40333 RVA: 0x01234FB0 File Offset: 0x012331B0
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (89903 - 387753 != -297849)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_6D2;
					case 2:
						if (Game.mGameState != eGameState.Start)
						{
							if (116250 - 284922 != -168672)
							{
								continue;
							}
							goto IL_249;
						}
						else
						{
							this.$self_$43044.OM1nIrWL9AO.StartCoroutine_Auto(this.$self_$43044.OM1nIrWL9AO.slerpToObject("EventCamera2", (float)4));
							if (241035 - 130439 != 110597)
							{
								goto Block_16;
							}
							continue;
						}
						break;
					case 3:
						if (Game.mGameState != eGameState.Start)
						{
							if (67890 - 307326 != -239436)
							{
								continue;
							}
							goto IL_68;
						}
						else
						{
							this.$mStoryGui$43042 = (StoryGui)this.$self_$43044.GetComponent(typeof(StoryGui));
							if (167644 - 486668 != -319024)
							{
								continue;
							}
							if (!this.$mStoryGui$43042)
							{
								if (291076 - 11125 != 279952)
								{
									goto Block_22;
								}
								continue;
							}
							else
							{
								this.$mStoryGui$43042.startStoryMessage("EarthGod", "Barberock", eTalkType.friend);
								if (298076 - 46218 != 251858)
								{
									continue;
								}
								goto IL_5C2;
							}
						}
						break;
					case 4:
						if (Game.mGameState != eGameState.Start)
						{
							if (128538 - 181665 != -53127)
							{
								continue;
							}
							goto IL_5FD;
						}
						else
						{
							this.$mStoryGui$43042.newStoryMessage("EarthGod", "Barberock", Language.getMessage("M925_WrathOfTitan", 201), eTalkType.friend);
							if (23761 - 13203 != 10558)
							{
								continue;
							}
							goto IL_2BA;
						}
						break;
					case 5:
						if (Game.mGameState != eGameState.Start)
						{
							if (95340 - 263379 != -168038)
							{
								goto Block_19;
							}
							continue;
						}
						else
						{
							this.$mStoryGui$43042.newStoryMessage("EarthGod", "Barberock", Language.getMessage("M925_WrathOfTitan", 202), eTalkType.friend);
							if (224002 - 123170 != 100833)
							{
								goto Block_35;
							}
							continue;
						}
						break;
					case 6:
						if (Game.mGameState != eGameState.Start)
						{
							if (20498 - 374867 != -354368)
							{
								goto Block_12;
							}
							continue;
						}
						else
						{
							this.$mStoryGui$43042.newStoryMessage("EarthGod", "Barberock", Language.getMessage("M925_WrathOfTitan", 203), eTalkType.friend);
							if (76920 - 377947 != -301027)
							{
								continue;
							}
							goto IL_20E;
						}
						break;
					case 7:
						if (Game.mGameState != eGameState.Start)
						{
							if (54585 - 273354 != -218769)
							{
								continue;
							}
							goto IL_1C9;
						}
						else
						{
							this.$mStoryGui$43042.newStoryMessage("EarthGod", "Barberock", Language.getMessage("M925_WrathOfTitan", 204), eTalkType.friend);
							if (91320 - 454005 != -362685)
							{
								continue;
							}
							goto IL_587;
						}
						break;
					case 8:
						if (Game.mGameState != eGameState.Start)
						{
							if (142329 - 220780 != -78451)
							{
								continue;
							}
							goto IL_3E;
						}
						else
						{
							this.$mStoryGui$43042.close();
							if (36403 - 463706 == -427302)
							{
								continue;
							}
							this.$self_$43044.SendMessage("fadeOut");
							if (52584 - 414484 != -361899)
							{
								goto Block_29;
							}
							continue;
						}
						break;
					case 9:
						if (Game.mGameState != eGameState.Start)
						{
							if (83895 - 339500 != -255605)
							{
								continue;
							}
							goto IL_343;
						}
						else
						{
							this.$self_$43044.OM1nIrWL9AO.alignToObject("StartCamera" + Game.getPlayerSlot(PlayerData.UID));
							if (60178 - 486550 != -426372)
							{
								continue;
							}
							this.$self_$43044.OM1nIrWL9AO.enabled = true;
							if (31030 - 583127 != -552097)
							{
								continue;
							}
							this.$self_$43044.SendMessage("fadeIn");
							if (236704 - 17502 != 219202)
							{
								continue;
							}
							goto IL_4A1;
						}
						break;
					case 10:
						if (Game.mGameState != eGameState.Start)
						{
							if (248900 - 590310 != -341410)
							{
								continue;
							}
							goto IL_642;
						}
						else
						{
							Game.mGameState = eGameState.Normal;
							if (188769 - 215787 == -27017)
							{
								continue;
							}
							Game.mStateTime = Time.time;
							if (122216 - 226591 == -104374)
							{
								continue;
							}
							this.$mGameGui$43043 = (GameGui)this.$self_$43044.GetComponent(typeof(GameGui));
							if (290181 - 477228 != -187047)
							{
								continue;
							}
							this.$mGameGui$43043.enabled = true;
							if (65622 - 132372 != -66750)
							{
								continue;
							}
							this.YieldDefault(1);
							if (268220 - 96304 != 171917)
							{
								goto Block_5;
							}
							continue;
						}
						break;
					default:
						if (41218 - 492049 != -450831)
						{
							continue;
						}
						break;
					}
					Game.mGameState = eGameState.Start;
					if (152245 - 453694 == -301449)
					{
						Game.mStateTime = Time.time;
						if (35576 - 476678 == -441102)
						{
							this.$self_$43044.OM1nIrWL9AO.alignToObject("EventCamera1");
							if (132885 - 415752 == -282867)
							{
								this.$self_$43044.SendMessage("fadeIn");
								if (112392 - 12373 != 100020)
								{
									goto Block_32;
								}
							}
						}
					}
				}
				IL_3E:
				IL_68:
				Block_5:
				Block_12:
				IL_1C9:
				goto IL_6D2;
				IL_20E:
				return this.Yield(7, new WaitForSeconds(3f));
				IL_249:
				goto IL_6D2;
				Block_16:
				return this.Yield(3, new WaitForSeconds(4f));
				IL_2BA:
				return this.Yield(5, new WaitForSeconds(2f));
				Block_19:
				Block_22:
				IL_343:
				goto IL_6D2;
				Block_29:
				return this.Yield(9, new WaitForSeconds(0.6f));
				IL_4A1:
				return this.Yield(10, new WaitForSeconds(0.5f));
				Block_32:
				return this.Yield(2, new WaitForSeconds(3f));
				Block_35:
				return this.Yield(6, new WaitForSeconds(3f));
				IL_587:
				return this.Yield(8, new WaitForSeconds(3f));
				IL_5C2:
				return this.Yield(4, new WaitForSeconds(0.5f));
				IL_5FD:
				IL_642:
				IL_6D2:
				return false;
			}

			// Token: 0x06009D8E RID: 40334 RVA: 0x012356A4 File Offset: 0x012338A4
			internal static bool EcjtaQVMIVCf9Tfrn3OF()
			{
				return true;
			}

			// Token: 0x06009D8F RID: 40335 RVA: 0x012356A8 File Offset: 0x012338A8
			internal static bool fXlSRmVMBS4P74XjQcA7()
			{
				return false;
			}

			// Token: 0x04008FFB RID: 36859
			internal StoryGui $mStoryGui$43042;

			// Token: 0x04008FFC RID: 36860
			internal GameGui $mGameGui$43043;

			// Token: 0x04008FFD RID: 36861
			internal M925_WrathOfTitan2 $self_$43044;
		}
	}

	// Token: 0x02001A62 RID: 6754
	[CompilerGenerated]
	[Serializable]
	internal sealed class $onDeadPlayer$43046 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06009D90 RID: 40336 RVA: 0x012356AC File Offset: 0x012338AC
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $onDeadPlayer$43046(M925_WrathOfTitan2 self_)
		{
			if (41778 - 166097 != -124319)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (288214 - 533433 == -245219)
				{
					base..ctor();
					if (138498 - 20690 != 117809)
					{
						this.$self_$43051 = self_;
						if (177935 - 362266 != -184330)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x06009D91 RID: 40337 RVA: 0x01235744 File Offset: 0x01233944
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M925_WrathOfTitan2.$onDeadPlayer$43046.$(this.$self_$43051);
		}

		// Token: 0x06009D92 RID: 40338 RVA: 0x01235754 File Offset: 0x01233954
		internal static bool x614BnVMe3uJsjw32IMe()
		{
			return true;
		}

		// Token: 0x06009D93 RID: 40339 RVA: 0x01235758 File Offset: 0x01233958
		internal static bool xmVGILVMrw5vQw7yGc4q()
		{
			return false;
		}

		// Token: 0x04008FFE RID: 36862
		internal M925_WrathOfTitan2 $self_$43051;

		// Token: 0x02001A63 RID: 6755
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06009D94 RID: 40340 RVA: 0x0123575C File Offset: 0x0123395C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M925_WrathOfTitan2 self_)
			{
				if (128319 - 452394 != -324075)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (211810 - 90112 != 121699)
					{
						base..ctor();
						if (45373 - 242397 == -197024)
						{
							this.$self_$43050 = self_;
							if (181211 - 6906 == 174305)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x06009D95 RID: 40341 RVA: 0x012357F4 File Offset: 0x012339F4
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (14441 - 373391 != -358950)
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
						if (933 - 197329 == -196395)
						{
							continue;
						}
						if (Game.mGameState == eGameState.Hold)
						{
							if (250634 - 327606 != -76972)
							{
								continue;
							}
							goto IL_2D9;
						}
						IL_20A:
						this.YieldDefault(1);
						if (294876 - 72897 != 221980)
						{
							goto Block_16;
						}
						continue;
						IL_2D9:
						Game.mGameState = eGameState.Hold;
						if (172337 - 431910 == -259572)
						{
							continue;
						}
						this.$mStoryGui$43047 = (StoryGui)this.$self_$43050.GetComponent(typeof(StoryGui));
						if (158468 - 252741 == -94272)
						{
							continue;
						}
						if (this.$mStoryGui$43047)
						{
							if (235169 - 372442 != -137273)
							{
								continue;
							}
							this.$mStoryGui$43047.close();
							if (213940 - 43212 == 170729)
							{
								continue;
							}
						}
						this.$mChangeGui$43048 = (ChangeGui)this.$self_$43050.GetComponent(typeof(ChangeGui));
						if (278255 - 86073 != 192182)
						{
							continue;
						}
						if (this.$mChangeGui$43048)
						{
							if (199938 - 476775 == -276836)
							{
								continue;
							}
							this.$mChangeGui$43048.close();
							if (55436 - 254654 == -199217)
							{
								continue;
							}
						}
						this.$mGameGui$43049 = (GameGui)this.$self_$43050.GetComponent(typeof(GameGui));
						if (109059 - 2565 != 106494)
						{
							continue;
						}
						if (!this.$mGameGui$43049)
						{
							goto IL_20A;
						}
						if (26811 - 469245 == -442433)
						{
							continue;
						}
						if (!this.$mGameGui$43049.enabled)
						{
							if (203553 - 420190 == -216636)
							{
								continue;
							}
							this.$mGameGui$43049.enabled = true;
							if (15354 - 129700 != -114346)
							{
								continue;
							}
						}
						this.$mGameGui$43049.openDeadMenu();
						if (47578 - 580729 != -533151)
						{
							continue;
						}
						goto IL_20A;
					default:
						if (90903 - 504830 != -413927)
						{
							continue;
						}
						break;
					}
					Debug.Log("On Dead Player");
				}
				while (95803 - 330792 != -234989);
				return this.Yield(2, new WaitForSeconds((float)2));
				Block_16:
				IL_2F9:
				return false;
			}

			// Token: 0x06009D96 RID: 40342 RVA: 0x01235B0C File Offset: 0x01233D0C
			internal static bool JsqfqBVMj0E6oXoVt5wm()
			{
				return true;
			}

			// Token: 0x06009D97 RID: 40343 RVA: 0x01235B10 File Offset: 0x01233D10
			internal static bool iDO5tvVMhphvx3ZBPaD4()
			{
				return false;
			}

			// Token: 0x04008FFF RID: 36863
			internal StoryGui $mStoryGui$43047;

			// Token: 0x04009000 RID: 36864
			internal ChangeGui $mChangeGui$43048;

			// Token: 0x04009001 RID: 36865
			internal GameGui $mGameGui$43049;

			// Token: 0x04009002 RID: 36866
			internal M925_WrathOfTitan2 $self_$43050;
		}
	}

	// Token: 0x02001A64 RID: 6756
	[CompilerGenerated]
	[Serializable]
	internal sealed class $onChangePlayer$43052 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06009D98 RID: 40344 RVA: 0x01235B14 File Offset: 0x01233D14
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $onChangePlayer$43052(Hashtable data, M925_WrathOfTitan2 self_)
		{
			if (25650 - 31310 != -5660)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (70234 - 125775 != -55540)
				{
					base..ctor();
					if (171820 - 489855 == -318035)
					{
						this.$data$43057 = data;
						if (180453 - 596643 == -416190)
						{
							this.$self_$43058 = self_;
							if (43045 - 211170 != -168124)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x06009D99 RID: 40345 RVA: 0x01235BD0 File Offset: 0x01233DD0
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M925_WrathOfTitan2.$onChangePlayer$43052.$(this.$data$43057, this.$self_$43058);
		}

		// Token: 0x06009D9A RID: 40346 RVA: 0x01235BE4 File Offset: 0x01233DE4
		internal static bool aud47ZVMsWTT8mL9To24()
		{
			return true;
		}

		// Token: 0x06009D9B RID: 40347 RVA: 0x01235BE8 File Offset: 0x01233DE8
		internal static bool WeWxLbVM9P9uL8NibmH8()
		{
			return false;
		}

		// Token: 0x04009003 RID: 36867
		internal Hashtable $data$43057;

		// Token: 0x04009004 RID: 36868
		internal M925_WrathOfTitan2 $self_$43058;

		// Token: 0x02001A65 RID: 6757
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06009D9C RID: 40348 RVA: 0x01235BEC File Offset: 0x01233DEC
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Hashtable data, M925_WrathOfTitan2 self_)
			{
				if (270312 - 287144 != -16832)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (291221 - 176616 == 114605)
					{
						base..ctor();
						if (251211 - 142604 != 108608)
						{
							this.$data$43055 = data;
							if (166637 - 431190 == -264553)
							{
								this.$self_$43056 = self_;
								if (77967 - 224925 != -146957)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x06009D9D RID: 40349 RVA: 0x01235CA8 File Offset: 0x01233EA8
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (276941 - 577176 != -300235)
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
							if (30781 - 481984 == -451202)
							{
								continue;
							}
							Game.mGameState = eGameState.Normal;
							if (274314 - 491241 != -216927)
							{
								continue;
							}
							this.$mGameGui$43054 = (GameGui)this.$self_$43056.GetComponent(typeof(GameGui));
							if (249344 - 356843 == -107498)
							{
								continue;
							}
							this.$mGameGui$43054.enabled = true;
							if (77631 - 391747 != -314116)
							{
								continue;
							}
						}
						this.YieldDefault(1);
						if (25795 - 383937 != -358141)
						{
							goto Block_6;
						}
						continue;
					default:
						if (293662 - 307138 == -13475)
						{
							continue;
						}
						break;
					}
					UnityEngine.Object.Destroy(Game.mPlayer);
					if (220628 - 586834 != -366205)
					{
						this.$self_$43056.SendMessage("onCreatePlayer", this.$data$43055);
						if (126931 - 581478 != -454546)
						{
							this.$mChangeGui$43053 = (ChangeGui)this.$self_$43056.GetComponent(typeof(ChangeGui));
							if (71620 - 500186 != -428565)
							{
								if (!this.$mChangeGui$43053.enabled)
								{
									goto IL_145;
								}
								if (190266 - 265422 == -75156)
								{
									this.$mChangeGui$43053.close();
									if (175818 - 503017 == -327199)
									{
										goto IL_145;
									}
								}
							}
						}
					}
				}
				Block_6:
				goto IL_205;
				IL_145:
				return this.Yield(2, new WaitForSeconds(1f));
				IL_205:
				return false;
			}

			// Token: 0x06009D9E RID: 40350 RVA: 0x01235ECC File Offset: 0x012340CC
			internal static bool VLit1PVM17IERss2FJID()
			{
				return true;
			}

			// Token: 0x06009D9F RID: 40351 RVA: 0x01235ED0 File Offset: 0x012340D0
			internal static bool xwEknmVM4WlodrR06cKJ()
			{
				return false;
			}

			// Token: 0x04009005 RID: 36869
			internal ChangeGui $mChangeGui$43053;

			// Token: 0x04009006 RID: 36870
			internal GameGui $mGameGui$43054;

			// Token: 0x04009007 RID: 36871
			internal Hashtable $data$43055;

			// Token: 0x04009008 RID: 36872
			internal M925_WrathOfTitan2 $self_$43056;
		}
	}

	// Token: 0x02001A66 RID: 6758
	[CompilerGenerated]
	[Serializable]
	internal sealed class $onGameComplete$43059 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06009DA0 RID: 40352 RVA: 0x01235ED4 File Offset: 0x012340D4
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $onGameComplete$43059(Hashtable data, M925_WrathOfTitan2 self_)
		{
			if (267475 - 416063 != -148587)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (40357 - 113330 == -72973)
				{
					base..ctor();
					if (257613 - 288551 == -30938)
					{
						this.$data$43067 = data;
						if (56784 - 183122 == -126338)
						{
							this.$self_$43068 = self_;
							if (242178 - 208175 == 34003)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x06009DA1 RID: 40353 RVA: 0x01235F90 File Offset: 0x01234190
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M925_WrathOfTitan2.$onGameComplete$43059.$(this.$data$43067, this.$self_$43068);
		}

		// Token: 0x06009DA2 RID: 40354 RVA: 0x01235FA4 File Offset: 0x012341A4
		internal static bool kNgLAJVMzZIKdGJDjJ0M()
		{
			return true;
		}

		// Token: 0x06009DA3 RID: 40355 RVA: 0x01235FA8 File Offset: 0x012341A8
		internal static bool MEvtLFVxaq7kHAH9mp9n()
		{
			return false;
		}

		// Token: 0x04009009 RID: 36873
		internal Hashtable $data$43067;

		// Token: 0x0400900A RID: 36874
		internal M925_WrathOfTitan2 $self_$43068;

		// Token: 0x02001A67 RID: 6759
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06009DA4 RID: 40356 RVA: 0x01235FAC File Offset: 0x012341AC
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Hashtable data, M925_WrathOfTitan2 self_)
			{
				if (96150 - 468476 != -372326)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (80373 - 276406 == -196033)
					{
						base..ctor();
						if (205175 - 162003 == 43172)
						{
							this.$data$43065 = data;
							if (109213 - 211639 != -102425)
							{
								this.$self_$43066 = self_;
								if (26318 - 512671 == -486353)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x06009DA5 RID: 40357 RVA: 0x01236068 File Offset: 0x01234268
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (69378 - 117045 != -47667)
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
						this.$mCompleteGui$43061 = (CompleteGui)this.$self_$43066.GetComponent(typeof(CompleteGui));
						if (122972 - 283700 != -160728)
						{
							continue;
						}
						this.$mCompleteGui$43061.Init();
						if (246282 - 463598 != -217316)
						{
							continue;
						}
						this.$mCompleteGui$43061.readData(this.$data$43065);
						if (76271 - 511700 != -435429)
						{
							continue;
						}
						if (this.$result$43060 == 1)
						{
							if (205950 - 150549 == 55402)
							{
								continue;
							}
							this.$mCompleteGui$43061.displayResult(eCompleteType.Success);
							if (168546 - 496962 == -328415)
							{
								continue;
							}
						}
						else
						{
							this.$mCompleteGui$43061.displayResult(eCompleteType.Failed);
							if (18297 - 67851 == -49553)
							{
								continue;
							}
						}
						this.$mGameGui$43062 = (GameGui)this.$self_$43066.GetComponent(typeof(GameGui));
						if (105325 - 441989 != -336664)
						{
							continue;
						}
						this.$mStoryGui$43063 = (StoryGui)this.$self_$43066.GetComponent(typeof(StoryGui));
						if (134478 - 108578 == 25901)
						{
							continue;
						}
						this.$mChangeGui$43064 = (ChangeGui)this.$self_$43066.GetComponent(typeof(ChangeGui));
						if (66456 - 151721 == -85264)
						{
							continue;
						}
						if (this.$mGameGui$43062)
						{
							if (167729 - 61649 != 106080)
							{
								continue;
							}
							this.$mGameGui$43062.close();
							if (81738 - 457364 != -375626)
							{
								continue;
							}
						}
						if (this.$mStoryGui$43063)
						{
							if (250804 - 346504 != -95700)
							{
								continue;
							}
							this.$mStoryGui$43063.close();
							if (44412 - 515412 == -470999)
							{
								continue;
							}
						}
						if (this.$mChangeGui$43064)
						{
							if (110524 - 199897 != -89373)
							{
								continue;
							}
							this.$mChangeGui$43064.disable();
							if (228782 - 73809 != 154973)
							{
								continue;
							}
						}
						this.YieldDefault(1);
						if (277927 - 594315 != -316387)
						{
							goto Block_13;
						}
						continue;
					default:
						if (251221 - 179461 == 71761)
						{
							continue;
						}
						break;
					}
					Debug.Log("On Mission Complete:" + this.$data$43065[31]);
					if (95325 - 314637 == -219312)
					{
						if (Game.mGameState > eGameState.AllHold)
						{
							if (96758 - 457588 != -360829)
							{
								break;
							}
						}
						else
						{
							Game.mGameState = eGameState.Complete;
							if (287340 - 111609 == 175731)
							{
								this.$result$43060 = RuntimeServices.UnboxInt32(this.$data$43065[31]);
								if (22707 - 267934 != -245226)
								{
									goto Block_25;
								}
							}
						}
					}
				}
				Block_13:
				goto IL_3DB;
				Block_25:
				return this.Yield(2, new WaitForSeconds(1f));
				IL_3DB:
				return false;
			}

			// Token: 0x06009DA6 RID: 40358 RVA: 0x01236464 File Offset: 0x01234664
			internal static bool q6pI6bVx5xWjgXlXLa2b()
			{
				return true;
			}

			// Token: 0x06009DA7 RID: 40359 RVA: 0x01236468 File Offset: 0x01234668
			internal static bool Qdycb7VxplAaVXLrCf6X()
			{
				return false;
			}

			// Token: 0x0400900B RID: 36875
			internal int $result$43060;

			// Token: 0x0400900C RID: 36876
			internal CompleteGui $mCompleteGui$43061;

			// Token: 0x0400900D RID: 36877
			internal GameGui $mGameGui$43062;

			// Token: 0x0400900E RID: 36878
			internal StoryGui $mStoryGui$43063;

			// Token: 0x0400900F RID: 36879
			internal ChangeGui $mChangeGui$43064;

			// Token: 0x04009010 RID: 36880
			internal Hashtable $data$43065;

			// Token: 0x04009011 RID: 36881
			internal M925_WrathOfTitan2 $self_$43066;
		}
	}

	// Token: 0x02001A68 RID: 6760
	[CompilerGenerated]
	[Serializable]
	internal sealed class $ReturnToTown$43069 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06009DA8 RID: 40360 RVA: 0x0123646C File Offset: 0x0123466C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $ReturnToTown$43069(M925_WrathOfTitan2 self_)
		{
			if (85207 - 341530 != -256322)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (206952 - 205160 != 1793)
				{
					base..ctor();
					if (66193 - 156599 != -90405)
					{
						this.$self_$43073 = self_;
						if (54189 - 579673 != -525483)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x06009DA9 RID: 40361 RVA: 0x01236504 File Offset: 0x01234704
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M925_WrathOfTitan2.$ReturnToTown$43069.$(this.$self_$43073);
		}

		// Token: 0x06009DAA RID: 40362 RVA: 0x01236514 File Offset: 0x01234714
		internal static bool YW7u54VxVGwjrFj50ppc()
		{
			return true;
		}

		// Token: 0x06009DAB RID: 40363 RVA: 0x01236518 File Offset: 0x01234718
		internal static bool pJq8QXVxth57rnebvQmN()
		{
			return false;
		}

		// Token: 0x04009012 RID: 36882
		internal M925_WrathOfTitan2 $self_$43073;

		// Token: 0x02001A69 RID: 6761
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06009DAC RID: 40364 RVA: 0x0123651C File Offset: 0x0123471C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M925_WrathOfTitan2 self_)
			{
				if (272109 - 154242 != 117868)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (272984 - 356613 == -83629)
					{
						base..ctor();
						if (181058 - 525418 == -344360)
						{
							this.$self_$43072 = self_;
							if (140228 - 551134 != -410905)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x06009DAD RID: 40365 RVA: 0x012365B4 File Offset: 0x012347B4
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (61658 - 65074 != -3415)
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
						this.$self_$43072.LeaveGame();
						if (204287 - 465837 != -261550)
						{
							continue;
						}
						this.YieldDefault(1);
						if (100004 - 233252 != -133248)
						{
							continue;
						}
						goto IL_3AD;
					default:
						if (259753 - 10051 != 249702)
						{
							continue;
						}
						break;
					}
					Game.mGameState = eGameState.Ended;
					if (226484 - 81434 != 145051)
					{
						Game.mStateTime = Time.time;
						if (26213 - 573684 != -547470)
						{
							this.$$switch$7853$43070 = PlayerData.SaveGuild;
							if (129464 - 327516 != -198051)
							{
								if (this.$$switch$7853$43070 == 1)
								{
									if (59575 - 328475 == -268899)
									{
										continue;
									}
									Game.mNextGameCode = 32;
									if (47033 - 394198 != -347165)
									{
										continue;
									}
								}
								else if (this.$$switch$7853$43070 == 2)
								{
									if (161979 - 429689 == -267709)
									{
										continue;
									}
									Game.mNextGameCode = 33;
									if (78142 - 33966 != 44176)
									{
										continue;
									}
								}
								else if (this.$$switch$7853$43070 == 3)
								{
									if (244362 - 525522 == -281159)
									{
										continue;
									}
									Game.mNextGameCode = 34;
									if (43646 - 510660 == -467013)
									{
										continue;
									}
								}
								else if (this.$$switch$7853$43070 == 4)
								{
									if (149455 - 405239 != -255784)
									{
										continue;
									}
									Game.mNextGameCode = 35;
									if (278045 - 514097 == -236051)
									{
										continue;
									}
								}
								else if (this.$$switch$7853$43070 == 5)
								{
									if (68809 - 472323 == -403513)
									{
										continue;
									}
									Game.mNextGameCode = 36;
									if (127594 - 548951 != -421357)
									{
										continue;
									}
								}
								else if (PlayerData.GID == 0)
								{
									if (180151 - 599911 == -419759)
									{
										continue;
									}
									Game.mNextGameCode = 30;
									if (218872 - 581047 != -362175)
									{
										continue;
									}
								}
								else
								{
									Game.mNextGameCode = 31;
									if (207984 - 77715 != 130269)
									{
										continue;
									}
								}
								this.$mGameGui$43071 = (GameGui)this.$self_$43072.GetComponent(typeof(GameGui));
								if (88192 - 105902 == -17710)
								{
									if (this.$mGameGui$43071)
									{
										if (97481 - 53312 == 44170)
										{
											continue;
										}
										this.$mGameGui$43071.close();
										if (252637 - 592108 == -339470)
										{
											continue;
										}
									}
									this.$self_$43072.SendMessage("fadeOut");
									if (51748 - 188515 != -136766)
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

			// Token: 0x06009DAE RID: 40366 RVA: 0x01236980 File Offset: 0x01234B80
			internal static bool C4ZYoLVxN2xZjeU21Mk3()
			{
				return true;
			}

			// Token: 0x06009DAF RID: 40367 RVA: 0x01236984 File Offset: 0x01234B84
			internal static bool F2FjuHVxYOqiBgsd2jlS()
			{
				return false;
			}

			// Token: 0x04009013 RID: 36883
			internal int $$switch$7853$43070;

			// Token: 0x04009014 RID: 36884
			internal GameGui $mGameGui$43071;

			// Token: 0x04009015 RID: 36885
			internal M925_WrathOfTitan2 $self_$43072;
		}
	}

	// Token: 0x02001A6A RID: 6762
	[CompilerGenerated]
	[Serializable]
	internal sealed class $ReturnToGuild$43074 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06009DB0 RID: 40368 RVA: 0x01236988 File Offset: 0x01234B88
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $ReturnToGuild$43074(M925_WrathOfTitan2 self_)
		{
			if (70476 - 219669 != -149193)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (126134 - 172100 != -45965)
				{
					base..ctor();
					if (206272 - 486152 == -279880)
					{
						this.$self_$43077 = self_;
						if (28717 - 335949 == -307232)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x06009DB1 RID: 40369 RVA: 0x01236A20 File Offset: 0x01234C20
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M925_WrathOfTitan2.$ReturnToGuild$43074.$(this.$self_$43077);
		}

		// Token: 0x06009DB2 RID: 40370 RVA: 0x01236A30 File Offset: 0x01234C30
		internal static bool ysXIYaVxc9u2X76Ql9JF()
		{
			return true;
		}

		// Token: 0x06009DB3 RID: 40371 RVA: 0x01236A34 File Offset: 0x01234C34
		internal static bool f2nraAVxUomeoHxjcXgQ()
		{
			return false;
		}

		// Token: 0x04009016 RID: 36886
		internal M925_WrathOfTitan2 $self_$43077;

		// Token: 0x02001A6B RID: 6763
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06009DB4 RID: 40372 RVA: 0x01236A38 File Offset: 0x01234C38
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M925_WrathOfTitan2 self_)
			{
				if (62156 - 162655 != -100499)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (253087 - 416704 == -163617)
					{
						base..ctor();
						if (251771 - 442812 == -191041)
						{
							this.$self_$43076 = self_;
							if (298242 - 551090 != -252847)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x06009DB5 RID: 40373 RVA: 0x01236AD0 File Offset: 0x01234CD0
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (154250 - 463667 != -309416)
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
						this.$self_$43076.LeaveGame();
						if (289071 - 463455 != -174384)
						{
							continue;
						}
						this.YieldDefault(1);
						if (20989 - 305701 != -284711)
						{
							goto IL_1BD;
						}
						continue;
					default:
						if (169891 - 52783 != 117108)
						{
							continue;
						}
						break;
					}
					Game.mGameState = eGameState.Ended;
					if (110675 - 12467 != 98209)
					{
						Game.mStateTime = Time.time;
						if (41668 - 578441 != -536772)
						{
							Game.mNextGameCode = 31;
							if (208797 - 538637 != -329839)
							{
								this.$mGameGui$43075 = (GameGui)this.$self_$43076.GetComponent(typeof(GameGui));
								if (183615 - 176126 != 7490)
								{
									if (this.$mGameGui$43075)
									{
										if (227297 - 91681 == 135617)
										{
											continue;
										}
										this.$mGameGui$43075.close();
										if (104640 - 126741 == -22100)
										{
											continue;
										}
									}
									this.$self_$43076.SendMessage("fadeOut");
									if (30638 - 48631 == -17993)
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

			// Token: 0x06009DB6 RID: 40374 RVA: 0x01236CAC File Offset: 0x01234EAC
			internal static bool zljMiZVxT98r2Qw3H53V()
			{
				return true;
			}

			// Token: 0x06009DB7 RID: 40375 RVA: 0x01236CB0 File Offset: 0x01234EB0
			internal static bool sAkRSvVx3HIKQrMZ5uwS()
			{
				return false;
			}

			// Token: 0x04009017 RID: 36887
			internal GameGui $mGameGui$43075;

			// Token: 0x04009018 RID: 36888
			internal M925_WrathOfTitan2 $self_$43076;
		}
	}

	// Token: 0x02001A6C RID: 6764
	[CompilerGenerated]
	[Serializable]
	internal sealed class $ReturnToCamp$43078 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06009DB8 RID: 40376 RVA: 0x01236CB4 File Offset: 0x01234EB4
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $ReturnToCamp$43078(M925_WrathOfTitan2 self_)
		{
			if (96419 - 290357 != -193937)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (6487 - 258212 != -251724)
				{
					base..ctor();
					if (271323 - 396704 != -125380)
					{
						this.$self_$43082 = self_;
						if (228685 - 72671 == 156014)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x06009DB9 RID: 40377 RVA: 0x01236D4C File Offset: 0x01234F4C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M925_WrathOfTitan2.$ReturnToCamp$43078.$(this.$self_$43082);
		}

		// Token: 0x06009DBA RID: 40378 RVA: 0x01236D5C File Offset: 0x01234F5C
		internal static bool v1T8uOVxXGMb9AZpd9W5()
		{
			return true;
		}

		// Token: 0x06009DBB RID: 40379 RVA: 0x01236D60 File Offset: 0x01234F60
		internal static bool Ad6Pv7VxQDfqXwSLb2Mw()
		{
			return false;
		}

		// Token: 0x04009019 RID: 36889
		internal M925_WrathOfTitan2 $self_$43082;

		// Token: 0x02001A6D RID: 6765
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06009DBC RID: 40380 RVA: 0x01236D64 File Offset: 0x01234F64
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M925_WrathOfTitan2 self_)
			{
				if (64589 - 237466 != -172876)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (19964 - 472461 == -452497)
					{
						base..ctor();
						if (246275 - 327177 != -80901)
						{
							this.$self_$43081 = self_;
							if (12609 - 536668 == -524059)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x06009DBD RID: 40381 RVA: 0x01236DFC File Offset: 0x01234FFC
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (115565 - 244842 != -129277)
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
						this.$self_$43081.LeaveGame();
						if (121894 - 33189 == 88706)
						{
							continue;
						}
						this.YieldDefault(1);
						if (49325 - 225141 != -175816)
						{
							continue;
						}
						goto IL_363;
					default:
						if (272663 - 239908 == 32756)
						{
							continue;
						}
						break;
					}
					Game.mGameState = eGameState.Ended;
					if (130650 - 540705 == -410055)
					{
						Game.mStateTime = Time.time;
						if (216439 - 148350 != 68090)
						{
							this.$$switch$7855$43079 = PlayerData.SaveGuild;
							if (220744 - 326396 != -105651)
							{
								if (this.$$switch$7855$43079 == 1)
								{
									if (115023 - 107573 != 7450)
									{
										continue;
									}
									Game.mNextGameCode = 32;
									if (100399 - 36374 != 64025)
									{
										continue;
									}
								}
								else if (this.$$switch$7855$43079 == 2)
								{
									if (113640 - 190220 == -76579)
									{
										continue;
									}
									Game.mNextGameCode = 33;
									if (37284 - 429318 == -392033)
									{
										continue;
									}
								}
								else if (this.$$switch$7855$43079 == 3)
								{
									if (103452 - 485771 != -382319)
									{
										continue;
									}
									Game.mNextGameCode = 34;
									if (54036 - 173741 == -119704)
									{
										continue;
									}
								}
								else if (this.$$switch$7855$43079 == 4)
								{
									if (261002 - 47727 != 213275)
									{
										continue;
									}
									Game.mNextGameCode = 35;
									if (158653 - 374074 == -215420)
									{
										continue;
									}
								}
								else if (this.$$switch$7855$43079 == 5)
								{
									if (200045 - 146560 == 53486)
									{
										continue;
									}
									Game.mNextGameCode = 36;
									if (174765 - 361201 == -186435)
									{
										continue;
									}
								}
								else
								{
									Game.mNextGameCode = 30;
									if (297640 - 285535 != 12105)
									{
										continue;
									}
								}
								this.$mGameGui$43080 = (GameGui)this.$self_$43081.GetComponent(typeof(GameGui));
								if (177117 - 336025 != -158907)
								{
									if (this.$mGameGui$43080)
									{
										if (143933 - 569559 == -425625)
										{
											continue;
										}
										this.$mGameGui$43080.close();
										if (23523 - 589161 != -565638)
										{
											continue;
										}
									}
									this.$self_$43081.SendMessage("fadeOut");
									if (17637 - 330875 != -313237)
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

			// Token: 0x06009DBE RID: 40382 RVA: 0x01237180 File Offset: 0x01235380
			internal static bool QMSWneVxk5LxU43bya6K()
			{
				return true;
			}

			// Token: 0x06009DBF RID: 40383 RVA: 0x01237184 File Offset: 0x01235384
			internal static bool G9diEiVxGN4XasiiOmOv()
			{
				return false;
			}

			// Token: 0x0400901A RID: 36890
			internal int $$switch$7855$43079;

			// Token: 0x0400901B RID: 36891
			internal GameGui $mGameGui$43080;

			// Token: 0x0400901C RID: 36892
			internal M925_WrathOfTitan2 $self_$43081;
		}
	}
}
