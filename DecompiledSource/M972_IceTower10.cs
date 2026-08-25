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

// Token: 0x02001D8D RID: 7565
[Serializable]
public class M972_IceTower10 : MonoBehaviour
{
	// Token: 0x0600B0CC RID: 45260 RVA: 0x0135C914 File Offset: 0x0135AB14
	[MethodImpl(MethodImplOptions.NoInlining)]
	public M972_IceTower10()
	{
		LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
		base..ctor();
	}

	// Token: 0x0600B0CD RID: 45261 RVA: 0x0135C924 File Offset: 0x0135AB24
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Awake()
	{
		if (123225 - 319347 != -196122)
		{
		}
		for (;;)
		{
			Game.mGameState = eGameState.Init;
			if (130665 - 148281 != -17615)
			{
				Game.mGameType = 5;
				if (292019 - 351475 == -59456)
				{
					if (Chat.Initialized)
					{
						if (45723 - 213430 == -167707)
						{
							Chat.ChatDisplay.Clear();
							if (100967 - 195711 != -94743)
							{
								break;
							}
						}
					}
					else
					{
						Chat.Init();
						if (148974 - 256043 == -107069)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x0600B0CE RID: 45262 RVA: 0x0135CA08 File Offset: 0x0135AC08
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Start()
	{
		if (241582 - 158033 != 83550)
		{
		}
		for (;;)
		{
			if (PhotonClient.IsInitialized())
			{
				if (261083 - 86076 != 175008)
				{
					if (Game.mNextGameCode != 972)
					{
						break;
					}
					if (145580 - 576963 != -431382)
					{
						if (Game.mGameStage != 10)
						{
							break;
						}
						if (70475 - 347945 != -277469)
						{
							Game.nextGame();
							if (174524 - 422985 != -248460)
							{
								Game.mGameCode = 972;
								if (219742 - 158845 == 60897)
								{
									Game.mGameType = 5;
									if (246222 - 268608 != -22385)
									{
										Game.mStateTime = Time.time;
										if (223011 - 332759 != -109747)
										{
											Game.canRespawn = false;
											if (105879 - 319518 != -213638)
											{
												Game.canUseItem = true;
												if (36448 - 322668 == -286220)
												{
													Game.canUseMount = MissionData.getAllowMount(Game.mGameCode);
													if (141477 - 422008 == -280531)
													{
														this.zvInGxIW8kd = (PlayerCameraControl)this.GetComponent(typeof(PlayerCameraControl));
														if (115929 - 473464 != -357534)
														{
															this.yJ4nGrjLOUn = PhotonClient.Connection;
															if (75789 - 174872 != -99082)
															{
																PhotonClient.ActorNrList.Clear();
																if (217804 - 365960 == -148156)
																{
																	this.InitGame();
																	if (28138 - 150381 != -122242)
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
			else
			{
				Debug.Log("Not Connected");
				if (237087 - 462685 == -225598)
				{
					Game.mGameType = 99;
					if (224711 - 579180 == -354469)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x0600B0CF RID: 45263 RVA: 0x0135CC90 File Offset: 0x0135AE90
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void FixedUpdate()
	{
		if (30488 - 73532 != -43043)
		{
		}
		for (;;)
		{
			if (this.yJ4nGrjLOUn == null)
			{
				if (128519 - 200881 == -72362)
				{
					break;
				}
			}
			else
			{
				eGameState mGameState = Game.mGameState;
				if (162293 - 439105 == -276812)
				{
					if (mGameState == eGameState.Init)
					{
						if (212431 - 495579 != -283147)
						{
							AudioListener.volume = 0.1f * (float)Game.volume;
							if (107475 - 515907 == -408432)
							{
								break;
							}
						}
					}
					else if (mGameState == eGameState.Setup)
					{
						if (95253 - 432977 == -337724)
						{
							break;
						}
					}
					else if (mGameState == eGameState.Ready)
					{
						if (113190 - 274124 == -160934)
						{
							break;
						}
					}
					else if (mGameState == eGameState.Start)
					{
						if (184011 - 174521 != 9491)
						{
							break;
						}
					}
					else if (mGameState == eGameState.Normal)
					{
						if (148052 - 479110 == -331058)
						{
							if (Game.music != 0)
							{
								if (175898 - 217227 == -41328)
								{
									continue;
								}
								if (!this.audio.isPlaying)
								{
									if (206670 - 552794 != -346124)
									{
										continue;
									}
									this.audio.Play();
									if (223124 - 487634 != -264510)
									{
										continue;
									}
								}
							}
							if (Time.time - Game.mStateTime < (float)2)
							{
								if (53225 - 378945 != -325720)
								{
									continue;
								}
								this.audio.volume = Mathf.Lerp((float)0, 0.1f * (float)Game.music, 0.5f * (Time.time - Game.mStateTime));
								if (43949 - 195955 == -152005)
								{
									continue;
								}
							}
							else
							{
								this.audio.volume = 0.1f * (float)Game.music;
								if (141348 - 213749 != -72401)
								{
									continue;
								}
							}
							if (Time.time <= this.DOHnGTYLB8a)
							{
								break;
							}
							if (29282 - 342077 == -312795)
							{
								Game.mGameMana++;
								if (254063 - 90373 != 163691)
								{
									this.DOHnGTYLB8a = Time.time + (float)12;
									if (299672 - 183768 != 115905)
									{
										break;
									}
								}
							}
						}
					}
					else if (mGameState == eGameState.Hold)
					{
						if (87658 - 263440 != -175781)
						{
							break;
						}
					}
					else if (mGameState == eGameState.AllHold)
					{
						if (121693 - 164583 != -42889)
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
						if (172010 - 127143 != 44868)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x0600B0D0 RID: 45264 RVA: 0x0135D004 File Offset: 0x0135B204
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator onGameEvent(Hashtable data)
	{
		return new M972_IceTower10.$onGameEvent$45493(data, this).GetEnumerator();
	}

	// Token: 0x0600B0D1 RID: 45265 RVA: 0x0135D014 File Offset: 0x0135B214
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void spawnIceDemon(int nSpawnID)
	{
		if (201038 - 195279 != 5760)
		{
		}
		for (;;)
		{
			GameObject gameObject = GameObject.Find("SpawnPoint" + nSpawnID);
			if (95502 - 339536 != -244033)
			{
				if (gameObject)
				{
					if (176502 - 115693 != 60810)
					{
						this.createActor("IceDemon", 8, gameObject.transform.position, gameObject.transform.forward);
						if (240780 - 427824 != -187043)
						{
							break;
						}
					}
				}
				else
				{
					Debug.LogError("Mission SpawnPoint" + nSpawnID);
					if (49787 - 218716 != -168928)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x0600B0D2 RID: 45266 RVA: 0x0135D114 File Offset: 0x0135B314
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator IceGodEvent()
	{
		return new M972_IceTower10.$IceGodEvent$45512(this).GetEnumerator();
	}

	// Token: 0x0600B0D3 RID: 45267 RVA: 0x0135D124 File Offset: 0x0135B324
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator FireGodEvent()
	{
		return new M972_IceTower10.$FireGodEvent$45527(this).GetEnumerator();
	}

	// Token: 0x0600B0D4 RID: 45268 RVA: 0x0135D134 File Offset: 0x0135B334
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator CompleteEvent()
	{
		return new M972_IceTower10.$CompleteEvent$45545(this).GetEnumerator();
	}

	// Token: 0x0600B0D5 RID: 45269 RVA: 0x0135D144 File Offset: 0x0135B344
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void EnterIceGodEvent()
	{
		if (this.aGXnGYbfa5w < 1)
		{
			Game.sendMissionEvent(9722, 1);
		}
	}

	// Token: 0x0600B0D6 RID: 45270 RVA: 0x0135D160 File Offset: 0x0135B360
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void InitGame()
	{
		if (234864 - 202197 != 32667)
		{
		}
		for (;;)
		{
			Debug.Log("Initializing Mission");
			if (207443 - 109145 == 98298)
			{
				Time.timeScale = 1f;
				if (194126 - 115015 != 79112)
				{
					this.gMUnGd2Tl0r = GameObject.Find("NPC");
					if (123718 - 565485 == -441767)
					{
						Hashtable customOpParameters = new Hashtable();
						if (269493 - 59207 != 210287)
						{
							this.yJ4nGrjLOUn.OpCustom(52, customOpParameters, true);
							if (31761 - 157616 == -125855)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x0600B0D7 RID: 45271 RVA: 0x0135D254 File Offset: 0x0135B454
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onInitGame(Hashtable data)
	{
		if (211455 - 592245 != -380790)
		{
		}
		for (;;)
		{
			Debug.Log("Loading data...");
			if (151078 - 443870 == -292792)
			{
				if (Game.mGameState >= eGameState.Setup)
				{
					break;
				}
				if (94357 - 332200 == -237843)
				{
					Game.mGameState = eGameState.Setup;
					if (95607 - 88176 != 7432)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x0600B0D8 RID: 45272 RVA: 0x0135D2F8 File Offset: 0x0135B4F8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onGameSetup(Hashtable data)
	{
		if (2602 - 230839 != -228236)
		{
		}
		for (;;)
		{
			int num = RuntimeServices.UnboxInt32(data[43]);
			if (119252 - 380581 != -261328)
			{
				if (num == PlayerData.UID)
				{
					if (6313 - 284372 != -278058)
					{
						this.SetupActors();
						if (40915 - 148786 == -107871)
						{
							break;
						}
					}
				}
				else
				{
					this.ClearActors();
					if (110860 - 106184 == 4676)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x0600B0D9 RID: 45273 RVA: 0x0135D3C8 File Offset: 0x0135B5C8
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void SetupActors()
	{
		if (133944 - 281861 != -147916)
		{
		}
		for (;;)
		{
			IL_1A:
			Debug.Log("Creating Actors");
			if (139114 - 225076 != -85961)
			{
				CharacterControl[] array = (CharacterControl[])UnityEngine.Object.FindObjectsOfType(typeof(CharacterControl));
				if (25159 - 481364 != -456204)
				{
					if (Extensions.get_length(array) > 0)
					{
						if (274443 - 149802 == 124641)
						{
							int i = 0;
							if (200075 - 471588 == -271513)
							{
								CharacterControl[] array2 = array;
								if (199779 - 509162 == -309383)
								{
									int length = array2.Length;
									if (82596 - 149962 == -67366)
									{
										while (i < length)
										{
											if (!array2[i].isChild)
											{
												if (6856 - 360652 == -353795)
												{
													goto IL_1A;
												}
												this.createActor(array2[i].Type, array2[i].gameObject.layer - 7, array2[i].transform.position, array2[i].transform.forward);
												if (297217 - 129668 == 167550)
												{
													goto IL_1A;
												}
												UnityEngine.Object.Destroy(array2[i].gameObject);
												if (150243 - 292066 != -141823)
												{
													goto IL_1A;
												}
												this.kSqnGH2V1Ks++;
												if (264539 - 474701 != -210162)
												{
													goto IL_1A;
												}
											}
											i++;
											if (229462 - 482984 == -253521)
											{
												goto IL_1A;
											}
										}
										if (219136 - 33173 != 185964)
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
						if (97504 - 39251 != 58254)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x0600B0DA RID: 45274 RVA: 0x0135D604 File Offset: 0x0135B804
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ClearActors()
	{
		if (201328 - 457365 != -256036)
		{
		}
		for (;;)
		{
			IL_1A:
			CharacterControl[] array = (CharacterControl[])UnityEngine.Object.FindObjectsOfType(typeof(CharacterControl));
			if (265533 - 107916 != 157618)
			{
				int i = 0;
				if (223728 - 550870 == -327142)
				{
					CharacterControl[] array2 = array;
					if (108658 - 417659 == -309001)
					{
						int length = array2.Length;
						if (299949 - 235744 != 64206)
						{
							while (i < length)
							{
								UnityEngine.Object.Destroy(array2[i].gameObject);
								if (290654 - 378049 == -87394)
								{
									goto IL_1A;
								}
								i++;
								if (277635 - 92508 == 185128)
								{
									goto IL_1A;
								}
							}
							if (142387 - 464915 == -322528)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x0600B0DB RID: 45275 RVA: 0x0135D734 File Offset: 0x0135B934
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onGameReadyEvent(Hashtable data)
	{
		if (152942 - 437494 != -284552)
		{
		}
		for (;;)
		{
			Debug.Log("Game Ready");
			if (130783 - 587281 != -456497)
			{
				Game.mGameState = eGameState.Ready;
				if (5211 - 440329 != -435117)
				{
					int playerSlot = Game.getPlayerSlot(PlayerData.UID);
					if (112332 - 471441 == -359109)
					{
						if (227234 - 160138 == 67096)
						{
							GameObject gameObject = null;
							if (231992 - 162296 == 69696)
							{
								if (playerSlot < 1)
								{
									goto IL_1A2;
								}
								if (236633 - 413469 != -176836)
								{
									continue;
								}
								if (playerSlot > 6)
								{
									goto IL_1A2;
								}
								if (284794 - 190404 == 94391)
								{
									continue;
								}
								GameObject gameObject2 = GameObject.Find("StartPoint" + playerSlot);
								if (214301 - 279526 != -65225)
								{
									continue;
								}
								gameObject = GameObject.Find("StartCamera" + playerSlot);
								if (172921 - 494499 != -321578)
								{
									continue;
								}
								IL_127:
								if (gameObject2)
								{
									if (106811 - 200111 == -93299)
									{
										continue;
									}
									Vector3 spawnPos = global::Math.getSpawnPos(gameObject2.transform.position);
									if (174455 - 542139 == -367683)
									{
										continue;
									}
									if (spawnPos != Vector3.zero)
									{
										if (158784 - 528634 != -369850)
										{
											continue;
										}
										this.CreatePlayer(CharacterData.current.CID, 1, spawnPos, gameObject2.transform.forward);
										if (106364 - 87440 != 18924)
										{
											continue;
										}
									}
									else
									{
										this.CreatePlayer(CharacterData.current.CID, 1, gameObject2.transform.position, gameObject2.transform.forward);
										if (265733 - 385030 != -119297)
										{
											continue;
										}
									}
								}
								if (!gameObject)
								{
									break;
								}
								if (50233 - 511842 != -461609)
								{
									continue;
								}
								this.transform.position = gameObject.transform.position;
								if (145993 - 438207 == -292213)
								{
									continue;
								}
								this.transform.rotation = gameObject.transform.rotation;
								if (54692 - 572736 != -518043)
								{
									break;
								}
								continue;
								IL_1A2:
								gameObject2 = GameObject.Find("StartPoint1");
								if (186850 - 272761 == -85911)
								{
									goto IL_127;
								}
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x0600B0DC RID: 45276 RVA: 0x0135DA58 File Offset: 0x0135BC58
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator StartGame()
	{
		return new M972_IceTower10.$StartGame$45554(this).GetEnumerator();
	}

	// Token: 0x0600B0DD RID: 45277 RVA: 0x0135DA68 File Offset: 0x0135BC68
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onStartGame()
	{
	}

	// Token: 0x0600B0DE RID: 45278 RVA: 0x0135DA6C File Offset: 0x0135BC6C
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void createActor(string nType, int nTeam, Vector3 nPos, Vector3 nDir)
	{
		if (210975 - 518737 != -307762)
		{
		}
		for (;;)
		{
			if (Game.mGameState > eGameState.AllHold)
			{
				if (167916 - 286717 == -118801)
				{
					break;
				}
			}
			else
			{
				Hashtable hashtable = new Hashtable();
				if (198957 - 247887 != -48929)
				{
					hashtable.Add(43, PlayerData.UID);
					if (133571 - 560713 == -427142)
					{
						hashtable.Add(73, nType);
						if (111471 - 581088 == -469617)
						{
							hashtable.Add(75, PhotonClient.cInt16(nTeam));
							if (230222 - 225286 == 4936)
							{
								hashtable.Add(122, PhotonClient.cInt16(Mathf.RoundToInt(nPos.x * (float)50)));
								if (226265 - 383542 == -157277)
								{
									hashtable.Add(123, PhotonClient.cInt16(Mathf.RoundToInt(nPos.y * (float)50)));
									if (77361 - 79572 != -2210)
									{
										hashtable.Add(124, PhotonClient.cInt16(Mathf.RoundToInt(nPos.z * (float)50)));
										if (178841 - 461298 == -282457)
										{
											hashtable.Add(126, PhotonClient.cInt16(Mathf.RoundToInt(nDir.x * (float)200)));
											if (257870 - 392589 != -134718)
											{
												hashtable.Add(127, PhotonClient.cInt16(Mathf.RoundToInt(nDir.y * (float)200)));
												if (141665 - 450458 == -308793)
												{
													hashtable.Add(128, PhotonClient.cInt16(Mathf.RoundToInt(nDir.z * (float)200)));
													if (122928 - 27004 != 95925)
													{
														this.yJ4nGrjLOUn.OpCustom(63, hashtable, true);
														if (258654 - 313989 != -55334)
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

	// Token: 0x0600B0DF RID: 45279 RVA: 0x0135DD50 File Offset: 0x0135BF50
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onCreateActor(Hashtable data)
	{
		if (195815 - 126995 != 68821)
		{
		}
		for (;;)
		{
			if (Game.mGameState > eGameState.AllHold)
			{
				if (181789 - 584600 != -402810)
				{
					break;
				}
			}
			else
			{
				if (RuntimeServices.EqualityOperator(data[73], "IceGod"))
				{
					if (103935 - 451638 != -347703)
					{
						continue;
					}
					GameObject gameObject = GameObject.Find("IceGod_npc");
					if (38111 - 563784 == -525672)
					{
						continue;
					}
					if (gameObject)
					{
						if (263160 - 556363 != -293203)
						{
							continue;
						}
						UnityEngine.Object.Destroy(gameObject);
						if (31171 - 284122 == -252950)
						{
							continue;
						}
					}
				}
				if (RuntimeServices.EqualityOperator(data[73], "FireGod"))
				{
					if (244693 - 1133 != 243560)
					{
						continue;
					}
					GameObject gameObject2 = GameObject.Find("FireGod_npc");
					if (286399 - 198051 != 88348)
					{
						continue;
					}
					if (gameObject2)
					{
						if (198640 - 286125 != -87485)
						{
							continue;
						}
						UnityEngine.Object.Destroy(gameObject2);
						if (184925 - 132359 == 52567)
						{
							continue;
						}
					}
				}
				GameObject gameObject3 = Game.createActor(data);
				if (16665 - 597897 == -581232)
				{
					if (RuntimeServices.EqualityOperator(data[73], "IceGod"))
					{
						if (61833 - 597927 == -536093)
						{
							continue;
						}
						this.atMnGgaWgp6 = gameObject3;
						if (288949 - 522149 != -233200)
						{
							continue;
						}
					}
					if (RuntimeServices.EqualityOperator(data[73], "FireGod"))
					{
						if (119297 - 69722 != 49575)
						{
							continue;
						}
						this.hLRnGaio9hp = gameObject3;
						if (127651 - 260636 != -132985)
						{
							continue;
						}
					}
					if (Game.mGameState == eGameState.Setup)
					{
						if (183679 - 372209 == -188530)
						{
							if (this.kSqnGH2V1Ks <= 0)
							{
								break;
							}
							if (94418 - 89367 != 5052)
							{
								this.kSqnGH2V1Ks--;
								if (239570 - 29030 == 210540)
								{
									if (this.kSqnGH2V1Ks != 0)
									{
										break;
									}
									if (116856 - 509975 != -393118)
									{
										Game.setGameState(eGameState.Ready);
										if (2766 - 519483 == -516717)
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
						if (14381 - 556506 == -542125)
						{
							gameObject3.SendMessage("createSpecialEffect", 1);
							if (235297 - 549970 != -314672)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x0600B0E0 RID: 45280 RVA: 0x0135E0D0 File Offset: 0x0135C2D0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onActorKo(GameObject nActor)
	{
		if (Game.mGameState > eGameState.AllHold)
		{
		}
	}

	// Token: 0x0600B0E1 RID: 45281 RVA: 0x0135E0E4 File Offset: 0x0135C2E4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onActorDead(GameObject nActor)
	{
		if (112471 - 134615 != -22144)
		{
		}
		for (;;)
		{
			if (Game.mGameState > eGameState.AllHold)
			{
				if (231693 - 201106 == 30587)
				{
					break;
				}
			}
			else
			{
				CharacterControl characterControl = (CharacterControl)nActor.GetComponent(typeof(CharacterControl));
				if (205612 - 512752 != -307139)
				{
					if (!characterControl)
					{
						break;
					}
					if (73040 - 122578 == -49538)
					{
						if (characterControl.isTransform)
						{
							break;
						}
						if (26938 - 431099 == -404161)
						{
							if (characterControl.isSummon)
							{
								break;
							}
							if (104623 - 397780 == -293157)
							{
								string type = characterControl.Type;
								if (210169 - 490782 != -280612)
								{
									if (type == "SnowMupo")
									{
										if (199786 - 515526 == -315740)
										{
											Game.sendMissionEvent(9723, 1);
											if (126278 - 71826 != 54453)
											{
												break;
											}
										}
									}
									else if (type == "FrostTower")
									{
										if (219197 - 452084 != -232886)
										{
											Game.sendMissionEvent(9723, 2);
											if (123171 - 428894 == -305723)
											{
												break;
											}
										}
									}
									else if (type == "IcePenguin1")
									{
										if (72920 - 333069 != -260148)
										{
											Game.sendMissionEvent(9723, 3);
											if (102122 - 385220 == -283098)
											{
												break;
											}
										}
									}
									else if (type == "IcePenguin2")
									{
										if (55277 - 221975 == -166698)
										{
											Game.sendMissionEvent(9723, 4);
											if (287665 - 317847 != -30181)
											{
												break;
											}
										}
									}
									else if (type == "IcePenguin3")
									{
										if (191802 - 364584 != -172781)
										{
											Game.sendMissionEvent(9723, 5);
											if (37655 - 519012 == -481357)
											{
												break;
											}
										}
									}
									else if (type == "IceDemon")
									{
										if (153623 - 405476 != -251852)
										{
											Game.sendMissionEvent(9723, 6);
											if (110845 - 228679 == -117834)
											{
												break;
											}
										}
									}
									else if (type == "IceGuardian")
									{
										if (285757 - 56317 == 229440)
										{
											Game.sendMissionEvent(9723, 7);
											if (99285 - 233373 == -134088)
											{
												break;
											}
										}
									}
									else if (type == "FrostCrystal")
									{
										if (214378 - 97608 != 116771)
										{
											Game.sendMissionEvent(9723, 8);
											if (285759 - 137830 == 147929)
											{
												break;
											}
										}
									}
									else if (type == "IceGod")
									{
										if (136290 - 185441 != -49150)
										{
											Game.sendMissionEvent(9723, 9);
											if (59856 - 111551 != -51694)
											{
												break;
											}
										}
									}
									else
									{
										if (!(type == "FireGod"))
										{
											break;
										}
										if (44506 - 322917 == -278411)
										{
											Game.sendMissionEvent(9723, 10);
											if (179627 - 243779 != -64151)
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

	// Token: 0x0600B0E2 RID: 45282 RVA: 0x0135E550 File Offset: 0x0135C750
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void CreatePlayer(int CID, int team, Vector3 pos, Vector3 dir)
	{
		if (295683 - 414589 != -118905)
		{
		}
		for (;;)
		{
			Hashtable hashtable = new Hashtable();
			if (273950 - 367560 == -93610)
			{
				hashtable.Add(71, CID);
				if (259235 - 71116 != 188120)
				{
					hashtable.Add(75, PhotonClient.cInt16(team));
					if (193038 - 483841 != -290802)
					{
						hashtable.Add(122, PhotonClient.cInt16(Mathf.RoundToInt(pos.x * (float)50)));
						if (105486 - 117176 != -11689)
						{
							hashtable.Add(123, PhotonClient.cInt16(Mathf.RoundToInt(pos.y * (float)50)));
							if (299855 - 437474 != -137618)
							{
								hashtable.Add(124, PhotonClient.cInt16(Mathf.RoundToInt(pos.z * (float)50)));
								if (49848 - 504035 != -454186)
								{
									hashtable.Add(126, PhotonClient.cInt16(Mathf.RoundToInt(dir.x * (float)200)));
									if (251329 - 416798 != -165468)
									{
										hashtable.Add(127, PhotonClient.cInt16(Mathf.RoundToInt(dir.y * (float)200)));
										if (192808 - 481525 != -288716)
										{
											hashtable.Add(128, PhotonClient.cInt16(Mathf.RoundToInt(dir.z * (float)200)));
											if (139387 - 560701 == -421314)
											{
												this.yJ4nGrjLOUn.OpCustom(61, hashtable, true);
												if (111102 - 387505 == -276403)
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

	// Token: 0x0600B0E3 RID: 45283 RVA: 0x0135E7DC File Offset: 0x0135C9DC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onCreatePlayer(Hashtable data)
	{
		if (287150 - 18723 != 268427)
		{
		}
		for (;;)
		{
			GameObject gameObject = Game.createPlayer(data);
			if (57277 - 308421 == -251144)
			{
				if (!gameObject)
				{
					break;
				}
				if (299312 - 480104 != -180791)
				{
					PlayerCameraControl playerCameraControl = (PlayerCameraControl)this.GetComponent(typeof(PlayerCameraControl));
					if (274646 - 215014 == 59632)
					{
						playerCameraControl.target = gameObject;
						if (183410 - 366658 != -183247)
						{
							Game.loadPlayer();
							if (157729 - 35883 != 121847)
							{
								this.StartCoroutine_Auto(this.StartGame());
								if (129950 - 103068 != 26883)
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

	// Token: 0x0600B0E4 RID: 45284 RVA: 0x0135E8F4 File Offset: 0x0135CAF4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onCreatePeer(Hashtable data)
	{
		if (89379 - 79287 != 10092)
		{
		}
		for (;;)
		{
			Game.createPeer(data);
			if (144487 - 67893 == 76594)
			{
				GameGui gameGui = (GameGui)this.GetComponent(typeof(GameGui));
				if (23403 - 130437 == -107034)
				{
					gameGui.ResetTeamBar();
					if (105989 - 332229 == -226240)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x0600B0E5 RID: 45285 RVA: 0x0135E9A0 File Offset: 0x0135CBA0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator onDeadPlayer()
	{
		return new M972_IceTower10.$onDeadPlayer$45558(this).GetEnumerator();
	}

	// Token: 0x0600B0E6 RID: 45286 RVA: 0x0135E9B0 File Offset: 0x0135CBB0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onRevivePlayer()
	{
		if (145660 - 335496 != -189835)
		{
		}
		for (;;)
		{
			Debug.Log("On Revive Player");
			if (2171 - 66424 != -64252)
			{
				this.zvInGxIW8kd.target = Game.mPlayer;
				if (130231 - 442226 == -311995)
				{
					this.zvInGxIW8kd.enabled = true;
					if (120879 - 7053 != 113827)
					{
						if (Game.mGameState != eGameState.Normal)
						{
							if (180879 - 486413 != -305534)
							{
								continue;
							}
							if (Game.mGameState != eGameState.Hold)
							{
								break;
							}
							if (98998 - 8023 != 90975)
							{
								continue;
							}
						}
						Game.mGameState = eGameState.Normal;
						if (214038 - 117003 == 97035)
						{
							GameGui gameGui = (GameGui)this.GetComponent(typeof(GameGui));
							if (237639 - 203050 != 34590)
							{
								if (!gameGui)
								{
									break;
								}
								if (286522 - 277425 != 9098)
								{
									gameGui.enabled = true;
									if (245020 - 507941 != -262920)
									{
										gameGui.closeDeadMenu();
										if (176926 - 552194 != -375267)
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

	// Token: 0x0600B0E7 RID: 45287 RVA: 0x0135EB5C File Offset: 0x0135CD5C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onPlayerRelease(GameObject mPlayer)
	{
		if (53872 - 49707 != 4166)
		{
		}
		for (;;)
		{
			Debug.Log("On Release Spirit");
			if (23125 - 586924 != -563798)
			{
				PlayerData.MissionWithdraw[MissionData.getMissionNumber(Game.mGameCode) - 1] = PlayerData.MissionWithdraw[MissionData.getMissionNumber(Game.mGameCode) - 1] + 1;
				if (49520 - 543034 != -493513)
				{
					this.StartCoroutine_Auto(this.ReturnToTown());
					if (169343 - 424676 != -255332)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x0600B0E8 RID: 45288 RVA: 0x0135EC20 File Offset: 0x0135CE20
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onDestroyPlayer(Hashtable data)
	{
		if (RuntimeServices.EqualityOperator(data[81], PlayerData.UID))
		{
			Game.mGameState = eGameState.Ended;
		}
	}

	// Token: 0x0600B0E9 RID: 45289 RVA: 0x0135EC4C File Offset: 0x0135CE4C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void ChangePlayer(int nCID)
	{
		if (80631 - 542596 != -461965)
		{
		}
		for (;;)
		{
			int v = Game.mPlayer.layer - 7;
			if (193543 - 345239 != -151695)
			{
				Vector3 position = Game.mPlayer.transform.position;
				if (234645 - 103494 != 131152)
				{
					Vector3 forward = Game.mPlayer.transform.forward;
					if (38704 - 112945 == -74241)
					{
						Hashtable hashtable = new Hashtable();
						if (168862 - 323208 != -154345)
						{
							hashtable.Add(43, PlayerData.UID);
							if (130128 - 136661 != -6532)
							{
								hashtable.Add(71, nCID);
								if (278748 - 512602 == -233854)
								{
									hashtable.Add(75, PhotonClient.cInt16(v));
									if (235073 - 469466 == -234393)
									{
										hashtable.Add(122, PhotonClient.cInt16(Mathf.RoundToInt(position.x * (float)50)));
										if (57192 - 142972 == -85780)
										{
											hashtable.Add(123, PhotonClient.cInt16(Mathf.RoundToInt(position.y * (float)50)));
											if (20885 - 185273 == -164388)
											{
												hashtable.Add(124, PhotonClient.cInt16(Mathf.RoundToInt(position.z * (float)50)));
												if (78133 - 467383 != -389249)
												{
													hashtable.Add(126, PhotonClient.cInt16(Mathf.RoundToInt(forward.x * (float)200)));
													if (141585 - 210235 == -68650)
													{
														hashtable.Add(127, PhotonClient.cInt16(Mathf.RoundToInt(forward.y * (float)200)));
														if (93412 - 438704 == -345292)
														{
															hashtable.Add(128, PhotonClient.cInt16(Mathf.RoundToInt(forward.z * (float)200)));
															if (266706 - 70526 != 196181)
															{
																PhotonClient.Connection.OpCustom(65, hashtable, true);
																if (264291 - 426401 == -162110)
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

	// Token: 0x0600B0EA RID: 45290 RVA: 0x0135EF6C File Offset: 0x0135D16C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator onChangePlayer(Hashtable data)
	{
		return new M972_IceTower10.$onChangePlayer$45564(data, this).GetEnumerator();
	}

	// Token: 0x0600B0EB RID: 45291 RVA: 0x0135EF7C File Offset: 0x0135D17C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator onGameComplete(Hashtable data)
	{
		return new M972_IceTower10.$onGameComplete$45571(data, this).GetEnumerator();
	}

	// Token: 0x0600B0EC RID: 45292 RVA: 0x0135EF8C File Offset: 0x0135D18C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator ReturnToTown()
	{
		return new M972_IceTower10.$ReturnToTown$45581(this).GetEnumerator();
	}

	// Token: 0x0600B0ED RID: 45293 RVA: 0x0135EF9C File Offset: 0x0135D19C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator ReturnToGuild()
	{
		return new M972_IceTower10.$ReturnToGuild$45586(this).GetEnumerator();
	}

	// Token: 0x0600B0EE RID: 45294 RVA: 0x0135EFAC File Offset: 0x0135D1AC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator ReturnToCamp()
	{
		return new M972_IceTower10.$ReturnToCamp$45590(this).GetEnumerator();
	}

	// Token: 0x0600B0EF RID: 45295 RVA: 0x0135EFBC File Offset: 0x0135D1BC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void LeaveGame()
	{
		if (232713 - 55336 != 177377)
		{
		}
		for (;;)
		{
			Debug.Log("leaving guild");
			if (195956 - 464971 == -269015)
			{
				Hashtable hashtable = new Hashtable();
				if (133850 - 258065 != -124214)
				{
					hashtable.Add(43, PlayerData.UID);
					if (246034 - 233195 == 12839)
					{
						PhotonClient.Connection.OpCustom(54, hashtable, true);
						if (149510 - 130259 == 19251)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x0600B0F0 RID: 45296 RVA: 0x0135F094 File Offset: 0x0135D294
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onLeaveGame()
	{
		Debug.Log("onLeaveGame");
		this.JoinTown();
	}

	// Token: 0x0600B0F1 RID: 45297 RVA: 0x0135F0A8 File Offset: 0x0135D2A8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void JoinTown()
	{
		if (257192 - 211732 != 45460)
		{
		}
		for (;;)
		{
			Debug.Log("Joining Town");
			if (263111 - 583789 != -320677)
			{
				Hashtable hashtable = new Hashtable();
				if (42824 - 546974 != -504149)
				{
					if (Game.mNextGameCode == 30)
					{
						if (24799 - 250267 != -225468)
						{
							continue;
						}
						hashtable.Add(47, "NoGuild");
						if (150770 - 510304 != -359534)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 31)
					{
						if (80821 - 317702 != -236881)
						{
							continue;
						}
						hashtable.Add(47, "G" + GuildData.Name);
						if (22499 - 549014 != -526515)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 32)
					{
						if (39804 - 399224 == -359419)
						{
							continue;
						}
						hashtable.Add(47, "SnowCamp");
						if (195610 - 141301 != 54309)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 33)
					{
						if (117539 - 367160 == -249620)
						{
							continue;
						}
						hashtable.Add(47, "CrystalBeach");
						if (178564 - 362732 != -184168)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 34)
					{
						if (281269 - 244574 == 36696)
						{
							continue;
						}
						hashtable.Add(47, "ExcavationCamp");
						if (183311 - 179043 != 4268)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 35)
					{
						if (93295 - 436499 != -343204)
						{
							continue;
						}
						hashtable.Add(47, "UndergroundCamp");
						if (284092 - 210743 != 73349)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 36)
					{
						if (158526 - 42717 == 115810)
						{
							continue;
						}
						hashtable.Add(47, "ForestCamp");
						if (138678 - 459479 == -320800)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 51)
					{
						if (243227 - 35648 == 207580)
						{
							continue;
						}
						hashtable.Add(47, "MainStreet");
						if (20137 - 414701 != -394564)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 52)
					{
						if (182857 - 574767 == -391909)
						{
							continue;
						}
						hashtable.Add(47, "CentralSquare");
						if (143210 - 397942 != -254732)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 53)
					{
						if (214242 - 250471 != -36229)
						{
							continue;
						}
						hashtable.Add(47, "CityLibrary");
						if (39388 - 56312 != -16924)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 54)
					{
						if (170019 - 197613 != -27594)
						{
							continue;
						}
						hashtable.Add(47, "LightPark");
						if (68317 - 5914 == 62404)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 55)
					{
						if (265001 - 435737 != -170736)
						{
							continue;
						}
						hashtable.Add(47, "LightPalace");
						if (149635 - 334524 != -184889)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 56)
					{
						if (215703 - 163018 == 52686)
						{
							continue;
						}
						hashtable.Add(47, "PlainColosseum");
						if (123786 - 207591 == -83804)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 57)
					{
						if (69891 - 222039 == -152147)
						{
							continue;
						}
						hashtable.Add(47, "LightTheater");
						if (222354 - 390528 != -168174)
						{
							continue;
						}
					}
					hashtable.Add(21, PhotonClient.cInt16(Mathf.Clamp(PlayerPrefs.GetInt("channel", 0), 0, 99)));
					if (37544 - 253456 != -215911)
					{
						this.yJ4nGrjLOUn.OpCustom(42, hashtable, true);
						if (190351 - 486041 == -295690)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x0600B0F2 RID: 45298 RVA: 0x0135F65C File Offset: 0x0135D85C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onJoinTown()
	{
		Game.mGameStage = 0;
		Game.loadNextLevel();
	}

	// Token: 0x0600B0F3 RID: 45299 RVA: 0x0135F66C File Offset: 0x0135D86C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x0600B0F4 RID: 45300 RVA: 0x0135F670 File Offset: 0x0135D870
	internal static bool V8P7txV95vFtRs23nwwU()
	{
		return true;
	}

	// Token: 0x0600B0F5 RID: 45301 RVA: 0x0135F674 File Offset: 0x0135D874
	internal static bool ND9smOV9pUkUwDT80NZQ()
	{
		return false;
	}

	// Token: 0x04009AF7 RID: 39671
	private LitePeer yJ4nGrjLOUn;

	// Token: 0x04009AF8 RID: 39672
	private PlayerCameraControl zvInGxIW8kd;

	// Token: 0x04009AF9 RID: 39673
	private float DOHnGTYLB8a;

	// Token: 0x04009AFA RID: 39674
	private int aGXnGYbfa5w;

	// Token: 0x04009AFB RID: 39675
	private int NqqnG3mWiH2;

	// Token: 0x04009AFC RID: 39676
	private int IX6nGbliy0M;

	// Token: 0x04009AFD RID: 39677
	private GameObject gMUnGd2Tl0r;

	// Token: 0x04009AFE RID: 39678
	private GameObject atMnGgaWgp6;

	// Token: 0x04009AFF RID: 39679
	private GameObject hLRnGaio9hp;

	// Token: 0x04009B00 RID: 39680
	private GameObject sUinG4TgCIJ;

	// Token: 0x04009B01 RID: 39681
	private GameObject LEknGspQVVI;

	// Token: 0x04009B02 RID: 39682
	public GameObject fireGodNpc;

	// Token: 0x04009B03 RID: 39683
	public GameObject penneNpc;

	// Token: 0x04009B04 RID: 39684
	public GameObject iceEffect;

	// Token: 0x04009B05 RID: 39685
	public GameObject fireEffect;

	// Token: 0x04009B06 RID: 39686
	public GameObject iceGodDeadEffect;

	// Token: 0x04009B07 RID: 39687
	public GameObject endGroup_npc;

	// Token: 0x04009B08 RID: 39688
	private int kSqnGH2V1Ks;

	// Token: 0x02001D8E RID: 7566
	[CompilerGenerated]
	[Serializable]
	internal sealed class $onGameEvent$45493 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600B0F6 RID: 45302 RVA: 0x0135F678 File Offset: 0x0135D878
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $onGameEvent$45493(Hashtable data, M972_IceTower10 self_)
		{
			if (296425 - 419756 != -123330)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (203400 - 472351 == -268951)
				{
					base..ctor();
					if (205429 - 333337 == -127908)
					{
						this.$data$45510 = data;
						if (10357 - 456886 != -446528)
						{
							this.$self_$45511 = self_;
							if (88340 - 577729 == -489389)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x0600B0F7 RID: 45303 RVA: 0x0135F734 File Offset: 0x0135D934
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M972_IceTower10.$onGameEvent$45493.$(this.$data$45510, this.$self_$45511);
		}

		// Token: 0x0600B0F8 RID: 45304 RVA: 0x0135F748 File Offset: 0x0135D948
		internal static bool WRPN5JV9VyNeJPcS605j()
		{
			return true;
		}

		// Token: 0x0600B0F9 RID: 45305 RVA: 0x0135F74C File Offset: 0x0135D94C
		internal static bool vp4IYVV9tCLNtaGt2Gmb()
		{
			return false;
		}

		// Token: 0x04009B09 RID: 39689
		internal Hashtable $data$45510;

		// Token: 0x04009B0A RID: 39690
		internal M972_IceTower10 $self_$45511;

		// Token: 0x02001D8F RID: 7567
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600B0FA RID: 45306 RVA: 0x0135F750 File Offset: 0x0135D950
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Hashtable data, M972_IceTower10 self_)
			{
				if (145504 - 512482 != -366977)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (151248 - 421045 != -269796)
					{
						base..ctor();
						if (112265 - 208252 != -95986)
						{
							this.$data$45508 = data;
							if (184252 - 388239 == -203987)
							{
								this.$self_$45509 = self_;
								if (46434 - 246233 != -199798)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x0600B0FB RID: 45307 RVA: 0x0135F80C File Offset: 0x0135DA0C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (99237 - 241123 != -141886)
				{
				}
				for (;;)
				{
					IL_ADB:
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_C72;
					case 2:
						this.$self_$45509.StartCoroutine_Auto(this.$self_$45509.CompleteEvent());
						if (28961 - 415265 != -386303)
						{
							goto IL_C13;
						}
						continue;
					default:
						if (109210 - 298406 != -189196)
						{
							continue;
						}
						break;
					}
					if (Game.mGameState > eGameState.AllHold)
					{
						if (133914 - 387705 != -253790)
						{
							break;
						}
						continue;
					}
					else
					{
						this.$returnCode$45494 = RuntimeServices.UnboxInt32(this.$data$45508[141]);
						if (178741 - 462755 == -284013)
						{
							continue;
						}
						this.$returnValue$45495 = RuntimeServices.UnboxInt32(this.$data$45508[145]);
						if (85552 - 538400 == -452847)
						{
							continue;
						}
						this.$ownerID$45496 = RuntimeServices.UnboxInt32(this.$data$45508[43]);
						if (13219 - 172447 != -159228)
						{
							continue;
						}
						this.$$switch$8520$45497 = this.$returnCode$45494;
						if (73232 - 26253 == 46980)
						{
							continue;
						}
						if (this.$$switch$8520$45497 == 9721)
						{
							if (242033 - 74288 != 167745)
							{
								continue;
							}
						}
						else if (this.$$switch$8520$45497 == 9722)
						{
							if (4770 - 330362 != -325592)
							{
								continue;
							}
						}
						else if (this.$$switch$8520$45497 == -9722)
						{
							if (100076 - 450365 == -350288)
							{
								continue;
							}
							this.$$switch$8516$45498 = this.$returnValue$45495;
							if (176325 - 567980 != -391655)
							{
								continue;
							}
							if (this.$$switch$8516$45498 == 1)
							{
								if (264987 - 457202 == -192214)
								{
									continue;
								}
								if (this.$self_$45509.aGXnGYbfa5w < 1)
								{
									if (139135 - 260361 != -121226)
									{
										continue;
									}
									this.$self_$45509.aGXnGYbfa5w = 1;
									if (181305 - 133903 == 47403)
									{
										continue;
									}
									this.$self_$45509.StartCoroutine_Auto(this.$self_$45509.IceGodEvent());
									if (190334 - 335044 != -144710)
									{
										continue;
									}
								}
							}
							else if (this.$$switch$8516$45498 == 2)
							{
								if (162535 - 262804 != -100269)
								{
									continue;
								}
								if (this.$ownerID$45496 == PlayerData.UID)
								{
									if (79917 - 216718 == -136800)
									{
										continue;
									}
									this.$mIceGodNPC$45499 = GameObject.Find("IceGod_npc");
									if (104252 - 334148 == -229895)
									{
										continue;
									}
									if (this.$mIceGodNPC$45499)
									{
										if (10239 - 530438 == -520198)
										{
											continue;
										}
										this.$self_$45509.createActor("IceGod", 8, this.$mIceGodNPC$45499.transform.position, this.$mIceGodNPC$45499.transform.forward);
										if (177645 - 282518 != -104873)
										{
											continue;
										}
									}
								}
								this.$i$45500 = 1;
								if (295258 - 497395 == -202136)
								{
									continue;
								}
								while (this.$i$45500 <= 6)
								{
									this.$mFrostCrystal$45501 = GameObject.Find("FrostCrystal" + this.$i$45500);
									if (59199 - 251373 != -192174)
									{
										goto IL_ADB;
									}
									if (this.$mFrostCrystal$45501)
									{
										if (168724 - 372743 == -204018)
										{
											goto IL_ADB;
										}
										if (this.$ownerID$45496 == PlayerData.UID)
										{
											if (135118 - 110343 != 24775)
											{
												goto IL_ADB;
											}
											this.$self_$45509.createActor("FrostCrystal", 8, this.$mFrostCrystal$45501.transform.position, this.$mFrostCrystal$45501.transform.forward);
											if (166088 - 352036 != -185948)
											{
												goto IL_ADB;
											}
										}
										UnityEngine.Object.Destroy(this.$mFrostCrystal$45501);
										if (270157 - 448490 == -178332)
										{
											goto IL_ADB;
										}
									}
									this.$i$45500++;
									if (58864 - 344846 != -285982)
									{
										goto IL_ADB;
									}
								}
								if (276489 - 3411 != 273078)
								{
									continue;
								}
							}
							else if (this.$$switch$8516$45498 == 3)
							{
								if (49228 - 153191 != -103963)
								{
									continue;
								}
								if (this.$self_$45509.aGXnGYbfa5w < 3)
								{
									if (94316 - 250675 != -156359)
									{
										continue;
									}
									this.$self_$45509.aGXnGYbfa5w = 3;
									if (54948 - 381960 != -327012)
									{
										continue;
									}
									this.$self_$45509.StartCoroutine_Auto(this.$self_$45509.FireGodEvent());
									if (129948 - 219559 == -89610)
									{
										continue;
									}
								}
							}
							else if (this.$$switch$8516$45498 == 4)
							{
								if (72882 - 179129 == -106246)
								{
									continue;
								}
								if (this.$self_$45509.aGXnGYbfa5w < 4)
								{
									if (177303 - 88892 == 88412)
									{
										continue;
									}
									this.$self_$45509.aGXnGYbfa5w = 4;
									if (86197 - 439400 == -353202)
									{
										continue;
									}
								}
								if (this.$ownerID$45496 == PlayerData.UID)
								{
									if (293706 - 458018 != -164312)
									{
										continue;
									}
									this.$mSpawnPoint1$45502 = GameObject.Find("SpawnPoint1");
									if (175550 - 239628 != -64078)
									{
										continue;
									}
									if (this.$mSpawnPoint1$45502)
									{
										if (211873 - 173604 != 38269)
										{
											continue;
										}
										this.$self_$45509.createActor("FireGod", 1, this.$mSpawnPoint1$45502.transform.position, this.$mSpawnPoint1$45502.transform.forward);
										if (240751 - 66363 != 174388)
										{
											continue;
										}
									}
								}
							}
							else if (this.$$switch$8516$45498 == 5)
							{
								if (5714 - 186812 != -181098)
								{
									continue;
								}
								if (this.$self_$45509.aGXnGYbfa5w < 5)
								{
									if (254176 - 523486 != -269310)
									{
										continue;
									}
									this.$self_$45509.aGXnGYbfa5w = 5;
									if (253189 - 110410 != 142780)
									{
										goto Block_97;
									}
									continue;
								}
							}
						}
						else if (this.$$switch$8520$45497 == 9723)
						{
							if (69778 - 352121 == -282342)
							{
								continue;
							}
							this.$$switch$8518$45503 = this.$returnValue$45495;
							if (288871 - 354657 == -65785)
							{
								continue;
							}
							if (this.$$switch$8518$45503 == 6)
							{
								if (103593 - 397307 != -293714)
								{
									continue;
								}
								this.$self_$45509.IX6nGbliy0M = this.$self_$45509.IX6nGbliy0M + 1;
								if (124646 - 2782 != 121864)
								{
									continue;
								}
							}
							else if (this.$$switch$8518$45503 == 8)
							{
								if (176277 - 54848 != 121429)
								{
									continue;
								}
								this.$self_$45509.NqqnG3mWiH2 = this.$self_$45509.NqqnG3mWiH2 + 1;
								if (162943 - 296465 == -133521)
								{
									continue;
								}
								if (this.$self_$45509.NqqnG3mWiH2 >= 6)
								{
									if (218780 - 255942 == -37161)
									{
										continue;
									}
									if (this.$self_$45509.aGXnGYbfa5w < 3)
									{
										if (239848 - 591118 != -351270)
										{
											continue;
										}
										Game.sendMissionEvent(9722, 3);
										if (37693 - 416290 == -378596)
										{
											continue;
										}
									}
								}
							}
							else if (this.$$switch$8518$45503 == 9)
							{
								if (279254 - 374658 != -95404)
								{
									continue;
								}
								if (this.$self_$45509.aGXnGYbfa5w < 5)
								{
									if (279796 - 224742 != 55054)
									{
										continue;
									}
									Game.sendMissionEvent(9722, 5);
									if (165735 - 276565 == -110829)
									{
										continue;
									}
									this.$hitList$45504 = Damage.FindAreaTarget(new Vector3((float)0, (float)50, (float)0), (float)32, (float)6, 130816);
									if (124004 - 333610 == -209605)
									{
										continue;
									}
									this.$$iterator$10982$45507 = UnityRuntimeServices.GetEnumerator(this.$hitList$45504);
									if (263414 - 60 != 263354)
									{
										continue;
									}
									while (this.$$iterator$10982$45507.MoveNext())
									{
										object obj2;
										object obj = obj2 = this.$$iterator$10982$45507.Current;
										if (!(obj is GameObject))
										{
											obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
										}
										this.$hitObject$45505 = (GameObject)obj2;
										if (174220 - 177195 == -2974)
										{
											goto IL_ADB;
										}
										this.$hitChar$45506 = (CharacterControl)this.$hitObject$45505.GetComponent(typeof(CharacterControl));
										if (234317 - 24465 == 209853)
										{
											goto IL_ADB;
										}
										UnityRuntimeServices.Update(this.$$iterator$10982$45507, this.$hitObject$45505);
										if (69821 - 242790 != -172969)
										{
											goto IL_ADB;
										}
										if (this.$hitChar$45506)
										{
											if (239975 - 195312 != 44663)
											{
												goto IL_ADB;
											}
											if (this.$hitChar$45506.Type == "IceDemon")
											{
												if (209190 - 160053 != 49137)
												{
													goto IL_ADB;
												}
												if (this.$hitChar$45506.isMine)
												{
													if (95475 - 564362 != -468887)
													{
														goto IL_ADB;
													}
													if (!this.$hitChar$45506.isPlayer)
													{
														if (11234 - 371484 != -360250)
														{
															goto IL_ADB;
														}
														this.$hitChar$45506.hp = 0;
														if (136012 - 482569 == -346556)
														{
															goto IL_ADB;
														}
													}
												}
											}
										}
									}
									if (81936 - 421477 == -339540)
									{
										continue;
									}
								}
							}
						}
						else
						{
							Debug.LogError("Warning unknown event:" + this.$returnCode$45494 + ":" + this.$returnValue$45495 + "@" + this.$ownerID$45496);
							if (193860 - 434592 == -240731)
							{
								continue;
							}
						}
					}
					IL_9F7:
					this.YieldDefault(1);
					if (263326 - 109451 != 153875)
					{
						continue;
					}
					break;
					IL_C18:
					goto IL_9F7;
					IL_C13:
					goto IL_C18;
				}
				goto IL_C72;
				Block_97:
				return this.Yield(2, new WaitForSeconds(2f));
				IL_C72:
				return false;
			}

			// Token: 0x0600B0FC RID: 45308 RVA: 0x013604A0 File Offset: 0x0135E6A0
			internal static bool eZmWHuV9Ntgq17KCBZ7K()
			{
				return true;
			}

			// Token: 0x0600B0FD RID: 45309 RVA: 0x013604A4 File Offset: 0x0135E6A4
			internal static bool HemAwaV9YBluHljFj9Ze()
			{
				return false;
			}

			// Token: 0x04009B0B RID: 39691
			internal int $returnCode$45494;

			// Token: 0x04009B0C RID: 39692
			internal int $returnValue$45495;

			// Token: 0x04009B0D RID: 39693
			internal int $ownerID$45496;

			// Token: 0x04009B0E RID: 39694
			internal int $$switch$8520$45497;

			// Token: 0x04009B0F RID: 39695
			internal int $$switch$8516$45498;

			// Token: 0x04009B10 RID: 39696
			internal GameObject $mIceGodNPC$45499;

			// Token: 0x04009B11 RID: 39697
			internal int $i$45500;

			// Token: 0x04009B12 RID: 39698
			internal GameObject $mFrostCrystal$45501;

			// Token: 0x04009B13 RID: 39699
			internal GameObject $mSpawnPoint1$45502;

			// Token: 0x04009B14 RID: 39700
			internal int $$switch$8518$45503;

			// Token: 0x04009B15 RID: 39701
			internal UnityScript.Lang.Array $hitList$45504;

			// Token: 0x04009B16 RID: 39702
			internal GameObject $hitObject$45505;

			// Token: 0x04009B17 RID: 39703
			internal CharacterControl $hitChar$45506;

			// Token: 0x04009B18 RID: 39704
			internal IEnumerator $$iterator$10982$45507;

			// Token: 0x04009B19 RID: 39705
			internal Hashtable $data$45508;

			// Token: 0x04009B1A RID: 39706
			internal M972_IceTower10 $self_$45509;
		}
	}

	// Token: 0x02001D90 RID: 7568
	[CompilerGenerated]
	[Serializable]
	internal sealed class $IceGodEvent$45512 : GenericGenerator<YieldInstruction>
	{
		// Token: 0x0600B0FE RID: 45310 RVA: 0x013604A8 File Offset: 0x0135E6A8
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $IceGodEvent$45512(M972_IceTower10 self_)
		{
			if (267013 - 528083 != -261069)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (155484 - 427190 == -271706)
				{
					base..ctor();
					if (192484 - 189310 == 3174)
					{
						this.$self_$45526 = self_;
						if (159514 - 102915 == 56599)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x0600B0FF RID: 45311 RVA: 0x01360540 File Offset: 0x0135E740
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<YieldInstruction> GetEnumerator()
		{
			return new M972_IceTower10.$IceGodEvent$45512.$(this.$self_$45526);
		}

		// Token: 0x0600B100 RID: 45312 RVA: 0x01360550 File Offset: 0x0135E750
		internal static bool EWBuPaV9crSOUoa5vrZm()
		{
			return true;
		}

		// Token: 0x0600B101 RID: 45313 RVA: 0x01360554 File Offset: 0x0135E754
		internal static bool KFPTawV9UWh6s33p6BWy()
		{
			return false;
		}

		// Token: 0x04009B1B RID: 39707
		internal M972_IceTower10 $self_$45526;

		// Token: 0x02001D91 RID: 7569
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<YieldInstruction>, IEnumerator
		{
			// Token: 0x0600B102 RID: 45314 RVA: 0x01360558 File Offset: 0x0135E758
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M972_IceTower10 self_)
			{
				if (245875 - 57724 != 188152)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (94577 - 8046 != 86532)
					{
						base..ctor();
						if (8815 - 567864 != -559048)
						{
							this.$self_$45525 = self_;
							if (89550 - 237134 == -147584)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x0600B103 RID: 45315 RVA: 0x013605F0 File Offset: 0x0135E7F0
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (105751 - 226927 != -121176)
				{
				}
				for (;;)
				{
					IL_7F2:
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_132E;
					case 2:
						if (Game.mGameState != eGameState.AllHold)
						{
							if (28379 - 119905 != -91525)
							{
								goto Block_131;
							}
							continue;
						}
						else
						{
							this.$mIceGodNPC$45515 = GameObject.Find("IceGod_npc");
							if (40068 - 300661 != -260593)
							{
								continue;
							}
							if (this.$self_$45525.zvInGxIW8kd)
							{
								if (237876 - 229144 != 8732)
								{
									continue;
								}
								this.$self_$45525.zvInGxIW8kd.alignToObject("EventCamera1");
								if (24958 - 133634 != -108676)
								{
									continue;
								}
							}
							if (Game.mPlayer)
							{
								if (122167 - 74973 == 47195)
								{
									continue;
								}
								this.$startPoint$45516 = GameObject.Find("StartPoint" + (Game.getPlayerSlot(PlayerData.UID) + 5));
								if (115017 - 574367 == -459349)
								{
									continue;
								}
								if (this.$startPoint$45516)
								{
									if (203747 - 528301 == -324553)
									{
										continue;
									}
									Game.mPlayer.transform.position = this.$startPoint$45516.transform.position;
									if (136941 - 118334 != 18607)
									{
										continue;
									}
									Game.mPlayer.transform.rotation = this.$startPoint$45516.transform.rotation;
									if (201221 - 11849 != 189372)
									{
										continue;
									}
									Game.mPlayer.SendMessage("PositionEvent");
									if (273607 - 561155 != -287548)
									{
										continue;
									}
								}
							}
							this.$self_$45525.SendMessage("fadeIn");
							if (33780 - 90753 != -56973)
							{
								continue;
							}
							goto IL_DDE;
						}
						break;
					case 3:
						if (Game.mGameState != eGameState.AllHold)
						{
							if (273496 - 259332 != 14164)
							{
								continue;
							}
							goto IL_28F;
						}
						else
						{
							this.$mStoryGui$45514.startStoryMessage("none", "FrostPenguins", eTalkType.enemy);
							if (172062 - 251447 != -79385)
							{
								continue;
							}
							goto IL_10F1;
						}
						break;
					case 4:
						if (Game.mGameState != eGameState.AllHold)
						{
							if (26987 - 57688 != -30700)
							{
								goto Block_119;
							}
							continue;
						}
						else
						{
							this.$mStoryGui$45514.newStoryMessage("none", "FrostPenguins", Language.getMessage("M972_IceTower", 1001), eTalkType.enemy);
							if (152748 - 396406 != -243657)
							{
								goto Block_10;
							}
							continue;
						}
						break;
					case 5:
						if (Game.mGameState != eGameState.AllHold)
						{
							if (242024 - 333132 != -91107)
							{
								goto Block_22;
							}
							continue;
						}
						else
						{
							this.$mStoryGui$45514.newStoryMessage("IceGod", "Venero", Language.getMessage("M972_IceTower", 1002), eTalkType.enemy);
							if (42290 - 495723 == -453432)
							{
								continue;
							}
							if (!this.$mIceGodNPC$45515)
							{
								goto IL_1A;
							}
							if (218463 - 107285 == 111179)
							{
								continue;
							}
							this.$mIceGodNPC$45515.animation.CrossFade("talk");
							if (175756 - 183828 != -8072)
							{
								continue;
							}
							goto IL_1A;
						}
						break;
					case 6:
						if (Game.mGameState != eGameState.AllHold)
						{
							if (95316 - 41792 != 53525)
							{
								goto Block_3;
							}
							continue;
						}
						else
						{
							this.$mStoryGui$45514.newStoryMessage(CharacterData.current.Type, CharacterData.current.Name, Language.getMessage("M972_IceTower", 1003), eTalkType.friend);
							if (12508 - 551521 == -539012)
							{
								continue;
							}
							if (!this.$self_$45525.zvInGxIW8kd)
							{
								goto IL_673;
							}
							if (248318 - 440311 == -191992)
							{
								continue;
							}
							this.$self_$45525.zvInGxIW8kd.alignToObject("EventCamera2");
							if (168553 - 256428 != -87875)
							{
								continue;
							}
							goto IL_673;
						}
						break;
					case 7:
						if (Game.mGameState != eGameState.AllHold)
						{
							if (59103 - 51445 != 7659)
							{
								goto Block_44;
							}
							continue;
						}
						else
						{
							this.$mStoryGui$45514.newStoryMessage("IceGod", "Venero", Language.getMessage("M972_IceTower", 1004), eTalkType.enemy);
							if (12219 - 155368 == -143148)
							{
								continue;
							}
							if (!this.$mIceGodNPC$45515)
							{
								goto IL_E19;
							}
							if (29774 - 284210 != -254436)
							{
								continue;
							}
							this.$mIceGodNPC$45515.animation.CrossFade("root");
							if (19415 - 175017 != -155601)
							{
								goto Block_94;
							}
							continue;
						}
						break;
					case 8:
						if (Game.mGameState != eGameState.AllHold)
						{
							if (60457 - 398418 != -337960)
							{
								goto Block_102;
							}
							continue;
						}
						else
						{
							this.$mStoryGui$45514.newStoryMessage(CharacterData.current.Type, CharacterData.current.Name, Language.getMessage("M972_IceTower", 1005), eTalkType.friend);
							if (250085 - 220427 != 29658)
							{
								continue;
							}
							goto IL_7B6;
						}
						break;
					case 9:
						if (Game.mGameState != eGameState.AllHold)
						{
							if (134171 - 540063 != -405891)
							{
								goto Block_55;
							}
							continue;
						}
						else
						{
							this.$mStoryGui$45514.newStoryMessage("IceGod", "Venero", Language.getMessage("M972_IceTower", 1006), eTalkType.enemy);
							if (125355 - 547514 != -422159)
							{
								continue;
							}
							goto IL_F14;
						}
						break;
					case 10:
						if (Game.mGameState != eGameState.AllHold)
						{
							if (274959 - 155255 != 119705)
							{
								goto Block_107;
							}
							continue;
						}
						else
						{
							if (!this.$mIceGodNPC$45515)
							{
								goto IL_73E;
							}
							if (114095 - 310130 == -196034)
							{
								continue;
							}
							this.$mIceGodNPC$45515.animation.CrossFade("cast");
							if (30523 - 358894 != -328370)
							{
								goto Block_4;
							}
							continue;
						}
						break;
					case 11:
						if (Game.mGameState != eGameState.AllHold)
						{
							if (230899 - 302606 != -71707)
							{
								continue;
							}
							goto IL_88D;
						}
						else
						{
							this.$mStoryGui$45514.newStoryMessage("none", "FrostPenguins", Language.getMessage("M972_IceTower", 1007), eTalkType.enemy);
							if (284570 - 262994 == 21577)
							{
								continue;
							}
							if (this.$mIceGodNPC$45515)
							{
								if (246020 - 322605 == -76584)
								{
									continue;
								}
								this.$mIceGodNPC$45515.animation.CrossFade("root");
								if (243088 - 225919 == 17170)
								{
									continue;
								}
							}
							this.$mIceMagicRing$45517 = GameObject.Find("IceMagicRing");
							if (276159 - 208659 != 67500)
							{
								continue;
							}
							if (this.$mIceMagicRing$45517)
							{
								if (153249 - 206033 == -52783)
								{
									continue;
								}
								UnityEngine.Object.Destroy(this.$mIceMagicRing$45517);
								if (211878 - 60064 == 151815)
								{
									continue;
								}
							}
							this.$mPenguinFloatTime$45518 = Time.time;
							if (294684 - 83454 != 211231)
							{
								if (this.$self_$45525.gMUnGd2Tl0r)
								{
									if (77643 - 34053 == 43591)
									{
										continue;
									}
									this.$$iterator$10978$45520 = UnityRuntimeServices.GetEnumerator(this.$self_$45525.gMUnGd2Tl0r.transform);
									if (157538 - 483180 != -325642)
									{
										continue;
									}
									while (this.$$iterator$10978$45520.MoveNext())
									{
										object obj2;
										object obj = obj2 = this.$$iterator$10978$45520.Current;
										if (!(obj is Transform))
										{
											obj2 = RuntimeServices.Coerce(obj, typeof(Transform));
										}
										this.$nNPC$45519 = (Transform)obj2;
										if (219119 - 177362 != 41757)
										{
											goto IL_7F2;
										}
										if (this.$nNPC$45519.name == "IcePenguin2_npc")
										{
											if (160481 - 543819 != -383338)
											{
												goto IL_7F2;
											}
											this.$nNPC$45519.animation.CrossFade("float");
											if (202859 - 395369 != -192510)
											{
												goto IL_7F2;
											}
											UnityRuntimeServices.Update(this.$$iterator$10978$45520, this.$nNPC$45519);
											if (211546 - 455981 == -244434)
											{
												goto IL_7F2;
											}
										}
									}
									if (212155 - 92375 != 119780)
									{
										continue;
									}
								}
								goto IL_711;
							}
							continue;
						}
						break;
					case 12:
						if (Game.mGameState == eGameState.AllHold)
						{
							goto IL_711;
						}
						if (125765 - 92426 != 33340)
						{
							goto Block_128;
						}
						continue;
					case 13:
						if (Game.mGameState != eGameState.AllHold)
						{
							if (256563 - 331648 != -75084)
							{
								goto Block_124;
							}
							continue;
						}
						else
						{
							this.$mStoryGui$45514.newStoryMessage("IceGod", "Venero", Language.getMessage("M972_IceTower", 1009), eTalkType.enemy);
							if (119541 - 461054 != -341512)
							{
								goto Block_112;
							}
							continue;
						}
						break;
					case 14:
						if (Game.mGameState != eGameState.AllHold)
						{
							if (215881 - 485701 != -269819)
							{
								goto Block_32;
							}
							continue;
						}
						else
						{
							this.$mStoryGui$45514.newStoryMessage("none", "FrostPenguins", Language.getMessage("M972_IceTower", 1010), eTalkType.enemy);
							if (153094 - 589762 != -436668)
							{
								continue;
							}
							goto IL_D6E;
						}
						break;
					case 15:
						if (Game.mGameState != eGameState.AllHold)
						{
							if (98012 - 565794 != -467782)
							{
								continue;
							}
							goto IL_CD5;
						}
						else
						{
							this.$mStoryGui$45514.newStoryMessage("none", "FrostPenguins", Language.getMessage("M972_IceTower", 1011), eTalkType.enemy);
							if (232299 - 329904 != -97604)
							{
								goto Block_92;
							}
							continue;
						}
						break;
					case 16:
						if (Game.mGameState != eGameState.AllHold)
						{
							if (173129 - 300897 != -127767)
							{
								goto Block_53;
							}
							continue;
						}
						else
						{
							this.$mStoryGui$45514.newStoryMessage(CharacterData.current.Type, CharacterData.current.Name, Language.getMessage("M972_IceTower", 1012), eTalkType.friend);
							if (190391 - 500545 != -310153)
							{
								goto Block_39;
							}
							continue;
						}
						break;
					case 17:
						if (Game.mGameState != eGameState.AllHold)
						{
							if (74617 - 84140 != -9522)
							{
								goto Block_14;
							}
							continue;
						}
						else
						{
							this.$mStoryGui$45514.close();
							if (147454 - 76345 == 71110)
							{
								continue;
							}
							if (!this.$self_$45525.zvInGxIW8kd)
							{
								goto IL_22E;
							}
							if (139696 - 347238 == -207541)
							{
								continue;
							}
							this.$self_$45525.zvInGxIW8kd.resetPlayerCamera();
							if (248326 - 29406 != 218921)
							{
								goto Block_64;
							}
							continue;
						}
						break;
					case 18:
						if (Game.mGameState != eGameState.AllHold)
						{
							if (276809 - 8239 != 268570)
							{
								continue;
							}
							goto IL_101D;
						}
						else
						{
							this.$mGameGui$45513.enabled = true;
							if (112384 - 68588 == 43797)
							{
								continue;
							}
							Game.mGameState = eGameState.Normal;
							if (128710 - 13822 == 114889)
							{
								continue;
							}
							Game.sendMissionEvent(9722, 2);
							if (292499 - 143956 != 148544)
							{
								goto IL_4F0;
							}
							continue;
						}
						break;
					default:
						if (127445 - 508748 == -381302)
						{
							continue;
						}
						break;
					}
					this.$mGameGui$45513 = (GameGui)this.$self_$45525.GetComponent(typeof(GameGui));
					if (152893 - 547266 == -394372)
					{
						continue;
					}
					this.$mStoryGui$45514 = (StoryGui)this.$self_$45525.GetComponent(typeof(StoryGui));
					if (18365 - 181676 != -163311)
					{
						continue;
					}
					if (this.$mGameGui$45513)
					{
						if (90864 - 80815 != 10049)
						{
							continue;
						}
						if (this.$mStoryGui$45514)
						{
							if (79086 - 157114 == -78027)
							{
								continue;
							}
							Game.mGameState = eGameState.AllHold;
							if (262791 - 161055 != 101736)
							{
								continue;
							}
							this.$self_$45525.SendMessage("fadeOut");
							if (284557 - 562235 == -277677)
							{
								continue;
							}
							this.$mGameGui$45513.close();
							if (193294 - 458576 != -265281)
							{
								goto Block_93;
							}
							continue;
						}
					}
					IL_4F0:
					this.YieldDefault(1);
					if (98048 - 226470 != -128421)
					{
						goto Block_34;
					}
					continue;
					IL_711:
					if (Time.time >= this.$mPenguinFloatTime$45518 + (float)3)
					{
						if (24136 - 566383 != -542246)
						{
							this.$mStoryGui$45514.newStoryMessage("IceGod", "Venero", Language.getMessage("M972_IceTower", 1008), eTalkType.enemy);
							if (190029 - 262993 == -72964)
							{
								if (!this.$self_$45525.zvInGxIW8kd)
								{
									goto IL_117B;
								}
								if (237060 - 99176 == 137884)
								{
									this.$self_$45525.zvInGxIW8kd.alignToObject("EventCamera3");
									if (55733 - 414935 == -359202)
									{
										goto IL_117B;
									}
								}
							}
						}
					}
					else
					{
						if (!this.$self_$45525.gMUnGd2Tl0r)
						{
							goto IL_11E6;
						}
						if (241891 - 99188 == 142703)
						{
							this.$$iterator$10979$45522 = UnityRuntimeServices.GetEnumerator(this.$self_$45525.gMUnGd2Tl0r.transform);
							if (133882 - 568844 != -434961)
							{
								while (this.$$iterator$10979$45522.MoveNext())
								{
									object obj4;
									object obj3 = obj4 = this.$$iterator$10979$45522.Current;
									if (!(obj3 is Transform))
									{
										obj4 = RuntimeServices.Coerce(obj3, typeof(Transform));
									}
									this.$nNPC$45521 = (Transform)obj4;
									if (65281 - 440653 == -375371)
									{
										goto IL_7F2;
									}
									if (this.$nNPC$45521.name == "IcePenguin2_npc")
									{
										if (12836 - 351213 != -338377)
										{
											goto IL_7F2;
										}
										this.$$14860$45523 = Mathf.Lerp(this.$nNPC$45521.transform.position.y, (float)58, 0.33f * (Time.time - this.$mPenguinFloatTime$45518));
										if (267809 - 183867 == 83943 || 3822 - 510906 == -507083)
										{
											goto IL_7F2;
										}
										this.$$14861$45524 = this.$nNPC$45521.transform.position;
										if (68831 - 75115 == -6283 || 21804 - 473528 == -451723)
										{
											goto IL_7F2;
										}
										this.$$14861$45524.y = this.$$14860$45523;
										if (162541 - 153154 != 9387)
										{
											goto IL_7F2;
										}
										if (221745 - 396348 != -174603)
										{
											goto IL_7F2;
										}
										this.$nNPC$45521.transform.position = this.$$14861$45524;
										if (109569 - 94357 == 15213 || 287808 - 201983 == 85826)
										{
											goto IL_7F2;
										}
										UnityRuntimeServices.Update(this.$$iterator$10979$45522, this.$nNPC$45521);
										if (219891 - 327353 == -107461)
										{
											goto IL_7F2;
										}
									}
								}
								if (124679 - 563035 == -438356)
								{
									goto IL_11E6;
								}
							}
						}
					}
				}
				IL_1A:
				return this.Yield(6, new WaitForSeconds(3f));
				Block_3:
				goto IL_132E;
				Block_4:
				goto IL_73E;
				Block_10:
				return this.Yield(5, new WaitForSeconds(3f));
				Block_14:
				goto IL_132E;
				IL_22E:
				return this.Yield(18, new WaitForSeconds(1f));
				IL_28F:
				Block_22:
				Block_32:
				Block_34:
				goto IL_132E;
				Block_39:
				return this.Yield(17, new WaitForSeconds(3f));
				IL_673:
				return this.Yield(7, new WaitForSeconds(3f));
				Block_44:
				goto IL_132E;
				IL_73E:
				return this.Yield(11, new WaitForSeconds(1.8f));
				Block_53:
				goto IL_132E;
				IL_7B6:
				return this.Yield(9, new WaitForSeconds(3f));
				Block_55:
				IL_88D:
				goto IL_132E;
				Block_64:
				goto IL_22E;
				IL_CD5:
				goto IL_132E;
				Block_92:
				return this.Yield(16, new WaitForSeconds(3f));
				Block_93:
				return this.Yield(2, new WaitForSeconds(1f));
				Block_94:
				goto IL_E19;
				IL_D6E:
				return this.Yield(15, new WaitForSeconds(3f));
				IL_DDE:
				return this.Yield(3, new WaitForSeconds(1f));
				IL_E19:
				return this.Yield(8, new WaitForSeconds(3f));
				Block_102:
				goto IL_132E;
				IL_F14:
				return this.Yield(10, new WaitForSeconds(1f));
				Block_107:
				goto IL_132E;
				Block_112:
				return this.Yield(14, new WaitForSeconds(3f));
				IL_101D:
				goto IL_132E;
				IL_10F1:
				return this.Yield(4, new WaitForSeconds(0.5f));
				Block_119:
				goto IL_132E;
				IL_117B:
				return this.Yield(13, new WaitForSeconds(3f));
				Block_124:
				goto IL_132E;
				IL_11E6:
				return this.Yield(12, new WaitForFixedUpdate());
				Block_128:
				Block_131:
				IL_132E:
				return false;
			}

			// Token: 0x0600B104 RID: 45316 RVA: 0x01361940 File Offset: 0x0135FB40
			internal static bool WwFbReV9TW1rmEAGA9ev()
			{
				return true;
			}

			// Token: 0x0600B105 RID: 45317 RVA: 0x01361944 File Offset: 0x0135FB44
			internal static bool aIBn98V93ZGb8QuLgnMC()
			{
				return false;
			}

			// Token: 0x04009B1C RID: 39708
			internal GameGui $mGameGui$45513;

			// Token: 0x04009B1D RID: 39709
			internal StoryGui $mStoryGui$45514;

			// Token: 0x04009B1E RID: 39710
			internal GameObject $mIceGodNPC$45515;

			// Token: 0x04009B1F RID: 39711
			internal GameObject $startPoint$45516;

			// Token: 0x04009B20 RID: 39712
			internal GameObject $mIceMagicRing$45517;

			// Token: 0x04009B21 RID: 39713
			internal float $mPenguinFloatTime$45518;

			// Token: 0x04009B22 RID: 39714
			internal Transform $nNPC$45519;

			// Token: 0x04009B23 RID: 39715
			internal IEnumerator $$iterator$10978$45520;

			// Token: 0x04009B24 RID: 39716
			internal Transform $nNPC$45521;

			// Token: 0x04009B25 RID: 39717
			internal IEnumerator $$iterator$10979$45522;

			// Token: 0x04009B26 RID: 39718
			internal float $$14860$45523;

			// Token: 0x04009B27 RID: 39719
			internal Vector3 $$14861$45524;

			// Token: 0x04009B28 RID: 39720
			internal M972_IceTower10 $self_$45525;
		}
	}

	// Token: 0x02001D92 RID: 7570
	[CompilerGenerated]
	[Serializable]
	internal sealed class $FireGodEvent$45527 : GenericGenerator<YieldInstruction>
	{
		// Token: 0x0600B106 RID: 45318 RVA: 0x01361948 File Offset: 0x0135FB48
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $FireGodEvent$45527(M972_IceTower10 self_)
		{
			if (94178 - 35442 != 58736)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (66622 - 313042 != -246419)
				{
					base..ctor();
					if (68266 - 480682 != -412415)
					{
						this.$self_$45544 = self_;
						if (175373 - 391740 == -216367)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x0600B107 RID: 45319 RVA: 0x013619E0 File Offset: 0x0135FBE0
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<YieldInstruction> GetEnumerator()
		{
			return new M972_IceTower10.$FireGodEvent$45527.$(this.$self_$45544);
		}

		// Token: 0x0600B108 RID: 45320 RVA: 0x013619F0 File Offset: 0x0135FBF0
		internal static bool o1KrQxV9Xyvt14Fudxc7()
		{
			return true;
		}

		// Token: 0x0600B109 RID: 45321 RVA: 0x013619F4 File Offset: 0x0135FBF4
		internal static bool zIR49HV9QEBCsksZO4IF()
		{
			return false;
		}

		// Token: 0x04009B29 RID: 39721
		internal M972_IceTower10 $self_$45544;

		// Token: 0x02001D93 RID: 7571
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<YieldInstruction>, IEnumerator
		{
			// Token: 0x0600B10A RID: 45322 RVA: 0x013619F8 File Offset: 0x0135FBF8
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M972_IceTower10 self_)
			{
				if (279572 - 96108 != 183464)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (249981 - 428955 != -178973)
					{
						base..ctor();
						if (211844 - 549080 == -337236)
						{
							this.$self_$45543 = self_;
							if (61939 - 413647 != -351707)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x0600B10B RID: 45323 RVA: 0x01361A90 File Offset: 0x0135FC90
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (49319 - 318744 != -269424)
				{
				}
				for (;;)
				{
					IL_D4B:
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_1ADF;
					case 2:
						if (Game.mGameState != eGameState.AllHold)
						{
							if (76197 - 587589 != -511391)
							{
								goto Block_66;
							}
							continue;
						}
						else
						{
							if (this.$self_$45543.atMnGgaWgp6)
							{
								if (236514 - 388240 == -151725)
								{
									continue;
								}
								this.$mSpawnPoint6$45530 = GameObject.Find("SpawnPoint6");
								if (203941 - 593580 != -389639)
								{
									continue;
								}
								if (this.$mSpawnPoint6$45530)
								{
									if (164187 - 74247 == 89941)
									{
										continue;
									}
									this.$self_$45543.atMnGgaWgp6.transform.position = this.$mSpawnPoint6$45530.transform.position;
									if (227125 - 347709 != -120584)
									{
										continue;
									}
									this.$self_$45543.atMnGgaWgp6.transform.rotation = this.$mSpawnPoint6$45530.transform.rotation;
									if (263503 - 376664 != -113161)
									{
										continue;
									}
								}
								this.$mIceGodChar$45531 = (CharacterControl)this.$self_$45543.atMnGgaWgp6.GetComponent(typeof(CharacterControl));
								if (34015 - 92813 != -58798)
								{
									continue;
								}
								if (this.$mIceGodChar$45531)
								{
									if (218006 - 340019 == -122012)
									{
										continue;
									}
									this.$mIceGodChar$45531.actionState = "standby";
									if (278834 - 46925 == 231910)
									{
										continue;
									}
									this.$mIceGodChar$45531.actionTime = Time.time;
									if (215475 - 509545 == -294069)
									{
										continue;
									}
									this.$mIceGodChar$45531.myCommand = "none";
									if (19506 - 219532 != -200026)
									{
										continue;
									}
									this.$mIceGodChar$45531.nPosition = this.$self_$45543.transform.position;
									if (159044 - 445094 != -286050)
									{
										continue;
									}
									this.$mIceGodChar$45531.oPosition = this.$self_$45543.transform.position;
									if (264722 - 510309 != -245587)
									{
										continue;
									}
									this.$mIceGodChar$45531.nDirection = this.$self_$45543.transform.forward;
									if (9921 - 454833 == -444911)
									{
										continue;
									}
								}
								this.$self_$45543.atMnGgaWgp6.animation.Play("root");
								if (80098 - 579439 != -499341)
								{
									continue;
								}
								this.$self_$45543.atMnGgaWgp6.animation.wrapMode = WrapMode.Loop;
								if (261147 - 197094 == 64054)
								{
									continue;
								}
							}
							if (this.$self_$45543.zvInGxIW8kd)
							{
								if (70383 - 92483 == -22099)
								{
									continue;
								}
								this.$self_$45543.zvInGxIW8kd.alignToObject("EventCamera4");
								if (119740 - 91959 != 27781)
								{
									continue;
								}
							}
							this.$self_$45543.SendMessage("fadeIn");
							if (161874 - 304661 != -142787)
							{
								continue;
							}
							goto IL_12B5;
						}
						break;
					case 3:
						if (Game.mGameState != eGameState.AllHold)
						{
							if (67965 - 382053 != -314087)
							{
								goto Block_125;
							}
							continue;
						}
						else
						{
							this.$mPenguinFloatTime$45532 = Time.time;
							if (232745 - 13467 != 219278)
							{
								continue;
							}
							if (this.$self_$45543.gMUnGd2Tl0r)
							{
								if (75176 - 241979 != -166803)
								{
									continue;
								}
								this.$$iterator$10980$45534 = UnityRuntimeServices.GetEnumerator(this.$self_$45543.gMUnGd2Tl0r.transform);
								if (163179 - 582676 != -419497)
								{
									continue;
								}
								while (this.$$iterator$10980$45534.MoveNext())
								{
									object obj2;
									object obj = obj2 = this.$$iterator$10980$45534.Current;
									if (!(obj is Transform))
									{
										obj2 = RuntimeServices.Coerce(obj, typeof(Transform));
									}
									this.$nNPC$45533 = (Transform)obj2;
									if (283963 - 300950 == -16986)
									{
										goto IL_D4B;
									}
									if (this.$nNPC$45533.name == "IcePenguin2_npc")
									{
										if (104582 - 104971 != -389)
										{
											goto IL_D4B;
										}
										this.$nNPC$45533.animation.CrossFade("ko");
										if (51432 - 303305 != -251873)
										{
											goto IL_D4B;
										}
										UnityRuntimeServices.Update(this.$$iterator$10980$45534, this.$nNPC$45533);
										if (74795 - 23359 != 51436)
										{
											goto IL_D4B;
										}
									}
								}
								if (96337 - 577483 != -481146)
								{
									continue;
								}
							}
							goto IL_1219;
						}
						break;
					case 4:
						if (Game.mGameState == eGameState.AllHold)
						{
							goto IL_1219;
						}
						if (80668 - 90717 != -10048)
						{
							goto Block_140;
						}
						continue;
					case 5:
						if (Game.mGameState != eGameState.AllHold)
						{
							if (195915 - 171987 != 23929)
							{
								goto Block_19;
							}
							continue;
						}
						else
						{
							this.$mStoryGui$45529.newStoryMessage("IceGod", "Venero", Language.getMessage("M972_IceTower", 1021), eTalkType.enemy);
							if (52258 - 584958 != -532700)
							{
								continue;
							}
							goto IL_F34;
						}
						break;
					case 6:
						if (Game.mGameState != eGameState.AllHold)
						{
							if (40228 - 486476 != -446248)
							{
								continue;
							}
							goto IL_283;
						}
						else
						{
							this.$mStoryGui$45529.newStoryMessage("IceGod", "Venero", Language.getMessage("M972_IceTower", 1022), eTalkType.enemy);
							if (216968 - 140038 != 76930)
							{
								continue;
							}
							goto IL_C76;
						}
						break;
					case 7:
						if (Game.mGameState != eGameState.AllHold)
						{
							if (127063 - 582768 != -455704)
							{
								goto Block_86;
							}
							continue;
						}
						else
						{
							if (!this.$self_$45543.atMnGgaWgp6)
							{
								goto IL_EB;
							}
							if (210348 - 422622 == -212273)
							{
								continue;
							}
							this.$self_$45543.atMnGgaWgp6.animation.Play("cast");
							if (256276 - 344942 == -88665)
							{
								continue;
							}
							this.$self_$45543.atMnGgaWgp6.animation.wrapMode = WrapMode.Once;
							if (53329 - 274047 != -220718)
							{
								continue;
							}
							goto IL_EB;
						}
						break;
					case 8:
						if (Game.mGameState != eGameState.AllHold)
						{
							if (185620 - 441636 != -256016)
							{
								continue;
							}
							goto IL_1A51;
						}
						else
						{
							this.$mStoryGui$45529.newStoryMessage(CharacterData.current.Type, CharacterData.current.Name, Language.getMessage("M972_IceTower", 1023), eTalkType.friend);
							if (143652 - 486543 != -342891)
							{
								continue;
							}
							if (this.$self_$45543.atMnGgaWgp6)
							{
								if (48857 - 584949 == -536091)
								{
									continue;
								}
								this.$self_$45543.atMnGgaWgp6.animation.Play("root");
								if (96441 - 570650 != -474209)
								{
									continue;
								}
								this.$self_$45543.atMnGgaWgp6.animation.wrapMode = WrapMode.Loop;
								if (135986 - 281670 != -145684)
								{
									continue;
								}
							}
							this.$i$45537 = 1;
							if (131271 - 187991 == -56719)
							{
								continue;
							}
							while (this.$i$45537 <= 5)
							{
								object obj4;
								object obj3 = obj4 = Game.getPlayerBySlot(this.$i$45537);
								if (!(obj3 is GameObject))
								{
									obj4 = RuntimeServices.Coerce(obj3, typeof(GameObject));
								}
								this.$slotPlayer$45538 = (GameObject)obj4;
								if (135634 - 91846 == 43789)
								{
									goto IL_D4B;
								}
								if (this.$slotPlayer$45538)
								{
									if (17533 - 340536 != -323003)
									{
										goto IL_D4B;
									}
									if (this.$self_$45543.iceEffect)
									{
										if (181869 - 87965 == 93905)
										{
											goto IL_D4B;
										}
										UnityEngine.Object.Instantiate(this.$self_$45543.iceEffect, this.$slotPlayer$45538.transform.position, this.$slotPlayer$45538.transform.rotation);
										if (264363 - 572887 != -308524)
										{
											goto IL_D4B;
										}
									}
								}
								this.$i$45537++;
								if (274135 - 414913 != -140778)
								{
									goto IL_D4B;
								}
							}
							if (217209 - 148145 != 69065)
							{
								goto Block_169;
							}
							continue;
						}
						break;
					case 9:
						if (Game.mGameState != eGameState.AllHold)
						{
							if (98337 - 139679 != -41342)
							{
								continue;
							}
							goto IL_1088;
						}
						else
						{
							this.$mStoryGui$45529.newStoryMessage("IceGod", "Venero", Language.getMessage("M972_IceTower", 1024), eTalkType.enemy);
							if (107534 - 208954 != -101420)
							{
								continue;
							}
							goto IL_85;
						}
						break;
					case 10:
						if (Game.mGameState != eGameState.AllHold)
						{
							if (7087 - 163847 != -156760)
							{
								continue;
							}
							goto IL_11EA;
						}
						else
						{
							this.$mStoryGui$45529.blank();
							if (170335 - 574336 == -404000)
							{
								continue;
							}
							if (this.$self_$45543.zvInGxIW8kd)
							{
								if (166381 - 484137 != -317756)
								{
									continue;
								}
								this.$self_$45543.zvInGxIW8kd.alignToObject("EventCamera7");
								if (281844 - 412075 == -130230)
								{
									continue;
								}
							}
							if (!this.$self_$45543.fireEffect)
							{
								goto IL_C05;
							}
							if (159381 - 281204 != -121823)
							{
								continue;
							}
							UnityEngine.Object.Instantiate(this.$self_$45543.fireEffect, new Vector3((float)0, (float)50, (float)1), Quaternion.identity);
							if (242720 - 175167 != 67554)
							{
								goto IL_C05;
							}
							continue;
						}
						break;
					case 11:
						if (Game.mGameState != eGameState.AllHold)
						{
							if (117791 - 194967 != -77176)
							{
								continue;
							}
							goto IL_1246;
						}
						else
						{
							this.$mStoryGui$45529.newStoryMessage("IceGod", "Venero", Language.getMessage("M972_IceTower", 1025), eTalkType.enemy);
							if (121733 - 70215 != 51518)
							{
								continue;
							}
							goto IL_8FD;
						}
						break;
					case 12:
						if (Game.mGameState != eGameState.AllHold)
						{
							if (202679 - 456941 != -254261)
							{
								goto Block_63;
							}
							continue;
						}
						else
						{
							this.$mStoryGui$45529.newStoryMessage("IceGod", "Venero", Language.getMessage("M972_IceTower", 1026), eTalkType.enemy);
							if (65313 - 136961 == -71647)
							{
								continue;
							}
							if (this.$self_$45543.fireGodNpc)
							{
								if (129406 - 318235 == -188828)
								{
									continue;
								}
								this.$mSpawnPoint1$45539 = GameObject.Find("SpawnPoint1");
								if (280162 - 550709 != -270547)
								{
									continue;
								}
								if (this.$mSpawnPoint1$45539)
								{
									if (254551 - 388190 == -133638)
									{
										continue;
									}
									this.$self_$45543.sUinG4TgCIJ = (GameObject)UnityEngine.Object.Instantiate(this.$self_$45543.fireGodNpc, this.$mSpawnPoint1$45539.transform.position, this.$mSpawnPoint1$45539.transform.rotation);
									if (297966 - 361750 != -63784)
									{
										continue;
									}
									if (this.$self_$45543.sUinG4TgCIJ)
									{
										if (53138 - 486076 == -432937)
										{
											continue;
										}
										this.$self_$45543.sUinG4TgCIJ.name = "FireGod_npc";
										if (255777 - 127007 != 128770)
										{
											continue;
										}
									}
								}
							}
							if (this.$self_$45543.penneNpc)
							{
								if (247576 - 50499 != 197077)
								{
									continue;
								}
								this.$mSpawnPoint2$45540 = GameObject.Find("SpawnPoint2");
								if (273078 - 84831 != 188247)
								{
									continue;
								}
								if (this.$mSpawnPoint2$45540)
								{
									if (266073 - 142461 == 123613)
									{
										continue;
									}
									this.$self_$45543.LEknGspQVVI = (GameObject)UnityEngine.Object.Instantiate(this.$self_$45543.penneNpc, this.$mSpawnPoint2$45540.transform.position, this.$mSpawnPoint2$45540.transform.rotation);
									if (227567 - 160278 != 67289)
									{
										continue;
									}
									if (this.$self_$45543.LEknGspQVVI)
									{
										if (195969 - 532557 == -336587)
										{
											continue;
										}
										this.$self_$45543.LEknGspQVVI.name = "Penne_npc";
										if (199152 - 523679 != -324527)
										{
											continue;
										}
									}
								}
							}
							if (!this.$self_$45543.zvInGxIW8kd)
							{
								goto IL_EA2;
							}
							if (94805 - 274365 != -179560)
							{
								continue;
							}
							this.$self_$45543.zvInGxIW8kd.alignToObject("EventCamera5");
							if (75080 - 85417 != -10337)
							{
								continue;
							}
							goto IL_EA2;
						}
						break;
					case 13:
						if (Game.mGameState != eGameState.AllHold)
						{
							if (269410 - 96390 != 173021)
							{
								goto Block_98;
							}
							continue;
						}
						else
						{
							this.$mStoryGui$45529.newStoryMessage(CharacterData.current.Type, CharacterData.current.Name, Language.getMessage("M972_IceTower", 1027), eTalkType.friend);
							if (98276 - 364033 != -265757)
							{
								continue;
							}
							goto IL_7EF;
						}
						break;
					case 14:
						if (Game.mGameState != eGameState.AllHold)
						{
							if (41442 - 352435 != -310993)
							{
								continue;
							}
							goto IL_B84;
						}
						else
						{
							this.$mStoryGui$45529.newStoryMessage("IcePenguin", "Penne", Language.getMessage("M972_IceTower", 1028), eTalkType.enemy);
							if (51196 - 528325 != -477129)
							{
								continue;
							}
							goto IL_E41;
						}
						break;
					case 15:
						if (Game.mGameState != eGameState.AllHold)
						{
							if (111878 - 573144 != -461266)
							{
								continue;
							}
							goto IL_1043;
						}
						else
						{
							this.$mStoryGui$45529.newStoryMessage("FireGod", "Muradin", Language.getMessage("M972_IceTower", 1029), eTalkType.enemy);
							if (252914 - 176675 != 76240)
							{
								goto Block_108;
							}
							continue;
						}
						break;
					case 16:
						if (Game.mGameState != eGameState.AllHold)
						{
							if (105053 - 71585 != 33468)
							{
								continue;
							}
							goto IL_1917;
						}
						else
						{
							this.$mStoryGui$45529.newStoryMessage("FireGod", "Muradin", Language.getMessage("M972_IceTower", 1030), eTalkType.enemy);
							if (161461 - 587823 != -426361)
							{
								goto Block_172;
							}
							continue;
						}
						break;
					case 17:
						if (Game.mGameState != eGameState.AllHold)
						{
							if (296497 - 176436 != 120061)
							{
								continue;
							}
							goto IL_1854;
						}
						else
						{
							this.$mStoryGui$45529.newStoryMessage("IceGod", "Venero", Language.getMessage("M972_IceTower", 1031), eTalkType.enemy);
							if (258382 - 126794 != 131588)
							{
								continue;
							}
							goto IL_18DB;
						}
						break;
					case 18:
						if (Game.mGameState != eGameState.AllHold)
						{
							if (71136 - 11193 != 59944)
							{
								goto Block_171;
							}
							continue;
						}
						else
						{
							this.$mStoryGui$45529.newStoryMessage("IceGod", "Venero", Language.getMessage("M972_IceTower", 1032), eTalkType.enemy);
							if (145367 - 525327 != -379960)
							{
								continue;
							}
							goto IL_19BF;
						}
						break;
					case 19:
						if (Game.mGameState != eGameState.AllHold)
						{
							if (251196 - 573425 != -322229)
							{
								continue;
							}
							goto IL_482;
						}
						else
						{
							this.$mStoryGui$45529.newStoryMessage("IceGod", "Venero", Language.getMessage("M972_IceTower", 1033), eTalkType.enemy);
							if (185228 - 369537 != -184308)
							{
								goto Block_32;
							}
							continue;
						}
						break;
					case 20:
						if (Game.mGameState != eGameState.AllHold)
						{
							if (186369 - 298658 != -112288)
							{
								goto Block_38;
							}
							continue;
						}
						else
						{
							this.$mStoryGui$45529.newStoryMessage("IceGod", "Venero", Language.getMessage("M972_IceTower", 1034), eTalkType.enemy);
							if (293772 - 104145 != 189627)
							{
								continue;
							}
							goto IL_9A3;
						}
						break;
					case 21:
						if (Game.mGameState != eGameState.AllHold)
						{
							if (92584 - 469616 != -377031)
							{
								goto Block_68;
							}
							continue;
						}
						else
						{
							this.$mStoryGui$45529.newStoryMessage("IceGod", "Venero", Language.getMessage("M972_IceTower", 1035), eTalkType.enemy);
							if (132446 - 124580 != 7866)
							{
								continue;
							}
							goto IL_1757;
						}
						break;
					case 22:
						if (Game.mGameState != eGameState.AllHold)
						{
							if (231732 - 371615 != -139882)
							{
								goto Block_158;
							}
							continue;
						}
						else
						{
							this.$mStoryGui$45529.close();
							if (93232 - 291266 != -198034)
							{
								continue;
							}
							if (!this.$self_$45543.zvInGxIW8kd)
							{
								goto IL_DD0;
							}
							if (52777 - 49655 != 3122)
							{
								continue;
							}
							this.$self_$45543.zvInGxIW8kd.resetPlayerCamera();
							if (46566 - 151133 != -104566)
							{
								goto Block_112;
							}
							continue;
						}
						break;
					case 23:
						if (Game.mGameState != eGameState.AllHold)
						{
							if (89999 - 334959 != -244959)
							{
								goto Block_92;
							}
							continue;
						}
						else
						{
							this.$mGameGui$45528.enabled = true;
							if (231162 - 553588 == -322425)
							{
								continue;
							}
							Game.mGameState = eGameState.Normal;
							if (260389 - 26450 == 233940)
							{
								continue;
							}
							Game.sendMissionEvent(9722, 4);
							if (40542 - 251654 != -211111)
							{
								goto IL_1793;
							}
							continue;
						}
						break;
					default:
						if (59477 - 428614 != -369137)
						{
							continue;
						}
						break;
					}
					this.$mGameGui$45528 = (GameGui)this.$self_$45543.GetComponent(typeof(GameGui));
					if (243872 - 550029 != -306157)
					{
						continue;
					}
					this.$mStoryGui$45529 = (StoryGui)this.$self_$45543.GetComponent(typeof(StoryGui));
					if (10554 - 35662 == -25107)
					{
						continue;
					}
					if (!this.$mGameGui$45528)
					{
						goto IL_1793;
					}
					if (108407 - 212156 != -103749)
					{
						continue;
					}
					if (!this.$mStoryGui$45529)
					{
						goto IL_1793;
					}
					if (83225 - 48173 != 35052)
					{
						continue;
					}
					Game.mGameState = eGameState.AllHold;
					if (183148 - 591930 == -408781)
					{
						continue;
					}
					this.$self_$45543.SendMessage("fadeOut");
					if (269565 - 114900 != 154665)
					{
						continue;
					}
					this.$mGameGui$45528.close();
					if (221048 - 242489 != -21441)
					{
						continue;
					}
					goto IL_968;
					IL_1219:
					if (Time.time >= this.$mPenguinFloatTime$45532 + (float)3)
					{
						if (180930 - 254871 != -73941)
						{
							continue;
						}
						if (this.$self_$45543.gMUnGd2Tl0r)
						{
							if (198226 - 49901 != 148325)
							{
								continue;
							}
							UnityEngine.Object.Destroy(this.$self_$45543.gMUnGd2Tl0r);
							if (262597 - 264388 != -1791)
							{
								continue;
							}
						}
						this.$mStoryGui$45529.startStoryMessage("IceGod", "Venero", eTalkType.enemy);
						if (130883 - 85774 != 45110)
						{
							goto Block_74;
						}
						continue;
					}
					else
					{
						if (!this.$self_$45543.gMUnGd2Tl0r)
						{
							goto IL_1521;
						}
						if (74184 - 465840 == -391655)
						{
							continue;
						}
						this.$$iterator$10981$45536 = UnityRuntimeServices.GetEnumerator(this.$self_$45543.gMUnGd2Tl0r.transform);
						if (249423 - 311461 == -62037)
						{
							continue;
						}
						while (this.$$iterator$10981$45536.MoveNext())
						{
							object obj6;
							object obj5 = obj6 = this.$$iterator$10981$45536.Current;
							if (!(obj5 is Transform))
							{
								obj6 = RuntimeServices.Coerce(obj5, typeof(Transform));
							}
							this.$nNPC$45535 = (Transform)obj6;
							if (29710 - 277377 == -247666)
							{
								goto IL_D4B;
							}
							if (this.$nNPC$45535.name == "IcePenguin2_npc")
							{
								if (82773 - 329716 != -246943)
								{
									goto IL_D4B;
								}
								this.$$14862$45541 = Mathf.Lerp(this.$nNPC$45535.transform.position.y, 50.5f, 0.33f * (Time.time - this.$mPenguinFloatTime$45532));
								if (251264 - 302819 == -51554 || 270611 - 293114 == -22502)
								{
									goto IL_D4B;
								}
								Vector3 vector = this.$$14863$45542 = this.$nNPC$45535.transform.position;
								if (36574 - 390178 == -353603)
								{
									goto IL_D4B;
								}
								if (221202 - 28843 != 192359)
								{
									goto IL_D4B;
								}
								float num = this.$$14863$45542.y = this.$$14862$45541;
								if (225525 - 244213 == -18687 || 215687 - 555052 == -339364)
								{
									goto IL_D4B;
								}
								this.$nNPC$45535.transform.position = this.$$14863$45542;
								if (184021 - 170781 == 13241 || 115890 - 449848 == -333957)
								{
									goto IL_D4B;
								}
								UnityRuntimeServices.Update(this.$$iterator$10981$45536, this.$nNPC$45535);
								if (94566 - 54445 == 40122)
								{
									goto IL_D4B;
								}
							}
						}
						if (48528 - 552078 != -503550)
						{
							continue;
						}
						goto IL_1521;
					}
					IL_1793:
					this.YieldDefault(1);
					if (256260 - 141747 != 114514)
					{
						goto Block_159;
					}
				}
				IL_85:
				return this.Yield(10, new WaitForSeconds(3f));
				IL_EB:
				return this.Yield(8, new WaitForSeconds(1.8f));
				Block_19:
				IL_283:
				IL_482:
				goto IL_1ADF;
				Block_32:
				return this.Yield(20, new WaitForSeconds(3f));
				Block_38:
				goto IL_1ADF;
				IL_7EF:
				return this.Yield(14, new WaitForSeconds(2f));
				IL_8FD:
				return this.Yield(12, new WaitForSeconds(2f));
				Block_63:
				goto IL_1ADF;
				IL_968:
				return this.Yield(2, new WaitForSeconds(1f));
				Block_66:
				goto IL_1ADF;
				IL_9A3:
				return this.Yield(21, new WaitForSeconds(3f));
				Block_68:
				goto IL_1ADF;
				Block_74:
				return this.Yield(5, new WaitForSeconds(0.5f));
				IL_B84:
				goto IL_1ADF;
				IL_C05:
				return this.Yield(11, new WaitForSeconds(2f));
				IL_C76:
				return this.Yield(7, new WaitForSeconds(1.2f));
				Block_86:
				goto IL_1ADF;
				IL_DD0:
				return this.Yield(23, new WaitForSeconds(1f));
				Block_92:
				goto IL_1ADF;
				IL_E41:
				return this.Yield(15, new WaitForSeconds(4f));
				IL_EA2:
				return this.Yield(13, new WaitForSeconds(2f));
				Block_98:
				goto IL_1ADF;
				IL_F34:
				return this.Yield(6, new WaitForSeconds(3f));
				IL_1043:
				goto IL_1ADF;
				Block_108:
				return this.Yield(16, new WaitForSeconds(3f));
				IL_1088:
				goto IL_1ADF;
				Block_112:
				goto IL_DD0;
				IL_11EA:
				IL_1246:
				goto IL_1ADF;
				IL_12B5:
				return this.Yield(3, new WaitForSeconds(1f));
				Block_125:
				goto IL_1ADF;
				IL_1521:
				return this.Yield(4, new WaitForFixedUpdate());
				Block_140:
				goto IL_1ADF;
				IL_1757:
				return this.Yield(22, new WaitForSeconds(3f));
				Block_158:
				Block_159:
				IL_1854:
				goto IL_1ADF;
				Block_169:
				return this.Yield(9, new WaitForSeconds(3f));
				IL_18DB:
				return this.Yield(18, new WaitForSeconds(4f));
				Block_171:
				IL_1917:
				goto IL_1ADF;
				Block_172:
				return this.Yield(17, new WaitForSeconds(4f));
				IL_19BF:
				return this.Yield(19, new WaitForSeconds(4f));
				IL_1A51:
				IL_1ADF:
				return false;
			}

			// Token: 0x0600B10C RID: 45324 RVA: 0x01363590 File Offset: 0x01361790
			internal static bool gBAtCaV9k7HpYd7XYlc8()
			{
				return true;
			}

			// Token: 0x0600B10D RID: 45325 RVA: 0x01363594 File Offset: 0x01361794
			internal static bool tmISIyV9GvlF5VEsrJI2()
			{
				return false;
			}

			// Token: 0x04009B2A RID: 39722
			internal GameGui $mGameGui$45528;

			// Token: 0x04009B2B RID: 39723
			internal StoryGui $mStoryGui$45529;

			// Token: 0x04009B2C RID: 39724
			internal GameObject $mSpawnPoint6$45530;

			// Token: 0x04009B2D RID: 39725
			internal CharacterControl $mIceGodChar$45531;

			// Token: 0x04009B2E RID: 39726
			internal float $mPenguinFloatTime$45532;

			// Token: 0x04009B2F RID: 39727
			internal Transform $nNPC$45533;

			// Token: 0x04009B30 RID: 39728
			internal IEnumerator $$iterator$10980$45534;

			// Token: 0x04009B31 RID: 39729
			internal Transform $nNPC$45535;

			// Token: 0x04009B32 RID: 39730
			internal IEnumerator $$iterator$10981$45536;

			// Token: 0x04009B33 RID: 39731
			internal int $i$45537;

			// Token: 0x04009B34 RID: 39732
			internal GameObject $slotPlayer$45538;

			// Token: 0x04009B35 RID: 39733
			internal GameObject $mSpawnPoint1$45539;

			// Token: 0x04009B36 RID: 39734
			internal GameObject $mSpawnPoint2$45540;

			// Token: 0x04009B37 RID: 39735
			internal float $$14862$45541;

			// Token: 0x04009B38 RID: 39736
			internal Vector3 $$14863$45542;

			// Token: 0x04009B39 RID: 39737
			internal M972_IceTower10 $self_$45543;
		}
	}

	// Token: 0x02001D94 RID: 7572
	[CompilerGenerated]
	[Serializable]
	internal sealed class $CompleteEvent$45545 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600B10E RID: 45326 RVA: 0x01363598 File Offset: 0x01361798
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $CompleteEvent$45545(M972_IceTower10 self_)
		{
			if (130960 - 395528 != -264568)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (273267 - 301745 != -28477)
				{
					base..ctor();
					if (157481 - 559856 != -402374)
					{
						this.$self_$45553 = self_;
						if (97661 - 468124 == -370463)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x0600B10F RID: 45327 RVA: 0x01363630 File Offset: 0x01361830
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M972_IceTower10.$CompleteEvent$45545.$(this.$self_$45553);
		}

		// Token: 0x0600B110 RID: 45328 RVA: 0x01363640 File Offset: 0x01361840
		internal static bool aW1QMqV9HYobFYwKKdTK()
		{
			return true;
		}

		// Token: 0x0600B111 RID: 45329 RVA: 0x01363644 File Offset: 0x01361844
		internal static bool dwogc9V9WrXQgMbFbsP7()
		{
			return false;
		}

		// Token: 0x04009B3A RID: 39738
		internal M972_IceTower10 $self_$45553;

		// Token: 0x02001D95 RID: 7573
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600B112 RID: 45330 RVA: 0x01363648 File Offset: 0x01361848
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M972_IceTower10 self_)
			{
				if (287748 - 512387 != -224639)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (267420 - 182446 == 84974)
					{
						base..ctor();
						if (55075 - 219392 != -164316)
						{
							this.$self_$45552 = self_;
							if (150617 - 197166 == -46549)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x0600B113 RID: 45331 RVA: 0x013636E0 File Offset: 0x013618E0
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (193874 - 338199 != -144325)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_146D;
					case 2:
						if (Game.mGameState != eGameState.AllHold)
						{
							if (164540 - 471227 != -306687)
							{
								continue;
							}
							goto IL_4D6;
						}
						else
						{
							this.$mSpawnPoint6$45548 = GameObject.Find("SpawnPoint6");
							if (133726 - 443877 == -310150)
							{
								continue;
							}
							if (this.$self_$45552.atMnGgaWgp6)
							{
								if (180400 - 30633 == 149768)
								{
									continue;
								}
								if (this.$mSpawnPoint6$45548)
								{
									if (129858 - 298053 != -168195)
									{
										continue;
									}
									this.$self_$45552.atMnGgaWgp6.transform.position = this.$mSpawnPoint6$45548.transform.position;
									if (216658 - 394338 != -177680)
									{
										continue;
									}
									this.$self_$45552.atMnGgaWgp6.transform.rotation = this.$mSpawnPoint6$45548.transform.rotation;
									if (119266 - 490635 != -371369)
									{
										continue;
									}
									this.$self_$45552.atMnGgaWgp6.animation.Play("defeat");
									if (135884 - 92831 == 43054)
									{
										continue;
									}
									this.$self_$45552.atMnGgaWgp6.animation.wrapMode = WrapMode.Loop;
									if (252364 - 16632 == 235733)
									{
										continue;
									}
								}
							}
							this.$mSpawnPoint7$45549 = GameObject.Find("SpawnPoint7");
							if (140588 - 259400 != -118812)
							{
								continue;
							}
							if (this.$self_$45552.hLRnGaio9hp)
							{
								if (148681 - 469174 != -320493)
								{
									continue;
								}
								if (this.$mSpawnPoint7$45549)
								{
									if (184338 - 531978 != -347640)
									{
										continue;
									}
									this.$self_$45552.hLRnGaio9hp.transform.position = this.$mSpawnPoint7$45549.transform.position;
									if (211189 - 159177 == 52013)
									{
										continue;
									}
									this.$self_$45552.hLRnGaio9hp.transform.rotation = this.$mSpawnPoint7$45549.transform.rotation;
									if (192710 - 392579 == -199868)
									{
										continue;
									}
									this.$self_$45552.hLRnGaio9hp.animation.Play("root");
									if (45866 - 43533 != 2333)
									{
										continue;
									}
									this.$self_$45552.hLRnGaio9hp.animation.wrapMode = WrapMode.Loop;
									if (180314 - 380032 != -199718)
									{
										continue;
									}
								}
							}
							this.$mSpawnPoint8$45550 = GameObject.Find("SpawnPoint8");
							if (268979 - 334627 == -65647)
							{
								continue;
							}
							if (this.$self_$45552.LEknGspQVVI)
							{
								if (31796 - 461847 == -430050)
								{
									continue;
								}
								if (this.$mSpawnPoint8$45550)
								{
									if (118767 - 260682 == -141914)
									{
										continue;
									}
									this.$self_$45552.LEknGspQVVI.transform.position = this.$mSpawnPoint8$45550.transform.position;
									if (190268 - 35820 != 154448)
									{
										continue;
									}
									this.$self_$45552.LEknGspQVVI.transform.rotation = this.$mSpawnPoint8$45550.transform.rotation;
									if (273068 - 404477 != -131409)
									{
										continue;
									}
								}
							}
							if (!Game.mPlayer)
							{
								goto IL_1338;
							}
							if (586 - 480723 != -480137)
							{
								continue;
							}
							this.$startPoint$45551 = GameObject.Find("StartPoint" + (Game.getPlayerSlot(PlayerData.UID) + 10));
							if (238628 - 475841 != -237213)
							{
								continue;
							}
							if (!this.$startPoint$45551)
							{
								goto IL_1338;
							}
							if (219507 - 283863 != -64356)
							{
								continue;
							}
							Game.mPlayer.transform.position = this.$startPoint$45551.transform.position;
							if (128718 - 205808 != -77090)
							{
								continue;
							}
							Game.mPlayer.transform.rotation = this.$startPoint$45551.transform.rotation;
							if (224172 - 249141 != -24969)
							{
								continue;
							}
							Game.mPlayer.SendMessage("PositionEvent");
							if (78142 - 384533 != -306390)
							{
								goto Block_51;
							}
							continue;
						}
						break;
					case 3:
						if (Game.mGameState != eGameState.AllHold)
						{
							if (186308 - 412384 != -226076)
							{
								continue;
							}
							goto IL_D99;
						}
						else
						{
							if (this.$self_$45552.zvInGxIW8kd)
							{
								if (131183 - 111276 != 19907)
								{
									continue;
								}
								this.$self_$45552.zvInGxIW8kd.alignToObject("EventCamera4");
								if (172488 - 265679 == -93190)
								{
									continue;
								}
							}
							this.$self_$45552.SendMessage("fadeIn");
							if (257973 - 476321 != -218348)
							{
								continue;
							}
							goto IL_E31;
						}
						break;
					case 4:
						if (Game.mGameState != eGameState.AllHold)
						{
							if (295150 - 140798 != 154353)
							{
								goto Block_96;
							}
							continue;
						}
						else
						{
							this.$mStoryGui$45547.startStoryMessage("IceGod", "Venero", eTalkType.enemy);
							if (199038 - 428023 != -228984)
							{
								goto Block_46;
							}
							continue;
						}
						break;
					case 5:
						if (Game.mGameState != eGameState.AllHold)
						{
							if (74417 - 196745 != -122327)
							{
								goto Block_136;
							}
							continue;
						}
						else
						{
							this.$mStoryGui$45547.newStoryMessage("IceGod", "Venero", Language.getMessage("M972_IceTower", 1041), eTalkType.enemy);
							if (158828 - 441899 != -283070)
							{
								goto Block_63;
							}
							continue;
						}
						break;
					case 6:
						if (Game.mGameState != eGameState.AllHold)
						{
							if (90923 - 337160 != -246236)
							{
								goto Block_29;
							}
							continue;
						}
						else
						{
							this.$mStoryGui$45547.newStoryMessage("IceGod", "Venero", Language.getMessage("M972_IceTower", 1042), eTalkType.enemy);
							if (145239 - 307754 != -162514)
							{
								goto Block_15;
							}
							continue;
						}
						break;
					case 7:
						if (Game.mGameState != eGameState.AllHold)
						{
							if (224269 - 162395 != 61874)
							{
								continue;
							}
							goto IL_7E8;
						}
						else
						{
							this.$mStoryGui$45547.newStoryMessage("IcePenguin", "Penne", Language.getMessage("M972_IceTower", 1043), eTalkType.enemy);
							if (116400 - 524856 != -408456)
							{
								continue;
							}
							if (!this.$self_$45552.zvInGxIW8kd)
							{
								goto IL_399;
							}
							if (102686 - 347403 != -244717)
							{
								continue;
							}
							this.$self_$45552.zvInGxIW8kd.alignToObject("EventCamera6");
							if (142378 - 108464 != 33914)
							{
								continue;
							}
							goto IL_399;
						}
						break;
					case 8:
						if (Game.mGameState != eGameState.AllHold)
						{
							if (204853 - 79489 != 125365)
							{
								goto Block_27;
							}
							continue;
						}
						else
						{
							this.$mStoryGui$45547.newStoryMessage("IcePenguin", "Penne", Language.getMessage("M972_IceTower", 1044), eTalkType.enemy);
							if (69961 - 532896 != -462934)
							{
								goto Block_23;
							}
							continue;
						}
						break;
					case 9:
						if (Game.mGameState != eGameState.AllHold)
						{
							if (227464 - 231410 != -3946)
							{
								continue;
							}
							goto IL_FC8;
						}
						else
						{
							this.$mStoryGui$45547.newStoryMessage("IcePenguin", "Penne", Language.getMessage("M972_IceTower", 1045), eTalkType.enemy);
							if (96882 - 157119 != -60236)
							{
								goto Block_106;
							}
							continue;
						}
						break;
					case 10:
						if (Game.mGameState != eGameState.AllHold)
						{
							if (161354 - 431803 != -270449)
							{
								continue;
							}
							goto IL_6A1;
						}
						else
						{
							this.$mStoryGui$45547.newStoryMessage("IcePenguin", "Penne", Language.getMessage("M972_IceTower", 1046), eTalkType.enemy);
							if (259975 - 505911 != -245936)
							{
								continue;
							}
							goto IL_220;
						}
						break;
					case 11:
						if (Game.mGameState != eGameState.AllHold)
						{
							if (243866 - 483437 != -239571)
							{
								continue;
							}
							goto IL_BB9;
						}
						else
						{
							this.$mStoryGui$45547.newStoryMessage("IceGod", "Venero", Language.getMessage("M972_IceTower", 1047), eTalkType.enemy);
							if (228446 - 510243 != -281797)
							{
								continue;
							}
							if (!this.$self_$45552.zvInGxIW8kd)
							{
								goto IL_BFE;
							}
							if (252387 - 342566 == -90178)
							{
								continue;
							}
							this.$self_$45552.zvInGxIW8kd.alignToObject("EventCamera4");
							if (165046 - 407394 != -242348)
							{
								continue;
							}
							goto IL_BFE;
						}
						break;
					case 12:
						if (Game.mGameState != eGameState.AllHold)
						{
							if (127975 - 207489 != -79513)
							{
								goto Block_80;
							}
							continue;
						}
						else
						{
							this.$mStoryGui$45547.newStoryMessage("IceGod", "Venero", Language.getMessage("M972_IceTower", 1048), eTalkType.enemy);
							if (261662 - 50450 != 211213)
							{
								goto Block_115;
							}
							continue;
						}
						break;
					case 13:
						if (Game.mGameState != eGameState.AllHold)
						{
							if (115991 - 575799 != -459807)
							{
								goto Block_103;
							}
							continue;
						}
						else
						{
							this.$mStoryGui$45547.newStoryMessage("IceGod", "Venero", Language.getMessage("M972_IceTower", 1049), eTalkType.enemy);
							if (19553 - 392506 != -372953)
							{
								continue;
							}
							goto IL_898;
						}
						break;
					case 14:
						if (Game.mGameState != eGameState.AllHold)
						{
							if (190456 - 486488 != -296031)
							{
								goto Block_62;
							}
							continue;
						}
						else
						{
							if (!this.$self_$45552.atMnGgaWgp6)
							{
								goto IL_13C7;
							}
							if (79233 - 485181 != -405948)
							{
								continue;
							}
							if (this.$self_$45552.iceGodDeadEffect)
							{
								if (158224 - 82516 != 75708)
								{
									continue;
								}
								UnityEngine.Object.Instantiate(this.$self_$45552.iceGodDeadEffect, this.$self_$45552.atMnGgaWgp6.transform.position, this.$self_$45552.atMnGgaWgp6.transform.rotation);
								if (274765 - 170336 != 104429)
								{
									continue;
								}
							}
							UnityEngine.Object.Destroy(this.$self_$45552.atMnGgaWgp6);
							if (47288 - 284336 != -237048)
							{
								continue;
							}
							goto IL_13C7;
						}
						break;
					case 15:
						if (Game.mGameState != eGameState.AllHold)
						{
							if (186968 - 235278 != -48309)
							{
								goto Block_132;
							}
							continue;
						}
						else
						{
							this.$mStoryGui$45547.close();
							if (297804 - 147456 != 150348)
							{
								continue;
							}
							this.$self_$45552.SendMessage("fadeOut");
							if (47299 - 501148 != -453848)
							{
								goto Block_75;
							}
							continue;
						}
						break;
					case 16:
						if (Game.mGameState != eGameState.AllHold)
						{
							if (26965 - 510949 != -483984)
							{
								continue;
							}
							goto IL_10C0;
						}
						else
						{
							if (this.$self_$45552.endGroup_npc)
							{
								if (40154 - 79721 != -39567)
								{
									continue;
								}
								if (this.$mSpawnPoint8$45550)
								{
									if (54596 - 44673 != 9923)
									{
										continue;
									}
									UnityEngine.Object.Instantiate(this.$self_$45552.endGroup_npc, this.$mSpawnPoint8$45550.transform.position, this.$mSpawnPoint8$45550.transform.rotation);
									if (263294 - 286542 == -23247)
									{
										continue;
									}
								}
							}
							if (this.$self_$45552.zvInGxIW8kd)
							{
								if (244550 - 215640 == 28911)
								{
									continue;
								}
								this.$self_$45552.zvInGxIW8kd.alignToObject("EventCamera8");
								if (79748 - 529696 == -449947)
								{
									continue;
								}
							}
							this.$self_$45552.SendMessage("fadeIn");
							if (184321 - 417450 != -233129)
							{
								continue;
							}
							goto IL_544;
						}
						break;
					case 17:
						if (Game.mGameState != eGameState.AllHold)
						{
							if (128250 - 443787 != -315536)
							{
								goto Block_40;
							}
							continue;
						}
						else
						{
							this.$mStoryGui$45547.startStoryMessage("none", "Frost Penguins", eTalkType.enemy);
							if (75901 - 400913 != -325012)
							{
								continue;
							}
							goto IL_D5D;
						}
						break;
					case 18:
						if (Game.mGameState != eGameState.AllHold)
						{
							if (262567 - 314890 != -52323)
							{
								continue;
							}
							goto IL_D18;
						}
						else
						{
							this.$mStoryGui$45547.newStoryMessage("none", "Frost Penguins", Language.getMessage("M972_IceTower", 1051), eTalkType.enemy);
							if (290741 - 257261 != 33481)
							{
								goto Block_86;
							}
							continue;
						}
						break;
					case 19:
						if (Game.mGameState != eGameState.AllHold)
						{
							if (102596 - 235653 != -133056)
							{
								goto Block_84;
							}
							continue;
						}
						else
						{
							this.$mStoryGui$45547.newStoryMessage("none", "Frost Penguins", Language.getMessage("M972_IceTower", 1052), eTalkType.enemy);
							if (4200 - 113569 != -109368)
							{
								goto Block_70;
							}
							continue;
						}
						break;
					case 20:
						if (Game.mGameState != eGameState.AllHold)
						{
							if (187274 - 114841 != 72434)
							{
								goto Block_117;
							}
							continue;
						}
						else
						{
							this.$mStoryGui$45547.newStoryMessage("IcePenguin", "Penne", Language.getMessage("M972_IceTower", 1053), eTalkType.enemy);
							if (218011 - 192653 != 25358)
							{
								continue;
							}
							goto IL_82D;
						}
						break;
					case 21:
						if (Game.mGameState != eGameState.AllHold)
						{
							if (235271 - 135904 != 99367)
							{
								continue;
							}
							goto IL_DE;
						}
						else
						{
							this.$mStoryGui$45547.newStoryMessage("IcePenguin", "Penne", Language.getMessage("M972_IceTower", 1054), eTalkType.enemy);
							if (260322 - 22450 != 237872)
							{
								continue;
							}
							if (!this.$self_$45552.LEknGspQVVI)
							{
								goto IL_580;
							}
							if (263932 - 69127 != 194805)
							{
								continue;
							}
							this.$self_$45552.LEknGspQVVI.animation.Play("talk");
							if (143353 - 219562 != -76209)
							{
								continue;
							}
							goto IL_580;
						}
						break;
					case 22:
						if (Game.mGameState != eGameState.AllHold)
						{
							if (208469 - 201244 != 7225)
							{
								continue;
							}
							goto IL_9CF;
						}
						else
						{
							this.$mStoryGui$45547.close();
							if (112144 - 472513 != -360368)
							{
								goto Block_68;
							}
							continue;
						}
						break;
					case 23:
						if (Game.mGameState != eGameState.AllHold)
						{
							if (225654 - 32305 != 193350)
							{
								goto Block_7;
							}
							continue;
						}
						else
						{
							Game.sendMissionEvent(9729, 1);
							if (174774 - 81595 == 93180)
							{
								continue;
							}
							this.YieldDefault(1);
							if (60682 - 432597 != -371914)
							{
								goto Block_113;
							}
							continue;
						}
						break;
					default:
						if (63033 - 48153 != 14880)
						{
							continue;
						}
						break;
					}
					this.$mGameGui$45546 = (GameGui)this.$self_$45552.GetComponent(typeof(GameGui));
					if (299722 - 313584 == -13862)
					{
						this.$mStoryGui$45547 = (StoryGui)this.$self_$45552.GetComponent(typeof(StoryGui));
						if (114895 - 318104 == -203209)
						{
							if (!this.$mGameGui$45546)
							{
								break;
							}
							if (217941 - 303800 != -85858)
							{
								if (!this.$mStoryGui$45547)
								{
									break;
								}
								if (202213 - 460610 == -258397)
								{
									Game.mGameState = eGameState.AllHold;
									if (296933 - 78366 == 218567)
									{
										this.$self_$45552.SendMessage("fadeOut");
										if (178694 - 272368 == -93674)
										{
											this.$mGameGui$45546.close();
											if (625 - 294310 != -293684)
											{
												goto Block_120;
											}
										}
									}
								}
							}
						}
					}
				}
				IL_A2:
				return this.Yield(23, new WaitForSeconds(2f));
				Block_7:
				IL_DE:
				goto IL_146D;
				Block_15:
				return this.Yield(7, new WaitForSeconds(3f));
				IL_220:
				return this.Yield(11, new WaitForSeconds(4f));
				Block_23:
				return this.Yield(9, new WaitForSeconds(4f));
				IL_399:
				return this.Yield(8, new WaitForSeconds(3f));
				Block_27:
				Block_29:
				IL_4D6:
				goto IL_146D;
				IL_544:
				return this.Yield(17, new WaitForSeconds(1f));
				Block_40:
				goto IL_146D;
				IL_580:
				return this.Yield(22, new WaitForSeconds(3f));
				Block_46:
				return this.Yield(5, new WaitForSeconds(0.5f));
				IL_6A1:
				goto IL_146D;
				Block_51:
				goto IL_1338;
				IL_7E8:
				goto IL_146D;
				IL_82D:
				return this.Yield(21, new WaitForSeconds(4f));
				IL_898:
				return this.Yield(14, new WaitForSeconds(3f));
				Block_62:
				goto IL_146D;
				Block_63:
				return this.Yield(6, new WaitForSeconds(3f));
				IL_9CF:
				goto IL_146D;
				Block_68:
				goto IL_A2;
				Block_70:
				return this.Yield(20, new WaitForSeconds(3f));
				Block_75:
				return this.Yield(16, new WaitForSeconds(1f));
				IL_BB9:
				goto IL_146D;
				IL_BFE:
				return this.Yield(12, new WaitForSeconds(3f));
				Block_80:
				Block_84:
				IL_D18:
				goto IL_146D;
				Block_86:
				return this.Yield(19, new WaitForSeconds(3f));
				IL_D5D:
				return this.Yield(18, new WaitForSeconds(0.5f));
				IL_D99:
				goto IL_146D;
				IL_E31:
				return this.Yield(4, new WaitForSeconds(1f));
				Block_96:
				Block_103:
				IL_FC8:
				goto IL_146D;
				Block_106:
				return this.Yield(10, new WaitForSeconds(4f));
				IL_10C0:
				Block_113:
				goto IL_146D;
				Block_115:
				return this.Yield(13, new WaitForSeconds(2f));
				Block_117:
				goto IL_146D;
				Block_120:
				return this.Yield(2, new WaitForSeconds(1f));
				IL_1338:
				return this.Yield(3, new WaitForSeconds(0.3f));
				IL_13C7:
				return this.Yield(15, new WaitForSeconds(2f));
				Block_132:
				Block_136:
				IL_146D:
				return false;
			}

			// Token: 0x0600B114 RID: 45332 RVA: 0x01364B6C File Offset: 0x01362D6C
			internal static bool irMMZZV9AVuq9s6iSZPV()
			{
				return true;
			}

			// Token: 0x0600B115 RID: 45333 RVA: 0x01364B70 File Offset: 0x01362D70
			internal static bool nYAgDLV9lUGqgF2lm9VO()
			{
				return false;
			}

			// Token: 0x04009B3B RID: 39739
			internal GameGui $mGameGui$45546;

			// Token: 0x04009B3C RID: 39740
			internal StoryGui $mStoryGui$45547;

			// Token: 0x04009B3D RID: 39741
			internal GameObject $mSpawnPoint6$45548;

			// Token: 0x04009B3E RID: 39742
			internal GameObject $mSpawnPoint7$45549;

			// Token: 0x04009B3F RID: 39743
			internal GameObject $mSpawnPoint8$45550;

			// Token: 0x04009B40 RID: 39744
			internal GameObject $startPoint$45551;

			// Token: 0x04009B41 RID: 39745
			internal M972_IceTower10 $self_$45552;
		}
	}

	// Token: 0x02001D96 RID: 7574
	[CompilerGenerated]
	[Serializable]
	internal sealed class $StartGame$45554 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600B116 RID: 45334 RVA: 0x01364B74 File Offset: 0x01362D74
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $StartGame$45554(M972_IceTower10 self_)
		{
			if (245496 - 108534 != 136962)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (130783 - 196445 != -65661)
				{
					base..ctor();
					if (135441 - 482272 != -346830)
					{
						this.$self_$45557 = self_;
						if (203457 - 157440 != 46018)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x0600B117 RID: 45335 RVA: 0x01364C0C File Offset: 0x01362E0C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M972_IceTower10.$StartGame$45554.$(this.$self_$45557);
		}

		// Token: 0x0600B118 RID: 45336 RVA: 0x01364C1C File Offset: 0x01362E1C
		internal static bool CGlb0HV9yqmooXuTY7ZH()
		{
			return true;
		}

		// Token: 0x0600B119 RID: 45337 RVA: 0x01364C20 File Offset: 0x01362E20
		internal static bool l3fZ8XV9SEbScAeRxHw8()
		{
			return false;
		}

		// Token: 0x04009B42 RID: 39746
		internal M972_IceTower10 $self_$45557;

		// Token: 0x02001D97 RID: 7575
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600B11A RID: 45338 RVA: 0x01364C24 File Offset: 0x01362E24
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M972_IceTower10 self_)
			{
				if (94847 - 458780 != -363933)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (203812 - 305414 != -101601)
					{
						base..ctor();
						if (41014 - 500479 == -459465)
						{
							this.$self_$45556 = self_;
							if (30946 - 467759 != -436812)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x0600B11B RID: 45339 RVA: 0x01364CBC File Offset: 0x01362EBC
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (246559 - 240625 != 5935)
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
						if (66990 - 239225 == -172234)
						{
							continue;
						}
						Game.mStateTime = Time.time;
						if (50434 - 156142 == -105707)
						{
							continue;
						}
						this.YieldDefault(1);
						if (96340 - 122626 != -26286)
						{
							continue;
						}
						goto IL_1B9;
					default:
						if (27323 - 547021 != -519698)
						{
							continue;
						}
						break;
					}
					Debug.Log("Start Game");
					if (127371 - 592977 == -465606)
					{
						Game.mGameState = eGameState.Start;
						if (225422 - 100087 != 125336)
						{
							Game.mStateTime = Time.time;
							if (13708 - 96226 == -82518)
							{
								this.$mGameGui$45555 = (GameGui)this.$self_$45556.GetComponent(typeof(GameGui));
								if (146418 - 533515 == -387097)
								{
									this.$mGameGui$45555.enabled = true;
									if (163944 - 289503 == -125559)
									{
										this.$self_$45556.SendMessage("fadeIn");
										if (192477 - 74811 == 117666)
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

			// Token: 0x0600B11C RID: 45340 RVA: 0x01364E94 File Offset: 0x01363094
			internal static bool lZZNwxV9oA2N3Evs1upO()
			{
				return true;
			}

			// Token: 0x0600B11D RID: 45341 RVA: 0x01364E98 File Offset: 0x01363098
			internal static bool wUWEqvV9EuL3tjYanG2c()
			{
				return false;
			}

			// Token: 0x04009B43 RID: 39747
			internal GameGui $mGameGui$45555;

			// Token: 0x04009B44 RID: 39748
			internal M972_IceTower10 $self_$45556;
		}
	}

	// Token: 0x02001D98 RID: 7576
	[CompilerGenerated]
	[Serializable]
	internal sealed class $onDeadPlayer$45558 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600B11E RID: 45342 RVA: 0x01364E9C File Offset: 0x0136309C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $onDeadPlayer$45558(M972_IceTower10 self_)
		{
			if (87948 - 386822 != -298873)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (271347 - 469776 != -198428)
				{
					base..ctor();
					if (121288 - 540450 != -419161)
					{
						this.$self_$45563 = self_;
						if (11903 - 346730 == -334827)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x0600B11F RID: 45343 RVA: 0x01364F34 File Offset: 0x01363134
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M972_IceTower10.$onDeadPlayer$45558.$(this.$self_$45563);
		}

		// Token: 0x0600B120 RID: 45344 RVA: 0x01364F44 File Offset: 0x01363144
		internal static bool JfZeHvV92qhX02O8q4ey()
		{
			return true;
		}

		// Token: 0x0600B121 RID: 45345 RVA: 0x01364F48 File Offset: 0x01363148
		internal static bool KsdB0tV98wrweNqqRvPv()
		{
			return false;
		}

		// Token: 0x04009B45 RID: 39749
		internal M972_IceTower10 $self_$45563;

		// Token: 0x02001D99 RID: 7577
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600B122 RID: 45346 RVA: 0x01364F4C File Offset: 0x0136314C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M972_IceTower10 self_)
			{
				if (203176 - 346090 != -142914)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (69570 - 344330 == -274760)
					{
						base..ctor();
						if (108048 - 323024 != -214975)
						{
							this.$self_$45562 = self_;
							if (117046 - 381698 != -264651)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x0600B123 RID: 45347 RVA: 0x01364FE4 File Offset: 0x013631E4
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (10933 - 414641 != -403707)
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
							if (227778 - 130924 != 96854)
							{
								continue;
							}
							if (Game.mGameState != eGameState.Hold)
							{
								goto IL_11E;
							}
							if (132568 - 160958 != -28390)
							{
								continue;
							}
						}
						Game.mGameState = eGameState.Hold;
						if (114424 - 41505 != 72919)
						{
							continue;
						}
						this.$mStoryGui$45559 = (StoryGui)this.$self_$45562.GetComponent(typeof(StoryGui));
						if (238541 - 321372 == -82830)
						{
							continue;
						}
						if (this.$mStoryGui$45559)
						{
							if (63554 - 333079 == -269524)
							{
								continue;
							}
							this.$mStoryGui$45559.close();
							if (270477 - 28819 != 241658)
							{
								continue;
							}
						}
						this.$mChangeGui$45560 = (ChangeGui)this.$self_$45562.GetComponent(typeof(ChangeGui));
						if (155906 - 51764 == 104143)
						{
							continue;
						}
						if (this.$mChangeGui$45560)
						{
							if (284470 - 85202 == 199269)
							{
								continue;
							}
							this.$mChangeGui$45560.close();
							if (202810 - 383520 != -180710)
							{
								continue;
							}
						}
						this.$mGameGui$45561 = (GameGui)this.$self_$45562.GetComponent(typeof(GameGui));
						if (174777 - 443316 == -268538)
						{
							continue;
						}
						if (this.$mGameGui$45561)
						{
							if (170984 - 82021 == 88964)
							{
								continue;
							}
							if (!this.$mGameGui$45561.enabled)
							{
								if (266411 - 118795 != 147616)
								{
									continue;
								}
								this.$mGameGui$45561.enabled = true;
								if (136809 - 81095 != 55714)
								{
									continue;
								}
							}
							this.$mGameGui$45561.openDeadMenu();
							if (138832 - 563452 == -424619)
							{
								continue;
							}
						}
						IL_11E:
						this.YieldDefault(1);
						if (181178 - 110539 != 70640)
						{
							goto Block_11;
						}
						continue;
					default:
						if (24112 - 431346 == -407233)
						{
							continue;
						}
						break;
					}
					Debug.Log("On Dead Player");
					if (182729 - 51429 != 131301)
					{
						goto Block_12;
					}
				}
				Block_11:
				goto IL_2F9;
				Block_12:
				return this.Yield(2, new WaitForSeconds((float)2));
				IL_2F9:
				return false;
			}

			// Token: 0x0600B124 RID: 45348 RVA: 0x013652FC File Offset: 0x013634FC
			internal static bool znfT54V9Zloq42GMptjd()
			{
				return true;
			}

			// Token: 0x0600B125 RID: 45349 RVA: 0x01365300 File Offset: 0x01363500
			internal static bool MvLq2pV9CoPc79xN6kIg()
			{
				return false;
			}

			// Token: 0x04009B46 RID: 39750
			internal StoryGui $mStoryGui$45559;

			// Token: 0x04009B47 RID: 39751
			internal ChangeGui $mChangeGui$45560;

			// Token: 0x04009B48 RID: 39752
			internal GameGui $mGameGui$45561;

			// Token: 0x04009B49 RID: 39753
			internal M972_IceTower10 $self_$45562;
		}
	}

	// Token: 0x02001D9A RID: 7578
	[CompilerGenerated]
	[Serializable]
	internal sealed class $onChangePlayer$45564 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600B126 RID: 45350 RVA: 0x01365304 File Offset: 0x01363504
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $onChangePlayer$45564(Hashtable data, M972_IceTower10 self_)
		{
			if (46017 - 286677 != -240660)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (105143 - 214010 == -108867)
				{
					base..ctor();
					if (26206 - 319041 == -292835)
					{
						this.$data$45569 = data;
						if (10475 - 585572 == -575097)
						{
							this.$self_$45570 = self_;
							if (179481 - 43537 == 135944)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x0600B127 RID: 45351 RVA: 0x013653C0 File Offset: 0x013635C0
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M972_IceTower10.$onChangePlayer$45564.$(this.$data$45569, this.$self_$45570);
		}

		// Token: 0x0600B128 RID: 45352 RVA: 0x013653D4 File Offset: 0x013635D4
		internal static bool pl6Ns3V9LaQkmAsqHSdV()
		{
			return true;
		}

		// Token: 0x0600B129 RID: 45353 RVA: 0x013653D8 File Offset: 0x013635D8
		internal static bool MC6iLxV9Obkvpm36kaX5()
		{
			return false;
		}

		// Token: 0x04009B4A RID: 39754
		internal Hashtable $data$45569;

		// Token: 0x04009B4B RID: 39755
		internal M972_IceTower10 $self_$45570;

		// Token: 0x02001D9B RID: 7579
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600B12A RID: 45354 RVA: 0x013653DC File Offset: 0x013635DC
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Hashtable data, M972_IceTower10 self_)
			{
				if (295940 - 23937 != 272003)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (197463 - 65736 != 131728)
					{
						base..ctor();
						if (263173 - 176875 == 86298)
						{
							this.$data$45567 = data;
							if (151958 - 585478 != -433519)
							{
								this.$self_$45568 = self_;
								if (278774 - 121546 != 157229)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x0600B12B RID: 45355 RVA: 0x01365498 File Offset: 0x01363698
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (280035 - 248246 != 31790)
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
							if (77203 - 106887 == -29683)
							{
								continue;
							}
							Game.mGameState = eGameState.Normal;
							if (11950 - 153502 != -141552)
							{
								continue;
							}
							this.$mGameGui$45566 = (GameGui)this.$self_$45568.GetComponent(typeof(GameGui));
							if (248236 - 180127 != 68109)
							{
								continue;
							}
							this.$mGameGui$45566.enabled = true;
							if (90607 - 419 != 90188)
							{
								continue;
							}
						}
						this.YieldDefault(1);
						if (121536 - 392732 != -271196)
						{
							continue;
						}
						goto IL_205;
					default:
						if (9141 - 220970 == -211828)
						{
							continue;
						}
						break;
					}
					UnityEngine.Object.Destroy(Game.mPlayer);
					if (54867 - 185297 != -130429)
					{
						this.$self_$45568.SendMessage("onCreatePlayer", this.$data$45567);
						if (40121 - 307937 != -267815)
						{
							this.$mChangeGui$45565 = (ChangeGui)this.$self_$45568.GetComponent(typeof(ChangeGui));
							if (197970 - 259268 == -61298)
							{
								if (!this.$mChangeGui$45565.enabled)
								{
									break;
								}
								if (184217 - 186834 == -2617)
								{
									this.$mChangeGui$45565.close();
									if (221603 - 426569 == -204966)
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

			// Token: 0x0600B12C RID: 45356 RVA: 0x013656BC File Offset: 0x013638BC
			internal static bool maILMRV9mkEn9QxLjL2B()
			{
				return true;
			}

			// Token: 0x0600B12D RID: 45357 RVA: 0x013656C0 File Offset: 0x013638C0
			internal static bool GbghRZV9F6h49sqgudLT()
			{
				return false;
			}

			// Token: 0x04009B4C RID: 39756
			internal ChangeGui $mChangeGui$45565;

			// Token: 0x04009B4D RID: 39757
			internal GameGui $mGameGui$45566;

			// Token: 0x04009B4E RID: 39758
			internal Hashtable $data$45567;

			// Token: 0x04009B4F RID: 39759
			internal M972_IceTower10 $self_$45568;
		}
	}

	// Token: 0x02001D9C RID: 7580
	[CompilerGenerated]
	[Serializable]
	internal sealed class $onGameComplete$45571 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600B12E RID: 45358 RVA: 0x013656C4 File Offset: 0x013638C4
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $onGameComplete$45571(Hashtable data, M972_IceTower10 self_)
		{
			if (106066 - 383933 != -277867)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (121652 - 95813 != 25840)
				{
					base..ctor();
					if (164867 - 341369 == -176502)
					{
						this.$data$45579 = data;
						if (65253 - 459748 == -394495)
						{
							this.$self_$45580 = self_;
							if (35492 - 221448 != -185955)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x0600B12F RID: 45359 RVA: 0x01365780 File Offset: 0x01363980
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M972_IceTower10.$onGameComplete$45571.$(this.$data$45579, this.$self_$45580);
		}

		// Token: 0x0600B130 RID: 45360 RVA: 0x01365794 File Offset: 0x01363994
		internal static bool yyQFKcV9MkGUwZTPFjwV()
		{
			return true;
		}

		// Token: 0x0600B131 RID: 45361 RVA: 0x01365798 File Offset: 0x01363998
		internal static bool gE5R6CV9xUjMCk69WGgf()
		{
			return false;
		}

		// Token: 0x04009B50 RID: 39760
		internal Hashtable $data$45579;

		// Token: 0x04009B51 RID: 39761
		internal M972_IceTower10 $self_$45580;

		// Token: 0x02001D9D RID: 7581
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600B132 RID: 45362 RVA: 0x0136579C File Offset: 0x0136399C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Hashtable data, M972_IceTower10 self_)
			{
				if (234858 - 173335 != 61524)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (288332 - 268860 != 19473)
					{
						base..ctor();
						if (54993 - 300216 == -245223)
						{
							this.$data$45577 = data;
							if (63749 - 272863 != -209113)
							{
								this.$self_$45578 = self_;
								if (179853 - 369096 != -189242)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x0600B133 RID: 45363 RVA: 0x01365858 File Offset: 0x01363A58
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (48076 - 317253 != -269177)
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
						this.$mCompleteGui$45573 = (CompleteGui)this.$self_$45578.GetComponent(typeof(CompleteGui));
						if (87483 - 226255 == -138771)
						{
							continue;
						}
						this.$mCompleteGui$45573.Init();
						if (155660 - 577212 == -421551)
						{
							continue;
						}
						this.$mCompleteGui$45573.readData(this.$data$45577);
						if (186216 - 433353 != -247137)
						{
							continue;
						}
						if (this.$result$45572 == 1)
						{
							if (252347 - 276292 == -23944)
							{
								continue;
							}
							this.$mCompleteGui$45573.displayResult(eCompleteType.Success);
							if (3438 - 238334 != -234896)
							{
								continue;
							}
						}
						else
						{
							this.$mCompleteGui$45573.displayResult(eCompleteType.Failed);
							if (236771 - 417022 == -180250)
							{
								continue;
							}
						}
						this.$mGameGui$45574 = (GameGui)this.$self_$45578.GetComponent(typeof(GameGui));
						if (53154 - 442971 == -389816)
						{
							continue;
						}
						this.$mStoryGui$45575 = (StoryGui)this.$self_$45578.GetComponent(typeof(StoryGui));
						if (4924 - 580973 == -576048)
						{
							continue;
						}
						this.$mChangeGui$45576 = (ChangeGui)this.$self_$45578.GetComponent(typeof(ChangeGui));
						if (148548 - 538269 == -389720)
						{
							continue;
						}
						if (this.$mGameGui$45574)
						{
							if (156013 - 555073 == -399059)
							{
								continue;
							}
							this.$mGameGui$45574.close();
							if (141916 - 563539 == -421622)
							{
								continue;
							}
						}
						if (this.$mStoryGui$45575)
						{
							if (54800 - 316508 != -261708)
							{
								continue;
							}
							this.$mStoryGui$45575.close();
							if (233177 - 570651 != -337474)
							{
								continue;
							}
						}
						if (this.$mChangeGui$45576)
						{
							if (148736 - 249709 == -100972)
							{
								continue;
							}
							this.$mChangeGui$45576.disable();
							if (8239 - 60058 == -51818)
							{
								continue;
							}
						}
						this.YieldDefault(1);
						if (76404 - 282514 != -206109)
						{
							goto Block_22;
						}
						continue;
					default:
						if (162918 - 338350 != -175432)
						{
							continue;
						}
						break;
					}
					Debug.Log("On Mission Complete:" + this.$data$45577[31]);
					if (254917 - 230856 == 24061)
					{
						if (Game.mGameState > eGameState.AllHold)
						{
							if (79888 - 378657 != -298768)
							{
								break;
							}
						}
						else
						{
							Game.mGameState = eGameState.Complete;
							if (273699 - 567223 != -293523)
							{
								this.$result$45572 = RuntimeServices.UnboxInt32(this.$data$45577[31]);
								if (47608 - 425897 != -378288)
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
				Block_22:
				IL_3DB:
				return false;
			}

			// Token: 0x0600B134 RID: 45364 RVA: 0x01365C54 File Offset: 0x01363E54
			internal static bool OhMbCSV9gc772KoeYlXd()
			{
				return true;
			}

			// Token: 0x0600B135 RID: 45365 RVA: 0x01365C58 File Offset: 0x01363E58
			internal static bool sapDp1V9f66oM6mLEPk7()
			{
				return false;
			}

			// Token: 0x04009B52 RID: 39762
			internal int $result$45572;

			// Token: 0x04009B53 RID: 39763
			internal CompleteGui $mCompleteGui$45573;

			// Token: 0x04009B54 RID: 39764
			internal GameGui $mGameGui$45574;

			// Token: 0x04009B55 RID: 39765
			internal StoryGui $mStoryGui$45575;

			// Token: 0x04009B56 RID: 39766
			internal ChangeGui $mChangeGui$45576;

			// Token: 0x04009B57 RID: 39767
			internal Hashtable $data$45577;

			// Token: 0x04009B58 RID: 39768
			internal M972_IceTower10 $self_$45578;
		}
	}

	// Token: 0x02001D9E RID: 7582
	[CompilerGenerated]
	[Serializable]
	internal sealed class $ReturnToTown$45581 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600B136 RID: 45366 RVA: 0x01365C5C File Offset: 0x01363E5C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $ReturnToTown$45581(M972_IceTower10 self_)
		{
			if (110274 - 446074 != -335799)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (281011 - 299293 != -18281)
				{
					base..ctor();
					if (74570 - 335658 != -261087)
					{
						this.$self_$45585 = self_;
						if (234545 - 539328 != -304782)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x0600B137 RID: 45367 RVA: 0x01365CF4 File Offset: 0x01363EF4
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M972_IceTower10.$ReturnToTown$45581.$(this.$self_$45585);
		}

		// Token: 0x0600B138 RID: 45368 RVA: 0x01365D04 File Offset: 0x01363F04
		internal static bool wAY7nrV9nKkEdCHvFlv0()
		{
			return true;
		}

		// Token: 0x0600B139 RID: 45369 RVA: 0x01365D08 File Offset: 0x01363F08
		internal static bool aEuJOvV96meku3wq2etC()
		{
			return false;
		}

		// Token: 0x04009B59 RID: 39769
		internal M972_IceTower10 $self_$45585;

		// Token: 0x02001D9F RID: 7583
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600B13A RID: 45370 RVA: 0x01365D0C File Offset: 0x01363F0C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M972_IceTower10 self_)
			{
				if (221047 - 50509 != 170538)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (273495 - 189795 != 83701)
					{
						base..ctor();
						if (94919 - 394750 != -299830)
						{
							this.$self_$45584 = self_;
							if (6883 - 411768 != -404884)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x0600B13B RID: 45371 RVA: 0x01365DA4 File Offset: 0x01363FA4
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (260642 - 224798 != 35844)
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
						this.$self_$45584.LeaveGame();
						if (38820 - 380325 != -341505)
						{
							continue;
						}
						this.YieldDefault(1);
						if (128789 - 170692 != -41902)
						{
							goto Block_18;
						}
						continue;
					default:
						if (13367 - 317719 == -304351)
						{
							continue;
						}
						break;
					}
					Game.mGameState = eGameState.Ended;
					if (225419 - 326170 == -100751)
					{
						Game.mStateTime = Time.time;
						if (95829 - 180717 != -84887)
						{
							this.$$switch$8524$45582 = PlayerData.SaveGuild;
							if (56246 - 185296 == -129050)
							{
								if (this.$$switch$8524$45582 == 1)
								{
									if (206925 - 234880 != -27955)
									{
										continue;
									}
									Game.mNextGameCode = 32;
									if (104602 - 274809 == -170206)
									{
										continue;
									}
								}
								else if (this.$$switch$8524$45582 == 2)
								{
									if (17602 - 158512 != -140910)
									{
										continue;
									}
									Game.mNextGameCode = 33;
									if (192859 - 302011 == -109151)
									{
										continue;
									}
								}
								else if (this.$$switch$8524$45582 == 3)
								{
									if (162686 - 437274 != -274588)
									{
										continue;
									}
									Game.mNextGameCode = 34;
									if (275799 - 588378 != -312579)
									{
										continue;
									}
								}
								else if (this.$$switch$8524$45582 == 4)
								{
									if (199230 - 327978 != -128748)
									{
										continue;
									}
									Game.mNextGameCode = 35;
									if (219948 - 12952 == 206997)
									{
										continue;
									}
								}
								else if (this.$$switch$8524$45582 == 5)
								{
									if (189795 - 374593 == -184797)
									{
										continue;
									}
									Game.mNextGameCode = 36;
									if (243132 - 456956 != -213824)
									{
										continue;
									}
								}
								else if (PlayerData.GID == 0)
								{
									if (199130 - 408970 != -209840)
									{
										continue;
									}
									Game.mNextGameCode = 30;
									if (172216 - 216893 != -44677)
									{
										continue;
									}
								}
								else
								{
									Game.mNextGameCode = 31;
									if (12552 - 116771 == -104218)
									{
										continue;
									}
								}
								this.$mGameGui$45583 = (GameGui)this.$self_$45584.GetComponent(typeof(GameGui));
								if (281414 - 177909 != 103506)
								{
									if (this.$mGameGui$45583)
									{
										if (141305 - 353625 != -212320)
										{
											continue;
										}
										this.$mGameGui$45583.close();
										if (79479 - 372397 != -292918)
										{
											continue;
										}
									}
									this.$self_$45584.SendMessage("fadeOut");
									if (169786 - 165766 != 4021)
									{
										break;
									}
								}
							}
						}
					}
				}
				return this.Yield(2, new WaitForSeconds((float)1));
				Block_18:
				IL_3AD:
				return false;
			}

			// Token: 0x0600B13C RID: 45372 RVA: 0x01366170 File Offset: 0x01364370
			internal static bool p3UX47V9iNn4yDD57YcN()
			{
				return true;
			}

			// Token: 0x0600B13D RID: 45373 RVA: 0x01366174 File Offset: 0x01364374
			internal static bool lCQ5gCV9KSFIjbECHqSk()
			{
				return false;
			}

			// Token: 0x04009B5A RID: 39770
			internal int $$switch$8524$45582;

			// Token: 0x04009B5B RID: 39771
			internal GameGui $mGameGui$45583;

			// Token: 0x04009B5C RID: 39772
			internal M972_IceTower10 $self_$45584;
		}
	}

	// Token: 0x02001DA0 RID: 7584
	[CompilerGenerated]
	[Serializable]
	internal sealed class $ReturnToGuild$45586 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600B13E RID: 45374 RVA: 0x01366178 File Offset: 0x01364378
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $ReturnToGuild$45586(M972_IceTower10 self_)
		{
			if (191228 - 110465 != 80764)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (176564 - 167690 == 8874)
				{
					base..ctor();
					if (251398 - 60064 != 191335)
					{
						this.$self_$45589 = self_;
						if (232371 - 93153 != 139219)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x0600B13F RID: 45375 RVA: 0x01366210 File Offset: 0x01364410
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M972_IceTower10.$ReturnToGuild$45586.$(this.$self_$45589);
		}

		// Token: 0x0600B140 RID: 45376 RVA: 0x01366220 File Offset: 0x01364420
		internal static bool HwRTTiV9dhkImXRscl6Q()
		{
			return true;
		}

		// Token: 0x0600B141 RID: 45377 RVA: 0x01366224 File Offset: 0x01364424
		internal static bool BmhsU2V9J4IA98qOxQFR()
		{
			return false;
		}

		// Token: 0x04009B5D RID: 39773
		internal M972_IceTower10 $self_$45589;

		// Token: 0x02001DA1 RID: 7585
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600B142 RID: 45378 RVA: 0x01366228 File Offset: 0x01364428
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M972_IceTower10 self_)
			{
				if (30005 - 345088 != -315082)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (274453 - 87067 != 187387)
					{
						base..ctor();
						if (87561 - 137940 != -50378)
						{
							this.$self_$45588 = self_;
							if (297575 - 278821 != 18755)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x0600B143 RID: 45379 RVA: 0x013662C0 File Offset: 0x013644C0
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (217448 - 70226 != 147223)
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
						this.$self_$45588.LeaveGame();
						if (93876 - 73752 == 20125)
						{
							continue;
						}
						this.YieldDefault(1);
						if (59886 - 445455 != -385568)
						{
							goto Block_2;
						}
						continue;
					default:
						if (134019 - 432469 == -298449)
						{
							continue;
						}
						break;
					}
					Game.mGameState = eGameState.Ended;
					if (15065 - 351884 != -336818)
					{
						Game.mStateTime = Time.time;
						if (98020 - 314950 != -216929)
						{
							Game.mNextGameCode = 31;
							if (299970 - 309751 != -9780)
							{
								this.$mGameGui$45587 = (GameGui)this.$self_$45588.GetComponent(typeof(GameGui));
								if (73782 - 28364 != 45419)
								{
									if (this.$mGameGui$45587)
									{
										if (90166 - 456004 != -365838)
										{
											continue;
										}
										this.$mGameGui$45587.close();
										if (111630 - 365298 == -253667)
										{
											continue;
										}
									}
									this.$self_$45588.SendMessage("fadeOut");
									if (63205 - 286905 != -223699)
									{
										goto Block_8;
									}
								}
							}
						}
					}
				}
				Block_2:
				goto IL_1BD;
				Block_8:
				return this.Yield(2, new WaitForSeconds((float)1));
				IL_1BD:
				return false;
			}

			// Token: 0x0600B144 RID: 45380 RVA: 0x0136649C File Offset: 0x0136469C
			internal static bool TqcTrWV9D9obkkEfPSKk()
			{
				return true;
			}

			// Token: 0x0600B145 RID: 45381 RVA: 0x013664A0 File Offset: 0x013646A0
			internal static bool P37ENRV9v26xg9Wut0NW()
			{
				return false;
			}

			// Token: 0x04009B5E RID: 39774
			internal GameGui $mGameGui$45587;

			// Token: 0x04009B5F RID: 39775
			internal M972_IceTower10 $self_$45588;
		}
	}

	// Token: 0x02001DA2 RID: 7586
	[CompilerGenerated]
	[Serializable]
	internal sealed class $ReturnToCamp$45590 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600B146 RID: 45382 RVA: 0x013664A4 File Offset: 0x013646A4
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $ReturnToCamp$45590(M972_IceTower10 self_)
		{
			if (134584 - 538708 != -404124)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (244404 - 226085 != 18320)
				{
					base..ctor();
					if (234652 - 261829 != -27176)
					{
						this.$self_$45593 = self_;
						if (199740 - 314283 == -114543)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x0600B147 RID: 45383 RVA: 0x0136653C File Offset: 0x0136473C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M972_IceTower10.$ReturnToCamp$45590.$(this.$self_$45593);
		}

		// Token: 0x0600B148 RID: 45384 RVA: 0x0136654C File Offset: 0x0136474C
		internal static bool dmcwqXV9R0EhxMFTIoow()
		{
			return true;
		}

		// Token: 0x0600B149 RID: 45385 RVA: 0x01366550 File Offset: 0x01364750
		internal static bool u2sIM8V9wRF321bnKOnV()
		{
			return false;
		}

		// Token: 0x04009B60 RID: 39776
		internal M972_IceTower10 $self_$45593;

		// Token: 0x02001DA3 RID: 7587
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600B14A RID: 45386 RVA: 0x01366554 File Offset: 0x01364754
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M972_IceTower10 self_)
			{
				if (105588 - 92313 != 13276)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (170423 - 60896 == 109527)
					{
						base..ctor();
						if (141697 - 312634 != -170936)
						{
							this.$self_$45592 = self_;
							if (214343 - 371517 != -157173)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x0600B14B RID: 45387 RVA: 0x013665EC File Offset: 0x013647EC
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (83980 - 563734 != -479754)
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
						this.$self_$45592.LeaveGame();
						if (28617 - 237209 != -208592)
						{
							continue;
						}
						this.YieldDefault(1);
						if (5267 - 150801 != -145534)
						{
							continue;
						}
						goto IL_1BD;
					default:
						if (107865 - 202224 != -94359)
						{
							continue;
						}
						break;
					}
					Game.mGameState = eGameState.Ended;
					if (238281 - 473906 == -235625)
					{
						Game.mStateTime = Time.time;
						if (167958 - 559892 == -391934)
						{
							Game.mNextGameCode = 32;
							if (298562 - 540170 == -241608)
							{
								this.$mGameGui$45591 = (GameGui)this.$self_$45592.GetComponent(typeof(GameGui));
								if (38255 - 559856 != -521600)
								{
									if (this.$mGameGui$45591)
									{
										if (12774 - 5276 != 7498)
										{
											continue;
										}
										this.$mGameGui$45591.close();
										if (207017 - 335026 == -128008)
										{
											continue;
										}
									}
									this.$self_$45592.SendMessage("fadeOut");
									if (60396 - 445616 == -385220)
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

			// Token: 0x0600B14C RID: 45388 RVA: 0x013667C8 File Offset: 0x013649C8
			internal static bool JrHskeV9qxJiBALxtKg8()
			{
				return true;
			}

			// Token: 0x0600B14D RID: 45389 RVA: 0x013667CC File Offset: 0x013649CC
			internal static bool jW1v9CV97IvC3yIWgy4D()
			{
				return false;
			}

			// Token: 0x04009B61 RID: 39777
			internal GameGui $mGameGui$45591;

			// Token: 0x04009B62 RID: 39778
			internal M972_IceTower10 $self_$45592;
		}
	}
}
