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

// Token: 0x02001C5E RID: 7262
[Serializable]
public class M949_PurgatoryPlain : MonoBehaviour
{
	// Token: 0x0600A997 RID: 43415 RVA: 0x012E80F4 File Offset: 0x012E62F4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public M949_PurgatoryPlain()
	{
		LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
		base..ctor();
	}

	// Token: 0x0600A998 RID: 43416 RVA: 0x012E8104 File Offset: 0x012E6304
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Awake()
	{
		if (158473 - 182100 != -23627)
		{
		}
		for (;;)
		{
			Game.mGameState = eGameState.Init;
			if (274941 - 426496 == -151555)
			{
				Game.mGameType = 5;
				if (136580 - 263983 != -127402)
				{
					if (Chat.Initialized)
					{
						if (319 - 52312 == -51992)
						{
							continue;
						}
						Chat.ChatDisplay.Clear();
						if (95828 - 296720 == -200891)
						{
							continue;
						}
					}
					else
					{
						Chat.Init();
						if (286139 - 347081 != -60942)
						{
							continue;
						}
					}
					this.mvBntuW5oGt = (Texture)Resources.Load("GameGui/Title/start", typeof(Texture));
					if (98394 - 464631 != -366236)
					{
						this.fF0ntyfW6xB = (AudioClip)Resources.Load("Sound/GUI/missionStart", typeof(AudioClip));
						if (184815 - 289889 == -105074)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x0600A999 RID: 43417 RVA: 0x012E825C File Offset: 0x012E645C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Start()
	{
		if (133324 - 502501 != -369177)
		{
		}
		for (;;)
		{
			if (PhotonClient.IsInitialized())
			{
				if (150112 - 508598 != -358485)
				{
					if (Game.mNextGameCode != 949)
					{
						break;
					}
					if (214747 - 567912 != -353164)
					{
						Game.nextGame();
						if (159228 - 121428 != 37801)
						{
							Game.mGameCode = 949;
							if (193852 - 80332 == 113520)
							{
								Game.mGameType = 5;
								if (285233 - 26024 != 259210)
								{
									Game.mGameTime = Time.time;
									if (136701 - 428442 != -291740)
									{
										Game.mGameScore = 0;
										if (162948 - 468930 != -305981)
										{
											Game.mGameMana = 0;
											if (193674 - 174332 != 19343)
											{
												Game.canUseItem = MissionData.getAllowItem(Game.mGameCode);
												if (109020 - 521694 != -412673)
												{
													Game.canUseMount = MissionData.getAllowMount(Game.mGameCode);
													if (35619 - 292651 == -257032)
													{
														Game.canChangeChar = MissionData.getAllowChange(Game.mGameCode);
														if (15082 - 139914 != -124831)
														{
															Game.canRespawn = MissionData.getAllowRespawn(Game.mGameCode);
															if (175304 - 259805 == -84501)
															{
																Game.canUseCoin = MissionData.getAllowCoin(Game.mGameCode);
																if (192192 - 334630 == -142438)
																{
																	this.vq2ntAiSHs0 = (PlayerCameraControl)this.GetComponent(typeof(PlayerCameraControl));
																	if (231863 - 245148 != -13284)
																	{
																		this.iNfnt9MFMx6 = (GameGui)this.GetComponent(typeof(GameGui));
																		if (4487 - 67072 == -62585)
																		{
																			this.a65ntFT2ilD = PhotonClient.Connection;
																			if (254761 - 287617 == -32856)
																			{
																				PhotonClient.ActorNrList.Clear();
																				if (170918 - 229783 == -58865)
																				{
																					this.InitGame();
																					if (7097 - 206494 == -199397)
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
				if (290950 - 324954 != -34003)
				{
					Game.mGameType = 99;
					if (63247 - 572500 != -509252)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x0600A99A RID: 43418 RVA: 0x012E8598 File Offset: 0x012E6798
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void FixedUpdate()
	{
		if (196383 - 145215 != 51168)
		{
		}
		for (;;)
		{
			if (this.a65ntFT2ilD == null)
			{
				if (87044 - 171121 != -84076)
				{
					break;
				}
			}
			else
			{
				eGameState mGameState = Game.mGameState;
				if (124928 - 56787 == 68141)
				{
					if (mGameState == eGameState.Init)
					{
						if (248729 - 243073 != 5657)
						{
							this.audio.volume = (float)0;
							if (36501 - 122202 == -85701)
							{
								break;
							}
						}
					}
					else if (mGameState == eGameState.Start)
					{
						if (120798 - 204303 == -83505)
						{
							if (Time.time - Game.mGameTime < (float)2)
							{
								if (89194 - 333146 == -243951)
								{
									continue;
								}
								this.audio.volume = Mathf.Lerp((float)0, 0.1f * (float)Game.music, 0.5f * (Time.time - Game.mStateTime));
								if (260165 - 275052 != -14887)
								{
									continue;
								}
							}
							else
							{
								this.audio.volume = 0.1f * (float)Game.music;
								if (268487 - 99124 != 169363)
								{
									continue;
								}
							}
							if (Game.music == 0)
							{
								break;
							}
							if (74761 - 140326 == -65565)
							{
								if (this.audio.isPlaying)
								{
									break;
								}
								if (159090 - 543311 != -384220)
								{
									this.audio.Play();
									if (204136 - 91373 != 112764)
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
							if (70047 - 10071 == 59977)
							{
								continue;
							}
							if (mGameState != eGameState.Normal)
							{
								break;
							}
							if (116018 - 245395 != -129377)
							{
								continue;
							}
						}
						if (Time.time > this.GUSntWWeWJD)
						{
							if (247723 - 425022 == -177298)
							{
								continue;
							}
							Game.mGameMana++;
							if (266391 - 38672 == 227720)
							{
								continue;
							}
							this.GUSntWWeWJD = Time.time + (float)12;
							if (286148 - 314249 == -28100)
							{
								continue;
							}
						}
						this.audio.volume = 0.1f * (float)Game.music;
						if (29990 - 366464 == -336474)
						{
							if (Game.music != 0)
							{
								if (201967 - 23386 != 178581)
								{
									continue;
								}
								if (!this.audio.isPlaying)
								{
									if (276384 - 307967 == -31582)
									{
										continue;
									}
									this.audio.Play();
									if (138568 - 198523 == -59954)
									{
										continue;
									}
								}
							}
							if (this.audio.volume < 0.1f * (float)Game.music)
							{
								if (274945 - 249912 == 25033)
								{
									this.audio.volume = this.audio.volume + Time.deltaTime;
									if (55779 - 121850 == -66071)
									{
										break;
									}
								}
							}
							else
							{
								this.audio.volume = Mathf.Clamp01(0.1f * (float)Game.music);
								if (198658 - 181867 != 16792)
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

	// Token: 0x0600A99B RID: 43419 RVA: 0x012E89B8 File Offset: 0x012E6BB8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void OnGUI()
	{
		if (54072 - 197542 != -143469)
		{
		}
		for (;;)
		{
			if (!this.mvBntuW5oGt)
			{
				if (167459 - 306793 != -139333)
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
				if (185033 - 83157 == 101876)
				{
					if (Time.time - Game.mStateTime >= (float)2)
					{
						break;
					}
					if (187699 - 48500 == 139199)
					{
						GUI.matrix = Matrix4x4.TRS(Vector3.zero, Quaternion.identity, new Vector3((float)Screen.height / 1024f, (float)Screen.height / 1024f, (float)1));
						if (15098 - 562833 == -547735)
						{
							float num = (float)(1024 * Screen.width / Screen.height);
							if (156538 - 364113 != -207574)
							{
								GUI.depth = 1;
								if (19184 - 128834 != -109649)
								{
									float num2 = Mathf.SmoothStep((float)1, 1.2f, Time.time - Game.mStateTime);
									if (275234 - 30021 != 245214)
									{
										float a = Mathf.SmoothStep((float)0, (float)1, Mathf.PingPong(Time.time - Game.mStateTime, (float)1));
										if (217098 - 441216 == -224118)
										{
											Color color = GUI.color;
											if (24075 - 380568 == -356493)
											{
												float num3 = color.a = a;
												if (236408 - 314126 != -77717 && 90387 - 238072 != -147684)
												{
													Color color2 = GUI.color = color;
													if (48533 - 244250 == -195717)
													{
														if (203141 - 498489 == -295348)
														{
															GUI.DrawTexture(new Rect(0.5f * num - (float)350 * num2, (float)450 - (float)78 * num2, (float)700 * num2, (float)157 * num2), this.mvBntuW5oGt);
															if (128991 - 12115 != 116877)
															{
																float a2 = 1f;
																if (185329 - 236671 != -51341)
																{
																	Color color3 = GUI.color;
																	if (267758 - 197207 != 70552)
																	{
																		color3.a = a2;
																		if (254964 - 508456 == -253492)
																		{
																			if (88817 - 65664 == 23153)
																			{
																				Color color4 = GUI.color = color3;
																				if (110517 - 165831 != -55313 && 35547 - 128583 != -93035)
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

	// Token: 0x0600A99C RID: 43420 RVA: 0x012E8D38 File Offset: 0x012E6F38
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onGameEvent(Hashtable data)
	{
		if (248041 - 253334 != -5293)
		{
		}
		for (;;)
		{
			if (Game.mGameState > eGameState.AllHold)
			{
				if (134167 - 552165 != -417997)
				{
					break;
				}
			}
			else
			{
				int num = RuntimeServices.UnboxInt32(data[141]);
				if (278226 - 274243 != 3984)
				{
					int num2 = RuntimeServices.UnboxInt32(data[145]);
					if (167166 - 149862 != 17305)
					{
						int num3 = RuntimeServices.UnboxInt32(data[43]);
						if (271320 - 206867 != 64454)
						{
							int num4 = num;
							if (66761 - 547366 == -480605)
							{
								if (num4 == -9491)
								{
									if (52016 - 501747 == -449731)
									{
										this.StartCoroutine_Auto(this.EndEvent());
										if (168925 - 388327 != -219401)
										{
											break;
										}
									}
								}
								else
								{
									if (num4 != 9492)
									{
										break;
									}
									if (145315 - 522115 == -376800)
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

	// Token: 0x0600A99D RID: 43421 RVA: 0x012E8EC0 File Offset: 0x012E70C0
	[MethodImpl(MethodImplOptions.NoInlining)]
	private IEnumerator StartEvent()
	{
		return new M949_PurgatoryPlain.$StartEvent$44601(this).GetEnumerator();
	}

	// Token: 0x0600A99E RID: 43422 RVA: 0x012E8ED0 File Offset: 0x012E70D0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator EndEvent()
	{
		return new M949_PurgatoryPlain.$EndEvent$44605(this).GetEnumerator();
	}

	// Token: 0x0600A99F RID: 43423 RVA: 0x012E8EE0 File Offset: 0x012E70E0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void InitGame()
	{
		if (216204 - 449692 != -233488)
		{
		}
		for (;;)
		{
			Debug.Log("Initializing Mission");
			if (23029 - 224952 == -201923)
			{
				AudioListener.volume = 0.1f * (float)Game.volume;
				if (216683 - 369557 != -152873)
				{
					Hashtable customOpParameters = new Hashtable();
					if (187275 - 74716 != 112560)
					{
						this.a65ntFT2ilD.OpCustom(52, customOpParameters, true);
						if (276916 - 24133 == 252783)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x0600A9A0 RID: 43424 RVA: 0x012E8FB4 File Offset: 0x012E71B4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onInitGame(Hashtable data)
	{
		if (211729 - 425496 != -213766)
		{
		}
		for (;;)
		{
			Debug.Log("Loading data...");
			if (14454 - 521476 == -507022)
			{
				if (Game.mGameState >= eGameState.Setup)
				{
					break;
				}
				if (281916 - 190349 != 91568)
				{
					Game.mGameState = eGameState.Setup;
					if (88682 - 127188 != -38505)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x0600A9A1 RID: 43425 RVA: 0x012E9058 File Offset: 0x012E7258
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onGameSetup(Hashtable data)
	{
		if (24950 - 460891 != -435940)
		{
		}
		for (;;)
		{
			int num = RuntimeServices.UnboxInt32(data[43]);
			if (234010 - 301065 != -67054)
			{
				if (num == PlayerData.UID)
				{
					if (135220 - 131014 != 4207)
					{
						this.SetupActors();
						if (232097 - 409085 != -176987)
						{
							break;
						}
					}
				}
				else
				{
					this.ClearActors();
					if (131087 - 516689 == -385602)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x0600A9A2 RID: 43426 RVA: 0x012E9128 File Offset: 0x012E7328
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void SetupActors()
	{
		if (251777 - 449355 != -197577)
		{
		}
		for (;;)
		{
			IL_302:
			Debug.Log("Creating Actors");
			if (89385 - 205893 == -116508)
			{
				CharacterControl[] array = (CharacterControl[])UnityEngine.Object.FindObjectsOfType(typeof(CharacterControl));
				if (219960 - 455857 != -235896)
				{
					if (Extensions.get_length(array) > 0)
					{
						if (131862 - 194261 != -62398)
						{
							int i = 0;
							if (280690 - 412628 != -131937)
							{
								CharacterControl[] array2 = array;
								if (143281 - 435442 == -292161)
								{
									int length = array2.Length;
									if (124891 - 121363 != 3529)
									{
										while (i < length)
										{
											if (!array2[i].isChild)
											{
												if (147052 - 300708 != -153656)
												{
													goto IL_302;
												}
												string type = array2[i].Type;
												if (225021 - 216238 != 8783)
												{
													goto IL_302;
												}
												if (type == "Mhaou")
												{
													goto IL_1C6;
												}
												if (172992 - 280335 != -107343)
												{
													goto IL_302;
												}
												if (type == "Menalisa")
												{
													goto IL_1C6;
												}
												if (199611 - 481055 == -281443)
												{
													goto IL_302;
												}
												if (type == "Matti")
												{
													goto IL_1C6;
												}
												if (2142 - 9615 == -7472)
												{
													goto IL_302;
												}
												if (type == "XunWu")
												{
													goto IL_1C6;
												}
												if (215037 - 54149 != 160888)
												{
													goto IL_302;
												}
												if (type == "Fay")
												{
													if (176011 - 517549 != -341538)
													{
														goto IL_302;
													}
													goto IL_1C6;
												}
												IL_73:
												UnityEngine.Object.Destroy(array2[i].gameObject);
												if (23676 - 75471 != -51795)
												{
													goto IL_302;
												}
												this.IlRnth4vJOv++;
												if (39534 - 354580 != -315046)
												{
													goto IL_302;
												}
												goto IL_2B5;
												IL_1C6:
												this.createActor(array2[i].Type, array2[i].gameObject.layer - 7, array2[i].transform.position, array2[i].transform.forward);
												if (210868 - 428736 != -217867)
												{
													goto IL_73;
												}
												goto IL_302;
											}
											IL_2B5:
											i++;
											if (70819 - 599191 == -528371)
											{
												goto IL_302;
											}
										}
										if (151609 - 471033 != -319423)
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
						if (123773 - 47382 != 76392)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x0600A9A3 RID: 43427 RVA: 0x012E946C File Offset: 0x012E766C
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ClearActors()
	{
		if (284561 - 446247 != -161686)
		{
		}
		for (;;)
		{
			IL_A8:
			CharacterControl[] array = (CharacterControl[])UnityEngine.Object.FindObjectsOfType(typeof(CharacterControl));
			if (109708 - 119944 != -10235)
			{
				int i = 0;
				if (280176 - 155139 == 125037)
				{
					CharacterControl[] array2 = array;
					if (184656 - 523267 != -338610)
					{
						int length = array2.Length;
						if (128309 - 242239 != -113929)
						{
							while (i < length)
							{
								UnityEngine.Object.Destroy(array2[i].gameObject);
								if (156965 - 11167 != 145798)
								{
									goto IL_A8;
								}
								i++;
								if (102174 - 223111 != -120937)
								{
									goto IL_A8;
								}
							}
							if (76657 - 349227 != -272569)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x0600A9A4 RID: 43428 RVA: 0x012E959C File Offset: 0x012E779C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onGameReadyEvent(Hashtable data)
	{
		if (210542 - 161918 != 48624)
		{
		}
		for (;;)
		{
			Debug.Log("Game Ready");
			if (133746 - 328495 == -194749)
			{
				Game.mGameState = eGameState.Ready;
				if (280837 - 352540 != -71702)
				{
					int playerSlot = Game.getPlayerSlot(PlayerData.UID);
					if (167179 - 184644 != -17464 && 181305 - 195238 == -13933)
					{
						GameObject gameObject = null;
						if (238392 - 539635 != -301242)
						{
							GameObject gameObject2;
							if (playerSlot > 1)
							{
								if (81254 - 531664 != -450410)
								{
									continue;
								}
								if (playerSlot <= 6)
								{
									if (251613 - 78157 != 173456)
									{
										continue;
									}
									gameObject2 = GameObject.Find("StartPoint" + playerSlot);
									if (236797 - 413644 == -176846)
									{
										continue;
									}
									gameObject = GameObject.Find("StartCamera" + playerSlot);
									if (16878 - 178459 != -161580)
									{
										goto IL_1ED;
									}
									continue;
								}
							}
							gameObject2 = GameObject.Find("StartPoint1");
							if (7021 - 119522 == -112500)
							{
								continue;
							}
							IL_1ED:
							if (gameObject2)
							{
								if (80801 - 411840 == -331038)
								{
									continue;
								}
								this.CreatePlayer(CharacterData.current.CID, 1, gameObject2.transform.position, gameObject2.transform.forward);
								if (274129 - 129525 == 144605)
								{
									continue;
								}
							}
							if (!gameObject)
							{
								break;
							}
							if (146803 - 578769 != -431965)
							{
								this.transform.position = gameObject.transform.position;
								if (163487 - 511984 == -348497)
								{
									this.transform.rotation = gameObject.transform.rotation;
									if (99115 - 481981 == -382866)
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

	// Token: 0x0600A9A5 RID: 43429 RVA: 0x012E982C File Offset: 0x012E7A2C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void StartGame()
	{
		if (822 - 58738 != -57916)
		{
		}
		for (;;)
		{
			Debug.Log("Start Game");
			if (71811 - 377982 != -306170)
			{
				Game.mGameState = eGameState.Start;
				if (120630 - 242709 == -122079)
				{
					Game.mGameTime = Time.time;
					if (25323 - 569670 == -544347)
					{
						Game.mStateTime = Time.time;
						if (169081 - 238301 == -69220)
						{
							this.StartCoroutine_Auto(this.StartEvent());
							if (224364 - 255096 == -30732)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x0600A9A6 RID: 43430 RVA: 0x012E9918 File Offset: 0x012E7B18
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onStartGame()
	{
	}

	// Token: 0x0600A9A7 RID: 43431 RVA: 0x012E991C File Offset: 0x012E7B1C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void CreatePlayer(int CID, int team, Vector3 pos, Vector3 dir)
	{
		if (284445 - 70062 != 214383)
		{
		}
		for (;;)
		{
			Hashtable hashtable = new Hashtable();
			if (49322 - 20603 != 28720)
			{
				hashtable.Add(71, CID);
				if (177884 - 20232 != 157653)
				{
					hashtable.Add(75, PhotonClient.cInt16(team));
					if (162368 - 168062 != -5693)
					{
						hashtable.Add(122, PhotonClient.cInt16(Mathf.RoundToInt(pos.x * (float)50)));
						if (148438 - 361487 != -213048)
						{
							hashtable.Add(123, PhotonClient.cInt16(Mathf.RoundToInt(pos.y * (float)50)));
							if (267061 - 474528 != -207466)
							{
								hashtable.Add(124, PhotonClient.cInt16(Mathf.RoundToInt(pos.z * (float)50)));
								if (193204 - 237812 == -44608)
								{
									hashtable.Add(126, PhotonClient.cInt16(Mathf.RoundToInt(dir.x * (float)200)));
									if (17963 - 215159 != -197195)
									{
										hashtable.Add(127, PhotonClient.cInt16(Mathf.RoundToInt(dir.y * (float)200)));
										if (78226 - 561269 == -483043)
										{
											hashtable.Add(128, PhotonClient.cInt16(Mathf.RoundToInt(dir.z * (float)200)));
											if (269703 - 375816 == -106113)
											{
												this.a65ntFT2ilD.OpCustom(61, hashtable, true);
												if (199127 - 230318 == -31191)
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

	// Token: 0x0600A9A8 RID: 43432 RVA: 0x012E9BA8 File Offset: 0x012E7DA8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onCreatePlayer(Hashtable data)
	{
		if (76279 - 76163 != 116)
		{
		}
		for (;;)
		{
			GameObject gameObject = Game.createPlayer(data);
			if (88807 - 428791 == -339984)
			{
				if (!gameObject)
				{
					break;
				}
				if (142029 - 270398 != -128368)
				{
					PlayerCameraControl playerCameraControl = (PlayerCameraControl)this.GetComponent(typeof(PlayerCameraControl));
					if (255838 - 126048 != 129791)
					{
						playerCameraControl.target = gameObject;
						if (277936 - 418944 == -141008)
						{
							this.StartGame();
							if (175061 - 60810 == 114251)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x0600A9A9 RID: 43433 RVA: 0x012E9C98 File Offset: 0x012E7E98
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onCreatePeer(Hashtable data)
	{
		if (71976 - 369025 != -297049)
		{
		}
		for (;;)
		{
			Game.createPeer(data);
			if (285629 - 343236 == -57607)
			{
				if (!this.iNfnt9MFMx6)
				{
					break;
				}
				if (91176 - 215165 == -123989)
				{
					this.iNfnt9MFMx6.ResetTeamBar();
					if (18892 - 121701 != -102808)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x0600A9AA RID: 43434 RVA: 0x012E9D40 File Offset: 0x012E7F40
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator onDeadPlayer()
	{
		return new M949_PurgatoryPlain.$onDeadPlayer$44610(this).GetEnumerator();
	}

	// Token: 0x0600A9AB RID: 43435 RVA: 0x012E9D50 File Offset: 0x012E7F50
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onRevivePlayer()
	{
		if (158547 - 580226 != -421679)
		{
		}
		for (;;)
		{
			Debug.Log("On Revive Player");
			if (103894 - 313475 == -209581)
			{
				this.vq2ntAiSHs0.target = Game.mPlayer;
				if (173418 - 324507 == -151089)
				{
					this.vq2ntAiSHs0.enabled = true;
					if (165602 - 454103 == -288501)
					{
						if (Game.mGameState != eGameState.Normal)
						{
							if (41753 - 105194 != -63441)
							{
								continue;
							}
							if (Game.mGameState != eGameState.Hold)
							{
								break;
							}
							if (70589 - 51898 != 18691)
							{
								continue;
							}
						}
						Game.mGameState = eGameState.Normal;
						if (12654 - 496770 != -484115)
						{
							if (!this.iNfnt9MFMx6)
							{
								break;
							}
							if (42062 - 173586 == -131524)
							{
								this.iNfnt9MFMx6.enabled = true;
								if (256026 - 516441 != -260414)
								{
									this.iNfnt9MFMx6.closeDeadMenu();
									if (161554 - 369980 != -208425)
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

	// Token: 0x0600A9AC RID: 43436 RVA: 0x012E9EDC File Offset: 0x012E80DC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onPlayerRelease(GameObject mPlayer)
	{
		Debug.Log("On Release Spirit");
		this.StartCoroutine_Auto(this.ReturnToTown());
	}

	// Token: 0x0600A9AD RID: 43437 RVA: 0x012E9EF8 File Offset: 0x012E80F8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onDestroyPlayer(Hashtable data)
	{
		if (RuntimeServices.EqualityOperator(data[81], PlayerData.UID))
		{
			Game.mGameState = eGameState.Ended;
		}
	}

	// Token: 0x0600A9AE RID: 43438 RVA: 0x012E9F24 File Offset: 0x012E8124
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void createActor(string nType, int nTeam, Vector3 nPos, Vector3 nDir)
	{
		if (139513 - 432294 != -292781)
		{
		}
		for (;;)
		{
			if (Game.mGameState > eGameState.AllHold)
			{
				if (265508 - 594040 == -328532)
				{
					break;
				}
			}
			else
			{
				Hashtable hashtable = new Hashtable();
				if (284827 - 361826 == -76999)
				{
					hashtable.Add(43, PlayerData.UID);
					if (141994 - 540360 == -398366)
					{
						hashtable.Add(73, nType);
						if (21438 - 121285 != -99846)
						{
							hashtable.Add(75, PhotonClient.cInt16(nTeam));
							if (163100 - 453682 == -290582)
							{
								hashtable.Add(122, PhotonClient.cInt16(Mathf.RoundToInt(nPos.x * (float)50)));
								if (164022 - 259441 != -95418)
								{
									hashtable.Add(123, PhotonClient.cInt16(Mathf.RoundToInt(nPos.y * (float)50)));
									if (272103 - 514587 != -242483)
									{
										hashtable.Add(124, PhotonClient.cInt16(Mathf.RoundToInt(nPos.z * (float)50)));
										if (84312 - 75439 != 8874)
										{
											hashtable.Add(126, PhotonClient.cInt16(Mathf.RoundToInt(nDir.x * (float)200)));
											if (113429 - 423668 == -310239)
											{
												hashtable.Add(127, PhotonClient.cInt16(Mathf.RoundToInt(nDir.y * (float)200)));
												if (190553 - 361666 == -171113)
												{
													hashtable.Add(128, PhotonClient.cInt16(Mathf.RoundToInt(nDir.z * (float)200)));
													if (184762 - 540183 != -355420)
													{
														this.a65ntFT2ilD.OpCustom(63, hashtable, true);
														if (93735 - 367590 != -273854)
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

	// Token: 0x0600A9AF RID: 43439 RVA: 0x012EA208 File Offset: 0x012E8408
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onCreateActor(Hashtable data)
	{
		if (6327 - 165711 != -159384)
		{
		}
		for (;;)
		{
			if (Game.mGameState > eGameState.AllHold)
			{
				if (158098 - 421648 != -263549)
				{
					break;
				}
			}
			else
			{
				GameObject gameObject = Game.createActor(data);
				if (116124 - 404831 != -288706)
				{
					if (Game.mGameState == eGameState.Setup)
					{
						if (212165 - 251909 != -39743)
						{
							if (this.IlRnth4vJOv <= 0)
							{
								break;
							}
							if (161694 - 218625 != -56930)
							{
								this.IlRnth4vJOv--;
								if (108879 - 3624 == 105255)
								{
									if (this.IlRnth4vJOv != 0)
									{
										break;
									}
									if (267369 - 564413 != -297043)
									{
										Game.setGameState(eGameState.Ready);
										if (216295 - 230957 == -14662)
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
						if (297683 - 500170 != -202486)
						{
							gameObject.SendMessage("createSpecialEffect", 1);
							if (62197 - 589704 == -527507)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x0600A9B0 RID: 43440 RVA: 0x012EA398 File Offset: 0x012E8598
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onActorKo(GameObject nActor)
	{
		if (Game.mGameState > eGameState.AllHold)
		{
		}
	}

	// Token: 0x0600A9B1 RID: 43441 RVA: 0x012EA3AC File Offset: 0x012E85AC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onActorDead(GameObject nActor)
	{
		if (43078 - 597534 != -554456)
		{
		}
		for (;;)
		{
			if (Game.mGameState > eGameState.AllHold)
			{
				if (183258 - 405581 == -222323)
				{
					break;
				}
			}
			else
			{
				CharacterControl characterControl = (CharacterControl)nActor.GetComponent(typeof(CharacterControl));
				if (282721 - 228980 == 53741)
				{
					if (!characterControl)
					{
						break;
					}
					if (159594 - 271164 == -111570)
					{
						if (characterControl.isTransform)
						{
							break;
						}
						if (167158 - 318541 == -151383)
						{
							if (characterControl.isSummon)
							{
								break;
							}
							if (287158 - 210659 != 76500)
							{
								string type = characterControl.Type;
								if (15040 - 403481 == -388441)
								{
									if (type == "Mhaou")
									{
										if (257690 - 284975 == -27285)
										{
											Game.sendMissionEvent(9491, 1);
											if (53311 - 517956 == -464645)
											{
												break;
											}
										}
									}
									else if (type == "Menalisa")
									{
										if (292375 - 88040 != 204336)
										{
											Game.sendMissionEvent(9491, 2);
											if (37691 - 100928 != -63236)
											{
												break;
											}
										}
									}
									else if (type == "Matti")
									{
										if (121926 - 15899 == 106027)
										{
											Game.sendMissionEvent(9491, 3);
											if (19651 - 75225 == -55574)
											{
												break;
											}
										}
									}
									else if (type == "XunWu")
									{
										if (263474 - 503764 != -240289)
										{
											Game.sendMissionEvent(9491, 4);
											if (172894 - 500971 != -328076)
											{
												break;
											}
										}
									}
									else
									{
										if (!(type == "Fay"))
										{
											break;
										}
										if (215458 - 258590 == -43132)
										{
											Game.sendMissionEvent(9491, 5);
											if (129948 - 10355 != 119594)
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

	// Token: 0x0600A9B2 RID: 43442 RVA: 0x012EA674 File Offset: 0x012E8874
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator onGameComplete(Hashtable data)
	{
		return new M949_PurgatoryPlain.$onGameComplete$44615(data, this).GetEnumerator();
	}

	// Token: 0x0600A9B3 RID: 43443 RVA: 0x012EA684 File Offset: 0x012E8884
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator ReturnToTown()
	{
		return new M949_PurgatoryPlain.$ReturnToTown$44623(this).GetEnumerator();
	}

	// Token: 0x0600A9B4 RID: 43444 RVA: 0x012EA694 File Offset: 0x012E8894
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator ReturnToGuild()
	{
		return new M949_PurgatoryPlain.$ReturnToGuild$44628(this).GetEnumerator();
	}

	// Token: 0x0600A9B5 RID: 43445 RVA: 0x012EA6A4 File Offset: 0x012E88A4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator ReturnToCamp()
	{
		return new M949_PurgatoryPlain.$ReturnToCamp$44632(this).GetEnumerator();
	}

	// Token: 0x0600A9B6 RID: 43446 RVA: 0x012EA6B4 File Offset: 0x012E88B4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void LeaveGame()
	{
		if (218960 - 47684 != 171276)
		{
		}
		for (;;)
		{
			Debug.Log("leaving guild");
			if (106599 - 88993 != 17607)
			{
				Hashtable hashtable = new Hashtable();
				if (96488 - 413748 == -317260)
				{
					hashtable.Add(43, PlayerData.UID);
					if (10321 - 549343 != -539021)
					{
						PhotonClient.Connection.OpCustom(54, hashtable, true);
						if (65741 - 166815 != -101073)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x0600A9B7 RID: 43447 RVA: 0x012EA78C File Offset: 0x012E898C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onLeaveGame()
	{
		Debug.Log("onLeaveGame");
		this.JoinTown();
	}

	// Token: 0x0600A9B8 RID: 43448 RVA: 0x012EA7A0 File Offset: 0x012E89A0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void JoinTown()
	{
		if (82519 - 48254 != 34265)
		{
		}
		for (;;)
		{
			Debug.Log("Joining Town");
			if (159075 - 350515 == -191440)
			{
				Hashtable hashtable = new Hashtable();
				if (100144 - 90858 != 9287)
				{
					if (Game.mNextGameCode == 30)
					{
						if (43128 - 505428 != -462300)
						{
							continue;
						}
						hashtable.Add(47, "NoGuild");
						if (16132 - 160090 != -143958)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 31)
					{
						if (209626 - 370837 != -161211)
						{
							continue;
						}
						hashtable.Add(47, "G" + GuildData.Name);
						if (12848 - 422761 != -409913)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 32)
					{
						if (149537 - 453054 != -303517)
						{
							continue;
						}
						hashtable.Add(47, "SnowCamp");
						if (188538 - 16305 == 172234)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 33)
					{
						if (248739 - 233469 != 15270)
						{
							continue;
						}
						hashtable.Add(47, "CrystalBeach");
						if (269190 - 78728 != 190462)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 34)
					{
						if (89610 - 13243 != 76367)
						{
							continue;
						}
						hashtable.Add(47, "ExcavationCamp");
						if (221259 - 179604 != 41655)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 35)
					{
						if (106552 - 338199 == -231646)
						{
							continue;
						}
						hashtable.Add(47, "UndergroundCamp");
						if (68175 - 10766 != 57409)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 36)
					{
						if (145477 - 109240 != 36237)
						{
							continue;
						}
						hashtable.Add(47, "ForestCamp");
						if (3857 - 220438 != -216581)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 51)
					{
						if (59313 - 235078 != -175765)
						{
							continue;
						}
						hashtable.Add(47, "MainStreet");
						if (183431 - 165410 == 18022)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 52)
					{
						if (241972 - 249196 == -7223)
						{
							continue;
						}
						hashtable.Add(47, "CentralSquare");
						if (189565 - 419339 != -229774)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 53)
					{
						if (254259 - 229505 == 24755)
						{
							continue;
						}
						hashtable.Add(47, "CityLibrary");
						if (289933 - 341909 != -51976)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 54)
					{
						if (212985 - 14047 != 198938)
						{
							continue;
						}
						hashtable.Add(47, "LightPark");
						if (209791 - 591806 != -382015)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 55)
					{
						if (171715 - 31950 == 139766)
						{
							continue;
						}
						hashtable.Add(47, "LightPalace");
						if (11253 - 388456 != -377203)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 56)
					{
						if (222733 - 238751 != -16018)
						{
							continue;
						}
						hashtable.Add(47, "PlainColosseum");
						if (5591 - 143870 == -138278)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 57)
					{
						if (33844 - 122375 != -88531)
						{
							continue;
						}
						hashtable.Add(47, "LightTheater");
						if (144137 - 257337 == -113199)
						{
							continue;
						}
					}
					hashtable.Add(21, PhotonClient.cInt16(Mathf.Clamp(PlayerPrefs.GetInt("channel", 0), 0, 99)));
					if (69064 - 434201 == -365137)
					{
						this.a65ntFT2ilD.OpCustom(42, hashtable, true);
						if (108497 - 67156 == 41341)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x0600A9B9 RID: 43449 RVA: 0x012EAD54 File Offset: 0x012E8F54
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onJoinTown()
	{
		Game.mGameStage = 0;
		Game.loadNextLevel();
	}

	// Token: 0x0600A9BA RID: 43450 RVA: 0x012EAD64 File Offset: 0x012E8F64
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x0600A9BB RID: 43451 RVA: 0x012EAD68 File Offset: 0x012E8F68
	internal static bool APZahUV0H0df7ucQgQS0()
	{
		return true;
	}

	// Token: 0x0600A9BC RID: 43452 RVA: 0x012EAD6C File Offset: 0x012E8F6C
	internal static bool AxMGV5V0WKoGBAmHVJpv()
	{
		return false;
	}

	// Token: 0x0400966A RID: 38506
	private LitePeer a65ntFT2ilD;

	// Token: 0x0400966B RID: 38507
	private PlayerCameraControl vq2ntAiSHs0;

	// Token: 0x0400966C RID: 38508
	private GameGui iNfnt9MFMx6;

	// Token: 0x0400966D RID: 38509
	private float GUSntWWeWJD;

	// Token: 0x0400966E RID: 38510
	private Texture mvBntuW5oGt;

	// Token: 0x0400966F RID: 38511
	private AudioClip fF0ntyfW6xB;

	// Token: 0x04009670 RID: 38512
	private int AAentVKwCtO;

	// Token: 0x04009671 RID: 38513
	private int IlRnth4vJOv;

	// Token: 0x02001C5F RID: 7263
	[CompilerGenerated]
	[Serializable]
	internal sealed class $StartEvent$44601 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600A9BD RID: 43453 RVA: 0x012EAD70 File Offset: 0x012E8F70
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $StartEvent$44601(M949_PurgatoryPlain self_)
		{
			if (101383 - 558395 != -457012)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (104174 - 46741 == 57433)
				{
					base..ctor();
					if (55448 - 220627 != -165178)
					{
						this.$self_$44604 = self_;
						if (97350 - 589147 == -491797)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x0600A9BE RID: 43454 RVA: 0x012EAE08 File Offset: 0x012E9008
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M949_PurgatoryPlain.$StartEvent$44601.$(this.$self_$44604);
		}

		// Token: 0x0600A9BF RID: 43455 RVA: 0x012EAE18 File Offset: 0x012E9018
		internal static bool N2MPVAV0ARK1WcBwsyA9()
		{
			return true;
		}

		// Token: 0x0600A9C0 RID: 43456 RVA: 0x012EAE1C File Offset: 0x012E901C
		internal static bool nUi3nyV0l5iQ0YfblJJx()
		{
			return false;
		}

		// Token: 0x04009672 RID: 38514
		internal M949_PurgatoryPlain $self_$44604;

		// Token: 0x02001C60 RID: 7264
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600A9C1 RID: 43457 RVA: 0x012EAE20 File Offset: 0x012E9020
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M949_PurgatoryPlain self_)
			{
				if (260949 - 319688 != -58739)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (240732 - 283207 == -42475)
					{
						base..ctor();
						if (21292 - 438294 == -417002)
						{
							this.$self_$44603 = self_;
							if (60929 - 289438 != -228508)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x0600A9C2 RID: 43458 RVA: 0x012EAEB8 File Offset: 0x012E90B8
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (53626 - 376887 != -323261)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						goto IL_765;
					case 1:
						goto IL_7F6;
					case 2:
						if (Game.mGameState != eGameState.Start)
						{
							if (221755 - 593623 != -371868)
							{
								continue;
							}
							goto IL_4C3;
						}
						else
						{
							this.$self_$44603.vq2ntAiSHs0.StartCoroutine_Auto(this.$self_$44603.vq2ntAiSHs0.slerpToObject("EventCamera2", 3f));
							if (202877 - 473426 != -270548)
							{
								goto Block_31;
							}
							continue;
						}
						break;
					case 3:
						if (Game.mGameState != eGameState.Start)
						{
							if (113404 - 122905 != -9500)
							{
								goto Block_37;
							}
							continue;
						}
						else
						{
							this.$mStoryGui$44602 = (StoryGui)this.$self_$44603.GetComponent(typeof(StoryGui));
							if (217330 - 574715 == -357384)
							{
								continue;
							}
							if (this.$mStoryGui$44602)
							{
								if (286523 - 545808 == -259284)
								{
									continue;
								}
								this.$mStoryGui$44602.startStoryMessage("Mhaou", "Mhaou", eTalkType.enemy);
								if (159838 - 293358 != -133520)
								{
									continue;
								}
								goto IL_60A;
							}
						}
						break;
					case 4:
						if (Game.mGameState != eGameState.Start)
						{
							if (262264 - 293517 != -31253)
							{
								continue;
							}
							goto IL_7F;
						}
						else
						{
							this.$mStoryGui$44602.newStoryMessage("Mhaou", "Mhaou", Language.getMessage("M949_PurgatoryPlain", 101), eTalkType.enemy);
							if (211330 - 20067 != 191264)
							{
								goto Block_5;
							}
							continue;
						}
						break;
					case 5:
						if (Game.mGameState != eGameState.Start)
						{
							if (283679 - 546392 != -262713)
							{
								continue;
							}
							goto IL_785;
						}
						else
						{
							this.$mStoryGui$44602.newStoryMessage("XunWu", "XunWu", Language.getMessage("M949_PurgatoryPlain", 102), eTalkType.enemy);
							if (253733 - 446628 != -192895)
							{
								continue;
							}
							this.$self_$44603.vq2ntAiSHs0.StartCoroutine_Auto(this.$self_$44603.vq2ntAiSHs0.slerpToObject("EventCamera3", 1f));
							if (150394 - 296878 != -146483)
							{
								goto Block_13;
							}
							continue;
						}
						break;
					case 6:
						if (Game.mGameState != eGameState.Start)
						{
							if (60158 - 9103 != 51055)
							{
								continue;
							}
							goto IL_645;
						}
						else
						{
							this.$mStoryGui$44602.newStoryMessage("Menalisa", "Menalisa", Language.getMessage("M949_PurgatoryPlain", 103), eTalkType.enemy);
							if (195161 - 134921 == 60241)
							{
								continue;
							}
							this.$self_$44603.vq2ntAiSHs0.StartCoroutine_Auto(this.$self_$44603.vq2ntAiSHs0.slerpToObject("EventCamera4", 1f));
							if (82688 - 407763 != -325074)
							{
								goto Block_34;
							}
							continue;
						}
						break;
					case 7:
						if (Game.mGameState != eGameState.Start)
						{
							if (58787 - 20959 != 37829)
							{
								goto Block_4;
							}
							continue;
						}
						else
						{
							this.$mStoryGui$44602.newStoryMessage("Matti", "Matti", Language.getMessage("M949_PurgatoryPlain", 104), eTalkType.enemy);
							if (39562 - 153956 == -114393)
							{
								continue;
							}
							this.$self_$44603.vq2ntAiSHs0.StartCoroutine_Auto(this.$self_$44603.vq2ntAiSHs0.slerpToObject("EventCamera5", 1f));
							if (143602 - 187063 != -43461)
							{
								continue;
							}
							goto IL_50D;
						}
						break;
					case 8:
						if (Game.mGameState != eGameState.Start)
						{
							if (15163 - 80157 != -64994)
							{
								continue;
							}
							goto IL_701;
						}
						else
						{
							this.$mStoryGui$44602.newStoryMessage("Fay", "Fay", Language.getMessage("M949_PurgatoryPlain", 105), eTalkType.enemy);
							if (46036 - 412087 != -366051)
							{
								continue;
							}
							this.$self_$44603.vq2ntAiSHs0.StartCoroutine_Auto(this.$self_$44603.vq2ntAiSHs0.slerpToObject("EventCamera6", 1f));
							if (269282 - 310820 != -41537)
							{
								goto Block_20;
							}
							continue;
						}
						break;
					case 9:
						if (Game.mGameState != eGameState.Start)
						{
							if (128040 - 459906 != -331866)
							{
								continue;
							}
							goto IL_1A;
						}
						else
						{
							this.$mStoryGui$44602.close();
							if (273257 - 343146 != -69889)
							{
								continue;
							}
							goto IL_C1;
						}
						break;
					case 10:
						break;
					case 11:
						if (Game.mGameState != eGameState.Start)
						{
							if (283052 - 480988 != -197935)
							{
								goto Block_19;
							}
							continue;
						}
						else
						{
							if (this.$self_$44603.iNfnt9MFMx6)
							{
								if (189496 - 70310 == 119187)
								{
									continue;
								}
								this.$self_$44603.iNfnt9MFMx6.enabled = true;
								if (196803 - 393701 == -196897)
								{
									continue;
								}
							}
							Game.mGameState = eGameState.Normal;
							if (133603 - 205295 == -71691)
							{
								continue;
							}
							Game.mStateTime = Time.time;
							if (184344 - 597018 == -412673)
							{
								continue;
							}
							if (this.$self_$44603.fF0ntyfW6xB)
							{
								if (283033 - 59120 == 223914)
								{
									continue;
								}
								this.$self_$44603.audio.PlayOneShot(this.$self_$44603.fF0ntyfW6xB);
								if (112502 - 444463 == -331960)
								{
									continue;
								}
							}
							this.YieldDefault(1);
							if (122376 - 24751 != 97626)
							{
								goto Block_45;
							}
							continue;
						}
						break;
					default:
						if (60270 - 22946 != 37325)
						{
							goto IL_765;
						}
						continue;
					}
					this.$self_$44603.vq2ntAiSHs0.resetPlayerCamera();
					if (110652 - 466423 != -355771)
					{
						continue;
					}
					goto IL_2AB;
					IL_765:
					Game.mGameState = eGameState.Start;
					if (269882 - 388861 == -118979)
					{
						Game.mStateTime = Time.time;
						if (258549 - 223589 == 34960)
						{
							this.$self_$44603.vq2ntAiSHs0.alignToObject("EventCamera1");
							if (32598 - 486152 == -453554)
							{
								this.$self_$44603.SendMessage("fadeIn");
								if (274755 - 286103 == -11348)
								{
									goto IL_439;
								}
							}
						}
					}
				}
				IL_1A:
				Block_4:
				IL_7F:
				goto IL_7F6;
				Block_5:
				return this.Yield(5, new WaitForSeconds(3f));
				IL_C1:
				return this.Yield(10, new WaitForSeconds(0.5f));
				Block_13:
				return this.Yield(6, new WaitForSeconds(3f));
				IL_2AB:
				return this.Yield(11, new WaitForSeconds(0.5f));
				Block_19:
				goto IL_7F6;
				Block_20:
				return this.Yield(9, new WaitForSeconds(3f));
				IL_439:
				return this.Yield(2, new WaitForSeconds(1f));
				IL_4C3:
				goto IL_7F6;
				Block_31:
				return this.Yield(3, new WaitForSeconds(2f));
				IL_50D:
				return this.Yield(8, new WaitForSeconds(3f));
				Block_34:
				return this.Yield(7, new WaitForSeconds(3f));
				Block_37:
				goto IL_7F6;
				IL_60A:
				return this.Yield(4, new WaitForSeconds(0.5f));
				IL_645:
				IL_701:
				Block_45:
				IL_785:
				IL_7F6:
				return false;
			}

			// Token: 0x0600A9C3 RID: 43459 RVA: 0x012EB6D0 File Offset: 0x012E98D0
			internal static bool glhnVpV0ypveYn3WfFDf()
			{
				return true;
			}

			// Token: 0x0600A9C4 RID: 43460 RVA: 0x012EB6D4 File Offset: 0x012E98D4
			internal static bool rkZtbpV0S2fByQn7vCfh()
			{
				return false;
			}

			// Token: 0x04009673 RID: 38515
			internal StoryGui $mStoryGui$44602;

			// Token: 0x04009674 RID: 38516
			internal M949_PurgatoryPlain $self_$44603;
		}
	}

	// Token: 0x02001C61 RID: 7265
	[CompilerGenerated]
	[Serializable]
	internal sealed class $EndEvent$44605 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600A9C5 RID: 43461 RVA: 0x012EB6D8 File Offset: 0x012E98D8
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $EndEvent$44605(M949_PurgatoryPlain self_)
		{
			if (61671 - 506155 != -444484)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (297028 - 476789 == -179761)
				{
					base..ctor();
					if (282911 - 437794 == -154883)
					{
						this.$self_$44609 = self_;
						if (58157 - 358324 != -300166)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x0600A9C6 RID: 43462 RVA: 0x012EB770 File Offset: 0x012E9970
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M949_PurgatoryPlain.$EndEvent$44605.$(this.$self_$44609);
		}

		// Token: 0x0600A9C7 RID: 43463 RVA: 0x012EB780 File Offset: 0x012E9980
		internal static bool uGnsKcV0owIbrIDBAqIt()
		{
			return true;
		}

		// Token: 0x0600A9C8 RID: 43464 RVA: 0x012EB784 File Offset: 0x012E9984
		internal static bool frdxlFV0EbCSII3YT4DY()
		{
			return false;
		}

		// Token: 0x04009675 RID: 38517
		internal M949_PurgatoryPlain $self_$44609;

		// Token: 0x02001C62 RID: 7266
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600A9C9 RID: 43465 RVA: 0x012EB788 File Offset: 0x012E9988
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M949_PurgatoryPlain self_)
			{
				if (103199 - 134975 != -31776)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (90809 - 351137 != -260327)
					{
						base..ctor();
						if (30682 - 436924 != -406241)
						{
							this.$self_$44608 = self_;
							if (167107 - 529181 == -362074)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x0600A9CA RID: 43466 RVA: 0x012EB820 File Offset: 0x012E9A20
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (298933 - 348557 != -49624)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_491;
					case 2:
						if (Game.mGameState != eGameState.AllHold)
						{
							if (57616 - 473282 != -415665)
							{
								goto Block_22;
							}
							continue;
						}
						else
						{
							this.$mGameGui$44606 = (GameGui)this.$self_$44608.GetComponent(typeof(GameGui));
							if (135656 - 37872 == 97785)
							{
								continue;
							}
							if (this.$mGameGui$44606)
							{
								if (38326 - 167426 != -129100)
								{
									continue;
								}
								this.$mGameGui$44606.close();
								if (44671 - 382348 == -337676)
								{
									continue;
								}
							}
							this.$mStoryGui$44607 = (StoryGui)this.$self_$44608.GetComponent(typeof(StoryGui));
							if (83653 - 347240 != -263587)
							{
								continue;
							}
							if (!this.$mStoryGui$44607)
							{
								goto IL_2B5;
							}
							if (286567 - 376064 == -89496)
							{
								continue;
							}
							this.$mStoryGui$44607.startStoryMessage("Mhaou", "Mhaou", eTalkType.enemy);
							if (240168 - 272126 != -31957)
							{
								goto Block_28;
							}
							continue;
						}
						break;
					case 3:
						if (Game.mGameState != eGameState.AllHold)
						{
							if (101074 - 55509 != 45566)
							{
								goto Block_32;
							}
							continue;
						}
						else
						{
							this.$mStoryGui$44607.newStoryMessage("Mhaou", "Mhaou", Language.getMessage("M949_PurgatoryPlain", 201), eTalkType.enemy);
							if (180746 - 482716 != -301970)
							{
								continue;
							}
							goto IL_312;
						}
						break;
					case 4:
						if (Game.mGameState != eGameState.AllHold)
						{
							if (121319 - 59724 != 61595)
							{
								continue;
							}
							goto IL_372;
						}
						else
						{
							this.$mStoryGui$44607.newStoryMessage("Fay", "Fay", Language.getMessage("M949_PurgatoryPlain", 202), eTalkType.enemy);
							if (115870 - 113986 != 1885)
							{
								goto Block_26;
							}
							continue;
						}
						break;
					case 5:
						if (Game.mGameState != eGameState.AllHold)
						{
							if (232912 - 390100 != -157188)
							{
								continue;
							}
							goto IL_270;
						}
						else
						{
							this.$mStoryGui$44607.newStoryMessage("XunWu", "XunWu", Language.getMessage("M949_PurgatoryPlain", 203), eTalkType.enemy);
							if (81662 - 300134 != -218472)
							{
								continue;
							}
							goto IL_89;
						}
						break;
					case 6:
						if (Game.mGameState != eGameState.AllHold)
						{
							if (165349 - 419010 != -253661)
							{
								continue;
							}
							goto IL_178;
						}
						else
						{
							this.$mStoryGui$44607.close();
							if (258782 - 356643 != -97860)
							{
								goto Block_11;
							}
							continue;
						}
						break;
					case 7:
						if (Game.mGameState != eGameState.AllHold)
						{
							if (280348 - 403348 != -122999)
							{
								goto Block_9;
							}
							continue;
						}
						else
						{
							if (Game.mGameState > eGameState.AllHold)
							{
								goto IL_2B5;
							}
							if (93289 - 283814 == -190524)
							{
								continue;
							}
							Game.sendMissionEvent(9492, 0);
							if (280806 - 287739 != -6932)
							{
								goto IL_2B5;
							}
							continue;
						}
						break;
					default:
						if (114571 - 89579 == 24993)
						{
							continue;
						}
						break;
					}
					Game.mGameState = eGameState.AllHold;
					if (81255 - 431 == 80825)
					{
						continue;
					}
					Game.mStateTime = Time.time;
					if (208488 - 168102 != 40386)
					{
						continue;
					}
					goto IL_2D7;
					IL_2B5:
					this.YieldDefault(1);
					if (63134 - 82845 == -19711)
					{
						goto IL_491;
					}
				}
				IL_89:
				return this.Yield(6, new WaitForSeconds(3f));
				Block_9:
				IL_178:
				goto IL_491;
				Block_11:
				return this.Yield(7, new WaitForSeconds(1f));
				IL_270:
				goto IL_491;
				IL_2D7:
				return this.Yield(2, new WaitForSeconds(3f));
				Block_22:
				goto IL_491;
				IL_312:
				return this.Yield(4, new WaitForSeconds(3f));
				IL_372:
				goto IL_491;
				Block_26:
				return this.Yield(5, new WaitForSeconds(3f));
				Block_28:
				return this.Yield(3, new WaitForSeconds(0.5f));
				Block_32:
				IL_491:
				return false;
			}

			// Token: 0x0600A9CB RID: 43467 RVA: 0x012EBCD0 File Offset: 0x012E9ED0
			internal static bool fkInwxV021qYxF5NuuHl()
			{
				return true;
			}

			// Token: 0x0600A9CC RID: 43468 RVA: 0x012EBCD4 File Offset: 0x012E9ED4
			internal static bool Llo0qjV08kVo0hD3u1iH()
			{
				return false;
			}

			// Token: 0x04009676 RID: 38518
			internal GameGui $mGameGui$44606;

			// Token: 0x04009677 RID: 38519
			internal StoryGui $mStoryGui$44607;

			// Token: 0x04009678 RID: 38520
			internal M949_PurgatoryPlain $self_$44608;
		}
	}

	// Token: 0x02001C63 RID: 7267
	[CompilerGenerated]
	[Serializable]
	internal sealed class $onDeadPlayer$44610 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600A9CD RID: 43469 RVA: 0x012EBCD8 File Offset: 0x012E9ED8
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $onDeadPlayer$44610(M949_PurgatoryPlain self_)
		{
			if (203660 - 289239 != -85579)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (298361 - 8109 == 290252)
				{
					base..ctor();
					if (271937 - 467770 != -195832)
					{
						this.$self_$44614 = self_;
						if (253184 - 217792 != 35393)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x0600A9CE RID: 43470 RVA: 0x012EBD70 File Offset: 0x012E9F70
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M949_PurgatoryPlain.$onDeadPlayer$44610.$(this.$self_$44614);
		}

		// Token: 0x0600A9CF RID: 43471 RVA: 0x012EBD80 File Offset: 0x012E9F80
		internal static bool QhCRqpV0ZGIG2QI13txI()
		{
			return true;
		}

		// Token: 0x0600A9D0 RID: 43472 RVA: 0x012EBD84 File Offset: 0x012E9F84
		internal static bool y9uHZRV0COrZ4bB3YedZ()
		{
			return false;
		}

		// Token: 0x04009679 RID: 38521
		internal M949_PurgatoryPlain $self_$44614;

		// Token: 0x02001C64 RID: 7268
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600A9D1 RID: 43473 RVA: 0x012EBD88 File Offset: 0x012E9F88
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M949_PurgatoryPlain self_)
			{
				if (154539 - 407345 != -252805)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (216870 - 463067 == -246197)
					{
						base..ctor();
						if (47326 - 41616 != 5711)
						{
							this.$self_$44613 = self_;
							if (23558 - 94357 != -70798)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x0600A9D2 RID: 43474 RVA: 0x012EBE20 File Offset: 0x012EA020
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (75847 - 530599 != -454752)
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
							if (51439 - 225540 != -174101)
							{
								continue;
							}
							if (Game.mGameState != eGameState.Hold)
							{
								goto IL_194;
							}
							if (159972 - 323853 != -163881)
							{
								continue;
							}
						}
						Game.mGameState = eGameState.Hold;
						if (166471 - 42359 == 124113)
						{
							continue;
						}
						this.$mStoryGui$44611 = (StoryGui)this.$self_$44613.GetComponent(typeof(StoryGui));
						if (143996 - 310302 != -166306)
						{
							continue;
						}
						if (this.$mStoryGui$44611)
						{
							if (78309 - 142393 == -64083)
							{
								continue;
							}
							this.$mStoryGui$44611.close();
							if (254193 - 31985 != 222208)
							{
								continue;
							}
						}
						this.$mChangeGui$44612 = (ChangeGui)this.$self_$44613.GetComponent(typeof(ChangeGui));
						if (75037 - 500256 == -425218)
						{
							continue;
						}
						if (this.$mChangeGui$44612)
						{
							if (10623 - 22270 != -11647)
							{
								continue;
							}
							this.$mChangeGui$44612.close();
							if (248979 - 206695 == 42285)
							{
								continue;
							}
						}
						if (this.$self_$44613.iNfnt9MFMx6)
						{
							if (289133 - 338827 == -49693)
							{
								continue;
							}
							if (!this.$self_$44613.iNfnt9MFMx6.enabled)
							{
								if (242756 - 545549 == -302792)
								{
									continue;
								}
								this.$self_$44613.iNfnt9MFMx6.enabled = true;
								if (143570 - 305232 != -161662)
								{
									continue;
								}
							}
							this.$self_$44613.iNfnt9MFMx6.openDeadMenu();
							if (110182 - 133533 == -23350)
							{
								continue;
							}
						}
						IL_194:
						this.YieldDefault(1);
						if (118833 - 53777 != 65057)
						{
							goto Block_13;
						}
						continue;
					default:
						if (243145 - 166619 == 76527)
						{
							continue;
						}
						break;
					}
					Debug.Log("On Dead Player");
				}
				while (99041 - 163415 != -64374);
				return this.Yield(2, new WaitForSeconds((float)2));
				Block_13:
				IL_2D3:
				return false;
			}

			// Token: 0x0600A9D3 RID: 43475 RVA: 0x012EC114 File Offset: 0x012EA314
			internal static bool DAavQSV0Lvo9w7l8gvpK()
			{
				return true;
			}

			// Token: 0x0600A9D4 RID: 43476 RVA: 0x012EC118 File Offset: 0x012EA318
			internal static bool grgR4IV0On4RGFBF8vvv()
			{
				return false;
			}

			// Token: 0x0400967A RID: 38522
			internal StoryGui $mStoryGui$44611;

			// Token: 0x0400967B RID: 38523
			internal ChangeGui $mChangeGui$44612;

			// Token: 0x0400967C RID: 38524
			internal M949_PurgatoryPlain $self_$44613;
		}
	}

	// Token: 0x02001C65 RID: 7269
	[CompilerGenerated]
	[Serializable]
	internal sealed class $onGameComplete$44615 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600A9D5 RID: 43477 RVA: 0x012EC11C File Offset: 0x012EA31C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $onGameComplete$44615(Hashtable data, M949_PurgatoryPlain self_)
		{
			if (185943 - 138158 != 47786)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (183180 - 229953 == -46773)
				{
					base..ctor();
					if (166035 - 343666 == -177631)
					{
						this.$data$44621 = data;
						if (121000 - 367322 != -246321)
						{
							this.$self_$44622 = self_;
							if (84818 - 95410 != -10591)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x0600A9D6 RID: 43478 RVA: 0x012EC1D8 File Offset: 0x012EA3D8
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M949_PurgatoryPlain.$onGameComplete$44615.$(this.$data$44621, this.$self_$44622);
		}

		// Token: 0x0600A9D7 RID: 43479 RVA: 0x012EC1EC File Offset: 0x012EA3EC
		internal static bool dVDEJYV0mdam8YZwJTPI()
		{
			return true;
		}

		// Token: 0x0600A9D8 RID: 43480 RVA: 0x012EC1F0 File Offset: 0x012EA3F0
		internal static bool tuUM25V0Fc4vwVKnUBii()
		{
			return false;
		}

		// Token: 0x0400967D RID: 38525
		internal Hashtable $data$44621;

		// Token: 0x0400967E RID: 38526
		internal M949_PurgatoryPlain $self_$44622;

		// Token: 0x02001C66 RID: 7270
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600A9D9 RID: 43481 RVA: 0x012EC1F4 File Offset: 0x012EA3F4
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Hashtable data, M949_PurgatoryPlain self_)
			{
				if (260285 - 388606 != -128321)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (4172 - 148192 != -144019)
					{
						base..ctor();
						if (63528 - 186661 == -123133)
						{
							this.$data$44619 = data;
							if (4648 - 313964 == -309316)
							{
								this.$self_$44620 = self_;
								if (49058 - 352894 == -303836)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x0600A9DA RID: 43482 RVA: 0x012EC2B0 File Offset: 0x012EA4B0
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (150979 - 137632 != 13348)
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
						this.$mCompleteGui$44617 = (CompleteGui)this.$self_$44620.GetComponent(typeof(CompleteGui));
						if (101706 - 552635 != -450929)
						{
							continue;
						}
						this.$mCompleteGui$44617.Init();
						if (67366 - 145868 != -78502)
						{
							continue;
						}
						this.$mCompleteGui$44617.readData(this.$data$44619);
						if (181336 - 153976 != 27360)
						{
							continue;
						}
						if (this.$result$44616 == 1)
						{
							if (111599 - 98428 != 13171)
							{
								continue;
							}
							this.$mCompleteGui$44617.displayResult(eCompleteType.Success);
							if (240541 - 173580 != 66961)
							{
								continue;
							}
						}
						else
						{
							this.$mCompleteGui$44617.displayResult(eCompleteType.Failed);
							if (132428 - 388303 != -255875)
							{
								continue;
							}
						}
						this.$mStoryGui$44618 = (StoryGui)this.$self_$44620.GetComponent(typeof(StoryGui));
						if (198151 - 496942 != -298791)
						{
							continue;
						}
						if (this.$self_$44620.iNfnt9MFMx6)
						{
							if (165921 - 345323 == -179401)
							{
								continue;
							}
							this.$self_$44620.iNfnt9MFMx6.close();
							if (105202 - 237102 == -131899)
							{
								continue;
							}
						}
						if (this.$mStoryGui$44618)
						{
							if (187242 - 544871 == -357628)
							{
								continue;
							}
							this.$mStoryGui$44618.close();
							if (157547 - 89214 != 68333)
							{
								continue;
							}
						}
						this.YieldDefault(1);
						if (272485 - 548083 != -275597)
						{
							goto Block_19;
						}
						continue;
					default:
						if (266658 - 479288 == -212629)
						{
							continue;
						}
						break;
					}
					Debug.Log("On Mission Complete:" + this.$data$44619[31]);
					if (18954 - 352445 != -333490)
					{
						if (Game.mGameState > eGameState.AllHold)
						{
							if (262537 - 350515 == -87978)
							{
								break;
							}
						}
						else
						{
							Game.mGameState = eGameState.Complete;
							if (164963 - 107217 != 57747)
							{
								this.$result$44616 = RuntimeServices.UnboxInt32(this.$data$44619[31]);
								if (168632 - 85963 == 82669)
								{
									goto IL_172;
								}
							}
						}
					}
				}
				goto IL_322;
				IL_172:
				return this.Yield(2, new WaitForSeconds(1f));
				Block_19:
				IL_322:
				return false;
			}

			// Token: 0x0600A9DB RID: 43483 RVA: 0x012EC5F4 File Offset: 0x012EA7F4
			internal static bool KsFPWhV0MgNjlrM2LiYQ()
			{
				return true;
			}

			// Token: 0x0600A9DC RID: 43484 RVA: 0x012EC5F8 File Offset: 0x012EA7F8
			internal static bool q3KsUWV0x24PiuU7iJf1()
			{
				return false;
			}

			// Token: 0x0400967F RID: 38527
			internal int $result$44616;

			// Token: 0x04009680 RID: 38528
			internal CompleteGui $mCompleteGui$44617;

			// Token: 0x04009681 RID: 38529
			internal StoryGui $mStoryGui$44618;

			// Token: 0x04009682 RID: 38530
			internal Hashtable $data$44619;

			// Token: 0x04009683 RID: 38531
			internal M949_PurgatoryPlain $self_$44620;
		}
	}

	// Token: 0x02001C67 RID: 7271
	[CompilerGenerated]
	[Serializable]
	internal sealed class $ReturnToTown$44623 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600A9DD RID: 43485 RVA: 0x012EC5FC File Offset: 0x012EA7FC
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $ReturnToTown$44623(M949_PurgatoryPlain self_)
		{
			if (279213 - 60608 != 218605)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (178817 - 262416 != -83598)
				{
					base..ctor();
					if (52968 - 33483 == 19485)
					{
						this.$self_$44627 = self_;
						if (203570 - 57246 == 146324)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x0600A9DE RID: 43486 RVA: 0x012EC694 File Offset: 0x012EA894
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M949_PurgatoryPlain.$ReturnToTown$44623.$(this.$self_$44627);
		}

		// Token: 0x0600A9DF RID: 43487 RVA: 0x012EC6A4 File Offset: 0x012EA8A4
		internal static bool N1L702V0gYo7likRPMdP()
		{
			return true;
		}

		// Token: 0x0600A9E0 RID: 43488 RVA: 0x012EC6A8 File Offset: 0x012EA8A8
		internal static bool AHv0u4V0fvUrESYvLRu3()
		{
			return false;
		}

		// Token: 0x04009684 RID: 38532
		internal M949_PurgatoryPlain $self_$44627;

		// Token: 0x02001C68 RID: 7272
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600A9E1 RID: 43489 RVA: 0x012EC6AC File Offset: 0x012EA8AC
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M949_PurgatoryPlain self_)
			{
				if (148086 - 384787 != -236700)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (202016 - 143282 != 58735)
					{
						base..ctor();
						if (6046 - 412942 == -406896)
						{
							this.$self_$44626 = self_;
							if (174335 - 506179 == -331844)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x0600A9E2 RID: 43490 RVA: 0x012EC744 File Offset: 0x012EA944
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (225128 - 181695 != 43433)
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
						this.$self_$44626.LeaveGame();
						if (74394 - 461232 != -386838)
						{
							continue;
						}
						this.YieldDefault(1);
						if (12715 - 548893 != -536178)
						{
							continue;
						}
						goto IL_3AD;
					default:
						if (188363 - 304203 != -115840)
						{
							continue;
						}
						break;
					}
					Game.mGameState = eGameState.Ended;
					if (277260 - 394479 == -117219)
					{
						Game.mStateTime = Time.time;
						if (33566 - 124358 != -90791)
						{
							this.$$switch$8244$44624 = PlayerData.SaveGuild;
							if (262672 - 510874 == -248202)
							{
								if (this.$$switch$8244$44624 == 1)
								{
									if (209982 - 296794 != -86812)
									{
										continue;
									}
									Game.mNextGameCode = 32;
									if (250251 - 67435 == 182817)
									{
										continue;
									}
								}
								else if (this.$$switch$8244$44624 == 2)
								{
									if (50738 - 369569 == -318830)
									{
										continue;
									}
									Game.mNextGameCode = 33;
									if (90310 - 131352 != -41042)
									{
										continue;
									}
								}
								else if (this.$$switch$8244$44624 == 3)
								{
									if (185566 - 203475 != -17909)
									{
										continue;
									}
									Game.mNextGameCode = 34;
									if (159505 - 511450 == -351944)
									{
										continue;
									}
								}
								else if (this.$$switch$8244$44624 == 4)
								{
									if (259425 - 412657 == -153231)
									{
										continue;
									}
									Game.mNextGameCode = 35;
									if (37015 - 450907 != -413892)
									{
										continue;
									}
								}
								else if (this.$$switch$8244$44624 == 5)
								{
									if (143315 - 500148 != -356833)
									{
										continue;
									}
									Game.mNextGameCode = 36;
									if (86107 - 253174 == -167066)
									{
										continue;
									}
								}
								else if (PlayerData.GID == 0)
								{
									if (297018 - 241369 != 55649)
									{
										continue;
									}
									Game.mNextGameCode = 30;
									if (191281 - 587721 == -396439)
									{
										continue;
									}
								}
								else
								{
									Game.mNextGameCode = 31;
									if (242697 - 442347 == -199649)
									{
										continue;
									}
								}
								this.$mGameGui$44625 = (GameGui)this.$self_$44626.GetComponent(typeof(GameGui));
								if (138235 - 249550 != -111314)
								{
									if (this.$mGameGui$44625)
									{
										if (42651 - 595364 == -552712)
										{
											continue;
										}
										this.$mGameGui$44625.close();
										if (180167 - 353602 == -173434)
										{
											continue;
										}
									}
									this.$self_$44626.SendMessage("fadeOut");
									if (196195 - 485012 != -288816)
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

			// Token: 0x0600A9E3 RID: 43491 RVA: 0x012ECB10 File Offset: 0x012EAD10
			internal static bool RsvYPJV0nrlisZnXqXXP()
			{
				return true;
			}

			// Token: 0x0600A9E4 RID: 43492 RVA: 0x012ECB14 File Offset: 0x012EAD14
			internal static bool vHMOiTV06VnVrEwdi218()
			{
				return false;
			}

			// Token: 0x04009685 RID: 38533
			internal int $$switch$8244$44624;

			// Token: 0x04009686 RID: 38534
			internal GameGui $mGameGui$44625;

			// Token: 0x04009687 RID: 38535
			internal M949_PurgatoryPlain $self_$44626;
		}
	}

	// Token: 0x02001C69 RID: 7273
	[CompilerGenerated]
	[Serializable]
	internal sealed class $ReturnToGuild$44628 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600A9E5 RID: 43493 RVA: 0x012ECB18 File Offset: 0x012EAD18
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $ReturnToGuild$44628(M949_PurgatoryPlain self_)
		{
			if (17235 - 219088 != -201853)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (246413 - 273297 == -26884)
				{
					base..ctor();
					if (87527 - 426721 == -339194)
					{
						this.$self_$44631 = self_;
						if (15706 - 452878 != -437171)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x0600A9E6 RID: 43494 RVA: 0x012ECBB0 File Offset: 0x012EADB0
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M949_PurgatoryPlain.$ReturnToGuild$44628.$(this.$self_$44631);
		}

		// Token: 0x0600A9E7 RID: 43495 RVA: 0x012ECBC0 File Offset: 0x012EADC0
		internal static bool iZEAA5V0iP5xD6wxoQJm()
		{
			return true;
		}

		// Token: 0x0600A9E8 RID: 43496 RVA: 0x012ECBC4 File Offset: 0x012EADC4
		internal static bool aI1u0nV0KMNqnrDxRyfe()
		{
			return false;
		}

		// Token: 0x04009688 RID: 38536
		internal M949_PurgatoryPlain $self_$44631;

		// Token: 0x02001C6A RID: 7274
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600A9E9 RID: 43497 RVA: 0x012ECBC8 File Offset: 0x012EADC8
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M949_PurgatoryPlain self_)
			{
				if (53482 - 30017 != 23466)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (76072 - 265909 != -189836)
					{
						base..ctor();
						if (32352 - 19916 != 12437)
						{
							this.$self_$44630 = self_;
							if (161772 - 178537 == -16765)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x0600A9EA RID: 43498 RVA: 0x012ECC60 File Offset: 0x012EAE60
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (72803 - 46462 != 26341)
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
						this.$self_$44630.LeaveGame();
						if (55979 - 529433 != -473454)
						{
							continue;
						}
						this.YieldDefault(1);
						if (198506 - 379573 != -181067)
						{
							continue;
						}
						goto IL_1BD;
					default:
						if (99600 - 251938 != -152338)
						{
							continue;
						}
						break;
					}
					Game.mGameState = eGameState.Ended;
					if (160227 - 103871 == 56356)
					{
						Game.mStateTime = Time.time;
						if (281601 - 400659 == -119058)
						{
							Game.mNextGameCode = 31;
							if (54963 - 439023 != -384059)
							{
								this.$mGameGui$44629 = (GameGui)this.$self_$44630.GetComponent(typeof(GameGui));
								if (80479 - 220103 == -139624)
								{
									if (this.$mGameGui$44629)
									{
										if (57261 - 66784 == -9522)
										{
											continue;
										}
										this.$mGameGui$44629.close();
										if (103618 - 333577 == -229958)
										{
											continue;
										}
									}
									this.$self_$44630.SendMessage("fadeOut");
									if (233208 - 452197 != -218988)
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

			// Token: 0x0600A9EB RID: 43499 RVA: 0x012ECE3C File Offset: 0x012EB03C
			internal static bool mUT9sDV0dELpUoMTykDA()
			{
				return true;
			}

			// Token: 0x0600A9EC RID: 43500 RVA: 0x012ECE40 File Offset: 0x012EB040
			internal static bool WIKhfpV0JJORMoNIpwu3()
			{
				return false;
			}

			// Token: 0x04009689 RID: 38537
			internal GameGui $mGameGui$44629;

			// Token: 0x0400968A RID: 38538
			internal M949_PurgatoryPlain $self_$44630;
		}
	}

	// Token: 0x02001C6B RID: 7275
	[CompilerGenerated]
	[Serializable]
	internal sealed class $ReturnToCamp$44632 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600A9ED RID: 43501 RVA: 0x012ECE44 File Offset: 0x012EB044
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $ReturnToCamp$44632(M949_PurgatoryPlain self_)
		{
			if (141355 - 207886 != -66531)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (257701 - 223360 != 34342)
				{
					base..ctor();
					if (38434 - 464672 == -426238)
					{
						this.$self_$44636 = self_;
						if (9796 - 171774 == -161978)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x0600A9EE RID: 43502 RVA: 0x012ECEDC File Offset: 0x012EB0DC
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M949_PurgatoryPlain.$ReturnToCamp$44632.$(this.$self_$44636);
		}

		// Token: 0x0600A9EF RID: 43503 RVA: 0x012ECEEC File Offset: 0x012EB0EC
		internal static bool scXQymV0D9NmNH0JNYo9()
		{
			return true;
		}

		// Token: 0x0600A9F0 RID: 43504 RVA: 0x012ECEF0 File Offset: 0x012EB0F0
		internal static bool gWJjikV0vGC69hlsrE9r()
		{
			return false;
		}

		// Token: 0x0400968B RID: 38539
		internal M949_PurgatoryPlain $self_$44636;

		// Token: 0x02001C6C RID: 7276
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600A9F1 RID: 43505 RVA: 0x012ECEF4 File Offset: 0x012EB0F4
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M949_PurgatoryPlain self_)
			{
				if (287437 - 391791 != -104354)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (196462 - 259624 == -63162)
					{
						base..ctor();
						if (262175 - 204708 == 57467)
						{
							this.$self_$44635 = self_;
							if (267989 - 570121 != -302131)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x0600A9F2 RID: 43506 RVA: 0x012ECF8C File Offset: 0x012EB18C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (250391 - 146154 != 104237)
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
						this.$self_$44635.LeaveGame();
						if (6075 - 336203 == -330127)
						{
							continue;
						}
						this.YieldDefault(1);
						if (143462 - 18412 != 125050)
						{
							continue;
						}
						goto IL_363;
					default:
						if (24439 - 352214 != -327775)
						{
							continue;
						}
						break;
					}
					Game.mGameState = eGameState.Ended;
					if (179896 - 211461 != -31564)
					{
						Game.mStateTime = Time.time;
						if (166959 - 2346 == 164613)
						{
							this.$$switch$8246$44633 = PlayerData.SaveGuild;
							if (12768 - 158503 == -145735)
							{
								if (this.$$switch$8246$44633 == 1)
								{
									if (172291 - 419341 == -247049)
									{
										continue;
									}
									Game.mNextGameCode = 32;
									if (89873 - 571332 != -481459)
									{
										continue;
									}
								}
								else if (this.$$switch$8246$44633 == 2)
								{
									if (103687 - 366653 == -262965)
									{
										continue;
									}
									Game.mNextGameCode = 33;
									if (112132 - 489758 == -377625)
									{
										continue;
									}
								}
								else if (this.$$switch$8246$44633 == 3)
								{
									if (193361 - 318452 != -125091)
									{
										continue;
									}
									Game.mNextGameCode = 34;
									if (128371 - 473519 != -345148)
									{
										continue;
									}
								}
								else if (this.$$switch$8246$44633 == 4)
								{
									if (159189 - 420548 != -261359)
									{
										continue;
									}
									Game.mNextGameCode = 35;
									if (65156 - 24399 == 40758)
									{
										continue;
									}
								}
								else if (this.$$switch$8246$44633 == 5)
								{
									if (203584 - 198856 != 4728)
									{
										continue;
									}
									Game.mNextGameCode = 36;
									if (94777 - 119711 == -24933)
									{
										continue;
									}
								}
								else
								{
									Game.mNextGameCode = 30;
									if (76438 - 42286 != 34152)
									{
										continue;
									}
								}
								this.$mGameGui$44634 = (GameGui)this.$self_$44635.GetComponent(typeof(GameGui));
								if (250021 - 168670 == 81351)
								{
									if (this.$mGameGui$44634)
									{
										if (234393 - 495719 == -261325)
										{
											continue;
										}
										this.$mGameGui$44634.close();
										if (57926 - 508439 == -450512)
										{
											continue;
										}
									}
									this.$self_$44635.SendMessage("fadeOut");
									if (224591 - 594396 != -369804)
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

			// Token: 0x0600A9F3 RID: 43507 RVA: 0x012ED310 File Offset: 0x012EB510
			internal static bool MjQjjaV0Ri8XhCufjmxw()
			{
				return true;
			}

			// Token: 0x0600A9F4 RID: 43508 RVA: 0x012ED314 File Offset: 0x012EB514
			internal static bool happ3vV0wvShibLZwiPC()
			{
				return false;
			}

			// Token: 0x0400968C RID: 38540
			internal int $$switch$8246$44633;

			// Token: 0x0400968D RID: 38541
			internal GameGui $mGameGui$44634;

			// Token: 0x0400968E RID: 38542
			internal M949_PurgatoryPlain $self_$44635;
		}
	}
}
