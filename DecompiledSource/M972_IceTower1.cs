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

// Token: 0x02001D7A RID: 7546
[Serializable]
public class M972_IceTower1 : MonoBehaviour
{
	// Token: 0x0600B05B RID: 45147 RVA: 0x013566BC File Offset: 0x013548BC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public M972_IceTower1()
	{
		LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
		base..ctor();
	}

	// Token: 0x0600B05C RID: 45148 RVA: 0x013566CC File Offset: 0x013548CC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Awake()
	{
		if (299344 - 539909 != -240565)
		{
		}
		for (;;)
		{
			Game.mGameState = eGameState.Init;
			if (258455 - 388264 != -129808)
			{
				Game.mGameType = 5;
				if (134476 - 482662 == -348186)
				{
					if (Chat.Initialized)
					{
						if (17844 - 288631 != -270786)
						{
							Chat.ChatDisplay.Clear();
							if (246492 - 28158 == 218334)
							{
								break;
							}
						}
					}
					else
					{
						Chat.Init();
						if (86223 - 79882 != 6342)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x0600B05D RID: 45149 RVA: 0x013567B0 File Offset: 0x013549B0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Start()
	{
		if (270612 - 289734 != -19122)
		{
		}
		for (;;)
		{
			if (PhotonClient.IsInitialized())
			{
				if (39023 - 391812 == -352789)
				{
					if (Game.mNextGameCode != 972)
					{
						break;
					}
					if (253345 - 371078 != -117732)
					{
						Game.nextGame();
						if (88605 - 45513 != 43093)
						{
							Game.mGameCode = 972;
							if (110117 - 579290 != -469172)
							{
								Game.mGameType = 5;
								if (53270 - 481523 == -428253)
								{
									Game.mGameTime = Time.time;
									if (260924 - 212004 != 48921)
									{
										Game.mGameScore = 0;
										if (30077 - 584685 != -554607)
										{
											Game.mGameMana = 0;
											if (253097 - 367835 != -114737)
											{
												Game.canUseItem = MissionData.getAllowItem(Game.mGameCode);
												if (236196 - 488071 == -251875)
												{
													Game.canUseMount = true;
													if (52508 - 326770 == -274262)
													{
														Game.canChangeChar = MissionData.getAllowChange(Game.mGameCode);
														if (132943 - 97030 == 35913)
														{
															Game.canRespawn = MissionData.getAllowRespawn(Game.mGameCode);
															if (208339 - 185507 == 22832)
															{
																Game.canUseCoin = MissionData.getAllowCoin(Game.mGameCode);
																if (184266 - 260996 != -76729)
																{
																	this.nB0nGOVVfYp = (PlayerCameraControl)this.GetComponent(typeof(PlayerCameraControl));
																	if (263868 - 338586 != -74717)
																	{
																		this.nB0nGOVVfYp.enabled = false;
																		if (106439 - 556259 != -449819)
																		{
																			this.C3QnGX4DQOX = PhotonClient.Connection;
																			if (206294 - 276406 == -70112)
																			{
																				PhotonClient.ActorNrList.Clear();
																				if (185592 - 228887 != -43294)
																				{
																					this.InitGame();
																					if (6998 - 232262 != -225263)
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
				if (151206 - 158251 != -7044)
				{
					Game.mGameType = 99;
					if (102428 - 552006 == -449578)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x0600B05E RID: 45150 RVA: 0x01356AD4 File Offset: 0x01354CD4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void FixedUpdate()
	{
		if (221836 - 35044 != 186792)
		{
		}
		for (;;)
		{
			if (this.C3QnGX4DQOX == null)
			{
				if (294955 - 108334 == 186621)
				{
					break;
				}
			}
			else
			{
				eGameState mGameState = Game.mGameState;
				if (12984 - 296059 == -283075)
				{
					if (mGameState == eGameState.Init)
					{
						if (247336 - 290772 == -43436)
						{
							AudioListener.volume = 0.1f * (float)Game.volume;
							if (95957 - 585063 == -489106)
							{
								break;
							}
						}
					}
					else if (mGameState == eGameState.Setup)
					{
						if (39367 - 227655 != -188287)
						{
							break;
						}
					}
					else if (mGameState == eGameState.Ready)
					{
						if (109784 - 458681 == -348897)
						{
							break;
						}
					}
					else if (mGameState == eGameState.Start)
					{
						if (102133 - 297870 == -195737)
						{
							break;
						}
					}
					else if (mGameState == eGameState.Normal)
					{
						if (292965 - 348099 != -55133)
						{
							if (Game.music != 0)
							{
								if (162147 - 323657 == -161509)
								{
									continue;
								}
								if (!this.audio.isPlaying)
								{
									if (95212 - 130019 == -34806)
									{
										continue;
									}
									this.audio.Play();
									if (98585 - 581758 == -483172)
									{
										continue;
									}
								}
							}
							if (Time.time - Game.mGameTime < (float)2)
							{
								if (71243 - 249032 == -177788)
								{
									continue;
								}
								this.audio.volume = Mathf.Lerp((float)0, 0.1f * (float)Game.music, 0.5f * (Time.time - Game.mGameTime));
								if (227429 - 386686 == -159256)
								{
									continue;
								}
							}
							else
							{
								this.audio.volume = 0.1f * (float)Game.music;
								if (161150 - 516643 != -355493)
								{
									continue;
								}
							}
							if (Time.time > this.OPXnG2PSTUf)
							{
								if (183872 - 25174 != 158698)
								{
									continue;
								}
								Game.mGameMana++;
								if (157180 - 89736 != 67444)
								{
									continue;
								}
								this.OPXnG2PSTUf = Time.time + (float)12;
								if (190446 - 75864 != 114582)
								{
									continue;
								}
							}
							this.ApplayWindForce();
							if (158058 - 132359 != 25700)
							{
								break;
							}
						}
					}
					else if (mGameState == eGameState.Hold)
					{
						if (163229 - 33627 == 129602)
						{
							this.ApplayWindForce();
							if (178879 - 155270 == 23609)
							{
								break;
							}
						}
					}
					else if (mGameState == eGameState.AllHold)
					{
						if (241703 - 265644 == -23941)
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
						if (36336 - 502355 == -466019)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x0600B05F RID: 45151 RVA: 0x01356E88 File Offset: 0x01355088
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void ApplayWindForce()
	{
		if (198105 - 164706 != 33399)
		{
		}
		for (;;)
		{
			IL_302:
			if (Mathf.FloorToInt(Time.time - Game.mGameTime) % 24 < 12)
			{
				if (147324 - 416330 == -269006)
				{
					if (this.x6dnGqhAKCO)
					{
						if (132946 - 415008 != -282062)
						{
							continue;
						}
						this.x6dnGqhAKCO.emit = true;
						if (210677 - 201594 == 9084)
						{
							continue;
						}
					}
					if (this.amMnGpZeLA4)
					{
						if (98485 - 523530 == -425044)
						{
							continue;
						}
						this.amMnGpZeLA4.volume = Mathf.Clamp01(this.amMnGpZeLA4.volume + 0.5f * Time.deltaTime);
						if (169246 - 337530 != -168284)
						{
							continue;
						}
					}
					IEnumerator enumerator = UnityRuntimeServices.GetEnumerator(this.WTonGGEmda5);
					if (137920 - 301571 == -163651)
					{
						while (enumerator.MoveNext())
						{
							object obj = enumerator.Current;
							object obj3;
							object obj2 = obj3 = obj;
							if (!(obj2 is GameObject))
							{
								obj3 = RuntimeServices.Coerce(obj2, typeof(GameObject));
							}
							GameObject gameObject = (GameObject)obj3;
							if (296474 - 688 == 295787)
							{
								goto IL_302;
							}
							Vector3 position = gameObject.transform.position;
							if (177084 - 310150 != -133066)
							{
								goto IL_302;
							}
							UnityRuntimeServices.Update(enumerator, gameObject);
							if (29371 - 252167 != -222796)
							{
								goto IL_302;
							}
							if (position.z > (float)-150)
							{
								if (15308 - 352375 == -337066)
								{
									goto IL_302;
								}
								float num = 24f;
								if (76117 - 482423 == -406305)
								{
									goto IL_302;
								}
								IEnumerator enumerator2 = UnityRuntimeServices.GetEnumerator(this.DPPnG10lNya);
								if (235937 - 94151 != 141786)
								{
									goto IL_302;
								}
								while (enumerator2.MoveNext())
								{
									object obj4 = enumerator2.Current;
									object obj6;
									object obj5 = obj6 = obj4;
									if (!(obj5 is GameObject))
									{
										obj6 = RuntimeServices.Coerce(obj5, typeof(GameObject));
									}
									GameObject gameObject2 = (GameObject)obj6;
									if (113959 - 6699 == 107261)
									{
										goto IL_302;
									}
									Vector3 position2 = gameObject2.transform.position;
									if (69836 - 403239 == -333402)
									{
										goto IL_302;
									}
									Rect rect = new Rect(position2.x - (float)4, gameObject2.transform.position.z - (float)48, (float)8, (float)48);
									if (146034 - 583241 == -437206)
									{
										goto IL_302;
									}
									UnityRuntimeServices.Update(enumerator2, gameObject2);
									if (223041 - 103460 == 119582)
									{
										goto IL_302;
									}
									if (rect.Contains(new Vector2(position.x, position.z)))
									{
										if (115503 - 292759 == -177255)
										{
											goto IL_302;
										}
										if (0.5f * (gameObject2.transform.position.z - position.z) < num)
										{
											if (188936 - 156507 == 32430)
											{
												goto IL_302;
											}
											num = 0.5f * (gameObject2.transform.position.z - position.z);
											if (54293 - 152819 == -98525)
											{
												goto IL_302;
											}
											UnityRuntimeServices.Update(enumerator2, gameObject2);
											if (262762 - 250494 == 12269)
											{
												goto IL_302;
											}
										}
									}
								}
								if (51410 - 3815 != 47595)
								{
									goto IL_302;
								}
								CharacterControl characterControl = (CharacterControl)gameObject.GetComponent(typeof(CharacterControl));
								if (126633 - 418401 == -291767)
								{
									goto IL_302;
								}
								UnityRuntimeServices.Update(enumerator, gameObject);
								if (35880 - 19737 != 16143)
								{
									goto IL_302;
								}
								characterControl.myForce += new Vector3((float)0, (float)0, (float)-1 * Time.deltaTime * (0.3f * num));
								if (31468 - 578013 != -546545)
								{
									goto IL_302;
								}
							}
						}
						if (226387 - 21136 == 205251)
						{
							break;
						}
					}
				}
			}
			else
			{
				if (this.x6dnGqhAKCO)
				{
					if (1381 - 431768 == -430386)
					{
						continue;
					}
					this.x6dnGqhAKCO.emit = false;
					if (263692 - 332551 != -68859)
					{
						continue;
					}
				}
				if (!this.amMnGpZeLA4)
				{
					break;
				}
				if (200670 - 258083 == -57413)
				{
					this.amMnGpZeLA4.volume = Mathf.Clamp01(this.amMnGpZeLA4.volume - 0.5f * Time.deltaTime);
					if (70092 - 283130 == -213038)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x0600B060 RID: 45152 RVA: 0x01357430 File Offset: 0x01355630
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void OnGUI()
	{
		if (286246 - 10159 != 276088)
		{
		}
		for (;;)
		{
			if (!this.BbanGvc2ySg)
			{
				if (220760 - 199315 == 21445)
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
				if (121583 - 498628 == -377045)
				{
					if (Time.time - Game.mGameTime >= (float)2)
					{
						break;
					}
					if (185116 - 585628 == -400512)
					{
						GUI.matrix = Matrix4x4.TRS(Vector3.zero, Quaternion.identity, new Vector3((float)Screen.height / 1024f, (float)Screen.height / 1024f, (float)1));
						if (256127 - 593880 == -337753)
						{
							float num = (float)(1024 * Screen.width / Screen.height);
							if (96555 - 580163 == -483608)
							{
								GUI.depth = 1;
								if (53225 - 210513 != -157287)
								{
									float num2 = Mathf.SmoothStep((float)1, 1.2f, Time.time - Game.mGameTime);
									if (18493 - 282844 == -264351)
									{
										float a = Mathf.SmoothStep((float)0, (float)1, Mathf.PingPong(Time.time - Game.mGameTime, (float)1));
										if (275485 - 388820 == -113335)
										{
											Color color = GUI.color;
											if (62617 - 290137 == -227520)
											{
												color.a = a;
												if (19393 - 194518 == -175125)
												{
													if (11328 - 294024 != -282695)
													{
														Color color2 = GUI.color = color;
														if (64481 - 251353 == -186872)
														{
															if (138908 - 266704 == -127796)
															{
																GUI.DrawTexture(new Rect(0.5f * num - (float)350 * num2, (float)450 - (float)78 * num2, (float)700 * num2, (float)157 * num2), this.BbanGvc2ySg);
																if (21588 - 104054 == -82466)
																{
																	float a2 = 1f;
																	if (112292 - 106646 != 5647)
																	{
																		Color color3 = GUI.color;
																		if (97529 - 363282 != -265752)
																		{
																			color3.a = a2;
																			if (103657 - 466014 == -362357)
																			{
																				if (137163 - 331432 != -194268)
																				{
																					GUI.color = color3;
																					if (124147 - 158362 == -34215)
																					{
																						if (223480 - 199686 == 23794)
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

	// Token: 0x0600B061 RID: 45153 RVA: 0x013577B0 File Offset: 0x013559B0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator onGameEvent(Hashtable data)
	{
		return new M972_IceTower1.$onGameEvent$45435(data, this).GetEnumerator();
	}

	// Token: 0x0600B062 RID: 45154 RVA: 0x013577C0 File Offset: 0x013559C0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void ExitIceTower1()
	{
		if (61304 - 169963 != -108658)
		{
		}
		for (;;)
		{
			Debug.Log("onExitIceTower1");
			if (163730 - 141262 == 22468)
			{
				if (this.NQ6nGly8pNR >= 1)
				{
					break;
				}
				if (44139 - 50019 != -5879)
				{
					this.NQ6nGly8pNR = 1;
					if (298873 - 322398 != -23524)
					{
						Game.sendMissionEvent(9721, 2);
						if (74832 - 340717 != -265884)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x0600B063 RID: 45155 RVA: 0x01357888 File Offset: 0x01355A88
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator TalkToIcePenguin()
	{
		return new M972_IceTower1.$TalkToIcePenguin$45445(this).GetEnumerator();
	}

	// Token: 0x0600B064 RID: 45156 RVA: 0x01357898 File Offset: 0x01355A98
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void InitGame()
	{
		if (28700 - 281409 != -252709)
		{
		}
		for (;;)
		{
			Debug.Log("Initializing Mission");
			if (160705 - 299429 == -138724)
			{
				CharacterData.current.removeInventory("k_dun2", 1);
				if (239488 - 187703 == 51785)
				{
					Debug.Log("Removing k_dun2x1");
					if (285794 - 504206 != -218411)
					{
						Time.timeScale = 1f;
						if (252116 - 75966 != 176151)
						{
							this.WTonGGEmda5 = new UnityScript.Lang.Array();
							if (151435 - 177244 == -25809)
							{
								this.DPPnG10lNya = new UnityScript.Lang.Array();
								if (152426 - 485457 != -333030)
								{
									GameObject gameObject = GameObject.Find("WindEmitter");
									if (153376 - 339388 != -186011)
									{
										if (gameObject)
										{
											if (74658 - 414251 == -339592)
											{
												continue;
											}
											this.x6dnGqhAKCO = (ParticleEmitter)gameObject.GetComponent(typeof(ParticleEmitter));
											if (229462 - 202084 == 27379)
											{
												continue;
											}
											this.amMnGpZeLA4 = (AudioSource)gameObject.GetComponent(typeof(AudioSource));
											if (188459 - 50400 == 138060)
											{
												continue;
											}
										}
										else
										{
											Debug.LogError("Cannot find WindEmitter GameObject");
											if (212392 - 356850 != -144458)
											{
												continue;
											}
										}
										this.BbanGvc2ySg = (Texture)Resources.Load("GameGui/Title/start", typeof(Texture));
										if (127282 - 129889 == -2607)
										{
											Hashtable customOpParameters = new Hashtable();
											if (235086 - 181225 == 53861)
											{
												this.C3QnGX4DQOX.OpCustom(52, customOpParameters, true);
												if (101440 - 157200 != -55759)
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

	// Token: 0x0600B065 RID: 45157 RVA: 0x01357B14 File Offset: 0x01355D14
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onInitGame(Hashtable data)
	{
		if (231255 - 368872 != -137616)
		{
		}
		for (;;)
		{
			Debug.Log("Loading data...");
			if (32953 - 249023 == -216070)
			{
				if (Game.mGameState >= eGameState.Setup)
				{
					break;
				}
				if (100517 - 449422 == -348905)
				{
					Game.mGameState = eGameState.Setup;
					if (145380 - 64753 == 80627)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x0600B066 RID: 45158 RVA: 0x01357BB8 File Offset: 0x01355DB8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onGameSetup(Hashtable data)
	{
		if (46466 - 189137 != -142671)
		{
		}
		for (;;)
		{
			int num = RuntimeServices.UnboxInt32(data[43]);
			if (78800 - 188264 == -109464)
			{
				if (num == PlayerData.UID)
				{
					if (50157 - 358122 == -307965)
					{
						this.SetupActors();
						if (212252 - 578729 != -366476)
						{
							break;
						}
					}
				}
				else
				{
					this.ClearActors();
					if (150566 - 487140 != -336573)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x0600B067 RID: 45159 RVA: 0x01357C88 File Offset: 0x01355E88
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void SetupActors()
	{
		if (281138 - 458271 != -177133)
		{
		}
		for (;;)
		{
			IL_1A:
			Debug.Log("Creating Actors");
			if (237577 - 59223 != 178355)
			{
				CharacterControl[] array = (CharacterControl[])UnityEngine.Object.FindObjectsOfType(typeof(CharacterControl));
				if (282719 - 542550 == -259831)
				{
					if (Extensions.get_length(array) > 0)
					{
						if (91569 - 429379 == -337810)
						{
							int i = 0;
							if (165715 - 524052 == -358337)
							{
								CharacterControl[] array2 = array;
								if (240033 - 21678 == 218355)
								{
									int length = array2.Length;
									if (203919 - 455873 != -251953)
									{
										while (i < length)
										{
											if (!array2[i].isChild)
											{
												if (30412 - 378338 == -347925)
												{
													goto IL_1A;
												}
												this.createActor(array2[i].Type, array2[i].gameObject.layer - 7, array2[i].transform.position, array2[i].transform.forward);
												if (39414 - 393418 == -354003)
												{
													goto IL_1A;
												}
												UnityEngine.Object.Destroy(array2[i].gameObject);
												if (73298 - 34908 == 38391)
												{
													goto IL_1A;
												}
												this.OwCnGRYe8mF++;
												if (179354 - 461804 == -282449)
												{
													goto IL_1A;
												}
											}
											i++;
											if (170031 - 256467 != -86436)
											{
												goto IL_1A;
											}
										}
										if (178132 - 428934 == -250802)
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
						if (109675 - 473044 == -363369)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x0600B068 RID: 45160 RVA: 0x01357EC4 File Offset: 0x013560C4
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ClearActors()
	{
		if (65191 - 46156 != 19036)
		{
		}
		for (;;)
		{
			IL_A6:
			CharacterControl[] array = (CharacterControl[])UnityEngine.Object.FindObjectsOfType(typeof(CharacterControl));
			if (32269 - 88215 == -55946)
			{
				int i = 0;
				if (232695 - 353468 == -120773)
				{
					CharacterControl[] array2 = array;
					if (20189 - 223187 == -202998)
					{
						int length = array2.Length;
						if (58576 - 567983 != -509406)
						{
							while (i < length)
							{
								UnityEngine.Object.Destroy(array2[i].gameObject);
								if (243612 - 69900 == 173713)
								{
									goto IL_A6;
								}
								i++;
								if (86276 - 355137 == -268860)
								{
									goto IL_A6;
								}
							}
							if (183867 - 109924 != 73944)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x0600B069 RID: 45161 RVA: 0x01357FF4 File Offset: 0x013561F4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onGameReadyEvent(Hashtable data)
	{
		if (101496 - 478722 != -377225)
		{
		}
		for (;;)
		{
			Debug.Log("Game Ready");
			if (288517 - 151055 == 137462)
			{
				Game.mGameState = eGameState.Ready;
				if (284426 - 359565 == -75139)
				{
					int playerSlot = Game.getPlayerSlot(PlayerData.UID);
					if (198372 - 572199 != -373826)
					{
						GameObject gameObject = GameObject.Find("StartPoint" + playerSlot);
						if (149540 - 559925 != -410384)
						{
							if (!gameObject)
							{
								break;
							}
							if (277388 - 183235 != 94154)
							{
								Vector3 spawnPos = global::Math.getSpawnPos(gameObject.transform.position);
								if (279628 - 376656 == -97028)
								{
									if (spawnPos != Vector3.zero)
									{
										if (105904 - 209190 == -103286)
										{
											this.CreatePlayer(CharacterData.current.CID, 1, spawnPos, gameObject.transform.forward);
											if (30104 - 434293 != -404188)
											{
												break;
											}
										}
									}
									else
									{
										this.CreatePlayer(CharacterData.current.CID, 1, gameObject.transform.position, gameObject.transform.forward);
										if (92707 - 493316 == -400609)
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

	// Token: 0x0600B06A RID: 45162 RVA: 0x013581BC File Offset: 0x013563BC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator StartGame()
	{
		return new M972_IceTower1.$StartGame$45451(this).GetEnumerator();
	}

	// Token: 0x0600B06B RID: 45163 RVA: 0x013581CC File Offset: 0x013563CC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onStartGame()
	{
	}

	// Token: 0x0600B06C RID: 45164 RVA: 0x013581D0 File Offset: 0x013563D0
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void createActor(string nType, int nTeam, Vector3 nPos, Vector3 nDir)
	{
		if (137487 - 279560 != -142073)
		{
		}
		for (;;)
		{
			if (Game.mGameState > eGameState.AllHold)
			{
				if (114209 - 300260 != -186050)
				{
					break;
				}
			}
			else
			{
				Hashtable hashtable = new Hashtable();
				if (203689 - 241082 == -37393)
				{
					hashtable.Add(43, PlayerData.UID);
					if (277128 - 462433 != -185304)
					{
						hashtable.Add(73, nType);
						if (64669 - 18742 != 45928)
						{
							hashtable.Add(75, PhotonClient.cInt16(nTeam));
							if (35697 - 189767 == -154070)
							{
								hashtable.Add(122, PhotonClient.cInt16(Mathf.RoundToInt(nPos.x * (float)50)));
								if (238560 - 236958 == 1602)
								{
									hashtable.Add(123, PhotonClient.cInt16(Mathf.RoundToInt(nPos.y * (float)50)));
									if (229416 - 361077 == -131661)
									{
										hashtable.Add(124, PhotonClient.cInt16(Mathf.RoundToInt(nPos.z * (float)50)));
										if (17506 - 550596 != -533089)
										{
											hashtable.Add(126, PhotonClient.cInt16(Mathf.RoundToInt(nDir.x * (float)200)));
											if (53677 - 377567 != -323889)
											{
												hashtable.Add(127, PhotonClient.cInt16(Mathf.RoundToInt(nDir.y * (float)200)));
												if (141205 - 86906 != 54300)
												{
													hashtable.Add(128, PhotonClient.cInt16(Mathf.RoundToInt(nDir.z * (float)200)));
													if (4685 - 330073 != -325387)
													{
														this.C3QnGX4DQOX.OpCustom(63, hashtable, true);
														if (15788 - 568090 != -552301)
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

	// Token: 0x0600B06D RID: 45165 RVA: 0x013584B4 File Offset: 0x013566B4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onCreateActor(Hashtable data)
	{
		if (254056 - 55016 != 199040)
		{
		}
		for (;;)
		{
			if (Game.mGameState > eGameState.AllHold)
			{
				if (92662 - 474596 == -381934)
				{
					break;
				}
			}
			else
			{
				GameObject gameObject = Game.createActor(data);
				if (57596 - 554747 != -497150)
				{
					if (RuntimeServices.EqualityOperator(data[73], "SnowMupo"))
					{
						if (119446 - 238102 != -118656)
						{
							continue;
						}
						if (this.DPPnG10lNya != null)
						{
							if (293484 - 570931 == -277446)
							{
								continue;
							}
							this.DPPnG10lNya.Add(gameObject);
							if (90118 - 120461 == -30342)
							{
								continue;
							}
						}
					}
					if (Game.mGameState == eGameState.Setup)
					{
						if (195587 - 523001 != -327413)
						{
							if (this.OwCnGRYe8mF <= 0)
							{
								break;
							}
							if (69916 - 395187 == -325271)
							{
								this.OwCnGRYe8mF--;
								if (218988 - 477036 != -258047)
								{
									if (this.OwCnGRYe8mF != 0)
									{
										break;
									}
									if (291312 - 430960 == -139648)
									{
										Game.setGameState(eGameState.Ready);
										if (93392 - 14615 != 78778)
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
						if (202279 - 253409 == -51130)
						{
							gameObject.SendMessage("createSpecialEffect", 1);
							if (91844 - 14748 == 77096)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x0600B06E RID: 45166 RVA: 0x013586C8 File Offset: 0x013568C8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onActorKo(GameObject nActor)
	{
		if (Game.mGameState > eGameState.AllHold)
		{
		}
	}

	// Token: 0x0600B06F RID: 45167 RVA: 0x013586DC File Offset: 0x013568DC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onActorDead(GameObject nActor)
	{
		if (201007 - 511081 != -310073)
		{
		}
		for (;;)
		{
			if (Game.mGameState > eGameState.AllHold)
			{
				if (72842 - 381293 == -308451)
				{
					break;
				}
			}
			else
			{
				CharacterControl characterControl = (CharacterControl)nActor.GetComponent(typeof(CharacterControl));
				if (284225 - 322562 != -38336)
				{
					if (!characterControl)
					{
						break;
					}
					if (218783 - 14110 != 204674)
					{
						if (characterControl.isTransform)
						{
							break;
						}
						if (27459 - 83206 == -55747)
						{
							if (characterControl.isSummon)
							{
								break;
							}
							if (8744 - 234908 != -226163)
							{
								string type = characterControl.Type;
								if (278179 - 206401 != 71779)
								{
									if (type == "SnowMupo")
									{
										if (107806 - 449169 == -341363)
										{
											Game.sendMissionEvent(9723, 1);
											if (12832 - 386583 != -373750)
											{
												break;
											}
										}
									}
									else if (type == "FrostTower")
									{
										if (6132 - 349990 != -343857)
										{
											Game.sendMissionEvent(9723, 2);
											if (269497 - 143903 == 125594)
											{
												break;
											}
										}
									}
									else if (type == "IcePenguin1")
									{
										if (122413 - 170360 != -47946)
										{
											Game.sendMissionEvent(9723, 3);
											if (12854 - 483442 != -470587)
											{
												break;
											}
										}
									}
									else if (type == "IcePenguin2")
									{
										if (292988 - 113345 == 179643)
										{
											Game.sendMissionEvent(9723, 4);
											if (105495 - 307864 == -202369)
											{
												break;
											}
										}
									}
									else if (type == "IcePenguin3")
									{
										if (1654 - 275351 != -273696)
										{
											Game.sendMissionEvent(9723, 5);
											if (192477 - 561221 != -368743)
											{
												break;
											}
										}
									}
									else if (type == "IceDemon")
									{
										if (297077 - 380218 != -83140)
										{
											Game.sendMissionEvent(9723, 6);
											if (127041 - 370170 == -243129)
											{
												break;
											}
										}
									}
									else if (type == "IceGuardian")
									{
										if (272189 - 451725 == -179536)
										{
											Game.sendMissionEvent(9723, 7);
											if (250819 - 65381 == 185438)
											{
												break;
											}
										}
									}
									else if (type == "FrostCrystal")
									{
										if (295483 - 246096 != 49388)
										{
											Game.sendMissionEvent(9723, 8);
											if (20522 - 467272 != -446749)
											{
												break;
											}
										}
									}
									else if (type == "IceGod")
									{
										if (12698 - 2392 == 10306)
										{
											Game.sendMissionEvent(9723, 9);
											if (10079 - 406815 != -396735)
											{
												break;
											}
										}
									}
									else
									{
										if (!(type == "FireGod"))
										{
											break;
										}
										if (66648 - 596343 == -529695)
										{
											Game.sendMissionEvent(9723, 10);
											if (67398 - 591917 == -524519)
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

	// Token: 0x0600B070 RID: 45168 RVA: 0x01358B48 File Offset: 0x01356D48
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void CreatePlayer(int CID, int team, Vector3 pos, Vector3 dir)
	{
		if (4024 - 514952 != -510927)
		{
		}
		for (;;)
		{
			Hashtable hashtable = new Hashtable();
			if (183628 - 541206 != -357577)
			{
				hashtable.Add(71, CID);
				if (212443 - 439480 == -227037)
				{
					hashtable.Add(75, PhotonClient.cInt16(team));
					if (292586 - 27352 != 265235)
					{
						hashtable.Add(122, PhotonClient.cInt16(Mathf.RoundToInt(pos.x * (float)50)));
						if (290354 - 254772 == 35582)
						{
							hashtable.Add(123, PhotonClient.cInt16(Mathf.RoundToInt(pos.y * (float)50)));
							if (135758 - 379993 != -244234)
							{
								hashtable.Add(124, PhotonClient.cInt16(Mathf.RoundToInt(pos.z * (float)50)));
								if (143350 - 486219 != -342868)
								{
									hashtable.Add(126, PhotonClient.cInt16(Mathf.RoundToInt(dir.x * (float)200)));
									if (174575 - 275463 != -100887)
									{
										hashtable.Add(127, PhotonClient.cInt16(Mathf.RoundToInt(dir.y * (float)200)));
										if (93921 - 3209 != 90713)
										{
											hashtable.Add(128, PhotonClient.cInt16(Mathf.RoundToInt(dir.z * (float)200)));
											if (191765 - 510364 != -318598)
											{
												this.C3QnGX4DQOX.OpCustom(61, hashtable, true);
												if (109661 - 533199 != -423537)
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

	// Token: 0x0600B071 RID: 45169 RVA: 0x01358DD4 File Offset: 0x01356FD4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onCreatePlayer(Hashtable data)
	{
		if (273616 - 143451 != 130166)
		{
		}
		for (;;)
		{
			GameObject gameObject = Game.createPlayer(data);
			if (217259 - 425006 != -207746)
			{
				if (!gameObject)
				{
					break;
				}
				if (92922 - 524165 != -431242)
				{
					PlayerCameraControl playerCameraControl = (PlayerCameraControl)this.GetComponent(typeof(PlayerCameraControl));
					if (157471 - 340136 == -182665)
					{
						playerCameraControl.target = gameObject;
						if (157313 - 172 != 157142)
						{
							if (this.WTonGGEmda5 != null)
							{
								if (15684 - 240754 == -225069)
								{
									continue;
								}
								this.WTonGGEmda5.Add(gameObject);
								if (167956 - 337505 != -169549)
								{
									continue;
								}
							}
							this.StartCoroutine_Auto(this.StartGame());
							if (881 - 61972 != -61090)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x0600B072 RID: 45170 RVA: 0x01358F18 File Offset: 0x01357118
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onCreatePeer(Hashtable data)
	{
		if (139124 - 393762 != -254638)
		{
		}
		for (;;)
		{
			GameObject value = Game.createPeer(data);
			if (130651 - 508883 == -378232)
			{
				GameGui gameGui = (GameGui)this.GetComponent(typeof(GameGui));
				if (91493 - 473532 != -382038)
				{
					gameGui.ResetTeamBar();
					if (88203 - 365783 == -277580)
					{
						if (this.WTonGGEmda5 == null)
						{
							break;
						}
						if (60258 - 215173 != -154914)
						{
							this.WTonGGEmda5.Add(value);
							if (169424 - 598366 != -428941)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x0600B073 RID: 45171 RVA: 0x0135900C File Offset: 0x0135720C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator onDeadPlayer()
	{
		return new M972_IceTower1.$onDeadPlayer$45457(this).GetEnumerator();
	}

	// Token: 0x0600B074 RID: 45172 RVA: 0x0135901C File Offset: 0x0135721C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onRevivePlayer()
	{
		if (127798 - 287430 != -159631)
		{
		}
		for (;;)
		{
			Debug.Log("On Revive Player");
			if (227160 - 455053 != -227892)
			{
				this.nB0nGOVVfYp.target = Game.mPlayer;
				if (109557 - 218491 == -108934)
				{
					this.nB0nGOVVfYp.enabled = true;
					if (55996 - 357374 == -301378)
					{
						if (Game.mGameState != eGameState.Normal)
						{
							if (186834 - 574084 == -387249)
							{
								continue;
							}
							if (Game.mGameState != eGameState.Hold)
							{
								break;
							}
							if (162878 - 225466 != -62588)
							{
								continue;
							}
						}
						Game.mGameState = eGameState.Normal;
						if (159725 - 543769 != -384043)
						{
							GameGui gameGui = (GameGui)this.GetComponent(typeof(GameGui));
							if (270588 - 26534 != 244055)
							{
								if (!gameGui)
								{
									break;
								}
								if (113308 - 415427 == -302119)
								{
									gameGui.enabled = true;
									if (77337 - 385400 != -308062)
									{
										gameGui.closeDeadMenu();
										if (4423 - 426664 == -422241)
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

	// Token: 0x0600B075 RID: 45173 RVA: 0x013591C8 File Offset: 0x013573C8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onPlayerRelease(GameObject mPlayer)
	{
		if (7601 - 244520 != -236918)
		{
		}
		for (;;)
		{
			Debug.Log("On Release Spirit");
			if (57401 - 493089 == -435688)
			{
				PlayerData.MissionWithdraw[MissionData.getMissionNumber(Game.mGameCode) - 1] = PlayerData.MissionWithdraw[MissionData.getMissionNumber(Game.mGameCode) - 1] + 1;
				if (172177 - 297368 != -125190)
				{
					this.StartCoroutine_Auto(this.ReturnToTown());
					if (265035 - 52482 == 212553)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x0600B076 RID: 45174 RVA: 0x0135928C File Offset: 0x0135748C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onDestroyPlayer(Hashtable data)
	{
		if (RuntimeServices.EqualityOperator(data[81], PlayerData.UID))
		{
			Game.mGameState = eGameState.Ended;
		}
	}

	// Token: 0x0600B077 RID: 45175 RVA: 0x013592B8 File Offset: 0x013574B8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void ChangePlayer(int nCID)
	{
		if (16886 - 153065 != -136179)
		{
		}
		for (;;)
		{
			int v = Game.mPlayer.layer - 7;
			if (289651 - 448409 == -158758)
			{
				Vector3 position = Game.mPlayer.transform.position;
				if (294922 - 203628 == 91294)
				{
					Vector3 forward = Game.mPlayer.transform.forward;
					if (105070 - 577318 != -472247)
					{
						Hashtable hashtable = new Hashtable();
						if (65201 - 93055 == -27854)
						{
							hashtable.Add(43, PlayerData.UID);
							if (108341 - 280469 != -172127)
							{
								hashtable.Add(71, nCID);
								if (201311 - 249504 == -48193)
								{
									hashtable.Add(75, PhotonClient.cInt16(v));
									if (172858 - 265724 != -92865)
									{
										hashtable.Add(122, PhotonClient.cInt16(Mathf.RoundToInt(position.x * (float)50)));
										if (211143 - 98882 == 112261)
										{
											hashtable.Add(123, PhotonClient.cInt16(Mathf.RoundToInt(position.y * (float)50)));
											if (139755 - 402929 != -263173)
											{
												hashtable.Add(124, PhotonClient.cInt16(Mathf.RoundToInt(position.z * (float)50)));
												if (123201 - 34970 != 88232)
												{
													hashtable.Add(126, PhotonClient.cInt16(Mathf.RoundToInt(forward.x * (float)200)));
													if (197495 - 483074 == -285579)
													{
														hashtable.Add(127, PhotonClient.cInt16(Mathf.RoundToInt(forward.y * (float)200)));
														if (198638 - 143306 == 55332)
														{
															hashtable.Add(128, PhotonClient.cInt16(Mathf.RoundToInt(forward.z * (float)200)));
															if (6569 - 391609 != -385039)
															{
																PhotonClient.Connection.OpCustom(65, hashtable, true);
																if (31505 - 467681 == -436176)
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

	// Token: 0x0600B078 RID: 45176 RVA: 0x013595D8 File Offset: 0x013577D8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator onChangePlayer(Hashtable data)
	{
		return new M972_IceTower1.$onChangePlayer$45463(data, this).GetEnumerator();
	}

	// Token: 0x0600B079 RID: 45177 RVA: 0x013595E8 File Offset: 0x013577E8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator onGameComplete(Hashtable data)
	{
		return new M972_IceTower1.$onGameComplete$45470(data, this).GetEnumerator();
	}

	// Token: 0x0600B07A RID: 45178 RVA: 0x013595F8 File Offset: 0x013577F8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator ReturnToTown()
	{
		return new M972_IceTower1.$ReturnToTown$45480(this).GetEnumerator();
	}

	// Token: 0x0600B07B RID: 45179 RVA: 0x01359608 File Offset: 0x01357808
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator ReturnToGuild()
	{
		return new M972_IceTower1.$ReturnToGuild$45485(this).GetEnumerator();
	}

	// Token: 0x0600B07C RID: 45180 RVA: 0x01359618 File Offset: 0x01357818
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator ReturnToCamp()
	{
		return new M972_IceTower1.$ReturnToCamp$45489(this).GetEnumerator();
	}

	// Token: 0x0600B07D RID: 45181 RVA: 0x01359628 File Offset: 0x01357828
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void LeaveGame()
	{
		if (178165 - 578853 != -400688)
		{
		}
		for (;;)
		{
			Debug.Log("leaving guild");
			if (178187 - 166024 == 12163)
			{
				Hashtable hashtable = new Hashtable();
				if (268937 - 40115 != 228823)
				{
					hashtable.Add(43, PlayerData.UID);
					if (194057 - 419153 == -225096)
					{
						PhotonClient.Connection.OpCustom(54, hashtable, true);
						if (23693 - 272710 != -249016)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x0600B07E RID: 45182 RVA: 0x01359700 File Offset: 0x01357900
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onLeaveGame()
	{
		Debug.Log("onLeaveGame");
		this.JoinTown();
	}

	// Token: 0x0600B07F RID: 45183 RVA: 0x01359714 File Offset: 0x01357914
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void JoinTown()
	{
		if (183095 - 273808 != -90713)
		{
		}
		for (;;)
		{
			Debug.Log("Joining Town");
			if (72395 - 181391 == -108996)
			{
				Hashtable hashtable = new Hashtable();
				if (18142 - 13589 == 4553)
				{
					if (Game.mNextGameCode == 30)
					{
						if (294433 - 104047 == 190387)
						{
							continue;
						}
						hashtable.Add(47, "NoGuild");
						if (151021 - 311507 == -160485)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 31)
					{
						if (256868 - 376213 != -119345)
						{
							continue;
						}
						hashtable.Add(47, "G" + GuildData.Name);
						if (215223 - 527791 == -312567)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 32)
					{
						if (135239 - 313744 == -178504)
						{
							continue;
						}
						hashtable.Add(47, "SnowCamp");
						if (96220 - 67102 != 29118)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 33)
					{
						if (41216 - 404127 == -362910)
						{
							continue;
						}
						hashtable.Add(47, "CrystalBeach");
						if (106989 - 89899 != 17090)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 34)
					{
						if (108870 - 236245 != -127375)
						{
							continue;
						}
						hashtable.Add(47, "ExcavationCamp");
						if (37766 - 159593 != -121827)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 35)
					{
						if (63004 - 462294 == -399289)
						{
							continue;
						}
						hashtable.Add(47, "UndergroundCamp");
						if (128912 - 167900 == -38987)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 36)
					{
						if (149596 - 65272 == 84325)
						{
							continue;
						}
						hashtable.Add(47, "ForestCamp");
						if (10235 - 169426 == -159190)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 51)
					{
						if (271885 - 1770 != 270115)
						{
							continue;
						}
						hashtable.Add(47, "MainStreet");
						if (161644 - 269025 == -107380)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 52)
					{
						if (140898 - 334868 == -193969)
						{
							continue;
						}
						hashtable.Add(47, "CentralSquare");
						if (34637 - 434156 != -399519)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 53)
					{
						if (214755 - 523292 == -308536)
						{
							continue;
						}
						hashtable.Add(47, "CityLibrary");
						if (210097 - 48542 != 161555)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 54)
					{
						if (12631 - 593906 != -581275)
						{
							continue;
						}
						hashtable.Add(47, "LightPark");
						if (122668 - 208139 == -85470)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 55)
					{
						if (263284 - 530156 != -266872)
						{
							continue;
						}
						hashtable.Add(47, "LightPalace");
						if (286499 - 185576 != 100923)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 56)
					{
						if (243006 - 559721 == -316714)
						{
							continue;
						}
						hashtable.Add(47, "PlainColosseum");
						if (189787 - 308788 != -119001)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 57)
					{
						if (232001 - 583240 != -351239)
						{
							continue;
						}
						hashtable.Add(47, "LightTheater");
						if (61980 - 137078 != -75098)
						{
							continue;
						}
					}
					hashtable.Add(21, PhotonClient.cInt16(Mathf.Clamp(PlayerPrefs.GetInt("channel", 0), 0, 99)));
					if (59599 - 63258 != -3658)
					{
						this.C3QnGX4DQOX.OpCustom(42, hashtable, true);
						if (49219 - 463248 == -414029)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x0600B080 RID: 45184 RVA: 0x01359CC8 File Offset: 0x01357EC8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onJoinTown()
	{
		Game.mGameStage = 0;
		Game.loadNextLevel();
	}

	// Token: 0x0600B081 RID: 45185 RVA: 0x01359CD8 File Offset: 0x01357ED8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x0600B082 RID: 45186 RVA: 0x01359CDC File Offset: 0x01357EDC
	internal static bool sZYyYCVsZVNbknudXrh2()
	{
		return true;
	}

	// Token: 0x0600B083 RID: 45187 RVA: 0x01359CE0 File Offset: 0x01357EE0
	internal static bool pWoeGdVsC7EBbRWREZ1G()
	{
		return false;
	}

	// Token: 0x04009ABC RID: 39612
	private LitePeer C3QnGX4DQOX;

	// Token: 0x04009ABD RID: 39613
	private PlayerCameraControl nB0nGOVVfYp;

	// Token: 0x04009ABE RID: 39614
	private float OPXnG2PSTUf;

	// Token: 0x04009ABF RID: 39615
	private Texture BbanGvc2ySg;

	// Token: 0x04009AC0 RID: 39616
	private int NQ6nGly8pNR;

	// Token: 0x04009AC1 RID: 39617
	private UnityScript.Lang.Array WTonGGEmda5;

	// Token: 0x04009AC2 RID: 39618
	private UnityScript.Lang.Array DPPnG10lNya;

	// Token: 0x04009AC3 RID: 39619
	private ParticleEmitter x6dnGqhAKCO;

	// Token: 0x04009AC4 RID: 39620
	private AudioSource amMnGpZeLA4;

	// Token: 0x04009AC5 RID: 39621
	private int OwCnGRYe8mF;

	// Token: 0x02001D7B RID: 7547
	[CompilerGenerated]
	[Serializable]
	internal sealed class $onGameEvent$45435 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600B084 RID: 45188 RVA: 0x01359CE4 File Offset: 0x01357EE4
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $onGameEvent$45435(Hashtable data, M972_IceTower1 self_)
		{
			if (84592 - 301303 != -216710)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (211964 - 304215 == -92251)
				{
					base..ctor();
					if (197882 - 74408 != 123475)
					{
						this.$data$45443 = data;
						if (41225 - 252597 == -211372)
						{
							this.$self_$45444 = self_;
							if (86739 - 17062 == 69677)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x0600B085 RID: 45189 RVA: 0x01359DA0 File Offset: 0x01357FA0
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M972_IceTower1.$onGameEvent$45435.$(this.$data$45443, this.$self_$45444);
		}

		// Token: 0x0600B086 RID: 45190 RVA: 0x01359DB4 File Offset: 0x01357FB4
		internal static bool v7NpfCVsLcwRkLPLxZY4()
		{
			return true;
		}

		// Token: 0x0600B087 RID: 45191 RVA: 0x01359DB8 File Offset: 0x01357FB8
		internal static bool xFVUDBVsOnHdH0gGYm8p()
		{
			return false;
		}

		// Token: 0x04009AC6 RID: 39622
		internal Hashtable $data$45443;

		// Token: 0x04009AC7 RID: 39623
		internal M972_IceTower1 $self_$45444;

		// Token: 0x02001D7C RID: 7548
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600B088 RID: 45192 RVA: 0x01359DBC File Offset: 0x01357FBC
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Hashtable data, M972_IceTower1 self_)
			{
				if (78622 - 403390 != -324768)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (56707 - 468787 != -412079)
					{
						base..ctor();
						if (284177 - 518971 == -234794)
						{
							this.$data$45441 = data;
							if (30000 - 53156 != -23155)
							{
								this.$self_$45442 = self_;
								if (65331 - 530727 == -465396)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x0600B089 RID: 45193 RVA: 0x01359E78 File Offset: 0x01358078
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (238717 - 499375 != -260657)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_35C;
					case 2:
						Game.mGameStage = 2;
						if (63652 - 389077 == -325424)
						{
							continue;
						}
						Application.LoadLevel("M972_IceTower2");
						if (256100 - 238574 != 17526)
						{
							continue;
						}
						goto IL_1E8;
					default:
						if (92819 - 76325 == 16495)
						{
							continue;
						}
						break;
					}
					if (Game.mGameState > eGameState.AllHold)
					{
						if (214017 - 222551 != -8533)
						{
							break;
						}
						continue;
					}
					else
					{
						this.$returnCode$45436 = RuntimeServices.UnboxInt32(this.$data$45441[141]);
						if (211716 - 13337 != 198379)
						{
							continue;
						}
						this.$returnValue$45437 = RuntimeServices.UnboxInt32(this.$data$45441[145]);
						if (118165 - 302996 != -184831)
						{
							continue;
						}
						this.$ownerID$45438 = RuntimeServices.UnboxInt32(this.$data$45441[43]);
						if (257097 - 46319 == 210779)
						{
							continue;
						}
						this.$$switch$8508$45439 = this.$returnCode$45436;
						if (168067 - 173823 != -5756)
						{
							continue;
						}
						if (this.$$switch$8508$45439 == 9721)
						{
							if (247416 - 24513 == 222904)
							{
								continue;
							}
						}
						else if (this.$$switch$8508$45439 == -9721)
						{
							if (48275 - 592215 == -543939)
							{
								continue;
							}
							if (this.$returnValue$45437 == 2)
							{
								if (79493 - 534897 == -455403)
								{
									continue;
								}
								if (this.$self_$45442.NQ6nGly8pNR < 2)
								{
									if (14658 - 533282 == -518623)
									{
										continue;
									}
									this.$self_$45442.NQ6nGly8pNR = 2;
									if (81810 - 206831 != -125021)
									{
										continue;
									}
									Game.mGameState = eGameState.AllHold;
									if (42805 - 70352 != -27547)
									{
										continue;
									}
									this.$mGameGui$45440 = (GameGui)this.$self_$45442.GetComponent(typeof(GameGui));
									if (81316 - 202249 != -120933)
									{
										continue;
									}
									this.$mGameGui$45440.close();
									if (198391 - 569523 == -371131)
									{
										continue;
									}
									Game.savePlayer();
									if (61840 - 465923 != -404083)
									{
										continue;
									}
									this.$self_$45442.SendMessage("fadeOut");
									if (218579 - 387247 != -168668)
									{
										continue;
									}
									goto IL_235;
								}
							}
						}
					}
					IL_1ED:
					this.YieldDefault(1);
					if (254943 - 179617 != 75326)
					{
						continue;
					}
					break;
					IL_1E8:
					goto IL_1ED;
				}
				goto IL_35C;
				IL_235:
				return this.Yield(2, new WaitForSeconds((float)1));
				IL_35C:
				return false;
			}

			// Token: 0x0600B08A RID: 45194 RVA: 0x0135A1F4 File Offset: 0x013583F4
			internal static bool efuRRGVsmJ9kYBPaBH0k()
			{
				return true;
			}

			// Token: 0x0600B08B RID: 45195 RVA: 0x0135A1F8 File Offset: 0x013583F8
			internal static bool aTgWbxVsFEoJJ7KLeeb9()
			{
				return false;
			}

			// Token: 0x04009AC8 RID: 39624
			internal int $returnCode$45436;

			// Token: 0x04009AC9 RID: 39625
			internal int $returnValue$45437;

			// Token: 0x04009ACA RID: 39626
			internal int $ownerID$45438;

			// Token: 0x04009ACB RID: 39627
			internal int $$switch$8508$45439;

			// Token: 0x04009ACC RID: 39628
			internal GameGui $mGameGui$45440;

			// Token: 0x04009ACD RID: 39629
			internal Hashtable $data$45441;

			// Token: 0x04009ACE RID: 39630
			internal M972_IceTower1 $self_$45442;
		}
	}

	// Token: 0x02001D7D RID: 7549
	[CompilerGenerated]
	[Serializable]
	internal sealed class $TalkToIcePenguin$45445 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600B08C RID: 45196 RVA: 0x0135A1FC File Offset: 0x013583FC
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $TalkToIcePenguin$45445(M972_IceTower1 self_)
		{
			if (193885 - 468053 != -274167)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (255699 - 548359 == -292660)
				{
					base..ctor();
					if (274251 - 380932 == -106681)
					{
						this.$self_$45450 = self_;
						if (245624 - 6580 == 239044)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x0600B08D RID: 45197 RVA: 0x0135A294 File Offset: 0x01358494
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M972_IceTower1.$TalkToIcePenguin$45445.$(this.$self_$45450);
		}

		// Token: 0x0600B08E RID: 45198 RVA: 0x0135A2A4 File Offset: 0x013584A4
		internal static bool Kw5rpcVsMsWMlW34RZWF()
		{
			return true;
		}

		// Token: 0x0600B08F RID: 45199 RVA: 0x0135A2A8 File Offset: 0x013584A8
		internal static bool wTJSKWVsxwh1oTLd60jC()
		{
			return false;
		}

		// Token: 0x04009ACF RID: 39631
		internal M972_IceTower1 $self_$45450;

		// Token: 0x02001D7E RID: 7550
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600B090 RID: 45200 RVA: 0x0135A2AC File Offset: 0x013584AC
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M972_IceTower1 self_)
			{
				if (164982 - 543629 != -378646)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (131390 - 436512 != -305121)
					{
						base..ctor();
						if (256390 - 216264 == 40126)
						{
							this.$self_$45449 = self_;
							if (226206 - 190483 != 35724)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x0600B091 RID: 45201 RVA: 0x0135A344 File Offset: 0x01358544
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (182237 - 591538 != -409301)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_488;
					case 2:
						if (Game.mGameState != eGameState.Hold)
						{
							if (163134 - 223021 != -59887)
							{
								continue;
							}
							goto IL_1E8;
						}
						else
						{
							this.$mStoryGui$45447.newStoryMessage("IcePenguin", "Penne", Language.getMessage("M972_IceTower", 111 + UnityEngine.Random.Range(0, 5)), eTalkType.friend);
							if (210753 - 340826 != -130072)
							{
								goto Block_16;
							}
							continue;
						}
						break;
					case 3:
						if (Game.mGameState != eGameState.Hold)
						{
							if (66260 - 130632 != -64372)
							{
								continue;
							}
							goto IL_2BB;
						}
						else
						{
							this.$mStoryGui$45447.close();
							if (121362 - 20166 != 101196)
							{
								continue;
							}
							this.$mGameGui$45446.enabled = true;
							if (278420 - 573269 != -294849)
							{
								continue;
							}
							goto IL_1AD;
						}
						break;
					case 4:
						if (Game.mGameState != eGameState.Hold)
						{
							if (144375 - 134627 != 9749)
							{
								goto Block_15;
							}
							continue;
						}
						else
						{
							Game.mGameState = eGameState.Normal;
							if (145845 - 368439 != -222593)
							{
								goto IL_18B;
							}
							continue;
						}
						break;
					default:
						if (262401 - 202568 != 59833)
						{
							continue;
						}
						break;
					}
					if (Game.mGameState != eGameState.Normal)
					{
						if (231646 - 170680 != 60966)
						{
							continue;
						}
						goto IL_FD;
					}
					else
					{
						this.$mGameGui$45446 = (GameGui)this.$self_$45449.GetComponent(typeof(GameGui));
						if (132349 - 548698 == -416348)
						{
							continue;
						}
						this.$mStoryGui$45447 = (StoryGui)this.$self_$45449.GetComponent(typeof(StoryGui));
						if (298765 - 33364 == 265402)
						{
							continue;
						}
						if (this.$mGameGui$45446)
						{
							if (296445 - 343773 == -47327)
							{
								continue;
							}
							if (this.$mStoryGui$45447)
							{
								if (269301 - 380082 == -110780)
								{
									continue;
								}
								Game.mGameState = eGameState.Hold;
								if (205517 - 87628 == 117890)
								{
									continue;
								}
								this.$mGameGui$45446.close();
								if (98635 - 590118 != -491483)
								{
									continue;
								}
								this.$mIcePenguin$45448 = GameObject.Find("IcePenguin");
								if (124936 - 241802 != -116866)
								{
									continue;
								}
								if (!Game.mPlayer)
								{
									goto IL_D9;
								}
								if (209474 - 143380 != 66094)
								{
									continue;
								}
								if (!this.$mIcePenguin$45448)
								{
									goto IL_D9;
								}
								if (77859 - 570585 == -492725)
								{
									continue;
								}
								this.$mIcePenguin$45448.transform.rotation = Quaternion.LookRotation(global::Math.vFlat(Game.mPlayer.transform.position - this.$mIcePenguin$45448.transform.position));
								if (234461 - 37451 != 197010)
								{
									continue;
								}
								Game.mPlayer.SendMessage("turnToPos", this.$mIcePenguin$45448.transform.position);
								if (275911 - 425017 == -149105)
								{
									continue;
								}
								IL_7A:
								this.$mStoryGui$45447.startStoryMessage("IcePenguin", "Penne", eTalkType.friend);
								if (47898 - 193997 != -146099)
								{
									continue;
								}
								break;
								IL_D9:
								Debug.LogError("Cannot find IcePenguin");
								if (196854 - 456480 != -259625)
								{
									goto IL_7A;
								}
								continue;
							}
						}
					}
					IL_18B:
					this.YieldDefault(1);
					if (194699 - 299070 != -104370)
					{
						goto Block_13;
					}
				}
				return this.Yield(2, new WaitForSeconds(0.5f));
				IL_FD:
				Block_13:
				goto IL_488;
				IL_1AD:
				return this.Yield(4, new WaitForSeconds(1f));
				Block_15:
				IL_1E8:
				goto IL_488;
				Block_16:
				return this.Yield(3, new WaitForSeconds(3f));
				IL_2BB:
				IL_488:
				return false;
			}

			// Token: 0x0600B092 RID: 45202 RVA: 0x0135A7EC File Offset: 0x013589EC
			internal static bool FbQkZKVsgomQ8g1GnnUo()
			{
				return true;
			}

			// Token: 0x0600B093 RID: 45203 RVA: 0x0135A7F0 File Offset: 0x013589F0
			internal static bool iVUD85Vsf7LG8KeS4a5u()
			{
				return false;
			}

			// Token: 0x04009AD0 RID: 39632
			internal GameGui $mGameGui$45446;

			// Token: 0x04009AD1 RID: 39633
			internal StoryGui $mStoryGui$45447;

			// Token: 0x04009AD2 RID: 39634
			internal GameObject $mIcePenguin$45448;

			// Token: 0x04009AD3 RID: 39635
			internal M972_IceTower1 $self_$45449;
		}
	}

	// Token: 0x02001D7F RID: 7551
	[CompilerGenerated]
	[Serializable]
	internal sealed class $StartGame$45451 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600B094 RID: 45204 RVA: 0x0135A7F4 File Offset: 0x013589F4
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $StartGame$45451(M972_IceTower1 self_)
		{
			if (145640 - 235905 != -90264)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (247895 - 342671 == -94776)
				{
					base..ctor();
					if (273156 - 277200 == -4044)
					{
						this.$self_$45456 = self_;
						if (110274 - 279593 != -169318)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x0600B095 RID: 45205 RVA: 0x0135A88C File Offset: 0x01358A8C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M972_IceTower1.$StartGame$45451.$(this.$self_$45456);
		}

		// Token: 0x0600B096 RID: 45206 RVA: 0x0135A89C File Offset: 0x01358A9C
		internal static bool zHYFmSVsn0V5IrlvGIpH()
		{
			return true;
		}

		// Token: 0x0600B097 RID: 45207 RVA: 0x0135A8A0 File Offset: 0x01358AA0
		internal static bool zFwwsIVs6aVlDEjGRWZI()
		{
			return false;
		}

		// Token: 0x04009AD4 RID: 39636
		internal M972_IceTower1 $self_$45456;

		// Token: 0x02001D80 RID: 7552
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600B098 RID: 45208 RVA: 0x0135A8A4 File Offset: 0x01358AA4
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M972_IceTower1 self_)
			{
				if (64326 - 578971 != -514645)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (186113 - 324915 != -138801)
					{
						base..ctor();
						if (185926 - 322564 != -136637)
						{
							this.$self_$45455 = self_;
							if (286371 - 95392 != 190980)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x0600B099 RID: 45209 RVA: 0x0135A93C File Offset: 0x01358B3C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (240500 - 595156 != -354655)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						goto IL_656;
					case 1:
						goto IL_67A;
					case 2:
						this.$mStoryGui$45452 = (StoryGui)this.$self_$45455.GetComponent(typeof(StoryGui));
						if (88404 - 8213 == 80192)
						{
							continue;
						}
						this.$mStoryTimer$45453 = 0f;
						if (281584 - 135749 == 145836)
						{
							continue;
						}
						if (!this.$mStoryGui$45452)
						{
							goto IL_3DD;
						}
						if (91924 - 580141 == -488216)
						{
							continue;
						}
						this.$mStoryGui$45452.startStoryMessage("IcePenguin", "Penne", eTalkType.friend);
						if (30947 - 517230 != -486283)
						{
							continue;
						}
						goto IL_176;
					case 3:
						if (Game.mGameState != eGameState.Start)
						{
							if (105619 - 12567 != 93053)
							{
								goto Block_11;
							}
							continue;
						}
						else
						{
							this.$mStoryGui$45452.newStoryMessage("IcePenguin", "Penne", Language.getMessage("M972_IceTower", 101), eTalkType.friend);
							if (175202 - 469663 != -294461)
							{
								continue;
							}
							this.$mStoryTimer$45453 = Time.time + 4f;
							if (29832 - 302303 != -272470)
							{
								goto Block_19;
							}
							continue;
						}
						break;
					case 4:
						break;
					case 5:
						break;
					case 6:
						goto IL_464;
					case 7:
						goto IL_464;
					case 8:
						goto IL_21F;
					case 9:
						goto IL_21F;
					case 10:
						goto IL_3DD;
					case 11:
						Game.mGameState = eGameState.Normal;
						if (244249 - 358640 != -114391)
						{
							continue;
						}
						Game.mGameTime = Time.time;
						if (278248 - 199932 == 78317)
						{
							continue;
						}
						this.YieldDefault(1);
						if (213260 - 514949 != -301689)
						{
							continue;
						}
						goto IL_67A;
					default:
						if (136953 - 247927 != -110974)
						{
							continue;
						}
						goto IL_656;
					}
					if (this.$mStoryTimer$45453 > Time.time)
					{
						if (130559 - 522568 == -392008)
						{
							continue;
						}
						if (!Input.GetKeyDown(KeyCode.Mouse0))
						{
							break;
						}
						if (223412 - 363117 != -139705)
						{
							continue;
						}
					}
					if (Game.mGameState != eGameState.Start)
					{
						if (207034 - 92446 != 114588)
						{
							continue;
						}
						goto IL_2CD;
					}
					else
					{
						this.$mStoryGui$45452.newStoryMessage("IcePenguin", "Penne", Language.getMessage("M972_IceTower", 102), eTalkType.friend);
						if (166339 - 242939 != -76600)
						{
							continue;
						}
						this.$mStoryTimer$45453 = Time.time + 4f;
						if (218194 - 443294 != -225100)
						{
							continue;
						}
						goto IL_43D;
					}
					IL_656:
					Debug.Log("Start Game");
					if (43781 - 449604 != -405823)
					{
						continue;
					}
					Game.mGameState = eGameState.Start;
					if (94954 - 350111 != -255157)
					{
						continue;
					}
					Game.mGameTime = Time.time;
					if (167335 - 543410 != -376075)
					{
						continue;
					}
					this.$self_$45455.SendMessage("fadeIn");
					if (225956 - 52759 != 173198)
					{
						goto Block_4;
					}
					continue;
					IL_21F:
					if (this.$mStoryTimer$45453 > Time.time)
					{
						if (173913 - 7342 != 166571)
						{
							continue;
						}
						if (!Input.GetKeyDown(KeyCode.Mouse0))
						{
							goto IL_212;
						}
						if (177591 - 141601 != 35990)
						{
							continue;
						}
					}
					if (Game.mGameState != eGameState.Start)
					{
						if (105900 - 354027 != -248126)
						{
							goto Block_23;
						}
						continue;
					}
					else
					{
						this.$mStoryGui$45452.close();
						if (247906 - 285487 != -37581)
						{
							continue;
						}
						goto IL_3C6;
					}
					IL_3DD:
					this.$mGameGui$45454 = (GameGui)this.$self_$45455.GetComponent(typeof(GameGui));
					if (247811 - 220992 != 26819)
					{
						continue;
					}
					this.$mGameGui$45454.enabled = true;
					if (39066 - 177882 == -138815)
					{
						continue;
					}
					this.$self_$45455.nB0nGOVVfYp.enabled = true;
					if (69792 - 398563 != -328770)
					{
						goto Block_42;
					}
					continue;
					IL_464:
					if (this.$mStoryTimer$45453 > Time.time)
					{
						if (262385 - 559946 != -297561)
						{
							continue;
						}
						if (!Input.GetKeyDown(KeyCode.Mouse0))
						{
							goto IL_458;
						}
						if (294360 - 44280 == 250081)
						{
							continue;
						}
					}
					if (Game.mGameState != eGameState.Start)
					{
						if (102114 - 496587 == -394473)
						{
							goto IL_48E;
						}
					}
					else
					{
						this.$mStoryGui$45452.newStoryMessage("IcePenguin", "Penne", Language.getMessage("M972_IceTower", 103), eTalkType.friend);
						if (105669 - 52167 == 53502)
						{
							this.$mStoryTimer$45453 = Time.time + 4f;
							if (253462 - 518370 == -264908)
							{
								goto IL_1F7;
							}
						}
					}
				}
				return this.YieldDefault(5);
				Block_4:
				return this.Yield(2, new WaitForSeconds(1f));
				IL_176:
				return this.Yield(3, new WaitForSeconds(0.5f));
				Block_11:
				goto IL_67A;
				IL_1F7:
				return this.Yield(8, new WaitForSeconds(0.5f));
				IL_212:
				return this.YieldDefault(9);
				Block_19:
				return this.Yield(4, new WaitForSeconds(0.5f));
				IL_2CD:
				Block_23:
				goto IL_67A;
				IL_3C6:
				return this.Yield(10, new WaitForSeconds(0.5f));
				IL_43D:
				return this.Yield(6, new WaitForSeconds(0.5f));
				IL_458:
				return this.YieldDefault(7);
				IL_48E:
				goto IL_67A;
				Block_42:
				return this.Yield(11, new WaitForSeconds(0.5f));
				IL_67A:
				return false;
			}

			// Token: 0x0600B09A RID: 45210 RVA: 0x0135AFD8 File Offset: 0x013591D8
			internal static bool qaGVutVsiOxZuG0Nijer()
			{
				return true;
			}

			// Token: 0x0600B09B RID: 45211 RVA: 0x0135AFDC File Offset: 0x013591DC
			internal static bool cLVKpGVsKP0LlGmOFUS9()
			{
				return false;
			}

			// Token: 0x04009AD5 RID: 39637
			internal StoryGui $mStoryGui$45452;

			// Token: 0x04009AD6 RID: 39638
			internal float $mStoryTimer$45453;

			// Token: 0x04009AD7 RID: 39639
			internal GameGui $mGameGui$45454;

			// Token: 0x04009AD8 RID: 39640
			internal M972_IceTower1 $self_$45455;
		}
	}

	// Token: 0x02001D81 RID: 7553
	[CompilerGenerated]
	[Serializable]
	internal sealed class $onDeadPlayer$45457 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600B09C RID: 45212 RVA: 0x0135AFE0 File Offset: 0x013591E0
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $onDeadPlayer$45457(M972_IceTower1 self_)
		{
			if (207941 - 167638 != 40304)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (214084 - 324689 != -110604)
				{
					base..ctor();
					if (95423 - 370050 == -274627)
					{
						this.$self_$45462 = self_;
						if (131206 - 194357 != -63150)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x0600B09D RID: 45213 RVA: 0x0135B078 File Offset: 0x01359278
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M972_IceTower1.$onDeadPlayer$45457.$(this.$self_$45462);
		}

		// Token: 0x0600B09E RID: 45214 RVA: 0x0135B088 File Offset: 0x01359288
		internal static bool CA1MAtVsdFwc6ogcpYOE()
		{
			return true;
		}

		// Token: 0x0600B09F RID: 45215 RVA: 0x0135B08C File Offset: 0x0135928C
		internal static bool Pk8O0EVsJsldZE9PNfWi()
		{
			return false;
		}

		// Token: 0x04009AD9 RID: 39641
		internal M972_IceTower1 $self_$45462;

		// Token: 0x02001D82 RID: 7554
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600B0A0 RID: 45216 RVA: 0x0135B090 File Offset: 0x01359290
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M972_IceTower1 self_)
			{
				if (297938 - 313322 != -15384)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (298274 - 561879 != -263604)
					{
						base..ctor();
						if (47316 - 559190 != -511873)
						{
							this.$self_$45461 = self_;
							if (141447 - 195119 == -53672)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x0600B0A1 RID: 45217 RVA: 0x0135B128 File Offset: 0x01359328
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (75293 - 199790 != -124497)
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
							if (107560 - 576680 != -469120)
							{
								continue;
							}
							if (Game.mGameState != eGameState.Hold)
							{
								goto IL_2B1;
							}
							if (43916 - 134581 != -90665)
							{
								continue;
							}
						}
						Game.mGameState = eGameState.Hold;
						if (201645 - 159927 != 41718)
						{
							continue;
						}
						this.$mStoryGui$45458 = (StoryGui)this.$self_$45461.GetComponent(typeof(StoryGui));
						if (259043 - 526466 == -267422)
						{
							continue;
						}
						if (this.$mStoryGui$45458)
						{
							if (171908 - 93803 == 78106)
							{
								continue;
							}
							this.$mStoryGui$45458.close();
							if (139949 - 249368 != -109419)
							{
								continue;
							}
						}
						this.$mChangeGui$45459 = (ChangeGui)this.$self_$45461.GetComponent(typeof(ChangeGui));
						if (57288 - 83239 == -25950)
						{
							continue;
						}
						if (this.$mChangeGui$45459)
						{
							if (25607 - 121531 == -95923)
							{
								continue;
							}
							this.$mChangeGui$45459.close();
							if (8956 - 457843 == -448886)
							{
								continue;
							}
						}
						this.$mGameGui$45460 = (GameGui)this.$self_$45461.GetComponent(typeof(GameGui));
						if (228585 - 540062 == -311476)
						{
							continue;
						}
						if (this.$mGameGui$45460)
						{
							if (169298 - 95554 != 73744)
							{
								continue;
							}
							if (!this.$mGameGui$45460.enabled)
							{
								if (171453 - 441134 != -269681)
								{
									continue;
								}
								this.$mGameGui$45460.enabled = true;
								if (161793 - 257793 != -96000)
								{
									continue;
								}
							}
							this.$mGameGui$45460.openDeadMenu();
							if (36933 - 55599 == -18665)
							{
								continue;
							}
						}
						IL_2B1:
						this.YieldDefault(1);
						if (242454 - 566261 != -323807)
						{
							continue;
						}
						goto IL_2F9;
					default:
						if (187518 - 525894 == -338375)
						{
							continue;
						}
						break;
					}
					Debug.Log("On Dead Player");
				}
				while (295358 - 290965 == 4394);
				return this.Yield(2, new WaitForSeconds((float)2));
				IL_2F9:
				return false;
			}

			// Token: 0x0600B0A2 RID: 45218 RVA: 0x0135B440 File Offset: 0x01359640
			internal static bool ISl7mSVsDsk2VSyYFHNd()
			{
				return true;
			}

			// Token: 0x0600B0A3 RID: 45219 RVA: 0x0135B444 File Offset: 0x01359644
			internal static bool dqsLrJVsviIcpiKQ02o3()
			{
				return false;
			}

			// Token: 0x04009ADA RID: 39642
			internal StoryGui $mStoryGui$45458;

			// Token: 0x04009ADB RID: 39643
			internal ChangeGui $mChangeGui$45459;

			// Token: 0x04009ADC RID: 39644
			internal GameGui $mGameGui$45460;

			// Token: 0x04009ADD RID: 39645
			internal M972_IceTower1 $self_$45461;
		}
	}

	// Token: 0x02001D83 RID: 7555
	[CompilerGenerated]
	[Serializable]
	internal sealed class $onChangePlayer$45463 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600B0A4 RID: 45220 RVA: 0x0135B448 File Offset: 0x01359648
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $onChangePlayer$45463(Hashtable data, M972_IceTower1 self_)
		{
			if (281212 - 375858 != -94646)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (75295 - 38010 != 37286)
				{
					base..ctor();
					if (233745 - 308659 != -74913)
					{
						this.$data$45468 = data;
						if (92068 - 144901 != -52832)
						{
							this.$self_$45469 = self_;
							if (100820 - 371066 != -270245)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x0600B0A5 RID: 45221 RVA: 0x0135B504 File Offset: 0x01359704
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M972_IceTower1.$onChangePlayer$45463.$(this.$data$45468, this.$self_$45469);
		}

		// Token: 0x0600B0A6 RID: 45222 RVA: 0x0135B518 File Offset: 0x01359718
		internal static bool yBlsxeVsR89ndX5RjeJI()
		{
			return true;
		}

		// Token: 0x0600B0A7 RID: 45223 RVA: 0x0135B51C File Offset: 0x0135971C
		internal static bool UyUXj9Vswe9L9CjFbuIa()
		{
			return false;
		}

		// Token: 0x04009ADE RID: 39646
		internal Hashtable $data$45468;

		// Token: 0x04009ADF RID: 39647
		internal M972_IceTower1 $self_$45469;

		// Token: 0x02001D84 RID: 7556
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600B0A8 RID: 45224 RVA: 0x0135B520 File Offset: 0x01359720
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Hashtable data, M972_IceTower1 self_)
			{
				if (104696 - 139929 != -35232)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (179015 - 286579 == -107564)
					{
						base..ctor();
						if (10120 - 305307 == -295187)
						{
							this.$data$45466 = data;
							if (3701 - 70185 == -66484)
							{
								this.$self_$45467 = self_;
								if (292298 - 447800 == -155502)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x0600B0A9 RID: 45225 RVA: 0x0135B5DC File Offset: 0x013597DC
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (112719 - 361065 != -248345)
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
							if (1441 - 111060 != -109619)
							{
								continue;
							}
							Game.mGameState = eGameState.Normal;
							if (30568 - 478939 == -448370)
							{
								continue;
							}
							this.$mGameGui$45465 = (GameGui)this.$self_$45467.GetComponent(typeof(GameGui));
							if (84741 - 593533 != -508792)
							{
								continue;
							}
							this.$mGameGui$45465.enabled = true;
							if (97089 - 361667 != -264578)
							{
								continue;
							}
						}
						this.YieldDefault(1);
						if (30713 - 312470 != -281757)
						{
							continue;
						}
						goto IL_205;
					default:
						if (122645 - 319488 != -196843)
						{
							continue;
						}
						break;
					}
					UnityEngine.Object.Destroy(Game.mPlayer);
					if (143602 - 191126 != -47523)
					{
						this.$self_$45467.SendMessage("onCreatePlayer", this.$data$45466);
						if (18932 - 133732 != -114799)
						{
							this.$mChangeGui$45464 = (ChangeGui)this.$self_$45467.GetComponent(typeof(ChangeGui));
							if (225465 - 559737 != -334271)
							{
								if (!this.$mChangeGui$45464.enabled)
								{
									break;
								}
								if (167444 - 227684 == -60240)
								{
									this.$mChangeGui$45464.close();
									if (16133 - 351433 != -335299)
									{
										break;
									}
								}
							}
						}
					}
				}
				IL_1A:
				return this.Yield(2, new WaitForSeconds(1f));
				goto IL_1A;
				IL_205:
				return false;
			}

			// Token: 0x0600B0AA RID: 45226 RVA: 0x0135B800 File Offset: 0x01359A00
			internal static bool Xg9ZnGVsqa0spkld3UdY()
			{
				return true;
			}

			// Token: 0x0600B0AB RID: 45227 RVA: 0x0135B804 File Offset: 0x01359A04
			internal static bool WHrxWeVs7gAL7dlp93VW()
			{
				return false;
			}

			// Token: 0x04009AE0 RID: 39648
			internal ChangeGui $mChangeGui$45464;

			// Token: 0x04009AE1 RID: 39649
			internal GameGui $mGameGui$45465;

			// Token: 0x04009AE2 RID: 39650
			internal Hashtable $data$45466;

			// Token: 0x04009AE3 RID: 39651
			internal M972_IceTower1 $self_$45467;
		}
	}

	// Token: 0x02001D85 RID: 7557
	[CompilerGenerated]
	[Serializable]
	internal sealed class $onGameComplete$45470 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600B0AC RID: 45228 RVA: 0x0135B808 File Offset: 0x01359A08
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $onGameComplete$45470(Hashtable data, M972_IceTower1 self_)
		{
			if (286367 - 320527 != -34160)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (175634 - 333315 == -157681)
				{
					base..ctor();
					if (265258 - 320434 != -55175)
					{
						this.$data$45478 = data;
						if (55937 - 56712 == -775)
						{
							this.$self_$45479 = self_;
							if (230014 - 125147 != 104868)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x0600B0AD RID: 45229 RVA: 0x0135B8C4 File Offset: 0x01359AC4
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M972_IceTower1.$onGameComplete$45470.$(this.$data$45478, this.$self_$45479);
		}

		// Token: 0x0600B0AE RID: 45230 RVA: 0x0135B8D8 File Offset: 0x01359AD8
		internal static bool t0rZTvVsPbkrMSIZ0Vxk()
		{
			return true;
		}

		// Token: 0x0600B0AF RID: 45231 RVA: 0x0135B8DC File Offset: 0x01359ADC
		internal static bool GWsfVGVs0n3nEVmbjJew()
		{
			return false;
		}

		// Token: 0x04009AE4 RID: 39652
		internal Hashtable $data$45478;

		// Token: 0x04009AE5 RID: 39653
		internal M972_IceTower1 $self_$45479;

		// Token: 0x02001D86 RID: 7558
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600B0B0 RID: 45232 RVA: 0x0135B8E0 File Offset: 0x01359AE0
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Hashtable data, M972_IceTower1 self_)
			{
				if (89282 - 266728 != -177445)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (81568 - 319782 == -238214)
					{
						base..ctor();
						if (34609 - 336203 == -301594)
						{
							this.$data$45476 = data;
							if (252891 - 323324 == -70433)
							{
								this.$self_$45477 = self_;
								if (215033 - 15215 == 199818)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x0600B0B1 RID: 45233 RVA: 0x0135B99C File Offset: 0x01359B9C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (46154 - 531478 != -485324)
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
						this.$mCompleteGui$45472 = (CompleteGui)this.$self_$45477.GetComponent(typeof(CompleteGui));
						if (10622 - 21990 != -11368)
						{
							continue;
						}
						this.$mCompleteGui$45472.Init();
						if (92018 - 456423 == -364404)
						{
							continue;
						}
						this.$mCompleteGui$45472.readData(this.$data$45476);
						if (149883 - 67294 != 82589)
						{
							continue;
						}
						if (this.$result$45471 == 1)
						{
							if (17746 - 159635 == -141888)
							{
								continue;
							}
							this.$mCompleteGui$45472.displayResult(eCompleteType.Success);
							if (148599 - 204241 != -55642)
							{
								continue;
							}
						}
						else
						{
							this.$mCompleteGui$45472.displayResult(eCompleteType.Failed);
							if (51144 - 85399 != -34255)
							{
								continue;
							}
						}
						this.$mGameGui$45473 = (GameGui)this.$self_$45477.GetComponent(typeof(GameGui));
						if (90960 - 156694 == -65733)
						{
							continue;
						}
						this.$mStoryGui$45474 = (StoryGui)this.$self_$45477.GetComponent(typeof(StoryGui));
						if (236480 - 263631 == -27150)
						{
							continue;
						}
						this.$mChangeGui$45475 = (ChangeGui)this.$self_$45477.GetComponent(typeof(ChangeGui));
						if (256657 - 179224 != 77433)
						{
							continue;
						}
						if (this.$mGameGui$45473)
						{
							if (164694 - 178023 != -13329)
							{
								continue;
							}
							this.$mGameGui$45473.close();
							if (151340 - 216669 != -65329)
							{
								continue;
							}
						}
						if (this.$mStoryGui$45474)
						{
							if (29473 - 448781 != -419308)
							{
								continue;
							}
							this.$mStoryGui$45474.close();
							if (57673 - 65780 == -8106)
							{
								continue;
							}
						}
						if (this.$mChangeGui$45475)
						{
							if (78786 - 462384 == -383597)
							{
								continue;
							}
							this.$mChangeGui$45475.disable();
							if (152253 - 63875 == 88379)
							{
								continue;
							}
						}
						this.YieldDefault(1);
						if (191349 - 152853 != 38496)
						{
							continue;
						}
						goto IL_3DB;
					default:
						if (31696 - 94749 != -63053)
						{
							continue;
						}
						break;
					}
					Debug.Log("On Mission Complete:" + this.$data$45476[31]);
					if (160049 - 570628 == -410579)
					{
						if (Game.mGameState > eGameState.AllHold)
						{
							if (253622 - 474946 == -221324)
							{
								break;
							}
						}
						else
						{
							Game.mGameState = eGameState.Complete;
							if (223480 - 3354 == 220126)
							{
								this.$result$45471 = RuntimeServices.UnboxInt32(this.$data$45476[31]);
								if (160185 - 354702 == -194517)
								{
									goto IL_2A4;
								}
							}
						}
					}
				}
				goto IL_3DB;
				IL_2A4:
				return this.Yield(2, new WaitForSeconds(1f));
				IL_3DB:
				return false;
			}

			// Token: 0x0600B0B2 RID: 45234 RVA: 0x0135BD98 File Offset: 0x01359F98
			internal static bool BpQ9AYVsbnhhcnnK83HA()
			{
				return true;
			}

			// Token: 0x0600B0B3 RID: 45235 RVA: 0x0135BD9C File Offset: 0x01359F9C
			internal static bool sHZZ2IVsu972iqJO5yaB()
			{
				return false;
			}

			// Token: 0x04009AE6 RID: 39654
			internal int $result$45471;

			// Token: 0x04009AE7 RID: 39655
			internal CompleteGui $mCompleteGui$45472;

			// Token: 0x04009AE8 RID: 39656
			internal GameGui $mGameGui$45473;

			// Token: 0x04009AE9 RID: 39657
			internal StoryGui $mStoryGui$45474;

			// Token: 0x04009AEA RID: 39658
			internal ChangeGui $mChangeGui$45475;

			// Token: 0x04009AEB RID: 39659
			internal Hashtable $data$45476;

			// Token: 0x04009AEC RID: 39660
			internal M972_IceTower1 $self_$45477;
		}
	}

	// Token: 0x02001D87 RID: 7559
	[CompilerGenerated]
	[Serializable]
	internal sealed class $ReturnToTown$45480 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600B0B4 RID: 45236 RVA: 0x0135BDA0 File Offset: 0x01359FA0
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $ReturnToTown$45480(M972_IceTower1 self_)
		{
			if (16130 - 576216 != -560086)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (154877 - 349634 == -194757)
				{
					base..ctor();
					if (81677 - 326211 == -244534)
					{
						this.$self_$45484 = self_;
						if (4403 - 491677 != -487273)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x0600B0B5 RID: 45237 RVA: 0x0135BE38 File Offset: 0x0135A038
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M972_IceTower1.$ReturnToTown$45480.$(this.$self_$45484);
		}

		// Token: 0x0600B0B6 RID: 45238 RVA: 0x0135BE48 File Offset: 0x0135A048
		internal static bool vFs9qZVsIdYNBMOFZX4K()
		{
			return true;
		}

		// Token: 0x0600B0B7 RID: 45239 RVA: 0x0135BE4C File Offset: 0x0135A04C
		internal static bool x1PUfdVsBuYFVxs7VN4N()
		{
			return false;
		}

		// Token: 0x04009AED RID: 39661
		internal M972_IceTower1 $self_$45484;

		// Token: 0x02001D88 RID: 7560
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600B0B8 RID: 45240 RVA: 0x0135BE50 File Offset: 0x0135A050
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M972_IceTower1 self_)
			{
				if (47370 - 69224 != -21853)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (16955 - 160765 != -143809)
					{
						base..ctor();
						if (66693 - 320788 != -254094)
						{
							this.$self_$45483 = self_;
							if (129167 - 68033 != 61135)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x0600B0B9 RID: 45241 RVA: 0x0135BEE8 File Offset: 0x0135A0E8
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (216216 - 9717 != 206500)
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
						this.$self_$45483.LeaveGame();
						if (264753 - 466696 != -201943)
						{
							continue;
						}
						this.YieldDefault(1);
						if (9789 - 326852 != -317063)
						{
							continue;
						}
						goto IL_3AD;
					default:
						if (91547 - 597609 != -506062)
						{
							continue;
						}
						break;
					}
					Game.mGameState = eGameState.Ended;
					if (148589 - 463055 == -314466)
					{
						Game.mStateTime = Time.time;
						if (132080 - 192018 == -59938)
						{
							this.$$switch$8512$45481 = PlayerData.SaveGuild;
							if (174750 - 172107 != 2644)
							{
								if (this.$$switch$8512$45481 == 1)
								{
									if (46882 - 170219 == -123336)
									{
										continue;
									}
									Game.mNextGameCode = 32;
									if (56755 - 48869 == 7887)
									{
										continue;
									}
								}
								else if (this.$$switch$8512$45481 == 2)
								{
									if (9979 - 176297 == -166317)
									{
										continue;
									}
									Game.mNextGameCode = 33;
									if (69538 - 43833 != 25705)
									{
										continue;
									}
								}
								else if (this.$$switch$8512$45481 == 3)
								{
									if (161710 - 12217 != 149493)
									{
										continue;
									}
									Game.mNextGameCode = 34;
									if (120545 - 70494 != 50051)
									{
										continue;
									}
								}
								else if (this.$$switch$8512$45481 == 4)
								{
									if (19049 - 361512 != -342463)
									{
										continue;
									}
									Game.mNextGameCode = 35;
									if (223394 - 387887 == -164492)
									{
										continue;
									}
								}
								else if (this.$$switch$8512$45481 == 5)
								{
									if (69668 - 332521 != -262853)
									{
										continue;
									}
									Game.mNextGameCode = 36;
									if (163011 - 99788 != 63223)
									{
										continue;
									}
								}
								else if (PlayerData.GID == 0)
								{
									if (265605 - 438713 != -173108)
									{
										continue;
									}
									Game.mNextGameCode = 30;
									if (130096 - 448950 == -318853)
									{
										continue;
									}
								}
								else
								{
									Game.mNextGameCode = 31;
									if (162391 - 461934 == -299542)
									{
										continue;
									}
								}
								this.$mGameGui$45482 = (GameGui)this.$self_$45483.GetComponent(typeof(GameGui));
								if (208676 - 411954 != -203277)
								{
									if (this.$mGameGui$45482)
									{
										if (76344 - 294884 != -218540)
										{
											continue;
										}
										this.$mGameGui$45482.close();
										if (48807 - 160206 != -111399)
										{
											continue;
										}
									}
									this.$self_$45483.SendMessage("fadeOut");
									if (26395 - 35782 == -9387)
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

			// Token: 0x0600B0BA RID: 45242 RVA: 0x0135C2B4 File Offset: 0x0135A4B4
			internal static bool l0ivSvVsee4feSuTRWO1()
			{
				return true;
			}

			// Token: 0x0600B0BB RID: 45243 RVA: 0x0135C2B8 File Offset: 0x0135A4B8
			internal static bool GDcJSSVsrKnbswXAuWd2()
			{
				return false;
			}

			// Token: 0x04009AEE RID: 39662
			internal int $$switch$8512$45481;

			// Token: 0x04009AEF RID: 39663
			internal GameGui $mGameGui$45482;

			// Token: 0x04009AF0 RID: 39664
			internal M972_IceTower1 $self_$45483;
		}
	}

	// Token: 0x02001D89 RID: 7561
	[CompilerGenerated]
	[Serializable]
	internal sealed class $ReturnToGuild$45485 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600B0BC RID: 45244 RVA: 0x0135C2BC File Offset: 0x0135A4BC
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $ReturnToGuild$45485(M972_IceTower1 self_)
		{
			if (222818 - 276234 != -53415)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (142201 - 518238 == -376037)
				{
					base..ctor();
					if (100582 - 561376 != -460793)
					{
						this.$self_$45488 = self_;
						if (149563 - 335418 == -185855)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x0600B0BD RID: 45245 RVA: 0x0135C354 File Offset: 0x0135A554
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M972_IceTower1.$ReturnToGuild$45485.$(this.$self_$45488);
		}

		// Token: 0x0600B0BE RID: 45246 RVA: 0x0135C364 File Offset: 0x0135A564
		internal static bool E9RfgWVsjcwcqDTAenKT()
		{
			return true;
		}

		// Token: 0x0600B0BF RID: 45247 RVA: 0x0135C368 File Offset: 0x0135A568
		internal static bool UaJE8YVshfd27dYZdFdN()
		{
			return false;
		}

		// Token: 0x04009AF1 RID: 39665
		internal M972_IceTower1 $self_$45488;

		// Token: 0x02001D8A RID: 7562
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600B0C0 RID: 45248 RVA: 0x0135C36C File Offset: 0x0135A56C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M972_IceTower1 self_)
			{
				if (15424 - 406733 != -391309)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (228876 - 307073 == -78197)
					{
						base..ctor();
						if (170066 - 87857 != 82210)
						{
							this.$self_$45487 = self_;
							if (241492 - 382570 == -141078)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x0600B0C1 RID: 45249 RVA: 0x0135C404 File Offset: 0x0135A604
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (135777 - 507979 != -372201)
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
						this.$self_$45487.LeaveGame();
						if (121968 - 383848 != -261880)
						{
							continue;
						}
						this.YieldDefault(1);
						if (64539 - 593146 != -528606)
						{
							goto IL_1BD;
						}
						continue;
					default:
						if (158532 - 43463 != 115069)
						{
							continue;
						}
						break;
					}
					Game.mGameState = eGameState.Ended;
					if (168657 - 131193 != 37465)
					{
						Game.mStateTime = Time.time;
						if (232221 - 54034 != 178188)
						{
							Game.mNextGameCode = 31;
							if (5799 - 333692 == -327893)
							{
								this.$mGameGui$45486 = (GameGui)this.$self_$45487.GetComponent(typeof(GameGui));
								if (122780 - 587037 == -464257)
								{
									if (this.$mGameGui$45486)
									{
										if (94053 - 53805 == 40249)
										{
											continue;
										}
										this.$mGameGui$45486.close();
										if (250881 - 349833 == -98951)
										{
											continue;
										}
									}
									this.$self_$45487.SendMessage("fadeOut");
									if (16958 - 281248 != -264289)
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

			// Token: 0x0600B0C2 RID: 45250 RVA: 0x0135C5E0 File Offset: 0x0135A7E0
			internal static bool Q76fuFVssyNo3iv4chGx()
			{
				return true;
			}

			// Token: 0x0600B0C3 RID: 45251 RVA: 0x0135C5E4 File Offset: 0x0135A7E4
			internal static bool hC8kijVs9EnviPTd7U10()
			{
				return false;
			}

			// Token: 0x04009AF2 RID: 39666
			internal GameGui $mGameGui$45486;

			// Token: 0x04009AF3 RID: 39667
			internal M972_IceTower1 $self_$45487;
		}
	}

	// Token: 0x02001D8B RID: 7563
	[CompilerGenerated]
	[Serializable]
	internal sealed class $ReturnToCamp$45489 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600B0C4 RID: 45252 RVA: 0x0135C5E8 File Offset: 0x0135A7E8
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $ReturnToCamp$45489(M972_IceTower1 self_)
		{
			if (60910 - 120075 != -59165)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (217697 - 214325 != 3373)
				{
					base..ctor();
					if (42047 - 447159 == -405112)
					{
						this.$self_$45492 = self_;
						if (188579 - 322130 != -133550)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x0600B0C5 RID: 45253 RVA: 0x0135C680 File Offset: 0x0135A880
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M972_IceTower1.$ReturnToCamp$45489.$(this.$self_$45492);
		}

		// Token: 0x0600B0C6 RID: 45254 RVA: 0x0135C690 File Offset: 0x0135A890
		internal static bool n0FURDVs1kCjnv4MPNmT()
		{
			return true;
		}

		// Token: 0x0600B0C7 RID: 45255 RVA: 0x0135C694 File Offset: 0x0135A894
		internal static bool tXwufcVs4YYuu0OkOKqP()
		{
			return false;
		}

		// Token: 0x04009AF4 RID: 39668
		internal M972_IceTower1 $self_$45492;

		// Token: 0x02001D8C RID: 7564
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600B0C8 RID: 45256 RVA: 0x0135C698 File Offset: 0x0135A898
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M972_IceTower1 self_)
			{
				if (78486 - 529062 != -450575)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (278892 - 231320 != 47573)
					{
						base..ctor();
						if (177596 - 369266 != -191669)
						{
							this.$self_$45491 = self_;
							if (279680 - 64043 != 215638)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x0600B0C9 RID: 45257 RVA: 0x0135C730 File Offset: 0x0135A930
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (92586 - 533330 != -440743)
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
						this.$self_$45491.LeaveGame();
						if (201159 - 175775 != 25384)
						{
							continue;
						}
						this.YieldDefault(1);
						if (28451 - 569580 != -541128)
						{
							goto Block_5;
						}
						continue;
					default:
						if (177432 - 503416 == -325983)
						{
							continue;
						}
						break;
					}
					Game.mGameState = eGameState.Ended;
					if (154566 - 191069 != -36502)
					{
						Game.mStateTime = Time.time;
						if (68239 - 349441 == -281202)
						{
							Game.mNextGameCode = 32;
							if (243935 - 117363 == 126572)
							{
								this.$mGameGui$45490 = (GameGui)this.$self_$45491.GetComponent(typeof(GameGui));
								if (200931 - 149437 != 51495)
								{
									if (this.$mGameGui$45490)
									{
										if (194910 - 443768 != -248858)
										{
											continue;
										}
										this.$mGameGui$45490.close();
										if (99193 - 237759 != -138566)
										{
											continue;
										}
									}
									this.$self_$45491.SendMessage("fadeOut");
									if (136315 - 22603 != 113713)
									{
										goto Block_7;
									}
								}
							}
						}
					}
				}
				Block_5:
				goto IL_1BD;
				Block_7:
				return this.Yield(2, new WaitForSeconds((float)1));
				IL_1BD:
				return false;
			}

			// Token: 0x0600B0CA RID: 45258 RVA: 0x0135C90C File Offset: 0x0135AB0C
			internal static bool JKid4WVszm9yjTFqLeY2()
			{
				return true;
			}

			// Token: 0x0600B0CB RID: 45259 RVA: 0x0135C910 File Offset: 0x0135AB10
			internal static bool mL4WGvV9aJpUM29RE9XW()
			{
				return false;
			}

			// Token: 0x04009AF5 RID: 39669
			internal GameGui $mGameGui$45490;

			// Token: 0x04009AF6 RID: 39670
			internal M972_IceTower1 $self_$45491;
		}
	}
}
