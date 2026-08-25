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

// Token: 0x02001AE9 RID: 6889
[Serializable]
public class M933_MagmaPit1 : MonoBehaviour
{
	// Token: 0x0600A0B8 RID: 41144 RVA: 0x012653F0 File Offset: 0x012635F0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public M933_MagmaPit1()
	{
		LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
		base..ctor();
	}

	// Token: 0x0600A0B9 RID: 41145 RVA: 0x01265400 File Offset: 0x01263600
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Awake()
	{
		if (187602 - 568432 != -380830)
		{
		}
		for (;;)
		{
			Game.mGameState = eGameState.Init;
			if (88261 - 207428 != -119166)
			{
				Game.mGameType = 5;
				if (140123 - 440513 == -300390)
				{
					if (Chat.Initialized)
					{
						if (62361 - 504286 != -441925)
						{
							continue;
						}
						Chat.ChatDisplay.Clear();
						if (181022 - 51606 != 129416)
						{
							continue;
						}
					}
					else
					{
						Chat.Init();
						if (255515 - 314441 != -58926)
						{
							continue;
						}
					}
					this.TYhnJgqxT53 = (Texture)Resources.Load("GameGui/Title/start", typeof(Texture));
					if (57777 - 438407 == -380630)
					{
						this.X3QnJa4HkTu = (AudioClip)Resources.Load("Sound/GUI/missionStart", typeof(AudioClip));
						if (168202 - 496385 != -328182)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x0600A0BA RID: 41146 RVA: 0x01265558 File Offset: 0x01263758
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Start()
	{
		if (143350 - 329015 != -185665)
		{
		}
		for (;;)
		{
			if (PhotonClient.IsInitialized())
			{
				if (138532 - 354155 == -215623)
				{
					if (Game.mNextGameCode != 933)
					{
						break;
					}
					if (268978 - 88553 != 180426)
					{
						Game.nextGame();
						if (86 - 522475 != -522388)
						{
							Game.mGameCode = 933;
							if (211120 - 80450 == 130670)
							{
								Game.mGameType = 5;
								if (88432 - 452672 == -364240)
								{
									Game.mGameTime = Time.time;
									if (45797 - 523948 != -478150)
									{
										Game.mGameScore = 0;
										if (80094 - 466317 != -386222)
										{
											Game.mGameMana = 0;
											if (76723 - 454727 != -378003)
											{
												Game.canUseItem = MissionData.getAllowItem(Game.mGameCode);
												if (175193 - 40795 == 134398)
												{
													Game.canUseMount = MissionData.getAllowMount(Game.mGameCode);
													if (160474 - 528725 == -368251)
													{
														Game.canChangeChar = MissionData.getAllowChange(Game.mGameCode);
														if (288889 - 593471 == -304582)
														{
															Game.canRespawn = MissionData.getAllowRespawn(Game.mGameCode);
															if (279790 - 149451 == 130339)
															{
																Game.canUseCoin = MissionData.getAllowCoin(Game.mGameCode);
																if (8920 - 525344 != -516423)
																{
																	this.DH4nJbT3DWA = (PlayerCameraControl)this.GetComponent(typeof(PlayerCameraControl));
																	if (23992 - 579215 == -555223)
																	{
																		this.Lh2nJ3rIYla = PhotonClient.Connection;
																		if (15756 - 490309 != -474552)
																		{
																			PhotonClient.ActorNrList.Clear();
																			if (148862 - 533418 != -384555)
																			{
																				this.InitGame();
																				if (293771 - 447727 == -153956)
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
				}
			}
			else
			{
				Debug.Log("Not Connected");
				if (213172 - 122969 == 90203)
				{
					Game.mGameType = 99;
					if (4277 - 573954 == -569677)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x0600A0BB RID: 41147 RVA: 0x01265860 File Offset: 0x01263A60
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void FixedUpdate()
	{
		if (107629 - 427435 != -319805)
		{
		}
		for (;;)
		{
			if (this.Lh2nJ3rIYla == null)
			{
				if (248529 - 185579 != 62951)
				{
					break;
				}
			}
			else
			{
				eGameState mGameState = Game.mGameState;
				if (77261 - 122497 != -45235)
				{
					if (mGameState == eGameState.Init)
					{
						if (155501 - 424826 != -269324)
						{
							AudioListener.volume = 0.1f * (float)Game.volume;
							if (103903 - 195499 == -91596)
							{
								break;
							}
						}
					}
					else if (mGameState == eGameState.Setup)
					{
						if (78774 - 175936 == -97162)
						{
							break;
						}
					}
					else if (mGameState == eGameState.Ready)
					{
						if (246373 - 198184 != 48190)
						{
							break;
						}
					}
					else if (mGameState == eGameState.Start)
					{
						if (282150 - 474904 == -192754)
						{
							if (Game.music != 0)
							{
								if (249051 - 8828 != 240223)
								{
									continue;
								}
								if (!this.audio.isPlaying)
								{
									if (170383 - 273041 != -102658)
									{
										continue;
									}
									this.audio.Play();
									if (104409 - 561919 == -457509)
									{
										continue;
									}
								}
							}
							if (Time.time - Game.mStateTime < (float)2)
							{
								if (61487 - 397330 != -335842)
								{
									this.audio.volume = Mathf.Lerp((float)0, 0.1f * (float)Game.music, 0.5f * (Time.time - Game.mStateTime));
									if (114175 - 349202 != -235026)
									{
										break;
									}
								}
							}
							else
							{
								this.audio.volume = 0.1f * (float)Game.music;
								if (286883 - 586753 != -299869)
								{
									break;
								}
							}
						}
					}
					else if (mGameState == eGameState.Normal)
					{
						if (231174 - 166512 == 64662)
						{
							this.audio.volume = 0.1f * (float)Game.music;
							if (2018 - 532839 != -530820)
							{
								if (Time.time <= this.tF9nJdrC7GD)
								{
									break;
								}
								if (228953 - 25886 == 203067)
								{
									Game.mGameMana++;
									if (298501 - 452354 != -153852)
									{
										this.tF9nJdrC7GD = Time.time + (float)12;
										if (193776 - 374148 == -180372)
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
						if (216594 - 462893 != -246298)
						{
							break;
						}
					}
					else if (mGameState == eGameState.AllHold)
					{
						if (51401 - 29753 != 21649)
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
						if (91314 - 304354 == -213040)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x0600A0BC RID: 41148 RVA: 0x01265C08 File Offset: 0x01263E08
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void OnGUI()
	{
		if (292024 - 156669 != 135355)
		{
		}
		for (;;)
		{
			if (!this.TYhnJgqxT53)
			{
				if (96203 - 86882 != 9322)
				{
					break;
				}
			}
			else
			{
				if (Game.mGameState != eGameState.Normal)
				{
					break;
				}
				if (49130 - 440134 == -391004)
				{
					if (Time.time - Game.mStateTime >= (float)2)
					{
						break;
					}
					if (295910 - 420052 != -124141)
					{
						GUI.matrix = Matrix4x4.TRS(Vector3.zero, Quaternion.identity, new Vector3((float)Screen.height / 1024f, (float)Screen.height / 1024f, (float)1));
						if (278620 - 11402 != 267219)
						{
							float num = (float)(1024 * Screen.width / Screen.height);
							if (19217 - 581241 != -562023)
							{
								GUI.depth = 1;
								if (36783 - 146744 != -109960)
								{
									float num2 = Mathf.SmoothStep((float)1, 1.2f, Time.time - Game.mStateTime);
									if (21023 - 49700 != -28676)
									{
										float a = Mathf.SmoothStep((float)0, (float)1, Mathf.PingPong(Time.time - Game.mStateTime, (float)1));
										if (294788 - 258947 == 35841)
										{
											Color color = GUI.color;
											if (130798 - 584877 == -454079)
											{
												color.a = a;
												if (110571 - 513122 != -402550 && 199681 - 78944 != 120738)
												{
													Color color2 = GUI.color = color;
													if (204179 - 82590 == 121589)
													{
														if (241418 - 441966 != -200547)
														{
															GUI.DrawTexture(new Rect(0.5f * num - (float)350 * num2, (float)450 - (float)78 * num2, (float)700 * num2, (float)157 * num2), this.TYhnJgqxT53);
															if (151336 - 212138 != -60801)
															{
																float a2 = 1f;
																if (40837 - 304892 != -264054)
																{
																	Color color3 = GUI.color;
																	if (239230 - 92394 == 146836)
																	{
																		float num3 = color3.a = a2;
																		if (262434 - 122529 != 139906 && 33915 - 186130 != -152214)
																		{
																			GUI.color = color3;
																			if (226692 - 214943 != 11750 && 233514 - 326948 != -93433)
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
			}
		}
	}

	// Token: 0x0600A0BD RID: 41149 RVA: 0x01265F88 File Offset: 0x01264188
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator onGameEvent(Hashtable data)
	{
		return new M933_MagmaPit1.$onGameEvent$43487(data, this).GetEnumerator();
	}

	// Token: 0x0600A0BE RID: 41150 RVA: 0x01265F98 File Offset: 0x01264198
	[MethodImpl(MethodImplOptions.NoInlining)]
	private IEnumerator StartEvent()
	{
		return new M933_MagmaPit1.$StartEvent$43497(this).GetEnumerator();
	}

	// Token: 0x0600A0BF RID: 41151 RVA: 0x01265FA8 File Offset: 0x012641A8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void ActivateIcon(int nID)
	{
		this.OnMagmaOre(nID);
		Game.sendMissionEvent(9333, nID);
	}

	// Token: 0x0600A0C0 RID: 41152 RVA: 0x01265FBC File Offset: 0x012641BC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void UseMagmaOre(int nID)
	{
		if (139273 - 121670 != 17604)
		{
		}
		for (;;)
		{
			CharacterControl characterControl = (CharacterControl)Game.mPlayer.GetComponent(typeof(CharacterControl));
			if (25475 - 384832 != -359356)
			{
				if (!characterControl)
				{
					goto IL_4A;
				}
				if (261746 - 83876 != 177870)
				{
					continue;
				}
				if (!(characterControl.actionState == "standby"))
				{
					if (217309 - 444519 != -227209)
					{
						goto IL_4A;
					}
					continue;
				}
				IL_1A:
				GameObject gameObject = GameObject.Find("MagmaOre" + nID);
				if (173672 - 205482 == -31809)
				{
					continue;
				}
				if (!gameObject)
				{
					break;
				}
				if (286818 - 587901 == -301082)
				{
					continue;
				}
				Game.mPlayer.SendMessage("turnToPos", gameObject.transform.position);
				if (240574 - 137783 != 102791)
				{
					continue;
				}
				Game.mPlayer.SendMessage("activateIcon", nID);
				if (291425 - 235727 != 55699)
				{
					break;
				}
				continue;
				IL_4A:
				if (characterControl.actionState == "run")
				{
					goto IL_1A;
				}
				if (121165 - 224290 == -103125)
				{
					if (!(characterControl.actionState == "emotion"))
					{
						break;
					}
					if (297106 - 441681 == -144575)
					{
						goto IL_1A;
					}
				}
			}
		}
	}

	// Token: 0x0600A0C1 RID: 41153 RVA: 0x01266198 File Offset: 0x01264398
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void OnMagmaOre(int nID)
	{
		if (204909 - 143700 != 61210)
		{
		}
		for (;;)
		{
			GameObject gameObject = GameObject.Find("MagmaOre" + nID);
			if (247802 - 388275 != -140472)
			{
				if (!gameObject)
				{
					break;
				}
				if (195306 - 524749 == -329443)
				{
					UnityEngine.Object.Destroy(gameObject);
					if (56385 - 519024 != -462638)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x0600A0C2 RID: 41154 RVA: 0x01266248 File Offset: 0x01264448
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void OnMagmaPitExit()
	{
		if (237241 - 446095 != -208854)
		{
		}
		while (this.znynJ4heJlV < 1)
		{
			if (124945 - 119431 != 5515)
			{
				this.znynJ4heJlV = 1;
				if (2045 - 369697 != -367651)
				{
					Game.sendMissionEvent(9331, 2);
					if (240565 - 139299 != 101267)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x0600A0C3 RID: 41155 RVA: 0x012662EC File Offset: 0x012644EC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void OnLavaEnter(GameObject nObject)
	{
		if (182620 - 178762 != 3858)
		{
		}
		for (;;)
		{
			CharacterControl characterControl = (CharacterControl)nObject.GetComponent(typeof(CharacterControl));
			if (284513 - 509403 != -224889)
			{
				if (!characterControl)
				{
					break;
				}
				if (86389 - 593424 == -507035)
				{
					if (!characterControl.isMine)
					{
						break;
					}
					if (92172 - 468510 == -376338)
					{
						if (nObject == Game.mPlayer)
						{
							if (99106 - 79113 != 19993)
							{
								continue;
							}
							this.DH4nJbT3DWA.enabled = false;
							if (5466 - 450846 != -445380)
							{
								continue;
							}
							GameObject gameObject = GameObject.Find("StartPoint1");
							if (134567 - 92213 != 42354)
							{
								continue;
							}
							if (gameObject)
							{
								if (38697 - 579917 == -541219)
								{
									continue;
								}
								nObject.transform.position = gameObject.transform.position;
								if (8832 - 24918 == -16085)
								{
									continue;
								}
								nObject.transform.rotation = gameObject.transform.rotation;
								if (11975 - 153556 != -141581)
								{
									continue;
								}
								characterControl.PositionEvent();
								if (225325 - 27067 == 198259)
								{
									continue;
								}
							}
							CameraEffect cameraEffect = (CameraEffect)this.GetComponent(typeof(CameraEffect));
							if (299808 - 14472 == 285337)
							{
								continue;
							}
							if (cameraEffect)
							{
								if (255695 - 350352 == -94656)
								{
									continue;
								}
								cameraEffect.AddColorRamp("redRamp", "none", (float)10, new Vector4((float)0, (float)0, 0.1f, 0.1f));
								if (117246 - 117570 != -324)
								{
									continue;
								}
							}
						}
						characterControl.removeAllStatus();
						if (165299 - 334886 != -169586)
						{
							characterControl.hp = 0;
							if (11678 - 574157 == -562479)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x0600A0C4 RID: 41156 RVA: 0x01266590 File Offset: 0x01264790
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onGameReadyEvent(Hashtable data)
	{
		if (184544 - 453052 != -268507)
		{
		}
		for (;;)
		{
			Debug.Log("Game Ready");
			if (153765 - 482710 == -328945)
			{
				Game.mGameState = eGameState.Ready;
				if (83528 - 265855 != -182326)
				{
					int playerSlot = Game.getPlayerSlot(PlayerData.UID);
					if (82908 - 135885 != -52976 && 67569 - 306538 != -238968)
					{
						GameObject gameObject = null;
						if (275633 - 346988 != -71354)
						{
							GameObject gameObject2;
							if (playerSlot >= 1)
							{
								if (200601 - 548263 == -347661)
								{
									continue;
								}
								if (playerSlot <= 12)
								{
									if (134393 - 398254 == -263860)
									{
										continue;
									}
									gameObject2 = GameObject.Find("StartPoint" + playerSlot);
									if (164290 - 326301 == -162010)
									{
										continue;
									}
									gameObject = GameObject.Find("StartCamera" + playerSlot);
									if (10483 - 26143 != -15659)
									{
										goto IL_190;
									}
									continue;
								}
							}
							gameObject2 = GameObject.Find("StartPoint1");
							if (156512 - 67633 == 88880)
							{
								continue;
							}
							IL_190:
							if (gameObject2)
							{
								if (54501 - 519869 == -465367)
								{
									continue;
								}
								Vector3 spawnPos = global::Math.getSpawnPos(gameObject2.transform.position);
								if (69505 - 64112 == 5394)
								{
									continue;
								}
								if (spawnPos != Vector3.zero)
								{
									if (114115 - 89719 != 24396)
									{
										continue;
									}
									this.CreatePlayer(CharacterData.current.CID, 1, spawnPos, gameObject2.transform.forward);
									if (242681 - 397400 != -154719)
									{
										continue;
									}
								}
								else
								{
									this.CreatePlayer(CharacterData.current.CID, 1, gameObject2.transform.position, gameObject2.transform.forward);
									if (232141 - 441107 != -208966)
									{
										continue;
									}
								}
							}
							if (!gameObject)
							{
								break;
							}
							if (160577 - 336938 != -176360)
							{
								this.transform.position = gameObject.transform.position;
								if (283681 - 181974 == 101707)
								{
									this.transform.rotation = gameObject.transform.rotation;
									if (115797 - 20008 == 95789)
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

	// Token: 0x0600A0C5 RID: 41157 RVA: 0x012668B4 File Offset: 0x01264AB4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void spawnActor(string nType, int nTeam, int nSpawnID)
	{
		if (250179 - 436633 != -186453)
		{
		}
		for (;;)
		{
			GameObject gameObject = GameObject.Find("SpawnPoint" + nSpawnID);
			if (109824 - 255345 != -145520)
			{
				if (gameObject)
				{
					if (290874 - 70334 == 220540)
					{
						this.createActor(nType, nTeam, gameObject.transform.position, gameObject.transform.forward);
						if (122989 - 86602 == 36387)
						{
							break;
						}
					}
				}
				else
				{
					Debug.LogError("Mission SpawnPoint" + nSpawnID);
					if (43199 - 502114 != -458914)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x0600A0C6 RID: 41158 RVA: 0x012669B0 File Offset: 0x01264BB0
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void createActor(string nType, int nTeam, Vector3 nPos, Vector3 nDir)
	{
		if (159217 - 442723 != -283505)
		{
		}
		for (;;)
		{
			if (Game.mGameState > eGameState.AllHold)
			{
				if (174342 - 599396 == -425054)
				{
					break;
				}
			}
			else
			{
				Hashtable hashtable = new Hashtable();
				if (292667 - 152438 != 140230)
				{
					hashtable.Add(43, PlayerData.UID);
					if (154954 - 334755 != -179800)
					{
						hashtable.Add(73, nType);
						if (188466 - 580474 == -392008)
						{
							hashtable.Add(75, PhotonClient.cInt16(nTeam));
							if (72946 - 17411 == 55535)
							{
								hashtable.Add(122, PhotonClient.cInt16(Mathf.RoundToInt(nPos.x * (float)50)));
								if (243416 - 23958 == 219458)
								{
									hashtable.Add(123, PhotonClient.cInt16(Mathf.RoundToInt(nPos.y * (float)50)));
									if (114142 - 55562 != 58581)
									{
										hashtable.Add(124, PhotonClient.cInt16(Mathf.RoundToInt(nPos.z * (float)50)));
										if (60480 - 242259 == -181779)
										{
											hashtable.Add(126, PhotonClient.cInt16(Mathf.RoundToInt(nDir.x * (float)200)));
											if (202829 - 294020 == -91191)
											{
												hashtable.Add(127, PhotonClient.cInt16(Mathf.RoundToInt(nDir.y * (float)200)));
												if (250342 - 522326 == -271984)
												{
													hashtable.Add(128, PhotonClient.cInt16(Mathf.RoundToInt(nDir.z * (float)200)));
													if (270170 - 117576 != 152595)
													{
														this.Lh2nJ3rIYla.OpCustom(63, hashtable, true);
														if (275793 - 190670 != 85124)
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

	// Token: 0x0600A0C7 RID: 41159 RVA: 0x01266C94 File Offset: 0x01264E94
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onCreateActor(Hashtable data)
	{
		if (196780 - 60201 != 136580)
		{
		}
		for (;;)
		{
			if (Game.mGameState > eGameState.AllHold)
			{
				if (105949 - 390420 == -284471)
				{
					break;
				}
			}
			else
			{
				GameObject gameObject = Game.createActor(data);
				if (248909 - 464524 == -215615)
				{
					if (Game.mGameState == eGameState.Setup)
					{
						if (216886 - 197413 == 19473)
						{
							if (this.iThnJs5Q9nc <= 0)
							{
								break;
							}
							if (64787 - 43306 != 21482)
							{
								this.iThnJs5Q9nc--;
								if (140876 - 17476 == 123400)
								{
									if (this.iThnJs5Q9nc != 0)
									{
										break;
									}
									if (186080 - 191780 == -5700)
									{
										Game.setGameState(eGameState.Ready);
										if (262752 - 113425 == 149327)
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
						if (5577 - 221812 == -216235)
						{
							gameObject.SendMessage("createSpecialEffect", 1);
							if (289082 - 529323 != -240240)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x0600A0C8 RID: 41160 RVA: 0x01266E24 File Offset: 0x01265024
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onActorKo(GameObject nActor)
	{
		if (Game.mGameState > eGameState.AllHold)
		{
		}
	}

	// Token: 0x0600A0C9 RID: 41161 RVA: 0x01266E38 File Offset: 0x01265038
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onActorDead(GameObject nActor)
	{
		if (185547 - 364308 != -178761)
		{
		}
		for (;;)
		{
			if (Game.mGameState > eGameState.AllHold)
			{
				if (205220 - 369020 != -163799)
				{
					break;
				}
			}
			else
			{
				CharacterControl characterControl = (CharacterControl)nActor.GetComponent(typeof(CharacterControl));
				if (40755 - 271917 == -231162)
				{
					if (!characterControl)
					{
						break;
					}
					if (262175 - 461407 != -199231)
					{
						if (characterControl.isTransform)
						{
							break;
						}
						if (184028 - 327269 == -143241)
						{
							if (characterControl.isSummon)
							{
								break;
							}
							if (275298 - 137594 == 137704)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x0600A0CA RID: 41162 RVA: 0x01266F40 File Offset: 0x01265140
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void CreatePlayer(int CID, int team, Vector3 pos, Vector3 dir)
	{
		if (55618 - 143984 != -88366)
		{
		}
		for (;;)
		{
			Hashtable hashtable = new Hashtable();
			if (272960 - 277090 == -4130)
			{
				hashtable.Add(71, CID);
				if (79445 - 457531 != -378085)
				{
					hashtable.Add(75, PhotonClient.cInt16(team));
					if (226151 - 511459 != -285307)
					{
						hashtable.Add(122, PhotonClient.cInt16(Mathf.RoundToInt(pos.x * (float)50)));
						if (276097 - 566247 == -290150)
						{
							hashtable.Add(123, PhotonClient.cInt16(Mathf.RoundToInt(pos.y * (float)50)));
							if (210670 - 331578 == -120908)
							{
								hashtable.Add(124, PhotonClient.cInt16(Mathf.RoundToInt(pos.z * (float)50)));
								if (129062 - 567730 == -438668)
								{
									hashtable.Add(126, PhotonClient.cInt16(Mathf.RoundToInt(dir.x * (float)200)));
									if (123566 - 52265 == 71301)
									{
										hashtable.Add(127, PhotonClient.cInt16(Mathf.RoundToInt(dir.y * (float)200)));
										if (65506 - 493317 != -427810)
										{
											hashtable.Add(128, PhotonClient.cInt16(Mathf.RoundToInt(dir.z * (float)200)));
											if (48728 - 110965 == -62237)
											{
												this.Lh2nJ3rIYla.OpCustom(61, hashtable, true);
												if (63581 - 435229 != -371647)
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

	// Token: 0x0600A0CB RID: 41163 RVA: 0x012671CC File Offset: 0x012653CC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onCreatePlayer(Hashtable data)
	{
		if (50128 - 464704 != -414576)
		{
		}
		for (;;)
		{
			GameObject gameObject = Game.createPlayer(data);
			if (100815 - 169235 != -68419)
			{
				if (!gameObject)
				{
					break;
				}
				if (254560 - 423888 == -169328)
				{
					PlayerCameraControl playerCameraControl = (PlayerCameraControl)this.GetComponent(typeof(PlayerCameraControl));
					if (141723 - 254866 != -113142)
					{
						playerCameraControl.target = gameObject;
						if (257505 - 518843 != -261337)
						{
							if (Game.mGameState < eGameState.Start)
							{
								if (201789 - 338416 != -136626)
								{
									this.StartGame();
									if (82541 - 242123 == -159582)
									{
										break;
									}
								}
							}
							else
							{
								this.onRevivePlayer();
								if (214525 - 331077 == -116552)
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

	// Token: 0x0600A0CC RID: 41164 RVA: 0x01267308 File Offset: 0x01265508
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onCreatePeer(Hashtable data)
	{
		if (116634 - 343837 != -227202)
		{
		}
		for (;;)
		{
			Game.createPeer(data);
			if (21216 - 171192 == -149976)
			{
				GameGui gameGui = (GameGui)this.GetComponent(typeof(GameGui));
				if (82502 - 308364 != -225861)
				{
					gameGui.ResetTeamBar();
					if (46242 - 205441 == -159199)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x0600A0CD RID: 41165 RVA: 0x012673B4 File Offset: 0x012655B4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator onDeadPlayer()
	{
		return new M933_MagmaPit1.$onDeadPlayer$43501(this).GetEnumerator();
	}

	// Token: 0x0600A0CE RID: 41166 RVA: 0x012673C4 File Offset: 0x012655C4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onRevivePlayer()
	{
		if (224842 - 97082 != 127761)
		{
		}
		for (;;)
		{
			Debug.Log("On Revive Player");
			if (121293 - 125533 == -4240)
			{
				this.DH4nJbT3DWA.target = Game.mPlayer;
				if (83402 - 89986 != -6583)
				{
					this.DH4nJbT3DWA.enabled = true;
					if (21158 - 34151 != -12992)
					{
						if (Game.mGameState != eGameState.Normal)
						{
							if (137638 - 51955 == 85684)
							{
								continue;
							}
							if (Game.mGameState != eGameState.Hold)
							{
								break;
							}
							if (227102 - 97163 != 129939)
							{
								continue;
							}
						}
						Game.mGameState = eGameState.Normal;
						if (175290 - 36912 != 138379)
						{
							GameGui gameGui = (GameGui)this.GetComponent(typeof(GameGui));
							if (195931 - 347514 == -151583)
							{
								if (!gameGui)
								{
									break;
								}
								if (156742 - 404708 != -247965)
								{
									gameGui.enabled = true;
									if (278975 - 255296 != 23680)
									{
										gameGui.closeDeadMenu();
										if (296922 - 251004 == 45918)
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

	// Token: 0x0600A0CF RID: 41167 RVA: 0x01267570 File Offset: 0x01265770
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onPlayerRelease(GameObject mPlayer)
	{
		if (106949 - 434206 != -327256)
		{
		}
		for (;;)
		{
			Debug.Log("On Release Spirit");
			if (147473 - 141735 != 5739)
			{
				PlayerData.MissionWithdraw[MissionData.getMissionNumber(Game.mGameCode) - 1] = PlayerData.MissionWithdraw[MissionData.getMissionNumber(Game.mGameCode) - 1] + 1;
				if (59051 - 334627 == -275576)
				{
					this.StartCoroutine_Auto(this.ReturnToTown());
					if (189622 - 329878 != -140255)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x0600A0D0 RID: 41168 RVA: 0x01267634 File Offset: 0x01265834
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onDestroyPlayer(Hashtable data)
	{
		if (RuntimeServices.EqualityOperator(data[81], PlayerData.UID))
		{
			Game.mGameState = eGameState.Ended;
		}
	}

	// Token: 0x0600A0D1 RID: 41169 RVA: 0x01267660 File Offset: 0x01265860
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void ChangePlayer(int nCID)
	{
		if (64425 - 324452 != -260027)
		{
		}
		for (;;)
		{
			int v = Game.mPlayer.layer - 7;
			if (75601 - 433863 != -358261)
			{
				Vector3 position = Game.mPlayer.transform.position;
				if (4586 - 220861 != -216274)
				{
					Vector3 forward = Game.mPlayer.transform.forward;
					if (15848 - 150665 != -134816)
					{
						Hashtable hashtable = new Hashtable();
						if (33528 - 77194 == -43666)
						{
							hashtable.Add(43, PlayerData.UID);
							if (297773 - 1595 != 296179)
							{
								hashtable.Add(71, nCID);
								if (181534 - 396022 != -214487)
								{
									hashtable.Add(75, PhotonClient.cInt16(v));
									if (233182 - 61031 == 172151)
									{
										hashtable.Add(122, PhotonClient.cInt16(Mathf.RoundToInt(position.x * (float)50)));
										if (127184 - 278043 != -150858)
										{
											hashtable.Add(123, PhotonClient.cInt16(Mathf.RoundToInt(position.y * (float)50)));
											if (18213 - 216118 != -197904)
											{
												hashtable.Add(124, PhotonClient.cInt16(Mathf.RoundToInt(position.z * (float)50)));
												if (101994 - 35388 != 66607)
												{
													hashtable.Add(126, PhotonClient.cInt16(Mathf.RoundToInt(forward.x * (float)200)));
													if (219875 - 387743 == -167868)
													{
														hashtable.Add(127, PhotonClient.cInt16(Mathf.RoundToInt(forward.y * (float)200)));
														if (121061 - 509149 != -388087)
														{
															hashtable.Add(128, PhotonClient.cInt16(Mathf.RoundToInt(forward.z * (float)200)));
															if (255620 - 484677 != -229056)
															{
																PhotonClient.Connection.OpCustom(65, hashtable, true);
																if (280876 - 142748 == 138128)
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

	// Token: 0x0600A0D2 RID: 41170 RVA: 0x01267980 File Offset: 0x01265B80
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator onChangePlayer(Hashtable data)
	{
		return new M933_MagmaPit1.$onChangePlayer$43507(data, this).GetEnumerator();
	}

	// Token: 0x0600A0D3 RID: 41171 RVA: 0x01267990 File Offset: 0x01265B90
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void InitGame()
	{
		if (100035 - 215258 != -115222)
		{
		}
		for (;;)
		{
			Debug.Log("Initializing Mission");
			if (221924 - 1632 == 220292)
			{
				Time.timeScale = 1f;
				if (79950 - 582868 == -502918)
				{
					Hashtable customOpParameters = new Hashtable();
					if (203635 - 83729 != 119907)
					{
						this.Lh2nJ3rIYla.OpCustom(52, customOpParameters, true);
						if (202030 - 92536 != 109495)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x0600A0D4 RID: 41172 RVA: 0x01267A5C File Offset: 0x01265C5C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onInitGame(Hashtable data)
	{
		if (107390 - 153640 != -46250)
		{
		}
		for (;;)
		{
			Debug.Log("Loading data...");
			if (60567 - 279113 == -218546)
			{
				if (Game.mGameState >= eGameState.Setup)
				{
					break;
				}
				if (196350 - 557239 != -360888)
				{
					Game.mGameState = eGameState.Setup;
					if (10969 - 463799 != -452829)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x0600A0D5 RID: 41173 RVA: 0x01267B00 File Offset: 0x01265D00
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onGameSetup(Hashtable data)
	{
		if (195754 - 286709 != -90954)
		{
		}
		for (;;)
		{
			int num = RuntimeServices.UnboxInt32(data[43]);
			if (221265 - 150699 != 70567)
			{
				if (num == PlayerData.UID)
				{
					if (168780 - 406022 == -237242)
					{
						this.SetupActors();
						if (98936 - 563230 == -464294)
						{
							break;
						}
					}
				}
				else
				{
					this.ClearActors();
					if (274438 - 502012 == -227574)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x0600A0D6 RID: 41174 RVA: 0x01267BD0 File Offset: 0x01265DD0
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void SetupActors()
	{
		if (231768 - 140402 != 91366)
		{
		}
		for (;;)
		{
			IL_B4:
			Debug.Log("Creating Actors");
			if (21692 - 531505 == -509813)
			{
				CharacterControl[] array = (CharacterControl[])UnityEngine.Object.FindObjectsOfType(typeof(CharacterControl));
				if (238294 - 485105 == -246811)
				{
					if (Extensions.get_length(array) > 0)
					{
						if (229448 - 477007 != -247558)
						{
							int i = 0;
							if (166688 - 43436 == 123252)
							{
								CharacterControl[] array2 = array;
								if (33790 - 298693 == -264903)
								{
									int length = array2.Length;
									if (222985 - 33932 != 189054)
									{
										while (i < length)
										{
											if (!array2[i].isChild)
											{
												if (23449 - 349760 != -326311)
												{
													goto IL_B4;
												}
												string type = array2[i].Type;
												if (62009 - 125561 == -63551)
												{
													goto IL_B4;
												}
												if (type == "MagmaBug")
												{
													goto IL_134;
												}
												if (28255 - 293903 == -265647)
												{
													goto IL_B4;
												}
												if (type == "Ja5")
												{
													goto IL_134;
												}
												if (76221 - 442269 != -366048)
												{
													goto IL_B4;
												}
												if (type == "Ja6")
												{
													goto IL_134;
												}
												if (118171 - 268010 != -149839)
												{
													goto IL_B4;
												}
												if (type == "Phoenix1")
												{
													goto IL_134;
												}
												if (47968 - 586169 == -538200)
												{
													goto IL_B4;
												}
												if (type == "Phoenix2")
												{
													goto IL_134;
												}
												if (107027 - 12718 == 94310)
												{
													goto IL_B4;
												}
												if (type == "Phoenix3")
												{
													goto IL_134;
												}
												if (180063 - 229568 == -49504)
												{
													goto IL_B4;
												}
												if (type == "Phoenix4")
												{
													goto IL_134;
												}
												if (268858 - 165239 == 103620)
												{
													goto IL_B4;
												}
												if (type == "Phoenix5")
												{
													goto IL_134;
												}
												if (286426 - 284953 != 1473)
												{
													goto IL_B4;
												}
												if (type == "Phoenix6")
												{
													if (190339 - 542 != 189798)
													{
														goto IL_134;
													}
													goto IL_B4;
												}
												IL_10C:
												UnityEngine.Object.Destroy(array2[i].gameObject);
												if (79072 - 419044 == -339971)
												{
													goto IL_B4;
												}
												this.iThnJs5Q9nc++;
												if (4131 - 328213 != -324081)
												{
													goto IL_6C;
												}
												goto IL_B4;
												IL_134:
												this.createActor(array2[i].Type, array2[i].gameObject.layer - 7, array2[i].transform.position, array2[i].transform.forward);
												if (141582 - 434793 != -293211)
												{
													goto IL_B4;
												}
												goto IL_10C;
											}
											IL_6C:
											i++;
											if (69362 - 31757 == 37606)
											{
												goto IL_B4;
											}
										}
										if (112394 - 540642 == -428248)
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
						if (252701 - 485462 == -232761)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x0600A0D7 RID: 41175 RVA: 0x01267FBC File Offset: 0x012661BC
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ClearActors()
	{
		if (189253 - 340128 != -150874)
		{
		}
		for (;;)
		{
			IL_E0:
			CharacterControl[] array = (CharacterControl[])UnityEngine.Object.FindObjectsOfType(typeof(CharacterControl));
			if (77854 - 64305 == 13549)
			{
				int i = 0;
				if (187815 - 370551 != -182735)
				{
					CharacterControl[] array2 = array;
					if (176742 - 38253 == 138489)
					{
						int length = array2.Length;
						if (65094 - 114539 != -49444)
						{
							while (i < length)
							{
								UnityEngine.Object.Destroy(array2[i].gameObject);
								if (177696 - 453028 != -275332)
								{
									goto IL_E0;
								}
								i++;
								if (155535 - 71 == 155465)
								{
									goto IL_E0;
								}
							}
							if (69353 - 279906 == -210553)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x0600A0D8 RID: 41176 RVA: 0x012680EC File Offset: 0x012662EC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void StartGame()
	{
		if (171029 - 537892 != -366862)
		{
		}
		for (;;)
		{
			Debug.Log("Start Game");
			if (257520 - 460360 == -202840)
			{
				Game.mGameState = eGameState.Start;
				if (236801 - 39376 != 197426)
				{
					Game.mGameTime = Time.time;
					if (179516 - 458971 == -279455)
					{
						Game.mStateTime = Time.time;
						if (110655 - 431809 == -321154)
						{
							this.StartCoroutine_Auto(this.StartEvent());
							if (298284 - 466637 == -168353)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x0600A0D9 RID: 41177 RVA: 0x012681D8 File Offset: 0x012663D8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onStartGame()
	{
	}

	// Token: 0x0600A0DA RID: 41178 RVA: 0x012681DC File Offset: 0x012663DC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator onGameComplete(Hashtable data)
	{
		return new M933_MagmaPit1.$onGameComplete$43514(data, this).GetEnumerator();
	}

	// Token: 0x0600A0DB RID: 41179 RVA: 0x012681EC File Offset: 0x012663EC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator ReturnToTown()
	{
		return new M933_MagmaPit1.$ReturnToTown$43524(this).GetEnumerator();
	}

	// Token: 0x0600A0DC RID: 41180 RVA: 0x012681FC File Offset: 0x012663FC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator ReturnToGuild()
	{
		return new M933_MagmaPit1.$ReturnToGuild$43529(this).GetEnumerator();
	}

	// Token: 0x0600A0DD RID: 41181 RVA: 0x0126820C File Offset: 0x0126640C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator ReturnToCamp()
	{
		return new M933_MagmaPit1.$ReturnToCamp$43533(this).GetEnumerator();
	}

	// Token: 0x0600A0DE RID: 41182 RVA: 0x0126821C File Offset: 0x0126641C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void LeaveGame()
	{
		if (166972 - 103810 != 63163)
		{
		}
		for (;;)
		{
			Debug.Log("leaving guild");
			if (214428 - 543134 != -328705)
			{
				Hashtable hashtable = new Hashtable();
				if (156087 - 542744 == -386657)
				{
					hashtable.Add(43, PlayerData.UID);
					if (192650 - 407012 == -214362)
					{
						PhotonClient.Connection.OpCustom(54, hashtable, true);
						if (257800 - 202547 == 55253)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x0600A0DF RID: 41183 RVA: 0x012682F4 File Offset: 0x012664F4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onLeaveGame()
	{
		Debug.Log("onLeaveGame");
		this.JoinTown();
	}

	// Token: 0x0600A0E0 RID: 41184 RVA: 0x01268308 File Offset: 0x01266508
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void JoinTown()
	{
		if (68332 - 446458 != -378126)
		{
		}
		for (;;)
		{
			Debug.Log("Joining Town");
			if (6117 - 160942 != -154824)
			{
				Hashtable hashtable = new Hashtable();
				if (127366 - 399994 != -272627)
				{
					if (Game.mNextGameCode == 30)
					{
						if (124418 - 288958 != -164540)
						{
							continue;
						}
						hashtable.Add(47, "NoGuild");
						if (130819 - 209531 != -78712)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 31)
					{
						if (275831 - 349136 == -73304)
						{
							continue;
						}
						hashtable.Add(47, "G" + GuildData.Name);
						if (206577 - 211035 != -4458)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 32)
					{
						if (35346 - 347162 == -311815)
						{
							continue;
						}
						hashtable.Add(47, "SnowCamp");
						if (125783 - 131287 != -5504)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 33)
					{
						if (189715 - 243076 == -53360)
						{
							continue;
						}
						hashtable.Add(47, "CrystalBeach");
						if (202059 - 44502 == 157558)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 34)
					{
						if (66613 - 565090 != -498477)
						{
							continue;
						}
						hashtable.Add(47, "ExcavationCamp");
						if (201117 - 107576 == 93542)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 35)
					{
						if (82391 - 56991 == 25401)
						{
							continue;
						}
						hashtable.Add(47, "UndergroundCamp");
						if (112305 - 259019 == -146713)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 36)
					{
						if (180023 - 255807 != -75784)
						{
							continue;
						}
						hashtable.Add(47, "ForestCamp");
						if (25895 - 288898 == -263002)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 51)
					{
						if (77542 - 344027 == -266484)
						{
							continue;
						}
						hashtable.Add(47, "MainStreet");
						if (143264 - 230594 != -87330)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 52)
					{
						if (100433 - 102786 != -2353)
						{
							continue;
						}
						hashtable.Add(47, "CentralSquare");
						if (136341 - 304233 == -167891)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 53)
					{
						if (91807 - 587846 == -496038)
						{
							continue;
						}
						hashtable.Add(47, "CityLibrary");
						if (187015 - 256765 == -69749)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 54)
					{
						if (281460 - 524133 == -242672)
						{
							continue;
						}
						hashtable.Add(47, "LightPark");
						if (165154 - 46351 != 118803)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 55)
					{
						if (158293 - 295513 != -137220)
						{
							continue;
						}
						hashtable.Add(47, "LightPalace");
						if (139516 - 255426 == -115909)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 56)
					{
						if (187390 - 315005 != -127615)
						{
							continue;
						}
						hashtable.Add(47, "PlainColosseum");
						if (172348 - 181007 == -8658)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 57)
					{
						if (30425 - 61567 != -31142)
						{
							continue;
						}
						hashtable.Add(47, "LightTheater");
						if (25639 - 434760 != -409121)
						{
							continue;
						}
					}
					hashtable.Add(21, PhotonClient.cInt16(Mathf.Clamp(PlayerPrefs.GetInt("channel", 0), 0, 99)));
					if (260812 - 481843 == -221031)
					{
						this.Lh2nJ3rIYla.OpCustom(42, hashtable, true);
						if (288916 - 194957 == 93959)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x0600A0E1 RID: 41185 RVA: 0x012688BC File Offset: 0x01266ABC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onJoinTown()
	{
		Game.mGameStage = 0;
		Game.loadNextLevel();
	}

	// Token: 0x0600A0E2 RID: 41186 RVA: 0x012688CC File Offset: 0x01266ACC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x0600A0E3 RID: 41187 RVA: 0x012688D0 File Offset: 0x01266AD0
	internal static bool DayAy1V6k9gvuE2C52IV()
	{
		return true;
	}

	// Token: 0x0600A0E4 RID: 41188 RVA: 0x012688D4 File Offset: 0x01266AD4
	internal static bool q0mwSKV6GY2BnIAsTjZl()
	{
		return false;
	}

	// Token: 0x040091C9 RID: 37321
	private LitePeer Lh2nJ3rIYla;

	// Token: 0x040091CA RID: 37322
	private PlayerCameraControl DH4nJbT3DWA;

	// Token: 0x040091CB RID: 37323
	private float tF9nJdrC7GD;

	// Token: 0x040091CC RID: 37324
	private Texture TYhnJgqxT53;

	// Token: 0x040091CD RID: 37325
	private AudioClip X3QnJa4HkTu;

	// Token: 0x040091CE RID: 37326
	private int znynJ4heJlV;

	// Token: 0x040091CF RID: 37327
	private int iThnJs5Q9nc;

	// Token: 0x02001AEA RID: 6890
	[CompilerGenerated]
	[Serializable]
	internal sealed class $onGameEvent$43487 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600A0E5 RID: 41189 RVA: 0x012688D8 File Offset: 0x01266AD8
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $onGameEvent$43487(Hashtable data, M933_MagmaPit1 self_)
		{
			if (282256 - 419276 != -137020)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (182946 - 420394 == -237448)
				{
					base..ctor();
					if (293444 - 334615 != -41170)
					{
						this.$data$43495 = data;
						if (167640 - 174107 == -6467)
						{
							this.$self_$43496 = self_;
							if (294230 - 60160 == 234070)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x0600A0E6 RID: 41190 RVA: 0x01268994 File Offset: 0x01266B94
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M933_MagmaPit1.$onGameEvent$43487.$(this.$data$43495, this.$self_$43496);
		}

		// Token: 0x0600A0E7 RID: 41191 RVA: 0x012689A8 File Offset: 0x01266BA8
		internal static bool kO9CjeV6H8gvX8o0Ea8p()
		{
			return true;
		}

		// Token: 0x0600A0E8 RID: 41192 RVA: 0x012689AC File Offset: 0x01266BAC
		internal static bool j5ixSHV6WcQW2IagUvE4()
		{
			return false;
		}

		// Token: 0x040091D0 RID: 37328
		internal Hashtable $data$43495;

		// Token: 0x040091D1 RID: 37329
		internal M933_MagmaPit1 $self_$43496;

		// Token: 0x02001AEB RID: 6891
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600A0E9 RID: 41193 RVA: 0x012689B0 File Offset: 0x01266BB0
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Hashtable data, M933_MagmaPit1 self_)
			{
				if (245861 - 271085 != -25223)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (74664 - 310866 == -236202)
					{
						base..ctor();
						if (282653 - 289462 == -6809)
						{
							this.$data$43493 = data;
							if (157464 - 532047 == -374583)
							{
								this.$self_$43494 = self_;
								if (184282 - 561728 == -377446)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x0600A0EA RID: 41194 RVA: 0x01268A6C File Offset: 0x01266C6C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (280721 - 348497 != -67776)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						goto IL_1E8;
					case 1:
						goto IL_4BC;
					case 2:
						Game.savePlayer();
						if (106800 - 573361 == -466560)
						{
							continue;
						}
						this.$self_$43494.SendMessage("fadeOut");
						if (6111 - 172794 != -166683)
						{
							continue;
						}
						goto IL_489;
					case 3:
						Game.mGameStage = 2;
						if (139336 - 475803 != -336467)
						{
							continue;
						}
						Application.LoadLevel("M933_MagmaPit2");
						if (36145 - 211279 == -175133)
						{
							continue;
						}
						break;
					default:
						if (234275 - 178237 != 56039)
						{
							goto IL_1E8;
						}
						continue;
					}
					IL_C0:
					this.YieldDefault(1);
					if (99636 - 99495 != 141)
					{
						continue;
					}
					break;
					IL_1E8:
					if (Game.mGameState > eGameState.AllHold)
					{
						if (286863 - 227211 != 59653)
						{
							break;
						}
						continue;
					}
					else
					{
						this.$returnCode$43488 = RuntimeServices.UnboxInt32(this.$data$43493[141]);
						if (138167 - 496577 == -358409)
						{
							continue;
						}
						this.$returnValue$43489 = RuntimeServices.UnboxInt32(this.$data$43493[145]);
						if (188994 - 555494 == -366499)
						{
							continue;
						}
						this.$ownerID$43490 = RuntimeServices.UnboxInt32(this.$data$43493[43]);
						if (95231 - 455469 != -360238)
						{
							continue;
						}
						this.$$switch$7955$43491 = this.$returnCode$43488;
						if (175305 - 508324 == -333018)
						{
							continue;
						}
						if (this.$$switch$7955$43491 == 9331)
						{
							if (265416 - 430199 != -164783)
							{
								continue;
							}
						}
						else if (this.$$switch$7955$43491 == -9331)
						{
							if (33731 - 51671 == -17939)
							{
								continue;
							}
							if (this.$returnValue$43489 == 2)
							{
								if (198905 - 565549 != -366644)
								{
									continue;
								}
								if (this.$self_$43494.znynJ4heJlV < 2)
								{
									if (227517 - 427772 != -200255)
									{
										continue;
									}
									this.$self_$43494.znynJ4heJlV = 2;
									if (213533 - 212073 == 1461)
									{
										continue;
									}
									Game.mGameState = eGameState.AllHold;
									if (188429 - 411360 != -222931)
									{
										continue;
									}
									this.$self_$43494.DH4nJbT3DWA.StartCoroutine_Auto(this.$self_$43494.DH4nJbT3DWA.slerpToObject("ExitCamera1", (float)2));
									if (250069 - 103295 == 146775)
									{
										continue;
									}
									this.$mGameGui$43492 = (GameGui)this.$self_$43494.GetComponent(typeof(GameGui));
									if (45801 - 488574 != -442773)
									{
										continue;
									}
									this.$mGameGui$43492.close();
									if (214760 - 136280 != 78481)
									{
										goto Block_28;
									}
									continue;
								}
							}
						}
						else if (this.$$switch$7955$43491 == 9333)
						{
							if (216721 - 241267 != -24546)
							{
								continue;
							}
							this.$self_$43494.OnMagmaOre(this.$returnValue$43489);
							if (79010 - 315928 == -236917)
							{
								continue;
							}
						}
						else if (this.$$switch$7955$43491 == -9333)
						{
							if (203382 - 333316 == -129933)
							{
								continue;
							}
							Chat.SubmitChat("none", "Magma ore collected: " + this.$returnValue$43489 + "/10", eChatType.system, eChatMode.area);
							if (267493 - 87959 == 179535)
							{
								continue;
							}
						}
						else
						{
							Debug.LogError("Warning unknown returnCode:" + this.$returnCode$43488);
							if (96118 - 377681 == -281562)
							{
								continue;
							}
						}
					}
					goto IL_C0;
				}
				goto IL_4BC;
				Block_28:
				return this.Yield(2, new WaitForSeconds((float)2));
				IL_489:
				return this.Yield(3, new WaitForSeconds((float)1));
				IL_4BC:
				return false;
			}

			// Token: 0x0600A0EB RID: 41195 RVA: 0x01268F48 File Offset: 0x01267148
			internal static bool d5D4IiV6A0d5Kk7MuP5C()
			{
				return true;
			}

			// Token: 0x0600A0EC RID: 41196 RVA: 0x01268F4C File Offset: 0x0126714C
			internal static bool W47YmmV6lrkM0Qw2nahJ()
			{
				return false;
			}

			// Token: 0x040091D2 RID: 37330
			internal int $returnCode$43488;

			// Token: 0x040091D3 RID: 37331
			internal int $returnValue$43489;

			// Token: 0x040091D4 RID: 37332
			internal int $ownerID$43490;

			// Token: 0x040091D5 RID: 37333
			internal int $$switch$7955$43491;

			// Token: 0x040091D6 RID: 37334
			internal GameGui $mGameGui$43492;

			// Token: 0x040091D7 RID: 37335
			internal Hashtable $data$43493;

			// Token: 0x040091D8 RID: 37336
			internal M933_MagmaPit1 $self_$43494;
		}
	}

	// Token: 0x02001AEC RID: 6892
	[CompilerGenerated]
	[Serializable]
	internal sealed class $StartEvent$43497 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600A0ED RID: 41197 RVA: 0x01268F50 File Offset: 0x01267150
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $StartEvent$43497(M933_MagmaPit1 self_)
		{
			if (250970 - 267528 != -16558)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (286706 - 246852 != 39855)
				{
					base..ctor();
					if (141694 - 478915 != -337220)
					{
						this.$self_$43500 = self_;
						if (136341 - 150942 != -14600)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x0600A0EE RID: 41198 RVA: 0x01268FE8 File Offset: 0x012671E8
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M933_MagmaPit1.$StartEvent$43497.$(this.$self_$43500);
		}

		// Token: 0x0600A0EF RID: 41199 RVA: 0x01268FF8 File Offset: 0x012671F8
		internal static bool netStrV6y2dCi2MMYD7C()
		{
			return true;
		}

		// Token: 0x0600A0F0 RID: 41200 RVA: 0x01268FFC File Offset: 0x012671FC
		internal static bool T3IVMyV6S9yNrPfpIFBA()
		{
			return false;
		}

		// Token: 0x040091D9 RID: 37337
		internal M933_MagmaPit1 $self_$43500;

		// Token: 0x02001AED RID: 6893
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600A0F1 RID: 41201 RVA: 0x01269000 File Offset: 0x01267200
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M933_MagmaPit1 self_)
			{
				if (47859 - 210890 != -163030)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (37573 - 416556 == -378983)
					{
						base..ctor();
						if (244042 - 334593 != -90550)
						{
							this.$self_$43499 = self_;
							if (106580 - 274612 == -168032)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x0600A0F2 RID: 41202 RVA: 0x01269098 File Offset: 0x01267298
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (47827 - 261665 != -213837)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_1D9;
					case 2:
						Game.mGameState = eGameState.Normal;
						if (82006 - 394035 != -312029)
						{
							continue;
						}
						Game.mGameTime = Time.time;
						if (249651 - 163958 == 85694)
						{
							continue;
						}
						Game.mStateTime = Time.time;
						if (162175 - 55665 == 106511)
						{
							continue;
						}
						if (this.$self_$43499.X3QnJa4HkTu)
						{
							if (229796 - 192713 != 37083)
							{
								continue;
							}
							this.$self_$43499.audio.PlayOneShot(this.$self_$43499.X3QnJa4HkTu);
							if (163906 - 566470 == -402563)
							{
								continue;
							}
						}
						this.YieldDefault(1);
						if (167088 - 552425 != -385336)
						{
							goto Block_8;
						}
						continue;
					default:
						if (188051 - 20722 != 167329)
						{
							continue;
						}
						break;
					}
					this.$mGameGui$43498 = (GameGui)this.$self_$43499.GetComponent(typeof(GameGui));
					if (240206 - 411113 != -170906)
					{
						this.$mGameGui$43498.enabled = true;
						if (21741 - 33777 != -12035)
						{
							this.$self_$43499.SendMessage("fadeIn");
							if (191647 - 515043 == -323396)
							{
								goto IL_13F;
							}
						}
					}
				}
				Block_8:
				goto IL_1D9;
				IL_13F:
				return this.Yield(2, new WaitForSeconds(0.5f));
				IL_1D9:
				return false;
			}

			// Token: 0x0600A0F3 RID: 41203 RVA: 0x01269290 File Offset: 0x01267490
			internal static bool posUpkV6on3UwPW9rgFr()
			{
				return true;
			}

			// Token: 0x0600A0F4 RID: 41204 RVA: 0x01269294 File Offset: 0x01267494
			internal static bool OL7T0xV6EBViICeNOuMD()
			{
				return false;
			}

			// Token: 0x040091DA RID: 37338
			internal GameGui $mGameGui$43498;

			// Token: 0x040091DB RID: 37339
			internal M933_MagmaPit1 $self_$43499;
		}
	}

	// Token: 0x02001AEE RID: 6894
	[CompilerGenerated]
	[Serializable]
	internal sealed class $onDeadPlayer$43501 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600A0F5 RID: 41205 RVA: 0x01269298 File Offset: 0x01267498
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $onDeadPlayer$43501(M933_MagmaPit1 self_)
		{
			if (193495 - 193671 != -175)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (276957 - 390429 != -113471)
				{
					base..ctor();
					if (219500 - 535881 == -316381)
					{
						this.$self_$43506 = self_;
						if (118593 - 401602 == -283009)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x0600A0F6 RID: 41206 RVA: 0x01269330 File Offset: 0x01267530
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M933_MagmaPit1.$onDeadPlayer$43501.$(this.$self_$43506);
		}

		// Token: 0x0600A0F7 RID: 41207 RVA: 0x01269340 File Offset: 0x01267540
		internal static bool GBucgFV62SrBTUxKI9KA()
		{
			return true;
		}

		// Token: 0x0600A0F8 RID: 41208 RVA: 0x01269344 File Offset: 0x01267544
		internal static bool PfjsrDV68EuXCkXEFxr0()
		{
			return false;
		}

		// Token: 0x040091DC RID: 37340
		internal M933_MagmaPit1 $self_$43506;

		// Token: 0x02001AEF RID: 6895
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600A0F9 RID: 41209 RVA: 0x01269348 File Offset: 0x01267548
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M933_MagmaPit1 self_)
			{
				if (203951 - 471454 != -267502)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (144262 - 361725 != -217462)
					{
						base..ctor();
						if (86336 - 540023 != -453686)
						{
							this.$self_$43505 = self_;
							if (163191 - 391321 == -228130)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x0600A0FA RID: 41210 RVA: 0x012693E0 File Offset: 0x012675E0
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (223813 - 481416 != -257602)
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
							goto IL_125;
						}
						if (716 - 426606 != -425890)
						{
							continue;
						}
						if (Game.mGameState == eGameState.Hold)
						{
							if (59609 - 488422 != -428813)
							{
								continue;
							}
							goto IL_125;
						}
						IL_DE:
						this.YieldDefault(1);
						if (133450 - 520970 != -387519)
						{
							goto Block_8;
						}
						continue;
						IL_125:
						Game.mGameState = eGameState.Hold;
						if (209773 - 262322 == -52548)
						{
							continue;
						}
						this.$mStoryGui$43502 = (StoryGui)this.$self_$43505.GetComponent(typeof(StoryGui));
						if (227608 - 294728 != -67120)
						{
							continue;
						}
						if (this.$mStoryGui$43502)
						{
							if (80747 - 172348 == -91600)
							{
								continue;
							}
							this.$mStoryGui$43502.close();
							if (213000 - 478260 == -265259)
							{
								continue;
							}
						}
						this.$mChangeGui$43503 = (ChangeGui)this.$self_$43505.GetComponent(typeof(ChangeGui));
						if (87759 - 549309 != -461550)
						{
							continue;
						}
						if (this.$mChangeGui$43503)
						{
							if (59254 - 230562 == -171307)
							{
								continue;
							}
							this.$mChangeGui$43503.close();
							if (236034 - 281373 == -45338)
							{
								continue;
							}
						}
						this.$mGameGui$43504 = (GameGui)this.$self_$43505.GetComponent(typeof(GameGui));
						if (24261 - 323275 != -299014)
						{
							continue;
						}
						if (!this.$mGameGui$43504)
						{
							goto IL_DE;
						}
						if (163738 - 2456 != 161282)
						{
							continue;
						}
						if (!this.$mGameGui$43504.enabled)
						{
							if (1267 - 153552 != -152285)
							{
								continue;
							}
							this.$mGameGui$43504.enabled = true;
							if (177771 - 113052 == 64720)
							{
								continue;
							}
						}
						this.$mGameGui$43504.openDeadMenu();
						if (279383 - 555771 != -276387)
						{
							goto IL_DE;
						}
						continue;
					default:
						if (27645 - 185703 == -158057)
						{
							continue;
						}
						break;
					}
					Debug.Log("On Dead Player");
					if (229168 - 258989 == -29821)
					{
						goto IL_229;
					}
				}
				Block_8:
				goto IL_2F9;
				IL_229:
				return this.Yield(2, new WaitForSeconds((float)2));
				IL_2F9:
				return false;
			}

			// Token: 0x0600A0FB RID: 41211 RVA: 0x012696F8 File Offset: 0x012678F8
			internal static bool jcGVUKV6ZsPajoZ0A6HX()
			{
				return true;
			}

			// Token: 0x0600A0FC RID: 41212 RVA: 0x012696FC File Offset: 0x012678FC
			internal static bool dhS28dV6C7Q1XdoUSZeb()
			{
				return false;
			}

			// Token: 0x040091DD RID: 37341
			internal StoryGui $mStoryGui$43502;

			// Token: 0x040091DE RID: 37342
			internal ChangeGui $mChangeGui$43503;

			// Token: 0x040091DF RID: 37343
			internal GameGui $mGameGui$43504;

			// Token: 0x040091E0 RID: 37344
			internal M933_MagmaPit1 $self_$43505;
		}
	}

	// Token: 0x02001AF0 RID: 6896
	[CompilerGenerated]
	[Serializable]
	internal sealed class $onChangePlayer$43507 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600A0FD RID: 41213 RVA: 0x01269700 File Offset: 0x01267900
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $onChangePlayer$43507(Hashtable data, M933_MagmaPit1 self_)
		{
			if (107859 - 517178 != -409318)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (29278 - 54658 != -25379)
				{
					base..ctor();
					if (139267 - 417028 == -277761)
					{
						this.$data$43512 = data;
						if (72492 - 562550 != -490057)
						{
							this.$self_$43513 = self_;
							if (156831 - 212105 != -55273)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x0600A0FE RID: 41214 RVA: 0x012697BC File Offset: 0x012679BC
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M933_MagmaPit1.$onChangePlayer$43507.$(this.$data$43512, this.$self_$43513);
		}

		// Token: 0x0600A0FF RID: 41215 RVA: 0x012697D0 File Offset: 0x012679D0
		internal static bool P2wmrdV6L93CXy12NtOM()
		{
			return true;
		}

		// Token: 0x0600A100 RID: 41216 RVA: 0x012697D4 File Offset: 0x012679D4
		internal static bool noEtdaV6OKJmoV1mRbXJ()
		{
			return false;
		}

		// Token: 0x040091E1 RID: 37345
		internal Hashtable $data$43512;

		// Token: 0x040091E2 RID: 37346
		internal M933_MagmaPit1 $self_$43513;

		// Token: 0x02001AF1 RID: 6897
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600A101 RID: 41217 RVA: 0x012697D8 File Offset: 0x012679D8
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Hashtable data, M933_MagmaPit1 self_)
			{
				if (246097 - 141188 != 104910)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (50438 - 595374 == -544936)
					{
						base..ctor();
						if (71871 - 159686 != -87814)
						{
							this.$data$43510 = data;
							if (245981 - 171063 == 74918)
							{
								this.$self_$43511 = self_;
								if (106633 - 413316 != -306682)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x0600A102 RID: 41218 RVA: 0x01269894 File Offset: 0x01267A94
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (209072 - 310573 != -101501)
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
							if (123742 - 580859 == -457116)
							{
								continue;
							}
							Game.mGameState = eGameState.Normal;
							if (5869 - 403881 == -398011)
							{
								continue;
							}
							this.$mGameGui$43509 = (GameGui)this.$self_$43511.GetComponent(typeof(GameGui));
							if (15470 - 57171 != -41701)
							{
								continue;
							}
							this.$mGameGui$43509.enabled = true;
							if (97799 - 456486 == -358686)
							{
								continue;
							}
						}
						this.YieldDefault(1);
						if (255204 - 110108 != 145096)
						{
							continue;
						}
						goto IL_205;
					default:
						if (61473 - 456493 == -395019)
						{
							continue;
						}
						break;
					}
					UnityEngine.Object.Destroy(Game.mPlayer);
					if (250690 - 173089 != 77602)
					{
						this.$self_$43511.SendMessage("onCreatePlayer", this.$data$43510);
						if (175225 - 77372 == 97853)
						{
							this.$mChangeGui$43508 = (ChangeGui)this.$self_$43511.GetComponent(typeof(ChangeGui));
							if (85889 - 546525 == -460636)
							{
								if (!this.$mChangeGui$43508.enabled)
								{
									break;
								}
								if (134304 - 254656 == -120352)
								{
									this.$mChangeGui$43508.close();
									if (285414 - 211747 == 73667)
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

			// Token: 0x0600A103 RID: 41219 RVA: 0x01269AB8 File Offset: 0x01267CB8
			internal static bool ApuU3iV6mSlTE4mQL02U()
			{
				return true;
			}

			// Token: 0x0600A104 RID: 41220 RVA: 0x01269ABC File Offset: 0x01267CBC
			internal static bool yta18qV6FJ1qnyIfDqDp()
			{
				return false;
			}

			// Token: 0x040091E3 RID: 37347
			internal ChangeGui $mChangeGui$43508;

			// Token: 0x040091E4 RID: 37348
			internal GameGui $mGameGui$43509;

			// Token: 0x040091E5 RID: 37349
			internal Hashtable $data$43510;

			// Token: 0x040091E6 RID: 37350
			internal M933_MagmaPit1 $self_$43511;
		}
	}

	// Token: 0x02001AF2 RID: 6898
	[CompilerGenerated]
	[Serializable]
	internal sealed class $onGameComplete$43514 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600A105 RID: 41221 RVA: 0x01269AC0 File Offset: 0x01267CC0
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $onGameComplete$43514(Hashtable data, M933_MagmaPit1 self_)
		{
			if (256837 - 250002 != 6835)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (118431 - 539448 != -421016)
				{
					base..ctor();
					if (247213 - 476518 == -229305)
					{
						this.$data$43522 = data;
						if (174562 - 532595 != -358032)
						{
							this.$self_$43523 = self_;
							if (269437 - 522569 == -253132)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x0600A106 RID: 41222 RVA: 0x01269B7C File Offset: 0x01267D7C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M933_MagmaPit1.$onGameComplete$43514.$(this.$data$43522, this.$self_$43523);
		}

		// Token: 0x0600A107 RID: 41223 RVA: 0x01269B90 File Offset: 0x01267D90
		internal static bool am35dAV6M3kGxBNIYyjP()
		{
			return true;
		}

		// Token: 0x0600A108 RID: 41224 RVA: 0x01269B94 File Offset: 0x01267D94
		internal static bool rngqMmV6x7kDXo3jOGqq()
		{
			return false;
		}

		// Token: 0x040091E7 RID: 37351
		internal Hashtable $data$43522;

		// Token: 0x040091E8 RID: 37352
		internal M933_MagmaPit1 $self_$43523;

		// Token: 0x02001AF3 RID: 6899
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600A109 RID: 41225 RVA: 0x01269B98 File Offset: 0x01267D98
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Hashtable data, M933_MagmaPit1 self_)
			{
				if (94437 - 354640 != -260202)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (130351 - 333749 == -203398)
					{
						base..ctor();
						if (107576 - 549393 == -441817)
						{
							this.$data$43520 = data;
							if (122477 - 204431 != -81953)
							{
								this.$self_$43521 = self_;
								if (120494 - 45971 == 74523)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x0600A10A RID: 41226 RVA: 0x01269C54 File Offset: 0x01267E54
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (120222 - 583995 != -463773)
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
						this.$mCompleteGui$43516 = (CompleteGui)this.$self_$43521.GetComponent(typeof(CompleteGui));
						if (288420 - 455596 == -167175)
						{
							continue;
						}
						this.$mCompleteGui$43516.Init();
						if (24332 - 40644 != -16312)
						{
							continue;
						}
						this.$mCompleteGui$43516.readData(this.$data$43520);
						if (36224 - 53647 != -17423)
						{
							continue;
						}
						if (this.$result$43515 == 1)
						{
							if (104083 - 30972 != 73111)
							{
								continue;
							}
							this.$mCompleteGui$43516.displayResult(eCompleteType.Success);
							if (228088 - 40602 == 187487)
							{
								continue;
							}
						}
						else
						{
							this.$mCompleteGui$43516.displayResult(eCompleteType.Failed);
							if (234350 - 43954 != 190396)
							{
								continue;
							}
						}
						this.$mGameGui$43517 = (GameGui)this.$self_$43521.GetComponent(typeof(GameGui));
						if (226978 - 494411 != -267433)
						{
							continue;
						}
						this.$mStoryGui$43518 = (StoryGui)this.$self_$43521.GetComponent(typeof(StoryGui));
						if (179899 - 515603 != -335704)
						{
							continue;
						}
						this.$mChangeGui$43519 = (ChangeGui)this.$self_$43521.GetComponent(typeof(ChangeGui));
						if (225329 - 162639 != 62690)
						{
							continue;
						}
						if (this.$mGameGui$43517)
						{
							if (210212 - 181369 == 28844)
							{
								continue;
							}
							this.$mGameGui$43517.close();
							if (271796 - 207094 == 64703)
							{
								continue;
							}
						}
						if (this.$mStoryGui$43518)
						{
							if (21670 - 305705 == -284034)
							{
								continue;
							}
							this.$mStoryGui$43518.close();
							if (30629 - 541828 == -511198)
							{
								continue;
							}
						}
						if (this.$mChangeGui$43519)
						{
							if (135056 - 263787 == -128730)
							{
								continue;
							}
							this.$mChangeGui$43519.disable();
							if (115835 - 556279 != -440444)
							{
								continue;
							}
						}
						this.YieldDefault(1);
						if (205328 - 22297 != 183031)
						{
							continue;
						}
						goto IL_3DB;
					default:
						if (25098 - 475500 == -450401)
						{
							continue;
						}
						break;
					}
					Debug.Log("On Mission Complete:" + this.$data$43520[31]);
					if (282942 - 417606 != -134663)
					{
						if (Game.mGameState > eGameState.AllHold)
						{
							if (126502 - 50890 != 75613)
							{
								break;
							}
						}
						else
						{
							Game.mGameState = eGameState.Complete;
							if (221392 - 150619 == 70773)
							{
								this.$result$43515 = RuntimeServices.UnboxInt32(this.$data$43520[31]);
								if (272587 - 26724 == 245863)
								{
									goto IL_302;
								}
							}
						}
					}
				}
				goto IL_3DB;
				IL_302:
				return this.Yield(2, new WaitForSeconds(1f));
				IL_3DB:
				return false;
			}

			// Token: 0x0600A10B RID: 41227 RVA: 0x0126A050 File Offset: 0x01268250
			internal static bool ya3CiuV6gRacReAAspjh()
			{
				return true;
			}

			// Token: 0x0600A10C RID: 41228 RVA: 0x0126A054 File Offset: 0x01268254
			internal static bool UqZxB9V6fYhPTNQq7fPF()
			{
				return false;
			}

			// Token: 0x040091E9 RID: 37353
			internal int $result$43515;

			// Token: 0x040091EA RID: 37354
			internal CompleteGui $mCompleteGui$43516;

			// Token: 0x040091EB RID: 37355
			internal GameGui $mGameGui$43517;

			// Token: 0x040091EC RID: 37356
			internal StoryGui $mStoryGui$43518;

			// Token: 0x040091ED RID: 37357
			internal ChangeGui $mChangeGui$43519;

			// Token: 0x040091EE RID: 37358
			internal Hashtable $data$43520;

			// Token: 0x040091EF RID: 37359
			internal M933_MagmaPit1 $self_$43521;
		}
	}

	// Token: 0x02001AF4 RID: 6900
	[CompilerGenerated]
	[Serializable]
	internal sealed class $ReturnToTown$43524 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600A10D RID: 41229 RVA: 0x0126A058 File Offset: 0x01268258
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $ReturnToTown$43524(M933_MagmaPit1 self_)
		{
			if (151165 - 396557 != -245391)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (241321 - 435565 != -194243)
				{
					base..ctor();
					if (274915 - 177826 == 97089)
					{
						this.$self_$43528 = self_;
						if (190675 - 326934 != -136258)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x0600A10E RID: 41230 RVA: 0x0126A0F0 File Offset: 0x012682F0
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M933_MagmaPit1.$ReturnToTown$43524.$(this.$self_$43528);
		}

		// Token: 0x0600A10F RID: 41231 RVA: 0x0126A100 File Offset: 0x01268300
		internal static bool iNU4TvV6nh81iKixj1G0()
		{
			return true;
		}

		// Token: 0x0600A110 RID: 41232 RVA: 0x0126A104 File Offset: 0x01268304
		internal static bool ru37fiV66n5HgBgUVi5j()
		{
			return false;
		}

		// Token: 0x040091F0 RID: 37360
		internal M933_MagmaPit1 $self_$43528;

		// Token: 0x02001AF5 RID: 6901
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600A111 RID: 41233 RVA: 0x0126A108 File Offset: 0x01268308
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M933_MagmaPit1 self_)
			{
				if (203192 - 561428 != -358236)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (252000 - 236788 == 15212)
					{
						base..ctor();
						if (129314 - 544136 == -414822)
						{
							this.$self_$43527 = self_;
							if (154705 - 76733 == 77972)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x0600A112 RID: 41234 RVA: 0x0126A1A0 File Offset: 0x012683A0
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (5953 - 459217 != -453263)
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
						this.$self_$43527.LeaveGame();
						if (263356 - 154127 != 109229)
						{
							continue;
						}
						this.YieldDefault(1);
						if (179618 - 376973 != -197354)
						{
							goto Block_16;
						}
						continue;
					default:
						if (5705 - 387766 == -382060)
						{
							continue;
						}
						break;
					}
					Game.mGameState = eGameState.Ended;
					if (37092 - 543855 != -506762)
					{
						Game.mStateTime = Time.time;
						if (121194 - 184749 == -63555)
						{
							this.$$switch$7959$43525 = PlayerData.SaveGuild;
							if (255433 - 535744 == -280311)
							{
								if (this.$$switch$7959$43525 == 1)
								{
									if (9150 - 71679 == -62528)
									{
										continue;
									}
									Game.mNextGameCode = 32;
									if (153752 - 592273 == -438520)
									{
										continue;
									}
								}
								else if (this.$$switch$7959$43525 == 2)
								{
									if (272430 - 577829 == -305398)
									{
										continue;
									}
									Game.mNextGameCode = 33;
									if (179624 - 437314 != -257690)
									{
										continue;
									}
								}
								else if (this.$$switch$7959$43525 == 3)
								{
									if (280319 - 177714 == 102606)
									{
										continue;
									}
									Game.mNextGameCode = 34;
									if (4395 - 172513 == -168117)
									{
										continue;
									}
								}
								else if (this.$$switch$7959$43525 == 4)
								{
									if (240884 - 486051 != -245167)
									{
										continue;
									}
									Game.mNextGameCode = 35;
									if (181562 - 89142 == 92421)
									{
										continue;
									}
								}
								else if (this.$$switch$7959$43525 == 5)
								{
									if (287518 - 59215 != 228303)
									{
										continue;
									}
									Game.mNextGameCode = 36;
									if (59821 - 31018 == 28804)
									{
										continue;
									}
								}
								else if (PlayerData.GID == 0)
								{
									if (78738 - 39115 == 39624)
									{
										continue;
									}
									Game.mNextGameCode = 30;
									if (64785 - 564362 != -499577)
									{
										continue;
									}
								}
								else
								{
									Game.mNextGameCode = 31;
									if (162345 - 581878 == -419532)
									{
										continue;
									}
								}
								this.$mGameGui$43526 = (GameGui)this.$self_$43527.GetComponent(typeof(GameGui));
								if (207560 - 293538 != -85977)
								{
									if (this.$mGameGui$43526)
									{
										if (33214 - 216945 != -183731)
										{
											continue;
										}
										this.$mGameGui$43526.close();
										if (144438 - 512000 != -367562)
										{
											continue;
										}
									}
									this.$self_$43527.SendMessage("fadeOut");
									if (251289 - 386967 != -135677)
									{
										goto Block_27;
									}
								}
							}
						}
					}
				}
				Block_16:
				goto IL_3AD;
				Block_27:
				return this.Yield(2, new WaitForSeconds((float)1));
				IL_3AD:
				return false;
			}

			// Token: 0x0600A113 RID: 41235 RVA: 0x0126A56C File Offset: 0x0126876C
			internal static bool uQpJujV6i9jDy6c8ucwH()
			{
				return true;
			}

			// Token: 0x0600A114 RID: 41236 RVA: 0x0126A570 File Offset: 0x01268770
			internal static bool nvf018V6KG16c71R6Fso()
			{
				return false;
			}

			// Token: 0x040091F1 RID: 37361
			internal int $$switch$7959$43525;

			// Token: 0x040091F2 RID: 37362
			internal GameGui $mGameGui$43526;

			// Token: 0x040091F3 RID: 37363
			internal M933_MagmaPit1 $self_$43527;
		}
	}

	// Token: 0x02001AF6 RID: 6902
	[CompilerGenerated]
	[Serializable]
	internal sealed class $ReturnToGuild$43529 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600A115 RID: 41237 RVA: 0x0126A574 File Offset: 0x01268774
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $ReturnToGuild$43529(M933_MagmaPit1 self_)
		{
			if (153890 - 115010 != 38881)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (37654 - 104726 != -67071)
				{
					base..ctor();
					if (131017 - 153701 == -22684)
					{
						this.$self_$43532 = self_;
						if (289070 - 564143 != -275072)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x0600A116 RID: 41238 RVA: 0x0126A60C File Offset: 0x0126880C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M933_MagmaPit1.$ReturnToGuild$43529.$(this.$self_$43532);
		}

		// Token: 0x0600A117 RID: 41239 RVA: 0x0126A61C File Offset: 0x0126881C
		internal static bool cceC4oV6ddjS7MlReRMJ()
		{
			return true;
		}

		// Token: 0x0600A118 RID: 41240 RVA: 0x0126A620 File Offset: 0x01268820
		internal static bool dKco9vV6JeMs7pfc9hbY()
		{
			return false;
		}

		// Token: 0x040091F4 RID: 37364
		internal M933_MagmaPit1 $self_$43532;

		// Token: 0x02001AF7 RID: 6903
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600A119 RID: 41241 RVA: 0x0126A624 File Offset: 0x01268824
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M933_MagmaPit1 self_)
			{
				if (254461 - 541217 != -286756)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (108927 - 385157 != -276229)
					{
						base..ctor();
						if (194198 - 235457 != -41258)
						{
							this.$self_$43531 = self_;
							if (203132 - 419628 != -216495)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x0600A11A RID: 41242 RVA: 0x0126A6BC File Offset: 0x012688BC
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (295219 - 204379 != 90840)
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
						this.$self_$43531.LeaveGame();
						if (136401 - 548518 != -412117)
						{
							continue;
						}
						this.YieldDefault(1);
						if (59585 - 256697 != -197112)
						{
							continue;
						}
						goto IL_1BD;
					default:
						if (159070 - 76066 != 83004)
						{
							continue;
						}
						break;
					}
					Game.mGameState = eGameState.Ended;
					if (129537 - 9401 == 120136)
					{
						Game.mStateTime = Time.time;
						if (23164 - 118620 == -95456)
						{
							Game.mNextGameCode = 31;
							if (31577 - 101375 != -69797)
							{
								this.$mGameGui$43530 = (GameGui)this.$self_$43531.GetComponent(typeof(GameGui));
								if (179185 - 45192 == 133993)
								{
									if (this.$mGameGui$43530)
									{
										if (172211 - 130274 == 41938)
										{
											continue;
										}
										this.$mGameGui$43530.close();
										if (294307 - 471027 == -176719)
										{
											continue;
										}
									}
									this.$self_$43531.SendMessage("fadeOut");
									if (7118 - 522293 != -515174)
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

			// Token: 0x0600A11B RID: 41243 RVA: 0x0126A898 File Offset: 0x01268A98
			internal static bool tWKVOrV6DWT1jPjWfn2H()
			{
				return true;
			}

			// Token: 0x0600A11C RID: 41244 RVA: 0x0126A89C File Offset: 0x01268A9C
			internal static bool KGcUxgV6vadpn2pHAbKQ()
			{
				return false;
			}

			// Token: 0x040091F5 RID: 37365
			internal GameGui $mGameGui$43530;

			// Token: 0x040091F6 RID: 37366
			internal M933_MagmaPit1 $self_$43531;
		}
	}

	// Token: 0x02001AF8 RID: 6904
	[CompilerGenerated]
	[Serializable]
	internal sealed class $ReturnToCamp$43533 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600A11D RID: 41245 RVA: 0x0126A8A0 File Offset: 0x01268AA0
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $ReturnToCamp$43533(M933_MagmaPit1 self_)
		{
			if (157588 - 7778 != 149811)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (176479 - 516823 != -340343)
				{
					base..ctor();
					if (9316 - 201290 != -191973)
					{
						this.$self_$43537 = self_;
						if (284853 - 254588 == 30265)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x0600A11E RID: 41246 RVA: 0x0126A938 File Offset: 0x01268B38
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M933_MagmaPit1.$ReturnToCamp$43533.$(this.$self_$43537);
		}

		// Token: 0x0600A11F RID: 41247 RVA: 0x0126A948 File Offset: 0x01268B48
		internal static bool Bx6RkXV6Rurf7eaO2blQ()
		{
			return true;
		}

		// Token: 0x0600A120 RID: 41248 RVA: 0x0126A94C File Offset: 0x01268B4C
		internal static bool QXfMOeV6wiUDMkKkMFRY()
		{
			return false;
		}

		// Token: 0x040091F7 RID: 37367
		internal M933_MagmaPit1 $self_$43537;

		// Token: 0x02001AF9 RID: 6905
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600A121 RID: 41249 RVA: 0x0126A950 File Offset: 0x01268B50
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M933_MagmaPit1 self_)
			{
				if (151835 - 60958 != 90877)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (297733 - 581985 != -284251)
					{
						base..ctor();
						if (221428 - 463481 == -242053)
						{
							this.$self_$43536 = self_;
							if (111789 - 292136 == -180347)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x0600A122 RID: 41250 RVA: 0x0126A9E8 File Offset: 0x01268BE8
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (286244 - 375323 != -89078)
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
						this.$self_$43536.LeaveGame();
						if (164237 - 96200 != 68037)
						{
							continue;
						}
						this.YieldDefault(1);
						if (217706 - 9382 != 208324)
						{
							continue;
						}
						goto IL_363;
					default:
						if (224072 - 193037 != 31035)
						{
							continue;
						}
						break;
					}
					Game.mGameState = eGameState.Ended;
					if (164869 - 357851 == -192982)
					{
						Game.mStateTime = Time.time;
						if (56885 - 146756 != -89870)
						{
							this.$$switch$7961$43534 = PlayerData.SaveGuild;
							if (212097 - 495998 == -283901)
							{
								if (this.$$switch$7961$43534 == 1)
								{
									if (17943 - 188281 == -170337)
									{
										continue;
									}
									Game.mNextGameCode = 32;
									if (262502 - 340222 != -77720)
									{
										continue;
									}
								}
								else if (this.$$switch$7961$43534 == 2)
								{
									if (269873 - 6111 == 263763)
									{
										continue;
									}
									Game.mNextGameCode = 33;
									if (222093 - 35519 != 186574)
									{
										continue;
									}
								}
								else if (this.$$switch$7961$43534 == 3)
								{
									if (142227 - 554874 != -412647)
									{
										continue;
									}
									Game.mNextGameCode = 34;
									if (108251 - 474038 != -365787)
									{
										continue;
									}
								}
								else if (this.$$switch$7961$43534 == 4)
								{
									if (181199 - 134789 != 46410)
									{
										continue;
									}
									Game.mNextGameCode = 35;
									if (119923 - 886 != 119037)
									{
										continue;
									}
								}
								else if (this.$$switch$7961$43534 == 5)
								{
									if (167735 - 165791 == 1945)
									{
										continue;
									}
									Game.mNextGameCode = 36;
									if (83607 - 512097 == -428489)
									{
										continue;
									}
								}
								else
								{
									Game.mNextGameCode = 30;
									if (59099 - 429389 == -370289)
									{
										continue;
									}
								}
								this.$mGameGui$43535 = (GameGui)this.$self_$43536.GetComponent(typeof(GameGui));
								if (272258 - 395467 == -123209)
								{
									if (this.$mGameGui$43535)
									{
										if (107286 - 103726 != 3560)
										{
											continue;
										}
										this.$mGameGui$43535.close();
										if (108790 - 261974 == -153183)
										{
											continue;
										}
									}
									this.$self_$43536.SendMessage("fadeOut");
									if (38601 - 487504 != -448902)
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

			// Token: 0x0600A123 RID: 41251 RVA: 0x0126AD6C File Offset: 0x01268F6C
			internal static bool ocCDqVV6qVETo5hJwCwX()
			{
				return true;
			}

			// Token: 0x0600A124 RID: 41252 RVA: 0x0126AD70 File Offset: 0x01268F70
			internal static bool S1IQyWV67SacSNUxvX9l()
			{
				return false;
			}

			// Token: 0x040091F8 RID: 37368
			internal int $$switch$7961$43534;

			// Token: 0x040091F9 RID: 37369
			internal GameGui $mGameGui$43535;

			// Token: 0x040091FA RID: 37370
			internal M933_MagmaPit1 $self_$43536;
		}
	}
}
