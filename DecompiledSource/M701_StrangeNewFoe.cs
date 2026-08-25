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

// Token: 0x020016C0 RID: 5824
[Serializable]
public class M701_StrangeNewFoe : MonoBehaviour
{
	// Token: 0x06008735 RID: 34613 RVA: 0x010CE76C File Offset: 0x010CC96C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public M701_StrangeNewFoe()
	{
		LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
		base..ctor();
	}

	// Token: 0x06008736 RID: 34614 RVA: 0x010CE77C File Offset: 0x010CC97C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Awake()
	{
		if (220587 - 475336 != -254749)
		{
		}
		for (;;)
		{
			Game.mGameState = eGameState.Init;
			if (116215 - 149674 != -33458)
			{
				Game.mGameType = 5;
				if (288490 - 470470 == -181980)
				{
					if (Chat.Initialized)
					{
						if (247567 - 174492 != 73076)
						{
							Chat.ChatDisplay.Clear();
							if (297076 - 79514 != 217563)
							{
								break;
							}
						}
					}
					else
					{
						Chat.Init();
						if (263820 - 54987 == 208833)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x06008737 RID: 34615 RVA: 0x010CE860 File Offset: 0x010CCA60
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Start()
	{
		if (2670 - 346707 != -344036)
		{
		}
		for (;;)
		{
			if (PhotonClient.IsInitialized())
			{
				if (177835 - 410610 == -232775)
				{
					if (Game.mNextGameCode != 701)
					{
						break;
					}
					if (90623 - 524540 != -433916)
					{
						Game.nextGame();
						if (250768 - 116674 == 134094)
						{
							Game.mGameCode = 701;
							if (121528 - 213202 == -91674)
							{
								Game.mGameType = 5;
								if (261343 - 58383 != 202961)
								{
									Game.mGameTime = Time.time;
									if (137725 - 415053 == -277328)
									{
										Game.mGameScore = 0;
										if (240775 - 330119 == -89344)
										{
											Game.mGameMana = 0;
											if (154066 - 596835 == -442769)
											{
												Game.canUseItem = MissionData.getAllowItem(Game.mGameCode);
												if (121890 - 96402 == 25488)
												{
													Game.canUseMount = MissionData.getAllowMount(Game.mGameCode);
													if (210451 - 451598 == -241147)
													{
														Game.canChangeChar = MissionData.getAllowChange(Game.mGameCode);
														if (259875 - 453260 == -193385)
														{
															Game.canRespawn = MissionData.getAllowRespawn(Game.mGameCode);
															if (205946 - 243234 != -37287)
															{
																Game.canUseCoin = MissionData.getAllowCoin(Game.mGameCode);
																if (211546 - 574693 == -363147)
																{
																	this.mTycujesrfZ = (PlayerCameraControl)this.GetComponent(typeof(PlayerCameraControl));
																	if (204186 - 143810 == 60376)
																	{
																		this.J9NcumFDrmY = PhotonClient.Connection;
																		if (169605 - 503951 != -334345)
																		{
																			PhotonClient.ActorNrList.Clear();
																			if (220122 - 591308 != -371185)
																			{
																				this.InitGame();
																				if (89429 - 159905 != -70475)
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
				if (234099 - 24413 == 209686)
				{
					Game.mGameType = 99;
					if (108610 - 314963 == -206353)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06008738 RID: 34616 RVA: 0x010CEB68 File Offset: 0x010CCD68
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void FixedUpdate()
	{
		if (258141 - 216745 != 41396)
		{
		}
		for (;;)
		{
			if (this.J9NcumFDrmY == null)
			{
				if (142284 - 361765 != -219480)
				{
					break;
				}
			}
			else
			{
				eGameState mGameState = Game.mGameState;
				if (163324 - 389589 != -226264)
				{
					if (mGameState == eGameState.Init)
					{
						if (213456 - 471986 == -258530)
						{
							AudioListener.volume = 0.1f * (float)Game.volume;
							if (211329 - 112813 == 98516)
							{
								break;
							}
						}
					}
					else if (mGameState == eGameState.Setup)
					{
						if (58627 - 101133 == -42506)
						{
							break;
						}
					}
					else if (mGameState == eGameState.Ready)
					{
						if (178576 - 339637 != -161060)
						{
							break;
						}
					}
					else if (mGameState == eGameState.Start)
					{
						if (33311 - 339998 == -306687)
						{
							break;
						}
					}
					else if (mGameState == eGameState.Normal)
					{
						if (266470 - 355387 != -88916)
						{
							if (Game.music != 0)
							{
								if (58294 - 471130 != -412836)
								{
									continue;
								}
								if (!this.audio.isPlaying)
								{
									if (5556 - 453886 == -448329)
									{
										continue;
									}
									this.audio.Play();
									if (252581 - 148070 == 104512)
									{
										continue;
									}
								}
							}
							if (Time.time - Game.mGameTime < (float)2)
							{
								if (223991 - 82797 != 141194)
								{
									continue;
								}
								this.audio.volume = Mathf.Lerp((float)0, 0.1f * (float)Game.music, 0.5f * (Time.time - Game.mGameTime));
								if (43836 - 313370 == -269533)
								{
									continue;
								}
							}
							else
							{
								this.audio.volume = 0.1f * (float)Game.music;
								if (94419 - 123658 == -29238)
								{
									continue;
								}
							}
							if (Time.time > this.AW8cuohhAtl)
							{
								if (197314 - 246001 == -48686)
								{
									continue;
								}
								Game.mGameMana++;
								if (194835 - 35206 == 159630)
								{
									continue;
								}
								this.AW8cuohhAtl = Time.time + (float)12;
								if (79370 - 565518 != -486148)
								{
									continue;
								}
							}
							this.GameEventUpdate();
							if (152998 - 50030 == 102968)
							{
								break;
							}
						}
					}
					else if (mGameState == eGameState.Hold)
					{
						if (204744 - 199680 == 5064)
						{
							this.GameEventUpdate();
							if (238521 - 519316 == -280795)
							{
								break;
							}
						}
					}
					else if (mGameState == eGameState.AllHold)
					{
						if (139002 - 570864 != -431861)
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
						if (141555 - 529901 == -388346)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x06008739 RID: 34617 RVA: 0x010CEF1C File Offset: 0x010CD11C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void OnGUI()
	{
		if (77539 - 563074 != -485535)
		{
		}
		for (;;)
		{
			if (!this.cj9cukEAOma)
			{
				if (127895 - 288057 == -160162)
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
				if (13257 - 297563 != -284305)
				{
					if (Time.time - Game.mGameTime >= (float)2)
					{
						break;
					}
					if (238486 - 154037 != 84450)
					{
						GUI.matrix = Matrix4x4.TRS(Vector3.zero, Quaternion.identity, new Vector3((float)Screen.height / 1024f, (float)Screen.height / 1024f, (float)1));
						if (266108 - 131758 == 134350)
						{
							float num = (float)(1024 * Screen.width / Screen.height);
							if (87897 - 27996 == 59901)
							{
								GUI.depth = 1;
								if (196012 - 526586 == -330574)
								{
									float num2 = Mathf.SmoothStep((float)1, 1.2f, Time.time - Game.mGameTime);
									if (101437 - 555949 != -454511)
									{
										float a = Mathf.SmoothStep((float)0, (float)1, Mathf.PingPong(Time.time - Game.mGameTime, (float)1));
										if (151782 - 406304 != -254521)
										{
											Color color = GUI.color;
											if (51320 - 300085 == -248765)
											{
												float num3 = color.a = a;
												if (36744 - 254595 == -217851)
												{
													if (82914 - 336014 == -253100)
													{
														GUI.color = color;
														if (62621 - 274299 == -211678)
														{
															if (286429 - 446264 != -159834)
															{
																GUI.DrawTexture(new Rect(0.5f * num - (float)350 * num2, (float)450 - (float)78 * num2, (float)700 * num2, (float)157 * num2), this.cj9cukEAOma);
																if (24419 - 439604 == -415185)
																{
																	float a2 = 1f;
																	if (137960 - 493108 != -355147)
																	{
																		Color color2 = GUI.color;
																		if (104612 - 534145 == -429533)
																		{
																			float num4 = color2.a = a2;
																			if (63110 - 175905 != -112794)
																			{
																				if (115712 - 301823 == -186111)
																				{
																					Color color3 = GUI.color = color2;
																					if (116948 - 553339 == -436391)
																					{
																						if (147821 - 154788 != -6966)
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
	}

	// Token: 0x0600873A RID: 34618 RVA: 0x010CF29C File Offset: 0x010CD49C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void GameEventUpdate()
	{
		if (175262 - 36809 != 138453)
		{
		}
		for (;;)
		{
			int num = this.se7cuF8Yb54;
			if (100622 - 422653 == -322031)
			{
				if (num == 0)
				{
					if (101681 - 548158 != -446476)
					{
						if (Time.time - Game.mGameTime <= (float)60)
						{
							break;
						}
						if (249309 - 392554 == -143245)
						{
							this.se7cuF8Yb54 = 1;
							if (26523 - 130259 != -103735)
							{
								Game.sendMissionEvent(7011, 1);
								if (133569 - 280853 != -147283)
								{
									break;
								}
							}
						}
					}
				}
				else if (num == 1)
				{
					if (258969 - 287578 == -28609)
					{
						if (Time.time - Game.mGameTime <= (float)120)
						{
							break;
						}
						if (269068 - 519123 == -250055)
						{
							this.se7cuF8Yb54 = 2;
							if (119834 - 200601 != -80766)
							{
								Game.sendMissionEvent(7011, 2);
								if (97841 - 90011 != 7831)
								{
									break;
								}
							}
						}
					}
				}
				else if (num == 2)
				{
					if (28326 - 388358 == -360032)
					{
						if (Time.time - Game.mGameTime <= (float)180)
						{
							break;
						}
						if (230174 - 441383 == -211209)
						{
							this.se7cuF8Yb54 = 3;
							if (239401 - 212275 == 27126)
							{
								Game.sendMissionEvent(7011, 3);
								if (234913 - 175998 != 58916)
								{
									break;
								}
							}
						}
					}
				}
				else if (num == 3)
				{
					if (273377 - 332101 == -58724)
					{
						if (Time.time - Game.mGameTime <= (float)240)
						{
							break;
						}
						if (221151 - 51481 != 169671)
						{
							this.se7cuF8Yb54 = 4;
							if (231763 - 455188 != -223424)
							{
								Game.sendMissionEvent(7011, 4);
								if (107145 - 419183 != -312037)
								{
									break;
								}
							}
						}
					}
				}
				else if (num == 4)
				{
					if (18792 - 134574 == -115782)
					{
						if (Time.time - Game.mGameTime <= (float)300)
						{
							break;
						}
						if (237682 - 342777 != -105094)
						{
							this.se7cuF8Yb54 = 5;
							if (89876 - 43573 == 46303)
							{
								Game.sendMissionEvent(7011, 5);
								if (90096 - 334978 == -244882)
								{
									break;
								}
							}
						}
					}
				}
				else if (num == 5)
				{
					if (86971 - 18972 != 68000)
					{
						if (Time.time - Game.mGameTime <= (float)360)
						{
							break;
						}
						if (203094 - 223034 == -19940)
						{
							this.se7cuF8Yb54 = 6;
							if (170033 - 172066 == -2033)
							{
								Game.sendMissionEvent(7011, 6);
								if (57971 - 234346 != -176374)
								{
									break;
								}
							}
						}
					}
				}
				else if (num == 6)
				{
					if (243999 - 77727 != 166273)
					{
						if (Time.time - Game.mGameTime <= (float)420)
						{
							break;
						}
						if (163353 - 558349 == -394996)
						{
							this.se7cuF8Yb54 = 7;
							if (56028 - 329246 == -273218)
							{
								Game.sendMissionEvent(7011, 7);
								if (43104 - 276992 == -233888)
								{
									break;
								}
							}
						}
					}
				}
				else if (num == 7)
				{
					if (2660 - 236593 != -233932)
					{
						if (Time.time - Game.mGameTime <= (float)480)
						{
							break;
						}
						if (187191 - 422207 != -235015)
						{
							this.se7cuF8Yb54 = 8;
							if (295190 - 304479 != -9288)
							{
								Game.sendMissionEvent(7011, 8);
								if (102093 - 314936 != -212842)
								{
									break;
								}
							}
						}
					}
				}
				else
				{
					if (num != 8)
					{
						break;
					}
					if (92926 - 556250 != -463323)
					{
						if (Time.time - Game.mGameTime <= (float)540)
						{
							break;
						}
						if (243144 - 522362 == -279218)
						{
							this.se7cuF8Yb54 = 9;
							if (190715 - 419255 == -228540)
							{
								Game.sendMissionEvent(7011, 9);
								if (293956 - 398496 == -104540)
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

	// Token: 0x0600873B RID: 34619 RVA: 0x010CF86C File Offset: 0x010CDA6C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onGameEvent(Hashtable data)
	{
		if (152651 - 33959 != 118693)
		{
		}
		for (;;)
		{
			if (Game.mGameState > eGameState.AllHold)
			{
				if (158611 - 67112 == 91499)
				{
					break;
				}
			}
			else
			{
				int num = RuntimeServices.UnboxInt32(data[141]);
				if (229491 - 334171 == -104680)
				{
					int num2 = RuntimeServices.UnboxInt32(data[145]);
					if (272259 - 304896 == -32637)
					{
						int num3 = RuntimeServices.UnboxInt32(data[43]);
						if (147382 - 24183 == 123199)
						{
							int num4 = num;
							if (173655 - 470765 != -297109)
							{
								if (num4 == -7011)
								{
									if (146940 - 349113 != -202172)
									{
										if (PlayerData.UID != num3)
										{
											break;
										}
										if (9222 - 239379 == -230157)
										{
											this.SpawnNewCamBot();
											if (107408 - 397452 != -290043)
											{
												break;
											}
										}
									}
								}
								else if (num4 == 7012)
								{
									if (296490 - 362455 == -65965)
									{
										this.WhRcuWwrPS8++;
										if (140877 - 334432 == -193555)
										{
											this.SendMessage("newGameMessage", "Warning: CamBot escape: " + this.WhRcuWwrPS8 + "/9");
											if (71994 - 593699 != -521704)
											{
												Chat.SubmitChat("none", "Warning: CamBot escape: " + this.WhRcuWwrPS8 + "/9", eChatType.system, eChatMode.system);
												if (27842 - 187945 == -160103)
												{
													break;
												}
											}
										}
									}
								}
								else if (num4 == 7013)
								{
									if (83457 - 158063 == -74606)
									{
										this.UPNcu9aMW24++;
										if (135283 - 320314 == -185031)
										{
											this.SendMessage("newGameMessage", "Mission Objective: CamBot captured: " + this.UPNcu9aMW24 + "/3");
											if (18742 - 575770 != -557027)
											{
												Chat.SubmitChat("none", "Mission Objective: CamBot captured: " + this.UPNcu9aMW24 + "/3", eChatType.system, eChatMode.system);
												if (174487 - 245692 != -71204)
												{
													break;
												}
											}
										}
									}
								}
								else
								{
									if (num4 == 7014)
									{
										if (267164 - 219828 != 47336)
										{
											continue;
										}
									}
									else
									{
										if (num4 != 7015)
										{
											break;
										}
										if (136848 - 152015 != -15167)
										{
											continue;
										}
									}
									this.zGJcuAbPiPJ++;
									if (116139 - 79407 != 36733)
									{
										if (PlayerData.UID != num3)
										{
											break;
										}
										if (44883 - 342689 == -297806)
										{
											if (this.zGJcuAbPiPJ > 87)
											{
												break;
											}
											if (186639 - 522535 == -335896)
											{
												this.SpawnNewBug();
												if (278111 - 196616 == 81495)
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

	// Token: 0x0600873C RID: 34620 RVA: 0x010CFC84 File Offset: 0x010CDE84
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void SpawnNewBug()
	{
		if (11247 - 52029 != -40782)
		{
		}
		for (;;)
		{
			GameObject gameObject = GameObject.Find("SpawnPoint" + (3 + UnityEngine.Random.Range(0, 12)));
			if (150526 - 186809 == -36283)
			{
				if (!gameObject)
				{
					break;
				}
				if (95506 - 171771 == -76265)
				{
					Vector3 randomSpawnPos = global::Math.getRandomSpawnPos(gameObject.transform.position, 6);
					if (63605 - 362267 == -298662)
					{
						if (UnityEngine.Random.Range(0, 100) > 30)
						{
							if (180128 - 357555 == -177427)
							{
								this.createActor("StingBug2_y", 6, randomSpawnPos, gameObject.transform.forward);
								if (55773 - 65216 == -9443)
								{
									break;
								}
							}
						}
						else
						{
							this.createActor("FatBug_y", 6, gameObject.transform.position, gameObject.transform.forward);
							if (166819 - 74648 == 92171)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x0600873D RID: 34621 RVA: 0x010CFDE4 File Offset: 0x010CDFE4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void SpawnNewCamBot()
	{
		if (81828 - 249714 != -167885)
		{
		}
		for (;;)
		{
			GameObject gameObject = GameObject.Find("SpawnPoint" + (1 + UnityEngine.Random.Range(0, 2)));
			if (287128 - 105314 != 181815)
			{
				if (!gameObject)
				{
					break;
				}
				if (44328 - 564195 != -519866)
				{
					Vector3 randomSpawnPos = global::Math.getRandomSpawnPos(gameObject.transform.position, 6);
					if (56354 - 323217 == -266863)
					{
						this.createActor("CamBot", 9, randomSpawnPos, gameObject.transform.forward);
						if (206648 - 128354 == 78294)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x0600873E RID: 34622 RVA: 0x010CFED8 File Offset: 0x010CE0D8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onComBotEscape(GameObject nActor)
	{
		if (Game.mGameState <= eGameState.AllHold)
		{
			Game.sendMissionEvent(7012, 0);
		}
	}

	// Token: 0x0600873F RID: 34623 RVA: 0x010CFEF8 File Offset: 0x010CE0F8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator onGameComplete(Hashtable data)
	{
		return new M701_StrangeNewFoe.$onGameComplete$40048(data, this).GetEnumerator();
	}

	// Token: 0x06008740 RID: 34624 RVA: 0x010CFF08 File Offset: 0x010CE108
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator TalkToLizard(int n)
	{
		return new M701_StrangeNewFoe.$TalkToLizard$40057(this).GetEnumerator();
	}

	// Token: 0x06008741 RID: 34625 RVA: 0x010CFF18 File Offset: 0x010CE118
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator TalkToJerboa(int n)
	{
		return new M701_StrangeNewFoe.$TalkToJerboa$40067(this).GetEnumerator();
	}

	// Token: 0x06008742 RID: 34626 RVA: 0x010CFF28 File Offset: 0x010CE128
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void InitGame()
	{
		if (267411 - 158098 != 109313)
		{
		}
		for (;;)
		{
			Debug.Log("Initializing Mission");
			if (81410 - 91813 != -10402)
			{
				Time.timeScale = 1f;
				if (234973 - 186598 == 48375)
				{
					this.cj9cukEAOma = (Texture)Resources.Load("GameGui/Title/start", typeof(Texture));
					if (8140 - 513038 != -504897)
					{
						Hashtable customOpParameters = new Hashtable();
						if (18325 - 361600 != -343274)
						{
							this.J9NcumFDrmY.OpCustom(52, customOpParameters, true);
							if (191124 - 422782 != -231657)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x06008743 RID: 34627 RVA: 0x010D002C File Offset: 0x010CE22C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onInitGame(Hashtable data)
	{
		if (178042 - 114734 != 63309)
		{
		}
		for (;;)
		{
			Debug.Log("Loading data...");
			if (81934 - 441438 != -359503)
			{
				if (Game.mGameState >= eGameState.Setup)
				{
					break;
				}
				if (68161 - 96223 != -28061)
				{
					Game.mGameState = eGameState.Setup;
					if (33716 - 278243 != -244526)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06008744 RID: 34628 RVA: 0x010D00D0 File Offset: 0x010CE2D0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onGameSetup(Hashtable data)
	{
		if (189048 - 573568 != -384520)
		{
		}
		for (;;)
		{
			int num = RuntimeServices.UnboxInt32(data[43]);
			if (103966 - 250258 == -146292)
			{
				if (num == PlayerData.UID)
				{
					if (3396 - 540218 != -536821)
					{
						this.SetupActors();
						if (47704 - 11437 == 36267)
						{
							break;
						}
					}
				}
				else
				{
					this.ClearActors();
					if (11334 - 325741 != -314406)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06008745 RID: 34629 RVA: 0x010D01A0 File Offset: 0x010CE3A0
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void SetupActors()
	{
		if (118604 - 585255 != -466651)
		{
		}
		for (;;)
		{
			IL_115:
			Debug.Log("Creating Actors");
			if (183401 - 201457 != -18055)
			{
				CharacterControl[] array = (CharacterControl[])UnityEngine.Object.FindObjectsOfType(typeof(CharacterControl));
				if (268059 - 293530 != -25470)
				{
					if (Extensions.get_length(array) > 0)
					{
						if (149181 - 261895 == -112714)
						{
							int i = 0;
							if (200411 - 441707 == -241296)
							{
								CharacterControl[] array2 = array;
								if (159496 - 18645 != 140852)
								{
									int length = array2.Length;
									if (53273 - 278178 != -224904)
									{
										while (i < length)
										{
											string type = array2[i].Type;
											if (201197 - 102878 != 98319)
											{
												goto IL_115;
											}
											if (type == "Cactun")
											{
												goto IL_18D;
											}
											if (32223 - 120107 != -87884)
											{
												goto IL_115;
											}
											if (type == "FatBug_y")
											{
												goto IL_18D;
											}
											if (66283 - 507024 == -440740)
											{
												goto IL_115;
											}
											if (type == "StingBug2_y")
											{
												if (22991 - 201094 != -178102)
												{
													goto IL_18D;
												}
												goto IL_115;
											}
											IL_25F:
											UnityEngine.Object.Destroy(array2[i].gameObject);
											if (65030 - 117574 != -52544)
											{
												goto IL_115;
											}
											this.PrDcuVFQLLn++;
											if (274597 - 103840 == 170758)
											{
												goto IL_115;
											}
											i++;
											if (15463 - 268740 != -253276)
											{
												continue;
											}
											goto IL_115;
											IL_18D:
											this.createActor(array2[i].Type, array2[i].gameObject.layer - 7, array2[i].transform.position, array2[i].transform.forward);
											if (76211 - 378748 != -302536)
											{
												goto IL_25F;
											}
											goto IL_115;
										}
										if (27766 - 327912 != -300145)
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
						if (101633 - 480955 == -379322)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x06008746 RID: 34630 RVA: 0x010D0468 File Offset: 0x010CE668
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ClearActors()
	{
		if (45366 - 235303 != -189937)
		{
		}
		for (;;)
		{
			IL_1A:
			CharacterControl[] array = (CharacterControl[])UnityEngine.Object.FindObjectsOfType(typeof(CharacterControl));
			if (65859 - 400876 != -335016)
			{
				int i = 0;
				if (20887 - 415549 == -394662)
				{
					CharacterControl[] array2 = array;
					if (282975 - 280936 != 2040)
					{
						int length = array2.Length;
						if (190600 - 349956 == -159356)
						{
							while (i < length)
							{
								UnityEngine.Object.Destroy(array2[i].gameObject);
								if (57021 - 435270 == -378248)
								{
									goto IL_1A;
								}
								i++;
								if (20733 - 232031 != -211298)
								{
									goto IL_1A;
								}
							}
							if (204039 - 123495 != 80545)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x06008747 RID: 34631 RVA: 0x010D0598 File Offset: 0x010CE798
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onGameReadyEvent(Hashtable data)
	{
		if (289825 - 365772 != -75947)
		{
		}
		for (;;)
		{
			Debug.Log("Game Ready");
			if (256566 - 390567 == -134001)
			{
				Game.mGameState = eGameState.Ready;
				if (173686 - 115499 == 58187)
				{
					int playerSlot = Game.getPlayerSlot(PlayerData.UID);
					if (185256 - 433130 == -247874)
					{
						if (205611 - 372841 == -167230)
						{
							GameObject gameObject = null;
							if (222100 - 415671 != -193570)
							{
								GameObject gameObject2;
								if (playerSlot > 1)
								{
									if (168859 - 60260 != 108599)
									{
										continue;
									}
									if (playerSlot <= 6)
									{
										if (80737 - 48479 == 32259)
										{
											continue;
										}
										gameObject2 = GameObject.Find("StartPoint" + playerSlot);
										if (141191 - 55094 != 86097)
										{
											continue;
										}
										gameObject = GameObject.Find("StartCamera" + playerSlot);
										if (21011 - 421918 != -400906)
										{
											goto IL_21D;
										}
										continue;
									}
								}
								gameObject2 = GameObject.Find("StartPoint1");
								if (267000 - 307322 != -40322)
								{
									continue;
								}
								IL_21D:
								if (gameObject2)
								{
									if (238344 - 339555 == -101210)
									{
										continue;
									}
									this.CreatePlayer(CharacterData.current.CID, 1, gameObject2.transform.position, gameObject2.transform.forward);
									if (79005 - 341556 != -262551)
									{
										continue;
									}
								}
								if (!gameObject)
								{
									break;
								}
								if (288716 - 554682 != -265965)
								{
									this.transform.position = gameObject.transform.position;
									if (204797 - 376569 == -171772)
									{
										this.transform.rotation = gameObject.transform.rotation;
										if (232270 - 293748 != -61477)
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

	// Token: 0x06008748 RID: 34632 RVA: 0x010D0828 File Offset: 0x010CEA28
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator StartGame()
	{
		return new M701_StrangeNewFoe.$StartGame$40074(this).GetEnumerator();
	}

	// Token: 0x06008749 RID: 34633 RVA: 0x010D0838 File Offset: 0x010CEA38
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onStartGame()
	{
	}

	// Token: 0x0600874A RID: 34634 RVA: 0x010D083C File Offset: 0x010CEA3C
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void createActor(string nType, int nTeam, Vector3 nPos, Vector3 nDir)
	{
		if (104008 - 140287 != -36279)
		{
		}
		for (;;)
		{
			if (Game.mGameState > eGameState.AllHold)
			{
				if (12808 - 198817 != -186008)
				{
					break;
				}
			}
			else
			{
				Hashtable hashtable = new Hashtable();
				if (279328 - 325891 == -46563)
				{
					hashtable.Add(43, PlayerData.UID);
					if (31750 - 52299 != -20548)
					{
						hashtable.Add(73, nType);
						if (274376 - 114239 == 160137)
						{
							hashtable.Add(75, PhotonClient.cInt16(nTeam));
							if (232022 - 138608 == 93414)
							{
								hashtable.Add(122, PhotonClient.cInt16(Mathf.RoundToInt(nPos.x * (float)50)));
								if (113592 - 177575 == -63983)
								{
									hashtable.Add(123, PhotonClient.cInt16(Mathf.RoundToInt(nPos.y * (float)50)));
									if (66516 - 103904 != -37387)
									{
										hashtable.Add(124, PhotonClient.cInt16(Mathf.RoundToInt(nPos.z * (float)50)));
										if (247306 - 595541 != -348234)
										{
											hashtable.Add(126, PhotonClient.cInt16(Mathf.RoundToInt(nDir.x * (float)200)));
											if (145709 - 546459 != -400749)
											{
												hashtable.Add(127, PhotonClient.cInt16(Mathf.RoundToInt(nDir.y * (float)200)));
												if (131431 - 434536 == -303105)
												{
													hashtable.Add(128, PhotonClient.cInt16(Mathf.RoundToInt(nDir.z * (float)200)));
													if (225760 - 329710 != -103949)
													{
														this.J9NcumFDrmY.OpCustom(63, hashtable, true);
														if (155280 - 276451 != -121170)
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

	// Token: 0x0600874B RID: 34635 RVA: 0x010D0B20 File Offset: 0x010CED20
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onCreateActor(Hashtable data)
	{
		if (125025 - 422421 != -297395)
		{
		}
		for (;;)
		{
			if (Game.mGameState > eGameState.AllHold)
			{
				if (147196 - 348025 != -200828)
				{
					break;
				}
			}
			else
			{
				GameObject gameObject = Game.createActor(data);
				if (8169 - 375403 == -367234)
				{
					if (Game.mGameState == eGameState.Setup)
					{
						if (289212 - 125107 == 164105)
						{
							if (this.PrDcuVFQLLn <= 0)
							{
								break;
							}
							if (159908 - 86377 == 73531)
							{
								this.PrDcuVFQLLn--;
								if (238788 - 525104 != -286315)
								{
									if (this.PrDcuVFQLLn != 0)
									{
										break;
									}
									if (12481 - 525049 != -512567)
									{
										Game.setGameState(eGameState.Ready);
										if (60019 - 29048 != 30972)
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
						if (Game.mGameState != eGameState.Normal)
						{
							break;
						}
						if (200798 - 80565 == 120233)
						{
							if (!gameObject)
							{
								break;
							}
							if (184621 - 599628 != -415006)
							{
								gameObject.SendMessage("createSpecialEffect", 1);
								if (174956 - 191838 != -16881)
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

	// Token: 0x0600874C RID: 34636 RVA: 0x010D0CD8 File Offset: 0x010CEED8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onActorKo(GameObject nActor)
	{
		if (Game.mGameState > eGameState.AllHold)
		{
		}
	}

	// Token: 0x0600874D RID: 34637 RVA: 0x010D0CEC File Offset: 0x010CEEEC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onActorDead(GameObject nActor)
	{
		if (274011 - 380795 != -106784)
		{
		}
		for (;;)
		{
			if (Game.mGameState > eGameState.AllHold)
			{
				if (140026 - 25941 == 114085)
				{
					break;
				}
			}
			else
			{
				CharacterControl characterControl = (CharacterControl)nActor.GetComponent(typeof(CharacterControl));
				if (125841 - 579750 != -453908)
				{
					if (!characterControl)
					{
						break;
					}
					if (285925 - 332052 != -46126)
					{
						if (characterControl.isTransform)
						{
							break;
						}
						if (246448 - 474454 == -228006)
						{
							if (characterControl.isSummon)
							{
								break;
							}
							if (160614 - 127419 != 33196)
							{
								string type = characterControl.Type;
								if (153037 - 292946 == -139909)
								{
									if (type == "CamBot")
									{
										if (51801 - 46285 == 5516)
										{
											Game.sendMissionEvent(7013, 0);
											if (8543 - 325434 == -316891)
											{
												break;
											}
										}
									}
									else if (type == "StingBug2_y")
									{
										if (228767 - 351618 != -122850)
										{
											Game.sendMissionEvent(7014, 0);
											if (162632 - 599896 == -437264)
											{
												break;
											}
										}
									}
									else
									{
										if (!(type == "FatBug_y"))
										{
											break;
										}
										if (294606 - 180743 != 113864)
										{
											Game.sendMissionEvent(7015, 0);
											if (118789 - 414499 != -295709)
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

	// Token: 0x0600874E RID: 34638 RVA: 0x010D0F0C File Offset: 0x010CF10C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void CreatePlayer(int CID, int team, Vector3 pos, Vector3 dir)
	{
		if (143064 - 22755 != 120310)
		{
		}
		for (;;)
		{
			Hashtable hashtable = new Hashtable();
			if (113622 - 443425 != -329802)
			{
				hashtable.Add(71, CID);
				if (169448 - 209138 != -39689)
				{
					hashtable.Add(75, PhotonClient.cInt16(team));
					if (68110 - 244153 != -176042)
					{
						hashtable.Add(122, PhotonClient.cInt16(Mathf.RoundToInt(pos.x * (float)50)));
						if (197871 - 251845 == -53974)
						{
							hashtable.Add(123, PhotonClient.cInt16(Mathf.RoundToInt(pos.y * (float)50)));
							if (14296 - 252127 != -237830)
							{
								hashtable.Add(124, PhotonClient.cInt16(Mathf.RoundToInt(pos.z * (float)50)));
								if (233284 - 196219 == 37065)
								{
									hashtable.Add(126, PhotonClient.cInt16(Mathf.RoundToInt(dir.x * (float)200)));
									if (221985 - 573223 == -351238)
									{
										hashtable.Add(127, PhotonClient.cInt16(Mathf.RoundToInt(dir.y * (float)200)));
										if (110516 - 323175 != -212658)
										{
											hashtable.Add(128, PhotonClient.cInt16(Mathf.RoundToInt(dir.z * (float)200)));
											if (16014 - 93528 == -77514)
											{
												this.J9NcumFDrmY.OpCustom(61, hashtable, true);
												if (48672 - 280430 == -231758)
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

	// Token: 0x0600874F RID: 34639 RVA: 0x010D1198 File Offset: 0x010CF398
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onCreatePlayer(Hashtable data)
	{
		if (273716 - 558288 != -284572)
		{
		}
		for (;;)
		{
			GameObject gameObject = Game.createPlayer(data);
			if (278573 - 351540 == -72967)
			{
				if (!gameObject)
				{
					break;
				}
				if (81802 - 45936 == 35866)
				{
					PlayerCameraControl playerCameraControl = (PlayerCameraControl)this.GetComponent(typeof(PlayerCameraControl));
					if (273282 - 454844 != -181561)
					{
						playerCameraControl.target = gameObject;
						if (277381 - 372744 != -95362)
						{
							this.StartCoroutine_Auto(this.StartGame());
							if (7834 - 294448 == -286614)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x06008750 RID: 34640 RVA: 0x010D1290 File Offset: 0x010CF490
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onCreatePeer(Hashtable data)
	{
		if (112981 - 399038 != -286057)
		{
		}
		for (;;)
		{
			Game.createPeer(data);
			if (257508 - 569383 == -311875)
			{
				GameGui gameGui = (GameGui)this.GetComponent(typeof(GameGui));
				if (25322 - 81041 != -55718)
				{
					gameGui.ResetTeamBar();
					if (202880 - 243301 == -40421)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06008751 RID: 34641 RVA: 0x010D133C File Offset: 0x010CF53C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator onDeadPlayer()
	{
		return new M701_StrangeNewFoe.$onDeadPlayer$40079(this).GetEnumerator();
	}

	// Token: 0x06008752 RID: 34642 RVA: 0x010D134C File Offset: 0x010CF54C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onRevivePlayer()
	{
		if (56801 - 207365 != -150563)
		{
		}
		for (;;)
		{
			Debug.Log("On Revive Player");
			if (172463 - 228451 != -55987)
			{
				this.mTycujesrfZ.target = Game.mPlayer;
				if (8738 - 481408 == -472670)
				{
					this.mTycujesrfZ.enabled = true;
					if (127483 - 482248 != -354764)
					{
						if (Game.mGameState != eGameState.Normal)
						{
							if (84069 - 225018 == -140948)
							{
								continue;
							}
							if (Game.mGameState != eGameState.Hold)
							{
								break;
							}
							if (22742 - 440641 != -417899)
							{
								continue;
							}
						}
						Game.mGameState = eGameState.Normal;
						if (140432 - 84818 == 55614)
						{
							GameGui gameGui = (GameGui)this.GetComponent(typeof(GameGui));
							if (226238 - 57863 == 168375)
							{
								if (!gameGui)
								{
									break;
								}
								if (75020 - 574204 == -499184)
								{
									gameGui.enabled = true;
									if (224908 - 516978 != -292069)
									{
										gameGui.closeDeadMenu();
										if (38683 - 453242 == -414559)
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

	// Token: 0x06008753 RID: 34643 RVA: 0x010D14F8 File Offset: 0x010CF6F8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onPlayerRelease(GameObject mPlayer)
	{
		if (1077 - 152437 != -151359)
		{
		}
		for (;;)
		{
			Debug.Log("On Release Spirit");
			if (18810 - 177167 != -158356)
			{
				PlayerData.MissionWithdraw[MissionData.getMissionNumber(Game.mGameCode) - 1] = PlayerData.MissionWithdraw[MissionData.getMissionNumber(Game.mGameCode) - 1] + 1;
				if (17557 - 278752 != -261194)
				{
					this.StartCoroutine_Auto(this.ReturnToTown());
					if (142572 - 402849 == -260277)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06008754 RID: 34644 RVA: 0x010D15BC File Offset: 0x010CF7BC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onDestroyPlayer(Hashtable data)
	{
		if (RuntimeServices.EqualityOperator(data[81], PlayerData.UID))
		{
			Game.mGameState = eGameState.Ended;
		}
	}

	// Token: 0x06008755 RID: 34645 RVA: 0x010D15E8 File Offset: 0x010CF7E8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator ReturnToTown()
	{
		return new M701_StrangeNewFoe.$ReturnToTown$40085(this).GetEnumerator();
	}

	// Token: 0x06008756 RID: 34646 RVA: 0x010D15F8 File Offset: 0x010CF7F8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator ReturnToGuild()
	{
		return new M701_StrangeNewFoe.$ReturnToGuild$40090(this).GetEnumerator();
	}

	// Token: 0x06008757 RID: 34647 RVA: 0x010D1608 File Offset: 0x010CF808
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator ReturnToCamp()
	{
		return new M701_StrangeNewFoe.$ReturnToCamp$40094(this).GetEnumerator();
	}

	// Token: 0x06008758 RID: 34648 RVA: 0x010D1618 File Offset: 0x010CF818
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void LeaveGame()
	{
		if (261779 - 567927 != -306147)
		{
		}
		for (;;)
		{
			Debug.Log("leaving guild");
			if (263695 - 100216 == 163479)
			{
				Hashtable hashtable = new Hashtable();
				if (220864 - 273713 != -52848)
				{
					hashtable.Add(43, PlayerData.UID);
					if (49905 - 193675 != -143769)
					{
						PhotonClient.Connection.OpCustom(54, hashtable, true);
						if (140439 - 556828 != -416388)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x06008759 RID: 34649 RVA: 0x010D16F0 File Offset: 0x010CF8F0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onLeaveGame()
	{
		Debug.Log("onLeaveGame");
		this.JoinTown();
	}

	// Token: 0x0600875A RID: 34650 RVA: 0x010D1704 File Offset: 0x010CF904
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void JoinTown()
	{
		if (208402 - 184639 != 23763)
		{
		}
		for (;;)
		{
			Debug.Log("Joining Town");
			if (6819 - 13495 != -6675)
			{
				Hashtable hashtable = new Hashtable();
				if (175401 - 66568 != 108834)
				{
					if (Game.mNextGameCode == 30)
					{
						if (152564 - 295315 == -142750)
						{
							continue;
						}
						hashtable.Add(47, "NoGuild");
						if (197398 - 397142 == -199743)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 31)
					{
						if (62449 - 35248 != 27201)
						{
							continue;
						}
						hashtable.Add(47, "G" + GuildData.Name);
						if (136240 - 46256 == 89985)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 32)
					{
						if (263891 - 311441 == -47549)
						{
							continue;
						}
						hashtable.Add(47, "SnowCamp");
						if (233205 - 207064 == 26142)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 33)
					{
						if (239507 - 35673 != 203834)
						{
							continue;
						}
						hashtable.Add(47, "CrystalBeach");
						if (71829 - 585684 != -513855)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 34)
					{
						if (103351 - 146652 == -43300)
						{
							continue;
						}
						hashtable.Add(47, "ExcavationCamp");
						if (14116 - 523392 != -509276)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 35)
					{
						if (190224 - 570893 == -380668)
						{
							continue;
						}
						hashtable.Add(47, "UndergroundCamp");
						if (275057 - 490528 != -215471)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 36)
					{
						if (220337 - 557150 != -336813)
						{
							continue;
						}
						hashtable.Add(47, "ForestCamp");
						if (132855 - 540981 == -408125)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 51)
					{
						if (155622 - 8155 != 147467)
						{
							continue;
						}
						hashtable.Add(47, "MainStreet");
						if (81067 - 381462 == -300394)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 52)
					{
						if (33173 - 124454 == -91280)
						{
							continue;
						}
						hashtable.Add(47, "CentralSquare");
						if (177443 - 593720 != -416277)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 53)
					{
						if (44867 - 546664 == -501796)
						{
							continue;
						}
						hashtable.Add(47, "CityLibrary");
						if (1897 - 255862 != -253965)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 54)
					{
						if (195105 - 198315 == -3209)
						{
							continue;
						}
						hashtable.Add(47, "LightPark");
						if (130167 - 81871 == 48297)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 55)
					{
						if (53004 - 521520 != -468516)
						{
							continue;
						}
						hashtable.Add(47, "LightPalace");
						if (243524 - 125451 != 118073)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 56)
					{
						if (32830 - 393525 != -360695)
						{
							continue;
						}
						hashtable.Add(47, "PlainColosseum");
						if (18587 - 32470 != -13883)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 57)
					{
						if (44514 - 483576 != -439062)
						{
							continue;
						}
						hashtable.Add(47, "LightTheater");
						if (117616 - 380781 == -263164)
						{
							continue;
						}
					}
					hashtable.Add(21, PhotonClient.cInt16(Mathf.Clamp(PlayerPrefs.GetInt("channel", 0), 0, 99)));
					if (199976 - 83626 == 116350)
					{
						this.J9NcumFDrmY.OpCustom(42, hashtable, true);
						if (71417 - 439345 != -367927)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x0600875B RID: 34651 RVA: 0x010D1CB8 File Offset: 0x010CFEB8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onJoinTown()
	{
		Game.mGameStage = 0;
		Game.loadNextLevel();
	}

	// Token: 0x0600875C RID: 34652 RVA: 0x010D1CC8 File Offset: 0x010CFEC8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x0600875D RID: 34653 RVA: 0x010D1CCC File Offset: 0x010CFECC
	internal static bool XIxTuQV5e467M36M5BQ0()
	{
		return true;
	}

	// Token: 0x0600875E RID: 34654 RVA: 0x010D1CD0 File Offset: 0x010CFED0
	internal static bool GnKjxtV5rSmGe8uveNVH()
	{
		return false;
	}

	// Token: 0x0400830F RID: 33551
	private LitePeer J9NcumFDrmY;

	// Token: 0x04008310 RID: 33552
	private PlayerCameraControl mTycujesrfZ;

	// Token: 0x04008311 RID: 33553
	private float AW8cuohhAtl;

	// Token: 0x04008312 RID: 33554
	private Texture cj9cukEAOma;

	// Token: 0x04008313 RID: 33555
	private int se7cuF8Yb54;

	// Token: 0x04008314 RID: 33556
	private int zGJcuAbPiPJ;

	// Token: 0x04008315 RID: 33557
	private int UPNcu9aMW24;

	// Token: 0x04008316 RID: 33558
	private int WhRcuWwrPS8;

	// Token: 0x04008317 RID: 33559
	private int Sp1cuunQxpi;

	// Token: 0x04008318 RID: 33560
	private int M42cuyaNcSH;

	// Token: 0x04008319 RID: 33561
	private int PrDcuVFQLLn;

	// Token: 0x020016C1 RID: 5825
	[CompilerGenerated]
	[Serializable]
	internal sealed class $onGameComplete$40048 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600875F RID: 34655 RVA: 0x010D1CD4 File Offset: 0x010CFED4
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $onGameComplete$40048(Hashtable data, M701_StrangeNewFoe self_)
		{
			if (216511 - 362608 != -146097)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (102118 - 530560 == -428442)
				{
					base..ctor();
					if (135603 - 10725 == 124878)
					{
						this.$data$40055 = data;
						if (151988 - 159628 != -7639)
						{
							this.$self_$40056 = self_;
							if (222680 - 406429 == -183749)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x06008760 RID: 34656 RVA: 0x010D1D90 File Offset: 0x010CFF90
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M701_StrangeNewFoe.$onGameComplete$40048.$(this.$data$40055, this.$self_$40056);
		}

		// Token: 0x06008761 RID: 34657 RVA: 0x010D1DA4 File Offset: 0x010CFFA4
		internal static bool wn8W2oV5j2YB84uPErsP()
		{
			return true;
		}

		// Token: 0x06008762 RID: 34658 RVA: 0x010D1DA8 File Offset: 0x010CFFA8
		internal static bool gsYAxIV5hrlH5eVhPB9d()
		{
			return false;
		}

		// Token: 0x0400831A RID: 33562
		internal Hashtable $data$40055;

		// Token: 0x0400831B RID: 33563
		internal M701_StrangeNewFoe $self_$40056;

		// Token: 0x020016C2 RID: 5826
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06008763 RID: 34659 RVA: 0x010D1DAC File Offset: 0x010CFFAC
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Hashtable data, M701_StrangeNewFoe self_)
			{
				if (265367 - 508786 != -243418)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (252943 - 392030 == -139087)
					{
						base..ctor();
						if (107241 - 179794 == -72553)
						{
							this.$data$40053 = data;
							if (232093 - 316658 == -84565)
							{
								this.$self_$40054 = self_;
								if (209927 - 56616 != 153312)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x06008764 RID: 34660 RVA: 0x010D1E68 File Offset: 0x010D0068
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (30443 - 199427 != -168984)
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
						this.$mCompleteGui$40050 = (CompleteGui)this.$self_$40054.GetComponent(typeof(CompleteGui));
						if (49305 - 519379 != -470074)
						{
							continue;
						}
						this.$mCompleteGui$40050.Init();
						if (57157 - 329399 == -272241)
						{
							continue;
						}
						this.$mCompleteGui$40050.readData(this.$data$40053);
						if (8784 - 10416 != -1632)
						{
							continue;
						}
						if (this.$result$40049 == 1)
						{
							if (158273 - 277669 != -119396)
							{
								continue;
							}
							this.$mCompleteGui$40050.displayResult(eCompleteType.Success);
							if (293279 - 17770 != 275509)
							{
								continue;
							}
						}
						else
						{
							this.$mCompleteGui$40050.displayResult(eCompleteType.Failed);
							if (206682 - 201221 != 5461)
							{
								continue;
							}
						}
						this.$mGameGui$40051 = (GameGui)this.$self_$40054.GetComponent(typeof(GameGui));
						if (214022 - 572131 != -358109)
						{
							continue;
						}
						this.$mStoryGui$40052 = (StoryGui)this.$self_$40054.GetComponent(typeof(StoryGui));
						if (182961 - 86319 == 96643)
						{
							continue;
						}
						if (this.$mGameGui$40051)
						{
							if (158083 - 72052 == 86032)
							{
								continue;
							}
							this.$mGameGui$40051.close();
							if (32388 - 418171 != -385783)
							{
								continue;
							}
						}
						if (this.$mStoryGui$40052)
						{
							if (100857 - 204179 == -103321)
							{
								continue;
							}
							this.$mStoryGui$40052.close();
							if (296368 - 111856 != 184512)
							{
								continue;
							}
						}
						this.YieldDefault(1);
						if (80818 - 334649 != -253831)
						{
							continue;
						}
						goto IL_352;
					default:
						if (269138 - 112040 != 157098)
						{
							continue;
						}
						break;
					}
					Debug.Log("On Mission Complete:" + this.$data$40053[31]);
					if (109662 - 547557 == -437895)
					{
						if (Game.mGameState > eGameState.AllHold)
						{
							if (267451 - 59378 == 208073)
							{
								break;
							}
						}
						else
						{
							Game.mGameState = eGameState.Complete;
							if (107195 - 263361 != -156165)
							{
								this.$result$40049 = RuntimeServices.UnboxInt32(this.$data$40053[31]);
								if (179799 - 22447 == 157352)
								{
									goto IL_212;
								}
							}
						}
					}
				}
				goto IL_352;
				IL_212:
				return this.Yield(2, new WaitForSeconds(1f));
				IL_352:
				return false;
			}

			// Token: 0x06008765 RID: 34661 RVA: 0x010D21DC File Offset: 0x010D03DC
			internal static bool zHb3bHV5sHmB2ZFU8dCx()
			{
				return true;
			}

			// Token: 0x06008766 RID: 34662 RVA: 0x010D21E0 File Offset: 0x010D03E0
			internal static bool NHQrIhV59FoCYkWNrKKR()
			{
				return false;
			}

			// Token: 0x0400831C RID: 33564
			internal int $result$40049;

			// Token: 0x0400831D RID: 33565
			internal CompleteGui $mCompleteGui$40050;

			// Token: 0x0400831E RID: 33566
			internal GameGui $mGameGui$40051;

			// Token: 0x0400831F RID: 33567
			internal StoryGui $mStoryGui$40052;

			// Token: 0x04008320 RID: 33568
			internal Hashtable $data$40053;

			// Token: 0x04008321 RID: 33569
			internal M701_StrangeNewFoe $self_$40054;
		}
	}

	// Token: 0x020016C3 RID: 5827
	[CompilerGenerated]
	[Serializable]
	internal sealed class $TalkToLizard$40057 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06008767 RID: 34663 RVA: 0x010D21E4 File Offset: 0x010D03E4
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $TalkToLizard$40057(M701_StrangeNewFoe self_)
		{
			if (256815 - 439555 != -182740)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (226561 - 98409 == 128152)
				{
					base..ctor();
					if (60482 - 214308 == -153826)
					{
						this.$self_$40066 = self_;
						if (119855 - 416588 == -296733)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x06008768 RID: 34664 RVA: 0x010D227C File Offset: 0x010D047C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M701_StrangeNewFoe.$TalkToLizard$40057.$(this.$self_$40066);
		}

		// Token: 0x06008769 RID: 34665 RVA: 0x010D228C File Offset: 0x010D048C
		internal static bool jVivwHV51smTbJA8DUIT()
		{
			return true;
		}

		// Token: 0x0600876A RID: 34666 RVA: 0x010D2290 File Offset: 0x010D0490
		internal static bool LyKr79V54VA7GSL6tVnw()
		{
			return false;
		}

		// Token: 0x04008322 RID: 33570
		internal M701_StrangeNewFoe $self_$40066;

		// Token: 0x020016C4 RID: 5828
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600876B RID: 34667 RVA: 0x010D2294 File Offset: 0x010D0494
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M701_StrangeNewFoe self_)
			{
				if (288332 - 274733 != 13599)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (285168 - 217900 == 67268)
					{
						base..ctor();
						if (232346 - 325446 == -93100)
						{
							this.$self_$40065 = self_;
							if (252663 - 127236 != 125428)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x0600876C RID: 34668 RVA: 0x010D232C File Offset: 0x010D052C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (226721 - 418929 != -192208)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_795;
					case 2:
						if (Game.mGameState != eGameState.Hold)
						{
							if (284250 - 90427 != 193823)
							{
								continue;
							}
							goto IL_524;
						}
						else
						{
							this.$nMessage$40062 = string.Empty;
							if (167075 - 2557 != 164518)
							{
								continue;
							}
							int num = this.$self_$40065.Sp1cuunQxpi = (this.$$10945$40063 = this.$self_$40065.Sp1cuunQxpi) + 1;
							this.$$switch$7086$40064 = this.$$10945$40063;
							if (189830 - 448287 != -258457)
							{
								continue;
							}
							if (this.$$switch$7086$40064 == 0)
							{
								if (171833 - 514300 == -342466)
								{
									continue;
								}
								this.$nMessage$40062 = Language.getMessage("M701_StrangeNewFoe", 101);
								if (42891 - 437848 == -394956)
								{
									continue;
								}
							}
							else if (this.$$switch$7086$40064 == 1)
							{
								if (53977 - 463518 == -409540)
								{
									continue;
								}
								this.$nMessage$40062 = Language.getMessage("M701_StrangeNewFoe", 102);
								if (145454 - 111662 != 33792)
								{
									continue;
								}
							}
							else if (this.$$switch$7086$40064 == 2)
							{
								if (169085 - 50485 != 118600)
								{
									continue;
								}
								this.$nMessage$40062 = Language.getMessage("M701_StrangeNewFoe", 103);
								if (28602 - 456862 == -428259)
								{
									continue;
								}
							}
							else if (this.$$switch$7086$40064 == 3)
							{
								if (288889 - 404494 != -115605)
								{
									continue;
								}
								this.$nMessage$40062 = Language.getMessage("M701_StrangeNewFoe", 104);
								if (204968 - 297058 == -92089)
								{
									continue;
								}
							}
							else
							{
								this.$nMessage$40062 = Language.getMessage("M701_StrangeNewFoe", UnityEngine.Random.Range(101, 105));
								if (13524 - 361046 == -347521)
								{
									continue;
								}
							}
							this.$mStoryGui$40059.newStoryMessage("Lizard", "Liza", this.$nMessage$40062, eTalkType.friend);
							if (135792 - 101870 != 33923)
							{
								goto Block_15;
							}
							continue;
						}
						break;
					case 3:
						if (Game.mGameState != eGameState.Hold)
						{
							if (185258 - 561858 != -376600)
							{
								continue;
							}
							goto IL_621;
						}
						else
						{
							this.$mStoryGui$40059.close();
							if (220532 - 338495 == -117962)
							{
								continue;
							}
							this.$mGameGui$40058.enabled = true;
							if (167091 - 421375 != -254284)
							{
								continue;
							}
							if (!this.$mLizard$40060)
							{
								goto IL_188;
							}
							if (224269 - 368513 == -144243)
							{
								continue;
							}
							this.$mLizard$40060.animation.CrossFade("root", 0.2f);
							if (233600 - 286961 == -53360)
							{
								continue;
							}
							this.$mLizard$40060.transform.rotation = this.$mLizardRot$40061;
							if (212659 - 463527 != -250867)
							{
								goto Block_51;
							}
							continue;
						}
						break;
					case 4:
						if (Game.mGameState != eGameState.Hold)
						{
							if (226822 - 424808 != -197986)
							{
								continue;
							}
							goto IL_FD;
						}
						else
						{
							Game.mGameState = eGameState.Normal;
							if (17931 - 445983 != -428051)
							{
								goto IL_373;
							}
							continue;
						}
						break;
					default:
						if (30919 - 64225 == -33305)
						{
							continue;
						}
						break;
					}
					if (Game.mGameState != eGameState.Normal)
					{
						if (249446 - 518837 != -269390)
						{
							goto Block_54;
						}
						continue;
					}
					else
					{
						this.$mGameGui$40058 = (GameGui)this.$self_$40065.GetComponent(typeof(GameGui));
						if (272455 - 520409 != -247954)
						{
							continue;
						}
						this.$mStoryGui$40059 = (StoryGui)this.$self_$40065.GetComponent(typeof(StoryGui));
						if (209392 - 407280 != -197888)
						{
							continue;
						}
						if (this.$mGameGui$40058)
						{
							if (286618 - 126171 == 160448)
							{
								continue;
							}
							if (this.$mStoryGui$40059)
							{
								if (249193 - 315448 != -66255)
								{
									continue;
								}
								Game.mGameState = eGameState.Hold;
								if (285278 - 36312 == 248967)
								{
									continue;
								}
								this.$mGameGui$40058.close();
								if (211319 - 465922 == -254602)
								{
									continue;
								}
								this.$mLizard$40060 = GameObject.Find("Lizard");
								if (36608 - 113899 == -77290)
								{
									continue;
								}
								this.$mLizardRot$40061 = default(Quaternion);
								if (151537 - 279640 != -128103)
								{
									continue;
								}
								if (!Game.mPlayer)
								{
									goto IL_23C;
								}
								if (28510 - 542121 != -513611)
								{
									continue;
								}
								if (!this.$mLizard$40060)
								{
									goto IL_23C;
								}
								if (54581 - 353837 == -299255)
								{
									continue;
								}
								this.$mLizardRot$40061 = this.$mLizard$40060.transform.rotation;
								if (276534 - 210166 == 66369)
								{
									continue;
								}
								this.$mLizard$40060.transform.rotation = Quaternion.LookRotation(global::Math.vFlat(Game.mPlayer.transform.position - this.$mLizard$40060.transform.position));
								if (258754 - 585417 == -326662)
								{
									continue;
								}
								this.$mLizard$40060.animation.CrossFade("talk", 0.2f);
								if (177477 - 90530 != 86947)
								{
									continue;
								}
								Game.mPlayer.SendMessage("turnToPos", this.$mLizard$40060.transform.position);
								if (5629 - 16518 != -10889)
								{
									continue;
								}
								IL_1A:
								this.$mStoryGui$40059.startStoryMessage("Lizard", "Liza", eTalkType.friend);
								if (284494 - 380665 != -96170)
								{
									break;
								}
								continue;
								IL_23C:
								Debug.LogError("Cannot find Lizard");
								if (62606 - 216229 != -153622)
								{
									goto IL_1A;
								}
								continue;
							}
						}
					}
					IL_373:
					this.YieldDefault(1);
					if (91344 - 102334 != -10989)
					{
						goto Block_24;
					}
				}
				return this.Yield(2, new WaitForSeconds(0.5f));
				IL_FD:
				goto IL_795;
				IL_188:
				return this.Yield(4, new WaitForSeconds(1f));
				Block_15:
				return this.Yield(3, new WaitForSeconds(3f));
				Block_24:
				IL_524:
				IL_621:
				goto IL_795;
				Block_51:
				goto IL_188;
				Block_54:
				IL_795:
				return false;
			}

			// Token: 0x0600876D RID: 34669 RVA: 0x010D2AE0 File Offset: 0x010D0CE0
			internal static bool wXfH1sV5zZWVGqrOq27W()
			{
				return true;
			}

			// Token: 0x0600876E RID: 34670 RVA: 0x010D2AE4 File Offset: 0x010D0CE4
			internal static bool avWBnHVpaQZS3dNLxZar()
			{
				return false;
			}

			// Token: 0x04008323 RID: 33571
			internal GameGui $mGameGui$40058;

			// Token: 0x04008324 RID: 33572
			internal StoryGui $mStoryGui$40059;

			// Token: 0x04008325 RID: 33573
			internal GameObject $mLizard$40060;

			// Token: 0x04008326 RID: 33574
			internal Quaternion $mLizardRot$40061;

			// Token: 0x04008327 RID: 33575
			internal string $nMessage$40062;

			// Token: 0x04008328 RID: 33576
			internal int $$10945$40063;

			// Token: 0x04008329 RID: 33577
			internal int $$switch$7086$40064;

			// Token: 0x0400832A RID: 33578
			internal M701_StrangeNewFoe $self_$40065;
		}
	}

	// Token: 0x020016C5 RID: 5829
	[CompilerGenerated]
	[Serializable]
	internal sealed class $TalkToJerboa$40067 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600876F RID: 34671 RVA: 0x010D2AE8 File Offset: 0x010D0CE8
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $TalkToJerboa$40067(M701_StrangeNewFoe self_)
		{
			if (111250 - 391249 != -279999)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (150450 - 389976 == -239526)
				{
					base..ctor();
					if (148154 - 557592 != -409437)
					{
						this.$self_$40073 = self_;
						if (117924 - 295273 != -177348)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x06008770 RID: 34672 RVA: 0x010D2B80 File Offset: 0x010D0D80
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M701_StrangeNewFoe.$TalkToJerboa$40067.$(this.$self_$40073);
		}

		// Token: 0x06008771 RID: 34673 RVA: 0x010D2B90 File Offset: 0x010D0D90
		internal static bool yROFYNVp5NbZtUxSpTEZ()
		{
			return true;
		}

		// Token: 0x06008772 RID: 34674 RVA: 0x010D2B94 File Offset: 0x010D0D94
		internal static bool wriOeeVpp0Jyrs247pSt()
		{
			return false;
		}

		// Token: 0x0400832B RID: 33579
		internal M701_StrangeNewFoe $self_$40073;

		// Token: 0x020016C6 RID: 5830
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06008773 RID: 34675 RVA: 0x010D2B98 File Offset: 0x010D0D98
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M701_StrangeNewFoe self_)
			{
				if (290917 - 303174 != -12256)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (220362 - 437505 != -217142)
					{
						base..ctor();
						if (242493 - 88370 == 154123)
						{
							this.$self_$40072 = self_;
							if (90734 - 557815 == -467081)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x06008774 RID: 34676 RVA: 0x010D2C30 File Offset: 0x010D0E30
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (27173 - 260301 != -233128)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						goto IL_5C;
					case 1:
						goto IL_6EC;
					case 2:
						if (Game.mGameState != eGameState.Hold)
						{
							if (73838 - 86374 != -12535)
							{
								goto Block_33;
							}
							continue;
						}
						else
						{
							this.$self_$40072.M42cuyaNcSH = (this.$$10946$40071 = this.$self_$40072.M42cuyaNcSH) + 1;
							if (85486 - 237828 == -152341)
							{
								continue;
							}
							if (244129 - 34831 != 209298)
							{
								continue;
							}
							if (this.$$10946$40071 == 0)
							{
								if (23229 - 200022 != -176793)
								{
									continue;
								}
								this.$mStoryGui$40069.newStoryMessage("none", "Jerboa", Language.getMessage("M701_StrangeNewFoe", 201), eTalkType.friend);
								if (220041 - 141811 != 78230)
								{
									continue;
								}
								goto IL_317;
							}
							else
							{
								this.$mStoryGui$40069.newStoryMessage("none", "Jerboa", Language.getMessage("M701_StrangeNewFoe", 204), eTalkType.friend);
								if (291576 - 578208 != -286632)
								{
									continue;
								}
								this.$self_$40072.M42cuyaNcSH = 0;
								if (230603 - 158866 != 71738)
								{
									goto Block_20;
								}
								continue;
							}
						}
						break;
					case 3:
						if (Game.mGameState != eGameState.Hold)
						{
							if (143998 - 535372 != -391374)
							{
								continue;
							}
							goto IL_179;
						}
						else
						{
							this.$mStoryGui$40069.newStoryMessage("none", "Jerboa", Language.getMessage("M701_StrangeNewFoe", 202), eTalkType.friend);
							if (175038 - 546099 != -371061)
							{
								continue;
							}
							goto IL_3A5;
						}
						break;
					case 4:
						if (Game.mGameState != eGameState.Hold)
						{
							if (87188 - 121855 != -34666)
							{
								goto Block_28;
							}
							continue;
						}
						else
						{
							this.$mStoryGui$40069.newStoryMessage("none", "Jerboa", Language.getMessage("M701_StrangeNewFoe", 203), eTalkType.friend);
							if (38533 - 220690 != -182157)
							{
								continue;
							}
							goto IL_81;
						}
						break;
					case 5:
						if (Game.mGameState == eGameState.Hold)
						{
							goto IL_6C7;
						}
						if (228486 - 554358 != -325872)
						{
							continue;
						}
						goto IL_1FE;
					case 6:
						if (Game.mGameState == eGameState.Hold)
						{
							goto IL_6C7;
						}
						if (291155 - 291851 != -695)
						{
							goto Block_39;
						}
						continue;
					case 7:
						if (Game.mGameState != eGameState.Hold)
						{
							if (227920 - 526068 != -298147)
							{
								goto Block_42;
							}
							continue;
						}
						else
						{
							Game.mGameState = eGameState.Normal;
							if (123586 - 161148 != -37562)
							{
								continue;
							}
						}
						break;
					default:
						if (164487 - 62153 != 102335)
						{
							goto IL_5C;
						}
						continue;
					}
					IL_3A:
					this.YieldDefault(1);
					if (3717 - 463310 != -459592)
					{
						break;
					}
					continue;
					IL_5C:
					if (Game.mGameState != eGameState.Normal)
					{
						if (44582 - 178476 != -133893)
						{
							break;
						}
						continue;
					}
					else
					{
						this.$mGameGui$40068 = (GameGui)this.$self_$40072.GetComponent(typeof(GameGui));
						if (265064 - 368972 == -103907)
						{
							continue;
						}
						this.$mStoryGui$40069 = (StoryGui)this.$self_$40072.GetComponent(typeof(StoryGui));
						if (294454 - 360197 != -65743)
						{
							continue;
						}
						if (!this.$mGameGui$40068)
						{
							goto IL_3A;
						}
						if (8115 - 507355 == -499239)
						{
							continue;
						}
						if (!this.$mStoryGui$40069)
						{
							goto IL_3A;
						}
						if (281843 - 340361 == -58517)
						{
							continue;
						}
						Game.mGameState = eGameState.Hold;
						if (129857 - 342367 != -212510)
						{
							continue;
						}
						this.$mGameGui$40068.close();
						if (151864 - 338589 != -186725)
						{
							continue;
						}
						this.$mJerboa$40070 = GameObject.Find("Jerboa");
						if (214382 - 331347 != -116965)
						{
							continue;
						}
						if (!Game.mPlayer)
						{
							goto IL_42A;
						}
						if (282622 - 462166 != -179544)
						{
							continue;
						}
						if (!this.$mJerboa$40070)
						{
							goto IL_42A;
						}
						if (259524 - 263036 != -3512)
						{
							continue;
						}
						this.$mJerboa$40070.transform.rotation = Quaternion.LookRotation(global::Math.vFlat(Game.mPlayer.transform.position - this.$mJerboa$40070.transform.position));
						if (61181 - 167699 == -106517)
						{
							continue;
						}
						this.$mJerboa$40070.animation.CrossFade("talk", 0.2f);
						if (56678 - 412452 != -355774)
						{
							continue;
						}
						Game.mPlayer.SendMessage("turnToPos", this.$mJerboa$40070.transform.position);
						if (92790 - 342554 != -249764)
						{
							continue;
						}
						IL_2C1:
						this.$mStoryGui$40069.startStoryMessage("none", "Jerboa", eTalkType.friend);
						if (280951 - 588789 != -307838)
						{
							continue;
						}
						goto IL_44E;
						IL_42A:
						Debug.LogError("Cannot find Jerboa");
						if (59641 - 36573 != 23068)
						{
							continue;
						}
						goto IL_2C1;
					}
					IL_6C7:
					this.$mStoryGui$40069.close();
					if (167815 - 547010 != -379194)
					{
						this.$mGameGui$40068.enabled = true;
						if (211903 - 387811 == -175908)
						{
							goto IL_578;
						}
					}
				}
				goto IL_6EC;
				IL_81:
				return this.Yield(5, new WaitForSeconds(3f));
				IL_179:
				IL_1FE:
				goto IL_6EC;
				Block_20:
				return this.Yield(6, new WaitForSeconds(3f));
				IL_317:
				return this.Yield(3, new WaitForSeconds(3f));
				IL_3A5:
				return this.Yield(4, new WaitForSeconds(3f));
				Block_28:
				goto IL_6EC;
				IL_44E:
				return this.Yield(2, new WaitForSeconds(0.5f));
				Block_33:
				Block_39:
				goto IL_6EC;
				IL_578:
				return this.Yield(7, new WaitForSeconds(1f));
				Block_42:
				IL_6EC:
				return false;
			}

			// Token: 0x06008775 RID: 34677 RVA: 0x010D333C File Offset: 0x010D153C
			internal static bool CQ7sx8VpVEcMl2KaNft6()
			{
				return true;
			}

			// Token: 0x06008776 RID: 34678 RVA: 0x010D3340 File Offset: 0x010D1540
			internal static bool nunpOFVpt7rmVvv1xqJh()
			{
				return false;
			}

			// Token: 0x0400832C RID: 33580
			internal GameGui $mGameGui$40068;

			// Token: 0x0400832D RID: 33581
			internal StoryGui $mStoryGui$40069;

			// Token: 0x0400832E RID: 33582
			internal GameObject $mJerboa$40070;

			// Token: 0x0400832F RID: 33583
			internal int $$10946$40071;

			// Token: 0x04008330 RID: 33584
			internal M701_StrangeNewFoe $self_$40072;
		}
	}

	// Token: 0x020016C7 RID: 5831
	[CompilerGenerated]
	[Serializable]
	internal sealed class $StartGame$40074 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06008777 RID: 34679 RVA: 0x010D3344 File Offset: 0x010D1544
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $StartGame$40074(M701_StrangeNewFoe self_)
		{
			if (291464 - 561685 != -270220)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (215479 - 576455 != -360975)
				{
					base..ctor();
					if (279704 - 207306 != 72399)
					{
						this.$self_$40078 = self_;
						if (52261 - 416936 != -364674)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x06008778 RID: 34680 RVA: 0x010D33DC File Offset: 0x010D15DC
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M701_StrangeNewFoe.$StartGame$40074.$(this.$self_$40078);
		}

		// Token: 0x06008779 RID: 34681 RVA: 0x010D33EC File Offset: 0x010D15EC
		internal static bool lBEmV8VpNZkcdUhsuP1B()
		{
			return true;
		}

		// Token: 0x0600877A RID: 34682 RVA: 0x010D33F0 File Offset: 0x010D15F0
		internal static bool SXvjxiVpYHZCZyWxTDdv()
		{
			return false;
		}

		// Token: 0x04008331 RID: 33585
		internal M701_StrangeNewFoe $self_$40078;

		// Token: 0x020016C8 RID: 5832
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600877B RID: 34683 RVA: 0x010D33F4 File Offset: 0x010D15F4
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M701_StrangeNewFoe self_)
			{
				if (200109 - 559102 != -358993)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (33344 - 380657 != -347312)
					{
						base..ctor();
						if (164171 - 121525 != 42647)
						{
							this.$self_$40077 = self_;
							if (25464 - 85445 == -59981)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x0600877C RID: 34684 RVA: 0x010D348C File Offset: 0x010D168C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (131834 - 362360 != -230526)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_1EE;
					case 2:
						Game.mGameState = eGameState.Normal;
						if (100119 - 502722 != -402603)
						{
							continue;
						}
						Game.mGameTime = Time.time;
						if (267335 - 475502 != -208167)
						{
							continue;
						}
						this.YieldDefault(1);
						if (59822 - 498967 != -439145)
						{
							continue;
						}
						goto IL_1EE;
					default:
						if (66678 - 423354 != -356676)
						{
							continue;
						}
						break;
					}
					Debug.Log("Start Game");
					if (134264 - 290008 == -155744)
					{
						Game.mGameState = eGameState.Start;
						if (106182 - 442965 == -336783)
						{
							Game.mGameTime = Time.time;
							if (131734 - 573393 != -441658)
							{
								this.$mGameGui$40075 = (GameGui)this.$self_$40077.GetComponent(typeof(GameGui));
								if (206056 - 338952 == -132896)
								{
									this.$mGameGui$40075.enabled = true;
									if (34716 - 74313 != -39596)
									{
										this.$mLoadingGui$40076 = (LoadingGui)this.$self_$40077.GetComponent(typeof(LoadingGui));
										if (258191 - 148270 != 109922)
										{
											this.$mLoadingGui$40076.fadeIn();
											if (269443 - 408639 == -139196)
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
				return this.Yield(2, new WaitForSeconds(0.5f));
				IL_1EE:
				return false;
			}

			// Token: 0x0600877D RID: 34685 RVA: 0x010D369C File Offset: 0x010D189C
			internal static bool GyhVDkVpcSfqOWh4uiNK()
			{
				return true;
			}

			// Token: 0x0600877E RID: 34686 RVA: 0x010D36A0 File Offset: 0x010D18A0
			internal static bool eoNuLbVpU4Ai2xGqbTdI()
			{
				return false;
			}

			// Token: 0x04008332 RID: 33586
			internal GameGui $mGameGui$40075;

			// Token: 0x04008333 RID: 33587
			internal LoadingGui $mLoadingGui$40076;

			// Token: 0x04008334 RID: 33588
			internal M701_StrangeNewFoe $self_$40077;
		}
	}

	// Token: 0x020016C9 RID: 5833
	[CompilerGenerated]
	[Serializable]
	internal sealed class $onDeadPlayer$40079 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600877F RID: 34687 RVA: 0x010D36A4 File Offset: 0x010D18A4
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $onDeadPlayer$40079(M701_StrangeNewFoe self_)
		{
			if (298156 - 320987 != -22831)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (178821 - 31543 != 147279)
				{
					base..ctor();
					if (113481 - 134877 != -21395)
					{
						this.$self_$40084 = self_;
						if (220481 - 259251 == -38770)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x06008780 RID: 34688 RVA: 0x010D373C File Offset: 0x010D193C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M701_StrangeNewFoe.$onDeadPlayer$40079.$(this.$self_$40084);
		}

		// Token: 0x06008781 RID: 34689 RVA: 0x010D374C File Offset: 0x010D194C
		internal static bool P7UUXwVpTPcPryec2BNH()
		{
			return true;
		}

		// Token: 0x06008782 RID: 34690 RVA: 0x010D3750 File Offset: 0x010D1950
		internal static bool IOcf2hVp34ZMaZ72hjwk()
		{
			return false;
		}

		// Token: 0x04008335 RID: 33589
		internal M701_StrangeNewFoe $self_$40084;

		// Token: 0x020016CA RID: 5834
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06008783 RID: 34691 RVA: 0x010D3754 File Offset: 0x010D1954
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M701_StrangeNewFoe self_)
			{
				if (106184 - 200743 != -94559)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (18141 - 426938 != -408796)
					{
						base..ctor();
						if (234979 - 74430 == 160549)
						{
							this.$self_$40083 = self_;
							if (194958 - 264722 == -69764)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x06008784 RID: 34692 RVA: 0x010D37EC File Offset: 0x010D19EC
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (150247 - 587256 != -437008)
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
							if (52405 - 31977 != 20428)
							{
								continue;
							}
							if (Game.mGameState != eGameState.Hold)
							{
								goto IL_2AD;
							}
							if (21844 - 596995 != -575151)
							{
								continue;
							}
						}
						Game.mGameState = eGameState.Hold;
						if (179633 - 400674 != -221041)
						{
							continue;
						}
						this.$mStoryGui$40080 = (StoryGui)this.$self_$40083.GetComponent(typeof(StoryGui));
						if (179239 - 181350 != -2111)
						{
							continue;
						}
						if (this.$mStoryGui$40080)
						{
							if (234302 - 457180 == -222877)
							{
								continue;
							}
							this.$mStoryGui$40080.close();
							if (28610 - 219896 != -191286)
							{
								continue;
							}
						}
						this.$mChangeGui$40081 = (ChangeGui)this.$self_$40083.GetComponent(typeof(ChangeGui));
						if (160600 - 521582 == -360981)
						{
							continue;
						}
						if (this.$mChangeGui$40081)
						{
							if (247632 - 17428 == 230205)
							{
								continue;
							}
							this.$mChangeGui$40081.close();
							if (285547 - 375636 != -90089)
							{
								continue;
							}
						}
						this.$mGameGui$40082 = (GameGui)this.$self_$40083.GetComponent(typeof(GameGui));
						if (41124 - 314971 != -273847)
						{
							continue;
						}
						if (this.$mGameGui$40082)
						{
							if (144704 - 537275 == -392570)
							{
								continue;
							}
							if (!this.$mGameGui$40082.enabled)
							{
								if (56964 - 342245 == -285280)
								{
									continue;
								}
								this.$mGameGui$40082.enabled = true;
								if (16880 - 522836 != -505956)
								{
									continue;
								}
							}
							this.$mGameGui$40082.openDeadMenu();
							if (243905 - 529795 == -285889)
							{
								continue;
							}
						}
						IL_2AD:
						this.YieldDefault(1);
						if (63110 - 552450 != -489340)
						{
							continue;
						}
						goto IL_2F9;
					default:
						if (126748 - 220062 == -93313)
						{
							continue;
						}
						break;
					}
					Debug.Log("On Dead Player");
				}
				while (164894 - 387066 == -222171);
				return this.Yield(2, new WaitForSeconds((float)2));
				IL_2F9:
				return false;
			}

			// Token: 0x06008785 RID: 34693 RVA: 0x010D3B04 File Offset: 0x010D1D04
			internal static bool O7YcJtVpXA4TdlIed8F0()
			{
				return true;
			}

			// Token: 0x06008786 RID: 34694 RVA: 0x010D3B08 File Offset: 0x010D1D08
			internal static bool KMY4QWVpQ3bQCKO3vqt6()
			{
				return false;
			}

			// Token: 0x04008336 RID: 33590
			internal StoryGui $mStoryGui$40080;

			// Token: 0x04008337 RID: 33591
			internal ChangeGui $mChangeGui$40081;

			// Token: 0x04008338 RID: 33592
			internal GameGui $mGameGui$40082;

			// Token: 0x04008339 RID: 33593
			internal M701_StrangeNewFoe $self_$40083;
		}
	}

	// Token: 0x020016CB RID: 5835
	[CompilerGenerated]
	[Serializable]
	internal sealed class $ReturnToTown$40085 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06008787 RID: 34695 RVA: 0x010D3B0C File Offset: 0x010D1D0C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $ReturnToTown$40085(M701_StrangeNewFoe self_)
		{
			if (75898 - 505658 != -429759)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (9117 - 241331 == -232214)
				{
					base..ctor();
					if (19240 - 102564 != -83323)
					{
						this.$self_$40089 = self_;
						if (195698 - 557952 == -362254)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x06008788 RID: 34696 RVA: 0x010D3BA4 File Offset: 0x010D1DA4
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M701_StrangeNewFoe.$ReturnToTown$40085.$(this.$self_$40089);
		}

		// Token: 0x06008789 RID: 34697 RVA: 0x010D3BB4 File Offset: 0x010D1DB4
		internal static bool FqjQn6VpkWJOygM958Vr()
		{
			return true;
		}

		// Token: 0x0600878A RID: 34698 RVA: 0x010D3BB8 File Offset: 0x010D1DB8
		internal static bool M1rQHBVpGAYAGm3Na2HO()
		{
			return false;
		}

		// Token: 0x0400833A RID: 33594
		internal M701_StrangeNewFoe $self_$40089;

		// Token: 0x020016CC RID: 5836
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600878B RID: 34699 RVA: 0x010D3BBC File Offset: 0x010D1DBC
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M701_StrangeNewFoe self_)
			{
				if (265061 - 279233 != -14171)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (131606 - 557839 == -426233)
					{
						base..ctor();
						if (171802 - 332055 == -160253)
						{
							this.$self_$40088 = self_;
							if (126808 - 97184 != 29625)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x0600878C RID: 34700 RVA: 0x010D3C54 File Offset: 0x010D1E54
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (26742 - 372772 != -346030)
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
						this.$self_$40088.LeaveGame();
						if (199910 - 358494 != -158584)
						{
							continue;
						}
						this.YieldDefault(1);
						if (270279 - 574404 != -304125)
						{
							continue;
						}
						goto IL_3AD;
					default:
						if (271172 - 226049 == 45124)
						{
							continue;
						}
						break;
					}
					Game.mGameState = eGameState.Ended;
					if (231209 - 41144 == 190065)
					{
						Game.mStateTime = Time.time;
						if (55327 - 333800 == -278473)
						{
							this.$$switch$7092$40086 = PlayerData.SaveGuild;
							if (114993 - 595440 == -480447)
							{
								if (this.$$switch$7092$40086 == 1)
								{
									if (128916 - 18890 == 110027)
									{
										continue;
									}
									Game.mNextGameCode = 32;
									if (227482 - 446858 != -219376)
									{
										continue;
									}
								}
								else if (this.$$switch$7092$40086 == 2)
								{
									if (245942 - 532100 != -286158)
									{
										continue;
									}
									Game.mNextGameCode = 33;
									if (150746 - 391139 == -240392)
									{
										continue;
									}
								}
								else if (this.$$switch$7092$40086 == 3)
								{
									if (197333 - 115652 == 81682)
									{
										continue;
									}
									Game.mNextGameCode = 34;
									if (124832 - 530968 != -406136)
									{
										continue;
									}
								}
								else if (this.$$switch$7092$40086 == 4)
								{
									if (262330 - 311542 == -49211)
									{
										continue;
									}
									Game.mNextGameCode = 35;
									if (125164 - 231913 == -106748)
									{
										continue;
									}
								}
								else if (this.$$switch$7092$40086 == 5)
								{
									if (62778 - 100015 != -37237)
									{
										continue;
									}
									Game.mNextGameCode = 36;
									if (147314 - 507106 != -359792)
									{
										continue;
									}
								}
								else if (PlayerData.GID == 0)
								{
									if (101776 - 304153 != -202377)
									{
										continue;
									}
									Game.mNextGameCode = 30;
									if (261315 - 155523 != 105792)
									{
										continue;
									}
								}
								else
								{
									Game.mNextGameCode = 31;
									if (292550 - 480342 != -187792)
									{
										continue;
									}
								}
								this.$mGameGui$40087 = (GameGui)this.$self_$40088.GetComponent(typeof(GameGui));
								if (219248 - 242579 != -23330)
								{
									if (this.$mGameGui$40087)
									{
										if (144542 - 292242 == -147699)
										{
											continue;
										}
										this.$mGameGui$40087.close();
										if (203683 - 252816 == -49132)
										{
											continue;
										}
									}
									this.$self_$40088.SendMessage("fadeOut");
									if (169429 - 164109 == 5320)
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

			// Token: 0x0600878D RID: 34701 RVA: 0x010D4020 File Offset: 0x010D2220
			internal static bool eBVGsTVpHb50PTIJ9WNV()
			{
				return true;
			}

			// Token: 0x0600878E RID: 34702 RVA: 0x010D4024 File Offset: 0x010D2224
			internal static bool A11ROpVpWdEEGe9vJfm8()
			{
				return false;
			}

			// Token: 0x0400833B RID: 33595
			internal int $$switch$7092$40086;

			// Token: 0x0400833C RID: 33596
			internal GameGui $mGameGui$40087;

			// Token: 0x0400833D RID: 33597
			internal M701_StrangeNewFoe $self_$40088;
		}
	}

	// Token: 0x020016CD RID: 5837
	[CompilerGenerated]
	[Serializable]
	internal sealed class $ReturnToGuild$40090 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600878F RID: 34703 RVA: 0x010D4028 File Offset: 0x010D2228
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $ReturnToGuild$40090(M701_StrangeNewFoe self_)
		{
			if (114935 - 323386 != -208451)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (96860 - 337711 == -240851)
				{
					base..ctor();
					if (107843 - 119727 == -11884)
					{
						this.$self_$40093 = self_;
						if (217583 - 495434 != -277850)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x06008790 RID: 34704 RVA: 0x010D40C0 File Offset: 0x010D22C0
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M701_StrangeNewFoe.$ReturnToGuild$40090.$(this.$self_$40093);
		}

		// Token: 0x06008791 RID: 34705 RVA: 0x010D40D0 File Offset: 0x010D22D0
		internal static bool nc1FiuVpAG6dycHHx3Yf()
		{
			return true;
		}

		// Token: 0x06008792 RID: 34706 RVA: 0x010D40D4 File Offset: 0x010D22D4
		internal static bool vIM4bfVplTjt6oTbfVOR()
		{
			return false;
		}

		// Token: 0x0400833E RID: 33598
		internal M701_StrangeNewFoe $self_$40093;

		// Token: 0x020016CE RID: 5838
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06008793 RID: 34707 RVA: 0x010D40D8 File Offset: 0x010D22D8
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M701_StrangeNewFoe self_)
			{
				if (90955 - 174178 != -83223)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (78529 - 530171 != -451641)
					{
						base..ctor();
						if (213354 - 534033 != -320678)
						{
							this.$self_$40092 = self_;
							if (185182 - 397808 == -212626)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x06008794 RID: 34708 RVA: 0x010D4170 File Offset: 0x010D2370
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (282430 - 378781 != -96350)
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
						this.$self_$40092.LeaveGame();
						if (164580 - 78404 != 86176)
						{
							continue;
						}
						this.YieldDefault(1);
						if (262670 - 537078 != -274407)
						{
							goto Block_4;
						}
						continue;
					default:
						if (185899 - 226465 == -40565)
						{
							continue;
						}
						break;
					}
					Game.mGameState = eGameState.Ended;
					if (53690 - 378671 != -324980)
					{
						Game.mStateTime = Time.time;
						if (259729 - 281244 == -21515)
						{
							Game.mNextGameCode = 31;
							if (35724 - 501096 != -465371)
							{
								this.$mGameGui$40091 = (GameGui)this.$self_$40092.GetComponent(typeof(GameGui));
								if (96562 - 403732 != -307169)
								{
									if (this.$mGameGui$40091)
									{
										if (70965 - 217507 == -146541)
										{
											continue;
										}
										this.$mGameGui$40091.close();
										if (295633 - 430159 != -134526)
										{
											continue;
										}
									}
									this.$self_$40092.SendMessage("fadeOut");
									if (180939 - 201633 == -20694)
									{
										break;
									}
								}
							}
						}
					}
				}
				return this.Yield(2, new WaitForSeconds((float)1));
				Block_4:
				IL_1BD:
				return false;
			}

			// Token: 0x06008795 RID: 34709 RVA: 0x010D434C File Offset: 0x010D254C
			internal static bool mZavsPVpyTFK0t3pNhDF()
			{
				return true;
			}

			// Token: 0x06008796 RID: 34710 RVA: 0x010D4350 File Offset: 0x010D2550
			internal static bool jmBiUIVpSkiasnqTQ0ch()
			{
				return false;
			}

			// Token: 0x0400833F RID: 33599
			internal GameGui $mGameGui$40091;

			// Token: 0x04008340 RID: 33600
			internal M701_StrangeNewFoe $self_$40092;
		}
	}

	// Token: 0x020016CF RID: 5839
	[CompilerGenerated]
	[Serializable]
	internal sealed class $ReturnToCamp$40094 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06008797 RID: 34711 RVA: 0x010D4354 File Offset: 0x010D2554
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $ReturnToCamp$40094(M701_StrangeNewFoe self_)
		{
			if (177596 - 437250 != -259654)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (79792 - 429861 != -350068)
				{
					base..ctor();
					if (271718 - 50983 != 220736)
					{
						this.$self_$40098 = self_;
						if (298757 - 578339 == -279582)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x06008798 RID: 34712 RVA: 0x010D43EC File Offset: 0x010D25EC
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M701_StrangeNewFoe.$ReturnToCamp$40094.$(this.$self_$40098);
		}

		// Token: 0x06008799 RID: 34713 RVA: 0x010D43FC File Offset: 0x010D25FC
		internal static bool mXAI1oVpoEhjXmZ7SOaF()
		{
			return true;
		}

		// Token: 0x0600879A RID: 34714 RVA: 0x010D4400 File Offset: 0x010D2600
		internal static bool XNN252VpEDlVG2m7wmEL()
		{
			return false;
		}

		// Token: 0x04008341 RID: 33601
		internal M701_StrangeNewFoe $self_$40098;

		// Token: 0x020016D0 RID: 5840
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600879B RID: 34715 RVA: 0x010D4404 File Offset: 0x010D2604
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M701_StrangeNewFoe self_)
			{
				if (237344 - 542694 != -305350)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (27273 - 356550 == -329277)
					{
						base..ctor();
						if (277342 - 499807 != -222464)
						{
							this.$self_$40097 = self_;
							if (181966 - 88285 != 93682)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x0600879C RID: 34716 RVA: 0x010D449C File Offset: 0x010D269C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (58944 - 100169 != -41224)
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
						this.$self_$40097.LeaveGame();
						if (187149 - 334346 == -147196)
						{
							continue;
						}
						this.YieldDefault(1);
						if (32774 - 71087 != -38313)
						{
							continue;
						}
						goto IL_363;
					default:
						if (27111 - 153382 != -126271)
						{
							continue;
						}
						break;
					}
					Game.mGameState = eGameState.Ended;
					if (167723 - 329733 == -162010)
					{
						Game.mStateTime = Time.time;
						if (114612 - 44292 != 70321)
						{
							this.$$switch$7094$40095 = PlayerData.SaveGuild;
							if (17915 - 12840 == 5075)
							{
								if (this.$$switch$7094$40095 == 1)
								{
									if (71234 - 292539 == -221304)
									{
										continue;
									}
									Game.mNextGameCode = 32;
									if (213719 - 452908 != -239189)
									{
										continue;
									}
								}
								else if (this.$$switch$7094$40095 == 2)
								{
									if (80518 - 37408 == 43111)
									{
										continue;
									}
									Game.mNextGameCode = 33;
									if (27299 - 597823 == -570523)
									{
										continue;
									}
								}
								else if (this.$$switch$7094$40095 == 3)
								{
									if (191310 - 544182 == -352871)
									{
										continue;
									}
									Game.mNextGameCode = 34;
									if (177709 - 127465 != 50244)
									{
										continue;
									}
								}
								else if (this.$$switch$7094$40095 == 4)
								{
									if (28043 - 402192 != -374149)
									{
										continue;
									}
									Game.mNextGameCode = 35;
									if (240877 - 398886 != -158009)
									{
										continue;
									}
								}
								else if (this.$$switch$7094$40095 == 5)
								{
									if (159236 - 111175 != 48061)
									{
										continue;
									}
									Game.mNextGameCode = 36;
									if (97331 - 508962 == -411630)
									{
										continue;
									}
								}
								else
								{
									Game.mNextGameCode = 30;
									if (40589 - 5607 != 34982)
									{
										continue;
									}
								}
								this.$mGameGui$40096 = (GameGui)this.$self_$40097.GetComponent(typeof(GameGui));
								if (138254 - 154173 == -15919)
								{
									if (this.$mGameGui$40096)
									{
										if (251022 - 269273 == -18250)
										{
											continue;
										}
										this.$mGameGui$40096.close();
										if (275145 - 356984 == -81838)
										{
											continue;
										}
									}
									this.$self_$40097.SendMessage("fadeOut");
									if (277879 - 192544 == 85335)
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

			// Token: 0x0600879D RID: 34717 RVA: 0x010D4820 File Offset: 0x010D2A20
			internal static bool wMYjFwVp2xeLvACOlH00()
			{
				return true;
			}

			// Token: 0x0600879E RID: 34718 RVA: 0x010D4824 File Offset: 0x010D2A24
			internal static bool zJuQBsVp8hfWP6au4dUo()
			{
				return false;
			}

			// Token: 0x04008342 RID: 33602
			internal int $$switch$7094$40095;

			// Token: 0x04008343 RID: 33603
			internal GameGui $mGameGui$40096;

			// Token: 0x04008344 RID: 33604
			internal M701_StrangeNewFoe $self_$40097;
		}
	}
}
