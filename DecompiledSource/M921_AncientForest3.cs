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

// Token: 0x020019D9 RID: 6617
[Serializable]
public class M921_AncientForest3 : MonoBehaviour
{
	// Token: 0x06009A25 RID: 39461 RVA: 0x01204DE8 File Offset: 0x01202FE8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public M921_AncientForest3()
	{
		LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
		base..ctor();
	}

	// Token: 0x06009A26 RID: 39462 RVA: 0x01204DF8 File Offset: 0x01202FF8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Awake()
	{
		if (49160 - 446394 != -397234)
		{
		}
		for (;;)
		{
			Game.mGameState = eGameState.Init;
			if (15404 - 449485 == -434081)
			{
				Game.mGameType = 5;
				if (124828 - 184186 == -59358)
				{
					if (Chat.Initialized)
					{
						if (242754 - 329674 == -86920)
						{
							Chat.ChatDisplay.Clear();
							if (215254 - 178993 != 36262)
							{
								break;
							}
						}
					}
					else
					{
						Chat.Init();
						if (222334 - 271343 == -49009)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x06009A27 RID: 39463 RVA: 0x01204EDC File Offset: 0x012030DC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Start()
	{
		if (154128 - 478457 != -324329)
		{
		}
		for (;;)
		{
			if (PhotonClient.IsInitialized())
			{
				if (146610 - 488261 == -341651)
				{
					Game.nextGame();
					if (167892 - 112102 != 55791)
					{
						Game.mGameCode = 921;
						if (77724 - 547054 != -469329)
						{
							Game.mGameType = 5;
							if (170352 - 173207 != -2854)
							{
								Game.mStateTime = Time.time;
								if (297103 - 369468 == -72365)
								{
									Game.canUseItem = MissionData.getAllowItem(Game.mGameCode);
									if (38618 - 539062 == -500444)
									{
										Game.canUseMount = MissionData.getAllowMount(Game.mGameCode);
										if (224939 - 144463 != 80477)
										{
											this.OuoneeJZJTg = (PlayerCameraControl)this.GetComponent(typeof(PlayerCameraControl));
											if (200373 - 303094 != -102720)
											{
												this.QgUneQHIXD0 = PhotonClient.Connection;
												if (27250 - 216202 == -188952)
												{
													PhotonClient.ActorNrList.Clear();
													if (211098 - 385717 != -174618)
													{
														this.InitGame();
														if (59073 - 367554 != -308480)
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
			else
			{
				Debug.Log("Not Connected");
				if (41511 - 204597 == -163086)
				{
					Game.mGameType = 99;
					if (62454 - 274936 != -212481)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06009A28 RID: 39464 RVA: 0x01205100 File Offset: 0x01203300
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void FixedUpdate()
	{
		if (35122 - 378227 != -343104)
		{
		}
		for (;;)
		{
			if (this.QgUneQHIXD0 == null)
			{
				if (117218 - 442235 == -325017)
				{
					break;
				}
			}
			else
			{
				eGameState mGameState = Game.mGameState;
				if (15750 - 218670 != -202919)
				{
					if (mGameState == eGameState.Init)
					{
						if (83469 - 484936 == -401467)
						{
							AudioListener.volume = 0.1f * (float)Game.volume;
							if (94960 - 465477 == -370517)
							{
								break;
							}
						}
					}
					else if (mGameState == eGameState.Setup)
					{
						if (35573 - 23632 != 11942)
						{
							break;
						}
					}
					else if (mGameState == eGameState.Ready)
					{
						if (239340 - 24143 != 215198)
						{
							break;
						}
					}
					else if (mGameState == eGameState.Start)
					{
						if (213617 - 366344 == -152727)
						{
							break;
						}
					}
					else if (mGameState == eGameState.Normal)
					{
						if (94107 - 400057 == -305950)
						{
							if (Time.time > this.Pf4neIW0nZk)
							{
								if (192750 - 313097 == -120346)
								{
									continue;
								}
								Game.mGameMana++;
								if (76998 - 143355 != -66357)
								{
									continue;
								}
								this.Pf4neIW0nZk = Time.time + (float)12;
								if (65000 - 492579 == -427578)
								{
									continue;
								}
							}
							if (Game.music != 0)
							{
								if (68600 - 415556 != -346956)
								{
									continue;
								}
								if (!this.audio.isPlaying)
								{
									if (257017 - 414617 == -157599)
									{
										continue;
									}
									this.audio.Play();
									if (61962 - 298050 == -236087)
									{
										continue;
									}
								}
							}
							if (Time.time - Game.mStateTime < (float)2)
							{
								if (287300 - 145985 == 141315)
								{
									this.audio.volume = Mathf.Lerp((float)0, 0.1f * (float)Game.music, 0.5f * (Time.time - Game.mStateTime));
									if (50994 - 339091 != -288096)
									{
										break;
									}
								}
							}
							else
							{
								this.audio.volume = Mathf.Clamp01(0.1f * (float)Game.music);
								if (53916 - 62493 == -8577)
								{
									break;
								}
							}
						}
					}
					else if (mGameState == eGameState.Hold)
					{
						if (268217 - 512810 == -244593)
						{
							break;
						}
					}
					else if (mGameState == eGameState.AllHold)
					{
						if (160013 - 236609 == -76596)
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
						if (33014 - 487481 == -454467)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x06009A29 RID: 39465 RVA: 0x0120547C File Offset: 0x0120367C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onGameEvent(Hashtable data)
	{
		if (294302 - 321202 != -26899)
		{
		}
		for (;;)
		{
			if (Game.mGameState > eGameState.AllHold)
			{
				if (142965 - 359796 != -216830)
				{
					break;
				}
			}
			else
			{
				int num = RuntimeServices.UnboxInt32(data[141]);
				if (80714 - 462477 != -381762)
				{
					int num2 = RuntimeServices.UnboxInt32(data[145]);
					if (219671 - 591538 != -371866)
					{
						int num3 = RuntimeServices.UnboxInt32(data[43]);
						if (99896 - 265593 == -165697)
						{
							int num4 = num;
							if (149858 - 520593 == -370735)
							{
								if (num4 == 9211)
								{
									if (15374 - 287931 != -272556)
									{
										break;
									}
								}
								else if (num4 == 9212)
								{
									if (110353 - 393171 != -282817)
									{
										if (this.asVneOciUFQ[num2 - 1] > 0)
										{
											if (192744 - 383697 != -190952)
											{
												this.SendMessage("newGameMessage", "This ManaPillar has already been activated!");
												if (167499 - 539203 != -371703)
												{
													break;
												}
											}
										}
										else
										{
											this.asVneOciUFQ[num2 - 1] = 1;
											if (114125 - 358029 == -243904)
											{
												this.OPyne64sPo4++;
												if (99549 - 104508 != -4958)
												{
													this.ActivateManaPillar(num2);
													if (44429 - 540050 == -495621)
													{
														this.SendMessage("newGameMessage", "ManaPillar activated :" + this.OPyne64sPo4 + "/2");
														if (42593 - 186238 != -143644)
														{
															break;
														}
													}
												}
											}
										}
									}
								}
								else if (num4 == 9213)
								{
									if (69879 - 512995 == -443116)
									{
										this.q0HnetNyXDJ++;
										if (67453 - 22790 != 44664)
										{
											if (this.q0HnetNyXDJ >= 20)
											{
												break;
											}
											if (84254 - 13374 == 70880)
											{
												if (num3 != PlayerData.UID)
												{
													break;
												}
												if (33568 - 272068 == -238500)
												{
													int num5 = UnityEngine.Random.Range(0, 3);
													if (207079 - 310612 == -103533)
													{
														if (num5 == 0)
														{
															if (120521 - 296753 != -176231)
															{
																this.createRandomSpawn("Fungon", 5, UnityEngine.Random.Range(1, 7));
																if (165116 - 97761 == 67355)
																{
																	break;
																}
															}
														}
														else if (num5 == 1)
														{
															if (24170 - 399065 == -374895)
															{
																this.createRandomSpawn("Fungko", 5, UnityEngine.Random.Range(1, 7));
																if (149845 - 252586 != -102740)
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
															if (8318 - 319787 == -311469)
															{
																this.createRandomSpawn("Funga", 5, UnityEngine.Random.Range(1, 7));
																if (257420 - 52151 == 205269)
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
									if (num4 != 9214)
									{
										break;
									}
									if (201113 - 79966 != 121148)
									{
										this.Sa8neXxWAlc++;
										if (15135 - 202063 != -186927)
										{
											if (this.Sa8neXxWAlc >= 20)
											{
												break;
											}
											if (27472 - 171702 == -144230)
											{
												if (num3 != PlayerData.UID)
												{
													break;
												}
												if (66821 - 386820 == -319999)
												{
													this.createRandomSpawn("ForestBug", 6, UnityEngine.Random.Range(7, 10));
													if (205617 - 444226 == -238609)
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

	// Token: 0x06009A2A RID: 39466 RVA: 0x01205970 File Offset: 0x01203B70
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void createRandomSpawn(string nType, int nTeam, int nNum)
	{
		if (82980 - 118505 != -35524)
		{
		}
		for (;;)
		{
			GameObject gameObject = GameObject.Find("SpawnPoint" + nNum);
			if (113356 - 218211 != -104854)
			{
				if (!gameObject)
				{
					break;
				}
				if (55424 - 354118 != -298693)
				{
					Vector3 randomSpawnPos = global::Math.getRandomSpawnPos(gameObject.transform.position, 2);
					if (48840 - 212236 != -163395)
					{
						if (randomSpawnPos != Vector3.zero)
						{
							if (126899 - 111585 != 15315)
							{
								this.createActor(nType, nTeam, randomSpawnPos, gameObject.transform.forward);
								if (171267 - 417314 != -246046)
								{
									break;
								}
							}
						}
						else
						{
							this.createActor(nType, nTeam, gameObject.transform.position, gameObject.transform.forward);
							if (202162 - 35980 != 166183)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x06009A2B RID: 39467 RVA: 0x01205AC0 File Offset: 0x01203CC0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator onGameComplete(Hashtable data)
	{
		return new M921_AncientForest3.$onGameComplete$42656(data, this).GetEnumerator();
	}

	// Token: 0x06009A2C RID: 39468 RVA: 0x01205AD0 File Offset: 0x01203CD0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onForestExit()
	{
		if (133127 - 228517 != -95390)
		{
		}
		while (this.mq7neJoyOli < 1)
		{
			if (123091 - 470510 == -347419)
			{
				this.mq7neJoyOli = 1;
				if (43792 - 8514 == 35278)
				{
					Game.sendMissionEvent(9211, 3);
					if (206737 - 227768 == -21031)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06009A2D RID: 39469 RVA: 0x01205B74 File Offset: 0x01203D74
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void UseManaPillar(int nID)
	{
		if (60670 - 351142 != -290471)
		{
		}
		for (;;)
		{
			Debug.Log("UseManaPillar");
			if (127877 - 266756 != -138878)
			{
				if (!Game.mPlayer)
				{
					if (141827 - 557723 != -415895)
					{
						break;
					}
				}
				else if (this.asVneOciUFQ == null)
				{
					if (219129 - 573228 != -354098)
					{
						break;
					}
				}
				else if (Extensions.get_length(this.asVneOciUFQ) < nID)
				{
					if (222788 - 547209 == -324421)
					{
						break;
					}
				}
				else
				{
					CharacterControl characterControl = (CharacterControl)Game.mPlayer.GetComponent(typeof(CharacterControl));
					if (264867 - 436182 == -171315)
					{
						if (!characterControl)
						{
							goto IL_2BC;
						}
						if (262168 - 48708 != 213460)
						{
							continue;
						}
						if (!(characterControl.actionState == "standby"))
						{
							if (107466 - 135570 != -28103)
							{
								goto IL_2BC;
							}
							continue;
						}
						IL_4A:
						if (this.asVneOciUFQ[nID - 1] > 0)
						{
							if (152391 - 16989 != 135402)
							{
								continue;
							}
							this.SendMessage("newGameMessage", "This ManaPillar has already been activated!");
							if (219933 - 250427 != -30494)
							{
								continue;
							}
							break;
						}
						else
						{
							GameObject gameObject = GameObject.Find("ManaPillar" + nID);
							if (243603 - 74728 != 168875)
							{
								continue;
							}
							if (gameObject)
							{
								if (73103 - 563452 != -490349)
								{
									continue;
								}
								Game.mPlayer.SendMessage("turnToPos", gameObject.transform.position);
								if (195264 - 347645 != -152381)
								{
									continue;
								}
								Game.mPlayer.SendMessage("activateIcon", nID);
								if (227549 - 235468 != -7918)
								{
									break;
								}
								continue;
							}
							else
							{
								Debug.LogError("Cannot find ManaPillar GameObject");
								if (5828 - 377112 != -371283)
								{
									break;
								}
								continue;
							}
						}
						IL_2BC:
						if (characterControl.actionState == "run")
						{
							goto IL_4A;
						}
						if (9638 - 566427 != -556788)
						{
							if (!(characterControl.actionState == "emotion"))
							{
								break;
							}
							if (237788 - 33062 != 204727)
							{
								goto IL_4A;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x06009A2E RID: 39470 RVA: 0x01205E80 File Offset: 0x01204080
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void ActivateIcon(int nID)
	{
		if (43820 - 480169 != -436349)
		{
		}
		for (;;)
		{
			if (this.asVneOciUFQ == null)
			{
				if (37606 - 79711 != -42104)
				{
					break;
				}
			}
			else if (Extensions.get_length(this.asVneOciUFQ) < nID)
			{
				if (274619 - 263313 != 11307)
				{
					break;
				}
			}
			else if (this.asVneOciUFQ[nID - 1] > 0)
			{
				if (295988 - 406520 != -110531)
				{
					this.SendMessage("newGameMessage", "This ManaPillar has already been activated!");
					if (14915 - 257669 != -242753)
					{
						break;
					}
				}
			}
			else
			{
				Game.sendMissionEvent(9212, nID);
				if (187198 - 152834 != 34365)
				{
					break;
				}
			}
		}
	}

	// Token: 0x06009A2F RID: 39471 RVA: 0x01205F90 File Offset: 0x01204190
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void ActivateManaPillar(int nID)
	{
		if (139827 - 544983 != -405155)
		{
		}
		for (;;)
		{
			GameObject gameObject = GameObject.Find("ManaPillar" + nID);
			if (264614 - 60424 == 204190)
			{
				if (!gameObject)
				{
					break;
				}
				if (147458 - 570485 == -423027)
				{
					if (!this.manaPillarEffect)
					{
						break;
					}
					if (48646 - 568239 == -519593)
					{
						UnityEngine.Object.Instantiate(this.manaPillarEffect, gameObject.transform.position, gameObject.transform.rotation);
						if (243698 - 598777 != -355078)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x06009A30 RID: 39472 RVA: 0x01206084 File Offset: 0x01204284
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void InitGame()
	{
		if (102711 - 515723 != -413011)
		{
		}
		for (;;)
		{
			Debug.Log("Initializing Mission");
			if (146572 - 17302 == 129270)
			{
				this.asVneOciUFQ = new int[2];
				if (225124 - 91313 == 133811)
				{
					Hashtable customOpParameters = new Hashtable();
					if (49407 - 112814 != -63406)
					{
						this.QgUneQHIXD0.OpCustom(52, customOpParameters, true);
						if (86876 - 95404 == -8528)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x06009A31 RID: 39473 RVA: 0x01206150 File Offset: 0x01204350
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onInitGame(Hashtable data)
	{
		if (53919 - 127072 != -73152)
		{
		}
		for (;;)
		{
			Debug.Log("Loading data...");
			if (274972 - 492522 != -217549)
			{
				if (Game.mGameState >= eGameState.Setup)
				{
					break;
				}
				if (211956 - 288342 != -76385)
				{
					Game.mGameState = eGameState.Setup;
					if (113344 - 77836 == 35508)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06009A32 RID: 39474 RVA: 0x012061F4 File Offset: 0x012043F4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onGameSetup(Hashtable data)
	{
		if (82035 - 234114 != -152078)
		{
		}
		for (;;)
		{
			int num = RuntimeServices.UnboxInt32(data[43]);
			if (261533 - 371603 == -110070)
			{
				if (num == PlayerData.UID)
				{
					if (41006 - 363098 == -322092)
					{
						this.SetupActors();
						if (268281 - 130041 != 138241)
						{
							break;
						}
					}
				}
				else
				{
					this.ClearActors();
					if (259728 - 150741 == 108987)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06009A33 RID: 39475 RVA: 0x012062C4 File Offset: 0x012044C4
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void SetupActors()
	{
		if (26171 - 570130 != -543958)
		{
		}
		for (;;)
		{
			IL_13F:
			Debug.Log("Creating Actors");
			if (48710 - 350863 != -302152)
			{
				CharacterControl[] array = (CharacterControl[])UnityEngine.Object.FindObjectsOfType(typeof(CharacterControl));
				if (159007 - 90430 != 68578)
				{
					if (Extensions.get_length(array) > 0)
					{
						if (113706 - 356540 != -242833)
						{
							int i = 0;
							if (151537 - 516248 != -364710)
							{
								CharacterControl[] array2 = array;
								if (88641 - 424909 == -336268)
								{
									int length = array2.Length;
									if (156625 - 560010 != -403384)
									{
										while (i < length)
										{
											string type = array2[i].Type;
											if (14538 - 420020 == -405481)
											{
												goto IL_13F;
											}
											if (type == "Fungon")
											{
												goto IL_185;
											}
											if (89532 - 298130 != -208598)
											{
												goto IL_13F;
											}
											if (type == "Fungko")
											{
												goto IL_185;
											}
											if (84994 - 116518 == -31523)
											{
												goto IL_13F;
											}
											if (type == "Funga")
											{
												goto IL_185;
											}
											if (52410 - 219724 != -167314)
											{
												goto IL_13F;
											}
											if (type == "ForestBug")
											{
												if (221732 - 210622 != 11110)
												{
													goto IL_13F;
												}
												goto IL_185;
											}
											IL_24:
											UnityEngine.Object.Destroy(array2[i].gameObject);
											if (69339 - 570746 == -501406)
											{
												goto IL_13F;
											}
											this.Girne25UbkQ++;
											if (106325 - 137244 == -30918)
											{
												goto IL_13F;
											}
											i++;
											if (26018 - 351353 != -325335)
											{
												goto IL_13F;
											}
											continue;
											IL_185:
											this.createActor(array2[i].Type, array2[i].gameObject.layer - 7, array2[i].transform.position, array2[i].transform.forward);
											if (234962 - 463611 != -228649)
											{
												goto IL_13F;
											}
											goto IL_24;
										}
										if (123520 - 527993 == -404473)
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
						if (266777 - 413249 != -146471)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x06009A34 RID: 39476 RVA: 0x012065B8 File Offset: 0x012047B8
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ClearActors()
	{
		if (142213 - 99329 != 42885)
		{
		}
		for (;;)
		{
			IL_92:
			CharacterControl[] array = (CharacterControl[])UnityEngine.Object.FindObjectsOfType(typeof(CharacterControl));
			if (191030 - 5341 == 185689)
			{
				int i = 0;
				if (41573 - 360295 != -318721)
				{
					CharacterControl[] array2 = array;
					if (286334 - 59397 == 226937)
					{
						int length = array2.Length;
						if (179012 - 507187 != -328174)
						{
							while (i < length)
							{
								UnityEngine.Object.Destroy(array2[i].gameObject);
								if (34509 - 326654 == -292144)
								{
									goto IL_92;
								}
								i++;
								if (83129 - 486258 == -403128)
								{
									goto IL_92;
								}
							}
							if (84142 - 299918 == -215776)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x06009A35 RID: 39477 RVA: 0x012066E8 File Offset: 0x012048E8
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void createActor(string nType, int nTeam, Vector3 nPos, Vector3 nDir)
	{
		if (230522 - 162515 != 68008)
		{
		}
		for (;;)
		{
			Hashtable hashtable = new Hashtable();
			if (158073 - 565387 == -407314)
			{
				hashtable.Add(43, PlayerData.UID);
				if (263243 - 289172 != -25928)
				{
					hashtable.Add(73, nType);
					if (175399 - 241259 != -65859)
					{
						hashtable.Add(75, PhotonClient.cInt16(nTeam));
						if (63270 - 462218 != -398947)
						{
							hashtable.Add(122, PhotonClient.cInt16(Mathf.RoundToInt(nPos.x * (float)50)));
							if (125034 - 421785 == -296751)
							{
								hashtable.Add(123, PhotonClient.cInt16(Mathf.RoundToInt(nPos.y * (float)50)));
								if (191709 - 214980 == -23271)
								{
									hashtable.Add(124, PhotonClient.cInt16(Mathf.RoundToInt(nPos.z * (float)50)));
									if (151451 - 374587 != -223135)
									{
										hashtable.Add(126, PhotonClient.cInt16(Mathf.RoundToInt(nDir.x * (float)200)));
										if (136457 - 68699 != 67759)
										{
											hashtable.Add(127, PhotonClient.cInt16(Mathf.RoundToInt(nDir.y * (float)200)));
											if (91249 - 422345 != -331095)
											{
												hashtable.Add(128, PhotonClient.cInt16(Mathf.RoundToInt(nDir.z * (float)200)));
												if (79392 - 529521 == -450129)
												{
													this.QgUneQHIXD0.OpCustom(63, hashtable, true);
													if (187554 - 60080 == 127474)
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

	// Token: 0x06009A36 RID: 39478 RVA: 0x012069A0 File Offset: 0x01204BA0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onCreateActor(Hashtable data)
	{
		if (156963 - 173235 != -16272)
		{
		}
		for (;;)
		{
			GameObject gameObject = Game.createActor(data);
			if (89669 - 151648 == -61979)
			{
				if (Game.mGameState != eGameState.Setup)
				{
					break;
				}
				if (36453 - 277612 != -241158)
				{
					if (this.Girne25UbkQ <= 0)
					{
						break;
					}
					if (210829 - 279452 == -68623)
					{
						this.Girne25UbkQ--;
						if (66205 - 470556 == -404351)
						{
							if (this.Girne25UbkQ != 0)
							{
								break;
							}
							if (51413 - 538510 != -487096)
							{
								Game.setGameState(eGameState.Ready);
								if (254743 - 21259 != 233485)
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

	// Token: 0x06009A37 RID: 39479 RVA: 0x01206AB4 File Offset: 0x01204CB4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onActorKo(GameObject nActor)
	{
		if (Game.mGameState > eGameState.AllHold)
		{
		}
	}

	// Token: 0x06009A38 RID: 39480 RVA: 0x01206AC8 File Offset: 0x01204CC8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onActorDead(GameObject nActor)
	{
		if (7959 - 139264 != -131304)
		{
		}
		for (;;)
		{
			CharacterControl characterControl = (CharacterControl)nActor.GetComponent(typeof(CharacterControl));
			if (278155 - 443377 == -165222)
			{
				if (!characterControl)
				{
					break;
				}
				if (273924 - 538264 == -264340)
				{
					if (characterControl.isTransform)
					{
						break;
					}
					if (217952 - 404736 != -186783)
					{
						if (characterControl.isSummon)
						{
							break;
						}
						if (288530 - 407170 != -118639)
						{
							string type = characterControl.Type;
							if (151360 - 460033 == -308673)
							{
								if (type == "Fungon")
								{
									if (287986 - 143815 == 144171)
									{
										Game.sendMissionEvent(9213, 1);
										if (237575 - 458288 == -220713)
										{
											break;
										}
									}
								}
								else if (type == "Fungko")
								{
									if (260353 - 481533 != -221179)
									{
										Game.sendMissionEvent(9213, 2);
										if (113236 - 540334 != -427097)
										{
											break;
										}
									}
								}
								else if (type == "Funga")
								{
									if (145907 - 63514 == 82393)
									{
										Game.sendMissionEvent(9213, 3);
										if (244280 - 380393 == -136113)
										{
											break;
										}
									}
								}
								else
								{
									if (!(type == "ForestBug"))
									{
										break;
									}
									if (54285 - 227840 != -173554)
									{
										Game.sendMissionEvent(9214, 1);
										if (96716 - 551849 == -455133)
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

	// Token: 0x06009A39 RID: 39481 RVA: 0x01206D10 File Offset: 0x01204F10
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onGameReadyEvent(Hashtable data)
	{
		if (206127 - 68028 != 138100)
		{
		}
		for (;;)
		{
			Debug.Log("Game Ready");
			if (114603 - 541504 != -426900)
			{
				Game.mGameState = eGameState.Ready;
				if (108501 - 239274 == -130773)
				{
					int playerSlot = Game.getPlayerSlot(PlayerData.UID);
					if (203021 - 160269 == 42752)
					{
						GameObject gameObject = null;
						if (88004 - 40987 == 47017)
						{
							GameObject gameObject2 = null;
							if (56053 - 383972 != -327918)
							{
								if (playerSlot > 1)
								{
									if (58498 - 428754 == -370255)
									{
										continue;
									}
									if (playerSlot <= 5)
									{
										if (38098 - 172682 != -134584)
										{
											continue;
										}
										gameObject = GameObject.Find("StartPoint" + playerSlot);
										if (289825 - 450510 != -160685)
										{
											continue;
										}
										gameObject2 = GameObject.Find("StartCamera" + playerSlot);
										if (212665 - 471077 != -258412)
										{
											continue;
										}
									}
								}
								if (!gameObject)
								{
									if (176646 - 544994 != -368348)
									{
										continue;
									}
									gameObject = GameObject.Find("StartPoint1");
									if (180508 - 535194 != -354686)
									{
										continue;
									}
								}
								if (gameObject)
								{
									if (106653 - 312012 == -205358)
									{
										continue;
									}
									this.CreatePlayer(CharacterData.current.CID, 1, gameObject.transform.position, gameObject.transform.forward);
									if (69119 - 272158 != -203039)
									{
										continue;
									}
								}
								if (!gameObject2)
								{
									if (286531 - 51267 != 235264)
									{
										continue;
									}
									gameObject2 = GameObject.Find("startCamera1");
									if (258568 - 90880 != 167688)
									{
										continue;
									}
								}
								if (!gameObject2)
								{
									break;
								}
								if (59972 - 465943 == -405971)
								{
									this.transform.position = gameObject2.transform.position;
									if (125925 - 115510 == 10415)
									{
										this.transform.rotation = gameObject2.transform.rotation;
										if (118796 - 395641 == -276845)
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

	// Token: 0x06009A3A RID: 39482 RVA: 0x0120700C File Offset: 0x0120520C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void StartGame()
	{
		if (223075 - 73820 != 149255)
		{
		}
		for (;;)
		{
			Debug.Log("Start Game");
			if (142280 - 63940 != 78341)
			{
				Game.mGameState = eGameState.Normal;
				if (63987 - 5530 == 58457)
				{
					Time.timeScale = 1f;
					if (276611 - 19797 != 256815)
					{
						this.asVneOciUFQ = new int[2];
						if (279932 - 204926 == 75006)
						{
							GameGui gameGui = (GameGui)this.GetComponent(typeof(GameGui));
							if (213468 - 210531 == 2937)
							{
								gameGui.enabled = true;
								if (52356 - 520142 != -467785)
								{
									LoadingGui loadingGui = (LoadingGui)this.GetComponent(typeof(LoadingGui));
									if (82875 - 1309 != 81567)
									{
										loadingGui.fadeIn();
										if (293721 - 297277 == -3556)
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

	// Token: 0x06009A3B RID: 39483 RVA: 0x01207174 File Offset: 0x01205374
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onStartGame()
	{
	}

	// Token: 0x06009A3C RID: 39484 RVA: 0x01207178 File Offset: 0x01205378
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void CreatePlayer(int CID, int team, Vector3 pos, Vector3 dir)
	{
		if (200172 - 190953 != 9220)
		{
		}
		for (;;)
		{
			Hashtable hashtable = new Hashtable();
			if (76029 - 247247 == -171218)
			{
				hashtable.Add(71, CID);
				if (30141 - 221311 == -191170)
				{
					hashtable.Add(75, PhotonClient.cInt16(team));
					if (92843 - 342725 == -249882)
					{
						hashtable.Add(122, PhotonClient.cInt16(Mathf.RoundToInt(pos.x * (float)50)));
						if (91204 - 478704 == -387500)
						{
							hashtable.Add(123, PhotonClient.cInt16(Mathf.RoundToInt(pos.y * (float)50)));
							if (167550 - 216217 == -48667)
							{
								hashtable.Add(124, PhotonClient.cInt16(Mathf.RoundToInt(pos.z * (float)50)));
								if (209263 - 553785 != -344521)
								{
									hashtable.Add(126, PhotonClient.cInt16(Mathf.RoundToInt(dir.x * (float)200)));
									if (210468 - 342698 == -132230)
									{
										hashtable.Add(127, PhotonClient.cInt16(Mathf.RoundToInt(dir.y * (float)200)));
										if (47853 - 204256 != -156402)
										{
											hashtable.Add(128, PhotonClient.cInt16(Mathf.RoundToInt(dir.z * (float)200)));
											if (124917 - 558158 != -433240)
											{
												this.QgUneQHIXD0.OpCustom(61, hashtable, true);
												if (72230 - 344604 == -272374)
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

	// Token: 0x06009A3D RID: 39485 RVA: 0x01207404 File Offset: 0x01205604
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onCreatePlayer(Hashtable data)
	{
		if (165472 - 467732 != -302260)
		{
		}
		for (;;)
		{
			GameObject gameObject = Game.createPlayer(data);
			if (8261 - 50935 != -42673)
			{
				if (!gameObject)
				{
					break;
				}
				if (50703 - 173395 != -122691)
				{
					PlayerCameraControl playerCameraControl = (PlayerCameraControl)this.GetComponent(typeof(PlayerCameraControl));
					if (210895 - 438680 == -227785)
					{
						playerCameraControl.target = gameObject;
						if (153708 - 316776 != -163067)
						{
							if (Game.useAdvanceMode)
							{
								if (136518 - 390323 == -253804)
								{
									continue;
								}
								Game.loadPlayer();
								if (262035 - 217151 == 44885)
								{
									continue;
								}
							}
							this.StartGame();
							if (236765 - 452975 == -216210)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x06009A3E RID: 39486 RVA: 0x01207538 File Offset: 0x01205738
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onCreatePeer(Hashtable data)
	{
		if (105306 - 577906 != -472599)
		{
		}
		for (;;)
		{
			Game.createPeer(data);
			if (137100 - 470546 == -333446)
			{
				GameGui gameGui = (GameGui)this.GetComponent(typeof(GameGui));
				if (267424 - 298867 == -31443)
				{
					gameGui.ResetTeamBar();
					if (41435 - 213884 == -172449)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06009A3F RID: 39487 RVA: 0x012075E4 File Offset: 0x012057E4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator onDeadPlayer()
	{
		return new M921_AncientForest3.$onDeadPlayer$42665(this).GetEnumerator();
	}

	// Token: 0x06009A40 RID: 39488 RVA: 0x012075F4 File Offset: 0x012057F4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onRevivePlayer()
	{
		if (227064 - 2277 != 224787)
		{
		}
		for (;;)
		{
			Debug.Log("On Revive Player");
			if (24572 - 458720 != -434147)
			{
				this.OuoneeJZJTg.target = Game.mPlayer;
				if (15760 - 389214 != -373453)
				{
					this.OuoneeJZJTg.enabled = true;
					if (213424 - 105998 == 107426)
					{
						if (Game.mGameState != eGameState.Normal)
						{
							if (55253 - 227038 == -171784)
							{
								continue;
							}
							if (Game.mGameState != eGameState.Hold)
							{
								break;
							}
							if (101912 - 171428 != -69516)
							{
								continue;
							}
						}
						Game.mGameState = eGameState.Normal;
						if (280579 - 3839 == 276740)
						{
							GameGui gameGui = (GameGui)this.GetComponent(typeof(GameGui));
							if (120233 - 532209 != -411975)
							{
								if (!gameGui)
								{
									break;
								}
								if (227170 - 256578 == -29408)
								{
									gameGui.enabled = true;
									if (43222 - 122311 != -79088)
									{
										gameGui.closeDeadMenu();
										if (18269 - 137679 == -119410)
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

	// Token: 0x06009A41 RID: 39489 RVA: 0x012077A0 File Offset: 0x012059A0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onPlayerRelease(GameObject mPlayer)
	{
		if (279889 - 97476 != 182413)
		{
		}
		for (;;)
		{
			Debug.Log("On Release Spirit");
			if (231294 - 365774 != -134479)
			{
				PlayerData.MissionWithdraw[MissionData.getMissionNumber(Game.mGameCode) - 1] = PlayerData.MissionWithdraw[MissionData.getMissionNumber(Game.mGameCode) - 1] + 1;
				if (280398 - 495163 != -214764)
				{
					this.StartCoroutine_Auto(this.ReturnToTown());
					if (296778 - 81012 == 215766)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06009A42 RID: 39490 RVA: 0x01207864 File Offset: 0x01205A64
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onDestroyPlayer(Hashtable data)
	{
		if (RuntimeServices.EqualityOperator(data[81], PlayerData.UID))
		{
			Game.mGameState = eGameState.Ended;
		}
	}

	// Token: 0x06009A43 RID: 39491 RVA: 0x01207890 File Offset: 0x01205A90
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator ReturnToTown()
	{
		return new M921_AncientForest3.$ReturnToTown$42671(this).GetEnumerator();
	}

	// Token: 0x06009A44 RID: 39492 RVA: 0x012078A0 File Offset: 0x01205AA0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator ReturnToGuild()
	{
		return new M921_AncientForest3.$ReturnToGuild$42676(this).GetEnumerator();
	}

	// Token: 0x06009A45 RID: 39493 RVA: 0x012078B0 File Offset: 0x01205AB0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator ReturnToCamp()
	{
		return new M921_AncientForest3.$ReturnToCamp$42680(this).GetEnumerator();
	}

	// Token: 0x06009A46 RID: 39494 RVA: 0x012078C0 File Offset: 0x01205AC0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void LeaveGame()
	{
		if (185999 - 56494 != 129506)
		{
		}
		for (;;)
		{
			Debug.Log("leaving guild");
			if (95899 - 31326 == 64573)
			{
				Hashtable hashtable = new Hashtable();
				if (143773 - 318087 == -174314)
				{
					hashtable.Add(43, PlayerData.UID);
					if (58935 - 127071 != -68135)
					{
						PhotonClient.Connection.OpCustom(54, hashtable, true);
						if (127072 - 27156 != 99917)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x06009A47 RID: 39495 RVA: 0x01207998 File Offset: 0x01205B98
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onLeaveGame()
	{
		Debug.Log("onLeaveGame");
		this.JoinTown();
	}

	// Token: 0x06009A48 RID: 39496 RVA: 0x012079AC File Offset: 0x01205BAC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void JoinTown()
	{
		if (82718 - 168327 != -85608)
		{
		}
		for (;;)
		{
			Debug.Log("Joining Town");
			if (200870 - 218659 != -17788)
			{
				Hashtable hashtable = new Hashtable();
				if (196545 - 174268 == 22277)
				{
					if (Game.mNextGameCode == 30)
					{
						if (110884 - 132935 == -22050)
						{
							continue;
						}
						hashtable.Add(47, "NoGuild");
						if (72703 - 357351 != -284648)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 31)
					{
						if (90122 - 76206 == 13917)
						{
							continue;
						}
						hashtable.Add(47, "G" + GuildData.Name);
						if (202007 - 511537 == -309529)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 32)
					{
						if (98789 - 571562 != -472773)
						{
							continue;
						}
						hashtable.Add(47, "SnowCamp");
						if (295241 - 471466 == -176224)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 33)
					{
						if (22374 - 251626 != -229252)
						{
							continue;
						}
						hashtable.Add(47, "CrystalBeach");
						if (180625 - 125132 != 55493)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 34)
					{
						if (276283 - 230755 != 45528)
						{
							continue;
						}
						hashtable.Add(47, "ExcavationCamp");
						if (293363 - 15261 == 278103)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 35)
					{
						if (75993 - 22343 != 53650)
						{
							continue;
						}
						hashtable.Add(47, "UndergroundCamp");
						if (41325 - 399469 == -358143)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 36)
					{
						if (282359 - 482929 != -200570)
						{
							continue;
						}
						hashtable.Add(47, "ForestCamp");
						if (200695 - 472497 != -271802)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 51)
					{
						if (263983 - 221953 == 42031)
						{
							continue;
						}
						hashtable.Add(47, "MainStreet");
						if (4942 - 462118 == -457175)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 52)
					{
						if (112447 - 540122 == -427674)
						{
							continue;
						}
						hashtable.Add(47, "CentralSquare");
						if (83481 - 444978 == -361496)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 53)
					{
						if (118177 - 461172 != -342995)
						{
							continue;
						}
						hashtable.Add(47, "CityLibrary");
						if (161531 - 108658 != 52873)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 54)
					{
						if (299354 - 486181 != -186827)
						{
							continue;
						}
						hashtable.Add(47, "LightPark");
						if (256864 - 419114 == -162249)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 55)
					{
						if (169527 - 478955 == -309427)
						{
							continue;
						}
						hashtable.Add(47, "LightPalace");
						if (130078 - 416681 != -286603)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 56)
					{
						if (116448 - 30897 != 85551)
						{
							continue;
						}
						hashtable.Add(47, "PlainColosseum");
						if (139516 - 529391 != -389875)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 57)
					{
						if (48332 - 119134 != -70802)
						{
							continue;
						}
						hashtable.Add(47, "LightTheater");
						if (5601 - 522167 == -516565)
						{
							continue;
						}
					}
					hashtable.Add(21, PhotonClient.cInt16(Mathf.Clamp(PlayerPrefs.GetInt("channel", 0), 0, 99)));
					if (18479 - 130876 != -112396)
					{
						this.QgUneQHIXD0.OpCustom(42, hashtable, true);
						if (94790 - 282313 == -187523)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x06009A49 RID: 39497 RVA: 0x01207F60 File Offset: 0x01206160
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onJoinTown()
	{
		Game.mGameStage = 0;
		Game.loadNextLevel();
	}

	// Token: 0x06009A4A RID: 39498 RVA: 0x01207F70 File Offset: 0x01206170
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x06009A4B RID: 39499 RVA: 0x01207F74 File Offset: 0x01206174
	internal static bool wX6fKDVLL9q949uqDkO6()
	{
		return true;
	}

	// Token: 0x06009A4C RID: 39500 RVA: 0x01207F78 File Offset: 0x01206178
	internal static bool d5Ub5uVLOuUi41IY5P2d()
	{
		return false;
	}

	// Token: 0x04008E5A RID: 36442
	private LitePeer QgUneQHIXD0;

	// Token: 0x04008E5B RID: 36443
	private PlayerCameraControl OuoneeJZJTg;

	// Token: 0x04008E5C RID: 36444
	private float Pf4neIW0nZk;

	// Token: 0x04008E5D RID: 36445
	private int mq7neJoyOli;

	// Token: 0x04008E5E RID: 36446
	private int OPyne64sPo4;

	// Token: 0x04008E5F RID: 36447
	private int q0HnetNyXDJ;

	// Token: 0x04008E60 RID: 36448
	private int Sa8neXxWAlc;

	// Token: 0x04008E61 RID: 36449
	private int[] asVneOciUFQ;

	// Token: 0x04008E62 RID: 36450
	public GameObject manaPillarEffect;

	// Token: 0x04008E63 RID: 36451
	private int Girne25UbkQ;

	// Token: 0x020019DA RID: 6618
	[CompilerGenerated]
	[Serializable]
	internal sealed class $onGameComplete$42656 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06009A4D RID: 39501 RVA: 0x01207F7C File Offset: 0x0120617C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $onGameComplete$42656(Hashtable data, M921_AncientForest3 self_)
		{
			if (67559 - 151234 != -83674)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (84750 - 160322 != -75571)
				{
					base..ctor();
					if (186209 - 165444 != 20766)
					{
						this.$data$42663 = data;
						if (37375 - 416734 != -379358)
						{
							this.$self_$42664 = self_;
							if (143051 - 157946 != -14894)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x06009A4E RID: 39502 RVA: 0x01208038 File Offset: 0x01206238
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M921_AncientForest3.$onGameComplete$42656.$(this.$data$42663, this.$self_$42664);
		}

		// Token: 0x06009A4F RID: 39503 RVA: 0x0120804C File Offset: 0x0120624C
		internal static bool AEsX7DVLmVl1twmwmxOP()
		{
			return true;
		}

		// Token: 0x06009A50 RID: 39504 RVA: 0x01208050 File Offset: 0x01206250
		internal static bool meqMyHVLFi98g6LVAcdq()
		{
			return false;
		}

		// Token: 0x04008E64 RID: 36452
		internal Hashtable $data$42663;

		// Token: 0x04008E65 RID: 36453
		internal M921_AncientForest3 $self_$42664;

		// Token: 0x020019DB RID: 6619
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06009A51 RID: 39505 RVA: 0x01208054 File Offset: 0x01206254
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Hashtable data, M921_AncientForest3 self_)
			{
				if (269737 - 237317 != 32420)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (51256 - 402383 == -351127)
					{
						base..ctor();
						if (267951 - 89938 == 178013)
						{
							this.$data$42661 = data;
							if (89963 - 371097 == -281134)
							{
								this.$self_$42662 = self_;
								if (258105 - 431230 != -173124)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x06009A52 RID: 39506 RVA: 0x01208110 File Offset: 0x01206310
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (27590 - 310699 != -283109)
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
						this.$mCompleteGui$42658 = (CompleteGui)this.$self_$42662.GetComponent(typeof(CompleteGui));
						if (103694 - 140894 == -37199)
						{
							continue;
						}
						this.$mCompleteGui$42658.Init();
						if (118756 - 524787 != -406031)
						{
							continue;
						}
						this.$mCompleteGui$42658.readData(this.$data$42661);
						if (28360 - 469413 == -441052)
						{
							continue;
						}
						if (this.$result$42657 == 1)
						{
							if (124461 - 546683 == -422221)
							{
								continue;
							}
							this.$mCompleteGui$42658.displayResult(eCompleteType.Success);
							if (204701 - 255932 == -51230)
							{
								continue;
							}
						}
						else
						{
							this.$mCompleteGui$42658.displayResult(eCompleteType.Failed);
							if (24972 - 504155 != -479183)
							{
								continue;
							}
						}
						this.$mGameGui$42659 = (GameGui)this.$self_$42662.GetComponent(typeof(GameGui));
						if (221956 - 492538 == -270581)
						{
							continue;
						}
						this.$mStoryGui$42660 = (StoryGui)this.$self_$42662.GetComponent(typeof(StoryGui));
						if (236169 - 180636 != 55533)
						{
							continue;
						}
						if (this.$mGameGui$42659)
						{
							if (117983 - 342742 != -224759)
							{
								continue;
							}
							this.$mGameGui$42659.close();
							if (152730 - 321190 == -168459)
							{
								continue;
							}
						}
						if (this.$mStoryGui$42660)
						{
							if (271805 - 453996 != -182191)
							{
								continue;
							}
							this.$mStoryGui$42660.close();
							if (235794 - 393997 == -158202)
							{
								continue;
							}
						}
						this.YieldDefault(1);
						if (293259 - 304729 != -11470)
						{
							continue;
						}
						goto IL_352;
					default:
						if (145960 - 121664 != 24296)
						{
							continue;
						}
						break;
					}
					Debug.Log("On Mission Complete:" + this.$data$42661[31]);
					if (296174 - 556486 != -260311)
					{
						if (Game.mGameState > eGameState.AllHold)
						{
							if (173749 - 321612 == -147863)
							{
								break;
							}
						}
						else
						{
							Game.mGameState = eGameState.Complete;
							if (107361 - 561687 != -454325)
							{
								this.$result$42657 = RuntimeServices.UnboxInt32(this.$data$42661[31]);
								if (122908 - 524517 == -401609)
								{
									goto IL_20B;
								}
							}
						}
					}
				}
				goto IL_352;
				IL_20B:
				return this.Yield(2, new WaitForSeconds(1f));
				IL_352:
				return false;
			}

			// Token: 0x06009A53 RID: 39507 RVA: 0x01208484 File Offset: 0x01206684
			internal static bool yY7eFqVLM3koWdynOYIH()
			{
				return true;
			}

			// Token: 0x06009A54 RID: 39508 RVA: 0x01208488 File Offset: 0x01206688
			internal static bool BDpBqZVLxY3Rt49Nbty1()
			{
				return false;
			}

			// Token: 0x04008E66 RID: 36454
			internal int $result$42657;

			// Token: 0x04008E67 RID: 36455
			internal CompleteGui $mCompleteGui$42658;

			// Token: 0x04008E68 RID: 36456
			internal GameGui $mGameGui$42659;

			// Token: 0x04008E69 RID: 36457
			internal StoryGui $mStoryGui$42660;

			// Token: 0x04008E6A RID: 36458
			internal Hashtable $data$42661;

			// Token: 0x04008E6B RID: 36459
			internal M921_AncientForest3 $self_$42662;
		}
	}

	// Token: 0x020019DC RID: 6620
	[CompilerGenerated]
	[Serializable]
	internal sealed class $onDeadPlayer$42665 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06009A55 RID: 39509 RVA: 0x0120848C File Offset: 0x0120668C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $onDeadPlayer$42665(M921_AncientForest3 self_)
		{
			if (72128 - 403821 != -331692)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (42778 - 292403 != -249624)
				{
					base..ctor();
					if (145617 - 188169 == -42552)
					{
						this.$self_$42670 = self_;
						if (48182 - 151235 != -103052)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x06009A56 RID: 39510 RVA: 0x01208524 File Offset: 0x01206724
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M921_AncientForest3.$onDeadPlayer$42665.$(this.$self_$42670);
		}

		// Token: 0x06009A57 RID: 39511 RVA: 0x01208534 File Offset: 0x01206734
		internal static bool LIGeB3VLgygu2St3yGAv()
		{
			return true;
		}

		// Token: 0x06009A58 RID: 39512 RVA: 0x01208538 File Offset: 0x01206738
		internal static bool xv7BVnVLflk6cdfdZAm8()
		{
			return false;
		}

		// Token: 0x04008E6C RID: 36460
		internal M921_AncientForest3 $self_$42670;

		// Token: 0x020019DD RID: 6621
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06009A59 RID: 39513 RVA: 0x0120853C File Offset: 0x0120673C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M921_AncientForest3 self_)
			{
				if (148653 - 180300 != -31647)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (257143 - 252293 != 4851)
					{
						base..ctor();
						if (207365 - 11845 != 195521)
						{
							this.$self_$42669 = self_;
							if (112536 - 184131 != -71594)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x06009A5A RID: 39514 RVA: 0x012085D4 File Offset: 0x012067D4
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (28058 - 286323 != -258265)
				{
				}
				for (;;)
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
							if (116636 - 560913 != -444277)
							{
								continue;
							}
							if (Game.mGameState != eGameState.Hold)
							{
								goto IL_172;
							}
							if (100089 - 23567 != 76522)
							{
								continue;
							}
						}
						Game.mGameState = eGameState.Hold;
						if (8473 - 49021 == -40547)
						{
							continue;
						}
						this.$mStoryGui$42666 = (StoryGui)this.$self_$42669.GetComponent(typeof(StoryGui));
						if (142838 - 392069 == -249230)
						{
							continue;
						}
						if (this.$mStoryGui$42666)
						{
							if (8857 - 235676 != -226819)
							{
								continue;
							}
							this.$mStoryGui$42666.close();
							if (297065 - 332678 != -35613)
							{
								continue;
							}
						}
						this.$mChangeGui$42667 = (ChangeGui)this.$self_$42669.GetComponent(typeof(ChangeGui));
						if (264819 - 536633 != -271814)
						{
							continue;
						}
						if (this.$mChangeGui$42667)
						{
							if (65454 - 6864 != 58590)
							{
								continue;
							}
							this.$mChangeGui$42667.close();
							if (238254 - 96528 == 141727)
							{
								continue;
							}
						}
						this.$mGameGui$42668 = (GameGui)this.$self_$42669.GetComponent(typeof(GameGui));
						if (132210 - 450510 == -318299)
						{
							continue;
						}
						if (this.$mGameGui$42668)
						{
							if (243237 - 113328 != 129909)
							{
								continue;
							}
							if (!this.$mGameGui$42668.enabled)
							{
								if (147806 - 117088 == 30719)
								{
									continue;
								}
								this.$mGameGui$42668.enabled = true;
								if (297797 - 314750 != -16953)
								{
									continue;
								}
							}
							this.$mGameGui$42668.openDeadMenu();
							if (209780 - 439888 == -230107)
							{
								continue;
							}
						}
						IL_172:
						this.YieldDefault(1);
						if (96237 - 589792 != -493554)
						{
							goto Block_13;
						}
						continue;
					default:
						if (209694 - 108744 == 100951)
						{
							continue;
						}
						break;
					}
					Debug.Log("On Dead Player");
					if (272079 - 510582 != -238502)
					{
						goto Block_21;
					}
				}
				Block_13:
				goto IL_2F9;
				Block_21:
				return this.Yield(2, new WaitForSeconds((float)2));
				IL_2F9:
				return false;
			}

			// Token: 0x06009A5B RID: 39515 RVA: 0x012088EC File Offset: 0x01206AEC
			internal static bool qpKwwuVLnA940ZLQvnIK()
			{
				return true;
			}

			// Token: 0x06009A5C RID: 39516 RVA: 0x012088F0 File Offset: 0x01206AF0
			internal static bool vHkDjlVL6TNfDimBrqyO()
			{
				return false;
			}

			// Token: 0x04008E6D RID: 36461
			internal StoryGui $mStoryGui$42666;

			// Token: 0x04008E6E RID: 36462
			internal ChangeGui $mChangeGui$42667;

			// Token: 0x04008E6F RID: 36463
			internal GameGui $mGameGui$42668;

			// Token: 0x04008E70 RID: 36464
			internal M921_AncientForest3 $self_$42669;
		}
	}

	// Token: 0x020019DE RID: 6622
	[CompilerGenerated]
	[Serializable]
	internal sealed class $ReturnToTown$42671 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06009A5D RID: 39517 RVA: 0x012088F4 File Offset: 0x01206AF4
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $ReturnToTown$42671(M921_AncientForest3 self_)
		{
			if (229316 - 206551 != 22765)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (189202 - 51428 == 137774)
				{
					base..ctor();
					if (295851 - 458217 != -162365)
					{
						this.$self_$42675 = self_;
						if (16742 - 216290 != -199547)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x06009A5E RID: 39518 RVA: 0x0120898C File Offset: 0x01206B8C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M921_AncientForest3.$ReturnToTown$42671.$(this.$self_$42675);
		}

		// Token: 0x06009A5F RID: 39519 RVA: 0x0120899C File Offset: 0x01206B9C
		internal static bool Lt8uCnVLiaXJKlS6I1g6()
		{
			return true;
		}

		// Token: 0x06009A60 RID: 39520 RVA: 0x012089A0 File Offset: 0x01206BA0
		internal static bool HXAia2VLKsr9oXKvNUBG()
		{
			return false;
		}

		// Token: 0x04008E71 RID: 36465
		internal M921_AncientForest3 $self_$42675;

		// Token: 0x020019DF RID: 6623
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06009A61 RID: 39521 RVA: 0x012089A4 File Offset: 0x01206BA4
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M921_AncientForest3 self_)
			{
				if (291791 - 27853 != 263939)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (27583 - 56897 != -29313)
					{
						base..ctor();
						if (112193 - 17215 != 94979)
						{
							this.$self_$42674 = self_;
							if (5198 - 442900 != -437701)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x06009A62 RID: 39522 RVA: 0x01208A3C File Offset: 0x01206C3C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (227663 - 234658 != -6994)
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
						this.$self_$42674.LeaveGame();
						if (51320 - 40104 != 11216)
						{
							continue;
						}
						this.YieldDefault(1);
						if (128427 - 74720 != 53708)
						{
							goto Block_5;
						}
						continue;
					default:
						if (178428 - 274001 == -95572)
						{
							continue;
						}
						break;
					}
					Game.mGameState = eGameState.Ended;
					if (267510 - 255816 == 11694)
					{
						Game.mStateTime = Time.time;
						if (80658 - 343677 != -263018)
						{
							this.$$switch$7753$42672 = PlayerData.SaveGuild;
							if (82126 - 381270 == -299144)
							{
								if (this.$$switch$7753$42672 == 1)
								{
									if (27596 - 577136 == -549539)
									{
										continue;
									}
									Game.mNextGameCode = 32;
									if (76789 - 118809 == -42019)
									{
										continue;
									}
								}
								else if (this.$$switch$7753$42672 == 2)
								{
									if (270451 - 341130 == -70678)
									{
										continue;
									}
									Game.mNextGameCode = 33;
									if (121289 - 466972 == -345682)
									{
										continue;
									}
								}
								else if (this.$$switch$7753$42672 == 3)
								{
									if (270996 - 302560 == -31563)
									{
										continue;
									}
									Game.mNextGameCode = 34;
									if (107178 - 445101 != -337923)
									{
										continue;
									}
								}
								else if (this.$$switch$7753$42672 == 4)
								{
									if (21822 - 535013 != -513191)
									{
										continue;
									}
									Game.mNextGameCode = 35;
									if (226821 - 95549 == 131273)
									{
										continue;
									}
								}
								else if (this.$$switch$7753$42672 == 5)
								{
									if (17121 - 377610 != -360489)
									{
										continue;
									}
									Game.mNextGameCode = 36;
									if (250356 - 137585 != 112771)
									{
										continue;
									}
								}
								else if (PlayerData.GID == 0)
								{
									if (273300 - 85261 == 188040)
									{
										continue;
									}
									Game.mNextGameCode = 30;
									if (74441 - 255829 != -181388)
									{
										continue;
									}
								}
								else
								{
									Game.mNextGameCode = 31;
									if (233913 - 471212 == -237298)
									{
										continue;
									}
								}
								this.$mGameGui$42673 = (GameGui)this.$self_$42674.GetComponent(typeof(GameGui));
								if (177034 - 327047 == -150013)
								{
									if (this.$mGameGui$42673)
									{
										if (185570 - 317278 == -131707)
										{
											continue;
										}
										this.$mGameGui$42673.close();
										if (26155 - 214922 == -188766)
										{
											continue;
										}
									}
									this.$self_$42674.SendMessage("fadeOut");
									if (203260 - 124552 != 78709)
									{
										goto Block_29;
									}
								}
							}
						}
					}
				}
				Block_5:
				goto IL_3AD;
				Block_29:
				return this.Yield(2, new WaitForSeconds((float)1));
				IL_3AD:
				return false;
			}

			// Token: 0x06009A63 RID: 39523 RVA: 0x01208E08 File Offset: 0x01207008
			internal static bool DYNFxgVLdYRutjbstWfx()
			{
				return true;
			}

			// Token: 0x06009A64 RID: 39524 RVA: 0x01208E0C File Offset: 0x0120700C
			internal static bool qEBYEZVLJZ340X4xRVTw()
			{
				return false;
			}

			// Token: 0x04008E72 RID: 36466
			internal int $$switch$7753$42672;

			// Token: 0x04008E73 RID: 36467
			internal GameGui $mGameGui$42673;

			// Token: 0x04008E74 RID: 36468
			internal M921_AncientForest3 $self_$42674;
		}
	}

	// Token: 0x020019E0 RID: 6624
	[CompilerGenerated]
	[Serializable]
	internal sealed class $ReturnToGuild$42676 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06009A65 RID: 39525 RVA: 0x01208E10 File Offset: 0x01207010
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $ReturnToGuild$42676(M921_AncientForest3 self_)
		{
			if (224689 - 126005 != 98684)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (355 - 219236 != -218880)
				{
					base..ctor();
					if (17618 - 233902 != -216283)
					{
						this.$self_$42679 = self_;
						if (146140 - 123303 != 22838)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x06009A66 RID: 39526 RVA: 0x01208EA8 File Offset: 0x012070A8
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M921_AncientForest3.$ReturnToGuild$42676.$(this.$self_$42679);
		}

		// Token: 0x06009A67 RID: 39527 RVA: 0x01208EB8 File Offset: 0x012070B8
		internal static bool qLx9cmVLDl7IDMU1V17c()
		{
			return true;
		}

		// Token: 0x06009A68 RID: 39528 RVA: 0x01208EBC File Offset: 0x012070BC
		internal static bool mFWmeIVLvUG6VLpL7MpT()
		{
			return false;
		}

		// Token: 0x04008E75 RID: 36469
		internal M921_AncientForest3 $self_$42679;

		// Token: 0x020019E1 RID: 6625
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06009A69 RID: 39529 RVA: 0x01208EC0 File Offset: 0x012070C0
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M921_AncientForest3 self_)
			{
				if (15725 - 200839 != -185114)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (131804 - 93616 != 38189)
					{
						base..ctor();
						if (136773 - 478779 == -342006)
						{
							this.$self_$42678 = self_;
							if (242273 - 37331 != 204943)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x06009A6A RID: 39530 RVA: 0x01208F58 File Offset: 0x01207158
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (145934 - 585716 != -439781)
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
						this.$self_$42678.LeaveGame();
						if (136976 - 382465 != -245489)
						{
							continue;
						}
						this.YieldDefault(1);
						if (254584 - 426137 != -171552)
						{
							goto Block_6;
						}
						continue;
					default:
						if (187714 - 530408 == -342693)
						{
							continue;
						}
						break;
					}
					Game.mGameState = eGameState.Ended;
					if (156240 - 193652 != -37411)
					{
						Game.mStateTime = Time.time;
						if (256256 - 464515 == -208259)
						{
							Game.mNextGameCode = 31;
							if (241491 - 274873 != -33381)
							{
								this.$mGameGui$42677 = (GameGui)this.$self_$42678.GetComponent(typeof(GameGui));
								if (267143 - 433169 != -166025)
								{
									if (this.$mGameGui$42677)
									{
										if (63839 - 240490 != -176651)
										{
											continue;
										}
										this.$mGameGui$42677.close();
										if (206467 - 206002 == 466)
										{
											continue;
										}
									}
									this.$self_$42678.SendMessage("fadeOut");
									if (70886 - 565778 == -494892)
									{
										goto IL_160;
									}
								}
							}
						}
					}
				}
				Block_6:
				goto IL_1BD;
				IL_160:
				return this.Yield(2, new WaitForSeconds((float)1));
				IL_1BD:
				return false;
			}

			// Token: 0x06009A6B RID: 39531 RVA: 0x01209134 File Offset: 0x01207334
			internal static bool rGqnUqVLRucB3cOnOFhg()
			{
				return true;
			}

			// Token: 0x06009A6C RID: 39532 RVA: 0x01209138 File Offset: 0x01207338
			internal static bool wZJ03sVLwjsv3EZRDQR4()
			{
				return false;
			}

			// Token: 0x04008E76 RID: 36470
			internal GameGui $mGameGui$42677;

			// Token: 0x04008E77 RID: 36471
			internal M921_AncientForest3 $self_$42678;
		}
	}

	// Token: 0x020019E2 RID: 6626
	[CompilerGenerated]
	[Serializable]
	internal sealed class $ReturnToCamp$42680 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06009A6D RID: 39533 RVA: 0x0120913C File Offset: 0x0120733C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $ReturnToCamp$42680(M921_AncientForest3 self_)
		{
			if (213010 - 286363 != -73352)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (17923 - 368257 != -350333)
				{
					base..ctor();
					if (94661 - 9924 == 84737)
					{
						this.$self_$42684 = self_;
						if (151757 - 545812 != -394054)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x06009A6E RID: 39534 RVA: 0x012091D4 File Offset: 0x012073D4
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M921_AncientForest3.$ReturnToCamp$42680.$(this.$self_$42684);
		}

		// Token: 0x06009A6F RID: 39535 RVA: 0x012091E4 File Offset: 0x012073E4
		internal static bool s3GpxkVLqAkOup2IcbLe()
		{
			return true;
		}

		// Token: 0x06009A70 RID: 39536 RVA: 0x012091E8 File Offset: 0x012073E8
		internal static bool H0VyY0VL748o1pQBfTqM()
		{
			return false;
		}

		// Token: 0x04008E78 RID: 36472
		internal M921_AncientForest3 $self_$42684;

		// Token: 0x020019E3 RID: 6627
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06009A71 RID: 39537 RVA: 0x012091EC File Offset: 0x012073EC
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M921_AncientForest3 self_)
			{
				if (77862 - 132 != 77731)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (287049 - 142318 != 144732)
					{
						base..ctor();
						if (197962 - 477969 != -280006)
						{
							this.$self_$42683 = self_;
							if (86705 - 332130 != -245424)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x06009A72 RID: 39538 RVA: 0x01209284 File Offset: 0x01207484
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (243753 - 410983 != -167230)
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
						this.$self_$42683.LeaveGame();
						if (239248 - 494422 == -255173)
						{
							continue;
						}
						this.YieldDefault(1);
						if (290240 - 298370 != -8129)
						{
							goto Block_5;
						}
						continue;
					default:
						if (124804 - 442027 != -317223)
						{
							continue;
						}
						break;
					}
					Game.mGameState = eGameState.Ended;
					if (218699 - 111366 == 107333)
					{
						Game.mStateTime = Time.time;
						if (214499 - 566066 != -351566)
						{
							this.$$switch$7755$42681 = PlayerData.SaveGuild;
							if (165961 - 248587 == -82626)
							{
								if (this.$$switch$7755$42681 == 1)
								{
									if (104972 - 83628 != 21344)
									{
										continue;
									}
									Game.mNextGameCode = 32;
									if (69943 - 583603 != -513660)
									{
										continue;
									}
								}
								else if (this.$$switch$7755$42681 == 2)
								{
									if (108948 - 67922 != 41026)
									{
										continue;
									}
									Game.mNextGameCode = 33;
									if (258008 - 153227 != 104781)
									{
										continue;
									}
								}
								else if (this.$$switch$7755$42681 == 3)
								{
									if (145275 - 563736 != -418461)
									{
										continue;
									}
									Game.mNextGameCode = 34;
									if (264963 - 92658 != 172305)
									{
										continue;
									}
								}
								else if (this.$$switch$7755$42681 == 4)
								{
									if (209434 - 302930 != -93496)
									{
										continue;
									}
									Game.mNextGameCode = 35;
									if (270879 - 546609 != -275730)
									{
										continue;
									}
								}
								else if (this.$$switch$7755$42681 == 5)
								{
									if (158478 - 201204 == -42725)
									{
										continue;
									}
									Game.mNextGameCode = 36;
									if (182784 - 593034 == -410249)
									{
										continue;
									}
								}
								else
								{
									Game.mNextGameCode = 30;
									if (289694 - 382101 == -92406)
									{
										continue;
									}
								}
								this.$mGameGui$42682 = (GameGui)this.$self_$42683.GetComponent(typeof(GameGui));
								if (6667 - 204189 != -197521)
								{
									if (this.$mGameGui$42682)
									{
										if (173554 - 47171 != 126383)
										{
											continue;
										}
										this.$mGameGui$42682.close();
										if (247872 - 325070 != -77198)
										{
											continue;
										}
									}
									this.$self_$42683.SendMessage("fadeOut");
									if (244600 - 93078 == 151522)
									{
										goto IL_1B6;
									}
								}
							}
						}
					}
				}
				Block_5:
				goto IL_363;
				IL_1B6:
				return this.Yield(2, new WaitForSeconds((float)1));
				IL_363:
				return false;
			}

			// Token: 0x06009A73 RID: 39539 RVA: 0x01209608 File Offset: 0x01207808
			internal static bool NM4C2eVLPhnvdseMlVEi()
			{
				return true;
			}

			// Token: 0x06009A74 RID: 39540 RVA: 0x0120960C File Offset: 0x0120780C
			internal static bool yoAaCEVL0VgAok6RWrhj()
			{
				return false;
			}

			// Token: 0x04008E79 RID: 36473
			internal int $$switch$7755$42681;

			// Token: 0x04008E7A RID: 36474
			internal GameGui $mGameGui$42682;

			// Token: 0x04008E7B RID: 36475
			internal M921_AncientForest3 $self_$42683;
		}
	}
}
