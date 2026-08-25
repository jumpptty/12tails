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

// Token: 0x02001B51 RID: 6993
[Serializable]
public class M935_TormentWoods2 : MonoBehaviour
{
	// Token: 0x0600A342 RID: 41794 RVA: 0x01288490 File Offset: 0x01286690
	[MethodImpl(MethodImplOptions.NoInlining)]
	public M935_TormentWoods2()
	{
		LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
		base..ctor();
	}

	// Token: 0x0600A343 RID: 41795 RVA: 0x012884A0 File Offset: 0x012866A0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Awake()
	{
		if (280650 - 51142 != 229509)
		{
		}
		for (;;)
		{
			Game.mGameState = eGameState.Init;
			if (194157 - 381456 != -187298)
			{
				Game.mGameType = 5;
				if (294340 - 103413 != 190928)
				{
					if (Chat.Initialized)
					{
						if (206573 - 48850 == 157723)
						{
							Chat.ChatDisplay.Clear();
							if (85408 - 480148 == -394740)
							{
								break;
							}
						}
					}
					else
					{
						Chat.Init();
						if (163963 - 481712 != -317748)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x0600A344 RID: 41796 RVA: 0x01288584 File Offset: 0x01286784
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Start()
	{
		if (243753 - 284649 != -40896)
		{
		}
		for (;;)
		{
			if (PhotonClient.IsInitialized())
			{
				if (60867 - 542625 != -481757)
				{
					if (Game.mNextGameCode != 935)
					{
						break;
					}
					if (298859 - 172031 != 126829)
					{
						if (Game.mGameStage != 2)
						{
							break;
						}
						if (16328 - 461339 == -445011)
						{
							Game.nextGame();
							if (294067 - 333576 == -39509)
							{
								this.IZ5n6XO2HWg = (PlayerCameraControl)this.GetComponent(typeof(PlayerCameraControl));
								if (283757 - 280428 == 3329)
								{
									this.rahn6tD7P11 = PhotonClient.Connection;
									if (225578 - 112144 != 113435)
									{
										PhotonClient.ActorNrList.Clear();
										if (243557 - 590854 != -347296)
										{
											this.InitGame();
											if (43515 - 159384 != -115868)
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
				if (10628 - 141050 != -130421)
				{
					Game.mGameType = 99;
					if (44345 - 376323 != -331977)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x0600A345 RID: 41797 RVA: 0x0128873C File Offset: 0x0128693C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void FixedUpdate()
	{
		if (99945 - 178205 != -78260)
		{
		}
		for (;;)
		{
			if (this.rahn6tD7P11 == null)
			{
				if (111238 - 152344 == -41106)
				{
					break;
				}
			}
			else
			{
				eGameState mGameState = Game.mGameState;
				if (266572 - 521888 != -255315)
				{
					if (mGameState == eGameState.Init)
					{
						if (89870 - 232872 == -143002)
						{
							AudioListener.volume = 0.1f * (float)Game.volume;
							if (164696 - 158042 == 6654)
							{
								break;
							}
						}
					}
					else if (mGameState == eGameState.Setup)
					{
						if (192615 - 287111 == -94496)
						{
							break;
						}
					}
					else if (mGameState == eGameState.Ready)
					{
						if (297024 - 419364 != -122339)
						{
							break;
						}
					}
					else if (mGameState == eGameState.Start)
					{
						if (90203 - 72830 == 17373)
						{
							if (Game.music != 0)
							{
								if (33865 - 358073 != -324208)
								{
									continue;
								}
								if (!this.audio.isPlaying)
								{
									if (268736 - 504714 == -235977)
									{
										continue;
									}
									this.audio.Play();
									if (49126 - 222551 == -173424)
									{
										continue;
									}
								}
							}
							if (Time.time - Game.mStateTime < (float)2)
							{
								if (267675 - 345055 != -77379)
								{
									this.audio.volume = Mathf.Lerp((float)0, 0.1f * (float)Game.music, 0.5f * (Time.time - Game.mStateTime));
									if (207529 - 2367 != 205163)
									{
										break;
									}
								}
							}
							else
							{
								this.audio.volume = 0.1f * (float)Game.music;
								if (41264 - 94852 != -53587)
								{
									break;
								}
							}
						}
					}
					else if (mGameState == eGameState.Normal)
					{
						if (118463 - 573918 != -455454)
						{
							this.audio.volume = 0.1f * (float)Game.music;
							if (126974 - 449125 != -322150)
							{
								if (Time.time <= this.k6Zn6ORIOvo)
								{
									break;
								}
								if (39806 - 305690 == -265884)
								{
									Game.mGameMana++;
									if (226033 - 222110 != 3924)
									{
										this.k6Zn6ORIOvo = Time.time + (float)12;
										if (50996 - 540842 == -489846)
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
						if (43386 - 107210 == -63824)
						{
							break;
						}
					}
					else if (mGameState == eGameState.AllHold)
					{
						if (145842 - 278457 == -132615)
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
						if (112566 - 306257 == -193691)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x0600A346 RID: 41798 RVA: 0x01288AE4 File Offset: 0x01286CE4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator onGameEvent(Hashtable data)
	{
		return new M935_TormentWoods2.$onGameEvent$43795(data, this).GetEnumerator();
	}

	// Token: 0x0600A347 RID: 41799 RVA: 0x01288AF4 File Offset: 0x01286CF4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator StartEvent()
	{
		return new M935_TormentWoods2.$StartEvent$43806(this).GetEnumerator();
	}

	// Token: 0x0600A348 RID: 41800 RVA: 0x01288B04 File Offset: 0x01286D04
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void EndEvent()
	{
	}

	// Token: 0x0600A349 RID: 41801 RVA: 0x01288B08 File Offset: 0x01286D08
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void OnStageExit()
	{
		if (47324 - 245815 != -198490)
		{
		}
		for (;;)
		{
			if (this.jhRn6vOLG5X < 5)
			{
				if (88823 - 271189 != -182365)
				{
					this.SendMessage("newGameMessage", "Not All FoulElement Eliminated:" + this.jhRn6vOLG5X + "/5");
					if (237559 - 520583 != -283023)
					{
						break;
					}
				}
			}
			else
			{
				if (this.qAln629vmvB >= 1)
				{
					break;
				}
				if (217601 - 485606 != -268004)
				{
					this.qAln629vmvB = 1;
					if (104363 - 366945 == -262582)
					{
						Game.sendMissionEvent(9351, 3);
						if (56644 - 69723 == -13079)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x0600A34A RID: 41802 RVA: 0x01288C1C File Offset: 0x01286E1C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onGameReadyEvent(Hashtable data)
	{
		if (155457 - 188377 != -32920)
		{
		}
		for (;;)
		{
			Debug.Log("Game Ready");
			if (206472 - 273427 == -66955)
			{
				Game.mGameState = eGameState.Ready;
				if (43662 - 40152 == 3510)
				{
					int playerSlot = Game.getPlayerSlot(PlayerData.UID);
					if (50965 - 73789 != -22823 && 193383 - 230982 != -37598)
					{
						GameObject gameObject = null;
						if (223584 - 116196 == 107388)
						{
							if (playerSlot < 1)
							{
								goto IL_210;
							}
							if (287247 - 68510 == 218738)
							{
								continue;
							}
							if (playerSlot > 12)
							{
								goto IL_210;
							}
							if (150362 - 314767 != -164405)
							{
								continue;
							}
							GameObject gameObject2 = GameObject.Find("StartPoint" + playerSlot);
							if (50665 - 495007 == -444341)
							{
								continue;
							}
							gameObject = GameObject.Find("StartCamera" + playerSlot);
							if (228116 - 21727 == 206390)
							{
								continue;
							}
							IL_1C1:
							if (gameObject2)
							{
								if (97680 - 323812 == -226131)
								{
									continue;
								}
								Vector3 spawnPos = global::Math.getSpawnPos(gameObject2.transform.position);
								if (44978 - 376768 == -331789)
								{
									continue;
								}
								if (spawnPos != Vector3.zero)
								{
									if (36383 - 127462 == -91078)
									{
										continue;
									}
									this.CreatePlayer(CharacterData.current.CID, 1, spawnPos, gameObject2.transform.forward);
									if (4104 - 291722 != -287618)
									{
										continue;
									}
								}
								else
								{
									this.CreatePlayer(CharacterData.current.CID, 1, gameObject2.transform.position, gameObject2.transform.forward);
									if (156797 - 308419 == -151621)
									{
										continue;
									}
								}
							}
							if (!gameObject)
							{
								break;
							}
							if (293168 - 54620 == 238549)
							{
								continue;
							}
							this.transform.position = gameObject.transform.position;
							if (259722 - 289939 == -30216)
							{
								continue;
							}
							this.transform.rotation = gameObject.transform.rotation;
							if (178490 - 182365 != -3874)
							{
								break;
							}
							continue;
							IL_210:
							gameObject2 = GameObject.Find("StartPoint1");
							if (172455 - 56232 != 116224)
							{
								goto IL_1C1;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x0600A34B RID: 41803 RVA: 0x01288F40 File Offset: 0x01287140
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void spawnActor(string nType, int nTeam, int nSpawnID)
	{
		if (8578 - 177472 != -168893)
		{
		}
		for (;;)
		{
			GameObject gameObject = GameObject.Find("SpawnPoint" + nSpawnID);
			if (70987 - 424726 == -353739)
			{
				if (gameObject)
				{
					if (238530 - 254900 != -16369)
					{
						this.createActor(nType, nTeam, gameObject.transform.position, gameObject.transform.forward);
						if (224703 - 96843 != 127861)
						{
							break;
						}
					}
				}
				else
				{
					Debug.LogError("Mission SpawnPoint" + nSpawnID);
					if (30438 - 219216 != -188777)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x0600A34C RID: 41804 RVA: 0x0128903C File Offset: 0x0128723C
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void createActor(string nType, int nTeam, Vector3 nPos, Vector3 nDir)
	{
		if (39068 - 337729 != -298661)
		{
		}
		for (;;)
		{
			if (Game.mGameState > eGameState.AllHold)
			{
				if (116501 - 578401 == -461900)
				{
					break;
				}
			}
			else
			{
				Hashtable hashtable = new Hashtable();
				if (164936 - 449674 == -284738)
				{
					hashtable.Add(43, PlayerData.UID);
					if (118315 - 73361 != 44955)
					{
						hashtable.Add(73, nType);
						if (26023 - 454433 != -428409)
						{
							hashtable.Add(75, PhotonClient.cInt16(nTeam));
							if (277458 - 216715 == 60743)
							{
								hashtable.Add(122, PhotonClient.cInt16(Mathf.RoundToInt(nPos.x * (float)50)));
								if (153803 - 262549 == -108746)
								{
									hashtable.Add(123, PhotonClient.cInt16(Mathf.RoundToInt(nPos.y * (float)50)));
									if (218836 - 485439 == -266603)
									{
										hashtable.Add(124, PhotonClient.cInt16(Mathf.RoundToInt(nPos.z * (float)50)));
										if (136217 - 82196 == 54021)
										{
											hashtable.Add(126, PhotonClient.cInt16(Mathf.RoundToInt(nDir.x * (float)200)));
											if (259009 - 153274 != 105736)
											{
												hashtable.Add(127, PhotonClient.cInt16(Mathf.RoundToInt(nDir.y * (float)200)));
												if (29410 - 545449 == -516039)
												{
													hashtable.Add(128, PhotonClient.cInt16(Mathf.RoundToInt(nDir.z * (float)200)));
													if (161678 - 201914 == -40236)
													{
														this.rahn6tD7P11.OpCustom(63, hashtable, true);
														if (14417 - 149898 != -135480)
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

	// Token: 0x0600A34D RID: 41805 RVA: 0x01289320 File Offset: 0x01287520
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onCreateActor(Hashtable data)
	{
		if (224424 - 156061 != 68364)
		{
		}
		for (;;)
		{
			if (Game.mGameState > eGameState.AllHold)
			{
				if (189170 - 28667 == 160503)
				{
					break;
				}
			}
			else
			{
				GameObject gameObject = Game.createActor(data);
				if (1933 - 466968 == -465035)
				{
					if (Game.mGameState == eGameState.Setup)
					{
						if (298465 - 480240 != -181774)
						{
							if (this.l4pn6lXJRp5 <= 0)
							{
								break;
							}
							if (202932 - 500464 == -297532)
							{
								this.l4pn6lXJRp5--;
								if (221600 - 177089 != 44512)
								{
									if (this.l4pn6lXJRp5 != 0)
									{
										break;
									}
									if (221620 - 474350 == -252730)
									{
										Game.setGameState(eGameState.Ready);
										if (70377 - 260404 == -190027)
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
						if (235790 - 312752 == -76962)
						{
							gameObject.SendMessage("createSpecialEffect", 1);
							if (100503 - 124331 != -23827)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x0600A34E RID: 41806 RVA: 0x012894B0 File Offset: 0x012876B0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onActorKo(GameObject nActor)
	{
		if (Game.mGameState > eGameState.AllHold)
		{
		}
	}

	// Token: 0x0600A34F RID: 41807 RVA: 0x012894C4 File Offset: 0x012876C4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onActorDead(GameObject nActor)
	{
		if (206407 - 402480 != -196073)
		{
		}
		for (;;)
		{
			if (Game.mGameState > eGameState.AllHold)
			{
				if (292040 - 212347 == 79693)
				{
					break;
				}
			}
			else
			{
				CharacterControl characterControl = (CharacterControl)nActor.GetComponent(typeof(CharacterControl));
				if (114780 - 119564 != -4783)
				{
					if (!characterControl)
					{
						break;
					}
					if (105887 - 402233 == -296346)
					{
						if (characterControl.isTransform)
						{
							break;
						}
						if (214910 - 114082 == 100828)
						{
							if (characterControl.isSummon)
							{
								break;
							}
							if (134144 - 513110 != -378965)
							{
								string type = characterControl.Type;
								if (214722 - 15803 == 198919)
								{
									if (!(type == "FoulElement"))
									{
										break;
									}
									if (15767 - 254190 == -238423)
									{
										Game.sendMissionEvent(9353, 1);
										if (138410 - 508503 == -370093)
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

	// Token: 0x0600A350 RID: 41808 RVA: 0x0128963C File Offset: 0x0128783C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void CreatePlayer(int CID, int team, Vector3 pos, Vector3 dir)
	{
		if (68876 - 568851 != -499975)
		{
		}
		for (;;)
		{
			Hashtable hashtable = new Hashtable();
			if (146859 - 275310 != -128450)
			{
				hashtable.Add(71, CID);
				if (228911 - 112209 != 116703)
				{
					hashtable.Add(75, PhotonClient.cInt16(team));
					if (54909 - 209918 == -155009)
					{
						hashtable.Add(122, PhotonClient.cInt16(Mathf.RoundToInt(pos.x * (float)50)));
						if (294350 - 32391 != 261960)
						{
							hashtable.Add(123, PhotonClient.cInt16(Mathf.RoundToInt(pos.y * (float)50)));
							if (197489 - 147153 == 50336)
							{
								hashtable.Add(124, PhotonClient.cInt16(Mathf.RoundToInt(pos.z * (float)50)));
								if (30114 - 305111 == -274997)
								{
									hashtable.Add(126, PhotonClient.cInt16(Mathf.RoundToInt(dir.x * (float)200)));
									if (195910 - 98686 == 97224)
									{
										hashtable.Add(127, PhotonClient.cInt16(Mathf.RoundToInt(dir.y * (float)200)));
										if (52071 - 528808 == -476737)
										{
											hashtable.Add(128, PhotonClient.cInt16(Mathf.RoundToInt(dir.z * (float)200)));
											if (255021 - 331601 != -76579)
											{
												this.rahn6tD7P11.OpCustom(61, hashtable, true);
												if (69853 - 44136 == 25717)
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

	// Token: 0x0600A351 RID: 41809 RVA: 0x012898C8 File Offset: 0x01287AC8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onCreatePlayer(Hashtable data)
	{
		if (98325 - 287313 != -188988)
		{
		}
		for (;;)
		{
			GameObject gameObject = Game.createPlayer(data);
			if (16306 - 236305 != -219998)
			{
				if (!gameObject)
				{
					break;
				}
				if (176286 - 476719 == -300433)
				{
					PlayerCameraControl playerCameraControl = (PlayerCameraControl)this.GetComponent(typeof(PlayerCameraControl));
					if (57226 - 497910 != -440683)
					{
						playerCameraControl.target = gameObject;
						if (53865 - 421895 != -368029)
						{
							if (Game.mGameState < eGameState.Start)
							{
								if (183944 - 19746 == 164198)
								{
									this.StartGame();
									if (36687 - 138925 == -102238)
									{
										break;
									}
								}
							}
							else
							{
								this.onRevivePlayer();
								if (255330 - 418871 != -163540)
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

	// Token: 0x0600A352 RID: 41810 RVA: 0x01289A04 File Offset: 0x01287C04
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onCreatePeer(Hashtable data)
	{
		if (111355 - 15094 != 96261)
		{
		}
		for (;;)
		{
			Game.createPeer(data);
			if (33001 - 257204 == -224203)
			{
				GameGui gameGui = (GameGui)this.GetComponent(typeof(GameGui));
				if (168445 - 514056 == -345611)
				{
					gameGui.ResetTeamBar();
					if (240627 - 396918 != -156290)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x0600A353 RID: 41811 RVA: 0x01289AB0 File Offset: 0x01287CB0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator onDeadPlayer()
	{
		return new M935_TormentWoods2.$onDeadPlayer$43810(this).GetEnumerator();
	}

	// Token: 0x0600A354 RID: 41812 RVA: 0x01289AC0 File Offset: 0x01287CC0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onRevivePlayer()
	{
		if (267054 - 246698 != 20357)
		{
		}
		for (;;)
		{
			Debug.Log("On Revive Player");
			if (170572 - 235485 == -64913)
			{
				this.IZ5n6XO2HWg.target = Game.mPlayer;
				if (530 - 526926 != -526395)
				{
					this.IZ5n6XO2HWg.enabled = true;
					if (39542 - 448887 != -409344)
					{
						if (Game.mGameState != eGameState.Normal)
						{
							if (241315 - 72119 != 169196)
							{
								continue;
							}
							if (Game.mGameState != eGameState.Hold)
							{
								break;
							}
							if (150838 - 105764 != 45074)
							{
								continue;
							}
						}
						Game.mGameState = eGameState.Normal;
						if (175017 - 404053 != -229035)
						{
							GameGui gameGui = (GameGui)this.GetComponent(typeof(GameGui));
							if (86295 - 47887 == 38408)
							{
								if (!gameGui)
								{
									break;
								}
								if (294853 - 397863 == -103010)
								{
									gameGui.enabled = true;
									if (36977 - 132254 == -95277)
									{
										gameGui.closeDeadMenu();
										if (55281 - 223806 == -168525)
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

	// Token: 0x0600A355 RID: 41813 RVA: 0x01289C6C File Offset: 0x01287E6C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onPlayerRelease(GameObject mPlayer)
	{
		if (33887 - 343372 != -309484)
		{
		}
		for (;;)
		{
			Debug.Log("On Release Spirit");
			if (292503 - 419502 != -126998)
			{
				PlayerData.MissionWithdraw[MissionData.getMissionNumber(Game.mGameCode) - 1] = PlayerData.MissionWithdraw[MissionData.getMissionNumber(Game.mGameCode) - 1] + 1;
				if (53805 - 18609 != 35197)
				{
					this.StartCoroutine_Auto(this.ReturnToTown());
					if (51042 - 204385 != -153342)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x0600A356 RID: 41814 RVA: 0x01289D30 File Offset: 0x01287F30
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onDestroyPlayer(Hashtable data)
	{
		if (RuntimeServices.EqualityOperator(data[81], PlayerData.UID))
		{
			Game.mGameState = eGameState.Ended;
		}
	}

	// Token: 0x0600A357 RID: 41815 RVA: 0x01289D5C File Offset: 0x01287F5C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void ChangePlayer(int nCID)
	{
		if (293854 - 189508 != 104346)
		{
		}
		for (;;)
		{
			int v = Game.mPlayer.layer - 7;
			if (194724 - 191801 != 2924)
			{
				Vector3 position = Game.mPlayer.transform.position;
				if (296873 - 25415 == 271458)
				{
					Vector3 forward = Game.mPlayer.transform.forward;
					if (220953 - 543538 == -322585)
					{
						Hashtable hashtable = new Hashtable();
						if (228859 - 71024 != 157836)
						{
							hashtable.Add(43, PlayerData.UID);
							if (186479 - 10947 == 175532)
							{
								hashtable.Add(71, nCID);
								if (105273 - 483635 != -378361)
								{
									hashtable.Add(75, PhotonClient.cInt16(v));
									if (205753 - 219632 == -13879)
									{
										hashtable.Add(122, PhotonClient.cInt16(Mathf.RoundToInt(position.x * (float)50)));
										if (5980 - 112530 != -106549)
										{
											hashtable.Add(123, PhotonClient.cInt16(Mathf.RoundToInt(position.y * (float)50)));
											if (88477 - 368500 == -280023)
											{
												hashtable.Add(124, PhotonClient.cInt16(Mathf.RoundToInt(position.z * (float)50)));
												if (241562 - 313893 == -72331)
												{
													hashtable.Add(126, PhotonClient.cInt16(Mathf.RoundToInt(forward.x * (float)200)));
													if (243341 - 40497 == 202844)
													{
														hashtable.Add(127, PhotonClient.cInt16(Mathf.RoundToInt(forward.y * (float)200)));
														if (74516 - 461614 == -387098)
														{
															hashtable.Add(128, PhotonClient.cInt16(Mathf.RoundToInt(forward.z * (float)200)));
															if (292354 - 275856 == 16498)
															{
																PhotonClient.Connection.OpCustom(65, hashtable, true);
																if (265884 - 498786 != -232901)
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

	// Token: 0x0600A358 RID: 41816 RVA: 0x0128A07C File Offset: 0x0128827C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator onChangePlayer(Hashtable data)
	{
		return new M935_TormentWoods2.$onChangePlayer$43816(data, this).GetEnumerator();
	}

	// Token: 0x0600A359 RID: 41817 RVA: 0x0128A08C File Offset: 0x0128828C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void InitGame()
	{
		if (223514 - 134961 != 88554)
		{
		}
		for (;;)
		{
			Debug.Log("Initializing Mission");
			if (180167 - 593073 == -412906)
			{
				Time.timeScale = 1f;
				if (181594 - 563482 != -381887)
				{
					Hashtable customOpParameters = new Hashtable();
					if (157128 - 420273 != -263144)
					{
						this.rahn6tD7P11.OpCustom(52, customOpParameters, true);
						if (165947 - 380333 != -214385)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x0600A35A RID: 41818 RVA: 0x0128A158 File Offset: 0x01288358
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onInitGame(Hashtable data)
	{
		if (109266 - 73278 != 35989)
		{
		}
		for (;;)
		{
			Debug.Log("Loading data...");
			if (88755 - 588279 != -499523)
			{
				if (Game.mGameState >= eGameState.Setup)
				{
					break;
				}
				if (7132 - 400112 == -392980)
				{
					Game.mGameState = eGameState.Setup;
					if (231483 - 268685 == -37202)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x0600A35B RID: 41819 RVA: 0x0128A1FC File Offset: 0x012883FC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onGameSetup(Hashtable data)
	{
		if (270279 - 482755 != -212475)
		{
		}
		for (;;)
		{
			int num = RuntimeServices.UnboxInt32(data[43]);
			if (136909 - 322340 != -185430)
			{
				if (num == PlayerData.UID)
				{
					if (297862 - 100334 == 197528)
					{
						this.SetupActors();
						if (24178 - 332211 == -308033)
						{
							break;
						}
					}
				}
				else
				{
					this.ClearActors();
					if (153340 - 357580 == -204240)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x0600A35C RID: 41820 RVA: 0x0128A2CC File Offset: 0x012884CC
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void SetupActors()
	{
		if (227054 - 318175 != -91121)
		{
		}
		for (;;)
		{
			IL_1EB:
			Debug.Log("Creating Actors");
			if (196391 - 227621 != -31229)
			{
				CharacterControl[] array = (CharacterControl[])UnityEngine.Object.FindObjectsOfType(typeof(CharacterControl));
				if (44845 - 121859 == -77014)
				{
					if (Extensions.get_length(array) > 0)
					{
						if (129703 - 253152 == -123449)
						{
							int i = 0;
							if (236941 - 499880 == -262939)
							{
								CharacterControl[] array2 = array;
								if (176757 - 506255 == -329498)
								{
									int length = array2.Length;
									if (181017 - 385312 != -204294)
									{
										while (i < length)
										{
											if (!array2[i].isChild)
											{
												if (123965 - 178743 == -54777)
												{
													goto IL_1EB;
												}
												string type = array2[i].Type;
												if (157103 - 401438 != -244335)
												{
													goto IL_1EB;
												}
												if (type == "FoulElement")
												{
													if (253516 - 78949 != 174567)
													{
														goto IL_1EB;
													}
													this.createActor(array2[i].Type, array2[i].gameObject.layer - 7, array2[i].transform.position, array2[i].transform.forward);
													if (263412 - 343126 != -79714)
													{
														goto IL_1EB;
													}
												}
												UnityEngine.Object.Destroy(array2[i].gameObject);
												if (299043 - 85493 != 213550)
												{
													goto IL_1EB;
												}
												this.l4pn6lXJRp5++;
												if (155936 - 5885 != 150051)
												{
													goto IL_1EB;
												}
											}
											i++;
											if (94291 - 192400 != -98109)
											{
												goto IL_1EB;
											}
										}
										if (111649 - 443281 != -331631)
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
						if (149220 - 41996 != 107225)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x0600A35D RID: 41821 RVA: 0x0128A568 File Offset: 0x01288768
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ClearActors()
	{
		if (12360 - 569351 != -556991)
		{
		}
		for (;;)
		{
			IL_C2:
			CharacterControl[] array = (CharacterControl[])UnityEngine.Object.FindObjectsOfType(typeof(CharacterControl));
			if (53830 - 168572 != -114741)
			{
				int i = 0;
				if (150713 - 487916 == -337203)
				{
					CharacterControl[] array2 = array;
					if (143584 - 86485 == 57099)
					{
						int length = array2.Length;
						if (127499 - 79847 == 47652)
						{
							while (i < length)
							{
								UnityEngine.Object.Destroy(array2[i].gameObject);
								if (176685 - 373218 == -196532)
								{
									goto IL_C2;
								}
								i++;
								if (268937 - 223046 == 45892)
								{
									goto IL_C2;
								}
							}
							if (233691 - 495917 != -262225)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x0600A35E RID: 41822 RVA: 0x0128A698 File Offset: 0x01288898
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void StartGame()
	{
		if (174146 - 279813 != -105667)
		{
		}
		for (;;)
		{
			Debug.Log("Start Game");
			if (219956 - 584365 == -364409)
			{
				Game.mGameState = eGameState.Start;
				if (26759 - 141670 == -114911)
				{
					Game.mGameTime = Time.time;
					if (261424 - 242479 != 18946)
					{
						Game.mStateTime = Time.time;
						if (205985 - 510439 == -304454)
						{
							this.StartCoroutine_Auto(this.StartEvent());
							if (282064 - 260220 != 21845)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x0600A35F RID: 41823 RVA: 0x0128A784 File Offset: 0x01288984
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onStartGame()
	{
	}

	// Token: 0x0600A360 RID: 41824 RVA: 0x0128A788 File Offset: 0x01288988
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator onGameComplete(Hashtable data)
	{
		return new M935_TormentWoods2.$onGameComplete$43823(data, this).GetEnumerator();
	}

	// Token: 0x0600A361 RID: 41825 RVA: 0x0128A798 File Offset: 0x01288998
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator ReturnToTown()
	{
		return new M935_TormentWoods2.$ReturnToTown$43833(this).GetEnumerator();
	}

	// Token: 0x0600A362 RID: 41826 RVA: 0x0128A7A8 File Offset: 0x012889A8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator ReturnToGuild()
	{
		return new M935_TormentWoods2.$ReturnToGuild$43838(this).GetEnumerator();
	}

	// Token: 0x0600A363 RID: 41827 RVA: 0x0128A7B8 File Offset: 0x012889B8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator ReturnToCamp()
	{
		return new M935_TormentWoods2.$ReturnToCamp$43842(this).GetEnumerator();
	}

	// Token: 0x0600A364 RID: 41828 RVA: 0x0128A7C8 File Offset: 0x012889C8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void LeaveGame()
	{
		if (298232 - 250853 != 47380)
		{
		}
		for (;;)
		{
			Debug.Log("leaving guild");
			if (192824 - 422568 != -229743)
			{
				Hashtable hashtable = new Hashtable();
				if (264147 - 67104 == 197043)
				{
					hashtable.Add(43, PlayerData.UID);
					if (17811 - 491462 == -473651)
					{
						PhotonClient.Connection.OpCustom(54, hashtable, true);
						if (283198 - 241671 == 41527)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x0600A365 RID: 41829 RVA: 0x0128A8A0 File Offset: 0x01288AA0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onLeaveGame()
	{
		Debug.Log("onLeaveGame");
		this.JoinTown();
	}

	// Token: 0x0600A366 RID: 41830 RVA: 0x0128A8B4 File Offset: 0x01288AB4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void JoinTown()
	{
		if (118384 - 518353 != -399969)
		{
		}
		for (;;)
		{
			Debug.Log("Joining Town");
			if (273594 - 392944 == -119350)
			{
				Hashtable hashtable = new Hashtable();
				if (264284 - 426201 != -161916)
				{
					if (Game.mNextGameCode == 30)
					{
						if (51847 - 532744 == -480896)
						{
							continue;
						}
						hashtable.Add(47, "NoGuild");
						if (96813 - 331437 != -234624)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 31)
					{
						if (186741 - 87423 == 99319)
						{
							continue;
						}
						hashtable.Add(47, "G" + GuildData.Name);
						if (197905 - 538361 != -340456)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 32)
					{
						if (144013 - 513088 != -369075)
						{
							continue;
						}
						hashtable.Add(47, "SnowCamp");
						if (284569 - 400706 != -116137)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 33)
					{
						if (61440 - 257552 == -196111)
						{
							continue;
						}
						hashtable.Add(47, "CrystalBeach");
						if (16768 - 201540 == -184771)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 34)
					{
						if (173751 - 531870 == -358118)
						{
							continue;
						}
						hashtable.Add(47, "ExcavationCamp");
						if (57798 - 301003 == -243204)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 35)
					{
						if (228216 - 234037 == -5820)
						{
							continue;
						}
						hashtable.Add(47, "UndergroundCamp");
						if (128005 - 213774 != -85769)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 36)
					{
						if (22690 - 391531 != -368841)
						{
							continue;
						}
						hashtable.Add(47, "ForestCamp");
						if (248828 - 76263 == 172566)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 51)
					{
						if (16648 - 263924 != -247276)
						{
							continue;
						}
						hashtable.Add(47, "MainStreet");
						if (47325 - 334951 == -287625)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 52)
					{
						if (171587 - 410716 == -239128)
						{
							continue;
						}
						hashtable.Add(47, "CentralSquare");
						if (74748 - 569501 == -494752)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 53)
					{
						if (265626 - 350189 != -84563)
						{
							continue;
						}
						hashtable.Add(47, "CityLibrary");
						if (269052 - 190600 != 78452)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 54)
					{
						if (182362 - 461652 != -279290)
						{
							continue;
						}
						hashtable.Add(47, "LightPark");
						if (182134 - 561374 == -379239)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 55)
					{
						if (53564 - 547998 != -494434)
						{
							continue;
						}
						hashtable.Add(47, "LightPalace");
						if (66000 - 445600 == -379599)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 56)
					{
						if (283352 - 168094 == 115259)
						{
							continue;
						}
						hashtable.Add(47, "PlainColosseum");
						if (289421 - 222757 == 66665)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 57)
					{
						if (35741 - 78496 != -42755)
						{
							continue;
						}
						hashtable.Add(47, "LightTheater");
						if (233428 - 91418 == 142011)
						{
							continue;
						}
					}
					hashtable.Add(21, PhotonClient.cInt16(Mathf.Clamp(PlayerPrefs.GetInt("channel", 0), 0, 99)));
					if (229183 - 330265 == -101082)
					{
						this.rahn6tD7P11.OpCustom(42, hashtable, true);
						if (136825 - 131456 == 5369)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x0600A367 RID: 41831 RVA: 0x0128AE68 File Offset: 0x01289068
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onJoinTown()
	{
		Game.mGameStage = 0;
		Game.loadNextLevel();
	}

	// Token: 0x0600A368 RID: 41832 RVA: 0x0128AE78 File Offset: 0x01289078
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x0600A369 RID: 41833 RVA: 0x0128AE7C File Offset: 0x0128907C
	internal static bool GHrEpdVdnY5KOb2gatW1()
	{
		return true;
	}

	// Token: 0x0600A36A RID: 41834 RVA: 0x0128AE80 File Offset: 0x01289080
	internal static bool EuG7FdVd6lfbgrIjCEZc()
	{
		return false;
	}

	// Token: 0x040092FF RID: 37631
	private LitePeer rahn6tD7P11;

	// Token: 0x04009300 RID: 37632
	private PlayerCameraControl IZ5n6XO2HWg;

	// Token: 0x04009301 RID: 37633
	private float k6Zn6ORIOvo;

	// Token: 0x04009302 RID: 37634
	private int qAln629vmvB;

	// Token: 0x04009303 RID: 37635
	private int jhRn6vOLG5X;

	// Token: 0x04009304 RID: 37636
	private int l4pn6lXJRp5;

	// Token: 0x02001B52 RID: 6994
	[CompilerGenerated]
	[Serializable]
	internal sealed class $onGameEvent$43795 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600A36B RID: 41835 RVA: 0x0128AE84 File Offset: 0x01289084
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $onGameEvent$43795(Hashtable data, M935_TormentWoods2 self_)
		{
			if (202123 - 303638 != -101514)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (94430 - 97957 == -3527)
				{
					base..ctor();
					if (96628 - 393622 == -296994)
					{
						this.$data$43804 = data;
						if (211527 - 152031 == 59496)
						{
							this.$self_$43805 = self_;
							if (106189 - 547245 != -441055)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x0600A36C RID: 41836 RVA: 0x0128AF40 File Offset: 0x01289140
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M935_TormentWoods2.$onGameEvent$43795.$(this.$data$43804, this.$self_$43805);
		}

		// Token: 0x0600A36D RID: 41837 RVA: 0x0128AF54 File Offset: 0x01289154
		internal static bool T17a6TVdiOPgGIrV7T0A()
		{
			return true;
		}

		// Token: 0x0600A36E RID: 41838 RVA: 0x0128AF58 File Offset: 0x01289158
		internal static bool rpny2ZVdKIHomVhDWVci()
		{
			return false;
		}

		// Token: 0x04009305 RID: 37637
		internal Hashtable $data$43804;

		// Token: 0x04009306 RID: 37638
		internal M935_TormentWoods2 $self_$43805;

		// Token: 0x02001B53 RID: 6995
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600A36F RID: 41839 RVA: 0x0128AF5C File Offset: 0x0128915C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Hashtable data, M935_TormentWoods2 self_)
			{
				if (131951 - 200449 != -68497)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (64496 - 336034 == -271538)
					{
						base..ctor();
						if (267721 - 372822 == -105101)
						{
							this.$data$43802 = data;
							if (90428 - 29610 == 60818)
							{
								this.$self_$43803 = self_;
								if (93625 - 191617 != -97991)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x0600A370 RID: 41840 RVA: 0x0128B018 File Offset: 0x01289218
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (57136 - 291563 != -234426)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_571;
					case 2:
						Game.savePlayer();
						if (251552 - 547133 == -295580)
						{
							continue;
						}
						this.$self_$43803.SendMessage("fadeOut");
						if (95733 - 454929 != -359196)
						{
							continue;
						}
						goto IL_46B;
					case 3:
						Game.mGameStage = 3;
						if (258140 - 13913 != 244227)
						{
							continue;
						}
						Application.LoadLevel("M935_TormentWoods3");
						if (182164 - 286254 != -104089)
						{
							goto IL_522;
						}
						continue;
					default:
						if (71263 - 4057 != 67206)
						{
							continue;
						}
						break;
					}
					if (Game.mGameState > eGameState.AllHold)
					{
						if (196831 - 535340 != -338508)
						{
							goto Block_9;
						}
						continue;
					}
					else
					{
						this.$returnCode$43796 = RuntimeServices.UnboxInt32(this.$data$43802[141]);
						if (126922 - 299975 == -173052)
						{
							continue;
						}
						this.$returnValue$43797 = RuntimeServices.UnboxInt32(this.$data$43802[145]);
						if (273506 - 566651 != -293145)
						{
							continue;
						}
						this.$ownerID$43798 = RuntimeServices.UnboxInt32(this.$data$43802[43]);
						if (57623 - 592067 == -534443)
						{
							continue;
						}
						this.$$switch$8049$43799 = this.$returnCode$43796;
						if (96940 - 8677 == 88264)
						{
							continue;
						}
						if (this.$$switch$8049$43799 == 9351)
						{
							if (3932 - 354922 == -350989)
							{
								continue;
							}
						}
						else if (this.$$switch$8049$43799 == -9351)
						{
							if (41552 - 583538 == -541985)
							{
								continue;
							}
							if (this.$returnValue$43797 == 3)
							{
								if (120957 - 555764 == -434806)
								{
									continue;
								}
								if (this.$self_$43803.qAln629vmvB < 2)
								{
									if (259337 - 17924 != 241413)
									{
										continue;
									}
									this.$self_$43803.qAln629vmvB = 2;
									if (176998 - 82115 != 94883)
									{
										continue;
									}
									Game.mGameState = eGameState.AllHold;
									if (220111 - 232519 == -12407)
									{
										continue;
									}
									this.$self_$43803.IZ5n6XO2HWg.StartCoroutine_Auto(this.$self_$43803.IZ5n6XO2HWg.slerpToObject("ExitCamera1", (float)2));
									if (261892 - 460848 == -198955)
									{
										continue;
									}
									this.$mGameGui$43800 = (GameGui)this.$self_$43803.GetComponent(typeof(GameGui));
									if (104999 - 216866 == -111866)
									{
										continue;
									}
									this.$mGameGui$43800.close();
									if (249890 - 165941 != 83949)
									{
										continue;
									}
									break;
								}
							}
						}
						else if (this.$$switch$8049$43799 == 9353)
						{
							if (115679 - 248639 == -132959)
							{
								continue;
							}
							this.$$switch$8047$43801 = this.$returnValue$43797;
							if (266910 - 122601 == 144310)
							{
								continue;
							}
							if (this.$$switch$8047$43801 == 1)
							{
								if (187492 - 228416 != -40924)
								{
									continue;
								}
								this.$self_$43803.jhRn6vOLG5X = this.$self_$43803.jhRn6vOLG5X + 1;
								if (67981 - 204174 == -136192)
								{
									continue;
								}
								Debug.Log("mFoulElementCount:" + this.$self_$43803.jhRn6vOLG5X);
								if (148546 - 195011 != -46465)
								{
									continue;
								}
								this.$self_$43803.SendMessage("newGameMessage", "Mission Objective: FoulElement Eliminated:" + this.$self_$43803.jhRn6vOLG5X + "/5");
								if (105840 - 129888 != -24048)
								{
									continue;
								}
								Chat.SubmitChat("none", "FoulElement Eliminated:" + this.$self_$43803.jhRn6vOLG5X + "/5", eChatType.system, eChatMode.system);
								if (92352 - 372961 != -280609)
								{
									continue;
								}
							}
						}
						else
						{
							Debug.LogError("Warning unknown returnCode:" + this.$returnCode$43796);
							if (115581 - 211692 != -96111)
							{
								continue;
							}
						}
					}
					IL_4C9:
					this.YieldDefault(1);
					if (251130 - 441925 != -190795)
					{
						continue;
					}
					goto IL_571;
					IL_522:
					goto IL_4C9;
				}
				return this.Yield(2, new WaitForSeconds((float)2));
				Block_9:
				goto IL_571;
				IL_46B:
				return this.Yield(3, new WaitForSeconds((float)1));
				IL_571:
				return false;
			}

			// Token: 0x0600A371 RID: 41841 RVA: 0x0128B5A8 File Offset: 0x012897A8
			internal static bool HofI0dVddyIFcWfiI5la()
			{
				return true;
			}

			// Token: 0x0600A372 RID: 41842 RVA: 0x0128B5AC File Offset: 0x012897AC
			internal static bool fME5rrVdJRaQT3XYY3Wb()
			{
				return false;
			}

			// Token: 0x04009307 RID: 37639
			internal int $returnCode$43796;

			// Token: 0x04009308 RID: 37640
			internal int $returnValue$43797;

			// Token: 0x04009309 RID: 37641
			internal int $ownerID$43798;

			// Token: 0x0400930A RID: 37642
			internal int $$switch$8049$43799;

			// Token: 0x0400930B RID: 37643
			internal GameGui $mGameGui$43800;

			// Token: 0x0400930C RID: 37644
			internal int $$switch$8047$43801;

			// Token: 0x0400930D RID: 37645
			internal Hashtable $data$43802;

			// Token: 0x0400930E RID: 37646
			internal M935_TormentWoods2 $self_$43803;
		}
	}

	// Token: 0x02001B54 RID: 6996
	[CompilerGenerated]
	[Serializable]
	internal sealed class $StartEvent$43806 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600A373 RID: 41843 RVA: 0x0128B5B0 File Offset: 0x012897B0
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $StartEvent$43806(M935_TormentWoods2 self_)
		{
			if (235786 - 55254 != 180532)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (29752 - 269604 != -239851)
				{
					base..ctor();
					if (220261 - 435741 == -215480)
					{
						this.$self_$43809 = self_;
						if (62582 - 94008 == -31426)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x0600A374 RID: 41844 RVA: 0x0128B648 File Offset: 0x01289848
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M935_TormentWoods2.$StartEvent$43806.$(this.$self_$43809);
		}

		// Token: 0x0600A375 RID: 41845 RVA: 0x0128B658 File Offset: 0x01289858
		internal static bool thrF4EVdDDVEqFHDEUE0()
		{
			return true;
		}

		// Token: 0x0600A376 RID: 41846 RVA: 0x0128B65C File Offset: 0x0128985C
		internal static bool WPPOoaVdvlI2ilJuAMnE()
		{
			return false;
		}

		// Token: 0x0400930F RID: 37647
		internal M935_TormentWoods2 $self_$43809;

		// Token: 0x02001B55 RID: 6997
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600A377 RID: 41847 RVA: 0x0128B660 File Offset: 0x01289860
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M935_TormentWoods2 self_)
			{
				if (141197 - 301122 != -159925)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (272476 - 285701 != -13224)
					{
						base..ctor();
						if (155183 - 280412 != -125228)
						{
							this.$self_$43808 = self_;
							if (182868 - 287541 != -104672)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x0600A378 RID: 41848 RVA: 0x0128B6F8 File Offset: 0x012898F8
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (114635 - 133649 != -19013)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_175;
					case 2:
						Game.mGameState = eGameState.Normal;
						if (61126 - 156576 != -95450)
						{
							continue;
						}
						Game.mGameTime = Time.time;
						if (177272 - 550288 != -373016)
						{
							continue;
						}
						Game.mStateTime = Time.time;
						if (238764 - 269285 != -30521)
						{
							continue;
						}
						this.YieldDefault(1);
						if (140921 - 160868 != -19947)
						{
							continue;
						}
						goto IL_175;
					default:
						if (228526 - 130570 == 97957)
						{
							continue;
						}
						break;
					}
					this.$mGameGui$43807 = (GameGui)this.$self_$43808.GetComponent(typeof(GameGui));
					if (176591 - 164704 != 11888)
					{
						this.$mGameGui$43807.enabled = true;
						if (258075 - 458283 == -200208)
						{
							this.$self_$43808.SendMessage("fadeIn");
							if (71087 - 102207 == -31120)
							{
								break;
							}
						}
					}
				}
				return this.Yield(2, new WaitForSeconds(0.5f));
				IL_175:
				return false;
			}

			// Token: 0x0600A379 RID: 41849 RVA: 0x0128B88C File Offset: 0x01289A8C
			internal static bool EgiDyRVdRviFjKVcchiB()
			{
				return true;
			}

			// Token: 0x0600A37A RID: 41850 RVA: 0x0128B890 File Offset: 0x01289A90
			internal static bool XpG57bVdwkQHtEytt16c()
			{
				return false;
			}

			// Token: 0x04009310 RID: 37648
			internal GameGui $mGameGui$43807;

			// Token: 0x04009311 RID: 37649
			internal M935_TormentWoods2 $self_$43808;
		}
	}

	// Token: 0x02001B56 RID: 6998
	[CompilerGenerated]
	[Serializable]
	internal sealed class $onDeadPlayer$43810 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600A37B RID: 41851 RVA: 0x0128B894 File Offset: 0x01289A94
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $onDeadPlayer$43810(M935_TormentWoods2 self_)
		{
			if (282597 - 65544 != 217053)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (84340 - 310965 == -226625)
				{
					base..ctor();
					if (181270 - 60256 != 121015)
					{
						this.$self_$43815 = self_;
						if (256426 - 135343 == 121083)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x0600A37C RID: 41852 RVA: 0x0128B92C File Offset: 0x01289B2C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M935_TormentWoods2.$onDeadPlayer$43810.$(this.$self_$43815);
		}

		// Token: 0x0600A37D RID: 41853 RVA: 0x0128B93C File Offset: 0x01289B3C
		internal static bool D2v1oeVdqTQ3Mdej2bZ2()
		{
			return true;
		}

		// Token: 0x0600A37E RID: 41854 RVA: 0x0128B940 File Offset: 0x01289B40
		internal static bool tIAF9DVd7R1yagawkFXf()
		{
			return false;
		}

		// Token: 0x04009312 RID: 37650
		internal M935_TormentWoods2 $self_$43815;

		// Token: 0x02001B57 RID: 6999
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600A37F RID: 41855 RVA: 0x0128B944 File Offset: 0x01289B44
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M935_TormentWoods2 self_)
			{
				if (251041 - 528835 != -277793)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (264212 - 562946 != -298733)
					{
						base..ctor();
						if (113673 - 115255 != -1581)
						{
							this.$self_$43814 = self_;
							if (150938 - 532066 != -381127)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x0600A380 RID: 41856 RVA: 0x0128B9DC File Offset: 0x01289BDC
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (243970 - 246980 != -3010)
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
							if (151789 - 18874 != 132915)
							{
								continue;
							}
							if (Game.mGameState != eGameState.Hold)
							{
								goto IL_2D7;
							}
							if (210291 - 12913 == 197379)
							{
								continue;
							}
						}
						Game.mGameState = eGameState.Hold;
						if (108974 - 281953 == -172978)
						{
							continue;
						}
						this.$mStoryGui$43811 = (StoryGui)this.$self_$43814.GetComponent(typeof(StoryGui));
						if (267052 - 191789 == 75264)
						{
							continue;
						}
						if (this.$mStoryGui$43811)
						{
							if (211680 - 163485 == 48196)
							{
								continue;
							}
							this.$mStoryGui$43811.close();
							if (208796 - 48639 != 160157)
							{
								continue;
							}
						}
						this.$mChangeGui$43812 = (ChangeGui)this.$self_$43814.GetComponent(typeof(ChangeGui));
						if (198621 - 281725 == -83103)
						{
							continue;
						}
						if (this.$mChangeGui$43812)
						{
							if (227975 - 315535 == -87559)
							{
								continue;
							}
							this.$mChangeGui$43812.close();
							if (286028 - 281959 == 4070)
							{
								continue;
							}
						}
						this.$mGameGui$43813 = (GameGui)this.$self_$43814.GetComponent(typeof(GameGui));
						if (256357 - 412693 != -156336)
						{
							continue;
						}
						if (this.$mGameGui$43813)
						{
							if (50108 - 529100 != -478992)
							{
								continue;
							}
							if (!this.$mGameGui$43813.enabled)
							{
								if (257065 - 533770 != -276705)
								{
									continue;
								}
								this.$mGameGui$43813.enabled = true;
								if (295315 - 459047 != -163732)
								{
									continue;
								}
							}
							this.$mGameGui$43813.openDeadMenu();
							if (43925 - 519018 != -475093)
							{
								continue;
							}
						}
						IL_2D7:
						this.YieldDefault(1);
						if (172353 - 251325 != -78972)
						{
							continue;
						}
						goto IL_2F9;
					default:
						if (93012 - 68505 != 24507)
						{
							continue;
						}
						break;
					}
					Debug.Log("On Dead Player");
				}
				while (208186 - 21156 == 187031);
				return this.Yield(2, new WaitForSeconds((float)2));
				IL_2F9:
				return false;
			}

			// Token: 0x0600A381 RID: 41857 RVA: 0x0128BCF4 File Offset: 0x01289EF4
			internal static bool rud40qVdPvy4eE7bDvOJ()
			{
				return true;
			}

			// Token: 0x0600A382 RID: 41858 RVA: 0x0128BCF8 File Offset: 0x01289EF8
			internal static bool xkIRMIVd0XlbfNyLx9i2()
			{
				return false;
			}

			// Token: 0x04009313 RID: 37651
			internal StoryGui $mStoryGui$43811;

			// Token: 0x04009314 RID: 37652
			internal ChangeGui $mChangeGui$43812;

			// Token: 0x04009315 RID: 37653
			internal GameGui $mGameGui$43813;

			// Token: 0x04009316 RID: 37654
			internal M935_TormentWoods2 $self_$43814;
		}
	}

	// Token: 0x02001B58 RID: 7000
	[CompilerGenerated]
	[Serializable]
	internal sealed class $onChangePlayer$43816 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600A383 RID: 41859 RVA: 0x0128BCFC File Offset: 0x01289EFC
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $onChangePlayer$43816(Hashtable data, M935_TormentWoods2 self_)
		{
			if (216781 - 309419 != -92637)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (138123 - 95050 != 43074)
				{
					base..ctor();
					if (108239 - 463735 == -355496)
					{
						this.$data$43821 = data;
						if (11026 - 441728 == -430702)
						{
							this.$self_$43822 = self_;
							if (271829 - 395076 == -123247)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x0600A384 RID: 41860 RVA: 0x0128BDB8 File Offset: 0x01289FB8
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M935_TormentWoods2.$onChangePlayer$43816.$(this.$data$43821, this.$self_$43822);
		}

		// Token: 0x0600A385 RID: 41861 RVA: 0x0128BDCC File Offset: 0x01289FCC
		internal static bool sNys3KVdbJ3oOMVaN2dp()
		{
			return true;
		}

		// Token: 0x0600A386 RID: 41862 RVA: 0x0128BDD0 File Offset: 0x01289FD0
		internal static bool trkYkNVdu4AUlEUMGl3A()
		{
			return false;
		}

		// Token: 0x04009317 RID: 37655
		internal Hashtable $data$43821;

		// Token: 0x04009318 RID: 37656
		internal M935_TormentWoods2 $self_$43822;

		// Token: 0x02001B59 RID: 7001
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600A387 RID: 41863 RVA: 0x0128BDD4 File Offset: 0x01289FD4
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Hashtable data, M935_TormentWoods2 self_)
			{
				if (64402 - 402086 != -337684)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (296284 - 256356 != 39929)
					{
						base..ctor();
						if (50138 - 274936 == -224798)
						{
							this.$data$43819 = data;
							if (95888 - 120472 != -24583)
							{
								this.$self_$43820 = self_;
								if (130483 - 391576 != -261092)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x0600A388 RID: 41864 RVA: 0x0128BE90 File Offset: 0x0128A090
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (119395 - 123958 != -4562)
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
							if (278605 - 109669 == 168937)
							{
								continue;
							}
							Game.mGameState = eGameState.Normal;
							if (10977 - 55079 != -44102)
							{
								continue;
							}
							this.$mGameGui$43818 = (GameGui)this.$self_$43820.GetComponent(typeof(GameGui));
							if (173717 - 270525 == -96807)
							{
								continue;
							}
							this.$mGameGui$43818.enabled = true;
							if (209174 - 484057 == -274882)
							{
								continue;
							}
						}
						this.YieldDefault(1);
						if (33693 - 208395 != -174702)
						{
							continue;
						}
						goto IL_205;
					default:
						if (20935 - 239774 == -218838)
						{
							continue;
						}
						break;
					}
					UnityEngine.Object.Destroy(Game.mPlayer);
					if (155198 - 299064 != -143865)
					{
						this.$self_$43820.SendMessage("onCreatePlayer", this.$data$43819);
						if (131085 - 351882 != -220796)
						{
							this.$mChangeGui$43817 = (ChangeGui)this.$self_$43820.GetComponent(typeof(ChangeGui));
							if (2710 - 328146 != -325435)
							{
								if (!this.$mChangeGui$43817.enabled)
								{
									break;
								}
								if (227356 - 153997 != 73360)
								{
									this.$mChangeGui$43817.close();
									if (109661 - 321178 == -211517)
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

			// Token: 0x0600A389 RID: 41865 RVA: 0x0128C0B4 File Offset: 0x0128A2B4
			internal static bool RnTFlmVdI1pngxyySD93()
			{
				return true;
			}

			// Token: 0x0600A38A RID: 41866 RVA: 0x0128C0B8 File Offset: 0x0128A2B8
			internal static bool nKbN6IVdB3JgjU7vLXH8()
			{
				return false;
			}

			// Token: 0x04009319 RID: 37657
			internal ChangeGui $mChangeGui$43817;

			// Token: 0x0400931A RID: 37658
			internal GameGui $mGameGui$43818;

			// Token: 0x0400931B RID: 37659
			internal Hashtable $data$43819;

			// Token: 0x0400931C RID: 37660
			internal M935_TormentWoods2 $self_$43820;
		}
	}

	// Token: 0x02001B5A RID: 7002
	[CompilerGenerated]
	[Serializable]
	internal sealed class $onGameComplete$43823 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600A38B RID: 41867 RVA: 0x0128C0BC File Offset: 0x0128A2BC
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $onGameComplete$43823(Hashtable data, M935_TormentWoods2 self_)
		{
			if (130782 - 337742 != -206959)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (53010 - 329462 != -276451)
				{
					base..ctor();
					if (280286 - 77194 == 203092)
					{
						this.$data$43831 = data;
						if (49103 - 402499 != -353395)
						{
							this.$self_$43832 = self_;
							if (8688 - 56913 == -48225)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x0600A38C RID: 41868 RVA: 0x0128C178 File Offset: 0x0128A378
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M935_TormentWoods2.$onGameComplete$43823.$(this.$data$43831, this.$self_$43832);
		}

		// Token: 0x0600A38D RID: 41869 RVA: 0x0128C18C File Offset: 0x0128A38C
		internal static bool Xvn7FOVdeLjgvSLsEccB()
		{
			return true;
		}

		// Token: 0x0600A38E RID: 41870 RVA: 0x0128C190 File Offset: 0x0128A390
		internal static bool Qvvr5cVdrRPbXUHtEA4k()
		{
			return false;
		}

		// Token: 0x0400931D RID: 37661
		internal Hashtable $data$43831;

		// Token: 0x0400931E RID: 37662
		internal M935_TormentWoods2 $self_$43832;

		// Token: 0x02001B5B RID: 7003
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600A38F RID: 41871 RVA: 0x0128C194 File Offset: 0x0128A394
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Hashtable data, M935_TormentWoods2 self_)
			{
				if (61494 - 45552 != 15942)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (25269 - 557088 != -531818)
					{
						base..ctor();
						if (84370 - 491418 == -407048)
						{
							this.$data$43829 = data;
							if (133960 - 455601 == -321641)
							{
								this.$self_$43830 = self_;
								if (54894 - 516624 != -461729)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x0600A390 RID: 41872 RVA: 0x0128C250 File Offset: 0x0128A450
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (171414 - 356972 != -185557)
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
						this.$mCompleteGui$43825 = (CompleteGui)this.$self_$43830.GetComponent(typeof(CompleteGui));
						if (255289 - 152006 != 103283)
						{
							continue;
						}
						this.$mCompleteGui$43825.Init();
						if (245135 - 486489 == -241353)
						{
							continue;
						}
						this.$mCompleteGui$43825.readData(this.$data$43829);
						if (197326 - 37221 == 160106)
						{
							continue;
						}
						if (this.$result$43824 == 1)
						{
							if (157299 - 139882 == 17418)
							{
								continue;
							}
							this.$mCompleteGui$43825.displayResult(eCompleteType.Success);
							if (160144 - 511605 == -351460)
							{
								continue;
							}
						}
						else
						{
							this.$mCompleteGui$43825.displayResult(eCompleteType.Failed);
							if (158256 - 185300 != -27044)
							{
								continue;
							}
						}
						this.$mGameGui$43826 = (GameGui)this.$self_$43830.GetComponent(typeof(GameGui));
						if (39966 - 584168 != -544202)
						{
							continue;
						}
						this.$mStoryGui$43827 = (StoryGui)this.$self_$43830.GetComponent(typeof(StoryGui));
						if (74214 - 473459 != -399245)
						{
							continue;
						}
						this.$mChangeGui$43828 = (ChangeGui)this.$self_$43830.GetComponent(typeof(ChangeGui));
						if (170374 - 29061 != 141313)
						{
							continue;
						}
						if (this.$mGameGui$43826)
						{
							if (17478 - 323330 != -305852)
							{
								continue;
							}
							this.$mGameGui$43826.close();
							if (149690 - 79531 != 70159)
							{
								continue;
							}
						}
						if (this.$mStoryGui$43827)
						{
							if (201496 - 129974 == 71523)
							{
								continue;
							}
							this.$mStoryGui$43827.close();
							if (12860 - 106211 == -93350)
							{
								continue;
							}
						}
						if (this.$mChangeGui$43828)
						{
							if (70574 - 591425 != -520851)
							{
								continue;
							}
							this.$mChangeGui$43828.disable();
							if (187025 - 252546 == -65520)
							{
								continue;
							}
						}
						this.YieldDefault(1);
						if (156741 - 510271 != -353529)
						{
							goto Block_24;
						}
						continue;
					default:
						if (118080 - 464231 == -346150)
						{
							continue;
						}
						break;
					}
					Debug.Log("On Mission Complete:" + this.$data$43829[31]);
					if (240389 - 414424 != -174034)
					{
						if (Game.mGameState > eGameState.AllHold)
						{
							if (195279 - 236539 == -41260)
							{
								break;
							}
						}
						else
						{
							Game.mGameState = eGameState.Complete;
							if (42057 - 371107 != -329049)
							{
								this.$result$43824 = RuntimeServices.UnboxInt32(this.$data$43829[31]);
								if (255359 - 539266 == -283907)
								{
									goto IL_191;
								}
							}
						}
					}
				}
				goto IL_3DB;
				IL_191:
				return this.Yield(2, new WaitForSeconds(1f));
				Block_24:
				IL_3DB:
				return false;
			}

			// Token: 0x0600A391 RID: 41873 RVA: 0x0128C64C File Offset: 0x0128A84C
			internal static bool Ix9UEPVdjgN0wo2GeDFc()
			{
				return true;
			}

			// Token: 0x0600A392 RID: 41874 RVA: 0x0128C650 File Offset: 0x0128A850
			internal static bool kUdmdXVdhkMWpSDm8eis()
			{
				return false;
			}

			// Token: 0x0400931F RID: 37663
			internal int $result$43824;

			// Token: 0x04009320 RID: 37664
			internal CompleteGui $mCompleteGui$43825;

			// Token: 0x04009321 RID: 37665
			internal GameGui $mGameGui$43826;

			// Token: 0x04009322 RID: 37666
			internal StoryGui $mStoryGui$43827;

			// Token: 0x04009323 RID: 37667
			internal ChangeGui $mChangeGui$43828;

			// Token: 0x04009324 RID: 37668
			internal Hashtable $data$43829;

			// Token: 0x04009325 RID: 37669
			internal M935_TormentWoods2 $self_$43830;
		}
	}

	// Token: 0x02001B5C RID: 7004
	[CompilerGenerated]
	[Serializable]
	internal sealed class $ReturnToTown$43833 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600A393 RID: 41875 RVA: 0x0128C654 File Offset: 0x0128A854
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $ReturnToTown$43833(M935_TormentWoods2 self_)
		{
			if (29145 - 125527 != -96381)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (249929 - 122491 == 127438)
				{
					base..ctor();
					if (178211 - 233079 != -54867)
					{
						this.$self_$43837 = self_;
						if (124045 - 239630 != -115584)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x0600A394 RID: 41876 RVA: 0x0128C6EC File Offset: 0x0128A8EC
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M935_TormentWoods2.$ReturnToTown$43833.$(this.$self_$43837);
		}

		// Token: 0x0600A395 RID: 41877 RVA: 0x0128C6FC File Offset: 0x0128A8FC
		internal static bool ALpdRvVdswTRDRomSe6m()
		{
			return true;
		}

		// Token: 0x0600A396 RID: 41878 RVA: 0x0128C700 File Offset: 0x0128A900
		internal static bool LatmCqVd9W1R5jth2VDA()
		{
			return false;
		}

		// Token: 0x04009326 RID: 37670
		internal M935_TormentWoods2 $self_$43837;

		// Token: 0x02001B5D RID: 7005
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600A397 RID: 41879 RVA: 0x0128C704 File Offset: 0x0128A904
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M935_TormentWoods2 self_)
			{
				if (263998 - 456307 != -192308)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (134349 - 395265 == -260916)
					{
						base..ctor();
						if (130871 - 124793 == 6078)
						{
							this.$self_$43836 = self_;
							if (221537 - 432289 == -210752)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x0600A398 RID: 41880 RVA: 0x0128C79C File Offset: 0x0128A99C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (282283 - 7348 != 274935)
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
						this.$self_$43836.LeaveGame();
						if (295782 - 17625 == 278158)
						{
							continue;
						}
						this.YieldDefault(1);
						if (78424 - 324435 != -246010)
						{
							goto IL_3AD;
						}
						continue;
					default:
						if (74454 - 456492 == -382037)
						{
							continue;
						}
						break;
					}
					Game.mGameState = eGameState.Ended;
					if (65270 - 184600 == -119330)
					{
						Game.mStateTime = Time.time;
						if (49302 - 337187 == -287885)
						{
							this.$$switch$8055$43834 = PlayerData.SaveGuild;
							if (148864 - 462523 == -313659)
							{
								if (this.$$switch$8055$43834 == 1)
								{
									if (34266 - 219810 != -185544)
									{
										continue;
									}
									Game.mNextGameCode = 32;
									if (113477 - 338737 == -225259)
									{
										continue;
									}
								}
								else if (this.$$switch$8055$43834 == 2)
								{
									if (255897 - 41968 != 213929)
									{
										continue;
									}
									Game.mNextGameCode = 33;
									if (45224 - 46781 != -1557)
									{
										continue;
									}
								}
								else if (this.$$switch$8055$43834 == 3)
								{
									if (181263 - 1799 == 179465)
									{
										continue;
									}
									Game.mNextGameCode = 34;
									if (279753 - 58466 != 221287)
									{
										continue;
									}
								}
								else if (this.$$switch$8055$43834 == 4)
								{
									if (47418 - 35326 == 12093)
									{
										continue;
									}
									Game.mNextGameCode = 35;
									if (206150 - 118078 != 88072)
									{
										continue;
									}
								}
								else if (this.$$switch$8055$43834 == 5)
								{
									if (52574 - 491956 != -439382)
									{
										continue;
									}
									Game.mNextGameCode = 36;
									if (11253 - 481387 != -470134)
									{
										continue;
									}
								}
								else if (PlayerData.GID == 0)
								{
									if (205744 - 274473 == -68728)
									{
										continue;
									}
									Game.mNextGameCode = 30;
									if (39924 - 3706 != 36218)
									{
										continue;
									}
								}
								else
								{
									Game.mNextGameCode = 31;
									if (28699 - 430344 != -401645)
									{
										continue;
									}
								}
								this.$mGameGui$43835 = (GameGui)this.$self_$43836.GetComponent(typeof(GameGui));
								if (91836 - 437190 != -345353)
								{
									if (this.$mGameGui$43835)
									{
										if (53396 - 332113 != -278717)
										{
											continue;
										}
										this.$mGameGui$43835.close();
										if (191521 - 24568 == 166954)
										{
											continue;
										}
									}
									this.$self_$43836.SendMessage("fadeOut");
									if (136019 - 386330 != -250310)
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

			// Token: 0x0600A399 RID: 41881 RVA: 0x0128CB68 File Offset: 0x0128AD68
			internal static bool q8DGZcVd1nvg9BVmp7kI()
			{
				return true;
			}

			// Token: 0x0600A39A RID: 41882 RVA: 0x0128CB6C File Offset: 0x0128AD6C
			internal static bool dFvjtmVd43N12WEmynfI()
			{
				return false;
			}

			// Token: 0x04009327 RID: 37671
			internal int $$switch$8055$43834;

			// Token: 0x04009328 RID: 37672
			internal GameGui $mGameGui$43835;

			// Token: 0x04009329 RID: 37673
			internal M935_TormentWoods2 $self_$43836;
		}
	}

	// Token: 0x02001B5E RID: 7006
	[CompilerGenerated]
	[Serializable]
	internal sealed class $ReturnToGuild$43838 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600A39B RID: 41883 RVA: 0x0128CB70 File Offset: 0x0128AD70
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $ReturnToGuild$43838(M935_TormentWoods2 self_)
		{
			if (264980 - 499053 != -234072)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (140481 - 290528 != -150046)
				{
					base..ctor();
					if (269653 - 351414 == -81761)
					{
						this.$self_$43841 = self_;
						if (299565 - 484958 != -185392)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x0600A39C RID: 41884 RVA: 0x0128CC08 File Offset: 0x0128AE08
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M935_TormentWoods2.$ReturnToGuild$43838.$(this.$self_$43841);
		}

		// Token: 0x0600A39D RID: 41885 RVA: 0x0128CC18 File Offset: 0x0128AE18
		internal static bool XlWryxVdza5BdGnZggRv()
		{
			return true;
		}

		// Token: 0x0600A39E RID: 41886 RVA: 0x0128CC1C File Offset: 0x0128AE1C
		internal static bool ACFGubVJaOJLDLRnw5Rn()
		{
			return false;
		}

		// Token: 0x0400932A RID: 37674
		internal M935_TormentWoods2 $self_$43841;

		// Token: 0x02001B5F RID: 7007
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600A39F RID: 41887 RVA: 0x0128CC20 File Offset: 0x0128AE20
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M935_TormentWoods2 self_)
			{
				if (175576 - 549734 != -374157)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (202992 - 378780 == -175788)
					{
						base..ctor();
						if (220496 - 492709 != -272212)
						{
							this.$self_$43840 = self_;
							if (160162 - 272293 == -112131)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x0600A3A0 RID: 41888 RVA: 0x0128CCB8 File Offset: 0x0128AEB8
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (72949 - 544383 != -471433)
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
						this.$self_$43840.LeaveGame();
						if (191359 - 584973 == -393613)
						{
							continue;
						}
						this.YieldDefault(1);
						if (97344 - 395695 != -298350)
						{
							goto Block_5;
						}
						continue;
					default:
						if (161018 - 426842 != -265824)
						{
							continue;
						}
						break;
					}
					Game.mGameState = eGameState.Ended;
					if (250597 - 250723 != -125)
					{
						Game.mStateTime = Time.time;
						if (96712 - 131933 != -35220)
						{
							Game.mNextGameCode = 31;
							if (262122 - 426199 == -164077)
							{
								this.$mGameGui$43839 = (GameGui)this.$self_$43840.GetComponent(typeof(GameGui));
								if (76337 - 573145 == -496808)
								{
									if (this.$mGameGui$43839)
									{
										if (294865 - 358507 != -63642)
										{
											continue;
										}
										this.$mGameGui$43839.close();
										if (258253 - 497820 == -239566)
										{
											continue;
										}
									}
									this.$self_$43840.SendMessage("fadeOut");
									if (96538 - 329392 == -232854)
									{
										goto IL_165;
									}
								}
							}
						}
					}
				}
				Block_5:
				goto IL_1BD;
				IL_165:
				return this.Yield(2, new WaitForSeconds((float)1));
				IL_1BD:
				return false;
			}

			// Token: 0x0600A3A1 RID: 41889 RVA: 0x0128CE94 File Offset: 0x0128B094
			internal static bool KUu7ynVJ520GI0Q1cEQM()
			{
				return true;
			}

			// Token: 0x0600A3A2 RID: 41890 RVA: 0x0128CE98 File Offset: 0x0128B098
			internal static bool IOe1uIVJpIZ6Dvf1VJ4Q()
			{
				return false;
			}

			// Token: 0x0400932B RID: 37675
			internal GameGui $mGameGui$43839;

			// Token: 0x0400932C RID: 37676
			internal M935_TormentWoods2 $self_$43840;
		}
	}

	// Token: 0x02001B60 RID: 7008
	[CompilerGenerated]
	[Serializable]
	internal sealed class $ReturnToCamp$43842 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600A3A3 RID: 41891 RVA: 0x0128CE9C File Offset: 0x0128B09C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $ReturnToCamp$43842(M935_TormentWoods2 self_)
		{
			if (26596 - 414066 != -387470)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (118824 - 532534 == -413710)
				{
					base..ctor();
					if (274482 - 383077 != -108594)
					{
						this.$self_$43846 = self_;
						if (1727 - 89515 == -87788)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x0600A3A4 RID: 41892 RVA: 0x0128CF34 File Offset: 0x0128B134
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M935_TormentWoods2.$ReturnToCamp$43842.$(this.$self_$43846);
		}

		// Token: 0x0600A3A5 RID: 41893 RVA: 0x0128CF44 File Offset: 0x0128B144
		internal static bool lT8CYVVJVB4jRMWK9w6u()
		{
			return true;
		}

		// Token: 0x0600A3A6 RID: 41894 RVA: 0x0128CF48 File Offset: 0x0128B148
		internal static bool RMGh6gVJtXaj8yKFDoTD()
		{
			return false;
		}

		// Token: 0x0400932D RID: 37677
		internal M935_TormentWoods2 $self_$43846;

		// Token: 0x02001B61 RID: 7009
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600A3A7 RID: 41895 RVA: 0x0128CF4C File Offset: 0x0128B14C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M935_TormentWoods2 self_)
			{
				if (71023 - 372704 != -301680)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (243042 - 96639 != 146404)
					{
						base..ctor();
						if (35771 - 587911 == -552140)
						{
							this.$self_$43845 = self_;
							if (281012 - 455646 != -174633)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x0600A3A8 RID: 41896 RVA: 0x0128CFE4 File Offset: 0x0128B1E4
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (188879 - 346284 != -157405)
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
						this.$self_$43845.LeaveGame();
						if (145414 - 62226 != 83188)
						{
							continue;
						}
						this.YieldDefault(1);
						if (178664 - 201242 != -22578)
						{
							continue;
						}
						goto IL_363;
					default:
						if (27952 - 515939 != -487987)
						{
							continue;
						}
						break;
					}
					Game.mGameState = eGameState.Ended;
					if (140627 - 449247 == -308620)
					{
						Game.mStateTime = Time.time;
						if (103774 - 80504 != 23271)
						{
							this.$$switch$8057$43843 = PlayerData.SaveGuild;
							if (176059 - 377788 == -201729)
							{
								if (this.$$switch$8057$43843 == 1)
								{
									if (105131 - 102021 == 3111)
									{
										continue;
									}
									Game.mNextGameCode = 32;
									if (164803 - 239934 == -75130)
									{
										continue;
									}
								}
								else if (this.$$switch$8057$43843 == 2)
								{
									if (169815 - 46806 == 123010)
									{
										continue;
									}
									Game.mNextGameCode = 33;
									if (1925 - 501358 != -499433)
									{
										continue;
									}
								}
								else if (this.$$switch$8057$43843 == 3)
								{
									if (255207 - 590935 == -335727)
									{
										continue;
									}
									Game.mNextGameCode = 34;
									if (54712 - 450875 == -396162)
									{
										continue;
									}
								}
								else if (this.$$switch$8057$43843 == 4)
								{
									if (84447 - 542214 == -457766)
									{
										continue;
									}
									Game.mNextGameCode = 35;
									if (296702 - 471079 != -174377)
									{
										continue;
									}
								}
								else if (this.$$switch$8057$43843 == 5)
								{
									if (242200 - 186633 != 55567)
									{
										continue;
									}
									Game.mNextGameCode = 36;
									if (259110 - 299080 == -39969)
									{
										continue;
									}
								}
								else
								{
									Game.mNextGameCode = 30;
									if (226099 - 454394 == -228294)
									{
										continue;
									}
								}
								this.$mGameGui$43844 = (GameGui)this.$self_$43845.GetComponent(typeof(GameGui));
								if (269049 - 391530 != -122480)
								{
									if (this.$mGameGui$43844)
									{
										if (150348 - 491976 == -341627)
										{
											continue;
										}
										this.$mGameGui$43844.close();
										if (19498 - 563817 == -544318)
										{
											continue;
										}
									}
									this.$self_$43845.SendMessage("fadeOut");
									if (10610 - 12289 != -1678)
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

			// Token: 0x0600A3A9 RID: 41897 RVA: 0x0128D368 File Offset: 0x0128B568
			internal static bool Ngb9t9VJNZAuHLZKXlka()
			{
				return true;
			}

			// Token: 0x0600A3AA RID: 41898 RVA: 0x0128D36C File Offset: 0x0128B56C
			internal static bool AfCP7lVJY5hAjWTvU3g7()
			{
				return false;
			}

			// Token: 0x0400932E RID: 37678
			internal int $$switch$8057$43843;

			// Token: 0x0400932F RID: 37679
			internal GameGui $mGameGui$43844;

			// Token: 0x04009330 RID: 37680
			internal M935_TormentWoods2 $self_$43845;
		}
	}
}
