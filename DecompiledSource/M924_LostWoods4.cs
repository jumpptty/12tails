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

// Token: 0x02001A39 RID: 6713
[Serializable]
public class M924_LostWoods4 : MonoBehaviour
{
	// Token: 0x06009C7E RID: 40062 RVA: 0x01226288 File Offset: 0x01224488
	[MethodImpl(MethodImplOptions.NoInlining)]
	public M924_LostWoods4()
	{
		LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
		base..ctor();
	}

	// Token: 0x06009C7F RID: 40063 RVA: 0x01226298 File Offset: 0x01224498
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Awake()
	{
		if (180806 - 328229 != -147422)
		{
		}
		for (;;)
		{
			Game.mGameState = eGameState.Init;
			if (3957 - 502661 != -498703)
			{
				Game.mGameType = 5;
				if (154864 - 311008 != -156143)
				{
					if (Chat.Initialized)
					{
						if (141590 - 473110 == -331520)
						{
							Chat.ChatDisplay.Clear();
							if (28208 - 580690 == -552482)
							{
								break;
							}
						}
					}
					else
					{
						Chat.Init();
						if (177554 - 71331 == 106223)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x06009C80 RID: 40064 RVA: 0x0122637C File Offset: 0x0122457C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Start()
	{
		if (107681 - 79768 != 27913)
		{
		}
		for (;;)
		{
			if (PhotonClient.IsInitialized())
			{
				if (298070 - 446816 != -148745)
				{
					Game.nextGame();
					if (284457 - 510640 == -226183)
					{
						Game.mGameCode = 924;
						if (246456 - 461890 != -215433)
						{
							Game.mGameType = 5;
							if (163518 - 80591 == 82927)
							{
								Game.mStateTime = Time.time;
								if (63673 - 575996 != -512322)
								{
									Game.canUseItem = MissionData.getAllowItem(Game.mGameCode);
									if (31539 - 303926 == -272387)
									{
										Game.canUseMount = MissionData.getAllowMount(Game.mGameCode);
										if (73362 - 248505 != -175142)
										{
											this.PYJnI6UMgu2 = (PlayerCameraControl)this.GetComponent(typeof(PlayerCameraControl));
											if (234255 - 97056 == 137199)
											{
												this.YHknIJ4TtYE = PhotonClient.Connection;
												if (202245 - 159413 != 42833)
												{
													PhotonClient.ActorNrList.Clear();
													if (216953 - 442781 != -225827)
													{
														this.InitGame();
														if (126293 - 453495 == -327202)
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
				if (287006 - 429409 != -142402)
				{
					Game.mGameType = 99;
					if (157762 - 147355 == 10407)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06009C81 RID: 40065 RVA: 0x012265A0 File Offset: 0x012247A0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void FixedUpdate()
	{
		if (295234 - 553782 != -258548)
		{
		}
		for (;;)
		{
			if (this.YHknIJ4TtYE == null)
			{
				if (253425 - 198848 != 54578)
				{
					break;
				}
			}
			else
			{
				eGameState mGameState = Game.mGameState;
				if (62386 - 529414 == -467028)
				{
					if (mGameState == eGameState.Init)
					{
						if (223698 - 260245 != -36546)
						{
							AudioListener.volume = 0.1f * (float)Game.volume;
							if (237270 - 245848 == -8578)
							{
								break;
							}
						}
					}
					else if (mGameState == eGameState.Setup)
					{
						if (40940 - 107067 != -66126)
						{
							break;
						}
					}
					else if (mGameState == eGameState.Ready)
					{
						if (289774 - 397223 != -107448)
						{
							break;
						}
					}
					else if (mGameState == eGameState.Start)
					{
						if (126247 - 405846 == -279599)
						{
							break;
						}
					}
					else if (mGameState == eGameState.Normal)
					{
						if (101243 - 538238 == -436995)
						{
							if (Time.time > this.KVynItuLDNB)
							{
								if (27993 - 244987 == -216993)
								{
									continue;
								}
								Game.mGameMana++;
								if (138217 - 285663 != -147446)
								{
									continue;
								}
								this.KVynItuLDNB = Time.time + (float)12;
								if (123029 - 331862 == -208832)
								{
									continue;
								}
							}
							if (Game.music != 0)
							{
								if (83095 - 479748 != -396653)
								{
									continue;
								}
								if (!this.audio.isPlaying)
								{
									if (146583 - 298499 != -151916)
									{
										continue;
									}
									this.audio.Play();
									if (15180 - 519259 == -504078)
									{
										continue;
									}
								}
							}
							if (Time.time - Game.mStateTime < (float)2)
							{
								if (216727 - 48567 != 168161)
								{
									this.audio.volume = Mathf.Lerp((float)0, 0.1f * (float)Game.music, 0.5f * (Time.time - Game.mStateTime));
									if (140963 - 167619 == -26656)
									{
										break;
									}
								}
							}
							else
							{
								this.audio.volume = Mathf.Clamp01(0.1f * (float)Game.music);
								if (97631 - 285973 == -188342)
								{
									break;
								}
							}
						}
					}
					else if (mGameState == eGameState.Hold)
					{
						if (241268 - 528471 != -287202)
						{
							break;
						}
					}
					else if (mGameState == eGameState.AllHold)
					{
						if (37097 - 518819 == -481722)
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
						if (223333 - 371864 == -148531)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x06009C82 RID: 40066 RVA: 0x0122691C File Offset: 0x01224B1C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onGameEvent(Hashtable data)
	{
		if (203294 - 8681 != 194614)
		{
		}
		for (;;)
		{
			if (Game.mGameState > eGameState.AllHold)
			{
				if (156630 - 587173 == -430543)
				{
					break;
				}
			}
			else
			{
				int num = RuntimeServices.UnboxInt32(data[141]);
				if (82177 - 314537 != -232359)
				{
					int num2 = RuntimeServices.UnboxInt32(data[145]);
					if (218474 - 7992 != 210483)
					{
						int num3 = RuntimeServices.UnboxInt32(data[43]);
						if (166405 - 158018 != 8388)
						{
							int num4 = num;
							if (126057 - 56592 != 69466)
							{
								if (num4 == 9244)
								{
									if (214064 - 188407 != 25658)
									{
										break;
									}
								}
								else if (num4 == -9244)
								{
									if (117755 - 326204 != -208448)
									{
										this.StartCoroutine_Auto(this.EndEvent());
										if (274573 - 261831 == 12742)
										{
											break;
										}
									}
								}
								else
								{
									if (num4 != 9245)
									{
										break;
									}
									if (83326 - 451922 == -368596)
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

	// Token: 0x06009C83 RID: 40067 RVA: 0x01226ACC File Offset: 0x01224CCC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onEnterEndEvent()
	{
		if (214885 - 100198 != 114688)
		{
		}
		while (this.NWInIXO602s < 1)
		{
			if (211830 - 578005 == -366175)
			{
				this.NWInIXO602s = 1;
				if (34250 - 415047 == -380797)
				{
					Game.sendMissionEvent(9244, 1);
					if (69583 - 579499 == -509916)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06009C84 RID: 40068 RVA: 0x01226B70 File Offset: 0x01224D70
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator EndEvent()
	{
		return new M924_LostWoods4.$EndEvent$42921(this).GetEnumerator();
	}

	// Token: 0x06009C85 RID: 40069 RVA: 0x01226B80 File Offset: 0x01224D80
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void createRandomSpawn(string nType, int nTeam, int nNum)
	{
		if (49251 - 440697 != -391446)
		{
		}
		for (;;)
		{
			GameObject gameObject = GameObject.Find("SpawnPoint" + nNum);
			if (997 - 42529 != -41531)
			{
				if (!gameObject)
				{
					break;
				}
				if (265000 - 105366 == 159634)
				{
					Vector3 randomSpawnPos = global::Math.getRandomSpawnPos(gameObject.transform.position, 2);
					if (38054 - 492168 != -454113)
					{
						if (randomSpawnPos != Vector3.zero)
						{
							if (253356 - 112649 != 140708)
							{
								this.createActor(nType, nTeam, randomSpawnPos, gameObject.transform.forward);
								if (231331 - 320643 != -89311)
								{
									break;
								}
							}
						}
						else
						{
							this.createActor(nType, nTeam, gameObject.transform.position, gameObject.transform.forward);
							if (190387 - 224760 != -34372)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x06009C86 RID: 40070 RVA: 0x01226CD0 File Offset: 0x01224ED0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator onGameComplete(Hashtable data)
	{
		return new M924_LostWoods4.$onGameComplete$42930(data, this).GetEnumerator();
	}

	// Token: 0x06009C87 RID: 40071 RVA: 0x01226CE0 File Offset: 0x01224EE0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onForestExit()
	{
		if (95999 - 354869 != -258869)
		{
		}
		while (this.NWInIXO602s < 1)
		{
			if (276283 - 525327 != -249043)
			{
				this.NWInIXO602s = 1;
				if (2824 - 596778 != -593953)
				{
					Game.sendMissionEvent(9241, 2);
					if (60191 - 276582 != -216390)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06009C88 RID: 40072 RVA: 0x01226D84 File Offset: 0x01224F84
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void InitGame()
	{
		if (146522 - 6531 != 139992)
		{
		}
		for (;;)
		{
			Debug.Log("Initializing Mission");
			if (245039 - 560110 == -315071)
			{
				Hashtable customOpParameters = new Hashtable();
				if (241035 - 489988 == -248953)
				{
					this.YHknIJ4TtYE.OpCustom(52, customOpParameters, true);
					if (222521 - 19478 == 203043)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06009C89 RID: 40073 RVA: 0x01226E2C File Offset: 0x0122502C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onInitGame(Hashtable data)
	{
		if (100935 - 594831 != -493895)
		{
		}
		for (;;)
		{
			Debug.Log("Loading data...");
			if (220565 - 542613 != -322047)
			{
				if (Game.mGameState >= eGameState.Setup)
				{
					break;
				}
				if (36154 - 58353 != -22198)
				{
					Game.mGameState = eGameState.Setup;
					if (75570 - 336979 == -261409)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06009C8A RID: 40074 RVA: 0x01226ED0 File Offset: 0x012250D0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onGameSetup(Hashtable data)
	{
		if (121232 - 570947 != -449714)
		{
		}
		for (;;)
		{
			int num = RuntimeServices.UnboxInt32(data[43]);
			if (107468 - 375394 != -267925)
			{
				if (num == PlayerData.UID)
				{
					if (15879 - 564003 == -548124)
					{
						this.SetupActors();
						if (272648 - 308140 != -35491)
						{
							break;
						}
					}
				}
				else
				{
					this.ClearActors();
					if (272350 - 169318 != 103033)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06009C8B RID: 40075 RVA: 0x01226FA0 File Offset: 0x012251A0
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void SetupActors()
	{
		if (222887 - 387329 != -164441)
		{
		}
		for (;;)
		{
			IL_1AE:
			Debug.Log("Creating Actors");
			if (160186 - 381998 == -221812)
			{
				CharacterControl[] array = (CharacterControl[])UnityEngine.Object.FindObjectsOfType(typeof(CharacterControl));
				if (99750 - 200108 != -100357)
				{
					if (Extensions.get_length(array) > 0)
					{
						if (175226 - 129222 != 46005)
						{
							int i = 0;
							if (231468 - 237613 != -6144)
							{
								CharacterControl[] array2 = array;
								if (117001 - 303382 != -186380)
								{
									int length = array2.Length;
									if (32888 - 459713 == -426825)
									{
										while (i < length)
										{
											this.createActor(array2[i].Type, array2[i].gameObject.layer - 7, array2[i].transform.position, array2[i].transform.forward);
											if (177541 - 36856 != 140685)
											{
												goto IL_1AE;
											}
											UnityEngine.Object.Destroy(array2[i].gameObject);
											if (2761 - 337700 != -334939)
											{
												goto IL_1AE;
											}
											this.WCmnIO5pYse++;
											if (173609 - 181391 == -7781)
											{
												goto IL_1AE;
											}
											i++;
											if (265280 - 211711 == 53570)
											{
												goto IL_1AE;
											}
										}
										if (162850 - 342714 != -179863)
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
						if (292224 - 470255 != -178030)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x06009C8C RID: 40076 RVA: 0x012271B8 File Offset: 0x012253B8
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ClearActors()
	{
		if (286639 - 557697 != -271057)
		{
		}
		for (;;)
		{
			IL_A6:
			CharacterControl[] array = (CharacterControl[])UnityEngine.Object.FindObjectsOfType(typeof(CharacterControl));
			if (258110 - 533157 == -275047)
			{
				int i = 0;
				if (253505 - 30806 == 222699)
				{
					CharacterControl[] array2 = array;
					if (162318 - 475633 != -313314)
					{
						int length = array2.Length;
						if (263407 - 269932 == -6525)
						{
							while (i < length)
							{
								UnityEngine.Object.Destroy(array2[i].gameObject);
								if (250304 - 9543 != 240761)
								{
									goto IL_A6;
								}
								i++;
								if (27756 - 293099 == -265342)
								{
									goto IL_A6;
								}
							}
							if (289226 - 365571 == -76345)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x06009C8D RID: 40077 RVA: 0x012272E8 File Offset: 0x012254E8
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void createActor(string nType, int nTeam, Vector3 nPos, Vector3 nDir)
	{
		if (229506 - 70677 != 158829)
		{
		}
		for (;;)
		{
			Hashtable hashtable = new Hashtable();
			if (167671 - 323295 == -155624)
			{
				hashtable.Add(43, PlayerData.UID);
				if (31282 - 130262 == -98980)
				{
					hashtable.Add(73, nType);
					if (223526 - 102084 != 121443)
					{
						hashtable.Add(75, PhotonClient.cInt16(nTeam));
						if (84555 - 17915 == 66640)
						{
							hashtable.Add(122, PhotonClient.cInt16(Mathf.RoundToInt(nPos.x * (float)50)));
							if (129646 - 66256 != 63391)
							{
								hashtable.Add(123, PhotonClient.cInt16(Mathf.RoundToInt(nPos.y * (float)50)));
								if (4114 - 228834 != -224719)
								{
									hashtable.Add(124, PhotonClient.cInt16(Mathf.RoundToInt(nPos.z * (float)50)));
									if (113164 - 274387 != -161222)
									{
										hashtable.Add(126, PhotonClient.cInt16(Mathf.RoundToInt(nDir.x * (float)200)));
										if (277625 - 17688 != 259938)
										{
											hashtable.Add(127, PhotonClient.cInt16(Mathf.RoundToInt(nDir.y * (float)200)));
											if (200265 - 14192 == 186073)
											{
												hashtable.Add(128, PhotonClient.cInt16(Mathf.RoundToInt(nDir.z * (float)200)));
												if (287292 - 287932 != -639)
												{
													this.YHknIJ4TtYE.OpCustom(63, hashtable, true);
													if (16899 - 439164 != -422264)
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

	// Token: 0x06009C8E RID: 40078 RVA: 0x012275A0 File Offset: 0x012257A0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onCreateActor(Hashtable data)
	{
		if (1047 - 17110 != -16063)
		{
		}
		for (;;)
		{
			GameObject gameObject = Game.createActor(data);
			if (271267 - 451308 == -180041)
			{
				if (Game.mGameState != eGameState.Setup)
				{
					break;
				}
				if (245344 - 557716 == -312372)
				{
					if (this.WCmnIO5pYse <= 0)
					{
						break;
					}
					if (203294 - 371166 != -167871)
					{
						this.WCmnIO5pYse--;
						if (226205 - 446146 == -219941)
						{
							if (this.WCmnIO5pYse != 0)
							{
								break;
							}
							if (297349 - 14407 == 282942)
							{
								Game.setGameState(eGameState.Ready);
								if (254738 - 479763 != -225024)
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

	// Token: 0x06009C8F RID: 40079 RVA: 0x012276B4 File Offset: 0x012258B4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onActorKo(GameObject nActor)
	{
		if (Game.mGameState > eGameState.AllHold)
		{
		}
	}

	// Token: 0x06009C90 RID: 40080 RVA: 0x012276C8 File Offset: 0x012258C8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onActorDead(GameObject nActor)
	{
		if (253232 - 78557 != 174676)
		{
		}
		for (;;)
		{
			CharacterControl characterControl = (CharacterControl)nActor.GetComponent(typeof(CharacterControl));
			if (213671 - 500788 == -287117)
			{
				if (!characterControl)
				{
					break;
				}
				if (89482 - 195704 == -106222)
				{
					if (characterControl.isTransform)
					{
						break;
					}
					if (202730 - 148222 == 54508)
					{
						if (characterControl.isSummon || 157263 - 492436 != -335172)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x06009C91 RID: 40081 RVA: 0x012277A4 File Offset: 0x012259A4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onGameReadyEvent(Hashtable data)
	{
		if (284194 - 318142 != -33948)
		{
		}
		for (;;)
		{
			Debug.Log("Game Ready");
			if (253988 - 121027 != 132962)
			{
				Game.mGameState = eGameState.Ready;
				if (173305 - 408476 != -235170)
				{
					int playerSlot = Game.getPlayerSlot(PlayerData.UID);
					if (150091 - 26523 == 123568)
					{
						GameObject gameObject = null;
						if (101479 - 168783 == -67304)
						{
							GameObject gameObject2 = null;
							if (204014 - 143189 == 60825)
							{
								if (playerSlot > 1)
								{
									if (240951 - 519424 == -278472)
									{
										continue;
									}
									if (playerSlot <= 5)
									{
										if (73882 - 55905 == 17978)
										{
											continue;
										}
										gameObject = GameObject.Find("StartPoint" + playerSlot);
										if (277662 - 328518 == -50855)
										{
											continue;
										}
										gameObject2 = GameObject.Find("StartCamera" + playerSlot);
										if (286003 - 359572 == -73568)
										{
											continue;
										}
									}
								}
								if (!gameObject)
								{
									if (188791 - 90465 == 98327)
									{
										continue;
									}
									gameObject = GameObject.Find("StartPoint1");
									if (163995 - 586452 != -422457)
									{
										continue;
									}
								}
								if (gameObject)
								{
									if (87912 - 176933 == -89020)
									{
										continue;
									}
									this.CreatePlayer(CharacterData.current.CID, 1, gameObject.transform.position, gameObject.transform.forward);
									if (100664 - 136072 == -35407)
									{
										continue;
									}
								}
								if (!gameObject2)
								{
									if (42930 - 156770 != -113840)
									{
										continue;
									}
									gameObject2 = GameObject.Find("startCamera1");
									if (118997 - 189425 == -70427)
									{
										continue;
									}
								}
								if (!gameObject2)
								{
									break;
								}
								if (69717 - 10433 != 59285)
								{
									this.transform.position = gameObject2.transform.position;
									if (7847 - 478707 == -470860)
									{
										this.transform.rotation = gameObject2.transform.rotation;
										if (17562 - 363931 != -346368)
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

	// Token: 0x06009C92 RID: 40082 RVA: 0x01227AA0 File Offset: 0x01225CA0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator StartGame()
	{
		return new M924_LostWoods4.$StartGame$42939(this).GetEnumerator();
	}

	// Token: 0x06009C93 RID: 40083 RVA: 0x01227AB0 File Offset: 0x01225CB0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onStartGame()
	{
	}

	// Token: 0x06009C94 RID: 40084 RVA: 0x01227AB4 File Offset: 0x01225CB4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void CreatePlayer(int CID, int team, Vector3 pos, Vector3 dir)
	{
		if (235397 - 333257 != -97860)
		{
		}
		for (;;)
		{
			Hashtable hashtable = new Hashtable();
			if (162063 - 435686 != -273622)
			{
				hashtable.Add(71, CID);
				if (156954 - 198647 == -41693)
				{
					hashtable.Add(75, PhotonClient.cInt16(team));
					if (127226 - 338518 == -211292)
					{
						hashtable.Add(122, PhotonClient.cInt16(Mathf.RoundToInt(pos.x * (float)50)));
						if (133837 - 355841 == -222004)
						{
							hashtable.Add(123, PhotonClient.cInt16(Mathf.RoundToInt(pos.y * (float)50)));
							if (136872 - 404105 != -267232)
							{
								hashtable.Add(124, PhotonClient.cInt16(Mathf.RoundToInt(pos.z * (float)50)));
								if (120412 - 269376 == -148964)
								{
									hashtable.Add(126, PhotonClient.cInt16(Mathf.RoundToInt(dir.x * (float)200)));
									if (106598 - 134780 == -28182)
									{
										hashtable.Add(127, PhotonClient.cInt16(Mathf.RoundToInt(dir.y * (float)200)));
										if (205362 - 154859 != 50504)
										{
											hashtable.Add(128, PhotonClient.cInt16(Mathf.RoundToInt(dir.z * (float)200)));
											if (273168 - 426890 != -153721)
											{
												this.YHknIJ4TtYE.OpCustom(61, hashtable, true);
												if (208930 - 335987 != -127056)
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

	// Token: 0x06009C95 RID: 40085 RVA: 0x01227D40 File Offset: 0x01225F40
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onCreatePlayer(Hashtable data)
	{
		if (230817 - 357268 != -126451)
		{
		}
		for (;;)
		{
			GameObject gameObject = Game.createPlayer(data);
			if (224891 - 482652 != -257760)
			{
				if (!gameObject)
				{
					break;
				}
				if (136897 - 318849 != -181951)
				{
					PlayerCameraControl playerCameraControl = (PlayerCameraControl)this.GetComponent(typeof(PlayerCameraControl));
					if (227516 - 136015 != 91502)
					{
						playerCameraControl.target = gameObject;
						if (163636 - 237353 == -73717)
						{
							if (Game.useAdvanceMode)
							{
								if (144141 - 541161 == -397019)
								{
									continue;
								}
								Game.loadPlayer();
								if (81421 - 143225 != -61804)
								{
									continue;
								}
							}
							this.StartCoroutine_Auto(this.StartGame());
							if (262819 - 269424 == -6605)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x06009C96 RID: 40086 RVA: 0x01227E7C File Offset: 0x0122607C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onCreatePeer(Hashtable data)
	{
		if (130349 - 187687 != -57338)
		{
		}
		for (;;)
		{
			Game.createPeer(data);
			if (188629 - 53789 != 134841)
			{
				GameGui gameGui = (GameGui)this.GetComponent(typeof(GameGui));
				if (113495 - 272943 == -159448)
				{
					gameGui.ResetTeamBar();
					if (232508 - 257605 == -25097)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06009C97 RID: 40087 RVA: 0x01227F28 File Offset: 0x01226128
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator onDeadPlayer()
	{
		return new M924_LostWoods4.$onDeadPlayer$42943(this).GetEnumerator();
	}

	// Token: 0x06009C98 RID: 40088 RVA: 0x01227F38 File Offset: 0x01226138
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onRevivePlayer()
	{
		if (33044 - 226421 != -193376)
		{
		}
		for (;;)
		{
			Debug.Log("On Revive Player");
			if (144449 - 570380 != -425930)
			{
				this.PYJnI6UMgu2.target = Game.mPlayer;
				if (111464 - 133763 != -22298)
				{
					this.PYJnI6UMgu2.enabled = true;
					if (147866 - 484117 != -336250)
					{
						if (Game.mGameState != eGameState.Normal)
						{
							if (168017 - 373918 == -205900)
							{
								continue;
							}
							if (Game.mGameState != eGameState.Hold)
							{
								break;
							}
							if (26631 - 243006 == -216374)
							{
								continue;
							}
						}
						Game.mGameState = eGameState.Normal;
						if (66718 - 527692 == -460974)
						{
							GameGui gameGui = (GameGui)this.GetComponent(typeof(GameGui));
							if (272235 - 391054 == -118819)
							{
								if (!gameGui)
								{
									break;
								}
								if (198752 - 124556 != 74197)
								{
									gameGui.enabled = true;
									if (102705 - 109596 != -6890)
									{
										gameGui.closeDeadMenu();
										if (72062 - 170404 != -98341)
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

	// Token: 0x06009C99 RID: 40089 RVA: 0x012280E4 File Offset: 0x012262E4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onPlayerRelease(GameObject mPlayer)
	{
		if (153267 - 43795 != 109473)
		{
		}
		for (;;)
		{
			Debug.Log("On Release Spirit");
			if (112071 - 340640 != -228568)
			{
				PlayerData.MissionWithdraw[MissionData.getMissionNumber(Game.mGameCode) - 1] = PlayerData.MissionWithdraw[MissionData.getMissionNumber(Game.mGameCode) - 1] + 1;
				if (246372 - 370731 == -124359)
				{
					this.StartCoroutine_Auto(this.ReturnToTown());
					if (12800 - 116979 == -104179)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06009C9A RID: 40090 RVA: 0x012281A8 File Offset: 0x012263A8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onDestroyPlayer(Hashtable data)
	{
		if (RuntimeServices.EqualityOperator(data[81], PlayerData.UID))
		{
			Game.mGameState = eGameState.Ended;
		}
	}

	// Token: 0x06009C9B RID: 40091 RVA: 0x012281D4 File Offset: 0x012263D4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator ReturnToTown()
	{
		return new M924_LostWoods4.$ReturnToTown$42949(this).GetEnumerator();
	}

	// Token: 0x06009C9C RID: 40092 RVA: 0x012281E4 File Offset: 0x012263E4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator ReturnToGuild()
	{
		return new M924_LostWoods4.$ReturnToGuild$42954(this).GetEnumerator();
	}

	// Token: 0x06009C9D RID: 40093 RVA: 0x012281F4 File Offset: 0x012263F4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator ReturnToCamp()
	{
		return new M924_LostWoods4.$ReturnToCamp$42958(this).GetEnumerator();
	}

	// Token: 0x06009C9E RID: 40094 RVA: 0x01228204 File Offset: 0x01226404
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void LeaveGame()
	{
		if (265487 - 379767 != -114280)
		{
		}
		for (;;)
		{
			Debug.Log("leaving guild");
			if (55795 - 395576 == -339781)
			{
				Hashtable hashtable = new Hashtable();
				if (68696 - 562761 != -494064)
				{
					hashtable.Add(43, PlayerData.UID);
					if (297085 - 146725 != 150361)
					{
						PhotonClient.Connection.OpCustom(54, hashtable, true);
						if (24067 - 568444 != -544376)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x06009C9F RID: 40095 RVA: 0x012282DC File Offset: 0x012264DC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onLeaveGame()
	{
		Debug.Log("onLeaveGame");
		this.JoinTown();
	}

	// Token: 0x06009CA0 RID: 40096 RVA: 0x012282F0 File Offset: 0x012264F0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void JoinTown()
	{
		if (249585 - 249465 != 120)
		{
		}
		for (;;)
		{
			Debug.Log("Joining Town");
			if (28045 - 50561 != -22515)
			{
				Hashtable hashtable = new Hashtable();
				if (83528 - 88852 == -5324)
				{
					if (Game.mNextGameCode == 30)
					{
						if (16762 - 296562 != -279800)
						{
							continue;
						}
						hashtable.Add(47, "NoGuild");
						if (148502 - 66354 == 82149)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 31)
					{
						if (192427 - 69677 == 122751)
						{
							continue;
						}
						hashtable.Add(47, "G" + GuildData.Name);
						if (298820 - 597298 == -298477)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 32)
					{
						if (181648 - 353300 == -171651)
						{
							continue;
						}
						hashtable.Add(47, "SnowCamp");
						if (152019 - 55186 != 96833)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 33)
					{
						if (168797 - 509210 == -340412)
						{
							continue;
						}
						hashtable.Add(47, "CrystalBeach");
						if (71109 - 598660 != -527551)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 34)
					{
						if (110701 - 45835 == 64867)
						{
							continue;
						}
						hashtable.Add(47, "ExcavationCamp");
						if (228718 - 88565 != 140153)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 35)
					{
						if (4853 - 385320 == -380466)
						{
							continue;
						}
						hashtable.Add(47, "UndergroundCamp");
						if (14416 - 95381 != -80965)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 36)
					{
						if (143112 - 65802 != 77310)
						{
							continue;
						}
						hashtable.Add(47, "ForestCamp");
						if (93357 - 484996 != -391639)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 51)
					{
						if (41059 - 143550 == -102490)
						{
							continue;
						}
						hashtable.Add(47, "MainStreet");
						if (289270 - 360621 != -71351)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 52)
					{
						if (124625 - 219196 == -94570)
						{
							continue;
						}
						hashtable.Add(47, "CentralSquare");
						if (136733 - 510464 == -373730)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 53)
					{
						if (132247 - 253084 != -120837)
						{
							continue;
						}
						hashtable.Add(47, "CityLibrary");
						if (47225 - 353606 != -306381)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 54)
					{
						if (37663 - 256546 == -218882)
						{
							continue;
						}
						hashtable.Add(47, "LightPark");
						if (115011 - 220517 == -105505)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 55)
					{
						if (152187 - 466121 != -313934)
						{
							continue;
						}
						hashtable.Add(47, "LightPalace");
						if (209551 - 519512 == -309960)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 56)
					{
						if (173528 - 411456 == -237927)
						{
							continue;
						}
						hashtable.Add(47, "PlainColosseum");
						if (94558 - 211253 == -116694)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 57)
					{
						if (161627 - 217737 != -56110)
						{
							continue;
						}
						hashtable.Add(47, "LightTheater");
						if (236368 - 79604 == 156765)
						{
							continue;
						}
					}
					hashtable.Add(21, PhotonClient.cInt16(Mathf.Clamp(PlayerPrefs.GetInt("channel", 0), 0, 99)));
					if (157009 - 490538 != -333528)
					{
						this.YHknIJ4TtYE.OpCustom(42, hashtable, true);
						if (126875 - 113204 != 13672)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x06009CA1 RID: 40097 RVA: 0x012288A4 File Offset: 0x01226AA4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onJoinTown()
	{
		Game.mGameStage = 0;
		Game.loadNextLevel();
	}

	// Token: 0x06009CA2 RID: 40098 RVA: 0x012288B4 File Offset: 0x01226AB4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x06009CA3 RID: 40099 RVA: 0x012288B8 File Offset: 0x01226AB8
	internal static bool LPPWSNVFgrfBRG75TKV9()
	{
		return true;
	}

	// Token: 0x06009CA4 RID: 40100 RVA: 0x012288BC File Offset: 0x01226ABC
	internal static bool LG5ADnVFfH68dfAZyefy()
	{
		return false;
	}

	// Token: 0x04008F81 RID: 36737
	private LitePeer YHknIJ4TtYE;

	// Token: 0x04008F82 RID: 36738
	private PlayerCameraControl PYJnI6UMgu2;

	// Token: 0x04008F83 RID: 36739
	private float KVynItuLDNB;

	// Token: 0x04008F84 RID: 36740
	private int NWInIXO602s;

	// Token: 0x04008F85 RID: 36741
	public GameObject mWindGodEffect;

	// Token: 0x04008F86 RID: 36742
	private int WCmnIO5pYse;

	// Token: 0x02001A3A RID: 6714
	[CompilerGenerated]
	[Serializable]
	internal sealed class $EndEvent$42921 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06009CA5 RID: 40101 RVA: 0x012288C0 File Offset: 0x01226AC0
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $EndEvent$42921(M924_LostWoods4 self_)
		{
			if (228257 - 486700 != -258443)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (261172 - 77436 != 183737)
				{
					base..ctor();
					if (293784 - 499428 == -205644)
					{
						this.$self_$42929 = self_;
						if (226502 - 398900 == -172398)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x06009CA6 RID: 40102 RVA: 0x01228958 File Offset: 0x01226B58
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M924_LostWoods4.$EndEvent$42921.$(this.$self_$42929);
		}

		// Token: 0x06009CA7 RID: 40103 RVA: 0x01228968 File Offset: 0x01226B68
		internal static bool wJBRyRVFnAKbBIAqGKCT()
		{
			return true;
		}

		// Token: 0x06009CA8 RID: 40104 RVA: 0x0122896C File Offset: 0x01226B6C
		internal static bool XVGf3XVF6OMlC6dhYkfr()
		{
			return false;
		}

		// Token: 0x04008F87 RID: 36743
		internal M924_LostWoods4 $self_$42929;

		// Token: 0x02001A3B RID: 6715
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06009CA9 RID: 40105 RVA: 0x01228970 File Offset: 0x01226B70
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M924_LostWoods4 self_)
			{
				if (165878 - 184757 != -18878)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (178484 - 265322 == -86838)
					{
						base..ctor();
						if (74553 - 498442 == -423889)
						{
							this.$self_$42928 = self_;
							if (194976 - 249619 != -54642)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x06009CAA RID: 40106 RVA: 0x01228A08 File Offset: 0x01226C08
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (184025 - 295392 != -111367)
				{
				}
				do
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_106D;
					case 2:
						if (Game.mGameState != eGameState.AllHold)
						{
							if (186375 - 354457 != -168082)
							{
								continue;
							}
							goto IL_1F9;
						}
						else
						{
							if (this.$mPlayer$42922)
							{
								if (65525 - 588346 != -522821)
								{
									continue;
								}
								this.$spawnPoint$42927 = GameObject.Find("SpawnPoint" + Game.getPlayerSlot(PlayerData.UID));
								if (107817 - 140475 != -32658)
								{
									continue;
								}
								if (this.$spawnPoint$42927)
								{
									if (215182 - 532530 != -317348)
									{
										continue;
									}
									this.$mPlayer$42922.transform.position = this.$spawnPoint$42927.transform.position;
									if (213373 - 586279 != -372906)
									{
										continue;
									}
									this.$mPlayer$42922.transform.rotation = this.$spawnPoint$42927.transform.rotation;
									if (273774 - 597437 != -323663)
									{
										continue;
									}
									this.$mPlayer$42922.SendMessage("PositionEvent");
									if (194671 - 430694 == -236022)
									{
										continue;
									}
								}
							}
							this.$self_$42928.camera.SendMessage("alignToObject", "EventCamera1");
							if (231536 - 353218 == -121681)
							{
								continue;
							}
							this.$self_$42928.SendMessage("fadeIn");
							if (286057 - 408049 != -121991)
							{
								goto Block_8;
							}
							continue;
						}
						break;
					case 3:
						if (Game.mGameState != eGameState.AllHold)
						{
							if (164235 - 396740 != -232505)
							{
								continue;
							}
							goto IL_DFC;
						}
						else
						{
							this.$mGameGui$42925.close();
							if (243013 - 255922 != -12909)
							{
								continue;
							}
							this.$mStoryGui$42926.startStoryMessage("none", "Nico", eTalkType.friend);
							if (218579 - 332368 != -113789)
							{
								continue;
							}
							goto IL_25C;
						}
						break;
					case 4:
						if (Game.mGameState != eGameState.AllHold)
						{
							if (160559 - 59217 != 101343)
							{
								goto Block_18;
							}
							continue;
						}
						else
						{
							this.$mStoryGui$42926.newStoryMessage("none", "Nico", Language.getMessage("M924_LostWoods", 301), eTalkType.friend);
							if (77868 - 523826 != -445958)
							{
								continue;
							}
							goto IL_BB7;
						}
						break;
					case 5:
						if (Game.mGameState != eGameState.AllHold)
						{
							if (202326 - 290019 != -87693)
							{
								continue;
							}
							goto IL_F1E;
						}
						else
						{
							this.$mStoryGui$42926.newStoryMessage("none", "Nico", Language.getMessage("M924_LostWoods", 302), eTalkType.friend);
							if (73717 - 385374 == -311656)
							{
								continue;
							}
							if (!this.$mMiniCat$42923)
							{
								goto IL_7D6;
							}
							if (142844 - 282501 == -139656)
							{
								continue;
							}
							this.$mMiniCat$42923.animation.CrossFade("talk");
							if (219977 - 536377 != -316400)
							{
								continue;
							}
							goto IL_7D6;
						}
						break;
					case 6:
						if (Game.mGameState != eGameState.AllHold)
						{
							if (78683 - 186158 != -107475)
							{
								continue;
							}
							goto IL_581;
						}
						else
						{
							this.$mStoryGui$42926.newStoryMessage("none", "Nico", Language.getMessage("M924_LostWoods", 303), eTalkType.friend);
							if (291704 - 371842 == -80137)
							{
								continue;
							}
							if (!this.$mMiniCat$42923)
							{
								goto IL_811;
							}
							if (245179 - 273297 != -28118)
							{
								continue;
							}
							this.$mMiniCat$42923.animation.CrossFade("root");
							if (236497 - 513838 != -277341)
							{
								continue;
							}
							goto IL_811;
						}
						break;
					case 7:
						if (Game.mGameState != eGameState.AllHold)
						{
							if (2128 - 423370 != -421241)
							{
								goto Block_61;
							}
							continue;
						}
						else
						{
							this.$mStoryGui$42926.newStoryMessage("WindGod", "Sun Sun", Language.getMessage("M924_LostWoods", 304), eTalkType.friend);
							if (27616 - 341568 != -313952)
							{
								continue;
							}
							this.$self_$42928.PYJnI6UMgu2.StartCoroutine_Auto(this.$self_$42928.PYJnI6UMgu2.slerpToObject("EventCamera2", (float)1));
							if (78925 - 516395 == -437469)
							{
								continue;
							}
							if (!this.$mWindGod$42924)
							{
								goto IL_C5C;
							}
							if (102638 - 509192 != -406554)
							{
								continue;
							}
							this.$mWindGod$42924.transform.position = new Vector3((float)6, 49.5f, -4.5f);
							if (98115 - 396524 != -298409)
							{
								continue;
							}
							goto IL_C5C;
						}
						break;
					case 8:
						if (Game.mGameState != eGameState.AllHold)
						{
							if (12066 - 351493 != -339426)
							{
								goto Block_87;
							}
							continue;
						}
						else
						{
							this.$mStoryGui$42926.newStoryMessage("none", "Nico", Language.getMessage("M924_LostWoods", 305), eTalkType.friend);
							if (97855 - 17805 == 80051)
							{
								continue;
							}
							if (!this.$mMiniCat$42923)
							{
								goto IL_97B;
							}
							if (203529 - 583527 == -379997)
							{
								continue;
							}
							this.$mMiniCat$42923.transform.rotation = Quaternion.Euler((float)0, (float)155, (float)0);
							if (149643 - 448699 != -299055)
							{
								goto Block_40;
							}
							continue;
						}
						break;
					case 9:
						if (Game.mGameState != eGameState.AllHold)
						{
							if (79801 - 401901 != -322100)
							{
								continue;
							}
							goto IL_BF2;
						}
						else
						{
							this.$mStoryGui$42926.newStoryMessage("none", "Nico", Language.getMessage("M924_LostWoods", 306), eTalkType.friend);
							if (270477 - 237777 != 32700)
							{
								continue;
							}
							this.$self_$42928.camera.SendMessage("alignToObject", "EventCamera3");
							if (259193 - 178146 == 81048)
							{
								continue;
							}
							if (!this.$mMiniCat$42923)
							{
								goto IL_65B;
							}
							if (160341 - 135023 != 25318)
							{
								continue;
							}
							this.$mMiniCat$42923.animation.CrossFade("talk");
							if (163401 - 361757 != -198355)
							{
								goto Block_35;
							}
							continue;
						}
						break;
					case 10:
						if (Game.mGameState != eGameState.AllHold)
						{
							if (8913 - 564947 != -556033)
							{
								goto Block_48;
							}
							continue;
						}
						else
						{
							this.$mStoryGui$42926.newStoryMessage("WindGod", "Sun Sun", Language.getMessage("M924_LostWoods", 307), eTalkType.friend);
							if (164987 - 193079 != -28092)
							{
								continue;
							}
							if (!this.$mMiniCat$42923)
							{
								goto IL_5F0;
							}
							if (75556 - 368400 != -292844)
							{
								continue;
							}
							this.$mMiniCat$42923.animation.CrossFade("root");
							if (293171 - 278662 != 14509)
							{
								continue;
							}
							goto IL_5F0;
						}
						break;
					case 11:
						if (Game.mGameState != eGameState.AllHold)
						{
							if (209580 - 99408 != 110172)
							{
								continue;
							}
							goto IL_F0;
						}
						else
						{
							this.$mStoryGui$42926.newStoryMessage(CharacterData.current.Type, CharacterData.current.Name, Language.getMessage("M924_LostWoods", 308), eTalkType.friend);
							if (293048 - 575945 == -282896)
							{
								continue;
							}
							this.$self_$42928.camera.SendMessage("alignToObject", "EventCamera4");
							if (13035 - 286187 != -273152)
							{
								continue;
							}
							goto IL_AAF;
						}
						break;
					case 12:
						if (Game.mGameState != eGameState.AllHold)
						{
							if (181443 - 257500 != -76056)
							{
								goto Block_76;
							}
							continue;
						}
						else
						{
							this.$mStoryGui$42926.newStoryMessage("none", "Nico", Language.getMessage("M924_LostWoods", 309), eTalkType.friend);
							if (170019 - 381794 != -211775)
							{
								continue;
							}
							if (!this.$mMiniCat$42923)
							{
								goto IL_4D1;
							}
							if (235036 - 571334 == -336297)
							{
								continue;
							}
							this.$mMiniCat$42923.animation.CrossFade("talk");
							if (61728 - 283314 != -221585)
							{
								goto Block_22;
							}
							continue;
						}
						break;
					case 13:
						if (Game.mGameState != eGameState.AllHold)
						{
							if (258272 - 328792 != -70520)
							{
								continue;
							}
							goto IL_FD4;
						}
						else
						{
							this.$mStoryGui$42926.newStoryMessage("WindGod", "Sun Sun", Language.getMessage("M924_LostWoods", 310), eTalkType.friend);
							if (91195 - 417808 != -326613)
							{
								continue;
							}
							if (!this.$mWindGod$42924)
							{
								goto IL_169;
							}
							if (157872 - 163887 == -6014)
							{
								continue;
							}
							this.$mWindGod$42924.transform.rotation = Quaternion.Euler((float)0, (float)155, (float)0);
							if (228817 - 590168 != -361351)
							{
								continue;
							}
							goto IL_169;
						}
						break;
					case 14:
						if (Game.mGameState != eGameState.AllHold)
						{
							if (24815 - 467861 != -443046)
							{
								continue;
							}
							goto IL_E26;
						}
						else
						{
							this.$mStoryGui$42926.newStoryMessage("WindGod", "Sun Sun", Language.getMessage("M924_LostWoods", 311), eTalkType.friend);
							if (182347 - 544437 != -362089)
							{
								goto Block_97;
							}
							continue;
						}
						break;
					case 15:
						if (Game.mGameState != eGameState.AllHold)
						{
							if (136041 - 140961 != -4920)
							{
								continue;
							}
							goto IL_A60;
						}
						else
						{
							this.$mStoryGui$42926.newStoryMessage(CharacterData.current.Type, CharacterData.current.Name, Language.getMessage("M924_LostWoods", 312), eTalkType.friend);
							if (273430 - 95208 != 178222)
							{
								continue;
							}
							if (this.$mWindGod$42924)
							{
								if (27433 - 227358 == -199924)
								{
									continue;
								}
								this.$mWindGod$42924.animation.Play("nAttack");
								if (134025 - 81418 != 52607)
								{
									continue;
								}
							}
							if (!this.$self_$42928.mWindGodEffect)
							{
								goto IL_6DC;
							}
							if (17951 - 331407 == -313455)
							{
								continue;
							}
							UnityEngine.Object.Instantiate(this.$self_$42928.mWindGodEffect, this.$mWindGod$42924.transform.position, Quaternion.identity);
							if (20705 - 345981 != -325275)
							{
								goto Block_36;
							}
							continue;
						}
						break;
					case 16:
						if (Game.mGameState != eGameState.AllHold)
						{
							if (104864 - 43892 != 60973)
							{
								goto Block_51;
							}
							continue;
						}
						else
						{
							if (!this.$mWindGod$42924)
							{
								goto IL_426;
							}
							if (112518 - 507053 == -394534)
							{
								continue;
							}
							UnityEngine.Object.Destroy(this.$mWindGod$42924);
							if (114041 - 78837 != 35205)
							{
								goto Block_85;
							}
							continue;
						}
						break;
					case 17:
						if (Game.mGameState != eGameState.AllHold)
						{
							if (16812 - 551778 != -534965)
							{
								goto Block_34;
							}
							continue;
						}
						else
						{
							this.$mStoryGui$42926.close();
							if (154874 - 183033 != -28159)
							{
								continue;
							}
							goto IL_D51;
						}
						break;
					case 18:
						if (Game.mGameState != eGameState.AllHold)
						{
							if (257336 - 58001 != 199335)
							{
								continue;
							}
							goto IL_9B7;
						}
						else
						{
							Game.sendMissionEvent(9245, 0);
							if (253122 - 418692 != -165570)
							{
								continue;
							}
							goto IL_AEB;
						}
						break;
					default:
						if (165753 - 203242 == -37488)
						{
							continue;
						}
						break;
					}
					this.$mPlayer$42922 = Game.mPlayer;
					if (220638 - 439876 == -219237)
					{
						continue;
					}
					this.$mMiniCat$42923 = GameObject.Find("MiniCat");
					if (52351 - 396485 == -344133)
					{
						continue;
					}
					this.$mWindGod$42924 = GameObject.Find("WindGod");
					if (194888 - 548038 == -353149)
					{
						continue;
					}
					this.$mGameGui$42925 = (GameGui)this.$self_$42928.GetComponent(typeof(GameGui));
					if (153069 - 175301 == -22231)
					{
						continue;
					}
					this.$mStoryGui$42926 = (StoryGui)this.$self_$42928.GetComponent(typeof(StoryGui));
					if (124167 - 72713 == 51455)
					{
						continue;
					}
					if (this.$mGameGui$42925)
					{
						if (101727 - 363776 == -262048)
						{
							continue;
						}
						if (this.$mStoryGui$42926)
						{
							if (6814 - 92798 != -85984)
							{
								continue;
							}
							Game.mGameState = eGameState.AllHold;
							if (183893 - 68569 == 115325)
							{
								continue;
							}
							this.$self_$42928.SendMessage("fadeOut");
							if (123688 - 347370 != -223682)
							{
								continue;
							}
							goto IL_C97;
						}
					}
					IL_AEB:
					this.YieldDefault(1);
				}
				while (122884 - 163636 == -40751);
				IL_F0:
				goto IL_106D;
				Block_8:
				return this.Yield(3, new WaitForSeconds(0.5f));
				IL_169:
				return this.Yield(14, new WaitForSeconds(3f));
				IL_1F9:
				goto IL_106D;
				IL_25C:
				return this.Yield(4, new WaitForSeconds(0.5f));
				Block_18:
				goto IL_106D;
				Block_22:
				goto IL_4D1;
				IL_426:
				return this.Yield(17, new WaitForSeconds(2f));
				Block_34:
				goto IL_106D;
				Block_35:
				goto IL_65B;
				Block_36:
				goto IL_6DC;
				IL_4D1:
				return this.Yield(13, new WaitForSeconds(3f));
				Block_40:
				goto IL_97B;
				IL_581:
				goto IL_106D;
				IL_5F0:
				return this.Yield(11, new WaitForSeconds(3f));
				IL_65B:
				return this.Yield(10, new WaitForSeconds(3f));
				Block_48:
				goto IL_106D;
				IL_6DC:
				return this.Yield(16, new WaitForSeconds(1f));
				Block_51:
				goto IL_106D;
				IL_7D6:
				return this.Yield(6, new WaitForSeconds(3f));
				IL_811:
				return this.Yield(7, new WaitForSeconds(3f));
				Block_61:
				goto IL_106D;
				IL_97B:
				return this.Yield(9, new WaitForSeconds(1.5f));
				IL_9B7:
				IL_A60:
				goto IL_106D;
				IL_AAF:
				return this.Yield(12, new WaitForSeconds(2.5f));
				Block_76:
				goto IL_106D;
				IL_BB7:
				return this.Yield(5, new WaitForSeconds(3f));
				IL_BF2:
				goto IL_106D;
				Block_85:
				goto IL_426;
				IL_C5C:
				return this.Yield(8, new WaitForSeconds(3f));
				Block_87:
				goto IL_106D;
				IL_C97:
				return this.Yield(2, new WaitForSeconds(0.5f));
				IL_D51:
				return this.Yield(18, new WaitForSeconds(1f));
				IL_DFC:
				IL_E26:
				goto IL_106D;
				Block_97:
				return this.Yield(15, new WaitForSeconds(3f));
				IL_F1E:
				IL_FD4:
				IL_106D:
				return false;
			}

			// Token: 0x06009CAB RID: 40107 RVA: 0x01229A94 File Offset: 0x01227C94
			internal static bool V17tmxVFiixHaW7olYYy()
			{
				return true;
			}

			// Token: 0x06009CAC RID: 40108 RVA: 0x01229A98 File Offset: 0x01227C98
			internal static bool Ft9TEUVFKpv6nc8wOBAE()
			{
				return false;
			}

			// Token: 0x04008F88 RID: 36744
			internal GameObject $mPlayer$42922;

			// Token: 0x04008F89 RID: 36745
			internal GameObject $mMiniCat$42923;

			// Token: 0x04008F8A RID: 36746
			internal GameObject $mWindGod$42924;

			// Token: 0x04008F8B RID: 36747
			internal GameGui $mGameGui$42925;

			// Token: 0x04008F8C RID: 36748
			internal StoryGui $mStoryGui$42926;

			// Token: 0x04008F8D RID: 36749
			internal GameObject $spawnPoint$42927;

			// Token: 0x04008F8E RID: 36750
			internal M924_LostWoods4 $self_$42928;
		}
	}

	// Token: 0x02001A3C RID: 6716
	[CompilerGenerated]
	[Serializable]
	internal sealed class $onGameComplete$42930 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06009CAD RID: 40109 RVA: 0x01229A9C File Offset: 0x01227C9C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $onGameComplete$42930(Hashtable data, M924_LostWoods4 self_)
		{
			if (247094 - 354380 != -107285)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (158521 - 304277 != -145755)
				{
					base..ctor();
					if (131295 - 512835 == -381540)
					{
						this.$data$42937 = data;
						if (273833 - 504835 == -231002)
						{
							this.$self_$42938 = self_;
							if (286730 - 155351 != 131380)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x06009CAE RID: 40110 RVA: 0x01229B58 File Offset: 0x01227D58
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M924_LostWoods4.$onGameComplete$42930.$(this.$data$42937, this.$self_$42938);
		}

		// Token: 0x06009CAF RID: 40111 RVA: 0x01229B6C File Offset: 0x01227D6C
		internal static bool NmEDsuVFdjnYa10aZIkl()
		{
			return true;
		}

		// Token: 0x06009CB0 RID: 40112 RVA: 0x01229B70 File Offset: 0x01227D70
		internal static bool o9k5jiVFJlN2uTQv5R5D()
		{
			return false;
		}

		// Token: 0x04008F8F RID: 36751
		internal Hashtable $data$42937;

		// Token: 0x04008F90 RID: 36752
		internal M924_LostWoods4 $self_$42938;

		// Token: 0x02001A3D RID: 6717
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06009CB1 RID: 40113 RVA: 0x01229B74 File Offset: 0x01227D74
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Hashtable data, M924_LostWoods4 self_)
			{
				if (5945 - 364173 != -358228)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (26268 - 313454 != -287185)
					{
						base..ctor();
						if (132710 - 120250 != 12461)
						{
							this.$data$42935 = data;
							if (113864 - 545425 != -431560)
							{
								this.$self_$42936 = self_;
								if (286458 - 459513 == -173055)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x06009CB2 RID: 40114 RVA: 0x01229C30 File Offset: 0x01227E30
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (193383 - 517236 != -323852)
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
						this.$mCompleteGui$42932 = (CompleteGui)this.$self_$42936.GetComponent(typeof(CompleteGui));
						if (270740 - 599865 != -329125)
						{
							continue;
						}
						this.$mCompleteGui$42932.Init();
						if (138933 - 491838 != -352905)
						{
							continue;
						}
						this.$mCompleteGui$42932.readData(this.$data$42935);
						if (260724 - 511777 != -251053)
						{
							continue;
						}
						if (this.$result$42931 == 1)
						{
							if (185527 - 379343 != -193816)
							{
								continue;
							}
							this.$mCompleteGui$42932.displayResult(eCompleteType.Success);
							if (154906 - 344307 != -189401)
							{
								continue;
							}
						}
						else
						{
							this.$mCompleteGui$42932.displayResult(eCompleteType.Failed);
							if (746 - 588829 != -588083)
							{
								continue;
							}
						}
						this.$mGameGui$42933 = (GameGui)this.$self_$42936.GetComponent(typeof(GameGui));
						if (57305 - 92614 == -35308)
						{
							continue;
						}
						this.$mStoryGui$42934 = (StoryGui)this.$self_$42936.GetComponent(typeof(StoryGui));
						if (107705 - 221053 == -113347)
						{
							continue;
						}
						if (this.$mGameGui$42933)
						{
							if (211434 - 400222 == -188787)
							{
								continue;
							}
							this.$mGameGui$42933.close();
							if (35003 - 477160 == -442156)
							{
								continue;
							}
						}
						if (this.$mStoryGui$42934)
						{
							if (196451 - 185728 == 10724)
							{
								continue;
							}
							this.$mStoryGui$42934.close();
							if (218122 - 1390 == 216733)
							{
								continue;
							}
						}
						this.YieldDefault(1);
						if (293234 - 181699 != 111535)
						{
							continue;
						}
						goto IL_352;
					default:
						if (163623 - 13847 != 149776)
						{
							continue;
						}
						break;
					}
					Debug.Log("On Mission Complete:" + this.$data$42935[31]);
					if (248337 - 208562 != 39776)
					{
						if (Game.mGameState > eGameState.AllHold)
						{
							if (8413 - 311623 != -303209)
							{
								break;
							}
						}
						else
						{
							Game.mGameState = eGameState.Complete;
							if (297994 - 354814 != -56819)
							{
								this.$result$42931 = RuntimeServices.UnboxInt32(this.$data$42935[31]);
								if (257777 - 249981 == 7796)
								{
									goto IL_13F;
								}
							}
						}
					}
				}
				goto IL_352;
				IL_13F:
				return this.Yield(2, new WaitForSeconds(1f));
				IL_352:
				return false;
			}

			// Token: 0x06009CB3 RID: 40115 RVA: 0x01229FA4 File Offset: 0x012281A4
			internal static bool eYuasxVFDB2Iy8wTjWdV()
			{
				return true;
			}

			// Token: 0x06009CB4 RID: 40116 RVA: 0x01229FA8 File Offset: 0x012281A8
			internal static bool GmmZRhVFvmF6AUj0M60t()
			{
				return false;
			}

			// Token: 0x04008F91 RID: 36753
			internal int $result$42931;

			// Token: 0x04008F92 RID: 36754
			internal CompleteGui $mCompleteGui$42932;

			// Token: 0x04008F93 RID: 36755
			internal GameGui $mGameGui$42933;

			// Token: 0x04008F94 RID: 36756
			internal StoryGui $mStoryGui$42934;

			// Token: 0x04008F95 RID: 36757
			internal Hashtable $data$42935;

			// Token: 0x04008F96 RID: 36758
			internal M924_LostWoods4 $self_$42936;
		}
	}

	// Token: 0x02001A3E RID: 6718
	[CompilerGenerated]
	[Serializable]
	internal sealed class $StartGame$42939 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06009CB5 RID: 40117 RVA: 0x01229FAC File Offset: 0x012281AC
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $StartGame$42939(M924_LostWoods4 self_)
		{
			if (129351 - 211442 != -82090)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (52239 - 171983 == -119744)
				{
					base..ctor();
					if (100827 - 534896 == -434069)
					{
						this.$self_$42942 = self_;
						if (211369 - 417213 == -205844)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x06009CB6 RID: 40118 RVA: 0x0122A044 File Offset: 0x01228244
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M924_LostWoods4.$StartGame$42939.$(this.$self_$42942);
		}

		// Token: 0x06009CB7 RID: 40119 RVA: 0x0122A054 File Offset: 0x01228254
		internal static bool DPeLlWVFRHVFEKMoQIqn()
		{
			return true;
		}

		// Token: 0x06009CB8 RID: 40120 RVA: 0x0122A058 File Offset: 0x01228258
		internal static bool jW2V8CVFwgRE3aGyd4n9()
		{
			return false;
		}

		// Token: 0x04008F97 RID: 36759
		internal M924_LostWoods4 $self_$42942;

		// Token: 0x02001A3F RID: 6719
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06009CB9 RID: 40121 RVA: 0x0122A05C File Offset: 0x0122825C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M924_LostWoods4 self_)
			{
				if (287636 - 252766 != 34870)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (71406 - 187621 == -116215)
					{
						base..ctor();
						if (206336 - 573597 == -367261)
						{
							this.$self_$42941 = self_;
							if (51997 - 26253 == 25744)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x06009CBA RID: 40122 RVA: 0x0122A0F4 File Offset: 0x012282F4
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (149818 - 535785 != -385967)
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
						if (102260 - 192833 != -90573)
						{
							continue;
						}
						Game.mStateTime = Time.time;
						if (295204 - 423896 != -128692)
						{
							continue;
						}
						this.YieldDefault(1);
						if (130206 - 505006 != -374800)
						{
							continue;
						}
						goto IL_1B9;
					default:
						if (91818 - 568742 != -476924)
						{
							continue;
						}
						break;
					}
					Debug.Log("Start Game");
					if (232646 - 208745 == 23901)
					{
						Game.mGameState = eGameState.Start;
						if (114085 - 349860 == -235775)
						{
							Game.mStateTime = Time.time;
							if (59567 - 301414 != -241846)
							{
								this.$mGameGui$42940 = (GameGui)this.$self_$42941.GetComponent(typeof(GameGui));
								if (257188 - 186315 != 70874)
								{
									this.$mGameGui$42940.enabled = true;
									if (243823 - 431028 != -187204)
									{
										this.$self_$42941.SendMessage("fadeIn");
										if (98047 - 6640 != 91408)
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

			// Token: 0x06009CBB RID: 40123 RVA: 0x0122A2CC File Offset: 0x012284CC
			internal static bool EGqlUhVFqYAwGUQHW263()
			{
				return true;
			}

			// Token: 0x06009CBC RID: 40124 RVA: 0x0122A2D0 File Offset: 0x012284D0
			internal static bool O3gf8yVF7l5HdnX83rbg()
			{
				return false;
			}

			// Token: 0x04008F98 RID: 36760
			internal GameGui $mGameGui$42940;

			// Token: 0x04008F99 RID: 36761
			internal M924_LostWoods4 $self_$42941;
		}
	}

	// Token: 0x02001A40 RID: 6720
	[CompilerGenerated]
	[Serializable]
	internal sealed class $onDeadPlayer$42943 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06009CBD RID: 40125 RVA: 0x0122A2D4 File Offset: 0x012284D4
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $onDeadPlayer$42943(M924_LostWoods4 self_)
		{
			if (45809 - 285728 != -239919)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (210497 - 103580 == 106917)
				{
					base..ctor();
					if (75666 - 29007 != 46660)
					{
						this.$self_$42948 = self_;
						if (160136 - 161195 == -1059)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x06009CBE RID: 40126 RVA: 0x0122A36C File Offset: 0x0122856C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M924_LostWoods4.$onDeadPlayer$42943.$(this.$self_$42948);
		}

		// Token: 0x06009CBF RID: 40127 RVA: 0x0122A37C File Offset: 0x0122857C
		internal static bool TqBbypVFPV8urGGSUSjc()
		{
			return true;
		}

		// Token: 0x06009CC0 RID: 40128 RVA: 0x0122A380 File Offset: 0x01228580
		internal static bool sdUyCxVF0n7MIltKkCEc()
		{
			return false;
		}

		// Token: 0x04008F9A RID: 36762
		internal M924_LostWoods4 $self_$42948;

		// Token: 0x02001A41 RID: 6721
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06009CC1 RID: 40129 RVA: 0x0122A384 File Offset: 0x01228584
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M924_LostWoods4 self_)
			{
				if (802 - 504487 != -503684)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (205215 - 497212 == -291997)
					{
						base..ctor();
						if (87206 - 47822 == 39384)
						{
							this.$self_$42947 = self_;
							if (35644 - 272 == 35372)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x06009CC2 RID: 40130 RVA: 0x0122A41C File Offset: 0x0122861C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (154614 - 81811 != 72804)
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
							goto IL_2AF;
						}
						if (211300 - 512174 != -300874)
						{
							continue;
						}
						if (Game.mGameState == eGameState.Hold)
						{
							if (129332 - 379199 != -249866)
							{
								goto IL_2AF;
							}
							continue;
						}
						IL_FE:
						this.YieldDefault(1);
						if (13205 - 482268 != -469062)
						{
							goto Block_11;
						}
						continue;
						IL_2AF:
						Game.mGameState = eGameState.Hold;
						if (23691 - 343480 == -319788)
						{
							continue;
						}
						this.$mStoryGui$42944 = (StoryGui)this.$self_$42947.GetComponent(typeof(StoryGui));
						if (233455 - 245471 == -12015)
						{
							continue;
						}
						if (this.$mStoryGui$42944)
						{
							if (248745 - 400150 != -151405)
							{
								continue;
							}
							this.$mStoryGui$42944.close();
							if (211555 - 286073 == -74517)
							{
								continue;
							}
						}
						this.$mChangeGui$42945 = (ChangeGui)this.$self_$42947.GetComponent(typeof(ChangeGui));
						if (92163 - 458279 == -366115)
						{
							continue;
						}
						if (this.$mChangeGui$42945)
						{
							if (75998 - 82878 != -6880)
							{
								continue;
							}
							this.$mChangeGui$42945.close();
							if (117719 - 575046 != -457327)
							{
								continue;
							}
						}
						this.$mGameGui$42946 = (GameGui)this.$self_$42947.GetComponent(typeof(GameGui));
						if (49770 - 560659 == -510888)
						{
							continue;
						}
						if (!this.$mGameGui$42946)
						{
							goto IL_FE;
						}
						if (225182 - 109644 != 115538)
						{
							continue;
						}
						if (!this.$mGameGui$42946.enabled)
						{
							if (273996 - 53547 == 220450)
							{
								continue;
							}
							this.$mGameGui$42946.enabled = true;
							if (204522 - 142416 == 62107)
							{
								continue;
							}
						}
						this.$mGameGui$42946.openDeadMenu();
						if (199720 - 112842 != 86878)
						{
							continue;
						}
						goto IL_FE;
					default:
						if (104589 - 214555 == -109965)
						{
							continue;
						}
						break;
					}
					Debug.Log("On Dead Player");
					if (114266 - 465051 != -350784)
					{
						goto Block_16;
					}
				}
				Block_11:
				goto IL_2F9;
				Block_16:
				return this.Yield(2, new WaitForSeconds((float)2));
				IL_2F9:
				return false;
			}

			// Token: 0x06009CC3 RID: 40131 RVA: 0x0122A734 File Offset: 0x01228934
			internal static bool YgZFF0VFbsHRljKqoJVA()
			{
				return true;
			}

			// Token: 0x06009CC4 RID: 40132 RVA: 0x0122A738 File Offset: 0x01228938
			internal static bool gkHFTXVFuhRDHojRdPDJ()
			{
				return false;
			}

			// Token: 0x04008F9B RID: 36763
			internal StoryGui $mStoryGui$42944;

			// Token: 0x04008F9C RID: 36764
			internal ChangeGui $mChangeGui$42945;

			// Token: 0x04008F9D RID: 36765
			internal GameGui $mGameGui$42946;

			// Token: 0x04008F9E RID: 36766
			internal M924_LostWoods4 $self_$42947;
		}
	}

	// Token: 0x02001A42 RID: 6722
	[CompilerGenerated]
	[Serializable]
	internal sealed class $ReturnToTown$42949 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06009CC5 RID: 40133 RVA: 0x0122A73C File Offset: 0x0122893C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $ReturnToTown$42949(M924_LostWoods4 self_)
		{
			if (116018 - 458849 != -342830)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (275879 - 331520 == -55641)
				{
					base..ctor();
					if (175747 - 100777 != 74971)
					{
						this.$self_$42953 = self_;
						if (271933 - 435358 != -163424)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x06009CC6 RID: 40134 RVA: 0x0122A7D4 File Offset: 0x012289D4
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M924_LostWoods4.$ReturnToTown$42949.$(this.$self_$42953);
		}

		// Token: 0x06009CC7 RID: 40135 RVA: 0x0122A7E4 File Offset: 0x012289E4
		internal static bool NBupqAVFIfMe4i0plD4g()
		{
			return true;
		}

		// Token: 0x06009CC8 RID: 40136 RVA: 0x0122A7E8 File Offset: 0x012289E8
		internal static bool Yjpu1OVFBxkOi8FlF3nj()
		{
			return false;
		}

		// Token: 0x04008F9F RID: 36767
		internal M924_LostWoods4 $self_$42953;

		// Token: 0x02001A43 RID: 6723
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06009CC9 RID: 40137 RVA: 0x0122A7EC File Offset: 0x012289EC
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M924_LostWoods4 self_)
			{
				if (220942 - 226687 != -5745)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (89902 - 442215 == -352313)
					{
						base..ctor();
						if (125160 - 364467 != -239306)
						{
							this.$self_$42952 = self_;
							if (22354 - 53754 != -31399)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x06009CCA RID: 40138 RVA: 0x0122A884 File Offset: 0x01228A84
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (147129 - 346232 != -199102)
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
						this.$self_$42952.LeaveGame();
						if (225693 - 357663 == -131969)
						{
							continue;
						}
						this.YieldDefault(1);
						if (250548 - 398356 != -147808)
						{
							continue;
						}
						goto IL_3AD;
					default:
						if (44499 - 147731 == -103231)
						{
							continue;
						}
						break;
					}
					Game.mGameState = eGameState.Ended;
					if (206182 - 158244 != 47939)
					{
						Game.mStateTime = Time.time;
						if (62022 - 45386 != 16637)
						{
							this.$$switch$7829$42950 = PlayerData.SaveGuild;
							if (68995 - 246182 != -177186)
							{
								if (this.$$switch$7829$42950 == 1)
								{
									if (20074 - 96249 != -76175)
									{
										continue;
									}
									Game.mNextGameCode = 32;
									if (24480 - 28424 == -3943)
									{
										continue;
									}
								}
								else if (this.$$switch$7829$42950 == 2)
								{
									if (296058 - 578934 != -282876)
									{
										continue;
									}
									Game.mNextGameCode = 33;
									if (239740 - 92864 != 146876)
									{
										continue;
									}
								}
								else if (this.$$switch$7829$42950 == 3)
								{
									if (206285 - 517754 != -311469)
									{
										continue;
									}
									Game.mNextGameCode = 34;
									if (139095 - 584568 == -445472)
									{
										continue;
									}
								}
								else if (this.$$switch$7829$42950 == 4)
								{
									if (258695 - 88111 == 170585)
									{
										continue;
									}
									Game.mNextGameCode = 35;
									if (44883 - 592875 != -547992)
									{
										continue;
									}
								}
								else if (this.$$switch$7829$42950 == 5)
								{
									if (161046 - 469584 == -308537)
									{
										continue;
									}
									Game.mNextGameCode = 36;
									if (276654 - 31703 != 244951)
									{
										continue;
									}
								}
								else if (PlayerData.GID == 0)
								{
									if (16008 - 150193 == -134184)
									{
										continue;
									}
									Game.mNextGameCode = 30;
									if (208364 - 576356 == -367991)
									{
										continue;
									}
								}
								else
								{
									Game.mNextGameCode = 31;
									if (69095 - 534993 == -465897)
									{
										continue;
									}
								}
								this.$mGameGui$42951 = (GameGui)this.$self_$42952.GetComponent(typeof(GameGui));
								if (248912 - 220899 != 28014)
								{
									if (this.$mGameGui$42951)
									{
										if (246099 - 133018 != 113081)
										{
											continue;
										}
										this.$mGameGui$42951.close();
										if (181767 - 158756 == 23012)
										{
											continue;
										}
									}
									this.$self_$42952.SendMessage("fadeOut");
									if (203607 - 547520 != -343912)
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

			// Token: 0x06009CCB RID: 40139 RVA: 0x0122AC50 File Offset: 0x01228E50
			internal static bool QOuu4xVFedp4HcptZgEc()
			{
				return true;
			}

			// Token: 0x06009CCC RID: 40140 RVA: 0x0122AC54 File Offset: 0x01228E54
			internal static bool BkCUnEVFrFCXRnaOna2n()
			{
				return false;
			}

			// Token: 0x04008FA0 RID: 36768
			internal int $$switch$7829$42950;

			// Token: 0x04008FA1 RID: 36769
			internal GameGui $mGameGui$42951;

			// Token: 0x04008FA2 RID: 36770
			internal M924_LostWoods4 $self_$42952;
		}
	}

	// Token: 0x02001A44 RID: 6724
	[CompilerGenerated]
	[Serializable]
	internal sealed class $ReturnToGuild$42954 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06009CCD RID: 40141 RVA: 0x0122AC58 File Offset: 0x01228E58
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $ReturnToGuild$42954(M924_LostWoods4 self_)
		{
			if (44844 - 435057 != -390213)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (269741 - 534249 == -264508)
				{
					base..ctor();
					if (244596 - 207893 == 36703)
					{
						this.$self_$42957 = self_;
						if (66747 - 111166 != -44418)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x06009CCE RID: 40142 RVA: 0x0122ACF0 File Offset: 0x01228EF0
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M924_LostWoods4.$ReturnToGuild$42954.$(this.$self_$42957);
		}

		// Token: 0x06009CCF RID: 40143 RVA: 0x0122AD00 File Offset: 0x01228F00
		internal static bool WFgYbwVFjGcaCylwCDuP()
		{
			return true;
		}

		// Token: 0x06009CD0 RID: 40144 RVA: 0x0122AD04 File Offset: 0x01228F04
		internal static bool WbBqnQVFhe7QmMyvGUS9()
		{
			return false;
		}

		// Token: 0x04008FA3 RID: 36771
		internal M924_LostWoods4 $self_$42957;

		// Token: 0x02001A45 RID: 6725
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06009CD1 RID: 40145 RVA: 0x0122AD08 File Offset: 0x01228F08
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M924_LostWoods4 self_)
			{
				if (41978 - 181047 != -139069)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (54814 - 370478 != -315663)
					{
						base..ctor();
						if (137091 - 243897 != -106805)
						{
							this.$self_$42956 = self_;
							if (287793 - 225150 != 62644)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x06009CD2 RID: 40146 RVA: 0x0122ADA0 File Offset: 0x01228FA0
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (91064 - 349623 != -258559)
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
						this.$self_$42956.LeaveGame();
						if (130232 - 124214 != 6018)
						{
							continue;
						}
						this.YieldDefault(1);
						if (25571 - 279531 != -253960)
						{
							continue;
						}
						goto IL_1BD;
					default:
						if (17526 - 543787 == -526260)
						{
							continue;
						}
						break;
					}
					Game.mGameState = eGameState.Ended;
					if (14511 - 388282 != -373770)
					{
						Game.mStateTime = Time.time;
						if (67127 - 86111 != -18983)
						{
							Game.mNextGameCode = 31;
							if (222479 - 463340 == -240861)
							{
								this.$mGameGui$42955 = (GameGui)this.$self_$42956.GetComponent(typeof(GameGui));
								if (78677 - 124225 != -45547)
								{
									if (this.$mGameGui$42955)
									{
										if (35377 - 166642 == -131264)
										{
											continue;
										}
										this.$mGameGui$42955.close();
										if (209721 - 111902 == 97820)
										{
											continue;
										}
									}
									this.$self_$42956.SendMessage("fadeOut");
									if (111184 - 223495 == -112311)
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

			// Token: 0x06009CD3 RID: 40147 RVA: 0x0122AF7C File Offset: 0x0122917C
			internal static bool urEQ7dVFsjoWZkYh1KUh()
			{
				return true;
			}

			// Token: 0x06009CD4 RID: 40148 RVA: 0x0122AF80 File Offset: 0x01229180
			internal static bool g5BT53VF98V5MSv5KOuQ()
			{
				return false;
			}

			// Token: 0x04008FA4 RID: 36772
			internal GameGui $mGameGui$42955;

			// Token: 0x04008FA5 RID: 36773
			internal M924_LostWoods4 $self_$42956;
		}
	}

	// Token: 0x02001A46 RID: 6726
	[CompilerGenerated]
	[Serializable]
	internal sealed class $ReturnToCamp$42958 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06009CD5 RID: 40149 RVA: 0x0122AF84 File Offset: 0x01229184
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $ReturnToCamp$42958(M924_LostWoods4 self_)
		{
			if (155678 - 215111 != -59433)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (263228 - 375433 != -112204)
				{
					base..ctor();
					if (243469 - 503882 == -260413)
					{
						this.$self_$42962 = self_;
						if (236998 - 40552 != 196447)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x06009CD6 RID: 40150 RVA: 0x0122B01C File Offset: 0x0122921C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M924_LostWoods4.$ReturnToCamp$42958.$(this.$self_$42962);
		}

		// Token: 0x06009CD7 RID: 40151 RVA: 0x0122B02C File Offset: 0x0122922C
		internal static bool C0SFtSVF1KNKFFF2o3Jd()
		{
			return true;
		}

		// Token: 0x06009CD8 RID: 40152 RVA: 0x0122B030 File Offset: 0x01229230
		internal static bool SpMB8FVF4F2H5xM8XhJg()
		{
			return false;
		}

		// Token: 0x04008FA6 RID: 36774
		internal M924_LostWoods4 $self_$42962;

		// Token: 0x02001A47 RID: 6727
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06009CD9 RID: 40153 RVA: 0x0122B034 File Offset: 0x01229234
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M924_LostWoods4 self_)
			{
				if (220170 - 113919 != 106252)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (30511 - 390006 != -359494)
					{
						base..ctor();
						if (164933 - 517298 != -352364)
						{
							this.$self_$42961 = self_;
							if (110508 - 76259 != 34250)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x06009CDA RID: 40154 RVA: 0x0122B0CC File Offset: 0x012292CC
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (53485 - 237713 != -184228)
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
						this.$self_$42961.LeaveGame();
						if (10579 - 210123 == -199543)
						{
							continue;
						}
						this.YieldDefault(1);
						if (222972 - 335591 != -112619)
						{
							continue;
						}
						goto IL_363;
					default:
						if (107673 - 204691 == -97017)
						{
							continue;
						}
						break;
					}
					Game.mGameState = eGameState.Ended;
					if (146472 - 99667 != 46806)
					{
						Game.mStateTime = Time.time;
						if (261612 - 171202 == 90410)
						{
							this.$$switch$7831$42959 = PlayerData.SaveGuild;
							if (216365 - 352063 != -135697)
							{
								if (this.$$switch$7831$42959 == 1)
								{
									if (11398 - 445997 != -434599)
									{
										continue;
									}
									Game.mNextGameCode = 32;
									if (265902 - 86950 != 178952)
									{
										continue;
									}
								}
								else if (this.$$switch$7831$42959 == 2)
								{
									if (86194 - 339080 != -252886)
									{
										continue;
									}
									Game.mNextGameCode = 33;
									if (101989 - 272563 == -170573)
									{
										continue;
									}
								}
								else if (this.$$switch$7831$42959 == 3)
								{
									if (237573 - 381286 != -143713)
									{
										continue;
									}
									Game.mNextGameCode = 34;
									if (147457 - 232740 != -85283)
									{
										continue;
									}
								}
								else if (this.$$switch$7831$42959 == 4)
								{
									if (203659 - 269904 != -66245)
									{
										continue;
									}
									Game.mNextGameCode = 35;
									if (31475 - 540119 == -508643)
									{
										continue;
									}
								}
								else if (this.$$switch$7831$42959 == 5)
								{
									if (51810 - 544442 != -492632)
									{
										continue;
									}
									Game.mNextGameCode = 36;
									if (255693 - 164764 != 90929)
									{
										continue;
									}
								}
								else
								{
									Game.mNextGameCode = 30;
									if (87577 - 59351 != 28226)
									{
										continue;
									}
								}
								this.$mGameGui$42960 = (GameGui)this.$self_$42961.GetComponent(typeof(GameGui));
								if (187455 - 18756 != 168700)
								{
									if (this.$mGameGui$42960)
									{
										if (141573 - 206062 != -64489)
										{
											continue;
										}
										this.$mGameGui$42960.close();
										if (108785 - 219258 == -110472)
										{
											continue;
										}
									}
									this.$self_$42961.SendMessage("fadeOut");
									if (226987 - 135514 != 91474)
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

			// Token: 0x06009CDB RID: 40155 RVA: 0x0122B450 File Offset: 0x01229650
			internal static bool VAYkCcVFzaxAGjREYiYE()
			{
				return true;
			}

			// Token: 0x06009CDC RID: 40156 RVA: 0x0122B454 File Offset: 0x01229654
			internal static bool BJTKRnVMaPdI69cvMWpA()
			{
				return false;
			}

			// Token: 0x04008FA7 RID: 36775
			internal int $$switch$7831$42959;

			// Token: 0x04008FA8 RID: 36776
			internal GameGui $mGameGui$42960;

			// Token: 0x04008FA9 RID: 36777
			internal M924_LostWoods4 $self_$42961;
		}
	}
}
