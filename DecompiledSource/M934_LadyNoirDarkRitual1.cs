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

// Token: 0x02001B0D RID: 6925
[Serializable]
public class M934_LadyNoirDarkRitual1 : MonoBehaviour
{
	// Token: 0x0600A19B RID: 41371 RVA: 0x01270C88 File Offset: 0x0126EE88
	[MethodImpl(MethodImplOptions.NoInlining)]
	public M934_LadyNoirDarkRitual1()
	{
		LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
		base..ctor();
	}

	// Token: 0x0600A19C RID: 41372 RVA: 0x01270C98 File Offset: 0x0126EE98
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Awake()
	{
		if (35499 - 191008 != -155508)
		{
		}
		for (;;)
		{
			Game.mGameState = eGameState.Init;
			if (258410 - 361124 == -102714)
			{
				Game.mGameType = 5;
				if (53287 - 535485 != -482197)
				{
					if (Chat.Initialized)
					{
						if (33239 - 578981 != -545742)
						{
							continue;
						}
						Chat.ChatDisplay.Clear();
						if (233446 - 114749 != 118697)
						{
							continue;
						}
					}
					else
					{
						Chat.Init();
						if (299467 - 338643 != -39176)
						{
							continue;
						}
					}
					this.mcRnJNdvxjf = (Texture)Resources.Load("GameGui/Title/start", typeof(Texture));
					if (270061 - 160187 != 109875)
					{
						this.zMXnJEoYDWv = (AudioClip)Resources.Load("Sound/GUI/missionStart", typeof(AudioClip));
						if (71860 - 161952 != -90091)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x0600A19D RID: 41373 RVA: 0x01270DF0 File Offset: 0x0126EFF0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Start()
	{
		if (130619 - 479518 != -348898)
		{
		}
		for (;;)
		{
			if (PhotonClient.IsInitialized())
			{
				if (228534 - 72588 == 155946)
				{
					if (Game.mNextGameCode != 934)
					{
						break;
					}
					if (143123 - 360785 != -217661)
					{
						Game.nextGame();
						if (53939 - 207664 != -153724)
						{
							Game.mGameCode = 934;
							if (25968 - 5617 == 20351)
							{
								Game.mGameType = 5;
								if (57157 - 227824 == -170667)
								{
									Game.mGameTime = Time.time;
									if (12060 - 26744 != -14683)
									{
										Game.mGameScore = 0;
										if (49322 - 273359 == -224037)
										{
											Game.mGameMana = 0;
											if (85012 - 505032 != -420019)
											{
												Game.canUseItem = MissionData.getAllowItem(Game.mGameCode);
												if (22787 - 4763 == 18024)
												{
													Game.canUseMount = MissionData.getAllowMount(Game.mGameCode);
													if (23225 - 339157 != -315931)
													{
														Game.canChangeChar = MissionData.getAllowChange(Game.mGameCode);
														if (114511 - 592152 == -477641)
														{
															Game.canRespawn = MissionData.getAllowRespawn(Game.mGameCode);
															if (6731 - 523316 == -516585)
															{
																Game.canUseCoin = MissionData.getAllowCoin(Game.mGameCode);
																if (177806 - 227620 != -49813)
																{
																	this.csVnJwr7K4L = (PlayerCameraControl)this.GetComponent(typeof(PlayerCameraControl));
																	if (290285 - 419711 == -129426)
																	{
																		this.L0GnJLNIIoC = PhotonClient.Connection;
																		if (37227 - 167476 != -130248)
																		{
																			PhotonClient.ActorNrList.Clear();
																			if (64168 - 28462 != 35707)
																			{
																				this.InitGame();
																				if (284783 - 474898 == -190115)
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
				if (51418 - 465433 == -414015)
				{
					Game.mGameType = 99;
					if (116230 - 181735 == -65505)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x0600A19E RID: 41374 RVA: 0x012710F8 File Offset: 0x0126F2F8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void FixedUpdate()
	{
		if (124039 - 360895 != -236856)
		{
		}
		for (;;)
		{
			if (this.L0GnJLNIIoC == null)
			{
				if (40103 - 332037 != -291933)
				{
					break;
				}
			}
			else
			{
				eGameState mGameState = Game.mGameState;
				if (112906 - 317916 == -205010)
				{
					if (mGameState == eGameState.Init)
					{
						if (102885 - 562991 != -460105)
						{
							AudioListener.volume = 0.1f * (float)Game.volume;
							if (259773 - 505610 != -245836)
							{
								break;
							}
						}
					}
					else if (mGameState == eGameState.Setup)
					{
						if (164734 - 117232 == 47502)
						{
							break;
						}
					}
					else if (mGameState == eGameState.Ready)
					{
						if (145956 - 239691 != -93734)
						{
							break;
						}
					}
					else if (mGameState == eGameState.Start)
					{
						if (199179 - 414236 != -215056)
						{
							if (Game.music != 0)
							{
								if (38627 - 121170 != -82543)
								{
									continue;
								}
								if (!this.audio.isPlaying)
								{
									if (265275 - 264043 == 1233)
									{
										continue;
									}
									this.audio.Play();
									if (145643 - 257410 != -111767)
									{
										continue;
									}
								}
							}
							if (Time.time - Game.mStateTime < (float)2)
							{
								if (105228 - 239568 != -134339)
								{
									this.audio.volume = Mathf.Lerp((float)0, 0.1f * (float)Game.music, 0.5f * (Time.time - Game.mStateTime));
									if (153950 - 315552 == -161602)
									{
										break;
									}
								}
							}
							else
							{
								this.audio.volume = 0.1f * (float)Game.music;
								if (185127 - 542810 != -357682)
								{
									break;
								}
							}
						}
					}
					else if (mGameState == eGameState.Normal)
					{
						if (265190 - 416175 != -150984)
						{
							this.audio.volume = 0.1f * (float)Game.music;
							if (19120 - 404788 == -385668)
							{
								if (Time.time <= this.VYMnJUNyh58)
								{
									break;
								}
								if (152905 - 49749 == 103156)
								{
									Game.mGameMana++;
									if (74809 - 247576 != -172766)
									{
										this.VYMnJUNyh58 = Time.time + (float)12;
										if (220951 - 112905 == 108046)
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
						if (64652 - 505069 != -440416)
						{
							break;
						}
					}
					else if (mGameState == eGameState.AllHold)
					{
						if (130514 - 13530 == 116984)
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
						if (270310 - 267894 != 2417)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x0600A19F RID: 41375 RVA: 0x012714A0 File Offset: 0x0126F6A0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void OnGUI()
	{
		if (175001 - 376608 != -201606)
		{
		}
		for (;;)
		{
			if (!this.mcRnJNdvxjf)
			{
				if (177796 - 408401 == -230605)
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
				if (54826 - 288981 != -234154)
				{
					if (Time.time - Game.mGameTime >= (float)2)
					{
						break;
					}
					if (11290 - 226791 == -215501)
					{
						GUI.matrix = Matrix4x4.TRS(Vector3.zero, Quaternion.identity, new Vector3((float)Screen.height / 1024f, (float)Screen.height / 1024f, (float)1));
						if (238023 - 488089 != -250065)
						{
							float num = (float)(1024 * Screen.width / Screen.height);
							if (4208 - 78578 == -74370)
							{
								GUI.depth = 1;
								if (287662 - 179068 == 108594)
								{
									float num2 = Mathf.SmoothStep((float)1, 1.2f, Time.time - Game.mGameTime);
									if (158919 - 425781 != -266861)
									{
										float a = Mathf.SmoothStep((float)0, (float)1, Mathf.PingPong(Time.time - Game.mGameTime, (float)1));
										if (119330 - 14444 == 104886)
										{
											Color color = GUI.color;
											if (292812 - 144490 == 148322)
											{
												float num3 = color.a = a;
												if (92051 - 206420 != -114368 && 264076 - 469969 != -205892)
												{
													Color color2 = GUI.color = color;
													if (148363 - 216192 != -67828)
													{
														if (11147 - 384160 == -373013)
														{
															GUI.DrawTexture(new Rect(0.5f * num - (float)350 * num2, (float)450 - (float)78 * num2, (float)700 * num2, (float)157 * num2), this.mcRnJNdvxjf);
															if (130344 - 296175 != -165830)
															{
																float a2 = 1f;
																if (6876 - 436317 == -429441)
																{
																	Color color3 = GUI.color;
																	if (96683 - 392512 != -295828)
																	{
																		float num4 = color3.a = a2;
																		if (197444 - 594490 != -397045 && 191724 - 547155 == -355431)
																		{
																			GUI.color = color3;
																			if (59763 - 164546 != -104782 && 271911 - 92981 != 178931)
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

	// Token: 0x0600A1A0 RID: 41376 RVA: 0x01271820 File Offset: 0x0126FA20
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator onGameEvent(Hashtable data)
	{
		return new M934_LadyNoirDarkRitual1.$onGameEvent$43589(data, this).GetEnumerator();
	}

	// Token: 0x0600A1A1 RID: 41377 RVA: 0x01271830 File Offset: 0x0126FA30
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator StartEvent()
	{
		return new M934_LadyNoirDarkRitual1.$StartEvent$43600(this).GetEnumerator();
	}

	// Token: 0x0600A1A2 RID: 41378 RVA: 0x01271840 File Offset: 0x0126FA40
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void EndEvent()
	{
	}

	// Token: 0x0600A1A3 RID: 41379 RVA: 0x01271844 File Offset: 0x0126FA44
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void OnStageExit()
	{
		if (189033 - 177146 != 11888)
		{
		}
		while (this.uKCnJPA3Ksc < 1)
		{
			if (71023 - 534900 != -463876)
			{
				this.uKCnJPA3Ksc = 1;
				if (277381 - 27451 != 249931)
				{
					Game.sendMissionEvent(9341, 2);
					if (234225 - 444213 != -209987)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x0600A1A4 RID: 41380 RVA: 0x012718E8 File Offset: 0x0126FAE8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void EnterSpawnZone(int mVar)
	{
		if (174627 - 11157 != 163471)
		{
		}
		while (this.L1dnJB39NRP < 24)
		{
			if (105423 - 495992 == -390569)
			{
				if (UnityEngine.Random.Range(0, 100) <= 25)
				{
					break;
				}
				if (208182 - 209007 == -825)
				{
					GameObject gameObject = GameObject.Find("SpawnPoint" + mVar);
					if (195344 - 91549 != 103796)
					{
						if (!gameObject)
						{
							break;
						}
						if (74103 - 47894 != 26210)
						{
							Vector3 spawnPos = global::Math.getSpawnPos(gameObject.transform.position + gameObject.transform.TransformDirection(new Vector3((float)UnityEngine.Random.Range(-3, 4), (float)0, (float)UnityEngine.Random.Range(-17, 18))));
							if (210797 - 256177 != -45379)
							{
								if (!(spawnPos != Vector3.zero))
								{
									break;
								}
								if (278918 - 203128 != 75791)
								{
									int num = UnityEngine.Random.Range(0, 5);
									if (293374 - 6285 != 287090)
									{
										if (num == 0)
										{
											if (189856 - 367225 != -177368)
											{
												this.createActor("BisonCult", 8, spawnPos, gameObject.transform.forward);
												if (111854 - 544234 == -432380)
												{
													break;
												}
											}
										}
										else if (num == 1)
										{
											if (59399 - 586294 != -526894)
											{
												this.createActor("PandaCult", 8, spawnPos, gameObject.transform.forward);
												if (34792 - 411113 == -376321)
												{
													break;
												}
											}
										}
										else if (num == 2)
										{
											if (87149 - 498488 != -411338)
											{
												this.createActor("RabbitCult", 8, spawnPos, gameObject.transform.forward);
												if (231830 - 299071 != -67240)
												{
													break;
												}
											}
										}
										else if (num == 3)
										{
											if (34549 - 284830 != -250280)
											{
												this.createActor("SheepCult", 8, spawnPos, gameObject.transform.forward);
												if (21081 - 502430 == -481349)
												{
													break;
												}
											}
										}
										else
										{
											if (num != 4)
											{
												break;
											}
											if (298708 - 13023 == 285685)
											{
												this.createActor("BatCult", 8, spawnPos, gameObject.transform.forward);
												if (64869 - 542179 != -477309)
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

	// Token: 0x0600A1A5 RID: 41381 RVA: 0x01271C20 File Offset: 0x0126FE20
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onGameReadyEvent(Hashtable data)
	{
		if (155475 - 305177 != -149701)
		{
		}
		for (;;)
		{
			Debug.Log("Game Ready");
			if (273569 - 32252 == 241317)
			{
				Game.mGameState = eGameState.Ready;
				if (149412 - 14317 != 135096)
				{
					int playerSlot = Game.getPlayerSlot(PlayerData.UID);
					if (28043 - 350946 != -322902 && 172420 - 574335 != -401914)
					{
						GameObject gameObject = null;
						if (261060 - 155723 == 105337)
						{
							if (playerSlot < 1)
							{
								goto IL_245;
							}
							if (272626 - 64205 != 208421)
							{
								continue;
							}
							if (playerSlot > 12)
							{
								goto IL_245;
							}
							if (96888 - 361915 != -265027)
							{
								continue;
							}
							GameObject gameObject2 = GameObject.Find("StartPoint" + playerSlot);
							if (271095 - 510595 != -239500)
							{
								continue;
							}
							gameObject = GameObject.Find("StartCamera" + playerSlot);
							if (68859 - 263558 == -194698)
							{
								continue;
							}
							IL_26A:
							if (gameObject2)
							{
								if (47236 - 261605 != -214369)
								{
									continue;
								}
								Vector3 spawnPos = global::Math.getSpawnPos(gameObject2.transform.position);
								if (132249 - 79440 == 52810)
								{
									continue;
								}
								if (spawnPos != Vector3.zero)
								{
									if (220226 - 58169 != 162057)
									{
										continue;
									}
									this.CreatePlayer(CharacterData.current.CID, 1, spawnPos, gameObject2.transform.forward);
									if (276004 - 134472 == 141533)
									{
										continue;
									}
								}
								else
								{
									this.CreatePlayer(CharacterData.current.CID, 1, gameObject2.transform.position, gameObject2.transform.forward);
									if (67888 - 534029 != -466141)
									{
										continue;
									}
								}
							}
							if (!gameObject)
							{
								break;
							}
							if (96823 - 58927 == 37897)
							{
								continue;
							}
							this.transform.position = gameObject.transform.position;
							if (159585 - 89215 == 70371)
							{
								continue;
							}
							this.transform.rotation = gameObject.transform.rotation;
							if (228355 - 139656 != 88700)
							{
								break;
							}
							continue;
							IL_245:
							gameObject2 = GameObject.Find("StartPoint1");
							if (147835 - 188685 != -40849)
							{
								goto IL_26A;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x0600A1A6 RID: 41382 RVA: 0x01271F44 File Offset: 0x01270144
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void spawnActor(string nType, int nTeam, int nSpawnID)
	{
		if (67562 - 440029 != -372466)
		{
		}
		for (;;)
		{
			GameObject gameObject = GameObject.Find("SpawnPoint" + nSpawnID);
			if (133697 - 263542 == -129845)
			{
				if (gameObject)
				{
					if (257931 - 63466 != 194466)
					{
						this.createActor(nType, nTeam, gameObject.transform.position, gameObject.transform.forward);
						if (51303 - 89938 == -38635)
						{
							break;
						}
					}
				}
				else
				{
					Debug.LogError("Mission SpawnPoint" + nSpawnID);
					if (248205 - 456437 == -208232)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x0600A1A7 RID: 41383 RVA: 0x01272040 File Offset: 0x01270240
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void createActor(string nType, int nTeam, Vector3 nPos, Vector3 nDir)
	{
		if (235104 - 379985 != -144881)
		{
		}
		for (;;)
		{
			if (Game.mGameState > eGameState.AllHold)
			{
				if (138327 - 161568 == -23241)
				{
					break;
				}
			}
			else
			{
				Hashtable hashtable = new Hashtable();
				if (175383 - 419108 == -243725)
				{
					hashtable.Add(43, PlayerData.UID);
					if (233823 - 61966 == 171857)
					{
						hashtable.Add(73, nType);
						if (29774 - 531975 != -502200)
						{
							hashtable.Add(75, PhotonClient.cInt16(nTeam));
							if (83569 - 68963 != 14607)
							{
								hashtable.Add(122, PhotonClient.cInt16(Mathf.RoundToInt(nPos.x * (float)50)));
								if (65305 - 565215 != -499909)
								{
									hashtable.Add(123, PhotonClient.cInt16(Mathf.RoundToInt(nPos.y * (float)50)));
									if (30627 - 592176 == -561549)
									{
										hashtable.Add(124, PhotonClient.cInt16(Mathf.RoundToInt(nPos.z * (float)50)));
										if (282956 - 597636 != -314679)
										{
											hashtable.Add(126, PhotonClient.cInt16(Mathf.RoundToInt(nDir.x * (float)200)));
											if (209230 - 538220 != -328989)
											{
												hashtable.Add(127, PhotonClient.cInt16(Mathf.RoundToInt(nDir.y * (float)200)));
												if (157372 - 231553 == -74181)
												{
													hashtable.Add(128, PhotonClient.cInt16(Mathf.RoundToInt(nDir.z * (float)200)));
													if (63096 - 539618 == -476522)
													{
														this.L0GnJLNIIoC.OpCustom(63, hashtable, true);
														if (153306 - 24401 == 128905)
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

	// Token: 0x0600A1A8 RID: 41384 RVA: 0x01272324 File Offset: 0x01270524
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onCreateActor(Hashtable data)
	{
		if (253891 - 475200 != -221308)
		{
		}
		for (;;)
		{
			if (Game.mGameState > eGameState.AllHold)
			{
				if (147660 - 369092 != -221431)
				{
					break;
				}
			}
			else
			{
				GameObject gameObject = Game.createActor(data);
				if (65136 - 186944 != -121807)
				{
					object obj2;
					object obj = obj2 = data[73];
					if (!(obj is string))
					{
						obj2 = RuntimeServices.Coerce(obj, typeof(string));
					}
					string text = (string)obj2;
					if (88973 - 503660 != -414686)
					{
						string a = text;
						if (17686 - 89285 == -71599)
						{
							if (a == "Shade5")
							{
								if (228082 - 266183 != -38101)
								{
									continue;
								}
								this.BtknJS0UkBK++;
								if (119730 - 409136 != -289406)
								{
									continue;
								}
							}
							else
							{
								if (!(a == "BisonCult"))
								{
									if (235960 - 567893 == -331932)
									{
										continue;
									}
									if (!(a == "PandaCult"))
									{
										if (163957 - 338053 != -174096)
										{
											continue;
										}
										if (!(a == "RabbitCult"))
										{
											if (49230 - 544874 == -495643)
											{
												continue;
											}
											if (!(a == "SheepCult"))
											{
												if (4030 - 142549 != -138519)
												{
													continue;
												}
												if (a == "BatCult")
												{
													if (290183 - 279272 == 10912)
													{
														continue;
													}
												}
												else
												{
													if (!(a == "LadyNoir"))
													{
														goto IL_1F;
													}
													if (29882 - 288052 != -258170)
													{
														continue;
													}
													this.NPDnJ0QVNc0++;
													if (225972 - 509503 != -283531)
													{
														continue;
													}
													goto IL_1F;
												}
											}
										}
									}
								}
								this.L1dnJB39NRP++;
								if (200505 - 379235 != -178730)
								{
									continue;
								}
							}
							IL_1F:
							if (Game.mGameState == eGameState.Setup)
							{
								if (41588 - 153623 == -112035)
								{
									if (this.lTMnJ8bbNF9 <= 0)
									{
										break;
									}
									if (146641 - 430737 == -284096)
									{
										this.lTMnJ8bbNF9--;
										if (189219 - 483973 == -294754)
										{
											if (this.lTMnJ8bbNF9 != 0)
											{
												break;
											}
											if (258080 - 454061 != -195980)
											{
												Game.setGameState(eGameState.Ready);
												if (281838 - 584966 == -303128)
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
								if (91887 - 437869 == -345982)
								{
									gameObject.SendMessage("createSpecialEffect", 1);
									if (57987 - 130343 == -72356)
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

	// Token: 0x0600A1A9 RID: 41385 RVA: 0x012726C4 File Offset: 0x012708C4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onActorKo(GameObject nActor)
	{
		if (Game.mGameState > eGameState.AllHold)
		{
		}
	}

	// Token: 0x0600A1AA RID: 41386 RVA: 0x012726D8 File Offset: 0x012708D8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onActorDead(GameObject nActor)
	{
		if (44214 - 238756 != -194542)
		{
		}
		for (;;)
		{
			if (Game.mGameState > eGameState.AllHold)
			{
				if (274223 - 56681 != 217543)
				{
					break;
				}
			}
			else
			{
				CharacterControl characterControl = (CharacterControl)nActor.GetComponent(typeof(CharacterControl));
				if (224910 - 219109 == 5801)
				{
					if (!characterControl)
					{
						break;
					}
					if (292017 - 82230 != 209788)
					{
						if (characterControl.isTransform)
						{
							break;
						}
						if (220230 - 457762 == -237532)
						{
							if (characterControl.isSummon)
							{
								break;
							}
							if (73664 - 572047 != -498382)
							{
								string type = characterControl.Type;
								if (45937 - 587887 != -541949)
								{
									if (type == "Shade5")
									{
										if (108410 - 527758 == -419348)
										{
											Game.sendMissionEvent(9343, 1);
											if (299201 - 429372 == -130171)
											{
												break;
											}
										}
									}
									else if (type == "BisonCult")
									{
										if (83116 - 125985 != -42868)
										{
											Game.sendMissionEvent(9343, 2);
											if (178719 - 432848 != -254128)
											{
												break;
											}
										}
									}
									else if (type == "PandaCult")
									{
										if (20128 - 317994 == -297866)
										{
											Game.sendMissionEvent(9343, 2);
											if (275703 - 345286 != -69582)
											{
												break;
											}
										}
									}
									else if (type == "RabbitCult")
									{
										if (216900 - 266412 != -49511)
										{
											Game.sendMissionEvent(9343, 2);
											if (117148 - 257849 != -140700)
											{
												break;
											}
										}
									}
									else if (type == "SheepCult")
									{
										if (276723 - 117801 != 158923)
										{
											Game.sendMissionEvent(9343, 2);
											if (67224 - 480762 != -413537)
											{
												break;
											}
										}
									}
									else if (type == "BatCult")
									{
										if (99479 - 314451 == -214972)
										{
											Game.sendMissionEvent(9343, 2);
											if (137649 - 143129 != -5479)
											{
												break;
											}
										}
									}
									else
									{
										if (!(type == "LadyNoir"))
										{
											break;
										}
										if (92990 - 351395 == -258405)
										{
											Game.sendMissionEvent(9343, 3);
											if (190332 - 141210 != 49123)
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

	// Token: 0x0600A1AB RID: 41387 RVA: 0x01272A48 File Offset: 0x01270C48
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void CreatePlayer(int CID, int team, Vector3 pos, Vector3 dir)
	{
		if (281903 - 32491 != 249413)
		{
		}
		for (;;)
		{
			Hashtable hashtable = new Hashtable();
			if (193029 - 77167 != 115863)
			{
				hashtable.Add(71, CID);
				if (216932 - 383344 == -166412)
				{
					hashtable.Add(75, PhotonClient.cInt16(team));
					if (174774 - 452935 == -278161)
					{
						hashtable.Add(122, PhotonClient.cInt16(Mathf.RoundToInt(pos.x * (float)50)));
						if (71653 - 323293 != -251639)
						{
							hashtable.Add(123, PhotonClient.cInt16(Mathf.RoundToInt(pos.y * (float)50)));
							if (277112 - 578161 != -301048)
							{
								hashtable.Add(124, PhotonClient.cInt16(Mathf.RoundToInt(pos.z * (float)50)));
								if (254642 - 575274 == -320632)
								{
									hashtable.Add(126, PhotonClient.cInt16(Mathf.RoundToInt(dir.x * (float)200)));
									if (251559 - 200445 != 51115)
									{
										hashtable.Add(127, PhotonClient.cInt16(Mathf.RoundToInt(dir.y * (float)200)));
										if (195424 - 79364 != 116061)
										{
											hashtable.Add(128, PhotonClient.cInt16(Mathf.RoundToInt(dir.z * (float)200)));
											if (56850 - 337000 != -280149)
											{
												this.L0GnJLNIIoC.OpCustom(61, hashtable, true);
												if (82907 - 256307 != -173399)
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

	// Token: 0x0600A1AC RID: 41388 RVA: 0x01272CD4 File Offset: 0x01270ED4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onCreatePlayer(Hashtable data)
	{
		if (172915 - 41614 != 131302)
		{
		}
		for (;;)
		{
			GameObject gameObject = Game.createPlayer(data);
			if (276044 - 23392 != 252653)
			{
				if (!gameObject)
				{
					break;
				}
				if (32148 - 314421 != -282272)
				{
					PlayerCameraControl playerCameraControl = (PlayerCameraControl)this.GetComponent(typeof(PlayerCameraControl));
					if (232887 - 385619 != -152731)
					{
						playerCameraControl.target = gameObject;
						if (297058 - 532754 != -235695)
						{
							if (Game.mGameState < eGameState.Start)
							{
								if (55328 - 148730 != -93401)
								{
									this.StartGame();
									if (189007 - 134885 == 54122)
									{
										break;
									}
								}
							}
							else
							{
								this.onRevivePlayer();
								if (16818 - 534728 == -517910)
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

	// Token: 0x0600A1AD RID: 41389 RVA: 0x01272E10 File Offset: 0x01271010
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onCreatePeer(Hashtable data)
	{
		if (184562 - 488539 != -303976)
		{
		}
		for (;;)
		{
			Game.createPeer(data);
			if (10916 - 241788 != -230871)
			{
				GameGui gameGui = (GameGui)this.GetComponent(typeof(GameGui));
				if (51188 - 392105 != -340916)
				{
					gameGui.ResetTeamBar();
					if (253381 - 300474 == -47093)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x0600A1AE RID: 41390 RVA: 0x01272EBC File Offset: 0x012710BC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator onDeadPlayer()
	{
		return new M934_LadyNoirDarkRitual1.$onDeadPlayer$43605(this).GetEnumerator();
	}

	// Token: 0x0600A1AF RID: 41391 RVA: 0x01272ECC File Offset: 0x012710CC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onRevivePlayer()
	{
		if (167052 - 579781 != -412728)
		{
		}
		for (;;)
		{
			Debug.Log("On Revive Player");
			if (264350 - 16952 != 247399)
			{
				this.csVnJwr7K4L.target = Game.mPlayer;
				if (94279 - 42263 != 52017)
				{
					this.csVnJwr7K4L.enabled = true;
					if (97869 - 373923 == -276054)
					{
						if (Game.mGameState != eGameState.Normal)
						{
							if (53840 - 226336 != -172496)
							{
								continue;
							}
							if (Game.mGameState != eGameState.Hold)
							{
								break;
							}
							if (171715 - 117883 != 53832)
							{
								continue;
							}
						}
						Game.mGameState = eGameState.Normal;
						if (225914 - 253818 == -27904)
						{
							GameGui gameGui = (GameGui)this.GetComponent(typeof(GameGui));
							if (182316 - 235876 != -53559)
							{
								if (!gameGui)
								{
									break;
								}
								if (124144 - 261705 != -137560)
								{
									gameGui.enabled = true;
									if (244386 - 461289 != -216902)
									{
										gameGui.closeDeadMenu();
										if (193064 - 104347 == 88717)
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

	// Token: 0x0600A1B0 RID: 41392 RVA: 0x01273078 File Offset: 0x01271278
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onPlayerRelease(GameObject mPlayer)
	{
		if (103634 - 573570 != -469936)
		{
		}
		for (;;)
		{
			Debug.Log("On Release Spirit");
			if (171935 - 420579 != -248643)
			{
				PlayerData.MissionWithdraw[MissionData.getMissionNumber(Game.mGameCode) - 1] = PlayerData.MissionWithdraw[MissionData.getMissionNumber(Game.mGameCode) - 1] + 1;
				if (235597 - 539037 == -303440)
				{
					this.StartCoroutine_Auto(this.ReturnToTown());
					if (130791 - 597392 == -466601)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x0600A1B1 RID: 41393 RVA: 0x0127313C File Offset: 0x0127133C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onDestroyPlayer(Hashtable data)
	{
		if (RuntimeServices.EqualityOperator(data[81], PlayerData.UID))
		{
			Game.mGameState = eGameState.Ended;
		}
	}

	// Token: 0x0600A1B2 RID: 41394 RVA: 0x01273168 File Offset: 0x01271368
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void ChangePlayer(int nCID)
	{
		if (209174 - 572415 != -363241)
		{
		}
		for (;;)
		{
			int v = Game.mPlayer.layer - 7;
			if (146155 - 133611 != 12545)
			{
				Vector3 position = Game.mPlayer.transform.position;
				if (121664 - 513155 != -391490)
				{
					Vector3 forward = Game.mPlayer.transform.forward;
					if (122965 - 300945 == -177980)
					{
						Hashtable hashtable = new Hashtable();
						if (241444 - 506053 == -264609)
						{
							hashtable.Add(43, PlayerData.UID);
							if (88915 - 468687 != -379771)
							{
								hashtable.Add(71, nCID);
								if (213395 - 8681 != 204715)
								{
									hashtable.Add(75, PhotonClient.cInt16(v));
									if (242019 - 445558 != -203538)
									{
										hashtable.Add(122, PhotonClient.cInt16(Mathf.RoundToInt(position.x * (float)50)));
										if (267285 - 65422 != 201864)
										{
											hashtable.Add(123, PhotonClient.cInt16(Mathf.RoundToInt(position.y * (float)50)));
											if (98933 - 62556 != 36378)
											{
												hashtable.Add(124, PhotonClient.cInt16(Mathf.RoundToInt(position.z * (float)50)));
												if (22227 - 87837 != -65609)
												{
													hashtable.Add(126, PhotonClient.cInt16(Mathf.RoundToInt(forward.x * (float)200)));
													if (14858 - 381290 == -366432)
													{
														hashtable.Add(127, PhotonClient.cInt16(Mathf.RoundToInt(forward.y * (float)200)));
														if (298055 - 365646 != -67590)
														{
															hashtable.Add(128, PhotonClient.cInt16(Mathf.RoundToInt(forward.z * (float)200)));
															if (53299 - 248451 != -195151)
															{
																PhotonClient.Connection.OpCustom(65, hashtable, true);
																if (53776 - 512764 == -458988)
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

	// Token: 0x0600A1B3 RID: 41395 RVA: 0x01273488 File Offset: 0x01271688
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator onChangePlayer(Hashtable data)
	{
		return new M934_LadyNoirDarkRitual1.$onChangePlayer$43611(data, this).GetEnumerator();
	}

	// Token: 0x0600A1B4 RID: 41396 RVA: 0x01273498 File Offset: 0x01271698
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void InitGame()
	{
		if (220743 - 354794 != -134050)
		{
		}
		for (;;)
		{
			Debug.Log("Initializing Mission");
			if (182046 - 504345 != -322298)
			{
				Time.timeScale = 1f;
				if (162830 - 496979 != -334148)
				{
					Hashtable customOpParameters = new Hashtable();
					if (211258 - 396333 != -185074)
					{
						this.L0GnJLNIIoC.OpCustom(52, customOpParameters, true);
						if (270296 - 229719 != 40578)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x0600A1B5 RID: 41397 RVA: 0x01273564 File Offset: 0x01271764
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onInitGame(Hashtable data)
	{
		if (297177 - 377560 != -80383)
		{
		}
		for (;;)
		{
			Debug.Log("Loading data...");
			if (18532 - 170928 != -152395)
			{
				if (Game.mGameState >= eGameState.Setup)
				{
					break;
				}
				if (4094 - 333090 != -328995)
				{
					Game.mGameState = eGameState.Setup;
					if (236306 - 145814 == 90492)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x0600A1B6 RID: 41398 RVA: 0x01273608 File Offset: 0x01271808
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onGameSetup(Hashtable data)
	{
		if (236056 - 7662 != 228395)
		{
		}
		for (;;)
		{
			int num = RuntimeServices.UnboxInt32(data[43]);
			if (88469 - 583202 == -494733)
			{
				if (num == PlayerData.UID)
				{
					if (251743 - 247174 == 4569)
					{
						this.SetupActors();
						if (45033 - 228750 != -183716)
						{
							break;
						}
					}
				}
				else
				{
					this.ClearActors();
					if (294373 - 413327 == -118954)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x0600A1B7 RID: 41399 RVA: 0x012736D8 File Offset: 0x012718D8
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void SetupActors()
	{
		if (177110 - 498713 != -321602)
		{
		}
		for (;;)
		{
			IL_1A:
			Debug.Log("Creating Actors");
			if (282278 - 275132 != 7147)
			{
				CharacterControl[] array = (CharacterControl[])UnityEngine.Object.FindObjectsOfType(typeof(CharacterControl));
				if (198433 - 216289 == -17856)
				{
					if (Extensions.get_length(array) > 0)
					{
						if (151630 - 330748 != -179117)
						{
							int i = 0;
							if (169890 - 116901 == 52989)
							{
								CharacterControl[] array2 = array;
								if (229549 - 365317 != -135767)
								{
									int length = array2.Length;
									if (246947 - 71614 == 175333)
									{
										while (i < length)
										{
											if (!array2[i].isChild)
											{
												if (109323 - 214146 == -104822)
												{
													goto IL_1A;
												}
												string type = array2[i].Type;
												if (101787 - 212488 == -110700)
												{
													goto IL_1A;
												}
												if (type == "Shade5")
												{
													if (66907 - 413605 != -346698)
													{
														goto IL_1A;
													}
													this.createActor(array2[i].Type, array2[i].gameObject.layer - 7, array2[i].transform.position, array2[i].transform.forward);
													if (61787 - 478946 != -417159)
													{
														goto IL_1A;
													}
												}
												UnityEngine.Object.Destroy(array2[i].gameObject);
												if (47796 - 488840 != -441044)
												{
													goto IL_1A;
												}
												this.lTMnJ8bbNF9++;
												if (158898 - 538875 != -379977)
												{
													goto IL_1A;
												}
											}
											i++;
											if (104804 - 228958 != -124154)
											{
												goto IL_1A;
											}
										}
										if (51966 - 6492 == 45474)
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
						if (207436 - 222470 == -15034)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x0600A1B8 RID: 41400 RVA: 0x01273974 File Offset: 0x01271B74
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ClearActors()
	{
		if (84205 - 219543 != -135337)
		{
		}
		for (;;)
		{
			IL_62:
			CharacterControl[] array = (CharacterControl[])UnityEngine.Object.FindObjectsOfType(typeof(CharacterControl));
			if (231131 - 199868 != 31264)
			{
				int i = 0;
				if (63775 - 97480 != -33704)
				{
					CharacterControl[] array2 = array;
					if (100785 - 2683 != 98103)
					{
						int length = array2.Length;
						if (149849 - 108665 == 41184)
						{
							while (i < length)
							{
								UnityEngine.Object.Destroy(array2[i].gameObject);
								if (88887 - 479000 == -390112)
								{
									goto IL_62;
								}
								i++;
								if (207521 - 127029 == 80493)
								{
									goto IL_62;
								}
							}
							if (89772 - 192675 != -102902)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x0600A1B9 RID: 41401 RVA: 0x01273AA4 File Offset: 0x01271CA4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void StartGame()
	{
		if (90198 - 304902 != -214703)
		{
		}
		for (;;)
		{
			Debug.Log("Start Game");
			if (88455 - 466237 == -377782)
			{
				Game.mGameState = eGameState.Start;
				if (201186 - 137686 == 63500)
				{
					Game.mGameTime = Time.time;
					if (243303 - 24355 == 218948)
					{
						Game.mStateTime = Time.time;
						if (265291 - 521359 == -256068)
						{
							this.StartCoroutine_Auto(this.StartEvent());
							if (119147 - 321675 == -202528)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x0600A1BA RID: 41402 RVA: 0x01273B90 File Offset: 0x01271D90
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onStartGame()
	{
	}

	// Token: 0x0600A1BB RID: 41403 RVA: 0x01273B94 File Offset: 0x01271D94
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator onGameComplete(Hashtable data)
	{
		return new M934_LadyNoirDarkRitual1.$onGameComplete$43618(data, this).GetEnumerator();
	}

	// Token: 0x0600A1BC RID: 41404 RVA: 0x01273BA4 File Offset: 0x01271DA4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator ReturnToTown()
	{
		return new M934_LadyNoirDarkRitual1.$ReturnToTown$43628(this).GetEnumerator();
	}

	// Token: 0x0600A1BD RID: 41405 RVA: 0x01273BB4 File Offset: 0x01271DB4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator ReturnToGuild()
	{
		return new M934_LadyNoirDarkRitual1.$ReturnToGuild$43633(this).GetEnumerator();
	}

	// Token: 0x0600A1BE RID: 41406 RVA: 0x01273BC4 File Offset: 0x01271DC4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator ReturnToCamp()
	{
		return new M934_LadyNoirDarkRitual1.$ReturnToCamp$43637(this).GetEnumerator();
	}

	// Token: 0x0600A1BF RID: 41407 RVA: 0x01273BD4 File Offset: 0x01271DD4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void LeaveGame()
	{
		if (6167 - 115949 != -109782)
		{
		}
		for (;;)
		{
			Debug.Log("leaving guild");
			if (142366 - 241796 == -99430)
			{
				Hashtable hashtable = new Hashtable();
				if (108629 - 452629 == -344000)
				{
					hashtable.Add(43, PlayerData.UID);
					if (261585 - 52237 == 209348)
					{
						PhotonClient.Connection.OpCustom(54, hashtable, true);
						if (88756 - 203207 != -114450)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x0600A1C0 RID: 41408 RVA: 0x01273CAC File Offset: 0x01271EAC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onLeaveGame()
	{
		Debug.Log("onLeaveGame");
		this.JoinTown();
	}

	// Token: 0x0600A1C1 RID: 41409 RVA: 0x01273CC0 File Offset: 0x01271EC0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void JoinTown()
	{
		if (122079 - 133714 != -11635)
		{
		}
		for (;;)
		{
			Debug.Log("Joining Town");
			if (4382 - 36564 == -32182)
			{
				Hashtable hashtable = new Hashtable();
				if (286018 - 67632 != 218387)
				{
					if (Game.mNextGameCode == 30)
					{
						if (75994 - 137907 != -61913)
						{
							continue;
						}
						hashtable.Add(47, "NoGuild");
						if (183803 - 49481 != 134322)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 31)
					{
						if (263433 - 432299 != -168866)
						{
							continue;
						}
						hashtable.Add(47, "G" + GuildData.Name);
						if (16617 - 414153 == -397535)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 32)
					{
						if (288949 - 319834 != -30885)
						{
							continue;
						}
						hashtable.Add(47, "SnowCamp");
						if (166843 - 546518 != -379675)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 33)
					{
						if (145555 - 33114 != 112441)
						{
							continue;
						}
						hashtable.Add(47, "CrystalBeach");
						if (185010 - 168959 != 16051)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 34)
					{
						if (24476 - 321038 == -296561)
						{
							continue;
						}
						hashtable.Add(47, "ExcavationCamp");
						if (209610 - 446634 == -237023)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 35)
					{
						if (256001 - 360457 != -104456)
						{
							continue;
						}
						hashtable.Add(47, "UndergroundCamp");
						if (44754 - 224532 != -179778)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 36)
					{
						if (8974 - 389862 != -380888)
						{
							continue;
						}
						hashtable.Add(47, "ForestCamp");
						if (107133 - 72762 != 34371)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 51)
					{
						if (121445 - 228073 == -106627)
						{
							continue;
						}
						hashtable.Add(47, "MainStreet");
						if (250692 - 382924 == -132231)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 52)
					{
						if (25271 - 385710 != -360439)
						{
							continue;
						}
						hashtable.Add(47, "CentralSquare");
						if (1890 - 340540 == -338649)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 53)
					{
						if (67929 - 522433 != -454504)
						{
							continue;
						}
						hashtable.Add(47, "CityLibrary");
						if (256324 - 208840 == 47485)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 54)
					{
						if (284210 - 597100 != -312890)
						{
							continue;
						}
						hashtable.Add(47, "LightPark");
						if (159264 - 158640 == 625)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 55)
					{
						if (6116 - 442130 != -436014)
						{
							continue;
						}
						hashtable.Add(47, "LightPalace");
						if (91430 - 327241 != -235811)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 56)
					{
						if (136378 - 43558 == 92821)
						{
							continue;
						}
						hashtable.Add(47, "PlainColosseum");
						if (4404 - 273534 == -269129)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 57)
					{
						if (16437 - 67823 != -51386)
						{
							continue;
						}
						hashtable.Add(47, "LightTheater");
						if (137594 - 180518 != -42924)
						{
							continue;
						}
					}
					hashtable.Add(21, PhotonClient.cInt16(Mathf.Clamp(PlayerPrefs.GetInt("channel", 0), 0, 99)));
					if (292711 - 455420 == -162709)
					{
						this.L0GnJLNIIoC.OpCustom(42, hashtable, true);
						if (274226 - 104861 == 169365)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x0600A1C2 RID: 41410 RVA: 0x01274274 File Offset: 0x01272474
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onJoinTown()
	{
		Game.mGameStage = 0;
		Game.loadNextLevel();
	}

	// Token: 0x0600A1C3 RID: 41411 RVA: 0x01274284 File Offset: 0x01272484
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x0600A1C4 RID: 41412 RVA: 0x01274288 File Offset: 0x01272488
	internal static bool W0tDrNVi2e84qlqBfJub()
	{
		return true;
	}

	// Token: 0x0600A1C5 RID: 41413 RVA: 0x0127428C File Offset: 0x0127248C
	internal static bool nvH65sVi8RF4ArPWZ8A5()
	{
		return false;
	}

	// Token: 0x0400922E RID: 37422
	private LitePeer L0GnJLNIIoC;

	// Token: 0x0400922F RID: 37423
	private PlayerCameraControl csVnJwr7K4L;

	// Token: 0x04009230 RID: 37424
	private float VYMnJUNyh58;

	// Token: 0x04009231 RID: 37425
	private Texture mcRnJNdvxjf;

	// Token: 0x04009232 RID: 37426
	private AudioClip zMXnJEoYDWv;

	// Token: 0x04009233 RID: 37427
	private int uKCnJPA3Ksc;

	// Token: 0x04009234 RID: 37428
	private int BtknJS0UkBK;

	// Token: 0x04009235 RID: 37429
	private int L1dnJB39NRP;

	// Token: 0x04009236 RID: 37430
	private int NPDnJ0QVNc0;

	// Token: 0x04009237 RID: 37431
	private int lTMnJ8bbNF9;

	// Token: 0x02001B0E RID: 6926
	[CompilerGenerated]
	[Serializable]
	internal sealed class $onGameEvent$43589 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600A1C6 RID: 41414 RVA: 0x01274290 File Offset: 0x01272490
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $onGameEvent$43589(Hashtable data, M934_LadyNoirDarkRitual1 self_)
		{
			if (279803 - 290315 != -10512)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (191197 - 194949 == -3752)
				{
					base..ctor();
					if (49992 - 423265 == -373273)
					{
						this.$data$43598 = data;
						if (24959 - 281575 == -256616)
						{
							this.$self_$43599 = self_;
							if (231194 - 417329 != -186134)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x0600A1C7 RID: 41415 RVA: 0x0127434C File Offset: 0x0127254C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M934_LadyNoirDarkRitual1.$onGameEvent$43589.$(this.$data$43598, this.$self_$43599);
		}

		// Token: 0x0600A1C8 RID: 41416 RVA: 0x01274360 File Offset: 0x01272560
		internal static bool nxe3PrViZJOtY7PEbNW1()
		{
			return true;
		}

		// Token: 0x0600A1C9 RID: 41417 RVA: 0x01274364 File Offset: 0x01272564
		internal static bool xIWItOViCZYchm48uer0()
		{
			return false;
		}

		// Token: 0x04009238 RID: 37432
		internal Hashtable $data$43598;

		// Token: 0x04009239 RID: 37433
		internal M934_LadyNoirDarkRitual1 $self_$43599;

		// Token: 0x02001B0F RID: 6927
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600A1CA RID: 41418 RVA: 0x01274368 File Offset: 0x01272568
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Hashtable data, M934_LadyNoirDarkRitual1 self_)
			{
				if (111591 - 101331 != 10261)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (36853 - 331920 != -295066)
					{
						base..ctor();
						if (129654 - 541555 != -411900)
						{
							this.$data$43596 = data;
							if (231423 - 415381 == -183958)
							{
								this.$self_$43597 = self_;
								if (220349 - 379493 == -159144)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x0600A1CB RID: 41419 RVA: 0x01274424 File Offset: 0x01272624
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (272793 - 65247 != 207547)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_605;
					case 2:
						Game.savePlayer();
						if (240786 - 264935 == -24148)
						{
							continue;
						}
						this.$self_$43597.SendMessage("fadeOut");
						if (38313 - 95741 != -57428)
						{
							continue;
						}
						goto IL_1A;
					case 3:
						Game.mGameStage = 2;
						if (243877 - 294068 == -50190)
						{
							continue;
						}
						Application.LoadLevel("M934_LadyNoirDarkRitual2");
						if (164278 - 305568 != -141290)
						{
							continue;
						}
						goto IL_1F3;
					default:
						if (211166 - 57967 == 153200)
						{
							continue;
						}
						break;
					}
					if (Game.mGameState > eGameState.AllHold)
					{
						if (227216 - 534993 != -307777)
						{
							continue;
						}
						goto IL_282;
					}
					else
					{
						this.$returnCode$43590 = RuntimeServices.UnboxInt32(this.$data$43596[141]);
						if (98304 - 418183 == -319878)
						{
							continue;
						}
						this.$returnValue$43591 = RuntimeServices.UnboxInt32(this.$data$43596[145]);
						if (195779 - 557804 == -362024)
						{
							continue;
						}
						this.$ownerID$43592 = RuntimeServices.UnboxInt32(this.$data$43596[43]);
						if (255833 - 587072 == -331238)
						{
							continue;
						}
						this.$$switch$7981$43593 = this.$returnCode$43590;
						if (291052 - 222215 != 68837)
						{
							continue;
						}
						if (this.$$switch$7981$43593 == 9341)
						{
							if (28631 - 24330 == 4302)
							{
								continue;
							}
						}
						else if (this.$$switch$7981$43593 == -9341)
						{
							if (172345 - 595515 == -423169)
							{
								continue;
							}
							if (this.$returnValue$43591 == 2)
							{
								if (262292 - 464570 != -202278)
								{
									continue;
								}
								if (this.$self_$43597.uKCnJPA3Ksc < 2)
								{
									if (107933 - 52525 != 55408)
									{
										continue;
									}
									this.$self_$43597.uKCnJPA3Ksc = 2;
									if (225299 - 186283 == 39017)
									{
										continue;
									}
									Game.mGameState = eGameState.AllHold;
									if (199268 - 225740 == -26471)
									{
										continue;
									}
									this.$self_$43597.csVnJwr7K4L.StartCoroutine_Auto(this.$self_$43597.csVnJwr7K4L.slerpToObject("ExitCamera1", (float)2));
									if (102585 - 403042 != -300457)
									{
										continue;
									}
									this.$mGameGui$43594 = (GameGui)this.$self_$43597.GetComponent(typeof(GameGui));
									if (172646 - 351248 == -178601)
									{
										continue;
									}
									this.$mGameGui$43594.close();
									if (48132 - 78470 != -30338)
									{
										continue;
									}
									goto IL_550;
								}
							}
						}
						else if (this.$$switch$7981$43593 == 9343)
						{
							if (197321 - 215786 == -18464)
							{
								continue;
							}
							this.$$switch$7979$43595 = this.$returnValue$43591;
							if (268400 - 151250 != 117150)
							{
								continue;
							}
							if (this.$$switch$7979$43595 == 1)
							{
								if (122647 - 462935 != -340288)
								{
									continue;
								}
								this.$self_$43597.BtknJS0UkBK = this.$self_$43597.BtknJS0UkBK - 1;
								if (86566 - 239896 != -153330)
								{
									continue;
								}
								Debug.Log("TailCount:" + this.$self_$43597.BtknJS0UkBK);
								if (44199 - 359682 != -315483)
								{
									continue;
								}
							}
							else if (this.$$switch$7979$43595 == 2)
							{
								if (72137 - 385889 == -313751)
								{
									continue;
								}
								this.$self_$43597.L1dnJB39NRP = this.$self_$43597.L1dnJB39NRP - 1;
								if (216876 - 566515 != -349639)
								{
									continue;
								}
								Debug.Log("TailCount:" + this.$self_$43597.L1dnJB39NRP);
								if (78023 - 265752 == -187728)
								{
									continue;
								}
							}
							else if (this.$$switch$7979$43595 == 3)
							{
								if (207774 - 204894 == 2881)
								{
									continue;
								}
								this.$self_$43597.NPDnJ0QVNc0 = this.$self_$43597.NPDnJ0QVNc0 - 1;
								if (53334 - 587797 == -534462)
								{
									continue;
								}
								Debug.Log("LadyNoirCount:" + this.$self_$43597.L1dnJB39NRP);
								if (230452 - 566716 != -336264)
								{
									continue;
								}
							}
						}
						else
						{
							Debug.LogError("Warning unknown returnCode:" + this.$returnCode$43590);
							if (52271 - 487993 == -435721)
							{
								continue;
							}
						}
					}
					IL_4E2:
					this.YieldDefault(1);
					if (165909 - 278370 != -112460)
					{
						goto Block_33;
					}
					continue;
					IL_1F3:
					goto IL_4E2;
				}
				IL_1A:
				return this.Yield(3, new WaitForSeconds((float)1));
				IL_282:
				Block_33:
				goto IL_605;
				IL_550:
				return this.Yield(2, new WaitForSeconds((float)2));
				IL_605:
				return false;
			}

			// Token: 0x0600A1CC RID: 41420 RVA: 0x01274A48 File Offset: 0x01272C48
			internal static bool JgE52AViL70NieLCyHOw()
			{
				return true;
			}

			// Token: 0x0600A1CD RID: 41421 RVA: 0x01274A4C File Offset: 0x01272C4C
			internal static bool uMIcmsViOFLOixWuTKMx()
			{
				return false;
			}

			// Token: 0x0400923A RID: 37434
			internal int $returnCode$43590;

			// Token: 0x0400923B RID: 37435
			internal int $returnValue$43591;

			// Token: 0x0400923C RID: 37436
			internal int $ownerID$43592;

			// Token: 0x0400923D RID: 37437
			internal int $$switch$7981$43593;

			// Token: 0x0400923E RID: 37438
			internal GameGui $mGameGui$43594;

			// Token: 0x0400923F RID: 37439
			internal int $$switch$7979$43595;

			// Token: 0x04009240 RID: 37440
			internal Hashtable $data$43596;

			// Token: 0x04009241 RID: 37441
			internal M934_LadyNoirDarkRitual1 $self_$43597;
		}
	}

	// Token: 0x02001B10 RID: 6928
	[CompilerGenerated]
	[Serializable]
	internal sealed class $StartEvent$43600 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600A1CE RID: 41422 RVA: 0x01274A50 File Offset: 0x01272C50
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $StartEvent$43600(M934_LadyNoirDarkRitual1 self_)
		{
			if (225102 - 78325 != 146777)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (181093 - 546447 == -365354)
				{
					base..ctor();
					if (130154 - 414347 == -284193)
					{
						this.$self_$43604 = self_;
						if (178205 - 271581 != -93375)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x0600A1CF RID: 41423 RVA: 0x01274AE8 File Offset: 0x01272CE8
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M934_LadyNoirDarkRitual1.$StartEvent$43600.$(this.$self_$43604);
		}

		// Token: 0x0600A1D0 RID: 41424 RVA: 0x01274AF8 File Offset: 0x01272CF8
		internal static bool eabFwwVimC1WMRLWG4Ts()
		{
			return true;
		}

		// Token: 0x0600A1D1 RID: 41425 RVA: 0x01274AFC File Offset: 0x01272CFC
		internal static bool jCnGwDViFMEMHjJal2Ph()
		{
			return false;
		}

		// Token: 0x04009242 RID: 37442
		internal M934_LadyNoirDarkRitual1 $self_$43604;

		// Token: 0x02001B11 RID: 6929
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600A1D2 RID: 41426 RVA: 0x01274B00 File Offset: 0x01272D00
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M934_LadyNoirDarkRitual1 self_)
			{
				if (272384 - 448680 != -176296)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (281320 - 234042 == 47278)
					{
						base..ctor();
						if (175062 - 72286 == 102776)
						{
							this.$self_$43603 = self_;
							if (87701 - 469148 == -381447)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x0600A1D3 RID: 41427 RVA: 0x01274B98 File Offset: 0x01272D98
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (65963 - 260040 != -194077)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_525;
					case 2:
						if (Game.mGameState != eGameState.Start)
						{
							if (170892 - 394218 != -223326)
							{
								continue;
							}
							goto IL_90;
						}
						else
						{
							this.$mStoryGui$43601 = (StoryGui)this.$self_$43603.GetComponent(typeof(StoryGui));
							if (128002 - 218210 != -90208)
							{
								continue;
							}
							if (!this.$mStoryGui$43601)
							{
								if (8114 - 449844 != -441729)
								{
									goto Block_8;
								}
								continue;
							}
							else
							{
								this.$mStoryGui$43601.startStoryMessage(CharacterData.current.Type, CharacterData.current.Name, eTalkType.friend);
								if (62144 - 203296 != -141151)
								{
									goto Block_16;
								}
								continue;
							}
						}
						break;
					case 3:
						if (Game.mGameState != eGameState.Start)
						{
							if (81353 - 179411 != -98058)
							{
								continue;
							}
							goto IL_3E4;
						}
						else
						{
							this.$mStoryGui$43601.newStoryMessage(CharacterData.current.Type, CharacterData.current.Name, Language.getMessage("M934_LadyNoirDarkRitual", 1001), eTalkType.friend);
							if (248389 - 580658 != -332269)
							{
								continue;
							}
							goto IL_55;
						}
						break;
					case 4:
						if (Game.mGameState != eGameState.Start)
						{
							if (148405 - 16165 != 132240)
							{
								continue;
							}
							goto IL_2FE;
						}
						else
						{
							this.$mStoryGui$43601.newStoryMessage(CharacterData.current.Type, CharacterData.current.Name, Language.getMessage("M934_LadyNoirDarkRitual", 1002), eTalkType.friend);
							if (104115 - 137707 == -33591)
							{
								continue;
							}
							this.$self_$43603.csVnJwr7K4L.StartCoroutine_Auto(this.$self_$43603.csVnJwr7K4L.slerpToObject("EventCamera2", (float)3));
							if (192270 - 147600 != 44671)
							{
								goto Block_19;
							}
							continue;
						}
						break;
					case 5:
						if (Game.mGameState != eGameState.Start)
						{
							if (157018 - 417157 != -260138)
							{
								goto Block_32;
							}
							continue;
						}
						else
						{
							this.$mStoryGui$43601.close();
							if (181090 - 574432 != -393341)
							{
								goto Block_11;
							}
							continue;
						}
						break;
					case 6:
						if (Game.mGameState != eGameState.Start)
						{
							if (148616 - 511739 != -363123)
							{
								continue;
							}
							goto IL_1A0;
						}
						else
						{
							this.$mGameGui$43602 = (GameGui)this.$self_$43603.GetComponent(typeof(GameGui));
							if (299268 - 33599 != 265669)
							{
								continue;
							}
							this.$mGameGui$43602.enabled = true;
							if (213171 - 177565 == 35607)
							{
								continue;
							}
							this.$self_$43603.csVnJwr7K4L.enabled = true;
							if (89859 - 466438 != -376579)
							{
								continue;
							}
							goto IL_373;
						}
						break;
					case 7:
						Game.mGameState = eGameState.Normal;
						if (12967 - 128688 != -115721)
						{
							continue;
						}
						Game.mGameTime = Time.time;
						if (31104 - 352139 != -321035)
						{
							continue;
						}
						Game.mStateTime = Time.time;
						if (95417 - 68371 != 27046)
						{
							continue;
						}
						if (this.$self_$43603.zMXnJEoYDWv)
						{
							if (246593 - 526260 == -279666)
							{
								continue;
							}
							this.$self_$43603.audio.PlayOneShot(this.$self_$43603.zMXnJEoYDWv);
							if (203485 - 54061 != 149424)
							{
								continue;
							}
						}
						this.YieldDefault(1);
						if (205436 - 84073 != 121363)
						{
							continue;
						}
						goto IL_525;
					default:
						if (113788 - 52279 != 61509)
						{
							continue;
						}
						break;
					}
					this.$self_$43603.csVnJwr7K4L.alignToObject("EventCamera1");
					if (142851 - 501034 == -358183)
					{
						this.$self_$43603.SendMessage("fadeIn");
						if (66211 - 268145 == -201934)
						{
							break;
						}
					}
				}
				return this.Yield(2, new WaitForSeconds(0.5f));
				IL_55:
				return this.Yield(4, new WaitForSeconds(3.5f));
				IL_90:
				Block_8:
				goto IL_525;
				Block_11:
				return this.Yield(6, new WaitForSeconds(0.5f));
				IL_1A0:
				goto IL_525;
				Block_16:
				return this.Yield(3, new WaitForSeconds(0.5f));
				Block_19:
				return this.Yield(5, new WaitForSeconds(3.5f));
				IL_2FE:
				goto IL_525;
				IL_373:
				return this.Yield(7, new WaitForSeconds(0.5f));
				IL_3E4:
				Block_32:
				IL_525:
				return false;
			}

			// Token: 0x0600A1D4 RID: 41428 RVA: 0x012750DC File Offset: 0x012732DC
			internal static bool ilU8OPViMQFWENBh1myI()
			{
				return true;
			}

			// Token: 0x0600A1D5 RID: 41429 RVA: 0x012750E0 File Offset: 0x012732E0
			internal static bool BX4hDiVixeLCKnxxO3qk()
			{
				return false;
			}

			// Token: 0x04009243 RID: 37443
			internal StoryGui $mStoryGui$43601;

			// Token: 0x04009244 RID: 37444
			internal GameGui $mGameGui$43602;

			// Token: 0x04009245 RID: 37445
			internal M934_LadyNoirDarkRitual1 $self_$43603;
		}
	}

	// Token: 0x02001B12 RID: 6930
	[CompilerGenerated]
	[Serializable]
	internal sealed class $onDeadPlayer$43605 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600A1D6 RID: 41430 RVA: 0x012750E4 File Offset: 0x012732E4
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $onDeadPlayer$43605(M934_LadyNoirDarkRitual1 self_)
		{
			if (74020 - 343356 != -269335)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (146904 - 28895 != 118010)
				{
					base..ctor();
					if (240996 - 260074 != -19077)
					{
						this.$self_$43610 = self_;
						if (107220 - 381319 == -274099)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x0600A1D7 RID: 41431 RVA: 0x0127517C File Offset: 0x0127337C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M934_LadyNoirDarkRitual1.$onDeadPlayer$43605.$(this.$self_$43610);
		}

		// Token: 0x0600A1D8 RID: 41432 RVA: 0x0127518C File Offset: 0x0127338C
		internal static bool z5UeAUVigv7ow8wBiOw0()
		{
			return true;
		}

		// Token: 0x0600A1D9 RID: 41433 RVA: 0x01275190 File Offset: 0x01273390
		internal static bool lrEJmiVifVhGjxorBdbC()
		{
			return false;
		}

		// Token: 0x04009246 RID: 37446
		internal M934_LadyNoirDarkRitual1 $self_$43610;

		// Token: 0x02001B13 RID: 6931
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600A1DA RID: 41434 RVA: 0x01275194 File Offset: 0x01273394
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M934_LadyNoirDarkRitual1 self_)
			{
				if (68208 - 306700 != -238492)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (295554 - 237065 != 58490)
					{
						base..ctor();
						if (4136 - 208800 != -204663)
						{
							this.$self_$43609 = self_;
							if (8539 - 133689 != -125149)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x0600A1DB RID: 41435 RVA: 0x0127522C File Offset: 0x0127342C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (258542 - 469896 != -211353)
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
							if (18920 - 341080 == -322159)
							{
								continue;
							}
							if (Game.mGameState != eGameState.Hold)
							{
								goto IL_245;
							}
							if (6165 - 147390 != -141225)
							{
								continue;
							}
						}
						Game.mGameState = eGameState.Hold;
						if (131636 - 229887 != -98251)
						{
							continue;
						}
						this.$mStoryGui$43606 = (StoryGui)this.$self_$43609.GetComponent(typeof(StoryGui));
						if (117661 - 428371 == -310709)
						{
							continue;
						}
						if (this.$mStoryGui$43606)
						{
							if (70370 - 231821 == -161450)
							{
								continue;
							}
							this.$mStoryGui$43606.close();
							if (210553 - 547859 != -337306)
							{
								continue;
							}
						}
						this.$mChangeGui$43607 = (ChangeGui)this.$self_$43609.GetComponent(typeof(ChangeGui));
						if (14309 - 524729 != -510420)
						{
							continue;
						}
						if (this.$mChangeGui$43607)
						{
							if (203014 - 35756 == 167259)
							{
								continue;
							}
							this.$mChangeGui$43607.close();
							if (52313 - 250426 != -198113)
							{
								continue;
							}
						}
						this.$mGameGui$43608 = (GameGui)this.$self_$43609.GetComponent(typeof(GameGui));
						if (232990 - 474032 == -241041)
						{
							continue;
						}
						if (this.$mGameGui$43608)
						{
							if (97797 - 60774 == 37024)
							{
								continue;
							}
							if (!this.$mGameGui$43608.enabled)
							{
								if (133559 - 303389 != -169830)
								{
									continue;
								}
								this.$mGameGui$43608.enabled = true;
								if (188403 - 47286 != 141117)
								{
									continue;
								}
							}
							this.$mGameGui$43608.openDeadMenu();
							if (227360 - 170121 == 57240)
							{
								continue;
							}
						}
						IL_245:
						this.YieldDefault(1);
						if (125341 - 426275 != -300933)
						{
							goto Block_20;
						}
						continue;
					default:
						if (60471 - 48730 == 11742)
						{
							continue;
						}
						break;
					}
					Debug.Log("On Dead Player");
				}
				while (266364 - 4116 == 262249);
				return this.Yield(2, new WaitForSeconds((float)2));
				Block_20:
				IL_2F9:
				return false;
			}

			// Token: 0x0600A1DC RID: 41436 RVA: 0x01275544 File Offset: 0x01273744
			internal static bool FDylN2VinenYjucGIqLt()
			{
				return true;
			}

			// Token: 0x0600A1DD RID: 41437 RVA: 0x01275548 File Offset: 0x01273748
			internal static bool SqkTB5Vi67S9b0Q6IvTd()
			{
				return false;
			}

			// Token: 0x04009247 RID: 37447
			internal StoryGui $mStoryGui$43606;

			// Token: 0x04009248 RID: 37448
			internal ChangeGui $mChangeGui$43607;

			// Token: 0x04009249 RID: 37449
			internal GameGui $mGameGui$43608;

			// Token: 0x0400924A RID: 37450
			internal M934_LadyNoirDarkRitual1 $self_$43609;
		}
	}

	// Token: 0x02001B14 RID: 6932
	[CompilerGenerated]
	[Serializable]
	internal sealed class $onChangePlayer$43611 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600A1DE RID: 41438 RVA: 0x0127554C File Offset: 0x0127374C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $onChangePlayer$43611(Hashtable data, M934_LadyNoirDarkRitual1 self_)
		{
			if (34935 - 114518 != -79582)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (114290 - 2078 == 112212)
				{
					base..ctor();
					if (13485 - 195896 == -182411)
					{
						this.$data$43616 = data;
						if (115350 - 241213 != -125862)
						{
							this.$self_$43617 = self_;
							if (205529 - 436357 == -230828)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x0600A1DF RID: 41439 RVA: 0x01275608 File Offset: 0x01273808
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M934_LadyNoirDarkRitual1.$onChangePlayer$43611.$(this.$data$43616, this.$self_$43617);
		}

		// Token: 0x0600A1E0 RID: 41440 RVA: 0x0127561C File Offset: 0x0127381C
		internal static bool ayNDCyViiKNOrukRmOiY()
		{
			return true;
		}

		// Token: 0x0600A1E1 RID: 41441 RVA: 0x01275620 File Offset: 0x01273820
		internal static bool Aab6ttViK4RdXl6algTs()
		{
			return false;
		}

		// Token: 0x0400924B RID: 37451
		internal Hashtable $data$43616;

		// Token: 0x0400924C RID: 37452
		internal M934_LadyNoirDarkRitual1 $self_$43617;

		// Token: 0x02001B15 RID: 6933
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600A1E2 RID: 41442 RVA: 0x01275624 File Offset: 0x01273824
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Hashtable data, M934_LadyNoirDarkRitual1 self_)
			{
				if (217979 - 194453 != 23526)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (251304 - 299404 == -48100)
					{
						base..ctor();
						if (104047 - 70646 == 33401)
						{
							this.$data$43614 = data;
							if (56068 - 144799 == -88731)
							{
								this.$self_$43615 = self_;
								if (45916 - 476927 != -431010)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x0600A1E3 RID: 41443 RVA: 0x012756E0 File Offset: 0x012738E0
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (46324 - 393651 != -347327)
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
							if (281416 - 112504 == 168913)
							{
								continue;
							}
							Game.mGameState = eGameState.Normal;
							if (90084 - 371760 != -281676)
							{
								continue;
							}
							this.$mGameGui$43613 = (GameGui)this.$self_$43615.GetComponent(typeof(GameGui));
							if (283528 - 161939 != 121589)
							{
								continue;
							}
							this.$mGameGui$43613.enabled = true;
							if (240931 - 420286 == -179354)
							{
								continue;
							}
						}
						this.YieldDefault(1);
						if (149974 - 263490 != -113515)
						{
							goto Block_8;
						}
						continue;
					default:
						if (102749 - 179258 != -76509)
						{
							continue;
						}
						break;
					}
					UnityEngine.Object.Destroy(Game.mPlayer);
					if (274845 - 494374 != -219528)
					{
						this.$self_$43615.SendMessage("onCreatePlayer", this.$data$43614);
						if (71155 - 371646 != -300490)
						{
							this.$mChangeGui$43612 = (ChangeGui)this.$self_$43615.GetComponent(typeof(ChangeGui));
							if (12498 - 580559 != -568060)
							{
								if (!this.$mChangeGui$43612.enabled)
								{
									break;
								}
								if (145796 - 86122 == 59674)
								{
									this.$mChangeGui$43612.close();
									if (229396 - 566454 != -337057)
									{
										break;
									}
								}
							}
						}
					}
				}
				IL_75:
				return this.Yield(2, new WaitForSeconds(1f));
				Block_8:
				goto IL_205;
				goto IL_75;
				IL_205:
				return false;
			}

			// Token: 0x0600A1E4 RID: 41444 RVA: 0x01275904 File Offset: 0x01273B04
			internal static bool cyKfNKVidR7FkU04uQK6()
			{
				return true;
			}

			// Token: 0x0600A1E5 RID: 41445 RVA: 0x01275908 File Offset: 0x01273B08
			internal static bool w1yG27ViJieU0AcvEUXH()
			{
				return false;
			}

			// Token: 0x0400924D RID: 37453
			internal ChangeGui $mChangeGui$43612;

			// Token: 0x0400924E RID: 37454
			internal GameGui $mGameGui$43613;

			// Token: 0x0400924F RID: 37455
			internal Hashtable $data$43614;

			// Token: 0x04009250 RID: 37456
			internal M934_LadyNoirDarkRitual1 $self_$43615;
		}
	}

	// Token: 0x02001B16 RID: 6934
	[CompilerGenerated]
	[Serializable]
	internal sealed class $onGameComplete$43618 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600A1E6 RID: 41446 RVA: 0x0127590C File Offset: 0x01273B0C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $onGameComplete$43618(Hashtable data, M934_LadyNoirDarkRitual1 self_)
		{
			if (65362 - 187122 != -121759)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (65941 - 136416 != -70474)
				{
					base..ctor();
					if (235442 - 507664 == -272222)
					{
						this.$data$43626 = data;
						if (88155 - 477198 != -389042)
						{
							this.$self_$43627 = self_;
							if (200626 - 110620 == 90006)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x0600A1E7 RID: 41447 RVA: 0x012759C8 File Offset: 0x01273BC8
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M934_LadyNoirDarkRitual1.$onGameComplete$43618.$(this.$data$43626, this.$self_$43627);
		}

		// Token: 0x0600A1E8 RID: 41448 RVA: 0x012759DC File Offset: 0x01273BDC
		internal static bool qrt021ViDfjfVPB4G9Zd()
		{
			return true;
		}

		// Token: 0x0600A1E9 RID: 41449 RVA: 0x012759E0 File Offset: 0x01273BE0
		internal static bool xWGpcsVivl7txa3gU8GZ()
		{
			return false;
		}

		// Token: 0x04009251 RID: 37457
		internal Hashtable $data$43626;

		// Token: 0x04009252 RID: 37458
		internal M934_LadyNoirDarkRitual1 $self_$43627;

		// Token: 0x02001B17 RID: 6935
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600A1EA RID: 41450 RVA: 0x012759E4 File Offset: 0x01273BE4
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Hashtable data, M934_LadyNoirDarkRitual1 self_)
			{
				if (102801 - 227791 != -124989)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (159681 - 49043 == 110638)
					{
						base..ctor();
						if (23742 - 314004 == -290262)
						{
							this.$data$43624 = data;
							if (67890 - 131724 == -63834)
							{
								this.$self_$43625 = self_;
								if (101713 - 54971 != 46743)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x0600A1EB RID: 41451 RVA: 0x01275AA0 File Offset: 0x01273CA0
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (83182 - 40241 != 42941)
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
						this.$mCompleteGui$43620 = (CompleteGui)this.$self_$43625.GetComponent(typeof(CompleteGui));
						if (114591 - 432068 == -317476)
						{
							continue;
						}
						this.$mCompleteGui$43620.Init();
						if (258015 - 589427 == -331411)
						{
							continue;
						}
						this.$mCompleteGui$43620.readData(this.$data$43624);
						if (282870 - 185132 != 97738)
						{
							continue;
						}
						if (this.$result$43619 == 1)
						{
							if (170827 - 262233 == -91405)
							{
								continue;
							}
							this.$mCompleteGui$43620.displayResult(eCompleteType.Success);
							if (267486 - 214997 != 52489)
							{
								continue;
							}
						}
						else
						{
							this.$mCompleteGui$43620.displayResult(eCompleteType.Failed);
							if (193965 - 176280 == 17686)
							{
								continue;
							}
						}
						this.$mGameGui$43621 = (GameGui)this.$self_$43625.GetComponent(typeof(GameGui));
						if (262242 - 207818 != 54424)
						{
							continue;
						}
						this.$mStoryGui$43622 = (StoryGui)this.$self_$43625.GetComponent(typeof(StoryGui));
						if (244747 - 113638 != 131109)
						{
							continue;
						}
						this.$mChangeGui$43623 = (ChangeGui)this.$self_$43625.GetComponent(typeof(ChangeGui));
						if (103617 - 167539 == -63921)
						{
							continue;
						}
						if (this.$mGameGui$43621)
						{
							if (16363 - 21766 != -5403)
							{
								continue;
							}
							this.$mGameGui$43621.close();
							if (217845 - 941 != 216904)
							{
								continue;
							}
						}
						if (this.$mStoryGui$43622)
						{
							if (192014 - 120847 == 71168)
							{
								continue;
							}
							this.$mStoryGui$43622.close();
							if (133977 - 185 == 133793)
							{
								continue;
							}
						}
						if (this.$mChangeGui$43623)
						{
							if (271848 - 27087 == 244762)
							{
								continue;
							}
							this.$mChangeGui$43623.disable();
							if (74937 - 23681 != 51256)
							{
								continue;
							}
						}
						this.YieldDefault(1);
						if (159480 - 87017 != 72464)
						{
							goto Block_12;
						}
						continue;
					default:
						if (270014 - 293255 != -23241)
						{
							continue;
						}
						break;
					}
					Debug.Log("On Mission Complete:" + this.$data$43624[31]);
					if (252423 - 290972 != -38548)
					{
						if (Game.mGameState > eGameState.AllHold)
						{
							if (9525 - 548386 == -538861)
							{
								goto IL_21B;
							}
						}
						else
						{
							Game.mGameState = eGameState.Complete;
							if (48214 - 89541 == -41327)
							{
								this.$result$43619 = RuntimeServices.UnboxInt32(this.$data$43624[31]);
								if (279376 - 531479 != -252102)
								{
									break;
								}
							}
						}
					}
				}
				return this.Yield(2, new WaitForSeconds(1f));
				Block_12:
				IL_21B:
				IL_3DB:
				return false;
			}

			// Token: 0x0600A1EC RID: 41452 RVA: 0x01275E9C File Offset: 0x0127409C
			internal static bool p14qrHViRMKeYtE1lIHC()
			{
				return true;
			}

			// Token: 0x0600A1ED RID: 41453 RVA: 0x01275EA0 File Offset: 0x012740A0
			internal static bool tfVPJwViwHCwXUhBtlQO()
			{
				return false;
			}

			// Token: 0x04009253 RID: 37459
			internal int $result$43619;

			// Token: 0x04009254 RID: 37460
			internal CompleteGui $mCompleteGui$43620;

			// Token: 0x04009255 RID: 37461
			internal GameGui $mGameGui$43621;

			// Token: 0x04009256 RID: 37462
			internal StoryGui $mStoryGui$43622;

			// Token: 0x04009257 RID: 37463
			internal ChangeGui $mChangeGui$43623;

			// Token: 0x04009258 RID: 37464
			internal Hashtable $data$43624;

			// Token: 0x04009259 RID: 37465
			internal M934_LadyNoirDarkRitual1 $self_$43625;
		}
	}

	// Token: 0x02001B18 RID: 6936
	[CompilerGenerated]
	[Serializable]
	internal sealed class $ReturnToTown$43628 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600A1EE RID: 41454 RVA: 0x01275EA4 File Offset: 0x012740A4
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $ReturnToTown$43628(M934_LadyNoirDarkRitual1 self_)
		{
			if (13709 - 247884 != -234174)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (297613 - 227814 == 69799)
				{
					base..ctor();
					if (52762 - 237223 != -184460)
					{
						this.$self_$43632 = self_;
						if (233486 - 511546 == -278060)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x0600A1EF RID: 41455 RVA: 0x01275F3C File Offset: 0x0127413C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M934_LadyNoirDarkRitual1.$ReturnToTown$43628.$(this.$self_$43632);
		}

		// Token: 0x0600A1F0 RID: 41456 RVA: 0x01275F4C File Offset: 0x0127414C
		internal static bool SPjjR9Viq65UytMwABdU()
		{
			return true;
		}

		// Token: 0x0600A1F1 RID: 41457 RVA: 0x01275F50 File Offset: 0x01274150
		internal static bool cgkOUDVi7fJaSdoADXrC()
		{
			return false;
		}

		// Token: 0x0400925A RID: 37466
		internal M934_LadyNoirDarkRitual1 $self_$43632;

		// Token: 0x02001B19 RID: 6937
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600A1F2 RID: 41458 RVA: 0x01275F54 File Offset: 0x01274154
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M934_LadyNoirDarkRitual1 self_)
			{
				if (203544 - 229598 != -26054)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (162681 - 376470 != -213788)
					{
						base..ctor();
						if (3003 - 63322 != -60318)
						{
							this.$self_$43631 = self_;
							if (14985 - 334363 == -319378)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x0600A1F3 RID: 41459 RVA: 0x01275FEC File Offset: 0x012741EC
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (84050 - 229208 != -145157)
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
						this.$self_$43631.LeaveGame();
						if (59942 - 490785 == -430842)
						{
							continue;
						}
						this.YieldDefault(1);
						if (129244 - 246824 != -117580)
						{
							continue;
						}
						goto IL_3AD;
					default:
						if (256346 - 199236 != 57110)
						{
							continue;
						}
						break;
					}
					Game.mGameState = eGameState.Ended;
					if (278851 - 477943 != -199091)
					{
						Game.mStateTime = Time.time;
						if (79200 - 37045 == 42155)
						{
							this.$$switch$7991$43629 = PlayerData.SaveGuild;
							if (82430 - 397680 == -315250)
							{
								if (this.$$switch$7991$43629 == 1)
								{
									if (166528 - 263321 != -96793)
									{
										continue;
									}
									Game.mNextGameCode = 32;
									if (45525 - 297070 != -251545)
									{
										continue;
									}
								}
								else if (this.$$switch$7991$43629 == 2)
								{
									if (206857 - 220101 != -13244)
									{
										continue;
									}
									Game.mNextGameCode = 33;
									if (93319 - 511089 == -417769)
									{
										continue;
									}
								}
								else if (this.$$switch$7991$43629 == 3)
								{
									if (72629 - 232222 != -159593)
									{
										continue;
									}
									Game.mNextGameCode = 34;
									if (160509 - 237336 == -76826)
									{
										continue;
									}
								}
								else if (this.$$switch$7991$43629 == 4)
								{
									if (105790 - 256947 != -151157)
									{
										continue;
									}
									Game.mNextGameCode = 35;
									if (33348 - 274758 == -241409)
									{
										continue;
									}
								}
								else if (this.$$switch$7991$43629 == 5)
								{
									if (299853 - 176009 == 123845)
									{
										continue;
									}
									Game.mNextGameCode = 36;
									if (233503 - 134611 != 98892)
									{
										continue;
									}
								}
								else if (PlayerData.GID == 0)
								{
									if (158849 - 178294 != -19445)
									{
										continue;
									}
									Game.mNextGameCode = 30;
									if (284577 - 69258 == 215320)
									{
										continue;
									}
								}
								else
								{
									Game.mNextGameCode = 31;
									if (120918 - 80530 != 40388)
									{
										continue;
									}
								}
								this.$mGameGui$43630 = (GameGui)this.$self_$43631.GetComponent(typeof(GameGui));
								if (230356 - 499542 != -269185)
								{
									if (this.$mGameGui$43630)
									{
										if (125796 - 146460 == -20663)
										{
											continue;
										}
										this.$mGameGui$43630.close();
										if (297543 - 193151 != 104392)
										{
											continue;
										}
									}
									this.$self_$43631.SendMessage("fadeOut");
									if (233810 - 2750 == 231060)
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

			// Token: 0x0600A1F4 RID: 41460 RVA: 0x012763B8 File Offset: 0x012745B8
			internal static bool yxAgnYViPrMYo4WPwR5l()
			{
				return true;
			}

			// Token: 0x0600A1F5 RID: 41461 RVA: 0x012763BC File Offset: 0x012745BC
			internal static bool K5NmCMVi0DD3KnrmgAHa()
			{
				return false;
			}

			// Token: 0x0400925B RID: 37467
			internal int $$switch$7991$43629;

			// Token: 0x0400925C RID: 37468
			internal GameGui $mGameGui$43630;

			// Token: 0x0400925D RID: 37469
			internal M934_LadyNoirDarkRitual1 $self_$43631;
		}
	}

	// Token: 0x02001B1A RID: 6938
	[CompilerGenerated]
	[Serializable]
	internal sealed class $ReturnToGuild$43633 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600A1F6 RID: 41462 RVA: 0x012763C0 File Offset: 0x012745C0
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $ReturnToGuild$43633(M934_LadyNoirDarkRitual1 self_)
		{
			if (19997 - 20877 != -879)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (82343 - 497275 == -414932)
				{
					base..ctor();
					if (24712 - 265017 == -240305)
					{
						this.$self_$43636 = self_;
						if (9890 - 394524 == -384634)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x0600A1F7 RID: 41463 RVA: 0x01276458 File Offset: 0x01274658
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M934_LadyNoirDarkRitual1.$ReturnToGuild$43633.$(this.$self_$43636);
		}

		// Token: 0x0600A1F8 RID: 41464 RVA: 0x01276468 File Offset: 0x01274668
		internal static bool zNcm9HVibcDwxRR8PIEL()
		{
			return true;
		}

		// Token: 0x0600A1F9 RID: 41465 RVA: 0x0127646C File Offset: 0x0127466C
		internal static bool rlKA5TViunys0t5Ba7vg()
		{
			return false;
		}

		// Token: 0x0400925E RID: 37470
		internal M934_LadyNoirDarkRitual1 $self_$43636;

		// Token: 0x02001B1B RID: 6939
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600A1FA RID: 41466 RVA: 0x01276470 File Offset: 0x01274670
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M934_LadyNoirDarkRitual1 self_)
			{
				if (231103 - 297844 != -66740)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (27417 - 283499 != -256081)
					{
						base..ctor();
						if (292231 - 459991 == -167760)
						{
							this.$self_$43635 = self_;
							if (286485 - 589666 != -303180)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x0600A1FB RID: 41467 RVA: 0x01276508 File Offset: 0x01274708
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (13674 - 175191 != -161516)
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
						this.$self_$43635.LeaveGame();
						if (274513 - 441304 == -166790)
						{
							continue;
						}
						this.YieldDefault(1);
						if (132930 - 356452 != -223521)
						{
							goto Block_2;
						}
						continue;
					default:
						if (180085 - 477850 != -297765)
						{
							continue;
						}
						break;
					}
					Game.mGameState = eGameState.Ended;
					if (264490 - 56257 != 208234)
					{
						Game.mStateTime = Time.time;
						if (132168 - 13773 == 118395)
						{
							Game.mNextGameCode = 31;
							if (105198 - 255309 != -150110)
							{
								this.$mGameGui$43634 = (GameGui)this.$self_$43635.GetComponent(typeof(GameGui));
								if (77464 - 142289 != -64824)
								{
									if (this.$mGameGui$43634)
									{
										if (118997 - 574910 == -455912)
										{
											continue;
										}
										this.$mGameGui$43634.close();
										if (111148 - 227206 == -116057)
										{
											continue;
										}
									}
									this.$self_$43635.SendMessage("fadeOut");
									if (138446 - 561666 == -423220)
									{
										goto IL_185;
									}
								}
							}
						}
					}
				}
				Block_2:
				goto IL_1BD;
				IL_185:
				return this.Yield(2, new WaitForSeconds((float)1));
				IL_1BD:
				return false;
			}

			// Token: 0x0600A1FC RID: 41468 RVA: 0x012766E4 File Offset: 0x012748E4
			internal static bool QAxAA9ViIC7rMOvbuqXj()
			{
				return true;
			}

			// Token: 0x0600A1FD RID: 41469 RVA: 0x012766E8 File Offset: 0x012748E8
			internal static bool wo1I2WViBD0bPfT5aaXq()
			{
				return false;
			}

			// Token: 0x0400925F RID: 37471
			internal GameGui $mGameGui$43634;

			// Token: 0x04009260 RID: 37472
			internal M934_LadyNoirDarkRitual1 $self_$43635;
		}
	}

	// Token: 0x02001B1C RID: 6940
	[CompilerGenerated]
	[Serializable]
	internal sealed class $ReturnToCamp$43637 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600A1FE RID: 41470 RVA: 0x012766EC File Offset: 0x012748EC
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $ReturnToCamp$43637(M934_LadyNoirDarkRitual1 self_)
		{
			if (106399 - 447401 != -341001)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (227894 - 454907 == -227013)
				{
					base..ctor();
					if (296022 - 592895 != -296872)
					{
						this.$self_$43641 = self_;
						if (280229 - 474707 == -194478)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x0600A1FF RID: 41471 RVA: 0x01276784 File Offset: 0x01274984
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M934_LadyNoirDarkRitual1.$ReturnToCamp$43637.$(this.$self_$43641);
		}

		// Token: 0x0600A200 RID: 41472 RVA: 0x01276794 File Offset: 0x01274994
		internal static bool a4whUKVieK8dirMoMJSx()
		{
			return true;
		}

		// Token: 0x0600A201 RID: 41473 RVA: 0x01276798 File Offset: 0x01274998
		internal static bool PXgcPxVirmBQiOGpAV4t()
		{
			return false;
		}

		// Token: 0x04009261 RID: 37473
		internal M934_LadyNoirDarkRitual1 $self_$43641;

		// Token: 0x02001B1D RID: 6941
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600A202 RID: 41474 RVA: 0x0127679C File Offset: 0x0127499C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M934_LadyNoirDarkRitual1 self_)
			{
				if (98410 - 193576 != -95165)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (193167 - 91763 != 101405)
					{
						base..ctor();
						if (182906 - 320236 == -137330)
						{
							this.$self_$43640 = self_;
							if (299893 - 464561 == -164668)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x0600A203 RID: 41475 RVA: 0x01276834 File Offset: 0x01274A34
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (94946 - 285049 != -190102)
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
						this.$self_$43640.LeaveGame();
						if (127473 - 401288 == -273814)
						{
							continue;
						}
						this.YieldDefault(1);
						if (255798 - 336522 != -80724)
						{
							continue;
						}
						goto IL_363;
					default:
						if (26249 - 253897 != -227648)
						{
							continue;
						}
						break;
					}
					Game.mGameState = eGameState.Ended;
					if (231871 - 530618 == -298747)
					{
						Game.mStateTime = Time.time;
						if (151286 - 405533 != -254246)
						{
							this.$$switch$7993$43638 = PlayerData.SaveGuild;
							if (279225 - 398278 != -119052)
							{
								if (this.$$switch$7993$43638 == 1)
								{
									if (129309 - 411120 == -281810)
									{
										continue;
									}
									Game.mNextGameCode = 32;
									if (235455 - 239539 == -4083)
									{
										continue;
									}
								}
								else if (this.$$switch$7993$43638 == 2)
								{
									if (68046 - 405753 != -337707)
									{
										continue;
									}
									Game.mNextGameCode = 33;
									if (256921 - 242932 == 13990)
									{
										continue;
									}
								}
								else if (this.$$switch$7993$43638 == 3)
								{
									if (242631 - 598717 == -356085)
									{
										continue;
									}
									Game.mNextGameCode = 34;
									if (20116 - 304704 != -284588)
									{
										continue;
									}
								}
								else if (this.$$switch$7993$43638 == 4)
								{
									if (16744 - 179989 != -163245)
									{
										continue;
									}
									Game.mNextGameCode = 35;
									if (222940 - 598602 != -375662)
									{
										continue;
									}
								}
								else if (this.$$switch$7993$43638 == 5)
								{
									if (101142 - 59571 != 41571)
									{
										continue;
									}
									Game.mNextGameCode = 36;
									if (104663 - 283183 != -178520)
									{
										continue;
									}
								}
								else
								{
									Game.mNextGameCode = 30;
									if (40454 - 586457 == -546002)
									{
										continue;
									}
								}
								this.$mGameGui$43639 = (GameGui)this.$self_$43640.GetComponent(typeof(GameGui));
								if (72455 - 123618 != -51162)
								{
									if (this.$mGameGui$43639)
									{
										if (205797 - 117260 == 88538)
										{
											continue;
										}
										this.$mGameGui$43639.close();
										if (177432 - 491747 != -314315)
										{
											continue;
										}
									}
									this.$self_$43640.SendMessage("fadeOut");
									if (24583 - 462864 == -438281)
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

			// Token: 0x0600A204 RID: 41476 RVA: 0x01276BB8 File Offset: 0x01274DB8
			internal static bool PLOj5lVij6Kg2auFnoV7()
			{
				return true;
			}

			// Token: 0x0600A205 RID: 41477 RVA: 0x01276BBC File Offset: 0x01274DBC
			internal static bool D0X0fxVih3q7Cmfg3L3b()
			{
				return false;
			}

			// Token: 0x04009262 RID: 37474
			internal int $$switch$7993$43638;

			// Token: 0x04009263 RID: 37475
			internal GameGui $mGameGui$43639;

			// Token: 0x04009264 RID: 37476
			internal M934_LadyNoirDarkRitual1 $self_$43640;
		}
	}
}
