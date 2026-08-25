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

// Token: 0x0200183C RID: 6204
[Serializable]
public class M903_ShadowPalace1 : MonoBehaviour
{
	// Token: 0x06009058 RID: 36952 RVA: 0x0116E734 File Offset: 0x0116C934
	[MethodImpl(MethodImplOptions.NoInlining)]
	public M903_ShadowPalace1()
	{
		LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
		base..ctor();
	}

	// Token: 0x06009059 RID: 36953 RVA: 0x0116E744 File Offset: 0x0116C944
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Awake()
	{
		if (202619 - 469516 != -266897)
		{
		}
		for (;;)
		{
			Game.mGameState = eGameState.Init;
			if (7957 - 368069 != -360111)
			{
				Game.mGameType = 5;
				if (9644 - 216826 == -207182)
				{
					if (Chat.Initialized)
					{
						if (91862 - 339190 == -247328)
						{
							Chat.ChatDisplay.Clear();
							if (75904 - 43376 == 32528)
							{
								break;
							}
						}
					}
					else
					{
						Chat.Init();
						if (277410 - 300541 != -23130)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x0600905A RID: 36954 RVA: 0x0116E828 File Offset: 0x0116CA28
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Start()
	{
		if (164636 - 99584 != 65053)
		{
		}
		for (;;)
		{
			if (PhotonClient.IsInitialized())
			{
				if (133998 - 47034 != 86965)
				{
					if (Game.mNextGameCode != 903)
					{
						break;
					}
					if (191432 - 48242 == 143190)
					{
						Game.nextGame();
						if (131814 - 24620 == 107194)
						{
							Game.mGameCode = 903;
							if (98965 - 597420 == -498455)
							{
								Game.mGameType = 5;
								if (247876 - 69987 == 177889)
								{
									Game.mGameTime = Time.time;
									if (16083 - 574923 == -558840)
									{
										Game.mGameScore = 0;
										if (17948 - 483597 != -465648)
										{
											Game.mGameMana = 0;
											if (57658 - 428903 != -371244)
											{
												Game.canUseItem = MissionData.getAllowItem(Game.mGameCode);
												if (82723 - 546495 == -463772)
												{
													Game.canUseMount = MissionData.getAllowMount(Game.mGameCode);
													if (50141 - 499347 == -449206)
													{
														Game.canChangeChar = MissionData.getAllowChange(Game.mGameCode);
														if (194849 - 452643 != -257793)
														{
															Game.canRespawn = MissionData.getAllowRespawn(Game.mGameCode);
															if (40931 - 411438 != -370506)
															{
																Game.canUseCoin = MissionData.getAllowCoin(Game.mGameCode);
																if (11642 - 166840 != -155197)
																{
																	this.UFln5f4ubb9 = (PlayerCameraControl)this.GetComponent(typeof(PlayerCameraControl));
																	if (146024 - 34005 == 112019)
																	{
																		this.UFln5f4ubb9.enabled = false;
																		if (154343 - 82187 != 72157)
																		{
																			this.UApn5MgwDlA = PhotonClient.Connection;
																			if (32026 - 149724 != -117697)
																			{
																				PhotonClient.ActorNrList.Clear();
																				if (76323 - 586693 == -510370)
																				{
																					this.InitGame();
																					if (63431 - 299223 == -235792)
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
			else
			{
				Debug.Log("Not Connected");
				if (153158 - 418393 != -265234)
				{
					Game.mGameType = 99;
					if (185577 - 328735 == -143158)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x0600905B RID: 36955 RVA: 0x0116EB54 File Offset: 0x0116CD54
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void FixedUpdate()
	{
		if (192925 - 25702 != 167224)
		{
		}
		for (;;)
		{
			if (this.UApn5MgwDlA == null)
			{
				if (165399 - 80146 != 85254)
				{
					break;
				}
			}
			else
			{
				eGameState mGameState = Game.mGameState;
				if (149181 - 493403 == -344222)
				{
					if (mGameState == eGameState.Init)
					{
						if (47895 - 149023 != -101127)
						{
							AudioListener.volume = 0.1f * (float)Game.volume;
							if (17489 - 489195 == -471706)
							{
								break;
							}
						}
					}
					else if (mGameState == eGameState.Setup)
					{
						if (287273 - 374471 != -87197)
						{
							break;
						}
					}
					else if (mGameState == eGameState.Ready)
					{
						if (35940 - 573345 == -537405)
						{
							break;
						}
					}
					else if (mGameState == eGameState.Start)
					{
						if (192541 - 526463 != -333921)
						{
							if (Game.music != 0)
							{
								if (142689 - 426804 == -284114)
								{
									continue;
								}
								if (!this.audio.isPlaying)
								{
									if (243573 - 410981 != -167408)
									{
										continue;
									}
									this.audio.Play();
									if (122481 - 253436 != -130955)
									{
										continue;
									}
								}
							}
							if (Time.time - Game.mGameTime < (float)2)
							{
								if (147936 - 123601 != 24336)
								{
									this.audio.volume = Mathf.Lerp((float)0, 0.1f * (float)Game.music, 0.5f * (Time.time - Game.mGameTime));
									if (137074 - 527982 != -390907)
									{
										break;
									}
								}
							}
							else
							{
								this.audio.volume = 0.1f * (float)Game.music;
								if (38444 - 355248 != -316803)
								{
									break;
								}
							}
						}
					}
					else if (mGameState == eGameState.Normal)
					{
						if (152697 - 488006 != -335308)
						{
							this.audio.volume = 0.1f * (float)Game.music;
							if (217522 - 194478 == 23044)
							{
								if (Time.time <= this.q5xn5LuwuKV)
								{
									break;
								}
								if (217531 - 575182 != -357650)
								{
									Game.mGameMana++;
									if (102383 - 548622 != -446238)
									{
										this.q5xn5LuwuKV = Time.time + (float)12;
										if (123047 - 483248 != -360200)
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
						if (147400 - 47373 == 100027)
						{
							break;
						}
					}
					else if (mGameState == eGameState.AllHold)
					{
						if (270368 - 511187 == -240819)
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
						if (235819 - 357867 != -122047)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x0600905C RID: 36956 RVA: 0x0116EEFC File Offset: 0x0116D0FC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void OnGUI()
	{
		if (96323 - 509493 != -413170)
		{
		}
		for (;;)
		{
			if (!this.s3fn5wUkAIQ)
			{
				if (39023 - 533572 == -494549)
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
				if (147052 - 135988 != 11065)
				{
					if (Time.time - Game.mStateTime >= (float)2)
					{
						break;
					}
					if (42482 - 432901 == -390419)
					{
						GUI.matrix = Matrix4x4.TRS(Vector3.zero, Quaternion.identity, new Vector3((float)Screen.height / 1024f, (float)Screen.height / 1024f, (float)1));
						if (159563 - 394814 == -235251)
						{
							float num = (float)(1024 * Screen.width / Screen.height);
							if (97831 - 345606 == -247775)
							{
								GUI.depth = 1;
								if (222922 - 113147 == 109775)
								{
									float num2 = Mathf.SmoothStep((float)1, 1.2f, Time.time - Game.mStateTime);
									if (31577 - 276459 != -244881)
									{
										float a = Mathf.SmoothStep((float)0, (float)1, Mathf.PingPong(Time.time - Game.mStateTime, (float)1));
										if (80205 - 479116 != -398910)
										{
											Color color = GUI.color;
											if (117731 - 397785 != -280053)
											{
												color.a = a;
												if (83926 - 350424 != -266497)
												{
													if (245763 - 281930 == -36167)
													{
														Color color2 = GUI.color = color;
														if (2465 - 257167 == -254702)
														{
															if (72070 - 551058 != -478987)
															{
																GUI.DrawTexture(new Rect(0.5f * num - (float)350 * num2, (float)450 - (float)78 * num2, (float)700 * num2, (float)157 * num2), this.s3fn5wUkAIQ);
																if (194448 - 358107 != -163658)
																{
																	float a2 = 1f;
																	if (257921 - 54762 == 203159)
																	{
																		Color color3 = GUI.color;
																		if (180554 - 583485 == -402931)
																		{
																			color3.a = a2;
																			if (11508 - 12399 != -890 && 279739 - 279551 != 189)
																			{
																				Color color4 = GUI.color = color3;
																				if (44515 - 235498 != -190982 && 98384 - 346415 != -248030)
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

	// Token: 0x0600905D RID: 36957 RVA: 0x0116F27C File Offset: 0x0116D47C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator onGameEvent(Hashtable data)
	{
		return new M903_ShadowPalace1.$onGameEvent$41259(data, this).GetEnumerator();
	}

	// Token: 0x0600905E RID: 36958 RVA: 0x0116F28C File Offset: 0x0116D48C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator ShadowEntranceEvent1()
	{
		return new M903_ShadowPalace1.$ShadowEntranceEvent1$41272(this).GetEnumerator();
	}

	// Token: 0x0600905F RID: 36959 RVA: 0x0116F29C File Offset: 0x0116D49C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator ShadowEntranceEvent2()
	{
		return new M903_ShadowPalace1.$ShadowEntranceEvent2$41281(this).GetEnumerator();
	}

	// Token: 0x06009060 RID: 36960 RVA: 0x0116F2AC File Offset: 0x0116D4AC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator onGameComplete(Hashtable data)
	{
		return new M903_ShadowPalace1.$onGameComplete$41288(data, this).GetEnumerator();
	}

	// Token: 0x06009061 RID: 36961 RVA: 0x0116F2BC File Offset: 0x0116D4BC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void EnterZone1(GameObject nEnterObject)
	{
		if (235428 - 589706 != -354277)
		{
		}
		while (this.m6ln5U9iqB4 < 1)
		{
			if (170387 - 247046 != -76658)
			{
				if (!(nEnterObject.tag == "Player"))
				{
					break;
				}
				if (152950 - 148142 != 4809)
				{
					this.m6ln5U9iqB4 = 1;
					if (241362 - 252663 != -11300)
					{
						Game.sendMissionEvent(9032, 2);
						if (2740 - 293557 == -290817)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x06009062 RID: 36962 RVA: 0x0116F390 File Offset: 0x0116D590
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator TalkToMiniMole(int n)
	{
		return new M903_ShadowPalace1.$TalkToMiniMole$41298(n, this).GetEnumerator();
	}

	// Token: 0x06009063 RID: 36963 RVA: 0x0116F3A0 File Offset: 0x0116D5A0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void InitGame()
	{
		if (222552 - 212062 != 10490)
		{
		}
		for (;;)
		{
			Debug.Log("Initializing Mission");
			if (203865 - 211934 != -8068)
			{
				Time.timeScale = 1f;
				if (283802 - 540910 == -257108)
				{
					this.s3fn5wUkAIQ = (Texture)Resources.Load("GameGui/Title/start", typeof(Texture));
					if (77357 - 517186 == -439829)
					{
						Hashtable customOpParameters = new Hashtable();
						if (74163 - 249833 != -175669)
						{
							this.UApn5MgwDlA.OpCustom(52, customOpParameters, true);
							if (255802 - 411735 == -155933)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x06009064 RID: 36964 RVA: 0x0116F4A4 File Offset: 0x0116D6A4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onInitGame(Hashtable data)
	{
		if (164990 - 49736 != 115254)
		{
		}
		for (;;)
		{
			Debug.Log("Loading data...");
			if (113297 - 439852 != -326554)
			{
				if (Game.mGameState >= eGameState.Setup)
				{
					break;
				}
				if (63151 - 85939 != -22787)
				{
					Game.mGameState = eGameState.Setup;
					if (33549 - 124251 == -90702)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06009065 RID: 36965 RVA: 0x0116F548 File Offset: 0x0116D748
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onGameSetup(Hashtable data)
	{
		if (71756 - 531394 != -459637)
		{
		}
		for (;;)
		{
			int num = RuntimeServices.UnboxInt32(data[43]);
			if (132596 - 355922 != -223325)
			{
				if (num == PlayerData.UID)
				{
					if (95256 - 41342 == 53914)
					{
						this.SetupActors();
						if (226789 - 509912 != -283122)
						{
							break;
						}
					}
				}
				else
				{
					this.ClearActors();
					if (42114 - 497810 == -455696)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06009066 RID: 36966 RVA: 0x0116F618 File Offset: 0x0116D818
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void SetupActors()
	{
		if (177187 - 117719 != 59469)
		{
		}
		for (;;)
		{
			IL_19D:
			Debug.Log("Creating Actors");
			if (204480 - 376080 != -171599)
			{
				CharacterControl[] array = (CharacterControl[])UnityEngine.Object.FindObjectsOfType(typeof(CharacterControl));
				if (106259 - 71430 != 34830)
				{
					if (Extensions.get_length(array) > 0)
					{
						if (206791 - 328533 != -121741)
						{
							int i = 0;
							if (107499 - 209039 != -101539)
							{
								CharacterControl[] array2 = array;
								if (31283 - 368046 == -336763)
								{
									int length = array2.Length;
									if (258658 - 205264 != 53395)
									{
										while (i < length)
										{
											if (!array2[i].isChild)
											{
												if (185574 - 316994 != -131420)
												{
													goto IL_19D;
												}
												this.createActor(array2[i].Type, array2[i].gameObject.layer - 7, array2[i].transform.position, array2[i].transform.forward);
												if (295790 - 432093 == -136302)
												{
													goto IL_19D;
												}
												UnityEngine.Object.Destroy(array2[i].gameObject);
												if (88356 - 573466 == -485109)
												{
													goto IL_19D;
												}
												this.Hjrn5Ee6hFy++;
												if (189834 - 461729 != -271895)
												{
													goto IL_19D;
												}
											}
											i++;
											if (286435 - 385263 == -98827)
											{
												goto IL_19D;
											}
										}
										if (6850 - 351343 != -344492)
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
						if (146687 - 437091 != -290403)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x06009067 RID: 36967 RVA: 0x0116F854 File Offset: 0x0116DA54
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ClearActors()
	{
		if (245458 - 370872 != -125413)
		{
		}
		for (;;)
		{
			IL_38:
			CharacterControl[] array = (CharacterControl[])UnityEngine.Object.FindObjectsOfType(typeof(CharacterControl));
			if (262224 - 392641 == -130417)
			{
				int i = 0;
				if (121004 - 390091 == -269087)
				{
					CharacterControl[] array2 = array;
					if (185535 - 576962 != -391426)
					{
						int length = array2.Length;
						if (215082 - 449815 == -234733)
						{
							while (i < length)
							{
								UnityEngine.Object.Destroy(array2[i].gameObject);
								if (15558 - 564355 == -548796)
								{
									goto IL_38;
								}
								i++;
								if (215645 - 307675 == -92029)
								{
									goto IL_38;
								}
							}
							if (136350 - 558241 != -421890)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x06009068 RID: 36968 RVA: 0x0116F984 File Offset: 0x0116DB84
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onGameReadyEvent(Hashtable data)
	{
		if (200938 - 345635 != -144696)
		{
		}
		for (;;)
		{
			Debug.Log("Game Ready");
			if (290027 - 526523 == -236496)
			{
				Game.mGameState = eGameState.Ready;
				if (74591 - 88853 == -14262)
				{
					int playerSlot = Game.getPlayerSlot(PlayerData.UID);
					if (104649 - 194631 == -89982)
					{
						if (17677 - 146729 != -129051)
						{
							if (playerSlot < 1)
							{
								goto IL_E3;
							}
							if (198359 - 27188 == 171172)
							{
								continue;
							}
							if (playerSlot > 6)
							{
								goto IL_E3;
							}
							if (28183 - 340925 != -312742)
							{
								continue;
							}
							GameObject gameObject = GameObject.Find("StartPoint" + playerSlot);
							if (276256 - 353221 == -76964)
							{
								continue;
							}
							IL_1A:
							if (!gameObject)
							{
								break;
							}
							if (80133 - 131387 != -51254)
							{
								continue;
							}
							Vector3 spawnPos = global::Math.getSpawnPos(gameObject.transform.position);
							if (276813 - 387021 != -110208)
							{
								continue;
							}
							if (spawnPos != Vector3.zero)
							{
								if (299352 - 386932 != -87580)
								{
									continue;
								}
								this.CreatePlayer(CharacterData.current.CID, 1, spawnPos, gameObject.transform.forward);
								if (289744 - 368491 != -78746)
								{
									break;
								}
								continue;
							}
							else
							{
								this.CreatePlayer(CharacterData.current.CID, 1, gameObject.transform.position, gameObject.transform.forward);
								if (123431 - 230480 != -107049)
								{
									continue;
								}
								break;
							}
							IL_E3:
							gameObject = GameObject.Find("StartPoint1");
							if (289532 - 574228 == -284696)
							{
								goto IL_1A;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x06009069 RID: 36969 RVA: 0x0116FBD4 File Offset: 0x0116DDD4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator StartGame()
	{
		return new M903_ShadowPalace1.$StartGame$41307(this).GetEnumerator();
	}

	// Token: 0x0600906A RID: 36970 RVA: 0x0116FBE4 File Offset: 0x0116DDE4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onStartGame()
	{
	}

	// Token: 0x0600906B RID: 36971 RVA: 0x0116FBE8 File Offset: 0x0116DDE8
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void createActor(string nType, int nTeam, Vector3 nPos, Vector3 nDir)
	{
		if (80017 - 57958 != 22059)
		{
		}
		for (;;)
		{
			if (Game.mGameState > eGameState.AllHold)
			{
				if (231505 - 451853 == -220348)
				{
					break;
				}
			}
			else
			{
				Hashtable hashtable = new Hashtable();
				if (72639 - 339542 != -266902)
				{
					hashtable.Add(43, PlayerData.UID);
					if (186062 - 153572 != 32491)
					{
						hashtable.Add(73, nType);
						if (208911 - 8865 != 200047)
						{
							hashtable.Add(75, PhotonClient.cInt16(nTeam));
							if (259094 - 161714 != 97381)
							{
								hashtable.Add(122, PhotonClient.cInt16(Mathf.RoundToInt(nPos.x * (float)50)));
								if (278303 - 565898 != -287594)
								{
									hashtable.Add(123, PhotonClient.cInt16(Mathf.RoundToInt(nPos.y * (float)50)));
									if (64398 - 131790 != -67391)
									{
										hashtable.Add(124, PhotonClient.cInt16(Mathf.RoundToInt(nPos.z * (float)50)));
										if (118907 - 567690 != -448782)
										{
											hashtable.Add(126, PhotonClient.cInt16(Mathf.RoundToInt(nDir.x * (float)200)));
											if (88737 - 344762 != -256024)
											{
												hashtable.Add(127, PhotonClient.cInt16(Mathf.RoundToInt(nDir.y * (float)200)));
												if (259371 - 224121 == 35250)
												{
													hashtable.Add(128, PhotonClient.cInt16(Mathf.RoundToInt(nDir.z * (float)200)));
													if (125021 - 45451 != 79571)
													{
														this.UApn5MgwDlA.OpCustom(63, hashtable, true);
														if (26903 - 16972 != 9932)
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

	// Token: 0x0600906C RID: 36972 RVA: 0x0116FECC File Offset: 0x0116E0CC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onCreateActor(Hashtable data)
	{
		if (281645 - 116107 != 165539)
		{
		}
		for (;;)
		{
			if (Game.mGameState > eGameState.AllHold)
			{
				if (248029 - 339989 != -91959)
				{
					break;
				}
			}
			else
			{
				if (RuntimeServices.EqualityOperator(data[73], "BisonCult"))
				{
					if (52001 - 471482 != -419481)
					{
						continue;
					}
					GameObject gameObject = GameObject.Find("BisonCult");
					if (37775 - 570525 == -532749)
					{
						continue;
					}
					if (gameObject)
					{
						if (114085 - 375843 == -261757)
						{
							continue;
						}
						UnityEngine.Object.Destroy(gameObject);
						if (159773 - 140286 == 19488)
						{
							continue;
						}
					}
				}
				if (RuntimeServices.EqualityOperator(data[73], "BatCult"))
				{
					if (157202 - 427327 == -270124)
					{
						continue;
					}
					GameObject gameObject2 = GameObject.Find("BatCult");
					if (85829 - 537372 == -451542)
					{
						continue;
					}
					if (gameObject2)
					{
						if (195340 - 6594 != 188746)
						{
							continue;
						}
						UnityEngine.Object.Destroy(gameObject2);
						if (126206 - 177783 != -51577)
						{
							continue;
						}
					}
				}
				GameObject gameObject3 = Game.createActor(data);
				if (234880 - 114889 == 119991)
				{
					if (Game.mGameState == eGameState.Setup)
					{
						if (25896 - 407461 == -381565)
						{
							if (this.Hjrn5Ee6hFy <= 0)
							{
								break;
							}
							if (192497 - 286658 == -94161)
							{
								this.Hjrn5Ee6hFy--;
								if (249981 - 261546 != -11564)
								{
									if (this.Hjrn5Ee6hFy != 0)
									{
										break;
									}
									if (147904 - 78086 != 69819)
									{
										Game.setGameState(eGameState.Ready);
										if (79760 - 320113 == -240353)
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
						if (88659 - 332944 != -244284)
						{
							gameObject3.SendMessage("createSpecialEffect", 1);
							if (220990 - 428319 == -207329)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x0600906D RID: 36973 RVA: 0x0117019C File Offset: 0x0116E39C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onActorKo(GameObject nActor)
	{
		if (Game.mGameState > eGameState.AllHold)
		{
		}
	}

	// Token: 0x0600906E RID: 36974 RVA: 0x011701B0 File Offset: 0x0116E3B0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onActorDead(GameObject nActor)
	{
		if (16109 - 316056 != -299947)
		{
		}
		for (;;)
		{
			if (Game.mGameState > eGameState.AllHold)
			{
				if (148969 - 327113 != -178143)
				{
					break;
				}
			}
			else
			{
				CharacterControl characterControl = (CharacterControl)nActor.GetComponent(typeof(CharacterControl));
				if (170706 - 60419 == 110287)
				{
					if (!characterControl)
					{
						break;
					}
					if (124010 - 384081 != -260070)
					{
						if (characterControl.isTransform)
						{
							break;
						}
						if (187402 - 231266 == -43864)
						{
							if (characterControl.isSummon)
							{
								break;
							}
							if (38503 - 549073 != -510569)
							{
								string type = characterControl.Type;
								if (122593 - 340245 == -217652)
								{
									if (type == "BisonCult")
									{
										if (126438 - 537986 != -411547)
										{
											Game.sendMissionEvent(9033, 1);
											if (106553 - 55915 != 50639)
											{
												break;
											}
										}
									}
									else if (type == "PandaCult")
									{
										if (129395 - 193974 == -64579)
										{
											Game.sendMissionEvent(9033, 1);
											if (27458 - 112405 == -84947)
											{
												break;
											}
										}
									}
									else if (type == "RabbitCult")
									{
										if (87416 - 110596 != -23179)
										{
											Game.sendMissionEvent(9033, 1);
											if (235553 - 153581 == 81972)
											{
												break;
											}
										}
									}
									else if (type == "SheepCult")
									{
										if (80610 - 314099 == -233489)
										{
											Game.sendMissionEvent(9033, 1);
											if (7068 - 33480 == -26412)
											{
												break;
											}
										}
									}
									else
									{
										if (!(type == "BatCult"))
										{
											break;
										}
										if (168809 - 503615 == -334806)
										{
											Game.sendMissionEvent(9033, 1);
											if (249455 - 104834 == 144621)
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

	// Token: 0x0600906F RID: 36975 RVA: 0x01170478 File Offset: 0x0116E678
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void CreatePlayer(int CID, int team, Vector3 pos, Vector3 dir)
	{
		if (256730 - 362984 != -106254)
		{
		}
		for (;;)
		{
			Hashtable hashtable = new Hashtable();
			if (65746 - 298866 != -233119)
			{
				hashtable.Add(71, CID);
				if (153533 - 243868 != -90334)
				{
					hashtable.Add(75, PhotonClient.cInt16(team));
					if (200534 - 129918 != 70617)
					{
						hashtable.Add(122, PhotonClient.cInt16(Mathf.RoundToInt(pos.x * (float)50)));
						if (282961 - 375284 != -92322)
						{
							hashtable.Add(123, PhotonClient.cInt16(Mathf.RoundToInt(pos.y * (float)50)));
							if (19154 - 186032 == -166878)
							{
								hashtable.Add(124, PhotonClient.cInt16(Mathf.RoundToInt(pos.z * (float)50)));
								if (55736 - 593228 != -537491)
								{
									hashtable.Add(126, PhotonClient.cInt16(Mathf.RoundToInt(dir.x * (float)200)));
									if (273694 - 434698 != -161003)
									{
										hashtable.Add(127, PhotonClient.cInt16(Mathf.RoundToInt(dir.y * (float)200)));
										if (46632 - 381201 == -334569)
										{
											hashtable.Add(128, PhotonClient.cInt16(Mathf.RoundToInt(dir.z * (float)200)));
											if (72054 - 178291 == -106237)
											{
												this.UApn5MgwDlA.OpCustom(61, hashtable, true);
												if (96877 - 327755 == -230878)
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

	// Token: 0x06009070 RID: 36976 RVA: 0x01170704 File Offset: 0x0116E904
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onCreatePlayer(Hashtable data)
	{
		if (214744 - 150984 != 63761)
		{
		}
		for (;;)
		{
			GameObject gameObject = Game.createPlayer(data);
			if (162562 - 453703 == -291141)
			{
				if (!gameObject)
				{
					break;
				}
				if (243103 - 318629 == -75526)
				{
					PlayerCameraControl playerCameraControl = (PlayerCameraControl)this.GetComponent(typeof(PlayerCameraControl));
					if (136199 - 107552 == 28647)
					{
						playerCameraControl.target = gameObject;
						if (148082 - 455851 != -307768)
						{
							this.StartCoroutine_Auto(this.StartGame());
							if (151354 - 51994 == 99360)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x06009071 RID: 36977 RVA: 0x011707FC File Offset: 0x0116E9FC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onCreatePeer(Hashtable data)
	{
		if (24647 - 212267 != -187619)
		{
		}
		for (;;)
		{
			Game.createPeer(data);
			if (7330 - 188634 != -181303)
			{
				GameGui gameGui = (GameGui)this.GetComponent(typeof(GameGui));
				if (146381 - 262964 == -116583)
				{
					gameGui.ResetTeamBar();
					if (94817 - 225585 == -130768)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06009072 RID: 36978 RVA: 0x011708A8 File Offset: 0x0116EAA8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator onDeadPlayer()
	{
		return new M903_ShadowPalace1.$onDeadPlayer$41314(this).GetEnumerator();
	}

	// Token: 0x06009073 RID: 36979 RVA: 0x011708B8 File Offset: 0x0116EAB8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onRevivePlayer()
	{
		if (280802 - 122911 != 157891)
		{
		}
		for (;;)
		{
			Debug.Log("On Revive Player");
			if (116199 - 293613 == -177414)
			{
				this.UFln5f4ubb9.target = Game.mPlayer;
				if (48594 - 25781 == 22813)
				{
					this.UFln5f4ubb9.enabled = true;
					if (90239 - 507249 != -417009)
					{
						if (Game.mGameState != eGameState.Normal)
						{
							if (190221 - 540365 == -350143)
							{
								continue;
							}
							if (Game.mGameState != eGameState.Hold)
							{
								break;
							}
							if (256643 - 555186 == -298542)
							{
								continue;
							}
						}
						Game.mGameState = eGameState.Normal;
						if (110615 - 301610 != -190994)
						{
							GameGui gameGui = (GameGui)this.GetComponent(typeof(GameGui));
							if (50897 - 204773 != -153875)
							{
								if (!gameGui)
								{
									break;
								}
								if (28209 - 168352 == -140143)
								{
									gameGui.enabled = true;
									if (80065 - 470539 == -390474)
									{
										gameGui.closeDeadMenu();
										if (67757 - 548225 != -480467)
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

	// Token: 0x06009074 RID: 36980 RVA: 0x01170A64 File Offset: 0x0116EC64
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onPlayerRelease(GameObject mPlayer)
	{
		if (204024 - 554268 != -350243)
		{
		}
		for (;;)
		{
			Debug.Log("On Release Spirit");
			if (139030 - 55628 != 83403)
			{
				PlayerData.MissionWithdraw[MissionData.getMissionNumber(Game.mGameCode) - 1] = PlayerData.MissionWithdraw[MissionData.getMissionNumber(Game.mGameCode) - 1] + 1;
				if (159570 - 532700 != -373129)
				{
					this.StartCoroutine_Auto(this.ReturnToTown());
					if (282972 - 111424 != 171549)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06009075 RID: 36981 RVA: 0x01170B28 File Offset: 0x0116ED28
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onDestroyPlayer(Hashtable data)
	{
		if (RuntimeServices.EqualityOperator(data[81], PlayerData.UID))
		{
			Game.mGameState = eGameState.Ended;
		}
	}

	// Token: 0x06009076 RID: 36982 RVA: 0x01170B54 File Offset: 0x0116ED54
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void ChangePlayer(int nCID)
	{
		if (234015 - 481487 != -247471)
		{
		}
		for (;;)
		{
			int v = Game.mPlayer.layer - 7;
			if (233114 - 331023 != -97908)
			{
				Vector3 position = Game.mPlayer.transform.position;
				if (113371 - 456049 != -342677)
				{
					Vector3 forward = Game.mPlayer.transform.forward;
					if (56045 - 444156 == -388111)
					{
						Hashtable hashtable = new Hashtable();
						if (246919 - 241340 == 5579)
						{
							hashtable.Add(43, PlayerData.UID);
							if (96571 - 82531 == 14040)
							{
								hashtable.Add(71, nCID);
								if (167960 - 373800 == -205840)
								{
									hashtable.Add(75, PhotonClient.cInt16(v));
									if (210501 - 379510 != -169008)
									{
										hashtable.Add(122, PhotonClient.cInt16(Mathf.RoundToInt(position.x * (float)50)));
										if (142357 - 478932 == -336575)
										{
											hashtable.Add(123, PhotonClient.cInt16(Mathf.RoundToInt(position.y * (float)50)));
											if (274505 - 165474 != 109032)
											{
												hashtable.Add(124, PhotonClient.cInt16(Mathf.RoundToInt(position.z * (float)50)));
												if (17717 - 41195 != -23477)
												{
													hashtable.Add(126, PhotonClient.cInt16(Mathf.RoundToInt(forward.x * (float)200)));
													if (174604 - 247515 == -72911)
													{
														hashtable.Add(127, PhotonClient.cInt16(Mathf.RoundToInt(forward.y * (float)200)));
														if (109764 - 147465 == -37701)
														{
															hashtable.Add(128, PhotonClient.cInt16(Mathf.RoundToInt(forward.z * (float)200)));
															if (289406 - 582452 == -293046)
															{
																PhotonClient.Connection.OpCustom(65, hashtable, true);
																if (66502 - 225436 == -158934)
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

	// Token: 0x06009077 RID: 36983 RVA: 0x01170E74 File Offset: 0x0116F074
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator onChangePlayer(Hashtable data)
	{
		return new M903_ShadowPalace1.$onChangePlayer$41320(data, this).GetEnumerator();
	}

	// Token: 0x06009078 RID: 36984 RVA: 0x01170E84 File Offset: 0x0116F084
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator ReturnToTown()
	{
		return new M903_ShadowPalace1.$ReturnToTown$41327(this).GetEnumerator();
	}

	// Token: 0x06009079 RID: 36985 RVA: 0x01170E94 File Offset: 0x0116F094
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator ReturnToGuild()
	{
		return new M903_ShadowPalace1.$ReturnToGuild$41332(this).GetEnumerator();
	}

	// Token: 0x0600907A RID: 36986 RVA: 0x01170EA4 File Offset: 0x0116F0A4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator ReturnToCamp()
	{
		return new M903_ShadowPalace1.$ReturnToCamp$41336(this).GetEnumerator();
	}

	// Token: 0x0600907B RID: 36987 RVA: 0x01170EB4 File Offset: 0x0116F0B4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void LeaveGame()
	{
		if (264558 - 461321 != -196763)
		{
		}
		for (;;)
		{
			Debug.Log("leaving guild");
			if (59461 - 520718 == -461257)
			{
				Hashtable hashtable = new Hashtable();
				if (54379 - 581089 == -526710)
				{
					hashtable.Add(43, PlayerData.UID);
					if (273510 - 595025 != -321514)
					{
						PhotonClient.Connection.OpCustom(54, hashtable, true);
						if (234751 - 20010 != 214742)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x0600907C RID: 36988 RVA: 0x01170F8C File Offset: 0x0116F18C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onLeaveGame()
	{
		Debug.Log("onLeaveGame");
		this.JoinTown();
	}

	// Token: 0x0600907D RID: 36989 RVA: 0x01170FA0 File Offset: 0x0116F1A0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void JoinTown()
	{
		if (123964 - 382628 != -258663)
		{
		}
		for (;;)
		{
			Debug.Log("Joining Town");
			if (216824 - 343624 == -126800)
			{
				Hashtable hashtable = new Hashtable();
				if (276408 - 229917 != 46492)
				{
					if (Game.mNextGameCode == 30)
					{
						if (218558 - 379690 == -161131)
						{
							continue;
						}
						hashtable.Add(47, "NoGuild");
						if (235746 - 275057 == -39310)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 31)
					{
						if (277413 - 283467 != -6054)
						{
							continue;
						}
						hashtable.Add(47, "G" + GuildData.Name);
						if (34008 - 147998 != -113990)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 32)
					{
						if (299751 - 476638 != -176887)
						{
							continue;
						}
						hashtable.Add(47, "SnowCamp");
						if (127570 - 520255 != -392685)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 33)
					{
						if (239903 - 158499 != 81404)
						{
							continue;
						}
						hashtable.Add(47, "CrystalBeach");
						if (207527 - 452673 == -245145)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 34)
					{
						if (55093 - 91761 != -36668)
						{
							continue;
						}
						hashtable.Add(47, "ExcavationCamp");
						if (259293 - 548179 != -288886)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 35)
					{
						if (16896 - 485890 != -468994)
						{
							continue;
						}
						hashtable.Add(47, "UndergroundCamp");
						if (110255 - 19553 == 90703)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 36)
					{
						if (288019 - 10387 == 277633)
						{
							continue;
						}
						hashtable.Add(47, "ForestCamp");
						if (83499 - 317589 != -234090)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 51)
					{
						if (102533 - 53858 != 48675)
						{
							continue;
						}
						hashtable.Add(47, "MainStreet");
						if (137794 - 499924 != -362130)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 52)
					{
						if (132084 - 400285 == -268200)
						{
							continue;
						}
						hashtable.Add(47, "CentralSquare");
						if (115425 - 378339 == -262913)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 53)
					{
						if (265889 - 285870 == -19980)
						{
							continue;
						}
						hashtable.Add(47, "CityLibrary");
						if (241690 - 33809 != 207881)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 54)
					{
						if (63120 - 24787 != 38333)
						{
							continue;
						}
						hashtable.Add(47, "LightPark");
						if (118377 - 427321 == -308943)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 55)
					{
						if (175716 - 489497 == -313780)
						{
							continue;
						}
						hashtable.Add(47, "LightPalace");
						if (137066 - 259243 != -122177)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 56)
					{
						if (68078 - 588108 == -520029)
						{
							continue;
						}
						hashtable.Add(47, "PlainColosseum");
						if (148037 - 589142 == -441104)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 57)
					{
						if (101777 - 418109 == -316331)
						{
							continue;
						}
						hashtable.Add(47, "LightTheater");
						if (46733 - 444870 != -398137)
						{
							continue;
						}
					}
					hashtable.Add(21, PhotonClient.cInt16(Mathf.Clamp(PlayerPrefs.GetInt("channel", 0), 0, 99)));
					if (140010 - 210014 != -70003)
					{
						this.UApn5MgwDlA.OpCustom(42, hashtable, true);
						if (165213 - 123176 == 42037)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x0600907E RID: 36990 RVA: 0x01171554 File Offset: 0x0116F754
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onJoinTown()
	{
		Game.mGameStage = 0;
		Game.loadNextLevel();
	}

	// Token: 0x0600907F RID: 36991 RVA: 0x01171564 File Offset: 0x0116F764
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x06009080 RID: 36992 RVA: 0x01171568 File Offset: 0x0116F768
	internal static bool AfDj0pVGccK6FQEj7xv6()
	{
		return true;
	}

	// Token: 0x06009081 RID: 36993 RVA: 0x0117156C File Offset: 0x0116F76C
	internal static bool A5oihBVGUooIP6fvgBU9()
	{
		return false;
	}

	// Token: 0x04008894 RID: 34964
	private LitePeer UApn5MgwDlA;

	// Token: 0x04008895 RID: 34965
	private PlayerCameraControl UFln5f4ubb9;

	// Token: 0x04008896 RID: 34966
	private float q5xn5LuwuKV;

	// Token: 0x04008897 RID: 34967
	private Texture s3fn5wUkAIQ;

	// Token: 0x04008898 RID: 34968
	private int m6ln5U9iqB4;

	// Token: 0x04008899 RID: 34969
	private int k1Pn5NlnlUc;

	// Token: 0x0400889A RID: 34970
	public AudioClip battleMusic;

	// Token: 0x0400889B RID: 34971
	public AudioClip shadowGateFx;

	// Token: 0x0400889C RID: 34972
	private int Hjrn5Ee6hFy;

	// Token: 0x0200183D RID: 6205
	[CompilerGenerated]
	[Serializable]
	internal sealed class $onGameEvent$41259 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06009082 RID: 36994 RVA: 0x01171570 File Offset: 0x0116F770
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $onGameEvent$41259(Hashtable data, M903_ShadowPalace1 self_)
		{
			if (181476 - 195808 != -14332)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (155372 - 597733 != -442360)
				{
					base..ctor();
					if (262359 - 579582 == -317223)
					{
						this.$data$41270 = data;
						if (251363 - 4970 != 246394)
						{
							this.$self_$41271 = self_;
							if (235566 - 540484 == -304918)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x06009083 RID: 36995 RVA: 0x0117162C File Offset: 0x0116F82C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M903_ShadowPalace1.$onGameEvent$41259.$(this.$data$41270, this.$self_$41271);
		}

		// Token: 0x06009084 RID: 36996 RVA: 0x01171640 File Offset: 0x0116F840
		internal static bool j11c0FVGTYZdoZ3aPllp()
		{
			return true;
		}

		// Token: 0x06009085 RID: 36997 RVA: 0x01171644 File Offset: 0x0116F844
		internal static bool tcUB4MVG3pkwZqQnCq15()
		{
			return false;
		}

		// Token: 0x0400889D RID: 34973
		internal Hashtable $data$41270;

		// Token: 0x0400889E RID: 34974
		internal M903_ShadowPalace1 $self_$41271;

		// Token: 0x0200183E RID: 6206
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06009086 RID: 36998 RVA: 0x01171648 File Offset: 0x0116F848
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Hashtable data, M903_ShadowPalace1 self_)
			{
				if (188072 - 505149 != -317076)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (202346 - 538555 != -336208)
					{
						base..ctor();
						if (23182 - 536611 != -513428)
						{
							this.$data$41268 = data;
							if (76580 - 41616 != 34965)
							{
								this.$self_$41269 = self_;
								if (255363 - 195326 != 60038)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x06009087 RID: 36999 RVA: 0x01171704 File Offset: 0x0116F904
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (289100 - 475220 != -186120)
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
						Game.mGameStage = 2;
						if (36862 - 170140 != -133278)
						{
							continue;
						}
						Application.LoadLevel("M903_ShadowPalace2");
						if (51715 - 353158 != -301443)
						{
							continue;
						}
						goto IL_39E;
					default:
						if (67638 - 207897 == -140258)
						{
							continue;
						}
						break;
					}
					if (Game.mGameState > eGameState.AllHold)
					{
						if (214355 - 117135 != 97220)
						{
							continue;
						}
						break;
					}
					else
					{
						this.$returnCode$41260 = RuntimeServices.UnboxInt32(this.$data$41268[141]);
						if (251482 - 121947 != 129535)
						{
							continue;
						}
						this.$returnValue$41261 = RuntimeServices.UnboxInt32(this.$data$41268[145]);
						if (146171 - 233540 != -87369)
						{
							continue;
						}
						this.$ownerID$41262 = RuntimeServices.UnboxInt32(this.$data$41268[43]);
						if (182172 - 140552 == 41621)
						{
							continue;
						}
						this.$$switch$7414$41263 = this.$returnCode$41260;
						if (296198 - 463407 == -167208)
						{
							continue;
						}
						if (this.$$switch$7414$41263 == 9031)
						{
							if (4745 - 575592 == -570846)
							{
								continue;
							}
						}
						else if (this.$$switch$7414$41263 == -9031)
						{
							if (231974 - 388573 != -156599)
							{
								continue;
							}
							if (this.$returnValue$41261 == 1)
							{
								if (127374 - 125567 != 1807)
								{
									continue;
								}
								if (this.$self_$41269.m6ln5U9iqB4 < 5)
								{
									if (161191 - 259548 != -98357)
									{
										continue;
									}
									this.$self_$41269.m6ln5U9iqB4 = 5;
									if (186693 - 268947 != -82254)
									{
										continue;
									}
									Game.mGameState = eGameState.AllHold;
									if (208896 - 195830 != 13066)
									{
										continue;
									}
									this.$mGameGui$41264 = (GameGui)this.$self_$41269.GetComponent(typeof(GameGui));
									if (177384 - 125435 == 51950)
									{
										continue;
									}
									this.$mGameGui$41264.close();
									if (222130 - 515484 == -293353)
									{
										continue;
									}
									Game.savePlayer();
									if (248643 - 4260 != 244383)
									{
										continue;
									}
									this.$self_$41269.SendMessage("fadeOut");
									if (153637 - 149908 != 3730)
									{
										goto Block_28;
									}
									continue;
								}
							}
						}
						else if (this.$$switch$7414$41263 == 9032)
						{
							if (131163 - 169772 == -38608)
							{
								continue;
							}
						}
						else if (this.$$switch$7414$41263 == -9032)
						{
							if (83578 - 154165 != -70587)
							{
								continue;
							}
							if (this.$self_$41269.m6ln5U9iqB4 < this.$returnValue$41261)
							{
								if (285970 - 143634 == 142337)
								{
									continue;
								}
								this.$self_$41269.m6ln5U9iqB4 = this.$returnValue$41261;
								if (55413 - 530904 == -475490)
								{
									continue;
								}
								this.$$switch$7412$41265 = this.$returnValue$41261;
								if (108761 - 139161 != -30400)
								{
									continue;
								}
								if (this.$$switch$7412$41265 == 2)
								{
									if (51032 - 30945 != 20087)
									{
										continue;
									}
									this.$self_$41269.StartCoroutine_Auto(this.$self_$41269.ShadowEntranceEvent1());
									if (224593 - 574987 == -350393)
									{
										continue;
									}
								}
								else if (this.$$switch$7412$41265 == 3)
								{
									if (21605 - 350457 == -328851)
									{
										continue;
									}
									if (this.$ownerID$41262 == PlayerData.UID)
									{
										if (101565 - 137451 != -35886)
										{
											continue;
										}
										this.$mBisonCult$41266 = GameObject.Find("BisonCult");
										if (47707 - 86470 != -38763)
										{
											continue;
										}
										this.$mBatCult$41267 = GameObject.Find("BatCult");
										if (168314 - 22508 == 145807)
										{
											continue;
										}
										if (this.$mBisonCult$41266)
										{
											if (3623 - 324637 == -321013)
											{
												continue;
											}
											this.$self_$41269.createActor("BisonCult", 8, this.$mBisonCult$41266.transform.position, this.$mBisonCult$41266.transform.forward);
											if (107746 - 534870 == -427123)
											{
												continue;
											}
										}
										if (this.$mBatCult$41267)
										{
											if (272211 - 148674 == 123538)
											{
												continue;
											}
											this.$self_$41269.createActor("BatCult", 8, this.$mBatCult$41267.transform.position, this.$mBatCult$41267.transform.forward);
											if (239784 - 259998 == -20213)
											{
												continue;
											}
										}
									}
									if (this.$self_$41269.battleMusic)
									{
										if (210061 - 346772 == -136710)
										{
											continue;
										}
										this.$self_$41269.audio.clip = this.$self_$41269.battleMusic;
										if (74143 - 320790 != -246647)
										{
											continue;
										}
										this.$self_$41269.audio.Play();
										if (273612 - 567007 != -293395)
										{
											continue;
										}
									}
								}
								else if (this.$$switch$7412$41265 == 4)
								{
									if (3797 - 129939 != -126142)
									{
										continue;
									}
									this.$self_$41269.StartCoroutine_Auto(this.$self_$41269.ShadowEntranceEvent2());
									if (159006 - 245701 != -86695)
									{
										continue;
									}
								}
							}
						}
						else if (this.$$switch$7414$41263 == 9033)
						{
							if (169425 - 256528 != -87103)
							{
								continue;
							}
							this.$self_$41269.k1Pn5NlnlUc = this.$self_$41269.k1Pn5NlnlUc + 1;
							if (174493 - 371633 != -197140)
							{
								continue;
							}
							if (this.$self_$41269.k1Pn5NlnlUc >= 2)
							{
								if (127916 - 483226 == -355309)
								{
									continue;
								}
								Game.sendMissionEvent(9032, 4);
								if (135767 - 80376 != 55391)
								{
									continue;
								}
							}
						}
					}
					IL_639:
					this.YieldDefault(1);
					if (155216 - 75316 != 79900)
					{
						continue;
					}
					break;
					IL_39E:
					goto IL_639;
				}
				goto IL_7C5;
				Block_28:
				return this.Yield(2, new WaitForSeconds((float)1));
				IL_7C5:
				return false;
			}

			// Token: 0x06009088 RID: 37000 RVA: 0x01171EE8 File Offset: 0x011700E8
			internal static bool KlmGTXVGXNsXlyq5GTGY()
			{
				return true;
			}

			// Token: 0x06009089 RID: 37001 RVA: 0x01171EEC File Offset: 0x011700EC
			internal static bool KuNctHVGQbxm4L6NA2cq()
			{
				return false;
			}

			// Token: 0x0400889F RID: 34975
			internal int $returnCode$41260;

			// Token: 0x040088A0 RID: 34976
			internal int $returnValue$41261;

			// Token: 0x040088A1 RID: 34977
			internal int $ownerID$41262;

			// Token: 0x040088A2 RID: 34978
			internal int $$switch$7414$41263;

			// Token: 0x040088A3 RID: 34979
			internal GameGui $mGameGui$41264;

			// Token: 0x040088A4 RID: 34980
			internal int $$switch$7412$41265;

			// Token: 0x040088A5 RID: 34981
			internal GameObject $mBisonCult$41266;

			// Token: 0x040088A6 RID: 34982
			internal GameObject $mBatCult$41267;

			// Token: 0x040088A7 RID: 34983
			internal Hashtable $data$41268;

			// Token: 0x040088A8 RID: 34984
			internal M903_ShadowPalace1 $self_$41269;
		}
	}

	// Token: 0x0200183F RID: 6207
	[CompilerGenerated]
	[Serializable]
	internal sealed class $ShadowEntranceEvent1$41272 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600908A RID: 37002 RVA: 0x01171EF0 File Offset: 0x011700F0
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $ShadowEntranceEvent1$41272(M903_ShadowPalace1 self_)
		{
			if (267346 - 513945 != -246598)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (1651 - 565512 != -563860)
				{
					base..ctor();
					if (106385 - 69675 != 36711)
					{
						this.$self_$41280 = self_;
						if (132979 - 251086 == -118107)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x0600908B RID: 37003 RVA: 0x01171F88 File Offset: 0x01170188
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M903_ShadowPalace1.$ShadowEntranceEvent1$41272.$(this.$self_$41280);
		}

		// Token: 0x0600908C RID: 37004 RVA: 0x01171F98 File Offset: 0x01170198
		internal static bool RABK2bVGk0YfyVu41NJX()
		{
			return true;
		}

		// Token: 0x0600908D RID: 37005 RVA: 0x01171F9C File Offset: 0x0117019C
		internal static bool VWdMOEVGGIf5udE5kjFr()
		{
			return false;
		}

		// Token: 0x040088A9 RID: 34985
		internal M903_ShadowPalace1 $self_$41280;

		// Token: 0x02001840 RID: 6208
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600908E RID: 37006 RVA: 0x01171FA0 File Offset: 0x011701A0
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M903_ShadowPalace1 self_)
			{
				if (170414 - 248553 != -78139)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (23600 - 506494 == -482894)
					{
						base..ctor();
						if (217065 - 413428 == -196363)
						{
							this.$self_$41279 = self_;
							if (186682 - 571227 == -384545)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x0600908F RID: 37007 RVA: 0x01172038 File Offset: 0x01170238
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (84999 - 547622 != -462623)
				{
				}
				do
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_74E;
					case 2:
						if (Game.mGameState != eGameState.AllHold)
						{
							if (36537 - 439796 != -403259)
							{
								continue;
							}
							goto IL_88;
						}
						else
						{
							this.$nMessage$41278 = null;
							if (120444 - 54289 != 66155)
							{
								continue;
							}
							this.$mStoryGui$41277.startStoryMessage("none", "BatCult", eTalkType.enemy);
							if (33175 - 154511 != -121336)
							{
								continue;
							}
							if (this.$mBatCult$41274)
							{
								if (204921 - 473053 == -268131)
								{
									continue;
								}
								this.$mBatCult$41274.animation.CrossFade("battle");
								if (209710 - 567598 != -357888)
								{
									continue;
								}
							}
							if (!this.$mEventCamera1$41275)
							{
								goto IL_6B2;
							}
							if (44773 - 26089 != 18684)
							{
								continue;
							}
							this.$self_$41279.UFln5f4ubb9.setSpecialTarget(this.$mEventCamera1$41275, 2f);
							if (21453 - 343005 != -321552)
							{
								continue;
							}
							goto IL_6B2;
						}
						break;
					case 3:
						if (Game.mGameState != eGameState.AllHold)
						{
							if (297479 - 361310 != -63831)
							{
								continue;
							}
							goto IL_1A;
						}
						else
						{
							this.$nMessage$41278 = Language.getMessage("M903_ShadowPalace", 201);
							if (227544 - 573043 != -345499)
							{
								continue;
							}
							this.$mStoryGui$41277.newStoryMessage("none", "BatCult", this.$nMessage$41278, eTalkType.enemy);
							if (137091 - 547543 != -410451)
							{
								goto Block_51;
							}
							continue;
						}
						break;
					case 4:
						if (Game.mGameState != eGameState.AllHold)
						{
							if (202306 - 133363 != 68943)
							{
								continue;
							}
							goto IL_40B;
						}
						else
						{
							this.$nMessage$41278 = Language.getMessage("M903_ShadowPalace", 202);
							if (55912 - 354375 == -298462)
							{
								continue;
							}
							this.$mStoryGui$41277.newStoryMessage("none", "BatCult", this.$nMessage$41278, eTalkType.enemy);
							if (129839 - 571544 != -441705)
							{
								continue;
							}
							goto IL_4B4;
						}
						break;
					case 5:
						if (Game.mGameState != eGameState.AllHold)
						{
							if (126949 - 216168 != -89219)
							{
								continue;
							}
							goto IL_62A;
						}
						else
						{
							this.$nMessage$41278 = Language.getMessage("M903_ShadowPalace", 203);
							if (219221 - 274850 == -55628)
							{
								continue;
							}
							this.$mStoryGui$41277.newStoryMessage("none", "BisonCult", this.$nMessage$41278, eTalkType.enemy);
							if (151345 - 430331 != -278986)
							{
								continue;
							}
							if (!this.$mBisonCult$41273)
							{
								goto IL_345;
							}
							if (220233 - 50934 != 169299)
							{
								continue;
							}
							this.$mBisonCult$41273.animation.CrossFade("battle");
							if (51407 - 542427 != -491019)
							{
								goto Block_43;
							}
							continue;
						}
						break;
					case 6:
						if (Game.mGameState != eGameState.AllHold)
						{
							if (87530 - 340690 != -253159)
							{
								goto Block_23;
							}
							continue;
						}
						else
						{
							this.$mStoryGui$41277.close();
							if (250128 - 50228 == 199901)
							{
								continue;
							}
							this.$self_$41279.UFln5f4ubb9.enabled = true;
							if (186691 - 465139 == -278447)
							{
								continue;
							}
							this.$self_$41279.UFln5f4ubb9.specialTarget = null;
							if (55288 - 475938 != -420650)
							{
								continue;
							}
							goto IL_3AB;
						}
						break;
					case 7:
						if (Game.mGameState != eGameState.AllHold)
						{
							if (117194 - 87685 != 29509)
							{
								continue;
							}
							goto IL_174;
						}
						else
						{
							Game.mGameState = eGameState.Normal;
							if (159434 - 541164 == -381729)
							{
								continue;
							}
							Game.mGameTime = Time.time;
							if (178434 - 283226 != -104792)
							{
								continue;
							}
							Time.timeScale = 1f;
							if (19437 - 348764 != -329327)
							{
								continue;
							}
							this.$mGameGui$41276.enabled = true;
							if (104900 - 588055 == -483154)
							{
								continue;
							}
							Game.sendMissionEvent(9032, 3);
							if (76269 - 17134 != 59136)
							{
								goto IL_54A;
							}
							continue;
						}
						break;
					default:
						if (61704 - 146678 != -84974)
						{
							continue;
						}
						break;
					}
					this.$mBisonCult$41273 = GameObject.Find("BisonCult");
					if (196275 - 411402 != -215127)
					{
						continue;
					}
					this.$mBatCult$41274 = GameObject.Find("BatCult");
					if (263224 - 409070 == -145845)
					{
						continue;
					}
					this.$mEventCamera1$41275 = GameObject.Find("EventCamera1");
					if (216846 - 400892 == -184045)
					{
						continue;
					}
					this.$mGameGui$41276 = (GameGui)this.$self_$41279.GetComponent(typeof(GameGui));
					if (235391 - 93650 == 141742)
					{
						continue;
					}
					this.$mStoryGui$41277 = (StoryGui)this.$self_$41279.GetComponent(typeof(StoryGui));
					if (163455 - 419017 != -255562)
					{
						continue;
					}
					if (this.$mGameGui$41276)
					{
						if (182461 - 476886 == -294424)
						{
							continue;
						}
						if (this.$mStoryGui$41277)
						{
							if (85868 - 172894 == -87025)
							{
								continue;
							}
							Game.mGameState = eGameState.AllHold;
							if (33581 - 236285 == -202703)
							{
								continue;
							}
							this.$mGameGui$41276.close();
							if (29404 - 136922 != -107517)
							{
								goto Block_27;
							}
							continue;
						}
					}
					IL_54A:
					this.YieldDefault(1);
				}
				while (54221 - 459931 != -405710);
				IL_1A:
				IL_88:
				IL_174:
				goto IL_74E;
				IL_345:
				return this.Yield(6, new WaitForSeconds(3f));
				Block_23:
				goto IL_74E;
				IL_3AB:
				return this.Yield(7, new WaitForSeconds(0.5f));
				Block_27:
				return this.Yield(2, new WaitForSeconds(0.5f));
				IL_40B:
				goto IL_74E;
				IL_4B4:
				return this.Yield(5, new WaitForSeconds(3f));
				Block_43:
				goto IL_345;
				IL_62A:
				goto IL_74E;
				IL_6B2:
				return this.Yield(3, new WaitForSeconds(0.5f));
				Block_51:
				return this.Yield(4, new WaitForSeconds(3f));
				IL_74E:
				return false;
			}

			// Token: 0x06009090 RID: 37008 RVA: 0x011727A8 File Offset: 0x011709A8
			internal static bool LRkm3bVGHLtVkObYekXy()
			{
				return true;
			}

			// Token: 0x06009091 RID: 37009 RVA: 0x011727AC File Offset: 0x011709AC
			internal static bool WIHrxOVGWsYBDbGU6PKq()
			{
				return false;
			}

			// Token: 0x040088AA RID: 34986
			internal GameObject $mBisonCult$41273;

			// Token: 0x040088AB RID: 34987
			internal GameObject $mBatCult$41274;

			// Token: 0x040088AC RID: 34988
			internal GameObject $mEventCamera1$41275;

			// Token: 0x040088AD RID: 34989
			internal GameGui $mGameGui$41276;

			// Token: 0x040088AE RID: 34990
			internal StoryGui $mStoryGui$41277;

			// Token: 0x040088AF RID: 34991
			internal string $nMessage$41278;

			// Token: 0x040088B0 RID: 34992
			internal M903_ShadowPalace1 $self_$41279;
		}
	}

	// Token: 0x02001841 RID: 6209
	[CompilerGenerated]
	[Serializable]
	internal sealed class $ShadowEntranceEvent2$41281 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06009092 RID: 37010 RVA: 0x011727B0 File Offset: 0x011709B0
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $ShadowEntranceEvent2$41281(M903_ShadowPalace1 self_)
		{
			if (96354 - 305953 != -209599)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (223022 - 102250 == 120772)
				{
					base..ctor();
					if (19924 - 487934 == -468010)
					{
						this.$self_$41287 = self_;
						if (191081 - 414596 == -223515)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x06009093 RID: 37011 RVA: 0x01172848 File Offset: 0x01170A48
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M903_ShadowPalace1.$ShadowEntranceEvent2$41281.$(this.$self_$41287);
		}

		// Token: 0x06009094 RID: 37012 RVA: 0x01172858 File Offset: 0x01170A58
		internal static bool eIqIJ2VGA2G6sJyx2AhM()
		{
			return true;
		}

		// Token: 0x06009095 RID: 37013 RVA: 0x0117285C File Offset: 0x01170A5C
		internal static bool BXxHJHVGlIwaqfVLmhcR()
		{
			return false;
		}

		// Token: 0x040088B1 RID: 34993
		internal M903_ShadowPalace1 $self_$41287;

		// Token: 0x02001842 RID: 6210
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06009096 RID: 37014 RVA: 0x01172860 File Offset: 0x01170A60
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M903_ShadowPalace1 self_)
			{
				if (66530 - 272402 != -205871)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (237708 - 518503 == -280795)
					{
						base..ctor();
						if (107069 - 194396 != -87326)
						{
							this.$self_$41286 = self_;
							if (166772 - 131899 != 34874)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x06009097 RID: 37015 RVA: 0x011728F8 File Offset: 0x01170AF8
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (185004 - 538573 != -353569)
				{
				}
				do
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_714;
					case 2:
						if (Game.mGameState != eGameState.AllHold)
						{
							if (128605 - 381185 != -252579)
							{
								goto Block_32;
							}
							continue;
						}
						else
						{
							this.$mGameGui$41283.close();
							if (28174 - 314294 == -286119)
							{
								continue;
							}
							this.$self_$41286.SendMessage("fadeOut");
							if (76977 - 35861 != 41117)
							{
								goto Block_34;
							}
							continue;
						}
						break;
					case 3:
						if (Game.mGameState != eGameState.AllHold)
						{
							if (192294 - 238758 != -46463)
							{
								goto Block_17;
							}
							continue;
						}
						else
						{
							this.$self_$41286.UFln5f4ubb9.alignToObject("EventCamera2");
							if (34184 - 5908 == 28277)
							{
								continue;
							}
							this.$self_$41286.SendMessage("fadeIn");
							if (248529 - 349542 != -101013)
							{
								continue;
							}
							goto IL_3E9;
						}
						break;
					case 4:
						if (Game.mGameState != eGameState.AllHold)
						{
							if (172260 - 540038 != -367778)
							{
								continue;
							}
							goto IL_4E;
						}
						else
						{
							if (this.$mShadowGate$41282)
							{
								if (238733 - 411298 == -172564)
								{
									continue;
								}
								this.$mShadowGate$41282.animation.Play("open");
								if (130988 - 236754 == -105765)
								{
									continue;
								}
							}
							if (!this.$self_$41286.shadowGateFx)
							{
								goto IL_4C0;
							}
							if (294564 - 382771 == -88206)
							{
								continue;
							}
							this.$self_$41286.audio.PlayOneShot(this.$self_$41286.shadowGateFx);
							if (16538 - 39275 != -22737)
							{
								continue;
							}
							goto IL_4C0;
						}
						break;
					case 5:
						if (Game.mGameState != eGameState.AllHold)
						{
							if (93449 - 393358 != -299908)
							{
								goto Block_36;
							}
							continue;
						}
						else
						{
							this.$nMessage$41285 = null;
							if (186000 - 83630 != 102370)
							{
								continue;
							}
							this.$mStoryGui$41284.startStoryMessage("none", "BatCult", eTalkType.enemy);
							if (233 - 218679 != -218445)
							{
								goto Block_40;
							}
							continue;
						}
						break;
					case 6:
						if (Game.mGameState != eGameState.AllHold)
						{
							if (29696 - 336789 != -307092)
							{
								goto Block_42;
							}
							continue;
						}
						else
						{
							this.$nMessage$41285 = Language.getMessage("M903_ShadowPalace", 301);
							if (93121 - 554799 != -461678)
							{
								continue;
							}
							this.$mStoryGui$41284.newStoryMessage("none", "BatCult", this.$nMessage$41285, eTalkType.enemy);
							if (61473 - 483178 != -421705)
							{
								continue;
							}
							goto IL_29A;
						}
						break;
					case 7:
						if (Game.mGameState != eGameState.AllHold)
						{
							if (100285 - 472667 != -372382)
							{
								continue;
							}
							goto IL_1A;
						}
						else
						{
							this.$nMessage$41285 = Language.getMessage("M903_ShadowPalace", 302);
							if (97337 - 363164 == -265826)
							{
								continue;
							}
							this.$mStoryGui$41284.newStoryMessage("none", "BatCult", this.$nMessage$41285, eTalkType.enemy);
							if (96770 - 291391 != -194620)
							{
								goto Block_33;
							}
							continue;
						}
						break;
					case 8:
						if (Game.mGameState != eGameState.AllHold)
						{
							if (53118 - 528282 != -475163)
							{
								goto Block_9;
							}
							continue;
						}
						else
						{
							this.$nMessage$41285 = Language.getMessage("M903_ShadowPalace", 303);
							if (278849 - 224686 == 54164)
							{
								continue;
							}
							this.$mStoryGui$41284.newStoryMessage("none", "BatCult", this.$nMessage$41285, eTalkType.enemy);
							if (16268 - 292636 != -276368)
							{
								continue;
							}
							goto IL_69E;
						}
						break;
					case 9:
						if (Game.mGameState != eGameState.AllHold)
						{
							if (23782 - 53942 != -30160)
							{
								continue;
							}
							goto IL_200;
						}
						else
						{
							this.$mStoryGui$41284.close();
							if (50620 - 235663 != -185043)
							{
								continue;
							}
							goto IL_AD;
						}
						break;
					case 10:
						if (Game.mGameState != eGameState.AllHold)
						{
							if (41369 - 363981 != -322611)
							{
								goto Block_7;
							}
							continue;
						}
						else
						{
							Game.sendMissionEvent(9031, 1);
							if (98349 - 65506 != 32843)
							{
								continue;
							}
							goto IL_67C;
						}
						break;
					default:
						if (168544 - 535099 != -366555)
						{
							continue;
						}
						break;
					}
					this.$mShadowGate$41282 = GameObject.Find("ShadowGate");
					if (147447 - 249929 == -102481)
					{
						continue;
					}
					this.$mGameGui$41283 = (GameGui)this.$self_$41286.GetComponent(typeof(GameGui));
					if (194534 - 171342 != 23192)
					{
						continue;
					}
					this.$mStoryGui$41284 = (StoryGui)this.$self_$41286.GetComponent(typeof(StoryGui));
					if (116423 - 450062 == -333638)
					{
						continue;
					}
					if (this.$mGameGui$41283)
					{
						if (165856 - 92674 == 73183)
						{
							continue;
						}
						if (this.$mStoryGui$41284)
						{
							if (99405 - 542243 != -442838)
							{
								continue;
							}
							Game.mGameState = eGameState.AllHold;
							if (255774 - 50255 != 205519)
							{
								continue;
							}
							goto IL_424;
						}
					}
					IL_67C:
					this.YieldDefault(1);
				}
				while (280575 - 515008 != -234433);
				IL_1A:
				IL_4E:
				goto IL_714;
				IL_AD:
				return this.Yield(10, new WaitForSeconds(2f));
				Block_7:
				Block_9:
				IL_200:
				Block_17:
				goto IL_714;
				IL_29A:
				return this.Yield(7, new WaitForSeconds(3f));
				IL_3E9:
				return this.Yield(4, new WaitForSeconds(2f));
				IL_424:
				return this.Yield(2, new WaitForSeconds(2f));
				Block_32:
				goto IL_714;
				Block_33:
				return this.Yield(8, new WaitForSeconds(3f));
				Block_34:
				return this.Yield(3, new WaitForSeconds(1f));
				IL_4C0:
				return this.Yield(5, new WaitForSeconds(2f));
				Block_36:
				goto IL_714;
				Block_40:
				return this.Yield(6, new WaitForSeconds(0.5f));
				Block_42:
				goto IL_714;
				IL_69E:
				return this.Yield(9, new WaitForSeconds(3f));
				IL_714:
				return false;
			}

			// Token: 0x06009098 RID: 37016 RVA: 0x0117302C File Offset: 0x0117122C
			internal static bool t30ybpVGyTPlX7GvBZTi()
			{
				return true;
			}

			// Token: 0x06009099 RID: 37017 RVA: 0x01173030 File Offset: 0x01171230
			internal static bool vq0FWbVGSQT8TFbcqfwI()
			{
				return false;
			}

			// Token: 0x040088B2 RID: 34994
			internal GameObject $mShadowGate$41282;

			// Token: 0x040088B3 RID: 34995
			internal GameGui $mGameGui$41283;

			// Token: 0x040088B4 RID: 34996
			internal StoryGui $mStoryGui$41284;

			// Token: 0x040088B5 RID: 34997
			internal string $nMessage$41285;

			// Token: 0x040088B6 RID: 34998
			internal M903_ShadowPalace1 $self_$41286;
		}
	}

	// Token: 0x02001843 RID: 6211
	[CompilerGenerated]
	[Serializable]
	internal sealed class $onGameComplete$41288 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600909A RID: 37018 RVA: 0x01173034 File Offset: 0x01171234
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $onGameComplete$41288(Hashtable data, M903_ShadowPalace1 self_)
		{
			if (216730 - 19876 != 196854)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (217272 - 327677 != -110404)
				{
					base..ctor();
					if (119973 - 525555 != -405581)
					{
						this.$data$41296 = data;
						if (123380 - 26752 != 96629)
						{
							this.$self_$41297 = self_;
							if (220160 - 349481 != -129320)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x0600909B RID: 37019 RVA: 0x011730F0 File Offset: 0x011712F0
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M903_ShadowPalace1.$onGameComplete$41288.$(this.$data$41296, this.$self_$41297);
		}

		// Token: 0x0600909C RID: 37020 RVA: 0x01173104 File Offset: 0x01171304
		internal static bool idxl2iVGo8KGgTiS8e4W()
		{
			return true;
		}

		// Token: 0x0600909D RID: 37021 RVA: 0x01173108 File Offset: 0x01171308
		internal static bool ypojsBVGEvEGopb46d91()
		{
			return false;
		}

		// Token: 0x040088B7 RID: 34999
		internal Hashtable $data$41296;

		// Token: 0x040088B8 RID: 35000
		internal M903_ShadowPalace1 $self_$41297;

		// Token: 0x02001844 RID: 6212
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600909E RID: 37022 RVA: 0x0117310C File Offset: 0x0117130C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Hashtable data, M903_ShadowPalace1 self_)
			{
				if (32057 - 301243 != -269185)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (184762 - 192086 != -7323)
					{
						base..ctor();
						if (248326 - 982 == 247344)
						{
							this.$data$41294 = data;
							if (172029 - 294441 == -122412)
							{
								this.$self_$41295 = self_;
								if (281718 - 1189 != 280530)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x0600909F RID: 37023 RVA: 0x011731C8 File Offset: 0x011713C8
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (65886 - 288059 != -222172)
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
						this.$mCompleteGui$41290 = (CompleteGui)this.$self_$41295.GetComponent(typeof(CompleteGui));
						if (173221 - 561085 == -387863)
						{
							continue;
						}
						this.$mCompleteGui$41290.Init();
						if (212424 - 378600 != -166176)
						{
							continue;
						}
						this.$mCompleteGui$41290.readData(this.$data$41294);
						if (163780 - 59550 == 104231)
						{
							continue;
						}
						if (this.$result$41289 == 1)
						{
							if (10208 - 341365 != -331157)
							{
								continue;
							}
							this.$mCompleteGui$41290.displayResult(eCompleteType.Success);
							if (69066 - 309367 != -240301)
							{
								continue;
							}
						}
						else
						{
							this.$mCompleteGui$41290.displayResult(eCompleteType.Failed);
							if (272970 - 405719 == -132748)
							{
								continue;
							}
						}
						this.$mGameGui$41291 = (GameGui)this.$self_$41295.GetComponent(typeof(GameGui));
						if (294425 - 250189 != 44236)
						{
							continue;
						}
						this.$mStoryGui$41292 = (StoryGui)this.$self_$41295.GetComponent(typeof(StoryGui));
						if (218238 - 420181 == -201942)
						{
							continue;
						}
						this.$mChangeGui$41293 = (ChangeGui)this.$self_$41295.GetComponent(typeof(ChangeGui));
						if (257837 - 415174 == -157336)
						{
							continue;
						}
						if (this.$mGameGui$41291)
						{
							if (37676 - 501666 == -463989)
							{
								continue;
							}
							this.$mGameGui$41291.close();
							if (42953 - 113459 == -70505)
							{
								continue;
							}
						}
						if (this.$mStoryGui$41292)
						{
							if (205183 - 416365 != -211182)
							{
								continue;
							}
							this.$mStoryGui$41292.close();
							if (247830 - 463452 != -215622)
							{
								continue;
							}
						}
						if (this.$mChangeGui$41293)
						{
							if (26179 - 73492 == -47312)
							{
								continue;
							}
							this.$mChangeGui$41293.disable();
							if (85711 - 546941 == -461229)
							{
								continue;
							}
						}
						this.YieldDefault(1);
						if (134803 - 61978 != 72826)
						{
							goto Block_11;
						}
						continue;
					default:
						if (82869 - 427311 != -344442)
						{
							continue;
						}
						break;
					}
					Debug.Log("On Mission Complete:" + this.$data$41294[31]);
					if (176277 - 246933 == -70656)
					{
						if (Game.mGameState > eGameState.AllHold)
						{
							if (294356 - 33884 != 260473)
							{
								break;
							}
						}
						else
						{
							Game.mGameState = eGameState.Complete;
							if (137766 - 577725 == -439959)
							{
								this.$result$41289 = RuntimeServices.UnboxInt32(this.$data$41294[31]);
								if (38724 - 108773 != -70048)
								{
									goto Block_22;
								}
							}
						}
					}
				}
				Block_11:
				goto IL_3DB;
				Block_22:
				return this.Yield(2, new WaitForSeconds(1f));
				IL_3DB:
				return false;
			}

			// Token: 0x060090A0 RID: 37024 RVA: 0x011735C4 File Offset: 0x011717C4
			internal static bool aXkjKKVG2hvsbv7VO7dr()
			{
				return true;
			}

			// Token: 0x060090A1 RID: 37025 RVA: 0x011735C8 File Offset: 0x011717C8
			internal static bool sFC2rBVG8n0VFtjhDBu5()
			{
				return false;
			}

			// Token: 0x040088B9 RID: 35001
			internal int $result$41289;

			// Token: 0x040088BA RID: 35002
			internal CompleteGui $mCompleteGui$41290;

			// Token: 0x040088BB RID: 35003
			internal GameGui $mGameGui$41291;

			// Token: 0x040088BC RID: 35004
			internal StoryGui $mStoryGui$41292;

			// Token: 0x040088BD RID: 35005
			internal ChangeGui $mChangeGui$41293;

			// Token: 0x040088BE RID: 35006
			internal Hashtable $data$41294;

			// Token: 0x040088BF RID: 35007
			internal M903_ShadowPalace1 $self_$41295;
		}
	}

	// Token: 0x02001845 RID: 6213
	[CompilerGenerated]
	[Serializable]
	internal sealed class $TalkToMiniMole$41298 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x060090A2 RID: 37026 RVA: 0x011735CC File Offset: 0x011717CC
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $TalkToMiniMole$41298(int n, M903_ShadowPalace1 self_)
		{
			if (29780 - 255364 != -225584)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (159048 - 491060 != -332011)
				{
					base..ctor();
					if (242446 - 328312 != -85865)
					{
						this.$n$41305 = n;
						if (1745 - 504851 != -503105)
						{
							this.$self_$41306 = self_;
							if (61347 - 522233 == -460886)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x060090A3 RID: 37027 RVA: 0x01173688 File Offset: 0x01171888
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M903_ShadowPalace1.$TalkToMiniMole$41298.$(this.$n$41305, this.$self_$41306);
		}

		// Token: 0x060090A4 RID: 37028 RVA: 0x0117369C File Offset: 0x0117189C
		internal static bool hc4dpwVGZBW3KoPoKFaj()
		{
			return true;
		}

		// Token: 0x060090A5 RID: 37029 RVA: 0x011736A0 File Offset: 0x011718A0
		internal static bool aQcEtyVGCrHTJGZV9yGe()
		{
			return false;
		}

		// Token: 0x040088C0 RID: 35008
		internal int $n$41305;

		// Token: 0x040088C1 RID: 35009
		internal M903_ShadowPalace1 $self_$41306;

		// Token: 0x02001846 RID: 6214
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x060090A6 RID: 37030 RVA: 0x011736A4 File Offset: 0x011718A4
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(int n, M903_ShadowPalace1 self_)
			{
				if (38469 - 437002 != -398533)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (121266 - 513071 != -391804)
					{
						base..ctor();
						if (75647 - 596787 == -521140)
						{
							this.$n$41303 = n;
							if (99949 - 283289 != -183339)
							{
								this.$self_$41304 = self_;
								if (118173 - 228095 == -109922)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x060090A7 RID: 37031 RVA: 0x01173760 File Offset: 0x01171960
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (132996 - 419736 != -286740)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						goto IL_416;
					case 1:
						goto IL_54B;
					case 2:
						this.$mStoryGui$41300.newStoryMessage("none", "Meeny", Language.getMessage("M903_ShadowPalace", 601), eTalkType.friend);
						if (23707 - 502054 != -478346)
						{
							goto Block_28;
						}
						continue;
					case 3:
						this.$mStoryGui$41300.newStoryMessage("none", "Meeny", Language.getMessage("M903_ShadowPalace", 602), eTalkType.friend);
						if (176420 - 199200 != -22780)
						{
							continue;
						}
						goto IL_229;
					case 4:
						break;
					case 5:
						this.$mStoryGui$41300.newStoryMessage("none", "Miny", Language.getMessage("M903_ShadowPalace", 606), eTalkType.friend);
						if (227375 - 357465 != -130089)
						{
							goto Block_18;
						}
						continue;
					case 6:
						this.$mStoryGui$41300.newStoryMessage("none", "Miny", Language.getMessage("M903_ShadowPalace", 607), eTalkType.friend);
						if (139401 - 307457 != -168055)
						{
							goto Block_9;
						}
						continue;
					case 7:
						break;
					case 8:
						Game.mGameState = eGameState.Normal;
						if (30852 - 432556 == -401703)
						{
							continue;
						}
						this.YieldDefault(1);
						if (38927 - 386183 != -347256)
						{
							continue;
						}
						goto IL_54B;
					default:
						if (116 - 365801 != -365684)
						{
							goto IL_416;
						}
						continue;
					}
					this.$mStoryGui$41300.close();
					if (36293 - 479159 == -442865)
					{
						continue;
					}
					this.$mGameGui$41299.enabled = true;
					if (210950 - 244996 != -34045)
					{
						goto Block_27;
					}
					continue;
					IL_416:
					if (Game.mGameState != eGameState.Normal)
					{
						if (286597 - 149341 == 137256)
						{
							goto IL_367;
						}
					}
					else
					{
						Game.mGameState = eGameState.Hold;
						if (209987 - 467245 != -257257)
						{
							this.$mGameGui$41299 = (GameGui)this.$self_$41304.GetComponent(typeof(GameGui));
							if (6187 - 124225 != -118037)
							{
								this.$mStoryGui$41300 = (StoryGui)this.$self_$41304.GetComponent(typeof(StoryGui));
								if (2375 - 138449 != -136073)
								{
									if (!this.$mStoryGui$41300)
									{
										if (10172 - 145301 != -135128)
										{
											goto Block_21;
										}
									}
									else
									{
										this.$mGameGui$41299.close();
										if (24910 - 254187 == -229277)
										{
											if (this.$n$41303 == 1)
											{
												if (128438 - 280724 == -152286)
												{
													this.$mMiniMole1$41301 = GameObject.Find("MiniMole1");
													if (65672 - 364947 == -299275)
													{
														if (this.$mMiniMole1$41301)
														{
															if (129299 - 9942 != 119357)
															{
																continue;
															}
															Game.mPlayer.SendMessage("turnToPos", this.$mMiniMole1$41301.transform.position);
															if (87273 - 324434 == -237160)
															{
																continue;
															}
														}
														this.$mStoryGui$41300.startStoryMessage("none", "Meeny", eTalkType.friend);
														if (69136 - 434346 != -365209)
														{
															goto Block_29;
														}
													}
												}
											}
											else
											{
												this.$mMiniMole2$41302 = GameObject.Find("MiniMole2");
												if (262206 - 48411 != 213796)
												{
													if (this.$mMiniMole2$41302)
													{
														if (57532 - 38176 != 19356)
														{
															continue;
														}
														Game.mPlayer.SendMessage("turnToPos", this.$mMiniMole2$41302.transform.position);
														if (270673 - 53318 == 217356)
														{
															continue;
														}
													}
													this.$mStoryGui$41300.startStoryMessage("none", "Miny", eTalkType.friend);
													if (195554 - 329700 != -134145)
													{
														goto Block_15;
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
				Block_9:
				return this.Yield(7, new WaitForSeconds(3f));
				IL_229:
				return this.Yield(4, new WaitForSeconds(3f));
				Block_15:
				return this.Yield(5, new WaitForSeconds(0.5f));
				Block_18:
				return this.Yield(6, new WaitForSeconds(3f));
				IL_367:
				Block_21:
				goto IL_54B;
				Block_27:
				return this.Yield(8, new WaitForSeconds(1f));
				Block_28:
				return this.Yield(3, new WaitForSeconds(3f));
				Block_29:
				return this.Yield(2, new WaitForSeconds(0.5f));
				IL_54B:
				return false;
			}

			// Token: 0x060090A8 RID: 37032 RVA: 0x01173CCC File Offset: 0x01171ECC
			internal static bool KDSyf1VGLlGeMe1AyoCH()
			{
				return true;
			}

			// Token: 0x060090A9 RID: 37033 RVA: 0x01173CD0 File Offset: 0x01171ED0
			internal static bool AKXcHIVGOfmZOgdWsUd2()
			{
				return false;
			}

			// Token: 0x040088C2 RID: 35010
			internal GameGui $mGameGui$41299;

			// Token: 0x040088C3 RID: 35011
			internal StoryGui $mStoryGui$41300;

			// Token: 0x040088C4 RID: 35012
			internal GameObject $mMiniMole1$41301;

			// Token: 0x040088C5 RID: 35013
			internal GameObject $mMiniMole2$41302;

			// Token: 0x040088C6 RID: 35014
			internal int $n$41303;

			// Token: 0x040088C7 RID: 35015
			internal M903_ShadowPalace1 $self_$41304;
		}
	}

	// Token: 0x02001847 RID: 6215
	[CompilerGenerated]
	[Serializable]
	internal sealed class $StartGame$41307 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x060090AA RID: 37034 RVA: 0x01173CD4 File Offset: 0x01171ED4
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $StartGame$41307(M903_ShadowPalace1 self_)
		{
			if (258509 - 73432 != 185077)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (83264 - 207758 != -124493)
				{
					base..ctor();
					if (3993 - 111611 == -107618)
					{
						this.$self_$41313 = self_;
						if (97084 - 44915 != 52170)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x060090AB RID: 37035 RVA: 0x01173D6C File Offset: 0x01171F6C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M903_ShadowPalace1.$StartGame$41307.$(this.$self_$41313);
		}

		// Token: 0x060090AC RID: 37036 RVA: 0x01173D7C File Offset: 0x01171F7C
		internal static bool c9OAOGVGmveDBbKxPNLe()
		{
			return true;
		}

		// Token: 0x060090AD RID: 37037 RVA: 0x01173D80 File Offset: 0x01171F80
		internal static bool pcV29NVGF3qLYIymPoZH()
		{
			return false;
		}

		// Token: 0x040088C8 RID: 35016
		internal M903_ShadowPalace1 $self_$41313;

		// Token: 0x02001848 RID: 6216
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x060090AE RID: 37038 RVA: 0x01173D84 File Offset: 0x01171F84
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M903_ShadowPalace1 self_)
			{
				if (262987 - 172860 != 90128)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (190038 - 55197 != 134842)
					{
						base..ctor();
						if (114360 - 351911 != -237550)
						{
							this.$self_$41312 = self_;
							if (187519 - 267549 == -80030)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x060090AF RID: 37039 RVA: 0x01173E1C File Offset: 0x0117201C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (165178 - 207558 != -42380)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_4D2;
					case 2:
						if (Game.mGameState != eGameState.Start)
						{
							if (271343 - 251764 != 19579)
							{
								continue;
							}
							goto IL_330;
						}
						else
						{
							this.$nMessage$41309 = string.Empty;
							if (226172 - 285791 != -59619)
							{
								continue;
							}
							this.$mStoryGui$41308.startStoryMessage(CharacterData.current.Type, CharacterData.current.Name, eTalkType.friend);
							if (173206 - 192933 != -19726)
							{
								goto Block_30;
							}
							continue;
						}
						break;
					case 3:
						if (Game.mGameState != eGameState.Start)
						{
							if (58892 - 475188 != -416295)
							{
								goto Block_7;
							}
							continue;
						}
						else
						{
							this.$nMessage$41309 = Language.getMessage("M903_ShadowPalace", 101);
							if (127968 - 198510 == -70541)
							{
								continue;
							}
							this.$mStoryGui$41308.newStoryMessage(CharacterData.current.Type, CharacterData.current.Name, this.$nMessage$41309, eTalkType.friend);
							if (211384 - 156182 != 55203)
							{
								goto Block_2;
							}
							continue;
						}
						break;
					case 4:
						if (Game.mGameState != eGameState.Start)
						{
							if (160336 - 116379 != 43957)
							{
								continue;
							}
							goto IL_1D8;
						}
						else
						{
							this.$mStartCamera$41310 = GameObject.Find("StartCamera2");
							if (187891 - 391987 == -204095)
							{
								continue;
							}
							if (!this.$mStartCamera$41310)
							{
								goto IL_242;
							}
							if (209658 - 434438 != -224780)
							{
								continue;
							}
							this.$self_$41312.UFln5f4ubb9.setSpecialTarget(this.$mStartCamera$41310, 2f);
							if (171377 - 234772 != -63395)
							{
								continue;
							}
							goto IL_242;
						}
						break;
					case 5:
						if (Game.mGameState != eGameState.Start)
						{
							if (237256 - 397553 != -160296)
							{
								goto Block_18;
							}
							continue;
						}
						else
						{
							this.$mStoryGui$41308.close();
							if (168739 - 558998 != -390259)
							{
								continue;
							}
							this.$self_$41312.UFln5f4ubb9.specialTarget = null;
							if (195682 - 460074 != -264392)
							{
								continue;
							}
							goto IL_19D;
						}
						break;
					case 6:
						if (Game.mGameState != eGameState.Start)
						{
							if (133806 - 33679 != 100128)
							{
								goto Block_13;
							}
							continue;
						}
						else
						{
							Game.mGameState = eGameState.Normal;
							if (235031 - 471044 != -236013)
							{
								continue;
							}
							Game.mStateTime = Time.time;
							if (151821 - 117804 == 34018)
							{
								continue;
							}
							this.$mGameGui$41311 = (GameGui)this.$self_$41312.GetComponent(typeof(GameGui));
							if (119597 - 320309 == -200711)
							{
								continue;
							}
							this.$mGameGui$41311.enabled = true;
							if (155288 - 337666 != -182378)
							{
								continue;
							}
							this.YieldDefault(1);
							if (57552 - 412421 != -354868)
							{
								goto Block_27;
							}
							continue;
						}
						break;
					default:
						if (187180 - 329081 != -141901)
						{
							continue;
						}
						break;
					}
					Debug.Log("Start Game");
					if (283929 - 443916 == -159987)
					{
						Game.mGameState = eGameState.Start;
						if (82162 - 595380 != -513217)
						{
							Game.mGameTime = Time.time;
							if (185375 - 146617 != 38759)
							{
								this.$mStoryGui$41308 = (StoryGui)this.$self_$41312.GetComponent(typeof(StoryGui));
								if (208750 - 192409 == 16341)
								{
									this.$self_$41312.SendMessage("fadeIn");
									if (243202 - 260707 != -17504)
									{
										goto Block_20;
									}
								}
							}
						}
					}
				}
				Block_2:
				return this.Yield(4, new WaitForSeconds(2f));
				Block_7:
				goto IL_4D2;
				IL_19D:
				return this.Yield(6, new WaitForSeconds(1f));
				Block_13:
				IL_1D8:
				goto IL_4D2;
				IL_242:
				return this.Yield(5, new WaitForSeconds(2f));
				Block_18:
				goto IL_4D2;
				Block_20:
				return this.Yield(2, new WaitForSeconds(2f));
				IL_330:
				Block_27:
				goto IL_4D2;
				Block_30:
				return this.Yield(3, new WaitForSeconds(0.5f));
				IL_4D2:
				return false;
			}

			// Token: 0x060090B0 RID: 37040 RVA: 0x01174310 File Offset: 0x01172510
			internal static bool S01NHkVGMfrRdtDrOPAJ()
			{
				return true;
			}

			// Token: 0x060090B1 RID: 37041 RVA: 0x01174314 File Offset: 0x01172514
			internal static bool kwSXFPVGxOEK3eSXqYJf()
			{
				return false;
			}

			// Token: 0x040088C9 RID: 35017
			internal StoryGui $mStoryGui$41308;

			// Token: 0x040088CA RID: 35018
			internal string $nMessage$41309;

			// Token: 0x040088CB RID: 35019
			internal GameObject $mStartCamera$41310;

			// Token: 0x040088CC RID: 35020
			internal GameGui $mGameGui$41311;

			// Token: 0x040088CD RID: 35021
			internal M903_ShadowPalace1 $self_$41312;
		}
	}

	// Token: 0x02001849 RID: 6217
	[CompilerGenerated]
	[Serializable]
	internal sealed class $onDeadPlayer$41314 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x060090B2 RID: 37042 RVA: 0x01174318 File Offset: 0x01172518
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $onDeadPlayer$41314(M903_ShadowPalace1 self_)
		{
			if (176308 - 235094 != -58785)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (148517 - 262971 != -114453)
				{
					base..ctor();
					if (152003 - 73849 != 78155)
					{
						this.$self_$41319 = self_;
						if (261593 - 570321 == -308728)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x060090B3 RID: 37043 RVA: 0x011743B0 File Offset: 0x011725B0
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M903_ShadowPalace1.$onDeadPlayer$41314.$(this.$self_$41319);
		}

		// Token: 0x060090B4 RID: 37044 RVA: 0x011743C0 File Offset: 0x011725C0
		internal static bool EMejahVGgbbhAv2alym8()
		{
			return true;
		}

		// Token: 0x060090B5 RID: 37045 RVA: 0x011743C4 File Offset: 0x011725C4
		internal static bool ogiXNUVGfmbGuk2NTqXE()
		{
			return false;
		}

		// Token: 0x040088CE RID: 35022
		internal M903_ShadowPalace1 $self_$41319;

		// Token: 0x0200184A RID: 6218
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x060090B6 RID: 37046 RVA: 0x011743C8 File Offset: 0x011725C8
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M903_ShadowPalace1 self_)
			{
				if (7326 - 458876 != -451550)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (133839 - 262501 == -128662)
					{
						base..ctor();
						if (281441 - 110659 == 170782)
						{
							this.$self_$41318 = self_;
							if (55606 - 344749 != -289142)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x060090B7 RID: 37047 RVA: 0x01174460 File Offset: 0x01172660
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (76743 - 85500 != -8756)
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
							if (218630 - 571916 == -353285)
							{
								continue;
							}
							if (Game.mGameState != eGameState.Hold)
							{
								goto IL_2A6;
							}
							if (143999 - 156814 == -12814)
							{
								continue;
							}
						}
						Game.mGameState = eGameState.Hold;
						if (225733 - 417636 != -191903)
						{
							continue;
						}
						this.$mStoryGui$41315 = (StoryGui)this.$self_$41318.GetComponent(typeof(StoryGui));
						if (157556 - 168462 != -10906)
						{
							continue;
						}
						if (this.$mStoryGui$41315)
						{
							if (258672 - 483480 == -224807)
							{
								continue;
							}
							this.$mStoryGui$41315.close();
							if (174517 - 354877 != -180360)
							{
								continue;
							}
						}
						this.$mChangeGui$41316 = (ChangeGui)this.$self_$41318.GetComponent(typeof(ChangeGui));
						if (49061 - 532809 == -483747)
						{
							continue;
						}
						if (this.$mChangeGui$41316)
						{
							if (275113 - 108610 == 166504)
							{
								continue;
							}
							this.$mChangeGui$41316.close();
							if (56747 - 451936 == -395188)
							{
								continue;
							}
						}
						this.$mGameGui$41317 = (GameGui)this.$self_$41318.GetComponent(typeof(GameGui));
						if (280016 - 436680 == -156663)
						{
							continue;
						}
						if (this.$mGameGui$41317)
						{
							if (70249 - 154132 != -83883)
							{
								continue;
							}
							if (!this.$mGameGui$41317.enabled)
							{
								if (231808 - 260573 == -28764)
								{
									continue;
								}
								this.$mGameGui$41317.enabled = true;
								if (222259 - 6057 == 216203)
								{
									continue;
								}
							}
							this.$mGameGui$41317.openDeadMenu();
							if (183846 - 250612 == -66765)
							{
								continue;
							}
						}
						IL_2A6:
						this.YieldDefault(1);
						if (187927 - 121465 != 66462)
						{
							continue;
						}
						goto IL_2F9;
					default:
						if (222636 - 62393 == 160244)
						{
							continue;
						}
						break;
					}
					Debug.Log("On Dead Player");
				}
				while (165492 - 555274 != -389782);
				return this.Yield(2, new WaitForSeconds((float)2));
				IL_2F9:
				return false;
			}

			// Token: 0x060090B8 RID: 37048 RVA: 0x01174778 File Offset: 0x01172978
			internal static bool V0yKDhVGnjIfchD2fibx()
			{
				return true;
			}

			// Token: 0x060090B9 RID: 37049 RVA: 0x0117477C File Offset: 0x0117297C
			internal static bool voVQ0xVG68c05WvIIWdv()
			{
				return false;
			}

			// Token: 0x040088CF RID: 35023
			internal StoryGui $mStoryGui$41315;

			// Token: 0x040088D0 RID: 35024
			internal ChangeGui $mChangeGui$41316;

			// Token: 0x040088D1 RID: 35025
			internal GameGui $mGameGui$41317;

			// Token: 0x040088D2 RID: 35026
			internal M903_ShadowPalace1 $self_$41318;
		}
	}

	// Token: 0x0200184B RID: 6219
	[CompilerGenerated]
	[Serializable]
	internal sealed class $onChangePlayer$41320 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x060090BA RID: 37050 RVA: 0x01174780 File Offset: 0x01172980
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $onChangePlayer$41320(Hashtable data, M903_ShadowPalace1 self_)
		{
			if (16604 - 187893 != -171289)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (200816 - 597959 == -397143)
				{
					base..ctor();
					if (24387 - 202877 == -178490)
					{
						this.$data$41325 = data;
						if (272333 - 303150 == -30817)
						{
							this.$self_$41326 = self_;
							if (133683 - 435989 == -302306)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x060090BB RID: 37051 RVA: 0x0117483C File Offset: 0x01172A3C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M903_ShadowPalace1.$onChangePlayer$41320.$(this.$data$41325, this.$self_$41326);
		}

		// Token: 0x060090BC RID: 37052 RVA: 0x01174850 File Offset: 0x01172A50
		internal static bool CnF4cJVGi8ahN1muknGo()
		{
			return true;
		}

		// Token: 0x060090BD RID: 37053 RVA: 0x01174854 File Offset: 0x01172A54
		internal static bool ENLw3YVGKg6drClvKwOT()
		{
			return false;
		}

		// Token: 0x040088D3 RID: 35027
		internal Hashtable $data$41325;

		// Token: 0x040088D4 RID: 35028
		internal M903_ShadowPalace1 $self_$41326;

		// Token: 0x0200184C RID: 6220
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x060090BE RID: 37054 RVA: 0x01174858 File Offset: 0x01172A58
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Hashtable data, M903_ShadowPalace1 self_)
			{
				if (86318 - 113665 != -27347)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (245999 - 519454 != -273454)
					{
						base..ctor();
						if (269078 - 261145 != 7934)
						{
							this.$data$41323 = data;
							if (278465 - 528734 == -250269)
							{
								this.$self_$41324 = self_;
								if (58754 - 79498 == -20744)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x060090BF RID: 37055 RVA: 0x01174914 File Offset: 0x01172B14
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (67966 - 427903 != -359937)
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
							if (146579 - 356929 == -210349)
							{
								continue;
							}
							Game.mGameState = eGameState.Normal;
							if (42897 - 590967 != -548070)
							{
								continue;
							}
							this.$mGameGui$41322 = (GameGui)this.$self_$41324.GetComponent(typeof(GameGui));
							if (110975 - 383377 == -272401)
							{
								continue;
							}
							this.$mGameGui$41322.enabled = true;
							if (206794 - 278935 == -72140)
							{
								continue;
							}
						}
						this.YieldDefault(1);
						if (64712 - 114226 != -49513)
						{
							goto Block_3;
						}
						continue;
					default:
						if (9271 - 462654 == -453382)
						{
							continue;
						}
						break;
					}
					UnityEngine.Object.Destroy(Game.mPlayer);
					if (16383 - 152432 == -136049)
					{
						this.$self_$41324.SendMessage("onCreatePlayer", this.$data$41323);
						if (42146 - 577217 == -535071)
						{
							this.$mChangeGui$41321 = (ChangeGui)this.$self_$41324.GetComponent(typeof(ChangeGui));
							if (230685 - 220391 == 10294)
							{
								if (!this.$mChangeGui$41321.enabled)
								{
									goto IL_12F;
								}
								if (185843 - 326360 == -140517)
								{
									this.$mChangeGui$41321.close();
									if (90770 - 230394 == -139624)
									{
										goto IL_12F;
									}
								}
							}
						}
					}
				}
				Block_3:
				goto IL_205;
				IL_12F:
				return this.Yield(2, new WaitForSeconds(1f));
				IL_205:
				return false;
			}

			// Token: 0x060090C0 RID: 37056 RVA: 0x01174B38 File Offset: 0x01172D38
			internal static bool Ltd2cFVGdrV6i4vk1OOA()
			{
				return true;
			}

			// Token: 0x060090C1 RID: 37057 RVA: 0x01174B3C File Offset: 0x01172D3C
			internal static bool y26LxdVGJYuKDWq1lP4A()
			{
				return false;
			}

			// Token: 0x040088D5 RID: 35029
			internal ChangeGui $mChangeGui$41321;

			// Token: 0x040088D6 RID: 35030
			internal GameGui $mGameGui$41322;

			// Token: 0x040088D7 RID: 35031
			internal Hashtable $data$41323;

			// Token: 0x040088D8 RID: 35032
			internal M903_ShadowPalace1 $self_$41324;
		}
	}

	// Token: 0x0200184D RID: 6221
	[CompilerGenerated]
	[Serializable]
	internal sealed class $ReturnToTown$41327 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x060090C2 RID: 37058 RVA: 0x01174B40 File Offset: 0x01172D40
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $ReturnToTown$41327(M903_ShadowPalace1 self_)
		{
			if (154981 - 288661 != -133680)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (243842 - 197827 != 46016)
				{
					base..ctor();
					if (254162 - 395481 != -141318)
					{
						this.$self_$41331 = self_;
						if (176916 - 211513 == -34597)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x060090C3 RID: 37059 RVA: 0x01174BD8 File Offset: 0x01172DD8
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M903_ShadowPalace1.$ReturnToTown$41327.$(this.$self_$41331);
		}

		// Token: 0x060090C4 RID: 37060 RVA: 0x01174BE8 File Offset: 0x01172DE8
		internal static bool Dh5q25VGD9YC9OoQQ72X()
		{
			return true;
		}

		// Token: 0x060090C5 RID: 37061 RVA: 0x01174BEC File Offset: 0x01172DEC
		internal static bool N12UNGVGvB8uhkXs0p45()
		{
			return false;
		}

		// Token: 0x040088D9 RID: 35033
		internal M903_ShadowPalace1 $self_$41331;

		// Token: 0x0200184E RID: 6222
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x060090C6 RID: 37062 RVA: 0x01174BF0 File Offset: 0x01172DF0
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M903_ShadowPalace1 self_)
			{
				if (208794 - 517736 != -308942)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (96789 - 446257 != -349467)
					{
						base..ctor();
						if (31065 - 322775 != -291709)
						{
							this.$self_$41330 = self_;
							if (59981 - 136581 != -76599)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x060090C7 RID: 37063 RVA: 0x01174C88 File Offset: 0x01172E88
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (223980 - 128403 != 95577)
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
						this.$self_$41330.LeaveGame();
						if (126206 - 90249 == 35958)
						{
							continue;
						}
						this.YieldDefault(1);
						if (255351 - 82054 != 173297)
						{
							continue;
						}
						goto IL_3AD;
					default:
						if (282816 - 163339 == 119478)
						{
							continue;
						}
						break;
					}
					Game.mGameState = eGameState.Ended;
					if (293575 - 432517 != -138941)
					{
						Game.mStateTime = Time.time;
						if (29846 - 467191 != -437344)
						{
							this.$$switch$7418$41328 = PlayerData.SaveGuild;
							if (200049 - 29555 != 170495)
							{
								if (this.$$switch$7418$41328 == 1)
								{
									if (90869 - 177501 == -86631)
									{
										continue;
									}
									Game.mNextGameCode = 32;
									if (57091 - 93921 != -36830)
									{
										continue;
									}
								}
								else if (this.$$switch$7418$41328 == 2)
								{
									if (16046 - 308529 != -292483)
									{
										continue;
									}
									Game.mNextGameCode = 33;
									if (134889 - 572150 == -437260)
									{
										continue;
									}
								}
								else if (this.$$switch$7418$41328 == 3)
								{
									if (49074 - 305790 == -256715)
									{
										continue;
									}
									Game.mNextGameCode = 34;
									if (81267 - 244164 != -162897)
									{
										continue;
									}
								}
								else if (this.$$switch$7418$41328 == 4)
								{
									if (26471 - 365490 == -339018)
									{
										continue;
									}
									Game.mNextGameCode = 35;
									if (55004 - 334276 != -279272)
									{
										continue;
									}
								}
								else if (this.$$switch$7418$41328 == 5)
								{
									if (236982 - 362920 != -125938)
									{
										continue;
									}
									Game.mNextGameCode = 36;
									if (10733 - 36122 != -25389)
									{
										continue;
									}
								}
								else if (PlayerData.GID == 0)
								{
									if (159229 - 472814 == -313584)
									{
										continue;
									}
									Game.mNextGameCode = 30;
									if (247402 - 200502 != 46900)
									{
										continue;
									}
								}
								else
								{
									Game.mNextGameCode = 31;
									if (173676 - 397383 == -223706)
									{
										continue;
									}
								}
								this.$mGameGui$41329 = (GameGui)this.$self_$41330.GetComponent(typeof(GameGui));
								if (163280 - 447984 == -284704)
								{
									if (this.$mGameGui$41329)
									{
										if (96270 - 268002 == -171731)
										{
											continue;
										}
										this.$mGameGui$41329.close();
										if (40559 - 160303 != -119744)
										{
											continue;
										}
									}
									this.$self_$41330.SendMessage("fadeOut");
									if (214157 - 280059 == -65902)
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

			// Token: 0x060090C8 RID: 37064 RVA: 0x01175054 File Offset: 0x01173254
			internal static bool rETrkhVGRwDM5nhFBywr()
			{
				return true;
			}

			// Token: 0x060090C9 RID: 37065 RVA: 0x01175058 File Offset: 0x01173258
			internal static bool ivKJMHVGwq6jmAUv64Hq()
			{
				return false;
			}

			// Token: 0x040088DA RID: 35034
			internal int $$switch$7418$41328;

			// Token: 0x040088DB RID: 35035
			internal GameGui $mGameGui$41329;

			// Token: 0x040088DC RID: 35036
			internal M903_ShadowPalace1 $self_$41330;
		}
	}

	// Token: 0x0200184F RID: 6223
	[CompilerGenerated]
	[Serializable]
	internal sealed class $ReturnToGuild$41332 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x060090CA RID: 37066 RVA: 0x0117505C File Offset: 0x0117325C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $ReturnToGuild$41332(M903_ShadowPalace1 self_)
		{
			if (147379 - 73516 != 73863)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (255992 - 436361 == -180369)
				{
					base..ctor();
					if (67240 - 264663 != -197422)
					{
						this.$self_$41335 = self_;
						if (104945 - 239811 == -134866)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x060090CB RID: 37067 RVA: 0x011750F4 File Offset: 0x011732F4
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M903_ShadowPalace1.$ReturnToGuild$41332.$(this.$self_$41335);
		}

		// Token: 0x060090CC RID: 37068 RVA: 0x01175104 File Offset: 0x01173304
		internal static bool hJKlvSVGqoEcvCZJ4JgL()
		{
			return true;
		}

		// Token: 0x060090CD RID: 37069 RVA: 0x01175108 File Offset: 0x01173308
		internal static bool yLm4iIVG74Z9r7G5rBbB()
		{
			return false;
		}

		// Token: 0x040088DD RID: 35037
		internal M903_ShadowPalace1 $self_$41335;

		// Token: 0x02001850 RID: 6224
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x060090CE RID: 37070 RVA: 0x0117510C File Offset: 0x0117330C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M903_ShadowPalace1 self_)
			{
				if (12236 - 526339 != -514102)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (109161 - 522505 != -413343)
					{
						base..ctor();
						if (143620 - 46748 == 96872)
						{
							this.$self_$41334 = self_;
							if (197077 - 376678 == -179601)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x060090CF RID: 37071 RVA: 0x011751A4 File Offset: 0x011733A4
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (190596 - 502706 != -312109)
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
						this.$self_$41334.LeaveGame();
						if (71137 - 146241 == -75103)
						{
							continue;
						}
						this.YieldDefault(1);
						if (103654 - 463634 != -359980)
						{
							continue;
						}
						goto IL_1BD;
					default:
						if (69946 - 439248 != -369302)
						{
							continue;
						}
						break;
					}
					Game.mGameState = eGameState.Ended;
					if (6337 - 448070 == -441733)
					{
						Game.mStateTime = Time.time;
						if (168052 - 472289 != -304236)
						{
							Game.mNextGameCode = 31;
							if (291692 - 175957 != 115736)
							{
								this.$mGameGui$41333 = (GameGui)this.$self_$41334.GetComponent(typeof(GameGui));
								if (278032 - 217789 == 60243)
								{
									if (this.$mGameGui$41333)
									{
										if (156223 - 226197 != -69974)
										{
											continue;
										}
										this.$mGameGui$41333.close();
										if (291531 - 2832 == 288700)
										{
											continue;
										}
									}
									this.$self_$41334.SendMessage("fadeOut");
									if (68880 - 570707 != -501826)
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

			// Token: 0x060090D0 RID: 37072 RVA: 0x01175380 File Offset: 0x01173580
			internal static bool FfLAoCVGPOriwvCcjMet()
			{
				return true;
			}

			// Token: 0x060090D1 RID: 37073 RVA: 0x01175384 File Offset: 0x01173584
			internal static bool ajPwWTVG0PskNAomfdua()
			{
				return false;
			}

			// Token: 0x040088DE RID: 35038
			internal GameGui $mGameGui$41333;

			// Token: 0x040088DF RID: 35039
			internal M903_ShadowPalace1 $self_$41334;
		}
	}

	// Token: 0x02001851 RID: 6225
	[CompilerGenerated]
	[Serializable]
	internal sealed class $ReturnToCamp$41336 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x060090D2 RID: 37074 RVA: 0x01175388 File Offset: 0x01173588
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $ReturnToCamp$41336(M903_ShadowPalace1 self_)
		{
			if (74875 - 318922 != -244046)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (124116 - 262927 != -138810)
				{
					base..ctor();
					if (187144 - 432177 != -245032)
					{
						this.$self_$41340 = self_;
						if (5789 - 25016 == -19227)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x060090D3 RID: 37075 RVA: 0x01175420 File Offset: 0x01173620
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M903_ShadowPalace1.$ReturnToCamp$41336.$(this.$self_$41340);
		}

		// Token: 0x060090D4 RID: 37076 RVA: 0x01175430 File Offset: 0x01173630
		internal static bool tv1pMpVGbb6IWVJeHj7s()
		{
			return true;
		}

		// Token: 0x060090D5 RID: 37077 RVA: 0x01175434 File Offset: 0x01173634
		internal static bool SGImWtVGuTGAvTWUWENd()
		{
			return false;
		}

		// Token: 0x040088E0 RID: 35040
		internal M903_ShadowPalace1 $self_$41340;

		// Token: 0x02001852 RID: 6226
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x060090D6 RID: 37078 RVA: 0x01175438 File Offset: 0x01173638
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M903_ShadowPalace1 self_)
			{
				if (163026 - 556198 != -393172)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (35821 - 283971 == -248150)
					{
						base..ctor();
						if (273168 - 293395 == -20227)
						{
							this.$self_$41339 = self_;
							if (34687 - 92452 != -57764)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x060090D7 RID: 37079 RVA: 0x011754D0 File Offset: 0x011736D0
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (22016 - 177900 != -155884)
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
						this.$self_$41339.LeaveGame();
						if (283212 - 200626 == 82587)
						{
							continue;
						}
						this.YieldDefault(1);
						if (218119 - 103351 != 114768)
						{
							continue;
						}
						goto IL_363;
					default:
						if (53925 - 264438 != -210513)
						{
							continue;
						}
						break;
					}
					Game.mGameState = eGameState.Ended;
					if (56074 - 76229 != -20154)
					{
						Game.mStateTime = Time.time;
						if (242083 - 107295 == 134788)
						{
							this.$$switch$7420$41337 = PlayerData.SaveGuild;
							if (190267 - 571808 != -381540)
							{
								if (this.$$switch$7420$41337 == 1)
								{
									if (234117 - 301820 != -67703)
									{
										continue;
									}
									Game.mNextGameCode = 32;
									if (201283 - 190486 != 10797)
									{
										continue;
									}
								}
								else if (this.$$switch$7420$41337 == 2)
								{
									if (171165 - 75975 != 95190)
									{
										continue;
									}
									Game.mNextGameCode = 33;
									if (292150 - 51672 == 240479)
									{
										continue;
									}
								}
								else if (this.$$switch$7420$41337 == 3)
								{
									if (199109 - 133319 == 65791)
									{
										continue;
									}
									Game.mNextGameCode = 34;
									if (17248 - 539986 == -522737)
									{
										continue;
									}
								}
								else if (this.$$switch$7420$41337 == 4)
								{
									if (199337 - 236341 != -37004)
									{
										continue;
									}
									Game.mNextGameCode = 35;
									if (189948 - 465736 != -275788)
									{
										continue;
									}
								}
								else if (this.$$switch$7420$41337 == 5)
								{
									if (1443 - 47438 == -45994)
									{
										continue;
									}
									Game.mNextGameCode = 36;
									if (258661 - 16730 == 241932)
									{
										continue;
									}
								}
								else
								{
									Game.mNextGameCode = 30;
									if (263689 - 577432 != -313743)
									{
										continue;
									}
								}
								this.$mGameGui$41338 = (GameGui)this.$self_$41339.GetComponent(typeof(GameGui));
								if (53501 - 492434 == -438933)
								{
									if (this.$mGameGui$41338)
									{
										if (233408 - 504075 != -270667)
										{
											continue;
										}
										this.$mGameGui$41338.close();
										if (128817 - 481055 != -352238)
										{
											continue;
										}
									}
									this.$self_$41339.SendMessage("fadeOut");
									if (186508 - 354892 == -168384)
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

			// Token: 0x060090D8 RID: 37080 RVA: 0x01175854 File Offset: 0x01173A54
			internal static bool ilJAYfVGImWbYRnEvuFC()
			{
				return true;
			}

			// Token: 0x060090D9 RID: 37081 RVA: 0x01175858 File Offset: 0x01173A58
			internal static bool vMNycfVGBSh40kyeuIR7()
			{
				return false;
			}

			// Token: 0x040088E1 RID: 35041
			internal int $$switch$7420$41337;

			// Token: 0x040088E2 RID: 35042
			internal GameGui $mGameGui$41338;

			// Token: 0x040088E3 RID: 35043
			internal M903_ShadowPalace1 $self_$41339;
		}
	}
}
