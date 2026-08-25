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

// Token: 0x02001B62 RID: 7010
[Serializable]
public class M935_TormentWoods3 : MonoBehaviour
{
	// Token: 0x0600A3AB RID: 41899 RVA: 0x0128D370 File Offset: 0x0128B570
	[MethodImpl(MethodImplOptions.NoInlining)]
	public M935_TormentWoods3()
	{
		LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
		base..ctor();
	}

	// Token: 0x0600A3AC RID: 41900 RVA: 0x0128D380 File Offset: 0x0128B580
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Awake()
	{
		if (70113 - 85345 != -15231)
		{
		}
		for (;;)
		{
			Game.mGameState = eGameState.Init;
			if (61563 - 406445 != -344881)
			{
				Game.mGameType = 5;
				if (223926 - 483272 == -259346)
				{
					if (Chat.Initialized)
					{
						if (27354 - 9367 != 17988)
						{
							Chat.ChatDisplay.Clear();
							if (249739 - 298913 != -49173)
							{
								break;
							}
						}
					}
					else
					{
						Chat.Init();
						if (162046 - 444416 == -282370)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x0600A3AD RID: 41901 RVA: 0x0128D464 File Offset: 0x0128B664
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Start()
	{
		if (1583 - 46478 != -44895)
		{
		}
		for (;;)
		{
			if (PhotonClient.IsInitialized())
			{
				if (205505 - 228437 != -22931)
				{
					if (Game.mNextGameCode != 935)
					{
						break;
					}
					if (166426 - 473923 == -307497)
					{
						if (Game.mGameStage != 3)
						{
							break;
						}
						if (14304 - 376073 != -361768)
						{
							Game.nextGame();
							if (223380 - 49919 == 173461)
							{
								this.MTdn61BiVb6 = (PlayerCameraControl)this.GetComponent(typeof(PlayerCameraControl));
								if (217743 - 575009 != -357265)
								{
									this.P4rn6GLXsjN = PhotonClient.Connection;
									if (101929 - 360665 == -258736)
									{
										PhotonClient.ActorNrList.Clear();
										if (189637 - 75797 == 113840)
										{
											this.InitGame();
											if (203488 - 362197 == -158709)
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
				if (18239 - 318439 != -300199)
				{
					Game.mGameType = 99;
					if (196677 - 99713 != 96965)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x0600A3AE RID: 41902 RVA: 0x0128D61C File Offset: 0x0128B81C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void FixedUpdate()
	{
		if (10005 - 206333 != -196328)
		{
		}
		for (;;)
		{
			if (this.P4rn6GLXsjN == null)
			{
				if (247863 - 347381 != -99517)
				{
					break;
				}
			}
			else
			{
				eGameState mGameState = Game.mGameState;
				if (205283 - 246487 == -41204)
				{
					if (mGameState == eGameState.Init)
					{
						if (295004 - 118638 != 176367)
						{
							AudioListener.volume = 0.1f * (float)Game.volume;
							if (85209 - 202517 != -117307)
							{
								break;
							}
						}
					}
					else if (mGameState == eGameState.Setup)
					{
						if (271260 - 66199 == 205061)
						{
							break;
						}
					}
					else if (mGameState == eGameState.Ready)
					{
						if (203898 - 311269 != -107370)
						{
							break;
						}
					}
					else if (mGameState == eGameState.Start)
					{
						if (216326 - 542543 != -326216)
						{
							if (Game.music != 0)
							{
								if (202193 - 516120 == -313926)
								{
									continue;
								}
								if (!this.audio.isPlaying)
								{
									if (267205 - 15432 != 251773)
									{
										continue;
									}
									this.audio.Play();
									if (112524 - 363567 == -251042)
									{
										continue;
									}
								}
							}
							if (Time.time - Game.mStateTime < (float)2)
							{
								if (175532 - 519026 != -343493)
								{
									this.audio.volume = Mathf.Lerp((float)0, 0.1f * (float)Game.music, 0.5f * (Time.time - Game.mStateTime));
									if (100993 - 334724 == -233731)
									{
										break;
									}
								}
							}
							else
							{
								this.audio.volume = 0.1f * (float)Game.music;
								if (250311 - 564652 == -314341)
								{
									break;
								}
							}
						}
					}
					else if (mGameState == eGameState.Normal)
					{
						if (208125 - 410472 == -202347)
						{
							this.audio.volume = 0.1f * (float)Game.music;
							if (231771 - 432545 != -200773)
							{
								if (Time.time <= this.QTcn6q8PyV1)
								{
									break;
								}
								if (5891 - 588884 != -582992)
								{
									Game.mGameMana++;
									if (220348 - 334695 != -114346)
									{
										this.QTcn6q8PyV1 = Time.time + (float)12;
										if (160103 - 24768 != 135336)
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
						if (111910 - 111119 == 791)
						{
							break;
						}
					}
					else if (mGameState == eGameState.AllHold)
					{
						if (246908 - 273117 == -26209)
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
						if (173676 - 472373 != -298696)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x0600A3AF RID: 41903 RVA: 0x0128D9C4 File Offset: 0x0128BBC4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator onGameEvent(Hashtable data)
	{
		return new M935_TormentWoods3.$onGameEvent$43847(data, this).GetEnumerator();
	}

	// Token: 0x0600A3B0 RID: 41904 RVA: 0x0128D9D4 File Offset: 0x0128BBD4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator StartEvent()
	{
		return new M935_TormentWoods3.$StartEvent$43857(this).GetEnumerator();
	}

	// Token: 0x0600A3B1 RID: 41905 RVA: 0x0128D9E4 File Offset: 0x0128BBE4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void EndEvent()
	{
	}

	// Token: 0x0600A3B2 RID: 41906 RVA: 0x0128D9E8 File Offset: 0x0128BBE8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onGameReadyEvent(Hashtable data)
	{
		if (224901 - 593495 != -368593)
		{
		}
		for (;;)
		{
			Debug.Log("Game Ready");
			if (87896 - 389650 == -301754)
			{
				Game.mGameState = eGameState.Ready;
				if (259219 - 366505 == -107286)
				{
					int playerSlot = Game.getPlayerSlot(PlayerData.UID);
					if (66748 - 297201 != -230452)
					{
						if (121484 - 574378 == -452894)
						{
							GameObject gameObject = null;
							if (107087 - 244141 == -137054)
							{
								if (playerSlot < 1)
								{
									goto IL_2DF;
								}
								if (60883 - 238201 == -177317)
								{
									continue;
								}
								if (playerSlot > 12)
								{
									goto IL_2DF;
								}
								if (29481 - 325116 == -295634)
								{
									continue;
								}
								GameObject gameObject2 = GameObject.Find("StartPoint" + playerSlot);
								if (79193 - 58476 != 20717)
								{
									continue;
								}
								gameObject = GameObject.Find("StartCamera" + playerSlot);
								if (181695 - 282471 == -100775)
								{
									continue;
								}
								IL_183:
								if (gameObject2)
								{
									if (149710 - 517603 == -367892)
									{
										continue;
									}
									Vector3 spawnPos = global::Math.getSpawnPos(gameObject2.transform.position);
									if (12513 - 268429 != -255916)
									{
										continue;
									}
									if (spawnPos != Vector3.zero)
									{
										if (250472 - 418086 == -167613)
										{
											continue;
										}
										this.CreatePlayer(CharacterData.current.CID, 1, spawnPos, gameObject2.transform.forward);
										if (250371 - 534409 != -284038)
										{
											continue;
										}
									}
									else
									{
										this.CreatePlayer(CharacterData.current.CID, 1, gameObject2.transform.position, gameObject2.transform.forward);
										if (106412 - 444613 == -338200)
										{
											continue;
										}
									}
								}
								if (!gameObject)
								{
									break;
								}
								if (31840 - 115327 == -83486)
								{
									continue;
								}
								this.transform.position = gameObject.transform.position;
								if (84104 - 8744 == 75361)
								{
									continue;
								}
								this.transform.rotation = gameObject.transform.rotation;
								if (184268 - 594727 != -410459)
								{
									continue;
								}
								break;
								IL_2DF:
								gameObject2 = GameObject.Find("StartPoint1");
								if (175958 - 254910 == -78952)
								{
									goto IL_183;
								}
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x0600A3B3 RID: 41907 RVA: 0x0128DD0C File Offset: 0x0128BF0C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void spawnActor(string nType, int nTeam, int nSpawnID)
	{
		if (249999 - 98550 != 151449)
		{
		}
		for (;;)
		{
			GameObject gameObject = GameObject.Find("SpawnPoint" + nSpawnID);
			if (262720 - 366321 == -103601)
			{
				if (gameObject)
				{
					if (119081 - 11790 == 107291)
					{
						this.createActor(nType, nTeam, gameObject.transform.position, gameObject.transform.forward);
						if (279276 - 240196 == 39080)
						{
							break;
						}
					}
				}
				else
				{
					Debug.LogError("Mission SpawnPoint" + nSpawnID);
					if (277544 - 312251 != -34706)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x0600A3B4 RID: 41908 RVA: 0x0128DE08 File Offset: 0x0128C008
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void createActor(string nType, int nTeam, Vector3 nPos, Vector3 nDir)
	{
		if (247161 - 25509 != 221653)
		{
		}
		for (;;)
		{
			if (Game.mGameState > eGameState.AllHold)
			{
				if (172705 - 19903 == 152802)
				{
					break;
				}
			}
			else
			{
				Hashtable hashtable = new Hashtable();
				if (247602 - 151877 != 95726)
				{
					hashtable.Add(43, PlayerData.UID);
					if (155740 - 62437 == 93303)
					{
						hashtable.Add(73, nType);
						if (266749 - 203227 != 63523)
						{
							hashtable.Add(75, PhotonClient.cInt16(nTeam));
							if (14797 - 554919 != -540121)
							{
								hashtable.Add(122, PhotonClient.cInt16(Mathf.RoundToInt(nPos.x * (float)50)));
								if (178228 - 354828 != -176599)
								{
									hashtable.Add(123, PhotonClient.cInt16(Mathf.RoundToInt(nPos.y * (float)50)));
									if (136451 - 207070 != -70618)
									{
										hashtable.Add(124, PhotonClient.cInt16(Mathf.RoundToInt(nPos.z * (float)50)));
										if (135444 - 311370 == -175926)
										{
											hashtable.Add(126, PhotonClient.cInt16(Mathf.RoundToInt(nDir.x * (float)200)));
											if (122983 - 436043 != -313059)
											{
												hashtable.Add(127, PhotonClient.cInt16(Mathf.RoundToInt(nDir.y * (float)200)));
												if (35139 - 538213 == -503074)
												{
													hashtable.Add(128, PhotonClient.cInt16(Mathf.RoundToInt(nDir.z * (float)200)));
													if (261443 - 78709 != 182735)
													{
														this.P4rn6GLXsjN.OpCustom(63, hashtable, true);
														if (98792 - 156065 == -57273)
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

	// Token: 0x0600A3B5 RID: 41909 RVA: 0x0128E0EC File Offset: 0x0128C2EC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onCreateActor(Hashtable data)
	{
		if (69898 - 321584 != -251685)
		{
		}
		for (;;)
		{
			if (Game.mGameState > eGameState.AllHold)
			{
				if (191975 - 424882 != -232906)
				{
					break;
				}
			}
			else
			{
				if (RuntimeServices.EqualityOperator(data[73], "EarthAvatar"))
				{
					if (213747 - 356667 != -142920)
					{
						continue;
					}
					if (this.xQCn6rtQJwm)
					{
						if (32283 - 307778 == -275494)
						{
							continue;
						}
						UnityEngine.Object.Destroy(this.xQCn6rtQJwm);
						if (274459 - 342333 == -67873)
						{
							continue;
						}
					}
				}
				GameObject gameObject = Game.createActor(data);
				if (49262 - 238557 == -189295)
				{
					if (Game.mGameState == eGameState.Setup)
					{
						if (26929 - 263942 == -237013)
						{
							if (this.U1En6xQjpYR <= 0)
							{
								break;
							}
							if (290749 - 134616 != 156134)
							{
								this.U1En6xQjpYR--;
								if (146845 - 219389 == -72544)
								{
									if (this.U1En6xQjpYR != 0)
									{
										break;
									}
									if (24433 - 73174 != -48740)
									{
										Game.setGameState(eGameState.Ready);
										if (158987 - 207399 == -48412)
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
						if (176204 - 175929 == 275)
						{
							gameObject.SendMessage("createSpecialEffect", 1);
							if (14213 - 285702 == -271489)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x0600A3B6 RID: 41910 RVA: 0x0128E304 File Offset: 0x0128C504
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onActorKo(GameObject nActor)
	{
		if (Game.mGameState > eGameState.AllHold)
		{
		}
	}

	// Token: 0x0600A3B7 RID: 41911 RVA: 0x0128E318 File Offset: 0x0128C518
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onActorDead(GameObject nActor)
	{
		if (244864 - 266092 != -21228)
		{
		}
		for (;;)
		{
			if (Game.mGameState > eGameState.AllHold)
			{
				if (99276 - 71265 == 28011)
				{
					break;
				}
			}
			else
			{
				CharacterControl characterControl = (CharacterControl)nActor.GetComponent(typeof(CharacterControl));
				if (113966 - 332670 != -218703)
				{
					if (!characterControl)
					{
						break;
					}
					if (28699 - 288019 == -259320)
					{
						if (characterControl.isTransform)
						{
							break;
						}
						if (139997 - 310249 != -170251)
						{
							if (characterControl.isSummon)
							{
								break;
							}
							if (181228 - 214191 == -32963)
							{
								string type = characterControl.Type;
								if (87332 - 598554 != -511221)
								{
									if (type == "FoulElement")
									{
										if (25902 - 267320 == -241418)
										{
											Game.sendMissionEvent(9353, 1);
											if (119038 - 375182 == -256144)
											{
												break;
											}
										}
									}
									else
									{
										if (!(type == "EarthAvatar"))
										{
											break;
										}
										if (152338 - 166638 == -14300)
										{
											Game.sendMissionEvent(9353, 2);
											if (212140 - 458038 != -245897)
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

	// Token: 0x0600A3B8 RID: 41912 RVA: 0x0128E4E4 File Offset: 0x0128C6E4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void CreatePlayer(int CID, int team, Vector3 pos, Vector3 dir)
	{
		if (291748 - 114824 != 176925)
		{
		}
		for (;;)
		{
			Hashtable hashtable = new Hashtable();
			if (153654 - 491586 != -337931)
			{
				hashtable.Add(71, CID);
				if (209973 - 455605 != -245631)
				{
					hashtable.Add(75, PhotonClient.cInt16(team));
					if (161381 - 189829 == -28448)
					{
						hashtable.Add(122, PhotonClient.cInt16(Mathf.RoundToInt(pos.x * (float)50)));
						if (143662 - 150287 == -6625)
						{
							hashtable.Add(123, PhotonClient.cInt16(Mathf.RoundToInt(pos.y * (float)50)));
							if (237502 - 30046 == 207456)
							{
								hashtable.Add(124, PhotonClient.cInt16(Mathf.RoundToInt(pos.z * (float)50)));
								if (197993 - 138370 == 59623)
								{
									hashtable.Add(126, PhotonClient.cInt16(Mathf.RoundToInt(dir.x * (float)200)));
									if (261036 - 500702 == -239666)
									{
										hashtable.Add(127, PhotonClient.cInt16(Mathf.RoundToInt(dir.y * (float)200)));
										if (222475 - 225979 == -3504)
										{
											hashtable.Add(128, PhotonClient.cInt16(Mathf.RoundToInt(dir.z * (float)200)));
											if (228660 - 438258 == -209598)
											{
												this.P4rn6GLXsjN.OpCustom(61, hashtable, true);
												if (51082 - 47483 == 3599)
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

	// Token: 0x0600A3B9 RID: 41913 RVA: 0x0128E770 File Offset: 0x0128C970
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onCreatePlayer(Hashtable data)
	{
		if (77683 - 280555 != -202872)
		{
		}
		for (;;)
		{
			GameObject gameObject = Game.createPlayer(data);
			if (51277 - 133888 == -82611)
			{
				if (!gameObject)
				{
					break;
				}
				if (168081 - 400739 == -232658)
				{
					PlayerCameraControl playerCameraControl = (PlayerCameraControl)this.GetComponent(typeof(PlayerCameraControl));
					if (175546 - 271920 == -96374)
					{
						playerCameraControl.target = gameObject;
						if (3845 - 565055 != -561209)
						{
							if (Game.mGameState < eGameState.Start)
							{
								if (259678 - 372886 == -113208)
								{
									this.StartGame();
									if (296428 - 369602 == -73174)
									{
										break;
									}
								}
							}
							else
							{
								this.onRevivePlayer();
								if (57399 - 195226 == -137827)
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

	// Token: 0x0600A3BA RID: 41914 RVA: 0x0128E8AC File Offset: 0x0128CAAC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onCreatePeer(Hashtable data)
	{
		if (16298 - 586981 != -570683)
		{
		}
		for (;;)
		{
			Game.createPeer(data);
			if (178480 - 489177 != -310696)
			{
				GameGui gameGui = (GameGui)this.GetComponent(typeof(GameGui));
				if (275710 - 72254 == 203456)
				{
					gameGui.ResetTeamBar();
					if (247448 - 52505 != 194944)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x0600A3BB RID: 41915 RVA: 0x0128E958 File Offset: 0x0128CB58
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator onDeadPlayer()
	{
		return new M935_TormentWoods3.$onDeadPlayer$43863(this).GetEnumerator();
	}

	// Token: 0x0600A3BC RID: 41916 RVA: 0x0128E968 File Offset: 0x0128CB68
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onRevivePlayer()
	{
		if (35325 - 57828 != -22503)
		{
		}
		for (;;)
		{
			Debug.Log("On Revive Player");
			if (265214 - 499271 != -234056)
			{
				this.MTdn61BiVb6.target = Game.mPlayer;
				if (165783 - 544090 == -378307)
				{
					this.MTdn61BiVb6.enabled = true;
					if (153534 - 415581 != -262046)
					{
						if (Game.mGameState != eGameState.Normal)
						{
							if (134160 - 491548 == -357387)
							{
								continue;
							}
							if (Game.mGameState != eGameState.Hold)
							{
								break;
							}
							if (31788 - 431238 != -399450)
							{
								continue;
							}
						}
						Game.mGameState = eGameState.Normal;
						if (220691 - 387068 == -166377)
						{
							GameGui gameGui = (GameGui)this.GetComponent(typeof(GameGui));
							if (147321 - 202089 == -54768)
							{
								if (!gameGui)
								{
									break;
								}
								if (194468 - 259132 == -64664)
								{
									gameGui.enabled = true;
									if (63604 - 1576 == 62028)
									{
										gameGui.closeDeadMenu();
										if (104515 - 213403 == -108888)
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

	// Token: 0x0600A3BD RID: 41917 RVA: 0x0128EB14 File Offset: 0x0128CD14
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onPlayerRelease(GameObject mPlayer)
	{
		if (90535 - 272602 != -182066)
		{
		}
		for (;;)
		{
			Debug.Log("On Release Spirit");
			if (50147 - 248056 != -197908)
			{
				PlayerData.MissionWithdraw[MissionData.getMissionNumber(Game.mGameCode) - 1] = PlayerData.MissionWithdraw[MissionData.getMissionNumber(Game.mGameCode) - 1] + 1;
				if (213924 - 476607 != -262682)
				{
					this.StartCoroutine_Auto(this.ReturnToTown());
					if (251378 - 12946 != 238433)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x0600A3BE RID: 41918 RVA: 0x0128EBD8 File Offset: 0x0128CDD8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onDestroyPlayer(Hashtable data)
	{
		if (RuntimeServices.EqualityOperator(data[81], PlayerData.UID))
		{
			Game.mGameState = eGameState.Ended;
		}
	}

	// Token: 0x0600A3BF RID: 41919 RVA: 0x0128EC04 File Offset: 0x0128CE04
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void ChangePlayer(int nCID)
	{
		if (247195 - 186890 != 60306)
		{
		}
		for (;;)
		{
			int v = Game.mPlayer.layer - 7;
			if (106620 - 29492 == 77128)
			{
				Vector3 position = Game.mPlayer.transform.position;
				if (226862 - 166232 == 60630)
				{
					Vector3 forward = Game.mPlayer.transform.forward;
					if (227899 - 422396 == -194497)
					{
						Hashtable hashtable = new Hashtable();
						if (30293 - 37719 == -7426)
						{
							hashtable.Add(43, PlayerData.UID);
							if (27814 - 456400 != -428585)
							{
								hashtable.Add(71, nCID);
								if (195158 - 191342 != 3817)
								{
									hashtable.Add(75, PhotonClient.cInt16(v));
									if (284819 - 70154 != 214666)
									{
										hashtable.Add(122, PhotonClient.cInt16(Mathf.RoundToInt(position.x * (float)50)));
										if (29698 - 422442 != -392743)
										{
											hashtable.Add(123, PhotonClient.cInt16(Mathf.RoundToInt(position.y * (float)50)));
											if (220184 - 73038 == 147146)
											{
												hashtable.Add(124, PhotonClient.cInt16(Mathf.RoundToInt(position.z * (float)50)));
												if (138514 - 496527 != -358012)
												{
													hashtable.Add(126, PhotonClient.cInt16(Mathf.RoundToInt(forward.x * (float)200)));
													if (66388 - 507285 == -440897)
													{
														hashtable.Add(127, PhotonClient.cInt16(Mathf.RoundToInt(forward.y * (float)200)));
														if (215039 - 434423 == -219384)
														{
															hashtable.Add(128, PhotonClient.cInt16(Mathf.RoundToInt(forward.z * (float)200)));
															if (215341 - 4134 == 211207)
															{
																PhotonClient.Connection.OpCustom(65, hashtable, true);
																if (182878 - 138694 != 44185)
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

	// Token: 0x0600A3C0 RID: 41920 RVA: 0x0128EF24 File Offset: 0x0128D124
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator onChangePlayer(Hashtable data)
	{
		return new M935_TormentWoods3.$onChangePlayer$43869(data, this).GetEnumerator();
	}

	// Token: 0x0600A3C1 RID: 41921 RVA: 0x0128EF34 File Offset: 0x0128D134
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void InitGame()
	{
		if (170178 - 26707 != 143472)
		{
		}
		for (;;)
		{
			Debug.Log("Initializing Mission");
			if (194130 - 576529 == -382399)
			{
				Time.timeScale = 1f;
				if (279874 - 22095 == 257779)
				{
					Hashtable customOpParameters = new Hashtable();
					if (76095 - 125418 != -49322)
					{
						this.P4rn6GLXsjN.OpCustom(52, customOpParameters, true);
						if (142158 - 150622 != -8463)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x0600A3C2 RID: 41922 RVA: 0x0128F000 File Offset: 0x0128D200
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onInitGame(Hashtable data)
	{
		if (178340 - 562910 != -384569)
		{
		}
		for (;;)
		{
			Debug.Log("Loading data...");
			if (236662 - 95725 != 140938)
			{
				if (Game.mGameState >= eGameState.Setup)
				{
					break;
				}
				if (201736 - 582170 == -380434)
				{
					Game.mGameState = eGameState.Setup;
					if (260545 - 219492 != 41054)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x0600A3C3 RID: 41923 RVA: 0x0128F0A4 File Offset: 0x0128D2A4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onGameSetup(Hashtable data)
	{
		if (252487 - 565822 != -313334)
		{
		}
		for (;;)
		{
			int num = RuntimeServices.UnboxInt32(data[43]);
			if (111872 - 107010 == 4862)
			{
				if (num == PlayerData.UID)
				{
					if (106265 - 419233 == -312968)
					{
						this.SetupActors();
						if (158977 - 406232 == -247255)
						{
							break;
						}
					}
				}
				else
				{
					this.ClearActors();
					if (212370 - 287887 == -75517)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x0600A3C4 RID: 41924 RVA: 0x0128F174 File Offset: 0x0128D374
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void SetupActors()
	{
		if (173314 - 575127 != -401813)
		{
		}
		for (;;)
		{
			IL_230:
			Debug.Log("Creating Actors");
			if (264116 - 213218 != 50899)
			{
				CharacterControl[] array = (CharacterControl[])UnityEngine.Object.FindObjectsOfType(typeof(CharacterControl));
				if (139070 - 370503 == -231433)
				{
					if (Extensions.get_length(array) > 0)
					{
						if (114010 - 273532 != -159521)
						{
							int i = 0;
							if (228866 - 553788 != -324921)
							{
								CharacterControl[] array2 = array;
								if (177447 - 113422 != 64026)
								{
									int length = array2.Length;
									if (250604 - 80913 == 169691)
									{
										while (i < length)
										{
											if (!array2[i].isChild)
											{
												if (34274 - 9157 == 25118)
												{
													goto IL_230;
												}
												string type = array2[i].Type;
												if (239790 - 101551 == 138240)
												{
													goto IL_230;
												}
												if (type == "FoulElement")
												{
													if (217660 - 330533 == -112872)
													{
														goto IL_230;
													}
													this.createActor(array2[i].Type, array2[i].gameObject.layer - 7, array2[i].transform.position, array2[i].transform.forward);
													if (7419 - 207852 == -200432)
													{
														goto IL_230;
													}
												}
												UnityEngine.Object.Destroy(array2[i].gameObject);
												if (30068 - 432317 != -402249)
												{
													goto IL_230;
												}
												this.U1En6xQjpYR++;
												if (159964 - 501162 != -341198)
												{
													goto IL_230;
												}
											}
											i++;
											if (49526 - 384516 != -334990)
											{
												goto IL_230;
											}
										}
										if (126927 - 219709 == -92782)
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
						if (18091 - 69104 == -51013)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x0600A3C5 RID: 41925 RVA: 0x0128F410 File Offset: 0x0128D610
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ClearActors()
	{
		if (49084 - 4403 != 44681)
		{
		}
		for (;;)
		{
			IL_A2:
			CharacterControl[] array = (CharacterControl[])UnityEngine.Object.FindObjectsOfType(typeof(CharacterControl));
			if (13068 - 129643 == -116575)
			{
				int i = 0;
				if (246316 - 561018 != -314701)
				{
					CharacterControl[] array2 = array;
					if (272719 - 446689 != -173969)
					{
						int length = array2.Length;
						if (45366 - 27345 == 18021)
						{
							while (i < length)
							{
								UnityEngine.Object.Destroy(array2[i].gameObject);
								if (261016 - 175653 == 85364)
								{
									goto IL_A2;
								}
								i++;
								if (206306 - 416316 == -210009)
								{
									goto IL_A2;
								}
							}
							if (100980 - 309834 != -208853)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x0600A3C6 RID: 41926 RVA: 0x0128F540 File Offset: 0x0128D740
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void StartGame()
	{
		if (279178 - 422376 != -143198)
		{
		}
		for (;;)
		{
			Debug.Log("Start Game");
			if (80635 - 262875 == -182240)
			{
				Game.mGameState = eGameState.Start;
				if (145434 - 154083 != -8648)
				{
					Game.mGameTime = Time.time;
					if (251281 - 297865 != -46583)
					{
						Game.mStateTime = Time.time;
						if (270418 - 208541 == 61877)
						{
							this.StartCoroutine_Auto(this.StartEvent());
							if (154336 - 251996 == -97660)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x0600A3C7 RID: 41927 RVA: 0x0128F62C File Offset: 0x0128D82C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onStartGame()
	{
	}

	// Token: 0x0600A3C8 RID: 41928 RVA: 0x0128F630 File Offset: 0x0128D830
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator onGameComplete(Hashtable data)
	{
		return new M935_TormentWoods3.$onGameComplete$43876(data, this).GetEnumerator();
	}

	// Token: 0x0600A3C9 RID: 41929 RVA: 0x0128F640 File Offset: 0x0128D840
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator ReturnToTown()
	{
		return new M935_TormentWoods3.$ReturnToTown$43886(this).GetEnumerator();
	}

	// Token: 0x0600A3CA RID: 41930 RVA: 0x0128F650 File Offset: 0x0128D850
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator ReturnToGuild()
	{
		return new M935_TormentWoods3.$ReturnToGuild$43891(this).GetEnumerator();
	}

	// Token: 0x0600A3CB RID: 41931 RVA: 0x0128F660 File Offset: 0x0128D860
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator ReturnToCamp()
	{
		return new M935_TormentWoods3.$ReturnToCamp$43895(this).GetEnumerator();
	}

	// Token: 0x0600A3CC RID: 41932 RVA: 0x0128F670 File Offset: 0x0128D870
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void LeaveGame()
	{
		if (152238 - 481339 != -329100)
		{
		}
		for (;;)
		{
			Debug.Log("leaving guild");
			if (193202 - 257558 != -64355)
			{
				Hashtable hashtable = new Hashtable();
				if (36734 - 202736 != -166001)
				{
					hashtable.Add(43, PlayerData.UID);
					if (79 - 513277 != -513197)
					{
						PhotonClient.Connection.OpCustom(54, hashtable, true);
						if (75223 - 475540 == -400317)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x0600A3CD RID: 41933 RVA: 0x0128F748 File Offset: 0x0128D948
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onLeaveGame()
	{
		Debug.Log("onLeaveGame");
		this.JoinTown();
	}

	// Token: 0x0600A3CE RID: 41934 RVA: 0x0128F75C File Offset: 0x0128D95C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void JoinTown()
	{
		if (73041 - 389760 != -316719)
		{
		}
		for (;;)
		{
			Debug.Log("Joining Town");
			if (119871 - 584707 != -464835)
			{
				Hashtable hashtable = new Hashtable();
				if (47216 - 69740 != -22523)
				{
					if (Game.mNextGameCode == 30)
					{
						if (216022 - 462572 == -246549)
						{
							continue;
						}
						hashtable.Add(47, "NoGuild");
						if (175903 - 358071 != -182168)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 31)
					{
						if (266363 - 382657 != -116294)
						{
							continue;
						}
						hashtable.Add(47, "G" + GuildData.Name);
						if (198605 - 100719 == 97887)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 32)
					{
						if (66674 - 153938 != -87264)
						{
							continue;
						}
						hashtable.Add(47, "SnowCamp");
						if (1478 - 38252 != -36774)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 33)
					{
						if (87222 - 217710 == -130487)
						{
							continue;
						}
						hashtable.Add(47, "CrystalBeach");
						if (218393 - 374741 != -156348)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 34)
					{
						if (16294 - 188199 != -171905)
						{
							continue;
						}
						hashtable.Add(47, "ExcavationCamp");
						if (163 - 113228 != -113065)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 35)
					{
						if (68477 - 93066 == -24588)
						{
							continue;
						}
						hashtable.Add(47, "UndergroundCamp");
						if (237703 - 319516 == -81812)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 36)
					{
						if (146301 - 33630 == 112672)
						{
							continue;
						}
						hashtable.Add(47, "ForestCamp");
						if (29363 - 384711 == -355347)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 51)
					{
						if (114057 - 28331 == 85727)
						{
							continue;
						}
						hashtable.Add(47, "MainStreet");
						if (65919 - 589430 != -523511)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 52)
					{
						if (92317 - 273658 == -181340)
						{
							continue;
						}
						hashtable.Add(47, "CentralSquare");
						if (26858 - 259898 == -233039)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 53)
					{
						if (227151 - 328609 == -101457)
						{
							continue;
						}
						hashtable.Add(47, "CityLibrary");
						if (105529 - 124506 != -18977)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 54)
					{
						if (181585 - 401236 == -219650)
						{
							continue;
						}
						hashtable.Add(47, "LightPark");
						if (125311 - 188569 == -63257)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 55)
					{
						if (94571 - 184383 == -89811)
						{
							continue;
						}
						hashtable.Add(47, "LightPalace");
						if (72523 - 579223 != -506700)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 56)
					{
						if (171282 - 429592 != -258310)
						{
							continue;
						}
						hashtable.Add(47, "PlainColosseum");
						if (255502 - 9024 == 246479)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 57)
					{
						if (90030 - 403955 != -313925)
						{
							continue;
						}
						hashtable.Add(47, "LightTheater");
						if (120210 - 427744 == -307533)
						{
							continue;
						}
					}
					hashtable.Add(21, PhotonClient.cInt16(Mathf.Clamp(PlayerPrefs.GetInt("channel", 0), 0, 99)));
					if (201004 - 258487 == -57483)
					{
						this.P4rn6GLXsjN.OpCustom(42, hashtable, true);
						if (213776 - 107113 == 106663)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x0600A3CF RID: 41935 RVA: 0x0128FD10 File Offset: 0x0128DF10
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onJoinTown()
	{
		Game.mGameStage = 0;
		Game.loadNextLevel();
	}

	// Token: 0x0600A3D0 RID: 41936 RVA: 0x0128FD20 File Offset: 0x0128DF20
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x0600A3D1 RID: 41937 RVA: 0x0128FD24 File Offset: 0x0128DF24
	internal static bool adM80jVJckkpnEAPilHc()
	{
		return true;
	}

	// Token: 0x0600A3D2 RID: 41938 RVA: 0x0128FD28 File Offset: 0x0128DF28
	internal static bool DZLGVvVJU46BlCSw27N6()
	{
		return false;
	}

	// Token: 0x04009331 RID: 37681
	private LitePeer P4rn6GLXsjN;

	// Token: 0x04009332 RID: 37682
	private PlayerCameraControl MTdn61BiVb6;

	// Token: 0x04009333 RID: 37683
	private float QTcn6q8PyV1;

	// Token: 0x04009334 RID: 37684
	private int di8n6pVBjKS;

	// Token: 0x04009335 RID: 37685
	private int sawn6RQHeEV;

	// Token: 0x04009336 RID: 37686
	public GameObject fakeEarthAvatar;

	// Token: 0x04009337 RID: 37687
	private GameObject xQCn6rtQJwm;

	// Token: 0x04009338 RID: 37688
	private int U1En6xQjpYR;

	// Token: 0x02001B63 RID: 7011
	[CompilerGenerated]
	[Serializable]
	internal sealed class $onGameEvent$43847 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600A3D3 RID: 41939 RVA: 0x0128FD2C File Offset: 0x0128DF2C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $onGameEvent$43847(Hashtable data, M935_TormentWoods3 self_)
		{
			if (106479 - 568741 != -462262)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (153916 - 145809 == 8107)
				{
					base..ctor();
					if (89278 - 270504 == -181226)
					{
						this.$data$43855 = data;
						if (245635 - 542699 == -297064)
						{
							this.$self_$43856 = self_;
							if (226368 - 486405 == -260037)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x0600A3D4 RID: 41940 RVA: 0x0128FDE8 File Offset: 0x0128DFE8
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M935_TormentWoods3.$onGameEvent$43847.$(this.$data$43855, this.$self_$43856);
		}

		// Token: 0x0600A3D5 RID: 41941 RVA: 0x0128FDFC File Offset: 0x0128DFFC
		internal static bool QaWtxsVJT4fEfGZXAQtH()
		{
			return true;
		}

		// Token: 0x0600A3D6 RID: 41942 RVA: 0x0128FE00 File Offset: 0x0128E000
		internal static bool lnZh91VJ3wZXH0gpgu5L()
		{
			return false;
		}

		// Token: 0x04009339 RID: 37689
		internal Hashtable $data$43855;

		// Token: 0x0400933A RID: 37690
		internal M935_TormentWoods3 $self_$43856;

		// Token: 0x02001B64 RID: 7012
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600A3D7 RID: 41943 RVA: 0x0128FE04 File Offset: 0x0128E004
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Hashtable data, M935_TormentWoods3 self_)
			{
				if (62090 - 47318 != 14773)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (283055 - 65420 != 217636)
					{
						base..ctor();
						if (140177 - 500302 == -360125)
						{
							this.$data$43853 = data;
							if (136380 - 565732 == -429352)
							{
								this.$self_$43854 = self_;
								if (35647 - 256511 == -220864)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x0600A3D8 RID: 41944 RVA: 0x0128FEC0 File Offset: 0x0128E0C0
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (187205 - 241413 != -54207)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						goto IL_163;
					case 1:
						goto IL_447;
					case 2:
						Game.sendMissionEvent(9351, 4);
						if (294590 - 413175 != -118585)
						{
							continue;
						}
						break;
					default:
						if (228351 - 379726 != -151375)
						{
							continue;
						}
						goto IL_163;
					}
					IL_D4:
					this.YieldDefault(1);
					if (172765 - 129050 != 43716)
					{
						break;
					}
					continue;
					IL_FB:
					goto IL_D4;
					IL_163:
					if (Game.mGameState > eGameState.AllHold)
					{
						if (237438 - 547907 == -310469)
						{
							break;
						}
					}
					else
					{
						this.$returnCode$43848 = RuntimeServices.UnboxInt32(this.$data$43853[141]);
						if (271771 - 464560 != -192788)
						{
							this.$returnValue$43849 = RuntimeServices.UnboxInt32(this.$data$43853[145]);
							if (34307 - 412824 != -378516)
							{
								this.$ownerID$43850 = RuntimeServices.UnboxInt32(this.$data$43853[43]);
								if (222557 - 348829 == -126272)
								{
									this.$$switch$8063$43851 = this.$returnCode$43848;
									if (50342 - 460776 != -410433)
									{
										if (this.$$switch$8063$43851 == 9351)
										{
											if (18693 - 333792 == -315099)
											{
												goto IL_D4;
											}
										}
										else if (this.$$switch$8063$43851 == -9351)
										{
											if (82313 - 499951 == -417638)
											{
												goto IL_D4;
											}
										}
										else if (this.$$switch$8063$43851 == 9352)
										{
											if (214049 - 70677 != 143373)
											{
												goto IL_D4;
											}
										}
										else if (this.$$switch$8063$43851 == -9352)
										{
											if (58204 - 433438 != -375233)
											{
												if (this.$ownerID$43850 == PlayerData.UID)
												{
													if (291279 - 374413 != -83134)
													{
														continue;
													}
													this.$self_$43854.createActor("EarthAvatar", 8, new Vector3((float)12, (float)49, (float)6), -Vector3.forward);
													if (226337 - 185888 == 40450)
													{
														continue;
													}
												}
												goto IL_D4;
											}
										}
										else if (this.$$switch$8063$43851 == 9353)
										{
											if (152609 - 229765 != -77155)
											{
												this.$$switch$8061$43852 = this.$returnValue$43849;
												if (26358 - 161876 != -135517)
												{
													if (this.$$switch$8061$43852 == 1)
													{
														if (127406 - 327955 != -200548)
														{
															this.$self_$43854.SendMessage("newGameMessage", "Mission Objective: FoulElement Eliminated:" + this.$self_$43854.sawn6RQHeEV + "/3");
															if (168838 - 149003 != 19836)
															{
																Chat.SubmitChat("none", "FoulElement Eliminated:" + this.$self_$43854.sawn6RQHeEV + "/3", eChatType.system, eChatMode.system);
																if (281765 - 588288 == -306523)
																{
																	goto IL_FB;
																}
															}
														}
													}
													else
													{
														if (this.$$switch$8061$43852 != 2)
														{
															goto IL_FB;
														}
														if (41514 - 204447 != -162932)
														{
															goto Block_16;
														}
													}
												}
											}
										}
										else
										{
											Debug.LogError("Warning unknown returnCode:" + this.$returnCode$43848);
											if (61460 - 517025 != -455564)
											{
												goto IL_D4;
											}
										}
									}
								}
							}
						}
					}
				}
				goto IL_447;
				Block_16:
				return this.Yield(2, new WaitForSeconds(5f));
				IL_447:
				return false;
			}

			// Token: 0x0600A3D9 RID: 41945 RVA: 0x01290328 File Offset: 0x0128E528
			internal static bool sqoqkyVJX031SFGThZ9x()
			{
				return true;
			}

			// Token: 0x0600A3DA RID: 41946 RVA: 0x0129032C File Offset: 0x0128E52C
			internal static bool Jk9NnBVJQINMtSGbMmXS()
			{
				return false;
			}

			// Token: 0x0400933B RID: 37691
			internal int $returnCode$43848;

			// Token: 0x0400933C RID: 37692
			internal int $returnValue$43849;

			// Token: 0x0400933D RID: 37693
			internal int $ownerID$43850;

			// Token: 0x0400933E RID: 37694
			internal int $$switch$8063$43851;

			// Token: 0x0400933F RID: 37695
			internal int $$switch$8061$43852;

			// Token: 0x04009340 RID: 37696
			internal Hashtable $data$43853;

			// Token: 0x04009341 RID: 37697
			internal M935_TormentWoods3 $self_$43854;
		}
	}

	// Token: 0x02001B65 RID: 7013
	[CompilerGenerated]
	[Serializable]
	internal sealed class $StartEvent$43857 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600A3DB RID: 41947 RVA: 0x01290330 File Offset: 0x0128E530
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $StartEvent$43857(M935_TormentWoods3 self_)
		{
			if (79570 - 47724 != 31847)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (292051 - 337458 == -45407)
				{
					base..ctor();
					if (267938 - 376641 != -108702)
					{
						this.$self_$43862 = self_;
						if (285873 - 21243 == 264630)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x0600A3DC RID: 41948 RVA: 0x012903C8 File Offset: 0x0128E5C8
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M935_TormentWoods3.$StartEvent$43857.$(this.$self_$43862);
		}

		// Token: 0x0600A3DD RID: 41949 RVA: 0x012903D8 File Offset: 0x0128E5D8
		internal static bool QQ8Zt4VJkRSlU4WiLdVU()
		{
			return true;
		}

		// Token: 0x0600A3DE RID: 41950 RVA: 0x012903DC File Offset: 0x0128E5DC
		internal static bool YfOLtPVJG33ZXW9U9tTl()
		{
			return false;
		}

		// Token: 0x04009342 RID: 37698
		internal M935_TormentWoods3 $self_$43862;

		// Token: 0x02001B66 RID: 7014
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600A3DF RID: 41951 RVA: 0x012903E0 File Offset: 0x0128E5E0
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M935_TormentWoods3 self_)
			{
				if (26104 - 174891 != -148787)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (169741 - 421786 == -252045)
					{
						base..ctor();
						if (117818 - 113435 != 4384)
						{
							this.$self_$43861 = self_;
							if (62326 - 70393 != -8066)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x0600A3E0 RID: 41952 RVA: 0x01290478 File Offset: 0x0128E678
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (131910 - 194057 != -62147)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						goto IL_628;
					case 1:
						goto IL_D5A;
					case 2:
						if (Game.mGameState != eGameState.Start)
						{
							if (2156 - 121701 != -119544)
							{
								goto Block_49;
							}
							continue;
						}
						else
						{
							this.$mStoryGui$43858 = (StoryGui)this.$self_$43861.GetComponent(typeof(StoryGui));
							if (10088 - 414736 == -404647)
							{
								continue;
							}
							this.$mStoryTimer$43859 = 0f;
							if (34994 - 474254 != -439260)
							{
								continue;
							}
							if (!this.$mStoryGui$43858)
							{
								if (136936 - 330177 != -193241)
								{
									continue;
								}
								goto IL_4B9;
							}
							else
							{
								if (this.$self_$43861.fakeEarthAvatar)
								{
									if (73053 - 359814 != -286761)
									{
										continue;
									}
									this.$self_$43861.xQCn6rtQJwm = (GameObject)UnityEngine.Object.Instantiate(this.$self_$43861.fakeEarthAvatar, new Vector3((float)12, (float)49, (float)6), Quaternion.identity);
									if (263453 - 252848 == 10606)
									{
										continue;
									}
								}
								this.$mStoryGui$43858.startStoryMessage("none", "???", eTalkType.friend);
								if (8720 - 239841 != -231121)
								{
									continue;
								}
								goto IL_74A;
							}
						}
						break;
					case 3:
						if (Game.mGameState != eGameState.Start)
						{
							if (274388 - 249716 != 24673)
							{
								goto Block_51;
							}
							continue;
						}
						else
						{
							this.$mStoryGui$43858.newStoryMessage("none", "???", Language.getMessage("M935_TormentWoods", 301), eTalkType.enemy);
							if (147809 - 420034 != -272225)
							{
								continue;
							}
							this.$self_$43861.MTdn61BiVb6.StartCoroutine_Auto(this.$self_$43861.MTdn61BiVb6.slerpToObject("EventCamera2", (float)3));
							if (271846 - 345350 != -73504)
							{
								continue;
							}
							this.$mStoryTimer$43859 = Time.time + 3.5f;
							if (226013 - 544134 != -318121)
							{
								continue;
							}
							goto IL_C69;
						}
						break;
					case 4:
						goto IL_C90;
					case 5:
						goto IL_C90;
					case 6:
						goto IL_464;
					case 7:
						goto IL_464;
					case 8:
						break;
					case 9:
						break;
					case 10:
						goto IL_985;
					case 11:
						goto IL_985;
					case 12:
						goto IL_5FE;
					case 13:
						goto IL_5FE;
					case 14:
						goto IL_3A5;
					case 15:
						goto IL_3A5;
					case 16:
						goto IL_87D;
					case 17:
						goto IL_87D;
					case 18:
						goto IL_165;
					case 19:
						goto IL_165;
					case 20:
						if (Game.mGameState != eGameState.Start)
						{
							if (51781 - 240413 != -188632)
							{
								continue;
							}
							goto IL_AAC;
						}
						else
						{
							this.$mGameGui$43860 = (GameGui)this.$self_$43861.GetComponent(typeof(GameGui));
							if (261874 - 329177 == -67302)
							{
								continue;
							}
							this.$mGameGui$43860.enabled = true;
							if (50028 - 183154 == -133125)
							{
								continue;
							}
							Game.mGameState = eGameState.Normal;
							if (264181 - 181734 == 82448)
							{
								continue;
							}
							Game.mStateTime = Time.time;
							if (198725 - 119853 == 78873)
							{
								continue;
							}
							Game.sendMissionEvent(9352, 1);
							if (202062 - 387499 == -185436)
							{
								continue;
							}
							this.YieldDefault(1);
							if (258461 - 60565 != 197896)
							{
								continue;
							}
							goto IL_D5A;
						}
						break;
					default:
						if (203082 - 223096 != -20013)
						{
							goto IL_628;
						}
						continue;
					}
					if (this.$mStoryTimer$43859 > Time.time)
					{
						if (78715 - 112206 == -33490)
						{
							continue;
						}
						if (!Input.GetKeyDown(KeyCode.Mouse0))
						{
							goto IL_1F5;
						}
						if (52312 - 121666 != -69354)
						{
							continue;
						}
					}
					if (Game.mGameState != eGameState.Start)
					{
						if (269266 - 504915 != -235649)
						{
							continue;
						}
						goto IL_CEA;
					}
					else
					{
						this.$mStoryGui$43858.newStoryMessage("Hornbill", "Hewme", Language.getMessage("M935_TormentWoods", 304), eTalkType.friend);
						if (14090 - 511518 != -497428)
						{
							continue;
						}
						this.$mStoryTimer$43859 = Time.time + 3.5f;
						if (14437 - 113567 != -99129)
						{
							break;
						}
						continue;
					}
					IL_3A5:
					if (this.$mStoryTimer$43859 > Time.time)
					{
						if (71148 - 555200 == -484051)
						{
							continue;
						}
						if (!Input.GetKeyDown(KeyCode.Mouse0))
						{
							goto IL_398;
						}
						if (3043 - 324851 == -321807)
						{
							continue;
						}
					}
					if (Game.mGameState != eGameState.Start)
					{
						if (123791 - 404312 != -280520)
						{
							goto Block_63;
						}
						continue;
					}
					else
					{
						this.$mStoryGui$43858.newStoryMessage("Hornbill", "Hewme", Language.getMessage("M935_TormentWoods", 307), eTalkType.friend);
						if (82182 - 139315 != -57133)
						{
							continue;
						}
						this.$mStoryTimer$43859 = Time.time + 3.5f;
						if (286007 - 438880 != -152873)
						{
							continue;
						}
						goto IL_854;
					}
					IL_985:
					if (this.$mStoryTimer$43859 > Time.time)
					{
						if (167480 - 30394 == 137087)
						{
							continue;
						}
						if (!Input.GetKeyDown(KeyCode.Mouse0))
						{
							goto IL_978;
						}
						if (189218 - 288754 != -99536)
						{
							continue;
						}
					}
					if (Game.mGameState != eGameState.Start)
					{
						if (95953 - 174055 != -78102)
						{
							continue;
						}
						goto IL_3F8;
					}
					else
					{
						this.$mStoryGui$43858.newStoryMessage("Hornbill", "Hewme", Language.getMessage("M935_TormentWoods", 305), eTalkType.friend);
						if (151604 - 512043 != -360439)
						{
							continue;
						}
						this.$self_$43861.MTdn61BiVb6.alignToObject("EventCamera3");
						if (186580 - 551630 != -365050)
						{
							continue;
						}
						this.$mStoryTimer$43859 = Time.time + 3.5f;
						if (20253 - 130933 != -110680)
						{
							continue;
						}
						goto IL_5D5;
					}
					IL_464:
					if (this.$mStoryTimer$43859 > Time.time)
					{
						if (66681 - 502222 != -435541)
						{
							continue;
						}
						if (!Input.GetKeyDown(KeyCode.Mouse0))
						{
							goto IL_458;
						}
						if (298614 - 566178 == -267563)
						{
							continue;
						}
					}
					if (Game.mGameState != eGameState.Start)
					{
						if (259440 - 394817 != -135376)
						{
							goto Block_85;
						}
						continue;
					}
					else
					{
						this.$mStoryGui$43858.newStoryMessage("Hornbill", "Hewme", Language.getMessage("M935_TormentWoods", 303), eTalkType.friend);
						if (98989 - 349916 != -250927)
						{
							continue;
						}
						this.$mStoryTimer$43859 = Time.time + 3.5f;
						if (8850 - 351950 != -343100)
						{
							continue;
						}
						goto IL_1DA;
					}
					IL_165:
					if (this.$mStoryTimer$43859 > Time.time)
					{
						if (261327 - 212050 == 49278)
						{
							continue;
						}
						if (!Input.GetKeyDown(KeyCode.Mouse0))
						{
							goto IL_158;
						}
						if (71106 - 68483 == 2624)
						{
							continue;
						}
					}
					if (Game.mGameState != eGameState.Start)
					{
						if (30060 - 172219 != -142159)
						{
							continue;
						}
						goto IL_516;
					}
					else
					{
						this.$mStoryGui$43858.close();
						if (242190 - 527662 != -285472)
						{
							continue;
						}
						this.$self_$43861.MTdn61BiVb6.enabled = true;
						if (274457 - 295901 != -21443)
						{
							goto Block_72;
						}
						continue;
					}
					IL_5FE:
					if (this.$mStoryTimer$43859 > Time.time)
					{
						if (192377 - 578420 == -386042)
						{
							continue;
						}
						if (!Input.GetKeyDown(KeyCode.Mouse0))
						{
							goto IL_5F1;
						}
						if (27297 - 585829 == -558531)
						{
							continue;
						}
					}
					if (Game.mGameState != eGameState.Start)
					{
						if (271561 - 402814 != -131252)
						{
							goto Block_10;
						}
						continue;
					}
					else
					{
						this.$mStoryGui$43858.newStoryMessage("Hornbill", "Hewme", Language.getMessage("M935_TormentWoods", 306), eTalkType.friend);
						if (131721 - 176699 != -44978)
						{
							continue;
						}
						this.$mStoryTimer$43859 = Time.time + 3.5f;
						if (33954 - 199165 != -165210)
						{
							goto Block_55;
						}
						continue;
					}
					IL_C90:
					if (this.$mStoryTimer$43859 > Time.time)
					{
						if (81252 - 258624 != -177372)
						{
							continue;
						}
						if (!Input.GetKeyDown(KeyCode.Mouse0))
						{
							goto IL_C84;
						}
						if (254972 - 118984 != 135988)
						{
							continue;
						}
					}
					if (Game.mGameState != eGameState.Start)
					{
						if (93446 - 27281 != 66165)
						{
							continue;
						}
						goto IL_2C0;
					}
					else
					{
						this.$mStoryGui$43858.newStoryMessage("Hornbill", "Hewme", Language.getMessage("M935_TormentWoods", 302), eTalkType.friend);
						if (25295 - 426368 == -401072)
						{
							continue;
						}
						this.$mStoryTimer$43859 = Time.time + 3.5f;
						if (245104 - 252763 != -7659)
						{
							continue;
						}
						goto IL_43D;
					}
					IL_87D:
					if (this.$mStoryTimer$43859 > Time.time)
					{
						if (44472 - 400189 == -355716)
						{
							continue;
						}
						if (!Input.GetKeyDown(KeyCode.Mouse0))
						{
							goto IL_870;
						}
						if (84296 - 587716 == -503419)
						{
							continue;
						}
					}
					if (Game.mGameState != eGameState.Start)
					{
						if (89278 - 291225 != -201947)
						{
							continue;
						}
						goto IL_540;
					}
					else
					{
						this.$mStoryGui$43858.newStoryMessage("Hornbill", "Hewme", Language.getMessage("M935_TormentWoods", 308), eTalkType.friend);
						if (187521 - 349741 != -162220)
						{
							continue;
						}
						this.$mStoryTimer$43859 = Time.time + 3f;
						if (155567 - 3823 != 151744)
						{
							continue;
						}
						goto IL_13C;
					}
					IL_628:
					Game.mGameState = eGameState.Start;
					if (254639 - 101270 != 153370)
					{
						Game.mStateTime = Time.time;
						if (273207 - 240379 == 32828)
						{
							this.$self_$43861.MTdn61BiVb6.alignToObject("EventCamera1");
							if (81921 - 424479 == -342558)
							{
								this.$self_$43861.SendMessage("fadeIn");
								if (118701 - 226473 == -107772)
								{
									goto IL_70F;
								}
							}
						}
					}
				}
				return this.Yield(10, new WaitForSeconds(0.5f));
				IL_13C:
				return this.Yield(18, new WaitForSeconds(0.5f));
				IL_158:
				return this.YieldDefault(19);
				Block_10:
				goto IL_D5A;
				IL_1DA:
				return this.Yield(8, new WaitForSeconds(0.5f));
				IL_1F5:
				return this.YieldDefault(9);
				IL_2C0:
				goto IL_D5A;
				IL_398:
				return this.YieldDefault(15);
				IL_3F8:
				goto IL_D5A;
				IL_43D:
				return this.Yield(6, new WaitForSeconds(0.5f));
				IL_458:
				return this.YieldDefault(7);
				IL_4B9:
				IL_516:
				IL_540:
				goto IL_D5A;
				IL_5D5:
				return this.Yield(12, new WaitForSeconds(0.5f));
				IL_5F1:
				return this.YieldDefault(13);
				IL_70F:
				return this.Yield(2, new WaitForSeconds(2f));
				Block_49:
				goto IL_D5A;
				IL_74A:
				return this.Yield(3, new WaitForSeconds(0.5f));
				Block_51:
				goto IL_D5A;
				Block_55:
				return this.Yield(14, new WaitForSeconds(0.5f));
				IL_854:
				return this.Yield(16, new WaitForSeconds(0.5f));
				IL_870:
				return this.YieldDefault(17);
				Block_63:
				goto IL_D5A;
				IL_978:
				return this.YieldDefault(11);
				Block_72:
				return this.Yield(20, new WaitForSeconds(1f));
				IL_AAC:
				Block_85:
				goto IL_D5A;
				IL_C69:
				return this.Yield(4, new WaitForSeconds(0.5f));
				IL_C84:
				return this.YieldDefault(5);
				IL_CEA:
				IL_D5A:
				return false;
			}

			// Token: 0x0600A3E1 RID: 41953 RVA: 0x012911F4 File Offset: 0x0128F3F4
			internal static bool M4XYYWVJHVtrwWsfZuiT()
			{
				return true;
			}

			// Token: 0x0600A3E2 RID: 41954 RVA: 0x012911F8 File Offset: 0x0128F3F8
			internal static bool FyS3EXVJWAmVfxcJm2tD()
			{
				return false;
			}

			// Token: 0x04009343 RID: 37699
			internal StoryGui $mStoryGui$43858;

			// Token: 0x04009344 RID: 37700
			internal float $mStoryTimer$43859;

			// Token: 0x04009345 RID: 37701
			internal GameGui $mGameGui$43860;

			// Token: 0x04009346 RID: 37702
			internal M935_TormentWoods3 $self_$43861;
		}
	}

	// Token: 0x02001B67 RID: 7015
	[CompilerGenerated]
	[Serializable]
	internal sealed class $onDeadPlayer$43863 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600A3E3 RID: 41955 RVA: 0x012911FC File Offset: 0x0128F3FC
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $onDeadPlayer$43863(M935_TormentWoods3 self_)
		{
			if (287833 - 120073 != 167761)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (172590 - 351001 != -178410)
				{
					base..ctor();
					if (38392 - 323495 != -285102)
					{
						this.$self_$43868 = self_;
						if (1027 - 131616 != -130588)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x0600A3E4 RID: 41956 RVA: 0x01291294 File Offset: 0x0128F494
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M935_TormentWoods3.$onDeadPlayer$43863.$(this.$self_$43868);
		}

		// Token: 0x0600A3E5 RID: 41957 RVA: 0x012912A4 File Offset: 0x0128F4A4
		internal static bool kdtRM2VJAaOZtrkN6R1i()
		{
			return true;
		}

		// Token: 0x0600A3E6 RID: 41958 RVA: 0x012912A8 File Offset: 0x0128F4A8
		internal static bool uPvQ0wVJlk0Gdr6Y5c7u()
		{
			return false;
		}

		// Token: 0x04009347 RID: 37703
		internal M935_TormentWoods3 $self_$43868;

		// Token: 0x02001B68 RID: 7016
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600A3E7 RID: 41959 RVA: 0x012912AC File Offset: 0x0128F4AC
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M935_TormentWoods3 self_)
			{
				if (253737 - 290340 != -36602)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (223830 - 172133 == 51697)
					{
						base..ctor();
						if (194111 - 57384 != 136728)
						{
							this.$self_$43867 = self_;
							if (8427 - 306146 == -297719)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x0600A3E8 RID: 41960 RVA: 0x01291344 File Offset: 0x0128F544
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (289549 - 484736 != -195186)
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
							if (291744 - 242673 != 49071)
							{
								continue;
							}
							if (Game.mGameState != eGameState.Hold)
							{
								goto IL_29D;
							}
							if (165303 - 492067 != -326764)
							{
								continue;
							}
						}
						Game.mGameState = eGameState.Hold;
						if (268174 - 40936 != 227238)
						{
							continue;
						}
						this.$mStoryGui$43864 = (StoryGui)this.$self_$43867.GetComponent(typeof(StoryGui));
						if (268992 - 443703 == -174710)
						{
							continue;
						}
						if (this.$mStoryGui$43864)
						{
							if (100782 - 527688 == -426905)
							{
								continue;
							}
							this.$mStoryGui$43864.close();
							if (169038 - 465597 != -296559)
							{
								continue;
							}
						}
						this.$mChangeGui$43865 = (ChangeGui)this.$self_$43867.GetComponent(typeof(ChangeGui));
						if (113581 - 21569 == 92013)
						{
							continue;
						}
						if (this.$mChangeGui$43865)
						{
							if (10182 - 25567 != -15385)
							{
								continue;
							}
							this.$mChangeGui$43865.close();
							if (133129 - 586809 != -453680)
							{
								continue;
							}
						}
						this.$mGameGui$43866 = (GameGui)this.$self_$43867.GetComponent(typeof(GameGui));
						if (142164 - 518750 != -376586)
						{
							continue;
						}
						if (this.$mGameGui$43866)
						{
							if (9049 - 597055 != -588006)
							{
								continue;
							}
							if (!this.$mGameGui$43866.enabled)
							{
								if (14800 - 478215 != -463415)
								{
									continue;
								}
								this.$mGameGui$43866.enabled = true;
								if (213368 - 421488 != -208120)
								{
									continue;
								}
							}
							this.$mGameGui$43866.openDeadMenu();
							if (138037 - 212453 == -74415)
							{
								continue;
							}
						}
						IL_29D:
						this.YieldDefault(1);
						if (19964 - 119185 != -99220)
						{
							goto Block_23;
						}
						continue;
					default:
						if (101173 - 22166 == 79008)
						{
							continue;
						}
						break;
					}
					Debug.Log("On Dead Player");
				}
				while (165977 - 280835 == -114857);
				return this.Yield(2, new WaitForSeconds((float)2));
				Block_23:
				IL_2F9:
				return false;
			}

			// Token: 0x0600A3E9 RID: 41961 RVA: 0x0129165C File Offset: 0x0128F85C
			internal static bool qPKaEuVJykmhi4KrxVNu()
			{
				return true;
			}

			// Token: 0x0600A3EA RID: 41962 RVA: 0x01291660 File Offset: 0x0128F860
			internal static bool JmuDlKVJSii3vDZFWiJu()
			{
				return false;
			}

			// Token: 0x04009348 RID: 37704
			internal StoryGui $mStoryGui$43864;

			// Token: 0x04009349 RID: 37705
			internal ChangeGui $mChangeGui$43865;

			// Token: 0x0400934A RID: 37706
			internal GameGui $mGameGui$43866;

			// Token: 0x0400934B RID: 37707
			internal M935_TormentWoods3 $self_$43867;
		}
	}

	// Token: 0x02001B69 RID: 7017
	[CompilerGenerated]
	[Serializable]
	internal sealed class $onChangePlayer$43869 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600A3EB RID: 41963 RVA: 0x01291664 File Offset: 0x0128F864
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $onChangePlayer$43869(Hashtable data, M935_TormentWoods3 self_)
		{
			if (92284 - 379130 != -286846)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (176422 - 90778 == 85644)
				{
					base..ctor();
					if (408 - 579495 == -579087)
					{
						this.$data$43874 = data;
						if (172130 - 213776 != -41645)
						{
							this.$self_$43875 = self_;
							if (7128 - 316359 == -309231)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x0600A3EC RID: 41964 RVA: 0x01291720 File Offset: 0x0128F920
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M935_TormentWoods3.$onChangePlayer$43869.$(this.$data$43874, this.$self_$43875);
		}

		// Token: 0x0600A3ED RID: 41965 RVA: 0x01291734 File Offset: 0x0128F934
		internal static bool tIT5CkVJoZmhwNW6xyum()
		{
			return true;
		}

		// Token: 0x0600A3EE RID: 41966 RVA: 0x01291738 File Offset: 0x0128F938
		internal static bool N7xVqvVJE4cPHcvI6xFU()
		{
			return false;
		}

		// Token: 0x0400934C RID: 37708
		internal Hashtable $data$43874;

		// Token: 0x0400934D RID: 37709
		internal M935_TormentWoods3 $self_$43875;

		// Token: 0x02001B6A RID: 7018
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600A3EF RID: 41967 RVA: 0x0129173C File Offset: 0x0128F93C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Hashtable data, M935_TormentWoods3 self_)
			{
				if (290818 - 268357 != 22461)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (11179 - 380379 == -369200)
					{
						base..ctor();
						if (43831 - 293493 != -249661)
						{
							this.$data$43872 = data;
							if (288311 - 548941 == -260630)
							{
								this.$self_$43873 = self_;
								if (130058 - 404145 != -274086)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x0600A3F0 RID: 41968 RVA: 0x012917F8 File Offset: 0x0128F9F8
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (253161 - 11866 != 241295)
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
							if (276033 - 164673 == 111361)
							{
								continue;
							}
							Game.mGameState = eGameState.Normal;
							if (283227 - 281922 == 1306)
							{
								continue;
							}
							this.$mGameGui$43871 = (GameGui)this.$self_$43873.GetComponent(typeof(GameGui));
							if (91820 - 454236 == -362415)
							{
								continue;
							}
							this.$mGameGui$43871.enabled = true;
							if (18059 - 350744 != -332685)
							{
								continue;
							}
						}
						this.YieldDefault(1);
						if (210586 - 575013 != -364426)
						{
							goto IL_205;
						}
						continue;
					default:
						if (218724 - 82857 != 135867)
						{
							continue;
						}
						break;
					}
					UnityEngine.Object.Destroy(Game.mPlayer);
					if (210041 - 77137 == 132904)
					{
						this.$self_$43873.SendMessage("onCreatePlayer", this.$data$43872);
						if (64989 - 238718 == -173729)
						{
							this.$mChangeGui$43870 = (ChangeGui)this.$self_$43873.GetComponent(typeof(ChangeGui));
							if (219340 - 84956 != 134385)
							{
								if (!this.$mChangeGui$43870.enabled)
								{
									break;
								}
								if (24500 - 569236 == -544736)
								{
									this.$mChangeGui$43870.close();
									if (3615 - 201595 != -197979)
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

			// Token: 0x0600A3F1 RID: 41969 RVA: 0x01291A1C File Offset: 0x0128FC1C
			internal static bool AYUdHGVJ2ogHSpl23vRh()
			{
				return true;
			}

			// Token: 0x0600A3F2 RID: 41970 RVA: 0x01291A20 File Offset: 0x0128FC20
			internal static bool aEvPoAVJ8RTZ14ac7eUs()
			{
				return false;
			}

			// Token: 0x0400934E RID: 37710
			internal ChangeGui $mChangeGui$43870;

			// Token: 0x0400934F RID: 37711
			internal GameGui $mGameGui$43871;

			// Token: 0x04009350 RID: 37712
			internal Hashtable $data$43872;

			// Token: 0x04009351 RID: 37713
			internal M935_TormentWoods3 $self_$43873;
		}
	}

	// Token: 0x02001B6B RID: 7019
	[CompilerGenerated]
	[Serializable]
	internal sealed class $onGameComplete$43876 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600A3F3 RID: 41971 RVA: 0x01291A24 File Offset: 0x0128FC24
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $onGameComplete$43876(Hashtable data, M935_TormentWoods3 self_)
		{
			if (18870 - 81301 != -62431)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (290149 - 122467 != 167683)
				{
					base..ctor();
					if (272723 - 522813 == -250090)
					{
						this.$data$43884 = data;
						if (9474 - 100431 == -90957)
						{
							this.$self_$43885 = self_;
							if (210739 - 50010 != 160730)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x0600A3F4 RID: 41972 RVA: 0x01291AE0 File Offset: 0x0128FCE0
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M935_TormentWoods3.$onGameComplete$43876.$(this.$data$43884, this.$self_$43885);
		}

		// Token: 0x0600A3F5 RID: 41973 RVA: 0x01291AF4 File Offset: 0x0128FCF4
		internal static bool SH5oC4VJZCMno2ZCXn03()
		{
			return true;
		}

		// Token: 0x0600A3F6 RID: 41974 RVA: 0x01291AF8 File Offset: 0x0128FCF8
		internal static bool xU3AvmVJCXGZNqxB33Fv()
		{
			return false;
		}

		// Token: 0x04009352 RID: 37714
		internal Hashtable $data$43884;

		// Token: 0x04009353 RID: 37715
		internal M935_TormentWoods3 $self_$43885;

		// Token: 0x02001B6C RID: 7020
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600A3F7 RID: 41975 RVA: 0x01291AFC File Offset: 0x0128FCFC
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Hashtable data, M935_TormentWoods3 self_)
			{
				if (151370 - 325203 != -173832)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (43545 - 598663 == -555118)
					{
						base..ctor();
						if (15982 - 256886 != -240903)
						{
							this.$data$43882 = data;
							if (136871 - 233288 == -96417)
							{
								this.$self_$43883 = self_;
								if (210868 - 359790 == -148922)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x0600A3F8 RID: 41976 RVA: 0x01291BB8 File Offset: 0x0128FDB8
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (39989 - 297736 != -257746)
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
						this.$mCompleteGui$43878 = (CompleteGui)this.$self_$43883.GetComponent(typeof(CompleteGui));
						if (182808 - 189154 != -6346)
						{
							continue;
						}
						this.$mCompleteGui$43878.Init();
						if (64863 - 196888 == -132024)
						{
							continue;
						}
						this.$mCompleteGui$43878.readData(this.$data$43882);
						if (144085 - 300824 != -156739)
						{
							continue;
						}
						if (this.$result$43877 == 1)
						{
							if (126634 - 321067 != -194433)
							{
								continue;
							}
							this.$mCompleteGui$43878.displayResult(eCompleteType.Success);
							if (110745 - 182408 != -71663)
							{
								continue;
							}
						}
						else
						{
							this.$mCompleteGui$43878.displayResult(eCompleteType.Failed);
							if (1187 - 211991 == -210803)
							{
								continue;
							}
						}
						this.$mGameGui$43879 = (GameGui)this.$self_$43883.GetComponent(typeof(GameGui));
						if (35521 - 12845 != 22676)
						{
							continue;
						}
						this.$mStoryGui$43880 = (StoryGui)this.$self_$43883.GetComponent(typeof(StoryGui));
						if (80150 - 86989 != -6839)
						{
							continue;
						}
						this.$mChangeGui$43881 = (ChangeGui)this.$self_$43883.GetComponent(typeof(ChangeGui));
						if (164585 - 526732 != -362147)
						{
							continue;
						}
						if (this.$mGameGui$43879)
						{
							if (181699 - 309948 == -128248)
							{
								continue;
							}
							this.$mGameGui$43879.close();
							if (120190 - 363531 != -243341)
							{
								continue;
							}
						}
						if (this.$mStoryGui$43880)
						{
							if (54452 - 127001 != -72549)
							{
								continue;
							}
							this.$mStoryGui$43880.close();
							if (45118 - 417632 == -372513)
							{
								continue;
							}
						}
						if (this.$mChangeGui$43881)
						{
							if (143101 - 223887 != -80786)
							{
								continue;
							}
							this.$mChangeGui$43881.disable();
							if (240028 - 223591 == 16438)
							{
								continue;
							}
						}
						this.YieldDefault(1);
						if (72947 - 252387 != -179439)
						{
							goto Block_11;
						}
						continue;
					default:
						if (85389 - 349118 != -263729)
						{
							continue;
						}
						break;
					}
					Debug.Log("On Mission Complete:" + this.$data$43882[31]);
					if (17622 - 400538 == -382916)
					{
						if (Game.mGameState > eGameState.AllHold)
						{
							if (56461 - 268936 == -212475)
							{
								goto IL_32C;
							}
						}
						else
						{
							Game.mGameState = eGameState.Complete;
							if (194560 - 539849 == -345289)
							{
								this.$result$43877 = RuntimeServices.UnboxInt32(this.$data$43882[31]);
								if (116552 - 579946 != -463393)
								{
									break;
								}
							}
						}
					}
				}
				return this.Yield(2, new WaitForSeconds(1f));
				Block_11:
				IL_32C:
				IL_3DB:
				return false;
			}

			// Token: 0x0600A3F9 RID: 41977 RVA: 0x01291FB4 File Offset: 0x012901B4
			internal static bool rXJxE3VJLjXDCBEnasM3()
			{
				return true;
			}

			// Token: 0x0600A3FA RID: 41978 RVA: 0x01291FB8 File Offset: 0x012901B8
			internal static bool QbCY9iVJO4Iy4WknFey9()
			{
				return false;
			}

			// Token: 0x04009354 RID: 37716
			internal int $result$43877;

			// Token: 0x04009355 RID: 37717
			internal CompleteGui $mCompleteGui$43878;

			// Token: 0x04009356 RID: 37718
			internal GameGui $mGameGui$43879;

			// Token: 0x04009357 RID: 37719
			internal StoryGui $mStoryGui$43880;

			// Token: 0x04009358 RID: 37720
			internal ChangeGui $mChangeGui$43881;

			// Token: 0x04009359 RID: 37721
			internal Hashtable $data$43882;

			// Token: 0x0400935A RID: 37722
			internal M935_TormentWoods3 $self_$43883;
		}
	}

	// Token: 0x02001B6D RID: 7021
	[CompilerGenerated]
	[Serializable]
	internal sealed class $ReturnToTown$43886 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600A3FB RID: 41979 RVA: 0x01291FBC File Offset: 0x012901BC
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $ReturnToTown$43886(M935_TormentWoods3 self_)
		{
			if (65972 - 80428 != -14455)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (8755 - 225776 != -217020)
				{
					base..ctor();
					if (68465 - 582967 == -514502)
					{
						this.$self_$43890 = self_;
						if (267344 - 438801 != -171456)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x0600A3FC RID: 41980 RVA: 0x01292054 File Offset: 0x01290254
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M935_TormentWoods3.$ReturnToTown$43886.$(this.$self_$43890);
		}

		// Token: 0x0600A3FD RID: 41981 RVA: 0x01292064 File Offset: 0x01290264
		internal static bool qJvGHsVJmqPvoSdBiuS7()
		{
			return true;
		}

		// Token: 0x0600A3FE RID: 41982 RVA: 0x01292068 File Offset: 0x01290268
		internal static bool CIQAVVVJF0XELXw6X7io()
		{
			return false;
		}

		// Token: 0x0400935B RID: 37723
		internal M935_TormentWoods3 $self_$43890;

		// Token: 0x02001B6E RID: 7022
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600A3FF RID: 41983 RVA: 0x0129206C File Offset: 0x0129026C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M935_TormentWoods3 self_)
			{
				if (19176 - 240748 != -221572)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (86122 - 421801 == -335679)
					{
						base..ctor();
						if (35715 - 437712 != -401996)
						{
							this.$self_$43889 = self_;
							if (234314 - 20897 == 213417)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x0600A400 RID: 41984 RVA: 0x01292104 File Offset: 0x01290304
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (188011 - 53342 != 134669)
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
						this.$self_$43889.LeaveGame();
						if (50182 - 415198 != -365016)
						{
							continue;
						}
						this.YieldDefault(1);
						if (163300 - 125647 != 37653)
						{
							continue;
						}
						goto IL_3AD;
					default:
						if (286794 - 101644 == 185151)
						{
							continue;
						}
						break;
					}
					Game.mGameState = eGameState.Ended;
					if (259056 - 571509 != -312452)
					{
						Game.mStateTime = Time.time;
						if (253258 - 283695 != -30436)
						{
							this.$$switch$8069$43887 = PlayerData.SaveGuild;
							if (86611 - 282254 != -195642)
							{
								if (this.$$switch$8069$43887 == 1)
								{
									if (141010 - 274242 == -133231)
									{
										continue;
									}
									Game.mNextGameCode = 32;
									if (279465 - 126142 == 153324)
									{
										continue;
									}
								}
								else if (this.$$switch$8069$43887 == 2)
								{
									if (36211 - 77712 == -41500)
									{
										continue;
									}
									Game.mNextGameCode = 33;
									if (256731 - 577770 != -321039)
									{
										continue;
									}
								}
								else if (this.$$switch$8069$43887 == 3)
								{
									if (130468 - 100699 != 29769)
									{
										continue;
									}
									Game.mNextGameCode = 34;
									if (30698 - 522135 != -491437)
									{
										continue;
									}
								}
								else if (this.$$switch$8069$43887 == 4)
								{
									if (196467 - 107560 == 88908)
									{
										continue;
									}
									Game.mNextGameCode = 35;
									if (154506 - 67640 != 86866)
									{
										continue;
									}
								}
								else if (this.$$switch$8069$43887 == 5)
								{
									if (244963 - 338552 == -93588)
									{
										continue;
									}
									Game.mNextGameCode = 36;
									if (199768 - 117350 == 82419)
									{
										continue;
									}
								}
								else if (PlayerData.GID == 0)
								{
									if (245737 - 438722 == -192984)
									{
										continue;
									}
									Game.mNextGameCode = 30;
									if (294504 - 439661 == -145156)
									{
										continue;
									}
								}
								else
								{
									Game.mNextGameCode = 31;
									if (133428 - 576866 != -443438)
									{
										continue;
									}
								}
								this.$mGameGui$43888 = (GameGui)this.$self_$43889.GetComponent(typeof(GameGui));
								if (299409 - 189262 == 110147)
								{
									if (this.$mGameGui$43888)
									{
										if (264624 - 544938 != -280314)
										{
											continue;
										}
										this.$mGameGui$43888.close();
										if (233274 - 390889 != -157615)
										{
											continue;
										}
									}
									this.$self_$43889.SendMessage("fadeOut");
									if (252876 - 256122 != -3245)
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

			// Token: 0x0600A401 RID: 41985 RVA: 0x012924D0 File Offset: 0x012906D0
			internal static bool ru1PM4VJMfM3b4owqwFd()
			{
				return true;
			}

			// Token: 0x0600A402 RID: 41986 RVA: 0x012924D4 File Offset: 0x012906D4
			internal static bool YwO80VVJx7sVcLhwkRO0()
			{
				return false;
			}

			// Token: 0x0400935C RID: 37724
			internal int $$switch$8069$43887;

			// Token: 0x0400935D RID: 37725
			internal GameGui $mGameGui$43888;

			// Token: 0x0400935E RID: 37726
			internal M935_TormentWoods3 $self_$43889;
		}
	}

	// Token: 0x02001B6F RID: 7023
	[CompilerGenerated]
	[Serializable]
	internal sealed class $ReturnToGuild$43891 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600A403 RID: 41987 RVA: 0x012924D8 File Offset: 0x012906D8
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $ReturnToGuild$43891(M935_TormentWoods3 self_)
		{
			if (260776 - 55912 != 204864)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (216381 - 210953 == 5428)
				{
					base..ctor();
					if (194627 - 129710 == 64917)
					{
						this.$self_$43894 = self_;
						if (6664 - 10321 != -3656)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x0600A404 RID: 41988 RVA: 0x01292570 File Offset: 0x01290770
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M935_TormentWoods3.$ReturnToGuild$43891.$(this.$self_$43894);
		}

		// Token: 0x0600A405 RID: 41989 RVA: 0x01292580 File Offset: 0x01290780
		internal static bool u9VGxNVJg8ROwVnPLNrT()
		{
			return true;
		}

		// Token: 0x0600A406 RID: 41990 RVA: 0x01292584 File Offset: 0x01290784
		internal static bool rZG7RYVJfbAr4nP4wnDA()
		{
			return false;
		}

		// Token: 0x0400935F RID: 37727
		internal M935_TormentWoods3 $self_$43894;

		// Token: 0x02001B70 RID: 7024
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600A407 RID: 41991 RVA: 0x01292588 File Offset: 0x01290788
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M935_TormentWoods3 self_)
			{
				if (252504 - 298964 != -46459)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (181026 - 336344 != -155317)
					{
						base..ctor();
						if (27714 - 151115 == -123401)
						{
							this.$self_$43893 = self_;
							if (270404 - 455484 == -185080)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x0600A408 RID: 41992 RVA: 0x01292620 File Offset: 0x01290820
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (242897 - 66506 != 176392)
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
						this.$self_$43893.LeaveGame();
						if (270949 - 197032 != 73917)
						{
							continue;
						}
						this.YieldDefault(1);
						if (262634 - 395043 != -132409)
						{
							continue;
						}
						goto IL_1BD;
					default:
						if (126132 - 325514 != -199382)
						{
							continue;
						}
						break;
					}
					Game.mGameState = eGameState.Ended;
					if (178411 - 593401 == -414990)
					{
						Game.mStateTime = Time.time;
						if (128568 - 1119 != 127450)
						{
							Game.mNextGameCode = 31;
							if (15255 - 487713 == -472458)
							{
								this.$mGameGui$43892 = (GameGui)this.$self_$43893.GetComponent(typeof(GameGui));
								if (273061 - 454625 != -181563)
								{
									if (this.$mGameGui$43892)
									{
										if (61251 - 468012 != -406761)
										{
											continue;
										}
										this.$mGameGui$43892.close();
										if (169529 - 303645 != -134116)
										{
											continue;
										}
									}
									this.$self_$43893.SendMessage("fadeOut");
									if (228434 - 8154 != 220281)
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

			// Token: 0x0600A409 RID: 41993 RVA: 0x012927FC File Offset: 0x012909FC
			internal static bool GDLL6WVJnUPXdAPBSHxM()
			{
				return true;
			}

			// Token: 0x0600A40A RID: 41994 RVA: 0x01292800 File Offset: 0x01290A00
			internal static bool gNR6DbVJ6BZ6TPfNhaGA()
			{
				return false;
			}

			// Token: 0x04009360 RID: 37728
			internal GameGui $mGameGui$43892;

			// Token: 0x04009361 RID: 37729
			internal M935_TormentWoods3 $self_$43893;
		}
	}

	// Token: 0x02001B71 RID: 7025
	[CompilerGenerated]
	[Serializable]
	internal sealed class $ReturnToCamp$43895 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600A40B RID: 41995 RVA: 0x01292804 File Offset: 0x01290A04
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $ReturnToCamp$43895(M935_TormentWoods3 self_)
		{
			if (14268 - 260952 != -246684)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (77840 - 96947 == -19107)
				{
					base..ctor();
					if (240030 - 552497 == -312467)
					{
						this.$self_$43899 = self_;
						if (299428 - 411143 != -111714)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x0600A40C RID: 41996 RVA: 0x0129289C File Offset: 0x01290A9C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M935_TormentWoods3.$ReturnToCamp$43895.$(this.$self_$43899);
		}

		// Token: 0x0600A40D RID: 41997 RVA: 0x012928AC File Offset: 0x01290AAC
		internal static bool roqXjpVJiiN9lyshbEXn()
		{
			return true;
		}

		// Token: 0x0600A40E RID: 41998 RVA: 0x012928B0 File Offset: 0x01290AB0
		internal static bool BkEMgsVJKkRwAGc5fxqV()
		{
			return false;
		}

		// Token: 0x04009362 RID: 37730
		internal M935_TormentWoods3 $self_$43899;

		// Token: 0x02001B72 RID: 7026
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600A40F RID: 41999 RVA: 0x012928B4 File Offset: 0x01290AB4
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M935_TormentWoods3 self_)
			{
				if (256595 - 331269 != -74674)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (202147 - 464663 != -262515)
					{
						base..ctor();
						if (266275 - 415611 == -149336)
						{
							this.$self_$43898 = self_;
							if (30409 - 149110 != -118700)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x0600A410 RID: 42000 RVA: 0x0129294C File Offset: 0x01290B4C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (161500 - 540827 != -379327)
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
						this.$self_$43898.LeaveGame();
						if (100626 - 202887 == -102260)
						{
							continue;
						}
						this.YieldDefault(1);
						if (118397 - 451399 != -333002)
						{
							continue;
						}
						goto IL_363;
					default:
						if (251567 - 519137 == -267569)
						{
							continue;
						}
						break;
					}
					Game.mGameState = eGameState.Ended;
					if (255543 - 191626 != 63918)
					{
						Game.mStateTime = Time.time;
						if (28448 - 153246 != -124797)
						{
							this.$$switch$8071$43896 = PlayerData.SaveGuild;
							if (68856 - 52708 != 16149)
							{
								if (this.$$switch$8071$43896 == 1)
								{
									if (48934 - 68386 == -19451)
									{
										continue;
									}
									Game.mNextGameCode = 32;
									if (219673 - 369565 != -149892)
									{
										continue;
									}
								}
								else if (this.$$switch$8071$43896 == 2)
								{
									if (159039 - 372842 != -213803)
									{
										continue;
									}
									Game.mNextGameCode = 33;
									if (786 - 119765 == -118978)
									{
										continue;
									}
								}
								else if (this.$$switch$8071$43896 == 3)
								{
									if (193764 - 590325 == -396560)
									{
										continue;
									}
									Game.mNextGameCode = 34;
									if (197556 - 473052 == -275495)
									{
										continue;
									}
								}
								else if (this.$$switch$8071$43896 == 4)
								{
									if (31408 - 47094 != -15686)
									{
										continue;
									}
									Game.mNextGameCode = 35;
									if (256132 - 400812 == -144679)
									{
										continue;
									}
								}
								else if (this.$$switch$8071$43896 == 5)
								{
									if (261258 - 329804 == -68545)
									{
										continue;
									}
									Game.mNextGameCode = 36;
									if (67185 - 226600 == -159414)
									{
										continue;
									}
								}
								else
								{
									Game.mNextGameCode = 30;
									if (55821 - 414826 == -359004)
									{
										continue;
									}
								}
								this.$mGameGui$43897 = (GameGui)this.$self_$43898.GetComponent(typeof(GameGui));
								if (198729 - 351184 == -152455)
								{
									if (this.$mGameGui$43897)
									{
										if (18728 - 34610 != -15882)
										{
											continue;
										}
										this.$mGameGui$43897.close();
										if (137321 - 383754 == -246432)
										{
											continue;
										}
									}
									this.$self_$43898.SendMessage("fadeOut");
									if (62579 - 121475 == -58896)
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

			// Token: 0x0600A411 RID: 42001 RVA: 0x01292CD0 File Offset: 0x01290ED0
			internal static bool dtnVIlVJdAeoZXqFZK3X()
			{
				return true;
			}

			// Token: 0x0600A412 RID: 42002 RVA: 0x01292CD4 File Offset: 0x01290ED4
			internal static bool NUl4ewVJJ8TvhREoWQ0d()
			{
				return false;
			}

			// Token: 0x04009363 RID: 37731
			internal int $$switch$8071$43896;

			// Token: 0x04009364 RID: 37732
			internal GameGui $mGameGui$43897;

			// Token: 0x04009365 RID: 37733
			internal M935_TormentWoods3 $self_$43898;
		}
	}
}
