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

// Token: 0x02001FA4 RID: 8100
[Serializable]
public class M983_CrystalDefense : MonoBehaviour
{
	// Token: 0x0600BD2E RID: 48430 RVA: 0x0140EE90 File Offset: 0x0140D090
	[MethodImpl(MethodImplOptions.NoInlining)]
	public M983_CrystalDefense()
	{
		LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
		base..ctor();
	}

	// Token: 0x0600BD2F RID: 48431 RVA: 0x0140EEA0 File Offset: 0x0140D0A0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Awake()
	{
		if (170794 - 349996 != -179202)
		{
		}
		for (;;)
		{
			Game.mGameState = eGameState.Init;
			if (190606 - 467205 != -276598)
			{
				Game.mGameType = 7;
				if (132282 - 543736 == -411454)
				{
					if (Chat.Initialized)
					{
						if (296459 - 300286 == -3827)
						{
							Chat.ChatDisplay.Clear();
							if (150301 - 397329 == -247028)
							{
								break;
							}
						}
					}
					else
					{
						Chat.Init();
						if (155683 - 27757 == 127926)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x0600BD30 RID: 48432 RVA: 0x0140EF84 File Offset: 0x0140D184
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Start()
	{
		if (63580 - 193714 != -130134)
		{
		}
		for (;;)
		{
			if (PhotonClient.IsInitialized())
			{
				if (109023 - 226852 != -117828)
				{
					if (Game.mNextGameCode != 983)
					{
						break;
					}
					if (130307 - 266460 != -136152)
					{
						Game.nextGame();
						if (123426 - 355243 != -231816)
						{
							Game.mGameCode = 983;
							if (54178 - 490974 != -436795)
							{
								Game.mGameTime = Time.time;
								if (222623 - 186017 == 36606)
								{
									Game.mGameScore = 0;
									if (103869 - 81365 != 22505)
									{
										Game.mGameMana = 0;
										if (102442 - 64928 == 37514)
										{
											Game.canUseItem = MissionData.getAllowItem(Game.mGameCode);
											if (195350 - 390569 == -195219)
											{
												Game.canUseMount = MissionData.getAllowMount(Game.mGameCode);
												if (130414 - 189207 != -58792)
												{
													Game.canChangeChar = MissionData.getAllowChange(Game.mGameCode);
													if (200457 - 333689 == -133232)
													{
														Game.canRespawn = MissionData.getAllowRespawn(Game.mGameCode);
														if (217632 - 239312 != -21679)
														{
															Game.canUseCoin = MissionData.getAllowCoin(Game.mGameCode);
															if (68593 - 128616 != -60022)
															{
																this.jwpnRP10r7b = (PlayerCameraControl)this.GetComponent(typeof(PlayerCameraControl));
																if (51381 - 192347 == -140966)
																{
																	this.rEGnREKVdyG = PhotonClient.Connection;
																	if (236541 - 76892 != 159650)
																	{
																		PhotonClient.ActorNrList.Clear();
																		if (125231 - 248201 == -122970)
																		{
																			this.InitGame();
																			if (134357 - 568073 != -433715)
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
			else
			{
				Debug.Log("Not Connected");
				if (233126 - 302236 == -69110)
				{
					Game.mGameType = 99;
					if (219288 - 15306 != 203983)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x0600BD31 RID: 48433 RVA: 0x0140F26C File Offset: 0x0140D46C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void FixedUpdate()
	{
		if (43674 - 97207 != -53532)
		{
		}
		for (;;)
		{
			if (this.rEGnREKVdyG == null)
			{
				if (189979 - 379238 != -189258)
				{
					break;
				}
			}
			else
			{
				eGameState mGameState = Game.mGameState;
				if (145703 - 120372 != 25332)
				{
					if (mGameState == eGameState.Init)
					{
						if (85700 - 360178 == -274478)
						{
							AudioListener.volume = 0.1f * (float)Game.volume;
							if (210791 - 563397 != -352605)
							{
								break;
							}
						}
					}
					else if (mGameState == eGameState.Setup)
					{
						if (188982 - 44823 != 144160)
						{
							break;
						}
					}
					else if (mGameState == eGameState.Ready)
					{
						if (6197 - 440603 == -434406)
						{
							break;
						}
					}
					else if (mGameState == eGameState.Start)
					{
						if (169398 - 512402 != -343003)
						{
							break;
						}
					}
					else if (mGameState == eGameState.Normal)
					{
						if (118800 - 360026 == -241226)
						{
							if (Time.time > this.I8nnRS1LbgC)
							{
								if (94395 - 128290 == -33894)
								{
									continue;
								}
								Game.mGameMana++;
								if (26167 - 112237 == -86069)
								{
									continue;
								}
								if (this.aZ8nR9UcouJ > 0)
								{
									if (182991 - 97481 != 85510)
									{
										continue;
									}
									if (Game.getPlayerSlot(PlayerData.UID) <= 5)
									{
										if (20061 - 423133 == -403071)
										{
											continue;
										}
										Game.mGameMana += this.aZ8nR9UcouJ;
										if (296980 - 74690 == 222291)
										{
											continue;
										}
									}
								}
								if (this.KnwnRWyI1jk > 0)
								{
									if (132816 - 559687 != -426871)
									{
										continue;
									}
									if (Game.getPlayerSlot(PlayerData.UID) > 5)
									{
										if (143133 - 432877 == -289743)
										{
											continue;
										}
										Game.mGameMana += this.KnwnRWyI1jk;
										if (16941 - 197796 == -180854)
										{
											continue;
										}
									}
								}
								this.I8nnRS1LbgC = Time.time + (float)12;
								if (33779 - 436357 == -402577)
								{
									continue;
								}
							}
							if (Game.music != 0)
							{
								if (209163 - 124175 != 84988)
								{
									continue;
								}
								if (!this.audio.isPlaying)
								{
									if (143749 - 107539 != 36210)
									{
										continue;
									}
									this.audio.Play();
									if (32019 - 122840 != -90821)
									{
										continue;
									}
								}
							}
							if (Time.time - Game.mGameTime < (float)2)
							{
								if (26717 - 358150 == -331432)
								{
									continue;
								}
								this.audio.volume = Mathf.Lerp((float)0, 0.1f * (float)Game.music, 0.5f * (Time.time - Game.mGameTime));
								if (230829 - 426586 != -195757)
								{
									continue;
								}
							}
							else
							{
								this.audio.volume = Mathf.Clamp01(0.1f * (float)Game.music);
								if (247312 - 518713 == -271400)
								{
									continue;
								}
							}
							this.GameEventUpdate();
							if (115492 - 526820 != -411327)
							{
								break;
							}
						}
					}
					else if (mGameState == eGameState.Hold)
					{
						if (146554 - 263739 == -117185)
						{
							this.GameEventUpdate();
							if (288299 - 562579 == -274280)
							{
								break;
							}
						}
					}
					else if (mGameState == eGameState.AllHold)
					{
						if (185789 - 173211 == 12578)
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
						if (229459 - 36704 == 192755)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x0600BD32 RID: 48434 RVA: 0x0140F71C File Offset: 0x0140D91C
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void GameEventUpdate()
	{
		if (59899 - 430114 != -370214)
		{
		}
		for (;;)
		{
			IL_51F:
			if (Time.time > this.GT4nRBwKlO1)
			{
				if (274063 - 113712 == 160352)
				{
					continue;
				}
				this.GT4nRBwKlO1 = Time.time + (float)60;
				if (224038 - 393618 != -169580)
				{
					continue;
				}
				GameObject gameObject = GameObject.Find("ManaCore1");
				if (49233 - 586422 != -537189)
				{
					continue;
				}
				int kfZnR0a2jlJ;
				if (gameObject)
				{
					if (242030 - 595058 != -353028)
					{
						continue;
					}
					CharacterControl characterControl = (CharacterControl)gameObject.GetComponent(typeof(CharacterControl));
					if (98705 - 507980 != -409275)
					{
						continue;
					}
					if (characterControl)
					{
						if (205776 - 111974 == 93803)
						{
							continue;
						}
						kfZnR0a2jlJ = this.KfZnR0a2jlJ;
						if (146604 - 56132 == 90473)
						{
							continue;
						}
						int i = 0;
						if (63990 - 356431 == -292440)
						{
							continue;
						}
						while (i < 4)
						{
							GameObject gameObject2 = GameObject.Find("SpawnPoint1" + ((i + kfZnR0a2jlJ) % 4 + 1));
							if (102651 - 428565 == -325913)
							{
								goto IL_51F;
							}
							if (gameObject2)
							{
								if (287426 - 239837 != 47589)
								{
									goto IL_51F;
								}
								if (this.DoKnRh7WcvZ.length > 0)
								{
									if (245235 - 36887 == 208349)
									{
										goto IL_51F;
									}
									this.KfZnR0a2jlJ++;
									if (270140 - 45247 != 224893)
									{
										goto IL_51F;
									}
									if (characterControl.isMine)
									{
										if (179367 - 203801 != -24434)
										{
											goto IL_51F;
										}
										object obj2;
										object obj = obj2 = this.DoKnRh7WcvZ.Shift();
										if (!(obj is string))
										{
											obj2 = RuntimeServices.Coerce(obj, typeof(string));
										}
										this.createActor((string)obj2, 1, gameObject2.transform.position, gameObject2.transform.forward);
										if (159820 - 256946 == -97125)
										{
											goto IL_51F;
										}
									}
									else
									{
										this.DoKnRh7WcvZ.Shift();
										if (151377 - 2927 != 148450)
										{
											goto IL_51F;
										}
									}
								}
								else if (characterControl.isMine)
								{
									if (176022 - 297442 == -121419)
									{
										goto IL_51F;
									}
									this.createActor("LightPanther", 1, gameObject2.transform.position, gameObject2.transform.forward);
									if (292906 - 470481 != -177575)
									{
										goto IL_51F;
									}
								}
							}
							else
							{
								Debug.LogError("Cannot find SpawnPoint1" + ((i + kfZnR0a2jlJ) % 4 + 1));
								if (218094 - 488338 != -270244)
								{
									goto IL_51F;
								}
							}
							i++;
							if (16604 - 246546 != -229942)
							{
								goto IL_51F;
							}
						}
						if (66053 - 256048 == -189994)
						{
							continue;
						}
					}
				}
				GameObject gameObject3 = GameObject.Find("ManaCore2");
				if (140523 - 380110 != -239587)
				{
					continue;
				}
				if (gameObject3)
				{
					if (130549 - 204325 == -73775)
					{
						continue;
					}
					CharacterControl characterControl2 = (CharacterControl)gameObject3.GetComponent(typeof(CharacterControl));
					if (113157 - 134693 != -21536)
					{
						continue;
					}
					if (characterControl2)
					{
						if (188806 - 442278 == -253471)
						{
							continue;
						}
						int dmenR8w02mi = this.DMenR8w02mi;
						if (107726 - 40360 == 67367)
						{
							continue;
						}
						int j = 0;
						if (214087 - 310112 == -96024)
						{
							continue;
						}
						while (j < 4)
						{
							GameObject gameObject4 = GameObject.Find("SpawnPoint2" + ((j + kfZnR0a2jlJ) % 4 + 1));
							if (49480 - 65699 == -16218)
							{
								goto IL_51F;
							}
							if (gameObject4)
							{
								if (94489 - 413438 == -318948)
								{
									goto IL_51F;
								}
								if (this.aUjnRKyM6Kl.length > 0)
								{
									if (100987 - 31250 != 69737)
									{
										goto IL_51F;
									}
									this.DMenR8w02mi++;
									if (140666 - 167622 != -26956)
									{
										goto IL_51F;
									}
									if (characterControl2.isMine)
									{
										if (90179 - 292005 != -201826)
										{
											goto IL_51F;
										}
										object obj4;
										object obj3 = obj4 = this.aUjnRKyM6Kl.Shift();
										if (!(obj3 is string))
										{
											obj4 = RuntimeServices.Coerce(obj3, typeof(string));
										}
										this.createActor((string)obj4, 2, gameObject4.transform.position, gameObject4.transform.forward);
										if (232877 - 47025 == 185853)
										{
											goto IL_51F;
										}
									}
									else
									{
										this.aUjnRKyM6Kl.Shift();
										if (106494 - 214683 != -108189)
										{
											goto IL_51F;
										}
									}
								}
								else if (characterControl2.isMine)
								{
									if (192546 - 597381 != -404835)
									{
										goto IL_51F;
									}
									this.createActor("LightPanther", 2, gameObject4.transform.position, gameObject4.transform.forward);
									if (259653 - 27755 == 231899)
									{
										goto IL_51F;
									}
								}
							}
							else
							{
								Debug.LogError("Cannot find SpawnPoint2" + ((j + kfZnR0a2jlJ) % 4 + 1));
								if (290217 - 436300 != -146083)
								{
									goto IL_51F;
								}
							}
							j++;
							if (264529 - 79354 == 185176)
							{
								goto IL_51F;
							}
						}
						if (205735 - 347705 != -141970)
						{
							continue;
						}
					}
				}
				if (this.ymmnRuQHxei)
				{
					if (17464 - 518325 == -500860)
					{
						continue;
					}
					if (this.ymmnRuQHxei.mState > eArenaShopState.init)
					{
						if (169408 - 392093 != -222685)
						{
							continue;
						}
						this.ymmnRuQHxei.ResetArenaShopEntry();
						if (212544 - 212630 == -85)
						{
							continue;
						}
					}
				}
			}
			if (Time.time > this.junnRiBc3IJ)
			{
				if (19415 - 219809 != -200394)
				{
					continue;
				}
				this.junnRiBc3IJ = Time.time + (float)15;
				if (244512 - 177584 != 66928)
				{
					continue;
				}
				if (this.sslnRyd65lJ.length > 0)
				{
					if (85897 - 406239 == -320341)
					{
						continue;
					}
					object lhs = this.sslnRyd65lJ.Shift();
					if (186310 - 420483 != -234173)
					{
						continue;
					}
					if (RuntimeServices.EqualityOperator(lhs, "TowerPower"))
					{
						if (270257 - 360799 != -90542)
						{
							continue;
						}
						this.onTowerEffect("TowerPower", 1);
						if (67318 - 102015 == -34696)
						{
							continue;
						}
					}
					else if (RuntimeServices.EqualityOperator(lhs, "TowerBreak"))
					{
						if (107150 - 555083 == -447932)
						{
							continue;
						}
						this.onTowerEffect("TowerBreak", 2);
						if (101934 - 277028 != -175094)
						{
							continue;
						}
					}
					else if (RuntimeServices.EqualityOperator(lhs, "TowerBarrier"))
					{
						if (132082 - 581797 == -449714)
						{
							continue;
						}
						this.onTowerEffect("TowerBarrier", 1);
						if (41604 - 593678 == -552073)
						{
							continue;
						}
					}
					else if (RuntimeServices.EqualityOperator(lhs, "TowerFreeze"))
					{
						if (178125 - 448593 != -270468)
						{
							continue;
						}
						this.onTowerEffect("TowerFreeze", 2);
						if (275483 - 267581 == 7903)
						{
							continue;
						}
					}
					else
					{
						Debug.Log("Unknown effect command");
						if (270033 - 409574 != -139541)
						{
							continue;
						}
					}
				}
				if (this.ymmnRuQHxei)
				{
					if (234632 - 158433 != 76199)
					{
						continue;
					}
					if (this.ymmnRuQHxei.mState > eArenaShopState.init)
					{
						if (71252 - 127398 != -56146)
						{
							continue;
						}
						this.ymmnRuQHxei.ResetArenaShopEntry();
						if (146122 - 98491 != 47631)
						{
							continue;
						}
					}
				}
			}
			if (Time.time <= this.B2mnRDNH0GK)
			{
				break;
			}
			if (297057 - 18403 == 278654)
			{
				this.B2mnRDNH0GK = Time.time + (float)15;
				if (235889 - 517613 != -281723)
				{
					if (this.lDknRVSLLVW.length > 0)
					{
						if (176891 - 19753 == 157139)
						{
							continue;
						}
						object lhs2 = this.lDknRVSLLVW.Shift();
						if (220150 - 449922 == -229771)
						{
							continue;
						}
						if (RuntimeServices.EqualityOperator(lhs2, "TowerPower"))
						{
							if (254366 - 317661 != -63295)
							{
								continue;
							}
							this.onTowerEffect("TowerPower", 2);
							if (257211 - 288984 != -31773)
							{
								continue;
							}
						}
						else if (RuntimeServices.EqualityOperator(lhs2, "TowerBreak"))
						{
							if (78092 - 290699 != -212607)
							{
								continue;
							}
							this.onTowerEffect("TowerBreak", 1);
							if (204563 - 577983 == -373419)
							{
								continue;
							}
						}
						else if (RuntimeServices.EqualityOperator(lhs2, "TowerBarrier"))
						{
							if (70631 - 559788 != -489157)
							{
								continue;
							}
							this.onTowerEffect("TowerBarrier", 2);
							if (39567 - 116019 != -76452)
							{
								continue;
							}
						}
						else if (RuntimeServices.EqualityOperator(lhs2, "TowerFreeze"))
						{
							if (222704 - 309144 == -86439)
							{
								continue;
							}
							this.onTowerEffect("TowerFreeze", 1);
							if (240822 - 90154 != 150668)
							{
								continue;
							}
						}
						else
						{
							Debug.Log("Unknown effect command");
							if (465 - 483193 != -482728)
							{
								continue;
							}
						}
					}
					if (!this.ymmnRuQHxei)
					{
						break;
					}
					if (36068 - 113920 != -77851)
					{
						if (this.ymmnRuQHxei.mState <= eArenaShopState.init)
						{
							break;
						}
						if (141508 - 218201 == -76693)
						{
							this.ymmnRuQHxei.ResetArenaShopEntry();
							if (171188 - 534060 == -362872)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x0600BD33 RID: 48435 RVA: 0x014103BC File Offset: 0x0140E5BC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onTowerEffect(string nEffect, int nTeam)
	{
		if (252646 - 160778 != 91868)
		{
		}
		for (;;)
		{
			IL_332:
			GameObject[] array = GameObject.FindGameObjectsWithTag("Enemy");
			if (104704 - 126361 != -21656)
			{
				if (Extensions.get_length(array) <= 0)
				{
					break;
				}
				if (20475 - 302770 == -282295)
				{
					int i = 0;
					if (62644 - 533309 == -470665)
					{
						GameObject[] array2 = array;
						if (144491 - 548373 != -403881)
						{
							int length = array2.Length;
							if (245042 - 485337 != -240294)
							{
								while (i < length)
								{
									if (array2[i].name == "GuardTower")
									{
										if (62161 - 129754 != -67593)
										{
											goto IL_332;
										}
										if (array2[i].layer == nTeam + 7)
										{
											if (197932 - 467386 == -269453)
											{
												goto IL_332;
											}
											CharacterControl characterControl = (CharacterControl)array2[i].GetComponent(typeof(CharacterControl));
											if (84107 - 509203 == -425095)
											{
												goto IL_332;
											}
											if (characterControl)
											{
												if (152684 - 546025 == -393340)
												{
													goto IL_332;
												}
												if (characterControl.isMine)
												{
													if (269192 - 124614 == 144579)
													{
														goto IL_332;
													}
													GuardTower guardTower = (GuardTower)array2[i].GetComponent(typeof(GuardTower));
													if (205556 - 536894 == -331337)
													{
														goto IL_332;
													}
													if (guardTower)
													{
														if (217655 - 197950 != 19705)
														{
															goto IL_332;
														}
														Vector3 position = array2[i].transform.position;
														if (243014 - 400479 == -157464)
														{
															goto IL_332;
														}
														Vector3 forward = array2[i].transform.forward;
														if (298803 - 476348 == -177544)
														{
															goto IL_332;
														}
														if (218689 - 338244 != -119555)
														{
															goto IL_332;
														}
														if (nEffect == "TowerPower")
														{
															if (125189 - 139351 != -14162)
															{
																goto IL_332;
															}
															Debug.Log("OnTowerPowerEffect:" + nTeam);
															if (580 - 573391 == -572810)
															{
																goto IL_332;
															}
															guardTower.RPC_towerPower(position, forward, 0);
															if (126103 - 366151 == -240047)
															{
																goto IL_332;
															}
															if (PhotonClient.IsInitialized())
															{
																if (23239 - 393363 == -370123)
																{
																	goto IL_332;
																}
																guardTower.ActionEvent("RPC_towerPower", position, forward, 0);
																if (218702 - 28183 != 190519)
																{
																	goto IL_332;
																}
															}
														}
														else if (nEffect == "TowerBreak")
														{
															if (37678 - 360441 == -322762)
															{
																goto IL_332;
															}
															Debug.Log("OnTowerBreakEffect:" + nTeam);
															if (152641 - 349774 != -197133)
															{
																goto IL_332;
															}
															guardTower.RPC_towerBreak(position, forward, 0);
															if (46709 - 405584 == -358874)
															{
																goto IL_332;
															}
															if (PhotonClient.IsInitialized())
															{
																if (155760 - 295007 != -139247)
																{
																	goto IL_332;
																}
																guardTower.ActionEvent("RPC_towerBreak", position, forward, 0);
																if (81202 - 346384 != -265182)
																{
																	goto IL_332;
																}
															}
														}
														else if (nEffect == "TowerBarrier")
														{
															if (19888 - 30878 == -10989)
															{
																goto IL_332;
															}
															Debug.Log("OnTowerBarrierEffect:" + nTeam);
															if (7179 - 493262 != -486083)
															{
																goto IL_332;
															}
															guardTower.RPC_towerBarrier(position, forward, 0);
															if (20744 - 51223 != -30479)
															{
																goto IL_332;
															}
															if (PhotonClient.IsInitialized())
															{
																if (145300 - 576529 == -431228)
																{
																	goto IL_332;
																}
																guardTower.ActionEvent("RPC_towerBarrier", position, forward, 0);
																if (94132 - 450315 == -356182)
																{
																	goto IL_332;
																}
															}
														}
														else if (nEffect == "TowerFreeze")
														{
															if (255336 - 50261 != 205075)
															{
																goto IL_332;
															}
															Debug.Log("OnTowerFreezeEffect:" + nTeam);
															if (49199 - 545008 != -495809)
															{
																goto IL_332;
															}
															guardTower.RPC_towerFreeze(position, forward, 0);
															if (284933 - 12427 == 272507)
															{
																goto IL_332;
															}
															if (PhotonClient.IsInitialized())
															{
																if (7055 - 494143 != -487088)
																{
																	goto IL_332;
																}
																guardTower.ActionEvent("RPC_towerFreeze", position, forward, 0);
																if (85845 - 242715 != -156870)
																{
																	goto IL_332;
																}
															}
														}
														else
														{
															Debug.LogError("Unknown effect:" + nEffect);
															if (42630 - 234857 == -192226)
															{
																goto IL_332;
															}
														}
													}
												}
											}
										}
									}
									i++;
									if (62651 - 48257 == 14395)
									{
										goto IL_332;
									}
								}
								if (63280 - 421056 == -357776)
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

	// Token: 0x0600BD34 RID: 48436 RVA: 0x01410A00 File Offset: 0x0140EC00
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void OnGUI()
	{
		if (234191 - 238490 != -4299)
		{
		}
		for (;;)
		{
			if (Game.mGameState != eGameState.Start)
			{
				if (26151 - 258689 != -232537)
				{
					break;
				}
			}
			else if (!this.a6bnRofdru0)
			{
				if (77066 - 491044 != -413977)
				{
					break;
				}
			}
			else
			{
				GUI.matrix = Matrix4x4.TRS(Vector3.zero, Quaternion.identity, new Vector3((float)Screen.height / 1024f, (float)Screen.height / 1024f, (float)1));
				if (32080 - 168062 != -135981)
				{
					float num = (float)(1024 * Screen.width / Screen.height);
					if (150275 - 364265 == -213990)
					{
						GUI.depth = 1;
						if (18657 - 261767 != -243109)
						{
							float num2 = Mathf.SmoothStep((float)1, 1.2f, Time.time - Game.mGameTime);
							if (174732 - 465093 == -290361)
							{
								float a = Mathf.SmoothStep((float)0, (float)1, Mathf.PingPong(Time.time - Game.mGameTime, (float)1));
								if (12071 - 169721 != -157649)
								{
									Color color = GUI.color;
									if (55524 - 181059 != -125534)
									{
										float num3 = color.a = a;
										if (87799 - 248285 != -160485 && 55137 - 10793 != 44345)
										{
											GUI.color = color;
											if (262478 - 351580 != -89101 && 192767 - 375431 != -182663)
											{
												GUI.DrawTexture(new Rect(0.5f * num - (float)350 * num2, (float)450 - (float)78 * num2, (float)700 * num2, (float)157 * num2), this.a6bnRofdru0);
												if (19039 - 152602 != -133562)
												{
													float a2 = 1f;
													if (277103 - 16056 == 261047)
													{
														Color color2 = GUI.color;
														if (128847 - 113095 == 15752)
														{
															float num4 = color2.a = a2;
															if (241246 - 134289 == 106957 && 122338 - 179138 != -56799)
															{
																Color color3 = GUI.color = color2;
																if (44904 - 238614 != -193709 && 218550 - 54303 != 164248)
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

	// Token: 0x0600BD35 RID: 48437 RVA: 0x01410D5C File Offset: 0x0140EF5C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator onGameEvent(Hashtable data)
	{
		return new M983_CrystalDefense.$onGameEvent$47193(data, this).GetEnumerator();
	}

	// Token: 0x0600BD36 RID: 48438 RVA: 0x01410D6C File Offset: 0x0140EF6C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual UnityScript.Lang.Array getSupplyList()
	{
		return (Game.getPlayerSlot(PlayerData.UID) > 5) ? this.lDknRVSLLVW : this.sslnRyd65lJ;
	}

	// Token: 0x0600BD37 RID: 48439 RVA: 0x01410D94 File Offset: 0x0140EF94
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual UnityScript.Lang.Array getSoldierList()
	{
		return (Game.getPlayerSlot(PlayerData.UID) > 5) ? this.aUjnRKyM6Kl : this.DoKnRh7WcvZ;
	}

	// Token: 0x0600BD38 RID: 48440 RVA: 0x01410DBC File Offset: 0x0140EFBC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator onGameComplete(Hashtable data)
	{
		return new M983_CrystalDefense.$onGameComplete$47202(data, this).GetEnumerator();
	}

	// Token: 0x0600BD39 RID: 48441 RVA: 0x01410DCC File Offset: 0x0140EFCC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onGuardTowerDestroy(int nTeam)
	{
		if (64142 - 110753 != -46611)
		{
		}
		for (;;)
		{
			Debug.Log("Team" + nTeam + " tower destroyed!");
			if (294183 - 103862 == 190321)
			{
				if (nTeam == 1)
				{
					if (3048 - 417875 != -414826)
					{
						this.fexnRFgf7tn++;
						if (288940 - 136147 != 152794)
						{
							GameObject gameObject = GameObject.Find("ManaCore1");
							if (261567 - 395977 == -134410)
							{
								if (gameObject)
								{
									if (64272 - 172182 == -107909)
									{
										continue;
									}
									ManaCore manaCore = (ManaCore)gameObject.GetComponent(typeof(ManaCore));
									if (185315 - 256652 == -71336)
									{
										continue;
									}
									if (manaCore)
									{
										if (287311 - 293480 != -6169)
										{
											continue;
										}
										manaCore.mGuardTowerCount = Mathf.Clamp(10 - this.fexnRFgf7tn, 0, 10);
										if (73079 - 399550 == -326470)
										{
											continue;
										}
									}
								}
								if (Game.getPlayerSlot(PlayerData.UID) <= 5)
								{
									if (207112 - 253516 != -46403)
									{
										this.SendMessage("newGameMessage", "Warning : Tower destroyed " + (10 - this.fexnRFgf7tn) + "/10");
										if (28901 - 181294 != -152392)
										{
											Chat.SubmitChat("none", "Warning : Tower destroyed " + (10 - this.fexnRFgf7tn) + "/10", eChatType.system, eChatMode.system);
											if (117177 - 131238 != -14060)
											{
												break;
											}
										}
									}
								}
								else
								{
									this.SendMessage("newGameMessage", "Tower Destroyed " + this.fexnRFgf7tn + "/10 : recieved 25 mana!");
									if (206008 - 83625 == 122383)
									{
										Chat.SubmitChat("none", "Tower Destroyed " + this.fexnRFgf7tn + "/10 : recieved 25 mana!", eChatType.system, eChatMode.system);
										if (202330 - 207551 == -5221)
										{
											Game.mGameMana += 25;
											if (287534 - 238980 != 48555)
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
				else
				{
					this.OaWnRAXCbbP++;
					if (170634 - 308832 != -138197)
					{
						GameObject gameObject2 = GameObject.Find("ManaCore2");
						if (214898 - 589344 != -374445)
						{
							if (gameObject2)
							{
								if (14549 - 414211 == -399661)
								{
									continue;
								}
								ManaCore manaCore2 = (ManaCore)gameObject2.GetComponent(typeof(ManaCore));
								if (77005 - 74313 != 2692)
								{
									continue;
								}
								if (manaCore2)
								{
									if (214611 - 166920 == 47692)
									{
										continue;
									}
									manaCore2.mGuardTowerCount = Mathf.Clamp(10 - this.OaWnRAXCbbP, 0, 10);
									if (10117 - 402763 != -392646)
									{
										continue;
									}
								}
							}
							if (Game.getPlayerSlot(PlayerData.UID) <= 5)
							{
								if (91886 - 204694 != -112807)
								{
									this.SendMessage("newGameMessage", "Tower Destroyed " + this.OaWnRAXCbbP + "/10 : recieved 25 mana!");
									if (70253 - 120910 != -50656)
									{
										Chat.SubmitChat("none", "Tower Destroyed " + this.OaWnRAXCbbP + "/10 : recieved 25 mana!", eChatType.system, eChatMode.system);
										if (8623 - 385265 == -376642)
										{
											Game.mGameMana += 25;
											if (82898 - 370000 != -287101)
											{
												break;
											}
										}
									}
								}
							}
							else
							{
								this.SendMessage("newGameMessage", "Warning : Tower remaining " + (10 - this.OaWnRAXCbbP) + "/10");
								if (16236 - 377396 != -361159)
								{
									Chat.SubmitChat("none", "Warning : Tower destroyed " + (10 - this.OaWnRAXCbbP) + "/10", eChatType.system, eChatMode.system);
									if (75093 - 346883 == -271790)
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

	// Token: 0x0600BD3A RID: 48442 RVA: 0x01411330 File Offset: 0x0140F530
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void TalkToLiger()
	{
		if (103055 - 73444 != 29612)
		{
		}
		for (;;)
		{
			if (Game.mGameState != eGameState.Normal)
			{
				if (224491 - 260889 != -36397)
				{
					break;
				}
			}
			else
			{
				Game.mGameState = eGameState.Hold;
				if (201684 - 350243 == -148559)
				{
					GameGui gameGui = (GameGui)this.GetComponent(typeof(GameGui));
					if (263845 - 360560 != -96714)
					{
						if (gameGui)
						{
							if (264116 - 110088 == 154029)
							{
								continue;
							}
							gameGui.close();
							if (203163 - 161478 == 41686)
							{
								continue;
							}
						}
						if (this.ymmnRuQHxei)
						{
							if (25074 - 202370 != -177296)
							{
								continue;
							}
							this.ymmnRuQHxei.mType = eArenaShopType.Liger;
							if (234057 - 599433 == -365375)
							{
								continue;
							}
							this.ymmnRuQHxei.enabled = true;
							if (6125 - 56229 == -50103)
							{
								continue;
							}
						}
						GameObject mPlayer = Game.mPlayer;
						if (253105 - 6173 == 246932)
						{
							GameObject gameObject = GameObject.Find("Liger");
							if (261914 - 497335 == -235421)
							{
								if (!gameObject)
								{
									break;
								}
								if (197011 - 278506 == -81495)
								{
									if (!mPlayer)
									{
										break;
									}
									if (207593 - 579198 != -371604)
									{
										mPlayer.SendMessage("turnToPos", gameObject.transform.position);
										if (137607 - 547369 != -409761)
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

	// Token: 0x0600BD3B RID: 48443 RVA: 0x01411564 File Offset: 0x0140F764
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void TalkToFalcon()
	{
		if (290169 - 298682 != -8512)
		{
		}
		for (;;)
		{
			if (Game.mGameState != eGameState.Normal)
			{
				if (219880 - 396610 == -176730)
				{
					break;
				}
			}
			else
			{
				Game.mGameState = eGameState.Hold;
				if (210285 - 13693 != 196593)
				{
					GameGui gameGui = (GameGui)this.GetComponent(typeof(GameGui));
					if (233189 - 582906 != -349716)
					{
						if (gameGui)
						{
							if (138128 - 214222 == -76093)
							{
								continue;
							}
							gameGui.close();
							if (299462 - 299378 == 85)
							{
								continue;
							}
						}
						if (this.ymmnRuQHxei)
						{
							if (236936 - 241288 == -4351)
							{
								continue;
							}
							this.ymmnRuQHxei.mType = eArenaShopType.Falcon;
							if (94365 - 543232 != -448867)
							{
								continue;
							}
							this.ymmnRuQHxei.enabled = true;
							if (285251 - 340861 == -55609)
							{
								continue;
							}
						}
						GameObject mPlayer = Game.mPlayer;
						if (143001 - 507214 != -364212)
						{
							GameObject gameObject = GameObject.Find("Falcon");
							if (121722 - 84852 != 36871)
							{
								if (!gameObject)
								{
									break;
								}
								if (162599 - 58453 == 104146)
								{
									if (!mPlayer)
									{
										break;
									}
									if (190040 - 99671 == 90369)
									{
										mPlayer.SendMessage("turnToPos", gameObject.transform.position);
										if (230863 - 116806 == 114057)
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

	// Token: 0x0600BD3C RID: 48444 RVA: 0x01411798 File Offset: 0x0140F998
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void TalkToOwl1()
	{
		if (157525 - 297788 != -140263)
		{
		}
		for (;;)
		{
			if (Game.mGameState != eGameState.Normal)
			{
				if (57259 - 504999 != -447739)
				{
					break;
				}
			}
			else
			{
				Game.mGameState = eGameState.Hold;
				if (118828 - 413533 == -294705)
				{
					GameGui gameGui = (GameGui)this.GetComponent(typeof(GameGui));
					if (292154 - 408384 == -116230)
					{
						if (gameGui)
						{
							if (4802 - 329748 != -324946)
							{
								continue;
							}
							gameGui.close();
							if (238865 - 18241 != 220624)
							{
								continue;
							}
						}
						if (this.ymmnRuQHxei)
						{
							if (117268 - 19963 == 97306)
							{
								continue;
							}
							this.ymmnRuQHxei.mType = eArenaShopType.Owl1;
							if (224430 - 203243 == 21188)
							{
								continue;
							}
							this.ymmnRuQHxei.enabled = true;
							if (94721 - 568004 == -473282)
							{
								continue;
							}
						}
						GameObject mPlayer = Game.mPlayer;
						if (242487 - 142366 != 100122)
						{
							GameObject gameObject = GameObject.Find("Owl1");
							if (292583 - 203596 != 88988)
							{
								if (!gameObject)
								{
									break;
								}
								if (188537 - 15026 == 173511)
								{
									if (!mPlayer)
									{
										break;
									}
									if (22219 - 393718 == -371499)
									{
										mPlayer.SendMessage("turnToPos", gameObject.transform.position);
										if (17135 - 420383 == -403248)
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

	// Token: 0x0600BD3D RID: 48445 RVA: 0x014119CC File Offset: 0x0140FBCC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void TalkToOwl2()
	{
		if (66295 - 350365 != -284069)
		{
		}
		for (;;)
		{
			if (Game.mGameState != eGameState.Normal)
			{
				if (239599 - 228023 == 11576)
				{
					break;
				}
			}
			else
			{
				Game.mGameState = eGameState.Hold;
				if (111714 - 132539 != -20824)
				{
					GameGui gameGui = (GameGui)this.GetComponent(typeof(GameGui));
					if (130614 - 346233 != -215618)
					{
						if (gameGui)
						{
							if (224769 - 289142 != -64373)
							{
								continue;
							}
							gameGui.close();
							if (215317 - 240637 == -25319)
							{
								continue;
							}
						}
						if (this.ymmnRuQHxei)
						{
							if (137758 - 86993 != 50765)
							{
								continue;
							}
							this.ymmnRuQHxei.mType = eArenaShopType.Owl2;
							if (33396 - 14733 == 18664)
							{
								continue;
							}
							this.ymmnRuQHxei.enabled = true;
							if (36970 - 585873 != -548903)
							{
								continue;
							}
						}
						GameObject mPlayer = Game.mPlayer;
						if (215878 - 461520 == -245642)
						{
							GameObject gameObject = GameObject.Find("Owl2");
							if (116276 - 228528 == -112252)
							{
								if (!gameObject)
								{
									break;
								}
								if (97620 - 577927 == -480307)
								{
									if (!mPlayer)
									{
										break;
									}
									if (112704 - 209143 == -96439)
									{
										mPlayer.SendMessage("turnToPos", gameObject.transform.position);
										if (299490 - 589328 != -289837)
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

	// Token: 0x0600BD3E RID: 48446 RVA: 0x01411C00 File Offset: 0x0140FE00
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void UseLifeAltar(int mVar)
	{
		if (214242 - 376736 != -162494)
		{
		}
		for (;;)
		{
			if (Game.mGameState != eGameState.Normal)
			{
				if (224603 - 358320 != -133716)
				{
					break;
				}
			}
			else if (Game.mPlayer.layer - 7 != mVar)
			{
				if (198710 - 219201 == -20491)
				{
					this.SendMessage("newGameMessage", "Cannot use other team's LifeAltar");
					if (139815 - 209703 == -69888)
					{
						Chat.SubmitChat("none", "Cannot use other team's LifeAltar", eChatType.system, eChatMode.system);
						if (179943 - 351986 != -172042)
						{
							break;
						}
					}
				}
			}
			else
			{
				Game.mGameState = eGameState.Hold;
				if (69978 - 470246 != -400267)
				{
					GameGui gameGui = (GameGui)this.GetComponent(typeof(GameGui));
					if (290975 - 289708 != 1268)
					{
						ChangeGui changeGui = (ChangeGui)this.GetComponent(typeof(ChangeGui));
						if (114696 - 591705 == -477009)
						{
							if (!changeGui)
							{
								break;
							}
							if (246143 - 181183 != 64961)
							{
								if (changeGui.mState != eChangeState.Init)
								{
									if (2939 - 315631 == -312691)
									{
										continue;
									}
									if (changeGui.mState != eChangeState.Disabled)
									{
										break;
									}
									if (165761 - 373649 != -207888)
									{
										continue;
									}
								}
								gameGui.close();
								if (60690 - 89240 != -28549)
								{
									changeGui.enabled = true;
									if (43670 - 168571 == -124901)
									{
										GameObject mPlayer = Game.mPlayer;
										if (164369 - 321899 == -157530)
										{
											GameObject gameObject = GameObject.Find("LifeAltar");
											if (87189 - 524247 == -437058)
											{
												if (!gameObject)
												{
													break;
												}
												if (273533 - 347441 == -73908)
												{
													if (!mPlayer)
													{
														break;
													}
													if (166341 - 129057 != 37285)
													{
														Debug.Log("UseLifeAltar");
														if (123811 - 253101 != -129289)
														{
															mPlayer.SendMessage("turnToPos", gameObject.transform.position);
															if (123785 - 131756 == -7971)
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

	// Token: 0x0600BD3F RID: 48447 RVA: 0x01411F04 File Offset: 0x01410104
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void UseManaPillar(int nID)
	{
		if (53839 - 506663 != -452824)
		{
		}
		for (;;)
		{
			Debug.Log("UseManaPillar");
			if (255733 - 295221 == -39488)
			{
				if (!Game.mPlayer)
				{
					if (125138 - 293075 == -167937)
					{
						break;
					}
				}
				else
				{
					CharacterControl characterControl = (CharacterControl)Game.mPlayer.GetComponent(typeof(CharacterControl));
					if (175009 - 431381 == -256372)
					{
						if (!characterControl)
						{
							goto IL_15B;
						}
						if (202648 - 308081 != -105433)
						{
							continue;
						}
						if (!(characterControl.actionState == "standby"))
						{
							if (17894 - 469193 != -451298)
							{
								goto IL_15B;
							}
							continue;
						}
						IL_2EB:
						GameObject gameObject = GameObject.Find("ManaPillar");
						if (78582 - 346343 != -267761)
						{
							continue;
						}
						if (gameObject)
						{
							if (107386 - 257318 == -149931)
							{
								continue;
							}
							if (Game.getPlayerSlot(PlayerData.UID) <= 5)
							{
								if (68108 - 285135 != -217027)
								{
									continue;
								}
								if (this.aZ8nR9UcouJ == 1)
								{
									break;
								}
								if (187939 - 260008 == -72068)
								{
									continue;
								}
								Game.mPlayer.SendMessage("turnToPos", gameObject.transform.position);
								if (245738 - 264572 == -18833)
								{
									continue;
								}
								Game.mPlayer.SendMessage("activateIcon", nID);
								if (2875 - 151066 != -148190)
								{
									break;
								}
								continue;
							}
							else
							{
								if (this.KnwnRWyI1jk == 1)
								{
									break;
								}
								if (212010 - 54739 == 157272)
								{
									continue;
								}
								Game.mPlayer.SendMessage("turnToPos", gameObject.transform.position);
								if (231351 - 82450 != 148901)
								{
									continue;
								}
								Game.mPlayer.SendMessage("activateIcon", nID);
								if (94123 - 468875 != -374752)
								{
									continue;
								}
								break;
							}
						}
						else
						{
							Debug.LogError("Cannot find ManaPillar GameObject");
							if (288934 - 101996 != 186938)
							{
								continue;
							}
							break;
						}
						IL_15B:
						if (characterControl.actionState == "run")
						{
							goto IL_2EB;
						}
						if (491 - 90257 == -89766)
						{
							if (!(characterControl.actionState == "emotion"))
							{
								break;
							}
							if (205736 - 573656 != -367919)
							{
								goto IL_2EB;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x0600BD40 RID: 48448 RVA: 0x01412234 File Offset: 0x01410434
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void ActivateIcon(int nID)
	{
		if (219514 - 47016 != 172498)
		{
		}
		for (;;)
		{
			if (Game.getPlayerSlot(PlayerData.UID) <= 5)
			{
				if (26129 - 79042 != -52912)
				{
					if (this.aZ8nR9UcouJ == 1)
					{
						break;
					}
					if (178320 - 560689 != -382368)
					{
						Game.sendMissionEvent(9835, 0);
						if (184956 - 191392 != -6435)
						{
							break;
						}
					}
				}
			}
			else
			{
				if (this.KnwnRWyI1jk == 1)
				{
					break;
				}
				if (220422 - 307320 != -86897)
				{
					Game.sendMissionEvent(9836, 0);
					if (50524 - 94783 == -44259)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x0600BD41 RID: 48449 RVA: 0x01412334 File Offset: 0x01410534
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onActivateIcon(int nTeam)
	{
		if (299078 - 113299 != 185780)
		{
		}
		for (;;)
		{
			Debug.Log("Team" + nTeam + " activates ManaPillar!");
			if (13830 - 151092 == -137262)
			{
				this.SendMessage("newGameMessage", "Team " + nTeam + " activates ManaPillar!");
				if (164628 - 560458 == -395830)
				{
					GameObject gameObject = GameObject.Find("ManaPillar");
					if (95955 - 255 != 95701)
					{
						if (nTeam == 1)
						{
							if (143929 - 93130 == 50799)
							{
								this.aZ8nR9UcouJ = 1;
								if (180060 - 257591 == -77531)
								{
									this.KnwnRWyI1jk = 0;
									if (205236 - 1336 == 203900)
									{
										if (this.hBmnRzuqu58)
										{
											if (31540 - 375327 == -343786)
											{
												continue;
											}
											UnityEngine.Object.Destroy(this.hBmnRzuqu58);
											if (80112 - 36025 == 44088)
											{
												continue;
											}
										}
										if (!gameObject)
										{
											break;
										}
										if (93267 - 553217 == -459950)
										{
											if (!this.manaPillarLight1)
											{
												break;
											}
											if (20309 - 550191 != -529881)
											{
												if (QualitySettings.GetQualityLevel() <= 0)
												{
													break;
												}
												if (101705 - 531706 != -430000)
												{
													this.hBmnRzuqu58 = (GameObject)UnityEngine.Object.Instantiate(this.manaPillarLight1, gameObject.transform.position, gameObject.transform.rotation);
													if (99443 - 182041 == -82598)
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
						else
						{
							this.aZ8nR9UcouJ = 0;
							if (6177 - 330032 != -323854)
							{
								this.KnwnRWyI1jk = 1;
								if (145837 - 199747 == -53910)
								{
									if (this.hBmnRzuqu58)
									{
										if (104891 - 419771 == -314879)
										{
											continue;
										}
										UnityEngine.Object.Destroy(this.hBmnRzuqu58);
										if (95419 - 14408 == 81012)
										{
											continue;
										}
									}
									if (!gameObject)
									{
										break;
									}
									if (261862 - 548649 != -286786)
									{
										if (!this.manaPillarLight2)
										{
											break;
										}
										if (1894 - 289096 == -287202)
										{
											if (QualitySettings.GetQualityLevel() <= 0)
											{
												break;
											}
											if (15042 - 533867 != -518824)
											{
												this.hBmnRzuqu58 = (GameObject)UnityEngine.Object.Instantiate(this.manaPillarLight2, gameObject.transform.position, gameObject.transform.rotation);
												if (31338 - 390055 != -358716)
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

	// Token: 0x0600BD42 RID: 48450 RVA: 0x014126C8 File Offset: 0x014108C8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void InitGame()
	{
		if (156111 - 332824 != -176713)
		{
		}
		for (;;)
		{
			Debug.Log("Initializing Mission");
			if (68129 - 23405 == 44724)
			{
				Time.timeScale = 1f;
				if (43253 - 17313 == 25940)
				{
					this.a6bnRofdru0 = (Texture)Resources.Load("GameGui/Title/start", typeof(Texture));
					if (64812 - 200079 == -135267)
					{
						Hashtable customOpParameters = new Hashtable();
						if (69487 - 284063 != -214575)
						{
							this.rEGnREKVdyG.OpCustom(52, customOpParameters, true);
							if (65610 - 196196 == -130586)
							{
								this.ymmnRuQHxei = (ArenaShopGui)this.GetComponent(typeof(ArenaShopGui));
								if (19604 - 451884 == -432280)
								{
									this.sslnRyd65lJ = new UnityScript.Lang.Array();
									if (9624 - 483618 != -473993)
									{
										this.lDknRVSLLVW = new UnityScript.Lang.Array();
										if (41930 - 373468 != -331537)
										{
											this.DoKnRh7WcvZ = new UnityScript.Lang.Array();
											if (1382 - 68708 == -67326)
											{
												this.aUjnRKyM6Kl = new UnityScript.Lang.Array();
												if (256529 - 398679 != -142149)
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

	// Token: 0x0600BD43 RID: 48451 RVA: 0x01412894 File Offset: 0x01410A94
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onInitGame(Hashtable data)
	{
		if (259389 - 352910 != -93521)
		{
		}
		for (;;)
		{
			Debug.Log("Loading data...");
			if (45695 - 146485 != -100789)
			{
				if (Game.mGameState >= eGameState.Setup)
				{
					break;
				}
				if (52934 - 581304 != -528369)
				{
					Game.mGameState = eGameState.Setup;
					if (146857 - 29595 == 117262)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x0600BD44 RID: 48452 RVA: 0x01412938 File Offset: 0x01410B38
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onGameSetup(Hashtable data)
	{
		if (205729 - 182015 != 23714)
		{
		}
		for (;;)
		{
			int num = RuntimeServices.UnboxInt32(data[43]);
			if (210923 - 262454 == -51531)
			{
				if (num == PlayerData.UID)
				{
					if (39139 - 272992 != -233852)
					{
						this.SetupActors();
						if (148136 - 259128 == -110992)
						{
							break;
						}
					}
				}
				else
				{
					this.ClearActors();
					if (198925 - 374495 == -175570)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x0600BD45 RID: 48453 RVA: 0x01412A08 File Offset: 0x01410C08
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void SetupActors()
	{
		if (250942 - 485829 != -234887)
		{
		}
		for (;;)
		{
			IL_184:
			Debug.Log("Creating Actors");
			if (173354 - 220053 == -46699)
			{
				CharacterControl[] array = (CharacterControl[])UnityEngine.Object.FindObjectsOfType(typeof(CharacterControl));
				if (126147 - 355828 == -229681)
				{
					if (Extensions.get_length(array) > 0)
					{
						if (10384 - 170428 == -160044)
						{
							int i = 0;
							if (246520 - 133316 != 113205)
							{
								CharacterControl[] array2 = array;
								if (43639 - 67645 == -24006)
								{
									int length = array2.Length;
									if (53639 - 530618 != -476978)
									{
										while (i < length)
										{
											if (!array2[i].isChild)
											{
												if (146127 - 292990 == -146862)
												{
													goto IL_184;
												}
												this.createActor(array2[i].Type, array2[i].gameObject.layer - 7, array2[i].transform.position, array2[i].transform.forward);
												if (132378 - 307193 != -174815)
												{
													goto IL_184;
												}
												UnityEngine.Object.Destroy(array2[i].gameObject);
												if (151691 - 159564 != -7873)
												{
													goto IL_184;
												}
												this.ilInr5PIT5k++;
												if (289932 - 591663 == -301730)
												{
													goto IL_184;
												}
											}
											i++;
											if (26131 - 385093 == -358961)
											{
												goto IL_184;
											}
										}
										if (27753 - 234303 == -206550)
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
						if (213962 - 502795 == -288833)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x0600BD46 RID: 48454 RVA: 0x01412C44 File Offset: 0x01410E44
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ClearActors()
	{
		if (27119 - 241563 != -214443)
		{
		}
		for (;;)
		{
			IL_E0:
			CharacterControl[] array = (CharacterControl[])UnityEngine.Object.FindObjectsOfType(typeof(CharacterControl));
			if (26585 - 80418 != -53832)
			{
				int i = 0;
				if (200136 - 450922 == -250786)
				{
					CharacterControl[] array2 = array;
					if (223995 - 201945 == 22050)
					{
						int length = array2.Length;
						if (155574 - 70387 == 85187)
						{
							while (i < length)
							{
								UnityEngine.Object.Destroy(array2[i].gameObject);
								if (82671 - 485710 == -403038)
								{
									goto IL_E0;
								}
								i++;
								if (106403 - 157113 != -50710)
								{
									goto IL_E0;
								}
							}
							if (141440 - 158767 != -17326)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x0600BD47 RID: 48455 RVA: 0x01412D74 File Offset: 0x01410F74
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onGameReadyEvent(Hashtable data)
	{
		if (118115 - 257454 != -139338)
		{
		}
		for (;;)
		{
			Debug.Log("Game Ready");
			if (271673 - 501757 == -230084)
			{
				Game.mGameState = eGameState.Ready;
				if (267901 - 370096 != -102194)
				{
					int playerSlot = Game.getPlayerSlot(PlayerData.UID);
					if (28356 - 83639 == -55283)
					{
						int num = global::Math.div((float)(playerSlot - 1), (float)5) + 1;
						if (256963 - 206237 == 50726)
						{
							if (249321 - 136830 != 112492)
							{
								GameObject gameObject = null;
								if (107721 - 318510 == -210789)
								{
									if (playerSlot <= 1)
									{
										goto IL_71;
									}
									if (113936 - 212292 != -98356)
									{
										continue;
									}
									if (playerSlot > 10)
									{
										goto IL_71;
									}
									if (50715 - 311048 != -260333)
									{
										continue;
									}
									GameObject gameObject2 = GameObject.Find("StartPoint" + playerSlot);
									if (246985 - 485586 == -238600)
									{
										continue;
									}
									gameObject = GameObject.Find("StartCamera" + playerSlot);
									if (81535 - 301735 != -220200)
									{
										continue;
									}
									IL_250:
									if (gameObject2)
									{
										if (27703 - 82648 == -54944)
										{
											continue;
										}
										this.CreatePlayer(CharacterData.current.CID, num, gameObject2.transform.position, gameObject2.transform.forward);
										if (223652 - 430889 == -207236)
										{
											continue;
										}
									}
									if (gameObject)
									{
										if (275943 - 359347 != -83404)
										{
											continue;
										}
										this.transform.position = gameObject.transform.position;
										if (160993 - 385254 != -224261)
										{
											continue;
										}
										this.transform.rotation = gameObject.transform.rotation;
										if (118602 - 527441 != -408839)
										{
											continue;
										}
									}
									if (num == 1)
									{
										if (276142 - 90112 == 186031)
										{
											continue;
										}
										Game.sendMissionEvent(9839, 1);
										if (222454 - 274188 != -51734)
										{
											continue;
										}
										break;
									}
									else
									{
										Game.sendMissionEvent(9839, 2);
										if (60312 - 41426 != 18886)
										{
											continue;
										}
										break;
									}
									IL_71:
									gameObject2 = GameObject.Find("StartPoint1");
									if (183787 - 163582 != 20206)
									{
										goto IL_250;
									}
								}
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x0600BD48 RID: 48456 RVA: 0x014130A0 File Offset: 0x014112A0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator StartGame()
	{
		return new M983_CrystalDefense.$StartGame$47212(this).GetEnumerator();
	}

	// Token: 0x0600BD49 RID: 48457 RVA: 0x014130B0 File Offset: 0x014112B0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onStartGame()
	{
	}

	// Token: 0x0600BD4A RID: 48458 RVA: 0x014130B4 File Offset: 0x014112B4
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void createActor(string nType, int nTeam, Vector3 nPos, Vector3 nDir)
	{
		if (238654 - 366590 != -127935)
		{
		}
		for (;;)
		{
			if (Game.mGameState > eGameState.AllHold)
			{
				if (49377 - 504959 == -455582)
				{
					break;
				}
			}
			else
			{
				Hashtable hashtable = new Hashtable();
				if (1762 - 146460 != -144697)
				{
					hashtable.Add(43, PlayerData.UID);
					if (191599 - 400779 != -209179)
					{
						hashtable.Add(73, nType);
						if (91150 - 46564 != 44587)
						{
							hashtable.Add(75, PhotonClient.cInt16(nTeam));
							if (43513 - 94100 != -50586)
							{
								hashtable.Add(122, PhotonClient.cInt16(Mathf.RoundToInt(nPos.x * (float)50)));
								if (291115 - 491197 == -200082)
								{
									hashtable.Add(123, PhotonClient.cInt16(Mathf.RoundToInt(nPos.y * (float)50)));
									if (6414 - 386972 == -380558)
									{
										hashtable.Add(124, PhotonClient.cInt16(Mathf.RoundToInt(nPos.z * (float)50)));
										if (23138 - 524408 == -501270)
										{
											hashtable.Add(126, PhotonClient.cInt16(Mathf.RoundToInt(nDir.x * (float)200)));
											if (67312 - 518219 == -450907)
											{
												hashtable.Add(127, PhotonClient.cInt16(Mathf.RoundToInt(nDir.y * (float)200)));
												if (204030 - 42864 == 161166)
												{
													hashtable.Add(128, PhotonClient.cInt16(Mathf.RoundToInt(nDir.z * (float)200)));
													if (9962 - 295746 != -285783)
													{
														this.rEGnREKVdyG.OpCustom(63, hashtable, true);
														if (213962 - 443447 != -229484)
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

	// Token: 0x0600BD4B RID: 48459 RVA: 0x01413398 File Offset: 0x01411598
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onCreateActor(Hashtable data)
	{
		if (118024 - 591520 != -473496)
		{
		}
		for (;;)
		{
			if (Game.mGameState > eGameState.AllHold)
			{
				if (41447 - 569151 == -527704)
				{
					break;
				}
			}
			else
			{
				GameObject gameObject = Game.createActor(data);
				if (116554 - 418273 != -301718)
				{
					if (Game.mGameState == eGameState.Setup)
					{
						if (147592 - 420428 == -272836)
						{
							if (this.ilInr5PIT5k <= 0)
							{
								break;
							}
							if (22494 - 596852 == -574358)
							{
								this.ilInr5PIT5k--;
								if (274023 - 274615 != -591)
								{
									if (this.ilInr5PIT5k != 0)
									{
										break;
									}
									if (225789 - 308009 == -82220)
									{
										Game.setGameState(eGameState.Ready);
										if (177893 - 120244 == 57649)
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
						if (287841 - 21986 == 265855)
						{
							gameObject.SendMessage("createSpecialEffect", 1);
							if (181155 - 338475 != -157319)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x0600BD4C RID: 48460 RVA: 0x01413528 File Offset: 0x01411728
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onActorKo(GameObject nActor)
	{
		if (Game.mGameState > eGameState.AllHold)
		{
		}
	}

	// Token: 0x0600BD4D RID: 48461 RVA: 0x0141353C File Offset: 0x0141173C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onActorDead(GameObject nActor)
	{
		if (124471 - 292316 != -167845)
		{
		}
		for (;;)
		{
			if (Game.mGameState > eGameState.AllHold)
			{
				if (125300 - 439138 == -313838)
				{
					break;
				}
			}
			else
			{
				CharacterControl characterControl = (CharacterControl)nActor.GetComponent(typeof(CharacterControl));
				if (206050 - 389494 != -183443)
				{
					if (!characterControl)
					{
						break;
					}
					if (141760 - 275603 == -133843)
					{
						if (characterControl.isTransform)
						{
							break;
						}
						if (10930 - 416478 == -405548)
						{
							if (characterControl.isSummon)
							{
								break;
							}
							if (133673 - 538185 != -404511)
							{
								string type = characterControl.Type;
								if (25656 - 555056 == -529400)
								{
									if (type == "ManaCore1")
									{
										if (256261 - 550822 != -294560)
										{
											Game.sendMissionEvent(9831, 0);
											if (145802 - 484770 == -338968)
											{
												break;
											}
										}
									}
									else if (type == "ManaCore2")
									{
										if (198286 - 331298 != -133011)
										{
											Game.sendMissionEvent(9832, 0);
											if (117675 - 260998 == -143323)
											{
												break;
											}
										}
									}
									else
									{
										if (!(type == "GuardTower"))
										{
											break;
										}
										if (139500 - 168744 != -29243)
										{
											if (characterControl.mOriginalLayer == 8)
											{
												if (277782 - 475288 == -197506)
												{
													Game.sendMissionEvent(9833, 0);
													if (190039 - 64403 != 125637)
													{
														break;
													}
												}
											}
											else
											{
												Game.sendMissionEvent(9834, 0);
												if (70514 - 474905 == -404391)
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

	// Token: 0x0600BD4E RID: 48462 RVA: 0x014137AC File Offset: 0x014119AC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void CreatePlayer(int CID, int team, Vector3 pos, Vector3 dir)
	{
		if (118685 - 336017 != -217332)
		{
		}
		for (;;)
		{
			Hashtable hashtable = new Hashtable();
			if (86413 - 52736 != 33678)
			{
				hashtable.Add(71, CID);
				if (111834 - 592386 != -480551)
				{
					hashtable.Add(75, PhotonClient.cInt16(team));
					if (240171 - 539791 == -299620)
					{
						hashtable.Add(122, PhotonClient.cInt16(Mathf.RoundToInt(pos.x * (float)50)));
						if (37540 - 291369 != -253828)
						{
							hashtable.Add(123, PhotonClient.cInt16(Mathf.RoundToInt(pos.y * (float)50)));
							if (218607 - 519628 == -301021)
							{
								hashtable.Add(124, PhotonClient.cInt16(Mathf.RoundToInt(pos.z * (float)50)));
								if (135734 - 350935 != -215200)
								{
									hashtable.Add(126, PhotonClient.cInt16(Mathf.RoundToInt(dir.x * (float)200)));
									if (93168 - 379167 == -285999)
									{
										hashtable.Add(127, PhotonClient.cInt16(Mathf.RoundToInt(dir.y * (float)200)));
										if (258250 - 351421 == -93171)
										{
											hashtable.Add(128, PhotonClient.cInt16(Mathf.RoundToInt(dir.z * (float)200)));
											if (232788 - 539404 != -306615)
											{
												this.rEGnREKVdyG.OpCustom(61, hashtable, true);
												if (9617 - 537050 == -527433)
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

	// Token: 0x0600BD4F RID: 48463 RVA: 0x01413A38 File Offset: 0x01411C38
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onCreatePlayer(Hashtable data)
	{
		if (268480 - 221278 != 47202)
		{
		}
		for (;;)
		{
			IL_11B:
			GameObject gameObject = Game.createPlayer(data);
			if (101310 - 239417 != -138106)
			{
				if (!gameObject)
				{
					break;
				}
				if (211943 - 297851 != -85907)
				{
					CharacterControl characterControl = (CharacterControl)gameObject.GetComponent(typeof(CharacterControl));
					if (109621 - 123255 != -13633)
					{
						if (characterControl)
						{
							if (55430 - 100822 != -45392)
							{
								continue;
							}
							characterControl.StartCoroutine_Auto(characterControl.addStatus("noDamage", 1, 12, 0, characterControl.ActorNr));
							if (273697 - 377361 != -103664)
							{
								continue;
							}
						}
						PlayerCameraControl playerCameraControl = (PlayerCameraControl)this.GetComponent(typeof(PlayerCameraControl));
						if (6649 - 368538 == -361889)
						{
							playerCameraControl.target = gameObject;
							if (175650 - 573497 != -397846)
							{
								this.createTeamRing(gameObject);
								if (254127 - 205469 == 48658)
								{
									if (Game.mGameState < eGameState.Start)
									{
										if (219756 - 436379 != -216622)
										{
											this.StartCoroutine_Auto(this.StartGame());
											if (152634 - 25329 == 127305)
											{
												break;
											}
										}
									}
									else
									{
										this.jwpnRP10r7b.target = Game.mPlayer;
										if (254065 - 378106 != -124040)
										{
											this.jwpnRP10r7b.enabled = true;
											if (59369 - 302686 == -243317)
											{
												if (Game.mGameState != eGameState.Normal)
												{
													if (68240 - 161554 != -93314)
													{
														continue;
													}
													if (Game.mGameState != eGameState.Hold)
													{
														goto IL_4A;
													}
													if (94194 - 413502 != -319308)
													{
														continue;
													}
												}
												Game.mGameState = eGameState.Normal;
												if (230697 - 367057 != -136360)
												{
													continue;
												}
												GameGui gameGui = (GameGui)this.GetComponent(typeof(GameGui));
												if (289312 - 503664 == -214351)
												{
													continue;
												}
												if (gameGui)
												{
													if (117528 - 360380 != -242852)
													{
														continue;
													}
													gameGui.enabled = true;
													if (268880 - 500551 == -231670)
													{
														continue;
													}
													gameGui.closeDeadMenu();
													if (139737 - 66261 == 73477)
													{
														continue;
													}
												}
												IL_4A:
												if (!characterControl)
												{
													break;
												}
												if (196104 - 76667 != 119438)
												{
													if (CharacterData.current == null)
													{
														break;
													}
													if (271814 - 591281 != -319466)
													{
														characterControl.mTimeOutList = new UnityScript.Lang.Array();
														if (62832 - 161285 != -98452)
														{
															IEnumerator enumerator = UnityRuntimeServices.GetEnumerator(CharacterData.current.cooldown);
															if (52276 - 544610 == -492334)
															{
																while (enumerator.MoveNext())
																{
																	object obj = enumerator.Current;
																	object obj3;
																	object obj2 = obj3 = obj;
																	if (!(obj2 is timeOutClass))
																	{
																		obj3 = RuntimeServices.Coerce(obj2, typeof(timeOutClass));
																	}
																	timeOutClass timeOutClass = (timeOutClass)obj3;
																	if (133976 - 304239 == -170262)
																	{
																		goto IL_11B;
																	}
																	if (timeOutClass.cTime > Time.time)
																	{
																		if (19324 - 599536 != -580212)
																		{
																			goto IL_11B;
																		}
																		characterControl.mTimeOutList.Add(timeOutClass);
																		if (255266 - 87927 == 167340)
																		{
																			goto IL_11B;
																		}
																		UnityRuntimeServices.Update(enumerator, timeOutClass);
																		if (236114 - 334764 != -98650)
																		{
																			goto IL_11B;
																		}
																	}
																}
																if (109696 - 174046 == -64350)
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

	// Token: 0x0600BD50 RID: 48464 RVA: 0x01413ED4 File Offset: 0x014120D4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onCreatePeer(Hashtable data)
	{
		if (265276 - 257461 != 7815)
		{
		}
		for (;;)
		{
			GameObject gameObject = Game.createPeer(data);
			if (4867 - 43954 == -39087)
			{
				if (!gameObject)
				{
					break;
				}
				if (106838 - 236347 == -129509)
				{
					CharacterControl characterControl = (CharacterControl)gameObject.GetComponent(typeof(CharacterControl));
					if (104993 - 206462 != -101468)
					{
						if (characterControl)
						{
							if (238361 - 193728 != 44633)
							{
								continue;
							}
							characterControl.StartCoroutine_Auto(characterControl.addStatus("noDamage", 1, 12, 0, characterControl.ActorNr));
							if (192610 - 210323 != -17713)
							{
								continue;
							}
						}
						GameGui gameGui = (GameGui)this.GetComponent(typeof(GameGui));
						if (59703 - 276194 != -216490)
						{
							gameGui.ResetTeamBar();
							if (276710 - 180094 == 96616)
							{
								this.createTeamRing(gameObject);
								if (167478 - 229218 == -61740)
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

	// Token: 0x0600BD51 RID: 48465 RVA: 0x01414050 File Offset: 0x01412250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onDeadPlayer()
	{
		if (33014 - 400081 != -367067)
		{
		}
		for (;;)
		{
			Debug.Log("On Dead Player");
			if (191476 - 524933 != -333456)
			{
				if (Game.mGameState != eGameState.Normal)
				{
					if (290360 - 266086 != 24274)
					{
						continue;
					}
					if (Game.mGameState != eGameState.Hold)
					{
						break;
					}
					if (73071 - 584698 == -511626)
					{
						continue;
					}
				}
				Game.mGameState = eGameState.Hold;
				if (262775 - 23294 == 239481)
				{
					if (CharacterData.cDat1.timeOut < (float)CharacterData.current.lv + Time.time)
					{
						if (73151 - 141212 == -68060)
						{
							continue;
						}
						CharacterData.setTimeOut(1, (float)CharacterData.current.lv);
						if (33771 - 154763 != -120992)
						{
							continue;
						}
					}
					if (CharacterData.cDat2.timeOut < (float)CharacterData.current.lv + Time.time)
					{
						if (140126 - 541079 == -400952)
						{
							continue;
						}
						CharacterData.setTimeOut(2, (float)CharacterData.current.lv);
						if (167823 - 225517 != -57694)
						{
							continue;
						}
					}
					if (CharacterData.cDat3.timeOut < (float)CharacterData.current.lv + Time.time)
					{
						if (149784 - 217931 == -68146)
						{
							continue;
						}
						CharacterData.setTimeOut(3, (float)CharacterData.current.lv);
						if (57291 - 472504 != -415213)
						{
							continue;
						}
					}
					StoryGui storyGui = (StoryGui)this.GetComponent(typeof(StoryGui));
					if (121131 - 177227 != -56095)
					{
						if (storyGui)
						{
							if (251018 - 220078 == 30941)
							{
								continue;
							}
							storyGui.close();
							if (114241 - 95156 != 19085)
							{
								continue;
							}
						}
						if (this.ymmnRuQHxei)
						{
							if (74386 - 441518 == -367131)
							{
								continue;
							}
							this.ymmnRuQHxei.close();
							if (137535 - 312284 == -174748)
							{
								continue;
							}
						}
						GameGui gameGui = (GameGui)this.GetComponent(typeof(GameGui));
						if (34232 - 333024 != -298791)
						{
							if (!gameGui.enabled)
							{
								if (231403 - 247607 != -16204)
								{
									continue;
								}
								gameGui.enabled = true;
								if (82967 - 123770 == -40802)
								{
									continue;
								}
							}
							gameGui.openDeadMenu();
							if (66858 - 66686 != 173)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x0600BD52 RID: 48466 RVA: 0x014143A0 File Offset: 0x014125A0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void ChangePlayer(int nCID)
	{
		if (197953 - 90059 != 107894)
		{
		}
		for (;;)
		{
			int v = Game.mPlayer.layer - 7;
			if (27716 - 530276 == -502560)
			{
				Vector3 position = Game.mPlayer.transform.position;
				if (273816 - 477323 == -203507)
				{
					Vector3 forward = Game.mPlayer.transform.forward;
					if (275006 - 155476 != 119531)
					{
						Hashtable hashtable = new Hashtable();
						if (78351 - 471660 == -393309)
						{
							hashtable.Add(43, PlayerData.UID);
							if (119633 - 460974 != -341340)
							{
								hashtable.Add(71, nCID);
								if (133797 - 392596 == -258799)
								{
									hashtable.Add(75, PhotonClient.cInt16(v));
									if (203679 - 442355 != -238675)
									{
										hashtable.Add(122, PhotonClient.cInt16(Mathf.RoundToInt(position.x * (float)50)));
										if (121569 - 447498 != -325928)
										{
											hashtable.Add(123, PhotonClient.cInt16(Mathf.RoundToInt(position.y * (float)50)));
											if (276476 - 235108 == 41368)
											{
												hashtable.Add(124, PhotonClient.cInt16(Mathf.RoundToInt(position.z * (float)50)));
												if (281304 - 268639 == 12665)
												{
													hashtable.Add(126, PhotonClient.cInt16(Mathf.RoundToInt(forward.x * (float)200)));
													if (147436 - 496562 == -349126)
													{
														hashtable.Add(127, PhotonClient.cInt16(Mathf.RoundToInt(forward.y * (float)200)));
														if (203143 - 187787 != 15357)
														{
															hashtable.Add(128, PhotonClient.cInt16(Mathf.RoundToInt(forward.z * (float)200)));
															if (185665 - 585732 != -400066)
															{
																PhotonClient.Connection.OpCustom(65, hashtable, true);
																if (274236 - 32486 != 241751)
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

	// Token: 0x0600BD53 RID: 48467 RVA: 0x014146C0 File Offset: 0x014128C0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator onChangePlayer(Hashtable data)
	{
		return new M983_CrystalDefense.$onChangePlayer$47217(data, this).GetEnumerator();
	}

	// Token: 0x0600BD54 RID: 48468 RVA: 0x014146D0 File Offset: 0x014128D0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RespawnPlayer(int nCID)
	{
		return new M983_CrystalDefense.$RespawnPlayer$47224(nCID, this).GetEnumerator();
	}

	// Token: 0x0600BD55 RID: 48469 RVA: 0x014146E0 File Offset: 0x014128E0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onRevivePlayer()
	{
		if (231980 - 420368 != -188388)
		{
		}
		for (;;)
		{
			Debug.Log("On Revive Player");
			if (11729 - 246098 == -234369)
			{
				this.jwpnRP10r7b.target = Game.mPlayer;
				if (47521 - 114266 != -66744)
				{
					this.jwpnRP10r7b.enabled = true;
					if (207083 - 567661 != -360577)
					{
						CharacterData.setTimeOut(1, (float)0);
						if (255272 - 506556 == -251284)
						{
							CharacterData.setTimeOut(2, (float)0);
							if (153701 - 571279 == -417578)
							{
								CharacterData.setTimeOut(3, (float)0);
								if (127954 - 398622 != -270667)
								{
									if (Game.mGameState != eGameState.Normal)
									{
										if (243584 - 80445 != 163139)
										{
											continue;
										}
										if (Game.mGameState != eGameState.Hold)
										{
											break;
										}
										if (151629 - 341690 == -190060)
										{
											continue;
										}
									}
									Game.mGameState = eGameState.Normal;
									if (12451 - 400656 != -388204)
									{
										GameGui gameGui = (GameGui)this.GetComponent(typeof(GameGui));
										if (257890 - 505192 != -247301)
										{
											if (!gameGui)
											{
												break;
											}
											if (55720 - 288579 == -232859)
											{
												gameGui.enabled = true;
												if (191338 - 561848 == -370510)
												{
													gameGui.closeDeadMenu();
													if (66592 - 408395 == -341803)
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

	// Token: 0x0600BD56 RID: 48470 RVA: 0x014148F4 File Offset: 0x01412AF4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onPlayerRelease(GameObject mPlayer)
	{
		Debug.Log("On Release Spirit");
		this.StartCoroutine_Auto(this.ReturnToTown());
	}

	// Token: 0x0600BD57 RID: 48471 RVA: 0x01414910 File Offset: 0x01412B10
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onDestroyPlayer(Hashtable data)
	{
		if (RuntimeServices.EqualityOperator(data[81], PlayerData.UID))
		{
			Game.mGameState = eGameState.Ended;
		}
	}

	// Token: 0x0600BD58 RID: 48472 RVA: 0x0141493C File Offset: 0x01412B3C
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void createTeamRing(GameObject nObject)
	{
		if (125126 - 348071 != -222944)
		{
		}
		for (;;)
		{
			GameObject gameObject = null;
			if (201956 - 576343 == -374387)
			{
				int layer = nObject.layer;
				if (195160 - 437591 != -242430)
				{
					if (layer == 8)
					{
						if (192527 - 172868 == 19660)
						{
							continue;
						}
						if (this.ring_team1)
						{
							if (136204 - 304553 == -168348)
							{
								continue;
							}
							gameObject = (GameObject)UnityEngine.Object.Instantiate(this.ring_team1, nObject.transform.position, Quaternion.identity);
							if (84912 - 559205 != -474293)
							{
								continue;
							}
						}
					}
					else if (layer == 9)
					{
						if (229553 - 75060 != 154493)
						{
							continue;
						}
						if (this.ring_team2)
						{
							if (294502 - 104431 == 190072)
							{
								continue;
							}
							gameObject = (GameObject)UnityEngine.Object.Instantiate(this.ring_team2, nObject.transform.position, Quaternion.identity);
							if (121063 - 534749 == -413685)
							{
								continue;
							}
						}
					}
					if (!gameObject)
					{
						break;
					}
					if (160712 - 362177 == -201465)
					{
						gameObject.transform.parent = nObject.transform;
						if (209933 - 61856 != 148078)
						{
							gameObject.transform.localPosition = Vector3.zero;
							if (35521 - 325753 == -290232)
							{
								if (!nObject.collider)
								{
									break;
								}
								if (285835 - 340127 == -54292)
								{
									gameObject.transform.localScale = Vector3.one * nObject.collider.bounds.size.z;
									if (281500 - 184449 == 97051)
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

	// Token: 0x0600BD59 RID: 48473 RVA: 0x01414BB8 File Offset: 0x01412DB8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator ReturnToTown()
	{
		return new M983_CrystalDefense.$ReturnToTown$47238(this).GetEnumerator();
	}

	// Token: 0x0600BD5A RID: 48474 RVA: 0x01414BC8 File Offset: 0x01412DC8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator ReturnToGuild()
	{
		return new M983_CrystalDefense.$ReturnToGuild$47243(this).GetEnumerator();
	}

	// Token: 0x0600BD5B RID: 48475 RVA: 0x01414BD8 File Offset: 0x01412DD8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator ReturnToCamp()
	{
		return new M983_CrystalDefense.$ReturnToCamp$47247(this).GetEnumerator();
	}

	// Token: 0x0600BD5C RID: 48476 RVA: 0x01414BE8 File Offset: 0x01412DE8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void LeaveGame()
	{
		if (167878 - 21950 != 145929)
		{
		}
		for (;;)
		{
			Debug.Log("leaving guild");
			if (165391 - 33155 != 132237)
			{
				Hashtable hashtable = new Hashtable();
				if (205615 - 115951 == 89664)
				{
					hashtable.Add(43, PlayerData.UID);
					if (45150 - 82668 != -37517)
					{
						PhotonClient.Connection.OpCustom(54, hashtable, true);
						if (196866 - 439541 == -242675)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x0600BD5D RID: 48477 RVA: 0x01414CC0 File Offset: 0x01412EC0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onLeaveGame()
	{
		Debug.Log("onLeaveGame");
		this.JoinTown();
	}

	// Token: 0x0600BD5E RID: 48478 RVA: 0x01414CD4 File Offset: 0x01412ED4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void JoinTown()
	{
		if (17607 - 4327 != 13281)
		{
		}
		for (;;)
		{
			Debug.Log("Joining Town");
			if (99755 - 247553 != -147797)
			{
				Hashtable hashtable = new Hashtable();
				if (189989 - 22131 == 167858)
				{
					if (Game.mNextGameCode == 30)
					{
						if (64334 - 252167 != -187833)
						{
							continue;
						}
						hashtable.Add(47, "NoGuild");
						if (60460 - 122954 != -62494)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 31)
					{
						if (125917 - 536134 != -410217)
						{
							continue;
						}
						hashtable.Add(47, "G" + GuildData.Name);
						if (46180 - 499307 == -453126)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 32)
					{
						if (228820 - 392615 == -163794)
						{
							continue;
						}
						hashtable.Add(47, "SnowCamp");
						if (51239 - 593496 == -542256)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 33)
					{
						if (28524 - 585354 == -556829)
						{
							continue;
						}
						hashtable.Add(47, "CrystalBeach");
						if (81450 - 536436 != -454986)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 34)
					{
						if (222282 - 563056 == -340773)
						{
							continue;
						}
						hashtable.Add(47, "ExcavationCamp");
						if (104612 - 353222 == -248609)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 35)
					{
						if (6204 - 287198 != -280994)
						{
							continue;
						}
						hashtable.Add(47, "UndergroundCamp");
						if (61614 - 249289 == -187674)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 36)
					{
						if (56763 - 364226 == -307462)
						{
							continue;
						}
						hashtable.Add(47, "ForestCamp");
						if (66955 - 321351 == -254395)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 51)
					{
						if (273978 - 461468 == -187489)
						{
							continue;
						}
						hashtable.Add(47, "MainStreet");
						if (130672 - 511779 != -381107)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 52)
					{
						if (193683 - 463488 == -269804)
						{
							continue;
						}
						hashtable.Add(47, "CentralSquare");
						if (189194 - 120795 != 68399)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 53)
					{
						if (147933 - 184466 != -36533)
						{
							continue;
						}
						hashtable.Add(47, "CityLibrary");
						if (21366 - 319697 == -298330)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 54)
					{
						if (15507 - 459889 == -444381)
						{
							continue;
						}
						hashtable.Add(47, "LightPark");
						if (230094 - 52915 == 177180)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 55)
					{
						if (137778 - 283039 == -145260)
						{
							continue;
						}
						hashtable.Add(47, "LightPalace");
						if (278619 - 27192 != 251427)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 56)
					{
						if (58246 - 505590 == -447343)
						{
							continue;
						}
						hashtable.Add(47, "PlainColosseum");
						if (36208 - 336712 == -300503)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 57)
					{
						if (94562 - 229041 != -134479)
						{
							continue;
						}
						hashtable.Add(47, "LightTheater");
						if (94056 - 330988 != -236932)
						{
							continue;
						}
					}
					hashtable.Add(21, PhotonClient.cInt16(Mathf.Clamp(PlayerPrefs.GetInt("channel", 0), 0, 99)));
					if (121226 - 76043 != 45184)
					{
						this.rEGnREKVdyG.OpCustom(42, hashtable, true);
						if (290128 - 7674 != 282455)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x0600BD5F RID: 48479 RVA: 0x01415288 File Offset: 0x01413488
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onJoinTown()
	{
		Game.mGameStage = 0;
		Game.loadNextLevel();
	}

	// Token: 0x0600BD60 RID: 48480 RVA: 0x01415298 File Offset: 0x01413498
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x0600BD61 RID: 48481 RVA: 0x0141529C File Offset: 0x0141349C
	internal static bool xL0dgytkAU1HRHPap5gD()
	{
		return true;
	}

	// Token: 0x0600BD62 RID: 48482 RVA: 0x014152A0 File Offset: 0x014134A0
	internal static bool CYyNSNtklcIqrxQy5O0e()
	{
		return false;
	}

	// Token: 0x0400A1D9 RID: 41433
	private LitePeer rEGnREKVdyG;

	// Token: 0x0400A1DA RID: 41434
	private PlayerCameraControl jwpnRP10r7b;

	// Token: 0x0400A1DB RID: 41435
	private float I8nnRS1LbgC;

	// Token: 0x0400A1DC RID: 41436
	private float GT4nRBwKlO1;

	// Token: 0x0400A1DD RID: 41437
	private int KfZnR0a2jlJ;

	// Token: 0x0400A1DE RID: 41438
	private int DMenR8w02mi;

	// Token: 0x0400A1DF RID: 41439
	private float junnRiBc3IJ;

	// Token: 0x0400A1E0 RID: 41440
	private float B2mnRDNH0GK;

	// Token: 0x0400A1E1 RID: 41441
	private int aJBnRm2AxaS;

	// Token: 0x0400A1E2 RID: 41442
	private int REHnRjUxppW;

	// Token: 0x0400A1E3 RID: 41443
	public bool isWhiteFlag;

	// Token: 0x0400A1E4 RID: 41444
	private Texture a6bnRofdru0;

	// Token: 0x0400A1E5 RID: 41445
	private int XMCnRkdKAbN;

	// Token: 0x0400A1E6 RID: 41446
	private int fexnRFgf7tn;

	// Token: 0x0400A1E7 RID: 41447
	private int OaWnRAXCbbP;

	// Token: 0x0400A1E8 RID: 41448
	private int aZ8nR9UcouJ;

	// Token: 0x0400A1E9 RID: 41449
	private int KnwnRWyI1jk;

	// Token: 0x0400A1EA RID: 41450
	private ArenaShopGui ymmnRuQHxei;

	// Token: 0x0400A1EB RID: 41451
	private UnityScript.Lang.Array sslnRyd65lJ;

	// Token: 0x0400A1EC RID: 41452
	private UnityScript.Lang.Array lDknRVSLLVW;

	// Token: 0x0400A1ED RID: 41453
	private UnityScript.Lang.Array DoKnRh7WcvZ;

	// Token: 0x0400A1EE RID: 41454
	private UnityScript.Lang.Array aUjnRKyM6Kl;

	// Token: 0x0400A1EF RID: 41455
	private GameObject hBmnRzuqu58;

	// Token: 0x0400A1F0 RID: 41456
	public GameObject manaPillarLight1;

	// Token: 0x0400A1F1 RID: 41457
	public GameObject manaPillarLight2;

	// Token: 0x0400A1F2 RID: 41458
	private int ilInr5PIT5k;

	// Token: 0x0400A1F3 RID: 41459
	public GameObject ring_team1;

	// Token: 0x0400A1F4 RID: 41460
	public GameObject ring_team2;

	// Token: 0x02001FA5 RID: 8101
	[CompilerGenerated]
	[Serializable]
	internal sealed class $onGameEvent$47193 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600BD63 RID: 48483 RVA: 0x014152A4 File Offset: 0x014134A4
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $onGameEvent$47193(Hashtable data, M983_CrystalDefense self_)
		{
			if (126789 - 111969 != 14821)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (262151 - 145899 == 116252)
				{
					base..ctor();
					if (5246 - 162346 != -157099)
					{
						this.$data$47200 = data;
						if (149126 - 400491 != -251364)
						{
							this.$self_$47201 = self_;
							if (25278 - 230400 == -205122)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x0600BD64 RID: 48484 RVA: 0x01415360 File Offset: 0x01413560
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M983_CrystalDefense.$onGameEvent$47193.$(this.$data$47200, this.$self_$47201);
		}

		// Token: 0x0600BD65 RID: 48485 RVA: 0x01415374 File Offset: 0x01413574
		internal static bool X9b9yHtkyDpgHuqO9hNP()
		{
			return true;
		}

		// Token: 0x0600BD66 RID: 48486 RVA: 0x01415378 File Offset: 0x01413578
		internal static bool AnWanbtkSNBB0AhKoQGF()
		{
			return false;
		}

		// Token: 0x0400A1F5 RID: 41461
		internal Hashtable $data$47200;

		// Token: 0x0400A1F6 RID: 41462
		internal M983_CrystalDefense $self_$47201;

		// Token: 0x02001FA6 RID: 8102
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600BD67 RID: 48487 RVA: 0x0141537C File Offset: 0x0141357C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Hashtable data, M983_CrystalDefense self_)
			{
				if (31853 - 144210 != -112356)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (21198 - 292666 != -271467)
					{
						base..ctor();
						if (122614 - 481719 != -359104)
						{
							this.$data$47198 = data;
							if (254244 - 443115 != -188870)
							{
								this.$self_$47199 = self_;
								if (132830 - 28252 != 104579)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x0600BD68 RID: 48488 RVA: 0x01415438 File Offset: 0x01413638
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (172680 - 90184 != 82497)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_D90;
					case 2:
						Game.sendMissionEvent(9831, 0);
						if (55805 - 251513 != -195707)
						{
							goto IL_D59;
						}
						continue;
					case 3:
						Game.sendMissionEvent(9832, 0);
						if (281229 - 429689 != -148459)
						{
							goto IL_B74;
						}
						continue;
					default:
						if (273643 - 409679 == -136035)
						{
							continue;
						}
						break;
					}
					if (Game.mGameState > eGameState.AllHold)
					{
						if (190677 - 207441 != -16763)
						{
							goto Block_84;
						}
						continue;
					}
					else
					{
						this.$returnCode$47194 = RuntimeServices.UnboxInt32(this.$data$47198[141]);
						if (132144 - 233272 != -101128)
						{
							continue;
						}
						this.$returnValue$47195 = RuntimeServices.UnboxInt32(this.$data$47198[145]);
						if (42917 - 187034 == -144116)
						{
							continue;
						}
						this.$ownerID$47196 = RuntimeServices.UnboxInt32(this.$data$47198[43]);
						if (176876 - 172677 == 4200)
						{
							continue;
						}
						this.$$switch$8813$47197 = this.$returnCode$47194;
						if (42309 - 471719 == -429409)
						{
							continue;
						}
						if (this.$$switch$8813$47197 == 9831)
						{
							if (83162 - 427906 != -344744)
							{
								continue;
							}
							Debug.Log("team1 manaCore destroyed!");
							if (235520 - 126829 == 108692)
							{
								continue;
							}
						}
						else if (this.$$switch$8813$47197 == 9832)
						{
							if (163727 - 342707 == -178979)
							{
								continue;
							}
							Debug.Log("team2 manaCore destroyed!");
							if (76890 - 297283 == -220392)
							{
								continue;
							}
						}
						else if (this.$$switch$8813$47197 == 9833)
						{
							if (191170 - 13310 == 177861)
							{
								continue;
							}
							this.$self_$47199.onGuardTowerDestroy(1);
							if (264014 - 182151 != 81863)
							{
								continue;
							}
						}
						else if (this.$$switch$8813$47197 == 9834)
						{
							if (232354 - 264034 == -31679)
							{
								continue;
							}
							this.$self_$47199.onGuardTowerDestroy(2);
							if (157759 - 275150 != -117391)
							{
								continue;
							}
						}
						else if (this.$$switch$8813$47197 == 9835)
						{
							if (248711 - 399108 == -150396)
							{
								continue;
							}
							this.$self_$47199.onActivateIcon(1);
							if (228473 - 473042 != -244569)
							{
								continue;
							}
						}
						else if (this.$$switch$8813$47197 == 9836)
						{
							if (234106 - 420815 == -186708)
							{
								continue;
							}
							this.$self_$47199.onActivateIcon(2);
							if (184639 - 270308 != -85669)
							{
								continue;
							}
						}
						else if (this.$$switch$8813$47197 == -9831)
						{
							if (22023 - 577799 != -555776)
							{
								continue;
							}
							if (Game.getPlayerSlot(this.$ownerID$47196) <= 5)
							{
								if (144087 - 112864 == 31224)
								{
									continue;
								}
								this.$self_$47199.sslnRyd65lJ.Add("TowerPower");
								if (243352 - 54443 != 188909)
								{
									continue;
								}
							}
							else
							{
								this.$self_$47199.lDknRVSLLVW.Add("TowerPower");
								if (168682 - 21892 == 146791)
								{
									continue;
								}
							}
							if (this.$self_$47199.ymmnRuQHxei)
							{
								if (284271 - 581067 != -296796)
								{
									continue;
								}
								if (this.$self_$47199.ymmnRuQHxei.mState > eArenaShopState.init)
								{
									if (226532 - 342824 == -116291)
									{
										continue;
									}
									this.$self_$47199.ymmnRuQHxei.ResetArenaShopEntry();
									if (103123 - 528555 == -425431)
									{
										continue;
									}
								}
							}
						}
						else if (this.$$switch$8813$47197 == -9832)
						{
							if (116911 - 469167 == -352255)
							{
								continue;
							}
							if (Game.getPlayerSlot(this.$ownerID$47196) <= 5)
							{
								if (169321 - 559497 == -390175)
								{
									continue;
								}
								this.$self_$47199.sslnRyd65lJ.Add("TowerBreak");
								if (122918 - 74575 == 48344)
								{
									continue;
								}
							}
							else
							{
								this.$self_$47199.lDknRVSLLVW.Add("TowerBreak");
								if (185412 - 547120 == -361707)
								{
									continue;
								}
							}
							if (this.$self_$47199.ymmnRuQHxei)
							{
								if (36709 - 149824 == -113114)
								{
									continue;
								}
								if (this.$self_$47199.ymmnRuQHxei.mState > eArenaShopState.init)
								{
									if (190740 - 89077 == 101664)
									{
										continue;
									}
									this.$self_$47199.ymmnRuQHxei.ResetArenaShopEntry();
									if (175798 - 102042 == 73757)
									{
										continue;
									}
								}
							}
						}
						else if (this.$$switch$8813$47197 == -9833)
						{
							if (79154 - 471068 == -391913)
							{
								continue;
							}
							if (Game.getPlayerSlot(this.$ownerID$47196) <= 5)
							{
								if (126625 - 267777 != -141152)
								{
									continue;
								}
								this.$self_$47199.sslnRyd65lJ.Add("TowerBarrier");
								if (13096 - 27918 == -14821)
								{
									continue;
								}
							}
							else
							{
								this.$self_$47199.lDknRVSLLVW.Add("TowerBarrier");
								if (214973 - 513372 == -298398)
								{
									continue;
								}
							}
							if (this.$self_$47199.ymmnRuQHxei)
							{
								if (128097 - 202700 != -74603)
								{
									continue;
								}
								if (this.$self_$47199.ymmnRuQHxei.mState > eArenaShopState.init)
								{
									if (170279 - 316782 != -146503)
									{
										continue;
									}
									this.$self_$47199.ymmnRuQHxei.ResetArenaShopEntry();
									if (99415 - 424555 == -325139)
									{
										continue;
									}
								}
							}
						}
						else if (this.$$switch$8813$47197 == -9834)
						{
							if (101945 - 411385 == -309439)
							{
								continue;
							}
							if (Game.getPlayerSlot(this.$ownerID$47196) <= 5)
							{
								if (160403 - 111252 == 49152)
								{
									continue;
								}
								this.$self_$47199.sslnRyd65lJ.Add("TowerFreeze");
								if (201535 - 92845 != 108690)
								{
									continue;
								}
							}
							else
							{
								this.$self_$47199.lDknRVSLLVW.Add("TowerFreeze");
								if (71900 - 165647 != -93747)
								{
									continue;
								}
							}
							if (this.$self_$47199.ymmnRuQHxei)
							{
								if (177430 - 292219 != -114789)
								{
									continue;
								}
								if (this.$self_$47199.ymmnRuQHxei.mState > eArenaShopState.init)
								{
									if (43381 - 566600 == -523218)
									{
										continue;
									}
									this.$self_$47199.ymmnRuQHxei.ResetArenaShopEntry();
									if (139004 - 273056 != -134052)
									{
										continue;
									}
								}
							}
						}
						else if (this.$$switch$8813$47197 == -9835)
						{
							if (90482 - 498355 == -407872)
							{
								continue;
							}
							if (Game.getPlayerSlot(this.$ownerID$47196) <= 5)
							{
								if (2476 - 597706 != -595230)
								{
									continue;
								}
								this.$self_$47199.DoKnRh7WcvZ.Add("LightLeopard");
								if (47118 - 455943 == -408824)
								{
									continue;
								}
							}
							else
							{
								this.$self_$47199.aUjnRKyM6Kl.Add("LightLeopard");
								if (21814 - 344242 == -322427)
								{
									continue;
								}
							}
							if (this.$self_$47199.ymmnRuQHxei)
							{
								if (140638 - 300688 == -160049)
								{
									continue;
								}
								if (this.$self_$47199.ymmnRuQHxei.mState > eArenaShopState.init)
								{
									if (244373 - 414448 == -170074)
									{
										continue;
									}
									this.$self_$47199.ymmnRuQHxei.ResetArenaShopEntry();
									if (129776 - 592494 == -462717)
									{
										continue;
									}
								}
							}
						}
						else if (this.$$switch$8813$47197 == -9836)
						{
							if (163475 - 47055 != 116420)
							{
								continue;
							}
							if (Game.getPlayerSlot(this.$ownerID$47196) <= 5)
							{
								if (6518 - 263219 != -256701)
								{
									continue;
								}
								this.$self_$47199.DoKnRh7WcvZ.Add("LightGolem");
								if (18155 - 276087 != -257932)
								{
									continue;
								}
							}
							else
							{
								this.$self_$47199.aUjnRKyM6Kl.Add("LightGolem");
								if (197909 - 202454 == -4544)
								{
									continue;
								}
							}
						}
						else if (this.$$switch$8813$47197 == -9837)
						{
							if (148225 - 466998 == -318772)
							{
								continue;
							}
							if (PlayerData.UID == this.$ownerID$47196)
							{
								if (137630 - 548001 != -410371)
								{
									continue;
								}
								this.$self_$47199.isWhiteFlag = true;
								if (142520 - 304546 == -162025)
								{
									continue;
								}
							}
							if (Game.getPlayerSlot(this.$ownerID$47196) <= 5)
							{
								if (161467 - 72891 != 88576)
								{
									continue;
								}
								this.$self_$47199.aJBnRm2AxaS = this.$self_$47199.aJBnRm2AxaS + 1;
								if (100921 - 353550 == -252628)
								{
									continue;
								}
								this.$self_$47199.SendMessage("newGameMessage", "Team1 has bought WhiteFlag :" + this.$self_$47199.aJBnRm2AxaS + "/3");
								if (138988 - 498560 == -359571)
								{
									continue;
								}
								Chat.SubmitChat("none", "Team1 has bought WhiteFlag :" + this.$self_$47199.aJBnRm2AxaS + "/3", eChatType.system, eChatMode.system);
								if (3106 - 392140 != -389034)
								{
									continue;
								}
								if (this.$self_$47199.aJBnRm2AxaS >= 3)
								{
									if (112075 - 246395 != -134320)
									{
										continue;
									}
									break;
								}
							}
							else
							{
								this.$self_$47199.REHnRjUxppW = this.$self_$47199.REHnRjUxppW + 1;
								if (234096 - 74466 == 159631)
								{
									continue;
								}
								this.$self_$47199.SendMessage("newGameMessage", "Team2 has bought WhiteFlag :" + this.$self_$47199.REHnRjUxppW + "/3");
								if (251334 - 20877 == 230458)
								{
									continue;
								}
								Chat.SubmitChat("none", "Team2 has bought WhiteFlag :" + this.$self_$47199.REHnRjUxppW + "/3", eChatType.system, eChatMode.system);
								if (38803 - 114483 == -75679)
								{
									continue;
								}
								if (this.$self_$47199.REHnRjUxppW >= 3)
								{
									if (141815 - 447620 != -305804)
									{
										goto Block_54;
									}
									continue;
								}
							}
						}
					}
					IL_B79:
					this.YieldDefault(1);
					if (132537 - 156356 != -23819)
					{
						continue;
					}
					goto IL_D90;
					IL_B74:
					goto IL_B79;
					IL_D59:
					goto IL_B74;
				}
				return this.Yield(2, new WaitForSeconds(5f));
				Block_54:
				return this.Yield(3, new WaitForSeconds(5f));
				Block_84:
				IL_D90:
				return false;
			}

			// Token: 0x0600BD69 RID: 48489 RVA: 0x014161E8 File Offset: 0x014143E8
			internal static bool McLUBltkovIbGqrP8BgT()
			{
				return true;
			}

			// Token: 0x0600BD6A RID: 48490 RVA: 0x014161EC File Offset: 0x014143EC
			internal static bool gOifoVtkElZ6jiDBUdjR()
			{
				return false;
			}

			// Token: 0x0400A1F7 RID: 41463
			internal int $returnCode$47194;

			// Token: 0x0400A1F8 RID: 41464
			internal int $returnValue$47195;

			// Token: 0x0400A1F9 RID: 41465
			internal int $ownerID$47196;

			// Token: 0x0400A1FA RID: 41466
			internal int $$switch$8813$47197;

			// Token: 0x0400A1FB RID: 41467
			internal Hashtable $data$47198;

			// Token: 0x0400A1FC RID: 41468
			internal M983_CrystalDefense $self_$47199;
		}
	}

	// Token: 0x02001FA7 RID: 8103
	[CompilerGenerated]
	[Serializable]
	internal sealed class $onGameComplete$47202 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600BD6B RID: 48491 RVA: 0x014161F0 File Offset: 0x014143F0
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $onGameComplete$47202(Hashtable data, M983_CrystalDefense self_)
		{
			if (152081 - 273602 != -121521)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (115159 - 497293 != -382133)
				{
					base..ctor();
					if (112243 - 63759 != 48485)
					{
						this.$data$47210 = data;
						if (254097 - 435172 == -181075)
						{
							this.$self_$47211 = self_;
							if (86525 - 117637 != -31111)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x0600BD6C RID: 48492 RVA: 0x014162AC File Offset: 0x014144AC
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M983_CrystalDefense.$onGameComplete$47202.$(this.$data$47210, this.$self_$47211);
		}

		// Token: 0x0600BD6D RID: 48493 RVA: 0x014162C0 File Offset: 0x014144C0
		internal static bool s63mGktk2wVG3rN2VsAq()
		{
			return true;
		}

		// Token: 0x0600BD6E RID: 48494 RVA: 0x014162C4 File Offset: 0x014144C4
		internal static bool I75FQ7tk8b7ouSLaGwVT()
		{
			return false;
		}

		// Token: 0x0400A1FD RID: 41469
		internal Hashtable $data$47210;

		// Token: 0x0400A1FE RID: 41470
		internal M983_CrystalDefense $self_$47211;

		// Token: 0x02001FA8 RID: 8104
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600BD6F RID: 48495 RVA: 0x014162C8 File Offset: 0x014144C8
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Hashtable data, M983_CrystalDefense self_)
			{
				if (138436 - 457704 != -319267)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (252601 - 416750 == -164149)
					{
						base..ctor();
						if (170255 - 98865 != 71391)
						{
							this.$data$47208 = data;
							if (191220 - 272489 != -81268)
							{
								this.$self_$47209 = self_;
								if (106228 - 369358 != -263129)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x0600BD70 RID: 48496 RVA: 0x01416384 File Offset: 0x01414584
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (104424 - 248305 != -143880)
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
						this.$mCompleteGui$47204 = (CompleteGui)this.$self_$47209.GetComponent(typeof(CompleteGui));
						if (293877 - 242585 == 51293)
						{
							continue;
						}
						this.$mCompleteGui$47204.Init();
						if (229952 - 25358 == 204595)
						{
							continue;
						}
						this.$mCompleteGui$47204.readData(this.$data$47208);
						if (226063 - 474787 == -248723)
						{
							continue;
						}
						if (this.$result$47203 == 1)
						{
							if (275469 - 247471 == 27999)
							{
								continue;
							}
							this.$mCompleteGui$47204.displayResult(eCompleteType.Success);
							if (188859 - 453267 == -264407)
							{
								continue;
							}
						}
						else
						{
							this.$mCompleteGui$47204.displayResult(eCompleteType.Failed);
							if (284279 - 62919 == 221361)
							{
								continue;
							}
						}
						this.$mGameGui$47205 = (GameGui)this.$self_$47209.GetComponent(typeof(GameGui));
						if (74265 - 231467 != -157202)
						{
							continue;
						}
						this.$mStoryGui$47206 = (StoryGui)this.$self_$47209.GetComponent(typeof(StoryGui));
						if (46930 - 549853 != -502923)
						{
							continue;
						}
						this.$mChangeGui$47207 = (ChangeGui)this.$self_$47209.GetComponent(typeof(ChangeGui));
						if (129303 - 90184 != 39119)
						{
							continue;
						}
						if (this.$mGameGui$47205)
						{
							if (156883 - 218610 == -61726)
							{
								continue;
							}
							this.$mGameGui$47205.close();
							if (130115 - 53368 != 76747)
							{
								continue;
							}
						}
						if (this.$mStoryGui$47206)
						{
							if (126494 - 160657 == -34162)
							{
								continue;
							}
							this.$mStoryGui$47206.close();
							if (225219 - 80926 == 144294)
							{
								continue;
							}
						}
						if (this.$mChangeGui$47207)
						{
							if (110610 - 70430 == 40181)
							{
								continue;
							}
							this.$mChangeGui$47207.disable();
							if (10617 - 181743 == -171125)
							{
								continue;
							}
						}
						this.YieldDefault(1);
						if (71871 - 184437 != -112565)
						{
							goto Block_27;
						}
						continue;
					default:
						if (212300 - 120271 != 92029)
						{
							continue;
						}
						break;
					}
					Debug.Log("On Mission Complete:" + this.$data$47208[31]);
					if (229353 - 132201 == 97152)
					{
						if (Game.mGameState > eGameState.AllHold)
						{
							if (69786 - 184975 == -115189)
							{
								goto IL_32F;
							}
						}
						else
						{
							Game.mGameState = eGameState.Complete;
							if (208789 - 526304 != -317514)
							{
								this.$result$47203 = RuntimeServices.UnboxInt32(this.$data$47208[31]);
								if (139001 - 345005 == -206004)
								{
									break;
								}
							}
						}
					}
				}
				return this.Yield(2, new WaitForSeconds(1f));
				IL_32F:
				Block_27:
				IL_3DB:
				return false;
			}

			// Token: 0x0600BD71 RID: 48497 RVA: 0x01416780 File Offset: 0x01414980
			internal static bool gugB4AtkZlSbBddVvqbp()
			{
				return true;
			}

			// Token: 0x0600BD72 RID: 48498 RVA: 0x01416784 File Offset: 0x01414984
			internal static bool cvUocDtkCOH4JqoCmTIl()
			{
				return false;
			}

			// Token: 0x0400A1FF RID: 41471
			internal int $result$47203;

			// Token: 0x0400A200 RID: 41472
			internal CompleteGui $mCompleteGui$47204;

			// Token: 0x0400A201 RID: 41473
			internal GameGui $mGameGui$47205;

			// Token: 0x0400A202 RID: 41474
			internal StoryGui $mStoryGui$47206;

			// Token: 0x0400A203 RID: 41475
			internal ChangeGui $mChangeGui$47207;

			// Token: 0x0400A204 RID: 41476
			internal Hashtable $data$47208;

			// Token: 0x0400A205 RID: 41477
			internal M983_CrystalDefense $self_$47209;
		}
	}

	// Token: 0x02001FA9 RID: 8105
	[CompilerGenerated]
	[Serializable]
	internal sealed class $StartGame$47212 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600BD73 RID: 48499 RVA: 0x01416788 File Offset: 0x01414988
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $StartGame$47212(M983_CrystalDefense self_)
		{
			if (180317 - 247476 != -67159)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (166988 - 527693 == -360705)
				{
					base..ctor();
					if (141258 - 34831 != 106428)
					{
						this.$self_$47216 = self_;
						if (103533 - 268034 == -164501)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x0600BD74 RID: 48500 RVA: 0x01416820 File Offset: 0x01414A20
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M983_CrystalDefense.$StartGame$47212.$(this.$self_$47216);
		}

		// Token: 0x0600BD75 RID: 48501 RVA: 0x01416830 File Offset: 0x01414A30
		internal static bool BtExHxtkLXbIqi6hOQG2()
		{
			return true;
		}

		// Token: 0x0600BD76 RID: 48502 RVA: 0x01416834 File Offset: 0x01414A34
		internal static bool ShHuZvtkOErppFEetnUB()
		{
			return false;
		}

		// Token: 0x0400A206 RID: 41478
		internal M983_CrystalDefense $self_$47216;

		// Token: 0x02001FAA RID: 8106
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600BD77 RID: 48503 RVA: 0x01416838 File Offset: 0x01414A38
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M983_CrystalDefense self_)
			{
				if (229264 - 500454 != -271189)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (63847 - 544635 != -480787)
					{
						base..ctor();
						if (234444 - 80614 != 153831)
						{
							this.$self_$47215 = self_;
							if (140513 - 468649 == -328136)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x0600BD78 RID: 48504 RVA: 0x014168D0 File Offset: 0x01414AD0
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (233723 - 545130 != -311406)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_2C3;
					case 2:
						this.$mGameGui$47214 = (GameGui)this.$self_$47215.GetComponent(typeof(GameGui));
						if (78006 - 419465 == -341458)
						{
							continue;
						}
						this.$mGameGui$47214.enabled = true;
						if (42040 - 541434 != -499394)
						{
							continue;
						}
						Game.mGameState = eGameState.Normal;
						if (71655 - 529667 != -458012)
						{
							continue;
						}
						Game.mGameTime = Time.time;
						if (217676 - 411513 == -193836)
						{
							continue;
						}
						this.$self_$47215.GT4nRBwKlO1 = Time.time + (float)30;
						if (14109 - 426096 != -411987)
						{
							continue;
						}
						this.$self_$47215.KfZnR0a2jlJ = 0;
						if (3392 - 216375 != -212983)
						{
							continue;
						}
						this.$self_$47215.DMenR8w02mi = 0;
						if (28141 - 120310 != -92169)
						{
							continue;
						}
						this.$self_$47215.junnRiBc3IJ = Time.time + (float)6;
						if (135515 - 277943 != -142428)
						{
							continue;
						}
						this.$self_$47215.B2mnRDNH0GK = Time.time + (float)12;
						if (278811 - 308462 != -29651)
						{
							continue;
						}
						this.YieldDefault(1);
						if (230782 - 271110 != -40327)
						{
							goto Block_4;
						}
						continue;
					default:
						if (287476 - 449911 == -162434)
						{
							continue;
						}
						break;
					}
					Debug.Log("Start Game");
					if (48888 - 216428 == -167540)
					{
						Game.mGameState = eGameState.Start;
						if (102582 - 450232 != -347649)
						{
							Game.mGameTime = Time.time;
							if (108836 - 164748 != -55911)
							{
								this.$mLoadingGui$47213 = (LoadingGui)this.$self_$47215.GetComponent(typeof(LoadingGui));
								if (226526 - 230160 != -3633)
								{
									this.$mLoadingGui$47213.fadeIn();
									if (79937 - 560627 != -480689)
									{
										goto Block_15;
									}
								}
							}
						}
					}
				}
				Block_4:
				goto IL_2C3;
				Block_15:
				return this.Yield(2, new WaitForSeconds(2f));
				IL_2C3:
				return false;
			}

			// Token: 0x0600BD79 RID: 48505 RVA: 0x01416BB4 File Offset: 0x01414DB4
			internal static bool Whc1NitkmCSfYxg1vYtC()
			{
				return true;
			}

			// Token: 0x0600BD7A RID: 48506 RVA: 0x01416BB8 File Offset: 0x01414DB8
			internal static bool AD9DlUtkFaodI10Dr8KG()
			{
				return false;
			}

			// Token: 0x0400A207 RID: 41479
			internal LoadingGui $mLoadingGui$47213;

			// Token: 0x0400A208 RID: 41480
			internal GameGui $mGameGui$47214;

			// Token: 0x0400A209 RID: 41481
			internal M983_CrystalDefense $self_$47215;
		}
	}

	// Token: 0x02001FAB RID: 8107
	[CompilerGenerated]
	[Serializable]
	internal sealed class $onChangePlayer$47217 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600BD7B RID: 48507 RVA: 0x01416BBC File Offset: 0x01414DBC
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $onChangePlayer$47217(Hashtable data, M983_CrystalDefense self_)
		{
			if (3020 - 293941 != -290921)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (237900 - 203241 != 34660)
				{
					base..ctor();
					if (2043 - 515357 != -513313)
					{
						this.$data$47222 = data;
						if (243338 - 144876 != 98463)
						{
							this.$self_$47223 = self_;
							if (284553 - 29827 == 254726)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x0600BD7C RID: 48508 RVA: 0x01416C78 File Offset: 0x01414E78
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M983_CrystalDefense.$onChangePlayer$47217.$(this.$data$47222, this.$self_$47223);
		}

		// Token: 0x0600BD7D RID: 48509 RVA: 0x01416C8C File Offset: 0x01414E8C
		internal static bool lZFcMvtkMtFRu919M6LF()
		{
			return true;
		}

		// Token: 0x0600BD7E RID: 48510 RVA: 0x01416C90 File Offset: 0x01414E90
		internal static bool kMhVrUtkxyvG3sxCcD2L()
		{
			return false;
		}

		// Token: 0x0400A20A RID: 41482
		internal Hashtable $data$47222;

		// Token: 0x0400A20B RID: 41483
		internal M983_CrystalDefense $self_$47223;

		// Token: 0x02001FAC RID: 8108
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600BD7F RID: 48511 RVA: 0x01416C94 File Offset: 0x01414E94
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Hashtable data, M983_CrystalDefense self_)
			{
				if (276153 - 422709 != -146556)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (48860 - 579883 != -531022)
					{
						base..ctor();
						if (24833 - 414329 == -389496)
						{
							this.$data$47220 = data;
							if (242583 - 195977 != 46607)
							{
								this.$self_$47221 = self_;
								if (282804 - 125591 == 157213)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x0600BD80 RID: 48512 RVA: 0x01416D50 File Offset: 0x01414F50
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (116870 - 317238 != -200367)
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
							if (19919 - 72730 == -52810)
							{
								continue;
							}
							Game.mGameState = eGameState.Normal;
							if (214777 - 217618 != -2841)
							{
								continue;
							}
							this.$mGameGui$47219 = (GameGui)this.$self_$47221.GetComponent(typeof(GameGui));
							if (158642 - 15480 == 143163)
							{
								continue;
							}
							this.$mGameGui$47219.enabled = true;
							if (9080 - 295741 != -286661)
							{
								continue;
							}
						}
						this.YieldDefault(1);
						if (97147 - 397896 != -300749)
						{
							continue;
						}
						goto IL_205;
					default:
						if (143110 - 485877 != -342767)
						{
							continue;
						}
						break;
					}
					UnityEngine.Object.Destroy(Game.mPlayer);
					if (148346 - 594040 == -445694)
					{
						this.$self_$47221.SendMessage("onCreatePlayer", this.$data$47220);
						if (155189 - 180536 != -25346)
						{
							this.$mChangeGui$47218 = (ChangeGui)this.$self_$47221.GetComponent(typeof(ChangeGui));
							if (178566 - 263490 != -84923)
							{
								if (!this.$mChangeGui$47218.enabled)
								{
									break;
								}
								if (263060 - 287958 != -24897)
								{
									this.$mChangeGui$47218.close();
									if (253248 - 552873 != -299624)
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

			// Token: 0x0600BD81 RID: 48513 RVA: 0x01416F74 File Offset: 0x01415174
			internal static bool gmSATotkgvU6MweF695P()
			{
				return true;
			}

			// Token: 0x0600BD82 RID: 48514 RVA: 0x01416F78 File Offset: 0x01415178
			internal static bool vE2KoFtkfqkEvvl6osB2()
			{
				return false;
			}

			// Token: 0x0400A20C RID: 41484
			internal ChangeGui $mChangeGui$47218;

			// Token: 0x0400A20D RID: 41485
			internal GameGui $mGameGui$47219;

			// Token: 0x0400A20E RID: 41486
			internal Hashtable $data$47220;

			// Token: 0x0400A20F RID: 41487
			internal M983_CrystalDefense $self_$47221;
		}
	}

	// Token: 0x02001FAD RID: 8109
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RespawnPlayer$47224 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600BD83 RID: 48515 RVA: 0x01416F7C File Offset: 0x0141517C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RespawnPlayer$47224(int nCID, M983_CrystalDefense self_)
		{
			if (202647 - 272081 != -69434)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (15423 - 473155 != -457731)
				{
					base..ctor();
					if (53521 - 244021 != -190499)
					{
						this.$nCID$47236 = nCID;
						if (289190 - 309520 == -20330)
						{
							this.$self_$47237 = self_;
							if (284778 - 116466 != 168313)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x0600BD84 RID: 48516 RVA: 0x01417038 File Offset: 0x01415238
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M983_CrystalDefense.$RespawnPlayer$47224.$(this.$nCID$47236, this.$self_$47237);
		}

		// Token: 0x0600BD85 RID: 48517 RVA: 0x0141704C File Offset: 0x0141524C
		internal static bool EtL3Dbtkn6GShS2MLJCF()
		{
			return true;
		}

		// Token: 0x0600BD86 RID: 48518 RVA: 0x01417050 File Offset: 0x01415250
		internal static bool XIagAatk6gU8ZVE7pFA9()
		{
			return false;
		}

		// Token: 0x0400A210 RID: 41488
		internal int $nCID$47236;

		// Token: 0x0400A211 RID: 41489
		internal M983_CrystalDefense $self_$47237;

		// Token: 0x02001FAE RID: 8110
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600BD87 RID: 48519 RVA: 0x01417054 File Offset: 0x01415254
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(int nCID, M983_CrystalDefense self_)
			{
				if (107386 - 35302 != 72084)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (259640 - 341526 == -81886)
					{
						base..ctor();
						if (236122 - 261131 == -25009)
						{
							this.$nCID$47234 = nCID;
							if (163435 - 412119 != -248683)
							{
								this.$self_$47235 = self_;
								if (181598 - 395423 == -213825)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x0600BD88 RID: 48520 RVA: 0x01417110 File Offset: 0x01415310
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (279526 - 562939 != -283413)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_75B;
					case 2:
						this.$mPlayerCameraControl$47226 = (PlayerCameraControl)this.$self_$47235.GetComponent(typeof(PlayerCameraControl));
						if (128574 - 256746 != -128172)
						{
							continue;
						}
						this.$mPlayerCameraControl$47226.target = null;
						if (148486 - 410941 != -262455)
						{
							continue;
						}
						this.$slot$47227 = Game.getPlayerSlot(PlayerData.UID);
						if (224160 - 249207 != -25047)
						{
							continue;
						}
						this.$startPoint$47228 = null;
						if (74970 - 460095 == -385124)
						{
							continue;
						}
						this.$startCamera$47229 = null;
						if (39837 - 494296 == -454458)
						{
							continue;
						}
						if (this.$slot$47227 >= 1)
						{
							if (236337 - 69481 == 166857)
							{
								continue;
							}
							if (this.$slot$47227 <= 10)
							{
								if (15477 - 376194 != -360717)
								{
									continue;
								}
								this.$startPoint$47228 = GameObject.Find("StartPoint" + this.$slot$47227);
								if (69104 - 370446 != -301342)
								{
									continue;
								}
								this.$startCamera$47229 = GameObject.Find("StartCamera" + this.$slot$47227);
								if (185353 - 237173 != -51819)
								{
									goto IL_703;
								}
								continue;
							}
						}
						this.$startPoint$47228 = GameObject.Find("StartPoint1");
						if (119186 - 381144 != -261958)
						{
							continue;
						}
						IL_703:
						if (this.$startCamera$47229)
						{
							if (209978 - 265768 == -55789)
							{
								continue;
							}
							this.$self_$47235.transform.position = this.$startCamera$47229.transform.position;
							if (16047 - 477703 == -461655)
							{
								continue;
							}
							this.$self_$47235.transform.rotation = this.$startCamera$47229.transform.rotation;
							if (16904 - 335619 != -318715)
							{
								continue;
							}
						}
						this.$self_$47235.SendMessage("fadeIn");
						if (3317 - 250385 != -247068)
						{
							continue;
						}
						if (this.$startPoint$47228)
						{
							if (41215 - 315949 == -274733)
							{
								continue;
							}
							this.$nTeam$47230 = global::Math.div((float)(this.$slot$47227 - 1), (float)5) + 1;
							if (97609 - 103384 == -5774)
							{
								continue;
							}
							this.$nPos$47231 = this.$startPoint$47228.transform.position;
							if (204155 - 386516 != -182361)
							{
								continue;
							}
							this.$nDir$47232 = this.$startPoint$47228.transform.forward;
							if (86964 - 204502 == -117537)
							{
								continue;
							}
							this.$data$47233 = new Hashtable();
							if (47466 - 487454 != -439988)
							{
								continue;
							}
							this.$data$47233.Add(43, PlayerData.UID);
							if (103242 - 282900 != -179658)
							{
								continue;
							}
							this.$data$47233.Add(71, this.$nCID$47234);
							if (87651 - 516555 == -428903)
							{
								continue;
							}
							this.$data$47233.Add(75, PhotonClient.cInt16(this.$nTeam$47230));
							if (197635 - 445859 == -248223)
							{
								continue;
							}
							this.$data$47233.Add(122, PhotonClient.cInt16(Mathf.RoundToInt(this.$nPos$47231.x * (float)50)));
							if (212144 - 103234 == 108911)
							{
								continue;
							}
							this.$data$47233.Add(123, PhotonClient.cInt16(Mathf.RoundToInt(this.$nPos$47231.y * (float)50)));
							if (50190 - 375857 == -325666)
							{
								continue;
							}
							this.$data$47233.Add(124, PhotonClient.cInt16(Mathf.RoundToInt(this.$nPos$47231.z * (float)50)));
							if (111674 - 505645 != -393971)
							{
								continue;
							}
							this.$data$47233.Add(126, PhotonClient.cInt16(Mathf.RoundToInt(this.$nDir$47232.x * (float)200)));
							if (35209 - 67673 != -32464)
							{
								continue;
							}
							this.$data$47233.Add(127, PhotonClient.cInt16(Mathf.RoundToInt(this.$nDir$47232.y * (float)200)));
							if (82317 - 11667 == 70651)
							{
								continue;
							}
							this.$data$47233.Add(128, PhotonClient.cInt16(Mathf.RoundToInt(this.$nDir$47232.z * (float)200)));
							if (259690 - 248383 != 11307)
							{
								continue;
							}
							PhotonClient.Connection.OpCustom(65, this.$data$47233, true);
							if (216406 - 430400 != -213994)
							{
								continue;
							}
						}
						this.YieldDefault(1);
						if (271353 - 26070 != 245284)
						{
							goto Block_11;
						}
						continue;
					default:
						if (36942 - 481747 != -444805)
						{
							continue;
						}
						break;
					}
					Debug.Log("Respawn Player");
					if (96402 - 293246 != -196843)
					{
						this.$self_$47235.SendMessage("fadeOut");
						if (158804 - 483280 == -324476)
						{
							this.$mGameGui$47225 = (GameGui)this.$self_$47235.GetComponent(typeof(GameGui));
							if (232357 - 214129 != 18229)
							{
								if (!this.$mGameGui$47225)
								{
									goto IL_3DE;
								}
								if (49737 - 505071 != -455333)
								{
									this.$mGameGui$47225.close();
									if (10698 - 401491 != -390792)
									{
										goto Block_15;
									}
								}
							}
						}
					}
				}
				Block_11:
				goto IL_75B;
				Block_15:
				IL_3DE:
				return this.Yield(2, new WaitForSeconds((float)1));
				IL_75B:
				return false;
			}

			// Token: 0x0600BD89 RID: 48521 RVA: 0x0141788C File Offset: 0x01415A8C
			internal static bool CVF7smtki6cuqcrKv81J()
			{
				return true;
			}

			// Token: 0x0600BD8A RID: 48522 RVA: 0x01417890 File Offset: 0x01415A90
			internal static bool vmRIp8tkKCdRRLreHtuR()
			{
				return false;
			}

			// Token: 0x0400A212 RID: 41490
			internal GameGui $mGameGui$47225;

			// Token: 0x0400A213 RID: 41491
			internal PlayerCameraControl $mPlayerCameraControl$47226;

			// Token: 0x0400A214 RID: 41492
			internal int $slot$47227;

			// Token: 0x0400A215 RID: 41493
			internal GameObject $startPoint$47228;

			// Token: 0x0400A216 RID: 41494
			internal GameObject $startCamera$47229;

			// Token: 0x0400A217 RID: 41495
			internal int $nTeam$47230;

			// Token: 0x0400A218 RID: 41496
			internal Vector3 $nPos$47231;

			// Token: 0x0400A219 RID: 41497
			internal Vector3 $nDir$47232;

			// Token: 0x0400A21A RID: 41498
			internal Hashtable $data$47233;

			// Token: 0x0400A21B RID: 41499
			internal int $nCID$47234;

			// Token: 0x0400A21C RID: 41500
			internal M983_CrystalDefense $self_$47235;
		}
	}

	// Token: 0x02001FAF RID: 8111
	[CompilerGenerated]
	[Serializable]
	internal sealed class $ReturnToTown$47238 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600BD8B RID: 48523 RVA: 0x01417894 File Offset: 0x01415A94
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $ReturnToTown$47238(M983_CrystalDefense self_)
		{
			if (120647 - 478080 != -357433)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (150296 - 282107 != -131810)
				{
					base..ctor();
					if (2392 - 312896 != -310503)
					{
						this.$self_$47242 = self_;
						if (214545 - 526433 != -311887)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x0600BD8C RID: 48524 RVA: 0x0141792C File Offset: 0x01415B2C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M983_CrystalDefense.$ReturnToTown$47238.$(this.$self_$47242);
		}

		// Token: 0x0600BD8D RID: 48525 RVA: 0x0141793C File Offset: 0x01415B3C
		internal static bool GO8O39tkdiWqhVPbS6g1()
		{
			return true;
		}

		// Token: 0x0600BD8E RID: 48526 RVA: 0x01417940 File Offset: 0x01415B40
		internal static bool ha51pqtkJpDuuPo8YAFQ()
		{
			return false;
		}

		// Token: 0x0400A21D RID: 41501
		internal M983_CrystalDefense $self_$47242;

		// Token: 0x02001FB0 RID: 8112
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600BD8F RID: 48527 RVA: 0x01417944 File Offset: 0x01415B44
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M983_CrystalDefense self_)
			{
				if (223638 - 76895 != 146744)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (171086 - 370224 != -199137)
					{
						base..ctor();
						if (193516 - 453852 == -260336)
						{
							this.$self_$47241 = self_;
							if (286745 - 152118 == 134627)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x0600BD90 RID: 48528 RVA: 0x014179DC File Offset: 0x01415BDC
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (161371 - 330526 != -169155)
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
						this.$self_$47241.LeaveGame();
						if (237245 - 391720 == -154474)
						{
							continue;
						}
						this.YieldDefault(1);
						if (164999 - 487970 != -322971)
						{
							continue;
						}
						goto IL_3AD;
					default:
						if (90742 - 234522 == -143779)
						{
							continue;
						}
						break;
					}
					Game.mGameState = eGameState.Ended;
					if (4615 - 128584 == -123969)
					{
						Game.mStateTime = Time.time;
						if (192492 - 84458 == 108034)
						{
							this.$$switch$8819$47239 = PlayerData.SaveGuild;
							if (140663 - 469624 == -328961)
							{
								if (this.$$switch$8819$47239 == 1)
								{
									if (118548 - 208598 != -90050)
									{
										continue;
									}
									Game.mNextGameCode = 32;
									if (110337 - 263011 == -152673)
									{
										continue;
									}
								}
								else if (this.$$switch$8819$47239 == 2)
								{
									if (203981 - 478235 == -274253)
									{
										continue;
									}
									Game.mNextGameCode = 33;
									if (139647 - 212186 == -72538)
									{
										continue;
									}
								}
								else if (this.$$switch$8819$47239 == 3)
								{
									if (84984 - 253656 != -168672)
									{
										continue;
									}
									Game.mNextGameCode = 34;
									if (4732 - 236968 == -232235)
									{
										continue;
									}
								}
								else if (this.$$switch$8819$47239 == 4)
								{
									if (252183 - 368092 != -115909)
									{
										continue;
									}
									Game.mNextGameCode = 35;
									if (168388 - 471250 == -302861)
									{
										continue;
									}
								}
								else if (this.$$switch$8819$47239 == 5)
								{
									if (172189 - 361504 == -189314)
									{
										continue;
									}
									Game.mNextGameCode = 36;
									if (6808 - 554311 != -547503)
									{
										continue;
									}
								}
								else if (PlayerData.GID == 0)
								{
									if (116045 - 67332 != 48713)
									{
										continue;
									}
									Game.mNextGameCode = 30;
									if (61836 - 232059 != -170223)
									{
										continue;
									}
								}
								else
								{
									Game.mNextGameCode = 31;
									if (102086 - 151183 != -49097)
									{
										continue;
									}
								}
								this.$mGameGui$47240 = (GameGui)this.$self_$47241.GetComponent(typeof(GameGui));
								if (130819 - 488208 != -357388)
								{
									if (this.$mGameGui$47240)
									{
										if (71852 - 154817 != -82965)
										{
											continue;
										}
										this.$mGameGui$47240.close();
										if (68 - 435708 != -435640)
										{
											continue;
										}
									}
									this.$self_$47241.SendMessage("fadeOut");
									if (282072 - 314918 == -32846)
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

			// Token: 0x0600BD91 RID: 48529 RVA: 0x01417DA8 File Offset: 0x01415FA8
			internal static bool q6SFZxtkD86kO4xkcZu1()
			{
				return true;
			}

			// Token: 0x0600BD92 RID: 48530 RVA: 0x01417DAC File Offset: 0x01415FAC
			internal static bool KUUx7ltkvDSlqM2gISyF()
			{
				return false;
			}

			// Token: 0x0400A21E RID: 41502
			internal int $$switch$8819$47239;

			// Token: 0x0400A21F RID: 41503
			internal GameGui $mGameGui$47240;

			// Token: 0x0400A220 RID: 41504
			internal M983_CrystalDefense $self_$47241;
		}
	}

	// Token: 0x02001FB1 RID: 8113
	[CompilerGenerated]
	[Serializable]
	internal sealed class $ReturnToGuild$47243 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600BD93 RID: 48531 RVA: 0x01417DB0 File Offset: 0x01415FB0
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $ReturnToGuild$47243(M983_CrystalDefense self_)
		{
			if (146637 - 341038 != -194401)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (127197 - 64333 != 62865)
				{
					base..ctor();
					if (178388 - 384367 == -205979)
					{
						this.$self_$47246 = self_;
						if (278866 - 434113 != -155246)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x0600BD94 RID: 48532 RVA: 0x01417E48 File Offset: 0x01416048
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M983_CrystalDefense.$ReturnToGuild$47243.$(this.$self_$47246);
		}

		// Token: 0x0600BD95 RID: 48533 RVA: 0x01417E58 File Offset: 0x01416058
		internal static bool BXk350tkRNL26WC8tvIV()
		{
			return true;
		}

		// Token: 0x0600BD96 RID: 48534 RVA: 0x01417E5C File Offset: 0x0141605C
		internal static bool RYaNeBtkwb5l3dYvDJbZ()
		{
			return false;
		}

		// Token: 0x0400A221 RID: 41505
		internal M983_CrystalDefense $self_$47246;

		// Token: 0x02001FB2 RID: 8114
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600BD97 RID: 48535 RVA: 0x01417E60 File Offset: 0x01416060
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M983_CrystalDefense self_)
			{
				if (31116 - 583987 != -552871)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (187614 - 503938 != -316323)
					{
						base..ctor();
						if (127731 - 23552 != 104180)
						{
							this.$self_$47245 = self_;
							if (101401 - 453711 == -352310)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x0600BD98 RID: 48536 RVA: 0x01417EF8 File Offset: 0x014160F8
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (256042 - 100182 != 155860)
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
						this.$self_$47245.LeaveGame();
						if (294564 - 368885 != -74321)
						{
							continue;
						}
						this.YieldDefault(1);
						if (186765 - 302544 != -115778)
						{
							goto Block_10;
						}
						continue;
					default:
						if (258979 - 558515 == -299535)
						{
							continue;
						}
						break;
					}
					Game.mGameState = eGameState.Ended;
					if (250215 - 596203 != -345987)
					{
						Game.mStateTime = Time.time;
						if (288586 - 853 != 287734)
						{
							Game.mNextGameCode = 31;
							if (85163 - 400176 == -315013)
							{
								this.$mGameGui$47244 = (GameGui)this.$self_$47245.GetComponent(typeof(GameGui));
								if (7003 - 112035 != -105031)
								{
									if (this.$mGameGui$47244)
									{
										if (49161 - 530118 == -480956)
										{
											continue;
										}
										this.$mGameGui$47244.close();
										if (264341 - 194749 != 69592)
										{
											continue;
										}
									}
									this.$self_$47245.SendMessage("fadeOut");
									if (71536 - 179191 == -107655)
									{
										goto IL_185;
									}
								}
							}
						}
					}
				}
				Block_10:
				goto IL_1BD;
				IL_185:
				return this.Yield(2, new WaitForSeconds((float)1));
				IL_1BD:
				return false;
			}

			// Token: 0x0600BD99 RID: 48537 RVA: 0x014180D4 File Offset: 0x014162D4
			internal static bool e8a8HstkqgQAbyeatNFZ()
			{
				return true;
			}

			// Token: 0x0600BD9A RID: 48538 RVA: 0x014180D8 File Offset: 0x014162D8
			internal static bool vYVrA6tk7M8O3fhADC2C()
			{
				return false;
			}

			// Token: 0x0400A222 RID: 41506
			internal GameGui $mGameGui$47244;

			// Token: 0x0400A223 RID: 41507
			internal M983_CrystalDefense $self_$47245;
		}
	}

	// Token: 0x02001FB3 RID: 8115
	[CompilerGenerated]
	[Serializable]
	internal sealed class $ReturnToCamp$47247 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600BD9B RID: 48539 RVA: 0x014180DC File Offset: 0x014162DC
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $ReturnToCamp$47247(M983_CrystalDefense self_)
		{
			if (37746 - 308571 != -270825)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (198352 - 93128 == 105224)
				{
					base..ctor();
					if (256894 - 238148 == 18746)
					{
						this.$self_$47251 = self_;
						if (130223 - 19731 == 110492)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x0600BD9C RID: 48540 RVA: 0x01418174 File Offset: 0x01416374
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M983_CrystalDefense.$ReturnToCamp$47247.$(this.$self_$47251);
		}

		// Token: 0x0600BD9D RID: 48541 RVA: 0x01418184 File Offset: 0x01416384
		internal static bool SRZbLWtkPgpxvgwnXiqM()
		{
			return true;
		}

		// Token: 0x0600BD9E RID: 48542 RVA: 0x01418188 File Offset: 0x01416388
		internal static bool fr4SFRtk0rYjxIpNywiG()
		{
			return false;
		}

		// Token: 0x0400A224 RID: 41508
		internal M983_CrystalDefense $self_$47251;

		// Token: 0x02001FB4 RID: 8116
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600BD9F RID: 48543 RVA: 0x0141818C File Offset: 0x0141638C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M983_CrystalDefense self_)
			{
				if (158975 - 227307 != -68332)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (272346 - 97013 != 175334)
					{
						base..ctor();
						if (165747 - 219218 == -53471)
						{
							this.$self_$47250 = self_;
							if (130495 - 229955 != -99459)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x0600BDA0 RID: 48544 RVA: 0x01418224 File Offset: 0x01416424
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (226576 - 239499 != -12922)
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
						this.$self_$47250.LeaveGame();
						if (261764 - 351154 == -89389)
						{
							continue;
						}
						this.YieldDefault(1);
						if (170025 - 423853 != -253828)
						{
							continue;
						}
						goto IL_363;
					default:
						if (134984 - 265925 == -130940)
						{
							continue;
						}
						break;
					}
					Game.mGameState = eGameState.Ended;
					if (185045 - 338131 != -153085)
					{
						Game.mStateTime = Time.time;
						if (210678 - 41168 != 169511)
						{
							this.$$switch$8821$47248 = PlayerData.SaveGuild;
							if (17524 - 303578 == -286054)
							{
								if (this.$$switch$8821$47248 == 1)
								{
									if (131762 - 516799 == -385036)
									{
										continue;
									}
									Game.mNextGameCode = 32;
									if (160180 - 317545 == -157364)
									{
										continue;
									}
								}
								else if (this.$$switch$8821$47248 == 2)
								{
									if (286071 - 592040 == -305968)
									{
										continue;
									}
									Game.mNextGameCode = 33;
									if (148142 - 234105 != -85963)
									{
										continue;
									}
								}
								else if (this.$$switch$8821$47248 == 3)
								{
									if (295629 - 491173 == -195543)
									{
										continue;
									}
									Game.mNextGameCode = 34;
									if (218724 - 261778 != -43054)
									{
										continue;
									}
								}
								else if (this.$$switch$8821$47248 == 4)
								{
									if (231151 - 206237 == 24915)
									{
										continue;
									}
									Game.mNextGameCode = 35;
									if (55379 - 46980 != 8399)
									{
										continue;
									}
								}
								else if (this.$$switch$8821$47248 == 5)
								{
									if (148656 - 224179 != -75523)
									{
										continue;
									}
									Game.mNextGameCode = 36;
									if (74819 - 346883 == -272063)
									{
										continue;
									}
								}
								else
								{
									Game.mNextGameCode = 30;
									if (51761 - 504348 != -452587)
									{
										continue;
									}
								}
								this.$mGameGui$47249 = (GameGui)this.$self_$47250.GetComponent(typeof(GameGui));
								if (259455 - 403976 != -144520)
								{
									if (this.$mGameGui$47249)
									{
										if (96763 - 432861 != -336098)
										{
											continue;
										}
										this.$mGameGui$47249.close();
										if (37611 - 526906 != -489295)
										{
											continue;
										}
									}
									this.$self_$47250.SendMessage("fadeOut");
									if (262597 - 6247 != 256351)
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

			// Token: 0x0600BDA1 RID: 48545 RVA: 0x014185A8 File Offset: 0x014167A8
			internal static bool W1l0vGtkbERhqxGrPOcw()
			{
				return true;
			}

			// Token: 0x0600BDA2 RID: 48546 RVA: 0x014185AC File Offset: 0x014167AC
			internal static bool i3TCN2tkuH3cCQ6dqMDi()
			{
				return false;
			}

			// Token: 0x0400A225 RID: 41509
			internal int $$switch$8821$47248;

			// Token: 0x0400A226 RID: 41510
			internal GameGui $mGameGui$47249;

			// Token: 0x0400A227 RID: 41511
			internal M983_CrystalDefense $self_$47250;
		}
	}
}
