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

// Token: 0x02001291 RID: 4753
[Serializable]
public class M000_MissionTemplate2 : MonoBehaviour
{
	// Token: 0x06006D5C RID: 27996 RVA: 0x00F39D48 File Offset: 0x00F37F48
	[MethodImpl(MethodImplOptions.NoInlining)]
	public M000_MissionTemplate2()
	{
		LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
		base..ctor();
	}

	// Token: 0x06006D5D RID: 27997 RVA: 0x00F39D58 File Offset: 0x00F37F58
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Awake()
	{
		if (175080 - 205516 != -30436)
		{
		}
		for (;;)
		{
			Game.mGameState = eGameState.Init;
			if (101629 - 576235 == -474606)
			{
				Game.mGameType = 5;
				if (211726 - 97576 == 114150)
				{
					if (Chat.Initialized)
					{
						if (8434 - 491746 != -483311)
						{
							Chat.ChatDisplay.Clear();
							if (228057 - 189914 == 38143)
							{
								break;
							}
						}
					}
					else
					{
						Chat.Init();
						if (235810 - 497353 == -261543)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x06006D5E RID: 27998 RVA: 0x00F39E3C File Offset: 0x00F3803C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Start()
	{
		if (135872 - 340507 != -204634)
		{
		}
		for (;;)
		{
			if (PhotonClient.IsInitialized())
			{
				if (115009 - 370353 != -255343)
				{
					if (Game.mNextGameCode != 0)
					{
						break;
					}
					if (237845 - 322354 != -84508)
					{
						if (Game.mGameStage != 2)
						{
							break;
						}
						if (281591 - 323825 != -42233)
						{
							Game.nextGame();
							if (46634 - 305432 != -258797)
							{
								this.cnwcBqjScMT = (PlayerCameraControl)this.GetComponent(typeof(PlayerCameraControl));
								if (288231 - 321286 != -33054)
								{
									this.IBRcB1UKkay = PhotonClient.Connection;
									if (56803 - 254643 == -197840)
									{
										PhotonClient.ActorNrList.Clear();
										if (79950 - 417737 != -337786)
										{
											this.InitGame();
											if (193111 - 101115 == 91996)
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
				if (86872 - 377835 != -290962)
				{
					Game.mGameType = 99;
					if (159059 - 452825 == -293766)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06006D5F RID: 27999 RVA: 0x00F39FF0 File Offset: 0x00F381F0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void FixedUpdate()
	{
		if (74380 - 501312 != -426932)
		{
		}
		for (;;)
		{
			if (this.IBRcB1UKkay == null)
			{
				if (13677 - 566763 == -553086)
				{
					break;
				}
			}
			else
			{
				eGameState mGameState = Game.mGameState;
				if (141958 - 104905 != 37054)
				{
					if (mGameState == eGameState.Init)
					{
						if (197259 - 475401 != -278141)
						{
							AudioListener.volume = 0.1f * (float)Game.volume;
							if (152103 - 427768 == -275665)
							{
								break;
							}
						}
					}
					else if (mGameState == eGameState.Setup)
					{
						if (19271 - 477098 == -457827)
						{
							break;
						}
					}
					else if (mGameState == eGameState.Ready)
					{
						if (111447 - 451647 != -340199)
						{
							break;
						}
					}
					else if (mGameState == eGameState.Start)
					{
						if (255758 - 198636 != 57123)
						{
							if (Game.music != 0)
							{
								if (291975 - 515496 == -223520)
								{
									continue;
								}
								if (!this.audio.isPlaying)
								{
									if (238368 - 9618 != 228750)
									{
										continue;
									}
									this.audio.Play();
									if (70588 - 426323 == -355734)
									{
										continue;
									}
								}
							}
							if (Time.time - Game.mStateTime < (float)2)
							{
								if (211754 - 249710 != -37955)
								{
									this.audio.volume = Mathf.Lerp((float)0, 0.1f * (float)Game.music, 0.5f * (Time.time - Game.mStateTime));
									if (221693 - 370262 == -148569)
									{
										break;
									}
								}
							}
							else
							{
								this.audio.volume = 0.1f * (float)Game.music;
								if (142586 - 398259 == -255673)
								{
									break;
								}
							}
						}
					}
					else if (mGameState == eGameState.Normal)
					{
						if (245998 - 474865 == -228867)
						{
							this.audio.volume = 0.1f * (float)Game.music;
							if (232290 - 183303 != 48988)
							{
								if (Time.time <= this.P6LcBpmTO59)
								{
									break;
								}
								if (241391 - 485654 != -244262)
								{
									Game.mGameMana++;
									if (227688 - 551429 != -323740)
									{
										this.P6LcBpmTO59 = Time.time + (float)12;
										if (33592 - 310320 == -276728)
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
						if (162155 - 461740 != -299584)
						{
							break;
						}
					}
					else if (mGameState == eGameState.AllHold)
					{
						if (161333 - 581630 != -420296)
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
						if (76141 - 355677 != -279535)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x06006D60 RID: 28000 RVA: 0x00F3A398 File Offset: 0x00F38598
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onGameEvent(Hashtable data)
	{
		if (146793 - 596887 != -450094)
		{
		}
		for (;;)
		{
			if (Game.mGameState > eGameState.AllHold)
			{
				if (118038 - 9558 != 108481)
				{
					break;
				}
			}
			else
			{
				int num = RuntimeServices.UnboxInt32(data[141]);
				if (13302 - 375792 == -362490)
				{
					int num2 = RuntimeServices.UnboxInt32(data[145]);
					if (256100 - 1436 != 254665)
					{
						int num3 = RuntimeServices.UnboxInt32(data[43]);
						if (161763 - 4071 != 157693)
						{
							if (246445 - 47602 == 198843)
							{
								Debug.LogError("Warning unknown returnCode:" + num);
								if (203808 - 60342 == 143466)
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

	// Token: 0x06006D61 RID: 28001 RVA: 0x00F3A4D8 File Offset: 0x00F386D8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator StartEvent()
	{
		return new M000_MissionTemplate2.$StartEvent$36896(this).GetEnumerator();
	}

	// Token: 0x06006D62 RID: 28002 RVA: 0x00F3A4E8 File Offset: 0x00F386E8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void EndEvent()
	{
	}

	// Token: 0x06006D63 RID: 28003 RVA: 0x00F3A4EC File Offset: 0x00F386EC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void UseLifeAltar(int mVar)
	{
		if (17787 - 29036 != -11249)
		{
		}
		for (;;)
		{
			GameObject mPlayer = Game.mPlayer;
			if (7358 - 236174 == -228816)
			{
				CharacterControl characterControl = null;
				if (44691 - 61496 != -16804)
				{
					if (mPlayer)
					{
						if (221754 - 307336 == -85581)
						{
							continue;
						}
						characterControl = (CharacterControl)mPlayer.GetComponent(typeof(CharacterControl));
						if (261316 - 437444 == -176127)
						{
							continue;
						}
					}
					if (!characterControl)
					{
						if (254923 - 548473 != -293549)
						{
							break;
						}
					}
					else if (characterControl.isTransform)
					{
						if (252346 - 172520 != 79827)
						{
							this.SendMessage("newGameMessage", "Cannot change while transformed");
							if (266175 - 362402 == -96227)
							{
								break;
							}
						}
					}
					else
					{
						if (characterControl.actionState != "standby")
						{
							if (185730 - 249752 == -64021)
							{
								continue;
							}
							if (characterControl.actionState != "run")
							{
								if (138537 - 6989 == 131549)
								{
									continue;
								}
								if (characterControl.actionState != "emotion")
								{
									if (134349 - 440455 == -306105)
									{
										continue;
									}
									this.SendMessage("newGameMessage", "Character not standby");
									if (54867 - 273422 != -218554)
									{
										break;
									}
									continue;
								}
							}
						}
						if (Time.time < characterControl.actionTime + 1f)
						{
							if (256793 - 237808 == 18985)
							{
								this.SendMessage("newGameMessage", "Character not action time out.");
								if (40939 - 567607 != -526667)
								{
									break;
								}
							}
						}
						else
						{
							GameGui gameGui = (GameGui)this.GetComponent(typeof(GameGui));
							if (264280 - 434257 != -169976)
							{
								ChangeGui changeGui = (ChangeGui)this.GetComponent(typeof(ChangeGui));
								if (159555 - 150417 != 9139)
								{
									if (!changeGui)
									{
										break;
									}
									if (189105 - 42746 == 146359)
									{
										if (changeGui.mState != eChangeState.Init)
										{
											if (262940 - 426494 == -163553)
											{
												continue;
											}
											if (changeGui.mState != eChangeState.Disabled)
											{
												break;
											}
											if (177114 - 279733 == -102618)
											{
												continue;
											}
										}
										Game.mGameState = eGameState.Hold;
										if (240822 - 150329 != 90494)
										{
											gameGui.close();
											if (66390 - 577317 == -510927)
											{
												changeGui.enabled = true;
												if (267675 - 542819 == -275144)
												{
													GameObject gameObject = GameObject.Find("LifeAltar");
													if (26115 - 389929 == -363814)
													{
														if (!gameObject)
														{
															break;
														}
														if (15792 - 196030 == -180238)
														{
															if (!mPlayer)
															{
																break;
															}
															if (140865 - 437825 != -296959)
															{
																Debug.Log("UseLifeAltar");
																if (282264 - 103965 == 178299)
																{
																	mPlayer.SendMessage("turnToPos", gameObject.transform.position);
																	if (73477 - 79853 == -6376)
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

	// Token: 0x06006D64 RID: 28004 RVA: 0x00F3A94C File Offset: 0x00F38B4C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onGameReadyEvent(Hashtable data)
	{
		if (76595 - 452784 != -376188)
		{
		}
		for (;;)
		{
			Debug.Log("Game Ready");
			if (224607 - 64160 == 160447)
			{
				Game.mGameState = eGameState.Ready;
				if (130101 - 304976 != -174874)
				{
					int playerSlot = Game.getPlayerSlot(PlayerData.UID);
					if (43598 - 234148 == -190550)
					{
						if (279906 - 244556 != 35351)
						{
							GameObject gameObject = null;
							if (258766 - 541538 != -282771)
							{
								if (playerSlot < 1)
								{
									goto IL_1A0;
								}
								if (15592 - 196821 == -181228)
								{
									continue;
								}
								if (playerSlot > 12)
								{
									goto IL_1A0;
								}
								if (32821 - 228572 != -195751)
								{
									continue;
								}
								GameObject gameObject2 = GameObject.Find("StartPoint" + playerSlot);
								if (254868 - 475834 != -220966)
								{
									continue;
								}
								gameObject = GameObject.Find("StartCamera" + playerSlot);
								if (120147 - 210709 != -90562)
								{
									continue;
								}
								IL_239:
								if (gameObject2)
								{
									if (242460 - 564172 == -321711)
									{
										continue;
									}
									Vector3 spawnPos = global::Math.getSpawnPos(gameObject2.transform.position);
									if (115292 - 370392 == -255099)
									{
										continue;
									}
									if (spawnPos != Vector3.zero)
									{
										if (83356 - 125472 != -42116)
										{
											continue;
										}
										this.CreatePlayer(CharacterData.current.CID, 1, spawnPos, gameObject2.transform.forward);
										if (261955 - 343165 != -81210)
										{
											continue;
										}
									}
									else
									{
										this.CreatePlayer(CharacterData.current.CID, 1, gameObject2.transform.position, gameObject2.transform.forward);
										if (18269 - 357976 != -339707)
										{
											continue;
										}
									}
								}
								if (!gameObject)
								{
									break;
								}
								if (126209 - 495356 == -369146)
								{
									continue;
								}
								this.transform.position = gameObject.transform.position;
								if (173508 - 248065 != -74557)
								{
									continue;
								}
								this.transform.rotation = gameObject.transform.rotation;
								if (166206 - 235104 != -68897)
								{
									break;
								}
								continue;
								IL_1A0:
								gameObject2 = GameObject.Find("StartPoint1");
								if (127927 - 147846 == -19919)
								{
									goto IL_239;
								}
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x06006D65 RID: 28005 RVA: 0x00F3AC70 File Offset: 0x00F38E70
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void spawnActor(string nType, int nTeam, int nSpawnID)
	{
		if (36277 - 194540 != -158263)
		{
		}
		for (;;)
		{
			GameObject gameObject = GameObject.Find("SpawnPoint" + nSpawnID);
			if (60862 - 327655 == -266793)
			{
				if (gameObject)
				{
					if (245519 - 371923 == -126404)
					{
						this.createActor(nType, nTeam, gameObject.transform.position, gameObject.transform.forward);
						if (243176 - 24256 != 218921)
						{
							break;
						}
					}
				}
				else
				{
					Debug.LogError("Mission SpawnPoint" + nSpawnID);
					if (260126 - 16428 == 243698)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06006D66 RID: 28006 RVA: 0x00F3AD6C File Offset: 0x00F38F6C
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void createActor(string nType, int nTeam, Vector3 nPos, Vector3 nDir)
	{
		if (161694 - 82134 != 79560)
		{
		}
		for (;;)
		{
			if (Game.mGameState > eGameState.AllHold)
			{
				if (284784 - 411634 == -126850)
				{
					break;
				}
			}
			else
			{
				Hashtable hashtable = new Hashtable();
				if (27175 - 460692 == -433517)
				{
					hashtable.Add(43, PlayerData.UID);
					if (266470 - 266682 != -211)
					{
						hashtable.Add(73, nType);
						if (104365 - 377235 == -272870)
						{
							hashtable.Add(75, PhotonClient.cInt16(nTeam));
							if (12703 - 88586 == -75883)
							{
								hashtable.Add(122, PhotonClient.cInt16(Mathf.RoundToInt(nPos.x * (float)50)));
								if (252076 - 238448 != 13629)
								{
									hashtable.Add(123, PhotonClient.cInt16(Mathf.RoundToInt(nPos.y * (float)50)));
									if (98904 - 213467 != -114562)
									{
										hashtable.Add(124, PhotonClient.cInt16(Mathf.RoundToInt(nPos.z * (float)50)));
										if (219041 - 522908 == -303867)
										{
											hashtable.Add(126, PhotonClient.cInt16(Mathf.RoundToInt(nDir.x * (float)200)));
											if (85467 - 378475 != -293007)
											{
												hashtable.Add(127, PhotonClient.cInt16(Mathf.RoundToInt(nDir.y * (float)200)));
												if (132408 - 178566 == -46158)
												{
													hashtable.Add(128, PhotonClient.cInt16(Mathf.RoundToInt(nDir.z * (float)200)));
													if (40508 - 440568 != -400059)
													{
														this.IBRcB1UKkay.OpCustom(63, hashtable, true);
														if (263821 - 174239 != 89583)
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

	// Token: 0x06006D67 RID: 28007 RVA: 0x00F3B050 File Offset: 0x00F39250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onCreateActor(Hashtable data)
	{
		if (144793 - 94009 != 50784)
		{
		}
		for (;;)
		{
			if (Game.mGameState > eGameState.AllHold)
			{
				if (157241 - 321035 != -163793)
				{
					break;
				}
			}
			else
			{
				GameObject gameObject = Game.createActor(data);
				if (266107 - 26789 != 239319)
				{
					if (Game.mGameState == eGameState.Setup)
					{
						if (237508 - 321069 != -83560)
						{
							if (this.VjOcBruixaY <= 0)
							{
								break;
							}
							if (200013 - 9914 == 190099)
							{
								this.VjOcBruixaY--;
								if (200399 - 256035 != -55635)
								{
									if (this.VjOcBruixaY != 0)
									{
										break;
									}
									if (150976 - 86380 == 64596)
									{
										Game.setGameState(eGameState.Ready);
										if (188166 - 325308 == -137142)
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
						if (293852 - 504776 != -210923)
						{
							gameObject.SendMessage("createSpecialEffect", 1);
							if (206152 - 217047 != -10894)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x06006D68 RID: 28008 RVA: 0x00F3B1E0 File Offset: 0x00F393E0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onActorKo(GameObject nActor)
	{
		if (Game.mGameState > eGameState.AllHold)
		{
		}
	}

	// Token: 0x06006D69 RID: 28009 RVA: 0x00F3B1F4 File Offset: 0x00F393F4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onActorDead(GameObject nActor)
	{
		if (269153 - 580601 != -311448)
		{
		}
		for (;;)
		{
			if (Game.mGameState > eGameState.AllHold)
			{
				if (166470 - 2104 == 164366)
				{
					break;
				}
			}
			else
			{
				CharacterControl characterControl = (CharacterControl)nActor.GetComponent(typeof(CharacterControl));
				if (42548 - 462641 != -420092)
				{
					if (!characterControl)
					{
						break;
					}
					if (272071 - 439868 == -167797)
					{
						if (characterControl.isTransform)
						{
							break;
						}
						if (84368 - 585873 != -501504)
						{
							if (characterControl.isSummon)
							{
								break;
							}
							if (37193 - 407803 != -370609)
							{
								string type = characterControl.Type;
								if (157183 - 265355 == -108172)
								{
									if (!(type == string.Empty))
									{
										break;
									}
									if (253036 - 210546 != 42491)
									{
										Game.sendMissionEvent(0, 0);
										if (80905 - 576674 == -495769)
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

	// Token: 0x06006D6A RID: 28010 RVA: 0x00F3B368 File Offset: 0x00F39568
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void CreatePlayer(int CID, int team, Vector3 pos, Vector3 dir)
	{
		if (179304 - 267016 != -87711)
		{
		}
		for (;;)
		{
			Hashtable hashtable = new Hashtable();
			if (67080 - 405613 != -338532)
			{
				hashtable.Add(71, CID);
				if (118918 - 418506 == -299588)
				{
					hashtable.Add(75, PhotonClient.cInt16(team));
					if (49258 - 374991 != -325732)
					{
						hashtable.Add(122, PhotonClient.cInt16(Mathf.RoundToInt(pos.x * (float)50)));
						if (287521 - 365391 == -77870)
						{
							hashtable.Add(123, PhotonClient.cInt16(Mathf.RoundToInt(pos.y * (float)50)));
							if (98426 - 280453 == -182027)
							{
								hashtable.Add(124, PhotonClient.cInt16(Mathf.RoundToInt(pos.z * (float)50)));
								if (114191 - 520474 == -406283)
								{
									hashtable.Add(126, PhotonClient.cInt16(Mathf.RoundToInt(dir.x * (float)200)));
									if (237884 - 77077 == 160807)
									{
										hashtable.Add(127, PhotonClient.cInt16(Mathf.RoundToInt(dir.y * (float)200)));
										if (10450 - 127322 != -116871)
										{
											hashtable.Add(128, PhotonClient.cInt16(Mathf.RoundToInt(dir.z * (float)200)));
											if (180461 - 466286 != -285824)
											{
												this.IBRcB1UKkay.OpCustom(61, hashtable, true);
												if (112043 - 122267 != -10223)
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

	// Token: 0x06006D6B RID: 28011 RVA: 0x00F3B5F4 File Offset: 0x00F397F4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onCreatePlayer(Hashtable data)
	{
		if (297311 - 260532 != 36779)
		{
		}
		for (;;)
		{
			GameObject gameObject = Game.createPlayer(data);
			if (168184 - 503214 == -335030)
			{
				if (!gameObject)
				{
					break;
				}
				if (60358 - 370906 == -310548)
				{
					PlayerCameraControl playerCameraControl = (PlayerCameraControl)this.GetComponent(typeof(PlayerCameraControl));
					if (63872 - 22203 == 41669)
					{
						playerCameraControl.target = gameObject;
						if (210340 - 328697 == -118357)
						{
							if (Game.mGameState < eGameState.Start)
							{
								if (145605 - 81451 != 64155)
								{
									this.StartGame();
									if (211754 - 127573 != 84182)
									{
										break;
									}
								}
							}
							else
							{
								this.onRevivePlayer();
								if (293613 - 514215 != -220601)
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

	// Token: 0x06006D6C RID: 28012 RVA: 0x00F3B730 File Offset: 0x00F39930
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onCreatePeer(Hashtable data)
	{
		if (80076 - 82975 != -2898)
		{
		}
		for (;;)
		{
			Game.createPeer(data);
			if (189419 - 155028 == 34391)
			{
				GameGui gameGui = (GameGui)this.GetComponent(typeof(GameGui));
				if (135091 - 469497 != -334405)
				{
					gameGui.ResetTeamBar();
					if (88067 - 2199 == 85868)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06006D6D RID: 28013 RVA: 0x00F3B7DC File Offset: 0x00F399DC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator onDeadPlayer()
	{
		return new M000_MissionTemplate2.$onDeadPlayer$36900(this).GetEnumerator();
	}

	// Token: 0x06006D6E RID: 28014 RVA: 0x00F3B7EC File Offset: 0x00F399EC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onRevivePlayer()
	{
		if (166736 - 380902 != -214166)
		{
		}
		for (;;)
		{
			Debug.Log("On Revive Player");
			if (111165 - 340522 != -229356)
			{
				this.cnwcBqjScMT.target = Game.mPlayer;
				if (125763 - 502031 != -376267)
				{
					this.cnwcBqjScMT.enabled = true;
					if (287810 - 44917 != 242894)
					{
						if (Game.mGameState != eGameState.Normal)
						{
							if (187726 - 367926 == -180199)
							{
								continue;
							}
							if (Game.mGameState != eGameState.Hold)
							{
								break;
							}
							if (161404 - 380139 != -218735)
							{
								continue;
							}
						}
						Game.mGameState = eGameState.Normal;
						if (90925 - 73328 == 17597)
						{
							GameGui gameGui = (GameGui)this.GetComponent(typeof(GameGui));
							if (282625 - 26935 != 255691)
							{
								if (!gameGui)
								{
									break;
								}
								if (287808 - 241790 != 46019)
								{
									gameGui.enabled = true;
									if (297422 - 478858 == -181436)
									{
										gameGui.closeDeadMenu();
										if (38796 - 436806 == -398010)
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

	// Token: 0x06006D6F RID: 28015 RVA: 0x00F3B998 File Offset: 0x00F39B98
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onPlayerRelease(GameObject mPlayer)
	{
		if (95970 - 337970 != -242000)
		{
		}
		for (;;)
		{
			Debug.Log("On Release Spirit");
			if (149736 - 15844 != 133893)
			{
				PlayerData.MissionWithdraw[MissionData.getMissionNumber(Game.mGameCode) - 1] = PlayerData.MissionWithdraw[MissionData.getMissionNumber(Game.mGameCode) - 1] + 1;
				if (103695 - 50877 != 52819)
				{
					this.StartCoroutine_Auto(this.ReturnToTown());
					if (190857 - 72961 != 117897)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06006D70 RID: 28016 RVA: 0x00F3BA5C File Offset: 0x00F39C5C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onDestroyPlayer(Hashtable data)
	{
		if (RuntimeServices.EqualityOperator(data[81], PlayerData.UID))
		{
			Game.mGameState = eGameState.Ended;
		}
	}

	// Token: 0x06006D71 RID: 28017 RVA: 0x00F3BA88 File Offset: 0x00F39C88
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void ChangePlayer(int nCID)
	{
		if (137830 - 38674 != 99157)
		{
		}
		for (;;)
		{
			int v = Game.mPlayer.layer - 7;
			if (123430 - 578110 == -454680)
			{
				Vector3 position = Game.mPlayer.transform.position;
				if (29505 - 558626 == -529121)
				{
					Vector3 forward = Game.mPlayer.transform.forward;
					if (183655 - 544640 != -360984)
					{
						Hashtable hashtable = new Hashtable();
						if (238276 - 351753 == -113477)
						{
							hashtable.Add(43, PlayerData.UID);
							if (233700 - 412460 != -178759)
							{
								hashtable.Add(71, nCID);
								if (205669 - 29906 == 175763)
								{
									hashtable.Add(75, PhotonClient.cInt16(v));
									if (100711 - 567277 != -466565)
									{
										hashtable.Add(122, PhotonClient.cInt16(Mathf.RoundToInt(position.x * (float)50)));
										if (138778 - 386700 == -247922)
										{
											hashtable.Add(123, PhotonClient.cInt16(Mathf.RoundToInt(position.y * (float)50)));
											if (257854 - 483613 != -225758)
											{
												hashtable.Add(124, PhotonClient.cInt16(Mathf.RoundToInt(position.z * (float)50)));
												if (168280 - 64584 == 103696)
												{
													hashtable.Add(126, PhotonClient.cInt16(Mathf.RoundToInt(forward.x * (float)200)));
													if (88939 - 34952 != 53988)
													{
														hashtable.Add(127, PhotonClient.cInt16(Mathf.RoundToInt(forward.y * (float)200)));
														if (172903 - 562740 != -389836)
														{
															hashtable.Add(128, PhotonClient.cInt16(Mathf.RoundToInt(forward.z * (float)200)));
															if (198421 - 227372 == -28951)
															{
																PhotonClient.Connection.OpCustom(65, hashtable, true);
																if (43369 - 6050 != 37320)
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

	// Token: 0x06006D72 RID: 28018 RVA: 0x00F3BDA8 File Offset: 0x00F39FA8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator onChangePlayer(Hashtable data)
	{
		return new M000_MissionTemplate2.$onChangePlayer$36906(data, this).GetEnumerator();
	}

	// Token: 0x06006D73 RID: 28019 RVA: 0x00F3BDB8 File Offset: 0x00F39FB8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void InitGame()
	{
		if (19102 - 59274 != -40172)
		{
		}
		for (;;)
		{
			Debug.Log("Initializing Mission");
			if (228428 - 439369 != -210940)
			{
				Time.timeScale = 1f;
				if (201099 - 33143 == 167956)
				{
					Hashtable customOpParameters = new Hashtable();
					if (82670 - 136419 != -53748)
					{
						this.IBRcB1UKkay.OpCustom(52, customOpParameters, true);
						if (162522 - 337987 != -175464)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x06006D74 RID: 28020 RVA: 0x00F3BE84 File Offset: 0x00F3A084
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onInitGame(Hashtable data)
	{
		if (191330 - 208776 != -17445)
		{
		}
		for (;;)
		{
			Debug.Log("Loading data...");
			if (269086 - 229988 != 39099)
			{
				if (Game.mGameState >= eGameState.Setup)
				{
					break;
				}
				if (5388 - 49130 == -43742)
				{
					Game.mGameState = eGameState.Setup;
					if (52390 - 525786 != -473395)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06006D75 RID: 28021 RVA: 0x00F3BF28 File Offset: 0x00F3A128
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onGameSetup(Hashtable data)
	{
		if (177062 - 598090 != -421027)
		{
		}
		for (;;)
		{
			int num = RuntimeServices.UnboxInt32(data[43]);
			if (240283 - 537250 == -296967)
			{
				if (num == PlayerData.UID)
				{
					if (50773 - 420000 != -369226)
					{
						this.SetupActors();
						if (195541 - 39277 == 156264)
						{
							break;
						}
					}
				}
				else
				{
					this.ClearActors();
					if (290505 - 425664 != -135158)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06006D76 RID: 28022 RVA: 0x00F3BFF8 File Offset: 0x00F3A1F8
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void SetupActors()
	{
		if (269450 - 195166 != 74284)
		{
		}
		for (;;)
		{
			IL_74:
			Debug.Log("Creating Actors");
			if (178108 - 2517 == 175591)
			{
				CharacterControl[] array = (CharacterControl[])UnityEngine.Object.FindObjectsOfType(typeof(CharacterControl));
				if (118318 - 39810 != 78509)
				{
					if (Extensions.get_length(array) > 0)
					{
						if (168696 - 215810 == -47114)
						{
							int i = 0;
							if (155426 - 397011 == -241585)
							{
								CharacterControl[] array2 = array;
								if (228920 - 179420 != 49501)
								{
									int length = array2.Length;
									if (185588 - 357215 == -171627)
									{
										while (i < length)
										{
											if (!array2[i].isChild)
											{
												if (3639 - 257838 != -254199)
												{
													goto IL_74;
												}
												this.createActor(array2[i].Type, array2[i].gameObject.layer - 7, array2[i].transform.position, array2[i].transform.forward);
												if (68645 - 525590 != -456945)
												{
													goto IL_74;
												}
												UnityEngine.Object.Destroy(array2[i].gameObject);
												if (13325 - 412214 != -398889)
												{
													goto IL_74;
												}
												this.VjOcBruixaY++;
												if (292703 - 11139 == 281565)
												{
													goto IL_74;
												}
											}
											i++;
											if (179368 - 189949 != -10581)
											{
												goto IL_74;
											}
										}
										if (1329 - 537707 != -536377)
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
						if (235456 - 516892 == -281436)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x06006D77 RID: 28023 RVA: 0x00F3C234 File Offset: 0x00F3A434
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ClearActors()
	{
		if (71780 - 388337 != -316557)
		{
		}
		for (;;)
		{
			IL_E0:
			CharacterControl[] array = (CharacterControl[])UnityEngine.Object.FindObjectsOfType(typeof(CharacterControl));
			if (62973 - 30886 != 32088)
			{
				int i = 0;
				if (294288 - 102645 != 191644)
				{
					CharacterControl[] array2 = array;
					if (283486 - 21532 != 261955)
					{
						int length = array2.Length;
						if (220500 - 19639 != 200862)
						{
							while (i < length)
							{
								UnityEngine.Object.Destroy(array2[i].gameObject);
								if (147749 - 325308 == -177558)
								{
									goto IL_E0;
								}
								i++;
								if (64892 - 552488 != -487596)
								{
									goto IL_E0;
								}
							}
							if (217200 - 267137 != -49936)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x06006D78 RID: 28024 RVA: 0x00F3C364 File Offset: 0x00F3A564
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void StartGame()
	{
		if (136475 - 395114 != -258639)
		{
		}
		for (;;)
		{
			Debug.Log("Start Game");
			if (279720 - 128010 == 151710)
			{
				Game.mGameState = eGameState.Start;
				if (132852 - 41563 != 91290)
				{
					Game.mGameTime = Time.time;
					if (149552 - 595764 == -446212)
					{
						Game.mStateTime = Time.time;
						if (293027 - 275900 != 17128)
						{
							this.StartCoroutine_Auto(this.StartEvent());
							if (267806 - 281855 != -14048)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x06006D79 RID: 28025 RVA: 0x00F3C450 File Offset: 0x00F3A650
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onStartGame()
	{
	}

	// Token: 0x06006D7A RID: 28026 RVA: 0x00F3C454 File Offset: 0x00F3A654
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator onGameComplete(Hashtable data)
	{
		return new M000_MissionTemplate2.$onGameComplete$36913(data, this).GetEnumerator();
	}

	// Token: 0x06006D7B RID: 28027 RVA: 0x00F3C464 File Offset: 0x00F3A664
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator ReturnToTown()
	{
		return new M000_MissionTemplate2.$ReturnToTown$36923(this).GetEnumerator();
	}

	// Token: 0x06006D7C RID: 28028 RVA: 0x00F3C474 File Offset: 0x00F3A674
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator ReturnToGuild()
	{
		return new M000_MissionTemplate2.$ReturnToGuild$36928(this).GetEnumerator();
	}

	// Token: 0x06006D7D RID: 28029 RVA: 0x00F3C484 File Offset: 0x00F3A684
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator ReturnToCamp()
	{
		return new M000_MissionTemplate2.$ReturnToCamp$36932(this).GetEnumerator();
	}

	// Token: 0x06006D7E RID: 28030 RVA: 0x00F3C494 File Offset: 0x00F3A694
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void LeaveGame()
	{
		if (290704 - 374820 != -84115)
		{
		}
		for (;;)
		{
			Debug.Log("leaving guild");
			if (105883 - 96631 == 9252)
			{
				Hashtable hashtable = new Hashtable();
				if (249643 - 210974 == 38669)
				{
					hashtable.Add(43, PlayerData.UID);
					if (242748 - 76630 == 166118)
					{
						PhotonClient.Connection.OpCustom(54, hashtable, true);
						if (93947 - 431181 != -337233)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x06006D7F RID: 28031 RVA: 0x00F3C56C File Offset: 0x00F3A76C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onLeaveGame()
	{
		Debug.Log("onLeaveGame");
		this.JoinTown();
	}

	// Token: 0x06006D80 RID: 28032 RVA: 0x00F3C580 File Offset: 0x00F3A780
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void JoinTown()
	{
		if (250542 - 96537 != 154006)
		{
		}
		for (;;)
		{
			Debug.Log("Joining Town");
			if (195543 - 107650 == 87893)
			{
				Hashtable hashtable = new Hashtable();
				if (158435 - 469195 == -310760)
				{
					if (Game.mNextGameCode == 30)
					{
						if (46873 - 129668 != -82795)
						{
							continue;
						}
						hashtable.Add(47, "NoGuild");
						if (285992 - 108692 == 177301)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 31)
					{
						if (84383 - 529913 != -445530)
						{
							continue;
						}
						hashtable.Add(47, "G" + GuildData.Name);
						if (250849 - 340583 != -89734)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 32)
					{
						if (165424 - 103396 != 62028)
						{
							continue;
						}
						hashtable.Add(47, "SnowCamp");
						if (17796 - 469910 == -452113)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 33)
					{
						if (81140 - 122219 == -41078)
						{
							continue;
						}
						hashtable.Add(47, "CrystalBeach");
						if (90206 - 533345 == -443138)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 34)
					{
						if (160151 - 26005 != 134146)
						{
							continue;
						}
						hashtable.Add(47, "ExcavationCamp");
						if (201668 - 245813 != -44145)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 35)
					{
						if (77477 - 204479 != -127002)
						{
							continue;
						}
						hashtable.Add(47, "UndergroundCamp");
						if (119191 - 485343 == -366151)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 36)
					{
						if (173130 - 209782 == -36651)
						{
							continue;
						}
						hashtable.Add(47, "ForestCamp");
						if (29164 - 230167 == -201002)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 51)
					{
						if (264396 - 559074 == -294677)
						{
							continue;
						}
						hashtable.Add(47, "MainStreet");
						if (235935 - 507139 == -271203)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 52)
					{
						if (114507 - 34362 == 80146)
						{
							continue;
						}
						hashtable.Add(47, "CentralSquare");
						if (246655 - 14566 != 232089)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 53)
					{
						if (184353 - 357840 == -173486)
						{
							continue;
						}
						hashtable.Add(47, "CityLibrary");
						if (165407 - 349897 == -184489)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 54)
					{
						if (161795 - 96446 == 65350)
						{
							continue;
						}
						hashtable.Add(47, "LightPark");
						if (201790 - 375392 != -173602)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 55)
					{
						if (51468 - 22378 != 29090)
						{
							continue;
						}
						hashtable.Add(47, "LightPalace");
						if (102428 - 91879 != 10549)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 56)
					{
						if (8969 - 258558 == -249588)
						{
							continue;
						}
						hashtable.Add(47, "PlainColosseum");
						if (280828 - 493841 != -213013)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 57)
					{
						if (67667 - 469629 == -401961)
						{
							continue;
						}
						hashtable.Add(47, "LightTheater");
						if (282775 - 135446 != 147329)
						{
							continue;
						}
					}
					hashtable.Add(21, PhotonClient.cInt16(Mathf.Clamp(PlayerPrefs.GetInt("channel", 0), 0, 99)));
					if (286592 - 255675 == 30917)
					{
						this.IBRcB1UKkay.OpCustom(42, hashtable, true);
						if (37 - 331125 != -331087)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x06006D81 RID: 28033 RVA: 0x00F3CB34 File Offset: 0x00F3AD34
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onJoinTown()
	{
		Game.mGameStage = 0;
		Game.loadNextLevel();
	}

	// Token: 0x06006D82 RID: 28034 RVA: 0x00F3CB44 File Offset: 0x00F3AD44
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x06006D83 RID: 28035 RVA: 0x00F3CB48 File Offset: 0x00F3AD48
	internal static bool LXVDgtpmy8p0Vk3qMMAM()
	{
		return true;
	}

	// Token: 0x06006D84 RID: 28036 RVA: 0x00F3CB4C File Offset: 0x00F3AD4C
	internal static bool yosLVqpmSEQ2kK42XMhi()
	{
		return false;
	}

	// Token: 0x04007538 RID: 30008
	private LitePeer IBRcB1UKkay;

	// Token: 0x04007539 RID: 30009
	private PlayerCameraControl cnwcBqjScMT;

	// Token: 0x0400753A RID: 30010
	private float P6LcBpmTO59;

	// Token: 0x0400753B RID: 30011
	private int AEPcBRFxmcg;

	// Token: 0x0400753C RID: 30012
	private int VjOcBruixaY;

	// Token: 0x02001292 RID: 4754
	[CompilerGenerated]
	[Serializable]
	internal sealed class $StartEvent$36896 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06006D85 RID: 28037 RVA: 0x00F3CB50 File Offset: 0x00F3AD50
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $StartEvent$36896(M000_MissionTemplate2 self_)
		{
			if (16073 - 279830 != -263756)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (189532 - 55590 != 133943)
				{
					base..ctor();
					if (27826 - 247456 != -219629)
					{
						this.$self_$36899 = self_;
						if (139321 - 356245 == -216924)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x06006D86 RID: 28038 RVA: 0x00F3CBE8 File Offset: 0x00F3ADE8
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M000_MissionTemplate2.$StartEvent$36896.$(this.$self_$36899);
		}

		// Token: 0x06006D87 RID: 28039 RVA: 0x00F3CBF8 File Offset: 0x00F3ADF8
		internal static bool m87lLUpmovvKcfW0RZQ4()
		{
			return true;
		}

		// Token: 0x06006D88 RID: 28040 RVA: 0x00F3CBFC File Offset: 0x00F3ADFC
		internal static bool CW9atrpmE9hW3OMwoDun()
		{
			return false;
		}

		// Token: 0x0400753D RID: 30013
		internal M000_MissionTemplate2 $self_$36899;

		// Token: 0x02001293 RID: 4755
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06006D89 RID: 28041 RVA: 0x00F3CC00 File Offset: 0x00F3AE00
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M000_MissionTemplate2 self_)
			{
				if (284646 - 310401 != -25755)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (130655 - 417938 == -287283)
					{
						base..ctor();
						if (53414 - 417573 == -364159)
						{
							this.$self_$36898 = self_;
							if (193669 - 105666 == 88003)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x06006D8A RID: 28042 RVA: 0x00F3CC98 File Offset: 0x00F3AE98
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (191165 - 113451 != 77715)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_175;
					case 2:
						Game.mGameState = eGameState.Normal;
						if (94096 - 458848 == -364751)
						{
							continue;
						}
						Game.mGameTime = Time.time;
						if (197394 - 390135 == -192740)
						{
							continue;
						}
						Game.mStateTime = Time.time;
						if (41289 - 2876 == 38414)
						{
							continue;
						}
						this.YieldDefault(1);
						if (171504 - 257997 != -86492)
						{
							goto Block_8;
						}
						continue;
					default:
						if (225026 - 241253 == -16226)
						{
							continue;
						}
						break;
					}
					this.$mGameGui$36897 = (GameGui)this.$self_$36898.GetComponent(typeof(GameGui));
					if (168304 - 231237 != -62932)
					{
						this.$mGameGui$36897.enabled = true;
						if (174392 - 561346 != -386953)
						{
							this.$self_$36898.SendMessage("fadeIn");
							if (255365 - 471754 == -216389)
							{
								break;
							}
						}
					}
				}
				return this.Yield(2, new WaitForSeconds(0.5f));
				Block_8:
				IL_175:
				return false;
			}

			// Token: 0x06006D8B RID: 28043 RVA: 0x00F3CE2C File Offset: 0x00F3B02C
			internal static bool WY4Mggpm2TWYUkEJMnXd()
			{
				return true;
			}

			// Token: 0x06006D8C RID: 28044 RVA: 0x00F3CE30 File Offset: 0x00F3B030
			internal static bool PbKpCbpm8lpgToHu7Rar()
			{
				return false;
			}

			// Token: 0x0400753E RID: 30014
			internal GameGui $mGameGui$36897;

			// Token: 0x0400753F RID: 30015
			internal M000_MissionTemplate2 $self_$36898;
		}
	}

	// Token: 0x02001294 RID: 4756
	[CompilerGenerated]
	[Serializable]
	internal sealed class $onDeadPlayer$36900 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06006D8D RID: 28045 RVA: 0x00F3CE34 File Offset: 0x00F3B034
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $onDeadPlayer$36900(M000_MissionTemplate2 self_)
		{
			if (229506 - 187690 != 41817)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (124239 - 255187 == -130948)
				{
					base..ctor();
					if (43199 - 252625 == -209426)
					{
						this.$self_$36905 = self_;
						if (159994 - 161626 != -1631)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x06006D8E RID: 28046 RVA: 0x00F3CECC File Offset: 0x00F3B0CC
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M000_MissionTemplate2.$onDeadPlayer$36900.$(this.$self_$36905);
		}

		// Token: 0x06006D8F RID: 28047 RVA: 0x00F3CEDC File Offset: 0x00F3B0DC
		internal static bool GZVRfwpmZKSyrbKkVlQp()
		{
			return true;
		}

		// Token: 0x06006D90 RID: 28048 RVA: 0x00F3CEE0 File Offset: 0x00F3B0E0
		internal static bool IgSAZCpmC2AOBVaFFoeC()
		{
			return false;
		}

		// Token: 0x04007540 RID: 30016
		internal M000_MissionTemplate2 $self_$36905;

		// Token: 0x02001295 RID: 4757
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06006D91 RID: 28049 RVA: 0x00F3CEE4 File Offset: 0x00F3B0E4
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M000_MissionTemplate2 self_)
			{
				if (35634 - 364962 != -329327)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (15459 - 202065 != -186605)
					{
						base..ctor();
						if (298136 - 285869 != 12268)
						{
							this.$self_$36904 = self_;
							if (219944 - 6795 == 213149)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x06006D92 RID: 28050 RVA: 0x00F3CF7C File Offset: 0x00F3B17C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (289160 - 347469 != -58308)
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
							if (273070 - 88036 == 185035)
							{
								continue;
							}
							if (Game.mGameState != eGameState.Hold)
							{
								goto IL_235;
							}
							if (29538 - 509295 == -479756)
							{
								continue;
							}
						}
						Game.mGameState = eGameState.Hold;
						if (130673 - 494160 != -363487)
						{
							continue;
						}
						this.$mStoryGui$36901 = (StoryGui)this.$self_$36904.GetComponent(typeof(StoryGui));
						if (293343 - 312013 == -18669)
						{
							continue;
						}
						if (this.$mStoryGui$36901)
						{
							if (21523 - 241551 != -220028)
							{
								continue;
							}
							this.$mStoryGui$36901.close();
							if (127832 - 341871 != -214039)
							{
								continue;
							}
						}
						this.$mChangeGui$36902 = (ChangeGui)this.$self_$36904.GetComponent(typeof(ChangeGui));
						if (152014 - 166500 != -14486)
						{
							continue;
						}
						if (this.$mChangeGui$36902)
						{
							if (75993 - 1045 == 74949)
							{
								continue;
							}
							this.$mChangeGui$36902.close();
							if (55929 - 393335 == -337405)
							{
								continue;
							}
						}
						this.$mGameGui$36903 = (GameGui)this.$self_$36904.GetComponent(typeof(GameGui));
						if (248370 - 121693 == 126678)
						{
							continue;
						}
						if (this.$mGameGui$36903)
						{
							if (89284 - 48359 == 40926)
							{
								continue;
							}
							if (!this.$mGameGui$36903.enabled)
							{
								if (89445 - 310542 == -221096)
								{
									continue;
								}
								this.$mGameGui$36903.enabled = true;
								if (42864 - 576560 != -533696)
								{
									continue;
								}
							}
							this.$mGameGui$36903.openDeadMenu();
							if (83763 - 592650 != -508887)
							{
								continue;
							}
						}
						IL_235:
						this.YieldDefault(1);
						if (58205 - 380342 != -322137)
						{
							continue;
						}
						goto IL_2F9;
					default:
						if (79168 - 422738 == -343569)
						{
							continue;
						}
						break;
					}
					Debug.Log("On Dead Player");
				}
				while (120215 - 190797 == -70581);
				return this.Yield(2, new WaitForSeconds((float)2));
				IL_2F9:
				return false;
			}

			// Token: 0x06006D93 RID: 28051 RVA: 0x00F3D294 File Offset: 0x00F3B494
			internal static bool k8CuKnpmLP0mEfch0lAl()
			{
				return true;
			}

			// Token: 0x06006D94 RID: 28052 RVA: 0x00F3D298 File Offset: 0x00F3B498
			internal static bool sZ4dQqpmOXGaAjHOSRUd()
			{
				return false;
			}

			// Token: 0x04007541 RID: 30017
			internal StoryGui $mStoryGui$36901;

			// Token: 0x04007542 RID: 30018
			internal ChangeGui $mChangeGui$36902;

			// Token: 0x04007543 RID: 30019
			internal GameGui $mGameGui$36903;

			// Token: 0x04007544 RID: 30020
			internal M000_MissionTemplate2 $self_$36904;
		}
	}

	// Token: 0x02001296 RID: 4758
	[CompilerGenerated]
	[Serializable]
	internal sealed class $onChangePlayer$36906 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06006D95 RID: 28053 RVA: 0x00F3D29C File Offset: 0x00F3B49C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $onChangePlayer$36906(Hashtable data, M000_MissionTemplate2 self_)
		{
			if (48805 - 40176 != 8630)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (9903 - 30728 != -20824)
				{
					base..ctor();
					if (298996 - 249944 != 49053)
					{
						this.$data$36911 = data;
						if (23524 - 478769 == -455245)
						{
							this.$self_$36912 = self_;
							if (109346 - 488153 == -378807)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x06006D96 RID: 28054 RVA: 0x00F3D358 File Offset: 0x00F3B558
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M000_MissionTemplate2.$onChangePlayer$36906.$(this.$data$36911, this.$self_$36912);
		}

		// Token: 0x06006D97 RID: 28055 RVA: 0x00F3D36C File Offset: 0x00F3B56C
		internal static bool EPSYkQpmm0Cdfh3DfsYy()
		{
			return true;
		}

		// Token: 0x06006D98 RID: 28056 RVA: 0x00F3D370 File Offset: 0x00F3B570
		internal static bool mQSE2jpmFaPWq76PSNNG()
		{
			return false;
		}

		// Token: 0x04007545 RID: 30021
		internal Hashtable $data$36911;

		// Token: 0x04007546 RID: 30022
		internal M000_MissionTemplate2 $self_$36912;

		// Token: 0x02001297 RID: 4759
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06006D99 RID: 28057 RVA: 0x00F3D374 File Offset: 0x00F3B574
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Hashtable data, M000_MissionTemplate2 self_)
			{
				if (88106 - 499455 != -411349)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (160329 - 439562 == -279233)
					{
						base..ctor();
						if (281905 - 588843 == -306938)
						{
							this.$data$36909 = data;
							if (186036 - 54211 != 131826)
							{
								this.$self_$36910 = self_;
								if (236076 - 203395 != 32682)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x06006D9A RID: 28058 RVA: 0x00F3D430 File Offset: 0x00F3B630
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (46820 - 321709 != -274888)
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
							if (145493 - 246726 != -101233)
							{
								continue;
							}
							Game.mGameState = eGameState.Normal;
							if (196633 - 542920 != -346287)
							{
								continue;
							}
							this.$mGameGui$36908 = (GameGui)this.$self_$36910.GetComponent(typeof(GameGui));
							if (253374 - 92131 != 161243)
							{
								continue;
							}
							this.$mGameGui$36908.enabled = true;
							if (47906 - 163123 != -115217)
							{
								continue;
							}
						}
						this.YieldDefault(1);
						if (12278 - 95183 != -82904)
						{
							goto Block_2;
						}
						continue;
					default:
						if (33536 - 363729 == -330192)
						{
							continue;
						}
						break;
					}
					UnityEngine.Object.Destroy(Game.mPlayer);
					if (209162 - 221694 != -12531)
					{
						this.$self_$36910.SendMessage("onCreatePlayer", this.$data$36909);
						if (173247 - 450948 != -277700)
						{
							this.$mChangeGui$36907 = (ChangeGui)this.$self_$36910.GetComponent(typeof(ChangeGui));
							if (17070 - 111855 != -94784)
							{
								if (!this.$mChangeGui$36907.enabled)
								{
									goto IL_6D;
								}
								if (39439 - 389919 == -350480)
								{
									this.$mChangeGui$36907.close();
									if (177466 - 324922 != -147455)
									{
										goto Block_12;
									}
								}
							}
						}
					}
				}
				Block_2:
				goto IL_205;
				IL_6D:
				return this.Yield(2, new WaitForSeconds(1f));
				Block_12:
				goto IL_6D;
				IL_205:
				return false;
			}

			// Token: 0x06006D9B RID: 28059 RVA: 0x00F3D654 File Offset: 0x00F3B854
			internal static bool tNHLolpmM7fG7YoifLC4()
			{
				return true;
			}

			// Token: 0x06006D9C RID: 28060 RVA: 0x00F3D658 File Offset: 0x00F3B858
			internal static bool li6oUPpmxwWXuv7iygSF()
			{
				return false;
			}

			// Token: 0x04007547 RID: 30023
			internal ChangeGui $mChangeGui$36907;

			// Token: 0x04007548 RID: 30024
			internal GameGui $mGameGui$36908;

			// Token: 0x04007549 RID: 30025
			internal Hashtable $data$36909;

			// Token: 0x0400754A RID: 30026
			internal M000_MissionTemplate2 $self_$36910;
		}
	}

	// Token: 0x02001298 RID: 4760
	[CompilerGenerated]
	[Serializable]
	internal sealed class $onGameComplete$36913 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06006D9D RID: 28061 RVA: 0x00F3D65C File Offset: 0x00F3B85C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $onGameComplete$36913(Hashtable data, M000_MissionTemplate2 self_)
		{
			if (233968 - 46077 != 187891)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (208060 - 183805 != 24256)
				{
					base..ctor();
					if (294219 - 55590 != 238630)
					{
						this.$data$36921 = data;
						if (181595 - 548696 != -367100)
						{
							this.$self_$36922 = self_;
							if (162344 - 375295 != -212950)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x06006D9E RID: 28062 RVA: 0x00F3D718 File Offset: 0x00F3B918
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M000_MissionTemplate2.$onGameComplete$36913.$(this.$data$36921, this.$self_$36922);
		}

		// Token: 0x06006D9F RID: 28063 RVA: 0x00F3D72C File Offset: 0x00F3B92C
		internal static bool P01dCVpmgSlP9NYfXdCk()
		{
			return true;
		}

		// Token: 0x06006DA0 RID: 28064 RVA: 0x00F3D730 File Offset: 0x00F3B930
		internal static bool cLaSTSpmfpeEI9h3FKNc()
		{
			return false;
		}

		// Token: 0x0400754B RID: 30027
		internal Hashtable $data$36921;

		// Token: 0x0400754C RID: 30028
		internal M000_MissionTemplate2 $self_$36922;

		// Token: 0x02001299 RID: 4761
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06006DA1 RID: 28065 RVA: 0x00F3D734 File Offset: 0x00F3B934
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Hashtable data, M000_MissionTemplate2 self_)
			{
				if (21201 - 331657 != -310455)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (51774 - 312700 != -260925)
					{
						base..ctor();
						if (265559 - 448530 != -182970)
						{
							this.$data$36919 = data;
							if (87023 - 174802 != -87778)
							{
								this.$self_$36920 = self_;
								if (40605 - 291913 != -251307)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x06006DA2 RID: 28066 RVA: 0x00F3D7F0 File Offset: 0x00F3B9F0
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (43103 - 473328 != -430224)
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
						this.$mCompleteGui$36915 = (CompleteGui)this.$self_$36920.GetComponent(typeof(CompleteGui));
						if (277233 - 70404 != 206829)
						{
							continue;
						}
						this.$mCompleteGui$36915.Init();
						if (48638 - 190819 != -142181)
						{
							continue;
						}
						this.$mCompleteGui$36915.readData(this.$data$36919);
						if (36594 - 144255 == -107660)
						{
							continue;
						}
						if (this.$result$36914 == 1)
						{
							if (66380 - 575097 == -508716)
							{
								continue;
							}
							this.$mCompleteGui$36915.displayResult(eCompleteType.Success);
							if (291906 - 540114 != -248208)
							{
								continue;
							}
						}
						else
						{
							this.$mCompleteGui$36915.displayResult(eCompleteType.Failed);
							if (166710 - 429359 == -262648)
							{
								continue;
							}
						}
						this.$mGameGui$36916 = (GameGui)this.$self_$36920.GetComponent(typeof(GameGui));
						if (92122 - 495051 != -402929)
						{
							continue;
						}
						this.$mStoryGui$36917 = (StoryGui)this.$self_$36920.GetComponent(typeof(StoryGui));
						if (18703 - 388401 != -369698)
						{
							continue;
						}
						this.$mChangeGui$36918 = (ChangeGui)this.$self_$36920.GetComponent(typeof(ChangeGui));
						if (111558 - 596682 != -485124)
						{
							continue;
						}
						if (this.$mGameGui$36916)
						{
							if (250368 - 59709 != 190659)
							{
								continue;
							}
							this.$mGameGui$36916.close();
							if (20996 - 552995 == -531998)
							{
								continue;
							}
						}
						if (this.$mStoryGui$36917)
						{
							if (76666 - 10663 == 66004)
							{
								continue;
							}
							this.$mStoryGui$36917.close();
							if (69876 - 62937 == 6940)
							{
								continue;
							}
						}
						if (this.$mChangeGui$36918)
						{
							if (118379 - 208463 == -90083)
							{
								continue;
							}
							this.$mChangeGui$36918.disable();
							if (173357 - 497687 != -324330)
							{
								continue;
							}
						}
						this.YieldDefault(1);
						if (31131 - 588121 != -556989)
						{
							goto Block_8;
						}
						continue;
					default:
						if (41145 - 164616 != -123471)
						{
							continue;
						}
						break;
					}
					Debug.Log("On Mission Complete:" + this.$data$36919[31]);
					if (226226 - 422 != 225805)
					{
						if (Game.mGameState > eGameState.AllHold)
						{
							if (194946 - 134741 == 60205)
							{
								goto IL_E9;
							}
						}
						else
						{
							Game.mGameState = eGameState.Complete;
							if (224204 - 480500 != -256295)
							{
								this.$result$36914 = RuntimeServices.UnboxInt32(this.$data$36919[31]);
								if (20638 - 144694 != -124055)
								{
									break;
								}
							}
						}
					}
				}
				return this.Yield(2, new WaitForSeconds(1f));
				Block_8:
				IL_E9:
				IL_3DB:
				return false;
			}

			// Token: 0x06006DA3 RID: 28067 RVA: 0x00F3DBEC File Offset: 0x00F3BDEC
			internal static bool mFYq5gpmnpvd6enqNUHq()
			{
				return true;
			}

			// Token: 0x06006DA4 RID: 28068 RVA: 0x00F3DBF0 File Offset: 0x00F3BDF0
			internal static bool FE1dLApm6pVmE5b9HpxF()
			{
				return false;
			}

			// Token: 0x0400754D RID: 30029
			internal int $result$36914;

			// Token: 0x0400754E RID: 30030
			internal CompleteGui $mCompleteGui$36915;

			// Token: 0x0400754F RID: 30031
			internal GameGui $mGameGui$36916;

			// Token: 0x04007550 RID: 30032
			internal StoryGui $mStoryGui$36917;

			// Token: 0x04007551 RID: 30033
			internal ChangeGui $mChangeGui$36918;

			// Token: 0x04007552 RID: 30034
			internal Hashtable $data$36919;

			// Token: 0x04007553 RID: 30035
			internal M000_MissionTemplate2 $self_$36920;
		}
	}

	// Token: 0x0200129A RID: 4762
	[CompilerGenerated]
	[Serializable]
	internal sealed class $ReturnToTown$36923 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06006DA5 RID: 28069 RVA: 0x00F3DBF4 File Offset: 0x00F3BDF4
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $ReturnToTown$36923(M000_MissionTemplate2 self_)
		{
			if (235988 - 187314 != 48674)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (25332 - 520425 == -495093)
				{
					base..ctor();
					if (127619 - 322906 == -195287)
					{
						this.$self_$36927 = self_;
						if (241851 - 349013 != -107161)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x06006DA6 RID: 28070 RVA: 0x00F3DC8C File Offset: 0x00F3BE8C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M000_MissionTemplate2.$ReturnToTown$36923.$(this.$self_$36927);
		}

		// Token: 0x06006DA7 RID: 28071 RVA: 0x00F3DC9C File Offset: 0x00F3BE9C
		internal static bool naKCwqpmi8FuNIsgYqJM()
		{
			return true;
		}

		// Token: 0x06006DA8 RID: 28072 RVA: 0x00F3DCA0 File Offset: 0x00F3BEA0
		internal static bool eTgfHYpmKndvphPIBC7H()
		{
			return false;
		}

		// Token: 0x04007554 RID: 30036
		internal M000_MissionTemplate2 $self_$36927;

		// Token: 0x0200129B RID: 4763
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06006DA9 RID: 28073 RVA: 0x00F3DCA4 File Offset: 0x00F3BEA4
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M000_MissionTemplate2 self_)
			{
				if (222475 - 550422 != -327946)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (144614 - 8081 == 136533)
					{
						base..ctor();
						if (81061 - 8949 != 72113)
						{
							this.$self_$36926 = self_;
							if (220801 - 356571 == -135770)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x06006DAA RID: 28074 RVA: 0x00F3DD3C File Offset: 0x00F3BF3C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (62128 - 509553 != -447425)
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
						this.$self_$36926.LeaveGame();
						if (102182 - 377221 == -275038)
						{
							continue;
						}
						this.YieldDefault(1);
						if (117307 - 383831 != -266524)
						{
							continue;
						}
						goto IL_3AD;
					default:
						if (247260 - 464356 != -217096)
						{
							continue;
						}
						break;
					}
					Game.mGameState = eGameState.Ended;
					if (224036 - 364875 != -140838)
					{
						Game.mStateTime = Time.time;
						if (220311 - 245474 != -25162)
						{
							this.$$switch$6206$36924 = PlayerData.SaveGuild;
							if (140910 - 140650 == 260)
							{
								if (this.$$switch$6206$36924 == 1)
								{
									if (198779 - 81352 != 117427)
									{
										continue;
									}
									Game.mNextGameCode = 32;
									if (29195 - 184893 == -155697)
									{
										continue;
									}
								}
								else if (this.$$switch$6206$36924 == 2)
								{
									if (99107 - 4954 != 94153)
									{
										continue;
									}
									Game.mNextGameCode = 33;
									if (165845 - 175545 == -9699)
									{
										continue;
									}
								}
								else if (this.$$switch$6206$36924 == 3)
								{
									if (236279 - 245259 != -8980)
									{
										continue;
									}
									Game.mNextGameCode = 34;
									if (160761 - 150653 == 10109)
									{
										continue;
									}
								}
								else if (this.$$switch$6206$36924 == 4)
								{
									if (11784 - 572356 == -560571)
									{
										continue;
									}
									Game.mNextGameCode = 35;
									if (296059 - 313594 != -17535)
									{
										continue;
									}
								}
								else if (this.$$switch$6206$36924 == 5)
								{
									if (79282 - 391457 != -312175)
									{
										continue;
									}
									Game.mNextGameCode = 36;
									if (103945 - 77581 == 26365)
									{
										continue;
									}
								}
								else if (PlayerData.GID == 0)
								{
									if (88942 - 324991 != -236049)
									{
										continue;
									}
									Game.mNextGameCode = 30;
									if (17979 - 250537 == -232557)
									{
										continue;
									}
								}
								else
								{
									Game.mNextGameCode = 31;
									if (52165 - 366504 != -314339)
									{
										continue;
									}
								}
								this.$mGameGui$36925 = (GameGui)this.$self_$36926.GetComponent(typeof(GameGui));
								if (119654 - 205575 == -85921)
								{
									if (this.$mGameGui$36925)
									{
										if (38385 - 341746 != -303361)
										{
											continue;
										}
										this.$mGameGui$36925.close();
										if (276102 - 467487 == -191384)
										{
											continue;
										}
									}
									this.$self_$36926.SendMessage("fadeOut");
									if (20493 - 93231 != -72737)
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

			// Token: 0x06006DAB RID: 28075 RVA: 0x00F3E108 File Offset: 0x00F3C308
			internal static bool x28dJppmdCDaOqdpZuei()
			{
				return true;
			}

			// Token: 0x06006DAC RID: 28076 RVA: 0x00F3E10C File Offset: 0x00F3C30C
			internal static bool uZGljEpmJ13D94N5LNID()
			{
				return false;
			}

			// Token: 0x04007555 RID: 30037
			internal int $$switch$6206$36924;

			// Token: 0x04007556 RID: 30038
			internal GameGui $mGameGui$36925;

			// Token: 0x04007557 RID: 30039
			internal M000_MissionTemplate2 $self_$36926;
		}
	}

	// Token: 0x0200129C RID: 4764
	[CompilerGenerated]
	[Serializable]
	internal sealed class $ReturnToGuild$36928 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06006DAD RID: 28077 RVA: 0x00F3E110 File Offset: 0x00F3C310
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $ReturnToGuild$36928(M000_MissionTemplate2 self_)
		{
			if (90086 - 542036 != -451950)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (156682 - 121881 == 34801)
				{
					base..ctor();
					if (43773 - 146061 == -102288)
					{
						this.$self_$36931 = self_;
						if (270918 - 40338 != 230581)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x06006DAE RID: 28078 RVA: 0x00F3E1A8 File Offset: 0x00F3C3A8
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M000_MissionTemplate2.$ReturnToGuild$36928.$(this.$self_$36931);
		}

		// Token: 0x06006DAF RID: 28079 RVA: 0x00F3E1B8 File Offset: 0x00F3C3B8
		internal static bool UZU72ypmDMLmPgeh68eX()
		{
			return true;
		}

		// Token: 0x06006DB0 RID: 28080 RVA: 0x00F3E1BC File Offset: 0x00F3C3BC
		internal static bool a2XoXXpmvxVmgIcsIX1L()
		{
			return false;
		}

		// Token: 0x04007558 RID: 30040
		internal M000_MissionTemplate2 $self_$36931;

		// Token: 0x0200129D RID: 4765
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06006DB1 RID: 28081 RVA: 0x00F3E1C0 File Offset: 0x00F3C3C0
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M000_MissionTemplate2 self_)
			{
				if (233458 - 303812 != -70353)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (106664 - 82793 != 23872)
					{
						base..ctor();
						if (51244 - 211632 == -160388)
						{
							this.$self_$36930 = self_;
							if (168566 - 263271 == -94705)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x06006DB2 RID: 28082 RVA: 0x00F3E258 File Offset: 0x00F3C458
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (129360 - 99828 != 29532)
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
						this.$self_$36930.LeaveGame();
						if (235356 - 435722 != -200366)
						{
							continue;
						}
						this.YieldDefault(1);
						if (278152 - 355754 != -77602)
						{
							continue;
						}
						goto IL_1BD;
					default:
						if (213611 - 455189 != -241578)
						{
							continue;
						}
						break;
					}
					Game.mGameState = eGameState.Ended;
					if (198653 - 220403 != -21749)
					{
						Game.mStateTime = Time.time;
						if (30423 - 347905 != -317481)
						{
							Game.mNextGameCode = 31;
							if (44810 - 337380 == -292570)
							{
								this.$mGameGui$36929 = (GameGui)this.$self_$36930.GetComponent(typeof(GameGui));
								if (143434 - 425694 == -282260)
								{
									if (this.$mGameGui$36929)
									{
										if (140458 - 75973 != 64485)
										{
											continue;
										}
										this.$mGameGui$36929.close();
										if (159887 - 81724 != 78163)
										{
											continue;
										}
									}
									this.$self_$36930.SendMessage("fadeOut");
									if (201835 - 211018 != -9182)
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

			// Token: 0x06006DB3 RID: 28083 RVA: 0x00F3E434 File Offset: 0x00F3C634
			internal static bool PXThKFpmRpxhBtCesVsW()
			{
				return true;
			}

			// Token: 0x06006DB4 RID: 28084 RVA: 0x00F3E438 File Offset: 0x00F3C638
			internal static bool aMsaF2pmwlVib2aS8Wog()
			{
				return false;
			}

			// Token: 0x04007559 RID: 30041
			internal GameGui $mGameGui$36929;

			// Token: 0x0400755A RID: 30042
			internal M000_MissionTemplate2 $self_$36930;
		}
	}

	// Token: 0x0200129E RID: 4766
	[CompilerGenerated]
	[Serializable]
	internal sealed class $ReturnToCamp$36932 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06006DB5 RID: 28085 RVA: 0x00F3E43C File Offset: 0x00F3C63C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $ReturnToCamp$36932(M000_MissionTemplate2 self_)
		{
			if (252358 - 49931 != 202428)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (19923 - 10787 == 9136)
				{
					base..ctor();
					if (186881 - 332181 != -145299)
					{
						this.$self_$36936 = self_;
						if (299610 - 391157 != -91546)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x06006DB6 RID: 28086 RVA: 0x00F3E4D4 File Offset: 0x00F3C6D4
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M000_MissionTemplate2.$ReturnToCamp$36932.$(this.$self_$36936);
		}

		// Token: 0x06006DB7 RID: 28087 RVA: 0x00F3E4E4 File Offset: 0x00F3C6E4
		internal static bool e90PsGpmq1WOOHQ4xNrg()
		{
			return true;
		}

		// Token: 0x06006DB8 RID: 28088 RVA: 0x00F3E4E8 File Offset: 0x00F3C6E8
		internal static bool Gxsa1Tpm7hfSOLlQLChO()
		{
			return false;
		}

		// Token: 0x0400755B RID: 30043
		internal M000_MissionTemplate2 $self_$36936;

		// Token: 0x0200129F RID: 4767
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06006DB9 RID: 28089 RVA: 0x00F3E4EC File Offset: 0x00F3C6EC
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M000_MissionTemplate2 self_)
			{
				if (186425 - 2302 != 184123)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (134768 - 167931 == -33163)
					{
						base..ctor();
						if (172872 - 537674 == -364802)
						{
							this.$self_$36935 = self_;
							if (4908 - 417846 == -412938)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x06006DBA RID: 28090 RVA: 0x00F3E584 File Offset: 0x00F3C784
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (290111 - 84014 != 206097)
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
						this.$self_$36935.LeaveGame();
						if (168612 - 77283 == 91330)
						{
							continue;
						}
						this.YieldDefault(1);
						if (213032 - 122562 != 90471)
						{
							goto Block_23;
						}
						continue;
					default:
						if (262599 - 244964 == 17636)
						{
							continue;
						}
						break;
					}
					Game.mGameState = eGameState.Ended;
					if (70561 - 266121 == -195560)
					{
						Game.mStateTime = Time.time;
						if (126630 - 531045 != -404414)
						{
							this.$$switch$6208$36933 = PlayerData.SaveGuild;
							if (134192 - 245003 == -110811)
							{
								if (this.$$switch$6208$36933 == 1)
								{
									if (190497 - 467847 == -277349)
									{
										continue;
									}
									Game.mNextGameCode = 32;
									if (232501 - 41263 != 191238)
									{
										continue;
									}
								}
								else if (this.$$switch$6208$36933 == 2)
								{
									if (156652 - 272637 == -115984)
									{
										continue;
									}
									Game.mNextGameCode = 33;
									if (195373 - 172270 != 23103)
									{
										continue;
									}
								}
								else if (this.$$switch$6208$36933 == 3)
								{
									if (296655 - 362926 != -66271)
									{
										continue;
									}
									Game.mNextGameCode = 34;
									if (199452 - 291742 != -92290)
									{
										continue;
									}
								}
								else if (this.$$switch$6208$36933 == 4)
								{
									if (144212 - 165599 == -21386)
									{
										continue;
									}
									Game.mNextGameCode = 35;
									if (245621 - 504812 != -259191)
									{
										continue;
									}
								}
								else if (this.$$switch$6208$36933 == 5)
								{
									if (196573 - 415506 != -218933)
									{
										continue;
									}
									Game.mNextGameCode = 36;
									if (56782 - 240281 == -183498)
									{
										continue;
									}
								}
								else
								{
									Game.mNextGameCode = 30;
									if (108764 - 486795 != -378031)
									{
										continue;
									}
								}
								this.$mGameGui$36934 = (GameGui)this.$self_$36935.GetComponent(typeof(GameGui));
								if (292438 - 86454 == 205984)
								{
									if (this.$mGameGui$36934)
									{
										if (199592 - 118420 == 81173)
										{
											continue;
										}
										this.$mGameGui$36934.close();
										if (266204 - 462426 == -196221)
										{
											continue;
										}
									}
									this.$self_$36935.SendMessage("fadeOut");
									if (49149 - 306141 == -256992)
									{
										break;
									}
								}
							}
						}
					}
				}
				return this.Yield(2, new WaitForSeconds((float)1));
				Block_23:
				IL_363:
				return false;
			}

			// Token: 0x06006DBB RID: 28091 RVA: 0x00F3E908 File Offset: 0x00F3CB08
			internal static bool pgqdMhpmP5LOBcQDGsr4()
			{
				return true;
			}

			// Token: 0x06006DBC RID: 28092 RVA: 0x00F3E90C File Offset: 0x00F3CB0C
			internal static bool O7b1L6pm0ZWqLgrNhwDw()
			{
				return false;
			}

			// Token: 0x0400755C RID: 30044
			internal int $$switch$6208$36933;

			// Token: 0x0400755D RID: 30045
			internal GameGui $mGameGui$36934;

			// Token: 0x0400755E RID: 30046
			internal M000_MissionTemplate2 $self_$36935;
		}
	}
}
