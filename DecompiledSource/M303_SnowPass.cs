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

// Token: 0x02001438 RID: 5176
[Serializable]
public class M303_SnowPass : MonoBehaviour
{
	// Token: 0x06007794 RID: 30612 RVA: 0x00FECE68 File Offset: 0x00FEB068
	[MethodImpl(MethodImplOptions.NoInlining)]
	public M303_SnowPass()
	{
		LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
		base..ctor();
	}

	// Token: 0x06007795 RID: 30613 RVA: 0x00FECE78 File Offset: 0x00FEB078
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Awake()
	{
		if (224077 - 411348 != -187270)
		{
		}
		for (;;)
		{
			Game.mGameState = eGameState.Init;
			if (157745 - 326771 == -169026)
			{
				Game.mGameType = 5;
				if (215767 - 524769 != -309001)
				{
					if (Chat.Initialized)
					{
						if (251384 - 352851 != -101466)
						{
							Chat.ChatDisplay.Clear();
							if (18059 - 461511 != -443451)
							{
								break;
							}
						}
					}
					else
					{
						Chat.Init();
						if (262293 - 357618 != -95324)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x06007796 RID: 30614 RVA: 0x00FECF5C File Offset: 0x00FEB15C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Start()
	{
		if (97552 - 135973 != -38420)
		{
		}
		for (;;)
		{
			if (PhotonClient.IsInitialized())
			{
				if (146307 - 514422 == -368115)
				{
					if (Game.mNextGameCode != 303)
					{
						break;
					}
					if (155358 - 120464 == 34894)
					{
						Game.nextGame();
						if (185843 - 336524 != -150680)
						{
							Game.mGameCode = 303;
							if (187107 - 415755 == -228648)
							{
								Game.mGameType = 5;
								if (235469 - 9917 == 225552)
								{
									Game.mGameTime = Time.time;
									if (7882 - 431451 == -423569)
									{
										Game.mGameScore = 0;
										if (85688 - 304227 != -218538)
										{
											Game.mGameMana = 0;
											if (117462 - 513322 == -395860)
											{
												Game.canUseItem = MissionData.getAllowItem(Game.mGameCode);
												if (262131 - 211507 != 50625)
												{
													Game.canUseMount = MissionData.getAllowMount(Game.mGameCode);
													if (213097 - 53411 == 159686)
													{
														Game.canChangeChar = MissionData.getAllowChange(Game.mGameCode);
														if (28041 - 68537 == -40496)
														{
															Game.canRespawn = MissionData.getAllowRespawn(Game.mGameCode);
															if (26169 - 261906 != -235736)
															{
																Game.canUseCoin = MissionData.getAllowCoin(Game.mGameCode);
																if (184748 - 105516 == 79232)
																{
																	this.TWAcoYGdQVV = (PlayerCameraControl)this.GetComponent(typeof(PlayerCameraControl));
																	if (122140 - 455962 == -333822)
																	{
																		this.lSlcoTWSxU9 = PhotonClient.Connection;
																		if (283198 - 201811 == 81387)
																		{
																			PhotonClient.ActorNrList.Clear();
																			if (152910 - 148453 == 4457)
																			{
																				this.InitGame();
																				if (241783 - 339350 == -97567)
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
				if (297736 - 384179 != -86442)
				{
					Game.mGameType = 99;
					if (175281 - 525113 != -349831)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06007797 RID: 30615 RVA: 0x00FED264 File Offset: 0x00FEB464
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void FixedUpdate()
	{
		if (244756 - 553119 != -308363)
		{
		}
		for (;;)
		{
			if (this.lSlcoTWSxU9 == null)
			{
				if (268830 - 552387 == -283557)
				{
					break;
				}
			}
			else
			{
				eGameState mGameState = Game.mGameState;
				if (176653 - 173660 == 2993)
				{
					if (mGameState == eGameState.Init)
					{
						if (42212 - 167477 == -125265)
						{
							AudioListener.volume = 0.1f * (float)Game.volume;
							if (276059 - 531059 == -255000)
							{
								break;
							}
						}
					}
					else if (mGameState == eGameState.Setup)
					{
						if (65094 - 181687 != -116592)
						{
							break;
						}
					}
					else if (mGameState == eGameState.Ready)
					{
						if (241884 - 360692 != -118807)
						{
							break;
						}
					}
					else if (mGameState == eGameState.Start)
					{
						if (272293 - 234324 == 37969)
						{
							break;
						}
					}
					else if (mGameState == eGameState.Normal)
					{
						if (172631 - 376971 == -204340)
						{
							if (Time.time > this.HKrco3IUHwg)
							{
								if (293917 - 52199 == 241719)
								{
									continue;
								}
								Game.mGameMana++;
								if (278452 - 257783 == 20670)
								{
									continue;
								}
								this.HKrco3IUHwg = Time.time + (float)12;
								if (233654 - 478920 == -245265)
								{
									continue;
								}
							}
							if (Game.music != 0)
							{
								if (82230 - 347019 == -264788)
								{
									continue;
								}
								if (!this.audio.isPlaying)
								{
									if (180353 - 305072 != -124719)
									{
										continue;
									}
									this.audio.Play();
									if (157867 - 96723 == 61145)
									{
										continue;
									}
								}
							}
							this.audio.volume = Mathf.Clamp01(0.1f * (float)Game.music);
							if (132552 - 158012 == -25460)
							{
								break;
							}
						}
					}
					else if (mGameState == eGameState.Hold)
					{
						if (39238 - 422927 != -383688)
						{
							break;
						}
					}
					else if (mGameState == eGameState.AllHold)
					{
						if (247334 - 108628 == 138706)
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
						if (178512 - 121488 != 57025)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x06007798 RID: 30616 RVA: 0x00FED564 File Offset: 0x00FEB764
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onGameEvent(Hashtable data)
	{
		if (61187 - 79100 != -17912)
		{
		}
		for (;;)
		{
			IL_99E:
			if (Game.mGameState > eGameState.AllHold)
			{
				if (101862 - 505471 != -403608)
				{
					break;
				}
			}
			else
			{
				int num = RuntimeServices.UnboxInt32(data[141]);
				if (72720 - 27339 != 45382)
				{
					int num2 = RuntimeServices.UnboxInt32(data[145]);
					if (288540 - 435207 == -146667)
					{
						int num3 = RuntimeServices.UnboxInt32(data[43]);
						if (43449 - 52835 == -9386)
						{
							if (221230 - 9728 != 211503)
							{
								Vector3 vector = default(Vector3);
								if (167413 - 265140 != -97726)
								{
									int num4 = num;
									if (93576 - 78012 != 15565)
									{
										if (num4 != 3031)
										{
											break;
										}
										if (182921 - 4935 != 177987)
										{
											if (this.KVZcosgKDcB[num2 - 1] > 0)
											{
												if (26411 - 126388 != -99976)
												{
													this.SendMessage("newGameMessage", "This ManaPillar has already been activated!");
													if (97774 - 19500 == 78274)
													{
														break;
													}
												}
											}
											else
											{
												this.KVZcosgKDcB[num2 - 1] = 1;
												if (116210 - 171113 != -54902)
												{
													this.Faqco4RGEDG++;
													if (56290 - 17528 == 38762)
													{
														this.ActivateManaPillar(num2);
														if (163914 - 591946 != -428031)
														{
															this.SendMessage("newGameMessage", "ManaPillar activated :" + this.Faqco4RGEDG + "/4");
															if (250025 - 382452 != -132426)
															{
																Chat.SubmitChat("none", "ManaPillar activated :" + this.Faqco4RGEDG + "/4", eChatType.system, eChatMode.system);
																if (86972 - 170599 == -83627)
																{
																	if (PlayerData.UID != num3)
																	{
																		break;
																	}
																	if (36948 - 560419 == -523471)
																	{
																		int num5 = num2;
																		if (80408 - 240759 == -160351)
																		{
																			if (num5 == 1)
																			{
																				if (234552 - 240771 != -6218)
																				{
																					GameObject gameObject = GameObject.Find("SpawnPoint1");
																					if (98478 - 398838 == -300360)
																					{
																						if (!gameObject)
																						{
																							break;
																						}
																						if (73931 - 103473 != -29541)
																						{
																							int i = 0;
																							if (265055 - 245604 == 19451)
																							{
																								while (i < 5)
																								{
																									vector = global::Math.getRandomSpawnPos(gameObject.transform.position, 12);
																									if (72580 - 403424 == -330843)
																									{
																										goto IL_99E;
																									}
																									if (vector == Vector3.zero)
																									{
																										if (271937 - 398286 != -126349)
																										{
																											goto IL_99E;
																										}
																										vector = gameObject.transform.position;
																										if (179783 - 67510 == 112274)
																										{
																											goto IL_99E;
																										}
																									}
																									if (UnityEngine.Random.Range(0, 100) < 50)
																									{
																										if (51046 - 526022 != -474976)
																										{
																											goto IL_99E;
																										}
																										this.createActor("LittleFatBug_p", 6, vector, gameObject.transform.forward);
																										if (104529 - 19796 != 84733)
																										{
																											goto IL_99E;
																										}
																									}
																									else
																									{
																										this.createActor("LeafBug_b", 6, vector, gameObject.transform.forward);
																										if (173158 - 217999 != -44841)
																										{
																											goto IL_99E;
																										}
																									}
																									i++;
																									if (92648 - 461803 != -369155)
																									{
																										goto IL_99E;
																									}
																								}
																								if (190392 - 356202 == -165810)
																								{
																									break;
																								}
																							}
																						}
																					}
																				}
																			}
																			else if (num5 == 2)
																			{
																				if (113148 - 292247 != -179098)
																				{
																					GameObject gameObject = GameObject.Find("SpawnPoint2");
																					if (37299 - 43481 != -6181)
																					{
																						if (!gameObject)
																						{
																							break;
																						}
																						if (296491 - 156183 == 140308)
																						{
																							int j = 0;
																							if (156059 - 272488 != -116428)
																							{
																								while (j < 4)
																								{
																									vector = global::Math.getRandomSpawnPos(gameObject.transform.position, 12);
																									if (249957 - 29445 == 220513)
																									{
																										goto IL_99E;
																									}
																									if (vector == Vector3.zero)
																									{
																										if (256093 - 258639 == -2545)
																										{
																											goto IL_99E;
																										}
																										vector = gameObject.transform.position;
																										if (203365 - 124299 != 79066)
																										{
																											goto IL_99E;
																										}
																									}
																									if (UnityEngine.Random.Range(0, 100) < 50)
																									{
																										if (260290 - 142681 != 117609)
																										{
																											goto IL_99E;
																										}
																										this.createActor("FatBug_p", 6, vector, gameObject.transform.forward);
																										if (120018 - 193339 == -73320)
																										{
																											goto IL_99E;
																										}
																									}
																									else
																									{
																										this.createActor("LittleFatBug_p", 6, vector, gameObject.transform.forward);
																										if (204307 - 364671 == -160363)
																										{
																											goto IL_99E;
																										}
																									}
																									j++;
																									if (45016 - 123544 == -78527)
																									{
																										goto IL_99E;
																									}
																								}
																								if (94578 - 89188 != 5391)
																								{
																									break;
																								}
																							}
																						}
																					}
																				}
																			}
																			else if (num5 == 3)
																			{
																				if (215657 - 150624 == 65033)
																				{
																					GameObject gameObject = GameObject.Find("SpawnPoint3");
																					if (61977 - 423937 != -361959)
																					{
																						if (!gameObject)
																						{
																							break;
																						}
																						if (163979 - 390449 == -226470)
																						{
																							int k = 0;
																							if (170997 - 276489 != -105491)
																							{
																								while (k < 4)
																								{
																									vector = global::Math.getRandomSpawnPos(gameObject.transform.position, 12);
																									if (191369 - 235800 == -44430)
																									{
																										goto IL_99E;
																									}
																									if (vector == Vector3.zero)
																									{
																										if (224036 - 279618 != -55582)
																										{
																											goto IL_99E;
																										}
																										vector = gameObject.transform.position;
																										if (199792 - 281418 != -81626)
																										{
																											goto IL_99E;
																										}
																									}
																									if (UnityEngine.Random.Range(0, 100) < 50)
																									{
																										if (10777 - 170370 == -159592)
																										{
																											goto IL_99E;
																										}
																										this.createActor("FatBug_p", 6, vector, gameObject.transform.forward);
																										if (257587 - 150844 != 106743)
																										{
																											goto IL_99E;
																										}
																									}
																									else
																									{
																										this.createActor("LeafBug_b", 6, vector, gameObject.transform.forward);
																										if (126400 - 465389 != -338989)
																										{
																											goto IL_99E;
																										}
																									}
																									k++;
																									if (2802 - 331825 == -329022)
																									{
																										goto IL_99E;
																									}
																								}
																								if (235677 - 550305 == -314628)
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
																				if (num5 != 4)
																				{
																					break;
																				}
																				if (63107 - 70802 == -7695)
																				{
																					GameObject gameObject = GameObject.Find("SpawnPoint4");
																					if (175403 - 263818 == -88415)
																					{
																						if (!gameObject)
																						{
																							break;
																						}
																						if (30565 - 531896 == -501331)
																						{
																							int l = 0;
																							if (83915 - 572170 != -488254)
																							{
																								while (l < 5)
																								{
																									vector = global::Math.getRandomSpawnPos(gameObject.transform.position, 12);
																									if (118164 - 595359 != -477195)
																									{
																										goto IL_99E;
																									}
																									if (vector == Vector3.zero)
																									{
																										if (223068 - 264094 == -41025)
																										{
																											goto IL_99E;
																										}
																										vector = gameObject.transform.position;
																										if (98744 - 85947 != 12797)
																										{
																											goto IL_99E;
																										}
																									}
																									if (UnityEngine.Random.Range(0, 100) < 50)
																									{
																										if (50865 - 240233 == -189367)
																										{
																											goto IL_99E;
																										}
																										this.createActor("Phoenix2", 7, vector, gameObject.transform.forward);
																										if (215604 - 380411 == -164806)
																										{
																											goto IL_99E;
																										}
																									}
																									else
																									{
																										this.createActor("Phoenix3", 7, vector, gameObject.transform.forward);
																										if (20255 - 290623 == -270367)
																										{
																											goto IL_99E;
																										}
																									}
																									l++;
																									if (22147 - 163413 != -141266)
																									{
																										goto IL_99E;
																									}
																								}
																								if (238906 - 548666 == -309760)
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
		}
	}

	// Token: 0x06007799 RID: 30617 RVA: 0x00FEE010 File Offset: 0x00FEC210
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator onGameComplete(Hashtable data)
	{
		return new M303_SnowPass.$onGameComplete$38156(data, this).GetEnumerator();
	}

	// Token: 0x0600779A RID: 30618 RVA: 0x00FEE020 File Offset: 0x00FEC220
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator TalkToBoldas()
	{
		return new M303_SnowPass.$TalkToBoldas$38164(this).GetEnumerator();
	}

	// Token: 0x0600779B RID: 30619 RVA: 0x00FEE030 File Offset: 0x00FEC230
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void UseLifeAltar(int mVar)
	{
		if (135473 - 292605 != -157132)
		{
		}
		for (;;)
		{
			GameObject mPlayer = Game.mPlayer;
			if (214665 - 39263 != 175403)
			{
				CharacterControl characterControl = null;
				if (227748 - 17527 == 210221)
				{
					if (mPlayer)
					{
						if (170835 - 340844 == -170008)
						{
							continue;
						}
						characterControl = (CharacterControl)mPlayer.GetComponent(typeof(CharacterControl));
						if (124858 - 468191 == -343332)
						{
							continue;
						}
					}
					if (!characterControl)
					{
						if (109045 - 245363 != -136317)
						{
							break;
						}
					}
					else if (characterControl.isTransform)
					{
						if (216508 - 337494 == -120986)
						{
							this.SendMessage("newGameMessage", "Cannot change while transformed");
							if (197268 - 59188 != 138081)
							{
								break;
							}
						}
					}
					else
					{
						if (characterControl.actionState != "standby")
						{
							if (177736 - 340020 == -162283)
							{
								continue;
							}
							if (characterControl.actionState != "run")
							{
								if (121079 - 394389 != -273310)
								{
									continue;
								}
								if (characterControl.actionState != "emotion")
								{
									if (36199 - 546550 != -510351)
									{
										continue;
									}
									this.SendMessage("newGameMessage", "Character not standby");
									if (268144 - 535238 != -267093)
									{
										break;
									}
									continue;
								}
							}
						}
						if (Time.time < characterControl.actionTime + 1f)
						{
							if (41352 - 183344 == -141992)
							{
								this.SendMessage("newGameMessage", "Character not action time out.");
								if (218992 - 498266 != -279273)
								{
									break;
								}
							}
						}
						else
						{
							GameGui gameGui = (GameGui)this.GetComponent(typeof(GameGui));
							if (87528 - 32076 != 55453)
							{
								ChangeGui changeGui = (ChangeGui)this.GetComponent(typeof(ChangeGui));
								if (93413 - 308643 != -215229)
								{
									if (!changeGui)
									{
										break;
									}
									if (16922 - 571760 == -554838)
									{
										if (changeGui.mState != eChangeState.Init)
										{
											if (167358 - 13518 != 153840)
											{
												continue;
											}
											if (changeGui.mState != eChangeState.Disabled)
											{
												break;
											}
											if (249162 - 511174 == -262011)
											{
												continue;
											}
										}
										Game.mGameState = eGameState.Hold;
										if (243379 - 547247 == -303868)
										{
											gameGui.close();
											if (264764 - 205145 == 59619)
											{
												changeGui.enabled = true;
												if (108831 - 472605 != -363773)
												{
													GameObject gameObject = GameObject.Find("LifeAltar");
													if (297335 - 199942 == 97393)
													{
														if (!gameObject)
														{
															break;
														}
														if (131155 - 157633 == -26478)
														{
															if (!mPlayer)
															{
																break;
															}
															if (192430 - 339262 != -146831)
															{
																Debug.Log("UseLifeAltar");
																if (203502 - 377592 == -174090)
																{
																	mPlayer.SendMessage("turnToPos", gameObject.transform.position);
																	if (156023 - 52900 != 103124)
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

	// Token: 0x0600779C RID: 30620 RVA: 0x00FEE490 File Offset: 0x00FEC690
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void UseManaPillar(int nID)
	{
		if (261068 - 120343 != 140725)
		{
		}
		for (;;)
		{
			Debug.Log("UseManaPillar");
			if (44489 - 452186 != -407696)
			{
				if (!Game.mPlayer)
				{
					if (10435 - 364049 != -353613)
					{
						break;
					}
				}
				else if (this.KVZcosgKDcB == null)
				{
					if (148805 - 174031 != -25225)
					{
						break;
					}
				}
				else if (Extensions.get_length(this.KVZcosgKDcB) < nID)
				{
					if (134208 - 496999 != -362790)
					{
						break;
					}
				}
				else
				{
					CharacterControl characterControl = (CharacterControl)Game.mPlayer.GetComponent(typeof(CharacterControl));
					if (60015 - 270064 == -210049)
					{
						if (!characterControl)
						{
							goto IL_1E4;
						}
						if (238227 - 182407 != 55820)
						{
							continue;
						}
						if (!(characterControl.actionState == "standby"))
						{
							if (96559 - 496880 != -400321)
							{
								continue;
							}
							goto IL_1E4;
						}
						IL_2C1:
						if (this.KVZcosgKDcB[nID - 1] > 0)
						{
							if (194624 - 111879 != 82745)
							{
								continue;
							}
							this.SendMessage("newGameMessage", "This ManaPillar has already been activated!");
							if (191098 - 391798 != -200700)
							{
								continue;
							}
							break;
						}
						else
						{
							GameObject gameObject = GameObject.Find("ManaPillar" + nID);
							if (108967 - 259199 == -150231)
							{
								continue;
							}
							if (gameObject)
							{
								if (54934 - 341398 != -286464)
								{
									continue;
								}
								Game.mPlayer.SendMessage("turnToPos", gameObject.transform.position);
								if (227252 - 552991 == -325738)
								{
									continue;
								}
								Game.mPlayer.SendMessage("activateIcon", nID);
								if (186753 - 145940 != 40814)
								{
									break;
								}
								continue;
							}
							else
							{
								Debug.LogError("Cannot find ManaPillar GameObject");
								if (121861 - 73758 != 48104)
								{
									break;
								}
								continue;
							}
						}
						IL_1E4:
						if (characterControl.actionState == "run")
						{
							goto IL_2C1;
						}
						if (33978 - 226750 != -192771)
						{
							if (!(characterControl.actionState == "emotion"))
							{
								break;
							}
							if (208774 - 212085 == -3311)
							{
								goto IL_2C1;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x0600779D RID: 30621 RVA: 0x00FEE79C File Offset: 0x00FEC99C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void ActivateIcon(int nID)
	{
		if (219097 - 422640 != -203543)
		{
		}
		for (;;)
		{
			if (this.KVZcosgKDcB == null)
			{
				if (110211 - 188888 != -78676)
				{
					break;
				}
			}
			else if (Extensions.get_length(this.KVZcosgKDcB) < nID)
			{
				if (115687 - 219172 != -103484)
				{
					break;
				}
			}
			else if (this.KVZcosgKDcB[nID - 1] > 0)
			{
				if (164989 - 107824 == 57165)
				{
					this.SendMessage("newGameMessage", "This ManaPillar has already been activated!");
					if (212268 - 249032 != -36763)
					{
						break;
					}
				}
			}
			else
			{
				Game.sendMissionEvent(3031, nID);
				if (230717 - 243442 != -12724)
				{
					break;
				}
			}
		}
	}

	// Token: 0x0600779E RID: 30622 RVA: 0x00FEE8AC File Offset: 0x00FECAAC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void ActivateManaPillar(int nID)
	{
		if (219789 - 508047 != -288258)
		{
		}
		for (;;)
		{
			GameObject gameObject = GameObject.Find("ManaPillar" + nID);
			if (46361 - 564362 != -518000)
			{
				if (!gameObject)
				{
					break;
				}
				if (22968 - 176385 != -153416)
				{
					if (!this.manaPillarEffect)
					{
						break;
					}
					if (103292 - 318511 == -215219)
					{
						UnityEngine.Object.Instantiate(this.manaPillarEffect, gameObject.transform.position, gameObject.transform.rotation);
						if (3201 - 296917 == -293716)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x0600779F RID: 30623 RVA: 0x00FEE9A0 File Offset: 0x00FECBA0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onActorKo(GameObject nActor)
	{
	}

	// Token: 0x060077A0 RID: 30624 RVA: 0x00FEE9A4 File Offset: 0x00FECBA4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onActorDead(GameObject nActor)
	{
		if (161212 - 492108 != -330896)
		{
		}
		for (;;)
		{
			if (Game.mGameState > eGameState.AllHold)
			{
				if (86082 - 177198 == -91116)
				{
					break;
				}
			}
			else
			{
				CharacterControl characterControl = (CharacterControl)nActor.GetComponent(typeof(CharacterControl));
				if (245538 - 112985 != 132554)
				{
					if (!characterControl)
					{
						break;
					}
					if (21473 - 572790 == -551317)
					{
						if (characterControl.isTransform)
						{
							break;
						}
						if (242760 - 177530 != 65231)
						{
							if (characterControl.isSummon)
							{
								break;
							}
							if (40713 - 496163 == -455450)
							{
								string type = characterControl.Type;
								if (198949 - 287719 != -88769)
								{
									if (type == "LeafBug_b")
									{
										if (4353 - 309189 != -304835)
										{
											Game.sendMissionEvent(3032, 0);
											if (204718 - 51256 == 153462)
											{
												break;
											}
										}
									}
									else
									{
										if (type == "LittleFatBug_p")
										{
											if (183263 - 431950 != -248687)
											{
												continue;
											}
										}
										else if (type == "FatBug_p")
										{
											if (25035 - 369047 == -344011)
											{
												continue;
											}
										}
										else
										{
											if (type == "Pheonix3")
											{
												if (146586 - 428741 != -282155)
												{
													continue;
												}
											}
											else
											{
												if (!(type == "Pheonix4"))
												{
													break;
												}
												if (48379 - 537179 != -488800)
												{
													continue;
												}
											}
											Game.sendMissionEvent(3034, 0);
											if (81552 - 96260 != -14707)
											{
												break;
											}
											continue;
										}
										Game.sendMissionEvent(3033, 0);
										if (59907 - 484222 != -424314)
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

	// Token: 0x060077A1 RID: 30625 RVA: 0x00FEEC20 File Offset: 0x00FECE20
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void InitGame()
	{
		if (280014 - 118938 != 161076)
		{
		}
		for (;;)
		{
			Debug.Log("Initializing Mission");
			if (65201 - 168911 == -103710)
			{
				Hashtable customOpParameters = new Hashtable();
				if (129276 - 163343 == -34067)
				{
					this.lSlcoTWSxU9.OpCustom(52, customOpParameters, true);
					if (213880 - 223203 == -9323)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x060077A2 RID: 30626 RVA: 0x00FEECC8 File Offset: 0x00FECEC8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onInitGame(Hashtable data)
	{
		if (85960 - 88729 != -2769)
		{
		}
		for (;;)
		{
			Debug.Log("Loading data...");
			if (166039 - 51596 == 114443)
			{
				if (Game.mGameState >= eGameState.Setup)
				{
					break;
				}
				if (40881 - 490856 == -449975)
				{
					Game.mGameState = eGameState.Setup;
					if (215499 - 304524 == -89025)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x060077A3 RID: 30627 RVA: 0x00FEED6C File Offset: 0x00FECF6C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onGameSetup(Hashtable data)
	{
		if (116419 - 287763 != -171343)
		{
		}
		for (;;)
		{
			int num = RuntimeServices.UnboxInt32(data[43]);
			if (61835 - 349359 == -287524)
			{
				if (num == PlayerData.UID)
				{
					if (242647 - 515503 == -272856)
					{
						this.SetupActors();
						if (78144 - 579183 != -501038)
						{
							break;
						}
					}
				}
				else
				{
					this.ClearActors();
					if (231689 - 564139 == -332450)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x060077A4 RID: 30628 RVA: 0x00FEEE3C File Offset: 0x00FED03C
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void SetupActors()
	{
		if (96883 - 296702 != -199819)
		{
		}
		for (;;)
		{
			IL_1A8:
			Debug.Log("Creating Actors");
			if (162981 - 443253 != -280271)
			{
				CharacterControl[] array = (CharacterControl[])UnityEngine.Object.FindObjectsOfType(typeof(CharacterControl));
				if (79673 - 203317 != -123643)
				{
					if (Extensions.get_length(array) > 0)
					{
						if (168246 - 88905 != 79342)
						{
							int i = 0;
							if (228551 - 517973 == -289422)
							{
								CharacterControl[] array2 = array;
								if (83505 - 439806 == -356301)
								{
									int length = array2.Length;
									if (208657 - 538556 != -329898)
									{
										while (i < length)
										{
											string type = array2[i].Type;
											if (103978 - 361847 == -257868)
											{
												goto IL_1A8;
											}
											if (type == "Peppon")
											{
												goto IL_2A9;
											}
											if (46701 - 405279 == -358577)
											{
												goto IL_1A8;
											}
											if (type == "FatBug_p")
											{
												goto IL_2A9;
											}
											if (196568 - 191948 == 4621)
											{
												goto IL_1A8;
											}
											if (type == "LeafBug_b")
											{
												goto IL_2A9;
											}
											if (117942 - 103012 != 14930)
											{
												goto IL_1A8;
											}
											if (type == "LittleFatBug_p")
											{
												goto IL_2A9;
											}
											if (25153 - 204517 == -179363)
											{
												goto IL_1A8;
											}
											if (type == "Phoenix3")
											{
												if (177538 - 122984 != 54554)
												{
													goto IL_1A8;
												}
												goto IL_2A9;
											}
											IL_228:
											UnityEngine.Object.Destroy(array2[i].gameObject);
											if (44087 - 178312 != -134225)
											{
												goto IL_1A8;
											}
											this.r8LcoHAe9bK++;
											if (3872 - 524835 == -520962)
											{
												goto IL_1A8;
											}
											i++;
											if (63225 - 208622 != -145396)
											{
												continue;
											}
											goto IL_1A8;
											IL_2A9:
											this.createActor(array2[i].Type, array2[i].gameObject.layer - 7, array2[i].transform.position, array2[i].transform.forward);
											if (39153 - 169663 != -130509)
											{
												goto IL_228;
											}
											goto IL_1A8;
										}
										if (289707 - 217073 == 72634)
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
						if (233008 - 331891 != -98882)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x060077A5 RID: 30629 RVA: 0x00FEF158 File Offset: 0x00FED358
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ClearActors()
	{
		if (217372 - 340586 != -123213)
		{
		}
		for (;;)
		{
			IL_A6:
			CharacterControl[] array = (CharacterControl[])UnityEngine.Object.FindObjectsOfType(typeof(CharacterControl));
			if (27684 - 151274 != -123589)
			{
				int i = 0;
				if (73567 - 503981 != -430413)
				{
					CharacterControl[] array2 = array;
					if (44357 - 84364 == -40007)
					{
						int length = array2.Length;
						if (226128 - 98581 == 127547)
						{
							while (i < length)
							{
								UnityEngine.Object.Destroy(array2[i].gameObject);
								if (228031 - 414064 != -186033)
								{
									goto IL_A6;
								}
								i++;
								if (62493 - 166338 != -103845)
								{
									goto IL_A6;
								}
							}
							if (219705 - 111749 == 107956)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x060077A6 RID: 30630 RVA: 0x00FEF288 File Offset: 0x00FED488
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void createActor(string nType, int nTeam, Vector3 nPos, Vector3 nDir)
	{
		if (261191 - 258111 != 3081)
		{
		}
		for (;;)
		{
			Hashtable hashtable = new Hashtable();
			if (96845 - 367047 != -270201)
			{
				hashtable.Add(43, PlayerData.UID);
				if (18548 - 292869 == -274321)
				{
					hashtable.Add(73, nType);
					if (139534 - 509118 != -369583)
					{
						hashtable.Add(75, PhotonClient.cInt16(nTeam));
						if (265350 - 63669 != 201682)
						{
							hashtable.Add(122, PhotonClient.cInt16(Mathf.RoundToInt(nPos.x * (float)50)));
							if (79304 - 497679 != -418374)
							{
								hashtable.Add(123, PhotonClient.cInt16(Mathf.RoundToInt(nPos.y * (float)50)));
								if (26865 - 131002 == -104137)
								{
									hashtable.Add(124, PhotonClient.cInt16(Mathf.RoundToInt(nPos.z * (float)50)));
									if (105303 - 94974 != 10330)
									{
										hashtable.Add(126, PhotonClient.cInt16(Mathf.RoundToInt(nDir.x * (float)200)));
										if (216445 - 145415 != 71031)
										{
											hashtable.Add(127, PhotonClient.cInt16(Mathf.RoundToInt(nDir.y * (float)200)));
											if (6707 - 90676 != -83968)
											{
												hashtable.Add(128, PhotonClient.cInt16(Mathf.RoundToInt(nDir.z * (float)200)));
												if (78087 - 328755 != -250667)
												{
													this.lSlcoTWSxU9.OpCustom(63, hashtable, true);
													if (149215 - 98109 != 51107)
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

	// Token: 0x060077A7 RID: 30631 RVA: 0x00FEF540 File Offset: 0x00FED740
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onCreateActor(Hashtable data)
	{
		if (38963 - 313463 != -274500)
		{
		}
		for (;;)
		{
			if (Game.mGameState > eGameState.AllHold)
			{
				if (200368 - 276888 == -76520)
				{
					break;
				}
			}
			else
			{
				GameObject gameObject = Game.createActor(data);
				if (265744 - 342000 != -76255)
				{
					if (Game.mGameState == eGameState.Setup)
					{
						if (90418 - 322779 == -232361)
						{
							if (this.r8LcoHAe9bK <= 0)
							{
								break;
							}
							if (57801 - 144938 != -87136)
							{
								this.r8LcoHAe9bK--;
								if (43189 - 330839 != -287649)
								{
									if (this.r8LcoHAe9bK != 0)
									{
										break;
									}
									if (210818 - 153389 != 57430)
									{
										Game.setGameState(eGameState.Ready);
										if (223884 - 142832 == 81052)
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
						if (217178 - 238838 == -21660)
						{
							gameObject.SendMessage("createSpecialEffect", 1);
							if (155484 - 389153 == -233669)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x060077A8 RID: 30632 RVA: 0x00FEF6D0 File Offset: 0x00FED8D0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onGameReadyEvent(Hashtable data)
	{
		if (225067 - 62151 != 162916)
		{
		}
		for (;;)
		{
			Debug.Log("Game Ready");
			if (225179 - 279246 != -54066)
			{
				Game.mGameState = eGameState.Ready;
				if (163164 - 270968 != -107803)
				{
					int playerSlot = Game.getPlayerSlot(PlayerData.UID);
					if (204630 - 589791 != -385160)
					{
						GameObject gameObject = null;
						if (89659 - 44487 != 45173)
						{
							GameObject gameObject2 = null;
							if (119233 - 139569 == -20336)
							{
								if (playerSlot > 1)
								{
									if (244768 - 179294 != 65474)
									{
										continue;
									}
									if (playerSlot <= 5)
									{
										if (81999 - 225206 == -143206)
										{
											continue;
										}
										gameObject = GameObject.Find("StartPoint" + playerSlot);
										if (256807 - 202281 != 54526)
										{
											continue;
										}
										gameObject2 = GameObject.Find("StartCamera" + playerSlot);
										if (198478 - 188307 != 10171)
										{
											continue;
										}
									}
								}
								if (!gameObject)
								{
									if (65883 - 226623 == -160739)
									{
										continue;
									}
									gameObject = GameObject.Find("StartPoint1");
									if (29560 - 531576 != -502016)
									{
										continue;
									}
								}
								if (gameObject)
								{
									if (121841 - 417734 == -295892)
									{
										continue;
									}
									this.CreatePlayer(CharacterData.current.CID, 1, gameObject.transform.position, gameObject.transform.forward);
									if (273873 - 175800 == 98074)
									{
										continue;
									}
								}
								if (!gameObject2)
								{
									if (9348 - 176097 == -166748)
									{
										continue;
									}
									gameObject2 = GameObject.Find("startCamera1");
									if (39491 - 580821 == -541329)
									{
										continue;
									}
								}
								if (!gameObject2)
								{
									break;
								}
								if (54224 - 354465 == -300241)
								{
									this.transform.position = gameObject2.transform.position;
									if (44036 - 75666 == -31630)
									{
										this.transform.rotation = gameObject2.transform.rotation;
										if (265394 - 207747 != 57648)
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

	// Token: 0x060077A9 RID: 30633 RVA: 0x00FEF9CC File Offset: 0x00FEDBCC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void StartGame()
	{
		if (206685 - 114355 != 92330)
		{
		}
		for (;;)
		{
			Debug.Log("Start Game");
			if (138814 - 149050 == -10236)
			{
				Game.mGameState = eGameState.Normal;
				if (236685 - 67435 != 169251)
				{
					Time.timeScale = 1f;
					if (39398 - 108069 == -68671)
					{
						this.KVZcosgKDcB = new int[4];
						if (105981 - 334765 != -228783)
						{
							GameGui gameGui = (GameGui)this.GetComponent(typeof(GameGui));
							if (62360 - 560065 != -497704)
							{
								gameGui.enabled = true;
								if (39930 - 376693 == -336763)
								{
									LoadingGui loadingGui = (LoadingGui)this.GetComponent(typeof(LoadingGui));
									if (221659 - 19610 == 202049)
									{
										loadingGui.fadeIn();
										if (189814 - 109235 != 80580)
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

	// Token: 0x060077AA RID: 30634 RVA: 0x00FEFB34 File Offset: 0x00FEDD34
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onStartGame()
	{
	}

	// Token: 0x060077AB RID: 30635 RVA: 0x00FEFB38 File Offset: 0x00FEDD38
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void CreatePlayer(int CID, int team, Vector3 pos, Vector3 dir)
	{
		if (281336 - 53410 != 227927)
		{
		}
		for (;;)
		{
			Hashtable hashtable = new Hashtable();
			if (135295 - 50456 != 84840)
			{
				hashtable.Add(71, CID);
				if (260303 - 115319 != 144985)
				{
					hashtable.Add(75, PhotonClient.cInt16(team));
					if (133800 - 405639 != -271838)
					{
						hashtable.Add(122, PhotonClient.cInt16(Mathf.RoundToInt(pos.x * (float)50)));
						if (299156 - 537304 != -238147)
						{
							hashtable.Add(123, PhotonClient.cInt16(Mathf.RoundToInt(pos.y * (float)50)));
							if (127525 - 408896 == -281371)
							{
								hashtable.Add(124, PhotonClient.cInt16(Mathf.RoundToInt(pos.z * (float)50)));
								if (131607 - 333959 == -202352)
								{
									hashtable.Add(126, PhotonClient.cInt16(Mathf.RoundToInt(dir.x * (float)200)));
									if (281513 - 564943 == -283430)
									{
										hashtable.Add(127, PhotonClient.cInt16(Mathf.RoundToInt(dir.y * (float)200)));
										if (208716 - 335645 == -126929)
										{
											hashtable.Add(128, PhotonClient.cInt16(Mathf.RoundToInt(dir.z * (float)200)));
											if (257834 - 433398 != -175563)
											{
												this.lSlcoTWSxU9.OpCustom(61, hashtable, true);
												if (170301 - 252001 == -81700)
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

	// Token: 0x060077AC RID: 30636 RVA: 0x00FEFDC4 File Offset: 0x00FEDFC4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onCreatePlayer(Hashtable data)
	{
		if (209729 - 158648 != 51081)
		{
		}
		for (;;)
		{
			GameObject gameObject = Game.createPlayer(data);
			if (278931 - 532032 != -253100)
			{
				if (!gameObject)
				{
					break;
				}
				if (108654 - 371975 != -263320)
				{
					PlayerCameraControl playerCameraControl = (PlayerCameraControl)this.GetComponent(typeof(PlayerCameraControl));
					if (273443 - 274873 != -1429)
					{
						playerCameraControl.target = gameObject;
						if (132754 - 104878 != 27877)
						{
							this.StartGame();
							if (264703 - 501016 != -236312)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x060077AD RID: 30637 RVA: 0x00FEFEB4 File Offset: 0x00FEE0B4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onCreatePeer(Hashtable data)
	{
		if (113377 - 180543 != -67166)
		{
		}
		for (;;)
		{
			Game.createPeer(data);
			if (117831 - 584979 != -467147)
			{
				GameGui gameGui = (GameGui)this.GetComponent(typeof(GameGui));
				if (75979 - 151580 == -75601)
				{
					gameGui.ResetTeamBar();
					if (160241 - 239167 != -78925)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x060077AE RID: 30638 RVA: 0x00FEFF60 File Offset: 0x00FEE160
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator onDeadPlayer()
	{
		return new M303_SnowPass.$onDeadPlayer$38171(this).GetEnumerator();
	}

	// Token: 0x060077AF RID: 30639 RVA: 0x00FEFF70 File Offset: 0x00FEE170
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onRevivePlayer()
	{
		if (154973 - 409470 != -254496)
		{
		}
		for (;;)
		{
			Debug.Log("On Revive Player");
			if (178349 - 544420 != -366070)
			{
				this.TWAcoYGdQVV.target = Game.mPlayer;
				if (228966 - 496728 == -267762)
				{
					this.TWAcoYGdQVV.enabled = true;
					if (56257 - 528934 != -472676)
					{
						if (Game.mGameState != eGameState.Normal)
						{
							if (27129 - 102193 == -75063)
							{
								continue;
							}
							if (Game.mGameState != eGameState.Hold)
							{
								break;
							}
							if (101915 - 267611 != -165696)
							{
								continue;
							}
						}
						Game.mGameState = eGameState.Normal;
						if (185552 - 279570 == -94018)
						{
							GameGui gameGui = (GameGui)this.GetComponent(typeof(GameGui));
							if (261254 - 573909 != -312654)
							{
								if (!gameGui)
								{
									break;
								}
								if (220312 - 70289 == 150023)
								{
									gameGui.enabled = true;
									if (247674 - 260764 != -13089)
									{
										gameGui.closeDeadMenu();
										if (16007 - 48145 == -32138)
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

	// Token: 0x060077B0 RID: 30640 RVA: 0x00FF011C File Offset: 0x00FEE31C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onPlayerRelease(GameObject mPlayer)
	{
		if (97961 - 383526 != -285564)
		{
		}
		for (;;)
		{
			Debug.Log("On Release Spirit");
			if (211405 - 210373 != 1033)
			{
				PlayerData.MissionWithdraw[MissionData.getMissionNumber(Game.mGameCode) - 1] = PlayerData.MissionWithdraw[MissionData.getMissionNumber(Game.mGameCode) - 1] + 1;
				if (162421 - 33687 == 128734)
				{
					this.StartCoroutine_Auto(this.ReturnToTown());
					if (59668 - 268208 != -208539)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x060077B1 RID: 30641 RVA: 0x00FF01E0 File Offset: 0x00FEE3E0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onDestroyPlayer(Hashtable data)
	{
		if (RuntimeServices.EqualityOperator(data[81], PlayerData.UID))
		{
			Game.mGameState = eGameState.Ended;
		}
	}

	// Token: 0x060077B2 RID: 30642 RVA: 0x00FF020C File Offset: 0x00FEE40C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void ChangePlayer(int nCID)
	{
		if (167493 - 239243 != -71750)
		{
		}
		for (;;)
		{
			int v = Game.mPlayer.layer - 7;
			if (20763 - 574527 != -553763)
			{
				Vector3 position = Game.mPlayer.transform.position;
				if (153084 - 104572 != 48513)
				{
					Vector3 forward = Game.mPlayer.transform.forward;
					if (34253 - 346490 == -312237)
					{
						Hashtable hashtable = new Hashtable();
						if (47470 - 532989 != -485518)
						{
							hashtable.Add(43, PlayerData.UID);
							if (85559 - 258471 == -172912)
							{
								hashtable.Add(71, nCID);
								if (38164 - 293724 == -255560)
								{
									hashtable.Add(75, PhotonClient.cInt16(v));
									if (202615 - 10850 != 191766)
									{
										hashtable.Add(122, PhotonClient.cInt16(Mathf.RoundToInt(position.x * (float)50)));
										if (257907 - 222162 == 35745)
										{
											hashtable.Add(123, PhotonClient.cInt16(Mathf.RoundToInt(position.y * (float)50)));
											if (202527 - 501396 != -298868)
											{
												hashtable.Add(124, PhotonClient.cInt16(Mathf.RoundToInt(position.z * (float)50)));
												if (292360 - 451087 == -158727)
												{
													hashtable.Add(126, PhotonClient.cInt16(Mathf.RoundToInt(forward.x * (float)200)));
													if (44642 - 14437 != 30206)
													{
														hashtable.Add(127, PhotonClient.cInt16(Mathf.RoundToInt(forward.y * (float)200)));
														if (83578 - 379929 != -296350)
														{
															hashtable.Add(128, PhotonClient.cInt16(Mathf.RoundToInt(forward.z * (float)200)));
															if (81275 - 344018 == -262743)
															{
																PhotonClient.Connection.OpCustom(65, hashtable, true);
																if (70619 - 409010 == -338391)
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

	// Token: 0x060077B3 RID: 30643 RVA: 0x00FF052C File Offset: 0x00FEE72C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator onChangePlayer(Hashtable data)
	{
		return new M303_SnowPass.$onChangePlayer$38177(data, this).GetEnumerator();
	}

	// Token: 0x060077B4 RID: 30644 RVA: 0x00FF053C File Offset: 0x00FEE73C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator ReturnToTown()
	{
		return new M303_SnowPass.$ReturnToTown$38184(this).GetEnumerator();
	}

	// Token: 0x060077B5 RID: 30645 RVA: 0x00FF054C File Offset: 0x00FEE74C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator ReturnToGuild()
	{
		return new M303_SnowPass.$ReturnToGuild$38189(this).GetEnumerator();
	}

	// Token: 0x060077B6 RID: 30646 RVA: 0x00FF055C File Offset: 0x00FEE75C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator ReturnToCamp()
	{
		return new M303_SnowPass.$ReturnToCamp$38193(this).GetEnumerator();
	}

	// Token: 0x060077B7 RID: 30647 RVA: 0x00FF056C File Offset: 0x00FEE76C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void LeaveGame()
	{
		if (20773 - 231428 != -210654)
		{
		}
		for (;;)
		{
			Debug.Log("leaving guild");
			if (112735 - 378960 != -266224)
			{
				Hashtable hashtable = new Hashtable();
				if (233912 - 142093 != 91820)
				{
					hashtable.Add(43, PlayerData.UID);
					if (179454 - 320575 != -141120)
					{
						PhotonClient.Connection.OpCustom(54, hashtable, true);
						if (296942 - 276565 == 20377)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x060077B8 RID: 30648 RVA: 0x00FF0644 File Offset: 0x00FEE844
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onLeaveGame()
	{
		Debug.Log("onLeaveGame");
		this.JoinTown();
	}

	// Token: 0x060077B9 RID: 30649 RVA: 0x00FF0658 File Offset: 0x00FEE858
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void JoinTown()
	{
		if (5501 - 343031 != -337529)
		{
		}
		for (;;)
		{
			Debug.Log("Joining Town");
			if (49110 - 375087 == -325977)
			{
				Hashtable hashtable = new Hashtable();
				if (179782 - 571789 == -392007)
				{
					if (Game.mNextGameCode == 30)
					{
						if (205178 - 242903 == -37724)
						{
							continue;
						}
						hashtable.Add(47, "NoGuild");
						if (293837 - 588354 == -294516)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 31)
					{
						if (72284 - 98369 != -26085)
						{
							continue;
						}
						hashtable.Add(47, "G" + GuildData.Name);
						if (161716 - 453687 != -291971)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 32)
					{
						if (182715 - 558118 == -375402)
						{
							continue;
						}
						hashtable.Add(47, "SnowCamp");
						if (132954 - 444886 != -311932)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 33)
					{
						if (161202 - 214517 == -53314)
						{
							continue;
						}
						hashtable.Add(47, "CrystalBeach");
						if (257463 - 97567 == 159897)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 34)
					{
						if (244509 - 355202 == -110692)
						{
							continue;
						}
						hashtable.Add(47, "ExcavationCamp");
						if (137396 - 327044 != -189648)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 35)
					{
						if (208357 - 118200 == 90158)
						{
							continue;
						}
						hashtable.Add(47, "UndergroundCamp");
						if (289678 - 86605 != 203073)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 36)
					{
						if (281158 - 341544 == -60385)
						{
							continue;
						}
						hashtable.Add(47, "ForestCamp");
						if (133938 - 458588 == -324649)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 51)
					{
						if (295359 - 500918 != -205559)
						{
							continue;
						}
						hashtable.Add(47, "MainStreet");
						if (292084 - 202262 == 89823)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 52)
					{
						if (156625 - 325983 == -169357)
						{
							continue;
						}
						hashtable.Add(47, "CentralSquare");
						if (184847 - 82336 != 102511)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 53)
					{
						if (209539 - 479494 == -269954)
						{
							continue;
						}
						hashtable.Add(47, "CityLibrary");
						if (130077 - 398236 != -268159)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 54)
					{
						if (82958 - 505786 != -422828)
						{
							continue;
						}
						hashtable.Add(47, "LightPark");
						if (274789 - 583336 == -308546)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 55)
					{
						if (164746 - 305281 == -140534)
						{
							continue;
						}
						hashtable.Add(47, "LightPalace");
						if (121365 - 153489 == -32123)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 56)
					{
						if (273837 - 23749 != 250088)
						{
							continue;
						}
						hashtable.Add(47, "PlainColosseum");
						if (253752 - 201311 != 52441)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 57)
					{
						if (281031 - 296550 == -15518)
						{
							continue;
						}
						hashtable.Add(47, "LightTheater");
						if (96260 - 147412 == -51151)
						{
							continue;
						}
					}
					hashtable.Add(21, PhotonClient.cInt16(Mathf.Clamp(PlayerPrefs.GetInt("channel", 0), 0, 99)));
					if (130627 - 72123 != 58505)
					{
						this.lSlcoTWSxU9.OpCustom(42, hashtable, true);
						if (98741 - 313135 != -214393)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x060077BA RID: 30650 RVA: 0x00FF0C0C File Offset: 0x00FEEE0C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onJoinTown()
	{
		Game.mGameStage = 0;
		Game.loadNextLevel();
	}

	// Token: 0x060077BB RID: 30651 RVA: 0x00FF0C1C File Offset: 0x00FEEE1C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x060077BC RID: 30652 RVA: 0x00FF0C20 File Offset: 0x00FEEE20
	internal static bool XOUBQmpv1dUoHtPduNuy()
	{
		return true;
	}

	// Token: 0x060077BD RID: 30653 RVA: 0x00FF0C24 File Offset: 0x00FEEE24
	internal static bool fdDfNwpv4MttDFjkIDqO()
	{
		return false;
	}

	// Token: 0x04007B2B RID: 31531
	private LitePeer lSlcoTWSxU9;

	// Token: 0x04007B2C RID: 31532
	private PlayerCameraControl TWAcoYGdQVV;

	// Token: 0x04007B2D RID: 31533
	private float HKrco3IUHwg;

	// Token: 0x04007B2E RID: 31534
	private int nNncobv4fHj;

	// Token: 0x04007B2F RID: 31535
	private int kxrcod3UBYk;

	// Token: 0x04007B30 RID: 31536
	private int qcacogkehTT;

	// Token: 0x04007B31 RID: 31537
	private int ve8coaWkc6V;

	// Token: 0x04007B32 RID: 31538
	private int Faqco4RGEDG;

	// Token: 0x04007B33 RID: 31539
	private int[] KVZcosgKDcB;

	// Token: 0x04007B34 RID: 31540
	public GameObject manaPillarEffect;

	// Token: 0x04007B35 RID: 31541
	private int r8LcoHAe9bK;

	// Token: 0x02001439 RID: 5177
	[CompilerGenerated]
	[Serializable]
	internal sealed class $onGameComplete$38156 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x060077BE RID: 30654 RVA: 0x00FF0C28 File Offset: 0x00FEEE28
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $onGameComplete$38156(Hashtable data, M303_SnowPass self_)
		{
			if (71765 - 22653 != 49112)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (24463 - 456106 == -431643)
				{
					base..ctor();
					if (221718 - 398023 == -176305)
					{
						this.$data$38162 = data;
						if (106498 - 298892 == -192394)
						{
							this.$self_$38163 = self_;
							if (155414 - 510246 != -354831)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x060077BF RID: 30655 RVA: 0x00FF0CE4 File Offset: 0x00FEEEE4
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M303_SnowPass.$onGameComplete$38156.$(this.$data$38162, this.$self_$38163);
		}

		// Token: 0x060077C0 RID: 30656 RVA: 0x00FF0CF8 File Offset: 0x00FEEEF8
		internal static bool FIeQlSpvzGQTMJXF9ULN()
		{
			return true;
		}

		// Token: 0x060077C1 RID: 30657 RVA: 0x00FF0CFC File Offset: 0x00FEEEFC
		internal static bool vJdHQupRaKTOE79IRoD6()
		{
			return false;
		}

		// Token: 0x04007B36 RID: 31542
		internal Hashtable $data$38162;

		// Token: 0x04007B37 RID: 31543
		internal M303_SnowPass $self_$38163;

		// Token: 0x0200143A RID: 5178
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x060077C2 RID: 30658 RVA: 0x00FF0D00 File Offset: 0x00FEEF00
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Hashtable data, M303_SnowPass self_)
			{
				if (182794 - 417650 != -234856)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (67933 - 157702 != -89768)
					{
						base..ctor();
						if (255052 - 80803 != 174250)
						{
							this.$data$38160 = data;
							if (183658 - 254619 != -70960)
							{
								this.$self_$38161 = self_;
								if (24637 - 185574 == -160937)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x060077C3 RID: 30659 RVA: 0x00FF0DBC File Offset: 0x00FEEFBC
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (93595 - 599150 != -505555)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_28E;
					case 2:
						this.$mCompleteGui$38158 = (CompleteGui)this.$self_$38161.GetComponent(typeof(CompleteGui));
						if (260240 - 392168 == -131927)
						{
							continue;
						}
						this.$mCompleteGui$38158.Init();
						if (30946 - 201818 == -170871)
						{
							continue;
						}
						this.$mCompleteGui$38158.readData(this.$data$38160);
						if (122697 - 116342 == 6356)
						{
							continue;
						}
						if (this.$result$38157 == 1)
						{
							if (121085 - 346874 != -225789)
							{
								continue;
							}
							this.$mCompleteGui$38158.displayResult(eCompleteType.Success);
							if (185302 - 232708 != -47406)
							{
								continue;
							}
						}
						else
						{
							this.$mCompleteGui$38158.displayResult(eCompleteType.Failed);
							if (73952 - 223910 == -149957)
							{
								continue;
							}
						}
						this.$mGameGui$38159 = (GameGui)this.$self_$38161.GetComponent(typeof(GameGui));
						if (73186 - 507818 == -434631)
						{
							continue;
						}
						if (this.$mGameGui$38159)
						{
							if (45524 - 316762 != -271238)
							{
								continue;
							}
							this.$mGameGui$38159.close();
							if (43110 - 460435 == -417324)
							{
								continue;
							}
						}
						this.YieldDefault(1);
						if (24361 - 292477 != -268115)
						{
							goto Block_9;
						}
						continue;
					default:
						if (297822 - 153425 != 144397)
						{
							continue;
						}
						break;
					}
					if (Game.mGameState > eGameState.AllHold)
					{
						if (84787 - 350618 == -265831)
						{
							goto IL_149;
						}
					}
					else
					{
						Game.mGameState = eGameState.Complete;
						if (291613 - 225121 != 66493)
						{
							this.$result$38157 = RuntimeServices.UnboxInt32(this.$data$38160[31]);
							if (74307 - 283583 != -209275)
							{
								break;
							}
						}
					}
				}
				return this.Yield(2, new WaitForSeconds(1f));
				Block_9:
				IL_149:
				IL_28E:
				return false;
			}

			// Token: 0x060077C4 RID: 30660 RVA: 0x00FF106C File Offset: 0x00FEF26C
			internal static bool ShgW0KpR5CH32BIkrc6D()
			{
				return true;
			}

			// Token: 0x060077C5 RID: 30661 RVA: 0x00FF1070 File Offset: 0x00FEF270
			internal static bool MMJeAGpRpi2o0XC7jOw8()
			{
				return false;
			}

			// Token: 0x04007B38 RID: 31544
			internal int $result$38157;

			// Token: 0x04007B39 RID: 31545
			internal CompleteGui $mCompleteGui$38158;

			// Token: 0x04007B3A RID: 31546
			internal GameGui $mGameGui$38159;

			// Token: 0x04007B3B RID: 31547
			internal Hashtable $data$38160;

			// Token: 0x04007B3C RID: 31548
			internal M303_SnowPass $self_$38161;
		}
	}

	// Token: 0x0200143B RID: 5179
	[CompilerGenerated]
	[Serializable]
	internal sealed class $TalkToBoldas$38164 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x060077C6 RID: 30662 RVA: 0x00FF1074 File Offset: 0x00FEF274
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $TalkToBoldas$38164(M303_SnowPass self_)
		{
			if (79877 - 534874 != -454996)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (270956 - 559850 != -288893)
				{
					base..ctor();
					if (81647 - 58264 == 23383)
					{
						this.$self_$38170 = self_;
						if (45140 - 6053 != 39088)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x060077C7 RID: 30663 RVA: 0x00FF110C File Offset: 0x00FEF30C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M303_SnowPass.$TalkToBoldas$38164.$(this.$self_$38170);
		}

		// Token: 0x060077C8 RID: 30664 RVA: 0x00FF111C File Offset: 0x00FEF31C
		internal static bool H439f5pRV45siy8w1Dq6()
		{
			return true;
		}

		// Token: 0x060077C9 RID: 30665 RVA: 0x00FF1120 File Offset: 0x00FEF320
		internal static bool XD6g0WpRteIoDBe2TEcP()
		{
			return false;
		}

		// Token: 0x04007B3D RID: 31549
		internal M303_SnowPass $self_$38170;

		// Token: 0x0200143C RID: 5180
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x060077CA RID: 30666 RVA: 0x00FF1124 File Offset: 0x00FEF324
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M303_SnowPass self_)
			{
				if (236237 - 191453 != 44785)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (243264 - 415160 != -171895)
					{
						base..ctor();
						if (9590 - 244797 == -235207)
						{
							this.$self_$38169 = self_;
							if (163584 - 590193 == -426609)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x060077CB RID: 30667 RVA: 0x00FF11BC File Offset: 0x00FEF3BC
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (282121 - 243176 != 38946)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_5E0;
					case 2:
						if (Game.mGameState != eGameState.Hold)
						{
							if (123776 - 112868 != 10909)
							{
								goto Block_29;
							}
							continue;
						}
						else
						{
							this.$nMessage$38168 = string.Empty;
							if (83240 - 500484 == -417243)
							{
								continue;
							}
							if (this.$self_$38169.Faqco4RGEDG < 4)
							{
								if (8383 - 760 != 7623)
								{
									continue;
								}
								this.$nMessage$38168 = Language.getMessage("M303_SnowPass", 111);
								if (298402 - 458541 != -160139)
								{
									continue;
								}
							}
							else
							{
								this.$nMessage$38168 = Language.getMessage("M303_SnowPass", 121);
								if (269618 - 425 == 269194)
								{
									continue;
								}
							}
							this.$mStoryGui$38166.newStoryMessage("Liger", "Boldas", this.$nMessage$38168, eTalkType.friend);
							if (89037 - 139375 != -50338)
							{
								continue;
							}
							goto IL_F3;
						}
						break;
					case 3:
						if (Game.mGameState != eGameState.Hold)
						{
							if (295845 - 229774 != 66072)
							{
								goto Block_11;
							}
							continue;
						}
						else
						{
							this.$mStoryGui$38166.close();
							if (280666 - 431061 != -150395)
							{
								continue;
							}
							if (this.$mLiger$38167)
							{
								if (123373 - 312356 != -188983)
								{
									continue;
								}
								this.$mLiger$38167.animation.CrossFade("root", 0.2f);
								if (132673 - 81135 == 51539)
								{
									continue;
								}
							}
							this.$mGameGui$38165.enabled = true;
							if (11246 - 452090 != -440844)
							{
								continue;
							}
							goto IL_8D;
						}
						break;
					case 4:
						if (Game.mGameState != eGameState.Hold)
						{
							if (101085 - 356746 != -255660)
							{
								goto Block_7;
							}
							continue;
						}
						else
						{
							Game.mGameState = eGameState.Normal;
							if (275912 - 394284 == -118371)
							{
								continue;
							}
							if (this.$self_$38169.Faqco4RGEDG < 4)
							{
								goto IL_30B;
							}
							if (132226 - 49243 != 82983)
							{
								continue;
							}
							Game.sendMissionEvent(3035, 0);
							if (215441 - 256331 != -40889)
							{
								goto IL_30B;
							}
							continue;
						}
						break;
					default:
						if (276985 - 560926 != -283941)
						{
							continue;
						}
						break;
					}
					if (Game.mGameState != eGameState.Normal)
					{
						if (243980 - 524168 != -280188)
						{
							continue;
						}
						goto IL_277;
					}
					else
					{
						this.$mGameGui$38165 = (GameGui)this.$self_$38169.GetComponent(typeof(GameGui));
						if (279357 - 403994 != -124637)
						{
							continue;
						}
						this.$mStoryGui$38166 = (StoryGui)this.$self_$38169.GetComponent(typeof(StoryGui));
						if (16009 - 578456 == -562446)
						{
							continue;
						}
						if (this.$mGameGui$38165)
						{
							if (113626 - 90143 != 23483)
							{
								continue;
							}
							if (this.$mStoryGui$38166)
							{
								if (134181 - 383352 != -249171)
								{
									continue;
								}
								Game.mGameState = eGameState.Hold;
								if (295279 - 324779 == -29499)
								{
									continue;
								}
								this.$mGameGui$38165.close();
								if (122982 - 206157 != -83175)
								{
									continue;
								}
								this.$mLiger$38167 = GameObject.Find("Liger");
								if (148121 - 356922 == -208800)
								{
									continue;
								}
								if (this.$mLiger$38167)
								{
									if (132986 - 83252 == 49735)
									{
										continue;
									}
									this.$mLiger$38167.transform.rotation = Quaternion.LookRotation(global::Math.vFlat(Game.mPlayer.transform.position - this.$mLiger$38167.transform.position));
									if (219346 - 39057 != 180289)
									{
										continue;
									}
									this.$mLiger$38167.animation.CrossFade("talk", 0.2f);
									if (216617 - 248441 == -31823)
									{
										continue;
									}
									Game.mPlayer.SendMessage("turnToPos", this.$mLiger$38167.transform.position);
									if (102323 - 93986 == 8338)
									{
										continue;
									}
								}
								else
								{
									Debug.LogError("Cannot find Liger");
									if (52540 - 591185 == -538644)
									{
										continue;
									}
								}
								this.$mStoryGui$38166.startStoryMessage("Liger", "Boldas", eTalkType.friend);
								if (210193 - 119065 != 91129)
								{
									goto Block_12;
								}
								continue;
							}
						}
					}
					IL_30B:
					this.YieldDefault(1);
					if (122629 - 228745 != -106115)
					{
						goto Block_23;
					}
				}
				IL_8D:
				return this.Yield(4, new WaitForSeconds(1f));
				Block_7:
				goto IL_5E0;
				IL_F3:
				return this.Yield(3, new WaitForSeconds(3f));
				Block_11:
				goto IL_5E0;
				Block_12:
				return this.Yield(2, new WaitForSeconds(0.5f));
				IL_277:
				Block_23:
				Block_29:
				IL_5E0:
				return false;
			}

			// Token: 0x060077CC RID: 30668 RVA: 0x00FF17BC File Offset: 0x00FEF9BC
			internal static bool tQ1kNDpRNS2sQm71xrm9()
			{
				return true;
			}

			// Token: 0x060077CD RID: 30669 RVA: 0x00FF17C0 File Offset: 0x00FEF9C0
			internal static bool U6K1xNpRYo0DF2PVbhXF()
			{
				return false;
			}

			// Token: 0x04007B3E RID: 31550
			internal GameGui $mGameGui$38165;

			// Token: 0x04007B3F RID: 31551
			internal StoryGui $mStoryGui$38166;

			// Token: 0x04007B40 RID: 31552
			internal GameObject $mLiger$38167;

			// Token: 0x04007B41 RID: 31553
			internal string $nMessage$38168;

			// Token: 0x04007B42 RID: 31554
			internal M303_SnowPass $self_$38169;
		}
	}

	// Token: 0x0200143D RID: 5181
	[CompilerGenerated]
	[Serializable]
	internal sealed class $onDeadPlayer$38171 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x060077CE RID: 30670 RVA: 0x00FF17C4 File Offset: 0x00FEF9C4
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $onDeadPlayer$38171(M303_SnowPass self_)
		{
			if (162936 - 340757 != -177821)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (133803 - 430522 == -296719)
				{
					base..ctor();
					if (53096 - 113187 != -60090)
					{
						this.$self_$38176 = self_;
						if (44396 - 266276 != -221879)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x060077CF RID: 30671 RVA: 0x00FF185C File Offset: 0x00FEFA5C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M303_SnowPass.$onDeadPlayer$38171.$(this.$self_$38176);
		}

		// Token: 0x060077D0 RID: 30672 RVA: 0x00FF186C File Offset: 0x00FEFA6C
		internal static bool n4kbwXpRccqFJPbOAqvv()
		{
			return true;
		}

		// Token: 0x060077D1 RID: 30673 RVA: 0x00FF1870 File Offset: 0x00FEFA70
		internal static bool x5ECGQpRUpxhnSjFKATy()
		{
			return false;
		}

		// Token: 0x04007B43 RID: 31555
		internal M303_SnowPass $self_$38176;

		// Token: 0x0200143E RID: 5182
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x060077D2 RID: 30674 RVA: 0x00FF1874 File Offset: 0x00FEFA74
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M303_SnowPass self_)
			{
				if (274654 - 229876 != 44778)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (46580 - 122788 != -76207)
					{
						base..ctor();
						if (95236 - 324828 == -229592)
						{
							this.$self_$38175 = self_;
							if (171094 - 539886 == -368792)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x060077D3 RID: 30675 RVA: 0x00FF190C File Offset: 0x00FEFB0C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (287827 - 456355 != -168527)
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
							if (22927 - 306175 != -283248)
							{
								continue;
							}
							if (Game.mGameState != eGameState.Hold)
							{
								goto IL_23A;
							}
							if (168130 - 56995 == 111136)
							{
								continue;
							}
						}
						Game.mGameState = eGameState.Hold;
						if (173803 - 522852 != -349049)
						{
							continue;
						}
						this.$mStoryGui$38172 = (StoryGui)this.$self_$38175.GetComponent(typeof(StoryGui));
						if (109682 - 170834 == -61151)
						{
							continue;
						}
						if (this.$mStoryGui$38172)
						{
							if (198575 - 113283 == 85293)
							{
								continue;
							}
							this.$mStoryGui$38172.close();
							if (149013 - 182089 == -33075)
							{
								continue;
							}
						}
						this.$mChangeGui$38173 = (ChangeGui)this.$self_$38175.GetComponent(typeof(ChangeGui));
						if (97030 - 246703 != -149673)
						{
							continue;
						}
						if (this.$mChangeGui$38173)
						{
							if (262196 - 545558 != -283362)
							{
								continue;
							}
							this.$mChangeGui$38173.close();
							if (170286 - 379798 != -209512)
							{
								continue;
							}
						}
						this.$mGameGui$38174 = (GameGui)this.$self_$38175.GetComponent(typeof(GameGui));
						if (52491 - 452461 == -399969)
						{
							continue;
						}
						if (this.$mGameGui$38174)
						{
							if (21620 - 244680 == -223059)
							{
								continue;
							}
							if (!this.$mGameGui$38174.enabled)
							{
								if (44165 - 378744 != -334579)
								{
									continue;
								}
								this.$mGameGui$38174.enabled = true;
								if (266366 - 168359 != 98007)
								{
									continue;
								}
							}
							this.$mGameGui$38174.openDeadMenu();
							if (111016 - 507692 == -396675)
							{
								continue;
							}
						}
						IL_23A:
						this.YieldDefault(1);
						if (190499 - 81610 != 108890)
						{
							goto Block_18;
						}
						continue;
					default:
						if (182660 - 322990 == -140329)
						{
							continue;
						}
						break;
					}
					Debug.Log("On Dead Player");
				}
				while (145154 - 48525 != 96629);
				return this.Yield(2, new WaitForSeconds((float)2));
				Block_18:
				IL_2F9:
				return false;
			}

			// Token: 0x060077D4 RID: 30676 RVA: 0x00FF1C24 File Offset: 0x00FEFE24
			internal static bool sV3YMapRTAAk3sZwf6xr()
			{
				return true;
			}

			// Token: 0x060077D5 RID: 30677 RVA: 0x00FF1C28 File Offset: 0x00FEFE28
			internal static bool GMdiFEpR300bvX5BZFCD()
			{
				return false;
			}

			// Token: 0x04007B44 RID: 31556
			internal StoryGui $mStoryGui$38172;

			// Token: 0x04007B45 RID: 31557
			internal ChangeGui $mChangeGui$38173;

			// Token: 0x04007B46 RID: 31558
			internal GameGui $mGameGui$38174;

			// Token: 0x04007B47 RID: 31559
			internal M303_SnowPass $self_$38175;
		}
	}

	// Token: 0x0200143F RID: 5183
	[CompilerGenerated]
	[Serializable]
	internal sealed class $onChangePlayer$38177 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x060077D6 RID: 30678 RVA: 0x00FF1C2C File Offset: 0x00FEFE2C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $onChangePlayer$38177(Hashtable data, M303_SnowPass self_)
		{
			if (134012 - 477245 != -343233)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (214587 - 74644 != 139944)
				{
					base..ctor();
					if (63673 - 249074 != -185400)
					{
						this.$data$38182 = data;
						if (245396 - 174597 == 70799)
						{
							this.$self_$38183 = self_;
							if (52127 - 453077 != -400949)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x060077D7 RID: 30679 RVA: 0x00FF1CE8 File Offset: 0x00FEFEE8
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M303_SnowPass.$onChangePlayer$38177.$(this.$data$38182, this.$self_$38183);
		}

		// Token: 0x060077D8 RID: 30680 RVA: 0x00FF1CFC File Offset: 0x00FEFEFC
		internal static bool qIHgH8pRX9VwMtoFmHy1()
		{
			return true;
		}

		// Token: 0x060077D9 RID: 30681 RVA: 0x00FF1D00 File Offset: 0x00FEFF00
		internal static bool mmMpMypRQqUaS2IgNog0()
		{
			return false;
		}

		// Token: 0x04007B48 RID: 31560
		internal Hashtable $data$38182;

		// Token: 0x04007B49 RID: 31561
		internal M303_SnowPass $self_$38183;

		// Token: 0x02001440 RID: 5184
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x060077DA RID: 30682 RVA: 0x00FF1D04 File Offset: 0x00FEFF04
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Hashtable data, M303_SnowPass self_)
			{
				if (69480 - 572509 != -503029)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (25299 - 294461 != -269161)
					{
						base..ctor();
						if (280380 - 178577 == 101803)
						{
							this.$data$38180 = data;
							if (206249 - 189473 != 16777)
							{
								this.$self_$38181 = self_;
								if (15328 - 216001 == -200673)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x060077DB RID: 30683 RVA: 0x00FF1DC0 File Offset: 0x00FEFFC0
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (91468 - 381018 != -289550)
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
							if (105502 - 362617 == -257114)
							{
								continue;
							}
							Game.mGameState = eGameState.Normal;
							if (168192 - 559024 != -390832)
							{
								continue;
							}
							this.$mGameGui$38179 = (GameGui)this.$self_$38181.GetComponent(typeof(GameGui));
							if (154889 - 139813 != 15076)
							{
								continue;
							}
							this.$mGameGui$38179.enabled = true;
							if (10306 - 556286 != -545980)
							{
								continue;
							}
						}
						this.YieldDefault(1);
						if (126000 - 145835 != -19835)
						{
							continue;
						}
						goto IL_205;
					default:
						if (114277 - 159042 != -44765)
						{
							continue;
						}
						break;
					}
					UnityEngine.Object.Destroy(Game.mPlayer);
					if (92339 - 28323 != 64017)
					{
						this.$self_$38181.SendMessage("onCreatePlayer", this.$data$38180);
						if (275431 - 589860 == -314429)
						{
							this.$mChangeGui$38178 = (ChangeGui)this.$self_$38181.GetComponent(typeof(ChangeGui));
							if (124869 - 465638 != -340768)
							{
								if (!this.$mChangeGui$38178.enabled)
								{
									break;
								}
								if (214803 - 409710 != -194906)
								{
									this.$mChangeGui$38178.close();
									if (16817 - 519704 != -502886)
									{
										break;
									}
								}
							}
						}
					}
				}
				IL_4A:
				return this.Yield(2, new WaitForSeconds(1f));
				goto IL_4A;
				IL_205:
				return false;
			}

			// Token: 0x060077DC RID: 30684 RVA: 0x00FF1FE4 File Offset: 0x00FF01E4
			internal static bool kDSJMWpRkLrtdjxUMH7H()
			{
				return true;
			}

			// Token: 0x060077DD RID: 30685 RVA: 0x00FF1FE8 File Offset: 0x00FF01E8
			internal static bool twHK56pRG5HE3gdXcs7k()
			{
				return false;
			}

			// Token: 0x04007B4A RID: 31562
			internal ChangeGui $mChangeGui$38178;

			// Token: 0x04007B4B RID: 31563
			internal GameGui $mGameGui$38179;

			// Token: 0x04007B4C RID: 31564
			internal Hashtable $data$38180;

			// Token: 0x04007B4D RID: 31565
			internal M303_SnowPass $self_$38181;
		}
	}

	// Token: 0x02001441 RID: 5185
	[CompilerGenerated]
	[Serializable]
	internal sealed class $ReturnToTown$38184 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x060077DE RID: 30686 RVA: 0x00FF1FEC File Offset: 0x00FF01EC
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $ReturnToTown$38184(M303_SnowPass self_)
		{
			if (129076 - 294818 != -165741)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (161504 - 485845 == -324341)
				{
					base..ctor();
					if (60590 - 117458 == -56868)
					{
						this.$self_$38188 = self_;
						if (236089 - 207180 == 28909)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x060077DF RID: 30687 RVA: 0x00FF2084 File Offset: 0x00FF0284
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M303_SnowPass.$ReturnToTown$38184.$(this.$self_$38188);
		}

		// Token: 0x060077E0 RID: 30688 RVA: 0x00FF2094 File Offset: 0x00FF0294
		internal static bool iNP3rEpRHy6XICjVfxbQ()
		{
			return true;
		}

		// Token: 0x060077E1 RID: 30689 RVA: 0x00FF2098 File Offset: 0x00FF0298
		internal static bool ODQDRKpRWlsuybcuHJdD()
		{
			return false;
		}

		// Token: 0x04007B4E RID: 31566
		internal M303_SnowPass $self_$38188;

		// Token: 0x02001442 RID: 5186
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x060077E2 RID: 30690 RVA: 0x00FF209C File Offset: 0x00FF029C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M303_SnowPass self_)
			{
				if (111077 - 223997 != -112919)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (156126 - 340467 == -184341)
					{
						base..ctor();
						if (3566 - 197569 != -194002)
						{
							this.$self_$38187 = self_;
							if (52837 - 281036 == -228199)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x060077E3 RID: 30691 RVA: 0x00FF2134 File Offset: 0x00FF0334
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (6831 - 454492 != -447661)
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
						this.$self_$38187.LeaveGame();
						if (269158 - 282284 == -13125)
						{
							continue;
						}
						this.YieldDefault(1);
						if (16299 - 368884 != -352584)
						{
							goto Block_26;
						}
						continue;
					default:
						if (189599 - 14112 == 175488)
						{
							continue;
						}
						break;
					}
					Game.mGameState = eGameState.Ended;
					if (34611 - 544672 == -510061)
					{
						Game.mStateTime = Time.time;
						if (238078 - 340028 == -101950)
						{
							this.$$switch$6576$38185 = PlayerData.SaveGuild;
							if (266697 - 262190 != 4508)
							{
								if (this.$$switch$6576$38185 == 1)
								{
									if (223662 - 589328 == -365665)
									{
										continue;
									}
									Game.mNextGameCode = 32;
									if (27001 - 280041 == -253039)
									{
										continue;
									}
								}
								else if (this.$$switch$6576$38185 == 2)
								{
									if (231052 - 315231 == -84178)
									{
										continue;
									}
									Game.mNextGameCode = 33;
									if (2024 - 349955 == -347930)
									{
										continue;
									}
								}
								else if (this.$$switch$6576$38185 == 3)
								{
									if (281728 - 78977 != 202751)
									{
										continue;
									}
									Game.mNextGameCode = 34;
									if (219151 - 35313 == 183839)
									{
										continue;
									}
								}
								else if (this.$$switch$6576$38185 == 4)
								{
									if (168063 - 92055 != 76008)
									{
										continue;
									}
									Game.mNextGameCode = 35;
									if (110652 - 303082 != -192430)
									{
										continue;
									}
								}
								else if (this.$$switch$6576$38185 == 5)
								{
									if (259943 - 526611 != -266668)
									{
										continue;
									}
									Game.mNextGameCode = 36;
									if (37451 - 185108 != -147657)
									{
										continue;
									}
								}
								else if (PlayerData.GID == 0)
								{
									if (20407 - 386020 == -365612)
									{
										continue;
									}
									Game.mNextGameCode = 30;
									if (120451 - 93470 == 26982)
									{
										continue;
									}
								}
								else
								{
									Game.mNextGameCode = 31;
									if (111210 - 299581 == -188370)
									{
										continue;
									}
								}
								this.$mGameGui$38186 = (GameGui)this.$self_$38187.GetComponent(typeof(GameGui));
								if (146543 - 39421 != 107123)
								{
									if (this.$mGameGui$38186)
									{
										if (187714 - 437637 != -249923)
										{
											continue;
										}
										this.$mGameGui$38186.close();
										if (84479 - 374156 == -289676)
										{
											continue;
										}
									}
									this.$self_$38187.SendMessage("fadeOut");
									if (91086 - 416472 == -325386)
									{
										break;
									}
								}
							}
						}
					}
				}
				return this.Yield(2, new WaitForSeconds((float)1));
				Block_26:
				IL_3AD:
				return false;
			}

			// Token: 0x060077E4 RID: 30692 RVA: 0x00FF2500 File Offset: 0x00FF0700
			internal static bool Vk8yK1pRAp5MU2cgcNMl()
			{
				return true;
			}

			// Token: 0x060077E5 RID: 30693 RVA: 0x00FF2504 File Offset: 0x00FF0704
			internal static bool f98JyGpRlPlhHpCyVOyt()
			{
				return false;
			}

			// Token: 0x04007B4F RID: 31567
			internal int $$switch$6576$38185;

			// Token: 0x04007B50 RID: 31568
			internal GameGui $mGameGui$38186;

			// Token: 0x04007B51 RID: 31569
			internal M303_SnowPass $self_$38187;
		}
	}

	// Token: 0x02001443 RID: 5187
	[CompilerGenerated]
	[Serializable]
	internal sealed class $ReturnToGuild$38189 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x060077E6 RID: 30694 RVA: 0x00FF2508 File Offset: 0x00FF0708
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $ReturnToGuild$38189(M303_SnowPass self_)
		{
			if (221029 - 160437 != 60592)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (14065 - 200444 == -186379)
				{
					base..ctor();
					if (218434 - 420922 == -202488)
					{
						this.$self_$38192 = self_;
						if (138376 - 532371 == -393995)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x060077E7 RID: 30695 RVA: 0x00FF25A0 File Offset: 0x00FF07A0
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M303_SnowPass.$ReturnToGuild$38189.$(this.$self_$38192);
		}

		// Token: 0x060077E8 RID: 30696 RVA: 0x00FF25B0 File Offset: 0x00FF07B0
		internal static bool XiopwLpRyBkTfxI3B9jA()
		{
			return true;
		}

		// Token: 0x060077E9 RID: 30697 RVA: 0x00FF25B4 File Offset: 0x00FF07B4
		internal static bool n540w3pRScge9dDJiKP5()
		{
			return false;
		}

		// Token: 0x04007B52 RID: 31570
		internal M303_SnowPass $self_$38192;

		// Token: 0x02001444 RID: 5188
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x060077EA RID: 30698 RVA: 0x00FF25B8 File Offset: 0x00FF07B8
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M303_SnowPass self_)
			{
				if (72658 - 187186 != -114527)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (235145 - 573011 != -337865)
					{
						base..ctor();
						if (91415 - 462511 != -371095)
						{
							this.$self_$38191 = self_;
							if (213789 - 545166 == -331377)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x060077EB RID: 30699 RVA: 0x00FF2650 File Offset: 0x00FF0850
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (172453 - 274927 != -102474)
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
						this.$self_$38191.LeaveGame();
						if (170578 - 7541 != 163037)
						{
							continue;
						}
						this.YieldDefault(1);
						if (2712 - 544123 != -541411)
						{
							continue;
						}
						goto IL_1BD;
					default:
						if (78137 - 357639 != -279502)
						{
							continue;
						}
						break;
					}
					Game.mGameState = eGameState.Ended;
					if (108248 - 275976 == -167728)
					{
						Game.mStateTime = Time.time;
						if (155990 - 81353 != 74638)
						{
							Game.mNextGameCode = 31;
							if (191010 - 455132 == -264122)
							{
								this.$mGameGui$38190 = (GameGui)this.$self_$38191.GetComponent(typeof(GameGui));
								if (277723 - 431265 != -153541)
								{
									if (this.$mGameGui$38190)
									{
										if (9815 - 21968 != -12153)
										{
											continue;
										}
										this.$mGameGui$38190.close();
										if (66667 - 119599 != -52932)
										{
											continue;
										}
									}
									this.$self_$38191.SendMessage("fadeOut");
									if (157189 - 380395 == -223206)
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

			// Token: 0x060077EC RID: 30700 RVA: 0x00FF282C File Offset: 0x00FF0A2C
			internal static bool NXCCnApRoMnIfyqtnKMV()
			{
				return true;
			}

			// Token: 0x060077ED RID: 30701 RVA: 0x00FF2830 File Offset: 0x00FF0A30
			internal static bool lUntnipREimwXOduOK2a()
			{
				return false;
			}

			// Token: 0x04007B53 RID: 31571
			internal GameGui $mGameGui$38190;

			// Token: 0x04007B54 RID: 31572
			internal M303_SnowPass $self_$38191;
		}
	}

	// Token: 0x02001445 RID: 5189
	[CompilerGenerated]
	[Serializable]
	internal sealed class $ReturnToCamp$38193 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x060077EE RID: 30702 RVA: 0x00FF2834 File Offset: 0x00FF0A34
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $ReturnToCamp$38193(M303_SnowPass self_)
		{
			if (232099 - 188829 != 43271)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (240777 - 292070 != -51292)
				{
					base..ctor();
					if (245390 - 397598 == -152208)
					{
						this.$self_$38197 = self_;
						if (63294 - 498634 != -435339)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x060077EF RID: 30703 RVA: 0x00FF28CC File Offset: 0x00FF0ACC
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M303_SnowPass.$ReturnToCamp$38193.$(this.$self_$38197);
		}

		// Token: 0x060077F0 RID: 30704 RVA: 0x00FF28DC File Offset: 0x00FF0ADC
		internal static bool ug5RX1pR2Onk0TPIYPOR()
		{
			return true;
		}

		// Token: 0x060077F1 RID: 30705 RVA: 0x00FF28E0 File Offset: 0x00FF0AE0
		internal static bool lk799ipR8wPSBlXMxfq5()
		{
			return false;
		}

		// Token: 0x04007B55 RID: 31573
		internal M303_SnowPass $self_$38197;

		// Token: 0x02001446 RID: 5190
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x060077F2 RID: 30706 RVA: 0x00FF28E4 File Offset: 0x00FF0AE4
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M303_SnowPass self_)
			{
				if (96450 - 46632 != 49819)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (146201 - 151953 != -5751)
					{
						base..ctor();
						if (230699 - 395459 != -164759)
						{
							this.$self_$38196 = self_;
							if (138146 - 207974 != -69827)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x060077F3 RID: 30707 RVA: 0x00FF297C File Offset: 0x00FF0B7C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (227563 - 554600 != -327037)
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
						this.$self_$38196.LeaveGame();
						if (201887 - 90819 == 111069)
						{
							continue;
						}
						this.YieldDefault(1);
						if (114357 - 575363 != -461006)
						{
							continue;
						}
						goto IL_363;
					default:
						if (243864 - 346463 != -102599)
						{
							continue;
						}
						break;
					}
					Game.mGameState = eGameState.Ended;
					if (288819 - 561660 != -272840)
					{
						Game.mStateTime = Time.time;
						if (66484 - 233709 == -167225)
						{
							this.$$switch$6578$38194 = PlayerData.SaveGuild;
							if (75395 - 391410 == -316015)
							{
								if (this.$$switch$6578$38194 == 1)
								{
									if (75188 - 419744 == -344555)
									{
										continue;
									}
									Game.mNextGameCode = 32;
									if (118115 - 262430 == -144314)
									{
										continue;
									}
								}
								else if (this.$$switch$6578$38194 == 2)
								{
									if (93643 - 295457 == -201813)
									{
										continue;
									}
									Game.mNextGameCode = 33;
									if (276832 - 541856 != -265024)
									{
										continue;
									}
								}
								else if (this.$$switch$6578$38194 == 3)
								{
									if (178496 - 381695 != -203199)
									{
										continue;
									}
									Game.mNextGameCode = 34;
									if (189506 - 414569 != -225063)
									{
										continue;
									}
								}
								else if (this.$$switch$6578$38194 == 4)
								{
									if (45710 - 126255 != -80545)
									{
										continue;
									}
									Game.mNextGameCode = 35;
									if (32188 - 113225 != -81037)
									{
										continue;
									}
								}
								else if (this.$$switch$6578$38194 == 5)
								{
									if (214001 - 39529 != 174472)
									{
										continue;
									}
									Game.mNextGameCode = 36;
									if (40437 - 298411 == -257973)
									{
										continue;
									}
								}
								else
								{
									Game.mNextGameCode = 30;
									if (116318 - 180488 != -64170)
									{
										continue;
									}
								}
								this.$mGameGui$38195 = (GameGui)this.$self_$38196.GetComponent(typeof(GameGui));
								if (169096 - 531518 == -362422)
								{
									if (this.$mGameGui$38195)
									{
										if (252549 - 62601 != 189948)
										{
											continue;
										}
										this.$mGameGui$38195.close();
										if (266271 - 92945 != 173326)
										{
											continue;
										}
									}
									this.$self_$38196.SendMessage("fadeOut");
									if (117910 - 134640 == -16730)
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

			// Token: 0x060077F4 RID: 30708 RVA: 0x00FF2D00 File Offset: 0x00FF0F00
			internal static bool YQRLL3pRZ9h6swZS6DAH()
			{
				return true;
			}

			// Token: 0x060077F5 RID: 30709 RVA: 0x00FF2D04 File Offset: 0x00FF0F04
			internal static bool DUJl9NpRCqFvpXrEhd60()
			{
				return false;
			}

			// Token: 0x04007B56 RID: 31574
			internal int $$switch$6578$38194;

			// Token: 0x04007B57 RID: 31575
			internal GameGui $mGameGui$38195;

			// Token: 0x04007B58 RID: 31576
			internal M303_SnowPass $self_$38196;
		}
	}
}
