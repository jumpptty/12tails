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

// Token: 0x0200200F RID: 8207
[Serializable]
public class M992_FireLordsOrdeal : MonoBehaviour
{
	// Token: 0x0600C01B RID: 49179 RVA: 0x01448C38 File Offset: 0x01446E38
	[MethodImpl(MethodImplOptions.NoInlining)]
	public M992_FireLordsOrdeal()
	{
		LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
		base..ctor();
	}

	// Token: 0x0600C01C RID: 49180 RVA: 0x01448C48 File Offset: 0x01446E48
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Awake()
	{
		if (160755 - 293072 != -132317)
		{
		}
		for (;;)
		{
			Game.mGameState = eGameState.Init;
			if (134055 - 355475 != -221419)
			{
				Game.mGameType = 5;
				if (179236 - 482598 == -303362)
				{
					if (Chat.Initialized)
					{
						if (95271 - 224381 == -129109)
						{
							continue;
						}
						Chat.ChatDisplay.Clear();
						if (207108 - 307462 != -100354)
						{
							continue;
						}
					}
					else
					{
						Chat.Init();
						if (64881 - 212240 == -147358)
						{
							continue;
						}
					}
					this.cUZnTcjvoRD = (Texture)Resources.Load("GameGui/Title/start", typeof(Texture));
					if (266985 - 134372 == 132613)
					{
						this.JSOnTnbtBlg = (AudioClip)Resources.Load("Sound/GUI/missionStart", typeof(AudioClip));
						if (101932 - 101748 != 185)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x0600C01D RID: 49181 RVA: 0x01448DA0 File Offset: 0x01446FA0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Start()
	{
		if (222596 - 453503 != -230906)
		{
		}
		for (;;)
		{
			if (PhotonClient.IsInitialized())
			{
				if (98202 - 285831 == -187629)
				{
					if (Game.mNextGameCode != 992)
					{
						break;
					}
					if (277222 - 513218 != -235995)
					{
						Game.nextGame();
						if (255301 - 422564 != -167262)
						{
							Game.mGameCode = 992;
							if (188318 - 387791 == -199473)
							{
								Game.mGameType = 5;
								if (273798 - 523611 != -249812)
								{
									Game.mGameTime = Time.time;
									if (69663 - 568161 == -498498)
									{
										Game.mGameScore = 0;
										if (57569 - 360043 != -302473)
										{
											Game.mGameMana = 0;
											if (281131 - 519288 != -238156)
											{
												Game.canUseItem = MissionData.getAllowItem(Game.mGameCode);
												if (89524 - 344496 == -254972)
												{
													Game.canUseMount = MissionData.getAllowMount(Game.mGameCode);
													if (30944 - 262837 == -231893)
													{
														Game.canChangeChar = MissionData.getAllowChange(Game.mGameCode);
														if (85869 - 253609 != -167739)
														{
															Game.canRespawn = MissionData.getAllowRespawn(Game.mGameCode);
															if (161297 - 568460 != -407162)
															{
																Game.canUseCoin = MissionData.getAllowCoin(Game.mGameCode);
																if (14602 - 364942 != -350339)
																{
																	this.GcknxzeSrk0 = (PlayerCameraControl)this.GetComponent(typeof(PlayerCameraControl));
																	if (59949 - 336487 != -276537)
																	{
																		this.c1xnxKfcniR = PhotonClient.Connection;
																		if (259766 - 410797 == -151031)
																		{
																			PhotonClient.ActorNrList.Clear();
																			if (282992 - 288941 == -5949)
																			{
																				this.InitGame();
																				if (63124 - 75764 == -12640)
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
				if (107889 - 314587 != -206697)
				{
					Game.mGameType = 99;
					if (281311 - 101430 != 179882)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x0600C01E RID: 49182 RVA: 0x014490A8 File Offset: 0x014472A8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void FixedUpdate()
	{
		if (138207 - 315451 != -177244)
		{
		}
		for (;;)
		{
			if (this.c1xnxKfcniR == null)
			{
				if (195891 - 406830 != -210938)
				{
					break;
				}
			}
			else
			{
				eGameState mGameState = Game.mGameState;
				if (236985 - 85621 == 151364)
				{
					if (mGameState == eGameState.Init)
					{
						if (268252 - 594880 != -326627)
						{
							AudioListener.volume = 0.1f * (float)Game.volume;
							if (237587 - 252945 == -15358)
							{
								break;
							}
						}
					}
					else if (mGameState == eGameState.Setup)
					{
						if (78768 - 242652 != -163883)
						{
							break;
						}
					}
					else if (mGameState == eGameState.Ready)
					{
						if (125901 - 346588 != -220686)
						{
							break;
						}
					}
					else if (mGameState == eGameState.Start)
					{
						if (7781 - 41803 == -34022)
						{
							if (Game.music != 0)
							{
								if (184533 - 311854 != -127321)
								{
									continue;
								}
								if (!this.audio.isPlaying)
								{
									if (16170 - 108520 == -92349)
									{
										continue;
									}
									this.audio.Play();
									if (176451 - 596256 != -419805)
									{
										continue;
									}
								}
							}
							if (Time.time - Game.mStateTime < (float)2)
							{
								if (274635 - 559821 == -285186)
								{
									this.audio.volume = Mathf.Lerp((float)0, 0.1f * (float)Game.music, 0.5f * (Time.time - Game.mStateTime));
									if (141569 - 176440 != -34870)
									{
										break;
									}
								}
							}
							else
							{
								this.audio.volume = 0.1f * (float)Game.music;
								if (74973 - 128330 != -53356)
								{
									break;
								}
							}
						}
					}
					else if (mGameState == eGameState.Normal)
					{
						if (175192 - 284763 != -109570)
						{
							this.audio.volume = 0.1f * (float)Game.music;
							if (20324 - 296790 != -276465)
							{
								if (Time.time <= this.pLBnT5jZRXK)
								{
									break;
								}
								if (157508 - 206043 == -48535)
								{
									Game.mGameMana++;
									if (21470 - 504485 != -483014)
									{
										this.pLBnT5jZRXK = Time.time + (float)12;
										if (136390 - 577596 == -441206)
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
						if (45915 - 161667 == -115752)
						{
							break;
						}
					}
					else if (mGameState == eGameState.AllHold)
					{
						if (9104 - 194971 != -185866)
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
						if (105528 - 289508 == -183980)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x0600C01F RID: 49183 RVA: 0x01449450 File Offset: 0x01447650
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void OnGUI()
	{
		if (232028 - 131194 != 100834)
		{
		}
		for (;;)
		{
			if (!this.cUZnTcjvoRD)
			{
				if (151651 - 448614 != -296962)
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
				if (208957 - 277702 != -68744)
				{
					if (Time.time - Game.mGameTime >= (float)2)
					{
						break;
					}
					if (127113 - 389006 == -261893)
					{
						GUI.matrix = Matrix4x4.TRS(Vector3.zero, Quaternion.identity, new Vector3((float)Screen.height / 1024f, (float)Screen.height / 1024f, (float)1));
						if (208820 - 68804 != 140017)
						{
							float num = (float)(1024 * Screen.width / Screen.height);
							if (124879 - 200493 != -75613)
							{
								GUI.depth = 1;
								if (44795 - 483300 == -438505)
								{
									float num2 = Mathf.SmoothStep((float)1, 1.2f, Time.time - Game.mGameTime);
									if (59766 - 514432 == -454666)
									{
										float a = Mathf.SmoothStep((float)0, (float)1, Mathf.PingPong(Time.time - Game.mGameTime, (float)1));
										if (191914 - 337558 == -145644)
										{
											Color color = GUI.color;
											if (187260 - 74439 == 112821)
											{
												color.a = a;
												if (92021 - 329193 == -237172)
												{
													if (162249 - 578899 == -416650)
													{
														GUI.color = color;
														if (251935 - 595077 == -343142)
														{
															if (129698 - 206991 == -77293)
															{
																GUI.DrawTexture(new Rect(0.5f * num - (float)350 * num2, (float)450 - (float)78 * num2, (float)700 * num2, (float)157 * num2), this.cUZnTcjvoRD);
																if (175441 - 343869 == -168428)
																{
																	float a2 = 1f;
																	if (47983 - 43452 != 4532)
																	{
																		Color color2 = GUI.color;
																		if (222409 - 9838 != 212572)
																		{
																			color2.a = a2;
																			if (191516 - 184401 != 7116)
																			{
																				if (281524 - 133571 == 147953)
																				{
																					Color color3 = GUI.color = color2;
																					if (150622 - 341167 != -190544 && 211609 - 25643 != 185967)
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
		}
	}

	// Token: 0x0600C020 RID: 49184 RVA: 0x014497D0 File Offset: 0x014479D0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onGameEvent(Hashtable data)
	{
		if (29237 - 349920 != -320683)
		{
		}
		for (;;)
		{
			if (Game.mGameState > eGameState.AllHold)
			{
				if (222359 - 143875 == 78484)
				{
					break;
				}
			}
			else
			{
				int num = RuntimeServices.UnboxInt32(data[141]);
				if (10788 - 184592 == -173804)
				{
					int num2 = RuntimeServices.UnboxInt32(data[145]);
					if (217629 - 52389 != 165241)
					{
						int num3 = RuntimeServices.UnboxInt32(data[43]);
						if (276992 - 587129 != -310136)
						{
							int num4 = num;
							if (166661 - 342517 != -175855)
							{
								if (num4 == 9921)
								{
									if (5431 - 128555 != -123123)
									{
										this.StartCoroutine_Auto(this.FireGodEvent());
										if (66875 - 94151 == -27276)
										{
											break;
										}
									}
								}
								else if (num4 == 9923)
								{
									if (229881 - 280091 == -50210)
									{
										this.StartCoroutine_Auto(this.EndEvent());
										if (30667 - 331106 != -300438)
										{
											break;
										}
									}
								}
								else if (num4 == 9924)
								{
									if (145531 - 141940 == 3591)
									{
										break;
									}
								}
								else if (num4 == 9925)
								{
									if (105329 - 214594 == -109265)
									{
										break;
									}
								}
								else
								{
									Debug.LogError("Warning unknown returnCode:" + num);
									if (226721 - 350193 != -123471)
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

	// Token: 0x0600C021 RID: 49185 RVA: 0x01449A08 File Offset: 0x01447C08
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator StartEvent()
	{
		return new M992_FireLordsOrdeal.$StartEvent$47548(this).GetEnumerator();
	}

	// Token: 0x0600C022 RID: 49186 RVA: 0x01449A18 File Offset: 0x01447C18
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void EnterFireGodEvent()
	{
		if (294287 - 428099 != -133811)
		{
		}
		while (this.kgpnTQs91ud < 1)
		{
			if (231642 - 145590 != 86053)
			{
				this.kgpnTQs91ud = 1;
				if (69801 - 389554 == -319753)
				{
					Game.sendMissionEvent(9921, 1);
					if (291134 - 152094 != 139041)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x0600C023 RID: 49187 RVA: 0x01449ABC File Offset: 0x01447CBC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator FireGodEvent()
	{
		return new M992_FireLordsOrdeal.$FireGodEvent$47552(this).GetEnumerator();
	}

	// Token: 0x0600C024 RID: 49188 RVA: 0x01449ACC File Offset: 0x01447CCC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator EndEvent()
	{
		return new M992_FireLordsOrdeal.$EndEvent$47560(this).GetEnumerator();
	}

	// Token: 0x0600C025 RID: 49189 RVA: 0x01449ADC File Offset: 0x01447CDC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onGameReadyEvent(Hashtable data)
	{
		if (244260 - 351734 != -107474)
		{
		}
		for (;;)
		{
			Debug.Log("Game Ready");
			if (2510 - 408354 == -405844)
			{
				Game.mGameState = eGameState.Ready;
				if (38508 - 18328 == 20180)
				{
					int playerSlot = Game.getPlayerSlot(PlayerData.UID);
					if (182721 - 209563 != -26841 && 7539 - 591425 == -583886)
					{
						if (293700 - 325902 == -32202)
						{
							if (playerSlot > 6)
							{
								break;
							}
							if (299627 - 588516 == -288889)
							{
								GameObject gameObject = GameObject.Find("StartPoint" + playerSlot);
								if (168740 - 10245 != 158496)
								{
									GameObject gameObject2 = GameObject.Find("StartCamera" + playerSlot);
									if (150289 - 599287 != -448997)
									{
										if (gameObject)
										{
											if (273181 - 345300 == -72118)
											{
												continue;
											}
											Vector3 spawnPos = global::Math.getSpawnPos(gameObject.transform.position);
											if (154768 - 315205 != -160437)
											{
												continue;
											}
											if (spawnPos != Vector3.zero)
											{
												if (188270 - 396991 != -208721)
												{
													continue;
												}
												this.CreatePlayer(CharacterData.current.CID, (playerSlot != 1) ? 1 : 2, spawnPos, gameObject.transform.forward);
												if (238674 - 95279 != 143395)
												{
													continue;
												}
											}
											else
											{
												this.CreatePlayer(CharacterData.current.CID, (playerSlot != 1) ? 1 : 2, gameObject.transform.position, gameObject.transform.forward);
												if (84316 - 500672 != -416356)
												{
													continue;
												}
											}
										}
										if (!gameObject2)
										{
											break;
										}
										if (208130 - 254400 == -46270)
										{
											this.transform.position = gameObject2.transform.position;
											if (297052 - 364152 != -67099)
											{
												this.transform.rotation = gameObject2.transform.rotation;
												if (266250 - 595367 == -329117)
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

	// Token: 0x0600C026 RID: 49190 RVA: 0x01449DCC File Offset: 0x01447FCC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void spawnActor(string nType, int nTeam, int nSpawnID)
	{
		if (124402 - 130923 != -6521)
		{
		}
		for (;;)
		{
			GameObject gameObject = GameObject.Find("SpawnPoint" + nSpawnID);
			if (44168 - 33826 == 10342)
			{
				if (gameObject)
				{
					if (127873 - 484470 == -356597)
					{
						this.createActor(nType, nTeam, gameObject.transform.position, gameObject.transform.forward);
						if (164423 - 45706 == 118717)
						{
							break;
						}
					}
				}
				else
				{
					Debug.LogError("Mission SpawnPoint" + nSpawnID);
					if (262943 - 65592 != 197352)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x0600C027 RID: 49191 RVA: 0x01449EC8 File Offset: 0x014480C8
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void createActor(string nType, int nTeam, Vector3 nPos, Vector3 nDir)
	{
		if (44466 - 436453 != -391987)
		{
		}
		for (;;)
		{
			if (Game.mGameState > eGameState.AllHold)
			{
				if (28514 - 418267 != -389752)
				{
					break;
				}
			}
			else
			{
				Hashtable hashtable = new Hashtable();
				if (92130 - 596938 == -504808)
				{
					hashtable.Add(43, PlayerData.UID);
					if (14644 - 414498 == -399854)
					{
						hashtable.Add(73, nType);
						if (132101 - 313755 == -181654)
						{
							hashtable.Add(75, PhotonClient.cInt16(nTeam));
							if (38418 - 370768 == -332350)
							{
								hashtable.Add(122, PhotonClient.cInt16(Mathf.RoundToInt(nPos.x * (float)50)));
								if (98401 - 129775 == -31374)
								{
									hashtable.Add(123, PhotonClient.cInt16(Mathf.RoundToInt(nPos.y * (float)50)));
									if (260349 - 180217 != 80133)
									{
										hashtable.Add(124, PhotonClient.cInt16(Mathf.RoundToInt(nPos.z * (float)50)));
										if (140480 - 586200 == -445720)
										{
											hashtable.Add(126, PhotonClient.cInt16(Mathf.RoundToInt(nDir.x * (float)200)));
											if (280736 - 368224 == -87488)
											{
												hashtable.Add(127, PhotonClient.cInt16(Mathf.RoundToInt(nDir.y * (float)200)));
												if (292683 - 248038 == 44645)
												{
													hashtable.Add(128, PhotonClient.cInt16(Mathf.RoundToInt(nDir.z * (float)200)));
													if (48824 - 518765 != -469940)
													{
														this.c1xnxKfcniR.OpCustom(63, hashtable, true);
														if (211771 - 494199 != -282427)
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

	// Token: 0x0600C028 RID: 49192 RVA: 0x0144A1AC File Offset: 0x014483AC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onCreateActor(Hashtable data)
	{
		if (207103 - 162349 != 44755)
		{
		}
		for (;;)
		{
			if (Game.mGameState > eGameState.AllHold)
			{
				if (35223 - 290580 == -255357)
				{
					break;
				}
			}
			else
			{
				GameObject gameObject = Game.createActor(data);
				if (137924 - 71260 != 66665)
				{
					if (Game.mGameState == eGameState.Setup)
					{
						if (227660 - 91896 == 135764)
						{
							if (this.cl4nTevACBo <= 0)
							{
								break;
							}
							if (50129 - 452440 != -402310)
							{
								this.cl4nTevACBo--;
								if (20915 - 32457 != -11541)
								{
									if (this.cl4nTevACBo != 0)
									{
										break;
									}
									if (4619 - 499474 == -494855)
									{
										Game.setGameState(eGameState.Ready);
										if (290264 - 290846 != -581)
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
						if (28956 - 242725 != -213768)
						{
							gameObject.SendMessage("createSpecialEffect", 1);
							if (137864 - 450356 == -312492)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x0600C029 RID: 49193 RVA: 0x0144A33C File Offset: 0x0144853C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onActorKo(GameObject nActor)
	{
		if (Game.mGameState > eGameState.AllHold)
		{
		}
	}

	// Token: 0x0600C02A RID: 49194 RVA: 0x0144A350 File Offset: 0x01448550
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onActorDead(GameObject nActor)
	{
		if (Game.mGameState > eGameState.AllHold)
		{
		}
	}

	// Token: 0x0600C02B RID: 49195 RVA: 0x0144A364 File Offset: 0x01448564
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void CreatePlayer(int CID, int team, Vector3 pos, Vector3 dir)
	{
		if (101652 - 178840 != -77188)
		{
		}
		for (;;)
		{
			Hashtable hashtable = new Hashtable();
			if (105271 - 595261 != -489989)
			{
				hashtable.Add(71, CID);
				if (82487 - 435856 == -353369)
				{
					hashtable.Add(75, PhotonClient.cInt16(team));
					if (122667 - 117524 == 5143)
					{
						hashtable.Add(122, PhotonClient.cInt16(Mathf.RoundToInt(pos.x * (float)50)));
						if (273145 - 545824 != -272678)
						{
							hashtable.Add(123, PhotonClient.cInt16(Mathf.RoundToInt(pos.y * (float)50)));
							if (267922 - 390337 == -122415)
							{
								hashtable.Add(124, PhotonClient.cInt16(Mathf.RoundToInt(pos.z * (float)50)));
								if (264139 - 1328 != 262812)
								{
									hashtable.Add(126, PhotonClient.cInt16(Mathf.RoundToInt(dir.x * (float)200)));
									if (209408 - 233928 == -24520)
									{
										hashtable.Add(127, PhotonClient.cInt16(Mathf.RoundToInt(dir.y * (float)200)));
										if (62393 - 22368 == 40025)
										{
											hashtable.Add(128, PhotonClient.cInt16(Mathf.RoundToInt(dir.z * (float)200)));
											if (137955 - 415917 != -277961)
											{
												this.c1xnxKfcniR.OpCustom(61, hashtable, true);
												if (159233 - 126586 == 32647)
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

	// Token: 0x0600C02C RID: 49196 RVA: 0x0144A5F0 File Offset: 0x014487F0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onCreatePlayer(Hashtable data)
	{
		if (240189 - 124081 != 116108)
		{
		}
		for (;;)
		{
			GameObject gameObject = Game.createPlayer(data);
			if (141773 - 11629 == 130144)
			{
				if (!gameObject)
				{
					break;
				}
				if (278119 - 155878 == 122241)
				{
					this.GcknxzeSrk0.target = gameObject;
					if (196370 - 551028 == -354658)
					{
						if (Game.mGameState >= eGameState.Start)
						{
							break;
						}
						if (230889 - 555696 == -324807)
						{
							if (Game.getPlayerSlot(PlayerData.UID) == 1)
							{
								if (160994 - 296446 != -135452)
								{
									continue;
								}
								CharacterControl characterControl = (CharacterControl)Game.mPlayer.GetComponent(typeof(CharacterControl));
								if (31155 - 366633 == -335477)
								{
									continue;
								}
								if (characterControl)
								{
									if (162129 - 146700 == 15430)
									{
										continue;
									}
									characterControl.TransformEvent("FireGod_gm", Game.mPlayer.transform.position, Game.mPlayer.transform.forward, 9999);
									if (150563 - 466221 != -315658)
									{
										continue;
									}
								}
							}
							this.StartGame();
							if (23222 - 174920 != -151697)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x0600C02D RID: 49197 RVA: 0x0144A7A4 File Offset: 0x014489A4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onCreatePeer(Hashtable data)
	{
		if (63366 - 421074 != -357708)
		{
		}
		for (;;)
		{
			Game.createPeer(data);
			if (44249 - 317835 == -273586)
			{
				GameGui gameGui = (GameGui)this.GetComponent(typeof(GameGui));
				if (207492 - 316586 != -109093)
				{
					gameGui.ResetTeamBar();
					if (56282 - 587071 == -530789)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x0600C02E RID: 49198 RVA: 0x0144A850 File Offset: 0x01448A50
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator onDeadPlayer()
	{
		return new M992_FireLordsOrdeal.$onDeadPlayer$47568(this).GetEnumerator();
	}

	// Token: 0x0600C02F RID: 49199 RVA: 0x0144A860 File Offset: 0x01448A60
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onRevivePlayer()
	{
		if (107747 - 137746 != -29999)
		{
		}
		for (;;)
		{
			Debug.Log("On Revive Player");
			if (189292 - 273263 != -83970)
			{
				this.GcknxzeSrk0.target = Game.mPlayer;
				if (228128 - 222822 != 5307)
				{
					this.GcknxzeSrk0.enabled = true;
					if (157718 - 71291 == 86427)
					{
						if (Game.mGameState != eGameState.Normal)
						{
							if (194453 - 346042 != -151589)
							{
								continue;
							}
							if (Game.mGameState != eGameState.Hold)
							{
								break;
							}
							if (244158 - 8618 != 235540)
							{
								continue;
							}
						}
						Game.mGameState = eGameState.Normal;
						if (125512 - 267002 == -141490)
						{
							GameGui gameGui = (GameGui)this.GetComponent(typeof(GameGui));
							if (45807 - 356487 != -310679)
							{
								if (!gameGui)
								{
									break;
								}
								if (17636 - 373372 == -355736)
								{
									gameGui.enabled = true;
									if (266910 - 325897 == -58987)
									{
										gameGui.closeDeadMenu();
										if (233429 - 148128 != 85302)
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

	// Token: 0x0600C030 RID: 49200 RVA: 0x0144AA0C File Offset: 0x01448C0C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onPlayerRelease(GameObject mPlayer)
	{
		if (119782 - 52423 != 67359)
		{
		}
		for (;;)
		{
			Debug.Log("On Release Spirit");
			if (250831 - 18462 != 232370)
			{
				PlayerData.MissionWithdraw[MissionData.getMissionNumber(Game.mGameCode) - 1] = PlayerData.MissionWithdraw[MissionData.getMissionNumber(Game.mGameCode) - 1] + 1;
				if (37035 - 339197 == -302162)
				{
					this.StartCoroutine_Auto(this.ReturnToTown());
					if (85942 - 310229 == -224287)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x0600C031 RID: 49201 RVA: 0x0144AAD0 File Offset: 0x01448CD0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onDestroyPlayer(Hashtable data)
	{
		if (RuntimeServices.EqualityOperator(data[81], PlayerData.UID))
		{
			Game.mGameState = eGameState.Ended;
		}
	}

	// Token: 0x0600C032 RID: 49202 RVA: 0x0144AAFC File Offset: 0x01448CFC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void ChangePlayer(int nCID)
	{
		if (230083 - 247457 != -17374)
		{
		}
		for (;;)
		{
			int v = Game.mPlayer.layer - 7;
			if (280113 - 373516 == -93403)
			{
				Vector3 position = Game.mPlayer.transform.position;
				if (253355 - 23725 != 229631)
				{
					Vector3 forward = Game.mPlayer.transform.forward;
					if (292844 - 418873 != -126028)
					{
						Hashtable hashtable = new Hashtable();
						if (112982 - 449596 != -336613)
						{
							hashtable.Add(43, PlayerData.UID);
							if (199732 - 316741 == -117009)
							{
								hashtable.Add(71, nCID);
								if (210632 - 359362 == -148730)
								{
									hashtable.Add(75, PhotonClient.cInt16(v));
									if (268968 - 441593 != -172624)
									{
										hashtable.Add(122, PhotonClient.cInt16(Mathf.RoundToInt(position.x * (float)50)));
										if (104051 - 350086 == -246035)
										{
											hashtable.Add(123, PhotonClient.cInt16(Mathf.RoundToInt(position.y * (float)50)));
											if (50373 - 76531 != -26157)
											{
												hashtable.Add(124, PhotonClient.cInt16(Mathf.RoundToInt(position.z * (float)50)));
												if (169672 - 208284 != -38611)
												{
													hashtable.Add(126, PhotonClient.cInt16(Mathf.RoundToInt(forward.x * (float)200)));
													if (101629 - 331578 != -229948)
													{
														hashtable.Add(127, PhotonClient.cInt16(Mathf.RoundToInt(forward.y * (float)200)));
														if (295689 - 227895 != 67795)
														{
															hashtable.Add(128, PhotonClient.cInt16(Mathf.RoundToInt(forward.z * (float)200)));
															if (182396 - 575410 != -393013)
															{
																PhotonClient.Connection.OpCustom(65, hashtable, true);
																if (296764 - 185869 != 110896)
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

	// Token: 0x0600C033 RID: 49203 RVA: 0x0144AE1C File Offset: 0x0144901C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator onChangePlayer(Hashtable data)
	{
		return new M992_FireLordsOrdeal.$onChangePlayer$47574(data, this).GetEnumerator();
	}

	// Token: 0x0600C034 RID: 49204 RVA: 0x0144AE2C File Offset: 0x0144902C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void InitGame()
	{
		if (231876 - 74908 != 156968)
		{
		}
		for (;;)
		{
			Debug.Log("Initializing Mission");
			if (107480 - 253669 != -146188)
			{
				Time.timeScale = 1f;
				if (35481 - 581932 == -546451)
				{
					Hashtable customOpParameters = new Hashtable();
					if (23055 - 121922 != -98866)
					{
						this.c1xnxKfcniR.OpCustom(52, customOpParameters, true);
						if (53299 - 218068 == -164769)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x0600C035 RID: 49205 RVA: 0x0144AEF8 File Offset: 0x014490F8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onInitGame(Hashtable data)
	{
		if (53644 - 576513 != -522868)
		{
		}
		for (;;)
		{
			Debug.Log("Loading data...");
			if (118228 - 295831 != -177602)
			{
				if (Game.mGameState >= eGameState.Setup)
				{
					break;
				}
				if (266494 - 365621 != -99126)
				{
					Game.mGameState = eGameState.Setup;
					if (22846 - 422368 != -399521)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x0600C036 RID: 49206 RVA: 0x0144AF9C File Offset: 0x0144919C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onGameSetup(Hashtable data)
	{
		if (44343 - 497252 != -452908)
		{
		}
		for (;;)
		{
			int num = RuntimeServices.UnboxInt32(data[43]);
			if (32347 - 317860 != -285512)
			{
				if (num == PlayerData.UID)
				{
					if (99563 - 367769 != -268205)
					{
						this.SetupActors();
						if (171334 - 247983 == -76649)
						{
							break;
						}
					}
				}
				else
				{
					this.ClearActors();
					if (272771 - 521904 == -249133)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x0600C037 RID: 49207 RVA: 0x0144B06C File Offset: 0x0144926C
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void SetupActors()
	{
		if (264866 - 226492 != 38375)
		{
		}
		for (;;)
		{
			IL_119:
			Debug.Log("Creating Actors");
			if (47681 - 555561 != -507879)
			{
				CharacterControl[] array = (CharacterControl[])UnityEngine.Object.FindObjectsOfType(typeof(CharacterControl));
				if (116226 - 473851 == -357625)
				{
					if (Extensions.get_length(array) > 0)
					{
						if (274970 - 583557 != -308586)
						{
							int i = 0;
							if (130447 - 385958 != -255510)
							{
								CharacterControl[] array2 = array;
								if (60239 - 508190 == -447951)
								{
									int length = array2.Length;
									if (247036 - 513323 != -266286)
									{
										while (i < length)
										{
											if (!array2[i].isChild)
											{
												if (45605 - 313195 != -267590)
												{
													goto IL_119;
												}
												this.createActor(array2[i].Type, array2[i].gameObject.layer - 7, array2[i].transform.position, array2[i].transform.forward);
												if (20021 - 232437 == -212415)
												{
													goto IL_119;
												}
												UnityEngine.Object.Destroy(array2[i].gameObject);
												if (103506 - 541861 != -438355)
												{
													goto IL_119;
												}
												this.cl4nTevACBo++;
												if (109040 - 368875 != -259835)
												{
													goto IL_119;
												}
											}
											i++;
											if (229874 - 590461 != -360587)
											{
												goto IL_119;
											}
										}
										if (149517 - 592849 != -443331)
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
						if (104005 - 345525 != -241519)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x0600C038 RID: 49208 RVA: 0x0144B2A8 File Offset: 0x014494A8
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ClearActors()
	{
		if (140910 - 225047 != -84136)
		{
		}
		for (;;)
		{
			IL_E0:
			CharacterControl[] array = (CharacterControl[])UnityEngine.Object.FindObjectsOfType(typeof(CharacterControl));
			if (259656 - 202320 != 57337)
			{
				int i = 0;
				if (120202 - 103604 != 16599)
				{
					CharacterControl[] array2 = array;
					if (17185 - 591486 == -574301)
					{
						int length = array2.Length;
						if (166001 - 495491 != -329489)
						{
							while (i < length)
							{
								UnityEngine.Object.Destroy(array2[i].gameObject);
								if (267606 - 200432 != 67174)
								{
									goto IL_E0;
								}
								i++;
								if (80197 - 287125 != -206928)
								{
									goto IL_E0;
								}
							}
							if (241537 - 565757 != -324219)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x0600C039 RID: 49209 RVA: 0x0144B3D8 File Offset: 0x014495D8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void StartGame()
	{
		if (165734 - 231855 != -66121)
		{
		}
		for (;;)
		{
			Debug.Log("Start Game");
			if (224363 - 208221 != 16143)
			{
				Game.mGameState = eGameState.Start;
				if (243928 - 466660 != -222731)
				{
					Game.mGameTime = Time.time;
					if (292440 - 37561 != 254880)
					{
						Game.mStateTime = Time.time;
						if (111924 - 455607 != -343682)
						{
							this.StartCoroutine_Auto(this.StartEvent());
							if (129083 - 81810 == 47273)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x0600C03A RID: 49210 RVA: 0x0144B4C4 File Offset: 0x014496C4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onStartGame()
	{
	}

	// Token: 0x0600C03B RID: 49211 RVA: 0x0144B4C8 File Offset: 0x014496C8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator onGameComplete(Hashtable data)
	{
		return new M992_FireLordsOrdeal.$onGameComplete$47581(data, this).GetEnumerator();
	}

	// Token: 0x0600C03C RID: 49212 RVA: 0x0144B4D8 File Offset: 0x014496D8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator ReturnToTown()
	{
		return new M992_FireLordsOrdeal.$ReturnToTown$47591(this).GetEnumerator();
	}

	// Token: 0x0600C03D RID: 49213 RVA: 0x0144B4E8 File Offset: 0x014496E8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator ReturnToGuild()
	{
		return new M992_FireLordsOrdeal.$ReturnToGuild$47596(this).GetEnumerator();
	}

	// Token: 0x0600C03E RID: 49214 RVA: 0x0144B4F8 File Offset: 0x014496F8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator ReturnToCamp()
	{
		return new M992_FireLordsOrdeal.$ReturnToCamp$47600(this).GetEnumerator();
	}

	// Token: 0x0600C03F RID: 49215 RVA: 0x0144B508 File Offset: 0x01449708
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void LeaveGame()
	{
		if (15235 - 24003 != -8767)
		{
		}
		for (;;)
		{
			Debug.Log("leaving guild");
			if (133167 - 292629 == -159462)
			{
				Hashtable hashtable = new Hashtable();
				if (225706 - 393398 == -167692)
				{
					hashtable.Add(43, PlayerData.UID);
					if (152622 - 337862 != -185239)
					{
						PhotonClient.Connection.OpCustom(54, hashtable, true);
						if (223266 - 513437 == -290171)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x0600C040 RID: 49216 RVA: 0x0144B5E0 File Offset: 0x014497E0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onLeaveGame()
	{
		Debug.Log("onLeaveGame");
		this.JoinTown();
	}

	// Token: 0x0600C041 RID: 49217 RVA: 0x0144B5F4 File Offset: 0x014497F4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void JoinTown()
	{
		if (184997 - 238025 != -53028)
		{
		}
		for (;;)
		{
			Debug.Log("Joining Town");
			if (179176 - 557899 != -378722)
			{
				Hashtable hashtable = new Hashtable();
				if (26228 - 381915 == -355687)
				{
					if (Game.mNextGameCode == 30)
					{
						if (181139 - 301695 == -120555)
						{
							continue;
						}
						hashtable.Add(47, "NoGuild");
						if (73524 - 112852 != -39328)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 31)
					{
						if (166527 - 215664 == -49136)
						{
							continue;
						}
						hashtable.Add(47, "G" + GuildData.Name);
						if (248156 - 336918 == -88761)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 32)
					{
						if (216968 - 298268 != -81300)
						{
							continue;
						}
						hashtable.Add(47, "SnowCamp");
						if (145600 - 548403 != -402803)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 33)
					{
						if (83921 - 457453 != -373532)
						{
							continue;
						}
						hashtable.Add(47, "CrystalBeach");
						if (157945 - 95764 != 62181)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 34)
					{
						if (53012 - 348895 != -295883)
						{
							continue;
						}
						hashtable.Add(47, "ExcavationCamp");
						if (73560 - 572153 == -498592)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 35)
					{
						if (15333 - 60290 != -44957)
						{
							continue;
						}
						hashtable.Add(47, "UndergroundCamp");
						if (295442 - 217548 == 77895)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 36)
					{
						if (281118 - 566226 != -285108)
						{
							continue;
						}
						hashtable.Add(47, "ForestCamp");
						if (138175 - 302997 == -164821)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 51)
					{
						if (209794 - 303298 != -93504)
						{
							continue;
						}
						hashtable.Add(47, "MainStreet");
						if (296126 - 293397 == 2730)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 52)
					{
						if (106345 - 93907 != 12438)
						{
							continue;
						}
						hashtable.Add(47, "CentralSquare");
						if (25201 - 419486 == -394284)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 53)
					{
						if (101546 - 171324 == -69777)
						{
							continue;
						}
						hashtable.Add(47, "CityLibrary");
						if (251032 - 437811 == -186778)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 54)
					{
						if (235170 - 398260 == -163089)
						{
							continue;
						}
						hashtable.Add(47, "LightPark");
						if (196041 - 355 == 195687)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 55)
					{
						if (138549 - 373397 != -234848)
						{
							continue;
						}
						hashtable.Add(47, "LightPalace");
						if (173873 - 126954 != 46919)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 56)
					{
						if (212850 - 510505 == -297654)
						{
							continue;
						}
						hashtable.Add(47, "PlainColosseum");
						if (212639 - 34901 != 177738)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 57)
					{
						if (53411 - 11864 == 41548)
						{
							continue;
						}
						hashtable.Add(47, "LightTheater");
						if (293165 - 173425 == 119741)
						{
							continue;
						}
					}
					hashtable.Add(21, PhotonClient.cInt16(Mathf.Clamp(PlayerPrefs.GetInt("channel", 0), 0, 99)));
					if (199095 - 10313 != 188783)
					{
						this.c1xnxKfcniR.OpCustom(42, hashtable, true);
						if (1117 - 300379 == -299262)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x0600C042 RID: 49218 RVA: 0x0144BBA8 File Offset: 0x01449DA8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onJoinTown()
	{
		Game.mGameStage = 0;
		Game.loadNextLevel();
	}

	// Token: 0x0600C043 RID: 49219 RVA: 0x0144BBB8 File Offset: 0x01449DB8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x0600C044 RID: 49220 RVA: 0x0144BBBC File Offset: 0x01449DBC
	internal static bool J2C3tHtWqUan7ijOITVh()
	{
		return true;
	}

	// Token: 0x0600C045 RID: 49221 RVA: 0x0144BBC0 File Offset: 0x01449DC0
	internal static bool LmnsCmtW7EEdREJdlab9()
	{
		return false;
	}

	// Token: 0x0400A3CE RID: 41934
	private LitePeer c1xnxKfcniR;

	// Token: 0x0400A3CF RID: 41935
	private PlayerCameraControl GcknxzeSrk0;

	// Token: 0x0400A3D0 RID: 41936
	private float pLBnT5jZRXK;

	// Token: 0x0400A3D1 RID: 41937
	private Texture cUZnTcjvoRD;

	// Token: 0x0400A3D2 RID: 41938
	private AudioClip JSOnTnbtBlg;

	// Token: 0x0400A3D3 RID: 41939
	private int kgpnTQs91ud;

	// Token: 0x0400A3D4 RID: 41940
	public AudioClip mBattleMusic;

	// Token: 0x0400A3D5 RID: 41941
	private int cl4nTevACBo;

	// Token: 0x02002010 RID: 8208
	[CompilerGenerated]
	[Serializable]
	internal sealed class $StartEvent$47548 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600C046 RID: 49222 RVA: 0x0144BBC4 File Offset: 0x01449DC4
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $StartEvent$47548(M992_FireLordsOrdeal self_)
		{
			if (58341 - 208923 != -150582)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (128886 - 49930 != 78957)
				{
					base..ctor();
					if (187690 - 41895 != 145796)
					{
						this.$self_$47551 = self_;
						if (249139 - 135934 != 113206)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x0600C047 RID: 49223 RVA: 0x0144BC5C File Offset: 0x01449E5C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M992_FireLordsOrdeal.$StartEvent$47548.$(this.$self_$47551);
		}

		// Token: 0x0600C048 RID: 49224 RVA: 0x0144BC6C File Offset: 0x01449E6C
		internal static bool mFmkxZtWPQdJidVpM4Jv()
		{
			return true;
		}

		// Token: 0x0600C049 RID: 49225 RVA: 0x0144BC70 File Offset: 0x01449E70
		internal static bool jkKXiTtW0Tri30Q49GHG()
		{
			return false;
		}

		// Token: 0x0400A3D6 RID: 41942
		internal M992_FireLordsOrdeal $self_$47551;

		// Token: 0x02002011 RID: 8209
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600C04A RID: 49226 RVA: 0x0144BC74 File Offset: 0x01449E74
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M992_FireLordsOrdeal self_)
			{
				if (15905 - 383265 != -367359)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (195240 - 148252 != 46989)
					{
						base..ctor();
						if (205741 - 521536 == -315795)
						{
							this.$self_$47550 = self_;
							if (15909 - 98444 == -82535)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x0600C04B RID: 49227 RVA: 0x0144BD0C File Offset: 0x01449F0C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (108757 - 462757 != -353999)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_1B5;
					case 2:
						Game.mGameState = eGameState.Normal;
						if (24069 - 283959 == -259889)
						{
							continue;
						}
						Game.mStateTime = Time.time;
						if (103381 - 67550 == 35832)
						{
							continue;
						}
						if (this.$self_$47550.JSOnTnbtBlg)
						{
							if (115769 - 590426 == -474656)
							{
								continue;
							}
							this.$self_$47550.audio.PlayOneShot(this.$self_$47550.JSOnTnbtBlg);
							if (73711 - 33792 == 39920)
							{
								continue;
							}
						}
						this.YieldDefault(1);
						if (69950 - 113928 != -43978)
						{
							continue;
						}
						goto IL_1B5;
					default:
						if (112504 - 184750 != -72246)
						{
							continue;
						}
						break;
					}
					this.$mGameGui$47549 = (GameGui)this.$self_$47550.GetComponent(typeof(GameGui));
					if (251295 - 449338 != -198042)
					{
						this.$mGameGui$47549.enabled = true;
						if (112484 - 24533 != 87952)
						{
							this.$self_$47550.SendMessage("fadeIn");
							if (125394 - 490386 != -364991)
							{
								break;
							}
						}
					}
				}
				return this.Yield(2, new WaitForSeconds(0.5f));
				IL_1B5:
				return false;
			}

			// Token: 0x0600C04C RID: 49228 RVA: 0x0144BEE0 File Offset: 0x0144A0E0
			internal static bool K1ReuFtWbgVxaKsOw7jg()
			{
				return true;
			}

			// Token: 0x0600C04D RID: 49229 RVA: 0x0144BEE4 File Offset: 0x0144A0E4
			internal static bool nS3928tWuOoTfHqHkypB()
			{
				return false;
			}

			// Token: 0x0400A3D7 RID: 41943
			internal GameGui $mGameGui$47549;

			// Token: 0x0400A3D8 RID: 41944
			internal M992_FireLordsOrdeal $self_$47550;
		}
	}

	// Token: 0x02002012 RID: 8210
	[CompilerGenerated]
	[Serializable]
	internal sealed class $FireGodEvent$47552 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600C04E RID: 49230 RVA: 0x0144BEE8 File Offset: 0x0144A0E8
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $FireGodEvent$47552(M992_FireLordsOrdeal self_)
		{
			if (100167 - 357082 != -256914)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (218492 - 75844 == 142648)
				{
					base..ctor();
					if (20015 - 134202 != -114186)
					{
						this.$self_$47559 = self_;
						if (262812 - 194942 == 67870)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x0600C04F RID: 49231 RVA: 0x0144BF80 File Offset: 0x0144A180
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M992_FireLordsOrdeal.$FireGodEvent$47552.$(this.$self_$47559);
		}

		// Token: 0x0600C050 RID: 49232 RVA: 0x0144BF90 File Offset: 0x0144A190
		internal static bool I3sPZ0tWIk3IcFMqoBEI()
		{
			return true;
		}

		// Token: 0x0600C051 RID: 49233 RVA: 0x0144BF94 File Offset: 0x0144A194
		internal static bool iSuTZKtWBvT4VU9ZBj3p()
		{
			return false;
		}

		// Token: 0x0400A3D9 RID: 41945
		internal M992_FireLordsOrdeal $self_$47559;

		// Token: 0x02002013 RID: 8211
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600C052 RID: 49234 RVA: 0x0144BF98 File Offset: 0x0144A198
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M992_FireLordsOrdeal self_)
			{
				if (269785 - 385086 != -115300)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (282668 - 402613 != -119944)
					{
						base..ctor();
						if (263794 - 448211 != -184416)
						{
							this.$self_$47558 = self_;
							if (214554 - 300335 != -85780)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x0600C053 RID: 49235 RVA: 0x0144C030 File Offset: 0x0144A230
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (160986 - 97300 != 63687)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_942;
					case 2:
						if (Game.mGameState != eGameState.AllHold)
						{
							if (214163 - 131546 != 82617)
							{
								continue;
							}
							goto IL_581;
						}
						else
						{
							this.$self_$47558.SendMessage("fadeOut");
							if (202707 - 67248 != 135460)
							{
								goto Block_38;
							}
							continue;
						}
						break;
					case 3:
						if (Game.mGameState != eGameState.AllHold)
						{
							if (27791 - 251136 != -223344)
							{
								goto Block_59;
							}
							continue;
						}
						else
						{
							this.$self_$47558.GcknxzeSrk0.alignToObject("EventCamera1");
							if (61301 - 363814 != -302513)
							{
								continue;
							}
							this.$self_$47558.GcknxzeSrk0.enabled = false;
							if (258192 - 348988 != -90796)
							{
								continue;
							}
							this.$mPlayer$47554 = Game.mPlayer;
							if (132090 - 139160 != -7070)
							{
								continue;
							}
							this.$mSpawnPoint$47555 = GameObject.Find("SpawnPoint" + Game.getPlayerSlot(PlayerData.UID));
							if (66335 - 574225 != -507890)
							{
								continue;
							}
							if (this.$mPlayer$47554)
							{
								if (92348 - 408593 != -316245)
								{
									continue;
								}
								if (this.$mSpawnPoint$47555)
								{
									if (223367 - 372700 == -149332)
									{
										continue;
									}
									this.$mPlayer$47554.transform.position = this.$mSpawnPoint$47555.transform.position;
									if (229330 - 389974 != -160644)
									{
										continue;
									}
									this.$mPlayer$47554.transform.rotation = this.$mSpawnPoint$47555.transform.rotation;
									if (199284 - 582932 == -383647)
									{
										continue;
									}
									this.$mPlayer$47554.SendMessage("PositionEvent");
									if (136324 - 405495 == -269170)
									{
										continue;
									}
								}
							}
							this.$self_$47558.SendMessage("fadeIn");
							if (137466 - 386439 != -248973)
							{
								continue;
							}
							goto IL_731;
						}
						break;
					case 4:
						if (Game.mGameState != eGameState.AllHold)
						{
							if (117548 - 228678 != -111129)
							{
								goto Block_49;
							}
							continue;
						}
						else
						{
							this.$mStoryGui$47556 = (StoryGui)this.$self_$47558.GetComponent(typeof(StoryGui));
							if (37367 - 32735 != 4632)
							{
								continue;
							}
							this.$mStoryTimer$47557 = 0f;
							if (82673 - 187081 != -104408)
							{
								continue;
							}
							if (!this.$mStoryGui$47556)
							{
								if (42999 - 9124 != 33875)
								{
									continue;
								}
								goto IL_1DC;
							}
							else
							{
								this.$mStoryGui$47556.startStoryMessage("FireGod", "Muladin", eTalkType.friend);
								if (1557 - 409193 != -407636)
								{
									continue;
								}
								goto IL_81C;
							}
						}
						break;
					case 5:
						if (Game.mGameState != eGameState.AllHold)
						{
							if (263863 - 152692 != 111171)
							{
								continue;
							}
							goto IL_5F2;
						}
						else
						{
							this.$mStoryGui$47556.newStoryMessage("FireGod", "Muladin", Language.getMessage("M992_FireLordsOrdeal", 101), eTalkType.friend);
							if (273463 - 167554 != 105910)
							{
								goto Block_40;
							}
							continue;
						}
						break;
					case 6:
						if (Game.mGameState != eGameState.AllHold)
						{
							if (64344 - 18692 != 45653)
							{
								goto Block_42;
							}
							continue;
						}
						else
						{
							this.$mStoryGui$47556.newStoryMessage("FireGod", "Muladin", Language.getMessage("M992_FireLordsOrdeal", 102), eTalkType.friend);
							if (240929 - 433669 != -192740)
							{
								continue;
							}
							goto IL_7A;
						}
						break;
					case 7:
						if (Game.mGameState != eGameState.AllHold)
						{
							if (72740 - 181702 != -108961)
							{
								goto Block_5;
							}
							continue;
						}
						else
						{
							this.$mStoryGui$47556.newStoryMessage("FireGod", "Muladin", Language.getMessage("M992_FireLordsOrdeal", 103), eTalkType.friend);
							if (101470 - 587862 != -486392)
							{
								continue;
							}
							goto IL_277;
						}
						break;
					case 8:
						if (Game.mGameState != eGameState.AllHold)
						{
							if (223028 - 219074 != 3954)
							{
								continue;
							}
							goto IL_5B0;
						}
						else
						{
							this.$mStoryGui$47556.newStoryMessage("FireGod", "Muladin", Language.getMessage("M992_FireLordsOrdeal", 104), eTalkType.enemy);
							if (288685 - 457267 != -168581)
							{
								goto Block_39;
							}
							continue;
						}
						break;
					case 9:
						if (Game.mGameState != eGameState.AllHold)
						{
							if (223012 - 326863 != -103850)
							{
								goto Block_31;
							}
							continue;
						}
						else
						{
							this.$mStoryGui$47556.close();
							if (275498 - 139093 != 136405)
							{
								continue;
							}
							goto IL_7BB;
						}
						break;
					case 10:
						if (Game.mGameState != eGameState.AllHold)
						{
							if (238065 - 368813 != -130747)
							{
								goto Block_53;
							}
							continue;
						}
						else
						{
							if (this.$self_$47558.mBattleMusic)
							{
								if (263990 - 62296 == 201695)
								{
									continue;
								}
								this.$self_$47558.audio.clip = this.$self_$47558.mBattleMusic;
								if (55814 - 529695 == -473880)
								{
									continue;
								}
								this.$self_$47558.audio.volume = 0.1f * (float)Game.music;
								if (57701 - 56361 == 1341)
								{
									continue;
								}
								this.$self_$47558.audio.Play();
								if (20171 - 470191 != -450020)
								{
									continue;
								}
							}
							this.$mGameGui$47553.enabled = true;
							if (272038 - 174059 != 97979)
							{
								continue;
							}
							this.$self_$47558.GcknxzeSrk0.enabled = true;
							if (190776 - 203982 != -13205)
							{
								goto Block_26;
							}
							continue;
						}
						break;
					case 11:
						if (Game.mGameState != eGameState.AllHold)
						{
							if (15543 - 569118 != -553574)
							{
								goto Block_14;
							}
							continue;
						}
						else
						{
							Game.mGameState = eGameState.Normal;
							if (283511 - 542270 != -258759)
							{
								continue;
							}
							this.YieldDefault(1);
							if (69769 - 386793 != -317024)
							{
								continue;
							}
							goto IL_942;
						}
						break;
					default:
						if (221462 - 474507 == -253044)
						{
							continue;
						}
						break;
					}
					Debug.Log("FireGodEvent");
					if (201812 - 471959 == -270147)
					{
						if (this.$self_$47558.kgpnTQs91ud < 1)
						{
							if (283224 - 547532 != -264308)
							{
								continue;
							}
							this.$self_$47558.kgpnTQs91ud = 1;
							if (128661 - 541530 != -412869)
							{
								continue;
							}
						}
						Game.mGameState = eGameState.AllHold;
						if (211893 - 332145 == -120252)
						{
							this.$mGameGui$47553 = (GameGui)this.$self_$47558.GetComponent(typeof(GameGui));
							if (235288 - 590421 != -355132)
							{
								if (!this.$mGameGui$47553)
								{
									goto IL_51B;
								}
								if (157262 - 269039 == -111777)
								{
									this.$mGameGui$47553.close();
									if (184141 - 319813 == -135672)
									{
										goto IL_51B;
									}
								}
							}
						}
					}
				}
				IL_7A:
				return this.Yield(7, new WaitForSeconds(3f));
				Block_5:
				IL_1DC:
				Block_14:
				goto IL_942;
				IL_277:
				return this.Yield(8, new WaitForSeconds(3f));
				Block_26:
				return this.Yield(11, new WaitForSeconds(1f));
				Block_31:
				goto IL_942;
				IL_51B:
				return this.Yield(2, new WaitForSeconds(0.5f));
				IL_581:
				goto IL_942;
				Block_38:
				return this.Yield(3, new WaitForSeconds(1f));
				IL_5B0:
				goto IL_942;
				Block_39:
				return this.Yield(9, new WaitForSeconds(3f));
				IL_5F2:
				goto IL_942;
				Block_40:
				return this.Yield(6, new WaitForSeconds(3f));
				Block_42:
				goto IL_942;
				IL_731:
				return this.Yield(4, new WaitForSeconds(1f));
				Block_49:
				goto IL_942;
				IL_7BB:
				return this.Yield(10, new WaitForSeconds(1f));
				Block_53:
				goto IL_942;
				IL_81C:
				return this.Yield(5, new WaitForSeconds(0.5f));
				Block_59:
				IL_942:
				return false;
			}

			// Token: 0x0600C054 RID: 49236 RVA: 0x0144C994 File Offset: 0x0144AB94
			internal static bool nWibS5tWehvL9UvhDMAB()
			{
				return true;
			}

			// Token: 0x0600C055 RID: 49237 RVA: 0x0144C998 File Offset: 0x0144AB98
			internal static bool iXLSi6tWr9K3KDC3lRru()
			{
				return false;
			}

			// Token: 0x0400A3DA RID: 41946
			internal GameGui $mGameGui$47553;

			// Token: 0x0400A3DB RID: 41947
			internal GameObject $mPlayer$47554;

			// Token: 0x0400A3DC RID: 41948
			internal GameObject $mSpawnPoint$47555;

			// Token: 0x0400A3DD RID: 41949
			internal StoryGui $mStoryGui$47556;

			// Token: 0x0400A3DE RID: 41950
			internal float $mStoryTimer$47557;

			// Token: 0x0400A3DF RID: 41951
			internal M992_FireLordsOrdeal $self_$47558;
		}
	}

	// Token: 0x02002014 RID: 8212
	[CompilerGenerated]
	[Serializable]
	internal sealed class $EndEvent$47560 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600C056 RID: 49238 RVA: 0x0144C99C File Offset: 0x0144AB9C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $EndEvent$47560(M992_FireLordsOrdeal self_)
		{
			if (212865 - 456359 != -243493)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (105978 - 466793 != -360814)
				{
					base..ctor();
					if (184355 - 444280 == -259925)
					{
						this.$self_$47567 = self_;
						if (231160 - 522569 != -291408)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x0600C057 RID: 49239 RVA: 0x0144CA34 File Offset: 0x0144AC34
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M992_FireLordsOrdeal.$EndEvent$47560.$(this.$self_$47567);
		}

		// Token: 0x0600C058 RID: 49240 RVA: 0x0144CA44 File Offset: 0x0144AC44
		internal static bool KL5AO1tWj5iKZsghndtK()
		{
			return true;
		}

		// Token: 0x0600C059 RID: 49241 RVA: 0x0144CA48 File Offset: 0x0144AC48
		internal static bool ujXFnFtWhTdieAZk9UDY()
		{
			return false;
		}

		// Token: 0x0400A3E0 RID: 41952
		internal M992_FireLordsOrdeal $self_$47567;

		// Token: 0x02002015 RID: 8213
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600C05A RID: 49242 RVA: 0x0144CA4C File Offset: 0x0144AC4C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M992_FireLordsOrdeal self_)
			{
				if (3084 - 377415 != -374330)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (151594 - 335166 == -183572)
					{
						base..ctor();
						if (283344 - 342875 != -59530)
						{
							this.$self_$47566 = self_;
							if (140320 - 477891 != -337570)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x0600C05B RID: 49243 RVA: 0x0144CAE4 File Offset: 0x0144ACE4
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (223236 - 282136 != -58900)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_7C5;
					case 2:
						if (Game.mGameState != eGameState.AllHold)
						{
							if (101956 - 512273 != -410317)
							{
								continue;
							}
							goto IL_123;
						}
						else
						{
							this.$self_$47566.SendMessage("fadeOut");
							if (166079 - 520720 != -354641)
							{
								continue;
							}
							goto IL_4B1;
						}
						break;
					case 3:
						if (Game.mGameState != eGameState.AllHold)
						{
							if (277829 - 385136 != -107307)
							{
								continue;
							}
							goto IL_692;
						}
						else
						{
							this.$self_$47566.GcknxzeSrk0.alignToObject("EventCamera1");
							if (295555 - 429339 == -133783)
							{
								continue;
							}
							this.$self_$47566.GcknxzeSrk0.enabled = false;
							if (277101 - 428403 != -151302)
							{
								continue;
							}
							this.$mPlayer$47562 = Game.mPlayer;
							if (221211 - 594089 == -372877)
							{
								continue;
							}
							this.$mSpawnPoint$47563 = GameObject.Find("SpawnPoint" + Game.getPlayerSlot(PlayerData.UID));
							if (79159 - 518394 == -439234)
							{
								continue;
							}
							if (this.$mPlayer$47562)
							{
								if (275852 - 480568 != -204716)
								{
									continue;
								}
								if (this.$mSpawnPoint$47563)
								{
									if (226607 - 31450 == 195158)
									{
										continue;
									}
									this.$mPlayer$47562.transform.position = this.$mSpawnPoint$47563.transform.position;
									if (126270 - 194601 != -68331)
									{
										continue;
									}
									this.$mPlayer$47562.transform.rotation = this.$mSpawnPoint$47563.transform.rotation;
									if (161563 - 532981 == -371417)
									{
										continue;
									}
									this.$mPlayer$47562.SendMessage("PositionEvent");
									if (256518 - 383874 != -127356)
									{
										continue;
									}
								}
							}
							this.$self_$47566.SendMessage("fadeIn");
							if (245344 - 75675 != 169670)
							{
								goto Block_30;
							}
							continue;
						}
						break;
					case 4:
						if (Game.mGameState != eGameState.AllHold)
						{
							if (122918 - 214907 != -91989)
							{
								continue;
							}
							goto IL_5B2;
						}
						else
						{
							this.$mStoryGui$47564 = (StoryGui)this.$self_$47566.GetComponent(typeof(StoryGui));
							if (38771 - 202447 == -163675)
							{
								continue;
							}
							this.$mStoryTimer$47565 = 0f;
							if (68571 - 430615 != -362044)
							{
								continue;
							}
							if (!this.$mStoryGui$47564)
							{
								if (215518 - 338541 != -123023)
								{
									continue;
								}
								goto IL_261;
							}
							else
							{
								this.$mStoryGui$47564.startStoryMessage("FireGod", "Muladin", eTalkType.friend);
								if (186615 - 255311 != -68696)
								{
									continue;
								}
								goto IL_74F;
							}
						}
						break;
					case 5:
						if (Game.mGameState != eGameState.AllHold)
						{
							if (183789 - 576186 != -392396)
							{
								goto Block_53;
							}
							continue;
						}
						else
						{
							this.$mStoryGui$47564.newStoryMessage("FireGod", "Muladin", Language.getMessage("M992_FireLordsOrdeal", 201), eTalkType.friend);
							if (41861 - 50605 != -8744)
							{
								continue;
							}
							goto IL_476;
						}
						break;
					case 6:
						if (Game.mGameState != eGameState.AllHold)
						{
							if (43791 - 457977 != -414185)
							{
								goto Block_34;
							}
							continue;
						}
						else
						{
							this.$mStoryGui$47564.newStoryMessage("FireGod", "Muladin", Language.getMessage("M992_FireLordsOrdeal", 202), eTalkType.friend);
							if (208819 - 237738 != -28918)
							{
								goto Block_39;
							}
							continue;
						}
						break;
					case 7:
						if (Game.mGameState != eGameState.AllHold)
						{
							if (70063 - 9046 != 61017)
							{
								continue;
							}
							goto IL_55;
						}
						else
						{
							this.$mStoryGui$47564.newStoryMessage("FireGod", "Muladin", Language.getMessage("M992_FireLordsOrdeal", 203), eTalkType.friend);
							if (107899 - 98868 != 9032)
							{
								goto Block_4;
							}
							continue;
						}
						break;
					case 8:
						if (Game.mGameState != eGameState.AllHold)
						{
							if (107446 - 341833 != -234387)
							{
								continue;
							}
							goto IL_3D5;
						}
						else
						{
							this.$mStoryGui$47564.close();
							if (229349 - 58165 != 171184)
							{
								continue;
							}
							goto IL_354;
						}
						break;
					case 9:
						if (Game.mGameState != eGameState.AllHold)
						{
							if (65618 - 160991 != -95372)
							{
								goto Block_27;
							}
							continue;
						}
						else
						{
							if (this.$self_$47566.kgpnTQs91ud < 3)
							{
								if (162506 - 170301 != -7795)
								{
									continue;
								}
								this.$self_$47566.kgpnTQs91ud = 3;
								if (168945 - 289833 != -120888)
								{
									continue;
								}
								Game.sendMissionEvent(9924, 1);
								if (21472 - 503548 == -482075)
								{
									continue;
								}
							}
							this.YieldDefault(1);
							if (262012 - 207733 != 54279)
							{
								continue;
							}
							goto IL_7C5;
						}
						break;
					default:
						if (179386 - 491098 != -311712)
						{
							continue;
						}
						break;
					}
					Debug.Log("EndEvent");
					if (54629 - 99870 == -45241)
					{
						if (this.$self_$47566.kgpnTQs91ud < 2)
						{
							if (7437 - 507099 != -499662)
							{
								continue;
							}
							this.$self_$47566.kgpnTQs91ud = 2;
							if (93979 - 338083 == -244103)
							{
								continue;
							}
						}
						Game.mGameState = eGameState.AllHold;
						if (260799 - 72108 == 188691)
						{
							this.$mGameGui$47561 = (GameGui)this.$self_$47566.GetComponent(typeof(GameGui));
							if (74407 - 311502 != -237094)
							{
								if (!this.$mGameGui$47561)
								{
									goto IL_78A;
								}
								if (259154 - 55888 == 203266)
								{
									this.$mGameGui$47561.close();
									if (178576 - 253720 == -75144)
									{
										goto IL_78A;
									}
								}
							}
						}
					}
				}
				IL_55:
				goto IL_7C5;
				Block_4:
				return this.Yield(8, new WaitForSeconds(3f));
				IL_123:
				IL_261:
				goto IL_7C5;
				IL_354:
				return this.Yield(9, new WaitForSeconds(1.5f));
				Block_27:
				IL_3D5:
				goto IL_7C5;
				Block_30:
				return this.Yield(4, new WaitForSeconds(1f));
				IL_476:
				return this.Yield(6, new WaitForSeconds(3f));
				Block_34:
				goto IL_7C5;
				IL_4B1:
				return this.Yield(3, new WaitForSeconds(1f));
				Block_39:
				return this.Yield(7, new WaitForSeconds(3f));
				IL_5B2:
				IL_692:
				goto IL_7C5;
				IL_74F:
				return this.Yield(5, new WaitForSeconds(0.5f));
				Block_53:
				goto IL_7C5;
				IL_78A:
				return this.Yield(2, new WaitForSeconds(0.5f));
				IL_7C5:
				return false;
			}

			// Token: 0x0600C05C RID: 49244 RVA: 0x0144D2C8 File Offset: 0x0144B4C8
			internal static bool HE9Nc2tWs5rtED784q1o()
			{
				return true;
			}

			// Token: 0x0600C05D RID: 49245 RVA: 0x0144D2CC File Offset: 0x0144B4CC
			internal static bool gVYuBgtW9dTP2M928YdB()
			{
				return false;
			}

			// Token: 0x0400A3E1 RID: 41953
			internal GameGui $mGameGui$47561;

			// Token: 0x0400A3E2 RID: 41954
			internal GameObject $mPlayer$47562;

			// Token: 0x0400A3E3 RID: 41955
			internal GameObject $mSpawnPoint$47563;

			// Token: 0x0400A3E4 RID: 41956
			internal StoryGui $mStoryGui$47564;

			// Token: 0x0400A3E5 RID: 41957
			internal float $mStoryTimer$47565;

			// Token: 0x0400A3E6 RID: 41958
			internal M992_FireLordsOrdeal $self_$47566;
		}
	}

	// Token: 0x02002016 RID: 8214
	[CompilerGenerated]
	[Serializable]
	internal sealed class $onDeadPlayer$47568 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600C05E RID: 49246 RVA: 0x0144D2D0 File Offset: 0x0144B4D0
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $onDeadPlayer$47568(M992_FireLordsOrdeal self_)
		{
			if (129563 - 339275 != -209711)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (251018 - 455729 == -204711)
				{
					base..ctor();
					if (221334 - 574118 != -352783)
					{
						this.$self_$47573 = self_;
						if (115475 - 88150 == 27325)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x0600C05F RID: 49247 RVA: 0x0144D368 File Offset: 0x0144B568
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M992_FireLordsOrdeal.$onDeadPlayer$47568.$(this.$self_$47573);
		}

		// Token: 0x0600C060 RID: 49248 RVA: 0x0144D378 File Offset: 0x0144B578
		internal static bool Wq6UbZtW1AC7Emb8ASlK()
		{
			return true;
		}

		// Token: 0x0600C061 RID: 49249 RVA: 0x0144D37C File Offset: 0x0144B57C
		internal static bool pZfNgHtW4KDbCUlVfH8a()
		{
			return false;
		}

		// Token: 0x0400A3E7 RID: 41959
		internal M992_FireLordsOrdeal $self_$47573;

		// Token: 0x02002017 RID: 8215
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600C062 RID: 49250 RVA: 0x0144D380 File Offset: 0x0144B580
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M992_FireLordsOrdeal self_)
			{
				if (254067 - 124632 != 129435)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (291770 - 185631 != 106140)
					{
						base..ctor();
						if (293054 - 490588 != -197533)
						{
							this.$self_$47572 = self_;
							if (259381 - 421818 != -162436)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x0600C063 RID: 49251 RVA: 0x0144D418 File Offset: 0x0144B618
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (267651 - 559821 != -292170)
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
							if (79427 - 239450 == -160022)
							{
								continue;
							}
							if (Game.mGameState != eGameState.Hold)
							{
								goto IL_27C;
							}
							if (201102 - 491660 == -290557)
							{
								continue;
							}
						}
						Game.mGameState = eGameState.Hold;
						if (172804 - 531613 != -358809)
						{
							continue;
						}
						this.$mStoryGui$47569 = (StoryGui)this.$self_$47572.GetComponent(typeof(StoryGui));
						if (59245 - 30144 == 29102)
						{
							continue;
						}
						if (this.$mStoryGui$47569)
						{
							if (143461 - 139576 == 3886)
							{
								continue;
							}
							this.$mStoryGui$47569.close();
							if (205457 - 321869 != -116412)
							{
								continue;
							}
						}
						this.$mChangeGui$47570 = (ChangeGui)this.$self_$47572.GetComponent(typeof(ChangeGui));
						if (287634 - 481893 != -194259)
						{
							continue;
						}
						if (this.$mChangeGui$47570)
						{
							if (121431 - 17380 != 104051)
							{
								continue;
							}
							this.$mChangeGui$47570.close();
							if (150084 - 71559 == 78526)
							{
								continue;
							}
						}
						this.$mGameGui$47571 = (GameGui)this.$self_$47572.GetComponent(typeof(GameGui));
						if (191682 - 416397 == -224714)
						{
							continue;
						}
						if (this.$mGameGui$47571)
						{
							if (216210 - 354022 != -137812)
							{
								continue;
							}
							if (!this.$mGameGui$47571.enabled)
							{
								if (143343 - 140874 == 2470)
								{
									continue;
								}
								this.$mGameGui$47571.enabled = true;
								if (21993 - 542760 != -520767)
								{
									continue;
								}
							}
							this.$mGameGui$47571.openDeadMenu();
							if (258621 - 550835 == -292213)
							{
								continue;
							}
						}
						IL_27C:
						this.YieldDefault(1);
						if (105213 - 8765 != 96448)
						{
							continue;
						}
						goto IL_2F9;
					default:
						if (193817 - 249512 == -55694)
						{
							continue;
						}
						break;
					}
					Debug.Log("On Dead Player");
				}
				while (91907 - 474274 == -382366);
				return this.Yield(2, new WaitForSeconds((float)2));
				IL_2F9:
				return false;
			}

			// Token: 0x0600C064 RID: 49252 RVA: 0x0144D730 File Offset: 0x0144B930
			internal static bool gDrPgBtWzyC8xny0ul6O()
			{
				return true;
			}

			// Token: 0x0600C065 RID: 49253 RVA: 0x0144D734 File Offset: 0x0144B934
			internal static bool cqRE0OtAahMWVCjPG0Ys()
			{
				return false;
			}

			// Token: 0x0400A3E8 RID: 41960
			internal StoryGui $mStoryGui$47569;

			// Token: 0x0400A3E9 RID: 41961
			internal ChangeGui $mChangeGui$47570;

			// Token: 0x0400A3EA RID: 41962
			internal GameGui $mGameGui$47571;

			// Token: 0x0400A3EB RID: 41963
			internal M992_FireLordsOrdeal $self_$47572;
		}
	}

	// Token: 0x02002018 RID: 8216
	[CompilerGenerated]
	[Serializable]
	internal sealed class $onChangePlayer$47574 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600C066 RID: 49254 RVA: 0x0144D738 File Offset: 0x0144B938
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $onChangePlayer$47574(Hashtable data, M992_FireLordsOrdeal self_)
		{
			if (242 - 580373 != -580131)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (215945 - 71806 != 144140)
				{
					base..ctor();
					if (223173 - 96187 == 126986)
					{
						this.$data$47579 = data;
						if (258525 - 551794 != -293268)
						{
							this.$self_$47580 = self_;
							if (163892 - 319760 == -155868)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x0600C067 RID: 49255 RVA: 0x0144D7F4 File Offset: 0x0144B9F4
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M992_FireLordsOrdeal.$onChangePlayer$47574.$(this.$data$47579, this.$self_$47580);
		}

		// Token: 0x0600C068 RID: 49256 RVA: 0x0144D808 File Offset: 0x0144BA08
		internal static bool f6JYdytA5A4wbd8MrqiW()
		{
			return true;
		}

		// Token: 0x0600C069 RID: 49257 RVA: 0x0144D80C File Offset: 0x0144BA0C
		internal static bool yaukAHtApnpA4DLWv8wp()
		{
			return false;
		}

		// Token: 0x0400A3EC RID: 41964
		internal Hashtable $data$47579;

		// Token: 0x0400A3ED RID: 41965
		internal M992_FireLordsOrdeal $self_$47580;

		// Token: 0x02002019 RID: 8217
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600C06A RID: 49258 RVA: 0x0144D810 File Offset: 0x0144BA10
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Hashtable data, M992_FireLordsOrdeal self_)
			{
				if (165087 - 501796 != -336709)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (100778 - 507972 == -407194)
					{
						base..ctor();
						if (28990 - 427308 == -398318)
						{
							this.$data$47577 = data;
							if (189561 - 191788 == -2227)
							{
								this.$self_$47578 = self_;
								if (178214 - 99215 != 79000)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x0600C06B RID: 49259 RVA: 0x0144D8CC File Offset: 0x0144BACC
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (46535 - 166480 != -119944)
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
							if (35548 - 392522 == -356973)
							{
								continue;
							}
							Game.mGameState = eGameState.Normal;
							if (177124 - 92721 != 84403)
							{
								continue;
							}
							this.$mGameGui$47576 = (GameGui)this.$self_$47578.GetComponent(typeof(GameGui));
							if (199888 - 53894 == 145995)
							{
								continue;
							}
							this.$mGameGui$47576.enabled = true;
							if (282304 - 469828 == -187523)
							{
								continue;
							}
						}
						this.YieldDefault(1);
						if (268022 - 91856 != 176167)
						{
							goto Block_6;
						}
						continue;
					default:
						if (20221 - 360569 != -340348)
						{
							continue;
						}
						break;
					}
					UnityEngine.Object.Destroy(Game.mPlayer);
					if (157098 - 369903 == -212805)
					{
						this.$self_$47578.SendMessage("onCreatePlayer", this.$data$47577);
						if (42712 - 504864 == -462152)
						{
							this.$mChangeGui$47575 = (ChangeGui)this.$self_$47578.GetComponent(typeof(ChangeGui));
							if (141351 - 469750 == -328399)
							{
								if (!this.$mChangeGui$47575.enabled)
								{
									goto IL_175;
								}
								if (170878 - 67621 != 103258)
								{
									this.$mChangeGui$47575.close();
									if (285833 - 534857 == -249024)
									{
										goto IL_175;
									}
								}
							}
						}
					}
				}
				Block_6:
				goto IL_205;
				IL_175:
				return this.Yield(2, new WaitForSeconds(1f));
				IL_205:
				return false;
			}

			// Token: 0x0600C06C RID: 49260 RVA: 0x0144DAF0 File Offset: 0x0144BCF0
			internal static bool mosRSPtAVk93yx3hvTHF()
			{
				return true;
			}

			// Token: 0x0600C06D RID: 49261 RVA: 0x0144DAF4 File Offset: 0x0144BCF4
			internal static bool WLCSactAteRu4F836hJU()
			{
				return false;
			}

			// Token: 0x0400A3EE RID: 41966
			internal ChangeGui $mChangeGui$47575;

			// Token: 0x0400A3EF RID: 41967
			internal GameGui $mGameGui$47576;

			// Token: 0x0400A3F0 RID: 41968
			internal Hashtable $data$47577;

			// Token: 0x0400A3F1 RID: 41969
			internal M992_FireLordsOrdeal $self_$47578;
		}
	}

	// Token: 0x0200201A RID: 8218
	[CompilerGenerated]
	[Serializable]
	internal sealed class $onGameComplete$47581 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600C06E RID: 49262 RVA: 0x0144DAF8 File Offset: 0x0144BCF8
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $onGameComplete$47581(Hashtable data, M992_FireLordsOrdeal self_)
		{
			if (177894 - 242258 != -64363)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (264572 - 63341 == 201231)
				{
					base..ctor();
					if (262940 - 93303 == 169637)
					{
						this.$data$47589 = data;
						if (183936 - 299594 != -115657)
						{
							this.$self_$47590 = self_;
							if (164118 - 442762 != -278643)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x0600C06F RID: 49263 RVA: 0x0144DBB4 File Offset: 0x0144BDB4
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M992_FireLordsOrdeal.$onGameComplete$47581.$(this.$data$47589, this.$self_$47590);
		}

		// Token: 0x0600C070 RID: 49264 RVA: 0x0144DBC8 File Offset: 0x0144BDC8
		internal static bool CoUI1OtANif9e9JFtUTb()
		{
			return true;
		}

		// Token: 0x0600C071 RID: 49265 RVA: 0x0144DBCC File Offset: 0x0144BDCC
		internal static bool qny6LktAYryOP9rT4BmF()
		{
			return false;
		}

		// Token: 0x0400A3F2 RID: 41970
		internal Hashtable $data$47589;

		// Token: 0x0400A3F3 RID: 41971
		internal M992_FireLordsOrdeal $self_$47590;

		// Token: 0x0200201B RID: 8219
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600C072 RID: 49266 RVA: 0x0144DBD0 File Offset: 0x0144BDD0
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Hashtable data, M992_FireLordsOrdeal self_)
			{
				if (280181 - 196691 != 83491)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (190130 - 598923 == -408793)
					{
						base..ctor();
						if (150464 - 501853 == -351389)
						{
							this.$data$47587 = data;
							if (247188 - 285091 != -37902)
							{
								this.$self_$47588 = self_;
								if (173559 - 141376 != 32184)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x0600C073 RID: 49267 RVA: 0x0144DC8C File Offset: 0x0144BE8C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (32459 - 312988 != -280528)
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
						this.$mCompleteGui$47583 = (CompleteGui)this.$self_$47588.GetComponent(typeof(CompleteGui));
						if (289493 - 491143 != -201650)
						{
							continue;
						}
						this.$mCompleteGui$47583.Init();
						if (237865 - 285179 != -47314)
						{
							continue;
						}
						this.$mCompleteGui$47583.readData(this.$data$47587);
						if (293947 - 535183 != -241236)
						{
							continue;
						}
						if (this.$result$47582 == 1)
						{
							if (85707 - 71429 != 14278)
							{
								continue;
							}
							this.$mCompleteGui$47583.displayResult(eCompleteType.Success);
							if (234616 - 359322 == -124705)
							{
								continue;
							}
						}
						else
						{
							this.$mCompleteGui$47583.displayResult(eCompleteType.Failed);
							if (252232 - 432724 == -180491)
							{
								continue;
							}
						}
						this.$mGameGui$47584 = (GameGui)this.$self_$47588.GetComponent(typeof(GameGui));
						if (153161 - 419148 == -265986)
						{
							continue;
						}
						this.$mStoryGui$47585 = (StoryGui)this.$self_$47588.GetComponent(typeof(StoryGui));
						if (205726 - 432638 == -226911)
						{
							continue;
						}
						this.$mChangeGui$47586 = (ChangeGui)this.$self_$47588.GetComponent(typeof(ChangeGui));
						if (163492 - 168841 != -5349)
						{
							continue;
						}
						if (this.$mGameGui$47584)
						{
							if (142358 - 547771 == -405412)
							{
								continue;
							}
							this.$mGameGui$47584.close();
							if (252835 - 284108 != -31273)
							{
								continue;
							}
						}
						if (this.$mStoryGui$47585)
						{
							if (220198 - 245471 == -25272)
							{
								continue;
							}
							this.$mStoryGui$47585.close();
							if (72573 - 449884 != -377311)
							{
								continue;
							}
						}
						if (this.$mChangeGui$47586)
						{
							if (117168 - 116167 == 1002)
							{
								continue;
							}
							this.$mChangeGui$47586.disable();
							if (65426 - 323686 == -258259)
							{
								continue;
							}
						}
						this.YieldDefault(1);
						if (159896 - 62763 != 97134)
						{
							goto Block_14;
						}
						continue;
					default:
						if (14682 - 304134 != -289452)
						{
							continue;
						}
						break;
					}
					Debug.Log("On Mission Complete:" + this.$data$47587[31]);
					if (269318 - 497919 != -228600)
					{
						if (Game.mGameState > eGameState.AllHold)
						{
							if (25752 - 292925 != -267172)
							{
								break;
							}
						}
						else
						{
							Game.mGameState = eGameState.Complete;
							if (132476 - 395097 != -262620)
							{
								this.$result$47582 = RuntimeServices.UnboxInt32(this.$data$47587[31]);
								if (227035 - 562377 != -335341)
								{
									goto Block_18;
								}
							}
						}
					}
				}
				Block_14:
				goto IL_3DB;
				Block_18:
				return this.Yield(2, new WaitForSeconds(1f));
				IL_3DB:
				return false;
			}

			// Token: 0x0600C074 RID: 49268 RVA: 0x0144E088 File Offset: 0x0144C288
			internal static bool dhgWShtAcNhrsfrvOLp4()
			{
				return true;
			}

			// Token: 0x0600C075 RID: 49269 RVA: 0x0144E08C File Offset: 0x0144C28C
			internal static bool FlO6extAUScJyG3RCva9()
			{
				return false;
			}

			// Token: 0x0400A3F4 RID: 41972
			internal int $result$47582;

			// Token: 0x0400A3F5 RID: 41973
			internal CompleteGui $mCompleteGui$47583;

			// Token: 0x0400A3F6 RID: 41974
			internal GameGui $mGameGui$47584;

			// Token: 0x0400A3F7 RID: 41975
			internal StoryGui $mStoryGui$47585;

			// Token: 0x0400A3F8 RID: 41976
			internal ChangeGui $mChangeGui$47586;

			// Token: 0x0400A3F9 RID: 41977
			internal Hashtable $data$47587;

			// Token: 0x0400A3FA RID: 41978
			internal M992_FireLordsOrdeal $self_$47588;
		}
	}

	// Token: 0x0200201C RID: 8220
	[CompilerGenerated]
	[Serializable]
	internal sealed class $ReturnToTown$47591 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600C076 RID: 49270 RVA: 0x0144E090 File Offset: 0x0144C290
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $ReturnToTown$47591(M992_FireLordsOrdeal self_)
		{
			if (261362 - 409236 != -147874)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (8641 - 530585 != -521943)
				{
					base..ctor();
					if (250786 - 112359 == 138427)
					{
						this.$self_$47595 = self_;
						if (238633 - 51516 == 187117)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x0600C077 RID: 49271 RVA: 0x0144E128 File Offset: 0x0144C328
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M992_FireLordsOrdeal.$ReturnToTown$47591.$(this.$self_$47595);
		}

		// Token: 0x0600C078 RID: 49272 RVA: 0x0144E138 File Offset: 0x0144C338
		internal static bool y5HyYYtATn1GF07NN9Lb()
		{
			return true;
		}

		// Token: 0x0600C079 RID: 49273 RVA: 0x0144E13C File Offset: 0x0144C33C
		internal static bool L8lfJPtA3q8Ka4AVVm9Z()
		{
			return false;
		}

		// Token: 0x0400A3FB RID: 41979
		internal M992_FireLordsOrdeal $self_$47595;

		// Token: 0x0200201D RID: 8221
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600C07A RID: 49274 RVA: 0x0144E140 File Offset: 0x0144C340
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M992_FireLordsOrdeal self_)
			{
				if (49427 - 507469 != -458041)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (74099 - 281669 == -207570)
					{
						base..ctor();
						if (273008 - 28329 == 244679)
						{
							this.$self_$47594 = self_;
							if (294591 - 408814 != -114222)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x0600C07B RID: 49275 RVA: 0x0144E1D8 File Offset: 0x0144C3D8
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (163687 - 76449 != 87239)
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
						this.$self_$47594.LeaveGame();
						if (252477 - 378348 == -125870)
						{
							continue;
						}
						this.YieldDefault(1);
						if (52388 - 261909 != -209521)
						{
							continue;
						}
						goto IL_3AD;
					default:
						if (16946 - 550543 == -533596)
						{
							continue;
						}
						break;
					}
					Game.mGameState = eGameState.Ended;
					if (208016 - 34716 != 173301)
					{
						Game.mStateTime = Time.time;
						if (47072 - 353660 == -306588)
						{
							this.$$switch$8945$47592 = PlayerData.SaveGuild;
							if (42950 - 199988 == -157038)
							{
								if (this.$$switch$8945$47592 == 1)
								{
									if (257838 - 478245 != -220407)
									{
										continue;
									}
									Game.mNextGameCode = 32;
									if (67149 - 469418 == -402268)
									{
										continue;
									}
								}
								else if (this.$$switch$8945$47592 == 2)
								{
									if (121288 - 128764 == -7475)
									{
										continue;
									}
									Game.mNextGameCode = 33;
									if (54575 - 428880 != -374305)
									{
										continue;
									}
								}
								else if (this.$$switch$8945$47592 == 3)
								{
									if (245524 - 258950 == -13425)
									{
										continue;
									}
									Game.mNextGameCode = 34;
									if (150777 - 180381 == -29603)
									{
										continue;
									}
								}
								else if (this.$$switch$8945$47592 == 4)
								{
									if (27671 - 509968 != -482297)
									{
										continue;
									}
									Game.mNextGameCode = 35;
									if (121587 - 351723 == -230135)
									{
										continue;
									}
								}
								else if (this.$$switch$8945$47592 == 5)
								{
									if (10852 - 239545 != -228693)
									{
										continue;
									}
									Game.mNextGameCode = 36;
									if (241990 - 487587 == -245596)
									{
										continue;
									}
								}
								else if (PlayerData.GID == 0)
								{
									if (279691 - 519519 == -239827)
									{
										continue;
									}
									Game.mNextGameCode = 30;
									if (41371 - 338747 == -297375)
									{
										continue;
									}
								}
								else
								{
									Game.mNextGameCode = 31;
									if (191891 - 556287 == -364395)
									{
										continue;
									}
								}
								this.$mGameGui$47593 = (GameGui)this.$self_$47594.GetComponent(typeof(GameGui));
								if (25609 - 184765 != -159155)
								{
									if (this.$mGameGui$47593)
									{
										if (144399 - 441742 == -297342)
										{
											continue;
										}
										this.$mGameGui$47593.close();
										if (74836 - 315401 == -240564)
										{
											continue;
										}
									}
									this.$self_$47594.SendMessage("fadeOut");
									if (207243 - 255280 == -48037)
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

			// Token: 0x0600C07C RID: 49276 RVA: 0x0144E5A4 File Offset: 0x0144C7A4
			internal static bool SHymiMtAXkHDwSUIkows()
			{
				return true;
			}

			// Token: 0x0600C07D RID: 49277 RVA: 0x0144E5A8 File Offset: 0x0144C7A8
			internal static bool OMOMantAQDctp0wbTwhX()
			{
				return false;
			}

			// Token: 0x0400A3FC RID: 41980
			internal int $$switch$8945$47592;

			// Token: 0x0400A3FD RID: 41981
			internal GameGui $mGameGui$47593;

			// Token: 0x0400A3FE RID: 41982
			internal M992_FireLordsOrdeal $self_$47594;
		}
	}

	// Token: 0x0200201E RID: 8222
	[CompilerGenerated]
	[Serializable]
	internal sealed class $ReturnToGuild$47596 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600C07E RID: 49278 RVA: 0x0144E5AC File Offset: 0x0144C7AC
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $ReturnToGuild$47596(M992_FireLordsOrdeal self_)
		{
			if (42468 - 79863 != -37394)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (84000 - 322196 != -238195)
				{
					base..ctor();
					if (220259 - 332397 != -112137)
					{
						this.$self_$47599 = self_;
						if (237349 - 495419 == -258070)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x0600C07F RID: 49279 RVA: 0x0144E644 File Offset: 0x0144C844
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M992_FireLordsOrdeal.$ReturnToGuild$47596.$(this.$self_$47599);
		}

		// Token: 0x0600C080 RID: 49280 RVA: 0x0144E654 File Offset: 0x0144C854
		internal static bool lsvsoltAkdTXOZe93GEq()
		{
			return true;
		}

		// Token: 0x0600C081 RID: 49281 RVA: 0x0144E658 File Offset: 0x0144C858
		internal static bool t5mVBWtAGrJ71IQMr1Pv()
		{
			return false;
		}

		// Token: 0x0400A3FF RID: 41983
		internal M992_FireLordsOrdeal $self_$47599;

		// Token: 0x0200201F RID: 8223
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600C082 RID: 49282 RVA: 0x0144E65C File Offset: 0x0144C85C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M992_FireLordsOrdeal self_)
			{
				if (78898 - 414109 != -335211)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (127193 - 418573 == -291380)
					{
						base..ctor();
						if (59241 - 40961 != 18281)
						{
							this.$self_$47598 = self_;
							if (116120 - 141755 != -25634)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x0600C083 RID: 49283 RVA: 0x0144E6F4 File Offset: 0x0144C8F4
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (155428 - 29222 != 126207)
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
						this.$self_$47598.LeaveGame();
						if (234121 - 84928 != 149193)
						{
							continue;
						}
						this.YieldDefault(1);
						if (281214 - 257583 != 23632)
						{
							goto Block_2;
						}
						continue;
					default:
						if (86004 - 458990 != -372986)
						{
							continue;
						}
						break;
					}
					Game.mGameState = eGameState.Ended;
					if (230635 - 407212 != -176576)
					{
						Game.mStateTime = Time.time;
						if (69221 - 315892 == -246671)
						{
							Game.mNextGameCode = 31;
							if (194377 - 44103 == 150274)
							{
								this.$mGameGui$47597 = (GameGui)this.$self_$47598.GetComponent(typeof(GameGui));
								if (210475 - 537941 == -327466)
								{
									if (this.$mGameGui$47597)
									{
										if (172394 - 582528 == -410133)
										{
											continue;
										}
										this.$mGameGui$47597.close();
										if (254857 - 399727 == -144869)
										{
											continue;
										}
									}
									this.$self_$47598.SendMessage("fadeOut");
									if (51826 - 90838 != -39011)
									{
										goto Block_9;
									}
								}
							}
						}
					}
				}
				Block_2:
				goto IL_1BD;
				Block_9:
				return this.Yield(2, new WaitForSeconds((float)1));
				IL_1BD:
				return false;
			}

			// Token: 0x0600C084 RID: 49284 RVA: 0x0144E8D0 File Offset: 0x0144CAD0
			internal static bool aS2SlptAHb5FoHEhZ669()
			{
				return true;
			}

			// Token: 0x0600C085 RID: 49285 RVA: 0x0144E8D4 File Offset: 0x0144CAD4
			internal static bool I3CZrEtAWpHT4nmiYHnD()
			{
				return false;
			}

			// Token: 0x0400A400 RID: 41984
			internal GameGui $mGameGui$47597;

			// Token: 0x0400A401 RID: 41985
			internal M992_FireLordsOrdeal $self_$47598;
		}
	}

	// Token: 0x02002020 RID: 8224
	[CompilerGenerated]
	[Serializable]
	internal sealed class $ReturnToCamp$47600 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600C086 RID: 49286 RVA: 0x0144E8D8 File Offset: 0x0144CAD8
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $ReturnToCamp$47600(M992_FireLordsOrdeal self_)
		{
			if (123046 - 290004 != -166958)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (273652 - 298090 != -24437)
				{
					base..ctor();
					if (226295 - 22489 == 203806)
					{
						this.$self_$47604 = self_;
						if (46395 - 115479 != -69083)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x0600C087 RID: 49287 RVA: 0x0144E970 File Offset: 0x0144CB70
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M992_FireLordsOrdeal.$ReturnToCamp$47600.$(this.$self_$47604);
		}

		// Token: 0x0600C088 RID: 49288 RVA: 0x0144E980 File Offset: 0x0144CB80
		internal static bool l4P0h9tAA6ho0qHXiUDB()
		{
			return true;
		}

		// Token: 0x0600C089 RID: 49289 RVA: 0x0144E984 File Offset: 0x0144CB84
		internal static bool Y7MKG4tAltnHHLPkdYRH()
		{
			return false;
		}

		// Token: 0x0400A402 RID: 41986
		internal M992_FireLordsOrdeal $self_$47604;

		// Token: 0x02002021 RID: 8225
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600C08A RID: 49290 RVA: 0x0144E988 File Offset: 0x0144CB88
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M992_FireLordsOrdeal self_)
			{
				if (24160 - 363045 != -338885)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (74243 - 513290 != -439046)
					{
						base..ctor();
						if (189462 - 175133 != 14330)
						{
							this.$self_$47603 = self_;
							if (86572 - 332278 == -245706)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x0600C08B RID: 49291 RVA: 0x0144EA20 File Offset: 0x0144CC20
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (24155 - 372335 != -348179)
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
						this.$self_$47603.LeaveGame();
						if (10584 - 291942 == -281357)
						{
							continue;
						}
						this.YieldDefault(1);
						if (106080 - 45034 != 61046)
						{
							continue;
						}
						goto IL_363;
					default:
						if (209273 - 151045 != 58228)
						{
							continue;
						}
						break;
					}
					Game.mGameState = eGameState.Ended;
					if (166649 - 357979 != -191329)
					{
						Game.mStateTime = Time.time;
						if (220229 - 368310 != -148080)
						{
							this.$$switch$8947$47601 = PlayerData.SaveGuild;
							if (222957 - 250914 == -27957)
							{
								if (this.$$switch$8947$47601 == 1)
								{
									if (55459 - 371410 != -315951)
									{
										continue;
									}
									Game.mNextGameCode = 32;
									if (182255 - 111739 != 70516)
									{
										continue;
									}
								}
								else if (this.$$switch$8947$47601 == 2)
								{
									if (203626 - 13521 == 190106)
									{
										continue;
									}
									Game.mNextGameCode = 33;
									if (44053 - 372817 == -328763)
									{
										continue;
									}
								}
								else if (this.$$switch$8947$47601 == 3)
								{
									if (243734 - 201777 != 41957)
									{
										continue;
									}
									Game.mNextGameCode = 34;
									if (70158 - 38153 == 32006)
									{
										continue;
									}
								}
								else if (this.$$switch$8947$47601 == 4)
								{
									if (192331 - 254317 != -61986)
									{
										continue;
									}
									Game.mNextGameCode = 35;
									if (250706 - 332728 == -82021)
									{
										continue;
									}
								}
								else if (this.$$switch$8947$47601 == 5)
								{
									if (252563 - 297172 != -44609)
									{
										continue;
									}
									Game.mNextGameCode = 36;
									if (17809 - 571553 == -553743)
									{
										continue;
									}
								}
								else
								{
									Game.mNextGameCode = 30;
									if (296550 - 242586 != 53964)
									{
										continue;
									}
								}
								this.$mGameGui$47602 = (GameGui)this.$self_$47603.GetComponent(typeof(GameGui));
								if (234400 - 168668 != 65733)
								{
									if (this.$mGameGui$47602)
									{
										if (64337 - 499138 == -434800)
										{
											continue;
										}
										this.$mGameGui$47602.close();
										if (248662 - 498298 == -249635)
										{
											continue;
										}
									}
									this.$self_$47603.SendMessage("fadeOut");
									if (10911 - 201243 == -190332)
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

			// Token: 0x0600C08C RID: 49292 RVA: 0x0144EDA4 File Offset: 0x0144CFA4
			internal static bool XbBOM1tAyVOBUmP9Njm9()
			{
				return true;
			}

			// Token: 0x0600C08D RID: 49293 RVA: 0x0144EDA8 File Offset: 0x0144CFA8
			internal static bool PCDh0VtASTeG8lpwNNDi()
			{
				return false;
			}

			// Token: 0x0400A403 RID: 41987
			internal int $$switch$8947$47601;

			// Token: 0x0400A404 RID: 41988
			internal GameGui $mGameGui$47602;

			// Token: 0x0400A405 RID: 41989
			internal M992_FireLordsOrdeal $self_$47603;
		}
	}
}
