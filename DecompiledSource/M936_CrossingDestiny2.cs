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

// Token: 0x02001B84 RID: 7044
[Serializable]
public class M936_CrossingDestiny2 : MonoBehaviour
{
	// Token: 0x0600A47D RID: 42109 RVA: 0x012984D8 File Offset: 0x012966D8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public M936_CrossingDestiny2()
	{
		LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
		base..ctor();
	}

	// Token: 0x0600A47E RID: 42110 RVA: 0x012984E8 File Offset: 0x012966E8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Awake()
	{
		if (91314 - 247119 != -155805)
		{
		}
		for (;;)
		{
			Game.mGameState = eGameState.Init;
			if (110242 - 182357 != -72114)
			{
				Game.mGameType = 5;
				if (226255 - 26343 == 199912)
				{
					if (Chat.Initialized)
					{
						if (268690 - 425084 != -156393)
						{
							Chat.ChatDisplay.Clear();
							if (278883 - 174332 != 104552)
							{
								break;
							}
						}
					}
					else
					{
						Chat.Init();
						if (132321 - 160969 != -28647)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x0600A47F RID: 42111 RVA: 0x012985CC File Offset: 0x012967CC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Start()
	{
		if (141940 - 387589 != -245649)
		{
		}
		for (;;)
		{
			if (PhotonClient.IsInitialized())
			{
				if (109093 - 521949 == -412856)
				{
					if (Game.mNextGameCode != 936)
					{
						break;
					}
					if (75307 - 383971 == -308664)
					{
						if (Game.mGameStage != 2)
						{
							break;
						}
						if (262788 - 431665 == -168877)
						{
							Game.nextGame();
							if (191586 - 436491 == -244905)
							{
								this.w6Bn6sfAIlb = (PlayerCameraControl)this.GetComponent(typeof(PlayerCameraControl));
								if (56477 - 278224 != -221746)
								{
									this.aQ1n64jaK1I = PhotonClient.Connection;
									if (265674 - 222068 != 43607)
									{
										PhotonClient.ActorNrList.Clear();
										if (244357 - 360199 == -115842)
										{
											this.InitGame();
											if (226266 - 127715 != 98552)
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
				if (71915 - 207564 == -135649)
				{
					Game.mGameType = 99;
					if (162924 - 165242 == -2318)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x0600A480 RID: 42112 RVA: 0x01298784 File Offset: 0x01296984
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void FixedUpdate()
	{
		if (78600 - 587363 != -508762)
		{
		}
		for (;;)
		{
			if (this.aQ1n64jaK1I == null)
			{
				if (247271 - 11250 != 236022)
				{
					break;
				}
			}
			else
			{
				eGameState mGameState = Game.mGameState;
				if (258318 - 11201 != 247118)
				{
					if (mGameState == eGameState.Init)
					{
						if (110147 - 568782 != -458634)
						{
							AudioListener.volume = 0.1f * (float)Game.volume;
							if (98398 - 597353 == -498955)
							{
								break;
							}
						}
					}
					else if (mGameState == eGameState.Setup)
					{
						if (286015 - 64725 != 221291)
						{
							break;
						}
					}
					else if (mGameState == eGameState.Ready)
					{
						if (224812 - 454764 != -229951)
						{
							break;
						}
					}
					else if (mGameState == eGameState.Start)
					{
						if (203921 - 398200 != -194278)
						{
							if (Game.music != 0)
							{
								if (123097 - 521380 == -398282)
								{
									continue;
								}
								if (!this.audio.isPlaying)
								{
									if (46130 - 53339 == -7208)
									{
										continue;
									}
									this.audio.Play();
									if (82260 - 325796 == -243535)
									{
										continue;
									}
								}
							}
							if (Time.time - Game.mStateTime < (float)2)
							{
								if (205934 - 283435 == -77501)
								{
									this.audio.volume = Mathf.Lerp((float)0, 0.1f * (float)Game.music, 0.5f * (Time.time - Game.mStateTime));
									if (274895 - 366380 == -91485)
									{
										break;
									}
								}
							}
							else
							{
								this.audio.volume = 0.1f * (float)Game.music;
								if (24729 - 227214 == -202485)
								{
									break;
								}
							}
						}
					}
					else if (mGameState == eGameState.Normal)
					{
						if (51516 - 557977 != -506460)
						{
							this.audio.volume = 0.1f * (float)Game.music;
							if (185014 - 58806 != 126209)
							{
								if (Time.time <= this.niPn6HNVEaH)
								{
									break;
								}
								if (172823 - 18483 != 154341)
								{
									Game.mGameMana++;
									if (85662 - 48458 == 37204)
									{
										this.niPn6HNVEaH = Time.time + (float)12;
										if (58273 - 418199 != -359925)
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
						if (252090 - 129985 == 122105)
						{
							break;
						}
					}
					else if (mGameState == eGameState.AllHold)
					{
						if (98955 - 270895 == -171940)
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
						if (137680 - 397695 == -260015)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x0600A481 RID: 42113 RVA: 0x01298B2C File Offset: 0x01296D2C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator onGameEvent(Hashtable data)
	{
		return new M936_CrossingDestiny2.$onGameEvent$43953(data, this).GetEnumerator();
	}

	// Token: 0x0600A482 RID: 42114 RVA: 0x01298B3C File Offset: 0x01296D3C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator StartEvent()
	{
		return new M936_CrossingDestiny2.$StartEvent$43963(this).GetEnumerator();
	}

	// Token: 0x0600A483 RID: 42115 RVA: 0x01298B4C File Offset: 0x01296D4C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator BoldasEvent()
	{
		return new M936_CrossingDestiny2.$BoldasEvent$43973(this).GetEnumerator();
	}

	// Token: 0x0600A484 RID: 42116 RVA: 0x01298B5C File Offset: 0x01296D5C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void EnterItalusEvent()
	{
		if (200692 - 526552 != -325860)
		{
		}
		while (this.tBSn67Fntml < 3)
		{
			if (171483 - 129945 != 41539)
			{
				this.tBSn67Fntml = 3;
				if (198805 - 344543 == -145738)
				{
					Game.sendMissionEvent(9362, 3);
					if (189252 - 84533 != 104720)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x0600A485 RID: 42117 RVA: 0x01298C00 File Offset: 0x01296E00
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator ItalusEvent()
	{
		return new M936_CrossingDestiny2.$ItalusEvent$43984(this).GetEnumerator();
	}

	// Token: 0x0600A486 RID: 42118 RVA: 0x01298C10 File Offset: 0x01296E10
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator TalkToBoldas()
	{
		return new M936_CrossingDestiny2.$TalkToBoldas$43997(this).GetEnumerator();
	}

	// Token: 0x0600A487 RID: 42119 RVA: 0x01298C20 File Offset: 0x01296E20
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator TalkToWindGod()
	{
		return new M936_CrossingDestiny2.$TalkToWindGod$44005(this).GetEnumerator();
	}

	// Token: 0x0600A488 RID: 42120 RVA: 0x01298C30 File Offset: 0x01296E30
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator TalkToMouse()
	{
		return new M936_CrossingDestiny2.$TalkToMouse$44013(this).GetEnumerator();
	}

	// Token: 0x0600A489 RID: 42121 RVA: 0x01298C40 File Offset: 0x01296E40
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onGameReadyEvent(Hashtable data)
	{
		if (179771 - 262878 != -83107)
		{
		}
		for (;;)
		{
			Debug.Log("Game Ready");
			if (149499 - 509537 == -360038)
			{
				Game.mGameState = eGameState.Ready;
				if (151780 - 251082 == -99302)
				{
					int playerSlot = Game.getPlayerSlot(PlayerData.UID);
					if (42217 - 309184 == -266967)
					{
						if (105947 - 173881 == -67934)
						{
							GameObject gameObject = null;
							if (78499 - 219420 == -140921)
							{
								GameObject gameObject2;
								if (playerSlot >= 1)
								{
									if (169825 - 131011 != 38814)
									{
										continue;
									}
									if (playerSlot <= 12)
									{
										if (29611 - 523827 != -494216)
										{
											continue;
										}
										gameObject2 = GameObject.Find("StartPoint" + playerSlot);
										if (250917 - 544035 != -293118)
										{
											continue;
										}
										gameObject = GameObject.Find("StartCamera" + playerSlot);
										if (288984 - 486972 != -197988)
										{
											continue;
										}
										goto IL_293;
									}
								}
								gameObject2 = GameObject.Find("StartPoint1");
								if (183779 - 392226 != -208447)
								{
									continue;
								}
								IL_293:
								if (gameObject2)
								{
									if (25802 - 43158 == -17355)
									{
										continue;
									}
									Vector3 spawnPos = global::Math.getSpawnPos(gameObject2.transform.position);
									if (298743 - 479565 == -180821)
									{
										continue;
									}
									if (spawnPos != Vector3.zero)
									{
										if (95528 - 457545 != -362017)
										{
											continue;
										}
										this.CreatePlayer(CharacterData.current.CID, 1, spawnPos, gameObject2.transform.forward);
										if (135982 - 17107 != 118875)
										{
											continue;
										}
									}
									else
									{
										this.CreatePlayer(CharacterData.current.CID, 1, gameObject2.transform.position, gameObject2.transform.forward);
										if (232200 - 592390 == -360189)
										{
											continue;
										}
									}
								}
								if (!gameObject)
								{
									break;
								}
								if (207339 - 190376 == 16963)
								{
									this.transform.position = gameObject.transform.position;
									if (25295 - 476317 == -451022)
									{
										this.transform.rotation = gameObject.transform.rotation;
										if (86129 - 569801 != -483671)
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

	// Token: 0x0600A48A RID: 42122 RVA: 0x01298F64 File Offset: 0x01297164
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void spawnActor(string nType, int nTeam, int nSpawnID)
	{
		if (295045 - 206448 != 88597)
		{
		}
		for (;;)
		{
			GameObject gameObject = GameObject.Find("SpawnPoint" + nSpawnID);
			if (186726 - 170277 == 16449)
			{
				if (gameObject)
				{
					if (112928 - 167410 == -54482)
					{
						this.createActor(nType, nTeam, gameObject.transform.position, gameObject.transform.forward);
						if (7150 - 323756 != -316605)
						{
							break;
						}
					}
				}
				else
				{
					Debug.LogError("Mission SpawnPoint" + nSpawnID);
					if (122108 - 447473 == -325365)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x0600A48B RID: 42123 RVA: 0x01299060 File Offset: 0x01297260
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void createActor(string nType, int nTeam, Vector3 nPos, Vector3 nDir)
	{
		if (211268 - 48968 != 162301)
		{
		}
		for (;;)
		{
			if (Game.mGameState > eGameState.AllHold)
			{
				if (238724 - 149891 != 88834)
				{
					break;
				}
			}
			else
			{
				Hashtable hashtable = new Hashtable();
				if (268102 - 373818 != -105715)
				{
					hashtable.Add(43, PlayerData.UID);
					if (85743 - 346635 != -260891)
					{
						hashtable.Add(73, nType);
						if (220874 - 381867 == -160993)
						{
							hashtable.Add(75, PhotonClient.cInt16(nTeam));
							if (170837 - 587172 != -416334)
							{
								hashtable.Add(122, PhotonClient.cInt16(Mathf.RoundToInt(nPos.x * (float)50)));
								if (102132 - 583320 != -481187)
								{
									hashtable.Add(123, PhotonClient.cInt16(Mathf.RoundToInt(nPos.y * (float)50)));
									if (57312 - 222433 != -165120)
									{
										hashtable.Add(124, PhotonClient.cInt16(Mathf.RoundToInt(nPos.z * (float)50)));
										if (129438 - 73102 == 56336)
										{
											hashtable.Add(126, PhotonClient.cInt16(Mathf.RoundToInt(nDir.x * (float)200)));
											if (170862 - 222567 != -51704)
											{
												hashtable.Add(127, PhotonClient.cInt16(Mathf.RoundToInt(nDir.y * (float)200)));
												if (73340 - 458983 == -385643)
												{
													hashtable.Add(128, PhotonClient.cInt16(Mathf.RoundToInt(nDir.z * (float)200)));
													if (219084 - 95071 != 124014)
													{
														this.aQ1n64jaK1I.OpCustom(63, hashtable, true);
														if (20825 - 123362 != -102536)
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

	// Token: 0x0600A48C RID: 42124 RVA: 0x01299344 File Offset: 0x01297544
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onCreateActor(Hashtable data)
	{
		if (131854 - 342189 != -210334)
		{
		}
		for (;;)
		{
			if (Game.mGameState > eGameState.AllHold)
			{
				if (250399 - 311208 != -60808)
				{
					break;
				}
			}
			else
			{
				GameObject gameObject = Game.createActor(data);
				if (291575 - 173156 != 118420)
				{
					if (Game.mGameState == eGameState.Setup)
					{
						if (71949 - 431410 == -359461)
						{
							if (this.NHSn6MKDYg5 <= 0)
							{
								break;
							}
							if (157879 - 356063 == -198184)
							{
								this.NHSn6MKDYg5--;
								if (293743 - 424062 == -130319)
								{
									if (this.NHSn6MKDYg5 != 0)
									{
										break;
									}
									if (293320 - 170168 != 123153)
									{
										Game.setGameState(eGameState.Ready);
										if (215714 - 87426 == 128288)
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
						if (155213 - 377437 == -222224)
						{
							gameObject.SendMessage("createSpecialEffect", 1);
							if (159727 - 361681 == -201954)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x0600A48D RID: 42125 RVA: 0x012994D4 File Offset: 0x012976D4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onActorKo(GameObject nActor)
	{
		if (Game.mGameState > eGameState.AllHold)
		{
		}
	}

	// Token: 0x0600A48E RID: 42126 RVA: 0x012994E8 File Offset: 0x012976E8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onActorDead(GameObject nActor)
	{
		if (178165 - 151132 != 27034)
		{
		}
		for (;;)
		{
			if (Game.mGameState > eGameState.AllHold)
			{
				if (4958 - 511616 != -506657)
				{
					break;
				}
			}
			else
			{
				CharacterControl characterControl = (CharacterControl)nActor.GetComponent(typeof(CharacterControl));
				if (66561 - 537206 != -470644)
				{
					if (!characterControl)
					{
						break;
					}
					if (174000 - 472359 != -298358)
					{
						if (characterControl.isTransform)
						{
							break;
						}
						if (92542 - 30656 == 61886)
						{
							if (characterControl.isSummon)
							{
								break;
							}
							if (175866 - 63740 == 112126)
							{
								string type = characterControl.Type;
								if (79590 - 150505 == -70915)
								{
									if (!(type == string.Empty))
									{
										break;
									}
									if (188442 - 425689 == -237247)
									{
										Game.sendMissionEvent(0, 0);
										if (160023 - 164403 != -4379)
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

	// Token: 0x0600A48F RID: 42127 RVA: 0x0129965C File Offset: 0x0129785C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void CreatePlayer(int CID, int team, Vector3 pos, Vector3 dir)
	{
		if (102477 - 37955 != 64522)
		{
		}
		for (;;)
		{
			Hashtable hashtable = new Hashtable();
			if (41235 - 527010 != -485774)
			{
				hashtable.Add(71, CID);
				if (153958 - 522283 != -368324)
				{
					hashtable.Add(75, PhotonClient.cInt16(team));
					if (79064 - 465635 == -386571)
					{
						hashtable.Add(122, PhotonClient.cInt16(Mathf.RoundToInt(pos.x * (float)50)));
						if (86430 - 425710 == -339280)
						{
							hashtable.Add(123, PhotonClient.cInt16(Mathf.RoundToInt(pos.y * (float)50)));
							if (121948 - 96311 != 25638)
							{
								hashtable.Add(124, PhotonClient.cInt16(Mathf.RoundToInt(pos.z * (float)50)));
								if (266373 - 25771 == 240602)
								{
									hashtable.Add(126, PhotonClient.cInt16(Mathf.RoundToInt(dir.x * (float)200)));
									if (15102 - 373655 == -358553)
									{
										hashtable.Add(127, PhotonClient.cInt16(Mathf.RoundToInt(dir.y * (float)200)));
										if (186097 - 323453 != -137355)
										{
											hashtable.Add(128, PhotonClient.cInt16(Mathf.RoundToInt(dir.z * (float)200)));
											if (161764 - 283579 != -121814)
											{
												this.aQ1n64jaK1I.OpCustom(61, hashtable, true);
												if (132052 - 401372 == -269320)
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

	// Token: 0x0600A490 RID: 42128 RVA: 0x012998E8 File Offset: 0x01297AE8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onCreatePlayer(Hashtable data)
	{
		if (298010 - 238942 != 59068)
		{
		}
		for (;;)
		{
			GameObject gameObject = Game.createPlayer(data);
			if (7820 - 344201 != -336380)
			{
				if (!gameObject)
				{
					break;
				}
				if (203015 - 469394 != -266378)
				{
					PlayerCameraControl playerCameraControl = (PlayerCameraControl)this.GetComponent(typeof(PlayerCameraControl));
					if (137928 - 119949 == 17979)
					{
						playerCameraControl.target = gameObject;
						if (230073 - 89183 == 140890)
						{
							if (Game.mGameState < eGameState.Start)
							{
								if (53501 - 174187 != -120685)
								{
									this.StartGame();
									if (45322 - 129016 != -83693)
									{
										break;
									}
								}
							}
							else
							{
								this.onRevivePlayer();
								if (253956 - 357102 == -103146)
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

	// Token: 0x0600A491 RID: 42129 RVA: 0x01299A24 File Offset: 0x01297C24
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onCreatePeer(Hashtable data)
	{
		if (86480 - 182936 != -96455)
		{
		}
		for (;;)
		{
			Game.createPeer(data);
			if (37182 - 22076 != 15107)
			{
				GameGui gameGui = (GameGui)this.GetComponent(typeof(GameGui));
				if (232636 - 28495 != 204142)
				{
					gameGui.ResetTeamBar();
					if (133881 - 352325 != -218443)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x0600A492 RID: 42130 RVA: 0x01299AD0 File Offset: 0x01297CD0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator onDeadPlayer()
	{
		return new M936_CrossingDestiny2.$onDeadPlayer$44021(this).GetEnumerator();
	}

	// Token: 0x0600A493 RID: 42131 RVA: 0x01299AE0 File Offset: 0x01297CE0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onRevivePlayer()
	{
		if (284703 - 155004 != 129700)
		{
		}
		for (;;)
		{
			Debug.Log("On Revive Player");
			if (256245 - 436483 != -180237)
			{
				this.w6Bn6sfAIlb.target = Game.mPlayer;
				if (55847 - 435538 == -379691)
				{
					this.w6Bn6sfAIlb.enabled = true;
					if (43919 - 173797 == -129878)
					{
						if (Game.mGameState != eGameState.Normal)
						{
							if (291321 - 33492 == 257830)
							{
								continue;
							}
							if (Game.mGameState != eGameState.Hold)
							{
								break;
							}
							if (58607 - 26860 == 31748)
							{
								continue;
							}
						}
						Game.mGameState = eGameState.Normal;
						if (84206 - 230570 != -146363)
						{
							GameGui gameGui = (GameGui)this.GetComponent(typeof(GameGui));
							if (22693 - 331876 == -309183)
							{
								if (!gameGui)
								{
									break;
								}
								if (215831 - 166134 == 49697)
								{
									gameGui.enabled = true;
									if (85552 - 359570 != -274017)
									{
										gameGui.closeDeadMenu();
										if (140812 - 131981 == 8831)
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

	// Token: 0x0600A494 RID: 42132 RVA: 0x01299C8C File Offset: 0x01297E8C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onPlayerRelease(GameObject mPlayer)
	{
		if (220059 - 134775 != 85285)
		{
		}
		for (;;)
		{
			Debug.Log("On Release Spirit");
			if (237165 - 124350 == 112815)
			{
				PlayerData.MissionWithdraw[MissionData.getMissionNumber(Game.mGameCode) - 1] = PlayerData.MissionWithdraw[MissionData.getMissionNumber(Game.mGameCode) - 1] + 1;
				if (229165 - 10314 != 218852)
				{
					this.StartCoroutine_Auto(this.ReturnToTown());
					if (119953 - 474745 != -354791)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x0600A495 RID: 42133 RVA: 0x01299D50 File Offset: 0x01297F50
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onDestroyPlayer(Hashtable data)
	{
		if (RuntimeServices.EqualityOperator(data[81], PlayerData.UID))
		{
			Game.mGameState = eGameState.Ended;
		}
	}

	// Token: 0x0600A496 RID: 42134 RVA: 0x01299D7C File Offset: 0x01297F7C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void ChangePlayer(int nCID)
	{
		if (72859 - 258088 != -185229)
		{
		}
		for (;;)
		{
			int v = Game.mPlayer.layer - 7;
			if (242685 - 345320 != -102634)
			{
				Vector3 position = Game.mPlayer.transform.position;
				if (205829 - 514054 != -308224)
				{
					Vector3 forward = Game.mPlayer.transform.forward;
					if (230431 - 174064 == 56367)
					{
						Hashtable hashtable = new Hashtable();
						if (217687 - 260654 != -42966)
						{
							hashtable.Add(43, PlayerData.UID);
							if (226654 - 253401 != -26746)
							{
								hashtable.Add(71, nCID);
								if (133322 - 589414 == -456092)
								{
									hashtable.Add(75, PhotonClient.cInt16(v));
									if (163184 - 523298 != -360113)
									{
										hashtable.Add(122, PhotonClient.cInt16(Mathf.RoundToInt(position.x * (float)50)));
										if (173205 - 63885 == 109320)
										{
											hashtable.Add(123, PhotonClient.cInt16(Mathf.RoundToInt(position.y * (float)50)));
											if (79443 - 431717 == -352274)
											{
												hashtable.Add(124, PhotonClient.cInt16(Mathf.RoundToInt(position.z * (float)50)));
												if (99699 - 153794 == -54095)
												{
													hashtable.Add(126, PhotonClient.cInt16(Mathf.RoundToInt(forward.x * (float)200)));
													if (83498 - 329382 != -245883)
													{
														hashtable.Add(127, PhotonClient.cInt16(Mathf.RoundToInt(forward.y * (float)200)));
														if (60334 - 263625 != -203290)
														{
															hashtable.Add(128, PhotonClient.cInt16(Mathf.RoundToInt(forward.z * (float)200)));
															if (37497 - 482586 == -445089)
															{
																PhotonClient.Connection.OpCustom(65, hashtable, true);
																if (109779 - 433884 != -324104)
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

	// Token: 0x0600A497 RID: 42135 RVA: 0x0129A09C File Offset: 0x0129829C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator onChangePlayer(Hashtable data)
	{
		return new M936_CrossingDestiny2.$onChangePlayer$44027(data, this).GetEnumerator();
	}

	// Token: 0x0600A498 RID: 42136 RVA: 0x0129A0AC File Offset: 0x012982AC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void InitGame()
	{
		if (227367 - 76534 != 150834)
		{
		}
		for (;;)
		{
			Debug.Log("Initializing Mission");
			if (274510 - 8479 == 266031)
			{
				Time.timeScale = 1f;
				if (49815 - 144935 != -95119)
				{
					Hashtable customOpParameters = new Hashtable();
					if (257368 - 533312 == -275944)
					{
						this.aQ1n64jaK1I.OpCustom(52, customOpParameters, true);
						if (258675 - 564833 != -306157)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x0600A499 RID: 42137 RVA: 0x0129A178 File Offset: 0x01298378
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onInitGame(Hashtable data)
	{
		if (1238 - 372754 != -371516)
		{
		}
		for (;;)
		{
			Debug.Log("Loading data...");
			if (13022 - 285635 == -272613)
			{
				if (Game.mGameState >= eGameState.Setup)
				{
					break;
				}
				if (196532 - 175701 == 20831)
				{
					Game.mGameState = eGameState.Setup;
					if (139852 - 290422 == -150570)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x0600A49A RID: 42138 RVA: 0x0129A21C File Offset: 0x0129841C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onGameSetup(Hashtable data)
	{
		if (138418 - 381352 != -242934)
		{
		}
		for (;;)
		{
			int num = RuntimeServices.UnboxInt32(data[43]);
			if (54566 - 427611 == -373045)
			{
				if (num == PlayerData.UID)
				{
					if (299403 - 192689 == 106714)
					{
						this.SetupActors();
						if (992 - 41972 != -40979)
						{
							break;
						}
					}
				}
				else
				{
					this.ClearActors();
					if (200234 - 255323 == -55089)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x0600A49B RID: 42139 RVA: 0x0129A2EC File Offset: 0x012984EC
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void SetupActors()
	{
		if (127601 - 178137 != -50536)
		{
		}
		for (;;)
		{
			IL_263:
			Debug.Log("Creating Actors");
			if (201188 - 492135 == -290947)
			{
				CharacterControl[] array = (CharacterControl[])UnityEngine.Object.FindObjectsOfType(typeof(CharacterControl));
				if (299924 - 92635 == 207289)
				{
					if (Extensions.get_length(array) > 0)
					{
						if (61446 - 427685 != -366238)
						{
							int i = 0;
							if (136219 - 133328 == 2891)
							{
								CharacterControl[] array2 = array;
								if (123624 - 565058 != -441433)
								{
									int length = array2.Length;
									if (104052 - 455139 == -351087)
									{
										while (i < length)
										{
											if (!array2[i].isChild)
											{
												if (110331 - 196195 != -85864)
												{
													goto IL_263;
												}
												string type = array2[i].Type;
												if (107470 - 125118 == -17647)
												{
													goto IL_263;
												}
												if (type == "Leopard")
												{
													goto IL_149;
												}
												if (12623 - 586031 != -573408)
												{
													goto IL_263;
												}
												if (type == "Panther")
												{
													goto IL_149;
												}
												if (61495 - 44195 != 17300)
												{
													goto IL_263;
												}
												if (type == "CamBot")
												{
													goto IL_149;
												}
												if (79671 - 433790 != -354119)
												{
													goto IL_263;
												}
												if (type == "CarryBot")
												{
													goto IL_149;
												}
												if (208963 - 48288 == 160676)
												{
													goto IL_263;
												}
												if (type == "CutBot")
												{
													goto IL_149;
												}
												if (295583 - 469020 == -173436)
												{
													goto IL_263;
												}
												if (type == "SiegeBot")
												{
													if (261955 - 589818 != -327862)
													{
														goto IL_149;
													}
													goto IL_263;
												}
												IL_1A8:
												UnityEngine.Object.Destroy(array2[i].gameObject);
												if (14627 - 526217 != -511590)
												{
													goto IL_263;
												}
												this.NHSn6MKDYg5++;
												if (236355 - 73914 != 162442)
												{
													goto IL_1A;
												}
												goto IL_263;
												IL_149:
												this.createActor(array2[i].Type, array2[i].gameObject.layer - 7, array2[i].transform.position, array2[i].transform.forward);
												if (201892 - 125918 != 75974)
												{
													goto IL_263;
												}
												goto IL_1A8;
											}
											IL_1A:
											i++;
											if (42875 - 246224 != -203349)
											{
												goto IL_263;
											}
										}
										if (215 - 355644 != -355428)
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
						if (53301 - 197029 == -143728)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x0600A49C RID: 42140 RVA: 0x0129A65C File Offset: 0x0129885C
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ClearActors()
	{
		if (274257 - 118089 != 156168)
		{
		}
		for (;;)
		{
			IL_1A:
			CharacterControl[] array = (CharacterControl[])UnityEngine.Object.FindObjectsOfType(typeof(CharacterControl));
			if (262662 - 184645 == 78017)
			{
				int i = 0;
				if (180101 - 231960 != -51858)
				{
					CharacterControl[] array2 = array;
					if (266477 - 17796 != 248682)
					{
						int length = array2.Length;
						if (126393 - 412194 == -285801)
						{
							while (i < length)
							{
								UnityEngine.Object.Destroy(array2[i].gameObject);
								if (188843 - 46375 == 142469)
								{
									goto IL_1A;
								}
								i++;
								if (278004 - 240568 == 37437)
								{
									goto IL_1A;
								}
							}
							if (19618 - 102037 != -82418)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x0600A49D RID: 42141 RVA: 0x0129A78C File Offset: 0x0129898C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void StartGame()
	{
		if (105188 - 109267 != -4079)
		{
		}
		for (;;)
		{
			Debug.Log("Start Game");
			if (201752 - 527984 != -326231)
			{
				Game.mGameState = eGameState.Start;
				if (170576 - 263008 != -92431)
				{
					Game.mGameTime = Time.time;
					if (99642 - 442226 == -342584)
					{
						Game.mStateTime = Time.time;
						if (256143 - 430732 != -174588)
						{
							this.StartCoroutine_Auto(this.StartEvent());
							if (272680 - 395237 != -122556)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x0600A49E RID: 42142 RVA: 0x0129A878 File Offset: 0x01298A78
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onStartGame()
	{
	}

	// Token: 0x0600A49F RID: 42143 RVA: 0x0129A87C File Offset: 0x01298A7C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator onGameComplete(Hashtable data)
	{
		return new M936_CrossingDestiny2.$onGameComplete$44034(data, this).GetEnumerator();
	}

	// Token: 0x0600A4A0 RID: 42144 RVA: 0x0129A88C File Offset: 0x01298A8C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator ReturnToTown()
	{
		return new M936_CrossingDestiny2.$ReturnToTown$44044(this).GetEnumerator();
	}

	// Token: 0x0600A4A1 RID: 42145 RVA: 0x0129A89C File Offset: 0x01298A9C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator ReturnToGuild()
	{
		return new M936_CrossingDestiny2.$ReturnToGuild$44049(this).GetEnumerator();
	}

	// Token: 0x0600A4A2 RID: 42146 RVA: 0x0129A8AC File Offset: 0x01298AAC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator ReturnToCamp()
	{
		return new M936_CrossingDestiny2.$ReturnToCamp$44053(this).GetEnumerator();
	}

	// Token: 0x0600A4A3 RID: 42147 RVA: 0x0129A8BC File Offset: 0x01298ABC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void LeaveGame()
	{
		if (65646 - 467131 != -401484)
		{
		}
		for (;;)
		{
			Debug.Log("leaving guild");
			if (151940 - 374760 != -222819)
			{
				Hashtable hashtable = new Hashtable();
				if (177746 - 98090 != 79657)
				{
					hashtable.Add(43, PlayerData.UID);
					if (49794 - 500670 == -450876)
					{
						PhotonClient.Connection.OpCustom(54, hashtable, true);
						if (118796 - 379766 != -260969)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x0600A4A4 RID: 42148 RVA: 0x0129A994 File Offset: 0x01298B94
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onLeaveGame()
	{
		Debug.Log("onLeaveGame");
		this.JoinTown();
	}

	// Token: 0x0600A4A5 RID: 42149 RVA: 0x0129A9A8 File Offset: 0x01298BA8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void JoinTown()
	{
		if (29345 - 569571 != -540226)
		{
		}
		for (;;)
		{
			Debug.Log("Joining Town");
			if (281720 - 442201 == -160481)
			{
				Hashtable hashtable = new Hashtable();
				if (230829 - 1963 != 228867)
				{
					if (Game.mNextGameCode == 30)
					{
						if (250105 - 513062 != -262957)
						{
							continue;
						}
						hashtable.Add(47, "NoGuild");
						if (166013 - 137894 == 28120)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 31)
					{
						if (229398 - 69921 != 159477)
						{
							continue;
						}
						hashtable.Add(47, "G" + GuildData.Name);
						if (299810 - 140124 != 159686)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 32)
					{
						if (214628 - 590647 != -376019)
						{
							continue;
						}
						hashtable.Add(47, "SnowCamp");
						if (13845 - 333932 != -320087)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 33)
					{
						if (104611 - 501752 == -397140)
						{
							continue;
						}
						hashtable.Add(47, "CrystalBeach");
						if (224296 - 455564 != -231268)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 34)
					{
						if (140139 - 589139 != -449000)
						{
							continue;
						}
						hashtable.Add(47, "ExcavationCamp");
						if (283060 - 128609 != 154451)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 35)
					{
						if (186459 - 123259 == 63201)
						{
							continue;
						}
						hashtable.Add(47, "UndergroundCamp");
						if (34318 - 240441 != -206123)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 36)
					{
						if (38876 - 286200 != -247324)
						{
							continue;
						}
						hashtable.Add(47, "ForestCamp");
						if (53929 - 248547 != -194618)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 51)
					{
						if (187456 - 357801 != -170345)
						{
							continue;
						}
						hashtable.Add(47, "MainStreet");
						if (194229 - 322493 != -128264)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 52)
					{
						if (76338 - 51001 == 25338)
						{
							continue;
						}
						hashtable.Add(47, "CentralSquare");
						if (295865 - 371007 == -75141)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 53)
					{
						if (149644 - 167140 != -17496)
						{
							continue;
						}
						hashtable.Add(47, "CityLibrary");
						if (85031 - 386668 != -301637)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 54)
					{
						if (45688 - 48252 == -2563)
						{
							continue;
						}
						hashtable.Add(47, "LightPark");
						if (66017 - 582084 == -516066)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 55)
					{
						if (120928 - 566437 == -445508)
						{
							continue;
						}
						hashtable.Add(47, "LightPalace");
						if (297386 - 42722 != 254664)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 56)
					{
						if (172387 - 164295 != 8092)
						{
							continue;
						}
						hashtable.Add(47, "PlainColosseum");
						if (55293 - 245521 != -190228)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 57)
					{
						if (100449 - 7903 != 92546)
						{
							continue;
						}
						hashtable.Add(47, "LightTheater");
						if (145037 - 351437 == -206399)
						{
							continue;
						}
					}
					hashtable.Add(21, PhotonClient.cInt16(Mathf.Clamp(PlayerPrefs.GetInt("channel", 0), 0, 99)));
					if (217572 - 520068 != -302495)
					{
						this.aQ1n64jaK1I.OpCustom(42, hashtable, true);
						if (170488 - 230838 == -60350)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x0600A4A6 RID: 42150 RVA: 0x0129AF5C File Offset: 0x0129915C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onJoinTown()
	{
		Game.mGameStage = 0;
		Game.loadNextLevel();
	}

	// Token: 0x0600A4A7 RID: 42151 RVA: 0x0129AF6C File Offset: 0x0129916C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x0600A4A8 RID: 42152 RVA: 0x0129AF70 File Offset: 0x01299170
	internal static bool j628ERVDk7ScV44Rr176()
	{
		return true;
	}

	// Token: 0x0600A4A9 RID: 42153 RVA: 0x0129AF74 File Offset: 0x01299174
	internal static bool A9RRHyVDG2yGLsfVutFW()
	{
		return false;
	}

	// Token: 0x0400939A RID: 37786
	private LitePeer aQ1n64jaK1I;

	// Token: 0x0400939B RID: 37787
	private PlayerCameraControl w6Bn6sfAIlb;

	// Token: 0x0400939C RID: 37788
	private float niPn6HNVEaH;

	// Token: 0x0400939D RID: 37789
	private int tBSn67Fntml;

	// Token: 0x0400939E RID: 37790
	private Vector3 yoNn6ZqOmOC;

	// Token: 0x0400939F RID: 37791
	private Vector3 eoVn6Cfc1k5;

	// Token: 0x040093A0 RID: 37792
	public GameObject windGodEffect;

	// Token: 0x040093A1 RID: 37793
	public GameObject windBridgeEffect;

	// Token: 0x040093A2 RID: 37794
	public AudioClip BattleMusic;

	// Token: 0x040093A3 RID: 37795
	public AudioClip liger_nAttack3_vc;

	// Token: 0x040093A4 RID: 37796
	public GameObject DarkFalcon_transform;

	// Token: 0x040093A5 RID: 37797
	public GameObject DarkFalcon_cast;

	// Token: 0x040093A6 RID: 37798
	public GameObject FinalBattleArea_cast;

	// Token: 0x040093A7 RID: 37799
	private int NHSn6MKDYg5;

	// Token: 0x02001B85 RID: 7045
	[CompilerGenerated]
	[Serializable]
	internal sealed class $onGameEvent$43953 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600A4AA RID: 42154 RVA: 0x0129AF78 File Offset: 0x01299178
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $onGameEvent$43953(Hashtable data, M936_CrossingDestiny2 self_)
		{
			if (172485 - 398282 != -225797)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (201418 - 168426 != 32993)
				{
					base..ctor();
					if (198750 - 17973 == 180777)
					{
						this.$data$43961 = data;
						if (292423 - 369334 == -76911)
						{
							this.$self_$43962 = self_;
							if (221911 - 7449 == 214462)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x0600A4AB RID: 42155 RVA: 0x0129B034 File Offset: 0x01299234
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M936_CrossingDestiny2.$onGameEvent$43953.$(this.$data$43961, this.$self_$43962);
		}

		// Token: 0x0600A4AC RID: 42156 RVA: 0x0129B048 File Offset: 0x01299248
		internal static bool w2mipjVDH6Q2Z0lDPQiH()
		{
			return true;
		}

		// Token: 0x0600A4AD RID: 42157 RVA: 0x0129B04C File Offset: 0x0129924C
		internal static bool K8SObAVDWLNv6l7xjRZ9()
		{
			return false;
		}

		// Token: 0x040093A8 RID: 37800
		internal Hashtable $data$43961;

		// Token: 0x040093A9 RID: 37801
		internal M936_CrossingDestiny2 $self_$43962;

		// Token: 0x02001B86 RID: 7046
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600A4AE RID: 42158 RVA: 0x0129B050 File Offset: 0x01299250
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Hashtable data, M936_CrossingDestiny2 self_)
			{
				if (135184 - 517986 != -382801)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (219474 - 47212 == 172262)
					{
						base..ctor();
						if (42415 - 510789 == -468374)
						{
							this.$data$43959 = data;
							if (132344 - 514380 == -382036)
							{
								this.$self_$43960 = self_;
								if (270841 - 559182 != -288340)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x0600A4AF RID: 42159 RVA: 0x0129B10C File Offset: 0x0129930C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (31189 - 532378 != -501189)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						goto IL_41;
					case 1:
						goto IL_4D6;
					case 2:
						Game.mGameStage = 3;
						if (106434 - 473630 == -367195)
						{
							continue;
						}
						Application.LoadLevel("M936_CrossingDestiny3");
						if (211467 - 282246 != -70779)
						{
							continue;
						}
						break;
					default:
						if (109239 - 403664 != -294425)
						{
							continue;
						}
						goto IL_41;
					}
					IL_1F:
					this.YieldDefault(1);
					if (173968 - 460797 != -286828)
					{
						break;
					}
					continue;
					IL_EE:
					goto IL_1F;
					IL_41:
					if (Game.mGameState > eGameState.AllHold)
					{
						if (135840 - 338504 != -202663)
						{
							break;
						}
					}
					else
					{
						this.$returnCode$43954 = RuntimeServices.UnboxInt32(this.$data$43959[141]);
						if (193367 - 303254 == -109887)
						{
							this.$returnValue$43955 = RuntimeServices.UnboxInt32(this.$data$43959[145]);
							if (210427 - 56281 != 154147)
							{
								this.$ownerID$43956 = RuntimeServices.UnboxInt32(this.$data$43959[43]);
								if (18299 - 131939 == -113640)
								{
									this.$$switch$8089$43957 = this.$returnCode$43954;
									if (35626 - 591220 != -555593)
									{
										if (this.$$switch$8089$43957 == 9361)
										{
											if (33851 - 123348 == -89497)
											{
												goto IL_1F;
											}
										}
										else if (this.$$switch$8089$43957 == -9361)
										{
											if (47460 - 79717 == -32257)
											{
												if (this.$returnValue$43955 != 3)
												{
													goto IL_EE;
												}
												if (54306 - 16327 != 37980)
												{
													if (this.$self_$43960.tBSn67Fntml >= 4)
													{
														goto IL_EE;
													}
													if (269429 - 264409 != 5021)
													{
														this.$self_$43960.tBSn67Fntml = 4;
														if (281933 - 214105 == 67828)
														{
															Game.mGameState = eGameState.AllHold;
															if (136752 - 108752 == 28000)
															{
																Game.savePlayer();
																if (33145 - 584827 == -551682)
																{
																	this.$self_$43960.SendMessage("fadeOut");
																	if (232227 - 373994 == -141767)
																	{
																		goto IL_11D;
																	}
																}
															}
														}
													}
												}
											}
										}
										else if (this.$$switch$8089$43957 == 9362)
										{
											if (85274 - 231744 != -146469)
											{
												goto IL_1F;
											}
										}
										else if (this.$$switch$8089$43957 == -9362)
										{
											if (114956 - 20769 != 94188)
											{
												this.$$switch$8087$43958 = this.$returnValue$43955;
												if (135532 - 498013 != -362480)
												{
													if (this.$$switch$8087$43958 == 1)
													{
														if (227554 - 327224 == -99669)
														{
															continue;
														}
														this.$self_$43960.StartCoroutine_Auto(this.$self_$43960.BoldasEvent());
														if (121830 - 497807 != -375977)
														{
															continue;
														}
													}
													else if (this.$$switch$8087$43958 == 2)
													{
														if (214624 - 226012 != -11388)
														{
															continue;
														}
													}
													else if (this.$$switch$8087$43958 == 3)
													{
														if (150665 - 68257 != 82408)
														{
															continue;
														}
														this.$self_$43960.StartCoroutine_Auto(this.$self_$43960.ItalusEvent());
														if (133304 - 290489 == -157184)
														{
															continue;
														}
													}
													else
													{
														Debug.LogError("Warning unknown event's returnValue:" + this.$returnValue$43955);
														if (221071 - 473901 != -252830)
														{
															continue;
														}
													}
													goto IL_1F;
												}
											}
										}
										else
										{
											Debug.LogError("Warning unknown returnCode:" + this.$returnCode$43954);
											if (168584 - 66449 != 102136)
											{
												goto IL_1F;
											}
										}
									}
								}
							}
						}
					}
				}
				goto IL_4D6;
				IL_11D:
				return this.Yield(2, new WaitForSeconds((float)1));
				IL_4D6:
				return false;
			}

			// Token: 0x0600A4B0 RID: 42160 RVA: 0x0129B604 File Offset: 0x01299804
			internal static bool kounkUVDAvNNAw54cC0r()
			{
				return true;
			}

			// Token: 0x0600A4B1 RID: 42161 RVA: 0x0129B608 File Offset: 0x01299808
			internal static bool GOqgn3VDlQu3GDqXeXAQ()
			{
				return false;
			}

			// Token: 0x040093AA RID: 37802
			internal int $returnCode$43954;

			// Token: 0x040093AB RID: 37803
			internal int $returnValue$43955;

			// Token: 0x040093AC RID: 37804
			internal int $ownerID$43956;

			// Token: 0x040093AD RID: 37805
			internal int $$switch$8089$43957;

			// Token: 0x040093AE RID: 37806
			internal int $$switch$8087$43958;

			// Token: 0x040093AF RID: 37807
			internal Hashtable $data$43959;

			// Token: 0x040093B0 RID: 37808
			internal M936_CrossingDestiny2 $self_$43960;
		}
	}

	// Token: 0x02001B87 RID: 7047
	[CompilerGenerated]
	[Serializable]
	internal sealed class $StartEvent$43963 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600A4B2 RID: 42162 RVA: 0x0129B60C File Offset: 0x0129980C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $StartEvent$43963(M936_CrossingDestiny2 self_)
		{
			if (233983 - 215882 != 18101)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (201928 - 148649 != 53280)
				{
					base..ctor();
					if (11269 - 514322 == -503053)
					{
						this.$self_$43972 = self_;
						if (21334 - 572884 == -551550)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x0600A4B3 RID: 42163 RVA: 0x0129B6A4 File Offset: 0x012998A4
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M936_CrossingDestiny2.$StartEvent$43963.$(this.$self_$43972);
		}

		// Token: 0x0600A4B4 RID: 42164 RVA: 0x0129B6B4 File Offset: 0x012998B4
		internal static bool PFdgOcVDyu1FMsCWZZ2U()
		{
			return true;
		}

		// Token: 0x0600A4B5 RID: 42165 RVA: 0x0129B6B8 File Offset: 0x012998B8
		internal static bool ajwbXxVDSZLqmnSI7cyK()
		{
			return false;
		}

		// Token: 0x040093B1 RID: 37809
		internal M936_CrossingDestiny2 $self_$43972;

		// Token: 0x02001B88 RID: 7048
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600A4B6 RID: 42166 RVA: 0x0129B6BC File Offset: 0x012998BC
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M936_CrossingDestiny2 self_)
			{
				if (12398 - 177841 != -165442)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (134920 - 519480 != -384559)
					{
						base..ctor();
						if (190361 - 523158 == -332797)
						{
							this.$self_$43971 = self_;
							if (201057 - 300233 != -99175)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x0600A4B7 RID: 42167 RVA: 0x0129B754 File Offset: 0x01299954
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (211904 - 325070 != -113166)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_876;
					case 2:
						if (Game.mGameState != eGameState.Start)
						{
							if (102952 - 374689 != -271736)
							{
								goto Block_41;
							}
							continue;
						}
						else
						{
							this.$mStoryGui$43969 = (StoryGui)this.$self_$43971.GetComponent(typeof(StoryGui));
							if (296516 - 282441 != 14075)
							{
								continue;
							}
							if (!this.$mStoryGui$43969)
							{
								if (120744 - 406788 != -286043)
								{
									goto Block_20;
								}
								continue;
							}
							else
							{
								this.$mStoryGui$43969.startStoryMessage("Liger", "Boldas", eTalkType.friend);
								if (12666 - 85388 != -72722)
								{
									continue;
								}
								goto IL_65E;
							}
						}
						break;
					case 3:
						if (Game.mGameState != eGameState.Start)
						{
							if (297139 - 334459 != -37319)
							{
								goto Block_49;
							}
							continue;
						}
						else
						{
							this.$mStoryGui$43969.newStoryMessage("Liger", "Boldas", "...", eTalkType.friend);
							if (67838 - 443733 != -375895)
							{
								continue;
							}
							if (!this.$mLiger$43968)
							{
								goto IL_EF;
							}
							if (289141 - 501255 != -212114)
							{
								continue;
							}
							this.$mLiger$43968.animation.CrossFade("talk", 0.2f);
							if (84798 - 228887 != -144089)
							{
								continue;
							}
							goto IL_EF;
						}
						break;
					case 4:
						if (Game.mGameState != eGameState.Start)
						{
							if (249777 - 284904 != -35126)
							{
								goto Block_8;
							}
							continue;
						}
						else
						{
							this.$mStoryGui$43969.newStoryMessage("Liger", "Boldas", Language.getMessage("M936_CrossingDestiny", 201), eTalkType.friend);
							if (227045 - 116778 != 110268)
							{
								goto Block_50;
							}
							continue;
						}
						break;
					case 5:
						if (Game.mGameState != eGameState.Start)
						{
							if (189457 - 353221 != -163763)
							{
								goto Block_22;
							}
							continue;
						}
						else
						{
							this.$mStoryGui$43969.newStoryMessage("Liger", "Boldas", Language.getMessage("M936_CrossingDestiny", 202), eTalkType.friend);
							if (221552 - 150965 != 70588)
							{
								goto Block_26;
							}
							continue;
						}
						break;
					case 6:
						if (Game.mGameState != eGameState.Start)
						{
							if (19291 - 512737 != -493445)
							{
								goto Block_45;
							}
							continue;
						}
						else
						{
							if (this.$mFakeCarrierBot$43967)
							{
								if (203073 - 31133 != 171940)
								{
									continue;
								}
								UnityEngine.Object.Destroy(this.$mFakeCarrierBot$43967);
								if (88645 - 430285 != -341640)
								{
									continue;
								}
							}
							this.$mStoryGui$43969.close();
							if (141404 - 47584 != 93820)
							{
								continue;
							}
							this.$self_$43971.w6Bn6sfAIlb.enabled = true;
							if (137695 - 221551 != -83855)
							{
								goto Block_14;
							}
							continue;
						}
						break;
					case 7:
						if (Game.mGameState != eGameState.Start)
						{
							if (101461 - 519670 != -418208)
							{
								goto Block_52;
							}
							continue;
						}
						else
						{
							this.$mGameGui$43970 = (GameGui)this.$self_$43971.GetComponent(typeof(GameGui));
							if (194928 - 199844 != -4916)
							{
								continue;
							}
							this.$mGameGui$43970.enabled = true;
							if (33087 - 30862 == 2226)
							{
								continue;
							}
							Game.mGameState = eGameState.Normal;
							if (121074 - 364637 == -243562)
							{
								continue;
							}
							Game.mStateTime = Time.time;
							if (58513 - 522959 != -464446)
							{
								continue;
							}
							this.YieldDefault(1);
							if (286796 - 431168 != -144372)
							{
								continue;
							}
							goto IL_876;
						}
						break;
					default:
						if (226809 - 561797 != -334988)
						{
							continue;
						}
						break;
					}
					Game.mGameState = eGameState.Start;
					if (42132 - 432025 == -389893)
					{
						Game.mStateTime = Time.time;
						if (27287 - 398758 == -371471)
						{
							this.$mWindBridge$43964 = GameObject.Find("WindBridge");
							if (282423 - 376296 == -93873)
							{
								if (this.$mWindBridge$43964)
								{
									if (127275 - 371764 == -244488)
									{
										continue;
									}
									this.$mWindBridge$43964.renderer.enabled = false;
									if (102017 - 541345 == -439327)
									{
										continue;
									}
								}
								this.$mWindGod$43965 = GameObject.Find("WindGod");
								if (298867 - 467714 == -168847)
								{
									if (this.$mWindGod$43965)
									{
										if (185304 - 85459 != 99845)
										{
											continue;
										}
										this.$self_$43971.yoNn6ZqOmOC = this.$mWindGod$43965.transform.position;
										if (9553 - 347266 != -337713)
										{
											continue;
										}
										this.$mWindGod$43965.transform.position = new Vector3((float)0, (float)-100, (float)0);
										if (39890 - 46479 == -6588)
										{
											continue;
										}
									}
									this.$mFalcon$43966 = GameObject.Find("Falcon");
									if (205706 - 518716 == -313010)
									{
										if (this.$mFalcon$43966)
										{
											if (226056 - 91105 == 134952)
											{
												continue;
											}
											this.$self_$43971.eoVn6Cfc1k5 = this.$mFalcon$43966.transform.position;
											if (80240 - 418902 == -338661)
											{
												continue;
											}
											this.$mFalcon$43966.transform.position = new Vector3((float)0, (float)-100, (float)0);
											if (268133 - 238915 == 29219)
											{
												continue;
											}
										}
										this.$mFakeCarrierBot$43967 = GameObject.Find("FakeCarrierBot");
										if (100182 - 466788 != -366605)
										{
											if (this.$mFakeCarrierBot$43967)
											{
												if (60010 - 334285 != -274275)
												{
													continue;
												}
												this.$mFakeCarrierBot$43967.animation.Play();
												if (219558 - 86173 == 133386)
												{
													continue;
												}
											}
											this.$mLiger$43968 = GameObject.Find("Liger");
											if (128515 - 33852 == 94663)
											{
												this.$self_$43971.w6Bn6sfAIlb.alignToObject("EventCamera1");
												if (3776 - 136578 != -132801)
												{
													this.$self_$43971.SendMessage("fadeIn");
													if (107476 - 373136 == -265660)
													{
														this.$self_$43971.w6Bn6sfAIlb.StartCoroutine_Auto(this.$self_$43971.w6Bn6sfAIlb.slerpToObject("EventCamera2", (float)6));
														if (271754 - 21531 == 250223)
														{
															goto IL_574;
														}
													}
												}
											}
										}
									}
								}
							}
						}
					}
				}
				IL_EF:
				return this.Yield(4, new WaitForSeconds(3f));
				Block_8:
				goto IL_876;
				Block_14:
				return this.Yield(7, new WaitForSeconds(1f));
				Block_20:
				Block_22:
				goto IL_876;
				Block_26:
				return this.Yield(6, new WaitForSeconds(3f));
				IL_574:
				return this.Yield(2, new WaitForSeconds(3f));
				Block_41:
				Block_45:
				goto IL_876;
				IL_65E:
				return this.Yield(3, new WaitForSeconds(0.5f));
				Block_49:
				goto IL_876;
				Block_50:
				return this.Yield(5, new WaitForSeconds(3f));
				Block_52:
				IL_876:
				return false;
			}

			// Token: 0x0600A4B8 RID: 42168 RVA: 0x0129BFEC File Offset: 0x0129A1EC
			internal static bool LWc0tTVDoCPqQgFPPwBu()
			{
				return true;
			}

			// Token: 0x0600A4B9 RID: 42169 RVA: 0x0129BFF0 File Offset: 0x0129A1F0
			internal static bool rcK6Y7VDEvHr0W9OQ5sE()
			{
				return false;
			}

			// Token: 0x040093B2 RID: 37810
			internal GameObject $mWindBridge$43964;

			// Token: 0x040093B3 RID: 37811
			internal GameObject $mWindGod$43965;

			// Token: 0x040093B4 RID: 37812
			internal GameObject $mFalcon$43966;

			// Token: 0x040093B5 RID: 37813
			internal GameObject $mFakeCarrierBot$43967;

			// Token: 0x040093B6 RID: 37814
			internal GameObject $mLiger$43968;

			// Token: 0x040093B7 RID: 37815
			internal StoryGui $mStoryGui$43969;

			// Token: 0x040093B8 RID: 37816
			internal GameGui $mGameGui$43970;

			// Token: 0x040093B9 RID: 37817
			internal M936_CrossingDestiny2 $self_$43971;
		}
	}

	// Token: 0x02001B89 RID: 7049
	[CompilerGenerated]
	[Serializable]
	internal sealed class $BoldasEvent$43973 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600A4BA RID: 42170 RVA: 0x0129BFF4 File Offset: 0x0129A1F4
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $BoldasEvent$43973(M936_CrossingDestiny2 self_)
		{
			if (292292 - 346975 != -54682)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (37952 - 438638 != -400685)
				{
					base..ctor();
					if (81700 - 268118 != -186417)
					{
						this.$self_$43983 = self_;
						if (72989 - 468143 == -395154)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x0600A4BB RID: 42171 RVA: 0x0129C08C File Offset: 0x0129A28C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M936_CrossingDestiny2.$BoldasEvent$43973.$(this.$self_$43983);
		}

		// Token: 0x0600A4BC RID: 42172 RVA: 0x0129C09C File Offset: 0x0129A29C
		internal static bool zKAikwVD2iGYQDBwHEQa()
		{
			return true;
		}

		// Token: 0x0600A4BD RID: 42173 RVA: 0x0129C0A0 File Offset: 0x0129A2A0
		internal static bool M3TAysVD8FMV2JeK3Vko()
		{
			return false;
		}

		// Token: 0x040093BA RID: 37818
		internal M936_CrossingDestiny2 $self_$43983;

		// Token: 0x02001B8A RID: 7050
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600A4BE RID: 42174 RVA: 0x0129C0A4 File Offset: 0x0129A2A4
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M936_CrossingDestiny2 self_)
			{
				if (227898 - 178711 != 49187)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (89100 - 167191 == -78091)
					{
						base..ctor();
						if (105750 - 200827 != -95076)
						{
							this.$self_$43982 = self_;
							if (74192 - 322954 == -248762)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x0600A4BF RID: 42175 RVA: 0x0129C13C File Offset: 0x0129A33C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (79856 - 549708 != -469852)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_16D3;
					case 2:
						if (Game.mGameState != eGameState.AllHold)
						{
							if (296706 - 367364 != -70657)
							{
								goto Block_143;
							}
							continue;
						}
						else
						{
							this.$mLiger$43975 = GameObject.Find("Liger");
							if (128023 - 48958 != 79065)
							{
								continue;
							}
							if (this.$mLiger$43975)
							{
								if (9228 - 344821 == -335592)
								{
									continue;
								}
								this.$mLiger$43975.animation.CrossFade("ko", 0.2f);
								if (217749 - 151408 != 66341)
								{
									continue;
								}
								this.$mLiger$43975.animation.wrapMode = WrapMode.Once;
								if (233413 - 599432 == -366018)
								{
									continue;
								}
							}
							this.$self_$43982.SendMessage("fadeOut");
							if (1066 - 429201 != -428134)
							{
								goto Block_50;
							}
							continue;
						}
						break;
					case 3:
						if (Game.mGameState != eGameState.AllHold)
						{
							if (91644 - 18822 != 72823)
							{
								goto Block_66;
							}
							continue;
						}
						else
						{
							this.$self_$43982.w6Bn6sfAIlb.alignToObject("EventCamera11");
							if (38727 - 484696 != -445969)
							{
								continue;
							}
							this.$self_$43982.w6Bn6sfAIlb.enabled = false;
							if (85897 - 21073 != 64824)
							{
								continue;
							}
							this.$mPlayer$43976 = Game.mPlayer;
							if (256651 - 578820 != -322169)
							{
								continue;
							}
							this.$mSpawnPoint$43977 = GameObject.Find("SpawnPoint1" + Game.getPlayerSlot(PlayerData.UID));
							if (207650 - 284497 == -76846)
							{
								continue;
							}
							if (this.$mPlayer$43976)
							{
								if (55513 - 39730 == 15784)
								{
									continue;
								}
								if (this.$mSpawnPoint$43977)
								{
									if (89517 - 363270 == -273752)
									{
										continue;
									}
									this.$mPlayer$43976.transform.position = this.$mSpawnPoint$43977.transform.position;
									if (52045 - 287692 == -235646)
									{
										continue;
									}
									this.$mPlayer$43976.transform.rotation = this.$mSpawnPoint$43977.transform.rotation;
									if (78190 - 87014 == -8823)
									{
										continue;
									}
									this.$mPlayer$43976.SendMessage("PositionEvent");
									if (285653 - 285874 != -221)
									{
										continue;
									}
								}
							}
							this.$self_$43982.SendMessage("fadeIn");
							if (206086 - 194973 != 11114)
							{
								goto Block_32;
							}
							continue;
						}
						break;
					case 4:
						if (Game.mGameState != eGameState.AllHold)
						{
							if (32028 - 205920 != -173892)
							{
								continue;
							}
							goto IL_1B9;
						}
						else
						{
							this.$mStoryGui$43978 = (StoryGui)this.$self_$43982.GetComponent(typeof(StoryGui));
							if (140555 - 477353 != -336798)
							{
								continue;
							}
							if (!this.$mStoryGui$43978)
							{
								if (124544 - 364740 != -240195)
								{
									goto Block_83;
								}
								continue;
							}
							else
							{
								this.$mStoryGui$43978.startStoryMessage("Liger", "Boldas", eTalkType.friend);
								if (223492 - 553346 != -329853)
								{
									goto Block_86;
								}
								continue;
							}
						}
						break;
					case 5:
						if (Game.mGameState != eGameState.AllHold)
						{
							if (258418 - 503887 != -245469)
							{
								continue;
							}
							goto IL_129D;
						}
						else
						{
							this.$mStoryGui$43978.newStoryMessage("Liger", "Boldas", Language.getMessage("M936_CrossingDestiny", 221), eTalkType.friend);
							if (94972 - 408827 != -313855)
							{
								continue;
							}
							goto IL_13F6;
						}
						break;
					case 6:
						if (Game.mGameState != eGameState.AllHold)
						{
							if (128069 - 237213 != -109144)
							{
								continue;
							}
							goto IL_386;
						}
						else
						{
							this.$mStoryGui$43978.newStoryMessage("Liger", "Boldas", Language.getMessage("M936_CrossingDestiny", 222), eTalkType.friend);
							if (279859 - 472657 != -192798)
							{
								continue;
							}
							goto IL_1232;
						}
						break;
					case 7:
						if (Game.mGameState != eGameState.AllHold)
						{
							if (201437 - 464978 != -263540)
							{
								goto Block_124;
							}
							continue;
						}
						else
						{
							this.$mStoryGui$43978.newStoryMessage("Liger", "Boldas", Language.getMessage("M936_CrossingDestiny", 223), eTalkType.friend);
							if (191265 - 108335 != 82931)
							{
								goto Block_6;
							}
							continue;
						}
						break;
					case 8:
						if (Game.mGameState != eGameState.AllHold)
						{
							if (96890 - 160241 != -63351)
							{
								continue;
							}
							goto IL_81;
						}
						else
						{
							this.$mStoryGui$43978.newStoryMessage("Liger", "Boldas", Language.getMessage("M936_CrossingDestiny", 224), eTalkType.friend);
							if (72833 - 5596 != 67237)
							{
								continue;
							}
							goto IL_ACF;
						}
						break;
					case 9:
						if (Game.mGameState != eGameState.AllHold)
						{
							if (38266 - 97461 != -59195)
							{
								continue;
							}
							goto IL_145C;
						}
						else
						{
							this.$mStoryGui$43978.newStoryMessage(CharacterData.current.Type, CharacterData.current.Name, Language.getMessage("M936_CrossingDestiny", 225), eTalkType.friend);
							if (120998 - 295285 != -174286)
							{
								goto Block_140;
							}
							continue;
						}
						break;
					case 10:
						if (Game.mGameState != eGameState.AllHold)
						{
							if (72003 - 210800 != -138797)
							{
								continue;
							}
							goto IL_222;
						}
						else
						{
							this.$self_$43982.w6Bn6sfAIlb.alignToObject("EventCamera12");
							if (12317 - 439015 != -426698)
							{
								continue;
							}
							this.$mWindGod$43979 = GameObject.Find("WindGod");
							if (232200 - 507021 == -274820)
							{
								continue;
							}
							if (this.$mWindGod$43979)
							{
								if (83888 - 389512 != -305624)
								{
									continue;
								}
								this.$mWindGod$43979.transform.position = this.$self_$43982.yoNn6ZqOmOC;
								if (173920 - 297028 != -123108)
								{
									continue;
								}
							}
							if (this.$mWindGod$43979)
							{
								if (253248 - 16992 == 236257)
								{
									continue;
								}
								this.$mWindGod$43979.animation.Play("nAttack");
								if (289413 - 583527 != -294114)
								{
									continue;
								}
							}
							if (this.$self_$43982.windGodEffect)
							{
								if (494 - 179845 != -179351)
								{
									continue;
								}
								UnityEngine.Object.Instantiate(this.$self_$43982.windGodEffect, this.$self_$43982.yoNn6ZqOmOC, Quaternion.identity);
								if (100474 - 125830 == -25355)
								{
									continue;
								}
							}
							this.$mStoryGui$43978.newStoryMessage("WindGod", "Sun Sun", Language.getMessage("M936_CrossingDestiny", 226), eTalkType.friend);
							if (22790 - 379261 != -356471)
							{
								continue;
							}
							goto IL_BCF;
						}
						break;
					case 11:
						if (Game.mGameState != eGameState.AllHold)
						{
							if (236456 - 178652 != 57805)
							{
								goto Block_80;
							}
							continue;
						}
						else
						{
							if (!this.$mWindGod$43979)
							{
								goto IL_45;
							}
							if (135358 - 329593 == -194234)
							{
								continue;
							}
							this.$mWindGod$43979.animation.CrossFade("root", 0.2f);
							if (197969 - 491167 != -293197)
							{
								goto Block_129;
							}
							continue;
						}
						break;
					case 12:
						if (Game.mGameState != eGameState.AllHold)
						{
							if (258545 - 30457 != 228089)
							{
								goto Block_4;
							}
							continue;
						}
						else
						{
							this.$mStoryGui$43978.newStoryMessage("Liger", "Boldas", Language.getMessage("M936_CrossingDestiny", 227), eTalkType.friend);
							if (54436 - 568531 == -514094)
							{
								continue;
							}
							if (!this.$mLiger$43975)
							{
								goto IL_649;
							}
							if (20071 - 377362 == -357290)
							{
								continue;
							}
							this.$mLiger$43975.animation.Play("getUp");
							if (204817 - 435627 != -230810)
							{
								continue;
							}
							this.$mLiger$43975.animation.wrapMode = WrapMode.Once;
							if (217714 - 111287 != 106428)
							{
								goto Block_151;
							}
							continue;
						}
						break;
					case 13:
						if (Game.mGameState != eGameState.AllHold)
						{
							if (123995 - 343934 != -219938)
							{
								goto Block_39;
							}
							continue;
						}
						else
						{
							if (!this.$mLiger$43975)
							{
								goto IL_105F;
							}
							if (284805 - 531357 == -246551)
							{
								continue;
							}
							this.$mLiger$43975.animation.Play("talk");
							if (273364 - 223739 != 49625)
							{
								continue;
							}
							this.$mLiger$43975.animation.wrapMode = WrapMode.Loop;
							if (120757 - 384499 != -263741)
							{
								goto Block_98;
							}
							continue;
						}
						break;
					case 14:
						if (Game.mGameState != eGameState.AllHold)
						{
							if (199101 - 338428 != -139326)
							{
								goto Block_111;
							}
							continue;
						}
						else
						{
							this.$mStoryGui$43978.newStoryMessage("Liger", "Boldas", Language.getMessage("M936_CrossingDestiny", 228), eTalkType.friend);
							if (265844 - 285766 != -19921)
							{
								goto Block_89;
							}
							continue;
						}
						break;
					case 15:
						if (Game.mGameState != eGameState.AllHold)
						{
							if (83434 - 263437 != -180003)
							{
								continue;
							}
							goto IL_154B;
						}
						else
						{
							this.$mStoryGui$43978.newStoryMessage("WindGod", "Sun Sun", Language.getMessage("M936_CrossingDestiny", 229), eTalkType.friend);
							if (92162 - 362950 == -270787)
							{
								continue;
							}
							if (!this.$mLiger$43975)
							{
								goto IL_830;
							}
							if (278752 - 321563 != -42811)
							{
								continue;
							}
							this.$mLiger$43975.animation.CrossFade("root", 0.2f);
							if (84776 - 205287 != -120511)
							{
								continue;
							}
							goto IL_830;
						}
						break;
					case 16:
						if (Game.mGameState != eGameState.AllHold)
						{
							if (219632 - 184773 != 34860)
							{
								goto Block_52;
							}
							continue;
						}
						else
						{
							this.$mStoryGui$43978.newStoryMessage("WindGod", "Sun Sun", Language.getMessage("M936_CrossingDestiny", 230), eTalkType.friend);
							if (71677 - 518416 != -446739)
							{
								continue;
							}
							goto IL_9D7;
						}
						break;
					case 17:
						if (Game.mGameState != eGameState.AllHold)
						{
							if (256502 - 423970 != -167467)
							{
								goto Block_64;
							}
							continue;
						}
						else
						{
							this.$self_$43982.w6Bn6sfAIlb.alignToObject("EventCamera13");
							if (188781 - 278535 != -89754)
							{
								continue;
							}
							this.$mStoryGui$43978.newStoryMessage("WindGod", "Sun Sun", Language.getMessage("M936_CrossingDestiny", 231), eTalkType.friend);
							if (165244 - 343142 != -177898)
							{
								continue;
							}
							goto IL_976;
						}
						break;
					case 18:
						if (Game.mGameState != eGameState.AllHold)
						{
							if (105341 - 463771 != -358429)
							{
								goto Block_61;
							}
							continue;
						}
						else
						{
							this.$self_$43982.w6Bn6sfAIlb.StartCoroutine_Auto(this.$self_$43982.w6Bn6sfAIlb.slerpToObject("EventCamera14", (float)3));
							if (178067 - 556182 == -378114)
							{
								continue;
							}
							this.$mStoryGui$43978.newStoryMessage("WindGod", "Sun Sun", Language.getMessage("M936_CrossingDestiny", 232), eTalkType.friend);
							if (104743 - 200909 != -96165)
							{
								goto Block_7;
							}
							continue;
						}
						break;
					case 19:
						if (Game.mGameState != eGameState.AllHold)
						{
							if (181159 - 487272 != -306113)
							{
								continue;
							}
							goto IL_791;
						}
						else
						{
							this.$self_$43982.SendMessage("fadeOutTimer", 0.5f);
							if (281145 - 458500 != -177354)
							{
								goto Block_47;
							}
							continue;
						}
						break;
					case 20:
						if (Game.mGameState != eGameState.AllHold)
						{
							if (210727 - 49559 != 161169)
							{
								goto Block_115;
							}
							continue;
						}
						else
						{
							this.$mWindBridge$43980 = GameObject.Find("WindBridge");
							if (72907 - 67031 != 5876)
							{
								continue;
							}
							if (this.$mWindBridge$43980)
							{
								if (218176 - 118077 == 100100)
								{
									continue;
								}
								this.$mWindBridge$43980.renderer.enabled = true;
								if (64725 - 540013 != -475288)
								{
									continue;
								}
								if (this.$self_$43982.windBridgeEffect)
								{
									if (185517 - 269350 != -83833)
									{
										continue;
									}
									UnityEngine.Object.Instantiate(this.$self_$43982.windBridgeEffect, this.$mWindBridge$43980.transform.position, this.$mWindBridge$43980.transform.rotation);
									if (294982 - 44014 != 250968)
									{
										continue;
									}
								}
							}
							this.$self_$43982.SendMessage("fadeInTimer", 0.5f);
							if (49915 - 259345 != -209429)
							{
								goto Block_8;
							}
							continue;
						}
						break;
					case 21:
						if (Game.mGameState != eGameState.AllHold)
						{
							if (232327 - 105279 != 127049)
							{
								goto Block_78;
							}
							continue;
						}
						else
						{
							this.$self_$43982.w6Bn6sfAIlb.alignToObject("EventCamera12");
							if (72296 - 598814 == -526517)
							{
								continue;
							}
							this.$mStoryGui$43978.newStoryMessage("WindGod", "Sun Sun", Language.getMessage("M936_CrossingDestiny", 233), eTalkType.friend);
							if (13912 - 440672 != -426760)
							{
								continue;
							}
							if (!this.$mWindGod$43979)
							{
								goto IL_1390;
							}
							if (176538 - 243405 != -66867)
							{
								continue;
							}
							this.$mWindGod$43979.animation.Play("ko");
							if (172562 - 111653 != 60909)
							{
								continue;
							}
							this.$mWindGod$43979.animation.wrapMode = WrapMode.Once;
							if (86641 - 518571 != -431930)
							{
								continue;
							}
							goto IL_1390;
						}
						break;
					case 22:
						if (Game.mGameState != eGameState.AllHold)
						{
							if (96222 - 233390 != -137168)
							{
								continue;
							}
							goto IL_EC7;
						}
						else
						{
							if (!this.$mWindGod$43979)
							{
								goto IL_6C1;
							}
							if (168502 - 140750 != 27752)
							{
								continue;
							}
							this.$mWindGod$43979.animation.Play("faint");
							if (193586 - 237981 != -44395)
							{
								continue;
							}
							this.$mWindGod$43979.animation.wrapMode = WrapMode.Loop;
							if (79250 - 251335 != -172084)
							{
								goto Block_84;
							}
							continue;
						}
						break;
					case 23:
						if (Game.mGameState != eGameState.AllHold)
						{
							if (293399 - 442239 != -148839)
							{
								goto Block_43;
							}
							continue;
						}
						else
						{
							this.$mStoryGui$43978.newStoryMessage("Liger", "Boldas", Language.getMessage("M936_CrossingDestiny", 234), eTalkType.friend);
							if (79122 - 170508 == -91385)
							{
								continue;
							}
							if (!this.$mLiger$43975)
							{
								goto IL_A93;
							}
							if (81477 - 85928 == -4450)
							{
								continue;
							}
							this.$mLiger$43975.animation.CrossFade("talk", 0.2f);
							if (11282 - 274917 != -263634)
							{
								goto Block_81;
							}
							continue;
						}
						break;
					case 24:
						if (Game.mGameState != eGameState.AllHold)
						{
							if (146982 - 266685 != -119702)
							{
								goto Block_69;
							}
							continue;
						}
						else
						{
							this.$mStoryGui$43978.close();
							if (117017 - 286794 == -169776)
							{
								continue;
							}
							this.$self_$43982.w6Bn6sfAIlb.enabled = true;
							if (97114 - 540910 != -443795)
							{
								goto Block_107;
							}
							continue;
						}
						break;
					case 25:
						if (Game.mGameState != eGameState.AllHold)
						{
							if (40721 - 316041 != -275319)
							{
								goto Block_109;
							}
							continue;
						}
						else
						{
							Game.mGameState = eGameState.Normal;
							if (298632 - 83453 == 215180)
							{
								continue;
							}
							Game.mStateTime = Time.time;
							if (246201 - 314556 == -68354)
							{
								continue;
							}
							this.$mGameGui$43974.enabled = true;
							if (54423 - 167506 == -113082)
							{
								continue;
							}
							this.$mEventWall1$43981 = GameObject.Find("EventWall1");
							if (168365 - 89479 == 78887)
							{
								continue;
							}
							if (this.$mEventWall1$43981)
							{
								if (126065 - 437117 != -311052)
								{
									continue;
								}
								UnityEngine.Object.Destroy(this.$mEventWall1$43981);
								if (175698 - 238014 != -62316)
								{
									continue;
								}
							}
							this.$self_$43982.tBSn67Fntml = 2;
							if (4458 - 581600 != -577142)
							{
								continue;
							}
							Game.sendMissionEvent(9362, 2);
							if (148453 - 43199 != 105254)
							{
								continue;
							}
							this.YieldDefault(1);
							if (96575 - 219279 != -122704)
							{
								continue;
							}
							goto IL_16D3;
						}
						break;
					default:
						if (63206 - 204100 != -140894)
						{
							continue;
						}
						break;
					}
					Debug.Log("BoldasEvent");
					if (16435 - 167471 == -151036)
					{
						if (Game.mGameState != eGameState.Normal)
						{
							if (193697 - 358943 == -165246)
							{
								goto IL_1526;
							}
						}
						else
						{
							Game.mGameState = eGameState.AllHold;
							if (181063 - 266431 != -85367)
							{
								this.$mGameGui$43974 = (GameGui)this.$self_$43982.GetComponent(typeof(GameGui));
								if (192097 - 127797 == 64300)
								{
									if (!this.$mGameGui$43974)
									{
										goto IL_14EB;
									}
									if (218060 - 286071 != -68010)
									{
										this.$mGameGui$43974.close();
										if (108726 - 281840 != -173113)
										{
											goto Block_118;
										}
									}
								}
							}
						}
					}
				}
				IL_45:
				return this.Yield(12, new WaitForSeconds(3f));
				Block_4:
				IL_81:
				goto IL_16D3;
				Block_6:
				return this.Yield(8, new WaitForSeconds(3f));
				Block_7:
				return this.Yield(19, new WaitForSeconds(2f));
				Block_8:
				return this.Yield(21, new WaitForSeconds(3f));
				IL_1B9:
				IL_222:
				IL_386:
				goto IL_16D3;
				Block_32:
				return this.Yield(4, new WaitForSeconds(1f));
				IL_649:
				return this.Yield(13, new WaitForSeconds(1f));
				Block_39:
				goto IL_16D3;
				IL_6C1:
				return this.Yield(23, new WaitForSeconds(2f));
				Block_43:
				IL_791:
				goto IL_16D3;
				Block_47:
				return this.Yield(20, new WaitForSeconds(0.5f));
				Block_50:
				return this.Yield(3, new WaitForSeconds(1f));
				IL_830:
				return this.Yield(16, new WaitForSeconds(3f));
				Block_52:
				goto IL_16D3;
				IL_976:
				return this.Yield(18, new WaitForSeconds(3f));
				Block_61:
				goto IL_16D3;
				IL_9D7:
				return this.Yield(17, new WaitForSeconds(3f));
				Block_64:
				Block_66:
				goto IL_16D3;
				IL_A93:
				return this.Yield(24, new WaitForSeconds(2.5f));
				Block_69:
				goto IL_16D3;
				IL_ACF:
				return this.Yield(9, new WaitForSeconds(2.5f));
				Block_78:
				goto IL_16D3;
				IL_BCF:
				return this.Yield(11, new WaitForSeconds(1f));
				Block_80:
				goto IL_16D3;
				Block_81:
				goto IL_A93;
				Block_83:
				goto IL_16D3;
				Block_84:
				goto IL_6C1;
				Block_86:
				return this.Yield(5, new WaitForSeconds(0.5f));
				Block_89:
				return this.Yield(15, new WaitForSeconds(3f));
				Block_98:
				goto IL_105F;
				IL_EC7:
				goto IL_16D3;
				Block_107:
				return this.Yield(25, new WaitForSeconds(1f));
				Block_109:
				goto IL_16D3;
				IL_105F:
				return this.Yield(14, new WaitForSeconds(1f));
				Block_111:
				Block_115:
				goto IL_16D3;
				Block_118:
				goto IL_14EB;
				IL_1232:
				return this.Yield(7, new WaitForSeconds(3f));
				Block_124:
				IL_129D:
				goto IL_16D3;
				Block_129:
				goto IL_45;
				IL_1390:
				return this.Yield(22, new WaitForSeconds(1f));
				IL_13F6:
				return this.Yield(6, new WaitForSeconds(3f));
				IL_145C:
				goto IL_16D3;
				Block_140:
				return this.Yield(10, new WaitForSeconds(3f));
				IL_14EB:
				return this.Yield(2, new WaitForSeconds(0.5f));
				Block_143:
				IL_1526:
				IL_154B:
				goto IL_16D3;
				Block_151:
				goto IL_649;
				IL_16D3:
				return false;
			}

			// Token: 0x0600A4C0 RID: 42176 RVA: 0x0129D830 File Offset: 0x0129BA30
			internal static bool qWGsyGVDZvDYxjRd350H()
			{
				return true;
			}

			// Token: 0x0600A4C1 RID: 42177 RVA: 0x0129D834 File Offset: 0x0129BA34
			internal static bool NWi2TNVDCxXe8ikdg8C5()
			{
				return false;
			}

			// Token: 0x040093BB RID: 37819
			internal GameGui $mGameGui$43974;

			// Token: 0x040093BC RID: 37820
			internal GameObject $mLiger$43975;

			// Token: 0x040093BD RID: 37821
			internal GameObject $mPlayer$43976;

			// Token: 0x040093BE RID: 37822
			internal GameObject $mSpawnPoint$43977;

			// Token: 0x040093BF RID: 37823
			internal StoryGui $mStoryGui$43978;

			// Token: 0x040093C0 RID: 37824
			internal GameObject $mWindGod$43979;

			// Token: 0x040093C1 RID: 37825
			internal GameObject $mWindBridge$43980;

			// Token: 0x040093C2 RID: 37826
			internal GameObject $mEventWall1$43981;

			// Token: 0x040093C3 RID: 37827
			internal M936_CrossingDestiny2 $self_$43982;
		}
	}

	// Token: 0x02001B8B RID: 7051
	[CompilerGenerated]
	[Serializable]
	internal sealed class $ItalusEvent$43984 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600A4C2 RID: 42178 RVA: 0x0129D838 File Offset: 0x0129BA38
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $ItalusEvent$43984(M936_CrossingDestiny2 self_)
		{
			if (81065 - 367605 != -286539)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (38441 - 7439 == 31002)
				{
					base..ctor();
					if (204030 - 532036 != -328005)
					{
						this.$self_$43996 = self_;
						if (58813 - 160880 == -102067)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x0600A4C3 RID: 42179 RVA: 0x0129D8D0 File Offset: 0x0129BAD0
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M936_CrossingDestiny2.$ItalusEvent$43984.$(this.$self_$43996);
		}

		// Token: 0x0600A4C4 RID: 42180 RVA: 0x0129D8E0 File Offset: 0x0129BAE0
		internal static bool R9oU8DVDLil3CKFrfM6m()
		{
			return true;
		}

		// Token: 0x0600A4C5 RID: 42181 RVA: 0x0129D8E4 File Offset: 0x0129BAE4
		internal static bool WKNc0WVDOuAkdeGhc5qP()
		{
			return false;
		}

		// Token: 0x040093C4 RID: 37828
		internal M936_CrossingDestiny2 $self_$43996;

		// Token: 0x02001B8C RID: 7052
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600A4C6 RID: 42182 RVA: 0x0129D8E8 File Offset: 0x0129BAE8
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M936_CrossingDestiny2 self_)
			{
				if (168760 - 531059 != -362298)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (111887 - 519927 != -408039)
					{
						base..ctor();
						if (192135 - 110656 == 81479)
						{
							this.$self_$43995 = self_;
							if (139541 - 267149 != -127607)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x0600A4C7 RID: 42183 RVA: 0x0129D980 File Offset: 0x0129BB80
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (158700 - 32198 != 126502)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						goto IL_E3C;
					case 1:
						goto IL_1A4E;
					case 2:
						if (Game.mGameState != eGameState.AllHold)
						{
							if (96447 - 168646 != -72198)
							{
								goto Block_60;
							}
							continue;
						}
						else
						{
							this.$self_$43995.SendMessage("fadeOut");
							if (181739 - 376612 != -194872)
							{
								goto Block_129;
							}
							continue;
						}
						break;
					case 3:
						if (Game.mGameState != eGameState.AllHold)
						{
							if (43469 - 42912 != 558)
							{
								goto Block_114;
							}
							continue;
						}
						else
						{
							this.$self_$43995.w6Bn6sfAIlb.alignToObject("EventCamera21");
							if (135405 - 545562 == -410156)
							{
								continue;
							}
							this.$self_$43995.w6Bn6sfAIlb.enabled = false;
							if (98914 - 285874 != -186960)
							{
								continue;
							}
							this.$mPlayer$43986 = Game.mPlayer;
							if (146513 - 246065 != -99552)
							{
								continue;
							}
							this.$mSpawnPoint$43987 = GameObject.Find("SpawnPoint2" + Game.getPlayerSlot(PlayerData.UID));
							if (224978 - 562789 != -337811)
							{
								continue;
							}
							if (this.$mPlayer$43986)
							{
								if (14100 - 247219 == -233118)
								{
									continue;
								}
								if (this.$mSpawnPoint$43987)
								{
									if (28184 - 202910 == -174725)
									{
										continue;
									}
									this.$mPlayer$43986.transform.position = this.$mSpawnPoint$43987.transform.position;
									if (187555 - 487710 != -300155)
									{
										continue;
									}
									this.$mPlayer$43986.transform.rotation = this.$mSpawnPoint$43987.transform.rotation;
									if (127372 - 404240 == -276867)
									{
										continue;
									}
									this.$mPlayer$43986.SendMessage("PositionEvent");
									if (168468 - 238504 != -70036)
									{
										continue;
									}
								}
							}
							this.$self_$43995.audio.Stop();
							if (67643 - 387456 == -319812)
							{
								continue;
							}
							this.$self_$43995.SendMessage("fadeIn");
							if (159219 - 284045 != -124826)
							{
								continue;
							}
							goto IL_19CE;
						}
						break;
					case 4:
						if (Game.mGameState != eGameState.AllHold)
						{
							if (92250 - 90862 != 1389)
							{
								goto Block_176;
							}
							continue;
						}
						else
						{
							this.$mStoryGui$43988 = (StoryGui)this.$self_$43995.GetComponent(typeof(StoryGui));
							if (203828 - 76758 != 127070)
							{
								continue;
							}
							this.$mStoryTimer$43989 = 0f;
							if (87054 - 339682 == -252627)
							{
								continue;
							}
							if (!this.$mStoryGui$43988)
							{
								if (134279 - 271112 != -136833)
								{
									continue;
								}
								goto IL_74;
							}
							else
							{
								this.$mDarkFalcon$43990 = GameObject.Find("DarkFalcon");
								if (195095 - 290591 != -95496)
								{
									continue;
								}
								this.$mStoryGui$43988.startStoryMessage("Falcon", "Italus", eTalkType.friend);
								if (270686 - 362969 != -92282)
								{
									goto Block_2;
								}
								continue;
							}
						}
						break;
					case 5:
						if (Game.mGameState != eGameState.AllHold)
						{
							if (119123 - 225882 != -106758)
							{
								goto Block_47;
							}
							continue;
						}
						else
						{
							this.$mStoryGui$43988.newStoryMessage("Falcon", "Italus", Language.getMessage("M936_CrossingDestiny", 301), eTalkType.friend);
							if (146249 - 109397 == 36853)
							{
								continue;
							}
							this.$mFalcon$43991 = GameObject.Find("Falcon");
							if (169023 - 318792 == -149768)
							{
								continue;
							}
							if (!this.$mFalcon$43991)
							{
								goto IL_1518;
							}
							if (22649 - 219265 != -196616)
							{
								continue;
							}
							this.$mFalcon$43991.transform.position = this.$self_$43995.eoVn6Cfc1k5;
							if (296011 - 262683 != 33328)
							{
								continue;
							}
							this.$mFalcon$43991.animation.Play("flyDown");
							if (158381 - 446875 != -288493)
							{
								goto Block_159;
							}
							continue;
						}
						break;
					case 6:
						if (Game.mGameState != eGameState.AllHold)
						{
							if (11500 - 432041 != -420540)
							{
								goto Block_143;
							}
							continue;
						}
						else
						{
							if (!this.$mFalcon$43991)
							{
								goto IL_15E8;
							}
							if (134161 - 584973 == -450811)
							{
								continue;
							}
							this.$mFalcon$43991.animation.Play("root");
							if (214297 - 85325 != 128972)
							{
								continue;
							}
							goto IL_15E8;
						}
						break;
					case 7:
						if (Game.mGameState != eGameState.AllHold)
						{
							if (3619 - 213229 != -209609)
							{
								goto Block_147;
							}
							continue;
						}
						else
						{
							if (this.$self_$43995.BattleMusic)
							{
								if (190 - 430415 == -430224)
								{
									continue;
								}
								this.$self_$43995.audio.clip = this.$self_$43995.BattleMusic;
								if (26718 - 212904 == -186185)
								{
									continue;
								}
								this.$self_$43995.audio.volume = 0.1f * (float)Game.music;
								if (47308 - 209357 != -162049)
								{
									continue;
								}
								this.$self_$43995.audio.Play();
								if (54093 - 568148 != -514055)
								{
									continue;
								}
							}
							this.$mStoryGui$43988.newStoryMessage(CharacterData.current.Type, CharacterData.current.Name, Language.getMessage("M936_CrossingDestiny", 302), eTalkType.friend);
							if (259604 - 424810 != -165205)
							{
								goto Block_104;
							}
							continue;
						}
						break;
					case 8:
						if (Game.mGameState != eGameState.AllHold)
						{
							if (84336 - 377932 != -293595)
							{
								goto Block_166;
							}
							continue;
						}
						else
						{
							this.$mStoryGui$43988.newStoryMessage("Falcon", "Italus", Language.getMessage("M936_CrossingDestiny", 303), eTalkType.friend);
							if (167224 - 275955 == -108730)
							{
								continue;
							}
							this.$self_$43995.w6Bn6sfAIlb.alignToObject("EventCamera22");
							if (214296 - 411821 != -197525)
							{
								continue;
							}
							if (!this.$mFalcon$43991)
							{
								goto IL_10F8;
							}
							if (274361 - 413459 == -139097)
							{
								continue;
							}
							this.$mFalcon$43991.animation.CrossFade("talk");
							if (108075 - 184589 != -76514)
							{
								continue;
							}
							goto IL_10F8;
						}
						break;
					case 9:
						if (Game.mGameState != eGameState.AllHold)
						{
							if (235265 - 222551 != 12714)
							{
								continue;
							}
							goto IL_1374;
						}
						else
						{
							this.$mStoryGui$43988.newStoryMessage("Liger", "Boldas", Language.getMessage("M936_CrossingDestiny", 304), eTalkType.friend);
							if (10405 - 497909 == -487503)
							{
								continue;
							}
							this.$mLiger$43992 = GameObject.Find("Liger");
							if (182341 - 361488 == -179146)
							{
								continue;
							}
							this.$mSpawnPoint20$43993 = GameObject.Find("SpawnPoint20");
							if (166740 - 517170 != -350430)
							{
								continue;
							}
							if (!this.$mLiger$43992)
							{
								goto IL_90B;
							}
							if (271442 - 109169 != 162273)
							{
								continue;
							}
							this.$mLiger$43992.animation.Play("run");
							if (277360 - 14574 != 262786)
							{
								continue;
							}
							this.$mLiger$43992.animation.wrapMode = WrapMode.Loop;
							if (39117 - 447760 != -408643)
							{
								continue;
							}
							if (!this.$mSpawnPoint20$43993)
							{
								goto IL_90B;
							}
							if (292851 - 493588 == -200736)
							{
								continue;
							}
							this.$mStoryTimer$43989 = Time.time;
							if (168579 - 160857 != 7723)
							{
								goto IL_1630;
							}
							continue;
						}
						break;
					case 10:
						goto IL_1630;
					case 11:
						if (Game.mGameState != eGameState.AllHold)
						{
							if (12460 - 512776 != -500315)
							{
								goto Block_112;
							}
							continue;
						}
						else
						{
							this.$mStoryGui$43988.newStoryMessage("Falcon", "Italus", Language.getMessage("M936_CrossingDestiny", 305), eTalkType.friend);
							if (85244 - 194671 != -109427)
							{
								continue;
							}
							if (!this.$mFalcon$43991)
							{
								goto IL_492;
							}
							if (298833 - 164214 != 134619)
							{
								continue;
							}
							this.$mFalcon$43991.animation.CrossFade("root");
							if (132906 - 313009 != -180102)
							{
								goto Block_172;
							}
							continue;
						}
						break;
					case 12:
						if (Game.mGameState != eGameState.AllHold)
						{
							if (185786 - 376302 != -190515)
							{
								goto Block_37;
							}
							continue;
						}
						else
						{
							this.$mStoryGui$43988.newStoryMessage("Liger", "Boldas", Language.getMessage("M936_CrossingDestiny", 306), eTalkType.friend);
							if (124875 - 434517 != -309641)
							{
								goto Block_70;
							}
							continue;
						}
						break;
					case 13:
						if (Game.mGameState != eGameState.AllHold)
						{
							if (206072 - 447372 != -241299)
							{
								goto Block_27;
							}
							continue;
						}
						else
						{
							this.$mStoryGui$43988.newStoryMessage("Liger", "Boldas", Language.getMessage("M936_CrossingDestiny", 307), eTalkType.friend);
							if (88324 - 103556 != -15231)
							{
								goto Block_89;
							}
							continue;
						}
						break;
					case 14:
						if (Game.mGameState != eGameState.AllHold)
						{
							if (189294 - 71615 != 117679)
							{
								continue;
							}
							goto IL_DF;
						}
						else
						{
							if (!this.$mLiger$43992)
							{
								goto IL_1288;
							}
							if (121823 - 581944 == -460120)
							{
								continue;
							}
							this.$mLiger$43992.animation.Play("leapingLion");
							if (290464 - 122280 != 168184)
							{
								continue;
							}
							this.$mLiger$43992.animation.wrapMode = WrapMode.Once;
							if (288542 - 542309 != -253767)
							{
								continue;
							}
							if (this.$self_$43995.liger_nAttack3_vc)
							{
								if (79297 - 293992 != -214695)
								{
									continue;
								}
								this.$self_$43995.audio.PlayOneShot(this.$self_$43995.liger_nAttack3_vc);
								if (113752 - 274015 != -160263)
								{
									continue;
								}
							}
							this.$mStoryTimer$43989 = Time.time;
							if (278811 - 3066 == 275746)
							{
								continue;
							}
						}
						break;
					case 15:
						break;
					case 16:
						if (Game.mGameState != eGameState.AllHold)
						{
							if (220752 - 319986 != -99234)
							{
								continue;
							}
							goto IL_43E;
						}
						else
						{
							this.$mStoryGui$43988.blank();
							if (159589 - 125799 != 33790)
							{
								continue;
							}
							this.$self_$43995.w6Bn6sfAIlb.alignToObject("EventCamera24");
							if (174402 - 251534 != -77132)
							{
								continue;
							}
							if (this.$mFalcon$43991)
							{
								if (260626 - 516578 == -255951)
								{
									continue;
								}
								UnityEngine.Object.Destroy(this.$mFalcon$43991);
								if (155462 - 259814 == -104351)
								{
									continue;
								}
							}
							if (this.$mDarkFalcon$43990)
							{
								if (192773 - 252775 != -60002)
								{
									continue;
								}
								this.$mDarkFalcon$43990.transform.position = this.$self_$43995.eoVn6Cfc1k5;
								if (159600 - 107378 != 52222)
								{
									continue;
								}
							}
							if (this.$self_$43995.DarkFalcon_transform)
							{
								if (203607 - 412239 != -208632)
								{
									continue;
								}
								UnityEngine.Object.Instantiate(this.$self_$43995.DarkFalcon_transform, this.$self_$43995.eoVn6Cfc1k5, Quaternion.identity);
								if (156150 - 521524 == -365373)
								{
									continue;
								}
							}
							if (this.$mLiger$43992)
							{
								if (239871 - 425121 == -185249)
								{
									continue;
								}
								this.$mSpawnPoint26$43994 = GameObject.Find("SpawnPoint26");
								if (193669 - 561706 == -368036)
								{
									continue;
								}
								if (this.$mSpawnPoint26$43994)
								{
									if (189800 - 64261 == 125540)
									{
										continue;
									}
									this.$mLiger$43992.transform.position = this.$mSpawnPoint26$43994.transform.position;
									if (104194 - 177793 != -73599)
									{
										continue;
									}
								}
								this.$mLiger$43992.animation.Play("ko");
								if (16734 - 61240 == -44505)
								{
									continue;
								}
								this.$mLiger$43992.animation.wrapMode = WrapMode.Once;
								if (32348 - 97146 != -64798)
								{
									continue;
								}
							}
							this.$self_$43995.SendMessage("fadeInTimer", 0.5f);
							if (148375 - 416386 != -268010)
							{
								goto Block_38;
							}
							continue;
						}
						break;
					case 17:
						if (Game.mGameState != eGameState.AllHold)
						{
							if (166064 - 62671 != 103394)
							{
								goto Block_77;
							}
							continue;
						}
						else
						{
							this.$mStoryGui$43988.startStoryMessage("Liger", "Boldas", eTalkType.friend);
							if (29836 - 147832 != -117996)
							{
								continue;
							}
							goto IL_E60;
						}
						break;
					case 18:
						if (Game.mGameState != eGameState.AllHold)
						{
							if (94408 - 543324 != -448916)
							{
								continue;
							}
							goto IL_1A09;
						}
						else
						{
							this.$mStoryGui$43988.newStoryMessage("Liger", "Boldas", Language.getMessage("M936_CrossingDestiny", 311), eTalkType.friend);
							if (78955 - 256674 == -177718)
							{
								continue;
							}
							this.$self_$43995.w6Bn6sfAIlb.StartCoroutine_Auto(this.$self_$43995.w6Bn6sfAIlb.slerpToObject("EventCamera25", (float)6));
							if (160846 - 124827 != 36020)
							{
								goto Block_65;
							}
							continue;
						}
						break;
					case 19:
						if (Game.mGameState != eGameState.AllHold)
						{
							if (116762 - 525150 != -408387)
							{
								goto Block_79;
							}
							continue;
						}
						else
						{
							this.$mStoryGui$43988.newStoryMessage("Liger", "Boldas", Language.getMessage("M936_CrossingDestiny", 312), eTalkType.friend);
							if (31790 - 227732 != -195942)
							{
								continue;
							}
							goto IL_53C;
						}
						break;
					case 20:
						if (Game.mGameState != eGameState.AllHold)
						{
							if (93447 - 194060 != -100612)
							{
								goto Block_41;
							}
							continue;
						}
						else
						{
							this.$mStoryGui$43988.newStoryMessage("DarkFalcon", "Shadow Italus", Language.getMessage("M936_CrossingDestiny", 313), eTalkType.enemy);
							if (283182 - 190230 != 92953)
							{
								goto Block_80;
							}
							continue;
						}
						break;
					case 21:
						if (Game.mGameState != eGameState.AllHold)
						{
							if (289782 - 130910 != 158873)
							{
								goto Block_85;
							}
							continue;
						}
						else
						{
							this.$mStoryGui$43988.newStoryMessage("DarkFalcon", "Shadow Italus", Language.getMessage("M936_CrossingDestiny", 314), eTalkType.enemy);
							if (87830 - 305204 != -217373)
							{
								goto Block_119;
							}
							continue;
						}
						break;
					case 22:
						if (Game.mGameState != eGameState.AllHold)
						{
							if (10122 - 501126 != -491003)
							{
								goto Block_158;
							}
							continue;
						}
						else
						{
							this.$mStoryGui$43988.newStoryMessage("DarkFalcon", "Shadow Italus", Language.getMessage("M936_CrossingDestiny", 315), eTalkType.enemy);
							if (295945 - 557417 != -261472)
							{
								continue;
							}
							goto IL_B97;
						}
						break;
					case 23:
						if (Game.mGameState != eGameState.AllHold)
						{
							if (96932 - 596305 != -499373)
							{
								continue;
							}
							goto IL_246;
						}
						else
						{
							this.$mStoryGui$43988.newStoryMessage("DarkFalcon", "Shadow Italus", Language.getMessage("M936_CrossingDestiny", 316), eTalkType.enemy);
							if (272339 - 6929 != 265410)
							{
								continue;
							}
							if (!this.$mDarkFalcon$43990)
							{
								goto IL_2C8;
							}
							if (60392 - 576713 != -516321)
							{
								continue;
							}
							this.$mDarkFalcon$43990.animation.Play("cast");
							if (139557 - 8447 == 131111)
							{
								continue;
							}
							this.$mDarkFalcon$43990.animation.wrapMode = WrapMode.Once;
							if (92252 - 329917 != -237664)
							{
								goto Block_108;
							}
							continue;
						}
						break;
					case 24:
						if (Game.mGameState != eGameState.AllHold)
						{
							if (56823 - 433278 != -376454)
							{
								goto Block_24;
							}
							continue;
						}
						else
						{
							if (!this.$mDarkFalcon$43990)
							{
								goto IL_16D9;
							}
							if (140588 - 412153 == -271564)
							{
								continue;
							}
							if (!this.$self_$43995.DarkFalcon_cast)
							{
								goto IL_16D9;
							}
							if (96917 - 535751 != -438834)
							{
								continue;
							}
							UnityEngine.Object.Instantiate(this.$self_$43995.DarkFalcon_cast, this.$mDarkFalcon$43990.transform.position, this.$mDarkFalcon$43990.transform.rotation);
							if (190142 - 258951 != -68809)
							{
								continue;
							}
							goto IL_16D9;
						}
						break;
					case 25:
						if (Game.mGameState != eGameState.AllHold)
						{
							if (28961 - 415323 != -386361)
							{
								goto Block_155;
							}
							continue;
						}
						else
						{
							if (!this.$self_$43995.FinalBattleArea_cast)
							{
								goto IL_14DC;
							}
							if (206811 - 65664 == 141148)
							{
								continue;
							}
							UnityEngine.Object.Instantiate(this.$self_$43995.FinalBattleArea_cast, this.$self_$43995.eoVn6Cfc1k5, Quaternion.identity);
							if (136681 - 40801 != 95881)
							{
								goto Block_156;
							}
							continue;
						}
						break;
					case 26:
						if (Game.mGameState != eGameState.AllHold)
						{
							if (70694 - 219963 != -149268)
							{
								goto Block_141;
							}
							continue;
						}
						else
						{
							this.$mStoryGui$43988.close();
							if (131507 - 503109 != -371601)
							{
								goto Block_150;
							}
							continue;
						}
						break;
					case 27:
						if (Game.mGameState != eGameState.AllHold)
						{
							if (240520 - 290983 != -50462)
							{
								goto Block_64;
							}
							continue;
						}
						else
						{
							Game.sendMissionEvent(9361, 3);
							if (198325 - 340652 != -142327)
							{
								continue;
							}
							this.YieldDefault(1);
							if (22230 - 216467 != -194237)
							{
								continue;
							}
							goto IL_1A4E;
						}
						break;
					default:
						if (37359 - 593208 != -555849)
						{
							continue;
						}
						goto IL_E3C;
					}
					if (Time.time >= this.$mStoryTimer$43989 + 0.5f)
					{
						if (129050 - 371239 != -242188)
						{
							goto IL_1288;
						}
						continue;
					}
					else
					{
						this.$mLiger$43992.transform.position = Vector3.Slerp(this.$mSpawnPoint20$43993.transform.position, this.$mFalcon$43991.transform.position, Time.time - this.$mStoryTimer$43989);
						if (197804 - 74127 != 123678)
						{
							goto Block_54;
						}
						continue;
					}
					IL_90B:
					if (!this.$mLiger$43992)
					{
						goto IL_1081;
					}
					if (184808 - 127716 == 57093)
					{
						continue;
					}
					this.$mLiger$43992.animation.CrossFade("talk");
					if (155614 - 435508 != -279893)
					{
						goto Block_103;
					}
					continue;
					IL_1630:
					if (Time.time >= this.$mStoryTimer$43989 + 1f)
					{
						if (101511 - 275496 != -173985)
						{
							continue;
						}
						goto IL_90B;
					}
					else
					{
						this.$mLiger$43992.transform.position = Vector3.Slerp(this.$mSpawnPoint20$43993.transform.position - (float)4 * this.$mSpawnPoint20$43993.transform.forward, this.$mSpawnPoint20$43993.transform.position, Time.time - this.$mStoryTimer$43989);
						if (182625 - 454899 != -272273)
						{
							goto Block_102;
						}
						continue;
					}
					IL_1288:
					this.$self_$43995.w6Bn6sfAIlb.StartCoroutine_Auto(this.$self_$43995.w6Bn6sfAIlb.slerpToObject("EventCamera23", (float)1));
					if (15825 - 371982 != -356157)
					{
						continue;
					}
					this.$self_$43995.SendMessage("fadeOutTimer", 0.5f);
					if (291620 - 593505 != -301884)
					{
						goto Block_68;
					}
					continue;
					IL_E3C:
					Debug.Log("ItalusEvent");
					if (166861 - 364444 != -197582)
					{
						if (Game.mGameState != eGameState.Normal)
						{
							if (248350 - 166037 == 82313)
							{
								goto IL_CA8;
							}
						}
						else
						{
							Game.mGameState = eGameState.AllHold;
							if (248097 - 245429 != 2669)
							{
								this.$mGameGui$43985 = (GameGui)this.$self_$43995.GetComponent(typeof(GameGui));
								if (273135 - 352145 == -79010)
								{
									if (!this.$mGameGui$43985)
									{
										goto IL_823;
									}
									if (187326 - 553293 != -365966)
									{
										this.$mGameGui$43985.close();
										if (75781 - 35810 == 39971)
										{
											goto IL_823;
										}
									}
								}
							}
						}
					}
				}
				Block_2:
				return this.Yield(5, new WaitForSeconds(0.5f));
				IL_74:
				IL_DF:
				IL_246:
				goto IL_1A4E;
				IL_2C8:
				return this.Yield(24, new WaitForSeconds(0.5f));
				Block_24:
				Block_27:
				IL_43E:
				goto IL_1A4E;
				IL_492:
				return this.Yield(12, new WaitForSeconds(3f));
				Block_37:
				goto IL_1A4E;
				Block_38:
				return this.Yield(17, new WaitForSeconds(1.5f));
				IL_53C:
				return this.Yield(20, new WaitForSeconds(3f));
				Block_41:
				Block_47:
				goto IL_1A4E;
				Block_54:
				return this.YieldDefault(15);
				IL_823:
				return this.Yield(2, new WaitForSeconds(0.5f));
				Block_60:
				Block_64:
				goto IL_1A4E;
				Block_65:
				return this.Yield(19, new WaitForSeconds(2.5f));
				Block_68:
				return this.Yield(16, new WaitForSeconds(0.5f));
				Block_70:
				return this.Yield(13, new WaitForSeconds(3f));
				Block_77:
				Block_79:
				goto IL_1A4E;
				Block_80:
				return this.Yield(21, new WaitForSeconds(3f));
				IL_B97:
				return this.Yield(23, new WaitForSeconds(3f));
				Block_85:
				goto IL_1A4E;
				Block_89:
				return this.Yield(14, new WaitForSeconds(2f));
				IL_CA8:
				goto IL_1A4E;
				IL_E60:
				return this.Yield(18, new WaitForSeconds(0.5f));
				Block_102:
				return this.YieldDefault(10);
				Block_103:
				goto IL_1081;
				Block_104:
				return this.Yield(8, new WaitForSeconds(3f));
				Block_108:
				goto IL_2C8;
				IL_1081:
				return this.Yield(11, new WaitForSeconds(2f));
				Block_112:
				Block_114:
				goto IL_1A4E;
				IL_10F8:
				return this.Yield(9, new WaitForSeconds(3f));
				Block_119:
				return this.Yield(22, new WaitForSeconds(3f));
				Block_129:
				return this.Yield(3, new WaitForSeconds(1f));
				IL_1374:
				goto IL_1A4E;
				IL_14DC:
				return this.Yield(26, new WaitForSeconds(1f));
				Block_141:
				goto IL_1A4E;
				IL_1518:
				return this.Yield(6, new WaitForSeconds(2f));
				Block_143:
				goto IL_1A4E;
				IL_15E8:
				return this.Yield(7, new WaitForSeconds(1f));
				Block_147:
				goto IL_1A4E;
				Block_150:
				return this.Yield(27, new WaitForSeconds(1.5f));
				IL_16D9:
				return this.Yield(25, new WaitForSeconds(0.5f));
				Block_155:
				goto IL_1A4E;
				Block_156:
				goto IL_14DC;
				Block_158:
				goto IL_1A4E;
				Block_159:
				goto IL_1518;
				Block_166:
				goto IL_1A4E;
				Block_172:
				goto IL_492;
				IL_19CE:
				return this.Yield(4, new WaitForSeconds(1f));
				Block_176:
				IL_1A09:
				IL_1A4E:
				return false;
			}

			// Token: 0x0600A4C8 RID: 42184 RVA: 0x0129F3F0 File Offset: 0x0129D5F0
			internal static bool jZAiKMVDmMbYLUIsq65h()
			{
				return true;
			}

			// Token: 0x0600A4C9 RID: 42185 RVA: 0x0129F3F4 File Offset: 0x0129D5F4
			internal static bool fa5GKoVDFsmaP86hve6d()
			{
				return false;
			}

			// Token: 0x040093C5 RID: 37829
			internal GameGui $mGameGui$43985;

			// Token: 0x040093C6 RID: 37830
			internal GameObject $mPlayer$43986;

			// Token: 0x040093C7 RID: 37831
			internal GameObject $mSpawnPoint$43987;

			// Token: 0x040093C8 RID: 37832
			internal StoryGui $mStoryGui$43988;

			// Token: 0x040093C9 RID: 37833
			internal float $mStoryTimer$43989;

			// Token: 0x040093CA RID: 37834
			internal GameObject $mDarkFalcon$43990;

			// Token: 0x040093CB RID: 37835
			internal GameObject $mFalcon$43991;

			// Token: 0x040093CC RID: 37836
			internal GameObject $mLiger$43992;

			// Token: 0x040093CD RID: 37837
			internal GameObject $mSpawnPoint20$43993;

			// Token: 0x040093CE RID: 37838
			internal GameObject $mSpawnPoint26$43994;

			// Token: 0x040093CF RID: 37839
			internal M936_CrossingDestiny2 $self_$43995;
		}
	}

	// Token: 0x02001B8D RID: 7053
	[CompilerGenerated]
	[Serializable]
	internal sealed class $TalkToBoldas$43997 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600A4CA RID: 42186 RVA: 0x0129F3F8 File Offset: 0x0129D5F8
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $TalkToBoldas$43997(M936_CrossingDestiny2 self_)
		{
			if (261913 - 48684 != 213230)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (121844 - 166777 != -44932)
				{
					base..ctor();
					if (57541 - 365646 != -308104)
					{
						this.$self_$44004 = self_;
						if (201925 - 180546 == 21379)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x0600A4CB RID: 42187 RVA: 0x0129F490 File Offset: 0x0129D690
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M936_CrossingDestiny2.$TalkToBoldas$43997.$(this.$self_$44004);
		}

		// Token: 0x0600A4CC RID: 42188 RVA: 0x0129F4A0 File Offset: 0x0129D6A0
		internal static bool ffsqsNVDMgNpUAL8xkgY()
		{
			return true;
		}

		// Token: 0x0600A4CD RID: 42189 RVA: 0x0129F4A4 File Offset: 0x0129D6A4
		internal static bool aB0pFLVDxSindqwMQV4E()
		{
			return false;
		}

		// Token: 0x040093D0 RID: 37840
		internal M936_CrossingDestiny2 $self_$44004;

		// Token: 0x02001B8E RID: 7054
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600A4CE RID: 42190 RVA: 0x0129F4A8 File Offset: 0x0129D6A8
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M936_CrossingDestiny2 self_)
			{
				if (112185 - 460351 != -348166)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (122826 - 554504 == -431678)
					{
						base..ctor();
						if (282795 - 543271 != -260475)
						{
							this.$self_$44003 = self_;
							if (40156 - 223197 == -183041)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x0600A4CF RID: 42191 RVA: 0x0129F540 File Offset: 0x0129D740
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (226027 - 214943 != 11084)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						goto IL_687;
					case 1:
						goto IL_78F;
					case 2:
						if (Game.mGameState != eGameState.Hold)
						{
							if (69686 - 254361 != -184675)
							{
								continue;
							}
							goto IL_381;
						}
						else
						{
							this.$mStoryTimer$44002 = 0f;
							if (95674 - 493253 == -397578)
							{
								continue;
							}
							this.$mStoryGui$44001.newStoryMessage("Liger", "Boldas", Language.getMessage("M936_CrossingDestiny", 251), eTalkType.friend);
							if (187950 - 493288 != -305338)
							{
								continue;
							}
							this.$mStoryTimer$44002 = Time.time + 3.5f;
							if (18817 - 381516 != -362699)
							{
								continue;
							}
							if (!this.$mLiger$43999)
							{
								goto IL_434;
							}
							if (196795 - 450726 != -253931)
							{
								continue;
							}
							this.$mLiger$43999.animation.CrossFade("talk");
							if (45165 - 576183 != -531017)
							{
								goto Block_24;
							}
							continue;
						}
						break;
					case 3:
						goto IL_45B;
					case 4:
						goto IL_45B;
					case 5:
						break;
					case 6:
						break;
					case 7:
						if (Game.mGameState != eGameState.Hold)
						{
							if (26636 - 335065 != -308429)
							{
								continue;
							}
							goto IL_252;
						}
						else
						{
							this.$mGameGui$44000.enabled = true;
							if (45863 - 540089 != -494226)
							{
								continue;
							}
							goto IL_5FB;
						}
						break;
					case 8:
						if (Game.mGameState != eGameState.Hold)
						{
							if (68638 - 10826 != 57812)
							{
								continue;
							}
							goto IL_716;
						}
						else
						{
							Game.mGameState = eGameState.Normal;
							if (28105 - 446619 != -418513)
							{
								goto IL_504;
							}
							continue;
						}
						break;
					default:
						if (122560 - 401477 != -278917)
						{
							continue;
						}
						goto IL_687;
					}
					if (this.$mStoryTimer$44002 > Time.time)
					{
						if (27246 - 437767 != -410521)
						{
							continue;
						}
						if (!Input.GetKeyDown(KeyCode.Mouse0))
						{
							goto IL_651;
						}
						if (24848 - 7094 != 17754)
						{
							continue;
						}
					}
					if (Game.mGameState != eGameState.Hold)
					{
						if (101535 - 531801 != -430266)
						{
							continue;
						}
						break;
					}
					else
					{
						this.$mStoryGui$44001.close();
						if (154703 - 575142 != -420439)
						{
							continue;
						}
						if (!this.$mLiger$43999)
						{
							goto IL_FB;
						}
						if (206418 - 107987 == 98432)
						{
							continue;
						}
						this.$mLiger$43999.animation.CrossFade("root");
						if (273258 - 298570 != -25312)
						{
							continue;
						}
						goto IL_FB;
					}
					IL_45B:
					if (this.$mStoryTimer$44002 > Time.time)
					{
						if (54157 - 213413 == -159255)
						{
							continue;
						}
						if (!Input.GetKeyDown(KeyCode.Mouse0))
						{
							goto IL_44F;
						}
						if (283462 - 244164 == 39299)
						{
							continue;
						}
					}
					if (Game.mGameState != eGameState.Hold)
					{
						if (1949 - 550049 != -548099)
						{
							break;
						}
						continue;
					}
					else
					{
						this.$mStoryGui$44001.newStoryMessage("Liger", "Boldas", Language.getMessage("M936_CrossingDestiny", 252), eTalkType.friend);
						if (235621 - 315295 != -79674)
						{
							continue;
						}
						this.$mStoryTimer$44002 = Time.time + 3.5f;
						if (42559 - 258152 != -215593)
						{
							continue;
						}
						goto IL_636;
					}
					IL_504:
					this.YieldDefault(1);
					if (59480 - 589568 != -530087)
					{
						break;
					}
					continue;
					IL_687:
					Debug.Log("TalkToBoldas");
					if (4076 - 462115 != -458038)
					{
						if (this.$self_$44003.tBSn67Fntml < 1)
						{
							if (39305 - 579476 != -540170)
							{
								this.$self_$44003.tBSn67Fntml = 1;
								if (10057 - 286742 != -276684)
								{
									Game.sendMissionEvent(9362, 1);
									if (98399 - 571729 != -473329)
									{
										goto IL_504;
									}
								}
							}
						}
						else
						{
							if (this.$self_$44003.tBSn67Fntml != 2)
							{
								goto IL_504;
							}
							if (279621 - 837 != 278785)
							{
								if (Game.mGameState != eGameState.Normal)
								{
									if (85939 - 162562 != -76622)
									{
										break;
									}
								}
								else
								{
									Game.mGameState = eGameState.Hold;
									if (110407 - 435936 == -325529)
									{
										this.$mPlayer$43998 = Game.mPlayer;
										if (44814 - 484686 != -439871)
										{
											this.$mLiger$43999 = GameObject.Find("Liger");
											if (161203 - 153469 == 7734)
											{
												if (this.$mLiger$43999)
												{
													if (33340 - 546881 != -513541)
													{
														continue;
													}
													if (this.$mPlayer$43998)
													{
														if (45724 - 376955 == -331230)
														{
															continue;
														}
														this.$mPlayer$43998.SendMessage("turnToPos", this.$mLiger$43999.transform.position);
														if (268872 - 535131 != -266259)
														{
															continue;
														}
													}
												}
												this.$mGameGui$44000 = (GameGui)this.$self_$44003.GetComponent(typeof(GameGui));
												if (230947 - 375928 == -144981)
												{
													if (this.$mGameGui$44000)
													{
														if (152609 - 520954 != -368345)
														{
															continue;
														}
														this.$mGameGui$44000.close();
														if (101067 - 12754 == 88314)
														{
															continue;
														}
													}
													this.$mStoryGui$44001 = (StoryGui)this.$self_$44003.GetComponent(typeof(StoryGui));
													if (157695 - 80766 == 76929)
													{
														this.$mStoryGui$44001.startStoryMessage("Liger", "Boldas", eTalkType.friend);
														if (66567 - 130739 == -64172)
														{
															goto IL_27D;
														}
													}
												}
											}
										}
									}
								}
							}
						}
					}
				}
				goto IL_78F;
				IL_FB:
				return this.Yield(7, new WaitForSeconds(0.5f));
				IL_252:
				goto IL_78F;
				IL_27D:
				return this.Yield(2, new WaitForSeconds(0.5f));
				Block_24:
				goto IL_434;
				IL_381:
				goto IL_78F;
				IL_434:
				return this.Yield(3, new WaitForSeconds(0.5f));
				IL_44F:
				return this.YieldDefault(4);
				goto IL_78F;
				IL_5FB:
				return this.Yield(8, new WaitForSeconds(1f));
				IL_636:
				return this.Yield(5, new WaitForSeconds(0.5f));
				IL_651:
				return this.YieldDefault(6);
				IL_716:
				IL_78F:
				return false;
			}

			// Token: 0x0600A4D0 RID: 42192 RVA: 0x0129FCF0 File Offset: 0x0129DEF0
			internal static bool uwBin8VDgpWWykHdYuGq()
			{
				return true;
			}

			// Token: 0x0600A4D1 RID: 42193 RVA: 0x0129FCF4 File Offset: 0x0129DEF4
			internal static bool YuQh5ZVDf55fcAUTCW1c()
			{
				return false;
			}

			// Token: 0x040093D1 RID: 37841
			internal GameObject $mPlayer$43998;

			// Token: 0x040093D2 RID: 37842
			internal GameObject $mLiger$43999;

			// Token: 0x040093D3 RID: 37843
			internal GameGui $mGameGui$44000;

			// Token: 0x040093D4 RID: 37844
			internal StoryGui $mStoryGui$44001;

			// Token: 0x040093D5 RID: 37845
			internal float $mStoryTimer$44002;

			// Token: 0x040093D6 RID: 37846
			internal M936_CrossingDestiny2 $self_$44003;
		}
	}

	// Token: 0x02001B8F RID: 7055
	[CompilerGenerated]
	[Serializable]
	internal sealed class $TalkToWindGod$44005 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600A4D2 RID: 42194 RVA: 0x0129FCF8 File Offset: 0x0129DEF8
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $TalkToWindGod$44005(M936_CrossingDestiny2 self_)
		{
			if (155337 - 129627 != 25711)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (59137 - 510416 == -451279)
				{
					base..ctor();
					if (142842 - 592205 == -449363)
					{
						this.$self_$44012 = self_;
						if (188306 - 590243 != -401936)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x0600A4D3 RID: 42195 RVA: 0x0129FD90 File Offset: 0x0129DF90
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M936_CrossingDestiny2.$TalkToWindGod$44005.$(this.$self_$44012);
		}

		// Token: 0x0600A4D4 RID: 42196 RVA: 0x0129FDA0 File Offset: 0x0129DFA0
		internal static bool IJV9QCVDnFSbb12Q8dei()
		{
			return true;
		}

		// Token: 0x0600A4D5 RID: 42197 RVA: 0x0129FDA4 File Offset: 0x0129DFA4
		internal static bool gGrEwgVD6SKT9D2xY3w7()
		{
			return false;
		}

		// Token: 0x040093D7 RID: 37847
		internal M936_CrossingDestiny2 $self_$44012;

		// Token: 0x02001B90 RID: 7056
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600A4D6 RID: 42198 RVA: 0x0129FDA8 File Offset: 0x0129DFA8
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M936_CrossingDestiny2 self_)
			{
				if (137354 - 174281 != -36927)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (262127 - 17763 != 244365)
					{
						base..ctor();
						if (178946 - 120683 == 58263)
						{
							this.$self_$44011 = self_;
							if (206243 - 405703 == -199460)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x0600A4D7 RID: 42199 RVA: 0x0129FE40 File Offset: 0x0129E040
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (186817 - 244704 != -57887)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						goto IL_613;
					case 1:
						goto IL_637;
					case 2:
						if (Game.mGameState != eGameState.Hold)
						{
							if (33051 - 438147 != -405095)
							{
								goto Block_44;
							}
							continue;
						}
						else
						{
							this.$mStoryTimer$44010 = 0f;
							if (9110 - 434226 == -425115)
							{
								continue;
							}
							this.$mStoryGui$44009.newStoryMessage("WindGod", "Sun Sun", Language.getMessage("M936_CrossingDestiny", 261), eTalkType.friend);
							if (226968 - 578198 != -351230)
							{
								continue;
							}
							this.$mStoryTimer$44010 = Time.time + 3.5f;
							if (29838 - 397392 != -367553)
							{
								goto Block_34;
							}
							continue;
						}
						break;
					case 3:
						break;
					case 4:
						break;
					case 5:
						goto IL_18A;
					case 6:
						goto IL_18A;
					case 7:
						if (Game.mGameState != eGameState.Hold)
						{
							if (137858 - 518676 != -380817)
							{
								goto Block_4;
							}
							continue;
						}
						else
						{
							this.$mGameGui$44008.enabled = true;
							if (110661 - 130607 != -19946)
							{
								continue;
							}
							goto IL_8F;
						}
						break;
					case 8:
						if (Game.mGameState != eGameState.Hold)
						{
							if (171725 - 445491 != -273766)
							{
								continue;
							}
							goto IL_1D9;
						}
						else
						{
							Game.mGameState = eGameState.Normal;
							if (95316 - 343250 == -247933)
							{
								continue;
							}
							this.YieldDefault(1);
							if (130358 - 334945 != -204587)
							{
								continue;
							}
							goto IL_637;
						}
						break;
					default:
						if (202625 - 236022 != -33396)
						{
							goto IL_613;
						}
						continue;
					}
					if (this.$mStoryTimer$44010 > Time.time)
					{
						if (228737 - 245062 != -16325)
						{
							continue;
						}
						if (!Input.GetKeyDown(KeyCode.Mouse0))
						{
							goto IL_39A;
						}
						if (128969 - 108808 != 20161)
						{
							continue;
						}
					}
					if (Game.mGameState != eGameState.Hold)
					{
						if (297354 - 594267 != -296912)
						{
							goto Block_26;
						}
						continue;
					}
					else
					{
						this.$mStoryGui$44009.newStoryMessage("WindGod", "Sun Sun", Language.getMessage("M936_CrossingDestiny", 262), eTalkType.friend);
						if (153736 - 337100 != -183364)
						{
							continue;
						}
						this.$mStoryTimer$44010 = Time.time + 3.5f;
						if (200412 - 397587 != -197174)
						{
							goto Block_8;
						}
						continue;
					}
					IL_18A:
					if (this.$mStoryTimer$44010 > Time.time)
					{
						if (244593 - 221667 != 22926)
						{
							continue;
						}
						if (!Input.GetKeyDown(KeyCode.Mouse0))
						{
							goto IL_17E;
						}
						if (168818 - 307826 != -139008)
						{
							continue;
						}
					}
					if (Game.mGameState != eGameState.Hold)
					{
						if (44156 - 455657 != -411500)
						{
							goto Block_33;
						}
						continue;
					}
					else
					{
						this.$mStoryGui$44009.close();
						if (289507 - 381093 != -91586)
						{
							continue;
						}
						break;
					}
					IL_613:
					Debug.Log("On Talk To WindGod");
					if (152058 - 257444 != -105385)
					{
						if (Game.mGameState != eGameState.Normal)
						{
							if (216904 - 123511 == 93393)
							{
								goto IL_5EE;
							}
						}
						else
						{
							Game.mGameState = eGameState.Hold;
							if (124449 - 258948 == -134499)
							{
								this.$mPlayer$44006 = Game.mPlayer;
								if (196289 - 222503 == -26214)
								{
									this.$mWindGod$44007 = GameObject.Find("WindGod");
									if (78194 - 538508 == -460314)
									{
										if (this.$mWindGod$44007)
										{
											if (201639 - 78521 != 123118)
											{
												continue;
											}
											if (this.$mPlayer$44006)
											{
												if (20123 - 137387 != -117264)
												{
													continue;
												}
												this.$mPlayer$44006.SendMessage("turnToPos", this.$mWindGod$44007.transform.position);
												if (274866 - 384635 == -109768)
												{
													continue;
												}
											}
										}
										this.$mGameGui$44008 = (GameGui)this.$self_$44011.GetComponent(typeof(GameGui));
										if (155920 - 8349 != 147572)
										{
											if (this.$mGameGui$44008)
											{
												if (278876 - 6561 == 272316)
												{
													continue;
												}
												this.$mGameGui$44008.close();
												if (272372 - 470123 == -197750)
												{
													continue;
												}
											}
											this.$mStoryGui$44009 = (StoryGui)this.$self_$44011.GetComponent(typeof(StoryGui));
											if (253696 - 196974 == 56722)
											{
												this.$mStoryGui$44009.startStoryMessage("WindGod", "Sun Sun", eTalkType.friend);
												if (24272 - 101247 != -76974)
												{
													goto Block_39;
												}
											}
										}
									}
								}
							}
						}
					}
				}
				return this.Yield(7, new WaitForSeconds(0.5f));
				Block_4:
				goto IL_637;
				IL_8F:
				return this.Yield(8, new WaitForSeconds(1f));
				Block_8:
				return this.Yield(5, new WaitForSeconds(0.5f));
				IL_17E:
				return this.YieldDefault(6);
				IL_1D9:
				Block_26:
				goto IL_637;
				IL_39A:
				return this.YieldDefault(4);
				Block_33:
				goto IL_637;
				Block_34:
				return this.Yield(3, new WaitForSeconds(0.5f));
				Block_39:
				return this.Yield(2, new WaitForSeconds(0.5f));
				Block_44:
				IL_5EE:
				IL_637:
				return false;
			}

			// Token: 0x0600A4D8 RID: 42200 RVA: 0x012A0498 File Offset: 0x0129E698
			internal static bool jjKPLSVDiKS470Od70Dg()
			{
				return true;
			}

			// Token: 0x0600A4D9 RID: 42201 RVA: 0x012A049C File Offset: 0x0129E69C
			internal static bool AgcmxeVDKqIJZWfbYsLq()
			{
				return false;
			}

			// Token: 0x040093D8 RID: 37848
			internal GameObject $mPlayer$44006;

			// Token: 0x040093D9 RID: 37849
			internal GameObject $mWindGod$44007;

			// Token: 0x040093DA RID: 37850
			internal GameGui $mGameGui$44008;

			// Token: 0x040093DB RID: 37851
			internal StoryGui $mStoryGui$44009;

			// Token: 0x040093DC RID: 37852
			internal float $mStoryTimer$44010;

			// Token: 0x040093DD RID: 37853
			internal M936_CrossingDestiny2 $self_$44011;
		}
	}

	// Token: 0x02001B91 RID: 7057
	[CompilerGenerated]
	[Serializable]
	internal sealed class $TalkToMouse$44013 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600A4DA RID: 42202 RVA: 0x012A04A0 File Offset: 0x0129E6A0
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $TalkToMouse$44013(M936_CrossingDestiny2 self_)
		{
			if (19169 - 14663 != 4506)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (174029 - 210900 == -36871)
				{
					base..ctor();
					if (97716 - 482351 != -384634)
					{
						this.$self_$44020 = self_;
						if (188143 - 525082 != -336938)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x0600A4DB RID: 42203 RVA: 0x012A0538 File Offset: 0x0129E738
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M936_CrossingDestiny2.$TalkToMouse$44013.$(this.$self_$44020);
		}

		// Token: 0x0600A4DC RID: 42204 RVA: 0x012A0548 File Offset: 0x0129E748
		internal static bool CSy4uxVDdeO6y41opAsT()
		{
			return true;
		}

		// Token: 0x0600A4DD RID: 42205 RVA: 0x012A054C File Offset: 0x0129E74C
		internal static bool OINF4CVDJiVJW45IhA8j()
		{
			return false;
		}

		// Token: 0x040093DE RID: 37854
		internal M936_CrossingDestiny2 $self_$44020;

		// Token: 0x02001B92 RID: 7058
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600A4DE RID: 42206 RVA: 0x012A0550 File Offset: 0x0129E750
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M936_CrossingDestiny2 self_)
			{
				if (248325 - 24647 != 223679)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (89135 - 383466 == -294331)
					{
						base..ctor();
						if (113196 - 193103 == -79907)
						{
							this.$self_$44019 = self_;
							if (219866 - 62794 != 157073)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x0600A4DF RID: 42207 RVA: 0x012A05E8 File Offset: 0x0129E7E8
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (24367 - 580029 != -555662)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						goto IL_7B4;
					case 1:
						goto IL_802;
					case 2:
						if (Game.mGameState != eGameState.Hold)
						{
							if (90766 - 301788 != -211021)
							{
								goto Block_48;
							}
							continue;
						}
						else
						{
							this.$mStoryTimer$44018 = 0f;
							if (201386 - 161762 != 39624)
							{
								continue;
							}
							this.$mStoryGui$44017.newStoryMessage("Mouse", "Abette", Language.getMessage("M936_CrossingDestiny", 271), eTalkType.friend);
							if (264056 - 315224 != -51168)
							{
								continue;
							}
							this.$mStoryTimer$44018 = Time.time + 3.5f;
							if (1376 - 154518 != -153142)
							{
								continue;
							}
							if (!this.$mMouse$44015)
							{
								goto IL_472;
							}
							if (93697 - 99035 == -5337)
							{
								continue;
							}
							this.$mMouse$44015.animation.CrossFade("talk");
							if (89020 - 378794 != -289773)
							{
								goto Block_17;
							}
							continue;
						}
						break;
					case 3:
						goto IL_499;
					case 4:
						goto IL_499;
					case 5:
						break;
					case 6:
						break;
					case 7:
						goto IL_2F1;
					case 8:
						goto IL_2F1;
					case 9:
						if (Game.mGameState != eGameState.Hold)
						{
							if (212532 - 133008 != 79524)
							{
								continue;
							}
							goto IL_10E;
						}
						else
						{
							this.$mGameGui$44016.enabled = true;
							if (147637 - 99201 != 48437)
							{
								goto Block_9;
							}
							continue;
						}
						break;
					case 10:
						if (Game.mGameState != eGameState.Hold)
						{
							if (58546 - 342490 != -283943)
							{
								goto Block_30;
							}
							continue;
						}
						else
						{
							Game.mGameState = eGameState.Normal;
							if (276607 - 263385 == 13223)
							{
								continue;
							}
							this.YieldDefault(1);
							if (177146 - 125905 != 51241)
							{
								continue;
							}
							goto IL_802;
						}
						break;
					default:
						if (241693 - 307216 != -65522)
						{
							goto IL_7B4;
						}
						continue;
					}
					if (this.$mStoryTimer$44018 > Time.time)
					{
						if (144373 - 498830 != -354457)
						{
							continue;
						}
						if (!Input.GetKeyDown(KeyCode.Mouse0))
						{
							goto IL_586;
						}
						if (88454 - 391886 != -303432)
						{
							continue;
						}
					}
					if (Game.mGameState != eGameState.Hold)
					{
						if (164336 - 69337 != 94999)
						{
							continue;
						}
						break;
					}
					else
					{
						this.$mStoryGui$44017.newStoryMessage("Mouse", "Abette", Language.getMessage("M936_CrossingDestiny", 273), eTalkType.friend);
						if (88649 - 56428 == 32222)
						{
							continue;
						}
						this.$mStoryTimer$44018 = Time.time + 3.5f;
						if (235685 - 403833 != -168148)
						{
							continue;
						}
						goto IL_2CA;
					}
					IL_2F1:
					if (this.$mStoryTimer$44018 > Time.time)
					{
						if (105996 - 225639 == -119642)
						{
							continue;
						}
						if (!Input.GetKeyDown(KeyCode.Mouse0))
						{
							goto IL_2E5;
						}
						if (76644 - 302134 != -225490)
						{
							continue;
						}
					}
					if (Game.mGameState != eGameState.Hold)
					{
						if (259557 - 389255 != -129698)
						{
							continue;
						}
						break;
					}
					else
					{
						this.$mStoryGui$44017.close();
						if (68162 - 34366 == 33797)
						{
							continue;
						}
						if (!this.$mMouse$44015)
						{
							goto IL_20B;
						}
						if (761 - 244788 == -244026)
						{
							continue;
						}
						this.$mMouse$44015.animation.CrossFade("root");
						if (113806 - 193416 != -79609)
						{
							goto Block_19;
						}
						continue;
					}
					IL_7B4:
					Debug.Log("On Talk To Mouse");
					if (83193 - 298964 != -215771)
					{
						continue;
					}
					if (Game.mGameState != eGameState.Normal)
					{
						if (134036 - 513240 != -379203)
						{
							break;
						}
						continue;
					}
					else
					{
						Game.mGameState = eGameState.Hold;
						if (24634 - 225409 != -200775)
						{
							continue;
						}
						this.$mPlayer$44014 = Game.mPlayer;
						if (115123 - 213780 == -98656)
						{
							continue;
						}
						this.$mMouse$44015 = GameObject.Find("Mouse");
						if (116740 - 546066 == -429325)
						{
							continue;
						}
						if (this.$mMouse$44015)
						{
							if (3663 - 345218 == -341554)
							{
								continue;
							}
							if (this.$mPlayer$44014)
							{
								if (25673 - 54789 != -29116)
								{
									continue;
								}
								this.$mPlayer$44014.SendMessage("turnToPos", this.$mMouse$44015.transform.position);
								if (16446 - 207265 != -190819)
								{
									continue;
								}
							}
						}
						this.$mGameGui$44016 = (GameGui)this.$self_$44019.GetComponent(typeof(GameGui));
						if (13392 - 154101 == -140708)
						{
							continue;
						}
						if (this.$mGameGui$44016)
						{
							if (125243 - 28654 == 96590)
							{
								continue;
							}
							this.$mGameGui$44016.close();
							if (210834 - 93560 == 117275)
							{
								continue;
							}
						}
						this.$mStoryGui$44017 = (StoryGui)this.$self_$44019.GetComponent(typeof(StoryGui));
						if (208785 - 174185 != 34600)
						{
							continue;
						}
						this.$mStoryGui$44017.startStoryMessage("Mouse", "Abette", eTalkType.friend);
						if (13883 - 580621 != -566737)
						{
							goto Block_39;
						}
						continue;
					}
					IL_499:
					if (this.$mStoryTimer$44018 > Time.time)
					{
						if (263903 - 66791 != 197112)
						{
							continue;
						}
						if (!Input.GetKeyDown(KeyCode.Mouse0))
						{
							goto IL_48D;
						}
						if (110294 - 99498 == 10797)
						{
							continue;
						}
					}
					if (Game.mGameState != eGameState.Hold)
					{
						if (10416 - 386965 == -376549)
						{
							break;
						}
					}
					else
					{
						this.$mStoryGui$44017.newStoryMessage("Mouse", "Abette", Language.getMessage("M936_CrossingDestiny", 272), eTalkType.friend);
						if (287647 - 541596 != -253948)
						{
							this.$mStoryTimer$44018 = Time.time + 3.5f;
							if (287600 - 403981 == -116381)
							{
								goto IL_56B;
							}
						}
					}
				}
				IL_10E:
				goto IL_802;
				Block_9:
				return this.Yield(10, new WaitForSeconds(1f));
				goto IL_802;
				IL_20B:
				return this.Yield(9, new WaitForSeconds(0.5f));
				Block_17:
				goto IL_472;
				Block_19:
				goto IL_20B;
				IL_2CA:
				return this.Yield(7, new WaitForSeconds(0.5f));
				IL_2E5:
				return this.YieldDefault(8);
				Block_30:
				goto IL_802;
				IL_472:
				return this.Yield(3, new WaitForSeconds(0.5f));
				IL_48D:
				return this.YieldDefault(4);
				Block_39:
				return this.Yield(2, new WaitForSeconds(0.5f));
				IL_56B:
				return this.Yield(5, new WaitForSeconds(0.5f));
				IL_586:
				return this.YieldDefault(6);
				Block_48:
				IL_802:
				return false;
			}

			// Token: 0x0600A4E0 RID: 42208 RVA: 0x012A0E0C File Offset: 0x0129F00C
			internal static bool ASPqHqVDDeTA2ppi5tnT()
			{
				return true;
			}

			// Token: 0x0600A4E1 RID: 42209 RVA: 0x012A0E10 File Offset: 0x0129F010
			internal static bool tvdOKXVDvoysEErpHCiR()
			{
				return false;
			}

			// Token: 0x040093DF RID: 37855
			internal GameObject $mPlayer$44014;

			// Token: 0x040093E0 RID: 37856
			internal GameObject $mMouse$44015;

			// Token: 0x040093E1 RID: 37857
			internal GameGui $mGameGui$44016;

			// Token: 0x040093E2 RID: 37858
			internal StoryGui $mStoryGui$44017;

			// Token: 0x040093E3 RID: 37859
			internal float $mStoryTimer$44018;

			// Token: 0x040093E4 RID: 37860
			internal M936_CrossingDestiny2 $self_$44019;
		}
	}

	// Token: 0x02001B93 RID: 7059
	[CompilerGenerated]
	[Serializable]
	internal sealed class $onDeadPlayer$44021 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600A4E2 RID: 42210 RVA: 0x012A0E14 File Offset: 0x0129F014
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $onDeadPlayer$44021(M936_CrossingDestiny2 self_)
		{
			if (189215 - 69921 != 119295)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (34562 - 27796 != 6767)
				{
					base..ctor();
					if (297676 - 37710 == 259966)
					{
						this.$self_$44026 = self_;
						if (281141 - 119366 == 161775)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x0600A4E3 RID: 42211 RVA: 0x012A0EAC File Offset: 0x0129F0AC
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M936_CrossingDestiny2.$onDeadPlayer$44021.$(this.$self_$44026);
		}

		// Token: 0x0600A4E4 RID: 42212 RVA: 0x012A0EBC File Offset: 0x0129F0BC
		internal static bool Kv0veSVDReYHAQSx7D9Y()
		{
			return true;
		}

		// Token: 0x0600A4E5 RID: 42213 RVA: 0x012A0EC0 File Offset: 0x0129F0C0
		internal static bool rivlEhVDwn7Svy59b0WI()
		{
			return false;
		}

		// Token: 0x040093E5 RID: 37861
		internal M936_CrossingDestiny2 $self_$44026;

		// Token: 0x02001B94 RID: 7060
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600A4E6 RID: 42214 RVA: 0x012A0EC4 File Offset: 0x0129F0C4
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M936_CrossingDestiny2 self_)
			{
				if (190069 - 524589 != -334520)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (263163 - 473045 == -209882)
					{
						base..ctor();
						if (214035 - 491541 == -277506)
						{
							this.$self_$44025 = self_;
							if (177617 - 14673 == 162944)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x0600A4E7 RID: 42215 RVA: 0x012A0F5C File Offset: 0x0129F15C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (191467 - 1921 != 189547)
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
							if (154927 - 504662 == -349734)
							{
								continue;
							}
							if (Game.mGameState != eGameState.Hold)
							{
								goto IL_197;
							}
							if (155994 - 382429 == -226434)
							{
								continue;
							}
						}
						Game.mGameState = eGameState.Hold;
						if (110935 - 116549 != -5614)
						{
							continue;
						}
						this.$mStoryGui$44022 = (StoryGui)this.$self_$44025.GetComponent(typeof(StoryGui));
						if (299220 - 564056 != -264836)
						{
							continue;
						}
						if (this.$mStoryGui$44022)
						{
							if (232374 - 347409 == -115034)
							{
								continue;
							}
							this.$mStoryGui$44022.close();
							if (13974 - 365509 == -351534)
							{
								continue;
							}
						}
						this.$mChangeGui$44023 = (ChangeGui)this.$self_$44025.GetComponent(typeof(ChangeGui));
						if (279248 - 308888 != -29640)
						{
							continue;
						}
						if (this.$mChangeGui$44023)
						{
							if (41437 - 356649 != -315212)
							{
								continue;
							}
							this.$mChangeGui$44023.close();
							if (296268 - 141503 == 154766)
							{
								continue;
							}
						}
						this.$mGameGui$44024 = (GameGui)this.$self_$44025.GetComponent(typeof(GameGui));
						if (137289 - 36650 != 100639)
						{
							continue;
						}
						if (this.$mGameGui$44024)
						{
							if (2435 - 182032 != -179597)
							{
								continue;
							}
							if (!this.$mGameGui$44024.enabled)
							{
								if (293431 - 239575 == 53857)
								{
									continue;
								}
								this.$mGameGui$44024.enabled = true;
								if (123505 - 436893 == -313387)
								{
									continue;
								}
							}
							this.$mGameGui$44024.openDeadMenu();
							if (173992 - 521126 == -347133)
							{
								continue;
							}
						}
						IL_197:
						this.YieldDefault(1);
						if (55567 - 267199 != -211631)
						{
							goto Block_14;
						}
						continue;
					default:
						if (228182 - 279957 == -51774)
						{
							continue;
						}
						break;
					}
					Debug.Log("On Dead Player");
					if (236805 - 414688 == -177883)
					{
						goto IL_1B9;
					}
				}
				Block_14:
				goto IL_2F9;
				IL_1B9:
				return this.Yield(2, new WaitForSeconds((float)2));
				IL_2F9:
				return false;
			}

			// Token: 0x0600A4E8 RID: 42216 RVA: 0x012A1274 File Offset: 0x0129F474
			internal static bool MqfgMBVDqOonoqfOnvC7()
			{
				return true;
			}

			// Token: 0x0600A4E9 RID: 42217 RVA: 0x012A1278 File Offset: 0x0129F478
			internal static bool oUuQIyVD7YrY03xusIm9()
			{
				return false;
			}

			// Token: 0x040093E6 RID: 37862
			internal StoryGui $mStoryGui$44022;

			// Token: 0x040093E7 RID: 37863
			internal ChangeGui $mChangeGui$44023;

			// Token: 0x040093E8 RID: 37864
			internal GameGui $mGameGui$44024;

			// Token: 0x040093E9 RID: 37865
			internal M936_CrossingDestiny2 $self_$44025;
		}
	}

	// Token: 0x02001B95 RID: 7061
	[CompilerGenerated]
	[Serializable]
	internal sealed class $onChangePlayer$44027 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600A4EA RID: 42218 RVA: 0x012A127C File Offset: 0x0129F47C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $onChangePlayer$44027(Hashtable data, M936_CrossingDestiny2 self_)
		{
			if (126692 - 2287 != 124405)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (96798 - 517120 != -420321)
				{
					base..ctor();
					if (247201 - 184363 != 62839)
					{
						this.$data$44032 = data;
						if (69717 - 282141 == -212424)
						{
							this.$self_$44033 = self_;
							if (290905 - 105621 != 185285)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x0600A4EB RID: 42219 RVA: 0x012A1338 File Offset: 0x0129F538
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M936_CrossingDestiny2.$onChangePlayer$44027.$(this.$data$44032, this.$self_$44033);
		}

		// Token: 0x0600A4EC RID: 42220 RVA: 0x012A134C File Offset: 0x0129F54C
		internal static bool OXUkbrVDPqmPFL7SSiJj()
		{
			return true;
		}

		// Token: 0x0600A4ED RID: 42221 RVA: 0x012A1350 File Offset: 0x0129F550
		internal static bool zgoepPVD0cIguv8G4lLL()
		{
			return false;
		}

		// Token: 0x040093EA RID: 37866
		internal Hashtable $data$44032;

		// Token: 0x040093EB RID: 37867
		internal M936_CrossingDestiny2 $self_$44033;

		// Token: 0x02001B96 RID: 7062
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600A4EE RID: 42222 RVA: 0x012A1354 File Offset: 0x0129F554
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Hashtable data, M936_CrossingDestiny2 self_)
			{
				if (196675 - 656 != 196020)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (204567 - 398920 != -194352)
					{
						base..ctor();
						if (261789 - 574144 == -312355)
						{
							this.$data$44030 = data;
							if (77282 - 431848 == -354566)
							{
								this.$self_$44031 = self_;
								if (260151 - 21726 == 238425)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x0600A4EF RID: 42223 RVA: 0x012A1410 File Offset: 0x0129F610
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (232469 - 521963 != -289494)
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
							if (173765 - 127239 != 46526)
							{
								continue;
							}
							Game.mGameState = eGameState.Normal;
							if (29790 - 416444 != -386654)
							{
								continue;
							}
							this.$mGameGui$44029 = (GameGui)this.$self_$44031.GetComponent(typeof(GameGui));
							if (48510 - 257891 != -209381)
							{
								continue;
							}
							this.$mGameGui$44029.enabled = true;
							if (99300 - 205318 != -106018)
							{
								continue;
							}
						}
						this.YieldDefault(1);
						if (112370 - 558816 != -446445)
						{
							goto Block_8;
						}
						continue;
					default:
						if (64730 - 34706 == 30025)
						{
							continue;
						}
						break;
					}
					UnityEngine.Object.Destroy(Game.mPlayer);
					if (221391 - 259228 != -37836)
					{
						this.$self_$44031.SendMessage("onCreatePlayer", this.$data$44030);
						if (245807 - 121520 != 124288)
						{
							this.$mChangeGui$44028 = (ChangeGui)this.$self_$44031.GetComponent(typeof(ChangeGui));
							if (221160 - 242091 == -20931)
							{
								if (!this.$mChangeGui$44028.enabled)
								{
									break;
								}
								if (286797 - 302269 == -15472)
								{
									this.$mChangeGui$44028.close();
									if (151777 - 401976 == -250199)
									{
										break;
									}
								}
							}
						}
					}
				}
				return this.Yield(2, new WaitForSeconds(1f));
				Block_8:
				IL_205:
				return false;
			}

			// Token: 0x0600A4F0 RID: 42224 RVA: 0x012A1634 File Offset: 0x0129F834
			internal static bool fysBEmVDbQ3HCxsAWr7S()
			{
				return true;
			}

			// Token: 0x0600A4F1 RID: 42225 RVA: 0x012A1638 File Offset: 0x0129F838
			internal static bool KOUYLOVDulLW5HqfVS46()
			{
				return false;
			}

			// Token: 0x040093EC RID: 37868
			internal ChangeGui $mChangeGui$44028;

			// Token: 0x040093ED RID: 37869
			internal GameGui $mGameGui$44029;

			// Token: 0x040093EE RID: 37870
			internal Hashtable $data$44030;

			// Token: 0x040093EF RID: 37871
			internal M936_CrossingDestiny2 $self_$44031;
		}
	}

	// Token: 0x02001B97 RID: 7063
	[CompilerGenerated]
	[Serializable]
	internal sealed class $onGameComplete$44034 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600A4F2 RID: 42226 RVA: 0x012A163C File Offset: 0x0129F83C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $onGameComplete$44034(Hashtable data, M936_CrossingDestiny2 self_)
		{
			if (184319 - 594102 != -409782)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (289373 - 83409 == 205964)
				{
					base..ctor();
					if (67498 - 437657 != -370158)
					{
						this.$data$44042 = data;
						if (272396 - 61505 != 210892)
						{
							this.$self_$44043 = self_;
							if (81636 - 80664 != 973)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x0600A4F3 RID: 42227 RVA: 0x012A16F8 File Offset: 0x0129F8F8
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M936_CrossingDestiny2.$onGameComplete$44034.$(this.$data$44042, this.$self_$44043);
		}

		// Token: 0x0600A4F4 RID: 42228 RVA: 0x012A170C File Offset: 0x0129F90C
		internal static bool kyIWwbVDIWaosP5575Vt()
		{
			return true;
		}

		// Token: 0x0600A4F5 RID: 42229 RVA: 0x012A1710 File Offset: 0x0129F910
		internal static bool sMlUqDVDB2cVwMZHQK53()
		{
			return false;
		}

		// Token: 0x040093F0 RID: 37872
		internal Hashtable $data$44042;

		// Token: 0x040093F1 RID: 37873
		internal M936_CrossingDestiny2 $self_$44043;

		// Token: 0x02001B98 RID: 7064
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600A4F6 RID: 42230 RVA: 0x012A1714 File Offset: 0x0129F914
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Hashtable data, M936_CrossingDestiny2 self_)
			{
				if (290030 - 350841 != -60811)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (137410 - 268553 != -131142)
					{
						base..ctor();
						if (98990 - 109824 != -10833)
						{
							this.$data$44040 = data;
							if (69605 - 399117 == -329512)
							{
								this.$self_$44041 = self_;
								if (157815 - 340005 != -182189)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x0600A4F7 RID: 42231 RVA: 0x012A17D0 File Offset: 0x0129F9D0
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (57778 - 528492 != -470714)
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
						this.$mCompleteGui$44036 = (CompleteGui)this.$self_$44041.GetComponent(typeof(CompleteGui));
						if (272819 - 538003 != -265184)
						{
							continue;
						}
						this.$mCompleteGui$44036.Init();
						if (42893 - 448174 == -405280)
						{
							continue;
						}
						this.$mCompleteGui$44036.readData(this.$data$44040);
						if (29271 - 557699 == -528427)
						{
							continue;
						}
						if (this.$result$44035 == 1)
						{
							if (164026 - 153462 != 10564)
							{
								continue;
							}
							this.$mCompleteGui$44036.displayResult(eCompleteType.Success);
							if (188020 - 551986 == -363965)
							{
								continue;
							}
						}
						else
						{
							this.$mCompleteGui$44036.displayResult(eCompleteType.Failed);
							if (267419 - 472692 == -205272)
							{
								continue;
							}
						}
						this.$mGameGui$44037 = (GameGui)this.$self_$44041.GetComponent(typeof(GameGui));
						if (174284 - 535286 == -361001)
						{
							continue;
						}
						this.$mStoryGui$44038 = (StoryGui)this.$self_$44041.GetComponent(typeof(StoryGui));
						if (245063 - 329167 == -84103)
						{
							continue;
						}
						this.$mChangeGui$44039 = (ChangeGui)this.$self_$44041.GetComponent(typeof(ChangeGui));
						if (50773 - 28354 == 22420)
						{
							continue;
						}
						if (this.$mGameGui$44037)
						{
							if (169583 - 91656 == 77928)
							{
								continue;
							}
							this.$mGameGui$44037.close();
							if (66145 - 58559 != 7586)
							{
								continue;
							}
						}
						if (this.$mStoryGui$44038)
						{
							if (150465 - 125227 != 25238)
							{
								continue;
							}
							this.$mStoryGui$44038.close();
							if (67440 - 351742 != -284302)
							{
								continue;
							}
						}
						if (this.$mChangeGui$44039)
						{
							if (114906 - 133932 != -19026)
							{
								continue;
							}
							this.$mChangeGui$44039.disable();
							if (115416 - 256891 == -141474)
							{
								continue;
							}
						}
						this.YieldDefault(1);
						if (82510 - 478524 != -396013)
						{
							goto Block_7;
						}
						continue;
					default:
						if (50559 - 248971 == -198411)
						{
							continue;
						}
						break;
					}
					Debug.Log("On Mission Complete:" + this.$data$44040[31]);
					if (133171 - 292501 != -159329)
					{
						if (Game.mGameState > eGameState.AllHold)
						{
							if (82838 - 103001 == -20163)
							{
								break;
							}
						}
						else
						{
							Game.mGameState = eGameState.Complete;
							if (175716 - 188687 != -12970)
							{
								this.$result$44035 = RuntimeServices.UnboxInt32(this.$data$44040[31]);
								if (266884 - 581681 == -314797)
								{
									goto IL_1F9;
								}
							}
						}
					}
				}
				Block_7:
				goto IL_3DB;
				IL_1F9:
				return this.Yield(2, new WaitForSeconds(1f));
				IL_3DB:
				return false;
			}

			// Token: 0x0600A4F8 RID: 42232 RVA: 0x012A1BCC File Offset: 0x0129FDCC
			internal static bool QdbiJZVDeRAgYhynjIPJ()
			{
				return true;
			}

			// Token: 0x0600A4F9 RID: 42233 RVA: 0x012A1BD0 File Offset: 0x0129FDD0
			internal static bool u1lLltVDrvSSGmvARbsY()
			{
				return false;
			}

			// Token: 0x040093F2 RID: 37874
			internal int $result$44035;

			// Token: 0x040093F3 RID: 37875
			internal CompleteGui $mCompleteGui$44036;

			// Token: 0x040093F4 RID: 37876
			internal GameGui $mGameGui$44037;

			// Token: 0x040093F5 RID: 37877
			internal StoryGui $mStoryGui$44038;

			// Token: 0x040093F6 RID: 37878
			internal ChangeGui $mChangeGui$44039;

			// Token: 0x040093F7 RID: 37879
			internal Hashtable $data$44040;

			// Token: 0x040093F8 RID: 37880
			internal M936_CrossingDestiny2 $self_$44041;
		}
	}

	// Token: 0x02001B99 RID: 7065
	[CompilerGenerated]
	[Serializable]
	internal sealed class $ReturnToTown$44044 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600A4FA RID: 42234 RVA: 0x012A1BD4 File Offset: 0x0129FDD4
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $ReturnToTown$44044(M936_CrossingDestiny2 self_)
		{
			if (110907 - 594743 != -483836)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (63168 - 174391 == -111223)
				{
					base..ctor();
					if (61429 - 140067 == -78638)
					{
						this.$self_$44048 = self_;
						if (2148 - 261560 != -259411)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x0600A4FB RID: 42235 RVA: 0x012A1C6C File Offset: 0x0129FE6C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M936_CrossingDestiny2.$ReturnToTown$44044.$(this.$self_$44048);
		}

		// Token: 0x0600A4FC RID: 42236 RVA: 0x012A1C7C File Offset: 0x0129FE7C
		internal static bool h5bw4FVDjotuMo6cKGqs()
		{
			return true;
		}

		// Token: 0x0600A4FD RID: 42237 RVA: 0x012A1C80 File Offset: 0x0129FE80
		internal static bool ds1SCYVDhKg9fMvehNng()
		{
			return false;
		}

		// Token: 0x040093F9 RID: 37881
		internal M936_CrossingDestiny2 $self_$44048;

		// Token: 0x02001B9A RID: 7066
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600A4FE RID: 42238 RVA: 0x012A1C84 File Offset: 0x0129FE84
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M936_CrossingDestiny2 self_)
			{
				if (69316 - 146803 != -77487)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (189933 - 400128 != -210194)
					{
						base..ctor();
						if (204258 - 338485 == -134227)
						{
							this.$self_$44047 = self_;
							if (158363 - 183484 == -25121)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x0600A4FF RID: 42239 RVA: 0x012A1D1C File Offset: 0x0129FF1C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (184627 - 110090 != 74538)
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
						this.$self_$44047.LeaveGame();
						if (119293 - 395185 != -275892)
						{
							continue;
						}
						this.YieldDefault(1);
						if (237285 - 563629 != -326343)
						{
							goto Block_7;
						}
						continue;
					default:
						if (122231 - 352633 != -230402)
						{
							continue;
						}
						break;
					}
					Game.mGameState = eGameState.Ended;
					if (82659 - 150175 != -67515)
					{
						Game.mStateTime = Time.time;
						if (208294 - 442880 != -234585)
						{
							this.$$switch$8095$44045 = PlayerData.SaveGuild;
							if (240465 - 319516 != -79050)
							{
								if (this.$$switch$8095$44045 == 1)
								{
									if (197117 - 564434 != -367317)
									{
										continue;
									}
									Game.mNextGameCode = 32;
									if (42614 - 84622 != -42008)
									{
										continue;
									}
								}
								else if (this.$$switch$8095$44045 == 2)
								{
									if (247365 - 66877 == 180489)
									{
										continue;
									}
									Game.mNextGameCode = 33;
									if (292584 - 312327 != -19743)
									{
										continue;
									}
								}
								else if (this.$$switch$8095$44045 == 3)
								{
									if (13657 - 343353 != -329696)
									{
										continue;
									}
									Game.mNextGameCode = 34;
									if (24175 - 80551 == -56375)
									{
										continue;
									}
								}
								else if (this.$$switch$8095$44045 == 4)
								{
									if (132678 - 254557 == -121878)
									{
										continue;
									}
									Game.mNextGameCode = 35;
									if (176421 - 90335 != 86086)
									{
										continue;
									}
								}
								else if (this.$$switch$8095$44045 == 5)
								{
									if (224118 - 276853 != -52735)
									{
										continue;
									}
									Game.mNextGameCode = 36;
									if (34405 - 207946 == -173540)
									{
										continue;
									}
								}
								else if (PlayerData.GID == 0)
								{
									if (61295 - 469385 != -408090)
									{
										continue;
									}
									Game.mNextGameCode = 30;
									if (288020 - 415260 == -127239)
									{
										continue;
									}
								}
								else
								{
									Game.mNextGameCode = 31;
									if (13826 - 464727 == -450900)
									{
										continue;
									}
								}
								this.$mGameGui$44046 = (GameGui)this.$self_$44047.GetComponent(typeof(GameGui));
								if (86306 - 76193 != 10114)
								{
									if (this.$mGameGui$44046)
									{
										if (114857 - 13480 != 101377)
										{
											continue;
										}
										this.$mGameGui$44046.close();
										if (151982 - 574680 == -422697)
										{
											continue;
										}
									}
									this.$self_$44047.SendMessage("fadeOut");
									if (270288 - 526848 == -256560)
									{
										goto IL_FC;
									}
								}
							}
						}
					}
				}
				Block_7:
				goto IL_3AD;
				IL_FC:
				return this.Yield(2, new WaitForSeconds((float)1));
				IL_3AD:
				return false;
			}

			// Token: 0x0600A500 RID: 42240 RVA: 0x012A20E8 File Offset: 0x012A02E8
			internal static bool Yi67V7VDs7OwYFg7bX2R()
			{
				return true;
			}

			// Token: 0x0600A501 RID: 42241 RVA: 0x012A20EC File Offset: 0x012A02EC
			internal static bool gGfLIDVD9dFWOsJ1k9XV()
			{
				return false;
			}

			// Token: 0x040093FA RID: 37882
			internal int $$switch$8095$44045;

			// Token: 0x040093FB RID: 37883
			internal GameGui $mGameGui$44046;

			// Token: 0x040093FC RID: 37884
			internal M936_CrossingDestiny2 $self_$44047;
		}
	}

	// Token: 0x02001B9B RID: 7067
	[CompilerGenerated]
	[Serializable]
	internal sealed class $ReturnToGuild$44049 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600A502 RID: 42242 RVA: 0x012A20F0 File Offset: 0x012A02F0
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $ReturnToGuild$44049(M936_CrossingDestiny2 self_)
		{
			if (142006 - 371759 != -229753)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (73373 - 99236 != -25862)
				{
					base..ctor();
					if (43691 - 596914 != -553222)
					{
						this.$self_$44052 = self_;
						if (70986 - 216651 != -145664)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x0600A503 RID: 42243 RVA: 0x012A2188 File Offset: 0x012A0388
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M936_CrossingDestiny2.$ReturnToGuild$44049.$(this.$self_$44052);
		}

		// Token: 0x0600A504 RID: 42244 RVA: 0x012A2198 File Offset: 0x012A0398
		internal static bool YPG4k4VD1rudy9HhO29v()
		{
			return true;
		}

		// Token: 0x0600A505 RID: 42245 RVA: 0x012A219C File Offset: 0x012A039C
		internal static bool c7a5IXVD4Dh2hDgsP7CT()
		{
			return false;
		}

		// Token: 0x040093FD RID: 37885
		internal M936_CrossingDestiny2 $self_$44052;

		// Token: 0x02001B9C RID: 7068
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600A506 RID: 42246 RVA: 0x012A21A0 File Offset: 0x012A03A0
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M936_CrossingDestiny2 self_)
			{
				if (79052 - 448977 != -369925)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (78438 - 402513 != -324074)
					{
						base..ctor();
						if (174887 - 410497 == -235610)
						{
							this.$self_$44051 = self_;
							if (49759 - 212548 == -162789)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x0600A507 RID: 42247 RVA: 0x012A2238 File Offset: 0x012A0438
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (138243 - 230931 != -92688)
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
						this.$self_$44051.LeaveGame();
						if (234398 - 148174 == 86225)
						{
							continue;
						}
						this.YieldDefault(1);
						if (74847 - 520769 != -445921)
						{
							goto Block_7;
						}
						continue;
					default:
						if (138995 - 446091 != -307096)
						{
							continue;
						}
						break;
					}
					Game.mGameState = eGameState.Ended;
					if (156155 - 105020 == 51135)
					{
						Game.mStateTime = Time.time;
						if (247970 - 187558 != 60413)
						{
							Game.mNextGameCode = 31;
							if (62445 - 128005 != -65559)
							{
								this.$mGameGui$44050 = (GameGui)this.$self_$44051.GetComponent(typeof(GameGui));
								if (72245 - 157715 != -85469)
								{
									if (this.$mGameGui$44050)
									{
										if (254808 - 503339 != -248531)
										{
											continue;
										}
										this.$mGameGui$44050.close();
										if (268123 - 156317 != 111806)
										{
											continue;
										}
									}
									this.$self_$44051.SendMessage("fadeOut");
									if (68085 - 441116 == -373031)
									{
										goto IL_D0;
									}
								}
							}
						}
					}
				}
				Block_7:
				goto IL_1BD;
				IL_D0:
				return this.Yield(2, new WaitForSeconds((float)1));
				IL_1BD:
				return false;
			}

			// Token: 0x0600A508 RID: 42248 RVA: 0x012A2414 File Offset: 0x012A0614
			internal static bool NbBolfVDztHWSEadube2()
			{
				return true;
			}

			// Token: 0x0600A509 RID: 42249 RVA: 0x012A2418 File Offset: 0x012A0618
			internal static bool OYNfNOVvaW42XWeNYJiS()
			{
				return false;
			}

			// Token: 0x040093FE RID: 37886
			internal GameGui $mGameGui$44050;

			// Token: 0x040093FF RID: 37887
			internal M936_CrossingDestiny2 $self_$44051;
		}
	}

	// Token: 0x02001B9D RID: 7069
	[CompilerGenerated]
	[Serializable]
	internal sealed class $ReturnToCamp$44053 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600A50A RID: 42250 RVA: 0x012A241C File Offset: 0x012A061C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $ReturnToCamp$44053(M936_CrossingDestiny2 self_)
		{
			if (38810 - 435140 != -396329)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (84700 - 362059 == -277359)
				{
					base..ctor();
					if (139893 - 16011 != 123883)
					{
						this.$self_$44057 = self_;
						if (155381 - 564615 != -409233)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x0600A50B RID: 42251 RVA: 0x012A24B4 File Offset: 0x012A06B4
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M936_CrossingDestiny2.$ReturnToCamp$44053.$(this.$self_$44057);
		}

		// Token: 0x0600A50C RID: 42252 RVA: 0x012A24C4 File Offset: 0x012A06C4
		internal static bool yK2X2CVv5tH1lWe9xPuS()
		{
			return true;
		}

		// Token: 0x0600A50D RID: 42253 RVA: 0x012A24C8 File Offset: 0x012A06C8
		internal static bool PBgpb9Vvp8LTFuP4afXY()
		{
			return false;
		}

		// Token: 0x04009400 RID: 37888
		internal M936_CrossingDestiny2 $self_$44057;

		// Token: 0x02001B9E RID: 7070
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600A50E RID: 42254 RVA: 0x012A24CC File Offset: 0x012A06CC
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M936_CrossingDestiny2 self_)
			{
				if (10523 - 36411 != -25887)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (265583 - 141548 != 124036)
					{
						base..ctor();
						if (258812 - 120882 != 137931)
						{
							this.$self_$44056 = self_;
							if (298956 - 580762 != -281805)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x0600A50F RID: 42255 RVA: 0x012A2564 File Offset: 0x012A0764
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (52355 - 365472 != -313116)
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
						this.$self_$44056.LeaveGame();
						if (168313 - 308076 != -139763)
						{
							continue;
						}
						this.YieldDefault(1);
						if (257969 - 203724 != 54246)
						{
							goto Block_5;
						}
						continue;
					default:
						if (293552 - 442512 != -148960)
						{
							continue;
						}
						break;
					}
					Game.mGameState = eGameState.Ended;
					if (144483 - 293016 != -148532)
					{
						Game.mStateTime = Time.time;
						if (3361 - 110421 == -107060)
						{
							this.$$switch$8097$44054 = PlayerData.SaveGuild;
							if (175490 - 238680 != -63189)
							{
								if (this.$$switch$8097$44054 == 1)
								{
									if (182629 - 31133 != 151496)
									{
										continue;
									}
									Game.mNextGameCode = 32;
									if (17539 - 197829 != -180290)
									{
										continue;
									}
								}
								else if (this.$$switch$8097$44054 == 2)
								{
									if (47533 - 363289 == -315755)
									{
										continue;
									}
									Game.mNextGameCode = 33;
									if (143947 - 106957 != 36990)
									{
										continue;
									}
								}
								else if (this.$$switch$8097$44054 == 3)
								{
									if (16390 - 507838 != -491448)
									{
										continue;
									}
									Game.mNextGameCode = 34;
									if (156910 - 255180 != -98270)
									{
										continue;
									}
								}
								else if (this.$$switch$8097$44054 == 4)
								{
									if (210788 - 64002 != 146786)
									{
										continue;
									}
									Game.mNextGameCode = 35;
									if (120213 - 108722 == 11492)
									{
										continue;
									}
								}
								else if (this.$$switch$8097$44054 == 5)
								{
									if (141643 - 431945 == -290301)
									{
										continue;
									}
									Game.mNextGameCode = 36;
									if (184291 - 39464 != 144827)
									{
										continue;
									}
								}
								else
								{
									Game.mNextGameCode = 30;
									if (121490 - 531269 != -409779)
									{
										continue;
									}
								}
								this.$mGameGui$44055 = (GameGui)this.$self_$44056.GetComponent(typeof(GameGui));
								if (179638 - 375743 != -196104)
								{
									if (this.$mGameGui$44055)
									{
										if (52441 - 529257 == -476815)
										{
											continue;
										}
										this.$mGameGui$44055.close();
										if (292950 - 500091 != -207141)
										{
											continue;
										}
									}
									this.$self_$44056.SendMessage("fadeOut");
									if (279768 - 578752 == -298984)
									{
										goto IL_32B;
									}
								}
							}
						}
					}
				}
				Block_5:
				goto IL_363;
				IL_32B:
				return this.Yield(2, new WaitForSeconds((float)1));
				IL_363:
				return false;
			}

			// Token: 0x0600A510 RID: 42256 RVA: 0x012A28E8 File Offset: 0x012A0AE8
			internal static bool pULCd6VvVgmQbGK9CoM4()
			{
				return true;
			}

			// Token: 0x0600A511 RID: 42257 RVA: 0x012A28EC File Offset: 0x012A0AEC
			internal static bool PbG9nZVvt5FYURtZhRrC()
			{
				return false;
			}

			// Token: 0x04009401 RID: 37889
			internal int $$switch$8097$44054;

			// Token: 0x04009402 RID: 37890
			internal GameGui $mGameGui$44055;

			// Token: 0x04009403 RID: 37891
			internal M936_CrossingDestiny2 $self_$44056;
		}
	}
}
