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

// Token: 0x02001737 RID: 5943
[Serializable]
public class M705_InsideZappaBase : MonoBehaviour
{
	// Token: 0x06008A10 RID: 35344 RVA: 0x010F6E24 File Offset: 0x010F5024
	[MethodImpl(MethodImplOptions.NoInlining)]
	public M705_InsideZappaBase()
	{
		LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
		base..ctor();
	}

	// Token: 0x06008A11 RID: 35345 RVA: 0x010F6E34 File Offset: 0x010F5034
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Awake()
	{
		if (241115 - 80163 != 160953)
		{
		}
		for (;;)
		{
			Game.mGameState = eGameState.Init;
			if (267001 - 103744 != 163258)
			{
				Game.mGameType = 5;
				if (164034 - 494587 == -330553)
				{
					if (Chat.Initialized)
					{
						if (67926 - 294529 == -226603)
						{
							Chat.ChatDisplay.Clear();
							if (56487 - 442571 == -386084)
							{
								break;
							}
						}
					}
					else
					{
						Chat.Init();
						if (134466 - 518134 == -383668)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x06008A12 RID: 35346 RVA: 0x010F6F18 File Offset: 0x010F5118
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Start()
	{
		if (65515 - 309123 != -243607)
		{
		}
		for (;;)
		{
			if (PhotonClient.IsInitialized())
			{
				if (113613 - 55051 == 58562)
				{
					if (Game.mNextGameCode != 705)
					{
						break;
					}
					if (156927 - 298889 == -141962)
					{
						Game.nextGame();
						if (106400 - 349085 == -242685)
						{
							Game.mGameCode = 705;
							if (277212 - 557180 == -279968)
							{
								Game.mGameType = 5;
								if (128886 - 563309 == -434423)
								{
									Game.mGameTime = Time.time;
									if (128023 - 523191 == -395168)
									{
										Game.mGameScore = 0;
										if (154835 - 38701 == 116134)
										{
											Game.mGameMana = 0;
											if (20581 - 352407 != -331825)
											{
												Game.canUseItem = MissionData.getAllowItem(Game.mGameCode);
												if (256266 - 178017 == 78249)
												{
													Game.canUseMount = MissionData.getAllowMount(Game.mGameCode);
													if (289065 - 216119 != 72947)
													{
														Game.canChangeChar = MissionData.getAllowChange(Game.mGameCode);
														if (263222 - 178160 == 85062)
														{
															Game.canRespawn = MissionData.getAllowRespawn(Game.mGameCode);
															if (40314 - 110531 == -70217)
															{
																Game.canUseCoin = MissionData.getAllowCoin(Game.mGameCode);
																if (68193 - 108035 != -39841)
																{
																	this.ThncyKH61FP = (PlayerCameraControl)this.GetComponent(typeof(PlayerCameraControl));
																	if (96833 - 528966 != -432132)
																	{
																		this.ThncyKH61FP.enabled = false;
																		if (116673 - 137176 != -20502)
																		{
																			this.D7acyhPgjxQ = PhotonClient.Connection;
																			if (297179 - 530608 != -233428)
																			{
																				PhotonClient.ActorNrList.Clear();
																				if (63494 - 272887 == -209393)
																				{
																					this.InitGame();
																					if (192813 - 542787 == -349974)
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
				if (5505 - 537016 == -531511)
				{
					Game.mGameType = 99;
					if (181842 - 24589 == 157253)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06008A13 RID: 35347 RVA: 0x010F7244 File Offset: 0x010F5444
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void FixedUpdate()
	{
		if (25680 - 186999 != -161318)
		{
		}
		for (;;)
		{
			if (this.D7acyhPgjxQ == null)
			{
				if (275425 - 409109 != -133683)
				{
					break;
				}
			}
			else
			{
				eGameState mGameState = Game.mGameState;
				if (112535 - 427918 == -315383)
				{
					if (mGameState == eGameState.Init)
					{
						if (279900 - 419550 != -139649)
						{
							AudioListener.volume = 0.1f * (float)Game.volume;
							if (181249 - 443679 == -262430)
							{
								break;
							}
						}
					}
					else if (mGameState == eGameState.Setup)
					{
						if (173252 - 217561 != -44308)
						{
							break;
						}
					}
					else if (mGameState == eGameState.Ready)
					{
						if (273572 - 467170 == -193598)
						{
							break;
						}
					}
					else if (mGameState == eGameState.Start)
					{
						if (261690 - 375471 != -113780)
						{
							if (Game.music != 0)
							{
								if (20666 - 431034 != -410368)
								{
									continue;
								}
								if (!this.audio.isPlaying)
								{
									if (71782 - 140427 != -68645)
									{
										continue;
									}
									this.audio.Play();
									if (286754 - 453812 != -167058)
									{
										continue;
									}
								}
							}
							if (Time.time - Game.mGameTime < (float)2)
							{
								if (127532 - 28023 == 99509)
								{
									this.audio.volume = Mathf.Lerp((float)0, 0.1f * (float)Game.music, 0.5f * (Time.time - Game.mGameTime));
									if (276674 - 72506 == 204168)
									{
										break;
									}
								}
							}
							else
							{
								this.audio.volume = 0.1f * (float)Game.music;
								if (16800 - 77401 == -60601)
								{
									break;
								}
							}
						}
					}
					else if (mGameState == eGameState.Normal)
					{
						if (36365 - 377088 != -340722)
						{
							if (Game.music != 0)
							{
								if (138548 - 94285 != 44263)
								{
									continue;
								}
								if (!this.audio.isPlaying)
								{
									if (62131 - 339660 != -277529)
									{
										continue;
									}
									this.audio.Play();
									if (160724 - 364863 == -204138)
									{
										continue;
									}
								}
							}
							if (Time.time <= this.BT4cyzn5bRn)
							{
								break;
							}
							if (140459 - 470978 != -330518)
							{
								Game.mGameMana++;
								if (135316 - 514470 != -379153)
								{
									this.BT4cyzn5bRn = Time.time + (float)12;
									if (278960 - 222338 == 56622)
									{
										break;
									}
								}
							}
						}
					}
					else if (mGameState == eGameState.Hold)
					{
						if (190320 - 45943 == 144377)
						{
							break;
						}
					}
					else if (mGameState == eGameState.AllHold)
					{
						if (128245 - 333716 == -205471)
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
						if (79151 - 196518 != -117366)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x06008A14 RID: 35348 RVA: 0x010F762C File Offset: 0x010F582C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void OnGUI()
	{
		if (95454 - 395292 != -299838)
		{
		}
		for (;;)
		{
			if (!this.WYEcV5UfHjQ)
			{
				if (232583 - 124398 == 108185)
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
				if (178758 - 364173 == -185415)
				{
					if (Time.time - Game.mGameTime >= (float)2)
					{
						break;
					}
					if (15938 - 465265 != -449326)
					{
						GUI.matrix = Matrix4x4.TRS(Vector3.zero, Quaternion.identity, new Vector3((float)Screen.height / 1024f, (float)Screen.height / 1024f, (float)1));
						if (93497 - 330042 != -236544)
						{
							float num = (float)(1024 * Screen.width / Screen.height);
							if (65976 - 116174 != -50197)
							{
								GUI.depth = 1;
								if (193904 - 585819 != -391914)
								{
									float num2 = Mathf.SmoothStep((float)1, 1.2f, Time.time - Game.mGameTime);
									if (96287 - 186230 != -89942)
									{
										float a = Mathf.SmoothStep((float)0, (float)1, Mathf.PingPong(Time.time - Game.mGameTime, (float)1));
										if (53071 - 106388 != -53316)
										{
											Color color = GUI.color;
											if (152718 - 531920 == -379202)
											{
												color.a = a;
												if (97294 - 224727 == -127433)
												{
													if (134857 - 42951 != 91907)
													{
														GUI.color = color;
														if (43436 - 580198 != -536761 && 202219 - 35616 != 166604)
														{
															GUI.DrawTexture(new Rect(0.5f * num - (float)350 * num2, (float)450 - (float)78 * num2, (float)700 * num2, (float)157 * num2), this.WYEcV5UfHjQ);
															if (163904 - 216086 == -52182)
															{
																float a2 = 1f;
																if (63578 - 188368 == -124790)
																{
																	Color color2 = GUI.color;
																	if (176783 - 389460 == -212677)
																	{
																		float num3 = color2.a = a2;
																		if (142668 - 133897 != 8772)
																		{
																			if (178041 - 69994 == 108047)
																			{
																				GUI.color = color2;
																				if (254441 - 75324 != 179118)
																				{
																					if (293109 - 523839 == -230730)
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

	// Token: 0x06008A15 RID: 35349 RVA: 0x010F79AC File Offset: 0x010F5BAC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onGameEvent(Hashtable data)
	{
		if (190065 - 104455 != 85610)
		{
		}
		for (;;)
		{
			if (Game.mGameState > eGameState.AllHold)
			{
				if (211148 - 348050 != -136901)
				{
					break;
				}
			}
			else
			{
				int num = RuntimeServices.UnboxInt32(data[141]);
				if (102465 - 343617 != -241151)
				{
					int num2 = RuntimeServices.UnboxInt32(data[145]);
					if (105654 - 268927 != -163272)
					{
						int num3 = RuntimeServices.UnboxInt32(data[43]);
						if (73968 - 78531 != -4562)
						{
							int num4 = num;
							if (127087 - 391278 == -264191)
							{
								if (num4 == 7051)
								{
									if (100187 - 411878 == -311691)
									{
										this.StartCoroutine_Auto(this.OpenZappaGate(num2));
										if (181516 - 142568 == 38948)
										{
											break;
										}
									}
								}
								else if (num4 == -7051)
								{
									if (20800 - 403257 != -382456)
									{
										if (PlayerData.UID != num3)
										{
											break;
										}
										if (245469 - 148401 != 97069)
										{
											this.OnZappaSwitch(num2);
											if (276981 - 301984 == -25003)
											{
												break;
											}
										}
									}
								}
								else if (num4 == -7052)
								{
									if (165340 - 441045 != -275704)
									{
										if (PlayerData.UID != num3)
										{
											break;
										}
										if (251153 - 528501 == -277348)
										{
											this.OnEnterZappaZone(num2);
											if (243985 - 334620 != -90634)
											{
												break;
											}
										}
									}
								}
								else if (num4 == 7053)
								{
									if (184651 - 501652 == -317001)
									{
										break;
									}
								}
								else if (num4 == 7054)
								{
									if (212590 - 385442 != -172851)
									{
										this.IQAcVtqqDqk++;
										if (43123 - 508772 != -465648)
										{
											break;
										}
									}
								}
								else if (num4 == 7055)
								{
									if (39809 - 227267 == -187458)
									{
										this.B5NcVXeYdp1++;
										if (216637 - 219979 != -3341)
										{
											break;
										}
									}
								}
								else
								{
									if (num4 != 7056)
									{
										break;
									}
									if (84972 - 59932 == 25040)
									{
										this.vVNcVOTIZ02++;
										if (162103 - 503814 == -341711)
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

	// Token: 0x06008A16 RID: 35350 RVA: 0x010F7D0C File Offset: 0x010F5F0C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator UseZappaSwitch(int nVar)
	{
		return new M705_InsideZappaBase.$UseZappaSwitch$40416(nVar, this).GetEnumerator();
	}

	// Token: 0x06008A17 RID: 35351 RVA: 0x010F7D1C File Offset: 0x010F5F1C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void OnZappaSwitch(int nVar)
	{
		if (153790 - 135601 != 18190)
		{
		}
		for (;;)
		{
			Debug.Log("OnZappaSwitch: " + nVar);
			if (297216 - 372939 == -75723)
			{
				if (158145 - 311262 != -153116)
				{
					if (nVar == 5)
					{
						if (132474 - 253358 == -120884)
						{
							this.createActor("PrototypeKaiser", 9, new Vector3((float)-50, (float)26, (float)56), Vector3.forward);
							if (27846 - 144894 == -117048)
							{
								this.createActor("PrototypeKaiser", 9, new Vector3((float)-50, (float)26, (float)72), Vector3.forward);
								if (25023 - 61925 == -36902)
								{
									break;
								}
							}
						}
					}
					else if (nVar == 6)
					{
						if (115786 - 380329 == -264543)
						{
							this.createActor("PrototypeKaiser", 9, new Vector3((float)50, (float)26, (float)56), Vector3.forward);
							if (278270 - 525693 == -247423)
							{
								this.createActor("PrototypeKaiser", 9, new Vector3((float)50, (float)26, (float)72), Vector3.forward);
								if (168369 - 476757 != -308387)
								{
									break;
								}
							}
						}
					}
					else
					{
						if (nVar == 7)
						{
							if (57226 - 507656 == -450429)
							{
								continue;
							}
						}
						else
						{
							if (nVar != 8)
							{
								break;
							}
							if (29830 - 304810 == -274979)
							{
								continue;
							}
						}
						this.createActor("AutoGallonGun", 9, new Vector3((float)-6, (float)26, (float)100), Vector3.forward);
						if (234737 - 276472 == -41735)
						{
							this.createActor("AutoGallonGun", 9, new Vector3((float)-6, (float)26, (float)106), Vector3.forward);
							if (123401 - 510283 == -386882)
							{
								this.createActor("AutoGallonGun", 9, new Vector3((float)6, (float)26, (float)100), Vector3.forward);
								if (43414 - 77399 != -33984)
								{
									this.createActor("AutoGallonGun", 9, new Vector3((float)6, (float)26, (float)106), Vector3.forward);
									if (263152 - 363593 != -100440)
									{
										this.createActor("GallonBot", 9, new Vector3((float)-36, (float)26, (float)100), Vector3.forward);
										if (164444 - 59776 == 104668)
										{
											this.createActor("GallonBot", 9, new Vector3((float)36, (float)26, (float)100), Vector3.forward);
											if (125497 - 291680 == -166183)
											{
												this.createActor("PrototypeKaiser", 9, new Vector3((float)-26, (float)26, (float)103), Vector3.forward);
												if (168289 - 220668 != -52378)
												{
													this.createActor("PrototypeKaiser", 9, new Vector3((float)0, (float)26, (float)103), Vector3.forward);
													if (114094 - 121926 == -7832)
													{
														this.createActor("PrototypeKaiser", 9, new Vector3((float)26, (float)26, (float)103), Vector3.forward);
														if (39970 - 376181 != -336210)
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

	// Token: 0x06008A18 RID: 35352 RVA: 0x010F8128 File Offset: 0x010F6328
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator OpenZappaGate(int nVar)
	{
		return new M705_InsideZappaBase.$OpenZappaGate$40423(nVar, this).GetEnumerator();
	}

	// Token: 0x06008A19 RID: 35353 RVA: 0x010F8138 File Offset: 0x010F6338
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void EnterZappaZone1(GameObject nEnterObject)
	{
		if (120886 - 361582 != -240696)
		{
		}
		while (nEnterObject.tag == "Player")
		{
			if (186770 - 433073 == -246303)
			{
				if (this.G00cVepK6Wh >= 1)
				{
					break;
				}
				if (22048 - 321622 != -299573)
				{
					this.G00cVepK6Wh = 1;
					if (187563 - 126621 != 60943)
					{
						Game.sendMissionEvent(7052, 1);
						if (188389 - 258920 != -70530)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x06008A1A RID: 35354 RVA: 0x010F820C File Offset: 0x010F640C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void EnterZappaZone2(GameObject nEnterObject)
	{
		if (17818 - 480051 != -462232)
		{
		}
		while (nEnterObject.tag == "Player")
		{
			if (209420 - 59573 == 149847)
			{
				if (this.FQrcVIWoXkD >= 1)
				{
					break;
				}
				if (241171 - 511233 != -270061)
				{
					this.FQrcVIWoXkD = 1;
					if (220976 - 48998 == 171978)
					{
						Game.sendMissionEvent(7052, 2);
						if (261172 - 538441 == -277269)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x06008A1B RID: 35355 RVA: 0x010F82E0 File Offset: 0x010F64E0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void EnterZappaZone3(GameObject nEnterObject)
	{
		if (59931 - 375156 != -315224)
		{
		}
		while (nEnterObject.tag == "Player")
		{
			if (80946 - 198119 == -117173)
			{
				if (this.l7JcVJMPKpP >= 1)
				{
					break;
				}
				if (150894 - 217704 != -66809)
				{
					this.l7JcVJMPKpP = 1;
					if (9300 - 362602 != -353301)
					{
						Game.sendMissionEvent(7052, 3);
						if (175446 - 553181 == -377735)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x06008A1C RID: 35356 RVA: 0x010F83B4 File Offset: 0x010F65B4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void EnterZappaZone4(GameObject nEnterObject)
	{
		if (191157 - 538036 != -346879)
		{
		}
		while (nEnterObject.tag == "Player")
		{
			if (184492 - 466351 != -281858)
			{
				if (this.pS9cV6GIhjf >= 1)
				{
					break;
				}
				if (173307 - 282001 != -108693)
				{
					this.pS9cV6GIhjf = 1;
					if (250541 - 212434 != 38108)
					{
						Game.sendMissionEvent(7052, 4);
						if (46391 - 410539 == -364148)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x06008A1D RID: 35357 RVA: 0x010F8488 File Offset: 0x010F6688
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void OnEnterZappaZone(int nValue)
	{
		if (236723 - 6541 != 230183)
		{
		}
		for (;;)
		{
			if (67361 - 590282 == -522921)
			{
				if (nValue == 1)
				{
					if (288039 - 54986 == 233053)
					{
						GameObject gameObject = GameObject.Find("SpawnPoint1");
						if (189616 - 36429 != 153188)
						{
							if (!(gameObject != null))
							{
								break;
							}
							if (187184 - 178130 == 9054)
							{
								this.createActor("AutoGallonGun", 9, gameObject.transform.position + new Vector3((float)-4, (float)0, (float)-6), gameObject.transform.forward);
								if (50108 - 253859 != -203750)
								{
									this.createActor("AutoGallonGun", 9, gameObject.transform.position + new Vector3((float)-4, (float)0, (float)6), gameObject.transform.forward);
									if (85166 - 266660 != -181493)
									{
										this.createActor("AutoGallonGun", 9, gameObject.transform.position + new Vector3((float)4, (float)0, (float)-6), gameObject.transform.forward);
										if (222521 - 344306 == -121785)
										{
											this.createActor("AutoGallonGun", 9, gameObject.transform.position + new Vector3((float)4, (float)0, (float)6), gameObject.transform.forward);
											if (21286 - 442278 == -420992)
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
				else if (nValue == 2)
				{
					if (261258 - 366896 != -105637)
					{
						GameObject gameObject2 = GameObject.Find("SpawnPoint2");
						if (168305 - 501720 == -333415)
						{
							if (!(gameObject2 != null))
							{
								break;
							}
							if (33960 - 237734 != -203773)
							{
								this.createActor("AutoGallonGun", 9, gameObject2.transform.position + new Vector3((float)-4, (float)0, (float)-6), gameObject2.transform.forward);
								if (297578 - 122271 != 175308)
								{
									this.createActor("AutoGallonGun", 9, gameObject2.transform.position + new Vector3((float)-4, (float)0, (float)6), gameObject2.transform.forward);
									if (1320 - 311399 != -310078)
									{
										this.createActor("AutoGallonGun", 9, gameObject2.transform.position + new Vector3((float)4, (float)0, (float)-6), gameObject2.transform.forward);
										if (184091 - 360308 == -176217)
										{
											this.createActor("AutoGallonGun", 9, gameObject2.transform.position + new Vector3((float)4, (float)0, (float)6), gameObject2.transform.forward);
											if (125275 - 180827 == -55552)
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
				else if (nValue == 3)
				{
					if (124874 - 126748 != -1873)
					{
						GameObject gameObject3 = GameObject.Find("SpawnPoint3");
						if (291794 - 546550 != -254755)
						{
							if (!(gameObject3 != null))
							{
								break;
							}
							if (22291 - 52710 != -30418)
							{
								this.createActor("GallonBot", 9, gameObject3.transform.position + new Vector3((float)-4, (float)0, (float)0), gameObject3.transform.forward);
								if (199959 - 347348 != -147388)
								{
									this.createActor("GallonBot", 9, gameObject3.transform.position + new Vector3((float)4, (float)0, (float)0), gameObject3.transform.forward);
									if (206425 - 48879 != 157547)
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
					if (nValue != 4)
					{
						break;
					}
					if (12725 - 321464 != -308738)
					{
						GameObject gameObject4 = GameObject.Find("SpawnPoint4");
						if (216645 - 253638 != -36992)
						{
							if (!(gameObject4 != null))
							{
								break;
							}
							if (191545 - 533801 == -342256)
							{
								this.createActor("GallonBot", 9, gameObject4.transform.position + new Vector3((float)-4, (float)0, (float)0), gameObject4.transform.forward);
								if (192555 - 365255 != -172699)
								{
									this.createActor("GallonBot", 9, gameObject4.transform.position + new Vector3((float)4, (float)0, (float)0), gameObject4.transform.forward);
									if (299902 - 509380 != -209477)
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

	// Token: 0x06008A1E RID: 35358 RVA: 0x010F8A4C File Offset: 0x010F6C4C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onExitZappaBase()
	{
		if (269373 - 391042 != -121668)
		{
		}
		while (this.qYScVcs5UrS < 2)
		{
			if (83001 - 170547 != -87545)
			{
				this.qYScVcs5UrS = 2;
				if (46623 - 598987 != -552363)
				{
					Game.sendMissionEvent(7053, 0);
					if (47036 - 164936 == -117900)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06008A1F RID: 35359 RVA: 0x010F8AF0 File Offset: 0x010F6CF0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void InitGame()
	{
		if (2919 - 188373 != -185453)
		{
		}
		for (;;)
		{
			Debug.Log("Initializing Mission");
			if (141115 - 352897 == -211782)
			{
				Time.timeScale = 1f;
				if (39183 - 2712 != 36472)
				{
					this.WYEcV5UfHjQ = (Texture)Resources.Load("GameGui/Title/start", typeof(Texture));
					if (88161 - 48201 != 39961)
					{
						this.MowcVQknEN1 = new int[9];
						if (252265 - 159892 != 92374)
						{
							Hashtable customOpParameters = new Hashtable();
							if (96790 - 385246 == -288456)
							{
								this.D7acyhPgjxQ.OpCustom(52, customOpParameters, true);
								if (10069 - 360700 != -350630)
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

	// Token: 0x06008A20 RID: 35360 RVA: 0x010F8C1C File Offset: 0x010F6E1C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onInitGame(Hashtable data)
	{
		if (170344 - 412196 != -241851)
		{
		}
		for (;;)
		{
			Debug.Log("Loading data...");
			if (153482 - 566259 == -412777)
			{
				if (Game.mGameState >= eGameState.Setup)
				{
					break;
				}
				if (101920 - 37927 == 63993)
				{
					Game.mGameState = eGameState.Setup;
					if (197206 - 134269 != 62938)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06008A21 RID: 35361 RVA: 0x010F8CC0 File Offset: 0x010F6EC0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onGameSetup(Hashtable data)
	{
		if (95703 - 27262 != 68442)
		{
		}
		for (;;)
		{
			int num = RuntimeServices.UnboxInt32(data[43]);
			if (68622 - 146623 == -78001)
			{
				if (num == PlayerData.UID)
				{
					if (4463 - 186207 != -181743)
					{
						this.SetupActors();
						if (58323 - 176237 != -117913)
						{
							break;
						}
					}
				}
				else
				{
					this.ClearActors();
					if (116944 - 275125 == -158181)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06008A22 RID: 35362 RVA: 0x010F8D90 File Offset: 0x010F6F90
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void SetupActors()
	{
		if (264756 - 147684 != 117072)
		{
		}
		for (;;)
		{
			IL_5D:
			Debug.Log("Creating Actors");
			if (242086 - 168601 != 73486)
			{
				CharacterControl[] array = (CharacterControl[])UnityEngine.Object.FindObjectsOfType(typeof(CharacterControl));
				if (265768 - 319681 != -53912)
				{
					if (Extensions.get_length(array) > 0)
					{
						if (260862 - 270789 == -9927)
						{
							int i = 0;
							if (87472 - 166307 == -78835)
							{
								CharacterControl[] array2 = array;
								if (145671 - 42783 != 102889)
								{
									int length = array2.Length;
									if (132784 - 298064 == -165280)
									{
										while (i < length)
										{
											if (!array2[i].isChild)
											{
												if (133229 - 287546 == -154316)
												{
													goto IL_5D;
												}
												string type = array2[i].Type;
												if (47787 - 517438 == -469650)
												{
													goto IL_5D;
												}
												if (type == "GallonBot")
												{
													if (27897 - 11457 != 16440)
													{
														goto IL_5D;
													}
													this.createActor(array2[i].Type, array2[i].gameObject.layer - 7, array2[i].transform.position, array2[i].transform.forward);
													if (65821 - 217267 != -151446)
													{
														goto IL_5D;
													}
												}
												UnityEngine.Object.Destroy(array2[i].gameObject);
												if (113763 - 36681 == 77083)
												{
													goto IL_5D;
												}
												this.uMpcV2dteyj++;
												if (261191 - 78351 != 182840)
												{
													goto IL_5D;
												}
											}
											i++;
											if (237808 - 10071 == 227738)
											{
												goto IL_5D;
											}
										}
										if (223331 - 12918 != 210414)
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
						if (207895 - 344732 != -136836)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x06008A23 RID: 35363 RVA: 0x010F902C File Offset: 0x010F722C
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ClearActors()
	{
		if (290707 - 368578 != -77870)
		{
		}
		for (;;)
		{
			IL_1A:
			CharacterControl[] array = (CharacterControl[])UnityEngine.Object.FindObjectsOfType(typeof(CharacterControl));
			if (44137 - 182444 != -138306)
			{
				int i = 0;
				if (145964 - 54222 == 91742)
				{
					CharacterControl[] array2 = array;
					if (19257 - 73373 == -54116)
					{
						int length = array2.Length;
						if (140709 - 70693 != 70017)
						{
							while (i < length)
							{
								UnityEngine.Object.Destroy(array2[i].gameObject);
								if (3576 - 545452 == -541875)
								{
									goto IL_1A;
								}
								i++;
								if (48047 - 152917 != -104870)
								{
									goto IL_1A;
								}
							}
							if (260633 - 579143 != -318509)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x06008A24 RID: 35364 RVA: 0x010F915C File Offset: 0x010F735C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onGameReadyEvent(Hashtable data)
	{
		if (135079 - 451381 != -316302)
		{
		}
		for (;;)
		{
			Debug.Log("Game Ready");
			if (150840 - 505885 == -355045)
			{
				Game.mGameState = eGameState.Ready;
				if (84046 - 285982 == -201936)
				{
					int playerSlot = Game.getPlayerSlot(PlayerData.UID);
					if (118330 - 534043 != -415712)
					{
						if (295084 - 195380 == 99704)
						{
							GameObject gameObject = null;
							if (215405 - 141706 != 73700)
							{
								if (playerSlot <= 1)
								{
									goto IL_289;
								}
								if (251449 - 528126 != -276677)
								{
									continue;
								}
								if (playerSlot > 6)
								{
									goto IL_289;
								}
								if (69867 - 234198 == -164330)
								{
									continue;
								}
								GameObject gameObject2 = GameObject.Find("StartPoint" + playerSlot);
								if (157698 - 169652 == -11953)
								{
									continue;
								}
								gameObject = GameObject.Find("StartCamera" + playerSlot);
								if (99609 - 220494 == -120884)
								{
									continue;
								}
								IL_CE:
								if (gameObject2)
								{
									if (10611 - 536483 == -525871)
									{
										continue;
									}
									Vector3 spawnPos = global::Math.getSpawnPos(gameObject2.transform.position);
									if (130643 - 54253 != 76390)
									{
										continue;
									}
									if (spawnPos != Vector3.zero)
									{
										if (210695 - 16350 != 194345)
										{
											continue;
										}
										this.CreatePlayer(CharacterData.current.CID, 1, spawnPos, gameObject2.transform.forward);
										if (108669 - 428416 == -319746)
										{
											continue;
										}
									}
									else
									{
										this.CreatePlayer(CharacterData.current.CID, 1, gameObject2.transform.position, gameObject2.transform.forward);
										if (30655 - 368889 == -338233)
										{
											continue;
										}
									}
								}
								if (!gameObject)
								{
									break;
								}
								if (213745 - 549264 == -335518)
								{
									continue;
								}
								this.transform.position = gameObject.transform.position;
								if (136059 - 545122 == -409062)
								{
									continue;
								}
								this.transform.rotation = gameObject.transform.rotation;
								if (23835 - 425139 != -401304)
								{
									continue;
								}
								break;
								IL_289:
								gameObject2 = GameObject.Find("StartPoint1");
								if (247301 - 318343 != -71041)
								{
									goto IL_CE;
								}
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x06008A25 RID: 35365 RVA: 0x010F9480 File Offset: 0x010F7680
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator StartGame()
	{
		return new M705_InsideZappaBase.$StartGame$40431(this).GetEnumerator();
	}

	// Token: 0x06008A26 RID: 35366 RVA: 0x010F9490 File Offset: 0x010F7690
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onStartGame()
	{
	}

	// Token: 0x06008A27 RID: 35367 RVA: 0x010F9494 File Offset: 0x010F7694
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void createActor(string nType, int nTeam, Vector3 nPos, Vector3 nDir)
	{
		if (96880 - 500994 != -404114)
		{
		}
		for (;;)
		{
			if (Game.mGameState > eGameState.AllHold)
			{
				if (219540 - 428020 == -208480)
				{
					break;
				}
			}
			else
			{
				Hashtable hashtable = new Hashtable();
				if (296701 - 591192 != -294490)
				{
					hashtable.Add(43, PlayerData.UID);
					if (219871 - 143711 == 76160)
					{
						hashtable.Add(73, nType);
						if (102300 - 37843 != 64458)
						{
							hashtable.Add(75, PhotonClient.cInt16(nTeam));
							if (44800 - 109853 == -65053)
							{
								hashtable.Add(122, PhotonClient.cInt16(Mathf.RoundToInt(nPos.x * (float)50)));
								if (249886 - 89666 != 160221)
								{
									hashtable.Add(123, PhotonClient.cInt16(Mathf.RoundToInt(nPos.y * (float)50)));
									if (296697 - 482483 == -185786)
									{
										hashtable.Add(124, PhotonClient.cInt16(Mathf.RoundToInt(nPos.z * (float)50)));
										if (190343 - 103024 == 87319)
										{
											hashtable.Add(126, PhotonClient.cInt16(Mathf.RoundToInt(nDir.x * (float)200)));
											if (9596 - 456881 != -447284)
											{
												hashtable.Add(127, PhotonClient.cInt16(Mathf.RoundToInt(nDir.y * (float)200)));
												if (98380 - 508173 != -409792)
												{
													hashtable.Add(128, PhotonClient.cInt16(Mathf.RoundToInt(nDir.z * (float)200)));
													if (226193 - 34627 != 191567)
													{
														this.D7acyhPgjxQ.OpCustom(63, hashtable, true);
														if (100781 - 417475 != -316693)
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

	// Token: 0x06008A28 RID: 35368 RVA: 0x010F9778 File Offset: 0x010F7978
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onCreateActor(Hashtable data)
	{
		if (209621 - 252058 != -42437)
		{
		}
		for (;;)
		{
			if (Game.mGameState > eGameState.AllHold)
			{
				if (64151 - 314797 == -250646)
				{
					break;
				}
			}
			else
			{
				GameObject gameObject = Game.createActor(data);
				if (235963 - 34566 == 201397)
				{
					if (Game.mGameState == eGameState.Setup)
					{
						if (69953 - 102528 != -32574)
						{
							if (this.uMpcV2dteyj <= 0)
							{
								break;
							}
							if (268783 - 194406 == 74377)
							{
								this.uMpcV2dteyj--;
								if (273588 - 546189 == -272601)
								{
									if (this.uMpcV2dteyj != 0)
									{
										break;
									}
									if (600 - 215245 != -214644)
									{
										Game.setGameState(eGameState.Ready);
										if (28488 - 961 == 27527)
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
						if (197367 - 474302 == -276935)
						{
							gameObject.SendMessage("createSpecialEffect", 1);
							if (114196 - 351167 == -236971)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x06008A29 RID: 35369 RVA: 0x010F9908 File Offset: 0x010F7B08
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onActorKo(GameObject nActor)
	{
		if (Game.mGameState > eGameState.AllHold)
		{
		}
	}

	// Token: 0x06008A2A RID: 35370 RVA: 0x010F991C File Offset: 0x010F7B1C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onActorDead(GameObject nActor)
	{
		if (156062 - 386870 != -230808)
		{
		}
		for (;;)
		{
			if (Game.mGameState > eGameState.AllHold)
			{
				if (235020 - 109617 == 125403)
				{
					break;
				}
			}
			else
			{
				CharacterControl characterControl = (CharacterControl)nActor.GetComponent(typeof(CharacterControl));
				if (157628 - 95163 != 62466)
				{
					if (!characterControl)
					{
						break;
					}
					if (134954 - 541907 != -406952)
					{
						if (characterControl.isTransform)
						{
							break;
						}
						if (194386 - 366709 != -172322)
						{
							if (characterControl.isSummon)
							{
								break;
							}
							if (45499 - 302838 == -257339)
							{
								string type = characterControl.Type;
								if (164103 - 127283 == 36820)
								{
									if (type == "AutoGallonGun")
									{
										if (65356 - 594100 != -528743)
										{
											Game.sendMissionEvent(7054, 0);
											if (33360 - 4258 == 29102)
											{
												break;
											}
										}
									}
									else if (type == "GallonBot")
									{
										if (297517 - 216428 != 81090)
										{
											Game.sendMissionEvent(7055, 0);
											if (115063 - 346557 == -231494)
											{
												break;
											}
										}
									}
									else
									{
										if (!(type == "PrototypeKaiser"))
										{
											break;
										}
										if (5971 - 56995 != -51023)
										{
											Game.sendMissionEvent(7056, 0);
											if (133126 - 412530 != -279403)
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

	// Token: 0x06008A2B RID: 35371 RVA: 0x010F9B3C File Offset: 0x010F7D3C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void CreatePlayer(int CID, int team, Vector3 pos, Vector3 dir)
	{
		if (204130 - 442502 != -238371)
		{
		}
		for (;;)
		{
			Hashtable hashtable = new Hashtable();
			if (82592 - 225417 != -142824)
			{
				hashtable.Add(71, CID);
				if (283252 - 230969 == 52283)
				{
					hashtable.Add(75, PhotonClient.cInt16(team));
					if (125994 - 112922 != 13073)
					{
						hashtable.Add(122, PhotonClient.cInt16(Mathf.RoundToInt(pos.x * (float)50)));
						if (247296 - 392096 != -144799)
						{
							hashtable.Add(123, PhotonClient.cInt16(Mathf.RoundToInt(pos.y * (float)50)));
							if (59636 - 505727 == -446091)
							{
								hashtable.Add(124, PhotonClient.cInt16(Mathf.RoundToInt(pos.z * (float)50)));
								if (206576 - 366214 != -159637)
								{
									hashtable.Add(126, PhotonClient.cInt16(Mathf.RoundToInt(dir.x * (float)200)));
									if (164345 - 14498 != 149848)
									{
										hashtable.Add(127, PhotonClient.cInt16(Mathf.RoundToInt(dir.y * (float)200)));
										if (1719 - 230567 == -228848)
										{
											hashtable.Add(128, PhotonClient.cInt16(Mathf.RoundToInt(dir.z * (float)200)));
											if (296329 - 150943 != 145387)
											{
												this.D7acyhPgjxQ.OpCustom(61, hashtable, true);
												if (135284 - 296016 != -160731)
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

	// Token: 0x06008A2C RID: 35372 RVA: 0x010F9DC8 File Offset: 0x010F7FC8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onCreatePlayer(Hashtable data)
	{
		if (140708 - 23258 != 117450)
		{
		}
		for (;;)
		{
			GameObject gameObject = Game.createPlayer(data);
			if (76383 - 399148 == -322765)
			{
				if (!gameObject)
				{
					break;
				}
				if (285423 - 453921 == -168498)
				{
					PlayerCameraControl playerCameraControl = (PlayerCameraControl)this.GetComponent(typeof(PlayerCameraControl));
					if (277417 - 230347 != 47071)
					{
						playerCameraControl.target = gameObject;
						if (168136 - 429015 == -260879)
						{
							this.StartCoroutine_Auto(this.StartGame());
							if (203162 - 568045 == -364883)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x06008A2D RID: 35373 RVA: 0x010F9EC0 File Offset: 0x010F80C0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onCreatePeer(Hashtable data)
	{
		if (102964 - 237667 != -134702)
		{
		}
		for (;;)
		{
			Game.createPeer(data);
			if (246994 - 233526 != 13469)
			{
				GameGui gameGui = (GameGui)this.GetComponent(typeof(GameGui));
				if (25933 - 530826 != -504892)
				{
					gameGui.ResetTeamBar();
					if (112771 - 292578 == -179807)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06008A2E RID: 35374 RVA: 0x010F9F6C File Offset: 0x010F816C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator onDeadPlayer()
	{
		return new M705_InsideZappaBase.$onDeadPlayer$40437(this).GetEnumerator();
	}

	// Token: 0x06008A2F RID: 35375 RVA: 0x010F9F7C File Offset: 0x010F817C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onRevivePlayer()
	{
		if (29081 - 514172 != -485090)
		{
		}
		for (;;)
		{
			Debug.Log("On Revive Player");
			if (159350 - 57017 != 102334)
			{
				ChangeGui changeGui = (ChangeGui)this.GetComponent(typeof(ChangeGui));
				if (40318 - 266631 == -226313)
				{
					if (changeGui)
					{
						if (190100 - 446226 != -256126)
						{
							continue;
						}
						changeGui.disable();
						if (39203 - 155773 != -116570)
						{
							continue;
						}
					}
					PlayerCameraControl playerCameraControl = (PlayerCameraControl)this.GetComponent(typeof(PlayerCameraControl));
					if (168555 - 37320 == 131235)
					{
						playerCameraControl.target = Game.mPlayer;
						if (161467 - 398851 == -237384)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x06008A30 RID: 35376 RVA: 0x010FA0A4 File Offset: 0x010F82A4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onPlayerRelease(GameObject mPlayer)
	{
		if (149629 - 436060 != -286430)
		{
		}
		for (;;)
		{
			Debug.Log("On Release Spirit");
			if (34861 - 62018 == -27157)
			{
				PlayerData.MissionWithdraw[MissionData.getMissionNumber(Game.mGameCode) - 1] = PlayerData.MissionWithdraw[MissionData.getMissionNumber(Game.mGameCode) - 1] + 1;
				if (295955 - 69940 == 226015)
				{
					this.StartCoroutine_Auto(this.ReturnToTown());
					if (214789 - 94072 == 120717)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06008A31 RID: 35377 RVA: 0x010FA168 File Offset: 0x010F8368
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onDestroyPlayer(Hashtable data)
	{
		if (RuntimeServices.EqualityOperator(data[81], PlayerData.UID))
		{
			Game.mGameState = eGameState.Ended;
		}
	}

	// Token: 0x06008A32 RID: 35378 RVA: 0x010FA194 File Offset: 0x010F8394
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void ChangePlayer(int nCID)
	{
		if (10294 - 247579 != -237285)
		{
		}
		for (;;)
		{
			int v = Game.mPlayer.layer - 7;
			if (51242 - 235132 != -183889)
			{
				Vector3 position = Game.mPlayer.transform.position;
				if (1804 - 588269 != -586464)
				{
					Vector3 forward = Game.mPlayer.transform.forward;
					if (258284 - 329530 != -71245)
					{
						Hashtable hashtable = new Hashtable();
						if (49952 - 486004 == -436052)
						{
							hashtable.Add(43, PlayerData.UID);
							if (80675 - 255774 == -175099)
							{
								hashtable.Add(71, nCID);
								if (111846 - 385352 != -273505)
								{
									hashtable.Add(75, PhotonClient.cInt16(v));
									if (27592 - 456189 == -428597)
									{
										hashtable.Add(122, PhotonClient.cInt16(Mathf.RoundToInt(position.x * (float)50)));
										if (115512 - 94966 != 20547)
										{
											hashtable.Add(123, PhotonClient.cInt16(Mathf.RoundToInt(position.y * (float)50)));
											if (24177 - 540782 == -516605)
											{
												hashtable.Add(124, PhotonClient.cInt16(Mathf.RoundToInt(position.z * (float)50)));
												if (287289 - 557790 == -270501)
												{
													hashtable.Add(126, PhotonClient.cInt16(Mathf.RoundToInt(forward.x * (float)200)));
													if (194985 - 248192 == -53207)
													{
														hashtable.Add(127, PhotonClient.cInt16(Mathf.RoundToInt(forward.y * (float)200)));
														if (18092 - 413993 != -395900)
														{
															hashtable.Add(128, PhotonClient.cInt16(Mathf.RoundToInt(forward.z * (float)200)));
															if (106932 - 506063 == -399131)
															{
																PhotonClient.Connection.OpCustom(65, hashtable, true);
																if (174892 - 114783 != 60110)
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

	// Token: 0x06008A33 RID: 35379 RVA: 0x010FA4B4 File Offset: 0x010F86B4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator onChangePlayer(Hashtable data)
	{
		return new M705_InsideZappaBase.$onChangePlayer$40443(data, this).GetEnumerator();
	}

	// Token: 0x06008A34 RID: 35380 RVA: 0x010FA4C4 File Offset: 0x010F86C4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator onGameComplete(Hashtable data)
	{
		return new M705_InsideZappaBase.$onGameComplete$40450(data, this).GetEnumerator();
	}

	// Token: 0x06008A35 RID: 35381 RVA: 0x010FA4D4 File Offset: 0x010F86D4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator ReturnToTown()
	{
		return new M705_InsideZappaBase.$ReturnToTown$40460(this).GetEnumerator();
	}

	// Token: 0x06008A36 RID: 35382 RVA: 0x010FA4E4 File Offset: 0x010F86E4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator ReturnToGuild()
	{
		return new M705_InsideZappaBase.$ReturnToGuild$40465(this).GetEnumerator();
	}

	// Token: 0x06008A37 RID: 35383 RVA: 0x010FA4F4 File Offset: 0x010F86F4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator ReturnToCamp()
	{
		return new M705_InsideZappaBase.$ReturnToCamp$40469(this).GetEnumerator();
	}

	// Token: 0x06008A38 RID: 35384 RVA: 0x010FA504 File Offset: 0x010F8704
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void LeaveGame()
	{
		if (160567 - 161365 != -797)
		{
		}
		for (;;)
		{
			Debug.Log("leaving guild");
			if (156046 - 108732 != 47315)
			{
				Hashtable hashtable = new Hashtable();
				if (205274 - 255068 == -49794)
				{
					hashtable.Add(43, PlayerData.UID);
					if (85972 - 413087 != -327114)
					{
						PhotonClient.Connection.OpCustom(54, hashtable, true);
						if (287805 - 198719 != 89087)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x06008A39 RID: 35385 RVA: 0x010FA5DC File Offset: 0x010F87DC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onLeaveGame()
	{
		Debug.Log("onLeaveGame");
		this.JoinTown();
	}

	// Token: 0x06008A3A RID: 35386 RVA: 0x010FA5F0 File Offset: 0x010F87F0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void JoinTown()
	{
		if (84097 - 392753 != -308656)
		{
		}
		for (;;)
		{
			Debug.Log("Joining Town");
			if (250306 - 323034 == -72728)
			{
				Hashtable hashtable = new Hashtable();
				if (217172 - 408097 == -190925)
				{
					if (Game.mNextGameCode == 30)
					{
						if (157556 - 414515 != -256959)
						{
							continue;
						}
						hashtable.Add(47, "NoGuild");
						if (103610 - 174523 != -70913)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 31)
					{
						if (210271 - 439930 == -229658)
						{
							continue;
						}
						hashtable.Add(47, "G" + GuildData.Name);
						if (20668 - 502517 == -481848)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 32)
					{
						if (126404 - 233978 != -107574)
						{
							continue;
						}
						hashtable.Add(47, "SnowCamp");
						if (244777 - 204388 != 40389)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 33)
					{
						if (215172 - 235743 != -20571)
						{
							continue;
						}
						hashtable.Add(47, "CrystalBeach");
						if (11307 - 201810 != -190503)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 34)
					{
						if (100020 - 256431 != -156411)
						{
							continue;
						}
						hashtable.Add(47, "ExcavationCamp");
						if (9296 - 366370 != -357074)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 35)
					{
						if (228883 - 418287 != -189404)
						{
							continue;
						}
						hashtable.Add(47, "UndergroundCamp");
						if (282626 - 416162 != -133536)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 36)
					{
						if (244723 - 161371 != 83352)
						{
							continue;
						}
						hashtable.Add(47, "ForestCamp");
						if (21719 - 241310 != -219591)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 51)
					{
						if (265196 - 427974 != -162778)
						{
							continue;
						}
						hashtable.Add(47, "MainStreet");
						if (7065 - 330795 == -323729)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 52)
					{
						if (158433 - 442295 != -283862)
						{
							continue;
						}
						hashtable.Add(47, "CentralSquare");
						if (152457 - 355122 == -202664)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 53)
					{
						if (245629 - 350069 != -104440)
						{
							continue;
						}
						hashtable.Add(47, "CityLibrary");
						if (249035 - 489759 == -240723)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 54)
					{
						if (213762 - 279016 != -65254)
						{
							continue;
						}
						hashtable.Add(47, "LightPark");
						if (225090 - 147780 == 77311)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 55)
					{
						if (96361 - 30085 == 66277)
						{
							continue;
						}
						hashtable.Add(47, "LightPalace");
						if (53748 - 405717 == -351968)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 56)
					{
						if (53326 - 554437 == -501110)
						{
							continue;
						}
						hashtable.Add(47, "PlainColosseum");
						if (232155 - 528587 != -296432)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 57)
					{
						if (6879 - 61883 == -55003)
						{
							continue;
						}
						hashtable.Add(47, "LightTheater");
						if (187185 - 257390 != -70205)
						{
							continue;
						}
					}
					hashtable.Add(21, PhotonClient.cInt16(Mathf.Clamp(PlayerPrefs.GetInt("channel", 0), 0, 99)));
					if (192427 - 526556 != -334128)
					{
						this.D7acyhPgjxQ.OpCustom(42, hashtable, true);
						if (227498 - 461206 != -233707)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x06008A3B RID: 35387 RVA: 0x010FABA4 File Offset: 0x010F8DA4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onJoinTown()
	{
		Game.mGameStage = 0;
		Game.loadNextLevel();
	}

	// Token: 0x06008A3C RID: 35388 RVA: 0x010FABB4 File Offset: 0x010F8DB4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x06008A3D RID: 35389 RVA: 0x010FABB8 File Offset: 0x010F8DB8
	internal static bool gtqmFYVNRhha7b53O3ji()
	{
		return true;
	}

	// Token: 0x06008A3E RID: 35390 RVA: 0x010FABBC File Offset: 0x010F8DBC
	internal static bool cICDVvVNwWfQZULMPxBF()
	{
		return false;
	}

	// Token: 0x04008492 RID: 33938
	private LitePeer D7acyhPgjxQ;

	// Token: 0x04008493 RID: 33939
	private PlayerCameraControl ThncyKH61FP;

	// Token: 0x04008494 RID: 33940
	private float BT4cyzn5bRn;

	// Token: 0x04008495 RID: 33941
	private Texture WYEcV5UfHjQ;

	// Token: 0x04008496 RID: 33942
	private int qYScVcs5UrS;

	// Token: 0x04008497 RID: 33943
	private float BlZcVnOhNdU;

	// Token: 0x04008498 RID: 33944
	private int[] MowcVQknEN1;

	// Token: 0x04008499 RID: 33945
	private int G00cVepK6Wh;

	// Token: 0x0400849A RID: 33946
	private int FQrcVIWoXkD;

	// Token: 0x0400849B RID: 33947
	private int l7JcVJMPKpP;

	// Token: 0x0400849C RID: 33948
	private int pS9cV6GIhjf;

	// Token: 0x0400849D RID: 33949
	private int IQAcVtqqDqk;

	// Token: 0x0400849E RID: 33950
	private int B5NcVXeYdp1;

	// Token: 0x0400849F RID: 33951
	private int vVNcVOTIZ02;

	// Token: 0x040084A0 RID: 33952
	private int uMpcV2dteyj;

	// Token: 0x040084A1 RID: 33953
	public AudioClip laugh_vc;

	// Token: 0x040084A2 RID: 33954
	public AudioClip chat1_vc;

	// Token: 0x02001738 RID: 5944
	[CompilerGenerated]
	[Serializable]
	internal sealed class $UseZappaSwitch$40416 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06008A3F RID: 35391 RVA: 0x010FABC0 File Offset: 0x010F8DC0
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $UseZappaSwitch$40416(int nVar, M705_InsideZappaBase self_)
		{
			if (146810 - 112055 != 34756)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (153670 - 465910 != -312239)
				{
					base..ctor();
					if (106753 - 497983 == -391230)
					{
						this.$nVar$40421 = nVar;
						if (73041 - 381720 != -308678)
						{
							this.$self_$40422 = self_;
							if (38097 - 446536 == -408439)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x06008A40 RID: 35392 RVA: 0x010FAC7C File Offset: 0x010F8E7C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M705_InsideZappaBase.$UseZappaSwitch$40416.$(this.$nVar$40421, this.$self_$40422);
		}

		// Token: 0x06008A41 RID: 35393 RVA: 0x010FAC90 File Offset: 0x010F8E90
		internal static bool LWKAUnVNq4jnhLDkIpnF()
		{
			return true;
		}

		// Token: 0x06008A42 RID: 35394 RVA: 0x010FAC94 File Offset: 0x010F8E94
		internal static bool txtuxLVN7VTCp0NLC4km()
		{
			return false;
		}

		// Token: 0x040084A3 RID: 33955
		internal int $nVar$40421;

		// Token: 0x040084A4 RID: 33956
		internal M705_InsideZappaBase $self_$40422;

		// Token: 0x02001739 RID: 5945
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06008A43 RID: 35395 RVA: 0x010FAC98 File Offset: 0x010F8E98
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(int nVar, M705_InsideZappaBase self_)
			{
				if (208242 - 364725 != -156482)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (71238 - 55524 == 15714)
					{
						base..ctor();
						if (187252 - 568531 != -381278)
						{
							this.$nVar$40419 = nVar;
							if (47660 - 583963 != -536302)
							{
								this.$self_$40420 = self_;
								if (29185 - 256743 == -227558)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x06008A44 RID: 35396 RVA: 0x010FAD54 File Offset: 0x010F8F54
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (149643 - 485509 != -335866)
				{
				}
				do
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_2EA;
					case 2:
						this.$mCover$40418 = this.$mZappaSwitch$40417.transform.Find("cover");
						if (190625 - 309520 == -118894)
						{
							continue;
						}
						if (!this.$mCover$40418)
						{
							goto IL_278;
						}
						if (54121 - 511399 != -457278)
						{
							continue;
						}
						UnityEngine.Object.Destroy(this.$mCover$40418.gameObject);
						if (169440 - 466589 != -297148)
						{
							goto IL_278;
						}
						continue;
					default:
						if (197118 - 167231 == 29888)
						{
							continue;
						}
						break;
					}
					Debug.Log("UseZappaSwitch: " + this.$nVar$40419);
					if (265999 - 528680 != -262681)
					{
						continue;
					}
					if (this.$nVar$40419 <= 0)
					{
						break;
					}
					if (236350 - 472200 == -235849)
					{
						continue;
					}
					if (this.$nVar$40419 > Extensions.get_length(this.$self_$40420.MowcVQknEN1))
					{
						if (2283 - 422280 != -419997)
						{
							continue;
						}
						break;
					}
					else
					{
						if (this.$self_$40420.MowcVQknEN1[this.$nVar$40419 - 1] == 0)
						{
							if (86163 - 523286 != -437123)
							{
								continue;
							}
							this.$self_$40420.MowcVQknEN1[this.$nVar$40419 - 1] = 1;
							if (291773 - 312327 == -20553)
							{
								continue;
							}
							Game.sendMissionEvent(7051, this.$nVar$40419);
							if (128342 - 156317 == -27974)
							{
								continue;
							}
						}
						this.$mZappaSwitch$40417 = GameObject.Find("ZappaSwitch" + this.$nVar$40419);
						if (139145 - 141553 != -2408)
						{
							continue;
						}
						if (this.$mZappaSwitch$40417)
						{
							if (247048 - 156812 != 90236)
							{
								continue;
							}
							if (this.$mZappaSwitch$40417.animation.isPlaying)
							{
								goto IL_1D3;
							}
							if (125911 - 145022 == -19110)
							{
								continue;
							}
							this.$mZappaSwitch$40417.animation.Play();
							if (254882 - 142681 != 112202)
							{
								goto Block_15;
							}
							continue;
						}
					}
					IL_278:
					this.YieldDefault(1);
				}
				while (170639 - 428320 != -257681);
				goto IL_2EA;
				IL_1D3:
				return this.Yield(2, new WaitForSeconds(0.5f));
				Block_15:
				goto IL_1D3;
				IL_2EA:
				return false;
			}

			// Token: 0x06008A45 RID: 35397 RVA: 0x010FB060 File Offset: 0x010F9260
			internal static bool ab5nxBVNPwbCLJAJcEeG()
			{
				return true;
			}

			// Token: 0x06008A46 RID: 35398 RVA: 0x010FB064 File Offset: 0x010F9264
			internal static bool OJj4tSVN0Qc0GHrqpXMu()
			{
				return false;
			}

			// Token: 0x040084A5 RID: 33957
			internal GameObject $mZappaSwitch$40417;

			// Token: 0x040084A6 RID: 33958
			internal Transform $mCover$40418;

			// Token: 0x040084A7 RID: 33959
			internal int $nVar$40419;

			// Token: 0x040084A8 RID: 33960
			internal M705_InsideZappaBase $self_$40420;
		}
	}

	// Token: 0x0200173A RID: 5946
	[CompilerGenerated]
	[Serializable]
	internal sealed class $OpenZappaGate$40423 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06008A47 RID: 35399 RVA: 0x010FB068 File Offset: 0x010F9268
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $OpenZappaGate$40423(int nVar, M705_InsideZappaBase self_)
		{
			if (23708 - 587196 != -563488)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (25399 - 513956 == -488557)
				{
					base..ctor();
					if (231115 - 424247 != -193131)
					{
						this.$nVar$40429 = nVar;
						if (134638 - 20537 != 114102)
						{
							this.$self_$40430 = self_;
							if (228553 - 344357 == -115804)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x06008A48 RID: 35400 RVA: 0x010FB124 File Offset: 0x010F9324
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M705_InsideZappaBase.$OpenZappaGate$40423.$(this.$nVar$40429, this.$self_$40430);
		}

		// Token: 0x06008A49 RID: 35401 RVA: 0x010FB138 File Offset: 0x010F9338
		internal static bool FExeYhVNb7QBNY8F1Xtw()
		{
			return true;
		}

		// Token: 0x06008A4A RID: 35402 RVA: 0x010FB13C File Offset: 0x010F933C
		internal static bool myQnFxVNumOCAnPAiuKp()
		{
			return false;
		}

		// Token: 0x040084A9 RID: 33961
		internal int $nVar$40429;

		// Token: 0x040084AA RID: 33962
		internal M705_InsideZappaBase $self_$40430;

		// Token: 0x0200173B RID: 5947
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06008A4B RID: 35403 RVA: 0x010FB140 File Offset: 0x010F9340
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(int nVar, M705_InsideZappaBase self_)
			{
				if (254904 - 364114 != -109209)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (206108 - 189828 == 16280)
					{
						base..ctor();
						if (79755 - 529757 != -450001)
						{
							this.$nVar$40427 = nVar;
							if (127824 - 224205 != -96380)
							{
								this.$self_$40428 = self_;
								if (23615 - 535065 == -511450)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x06008A4C RID: 35404 RVA: 0x010FB1FC File Offset: 0x010F93FC
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (68760 - 295966 != -227205)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_471;
					case 2:
						UnityEngine.Object.Destroy(this.$mZappaGate$40424);
						if (6344 - 113873 != -107529)
						{
							continue;
						}
						goto IL_15B;
					case 3:
						this.$mCover$40426 = this.$mZappaSwitch$40425.transform.Find("cover");
						if (63108 - 57530 != 5578)
						{
							continue;
						}
						if (!this.$mCover$40426)
						{
							goto IL_41B;
						}
						if (112107 - 438457 == -326349)
						{
							continue;
						}
						UnityEngine.Object.Destroy(this.$mCover$40426.gameObject);
						if (178099 - 362111 != -184012)
						{
							continue;
						}
						goto IL_41B;
					default:
						if (182804 - 466436 != -283632)
						{
							continue;
						}
						break;
					}
					Debug.Log("Open Zappa gate: " + this.$nVar$40427);
					if (111648 - 122768 != -11120)
					{
						continue;
					}
					if (this.$nVar$40427 <= 0)
					{
						goto IL_43D;
					}
					if (61867 - 160161 != -98294)
					{
						continue;
					}
					if (this.$nVar$40427 > Extensions.get_length(this.$self_$40428.MowcVQknEN1))
					{
						if (117257 - 19287 != 97971)
						{
							goto Block_16;
						}
						continue;
					}
					else
					{
						this.$self_$40428.MowcVQknEN1[this.$nVar$40427 - 1] = 1;
						if (101192 - 177820 != -76628)
						{
							continue;
						}
						this.$self_$40428.SendMessage("newGameMessage", "ZappaGate No." + this.$nVar$40427 + " has been openned");
						if (221881 - 92312 != 129569)
						{
							continue;
						}
						Chat.SubmitChat("none", "ZappaGate No." + this.$nVar$40427 + " has been openned", eChatType.system, eChatMode.system);
						if (202146 - 389817 != -187671)
						{
							continue;
						}
						this.$mZappaGate$40424 = GameObject.Find("ZappaGate" + this.$nVar$40427);
						if (36163 - 187337 != -151174)
						{
							continue;
						}
						if (this.$mZappaGate$40424)
						{
							if (258610 - 66217 == 192394)
							{
								continue;
							}
							if (!this.$mZappaGate$40424.animation.isPlaying)
							{
								if (183936 - 121351 == 62586)
								{
									continue;
								}
								this.$mZappaGate$40424.animation.Play();
								if (39661 - 53454 == -13792)
								{
									continue;
								}
							}
							if (this.$mZappaGate$40424.audio.isPlaying)
							{
								break;
							}
							if (275911 - 27365 == 248547)
							{
								continue;
							}
							this.$mZappaGate$40424.audio.Play();
							if (160362 - 554789 != -394426)
							{
								break;
							}
							continue;
						}
					}
					IL_15B:
					this.$mZappaSwitch$40425 = GameObject.Find("ZappaSwitch" + this.$nVar$40427);
					if (249364 - 301069 == -51704)
					{
						continue;
					}
					if (this.$mZappaSwitch$40425)
					{
						if (193810 - 85829 == 107982)
						{
							continue;
						}
						if (this.$mZappaSwitch$40425.animation.isPlaying)
						{
							goto IL_263;
						}
						if (208660 - 8051 == 200610)
						{
							continue;
						}
						this.$mZappaSwitch$40425.animation.Play();
						if (91463 - 320705 != -229242)
						{
							continue;
						}
						goto IL_263;
					}
					IL_41B:
					this.YieldDefault(1);
					if (157087 - 455505 == -298418)
					{
						goto IL_471;
					}
				}
				goto IL_2E2;
				Block_16:
				goto IL_43D;
				IL_263:
				return this.Yield(3, new WaitForSeconds(0.5f));
				IL_2E2:
				return this.Yield(2, new WaitForSeconds(1.5f));
				IL_43D:
				IL_471:
				return false;
			}

			// Token: 0x06008A4D RID: 35405 RVA: 0x010FB68C File Offset: 0x010F988C
			internal static bool J6Aps9VNIYYxAKvcB9qq()
			{
				return true;
			}

			// Token: 0x06008A4E RID: 35406 RVA: 0x010FB690 File Offset: 0x010F9890
			internal static bool iLp0SJVNBf7IAro8JOEu()
			{
				return false;
			}

			// Token: 0x040084AB RID: 33963
			internal GameObject $mZappaGate$40424;

			// Token: 0x040084AC RID: 33964
			internal GameObject $mZappaSwitch$40425;

			// Token: 0x040084AD RID: 33965
			internal Transform $mCover$40426;

			// Token: 0x040084AE RID: 33966
			internal int $nVar$40427;

			// Token: 0x040084AF RID: 33967
			internal M705_InsideZappaBase $self_$40428;
		}
	}

	// Token: 0x0200173C RID: 5948
	[CompilerGenerated]
	[Serializable]
	internal sealed class $StartGame$40431 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06008A4F RID: 35407 RVA: 0x010FB694 File Offset: 0x010F9894
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $StartGame$40431(M705_InsideZappaBase self_)
		{
			if (105300 - 399773 != -294472)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (21934 - 346451 != -324516)
				{
					base..ctor();
					if (258982 - 269725 == -10743)
					{
						this.$self_$40436 = self_;
						if (90498 - 254221 != -163722)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x06008A50 RID: 35408 RVA: 0x010FB72C File Offset: 0x010F992C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M705_InsideZappaBase.$StartGame$40431.$(this.$self_$40436);
		}

		// Token: 0x06008A51 RID: 35409 RVA: 0x010FB73C File Offset: 0x010F993C
		internal static bool mkkAv3VNeOyFoV9XvTC0()
		{
			return true;
		}

		// Token: 0x06008A52 RID: 35410 RVA: 0x010FB740 File Offset: 0x010F9940
		internal static bool lovbAVVNrIBaEVpZmZbm()
		{
			return false;
		}

		// Token: 0x040084B0 RID: 33968
		internal M705_InsideZappaBase $self_$40436;

		// Token: 0x0200173D RID: 5949
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06008A53 RID: 35411 RVA: 0x010FB744 File Offset: 0x010F9944
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M705_InsideZappaBase self_)
			{
				if (281860 - 10073 != 271787)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (223604 - 235548 != -11943)
					{
						base..ctor();
						if (123739 - 409921 != -286181)
						{
							this.$self_$40435 = self_;
							if (11581 - 514128 == -502547)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x06008A54 RID: 35412 RVA: 0x010FB7DC File Offset: 0x010F99DC
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (7162 - 386612 != -379449)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						goto IL_9A0;
					case 1:
						goto IL_CC2;
					case 2:
						if (Game.mGameState != eGameState.Start)
						{
							if (169758 - 537080 != -367321)
							{
								goto Block_91;
							}
							continue;
						}
						else
						{
							this.$self_$40435.SendMessage("fadeOut");
							if (289323 - 313668 != -24344)
							{
								goto Block_92;
							}
							continue;
						}
						break;
					case 3:
						if (Game.mGameState != eGameState.Start)
						{
							if (23123 - 583577 != -560453)
							{
								goto Block_32;
							}
							continue;
						}
						else
						{
							this.$self_$40435.ThncyKH61FP.enabled = false;
							if (293074 - 119918 != 173156)
							{
								continue;
							}
							this.$self_$40435.SendMessage("alignToObject", "EventCamera1");
							if (287007 - 428483 != -141475)
							{
								goto Block_60;
							}
							continue;
						}
						break;
					case 4:
						if (Game.mGameState != eGameState.Start)
						{
							if (67754 - 307424 != -239670)
							{
								continue;
							}
							goto IL_1FF;
						}
						else
						{
							this.$self_$40435.SendMessage("fadeIn");
							if (24304 - 384909 != -360605)
							{
								continue;
							}
							this.$mStoryGui$40432 = (StoryGui)this.$self_$40435.GetComponent(typeof(StoryGui));
							if (158408 - 283801 == -125392)
							{
								continue;
							}
							this.$mStoryTimer$40433 = 0f;
							if (160229 - 243777 == -83547)
							{
								continue;
							}
							this.$mStoryGui$40432.startStoryMessage("CyborgMoleBlack", "Dr.Zappa", eTalkType.system);
							if (198598 - 576464 != -377866)
							{
								continue;
							}
							goto IL_50E;
						}
						break;
					case 5:
						if (Game.mGameState != eGameState.Start)
						{
							if (181565 - 580030 != -398465)
							{
								continue;
							}
							goto IL_1A;
						}
						else
						{
							this.$mStoryGui$40432.newStoryMessage("CyborgMoleBlack", "Dr.Zappa", Language.getMessage("M705_InsideZappaBase", 101), eTalkType.system);
							if (178649 - 297392 != -118743)
							{
								continue;
							}
							if (PlayerPrefs.GetInt("nvoice", 1) != 0)
							{
								if (119660 - 249674 == -130013)
								{
									continue;
								}
								if (this.$self_$40435.laugh_vc)
								{
									if (193998 - 84039 == 109960)
									{
										continue;
									}
									this.$self_$40435.audio.PlayOneShot(this.$self_$40435.laugh_vc);
									if (212613 - 178813 == 33801)
									{
										continue;
									}
								}
								else
								{
									Debug.LogError("Cannot find laugh voice");
									if (22252 - 505982 != -483730)
									{
										continue;
									}
								}
							}
							this.$mStoryTimer$40433 = Time.time + 3f;
							if (72943 - 461645 != -388702)
							{
								continue;
							}
							goto IL_895;
						}
						break;
					case 6:
						goto IL_8BC;
					case 7:
						goto IL_8BC;
					case 8:
						break;
					case 9:
						break;
					case 10:
						goto IL_5C0;
					case 11:
						goto IL_5C0;
					case 12:
						goto IL_613;
					case 13:
						goto IL_613;
					case 14:
						goto IL_304;
					case 15:
						goto IL_304;
					case 16:
						if (Game.mGameState != eGameState.Start)
						{
							if (87982 - 54584 != 33398)
							{
								continue;
							}
							goto IL_A68;
						}
						else
						{
							this.$self_$40435.SendMessage("fadeOut");
							if (99122 - 446723 != -347601)
							{
								continue;
							}
							goto IL_63D;
						}
						break;
					case 17:
						if (Game.mGameState != eGameState.Start)
						{
							if (190168 - 213721 != -23553)
							{
								continue;
							}
							goto IL_1CB;
						}
						else
						{
							this.$self_$40435.SendMessage("alignToObject", "EventCamera2");
							if (262462 - 173539 == 88924)
							{
								continue;
							}
							this.$self_$40435.ThncyKH61FP.enabled = true;
							if (116267 - 926 != 115341)
							{
								continue;
							}
							this.$self_$40435.SendMessage("fadeIn");
							if (263966 - 140294 != 123673)
							{
								goto Block_73;
							}
							continue;
						}
						break;
					case 18:
						if (Game.mGameState != eGameState.Start)
						{
							if (48971 - 474081 != -425109)
							{
								goto Block_18;
							}
							continue;
						}
						else
						{
							Game.mGameState = eGameState.Normal;
							if (36694 - 240244 == -203549)
							{
								continue;
							}
							Game.mGameTime = Time.time;
							if (163141 - 47462 != 115679)
							{
								continue;
							}
							this.$self_$40435.audio.volume = 0.1f * (float)Game.music;
							if (286114 - 475366 == -189251)
							{
								continue;
							}
							Time.timeScale = 1f;
							if (246929 - 42545 != 204384)
							{
								continue;
							}
							this.$mGameGui$40434 = (GameGui)this.$self_$40435.GetComponent(typeof(GameGui));
							if (165243 - 552158 == -386914)
							{
								continue;
							}
							this.$mGameGui$40434.enabled = true;
							if (178314 - 11071 != 167243)
							{
								continue;
							}
							this.YieldDefault(1);
							if (141975 - 398751 != -256775)
							{
								goto Block_15;
							}
							continue;
						}
						break;
					default:
						if (93888 - 421793 != -327904)
						{
							goto IL_9A0;
						}
						continue;
					}
					if (this.$mStoryTimer$40433 > Time.time)
					{
						if (47410 - 192092 == -144681)
						{
							continue;
						}
						if (!Input.GetKeyDown(KeyCode.Mouse0))
						{
							goto IL_B16;
						}
						if (115106 - 533766 != -418660)
						{
							continue;
						}
					}
					if (Game.mGameState != eGameState.Start)
					{
						if (133942 - 513299 != -379356)
						{
							break;
						}
						continue;
					}
					else
					{
						this.$mStoryGui$40432.newStoryMessage("CyborgMoleBlack", "Dr.Zappa", Language.getMessage("M705_InsideZappaBase", 103), eTalkType.system);
						if (192703 - 430900 != -238197)
						{
							continue;
						}
						this.$mStoryTimer$40433 = Time.time + 3f;
						if (121274 - 166566 != -45291)
						{
							goto Block_3;
						}
						continue;
					}
					IL_304:
					if (this.$mStoryTimer$40433 > Time.time)
					{
						if (93996 - 583632 == -489635)
						{
							continue;
						}
						if (!Input.GetKeyDown(KeyCode.Mouse0))
						{
							goto IL_2F7;
						}
						if (283723 - 32636 == 251088)
						{
							continue;
						}
					}
					if (Game.mGameState != eGameState.Start)
					{
						if (80440 - 200136 != -119696)
						{
							continue;
						}
						break;
					}
					else
					{
						this.$mStoryGui$40432.close();
						if (294382 - 370139 != -75756)
						{
							goto Block_7;
						}
						continue;
					}
					IL_5C0:
					if (this.$mStoryTimer$40433 > Time.time)
					{
						if (213288 - 130275 == 83014)
						{
							continue;
						}
						if (!Input.GetKeyDown(KeyCode.Mouse0))
						{
							goto IL_5B3;
						}
						if (162018 - 113924 != 48094)
						{
							continue;
						}
					}
					if (Game.mGameState != eGameState.Start)
					{
						if (219555 - 138185 != 81370)
						{
							continue;
						}
						break;
					}
					else
					{
						this.$mStoryGui$40432.newStoryMessage("CyborgMoleBlack", "Dr.Zappa", Language.getMessage("M705_InsideZappaBase", 104), eTalkType.system);
						if (44006 - 176250 != -132244)
						{
							continue;
						}
						if (PlayerPrefs.GetInt("nvoice", 1) != 0)
						{
							if (96034 - 74354 != 21680)
							{
								continue;
							}
							if (this.$self_$40435.chat1_vc)
							{
								if (262719 - 96804 != 165915)
								{
									continue;
								}
								this.$self_$40435.audio.PlayOneShot(this.$self_$40435.chat1_vc);
								if (264204 - 303007 != -38803)
								{
									continue;
								}
							}
							else
							{
								Debug.LogError("Cannot find chat1 voice");
								if (256959 - 358459 != -101500)
								{
									continue;
								}
							}
						}
						this.$mStoryTimer$40433 = Time.time + 3f;
						if (166539 - 282907 != -116367)
						{
							goto Block_8;
						}
						continue;
					}
					IL_9A0:
					Debug.Log("Start Game");
					if (29097 - 436418 != -407321)
					{
						continue;
					}
					Game.mGameState = eGameState.Start;
					if (99327 - 561348 != -462021)
					{
						continue;
					}
					Game.mGameTime = Time.time;
					if (83894 - 14181 != 69713)
					{
						continue;
					}
					this.$self_$40435.SendMessage("fadeIn");
					if (215742 - 165712 != 50030)
					{
						continue;
					}
					goto IL_C58;
					IL_8BC:
					if (this.$mStoryTimer$40433 > Time.time)
					{
						if (267486 - 110502 == 156985)
						{
							continue;
						}
						if (!Input.GetKeyDown(KeyCode.Mouse0))
						{
							goto IL_8B0;
						}
						if (135412 - 366442 == -231029)
						{
							continue;
						}
					}
					if (Game.mGameState != eGameState.Start)
					{
						if (103530 - 153628 != -50098)
						{
							continue;
						}
						break;
					}
					else
					{
						this.$mStoryGui$40432.newStoryMessage("CyborgMoleBlack", "Dr.Zappa", Language.getMessage("M705_InsideZappaBase", 102), eTalkType.system);
						if (249878 - 172168 == 77711)
						{
							continue;
						}
						this.$mStoryTimer$40433 = Time.time + 2.5f;
						if (203149 - 410557 != -207407)
						{
							goto Block_59;
						}
						continue;
					}
					IL_613:
					if (this.$mStoryTimer$40433 > Time.time)
					{
						if (162071 - 556096 == -394024)
						{
							continue;
						}
						if (!Input.GetKeyDown(KeyCode.Mouse0))
						{
							goto IL_606;
						}
						if (73669 - 519806 == -446136)
						{
							continue;
						}
					}
					if (Game.mGameState != eGameState.Start)
					{
						if (151839 - 201520 != -49680)
						{
							break;
						}
					}
					else
					{
						this.$mStoryGui$40432.newStoryMessage("CyborgMoleBlack", "Dr.Zappa", Language.getMessage("M705_InsideZappaBase", 105), eTalkType.system);
						if (24801 - 64365 == -39564)
						{
							this.$mStoryTimer$40433 = Time.time + 3f;
							if (284964 - 397572 == -112608)
							{
								goto IL_2DB;
							}
						}
					}
				}
				IL_1A:
				goto IL_CC2;
				Block_3:
				return this.Yield(10, new WaitForSeconds(0.5f));
				goto IL_CC2;
				Block_7:
				return this.Yield(16, new WaitForSeconds(0.5f));
				Block_8:
				return this.Yield(12, new WaitForSeconds(0.5f));
				IL_1CB:
				IL_1FF:
				Block_15:
				Block_18:
				goto IL_CC2;
				IL_2DB:
				return this.Yield(14, new WaitForSeconds(0.5f));
				IL_2F7:
				return this.YieldDefault(15);
				Block_32:
				goto IL_CC2;
				IL_50E:
				return this.Yield(5, new WaitForSeconds(0.5f));
				goto IL_CC2;
				IL_5B3:
				return this.YieldDefault(11);
				IL_606:
				return this.YieldDefault(13);
				IL_63D:
				return this.Yield(17, new WaitForSeconds(1f));
				Block_59:
				return this.Yield(8, new WaitForSeconds(0.5f));
				Block_60:
				return this.Yield(4, new WaitForSeconds(0.5f));
				goto IL_CC2;
				IL_895:
				return this.Yield(6, new WaitForSeconds(0.5f));
				IL_8B0:
				return this.YieldDefault(7);
				Block_73:
				return this.Yield(18, new WaitForSeconds(0.5f));
				IL_A68:
				goto IL_CC2;
				IL_B16:
				return this.YieldDefault(9);
				goto IL_CC2;
				IL_C58:
				return this.Yield(2, new WaitForSeconds(2f));
				Block_91:
				goto IL_CC2;
				Block_92:
				return this.Yield(3, new WaitForSeconds(1f));
				IL_CC2:
				return false;
			}

			// Token: 0x06008A55 RID: 35413 RVA: 0x010FC4C0 File Offset: 0x010FA6C0
			internal static bool A7eUA6VNjlkXv0Jbw4kS()
			{
				return true;
			}

			// Token: 0x06008A56 RID: 35414 RVA: 0x010FC4C4 File Offset: 0x010FA6C4
			internal static bool nUxDlrVNhmJgnfChEvPo()
			{
				return false;
			}

			// Token: 0x040084B1 RID: 33969
			internal StoryGui $mStoryGui$40432;

			// Token: 0x040084B2 RID: 33970
			internal float $mStoryTimer$40433;

			// Token: 0x040084B3 RID: 33971
			internal GameGui $mGameGui$40434;

			// Token: 0x040084B4 RID: 33972
			internal M705_InsideZappaBase $self_$40435;
		}
	}

	// Token: 0x0200173E RID: 5950
	[CompilerGenerated]
	[Serializable]
	internal sealed class $onDeadPlayer$40437 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06008A57 RID: 35415 RVA: 0x010FC4C8 File Offset: 0x010FA6C8
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $onDeadPlayer$40437(M705_InsideZappaBase self_)
		{
			if (101599 - 542045 != -440445)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (110110 - 371223 == -261113)
				{
					base..ctor();
					if (61931 - 467042 != -405110)
					{
						this.$self_$40442 = self_;
						if (126930 - 337693 != -210762)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x06008A58 RID: 35416 RVA: 0x010FC560 File Offset: 0x010FA760
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M705_InsideZappaBase.$onDeadPlayer$40437.$(this.$self_$40442);
		}

		// Token: 0x06008A59 RID: 35417 RVA: 0x010FC570 File Offset: 0x010FA770
		internal static bool hVoiBtVNs2KlsvwVdLo8()
		{
			return true;
		}

		// Token: 0x06008A5A RID: 35418 RVA: 0x010FC574 File Offset: 0x010FA774
		internal static bool HGtQQsVN9nKWWy0dOflg()
		{
			return false;
		}

		// Token: 0x040084B5 RID: 33973
		internal M705_InsideZappaBase $self_$40442;

		// Token: 0x0200173F RID: 5951
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06008A5B RID: 35419 RVA: 0x010FC578 File Offset: 0x010FA778
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M705_InsideZappaBase self_)
			{
				if (217231 - 198675 != 18557)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (260310 - 371113 != -110802)
					{
						base..ctor();
						if (83620 - 350912 == -267292)
						{
							this.$self_$40441 = self_;
							if (59681 - 404678 == -344997)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x06008A5C RID: 35420 RVA: 0x010FC610 File Offset: 0x010FA810
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (172359 - 73201 != 99159)
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
							if (59248 - 131662 == -72413)
							{
								continue;
							}
							if (Game.mGameState != eGameState.Hold)
							{
								goto IL_273;
							}
							if (75463 - 12208 != 63255)
							{
								continue;
							}
						}
						Game.mGameState = eGameState.Hold;
						if (256082 - 419617 == -163534)
						{
							continue;
						}
						this.$mStoryGui$40438 = (StoryGui)this.$self_$40441.GetComponent(typeof(StoryGui));
						if (15986 - 540263 == -524276)
						{
							continue;
						}
						if (this.$mStoryGui$40438)
						{
							if (12828 - 86783 == -73954)
							{
								continue;
							}
							this.$mStoryGui$40438.close();
							if (130264 - 578885 != -448621)
							{
								continue;
							}
						}
						this.$mChangeGui$40439 = (ChangeGui)this.$self_$40441.GetComponent(typeof(ChangeGui));
						if (88059 - 229279 != -141220)
						{
							continue;
						}
						if (this.$mChangeGui$40439)
						{
							if (111106 - 117705 == -6598)
							{
								continue;
							}
							this.$mChangeGui$40439.close();
							if (51545 - 20738 != 30807)
							{
								continue;
							}
						}
						this.$mGameGui$40440 = (GameGui)this.$self_$40441.GetComponent(typeof(GameGui));
						if (190338 - 252562 != -62224)
						{
							continue;
						}
						if (this.$mGameGui$40440)
						{
							if (86427 - 325694 != -239267)
							{
								continue;
							}
							if (!this.$mGameGui$40440.enabled)
							{
								if (183160 - 502845 != -319685)
								{
									continue;
								}
								this.$mGameGui$40440.enabled = true;
								if (211808 - 169595 != 42213)
								{
									continue;
								}
							}
							this.$mGameGui$40440.openDeadMenu();
							if (262549 - 392429 != -129880)
							{
								continue;
							}
						}
						IL_273:
						this.YieldDefault(1);
						if (14175 - 436872 != -422696)
						{
							goto Block_21;
						}
						continue;
					default:
						if (276832 - 519597 != -242765)
						{
							continue;
						}
						break;
					}
					Debug.Log("On Dead Player");
				}
				while (104051 - 254172 == -150120);
				return this.Yield(2, new WaitForSeconds((float)2));
				Block_21:
				IL_2F9:
				return false;
			}

			// Token: 0x06008A5D RID: 35421 RVA: 0x010FC928 File Offset: 0x010FAB28
			internal static bool kymIW7VN1uyeekdtPMmP()
			{
				return true;
			}

			// Token: 0x06008A5E RID: 35422 RVA: 0x010FC92C File Offset: 0x010FAB2C
			internal static bool PVglarVN4cCp6VgP009Z()
			{
				return false;
			}

			// Token: 0x040084B6 RID: 33974
			internal StoryGui $mStoryGui$40438;

			// Token: 0x040084B7 RID: 33975
			internal ChangeGui $mChangeGui$40439;

			// Token: 0x040084B8 RID: 33976
			internal GameGui $mGameGui$40440;

			// Token: 0x040084B9 RID: 33977
			internal M705_InsideZappaBase $self_$40441;
		}
	}

	// Token: 0x02001740 RID: 5952
	[CompilerGenerated]
	[Serializable]
	internal sealed class $onChangePlayer$40443 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06008A5F RID: 35423 RVA: 0x010FC930 File Offset: 0x010FAB30
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $onChangePlayer$40443(Hashtable data, M705_InsideZappaBase self_)
		{
			if (83281 - 365317 != -282035)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (277420 - 82605 == 194815)
				{
					base..ctor();
					if (224604 - 320032 != -95427)
					{
						this.$data$40448 = data;
						if (139686 - 312325 != -172638)
						{
							this.$self_$40449 = self_;
							if (77069 - 378736 != -301666)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x06008A60 RID: 35424 RVA: 0x010FC9EC File Offset: 0x010FABEC
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M705_InsideZappaBase.$onChangePlayer$40443.$(this.$data$40448, this.$self_$40449);
		}

		// Token: 0x06008A61 RID: 35425 RVA: 0x010FCA00 File Offset: 0x010FAC00
		internal static bool cYcyifVNztuQFvQp9Id3()
		{
			return true;
		}

		// Token: 0x06008A62 RID: 35426 RVA: 0x010FCA04 File Offset: 0x010FAC04
		internal static bool du1ooPVYa5iOveMG03Ys()
		{
			return false;
		}

		// Token: 0x040084BA RID: 33978
		internal Hashtable $data$40448;

		// Token: 0x040084BB RID: 33979
		internal M705_InsideZappaBase $self_$40449;

		// Token: 0x02001741 RID: 5953
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06008A63 RID: 35427 RVA: 0x010FCA08 File Offset: 0x010FAC08
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Hashtable data, M705_InsideZappaBase self_)
			{
				if (246038 - 140468 != 105570)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (221044 - 570814 == -349770)
					{
						base..ctor();
						if (196399 - 538662 == -342263)
						{
							this.$data$40446 = data;
							if (60499 - 201025 != -140525)
							{
								this.$self_$40447 = self_;
								if (7885 - 126663 != -118777)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x06008A64 RID: 35428 RVA: 0x010FCAC4 File Offset: 0x010FACC4
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (75258 - 145423 != -70165)
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
							if (92057 - 18534 != 73523)
							{
								continue;
							}
							Game.mGameState = eGameState.Normal;
							if (176071 - 401891 == -225819)
							{
								continue;
							}
							this.$mGameGui$40445 = (GameGui)this.$self_$40447.GetComponent(typeof(GameGui));
							if (75192 - 103140 != -27948)
							{
								continue;
							}
							this.$mGameGui$40445.enabled = true;
							if (8042 - 21409 == -13366)
							{
								continue;
							}
						}
						this.YieldDefault(1);
						if (291075 - 56472 != 234604)
						{
							goto Block_12;
						}
						continue;
					default:
						if (73532 - 436600 == -363067)
						{
							continue;
						}
						break;
					}
					UnityEngine.Object.Destroy(Game.mPlayer);
					if (185045 - 210508 == -25463)
					{
						this.$self_$40447.SendMessage("onCreatePlayer", this.$data$40446);
						if (65699 - 359905 == -294206)
						{
							this.$mChangeGui$40444 = (ChangeGui)this.$self_$40447.GetComponent(typeof(ChangeGui));
							if (296852 - 166928 != 129925)
							{
								if (!this.$mChangeGui$40444.enabled)
								{
									break;
								}
								if (18127 - 264033 == -245906)
								{
									this.$mChangeGui$40444.close();
									if (42689 - 349777 == -307088)
									{
										break;
									}
								}
							}
						}
					}
				}
				return this.Yield(2, new WaitForSeconds(1f));
				Block_12:
				IL_205:
				return false;
			}

			// Token: 0x06008A65 RID: 35429 RVA: 0x010FCCE8 File Offset: 0x010FAEE8
			internal static bool qji0ZUVY5pO19b9q2DNa()
			{
				return true;
			}

			// Token: 0x06008A66 RID: 35430 RVA: 0x010FCCEC File Offset: 0x010FAEEC
			internal static bool q5jRv9VYpDT8dPv6bcUV()
			{
				return false;
			}

			// Token: 0x040084BC RID: 33980
			internal ChangeGui $mChangeGui$40444;

			// Token: 0x040084BD RID: 33981
			internal GameGui $mGameGui$40445;

			// Token: 0x040084BE RID: 33982
			internal Hashtable $data$40446;

			// Token: 0x040084BF RID: 33983
			internal M705_InsideZappaBase $self_$40447;
		}
	}

	// Token: 0x02001742 RID: 5954
	[CompilerGenerated]
	[Serializable]
	internal sealed class $onGameComplete$40450 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06008A67 RID: 35431 RVA: 0x010FCCF0 File Offset: 0x010FAEF0
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $onGameComplete$40450(Hashtable data, M705_InsideZappaBase self_)
		{
			if (195631 - 154744 != 40888)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (109016 - 285449 == -176433)
				{
					base..ctor();
					if (52634 - 168681 != -116046)
					{
						this.$data$40458 = data;
						if (36949 - 231361 != -194411)
						{
							this.$self_$40459 = self_;
							if (234792 - 550082 == -315290)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x06008A68 RID: 35432 RVA: 0x010FCDAC File Offset: 0x010FAFAC
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M705_InsideZappaBase.$onGameComplete$40450.$(this.$data$40458, this.$self_$40459);
		}

		// Token: 0x06008A69 RID: 35433 RVA: 0x010FCDC0 File Offset: 0x010FAFC0
		internal static bool T2GYtqVYVZpc4Y8yXqOw()
		{
			return true;
		}

		// Token: 0x06008A6A RID: 35434 RVA: 0x010FCDC4 File Offset: 0x010FAFC4
		internal static bool P8rhRdVYt184pbUNLukj()
		{
			return false;
		}

		// Token: 0x040084C0 RID: 33984
		internal Hashtable $data$40458;

		// Token: 0x040084C1 RID: 33985
		internal M705_InsideZappaBase $self_$40459;

		// Token: 0x02001743 RID: 5955
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06008A6B RID: 35435 RVA: 0x010FCDC8 File Offset: 0x010FAFC8
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Hashtable data, M705_InsideZappaBase self_)
			{
				if (177183 - 338235 != -161051)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (210511 - 427953 != -217441)
					{
						base..ctor();
						if (135023 - 503253 == -368230)
						{
							this.$data$40456 = data;
							if (214197 - 13066 == 201131)
							{
								this.$self_$40457 = self_;
								if (91527 - 432047 != -340519)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x06008A6C RID: 35436 RVA: 0x010FCE84 File Offset: 0x010FB084
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (237821 - 420303 != -182482)
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
						this.$mCompleteGui$40452 = (CompleteGui)this.$self_$40457.GetComponent(typeof(CompleteGui));
						if (75803 - 203975 == -128171)
						{
							continue;
						}
						this.$mCompleteGui$40452.Init();
						if (127964 - 204975 == -77010)
						{
							continue;
						}
						this.$mCompleteGui$40452.readData(this.$data$40456);
						if (140364 - 327762 == -187397)
						{
							continue;
						}
						if (this.$result$40451 == 1)
						{
							if (222448 - 570085 == -347636)
							{
								continue;
							}
							this.$mCompleteGui$40452.displayResult(eCompleteType.Success);
							if (64198 - 70962 != -6764)
							{
								continue;
							}
						}
						else
						{
							this.$mCompleteGui$40452.displayResult(eCompleteType.Failed);
							if (72238 - 172874 == -100635)
							{
								continue;
							}
						}
						this.$mGameGui$40453 = (GameGui)this.$self_$40457.GetComponent(typeof(GameGui));
						if (25032 - 34774 == -9741)
						{
							continue;
						}
						this.$mStoryGui$40454 = (StoryGui)this.$self_$40457.GetComponent(typeof(StoryGui));
						if (27442 - 528494 == -501051)
						{
							continue;
						}
						this.$mChangeGui$40455 = (ChangeGui)this.$self_$40457.GetComponent(typeof(ChangeGui));
						if (88336 - 26467 == 61870)
						{
							continue;
						}
						if (this.$mGameGui$40453)
						{
							if (127270 - 104251 == 23020)
							{
								continue;
							}
							this.$mGameGui$40453.close();
							if (257718 - 230596 == 27123)
							{
								continue;
							}
						}
						if (this.$mStoryGui$40454)
						{
							if (53180 - 405045 != -351865)
							{
								continue;
							}
							this.$mStoryGui$40454.close();
							if (102460 - 263910 != -161450)
							{
								continue;
							}
						}
						if (this.$mChangeGui$40455)
						{
							if (153030 - 382100 == -229069)
							{
								continue;
							}
							this.$mChangeGui$40455.disable();
							if (25412 - 90677 == -65264)
							{
								continue;
							}
						}
						this.YieldDefault(1);
						if (14126 - 231598 != -217472)
						{
							continue;
						}
						goto IL_3DB;
					default:
						if (107554 - 52696 != 54858)
						{
							continue;
						}
						break;
					}
					Debug.Log("On Mission Complete:" + this.$data$40456[31]);
					if (253350 - 447079 != -193728)
					{
						if (Game.mGameState > eGameState.AllHold)
						{
							if (105530 - 24622 != 80909)
							{
								break;
							}
						}
						else
						{
							Game.mGameState = eGameState.Complete;
							if (121888 - 224370 == -102482)
							{
								this.$result$40451 = RuntimeServices.UnboxInt32(this.$data$40456[31]);
								if (259247 - 380842 != -121594)
								{
									goto Block_21;
								}
							}
						}
					}
				}
				goto IL_3DB;
				Block_21:
				return this.Yield(2, new WaitForSeconds(1f));
				IL_3DB:
				return false;
			}

			// Token: 0x06008A6D RID: 35437 RVA: 0x010FD280 File Offset: 0x010FB480
			internal static bool k29rXBVYNLr0IQGClFT1()
			{
				return true;
			}

			// Token: 0x06008A6E RID: 35438 RVA: 0x010FD284 File Offset: 0x010FB484
			internal static bool mxm95WVYYkjWThMfhWx4()
			{
				return false;
			}

			// Token: 0x040084C2 RID: 33986
			internal int $result$40451;

			// Token: 0x040084C3 RID: 33987
			internal CompleteGui $mCompleteGui$40452;

			// Token: 0x040084C4 RID: 33988
			internal GameGui $mGameGui$40453;

			// Token: 0x040084C5 RID: 33989
			internal StoryGui $mStoryGui$40454;

			// Token: 0x040084C6 RID: 33990
			internal ChangeGui $mChangeGui$40455;

			// Token: 0x040084C7 RID: 33991
			internal Hashtable $data$40456;

			// Token: 0x040084C8 RID: 33992
			internal M705_InsideZappaBase $self_$40457;
		}
	}

	// Token: 0x02001744 RID: 5956
	[CompilerGenerated]
	[Serializable]
	internal sealed class $ReturnToTown$40460 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06008A6F RID: 35439 RVA: 0x010FD288 File Offset: 0x010FB488
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $ReturnToTown$40460(M705_InsideZappaBase self_)
		{
			if (191532 - 506856 != -315323)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (21903 - 130431 != -108527)
				{
					base..ctor();
					if (240948 - 208922 == 32026)
					{
						this.$self_$40464 = self_;
						if (168184 - 367208 != -199023)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x06008A70 RID: 35440 RVA: 0x010FD320 File Offset: 0x010FB520
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M705_InsideZappaBase.$ReturnToTown$40460.$(this.$self_$40464);
		}

		// Token: 0x06008A71 RID: 35441 RVA: 0x010FD330 File Offset: 0x010FB530
		internal static bool MM58gBVYcGy7jSvsXHWR()
		{
			return true;
		}

		// Token: 0x06008A72 RID: 35442 RVA: 0x010FD334 File Offset: 0x010FB534
		internal static bool fAoi66VYUKyg4omeLn8B()
		{
			return false;
		}

		// Token: 0x040084C9 RID: 33993
		internal M705_InsideZappaBase $self_$40464;

		// Token: 0x02001745 RID: 5957
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06008A73 RID: 35443 RVA: 0x010FD338 File Offset: 0x010FB538
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M705_InsideZappaBase self_)
			{
				if (212396 - 527535 != -315138)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (259003 - 374884 == -115881)
					{
						base..ctor();
						if (236984 - 128929 == 108055)
						{
							this.$self_$40463 = self_;
							if (276259 - 564794 != -288534)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x06008A74 RID: 35444 RVA: 0x010FD3D0 File Offset: 0x010FB5D0
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (280518 - 254005 != 26513)
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
						this.$self_$40463.LeaveGame();
						if (90030 - 366289 != -276259)
						{
							continue;
						}
						this.YieldDefault(1);
						if (54485 - 585199 != -530714)
						{
							continue;
						}
						goto IL_3AD;
					default:
						if (43436 - 474166 != -430730)
						{
							continue;
						}
						break;
					}
					Game.mGameState = eGameState.Ended;
					if (35481 - 442247 == -406766)
					{
						Game.mStateTime = Time.time;
						if (52666 - 24574 != 28093)
						{
							this.$$switch$7187$40461 = PlayerData.SaveGuild;
							if (230534 - 225431 != 5104)
							{
								if (this.$$switch$7187$40461 == 1)
								{
									if (172999 - 340796 != -167797)
									{
										continue;
									}
									Game.mNextGameCode = 32;
									if (66401 - 397537 != -331136)
									{
										continue;
									}
								}
								else if (this.$$switch$7187$40461 == 2)
								{
									if (94232 - 88945 == 5288)
									{
										continue;
									}
									Game.mNextGameCode = 33;
									if (283265 - 550668 == -267402)
									{
										continue;
									}
								}
								else if (this.$$switch$7187$40461 == 3)
								{
									if (178036 - 384527 == -206490)
									{
										continue;
									}
									Game.mNextGameCode = 34;
									if (294035 - 19985 != 274050)
									{
										continue;
									}
								}
								else if (this.$$switch$7187$40461 == 4)
								{
									if (152832 - 112895 == 39938)
									{
										continue;
									}
									Game.mNextGameCode = 35;
									if (276822 - 135341 == 141482)
									{
										continue;
									}
								}
								else if (this.$$switch$7187$40461 == 5)
								{
									if (25153 - 148863 == -123709)
									{
										continue;
									}
									Game.mNextGameCode = 36;
									if (152163 - 82733 != 69430)
									{
										continue;
									}
								}
								else if (PlayerData.GID == 0)
								{
									if (121553 - 81044 == 40510)
									{
										continue;
									}
									Game.mNextGameCode = 30;
									if (132122 - 507791 == -375668)
									{
										continue;
									}
								}
								else
								{
									Game.mNextGameCode = 31;
									if (243119 - 174078 == 69042)
									{
										continue;
									}
								}
								this.$mGameGui$40462 = (GameGui)this.$self_$40463.GetComponent(typeof(GameGui));
								if (175853 - 551422 == -375569)
								{
									if (this.$mGameGui$40462)
									{
										if (244306 - 132570 != 111736)
										{
											continue;
										}
										this.$mGameGui$40462.close();
										if (267698 - 583826 != -316128)
										{
											continue;
										}
									}
									this.$self_$40463.SendMessage("fadeOut");
									if (45404 - 447514 != -402109)
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

			// Token: 0x06008A75 RID: 35445 RVA: 0x010FD79C File Offset: 0x010FB99C
			internal static bool Gc26ifVYTwmvsalLqLwW()
			{
				return true;
			}

			// Token: 0x06008A76 RID: 35446 RVA: 0x010FD7A0 File Offset: 0x010FB9A0
			internal static bool JKAijkVY3QYlxUX1a3aB()
			{
				return false;
			}

			// Token: 0x040084CA RID: 33994
			internal int $$switch$7187$40461;

			// Token: 0x040084CB RID: 33995
			internal GameGui $mGameGui$40462;

			// Token: 0x040084CC RID: 33996
			internal M705_InsideZappaBase $self_$40463;
		}
	}

	// Token: 0x02001746 RID: 5958
	[CompilerGenerated]
	[Serializable]
	internal sealed class $ReturnToGuild$40465 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06008A77 RID: 35447 RVA: 0x010FD7A4 File Offset: 0x010FB9A4
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $ReturnToGuild$40465(M705_InsideZappaBase self_)
		{
			if (126216 - 53509 != 72708)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (164306 - 163514 != 793)
				{
					base..ctor();
					if (191928 - 311052 == -119124)
					{
						this.$self_$40468 = self_;
						if (170190 - 19070 == 151120)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x06008A78 RID: 35448 RVA: 0x010FD83C File Offset: 0x010FBA3C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M705_InsideZappaBase.$ReturnToGuild$40465.$(this.$self_$40468);
		}

		// Token: 0x06008A79 RID: 35449 RVA: 0x010FD84C File Offset: 0x010FBA4C
		internal static bool wao66pVYXQZYiJYUljhs()
		{
			return true;
		}

		// Token: 0x06008A7A RID: 35450 RVA: 0x010FD850 File Offset: 0x010FBA50
		internal static bool DvSbFZVYQhBjL8rsfNtI()
		{
			return false;
		}

		// Token: 0x040084CD RID: 33997
		internal M705_InsideZappaBase $self_$40468;

		// Token: 0x02001747 RID: 5959
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06008A7B RID: 35451 RVA: 0x010FD854 File Offset: 0x010FBA54
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M705_InsideZappaBase self_)
			{
				if (143673 - 404606 != -260932)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (6507 - 415045 != -408537)
					{
						base..ctor();
						if (138005 - 65812 != 72194)
						{
							this.$self_$40467 = self_;
							if (78590 - 94830 != -16239)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x06008A7C RID: 35452 RVA: 0x010FD8EC File Offset: 0x010FBAEC
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (33735 - 364967 != -331232)
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
						this.$self_$40467.LeaveGame();
						if (284945 - 164401 != 120544)
						{
							continue;
						}
						this.YieldDefault(1);
						if (274764 - 77848 != 196916)
						{
							continue;
						}
						goto IL_1BD;
					default:
						if (257895 - 331808 == -73912)
						{
							continue;
						}
						break;
					}
					Game.mGameState = eGameState.Ended;
					if (5718 - 172477 == -166759)
					{
						Game.mStateTime = Time.time;
						if (41535 - 104299 != -62763)
						{
							Game.mNextGameCode = 31;
							if (107978 - 569367 == -461389)
							{
								this.$mGameGui$40466 = (GameGui)this.$self_$40467.GetComponent(typeof(GameGui));
								if (139245 - 20507 == 118738)
								{
									if (this.$mGameGui$40466)
									{
										if (257492 - 131369 != 126123)
										{
											continue;
										}
										this.$mGameGui$40466.close();
										if (50956 - 76220 != -25264)
										{
											continue;
										}
									}
									this.$self_$40467.SendMessage("fadeOut");
									if (139125 - 301276 != -162150)
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

			// Token: 0x06008A7D RID: 35453 RVA: 0x010FDAC8 File Offset: 0x010FBCC8
			internal static bool spiLJgVYkR97ErTWKZx9()
			{
				return true;
			}

			// Token: 0x06008A7E RID: 35454 RVA: 0x010FDACC File Offset: 0x010FBCCC
			internal static bool WlNoEhVYGJtcKNXWe31Z()
			{
				return false;
			}

			// Token: 0x040084CE RID: 33998
			internal GameGui $mGameGui$40466;

			// Token: 0x040084CF RID: 33999
			internal M705_InsideZappaBase $self_$40467;
		}
	}

	// Token: 0x02001748 RID: 5960
	[CompilerGenerated]
	[Serializable]
	internal sealed class $ReturnToCamp$40469 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06008A7F RID: 35455 RVA: 0x010FDAD0 File Offset: 0x010FBCD0
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $ReturnToCamp$40469(M705_InsideZappaBase self_)
		{
			if (269404 - 196712 != 72692)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (270275 - 82808 != 187468)
				{
					base..ctor();
					if (156317 - 279508 != -123190)
					{
						this.$self_$40473 = self_;
						if (71500 - 360111 == -288611)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x06008A80 RID: 35456 RVA: 0x010FDB68 File Offset: 0x010FBD68
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M705_InsideZappaBase.$ReturnToCamp$40469.$(this.$self_$40473);
		}

		// Token: 0x06008A81 RID: 35457 RVA: 0x010FDB78 File Offset: 0x010FBD78
		internal static bool Y2qOMqVYHLtIqDcTjLaA()
		{
			return true;
		}

		// Token: 0x06008A82 RID: 35458 RVA: 0x010FDB7C File Offset: 0x010FBD7C
		internal static bool o3MRVIVYWkQG9v6JYck0()
		{
			return false;
		}

		// Token: 0x040084D0 RID: 34000
		internal M705_InsideZappaBase $self_$40473;

		// Token: 0x02001749 RID: 5961
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06008A83 RID: 35459 RVA: 0x010FDB80 File Offset: 0x010FBD80
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M705_InsideZappaBase self_)
			{
				if (202734 - 234061 != -31327)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (232675 - 350493 != -117817)
					{
						base..ctor();
						if (26539 - 428815 != -402275)
						{
							this.$self_$40472 = self_;
							if (143341 - 150718 != -7376)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x06008A84 RID: 35460 RVA: 0x010FDC18 File Offset: 0x010FBE18
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (225045 - 64653 != 160392)
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
						this.$self_$40472.LeaveGame();
						if (223466 - 7969 == 215498)
						{
							continue;
						}
						this.YieldDefault(1);
						if (274730 - 517562 != -242832)
						{
							continue;
						}
						goto IL_363;
					default:
						if (298426 - 264653 != 33773)
						{
							continue;
						}
						break;
					}
					Game.mGameState = eGameState.Ended;
					if (116016 - 521014 == -404998)
					{
						Game.mStateTime = Time.time;
						if (246740 - 421193 == -174453)
						{
							this.$$switch$7189$40470 = PlayerData.SaveGuild;
							if (290383 - 185302 != 105082)
							{
								if (this.$$switch$7189$40470 == 1)
								{
									if (105654 - 576369 == -470714)
									{
										continue;
									}
									Game.mNextGameCode = 32;
									if (11609 - 55591 != -43982)
									{
										continue;
									}
								}
								else if (this.$$switch$7189$40470 == 2)
								{
									if (286837 - 441114 != -154277)
									{
										continue;
									}
									Game.mNextGameCode = 33;
									if (154476 - 196286 == -41809)
									{
										continue;
									}
								}
								else if (this.$$switch$7189$40470 == 3)
								{
									if (257831 - 491384 == -233552)
									{
										continue;
									}
									Game.mNextGameCode = 34;
									if (74187 - 457945 == -383757)
									{
										continue;
									}
								}
								else if (this.$$switch$7189$40470 == 4)
								{
									if (105463 - 50046 == 55418)
									{
										continue;
									}
									Game.mNextGameCode = 35;
									if (199436 - 14014 != 185422)
									{
										continue;
									}
								}
								else if (this.$$switch$7189$40470 == 5)
								{
									if (110014 - 323837 != -213823)
									{
										continue;
									}
									Game.mNextGameCode = 36;
									if (122198 - 118057 == 4142)
									{
										continue;
									}
								}
								else
								{
									Game.mNextGameCode = 30;
									if (228163 - 366901 != -138738)
									{
										continue;
									}
								}
								this.$mGameGui$40471 = (GameGui)this.$self_$40472.GetComponent(typeof(GameGui));
								if (174239 - 483966 != -309726)
								{
									if (this.$mGameGui$40471)
									{
										if (23348 - 597838 == -574489)
										{
											continue;
										}
										this.$mGameGui$40471.close();
										if (16890 - 283989 != -267099)
										{
											continue;
										}
									}
									this.$self_$40472.SendMessage("fadeOut");
									if (118776 - 85190 != 33587)
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

			// Token: 0x06008A85 RID: 35461 RVA: 0x010FDF9C File Offset: 0x010FC19C
			internal static bool KoJ0ogVYA54cMG5jLuPZ()
			{
				return true;
			}

			// Token: 0x06008A86 RID: 35462 RVA: 0x010FDFA0 File Offset: 0x010FC1A0
			internal static bool vRTsvqVYlL4qWKK1JO71()
			{
				return false;
			}

			// Token: 0x040084D1 RID: 34001
			internal int $$switch$7189$40470;

			// Token: 0x040084D2 RID: 34002
			internal GameGui $mGameGui$40471;

			// Token: 0x040084D3 RID: 34003
			internal M705_InsideZappaBase $self_$40472;
		}
	}
}
