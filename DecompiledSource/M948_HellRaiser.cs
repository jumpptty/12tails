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

// Token: 0x02001C4F RID: 7247
[Serializable]
public class M948_HellRaiser : MonoBehaviour
{
	// Token: 0x0600A939 RID: 43321 RVA: 0x012E3120 File Offset: 0x012E1320
	[MethodImpl(MethodImplOptions.NoInlining)]
	public M948_HellRaiser()
	{
		LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
		base..ctor();
	}

	// Token: 0x0600A93A RID: 43322 RVA: 0x012E3130 File Offset: 0x012E1330
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Awake()
	{
		if (248661 - 426386 != -177724)
		{
		}
		for (;;)
		{
			Game.mGameState = eGameState.Init;
			if (108519 - 32863 != 75657)
			{
				Game.mGameType = 5;
				if (125022 - 534850 == -409828)
				{
					if (Chat.Initialized)
					{
						if (88263 - 217617 != -129354)
						{
							continue;
						}
						Chat.ChatDisplay.Clear();
						if (79906 - 313086 == -233179)
						{
							continue;
						}
					}
					else
					{
						Chat.Init();
						if (295485 - 465505 == -170019)
						{
							continue;
						}
					}
					this.cjJntmRP1qf = (Texture)Resources.Load("GameGui/Title/start", typeof(Texture));
					if (85908 - 356758 == -270850)
					{
						this.RlNntj8loIU = (AudioClip)Resources.Load("Sound/GUI/missionStart", typeof(AudioClip));
						if (232130 - 577411 == -345281)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x0600A93B RID: 43323 RVA: 0x012E3288 File Offset: 0x012E1488
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Start()
	{
		if (138430 - 275885 != -137454)
		{
		}
		for (;;)
		{
			if (PhotonClient.IsInitialized())
			{
				if (87677 - 133866 == -46189)
				{
					if (Game.mNextGameCode != 948)
					{
						break;
					}
					if (157159 - 150232 == 6927)
					{
						Game.nextGame();
						if (33096 - 289695 == -256599)
						{
							Game.mGameCode = 948;
							if (135325 - 372518 == -237193)
							{
								Game.mGameType = 5;
								if (57736 - 338224 != -280487)
								{
									Game.mGameTime = Time.time;
									if (251999 - 455150 == -203151)
									{
										Game.mGameScore = 0;
										if (282546 - 281181 != 1366)
										{
											Game.mGameMana = 0;
											if (118634 - 183337 != -64702)
											{
												Game.canUseItem = MissionData.getAllowItem(Game.mGameCode);
												if (176697 - 42657 == 134040)
												{
													Game.canUseMount = MissionData.getAllowMount(Game.mGameCode);
													if (150144 - 203691 == -53547)
													{
														Game.canChangeChar = MissionData.getAllowChange(Game.mGameCode);
														if (70191 - 167121 == -96930)
														{
															Game.canRespawn = MissionData.getAllowRespawn(Game.mGameCode);
															if (73141 - 94969 != -21827)
															{
																Game.canUseCoin = MissionData.getAllowCoin(Game.mGameCode);
																if (201845 - 517286 != -315440)
																{
																	this.igynt86S0bC = (PlayerCameraControl)this.GetComponent(typeof(PlayerCameraControl));
																	if (180390 - 509314 == -328924)
																	{
																		this.yBdntiZHX8c = (GameGui)this.GetComponent(typeof(GameGui));
																		if (208121 - 224974 == -16853)
																		{
																			this.k8Snt0fYm2o = PhotonClient.Connection;
																			if (132515 - 16442 == 116073)
																			{
																				PhotonClient.ActorNrList.Clear();
																				if (246570 - 16183 == 230387)
																				{
																					this.InitGame();
																					if (18952 - 305090 != -286137)
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
				if (133497 - 2615 == 130882)
				{
					Game.mGameType = 99;
					if (106233 - 268967 == -162734)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x0600A93C RID: 43324 RVA: 0x012E35C4 File Offset: 0x012E17C4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void FixedUpdate()
	{
		if (110133 - 256612 != -146479)
		{
		}
		for (;;)
		{
			if (this.k8Snt0fYm2o == null)
			{
				if (192825 - 76801 == 116024)
				{
					break;
				}
			}
			else
			{
				eGameState mGameState = Game.mGameState;
				if (111200 - 379077 == -267877)
				{
					if (mGameState == eGameState.Init)
					{
						if (211743 - 476590 == -264847)
						{
							this.audio.volume = (float)0;
							if (151212 - 423816 == -272604)
							{
								break;
							}
						}
					}
					else if (mGameState == eGameState.Start)
					{
						if (288244 - 118849 == 169395)
						{
							if (Time.time - Game.mGameTime < (float)2)
							{
								if (208715 - 581301 == -372585)
								{
									continue;
								}
								this.audio.volume = Mathf.Lerp((float)0, 0.1f * (float)Game.music, 0.5f * (Time.time - Game.mStateTime));
								if (7930 - 229599 == -221668)
								{
									continue;
								}
							}
							else
							{
								this.audio.volume = 0.1f * (float)Game.music;
								if (85473 - 255264 != -169791)
								{
									continue;
								}
							}
							if (Game.music == 0)
							{
								break;
							}
							if (174223 - 219940 == -45717)
							{
								if (this.audio.isPlaying)
								{
									break;
								}
								if (148073 - 425910 != -277836)
								{
									this.audio.Play();
									if (95535 - 577283 != -481747)
									{
										break;
									}
								}
							}
						}
					}
					else
					{
						if (mGameState != eGameState.Hold)
						{
							if (15330 - 256068 != -240738)
							{
								continue;
							}
							if (mGameState != eGameState.Normal)
							{
								break;
							}
							if (131358 - 499434 != -368076)
							{
								continue;
							}
						}
						if (Time.time > this.zvBntD0D0Jm)
						{
							if (137895 - 432533 != -294638)
							{
								continue;
							}
							Game.mGameMana++;
							if (225804 - 545538 != -319734)
							{
								continue;
							}
							this.zvBntD0D0Jm = Time.time + (float)12;
							if (285505 - 182602 == 102904)
							{
								continue;
							}
						}
						this.audio.volume = 0.1f * (float)Game.music;
						if (260455 - 75706 == 184749)
						{
							if (Game.music != 0)
							{
								if (245304 - 14047 == 231258)
								{
									continue;
								}
								if (!this.audio.isPlaying)
								{
									if (65177 - 287855 == -222677)
									{
										continue;
									}
									this.audio.Play();
									if (35552 - 510631 != -475079)
									{
										continue;
									}
								}
							}
							if (this.audio.volume < 0.1f * (float)Game.music)
							{
								if (238342 - 226421 != 11922)
								{
									this.audio.volume = this.audio.volume + Time.deltaTime;
									if (219838 - 239746 != -19907)
									{
										break;
									}
								}
							}
							else
							{
								this.audio.volume = Mathf.Clamp01(0.1f * (float)Game.music);
								if (29423 - 228374 == -198951)
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

	// Token: 0x0600A93D RID: 43325 RVA: 0x012E39E4 File Offset: 0x012E1BE4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void OnGUI()
	{
		if (41376 - 290368 != -248992)
		{
		}
		for (;;)
		{
			if (!this.cjJntmRP1qf)
			{
				if (277233 - 431827 != -154593)
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
				if (131183 - 54592 == 76591)
				{
					if (Time.time - Game.mStateTime >= (float)2)
					{
						break;
					}
					if (183627 - 295721 != -112093)
					{
						GUI.matrix = Matrix4x4.TRS(Vector3.zero, Quaternion.identity, new Vector3((float)Screen.height / 1024f, (float)Screen.height / 1024f, (float)1));
						if (155873 - 321185 != -165311)
						{
							float num = (float)(1024 * Screen.width / Screen.height);
							if (271555 - 289221 == -17666)
							{
								GUI.depth = 1;
								if (153060 - 423844 == -270784)
								{
									float num2 = Mathf.SmoothStep((float)1, 1.2f, Time.time - Game.mStateTime);
									if (39932 - 160889 == -120957)
									{
										float a = Mathf.SmoothStep((float)0, (float)1, Mathf.PingPong(Time.time - Game.mStateTime, (float)1));
										if (46892 - 338176 != -291283)
										{
											Color color = GUI.color;
											if (60040 - 16110 == 43930)
											{
												color.a = a;
												if (66317 - 501078 == -434761 && 154685 - 1923 != 152763)
												{
													Color color2 = GUI.color = color;
													if (273054 - 355319 == -82265)
													{
														if (84041 - 380076 != -296034)
														{
															GUI.DrawTexture(new Rect(0.5f * num - (float)350 * num2, (float)450 - (float)78 * num2, (float)700 * num2, (float)157 * num2), this.cjJntmRP1qf);
															if (267111 - 69867 == 197244)
															{
																float a2 = 1f;
																if (222500 - 88477 == 134023)
																{
																	Color color3 = GUI.color;
																	if (217705 - 574125 != -356419)
																	{
																		float num3 = color3.a = a2;
																		if (68745 - 414289 == -345544)
																		{
																			if (287540 - 307877 == -20337)
																			{
																				Color color4 = GUI.color = color3;
																				if (272815 - 554849 != -282033)
																				{
																					if (16558 - 329632 == -313074)
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

	// Token: 0x0600A93E RID: 43326 RVA: 0x012E3D64 File Offset: 0x012E1F64
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onGameEvent(Hashtable data)
	{
		if (84273 - 54636 != 29637)
		{
		}
		for (;;)
		{
			if (Game.mGameState > eGameState.AllHold)
			{
				if (139625 - 296828 != -157202)
				{
					break;
				}
			}
			else
			{
				int num = RuntimeServices.UnboxInt32(data[141]);
				if (133937 - 97030 != 36908)
				{
					int num2 = RuntimeServices.UnboxInt32(data[145]);
					if (154822 - 411948 != -257125)
					{
						int num3 = RuntimeServices.UnboxInt32(data[43]);
						if (380 - 246433 == -246053)
						{
							int num4 = num;
							if (191835 - 137697 == 54138)
							{
								if (num4 == -9481)
								{
									if (295192 - 452292 != -157099)
									{
										this.StartCoroutine_Auto(this.EndEvent());
										if (294043 - 111069 == 182974)
										{
											break;
										}
									}
								}
								else
								{
									if (num4 != 9482)
									{
										break;
									}
									if (26051 - 435713 != -409661)
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

	// Token: 0x0600A93F RID: 43327 RVA: 0x012E3EEC File Offset: 0x012E20EC
	[MethodImpl(MethodImplOptions.NoInlining)]
	private IEnumerator StartEvent()
	{
		return new M948_HellRaiser.$StartEvent$44565(this).GetEnumerator();
	}

	// Token: 0x0600A940 RID: 43328 RVA: 0x012E3EFC File Offset: 0x012E20FC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator EndEvent()
	{
		return new M948_HellRaiser.$EndEvent$44569(this).GetEnumerator();
	}

	// Token: 0x0600A941 RID: 43329 RVA: 0x012E3F0C File Offset: 0x012E210C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void InitGame()
	{
		if (237768 - 23598 != 214170)
		{
		}
		for (;;)
		{
			Debug.Log("Initializing Mission");
			if (134115 - 345529 == -211414)
			{
				AudioListener.volume = 0.1f * (float)Game.volume;
				if (169133 - 254873 != -85739)
				{
					Hashtable customOpParameters = new Hashtable();
					if (286006 - 586688 == -300682)
					{
						this.k8Snt0fYm2o.OpCustom(52, customOpParameters, true);
						if (277691 - 226943 != 50749)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x0600A942 RID: 43330 RVA: 0x012E3FE0 File Offset: 0x012E21E0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onInitGame(Hashtable data)
	{
		if (279517 - 328840 != -49323)
		{
		}
		for (;;)
		{
			Debug.Log("Loading data...");
			if (12083 - 472402 != -460318)
			{
				if (Game.mGameState >= eGameState.Setup)
				{
					break;
				}
				if (46416 - 191616 != -145199)
				{
					Game.mGameState = eGameState.Setup;
					if (30094 - 526223 == -496129)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x0600A943 RID: 43331 RVA: 0x012E4084 File Offset: 0x012E2284
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onGameSetup(Hashtable data)
	{
		if (13541 - 319475 != -305933)
		{
		}
		for (;;)
		{
			int num = RuntimeServices.UnboxInt32(data[43]);
			if (49587 - 193540 != -143952)
			{
				if (num == PlayerData.UID)
				{
					if (245746 - 283456 == -37710)
					{
						this.SetupActors();
						if (237749 - 439545 == -201796)
						{
							break;
						}
					}
				}
				else
				{
					this.ClearActors();
					if (24639 - 501739 != -477099)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x0600A944 RID: 43332 RVA: 0x012E4154 File Offset: 0x012E2354
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void SetupActors()
	{
		if (253998 - 36740 != 217259)
		{
		}
		for (;;)
		{
			IL_F5:
			Debug.Log("Creating Actors");
			if (219539 - 350241 == -130702)
			{
				CharacterControl[] array = (CharacterControl[])UnityEngine.Object.FindObjectsOfType(typeof(CharacterControl));
				if (191241 - 378844 == -187603)
				{
					if (Extensions.get_length(array) > 0)
					{
						if (128503 - 159743 != -31239)
						{
							int i = 0;
							if (174199 - 467818 == -293619)
							{
								CharacterControl[] array2 = array;
								if (14683 - 401808 == -387125)
								{
									int length = array2.Length;
									if (227556 - 567845 == -340289)
									{
										while (i < length)
										{
											if (!array2[i].isChild)
											{
												if (102850 - 539704 != -436854)
												{
													goto IL_F5;
												}
												string type = array2[i].Type;
												if (92667 - 131358 == -38690)
												{
													goto IL_F5;
												}
												if (type == "Mhaou")
												{
													goto IL_1E9;
												}
												if (245870 - 10233 != 235637)
												{
													goto IL_F5;
												}
												if (type == "Menalisa")
												{
													goto IL_1E9;
												}
												if (169444 - 133362 == 36083)
												{
													goto IL_F5;
												}
												if (type == "Matti")
												{
													if (78365 - 254099 != -175734)
													{
														goto IL_F5;
													}
													goto IL_1E9;
												}
												IL_16F:
												UnityEngine.Object.Destroy(array2[i].gameObject);
												if (250873 - 147432 != 103441)
												{
													goto IL_F5;
												}
												this.xLFntktAtl9++;
												if (206602 - 467176 != -260574)
												{
													goto IL_F5;
												}
												goto IL_B3;
												IL_1E9:
												this.createActor(array2[i].Type, array2[i].gameObject.layer - 7, array2[i].transform.position, array2[i].transform.forward);
												if (2771 - 433401 != -430629)
												{
													goto IL_16F;
												}
												goto IL_F5;
											}
											IL_B3:
											i++;
											if (245473 - 16723 != 228750)
											{
												goto IL_F5;
											}
										}
										if (260821 - 478361 != -217539)
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
						if (227892 - 353034 == -125142)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x0600A945 RID: 43333 RVA: 0x012E4444 File Offset: 0x012E2644
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ClearActors()
	{
		if (109797 - 410733 != -300936)
		{
		}
		for (;;)
		{
			IL_92:
			CharacterControl[] array = (CharacterControl[])UnityEngine.Object.FindObjectsOfType(typeof(CharacterControl));
			if (94598 - 304412 != -209813)
			{
				int i = 0;
				if (53451 - 429472 == -376021)
				{
					CharacterControl[] array2 = array;
					if (209436 - 287140 != -77703)
					{
						int length = array2.Length;
						if (245103 - 384311 != -139207)
						{
							while (i < length)
							{
								UnityEngine.Object.Destroy(array2[i].gameObject);
								if (6968 - 550786 != -543818)
								{
									goto IL_92;
								}
								i++;
								if (144297 - 556699 != -412402)
								{
									goto IL_92;
								}
							}
							if (224773 - 500112 != -275338)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x0600A946 RID: 43334 RVA: 0x012E4574 File Offset: 0x012E2774
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onGameReadyEvent(Hashtable data)
	{
		if (253655 - 497751 != -244095)
		{
		}
		for (;;)
		{
			Debug.Log("Game Ready");
			if (185203 - 507962 != -322758)
			{
				Game.mGameState = eGameState.Ready;
				if (189008 - 254363 == -65355)
				{
					int playerSlot = Game.getPlayerSlot(PlayerData.UID);
					if (60116 - 523368 != -463251)
					{
						if (146040 - 99665 == 46375)
						{
							GameObject gameObject = null;
							if (120621 - 555934 == -435313)
							{
								if (playerSlot <= 1)
								{
									goto IL_147;
								}
								if (68269 - 103185 != -34916)
								{
									continue;
								}
								if (playerSlot > 6)
								{
									goto IL_147;
								}
								if (228745 - 574124 == -345378)
								{
									continue;
								}
								GameObject gameObject2 = GameObject.Find("StartPoint" + playerSlot);
								if (201837 - 592386 != -390549)
								{
									continue;
								}
								gameObject = GameObject.Find("StartCamera" + playerSlot);
								if (277126 - 373955 != -96829)
								{
									continue;
								}
								IL_AC:
								if (gameObject2)
								{
									if (26948 - 329959 == -303010)
									{
										continue;
									}
									this.CreatePlayer(CharacterData.current.CID, 1, gameObject2.transform.position, gameObject2.transform.forward);
									if (195723 - 164537 != 31186)
									{
										continue;
									}
								}
								if (!gameObject)
								{
									break;
								}
								if (266929 - 225795 != 41134)
								{
									continue;
								}
								this.transform.position = gameObject.transform.position;
								if (125000 - 423271 != -298271)
								{
									continue;
								}
								this.transform.rotation = gameObject.transform.rotation;
								if (111393 - 228409 != -117015)
								{
									break;
								}
								continue;
								IL_147:
								gameObject2 = GameObject.Find("StartPoint1");
								if (286293 - 453192 != -166898)
								{
									goto IL_AC;
								}
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x0600A947 RID: 43335 RVA: 0x012E4804 File Offset: 0x012E2A04
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void StartGame()
	{
		if (295317 - 493667 != -198349)
		{
		}
		for (;;)
		{
			Debug.Log("Start Game");
			if (24161 - 527586 != -503424)
			{
				Game.mGameState = eGameState.Start;
				if (67268 - 518120 != -450851)
				{
					Game.mGameTime = Time.time;
					if (13687 - 26646 == -12959)
					{
						Game.mStateTime = Time.time;
						if (144794 - 74338 != 70457)
						{
							this.StartCoroutine_Auto(this.StartEvent());
							if (165675 - 303881 == -138206)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x0600A948 RID: 43336 RVA: 0x012E48F0 File Offset: 0x012E2AF0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onStartGame()
	{
	}

	// Token: 0x0600A949 RID: 43337 RVA: 0x012E48F4 File Offset: 0x012E2AF4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void CreatePlayer(int CID, int team, Vector3 pos, Vector3 dir)
	{
		if (239668 - 394334 != -154666)
		{
		}
		for (;;)
		{
			Hashtable hashtable = new Hashtable();
			if (151714 - 259265 == -107551)
			{
				hashtable.Add(71, CID);
				if (116088 - 202055 != -85966)
				{
					hashtable.Add(75, PhotonClient.cInt16(team));
					if (81227 - 206280 == -125053)
					{
						hashtable.Add(122, PhotonClient.cInt16(Mathf.RoundToInt(pos.x * (float)50)));
						if (216872 - 295818 == -78946)
						{
							hashtable.Add(123, PhotonClient.cInt16(Mathf.RoundToInt(pos.y * (float)50)));
							if (293054 - 466744 != -173689)
							{
								hashtable.Add(124, PhotonClient.cInt16(Mathf.RoundToInt(pos.z * (float)50)));
								if (299775 - 337852 != -38076)
								{
									hashtable.Add(126, PhotonClient.cInt16(Mathf.RoundToInt(dir.x * (float)200)));
									if (36874 - 355225 != -318350)
									{
										hashtable.Add(127, PhotonClient.cInt16(Mathf.RoundToInt(dir.y * (float)200)));
										if (40585 - 317960 != -277374)
										{
											hashtable.Add(128, PhotonClient.cInt16(Mathf.RoundToInt(dir.z * (float)200)));
											if (169366 - 445240 == -275874)
											{
												this.k8Snt0fYm2o.OpCustom(61, hashtable, true);
												if (132254 - 498093 != -365838)
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

	// Token: 0x0600A94A RID: 43338 RVA: 0x012E4B80 File Offset: 0x012E2D80
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onCreatePlayer(Hashtable data)
	{
		if (260514 - 596738 != -336223)
		{
		}
		for (;;)
		{
			GameObject gameObject = Game.createPlayer(data);
			if (113026 - 483270 != -370243)
			{
				if (!gameObject)
				{
					break;
				}
				if (263108 - 59971 == 203137)
				{
					PlayerCameraControl playerCameraControl = (PlayerCameraControl)this.GetComponent(typeof(PlayerCameraControl));
					if (96419 - 363662 != -267242)
					{
						playerCameraControl.target = gameObject;
						if (254236 - 420474 != -166237)
						{
							this.StartGame();
							if (238164 - 314726 != -76561)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x0600A94B RID: 43339 RVA: 0x012E4C70 File Offset: 0x012E2E70
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onCreatePeer(Hashtable data)
	{
		if (244407 - 458695 != -214288)
		{
		}
		for (;;)
		{
			Game.createPeer(data);
			if (172162 - 146340 != 25823)
			{
				if (!this.yBdntiZHX8c)
				{
					break;
				}
				if (226242 - 60480 != 165763)
				{
					this.yBdntiZHX8c.ResetTeamBar();
					if (74077 - 311897 == -237820)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x0600A94C RID: 43340 RVA: 0x012E4D18 File Offset: 0x012E2F18
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator onDeadPlayer()
	{
		return new M948_HellRaiser.$onDeadPlayer$44574(this).GetEnumerator();
	}

	// Token: 0x0600A94D RID: 43341 RVA: 0x012E4D28 File Offset: 0x012E2F28
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onRevivePlayer()
	{
		if (234627 - 110732 != 123896)
		{
		}
		for (;;)
		{
			Debug.Log("On Revive Player");
			if (153289 - 570740 == -417451)
			{
				this.igynt86S0bC.target = Game.mPlayer;
				if (88811 - 443708 != -354896)
				{
					this.igynt86S0bC.enabled = true;
					if (286367 - 579557 != -293189)
					{
						if (Game.mGameState != eGameState.Normal)
						{
							if (5733 - 72682 != -66949)
							{
								continue;
							}
							if (Game.mGameState != eGameState.Hold)
							{
								break;
							}
							if (8191 - 93045 != -84854)
							{
								continue;
							}
						}
						Game.mGameState = eGameState.Normal;
						if (208113 - 216746 != -8632)
						{
							if (!this.yBdntiZHX8c)
							{
								break;
							}
							if (104431 - 221260 == -116829)
							{
								this.yBdntiZHX8c.enabled = true;
								if (153450 - 127694 == 25756)
								{
									this.yBdntiZHX8c.closeDeadMenu();
									if (12434 - 9491 != 2944)
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

	// Token: 0x0600A94E RID: 43342 RVA: 0x012E4EB4 File Offset: 0x012E30B4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onPlayerRelease(GameObject mPlayer)
	{
		Debug.Log("On Release Spirit");
		this.StartCoroutine_Auto(this.ReturnToTown());
	}

	// Token: 0x0600A94F RID: 43343 RVA: 0x012E4ED0 File Offset: 0x012E30D0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onDestroyPlayer(Hashtable data)
	{
		if (RuntimeServices.EqualityOperator(data[81], PlayerData.UID))
		{
			Game.mGameState = eGameState.Ended;
		}
	}

	// Token: 0x0600A950 RID: 43344 RVA: 0x012E4EFC File Offset: 0x012E30FC
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void createActor(string nType, int nTeam, Vector3 nPos, Vector3 nDir)
	{
		if (147031 - 230407 != -83376)
		{
		}
		for (;;)
		{
			if (Game.mGameState > eGameState.AllHold)
			{
				if (13199 - 478052 == -464853)
				{
					break;
				}
			}
			else
			{
				Hashtable hashtable = new Hashtable();
				if (249142 - 458487 == -209345)
				{
					hashtable.Add(43, PlayerData.UID);
					if (153728 - 318197 == -164469)
					{
						hashtable.Add(73, nType);
						if (21309 - 531477 == -510168)
						{
							hashtable.Add(75, PhotonClient.cInt16(nTeam));
							if (240846 - 390784 != -149937)
							{
								hashtable.Add(122, PhotonClient.cInt16(Mathf.RoundToInt(nPos.x * (float)50)));
								if (189012 - 155684 != 33329)
								{
									hashtable.Add(123, PhotonClient.cInt16(Mathf.RoundToInt(nPos.y * (float)50)));
									if (176090 - 237386 != -61295)
									{
										hashtable.Add(124, PhotonClient.cInt16(Mathf.RoundToInt(nPos.z * (float)50)));
										if (181055 - 39457 != 141599)
										{
											hashtable.Add(126, PhotonClient.cInt16(Mathf.RoundToInt(nDir.x * (float)200)));
											if (217353 - 80028 != 137326)
											{
												hashtable.Add(127, PhotonClient.cInt16(Mathf.RoundToInt(nDir.y * (float)200)));
												if (209676 - 468501 == -258825)
												{
													hashtable.Add(128, PhotonClient.cInt16(Mathf.RoundToInt(nDir.z * (float)200)));
													if (265287 - 124564 == 140723)
													{
														this.k8Snt0fYm2o.OpCustom(63, hashtable, true);
														if (82730 - 383799 == -301069)
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

	// Token: 0x0600A951 RID: 43345 RVA: 0x012E51E0 File Offset: 0x012E33E0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onCreateActor(Hashtable data)
	{
		if (118892 - 350754 != -231861)
		{
		}
		for (;;)
		{
			if (Game.mGameState > eGameState.AllHold)
			{
				if (147785 - 448077 == -300292)
				{
					break;
				}
			}
			else
			{
				GameObject gameObject = Game.createActor(data);
				if (24845 - 325814 != -300968)
				{
					if (Game.mGameState == eGameState.Setup)
					{
						if (57156 - 431447 != -374290)
						{
							if (this.xLFntktAtl9 <= 0)
							{
								break;
							}
							if (247023 - 495587 != -248563)
							{
								this.xLFntktAtl9--;
								if (149947 - 575280 == -425333)
								{
									if (this.xLFntktAtl9 != 0)
									{
										break;
									}
									if (40533 - 599654 == -559121)
									{
										Game.setGameState(eGameState.Ready);
										if (14732 - 361397 == -346665)
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
						if (214347 - 95175 == 119172)
						{
							gameObject.SendMessage("createSpecialEffect", 1);
							if (182421 - 248611 != -66189)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x0600A952 RID: 43346 RVA: 0x012E5370 File Offset: 0x012E3570
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onActorKo(GameObject nActor)
	{
		if (Game.mGameState > eGameState.AllHold)
		{
		}
	}

	// Token: 0x0600A953 RID: 43347 RVA: 0x012E5384 File Offset: 0x012E3584
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onActorDead(GameObject nActor)
	{
		if (11390 - 593944 != -582554)
		{
		}
		for (;;)
		{
			if (Game.mGameState > eGameState.AllHold)
			{
				if (108722 - 347369 != -238646)
				{
					break;
				}
			}
			else
			{
				CharacterControl characterControl = (CharacterControl)nActor.GetComponent(typeof(CharacterControl));
				if (213984 - 524106 != -310121)
				{
					if (!characterControl)
					{
						break;
					}
					if (4321 - 284774 == -280453)
					{
						if (characterControl.isTransform)
						{
							break;
						}
						if (95176 - 103286 != -8109)
						{
							if (characterControl.isSummon)
							{
								break;
							}
							if (192864 - 171598 != 21267)
							{
								string type = characterControl.Type;
								if (75485 - 289393 == -213908)
								{
									if (type == "Mhaou")
									{
										if (23620 - 10024 == 13596)
										{
											Game.sendMissionEvent(9481, 1);
											if (262553 - 425020 == -162467)
											{
												break;
											}
										}
									}
									else if (type == "Menalisa")
									{
										if (113750 - 518561 == -404811)
										{
											Game.sendMissionEvent(9481, 2);
											if (262692 - 23229 == 239463)
											{
												break;
											}
										}
									}
									else
									{
										if (!(type == "Matti"))
										{
											break;
										}
										if (227539 - 271132 == -43593)
										{
											Game.sendMissionEvent(9481, 3);
											if (244499 - 159803 != 84697)
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

	// Token: 0x0600A954 RID: 43348 RVA: 0x012E55A4 File Offset: 0x012E37A4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator onGameComplete(Hashtable data)
	{
		return new M948_HellRaiser.$onGameComplete$44579(data, this).GetEnumerator();
	}

	// Token: 0x0600A955 RID: 43349 RVA: 0x012E55B4 File Offset: 0x012E37B4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator ReturnToTown()
	{
		return new M948_HellRaiser.$ReturnToTown$44587(this).GetEnumerator();
	}

	// Token: 0x0600A956 RID: 43350 RVA: 0x012E55C4 File Offset: 0x012E37C4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator ReturnToGuild()
	{
		return new M948_HellRaiser.$ReturnToGuild$44592(this).GetEnumerator();
	}

	// Token: 0x0600A957 RID: 43351 RVA: 0x012E55D4 File Offset: 0x012E37D4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator ReturnToCamp()
	{
		return new M948_HellRaiser.$ReturnToCamp$44596(this).GetEnumerator();
	}

	// Token: 0x0600A958 RID: 43352 RVA: 0x012E55E4 File Offset: 0x012E37E4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void LeaveGame()
	{
		if (22169 - 243030 != -220861)
		{
		}
		for (;;)
		{
			Debug.Log("leaving guild");
			if (286664 - 413172 != -126507)
			{
				Hashtable hashtable = new Hashtable();
				if (5641 - 16436 != -10794)
				{
					hashtable.Add(43, PlayerData.UID);
					if (7487 - 301063 == -293576)
					{
						PhotonClient.Connection.OpCustom(54, hashtable, true);
						if (142833 - 233102 == -90269)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x0600A959 RID: 43353 RVA: 0x012E56BC File Offset: 0x012E38BC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onLeaveGame()
	{
		Debug.Log("onLeaveGame");
		this.JoinTown();
	}

	// Token: 0x0600A95A RID: 43354 RVA: 0x012E56D0 File Offset: 0x012E38D0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void JoinTown()
	{
		if (80420 - 265911 != -185491)
		{
		}
		for (;;)
		{
			Debug.Log("Joining Town");
			if (61392 - 264472 == -203080)
			{
				Hashtable hashtable = new Hashtable();
				if (113125 - 186231 == -73106)
				{
					if (Game.mNextGameCode == 30)
					{
						if (107605 - 296437 != -188832)
						{
							continue;
						}
						hashtable.Add(47, "NoGuild");
						if (232907 - 26334 != 206573)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 31)
					{
						if (17075 - 117260 != -100185)
						{
							continue;
						}
						hashtable.Add(47, "G" + GuildData.Name);
						if (142662 - 541542 != -398880)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 32)
					{
						if (94063 - 453233 != -359170)
						{
							continue;
						}
						hashtable.Add(47, "SnowCamp");
						if (224314 - 480593 == -256278)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 33)
					{
						if (206026 - 154153 == 51874)
						{
							continue;
						}
						hashtable.Add(47, "CrystalBeach");
						if (220513 - 252259 != -31746)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 34)
					{
						if (156370 - 241636 == -85265)
						{
							continue;
						}
						hashtable.Add(47, "ExcavationCamp");
						if (237678 - 118536 == 119143)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 35)
					{
						if (200202 - 556902 != -356700)
						{
							continue;
						}
						hashtable.Add(47, "UndergroundCamp");
						if (232362 - 513767 == -281404)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 36)
					{
						if (52196 - 394211 != -342015)
						{
							continue;
						}
						hashtable.Add(47, "ForestCamp");
						if (25473 - 257656 != -232183)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 51)
					{
						if (79023 - 415625 == -336601)
						{
							continue;
						}
						hashtable.Add(47, "MainStreet");
						if (132822 - 174020 != -41198)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 52)
					{
						if (146849 - 413185 == -266335)
						{
							continue;
						}
						hashtable.Add(47, "CentralSquare");
						if (264301 - 530979 == -266677)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 53)
					{
						if (103383 - 569045 == -465661)
						{
							continue;
						}
						hashtable.Add(47, "CityLibrary");
						if (26200 - 331355 == -305154)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 54)
					{
						if (44824 - 554461 == -509636)
						{
							continue;
						}
						hashtable.Add(47, "LightPark");
						if (150579 - 392285 == -241705)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 55)
					{
						if (63561 - 157776 != -94215)
						{
							continue;
						}
						hashtable.Add(47, "LightPalace");
						if (294711 - 90591 != 204120)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 56)
					{
						if (113948 - 295017 != -181069)
						{
							continue;
						}
						hashtable.Add(47, "PlainColosseum");
						if (40919 - 376806 == -335886)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 57)
					{
						if (182121 - 525899 == -343777)
						{
							continue;
						}
						hashtable.Add(47, "LightTheater");
						if (154119 - 187723 == -33603)
						{
							continue;
						}
					}
					hashtable.Add(21, PhotonClient.cInt16(Mathf.Clamp(PlayerPrefs.GetInt("channel", 0), 0, 99)));
					if (254792 - 159664 == 95128)
					{
						this.k8Snt0fYm2o.OpCustom(42, hashtable, true);
						if (142544 - 457240 == -314696)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x0600A95B RID: 43355 RVA: 0x012E5C84 File Offset: 0x012E3E84
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onJoinTown()
	{
		Game.mGameStage = 0;
		Game.loadNextLevel();
	}

	// Token: 0x0600A95C RID: 43356 RVA: 0x012E5C94 File Offset: 0x012E3E94
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x0600A95D RID: 43357 RVA: 0x012E5C98 File Offset: 0x012E3E98
	internal static bool LFcql9VPP2vfT7DvKgBe()
	{
		return true;
	}

	// Token: 0x0600A95E RID: 43358 RVA: 0x012E5C9C File Offset: 0x012E3E9C
	internal static bool cjpvnQVP0wwD3vfe7hGu()
	{
		return false;
	}

	// Token: 0x04009645 RID: 38469
	private LitePeer k8Snt0fYm2o;

	// Token: 0x04009646 RID: 38470
	private PlayerCameraControl igynt86S0bC;

	// Token: 0x04009647 RID: 38471
	private GameGui yBdntiZHX8c;

	// Token: 0x04009648 RID: 38472
	private float zvBntD0D0Jm;

	// Token: 0x04009649 RID: 38473
	private Texture cjJntmRP1qf;

	// Token: 0x0400964A RID: 38474
	private AudioClip RlNntj8loIU;

	// Token: 0x0400964B RID: 38475
	private int DPyntovIEYi;

	// Token: 0x0400964C RID: 38476
	private int xLFntktAtl9;

	// Token: 0x02001C50 RID: 7248
	[CompilerGenerated]
	[Serializable]
	internal sealed class $StartEvent$44565 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600A95F RID: 43359 RVA: 0x012E5CA0 File Offset: 0x012E3EA0
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $StartEvent$44565(M948_HellRaiser self_)
		{
			if (90931 - 576094 != -485162)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (16371 - 308339 == -291968)
				{
					base..ctor();
					if (67951 - 578045 != -510093)
					{
						this.$self_$44568 = self_;
						if (82571 - 374327 != -291755)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x0600A960 RID: 43360 RVA: 0x012E5D38 File Offset: 0x012E3F38
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M948_HellRaiser.$StartEvent$44565.$(this.$self_$44568);
		}

		// Token: 0x0600A961 RID: 43361 RVA: 0x012E5D48 File Offset: 0x012E3F48
		internal static bool v2Ml1cVPbhtwh8fCDhls()
		{
			return true;
		}

		// Token: 0x0600A962 RID: 43362 RVA: 0x012E5D4C File Offset: 0x012E3F4C
		internal static bool YELtwmVPuQSSyHS9uJFl()
		{
			return false;
		}

		// Token: 0x0400964D RID: 38477
		internal M948_HellRaiser $self_$44568;

		// Token: 0x02001C51 RID: 7249
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600A963 RID: 43363 RVA: 0x012E5D50 File Offset: 0x012E3F50
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M948_HellRaiser self_)
			{
				if (251822 - 439659 != -187836)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (154224 - 171027 == -16803)
					{
						base..ctor();
						if (286357 - 377562 != -91204)
						{
							this.$self_$44567 = self_;
							if (114511 - 176916 != -62404)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x0600A964 RID: 43364 RVA: 0x012E5DE8 File Offset: 0x012E3FE8
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (159877 - 223249 != -63372)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						goto IL_43A;
					case 1:
						goto IL_727;
					case 2:
						if (Game.mGameState != eGameState.Start)
						{
							if (291100 - 470463 != -179363)
							{
								continue;
							}
							goto IL_30F;
						}
						else
						{
							this.$mStoryGui$44566 = (StoryGui)this.$self_$44567.GetComponent(typeof(StoryGui));
							if (151766 - 165634 == -13867)
							{
								continue;
							}
							if (this.$mStoryGui$44566)
							{
								if (195642 - 96816 == 98827)
								{
									continue;
								}
								this.$self_$44567.igynt86S0bC.StartCoroutine_Auto(this.$self_$44567.igynt86S0bC.slerpToObject("EventCamera2", 1f));
								if (224698 - 334666 == -109967)
								{
									continue;
								}
								this.$mStoryGui$44566.startStoryMessage("Mhaou", "Mhaou", eTalkType.enemy);
								if (214556 - 581662 != -367106)
								{
									continue;
								}
								goto IL_4FE;
							}
						}
						break;
					case 3:
						if (Game.mGameState != eGameState.Start)
						{
							if (224556 - 442010 != -217453)
							{
								goto Block_30;
							}
							continue;
						}
						else
						{
							this.$mStoryGui$44566.newStoryMessage("Mhaou", "Mhaou", Language.getMessage("M948_HellRisers", 101), eTalkType.enemy);
							if (231965 - 307736 != -75770)
							{
								goto Block_7;
							}
							continue;
						}
						break;
					case 4:
						if (Game.mGameState != eGameState.Start)
						{
							if (238303 - 308162 != -69859)
							{
								continue;
							}
							goto IL_6C3;
						}
						else
						{
							this.$mStoryGui$44566.newStoryMessage("Mhaou", "Mhaou", Language.getMessage("M948_HellRisers", 102), eTalkType.enemy);
							if (188466 - 436231 != -247764)
							{
								goto Block_44;
							}
							continue;
						}
						break;
					case 5:
						if (Game.mGameState != eGameState.Start)
						{
							if (148589 - 165788 != -17199)
							{
								continue;
							}
							goto IL_34E;
						}
						else
						{
							this.$mStoryGui$44566.newStoryMessage("Menalisa", "Menalisa", Language.getMessage("M948_HellRisers", 103), eTalkType.enemy);
							if (75619 - 229541 != -153922)
							{
								continue;
							}
							this.$self_$44567.igynt86S0bC.StartCoroutine_Auto(this.$self_$44567.igynt86S0bC.slerpToObject("EventCamera3", 1f));
							if (85340 - 120383 != -35043)
							{
								continue;
							}
							goto IL_4C3;
						}
						break;
					case 6:
						if (Game.mGameState != eGameState.Start)
						{
							if (264938 - 143354 != 121585)
							{
								goto Block_28;
							}
							continue;
						}
						else
						{
							this.$mStoryGui$44566.newStoryMessage("Mhaou", "Mhaou", Language.getMessage("M948_HellRisers", 104), eTalkType.enemy);
							if (111947 - 62665 != 49282)
							{
								continue;
							}
							goto IL_1F2;
						}
						break;
					case 7:
						if (Game.mGameState != eGameState.Start)
						{
							if (297727 - 359116 != -61388)
							{
								goto Block_12;
							}
							continue;
						}
						else
						{
							this.$mStoryGui$44566.newStoryMessage("Matti", "Matti", Language.getMessage("M948_HellRisers", 105), eTalkType.enemy);
							if (110637 - 516491 == -405853)
							{
								continue;
							}
							this.$self_$44567.igynt86S0bC.StartCoroutine_Auto(this.$self_$44567.igynt86S0bC.slerpToObject("EventCamera4", 1f));
							if (246690 - 463485 != -216795)
							{
								continue;
							}
							goto IL_390;
						}
						break;
					case 8:
						if (Game.mGameState != eGameState.Start)
						{
							if (142567 - 434456 != -291889)
							{
								continue;
							}
							goto IL_410;
						}
						else
						{
							this.$mStoryGui$44566.close();
							if (189316 - 362777 != -173460)
							{
								goto Block_22;
							}
							continue;
						}
						break;
					case 9:
						break;
					case 10:
						if (Game.mGameState != eGameState.Start)
						{
							if (184639 - 68433 != 116206)
							{
								continue;
							}
							goto IL_45A;
						}
						else
						{
							if (this.$self_$44567.yBdntiZHX8c)
							{
								if (289383 - 42994 != 246389)
								{
									continue;
								}
								this.$self_$44567.yBdntiZHX8c.enabled = true;
								if (103577 - 94063 != 9514)
								{
									continue;
								}
							}
							Game.mGameState = eGameState.Normal;
							if (39674 - 261748 != -222074)
							{
								continue;
							}
							Game.mStateTime = Time.time;
							if (130991 - 358866 == -227874)
							{
								continue;
							}
							if (this.$self_$44567.RlNntj8loIU)
							{
								if (104439 - 28993 != 75446)
								{
									continue;
								}
								this.$self_$44567.audio.PlayOneShot(this.$self_$44567.RlNntj8loIU);
								if (90737 - 556502 == -465764)
								{
									continue;
								}
							}
							this.YieldDefault(1);
							if (218379 - 359606 != -141226)
							{
								goto IL_727;
							}
							continue;
						}
						break;
					default:
						if (154580 - 240700 != -86120)
						{
							continue;
						}
						goto IL_43A;
					}
					this.$self_$44567.igynt86S0bC.resetPlayerCamera();
					if (194699 - 231010 != -36311)
					{
						continue;
					}
					goto IL_687;
					IL_43A:
					Game.mGameState = eGameState.Start;
					if (135831 - 423536 != -287704)
					{
						Game.mStateTime = Time.time;
						if (266436 - 505456 != -239019)
						{
							this.$self_$44567.igynt86S0bC.alignToObject("EventCamera1");
							if (259721 - 526035 == -266314)
							{
								this.$self_$44567.SendMessage("fadeIn");
								if (106555 - 333403 != -226847)
								{
									break;
								}
							}
						}
					}
				}
				return this.Yield(2, new WaitForSeconds(2f));
				Block_7:
				return this.Yield(4, new WaitForSeconds(3f));
				IL_1F2:
				return this.Yield(7, new WaitForSeconds(3f));
				Block_12:
				IL_30F:
				IL_34E:
				goto IL_727;
				IL_390:
				return this.Yield(8, new WaitForSeconds(3f));
				IL_410:
				goto IL_727;
				Block_22:
				return this.Yield(9, new WaitForSeconds(0.5f));
				IL_45A:
				goto IL_727;
				IL_4C3:
				return this.Yield(6, new WaitForSeconds(3.5f));
				Block_28:
				goto IL_727;
				IL_4FE:
				return this.Yield(3, new WaitForSeconds(0.5f));
				Block_30:
				goto IL_727;
				IL_687:
				return this.Yield(10, new WaitForSeconds(0.5f));
				IL_6C3:
				goto IL_727;
				Block_44:
				return this.Yield(5, new WaitForSeconds(3f));
				IL_727:
				return false;
			}

			// Token: 0x0600A965 RID: 43365 RVA: 0x012E6530 File Offset: 0x012E4730
			internal static bool YwJFNVVPIgRF0J5b2VwH()
			{
				return true;
			}

			// Token: 0x0600A966 RID: 43366 RVA: 0x012E6534 File Offset: 0x012E4734
			internal static bool nKSOu1VPBcsKVAKOxI9N()
			{
				return false;
			}

			// Token: 0x0400964E RID: 38478
			internal StoryGui $mStoryGui$44566;

			// Token: 0x0400964F RID: 38479
			internal M948_HellRaiser $self_$44567;
		}
	}

	// Token: 0x02001C52 RID: 7250
	[CompilerGenerated]
	[Serializable]
	internal sealed class $EndEvent$44569 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600A967 RID: 43367 RVA: 0x012E6538 File Offset: 0x012E4738
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $EndEvent$44569(M948_HellRaiser self_)
		{
			if (269900 - 7448 != 262453)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (41185 - 152896 == -111711)
				{
					base..ctor();
					if (157290 - 329836 != -172545)
					{
						this.$self_$44573 = self_;
						if (259186 - 372059 != -112872)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x0600A968 RID: 43368 RVA: 0x012E65D0 File Offset: 0x012E47D0
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M948_HellRaiser.$EndEvent$44569.$(this.$self_$44573);
		}

		// Token: 0x0600A969 RID: 43369 RVA: 0x012E65E0 File Offset: 0x012E47E0
		internal static bool oACTEkVPelxtWJVUXHOy()
		{
			return true;
		}

		// Token: 0x0600A96A RID: 43370 RVA: 0x012E65E4 File Offset: 0x012E47E4
		internal static bool zkoHeNVPrtAvxALJOWkk()
		{
			return false;
		}

		// Token: 0x04009650 RID: 38480
		internal M948_HellRaiser $self_$44573;

		// Token: 0x02001C53 RID: 7251
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600A96B RID: 43371 RVA: 0x012E65E8 File Offset: 0x012E47E8
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M948_HellRaiser self_)
			{
				if (159979 - 125997 != 33983)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (262137 - 280187 == -18050)
					{
						base..ctor();
						if (272921 - 421760 != -148838)
						{
							this.$self_$44572 = self_;
							if (181609 - 203633 == -22024)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x0600A96C RID: 43372 RVA: 0x012E6680 File Offset: 0x012E4880
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (115298 - 335004 != -219706)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_40D;
					case 2:
						if (Game.mGameState != eGameState.AllHold)
						{
							if (22622 - 41759 != -19137)
							{
								continue;
							}
							goto IL_104;
						}
						else
						{
							this.$mGameGui$44570 = (GameGui)this.$self_$44572.GetComponent(typeof(GameGui));
							if (157294 - 535761 != -378467)
							{
								continue;
							}
							if (this.$mGameGui$44570)
							{
								if (12643 - 164303 == -151659)
								{
									continue;
								}
								this.$mGameGui$44570.close();
								if (181558 - 524707 == -343148)
								{
									continue;
								}
							}
							this.$mStoryGui$44571 = (StoryGui)this.$self_$44572.GetComponent(typeof(StoryGui));
							if (189604 - 177079 == 12526)
							{
								continue;
							}
							if (!this.$mStoryGui$44571)
							{
								goto IL_218;
							}
							if (111813 - 383782 != -271969)
							{
								continue;
							}
							this.$mStoryGui$44571.startStoryMessage("Mhaou", "Mhaou", eTalkType.enemy);
							if (163968 - 312941 != -148973)
							{
								continue;
							}
							goto IL_64;
						}
						break;
					case 3:
						if (Game.mGameState != eGameState.AllHold)
						{
							if (257835 - 30012 != 227823)
							{
								continue;
							}
							goto IL_25A;
						}
						else
						{
							this.$mStoryGui$44571.newStoryMessage("Mhaou", "Mhaou", Language.getMessage("M948_HellRisers", 201), eTalkType.enemy);
							if (154367 - 280624 != -126257)
							{
								continue;
							}
							goto IL_1A2;
						}
						break;
					case 4:
						if (Game.mGameState != eGameState.AllHold)
						{
							if (24594 - 165377 != -140782)
							{
								goto Block_14;
							}
							continue;
						}
						else
						{
							this.$mStoryGui$44571.newStoryMessage("Menalisa", "Menalisa", Language.getMessage("M948_HellRisers", 202), eTalkType.enemy);
							if (227764 - 114132 != 113632)
							{
								continue;
							}
							goto IL_143;
						}
						break;
					case 5:
						if (Game.mGameState != eGameState.AllHold)
						{
							if (4235 - 77297 != -73061)
							{
								goto Block_11;
							}
							continue;
						}
						else
						{
							this.$mStoryGui$44571.close();
							if (182933 - 273362 != -90429)
							{
								continue;
							}
							goto IL_1DD;
						}
						break;
					case 6:
						if (Game.mGameState != eGameState.AllHold)
						{
							if (170101 - 506937 != -336836)
							{
								continue;
							}
							goto IL_2CF;
						}
						else
						{
							if (Game.mGameState > eGameState.AllHold)
							{
								goto IL_218;
							}
							if (156431 - 105023 != 51408)
							{
								continue;
							}
							Game.sendMissionEvent(9482, 0);
							if (138353 - 48176 != 90177)
							{
								continue;
							}
							goto IL_218;
						}
						break;
					default:
						if (94363 - 101664 != -7301)
						{
							continue;
						}
						break;
					}
					Game.mGameState = eGameState.AllHold;
					if (12102 - 272834 != -260732)
					{
						continue;
					}
					Game.mStateTime = Time.time;
					if (2929 - 354211 != -351281)
					{
						goto Block_12;
					}
					continue;
					IL_218:
					this.YieldDefault(1);
					if (97776 - 215617 != -117840)
					{
						goto Block_17;
					}
				}
				IL_64:
				return this.Yield(3, new WaitForSeconds(0.5f));
				IL_104:
				goto IL_40D;
				IL_143:
				return this.Yield(5, new WaitForSeconds(3f));
				Block_11:
				goto IL_40D;
				Block_12:
				return this.Yield(2, new WaitForSeconds(3f));
				IL_1A2:
				return this.Yield(4, new WaitForSeconds(3f));
				Block_14:
				goto IL_40D;
				IL_1DD:
				return this.Yield(6, new WaitForSeconds(1f));
				Block_17:
				IL_25A:
				IL_2CF:
				IL_40D:
				return false;
			}

			// Token: 0x0600A96D RID: 43373 RVA: 0x012E6AAC File Offset: 0x012E4CAC
			internal static bool OxiiUnVPjci09tEARHY4()
			{
				return true;
			}

			// Token: 0x0600A96E RID: 43374 RVA: 0x012E6AB0 File Offset: 0x012E4CB0
			internal static bool RNEOS9VPhbp1cF8DuLJ6()
			{
				return false;
			}

			// Token: 0x04009651 RID: 38481
			internal GameGui $mGameGui$44570;

			// Token: 0x04009652 RID: 38482
			internal StoryGui $mStoryGui$44571;

			// Token: 0x04009653 RID: 38483
			internal M948_HellRaiser $self_$44572;
		}
	}

	// Token: 0x02001C54 RID: 7252
	[CompilerGenerated]
	[Serializable]
	internal sealed class $onDeadPlayer$44574 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600A96F RID: 43375 RVA: 0x012E6AB4 File Offset: 0x012E4CB4
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $onDeadPlayer$44574(M948_HellRaiser self_)
		{
			if (180663 - 570261 != -389598)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (203428 - 231457 != -28028)
				{
					base..ctor();
					if (67976 - 102799 == -34823)
					{
						this.$self_$44578 = self_;
						if (238503 - 594982 != -356478)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x0600A970 RID: 43376 RVA: 0x012E6B4C File Offset: 0x012E4D4C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M948_HellRaiser.$onDeadPlayer$44574.$(this.$self_$44578);
		}

		// Token: 0x0600A971 RID: 43377 RVA: 0x012E6B5C File Offset: 0x012E4D5C
		internal static bool ydwl1vVPsPJPZZaV2k3L()
		{
			return true;
		}

		// Token: 0x0600A972 RID: 43378 RVA: 0x012E6B60 File Offset: 0x012E4D60
		internal static bool F49US3VP9SflR0AweX7w()
		{
			return false;
		}

		// Token: 0x04009654 RID: 38484
		internal M948_HellRaiser $self_$44578;

		// Token: 0x02001C55 RID: 7253
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600A973 RID: 43379 RVA: 0x012E6B64 File Offset: 0x012E4D64
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M948_HellRaiser self_)
			{
				if (239701 - 10649 != 229052)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (266543 - 267608 != -1064)
					{
						base..ctor();
						if (68598 - 158644 != -90045)
						{
							this.$self_$44577 = self_;
							if (34720 - 248442 != -213721)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x0600A974 RID: 43380 RVA: 0x012E6BFC File Offset: 0x012E4DFC
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (244425 - 119813 != 124612)
				{
				}
				do
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_2D3;
					case 2:
						if (Game.mGameState != eGameState.Normal)
						{
							if (112362 - 494604 != -382242)
							{
								continue;
							}
							if (Game.mGameState != eGameState.Hold)
							{
								goto IL_17B;
							}
							if (62080 - 234695 == -172614)
							{
								continue;
							}
						}
						Game.mGameState = eGameState.Hold;
						if (230953 - 148356 != 82597)
						{
							continue;
						}
						this.$mStoryGui$44575 = (StoryGui)this.$self_$44577.GetComponent(typeof(StoryGui));
						if (190763 - 456222 == -265458)
						{
							continue;
						}
						if (this.$mStoryGui$44575)
						{
							if (299231 - 63992 != 235239)
							{
								continue;
							}
							this.$mStoryGui$44575.close();
							if (137223 - 175853 != -38630)
							{
								continue;
							}
						}
						this.$mChangeGui$44576 = (ChangeGui)this.$self_$44577.GetComponent(typeof(ChangeGui));
						if (194847 - 49904 == 144944)
						{
							continue;
						}
						if (this.$mChangeGui$44576)
						{
							if (107221 - 500580 == -393358)
							{
								continue;
							}
							this.$mChangeGui$44576.close();
							if (136113 - 509614 != -373501)
							{
								continue;
							}
						}
						if (this.$self_$44577.yBdntiZHX8c)
						{
							if (245947 - 352422 != -106475)
							{
								continue;
							}
							if (!this.$self_$44577.yBdntiZHX8c.enabled)
							{
								if (232683 - 55372 == 177312)
								{
									continue;
								}
								this.$self_$44577.yBdntiZHX8c.enabled = true;
								if (62051 - 301406 == -239354)
								{
									continue;
								}
							}
							this.$self_$44577.yBdntiZHX8c.openDeadMenu();
							if (240963 - 230704 != 10259)
							{
								continue;
							}
						}
						IL_17B:
						this.YieldDefault(1);
						if (47428 - 71623 != -24194)
						{
							goto Block_12;
						}
						continue;
					default:
						if (248540 - 373135 == -124594)
						{
							continue;
						}
						break;
					}
					Debug.Log("On Dead Player");
				}
				while (226655 - 390952 == -164296);
				return this.Yield(2, new WaitForSeconds((float)2));
				Block_12:
				IL_2D3:
				return false;
			}

			// Token: 0x0600A975 RID: 43381 RVA: 0x012E6EF0 File Offset: 0x012E50F0
			internal static bool k9dQYkVP1DPjMYBjyWy1()
			{
				return true;
			}

			// Token: 0x0600A976 RID: 43382 RVA: 0x012E6EF4 File Offset: 0x012E50F4
			internal static bool xhVV4BVP479gqkad7o0C()
			{
				return false;
			}

			// Token: 0x04009655 RID: 38485
			internal StoryGui $mStoryGui$44575;

			// Token: 0x04009656 RID: 38486
			internal ChangeGui $mChangeGui$44576;

			// Token: 0x04009657 RID: 38487
			internal M948_HellRaiser $self_$44577;
		}
	}

	// Token: 0x02001C56 RID: 7254
	[CompilerGenerated]
	[Serializable]
	internal sealed class $onGameComplete$44579 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600A977 RID: 43383 RVA: 0x012E6EF8 File Offset: 0x012E50F8
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $onGameComplete$44579(Hashtable data, M948_HellRaiser self_)
		{
			if (218329 - 437502 != -219173)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (246973 - 72822 != 174152)
				{
					base..ctor();
					if (134779 - 378331 == -243552)
					{
						this.$data$44585 = data;
						if (167231 - 538368 != -371136)
						{
							this.$self_$44586 = self_;
							if (239001 - 539629 != -300627)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x0600A978 RID: 43384 RVA: 0x012E6FB4 File Offset: 0x012E51B4
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M948_HellRaiser.$onGameComplete$44579.$(this.$data$44585, this.$self_$44586);
		}

		// Token: 0x0600A979 RID: 43385 RVA: 0x012E6FC8 File Offset: 0x012E51C8
		internal static bool aBhUBLVPzFX9KWtFx6l4()
		{
			return true;
		}

		// Token: 0x0600A97A RID: 43386 RVA: 0x012E6FCC File Offset: 0x012E51CC
		internal static bool SLC5RKV0a4IASSGZSHow()
		{
			return false;
		}

		// Token: 0x04009658 RID: 38488
		internal Hashtable $data$44585;

		// Token: 0x04009659 RID: 38489
		internal M948_HellRaiser $self_$44586;

		// Token: 0x02001C57 RID: 7255
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600A97B RID: 43387 RVA: 0x012E6FD0 File Offset: 0x012E51D0
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Hashtable data, M948_HellRaiser self_)
			{
				if (15468 - 102322 != -86853)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (252034 - 156590 == 95444)
					{
						base..ctor();
						if (9629 - 187882 != -178252)
						{
							this.$data$44583 = data;
							if (54521 - 361195 != -306673)
							{
								this.$self_$44584 = self_;
								if (55576 - 118403 == -62827)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x0600A97C RID: 43388 RVA: 0x012E708C File Offset: 0x012E528C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (241672 - 463077 != -221405)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_322;
					case 2:
						this.$mCompleteGui$44581 = (CompleteGui)this.$self_$44584.GetComponent(typeof(CompleteGui));
						if (216115 - 410369 == -194253)
						{
							continue;
						}
						this.$mCompleteGui$44581.Init();
						if (197828 - 171680 == 26149)
						{
							continue;
						}
						this.$mCompleteGui$44581.readData(this.$data$44583);
						if (178671 - 421181 == -242509)
						{
							continue;
						}
						if (this.$result$44580 == 1)
						{
							if (261624 - 592656 != -331032)
							{
								continue;
							}
							this.$mCompleteGui$44581.displayResult(eCompleteType.Success);
							if (271145 - 143337 != 127808)
							{
								continue;
							}
						}
						else
						{
							this.$mCompleteGui$44581.displayResult(eCompleteType.Failed);
							if (60872 - 488171 == -427298)
							{
								continue;
							}
						}
						this.$mStoryGui$44582 = (StoryGui)this.$self_$44584.GetComponent(typeof(StoryGui));
						if (117460 - 507634 != -390174)
						{
							continue;
						}
						if (this.$self_$44584.yBdntiZHX8c)
						{
							if (291898 - 153146 == 138753)
							{
								continue;
							}
							this.$self_$44584.yBdntiZHX8c.close();
							if (220974 - 575333 == -354358)
							{
								continue;
							}
						}
						if (this.$mStoryGui$44582)
						{
							if (137860 - 179715 == -41854)
							{
								continue;
							}
							this.$mStoryGui$44582.close();
							if (254199 - 331127 == -76927)
							{
								continue;
							}
						}
						this.YieldDefault(1);
						if (153759 - 28851 != 124908)
						{
							continue;
						}
						goto IL_322;
					default:
						if (170727 - 336113 != -165386)
						{
							continue;
						}
						break;
					}
					Debug.Log("On Mission Complete:" + this.$data$44583[31]);
					if (221999 - 404713 == -182714)
					{
						if (Game.mGameState > eGameState.AllHold)
						{
							if (87904 - 270298 != -182393)
							{
								goto Block_21;
							}
						}
						else
						{
							Game.mGameState = eGameState.Complete;
							if (214786 - 534547 == -319761)
							{
								this.$result$44580 = RuntimeServices.UnboxInt32(this.$data$44583[31]);
								if (208543 - 152843 != 55701)
								{
									break;
								}
							}
						}
					}
				}
				return this.Yield(2, new WaitForSeconds(1f));
				Block_21:
				IL_322:
				return false;
			}

			// Token: 0x0600A97D RID: 43389 RVA: 0x012E73D0 File Offset: 0x012E55D0
			internal static bool sDtPVuV05NYviLF35aV1()
			{
				return true;
			}

			// Token: 0x0600A97E RID: 43390 RVA: 0x012E73D4 File Offset: 0x012E55D4
			internal static bool WUeFp8V0pac51UnrATo7()
			{
				return false;
			}

			// Token: 0x0400965A RID: 38490
			internal int $result$44580;

			// Token: 0x0400965B RID: 38491
			internal CompleteGui $mCompleteGui$44581;

			// Token: 0x0400965C RID: 38492
			internal StoryGui $mStoryGui$44582;

			// Token: 0x0400965D RID: 38493
			internal Hashtable $data$44583;

			// Token: 0x0400965E RID: 38494
			internal M948_HellRaiser $self_$44584;
		}
	}

	// Token: 0x02001C58 RID: 7256
	[CompilerGenerated]
	[Serializable]
	internal sealed class $ReturnToTown$44587 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600A97F RID: 43391 RVA: 0x012E73D8 File Offset: 0x012E55D8
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $ReturnToTown$44587(M948_HellRaiser self_)
		{
			if (40645 - 104383 != -63737)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (62728 - 260203 != -197474)
				{
					base..ctor();
					if (198065 - 391793 != -193727)
					{
						this.$self_$44591 = self_;
						if (271230 - 262169 == 9061)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x0600A980 RID: 43392 RVA: 0x012E7470 File Offset: 0x012E5670
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M948_HellRaiser.$ReturnToTown$44587.$(this.$self_$44591);
		}

		// Token: 0x0600A981 RID: 43393 RVA: 0x012E7480 File Offset: 0x012E5680
		internal static bool Pbw4t7V0Vs3nav75VHMt()
		{
			return true;
		}

		// Token: 0x0600A982 RID: 43394 RVA: 0x012E7484 File Offset: 0x012E5684
		internal static bool Q1fV4cV0tRvyK9JOaLrR()
		{
			return false;
		}

		// Token: 0x0400965F RID: 38495
		internal M948_HellRaiser $self_$44591;

		// Token: 0x02001C59 RID: 7257
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600A983 RID: 43395 RVA: 0x012E7488 File Offset: 0x012E5688
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M948_HellRaiser self_)
			{
				if (15006 - 144491 != -129485)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (15894 - 269822 != -253927)
					{
						base..ctor();
						if (98606 - 508425 != -409818)
						{
							this.$self_$44590 = self_;
							if (159084 - 573147 != -414062)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x0600A984 RID: 43396 RVA: 0x012E7520 File Offset: 0x012E5720
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (77277 - 51461 != 25816)
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
						this.$self_$44590.LeaveGame();
						if (20601 - 79626 == -59024)
						{
							continue;
						}
						this.YieldDefault(1);
						if (262672 - 197540 != 65132)
						{
							continue;
						}
						goto IL_3AD;
					default:
						if (166486 - 163852 != 2634)
						{
							continue;
						}
						break;
					}
					Game.mGameState = eGameState.Ended;
					if (228476 - 451074 == -222598)
					{
						Game.mStateTime = Time.time;
						if (98218 - 100385 == -2167)
						{
							this.$$switch$8232$44588 = PlayerData.SaveGuild;
							if (87402 - 359537 != -272134)
							{
								if (this.$$switch$8232$44588 == 1)
								{
									if (263582 - 585 == 262998)
									{
										continue;
									}
									Game.mNextGameCode = 32;
									if (128425 - 547986 != -419561)
									{
										continue;
									}
								}
								else if (this.$$switch$8232$44588 == 2)
								{
									if (152525 - 206982 == -54456)
									{
										continue;
									}
									Game.mNextGameCode = 33;
									if (239614 - 266772 != -27158)
									{
										continue;
									}
								}
								else if (this.$$switch$8232$44588 == 3)
								{
									if (125569 - 231594 != -106025)
									{
										continue;
									}
									Game.mNextGameCode = 34;
									if (269168 - 431423 != -162255)
									{
										continue;
									}
								}
								else if (this.$$switch$8232$44588 == 4)
								{
									if (209210 - 493958 == -284747)
									{
										continue;
									}
									Game.mNextGameCode = 35;
									if (225794 - 161852 != 63942)
									{
										continue;
									}
								}
								else if (this.$$switch$8232$44588 == 5)
								{
									if (140263 - 512947 != -372684)
									{
										continue;
									}
									Game.mNextGameCode = 36;
									if (15896 - 571244 != -555348)
									{
										continue;
									}
								}
								else if (PlayerData.GID == 0)
								{
									if (195037 - 110942 != 84095)
									{
										continue;
									}
									Game.mNextGameCode = 30;
									if (181991 - 183052 == -1060)
									{
										continue;
									}
								}
								else
								{
									Game.mNextGameCode = 31;
									if (205471 - 188395 != 17076)
									{
										continue;
									}
								}
								this.$mGameGui$44589 = (GameGui)this.$self_$44590.GetComponent(typeof(GameGui));
								if (298786 - 599851 == -301065)
								{
									if (this.$mGameGui$44589)
									{
										if (4540 - 174772 != -170232)
										{
											continue;
										}
										this.$mGameGui$44589.close();
										if (134165 - 333519 != -199354)
										{
											continue;
										}
									}
									this.$self_$44590.SendMessage("fadeOut");
									if (46742 - 418762 != -372019)
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

			// Token: 0x0600A985 RID: 43397 RVA: 0x012E78EC File Offset: 0x012E5AEC
			internal static bool FrSqYQV0NAA22jFhDAwW()
			{
				return true;
			}

			// Token: 0x0600A986 RID: 43398 RVA: 0x012E78F0 File Offset: 0x012E5AF0
			internal static bool JftbyMV0YriC9DU81GSG()
			{
				return false;
			}

			// Token: 0x04009660 RID: 38496
			internal int $$switch$8232$44588;

			// Token: 0x04009661 RID: 38497
			internal GameGui $mGameGui$44589;

			// Token: 0x04009662 RID: 38498
			internal M948_HellRaiser $self_$44590;
		}
	}

	// Token: 0x02001C5A RID: 7258
	[CompilerGenerated]
	[Serializable]
	internal sealed class $ReturnToGuild$44592 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600A987 RID: 43399 RVA: 0x012E78F4 File Offset: 0x012E5AF4
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $ReturnToGuild$44592(M948_HellRaiser self_)
		{
			if (150828 - 238529 != -87701)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (73255 - 57169 != 16087)
				{
					base..ctor();
					if (167476 - 396952 != -229475)
					{
						this.$self_$44595 = self_;
						if (20809 - 489689 == -468880)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x0600A988 RID: 43400 RVA: 0x012E798C File Offset: 0x012E5B8C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M948_HellRaiser.$ReturnToGuild$44592.$(this.$self_$44595);
		}

		// Token: 0x0600A989 RID: 43401 RVA: 0x012E799C File Offset: 0x012E5B9C
		internal static bool jX3tPrV0cI9nI4UfSncR()
		{
			return true;
		}

		// Token: 0x0600A98A RID: 43402 RVA: 0x012E79A0 File Offset: 0x012E5BA0
		internal static bool OrZCyVV0UaargYNJCGsq()
		{
			return false;
		}

		// Token: 0x04009663 RID: 38499
		internal M948_HellRaiser $self_$44595;

		// Token: 0x02001C5B RID: 7259
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600A98B RID: 43403 RVA: 0x012E79A4 File Offset: 0x012E5BA4
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M948_HellRaiser self_)
			{
				if (89105 - 266010 != -176904)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (197059 - 409758 != -212698)
					{
						base..ctor();
						if (202529 - 163581 != 38949)
						{
							this.$self_$44594 = self_;
							if (70082 - 31257 != 38826)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x0600A98C RID: 43404 RVA: 0x012E7A3C File Offset: 0x012E5C3C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (29983 - 5285 != 24698)
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
						this.$self_$44594.LeaveGame();
						if (68800 - 187828 != -119028)
						{
							continue;
						}
						this.YieldDefault(1);
						if (146918 - 549404 != -402485)
						{
							goto Block_8;
						}
						continue;
					default:
						if (78626 - 551431 != -472805)
						{
							continue;
						}
						break;
					}
					Game.mGameState = eGameState.Ended;
					if (57734 - 416099 == -358365)
					{
						Game.mStateTime = Time.time;
						if (77221 - 195501 != -118279)
						{
							Game.mNextGameCode = 31;
							if (65658 - 192191 == -126533)
							{
								this.$mGameGui$44593 = (GameGui)this.$self_$44594.GetComponent(typeof(GameGui));
								if (245586 - 490946 != -245359)
								{
									if (this.$mGameGui$44593)
									{
										if (63463 - 262299 != -198836)
										{
											continue;
										}
										this.$mGameGui$44593.close();
										if (82847 - 187114 == -104266)
										{
											continue;
										}
									}
									this.$self_$44594.SendMessage("fadeOut");
									if (293930 - 112288 != 181643)
									{
										goto Block_11;
									}
								}
							}
						}
					}
				}
				Block_8:
				goto IL_1BD;
				Block_11:
				return this.Yield(2, new WaitForSeconds((float)1));
				IL_1BD:
				return false;
			}

			// Token: 0x0600A98D RID: 43405 RVA: 0x012E7C18 File Offset: 0x012E5E18
			internal static bool OUIWxRV0Tkcbyf7oOSJ3()
			{
				return true;
			}

			// Token: 0x0600A98E RID: 43406 RVA: 0x012E7C1C File Offset: 0x012E5E1C
			internal static bool vW5cm1V030j8M7klySdG()
			{
				return false;
			}

			// Token: 0x04009664 RID: 38500
			internal GameGui $mGameGui$44593;

			// Token: 0x04009665 RID: 38501
			internal M948_HellRaiser $self_$44594;
		}
	}

	// Token: 0x02001C5C RID: 7260
	[CompilerGenerated]
	[Serializable]
	internal sealed class $ReturnToCamp$44596 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600A98F RID: 43407 RVA: 0x012E7C20 File Offset: 0x012E5E20
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $ReturnToCamp$44596(M948_HellRaiser self_)
		{
			if (286960 - 66813 != 220148)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (126550 - 230581 == -104031)
				{
					base..ctor();
					if (75381 - 451586 != -376204)
					{
						this.$self_$44600 = self_;
						if (196138 - 290698 == -94560)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x0600A990 RID: 43408 RVA: 0x012E7CB8 File Offset: 0x012E5EB8
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M948_HellRaiser.$ReturnToCamp$44596.$(this.$self_$44600);
		}

		// Token: 0x0600A991 RID: 43409 RVA: 0x012E7CC8 File Offset: 0x012E5EC8
		internal static bool MgUDZrV0XLBJwmRe4n8d()
		{
			return true;
		}

		// Token: 0x0600A992 RID: 43410 RVA: 0x012E7CCC File Offset: 0x012E5ECC
		internal static bool ynS7bXV0QnaAGW9qM76g()
		{
			return false;
		}

		// Token: 0x04009666 RID: 38502
		internal M948_HellRaiser $self_$44600;

		// Token: 0x02001C5D RID: 7261
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600A993 RID: 43411 RVA: 0x012E7CD0 File Offset: 0x012E5ED0
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M948_HellRaiser self_)
			{
				if (15704 - 67303 != -51599)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (18751 - 98412 == -79661)
					{
						base..ctor();
						if (140620 - 238386 == -97766)
						{
							this.$self_$44599 = self_;
							if (144258 - 576003 == -431745)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x0600A994 RID: 43412 RVA: 0x012E7D68 File Offset: 0x012E5F68
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (122776 - 144095 != -21319)
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
						this.$self_$44599.LeaveGame();
						if (173929 - 57533 != 116396)
						{
							continue;
						}
						this.YieldDefault(1);
						if (204838 - 225839 != -21000)
						{
							goto Block_2;
						}
						continue;
					default:
						if (129206 - 109705 != 19501)
						{
							continue;
						}
						break;
					}
					Game.mGameState = eGameState.Ended;
					if (232494 - 384553 == -152059)
					{
						Game.mStateTime = Time.time;
						if (168056 - 225253 == -57197)
						{
							this.$$switch$8234$44597 = PlayerData.SaveGuild;
							if (266846 - 94662 != 172185)
							{
								if (this.$$switch$8234$44597 == 1)
								{
									if (57926 - 298497 != -240571)
									{
										continue;
									}
									Game.mNextGameCode = 32;
									if (155891 - 465179 == -309287)
									{
										continue;
									}
								}
								else if (this.$$switch$8234$44597 == 2)
								{
									if (225342 - 293879 == -68536)
									{
										continue;
									}
									Game.mNextGameCode = 33;
									if (244278 - 164923 == 79356)
									{
										continue;
									}
								}
								else if (this.$$switch$8234$44597 == 3)
								{
									if (176464 - 516712 == -340247)
									{
										continue;
									}
									Game.mNextGameCode = 34;
									if (162128 - 430432 == -268303)
									{
										continue;
									}
								}
								else if (this.$$switch$8234$44597 == 4)
								{
									if (120204 - 91098 != 29106)
									{
										continue;
									}
									Game.mNextGameCode = 35;
									if (132806 - 333524 != -200718)
									{
										continue;
									}
								}
								else if (this.$$switch$8234$44597 == 5)
								{
									if (198343 - 166640 == 31704)
									{
										continue;
									}
									Game.mNextGameCode = 36;
									if (249495 - 283553 != -34058)
									{
										continue;
									}
								}
								else
								{
									Game.mNextGameCode = 30;
									if (221981 - 187938 != 34043)
									{
										continue;
									}
								}
								this.$mGameGui$44598 = (GameGui)this.$self_$44599.GetComponent(typeof(GameGui));
								if (80945 - 367431 == -286486)
								{
									if (this.$mGameGui$44598)
									{
										if (204247 - 298215 != -93968)
										{
											continue;
										}
										this.$mGameGui$44598.close();
										if (33951 - 541255 != -507304)
										{
											continue;
										}
									}
									this.$self_$44599.SendMessage("fadeOut");
									if (196752 - 297667 != -100914)
									{
										goto Block_20;
									}
								}
							}
						}
					}
				}
				Block_2:
				goto IL_363;
				Block_20:
				return this.Yield(2, new WaitForSeconds((float)1));
				IL_363:
				return false;
			}

			// Token: 0x0600A995 RID: 43413 RVA: 0x012E80EC File Offset: 0x012E62EC
			internal static bool fGV0XqV0kmcjZ0GNHjye()
			{
				return true;
			}

			// Token: 0x0600A996 RID: 43414 RVA: 0x012E80F0 File Offset: 0x012E62F0
			internal static bool JQs0EuV0GkQgP7YiRX0O()
			{
				return false;
			}

			// Token: 0x04009667 RID: 38503
			internal int $$switch$8234$44597;

			// Token: 0x04009668 RID: 38504
			internal GameGui $mGameGui$44598;

			// Token: 0x04009669 RID: 38505
			internal M948_HellRaiser $self_$44599;
		}
	}
}
