using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Boo.Lang;
using Boo.Lang.Runtime;
using cZRJ81ju0AbIsUerIn;
using ExitGames.Client.Photon;
using UnityEngine;

// Token: 0x020015E5 RID: 5605
[Serializable]
public class M505_SunkenCity2 : MonoBehaviour
{
	// Token: 0x06008203 RID: 33283 RVA: 0x01081BAC File Offset: 0x0107FDAC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public M505_SunkenCity2()
	{
		LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
		base..ctor();
	}

	// Token: 0x06008204 RID: 33284 RVA: 0x01081BBC File Offset: 0x0107FDBC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Awake()
	{
		if (182295 - 330466 != -148171)
		{
		}
		for (;;)
		{
			Game.mGameState = eGameState.Init;
			if (54191 - 479927 == -425736)
			{
				Game.mGameType = 5;
				if (94268 - 329235 == -234967)
				{
					if (Chat.Initialized)
					{
						if (53172 - 579217 != -526044)
						{
							Chat.ChatDisplay.Clear();
							if (174852 - 160515 == 14337)
							{
								break;
							}
						}
					}
					else
					{
						Chat.Init();
						if (196595 - 364291 == -167696)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x06008205 RID: 33285 RVA: 0x01081CA0 File Offset: 0x0107FEA0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Start()
	{
		if (288948 - 365636 != -76687)
		{
		}
		for (;;)
		{
			if (PhotonClient.IsInitialized())
			{
				if (184886 - 536354 != -351467)
				{
					if (Game.mNextGameCode != 505)
					{
						break;
					}
					if (87013 - 596468 != -509454)
					{
						if (Game.mGameStage != 2)
						{
							break;
						}
						if (123825 - 75758 == 48067)
						{
							Game.nextGame();
							if (153363 - 438750 != -285386)
							{
								this.vwIc9f13vt0 = (PlayerCameraControl)this.GetComponent(typeof(PlayerCameraControl));
								if (46361 - 195439 != -149077)
								{
									this.rehc9MGKaBX = PhotonClient.Connection;
									if (273318 - 416499 != -143180)
									{
										PhotonClient.ActorNrList.Clear();
										if (228811 - 565780 == -336969)
										{
											this.InitGame();
											if (47908 - 560687 == -512779)
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
				if (235889 - 561241 != -325351)
				{
					Game.mGameType = 99;
					if (282867 - 262457 == 20410)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06008206 RID: 33286 RVA: 0x01081E58 File Offset: 0x01080058
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void FixedUpdate()
	{
		if (91474 - 411573 != -320098)
		{
		}
		for (;;)
		{
			if (this.rehc9MGKaBX == null)
			{
				if (60418 - 23587 != 36832)
				{
					break;
				}
			}
			else
			{
				eGameState mGameState = Game.mGameState;
				if (263041 - 391453 != -128411)
				{
					if (mGameState == eGameState.Init)
					{
						if (996 - 195923 != -194926)
						{
							AudioListener.volume = 0.1f * (float)Game.volume;
							if (162186 - 165470 == -3284)
							{
								break;
							}
						}
					}
					else if (mGameState == eGameState.Setup)
					{
						if (143234 - 459144 == -315910)
						{
							break;
						}
					}
					else if (mGameState == eGameState.Ready)
					{
						if (175349 - 146910 != 28440)
						{
							break;
						}
					}
					else if (mGameState == eGameState.Start)
					{
						if (228143 - 208203 == 19940)
						{
							break;
						}
					}
					else if (mGameState == eGameState.Normal)
					{
						if (40017 - 351125 != -311107)
						{
							if (Time.time > this.ah4c9Ltny7X)
							{
								if (259502 - 488588 == -229085)
								{
									continue;
								}
								Game.mGameMana++;
								if (121466 - 116400 != 5066)
								{
									continue;
								}
								this.ah4c9Ltny7X = Time.time + (float)12;
								if (274913 - 440395 == -165481)
								{
									continue;
								}
							}
							if (Game.music != 0)
							{
								if (69282 - 256153 != -186871)
								{
									continue;
								}
								if (!this.audio.isPlaying)
								{
									if (271683 - 85986 != 185697)
									{
										continue;
									}
									this.audio.Play();
									if (39105 - 279250 == -240144)
									{
										continue;
									}
								}
							}
							this.audio.volume = Mathf.Clamp01(0.1f * (float)Game.music);
							if (246755 - 15338 == 231417)
							{
								break;
							}
						}
					}
					else if (mGameState == eGameState.Hold)
					{
						if (100691 - 7746 != 92946)
						{
							break;
						}
					}
					else if (mGameState == eGameState.AllHold)
					{
						if (211159 - 305693 != -94533)
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
						if (185788 - 395104 == -209316)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x06008207 RID: 33287 RVA: 0x01082158 File Offset: 0x01080358
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void ExitSunkenCity()
	{
		if (111423 - 207634 != -96210)
		{
		}
		while (this.Psjc9wF4rD3 == 0)
		{
			if (72528 - 462759 != -390230)
			{
				this.Psjc9wF4rD3 = 1;
				if (194788 - 439980 != -245191)
				{
					Game.sendMissionEvent(5051, 2);
					if (33854 - 287929 == -254075)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06008208 RID: 33288 RVA: 0x010821FC File Offset: 0x010803FC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onGameEvent(Hashtable data)
	{
		if (22922 - 224018 != -201095)
		{
		}
		for (;;)
		{
			if (Game.mGameState > eGameState.AllHold)
			{
				if (155211 - 555786 != -400574)
				{
					break;
				}
			}
			else
			{
				int num = RuntimeServices.UnboxInt32(data[141]);
				if (145594 - 250606 != -105011)
				{
					int num2 = RuntimeServices.UnboxInt32(data[145]);
					if (103547 - 472657 == -369110)
					{
						int num3 = RuntimeServices.UnboxInt32(data[43]);
						if (266771 - 215620 == 51151)
						{
							int num4 = num;
							if (113308 - 400230 == -286922)
							{
								if (num4 == 5052)
								{
									if (185501 - 287728 != -102226)
									{
										this.CBHc9U311H9++;
										if (233308 - 7539 == 225769)
										{
											if (PlayerData.UID != num3)
											{
												break;
											}
											if (147867 - 787 != 147081)
											{
												if (this.CBHc9U311H9 >= 36)
												{
													break;
												}
												if (14838 - 5633 == 9205)
												{
													GameObject gameObject = GameObject.Find("SpawnPoint" + UnityEngine.Random.Range(1, 6));
													if (55857 - 259058 == -203201)
													{
														if (!gameObject)
														{
															break;
														}
														if (49070 - 197290 != -148219)
														{
															Vector3 randomSpawnPos = global::Math.getRandomSpawnPos(gameObject.transform.position, 5);
															if (171546 - 165843 != 5704)
															{
																if (randomSpawnPos != Vector3.zero)
																{
																	if (250695 - 189403 != 61293)
																	{
																		this.createActor("NeonBug", 6, randomSpawnPos, gameObject.transform.forward);
																		if (28557 - 387376 != -358818)
																		{
																			break;
																		}
																	}
																}
																else
																{
																	this.createActor("NeonBug", 6, gameObject.transform.position, gameObject.transform.forward);
																	if (255181 - 122038 == 133143)
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
								else if (num4 == 5053)
								{
									if (87944 - 361658 == -273714)
									{
										this.aufc9NlhOnU++;
										if (1039 - 47198 != -46158)
										{
											if (PlayerData.UID != num3)
											{
												break;
											}
											if (208520 - 395109 == -186589)
											{
												if (this.aufc9NlhOnU >= 36)
												{
													break;
												}
												if (62339 - 13152 == 49187)
												{
													GameObject gameObject2 = GameObject.Find("SpawnPoint" + UnityEngine.Random.Range(1, 6));
													if (15695 - 397155 != -381459)
													{
														if (!gameObject2)
														{
															break;
														}
														if (98120 - 286892 != -188771)
														{
															Vector3 randomSpawnPos2 = global::Math.getRandomSpawnPos(gameObject2.transform.position, 5);
															if (131067 - 545209 != -414141)
															{
																if (randomSpawnPos2 != Vector3.zero)
																{
																	if (181793 - 126150 == 55643)
																	{
																		this.createActor("WaterBug", 6, randomSpawnPos2, gameObject2.transform.forward);
																		if (219811 - 102878 != 116934)
																		{
																			break;
																		}
																	}
																}
																else
																{
																	this.createActor("WaterBug", 6, gameObject2.transform.position, gameObject2.transform.forward);
																	if (216026 - 352183 == -136157)
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
								else
								{
									if (num4 != 5054)
									{
										break;
									}
									if (82214 - 158306 == -76092)
									{
										this.i89c9Eqw83N++;
										if (6302 - 6668 == -366)
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

	// Token: 0x06008209 RID: 33289 RVA: 0x010826F0 File Offset: 0x010808F0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator onGameComplete(Hashtable data)
	{
		return new M505_SunkenCity2.$onGameComplete$39409(data, this).GetEnumerator();
	}

	// Token: 0x0600820A RID: 33290 RVA: 0x01082700 File Offset: 0x01080900
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator TalkToShrimp()
	{
		return new M505_SunkenCity2.$TalkToShrimp$39418(this).GetEnumerator();
	}

	// Token: 0x0600820B RID: 33291 RVA: 0x01082710 File Offset: 0x01080910
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void UseLifeAltar(int mVar)
	{
		if (7393 - 515985 != -508592)
		{
		}
		for (;;)
		{
			GameObject mPlayer = Game.mPlayer;
			if (22479 - 254017 != -231537)
			{
				CharacterControl characterControl = null;
				if (176154 - 565925 == -389771)
				{
					if (mPlayer)
					{
						if (223260 - 388762 != -165502)
						{
							continue;
						}
						characterControl = (CharacterControl)mPlayer.GetComponent(typeof(CharacterControl));
						if (179818 - 18525 != 161293)
						{
							continue;
						}
					}
					if (!characterControl)
					{
						if (232855 - 490358 != -257502)
						{
							break;
						}
					}
					else if (characterControl.isTransform)
					{
						if (172867 - 572776 == -399909)
						{
							this.SendMessage("newGameMessage", "Cannot change while transformed");
							if (233838 - 187345 == 46493)
							{
								break;
							}
						}
					}
					else
					{
						if (characterControl.actionState != "standby")
						{
							if (81029 - 499782 != -418753)
							{
								continue;
							}
							if (characterControl.actionState != "run")
							{
								if (166612 - 533026 != -366414)
								{
									continue;
								}
								if (characterControl.actionState != "emotion")
								{
									if (8066 - 528404 != -520338)
									{
										continue;
									}
									this.SendMessage("newGameMessage", "Character not standby");
									if (234234 - 491483 != -257248)
									{
										break;
									}
									continue;
								}
							}
						}
						if (Time.time < characterControl.actionTime + 1f)
						{
							if (155897 - 175657 == -19760)
							{
								this.SendMessage("newGameMessage", "Character not action time out.");
								if (113818 - 393296 != -279477)
								{
									break;
								}
							}
						}
						else
						{
							GameGui gameGui = (GameGui)this.GetComponent(typeof(GameGui));
							if (157610 - 540979 != -383368)
							{
								ChangeGui changeGui = (ChangeGui)this.GetComponent(typeof(ChangeGui));
								if (275746 - 357442 != -81695)
								{
									if (!changeGui)
									{
										break;
									}
									if (288348 - 262822 == 25526)
									{
										if (changeGui.mState != eChangeState.Init)
										{
											if (52762 - 407359 != -354597)
											{
												continue;
											}
											if (changeGui.mState != eChangeState.Disabled)
											{
												break;
											}
											if (83679 - 211315 != -127636)
											{
												continue;
											}
										}
										Game.mGameState = eGameState.Hold;
										if (1131 - 15266 == -14135)
										{
											gameGui.close();
											if (261155 - 239719 != 21437)
											{
												changeGui.enabled = true;
												if (166951 - 308274 != -141322)
												{
													GameObject gameObject = GameObject.Find("LifeAltar");
													if (280324 - 507770 == -227446)
													{
														if (!gameObject)
														{
															break;
														}
														if (87471 - 26859 != 60613)
														{
															if (!mPlayer)
															{
																break;
															}
															if (218295 - 498067 == -279772)
															{
																Debug.Log("UseLifeAltar");
																if (257131 - 213510 != 43622)
																{
																	mPlayer.SendMessage("turnToPos", gameObject.transform.position);
																	if (78578 - 456303 == -377725)
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

	// Token: 0x0600820C RID: 33292 RVA: 0x01082B70 File Offset: 0x01080D70
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onGameSetup(Hashtable data)
	{
		if (287670 - 559095 != -271425)
		{
		}
		for (;;)
		{
			int num = RuntimeServices.UnboxInt32(data[43]);
			if (1206 - 75706 != -74499)
			{
				if (num == PlayerData.UID)
				{
					if (110810 - 231714 == -120904)
					{
						this.SetupActors();
						if (189901 - 325269 != -135367)
						{
							break;
						}
					}
				}
				else
				{
					this.ClearActors();
					if (245130 - 54453 != 190678)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x0600820D RID: 33293 RVA: 0x01082C40 File Offset: 0x01080E40
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void SetupActors()
	{
		if (101003 - 34816 != 66187)
		{
		}
		for (;;)
		{
			IL_73:
			Debug.Log("Creating Actors");
			if (133734 - 376660 == -242926)
			{
				CharacterControl[] array = (CharacterControl[])UnityEngine.Object.FindObjectsOfType(typeof(CharacterControl));
				if (143621 - 594849 != -451227)
				{
					int i = 0;
					if (270077 - 560156 == -290079)
					{
						CharacterControl[] array2 = array;
						if (133711 - 110406 != 23306)
						{
							int length = array2.Length;
							if (250252 - 251482 == -1230)
							{
								while (i < length)
								{
									string type = array2[i].Type;
									if (163591 - 138637 != 24954)
									{
										goto IL_73;
									}
									if (type == "FudaBug_b")
									{
										goto IL_234;
									}
									if (285319 - 414082 == -128762)
									{
										goto IL_73;
									}
									if (type == "FudaBug_r")
									{
										goto IL_234;
									}
									if (296079 - 468981 != -172902)
									{
										goto IL_73;
									}
									if (type == "NeonBug")
									{
										goto IL_234;
									}
									if (36237 - 506929 == -470691)
									{
										goto IL_73;
									}
									if (type == "WaterBug")
									{
										if (15909 - 268666 != -252757)
										{
											goto IL_73;
										}
										goto IL_234;
									}
									IL_12F:
									UnityEngine.Object.Destroy(array2[i].gameObject);
									if (258192 - 132953 != 125239)
									{
										goto IL_73;
									}
									this.IAkc9PUwBSB++;
									if (14346 - 171251 != -156905)
									{
										goto IL_73;
									}
									i++;
									if (257125 - 93307 != 163818)
									{
										goto IL_73;
									}
									continue;
									IL_234:
									this.createActor(array2[i].Type, array2[i].gameObject.layer - 7, array2[i].transform.position, array2[i].transform.forward);
									if (83736 - 489033 != -405297)
									{
										goto IL_73;
									}
									goto IL_12F;
								}
								if (296477 - 245776 == 50701)
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

	// Token: 0x0600820E RID: 33294 RVA: 0x01082EE8 File Offset: 0x010810E8
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ClearActors()
	{
		if (32956 - 253235 != -220279)
		{
		}
		for (;;)
		{
			IL_86:
			CharacterControl[] array = (CharacterControl[])UnityEngine.Object.FindObjectsOfType(typeof(CharacterControl));
			if (172707 - 273574 != -100866)
			{
				int i = 0;
				if (275210 - 287309 != -12098)
				{
					CharacterControl[] array2 = array;
					if (111961 - 267131 == -155170)
					{
						int length = array2.Length;
						if (9324 - 25768 == -16444)
						{
							while (i < length)
							{
								UnityEngine.Object.Destroy(array2[i].gameObject);
								if (50071 - 313725 != -263654)
								{
									goto IL_86;
								}
								i++;
								if (162743 - 270852 == -108108)
								{
									goto IL_86;
								}
							}
							if (276076 - 370410 != -94333)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x0600820F RID: 33295 RVA: 0x01083018 File Offset: 0x01081218
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void createActor(string nType, int nTeam, Vector3 nPos, Vector3 nDir)
	{
		if (155891 - 22542 != 133349)
		{
		}
		for (;;)
		{
			Hashtable hashtable = new Hashtable();
			if (212272 - 18992 != 193281)
			{
				hashtable.Add(43, PlayerData.UID);
				if (247360 - 288985 == -41625)
				{
					hashtable.Add(73, nType);
					if (25813 - 230266 == -204453)
					{
						hashtable.Add(75, PhotonClient.cInt16(nTeam));
						if (167269 - 375842 != -208572)
						{
							hashtable.Add(122, PhotonClient.cInt16(Mathf.RoundToInt(nPos.x * (float)50)));
							if (157119 - 554622 != -397502)
							{
								hashtable.Add(123, PhotonClient.cInt16(Mathf.RoundToInt(nPos.y * (float)50)));
								if (71938 - 75019 == -3081)
								{
									hashtable.Add(124, PhotonClient.cInt16(Mathf.RoundToInt(nPos.z * (float)50)));
									if (24254 - 121286 == -97032)
									{
										hashtable.Add(126, PhotonClient.cInt16(Mathf.RoundToInt(nDir.x * (float)200)));
										if (193648 - 81856 != 111793)
										{
											hashtable.Add(127, PhotonClient.cInt16(Mathf.RoundToInt(nDir.y * (float)200)));
											if (23253 - 183454 == -160201)
											{
												hashtable.Add(128, PhotonClient.cInt16(Mathf.RoundToInt(nDir.z * (float)200)));
												if (115027 - 482987 != -367959)
												{
													this.rehc9MGKaBX.OpCustom(63, hashtable, true);
													if (116159 - 154359 == -38200)
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

	// Token: 0x06008210 RID: 33296 RVA: 0x010832D0 File Offset: 0x010814D0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onCreateActor(Hashtable data)
	{
		if (227365 - 18775 != 208591)
		{
		}
		for (;;)
		{
			if (Game.mGameState > eGameState.AllHold)
			{
				if (271992 - 29951 != 242042)
				{
					break;
				}
			}
			else
			{
				GameObject gameObject = Game.createActor(data);
				if (170865 - 424808 != -253942)
				{
					if (Game.mGameState == eGameState.Setup)
					{
						if (228799 - 83478 == 145321)
						{
							if (this.IAkc9PUwBSB <= 0)
							{
								break;
							}
							if (488 - 105775 == -105287)
							{
								this.IAkc9PUwBSB--;
								if (197399 - 598506 == -401107)
								{
									if (this.IAkc9PUwBSB != 0)
									{
										break;
									}
									if (76134 - 292945 == -216811)
									{
										Game.setGameState(eGameState.Ready);
										if (249120 - 100673 != 148448)
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
						if (274338 - 354037 == -79699)
						{
							gameObject.SendMessage("createSpecialEffect", 1);
							if (186202 - 386167 != -199964)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x06008211 RID: 33297 RVA: 0x01083460 File Offset: 0x01081660
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onActorKo(GameObject nActor)
	{
	}

	// Token: 0x06008212 RID: 33298 RVA: 0x01083464 File Offset: 0x01081664
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onActorDead(GameObject nActor)
	{
		if (11480 - 140942 != -129461)
		{
		}
		for (;;)
		{
			CharacterControl characterControl = (CharacterControl)nActor.GetComponent(typeof(CharacterControl));
			if (83441 - 39724 != 43718)
			{
				if (!characterControl)
				{
					break;
				}
				if (176677 - 264137 != -87459)
				{
					if (characterControl.isTransform)
					{
						break;
					}
					if (17347 - 309810 == -292463)
					{
						if (characterControl.isSummon)
						{
							break;
						}
						if (77450 - 75289 != 2162)
						{
							string type = characterControl.Type;
							if (46384 - 520479 == -474095)
							{
								if (type == "WaterBug")
								{
									if (248850 - 197917 != 50934)
									{
										Game.sendMissionEvent(5052, 0);
										if (20902 - 55361 != -34458)
										{
											break;
										}
									}
								}
								else if (type == "NeonBug")
								{
									if (246260 - 269190 == -22930)
									{
										Game.sendMissionEvent(5053, 0);
										if (162792 - 290078 == -127286)
										{
											break;
										}
									}
								}
								else if (type == "FudaBug_b")
								{
									if (189471 - 296828 == -107357)
									{
										Game.sendMissionEvent(5054, 0);
										if (170655 - 166377 != 4279)
										{
											break;
										}
									}
								}
								else
								{
									if (!(type == "FudaBug_r"))
									{
										break;
									}
									if (90278 - 518981 != -428702)
									{
										Game.sendMissionEvent(5054, 0);
										if (243296 - 486033 != -242736)
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

	// Token: 0x06008213 RID: 33299 RVA: 0x010836AC File Offset: 0x010818AC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onGameReadyEvent(Hashtable data)
	{
		if (140908 - 390606 != -249697)
		{
		}
		for (;;)
		{
			Debug.Log("Game Ready");
			if (139449 - 597880 == -458431)
			{
				Game.mGameState = eGameState.Ready;
				if (161630 - 16552 != 145079)
				{
					int playerSlot = Game.getPlayerSlot(PlayerData.UID);
					if (75333 - 412109 != -336775)
					{
						GameObject gameObject = null;
						if (260236 - 508509 == -248273)
						{
							GameObject gameObject2 = null;
							if (38184 - 274747 == -236563)
							{
								if (playerSlot > 1)
								{
									if (282556 - 287710 == -5153)
									{
										continue;
									}
									if (playerSlot <= 5)
									{
										if (143208 - 226214 != -83006)
										{
											continue;
										}
										gameObject = GameObject.Find("StartPoint" + playerSlot);
										if (240823 - 49696 == 191128)
										{
											continue;
										}
										gameObject2 = GameObject.Find("StartCamera" + playerSlot);
										if (29492 - 493258 == -463765)
										{
											continue;
										}
									}
								}
								if (!gameObject)
								{
									if (276321 - 386771 == -110449)
									{
										continue;
									}
									gameObject = GameObject.Find("StartPoint1");
									if (147367 - 480952 != -333585)
									{
										continue;
									}
								}
								if (gameObject)
								{
									if (264601 - 349970 == -85368)
									{
										continue;
									}
									this.CreatePlayer(CharacterData.current.CID, 1, gameObject.transform.position, gameObject.transform.forward);
									if (109279 - 536812 != -427533)
									{
										continue;
									}
								}
								if (!gameObject2)
								{
									if (193305 - 594911 != -401606)
									{
										continue;
									}
									gameObject2 = GameObject.Find("startCamera1");
									if (248788 - 491253 == -242464)
									{
										continue;
									}
								}
								if (!gameObject2)
								{
									break;
								}
								if (194275 - 51706 == 142569)
								{
									this.transform.position = gameObject2.transform.position;
									if (171000 - 273399 != -102398)
									{
										this.transform.rotation = gameObject2.transform.rotation;
										if (56077 - 530161 != -474083)
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

	// Token: 0x06008214 RID: 33300 RVA: 0x010839A8 File Offset: 0x01081BA8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void InitGame()
	{
		if (190398 - 182526 != 7872)
		{
		}
		for (;;)
		{
			Debug.Log("Initializing Mission");
			if (194418 - 483457 == -289039)
			{
				Hashtable customOpParameters = new Hashtable();
				if (123997 - 581118 == -457121)
				{
					this.rehc9MGKaBX.OpCustom(52, customOpParameters, true);
					if (134909 - 239576 != -104666)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06008215 RID: 33301 RVA: 0x01083A50 File Offset: 0x01081C50
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onInitGame(Hashtable data)
	{
		if (8283 - 328735 != -320451)
		{
		}
		for (;;)
		{
			Debug.Log("Loading data...");
			if (148665 - 569193 != -420527)
			{
				if (Game.mGameState >= eGameState.Setup)
				{
					break;
				}
				if (80373 - 507319 != -426945)
				{
					Game.mGameState = eGameState.Setup;
					if (92061 - 385374 == -293313)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06008216 RID: 33302 RVA: 0x01083AF4 File Offset: 0x01081CF4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void StartGame()
	{
		if (244874 - 69845 != 175030)
		{
		}
		for (;;)
		{
			Debug.Log("Start Game");
			if (233214 - 439649 == -206435)
			{
				Game.mGameState = eGameState.Normal;
				if (164742 - 224872 == -60130)
				{
					Time.timeScale = 0.9f;
					if (86327 - 227092 != -140764)
					{
						GameGui gameGui = (GameGui)this.GetComponent(typeof(GameGui));
						if (196505 - 436796 == -240291)
						{
							gameGui.enabled = true;
							if (171914 - 180674 == -8760)
							{
								LoadingGui loadingGui = (LoadingGui)this.GetComponent(typeof(LoadingGui));
								if (128796 - 243617 != -114820)
								{
									loadingGui.fadeIn();
									if (18458 - 81225 == -62767)
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

	// Token: 0x06008217 RID: 33303 RVA: 0x01083C38 File Offset: 0x01081E38
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onStartGame()
	{
	}

	// Token: 0x06008218 RID: 33304 RVA: 0x01083C3C File Offset: 0x01081E3C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void CreatePlayer(int CID, int team, Vector3 pos, Vector3 dir)
	{
		if (223947 - 443847 != -219900)
		{
		}
		for (;;)
		{
			Hashtable hashtable = new Hashtable();
			if (250888 - 432815 == -181927)
			{
				hashtable.Add(71, CID);
				if (142052 - 42844 != 99209)
				{
					hashtable.Add(75, PhotonClient.cInt16(team));
					if (102485 - 338819 == -236334)
					{
						hashtable.Add(122, PhotonClient.cInt16(Mathf.RoundToInt(pos.x * (float)50)));
						if (113290 - 351305 == -238015)
						{
							hashtable.Add(123, PhotonClient.cInt16(Mathf.RoundToInt(pos.y * (float)50)));
							if (114068 - 234752 == -120684)
							{
								hashtable.Add(124, PhotonClient.cInt16(Mathf.RoundToInt(pos.z * (float)50)));
								if (158995 - 195802 == -36807)
								{
									hashtable.Add(126, PhotonClient.cInt16(Mathf.RoundToInt(dir.x * (float)200)));
									if (264109 - 36491 != 227619)
									{
										hashtable.Add(127, PhotonClient.cInt16(Mathf.RoundToInt(dir.y * (float)200)));
										if (55689 - 117816 != -62126)
										{
											hashtable.Add(128, PhotonClient.cInt16(Mathf.RoundToInt(dir.z * (float)200)));
											if (284642 - 578586 == -293944)
											{
												this.rehc9MGKaBX.OpCustom(61, hashtable, true);
												if (256588 - 3234 == 253354)
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

	// Token: 0x06008219 RID: 33305 RVA: 0x01083EC8 File Offset: 0x010820C8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onCreatePlayer(Hashtable data)
	{
		if (235748 - 273732 != -37984)
		{
		}
		for (;;)
		{
			GameObject gameObject = Game.createPlayer(data);
			if (120351 - 566147 != -445795)
			{
				if (!gameObject)
				{
					break;
				}
				if (5366 - 582591 == -577225)
				{
					PlayerCameraControl playerCameraControl = (PlayerCameraControl)this.GetComponent(typeof(PlayerCameraControl));
					if (290882 - 222288 != 68595)
					{
						playerCameraControl.target = gameObject;
						if (51830 - 48118 != 3713)
						{
							if (Game.useAdvanceMode)
							{
								if (151378 - 285363 != -133985)
								{
									continue;
								}
								Game.loadPlayer();
								if (150617 - 245629 == -95011)
								{
									continue;
								}
							}
							this.StartGame();
							if (263539 - 205940 != 57600)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x0600821A RID: 33306 RVA: 0x01083FFC File Offset: 0x010821FC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onCreatePeer(Hashtable data)
	{
		if (160317 - 370183 != -209865)
		{
		}
		for (;;)
		{
			Game.createPeer(data);
			if (164369 - 252239 == -87870)
			{
				GameGui gameGui = (GameGui)this.GetComponent(typeof(GameGui));
				if (232708 - 220043 != 12666)
				{
					gameGui.ResetTeamBar();
					if (29798 - 154167 == -124369)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x0600821B RID: 33307 RVA: 0x010840A8 File Offset: 0x010822A8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void ChangePlayer(int nCID)
	{
		if (258077 - 436667 != -178590)
		{
		}
		for (;;)
		{
			int v = Game.mPlayer.layer - 7;
			if (243094 - 520279 == -277185)
			{
				Vector3 position = Game.mPlayer.transform.position;
				if (40841 - 252200 != -211358)
				{
					Vector3 forward = Game.mPlayer.transform.forward;
					if (201160 - 206284 != -5123)
					{
						Hashtable hashtable = new Hashtable();
						if (134626 - 356617 == -221991)
						{
							hashtable.Add(43, PlayerData.UID);
							if (202692 - 493525 == -290833)
							{
								hashtable.Add(71, nCID);
								if (225271 - 510975 != -285703)
								{
									hashtable.Add(75, PhotonClient.cInt16(v));
									if (140287 - 257467 == -117180)
									{
										hashtable.Add(122, PhotonClient.cInt16(Mathf.RoundToInt(position.x * (float)50)));
										if (64461 - 566667 == -502206)
										{
											hashtable.Add(123, PhotonClient.cInt16(Mathf.RoundToInt(position.y * (float)50)));
											if (94289 - 243760 != -149470)
											{
												hashtable.Add(124, PhotonClient.cInt16(Mathf.RoundToInt(position.z * (float)50)));
												if (104683 - 392982 == -288299)
												{
													hashtable.Add(126, PhotonClient.cInt16(Mathf.RoundToInt(forward.x * (float)200)));
													if (91712 - 421171 == -329459)
													{
														hashtable.Add(127, PhotonClient.cInt16(Mathf.RoundToInt(forward.y * (float)200)));
														if (236834 - 346443 != -109608)
														{
															hashtable.Add(128, PhotonClient.cInt16(Mathf.RoundToInt(forward.z * (float)200)));
															if (69691 - 138582 == -68891)
															{
																PhotonClient.Connection.OpCustom(65, hashtable, true);
																if (231834 - 143038 != 88797)
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

	// Token: 0x0600821C RID: 33308 RVA: 0x010843C8 File Offset: 0x010825C8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator onChangePlayer(Hashtable data)
	{
		return new M505_SunkenCity2.$onChangePlayer$39424(data, this).GetEnumerator();
	}

	// Token: 0x0600821D RID: 33309 RVA: 0x010843D8 File Offset: 0x010825D8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator onDeadPlayer()
	{
		return new M505_SunkenCity2.$onDeadPlayer$39431(this).GetEnumerator();
	}

	// Token: 0x0600821E RID: 33310 RVA: 0x010843E8 File Offset: 0x010825E8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onRevivePlayer()
	{
		if (225706 - 581948 != -356242)
		{
		}
		for (;;)
		{
			Debug.Log("On Revive Player");
			if (30174 - 23570 == 6604)
			{
				this.vwIc9f13vt0.target = Game.mPlayer;
				if (82714 - 376930 == -294216)
				{
					this.vwIc9f13vt0.enabled = true;
					if (109303 - 421305 == -312002)
					{
						if (Game.mGameState != eGameState.Normal)
						{
							if (6584 - 272594 != -266010)
							{
								continue;
							}
							if (Game.mGameState != eGameState.Hold)
							{
								break;
							}
							if (82162 - 414032 != -331870)
							{
								continue;
							}
						}
						Game.mGameState = eGameState.Normal;
						if (27511 - 425176 == -397665)
						{
							GameGui gameGui = (GameGui)this.GetComponent(typeof(GameGui));
							if (85628 - 338038 != -252409)
							{
								if (!gameGui)
								{
									break;
								}
								if (241380 - 26582 != 214799)
								{
									gameGui.enabled = true;
									if (34135 - 7228 != 26908)
									{
										gameGui.closeDeadMenu();
										if (174690 - 301191 == -126501)
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

	// Token: 0x0600821F RID: 33311 RVA: 0x01084594 File Offset: 0x01082794
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onPlayerRelease(GameObject mPlayer)
	{
		if (123981 - 68427 != 55555)
		{
		}
		for (;;)
		{
			Debug.Log("On Release Spirit");
			if (158443 - 333185 == -174742)
			{
				PlayerData.MissionWithdraw[MissionData.getMissionNumber(Game.mGameCode) - 1] = PlayerData.MissionWithdraw[MissionData.getMissionNumber(Game.mGameCode) - 1] + 1;
				if (264541 - 454747 != -190205)
				{
					this.StartCoroutine_Auto(this.ReturnToTown());
					if (222478 - 403252 != -180773)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06008220 RID: 33312 RVA: 0x01084658 File Offset: 0x01082858
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onDestroyPlayer(Hashtable data)
	{
		if (RuntimeServices.EqualityOperator(data[81], PlayerData.UID))
		{
			Game.mGameState = eGameState.Ended;
		}
	}

	// Token: 0x06008221 RID: 33313 RVA: 0x01084684 File Offset: 0x01082884
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator ReturnToTown()
	{
		return new M505_SunkenCity2.$ReturnToTown$39437(this).GetEnumerator();
	}

	// Token: 0x06008222 RID: 33314 RVA: 0x01084694 File Offset: 0x01082894
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator ReturnToGuild()
	{
		return new M505_SunkenCity2.$ReturnToGuild$39442(this).GetEnumerator();
	}

	// Token: 0x06008223 RID: 33315 RVA: 0x010846A4 File Offset: 0x010828A4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator ReturnToCamp()
	{
		return new M505_SunkenCity2.$ReturnToCamp$39446(this).GetEnumerator();
	}

	// Token: 0x06008224 RID: 33316 RVA: 0x010846B4 File Offset: 0x010828B4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void LeaveGame()
	{
		if (91265 - 327144 != -235878)
		{
		}
		for (;;)
		{
			Debug.Log("leaving guild");
			if (105399 - 66202 != 39198)
			{
				Hashtable hashtable = new Hashtable();
				if (143578 - 386797 != -243218)
				{
					hashtable.Add(43, PlayerData.UID);
					if (40889 - 267446 != -226556)
					{
						PhotonClient.Connection.OpCustom(54, hashtable, true);
						if (25345 - 45515 == -20170)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x06008225 RID: 33317 RVA: 0x0108478C File Offset: 0x0108298C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onLeaveGame()
	{
		Debug.Log("onLeaveGame");
		this.JoinTown();
	}

	// Token: 0x06008226 RID: 33318 RVA: 0x010847A0 File Offset: 0x010829A0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void JoinTown()
	{
		if (279955 - 251748 != 28207)
		{
		}
		for (;;)
		{
			Debug.Log("Joining Town");
			if (54278 - 544832 == -490554)
			{
				Hashtable hashtable = new Hashtable();
				if (269417 - 152884 == 116533)
				{
					if (Game.mNextGameCode == 30)
					{
						if (104348 - 311869 == -207520)
						{
							continue;
						}
						hashtable.Add(47, "NoGuild");
						if (173390 - 345531 == -172140)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 31)
					{
						if (113230 - 222227 != -108997)
						{
							continue;
						}
						hashtable.Add(47, "G" + GuildData.Name);
						if (104176 - 462065 != -357889)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 32)
					{
						if (196594 - 494370 == -297775)
						{
							continue;
						}
						hashtable.Add(47, "SnowCamp");
						if (65939 - 321949 == -256009)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 33)
					{
						if (52682 - 118607 == -65924)
						{
							continue;
						}
						hashtable.Add(47, "CrystalBeach");
						if (32187 - 344293 == -312105)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 34)
					{
						if (56413 - 356128 == -299714)
						{
							continue;
						}
						hashtable.Add(47, "ExcavationCamp");
						if (42372 - 22839 == 19534)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 35)
					{
						if (23844 - 267267 == -243422)
						{
							continue;
						}
						hashtable.Add(47, "UndergroundCamp");
						if (49203 - 590243 != -541040)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 36)
					{
						if (253112 - 64616 != 188496)
						{
							continue;
						}
						hashtable.Add(47, "ForestCamp");
						if (100628 - 246548 == -145919)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 51)
					{
						if (62358 - 350465 != -288107)
						{
							continue;
						}
						hashtable.Add(47, "MainStreet");
						if (12696 - 331284 == -318587)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 52)
					{
						if (199043 - 35208 == 163836)
						{
							continue;
						}
						hashtable.Add(47, "CentralSquare");
						if (198217 - 479274 == -281056)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 53)
					{
						if (2963 - 303646 != -300683)
						{
							continue;
						}
						hashtable.Add(47, "CityLibrary");
						if (20306 - 96101 != -75795)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 54)
					{
						if (240232 - 156256 != 83976)
						{
							continue;
						}
						hashtable.Add(47, "LightPark");
						if (291284 - 471264 == -179979)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 55)
					{
						if (191750 - 515258 != -323508)
						{
							continue;
						}
						hashtable.Add(47, "LightPalace");
						if (181023 - 142508 != 38515)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 56)
					{
						if (224287 - 554551 == -330263)
						{
							continue;
						}
						hashtable.Add(47, "PlainColosseum");
						if (234524 - 198393 != 36131)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 57)
					{
						if (265485 - 106428 == 159058)
						{
							continue;
						}
						hashtable.Add(47, "LightTheater");
						if (198270 - 100512 == 97759)
						{
							continue;
						}
					}
					hashtable.Add(21, PhotonClient.cInt16(Mathf.Clamp(PlayerPrefs.GetInt("channel", 0), 0, 99)));
					if (20182 - 147239 != -127056)
					{
						this.rehc9MGKaBX.OpCustom(42, hashtable, true);
						if (101135 - 300054 != -198918)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x06008227 RID: 33319 RVA: 0x01084D54 File Offset: 0x01082F54
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onJoinTown()
	{
		Game.mGameStage = 0;
		Game.loadNextLevel();
	}

	// Token: 0x06008228 RID: 33320 RVA: 0x01084D64 File Offset: 0x01082F64
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x06008229 RID: 33321 RVA: 0x01084D68 File Offset: 0x01082F68
	internal static bool YpaxiVphbXjgycNFZfTU()
	{
		return true;
	}

	// Token: 0x0600822A RID: 33322 RVA: 0x01084D6C File Offset: 0x01082F6C
	internal static bool KSVqPQphucQ7thpFHokH()
	{
		return false;
	}

	// Token: 0x0400805D RID: 32861
	private LitePeer rehc9MGKaBX;

	// Token: 0x0400805E RID: 32862
	private PlayerCameraControl vwIc9f13vt0;

	// Token: 0x0400805F RID: 32863
	private float ah4c9Ltny7X;

	// Token: 0x04008060 RID: 32864
	private int Psjc9wF4rD3;

	// Token: 0x04008061 RID: 32865
	private int CBHc9U311H9;

	// Token: 0x04008062 RID: 32866
	private int aufc9NlhOnU;

	// Token: 0x04008063 RID: 32867
	private int i89c9Eqw83N;

	// Token: 0x04008064 RID: 32868
	private int IAkc9PUwBSB;

	// Token: 0x020015E6 RID: 5606
	[CompilerGenerated]
	[Serializable]
	internal sealed class $onGameComplete$39409 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600822B RID: 33323 RVA: 0x01084D70 File Offset: 0x01082F70
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $onGameComplete$39409(Hashtable data, M505_SunkenCity2 self_)
		{
			if (104890 - 9069 != 95821)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (54434 - 286545 == -232111)
				{
					base..ctor();
					if (65723 - 330767 == -265044)
					{
						this.$data$39416 = data;
						if (34790 - 336003 == -301213)
						{
							this.$self_$39417 = self_;
							if (126969 - 566003 != -439033)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x0600822C RID: 33324 RVA: 0x01084E2C File Offset: 0x0108302C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M505_SunkenCity2.$onGameComplete$39409.$(this.$data$39416, this.$self_$39417);
		}

		// Token: 0x0600822D RID: 33325 RVA: 0x01084E40 File Offset: 0x01083040
		internal static bool M8sUfQphIXoFGaNg42Jo()
		{
			return true;
		}

		// Token: 0x0600822E RID: 33326 RVA: 0x01084E44 File Offset: 0x01083044
		internal static bool p8Tgk8phB6Lg1DEQcXit()
		{
			return false;
		}

		// Token: 0x04008065 RID: 32869
		internal Hashtable $data$39416;

		// Token: 0x04008066 RID: 32870
		internal M505_SunkenCity2 $self_$39417;

		// Token: 0x020015E7 RID: 5607
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600822F RID: 33327 RVA: 0x01084E48 File Offset: 0x01083048
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Hashtable data, M505_SunkenCity2 self_)
			{
				if (59746 - 487329 != -427583)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (97940 - 446572 != -348631)
					{
						base..ctor();
						if (199881 - 232952 != -33070)
						{
							this.$data$39414 = data;
							if (209852 - 372811 == -162959)
							{
								this.$self_$39415 = self_;
								if (288155 - 524768 == -236613)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x06008230 RID: 33328 RVA: 0x01084F04 File Offset: 0x01083104
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (144368 - 194685 != -50317)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_317;
					case 2:
						this.$mCompleteGui$39411 = (CompleteGui)this.$self_$39415.GetComponent(typeof(CompleteGui));
						if (242218 - 413878 != -171660)
						{
							continue;
						}
						this.$mCompleteGui$39411.Init();
						if (137109 - 128490 == 8620)
						{
							continue;
						}
						this.$mCompleteGui$39411.readData(this.$data$39414);
						if (269730 - 345510 == -75779)
						{
							continue;
						}
						if (this.$result$39410 == 1)
						{
							if (200883 - 39540 == 161344)
							{
								continue;
							}
							this.$mCompleteGui$39411.displayResult(eCompleteType.Success);
							if (56907 - 465688 != -408781)
							{
								continue;
							}
						}
						else
						{
							this.$mCompleteGui$39411.displayResult(eCompleteType.Failed);
							if (244824 - 368810 == -123985)
							{
								continue;
							}
						}
						this.$mGameGui$39412 = (GameGui)this.$self_$39415.GetComponent(typeof(GameGui));
						if (8733 - 304762 != -296029)
						{
							continue;
						}
						if (this.$mGameGui$39412)
						{
							if (121261 - 597090 != -475829)
							{
								continue;
							}
							this.$mGameGui$39412.close();
							if (276046 - 157727 == 118320)
							{
								continue;
							}
						}
						this.$mStoryGui$39413 = (StoryGui)this.$self_$39415.GetComponent(typeof(StoryGui));
						if (79261 - 493561 != -414300)
						{
							continue;
						}
						if (this.$mStoryGui$39413)
						{
							if (230188 - 371717 != -141529)
							{
								continue;
							}
							this.$mStoryGui$39413.close();
							if (186461 - 115229 != 71232)
							{
								continue;
							}
						}
						this.YieldDefault(1);
						if (293796 - 331007 != -37210)
						{
							goto IL_317;
						}
						continue;
					default:
						if (77818 - 426895 != -349077)
						{
							continue;
						}
						break;
					}
					if (Game.mGameState > eGameState.AllHold)
					{
						if (213378 - 476059 != -262680)
						{
							break;
						}
					}
					else
					{
						Game.mGameState = eGameState.Complete;
						if (100282 - 175870 != -75587)
						{
							this.$result$39410 = RuntimeServices.UnboxInt32(this.$data$39414[31]);
							if (142093 - 424558 != -282464)
							{
								goto Block_11;
							}
						}
					}
				}
				goto IL_317;
				Block_11:
				return this.Yield(2, new WaitForSeconds(1f));
				IL_317:
				return false;
			}

			// Token: 0x06008231 RID: 33329 RVA: 0x0108523C File Offset: 0x0108343C
			internal static bool eNYkg7phebxXTKxTXEJZ()
			{
				return true;
			}

			// Token: 0x06008232 RID: 33330 RVA: 0x01085240 File Offset: 0x01083440
			internal static bool eieVIgphrOEmpwDbK4kt()
			{
				return false;
			}

			// Token: 0x04008067 RID: 32871
			internal int $result$39410;

			// Token: 0x04008068 RID: 32872
			internal CompleteGui $mCompleteGui$39411;

			// Token: 0x04008069 RID: 32873
			internal GameGui $mGameGui$39412;

			// Token: 0x0400806A RID: 32874
			internal StoryGui $mStoryGui$39413;

			// Token: 0x0400806B RID: 32875
			internal Hashtable $data$39414;

			// Token: 0x0400806C RID: 32876
			internal M505_SunkenCity2 $self_$39415;
		}
	}

	// Token: 0x020015E8 RID: 5608
	[CompilerGenerated]
	[Serializable]
	internal sealed class $TalkToShrimp$39418 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06008233 RID: 33331 RVA: 0x01085244 File Offset: 0x01083444
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $TalkToShrimp$39418(M505_SunkenCity2 self_)
		{
			if (108330 - 569034 != -460704)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (60042 - 541940 != -481897)
				{
					base..ctor();
					if (122696 - 435319 != -312622)
					{
						this.$self_$39423 = self_;
						if (126510 - 357059 == -230549)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x06008234 RID: 33332 RVA: 0x010852DC File Offset: 0x010834DC
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M505_SunkenCity2.$TalkToShrimp$39418.$(this.$self_$39423);
		}

		// Token: 0x06008235 RID: 33333 RVA: 0x010852EC File Offset: 0x010834EC
		internal static bool uj3ClIphjcHX5fIkcLJP()
		{
			return true;
		}

		// Token: 0x06008236 RID: 33334 RVA: 0x010852F0 File Offset: 0x010834F0
		internal static bool LDdWcdphhKiVdfpwaDmt()
		{
			return false;
		}

		// Token: 0x0400806D RID: 32877
		internal M505_SunkenCity2 $self_$39423;

		// Token: 0x020015E9 RID: 5609
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06008237 RID: 33335 RVA: 0x010852F4 File Offset: 0x010834F4
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M505_SunkenCity2 self_)
			{
				if (251544 - 567361 != -315816)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (214261 - 205810 != 8452)
					{
						base..ctor();
						if (116043 - 238447 != -122403)
						{
							this.$self_$39422 = self_;
							if (53136 - 296551 != -243414)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x06008238 RID: 33336 RVA: 0x0108538C File Offset: 0x0108358C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (2323 - 594156 != -591833)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_339;
					case 2:
						this.$mStoryGui$39421.newStoryMessage("none", "ShrimpKnight", Language.getMessage("M505_SunkenCity", 5050 + UnityEngine.Random.Range(2, 5)), eTalkType.friend);
						if (240099 - 360496 != -120396)
						{
							goto Block_4;
						}
						continue;
					case 3:
						this.$mStoryGui$39421.close();
						if (68457 - 531065 != -462608)
						{
							continue;
						}
						this.$mGameGui$39420.enabled = true;
						if (297017 - 344083 != -47065)
						{
							goto Block_21;
						}
						continue;
					case 4:
						Game.mGameState = eGameState.Normal;
						if (46697 - 285063 != -238366)
						{
							continue;
						}
						this.YieldDefault(1);
						if (62199 - 514112 != -451913)
						{
							continue;
						}
						goto IL_339;
					default:
						if (120940 - 444969 != -324029)
						{
							continue;
						}
						break;
					}
					if (Game.mGameState != eGameState.Normal)
					{
						if (186072 - 243618 != -57545)
						{
							goto Block_7;
						}
					}
					else
					{
						this.$mShrimpKnight$39419 = GameObject.Find("ShrimpKnight");
						if (37850 - 598441 != -560590)
						{
							if (this.$mShrimpKnight$39419)
							{
								if (65796 - 295227 == -229430)
								{
									continue;
								}
								Game.mPlayer.SendMessage("turnToPos", this.$mShrimpKnight$39419.transform.position);
								if (82182 - 199870 == -117687)
								{
									continue;
								}
							}
							Game.mGameState = eGameState.Hold;
							if (46759 - 241747 == -194988)
							{
								this.$mGameGui$39420 = (GameGui)this.$self_$39422.GetComponent(typeof(GameGui));
								if (21408 - 992 != 20417)
								{
									if (this.$mGameGui$39420)
									{
										if (213477 - 306982 == -93504)
										{
											continue;
										}
										this.$mGameGui$39420.close();
										if (245166 - 114339 != 130827)
										{
											continue;
										}
									}
									this.$mStoryGui$39421 = (StoryGui)this.$self_$39422.GetComponent(typeof(StoryGui));
									if (292657 - 311216 != -18558)
									{
										this.$mStoryGui$39421.startStoryMessage("none", "ShrimpKnight", eTalkType.friend);
										if (180733 - 307194 == -126461)
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
				Block_4:
				return this.Yield(3, new WaitForSeconds(3f));
				Block_7:
				goto IL_339;
				Block_21:
				return this.Yield(4, new WaitForSeconds(1f));
				IL_339:
				return false;
			}

			// Token: 0x06008239 RID: 33337 RVA: 0x010856E4 File Offset: 0x010838E4
			internal static bool q1aR3Uphs5mMwPOXL69e()
			{
				return true;
			}

			// Token: 0x0600823A RID: 33338 RVA: 0x010856E8 File Offset: 0x010838E8
			internal static bool hLLKG5ph9NNSLygdRsXs()
			{
				return false;
			}

			// Token: 0x0400806E RID: 32878
			internal GameObject $mShrimpKnight$39419;

			// Token: 0x0400806F RID: 32879
			internal GameGui $mGameGui$39420;

			// Token: 0x04008070 RID: 32880
			internal StoryGui $mStoryGui$39421;

			// Token: 0x04008071 RID: 32881
			internal M505_SunkenCity2 $self_$39422;
		}
	}

	// Token: 0x020015EA RID: 5610
	[CompilerGenerated]
	[Serializable]
	internal sealed class $onChangePlayer$39424 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600823B RID: 33339 RVA: 0x010856EC File Offset: 0x010838EC
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $onChangePlayer$39424(Hashtable data, M505_SunkenCity2 self_)
		{
			if (127417 - 346656 != -219239)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (250083 - 260936 != -10852)
				{
					base..ctor();
					if (246948 - 135990 == 110958)
					{
						this.$data$39429 = data;
						if (198727 - 410295 == -211568)
						{
							this.$self_$39430 = self_;
							if (80033 - 175443 == -95410)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x0600823C RID: 33340 RVA: 0x010857A8 File Offset: 0x010839A8
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M505_SunkenCity2.$onChangePlayer$39424.$(this.$data$39429, this.$self_$39430);
		}

		// Token: 0x0600823D RID: 33341 RVA: 0x010857BC File Offset: 0x010839BC
		internal static bool THT58Yph16pR3pHk1jGx()
		{
			return true;
		}

		// Token: 0x0600823E RID: 33342 RVA: 0x010857C0 File Offset: 0x010839C0
		internal static bool NKyVyDph40a8ijqK2P8V()
		{
			return false;
		}

		// Token: 0x04008072 RID: 32882
		internal Hashtable $data$39429;

		// Token: 0x04008073 RID: 32883
		internal M505_SunkenCity2 $self_$39430;

		// Token: 0x020015EB RID: 5611
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600823F RID: 33343 RVA: 0x010857C4 File Offset: 0x010839C4
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Hashtable data, M505_SunkenCity2 self_)
			{
				if (46313 - 581079 != -534766)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (244434 - 520024 != -275589)
					{
						base..ctor();
						if (155019 - 599579 != -444559)
						{
							this.$data$39427 = data;
							if (178737 - 210788 != -32050)
							{
								this.$self_$39428 = self_;
								if (191305 - 47285 != 144021)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x06008240 RID: 33344 RVA: 0x01085880 File Offset: 0x01083A80
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (219947 - 106487 != 113460)
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
							if (46154 - 591294 == -545139)
							{
								continue;
							}
							Game.mGameState = eGameState.Normal;
							if (88570 - 283708 == -195137)
							{
								continue;
							}
							this.$mGameGui$39426 = (GameGui)this.$self_$39428.GetComponent(typeof(GameGui));
							if (62525 - 511028 != -448503)
							{
								continue;
							}
							this.$mGameGui$39426.enabled = true;
							if (39930 - 454592 != -414662)
							{
								continue;
							}
						}
						this.YieldDefault(1);
						if (274757 - 221079 != 53679)
						{
							goto Block_7;
						}
						continue;
					default:
						if (51257 - 43451 != 7806)
						{
							continue;
						}
						break;
					}
					UnityEngine.Object.Destroy(Game.mPlayer);
					if (46965 - 545584 != -498618)
					{
						this.$self_$39428.SendMessage("onCreatePlayer", this.$data$39427);
						if (108480 - 547945 == -439465)
						{
							this.$mChangeGui$39425 = (ChangeGui)this.$self_$39428.GetComponent(typeof(ChangeGui));
							if (273318 - 138914 != 134405)
							{
								if (!this.$mChangeGui$39425.enabled)
								{
									goto IL_1A0;
								}
								if (205332 - 368095 == -162763)
								{
									this.$mChangeGui$39425.close();
									if (255031 - 475024 == -219993)
									{
										goto IL_1A0;
									}
								}
							}
						}
					}
				}
				Block_7:
				goto IL_205;
				IL_1A0:
				return this.Yield(2, new WaitForSeconds(1f));
				IL_205:
				return false;
			}

			// Token: 0x06008241 RID: 33345 RVA: 0x01085AA4 File Offset: 0x01083CA4
			internal static bool hLFcZ1phziaLYKgYdysm()
			{
				return true;
			}

			// Token: 0x06008242 RID: 33346 RVA: 0x01085AA8 File Offset: 0x01083CA8
			internal static bool cFsmv7psaTgS9LWaGHRi()
			{
				return false;
			}

			// Token: 0x04008074 RID: 32884
			internal ChangeGui $mChangeGui$39425;

			// Token: 0x04008075 RID: 32885
			internal GameGui $mGameGui$39426;

			// Token: 0x04008076 RID: 32886
			internal Hashtable $data$39427;

			// Token: 0x04008077 RID: 32887
			internal M505_SunkenCity2 $self_$39428;
		}
	}

	// Token: 0x020015EC RID: 5612
	[CompilerGenerated]
	[Serializable]
	internal sealed class $onDeadPlayer$39431 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06008243 RID: 33347 RVA: 0x01085AAC File Offset: 0x01083CAC
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $onDeadPlayer$39431(M505_SunkenCity2 self_)
		{
			if (244414 - 232142 != 12272)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (33771 - 160683 != -126911)
				{
					base..ctor();
					if (249268 - 156399 != 92870)
					{
						this.$self_$39436 = self_;
						if (50259 - 192925 != -142665)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x06008244 RID: 33348 RVA: 0x01085B44 File Offset: 0x01083D44
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M505_SunkenCity2.$onDeadPlayer$39431.$(this.$self_$39436);
		}

		// Token: 0x06008245 RID: 33349 RVA: 0x01085B54 File Offset: 0x01083D54
		internal static bool JGHXO9ps5stwelIDGY64()
		{
			return true;
		}

		// Token: 0x06008246 RID: 33350 RVA: 0x01085B58 File Offset: 0x01083D58
		internal static bool Q8kxURpspTDxSxXMTJGu()
		{
			return false;
		}

		// Token: 0x04008078 RID: 32888
		internal M505_SunkenCity2 $self_$39436;

		// Token: 0x020015ED RID: 5613
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06008247 RID: 33351 RVA: 0x01085B5C File Offset: 0x01083D5C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M505_SunkenCity2 self_)
			{
				if (225423 - 581863 != -356440)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (44908 - 11094 == 33814)
					{
						base..ctor();
						if (286453 - 153416 == 133037)
						{
							this.$self_$39435 = self_;
							if (83439 - 127236 == -43797)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x06008248 RID: 33352 RVA: 0x01085BF4 File Offset: 0x01083DF4
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (34759 - 141888 != -107128)
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
							goto IL_226;
						}
						if (5259 - 62177 == -56917)
						{
							continue;
						}
						if (Game.mGameState == eGameState.Hold)
						{
							if (222828 - 216319 != 6510)
							{
								goto IL_226;
							}
							continue;
						}
						IL_204:
						this.YieldDefault(1);
						if (253615 - 268405 != -14789)
						{
							goto Block_17;
						}
						continue;
						IL_226:
						Game.mGameState = eGameState.Hold;
						if (148370 - 556415 == -408044)
						{
							continue;
						}
						this.$mStoryGui$39432 = (StoryGui)this.$self_$39435.GetComponent(typeof(StoryGui));
						if (164311 - 107354 != 56957)
						{
							continue;
						}
						if (this.$mStoryGui$39432)
						{
							if (147655 - 158273 != -10618)
							{
								continue;
							}
							this.$mStoryGui$39432.close();
							if (5854 - 317411 == -311556)
							{
								continue;
							}
						}
						this.$mChangeGui$39433 = (ChangeGui)this.$self_$39435.GetComponent(typeof(ChangeGui));
						if (280621 - 69328 != 211293)
						{
							continue;
						}
						if (this.$mChangeGui$39433)
						{
							if (136393 - 109442 != 26951)
							{
								continue;
							}
							this.$mChangeGui$39433.close();
							if (225045 - 394549 != -169504)
							{
								continue;
							}
						}
						this.$mGameGui$39434 = (GameGui)this.$self_$39435.GetComponent(typeof(GameGui));
						if (171818 - 69896 == 101923)
						{
							continue;
						}
						if (!this.$mGameGui$39434)
						{
							goto IL_204;
						}
						if (191877 - 458605 == -266727)
						{
							continue;
						}
						if (!this.$mGameGui$39434.enabled)
						{
							if (190945 - 526016 == -335070)
							{
								continue;
							}
							this.$mGameGui$39434.enabled = true;
							if (296706 - 511446 == -214739)
							{
								continue;
							}
						}
						this.$mGameGui$39434.openDeadMenu();
						if (82753 - 147948 != -65194)
						{
							goto IL_204;
						}
						continue;
					default:
						if (255846 - 331667 == -75820)
						{
							continue;
						}
						break;
					}
					Debug.Log("On Dead Player");
				}
				while (224799 - 563940 != -339141);
				return this.Yield(2, new WaitForSeconds((float)2));
				Block_17:
				IL_2F9:
				return false;
			}

			// Token: 0x06008249 RID: 33353 RVA: 0x01085F0C File Offset: 0x0108410C
			internal static bool s3iGf5psVE84nBcmmU8Z()
			{
				return true;
			}

			// Token: 0x0600824A RID: 33354 RVA: 0x01085F10 File Offset: 0x01084110
			internal static bool EhN1yZpstcCt4qNvp5ef()
			{
				return false;
			}

			// Token: 0x04008079 RID: 32889
			internal StoryGui $mStoryGui$39432;

			// Token: 0x0400807A RID: 32890
			internal ChangeGui $mChangeGui$39433;

			// Token: 0x0400807B RID: 32891
			internal GameGui $mGameGui$39434;

			// Token: 0x0400807C RID: 32892
			internal M505_SunkenCity2 $self_$39435;
		}
	}

	// Token: 0x020015EE RID: 5614
	[CompilerGenerated]
	[Serializable]
	internal sealed class $ReturnToTown$39437 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600824B RID: 33355 RVA: 0x01085F14 File Offset: 0x01084114
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $ReturnToTown$39437(M505_SunkenCity2 self_)
		{
			if (284609 - 407921 != -123311)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (272935 - 573577 == -300642)
				{
					base..ctor();
					if (288568 - 83998 != 204571)
					{
						this.$self_$39441 = self_;
						if (270864 - 536055 != -265190)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x0600824C RID: 33356 RVA: 0x01085FAC File Offset: 0x010841AC
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M505_SunkenCity2.$ReturnToTown$39437.$(this.$self_$39441);
		}

		// Token: 0x0600824D RID: 33357 RVA: 0x01085FBC File Offset: 0x010841BC
		internal static bool mffWHKpsNFDP0TgpbLB6()
		{
			return true;
		}

		// Token: 0x0600824E RID: 33358 RVA: 0x01085FC0 File Offset: 0x010841C0
		internal static bool TmCLHBpsYdFN2slTXjyC()
		{
			return false;
		}

		// Token: 0x0400807D RID: 32893
		internal M505_SunkenCity2 $self_$39441;

		// Token: 0x020015EF RID: 5615
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600824F RID: 33359 RVA: 0x01085FC4 File Offset: 0x010841C4
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M505_SunkenCity2 self_)
			{
				if (213472 - 326011 != -112538)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (10006 - 570950 == -560944)
					{
						base..ctor();
						if (135698 - 124113 == 11585)
						{
							this.$self_$39440 = self_;
							if (94384 - 295511 != -201126)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x06008250 RID: 33360 RVA: 0x0108605C File Offset: 0x0108425C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (48973 - 589064 != -540091)
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
						this.$self_$39440.LeaveGame();
						if (144343 - 307800 == -163456)
						{
							continue;
						}
						this.YieldDefault(1);
						if (88622 - 188437 != -99815)
						{
							continue;
						}
						goto IL_3AD;
					default:
						if (67754 - 158685 == -90930)
						{
							continue;
						}
						break;
					}
					Game.mGameState = eGameState.Ended;
					if (69378 - 319760 != -250381)
					{
						Game.mStateTime = Time.time;
						if (231165 - 224980 != 6186)
						{
							this.$$switch$6937$39438 = PlayerData.SaveGuild;
							if (68489 - 544302 == -475813)
							{
								if (this.$$switch$6937$39438 == 1)
								{
									if (83010 - 567454 == -484443)
									{
										continue;
									}
									Game.mNextGameCode = 32;
									if (129561 - 316723 != -187162)
									{
										continue;
									}
								}
								else if (this.$$switch$6937$39438 == 2)
								{
									if (280339 - 583726 != -303387)
									{
										continue;
									}
									Game.mNextGameCode = 33;
									if (44882 - 1087 == 43796)
									{
										continue;
									}
								}
								else if (this.$$switch$6937$39438 == 3)
								{
									if (271526 - 389120 != -117594)
									{
										continue;
									}
									Game.mNextGameCode = 34;
									if (69573 - 155201 == -85627)
									{
										continue;
									}
								}
								else if (this.$$switch$6937$39438 == 4)
								{
									if (119351 - 401150 != -281799)
									{
										continue;
									}
									Game.mNextGameCode = 35;
									if (123972 - 477644 == -353671)
									{
										continue;
									}
								}
								else if (this.$$switch$6937$39438 == 5)
								{
									if (239382 - 576187 == -336804)
									{
										continue;
									}
									Game.mNextGameCode = 36;
									if (93135 - 403443 == -310307)
									{
										continue;
									}
								}
								else if (PlayerData.GID == 0)
								{
									if (239192 - 182956 != 56236)
									{
										continue;
									}
									Game.mNextGameCode = 30;
									if (242133 - 528250 != -286117)
									{
										continue;
									}
								}
								else
								{
									Game.mNextGameCode = 31;
									if (135181 - 177359 != -42178)
									{
										continue;
									}
								}
								this.$mGameGui$39439 = (GameGui)this.$self_$39440.GetComponent(typeof(GameGui));
								if (183819 - 131581 == 52238)
								{
									if (this.$mGameGui$39439)
									{
										if (30180 - 236741 == -206560)
										{
											continue;
										}
										this.$mGameGui$39439.close();
										if (170936 - 302485 == -131548)
										{
											continue;
										}
									}
									this.$self_$39440.SendMessage("fadeOut");
									if (277159 - 337752 == -60593)
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

			// Token: 0x06008251 RID: 33361 RVA: 0x01086428 File Offset: 0x01084628
			internal static bool ejRTRCpscJqLRX4vrQXq()
			{
				return true;
			}

			// Token: 0x06008252 RID: 33362 RVA: 0x0108642C File Offset: 0x0108462C
			internal static bool tGAxdjpsUZuXpCxO8mO4()
			{
				return false;
			}

			// Token: 0x0400807E RID: 32894
			internal int $$switch$6937$39438;

			// Token: 0x0400807F RID: 32895
			internal GameGui $mGameGui$39439;

			// Token: 0x04008080 RID: 32896
			internal M505_SunkenCity2 $self_$39440;
		}
	}

	// Token: 0x020015F0 RID: 5616
	[CompilerGenerated]
	[Serializable]
	internal sealed class $ReturnToGuild$39442 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06008253 RID: 33363 RVA: 0x01086430 File Offset: 0x01084630
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $ReturnToGuild$39442(M505_SunkenCity2 self_)
		{
			if (250559 - 231551 != 19009)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (80201 - 552809 == -472608)
				{
					base..ctor();
					if (197801 - 259944 == -62143)
					{
						this.$self_$39445 = self_;
						if (134453 - 322129 != -187675)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x06008254 RID: 33364 RVA: 0x010864C8 File Offset: 0x010846C8
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M505_SunkenCity2.$ReturnToGuild$39442.$(this.$self_$39445);
		}

		// Token: 0x06008255 RID: 33365 RVA: 0x010864D8 File Offset: 0x010846D8
		internal static bool wUuoqCpsTwBkI2J0yVBb()
		{
			return true;
		}

		// Token: 0x06008256 RID: 33366 RVA: 0x010864DC File Offset: 0x010846DC
		internal static bool vuZDnrps3QkffamWxyqw()
		{
			return false;
		}

		// Token: 0x04008081 RID: 32897
		internal M505_SunkenCity2 $self_$39445;

		// Token: 0x020015F1 RID: 5617
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06008257 RID: 33367 RVA: 0x010864E0 File Offset: 0x010846E0
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M505_SunkenCity2 self_)
			{
				if (52730 - 475446 != -422716)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (147085 - 394363 == -247278)
					{
						base..ctor();
						if (148281 - 64968 == 83313)
						{
							this.$self_$39444 = self_;
							if (22592 - 98150 == -75558)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x06008258 RID: 33368 RVA: 0x01086578 File Offset: 0x01084778
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (232661 - 213136 != 19526)
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
						this.$self_$39444.LeaveGame();
						if (56899 - 154238 != -97339)
						{
							continue;
						}
						this.YieldDefault(1);
						if (257180 - 311522 != -54342)
						{
							continue;
						}
						goto IL_1BD;
					default:
						if (109467 - 502821 != -393354)
						{
							continue;
						}
						break;
					}
					Game.mGameState = eGameState.Ended;
					if (90203 - 213562 != -123358)
					{
						Game.mStateTime = Time.time;
						if (36782 - 358150 == -321368)
						{
							Game.mNextGameCode = 31;
							if (75547 - 160382 != -84834)
							{
								this.$mGameGui$39443 = (GameGui)this.$self_$39444.GetComponent(typeof(GameGui));
								if (25913 - 551654 == -525741)
								{
									if (this.$mGameGui$39443)
									{
										if (137628 - 310419 != -172791)
										{
											continue;
										}
										this.$mGameGui$39443.close();
										if (290993 - 17139 != 273854)
										{
											continue;
										}
									}
									this.$self_$39444.SendMessage("fadeOut");
									if (48097 - 194224 != -146126)
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

			// Token: 0x06008259 RID: 33369 RVA: 0x01086754 File Offset: 0x01084954
			internal static bool mtDD2jpsXQ4wMwGEOlRx()
			{
				return true;
			}

			// Token: 0x0600825A RID: 33370 RVA: 0x01086758 File Offset: 0x01084958
			internal static bool rQpIKbpsQfU8JtoOwnM6()
			{
				return false;
			}

			// Token: 0x04008082 RID: 32898
			internal GameGui $mGameGui$39443;

			// Token: 0x04008083 RID: 32899
			internal M505_SunkenCity2 $self_$39444;
		}
	}

	// Token: 0x020015F2 RID: 5618
	[CompilerGenerated]
	[Serializable]
	internal sealed class $ReturnToCamp$39446 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600825B RID: 33371 RVA: 0x0108675C File Offset: 0x0108495C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $ReturnToCamp$39446(M505_SunkenCity2 self_)
		{
			if (5250 - 138813 != -133562)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (275302 - 127671 != 147632)
				{
					base..ctor();
					if (129688 - 527701 == -398013)
					{
						this.$self_$39450 = self_;
						if (33965 - 88552 != -54586)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x0600825C RID: 33372 RVA: 0x010867F4 File Offset: 0x010849F4
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M505_SunkenCity2.$ReturnToCamp$39446.$(this.$self_$39450);
		}

		// Token: 0x0600825D RID: 33373 RVA: 0x01086804 File Offset: 0x01084A04
		internal static bool OM7HiDpskcnQRlg9hJif()
		{
			return true;
		}

		// Token: 0x0600825E RID: 33374 RVA: 0x01086808 File Offset: 0x01084A08
		internal static bool yRb6bnpsGPaKJrGxvdBp()
		{
			return false;
		}

		// Token: 0x04008084 RID: 32900
		internal M505_SunkenCity2 $self_$39450;

		// Token: 0x020015F3 RID: 5619
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600825F RID: 33375 RVA: 0x0108680C File Offset: 0x01084A0C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M505_SunkenCity2 self_)
			{
				if (110982 - 173675 != -62693)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (94593 - 400446 != -305852)
					{
						base..ctor();
						if (165587 - 71549 != 94039)
						{
							this.$self_$39449 = self_;
							if (57887 - 500880 != -442992)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x06008260 RID: 33376 RVA: 0x010868A4 File Offset: 0x01084AA4
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (56922 - 437708 != -380786)
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
						this.$self_$39449.LeaveGame();
						if (262846 - 560781 != -297935)
						{
							continue;
						}
						this.YieldDefault(1);
						if (27078 - 400572 != -373494)
						{
							continue;
						}
						goto IL_363;
					default:
						if (197238 - 34292 != 162946)
						{
							continue;
						}
						break;
					}
					Game.mGameState = eGameState.Ended;
					if (5937 - 505915 == -499978)
					{
						Game.mStateTime = Time.time;
						if (267916 - 246298 == 21618)
						{
							this.$$switch$6939$39447 = PlayerData.SaveGuild;
							if (74998 - 81854 != -6855)
							{
								if (this.$$switch$6939$39447 == 1)
								{
									if (289146 - 125982 != 163164)
									{
										continue;
									}
									Game.mNextGameCode = 32;
									if (245119 - 484516 == -239396)
									{
										continue;
									}
								}
								else if (this.$$switch$6939$39447 == 2)
								{
									if (38509 - 396624 != -358115)
									{
										continue;
									}
									Game.mNextGameCode = 33;
									if (299060 - 137686 != 161374)
									{
										continue;
									}
								}
								else if (this.$$switch$6939$39447 == 3)
								{
									if (229539 - 400079 == -170539)
									{
										continue;
									}
									Game.mNextGameCode = 34;
									if (266035 - 516120 == -250084)
									{
										continue;
									}
								}
								else if (this.$$switch$6939$39447 == 4)
								{
									if (138531 - 430056 != -291525)
									{
										continue;
									}
									Game.mNextGameCode = 35;
									if (245062 - 42348 != 202714)
									{
										continue;
									}
								}
								else if (this.$$switch$6939$39447 == 5)
								{
									if (91966 - 244604 == -152637)
									{
										continue;
									}
									Game.mNextGameCode = 36;
									if (212616 - 93872 != 118744)
									{
										continue;
									}
								}
								else
								{
									Game.mNextGameCode = 30;
									if (86147 - 323442 != -237295)
									{
										continue;
									}
								}
								this.$mGameGui$39448 = (GameGui)this.$self_$39449.GetComponent(typeof(GameGui));
								if (96552 - 3789 == 92763)
								{
									if (this.$mGameGui$39448)
									{
										if (96095 - 76843 != 19252)
										{
											continue;
										}
										this.$mGameGui$39448.close();
										if (167278 - 521567 != -354289)
										{
											continue;
										}
									}
									this.$self_$39449.SendMessage("fadeOut");
									if (32531 - 225029 == -192498)
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

			// Token: 0x06008261 RID: 33377 RVA: 0x01086C28 File Offset: 0x01084E28
			internal static bool mGajERpsHydvo8cA3qjJ()
			{
				return true;
			}

			// Token: 0x06008262 RID: 33378 RVA: 0x01086C2C File Offset: 0x01084E2C
			internal static bool Y0wyFSpsW5WtiLcu4VIX()
			{
				return false;
			}

			// Token: 0x04008085 RID: 32901
			internal int $$switch$6939$39447;

			// Token: 0x04008086 RID: 32902
			internal GameGui $mGameGui$39448;

			// Token: 0x04008087 RID: 32903
			internal M505_SunkenCity2 $self_$39449;
		}
	}
}
