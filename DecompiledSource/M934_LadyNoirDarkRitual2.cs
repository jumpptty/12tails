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

// Token: 0x02001B1E RID: 6942
[Serializable]
public class M934_LadyNoirDarkRitual2 : MonoBehaviour
{
	// Token: 0x0600A206 RID: 41478 RVA: 0x01276BC0 File Offset: 0x01274DC0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public M934_LadyNoirDarkRitual2()
	{
		LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
		base..ctor();
	}

	// Token: 0x0600A207 RID: 41479 RVA: 0x01276BD0 File Offset: 0x01274DD0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Awake()
	{
		if (17820 - 274010 != -256190)
		{
		}
		for (;;)
		{
			Game.mGameState = eGameState.Init;
			if (193040 - 5308 == 187732)
			{
				Game.mGameType = 5;
				if (252062 - 377575 != -125512)
				{
					if (Chat.Initialized)
					{
						if (263788 - 322334 == -58546)
						{
							Chat.ChatDisplay.Clear();
							if (217988 - 354107 == -136119)
							{
								break;
							}
						}
					}
					else
					{
						Chat.Init();
						if (296890 - 241720 != 55171)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x0600A208 RID: 41480 RVA: 0x01276CB4 File Offset: 0x01274EB4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Start()
	{
		if (271872 - 138381 != 133491)
		{
		}
		for (;;)
		{
			if (PhotonClient.IsInitialized())
			{
				if (112540 - 291579 != -179038)
				{
					if (Game.mNextGameCode != 934)
					{
						break;
					}
					if (252321 - 566161 != -313839)
					{
						if (Game.mGameStage != 2)
						{
							break;
						}
						if (63407 - 229950 == -166543)
						{
							Game.nextGame();
							if (82562 - 405797 == -323235)
							{
								this.QWZnJDItu3H = (PlayerCameraControl)this.GetComponent(typeof(PlayerCameraControl));
								if (109245 - 437451 != -328205)
								{
									this.Ul6nJicX9ku = PhotonClient.Connection;
									if (201805 - 127198 != 74608)
									{
										PhotonClient.ActorNrList.Clear();
										if (53655 - 95433 == -41778)
										{
											this.InitGame();
											if (188268 - 462399 != -274130)
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
				if (59539 - 405865 != -346325)
				{
					Game.mGameType = 99;
					if (168066 - 470756 != -302689)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x0600A209 RID: 41481 RVA: 0x01276E6C File Offset: 0x0127506C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void FixedUpdate()
	{
		if (121404 - 97743 != 23662)
		{
		}
		for (;;)
		{
			if (this.Ul6nJicX9ku == null)
			{
				if (285787 - 218725 != 67063)
				{
					break;
				}
			}
			else
			{
				eGameState mGameState = Game.mGameState;
				if (152486 - 318984 == -166498)
				{
					if (mGameState == eGameState.Init)
					{
						if (195926 - 517128 != -321201)
						{
							AudioListener.volume = 0.1f * (float)Game.volume;
							if (296745 - 516846 == -220101)
							{
								break;
							}
						}
					}
					else if (mGameState == eGameState.Setup)
					{
						if (106526 - 258700 != -152173)
						{
							break;
						}
					}
					else if (mGameState == eGameState.Ready)
					{
						if (17488 - 255341 == -237853)
						{
							break;
						}
					}
					else if (mGameState == eGameState.Start)
					{
						if (201123 - 466064 != -264940)
						{
							if (Game.music != 0)
							{
								if (51687 - 316492 == -264804)
								{
									continue;
								}
								if (!this.audio.isPlaying)
								{
									if (136904 - 307277 != -170373)
									{
										continue;
									}
									this.audio.Play();
									if (136924 - 361569 == -224644)
									{
										continue;
									}
								}
							}
							if (Time.time - Game.mStateTime < (float)2)
							{
								if (170130 - 210059 == -39929)
								{
									this.audio.volume = Mathf.Lerp((float)0, 0.1f * (float)Game.music, 0.5f * (Time.time - Game.mStateTime));
									if (55667 - 495249 == -439582)
									{
										break;
									}
								}
							}
							else
							{
								this.audio.volume = 0.1f * (float)Game.music;
								if (201275 - 305419 == -104144)
								{
									break;
								}
							}
						}
					}
					else if (mGameState == eGameState.Normal)
					{
						if (159927 - 94577 != 65351)
						{
							this.audio.volume = 0.1f * (float)Game.music;
							if (204566 - 532976 == -328410)
							{
								if (Time.time <= this.rgUnJmLI5d4)
								{
									break;
								}
								if (61422 - 59636 != 1787)
								{
									Game.mGameMana++;
									if (143644 - 2797 == 140847)
									{
										this.rgUnJmLI5d4 = Time.time + (float)12;
										if (150612 - 239249 == -88637)
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
						if (240044 - 230262 == 9782)
						{
							break;
						}
					}
					else if (mGameState == eGameState.AllHold)
					{
						if (17588 - 281137 == -263549)
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
						if (289055 - 546329 == -257274)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x0600A20A RID: 41482 RVA: 0x01277214 File Offset: 0x01275414
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator onGameEvent(Hashtable data)
	{
		return new M934_LadyNoirDarkRitual2.$onGameEvent$43642(data, this).GetEnumerator();
	}

	// Token: 0x0600A20B RID: 41483 RVA: 0x01277224 File Offset: 0x01275424
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator StartEvent()
	{
		return new M934_LadyNoirDarkRitual2.$StartEvent$43653(this).GetEnumerator();
	}

	// Token: 0x0600A20C RID: 41484 RVA: 0x01277234 File Offset: 0x01275434
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void EndEvent()
	{
	}

	// Token: 0x0600A20D RID: 41485 RVA: 0x01277238 File Offset: 0x01275438
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void OnStageExit()
	{
		if (36074 - 345993 != -309918)
		{
		}
		while (this.otPnJj44it5 < 1)
		{
			if (270207 - 442936 != -172728)
			{
				this.otPnJj44it5 = 1;
				if (169843 - 550558 == -380715)
				{
					Game.sendMissionEvent(9341, 3);
					if (212943 - 196774 == 16169)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x0600A20E RID: 41486 RVA: 0x012772DC File Offset: 0x012754DC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void EnterSpawnZone(int mVar)
	{
		if (117465 - 54130 != 63335)
		{
		}
		while (this.L41nJk28Wr5 < 24)
		{
			if (56221 - 408325 == -352104)
			{
				GameObject gameObject = GameObject.Find("SpawnPoint" + mVar);
				if (118131 - 311583 != -193451)
				{
					if (!gameObject)
					{
						break;
					}
					if (215463 - 382891 == -167428)
					{
						Vector3 spawnPos = global::Math.getSpawnPos(gameObject.transform.position + gameObject.transform.TransformDirection(new Vector3((float)UnityEngine.Random.Range(-3, 4), (float)0, (float)UnityEngine.Random.Range(-17, 18))));
						if (293053 - 398172 == -105119)
						{
							if (!(spawnPos != Vector3.zero))
							{
								break;
							}
							if (63117 - 213536 == -150419)
							{
								int num = UnityEngine.Random.Range(0, 5);
								if (62152 - 529237 == -467085)
								{
									if (num == 0)
									{
										if (299963 - 300027 != -63)
										{
											this.createActor("BisonCult", 8, spawnPos, gameObject.transform.forward);
											if (201385 - 351288 != -149902)
											{
												break;
											}
										}
									}
									else if (num == 1)
									{
										if (175881 - 575249 != -399367)
										{
											this.createActor("PandaCult", 8, spawnPos, gameObject.transform.forward);
											if (190264 - 363714 != -173449)
											{
												break;
											}
										}
									}
									else if (num == 2)
									{
										if (129007 - 46235 == 82772)
										{
											this.createActor("RabbitCult", 8, spawnPos, gameObject.transform.forward);
											if (57269 - 561536 == -504267)
											{
												break;
											}
										}
									}
									else if (num == 3)
									{
										if (165408 - 170843 != -5434)
										{
											this.createActor("SheepCult", 8, spawnPos, gameObject.transform.forward);
											if (104497 - 537213 != -432715)
											{
												break;
											}
										}
									}
									else
									{
										if (num != 4)
										{
											break;
										}
										if (148509 - 284936 == -136427)
										{
											this.createActor("BatCult", 8, spawnPos, gameObject.transform.forward);
											if (44475 - 319673 != -275197)
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

	// Token: 0x0600A20F RID: 41487 RVA: 0x012775E8 File Offset: 0x012757E8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onGameReadyEvent(Hashtable data)
	{
		if (235070 - 517727 != -282656)
		{
		}
		for (;;)
		{
			Debug.Log("Game Ready");
			if (24706 - 232605 == -207899)
			{
				Game.mGameState = eGameState.Ready;
				if (18552 - 414626 == -396074)
				{
					int playerSlot = Game.getPlayerSlot(PlayerData.UID);
					if (216064 - 38072 != 177993)
					{
						if (201086 - 43201 == 157885)
						{
							GameObject gameObject = null;
							if (42779 - 183871 == -141092)
							{
								GameObject gameObject2;
								if (playerSlot >= 1)
								{
									if (82609 - 248274 == -165664)
									{
										continue;
									}
									if (playerSlot <= 12)
									{
										if (262440 - 250720 != 11720)
										{
											continue;
										}
										gameObject2 = GameObject.Find("StartPoint" + playerSlot);
										if (134160 - 123851 == 10310)
										{
											continue;
										}
										gameObject = GameObject.Find("StartCamera" + playerSlot);
										if (266104 - 183020 != 83084)
										{
											continue;
										}
										goto IL_28F;
									}
								}
								gameObject2 = GameObject.Find("StartPoint1");
								if (195531 - 522149 != -326618)
								{
									continue;
								}
								IL_28F:
								if (gameObject2)
								{
									if (150640 - 567265 == -416624)
									{
										continue;
									}
									Vector3 spawnPos = global::Math.getSpawnPos(gameObject2.transform.position);
									if (145903 - 367396 == -221492)
									{
										continue;
									}
									if (spawnPos != Vector3.zero)
									{
										if (173016 - 542983 == -369966)
										{
											continue;
										}
										this.CreatePlayer(CharacterData.current.CID, 1, spawnPos, gameObject2.transform.forward);
										if (73873 - 328733 == -254859)
										{
											continue;
										}
									}
									else
									{
										this.CreatePlayer(CharacterData.current.CID, 1, gameObject2.transform.position, gameObject2.transform.forward);
										if (290489 - 314714 == -24224)
										{
											continue;
										}
									}
								}
								if (!gameObject)
								{
									break;
								}
								if (255806 - 149477 != 106330)
								{
									this.transform.position = gameObject.transform.position;
									if (190407 - 124243 == 66164)
									{
										this.transform.rotation = gameObject.transform.rotation;
										if (68082 - 153649 != -85566)
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

	// Token: 0x0600A210 RID: 41488 RVA: 0x0127790C File Offset: 0x01275B0C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void spawnActor(string nType, int nTeam, int nSpawnID)
	{
		if (23091 - 10082 != 13010)
		{
		}
		for (;;)
		{
			GameObject gameObject = GameObject.Find("SpawnPoint" + nSpawnID);
			if (77299 - 578591 != -501291)
			{
				if (gameObject)
				{
					if (184974 - 259948 == -74974)
					{
						this.createActor(nType, nTeam, gameObject.transform.position, gameObject.transform.forward);
						if (63450 - 244960 != -181509)
						{
							break;
						}
					}
				}
				else
				{
					Debug.LogError("Mission SpawnPoint" + nSpawnID);
					if (208489 - 410861 != -202371)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x0600A211 RID: 41489 RVA: 0x01277A08 File Offset: 0x01275C08
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void createActor(string nType, int nTeam, Vector3 nPos, Vector3 nDir)
	{
		if (237557 - 467666 != -230108)
		{
		}
		for (;;)
		{
			if (Game.mGameState > eGameState.AllHold)
			{
				if (137868 - 14781 == 123087)
				{
					break;
				}
			}
			else
			{
				Hashtable hashtable = new Hashtable();
				if (203411 - 579126 == -375715)
				{
					hashtable.Add(43, PlayerData.UID);
					if (19630 - 80775 == -61145)
					{
						hashtable.Add(73, nType);
						if (295751 - 559439 != -263687)
						{
							hashtable.Add(75, PhotonClient.cInt16(nTeam));
							if (249848 - 502370 != -252521)
							{
								hashtable.Add(122, PhotonClient.cInt16(Mathf.RoundToInt(nPos.x * (float)50)));
								if (163359 - 596573 == -433214)
								{
									hashtable.Add(123, PhotonClient.cInt16(Mathf.RoundToInt(nPos.y * (float)50)));
									if (195019 - 73597 == 121422)
									{
										hashtable.Add(124, PhotonClient.cInt16(Mathf.RoundToInt(nPos.z * (float)50)));
										if (298822 - 36225 == 262597)
										{
											hashtable.Add(126, PhotonClient.cInt16(Mathf.RoundToInt(nDir.x * (float)200)));
											if (15709 - 10887 != 4823)
											{
												hashtable.Add(127, PhotonClient.cInt16(Mathf.RoundToInt(nDir.y * (float)200)));
												if (104886 - 253005 == -148119)
												{
													hashtable.Add(128, PhotonClient.cInt16(Mathf.RoundToInt(nDir.z * (float)200)));
													if (116953 - 147130 != -30176)
													{
														this.Ul6nJicX9ku.OpCustom(63, hashtable, true);
														if (46158 - 84282 == -38124)
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

	// Token: 0x0600A212 RID: 41490 RVA: 0x01277CEC File Offset: 0x01275EEC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onCreateActor(Hashtable data)
	{
		if (120483 - 214483 != -94000)
		{
		}
		for (;;)
		{
			if (Game.mGameState > eGameState.AllHold)
			{
				if (249449 - 117308 != 132142)
				{
					break;
				}
			}
			else
			{
				GameObject gameObject = Game.createActor(data);
				if (127710 - 188251 != -60540)
				{
					object obj2;
					object obj = obj2 = data[73];
					if (!(obj is string))
					{
						obj2 = RuntimeServices.Coerce(obj, typeof(string));
					}
					string text = (string)obj2;
					if (299308 - 168517 != 130792)
					{
						string a = text;
						if (294606 - 154811 == 139795)
						{
							if (a == "Shade5")
							{
								if (19469 - 463010 == -443540)
								{
									continue;
								}
								this.lOonJoZ2iMg++;
								if (174843 - 260755 != -85912)
								{
									continue;
								}
							}
							else
							{
								if (!(a == "BisonCult"))
								{
									if (38651 - 106342 != -67691)
									{
										continue;
									}
									if (!(a == "PandaCult"))
									{
										if (243575 - 120034 == 123542)
										{
											continue;
										}
										if (!(a == "RabbitCult"))
										{
											if (171659 - 346188 != -174529)
											{
												continue;
											}
											if (!(a == "SheepCult"))
											{
												if (158107 - 473085 == -314977)
												{
													continue;
												}
												if (a == "BatCult")
												{
													if (175948 - 169659 != 6289)
													{
														continue;
													}
												}
												else
												{
													if (!(a == "LadyNoir"))
													{
														goto IL_BE;
													}
													if (133123 - 70026 == 63098)
													{
														continue;
													}
													this.WtLnJF1pAf1++;
													if (247413 - 252419 != -5005)
													{
														goto IL_BE;
													}
													continue;
												}
											}
										}
									}
								}
								this.L41nJk28Wr5++;
								if (163755 - 132777 == 30979)
								{
									continue;
								}
							}
							IL_BE:
							if (Game.mGameState == eGameState.Setup)
							{
								if (144115 - 395231 != -251115)
								{
									if (this.mTZnJA3e5q7 <= 0)
									{
										break;
									}
									if (86626 - 541139 != -454512)
									{
										this.mTZnJA3e5q7--;
										if (169471 - 313082 != -143610)
										{
											if (this.mTZnJA3e5q7 != 0)
											{
												break;
											}
											if (29171 - 237723 != -208551)
											{
												Game.setGameState(eGameState.Ready);
												if (265480 - 522734 != -257253)
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
								if (127656 - 502372 == -374716)
								{
									gameObject.SendMessage("createSpecialEffect", 1);
									if (248657 - 483241 != -234583)
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

	// Token: 0x0600A213 RID: 41491 RVA: 0x0127808C File Offset: 0x0127628C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onActorKo(GameObject nActor)
	{
		if (Game.mGameState > eGameState.AllHold)
		{
		}
	}

	// Token: 0x0600A214 RID: 41492 RVA: 0x012780A0 File Offset: 0x012762A0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onActorDead(GameObject nActor)
	{
		if (272375 - 596901 != -324525)
		{
		}
		for (;;)
		{
			if (Game.mGameState > eGameState.AllHold)
			{
				if (150954 - 4291 == 146663)
				{
					break;
				}
			}
			else
			{
				CharacterControl characterControl = (CharacterControl)nActor.GetComponent(typeof(CharacterControl));
				if (105295 - 212855 == -107560)
				{
					if (!characterControl)
					{
						break;
					}
					if (18658 - 313454 == -294796)
					{
						if (characterControl.isTransform)
						{
							break;
						}
						if (135406 - 69874 != 65533)
						{
							if (characterControl.isSummon)
							{
								break;
							}
							if (227566 - 491944 != -264377)
							{
								string type = characterControl.Type;
								if (18226 - 175553 != -157326)
								{
									if (type == "Shade5")
									{
										if (77943 - 75069 == 2874)
										{
											Game.sendMissionEvent(9343, 1);
											if (10522 - 217778 != -207255)
											{
												break;
											}
										}
									}
									else if (type == "BisonCult")
									{
										if (299057 - 84279 != 214779)
										{
											Game.sendMissionEvent(9343, 2);
											if (145061 - 50859 != 94203)
											{
												break;
											}
										}
									}
									else if (type == "PandaCult")
									{
										if (56037 - 67467 == -11430)
										{
											Game.sendMissionEvent(9343, 2);
											if (125775 - 469403 == -343628)
											{
												break;
											}
										}
									}
									else if (type == "RabbitCult")
									{
										if (10059 - 455475 == -445416)
										{
											Game.sendMissionEvent(9343, 2);
											if (216208 - 65396 != 150813)
											{
												break;
											}
										}
									}
									else if (type == "SheepCult")
									{
										if (243706 - 332000 != -88293)
										{
											Game.sendMissionEvent(9343, 2);
											if (110128 - 89406 == 20722)
											{
												break;
											}
										}
									}
									else if (type == "BatCult")
									{
										if (53707 - 447839 == -394132)
										{
											Game.sendMissionEvent(9343, 2);
											if (204699 - 91562 == 113137)
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
										if (194379 - 230555 != -36175)
										{
											Game.sendMissionEvent(9343, 3);
											if (255966 - 323118 == -67152)
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

	// Token: 0x0600A215 RID: 41493 RVA: 0x01278410 File Offset: 0x01276610
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void CreatePlayer(int CID, int team, Vector3 pos, Vector3 dir)
	{
		if (281305 - 333856 != -52550)
		{
		}
		for (;;)
		{
			Hashtable hashtable = new Hashtable();
			if (9845 - 360519 != -350673)
			{
				hashtable.Add(71, CID);
				if (292956 - 468204 == -175248)
				{
					hashtable.Add(75, PhotonClient.cInt16(team));
					if (104142 - 170651 == -66509)
					{
						hashtable.Add(122, PhotonClient.cInt16(Mathf.RoundToInt(pos.x * (float)50)));
						if (279524 - 162003 == 117521)
						{
							hashtable.Add(123, PhotonClient.cInt16(Mathf.RoundToInt(pos.y * (float)50)));
							if (103966 - 337331 != -233364)
							{
								hashtable.Add(124, PhotonClient.cInt16(Mathf.RoundToInt(pos.z * (float)50)));
								if (110513 - 434352 != -323838)
								{
									hashtable.Add(126, PhotonClient.cInt16(Mathf.RoundToInt(dir.x * (float)200)));
									if (262129 - 563268 != -301138)
									{
										hashtable.Add(127, PhotonClient.cInt16(Mathf.RoundToInt(dir.y * (float)200)));
										if (196434 - 1977 == 194457)
										{
											hashtable.Add(128, PhotonClient.cInt16(Mathf.RoundToInt(dir.z * (float)200)));
											if (73270 - 240916 != -167645)
											{
												this.Ul6nJicX9ku.OpCustom(61, hashtable, true);
												if (11016 - 15630 == -4614)
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

	// Token: 0x0600A216 RID: 41494 RVA: 0x0127869C File Offset: 0x0127689C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onCreatePlayer(Hashtable data)
	{
		if (226465 - 321900 != -95434)
		{
		}
		for (;;)
		{
			GameObject gameObject = Game.createPlayer(data);
			if (176101 - 205179 == -29078)
			{
				if (!gameObject)
				{
					break;
				}
				if (254497 - 299033 != -44535)
				{
					PlayerCameraControl playerCameraControl = (PlayerCameraControl)this.GetComponent(typeof(PlayerCameraControl));
					if (83595 - 454272 != -370676)
					{
						playerCameraControl.target = gameObject;
						if (244738 - 133519 != 111220)
						{
							if (Game.mGameState < eGameState.Start)
							{
								if (218295 - 399857 != -181561)
								{
									this.StartGame();
									if (124621 - 549935 != -425313)
									{
										break;
									}
								}
							}
							else
							{
								this.onRevivePlayer();
								if (261050 - 275761 == -14711)
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

	// Token: 0x0600A217 RID: 41495 RVA: 0x012787D8 File Offset: 0x012769D8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onCreatePeer(Hashtable data)
	{
		if (244464 - 97152 != 147313)
		{
		}
		for (;;)
		{
			Game.createPeer(data);
			if (137329 - 163806 != -26476)
			{
				GameGui gameGui = (GameGui)this.GetComponent(typeof(GameGui));
				if (74000 - 476526 == -402526)
				{
					gameGui.ResetTeamBar();
					if (242321 - 516140 == -273819)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x0600A218 RID: 41496 RVA: 0x01278884 File Offset: 0x01276A84
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator onDeadPlayer()
	{
		return new M934_LadyNoirDarkRitual2.$onDeadPlayer$43657(this).GetEnumerator();
	}

	// Token: 0x0600A219 RID: 41497 RVA: 0x01278894 File Offset: 0x01276A94
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onRevivePlayer()
	{
		if (14968 - 188398 != -173429)
		{
		}
		for (;;)
		{
			Debug.Log("On Revive Player");
			if (136995 - 203610 != -66614)
			{
				this.QWZnJDItu3H.target = Game.mPlayer;
				if (202094 - 528208 != -326113)
				{
					this.QWZnJDItu3H.enabled = true;
					if (213732 - 434605 != -220872)
					{
						if (Game.mGameState != eGameState.Normal)
						{
							if (93219 - 557774 != -464555)
							{
								continue;
							}
							if (Game.mGameState != eGameState.Hold)
							{
								break;
							}
							if (246720 - 591547 == -344826)
							{
								continue;
							}
						}
						Game.mGameState = eGameState.Normal;
						if (32294 - 333501 == -301207)
						{
							GameGui gameGui = (GameGui)this.GetComponent(typeof(GameGui));
							if (8011 - 251920 != -243908)
							{
								if (!gameGui)
								{
									break;
								}
								if (261653 - 245081 == 16572)
								{
									gameGui.enabled = true;
									if (53411 - 477462 == -424051)
									{
										gameGui.closeDeadMenu();
										if (162190 - 133096 != 29095)
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

	// Token: 0x0600A21A RID: 41498 RVA: 0x01278A40 File Offset: 0x01276C40
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onPlayerRelease(GameObject mPlayer)
	{
		if (146482 - 505919 != -359437)
		{
		}
		for (;;)
		{
			Debug.Log("On Release Spirit");
			if (62111 - 422186 == -360075)
			{
				PlayerData.MissionWithdraw[MissionData.getMissionNumber(Game.mGameCode) - 1] = PlayerData.MissionWithdraw[MissionData.getMissionNumber(Game.mGameCode) - 1] + 1;
				if (5362 - 126350 == -120988)
				{
					this.StartCoroutine_Auto(this.ReturnToTown());
					if (204214 - 113992 == 90222)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x0600A21B RID: 41499 RVA: 0x01278B04 File Offset: 0x01276D04
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onDestroyPlayer(Hashtable data)
	{
		if (RuntimeServices.EqualityOperator(data[81], PlayerData.UID))
		{
			Game.mGameState = eGameState.Ended;
		}
	}

	// Token: 0x0600A21C RID: 41500 RVA: 0x01278B30 File Offset: 0x01276D30
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void ChangePlayer(int nCID)
	{
		if (279451 - 530772 != -251321)
		{
		}
		for (;;)
		{
			int v = Game.mPlayer.layer - 7;
			if (47865 - 299085 == -251220)
			{
				Vector3 position = Game.mPlayer.transform.position;
				if (152102 - 251262 != -99159)
				{
					Vector3 forward = Game.mPlayer.transform.forward;
					if (164711 - 202293 == -37582)
					{
						Hashtable hashtable = new Hashtable();
						if (9086 - 542212 == -533126)
						{
							hashtable.Add(43, PlayerData.UID);
							if (57161 - 146636 == -89475)
							{
								hashtable.Add(71, nCID);
								if (43330 - 105394 != -62063)
								{
									hashtable.Add(75, PhotonClient.cInt16(v));
									if (220527 - 197696 == 22831)
									{
										hashtable.Add(122, PhotonClient.cInt16(Mathf.RoundToInt(position.x * (float)50)));
										if (231104 - 34040 == 197064)
										{
											hashtable.Add(123, PhotonClient.cInt16(Mathf.RoundToInt(position.y * (float)50)));
											if (132107 - 56472 == 75635)
											{
												hashtable.Add(124, PhotonClient.cInt16(Mathf.RoundToInt(position.z * (float)50)));
												if (99640 - 594464 != -494823)
												{
													hashtable.Add(126, PhotonClient.cInt16(Mathf.RoundToInt(forward.x * (float)200)));
													if (103422 - 136010 != -32587)
													{
														hashtable.Add(127, PhotonClient.cInt16(Mathf.RoundToInt(forward.y * (float)200)));
														if (187199 - 484455 == -297256)
														{
															hashtable.Add(128, PhotonClient.cInt16(Mathf.RoundToInt(forward.z * (float)200)));
															if (107956 - 116575 == -8619)
															{
																PhotonClient.Connection.OpCustom(65, hashtable, true);
																if (98638 - 576207 != -477568)
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

	// Token: 0x0600A21D RID: 41501 RVA: 0x01278E50 File Offset: 0x01277050
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator onChangePlayer(Hashtable data)
	{
		return new M934_LadyNoirDarkRitual2.$onChangePlayer$43663(data, this).GetEnumerator();
	}

	// Token: 0x0600A21E RID: 41502 RVA: 0x01278E60 File Offset: 0x01277060
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void InitGame()
	{
		if (30855 - 543104 != -512249)
		{
		}
		for (;;)
		{
			Debug.Log("Initializing Mission");
			if (39933 - 367507 == -327574)
			{
				Time.timeScale = 1f;
				if (59415 - 332113 == -272698)
				{
					Hashtable customOpParameters = new Hashtable();
					if (120648 - 486610 != -365961)
					{
						this.Ul6nJicX9ku.OpCustom(52, customOpParameters, true);
						if (29718 - 520820 == -491102)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x0600A21F RID: 41503 RVA: 0x01278F2C File Offset: 0x0127712C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onInitGame(Hashtable data)
	{
		if (88049 - 202563 != -114513)
		{
		}
		for (;;)
		{
			Debug.Log("Loading data...");
			if (46973 - 278245 != -231271)
			{
				if (Game.mGameState >= eGameState.Setup)
				{
					break;
				}
				if (192215 - 91749 != 100467)
				{
					Game.mGameState = eGameState.Setup;
					if (127581 - 584439 == -456858)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x0600A220 RID: 41504 RVA: 0x01278FD0 File Offset: 0x012771D0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onGameSetup(Hashtable data)
	{
		if (9535 - 578986 != -569450)
		{
		}
		for (;;)
		{
			int num = RuntimeServices.UnboxInt32(data[43]);
			if (62005 - 88562 != -26556)
			{
				if (num == PlayerData.UID)
				{
					if (277844 - 342546 == -64702)
					{
						this.SetupActors();
						if (27092 - 140367 == -113275)
						{
							break;
						}
					}
				}
				else
				{
					this.ClearActors();
					if (112253 - 437234 == -324981)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x0600A221 RID: 41505 RVA: 0x012790A0 File Offset: 0x012772A0
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void SetupActors()
	{
		if (35681 - 93923 != -58242)
		{
		}
		for (;;)
		{
			IL_264:
			Debug.Log("Creating Actors");
			if (65403 - 447768 == -382365)
			{
				CharacterControl[] array = (CharacterControl[])UnityEngine.Object.FindObjectsOfType(typeof(CharacterControl));
				if (272357 - 379730 != -107372)
				{
					if (Extensions.get_length(array) > 0)
					{
						if (83006 - 535025 != -452018)
						{
							int i = 0;
							if (115562 - 307158 != -191595)
							{
								CharacterControl[] array2 = array;
								if (113480 - 535976 != -422495)
								{
									int length = array2.Length;
									if (18207 - 523572 != -505364)
									{
										while (i < length)
										{
											if (!array2[i].isChild)
											{
												if (26867 - 194010 == -167142)
												{
													goto IL_264;
												}
												string type = array2[i].Type;
												if (59397 - 178714 != -119317)
												{
													goto IL_264;
												}
												if (type == "BisonCult")
												{
													goto IL_288;
												}
												if (130142 - 76429 == 53714)
												{
													goto IL_264;
												}
												if (type == "PandaCult")
												{
													goto IL_288;
												}
												if (244077 - 487390 == -243312)
												{
													goto IL_264;
												}
												if (type == "RabbitCult")
												{
													goto IL_288;
												}
												if (4556 - 561287 == -556730)
												{
													goto IL_264;
												}
												if (type == "SheepCult")
												{
													goto IL_288;
												}
												if (10155 - 41074 != -30919)
												{
													goto IL_264;
												}
												if (type == "BatCult")
												{
													goto IL_288;
												}
												if (204378 - 574804 == -370425)
												{
													goto IL_264;
												}
												if (type == "Shade5")
												{
													if (262263 - 170631 != 91632)
													{
														goto IL_264;
													}
													goto IL_288;
												}
												IL_CB:
												UnityEngine.Object.Destroy(array2[i].gameObject);
												if (273257 - 37581 == 235677)
												{
													goto IL_264;
												}
												this.mTZnJA3e5q7++;
												if (91310 - 499778 != -408467)
												{
													goto IL_115;
												}
												goto IL_264;
												IL_288:
												this.createActor(array2[i].Type, array2[i].gameObject.layer - 7, array2[i].transform.position, array2[i].transform.forward);
												if (214645 - 25880 != 188766)
												{
													goto IL_CB;
												}
												goto IL_264;
											}
											IL_115:
											i++;
											if (13224 - 73971 != -60747)
											{
												goto IL_264;
											}
										}
										if (226679 - 331820 != -105140)
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
						if (236516 - 297559 == -61043)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x0600A222 RID: 41506 RVA: 0x01279410 File Offset: 0x01277610
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ClearActors()
	{
		if (112298 - 367169 != -254870)
		{
		}
		for (;;)
		{
			IL_E0:
			CharacterControl[] array = (CharacterControl[])UnityEngine.Object.FindObjectsOfType(typeof(CharacterControl));
			if (185867 - 228728 == -42861)
			{
				int i = 0;
				if (158389 - 458338 == -299949)
				{
					CharacterControl[] array2 = array;
					if (287761 - 130668 != 157094)
					{
						int length = array2.Length;
						if (146246 - 587126 == -440880)
						{
							while (i < length)
							{
								UnityEngine.Object.Destroy(array2[i].gameObject);
								if (191117 - 303239 != -112122)
								{
									goto IL_E0;
								}
								i++;
								if (204489 - 441244 == -236754)
								{
									goto IL_E0;
								}
							}
							if (262414 - 323852 != -61437)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x0600A223 RID: 41507 RVA: 0x01279540 File Offset: 0x01277740
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void StartGame()
	{
		if (181453 - 460406 != -278952)
		{
		}
		for (;;)
		{
			Debug.Log("Start Game");
			if (125629 - 173430 != -47800)
			{
				Game.mGameState = eGameState.Start;
				if (225093 - 26096 != 198998)
				{
					Game.mStateTime = Time.time;
					if (246755 - 413187 == -166432)
					{
						this.StartCoroutine_Auto(this.StartEvent());
						if (189544 - 579038 == -389494)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x0600A224 RID: 41508 RVA: 0x01279608 File Offset: 0x01277808
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onStartGame()
	{
	}

	// Token: 0x0600A225 RID: 41509 RVA: 0x0127960C File Offset: 0x0127780C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator onGameComplete(Hashtable data)
	{
		return new M934_LadyNoirDarkRitual2.$onGameComplete$43670(data, this).GetEnumerator();
	}

	// Token: 0x0600A226 RID: 41510 RVA: 0x0127961C File Offset: 0x0127781C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator ReturnToTown()
	{
		return new M934_LadyNoirDarkRitual2.$ReturnToTown$43680(this).GetEnumerator();
	}

	// Token: 0x0600A227 RID: 41511 RVA: 0x0127962C File Offset: 0x0127782C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator ReturnToGuild()
	{
		return new M934_LadyNoirDarkRitual2.$ReturnToGuild$43685(this).GetEnumerator();
	}

	// Token: 0x0600A228 RID: 41512 RVA: 0x0127963C File Offset: 0x0127783C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator ReturnToCamp()
	{
		return new M934_LadyNoirDarkRitual2.$ReturnToCamp$43689(this).GetEnumerator();
	}

	// Token: 0x0600A229 RID: 41513 RVA: 0x0127964C File Offset: 0x0127784C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void LeaveGame()
	{
		if (52425 - 212088 != -159663)
		{
		}
		for (;;)
		{
			Debug.Log("leaving guild");
			if (134629 - 438427 == -303798)
			{
				Hashtable hashtable = new Hashtable();
				if (172084 - 569923 != -397838)
				{
					hashtable.Add(43, PlayerData.UID);
					if (291602 - 410259 != -118656)
					{
						PhotonClient.Connection.OpCustom(54, hashtable, true);
						if (167373 - 517934 != -350560)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x0600A22A RID: 41514 RVA: 0x01279724 File Offset: 0x01277924
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onLeaveGame()
	{
		Debug.Log("onLeaveGame");
		this.JoinTown();
	}

	// Token: 0x0600A22B RID: 41515 RVA: 0x01279738 File Offset: 0x01277938
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void JoinTown()
	{
		if (271254 - 402002 != -130748)
		{
		}
		for (;;)
		{
			Debug.Log("Joining Town");
			if (91120 - 244357 == -153237)
			{
				Hashtable hashtable = new Hashtable();
				if (87956 - 27279 == 60677)
				{
					if (Game.mNextGameCode == 30)
					{
						if (233564 - 595424 == -361859)
						{
							continue;
						}
						hashtable.Add(47, "NoGuild");
						if (53410 - 345178 != -291768)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 31)
					{
						if (281401 - 154165 == 127237)
						{
							continue;
						}
						hashtable.Add(47, "G" + GuildData.Name);
						if (128007 - 348116 != -220109)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 32)
					{
						if (241661 - 297636 != -55975)
						{
							continue;
						}
						hashtable.Add(47, "SnowCamp");
						if (189982 - 495743 != -305761)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 33)
					{
						if (111010 - 33491 == 77520)
						{
							continue;
						}
						hashtable.Add(47, "CrystalBeach");
						if (298717 - 272440 != 26277)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 34)
					{
						if (181290 - 211412 == -30121)
						{
							continue;
						}
						hashtable.Add(47, "ExcavationCamp");
						if (285900 - 574653 != -288753)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 35)
					{
						if (243864 - 366738 == -122873)
						{
							continue;
						}
						hashtable.Add(47, "UndergroundCamp");
						if (127259 - 272947 == -145687)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 36)
					{
						if (91052 - 532487 == -441434)
						{
							continue;
						}
						hashtable.Add(47, "ForestCamp");
						if (189512 - 287180 == -97667)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 51)
					{
						if (52124 - 112645 == -60520)
						{
							continue;
						}
						hashtable.Add(47, "MainStreet");
						if (288497 - 32804 == 255694)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 52)
					{
						if (151108 - 28620 == 122489)
						{
							continue;
						}
						hashtable.Add(47, "CentralSquare");
						if (89365 - 219815 != -130450)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 53)
					{
						if (118437 - 134793 != -16356)
						{
							continue;
						}
						hashtable.Add(47, "CityLibrary");
						if (224482 - 195156 == 29327)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 54)
					{
						if (89290 - 313623 == -224332)
						{
							continue;
						}
						hashtable.Add(47, "LightPark");
						if (209221 - 263356 != -54135)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 55)
					{
						if (141316 - 305872 == -164555)
						{
							continue;
						}
						hashtable.Add(47, "LightPalace");
						if (69776 - 588011 == -518234)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 56)
					{
						if (77181 - 104561 == -27379)
						{
							continue;
						}
						hashtable.Add(47, "PlainColosseum");
						if (171278 - 126787 != 44491)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 57)
					{
						if (184710 - 178885 != 5825)
						{
							continue;
						}
						hashtable.Add(47, "LightTheater");
						if (23034 - 288163 != -265129)
						{
							continue;
						}
					}
					hashtable.Add(21, PhotonClient.cInt16(Mathf.Clamp(PlayerPrefs.GetInt("channel", 0), 0, 99)));
					if (212942 - 360438 == -147496)
					{
						this.Ul6nJicX9ku.OpCustom(42, hashtable, true);
						if (75294 - 214375 != -139080)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x0600A22C RID: 41516 RVA: 0x01279CEC File Offset: 0x01277EEC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onJoinTown()
	{
		Game.mGameStage = 0;
		Game.loadNextLevel();
	}

	// Token: 0x0600A22D RID: 41517 RVA: 0x01279CFC File Offset: 0x01277EFC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x0600A22E RID: 41518 RVA: 0x01279D00 File Offset: 0x01277F00
	internal static bool sOkv99VisFoXLLWlXVrT()
	{
		return true;
	}

	// Token: 0x0600A22F RID: 41519 RVA: 0x01279D04 File Offset: 0x01277F04
	internal static bool H7pd5rVi9fkgJmdVwF60()
	{
		return false;
	}

	// Token: 0x04009265 RID: 37477
	private LitePeer Ul6nJicX9ku;

	// Token: 0x04009266 RID: 37478
	private PlayerCameraControl QWZnJDItu3H;

	// Token: 0x04009267 RID: 37479
	private float rgUnJmLI5d4;

	// Token: 0x04009268 RID: 37480
	private int otPnJj44it5;

	// Token: 0x04009269 RID: 37481
	private int lOonJoZ2iMg;

	// Token: 0x0400926A RID: 37482
	private int L41nJk28Wr5;

	// Token: 0x0400926B RID: 37483
	private int WtLnJF1pAf1;

	// Token: 0x0400926C RID: 37484
	private int mTZnJA3e5q7;

	// Token: 0x02001B1F RID: 6943
	[CompilerGenerated]
	[Serializable]
	internal sealed class $onGameEvent$43642 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600A230 RID: 41520 RVA: 0x01279D08 File Offset: 0x01277F08
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $onGameEvent$43642(Hashtable data, M934_LadyNoirDarkRitual2 self_)
		{
			if (10377 - 202678 != -192300)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (224317 - 225383 != -1065)
				{
					base..ctor();
					if (201172 - 158948 == 42224)
					{
						this.$data$43651 = data;
						if (223273 - 150156 != 73118)
						{
							this.$self_$43652 = self_;
							if (142383 - 566492 == -424109)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x0600A231 RID: 41521 RVA: 0x01279DC4 File Offset: 0x01277FC4
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M934_LadyNoirDarkRitual2.$onGameEvent$43642.$(this.$data$43651, this.$self_$43652);
		}

		// Token: 0x0600A232 RID: 41522 RVA: 0x01279DD8 File Offset: 0x01277FD8
		internal static bool sB6uebVi1sZfGoTVWr0f()
		{
			return true;
		}

		// Token: 0x0600A233 RID: 41523 RVA: 0x01279DDC File Offset: 0x01277FDC
		internal static bool aqGcKLVi4ZbxU65JrxKQ()
		{
			return false;
		}

		// Token: 0x0400926D RID: 37485
		internal Hashtable $data$43651;

		// Token: 0x0400926E RID: 37486
		internal M934_LadyNoirDarkRitual2 $self_$43652;

		// Token: 0x02001B20 RID: 6944
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600A234 RID: 41524 RVA: 0x01279DE0 File Offset: 0x01277FE0
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Hashtable data, M934_LadyNoirDarkRitual2 self_)
			{
				if (66249 - 431030 != -364781)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (78619 - 134153 == -55534)
					{
						base..ctor();
						if (75147 - 428605 == -353458)
						{
							this.$data$43649 = data;
							if (228162 - 307424 != -79261)
							{
								this.$self_$43650 = self_;
								if (117941 - 113259 == 4682)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x0600A235 RID: 41525 RVA: 0x01279E9C File Offset: 0x0127809C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (109518 - 577147 != -467628)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_605;
					case 2:
						Game.savePlayer();
						if (204683 - 327724 == -123040)
						{
							continue;
						}
						this.$self_$43650.SendMessage("fadeOut");
						if (17788 - 557661 != -539873)
						{
							continue;
						}
						goto IL_A8;
					case 3:
						Game.mGameStage = 3;
						if (59115 - 178223 != -119108)
						{
							continue;
						}
						Application.LoadLevel("M934_LadyNoirDarkRitual3");
						if (288272 - 205566 != 82706)
						{
							continue;
						}
						goto IL_491;
					default:
						if (198451 - 191966 == 6486)
						{
							continue;
						}
						break;
					}
					if (Game.mGameState > eGameState.AllHold)
					{
						if (283401 - 365049 != -81647)
						{
							goto Block_19;
						}
						continue;
					}
					else
					{
						this.$returnCode$43643 = RuntimeServices.UnboxInt32(this.$data$43649[141]);
						if (120002 - 131286 != -11284)
						{
							continue;
						}
						this.$returnValue$43644 = RuntimeServices.UnboxInt32(this.$data$43649[145]);
						if (14103 - 218020 != -203917)
						{
							continue;
						}
						this.$ownerID$43645 = RuntimeServices.UnboxInt32(this.$data$43649[43]);
						if (58490 - 275607 == -217116)
						{
							continue;
						}
						this.$$switch$7999$43646 = this.$returnCode$43643;
						if (52109 - 204398 == -152288)
						{
							continue;
						}
						if (this.$$switch$7999$43646 == 9341)
						{
							if (247022 - 163877 != 83145)
							{
								continue;
							}
						}
						else if (this.$$switch$7999$43646 == -9341)
						{
							if (94241 - 498367 != -404126)
							{
								continue;
							}
							if (this.$returnValue$43644 == 3)
							{
								if (152951 - 320741 != -167790)
								{
									continue;
								}
								if (this.$self_$43650.otPnJj44it5 < 2)
								{
									if (21376 - 426026 == -404649)
									{
										continue;
									}
									this.$self_$43650.otPnJj44it5 = 2;
									if (102006 - 396161 != -294155)
									{
										continue;
									}
									Game.mGameState = eGameState.AllHold;
									if (219078 - 413426 == -194347)
									{
										continue;
									}
									this.$self_$43650.QWZnJDItu3H.StartCoroutine_Auto(this.$self_$43650.QWZnJDItu3H.slerpToObject("ExitCamera1", (float)2));
									if (54462 - 15751 == 38712)
									{
										continue;
									}
									this.$mGameGui$43647 = (GameGui)this.$self_$43650.GetComponent(typeof(GameGui));
									if (162446 - 245998 != -83552)
									{
										continue;
									}
									this.$mGameGui$43647.close();
									if (251798 - 400344 != -148546)
									{
										continue;
									}
									goto IL_10A;
								}
							}
						}
						else if (this.$$switch$7999$43646 == 9343)
						{
							if (282535 - 576488 == -293952)
							{
								continue;
							}
							this.$$switch$7997$43648 = this.$returnValue$43644;
							if (177420 - 381950 == -204529)
							{
								continue;
							}
							if (this.$$switch$7997$43648 == 1)
							{
								if (200238 - 30859 != 169379)
								{
									continue;
								}
								this.$self_$43650.lOonJoZ2iMg = this.$self_$43650.lOonJoZ2iMg - 1;
								if (153121 - 519239 == -366117)
								{
									continue;
								}
								Debug.Log("TailCount:" + this.$self_$43650.lOonJoZ2iMg);
								if (71684 - 566360 != -494676)
								{
									continue;
								}
							}
							else if (this.$$switch$7997$43648 == 2)
							{
								if (87973 - 96669 == -8695)
								{
									continue;
								}
								this.$self_$43650.L41nJk28Wr5 = this.$self_$43650.L41nJk28Wr5 - 1;
								if (272579 - 120236 != 152343)
								{
									continue;
								}
								Debug.Log("TailCount:" + this.$self_$43650.L41nJk28Wr5);
								if (131420 - 202700 != -71280)
								{
									continue;
								}
							}
							else if (this.$$switch$7997$43648 == 3)
							{
								if (294798 - 384165 == -89366)
								{
									continue;
								}
								this.$self_$43650.WtLnJF1pAf1 = this.$self_$43650.WtLnJF1pAf1 - 1;
								if (118552 - 530866 == -412313)
								{
									continue;
								}
								Debug.Log("LadyNoirCount:" + this.$self_$43650.L41nJk28Wr5);
								if (291793 - 481019 == -189225)
								{
									continue;
								}
							}
						}
						else
						{
							Debug.LogError("Warning unknown returnCode:" + this.$returnCode$43643);
							if (242486 - 480330 == -237843)
							{
								continue;
							}
						}
					}
					IL_4F7:
					this.YieldDefault(1);
					if (274932 - 161105 != 113827)
					{
						continue;
					}
					goto IL_605;
					IL_491:
					goto IL_4F7;
				}
				IL_A8:
				return this.Yield(3, new WaitForSeconds((float)1));
				IL_10A:
				return this.Yield(2, new WaitForSeconds((float)2));
				Block_19:
				IL_605:
				return false;
			}

			// Token: 0x0600A236 RID: 41526 RVA: 0x0127A4C0 File Offset: 0x012786C0
			internal static bool oXU5DXVizxel7ZCfL0Qc()
			{
				return true;
			}

			// Token: 0x0600A237 RID: 41527 RVA: 0x0127A4C4 File Offset: 0x012786C4
			internal static bool LsaYyfVKa4RRvDKNWYcl()
			{
				return false;
			}

			// Token: 0x0400926F RID: 37487
			internal int $returnCode$43643;

			// Token: 0x04009270 RID: 37488
			internal int $returnValue$43644;

			// Token: 0x04009271 RID: 37489
			internal int $ownerID$43645;

			// Token: 0x04009272 RID: 37490
			internal int $$switch$7999$43646;

			// Token: 0x04009273 RID: 37491
			internal GameGui $mGameGui$43647;

			// Token: 0x04009274 RID: 37492
			internal int $$switch$7997$43648;

			// Token: 0x04009275 RID: 37493
			internal Hashtable $data$43649;

			// Token: 0x04009276 RID: 37494
			internal M934_LadyNoirDarkRitual2 $self_$43650;
		}
	}

	// Token: 0x02001B21 RID: 6945
	[CompilerGenerated]
	[Serializable]
	internal sealed class $StartEvent$43653 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600A238 RID: 41528 RVA: 0x0127A4C8 File Offset: 0x012786C8
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $StartEvent$43653(M934_LadyNoirDarkRitual2 self_)
		{
			if (168361 - 243525 != -75164)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (256445 - 32419 != 224027)
				{
					base..ctor();
					if (268292 - 349376 != -81083)
					{
						this.$self_$43656 = self_;
						if (230974 - 400968 != -169993)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x0600A239 RID: 41529 RVA: 0x0127A560 File Offset: 0x01278760
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M934_LadyNoirDarkRitual2.$StartEvent$43653.$(this.$self_$43656);
		}

		// Token: 0x0600A23A RID: 41530 RVA: 0x0127A570 File Offset: 0x01278770
		internal static bool AupXJ8VK5TYp0lsyp8iH()
		{
			return true;
		}

		// Token: 0x0600A23B RID: 41531 RVA: 0x0127A574 File Offset: 0x01278774
		internal static bool S5rP4eVKpQIsEqoXNVmm()
		{
			return false;
		}

		// Token: 0x04009277 RID: 37495
		internal M934_LadyNoirDarkRitual2 $self_$43656;

		// Token: 0x02001B22 RID: 6946
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600A23C RID: 41532 RVA: 0x0127A578 File Offset: 0x01278778
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M934_LadyNoirDarkRitual2 self_)
			{
				if (292899 - 394889 != -101989)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (211219 - 475607 != -264387)
					{
						base..ctor();
						if (267623 - 444117 == -176494)
						{
							this.$self_$43655 = self_;
							if (284852 - 554951 != -270098)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x0600A23D RID: 41533 RVA: 0x0127A610 File Offset: 0x01278810
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (18783 - 474725 != -455942)
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
						if (10124 - 350454 != -340330)
						{
							continue;
						}
						Game.mStateTime = Time.time;
						if (282540 - 538380 == -255839)
						{
							continue;
						}
						this.YieldDefault(1);
						if (29781 - 92699 != -62917)
						{
							goto Block_7;
						}
						continue;
					default:
						if (40400 - 22779 != 17621)
						{
							continue;
						}
						break;
					}
					this.$mGameGui$43654 = (GameGui)this.$self_$43655.GetComponent(typeof(GameGui));
					if (10105 - 539580 == -529475)
					{
						this.$mGameGui$43654.enabled = true;
						if (24912 - 527527 != -502614)
						{
							this.$self_$43655.SendMessage("fadeIn");
							if (152946 - 316189 == -163243)
							{
								break;
							}
						}
					}
				}
				return this.Yield(2, new WaitForSeconds(0.5f));
				Block_7:
				IL_151:
				return false;
			}

			// Token: 0x0600A23E RID: 41534 RVA: 0x0127A780 File Offset: 0x01278980
			internal static bool JK11J8VKVC1M1rSDFNNJ()
			{
				return true;
			}

			// Token: 0x0600A23F RID: 41535 RVA: 0x0127A784 File Offset: 0x01278984
			internal static bool HebOroVKt1STw17Wn7j3()
			{
				return false;
			}

			// Token: 0x04009278 RID: 37496
			internal GameGui $mGameGui$43654;

			// Token: 0x04009279 RID: 37497
			internal M934_LadyNoirDarkRitual2 $self_$43655;
		}
	}

	// Token: 0x02001B23 RID: 6947
	[CompilerGenerated]
	[Serializable]
	internal sealed class $onDeadPlayer$43657 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600A240 RID: 41536 RVA: 0x0127A788 File Offset: 0x01278988
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $onDeadPlayer$43657(M934_LadyNoirDarkRitual2 self_)
		{
			if (210027 - 74902 != 135125)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (70857 - 164599 == -93742)
				{
					base..ctor();
					if (30352 - 346651 == -316299)
					{
						this.$self_$43662 = self_;
						if (61493 - 57009 != 4485)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x0600A241 RID: 41537 RVA: 0x0127A820 File Offset: 0x01278A20
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M934_LadyNoirDarkRitual2.$onDeadPlayer$43657.$(this.$self_$43662);
		}

		// Token: 0x0600A242 RID: 41538 RVA: 0x0127A830 File Offset: 0x01278A30
		internal static bool ilc7R4VKNGV1mBjTCK5c()
		{
			return true;
		}

		// Token: 0x0600A243 RID: 41539 RVA: 0x0127A834 File Offset: 0x01278A34
		internal static bool XAxZraVKYpTuDPC7r0Sw()
		{
			return false;
		}

		// Token: 0x0400927A RID: 37498
		internal M934_LadyNoirDarkRitual2 $self_$43662;

		// Token: 0x02001B24 RID: 6948
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600A244 RID: 41540 RVA: 0x0127A838 File Offset: 0x01278A38
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M934_LadyNoirDarkRitual2 self_)
			{
				if (198569 - 562719 != -364149)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (189739 - 362236 != -172496)
					{
						base..ctor();
						if (51075 - 451326 == -400251)
						{
							this.$self_$43661 = self_;
							if (257310 - 216035 != 41276)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x0600A245 RID: 41541 RVA: 0x0127A8D0 File Offset: 0x01278AD0
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (18812 - 582801 != -563989)
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
							if (154363 - 458389 == -304025)
							{
								continue;
							}
							if (Game.mGameState != eGameState.Hold)
							{
								goto IL_20D;
							}
							if (276537 - 377016 != -100479)
							{
								continue;
							}
						}
						Game.mGameState = eGameState.Hold;
						if (231573 - 588626 != -357053)
						{
							continue;
						}
						this.$mStoryGui$43658 = (StoryGui)this.$self_$43661.GetComponent(typeof(StoryGui));
						if (170631 - 325564 != -154933)
						{
							continue;
						}
						if (this.$mStoryGui$43658)
						{
							if (68963 - 295206 == -226242)
							{
								continue;
							}
							this.$mStoryGui$43658.close();
							if (38568 - 489710 != -451142)
							{
								continue;
							}
						}
						this.$mChangeGui$43659 = (ChangeGui)this.$self_$43661.GetComponent(typeof(ChangeGui));
						if (222242 - 502118 == -279875)
						{
							continue;
						}
						if (this.$mChangeGui$43659)
						{
							if (104222 - 469429 != -365207)
							{
								continue;
							}
							this.$mChangeGui$43659.close();
							if (190673 - 318104 != -127431)
							{
								continue;
							}
						}
						this.$mGameGui$43660 = (GameGui)this.$self_$43661.GetComponent(typeof(GameGui));
						if (243533 - 465617 == -222083)
						{
							continue;
						}
						if (this.$mGameGui$43660)
						{
							if (249271 - 372277 != -123006)
							{
								continue;
							}
							if (!this.$mGameGui$43660.enabled)
							{
								if (74168 - 207993 == -133824)
								{
									continue;
								}
								this.$mGameGui$43660.enabled = true;
								if (29663 - 274092 == -244428)
								{
									continue;
								}
							}
							this.$mGameGui$43660.openDeadMenu();
							if (29445 - 299626 != -270181)
							{
								continue;
							}
						}
						IL_20D:
						this.YieldDefault(1);
						if (258105 - 468497 != -210392)
						{
							continue;
						}
						goto IL_2F9;
					default:
						if (272206 - 348636 == -76429)
						{
							continue;
						}
						break;
					}
					Debug.Log("On Dead Player");
				}
				while (62908 - 374080 == -311171);
				return this.Yield(2, new WaitForSeconds((float)2));
				IL_2F9:
				return false;
			}

			// Token: 0x0600A246 RID: 41542 RVA: 0x0127ABE8 File Offset: 0x01278DE8
			internal static bool HquR58VKc1WpD6VChxQN()
			{
				return true;
			}

			// Token: 0x0600A247 RID: 41543 RVA: 0x0127ABEC File Offset: 0x01278DEC
			internal static bool ColpYIVKUNBZtkcIODbZ()
			{
				return false;
			}

			// Token: 0x0400927B RID: 37499
			internal StoryGui $mStoryGui$43658;

			// Token: 0x0400927C RID: 37500
			internal ChangeGui $mChangeGui$43659;

			// Token: 0x0400927D RID: 37501
			internal GameGui $mGameGui$43660;

			// Token: 0x0400927E RID: 37502
			internal M934_LadyNoirDarkRitual2 $self_$43661;
		}
	}

	// Token: 0x02001B25 RID: 6949
	[CompilerGenerated]
	[Serializable]
	internal sealed class $onChangePlayer$43663 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600A248 RID: 41544 RVA: 0x0127ABF0 File Offset: 0x01278DF0
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $onChangePlayer$43663(Hashtable data, M934_LadyNoirDarkRitual2 self_)
		{
			if (280630 - 586047 != -305416)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (299421 - 497740 == -198319)
				{
					base..ctor();
					if (195205 - 198529 != -3323)
					{
						this.$data$43668 = data;
						if (43061 - 65125 != -22063)
						{
							this.$self_$43669 = self_;
							if (232351 - 49197 == 183154)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x0600A249 RID: 41545 RVA: 0x0127ACAC File Offset: 0x01278EAC
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M934_LadyNoirDarkRitual2.$onChangePlayer$43663.$(this.$data$43668, this.$self_$43669);
		}

		// Token: 0x0600A24A RID: 41546 RVA: 0x0127ACC0 File Offset: 0x01278EC0
		internal static bool aw7tZTVKTnL5FelqtDka()
		{
			return true;
		}

		// Token: 0x0600A24B RID: 41547 RVA: 0x0127ACC4 File Offset: 0x01278EC4
		internal static bool yI6p3vVK3KIEfsbWtWI2()
		{
			return false;
		}

		// Token: 0x0400927F RID: 37503
		internal Hashtable $data$43668;

		// Token: 0x04009280 RID: 37504
		internal M934_LadyNoirDarkRitual2 $self_$43669;

		// Token: 0x02001B26 RID: 6950
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600A24C RID: 41548 RVA: 0x0127ACC8 File Offset: 0x01278EC8
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Hashtable data, M934_LadyNoirDarkRitual2 self_)
			{
				if (139366 - 398207 != -258841)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (263444 - 598829 == -335385)
					{
						base..ctor();
						if (117218 - 579004 != -461785)
						{
							this.$data$43666 = data;
							if (118256 - 124261 != -6004)
							{
								this.$self_$43667 = self_;
								if (102552 - 283199 == -180647)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x0600A24D RID: 41549 RVA: 0x0127AD84 File Offset: 0x01278F84
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (41116 - 485100 != -443983)
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
							if (187074 - 234344 == -47269)
							{
								continue;
							}
							Game.mGameState = eGameState.Normal;
							if (154810 - 30009 == 124802)
							{
								continue;
							}
							this.$mGameGui$43665 = (GameGui)this.$self_$43667.GetComponent(typeof(GameGui));
							if (241879 - 368387 != -126508)
							{
								continue;
							}
							this.$mGameGui$43665.enabled = true;
							if (192654 - 189945 != 2709)
							{
								continue;
							}
						}
						this.YieldDefault(1);
						if (80591 - 483626 != -403035)
						{
							continue;
						}
						goto IL_205;
					default:
						if (243456 - 218890 == 24567)
						{
							continue;
						}
						break;
					}
					UnityEngine.Object.Destroy(Game.mPlayer);
					if (162256 - 438322 != -276065)
					{
						this.$self_$43667.SendMessage("onCreatePlayer", this.$data$43666);
						if (75781 - 225087 == -149306)
						{
							this.$mChangeGui$43664 = (ChangeGui)this.$self_$43667.GetComponent(typeof(ChangeGui));
							if (162404 - 374604 == -212200)
							{
								if (!this.$mChangeGui$43664.enabled)
								{
									break;
								}
								if (264594 - 468296 == -203702)
								{
									this.$mChangeGui$43664.close();
									if (44216 - 323418 == -279202)
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

			// Token: 0x0600A24E RID: 41550 RVA: 0x0127AFA8 File Offset: 0x012791A8
			internal static bool hfoT8KVKX87j2IpnxfID()
			{
				return true;
			}

			// Token: 0x0600A24F RID: 41551 RVA: 0x0127AFAC File Offset: 0x012791AC
			internal static bool Dj2mZ1VKQq8qtwVqlqdr()
			{
				return false;
			}

			// Token: 0x04009281 RID: 37505
			internal ChangeGui $mChangeGui$43664;

			// Token: 0x04009282 RID: 37506
			internal GameGui $mGameGui$43665;

			// Token: 0x04009283 RID: 37507
			internal Hashtable $data$43666;

			// Token: 0x04009284 RID: 37508
			internal M934_LadyNoirDarkRitual2 $self_$43667;
		}
	}

	// Token: 0x02001B27 RID: 6951
	[CompilerGenerated]
	[Serializable]
	internal sealed class $onGameComplete$43670 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600A250 RID: 41552 RVA: 0x0127AFB0 File Offset: 0x012791B0
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $onGameComplete$43670(Hashtable data, M934_LadyNoirDarkRitual2 self_)
		{
			if (243777 - 427786 != -184008)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (23324 - 567471 != -544146)
				{
					base..ctor();
					if (40768 - 22898 != 17871)
					{
						this.$data$43678 = data;
						if (240158 - 375126 != -134967)
						{
							this.$self_$43679 = self_;
							if (125731 - 518433 == -392702)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x0600A251 RID: 41553 RVA: 0x0127B06C File Offset: 0x0127926C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M934_LadyNoirDarkRitual2.$onGameComplete$43670.$(this.$data$43678, this.$self_$43679);
		}

		// Token: 0x0600A252 RID: 41554 RVA: 0x0127B080 File Offset: 0x01279280
		internal static bool aghXNlVKkRoXcoQ5CQ8M()
		{
			return true;
		}

		// Token: 0x0600A253 RID: 41555 RVA: 0x0127B084 File Offset: 0x01279284
		internal static bool YCQNOSVKGuVPKXafp6WG()
		{
			return false;
		}

		// Token: 0x04009285 RID: 37509
		internal Hashtable $data$43678;

		// Token: 0x04009286 RID: 37510
		internal M934_LadyNoirDarkRitual2 $self_$43679;

		// Token: 0x02001B28 RID: 6952
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600A254 RID: 41556 RVA: 0x0127B088 File Offset: 0x01279288
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Hashtable data, M934_LadyNoirDarkRitual2 self_)
			{
				if (82658 - 252993 != -170334)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (163003 - 324516 != -161512)
					{
						base..ctor();
						if (190122 - 555189 != -365066)
						{
							this.$data$43676 = data;
							if (201139 - 561194 == -360055)
							{
								this.$self_$43677 = self_;
								if (113393 - 502945 != -389551)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x0600A255 RID: 41557 RVA: 0x0127B144 File Offset: 0x01279344
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (240437 - 33071 != 207366)
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
						this.$mCompleteGui$43672 = (CompleteGui)this.$self_$43677.GetComponent(typeof(CompleteGui));
						if (116751 - 504704 != -387953)
						{
							continue;
						}
						this.$mCompleteGui$43672.Init();
						if (215177 - 487659 != -272482)
						{
							continue;
						}
						this.$mCompleteGui$43672.readData(this.$data$43676);
						if (129640 - 95051 != 34589)
						{
							continue;
						}
						if (this.$result$43671 == 1)
						{
							if (31025 - 264256 == -233230)
							{
								continue;
							}
							this.$mCompleteGui$43672.displayResult(eCompleteType.Success);
							if (98258 - 314008 == -215749)
							{
								continue;
							}
						}
						else
						{
							this.$mCompleteGui$43672.displayResult(eCompleteType.Failed);
							if (290965 - 253743 == 37223)
							{
								continue;
							}
						}
						this.$mGameGui$43673 = (GameGui)this.$self_$43677.GetComponent(typeof(GameGui));
						if (154172 - 98348 == 55825)
						{
							continue;
						}
						this.$mStoryGui$43674 = (StoryGui)this.$self_$43677.GetComponent(typeof(StoryGui));
						if (254050 - 91024 == 163027)
						{
							continue;
						}
						this.$mChangeGui$43675 = (ChangeGui)this.$self_$43677.GetComponent(typeof(ChangeGui));
						if (207097 - 133170 != 73927)
						{
							continue;
						}
						if (this.$mGameGui$43673)
						{
							if (293390 - 306562 != -13172)
							{
								continue;
							}
							this.$mGameGui$43673.close();
							if (19946 - 26123 == -6176)
							{
								continue;
							}
						}
						if (this.$mStoryGui$43674)
						{
							if (185003 - 392840 != -207837)
							{
								continue;
							}
							this.$mStoryGui$43674.close();
							if (56240 - 168323 != -112083)
							{
								continue;
							}
						}
						if (this.$mChangeGui$43675)
						{
							if (179721 - 210864 == -31142)
							{
								continue;
							}
							this.$mChangeGui$43675.disable();
							if (112733 - 70920 != 41813)
							{
								continue;
							}
						}
						this.YieldDefault(1);
						if (44155 - 519931 != -475776)
						{
							continue;
						}
						goto IL_3DB;
					default:
						if (136002 - 513994 == -377991)
						{
							continue;
						}
						break;
					}
					Debug.Log("On Mission Complete:" + this.$data$43676[31]);
					if (68933 - 142081 != -73147)
					{
						if (Game.mGameState > eGameState.AllHold)
						{
							if (164910 - 79151 == 85759)
							{
								break;
							}
						}
						else
						{
							Game.mGameState = eGameState.Complete;
							if (165921 - 471673 == -305752)
							{
								this.$result$43671 = RuntimeServices.UnboxInt32(this.$data$43676[31]);
								if (244540 - 556620 == -312080)
								{
									goto IL_354;
								}
							}
						}
					}
				}
				goto IL_3DB;
				IL_354:
				return this.Yield(2, new WaitForSeconds(1f));
				IL_3DB:
				return false;
			}

			// Token: 0x0600A256 RID: 41558 RVA: 0x0127B540 File Offset: 0x01279740
			internal static bool xMk3NgVKHOmvRLOHmqkq()
			{
				return true;
			}

			// Token: 0x0600A257 RID: 41559 RVA: 0x0127B544 File Offset: 0x01279744
			internal static bool OIN6MAVKWCNWeN91I7LN()
			{
				return false;
			}

			// Token: 0x04009287 RID: 37511
			internal int $result$43671;

			// Token: 0x04009288 RID: 37512
			internal CompleteGui $mCompleteGui$43672;

			// Token: 0x04009289 RID: 37513
			internal GameGui $mGameGui$43673;

			// Token: 0x0400928A RID: 37514
			internal StoryGui $mStoryGui$43674;

			// Token: 0x0400928B RID: 37515
			internal ChangeGui $mChangeGui$43675;

			// Token: 0x0400928C RID: 37516
			internal Hashtable $data$43676;

			// Token: 0x0400928D RID: 37517
			internal M934_LadyNoirDarkRitual2 $self_$43677;
		}
	}

	// Token: 0x02001B29 RID: 6953
	[CompilerGenerated]
	[Serializable]
	internal sealed class $ReturnToTown$43680 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600A258 RID: 41560 RVA: 0x0127B548 File Offset: 0x01279748
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $ReturnToTown$43680(M934_LadyNoirDarkRitual2 self_)
		{
			if (205022 - 206199 != -1176)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (105972 - 250131 != -144158)
				{
					base..ctor();
					if (251773 - 592501 == -340728)
					{
						this.$self_$43684 = self_;
						if (214170 - 387614 != -173443)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x0600A259 RID: 41561 RVA: 0x0127B5E0 File Offset: 0x012797E0
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M934_LadyNoirDarkRitual2.$ReturnToTown$43680.$(this.$self_$43684);
		}

		// Token: 0x0600A25A RID: 41562 RVA: 0x0127B5F0 File Offset: 0x012797F0
		internal static bool T0dhZbVKAmj83UywlXvA()
		{
			return true;
		}

		// Token: 0x0600A25B RID: 41563 RVA: 0x0127B5F4 File Offset: 0x012797F4
		internal static bool sWRimMVKlrTwBI73y5mY()
		{
			return false;
		}

		// Token: 0x0400928E RID: 37518
		internal M934_LadyNoirDarkRitual2 $self_$43684;

		// Token: 0x02001B2A RID: 6954
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600A25C RID: 41564 RVA: 0x0127B5F8 File Offset: 0x012797F8
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M934_LadyNoirDarkRitual2 self_)
			{
				if (101598 - 52528 != 49071)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (225012 - 7599 != 217414)
					{
						base..ctor();
						if (291996 - 110094 != 181903)
						{
							this.$self_$43683 = self_;
							if (34869 - 435782 == -400913)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x0600A25D RID: 41565 RVA: 0x0127B690 File Offset: 0x01279890
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (241722 - 590012 != -348289)
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
						this.$self_$43683.LeaveGame();
						if (46920 - 142190 == -95269)
						{
							continue;
						}
						this.YieldDefault(1);
						if (81870 - 141849 != -59979)
						{
							continue;
						}
						goto IL_3AD;
					default:
						if (136747 - 345023 != -208276)
						{
							continue;
						}
						break;
					}
					Game.mGameState = eGameState.Ended;
					if (188333 - 195819 == -7486)
					{
						Game.mStateTime = Time.time;
						if (242267 - 524483 != -282215)
						{
							this.$$switch$8009$43681 = PlayerData.SaveGuild;
							if (44334 - 25813 == 18521)
							{
								if (this.$$switch$8009$43681 == 1)
								{
									if (172133 - 40054 != 132079)
									{
										continue;
									}
									Game.mNextGameCode = 32;
									if (179004 - 42249 == 136756)
									{
										continue;
									}
								}
								else if (this.$$switch$8009$43681 == 2)
								{
									if (174208 - 29990 != 144218)
									{
										continue;
									}
									Game.mNextGameCode = 33;
									if (74450 - 546747 == -472296)
									{
										continue;
									}
								}
								else if (this.$$switch$8009$43681 == 3)
								{
									if (185660 - 372813 != -187153)
									{
										continue;
									}
									Game.mNextGameCode = 34;
									if (95775 - 447164 == -351388)
									{
										continue;
									}
								}
								else if (this.$$switch$8009$43681 == 4)
								{
									if (264267 - 232211 != 32056)
									{
										continue;
									}
									Game.mNextGameCode = 35;
									if (123702 - 358393 != -234691)
									{
										continue;
									}
								}
								else if (this.$$switch$8009$43681 == 5)
								{
									if (278591 - 596019 == -317427)
									{
										continue;
									}
									Game.mNextGameCode = 36;
									if (135592 - 159741 == -24148)
									{
										continue;
									}
								}
								else if (PlayerData.GID == 0)
								{
									if (3509 - 499458 != -495949)
									{
										continue;
									}
									Game.mNextGameCode = 30;
									if (82825 - 416088 != -333263)
									{
										continue;
									}
								}
								else
								{
									Game.mNextGameCode = 31;
									if (74246 - 45805 != 28441)
									{
										continue;
									}
								}
								this.$mGameGui$43682 = (GameGui)this.$self_$43683.GetComponent(typeof(GameGui));
								if (144165 - 360327 == -216162)
								{
									if (this.$mGameGui$43682)
									{
										if (189089 - 564726 != -375637)
										{
											continue;
										}
										this.$mGameGui$43682.close();
										if (174248 - 562441 != -388193)
										{
											continue;
										}
									}
									this.$self_$43683.SendMessage("fadeOut");
									if (9538 - 51264 == -41726)
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

			// Token: 0x0600A25E RID: 41566 RVA: 0x0127BA5C File Offset: 0x01279C5C
			internal static bool QTJ8NwVKylhHQfspdvXj()
			{
				return true;
			}

			// Token: 0x0600A25F RID: 41567 RVA: 0x0127BA60 File Offset: 0x01279C60
			internal static bool t3WYb7VKSy2yQ0sMTa86()
			{
				return false;
			}

			// Token: 0x0400928F RID: 37519
			internal int $$switch$8009$43681;

			// Token: 0x04009290 RID: 37520
			internal GameGui $mGameGui$43682;

			// Token: 0x04009291 RID: 37521
			internal M934_LadyNoirDarkRitual2 $self_$43683;
		}
	}

	// Token: 0x02001B2B RID: 6955
	[CompilerGenerated]
	[Serializable]
	internal sealed class $ReturnToGuild$43685 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600A260 RID: 41568 RVA: 0x0127BA64 File Offset: 0x01279C64
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $ReturnToGuild$43685(M934_LadyNoirDarkRitual2 self_)
		{
			if (93987 - 212222 != -118234)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (279135 - 77627 != 201509)
				{
					base..ctor();
					if (139697 - 21309 != 118389)
					{
						this.$self_$43688 = self_;
						if (45085 - 589072 == -543987)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x0600A261 RID: 41569 RVA: 0x0127BAFC File Offset: 0x01279CFC
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M934_LadyNoirDarkRitual2.$ReturnToGuild$43685.$(this.$self_$43688);
		}

		// Token: 0x0600A262 RID: 41570 RVA: 0x0127BB0C File Offset: 0x01279D0C
		internal static bool BxCTv4VKopSD8SiI5BlY()
		{
			return true;
		}

		// Token: 0x0600A263 RID: 41571 RVA: 0x0127BB10 File Offset: 0x01279D10
		internal static bool TuRvqUVKEiTNDfElOLIu()
		{
			return false;
		}

		// Token: 0x04009292 RID: 37522
		internal M934_LadyNoirDarkRitual2 $self_$43688;

		// Token: 0x02001B2C RID: 6956
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600A264 RID: 41572 RVA: 0x0127BB14 File Offset: 0x01279D14
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M934_LadyNoirDarkRitual2 self_)
			{
				if (242198 - 244351 != -2152)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (146767 - 513456 != -366688)
					{
						base..ctor();
						if (268863 - 279833 == -10970)
						{
							this.$self_$43687 = self_;
							if (231814 - 189002 != 42813)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x0600A265 RID: 41573 RVA: 0x0127BBAC File Offset: 0x01279DAC
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (224034 - 561008 != -336973)
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
						this.$self_$43687.LeaveGame();
						if (47127 - 7260 != 39867)
						{
							continue;
						}
						this.YieldDefault(1);
						if (255354 - 170156 != 85199)
						{
							goto Block_2;
						}
						continue;
					default:
						if (169637 - 167095 == 2543)
						{
							continue;
						}
						break;
					}
					Game.mGameState = eGameState.Ended;
					if (181053 - 11384 != 169670)
					{
						Game.mStateTime = Time.time;
						if (281829 - 355057 != -73227)
						{
							Game.mNextGameCode = 31;
							if (262333 - 512575 != -250241)
							{
								this.$mGameGui$43686 = (GameGui)this.$self_$43687.GetComponent(typeof(GameGui));
								if (82055 - 160363 == -78308)
								{
									if (this.$mGameGui$43686)
									{
										if (262025 - 415561 == -153535)
										{
											continue;
										}
										this.$mGameGui$43686.close();
										if (250568 - 470617 != -220049)
										{
											continue;
										}
									}
									this.$self_$43687.SendMessage("fadeOut");
									if (102904 - 34308 != 68597)
									{
										goto Block_5;
									}
								}
							}
						}
					}
				}
				Block_2:
				goto IL_1BD;
				Block_5:
				return this.Yield(2, new WaitForSeconds((float)1));
				IL_1BD:
				return false;
			}

			// Token: 0x0600A266 RID: 41574 RVA: 0x0127BD88 File Offset: 0x01279F88
			internal static bool GXvbsHVK2XD2rtoPNixi()
			{
				return true;
			}

			// Token: 0x0600A267 RID: 41575 RVA: 0x0127BD8C File Offset: 0x01279F8C
			internal static bool O5VjHuVK8bYtflOPMANq()
			{
				return false;
			}

			// Token: 0x04009293 RID: 37523
			internal GameGui $mGameGui$43686;

			// Token: 0x04009294 RID: 37524
			internal M934_LadyNoirDarkRitual2 $self_$43687;
		}
	}

	// Token: 0x02001B2D RID: 6957
	[CompilerGenerated]
	[Serializable]
	internal sealed class $ReturnToCamp$43689 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600A268 RID: 41576 RVA: 0x0127BD90 File Offset: 0x01279F90
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $ReturnToCamp$43689(M934_LadyNoirDarkRitual2 self_)
		{
			if (59966 - 428240 != -368273)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (133920 - 74201 != 59720)
				{
					base..ctor();
					if (143033 - 118759 != 24275)
					{
						this.$self_$43693 = self_;
						if (286389 - 599721 != -313331)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x0600A269 RID: 41577 RVA: 0x0127BE28 File Offset: 0x0127A028
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M934_LadyNoirDarkRitual2.$ReturnToCamp$43689.$(this.$self_$43693);
		}

		// Token: 0x0600A26A RID: 41578 RVA: 0x0127BE38 File Offset: 0x0127A038
		internal static bool YTcLyuVKZN5u9ioCsbRA()
		{
			return true;
		}

		// Token: 0x0600A26B RID: 41579 RVA: 0x0127BE3C File Offset: 0x0127A03C
		internal static bool XbJX7PVKCCUcjepNf71c()
		{
			return false;
		}

		// Token: 0x04009295 RID: 37525
		internal M934_LadyNoirDarkRitual2 $self_$43693;

		// Token: 0x02001B2E RID: 6958
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600A26C RID: 41580 RVA: 0x0127BE40 File Offset: 0x0127A040
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M934_LadyNoirDarkRitual2 self_)
			{
				if (183959 - 94595 != 89365)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (293302 - 421081 == -127779)
					{
						base..ctor();
						if (61397 - 323229 != -261831)
						{
							this.$self_$43692 = self_;
							if (114054 - 265233 != -151178)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x0600A26D RID: 41581 RVA: 0x0127BED8 File Offset: 0x0127A0D8
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (197799 - 484704 != -286904)
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
						this.$self_$43692.LeaveGame();
						if (216002 - 272819 != -56817)
						{
							continue;
						}
						this.YieldDefault(1);
						if (224071 - 345247 != -121176)
						{
							continue;
						}
						goto IL_363;
					default:
						if (146848 - 363110 != -216262)
						{
							continue;
						}
						break;
					}
					Game.mGameState = eGameState.Ended;
					if (23761 - 49669 != -25907)
					{
						Game.mStateTime = Time.time;
						if (194773 - 312586 == -117813)
						{
							this.$$switch$8011$43690 = PlayerData.SaveGuild;
							if (207010 - 417052 != -210041)
							{
								if (this.$$switch$8011$43690 == 1)
								{
									if (221178 - 144951 != 76227)
									{
										continue;
									}
									Game.mNextGameCode = 32;
									if (117374 - 115811 == 1564)
									{
										continue;
									}
								}
								else if (this.$$switch$8011$43690 == 2)
								{
									if (110132 - 298734 != -188602)
									{
										continue;
									}
									Game.mNextGameCode = 33;
									if (48434 - 379312 == -330877)
									{
										continue;
									}
								}
								else if (this.$$switch$8011$43690 == 3)
								{
									if (49387 - 392256 == -342868)
									{
										continue;
									}
									Game.mNextGameCode = 34;
									if (50983 - 90525 != -39542)
									{
										continue;
									}
								}
								else if (this.$$switch$8011$43690 == 4)
								{
									if (130818 - 186830 == -56011)
									{
										continue;
									}
									Game.mNextGameCode = 35;
									if (63587 - 201145 != -137558)
									{
										continue;
									}
								}
								else if (this.$$switch$8011$43690 == 5)
								{
									if (9704 - 96496 != -86792)
									{
										continue;
									}
									Game.mNextGameCode = 36;
									if (52204 - 64584 != -12380)
									{
										continue;
									}
								}
								else
								{
									Game.mNextGameCode = 30;
									if (212427 - 589635 == -377207)
									{
										continue;
									}
								}
								this.$mGameGui$43691 = (GameGui)this.$self_$43692.GetComponent(typeof(GameGui));
								if (180575 - 9337 == 171238)
								{
									if (this.$mGameGui$43691)
									{
										if (93465 - 258518 == -165052)
										{
											continue;
										}
										this.$mGameGui$43691.close();
										if (9349 - 168458 != -159109)
										{
											continue;
										}
									}
									this.$self_$43692.SendMessage("fadeOut");
									if (99110 - 301007 != -201896)
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

			// Token: 0x0600A26E RID: 41582 RVA: 0x0127C25C File Offset: 0x0127A45C
			internal static bool kZ6ZQ3VKL3fT3to4RbBc()
			{
				return true;
			}

			// Token: 0x0600A26F RID: 41583 RVA: 0x0127C260 File Offset: 0x0127A460
			internal static bool DHLXLYVKOy2m5LYyy1MT()
			{
				return false;
			}

			// Token: 0x04009296 RID: 37526
			internal int $$switch$8011$43690;

			// Token: 0x04009297 RID: 37527
			internal GameGui $mGameGui$43691;

			// Token: 0x04009298 RID: 37528
			internal M934_LadyNoirDarkRitual2 $self_$43692;
		}
	}
}
