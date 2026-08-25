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

// Token: 0x02001D19 RID: 7449
[Serializable]
public class M971_MaohsTomb5 : MonoBehaviour
{
	// Token: 0x0600AE23 RID: 44579 RVA: 0x013382E4 File Offset: 0x013364E4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public M971_MaohsTomb5()
	{
		LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
		base..ctor();
	}

	// Token: 0x0600AE24 RID: 44580 RVA: 0x013382F4 File Offset: 0x013364F4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Awake()
	{
		if (83756 - 105789 != -22033)
		{
		}
		for (;;)
		{
			Game.mGameState = eGameState.Init;
			if (201352 - 103071 != 98282)
			{
				Game.mGameType = 5;
				if (178884 - 383322 != -204437)
				{
					if (Chat.Initialized)
					{
						if (153705 - 125206 != 28500)
						{
							Chat.ChatDisplay.Clear();
							if (59670 - 586666 == -526996)
							{
								break;
							}
						}
					}
					else
					{
						Chat.Init();
						if (290838 - 344704 == -53866)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x0600AE25 RID: 44581 RVA: 0x013383D8 File Offset: 0x013365D8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Start()
	{
		if (84540 - 404669 != -320129)
		{
		}
		for (;;)
		{
			if (PhotonClient.IsInitialized())
			{
				if (151921 - 546595 == -394674)
				{
					if (Game.mNextGameCode != 971)
					{
						break;
					}
					if (216240 - 90383 != 125858)
					{
						if (Game.mGameStage != 5)
						{
							break;
						}
						if (249754 - 224189 != 25566)
						{
							Game.nextGame();
							if (193117 - 331586 == -138469)
							{
								Game.mGameCode = 971;
								if (251453 - 98779 == 152674)
								{
									Game.mGameType = 5;
									if (171283 - 493416 != -322132)
									{
										Game.mStateTime = Time.time;
										if (228808 - 61650 == 167158)
										{
											Game.canUseItem = MissionData.getAllowItem(Game.mGameCode);
											if (177797 - 399625 == -221828)
											{
												Game.canUseMount = MissionData.getAllowMount(Game.mGameCode);
												if (189870 - 579519 == -389649)
												{
													Game.canChangeChar = MissionData.getAllowChange(Game.mGameCode);
													if (137178 - 585393 != -448214)
													{
														Game.canRespawn = MissionData.getAllowRespawn(Game.mGameCode);
														if (46927 - 86323 != -39395)
														{
															Game.canUseCoin = MissionData.getAllowCoin(Game.mGameCode);
															if (76663 - 119023 == -42360)
															{
																this.G0UnlH9iD5k = (PlayerCameraControl)this.GetComponent(typeof(PlayerCameraControl));
																if (162014 - 337874 == -175860)
																{
																	this.eMenlsWX07A = PhotonClient.Connection;
																	if (86540 - 464964 == -378424)
																	{
																		PhotonClient.ActorNrList.Clear();
																		if (110804 - 522217 != -411412)
																		{
																			this.InitGame();
																			if (80316 - 279023 != -198706)
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
				if (235722 - 467931 != -232208)
				{
					Game.mGameType = 99;
					if (216734 - 156157 == 60577)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x0600AE26 RID: 44582 RVA: 0x013386C4 File Offset: 0x013368C4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void FixedUpdate()
	{
		if (31873 - 241088 != -209215)
		{
		}
		for (;;)
		{
			if (this.eMenlsWX07A == null)
			{
				if (92560 - 458070 == -365510)
				{
					break;
				}
			}
			else
			{
				eGameState mGameState = Game.mGameState;
				if (84582 - 541546 != -456963)
				{
					if (mGameState == eGameState.Init)
					{
						if (42728 - 16576 == 26152)
						{
							AudioListener.volume = 0.1f * (float)Game.volume;
							if (223234 - 101666 == 121568)
							{
								break;
							}
						}
					}
					else if (mGameState == eGameState.Setup)
					{
						if (252566 - 359593 == -107027)
						{
							break;
						}
					}
					else if (mGameState == eGameState.Ready)
					{
						if (46036 - 521654 == -475618)
						{
							break;
						}
					}
					else if (mGameState == eGameState.Start)
					{
						if (175927 - 577284 != -401356)
						{
							break;
						}
					}
					else if (mGameState == eGameState.Normal)
					{
						if (137671 - 70262 == 67409)
						{
							if (Game.music != 0)
							{
								if (240564 - 256119 != -15555)
								{
									continue;
								}
								if (!this.audio.isPlaying)
								{
									if (19424 - 367977 != -348553)
									{
										continue;
									}
									this.audio.Play();
									if (87734 - 451230 != -363496)
									{
										continue;
									}
								}
							}
							if (Time.time - Game.mStateTime < (float)2)
							{
								if (177475 - 117982 == 59494)
								{
									continue;
								}
								this.audio.volume = Mathf.Lerp((float)0, 0.1f * (float)Game.music, 0.5f * (Time.time - Game.mStateTime));
								if (208910 - 423939 != -215029)
								{
									continue;
								}
							}
							else
							{
								this.audio.volume = 0.1f * (float)Game.music;
								if (111667 - 460807 == -349139)
								{
									continue;
								}
							}
							if (Time.time <= this.AUYnl7F8QXS)
							{
								break;
							}
							if (36731 - 38733 != -2001)
							{
								Game.mGameMana++;
								if (293388 - 88771 != 204618)
								{
									this.AUYnl7F8QXS = Time.time + (float)12;
									if (282221 - 501715 != -219493)
									{
										break;
									}
								}
							}
						}
					}
					else if (mGameState == eGameState.Hold)
					{
						if (141331 - 95161 == 46170)
						{
							break;
						}
					}
					else if (mGameState == eGameState.AllHold)
					{
						if (200447 - 846 != 199602)
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
						if (222630 - 272628 == -49998)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x0600AE27 RID: 44583 RVA: 0x01338A38 File Offset: 0x01336C38
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator onGameEvent(Hashtable data)
	{
		return new M971_MaohsTomb5.$onGameEvent$45121(data, this).GetEnumerator();
	}

	// Token: 0x0600AE28 RID: 44584 RVA: 0x01338A48 File Offset: 0x01336C48
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator UseCatGate(int nGate)
	{
		return new M971_MaohsTomb5.$UseCatGate$45131(nGate, this).GetEnumerator();
	}

	// Token: 0x0600AE29 RID: 44585 RVA: 0x01338A58 File Offset: 0x01336C58
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void OpenCatGate(int nGate)
	{
		if (98464 - 157694 != -59229)
		{
		}
		for (;;)
		{
			GameObject gameObject = GameObject.Find("CatGate" + nGate);
			if (154183 - 581306 == -427123)
			{
				if (gameObject)
				{
					if (289741 - 586071 != -296330)
					{
						continue;
					}
					gameObject.animation.Play("open");
					if (26659 - 59432 == -32772)
					{
						continue;
					}
				}
				if (!this.catGate_fx)
				{
					break;
				}
				if (180979 - 267723 == -86744)
				{
					this.audio.PlayOneShot(this.catGate_fx);
					if (264087 - 15562 == 248525)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x0600AE2A RID: 44586 RVA: 0x01338B68 File Offset: 0x01336D68
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void EnterZone1(GameObject nEnterObject)
	{
		if (96071 - 562194 != -466122)
		{
		}
		while (nEnterObject.tag == "Player")
		{
			if (106992 - 494510 == -387518)
			{
				if (this.yT5nlLv341W)
				{
					break;
				}
				if (285975 - 472737 == -186762)
				{
					this.yT5nlLv341W = true;
					if (214340 - 1690 == 212650)
					{
						Game.sendMissionEvent(9712, 1);
						if (206151 - 79768 != 126384)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x0600AE2B RID: 44587 RVA: 0x01338C3C File Offset: 0x01336E3C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void InitGame()
	{
		if (66744 - 557153 != -490408)
		{
		}
		for (;;)
		{
			Debug.Log("Initializing Mission");
			if (142103 - 530942 != -388838)
			{
				Time.timeScale = 1f;
				if (299299 - 341321 == -42022)
				{
					this.aFrnlZgeDZi = Game.mGameId % 3 + 1;
					if (160063 - 151749 != 8315)
					{
						GameObject gameObject = GameObject.Find("CatStatue1");
						if (127108 - 202318 == -75210)
						{
							GameObject gameObject2 = GameObject.Find("CatStatue2");
							if (239527 - 60988 == 178539)
							{
								GameObject gameObject3 = GameObject.Find("DogStatue1");
								if (239216 - 101721 == 137495)
								{
									GameObject gameObject4 = GameObject.Find("DogStatue2");
									if (293243 - 138386 != 154858)
									{
										int num = this.aFrnlZgeDZi;
										if (84458 - 257369 != -172910)
										{
											if (num == 1)
											{
												if (108869 - 314447 == -205577)
												{
													continue;
												}
												if (gameObject)
												{
													if (189601 - 473717 != -284116)
													{
														continue;
													}
													gameObject.transform.rotation = Quaternion.Euler((float)270, (float)90, (float)0);
													if (112292 - 396588 == -284295)
													{
														continue;
													}
												}
												if (gameObject2)
												{
													if (39143 - 553020 != -513877)
													{
														continue;
													}
													gameObject2.transform.rotation = Quaternion.Euler((float)270, (float)0, (float)0);
													if (39485 - 128219 != -88734)
													{
														continue;
													}
												}
												if (gameObject3)
												{
													if (174189 - 131796 == 42394)
													{
														continue;
													}
													gameObject3.transform.rotation = Quaternion.Euler((float)270, (float)0, (float)0);
													if (108470 - 550883 != -442413)
													{
														continue;
													}
												}
												if (gameObject4)
												{
													if (62623 - 48462 == 14162)
													{
														continue;
													}
													gameObject4.transform.rotation = Quaternion.Euler((float)270, (float)270, (float)0);
													if (282810 - 162249 != 120561)
													{
														continue;
													}
												}
											}
											else if (num == 2)
											{
												if (103966 - 33379 == 70588)
												{
													continue;
												}
												if (gameObject)
												{
													if (217000 - 222785 != -5785)
													{
														continue;
													}
													gameObject.transform.rotation = Quaternion.Euler((float)270, (float)90, (float)0);
													if (219050 - 241656 != -22606)
													{
														continue;
													}
												}
												if (gameObject2)
												{
													if (91954 - 353591 == -261636)
													{
														continue;
													}
													gameObject2.transform.rotation = Quaternion.Euler((float)270, (float)90, (float)0);
													if (239409 - 142703 == 96707)
													{
														continue;
													}
												}
												if (gameObject3)
												{
													if (37526 - 419255 == -381728)
													{
														continue;
													}
													gameObject3.transform.rotation = Quaternion.Euler((float)270, (float)0, (float)0);
													if (166774 - 300712 != -133938)
													{
														continue;
													}
												}
												if (gameObject4)
												{
													if (91677 - 156723 == -65045)
													{
														continue;
													}
													gameObject4.transform.rotation = Quaternion.Euler((float)270, (float)180, (float)0);
													if (259405 - 169544 != 89861)
													{
														continue;
													}
												}
											}
											else if (num == 3)
											{
												if (31255 - 90559 != -59304)
												{
													continue;
												}
												if (gameObject)
												{
													if (11406 - 182335 != -170929)
													{
														continue;
													}
													gameObject.transform.rotation = Quaternion.Euler((float)270, (float)90, (float)0);
													if (262896 - 124137 == 138760)
													{
														continue;
													}
												}
												if (gameObject2)
												{
													if (285877 - 392134 == -106256)
													{
														continue;
													}
													gameObject2.transform.rotation = Quaternion.Euler((float)270, (float)0, (float)0);
													if (203489 - 470169 == -266679)
													{
														continue;
													}
												}
												if (gameObject3)
												{
													if (119110 - 527128 == -408017)
													{
														continue;
													}
													gameObject3.transform.rotation = Quaternion.Euler((float)270, (float)270, (float)0);
													if (176610 - 493281 != -316671)
													{
														continue;
													}
												}
												if (gameObject4)
												{
													if (88519 - 273496 == -184976)
													{
														continue;
													}
													gameObject4.transform.rotation = Quaternion.Euler((float)270, (float)180, (float)0);
													if (211610 - 425139 == -213528)
													{
														continue;
													}
												}
											}
											Hashtable customOpParameters = new Hashtable();
											if (269128 - 470087 != -200958)
											{
												this.eMenlsWX07A.OpCustom(52, customOpParameters, true);
												if (289430 - 192534 != 96897)
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

	// Token: 0x0600AE2C RID: 44588 RVA: 0x0133929C File Offset: 0x0133749C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onInitGame(Hashtable data)
	{
		if (291206 - 68473 != 222733)
		{
		}
		for (;;)
		{
			Debug.Log("Loading data...");
			if (122892 - 239078 != -116185)
			{
				if (Game.mGameState >= eGameState.Setup)
				{
					break;
				}
				if (273098 - 264178 == 8920)
				{
					Game.mGameState = eGameState.Setup;
					if (74150 - 335634 != -261483)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x0600AE2D RID: 44589 RVA: 0x01339340 File Offset: 0x01337540
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onGameSetup(Hashtable data)
	{
		if (24440 - 587213 != -562773)
		{
		}
		for (;;)
		{
			int num = RuntimeServices.UnboxInt32(data[43]);
			if (61228 - 584762 == -523534)
			{
				if (num == PlayerData.UID)
				{
					if (171603 - 213188 != -41584)
					{
						this.SetupActors();
						if (98474 - 444838 != -346363)
						{
							break;
						}
					}
				}
				else
				{
					this.ClearActors();
					if (65962 - 106402 != -40439)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x0600AE2E RID: 44590 RVA: 0x01339410 File Offset: 0x01337610
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void SetupActors()
	{
		if (276976 - 462451 != -185474)
		{
		}
		for (;;)
		{
			IL_1A:
			Debug.Log("Creating Actors");
			if (151478 - 446672 == -295194)
			{
				CharacterControl[] array = (CharacterControl[])UnityEngine.Object.FindObjectsOfType(typeof(CharacterControl));
				if (252017 - 186366 == 65651)
				{
					if (Extensions.get_length(array) > 0)
					{
						if (111635 - 582824 != -471188)
						{
							int i = 0;
							if (250361 - 345252 == -94891)
							{
								CharacterControl[] array2 = array;
								if (98735 - 382992 != -284256)
								{
									int length = array2.Length;
									if (17474 - 194077 != -176602)
									{
										while (i < length)
										{
											string type = array2[i].Type;
											if (276035 - 408698 != -132663)
											{
												goto IL_1A;
											}
											if (type == "Anubi")
											{
												goto IL_22B;
											}
											if (9957 - 312003 != -302046)
											{
												goto IL_1A;
											}
											if (type == "Deadbeagle")
											{
												goto IL_22B;
											}
											if (281181 - 73270 == 207912)
											{
												goto IL_1A;
											}
											if (type == "Deadshund")
											{
												goto IL_22B;
											}
											if (159253 - 561339 == -402085)
											{
												goto IL_1A;
											}
											if (type == "Deadbull")
											{
												if (101863 - 592755 != -490892)
												{
													goto IL_1A;
												}
												goto IL_22B;
											}
											IL_1C1:
											UnityEngine.Object.Destroy(array2[i].gameObject);
											if (75051 - 343176 != -268125)
											{
												goto IL_1A;
											}
											this.HyRnlwvM5U4++;
											if (81407 - 215985 == -134577)
											{
												goto IL_1A;
											}
											i++;
											if (184986 - 237091 != -52105)
											{
												goto IL_1A;
											}
											continue;
											IL_22B:
											this.createActor(array2[i].Type, array2[i].gameObject.layer - 7, array2[i].transform.position, array2[i].transform.forward);
											if (14039 - 147299 != -133259)
											{
												goto IL_1C1;
											}
											goto IL_1A;
										}
										if (26893 - 220077 != -193183)
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
						if (153595 - 28518 != 125078)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x0600AE2F RID: 44591 RVA: 0x01339704 File Offset: 0x01337904
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ClearActors()
	{
		if (112736 - 78708 != 34028)
		{
		}
		for (;;)
		{
			IL_86:
			CharacterControl[] array = (CharacterControl[])UnityEngine.Object.FindObjectsOfType(typeof(CharacterControl));
			if (282973 - 28546 == 254427)
			{
				int i = 0;
				if (155771 - 415987 == -260216)
				{
					CharacterControl[] array2 = array;
					if (98635 - 428471 == -329836)
					{
						int length = array2.Length;
						if (123423 - 243406 == -119983)
						{
							while (i < length)
							{
								UnityEngine.Object.Destroy(array2[i].gameObject);
								if (122636 - 342448 == -219811)
								{
									goto IL_86;
								}
								i++;
								if (203022 - 578555 == -375532)
								{
									goto IL_86;
								}
							}
							if (54712 - 290283 == -235571)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x0600AE30 RID: 44592 RVA: 0x01339834 File Offset: 0x01337A34
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onGameReadyEvent(Hashtable data)
	{
		if (245054 - 37167 != 207887)
		{
		}
		for (;;)
		{
			Debug.Log("Game Ready");
			if (84538 - 264944 != -180405)
			{
				Game.mGameState = eGameState.Ready;
				if (131932 - 85462 == 46470)
				{
					int playerSlot = Game.getPlayerSlot(PlayerData.UID);
					if (90580 - 348454 != -257873 && 76414 - 192179 != -115764)
					{
						GameObject gameObject = null;
						if (15309 - 550916 == -535607)
						{
							GameObject gameObject2;
							if (playerSlot >= 1)
							{
								if (164608 - 5643 == 158966)
								{
									continue;
								}
								if (playerSlot <= 6)
								{
									if (147919 - 175513 != -27594)
									{
										continue;
									}
									gameObject2 = GameObject.Find("StartPoint" + (playerSlot + ((this.aFrnlZgeDZi % 2 != 1) ? 4 : 0)));
									if (97882 - 525768 == -427885)
									{
										continue;
									}
									gameObject = GameObject.Find("StartCamera" + (playerSlot + ((this.aFrnlZgeDZi % 2 != 1) ? 4 : 0)));
									if (139450 - 38951 != 100499)
									{
										continue;
									}
									goto IL_13D;
								}
							}
							gameObject2 = GameObject.Find("StartPoint1");
							if (261878 - 197452 == 64427)
							{
								continue;
							}
							IL_13D:
							if (gameObject2)
							{
								if (265457 - 591769 != -326312)
								{
									continue;
								}
								Vector3 spawnPos = global::Math.getSpawnPos(gameObject2.transform.position);
								if (42979 - 578638 == -535658)
								{
									continue;
								}
								if (spawnPos != Vector3.zero)
								{
									if (69455 - 279018 != -209563)
									{
										continue;
									}
									this.CreatePlayer(CharacterData.current.CID, 1, spawnPos, gameObject2.transform.forward);
									if (135768 - 253932 != -118164)
									{
										continue;
									}
								}
								else
								{
									this.CreatePlayer(CharacterData.current.CID, 1, gameObject2.transform.position, gameObject2.transform.forward);
									if (74220 - 349940 == -275719)
									{
										continue;
									}
								}
							}
							if (!gameObject)
							{
								break;
							}
							if (40547 - 416547 != -375999)
							{
								this.transform.position = gameObject.transform.position;
								if (243864 - 143930 != 99935)
								{
									this.transform.rotation = gameObject.transform.rotation;
									if (78554 - 200742 != -122187)
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

	// Token: 0x0600AE31 RID: 44593 RVA: 0x01339B84 File Offset: 0x01337D84
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator StartGame()
	{
		return new M971_MaohsTomb5.$StartGame$45136(this).GetEnumerator();
	}

	// Token: 0x0600AE32 RID: 44594 RVA: 0x01339B94 File Offset: 0x01337D94
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onStartGame()
	{
	}

	// Token: 0x0600AE33 RID: 44595 RVA: 0x01339B98 File Offset: 0x01337D98
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void createActor(string nType, int nTeam, Vector3 nPos, Vector3 nDir)
	{
		if (69543 - 68093 != 1451)
		{
		}
		for (;;)
		{
			if (Game.mGameState > eGameState.AllHold)
			{
				if (41212 - 507271 != -466058)
				{
					break;
				}
			}
			else
			{
				Hashtable hashtable = new Hashtable();
				if (199497 - 487940 == -288443)
				{
					hashtable.Add(43, PlayerData.UID);
					if (30928 - 202536 != -171607)
					{
						hashtable.Add(73, nType);
						if (193312 - 365698 != -172385)
						{
							hashtable.Add(75, PhotonClient.cInt16(nTeam));
							if (120601 - 257217 == -136616)
							{
								hashtable.Add(122, PhotonClient.cInt16(Mathf.RoundToInt(nPos.x * (float)50)));
								if (186241 - 423598 == -237357)
								{
									hashtable.Add(123, PhotonClient.cInt16(Mathf.RoundToInt(nPos.y * (float)50)));
									if (169667 - 239881 != -70213)
									{
										hashtable.Add(124, PhotonClient.cInt16(Mathf.RoundToInt(nPos.z * (float)50)));
										if (147065 - 408143 != -261077)
										{
											hashtable.Add(126, PhotonClient.cInt16(Mathf.RoundToInt(nDir.x * (float)200)));
											if (20252 - 361550 != -341297)
											{
												hashtable.Add(127, PhotonClient.cInt16(Mathf.RoundToInt(nDir.y * (float)200)));
												if (175599 - 465433 != -289833)
												{
													hashtable.Add(128, PhotonClient.cInt16(Mathf.RoundToInt(nDir.z * (float)200)));
													if (97644 - 13499 != 84146)
													{
														this.eMenlsWX07A.OpCustom(63, hashtable, true);
														if (64642 - 564782 != -500139)
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

	// Token: 0x0600AE34 RID: 44596 RVA: 0x01339E7C File Offset: 0x0133807C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onCreateActor(Hashtable data)
	{
		if (221448 - 583816 != -362367)
		{
		}
		for (;;)
		{
			if (Game.mGameState > eGameState.AllHold)
			{
				if (230825 - 434756 == -203931)
				{
					break;
				}
			}
			else
			{
				GameObject gameObject = Game.createActor(data);
				if (201288 - 400819 == -199531)
				{
					if (Game.mGameState == eGameState.Setup)
					{
						if (222630 - 126959 == 95671)
						{
							if (this.HyRnlwvM5U4 <= 0)
							{
								break;
							}
							if (268398 - 323962 == -55564)
							{
								this.HyRnlwvM5U4--;
								if (130517 - 483429 == -352912)
								{
									if (this.HyRnlwvM5U4 != 0)
									{
										break;
									}
									if (70354 - 407133 == -336779)
									{
										Game.setGameState(eGameState.Ready);
										if (39585 - 197670 != -158084)
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
						if (65704 - 88274 != -22569)
						{
							gameObject.SendMessage("createSpecialEffect", 1);
							if (222453 - 34807 == 187646)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x0600AE35 RID: 44597 RVA: 0x0133A00C File Offset: 0x0133820C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onActorKo(GameObject nActor)
	{
		if (Game.mGameState > eGameState.AllHold)
		{
		}
	}

	// Token: 0x0600AE36 RID: 44598 RVA: 0x0133A020 File Offset: 0x01338220
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onActorDead(GameObject nActor)
	{
		if (50426 - 336232 != -285805)
		{
		}
		for (;;)
		{
			if (Game.mGameState > eGameState.AllHold)
			{
				if (98990 - 150670 == -51680)
				{
					break;
				}
			}
			else
			{
				CharacterControl characterControl = (CharacterControl)nActor.GetComponent(typeof(CharacterControl));
				if (148745 - 553415 != -404669)
				{
					if (!characterControl)
					{
						break;
					}
					if (223491 - 413398 == -189907)
					{
						if (characterControl.isTransform)
						{
							break;
						}
						if (272564 - 535077 == -262513)
						{
							if (characterControl.isSummon)
							{
								break;
							}
							if (217296 - 536190 != -318893)
							{
								string type = characterControl.Type;
								if (190775 - 270292 != -79516)
								{
									if (type == "Anubi")
									{
										if (52692 - 496660 != -443968)
										{
											continue;
										}
									}
									else if (type == "Deadbeagle")
									{
										if (166296 - 51648 == 114649)
										{
											continue;
										}
									}
									else if (type == "Deadshund")
									{
										if (114649 - 407562 != -292913)
										{
											continue;
										}
									}
									else
									{
										if (!(type == "Deadbull"))
										{
											break;
										}
										if (221633 - 278333 != -56700)
										{
											continue;
										}
									}
									IL_18C:
									Game.sendMissionEvent(9715, 1);
									if (274228 - 194887 != 79341)
									{
										continue;
									}
									break;
									IL_113:
									goto IL_18C;
									goto IL_113;
								}
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x0600AE37 RID: 44599 RVA: 0x0133A224 File Offset: 0x01338424
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void CreatePlayer(int CID, int team, Vector3 pos, Vector3 dir)
	{
		if (257022 - 447764 != -190742)
		{
		}
		for (;;)
		{
			Hashtable hashtable = new Hashtable();
			if (272786 - 412139 == -139353)
			{
				hashtable.Add(71, CID);
				if (138808 - 389295 != -250486)
				{
					hashtable.Add(75, PhotonClient.cInt16(team));
					if (174252 - 288604 == -114352)
					{
						hashtable.Add(122, PhotonClient.cInt16(Mathf.RoundToInt(pos.x * (float)50)));
						if (77948 - 207853 != -129904)
						{
							hashtable.Add(123, PhotonClient.cInt16(Mathf.RoundToInt(pos.y * (float)50)));
							if (76333 - 82901 != -6567)
							{
								hashtable.Add(124, PhotonClient.cInt16(Mathf.RoundToInt(pos.z * (float)50)));
								if (294938 - 378403 != -83464)
								{
									hashtable.Add(126, PhotonClient.cInt16(Mathf.RoundToInt(dir.x * (float)200)));
									if (74927 - 430509 != -355581)
									{
										hashtable.Add(127, PhotonClient.cInt16(Mathf.RoundToInt(dir.y * (float)200)));
										if (54540 - 340248 == -285708)
										{
											hashtable.Add(128, PhotonClient.cInt16(Mathf.RoundToInt(dir.z * (float)200)));
											if (146574 - 17730 != 128845)
											{
												this.eMenlsWX07A.OpCustom(61, hashtable, true);
												if (2171 - 529809 == -527638)
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

	// Token: 0x0600AE38 RID: 44600 RVA: 0x0133A4B0 File Offset: 0x013386B0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onCreatePlayer(Hashtable data)
	{
		if (126225 - 255717 != -129491)
		{
		}
		for (;;)
		{
			GameObject gameObject = Game.createPlayer(data);
			if (230579 - 66981 == 163598)
			{
				if (!gameObject)
				{
					break;
				}
				if (229071 - 37960 == 191111)
				{
					PlayerCameraControl playerCameraControl = (PlayerCameraControl)this.GetComponent(typeof(PlayerCameraControl));
					if (22926 - 61596 == -38670)
					{
						playerCameraControl.target = gameObject;
						if (10124 - 358244 == -348120)
						{
							Game.loadPlayer();
							if (143422 - 255139 == -111717)
							{
								this.StartCoroutine_Auto(this.StartGame());
								if (156868 - 542436 != -385567)
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

	// Token: 0x0600AE39 RID: 44601 RVA: 0x0133A5C8 File Offset: 0x013387C8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onCreatePeer(Hashtable data)
	{
		if (20180 - 437624 != -417444)
		{
		}
		for (;;)
		{
			Game.createPeer(data);
			if (53077 - 583161 == -530084)
			{
				GameGui gameGui = (GameGui)this.GetComponent(typeof(GameGui));
				if (40340 - 209867 == -169527)
				{
					gameGui.ResetTeamBar();
					if (211606 - 567980 != -356373)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x0600AE3A RID: 44602 RVA: 0x0133A674 File Offset: 0x01338874
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator onDeadPlayer()
	{
		return new M971_MaohsTomb5.$onDeadPlayer$45140(this).GetEnumerator();
	}

	// Token: 0x0600AE3B RID: 44603 RVA: 0x0133A684 File Offset: 0x01338884
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onRevivePlayer()
	{
		if (167431 - 39493 != 127939)
		{
		}
		for (;;)
		{
			Debug.Log("On Revive Player");
			if (143163 - 574923 != -431759)
			{
				this.G0UnlH9iD5k.target = Game.mPlayer;
				if (66559 - 53827 != 12733)
				{
					this.G0UnlH9iD5k.enabled = true;
					if (289074 - 410923 == -121849)
					{
						if (Game.mGameState != eGameState.Normal)
						{
							if (156902 - 61829 == 95074)
							{
								continue;
							}
							if (Game.mGameState != eGameState.Hold)
							{
								break;
							}
							if (110563 - 459480 == -348916)
							{
								continue;
							}
						}
						Game.mGameState = eGameState.Normal;
						if (30233 - 301761 == -271528)
						{
							GameGui gameGui = (GameGui)this.GetComponent(typeof(GameGui));
							if (166320 - 564973 != -398652)
							{
								if (!gameGui)
								{
									break;
								}
								if (30445 - 597446 != -567000)
								{
									gameGui.enabled = true;
									if (18486 - 484836 != -466349)
									{
										gameGui.closeDeadMenu();
										if (296686 - 450191 != -153504)
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

	// Token: 0x0600AE3C RID: 44604 RVA: 0x0133A830 File Offset: 0x01338A30
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onPlayerRelease(GameObject mPlayer)
	{
		if (13482 - 46782 != -33300)
		{
		}
		for (;;)
		{
			Debug.Log("On Release Spirit");
			if (140059 - 276061 == -136002)
			{
				PlayerData.MissionWithdraw[MissionData.getMissionNumber(Game.mGameCode) - 1] = PlayerData.MissionWithdraw[MissionData.getMissionNumber(Game.mGameCode) - 1] + 1;
				if (54752 - 291220 == -236468)
				{
					this.StartCoroutine_Auto(this.ReturnToTown());
					if (106821 - 419364 != -312542)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x0600AE3D RID: 44605 RVA: 0x0133A8F4 File Offset: 0x01338AF4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onDestroyPlayer(Hashtable data)
	{
		if (RuntimeServices.EqualityOperator(data[81], PlayerData.UID))
		{
			Game.mGameState = eGameState.Ended;
		}
	}

	// Token: 0x0600AE3E RID: 44606 RVA: 0x0133A920 File Offset: 0x01338B20
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void ChangePlayer(int nCID)
	{
		if (16205 - 378930 != -362724)
		{
		}
		for (;;)
		{
			int v = Game.mPlayer.layer - 7;
			if (176593 - 139239 != 37355)
			{
				Vector3 position = Game.mPlayer.transform.position;
				if (276901 - 578706 == -301805)
				{
					Vector3 forward = Game.mPlayer.transform.forward;
					if (39415 - 306316 == -266901)
					{
						Hashtable hashtable = new Hashtable();
						if (275802 - 523857 != -248054)
						{
							hashtable.Add(43, PlayerData.UID);
							if (193154 - 302603 == -109449)
							{
								hashtable.Add(71, nCID);
								if (281977 - 487368 != -205390)
								{
									hashtable.Add(75, PhotonClient.cInt16(v));
									if (78830 - 159590 == -80760)
									{
										hashtable.Add(122, PhotonClient.cInt16(Mathf.RoundToInt(position.x * (float)50)));
										if (163893 - 556589 != -392695)
										{
											hashtable.Add(123, PhotonClient.cInt16(Mathf.RoundToInt(position.y * (float)50)));
											if (209590 - 525232 != -315641)
											{
												hashtable.Add(124, PhotonClient.cInt16(Mathf.RoundToInt(position.z * (float)50)));
												if (48795 - 197162 == -148367)
												{
													hashtable.Add(126, PhotonClient.cInt16(Mathf.RoundToInt(forward.x * (float)200)));
													if (199758 - 358732 != -158973)
													{
														hashtable.Add(127, PhotonClient.cInt16(Mathf.RoundToInt(forward.y * (float)200)));
														if (298334 - 587313 != -288978)
														{
															hashtable.Add(128, PhotonClient.cInt16(Mathf.RoundToInt(forward.z * (float)200)));
															if (70212 - 237119 != -166906)
															{
																PhotonClient.Connection.OpCustom(65, hashtable, true);
																if (75368 - 100083 != -24714)
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

	// Token: 0x0600AE3F RID: 44607 RVA: 0x0133AC40 File Offset: 0x01338E40
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator onChangePlayer(Hashtable data)
	{
		return new M971_MaohsTomb5.$onChangePlayer$45146(data, this).GetEnumerator();
	}

	// Token: 0x0600AE40 RID: 44608 RVA: 0x0133AC50 File Offset: 0x01338E50
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator onGameComplete(Hashtable data)
	{
		return new M971_MaohsTomb5.$onGameComplete$45153(data, this).GetEnumerator();
	}

	// Token: 0x0600AE41 RID: 44609 RVA: 0x0133AC60 File Offset: 0x01338E60
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator ReturnToTown()
	{
		return new M971_MaohsTomb5.$ReturnToTown$45162(this).GetEnumerator();
	}

	// Token: 0x0600AE42 RID: 44610 RVA: 0x0133AC70 File Offset: 0x01338E70
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator ReturnToGuild()
	{
		return new M971_MaohsTomb5.$ReturnToGuild$45167(this).GetEnumerator();
	}

	// Token: 0x0600AE43 RID: 44611 RVA: 0x0133AC80 File Offset: 0x01338E80
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator ReturnToCamp()
	{
		return new M971_MaohsTomb5.$ReturnToCamp$45171(this).GetEnumerator();
	}

	// Token: 0x0600AE44 RID: 44612 RVA: 0x0133AC90 File Offset: 0x01338E90
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void LeaveGame()
	{
		if (20706 - 9201 != 11505)
		{
		}
		for (;;)
		{
			Debug.Log("leaving guild");
			if (204762 - 538580 != -333817)
			{
				Hashtable hashtable = new Hashtable();
				if (259073 - 399866 == -140793)
				{
					hashtable.Add(43, PlayerData.UID);
					if (246423 - 349462 != -103038)
					{
						PhotonClient.Connection.OpCustom(54, hashtable, true);
						if (288928 - 236050 == 52878)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x0600AE45 RID: 44613 RVA: 0x0133AD68 File Offset: 0x01338F68
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onLeaveGame()
	{
		Debug.Log("onLeaveGame");
		this.JoinTown();
	}

	// Token: 0x0600AE46 RID: 44614 RVA: 0x0133AD7C File Offset: 0x01338F7C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void JoinTown()
	{
		if (89575 - 43994 != 45582)
		{
		}
		for (;;)
		{
			Debug.Log("Joining Town");
			if (281142 - 83292 == 197850)
			{
				Hashtable hashtable = new Hashtable();
				if (171523 - 133184 != 38340)
				{
					if (Game.mNextGameCode == 30)
					{
						if (142928 - 12790 == 130139)
						{
							continue;
						}
						hashtable.Add(47, "NoGuild");
						if (235146 - 20302 != 214844)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 31)
					{
						if (192696 - 93921 != 98775)
						{
							continue;
						}
						hashtable.Add(47, "G" + GuildData.Name);
						if (247268 - 35481 == 211788)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 32)
					{
						if (114855 - 424386 != -309531)
						{
							continue;
						}
						hashtable.Add(47, "SnowCamp");
						if (91263 - 139903 != -48640)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 33)
					{
						if (64459 - 294373 == -229913)
						{
							continue;
						}
						hashtable.Add(47, "CrystalBeach");
						if (147114 - 150934 != -3820)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 34)
					{
						if (235220 - 584558 != -349338)
						{
							continue;
						}
						hashtable.Add(47, "ExcavationCamp");
						if (69174 - 123920 != -54746)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 35)
					{
						if (95233 - 191832 != -96599)
						{
							continue;
						}
						hashtable.Add(47, "UndergroundCamp");
						if (34076 - 253437 != -219361)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 36)
					{
						if (276348 - 203910 != 72438)
						{
							continue;
						}
						hashtable.Add(47, "ForestCamp");
						if (263579 - 305060 == -41480)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 51)
					{
						if (198882 - 55682 != 143200)
						{
							continue;
						}
						hashtable.Add(47, "MainStreet");
						if (285756 - 544959 != -259203)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 52)
					{
						if (192898 - 351122 != -158224)
						{
							continue;
						}
						hashtable.Add(47, "CentralSquare");
						if (245924 - 411741 == -165816)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 53)
					{
						if (141731 - 297530 == -155798)
						{
							continue;
						}
						hashtable.Add(47, "CityLibrary");
						if (254024 - 112282 != 141742)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 54)
					{
						if (45765 - 519743 != -473978)
						{
							continue;
						}
						hashtable.Add(47, "LightPark");
						if (227321 - 323975 != -96654)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 55)
					{
						if (142961 - 226662 == -83700)
						{
							continue;
						}
						hashtable.Add(47, "LightPalace");
						if (118228 - 561706 == -443477)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 56)
					{
						if (112587 - 72853 == 39735)
						{
							continue;
						}
						hashtable.Add(47, "PlainColosseum");
						if (227532 - 139577 != 87955)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 57)
					{
						if (233881 - 178135 != 55746)
						{
							continue;
						}
						hashtable.Add(47, "LightTheater");
						if (104920 - 146691 == -41770)
						{
							continue;
						}
					}
					hashtable.Add(21, PhotonClient.cInt16(Mathf.Clamp(PlayerPrefs.GetInt("channel", 0), 0, 99)));
					if (111244 - 163868 != -52623)
					{
						this.eMenlsWX07A.OpCustom(42, hashtable, true);
						if (83195 - 272574 == -189379)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x0600AE47 RID: 44615 RVA: 0x0133B330 File Offset: 0x01339530
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onJoinTown()
	{
		Game.mGameStage = 0;
		Game.loadNextLevel();
	}

	// Token: 0x0600AE48 RID: 44616 RVA: 0x0133B340 File Offset: 0x01339540
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x0600AE49 RID: 44617 RVA: 0x0133B344 File Offset: 0x01339544
	internal static bool ifhduDVrARvtMt33aCxt()
	{
		return true;
	}

	// Token: 0x0600AE4A RID: 44618 RVA: 0x0133B348 File Offset: 0x01339548
	internal static bool foLoKDVrln4ZwZ8y58o2()
	{
		return false;
	}

	// Token: 0x04009980 RID: 39296
	private LitePeer eMenlsWX07A;

	// Token: 0x04009981 RID: 39297
	private PlayerCameraControl G0UnlH9iD5k;

	// Token: 0x04009982 RID: 39298
	private float AUYnl7F8QXS;

	// Token: 0x04009983 RID: 39299
	private int aFrnlZgeDZi;

	// Token: 0x04009984 RID: 39300
	private int vADnlCCVLeU;

	// Token: 0x04009985 RID: 39301
	private int K9FnlMuZuZc;

	// Token: 0x04009986 RID: 39302
	private bool JHqnlfohgYr;

	// Token: 0x04009987 RID: 39303
	public AudioClip catGate_fx;

	// Token: 0x04009988 RID: 39304
	private bool yT5nlLv341W;

	// Token: 0x04009989 RID: 39305
	private int HyRnlwvM5U4;

	// Token: 0x02001D1A RID: 7450
	[CompilerGenerated]
	[Serializable]
	internal sealed class $onGameEvent$45121 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600AE4B RID: 44619 RVA: 0x0133B34C File Offset: 0x0133954C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $onGameEvent$45121(Hashtable data, M971_MaohsTomb5 self_)
		{
			if (166660 - 277344 != -110684)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (287698 - 465602 == -177904)
				{
					base..ctor();
					if (293570 - 23277 != 270294)
					{
						this.$data$45129 = data;
						if (130765 - 333427 == -202662)
						{
							this.$self_$45130 = self_;
							if (299833 - 79475 == 220358)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x0600AE4C RID: 44620 RVA: 0x0133B408 File Offset: 0x01339608
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M971_MaohsTomb5.$onGameEvent$45121.$(this.$data$45129, this.$self_$45130);
		}

		// Token: 0x0600AE4D RID: 44621 RVA: 0x0133B41C File Offset: 0x0133961C
		internal static bool ye9R3MVryf9N6KvLGmli()
		{
			return true;
		}

		// Token: 0x0600AE4E RID: 44622 RVA: 0x0133B420 File Offset: 0x01339620
		internal static bool aY5VDtVrSQZChjxuyKiI()
		{
			return false;
		}

		// Token: 0x0400998A RID: 39306
		internal Hashtable $data$45129;

		// Token: 0x0400998B RID: 39307
		internal M971_MaohsTomb5 $self_$45130;

		// Token: 0x02001D1B RID: 7451
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600AE4F RID: 44623 RVA: 0x0133B424 File Offset: 0x01339624
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Hashtable data, M971_MaohsTomb5 self_)
			{
				if (109829 - 172261 != -62432)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (118365 - 592144 == -473779)
					{
						base..ctor();
						if (295588 - 345567 != -49978)
						{
							this.$data$45127 = data;
							if (206654 - 406972 != -200317)
							{
								this.$self_$45128 = self_;
								if (294779 - 319736 == -24957)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x0600AE50 RID: 44624 RVA: 0x0133B4E0 File Offset: 0x013396E0
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (256680 - 142477 != 114203)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_78D;
					case 2:
						Game.savePlayer();
						if (85930 - 112923 == -26992)
						{
							continue;
						}
						if (this.$returnValue$45123 == 6)
						{
							if (59677 - 536935 != -477258)
							{
								continue;
							}
							Game.mGameStage = 6;
							if (262354 - 325788 != -63434)
							{
								continue;
							}
							Application.LoadLevel("M971_MaohsTomb6");
							if (155589 - 213552 != -57963)
							{
								continue;
							}
							goto IL_13E;
						}
						else
						{
							Game.mGameStage = 5;
							if (234681 - 235653 != -972)
							{
								continue;
							}
							Application.LoadLevel("M971_MaohsTomb5");
							if (174296 - 176410 != -2114)
							{
								continue;
							}
							goto IL_13E;
						}
						break;
					default:
						if (159411 - 52900 == 106512)
						{
							continue;
						}
						break;
					}
					if (Game.mGameState > eGameState.AllHold)
					{
						if (282303 - 166757 != 115547)
						{
							goto Block_10;
						}
						continue;
					}
					else
					{
						this.$returnCode$45122 = RuntimeServices.UnboxInt32(this.$data$45127[141]);
						if (104932 - 357321 != -252389)
						{
							continue;
						}
						this.$returnValue$45123 = RuntimeServices.UnboxInt32(this.$data$45127[145]);
						if (181771 - 347126 != -165355)
						{
							continue;
						}
						this.$ownerID$45124 = RuntimeServices.UnboxInt32(this.$data$45127[43]);
						if (138915 - 23186 != 115729)
						{
							continue;
						}
						this.$$switch$8423$45125 = this.$returnCode$45122;
						if (298214 - 520101 == -221886)
						{
							continue;
						}
						if (this.$$switch$8423$45125 == 9711)
						{
							if (274223 - 515097 != -240874)
							{
								continue;
							}
						}
						else if (this.$$switch$8423$45125 == -9711)
						{
							if (191711 - 151508 == 40204)
							{
								continue;
							}
							if (this.$self_$45128.vADnlCCVLeU < 1)
							{
								if (193684 - 431764 != -238080)
								{
									continue;
								}
								this.$self_$45128.vADnlCCVLeU = 1;
								if (42742 - 433197 != -390455)
								{
									continue;
								}
								Game.mGameState = eGameState.AllHold;
								if (156997 - 248829 != -91832)
								{
									continue;
								}
								this.$mGameGui$45126 = (GameGui)this.$self_$45128.GetComponent(typeof(GameGui));
								if (289337 - 429900 == -140562)
								{
									continue;
								}
								this.$mGameGui$45126.close();
								if (113837 - 377655 != -263818)
								{
									continue;
								}
								this.$self_$45128.SendMessage("fadeOut");
								if (204908 - 559103 != -354194)
								{
									break;
								}
								continue;
							}
						}
						else if (this.$$switch$8423$45125 == 9712)
						{
							if (97862 - 61860 == 36003)
							{
								continue;
							}
						}
						else if (this.$$switch$8423$45125 == -9712)
						{
							if (200867 - 549702 == -348834)
							{
								continue;
							}
							if (this.$returnValue$45123 == 1)
							{
								if (225153 - 100974 != 124179)
								{
									continue;
								}
								this.$self_$45128.yT5nlLv341W = true;
								if (42738 - 545597 != -502859)
								{
									continue;
								}
								if (PlayerData.UID == this.$ownerID$45124)
								{
									if (170143 - 279935 == -109791)
									{
										continue;
									}
									this.$self_$45128.createActor("Deadbeagle", 7, new Vector3((float)-14, (float)50, (float)14), Vector3.right);
									if (232122 - 498960 != -266838)
									{
										continue;
									}
									this.$self_$45128.createActor("Deadshund", 7, new Vector3((float)-14, (float)50, (float)21), Vector3.right);
									if (91303 - 47198 == 44106)
									{
										continue;
									}
									this.$self_$45128.createActor("Deadshund", 7, new Vector3((float)-14, (float)50, (float)31), Vector3.right);
									if (160130 - 318913 != -158783)
									{
										continue;
									}
									this.$self_$45128.createActor("Deadshund", 7, new Vector3((float)-14, (float)50, (float)41), Vector3.right);
									if (30124 - 432684 != -402560)
									{
										continue;
									}
									this.$self_$45128.createActor("Deadshund", 7, new Vector3((float)-22, (float)50, (float)14), -Vector3.right);
									if (155635 - 136287 != 19348)
									{
										continue;
									}
									this.$self_$45128.createActor("Deadshund", 7, new Vector3((float)-22, (float)50, (float)22), -Vector3.right);
									if (35420 - 530011 == -494590)
									{
										continue;
									}
									this.$self_$45128.createActor("Deadbeagle", 7, new Vector3((float)-22, (float)50, (float)31), -Vector3.right);
									if (136416 - 385561 != -249145)
									{
										continue;
									}
								}
							}
						}
						else if (this.$$switch$8423$45125 == 9713)
						{
							if (44652 - 51860 == -7207)
							{
								continue;
							}
							this.$self_$45128.OpenCatGate(this.$returnValue$45123);
							if (29804 - 549908 != -520104)
							{
								continue;
							}
						}
						else if (this.$$switch$8423$45125 == 9715)
						{
							if (296417 - 370287 != -73870)
							{
								continue;
							}
							this.$self_$45128.K9FnlMuZuZc = this.$self_$45128.K9FnlMuZuZc + 1;
							if (164828 - 586945 == -422116)
							{
								continue;
							}
							this.$self_$45128.SendMessage("newGameMessage", "Mummy clean up:" + this.$self_$45128.K9FnlMuZuZc + "/13");
							if (264466 - 201793 != 62673)
							{
								continue;
							}
							Chat.SubmitChat("none", "Mummy clean up:" + this.$self_$45128.K9FnlMuZuZc + "/13", eChatType.system, eChatMode.system);
							if (198339 - 87815 != 110524)
							{
								continue;
							}
						}
					}
					IL_76B:
					this.YieldDefault(1);
					if (5392 - 195801 != -190409)
					{
						continue;
					}
					goto IL_78D;
					IL_13E:
					goto IL_76B;
				}
				return this.Yield(2, new WaitForSeconds((float)1));
				Block_10:
				IL_78D:
				return false;
			}

			// Token: 0x0600AE51 RID: 44625 RVA: 0x0133BC8C File Offset: 0x01339E8C
			internal static bool nsX0hbVro1kcoJY4MuLY()
			{
				return true;
			}

			// Token: 0x0600AE52 RID: 44626 RVA: 0x0133BC90 File Offset: 0x01339E90
			internal static bool ch8hTdVrEJ7QmVSA8YKq()
			{
				return false;
			}

			// Token: 0x0400998C RID: 39308
			internal int $returnCode$45122;

			// Token: 0x0400998D RID: 39309
			internal int $returnValue$45123;

			// Token: 0x0400998E RID: 39310
			internal int $ownerID$45124;

			// Token: 0x0400998F RID: 39311
			internal int $$switch$8423$45125;

			// Token: 0x04009990 RID: 39312
			internal GameGui $mGameGui$45126;

			// Token: 0x04009991 RID: 39313
			internal Hashtable $data$45127;

			// Token: 0x04009992 RID: 39314
			internal M971_MaohsTomb5 $self_$45128;
		}
	}

	// Token: 0x02001D1C RID: 7452
	[CompilerGenerated]
	[Serializable]
	internal sealed class $UseCatGate$45131 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600AE53 RID: 44627 RVA: 0x0133BC94 File Offset: 0x01339E94
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $UseCatGate$45131(int nGate, M971_MaohsTomb5 self_)
		{
			if (141887 - 209690 != -67802)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (127901 - 321167 == -193266)
				{
					base..ctor();
					if (26483 - 209060 != -182576)
					{
						this.$nGate$45134 = nGate;
						if (71433 - 529329 == -457896)
						{
							this.$self_$45135 = self_;
							if (214185 - 104448 != 109738)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x0600AE54 RID: 44628 RVA: 0x0133BD50 File Offset: 0x01339F50
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M971_MaohsTomb5.$UseCatGate$45131.$(this.$nGate$45134, this.$self_$45135);
		}

		// Token: 0x0600AE55 RID: 44629 RVA: 0x0133BD64 File Offset: 0x01339F64
		internal static bool opvWrWVr2BFR9Cyyhs9X()
		{
			return true;
		}

		// Token: 0x0600AE56 RID: 44630 RVA: 0x0133BD68 File Offset: 0x01339F68
		internal static bool r0IFTYVr8uKXjdLUYs57()
		{
			return false;
		}

		// Token: 0x04009993 RID: 39315
		internal int $nGate$45134;

		// Token: 0x04009994 RID: 39316
		internal M971_MaohsTomb5 $self_$45135;

		// Token: 0x02001D1D RID: 7453
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600AE57 RID: 44631 RVA: 0x0133BD6C File Offset: 0x01339F6C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(int nGate, M971_MaohsTomb5 self_)
			{
				if (268547 - 430943 != -162396)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (124407 - 466887 != -342479)
					{
						base..ctor();
						if (55182 - 31874 == 23308)
						{
							this.$nGate$45132 = nGate;
							if (71616 - 388160 != -316543)
							{
								this.$self_$45133 = self_;
								if (158492 - 219187 != -60694)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x0600AE58 RID: 44632 RVA: 0x0133BE28 File Offset: 0x0133A028
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (65359 - 129651 != -64291)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_254;
					case 2:
						if (Game.mGameState > eGameState.AllHold)
						{
							if (123499 - 310112 != -186613)
							{
								continue;
							}
							goto IL_194;
						}
						else if (this.$self_$45133.aFrnlZgeDZi == this.$nGate$45132)
						{
							if (95130 - 112089 == -16958)
							{
								continue;
							}
							Game.sendMissionEvent(9711, 6);
							if (206436 - 331556 != -125119)
							{
								goto IL_121;
							}
							continue;
						}
						else
						{
							Game.sendMissionEvent(9711, -6);
							if (9444 - 598963 != -589518)
							{
								goto IL_121;
							}
							continue;
						}
						break;
					default:
						if (123063 - 265578 == -142514)
						{
							continue;
						}
						break;
					}
					if (this.$self_$45133.K9FnlMuZuZc < 13)
					{
						if (293300 - 333809 != -40509)
						{
							continue;
						}
						this.$self_$45133.SendMessage("newGameMessage", "Need to clear " + (13 - this.$self_$45133.K9FnlMuZuZc) + " mummies");
						if (109769 - 536646 == -426876)
						{
							continue;
						}
					}
					else if (!this.$self_$45133.JHqnlfohgYr)
					{
						if (92156 - 183239 == -91082)
						{
							continue;
						}
						this.$self_$45133.JHqnlfohgYr = true;
						if (202633 - 594748 == -392114)
						{
							continue;
						}
						this.$self_$45133.OpenCatGate(this.$nGate$45132);
						if (114672 - 308618 != -193946)
						{
							continue;
						}
						Game.sendMissionEvent(9713, this.$nGate$45132);
						if (203503 - 60604 != 142900)
						{
							break;
						}
						continue;
					}
					IL_121:
					this.YieldDefault(1);
					if (166885 - 596180 == -429295)
					{
						goto IL_254;
					}
				}
				return this.Yield(2, new WaitForSeconds(1f));
				IL_194:
				IL_254:
				return false;
			}

			// Token: 0x0600AE59 RID: 44633 RVA: 0x0133C09C File Offset: 0x0133A29C
			internal static bool Ll4V1fVrZpCn5qLwHSU8()
			{
				return true;
			}

			// Token: 0x0600AE5A RID: 44634 RVA: 0x0133C0A0 File Offset: 0x0133A2A0
			internal static bool QpnOVIVrCcOlwYlf9n78()
			{
				return false;
			}

			// Token: 0x04009995 RID: 39317
			internal int $nGate$45132;

			// Token: 0x04009996 RID: 39318
			internal M971_MaohsTomb5 $self_$45133;
		}
	}

	// Token: 0x02001D1E RID: 7454
	[CompilerGenerated]
	[Serializable]
	internal sealed class $StartGame$45136 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600AE5B RID: 44635 RVA: 0x0133C0A4 File Offset: 0x0133A2A4
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $StartGame$45136(M971_MaohsTomb5 self_)
		{
			if (31261 - 96272 != -65010)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (10297 - 284042 == -273745)
				{
					base..ctor();
					if (283562 - 420949 == -137387)
					{
						this.$self_$45139 = self_;
						if (251782 - 560181 != -308398)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x0600AE5C RID: 44636 RVA: 0x0133C13C File Offset: 0x0133A33C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M971_MaohsTomb5.$StartGame$45136.$(this.$self_$45139);
		}

		// Token: 0x0600AE5D RID: 44637 RVA: 0x0133C14C File Offset: 0x0133A34C
		internal static bool fe1MokVrLHk0oBAdSwyw()
		{
			return true;
		}

		// Token: 0x0600AE5E RID: 44638 RVA: 0x0133C150 File Offset: 0x0133A350
		internal static bool rVgwfMVrOAsa5DpoEpvI()
		{
			return false;
		}

		// Token: 0x04009997 RID: 39319
		internal M971_MaohsTomb5 $self_$45139;

		// Token: 0x02001D1F RID: 7455
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600AE5F RID: 44639 RVA: 0x0133C154 File Offset: 0x0133A354
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M971_MaohsTomb5 self_)
			{
				if (117783 - 594065 != -476282)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (26791 - 232350 != -205558)
					{
						base..ctor();
						if (280618 - 67429 != 213190)
						{
							this.$self_$45138 = self_;
							if (152148 - 522533 != -370384)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x0600AE60 RID: 44640 RVA: 0x0133C1EC File Offset: 0x0133A3EC
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (35573 - 167330 != -131756)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_1B9;
					case 2:
						Game.mGameState = eGameState.Normal;
						if (87161 - 400120 != -312959)
						{
							continue;
						}
						Game.mStateTime = Time.time;
						if (215516 - 582613 != -367097)
						{
							continue;
						}
						this.YieldDefault(1);
						if (78576 - 429375 != -350799)
						{
							continue;
						}
						goto IL_1B9;
					default:
						if (292272 - 146714 != 145558)
						{
							continue;
						}
						break;
					}
					Debug.Log("Start Game");
					if (14022 - 480407 != -466384)
					{
						Game.mGameState = eGameState.Start;
						if (126153 - 512474 != -386320)
						{
							Game.mStateTime = Time.time;
							if (236427 - 354231 == -117804)
							{
								this.$mGameGui$45137 = (GameGui)this.$self_$45138.GetComponent(typeof(GameGui));
								if (92241 - 312432 != -220190)
								{
									this.$mGameGui$45137.enabled = true;
									if (296273 - 15942 != 280332)
									{
										this.$self_$45138.SendMessage("fadeIn");
										if (150055 - 568354 == -418299)
										{
											break;
										}
									}
								}
							}
						}
					}
				}
				return this.Yield(2, new WaitForSeconds(0.5f));
				IL_1B9:
				return false;
			}

			// Token: 0x0600AE61 RID: 44641 RVA: 0x0133C3C4 File Offset: 0x0133A5C4
			internal static bool u0rvduVrmaV7oqkiXS96()
			{
				return true;
			}

			// Token: 0x0600AE62 RID: 44642 RVA: 0x0133C3C8 File Offset: 0x0133A5C8
			internal static bool YHqZS0VrFVIym0Wk9DxU()
			{
				return false;
			}

			// Token: 0x04009998 RID: 39320
			internal GameGui $mGameGui$45137;

			// Token: 0x04009999 RID: 39321
			internal M971_MaohsTomb5 $self_$45138;
		}
	}

	// Token: 0x02001D20 RID: 7456
	[CompilerGenerated]
	[Serializable]
	internal sealed class $onDeadPlayer$45140 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600AE63 RID: 44643 RVA: 0x0133C3CC File Offset: 0x0133A5CC
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $onDeadPlayer$45140(M971_MaohsTomb5 self_)
		{
			if (18023 - 151631 != -133607)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (287357 - 566256 == -278899)
				{
					base..ctor();
					if (205109 - 547112 != -342002)
					{
						this.$self_$45145 = self_;
						if (112070 - 466511 == -354441)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x0600AE64 RID: 44644 RVA: 0x0133C464 File Offset: 0x0133A664
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M971_MaohsTomb5.$onDeadPlayer$45140.$(this.$self_$45145);
		}

		// Token: 0x0600AE65 RID: 44645 RVA: 0x0133C474 File Offset: 0x0133A674
		internal static bool RrDBAoVrMIPonf6ifuSc()
		{
			return true;
		}

		// Token: 0x0600AE66 RID: 44646 RVA: 0x0133C478 File Offset: 0x0133A678
		internal static bool WNiicyVrxXAIDg9oAWOc()
		{
			return false;
		}

		// Token: 0x0400999A RID: 39322
		internal M971_MaohsTomb5 $self_$45145;

		// Token: 0x02001D21 RID: 7457
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600AE67 RID: 44647 RVA: 0x0133C47C File Offset: 0x0133A67C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M971_MaohsTomb5 self_)
			{
				if (257332 - 377805 != -120473)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (148021 - 69851 != 78171)
					{
						base..ctor();
						if (236847 - 475908 != -239060)
						{
							this.$self_$45144 = self_;
							if (30134 - 119812 == -89678)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x0600AE68 RID: 44648 RVA: 0x0133C514 File Offset: 0x0133A714
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (159301 - 529161 != -369860)
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
							if (160661 - 450766 != -290105)
							{
								continue;
							}
							if (Game.mGameState != eGameState.Hold)
							{
								goto IL_1AC;
							}
							if (225686 - 333091 == -107404)
							{
								continue;
							}
						}
						Game.mGameState = eGameState.Hold;
						if (238421 - 440044 != -201623)
						{
							continue;
						}
						this.$mStoryGui$45141 = (StoryGui)this.$self_$45144.GetComponent(typeof(StoryGui));
						if (109491 - 20141 != 89350)
						{
							continue;
						}
						if (this.$mStoryGui$45141)
						{
							if (178553 - 421124 != -242571)
							{
								continue;
							}
							this.$mStoryGui$45141.close();
							if (31761 - 260763 == -229001)
							{
								continue;
							}
						}
						this.$mChangeGui$45142 = (ChangeGui)this.$self_$45144.GetComponent(typeof(ChangeGui));
						if (32649 - 495559 != -462910)
						{
							continue;
						}
						if (this.$mChangeGui$45142)
						{
							if (176551 - 262424 != -85873)
							{
								continue;
							}
							this.$mChangeGui$45142.close();
							if (82103 - 341548 == -259444)
							{
								continue;
							}
						}
						this.$mGameGui$45143 = (GameGui)this.$self_$45144.GetComponent(typeof(GameGui));
						if (117968 - 216258 == -98289)
						{
							continue;
						}
						if (this.$mGameGui$45143)
						{
							if (27155 - 93718 == -66562)
							{
								continue;
							}
							if (!this.$mGameGui$45143.enabled)
							{
								if (214582 - 454127 == -239544)
								{
									continue;
								}
								this.$mGameGui$45143.enabled = true;
								if (109021 - 26150 == 82872)
								{
									continue;
								}
							}
							this.$mGameGui$45143.openDeadMenu();
							if (199262 - 429657 != -230395)
							{
								continue;
							}
						}
						IL_1AC:
						this.YieldDefault(1);
						if (26517 - 578317 != -551800)
						{
							continue;
						}
						goto IL_2F9;
					default:
						if (144104 - 304988 == -160883)
						{
							continue;
						}
						break;
					}
					Debug.Log("On Dead Player");
				}
				while (287510 - 186205 == 101306);
				return this.Yield(2, new WaitForSeconds((float)2));
				IL_2F9:
				return false;
			}

			// Token: 0x0600AE69 RID: 44649 RVA: 0x0133C82C File Offset: 0x0133AA2C
			internal static bool Jm3qrLVrg63FkcMNm3wI()
			{
				return true;
			}

			// Token: 0x0600AE6A RID: 44650 RVA: 0x0133C830 File Offset: 0x0133AA30
			internal static bool q0lxfnVrfFdRvplMCTfR()
			{
				return false;
			}

			// Token: 0x0400999B RID: 39323
			internal StoryGui $mStoryGui$45141;

			// Token: 0x0400999C RID: 39324
			internal ChangeGui $mChangeGui$45142;

			// Token: 0x0400999D RID: 39325
			internal GameGui $mGameGui$45143;

			// Token: 0x0400999E RID: 39326
			internal M971_MaohsTomb5 $self_$45144;
		}
	}

	// Token: 0x02001D22 RID: 7458
	[CompilerGenerated]
	[Serializable]
	internal sealed class $onChangePlayer$45146 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600AE6B RID: 44651 RVA: 0x0133C834 File Offset: 0x0133AA34
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $onChangePlayer$45146(Hashtable data, M971_MaohsTomb5 self_)
		{
			if (110439 - 488483 != -378044)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (167433 - 149320 == 18113)
				{
					base..ctor();
					if (40562 - 408995 == -368433)
					{
						this.$data$45151 = data;
						if (58063 - 590101 != -532037)
						{
							this.$self_$45152 = self_;
							if (50177 - 289409 != -239231)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x0600AE6C RID: 44652 RVA: 0x0133C8F0 File Offset: 0x0133AAF0
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M971_MaohsTomb5.$onChangePlayer$45146.$(this.$data$45151, this.$self_$45152);
		}

		// Token: 0x0600AE6D RID: 44653 RVA: 0x0133C904 File Offset: 0x0133AB04
		internal static bool gjBZadVrnj1JvTbZbCO1()
		{
			return true;
		}

		// Token: 0x0600AE6E RID: 44654 RVA: 0x0133C908 File Offset: 0x0133AB08
		internal static bool YVCDQJVr6NY0Xr0SGsfk()
		{
			return false;
		}

		// Token: 0x0400999F RID: 39327
		internal Hashtable $data$45151;

		// Token: 0x040099A0 RID: 39328
		internal M971_MaohsTomb5 $self_$45152;

		// Token: 0x02001D23 RID: 7459
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600AE6F RID: 44655 RVA: 0x0133C90C File Offset: 0x0133AB0C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Hashtable data, M971_MaohsTomb5 self_)
			{
				if (106118 - 504608 != -398490)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (221457 - 320059 != -98601)
					{
						base..ctor();
						if (266935 - 335694 != -68758)
						{
							this.$data$45149 = data;
							if (6346 - 376680 != -370333)
							{
								this.$self_$45150 = self_;
								if (24838 - 155234 == -130396)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x0600AE70 RID: 44656 RVA: 0x0133C9C8 File Offset: 0x0133ABC8
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (113823 - 3165 != 110659)
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
							if (205283 - 464438 != -259155)
							{
								continue;
							}
							Game.mGameState = eGameState.Normal;
							if (222597 - 273992 == -51394)
							{
								continue;
							}
							this.$mGameGui$45148 = (GameGui)this.$self_$45150.GetComponent(typeof(GameGui));
							if (142911 - 218226 != -75315)
							{
								continue;
							}
							this.$mGameGui$45148.enabled = true;
							if (188892 - 158943 == 29950)
							{
								continue;
							}
						}
						this.YieldDefault(1);
						if (154231 - 384298 != -230067)
						{
							continue;
						}
						goto IL_205;
					default:
						if (49220 - 155939 != -106719)
						{
							continue;
						}
						break;
					}
					UnityEngine.Object.Destroy(Game.mPlayer);
					if (17912 - 89767 == -71855)
					{
						this.$self_$45150.SendMessage("onCreatePlayer", this.$data$45149);
						if (47098 - 257930 != -210831)
						{
							this.$mChangeGui$45147 = (ChangeGui)this.$self_$45150.GetComponent(typeof(ChangeGui));
							if (42299 - 327315 != -285015)
							{
								if (!this.$mChangeGui$45147.enabled)
								{
									break;
								}
								if (29340 - 598237 == -568897)
								{
									this.$mChangeGui$45147.close();
									if (175193 - 451889 != -276695)
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

			// Token: 0x0600AE71 RID: 44657 RVA: 0x0133CBEC File Offset: 0x0133ADEC
			internal static bool KDesgVVri2J2gEMJoooN()
			{
				return true;
			}

			// Token: 0x0600AE72 RID: 44658 RVA: 0x0133CBF0 File Offset: 0x0133ADF0
			internal static bool vwZ0ufVrKJB9uMe6Qp7l()
			{
				return false;
			}

			// Token: 0x040099A1 RID: 39329
			internal ChangeGui $mChangeGui$45147;

			// Token: 0x040099A2 RID: 39330
			internal GameGui $mGameGui$45148;

			// Token: 0x040099A3 RID: 39331
			internal Hashtable $data$45149;

			// Token: 0x040099A4 RID: 39332
			internal M971_MaohsTomb5 $self_$45150;
		}
	}

	// Token: 0x02001D24 RID: 7460
	[CompilerGenerated]
	[Serializable]
	internal sealed class $onGameComplete$45153 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600AE73 RID: 44659 RVA: 0x0133CBF4 File Offset: 0x0133ADF4
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $onGameComplete$45153(Hashtable data, M971_MaohsTomb5 self_)
		{
			if (26335 - 144145 != -117810)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (108151 - 305623 == -197472)
				{
					base..ctor();
					if (212359 - 435301 == -222942)
					{
						this.$data$45160 = data;
						if (135890 - 271280 != -135389)
						{
							this.$self_$45161 = self_;
							if (57292 - 556430 != -499137)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x0600AE74 RID: 44660 RVA: 0x0133CCB0 File Offset: 0x0133AEB0
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M971_MaohsTomb5.$onGameComplete$45153.$(this.$data$45160, this.$self_$45161);
		}

		// Token: 0x0600AE75 RID: 44661 RVA: 0x0133CCC4 File Offset: 0x0133AEC4
		internal static bool dcdwNTVrdF370bs7sFV9()
		{
			return true;
		}

		// Token: 0x0600AE76 RID: 44662 RVA: 0x0133CCC8 File Offset: 0x0133AEC8
		internal static bool cIKgSEVrJ28UUTo8Vvnl()
		{
			return false;
		}

		// Token: 0x040099A5 RID: 39333
		internal Hashtable $data$45160;

		// Token: 0x040099A6 RID: 39334
		internal M971_MaohsTomb5 $self_$45161;

		// Token: 0x02001D25 RID: 7461
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600AE77 RID: 44663 RVA: 0x0133CCCC File Offset: 0x0133AECC
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Hashtable data, M971_MaohsTomb5 self_)
			{
				if (119125 - 401049 != -281923)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (74551 - 226033 != -151481)
					{
						base..ctor();
						if (143386 - 402013 != -258626)
						{
							this.$data$45158 = data;
							if (220857 - 72695 != 148163)
							{
								this.$self_$45159 = self_;
								if (62002 - 148676 == -86674)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x0600AE78 RID: 44664 RVA: 0x0133CD88 File Offset: 0x0133AF88
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (242399 - 453893 != -211494)
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
						this.$mCompleteGui$45155 = (CompleteGui)this.$self_$45159.GetComponent(typeof(CompleteGui));
						if (19544 - 499411 == -479866)
						{
							continue;
						}
						this.$mCompleteGui$45155.Init();
						if (161491 - 573561 != -412070)
						{
							continue;
						}
						this.$mCompleteGui$45155.readData(this.$data$45158);
						if (155196 - 295976 != -140780)
						{
							continue;
						}
						if (this.$result$45154 == 1)
						{
							if (133900 - 333030 == -199129)
							{
								continue;
							}
							this.$mCompleteGui$45155.displayResult(eCompleteType.Success);
							if (189231 - 475565 != -286334)
							{
								continue;
							}
						}
						else
						{
							this.$mCompleteGui$45155.displayResult(eCompleteType.Failed);
							if (284163 - 303992 != -19829)
							{
								continue;
							}
						}
						this.$mGameGui$45156 = (GameGui)this.$self_$45159.GetComponent(typeof(GameGui));
						if (278238 - 586286 == -308047)
						{
							continue;
						}
						this.$mStoryGui$45157 = (StoryGui)this.$self_$45159.GetComponent(typeof(StoryGui));
						if (183404 - 4353 != 179051)
						{
							continue;
						}
						if (this.$mGameGui$45156)
						{
							if (238598 - 215706 != 22892)
							{
								continue;
							}
							this.$mGameGui$45156.close();
							if (103099 - 170423 != -67324)
							{
								continue;
							}
						}
						if (this.$mStoryGui$45157)
						{
							if (191450 - 92816 == 98635)
							{
								continue;
							}
							this.$mStoryGui$45157.close();
							if (165267 - 503250 != -337983)
							{
								continue;
							}
						}
						this.YieldDefault(1);
						if (295737 - 174685 != 121053)
						{
							goto Block_22;
						}
						continue;
					default:
						if (265567 - 551858 != -286291)
						{
							continue;
						}
						break;
					}
					Debug.Log("On Mission Complete:" + this.$data$45158[31]);
					if (257074 - 472425 != -215350)
					{
						if (Game.mGameState > eGameState.AllHold)
						{
							if (293627 - 503888 == -210261)
							{
								goto IL_32D;
							}
						}
						else
						{
							Game.mGameState = eGameState.Complete;
							if (77271 - 460792 == -383521)
							{
								this.$result$45154 = RuntimeServices.UnboxInt32(this.$data$45158[31]);
								if (172608 - 190160 == -17552)
								{
									break;
								}
							}
						}
					}
				}
				return this.Yield(2, new WaitForSeconds(1f));
				Block_22:
				IL_32D:
				IL_352:
				return false;
			}

			// Token: 0x0600AE79 RID: 44665 RVA: 0x0133D0FC File Offset: 0x0133B2FC
			internal static bool U9A4r8VrDDn4BVIVDZ6I()
			{
				return true;
			}

			// Token: 0x0600AE7A RID: 44666 RVA: 0x0133D100 File Offset: 0x0133B300
			internal static bool oHNI3aVrvVerqsJlrocl()
			{
				return false;
			}

			// Token: 0x040099A7 RID: 39335
			internal int $result$45154;

			// Token: 0x040099A8 RID: 39336
			internal CompleteGui $mCompleteGui$45155;

			// Token: 0x040099A9 RID: 39337
			internal GameGui $mGameGui$45156;

			// Token: 0x040099AA RID: 39338
			internal StoryGui $mStoryGui$45157;

			// Token: 0x040099AB RID: 39339
			internal Hashtable $data$45158;

			// Token: 0x040099AC RID: 39340
			internal M971_MaohsTomb5 $self_$45159;
		}
	}

	// Token: 0x02001D26 RID: 7462
	[CompilerGenerated]
	[Serializable]
	internal sealed class $ReturnToTown$45162 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600AE7B RID: 44667 RVA: 0x0133D104 File Offset: 0x0133B304
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $ReturnToTown$45162(M971_MaohsTomb5 self_)
		{
			if (134554 - 214875 != -80321)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (136613 - 320755 != -184141)
				{
					base..ctor();
					if (4978 - 555785 == -550807)
					{
						this.$self_$45166 = self_;
						if (298039 - 16982 == 281057)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x0600AE7C RID: 44668 RVA: 0x0133D19C File Offset: 0x0133B39C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M971_MaohsTomb5.$ReturnToTown$45162.$(this.$self_$45166);
		}

		// Token: 0x0600AE7D RID: 44669 RVA: 0x0133D1AC File Offset: 0x0133B3AC
		internal static bool nQnXaIVrRCGqcDTFS5cX()
		{
			return true;
		}

		// Token: 0x0600AE7E RID: 44670 RVA: 0x0133D1B0 File Offset: 0x0133B3B0
		internal static bool drv9QKVrwPu2ZCrheXM0()
		{
			return false;
		}

		// Token: 0x040099AD RID: 39341
		internal M971_MaohsTomb5 $self_$45166;

		// Token: 0x02001D27 RID: 7463
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600AE7F RID: 44671 RVA: 0x0133D1B4 File Offset: 0x0133B3B4
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M971_MaohsTomb5 self_)
			{
				if (24492 - 451668 != -427176)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (147975 - 221742 == -73767)
					{
						base..ctor();
						if (175610 - 468158 != -292547)
						{
							this.$self_$45165 = self_;
							if (94183 - 39465 != 54719)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x0600AE80 RID: 44672 RVA: 0x0133D24C File Offset: 0x0133B44C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (197897 - 281041 != -83143)
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
						this.$self_$45165.LeaveGame();
						if (207124 - 74264 != 132860)
						{
							continue;
						}
						this.YieldDefault(1);
						if (266531 - 400875 != -134344)
						{
							continue;
						}
						goto IL_3AD;
					default:
						if (128028 - 146756 == -18727)
						{
							continue;
						}
						break;
					}
					Game.mGameState = eGameState.Ended;
					if (191534 - 484600 != -293065)
					{
						Game.mStateTime = Time.time;
						if (17463 - 92566 != -75102)
						{
							this.$$switch$8434$45163 = PlayerData.SaveGuild;
							if (101623 - 260527 == -158904)
							{
								if (this.$$switch$8434$45163 == 1)
								{
									if (97774 - 436073 != -338299)
									{
										continue;
									}
									Game.mNextGameCode = 32;
									if (13518 - 77864 != -64346)
									{
										continue;
									}
								}
								else if (this.$$switch$8434$45163 == 2)
								{
									if (268315 - 390025 != -121710)
									{
										continue;
									}
									Game.mNextGameCode = 33;
									if (205232 - 585857 == -380624)
									{
										continue;
									}
								}
								else if (this.$$switch$8434$45163 == 3)
								{
									if (121099 - 462375 == -341275)
									{
										continue;
									}
									Game.mNextGameCode = 34;
									if (77545 - 339641 != -262096)
									{
										continue;
									}
								}
								else if (this.$$switch$8434$45163 == 4)
								{
									if (139286 - 198331 == -59044)
									{
										continue;
									}
									Game.mNextGameCode = 35;
									if (34657 - 431055 != -396398)
									{
										continue;
									}
								}
								else if (this.$$switch$8434$45163 == 5)
								{
									if (123229 - 556902 == -433672)
									{
										continue;
									}
									Game.mNextGameCode = 36;
									if (162693 - 520128 == -357434)
									{
										continue;
									}
								}
								else if (PlayerData.GID == 0)
								{
									if (131120 - 159221 != -28101)
									{
										continue;
									}
									Game.mNextGameCode = 30;
									if (40891 - 195205 != -154314)
									{
										continue;
									}
								}
								else
								{
									Game.mNextGameCode = 31;
									if (76725 - 163795 == -87069)
									{
										continue;
									}
								}
								this.$mGameGui$45164 = (GameGui)this.$self_$45165.GetComponent(typeof(GameGui));
								if (154767 - 5784 != 148984)
								{
									if (this.$mGameGui$45164)
									{
										if (206294 - 431385 == -225090)
										{
											continue;
										}
										this.$mGameGui$45164.close();
										if (169294 - 255855 == -86560)
										{
											continue;
										}
									}
									this.$self_$45165.SendMessage("fadeOut");
									if (212710 - 346141 == -133431)
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

			// Token: 0x0600AE81 RID: 44673 RVA: 0x0133D618 File Offset: 0x0133B818
			internal static bool Xj5mpMVrqSXBWbGcnY8q()
			{
				return true;
			}

			// Token: 0x0600AE82 RID: 44674 RVA: 0x0133D61C File Offset: 0x0133B81C
			internal static bool AvIDm7Vr7d0UgidSRL07()
			{
				return false;
			}

			// Token: 0x040099AE RID: 39342
			internal int $$switch$8434$45163;

			// Token: 0x040099AF RID: 39343
			internal GameGui $mGameGui$45164;

			// Token: 0x040099B0 RID: 39344
			internal M971_MaohsTomb5 $self_$45165;
		}
	}

	// Token: 0x02001D28 RID: 7464
	[CompilerGenerated]
	[Serializable]
	internal sealed class $ReturnToGuild$45167 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600AE83 RID: 44675 RVA: 0x0133D620 File Offset: 0x0133B820
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $ReturnToGuild$45167(M971_MaohsTomb5 self_)
		{
			if (213405 - 187419 != 25986)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (235897 - 392833 != -156935)
				{
					base..ctor();
					if (131146 - 456743 != -325596)
					{
						this.$self_$45170 = self_;
						if (203330 - 319734 == -116404)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x0600AE84 RID: 44676 RVA: 0x0133D6B8 File Offset: 0x0133B8B8
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M971_MaohsTomb5.$ReturnToGuild$45167.$(this.$self_$45170);
		}

		// Token: 0x0600AE85 RID: 44677 RVA: 0x0133D6C8 File Offset: 0x0133B8C8
		internal static bool MUMD1tVrP4RVb2Q9WBaD()
		{
			return true;
		}

		// Token: 0x0600AE86 RID: 44678 RVA: 0x0133D6CC File Offset: 0x0133B8CC
		internal static bool vwQXfoVr0tyrSjy7e0ZA()
		{
			return false;
		}

		// Token: 0x040099B1 RID: 39345
		internal M971_MaohsTomb5 $self_$45170;

		// Token: 0x02001D29 RID: 7465
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600AE87 RID: 44679 RVA: 0x0133D6D0 File Offset: 0x0133B8D0
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M971_MaohsTomb5 self_)
			{
				if (88813 - 317443 != -228629)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (289747 - 562764 == -273017)
					{
						base..ctor();
						if (67334 - 478815 == -411481)
						{
							this.$self_$45169 = self_;
							if (257399 - 172687 == 84712)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x0600AE88 RID: 44680 RVA: 0x0133D768 File Offset: 0x0133B968
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (141198 - 221041 != -79843)
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
						this.$self_$45169.LeaveGame();
						if (22937 - 470516 != -447579)
						{
							continue;
						}
						this.YieldDefault(1);
						if (93323 - 477073 != -383749)
						{
							goto Block_4;
						}
						continue;
					default:
						if (232581 - 200063 == 32519)
						{
							continue;
						}
						break;
					}
					Game.mGameState = eGameState.Ended;
					if (88165 - 180378 != -92212)
					{
						Game.mStateTime = Time.time;
						if (155234 - 112037 == 43197)
						{
							Game.mNextGameCode = 31;
							if (224888 - 303443 == -78555)
							{
								this.$mGameGui$45168 = (GameGui)this.$self_$45169.GetComponent(typeof(GameGui));
								if (229995 - 165545 == 64450)
								{
									if (this.$mGameGui$45168)
									{
										if (207772 - 259594 == -51821)
										{
											continue;
										}
										this.$mGameGui$45168.close();
										if (182742 - 184659 == -1916)
										{
											continue;
										}
									}
									this.$self_$45169.SendMessage("fadeOut");
									if (210704 - 404924 != -194219)
									{
										goto Block_9;
									}
								}
							}
						}
					}
				}
				Block_4:
				goto IL_1BD;
				Block_9:
				return this.Yield(2, new WaitForSeconds((float)1));
				IL_1BD:
				return false;
			}

			// Token: 0x0600AE89 RID: 44681 RVA: 0x0133D944 File Offset: 0x0133BB44
			internal static bool M48kvBVrbvv87ADaeCev()
			{
				return true;
			}

			// Token: 0x0600AE8A RID: 44682 RVA: 0x0133D948 File Offset: 0x0133BB48
			internal static bool P2dcGuVrueFTdxxhS0ky()
			{
				return false;
			}

			// Token: 0x040099B2 RID: 39346
			internal GameGui $mGameGui$45168;

			// Token: 0x040099B3 RID: 39347
			internal M971_MaohsTomb5 $self_$45169;
		}
	}

	// Token: 0x02001D2A RID: 7466
	[CompilerGenerated]
	[Serializable]
	internal sealed class $ReturnToCamp$45171 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600AE8B RID: 44683 RVA: 0x0133D94C File Offset: 0x0133BB4C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $ReturnToCamp$45171(M971_MaohsTomb5 self_)
		{
			if (95629 - 409090 != -313460)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (92985 - 475610 == -382625)
				{
					base..ctor();
					if (258472 - 213427 != 45046)
					{
						this.$self_$45175 = self_;
						if (160973 - 501135 == -340162)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x0600AE8C RID: 44684 RVA: 0x0133D9E4 File Offset: 0x0133BBE4
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M971_MaohsTomb5.$ReturnToCamp$45171.$(this.$self_$45175);
		}

		// Token: 0x0600AE8D RID: 44685 RVA: 0x0133D9F4 File Offset: 0x0133BBF4
		internal static bool DxlMsaVrIaZ4rlfumOsG()
		{
			return true;
		}

		// Token: 0x0600AE8E RID: 44686 RVA: 0x0133D9F8 File Offset: 0x0133BBF8
		internal static bool LQP57lVrBH7mGSlSO6r5()
		{
			return false;
		}

		// Token: 0x040099B4 RID: 39348
		internal M971_MaohsTomb5 $self_$45175;

		// Token: 0x02001D2B RID: 7467
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600AE8F RID: 44687 RVA: 0x0133D9FC File Offset: 0x0133BBFC
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M971_MaohsTomb5 self_)
			{
				if (178643 - 116635 != 62009)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (230933 - 499786 == -268853)
					{
						base..ctor();
						if (195775 - 531779 == -336004)
						{
							this.$self_$45174 = self_;
							if (272545 - 115849 == 156696)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x0600AE90 RID: 44688 RVA: 0x0133DA94 File Offset: 0x0133BC94
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (272509 - 478266 != -205757)
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
						this.$self_$45174.LeaveGame();
						if (229401 - 261146 != -31745)
						{
							continue;
						}
						this.YieldDefault(1);
						if (24477 - 511446 != -486969)
						{
							continue;
						}
						goto IL_363;
					default:
						if (55619 - 344866 == -289246)
						{
							continue;
						}
						break;
					}
					Game.mGameState = eGameState.Ended;
					if (115852 - 592344 != -476491)
					{
						Game.mStateTime = Time.time;
						if (113205 - 529432 != -416226)
						{
							this.$$switch$8436$45172 = PlayerData.SaveGuild;
							if (134829 - 459212 == -324383)
							{
								if (this.$$switch$8436$45172 == 1)
								{
									if (7782 - 64178 == -56395)
									{
										continue;
									}
									Game.mNextGameCode = 32;
									if (21985 - 125653 != -103668)
									{
										continue;
									}
								}
								else if (this.$$switch$8436$45172 == 2)
								{
									if (285903 - 581004 == -295100)
									{
										continue;
									}
									Game.mNextGameCode = 33;
									if (72162 - 23459 == 48704)
									{
										continue;
									}
								}
								else if (this.$$switch$8436$45172 == 3)
								{
									if (26273 - 325374 != -299101)
									{
										continue;
									}
									Game.mNextGameCode = 34;
									if (119895 - 99931 != 19964)
									{
										continue;
									}
								}
								else if (this.$$switch$8436$45172 == 4)
								{
									if (70760 - 89316 == -18555)
									{
										continue;
									}
									Game.mNextGameCode = 35;
									if (3915 - 116360 == -112444)
									{
										continue;
									}
								}
								else if (this.$$switch$8436$45172 == 5)
								{
									if (246958 - 252991 != -6033)
									{
										continue;
									}
									Game.mNextGameCode = 36;
									if (79229 - 278539 == -199309)
									{
										continue;
									}
								}
								else
								{
									Game.mNextGameCode = 30;
									if (200966 - 128817 != 72149)
									{
										continue;
									}
								}
								this.$mGameGui$45173 = (GameGui)this.$self_$45174.GetComponent(typeof(GameGui));
								if (205618 - 549865 == -344247)
								{
									if (this.$mGameGui$45173)
									{
										if (178375 - 314116 == -135740)
										{
											continue;
										}
										this.$mGameGui$45173.close();
										if (278602 - 456343 != -177741)
										{
											continue;
										}
									}
									this.$self_$45174.SendMessage("fadeOut");
									if (177573 - 352277 != -174703)
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

			// Token: 0x0600AE91 RID: 44689 RVA: 0x0133DE18 File Offset: 0x0133C018
			internal static bool aDrgd8Vrepsq3hiUcbAq()
			{
				return true;
			}

			// Token: 0x0600AE92 RID: 44690 RVA: 0x0133DE1C File Offset: 0x0133C01C
			internal static bool BdHCILVrrlwEOaPChhxe()
			{
				return false;
			}

			// Token: 0x040099B5 RID: 39349
			internal int $$switch$8436$45172;

			// Token: 0x040099B6 RID: 39350
			internal GameGui $mGameGui$45173;

			// Token: 0x040099B7 RID: 39351
			internal M971_MaohsTomb5 $self_$45174;
		}
	}
}
