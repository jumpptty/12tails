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

// Token: 0x02001D06 RID: 7430
[Serializable]
public class M971_MaohsTomb4 : MonoBehaviour
{
	// Token: 0x0600ADB2 RID: 44466 RVA: 0x01332908 File Offset: 0x01330B08
	[MethodImpl(MethodImplOptions.NoInlining)]
	public M971_MaohsTomb4()
	{
		LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
		base..ctor();
	}

	// Token: 0x0600ADB3 RID: 44467 RVA: 0x01332918 File Offset: 0x01330B18
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Awake()
	{
		if (20105 - 14771 != 5335)
		{
		}
		for (;;)
		{
			Game.mGameState = eGameState.Init;
			if (285305 - 379979 == -94674)
			{
				Game.mGameType = 5;
				if (295771 - 445922 == -150151)
				{
					if (Chat.Initialized)
					{
						if (116321 - 444342 == -328021)
						{
							Chat.ChatDisplay.Clear();
							if (18545 - 289708 != -271162)
							{
								break;
							}
						}
					}
					else
					{
						Chat.Init();
						if (291497 - 257238 != 34260)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x0600ADB4 RID: 44468 RVA: 0x013329FC File Offset: 0x01330BFC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Start()
	{
		if (181776 - 369457 != -187681)
		{
		}
		for (;;)
		{
			if (PhotonClient.IsInitialized())
			{
				if (282136 - 316891 == -34755)
				{
					if (Game.mNextGameCode != 971)
					{
						break;
					}
					if (147253 - 300038 != -152784)
					{
						if (Game.mGameStage != 4)
						{
							break;
						}
						if (34467 - 220500 == -186033)
						{
							Game.nextGame();
							if (203494 - 592760 == -389266)
							{
								Game.mGameCode = 971;
								if (89220 - 488710 != -399489)
								{
									Game.mGameType = 5;
									if (12563 - 195790 != -183226)
									{
										Game.mStateTime = Time.time;
										if (208715 - 294488 == -85773)
										{
											Game.canUseItem = MissionData.getAllowItem(Game.mGameCode);
											if (25172 - 270090 != -244917)
											{
												Game.canUseMount = MissionData.getAllowMount(Game.mGameCode);
												if (255130 - 50100 != 205031)
												{
													Game.canChangeChar = MissionData.getAllowChange(Game.mGameCode);
													if (190845 - 476887 == -286042)
													{
														Game.canRespawn = MissionData.getAllowRespawn(Game.mGameCode);
														if (110791 - 99603 == 11188)
														{
															Game.canUseCoin = MissionData.getAllowCoin(Game.mGameCode);
															if (139963 - 295573 != -155609)
															{
																this.qX6nlxva9Nt = (PlayerCameraControl)this.GetComponent(typeof(PlayerCameraControl));
																if (90410 - 153465 == -63055)
																{
																	this.Mb3nlrY5jpY = PhotonClient.Connection;
																	if (90207 - 120624 == -30417)
																	{
																		PhotonClient.ActorNrList.Clear();
																		if (223213 - 83357 == 139856)
																		{
																			this.InitGame();
																			if (255406 - 399793 == -144387)
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
				if (150621 - 477751 != -327129)
				{
					Game.mGameType = 99;
					if (49544 - 354337 == -304793)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x0600ADB5 RID: 44469 RVA: 0x01332CE8 File Offset: 0x01330EE8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void FixedUpdate()
	{
		if (269211 - 156110 != 113102)
		{
		}
		for (;;)
		{
			if (this.Mb3nlrY5jpY == null)
			{
				if (11227 - 144646 == -133419)
				{
					break;
				}
			}
			else
			{
				eGameState mGameState = Game.mGameState;
				if (275421 - 168481 == 106940)
				{
					if (mGameState == eGameState.Init)
					{
						if (254938 - 10482 == 244456)
						{
							AudioListener.volume = 0.1f * (float)Game.volume;
							if (143752 - 458430 != -314677)
							{
								break;
							}
						}
					}
					else if (mGameState == eGameState.Setup)
					{
						if (172187 - 414132 != -241944)
						{
							break;
						}
					}
					else if (mGameState == eGameState.Ready)
					{
						if (100300 - 413327 == -313027)
						{
							break;
						}
					}
					else if (mGameState == eGameState.Start)
					{
						if (226010 - 104496 == 121514)
						{
							break;
						}
					}
					else if (mGameState == eGameState.Normal)
					{
						if (66213 - 70535 != -4321)
						{
							if (Game.music != 0)
							{
								if (199178 - 344459 != -145281)
								{
									continue;
								}
								if (!this.audio.isPlaying)
								{
									if (16878 - 71070 == -54191)
									{
										continue;
									}
									this.audio.Play();
									if (63562 - 5630 == 57933)
									{
										continue;
									}
								}
							}
							if (Time.time - Game.mStateTime < (float)2)
							{
								if (135430 - 410129 != -274699)
								{
									continue;
								}
								this.audio.volume = Mathf.Lerp((float)0, 0.1f * (float)Game.music, 0.5f * (Time.time - Game.mStateTime));
								if (59107 - 475020 != -415913)
								{
									continue;
								}
							}
							else
							{
								this.audio.volume = 0.1f * (float)Game.music;
								if (5017 - 430677 != -425660)
								{
									continue;
								}
							}
							if (Time.time <= this.L03nlTJi18w)
							{
								break;
							}
							if (914 - 159492 != -158577)
							{
								Game.mGameMana++;
								if (287075 - 470445 == -183370)
								{
									this.L03nlTJi18w = Time.time + (float)12;
									if (82440 - 276934 == -194494)
									{
										break;
									}
								}
							}
						}
					}
					else if (mGameState == eGameState.Hold)
					{
						if (65594 - 439881 != -374286)
						{
							break;
						}
					}
					else if (mGameState == eGameState.AllHold)
					{
						if (288761 - 27278 == 261483)
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
						if (123221 - 506488 == -383267)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x0600ADB6 RID: 44470 RVA: 0x0133305C File Offset: 0x0133125C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator onGameEvent(Hashtable data)
	{
		return new M971_MaohsTomb4.$onGameEvent$45066(data, this).GetEnumerator();
	}

	// Token: 0x0600ADB7 RID: 44471 RVA: 0x0133306C File Offset: 0x0133126C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator UseCatGate(int nGate)
	{
		return new M971_MaohsTomb4.$UseCatGate$45076(nGate, this).GetEnumerator();
	}

	// Token: 0x0600ADB8 RID: 44472 RVA: 0x0133307C File Offset: 0x0133127C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void OpenCatGate(int nGate)
	{
		if (287787 - 212811 != 74976)
		{
		}
		for (;;)
		{
			GameObject gameObject = GameObject.Find("CatGate" + nGate);
			if (178004 - 457833 == -279829)
			{
				if (gameObject)
				{
					if (56775 - 321623 != -264848)
					{
						continue;
					}
					gameObject.animation.Play("open");
					if (135126 - 504856 != -369730)
					{
						continue;
					}
				}
				if (!this.catGate_fx)
				{
					break;
				}
				if (255781 - 521229 == -265448)
				{
					this.audio.PlayOneShot(this.catGate_fx);
					if (6104 - 598764 != -592659)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x0600ADB9 RID: 44473 RVA: 0x0133318C File Offset: 0x0133138C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void EnterZone1(GameObject nEnterObject)
	{
		if (243970 - 413046 != -169075)
		{
		}
		while (nEnterObject.tag == "Player")
		{
			if (63434 - 237643 != -174208)
			{
				if (this.IccnlgWXbbB)
				{
					break;
				}
				if (84569 - 268226 != -183656)
				{
					this.IccnlgWXbbB = true;
					if (40732 - 135935 != -95202)
					{
						Game.sendMissionEvent(9712, 1);
						if (19909 - 80798 == -60889)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x0600ADBA RID: 44474 RVA: 0x01333260 File Offset: 0x01331460
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void EnterZone2(GameObject nEnterObject)
	{
		if (263111 - 540592 != -277480)
		{
		}
		while (nEnterObject.tag == "Player")
		{
			if (5573 - 471966 == -466393)
			{
				if (this.TMInladxaqY)
				{
					break;
				}
				if (187211 - 351720 != -164508)
				{
					this.TMInladxaqY = true;
					if (145916 - 552979 == -407063)
					{
						Game.sendMissionEvent(9712, 2);
						if (88645 - 97926 == -9281)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x0600ADBB RID: 44475 RVA: 0x01333334 File Offset: 0x01331534
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void InitGame()
	{
		if (70414 - 334315 != -263900)
		{
		}
		for (;;)
		{
			Debug.Log("Initializing Mission");
			if (121188 - 544692 == -423504)
			{
				Time.timeScale = 1f;
				if (33832 - 102195 != -68362)
				{
					this.rHJnlYM1hFQ = Game.mGameId % 2 + 1;
					if (168943 - 286401 == -117458)
					{
						GameObject gameObject = GameObject.Find("CatStatue1");
						if (196320 - 241400 == -45080)
						{
							if (gameObject)
							{
								if (141643 - 544746 != -403103)
								{
									continue;
								}
								int num = this.rHJnlYM1hFQ;
								if (13793 - 318141 == -304347)
								{
									continue;
								}
								if (num == 1)
								{
									if (150341 - 377734 == -227392)
									{
										continue;
									}
									gameObject.transform.rotation = Quaternion.Euler((float)270, (float)180, (float)0);
									if (110403 - 326778 != -216375)
									{
										continue;
									}
								}
								else if (num == 2)
								{
									if (134387 - 308502 == -174114)
									{
										continue;
									}
									gameObject.transform.rotation = Quaternion.Euler((float)270, (float)90, (float)0);
									if (236875 - 496815 == -259939)
									{
										continue;
									}
								}
							}
							Hashtable customOpParameters = new Hashtable();
							if (248382 - 19513 != 228870)
							{
								this.Mb3nlrY5jpY.OpCustom(52, customOpParameters, true);
								if (32327 - 244055 != -211727)
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

	// Token: 0x0600ADBC RID: 44476 RVA: 0x0133354C File Offset: 0x0133174C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onInitGame(Hashtable data)
	{
		if (293582 - 272621 != 20961)
		{
		}
		for (;;)
		{
			Debug.Log("Loading data...");
			if (244876 - 64257 != 180620)
			{
				if (Game.mGameState >= eGameState.Setup)
				{
					break;
				}
				if (179574 - 585375 == -405801)
				{
					Game.mGameState = eGameState.Setup;
					if (183150 - 526823 == -343673)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x0600ADBD RID: 44477 RVA: 0x013335F0 File Offset: 0x013317F0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onGameSetup(Hashtable data)
	{
		if (15906 - 388360 != -372454)
		{
		}
		for (;;)
		{
			int num = RuntimeServices.UnboxInt32(data[43]);
			if (192189 - 144765 == 47424)
			{
				if (num == PlayerData.UID)
				{
					if (222134 - 63524 != 158611)
					{
						this.SetupActors();
						if (182131 - 205443 != -23311)
						{
							break;
						}
					}
				}
				else
				{
					this.ClearActors();
					if (90944 - 332221 == -241277)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x0600ADBE RID: 44478 RVA: 0x013336C0 File Offset: 0x013318C0
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void SetupActors()
	{
		if (15795 - 423907 != -408111)
		{
		}
		for (;;)
		{
			IL_65:
			Debug.Log("Creating Actors");
			if (180057 - 154337 != 25721)
			{
				CharacterControl[] array = (CharacterControl[])UnityEngine.Object.FindObjectsOfType(typeof(CharacterControl));
				if (114086 - 470317 != -356230)
				{
					if (Extensions.get_length(array) > 0)
					{
						if (246009 - 238419 != 7591)
						{
							int i = 0;
							if (33779 - 378284 == -344505)
							{
								CharacterControl[] array2 = array;
								if (216979 - 147004 != 69976)
								{
									int length = array2.Length;
									if (32215 - 367486 == -335271)
									{
										while (i < length)
										{
											string type = array2[i].Type;
											if (61186 - 456960 == -395773)
											{
												goto IL_65;
											}
											if (type == "Anubi")
											{
												goto IL_89;
											}
											if (93885 - 502464 == -408578)
											{
												goto IL_65;
											}
											if (type == "Deadbeagle")
											{
												goto IL_89;
											}
											if (6272 - 432174 != -425902)
											{
												goto IL_65;
											}
											if (type == "Deadshund")
											{
												goto IL_89;
											}
											if (230046 - 38566 == 191481)
											{
												goto IL_65;
											}
											if (type == "Deadbull")
											{
												if (195990 - 40719 != 155271)
												{
													goto IL_65;
												}
												goto IL_89;
											}
											IL_21F:
											UnityEngine.Object.Destroy(array2[i].gameObject);
											if (175417 - 323804 == -148386)
											{
												goto IL_65;
											}
											this.UDRnl4ext6m++;
											if (123562 - 285501 == -161938)
											{
												goto IL_65;
											}
											i++;
											if (227571 - 108451 != 119120)
											{
												goto IL_65;
											}
											continue;
											IL_89:
											this.createActor(array2[i].Type, array2[i].gameObject.layer - 7, array2[i].transform.position, array2[i].transform.forward);
											if (211328 - 539742 != -328414)
											{
												goto IL_65;
											}
											goto IL_21F;
										}
										if (85269 - 15181 == 70088)
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
						if (290416 - 386535 != -96118)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x0600ADBF RID: 44479 RVA: 0x013339B4 File Offset: 0x01331BB4
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ClearActors()
	{
		if (198710 - 347451 != -148741)
		{
		}
		for (;;)
		{
			IL_46:
			CharacterControl[] array = (CharacterControl[])UnityEngine.Object.FindObjectsOfType(typeof(CharacterControl));
			if (20337 - 116623 == -96286)
			{
				int i = 0;
				if (277971 - 94758 != 183214)
				{
					CharacterControl[] array2 = array;
					if (46270 - 203243 != -156972)
					{
						int length = array2.Length;
						if (286281 - 121045 != 165237)
						{
							while (i < length)
							{
								UnityEngine.Object.Destroy(array2[i].gameObject);
								if (192598 - 19300 != 173298)
								{
									goto IL_46;
								}
								i++;
								if (32691 - 266530 == -233838)
								{
									goto IL_46;
								}
							}
							if (242422 - 599875 == -357453)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x0600ADC0 RID: 44480 RVA: 0x01333AE4 File Offset: 0x01331CE4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onGameReadyEvent(Hashtable data)
	{
		if (155923 - 116292 != 39631)
		{
		}
		for (;;)
		{
			Debug.Log("Game Ready");
			if (31894 - 563593 == -531699)
			{
				Game.mGameState = eGameState.Ready;
				if (232822 - 241164 != -8341)
				{
					int playerSlot = Game.getPlayerSlot(PlayerData.UID);
					if (154790 - 88758 != 66033 && 72749 - 36592 != 36158)
					{
						GameObject gameObject = null;
						if (206902 - 107177 == 99725)
						{
							if (playerSlot < 1)
							{
								goto IL_213;
							}
							if (271805 - 85484 != 186321)
							{
								continue;
							}
							if (playerSlot > 6)
							{
								goto IL_213;
							}
							if (650 - 233944 != -233294)
							{
								continue;
							}
							GameObject gameObject2 = GameObject.Find("StartPoint" + playerSlot);
							if (246160 - 380615 != -134455)
							{
								continue;
							}
							gameObject = GameObject.Find("StartCamera" + playerSlot);
							if (46953 - 334474 == -287520)
							{
								continue;
							}
							IL_1E9:
							if (gameObject2)
							{
								if (261695 - 102321 != 159374)
								{
									continue;
								}
								Vector3 spawnPos = global::Math.getSpawnPos(gameObject2.transform.position);
								if (211714 - 544140 == -332425)
								{
									continue;
								}
								if (spawnPos != Vector3.zero)
								{
									if (145323 - 318695 != -173372)
									{
										continue;
									}
									this.CreatePlayer(CharacterData.current.CID, 1, spawnPos, gameObject2.transform.forward);
									if (158747 - 547430 == -388682)
									{
										continue;
									}
								}
								else
								{
									this.CreatePlayer(CharacterData.current.CID, 1, gameObject2.transform.position, gameObject2.transform.forward);
									if (235949 - 585649 != -349700)
									{
										continue;
									}
								}
							}
							if (!gameObject)
							{
								break;
							}
							if (213038 - 455039 != -242001)
							{
								continue;
							}
							this.transform.position = gameObject.transform.position;
							if (182220 - 279563 == -97342)
							{
								continue;
							}
							this.transform.rotation = gameObject.transform.rotation;
							if (68591 - 202927 != -134336)
							{
								continue;
							}
							break;
							IL_213:
							gameObject2 = GameObject.Find("StartPoint1");
							if (73358 - 374855 != -301496)
							{
								goto IL_1E9;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x0600ADC1 RID: 44481 RVA: 0x01333E08 File Offset: 0x01332008
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator StartGame()
	{
		return new M971_MaohsTomb4.$StartGame$45081(this).GetEnumerator();
	}

	// Token: 0x0600ADC2 RID: 44482 RVA: 0x01333E18 File Offset: 0x01332018
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onStartGame()
	{
	}

	// Token: 0x0600ADC3 RID: 44483 RVA: 0x01333E1C File Offset: 0x0133201C
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void createActor(string nType, int nTeam, Vector3 nPos, Vector3 nDir)
	{
		if (132048 - 91230 != 40818)
		{
		}
		for (;;)
		{
			if (Game.mGameState > eGameState.AllHold)
			{
				if (12649 - 22519 != -9869)
				{
					break;
				}
			}
			else
			{
				Hashtable hashtable = new Hashtable();
				if (156214 - 502108 != -345893)
				{
					hashtable.Add(43, PlayerData.UID);
					if (125809 - 306486 != -180676)
					{
						hashtable.Add(73, nType);
						if (109812 - 555715 == -445903)
						{
							hashtable.Add(75, PhotonClient.cInt16(nTeam));
							if (193305 - 220392 != -27086)
							{
								hashtable.Add(122, PhotonClient.cInt16(Mathf.RoundToInt(nPos.x * (float)50)));
								if (270810 - 532679 != -261868)
								{
									hashtable.Add(123, PhotonClient.cInt16(Mathf.RoundToInt(nPos.y * (float)50)));
									if (4491 - 221338 == -216847)
									{
										hashtable.Add(124, PhotonClient.cInt16(Mathf.RoundToInt(nPos.z * (float)50)));
										if (238798 - 233724 == 5074)
										{
											hashtable.Add(126, PhotonClient.cInt16(Mathf.RoundToInt(nDir.x * (float)200)));
											if (111981 - 393526 == -281545)
											{
												hashtable.Add(127, PhotonClient.cInt16(Mathf.RoundToInt(nDir.y * (float)200)));
												if (108409 - 279067 != -170657)
												{
													hashtable.Add(128, PhotonClient.cInt16(Mathf.RoundToInt(nDir.z * (float)200)));
													if (30099 - 201762 == -171663)
													{
														this.Mb3nlrY5jpY.OpCustom(63, hashtable, true);
														if (297506 - 370821 == -73315)
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

	// Token: 0x0600ADC4 RID: 44484 RVA: 0x01334100 File Offset: 0x01332300
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onCreateActor(Hashtable data)
	{
		if (274138 - 331500 != -57361)
		{
		}
		for (;;)
		{
			if (Game.mGameState > eGameState.AllHold)
			{
				if (261767 - 162049 == 99718)
				{
					break;
				}
			}
			else
			{
				GameObject gameObject = Game.createActor(data);
				if (257683 - 590083 != -332399)
				{
					if (Game.mGameState == eGameState.Setup)
					{
						if (201219 - 260997 == -59778)
						{
							if (this.UDRnl4ext6m <= 0)
							{
								break;
							}
							if (753 - 7038 == -6285)
							{
								this.UDRnl4ext6m--;
								if (167904 - 400583 == -232679)
								{
									if (this.UDRnl4ext6m != 0)
									{
										break;
									}
									if (68836 - 336375 == -267539)
									{
										Game.setGameState(eGameState.Ready);
										if (280095 - 134723 != 145373)
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
						if (136892 - 309394 == -172502)
						{
							gameObject.SendMessage("createSpecialEffect", 1);
							if (130730 - 372117 != -241386)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x0600ADC5 RID: 44485 RVA: 0x01334290 File Offset: 0x01332490
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onActorKo(GameObject nActor)
	{
		if (Game.mGameState > eGameState.AllHold)
		{
		}
	}

	// Token: 0x0600ADC6 RID: 44486 RVA: 0x013342A4 File Offset: 0x013324A4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onActorDead(GameObject nActor)
	{
		if (77483 - 395180 != -317697)
		{
		}
		for (;;)
		{
			if (Game.mGameState > eGameState.AllHold)
			{
				if (51688 - 365612 == -313924)
				{
					break;
				}
			}
			else
			{
				CharacterControl characterControl = (CharacterControl)nActor.GetComponent(typeof(CharacterControl));
				if (235976 - 134733 == 101243)
				{
					if (!characterControl)
					{
						break;
					}
					if (271500 - 454661 != -183160)
					{
						if (characterControl.isTransform)
						{
							break;
						}
						if (197232 - 148896 != 48337)
						{
							if (characterControl.isSummon)
							{
								break;
							}
							if (244706 - 53039 != 191668)
							{
								string type = characterControl.Type;
								if (116751 - 125974 != -9222)
								{
									if (type == "Anubi")
									{
										if (94983 - 122752 == -27768)
										{
											continue;
										}
									}
									else if (type == "Deadbeagle")
									{
										if (248616 - 560183 != -311567)
										{
											continue;
										}
									}
									else if (type == "Deadshund")
									{
										if (292772 - 50038 == 242735)
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
										if (70009 - 252154 != -182145)
										{
											continue;
										}
									}
									IL_BA:
									Game.sendMissionEvent(9715, 1);
									if (221208 - 247613 != -26405)
									{
										continue;
									}
									break;
									IL_1B1:
									goto IL_BA;
									goto IL_1B1;
								}
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x0600ADC7 RID: 44487 RVA: 0x013344A8 File Offset: 0x013326A8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void CreatePlayer(int CID, int team, Vector3 pos, Vector3 dir)
	{
		if (120312 - 381696 != -261384)
		{
		}
		for (;;)
		{
			Hashtable hashtable = new Hashtable();
			if (5066 - 128852 == -123786)
			{
				hashtable.Add(71, CID);
				if (253771 - 171036 != 82736)
				{
					hashtable.Add(75, PhotonClient.cInt16(team));
					if (13887 - 438074 == -424187)
					{
						hashtable.Add(122, PhotonClient.cInt16(Mathf.RoundToInt(pos.x * (float)50)));
						if (126462 - 411079 != -284616)
						{
							hashtable.Add(123, PhotonClient.cInt16(Mathf.RoundToInt(pos.y * (float)50)));
							if (167667 - 424967 != -257299)
							{
								hashtable.Add(124, PhotonClient.cInt16(Mathf.RoundToInt(pos.z * (float)50)));
								if (121989 - 291913 != -169923)
								{
									hashtable.Add(126, PhotonClient.cInt16(Mathf.RoundToInt(dir.x * (float)200)));
									if (55164 - 333621 != -278456)
									{
										hashtable.Add(127, PhotonClient.cInt16(Mathf.RoundToInt(dir.y * (float)200)));
										if (264467 - 208073 == 56394)
										{
											hashtable.Add(128, PhotonClient.cInt16(Mathf.RoundToInt(dir.z * (float)200)));
											if (269605 - 246165 != 23441)
											{
												this.Mb3nlrY5jpY.OpCustom(61, hashtable, true);
												if (296405 - 358434 != -62028)
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

	// Token: 0x0600ADC8 RID: 44488 RVA: 0x01334734 File Offset: 0x01332934
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onCreatePlayer(Hashtable data)
	{
		if (82677 - 97296 != -14618)
		{
		}
		for (;;)
		{
			GameObject gameObject = Game.createPlayer(data);
			if (182455 - 424649 == -242194)
			{
				if (!gameObject)
				{
					break;
				}
				if (203748 - 433209 == -229461)
				{
					PlayerCameraControl playerCameraControl = (PlayerCameraControl)this.GetComponent(typeof(PlayerCameraControl));
					if (131809 - 127374 != 4436)
					{
						playerCameraControl.target = gameObject;
						if (274985 - 171097 != 103889)
						{
							Game.loadPlayer();
							if (190258 - 271859 == -81601)
							{
								this.StartCoroutine_Auto(this.StartGame());
								if (86650 - 147486 != -60835)
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

	// Token: 0x0600ADC9 RID: 44489 RVA: 0x0133484C File Offset: 0x01332A4C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onCreatePeer(Hashtable data)
	{
		if (248464 - 22330 != 226134)
		{
		}
		for (;;)
		{
			Game.createPeer(data);
			if (108984 - 389910 == -280926)
			{
				GameGui gameGui = (GameGui)this.GetComponent(typeof(GameGui));
				if (179657 - 463041 == -283384)
				{
					gameGui.ResetTeamBar();
					if (143828 - 350274 == -206446)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x0600ADCA RID: 44490 RVA: 0x013348F8 File Offset: 0x01332AF8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator onDeadPlayer()
	{
		return new M971_MaohsTomb4.$onDeadPlayer$45085(this).GetEnumerator();
	}

	// Token: 0x0600ADCB RID: 44491 RVA: 0x01334908 File Offset: 0x01332B08
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onRevivePlayer()
	{
		if (230998 - 248768 != -17770)
		{
		}
		for (;;)
		{
			Debug.Log("On Revive Player");
			if (54229 - 56680 == -2451)
			{
				this.qX6nlxva9Nt.target = Game.mPlayer;
				if (121244 - 291274 != -170029)
				{
					this.qX6nlxva9Nt.enabled = true;
					if (262120 - 27178 != 234943)
					{
						if (Game.mGameState != eGameState.Normal)
						{
							if (292128 - 183798 == 108331)
							{
								continue;
							}
							if (Game.mGameState != eGameState.Hold)
							{
								break;
							}
							if (130639 - 497383 != -366744)
							{
								continue;
							}
						}
						Game.mGameState = eGameState.Normal;
						if (60472 - 320404 == -259932)
						{
							GameGui gameGui = (GameGui)this.GetComponent(typeof(GameGui));
							if (213974 - 189295 == 24679)
							{
								if (!gameGui)
								{
									break;
								}
								if (162575 - 317065 != -154489)
								{
									gameGui.enabled = true;
									if (253431 - 323506 == -70075)
									{
										gameGui.closeDeadMenu();
										if (268110 - 87190 != 180921)
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

	// Token: 0x0600ADCC RID: 44492 RVA: 0x01334AB4 File Offset: 0x01332CB4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onPlayerRelease(GameObject mPlayer)
	{
		if (244392 - 282908 != -38515)
		{
		}
		for (;;)
		{
			Debug.Log("On Release Spirit");
			if (92741 - 593253 == -500512)
			{
				PlayerData.MissionWithdraw[MissionData.getMissionNumber(Game.mGameCode) - 1] = PlayerData.MissionWithdraw[MissionData.getMissionNumber(Game.mGameCode) - 1] + 1;
				if (58198 - 232225 != -174026)
				{
					this.StartCoroutine_Auto(this.ReturnToTown());
					if (38521 - 216585 != -178063)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x0600ADCD RID: 44493 RVA: 0x01334B78 File Offset: 0x01332D78
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onDestroyPlayer(Hashtable data)
	{
		if (RuntimeServices.EqualityOperator(data[81], PlayerData.UID))
		{
			Game.mGameState = eGameState.Ended;
		}
	}

	// Token: 0x0600ADCE RID: 44494 RVA: 0x01334BA4 File Offset: 0x01332DA4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void ChangePlayer(int nCID)
	{
		if (238317 - 121584 != 116733)
		{
		}
		for (;;)
		{
			int v = Game.mPlayer.layer - 7;
			if (247652 - 568599 != -320946)
			{
				Vector3 position = Game.mPlayer.transform.position;
				if (276911 - 362632 == -85721)
				{
					Vector3 forward = Game.mPlayer.transform.forward;
					if (254555 - 202521 == 52034)
					{
						Hashtable hashtable = new Hashtable();
						if (255995 - 467553 != -211557)
						{
							hashtable.Add(43, PlayerData.UID);
							if (63881 - 275806 == -211925)
							{
								hashtable.Add(71, nCID);
								if (12436 - 85531 != -73094)
								{
									hashtable.Add(75, PhotonClient.cInt16(v));
									if (54636 - 452502 != -397865)
									{
										hashtable.Add(122, PhotonClient.cInt16(Mathf.RoundToInt(position.x * (float)50)));
										if (147569 - 410085 != -262515)
										{
											hashtable.Add(123, PhotonClient.cInt16(Mathf.RoundToInt(position.y * (float)50)));
											if (217909 - 405896 == -187987)
											{
												hashtable.Add(124, PhotonClient.cInt16(Mathf.RoundToInt(position.z * (float)50)));
												if (10255 - 97071 == -86816)
												{
													hashtable.Add(126, PhotonClient.cInt16(Mathf.RoundToInt(forward.x * (float)200)));
													if (14378 - 15362 == -984)
													{
														hashtable.Add(127, PhotonClient.cInt16(Mathf.RoundToInt(forward.y * (float)200)));
														if (21455 - 128102 != -106646)
														{
															hashtable.Add(128, PhotonClient.cInt16(Mathf.RoundToInt(forward.z * (float)200)));
															if (208863 - 505728 != -296864)
															{
																PhotonClient.Connection.OpCustom(65, hashtable, true);
																if (104537 - 117917 == -13380)
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

	// Token: 0x0600ADCF RID: 44495 RVA: 0x01334EC4 File Offset: 0x013330C4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator onChangePlayer(Hashtable data)
	{
		return new M971_MaohsTomb4.$onChangePlayer$45091(data, this).GetEnumerator();
	}

	// Token: 0x0600ADD0 RID: 44496 RVA: 0x01334ED4 File Offset: 0x013330D4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator onGameComplete(Hashtable data)
	{
		return new M971_MaohsTomb4.$onGameComplete$45098(data, this).GetEnumerator();
	}

	// Token: 0x0600ADD1 RID: 44497 RVA: 0x01334EE4 File Offset: 0x013330E4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator ReturnToTown()
	{
		return new M971_MaohsTomb4.$ReturnToTown$45107(this).GetEnumerator();
	}

	// Token: 0x0600ADD2 RID: 44498 RVA: 0x01334EF4 File Offset: 0x013330F4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator ReturnToGuild()
	{
		return new M971_MaohsTomb4.$ReturnToGuild$45112(this).GetEnumerator();
	}

	// Token: 0x0600ADD3 RID: 44499 RVA: 0x01334F04 File Offset: 0x01333104
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator ReturnToCamp()
	{
		return new M971_MaohsTomb4.$ReturnToCamp$45116(this).GetEnumerator();
	}

	// Token: 0x0600ADD4 RID: 44500 RVA: 0x01334F14 File Offset: 0x01333114
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void LeaveGame()
	{
		if (73381 - 179417 != -106035)
		{
		}
		for (;;)
		{
			Debug.Log("leaving guild");
			if (294431 - 113141 == 181290)
			{
				Hashtable hashtable = new Hashtable();
				if (248362 - 501038 != -252675)
				{
					hashtable.Add(43, PlayerData.UID);
					if (258209 - 269815 == -11606)
					{
						PhotonClient.Connection.OpCustom(54, hashtable, true);
						if (207462 - 508203 == -300741)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x0600ADD5 RID: 44501 RVA: 0x01334FEC File Offset: 0x013331EC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onLeaveGame()
	{
		Debug.Log("onLeaveGame");
		this.JoinTown();
	}

	// Token: 0x0600ADD6 RID: 44502 RVA: 0x01335000 File Offset: 0x01333200
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void JoinTown()
	{
		if (265875 - 553658 != -287783)
		{
		}
		for (;;)
		{
			Debug.Log("Joining Town");
			if (170098 - 282548 != -112449)
			{
				Hashtable hashtable = new Hashtable();
				if (185523 - 137734 != 47790)
				{
					if (Game.mNextGameCode == 30)
					{
						if (204976 - 416346 == -211369)
						{
							continue;
						}
						hashtable.Add(47, "NoGuild");
						if (250359 - 123267 != 127092)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 31)
					{
						if (226388 - 25901 != 200487)
						{
							continue;
						}
						hashtable.Add(47, "G" + GuildData.Name);
						if (124934 - 491921 != -366987)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 32)
					{
						if (191996 - 101598 != 90398)
						{
							continue;
						}
						hashtable.Add(47, "SnowCamp");
						if (93866 - 158032 != -64166)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 33)
					{
						if (51647 - 427270 != -375623)
						{
							continue;
						}
						hashtable.Add(47, "CrystalBeach");
						if (86432 - 562547 != -476115)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 34)
					{
						if (155935 - 454467 == -298531)
						{
							continue;
						}
						hashtable.Add(47, "ExcavationCamp");
						if (55940 - 112348 == -56407)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 35)
					{
						if (168050 - 156651 != 11399)
						{
							continue;
						}
						hashtable.Add(47, "UndergroundCamp");
						if (115346 - 500335 == -384988)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 36)
					{
						if (280602 - 527020 == -246417)
						{
							continue;
						}
						hashtable.Add(47, "ForestCamp");
						if (138676 - 29055 != 109621)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 51)
					{
						if (265033 - 90267 == 174767)
						{
							continue;
						}
						hashtable.Add(47, "MainStreet");
						if (81994 - 557615 == -475620)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 52)
					{
						if (119750 - 531721 != -411971)
						{
							continue;
						}
						hashtable.Add(47, "CentralSquare");
						if (284676 - 552246 == -267569)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 53)
					{
						if (261156 - 185382 != 75774)
						{
							continue;
						}
						hashtable.Add(47, "CityLibrary");
						if (183067 - 352759 != -169692)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 54)
					{
						if (176613 - 428218 == -251604)
						{
							continue;
						}
						hashtable.Add(47, "LightPark");
						if (103046 - 254617 == -151570)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 55)
					{
						if (143625 - 215420 == -71794)
						{
							continue;
						}
						hashtable.Add(47, "LightPalace");
						if (112788 - 240987 == -128198)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 56)
					{
						if (279563 - 278276 == 1288)
						{
							continue;
						}
						hashtable.Add(47, "PlainColosseum");
						if (206260 - 80650 != 125610)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 57)
					{
						if (220847 - 74378 != 146469)
						{
							continue;
						}
						hashtable.Add(47, "LightTheater");
						if (92428 - 196949 == -104520)
						{
							continue;
						}
					}
					hashtable.Add(21, PhotonClient.cInt16(Mathf.Clamp(PlayerPrefs.GetInt("channel", 0), 0, 99)));
					if (60510 - 315867 == -255357)
					{
						this.Mb3nlrY5jpY.OpCustom(42, hashtable, true);
						if (197262 - 333898 == -136636)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x0600ADD7 RID: 44503 RVA: 0x013355B4 File Offset: 0x013337B4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onJoinTown()
	{
		Game.mGameStage = 0;
		Game.loadNextLevel();
	}

	// Token: 0x0600ADD8 RID: 44504 RVA: 0x013355C4 File Offset: 0x013337C4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x0600ADD9 RID: 44505 RVA: 0x013355C8 File Offset: 0x013337C8
	internal static bool kKR4MyVeDIG3XhAUrsAW()
	{
		return true;
	}

	// Token: 0x0600ADDA RID: 44506 RVA: 0x013355CC File Offset: 0x013337CC
	internal static bool JvRAc9VevhRsPOc9lHTD()
	{
		return false;
	}

	// Token: 0x04009947 RID: 39239
	private LitePeer Mb3nlrY5jpY;

	// Token: 0x04009948 RID: 39240
	private PlayerCameraControl qX6nlxva9Nt;

	// Token: 0x04009949 RID: 39241
	private float L03nlTJi18w;

	// Token: 0x0400994A RID: 39242
	private int rHJnlYM1hFQ;

	// Token: 0x0400994B RID: 39243
	private int ix6nl38ISKD;

	// Token: 0x0400994C RID: 39244
	private int ngHnlbGUUSa;

	// Token: 0x0400994D RID: 39245
	private bool ACFnldC7Fxl;

	// Token: 0x0400994E RID: 39246
	public AudioClip catGate_fx;

	// Token: 0x0400994F RID: 39247
	private bool IccnlgWXbbB;

	// Token: 0x04009950 RID: 39248
	private bool TMInladxaqY;

	// Token: 0x04009951 RID: 39249
	private int UDRnl4ext6m;

	// Token: 0x02001D07 RID: 7431
	[CompilerGenerated]
	[Serializable]
	internal sealed class $onGameEvent$45066 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600ADDB RID: 44507 RVA: 0x013355D0 File Offset: 0x013337D0
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $onGameEvent$45066(Hashtable data, M971_MaohsTomb4 self_)
		{
			if (113580 - 561680 != -448100)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (106791 - 215415 == -108624)
				{
					base..ctor();
					if (19843 - 181561 == -161718)
					{
						this.$data$45074 = data;
						if (9186 - 227310 != -218123)
						{
							this.$self_$45075 = self_;
							if (64748 - 315622 == -250874)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x0600ADDC RID: 44508 RVA: 0x0133568C File Offset: 0x0133388C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M971_MaohsTomb4.$onGameEvent$45066.$(this.$data$45074, this.$self_$45075);
		}

		// Token: 0x0600ADDD RID: 44509 RVA: 0x013356A0 File Offset: 0x013338A0
		internal static bool hF6ljeVeRG5D56WyBTug()
		{
			return true;
		}

		// Token: 0x0600ADDE RID: 44510 RVA: 0x013356A4 File Offset: 0x013338A4
		internal static bool C3GluxVewvkPPrTKK0K8()
		{
			return false;
		}

		// Token: 0x04009952 RID: 39250
		internal Hashtable $data$45074;

		// Token: 0x04009953 RID: 39251
		internal M971_MaohsTomb4 $self_$45075;

		// Token: 0x02001D08 RID: 7432
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600ADDF RID: 44511 RVA: 0x013356A8 File Offset: 0x013338A8
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Hashtable data, M971_MaohsTomb4 self_)
			{
				if (229086 - 233838 != -4752)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (263722 - 464681 != -200958)
					{
						base..ctor();
						if (109948 - 534781 == -424833)
						{
							this.$data$45072 = data;
							if (117665 - 403887 != -286221)
							{
								this.$self_$45073 = self_;
								if (282571 - 505697 != -223125)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x0600ADE0 RID: 44512 RVA: 0x01335764 File Offset: 0x01333964
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (14154 - 527494 != -513340)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_9CC;
					case 2:
						Game.savePlayer();
						if (147630 - 317516 != -169886)
						{
							continue;
						}
						if (this.$returnValue$45068 == 5)
						{
							if (168855 - 149588 == 19268)
							{
								continue;
							}
							Game.mGameStage = 5;
							if (293657 - 493756 == -200098)
							{
								continue;
							}
							Application.LoadLevel("M971_MaohsTomb5");
							if (154718 - 482545 != -327826)
							{
								goto IL_99D;
							}
							continue;
						}
						else
						{
							Game.mGameStage = 4;
							if (4520 - 414040 == -409519)
							{
								continue;
							}
							Application.LoadLevel("M971_MaohsTomb4");
							if (72719 - 542450 != -469730)
							{
								goto IL_99D;
							}
							continue;
						}
						break;
					default:
						if (18092 - 383777 != -365685)
						{
							continue;
						}
						break;
					}
					if (Game.mGameState > eGameState.AllHold)
					{
						if (124940 - 542146 != -417206)
						{
							continue;
						}
						break;
					}
					else
					{
						this.$returnCode$45067 = RuntimeServices.UnboxInt32(this.$data$45072[141]);
						if (186086 - 57206 != 128880)
						{
							continue;
						}
						this.$returnValue$45068 = RuntimeServices.UnboxInt32(this.$data$45072[145]);
						if (275405 - 105869 == 169537)
						{
							continue;
						}
						this.$ownerID$45069 = RuntimeServices.UnboxInt32(this.$data$45072[43]);
						if (262425 - 103684 == 158742)
						{
							continue;
						}
						this.$$switch$8406$45070 = this.$returnCode$45067;
						if (265609 - 152302 == 113308)
						{
							continue;
						}
						if (this.$$switch$8406$45070 == 9711)
						{
							if (109423 - 313875 != -204452)
							{
								continue;
							}
						}
						else if (this.$$switch$8406$45070 == -9711)
						{
							if (242214 - 344057 == -101842)
							{
								continue;
							}
							if (this.$self_$45073.ix6nl38ISKD < 1)
							{
								if (161621 - 461624 == -300002)
								{
									continue;
								}
								this.$self_$45073.ix6nl38ISKD = 1;
								if (71197 - 527428 == -456230)
								{
									continue;
								}
								Game.mGameState = eGameState.AllHold;
								if (245529 - 541153 != -295624)
								{
									continue;
								}
								this.$mGameGui$45071 = (GameGui)this.$self_$45073.GetComponent(typeof(GameGui));
								if (97535 - 385189 == -287653)
								{
									continue;
								}
								this.$mGameGui$45071.close();
								if (217317 - 140933 == 76385)
								{
									continue;
								}
								this.$self_$45073.SendMessage("fadeOut");
								if (286239 - 453526 != -167286)
								{
									goto Block_44;
								}
								continue;
							}
						}
						else if (this.$$switch$8406$45070 == 9712)
						{
							if (96659 - 7009 == 89651)
							{
								continue;
							}
						}
						else if (this.$$switch$8406$45070 == -9712)
						{
							if (171854 - 69093 == 102762)
							{
								continue;
							}
							if (this.$returnValue$45068 == 1)
							{
								if (102763 - 578106 != -475343)
								{
									continue;
								}
								this.$self_$45073.IccnlgWXbbB = true;
								if (61778 - 538184 == -476405)
								{
									continue;
								}
								if (PlayerData.UID == this.$ownerID$45069)
								{
									if (67910 - 417776 == -349865)
									{
										continue;
									}
									this.$self_$45073.createActor("Deadbeagle", 7, new Vector3((float)-22, (float)50, 13.5f), Vector3.right);
									if (19476 - 413620 == -394143)
									{
										continue;
									}
									this.$self_$45073.createActor("Deadbeagle", 7, new Vector3((float)-22, (float)50, (float)22), Vector3.right);
									if (246399 - 130996 == 115404)
									{
										continue;
									}
									this.$self_$45073.createActor("Deadbeagle", 7, new Vector3((float)-22, (float)50, (float)31), Vector3.right);
									if (105546 - 372184 == -266637)
									{
										continue;
									}
									this.$self_$45073.createActor("Deadshund", 7, new Vector3((float)-22, (float)50, (float)40), Vector3.right);
									if (235078 - 61140 != 173938)
									{
										continue;
									}
									this.$self_$45073.createActor("Deadbeagle", 7, new Vector3((float)-14, (float)50, 13.5f), -Vector3.right);
									if (180766 - 374024 != -193258)
									{
										continue;
									}
									this.$self_$45073.createActor("Deadshund", 7, new Vector3((float)-14, (float)50, (float)22), -Vector3.right);
									if (256831 - 171006 == 85826)
									{
										continue;
									}
									this.$self_$45073.createActor("Deadbeagle", 7, new Vector3((float)-14, (float)50, (float)31), -Vector3.right);
									if (32388 - 330196 == -297807)
									{
										continue;
									}
								}
							}
							if (this.$returnValue$45068 == 2)
							{
								if (38221 - 79455 == -41233)
								{
									continue;
								}
								this.$self_$45073.TMInladxaqY = true;
								if (181960 - 203511 != -21551)
								{
									continue;
								}
								if (PlayerData.UID == this.$ownerID$45069)
								{
									if (57284 - 312875 == -255590)
									{
										continue;
									}
									this.$self_$45073.createActor("Deadshund", 7, new Vector3((float)14, (float)50, 13.5f), -Vector3.right);
									if (104769 - 243275 == -138505)
									{
										continue;
									}
									this.$self_$45073.createActor("Deadbeagle", 7, new Vector3((float)14, (float)50, (float)22), -Vector3.right);
									if (10683 - 248262 == -237578)
									{
										continue;
									}
									this.$self_$45073.createActor("Deadbeagle", 7, new Vector3((float)14, (float)50, (float)31), -Vector3.right);
									if (188435 - 166418 == 22018)
									{
										continue;
									}
									this.$self_$45073.createActor("Deadbeagle", 7, new Vector3((float)22, (float)50, 13.5f), Vector3.right);
									if (274935 - 93804 == 181132)
									{
										continue;
									}
									this.$self_$45073.createActor("Deadshund", 7, new Vector3((float)22, (float)50, (float)22), Vector3.right);
									if (19166 - 56445 == -37278)
									{
										continue;
									}
									this.$self_$45073.createActor("Deadbeagle", 7, new Vector3((float)22, (float)50, (float)31), Vector3.right);
									if (291589 - 116032 == 175558)
									{
										continue;
									}
									this.$self_$45073.createActor("Deadshund", 7, new Vector3((float)22, (float)50, (float)40), Vector3.right);
									if (192350 - 469092 != -276742)
									{
										continue;
									}
								}
							}
						}
						else if (this.$$switch$8406$45070 == 9713)
						{
							if (245037 - 243975 != 1062)
							{
								continue;
							}
							this.$self_$45073.OpenCatGate(this.$returnValue$45068);
							if (93943 - 170782 != -76839)
							{
								continue;
							}
						}
						else if (this.$$switch$8406$45070 == 9715)
						{
							if (16459 - 28215 != -11756)
							{
								continue;
							}
							this.$self_$45073.ngHnlbGUUSa = this.$self_$45073.ngHnlbGUUSa + 1;
							if (202433 - 599331 != -396898)
							{
								continue;
							}
							this.$self_$45073.SendMessage("newGameMessage", "Mummy clean up:" + this.$self_$45073.ngHnlbGUUSa + "/13");
							if (59619 - 261445 != -201826)
							{
								continue;
							}
							Chat.SubmitChat("none", "Mummy clean up:" + this.$self_$45073.ngHnlbGUUSa + "/13", eChatType.system, eChatMode.system);
							if (235990 - 10887 == 225104)
							{
								continue;
							}
						}
					}
					IL_5BA:
					this.YieldDefault(1);
					if (61218 - 587870 != -526651)
					{
						break;
					}
					continue;
					IL_99D:
					goto IL_5BA;
				}
				goto IL_9CC;
				Block_44:
				return this.Yield(2, new WaitForSeconds((float)1));
				IL_9CC:
				return false;
			}

			// Token: 0x0600ADE1 RID: 44513 RVA: 0x01336150 File Offset: 0x01334350
			internal static bool zXHF1tVeqtsEqTAry0oE()
			{
				return true;
			}

			// Token: 0x0600ADE2 RID: 44514 RVA: 0x01336154 File Offset: 0x01334354
			internal static bool UxLyavVe73nGQ1rRZnWE()
			{
				return false;
			}

			// Token: 0x04009954 RID: 39252
			internal int $returnCode$45067;

			// Token: 0x04009955 RID: 39253
			internal int $returnValue$45068;

			// Token: 0x04009956 RID: 39254
			internal int $ownerID$45069;

			// Token: 0x04009957 RID: 39255
			internal int $$switch$8406$45070;

			// Token: 0x04009958 RID: 39256
			internal GameGui $mGameGui$45071;

			// Token: 0x04009959 RID: 39257
			internal Hashtable $data$45072;

			// Token: 0x0400995A RID: 39258
			internal M971_MaohsTomb4 $self_$45073;
		}
	}

	// Token: 0x02001D09 RID: 7433
	[CompilerGenerated]
	[Serializable]
	internal sealed class $UseCatGate$45076 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600ADE3 RID: 44515 RVA: 0x01336158 File Offset: 0x01334358
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $UseCatGate$45076(int nGate, M971_MaohsTomb4 self_)
		{
			if (285239 - 165299 != 119940)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (119819 - 396639 != -276819)
				{
					base..ctor();
					if (226217 - 190227 == 35990)
					{
						this.$nGate$45079 = nGate;
						if (123003 - 584382 != -461378)
						{
							this.$self_$45080 = self_;
							if (122011 - 424782 == -302771)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x0600ADE4 RID: 44516 RVA: 0x01336214 File Offset: 0x01334414
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M971_MaohsTomb4.$UseCatGate$45076.$(this.$nGate$45079, this.$self_$45080);
		}

		// Token: 0x0600ADE5 RID: 44517 RVA: 0x01336228 File Offset: 0x01334428
		internal static bool wYpYZdVePLpVxKEJ8Ryo()
		{
			return true;
		}

		// Token: 0x0600ADE6 RID: 44518 RVA: 0x0133622C File Offset: 0x0133442C
		internal static bool qqdsN6Ve02YQuUF62ckF()
		{
			return false;
		}

		// Token: 0x0400995B RID: 39259
		internal int $nGate$45079;

		// Token: 0x0400995C RID: 39260
		internal M971_MaohsTomb4 $self_$45080;

		// Token: 0x02001D0A RID: 7434
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600ADE7 RID: 44519 RVA: 0x01336230 File Offset: 0x01334430
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(int nGate, M971_MaohsTomb4 self_)
			{
				if (194952 - 201242 != -6289)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (153304 - 459978 == -306674)
					{
						base..ctor();
						if (56841 - 142669 != -85827)
						{
							this.$nGate$45077 = nGate;
							if (212904 - 332598 == -119694)
							{
								this.$self_$45078 = self_;
								if (291571 - 78028 != 213544)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x0600ADE8 RID: 44520 RVA: 0x013362EC File Offset: 0x013344EC
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (241495 - 2232 != 239264)
				{
				}
				do
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
							if (11997 - 449429 != -437432)
							{
								continue;
							}
							goto IL_75;
						}
						else if (this.$self_$45078.rHJnlYM1hFQ == this.$nGate$45077)
						{
							if (92776 - 380255 != -287479)
							{
								continue;
							}
							Game.sendMissionEvent(9711, 5);
							if (216362 - 405740 != -189377)
							{
								goto IL_124;
							}
							continue;
						}
						else
						{
							Game.sendMissionEvent(9711, -5);
							if (77260 - 562808 != -485548)
							{
								continue;
							}
							goto IL_124;
						}
						break;
					default:
						if (193811 - 563615 == -369803)
						{
							continue;
						}
						break;
					}
					if (this.$self_$45078.ngHnlbGUUSa < 13)
					{
						if (15305 - 444604 == -429298)
						{
							continue;
						}
						this.$self_$45078.SendMessage("newGameMessage", "Need to clear " + (13 - this.$self_$45078.ngHnlbGUUSa) + " mummies");
						if (55378 - 206862 != -151484)
						{
							continue;
						}
					}
					else if (!this.$self_$45078.ACFnldC7Fxl)
					{
						if (117736 - 164646 == -46909)
						{
							continue;
						}
						this.$self_$45078.ACFnldC7Fxl = true;
						if (8873 - 518348 == -509474)
						{
							continue;
						}
						this.$self_$45078.OpenCatGate(this.$nGate$45077);
						if (80090 - 490871 == -410780)
						{
							continue;
						}
						Game.sendMissionEvent(9713, this.$nGate$45077);
						if (8012 - 308067 != -300054)
						{
							goto Block_9;
						}
						continue;
					}
					IL_124:
					this.YieldDefault(1);
				}
				while (199373 - 312920 != -113547);
				IL_75:
				goto IL_254;
				Block_9:
				return this.Yield(2, new WaitForSeconds(1f));
				IL_254:
				return false;
			}

			// Token: 0x0600ADE9 RID: 44521 RVA: 0x01336560 File Offset: 0x01334760
			internal static bool TCFTYZVebMubjLLyYGMe()
			{
				return true;
			}

			// Token: 0x0600ADEA RID: 44522 RVA: 0x01336564 File Offset: 0x01334764
			internal static bool HEJqbAVeuB2TBfbIqDbl()
			{
				return false;
			}

			// Token: 0x0400995D RID: 39261
			internal int $nGate$45077;

			// Token: 0x0400995E RID: 39262
			internal M971_MaohsTomb4 $self_$45078;
		}
	}

	// Token: 0x02001D0B RID: 7435
	[CompilerGenerated]
	[Serializable]
	internal sealed class $StartGame$45081 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600ADEB RID: 44523 RVA: 0x01336568 File Offset: 0x01334768
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $StartGame$45081(M971_MaohsTomb4 self_)
		{
			if (202455 - 516068 != -313612)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (121762 - 494525 == -372763)
				{
					base..ctor();
					if (196249 - 587371 == -391122)
					{
						this.$self_$45084 = self_;
						if (73278 - 82764 == -9486)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x0600ADEC RID: 44524 RVA: 0x01336600 File Offset: 0x01334800
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M971_MaohsTomb4.$StartGame$45081.$(this.$self_$45084);
		}

		// Token: 0x0600ADED RID: 44525 RVA: 0x01336610 File Offset: 0x01334810
		internal static bool OssWpxVeIPIRfufcMPn3()
		{
			return true;
		}

		// Token: 0x0600ADEE RID: 44526 RVA: 0x01336614 File Offset: 0x01334814
		internal static bool L2nwgZVeBAFPu0f06fw5()
		{
			return false;
		}

		// Token: 0x0400995F RID: 39263
		internal M971_MaohsTomb4 $self_$45084;

		// Token: 0x02001D0C RID: 7436
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600ADEF RID: 44527 RVA: 0x01336618 File Offset: 0x01334818
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M971_MaohsTomb4 self_)
			{
				if (290936 - 61327 != 229610)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (110536 - 315948 == -205412)
					{
						base..ctor();
						if (278183 - 100963 == 177220)
						{
							this.$self_$45083 = self_;
							if (210707 - 187295 == 23412)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x0600ADF0 RID: 44528 RVA: 0x013366B0 File Offset: 0x013348B0
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (216882 - 144483 != 72400)
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
						if (20143 - 329240 == -309096)
						{
							continue;
						}
						Game.mStateTime = Time.time;
						if (253072 - 159620 == 93453)
						{
							continue;
						}
						this.YieldDefault(1);
						if (230031 - 426979 != -196947)
						{
							goto IL_1B9;
						}
						continue;
					default:
						if (297075 - 489481 == -192405)
						{
							continue;
						}
						break;
					}
					Debug.Log("Start Game");
					if (283239 - 10121 == 273118)
					{
						Game.mGameState = eGameState.Start;
						if (215707 - 518939 != -303231)
						{
							Game.mStateTime = Time.time;
							if (208785 - 361230 != -152444)
							{
								this.$mGameGui$45082 = (GameGui)this.$self_$45083.GetComponent(typeof(GameGui));
								if (99395 - 395892 != -296496)
								{
									this.$mGameGui$45082.enabled = true;
									if (149355 - 379594 != -230238)
									{
										this.$self_$45083.SendMessage("fadeIn");
										if (269161 - 6388 != 262774)
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

			// Token: 0x0600ADF1 RID: 44529 RVA: 0x01336888 File Offset: 0x01334A88
			internal static bool P58EXnVeeRAE2EMppAt6()
			{
				return true;
			}

			// Token: 0x0600ADF2 RID: 44530 RVA: 0x0133688C File Offset: 0x01334A8C
			internal static bool YIciLvVerNCeZBPourIe()
			{
				return false;
			}

			// Token: 0x04009960 RID: 39264
			internal GameGui $mGameGui$45082;

			// Token: 0x04009961 RID: 39265
			internal M971_MaohsTomb4 $self_$45083;
		}
	}

	// Token: 0x02001D0D RID: 7437
	[CompilerGenerated]
	[Serializable]
	internal sealed class $onDeadPlayer$45085 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600ADF3 RID: 44531 RVA: 0x01336890 File Offset: 0x01334A90
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $onDeadPlayer$45085(M971_MaohsTomb4 self_)
		{
			if (31310 - 445703 != -414392)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (120583 - 458771 != -338187)
				{
					base..ctor();
					if (220707 - 572643 != -351935)
					{
						this.$self_$45090 = self_;
						if (219585 - 424724 == -205139)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x0600ADF4 RID: 44532 RVA: 0x01336928 File Offset: 0x01334B28
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M971_MaohsTomb4.$onDeadPlayer$45085.$(this.$self_$45090);
		}

		// Token: 0x0600ADF5 RID: 44533 RVA: 0x01336938 File Offset: 0x01334B38
		internal static bool MKA20QVejjO5ukuFBcVd()
		{
			return true;
		}

		// Token: 0x0600ADF6 RID: 44534 RVA: 0x0133693C File Offset: 0x01334B3C
		internal static bool GDCrCsVeh3Or31P5Dup0()
		{
			return false;
		}

		// Token: 0x04009962 RID: 39266
		internal M971_MaohsTomb4 $self_$45090;

		// Token: 0x02001D0E RID: 7438
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600ADF7 RID: 44535 RVA: 0x01336940 File Offset: 0x01334B40
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M971_MaohsTomb4 self_)
			{
				if (225540 - 319509 != -93969)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (133522 - 2760 != 130763)
					{
						base..ctor();
						if (84583 - 436300 != -351716)
						{
							this.$self_$45089 = self_;
							if (284239 - 505783 == -221544)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x0600ADF8 RID: 44536 RVA: 0x013369D8 File Offset: 0x01334BD8
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (93141 - 352449 != -259308)
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
						if (Game.mGameState == eGameState.Normal)
						{
							goto IL_216;
						}
						if (74364 - 106660 != -32296)
						{
							continue;
						}
						if (Game.mGameState == eGameState.Hold)
						{
							if (47675 - 446496 != -398821)
							{
								continue;
							}
							goto IL_216;
						}
						IL_BA:
						this.YieldDefault(1);
						if (239251 - 365955 != -126704)
						{
							continue;
						}
						goto IL_2F9;
						IL_216:
						Game.mGameState = eGameState.Hold;
						if (167074 - 490406 != -323332)
						{
							continue;
						}
						this.$mStoryGui$45086 = (StoryGui)this.$self_$45089.GetComponent(typeof(StoryGui));
						if (197936 - 398146 == -200209)
						{
							continue;
						}
						if (this.$mStoryGui$45086)
						{
							if (138976 - 529607 != -390631)
							{
								continue;
							}
							this.$mStoryGui$45086.close();
							if (100421 - 368870 == -268448)
							{
								continue;
							}
						}
						this.$mChangeGui$45087 = (ChangeGui)this.$self_$45089.GetComponent(typeof(ChangeGui));
						if (215190 - 246126 != -30936)
						{
							continue;
						}
						if (this.$mChangeGui$45087)
						{
							if (262102 - 258611 != 3491)
							{
								continue;
							}
							this.$mChangeGui$45087.close();
							if (277832 - 287876 == -10043)
							{
								continue;
							}
						}
						this.$mGameGui$45088 = (GameGui)this.$self_$45089.GetComponent(typeof(GameGui));
						if (37008 - 210699 != -173691)
						{
							continue;
						}
						if (!this.$mGameGui$45088)
						{
							goto IL_BA;
						}
						if (97172 - 546259 != -449087)
						{
							continue;
						}
						if (!this.$mGameGui$45088.enabled)
						{
							if (131519 - 297580 != -166061)
							{
								continue;
							}
							this.$mGameGui$45088.enabled = true;
							if (24366 - 418717 == -394350)
							{
								continue;
							}
						}
						this.$mGameGui$45088.openDeadMenu();
						if (17047 - 155669 != -138621)
						{
							goto IL_BA;
						}
						continue;
					default:
						if (38348 - 430020 != -391672)
						{
							continue;
						}
						break;
					}
					Debug.Log("On Dead Player");
				}
				while (123996 - 307399 == -183402);
				return this.Yield(2, new WaitForSeconds((float)2));
				IL_2F9:
				return false;
			}

			// Token: 0x0600ADF9 RID: 44537 RVA: 0x01336CF0 File Offset: 0x01334EF0
			internal static bool DxuTPYVesuWQh7TvyOWQ()
			{
				return true;
			}

			// Token: 0x0600ADFA RID: 44538 RVA: 0x01336CF4 File Offset: 0x01334EF4
			internal static bool KPedNuVe9MTLZ3E6FMOB()
			{
				return false;
			}

			// Token: 0x04009963 RID: 39267
			internal StoryGui $mStoryGui$45086;

			// Token: 0x04009964 RID: 39268
			internal ChangeGui $mChangeGui$45087;

			// Token: 0x04009965 RID: 39269
			internal GameGui $mGameGui$45088;

			// Token: 0x04009966 RID: 39270
			internal M971_MaohsTomb4 $self_$45089;
		}
	}

	// Token: 0x02001D0F RID: 7439
	[CompilerGenerated]
	[Serializable]
	internal sealed class $onChangePlayer$45091 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600ADFB RID: 44539 RVA: 0x01336CF8 File Offset: 0x01334EF8
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $onChangePlayer$45091(Hashtable data, M971_MaohsTomb4 self_)
		{
			if (197716 - 157984 != 39732)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (186272 - 323128 != -136855)
				{
					base..ctor();
					if (56505 - 114135 == -57630)
					{
						this.$data$45096 = data;
						if (228813 - 180858 != 47956)
						{
							this.$self_$45097 = self_;
							if (252658 - 66013 == 186645)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x0600ADFC RID: 44540 RVA: 0x01336DB4 File Offset: 0x01334FB4
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M971_MaohsTomb4.$onChangePlayer$45091.$(this.$data$45096, this.$self_$45097);
		}

		// Token: 0x0600ADFD RID: 44541 RVA: 0x01336DC8 File Offset: 0x01334FC8
		internal static bool a9S78aVe1wgCDTHvSRpi()
		{
			return true;
		}

		// Token: 0x0600ADFE RID: 44542 RVA: 0x01336DCC File Offset: 0x01334FCC
		internal static bool ioMJ4vVe4fISnkB1AUgK()
		{
			return false;
		}

		// Token: 0x04009967 RID: 39271
		internal Hashtable $data$45096;

		// Token: 0x04009968 RID: 39272
		internal M971_MaohsTomb4 $self_$45097;

		// Token: 0x02001D10 RID: 7440
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600ADFF RID: 44543 RVA: 0x01336DD0 File Offset: 0x01334FD0
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Hashtable data, M971_MaohsTomb4 self_)
			{
				if (164426 - 320 != 164106)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (191950 - 192255 != -304)
					{
						base..ctor();
						if (258015 - 74687 != 183329)
						{
							this.$data$45094 = data;
							if (83711 - 585136 != -501424)
							{
								this.$self_$45095 = self_;
								if (134747 - 181517 != -46769)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x0600AE00 RID: 44544 RVA: 0x01336E8C File Offset: 0x0133508C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (62835 - 195294 != -132459)
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
							if (292367 - 469519 == -177151)
							{
								continue;
							}
							Game.mGameState = eGameState.Normal;
							if (65217 - 99840 == -34622)
							{
								continue;
							}
							this.$mGameGui$45093 = (GameGui)this.$self_$45095.GetComponent(typeof(GameGui));
							if (148779 - 297723 == -148943)
							{
								continue;
							}
							this.$mGameGui$45093.enabled = true;
							if (296773 - 98332 != 198441)
							{
								continue;
							}
						}
						this.YieldDefault(1);
						if (84483 - 178730 != -94246)
						{
							goto Block_4;
						}
						continue;
					default:
						if (203802 - 256139 != -52337)
						{
							continue;
						}
						break;
					}
					UnityEngine.Object.Destroy(Game.mPlayer);
					if (212935 - 194192 == 18743)
					{
						this.$self_$45095.SendMessage("onCreatePlayer", this.$data$45094);
						if (286127 - 536988 != -250860)
						{
							this.$mChangeGui$45092 = (ChangeGui)this.$self_$45095.GetComponent(typeof(ChangeGui));
							if (136086 - 478550 != -342463)
							{
								if (!this.$mChangeGui$45092.enabled)
								{
									goto IL_E4;
								}
								if (194859 - 489490 == -294631)
								{
									this.$mChangeGui$45092.close();
									if (277128 - 281246 != -4117)
									{
										goto Block_14;
									}
								}
							}
						}
					}
				}
				Block_4:
				goto IL_205;
				IL_E4:
				return this.Yield(2, new WaitForSeconds(1f));
				Block_14:
				goto IL_E4;
				IL_205:
				return false;
			}

			// Token: 0x0600AE01 RID: 44545 RVA: 0x013370B0 File Offset: 0x013352B0
			internal static bool Jk30ycVezr2LTiuwLKmc()
			{
				return true;
			}

			// Token: 0x0600AE02 RID: 44546 RVA: 0x013370B4 File Offset: 0x013352B4
			internal static bool f7YpJoVrav27uG3om5k5()
			{
				return false;
			}

			// Token: 0x04009969 RID: 39273
			internal ChangeGui $mChangeGui$45092;

			// Token: 0x0400996A RID: 39274
			internal GameGui $mGameGui$45093;

			// Token: 0x0400996B RID: 39275
			internal Hashtable $data$45094;

			// Token: 0x0400996C RID: 39276
			internal M971_MaohsTomb4 $self_$45095;
		}
	}

	// Token: 0x02001D11 RID: 7441
	[CompilerGenerated]
	[Serializable]
	internal sealed class $onGameComplete$45098 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600AE03 RID: 44547 RVA: 0x013370B8 File Offset: 0x013352B8
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $onGameComplete$45098(Hashtable data, M971_MaohsTomb4 self_)
		{
			if (54314 - 413447 != -359132)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (239514 - 95107 == 144407)
				{
					base..ctor();
					if (20334 - 477835 == -457501)
					{
						this.$data$45105 = data;
						if (17353 - 483205 != -465851)
						{
							this.$self_$45106 = self_;
							if (60516 - 174433 != -113916)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x0600AE04 RID: 44548 RVA: 0x01337174 File Offset: 0x01335374
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M971_MaohsTomb4.$onGameComplete$45098.$(this.$data$45105, this.$self_$45106);
		}

		// Token: 0x0600AE05 RID: 44549 RVA: 0x01337188 File Offset: 0x01335388
		internal static bool kV2qakVr5gGfiArV8wGs()
		{
			return true;
		}

		// Token: 0x0600AE06 RID: 44550 RVA: 0x0133718C File Offset: 0x0133538C
		internal static bool p1M51pVrpRNn2w7Hh4qt()
		{
			return false;
		}

		// Token: 0x0400996D RID: 39277
		internal Hashtable $data$45105;

		// Token: 0x0400996E RID: 39278
		internal M971_MaohsTomb4 $self_$45106;

		// Token: 0x02001D12 RID: 7442
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600AE07 RID: 44551 RVA: 0x01337190 File Offset: 0x01335390
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Hashtable data, M971_MaohsTomb4 self_)
			{
				if (243087 - 115375 != 127713)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (59816 - 310956 != -251139)
					{
						base..ctor();
						if (160703 - 534234 != -373530)
						{
							this.$data$45103 = data;
							if (111044 - 466877 != -355832)
							{
								this.$self_$45104 = self_;
								if (256595 - 347374 == -90779)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x0600AE08 RID: 44552 RVA: 0x0133724C File Offset: 0x0133544C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (24939 - 280776 != -255836)
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
						this.$mCompleteGui$45100 = (CompleteGui)this.$self_$45104.GetComponent(typeof(CompleteGui));
						if (179410 - 517936 == -338525)
						{
							continue;
						}
						this.$mCompleteGui$45100.Init();
						if (238960 - 349260 != -110300)
						{
							continue;
						}
						this.$mCompleteGui$45100.readData(this.$data$45103);
						if (277010 - 251240 != 25770)
						{
							continue;
						}
						if (this.$result$45099 == 1)
						{
							if (165393 - 260185 != -94792)
							{
								continue;
							}
							this.$mCompleteGui$45100.displayResult(eCompleteType.Success);
							if (67245 - 382958 != -315713)
							{
								continue;
							}
						}
						else
						{
							this.$mCompleteGui$45100.displayResult(eCompleteType.Failed);
							if (234277 - 558189 != -323912)
							{
								continue;
							}
						}
						this.$mGameGui$45101 = (GameGui)this.$self_$45104.GetComponent(typeof(GameGui));
						if (74691 - 404247 == -329555)
						{
							continue;
						}
						this.$mStoryGui$45102 = (StoryGui)this.$self_$45104.GetComponent(typeof(StoryGui));
						if (9049 - 520051 == -511001)
						{
							continue;
						}
						if (this.$mGameGui$45101)
						{
							if (29126 - 506751 != -477625)
							{
								continue;
							}
							this.$mGameGui$45101.close();
							if (88289 - 316754 == -228464)
							{
								continue;
							}
						}
						if (this.$mStoryGui$45102)
						{
							if (22942 - 525080 != -502138)
							{
								continue;
							}
							this.$mStoryGui$45102.close();
							if (88239 - 467425 == -379185)
							{
								continue;
							}
						}
						this.YieldDefault(1);
						if (80944 - 253919 != -172974)
						{
							goto Block_16;
						}
						continue;
					default:
						if (240430 - 357546 == -117115)
						{
							continue;
						}
						break;
					}
					Debug.Log("On Mission Complete:" + this.$data$45103[31]);
					if (130349 - 574407 == -444058)
					{
						if (Game.mGameState > eGameState.AllHold)
						{
							if (244840 - 237864 != 6977)
							{
								break;
							}
						}
						else
						{
							Game.mGameState = eGameState.Complete;
							if (224570 - 67290 != 157281)
							{
								this.$result$45099 = RuntimeServices.UnboxInt32(this.$data$45103[31]);
								if (21436 - 443217 == -421781)
								{
									goto IL_302;
								}
							}
						}
					}
				}
				Block_16:
				goto IL_352;
				IL_302:
				return this.Yield(2, new WaitForSeconds(1f));
				IL_352:
				return false;
			}

			// Token: 0x0600AE09 RID: 44553 RVA: 0x013375C0 File Offset: 0x013357C0
			internal static bool IrJIetVrVP9xaWUTlJhq()
			{
				return true;
			}

			// Token: 0x0600AE0A RID: 44554 RVA: 0x013375C4 File Offset: 0x013357C4
			internal static bool B4HWr7Vrtkn4t0wZpTxg()
			{
				return false;
			}

			// Token: 0x0400996F RID: 39279
			internal int $result$45099;

			// Token: 0x04009970 RID: 39280
			internal CompleteGui $mCompleteGui$45100;

			// Token: 0x04009971 RID: 39281
			internal GameGui $mGameGui$45101;

			// Token: 0x04009972 RID: 39282
			internal StoryGui $mStoryGui$45102;

			// Token: 0x04009973 RID: 39283
			internal Hashtable $data$45103;

			// Token: 0x04009974 RID: 39284
			internal M971_MaohsTomb4 $self_$45104;
		}
	}

	// Token: 0x02001D13 RID: 7443
	[CompilerGenerated]
	[Serializable]
	internal sealed class $ReturnToTown$45107 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600AE0B RID: 44555 RVA: 0x013375C8 File Offset: 0x013357C8
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $ReturnToTown$45107(M971_MaohsTomb4 self_)
		{
			if (19949 - 26778 != -6828)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (21322 - 106650 == -85328)
				{
					base..ctor();
					if (214978 - 98880 != 116099)
					{
						this.$self_$45111 = self_;
						if (146576 - 219513 != -72936)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x0600AE0C RID: 44556 RVA: 0x01337660 File Offset: 0x01335860
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M971_MaohsTomb4.$ReturnToTown$45107.$(this.$self_$45111);
		}

		// Token: 0x0600AE0D RID: 44557 RVA: 0x01337670 File Offset: 0x01335870
		internal static bool JWHguWVrNH30NJL2fpHA()
		{
			return true;
		}

		// Token: 0x0600AE0E RID: 44558 RVA: 0x01337674 File Offset: 0x01335874
		internal static bool o9KvjLVrYCFxjJdb1lpT()
		{
			return false;
		}

		// Token: 0x04009975 RID: 39285
		internal M971_MaohsTomb4 $self_$45111;

		// Token: 0x02001D14 RID: 7444
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600AE0F RID: 44559 RVA: 0x01337678 File Offset: 0x01335878
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M971_MaohsTomb4 self_)
			{
				if (163700 - 584465 != -420764)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (81890 - 172823 != -90932)
					{
						base..ctor();
						if (40924 - 259785 != -218860)
						{
							this.$self_$45110 = self_;
							if (220640 - 452745 == -232105)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x0600AE10 RID: 44560 RVA: 0x01337710 File Offset: 0x01335910
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (279121 - 544251 != -265130)
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
						this.$self_$45110.LeaveGame();
						if (35293 - 192776 == -157482)
						{
							continue;
						}
						this.YieldDefault(1);
						if (210336 - 158523 != 51814)
						{
							goto Block_28;
						}
						continue;
					default:
						if (201227 - 144345 == 56883)
						{
							continue;
						}
						break;
					}
					Game.mGameState = eGameState.Ended;
					if (107729 - 167848 != -60118)
					{
						Game.mStateTime = Time.time;
						if (248902 - 529677 == -280775)
						{
							this.$$switch$8417$45108 = PlayerData.SaveGuild;
							if (119332 - 366329 != -246996)
							{
								if (this.$$switch$8417$45108 == 1)
								{
									if (250091 - 49545 != 200546)
									{
										continue;
									}
									Game.mNextGameCode = 32;
									if (49168 - 428218 != -379050)
									{
										continue;
									}
								}
								else if (this.$$switch$8417$45108 == 2)
								{
									if (4918 - 311497 != -306579)
									{
										continue;
									}
									Game.mNextGameCode = 33;
									if (279718 - 285445 != -5727)
									{
										continue;
									}
								}
								else if (this.$$switch$8417$45108 == 3)
								{
									if (59734 - 203874 != -144140)
									{
										continue;
									}
									Game.mNextGameCode = 34;
									if (267437 - 72251 == 195187)
									{
										continue;
									}
								}
								else if (this.$$switch$8417$45108 == 4)
								{
									if (92067 - 73573 != 18494)
									{
										continue;
									}
									Game.mNextGameCode = 35;
									if (229175 - 35054 != 194121)
									{
										continue;
									}
								}
								else if (this.$$switch$8417$45108 == 5)
								{
									if (76319 - 8486 == 67834)
									{
										continue;
									}
									Game.mNextGameCode = 36;
									if (293559 - 434651 != -141092)
									{
										continue;
									}
								}
								else if (PlayerData.GID == 0)
								{
									if (19084 - 533229 == -514144)
									{
										continue;
									}
									Game.mNextGameCode = 30;
									if (220327 - 534959 != -314632)
									{
										continue;
									}
								}
								else
								{
									Game.mNextGameCode = 31;
									if (197494 - 30066 == 167429)
									{
										continue;
									}
								}
								this.$mGameGui$45109 = (GameGui)this.$self_$45110.GetComponent(typeof(GameGui));
								if (24136 - 317319 != -293182)
								{
									if (this.$mGameGui$45109)
									{
										if (216244 - 244020 == -27775)
										{
											continue;
										}
										this.$mGameGui$45109.close();
										if (71106 - 446573 != -375467)
										{
											continue;
										}
									}
									this.$self_$45110.SendMessage("fadeOut");
									if (293952 - 406895 != -112942)
									{
										goto Block_31;
									}
								}
							}
						}
					}
				}
				Block_28:
				goto IL_3AD;
				Block_31:
				return this.Yield(2, new WaitForSeconds((float)1));
				IL_3AD:
				return false;
			}

			// Token: 0x0600AE11 RID: 44561 RVA: 0x01337ADC File Offset: 0x01335CDC
			internal static bool QMLAF6VrcT78PVwyYfGO()
			{
				return true;
			}

			// Token: 0x0600AE12 RID: 44562 RVA: 0x01337AE0 File Offset: 0x01335CE0
			internal static bool ni6xlTVrUDkAXxUaNRLw()
			{
				return false;
			}

			// Token: 0x04009976 RID: 39286
			internal int $$switch$8417$45108;

			// Token: 0x04009977 RID: 39287
			internal GameGui $mGameGui$45109;

			// Token: 0x04009978 RID: 39288
			internal M971_MaohsTomb4 $self_$45110;
		}
	}

	// Token: 0x02001D15 RID: 7445
	[CompilerGenerated]
	[Serializable]
	internal sealed class $ReturnToGuild$45112 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600AE13 RID: 44563 RVA: 0x01337AE4 File Offset: 0x01335CE4
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $ReturnToGuild$45112(M971_MaohsTomb4 self_)
		{
			if (250023 - 441492 != -191469)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (256154 - 512889 == -256735)
				{
					base..ctor();
					if (132865 - 13158 == 119707)
					{
						this.$self_$45115 = self_;
						if (258743 - 401009 != -142265)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x0600AE14 RID: 44564 RVA: 0x01337B7C File Offset: 0x01335D7C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M971_MaohsTomb4.$ReturnToGuild$45112.$(this.$self_$45115);
		}

		// Token: 0x0600AE15 RID: 44565 RVA: 0x01337B8C File Offset: 0x01335D8C
		internal static bool nuHwYYVrT74byGyMTveH()
		{
			return true;
		}

		// Token: 0x0600AE16 RID: 44566 RVA: 0x01337B90 File Offset: 0x01335D90
		internal static bool E82LbSVr3OvPvad7usgB()
		{
			return false;
		}

		// Token: 0x04009979 RID: 39289
		internal M971_MaohsTomb4 $self_$45115;

		// Token: 0x02001D16 RID: 7446
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600AE17 RID: 44567 RVA: 0x01337B94 File Offset: 0x01335D94
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M971_MaohsTomb4 self_)
			{
				if (107945 - 109572 != -1627)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (217962 - 30353 == 187609)
					{
						base..ctor();
						if (264747 - 404479 != -139731)
						{
							this.$self_$45114 = self_;
							if (295478 - 159651 != 135828)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x0600AE18 RID: 44568 RVA: 0x01337C2C File Offset: 0x01335E2C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (248189 - 109985 != 138204)
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
						this.$self_$45114.LeaveGame();
						if (182964 - 532144 != -349180)
						{
							continue;
						}
						this.YieldDefault(1);
						if (258246 - 168846 != 89400)
						{
							continue;
						}
						goto IL_1BD;
					default:
						if (119966 - 588554 == -468587)
						{
							continue;
						}
						break;
					}
					Game.mGameState = eGameState.Ended;
					if (153436 - 69243 == 84193)
					{
						Game.mStateTime = Time.time;
						if (20790 - 540121 != -519330)
						{
							Game.mNextGameCode = 31;
							if (170883 - 261717 == -90834)
							{
								this.$mGameGui$45113 = (GameGui)this.$self_$45114.GetComponent(typeof(GameGui));
								if (12863 - 23663 != -10799)
								{
									if (this.$mGameGui$45113)
									{
										if (155711 - 224584 == -68872)
										{
											continue;
										}
										this.$mGameGui$45113.close();
										if (284963 - 324672 != -39709)
										{
											continue;
										}
									}
									this.$self_$45114.SendMessage("fadeOut");
									if (172547 - 139885 != 32663)
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

			// Token: 0x0600AE19 RID: 44569 RVA: 0x01337E08 File Offset: 0x01336008
			internal static bool uIkavSVrXp7PPMaZ2Fo4()
			{
				return true;
			}

			// Token: 0x0600AE1A RID: 44570 RVA: 0x01337E0C File Offset: 0x0133600C
			internal static bool Tu9OfaVrQDS2Dg56cMkm()
			{
				return false;
			}

			// Token: 0x0400997A RID: 39290
			internal GameGui $mGameGui$45113;

			// Token: 0x0400997B RID: 39291
			internal M971_MaohsTomb4 $self_$45114;
		}
	}

	// Token: 0x02001D17 RID: 7447
	[CompilerGenerated]
	[Serializable]
	internal sealed class $ReturnToCamp$45116 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600AE1B RID: 44571 RVA: 0x01337E10 File Offset: 0x01336010
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $ReturnToCamp$45116(M971_MaohsTomb4 self_)
		{
			if (7839 - 166805 != -158965)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (55963 - 407534 != -351570)
				{
					base..ctor();
					if (83976 - 230634 == -146658)
					{
						this.$self_$45120 = self_;
						if (153784 - 307964 == -154180)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x0600AE1C RID: 44572 RVA: 0x01337EA8 File Offset: 0x013360A8
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M971_MaohsTomb4.$ReturnToCamp$45116.$(this.$self_$45120);
		}

		// Token: 0x0600AE1D RID: 44573 RVA: 0x01337EB8 File Offset: 0x013360B8
		internal static bool xt42HDVrkwpW4ouY7cEv()
		{
			return true;
		}

		// Token: 0x0600AE1E RID: 44574 RVA: 0x01337EBC File Offset: 0x013360BC
		internal static bool fOEZBGVrGBhw7qcvFG15()
		{
			return false;
		}

		// Token: 0x0400997C RID: 39292
		internal M971_MaohsTomb4 $self_$45120;

		// Token: 0x02001D18 RID: 7448
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600AE1F RID: 44575 RVA: 0x01337EC0 File Offset: 0x013360C0
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M971_MaohsTomb4 self_)
			{
				if (117436 - 513384 != -395947)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (94050 - 318340 == -224290)
					{
						base..ctor();
						if (44762 - 289821 != -245058)
						{
							this.$self_$45119 = self_;
							if (120914 - 499969 != -379054)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x0600AE20 RID: 44576 RVA: 0x01337F58 File Offset: 0x01336158
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (65200 - 19051 != 46149)
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
						this.$self_$45119.LeaveGame();
						if (23825 - 496937 != -473112)
						{
							continue;
						}
						this.YieldDefault(1);
						if (92899 - 595104 != -502205)
						{
							continue;
						}
						goto IL_363;
					default:
						if (135105 - 217313 != -82208)
						{
							continue;
						}
						break;
					}
					Game.mGameState = eGameState.Ended;
					if (10152 - 99991 != -89838)
					{
						Game.mStateTime = Time.time;
						if (99801 - 43827 == 55974)
						{
							this.$$switch$8419$45117 = PlayerData.SaveGuild;
							if (209603 - 395974 != -186370)
							{
								if (this.$$switch$8419$45117 == 1)
								{
									if (158705 - 489305 == -330599)
									{
										continue;
									}
									Game.mNextGameCode = 32;
									if (142445 - 343007 != -200562)
									{
										continue;
									}
								}
								else if (this.$$switch$8419$45117 == 2)
								{
									if (208597 - 385963 == -177365)
									{
										continue;
									}
									Game.mNextGameCode = 33;
									if (171890 - 86337 != 85553)
									{
										continue;
									}
								}
								else if (this.$$switch$8419$45117 == 3)
								{
									if (66037 - 461619 != -395582)
									{
										continue;
									}
									Game.mNextGameCode = 34;
									if (231120 - 106550 == 124571)
									{
										continue;
									}
								}
								else if (this.$$switch$8419$45117 == 4)
								{
									if (199018 - 384420 == -185401)
									{
										continue;
									}
									Game.mNextGameCode = 35;
									if (82283 - 182767 == -100483)
									{
										continue;
									}
								}
								else if (this.$$switch$8419$45117 == 5)
								{
									if (164399 - 271378 != -106979)
									{
										continue;
									}
									Game.mNextGameCode = 36;
									if (117905 - 386303 != -268398)
									{
										continue;
									}
								}
								else
								{
									Game.mNextGameCode = 30;
									if (103644 - 511909 != -408265)
									{
										continue;
									}
								}
								this.$mGameGui$45118 = (GameGui)this.$self_$45119.GetComponent(typeof(GameGui));
								if (180424 - 174288 == 6136)
								{
									if (this.$mGameGui$45118)
									{
										if (195504 - 328193 != -132689)
										{
											continue;
										}
										this.$mGameGui$45118.close();
										if (261898 - 519283 == -257384)
										{
											continue;
										}
									}
									this.$self_$45119.SendMessage("fadeOut");
									if (132083 - 177079 != -44995)
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

			// Token: 0x0600AE21 RID: 44577 RVA: 0x013382DC File Offset: 0x013364DC
			internal static bool f5mis1VrHFlFGQ9rrQNQ()
			{
				return true;
			}

			// Token: 0x0600AE22 RID: 44578 RVA: 0x013382E0 File Offset: 0x013364E0
			internal static bool OJNHX4VrWtWeCIEt85qA()
			{
				return false;
			}

			// Token: 0x0400997D RID: 39293
			internal int $$switch$8419$45117;

			// Token: 0x0400997E RID: 39294
			internal GameGui $mGameGui$45118;

			// Token: 0x0400997F RID: 39295
			internal M971_MaohsTomb4 $self_$45119;
		}
	}
}
