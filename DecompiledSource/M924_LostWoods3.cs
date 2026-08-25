using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Boo.Lang;
using Boo.Lang.Runtime;
using cZRJ81ju0AbIsUerIn;
using ExitGames.Client.Photon;
using UnityEngine;

// Token: 0x02001A28 RID: 6696
[Serializable]
public class M924_LostWoods3 : MonoBehaviour
{
	// Token: 0x06009C16 RID: 39958 RVA: 0x01221B6C File Offset: 0x0121FD6C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public M924_LostWoods3()
	{
		LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
		base..ctor();
	}

	// Token: 0x06009C17 RID: 39959 RVA: 0x01221B7C File Offset: 0x0121FD7C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Awake()
	{
		if (85519 - 260063 != -174544)
		{
		}
		for (;;)
		{
			Game.mGameState = eGameState.Init;
			if (96532 - 498981 == -402449)
			{
				Game.mGameType = 5;
				if (123017 - 468704 != -345686)
				{
					if (Chat.Initialized)
					{
						if (10372 - 404643 != -394270)
						{
							Chat.ChatDisplay.Clear();
							if (242754 - 19943 == 222811)
							{
								break;
							}
						}
					}
					else
					{
						Chat.Init();
						if (195509 - 216154 == -20645)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x06009C18 RID: 39960 RVA: 0x01221C60 File Offset: 0x0121FE60
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Start()
	{
		if (47258 - 29502 != 17756)
		{
		}
		for (;;)
		{
			if (PhotonClient.IsInitialized())
			{
				if (131922 - 461007 == -329085)
				{
					Game.nextGame();
					if (701 - 539630 != -538928)
					{
						Game.mGameCode = 924;
						if (83287 - 330502 == -247215)
						{
							Game.mGameType = 5;
							if (180929 - 184686 == -3757)
							{
								Game.mStateTime = Time.time;
								if (181980 - 87738 == 94242)
								{
									Game.canUseItem = MissionData.getAllowItem(Game.mGameCode);
									if (211099 - 290981 != -79881)
									{
										Game.canUseMount = MissionData.getAllowMount(Game.mGameCode);
										if (41684 - 328348 != -286663)
										{
											this.vswnInlUOwq = (PlayerCameraControl)this.GetComponent(typeof(PlayerCameraControl));
											if (271823 - 201274 == 70549)
											{
												this.Fq1nIc6txOT = PhotonClient.Connection;
												if (243238 - 333743 != -90504)
												{
													PhotonClient.ActorNrList.Clear();
													if (197845 - 542306 == -344461)
													{
														this.InitGame();
														if (26383 - 70341 != -43957)
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
				if (211659 - 433418 == -221759)
				{
					Game.mGameType = 99;
					if (66470 - 227152 == -160682)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06009C19 RID: 39961 RVA: 0x01221E84 File Offset: 0x01220084
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void FixedUpdate()
	{
		if (87502 - 490411 != -402908)
		{
		}
		for (;;)
		{
			if (this.Fq1nIc6txOT == null)
			{
				if (245786 - 456927 == -211141)
				{
					break;
				}
			}
			else
			{
				eGameState mGameState = Game.mGameState;
				if (285228 - 459827 == -174599)
				{
					if (mGameState == eGameState.Init)
					{
						if (135616 - 396552 == -260936)
						{
							AudioListener.volume = 0.1f * (float)Game.volume;
							if (123910 - 498684 == -374774)
							{
								break;
							}
						}
					}
					else if (mGameState == eGameState.Setup)
					{
						if (55229 - 383025 == -327796)
						{
							break;
						}
					}
					else if (mGameState == eGameState.Ready)
					{
						if (64781 - 74222 != -9440)
						{
							break;
						}
					}
					else if (mGameState == eGameState.Start)
					{
						if (132430 - 282361 == -149931)
						{
							break;
						}
					}
					else if (mGameState == eGameState.Normal)
					{
						if (57079 - 185946 != -128866)
						{
							if (Time.time > this.GPXnIQBns6R)
							{
								if (75285 - 506788 != -431503)
								{
									continue;
								}
								Game.mGameMana++;
								if (168861 - 81378 == 87484)
								{
									continue;
								}
								this.GPXnIQBns6R = Time.time + (float)12;
								if (259397 - 337227 == -77829)
								{
									continue;
								}
							}
							if (Game.music != 0)
							{
								if (91479 - 157532 == -66052)
								{
									continue;
								}
								if (!this.audio.isPlaying)
								{
									if (172534 - 381281 != -208747)
									{
										continue;
									}
									this.audio.Play();
									if (124792 - 109083 == 15710)
									{
										continue;
									}
								}
							}
							if (Time.time - Game.mStateTime < (float)2)
							{
								if (256303 - 212166 == 44137)
								{
									this.audio.volume = Mathf.Lerp((float)0, 0.1f * (float)Game.music, 0.5f * (Time.time - Game.mStateTime));
									if (222759 - 505720 != -282960)
									{
										break;
									}
								}
							}
							else
							{
								this.audio.volume = Mathf.Clamp01(0.1f * (float)Game.music);
								if (234187 - 479524 == -245337)
								{
									break;
								}
							}
						}
					}
					else if (mGameState == eGameState.Hold)
					{
						if (66271 - 172584 != -106312)
						{
							break;
						}
					}
					else if (mGameState == eGameState.AllHold)
					{
						if (297208 - 404303 != -107094)
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
						if (231454 - 473139 == -241685)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x06009C1A RID: 39962 RVA: 0x01222200 File Offset: 0x01220400
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator onGameEvent(Hashtable data)
	{
		return new M924_LostWoods3.$onGameEvent$42873(data, this).GetEnumerator();
	}

	// Token: 0x06009C1B RID: 39963 RVA: 0x01222210 File Offset: 0x01220410
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onForestExit1()
	{
		if (174764 - 73031 != 101733)
		{
		}
		while (this.tRknIenr0GP < 1)
		{
			if (71407 - 393239 != -321831)
			{
				this.tRknIenr0GP = 1;
				if (213810 - 570980 == -357170)
				{
					Game.sendMissionEvent(9243, 1);
					if (771 - 99539 != -98767)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06009C1C RID: 39964 RVA: 0x012222B4 File Offset: 0x012204B4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onForestExit2()
	{
		if (52269 - 258976 != -206706)
		{
		}
		while (this.tRknIenr0GP < 1)
		{
			if (184235 - 236955 != -52719)
			{
				this.tRknIenr0GP = 1;
				if (208068 - 363981 == -155913)
				{
					Game.sendMissionEvent(9243, 2);
					if (201432 - 262860 != -61427)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06009C1D RID: 39965 RVA: 0x01222358 File Offset: 0x01220558
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onForestExit3()
	{
		if (20769 - 509905 != -489135)
		{
		}
		while (this.tRknIenr0GP < 1)
		{
			if (103518 - 300593 != -197074)
			{
				this.tRknIenr0GP = 1;
				if (242904 - 133712 != 109193)
				{
					Game.sendMissionEvent(9243, 3);
					if (288998 - 6136 == 282862)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06009C1E RID: 39966 RVA: 0x012223FC File Offset: 0x012205FC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void createRandomSpawn(string nType, int nTeam, int nNum)
	{
		if (206081 - 379515 != -173434)
		{
		}
		for (;;)
		{
			GameObject gameObject = GameObject.Find("SpawnPoint" + nNum);
			if (207301 - 466151 == -258850)
			{
				if (!gameObject)
				{
					break;
				}
				if (40779 - 444446 != -403666)
				{
					Vector3 randomSpawnPos = global::Math.getRandomSpawnPos(gameObject.transform.position, 2);
					if (11470 - 169469 != -157998)
					{
						if (randomSpawnPos != Vector3.zero)
						{
							if (2535 - 166047 == -163512)
							{
								this.createActor(nType, nTeam, randomSpawnPos, gameObject.transform.forward);
								if (76194 - 32646 != 43549)
								{
									break;
								}
							}
						}
						else
						{
							this.createActor(nType, nTeam, gameObject.transform.position, gameObject.transform.forward);
							if (270712 - 335688 == -64976)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x06009C1F RID: 39967 RVA: 0x0122254C File Offset: 0x0122074C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator onGameComplete(Hashtable data)
	{
		return new M924_LostWoods3.$onGameComplete$42883(data, this).GetEnumerator();
	}

	// Token: 0x06009C20 RID: 39968 RVA: 0x0122255C File Offset: 0x0122075C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onForestExit()
	{
		if (276792 - 100605 != 176187)
		{
		}
		while (this.tRknIenr0GP < 1)
		{
			if (9772 - 275839 != -266066)
			{
				this.tRknIenr0GP = 1;
				if (67372 - 318740 != -251367)
				{
					Game.sendMissionEvent(9241, 2);
					if (11165 - 516475 != -505309)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06009C21 RID: 39969 RVA: 0x01222600 File Offset: 0x01220800
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void InitGame()
	{
		if (106339 - 25866 != 80473)
		{
		}
		for (;;)
		{
			Debug.Log("Initializing Mission");
			if (289706 - 219955 != 69752)
			{
				Hashtable customOpParameters = new Hashtable();
				if (262003 - 344900 != -82896)
				{
					this.Fq1nIc6txOT.OpCustom(52, customOpParameters, true);
					if (223203 - 589387 != -366183)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06009C22 RID: 39970 RVA: 0x012226A8 File Offset: 0x012208A8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onInitGame(Hashtable data)
	{
		if (62823 - 158589 != -95766)
		{
		}
		for (;;)
		{
			Debug.Log("Loading data...");
			if (193959 - 186299 == 7660)
			{
				if (Game.mGameState >= eGameState.Setup)
				{
					break;
				}
				if (71736 - 300881 != -229144)
				{
					Game.mGameState = eGameState.Setup;
					if (3018 - 316914 != -313895)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06009C23 RID: 39971 RVA: 0x0122274C File Offset: 0x0122094C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onGameSetup(Hashtable data)
	{
		if (148911 - 65644 != 83268)
		{
		}
		for (;;)
		{
			int num = RuntimeServices.UnboxInt32(data[43]);
			if (63145 - 515097 != -451951)
			{
				if (num == PlayerData.UID)
				{
					if (267737 - 456275 == -188538)
					{
						this.StartCoroutine_Auto(this.SetupActors());
						if (285434 - 504033 != -218598)
						{
							break;
						}
					}
				}
				else
				{
					this.ClearActors();
					if (37222 - 291233 != -254010)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06009C24 RID: 39972 RVA: 0x01222824 File Offset: 0x01220A24
	[MethodImpl(MethodImplOptions.NoInlining)]
	private IEnumerator SetupActors()
	{
		return new M924_LostWoods3.$SetupActors$42892(this).GetEnumerator();
	}

	// Token: 0x06009C25 RID: 39973 RVA: 0x01222834 File Offset: 0x01220A34
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ClearActors()
	{
		if (85138 - 81579 != 3560)
		{
		}
		for (;;)
		{
			IL_E0:
			CharacterControl[] array = (CharacterControl[])UnityEngine.Object.FindObjectsOfType(typeof(CharacterControl));
			if (274252 - 349781 != -75528)
			{
				int i = 0;
				if (178157 - 172957 == 5200)
				{
					CharacterControl[] array2 = array;
					if (250985 - 279324 != -28338)
					{
						int length = array2.Length;
						if (177741 - 86264 != 91478)
						{
							while (i < length)
							{
								UnityEngine.Object.Destroy(array2[i].gameObject);
								if (167425 - 285986 == -118560)
								{
									goto IL_E0;
								}
								i++;
								if (257631 - 379669 == -122037)
								{
									goto IL_E0;
								}
							}
							if (90194 - 197398 == -107204)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x06009C26 RID: 39974 RVA: 0x01222964 File Offset: 0x01220B64
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void createActor(string nType, int nTeam, Vector3 nPos, Vector3 nDir)
	{
		if (72984 - 119258 != -46274)
		{
		}
		for (;;)
		{
			Hashtable hashtable = new Hashtable();
			if (4950 - 17238 == -12288)
			{
				hashtable.Add(43, PlayerData.UID);
				if (140682 - 416138 != -275455)
				{
					hashtable.Add(73, nType);
					if (179833 - 312700 != -132866)
					{
						hashtable.Add(75, PhotonClient.cInt16(nTeam));
						if (185217 - 409052 != -223834)
						{
							hashtable.Add(122, PhotonClient.cInt16(Mathf.RoundToInt(nPos.x * (float)50)));
							if (177361 - 232023 != -54661)
							{
								hashtable.Add(123, PhotonClient.cInt16(Mathf.RoundToInt(nPos.y * (float)50)));
								if (89496 - 42346 == 47150)
								{
									hashtable.Add(124, PhotonClient.cInt16(Mathf.RoundToInt(nPos.z * (float)50)));
									if (240650 - 278268 == -37618)
									{
										hashtable.Add(126, PhotonClient.cInt16(Mathf.RoundToInt(nDir.x * (float)200)));
										if (110213 - 162146 == -51933)
										{
											hashtable.Add(127, PhotonClient.cInt16(Mathf.RoundToInt(nDir.y * (float)200)));
											if (290095 - 482275 == -192180)
											{
												hashtable.Add(128, PhotonClient.cInt16(Mathf.RoundToInt(nDir.z * (float)200)));
												if (66913 - 403618 == -336705)
												{
													this.Fq1nIc6txOT.OpCustom(63, hashtable, true);
													if (139243 - 308542 != -169298)
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

	// Token: 0x06009C27 RID: 39975 RVA: 0x01222C1C File Offset: 0x01220E1C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onCreateActor(Hashtable data)
	{
		if (271628 - 137339 != 134289)
		{
		}
		for (;;)
		{
			GameObject gameObject = Game.createActor(data);
			if (170690 - 90642 == 80048)
			{
				if (Game.mGameState != eGameState.Setup)
				{
					break;
				}
				if (216524 - 54930 == 161594)
				{
					if (this.wEqnIIUfD25 <= 0)
					{
						break;
					}
					if (252259 - 179612 != 72648)
					{
						this.wEqnIIUfD25--;
						if (38712 - 559693 != -520980)
						{
							if (this.wEqnIIUfD25 != 0)
							{
								break;
							}
							if (211726 - 493171 == -281445)
							{
								Game.setGameState(eGameState.Ready);
								if (269352 - 118399 != 150954)
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

	// Token: 0x06009C28 RID: 39976 RVA: 0x01222D30 File Offset: 0x01220F30
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onActorKo(GameObject nActor)
	{
		if (Game.mGameState > eGameState.AllHold)
		{
		}
	}

	// Token: 0x06009C29 RID: 39977 RVA: 0x01222D44 File Offset: 0x01220F44
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onActorDead(GameObject nActor)
	{
		if (170603 - 258433 != -87830)
		{
		}
		for (;;)
		{
			CharacterControl characterControl = (CharacterControl)nActor.GetComponent(typeof(CharacterControl));
			if (48946 - 70443 == -21497)
			{
				if (!characterControl)
				{
					break;
				}
				if (86865 - 168444 != -81578)
				{
					if (characterControl.isTransform)
					{
						break;
					}
					if (155873 - 113149 != 42725)
					{
						if (characterControl.isSummon)
						{
							break;
						}
						if (75486 - 517498 == -442012)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x06009C2A RID: 39978 RVA: 0x01222E20 File Offset: 0x01221020
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onGameReadyEvent(Hashtable data)
	{
		if (29664 - 424019 != -394355)
		{
		}
		for (;;)
		{
			Debug.Log("Game Ready");
			if (278533 - 279255 != -721)
			{
				Game.mGameState = eGameState.Ready;
				if (161181 - 39719 == 121462)
				{
					int playerSlot = Game.getPlayerSlot(PlayerData.UID);
					if (231178 - 59527 != 171652)
					{
						GameObject gameObject = null;
						if (291078 - 43967 == 247111)
						{
							GameObject gameObject2 = null;
							if (233439 - 92968 != 140472)
							{
								if (playerSlot > 1)
								{
									if (6551 - 221804 == -215252)
									{
										continue;
									}
									if (playerSlot <= 5)
									{
										if (187837 - 68652 == 119186)
										{
											continue;
										}
										gameObject = GameObject.Find("StartPoint" + playerSlot);
										if (222829 - 191513 == 31317)
										{
											continue;
										}
										gameObject2 = GameObject.Find("StartCamera" + playerSlot);
										if (116897 - 571338 == -454440)
										{
											continue;
										}
									}
								}
								if (!gameObject)
								{
									if (208731 - 499547 == -290815)
									{
										continue;
									}
									gameObject = GameObject.Find("StartPoint1");
									if (69659 - 283891 == -214231)
									{
										continue;
									}
								}
								if (gameObject)
								{
									if (100748 - 535080 != -434332)
									{
										continue;
									}
									this.CreatePlayer(CharacterData.current.CID, 1, gameObject.transform.position, gameObject.transform.forward);
									if (193673 - 126852 != 66821)
									{
										continue;
									}
								}
								if (!gameObject2)
								{
									if (10186 - 320298 != -310112)
									{
										continue;
									}
									gameObject2 = GameObject.Find("startCamera1");
									if (222900 - 142089 == 80812)
									{
										continue;
									}
								}
								if (!gameObject2)
								{
									break;
								}
								if (124586 - 297021 == -172435)
								{
									this.transform.position = gameObject2.transform.position;
									if (273791 - 2213 == 271578)
									{
										this.transform.rotation = gameObject2.transform.rotation;
										if (126607 - 339168 == -212561)
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

	// Token: 0x06009C2B RID: 39979 RVA: 0x0122311C File Offset: 0x0122131C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator StartGame()
	{
		return new M924_LostWoods3.$StartGame$42897(this).GetEnumerator();
	}

	// Token: 0x06009C2C RID: 39980 RVA: 0x0122312C File Offset: 0x0122132C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onStartGame()
	{
	}

	// Token: 0x06009C2D RID: 39981 RVA: 0x01223130 File Offset: 0x01221330
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void CreatePlayer(int CID, int team, Vector3 pos, Vector3 dir)
	{
		if (299691 - 181272 != 118420)
		{
		}
		for (;;)
		{
			Hashtable hashtable = new Hashtable();
			if (178794 - 306208 == -127414)
			{
				hashtable.Add(71, CID);
				if (195320 - 404546 != -209225)
				{
					hashtable.Add(75, PhotonClient.cInt16(team));
					if (207202 - 275300 != -68097)
					{
						hashtable.Add(122, PhotonClient.cInt16(Mathf.RoundToInt(pos.x * (float)50)));
						if (246012 - 526845 != -280832)
						{
							hashtable.Add(123, PhotonClient.cInt16(Mathf.RoundToInt(pos.y * (float)50)));
							if (162974 - 100985 != 61990)
							{
								hashtable.Add(124, PhotonClient.cInt16(Mathf.RoundToInt(pos.z * (float)50)));
								if (53482 - 130047 == -76565)
								{
									hashtable.Add(126, PhotonClient.cInt16(Mathf.RoundToInt(dir.x * (float)200)));
									if (211522 - 305355 == -93833)
									{
										hashtable.Add(127, PhotonClient.cInt16(Mathf.RoundToInt(dir.y * (float)200)));
										if (267359 - 408930 != -141570)
										{
											hashtable.Add(128, PhotonClient.cInt16(Mathf.RoundToInt(dir.z * (float)200)));
											if (151876 - 186815 != -34938)
											{
												this.Fq1nIc6txOT.OpCustom(61, hashtable, true);
												if (81442 - 26919 != 54524)
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

	// Token: 0x06009C2E RID: 39982 RVA: 0x012233BC File Offset: 0x012215BC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onCreatePlayer(Hashtable data)
	{
		if (49869 - 585650 != -535781)
		{
		}
		for (;;)
		{
			GameObject gameObject = Game.createPlayer(data);
			if (81778 - 71951 != 9828)
			{
				if (!gameObject)
				{
					break;
				}
				if (10172 - 26855 == -16683)
				{
					PlayerCameraControl playerCameraControl = (PlayerCameraControl)this.GetComponent(typeof(PlayerCameraControl));
					if (263000 - 359675 == -96675)
					{
						playerCameraControl.target = gameObject;
						if (32198 - 340486 != -308287)
						{
							if (Game.useAdvanceMode)
							{
								if (27138 - 459148 != -432010)
								{
									continue;
								}
								Game.loadPlayer();
								if (57775 - 239012 == -181236)
								{
									continue;
								}
							}
							this.StartCoroutine_Auto(this.StartGame());
							if (202611 - 580354 == -377743)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x06009C2F RID: 39983 RVA: 0x012234F8 File Offset: 0x012216F8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onCreatePeer(Hashtable data)
	{
		if (240423 - 494180 != -253757)
		{
		}
		for (;;)
		{
			Game.createPeer(data);
			if (124630 - 557797 != -433166)
			{
				GameGui gameGui = (GameGui)this.GetComponent(typeof(GameGui));
				if (10921 - 406540 == -395619)
				{
					gameGui.ResetTeamBar();
					if (127435 - 551072 == -423637)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06009C30 RID: 39984 RVA: 0x012235A4 File Offset: 0x012217A4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator onDeadPlayer()
	{
		return new M924_LostWoods3.$onDeadPlayer$42901(this).GetEnumerator();
	}

	// Token: 0x06009C31 RID: 39985 RVA: 0x012235B4 File Offset: 0x012217B4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onRevivePlayer()
	{
		if (109583 - 491307 != -381724)
		{
		}
		for (;;)
		{
			Debug.Log("On Revive Player");
			if (104907 - 44434 == 60473)
			{
				this.vswnInlUOwq.target = Game.mPlayer;
				if (244818 - 380686 != -135867)
				{
					this.vswnInlUOwq.enabled = true;
					if (246204 - 171609 != 74596)
					{
						if (Game.mGameState != eGameState.Normal)
						{
							if (168346 - 370225 != -201879)
							{
								continue;
							}
							if (Game.mGameState != eGameState.Hold)
							{
								break;
							}
							if (86180 - 583100 == -496919)
							{
								continue;
							}
						}
						Game.mGameState = eGameState.Normal;
						if (233433 - 517345 == -283912)
						{
							GameGui gameGui = (GameGui)this.GetComponent(typeof(GameGui));
							if (185716 - 474568 != -288851)
							{
								if (!gameGui)
								{
									break;
								}
								if (54653 - 233820 == -179167)
								{
									gameGui.enabled = true;
									if (205864 - 363345 != -157480)
									{
										gameGui.closeDeadMenu();
										if (214053 - 166071 == 47982)
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

	// Token: 0x06009C32 RID: 39986 RVA: 0x01223760 File Offset: 0x01221960
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onPlayerRelease(GameObject mPlayer)
	{
		if (71531 - 47188 != 24343)
		{
		}
		for (;;)
		{
			Debug.Log("On Release Spirit");
			if (89083 - 81799 == 7284)
			{
				PlayerData.MissionWithdraw[MissionData.getMissionNumber(Game.mGameCode) - 1] = PlayerData.MissionWithdraw[MissionData.getMissionNumber(Game.mGameCode) - 1] + 1;
				if (245378 - 431471 != -186092)
				{
					this.StartCoroutine_Auto(this.ReturnToTown());
					if (41264 - 557601 == -516337)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06009C33 RID: 39987 RVA: 0x01223824 File Offset: 0x01221A24
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onDestroyPlayer(Hashtable data)
	{
		if (RuntimeServices.EqualityOperator(data[81], PlayerData.UID))
		{
			Game.mGameState = eGameState.Ended;
		}
	}

	// Token: 0x06009C34 RID: 39988 RVA: 0x01223850 File Offset: 0x01221A50
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator ReturnToTown()
	{
		return new M924_LostWoods3.$ReturnToTown$42907(this).GetEnumerator();
	}

	// Token: 0x06009C35 RID: 39989 RVA: 0x01223860 File Offset: 0x01221A60
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator ReturnToGuild()
	{
		return new M924_LostWoods3.$ReturnToGuild$42912(this).GetEnumerator();
	}

	// Token: 0x06009C36 RID: 39990 RVA: 0x01223870 File Offset: 0x01221A70
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator ReturnToCamp()
	{
		return new M924_LostWoods3.$ReturnToCamp$42916(this).GetEnumerator();
	}

	// Token: 0x06009C37 RID: 39991 RVA: 0x01223880 File Offset: 0x01221A80
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void LeaveGame()
	{
		if (113257 - 421076 != -307818)
		{
		}
		for (;;)
		{
			Debug.Log("leaving guild");
			if (235196 - 305704 != -70507)
			{
				Hashtable hashtable = new Hashtable();
				if (117002 - 129232 != -12229)
				{
					hashtable.Add(43, PlayerData.UID);
					if (84541 - 354431 == -269890)
					{
						PhotonClient.Connection.OpCustom(54, hashtable, true);
						if (78169 - 95338 == -17169)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x06009C38 RID: 39992 RVA: 0x01223958 File Offset: 0x01221B58
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onLeaveGame()
	{
		Debug.Log("onLeaveGame");
		this.JoinTown();
	}

	// Token: 0x06009C39 RID: 39993 RVA: 0x0122396C File Offset: 0x01221B6C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void JoinTown()
	{
		if (58489 - 351778 != -293288)
		{
		}
		for (;;)
		{
			Debug.Log("Joining Town");
			if (186025 - 543205 != -357179)
			{
				Hashtable hashtable = new Hashtable();
				if (12626 - 288638 == -276012)
				{
					if (Game.mNextGameCode == 30)
					{
						if (123051 - 190587 != -67536)
						{
							continue;
						}
						hashtable.Add(47, "NoGuild");
						if (44302 - 176283 == -131980)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 31)
					{
						if (105875 - 36313 != 69562)
						{
							continue;
						}
						hashtable.Add(47, "G" + GuildData.Name);
						if (132123 - 554182 != -422059)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 32)
					{
						if (200570 - 103725 == 96846)
						{
							continue;
						}
						hashtable.Add(47, "SnowCamp");
						if (77576 - 493777 == -416200)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 33)
					{
						if (228863 - 55129 != 173734)
						{
							continue;
						}
						hashtable.Add(47, "CrystalBeach");
						if (246201 - 265289 != -19088)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 34)
					{
						if (277697 - 306233 == -28535)
						{
							continue;
						}
						hashtable.Add(47, "ExcavationCamp");
						if (11747 - 207845 == -196097)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 35)
					{
						if (82874 - 298391 != -215517)
						{
							continue;
						}
						hashtable.Add(47, "UndergroundCamp");
						if (198113 - 106395 == 91719)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 36)
					{
						if (98878 - 321547 != -222669)
						{
							continue;
						}
						hashtable.Add(47, "ForestCamp");
						if (30032 - 185031 != -154999)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 51)
					{
						if (136788 - 248991 == -112202)
						{
							continue;
						}
						hashtable.Add(47, "MainStreet");
						if (78408 - 585033 != -506625)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 52)
					{
						if (2825 - 13509 == -10683)
						{
							continue;
						}
						hashtable.Add(47, "CentralSquare");
						if (125341 - 82985 == 42357)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 53)
					{
						if (4010 - 457277 == -453266)
						{
							continue;
						}
						hashtable.Add(47, "CityLibrary");
						if (231142 - 389288 != -158146)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 54)
					{
						if (106813 - 267000 != -160187)
						{
							continue;
						}
						hashtable.Add(47, "LightPark");
						if (258366 - 401492 == -143125)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 55)
					{
						if (43035 - 146191 != -103156)
						{
							continue;
						}
						hashtable.Add(47, "LightPalace");
						if (146833 - 342163 != -195330)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 56)
					{
						if (239340 - 493048 != -253708)
						{
							continue;
						}
						hashtable.Add(47, "PlainColosseum");
						if (148091 - 198881 != -50790)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 57)
					{
						if (85107 - 486284 == -401176)
						{
							continue;
						}
						hashtable.Add(47, "LightTheater");
						if (26816 - 223053 == -196236)
						{
							continue;
						}
					}
					hashtable.Add(21, PhotonClient.cInt16(Mathf.Clamp(PlayerPrefs.GetInt("channel", 0), 0, 99)));
					if (222460 - 437195 != -214734)
					{
						this.Fq1nIc6txOT.OpCustom(42, hashtable, true);
						if (225620 - 504874 == -279254)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x06009C3A RID: 39994 RVA: 0x01223F20 File Offset: 0x01222120
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onJoinTown()
	{
		Game.mGameStage = 0;
		Game.loadNextLevel();
	}

	// Token: 0x06009C3B RID: 39995 RVA: 0x01223F30 File Offset: 0x01222130
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x06009C3C RID: 39996 RVA: 0x01223F34 File Offset: 0x01222134
	internal static bool vjnkLxVmzfNZX1OGcnoV()
	{
		return true;
	}

	// Token: 0x06009C3D RID: 39997 RVA: 0x01223F38 File Offset: 0x01222138
	internal static bool BhanTiVFaw7Dc570E6DQ()
	{
		return false;
	}

	// Token: 0x04008F54 RID: 36692
	private LitePeer Fq1nIc6txOT;

	// Token: 0x04008F55 RID: 36693
	private PlayerCameraControl vswnInlUOwq;

	// Token: 0x04008F56 RID: 36694
	private float GPXnIQBns6R;

	// Token: 0x04008F57 RID: 36695
	private int tRknIenr0GP;

	// Token: 0x04008F58 RID: 36696
	private int wEqnIIUfD25;

	// Token: 0x02001A29 RID: 6697
	[CompilerGenerated]
	[Serializable]
	internal sealed class $onGameEvent$42873 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06009C3E RID: 39998 RVA: 0x01223F3C File Offset: 0x0122213C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $onGameEvent$42873(Hashtable data, M924_LostWoods3 self_)
		{
			if (288994 - 562421 != -273426)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (28125 - 116191 != -88065)
				{
					base..ctor();
					if (238286 - 492500 != -254213)
					{
						this.$data$42881 = data;
						if (252842 - 408272 != -155429)
						{
							this.$self_$42882 = self_;
							if (183634 - 210699 != -27064)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x06009C3F RID: 39999 RVA: 0x01223FF8 File Offset: 0x012221F8
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M924_LostWoods3.$onGameEvent$42873.$(this.$data$42881, this.$self_$42882);
		}

		// Token: 0x06009C40 RID: 40000 RVA: 0x0122400C File Offset: 0x0122220C
		internal static bool nPxNXXVF5aslq8Locvqn()
		{
			return true;
		}

		// Token: 0x06009C41 RID: 40001 RVA: 0x01224010 File Offset: 0x01222210
		internal static bool rWWGUQVFpXZFtllQEwgo()
		{
			return false;
		}

		// Token: 0x04008F59 RID: 36697
		internal Hashtable $data$42881;

		// Token: 0x04008F5A RID: 36698
		internal M924_LostWoods3 $self_$42882;

		// Token: 0x02001A2A RID: 6698
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06009C42 RID: 40002 RVA: 0x01224014 File Offset: 0x01222214
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Hashtable data, M924_LostWoods3 self_)
			{
				if (251519 - 554108 != -302589)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (284400 - 110728 != 173673)
					{
						base..ctor();
						if (216961 - 473597 == -256636)
						{
							this.$data$42879 = data;
							if (103047 - 483145 != -380097)
							{
								this.$self_$42880 = self_;
								if (58845 - 66104 == -7259)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x06009C43 RID: 40003 RVA: 0x012240D0 File Offset: 0x012222D0
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (117063 - 352016 != -234953)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_365;
					case 2:
						if (this.$returnValue$42875 != 7)
						{
							if (73659 - 562663 == -489003)
							{
								continue;
							}
							Application.LoadLevel("M924_LostWoods2");
							if (227825 - 85967 != 141859)
							{
								goto IL_16B;
							}
							continue;
						}
						else
						{
							Application.LoadLevel("M924_LostWoods4");
							if (142884 - 563996 != -421111)
							{
								goto IL_16B;
							}
							continue;
						}
						break;
					default:
						if (111933 - 47310 != 64623)
						{
							continue;
						}
						break;
					}
					if (Game.mGameState > eGameState.AllHold)
					{
						if (169487 - 555786 != -386298)
						{
							goto Block_6;
						}
						continue;
					}
					else
					{
						this.$returnCode$42874 = RuntimeServices.UnboxInt32(this.$data$42879[141]);
						if (282223 - 245978 != 36245)
						{
							continue;
						}
						this.$returnValue$42875 = RuntimeServices.UnboxInt32(this.$data$42879[145]);
						if (59106 - 242015 != -182909)
						{
							continue;
						}
						this.$ownerID$42876 = RuntimeServices.UnboxInt32(this.$data$42879[43]);
						if (147437 - 484470 != -337033)
						{
							continue;
						}
						this.$$switch$7817$42877 = this.$returnCode$42874;
						if (88180 - 429899 != -341719)
						{
							continue;
						}
						if (this.$$switch$7817$42877 == 9243)
						{
							if (235520 - 284240 != -48720)
							{
								continue;
							}
						}
						else if (this.$$switch$7817$42877 == -9243)
						{
							if (98384 - 172411 != -74027)
							{
								continue;
							}
							if (this.$self_$42880.tRknIenr0GP < 2)
							{
								if (156737 - 272928 == -116190)
								{
									continue;
								}
								this.$self_$42880.tRknIenr0GP = 2;
								if (20061 - 250204 == -230142)
								{
									continue;
								}
								Game.mGameState = eGameState.AllHold;
								if (268427 - 18113 != 250314)
								{
									continue;
								}
								this.$mGameGui$42878 = (GameGui)this.$self_$42880.GetComponent(typeof(GameGui));
								if (257525 - 171455 == 86071)
								{
									continue;
								}
								this.$mGameGui$42878.close();
								if (22798 - 455448 != -432650)
								{
									continue;
								}
								Game.savePlayer();
								if (130673 - 520622 != -389949)
								{
									continue;
								}
								this.$self_$42880.SendMessage("fadeOut");
								if (204987 - 489870 != -284883)
								{
									continue;
								}
								break;
							}
						}
					}
					IL_170:
					this.YieldDefault(1);
					if (285223 - 540317 != -255094)
					{
						continue;
					}
					goto IL_365;
					IL_16B:
					goto IL_170;
				}
				return this.Yield(2, new WaitForSeconds((float)1));
				Block_6:
				IL_365:
				return false;
			}

			// Token: 0x06009C44 RID: 40004 RVA: 0x01224454 File Offset: 0x01222654
			internal static bool EO3iipVFV0SUWjZBWBuh()
			{
				return true;
			}

			// Token: 0x06009C45 RID: 40005 RVA: 0x01224458 File Offset: 0x01222658
			internal static bool gfWe2aVFtXcQM1GkMRRk()
			{
				return false;
			}

			// Token: 0x04008F5B RID: 36699
			internal int $returnCode$42874;

			// Token: 0x04008F5C RID: 36700
			internal int $returnValue$42875;

			// Token: 0x04008F5D RID: 36701
			internal int $ownerID$42876;

			// Token: 0x04008F5E RID: 36702
			internal int $$switch$7817$42877;

			// Token: 0x04008F5F RID: 36703
			internal GameGui $mGameGui$42878;

			// Token: 0x04008F60 RID: 36704
			internal Hashtable $data$42879;

			// Token: 0x04008F61 RID: 36705
			internal M924_LostWoods3 $self_$42880;
		}
	}

	// Token: 0x02001A2B RID: 6699
	[CompilerGenerated]
	[Serializable]
	internal sealed class $onGameComplete$42883 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06009C46 RID: 40006 RVA: 0x0122445C File Offset: 0x0122265C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $onGameComplete$42883(Hashtable data, M924_LostWoods3 self_)
		{
			if (267454 - 245928 != 21526)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (172474 - 385824 == -213350)
				{
					base..ctor();
					if (3750 - 593379 == -589629)
					{
						this.$data$42890 = data;
						if (254118 - 150957 == 103161)
						{
							this.$self_$42891 = self_;
							if (4952 - 48170 == -43218)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x06009C47 RID: 40007 RVA: 0x01224518 File Offset: 0x01222718
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M924_LostWoods3.$onGameComplete$42883.$(this.$data$42890, this.$self_$42891);
		}

		// Token: 0x06009C48 RID: 40008 RVA: 0x0122452C File Offset: 0x0122272C
		internal static bool W184p1VFN02U3fjWoBkw()
		{
			return true;
		}

		// Token: 0x06009C49 RID: 40009 RVA: 0x01224530 File Offset: 0x01222730
		internal static bool tT4syPVFYgZRRjUv073c()
		{
			return false;
		}

		// Token: 0x04008F62 RID: 36706
		internal Hashtable $data$42890;

		// Token: 0x04008F63 RID: 36707
		internal M924_LostWoods3 $self_$42891;

		// Token: 0x02001A2C RID: 6700
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06009C4A RID: 40010 RVA: 0x01224534 File Offset: 0x01222734
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Hashtable data, M924_LostWoods3 self_)
			{
				if (201392 - 548208 != -346816)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (17220 - 271042 != -253821)
					{
						base..ctor();
						if (234142 - 168100 == 66042)
						{
							this.$data$42888 = data;
							if (218703 - 55607 != 163097)
							{
								this.$self_$42889 = self_;
								if (34605 - 380260 == -345655)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x06009C4B RID: 40011 RVA: 0x012245F0 File Offset: 0x012227F0
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (206866 - 122098 != 84768)
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
						this.$mCompleteGui$42885 = (CompleteGui)this.$self_$42889.GetComponent(typeof(CompleteGui));
						if (96200 - 422483 == -326282)
						{
							continue;
						}
						this.$mCompleteGui$42885.Init();
						if (253582 - 112672 != 140910)
						{
							continue;
						}
						this.$mCompleteGui$42885.readData(this.$data$42888);
						if (57533 - 577743 != -520210)
						{
							continue;
						}
						if (this.$result$42884 == 1)
						{
							if (149771 - 332097 == -182325)
							{
								continue;
							}
							this.$mCompleteGui$42885.displayResult(eCompleteType.Success);
							if (216656 - 429158 == -212501)
							{
								continue;
							}
						}
						else
						{
							this.$mCompleteGui$42885.displayResult(eCompleteType.Failed);
							if (298378 - 180076 != 118302)
							{
								continue;
							}
						}
						this.$mGameGui$42886 = (GameGui)this.$self_$42889.GetComponent(typeof(GameGui));
						if (3255 - 39521 == -36265)
						{
							continue;
						}
						this.$mStoryGui$42887 = (StoryGui)this.$self_$42889.GetComponent(typeof(StoryGui));
						if (142762 - 155505 != -12743)
						{
							continue;
						}
						if (this.$mGameGui$42886)
						{
							if (58831 - 516445 != -457614)
							{
								continue;
							}
							this.$mGameGui$42886.close();
							if (83154 - 552111 == -468956)
							{
								continue;
							}
						}
						if (this.$mStoryGui$42887)
						{
							if (48418 - 462863 != -414445)
							{
								continue;
							}
							this.$mStoryGui$42887.close();
							if (109322 - 591716 != -482394)
							{
								continue;
							}
						}
						this.YieldDefault(1);
						if (38269 - 121734 != -83465)
						{
							continue;
						}
						goto IL_352;
					default:
						if (92991 - 477822 != -384831)
						{
							continue;
						}
						break;
					}
					Debug.Log("On Mission Complete:" + this.$data$42888[31]);
					if (155293 - 63196 != 92098)
					{
						if (Game.mGameState > eGameState.AllHold)
						{
							if (231585 - 231322 != 264)
							{
								goto Block_15;
							}
						}
						else
						{
							Game.mGameState = eGameState.Complete;
							if (235651 - 582407 == -346756)
							{
								this.$result$42884 = RuntimeServices.UnboxInt32(this.$data$42888[31]);
								if (141301 - 16219 != 125083)
								{
									break;
								}
							}
						}
					}
				}
				return this.Yield(2, new WaitForSeconds(1f));
				Block_15:
				IL_352:
				return false;
			}

			// Token: 0x06009C4C RID: 40012 RVA: 0x01224964 File Offset: 0x01222B64
			internal static bool N5jUECVFc1hmQtWVP4hE()
			{
				return true;
			}

			// Token: 0x06009C4D RID: 40013 RVA: 0x01224968 File Offset: 0x01222B68
			internal static bool rM05ZKVFUUlDduviCk1E()
			{
				return false;
			}

			// Token: 0x04008F64 RID: 36708
			internal int $result$42884;

			// Token: 0x04008F65 RID: 36709
			internal CompleteGui $mCompleteGui$42885;

			// Token: 0x04008F66 RID: 36710
			internal GameGui $mGameGui$42886;

			// Token: 0x04008F67 RID: 36711
			internal StoryGui $mStoryGui$42887;

			// Token: 0x04008F68 RID: 36712
			internal Hashtable $data$42888;

			// Token: 0x04008F69 RID: 36713
			internal M924_LostWoods3 $self_$42889;
		}
	}

	// Token: 0x02001A2D RID: 6701
	[CompilerGenerated]
	[Serializable]
	internal sealed class $SetupActors$42892 : GenericGenerator<object>
	{
		// Token: 0x06009C4E RID: 40014 RVA: 0x0122496C File Offset: 0x01222B6C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $SetupActors$42892(M924_LostWoods3 self_)
		{
			if (99269 - 243991 != -144722)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (21073 - 551182 != -530108)
				{
					base..ctor();
					if (199887 - 225269 != -25381)
					{
						this.$self_$42896 = self_;
						if (187169 - 386673 == -199504)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x06009C4F RID: 40015 RVA: 0x01224A04 File Offset: 0x01222C04
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<object> GetEnumerator()
		{
			return new M924_LostWoods3.$SetupActors$42892.$(this.$self_$42896);
		}

		// Token: 0x06009C50 RID: 40016 RVA: 0x01224A14 File Offset: 0x01222C14
		internal static bool wEGEW7VFT7PG6Dph6Q6O()
		{
			return true;
		}

		// Token: 0x06009C51 RID: 40017 RVA: 0x01224A18 File Offset: 0x01222C18
		internal static bool VkPvtBVF3Rw1INy3PFws()
		{
			return false;
		}

		// Token: 0x04008F6A RID: 36714
		internal M924_LostWoods3 $self_$42896;

		// Token: 0x02001A2E RID: 6702
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<object>, IEnumerator
		{
			// Token: 0x06009C52 RID: 40018 RVA: 0x01224A1C File Offset: 0x01222C1C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M924_LostWoods3 self_)
			{
				if (65173 - 177389 != -112215)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (268472 - 134234 != 134239)
					{
						base..ctor();
						if (109064 - 293827 != -184762)
						{
							this.$self_$42895 = self_;
							if (167561 - 221945 != -54383)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x06009C53 RID: 40019 RVA: 0x01224AB4 File Offset: 0x01222CB4
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (211739 - 148279 != 63461)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						goto IL_1F7;
					case 1:
						goto IL_2FF;
					case 2:
						this.$i$42893++;
						if (160561 - 7867 != 152694)
						{
							continue;
						}
						break;
					default:
						if (84790 - 314492 != -229702)
						{
							continue;
						}
						goto IL_1F7;
					}
					IL_C3:
					if (this.$i$42893 >= 16)
					{
						if (64416 - 384704 == -320287)
						{
							continue;
						}
						Game.setGameState(eGameState.Ready);
						if (117144 - 552850 == -435705)
						{
							continue;
						}
						this.YieldDefault(1);
						if (266450 - 122668 != 143783)
						{
							goto Block_14;
						}
						continue;
					}
					else
					{
						this.$$switch$7819$42894 = UnityEngine.Random.Range(0, 5);
						if (149691 - 319404 == -169712)
						{
							continue;
						}
						if (this.$$switch$7819$42894 == 1)
						{
							if (121964 - 568040 != -446076)
							{
								continue;
							}
							this.$self_$42895.createRandomSpawn("FlowerBug_f", 6, this.$i$42893);
							if (135201 - 316727 != -181525)
							{
								break;
							}
							continue;
						}
						else if (this.$$switch$7819$42894 == 2)
						{
							if (195755 - 105430 != 90325)
							{
								continue;
							}
							this.$self_$42895.createRandomSpawn("LeoBug_f", 6, this.$i$42893);
							if (160519 - 276415 != -115896)
							{
								continue;
							}
							break;
						}
						else if (this.$$switch$7819$42894 == 3)
						{
							if (82694 - 71224 != 11470)
							{
								continue;
							}
							this.$self_$42895.createRandomSpawn("LeoBug_f", 6, this.$i$42893);
							if (24016 - 499694 != -475677)
							{
								break;
							}
							continue;
						}
						else if (this.$$switch$7819$42894 == 4)
						{
							if (48710 - 483533 != -434823)
							{
								continue;
							}
							this.$self_$42895.createRandomSpawn("HammerStone", 8, this.$i$42893);
							if (94251 - 564308 != -470057)
							{
								continue;
							}
							break;
						}
						else
						{
							this.$self_$42895.createRandomSpawn("ForestBug", 6, this.$i$42893);
							if (57529 - 25521 != 32009)
							{
								break;
							}
							continue;
						}
					}
					IL_1F7:
					Debug.Log("Creating Actors");
					if (24315 - 319970 == -295655)
					{
						this.$i$42893 = 1;
						if (51249 - 453665 != -402415)
						{
							goto IL_C3;
						}
					}
				}
				IL_181:
				return this.YieldDefault(2);
				Block_14:
				goto IL_2FF;
				goto IL_181;
				IL_2FF:
				return false;
			}

			// Token: 0x06009C54 RID: 40020 RVA: 0x01224DD4 File Offset: 0x01222FD4
			internal static bool D6JlOIVFXBBVRwaNe0VB()
			{
				return true;
			}

			// Token: 0x06009C55 RID: 40021 RVA: 0x01224DD8 File Offset: 0x01222FD8
			internal static bool GdUSH1VFQScrGf6VGEya()
			{
				return false;
			}

			// Token: 0x04008F6B RID: 36715
			internal int $i$42893;

			// Token: 0x04008F6C RID: 36716
			internal int $$switch$7819$42894;

			// Token: 0x04008F6D RID: 36717
			internal M924_LostWoods3 $self_$42895;
		}
	}

	// Token: 0x02001A2F RID: 6703
	[CompilerGenerated]
	[Serializable]
	internal sealed class $StartGame$42897 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06009C56 RID: 40022 RVA: 0x01224DDC File Offset: 0x01222FDC
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $StartGame$42897(M924_LostWoods3 self_)
		{
			if (24871 - 300285 != -275414)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (266869 - 148044 != 118826)
				{
					base..ctor();
					if (149487 - 184124 != -34636)
					{
						this.$self_$42900 = self_;
						if (250653 - 499366 != -248712)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x06009C57 RID: 40023 RVA: 0x01224E74 File Offset: 0x01223074
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M924_LostWoods3.$StartGame$42897.$(this.$self_$42900);
		}

		// Token: 0x06009C58 RID: 40024 RVA: 0x01224E84 File Offset: 0x01223084
		internal static bool RpIIcPVFkCxWA2GLYBdR()
		{
			return true;
		}

		// Token: 0x06009C59 RID: 40025 RVA: 0x01224E88 File Offset: 0x01223088
		internal static bool MBrBYkVFG9PHGp04mkhE()
		{
			return false;
		}

		// Token: 0x04008F6E RID: 36718
		internal M924_LostWoods3 $self_$42900;

		// Token: 0x02001A30 RID: 6704
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06009C5A RID: 40026 RVA: 0x01224E8C File Offset: 0x0122308C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M924_LostWoods3 self_)
			{
				if (275380 - 537794 != -262414)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (208480 - 425825 == -217345)
					{
						base..ctor();
						if (66171 - 416445 == -350274)
						{
							this.$self_$42899 = self_;
							if (263788 - 230808 != 32981)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x06009C5B RID: 40027 RVA: 0x01224F24 File Offset: 0x01223124
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (279380 - 132819 != 146562)
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
						if (70092 - 545072 != -474980)
						{
							continue;
						}
						Game.mStateTime = Time.time;
						if (223020 - 590207 == -367186)
						{
							continue;
						}
						this.YieldDefault(1);
						if (156483 - 154571 != 1912)
						{
							continue;
						}
						goto IL_1B9;
					default:
						if (149878 - 403881 != -254003)
						{
							continue;
						}
						break;
					}
					Debug.Log("Start Game");
					if (130473 - 141989 == -11516)
					{
						Game.mGameState = eGameState.Start;
						if (96166 - 337151 != -240984)
						{
							Game.mStateTime = Time.time;
							if (284699 - 521765 != -237065)
							{
								this.$mGameGui$42898 = (GameGui)this.$self_$42899.GetComponent(typeof(GameGui));
								if (76354 - 133837 == -57483)
								{
									this.$mGameGui$42898.enabled = true;
									if (39963 - 217387 != -177423)
									{
										this.$self_$42899.SendMessage("fadeIn");
										if (51265 - 510703 == -459438)
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

			// Token: 0x06009C5C RID: 40028 RVA: 0x012250FC File Offset: 0x012232FC
			internal static bool koRmlSVFHhQ15m0mOf23()
			{
				return true;
			}

			// Token: 0x06009C5D RID: 40029 RVA: 0x01225100 File Offset: 0x01223300
			internal static bool RdtijXVFWNq0MZND7AdM()
			{
				return false;
			}

			// Token: 0x04008F6F RID: 36719
			internal GameGui $mGameGui$42898;

			// Token: 0x04008F70 RID: 36720
			internal M924_LostWoods3 $self_$42899;
		}
	}

	// Token: 0x02001A31 RID: 6705
	[CompilerGenerated]
	[Serializable]
	internal sealed class $onDeadPlayer$42901 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06009C5E RID: 40030 RVA: 0x01225104 File Offset: 0x01223304
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $onDeadPlayer$42901(M924_LostWoods3 self_)
		{
			if (107903 - 101420 != 6484)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (217911 - 289942 != -72030)
				{
					base..ctor();
					if (221388 - 357295 != -135906)
					{
						this.$self_$42906 = self_;
						if (197337 - 178184 != 19154)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x06009C5F RID: 40031 RVA: 0x0122519C File Offset: 0x0122339C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M924_LostWoods3.$onDeadPlayer$42901.$(this.$self_$42906);
		}

		// Token: 0x06009C60 RID: 40032 RVA: 0x012251AC File Offset: 0x012233AC
		internal static bool NebIaMVFA4wM35jF6UdW()
		{
			return true;
		}

		// Token: 0x06009C61 RID: 40033 RVA: 0x012251B0 File Offset: 0x012233B0
		internal static bool qeoSOxVFlyAZq8sKwr3o()
		{
			return false;
		}

		// Token: 0x04008F71 RID: 36721
		internal M924_LostWoods3 $self_$42906;

		// Token: 0x02001A32 RID: 6706
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06009C62 RID: 40034 RVA: 0x012251B4 File Offset: 0x012233B4
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M924_LostWoods3 self_)
			{
				if (268931 - 560355 != -291424)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (139169 - 287817 != -148647)
					{
						base..ctor();
						if (274779 - 330403 != -55623)
						{
							this.$self_$42905 = self_;
							if (224418 - 317713 == -93295)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x06009C63 RID: 40035 RVA: 0x0122524C File Offset: 0x0122344C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (217188 - 63840 != 153349)
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
							goto IL_2D9;
						}
						if (41521 - 338566 == -297044)
						{
							continue;
						}
						if (Game.mGameState == eGameState.Hold)
						{
							if (131563 - 91544 != 40019)
							{
								continue;
							}
							goto IL_2D9;
						}
						IL_18E:
						this.YieldDefault(1);
						if (53496 - 17821 != 35676)
						{
							goto Block_13;
						}
						continue;
						IL_2D9:
						Game.mGameState = eGameState.Hold;
						if (83447 - 48513 == 34935)
						{
							continue;
						}
						this.$mStoryGui$42902 = (StoryGui)this.$self_$42905.GetComponent(typeof(StoryGui));
						if (252533 - 139811 == 112723)
						{
							continue;
						}
						if (this.$mStoryGui$42902)
						{
							if (123954 - 172804 != -48850)
							{
								continue;
							}
							this.$mStoryGui$42902.close();
							if (266803 - 439242 == -172438)
							{
								continue;
							}
						}
						this.$mChangeGui$42903 = (ChangeGui)this.$self_$42905.GetComponent(typeof(ChangeGui));
						if (88027 - 469625 == -381597)
						{
							continue;
						}
						if (this.$mChangeGui$42903)
						{
							if (259723 - 284607 == -24883)
							{
								continue;
							}
							this.$mChangeGui$42903.close();
							if (178316 - 184241 == -5924)
							{
								continue;
							}
						}
						this.$mGameGui$42904 = (GameGui)this.$self_$42905.GetComponent(typeof(GameGui));
						if (162977 - 217595 == -54617)
						{
							continue;
						}
						if (!this.$mGameGui$42904)
						{
							goto IL_18E;
						}
						if (194022 - 431966 != -237944)
						{
							continue;
						}
						if (!this.$mGameGui$42904.enabled)
						{
							if (123602 - 176968 == -53365)
							{
								continue;
							}
							this.$mGameGui$42904.enabled = true;
							if (237029 - 246820 != -9791)
							{
								continue;
							}
						}
						this.$mGameGui$42904.openDeadMenu();
						if (274915 - 148817 != 126099)
						{
							goto IL_18E;
						}
						continue;
					default:
						if (292531 - 549601 == -257069)
						{
							continue;
						}
						break;
					}
					Debug.Log("On Dead Player");
					if (201580 - 204261 != -2680)
					{
						goto Block_15;
					}
				}
				Block_13:
				goto IL_2F9;
				Block_15:
				return this.Yield(2, new WaitForSeconds((float)2));
				IL_2F9:
				return false;
			}

			// Token: 0x06009C64 RID: 40036 RVA: 0x01225564 File Offset: 0x01223764
			internal static bool iEblbaVFyVr6wLQE0m7U()
			{
				return true;
			}

			// Token: 0x06009C65 RID: 40037 RVA: 0x01225568 File Offset: 0x01223768
			internal static bool HaNj3KVFSjJb2HJwCwgh()
			{
				return false;
			}

			// Token: 0x04008F72 RID: 36722
			internal StoryGui $mStoryGui$42902;

			// Token: 0x04008F73 RID: 36723
			internal ChangeGui $mChangeGui$42903;

			// Token: 0x04008F74 RID: 36724
			internal GameGui $mGameGui$42904;

			// Token: 0x04008F75 RID: 36725
			internal M924_LostWoods3 $self_$42905;
		}
	}

	// Token: 0x02001A33 RID: 6707
	[CompilerGenerated]
	[Serializable]
	internal sealed class $ReturnToTown$42907 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06009C66 RID: 40038 RVA: 0x0122556C File Offset: 0x0122376C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $ReturnToTown$42907(M924_LostWoods3 self_)
		{
			if (271435 - 133622 != 137814)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (268819 - 593873 != -325053)
				{
					base..ctor();
					if (230212 - 12112 == 218100)
					{
						this.$self_$42911 = self_;
						if (167980 - 522320 == -354340)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x06009C67 RID: 40039 RVA: 0x01225604 File Offset: 0x01223804
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M924_LostWoods3.$ReturnToTown$42907.$(this.$self_$42911);
		}

		// Token: 0x06009C68 RID: 40040 RVA: 0x01225614 File Offset: 0x01223814
		internal static bool hd55iLVFowXROgyIfYx0()
		{
			return true;
		}

		// Token: 0x06009C69 RID: 40041 RVA: 0x01225618 File Offset: 0x01223818
		internal static bool A09ALmVFEIXXNXZyIdLQ()
		{
			return false;
		}

		// Token: 0x04008F76 RID: 36726
		internal M924_LostWoods3 $self_$42911;

		// Token: 0x02001A34 RID: 6708
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06009C6A RID: 40042 RVA: 0x0122561C File Offset: 0x0122381C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M924_LostWoods3 self_)
			{
				if (124344 - 317903 != -193558)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (233280 - 279178 == -45898)
					{
						base..ctor();
						if (124577 - 100161 == 24416)
						{
							this.$self_$42910 = self_;
							if (116826 - 286357 == -169531)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x06009C6B RID: 40043 RVA: 0x012256B4 File Offset: 0x012238B4
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (73684 - 278949 != -205265)
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
						this.$self_$42910.LeaveGame();
						if (91679 - 296274 != -204595)
						{
							continue;
						}
						this.YieldDefault(1);
						if (97057 - 455507 != -358449)
						{
							goto Block_14;
						}
						continue;
					default:
						if (153741 - 432579 == -278837)
						{
							continue;
						}
						break;
					}
					Game.mGameState = eGameState.Ended;
					if (131786 - 284092 == -152306)
					{
						Game.mStateTime = Time.time;
						if (241421 - 53899 != 187523)
						{
							this.$$switch$7821$42908 = PlayerData.SaveGuild;
							if (231556 - 40418 == 191138)
							{
								if (this.$$switch$7821$42908 == 1)
								{
									if (54449 - 98494 != -44045)
									{
										continue;
									}
									Game.mNextGameCode = 32;
									if (124883 - 568132 != -443249)
									{
										continue;
									}
								}
								else if (this.$$switch$7821$42908 == 2)
								{
									if (215958 - 211214 != 4744)
									{
										continue;
									}
									Game.mNextGameCode = 33;
									if (98682 - 399401 != -300719)
									{
										continue;
									}
								}
								else if (this.$$switch$7821$42908 == 3)
								{
									if (41123 - 517143 == -476019)
									{
										continue;
									}
									Game.mNextGameCode = 34;
									if (70091 - 389002 == -318910)
									{
										continue;
									}
								}
								else if (this.$$switch$7821$42908 == 4)
								{
									if (173786 - 494845 == -321058)
									{
										continue;
									}
									Game.mNextGameCode = 35;
									if (292617 - 35531 != 257086)
									{
										continue;
									}
								}
								else if (this.$$switch$7821$42908 == 5)
								{
									if (184518 - 596232 != -411714)
									{
										continue;
									}
									Game.mNextGameCode = 36;
									if (215942 - 300538 != -84596)
									{
										continue;
									}
								}
								else if (PlayerData.GID == 0)
								{
									if (135549 - 525902 == -390352)
									{
										continue;
									}
									Game.mNextGameCode = 30;
									if (117087 - 169893 != -52806)
									{
										continue;
									}
								}
								else
								{
									Game.mNextGameCode = 31;
									if (39346 - 44943 != -5597)
									{
										continue;
									}
								}
								this.$mGameGui$42909 = (GameGui)this.$self_$42910.GetComponent(typeof(GameGui));
								if (65189 - 330371 == -265182)
								{
									if (this.$mGameGui$42909)
									{
										if (71939 - 32376 != 39563)
										{
											continue;
										}
										this.$mGameGui$42909.close();
										if (116410 - 160040 == -43629)
										{
											continue;
										}
									}
									this.$self_$42910.SendMessage("fadeOut");
									if (49234 - 583212 == -533978)
									{
										goto IL_18B;
									}
								}
							}
						}
					}
				}
				Block_14:
				goto IL_3AD;
				IL_18B:
				return this.Yield(2, new WaitForSeconds((float)1));
				IL_3AD:
				return false;
			}

			// Token: 0x06009C6C RID: 40044 RVA: 0x01225A80 File Offset: 0x01223C80
			internal static bool oh5oBdVF2YIM07RSxG92()
			{
				return true;
			}

			// Token: 0x06009C6D RID: 40045 RVA: 0x01225A84 File Offset: 0x01223C84
			internal static bool a2Oc0XVF8BLX4yVQQYTE()
			{
				return false;
			}

			// Token: 0x04008F77 RID: 36727
			internal int $$switch$7821$42908;

			// Token: 0x04008F78 RID: 36728
			internal GameGui $mGameGui$42909;

			// Token: 0x04008F79 RID: 36729
			internal M924_LostWoods3 $self_$42910;
		}
	}

	// Token: 0x02001A35 RID: 6709
	[CompilerGenerated]
	[Serializable]
	internal sealed class $ReturnToGuild$42912 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06009C6E RID: 40046 RVA: 0x01225A88 File Offset: 0x01223C88
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $ReturnToGuild$42912(M924_LostWoods3 self_)
		{
			if (190900 - 378096 != -187195)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (186302 - 26522 == 159780)
				{
					base..ctor();
					if (284875 - 447050 != -162174)
					{
						this.$self_$42915 = self_;
						if (186767 - 405056 != -218288)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x06009C6F RID: 40047 RVA: 0x01225B20 File Offset: 0x01223D20
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M924_LostWoods3.$ReturnToGuild$42912.$(this.$self_$42915);
		}

		// Token: 0x06009C70 RID: 40048 RVA: 0x01225B30 File Offset: 0x01223D30
		internal static bool g1sJXKVFZIVcv1JeUk9q()
		{
			return true;
		}

		// Token: 0x06009C71 RID: 40049 RVA: 0x01225B34 File Offset: 0x01223D34
		internal static bool Bt1In8VFCyT9BS2EIROo()
		{
			return false;
		}

		// Token: 0x04008F7A RID: 36730
		internal M924_LostWoods3 $self_$42915;

		// Token: 0x02001A36 RID: 6710
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06009C72 RID: 40050 RVA: 0x01225B38 File Offset: 0x01223D38
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M924_LostWoods3 self_)
			{
				if (191432 - 467506 != -276074)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (121026 - 68617 != 52410)
					{
						base..ctor();
						if (93774 - 8283 != 85492)
						{
							this.$self_$42914 = self_;
							if (52572 - 201676 != -149103)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x06009C73 RID: 40051 RVA: 0x01225BD0 File Offset: 0x01223DD0
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (135287 - 284684 != -149396)
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
						this.$self_$42914.LeaveGame();
						if (242769 - 547747 == -304977)
						{
							continue;
						}
						this.YieldDefault(1);
						if (259622 - 218094 != 41528)
						{
							continue;
						}
						goto IL_1BD;
					default:
						if (174395 - 244675 == -70279)
						{
							continue;
						}
						break;
					}
					Game.mGameState = eGameState.Ended;
					if (41656 - 143648 == -101992)
					{
						Game.mStateTime = Time.time;
						if (286331 - 430425 != -144093)
						{
							Game.mNextGameCode = 31;
							if (288852 - 407295 == -118443)
							{
								this.$mGameGui$42913 = (GameGui)this.$self_$42914.GetComponent(typeof(GameGui));
								if (47897 - 133898 != -86000)
								{
									if (this.$mGameGui$42913)
									{
										if (94841 - 308549 != -213708)
										{
											continue;
										}
										this.$mGameGui$42913.close();
										if (4496 - 77970 != -73474)
										{
											continue;
										}
									}
									this.$self_$42914.SendMessage("fadeOut");
									if (258395 - 257304 == 1091)
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

			// Token: 0x06009C74 RID: 40052 RVA: 0x01225DAC File Offset: 0x01223FAC
			internal static bool SLO1vaVFL9HnuuDAjYqD()
			{
				return true;
			}

			// Token: 0x06009C75 RID: 40053 RVA: 0x01225DB0 File Offset: 0x01223FB0
			internal static bool F7M4lBVFOoWiIPpYFIvV()
			{
				return false;
			}

			// Token: 0x04008F7B RID: 36731
			internal GameGui $mGameGui$42913;

			// Token: 0x04008F7C RID: 36732
			internal M924_LostWoods3 $self_$42914;
		}
	}

	// Token: 0x02001A37 RID: 6711
	[CompilerGenerated]
	[Serializable]
	internal sealed class $ReturnToCamp$42916 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06009C76 RID: 40054 RVA: 0x01225DB4 File Offset: 0x01223FB4
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $ReturnToCamp$42916(M924_LostWoods3 self_)
		{
			if (47011 - 136561 != -89550)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (246197 - 51428 == 194769)
				{
					base..ctor();
					if (151663 - 540740 != -389076)
					{
						this.$self_$42920 = self_;
						if (31933 - 453643 != -421709)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x06009C77 RID: 40055 RVA: 0x01225E4C File Offset: 0x0122404C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M924_LostWoods3.$ReturnToCamp$42916.$(this.$self_$42920);
		}

		// Token: 0x06009C78 RID: 40056 RVA: 0x01225E5C File Offset: 0x0122405C
		internal static bool psex5dVFmnOBfRrTid1U()
		{
			return true;
		}

		// Token: 0x06009C79 RID: 40057 RVA: 0x01225E60 File Offset: 0x01224060
		internal static bool McJkvqVFFfowcjp081dR()
		{
			return false;
		}

		// Token: 0x04008F7D RID: 36733
		internal M924_LostWoods3 $self_$42920;

		// Token: 0x02001A38 RID: 6712
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06009C7A RID: 40058 RVA: 0x01225E64 File Offset: 0x01224064
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M924_LostWoods3 self_)
			{
				if (237877 - 324728 != -86851)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (215481 - 351260 == -135779)
					{
						base..ctor();
						if (294887 - 170005 != 124883)
						{
							this.$self_$42919 = self_;
							if (95488 - 415400 != -319911)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x06009C7B RID: 40059 RVA: 0x01225EFC File Offset: 0x012240FC
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (72085 - 538619 != -466534)
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
						this.$self_$42919.LeaveGame();
						if (151406 - 184581 != -33175)
						{
							continue;
						}
						this.YieldDefault(1);
						if (124301 - 268521 != -144219)
						{
							goto Block_8;
						}
						continue;
					default:
						if (295180 - 515714 != -220534)
						{
							continue;
						}
						break;
					}
					Game.mGameState = eGameState.Ended;
					if (91936 - 405408 != -313471)
					{
						Game.mStateTime = Time.time;
						if (47082 - 584122 != -537039)
						{
							this.$$switch$7823$42917 = PlayerData.SaveGuild;
							if (81528 - 17004 == 64524)
							{
								if (this.$$switch$7823$42917 == 1)
								{
									if (141794 - 407178 == -265383)
									{
										continue;
									}
									Game.mNextGameCode = 32;
									if (273329 - 254065 != 19264)
									{
										continue;
									}
								}
								else if (this.$$switch$7823$42917 == 2)
								{
									if (191487 - 387592 == -196104)
									{
										continue;
									}
									Game.mNextGameCode = 33;
									if (145074 - 527308 != -382234)
									{
										continue;
									}
								}
								else if (this.$$switch$7823$42917 == 3)
								{
									if (282924 - 499821 != -216897)
									{
										continue;
									}
									Game.mNextGameCode = 34;
									if (12930 - 350961 != -338031)
									{
										continue;
									}
								}
								else if (this.$$switch$7823$42917 == 4)
								{
									if (298944 - 415585 == -116640)
									{
										continue;
									}
									Game.mNextGameCode = 35;
									if (15647 - 148660 != -133013)
									{
										continue;
									}
								}
								else if (this.$$switch$7823$42917 == 5)
								{
									if (267017 - 142499 == 124519)
									{
										continue;
									}
									Game.mNextGameCode = 36;
									if (155966 - 413808 == -257841)
									{
										continue;
									}
								}
								else
								{
									Game.mNextGameCode = 30;
									if (72421 - 8750 != 63671)
									{
										continue;
									}
								}
								this.$mGameGui$42918 = (GameGui)this.$self_$42919.GetComponent(typeof(GameGui));
								if (191685 - 588725 == -397040)
								{
									if (this.$mGameGui$42918)
									{
										if (100792 - 243494 == -142701)
										{
											continue;
										}
										this.$mGameGui$42918.close();
										if (41938 - 239606 == -197667)
										{
											continue;
										}
									}
									this.$self_$42919.SendMessage("fadeOut");
									if (124313 - 10647 != 113667)
									{
										goto Block_27;
									}
								}
							}
						}
					}
				}
				Block_8:
				goto IL_363;
				Block_27:
				return this.Yield(2, new WaitForSeconds((float)1));
				IL_363:
				return false;
			}

			// Token: 0x06009C7C RID: 40060 RVA: 0x01226280 File Offset: 0x01224480
			internal static bool DbOpwoVFMBDXpb1OQvIY()
			{
				return true;
			}

			// Token: 0x06009C7D RID: 40061 RVA: 0x01226284 File Offset: 0x01224484
			internal static bool MpbXsPVFxLlyVdgqwSLW()
			{
				return false;
			}

			// Token: 0x04008F7E RID: 36734
			internal int $$switch$7823$42917;

			// Token: 0x04008F7F RID: 36735
			internal GameGui $mGameGui$42918;

			// Token: 0x04008F80 RID: 36736
			internal M924_LostWoods3 $self_$42919;
		}
	}
}
