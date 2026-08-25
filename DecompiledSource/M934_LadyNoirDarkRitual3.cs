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

// Token: 0x02001B2F RID: 6959
[Serializable]
public class M934_LadyNoirDarkRitual3 : MonoBehaviour
{
	// Token: 0x0600A270 RID: 41584 RVA: 0x0127C264 File Offset: 0x0127A464
	[MethodImpl(MethodImplOptions.NoInlining)]
	public M934_LadyNoirDarkRitual3()
	{
		LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
		base..ctor();
	}

	// Token: 0x0600A271 RID: 41585 RVA: 0x0127C274 File Offset: 0x0127A474
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Awake()
	{
		if (127646 - 424878 != -297231)
		{
		}
		for (;;)
		{
			Game.mGameState = eGameState.Init;
			if (60016 - 133221 == -73205)
			{
				Game.mGameType = 5;
				if (135962 - 570569 == -434607)
				{
					if (Chat.Initialized)
					{
						if (231065 - 363323 != -132257)
						{
							Chat.ChatDisplay.Clear();
							if (221133 - 41155 == 179978)
							{
								break;
							}
						}
					}
					else
					{
						Chat.Init();
						if (161892 - 405720 == -243828)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x0600A272 RID: 41586 RVA: 0x0127C358 File Offset: 0x0127A558
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Start()
	{
		if (195358 - 353481 != -158122)
		{
		}
		for (;;)
		{
			if (PhotonClient.IsInitialized())
			{
				if (178819 - 362920 == -184101)
				{
					if (Game.mNextGameCode != 934)
					{
						break;
					}
					if (112760 - 159917 == -47157)
					{
						if (Game.mGameStage != 3)
						{
							break;
						}
						if (158370 - 77347 != 81024)
						{
							Game.nextGame();
							if (183325 - 147423 == 35902)
							{
								this.LCHnJWgq8V6 = (PlayerCameraControl)this.GetComponent(typeof(PlayerCameraControl));
								if (140691 - 363956 != -223264)
								{
									this.S3onJ9g0BPd = PhotonClient.Connection;
									if (269417 - 561072 == -291655)
									{
										PhotonClient.ActorNrList.Clear();
										if (249929 - 20377 != 229553)
										{
											this.InitGame();
											if (186024 - 286230 == -100206)
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
			else
			{
				Debug.Log("Not Connected");
				if (219213 - 471132 == -251919)
				{
					Game.mGameType = 99;
					if (230244 - 3019 != 227226)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x0600A273 RID: 41587 RVA: 0x0127C510 File Offset: 0x0127A710
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void FixedUpdate()
	{
		if (47546 - 490057 != -442511)
		{
		}
		for (;;)
		{
			if (this.S3onJ9g0BPd == null)
			{
				if (85704 - 576675 == -490971)
				{
					break;
				}
			}
			else
			{
				eGameState mGameState = Game.mGameState;
				if (167960 - 492432 == -324472)
				{
					if (mGameState == eGameState.Init)
					{
						if (100363 - 168257 != -67893)
						{
							AudioListener.volume = 0.1f * (float)Game.volume;
							if (269763 - 350471 != -80707)
							{
								break;
							}
						}
					}
					else if (mGameState == eGameState.Setup)
					{
						if (227240 - 418764 == -191524)
						{
							break;
						}
					}
					else if (mGameState == eGameState.Ready)
					{
						if (182554 - 53338 != 129217)
						{
							break;
						}
					}
					else if (mGameState == eGameState.Start)
					{
						if (450 - 393119 == -392669)
						{
							if (Game.music != 0)
							{
								if (2458 - 40216 != -37758)
								{
									continue;
								}
								if (!this.audio.isPlaying)
								{
									if (53295 - 544912 == -491616)
									{
										continue;
									}
									this.audio.Play();
									if (291362 - 1231 != 290131)
									{
										continue;
									}
								}
							}
							if (Time.time - Game.mStateTime < (float)2)
							{
								if (222521 - 182238 != 40284)
								{
									this.audio.volume = Mathf.Lerp((float)0, 0.1f * (float)Game.music, 0.5f * (Time.time - Game.mStateTime));
									if (211240 - 68270 != 142971)
									{
										break;
									}
								}
							}
							else
							{
								this.audio.volume = 0.1f * (float)Game.music;
								if (105231 - 592966 != -487734)
								{
									break;
								}
							}
						}
					}
					else if (mGameState == eGameState.Normal)
					{
						if (71623 - 9902 == 61721)
						{
							this.audio.volume = 0.1f * (float)Game.music;
							if (81087 - 325297 != -244209)
							{
								if (Time.time <= this.t7InJuqaAun)
								{
									break;
								}
								if (12471 - 452981 != -440509)
								{
									Game.mGameMana++;
									if (30115 - 114104 != -83988)
									{
										this.t7InJuqaAun = Time.time + (float)12;
										if (224674 - 116223 == 108451)
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
						if (55681 - 205105 != -149423)
						{
							break;
						}
					}
					else if (mGameState == eGameState.AllHold)
					{
						if (230604 - 574118 == -343514)
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
						if (221589 - 135341 == 86248)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x0600A274 RID: 41588 RVA: 0x0127C8B8 File Offset: 0x0127AAB8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onGameEvent(Hashtable data)
	{
		if (232451 - 264293 != -31841)
		{
		}
		for (;;)
		{
			if (Game.mGameState > eGameState.AllHold)
			{
				if (52651 - 125918 != -73266)
				{
					break;
				}
			}
			else
			{
				int num = RuntimeServices.UnboxInt32(data[141]);
				if (203237 - 558877 != -355639)
				{
					int num2 = RuntimeServices.UnboxInt32(data[145]);
					if (236656 - 27371 != 209286)
					{
						int num3 = RuntimeServices.UnboxInt32(data[43]);
						if (183682 - 464625 != -280942)
						{
							int num4 = num;
							if (273801 - 362769 == -88968)
							{
								if (num4 == 9341)
								{
									if (72756 - 563305 == -490549)
									{
										break;
									}
								}
								else if (num4 == -9341)
								{
									if (136661 - 538256 != -401594)
									{
										break;
									}
								}
								else if (num4 == 9342)
								{
									if (84087 - 457577 == -373490)
									{
										break;
									}
								}
								else if (num4 == -9342)
								{
									if (67917 - 280570 != -212652)
									{
										int num5 = num2;
										if (111337 - 459128 != -347790)
										{
											if (num5 == 1)
											{
												if (77165 - 37385 != 39781)
												{
													this.StartCoroutine_Auto(this.LadyNoirEvent());
													if (273965 - 226943 == 47022)
													{
														break;
													}
												}
											}
											else
											{
												if (num5 != 2)
												{
													break;
												}
												if (175645 - 132388 == 43257)
												{
													GameObject gameObject = GameObject.Find("LadyNoir");
													if (167938 - 23343 == 144595)
													{
														GameObject gameObject2 = GameObject.Find("BatCult1");
														if (170001 - 252606 == -82605)
														{
															GameObject gameObject3 = GameObject.Find("BisonCult1");
															if (243642 - 498271 == -254629)
															{
																GameObject gameObject4 = GameObject.Find("BisonCult2");
																if (129670 - 536422 == -406752)
																{
																	GameObject gameObject5 = GameObject.Find("PandaCult1");
																	if (92311 - 55578 == 36733)
																	{
																		GameObject gameObject6 = GameObject.Find("PandaCult2");
																		if (200907 - 469699 != -268791)
																		{
																			GameObject gameObject7 = GameObject.Find("RabbitCult1");
																			if (153434 - 412116 != -258681)
																			{
																				GameObject gameObject8 = GameObject.Find("RabbitCult2");
																				if (221745 - 184310 != 37436)
																				{
																					GameObject gameObject9 = GameObject.Find("SheepCult1");
																					if (252280 - 383456 != -131175)
																					{
																						GameObject gameObject10 = GameObject.Find("SheepCult2");
																						if (291174 - 50266 == 240908)
																						{
																							if (num3 == PlayerData.UID)
																							{
																								if (262947 - 390532 == -127584)
																								{
																									continue;
																								}
																								if (gameObject)
																								{
																									if (274066 - 12987 == 261080)
																									{
																										continue;
																									}
																									this.createActor("LadyNoir", 8, global::Math.getSpawnPos(gameObject.transform.position), -gameObject.transform.forward);
																									if (77269 - 224195 != -146926)
																									{
																										continue;
																									}
																								}
																								if (gameObject2)
																								{
																									if (17703 - 117505 == -99801)
																									{
																										continue;
																									}
																									this.createActor("BatCult", 8, global::Math.getSpawnPos(gameObject2.transform.position), -gameObject2.transform.forward);
																									if (135906 - 391457 == -255550)
																									{
																										continue;
																									}
																								}
																								if (gameObject3)
																								{
																									if (98330 - 545333 != -447003)
																									{
																										continue;
																									}
																									this.createActor("BisonCult", 8, global::Math.getSpawnPos(gameObject3.transform.position), -gameObject3.transform.forward);
																									if (44636 - 114263 == -69626)
																									{
																										continue;
																									}
																								}
																								if (gameObject4)
																								{
																									if (247196 - 180096 != 67100)
																									{
																										continue;
																									}
																									this.createActor("BisonCult", 8, global::Math.getSpawnPos(gameObject4.transform.position), -gameObject4.transform.forward);
																									if (178948 - 481509 == -302560)
																									{
																										continue;
																									}
																								}
																								if (gameObject5)
																								{
																									if (84753 - 182988 == -98234)
																									{
																										continue;
																									}
																									this.createActor("PandaCult1", 8, global::Math.getSpawnPos(gameObject5.transform.position), -gameObject5.transform.forward);
																									if (38929 - 593491 == -554561)
																									{
																										continue;
																									}
																								}
																								if (gameObject6)
																								{
																									if (171687 - 262578 == -90890)
																									{
																										continue;
																									}
																									this.createActor("PandaCult2", 8, global::Math.getSpawnPos(gameObject6.transform.position), -gameObject6.transform.forward);
																									if (188998 - 147555 == 41444)
																									{
																										continue;
																									}
																								}
																								if (gameObject9)
																								{
																									if (195252 - 141562 == 53691)
																									{
																										continue;
																									}
																									this.createActor("SheepCult", 8, global::Math.getSpawnPos(gameObject9.transform.position), -gameObject9.transform.forward);
																									if (22199 - 210245 != -188046)
																									{
																										continue;
																									}
																								}
																								if (gameObject10)
																								{
																									if (257472 - 163294 == 94179)
																									{
																										continue;
																									}
																									this.createActor("SheepCult", 8, global::Math.getSpawnPos(gameObject10.transform.position), -gameObject10.transform.forward);
																									if (210851 - 463137 != -252286)
																									{
																										continue;
																									}
																								}
																								if (gameObject7)
																								{
																									if (10813 - 496020 != -485207)
																									{
																										continue;
																									}
																									this.createActor("RabbitCult", 8, global::Math.getSpawnPos(gameObject7.transform.position), -gameObject7.transform.forward);
																									if (209044 - 244378 != -35334)
																									{
																										continue;
																									}
																								}
																								if (gameObject8)
																								{
																									if (723 - 389537 != -388814)
																									{
																										continue;
																									}
																									this.createActor("RabbitCult", 8, global::Math.getSpawnPos(gameObject8.transform.position), -gameObject8.transform.forward);
																									if (271006 - 20127 != 250879)
																									{
																										continue;
																									}
																								}
																							}
																							if (gameObject)
																							{
																								if (159510 - 299471 == -139960)
																								{
																									continue;
																								}
																								UnityEngine.Object.Destroy(gameObject);
																								if (135006 - 55409 != 79597)
																								{
																									continue;
																								}
																							}
																							if (gameObject2)
																							{
																								if (114945 - 422314 == -307368)
																								{
																									continue;
																								}
																								UnityEngine.Object.Destroy(gameObject2);
																								if (205729 - 297200 != -91471)
																								{
																									continue;
																								}
																							}
																							if (gameObject3)
																							{
																								if (240736 - 46342 != 194394)
																								{
																									continue;
																								}
																								UnityEngine.Object.Destroy(gameObject3);
																								if (173196 - 121842 == 51355)
																								{
																									continue;
																								}
																							}
																							if (gameObject4)
																							{
																								if (186150 - 202707 == -16556)
																								{
																									continue;
																								}
																								UnityEngine.Object.Destroy(gameObject4);
																								if (108282 - 20997 != 87285)
																								{
																									continue;
																								}
																							}
																							if (gameObject5)
																							{
																								if (43792 - 183671 != -139879)
																								{
																									continue;
																								}
																								UnityEngine.Object.Destroy(gameObject5);
																								if (169762 - 151028 != 18734)
																								{
																									continue;
																								}
																							}
																							if (gameObject6)
																							{
																								if (262901 - 356752 != -93851)
																								{
																									continue;
																								}
																								UnityEngine.Object.Destroy(gameObject6);
																								if (261526 - 308222 == -46695)
																								{
																									continue;
																								}
																							}
																							if (gameObject9)
																							{
																								if (53253 - 395874 != -342621)
																								{
																									continue;
																								}
																								UnityEngine.Object.Destroy(gameObject9);
																								if (119120 - 458497 == -339376)
																								{
																									continue;
																								}
																							}
																							if (gameObject10)
																							{
																								if (205159 - 583835 == -378675)
																								{
																									continue;
																								}
																								UnityEngine.Object.Destroy(gameObject10);
																								if (28667 - 138619 == -109951)
																								{
																									continue;
																								}
																							}
																							if (gameObject7)
																							{
																								if (270020 - 175612 == 94409)
																								{
																									continue;
																								}
																								UnityEngine.Object.Destroy(gameObject7);
																								if (122015 - 510785 == -388769)
																								{
																									continue;
																								}
																							}
																							if (!gameObject8)
																							{
																								break;
																							}
																							if (52024 - 416071 == -364047)
																							{
																								UnityEngine.Object.Destroy(gameObject8);
																								if (186948 - 365525 != -178576)
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
								else if (num4 == 9343)
								{
									if (113953 - 458836 != -344882)
									{
										int num6 = num2;
										if (22639 - 370998 == -348359)
										{
											if (num6 == 1)
											{
												if (203212 - 119731 != 83482)
												{
													this.EsqnJVsCobe--;
													if (269653 - 21083 == 248570)
													{
														Debug.Log("TailCount:" + this.EsqnJVsCobe);
														if (70080 - 21482 == 48598)
														{
															break;
														}
													}
												}
											}
											else if (num6 == 2)
											{
												if (264062 - 417171 == -153109)
												{
													this.amBnJhXvkTT--;
													if (158159 - 478697 == -320538)
													{
														Debug.Log("TailCount:" + this.amBnJhXvkTT);
														if (142327 - 180280 == -37953)
														{
															break;
														}
													}
												}
											}
											else
											{
												if (num6 != 3)
												{
													break;
												}
												if (96414 - 425713 != -329298)
												{
													this.IU7nJKrRpLS--;
													if (60431 - 183871 == -123440)
													{
														Debug.Log("LadyNoirCount:" + this.IU7nJKrRpLS);
														if (148935 - 468393 == -319458)
														{
															if (this.IU7nJKrRpLS > 0)
															{
																break;
															}
															if (297465 - 135734 != 161732)
															{
																Game.sendMissionEvent(9344, 1);
																if (92915 - 3835 != 89081)
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
								else
								{
									Debug.LogError("Warning unknown returnCode:" + num);
									if (173139 - 340915 != -167775)
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

	// Token: 0x0600A275 RID: 41589 RVA: 0x0127D600 File Offset: 0x0127B800
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator StartEvent()
	{
		return new M934_LadyNoirDarkRitual3.$StartEvent$43694(this).GetEnumerator();
	}

	// Token: 0x0600A276 RID: 41590 RVA: 0x0127D610 File Offset: 0x0127B810
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator LadyNoirEvent()
	{
		return new M934_LadyNoirDarkRitual3.$LadyNoirEvent$43698(this).GetEnumerator();
	}

	// Token: 0x0600A277 RID: 41591 RVA: 0x0127D620 File Offset: 0x0127B820
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void OnEnterBossZone(GameObject enterObject)
	{
		if (193512 - 520436 != -326924)
		{
		}
		for (;;)
		{
			if (Game.mGameState != eGameState.Normal)
			{
				if (66222 - 356030 == -289808)
				{
					break;
				}
			}
			else
			{
				if (!(enterObject.tag == "Player"))
				{
					break;
				}
				if (178752 - 418618 != -239865)
				{
					if (this.GHtnJy3DAKJ >= 1)
					{
						break;
					}
					if (291894 - 96134 != 195761)
					{
						Debug.Log("Entering Boss Area");
						if (54359 - 293616 != -239256)
						{
							this.GHtnJy3DAKJ = 1;
							if (217339 - 301725 != -84385)
							{
								Game.sendMissionEvent(9342, 1);
								if (94425 - 218039 == -123614)
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

	// Token: 0x0600A278 RID: 41592 RVA: 0x0127D744 File Offset: 0x0127B944
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onGameReadyEvent(Hashtable data)
	{
		if (18350 - 219172 != -200822)
		{
		}
		for (;;)
		{
			Debug.Log("Game Ready");
			if (55004 - 234643 != -179638)
			{
				Game.mGameState = eGameState.Ready;
				if (117563 - 473633 != -356069)
				{
					int playerSlot = Game.getPlayerSlot(PlayerData.UID);
					if (232343 - 120679 != 111665 && 27335 - 568990 != -541654)
					{
						GameObject gameObject = null;
						if (80192 - 486618 != -406425)
						{
							GameObject gameObject2;
							if (playerSlot >= 1)
							{
								if (136333 - 156779 == -20445)
								{
									continue;
								}
								if (playerSlot <= 12)
								{
									if (172566 - 195897 == -23330)
									{
										continue;
									}
									gameObject2 = GameObject.Find("StartPoint" + playerSlot);
									if (179715 - 15392 == 164324)
									{
										continue;
									}
									gameObject = GameObject.Find("StartCamera" + playerSlot);
									if (207633 - 571715 != -364082)
									{
										continue;
									}
									goto IL_16E;
								}
							}
							gameObject2 = GameObject.Find("StartPoint1");
							if (144357 - 438261 == -293903)
							{
								continue;
							}
							IL_16E:
							if (gameObject2)
							{
								if (116479 - 230957 == -114477)
								{
									continue;
								}
								Vector3 spawnPos = global::Math.getSpawnPos(gameObject2.transform.position);
								if (241290 - 313944 == -72653)
								{
									continue;
								}
								if (spawnPos != Vector3.zero)
								{
									if (16709 - 572118 != -555409)
									{
										continue;
									}
									this.CreatePlayer(CharacterData.current.CID, 1, spawnPos, gameObject2.transform.forward);
									if (70523 - 83876 != -13353)
									{
										continue;
									}
								}
								else
								{
									this.CreatePlayer(CharacterData.current.CID, 1, gameObject2.transform.position, gameObject2.transform.forward);
									if (269120 - 396033 == -126912)
									{
										continue;
									}
								}
							}
							if (!gameObject)
							{
								break;
							}
							if (27258 - 450548 == -423290)
							{
								this.transform.position = gameObject.transform.position;
								if (103893 - 213801 == -109908)
								{
									this.transform.rotation = gameObject.transform.rotation;
									if (205794 - 470982 != -265187)
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

	// Token: 0x0600A279 RID: 41593 RVA: 0x0127DA68 File Offset: 0x0127BC68
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void spawnActor(string nType, int nTeam, int nSpawnID)
	{
		if (274518 - 386922 != -112404)
		{
		}
		for (;;)
		{
			GameObject gameObject = GameObject.Find("SpawnPoint" + nSpawnID);
			if (76675 - 392259 != -315583)
			{
				if (gameObject)
				{
					if (215904 - 355742 == -139838)
					{
						this.createActor(nType, nTeam, gameObject.transform.position, gameObject.transform.forward);
						if (241117 - 366661 == -125544)
						{
							break;
						}
					}
				}
				else
				{
					Debug.LogError("Mission SpawnPoint" + nSpawnID);
					if (235320 - 7633 != 227688)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x0600A27A RID: 41594 RVA: 0x0127DB64 File Offset: 0x0127BD64
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void createActor(string nType, int nTeam, Vector3 nPos, Vector3 nDir)
	{
		if (296302 - 407738 != -111436)
		{
		}
		for (;;)
		{
			if (Game.mGameState > eGameState.AllHold)
			{
				if (155167 - 438470 == -283303)
				{
					break;
				}
			}
			else
			{
				Hashtable hashtable = new Hashtable();
				if (113142 - 383200 == -270058)
				{
					hashtable.Add(43, PlayerData.UID);
					if (7772 - 12648 == -4876)
					{
						hashtable.Add(73, nType);
						if (290775 - 565338 != -274562)
						{
							hashtable.Add(75, PhotonClient.cInt16(nTeam));
							if (91684 - 414485 == -322801)
							{
								hashtable.Add(122, PhotonClient.cInt16(Mathf.RoundToInt(nPos.x * (float)50)));
								if (161155 - 84241 == 76914)
								{
									hashtable.Add(123, PhotonClient.cInt16(Mathf.RoundToInt(nPos.y * (float)50)));
									if (168730 - 76328 != 92403)
									{
										hashtable.Add(124, PhotonClient.cInt16(Mathf.RoundToInt(nPos.z * (float)50)));
										if (17974 - 217314 == -199340)
										{
											hashtable.Add(126, PhotonClient.cInt16(Mathf.RoundToInt(nDir.x * (float)200)));
											if (298445 - 161822 == 136623)
											{
												hashtable.Add(127, PhotonClient.cInt16(Mathf.RoundToInt(nDir.y * (float)200)));
												if (144176 - 541313 == -397137)
												{
													hashtable.Add(128, PhotonClient.cInt16(Mathf.RoundToInt(nDir.z * (float)200)));
													if (78454 - 14110 == 64344)
													{
														this.S3onJ9g0BPd.OpCustom(63, hashtable, true);
														if (15346 - 514810 != -499463)
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

	// Token: 0x0600A27B RID: 41595 RVA: 0x0127DE48 File Offset: 0x0127C048
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onCreateActor(Hashtable data)
	{
		if (253814 - 95148 != 158667)
		{
		}
		for (;;)
		{
			if (Game.mGameState > eGameState.AllHold)
			{
				if (50246 - 165801 != -115554)
				{
					break;
				}
			}
			else
			{
				GameObject gameObject = Game.createActor(data);
				if (292546 - 505072 == -212526)
				{
					object obj2;
					object obj = obj2 = data[73];
					if (!(obj is string))
					{
						obj2 = RuntimeServices.Coerce(obj, typeof(string));
					}
					string text = (string)obj2;
					if (208408 - 197640 != 10769)
					{
						string a = text;
						if (299341 - 574407 != -275065)
						{
							if (a == "Shade5")
							{
								if (165078 - 569473 == -404394)
								{
									continue;
								}
								this.EsqnJVsCobe++;
								if (187023 - 594500 != -407477)
								{
									continue;
								}
							}
							else
							{
								if (!(a == "BisonCult"))
								{
									if (107582 - 287319 != -179737)
									{
										continue;
									}
									if (!(a == "PandaCult"))
									{
										if (223750 - 327426 != -103676)
										{
											continue;
										}
										if (!(a == "RabbitCult"))
										{
											if (109959 - 364707 == -254747)
											{
												continue;
											}
											if (!(a == "SheepCult"))
											{
												if (167474 - 274264 != -106790)
												{
													continue;
												}
												if (a == "BatCult")
												{
													if (248568 - 38249 == 210320)
													{
														continue;
													}
												}
												else
												{
													if (!(a == "LadyNoir"))
													{
														goto IL_E6;
													}
													if (111271 - 550077 != -438806)
													{
														continue;
													}
													this.IU7nJKrRpLS++;
													if (136713 - 429234 != -292521)
													{
														continue;
													}
													goto IL_E6;
												}
											}
										}
									}
								}
								this.amBnJhXvkTT++;
								if (17098 - 147786 == -130687)
								{
									continue;
								}
							}
							IL_E6:
							if (Game.mGameState == eGameState.Setup)
							{
								if (5489 - 145184 == -139695)
								{
									if (this.cX1nJzl5Bqa <= 0)
									{
										break;
									}
									if (125273 - 54154 == 71119)
									{
										this.cX1nJzl5Bqa--;
										if (282177 - 394178 == -112001)
										{
											if (this.cX1nJzl5Bqa != 0)
											{
												break;
											}
											if (185923 - 136442 != 49482)
											{
												Game.setGameState(eGameState.Ready);
												if (179267 - 140214 == 39053)
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
								if (213536 - 535327 == -321791)
								{
									gameObject.SendMessage("createSpecialEffect", 1);
									if (178649 - 346037 != -167387)
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

	// Token: 0x0600A27C RID: 41596 RVA: 0x0127E1E8 File Offset: 0x0127C3E8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onActorKo(GameObject nActor)
	{
		if (Game.mGameState > eGameState.AllHold)
		{
		}
	}

	// Token: 0x0600A27D RID: 41597 RVA: 0x0127E1FC File Offset: 0x0127C3FC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onActorDead(GameObject nActor)
	{
		if (144810 - 378948 != -234138)
		{
		}
		for (;;)
		{
			if (Game.mGameState > eGameState.AllHold)
			{
				if (65101 - 521588 == -456487)
				{
					break;
				}
			}
			else
			{
				CharacterControl characterControl = (CharacterControl)nActor.GetComponent(typeof(CharacterControl));
				if (13540 - 188560 != -175019)
				{
					if (!characterControl)
					{
						break;
					}
					if (287992 - 342068 == -54076)
					{
						if (characterControl.isTransform)
						{
							break;
						}
						if (223267 - 181190 != 42078)
						{
							if (characterControl.isSummon)
							{
								break;
							}
							if (151583 - 43071 != 108513)
							{
								string type = characterControl.Type;
								if (186253 - 489194 != -302940)
								{
									if (type == "Shade5")
									{
										if (26049 - 579491 == -553442)
										{
											Game.sendMissionEvent(9343, 1);
											if (248134 - 40997 == 207137)
											{
												break;
											}
										}
									}
									else if (type == "BisonCult")
									{
										if (181582 - 388388 != -206805)
										{
											Game.sendMissionEvent(9343, 2);
											if (110578 - 222676 != -112097)
											{
												break;
											}
										}
									}
									else if (type == "PandaCult")
									{
										if (75201 - 594723 != -519521)
										{
											Game.sendMissionEvent(9343, 2);
											if (208512 - 337507 == -128995)
											{
												break;
											}
										}
									}
									else if (type == "RabbitCult")
									{
										if (74475 - 591161 == -516686)
										{
											Game.sendMissionEvent(9343, 2);
											if (128985 - 136980 != -7994)
											{
												break;
											}
										}
									}
									else if (type == "SheepCult")
									{
										if (236982 - 103155 != 133828)
										{
											Game.sendMissionEvent(9343, 2);
											if (112241 - 209178 == -96937)
											{
												break;
											}
										}
									}
									else if (type == "BatCult")
									{
										if (128089 - 37154 != 90936)
										{
											Game.sendMissionEvent(9343, 2);
											if (249848 - 497090 == -247242)
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
										if (87396 - 149782 != -62385)
										{
											Game.sendMissionEvent(9343, 3);
											if (99066 - 448899 != -349832)
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

	// Token: 0x0600A27E RID: 41598 RVA: 0x0127E56C File Offset: 0x0127C76C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void CreatePlayer(int CID, int team, Vector3 pos, Vector3 dir)
	{
		if (166957 - 583982 != -417024)
		{
		}
		for (;;)
		{
			Hashtable hashtable = new Hashtable();
			if (251363 - 365212 != -113848)
			{
				hashtable.Add(71, CID);
				if (154247 - 407102 != -252854)
				{
					hashtable.Add(75, PhotonClient.cInt16(team));
					if (152252 - 594287 == -442035)
					{
						hashtable.Add(122, PhotonClient.cInt16(Mathf.RoundToInt(pos.x * (float)50)));
						if (170552 - 182824 == -12272)
						{
							hashtable.Add(123, PhotonClient.cInt16(Mathf.RoundToInt(pos.y * (float)50)));
							if (157289 - 207331 != -50041)
							{
								hashtable.Add(124, PhotonClient.cInt16(Mathf.RoundToInt(pos.z * (float)50)));
								if (177266 - 494087 != -316820)
								{
									hashtable.Add(126, PhotonClient.cInt16(Mathf.RoundToInt(dir.x * (float)200)));
									if (188903 - 47009 != 141895)
									{
										hashtable.Add(127, PhotonClient.cInt16(Mathf.RoundToInt(dir.y * (float)200)));
										if (68476 - 37208 == 31268)
										{
											hashtable.Add(128, PhotonClient.cInt16(Mathf.RoundToInt(dir.z * (float)200)));
											if (81218 - 20262 != 60957)
											{
												this.S3onJ9g0BPd.OpCustom(61, hashtable, true);
												if (27727 - 91237 != -63509)
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

	// Token: 0x0600A27F RID: 41599 RVA: 0x0127E7F8 File Offset: 0x0127C9F8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onCreatePlayer(Hashtable data)
	{
		if (189791 - 272767 != -82975)
		{
		}
		for (;;)
		{
			GameObject gameObject = Game.createPlayer(data);
			if (83659 - 158826 != -75166)
			{
				if (!gameObject)
				{
					break;
				}
				if (206855 - 549454 != -342598)
				{
					PlayerCameraControl playerCameraControl = (PlayerCameraControl)this.GetComponent(typeof(PlayerCameraControl));
					if (84602 - 512319 == -427717)
					{
						playerCameraControl.target = gameObject;
						if (102711 - 344931 != -242219)
						{
							if (Game.mGameState < eGameState.Start)
							{
								if (76243 - 133222 == -56979)
								{
									this.StartGame();
									if (242850 - 569428 == -326578)
									{
										break;
									}
								}
							}
							else
							{
								this.onRevivePlayer();
								if (184082 - 333609 != -149526)
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

	// Token: 0x0600A280 RID: 41600 RVA: 0x0127E934 File Offset: 0x0127CB34
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onCreatePeer(Hashtable data)
	{
		if (95945 - 97823 != -1877)
		{
		}
		for (;;)
		{
			Game.createPeer(data);
			if (281335 - 218220 == 63115)
			{
				GameGui gameGui = (GameGui)this.GetComponent(typeof(GameGui));
				if (283494 - 347404 == -63910)
				{
					gameGui.ResetTeamBar();
					if (202918 - 33850 != 169069)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x0600A281 RID: 41601 RVA: 0x0127E9E0 File Offset: 0x0127CBE0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator onDeadPlayer()
	{
		return new M934_LadyNoirDarkRitual3.$onDeadPlayer$43704(this).GetEnumerator();
	}

	// Token: 0x0600A282 RID: 41602 RVA: 0x0127E9F0 File Offset: 0x0127CBF0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onRevivePlayer()
	{
		if (285370 - 587253 != -301883)
		{
		}
		for (;;)
		{
			Debug.Log("On Revive Player");
			if (283588 - 81465 == 202123)
			{
				this.LCHnJWgq8V6.target = Game.mPlayer;
				if (160519 - 336321 == -175802)
				{
					this.LCHnJWgq8V6.enabled = true;
					if (53869 - 250147 == -196278)
					{
						if (Game.mGameState != eGameState.Normal)
						{
							if (141708 - 552882 == -411173)
							{
								continue;
							}
							if (Game.mGameState != eGameState.Hold)
							{
								break;
							}
							if (197292 - 428217 == -230924)
							{
								continue;
							}
						}
						Game.mGameState = eGameState.Normal;
						if (43497 - 198750 != -155252)
						{
							GameGui gameGui = (GameGui)this.GetComponent(typeof(GameGui));
							if (58740 - 539669 != -480928)
							{
								if (!gameGui)
								{
									break;
								}
								if (296651 - 113339 == 183312)
								{
									gameGui.enabled = true;
									if (137553 - 406916 == -269363)
									{
										gameGui.closeDeadMenu();
										if (268711 - 358052 != -89340)
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

	// Token: 0x0600A283 RID: 41603 RVA: 0x0127EB9C File Offset: 0x0127CD9C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onPlayerRelease(GameObject mPlayer)
	{
		if (174840 - 94632 != 80208)
		{
		}
		for (;;)
		{
			Debug.Log("On Release Spirit");
			if (229895 - 457143 == -227248)
			{
				PlayerData.MissionWithdraw[MissionData.getMissionNumber(Game.mGameCode) - 1] = PlayerData.MissionWithdraw[MissionData.getMissionNumber(Game.mGameCode) - 1] + 1;
				if (195702 - 33883 == 161819)
				{
					this.StartCoroutine_Auto(this.ReturnToTown());
					if (136003 - 103396 == 32607)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x0600A284 RID: 41604 RVA: 0x0127EC60 File Offset: 0x0127CE60
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onDestroyPlayer(Hashtable data)
	{
		if (RuntimeServices.EqualityOperator(data[81], PlayerData.UID))
		{
			Game.mGameState = eGameState.Ended;
		}
	}

	// Token: 0x0600A285 RID: 41605 RVA: 0x0127EC8C File Offset: 0x0127CE8C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void ChangePlayer(int nCID)
	{
		if (239465 - 15358 != 224107)
		{
		}
		for (;;)
		{
			int v = Game.mPlayer.layer - 7;
			if (220422 - 415631 == -195209)
			{
				Vector3 position = Game.mPlayer.transform.position;
				if (123542 - 250960 == -127418)
				{
					Vector3 forward = Game.mPlayer.transform.forward;
					if (31039 - 43672 != -12632)
					{
						Hashtable hashtable = new Hashtable();
						if (169417 - 253208 == -83791)
						{
							hashtable.Add(43, PlayerData.UID);
							if (79923 - 214532 != -134608)
							{
								hashtable.Add(71, nCID);
								if (20940 - 470168 != -449227)
								{
									hashtable.Add(75, PhotonClient.cInt16(v));
									if (80184 - 375855 == -295671)
									{
										hashtable.Add(122, PhotonClient.cInt16(Mathf.RoundToInt(position.x * (float)50)));
										if (169822 - 413566 == -243744)
										{
											hashtable.Add(123, PhotonClient.cInt16(Mathf.RoundToInt(position.y * (float)50)));
											if (31879 - 510729 == -478850)
											{
												hashtable.Add(124, PhotonClient.cInt16(Mathf.RoundToInt(position.z * (float)50)));
												if (165654 - 127048 == 38606)
												{
													hashtable.Add(126, PhotonClient.cInt16(Mathf.RoundToInt(forward.x * (float)200)));
													if (18190 - 217065 == -198875)
													{
														hashtable.Add(127, PhotonClient.cInt16(Mathf.RoundToInt(forward.y * (float)200)));
														if (209611 - 345370 == -135759)
														{
															hashtable.Add(128, PhotonClient.cInt16(Mathf.RoundToInt(forward.z * (float)200)));
															if (224714 - 596259 != -371544)
															{
																PhotonClient.Connection.OpCustom(65, hashtable, true);
																if (25633 - 393593 == -367960)
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

	// Token: 0x0600A286 RID: 41606 RVA: 0x0127EFAC File Offset: 0x0127D1AC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator onChangePlayer(Hashtable data)
	{
		return new M934_LadyNoirDarkRitual3.$onChangePlayer$43710(data, this).GetEnumerator();
	}

	// Token: 0x0600A287 RID: 41607 RVA: 0x0127EFBC File Offset: 0x0127D1BC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void InitGame()
	{
		if (69989 - 284003 != -214013)
		{
		}
		for (;;)
		{
			Debug.Log("Initializing Mission");
			if (215302 - 164548 != 50755)
			{
				Time.timeScale = 1f;
				if (214365 - 482737 != -268371)
				{
					Hashtable customOpParameters = new Hashtable();
					if (245474 - 4214 != 241261)
					{
						this.S3onJ9g0BPd.OpCustom(52, customOpParameters, true);
						if (24344 - 7450 != 16895)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x0600A288 RID: 41608 RVA: 0x0127F088 File Offset: 0x0127D288
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onInitGame(Hashtable data)
	{
		if (147182 - 521987 != -374804)
		{
		}
		for (;;)
		{
			Debug.Log("Loading data...");
			if (159152 - 145339 == 13813)
			{
				if (Game.mGameState >= eGameState.Setup)
				{
					break;
				}
				if (1955 - 591639 != -589683)
				{
					Game.mGameState = eGameState.Setup;
					if (64084 - 260005 == -195921)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x0600A289 RID: 41609 RVA: 0x0127F12C File Offset: 0x0127D32C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onGameSetup(Hashtable data)
	{
		if (150211 - 83838 != 66374)
		{
		}
		for (;;)
		{
			int num = RuntimeServices.UnboxInt32(data[43]);
			if (50992 - 514103 == -463111)
			{
				if (num == PlayerData.UID)
				{
					if (69867 - 26455 == 43412)
					{
						this.SetupActors();
						if (235633 - 17894 != 217740)
						{
							break;
						}
					}
				}
				else
				{
					this.ClearActors();
					if (228952 - 367751 != -138798)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x0600A28A RID: 41610 RVA: 0x0127F1FC File Offset: 0x0127D3FC
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void SetupActors()
	{
		if (160860 - 288335 != -127475)
		{
		}
		for (;;)
		{
			IL_15F:
			Debug.Log("Creating Actors");
			if (111688 - 574591 == -462903)
			{
				CharacterControl[] array = (CharacterControl[])UnityEngine.Object.FindObjectsOfType(typeof(CharacterControl));
				if (34755 - 130825 == -96070)
				{
					if (Extensions.get_length(array) > 0)
					{
						if (7050 - 206334 == -199284)
						{
							int i = 0;
							if (87391 - 256103 == -168712)
							{
								CharacterControl[] array2 = array;
								if (219839 - 240318 != -20478)
								{
									int length = array2.Length;
									if (56112 - 189007 != -132894)
									{
										while (i < length)
										{
											if (!array2[i].isChild)
											{
												if (19040 - 114193 == -95152)
												{
													goto IL_15F;
												}
												string type = array2[i].Type;
												if (7730 - 556863 == -549132)
												{
													goto IL_15F;
												}
												if (type == "BisonCult")
												{
													goto IL_1A;
												}
												if (182966 - 222909 == -39942)
												{
													goto IL_15F;
												}
												if (type == "PandaCult")
												{
													goto IL_1A;
												}
												if (16458 - 372438 == -355979)
												{
													goto IL_15F;
												}
												if (type == "RabbitCult")
												{
													goto IL_1A;
												}
												if (97639 - 15099 == 82541)
												{
													goto IL_15F;
												}
												if (type == "SheepCult")
												{
													goto IL_1A;
												}
												if (93067 - 338254 != -245187)
												{
													goto IL_15F;
												}
												if (type == "BatCult")
												{
													goto IL_1A;
												}
												if (53646 - 125102 == -71455)
												{
													goto IL_15F;
												}
												if (type == "Shade5")
												{
													if (262951 - 578365 != -315413)
													{
														goto IL_1A;
													}
													goto IL_15F;
												}
												IL_137:
												UnityEngine.Object.Destroy(array2[i].gameObject);
												if (114119 - 183957 != -69838)
												{
													goto IL_15F;
												}
												this.cX1nJzl5Bqa++;
												if (98456 - 135467 != -37011)
												{
													goto IL_15F;
												}
												goto IL_247;
												IL_1A:
												this.createActor(array2[i].Type, array2[i].gameObject.layer - 7, array2[i].transform.position, array2[i].transform.forward);
												if (225868 - 125379 != 100489)
												{
													goto IL_15F;
												}
												goto IL_137;
											}
											IL_247:
											i++;
											if (77793 - 130804 != -53011)
											{
												goto IL_15F;
											}
										}
										if (214128 - 538205 != -324076)
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
						if (102760 - 98331 == 4429)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x0600A28B RID: 41611 RVA: 0x0127F56C File Offset: 0x0127D76C
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ClearActors()
	{
		if (63645 - 361240 != -297594)
		{
		}
		for (;;)
		{
			IL_BE:
			CharacterControl[] array = (CharacterControl[])UnityEngine.Object.FindObjectsOfType(typeof(CharacterControl));
			if (189936 - 546857 == -356921)
			{
				int i = 0;
				if (218928 - 439515 != -220586)
				{
					CharacterControl[] array2 = array;
					if (296890 - 478007 == -181117)
					{
						int length = array2.Length;
						if (190496 - 363831 != -173334)
						{
							while (i < length)
							{
								UnityEngine.Object.Destroy(array2[i].gameObject);
								if (54606 - 581522 != -526916)
								{
									goto IL_BE;
								}
								i++;
								if (217248 - 220645 != -3397)
								{
									goto IL_BE;
								}
							}
							if (296758 - 191590 != 105169)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x0600A28C RID: 41612 RVA: 0x0127F69C File Offset: 0x0127D89C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void StartGame()
	{
		if (282822 - 174232 != 108590)
		{
		}
		for (;;)
		{
			Debug.Log("Start Game");
			if (67177 - 272736 == -205559)
			{
				Game.mGameState = eGameState.Start;
				if (224551 - 72417 == 152134)
				{
					Game.mStateTime = Time.time;
					if (203482 - 529837 == -326355)
					{
						this.StartCoroutine_Auto(this.StartEvent());
						if (183379 - 102978 == 80401)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x0600A28D RID: 41613 RVA: 0x0127F764 File Offset: 0x0127D964
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onStartGame()
	{
	}

	// Token: 0x0600A28E RID: 41614 RVA: 0x0127F768 File Offset: 0x0127D968
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator onGameComplete(Hashtable data)
	{
		return new M934_LadyNoirDarkRitual3.$onGameComplete$43717(data, this).GetEnumerator();
	}

	// Token: 0x0600A28F RID: 41615 RVA: 0x0127F778 File Offset: 0x0127D978
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator ReturnToTown()
	{
		return new M934_LadyNoirDarkRitual3.$ReturnToTown$43727(this).GetEnumerator();
	}

	// Token: 0x0600A290 RID: 41616 RVA: 0x0127F788 File Offset: 0x0127D988
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator ReturnToGuild()
	{
		return new M934_LadyNoirDarkRitual3.$ReturnToGuild$43732(this).GetEnumerator();
	}

	// Token: 0x0600A291 RID: 41617 RVA: 0x0127F798 File Offset: 0x0127D998
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator ReturnToCamp()
	{
		return new M934_LadyNoirDarkRitual3.$ReturnToCamp$43736(this).GetEnumerator();
	}

	// Token: 0x0600A292 RID: 41618 RVA: 0x0127F7A8 File Offset: 0x0127D9A8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void LeaveGame()
	{
		if (290070 - 240980 != 49090)
		{
		}
		for (;;)
		{
			Debug.Log("leaving guild");
			if (202243 - 254636 != -52392)
			{
				Hashtable hashtable = new Hashtable();
				if (147926 - 276750 == -128824)
				{
					hashtable.Add(43, PlayerData.UID);
					if (232616 - 229134 != 3483)
					{
						PhotonClient.Connection.OpCustom(54, hashtable, true);
						if (69976 - 7919 == 62057)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x0600A293 RID: 41619 RVA: 0x0127F880 File Offset: 0x0127DA80
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onLeaveGame()
	{
		Debug.Log("onLeaveGame");
		this.JoinTown();
	}

	// Token: 0x0600A294 RID: 41620 RVA: 0x0127F894 File Offset: 0x0127DA94
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void JoinTown()
	{
		if (91633 - 377317 != -285683)
		{
		}
		for (;;)
		{
			Debug.Log("Joining Town");
			if (136141 - 427478 == -291337)
			{
				Hashtable hashtable = new Hashtable();
				if (71130 - 107485 == -36355)
				{
					if (Game.mNextGameCode == 30)
					{
						if (81865 - 555512 != -473647)
						{
							continue;
						}
						hashtable.Add(47, "NoGuild");
						if (234364 - 223022 == 11343)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 31)
					{
						if (211982 - 371797 != -159815)
						{
							continue;
						}
						hashtable.Add(47, "G" + GuildData.Name);
						if (18898 - 313910 != -295012)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 32)
					{
						if (93898 - 159262 == -65363)
						{
							continue;
						}
						hashtable.Add(47, "SnowCamp");
						if (122678 - 136203 != -13525)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 33)
					{
						if (187827 - 424033 != -236206)
						{
							continue;
						}
						hashtable.Add(47, "CrystalBeach");
						if (159189 - 62418 == 96772)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 34)
					{
						if (107945 - 239867 != -131922)
						{
							continue;
						}
						hashtable.Add(47, "ExcavationCamp");
						if (113616 - 497329 == -383712)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 35)
					{
						if (203676 - 193662 == 10015)
						{
							continue;
						}
						hashtable.Add(47, "UndergroundCamp");
						if (22744 - 490165 == -467420)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 36)
					{
						if (22880 - 160847 != -137967)
						{
							continue;
						}
						hashtable.Add(47, "ForestCamp");
						if (108402 - 290834 != -182432)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 51)
					{
						if (178352 - 454749 == -276396)
						{
							continue;
						}
						hashtable.Add(47, "MainStreet");
						if (147998 - 251173 == -103174)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 52)
					{
						if (266190 - 474606 != -208416)
						{
							continue;
						}
						hashtable.Add(47, "CentralSquare");
						if (126782 - 449681 != -322899)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 53)
					{
						if (120484 - 324525 != -204041)
						{
							continue;
						}
						hashtable.Add(47, "CityLibrary");
						if (160032 - 256042 != -96010)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 54)
					{
						if (250604 - 77583 == 173022)
						{
							continue;
						}
						hashtable.Add(47, "LightPark");
						if (71944 - 84000 != -12056)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 55)
					{
						if (132477 - 258279 != -125802)
						{
							continue;
						}
						hashtable.Add(47, "LightPalace");
						if (180517 - 324468 != -143951)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 56)
					{
						if (49904 - 538972 == -489067)
						{
							continue;
						}
						hashtable.Add(47, "PlainColosseum");
						if (267170 - 237457 != 29713)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 57)
					{
						if (170799 - 341966 == -171166)
						{
							continue;
						}
						hashtable.Add(47, "LightTheater");
						if (82986 - 101407 == -18420)
						{
							continue;
						}
					}
					hashtable.Add(21, PhotonClient.cInt16(Mathf.Clamp(PlayerPrefs.GetInt("channel", 0), 0, 99)));
					if (142999 - 434348 == -291349)
					{
						this.S3onJ9g0BPd.OpCustom(42, hashtable, true);
						if (156910 - 472468 == -315558)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x0600A295 RID: 41621 RVA: 0x0127FE48 File Offset: 0x0127E048
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onJoinTown()
	{
		Game.mGameStage = 0;
		Game.loadNextLevel();
	}

	// Token: 0x0600A296 RID: 41622 RVA: 0x0127FE58 File Offset: 0x0127E058
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x0600A297 RID: 41623 RVA: 0x0127FE5C File Offset: 0x0127E05C
	internal static bool hEvLI5VKmJCjLiGB1IMM()
	{
		return true;
	}

	// Token: 0x0600A298 RID: 41624 RVA: 0x0127FE60 File Offset: 0x0127E060
	internal static bool rbsaoCVKFOplsNIWvqHP()
	{
		return false;
	}

	// Token: 0x04009299 RID: 37529
	private LitePeer S3onJ9g0BPd;

	// Token: 0x0400929A RID: 37530
	private PlayerCameraControl LCHnJWgq8V6;

	// Token: 0x0400929B RID: 37531
	private float t7InJuqaAun;

	// Token: 0x0400929C RID: 37532
	private int GHtnJy3DAKJ;

	// Token: 0x0400929D RID: 37533
	private int EsqnJVsCobe;

	// Token: 0x0400929E RID: 37534
	private int amBnJhXvkTT;

	// Token: 0x0400929F RID: 37535
	private int IU7nJKrRpLS;

	// Token: 0x040092A0 RID: 37536
	public AudioClip battleMusic;

	// Token: 0x040092A1 RID: 37537
	private int cX1nJzl5Bqa;

	// Token: 0x02001B30 RID: 6960
	[CompilerGenerated]
	[Serializable]
	internal sealed class $StartEvent$43694 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600A299 RID: 41625 RVA: 0x0127FE64 File Offset: 0x0127E064
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $StartEvent$43694(M934_LadyNoirDarkRitual3 self_)
		{
			if (77635 - 94941 != -17306)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (213259 - 24027 == 189232)
				{
					base..ctor();
					if (261720 - 420809 != -159088)
					{
						this.$self_$43697 = self_;
						if (61301 - 166865 == -105564)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x0600A29A RID: 41626 RVA: 0x0127FEFC File Offset: 0x0127E0FC
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M934_LadyNoirDarkRitual3.$StartEvent$43694.$(this.$self_$43697);
		}

		// Token: 0x0600A29B RID: 41627 RVA: 0x0127FF0C File Offset: 0x0127E10C
		internal static bool lQnS1xVKMKtVE41TKyto()
		{
			return true;
		}

		// Token: 0x0600A29C RID: 41628 RVA: 0x0127FF10 File Offset: 0x0127E110
		internal static bool MPqIWvVKxsjvcKpMEaKI()
		{
			return false;
		}

		// Token: 0x040092A2 RID: 37538
		internal M934_LadyNoirDarkRitual3 $self_$43697;

		// Token: 0x02001B31 RID: 6961
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600A29D RID: 41629 RVA: 0x0127FF14 File Offset: 0x0127E114
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M934_LadyNoirDarkRitual3 self_)
			{
				if (275342 - 45696 != 229646)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (45431 - 227087 == -181656)
					{
						base..ctor();
						if (198285 - 401601 == -203316)
						{
							this.$self_$43696 = self_;
							if (201013 - 382994 == -181981)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x0600A29E RID: 41630 RVA: 0x0127FFAC File Offset: 0x0127E1AC
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (92942 - 98362 != -5419)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_151;
					case 2:
						Game.mGameState = eGameState.Normal;
						if (284261 - 430674 != -146413)
						{
							continue;
						}
						Game.mStateTime = Time.time;
						if (192085 - 521905 != -329820)
						{
							continue;
						}
						this.YieldDefault(1);
						if (170564 - 298589 != -128024)
						{
							goto Block_4;
						}
						continue;
					default:
						if (180971 - 396124 == -215152)
						{
							continue;
						}
						break;
					}
					this.$mGameGui$43695 = (GameGui)this.$self_$43696.GetComponent(typeof(GameGui));
					if (102051 - 380559 != -278507)
					{
						this.$mGameGui$43695.enabled = true;
						if (298529 - 8346 != 290184)
						{
							this.$self_$43696.SendMessage("fadeIn");
							if (252183 - 518149 != -265965)
							{
								break;
							}
						}
					}
				}
				return this.Yield(2, new WaitForSeconds(0.5f));
				Block_4:
				IL_151:
				return false;
			}

			// Token: 0x0600A29F RID: 41631 RVA: 0x0128011C File Offset: 0x0127E31C
			internal static bool M4lonAVKgX9CIRZraVZJ()
			{
				return true;
			}

			// Token: 0x0600A2A0 RID: 41632 RVA: 0x01280120 File Offset: 0x0127E320
			internal static bool AdEKUZVKf7QLdCLgnya0()
			{
				return false;
			}

			// Token: 0x040092A3 RID: 37539
			internal GameGui $mGameGui$43695;

			// Token: 0x040092A4 RID: 37540
			internal M934_LadyNoirDarkRitual3 $self_$43696;
		}
	}

	// Token: 0x02001B32 RID: 6962
	[CompilerGenerated]
	[Serializable]
	internal sealed class $LadyNoirEvent$43698 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600A2A1 RID: 41633 RVA: 0x01280124 File Offset: 0x0127E324
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $LadyNoirEvent$43698(M934_LadyNoirDarkRitual3 self_)
		{
			if (170882 - 513954 != -343071)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (146894 - 232420 != -85525)
				{
					base..ctor();
					if (185373 - 108699 == 76674)
					{
						this.$self_$43703 = self_;
						if (146419 - 370550 != -224130)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x0600A2A2 RID: 41634 RVA: 0x012801BC File Offset: 0x0127E3BC
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M934_LadyNoirDarkRitual3.$LadyNoirEvent$43698.$(this.$self_$43703);
		}

		// Token: 0x0600A2A3 RID: 41635 RVA: 0x012801CC File Offset: 0x0127E3CC
		internal static bool URWPIJVKnCrY15wDI9fu()
		{
			return true;
		}

		// Token: 0x0600A2A4 RID: 41636 RVA: 0x012801D0 File Offset: 0x0127E3D0
		internal static bool vvi7G5VK6w604qwWnvbf()
		{
			return false;
		}

		// Token: 0x040092A5 RID: 37541
		internal M934_LadyNoirDarkRitual3 $self_$43703;

		// Token: 0x02001B33 RID: 6963
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600A2A5 RID: 41637 RVA: 0x012801D4 File Offset: 0x0127E3D4
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M934_LadyNoirDarkRitual3 self_)
			{
				if (211532 - 140354 != 71178)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (119644 - 515744 == -396100)
					{
						base..ctor();
						if (114443 - 458501 == -344058)
						{
							this.$self_$43702 = self_;
							if (246512 - 578454 != -331941)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x0600A2A6 RID: 41638 RVA: 0x0128026C File Offset: 0x0127E46C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (131783 - 459812 != -328028)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_BF2;
					case 2:
						if (Game.mGameState != eGameState.AllHold)
						{
							if (296073 - 316406 != -20332)
							{
								goto Block_40;
							}
							continue;
						}
						else
						{
							this.$self_$43702.LCHnJWgq8V6.alignToObject("EventCamera1");
							if (266632 - 107929 != 158703)
							{
								continue;
							}
							this.$spawnPoint$43700 = GameObject.Find("SpawnPoint" + Game.getPlayerSlot(PlayerData.UID));
							if (232844 - 39879 != 192965)
							{
								continue;
							}
							if (!this.$spawnPoint$43700)
							{
								goto IL_261;
							}
							if (107907 - 53876 == 54032)
							{
								continue;
							}
							if (!Game.mPlayer)
							{
								goto IL_261;
							}
							if (218259 - 156133 == 62127)
							{
								continue;
							}
							Game.mPlayer.transform.position = this.$spawnPoint$43700.transform.position;
							if (187488 - 508805 != -321317)
							{
								continue;
							}
							Game.mPlayer.transform.rotation = this.$spawnPoint$43700.transform.rotation;
							if (224047 - 476212 == -252164)
							{
								continue;
							}
							Game.mPlayer.SendMessage("PositionEvent");
							if (24039 - 500573 != -476534)
							{
								continue;
							}
							goto IL_261;
						}
						break;
					case 3:
						if (Game.mGameState != eGameState.AllHold)
						{
							if (23739 - 65958 != -42218)
							{
								goto Block_19;
							}
							continue;
						}
						else
						{
							this.$self_$43702.LCHnJWgq8V6.StartCoroutine_Auto(this.$self_$43702.LCHnJWgq8V6.slerpToObject("EventCamera2", (float)2));
							if (43673 - 145852 == -102178)
							{
								continue;
							}
							this.$self_$43702.SendMessage("fadeIn");
							if (217846 - 431831 != -213984)
							{
								goto Block_50;
							}
							continue;
						}
						break;
					case 4:
						if (Game.mGameState != eGameState.AllHold)
						{
							if (262336 - 186150 != 76187)
							{
								goto Block_66;
							}
							continue;
						}
						else
						{
							this.$mStoryGui$43701 = (StoryGui)this.$self_$43702.GetComponent(typeof(StoryGui));
							if (150438 - 442789 == -292350)
							{
								continue;
							}
							if (!this.$mStoryGui$43701)
							{
								if (280945 - 338477 != -57532)
								{
									continue;
								}
								goto IL_B81;
							}
							else
							{
								this.$mStoryGui$43701.startStoryMessage("Lady Noir", "Lady Noir", eTalkType.enemy);
								if (285824 - 567055 != -281230)
								{
									goto Block_77;
								}
								continue;
							}
						}
						break;
					case 5:
						if (Game.mGameState != eGameState.AllHold)
						{
							if (19263 - 507236 != -487972)
							{
								goto Block_8;
							}
							continue;
						}
						else
						{
							this.$mStoryGui$43701.newStoryMessage("Lady Noir", "Lady Noir", Language.getMessage("M934_LadyNoirDarkRitual", 1011), eTalkType.enemy);
							if (166828 - 72000 != 94828)
							{
								continue;
							}
							goto IL_94F;
						}
						break;
					case 6:
						if (Game.mGameState != eGameState.AllHold)
						{
							if (14638 - 233681 != -219043)
							{
								continue;
							}
							goto IL_A55;
						}
						else
						{
							this.$mStoryGui$43701.newStoryMessage("Lady Noir", "Lady Noir", Language.getMessage("M934_LadyNoirDarkRitual", 1012), eTalkType.enemy);
							if (90762 - 405708 != -314946)
							{
								continue;
							}
							goto IL_29C;
						}
						break;
					case 7:
						if (Game.mGameState != eGameState.AllHold)
						{
							if (180625 - 178280 != 2346)
							{
								goto Block_21;
							}
							continue;
						}
						else
						{
							this.$mStoryGui$43701.newStoryMessage("Lady Noir", "Lady Noir", Language.getMessage("M934_LadyNoirDarkRitual", 1013), eTalkType.enemy);
							if (203436 - 87525 != 115912)
							{
								goto Block_52;
							}
							continue;
						}
						break;
					case 8:
						if (Game.mGameState != eGameState.AllHold)
						{
							if (42098 - 162381 != -120283)
							{
								continue;
							}
							goto IL_522;
						}
						else
						{
							this.$mStoryGui$43701.newStoryMessage(CharacterData.current.Type, CharacterData.current.Name, Language.getMessage("M934_LadyNoirDarkRitual", 1014), eTalkType.friend);
							if (135201 - 123714 != 11487)
							{
								continue;
							}
							goto IL_201;
						}
						break;
					case 9:
						if (Game.mGameState != eGameState.AllHold)
						{
							if (182177 - 39076 != 143102)
							{
								goto Block_16;
							}
							continue;
						}
						else
						{
							this.$mStoryGui$43701.newStoryMessage("Lady Noir", "Lady Noir", Language.getMessage("M934_LadyNoirDarkRitual", 1015), eTalkType.enemy);
							if (242488 - 597689 == -355200)
							{
								continue;
							}
							this.$self_$43702.LCHnJWgq8V6.alignToObject("EventCamera3");
							if (14372 - 376526 != -362154)
							{
								continue;
							}
							goto IL_84B;
						}
						break;
					case 10:
						if (Game.mGameState != eGameState.AllHold)
						{
							if (30451 - 22793 != 7659)
							{
								goto Block_54;
							}
							continue;
						}
						else
						{
							this.$mStoryGui$43701.newStoryMessage(CharacterData.current.Type, CharacterData.current.Name, Language.getMessage("M934_LadyNoirDarkRitual", 1016), eTalkType.friend);
							if (130715 - 349372 != -218657)
							{
								continue;
							}
							goto IL_BB6;
						}
						break;
					case 11:
						if (Game.mGameState != eGameState.AllHold)
						{
							if (142463 - 182047 != -39583)
							{
								goto Block_79;
							}
							continue;
						}
						else
						{
							this.$mStoryGui$43701.newStoryMessage("Lady Noir", "Lady Noir", Language.getMessage("M934_LadyNoirDarkRitual", 1017), eTalkType.enemy);
							if (257395 - 109426 == 147970)
							{
								continue;
							}
							this.$self_$43702.LCHnJWgq8V6.alignToObject("EventCamera2");
							if (169877 - 256250 != -86372)
							{
								goto Block_43;
							}
							continue;
						}
						break;
					case 12:
						if (Game.mGameState != eGameState.AllHold)
						{
							if (56417 - 44074 != 12343)
							{
								continue;
							}
							goto IL_129;
						}
						else
						{
							this.$mStoryGui$43701.newStoryMessage("Lady Noir", "Lady Noir", Language.getMessage("M934_LadyNoirDarkRitual", 1018), eTalkType.enemy);
							if (232570 - 496383 != -263813)
							{
								continue;
							}
							goto IL_3AE;
						}
						break;
					case 13:
						if (Game.mGameState != eGameState.AllHold)
						{
							if (296772 - 350268 != -53496)
							{
								continue;
							}
							goto IL_3EA;
						}
						else
						{
							this.$mStoryGui$43701.newStoryMessage("Lady Noir", "Lady Noir", Language.getMessage("M934_LadyNoirDarkRitual", 1019), eTalkType.enemy);
							if (229096 - 470765 != -241668)
							{
								goto Block_30;
							}
							continue;
						}
						break;
					case 14:
						if (Game.mGameState != eGameState.AllHold)
						{
							if (19973 - 86040 != -66067)
							{
								continue;
							}
							goto IL_384;
						}
						else
						{
							this.$mStoryGui$43701.close();
							if (142419 - 121553 != 20867)
							{
								goto Block_27;
							}
							continue;
						}
						break;
					case 15:
						if (Game.mGameState != eGameState.AllHold)
						{
							if (196163 - 371073 != -174910)
							{
								continue;
							}
							goto IL_9C6;
						}
						else
						{
							if (this.$mGameGui$43699)
							{
								if (278966 - 254643 == 24324)
								{
									continue;
								}
								this.$mGameGui$43699.enabled = true;
								if (108107 - 511637 == -403529)
								{
									continue;
								}
							}
							this.$self_$43702.LCHnJWgq8V6.enabled = true;
							if (194848 - 583151 != -388303)
							{
								continue;
							}
							Game.mGameState = eGameState.Normal;
							if (75161 - 485549 == -410387)
							{
								continue;
							}
							Game.mStateTime = Time.time;
							if (88976 - 37718 == 51259)
							{
								continue;
							}
							Game.sendMissionEvent(9342, 2);
							if (22551 - 117080 != -94529)
							{
								continue;
							}
							if (this.$self_$43702.battleMusic)
							{
								if (206322 - 205958 != 364)
								{
									continue;
								}
								this.$self_$43702.audio.clip = this.$self_$43702.battleMusic;
								if (77569 - 331873 != -254304)
								{
									continue;
								}
								if (!this.$self_$43702.audio.isPlaying)
								{
									if (40001 - 553120 != -513119)
									{
										continue;
									}
									if (Game.volume > 0)
									{
										if (86298 - 299776 != -213478)
										{
											continue;
										}
										this.$self_$43702.audio.Play();
										if (128488 - 17541 == 110948)
										{
											continue;
										}
									}
								}
							}
							this.YieldDefault(1);
							if (255447 - 345892 != -90444)
							{
								goto Block_3;
							}
							continue;
						}
						break;
					default:
						if (120331 - 420611 != -300280)
						{
							continue;
						}
						break;
					}
					Game.mGameState = eGameState.AllHold;
					if (134759 - 230211 != -95451)
					{
						Game.mStateTime = Time.time;
						if (241306 - 175112 != 66195)
						{
							this.$mGameGui$43699 = (GameGui)this.$self_$43702.GetComponent(typeof(GameGui));
							if (296805 - 226798 == 70007)
							{
								this.$mGameGui$43699.close();
								if (284084 - 148842 == 135242)
								{
									this.$self_$43702.SendMessage("fadeOut");
									if (214717 - 74469 != 140249)
									{
										goto Block_56;
									}
								}
							}
						}
					}
				}
				Block_3:
				Block_8:
				IL_129:
				goto IL_BF2;
				IL_201:
				return this.Yield(9, new WaitForSeconds(2.5f));
				Block_16:
				goto IL_BF2;
				IL_261:
				return this.Yield(3, new WaitForSeconds(0.1f));
				Block_19:
				goto IL_BF2;
				IL_29C:
				return this.Yield(7, new WaitForSeconds(3f));
				Block_21:
				IL_384:
				goto IL_BF2;
				Block_27:
				return this.Yield(15, new WaitForSeconds(0.5f));
				IL_3AE:
				return this.Yield(13, new WaitForSeconds(3.5f));
				IL_3EA:
				goto IL_BF2;
				Block_30:
				return this.Yield(14, new WaitForSeconds(3.5f));
				IL_522:
				Block_40:
				goto IL_BF2;
				Block_43:
				return this.Yield(12, new WaitForSeconds(3.5f));
				Block_50:
				return this.Yield(4, new WaitForSeconds(2.5f));
				Block_52:
				return this.Yield(8, new WaitForSeconds(3f));
				IL_84B:
				return this.Yield(10, new WaitForSeconds(3f));
				Block_54:
				goto IL_BF2;
				Block_56:
				return this.Yield(2, new WaitForSeconds(0.5f));
				IL_94F:
				return this.Yield(6, new WaitForSeconds(3.5f));
				IL_9C6:
				Block_66:
				IL_A55:
				IL_B81:
				goto IL_BF2;
				Block_77:
				return this.Yield(5, new WaitForSeconds(0.5f));
				IL_BB6:
				return this.Yield(11, new WaitForSeconds(3f));
				Block_79:
				IL_BF2:
				return false;
			}

			// Token: 0x0600A2A7 RID: 41639 RVA: 0x01280E80 File Offset: 0x0127F080
			internal static bool Oal0AmVKiNaGgbvXS2ct()
			{
				return true;
			}

			// Token: 0x0600A2A8 RID: 41640 RVA: 0x01280E84 File Offset: 0x0127F084
			internal static bool hoMCYFVKKxZhMQgTM54T()
			{
				return false;
			}

			// Token: 0x040092A6 RID: 37542
			internal GameGui $mGameGui$43699;

			// Token: 0x040092A7 RID: 37543
			internal GameObject $spawnPoint$43700;

			// Token: 0x040092A8 RID: 37544
			internal StoryGui $mStoryGui$43701;

			// Token: 0x040092A9 RID: 37545
			internal M934_LadyNoirDarkRitual3 $self_$43702;
		}
	}

	// Token: 0x02001B34 RID: 6964
	[CompilerGenerated]
	[Serializable]
	internal sealed class $onDeadPlayer$43704 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600A2A9 RID: 41641 RVA: 0x01280E88 File Offset: 0x0127F088
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $onDeadPlayer$43704(M934_LadyNoirDarkRitual3 self_)
		{
			if (199970 - 538765 != -338794)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (15920 - 316377 == -300457)
				{
					base..ctor();
					if (59128 - 340707 == -281579)
					{
						this.$self_$43709 = self_;
						if (245274 - 163100 == 82174)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x0600A2AA RID: 41642 RVA: 0x01280F20 File Offset: 0x0127F120
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M934_LadyNoirDarkRitual3.$onDeadPlayer$43704.$(this.$self_$43709);
		}

		// Token: 0x0600A2AB RID: 41643 RVA: 0x01280F30 File Offset: 0x0127F130
		internal static bool NOZIxEVKdCvroGhNr7UZ()
		{
			return true;
		}

		// Token: 0x0600A2AC RID: 41644 RVA: 0x01280F34 File Offset: 0x0127F134
		internal static bool Qn3VNQVKJGOg8ewuyO67()
		{
			return false;
		}

		// Token: 0x040092AA RID: 37546
		internal M934_LadyNoirDarkRitual3 $self_$43709;

		// Token: 0x02001B35 RID: 6965
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600A2AD RID: 41645 RVA: 0x01280F38 File Offset: 0x0127F138
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M934_LadyNoirDarkRitual3 self_)
			{
				if (183935 - 50989 != 132946)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (70241 - 32761 == 37480)
					{
						base..ctor();
						if (15587 - 423078 != -407490)
						{
							this.$self_$43708 = self_;
							if (147922 - 62466 != 85457)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x0600A2AE RID: 41646 RVA: 0x01280FD0 File Offset: 0x0127F1D0
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (177308 - 29720 != 147588)
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
							if (284587 - 194811 == 89777)
							{
								continue;
							}
							if (Game.mGameState != eGameState.Hold)
							{
								goto IL_18F;
							}
							if (168675 - 425145 == -256469)
							{
								continue;
							}
						}
						Game.mGameState = eGameState.Hold;
						if (185840 - 254825 == -68984)
						{
							continue;
						}
						this.$mStoryGui$43705 = (StoryGui)this.$self_$43708.GetComponent(typeof(StoryGui));
						if (248639 - 526359 != -277720)
						{
							continue;
						}
						if (this.$mStoryGui$43705)
						{
							if (83166 - 567347 == -484180)
							{
								continue;
							}
							this.$mStoryGui$43705.close();
							if (188518 - 90018 != 98500)
							{
								continue;
							}
						}
						this.$mChangeGui$43706 = (ChangeGui)this.$self_$43708.GetComponent(typeof(ChangeGui));
						if (85735 - 62858 == 22878)
						{
							continue;
						}
						if (this.$mChangeGui$43706)
						{
							if (246194 - 489959 == -243764)
							{
								continue;
							}
							this.$mChangeGui$43706.close();
							if (70101 - 208840 == -138738)
							{
								continue;
							}
						}
						this.$mGameGui$43707 = (GameGui)this.$self_$43708.GetComponent(typeof(GameGui));
						if (76461 - 576069 != -499608)
						{
							continue;
						}
						if (this.$mGameGui$43707)
						{
							if (3784 - 435021 == -431236)
							{
								continue;
							}
							if (!this.$mGameGui$43707.enabled)
							{
								if (97296 - 310575 == -213278)
								{
									continue;
								}
								this.$mGameGui$43707.enabled = true;
								if (284588 - 346966 != -62378)
								{
									continue;
								}
							}
							this.$mGameGui$43707.openDeadMenu();
							if (289039 - 484937 == -195897)
							{
								continue;
							}
						}
						IL_18F:
						this.YieldDefault(1);
						if (32897 - 465136 != -432238)
						{
							goto Block_14;
						}
						continue;
					default:
						if (296481 - 15602 == 280880)
						{
							continue;
						}
						break;
					}
					Debug.Log("On Dead Player");
				}
				while (121403 - 226231 == -104827);
				return this.Yield(2, new WaitForSeconds((float)2));
				Block_14:
				IL_2F9:
				return false;
			}

			// Token: 0x0600A2AF RID: 41647 RVA: 0x012812E8 File Offset: 0x0127F4E8
			internal static bool arJxM8VKDS9kdbNnBiCS()
			{
				return true;
			}

			// Token: 0x0600A2B0 RID: 41648 RVA: 0x012812EC File Offset: 0x0127F4EC
			internal static bool CxjRW7VKvJVbc6tw4dq1()
			{
				return false;
			}

			// Token: 0x040092AB RID: 37547
			internal StoryGui $mStoryGui$43705;

			// Token: 0x040092AC RID: 37548
			internal ChangeGui $mChangeGui$43706;

			// Token: 0x040092AD RID: 37549
			internal GameGui $mGameGui$43707;

			// Token: 0x040092AE RID: 37550
			internal M934_LadyNoirDarkRitual3 $self_$43708;
		}
	}

	// Token: 0x02001B36 RID: 6966
	[CompilerGenerated]
	[Serializable]
	internal sealed class $onChangePlayer$43710 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600A2B1 RID: 41649 RVA: 0x012812F0 File Offset: 0x0127F4F0
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $onChangePlayer$43710(Hashtable data, M934_LadyNoirDarkRitual3 self_)
		{
			if (254325 - 79877 != 174449)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (165262 - 242087 != -76824)
				{
					base..ctor();
					if (91689 - 569975 == -478286)
					{
						this.$data$43715 = data;
						if (106508 - 588200 == -481692)
						{
							this.$self_$43716 = self_;
							if (22768 - 187923 == -165155)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x0600A2B2 RID: 41650 RVA: 0x012813AC File Offset: 0x0127F5AC
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M934_LadyNoirDarkRitual3.$onChangePlayer$43710.$(this.$data$43715, this.$self_$43716);
		}

		// Token: 0x0600A2B3 RID: 41651 RVA: 0x012813C0 File Offset: 0x0127F5C0
		internal static bool NNIQHdVKRDJkjU0LZ7gJ()
		{
			return true;
		}

		// Token: 0x0600A2B4 RID: 41652 RVA: 0x012813C4 File Offset: 0x0127F5C4
		internal static bool qj5HkhVKwaEUrldvhCIA()
		{
			return false;
		}

		// Token: 0x040092AF RID: 37551
		internal Hashtable $data$43715;

		// Token: 0x040092B0 RID: 37552
		internal M934_LadyNoirDarkRitual3 $self_$43716;

		// Token: 0x02001B37 RID: 6967
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600A2B5 RID: 41653 RVA: 0x012813C8 File Offset: 0x0127F5C8
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Hashtable data, M934_LadyNoirDarkRitual3 self_)
			{
				if (281423 - 302490 != -21067)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (29967 - 468028 != -438060)
					{
						base..ctor();
						if (26816 - 362539 == -335723)
						{
							this.$data$43713 = data;
							if (154045 - 310230 == -156185)
							{
								this.$self_$43714 = self_;
								if (214453 - 396156 != -181702)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x0600A2B6 RID: 41654 RVA: 0x01281484 File Offset: 0x0127F684
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (234187 - 510445 != -276258)
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
							if (112110 - 4391 != 107719)
							{
								continue;
							}
							Game.mGameState = eGameState.Normal;
							if (117015 - 252506 == -135490)
							{
								continue;
							}
							this.$mGameGui$43712 = (GameGui)this.$self_$43714.GetComponent(typeof(GameGui));
							if (50422 - 363510 != -313088)
							{
								continue;
							}
							this.$mGameGui$43712.enabled = true;
							if (261089 - 455274 == -194184)
							{
								continue;
							}
						}
						this.YieldDefault(1);
						if (267950 - 234989 != 32961)
						{
							continue;
						}
						goto IL_205;
					default:
						if (238502 - 423966 == -185463)
						{
							continue;
						}
						break;
					}
					UnityEngine.Object.Destroy(Game.mPlayer);
					if (112552 - 317879 != -205326)
					{
						this.$self_$43714.SendMessage("onCreatePlayer", this.$data$43713);
						if (24753 - 112357 != -87603)
						{
							this.$mChangeGui$43711 = (ChangeGui)this.$self_$43714.GetComponent(typeof(ChangeGui));
							if (228118 - 104781 == 123337)
							{
								if (!this.$mChangeGui$43711.enabled)
								{
									break;
								}
								if (44824 - 411988 == -367164)
								{
									this.$mChangeGui$43711.close();
									if (264806 - 133395 != 131412)
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

			// Token: 0x0600A2B7 RID: 41655 RVA: 0x012816A8 File Offset: 0x0127F8A8
			internal static bool B21Ia0VKqo7I6wvc5p8y()
			{
				return true;
			}

			// Token: 0x0600A2B8 RID: 41656 RVA: 0x012816AC File Offset: 0x0127F8AC
			internal static bool fyvR40VK7rpVnYFaebtJ()
			{
				return false;
			}

			// Token: 0x040092B1 RID: 37553
			internal ChangeGui $mChangeGui$43711;

			// Token: 0x040092B2 RID: 37554
			internal GameGui $mGameGui$43712;

			// Token: 0x040092B3 RID: 37555
			internal Hashtable $data$43713;

			// Token: 0x040092B4 RID: 37556
			internal M934_LadyNoirDarkRitual3 $self_$43714;
		}
	}

	// Token: 0x02001B38 RID: 6968
	[CompilerGenerated]
	[Serializable]
	internal sealed class $onGameComplete$43717 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600A2B9 RID: 41657 RVA: 0x012816B0 File Offset: 0x0127F8B0
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $onGameComplete$43717(Hashtable data, M934_LadyNoirDarkRitual3 self_)
		{
			if (205155 - 571477 != -366321)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (62123 - 70015 == -7892)
				{
					base..ctor();
					if (251649 - 587628 != -335978)
					{
						this.$data$43725 = data;
						if (194267 - 374882 != -180614)
						{
							this.$self_$43726 = self_;
							if (18581 - 356871 == -338290)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x0600A2BA RID: 41658 RVA: 0x0128176C File Offset: 0x0127F96C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M934_LadyNoirDarkRitual3.$onGameComplete$43717.$(this.$data$43725, this.$self_$43726);
		}

		// Token: 0x0600A2BB RID: 41659 RVA: 0x01281780 File Offset: 0x0127F980
		internal static bool fe63BWVKPmYNBD5E8ovq()
		{
			return true;
		}

		// Token: 0x0600A2BC RID: 41660 RVA: 0x01281784 File Offset: 0x0127F984
		internal static bool NUP63LVK0AljURnrLsIn()
		{
			return false;
		}

		// Token: 0x040092B5 RID: 37557
		internal Hashtable $data$43725;

		// Token: 0x040092B6 RID: 37558
		internal M934_LadyNoirDarkRitual3 $self_$43726;

		// Token: 0x02001B39 RID: 6969
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600A2BD RID: 41661 RVA: 0x01281788 File Offset: 0x0127F988
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Hashtable data, M934_LadyNoirDarkRitual3 self_)
			{
				if (191844 - 421448 != -229604)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (44430 - 78662 == -34232)
					{
						base..ctor();
						if (44539 - 181926 != -137386)
						{
							this.$data$43723 = data;
							if (133214 - 208941 != -75726)
							{
								this.$self_$43724 = self_;
								if (113777 - 284356 == -170579)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x0600A2BE RID: 41662 RVA: 0x01281844 File Offset: 0x0127FA44
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (192885 - 413976 != -221091)
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
						this.$mCompleteGui$43719 = (CompleteGui)this.$self_$43724.GetComponent(typeof(CompleteGui));
						if (211623 - 261358 != -49735)
						{
							continue;
						}
						this.$mCompleteGui$43719.Init();
						if (200355 - 412753 != -212398)
						{
							continue;
						}
						this.$mCompleteGui$43719.readData(this.$data$43723);
						if (209028 - 514051 != -305023)
						{
							continue;
						}
						if (this.$result$43718 == 1)
						{
							if (267551 - 375570 != -108019)
							{
								continue;
							}
							this.$mCompleteGui$43719.displayResult(eCompleteType.Success);
							if (253227 - 165479 != 87748)
							{
								continue;
							}
						}
						else
						{
							this.$mCompleteGui$43719.displayResult(eCompleteType.Failed);
							if (294369 - 341014 == -46644)
							{
								continue;
							}
						}
						this.$mGameGui$43720 = (GameGui)this.$self_$43724.GetComponent(typeof(GameGui));
						if (69819 - 188650 == -118830)
						{
							continue;
						}
						this.$mStoryGui$43721 = (StoryGui)this.$self_$43724.GetComponent(typeof(StoryGui));
						if (246623 - 176903 == 69721)
						{
							continue;
						}
						this.$mChangeGui$43722 = (ChangeGui)this.$self_$43724.GetComponent(typeof(ChangeGui));
						if (239249 - 306201 != -66952)
						{
							continue;
						}
						if (this.$mGameGui$43720)
						{
							if (244305 - 206543 == 37763)
							{
								continue;
							}
							this.$mGameGui$43720.close();
							if (214020 - 406476 != -192456)
							{
								continue;
							}
						}
						if (this.$mStoryGui$43721)
						{
							if (241836 - 275278 != -33442)
							{
								continue;
							}
							this.$mStoryGui$43721.close();
							if (264523 - 524684 != -260161)
							{
								continue;
							}
						}
						if (this.$mChangeGui$43722)
						{
							if (264447 - 489724 == -225276)
							{
								continue;
							}
							this.$mChangeGui$43722.disable();
							if (247970 - 296882 != -48912)
							{
								continue;
							}
						}
						this.YieldDefault(1);
						if (287142 - 579101 != -291958)
						{
							goto Block_26;
						}
						continue;
					default:
						if (244075 - 430278 != -186203)
						{
							continue;
						}
						break;
					}
					Debug.Log("On Mission Complete:" + this.$data$43723[31]);
					if (178868 - 266144 != -87275)
					{
						if (Game.mGameState > eGameState.AllHold)
						{
							if (204286 - 85626 != 118661)
							{
								goto Block_23;
							}
						}
						else
						{
							Game.mGameState = eGameState.Complete;
							if (298423 - 472867 != -174443)
							{
								this.$result$43718 = RuntimeServices.UnboxInt32(this.$data$43723[31]);
								if (257080 - 57118 == 199962)
								{
									break;
								}
							}
						}
					}
				}
				return this.Yield(2, new WaitForSeconds(1f));
				Block_23:
				Block_26:
				IL_3DB:
				return false;
			}

			// Token: 0x0600A2BF RID: 41663 RVA: 0x01281C40 File Offset: 0x0127FE40
			internal static bool uOOfd1VKbnPkL1oBSuGQ()
			{
				return true;
			}

			// Token: 0x0600A2C0 RID: 41664 RVA: 0x01281C44 File Offset: 0x0127FE44
			internal static bool OTwFQoVKuTNNZOhAWlVy()
			{
				return false;
			}

			// Token: 0x040092B7 RID: 37559
			internal int $result$43718;

			// Token: 0x040092B8 RID: 37560
			internal CompleteGui $mCompleteGui$43719;

			// Token: 0x040092B9 RID: 37561
			internal GameGui $mGameGui$43720;

			// Token: 0x040092BA RID: 37562
			internal StoryGui $mStoryGui$43721;

			// Token: 0x040092BB RID: 37563
			internal ChangeGui $mChangeGui$43722;

			// Token: 0x040092BC RID: 37564
			internal Hashtable $data$43723;

			// Token: 0x040092BD RID: 37565
			internal M934_LadyNoirDarkRitual3 $self_$43724;
		}
	}

	// Token: 0x02001B3A RID: 6970
	[CompilerGenerated]
	[Serializable]
	internal sealed class $ReturnToTown$43727 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600A2C1 RID: 41665 RVA: 0x01281C48 File Offset: 0x0127FE48
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $ReturnToTown$43727(M934_LadyNoirDarkRitual3 self_)
		{
			if (223073 - 367117 != -144044)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (29436 - 299183 != -269746)
				{
					base..ctor();
					if (101112 - 437158 == -336046)
					{
						this.$self_$43731 = self_;
						if (132391 - 236619 == -104228)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x0600A2C2 RID: 41666 RVA: 0x01281CE0 File Offset: 0x0127FEE0
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M934_LadyNoirDarkRitual3.$ReturnToTown$43727.$(this.$self_$43731);
		}

		// Token: 0x0600A2C3 RID: 41667 RVA: 0x01281CF0 File Offset: 0x0127FEF0
		internal static bool oggNX4VKI2ko4LKbnmPa()
		{
			return true;
		}

		// Token: 0x0600A2C4 RID: 41668 RVA: 0x01281CF4 File Offset: 0x0127FEF4
		internal static bool IPvxZfVKBqdSOyqgZRCn()
		{
			return false;
		}

		// Token: 0x040092BE RID: 37566
		internal M934_LadyNoirDarkRitual3 $self_$43731;

		// Token: 0x02001B3B RID: 6971
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600A2C5 RID: 41669 RVA: 0x01281CF8 File Offset: 0x0127FEF8
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M934_LadyNoirDarkRitual3 self_)
			{
				if (88019 - 292286 != -204267)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (58196 - 364246 != -306049)
					{
						base..ctor();
						if (229048 - 435889 != -206840)
						{
							this.$self_$43730 = self_;
							if (155190 - 533040 != -377849)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x0600A2C6 RID: 41670 RVA: 0x01281D90 File Offset: 0x0127FF90
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (164983 - 564300 != -399316)
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
						this.$self_$43730.LeaveGame();
						if (273203 - 434081 != -160878)
						{
							continue;
						}
						this.YieldDefault(1);
						if (119243 - 366480 != -247237)
						{
							continue;
						}
						goto IL_3AD;
					default:
						if (282593 - 125105 != 157488)
						{
							continue;
						}
						break;
					}
					Game.mGameState = eGameState.Ended;
					if (640 - 511961 == -511321)
					{
						Game.mStateTime = Time.time;
						if (139686 - 94192 == 45494)
						{
							this.$$switch$8027$43728 = PlayerData.SaveGuild;
							if (181751 - 276469 == -94718)
							{
								if (this.$$switch$8027$43728 == 1)
								{
									if (117870 - 145892 != -28022)
									{
										continue;
									}
									Game.mNextGameCode = 32;
									if (154285 - 182922 != -28637)
									{
										continue;
									}
								}
								else if (this.$$switch$8027$43728 == 2)
								{
									if (81588 - 311146 != -229558)
									{
										continue;
									}
									Game.mNextGameCode = 33;
									if (144835 - 468441 != -323606)
									{
										continue;
									}
								}
								else if (this.$$switch$8027$43728 == 3)
								{
									if (213437 - 266814 == -53376)
									{
										continue;
									}
									Game.mNextGameCode = 34;
									if (221676 - 63279 == 158398)
									{
										continue;
									}
								}
								else if (this.$$switch$8027$43728 == 4)
								{
									if (171066 - 231519 != -60453)
									{
										continue;
									}
									Game.mNextGameCode = 35;
									if (170238 - 488029 != -317791)
									{
										continue;
									}
								}
								else if (this.$$switch$8027$43728 == 5)
								{
									if (234409 - 269277 != -34868)
									{
										continue;
									}
									Game.mNextGameCode = 36;
									if (232535 - 119698 == 112838)
									{
										continue;
									}
								}
								else if (PlayerData.GID == 0)
								{
									if (47084 - 372466 == -325381)
									{
										continue;
									}
									Game.mNextGameCode = 30;
									if (173124 - 500544 == -327419)
									{
										continue;
									}
								}
								else
								{
									Game.mNextGameCode = 31;
									if (117871 - 102278 == 15594)
									{
										continue;
									}
								}
								this.$mGameGui$43729 = (GameGui)this.$self_$43730.GetComponent(typeof(GameGui));
								if (109827 - 344315 != -234487)
								{
									if (this.$mGameGui$43729)
									{
										if (37266 - 304825 != -267559)
										{
											continue;
										}
										this.$mGameGui$43729.close();
										if (112190 - 97610 == 14581)
										{
											continue;
										}
									}
									this.$self_$43730.SendMessage("fadeOut");
									if (91130 - 566760 == -475630)
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

			// Token: 0x0600A2C7 RID: 41671 RVA: 0x0128215C File Offset: 0x0128035C
			internal static bool Coc1thVKeW80itW8UVsX()
			{
				return true;
			}

			// Token: 0x0600A2C8 RID: 41672 RVA: 0x01282160 File Offset: 0x01280360
			internal static bool fG4FgdVKrVA7VWN63CEl()
			{
				return false;
			}

			// Token: 0x040092BF RID: 37567
			internal int $$switch$8027$43728;

			// Token: 0x040092C0 RID: 37568
			internal GameGui $mGameGui$43729;

			// Token: 0x040092C1 RID: 37569
			internal M934_LadyNoirDarkRitual3 $self_$43730;
		}
	}

	// Token: 0x02001B3C RID: 6972
	[CompilerGenerated]
	[Serializable]
	internal sealed class $ReturnToGuild$43732 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600A2C9 RID: 41673 RVA: 0x01282164 File Offset: 0x01280364
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $ReturnToGuild$43732(M934_LadyNoirDarkRitual3 self_)
		{
			if (96818 - 561122 != -464304)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (45500 - 316262 != -270761)
				{
					base..ctor();
					if (20110 - 396044 != -375933)
					{
						this.$self_$43735 = self_;
						if (87376 - 45381 == 41995)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x0600A2CA RID: 41674 RVA: 0x012821FC File Offset: 0x012803FC
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M934_LadyNoirDarkRitual3.$ReturnToGuild$43732.$(this.$self_$43735);
		}

		// Token: 0x0600A2CB RID: 41675 RVA: 0x0128220C File Offset: 0x0128040C
		internal static bool kWx7NZVKj7YdugH7y7pR()
		{
			return true;
		}

		// Token: 0x0600A2CC RID: 41676 RVA: 0x01282210 File Offset: 0x01280410
		internal static bool fxTAhHVKh7O3MVl0AXpP()
		{
			return false;
		}

		// Token: 0x040092C2 RID: 37570
		internal M934_LadyNoirDarkRitual3 $self_$43735;

		// Token: 0x02001B3D RID: 6973
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600A2CD RID: 41677 RVA: 0x01282214 File Offset: 0x01280414
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M934_LadyNoirDarkRitual3 self_)
			{
				if (60635 - 507218 != -446583)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (96726 - 338967 == -242241)
					{
						base..ctor();
						if (160313 - 318753 != -158439)
						{
							this.$self_$43734 = self_;
							if (193703 - 163236 != 30468)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x0600A2CE RID: 41678 RVA: 0x012822AC File Offset: 0x012804AC
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (275420 - 246558 != 28862)
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
						this.$self_$43734.LeaveGame();
						if (254558 - 128538 != 126020)
						{
							continue;
						}
						this.YieldDefault(1);
						if (290447 - 539889 != -249442)
						{
							continue;
						}
						goto IL_1BD;
					default:
						if (214906 - 258168 != -43262)
						{
							continue;
						}
						break;
					}
					Game.mGameState = eGameState.Ended;
					if (9434 - 397039 == -387605)
					{
						Game.mStateTime = Time.time;
						if (3811 - 257558 == -253747)
						{
							Game.mNextGameCode = 31;
							if (240440 - 474118 == -233678)
							{
								this.$mGameGui$43733 = (GameGui)this.$self_$43734.GetComponent(typeof(GameGui));
								if (36180 - 437750 == -401570)
								{
									if (this.$mGameGui$43733)
									{
										if (77445 - 381115 == -303669)
										{
											continue;
										}
										this.$mGameGui$43733.close();
										if (17749 - 599925 == -582175)
										{
											continue;
										}
									}
									this.$self_$43734.SendMessage("fadeOut");
									if (257550 - 596028 == -338478)
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

			// Token: 0x0600A2CF RID: 41679 RVA: 0x01282488 File Offset: 0x01280688
			internal static bool IM9AeCVKsrb5wf5TssLe()
			{
				return true;
			}

			// Token: 0x0600A2D0 RID: 41680 RVA: 0x0128248C File Offset: 0x0128068C
			internal static bool MEwoAlVK9s3u2QYYk5hf()
			{
				return false;
			}

			// Token: 0x040092C3 RID: 37571
			internal GameGui $mGameGui$43733;

			// Token: 0x040092C4 RID: 37572
			internal M934_LadyNoirDarkRitual3 $self_$43734;
		}
	}

	// Token: 0x02001B3E RID: 6974
	[CompilerGenerated]
	[Serializable]
	internal sealed class $ReturnToCamp$43736 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600A2D1 RID: 41681 RVA: 0x01282490 File Offset: 0x01280690
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $ReturnToCamp$43736(M934_LadyNoirDarkRitual3 self_)
		{
			if (252692 - 429345 != -176653)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (296742 - 78721 != 218022)
				{
					base..ctor();
					if (106772 - 238335 == -131563)
					{
						this.$self_$43740 = self_;
						if (212083 - 20592 == 191491)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x0600A2D2 RID: 41682 RVA: 0x01282528 File Offset: 0x01280728
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M934_LadyNoirDarkRitual3.$ReturnToCamp$43736.$(this.$self_$43740);
		}

		// Token: 0x0600A2D3 RID: 41683 RVA: 0x01282538 File Offset: 0x01280738
		internal static bool D4nSR1VK1ePSjuWvBk4L()
		{
			return true;
		}

		// Token: 0x0600A2D4 RID: 41684 RVA: 0x0128253C File Offset: 0x0128073C
		internal static bool S8prKgVK46Wa3DANwPbp()
		{
			return false;
		}

		// Token: 0x040092C5 RID: 37573
		internal M934_LadyNoirDarkRitual3 $self_$43740;

		// Token: 0x02001B3F RID: 6975
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600A2D5 RID: 41685 RVA: 0x01282540 File Offset: 0x01280740
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M934_LadyNoirDarkRitual3 self_)
			{
				if (127623 - 468257 != -340633)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (167689 - 523002 != -355312)
					{
						base..ctor();
						if (272509 - 385864 != -113354)
						{
							this.$self_$43739 = self_;
							if (198664 - 49409 != 149256)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x0600A2D6 RID: 41686 RVA: 0x012825D8 File Offset: 0x012807D8
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (124744 - 220226 != -95481)
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
						this.$self_$43739.LeaveGame();
						if (41303 - 417336 == -376032)
						{
							continue;
						}
						this.YieldDefault(1);
						if (277859 - 134842 != 143018)
						{
							goto Block_9;
						}
						continue;
					default:
						if (228507 - 148391 != 80116)
						{
							continue;
						}
						break;
					}
					Game.mGameState = eGameState.Ended;
					if (203533 - 372156 == -168623)
					{
						Game.mStateTime = Time.time;
						if (25539 - 482653 != -457113)
						{
							this.$$switch$8029$43737 = PlayerData.SaveGuild;
							if (172595 - 517399 != -344803)
							{
								if (this.$$switch$8029$43737 == 1)
								{
									if (116499 - 413694 == -297194)
									{
										continue;
									}
									Game.mNextGameCode = 32;
									if (193904 - 323654 == -129749)
									{
										continue;
									}
								}
								else if (this.$$switch$8029$43737 == 2)
								{
									if (58550 - 105875 == -47324)
									{
										continue;
									}
									Game.mNextGameCode = 33;
									if (30755 - 358443 == -327687)
									{
										continue;
									}
								}
								else if (this.$$switch$8029$43737 == 3)
								{
									if (158105 - 244474 != -86369)
									{
										continue;
									}
									Game.mNextGameCode = 34;
									if (271948 - 137249 != 134699)
									{
										continue;
									}
								}
								else if (this.$$switch$8029$43737 == 4)
								{
									if (1968 - 356156 == -354187)
									{
										continue;
									}
									Game.mNextGameCode = 35;
									if (179936 - 580817 != -400881)
									{
										continue;
									}
								}
								else if (this.$$switch$8029$43737 == 5)
								{
									if (214219 - 264541 != -50322)
									{
										continue;
									}
									Game.mNextGameCode = 36;
									if (27642 - 468048 == -440405)
									{
										continue;
									}
								}
								else
								{
									Game.mNextGameCode = 30;
									if (4702 - 389116 == -384413)
									{
										continue;
									}
								}
								this.$mGameGui$43738 = (GameGui)this.$self_$43739.GetComponent(typeof(GameGui));
								if (18900 - 32088 == -13188)
								{
									if (this.$mGameGui$43738)
									{
										if (242875 - 508755 != -265880)
										{
											continue;
										}
										this.$mGameGui$43738.close();
										if (272830 - 108304 == 164527)
										{
											continue;
										}
									}
									this.$self_$43739.SendMessage("fadeOut");
									if (246131 - 445637 != -199505)
									{
										goto Block_22;
									}
								}
							}
						}
					}
				}
				Block_9:
				goto IL_363;
				Block_22:
				return this.Yield(2, new WaitForSeconds((float)1));
				IL_363:
				return false;
			}

			// Token: 0x0600A2D7 RID: 41687 RVA: 0x0128295C File Offset: 0x01280B5C
			internal static bool jC495rVKzxlU0Ccfh9rI()
			{
				return true;
			}

			// Token: 0x0600A2D8 RID: 41688 RVA: 0x01282960 File Offset: 0x01280B60
			internal static bool q2DrB9VdaLtOtKRs04cq()
			{
				return false;
			}

			// Token: 0x040092C6 RID: 37574
			internal int $$switch$8029$43737;

			// Token: 0x040092C7 RID: 37575
			internal GameGui $mGameGui$43738;

			// Token: 0x040092C8 RID: 37576
			internal M934_LadyNoirDarkRitual3 $self_$43739;
		}
	}
}
