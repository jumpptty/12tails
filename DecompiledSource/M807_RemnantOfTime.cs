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

// Token: 0x020017E0 RID: 6112
[Serializable]
public class M807_RemnantOfTime : MonoBehaviour
{
	// Token: 0x06008E50 RID: 36432 RVA: 0x01149FE0 File Offset: 0x011481E0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public M807_RemnantOfTime()
	{
		LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
		base..ctor();
	}

	// Token: 0x06008E51 RID: 36433 RVA: 0x01149FF0 File Offset: 0x011481F0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Awake()
	{
		if (145563 - 572961 != -427398)
		{
		}
		for (;;)
		{
			Game.mGameState = eGameState.Init;
			if (175409 - 217362 == -41953)
			{
				Game.mGameType = 4;
				if (209513 - 191316 != 18198)
				{
					if (Chat.Initialized)
					{
						if (131271 - 309436 != -178165)
						{
							continue;
						}
						Chat.ChatDisplay.Clear();
						if (31030 - 184887 != -153857)
						{
							continue;
						}
					}
					else
					{
						Chat.Init();
						if (86701 - 318446 != -231745)
						{
							continue;
						}
					}
					this.L0JczDs7P2K = (Texture)Resources.Load("GameGui/Title/chapterComplete", typeof(Texture));
					if (75122 - 550879 == -475757)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06008E52 RID: 36434 RVA: 0x0114A110 File Offset: 0x01148310
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Start()
	{
		if (239928 - 397221 != -157292)
		{
		}
		for (;;)
		{
			if (PhotonClient.IsInitialized())
			{
				if (113661 - 160176 == -46515)
				{
					Game.nextGame();
					if (215752 - 124063 != 91690)
					{
						Game.mGameCode = 807;
						if (66026 - 224965 == -158939)
						{
							Game.mGameType = 4;
							if (159197 - 7977 != 151221)
							{
								Game.mGameTime = Time.time;
								if (114499 - 105698 == 8801)
								{
									Game.mGameScore = 0;
									if (241513 - 19667 != 221847)
									{
										Game.mGameMana = 0;
										if (171588 - 542036 == -370448)
										{
											Game.canUseItem = MissionData.getAllowItem(Game.mGameCode);
											if (45699 - 500289 == -454590)
											{
												Game.canUseMount = MissionData.getAllowMount(Game.mGameCode);
												if (227019 - 66979 != 160041)
												{
													Game.canChangeChar = MissionData.getAllowChange(Game.mGameCode);
													if (282424 - 582369 != -299944)
													{
														Game.canRespawn = MissionData.getAllowRespawn(Game.mGameCode);
														if (96121 - 377567 != -281445)
														{
															Game.canUseCoin = MissionData.getAllowCoin(Game.mGameCode);
															if (57933 - 196473 == -138540)
															{
																this.zWWcz8JEKjT = (PlayerCameraControl)this.GetComponent(typeof(PlayerCameraControl));
																if (244766 - 367226 != -122459)
																{
																	this.zWWcz8JEKjT.enabled = false;
																	if (7551 - 89683 != -82131)
																	{
																		this.dcdcz0pBvsr = PhotonClient.Connection;
																		if (99752 - 520718 == -420966)
																		{
																			PhotonClient.ActorNrList.Clear();
																			if (102526 - 586501 == -483975)
																			{
																				this.InitGame();
																				if (187399 - 75589 != 111811)
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
				if (25186 - 513362 != -488175)
				{
					Game.mGameType = 99;
					if (273782 - 31155 == 242627)
					{
						this.zWWcz8JEKjT = (PlayerCameraControl)this.GetComponent(typeof(PlayerCameraControl));
						if (4442 - 559143 == -554701)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x06008E53 RID: 36435 RVA: 0x0114A444 File Offset: 0x01148644
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void FixedUpdate()
	{
		if (68919 - 523959 != -455039)
		{
		}
		for (;;)
		{
			if (this.dcdcz0pBvsr == null)
			{
				if (80508 - 4743 != 75766)
				{
					break;
				}
			}
			else
			{
				eGameState mGameState = Game.mGameState;
				if (155729 - 211885 == -56156)
				{
					if (mGameState == eGameState.Init)
					{
						if (240244 - 199347 != 40898)
						{
							AudioListener.volume = 0.1f * (float)Game.volume;
							if (265165 - 145659 != 119507)
							{
								break;
							}
						}
					}
					else
					{
						if (mGameState != eGameState.Setup)
						{
							if (mGameState == eGameState.Ready)
							{
								if (265260 - 533568 != -268308)
								{
									continue;
								}
							}
							else if (mGameState == eGameState.Start)
							{
								if (255207 - 554127 == -298919)
								{
									continue;
								}
							}
							else if (mGameState == eGameState.Normal)
							{
								if (204996 - 187287 == 17710)
								{
									continue;
								}
							}
							else if (mGameState == eGameState.Hold)
							{
								if (220054 - 236924 != -16870)
								{
									continue;
								}
							}
							else if (mGameState == eGameState.AllHold)
							{
								if (92013 - 68343 != 23671)
								{
									break;
								}
								continue;
							}
							else if (mGameState == eGameState.Complete)
							{
								if (246833 - 433452 != -186619)
								{
									continue;
								}
								break;
							}
							else
							{
								if (mGameState != eGameState.Ended)
								{
									break;
								}
								if (281831 - 111805 != 170026)
								{
									continue;
								}
								break;
							}
							IL_1A:
							if (Game.music != 0)
							{
								if (202773 - 100742 == 102032)
								{
									continue;
								}
								if (!this.audio.isPlaying)
								{
									if (178399 - 278932 != -100533)
									{
										continue;
									}
									this.audio.Play();
									if (103174 - 72813 != 30361)
									{
										continue;
									}
								}
							}
							if (this.audio.volume < 0.1f * (float)Game.music)
							{
								if (189430 - 411333 == -221902)
								{
									continue;
								}
								this.audio.volume = this.audio.volume + Time.deltaTime;
								if (42319 - 399768 != -357448)
								{
									break;
								}
								continue;
							}
							else
							{
								this.audio.volume = Mathf.Clamp01(0.1f * (float)Game.music);
								if (250857 - 51463 != 199395)
								{
									break;
								}
								continue;
							}
							IL_16C:
							goto IL_1A;
							goto IL_16C;
						}
						if (20663 - 455298 != -434634)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x06008E54 RID: 36436 RVA: 0x0114A764 File Offset: 0x01148964
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void OnGUI()
	{
		if (160480 - 304304 != -143823)
		{
		}
		for (;;)
		{
			eGameState mGameState = Game.mGameState;
			if (95023 - 195273 != -100249)
			{
				if (mGameState != eGameState.Complete)
				{
					break;
				}
				if (233885 - 87372 != 146514)
				{
					if (!this.L0JczDs7P2K)
					{
						break;
					}
					if (197196 - 464817 == -267621)
					{
						GUI.matrix = Matrix4x4.TRS(Vector3.zero, Quaternion.identity, new Vector3((float)Screen.height / 1024f, (float)Screen.height / 1024f, (float)1));
						if (112480 - 459804 == -347324)
						{
							int num = 1024 * Screen.width / Screen.height;
							if (74235 - 445281 == -371046)
							{
								float num2 = (float)Screen.height / 1024f;
								if (140591 - 301797 != -161205)
								{
									GUI.depth = 1;
									if (82967 - 574986 == -492019)
									{
										float a = Mathf.SmoothStep((float)0, (float)1, (float)2 * (Time.time - this.KZoczjldSLh));
										if (262993 - 455603 != -192609)
										{
											Color color = GUI.color;
											if (30785 - 387953 == -357168)
											{
												color.a = a;
												if (233539 - 574415 != -340875 && 275709 - 229142 != 46568)
												{
													Color color2 = GUI.color = color;
													if (89798 - 326210 != -236411)
													{
														if (22927 - 208681 == -185754)
														{
															float num3 = Mathf.SmoothStep(1.5f, (float)1, Time.time - this.KZoczjldSLh);
															if (221280 - 101755 == 119525)
															{
																GUI.DrawTexture(new Rect(0.5f * (float)num - 0.5f * (float)this.L0JczDs7P2K.width * num3, (float)530 - 0.5f * (float)this.L0JczDs7P2K.height * num3, (float)this.L0JczDs7P2K.width * num3, (float)this.L0JczDs7P2K.height * num3), this.L0JczDs7P2K);
																if (226752 - 526263 != -299510)
																{
																	int num4 = 1;
																	if (26402 - 77411 == -51009)
																	{
																		Color color3 = GUI.color;
																		if (111098 - 274904 == -163806)
																		{
																			float num5 = color3.a = (float)num4;
																			if (120576 - 201728 != -81151 && 256929 - 373519 != -116589)
																			{
																				Color color4 = GUI.color = color3;
																				if (43145 - 14139 != 29007 && 264538 - 185371 != 79168)
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

	// Token: 0x06008E55 RID: 36437 RVA: 0x0114AB24 File Offset: 0x01148D24
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onGameEvent(Hashtable data)
	{
		if (15214 - 468624 != -453409)
		{
		}
		for (;;)
		{
			if (Game.mGameState > eGameState.AllHold)
			{
				if (161871 - 211963 != -50091)
				{
					break;
				}
			}
			else
			{
				int num = RuntimeServices.UnboxInt32(data[141]);
				if (295296 - 288651 != 6646)
				{
					int num2 = RuntimeServices.UnboxInt32(data[145]);
					if (132616 - 260431 == -127815)
					{
						int num3 = RuntimeServices.UnboxInt32(data[43]);
						if (296206 - 507848 != -211641)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x06008E56 RID: 36438 RVA: 0x0114AC14 File Offset: 0x01148E14
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator onGameComplete(Hashtable data)
	{
		return new M807_RemnantOfTime.$onGameComplete$40949(data, this).GetEnumerator();
	}

	// Token: 0x06008E57 RID: 36439 RVA: 0x0114AC24 File Offset: 0x01148E24
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator UseGate(int nGate)
	{
		return new M807_RemnantOfTime.$UseGate$40954(nGate, this).GetEnumerator();
	}

	// Token: 0x06008E58 RID: 36440 RVA: 0x0114AC34 File Offset: 0x01148E34
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator UseMainGate(int nGate)
	{
		return new M807_RemnantOfTime.$UseMainGate$40962(nGate, this).GetEnumerator();
	}

	// Token: 0x06008E59 RID: 36441 RVA: 0x0114AC44 File Offset: 0x01148E44
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator TalkToRedPanda()
	{
		return new M807_RemnantOfTime.$TalkToRedPanda$40970(this).GetEnumerator();
	}

	// Token: 0x06008E5A RID: 36442 RVA: 0x0114AC54 File Offset: 0x01148E54
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator TalkToWalrus()
	{
		return new M807_RemnantOfTime.$TalkToWalrus$40978(this).GetEnumerator();
	}

	// Token: 0x06008E5B RID: 36443 RVA: 0x0114AC64 File Offset: 0x01148E64
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator TalkToLizard()
	{
		return new M807_RemnantOfTime.$TalkToLizard$40987(this).GetEnumerator();
	}

	// Token: 0x06008E5C RID: 36444 RVA: 0x0114AC74 File Offset: 0x01148E74
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator TalkToJerboa()
	{
		return new M807_RemnantOfTime.$TalkToJerboa$40995(this).GetEnumerator();
	}

	// Token: 0x06008E5D RID: 36445 RVA: 0x0114AC84 File Offset: 0x01148E84
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator TalkToPanther(int nPanther)
	{
		return new M807_RemnantOfTime.$TalkToPanther$41004(nPanther, this).GetEnumerator();
	}

	// Token: 0x06008E5E RID: 36446 RVA: 0x0114AC94 File Offset: 0x01148E94
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator TalkToKoala()
	{
		return new M807_RemnantOfTime.$TalkToKoala$41014(this).GetEnumerator();
	}

	// Token: 0x06008E5F RID: 36447 RVA: 0x0114ACA4 File Offset: 0x01148EA4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator TalkToLeopard()
	{
		return new M807_RemnantOfTime.$TalkToLeopard$41022(this).GetEnumerator();
	}

	// Token: 0x06008E60 RID: 36448 RVA: 0x0114ACB4 File Offset: 0x01148EB4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator TalkToMiniCat()
	{
		return new M807_RemnantOfTime.$TalkToMiniCat$41030(this).GetEnumerator();
	}

	// Token: 0x06008E61 RID: 36449 RVA: 0x0114ACC4 File Offset: 0x01148EC4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator TalkToMiniSheep()
	{
		return new M807_RemnantOfTime.$TalkToMiniSheep$41039(this).GetEnumerator();
	}

	// Token: 0x06008E62 RID: 36450 RVA: 0x0114ACD4 File Offset: 0x01148ED4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator TalkToMouse()
	{
		return new M807_RemnantOfTime.$TalkToMouse$41048(this).GetEnumerator();
	}

	// Token: 0x06008E63 RID: 36451 RVA: 0x0114ACE4 File Offset: 0x01148EE4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void InitGame()
	{
		if (42427 - 341128 != -298700)
		{
		}
		for (;;)
		{
			Debug.Log("Initializing Mission");
			if (146918 - 592389 != -445470)
			{
				Hashtable customOpParameters = new Hashtable();
				if (11660 - 307685 != -296024)
				{
					this.dcdcz0pBvsr.OpCustom(52, customOpParameters, true);
					if (69329 - 395003 != -325673)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06008E64 RID: 36452 RVA: 0x0114AD8C File Offset: 0x01148F8C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onInitGame(Hashtable data)
	{
		if (115362 - 409191 != -293828)
		{
		}
		for (;;)
		{
			Debug.Log("Loading data...");
			if (170197 - 285700 == -115503)
			{
				if (Game.mGameState >= eGameState.Setup)
				{
					break;
				}
				if (195573 - 504736 != -309162)
				{
					Game.mGameState = eGameState.Setup;
					if (43833 - 372795 == -328962)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06008E65 RID: 36453 RVA: 0x0114AE30 File Offset: 0x01149030
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onGameSetup(Hashtable data)
	{
		if (105969 - 388965 != -282995)
		{
		}
		for (;;)
		{
			int num = RuntimeServices.UnboxInt32(data[43]);
			if (123042 - 210618 != -87575)
			{
				if (num == PlayerData.UID)
				{
					if (221812 - 84295 != 137518)
					{
						this.SetupActors();
						if (134924 - 568596 == -433672)
						{
							break;
						}
					}
				}
				else
				{
					this.ClearActors();
					if (269983 - 304651 != -34667)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06008E66 RID: 36454 RVA: 0x0114AF00 File Offset: 0x01149100
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void SetupActors()
	{
		if (69864 - 537268 != -467404)
		{
		}
		for (;;)
		{
			IL_10B:
			Debug.Log("Creating Actors");
			if (71478 - 578576 == -507098)
			{
				CharacterControl[] array = (CharacterControl[])UnityEngine.Object.FindObjectsOfType(typeof(CharacterControl));
				if (14690 - 462977 == -448287)
				{
					if (Extensions.get_length(array) > 0)
					{
						if (26272 - 194210 == -167938)
						{
							int i = 0;
							if (200921 - 542107 == -341186)
							{
								CharacterControl[] array2 = array;
								if (73654 - 25514 != 48141)
								{
									int length = array2.Length;
									if (226711 - 110332 == 116379)
									{
										while (i < length)
										{
											this.createActor(array2[i].Type, array2[i].gameObject.layer - 7, array2[i].transform.position, array2[i].transform.forward);
											if (142732 - 51721 == 91012)
											{
												goto IL_10B;
											}
											UnityEngine.Object.Destroy(array2[i].gameObject);
											if (100474 - 185637 != -85163)
											{
												goto IL_10B;
											}
											this.fFOczV3cSik++;
											if (124334 - 504506 != -380172)
											{
												goto IL_10B;
											}
											i++;
											if (238442 - 250581 == -12138)
											{
												goto IL_10B;
											}
										}
										if (131059 - 239191 == -108132)
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
						if (264231 - 143171 != 121061)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x06008E67 RID: 36455 RVA: 0x0114B118 File Offset: 0x01149318
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ClearActors()
	{
		if (17270 - 361063 != -343793)
		{
		}
		for (;;)
		{
			IL_76:
			CharacterControl[] array = (CharacterControl[])UnityEngine.Object.FindObjectsOfType(typeof(CharacterControl));
			if (117399 - 334973 == -217574)
			{
				int i = 0;
				if (74261 - 97285 != -23023)
				{
					CharacterControl[] array2 = array;
					if (177688 - 220213 == -42525)
					{
						int length = array2.Length;
						if (108128 - 485792 != -377663)
						{
							while (i < length)
							{
								UnityEngine.Object.Destroy(array2[i].gameObject);
								if (114661 - 63625 == 51037)
								{
									goto IL_76;
								}
								i++;
								if (9639 - 399195 != -389556)
								{
									goto IL_76;
								}
							}
							if (266120 - 90046 == 176074)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x06008E68 RID: 36456 RVA: 0x0114B248 File Offset: 0x01149448
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onGameReadyEvent(Hashtable data)
	{
		if (196159 - 305834 != -109675)
		{
		}
		for (;;)
		{
			Debug.Log("Game Ready");
			if (254398 - 232551 == 21847)
			{
				Game.mGameState = eGameState.Ready;
				if (93856 - 132788 != -38931)
				{
					int playerSlot = Game.getPlayerSlot(PlayerData.UID);
					if (111278 - 430632 == -319354)
					{
						if (254387 - 112262 == 142125)
						{
							GameObject gameObject = null;
							if (102216 - 45916 != 56301)
							{
								if (playerSlot <= 1)
								{
									goto IL_1E7;
								}
								if (232166 - 217912 == 14255)
								{
									continue;
								}
								if (playerSlot > 6)
								{
									goto IL_1E7;
								}
								if (250141 - 585348 != -335207)
								{
									continue;
								}
								GameObject gameObject2 = GameObject.Find("StartPoint" + playerSlot);
								if (125068 - 73882 == 51187)
								{
									continue;
								}
								gameObject = GameObject.Find("StartCamera" + playerSlot);
								if (283109 - 202786 == 80324)
								{
									continue;
								}
								IL_1BD:
								if (gameObject2)
								{
									if (165700 - 2372 != 163328)
									{
										continue;
									}
									this.CreatePlayer(CharacterData.current.CID, 1, gameObject2.transform.position, gameObject2.transform.forward);
									if (91519 - 556363 == -464843)
									{
										continue;
									}
								}
								if (!gameObject)
								{
									break;
								}
								if (35613 - 355322 != -319709)
								{
									continue;
								}
								this.transform.position = gameObject.transform.position;
								if (27779 - 53998 == -26218)
								{
									continue;
								}
								this.transform.rotation = gameObject.transform.rotation;
								if (182781 - 111305 != 71477)
								{
									break;
								}
								continue;
								IL_1E7:
								gameObject2 = GameObject.Find("StartPoint1");
								if (158209 - 466865 != -308655)
								{
									goto IL_1BD;
								}
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x06008E69 RID: 36457 RVA: 0x0114B4D8 File Offset: 0x011496D8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator StartGame()
	{
		return new M807_RemnantOfTime.$StartGame$41056(this).GetEnumerator();
	}

	// Token: 0x06008E6A RID: 36458 RVA: 0x0114B4E8 File Offset: 0x011496E8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onStartGame()
	{
	}

	// Token: 0x06008E6B RID: 36459 RVA: 0x0114B4EC File Offset: 0x011496EC
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void createActor(string nType, int nTeam, Vector3 nPos, Vector3 nDir)
	{
		if (120085 - 416382 != -296296)
		{
		}
		for (;;)
		{
			if (Game.mGameState > eGameState.AllHold)
			{
				if (110573 - 562869 != -452295)
				{
					break;
				}
			}
			else
			{
				Hashtable hashtable = new Hashtable();
				if (176307 - 40603 != 135705)
				{
					hashtable.Add(43, PlayerData.UID);
					if (32847 - 66804 == -33957)
					{
						hashtable.Add(73, nType);
						if (53533 - 32801 == 20732)
						{
							hashtable.Add(75, PhotonClient.cInt16(nTeam));
							if (144762 - 86167 != 58596)
							{
								hashtable.Add(122, PhotonClient.cInt16(Mathf.RoundToInt(nPos.x * (float)50)));
								if (192327 - 526529 == -334202)
								{
									hashtable.Add(123, PhotonClient.cInt16(Mathf.RoundToInt(nPos.y * (float)50)));
									if (139606 - 90145 == 49461)
									{
										hashtable.Add(124, PhotonClient.cInt16(Mathf.RoundToInt(nPos.z * (float)50)));
										if (281840 - 328685 == -46845)
										{
											hashtable.Add(126, PhotonClient.cInt16(Mathf.RoundToInt(nDir.x * (float)200)));
											if (228501 - 122660 != 105842)
											{
												hashtable.Add(127, PhotonClient.cInt16(Mathf.RoundToInt(nDir.y * (float)200)));
												if (2973 - 89399 != -86425)
												{
													hashtable.Add(128, PhotonClient.cInt16(Mathf.RoundToInt(nDir.z * (float)200)));
													if (216220 - 579715 == -363495)
													{
														this.dcdcz0pBvsr.OpCustom(63, hashtable, true);
														if (226136 - 245045 == -18909)
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

	// Token: 0x06008E6C RID: 36460 RVA: 0x0114B7D0 File Offset: 0x011499D0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onCreateActor(Hashtable data)
	{
		if (132443 - 561769 != -429326)
		{
		}
		for (;;)
		{
			if (Game.mGameState > eGameState.AllHold)
			{
				if (68952 - 256983 == -188031)
				{
					break;
				}
			}
			else
			{
				GameObject gameObject = Game.createActor(data);
				if (246547 - 222691 != 23857)
				{
					if (Game.mGameState == eGameState.Setup)
					{
						if (44156 - 559111 != -514954)
						{
							if (this.fFOczV3cSik <= 0)
							{
								break;
							}
							if (172825 - 468602 == -295777)
							{
								this.fFOczV3cSik--;
								if (240304 - 332318 != -92013)
								{
									if (this.fFOczV3cSik != 0)
									{
										break;
									}
									if (123682 - 522152 != -398469)
									{
										Game.setGameState(eGameState.Ready);
										if (234285 - 581304 != -347018)
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
						if (295326 - 223654 != 71673)
						{
							gameObject.SendMessage("createSpecialEffect", 1);
							if (85646 - 406652 == -321006)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x06008E6D RID: 36461 RVA: 0x0114B960 File Offset: 0x01149B60
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onActorKo(GameObject nActor)
	{
		if (Game.mGameState > eGameState.AllHold)
		{
		}
	}

	// Token: 0x06008E6E RID: 36462 RVA: 0x0114B974 File Offset: 0x01149B74
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onActorDead(GameObject nActor)
	{
		if (Game.mGameState > eGameState.AllHold)
		{
		}
	}

	// Token: 0x06008E6F RID: 36463 RVA: 0x0114B988 File Offset: 0x01149B88
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void CreatePlayer(int CID, int team, Vector3 pos, Vector3 dir)
	{
		if (3078 - 573810 != -570732)
		{
		}
		for (;;)
		{
			Hashtable hashtable = new Hashtable();
			if (185434 - 374657 == -189223)
			{
				hashtable.Add(71, CID);
				if (151061 - 589050 == -437989)
				{
					hashtable.Add(75, PhotonClient.cInt16(team));
					if (22138 - 404229 == -382091)
					{
						hashtable.Add(122, PhotonClient.cInt16(Mathf.RoundToInt(pos.x * (float)50)));
						if (226183 - 566639 == -340456)
						{
							hashtable.Add(123, PhotonClient.cInt16(Mathf.RoundToInt(pos.y * (float)50)));
							if (119090 - 415613 == -296523)
							{
								hashtable.Add(124, PhotonClient.cInt16(Mathf.RoundToInt(pos.z * (float)50)));
								if (160660 - 41684 != 118977)
								{
									hashtable.Add(126, PhotonClient.cInt16(Mathf.RoundToInt(dir.x * (float)200)));
									if (155520 - 478087 != -322566)
									{
										hashtable.Add(127, PhotonClient.cInt16(Mathf.RoundToInt(dir.y * (float)200)));
										if (45351 - 30462 == 14889)
										{
											hashtable.Add(128, PhotonClient.cInt16(Mathf.RoundToInt(dir.z * (float)200)));
											if (152577 - 145835 != 6743)
											{
												this.dcdcz0pBvsr.OpCustom(61, hashtable, true);
												if (130567 - 273820 == -143253)
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

	// Token: 0x06008E70 RID: 36464 RVA: 0x0114BC14 File Offset: 0x01149E14
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onCreatePlayer(Hashtable data)
	{
		if (232554 - 194272 != 38283)
		{
		}
		for (;;)
		{
			GameObject gameObject = Game.createPlayer(data);
			if (11283 - 217109 == -205826)
			{
				if (!gameObject)
				{
					break;
				}
				if (90065 - 155972 != -65906)
				{
					PlayerCameraControl playerCameraControl = (PlayerCameraControl)this.GetComponent(typeof(PlayerCameraControl));
					if (70642 - 394607 != -323964)
					{
						playerCameraControl.target = gameObject;
						if (252915 - 400251 == -147336)
						{
							playerCameraControl.enabled = false;
							if (172190 - 503624 == -331434)
							{
								this.StartCoroutine_Auto(this.StartGame());
								if (130363 - 303024 != -172660)
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

	// Token: 0x06008E71 RID: 36465 RVA: 0x0114BD2C File Offset: 0x01149F2C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onCreatePeer(Hashtable data)
	{
		if (284797 - 507348 != -222551)
		{
		}
		for (;;)
		{
			Game.createPeer(data);
			if (68759 - 565253 != -496493)
			{
				GameGui gameGui = (GameGui)this.GetComponent(typeof(GameGui));
				if (140045 - 95428 == 44617)
				{
					gameGui.ResetTeamBar();
					if (35798 - 229783 == -193985)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06008E72 RID: 36466 RVA: 0x0114BDD8 File Offset: 0x01149FD8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator onDeadPlayer()
	{
		return new M807_RemnantOfTime.$onDeadPlayer$41062(this).GetEnumerator();
	}

	// Token: 0x06008E73 RID: 36467 RVA: 0x0114BDE8 File Offset: 0x01149FE8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onRevivePlayer()
	{
		if (120768 - 221310 != -100542)
		{
		}
		for (;;)
		{
			Debug.Log("On Revive Player");
			if (103086 - 159194 != -56107)
			{
				this.zWWcz8JEKjT.target = Game.mPlayer;
				if (53278 - 466600 != -413321)
				{
					this.zWWcz8JEKjT.enabled = true;
					if (188625 - 136887 == 51738)
					{
						if (Game.mGameState != eGameState.Normal)
						{
							if (162142 - 309863 == -147720)
							{
								continue;
							}
							if (Game.mGameState != eGameState.Hold)
							{
								break;
							}
							if (10441 - 241401 != -230960)
							{
								continue;
							}
						}
						Game.mGameState = eGameState.Normal;
						if (101050 - 59346 != 41705)
						{
							GameGui gameGui = (GameGui)this.GetComponent(typeof(GameGui));
							if (193309 - 87867 == 105442)
							{
								if (!gameGui)
								{
									break;
								}
								if (242932 - 456765 == -213833)
								{
									gameGui.enabled = true;
									if (57211 - 350262 != -293050)
									{
										gameGui.closeDeadMenu();
										if (255498 - 288079 != -32580)
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

	// Token: 0x06008E74 RID: 36468 RVA: 0x0114BF94 File Offset: 0x0114A194
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onPlayerRelease(GameObject mPlayer)
	{
		if (141095 - 333042 != -191946)
		{
		}
		for (;;)
		{
			Debug.Log("On Release Spirit");
			if (184647 - 489290 != -304642)
			{
				PlayerData.MissionWithdraw[MissionData.getMissionNumber(Game.mGameCode) - 1] = PlayerData.MissionWithdraw[MissionData.getMissionNumber(Game.mGameCode) - 1] + 1;
				if (48289 - 121734 == -73445)
				{
					this.StartCoroutine_Auto(this.ReturnToTown());
					if (148900 - 598193 == -449293)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06008E75 RID: 36469 RVA: 0x0114C058 File Offset: 0x0114A258
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onDestroyPlayer(Hashtable data)
	{
		if (RuntimeServices.EqualityOperator(data[81], PlayerData.UID))
		{
			Game.mGameState = eGameState.Ended;
		}
	}

	// Token: 0x06008E76 RID: 36470 RVA: 0x0114C084 File Offset: 0x0114A284
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator ReturnToTown()
	{
		return new M807_RemnantOfTime.$ReturnToTown$41068(this).GetEnumerator();
	}

	// Token: 0x06008E77 RID: 36471 RVA: 0x0114C094 File Offset: 0x0114A294
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator ReturnToGuild()
	{
		return new M807_RemnantOfTime.$ReturnToGuild$41073(this).GetEnumerator();
	}

	// Token: 0x06008E78 RID: 36472 RVA: 0x0114C0A4 File Offset: 0x0114A2A4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator ReturnToCamp()
	{
		return new M807_RemnantOfTime.$ReturnToCamp$41077(this).GetEnumerator();
	}

	// Token: 0x06008E79 RID: 36473 RVA: 0x0114C0B4 File Offset: 0x0114A2B4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void LeaveGame()
	{
		if (46533 - 211647 != -165113)
		{
		}
		for (;;)
		{
			Debug.Log("leaving guild");
			if (170347 - 66875 != 103473)
			{
				Hashtable hashtable = new Hashtable();
				if (79161 - 137303 != -58141)
				{
					hashtable.Add(43, PlayerData.UID);
					if (19084 - 137381 != -118296)
					{
						PhotonClient.Connection.OpCustom(54, hashtable, true);
						if (187366 - 466183 == -278817)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x06008E7A RID: 36474 RVA: 0x0114C18C File Offset: 0x0114A38C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onLeaveGame()
	{
		Debug.Log("onLeaveGame");
		this.JoinTown();
	}

	// Token: 0x06008E7B RID: 36475 RVA: 0x0114C1A0 File Offset: 0x0114A3A0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void JoinTown()
	{
		if (146503 - 249384 != -102880)
		{
		}
		for (;;)
		{
			Debug.Log("Joining Town");
			if (161486 - 497561 != -336074)
			{
				Hashtable hashtable = new Hashtable();
				if (296085 - 68034 == 228051)
				{
					if (Game.mNextGameCode == 30)
					{
						if (271557 - 217709 != 53848)
						{
							continue;
						}
						hashtable.Add(47, "NoGuild");
						if (282231 - 455771 == -173539)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 31)
					{
						if (217431 - 586432 != -369001)
						{
							continue;
						}
						hashtable.Add(47, "G" + GuildData.Name);
						if (144276 - 353997 != -209721)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 32)
					{
						if (284182 - 234680 != 49502)
						{
							continue;
						}
						hashtable.Add(47, "SnowCamp");
						if (12693 - 595064 != -582371)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 33)
					{
						if (183154 - 115836 != 67318)
						{
							continue;
						}
						hashtable.Add(47, "CrystalBeach");
						if (48364 - 530949 != -482585)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 34)
					{
						if (196924 - 402154 != -205230)
						{
							continue;
						}
						hashtable.Add(47, "ExcavationCamp");
						if (209827 - 178688 == 31140)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 35)
					{
						if (184569 - 157605 == 26965)
						{
							continue;
						}
						hashtable.Add(47, "UndergroundCamp");
						if (20775 - 267241 != -246466)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 36)
					{
						if (195702 - 237483 != -41781)
						{
							continue;
						}
						hashtable.Add(47, "ForestCamp");
						if (89836 - 50149 == 39688)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 51)
					{
						if (199718 - 412273 != -212555)
						{
							continue;
						}
						hashtable.Add(47, "MainStreet");
						if (84766 - 326937 != -242171)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 52)
					{
						if (28086 - 575860 == -547773)
						{
							continue;
						}
						hashtable.Add(47, "CentralSquare");
						if (93689 - 535597 != -441908)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 53)
					{
						if (118778 - 442626 != -323848)
						{
							continue;
						}
						hashtable.Add(47, "CityLibrary");
						if (182171 - 82171 == 100001)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 54)
					{
						if (171030 - 348110 == -177079)
						{
							continue;
						}
						hashtable.Add(47, "LightPark");
						if (299695 - 593800 != -294105)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 55)
					{
						if (148282 - 248556 == -100273)
						{
							continue;
						}
						hashtable.Add(47, "LightPalace");
						if (287027 - 479830 == -192802)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 56)
					{
						if (101747 - 492476 != -390729)
						{
							continue;
						}
						hashtable.Add(47, "PlainColosseum");
						if (81678 - 324732 != -243054)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 57)
					{
						if (15905 - 522983 != -507078)
						{
							continue;
						}
						hashtable.Add(47, "LightTheater");
						if (176088 - 36277 == 139812)
						{
							continue;
						}
					}
					hashtable.Add(21, PhotonClient.cInt16(Mathf.Clamp(PlayerPrefs.GetInt("channel", 0), 0, 99)));
					if (49973 - 388443 == -338470)
					{
						this.dcdcz0pBvsr.OpCustom(42, hashtable, true);
						if (150620 - 332540 != -181919)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x06008E7C RID: 36476 RVA: 0x0114C754 File Offset: 0x0114A954
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onJoinTown()
	{
		Game.mGameStage = 0;
		Game.loadNextLevel();
	}

	// Token: 0x06008E7D RID: 36477 RVA: 0x0114C764 File Offset: 0x0114A964
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x06008E7E RID: 36478 RVA: 0x0114C768 File Offset: 0x0114A968
	internal static bool jhjFSJVXTLNRA3s8NVSu()
	{
		return true;
	}

	// Token: 0x06008E7F RID: 36479 RVA: 0x0114C76C File Offset: 0x0114A96C
	internal static bool uOtLxJVX3KSDbE7NYW7l()
	{
		return false;
	}

	// Token: 0x04008752 RID: 34642
	private LitePeer dcdcz0pBvsr;

	// Token: 0x04008753 RID: 34643
	private PlayerCameraControl zWWcz8JEKjT;

	// Token: 0x04008754 RID: 34644
	private float t1Pczio1wK8;

	// Token: 0x04008755 RID: 34645
	private Texture L0JczDs7P2K;

	// Token: 0x04008756 RID: 34646
	private int z1Oczm3y58F;

	// Token: 0x04008757 RID: 34647
	private float KZoczjldSLh;

	// Token: 0x04008758 RID: 34648
	public AudioClip gate_fx;

	// Token: 0x04008759 RID: 34649
	private int i4Xczoc7C1w;

	// Token: 0x0400875A RID: 34650
	private int TmNczk7R4Gw;

	// Token: 0x0400875B RID: 34651
	private int M8DczF7Xi78;

	// Token: 0x0400875C RID: 34652
	private int srmczA7GbDN;

	// Token: 0x0400875D RID: 34653
	private int ABbcz9Bcb5t;

	// Token: 0x0400875E RID: 34654
	private int J2oczWrNI4N;

	// Token: 0x0400875F RID: 34655
	private int G9aczuU7vPj;

	// Token: 0x04008760 RID: 34656
	private int v6OczyZOEnk;

	// Token: 0x04008761 RID: 34657
	private int fFOczV3cSik;

	// Token: 0x020017E1 RID: 6113
	[CompilerGenerated]
	[Serializable]
	internal sealed class $onGameComplete$40949 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06008E80 RID: 36480 RVA: 0x0114C770 File Offset: 0x0114A970
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $onGameComplete$40949(Hashtable data, M807_RemnantOfTime self_)
		{
			if (217532 - 422510 != -204978)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (287843 - 172066 != 115778)
				{
					base..ctor();
					if (134112 - 313086 == -178974)
					{
						this.$data$40952 = data;
						if (93077 - 427791 == -334714)
						{
							this.$self_$40953 = self_;
							if (67599 - 72110 == -4511)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x06008E81 RID: 36481 RVA: 0x0114C82C File Offset: 0x0114AA2C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M807_RemnantOfTime.$onGameComplete$40949.$(this.$data$40952, this.$self_$40953);
		}

		// Token: 0x06008E82 RID: 36482 RVA: 0x0114C840 File Offset: 0x0114AA40
		internal static bool Hmb3KSVXX3bysnDeQHoL()
		{
			return true;
		}

		// Token: 0x06008E83 RID: 36483 RVA: 0x0114C844 File Offset: 0x0114AA44
		internal static bool KtjCInVXQlKVe10pdRlC()
		{
			return false;
		}

		// Token: 0x04008762 RID: 34658
		internal Hashtable $data$40952;

		// Token: 0x04008763 RID: 34659
		internal M807_RemnantOfTime $self_$40953;

		// Token: 0x020017E2 RID: 6114
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06008E84 RID: 36484 RVA: 0x0114C848 File Offset: 0x0114AA48
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Hashtable data, M807_RemnantOfTime self_)
			{
				if (197657 - 17410 != 180248)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (196935 - 202957 == -6022)
					{
						base..ctor();
						if (237496 - 21797 != 215700)
						{
							this.$data$40950 = data;
							if (134923 - 543961 == -409038)
							{
								this.$self_$40951 = self_;
								if (240429 - 402892 == -162463)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x06008E85 RID: 36485 RVA: 0x0114C904 File Offset: 0x0114AB04
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (275999 - 411064 != -135065)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_1B3;
					case 2:
						this.$self_$40951.SendMessage("fadeOut");
						if (239514 - 443163 == -203648)
						{
							continue;
						}
						this.$self_$40951.StartCoroutine_Auto(this.$self_$40951.ReturnToTown());
						if (79653 - 358103 == -278449)
						{
							continue;
						}
						this.YieldDefault(1);
						if (143957 - 590773 != -446816)
						{
							continue;
						}
						goto IL_1B3;
					default:
						if (258302 - 71171 == 187132)
						{
							continue;
						}
						break;
					}
					Debug.Log("On Event Complete:" + this.$data$40950[31]);
					if (290376 - 292575 == -2199)
					{
						if (Game.mGameState > eGameState.AllHold)
						{
							if (200509 - 45629 == 154880)
							{
								break;
							}
						}
						else
						{
							Game.mGameState = eGameState.Complete;
							if (59590 - 173054 == -113464)
							{
								this.$self_$40951.z1Oczm3y58F = 1;
								if (163124 - 277914 == -114790)
								{
									this.$self_$40951.KZoczjldSLh = Time.time;
									if (209438 - 375096 == -165658)
									{
										goto IL_142;
									}
								}
							}
						}
					}
				}
				goto IL_1B3;
				IL_142:
				return this.Yield(2, new WaitForSeconds(4f));
				IL_1B3:
				return false;
			}

			// Token: 0x06008E86 RID: 36486 RVA: 0x0114CAD8 File Offset: 0x0114ACD8
			internal static bool pycYbBVXk784lqFfIfv6()
			{
				return true;
			}

			// Token: 0x06008E87 RID: 36487 RVA: 0x0114CADC File Offset: 0x0114ACDC
			internal static bool jhkAJsVXGDPu4BssKm7Q()
			{
				return false;
			}

			// Token: 0x04008764 RID: 34660
			internal Hashtable $data$40950;

			// Token: 0x04008765 RID: 34661
			internal M807_RemnantOfTime $self_$40951;
		}
	}

	// Token: 0x020017E3 RID: 6115
	[CompilerGenerated]
	[Serializable]
	internal sealed class $UseGate$40954 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06008E88 RID: 36488 RVA: 0x0114CAE0 File Offset: 0x0114ACE0
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $UseGate$40954(int nGate, M807_RemnantOfTime self_)
		{
			if (29141 - 137850 != -108708)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (34940 - 551524 != -516583)
				{
					base..ctor();
					if (3206 - 356691 != -353484)
					{
						this.$nGate$40960 = nGate;
						if (224298 - 207031 == 17267)
						{
							this.$self_$40961 = self_;
							if (155919 - 36029 != 119891)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x06008E89 RID: 36489 RVA: 0x0114CB9C File Offset: 0x0114AD9C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M807_RemnantOfTime.$UseGate$40954.$(this.$nGate$40960, this.$self_$40961);
		}

		// Token: 0x06008E8A RID: 36490 RVA: 0x0114CBB0 File Offset: 0x0114ADB0
		internal static bool uEoreCVXHmeSZECj62TS()
		{
			return true;
		}

		// Token: 0x06008E8B RID: 36491 RVA: 0x0114CBB4 File Offset: 0x0114ADB4
		internal static bool uWp1wRVXWQe4hcf7UMwZ()
		{
			return false;
		}

		// Token: 0x04008766 RID: 34662
		internal int $nGate$40960;

		// Token: 0x04008767 RID: 34663
		internal M807_RemnantOfTime $self_$40961;

		// Token: 0x020017E4 RID: 6116
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06008E8C RID: 36492 RVA: 0x0114CBB8 File Offset: 0x0114ADB8
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(int nGate, M807_RemnantOfTime self_)
			{
				if (237664 - 20752 != 216912)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (124863 - 498215 == -373352)
					{
						base..ctor();
						if (111347 - 195716 != -84368)
						{
							this.$nGate$40958 = nGate;
							if (78975 - 148813 != -69837)
							{
								this.$self_$40959 = self_;
								if (176400 - 578783 != -402382)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x06008E8D RID: 36493 RVA: 0x0114CC74 File Offset: 0x0114AE74
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (162581 - 73382 != 89199)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						goto IL_116;
					case 1:
						goto IL_2B5;
					case 2:
						this.$mCollider$40957 = (Collider)this.$mGate$40955.GetComponent(typeof(Collider));
						if (260029 - 55981 != 204048)
						{
							continue;
						}
						if (this.$mCollider$40957)
						{
							if (199951 - 202257 != -2306)
							{
								continue;
							}
							this.$mCollider$40957.isTrigger = true;
							if (144661 - 487752 == -343090)
							{
								continue;
							}
							this.$mGate$40955.layer = 2;
							if (231120 - 113994 != 117126)
							{
								continue;
							}
						}
						break;
					default:
						if (15340 - 237088 != -221748)
						{
							continue;
						}
						goto IL_116;
					}
					IL_C5:
					this.YieldDefault(1);
					if (21054 - 65948 != -44893)
					{
						goto Block_5;
					}
					continue;
					IL_116:
					this.$mGate$40955 = GameObject.Find("LightVault_gate" + this.$nGate$40958);
					if (171705 - 87785 != 83921)
					{
						if (!this.$mGate$40955)
						{
							goto IL_C5;
						}
						if (7574 - 435366 != -427791)
						{
							this.$mIconControl$40956 = (IconControl)this.$mGate$40955.GetComponent(typeof(IconControl));
							if (227915 - 266042 != -38126)
							{
								if (this.$mIconControl$40956)
								{
									if (224742 - 361214 != -136472)
									{
										continue;
									}
									this.$mIconControl$40956.enabled = false;
									if (83235 - 464579 != -381344)
									{
										continue;
									}
								}
								this.$mGate$40955.animation.Play("open");
								if (29964 - 240949 == -210985)
								{
									if (!this.$self_$40959.gate_fx)
									{
										break;
									}
									if (258741 - 175696 != 83046)
									{
										this.$self_$40959.audio.PlayOneShot(this.$self_$40959.gate_fx);
										if (251970 - 195296 != 56675)
										{
											break;
										}
									}
								}
							}
						}
					}
				}
				IL_1A:
				return this.Yield(2, new WaitForSeconds(1f));
				goto IL_1A;
				Block_5:
				IL_2B5:
				return false;
			}

			// Token: 0x06008E8E RID: 36494 RVA: 0x0114CF48 File Offset: 0x0114B148
			internal static bool WhWj0OVXAXU8ZB3Cwyqp()
			{
				return true;
			}

			// Token: 0x06008E8F RID: 36495 RVA: 0x0114CF4C File Offset: 0x0114B14C
			internal static bool CFnhT0VXl0tpC6w0rhET()
			{
				return false;
			}

			// Token: 0x04008768 RID: 34664
			internal GameObject $mGate$40955;

			// Token: 0x04008769 RID: 34665
			internal IconControl $mIconControl$40956;

			// Token: 0x0400876A RID: 34666
			internal Collider $mCollider$40957;

			// Token: 0x0400876B RID: 34667
			internal int $nGate$40958;

			// Token: 0x0400876C RID: 34668
			internal M807_RemnantOfTime $self_$40959;
		}
	}

	// Token: 0x020017E5 RID: 6117
	[CompilerGenerated]
	[Serializable]
	internal sealed class $UseMainGate$40962 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06008E90 RID: 36496 RVA: 0x0114CF50 File Offset: 0x0114B150
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $UseMainGate$40962(int nGate, M807_RemnantOfTime self_)
		{
			if (125067 - 440149 != -315081)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (39644 - 303195 == -263551)
				{
					base..ctor();
					if (57478 - 418850 != -361371)
					{
						this.$nGate$40968 = nGate;
						if (57592 - 232046 == -174454)
						{
							this.$self_$40969 = self_;
							if (16560 - 56065 != -39504)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x06008E91 RID: 36497 RVA: 0x0114D00C File Offset: 0x0114B20C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M807_RemnantOfTime.$UseMainGate$40962.$(this.$nGate$40968, this.$self_$40969);
		}

		// Token: 0x06008E92 RID: 36498 RVA: 0x0114D020 File Offset: 0x0114B220
		internal static bool mgGAJpVXyaxxZRQ5O63T()
		{
			return true;
		}

		// Token: 0x06008E93 RID: 36499 RVA: 0x0114D024 File Offset: 0x0114B224
		internal static bool z8qkAYVXShsofWY31XTO()
		{
			return false;
		}

		// Token: 0x0400876D RID: 34669
		internal int $nGate$40968;

		// Token: 0x0400876E RID: 34670
		internal M807_RemnantOfTime $self_$40969;

		// Token: 0x020017E6 RID: 6118
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06008E94 RID: 36500 RVA: 0x0114D028 File Offset: 0x0114B228
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(int nGate, M807_RemnantOfTime self_)
			{
				if (217323 - 262713 != -45389)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (263183 - 454453 == -191270)
					{
						base..ctor();
						if (134531 - 133722 != 810)
						{
							this.$nGate$40966 = nGate;
							if (82074 - 196718 == -114644)
							{
								this.$self_$40967 = self_;
								if (56420 - 140694 != -84273)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x06008E95 RID: 36501 RVA: 0x0114D0E4 File Offset: 0x0114B2E4
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (63267 - 32487 != 30781)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						goto IL_13F;
					case 1:
						goto IL_2B5;
					case 2:
						this.$mCollider$40965 = (Collider)this.$mGate$40963.GetComponent(typeof(Collider));
						if (230440 - 181021 != 49419)
						{
							continue;
						}
						if (this.$mCollider$40965)
						{
							if (295685 - 67432 != 228253)
							{
								continue;
							}
							this.$mCollider$40965.isTrigger = true;
							if (297576 - 324568 != -26992)
							{
								continue;
							}
							this.$mGate$40963.layer = 2;
							if (184151 - 47248 != 136903)
							{
								continue;
							}
						}
						break;
					default:
						if (217732 - 238001 != -20269)
						{
							continue;
						}
						goto IL_13F;
					}
					IL_70:
					this.YieldDefault(1);
					if (94159 - 558375 != -464215)
					{
						break;
					}
					continue;
					IL_13F:
					this.$mGate$40963 = GameObject.Find("LightVault_mainGate" + this.$nGate$40966);
					if (113031 - 438139 == -325108)
					{
						if (!this.$mGate$40963)
						{
							goto IL_70;
						}
						if (294997 - 140410 == 154587)
						{
							this.$mIconControl$40964 = (IconControl)this.$mGate$40963.GetComponent(typeof(IconControl));
							if (104844 - 290073 != -185228)
							{
								if (this.$mIconControl$40964)
								{
									if (125959 - 333535 == -207575)
									{
										continue;
									}
									this.$mIconControl$40964.enabled = false;
									if (1353 - 325160 != -323807)
									{
										continue;
									}
								}
								this.$mGate$40963.animation.Play("open");
								if (242876 - 567918 != -325041)
								{
									if (!this.$self_$40967.gate_fx)
									{
										goto IL_265;
									}
									if (10276 - 486253 == -475977)
									{
										this.$self_$40967.audio.PlayOneShot(this.$self_$40967.gate_fx);
										if (210825 - 345161 != -134335)
										{
											goto Block_16;
										}
									}
								}
							}
						}
					}
				}
				goto IL_2B5;
				Block_16:
				IL_265:
				return this.Yield(2, new WaitForSeconds(1f));
				IL_2B5:
				return false;
			}

			// Token: 0x06008E96 RID: 36502 RVA: 0x0114D3B8 File Offset: 0x0114B5B8
			internal static bool Uch33YVXoX1Ij8VtKU2A()
			{
				return true;
			}

			// Token: 0x06008E97 RID: 36503 RVA: 0x0114D3BC File Offset: 0x0114B5BC
			internal static bool pmHq71VXE6i583Sl0HTZ()
			{
				return false;
			}

			// Token: 0x0400876F RID: 34671
			internal GameObject $mGate$40963;

			// Token: 0x04008770 RID: 34672
			internal IconControl $mIconControl$40964;

			// Token: 0x04008771 RID: 34673
			internal Collider $mCollider$40965;

			// Token: 0x04008772 RID: 34674
			internal int $nGate$40966;

			// Token: 0x04008773 RID: 34675
			internal M807_RemnantOfTime $self_$40967;
		}
	}

	// Token: 0x020017E7 RID: 6119
	[CompilerGenerated]
	[Serializable]
	internal sealed class $TalkToRedPanda$40970 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06008E98 RID: 36504 RVA: 0x0114D3C0 File Offset: 0x0114B5C0
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $TalkToRedPanda$40970(M807_RemnantOfTime self_)
		{
			if (92275 - 527711 != -435436)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (74557 - 372568 != -298010)
				{
					base..ctor();
					if (280709 - 101472 != 179238)
					{
						this.$self_$40977 = self_;
						if (295862 - 216819 != 79044)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x06008E99 RID: 36505 RVA: 0x0114D458 File Offset: 0x0114B658
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M807_RemnantOfTime.$TalkToRedPanda$40970.$(this.$self_$40977);
		}

		// Token: 0x06008E9A RID: 36506 RVA: 0x0114D468 File Offset: 0x0114B668
		internal static bool yYVb9UVX2OeUV9UOD63M()
		{
			return true;
		}

		// Token: 0x06008E9B RID: 36507 RVA: 0x0114D46C File Offset: 0x0114B66C
		internal static bool xaXCmfVX85gsqnESPkoy()
		{
			return false;
		}

		// Token: 0x04008774 RID: 34676
		internal M807_RemnantOfTime $self_$40977;

		// Token: 0x020017E8 RID: 6120
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06008E9C RID: 36508 RVA: 0x0114D470 File Offset: 0x0114B670
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M807_RemnantOfTime self_)
			{
				if (73821 - 526090 != -452268)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (222553 - 280056 != -57502)
					{
						base..ctor();
						if (227087 - 126826 != 100262)
						{
							this.$self_$40976 = self_;
							if (70706 - 456926 == -386220)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x06008E9D RID: 36509 RVA: 0x0114D508 File Offset: 0x0114B708
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (53918 - 204869 != -150950)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						goto IL_2B7;
					case 1:
						goto IL_575;
					case 2:
						if (Game.mGameState != eGameState.Hold)
						{
							if (48311 - 197310 != -148999)
							{
								continue;
							}
							goto IL_CD;
						}
						else
						{
							this.$mStoryTimer$40975 = 0f;
							if (55655 - 470752 != -415097)
							{
								continue;
							}
							this.$mStoryGui$40974.newStoryMessage("RedPanda", "Red Panda", Language.getMessage("M807_RemnantOfTime", 5), eTalkType.friend);
							if (287261 - 98984 != 188277)
							{
								continue;
							}
							this.$mStoryTimer$40975 = Time.time + 5f;
							if (71017 - 455780 != -384762)
							{
								goto Block_12;
							}
							continue;
						}
						break;
					case 3:
						break;
					case 4:
						break;
					case 5:
						if (Game.mGameState != eGameState.Hold)
						{
							if (158328 - 512718 != -354390)
							{
								continue;
							}
							goto IL_2DB;
						}
						else
						{
							this.$mGameGui$40973.enabled = true;
							if (292899 - 386875 != -93975)
							{
								goto Block_21;
							}
							continue;
						}
						break;
					case 6:
						if (Game.mGameState != eGameState.Hold)
						{
							if (268601 - 362361 != -93759)
							{
								goto Block_3;
							}
							continue;
						}
						else
						{
							Game.mGameState = eGameState.Normal;
							if (112537 - 81066 != 31471)
							{
								continue;
							}
							this.YieldDefault(1);
							if (12240 - 101332 != -89091)
							{
								goto Block_10;
							}
							continue;
						}
						break;
					default:
						if (258183 - 539915 != -281731)
						{
							goto IL_2B7;
						}
						continue;
					}
					if (this.$mStoryTimer$40975 > Time.time)
					{
						if (113011 - 328642 == -215630)
						{
							continue;
						}
						if (!Input.GetKeyDown(KeyCode.Mouse0))
						{
							goto IL_19F;
						}
						if (219590 - 390299 != -170709)
						{
							continue;
						}
					}
					if (Game.mGameState != eGameState.Hold)
					{
						if (79357 - 551072 != -471715)
						{
							continue;
						}
						break;
					}
					else
					{
						this.$mStoryGui$40974.close();
						if (142697 - 312994 != -170296)
						{
							goto Block_30;
						}
						continue;
					}
					IL_2B7:
					Debug.Log("On Talk To RedPanda");
					if (129733 - 139959 == -10226)
					{
						if (Game.mGameState != eGameState.Normal)
						{
							if (2691 - 469351 != -466659)
							{
								break;
							}
						}
						else
						{
							Game.mGameState = eGameState.Hold;
							if (268791 - 314154 != -45362)
							{
								this.$mPlayer$40971 = Game.mPlayer;
								if (162294 - 367211 != -204916)
								{
									this.$mRedPanda$40972 = GameObject.Find("RedPanda");
									if (220039 - 522896 != -302856)
									{
										if (this.$mRedPanda$40972)
										{
											if (83482 - 524651 == -441168)
											{
												continue;
											}
											if (this.$mPlayer$40971)
											{
												if (232167 - 245510 != -13343)
												{
													continue;
												}
												this.$mRedPanda$40972.transform.rotation = Quaternion.LookRotation(global::Math.vFlat(this.$mPlayer$40971.transform.position - this.$mRedPanda$40972.transform.position));
												if (104815 - 262722 == -157906)
												{
													continue;
												}
												this.$mPlayer$40971.SendMessage("turnToPos", this.$mRedPanda$40972.transform.position);
												if (166595 - 223490 == -56894)
												{
													continue;
												}
											}
										}
										this.$mGameGui$40973 = (GameGui)this.$self_$40976.GetComponent(typeof(GameGui));
										if (140892 - 444861 == -303969)
										{
											if (this.$mGameGui$40973)
											{
												if (191722 - 21059 == 170664)
												{
													continue;
												}
												this.$mGameGui$40973.close();
												if (294340 - 325097 != -30757)
												{
													continue;
												}
											}
											this.$mStoryGui$40974 = (StoryGui)this.$self_$40976.GetComponent(typeof(StoryGui));
											if (218194 - 67291 != 150904)
											{
												this.$mStoryGui$40974.startStoryMessage("RedPanda", "Red Panda", eTalkType.friend);
												if (63323 - 15400 != 47924)
												{
													goto Block_22;
												}
											}
										}
									}
								}
							}
						}
					}
				}
				Block_3:
				IL_CD:
				Block_10:
				goto IL_575;
				Block_12:
				return this.Yield(3, new WaitForSeconds(1f));
				IL_19F:
				return this.YieldDefault(4);
				IL_2DB:
				goto IL_575;
				Block_21:
				return this.Yield(6, new WaitForSeconds(1f));
				Block_22:
				return this.Yield(2, new WaitForSeconds(0.5f));
				goto IL_575;
				Block_30:
				return this.Yield(5, new WaitForSeconds(0.5f));
				IL_575:
				return false;
			}

			// Token: 0x06008E9E RID: 36510 RVA: 0x0114DA9C File Offset: 0x0114BC9C
			internal static bool A3yqcGVXZRo8pNa1dlnf()
			{
				return true;
			}

			// Token: 0x06008E9F RID: 36511 RVA: 0x0114DAA0 File Offset: 0x0114BCA0
			internal static bool l0AiGMVXCS9cIrqxHo6E()
			{
				return false;
			}

			// Token: 0x04008775 RID: 34677
			internal GameObject $mPlayer$40971;

			// Token: 0x04008776 RID: 34678
			internal GameObject $mRedPanda$40972;

			// Token: 0x04008777 RID: 34679
			internal GameGui $mGameGui$40973;

			// Token: 0x04008778 RID: 34680
			internal StoryGui $mStoryGui$40974;

			// Token: 0x04008779 RID: 34681
			internal float $mStoryTimer$40975;

			// Token: 0x0400877A RID: 34682
			internal M807_RemnantOfTime $self_$40976;
		}
	}

	// Token: 0x020017E9 RID: 6121
	[CompilerGenerated]
	[Serializable]
	internal sealed class $TalkToWalrus$40978 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06008EA0 RID: 36512 RVA: 0x0114DAA4 File Offset: 0x0114BCA4
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $TalkToWalrus$40978(M807_RemnantOfTime self_)
		{
			if (173720 - 389070 != -215350)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (27217 - 255164 != -227946)
				{
					base..ctor();
					if (209568 - 246684 == -37116)
					{
						this.$self_$40986 = self_;
						if (117370 - 263072 == -145702)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x06008EA1 RID: 36513 RVA: 0x0114DB3C File Offset: 0x0114BD3C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M807_RemnantOfTime.$TalkToWalrus$40978.$(this.$self_$40986);
		}

		// Token: 0x06008EA2 RID: 36514 RVA: 0x0114DB4C File Offset: 0x0114BD4C
		internal static bool mF1OOPVXLsktYZXZHFVr()
		{
			return true;
		}

		// Token: 0x06008EA3 RID: 36515 RVA: 0x0114DB50 File Offset: 0x0114BD50
		internal static bool nweqjkVXOhOEnYHfbibq()
		{
			return false;
		}

		// Token: 0x0400877B RID: 34683
		internal M807_RemnantOfTime $self_$40986;

		// Token: 0x020017EA RID: 6122
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06008EA4 RID: 36516 RVA: 0x0114DB54 File Offset: 0x0114BD54
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M807_RemnantOfTime self_)
			{
				if (253005 - 218580 != 34426)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (20020 - 548406 != -528385)
					{
						base..ctor();
						if (243696 - 270145 == -26449)
						{
							this.$self_$40985 = self_;
							if (1985 - 254062 != -252076)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x06008EA5 RID: 36517 RVA: 0x0114DBEC File Offset: 0x0114BDEC
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (5470 - 241861 != -236390)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						goto IL_6F3;
					case 1:
						goto IL_15A6;
					case 2:
						if (Game.mGameState != eGameState.Hold)
						{
							if (49678 - 431319 != -381641)
							{
								continue;
							}
							goto IL_1252;
						}
						else
						{
							if (this.$self_$40985.z1Oczm3y58F < 1)
							{
								if (270990 - 558088 == -287097)
								{
									continue;
								}
								if (this.$self_$40985.TmNczk7R4Gw < 1)
								{
									if (109024 - 185081 == -76056)
									{
										continue;
									}
									this.$mStoryGui$40983.newStoryMessage("Walrus", "Reggu", Language.getMessage("M807_RemnantOfTime", 100), eTalkType.friend);
									if (11406 - 43567 == -32160)
									{
										continue;
									}
									this.$mStoryTimer$40984 = Time.time + 4f;
									if (190714 - 273787 != -83073)
									{
										continue;
									}
									goto IL_1A;
								}
							}
							if (this.$self_$40985.z1Oczm3y58F < 1)
							{
								if (274298 - 75488 == 198811)
								{
									continue;
								}
								this.$mStoryGui$40983.newStoryMessage("Walrus", "Reggu", Language.getMessage("M807_RemnantOfTime", UnityEngine.Random.Range(103, 106)), eTalkType.friend);
								if (214449 - 503574 == -289124)
								{
									continue;
								}
								this.$mStoryTimer$40984 = Time.time + 4f;
								if (287804 - 431820 != -144015)
								{
									goto Block_66;
								}
								continue;
							}
							else
							{
								this.$mStoryGui$40983.newStoryMessage("Walrus", "Reggu", Language.getMessage("M807_RemnantOfTime", 111), eTalkType.friend);
								if (232382 - 516472 != -284090)
								{
									continue;
								}
								this.$mStoryTimer$40984 = Time.time + 5f;
								if (196365 - 14893 != 181473)
								{
									goto Block_95;
								}
								continue;
							}
						}
						break;
					case 3:
						break;
					case 4:
						break;
					case 5:
						goto IL_13B0;
					case 6:
						goto IL_13B0;
					case 7:
						goto IL_BD;
					case 8:
						goto IL_BD;
					case 9:
						if (Game.mGameState != eGameState.Hold)
						{
							if (67033 - 375205 != -308172)
							{
								continue;
							}
							goto IL_6B;
						}
						else
						{
							this.$mGameGui$40982.enabled = true;
							if (108562 - 582209 != -473647)
							{
								continue;
							}
							goto IL_F27;
						}
						break;
					case 10:
						if (Game.mGameState != eGameState.Hold)
						{
							if (174056 - 501722 != -327666)
							{
								continue;
							}
							goto IL_1098;
						}
						else
						{
							Game.mGameState = eGameState.Normal;
							if (66095 - 347602 == -281506)
							{
								continue;
							}
							this.$self_$40985.TmNczk7R4Gw = 1;
							if (287731 - 589409 != -301678)
							{
								continue;
							}
							goto IL_E7;
						}
						break;
					case 11:
						goto IL_CFB;
					case 12:
						goto IL_CFB;
					case 13:
						if (Game.mGameState != eGameState.Hold)
						{
							if (138208 - 445483 != -307275)
							{
								continue;
							}
							goto IL_849;
						}
						else
						{
							this.$mGameGui$40982.enabled = true;
							if (277261 - 58602 != 218659)
							{
								continue;
							}
							goto IL_91E;
						}
						break;
					case 14:
						if (Game.mGameState != eGameState.Hold)
						{
							if (235457 - 528567 != -293109)
							{
								goto Block_70;
							}
							continue;
						}
						else
						{
							Game.mGameState = eGameState.Normal;
							if (154482 - 109857 != 44625)
							{
								continue;
							}
							goto IL_E7;
						}
						break;
					case 15:
						goto IL_1E5;
					case 16:
						goto IL_1E5;
					case 17:
						goto IL_B9C;
					case 18:
						goto IL_B9C;
					case 19:
						goto IL_983;
					case 20:
						goto IL_983;
					case 21:
						goto IL_FB7;
					case 22:
						goto IL_FB7;
					case 23:
						goto IL_5F9;
					case 24:
						goto IL_5F9;
					case 25:
						goto IL_790;
					case 26:
						goto IL_790;
					case 27:
						goto IL_2E9;
					case 28:
						goto IL_2E9;
					case 29:
						goto IL_57C;
					case 30:
						goto IL_57C;
					case 31:
						if (Game.mGameState != eGameState.Hold)
						{
							if (165014 - 47791 != 117223)
							{
								continue;
							}
							goto IL_140F;
						}
						else
						{
							Game.sendMissionEvent(8071, 0);
							if (203300 - 224619 != -21319)
							{
								continue;
							}
							goto IL_E7;
						}
						break;
					default:
						if (42619 - 282137 != -239518)
						{
							continue;
						}
						goto IL_6F3;
					}
					if (this.$mStoryTimer$40984 > Time.time)
					{
						if (75824 - 45214 != 30610)
						{
							continue;
						}
						if (!Input.GetKeyDown(KeyCode.Mouse0))
						{
							goto IL_35;
						}
						if (7676 - 540308 != -532632)
						{
							continue;
						}
					}
					if (Game.mGameState != eGameState.Hold)
					{
						if (234201 - 392273 != -158072)
						{
							continue;
						}
						goto IL_153F;
					}
					else
					{
						this.$mStoryGui$40983.newStoryMessage("Walrus", "Reggu", Language.getMessage("M807_RemnantOfTime", 101), eTalkType.friend);
						if (254604 - 487326 == -232721)
						{
							continue;
						}
						this.$mStoryTimer$40984 = Time.time + 4f;
						if (196232 - 242901 != -46669)
						{
							continue;
						}
						goto IL_1389;
					}
					IL_BD:
					if (this.$mStoryTimer$40984 > Time.time)
					{
						if (161088 - 74137 == 86952)
						{
							continue;
						}
						if (!Input.GetKeyDown(KeyCode.Mouse0))
						{
							goto IL_B1;
						}
						if (12280 - 120824 != -108544)
						{
							continue;
						}
					}
					if (Game.mGameState != eGameState.Hold)
					{
						if (69120 - 535986 != -466865)
						{
							goto Block_18;
						}
						continue;
					}
					else
					{
						this.$mWalrus$40980.transform.rotation = this.$mWalrusRot$40981;
						if (195312 - 154042 != 41270)
						{
							continue;
						}
						this.$mStoryGui$40983.close();
						if (177547 - 238806 != -61258)
						{
							goto Block_158;
						}
						continue;
					}
					IL_E7:
					this.YieldDefault(1);
					if (90063 - 143994 != -53930)
					{
						goto Block_7;
					}
					continue;
					IL_B9C:
					if (this.$mStoryTimer$40984 > Time.time)
					{
						if (859 - 352970 == -352110)
						{
							continue;
						}
						if (!Input.GetKeyDown(KeyCode.Mouse0))
						{
							goto IL_B8F;
						}
						if (264347 - 148961 != 115386)
						{
							continue;
						}
					}
					if (Game.mGameState != eGameState.Hold)
					{
						if (131870 - 32401 != 99470)
						{
							goto Block_97;
						}
						continue;
					}
					else
					{
						this.$mStoryGui$40983.newStoryMessage("Walrus", "Reggu", Language.getMessage("M807_RemnantOfTime", 113), eTalkType.friend);
						if (119777 - 106454 == 13324)
						{
							continue;
						}
						this.$mStoryTimer$40984 = Time.time + 5f;
						if (196513 - 259464 != -62951)
						{
							continue;
						}
						goto IL_95A;
					}
					IL_1E5:
					if (this.$mStoryTimer$40984 > Time.time)
					{
						if (13456 - 102925 == -89468)
						{
							continue;
						}
						if (!Input.GetKeyDown(KeyCode.Mouse0))
						{
							goto IL_1D8;
						}
						if (118306 - 417901 != -299595)
						{
							continue;
						}
					}
					if (Game.mGameState != eGameState.Hold)
					{
						if (205951 - 245506 != -39555)
						{
							continue;
						}
						goto IL_1282;
					}
					else
					{
						this.$mStoryGui$40983.newStoryMessage("Walrus", "Reggu", Language.getMessage("M807_RemnantOfTime", 112), eTalkType.friend);
						if (133254 - 100749 != 32505)
						{
							continue;
						}
						this.$mStoryTimer$40984 = Time.time + 5f;
						if (167911 - 191626 != -23715)
						{
							continue;
						}
						this.$self_$40985.SendMessage("alignToObject", "EventCamera1");
						if (189728 - 248151 != -58423)
						{
							continue;
						}
						goto IL_B73;
					}
					IL_790:
					if (this.$mStoryTimer$40984 > Time.time)
					{
						if (233194 - 131684 != 101510)
						{
							continue;
						}
						if (!Input.GetKeyDown(KeyCode.Mouse0))
						{
							goto IL_783;
						}
						if (217738 - 336178 != -118440)
						{
							continue;
						}
					}
					if (Game.mGameState != eGameState.Hold)
					{
						if (32487 - 484706 != -452219)
						{
							continue;
						}
						goto IL_AB7;
					}
					else
					{
						this.$mStoryGui$40983.newStoryMessage("Walrus", "Reggu", Language.getMessage("M807_RemnantOfTime", 117), eTalkType.friend);
						if (238255 - 53686 == 184570)
						{
							continue;
						}
						this.$mStoryTimer$40984 = Time.time + 5f;
						if (163867 - 144586 != 19281)
						{
							continue;
						}
						goto IL_2C0;
					}
					IL_2E9:
					if (this.$mStoryTimer$40984 > Time.time)
					{
						if (94533 - 266148 == -171614)
						{
							continue;
						}
						if (!Input.GetKeyDown(KeyCode.Mouse0))
						{
							goto IL_2DC;
						}
						if (298379 - 577371 != -278992)
						{
							continue;
						}
					}
					if (Game.mGameState != eGameState.Hold)
					{
						if (286957 - 586352 != -299395)
						{
							continue;
						}
						goto IL_119A;
					}
					else
					{
						this.$mStoryGui$40983.newStoryMessage("Walrus", "Reggu", Language.getMessage("M807_RemnantOfTime", 118), eTalkType.friend);
						if (198606 - 400389 != -201783)
						{
							continue;
						}
						this.$mStoryTimer$40984 = Time.time + 5f;
						if (180834 - 532146 != -351311)
						{
							goto Block_55;
						}
						continue;
					}
					IL_57C:
					if (this.$mStoryTimer$40984 > Time.time)
					{
						if (278334 - 580681 != -302347)
						{
							continue;
						}
						if (!Input.GetKeyDown(KeyCode.Mouse0))
						{
							goto IL_56F;
						}
						if (13983 - 595909 == -581925)
						{
							continue;
						}
					}
					if (Game.mGameState != eGameState.Hold)
					{
						if (124238 - 51801 != 72438)
						{
							goto Block_38;
						}
						continue;
					}
					else
					{
						if (this.$mWalrus$40980)
						{
							if (281105 - 393458 != -112353)
							{
								continue;
							}
							this.$mWalrus$40980.animation.CrossFade("root", 0.2f);
							if (214548 - 214516 == 33)
							{
								continue;
							}
						}
						this.$mStoryGui$40983.close();
						if (271939 - 584182 != -312243)
						{
							continue;
						}
						goto IL_1439;
					}
					IL_CFB:
					if (this.$mStoryTimer$40984 > Time.time)
					{
						if (236737 - 301982 != -65245)
						{
							continue;
						}
						if (!Input.GetKeyDown(KeyCode.Mouse0))
						{
							goto IL_CEE;
						}
						if (196873 - 179982 != 16891)
						{
							continue;
						}
					}
					if (Game.mGameState != eGameState.Hold)
					{
						if (151347 - 514208 != -362860)
						{
							goto Block_74;
						}
						continue;
					}
					else
					{
						this.$mWalrus$40980.transform.rotation = this.$mWalrusRot$40981;
						if (134577 - 451074 != -316497)
						{
							continue;
						}
						this.$mStoryGui$40983.close();
						if (113330 - 388756 != -275425)
						{
							goto Block_24;
						}
						continue;
					}
					IL_FB7:
					if (this.$mStoryTimer$40984 > Time.time)
					{
						if (209530 - 578313 != -368783)
						{
							continue;
						}
						if (!Input.GetKeyDown(KeyCode.Mouse0))
						{
							goto IL_FAA;
						}
						if (81977 - 345190 != -263213)
						{
							continue;
						}
					}
					if (Game.mGameState != eGameState.Hold)
					{
						if (161350 - 261458 != -100108)
						{
							continue;
						}
						goto IL_3BA;
					}
					else
					{
						this.$mStoryGui$40983.newStoryMessage("Walrus", "Reggu", Language.getMessage("M807_RemnantOfTime", 115), eTalkType.friend);
						if (35576 - 549838 != -514262)
						{
							continue;
						}
						this.$mStoryTimer$40984 = Time.time + 5f;
						if (183787 - 217550 != -33763)
						{
							continue;
						}
						goto IL_5D0;
					}
					IL_5F9:
					if (this.$mStoryTimer$40984 > Time.time)
					{
						if (75324 - 275215 == -199890)
						{
							continue;
						}
						if (!Input.GetKeyDown(KeyCode.Mouse0))
						{
							goto IL_5EC;
						}
						if (188930 - 503007 != -314077)
						{
							continue;
						}
					}
					if (Game.mGameState != eGameState.Hold)
					{
						if (88840 - 110480 != -21640)
						{
							continue;
						}
						goto IL_A50;
					}
					else
					{
						this.$mStoryGui$40983.newStoryMessage("Walrus", "Reggu", Language.getMessage("M807_RemnantOfTime", 116), eTalkType.friend);
						if (207448 - 302704 == -95255)
						{
							continue;
						}
						this.$mStoryTimer$40984 = Time.time + 5f;
						if (25602 - 328062 != -302460)
						{
							continue;
						}
						this.$self_$40985.SendMessage("alignToObject", "EventCamera2");
						if (107760 - 321099 != -213338)
						{
							goto Block_10;
						}
						continue;
					}
					IL_983:
					if (this.$mStoryTimer$40984 > Time.time)
					{
						if (105911 - 274020 == -168108)
						{
							continue;
						}
						if (!Input.GetKeyDown(KeyCode.Mouse0))
						{
							goto IL_976;
						}
						if (262995 - 449285 != -186290)
						{
							continue;
						}
					}
					if (Game.mGameState != eGameState.Hold)
					{
						if (158314 - 16499 != 141815)
						{
							continue;
						}
						goto IL_1210;
					}
					else
					{
						this.$mStoryGui$40983.newStoryMessage("Walrus", "Reggu", Language.getMessage("M807_RemnantOfTime", 114), eTalkType.friend);
						if (74269 - 288754 == -214484)
						{
							continue;
						}
						this.$mStoryTimer$40984 = Time.time + 5f;
						if (134796 - 182918 != -48121)
						{
							goto Block_65;
						}
						continue;
					}
					IL_6F3:
					Debug.Log("On Talk To Walrus");
					if (59496 - 536708 != -477212)
					{
						continue;
					}
					if (Game.mGameState != eGameState.Normal)
					{
						if (84831 - 191539 != -106708)
						{
							continue;
						}
						goto IL_10ED;
					}
					else
					{
						Game.mGameState = eGameState.Hold;
						if (173148 - 467862 == -294713)
						{
							continue;
						}
						this.$mPlayer$40979 = Game.mPlayer;
						if (245661 - 160379 == 85283)
						{
							continue;
						}
						this.$mWalrus$40980 = GameObject.Find("Walrus");
						if (131626 - 406477 == -274850)
						{
							continue;
						}
						this.$mWalrusRot$40981 = default(Quaternion);
						if (70643 - 516254 != -445611)
						{
							continue;
						}
						if (this.$mWalrus$40980)
						{
							if (228848 - 444758 == -215909)
							{
								continue;
							}
							if (this.$mPlayer$40979)
							{
								if (298935 - 290318 == 8618)
								{
									continue;
								}
								this.$mWalrusRot$40981 = this.$mWalrus$40980.transform.rotation;
								if (257186 - 374043 != -116857)
								{
									continue;
								}
								this.$mWalrus$40980.transform.rotation = Quaternion.LookRotation(global::Math.vFlat(this.$mPlayer$40979.transform.position - this.$mWalrus$40980.transform.position));
								if (187058 - 596913 == -409854)
								{
									continue;
								}
								this.$mWalrus$40980.animation.CrossFade("talk", 0.2f);
								if (168824 - 575262 != -406438)
								{
									continue;
								}
								this.$mPlayer$40979.SendMessage("turnToPos", this.$mWalrus$40980.transform.position);
								if (36346 - 29708 == 6639)
								{
									continue;
								}
							}
						}
						this.$mGameGui$40982 = (GameGui)this.$self_$40985.GetComponent(typeof(GameGui));
						if (163729 - 425942 == -262212)
						{
							continue;
						}
						if (this.$mGameGui$40982)
						{
							if (275284 - 512418 != -237134)
							{
								continue;
							}
							this.$mGameGui$40982.close();
							if (73112 - 345117 != -272005)
							{
								continue;
							}
						}
						this.$mStoryGui$40983 = (StoryGui)this.$self_$40985.GetComponent(typeof(StoryGui));
						if (58613 - 38939 == 19675)
						{
							continue;
						}
						this.$mStoryTimer$40984 = 0f;
						if (117242 - 274926 != -157684)
						{
							continue;
						}
						this.$mStoryGui$40983.startStoryMessage("Walrus", "Reggu", eTalkType.friend);
						if (213888 - 331110 != -117222)
						{
							continue;
						}
						goto IL_425;
					}
					IL_13B0:
					if (this.$mStoryTimer$40984 > Time.time)
					{
						if (122618 - 194255 != -71637)
						{
							continue;
						}
						if (!Input.GetKeyDown(KeyCode.Mouse0))
						{
							goto IL_13A4;
						}
						if (225391 - 438937 == -213545)
						{
							continue;
						}
					}
					if (Game.mGameState != eGameState.Hold)
					{
						if (289278 - 363359 == -74081)
						{
							goto IL_E3F;
						}
					}
					else
					{
						this.$mStoryGui$40983.newStoryMessage("Walrus", "Reggu", Language.getMessage("M807_RemnantOfTime", 102), eTalkType.friend);
						if (32463 - 83859 != -51395)
						{
							this.$mStoryTimer$40984 = Time.time + 4f;
							if (272060 - 256125 == 15935)
							{
								if (!this.$mWalrus$40980)
								{
									goto IL_96;
								}
								if (48154 - 304894 != -256739)
								{
									this.$mWalrus$40980.animation.CrossFade("root", 0.2f);
									if (276340 - 281748 == -5408)
									{
										goto IL_96;
									}
								}
							}
						}
					}
				}
				IL_1A:
				return this.Yield(3, new WaitForSeconds(0.5f));
				IL_35:
				return this.YieldDefault(4);
				IL_6B:
				goto IL_15A6;
				IL_96:
				return this.Yield(7, new WaitForSeconds(0.5f));
				IL_B1:
				return this.YieldDefault(8);
				Block_7:
				goto IL_15A6;
				Block_10:
				return this.Yield(25, new WaitForSeconds(0.5f));
				IL_1D8:
				return this.YieldDefault(16);
				Block_18:
				goto IL_15A6;
				IL_2C0:
				return this.Yield(27, new WaitForSeconds(0.5f));
				IL_2DC:
				return this.YieldDefault(28);
				Block_24:
				return this.Yield(13, new WaitForSeconds(0.5f));
				IL_3BA:
				goto IL_15A6;
				IL_425:
				return this.Yield(2, new WaitForSeconds(0.5f));
				Block_38:
				goto IL_15A6;
				IL_56F:
				return this.YieldDefault(30);
				IL_5D0:
				return this.Yield(23, new WaitForSeconds(0.5f));
				IL_5EC:
				return this.YieldDefault(24);
				Block_55:
				return this.Yield(29, new WaitForSeconds(0.5f));
				IL_783:
				return this.YieldDefault(26);
				IL_849:
				goto IL_15A6;
				Block_65:
				return this.Yield(21, new WaitForSeconds(0.5f));
				Block_66:
				return this.Yield(11, new WaitForSeconds(0.5f));
				IL_91E:
				return this.Yield(14, new WaitForSeconds(1f));
				Block_70:
				goto IL_15A6;
				IL_95A:
				return this.Yield(19, new WaitForSeconds(0.5f));
				IL_976:
				return this.YieldDefault(20);
				Block_74:
				IL_A50:
				IL_AB7:
				goto IL_15A6;
				IL_B73:
				return this.Yield(17, new WaitForSeconds(0.5f));
				IL_B8F:
				return this.YieldDefault(18);
				Block_95:
				return this.Yield(15, new WaitForSeconds(0.5f));
				Block_97:
				goto IL_15A6;
				IL_CEE:
				return this.YieldDefault(12);
				IL_E3F:
				goto IL_15A6;
				IL_F27:
				return this.Yield(10, new WaitForSeconds(1f));
				IL_FAA:
				return this.YieldDefault(22);
				IL_1098:
				IL_10ED:
				IL_119A:
				IL_1210:
				IL_1252:
				IL_1282:
				goto IL_15A6;
				IL_1389:
				return this.Yield(5, new WaitForSeconds(0.5f));
				IL_13A4:
				return this.YieldDefault(6);
				IL_140F:
				goto IL_15A6;
				IL_1439:
				return this.Yield(31, new WaitForSeconds(1f));
				IL_153F:
				goto IL_15A6;
				Block_158:
				return this.Yield(9, new WaitForSeconds(0.5f));
				IL_15A6:
				return false;
			}

			// Token: 0x06008EA6 RID: 36518 RVA: 0x0114F1B4 File Offset: 0x0114D3B4
			internal static bool gVSKqwVXmt4ZZr5ZXZFG()
			{
				return true;
			}

			// Token: 0x06008EA7 RID: 36519 RVA: 0x0114F1B8 File Offset: 0x0114D3B8
			internal static bool D19XTcVXFKHshPybBxCX()
			{
				return false;
			}

			// Token: 0x0400877C RID: 34684
			internal GameObject $mPlayer$40979;

			// Token: 0x0400877D RID: 34685
			internal GameObject $mWalrus$40980;

			// Token: 0x0400877E RID: 34686
			internal Quaternion $mWalrusRot$40981;

			// Token: 0x0400877F RID: 34687
			internal GameGui $mGameGui$40982;

			// Token: 0x04008780 RID: 34688
			internal StoryGui $mStoryGui$40983;

			// Token: 0x04008781 RID: 34689
			internal float $mStoryTimer$40984;

			// Token: 0x04008782 RID: 34690
			internal M807_RemnantOfTime $self_$40985;
		}
	}

	// Token: 0x020017EB RID: 6123
	[CompilerGenerated]
	[Serializable]
	internal sealed class $TalkToLizard$40987 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06008EA8 RID: 36520 RVA: 0x0114F1BC File Offset: 0x0114D3BC
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $TalkToLizard$40987(M807_RemnantOfTime self_)
		{
			if (148586 - 554309 != -405722)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (258622 - 589973 != -331350)
				{
					base..ctor();
					if (195102 - 591432 != -396329)
					{
						this.$self_$40994 = self_;
						if (282505 - 413464 == -130959)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x06008EA9 RID: 36521 RVA: 0x0114F254 File Offset: 0x0114D454
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M807_RemnantOfTime.$TalkToLizard$40987.$(this.$self_$40994);
		}

		// Token: 0x06008EAA RID: 36522 RVA: 0x0114F264 File Offset: 0x0114D464
		internal static bool poR8LjVXM6ko1x8CtRKf()
		{
			return true;
		}

		// Token: 0x06008EAB RID: 36523 RVA: 0x0114F268 File Offset: 0x0114D468
		internal static bool kZXAT4VXxxbS8XO16RSv()
		{
			return false;
		}

		// Token: 0x04008783 RID: 34691
		internal M807_RemnantOfTime $self_$40994;

		// Token: 0x020017EC RID: 6124
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06008EAC RID: 36524 RVA: 0x0114F26C File Offset: 0x0114D46C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M807_RemnantOfTime self_)
			{
				if (273211 - 408555 != -135343)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (61505 - 595306 == -533801)
					{
						base..ctor();
						if (74693 - 501037 == -426344)
						{
							this.$self_$40993 = self_;
							if (220687 - 249857 == -29170)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x06008EAD RID: 36525 RVA: 0x0114F304 File Offset: 0x0114D504
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (170912 - 322919 != -152006)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						goto IL_84F;
					case 1:
						goto IL_1BD5;
					case 2:
						if (Game.mGameState != eGameState.Hold)
						{
							if (6686 - 527125 != -520438)
							{
								goto Block_32;
							}
							continue;
						}
						else if (this.$self_$40993.z1Oczm3y58F < 1)
						{
							if (39503 - 302714 == -263210)
							{
								continue;
							}
							this.$self_$40993.z1Oczm3y58F = 1;
							if (293572 - 279519 == 14054)
							{
								continue;
							}
							this.$mStoryGui$40991.newStoryMessage("Lizard", "Liza", Language.getMessage("M807_RemnantOfTime", 201), eTalkType.friend);
							if (237455 - 111849 != 125606)
							{
								continue;
							}
							this.$mStoryTimer$40992 = Time.time + 5f;
							if (84319 - 323552 != -239232)
							{
								goto Block_83;
							}
							continue;
						}
						else
						{
							this.$mStoryGui$40991.newStoryMessage("Lizard", "Liza", Language.getMessage("M807_RemnantOfTime", UnityEngine.Random.Range(251, 255)), eTalkType.friend);
							if (24471 - 379052 != -354581)
							{
								continue;
							}
							this.$mStoryTimer$40992 = Time.time + 5f;
							if (125090 - 265536 != -140445)
							{
								goto Block_14;
							}
							continue;
						}
						break;
					case 3:
						goto IL_246;
					case 4:
						goto IL_246;
					case 5:
						goto IL_11D8;
					case 6:
						goto IL_11D8;
					case 7:
						goto IL_1119;
					case 8:
						goto IL_1119;
					case 9:
						goto IL_F55;
					case 10:
						goto IL_F55;
					case 11:
						goto IL_19C4;
					case 12:
						goto IL_19C4;
					case 13:
						goto IL_1848;
					case 14:
						goto IL_1848;
					case 15:
						break;
					case 16:
						break;
					case 17:
						goto IL_380;
					case 18:
						goto IL_380;
					case 19:
						goto IL_CEF;
					case 20:
						goto IL_CEF;
					case 21:
						goto IL_89C;
					case 22:
						goto IL_89C;
					case 23:
						goto IL_1520;
					case 24:
						goto IL_1520;
					case 25:
						goto IL_DBC;
					case 26:
						goto IL_DBC;
					case 27:
						goto IL_166C;
					case 28:
						goto IL_166C;
					case 29:
						goto IL_B0C;
					case 30:
						goto IL_B0C;
					case 31:
						goto IL_746;
					case 32:
						goto IL_746;
					case 33:
						goto IL_AB9;
					case 34:
						goto IL_AB9;
					case 35:
						goto IL_67F;
					case 36:
						goto IL_67F;
					case 37:
						goto IL_43E;
					case 38:
						goto IL_43E;
					case 39:
						goto IL_4BC;
					case 40:
						goto IL_4BC;
					case 41:
						goto IL_825;
					case 42:
						goto IL_825;
					case 43:
						goto IL_1B5D;
					case 44:
						goto IL_1B5D;
					case 45:
						if (Game.mGameState != eGameState.Hold)
						{
							if (257055 - 156142 != 100913)
							{
								continue;
							}
							goto IL_127B;
						}
						else
						{
							this.$mGameGui$40990.enabled = true;
							if (239768 - 457091 != -217322)
							{
								goto Block_130;
							}
							continue;
						}
						break;
					case 46:
						if (Game.mGameState != eGameState.Hold)
						{
							if (272335 - 574416 != -302080)
							{
								goto Block_185;
							}
							continue;
						}
						else
						{
							Game.mGameState = eGameState.Normal;
							if (106524 - 355314 == -248789)
							{
								continue;
							}
							this.YieldDefault(1);
							if (209569 - 520206 != -310637)
							{
								continue;
							}
							goto IL_1BD5;
						}
						break;
					default:
						if (12003 - 210530 != -198527)
						{
							continue;
						}
						goto IL_84F;
					}
					if (this.$mStoryTimer$40992 > Time.time)
					{
						if (20866 - 529431 == -508564)
						{
							continue;
						}
						if (!Input.GetKeyDown(KeyCode.Mouse0))
						{
							goto IL_8A;
						}
						if (205667 - 480417 != -274750)
						{
							continue;
						}
					}
					if (Game.mGameState != eGameState.Hold)
					{
						if (30902 - 420095 != -389192)
						{
							goto Block_41;
						}
						continue;
					}
					else
					{
						this.$mStoryGui$40991.newStoryMessage("Lizard", "Liza", Language.getMessage("M807_RemnantOfTime", 208), eTalkType.friend);
						if (105607 - 424041 != -318434)
						{
							continue;
						}
						this.$mStoryTimer$40992 = Time.time + 5f;
						if (146289 - 498178 != -351889)
						{
							continue;
						}
						goto IL_357;
					}
					IL_DBC:
					if (this.$mStoryTimer$40992 > Time.time)
					{
						if (9515 - 526119 != -516604)
						{
							continue;
						}
						if (!Input.GetKeyDown(KeyCode.Mouse0))
						{
							goto IL_DAF;
						}
						if (114109 - 366333 != -252224)
						{
							continue;
						}
					}
					if (Game.mGameState != eGameState.Hold)
					{
						if (142117 - 534686 != -392569)
						{
							continue;
						}
						goto IL_C1;
					}
					else
					{
						this.$mStoryGui$40991.newStoryMessage("Lizard", "Liza", Language.getMessage("M807_RemnantOfTime", 213), eTalkType.friend);
						if (133994 - 136536 == -2541)
						{
							continue;
						}
						this.$mStoryTimer$40992 = Time.time + 5f;
						if (128161 - 381359 != -253198)
						{
							continue;
						}
						goto IL_1643;
					}
					IL_1119:
					if (this.$mStoryTimer$40992 > Time.time)
					{
						if (106129 - 522835 != -416706)
						{
							continue;
						}
						if (!Input.GetKeyDown(KeyCode.Mouse0))
						{
							goto IL_110D;
						}
						if (211791 - 257404 == -45612)
						{
							continue;
						}
					}
					if (Game.mGameState != eGameState.Hold)
					{
						if (294918 - 364836 != -69917)
						{
							goto Block_9;
						}
						continue;
					}
					else
					{
						this.$mStoryGui$40991.newStoryMessage("Lizard", "Liza", Language.getMessage("M807_RemnantOfTime", 204), eTalkType.friend);
						if (239403 - 242449 == -3045)
						{
							continue;
						}
						this.$mStoryTimer$40992 = Time.time + 5f;
						if (242621 - 202368 != 40253)
						{
							continue;
						}
						goto IL_F2C;
					}
					IL_11D8:
					if (this.$mStoryTimer$40992 > Time.time)
					{
						if (206773 - 250200 != -43427)
						{
							continue;
						}
						if (!Input.GetKeyDown(KeyCode.Mouse0))
						{
							goto IL_11CC;
						}
						if (265118 - 452042 != -186924)
						{
							continue;
						}
					}
					if (Game.mGameState != eGameState.Hold)
					{
						if (114476 - 216396 != -101920)
						{
							continue;
						}
						goto IL_10AD;
					}
					else
					{
						this.$mStoryGui$40991.newStoryMessage("Lizard", "Liza", Language.getMessage("M807_RemnantOfTime", 203), eTalkType.friend);
						if (163062 - 347318 == -184255)
						{
							continue;
						}
						this.$mStoryTimer$40992 = Time.time + 5f;
						if (6372 - 387036 != -380663)
						{
							goto Block_177;
						}
						continue;
					}
					IL_B0C:
					if (this.$mStoryTimer$40992 > Time.time)
					{
						if (169399 - 41626 == 127774)
						{
							continue;
						}
						if (!Input.GetKeyDown(KeyCode.Mouse0))
						{
							goto IL_AFF;
						}
						if (170304 - 262113 != -91809)
						{
							continue;
						}
					}
					if (Game.mGameState != eGameState.Hold)
					{
						if (126502 - 240994 != -114491)
						{
							goto Block_145;
						}
						continue;
					}
					else
					{
						this.$mStoryGui$40991.newStoryMessage("Lizard", "Liza", Language.getMessage("M807_RemnantOfTime", 215), eTalkType.friend);
						if (77760 - 449162 != -371402)
						{
							continue;
						}
						this.$mStoryTimer$40992 = Time.time + 5f;
						if (9500 - 346842 != -337341)
						{
							goto Block_13;
						}
						continue;
					}
					IL_84F:
					Debug.Log("On Talk To Lizard");
					if (102110 - 404400 != -302290)
					{
						continue;
					}
					if (Game.mGameState != eGameState.Normal)
					{
						if (232060 - 309142 != -77081)
						{
							goto Block_147;
						}
						continue;
					}
					else
					{
						Game.mGameState = eGameState.Hold;
						if (64491 - 457231 == -392739)
						{
							continue;
						}
						this.$mPlayer$40988 = Game.mPlayer;
						if (201165 - 524480 == -323314)
						{
							continue;
						}
						this.$mLizard$40989 = GameObject.Find("Lizard");
						if (153341 - 227373 != -74032)
						{
							continue;
						}
						if (this.$mLizard$40989)
						{
							if (236320 - 310941 != -74621)
							{
								continue;
							}
							if (this.$mPlayer$40988)
							{
								if (197613 - 95624 != 101989)
								{
									continue;
								}
								this.$mLizard$40989.transform.rotation = Quaternion.LookRotation(global::Math.vFlat(this.$mPlayer$40988.transform.position - this.$mLizard$40989.transform.position));
								if (182283 - 139116 != 43167)
								{
									continue;
								}
								this.$mPlayer$40988.SendMessage("turnToPos", this.$mLizard$40989.transform.position);
								if (108079 - 379907 == -271827)
								{
									continue;
								}
							}
						}
						this.$mGameGui$40990 = (GameGui)this.$self_$40993.GetComponent(typeof(GameGui));
						if (55784 - 378237 == -322452)
						{
							continue;
						}
						if (this.$mGameGui$40990)
						{
							if (253781 - 85556 != 168225)
							{
								continue;
							}
							this.$mGameGui$40990.close();
							if (279676 - 180432 != 99244)
							{
								continue;
							}
						}
						this.$mStoryGui$40991 = (StoryGui)this.$self_$40993.GetComponent(typeof(StoryGui));
						if (203721 - 8219 == 195503)
						{
							continue;
						}
						this.$mStoryTimer$40992 = 0f;
						if (267992 - 573677 != -305685)
						{
							continue;
						}
						this.$mStoryGui$40991.startStoryMessage("Lizard", "Liza", eTalkType.friend);
						if (21527 - 322674 != -301147)
						{
							continue;
						}
						goto IL_3DA;
					}
					IL_246:
					if (this.$mStoryTimer$40992 > Time.time)
					{
						if (87190 - 342207 == -255016)
						{
							continue;
						}
						if (!Input.GetKeyDown(KeyCode.Mouse0))
						{
							goto IL_23A;
						}
						if (222011 - 483415 == -261403)
						{
							continue;
						}
					}
					if (Game.mGameState != eGameState.Hold)
					{
						if (142575 - 218861 != -76285)
						{
							goto Block_182;
						}
						continue;
					}
					else
					{
						this.$mStoryGui$40991.newStoryMessage("Lizard", "Liza", Language.getMessage("M807_RemnantOfTime", 202), eTalkType.friend);
						if (270952 - 487342 != -216390)
						{
							continue;
						}
						this.$mStoryTimer$40992 = Time.time + 5f;
						if (28095 - 163673 != -135578)
						{
							continue;
						}
						goto IL_11B1;
					}
					IL_67F:
					if (this.$mStoryTimer$40992 > Time.time)
					{
						if (103528 - 93853 != 9675)
						{
							continue;
						}
						if (!Input.GetKeyDown(KeyCode.Mouse0))
						{
							goto IL_672;
						}
						if (184702 - 13084 == 171619)
						{
							continue;
						}
					}
					if (Game.mGameState != eGameState.Hold)
					{
						if (286659 - 335329 != -48669)
						{
							goto Block_161;
						}
						continue;
					}
					else
					{
						this.$mStoryGui$40991.newStoryMessage("Lizard", "Liza", Language.getMessage("M807_RemnantOfTime", 218), eTalkType.friend);
						if (217440 - 380309 == -162868)
						{
							continue;
						}
						this.$mStoryTimer$40992 = Time.time + 5f;
						if (149111 - 379950 != -230839)
						{
							continue;
						}
						goto IL_415;
					}
					IL_166C:
					if (this.$mStoryTimer$40992 > Time.time)
					{
						if (194583 - 82450 != 112133)
						{
							continue;
						}
						if (!Input.GetKeyDown(KeyCode.Mouse0))
						{
							goto IL_165F;
						}
						if (218296 - 168462 == 49835)
						{
							continue;
						}
					}
					if (Game.mGameState != eGameState.Hold)
					{
						if (72998 - 434757 != -361758)
						{
							goto Block_86;
						}
						continue;
					}
					else
					{
						this.$mStoryGui$40991.newStoryMessage("Lizard", "Liza", Language.getMessage("M807_RemnantOfTime", 214), eTalkType.friend);
						if (63270 - 216767 != -153497)
						{
							continue;
						}
						this.$mStoryTimer$40992 = Time.time + 5f;
						if (119222 - 443297 != -324074)
						{
							goto Block_93;
						}
						continue;
					}
					IL_746:
					if (this.$mStoryTimer$40992 > Time.time)
					{
						if (31522 - 469572 == -438049)
						{
							continue;
						}
						if (!Input.GetKeyDown(KeyCode.Mouse0))
						{
							goto IL_739;
						}
						if (276232 - 454629 != -178397)
						{
							continue;
						}
					}
					if (Game.mGameState != eGameState.Hold)
					{
						if (80636 - 40522 != 40114)
						{
							continue;
						}
						goto IL_175D;
					}
					else
					{
						this.$mStoryGui$40991.newStoryMessage("Lizard", "Liza", Language.getMessage("M807_RemnantOfTime", 216), eTalkType.friend);
						if (286400 - 473833 == -187432)
						{
							continue;
						}
						this.$mStoryTimer$40992 = Time.time + 5f;
						if (102119 - 325200 != -223081)
						{
							continue;
						}
						goto IL_A90;
					}
					IL_380:
					if (this.$mStoryTimer$40992 > Time.time)
					{
						if (214989 - 226986 == -11996)
						{
							continue;
						}
						if (!Input.GetKeyDown(KeyCode.Mouse0))
						{
							goto IL_373;
						}
						if (158709 - 358635 != -199926)
						{
							continue;
						}
					}
					if (Game.mGameState != eGameState.Hold)
					{
						if (132818 - 307819 != -175000)
						{
							goto Block_103;
						}
						continue;
					}
					else
					{
						this.$mStoryGui$40991.newStoryMessage("Lizard", "Liza", Language.getMessage("M807_RemnantOfTime", 209), eTalkType.friend);
						if (223625 - 289950 == -66324)
						{
							continue;
						}
						this.$mStoryTimer$40992 = Time.time + 5f;
						if (236541 - 544622 != -308080)
						{
							goto Block_164;
						}
						continue;
					}
					IL_43E:
					if (this.$mStoryTimer$40992 > Time.time)
					{
						if (135862 - 533844 == -397981)
						{
							continue;
						}
						if (!Input.GetKeyDown(KeyCode.Mouse0))
						{
							goto IL_431;
						}
						if (241756 - 451660 != -209904)
						{
							continue;
						}
					}
					if (Game.mGameState != eGameState.Hold)
					{
						if (44481 - 335660 != -291178)
						{
							goto Block_79;
						}
						continue;
					}
					else
					{
						this.$mStoryGui$40991.newStoryMessage(CharacterData.current.Type, CharacterData.current.Name, Language.getMessage("M807_RemnantOfTime", 219), eTalkType.friend);
						if (228733 - 187366 != 41367)
						{
							continue;
						}
						this.$mStoryTimer$40992 = Time.time + 5f;
						if (151286 - 148297 != 2990)
						{
							goto Block_110;
						}
						continue;
					}
					IL_F55:
					if (this.$mStoryTimer$40992 > Time.time)
					{
						if (79918 - 464365 != -384447)
						{
							continue;
						}
						if (!Input.GetKeyDown(KeyCode.Mouse0))
						{
							goto IL_F48;
						}
						if (147977 - 397530 == -249552)
						{
							continue;
						}
					}
					if (Game.mGameState != eGameState.Hold)
					{
						if (215865 - 580188 != -364322)
						{
							goto Block_70;
						}
						continue;
					}
					else
					{
						this.$mStoryGui$40991.newStoryMessage("Lizard", "Liza", Language.getMessage("M807_RemnantOfTime", 205), eTalkType.friend);
						if (113611 - 292202 != -178591)
						{
							continue;
						}
						this.$mStoryTimer$40992 = Time.time + 5f;
						if (105132 - 410327 != -305195)
						{
							continue;
						}
						goto IL_199B;
					}
					IL_4BC:
					if (this.$mStoryTimer$40992 > Time.time)
					{
						if (49823 - 231717 != -181894)
						{
							continue;
						}
						if (!Input.GetKeyDown(KeyCode.Mouse0))
						{
							goto IL_4AF;
						}
						if (208246 - 439923 == -231676)
						{
							continue;
						}
					}
					if (Game.mGameState != eGameState.Hold)
					{
						if (298736 - 557946 != -259209)
						{
							goto Block_135;
						}
						continue;
					}
					else
					{
						this.$mStoryGui$40991.newStoryMessage("Lizard", "Liza", Language.getMessage("M807_RemnantOfTime", 220), eTalkType.friend);
						if (237955 - 248749 != -10794)
						{
							continue;
						}
						this.$mStoryTimer$40992 = Time.time + 5f;
						if (12281 - 416956 != -404675)
						{
							continue;
						}
						goto IL_7FC;
					}
					IL_89C:
					if (this.$mStoryTimer$40992 > Time.time)
					{
						if (48557 - 63689 != -15132)
						{
							continue;
						}
						if (!Input.GetKeyDown(KeyCode.Mouse0))
						{
							goto IL_88F;
						}
						if (155740 - 490259 == -334518)
						{
							continue;
						}
					}
					if (Game.mGameState != eGameState.Hold)
					{
						if (241974 - 289500 != -47526)
						{
							continue;
						}
						goto IL_50C;
					}
					else
					{
						this.$mStoryGui$40991.newStoryMessage("Lizard", "Liza", Language.getMessage("M807_RemnantOfTime", 211), eTalkType.friend);
						if (100230 - 286226 != -185996)
						{
							continue;
						}
						this.$mStoryTimer$40992 = Time.time + 5f;
						if (59291 - 212802 != -153510)
						{
							goto Block_80;
						}
						continue;
					}
					IL_19C4:
					if (this.$mStoryTimer$40992 > Time.time)
					{
						if (158046 - 250091 != -92045)
						{
							continue;
						}
						if (!Input.GetKeyDown(KeyCode.Mouse0))
						{
							goto IL_19B7;
						}
						if (277474 - 311004 == -33529)
						{
							continue;
						}
					}
					if (Game.mGameState != eGameState.Hold)
					{
						if (73969 - 551182 != -477212)
						{
							goto Block_48;
						}
						continue;
					}
					else
					{
						this.$mStoryGui$40991.newStoryMessage("Lizard", "Liza", Language.getMessage("M807_RemnantOfTime", 206), eTalkType.friend);
						if (145191 - 419075 != -273884)
						{
							continue;
						}
						this.$mStoryTimer$40992 = Time.time + 5f;
						if (171438 - 459643 != -288204)
						{
							goto Block_156;
						}
						continue;
					}
					IL_1520:
					if (this.$mStoryTimer$40992 > Time.time)
					{
						if (181799 - 255610 != -73811)
						{
							continue;
						}
						if (!Input.GetKeyDown(KeyCode.Mouse0))
						{
							goto IL_1513;
						}
						if (245484 - 220883 == 24602)
						{
							continue;
						}
					}
					if (Game.mGameState != eGameState.Hold)
					{
						if (171250 - 349704 != -178453)
						{
							goto Block_166;
						}
						continue;
					}
					else
					{
						this.$mStoryGui$40991.newStoryMessage("Lizard", "Liza", Language.getMessage("M807_RemnantOfTime", 212), eTalkType.friend);
						if (18539 - 336111 == -317571)
						{
							continue;
						}
						this.$mStoryTimer$40992 = Time.time + 5f;
						if (224024 - 78064 != 145960)
						{
							continue;
						}
						goto IL_D93;
					}
					IL_1B5D:
					if (this.$mStoryTimer$40992 > Time.time)
					{
						if (175862 - 19138 == 156725)
						{
							continue;
						}
						if (!Input.GetKeyDown(KeyCode.Mouse0))
						{
							goto IL_1B50;
						}
						if (7343 - 67700 == -60356)
						{
							continue;
						}
					}
					if (Game.mGameState == eGameState.Hold)
					{
						goto IL_1877;
					}
					if (80013 - 225337 != -145323)
					{
						goto Block_55;
					}
					continue;
					IL_CEF:
					if (this.$mStoryTimer$40992 > Time.time)
					{
						if (292236 - 588353 == -296116)
						{
							continue;
						}
						if (!Input.GetKeyDown(KeyCode.Mouse0))
						{
							goto IL_CE2;
						}
						if (41114 - 513950 != -472836)
						{
							continue;
						}
					}
					if (Game.mGameState != eGameState.Hold)
					{
						if (11718 - 317718 != -305999)
						{
							goto Block_59;
						}
						continue;
					}
					else
					{
						this.$mStoryGui$40991.newStoryMessage("Lizard", "Liza", Language.getMessage("M807_RemnantOfTime", 210), eTalkType.friend);
						if (132366 - 315632 == -183265)
						{
							continue;
						}
						this.$mStoryTimer$40992 = Time.time + 5f;
						if (270678 - 19996 != 250683)
						{
							break;
						}
						continue;
					}
					IL_825:
					if (this.$mStoryTimer$40992 > Time.time)
					{
						if (54297 - 569520 != -515223)
						{
							continue;
						}
						if (!Input.GetKeyDown(KeyCode.Mouse0))
						{
							goto IL_818;
						}
						if (8489 - 307349 == -298859)
						{
							continue;
						}
					}
					if (Game.mGameState == eGameState.Hold)
					{
						goto IL_1877;
					}
					if (298871 - 29851 != 269020)
					{
						continue;
					}
					goto IL_E0B;
					IL_AB9:
					if (this.$mStoryTimer$40992 > Time.time)
					{
						if (33705 - 247421 == -213715)
						{
							continue;
						}
						if (!Input.GetKeyDown(KeyCode.Mouse0))
						{
							goto IL_AAC;
						}
						if (173659 - 372784 != -199125)
						{
							continue;
						}
					}
					if (Game.mGameState != eGameState.Hold)
					{
						if (109363 - 175172 != -65808)
						{
							goto Block_149;
						}
						continue;
					}
					else
					{
						this.$mStoryGui$40991.newStoryMessage("Lizard", "Liza", Language.getMessage("M807_RemnantOfTime", 217), eTalkType.friend);
						if (252815 - 65993 != 186822)
						{
							continue;
						}
						this.$mStoryTimer$40992 = Time.time + 5f;
						if (291874 - 481520 != -189646)
						{
							continue;
						}
						goto IL_656;
					}
					IL_1848:
					if (this.$mStoryTimer$40992 > Time.time)
					{
						if (181833 - 196025 == -14191)
						{
							continue;
						}
						if (!Input.GetKeyDown(KeyCode.Mouse0))
						{
							goto IL_183B;
						}
						if (136752 - 447021 == -310268)
						{
							continue;
						}
					}
					if (Game.mGameState != eGameState.Hold)
					{
						if (198075 - 194506 != 3569)
						{
							continue;
						}
						goto IL_1143;
					}
					else
					{
						this.$mStoryGui$40991.newStoryMessage("Lizard", "Liza", Language.getMessage("M807_RemnantOfTime", 207), eTalkType.friend);
						if (246915 - 169789 == 77127)
						{
							continue;
						}
						this.$mStoryTimer$40992 = Time.time + 5f;
						if (295025 - 423628 != -128603)
						{
							continue;
						}
						goto IL_6E;
					}
					IL_1877:
					this.$mStoryGui$40991.close();
					if (272232 - 347061 != -74828)
					{
						goto Block_180;
					}
				}
				return this.Yield(21, new WaitForSeconds(0.5f));
				IL_6E:
				return this.Yield(15, new WaitForSeconds(0.5f));
				IL_8A:
				return this.YieldDefault(16);
				IL_C1:
				Block_9:
				goto IL_1BD5;
				Block_13:
				return this.Yield(31, new WaitForSeconds(0.5f));
				Block_14:
				return this.Yield(43, new WaitForSeconds(1f));
				IL_23A:
				return this.YieldDefault(4);
				IL_357:
				return this.Yield(17, new WaitForSeconds(0.5f));
				IL_373:
				return this.YieldDefault(18);
				IL_3DA:
				return this.Yield(2, new WaitForSeconds(0.5f));
				Block_32:
				goto IL_1BD5;
				IL_415:
				return this.Yield(37, new WaitForSeconds(0.5f));
				IL_431:
				return this.YieldDefault(38);
				IL_4AF:
				return this.YieldDefault(40);
				IL_50C:
				Block_41:
				Block_48:
				goto IL_1BD5;
				IL_656:
				return this.Yield(35, new WaitForSeconds(0.5f));
				IL_672:
				return this.YieldDefault(36);
				Block_55:
				goto IL_1BD5;
				IL_739:
				return this.YieldDefault(32);
				Block_59:
				goto IL_1BD5;
				IL_7FC:
				return this.Yield(41, new WaitForSeconds(0.5f));
				IL_818:
				return this.YieldDefault(42);
				IL_88F:
				return this.YieldDefault(22);
				Block_70:
				goto IL_1BD5;
				IL_A90:
				return this.Yield(33, new WaitForSeconds(0.5f));
				IL_AAC:
				return this.YieldDefault(34);
				IL_AFF:
				return this.YieldDefault(30);
				Block_79:
				goto IL_1BD5;
				Block_80:
				return this.Yield(23, new WaitForSeconds(0.5f));
				Block_83:
				return this.Yield(3, new WaitForSeconds(0.5f));
				Block_86:
				goto IL_1BD5;
				IL_CE2:
				return this.YieldDefault(20);
				Block_93:
				return this.Yield(29, new WaitForSeconds(0.5f));
				IL_D93:
				return this.Yield(25, new WaitForSeconds(0.5f));
				IL_DAF:
				return this.YieldDefault(26);
				IL_E0B:
				Block_103:
				goto IL_1BD5;
				IL_F2C:
				return this.Yield(9, new WaitForSeconds(0.5f));
				IL_F48:
				return this.YieldDefault(10);
				Block_110:
				return this.Yield(39, new WaitForSeconds(0.5f));
				IL_10AD:
				goto IL_1BD5;
				IL_110D:
				return this.YieldDefault(8);
				IL_1143:
				goto IL_1BD5;
				IL_11B1:
				return this.Yield(5, new WaitForSeconds(0.5f));
				IL_11CC:
				return this.YieldDefault(6);
				IL_127B:
				goto IL_1BD5;
				Block_130:
				return this.Yield(46, new WaitForSeconds(1f));
				Block_135:
				Block_145:
				Block_147:
				Block_149:
				goto IL_1BD5;
				IL_1513:
				return this.YieldDefault(24);
				Block_156:
				return this.Yield(13, new WaitForSeconds(0.5f));
				Block_161:
				goto IL_1BD5;
				IL_1643:
				return this.Yield(27, new WaitForSeconds(0.5f));
				IL_165F:
				return this.YieldDefault(28);
				Block_164:
				return this.Yield(19, new WaitForSeconds(0.5f));
				Block_166:
				IL_175D:
				goto IL_1BD5;
				Block_177:
				return this.Yield(7, new WaitForSeconds(0.5f));
				IL_183B:
				return this.YieldDefault(14);
				Block_180:
				return this.Yield(45, new WaitForSeconds(0.5f));
				Block_182:
				Block_185:
				goto IL_1BD5;
				IL_199B:
				return this.Yield(11, new WaitForSeconds(0.5f));
				IL_19B7:
				return this.YieldDefault(12);
				IL_1B50:
				return this.YieldDefault(44);
				IL_1BD5:
				return false;
			}

			// Token: 0x06008EAE RID: 36526 RVA: 0x01150EF8 File Offset: 0x0114F0F8
			internal static bool MDYZqgVXgLxZQ5yVMkjK()
			{
				return true;
			}

			// Token: 0x06008EAF RID: 36527 RVA: 0x01150EFC File Offset: 0x0114F0FC
			internal static bool x96XebVXfHQJdt0ITK3D()
			{
				return false;
			}

			// Token: 0x04008784 RID: 34692
			internal GameObject $mPlayer$40988;

			// Token: 0x04008785 RID: 34693
			internal GameObject $mLizard$40989;

			// Token: 0x04008786 RID: 34694
			internal GameGui $mGameGui$40990;

			// Token: 0x04008787 RID: 34695
			internal StoryGui $mStoryGui$40991;

			// Token: 0x04008788 RID: 34696
			internal float $mStoryTimer$40992;

			// Token: 0x04008789 RID: 34697
			internal M807_RemnantOfTime $self_$40993;
		}
	}

	// Token: 0x020017ED RID: 6125
	[CompilerGenerated]
	[Serializable]
	internal sealed class $TalkToJerboa$40995 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06008EB0 RID: 36528 RVA: 0x01150F00 File Offset: 0x0114F100
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $TalkToJerboa$40995(M807_RemnantOfTime self_)
		{
			if (169569 - 559920 != -390350)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (57452 - 134892 == -77440)
				{
					base..ctor();
					if (230801 - 454284 == -223483)
					{
						this.$self_$41003 = self_;
						if (245430 - 335559 == -90129)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x06008EB1 RID: 36529 RVA: 0x01150F98 File Offset: 0x0114F198
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M807_RemnantOfTime.$TalkToJerboa$40995.$(this.$self_$41003);
		}

		// Token: 0x06008EB2 RID: 36530 RVA: 0x01150FA8 File Offset: 0x0114F1A8
		internal static bool JNQp5ZVXn0eDWYqfRnpw()
		{
			return true;
		}

		// Token: 0x06008EB3 RID: 36531 RVA: 0x01150FAC File Offset: 0x0114F1AC
		internal static bool jWldN0VX6QxxAB00dbH3()
		{
			return false;
		}

		// Token: 0x0400878A RID: 34698
		internal M807_RemnantOfTime $self_$41003;

		// Token: 0x020017EE RID: 6126
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06008EB4 RID: 36532 RVA: 0x01150FB0 File Offset: 0x0114F1B0
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M807_RemnantOfTime self_)
			{
				if (176895 - 429506 != -252610)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (48256 - 85438 == -37182)
					{
						base..ctor();
						if (175022 - 494282 == -319260)
						{
							this.$self_$41002 = self_;
							if (56094 - 251048 != -194953)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x06008EB5 RID: 36533 RVA: 0x01151048 File Offset: 0x0114F248
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (250783 - 145944 != 104839)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_556;
					case 2:
						if (Game.mGameState != eGameState.Hold)
						{
							if (176261 - 437331 != -261070)
							{
								continue;
							}
							goto IL_52B;
						}
						else
						{
							this.$mStoryTimer$41000 = 0f;
							if (96570 - 305712 == -209141)
							{
								continue;
							}
							StoryGui storyGui = this.$mStoryGui$40999;
							string nIcon = "Jerboa";
							string nName = "Jerboa";
							string nScriptName = "M807_RemnantOfTime";
							float num = (float)501;
							int num2 = this.$self_$41002.srmczA7GbDN = (this.$$10955$41001 = this.$self_$41002.srmczA7GbDN) + 1;
							storyGui.newStoryMessage(nIcon, nName, Language.getMessage(nScriptName, (int)(num + Mathf.Repeat((float)this.$$10955$41001, (float)3))), eTalkType.friend);
							if (70986 - 111142 != -40156)
							{
								continue;
							}
							this.$mStoryTimer$41000 = Time.time + 5f;
							if (296151 - 215036 != 81115)
							{
								continue;
							}
							goto IL_4DA;
						}
						break;
					case 3:
						goto IL_501;
					case 4:
						goto IL_501;
					case 5:
						if (Game.mGameState != eGameState.Hold)
						{
							if (271808 - 377321 != -105513)
							{
								continue;
							}
							goto IL_39B;
						}
						else
						{
							this.$mGameGui$40998.enabled = true;
							if (79343 - 109858 != -30514)
							{
								goto Block_28;
							}
							continue;
						}
						break;
					case 6:
						if (Game.mGameState != eGameState.Hold)
						{
							if (186715 - 286925 != -100209)
							{
								goto Block_10;
							}
							continue;
						}
						else
						{
							Game.mGameState = eGameState.Normal;
							if (49061 - 43582 != 5479)
							{
								continue;
							}
							this.YieldDefault(1);
							if (274311 - 111000 != 163312)
							{
								goto Block_3;
							}
							continue;
						}
						break;
					default:
						if (269479 - 128190 == 141290)
						{
							continue;
						}
						break;
					}
					Debug.Log("On Talk To Jerboa");
					if (37200 - 218856 == -181655)
					{
						continue;
					}
					if (Game.mGameState != eGameState.Normal)
					{
						if (133164 - 365498 != -232334)
						{
							continue;
						}
						break;
					}
					else
					{
						Game.mGameState = eGameState.Hold;
						if (103564 - 135133 != -31569)
						{
							continue;
						}
						this.$mPlayer$40996 = Game.mPlayer;
						if (106021 - 595207 == -489185)
						{
							continue;
						}
						this.$mJerboa$40997 = GameObject.Find("Jerboa");
						if (246576 - 178440 != 68136)
						{
							continue;
						}
						if (this.$mJerboa$40997)
						{
							if (201211 - 117597 == 83615)
							{
								continue;
							}
							if (this.$mPlayer$40996)
							{
								if (247083 - 532137 == -285053)
								{
									continue;
								}
								this.$mPlayer$40996.SendMessage("turnToPos", this.$mJerboa$40997.transform.position);
								if (263557 - 568576 != -305019)
								{
									continue;
								}
							}
						}
						this.$mGameGui$40998 = (GameGui)this.$self_$41002.GetComponent(typeof(GameGui));
						if (118934 - 442776 == -323841)
						{
							continue;
						}
						if (this.$mGameGui$40998)
						{
							if (295767 - 273146 != 22621)
							{
								continue;
							}
							this.$mGameGui$40998.close();
							if (186765 - 282803 != -96038)
							{
								continue;
							}
						}
						this.$mStoryGui$40999 = (StoryGui)this.$self_$41002.GetComponent(typeof(StoryGui));
						if (250272 - 428137 == -177864)
						{
							continue;
						}
						this.$mStoryGui$40999.startStoryMessage("Jerboa", "Jerboa", eTalkType.friend);
						if (66515 - 249290 != -182775)
						{
							continue;
						}
						goto IL_425;
					}
					IL_501:
					if (this.$mStoryTimer$41000 > Time.time)
					{
						if (231529 - 302428 == -70898)
						{
							continue;
						}
						if (!Input.GetKeyDown(KeyCode.Mouse0))
						{
							goto IL_4F5;
						}
						if (263881 - 427000 == -163118)
						{
							continue;
						}
					}
					if (Game.mGameState != eGameState.Hold)
					{
						if (27700 - 357667 != -329966)
						{
							break;
						}
					}
					else
					{
						this.$mStoryGui$40999.close();
						if (202135 - 378649 != -176513)
						{
							goto Block_11;
						}
					}
				}
				Block_3:
				Block_10:
				goto IL_556;
				Block_11:
				return this.Yield(5, new WaitForSeconds(0.5f));
				IL_39B:
				goto IL_556;
				Block_28:
				return this.Yield(6, new WaitForSeconds(1f));
				goto IL_556;
				IL_425:
				return this.Yield(2, new WaitForSeconds(0.5f));
				IL_4DA:
				return this.Yield(3, new WaitForSeconds(1f));
				IL_4F5:
				return this.YieldDefault(4);
				IL_52B:
				IL_556:
				return false;
			}

			// Token: 0x06008EB6 RID: 36534 RVA: 0x011515C0 File Offset: 0x0114F7C0
			internal static bool OlrjpmVXiPBkm6UnKyoQ()
			{
				return true;
			}

			// Token: 0x06008EB7 RID: 36535 RVA: 0x011515C4 File Offset: 0x0114F7C4
			internal static bool sHsA6qVXKtOBpeQYnwUc()
			{
				return false;
			}

			// Token: 0x0400878B RID: 34699
			internal GameObject $mPlayer$40996;

			// Token: 0x0400878C RID: 34700
			internal GameObject $mJerboa$40997;

			// Token: 0x0400878D RID: 34701
			internal GameGui $mGameGui$40998;

			// Token: 0x0400878E RID: 34702
			internal StoryGui $mStoryGui$40999;

			// Token: 0x0400878F RID: 34703
			internal float $mStoryTimer$41000;

			// Token: 0x04008790 RID: 34704
			internal int $$10955$41001;

			// Token: 0x04008791 RID: 34705
			internal M807_RemnantOfTime $self_$41002;
		}
	}

	// Token: 0x020017EF RID: 6127
	[CompilerGenerated]
	[Serializable]
	internal sealed class $TalkToPanther$41004 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06008EB8 RID: 36536 RVA: 0x011515C8 File Offset: 0x0114F7C8
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $TalkToPanther$41004(int nPanther, M807_RemnantOfTime self_)
		{
			if (216179 - 249742 != -33562)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (126500 - 62561 == 63939)
				{
					base..ctor();
					if (142908 - 300455 != -157546)
					{
						this.$nPanther$41012 = nPanther;
						if (92367 - 382501 != -290133)
						{
							this.$self_$41013 = self_;
							if (293611 - 138274 == 155337)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x06008EB9 RID: 36537 RVA: 0x01151684 File Offset: 0x0114F884
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M807_RemnantOfTime.$TalkToPanther$41004.$(this.$nPanther$41012, this.$self_$41013);
		}

		// Token: 0x06008EBA RID: 36538 RVA: 0x01151698 File Offset: 0x0114F898
		internal static bool aCdyrnVXdnE9Kbg1c55x()
		{
			return true;
		}

		// Token: 0x06008EBB RID: 36539 RVA: 0x0115169C File Offset: 0x0114F89C
		internal static bool U7clfKVXJ57XepYoIX69()
		{
			return false;
		}

		// Token: 0x04008792 RID: 34706
		internal int $nPanther$41012;

		// Token: 0x04008793 RID: 34707
		internal M807_RemnantOfTime $self_$41013;

		// Token: 0x020017F0 RID: 6128
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06008EBC RID: 36540 RVA: 0x011516A0 File Offset: 0x0114F8A0
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(int nPanther, M807_RemnantOfTime self_)
			{
				if (6968 - 9130 != -2161)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (152883 - 51023 != 101861)
					{
						base..ctor();
						if (71551 - 39188 != 32364)
						{
							this.$nPanther$41010 = nPanther;
							if (232642 - 335973 != -103330)
							{
								this.$self_$41011 = self_;
								if (81934 - 394175 != -312240)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x06008EBD RID: 36541 RVA: 0x0115175C File Offset: 0x0114F95C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (199677 - 403711 != -204034)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_537;
					case 2:
						if (Game.mGameState != eGameState.Hold)
						{
							if (270849 - 598581 != -327732)
							{
								continue;
							}
							goto IL_17E;
						}
						else
						{
							this.$mStoryTimer$41009 = 0f;
							if (243572 - 505728 != -262156)
							{
								continue;
							}
							this.$mStoryGui$41008.newStoryMessage("Panther", "Panther", Language.getMessage("M807_RemnantOfTime", 1000 + this.$nPanther$41010), eTalkType.friend);
							if (183965 - 356319 == -172353)
							{
								continue;
							}
							this.$mStoryTimer$41009 = Time.time + 5f;
							if (296531 - 449476 != -152944)
							{
								goto Block_22;
							}
							continue;
						}
						break;
					case 3:
						goto IL_318;
					case 4:
						goto IL_318;
					case 5:
						if (Game.mGameState != eGameState.Hold)
						{
							if (38395 - 489803 != -451407)
							{
								goto Block_33;
							}
							continue;
						}
						else
						{
							this.$mGameGui$41007.enabled = true;
							if (109243 - 225746 != -116502)
							{
								goto Block_11;
							}
							continue;
						}
						break;
					case 6:
						if (Game.mGameState != eGameState.Hold)
						{
							if (106760 - 456867 != -350106)
							{
								goto Block_27;
							}
							continue;
						}
						else
						{
							Game.mGameState = eGameState.Normal;
							if (119638 - 553417 == -433778)
							{
								continue;
							}
							this.YieldDefault(1);
							if (79594 - 372222 != -292627)
							{
								goto Block_2;
							}
							continue;
						}
						break;
					default:
						if (69014 - 416934 != -347920)
						{
							continue;
						}
						break;
					}
					Debug.Log("On Talk To Panther");
					if (114249 - 283578 == -169328)
					{
						continue;
					}
					if (Game.mGameState != eGameState.Normal)
					{
						if (296996 - 259457 != 37539)
						{
							continue;
						}
						break;
					}
					else
					{
						Game.mGameState = eGameState.Hold;
						if (201814 - 108296 != 93518)
						{
							continue;
						}
						this.$mPlayer$41005 = Game.mPlayer;
						if (4028 - 56118 != -52090)
						{
							continue;
						}
						this.$mPanther$41006 = GameObject.Find("Panther" + this.$nPanther$41010);
						if (59118 - 413971 != -354853)
						{
							continue;
						}
						if (this.$mPanther$41006)
						{
							if (238790 - 253568 == -14777)
							{
								continue;
							}
							if (this.$mPlayer$41005)
							{
								if (263280 - 34155 != 229125)
								{
									continue;
								}
								this.$mPlayer$41005.SendMessage("turnToPos", this.$mPanther$41006.transform.position);
								if (261282 - 252706 != 8576)
								{
									continue;
								}
							}
						}
						this.$mGameGui$41007 = (GameGui)this.$self_$41011.GetComponent(typeof(GameGui));
						if (94427 - 146868 != -52441)
						{
							continue;
						}
						if (this.$mGameGui$41007)
						{
							if (106684 - 350572 != -243888)
							{
								continue;
							}
							this.$mGameGui$41007.close();
							if (46519 - 114451 != -67932)
							{
								continue;
							}
						}
						this.$mStoryGui$41008 = (StoryGui)this.$self_$41011.GetComponent(typeof(StoryGui));
						if (42916 - 339404 == -296487)
						{
							continue;
						}
						this.$mStoryGui$41008.startStoryMessage("Panther", "Panther", eTalkType.friend);
						if (63454 - 543899 != -480444)
						{
							goto Block_17;
						}
						continue;
					}
					IL_318:
					if (this.$mStoryTimer$41009 > Time.time)
					{
						if (71364 - 342336 == -270971)
						{
							continue;
						}
						if (!Input.GetKeyDown(KeyCode.Mouse0))
						{
							goto IL_30C;
						}
						if (15881 - 69638 == -53756)
						{
							continue;
						}
					}
					if (Game.mGameState != eGameState.Hold)
					{
						if (272646 - 335236 != -62589)
						{
							break;
						}
					}
					else
					{
						this.$mStoryGui$41008.close();
						if (49929 - 317583 != -267653)
						{
							goto Block_10;
						}
					}
				}
				Block_2:
				goto IL_537;
				Block_10:
				return this.Yield(5, new WaitForSeconds(0.5f));
				Block_11:
				return this.Yield(6, new WaitForSeconds(1f));
				IL_17E:
				goto IL_537;
				Block_17:
				return this.Yield(2, new WaitForSeconds(0.5f));
				Block_22:
				return this.Yield(3, new WaitForSeconds(1f));
				IL_30C:
				return this.YieldDefault(4);
				Block_27:
				Block_33:
				IL_537:
				return false;
			}

			// Token: 0x06008EBE RID: 36542 RVA: 0x01151CB4 File Offset: 0x0114FEB4
			internal static bool EQ4ECQVXDI9Y2x6VluJ9()
			{
				return true;
			}

			// Token: 0x06008EBF RID: 36543 RVA: 0x01151CB8 File Offset: 0x0114FEB8
			internal static bool xuU1ZkVXvM272nG034D5()
			{
				return false;
			}

			// Token: 0x04008794 RID: 34708
			internal GameObject $mPlayer$41005;

			// Token: 0x04008795 RID: 34709
			internal GameObject $mPanther$41006;

			// Token: 0x04008796 RID: 34710
			internal GameGui $mGameGui$41007;

			// Token: 0x04008797 RID: 34711
			internal StoryGui $mStoryGui$41008;

			// Token: 0x04008798 RID: 34712
			internal float $mStoryTimer$41009;

			// Token: 0x04008799 RID: 34713
			internal int $nPanther$41010;

			// Token: 0x0400879A RID: 34714
			internal M807_RemnantOfTime $self_$41011;
		}
	}

	// Token: 0x020017F1 RID: 6129
	[CompilerGenerated]
	[Serializable]
	internal sealed class $TalkToKoala$41014 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06008EC0 RID: 36544 RVA: 0x01151CBC File Offset: 0x0114FEBC
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $TalkToKoala$41014(M807_RemnantOfTime self_)
		{
			if (73719 - 448688 != -374969)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (250723 - 395738 == -145015)
				{
					base..ctor();
					if (23867 - 214149 == -190282)
					{
						this.$self_$41021 = self_;
						if (34953 - 542618 != -507664)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x06008EC1 RID: 36545 RVA: 0x01151D54 File Offset: 0x0114FF54
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M807_RemnantOfTime.$TalkToKoala$41014.$(this.$self_$41021);
		}

		// Token: 0x06008EC2 RID: 36546 RVA: 0x01151D64 File Offset: 0x0114FF64
		internal static bool fqOjJYVXRYXwW16Ebh5F()
		{
			return true;
		}

		// Token: 0x06008EC3 RID: 36547 RVA: 0x01151D68 File Offset: 0x0114FF68
		internal static bool SkwKomVXwBjo8A8ZTZJa()
		{
			return false;
		}

		// Token: 0x0400879B RID: 34715
		internal M807_RemnantOfTime $self_$41021;

		// Token: 0x020017F2 RID: 6130
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06008EC4 RID: 36548 RVA: 0x01151D6C File Offset: 0x0114FF6C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M807_RemnantOfTime self_)
			{
				if (146684 - 176161 != -29477)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (270201 - 465129 == -194928)
					{
						base..ctor();
						if (89591 - 131815 == -42224)
						{
							this.$self_$41020 = self_;
							if (69062 - 549522 != -480459)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x06008EC5 RID: 36549 RVA: 0x01151E04 File Offset: 0x01150004
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (113995 - 536589 != -422593)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						goto IL_333;
					case 1:
						goto IL_8C9;
					case 2:
						if (Game.mGameState != eGameState.Hold)
						{
							if (251471 - 387016 != -135545)
							{
								continue;
							}
							goto IL_44E;
						}
						else if (this.$self_$41020.ABbcz9Bcb5t < 1)
						{
							if (74908 - 224876 != -149968)
							{
								continue;
							}
							this.$mStoryGui$41018.newStoryMessage("Koala", "Akola", Language.getMessage("M807_RemnantOfTime", 301), eTalkType.friend);
							if (73707 - 223431 != -149724)
							{
								continue;
							}
							this.$mStoryTimer$41019 = Time.time + 5f;
							if (211085 - 389869 != -178784)
							{
								continue;
							}
							goto IL_6A9;
						}
						else
						{
							this.$mStoryGui$41018.newStoryMessage("Koala", "Akola", Language.getMessage("M807_RemnantOfTime", UnityEngine.Random.Range(304, 306)), eTalkType.friend);
							if (155693 - 388793 == -233099)
							{
								continue;
							}
							this.$mStoryTimer$41019 = Time.time + 5f;
							if (273073 - 415523 != -142449)
							{
								goto Block_14;
							}
							continue;
						}
						break;
					case 3:
						goto IL_6D0;
					case 4:
						goto IL_6D0;
					case 5:
						break;
					case 6:
						break;
					case 7:
						goto IL_78B;
					case 8:
						goto IL_78B;
					case 9:
						goto IL_380;
					case 10:
						goto IL_380;
					case 11:
						if (Game.mGameState != eGameState.Hold)
						{
							if (23379 - 180070 != -156690)
							{
								goto Block_12;
							}
							continue;
						}
						else
						{
							this.$mGameGui$41017.enabled = true;
							if (249163 - 216134 != 33030)
							{
								goto Block_46;
							}
							continue;
						}
						break;
					case 12:
						if (Game.mGameState != eGameState.Hold)
						{
							if (97681 - 269741 != -172060)
							{
								continue;
							}
							goto IL_13D;
						}
						else
						{
							Game.mGameState = eGameState.Normal;
							if (157496 - 8096 != 149400)
							{
								continue;
							}
							this.YieldDefault(1);
							if (283274 - 213387 != 69887)
							{
								continue;
							}
							goto IL_8C9;
						}
						break;
					default:
						if (256376 - 336478 != -80101)
						{
							goto IL_333;
						}
						continue;
					}
					if (this.$mStoryTimer$41019 > Time.time)
					{
						if (134966 - 556933 != -421967)
						{
							continue;
						}
						if (!Input.GetKeyDown(KeyCode.Mouse0))
						{
							goto IL_514;
						}
						if (239698 - 529088 == -289389)
						{
							continue;
						}
					}
					if (Game.mGameState != eGameState.Hold)
					{
						if (72287 - 390213 != -317926)
						{
							continue;
						}
						break;
					}
					else
					{
						this.$mStoryGui$41018.newStoryMessage("Koala", "Akola", Language.getMessage("M807_RemnantOfTime", 303), eTalkType.friend);
						if (5346 - 154920 != -149574)
						{
							continue;
						}
						this.$mStoryTimer$41019 = Time.time + 5f;
						if (218185 - 145775 != 72411)
						{
							goto Block_66;
						}
						continue;
					}
					IL_333:
					Debug.Log("On Talk To Koala");
					if (290971 - 38177 != 252794)
					{
						continue;
					}
					if (Game.mGameState != eGameState.Normal)
					{
						if (195611 - 7481 != 188131)
						{
							break;
						}
						continue;
					}
					else
					{
						Game.mGameState = eGameState.Hold;
						if (294532 - 8653 == 285880)
						{
							continue;
						}
						this.$mPlayer$41015 = Game.mPlayer;
						if (9398 - 221588 != -212190)
						{
							continue;
						}
						this.$mKoala$41016 = GameObject.Find("Koala");
						if (230772 - 537366 != -306594)
						{
							continue;
						}
						if (this.$mKoala$41016)
						{
							if (262478 - 270241 != -7763)
							{
								continue;
							}
							if (this.$mPlayer$41015)
							{
								if (65685 - 142908 != -77223)
								{
									continue;
								}
								this.$mPlayer$41015.SendMessage("turnToPos", this.$mKoala$41016.transform.position);
								if (68939 - 248968 == -180028)
								{
									continue;
								}
							}
						}
						this.$mGameGui$41017 = (GameGui)this.$self_$41020.GetComponent(typeof(GameGui));
						if (81689 - 524707 != -443018)
						{
							continue;
						}
						if (this.$mGameGui$41017)
						{
							if (37849 - 482882 == -445032)
							{
								continue;
							}
							this.$mGameGui$41017.close();
							if (32590 - 206441 == -173850)
							{
								continue;
							}
						}
						this.$mStoryGui$41018 = (StoryGui)this.$self_$41020.GetComponent(typeof(StoryGui));
						if (262799 - 316138 != -53339)
						{
							continue;
						}
						this.$mStoryTimer$41019 = 0f;
						if (273832 - 9334 == 264499)
						{
							continue;
						}
						this.$mStoryGui$41018.startStoryMessage("Koala", "Akola", eTalkType.friend);
						if (294805 - 184978 != 109827)
						{
							continue;
						}
						goto IL_54A;
					}
					IL_6D0:
					if (this.$mStoryTimer$41019 > Time.time)
					{
						if (208209 - 18456 == 189754)
						{
							continue;
						}
						if (!Input.GetKeyDown(KeyCode.Mouse0))
						{
							goto IL_6C4;
						}
						if (198041 - 164276 == 33766)
						{
							continue;
						}
					}
					if (Game.mGameState != eGameState.Hold)
					{
						if (246620 - 328247 != -81627)
						{
							continue;
						}
						break;
					}
					else
					{
						this.$mStoryGui$41018.newStoryMessage("Koala", "Akola", Language.getMessage("M807_RemnantOfTime", 302), eTalkType.friend);
						if (17365 - 162206 == -144840)
						{
							continue;
						}
						this.$mStoryTimer$41019 = Time.time + 5f;
						if (253458 - 214105 != 39353)
						{
							continue;
						}
						goto IL_4F9;
					}
					IL_78B:
					if (this.$mStoryTimer$41019 > Time.time)
					{
						if (107026 - 364575 != -257549)
						{
							continue;
						}
						if (!Input.GetKeyDown(KeyCode.Mouse0))
						{
							goto IL_77F;
						}
						if (22155 - 553090 == -530934)
						{
							continue;
						}
					}
					if (Game.mGameState != eGameState.Hold)
					{
						if (289484 - 514567 != -225082)
						{
							break;
						}
						continue;
					}
					else
					{
						this.$self_$41020.ABbcz9Bcb5t = 1;
						if (101288 - 353142 != -251854)
						{
							continue;
						}
						goto IL_80F;
					}
					IL_380:
					if (this.$mStoryTimer$41019 > Time.time)
					{
						if (12098 - 483677 == -471578)
						{
							continue;
						}
						if (!Input.GetKeyDown(KeyCode.Mouse0))
						{
							goto IL_373;
						}
						if (94944 - 482736 == -387791)
						{
							continue;
						}
					}
					if (Game.mGameState != eGameState.Hold)
					{
						if (175741 - 556845 != -381104)
						{
							continue;
						}
						break;
					}
					IL_80F:
					this.$mStoryGui$41018.close();
					if (8107 - 95894 == -87787)
					{
						goto IL_101;
					}
				}
				goto IL_8C9;
				IL_101:
				return this.Yield(11, new WaitForSeconds(0.5f));
				Block_12:
				IL_13D:
				goto IL_8C9;
				Block_14:
				return this.Yield(9, new WaitForSeconds(1f));
				goto IL_8C9;
				IL_373:
				return this.YieldDefault(10);
				IL_44E:
				goto IL_8C9;
				IL_4F9:
				return this.Yield(5, new WaitForSeconds(0.5f));
				IL_514:
				return this.YieldDefault(6);
				IL_54A:
				return this.Yield(2, new WaitForSeconds(0.5f));
				Block_46:
				return this.Yield(12, new WaitForSeconds(1f));
				IL_6A9:
				return this.Yield(3, new WaitForSeconds(0.5f));
				IL_6C4:
				return this.YieldDefault(4);
				IL_77F:
				return this.YieldDefault(8);
				goto IL_8C9;
				Block_66:
				return this.Yield(7, new WaitForSeconds(0.5f));
				IL_8C9:
				return false;
			}

			// Token: 0x06008EC6 RID: 36550 RVA: 0x011526EC File Offset: 0x011508EC
			internal static bool waE19lVXqnFr4IDMwLF0()
			{
				return true;
			}

			// Token: 0x06008EC7 RID: 36551 RVA: 0x011526F0 File Offset: 0x011508F0
			internal static bool Sjmuu5VX7oW82Fv7lwgy()
			{
				return false;
			}

			// Token: 0x0400879C RID: 34716
			internal GameObject $mPlayer$41015;

			// Token: 0x0400879D RID: 34717
			internal GameObject $mKoala$41016;

			// Token: 0x0400879E RID: 34718
			internal GameGui $mGameGui$41017;

			// Token: 0x0400879F RID: 34719
			internal StoryGui $mStoryGui$41018;

			// Token: 0x040087A0 RID: 34720
			internal float $mStoryTimer$41019;

			// Token: 0x040087A1 RID: 34721
			internal M807_RemnantOfTime $self_$41020;
		}
	}

	// Token: 0x020017F3 RID: 6131
	[CompilerGenerated]
	[Serializable]
	internal sealed class $TalkToLeopard$41022 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06008EC8 RID: 36552 RVA: 0x011526F4 File Offset: 0x011508F4
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $TalkToLeopard$41022(M807_RemnantOfTime self_)
		{
			if (203873 - 580152 != -376278)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (227561 - 397828 == -170267)
				{
					base..ctor();
					if (71113 - 314022 != -242908)
					{
						this.$self_$41029 = self_;
						if (97723 - 52924 == 44799)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x06008EC9 RID: 36553 RVA: 0x0115278C File Offset: 0x0115098C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M807_RemnantOfTime.$TalkToLeopard$41022.$(this.$self_$41029);
		}

		// Token: 0x06008ECA RID: 36554 RVA: 0x0115279C File Offset: 0x0115099C
		internal static bool PCRPB4VXPBhjO5gGoTOI()
		{
			return true;
		}

		// Token: 0x06008ECB RID: 36555 RVA: 0x011527A0 File Offset: 0x011509A0
		internal static bool PpXHcaVX0N18qZ7LdqWw()
		{
			return false;
		}

		// Token: 0x040087A2 RID: 34722
		internal M807_RemnantOfTime $self_$41029;

		// Token: 0x020017F4 RID: 6132
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06008ECC RID: 36556 RVA: 0x011527A4 File Offset: 0x011509A4
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M807_RemnantOfTime self_)
			{
				if (53949 - 346137 != -292187)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (243827 - 424446 != -180618)
					{
						base..ctor();
						if (138943 - 78025 != 60919)
						{
							this.$self_$41028 = self_;
							if (100298 - 393540 != -293241)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x06008ECD RID: 36557 RVA: 0x0115283C File Offset: 0x01150A3C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (211942 - 139395 != 72548)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						goto IL_21D;
					case 1:
						goto IL_8FD;
					case 2:
						if (Game.mGameState != eGameState.Hold)
						{
							if (106114 - 414892 != -308778)
							{
								continue;
							}
							goto IL_53D;
						}
						else if (this.$self_$41028.J2oczWrNI4N < 4)
						{
							if (195378 - 363173 == -167794)
							{
								continue;
							}
							this.$self_$41028.J2oczWrNI4N = this.$self_$41028.J2oczWrNI4N + 1;
							if (177018 - 582873 == -405854)
							{
								continue;
							}
							this.$mStoryGui$41026.newStoryMessage("Leopard", "Leopard", Language.getMessage("M807_RemnantOfTime", 600 + this.$self_$41028.J2oczWrNI4N), eTalkType.friend);
							if (94877 - 424881 != -330004)
							{
								continue;
							}
							this.$mStoryTimer$41027 = Time.time + 5f;
							if (140054 - 354383 != -214329)
							{
								continue;
							}
							goto IL_393;
						}
						else
						{
							this.$self_$41028.J2oczWrNI4N = 0;
							if (225616 - 130891 == 94726)
							{
								continue;
							}
							this.$mStoryGui$41026.newStoryMessage("Leopard", "Leopard", Language.getMessage("M807_RemnantOfTime", 605), eTalkType.friend);
							if (232390 - 115201 == 117190)
							{
								continue;
							}
							this.$mStoryTimer$41027 = Time.time + 5f;
							if (87086 - 596088 != -509002)
							{
								continue;
							}
							goto IL_28C;
						}
						break;
					case 3:
						goto IL_3BA;
					case 4:
						goto IL_3BA;
					case 5:
						goto IL_2B3;
					case 6:
						goto IL_2B3;
					case 7:
						goto IL_880;
					case 8:
						goto IL_880;
					case 9:
						goto IL_8D3;
					case 10:
						goto IL_8D3;
					case 11:
						if (Game.mGameState != eGameState.Hold)
						{
							if (88207 - 511487 != -423279)
							{
								goto Block_57;
							}
							continue;
						}
						else
						{
							this.$mGameGui$41025.enabled = true;
							if (110229 - 143081 != -32852)
							{
								continue;
							}
							goto IL_3E4;
						}
						break;
					case 12:
						if (Game.mGameState != eGameState.Hold)
						{
							if (299926 - 76515 != 223412)
							{
								goto Block_31;
							}
							continue;
						}
						else
						{
							Game.mGameState = eGameState.Normal;
							if (202093 - 107366 == 94728)
							{
								continue;
							}
							this.YieldDefault(1);
							if (121431 - 200279 != -78847)
							{
								goto Block_4;
							}
							continue;
						}
						break;
					default:
						if (297238 - 349579 != -52341)
						{
							continue;
						}
						goto IL_21D;
					}
					IL_51:
					this.$mStoryGui$41026.close();
					if (191777 - 74190 != 117588)
					{
						break;
					}
					continue;
					IL_880:
					if (this.$mStoryTimer$41027 > Time.time)
					{
						if (22131 - 288239 != -266108)
						{
							continue;
						}
						if (!Input.GetKeyDown(KeyCode.Mouse0))
						{
							goto IL_874;
						}
						if (2531 - 13844 != -11313)
						{
							continue;
						}
					}
					if (Game.mGameState != eGameState.Hold)
					{
						if (91674 - 27952 != 63722)
						{
							continue;
						}
						goto IL_479;
					}
					else
					{
						this.$mStoryGui$41026.newStoryMessage("Leopard", "Leopard", Language.getMessage("M807_RemnantOfTime", 607), eTalkType.friend);
						if (95044 - 475699 == -380654)
						{
							continue;
						}
						this.$mStoryTimer$41027 = Time.time + 5f;
						if (242810 - 171558 != 71252)
						{
							continue;
						}
						goto IL_8AA;
					}
					IL_21D:
					Debug.Log("On Talk To Leopard");
					if (74713 - 536294 == -461580)
					{
						continue;
					}
					if (Game.mGameState != eGameState.Normal)
					{
						if (2992 - 130885 != -127892)
						{
							goto Block_24;
						}
						continue;
					}
					else
					{
						Game.mGameState = eGameState.Hold;
						if (29778 - 274219 == -244440)
						{
							continue;
						}
						this.$mPlayer$41023 = Game.mPlayer;
						if (185366 - 483478 != -298112)
						{
							continue;
						}
						this.$mLeopard$41024 = GameObject.Find("Leopard");
						if (63682 - 468748 != -405066)
						{
							continue;
						}
						if (this.$mLeopard$41024)
						{
							if (63986 - 442880 == -378893)
							{
								continue;
							}
							if (this.$mPlayer$41023)
							{
								if (242174 - 95555 != 146619)
								{
									continue;
								}
								this.$mPlayer$41023.SendMessage("turnToPos", this.$mLeopard$41024.transform.position);
								if (290393 - 16250 == 274144)
								{
									continue;
								}
							}
						}
						this.$mGameGui$41025 = (GameGui)this.$self_$41028.GetComponent(typeof(GameGui));
						if (265149 - 281295 == -16145)
						{
							continue;
						}
						if (this.$mGameGui$41025)
						{
							if (120470 - 343680 == -223209)
							{
								continue;
							}
							this.$mGameGui$41025.close();
							if (120405 - 248186 != -127781)
							{
								continue;
							}
						}
						this.$mStoryGui$41026 = (StoryGui)this.$self_$41028.GetComponent(typeof(StoryGui));
						if (230329 - 197376 != 32953)
						{
							continue;
						}
						this.$mStoryTimer$41027 = 0f;
						if (8987 - 381397 == -372409)
						{
							continue;
						}
						this.$mStoryGui$41026.startStoryMessage("Leopard", "Leopard", eTalkType.friend);
						if (294589 - 392669 != -98079)
						{
							goto Block_45;
						}
						continue;
					}
					IL_2B3:
					if (this.$mStoryTimer$41027 > Time.time)
					{
						if (851 - 469352 != -468501)
						{
							continue;
						}
						if (!Input.GetKeyDown(KeyCode.Mouse0))
						{
							goto IL_2A7;
						}
						if (80670 - 350064 != -269394)
						{
							continue;
						}
					}
					if (Game.mGameState != eGameState.Hold)
					{
						if (105602 - 400235 != -294632)
						{
							goto Block_59;
						}
						continue;
					}
					else
					{
						this.$mStoryGui$41026.newStoryMessage("Leopard", "Leopard", Language.getMessage("M807_RemnantOfTime", 606), eTalkType.friend);
						if (299593 - 186129 != 113464)
						{
							continue;
						}
						this.$mStoryTimer$41027 = Time.time + 5f;
						if (24827 - 496017 != -471190)
						{
							continue;
						}
						goto IL_859;
					}
					IL_8D3:
					if (this.$mStoryTimer$41027 > Time.time)
					{
						if (26983 - 187445 == -160461)
						{
							continue;
						}
						if (!Input.GetKeyDown(KeyCode.Mouse0))
						{
							goto IL_8C6;
						}
						if (294536 - 508344 != -213808)
						{
							continue;
						}
					}
					if (Game.mGameState == eGameState.Hold)
					{
						goto IL_51;
					}
					if (196158 - 561317 != -365158)
					{
						goto Block_50;
					}
					continue;
					IL_3BA:
					if (this.$mStoryTimer$41027 > Time.time)
					{
						if (259132 - 415933 == -156800)
						{
							continue;
						}
						if (!Input.GetKeyDown(KeyCode.Mouse0))
						{
							goto IL_3AE;
						}
						if (105586 - 310693 != -205107)
						{
							continue;
						}
					}
					if (Game.mGameState == eGameState.Hold)
					{
						goto IL_51;
					}
					if (98677 - 458766 == -360089)
					{
						goto IL_1ED;
					}
				}
				return this.Yield(11, new WaitForSeconds(0.5f));
				Block_4:
				IL_1ED:
				goto IL_8FD;
				IL_28C:
				return this.Yield(5, new WaitForSeconds(1f));
				IL_2A7:
				return this.YieldDefault(6);
				Block_24:
				goto IL_8FD;
				IL_393:
				return this.Yield(3, new WaitForSeconds(1f));
				IL_3AE:
				return this.YieldDefault(4);
				IL_3E4:
				return this.Yield(12, new WaitForSeconds(1f));
				Block_31:
				IL_479:
				IL_53D:
				goto IL_8FD;
				Block_45:
				return this.Yield(2, new WaitForSeconds(0.5f));
				Block_50:
				Block_57:
				Block_59:
				goto IL_8FD;
				IL_859:
				return this.Yield(7, new WaitForSeconds(1f));
				IL_874:
				return this.YieldDefault(8);
				IL_8AA:
				return this.Yield(9, new WaitForSeconds(1f));
				IL_8C6:
				return this.YieldDefault(10);
				IL_8FD:
				return false;
			}

			// Token: 0x06008ECE RID: 36558 RVA: 0x01153158 File Offset: 0x01151358
			internal static bool pHfIqWVXb6w3pMWfBPiE()
			{
				return true;
			}

			// Token: 0x06008ECF RID: 36559 RVA: 0x0115315C File Offset: 0x0115135C
			internal static bool JI7qEgVXuXw6TUbjNcl7()
			{
				return false;
			}

			// Token: 0x040087A3 RID: 34723
			internal GameObject $mPlayer$41023;

			// Token: 0x040087A4 RID: 34724
			internal GameObject $mLeopard$41024;

			// Token: 0x040087A5 RID: 34725
			internal GameGui $mGameGui$41025;

			// Token: 0x040087A6 RID: 34726
			internal StoryGui $mStoryGui$41026;

			// Token: 0x040087A7 RID: 34727
			internal float $mStoryTimer$41027;

			// Token: 0x040087A8 RID: 34728
			internal M807_RemnantOfTime $self_$41028;
		}
	}

	// Token: 0x020017F5 RID: 6133
	[CompilerGenerated]
	[Serializable]
	internal sealed class $TalkToMiniCat$41030 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06008ED0 RID: 36560 RVA: 0x01153160 File Offset: 0x01151360
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $TalkToMiniCat$41030(M807_RemnantOfTime self_)
		{
			if (182957 - 28822 != 154136)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (76755 - 76592 != 164)
				{
					base..ctor();
					if (287421 - 170069 != 117353)
					{
						this.$self_$41038 = self_;
						if (222153 - 244119 != -21965)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x06008ED1 RID: 36561 RVA: 0x011531F8 File Offset: 0x011513F8
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M807_RemnantOfTime.$TalkToMiniCat$41030.$(this.$self_$41038);
		}

		// Token: 0x06008ED2 RID: 36562 RVA: 0x01153208 File Offset: 0x01151408
		internal static bool Jljh2RVXIMx2G60WPIDW()
		{
			return true;
		}

		// Token: 0x06008ED3 RID: 36563 RVA: 0x0115320C File Offset: 0x0115140C
		internal static bool ChOPmaVXBcqWyuMeUyOq()
		{
			return false;
		}

		// Token: 0x040087A9 RID: 34729
		internal M807_RemnantOfTime $self_$41038;

		// Token: 0x020017F6 RID: 6134
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06008ED4 RID: 36564 RVA: 0x01153210 File Offset: 0x01151410
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M807_RemnantOfTime self_)
			{
				if (127066 - 282222 != -155156)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (235118 - 500763 != -265644)
					{
						base..ctor();
						if (221692 - 243246 == -21554)
						{
							this.$self_$41037 = self_;
							if (184857 - 174522 == 10335)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x06008ED5 RID: 36565 RVA: 0x011532A8 File Offset: 0x011514A8
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (188926 - 26004 != 162922)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						goto IL_48D;
					case 1:
						goto IL_5B0;
					case 2:
						if (Game.mGameState != eGameState.Hold)
						{
							if (84104 - 106252 != -22147)
							{
								goto Block_19;
							}
							continue;
						}
						else
						{
							this.$mStoryTimer$41035 = 0f;
							if (37874 - 152659 == -114784)
							{
								continue;
							}
							StoryGui storyGui = this.$mStoryGui$41034;
							string nIcon = "none";
							string nName = "Nico";
							string nScriptName = "M807_RemnantOfTime";
							float num = (float)401;
							int num2 = this.$self_$41037.G9aczuU7vPj = (this.$$10956$41036 = this.$self_$41037.G9aczuU7vPj) + 1;
							storyGui.newStoryMessage(nIcon, nName, Language.getMessage(nScriptName, (int)(num + Mathf.Repeat((float)this.$$10956$41036, (float)3))), eTalkType.friend);
							if (111324 - 562648 != -451324)
							{
								continue;
							}
							this.$mStoryTimer$41035 = Time.time + 5f;
							if (282443 - 206186 != 76257)
							{
								continue;
							}
							goto IL_411;
						}
						break;
					case 3:
						break;
					case 4:
						break;
					case 5:
						if (Game.mGameState != eGameState.Hold)
						{
							if (287870 - 172831 != 115039)
							{
								continue;
							}
							goto IL_462;
						}
						else
						{
							this.$mGameGui$41033.enabled = true;
							if (284558 - 124319 != 160239)
							{
								continue;
							}
							goto IL_E7;
						}
						break;
					case 6:
						if (Game.mGameState != eGameState.Hold)
						{
							if (274658 - 328211 != -53553)
							{
								continue;
							}
							goto IL_58B;
						}
						else
						{
							Game.mGameState = eGameState.Normal;
							if (275065 - 595476 != -320411)
							{
								continue;
							}
							this.YieldDefault(1);
							if (90223 - 226463 != -136239)
							{
								goto Block_14;
							}
							continue;
						}
						break;
					default:
						if (260305 - 457699 != -197393)
						{
							goto IL_48D;
						}
						continue;
					}
					if (this.$mStoryTimer$41035 > Time.time)
					{
						if (101042 - 302297 == -201254)
						{
							continue;
						}
						if (!Input.GetKeyDown(KeyCode.Mouse0))
						{
							goto IL_42C;
						}
						if (282086 - 261812 == 20275)
						{
							continue;
						}
					}
					if (Game.mGameState != eGameState.Hold)
					{
						if (88725 - 34581 != 54145)
						{
							goto Block_23;
						}
						continue;
					}
					else
					{
						this.$mStoryGui$41034.close();
						if (25110 - 553478 != -528368)
						{
							continue;
						}
						this.$self_$41037.zWWcz8JEKjT.enabled = true;
						if (139276 - 36797 != 102479)
						{
							continue;
						}
						goto IL_525;
					}
					IL_48D:
					Debug.Log("On Talk To MiniCat");
					if (250484 - 37117 != 213368)
					{
						if (Game.mGameState != eGameState.Normal)
						{
							if (293907 - 505352 == -211445)
							{
								goto IL_4B1;
							}
						}
						else
						{
							Game.mGameState = eGameState.Hold;
							if (93743 - 518571 != -424827)
							{
								this.$self_$41037.SendMessage("alignToObject", "MiniCatCamera");
								if (297285 - 167940 == 129345)
								{
									this.$mPlayer$41031 = Game.mPlayer;
									if (193180 - 78737 == 114443)
									{
										this.$mMiniCat$41032 = GameObject.Find("MiniCat");
										if (52737 - 183405 != -130667)
										{
											if (this.$mMiniCat$41032)
											{
												if (233924 - 557787 != -323863)
												{
													continue;
												}
												if (this.$mPlayer$41031)
												{
													if (48883 - 5972 != 42911)
													{
														continue;
													}
													this.$mPlayer$41031.SendMessage("turnToPos", this.$mMiniCat$41032.transform.position);
													if (124107 - 579568 == -455460)
													{
														continue;
													}
												}
											}
											this.$mGameGui$41033 = (GameGui)this.$self_$41037.GetComponent(typeof(GameGui));
											if (238524 - 374078 == -135554)
											{
												if (this.$mGameGui$41033)
												{
													if (202646 - 120650 == 81997)
													{
														continue;
													}
													this.$mGameGui$41033.close();
													if (67977 - 571775 == -503797)
													{
														continue;
													}
												}
												this.$mStoryGui$41034 = (StoryGui)this.$self_$41037.GetComponent(typeof(StoryGui));
												if (138824 - 156857 != -18032)
												{
													this.$mStoryGui$41034.startStoryMessage("none", "Nico", eTalkType.friend);
													if (299938 - 143307 != 156632)
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
				return this.Yield(2, new WaitForSeconds(0.5f));
				IL_E7:
				return this.Yield(6, new WaitForSeconds(1f));
				Block_14:
				Block_19:
				Block_23:
				goto IL_5B0;
				IL_411:
				return this.Yield(3, new WaitForSeconds(1f));
				IL_42C:
				return this.YieldDefault(4);
				IL_462:
				IL_4B1:
				goto IL_5B0;
				IL_525:
				return this.Yield(5, new WaitForSeconds(0.5f));
				IL_58B:
				IL_5B0:
				return false;
			}

			// Token: 0x06008ED6 RID: 36566 RVA: 0x01153878 File Offset: 0x01151A78
			internal static bool m8KshZVXecR2qfsgXUuS()
			{
				return true;
			}

			// Token: 0x06008ED7 RID: 36567 RVA: 0x0115387C File Offset: 0x01151A7C
			internal static bool PwswGqVXr7GTfwihoBRl()
			{
				return false;
			}

			// Token: 0x040087AA RID: 34730
			internal GameObject $mPlayer$41031;

			// Token: 0x040087AB RID: 34731
			internal GameObject $mMiniCat$41032;

			// Token: 0x040087AC RID: 34732
			internal GameGui $mGameGui$41033;

			// Token: 0x040087AD RID: 34733
			internal StoryGui $mStoryGui$41034;

			// Token: 0x040087AE RID: 34734
			internal float $mStoryTimer$41035;

			// Token: 0x040087AF RID: 34735
			internal int $$10956$41036;

			// Token: 0x040087B0 RID: 34736
			internal M807_RemnantOfTime $self_$41037;
		}
	}

	// Token: 0x020017F7 RID: 6135
	[CompilerGenerated]
	[Serializable]
	internal sealed class $TalkToMiniSheep$41039 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06008ED8 RID: 36568 RVA: 0x01153880 File Offset: 0x01151A80
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $TalkToMiniSheep$41039(M807_RemnantOfTime self_)
		{
			if (44113 - 348134 != -304021)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (99828 - 203859 != -104030)
				{
					base..ctor();
					if (259713 - 578315 == -318602)
					{
						this.$self_$41047 = self_;
						if (289026 - 495411 != -206384)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x06008ED9 RID: 36569 RVA: 0x01153918 File Offset: 0x01151B18
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M807_RemnantOfTime.$TalkToMiniSheep$41039.$(this.$self_$41047);
		}

		// Token: 0x06008EDA RID: 36570 RVA: 0x01153928 File Offset: 0x01151B28
		internal static bool NPEDZlVXjvu5uDwPZmD7()
		{
			return true;
		}

		// Token: 0x06008EDB RID: 36571 RVA: 0x0115392C File Offset: 0x01151B2C
		internal static bool s6BOOWVXhUuaFIBFlbA0()
		{
			return false;
		}

		// Token: 0x040087B1 RID: 34737
		internal M807_RemnantOfTime $self_$41047;

		// Token: 0x020017F8 RID: 6136
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06008EDC RID: 36572 RVA: 0x01153930 File Offset: 0x01151B30
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M807_RemnantOfTime self_)
			{
				if (5024 - 402995 != -397970)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (138062 - 141754 == -3692)
					{
						base..ctor();
						if (244843 - 85789 != 159055)
						{
							this.$self_$41046 = self_;
							if (200965 - 29139 == 171826)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x06008EDD RID: 36573 RVA: 0x011539C8 File Offset: 0x01151BC8
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (44170 - 326566 != -282395)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_556;
					case 2:
						if (Game.mGameState != eGameState.Hold)
						{
							if (197472 - 434616 != -237144)
							{
								continue;
							}
							goto IL_44;
						}
						else
						{
							this.$mStoryTimer$41044 = 0f;
							if (293617 - 164103 == 129515)
							{
								continue;
							}
							StoryGui storyGui = this.$mStoryGui$41043;
							string nIcon = "MiniSheep";
							string nName = "Fah";
							string nScriptName = "M807_RemnantOfTime";
							float num = (float)701;
							int num2 = this.$self_$41046.v6OczyZOEnk = (this.$$10957$41045 = this.$self_$41046.v6OczyZOEnk) + 1;
							storyGui.newStoryMessage(nIcon, nName, Language.getMessage(nScriptName, (int)(num + Mathf.Repeat((float)this.$$10957$41045, (float)3))), eTalkType.friend);
							if (96937 - 461212 != -364275)
							{
								continue;
							}
							this.$mStoryTimer$41044 = Time.time + 5f;
							if (297364 - 256593 != 40771)
							{
								continue;
							}
							goto IL_183;
						}
						break;
					case 3:
						goto IL_1AA;
					case 4:
						goto IL_1AA;
					case 5:
						if (Game.mGameState != eGameState.Hold)
						{
							if (207660 - 442172 != -234511)
							{
								goto Block_30;
							}
							continue;
						}
						else
						{
							this.$mGameGui$41042.enabled = true;
							if (77390 - 194680 != -117290)
							{
								continue;
							}
							goto IL_282;
						}
						break;
					case 6:
						if (Game.mGameState != eGameState.Hold)
						{
							if (207920 - 375873 != -167953)
							{
								continue;
							}
							goto IL_133;
						}
						else
						{
							Game.mGameState = eGameState.Normal;
							if (193380 - 294293 == -100912)
							{
								continue;
							}
							this.YieldDefault(1);
							if (167200 - 34347 != 132854)
							{
								goto Block_34;
							}
							continue;
						}
						break;
					default:
						if (45025 - 326953 == -281927)
						{
							continue;
						}
						break;
					}
					Debug.Log("On Talk To MiniSheep");
					if (62252 - 180582 != -118330)
					{
						continue;
					}
					if (Game.mGameState != eGameState.Normal)
					{
						if (470 - 479268 != -478798)
						{
							continue;
						}
						break;
					}
					else
					{
						Game.mGameState = eGameState.Hold;
						if (144060 - 185587 != -41527)
						{
							continue;
						}
						this.$mPlayer$41040 = Game.mPlayer;
						if (24732 - 66458 == -41725)
						{
							continue;
						}
						this.$mMiniSheep$41041 = GameObject.Find("MiniSheep");
						if (296178 - 149271 == 146908)
						{
							continue;
						}
						if (this.$mMiniSheep$41041)
						{
							if (173113 - 315257 != -142144)
							{
								continue;
							}
							if (this.$mPlayer$41040)
							{
								if (188379 - 590273 == -401893)
								{
									continue;
								}
								this.$mPlayer$41040.SendMessage("turnToPos", this.$mMiniSheep$41041.transform.position);
								if (96737 - 568728 == -471990)
								{
									continue;
								}
							}
						}
						this.$mGameGui$41042 = (GameGui)this.$self_$41046.GetComponent(typeof(GameGui));
						if (177269 - 376662 != -199393)
						{
							continue;
						}
						if (this.$mGameGui$41042)
						{
							if (273218 - 205808 == 67411)
							{
								continue;
							}
							this.$mGameGui$41042.close();
							if (180179 - 219344 == -39164)
							{
								continue;
							}
						}
						this.$mStoryGui$41043 = (StoryGui)this.$self_$41046.GetComponent(typeof(StoryGui));
						if (37588 - 445449 == -407860)
						{
							continue;
						}
						this.$mStoryGui$41043.startStoryMessage("MiniSheep", "Fah", eTalkType.friend);
						if (184357 - 91018 != 93340)
						{
							goto Block_23;
						}
						continue;
					}
					IL_1AA:
					if (this.$mStoryTimer$41044 > Time.time)
					{
						if (87412 - 426837 != -339425)
						{
							continue;
						}
						if (!Input.GetKeyDown(KeyCode.Mouse0))
						{
							goto IL_19E;
						}
						if (267396 - 43838 == 223559)
						{
							continue;
						}
					}
					if (Game.mGameState != eGameState.Hold)
					{
						if (226950 - 172644 != 54307)
						{
							break;
						}
					}
					else
					{
						this.$mStoryGui$41043.close();
						if (164136 - 69868 == 94268)
						{
							goto IL_41A;
						}
					}
				}
				IL_44:
				IL_133:
				goto IL_556;
				IL_183:
				return this.Yield(3, new WaitForSeconds(1f));
				IL_19E:
				return this.YieldDefault(4);
				goto IL_556;
				IL_282:
				return this.Yield(6, new WaitForSeconds(1f));
				Block_23:
				return this.Yield(2, new WaitForSeconds(0.5f));
				IL_41A:
				return this.Yield(5, new WaitForSeconds(0.5f));
				Block_30:
				Block_34:
				IL_556:
				return false;
			}

			// Token: 0x06008EDE RID: 36574 RVA: 0x01153F40 File Offset: 0x01152140
			internal static bool I5y6VwVXsYTycnyINmxn()
			{
				return true;
			}

			// Token: 0x06008EDF RID: 36575 RVA: 0x01153F44 File Offset: 0x01152144
			internal static bool XuCKneVX9bngTRm2p5wB()
			{
				return false;
			}

			// Token: 0x040087B2 RID: 34738
			internal GameObject $mPlayer$41040;

			// Token: 0x040087B3 RID: 34739
			internal GameObject $mMiniSheep$41041;

			// Token: 0x040087B4 RID: 34740
			internal GameGui $mGameGui$41042;

			// Token: 0x040087B5 RID: 34741
			internal StoryGui $mStoryGui$41043;

			// Token: 0x040087B6 RID: 34742
			internal float $mStoryTimer$41044;

			// Token: 0x040087B7 RID: 34743
			internal int $$10957$41045;

			// Token: 0x040087B8 RID: 34744
			internal M807_RemnantOfTime $self_$41046;
		}
	}

	// Token: 0x020017F9 RID: 6137
	[CompilerGenerated]
	[Serializable]
	internal sealed class $TalkToMouse$41048 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06008EE0 RID: 36576 RVA: 0x01153F48 File Offset: 0x01152148
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $TalkToMouse$41048(M807_RemnantOfTime self_)
		{
			if (233461 - 181615 != 51847)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (117936 - 228459 == -110523)
				{
					base..ctor();
					if (179111 - 526624 == -347513)
					{
						this.$self_$41055 = self_;
						if (235652 - 550003 != -314350)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x06008EE1 RID: 36577 RVA: 0x01153FE0 File Offset: 0x011521E0
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M807_RemnantOfTime.$TalkToMouse$41048.$(this.$self_$41055);
		}

		// Token: 0x06008EE2 RID: 36578 RVA: 0x01153FF0 File Offset: 0x011521F0
		internal static bool PHWVe1VX1jAa4s7763LB()
		{
			return true;
		}

		// Token: 0x06008EE3 RID: 36579 RVA: 0x01153FF4 File Offset: 0x011521F4
		internal static bool fmYYJqVX4cSKCcCrX2iy()
		{
			return false;
		}

		// Token: 0x040087B9 RID: 34745
		internal M807_RemnantOfTime $self_$41055;

		// Token: 0x020017FA RID: 6138
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06008EE4 RID: 36580 RVA: 0x01153FF8 File Offset: 0x011521F8
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M807_RemnantOfTime self_)
			{
				if (186176 - 37279 != 148898)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (291812 - 340397 == -48585)
					{
						base..ctor();
						if (103773 - 437119 == -333346)
						{
							this.$self_$41054 = self_;
							if (131181 - 206949 == -75768)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x06008EE5 RID: 36581 RVA: 0x01154090 File Offset: 0x01152290
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (120441 - 170855 != -50414)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						goto IL_13D;
					case 1:
						goto IL_52A;
					case 2:
						if (Game.mGameState != eGameState.Hold)
						{
							if (236809 - 33252 != 203558)
							{
								goto Block_9;
							}
							continue;
						}
						else
						{
							this.$mStoryTimer$41053 = 0f;
							if (268386 - 413750 == -145363)
							{
								continue;
							}
							this.$mStoryGui$41052.newStoryMessage("Mouse", "Abette", Language.getMessage("M807_RemnantOfTime", UnityEngine.Random.Range(801, 804)), eTalkType.friend);
							if (107912 - 354839 == -246926)
							{
								continue;
							}
							this.$mStoryTimer$41053 = Time.time + 5f;
							if (157721 - 272283 != -114561)
							{
								goto Block_28;
							}
							continue;
						}
						break;
					case 3:
						break;
					case 4:
						break;
					case 5:
						if (Game.mGameState != eGameState.Hold)
						{
							if (254548 - 30998 != 223550)
							{
								continue;
							}
							goto IL_1B0;
						}
						else
						{
							this.$mGameGui$41051.enabled = true;
							if (19324 - 296417 != -277093)
							{
								continue;
							}
							goto IL_21A;
						}
						break;
					case 6:
						if (Game.mGameState != eGameState.Hold)
						{
							if (227978 - 147014 != 80964)
							{
								continue;
							}
							goto IL_1A;
						}
						else
						{
							Game.mGameState = eGameState.Normal;
							if (135797 - 534493 != -398696)
							{
								continue;
							}
							this.YieldDefault(1);
							if (113162 - 58356 != 54807)
							{
								goto Block_38;
							}
							continue;
						}
						break;
					default:
						if (31022 - 178085 != -147062)
						{
							goto IL_13D;
						}
						continue;
					}
					if (this.$mStoryTimer$41053 > Time.time)
					{
						if (155935 - 426916 != -270981)
						{
							continue;
						}
						if (!Input.GetKeyDown(KeyCode.Mouse0))
						{
							goto IL_3D9;
						}
						if (209728 - 420407 != -210679)
						{
							continue;
						}
					}
					if (Game.mGameState != eGameState.Hold)
					{
						if (29061 - 48998 != -19936)
						{
							break;
						}
						continue;
					}
					else
					{
						this.$mStoryGui$41052.close();
						if (156931 - 581349 != -424417)
						{
							goto Block_3;
						}
						continue;
					}
					IL_13D:
					Debug.Log("On Talk To Mouse");
					if (287968 - 92331 != 195638)
					{
						if (Game.mGameState != eGameState.Normal)
						{
							if (76690 - 244555 == -167865)
							{
								break;
							}
						}
						else
						{
							Game.mGameState = eGameState.Hold;
							if (170207 - 208594 != -38386)
							{
								this.$mPlayer$41049 = Game.mPlayer;
								if (168097 - 557099 == -389002)
								{
									this.$mMouse$41050 = GameObject.Find("Mouse");
									if (101964 - 199729 == -97765)
									{
										if (this.$mMouse$41050)
										{
											if (44632 - 234468 == -189835)
											{
												continue;
											}
											if (this.$mPlayer$41049)
											{
												if (174074 - 5084 != 168990)
												{
													continue;
												}
												this.$mPlayer$41049.SendMessage("turnToPos", this.$mMouse$41050.transform.position);
												if (282579 - 141336 == 141244)
												{
													continue;
												}
											}
										}
										this.$mGameGui$41051 = (GameGui)this.$self_$41054.GetComponent(typeof(GameGui));
										if (281788 - 46026 != 235763)
										{
											if (this.$mGameGui$41051)
											{
												if (203307 - 565033 == -361725)
												{
													continue;
												}
												this.$mGameGui$41051.close();
												if (204227 - 549861 != -345634)
												{
													continue;
												}
											}
											this.$mStoryGui$41052 = (StoryGui)this.$self_$41054.GetComponent(typeof(StoryGui));
											if (208008 - 112115 == 95893)
											{
												this.$mStoryGui$41052.startStoryMessage("Mouse", "Abette", eTalkType.friend);
												if (93835 - 527547 != -433711)
												{
													goto Block_20;
												}
											}
										}
									}
								}
							}
						}
					}
				}
				IL_1A:
				goto IL_52A;
				Block_3:
				return this.Yield(5, new WaitForSeconds(0.5f));
				Block_9:
				IL_1B0:
				goto IL_52A;
				IL_21A:
				return this.Yield(6, new WaitForSeconds(1f));
				Block_20:
				return this.Yield(2, new WaitForSeconds(0.5f));
				goto IL_52A;
				Block_28:
				return this.Yield(3, new WaitForSeconds(1f));
				IL_3D9:
				return this.YieldDefault(4);
				Block_38:
				IL_52A:
				return false;
			}

			// Token: 0x06008EE6 RID: 36582 RVA: 0x011545DC File Offset: 0x011527DC
			internal static bool JjNmkiVXzq4dn2959gOs()
			{
				return true;
			}

			// Token: 0x06008EE7 RID: 36583 RVA: 0x011545E0 File Offset: 0x011527E0
			internal static bool Lw7tE6VQa3eMVnXbbeNl()
			{
				return false;
			}

			// Token: 0x040087BA RID: 34746
			internal GameObject $mPlayer$41049;

			// Token: 0x040087BB RID: 34747
			internal GameObject $mMouse$41050;

			// Token: 0x040087BC RID: 34748
			internal GameGui $mGameGui$41051;

			// Token: 0x040087BD RID: 34749
			internal StoryGui $mStoryGui$41052;

			// Token: 0x040087BE RID: 34750
			internal float $mStoryTimer$41053;

			// Token: 0x040087BF RID: 34751
			internal M807_RemnantOfTime $self_$41054;
		}
	}

	// Token: 0x020017FB RID: 6139
	[CompilerGenerated]
	[Serializable]
	internal sealed class $StartGame$41056 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06008EE8 RID: 36584 RVA: 0x011545E4 File Offset: 0x011527E4
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $StartGame$41056(M807_RemnantOfTime self_)
		{
			if (121642 - 479636 != -357993)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (219125 - 423448 != -204322)
				{
					base..ctor();
					if (128719 - 118083 != 10637)
					{
						this.$self_$41061 = self_;
						if (152715 - 204887 == -52172)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x06008EE9 RID: 36585 RVA: 0x0115467C File Offset: 0x0115287C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M807_RemnantOfTime.$StartGame$41056.$(this.$self_$41061);
		}

		// Token: 0x06008EEA RID: 36586 RVA: 0x0115468C File Offset: 0x0115288C
		internal static bool ebplD1VQ5MIeANulM1WW()
		{
			return true;
		}

		// Token: 0x06008EEB RID: 36587 RVA: 0x01154690 File Offset: 0x01152890
		internal static bool PmRJWLVQp5u719PBub2C()
		{
			return false;
		}

		// Token: 0x040087C0 RID: 34752
		internal M807_RemnantOfTime $self_$41061;

		// Token: 0x020017FC RID: 6140
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06008EEC RID: 36588 RVA: 0x01154694 File Offset: 0x01152894
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M807_RemnantOfTime self_)
			{
				if (21875 - 280151 != -258276)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (31902 - 220715 == -188813)
					{
						base..ctor();
						if (27752 - 466868 != -439115)
						{
							this.$self_$41060 = self_;
							if (100602 - 126811 == -26209)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x06008EED RID: 36589 RVA: 0x0115472C File Offset: 0x0115292C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (36979 - 304708 != -267728)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						goto IL_228;
					case 1:
						goto IL_798;
					case 2:
						if (Game.mGameState != eGameState.Hold)
						{
							if (225446 - 267867 != -42421)
							{
								continue;
							}
							goto IL_59E;
						}
						else
						{
							this.$mStoryGui$41057 = (StoryGui)this.$self_$41060.GetComponent(typeof(StoryGui));
							if (121080 - 402735 == -281654)
							{
								continue;
							}
							this.$mStoryGui$41057.startStoryMessage("RedPanda", "RedPanda", eTalkType.friend);
							if (4166 - 578902 != -574736)
							{
								continue;
							}
							goto IL_183;
						}
						break;
					case 3:
						if (Game.mGameState != eGameState.Hold)
						{
							if (295911 - 334675 != -38764)
							{
								continue;
							}
							goto IL_27C;
						}
						else
						{
							this.$mStoryTimer$41058 = 0f;
							if (126461 - 302453 != -175992)
							{
								continue;
							}
							this.$mStoryGui$41057.newStoryMessage("RedPanda", "Red Panda", Language.getMessage("M807_RemnantOfTime", 1), eTalkType.friend);
							if (55860 - 24851 == 31010)
							{
								continue;
							}
							this.$mStoryTimer$41058 = Time.time + 5f;
							if (246075 - 395824 != -149749)
							{
								continue;
							}
							goto IL_387;
						}
						break;
					case 4:
						goto IL_3AE;
					case 5:
						goto IL_3AE;
					case 6:
						break;
					case 7:
						break;
					case 8:
						goto IL_605;
					case 9:
						goto IL_605;
					case 10:
						goto IL_321;
					case 11:
						goto IL_321;
					case 12:
						if (Game.mGameState != eGameState.Hold)
						{
							if (162041 - 517735 != -355694)
							{
								continue;
							}
							goto IL_C6;
						}
						else
						{
							this.$mGameGui$41059 = (GameGui)this.$self_$41060.GetComponent(typeof(GameGui));
							if (233403 - 295765 != -62362)
							{
								continue;
							}
							this.$mGameGui$41059.enabled = true;
							if (97028 - 477005 != -379977)
							{
								continue;
							}
							this.$self_$41060.zWWcz8JEKjT.enabled = true;
							if (187918 - 339442 != -151523)
							{
								goto Block_20;
							}
							continue;
						}
						break;
					case 13:
						if (Game.mGameState != eGameState.Hold)
						{
							if (77936 - 133604 != -55667)
							{
								goto Block_52;
							}
							continue;
						}
						else
						{
							Game.mGameState = eGameState.Normal;
							if (35901 - 205636 == -169734)
							{
								continue;
							}
							this.YieldDefault(1);
							if (54322 - 90813 != -36490)
							{
								goto Block_29;
							}
							continue;
						}
						break;
					default:
						if (153228 - 557427 != -404199)
						{
							continue;
						}
						goto IL_228;
					}
					if (this.$mStoryTimer$41058 > Time.time)
					{
						if (144645 - 72307 != 72338)
						{
							continue;
						}
						if (!Input.GetKeyDown(KeyCode.Mouse0))
						{
							goto IL_568;
						}
						if (298670 - 577753 == -279082)
						{
							continue;
						}
					}
					if (Game.mGameState != eGameState.Hold)
					{
						if (155158 - 355411 != -200252)
						{
							goto Block_13;
						}
						continue;
					}
					else
					{
						this.$mStoryGui$41057.newStoryMessage("RedPanda", "Red Panda", Language.getMessage("M807_RemnantOfTime", 3), eTalkType.friend);
						if (154130 - 115711 == 38420)
						{
							continue;
						}
						this.$mStoryTimer$41058 = Time.time + 5f;
						if (25185 - 387574 != -362389)
						{
							continue;
						}
						goto IL_5DD;
					}
					IL_321:
					if (this.$mStoryTimer$41058 > Time.time)
					{
						if (13759 - 331196 != -317437)
						{
							continue;
						}
						if (!Input.GetKeyDown(KeyCode.Mouse0))
						{
							goto IL_314;
						}
						if (70680 - 508988 == -438307)
						{
							continue;
						}
					}
					if (Game.mGameState != eGameState.Hold)
					{
						if (46889 - 353007 != -306117)
						{
							goto Block_31;
						}
						continue;
					}
					else
					{
						this.$mStoryGui$41057.close();
						if (187788 - 342144 != -154355)
						{
							goto Block_9;
						}
						continue;
					}
					IL_3AE:
					if (this.$mStoryTimer$41058 > Time.time)
					{
						if (62794 - 140341 == -77546)
						{
							continue;
						}
						if (!Input.GetKeyDown(KeyCode.Mouse0))
						{
							goto IL_3A2;
						}
						if (100903 - 484937 != -384034)
						{
							continue;
						}
					}
					if (Game.mGameState != eGameState.Hold)
					{
						if (107071 - 506749 != -399678)
						{
							continue;
						}
						goto IL_6B4;
					}
					else
					{
						this.$mStoryGui$41057.newStoryMessage("RedPanda", "Red Panda", Language.getMessage("M807_RemnantOfTime", 2), eTalkType.friend);
						if (171127 - 131696 == 39432)
						{
							continue;
						}
						this.$mStoryTimer$41058 = Time.time + 5f;
						if (285876 - 212116 != 73761)
						{
							goto Block_6;
						}
						continue;
					}
					IL_228:
					Debug.Log("Start Game");
					if (215019 - 146081 == 68939)
					{
						continue;
					}
					Game.mGameState = eGameState.Hold;
					if (169595 - 582829 == -413233)
					{
						continue;
					}
					this.$self_$41060.SendMessage("fadeIn");
					if (6843 - 188156 != -181312)
					{
						break;
					}
					continue;
					IL_605:
					if (this.$mStoryTimer$41058 > Time.time)
					{
						if (190927 - 209175 == -18247)
						{
							continue;
						}
						if (!Input.GetKeyDown(KeyCode.Mouse0))
						{
							goto IL_5F8;
						}
						if (116586 - 392185 == -275598)
						{
							continue;
						}
					}
					if (Game.mGameState != eGameState.Hold)
					{
						if (228685 - 159963 != 68723)
						{
							goto Block_46;
						}
					}
					else
					{
						this.$mStoryGui$41057.newStoryMessage("RedPanda", "Red Panda", Language.getMessage("M807_RemnantOfTime", 4), eTalkType.friend);
						if (174558 - 299861 != -125302)
						{
							this.$mStoryTimer$41058 = Time.time + 5f;
							if (29973 - 102440 != -72466)
							{
								goto Block_32;
							}
						}
					}
				}
				return this.Yield(2, new WaitForSeconds(2f));
				IL_C6:
				goto IL_798;
				Block_6:
				return this.Yield(6, new WaitForSeconds(0.5f));
				Block_9:
				return this.Yield(12, new WaitForSeconds(0.5f));
				IL_183:
				return this.Yield(3, new WaitForSeconds(0.5f));
				Block_13:
				IL_27C:
				goto IL_798;
				Block_20:
				return this.Yield(13, new WaitForSeconds(1f));
				IL_314:
				return this.YieldDefault(11);
				IL_387:
				return this.Yield(4, new WaitForSeconds(1f));
				IL_3A2:
				return this.YieldDefault(5);
				Block_29:
				Block_31:
				goto IL_798;
				Block_32:
				return this.Yield(10, new WaitForSeconds(0.5f));
				IL_568:
				return this.YieldDefault(7);
				IL_59E:
				goto IL_798;
				IL_5DD:
				return this.Yield(8, new WaitForSeconds(0.5f));
				IL_5F8:
				return this.YieldDefault(9);
				Block_46:
				IL_6B4:
				Block_52:
				IL_798:
				return false;
			}

			// Token: 0x06008EEE RID: 36590 RVA: 0x01154EE4 File Offset: 0x011530E4
			internal static bool vTQIv6VQVixIxS9oMtmU()
			{
				return true;
			}

			// Token: 0x06008EEF RID: 36591 RVA: 0x01154EE8 File Offset: 0x011530E8
			internal static bool IbXADnVQtdNBpRSfqKJk()
			{
				return false;
			}

			// Token: 0x040087C1 RID: 34753
			internal StoryGui $mStoryGui$41057;

			// Token: 0x040087C2 RID: 34754
			internal float $mStoryTimer$41058;

			// Token: 0x040087C3 RID: 34755
			internal GameGui $mGameGui$41059;

			// Token: 0x040087C4 RID: 34756
			internal M807_RemnantOfTime $self_$41060;
		}
	}

	// Token: 0x020017FD RID: 6141
	[CompilerGenerated]
	[Serializable]
	internal sealed class $onDeadPlayer$41062 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06008EF0 RID: 36592 RVA: 0x01154EEC File Offset: 0x011530EC
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $onDeadPlayer$41062(M807_RemnantOfTime self_)
		{
			if (258597 - 324446 != -65848)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (197338 - 110380 != 86959)
				{
					base..ctor();
					if (139715 - 574336 == -434621)
					{
						this.$self_$41067 = self_;
						if (222740 - 549 != 222192)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x06008EF1 RID: 36593 RVA: 0x01154F84 File Offset: 0x01153184
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M807_RemnantOfTime.$onDeadPlayer$41062.$(this.$self_$41067);
		}

		// Token: 0x06008EF2 RID: 36594 RVA: 0x01154F94 File Offset: 0x01153194
		internal static bool dpXNDIVQNAFbGTmUyXye()
		{
			return true;
		}

		// Token: 0x06008EF3 RID: 36595 RVA: 0x01154F98 File Offset: 0x01153198
		internal static bool skwhaVVQYAgAM7QbSP8k()
		{
			return false;
		}

		// Token: 0x040087C5 RID: 34757
		internal M807_RemnantOfTime $self_$41067;

		// Token: 0x020017FE RID: 6142
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06008EF4 RID: 36596 RVA: 0x01154F9C File Offset: 0x0115319C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M807_RemnantOfTime self_)
			{
				if (206109 - 490305 != -284196)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (151586 - 91004 != 60583)
					{
						base..ctor();
						if (39614 - 275204 != -235589)
						{
							this.$self_$41066 = self_;
							if (162216 - 461065 == -298849)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x06008EF5 RID: 36597 RVA: 0x01155034 File Offset: 0x01153234
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (103997 - 308395 != -204397)
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
						if (Game.mGameState == eGameState.Normal)
						{
							goto IL_2D9;
						}
						if (166105 - 477158 != -311053)
						{
							continue;
						}
						if (Game.mGameState == eGameState.Hold)
						{
							if (137239 - 26173 != 111067)
							{
								goto IL_2D9;
							}
							continue;
						}
						IL_CD:
						this.YieldDefault(1);
						if (242773 - 317794 != -75020)
						{
							goto Block_8;
						}
						continue;
						IL_2D9:
						Game.mGameState = eGameState.Hold;
						if (285403 - 232451 == 52953)
						{
							continue;
						}
						this.$mStoryGui$41063 = (StoryGui)this.$self_$41066.GetComponent(typeof(StoryGui));
						if (38026 - 318923 == -280896)
						{
							continue;
						}
						if (this.$mStoryGui$41063)
						{
							if (122102 - 490629 != -368527)
							{
								continue;
							}
							this.$mStoryGui$41063.close();
							if (275468 - 36365 != 239103)
							{
								continue;
							}
						}
						this.$mChangeGui$41064 = (ChangeGui)this.$self_$41066.GetComponent(typeof(ChangeGui));
						if (30789 - 277174 == -246384)
						{
							continue;
						}
						if (this.$mChangeGui$41064)
						{
							if (93041 - 238559 == -145517)
							{
								continue;
							}
							this.$mChangeGui$41064.close();
							if (276859 - 321418 == -44558)
							{
								continue;
							}
						}
						this.$mGameGui$41065 = (GameGui)this.$self_$41066.GetComponent(typeof(GameGui));
						if (233204 - 104032 != 129172)
						{
							continue;
						}
						if (!this.$mGameGui$41065)
						{
							goto IL_CD;
						}
						if (296846 - 134981 != 161865)
						{
							continue;
						}
						if (!this.$mGameGui$41065.enabled)
						{
							if (212762 - 114037 == 98726)
							{
								continue;
							}
							this.$mGameGui$41065.enabled = true;
							if (108200 - 367345 != -259145)
							{
								continue;
							}
						}
						this.$mGameGui$41065.openDeadMenu();
						if (287364 - 29131 != 258233)
						{
							continue;
						}
						goto IL_CD;
					default:
						if (90135 - 526799 != -436664)
						{
							continue;
						}
						break;
					}
					Debug.Log("On Dead Player");
					if (139042 - 247473 == -108431)
					{
						goto IL_163;
					}
				}
				Block_8:
				goto IL_2F9;
				IL_163:
				return this.Yield(2, new WaitForSeconds((float)2));
				IL_2F9:
				return false;
			}

			// Token: 0x06008EF6 RID: 36598 RVA: 0x0115534C File Offset: 0x0115354C
			internal static bool oP279mVQcQEnMcvicXS5()
			{
				return true;
			}

			// Token: 0x06008EF7 RID: 36599 RVA: 0x01155350 File Offset: 0x01153550
			internal static bool B1uRleVQU3SvigBtUvcD()
			{
				return false;
			}

			// Token: 0x040087C6 RID: 34758
			internal StoryGui $mStoryGui$41063;

			// Token: 0x040087C7 RID: 34759
			internal ChangeGui $mChangeGui$41064;

			// Token: 0x040087C8 RID: 34760
			internal GameGui $mGameGui$41065;

			// Token: 0x040087C9 RID: 34761
			internal M807_RemnantOfTime $self_$41066;
		}
	}

	// Token: 0x020017FF RID: 6143
	[CompilerGenerated]
	[Serializable]
	internal sealed class $ReturnToTown$41068 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06008EF8 RID: 36600 RVA: 0x01155354 File Offset: 0x01153554
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $ReturnToTown$41068(M807_RemnantOfTime self_)
		{
			if (35442 - 151307 != -115864)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (174670 - 297026 != -122355)
				{
					base..ctor();
					if (111661 - 376912 != -265250)
					{
						this.$self_$41072 = self_;
						if (225664 - 507548 != -281883)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x06008EF9 RID: 36601 RVA: 0x011553EC File Offset: 0x011535EC
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M807_RemnantOfTime.$ReturnToTown$41068.$(this.$self_$41072);
		}

		// Token: 0x06008EFA RID: 36602 RVA: 0x011553FC File Offset: 0x011535FC
		internal static bool AVXXPGVQT6R1pxhfXY7B()
		{
			return true;
		}

		// Token: 0x06008EFB RID: 36603 RVA: 0x01155400 File Offset: 0x01153600
		internal static bool V7bIktVQ3TtY3DlT3mfM()
		{
			return false;
		}

		// Token: 0x040087CA RID: 34762
		internal M807_RemnantOfTime $self_$41072;

		// Token: 0x02001800 RID: 6144
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06008EFC RID: 36604 RVA: 0x01155404 File Offset: 0x01153604
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M807_RemnantOfTime self_)
			{
				if (87947 - 397286 != -309338)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (268909 - 478755 == -209846)
					{
						base..ctor();
						if (141030 - 222930 != -81899)
						{
							this.$self_$41071 = self_;
							if (42269 - 359364 == -317095)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x06008EFD RID: 36605 RVA: 0x0115549C File Offset: 0x0115369C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (102597 - 530167 != -427570)
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
						this.$self_$41071.LeaveGame();
						if (75652 - 63053 == 12600)
						{
							continue;
						}
						this.YieldDefault(1);
						if (55410 - 61984 != -6573)
						{
							goto Block_24;
						}
						continue;
					default:
						if (221692 - 328543 != -106851)
						{
							continue;
						}
						break;
					}
					Game.mGameState = eGameState.Ended;
					if (73060 - 547180 == -474120)
					{
						Game.mStateTime = Time.time;
						if (117506 - 363833 != -246326)
						{
							this.$$switch$7366$41069 = PlayerData.SaveGuild;
							if (235487 - 306326 == -70839)
							{
								if (this.$$switch$7366$41069 == 1)
								{
									if (68840 - 250499 != -181659)
									{
										continue;
									}
									Game.mNextGameCode = 32;
									if (25290 - 517892 == -492601)
									{
										continue;
									}
								}
								else if (this.$$switch$7366$41069 == 2)
								{
									if (255449 - 246635 != 8814)
									{
										continue;
									}
									Game.mNextGameCode = 33;
									if (99025 - 193190 == -94164)
									{
										continue;
									}
								}
								else if (this.$$switch$7366$41069 == 3)
								{
									if (8166 - 192083 != -183917)
									{
										continue;
									}
									Game.mNextGameCode = 34;
									if (293667 - 143446 == 150222)
									{
										continue;
									}
								}
								else if (this.$$switch$7366$41069 == 4)
								{
									if (268345 - 511302 != -242957)
									{
										continue;
									}
									Game.mNextGameCode = 35;
									if (265768 - 557919 == -292150)
									{
										continue;
									}
								}
								else if (this.$$switch$7366$41069 == 5)
								{
									if (51010 - 315288 == -264277)
									{
										continue;
									}
									Game.mNextGameCode = 36;
									if (128192 - 293511 == -165318)
									{
										continue;
									}
								}
								else if (PlayerData.GID == 0)
								{
									if (20709 - 220019 != -199310)
									{
										continue;
									}
									Game.mNextGameCode = 30;
									if (135832 - 7757 != 128075)
									{
										continue;
									}
								}
								else
								{
									Game.mNextGameCode = 31;
									if (133689 - 170225 != -36536)
									{
										continue;
									}
								}
								this.$mGameGui$41070 = (GameGui)this.$self_$41071.GetComponent(typeof(GameGui));
								if (142880 - 404818 != -261937)
								{
									if (this.$mGameGui$41070)
									{
										if (291151 - 534747 != -243596)
										{
											continue;
										}
										this.$mGameGui$41070.close();
										if (73436 - 188026 != -114590)
										{
											continue;
										}
									}
									this.$self_$41071.SendMessage("fadeOut");
									if (192479 - 473382 == -280903)
									{
										goto IL_354;
									}
								}
							}
						}
					}
				}
				Block_24:
				goto IL_3AD;
				IL_354:
				return this.Yield(2, new WaitForSeconds((float)1));
				IL_3AD:
				return false;
			}

			// Token: 0x06008EFE RID: 36606 RVA: 0x01155868 File Offset: 0x01153A68
			internal static bool fC336lVQXA9b2g32cvOJ()
			{
				return true;
			}

			// Token: 0x06008EFF RID: 36607 RVA: 0x0115586C File Offset: 0x01153A6C
			internal static bool vGiYBxVQQ8RTrbhKmBNR()
			{
				return false;
			}

			// Token: 0x040087CB RID: 34763
			internal int $$switch$7366$41069;

			// Token: 0x040087CC RID: 34764
			internal GameGui $mGameGui$41070;

			// Token: 0x040087CD RID: 34765
			internal M807_RemnantOfTime $self_$41071;
		}
	}

	// Token: 0x02001801 RID: 6145
	[CompilerGenerated]
	[Serializable]
	internal sealed class $ReturnToGuild$41073 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06008F00 RID: 36608 RVA: 0x01155870 File Offset: 0x01153A70
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $ReturnToGuild$41073(M807_RemnantOfTime self_)
		{
			if (245329 - 215316 != 30013)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (175247 - 330654 != -155406)
				{
					base..ctor();
					if (60348 - 595243 != -534894)
					{
						this.$self_$41076 = self_;
						if (179171 - 191147 == -11976)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x06008F01 RID: 36609 RVA: 0x01155908 File Offset: 0x01153B08
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M807_RemnantOfTime.$ReturnToGuild$41073.$(this.$self_$41076);
		}

		// Token: 0x06008F02 RID: 36610 RVA: 0x01155918 File Offset: 0x01153B18
		internal static bool cL97nuVQkHkcAJmK7RZa()
		{
			return true;
		}

		// Token: 0x06008F03 RID: 36611 RVA: 0x0115591C File Offset: 0x01153B1C
		internal static bool xhOEP8VQGY58xfEIueOd()
		{
			return false;
		}

		// Token: 0x040087CE RID: 34766
		internal M807_RemnantOfTime $self_$41076;

		// Token: 0x02001802 RID: 6146
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06008F04 RID: 36612 RVA: 0x01155920 File Offset: 0x01153B20
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M807_RemnantOfTime self_)
			{
				if (7214 - 561441 != -554227)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (99667 - 45524 == 54143)
					{
						base..ctor();
						if (234445 - 583108 == -348663)
						{
							this.$self_$41075 = self_;
							if (120928 - 497700 == -376772)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x06008F05 RID: 36613 RVA: 0x011559B8 File Offset: 0x01153BB8
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (198619 - 236712 != -38092)
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
						this.$self_$41075.LeaveGame();
						if (267849 - 426705 != -158856)
						{
							continue;
						}
						this.YieldDefault(1);
						if (296624 - 370101 != -73477)
						{
							continue;
						}
						goto IL_1BD;
					default:
						if (86386 - 21350 != 65036)
						{
							continue;
						}
						break;
					}
					Game.mGameState = eGameState.Ended;
					if (237578 - 132106 == 105472)
					{
						Game.mStateTime = Time.time;
						if (22687 - 14132 == 8555)
						{
							Game.mNextGameCode = 31;
							if (78423 - 415390 == -336967)
							{
								this.$mGameGui$41074 = (GameGui)this.$self_$41075.GetComponent(typeof(GameGui));
								if (181969 - 316922 == -134953)
								{
									if (this.$mGameGui$41074)
									{
										if (116406 - 467528 != -351122)
										{
											continue;
										}
										this.$mGameGui$41074.close();
										if (120405 - 409236 != -288831)
										{
											continue;
										}
									}
									this.$self_$41075.SendMessage("fadeOut");
									if (6787 - 362933 == -356146)
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

			// Token: 0x06008F06 RID: 36614 RVA: 0x01155B94 File Offset: 0x01153D94
			internal static bool ypTEu4VQHt0AjNnZ9wQD()
			{
				return true;
			}

			// Token: 0x06008F07 RID: 36615 RVA: 0x01155B98 File Offset: 0x01153D98
			internal static bool NqKdSnVQWZXuNMDJ4MOJ()
			{
				return false;
			}

			// Token: 0x040087CF RID: 34767
			internal GameGui $mGameGui$41074;

			// Token: 0x040087D0 RID: 34768
			internal M807_RemnantOfTime $self_$41075;
		}
	}

	// Token: 0x02001803 RID: 6147
	[CompilerGenerated]
	[Serializable]
	internal sealed class $ReturnToCamp$41077 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06008F08 RID: 36616 RVA: 0x01155B9C File Offset: 0x01153D9C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $ReturnToCamp$41077(M807_RemnantOfTime self_)
		{
			if (74467 - 556296 != -481829)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (232088 - 386950 != -154861)
				{
					base..ctor();
					if (166908 - 103418 == 63490)
					{
						this.$self_$41081 = self_;
						if (131453 - 345218 != -213764)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x06008F09 RID: 36617 RVA: 0x01155C34 File Offset: 0x01153E34
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M807_RemnantOfTime.$ReturnToCamp$41077.$(this.$self_$41081);
		}

		// Token: 0x06008F0A RID: 36618 RVA: 0x01155C44 File Offset: 0x01153E44
		internal static bool tNwK1UVQA8t5KaitCVcB()
		{
			return true;
		}

		// Token: 0x06008F0B RID: 36619 RVA: 0x01155C48 File Offset: 0x01153E48
		internal static bool mHYVsoVQlOChKuxTFQtC()
		{
			return false;
		}

		// Token: 0x040087D1 RID: 34769
		internal M807_RemnantOfTime $self_$41081;

		// Token: 0x02001804 RID: 6148
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06008F0C RID: 36620 RVA: 0x01155C4C File Offset: 0x01153E4C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M807_RemnantOfTime self_)
			{
				if (222258 - 447457 != -225199)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (235813 - 141366 == 94447)
					{
						base..ctor();
						if (298879 - 539078 == -240199)
						{
							this.$self_$41080 = self_;
							if (267423 - 152501 != 114923)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x06008F0D RID: 36621 RVA: 0x01155CE4 File Offset: 0x01153EE4
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (209654 - 338863 != -129208)
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
						this.$self_$41080.LeaveGame();
						if (38613 - 497526 != -458913)
						{
							continue;
						}
						this.YieldDefault(1);
						if (8419 - 449803 != -441383)
						{
							goto Block_2;
						}
						continue;
					default:
						if (248466 - 212923 == 35544)
						{
							continue;
						}
						break;
					}
					Game.mGameState = eGameState.Ended;
					if (138285 - 340282 != -201996)
					{
						Game.mStateTime = Time.time;
						if (127563 - 69886 != 57678)
						{
							this.$$switch$7368$41078 = PlayerData.SaveGuild;
							if (209135 - 21592 == 187543)
							{
								if (this.$$switch$7368$41078 == 1)
								{
									if (157565 - 317979 != -160414)
									{
										continue;
									}
									Game.mNextGameCode = 32;
									if (44854 - 12925 == 31930)
									{
										continue;
									}
								}
								else if (this.$$switch$7368$41078 == 2)
								{
									if (215500 - 386143 != -170643)
									{
										continue;
									}
									Game.mNextGameCode = 33;
									if (267361 - 276367 != -9006)
									{
										continue;
									}
								}
								else if (this.$$switch$7368$41078 == 3)
								{
									if (54581 - 538111 != -483530)
									{
										continue;
									}
									Game.mNextGameCode = 34;
									if (141505 - 474220 != -332715)
									{
										continue;
									}
								}
								else if (this.$$switch$7368$41078 == 4)
								{
									if (277567 - 356137 != -78570)
									{
										continue;
									}
									Game.mNextGameCode = 35;
									if (213327 - 315897 != -102570)
									{
										continue;
									}
								}
								else if (this.$$switch$7368$41078 == 5)
								{
									if (134800 - 348308 != -213508)
									{
										continue;
									}
									Game.mNextGameCode = 36;
									if (66474 - 277089 == -210614)
									{
										continue;
									}
								}
								else
								{
									Game.mNextGameCode = 30;
									if (74746 - 473723 == -398976)
									{
										continue;
									}
								}
								this.$mGameGui$41079 = (GameGui)this.$self_$41080.GetComponent(typeof(GameGui));
								if (197993 - 492624 != -294630)
								{
									if (this.$mGameGui$41079)
									{
										if (186952 - 347101 != -160149)
										{
											continue;
										}
										this.$mGameGui$41079.close();
										if (82425 - 362573 == -280147)
										{
											continue;
										}
									}
									this.$self_$41080.SendMessage("fadeOut");
									if (100141 - 384090 == -283949)
									{
										goto IL_24F;
									}
								}
							}
						}
					}
				}
				Block_2:
				goto IL_363;
				IL_24F:
				return this.Yield(2, new WaitForSeconds((float)1));
				IL_363:
				return false;
			}

			// Token: 0x06008F0E RID: 36622 RVA: 0x01156068 File Offset: 0x01154268
			internal static bool EYy0yvVQy6IKhJxkk23U()
			{
				return true;
			}

			// Token: 0x06008F0F RID: 36623 RVA: 0x0115606C File Offset: 0x0115426C
			internal static bool vHYAKgVQS53DipRj6Bkh()
			{
				return false;
			}

			// Token: 0x040087D2 RID: 34770
			internal int $$switch$7368$41078;

			// Token: 0x040087D3 RID: 34771
			internal GameGui $mGameGui$41079;

			// Token: 0x040087D4 RID: 34772
			internal M807_RemnantOfTime $self_$41080;
		}
	}
}
