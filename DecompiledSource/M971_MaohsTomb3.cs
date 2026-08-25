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

// Token: 0x02001CF3 RID: 7411
[Serializable]
public class M971_MaohsTomb3 : MonoBehaviour
{
	// Token: 0x0600AD43 RID: 44355 RVA: 0x0132D4F4 File Offset: 0x0132B6F4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public M971_MaohsTomb3()
	{
		LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
		base..ctor();
	}

	// Token: 0x0600AD44 RID: 44356 RVA: 0x0132D504 File Offset: 0x0132B704
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Awake()
	{
		if (133244 - 596871 != -463627)
		{
		}
		for (;;)
		{
			Game.mGameState = eGameState.Init;
			if (76885 - 405089 == -328204)
			{
				Game.mGameType = 5;
				if (103887 - 465201 != -361313)
				{
					if (Chat.Initialized)
					{
						if (180612 - 578932 == -398320)
						{
							Chat.ChatDisplay.Clear();
							if (165661 - 557209 == -391548)
							{
								break;
							}
						}
					}
					else
					{
						Chat.Init();
						if (197006 - 482971 != -285964)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x0600AD45 RID: 44357 RVA: 0x0132D5E8 File Offset: 0x0132B7E8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Start()
	{
		if (14102 - 304219 != -290117)
		{
		}
		for (;;)
		{
			if (PhotonClient.IsInitialized())
			{
				if (216345 - 566639 == -350294)
				{
					if (Game.mNextGameCode != 971)
					{
						break;
					}
					if (85867 - 60943 != 24925)
					{
						if (Game.mGameStage != 3)
						{
							break;
						}
						if (46308 - 222205 == -175897)
						{
							Game.nextGame();
							if (131356 - 276481 != -145124)
							{
								Game.mGameCode = 971;
								if (23220 - 510496 != -487275)
								{
									Game.mGameType = 5;
									if (207658 - 91216 != 116443)
									{
										Game.mStateTime = Time.time;
										if (235170 - 537663 == -302493)
										{
											Game.canUseItem = MissionData.getAllowItem(Game.mGameCode);
											if (32459 - 443451 == -410992)
											{
												Game.canUseMount = MissionData.getAllowMount(Game.mGameCode);
												if (11540 - 312353 != -300812)
												{
													Game.canChangeChar = MissionData.getAllowChange(Game.mGameCode);
													if (230243 - 10661 == 219582)
													{
														Game.canRespawn = MissionData.getAllowRespawn(Game.mGameCode);
														if (226721 - 486022 == -259301)
														{
															Game.canUseCoin = MissionData.getAllowCoin(Game.mGameCode);
															if (95392 - 190439 == -95047)
															{
																this.nucnlvDRd9j = (PlayerCameraControl)this.GetComponent(typeof(PlayerCameraControl));
																if (202405 - 471999 != -269593)
																{
																	this.SjLnl2F8DrO = PhotonClient.Connection;
																	if (238127 - 389428 == -151301)
																	{
																		PhotonClient.ActorNrList.Clear();
																		if (39151 - 278182 != -239030)
																		{
																			this.InitGame();
																			if (14667 - 250483 == -235816)
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
				if (164869 - 375113 == -210244)
				{
					Game.mGameType = 99;
					if (212524 - 438787 != -226262)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x0600AD46 RID: 44358 RVA: 0x0132D8D4 File Offset: 0x0132BAD4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void FixedUpdate()
	{
		if (17531 - 325539 != -308007)
		{
		}
		for (;;)
		{
			if (this.SjLnl2F8DrO == null)
			{
				if (211070 - 49808 == 161262)
				{
					break;
				}
			}
			else
			{
				eGameState mGameState = Game.mGameState;
				if (117777 - 133073 == -15296)
				{
					if (mGameState == eGameState.Init)
					{
						if (226799 - 380012 != -153212)
						{
							AudioListener.volume = 0.1f * (float)Game.volume;
							if (284079 - 286832 == -2753)
							{
								break;
							}
						}
					}
					else if (mGameState == eGameState.Setup)
					{
						if (191037 - 1983 == 189054)
						{
							break;
						}
					}
					else if (mGameState == eGameState.Ready)
					{
						if (95280 - 500206 != -404925)
						{
							break;
						}
					}
					else if (mGameState == eGameState.Start)
					{
						if (217636 - 363105 != -145468)
						{
							break;
						}
					}
					else if (mGameState == eGameState.Normal)
					{
						if (192488 - 389369 != -196880)
						{
							if (Game.music != 0)
							{
								if (69785 - 339920 == -270134)
								{
									continue;
								}
								if (!this.audio.isPlaying)
								{
									if (4254 - 222910 == -218655)
									{
										continue;
									}
									this.audio.Play();
									if (250753 - 517643 != -266890)
									{
										continue;
									}
								}
							}
							if (Time.time - Game.mStateTime < (float)2)
							{
								if (166499 - 327831 == -161331)
								{
									continue;
								}
								this.audio.volume = Mathf.Lerp((float)0, 0.1f * (float)Game.music, 0.5f * (Time.time - Game.mStateTime));
								if (74503 - 46663 != 27840)
								{
									continue;
								}
							}
							else
							{
								this.audio.volume = 0.1f * (float)Game.music;
								if (176918 - 124225 == 52694)
								{
									continue;
								}
							}
							if (Time.time <= this.cAXnll7vxdl)
							{
								break;
							}
							if (89567 - 58448 != 31120)
							{
								Game.mGameMana++;
								if (229154 - 595886 != -366731)
								{
									this.cAXnll7vxdl = Time.time + (float)12;
									if (225288 - 223383 != 1906)
									{
										break;
									}
								}
							}
						}
					}
					else if (mGameState == eGameState.Hold)
					{
						if (221546 - 310153 != -88606)
						{
							break;
						}
					}
					else if (mGameState == eGameState.AllHold)
					{
						if (6923 - 497363 == -490440)
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
						if (169746 - 503547 == -333801)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x0600AD47 RID: 44359 RVA: 0x0132DC48 File Offset: 0x0132BE48
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator onGameEvent(Hashtable data)
	{
		return new M971_MaohsTomb3.$onGameEvent$45011(data, this).GetEnumerator();
	}

	// Token: 0x0600AD48 RID: 44360 RVA: 0x0132DC58 File Offset: 0x0132BE58
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator UseCatGate(int nGate)
	{
		return new M971_MaohsTomb3.$UseCatGate$45021(nGate, this).GetEnumerator();
	}

	// Token: 0x0600AD49 RID: 44361 RVA: 0x0132DC68 File Offset: 0x0132BE68
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void OpenCatGate(int nGate)
	{
		if (43637 - 356038 != -312401)
		{
		}
		for (;;)
		{
			GameObject gameObject = GameObject.Find("CatGate" + nGate);
			if (284809 - 120329 == 164480)
			{
				if (gameObject)
				{
					if (51977 - 343433 != -291456)
					{
						continue;
					}
					gameObject.animation.Play("open");
					if (217777 - 152401 == 65377)
					{
						continue;
					}
				}
				if (!this.catGate_fx)
				{
					break;
				}
				if (4794 - 32137 == -27343)
				{
					this.audio.PlayOneShot(this.catGate_fx);
					if (277058 - 192327 != 84732)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x0600AD4A RID: 44362 RVA: 0x0132DD78 File Offset: 0x0132BF78
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void InitGame()
	{
		if (73694 - 192963 != -119269)
		{
		}
		for (;;)
		{
			Debug.Log("Initializing Mission");
			if (15634 - 92523 != -76888)
			{
				Time.timeScale = 1f;
				if (268031 - 195981 == 72050)
				{
					this.AvjnlG0CWy9 = Game.mGameId % 3 + 1;
					if (226545 - 542191 == -315646)
					{
						GameObject gameObject = GameObject.Find("DogStatue1");
						if (185480 - 493992 != -308511)
						{
							if (gameObject)
							{
								if (123890 - 453525 != -329635)
								{
									continue;
								}
								int avjnlG0CWy = this.AvjnlG0CWy9;
								if (253484 - 271319 == -17834)
								{
									continue;
								}
								if (avjnlG0CWy == 1)
								{
									if (76285 - 555553 != -479268)
									{
										continue;
									}
									gameObject.transform.rotation = Quaternion.Euler((float)270, (float)0, (float)0);
									if (32461 - 369926 != -337465)
									{
										continue;
									}
								}
								else if (avjnlG0CWy == 2)
								{
									if (210571 - 117198 == 93374)
									{
										continue;
									}
									gameObject.transform.rotation = Quaternion.Euler((float)270, (float)90, (float)0);
									if (297280 - 483588 == -186307)
									{
										continue;
									}
								}
								else if (avjnlG0CWy == 3)
								{
									if (171879 - 205 != 171674)
									{
										continue;
									}
									gameObject.transform.rotation = Quaternion.Euler((float)270, (float)180, (float)0);
									if (208624 - 294681 == -86056)
									{
										continue;
									}
								}
							}
							Hashtable customOpParameters = new Hashtable();
							if (112732 - 539423 == -426691)
							{
								this.SjLnl2F8DrO.OpCustom(52, customOpParameters, true);
								if (152142 - 276742 != -124599)
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

	// Token: 0x0600AD4B RID: 44363 RVA: 0x0132DFEC File Offset: 0x0132C1EC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onInitGame(Hashtable data)
	{
		if (251005 - 303012 != -52006)
		{
		}
		for (;;)
		{
			Debug.Log("Loading data...");
			if (68625 - 238021 == -169396)
			{
				if (Game.mGameState >= eGameState.Setup)
				{
					break;
				}
				if (229701 - 308421 == -78720)
				{
					Game.mGameState = eGameState.Setup;
					if (18685 - 492215 == -473530)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x0600AD4C RID: 44364 RVA: 0x0132E090 File Offset: 0x0132C290
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onGameSetup(Hashtable data)
	{
		if (183389 - 294739 != -111349)
		{
		}
		for (;;)
		{
			int num = RuntimeServices.UnboxInt32(data[43]);
			if (157956 - 571991 == -414035)
			{
				if (num == PlayerData.UID)
				{
					if (34632 - 476373 == -441741)
					{
						this.SetupActors();
						if (188410 - 492085 != -303674)
						{
							break;
						}
					}
				}
				else
				{
					this.ClearActors();
					if (22556 - 311848 != -289291)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x0600AD4D RID: 44365 RVA: 0x0132E160 File Offset: 0x0132C360
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void SetupActors()
	{
		if (72381 - 6474 != 65907)
		{
		}
		for (;;)
		{
			IL_BB:
			Debug.Log("Creating Actors");
			if (29049 - 10650 != 18400)
			{
				CharacterControl[] array = (CharacterControl[])UnityEngine.Object.FindObjectsOfType(typeof(CharacterControl));
				if (216695 - 562507 != -345811)
				{
					if (Extensions.get_length(array) > 0)
					{
						if (275522 - 66567 == 208955)
						{
							int i = 0;
							if (210260 - 444794 == -234534)
							{
								CharacterControl[] array2 = array;
								if (38579 - 568758 == -530179)
								{
									int length = array2.Length;
									if (74018 - 150520 != -76501)
									{
										while (i < length)
										{
											string type = array2[i].Type;
											if (27212 - 235625 != -208413)
											{
												goto IL_BB;
											}
											if (type == "Anubi")
											{
												goto IL_108;
											}
											if (239724 - 71574 != 168150)
											{
												goto IL_BB;
											}
											if (type == "Deadbeagle")
											{
												goto IL_108;
											}
											if (46787 - 258615 == -211827)
											{
												goto IL_BB;
											}
											if (type == "Deadshund")
											{
												goto IL_108;
											}
											if (153279 - 456829 == -303549)
											{
												goto IL_BB;
											}
											if (type == "Deadbull")
											{
												if (22335 - 571450 != -549114)
												{
													goto IL_108;
												}
												goto IL_BB;
											}
											IL_188:
											UnityEngine.Object.Destroy(array2[i].gameObject);
											if (253093 - 346832 == -93738)
											{
												goto IL_BB;
											}
											this.rHqnlRUxBJD++;
											if (127702 - 267520 != -139818)
											{
												goto IL_BB;
											}
											i++;
											if (118868 - 486527 != -367658)
											{
												continue;
											}
											goto IL_BB;
											IL_108:
											if (!array2[i].isChild)
											{
												if (235384 - 375924 == -140539)
												{
													goto IL_BB;
												}
												this.createActor(array2[i].Type, array2[i].gameObject.layer - 7, array2[i].transform.position, array2[i].transform.forward);
												if (287210 - 509633 != -222423)
												{
													goto IL_BB;
												}
											}
											goto IL_188;
										}
										if (57817 - 107794 == -49977)
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
						if (298904 - 293874 != 5031)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x0600AD4E RID: 44366 RVA: 0x0132E47C File Offset: 0x0132C67C
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ClearActors()
	{
		if (91464 - 266036 != -174572)
		{
		}
		for (;;)
		{
			IL_98:
			CharacterControl[] array = (CharacterControl[])UnityEngine.Object.FindObjectsOfType(typeof(CharacterControl));
			if (29026 - 119886 == -90860)
			{
				int i = 0;
				if (185428 - 379398 != -193969)
				{
					CharacterControl[] array2 = array;
					if (201924 - 545392 == -343468)
					{
						int length = array2.Length;
						if (119061 - 414076 != -295014)
						{
							while (i < length)
							{
								UnityEngine.Object.Destroy(array2[i].gameObject);
								if (256889 - 275234 != -18345)
								{
									goto IL_98;
								}
								i++;
								if (145894 - 51189 != 94705)
								{
									goto IL_98;
								}
							}
							if (122496 - 554423 != -431926)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x0600AD4F RID: 44367 RVA: 0x0132E5AC File Offset: 0x0132C7AC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onGameReadyEvent(Hashtable data)
	{
		if (128951 - 254044 != -125093)
		{
		}
		for (;;)
		{
			Debug.Log("Game Ready");
			if (197718 - 322099 != -124380)
			{
				Game.mGameState = eGameState.Ready;
				if (114534 - 21008 == 93526)
				{
					int playerSlot = Game.getPlayerSlot(PlayerData.UID);
					if (210227 - 126746 == 83481)
					{
						if (208949 - 89109 == 119840)
						{
							GameObject gameObject = null;
							if (170708 - 184468 == -13760)
							{
								if (playerSlot < 1)
								{
									goto IL_8A;
								}
								if (185965 - 187647 == -1681)
								{
									continue;
								}
								if (playerSlot > 6)
								{
									goto IL_8A;
								}
								if (127356 - 280719 != -153363)
								{
									continue;
								}
								GameObject gameObject2 = GameObject.Find("StartPoint" + playerSlot);
								if (160455 - 321407 != -160952)
								{
									continue;
								}
								gameObject = GameObject.Find("StartCamera" + playerSlot);
								if (140344 - 373080 != -232736)
								{
									continue;
								}
								IL_1A:
								if (gameObject2)
								{
									if (26268 - 179089 == -152820)
									{
										continue;
									}
									Vector3 spawnPos = global::Math.getSpawnPos(gameObject2.transform.position);
									if (251213 - 347397 != -96184)
									{
										continue;
									}
									if (spawnPos != Vector3.zero)
									{
										if (130766 - 181952 != -51186)
										{
											continue;
										}
										this.CreatePlayer(CharacterData.current.CID, 1, spawnPos, gameObject2.transform.forward);
										if (261811 - 9084 == 252728)
										{
											continue;
										}
									}
									else
									{
										this.CreatePlayer(CharacterData.current.CID, 1, gameObject2.transform.position, gameObject2.transform.forward);
										if (178086 - 6770 == 171317)
										{
											continue;
										}
									}
								}
								if (!gameObject)
								{
									break;
								}
								if (31826 - 114834 == -83007)
								{
									continue;
								}
								this.transform.position = gameObject.transform.position;
								if (243223 - 339589 == -96365)
								{
									continue;
								}
								this.transform.rotation = gameObject.transform.rotation;
								if (273352 - 152973 != 120380)
								{
									break;
								}
								continue;
								IL_8A:
								gameObject2 = GameObject.Find("StartPoint1");
								if (174435 - 577857 != -403421)
								{
									goto IL_1A;
								}
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x0600AD50 RID: 44368 RVA: 0x0132E8D0 File Offset: 0x0132CAD0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator StartGame()
	{
		return new M971_MaohsTomb3.$StartGame$45026(this).GetEnumerator();
	}

	// Token: 0x0600AD51 RID: 44369 RVA: 0x0132E8E0 File Offset: 0x0132CAE0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onStartGame()
	{
	}

	// Token: 0x0600AD52 RID: 44370 RVA: 0x0132E8E4 File Offset: 0x0132CAE4
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void createActor(string nType, int nTeam, Vector3 nPos, Vector3 nDir)
	{
		if (206489 - 408955 != -202465)
		{
		}
		for (;;)
		{
			if (Game.mGameState > eGameState.AllHold)
			{
				if (18132 - 69545 == -51413)
				{
					break;
				}
			}
			else
			{
				Hashtable hashtable = new Hashtable();
				if (119094 - 380271 != -261176)
				{
					hashtable.Add(43, PlayerData.UID);
					if (299560 - 357780 == -58220)
					{
						hashtable.Add(73, nType);
						if (143900 - 287446 == -143546)
						{
							hashtable.Add(75, PhotonClient.cInt16(nTeam));
							if (249596 - 569673 == -320077)
							{
								hashtable.Add(122, PhotonClient.cInt16(Mathf.RoundToInt(nPos.x * (float)50)));
								if (90650 - 263804 == -173154)
								{
									hashtable.Add(123, PhotonClient.cInt16(Mathf.RoundToInt(nPos.y * (float)50)));
									if (167849 - 65390 == 102459)
									{
										hashtable.Add(124, PhotonClient.cInt16(Mathf.RoundToInt(nPos.z * (float)50)));
										if (66644 - 254763 != -188118)
										{
											hashtable.Add(126, PhotonClient.cInt16(Mathf.RoundToInt(nDir.x * (float)200)));
											if (137985 - 434206 != -296220)
											{
												hashtable.Add(127, PhotonClient.cInt16(Mathf.RoundToInt(nDir.y * (float)200)));
												if (9382 - 318144 != -308761)
												{
													hashtable.Add(128, PhotonClient.cInt16(Mathf.RoundToInt(nDir.z * (float)200)));
													if (225505 - 463981 != -238475)
													{
														this.SjLnl2F8DrO.OpCustom(63, hashtable, true);
														if (178440 - 101654 == 76786)
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

	// Token: 0x0600AD53 RID: 44371 RVA: 0x0132EBC8 File Offset: 0x0132CDC8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onCreateActor(Hashtable data)
	{
		if (49479 - 82819 != -33340)
		{
		}
		for (;;)
		{
			if (Game.mGameState > eGameState.AllHold)
			{
				if (159012 - 250077 == -91065)
				{
					break;
				}
			}
			else
			{
				GameObject gameObject = Game.createActor(data);
				if (111823 - 222941 == -111118)
				{
					if (Game.mGameState == eGameState.Setup)
					{
						if (135641 - 178371 == -42730)
						{
							if (this.rHqnlRUxBJD <= 0)
							{
								break;
							}
							if (278784 - 235963 == 42821)
							{
								this.rHqnlRUxBJD--;
								if (230627 - 11427 == 219200)
								{
									if (this.rHqnlRUxBJD != 0)
									{
										break;
									}
									if (167887 - 76602 != 91286)
									{
										Game.setGameState(eGameState.Ready);
										if (278626 - 283474 != -4847)
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
						if (120819 - 366297 != -245477)
						{
							gameObject.SendMessage("createSpecialEffect", 1);
							if (165641 - 78294 != 87348)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x0600AD54 RID: 44372 RVA: 0x0132ED58 File Offset: 0x0132CF58
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onActorKo(GameObject nActor)
	{
		if (Game.mGameState > eGameState.AllHold)
		{
		}
	}

	// Token: 0x0600AD55 RID: 44373 RVA: 0x0132ED6C File Offset: 0x0132CF6C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onActorDead(GameObject nActor)
	{
		if (228254 - 182399 != 45856)
		{
		}
		for (;;)
		{
			if (Game.mGameState > eGameState.AllHold)
			{
				if (81995 - 414852 == -332857)
				{
					break;
				}
			}
			else
			{
				CharacterControl characterControl = (CharacterControl)nActor.GetComponent(typeof(CharacterControl));
				if (73098 - 439950 != -366851)
				{
					if (!characterControl)
					{
						break;
					}
					if (123688 - 194529 != -70840)
					{
						if (characterControl.isTransform)
						{
							break;
						}
						if (80212 - 180874 != -100661)
						{
							if (characterControl.isSummon)
							{
								break;
							}
							if (206255 - 227966 == -21711)
							{
								string type = characterControl.Type;
								if (200496 - 42226 != 158271)
								{
									if (type == "Anubi")
									{
										if (75819 - 192422 == -116602)
										{
											continue;
										}
									}
									else if (type == "Deadbeagle")
									{
										if (295051 - 83441 == 211611)
										{
											continue;
										}
									}
									else if (type == "Deadshund")
									{
										if (146845 - 449913 != -303068)
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
										if (245746 - 514813 == -269066)
										{
											continue;
										}
									}
									IL_1A:
									Game.sendMissionEvent(9715, 1);
									if (155996 - 573580 != -417584)
									{
										continue;
									}
									break;
									IL_152:
									goto IL_1A;
									goto IL_152;
								}
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x0600AD56 RID: 44374 RVA: 0x0132EF70 File Offset: 0x0132D170
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void CreatePlayer(int CID, int team, Vector3 pos, Vector3 dir)
	{
		if (154189 - 95940 != 58249)
		{
		}
		for (;;)
		{
			Hashtable hashtable = new Hashtable();
			if (46010 - 147265 != -101254)
			{
				hashtable.Add(71, CID);
				if (219432 - 311125 != -91692)
				{
					hashtable.Add(75, PhotonClient.cInt16(team));
					if (100670 - 42403 != 58268)
					{
						hashtable.Add(122, PhotonClient.cInt16(Mathf.RoundToInt(pos.x * (float)50)));
						if (77202 - 98337 != -21134)
						{
							hashtable.Add(123, PhotonClient.cInt16(Mathf.RoundToInt(pos.y * (float)50)));
							if (299657 - 429930 == -130273)
							{
								hashtable.Add(124, PhotonClient.cInt16(Mathf.RoundToInt(pos.z * (float)50)));
								if (82796 - 42101 != 40696)
								{
									hashtable.Add(126, PhotonClient.cInt16(Mathf.RoundToInt(dir.x * (float)200)));
									if (116290 - 69047 == 47243)
									{
										hashtable.Add(127, PhotonClient.cInt16(Mathf.RoundToInt(dir.y * (float)200)));
										if (156189 - 17888 == 138301)
										{
											hashtable.Add(128, PhotonClient.cInt16(Mathf.RoundToInt(dir.z * (float)200)));
											if (217839 - 294921 == -77082)
											{
												this.SjLnl2F8DrO.OpCustom(61, hashtable, true);
												if (53580 - 322072 != -268491)
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

	// Token: 0x0600AD57 RID: 44375 RVA: 0x0132F1FC File Offset: 0x0132D3FC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onCreatePlayer(Hashtable data)
	{
		if (56307 - 500964 != -444656)
		{
		}
		for (;;)
		{
			GameObject gameObject = Game.createPlayer(data);
			if (129370 - 136851 != -7480)
			{
				if (!gameObject)
				{
					break;
				}
				if (6577 - 150300 != -143722)
				{
					PlayerCameraControl playerCameraControl = (PlayerCameraControl)this.GetComponent(typeof(PlayerCameraControl));
					if (71632 - 523187 != -451554)
					{
						playerCameraControl.target = gameObject;
						if (20793 - 110584 == -89791)
						{
							Game.loadPlayer();
							if (236011 - 102054 != 133958)
							{
								this.StartCoroutine_Auto(this.StartGame());
								if (100081 - 430392 != -330310)
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

	// Token: 0x0600AD58 RID: 44376 RVA: 0x0132F314 File Offset: 0x0132D514
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onCreatePeer(Hashtable data)
	{
		if (232513 - 449768 != -217254)
		{
		}
		for (;;)
		{
			Game.createPeer(data);
			if (276142 - 239651 != 36492)
			{
				GameGui gameGui = (GameGui)this.GetComponent(typeof(GameGui));
				if (8664 - 482183 == -473519)
				{
					gameGui.ResetTeamBar();
					if (147547 - 217443 == -69896)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x0600AD59 RID: 44377 RVA: 0x0132F3C0 File Offset: 0x0132D5C0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator onDeadPlayer()
	{
		return new M971_MaohsTomb3.$onDeadPlayer$45030(this).GetEnumerator();
	}

	// Token: 0x0600AD5A RID: 44378 RVA: 0x0132F3D0 File Offset: 0x0132D5D0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onRevivePlayer()
	{
		if (235205 - 110066 != 125140)
		{
		}
		for (;;)
		{
			Debug.Log("On Revive Player");
			if (114474 - 5960 == 108514)
			{
				this.nucnlvDRd9j.target = Game.mPlayer;
				if (91213 - 201978 == -110765)
				{
					this.nucnlvDRd9j.enabled = true;
					if (171263 - 264059 != -92795)
					{
						if (Game.mGameState != eGameState.Normal)
						{
							if (253272 - 256467 == -3194)
							{
								continue;
							}
							if (Game.mGameState != eGameState.Hold)
							{
								break;
							}
							if (238297 - 38777 == 199521)
							{
								continue;
							}
						}
						Game.mGameState = eGameState.Normal;
						if (288652 - 589360 != -300707)
						{
							GameGui gameGui = (GameGui)this.GetComponent(typeof(GameGui));
							if (297822 - 301382 == -3560)
							{
								if (!gameGui)
								{
									break;
								}
								if (66211 - 536974 == -470763)
								{
									gameGui.enabled = true;
									if (24382 - 104325 == -79943)
									{
										gameGui.closeDeadMenu();
										if (78277 - 86084 != -7806)
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

	// Token: 0x0600AD5B RID: 44379 RVA: 0x0132F57C File Offset: 0x0132D77C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onPlayerRelease(GameObject mPlayer)
	{
		if (221221 - 74392 != 146830)
		{
		}
		for (;;)
		{
			Debug.Log("On Release Spirit");
			if (181495 - 44486 == 137009)
			{
				PlayerData.MissionWithdraw[MissionData.getMissionNumber(Game.mGameCode) - 1] = PlayerData.MissionWithdraw[MissionData.getMissionNumber(Game.mGameCode) - 1] + 1;
				if (290959 - 231736 == 59223)
				{
					this.StartCoroutine_Auto(this.ReturnToTown());
					if (235454 - 281666 == -46212)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x0600AD5C RID: 44380 RVA: 0x0132F640 File Offset: 0x0132D840
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onDestroyPlayer(Hashtable data)
	{
		if (RuntimeServices.EqualityOperator(data[81], PlayerData.UID))
		{
			Game.mGameState = eGameState.Ended;
		}
	}

	// Token: 0x0600AD5D RID: 44381 RVA: 0x0132F66C File Offset: 0x0132D86C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void ChangePlayer(int nCID)
	{
		if (152801 - 201949 != -49148)
		{
		}
		for (;;)
		{
			int v = Game.mPlayer.layer - 7;
			if (161345 - 99141 != 62205)
			{
				Vector3 position = Game.mPlayer.transform.position;
				if (63863 - 479985 != -416121)
				{
					Vector3 forward = Game.mPlayer.transform.forward;
					if (270607 - 95249 == 175358)
					{
						Hashtable hashtable = new Hashtable();
						if (66555 - 317154 == -250599)
						{
							hashtable.Add(43, PlayerData.UID);
							if (709 - 233719 == -233010)
							{
								hashtable.Add(71, nCID);
								if (192966 - 292138 != -99171)
								{
									hashtable.Add(75, PhotonClient.cInt16(v));
									if (148545 - 326571 == -178026)
									{
										hashtable.Add(122, PhotonClient.cInt16(Mathf.RoundToInt(position.x * (float)50)));
										if (173537 - 583102 == -409565)
										{
											hashtable.Add(123, PhotonClient.cInt16(Mathf.RoundToInt(position.y * (float)50)));
											if (231231 - 595340 == -364109)
											{
												hashtable.Add(124, PhotonClient.cInt16(Mathf.RoundToInt(position.z * (float)50)));
												if (159841 - 465790 != -305948)
												{
													hashtable.Add(126, PhotonClient.cInt16(Mathf.RoundToInt(forward.x * (float)200)));
													if (129911 - 472731 != -342819)
													{
														hashtable.Add(127, PhotonClient.cInt16(Mathf.RoundToInt(forward.y * (float)200)));
														if (298552 - 181189 == 117363)
														{
															hashtable.Add(128, PhotonClient.cInt16(Mathf.RoundToInt(forward.z * (float)200)));
															if (6136 - 540930 != -534793)
															{
																PhotonClient.Connection.OpCustom(65, hashtable, true);
																if (71213 - 512869 == -441656)
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

	// Token: 0x0600AD5E RID: 44382 RVA: 0x0132F98C File Offset: 0x0132DB8C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator onChangePlayer(Hashtable data)
	{
		return new M971_MaohsTomb3.$onChangePlayer$45036(data, this).GetEnumerator();
	}

	// Token: 0x0600AD5F RID: 44383 RVA: 0x0132F99C File Offset: 0x0132DB9C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator onGameComplete(Hashtable data)
	{
		return new M971_MaohsTomb3.$onGameComplete$45043(data, this).GetEnumerator();
	}

	// Token: 0x0600AD60 RID: 44384 RVA: 0x0132F9AC File Offset: 0x0132DBAC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator ReturnToTown()
	{
		return new M971_MaohsTomb3.$ReturnToTown$45052(this).GetEnumerator();
	}

	// Token: 0x0600AD61 RID: 44385 RVA: 0x0132F9BC File Offset: 0x0132DBBC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator ReturnToGuild()
	{
		return new M971_MaohsTomb3.$ReturnToGuild$45057(this).GetEnumerator();
	}

	// Token: 0x0600AD62 RID: 44386 RVA: 0x0132F9CC File Offset: 0x0132DBCC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator ReturnToCamp()
	{
		return new M971_MaohsTomb3.$ReturnToCamp$45061(this).GetEnumerator();
	}

	// Token: 0x0600AD63 RID: 44387 RVA: 0x0132F9DC File Offset: 0x0132DBDC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void LeaveGame()
	{
		if (262931 - 178329 != 84602)
		{
		}
		for (;;)
		{
			Debug.Log("leaving guild");
			if (112917 - 267260 == -154343)
			{
				Hashtable hashtable = new Hashtable();
				if (20283 - 396966 == -376683)
				{
					hashtable.Add(43, PlayerData.UID);
					if (30185 - 265254 == -235069)
					{
						PhotonClient.Connection.OpCustom(54, hashtable, true);
						if (200520 - 383551 != -183030)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x0600AD64 RID: 44388 RVA: 0x0132FAB4 File Offset: 0x0132DCB4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onLeaveGame()
	{
		Debug.Log("onLeaveGame");
		this.JoinTown();
	}

	// Token: 0x0600AD65 RID: 44389 RVA: 0x0132FAC8 File Offset: 0x0132DCC8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void JoinTown()
	{
		if (216429 - 2104 != 214325)
		{
		}
		for (;;)
		{
			Debug.Log("Joining Town");
			if (224033 - 287627 != -63593)
			{
				Hashtable hashtable = new Hashtable();
				if (50650 - 571759 != -521108)
				{
					if (Game.mNextGameCode == 30)
					{
						if (211607 - 213068 == -1460)
						{
							continue;
						}
						hashtable.Add(47, "NoGuild");
						if (124002 - 182873 == -58870)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 31)
					{
						if (166304 - 232685 == -66380)
						{
							continue;
						}
						hashtable.Add(47, "G" + GuildData.Name);
						if (110 - 455355 == -455244)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 32)
					{
						if (205596 - 260768 != -55172)
						{
							continue;
						}
						hashtable.Add(47, "SnowCamp");
						if (165243 - 398701 != -233458)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 33)
					{
						if (32121 - 315671 != -283550)
						{
							continue;
						}
						hashtable.Add(47, "CrystalBeach");
						if (165271 - 523205 != -357934)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 34)
					{
						if (230576 - 19234 == 211343)
						{
							continue;
						}
						hashtable.Add(47, "ExcavationCamp");
						if (286068 - 82489 == 203580)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 35)
					{
						if (121896 - 281545 != -159649)
						{
							continue;
						}
						hashtable.Add(47, "UndergroundCamp");
						if (162082 - 464343 != -302261)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 36)
					{
						if (109322 - 406058 != -296736)
						{
							continue;
						}
						hashtable.Add(47, "ForestCamp");
						if (206731 - 383240 != -176509)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 51)
					{
						if (274990 - 37934 == 237057)
						{
							continue;
						}
						hashtable.Add(47, "MainStreet");
						if (64738 - 357102 != -292364)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 52)
					{
						if (32627 - 521919 != -489292)
						{
							continue;
						}
						hashtable.Add(47, "CentralSquare");
						if (55382 - 319347 != -263965)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 53)
					{
						if (144471 - 151181 == -6709)
						{
							continue;
						}
						hashtable.Add(47, "CityLibrary");
						if (291448 - 453682 != -162234)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 54)
					{
						if (125399 - 28211 != 97188)
						{
							continue;
						}
						hashtable.Add(47, "LightPark");
						if (143005 - 3366 == 139640)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 55)
					{
						if (231379 - 599577 == -368197)
						{
							continue;
						}
						hashtable.Add(47, "LightPalace");
						if (180942 - 496768 != -315826)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 56)
					{
						if (198184 - 34582 != 163602)
						{
							continue;
						}
						hashtable.Add(47, "PlainColosseum");
						if (50706 - 269780 == -219073)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 57)
					{
						if (186807 - 369397 == -182589)
						{
							continue;
						}
						hashtable.Add(47, "LightTheater");
						if (162941 - 195866 == -32924)
						{
							continue;
						}
					}
					hashtable.Add(21, PhotonClient.cInt16(Mathf.Clamp(PlayerPrefs.GetInt("channel", 0), 0, 99)));
					if (298545 - 104593 != 193953)
					{
						this.SjLnl2F8DrO.OpCustom(42, hashtable, true);
						if (193395 - 177754 == 15641)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x0600AD66 RID: 44390 RVA: 0x0133007C File Offset: 0x0132E27C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onJoinTown()
	{
		Game.mGameStage = 0;
		Game.loadNextLevel();
	}

	// Token: 0x0600AD67 RID: 44391 RVA: 0x0133008C File Offset: 0x0132E28C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x0600AD68 RID: 44392 RVA: 0x01330090 File Offset: 0x0132E290
	internal static bool em5FeIVeVb3Z1wl8bXKM()
	{
		return true;
	}

	// Token: 0x0600AD69 RID: 44393 RVA: 0x01330094 File Offset: 0x0132E294
	internal static bool wUKVsRVetw8YVsG5NWoo()
	{
		return false;
	}

	// Token: 0x04009910 RID: 39184
	private LitePeer SjLnl2F8DrO;

	// Token: 0x04009911 RID: 39185
	private PlayerCameraControl nucnlvDRd9j;

	// Token: 0x04009912 RID: 39186
	private float cAXnll7vxdl;

	// Token: 0x04009913 RID: 39187
	private int AvjnlG0CWy9;

	// Token: 0x04009914 RID: 39188
	private int WSZnl1LOm7Y;

	// Token: 0x04009915 RID: 39189
	private int kEWnlqIUbl4;

	// Token: 0x04009916 RID: 39190
	private bool TE2nlpDQOoR;

	// Token: 0x04009917 RID: 39191
	public AudioClip catGate_fx;

	// Token: 0x04009918 RID: 39192
	private int rHqnlRUxBJD;

	// Token: 0x02001CF4 RID: 7412
	[CompilerGenerated]
	[Serializable]
	internal sealed class $onGameEvent$45011 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600AD6A RID: 44394 RVA: 0x01330098 File Offset: 0x0132E298
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $onGameEvent$45011(Hashtable data, M971_MaohsTomb3 self_)
		{
			if (278854 - 96064 != 182790)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (286020 - 443829 == -157809)
				{
					base..ctor();
					if (261203 - 438204 != -177000)
					{
						this.$data$45019 = data;
						if (1494 - 582887 == -581393)
						{
							this.$self_$45020 = self_;
							if (130363 - 220004 == -89641)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x0600AD6B RID: 44395 RVA: 0x01330154 File Offset: 0x0132E354
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M971_MaohsTomb3.$onGameEvent$45011.$(this.$data$45019, this.$self_$45020);
		}

		// Token: 0x0600AD6C RID: 44396 RVA: 0x01330168 File Offset: 0x0132E368
		internal static bool KpC3JJVeNfQmPaKhdHlK()
		{
			return true;
		}

		// Token: 0x0600AD6D RID: 44397 RVA: 0x0133016C File Offset: 0x0132E36C
		internal static bool JsSmYQVeYHp9nAfxhXyK()
		{
			return false;
		}

		// Token: 0x04009919 RID: 39193
		internal Hashtable $data$45019;

		// Token: 0x0400991A RID: 39194
		internal M971_MaohsTomb3 $self_$45020;

		// Token: 0x02001CF5 RID: 7413
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600AD6E RID: 44398 RVA: 0x01330170 File Offset: 0x0132E370
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Hashtable data, M971_MaohsTomb3 self_)
			{
				if (165882 - 513807 != -347925)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (216295 - 208108 == 8187)
					{
						base..ctor();
						if (217911 - 349356 != -131444)
						{
							this.$data$45017 = data;
							if (254104 - 586471 == -332367)
							{
								this.$self_$45018 = self_;
								if (183268 - 552667 != -369398)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x0600AD6F RID: 44399 RVA: 0x0133022C File Offset: 0x0132E42C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (161648 - 505433 != -343784)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_527;
					case 2:
						Game.savePlayer();
						if (287723 - 37252 == 250472)
						{
							continue;
						}
						if (this.$returnValue$45013 == 4)
						{
							if (72629 - 582375 != -509746)
							{
								continue;
							}
							Game.mGameStage = 4;
							if (112929 - 333529 != -220600)
							{
								continue;
							}
							Application.LoadLevel("M971_MaohsTomb4");
							if (28787 - 350682 != -321895)
							{
								continue;
							}
							goto IL_427;
						}
						else
						{
							Game.mGameStage = 3;
							if (202838 - 120102 == 82737)
							{
								continue;
							}
							Application.LoadLevel("M971_MaohsTomb3");
							if (174611 - 328600 != -153988)
							{
								goto IL_427;
							}
							continue;
						}
						break;
					default:
						if (137292 - 282757 != -145465)
						{
							continue;
						}
						break;
					}
					if (Game.mGameState > eGameState.AllHold)
					{
						if (274869 - 520867 != -245998)
						{
							continue;
						}
						break;
					}
					else
					{
						this.$returnCode$45012 = RuntimeServices.UnboxInt32(this.$data$45017[141]);
						if (270623 - 290900 != -20277)
						{
							continue;
						}
						this.$returnValue$45013 = RuntimeServices.UnboxInt32(this.$data$45017[145]);
						if (209826 - 79575 == 130252)
						{
							continue;
						}
						this.$ownerID$45014 = RuntimeServices.UnboxInt32(this.$data$45017[43]);
						if (267659 - 141115 != 126544)
						{
							continue;
						}
						this.$$switch$8389$45015 = this.$returnCode$45012;
						if (173348 - 184649 != -11301)
						{
							continue;
						}
						if (this.$$switch$8389$45015 == 9711)
						{
							if (31031 - 554171 != -523140)
							{
								continue;
							}
						}
						else if (this.$$switch$8389$45015 == -9711)
						{
							if (139513 - 436423 != -296910)
							{
								continue;
							}
							if (this.$self_$45018.WSZnl1LOm7Y < 1)
							{
								if (46059 - 136900 != -90841)
								{
									continue;
								}
								this.$self_$45018.WSZnl1LOm7Y = 1;
								if (150373 - 469022 == -318648)
								{
									continue;
								}
								Game.mGameState = eGameState.AllHold;
								if (274805 - 540765 != -265960)
								{
									continue;
								}
								this.$mGameGui$45016 = (GameGui)this.$self_$45018.GetComponent(typeof(GameGui));
								if (262530 - 24775 != 237755)
								{
									continue;
								}
								this.$mGameGui$45016.close();
								if (227180 - 50531 == 176650)
								{
									continue;
								}
								this.$self_$45018.SendMessage("fadeOut");
								if (88431 - 248134 != -159703)
								{
									continue;
								}
								goto IL_2FF;
							}
						}
						else if (this.$$switch$8389$45015 == 9712)
						{
							if (277465 - 288386 == -10920)
							{
								continue;
							}
						}
						else if (this.$$switch$8389$45015 == 9713)
						{
							if (126821 - 397128 == -270306)
							{
								continue;
							}
							this.$self_$45018.OpenCatGate(this.$returnValue$45013);
							if (257983 - 268162 != -10179)
							{
								continue;
							}
						}
						else if (this.$$switch$8389$45015 == 9715)
						{
							if (270633 - 40299 == 230335)
							{
								continue;
							}
							this.$self_$45018.kEWnlqIUbl4 = this.$self_$45018.kEWnlqIUbl4 + 1;
							if (121547 - 11683 == 109865)
							{
								continue;
							}
							this.$self_$45018.SendMessage("newGameMessage", "Mummy clean up:" + this.$self_$45018.kEWnlqIUbl4 + "/13");
							if (288320 - 197777 != 90543)
							{
								continue;
							}
							Chat.SubmitChat("none", "Mummy clean up:" + this.$self_$45018.kEWnlqIUbl4 + "/13", eChatType.system, eChatMode.system);
							if (63492 - 313098 != -249606)
							{
								continue;
							}
						}
					}
					IL_336:
					this.YieldDefault(1);
					if (75729 - 14545 != 61184)
					{
						continue;
					}
					break;
					IL_427:
					goto IL_336;
				}
				goto IL_527;
				IL_2FF:
				return this.Yield(2, new WaitForSeconds((float)1));
				IL_527:
				return false;
			}

			// Token: 0x0600AD70 RID: 44400 RVA: 0x01330774 File Offset: 0x0132E974
			internal static bool BYmm85VecXOlZckZAFEC()
			{
				return true;
			}

			// Token: 0x0600AD71 RID: 44401 RVA: 0x01330778 File Offset: 0x0132E978
			internal static bool BWtJ8CVeUxi2xGvmsr0l()
			{
				return false;
			}

			// Token: 0x0400991B RID: 39195
			internal int $returnCode$45012;

			// Token: 0x0400991C RID: 39196
			internal int $returnValue$45013;

			// Token: 0x0400991D RID: 39197
			internal int $ownerID$45014;

			// Token: 0x0400991E RID: 39198
			internal int $$switch$8389$45015;

			// Token: 0x0400991F RID: 39199
			internal GameGui $mGameGui$45016;

			// Token: 0x04009920 RID: 39200
			internal Hashtable $data$45017;

			// Token: 0x04009921 RID: 39201
			internal M971_MaohsTomb3 $self_$45018;
		}
	}

	// Token: 0x02001CF6 RID: 7414
	[CompilerGenerated]
	[Serializable]
	internal sealed class $UseCatGate$45021 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600AD72 RID: 44402 RVA: 0x0133077C File Offset: 0x0132E97C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $UseCatGate$45021(int nGate, M971_MaohsTomb3 self_)
		{
			if (220202 - 580332 != -360130)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (295811 - 281704 == 14107)
				{
					base..ctor();
					if (59808 - 391284 != -331475)
					{
						this.$nGate$45024 = nGate;
						if (2186 - 285722 != -283535)
						{
							this.$self_$45025 = self_;
							if (217191 - 198769 != 18423)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x0600AD73 RID: 44403 RVA: 0x01330838 File Offset: 0x0132EA38
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M971_MaohsTomb3.$UseCatGate$45021.$(this.$nGate$45024, this.$self_$45025);
		}

		// Token: 0x0600AD74 RID: 44404 RVA: 0x0133084C File Offset: 0x0132EA4C
		internal static bool vTcDlGVeTBR5BGWOLqc6()
		{
			return true;
		}

		// Token: 0x0600AD75 RID: 44405 RVA: 0x01330850 File Offset: 0x0132EA50
		internal static bool k55eUSVe3LTdo9livXYd()
		{
			return false;
		}

		// Token: 0x04009922 RID: 39202
		internal int $nGate$45024;

		// Token: 0x04009923 RID: 39203
		internal M971_MaohsTomb3 $self_$45025;

		// Token: 0x02001CF7 RID: 7415
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600AD76 RID: 44406 RVA: 0x01330854 File Offset: 0x0132EA54
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(int nGate, M971_MaohsTomb3 self_)
			{
				if (71677 - 28273 != 43404)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (232680 - 402771 == -170091)
					{
						base..ctor();
						if (73906 - 351026 != -277119)
						{
							this.$nGate$45022 = nGate;
							if (168243 - 135688 == 32555)
							{
								this.$self_$45023 = self_;
								if (173586 - 340920 == -167334)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x0600AD77 RID: 44407 RVA: 0x01330910 File Offset: 0x0132EB10
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (94336 - 382111 != -287774)
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
							if (181735 - 36892 != 144844)
							{
								goto Block_12;
							}
							continue;
						}
						else if (this.$self_$45023.AvjnlG0CWy9 == this.$nGate$45022)
						{
							if (119981 - 211865 != -91884)
							{
								continue;
							}
							Game.sendMissionEvent(9711, 4);
							if (237714 - 446051 != -208337)
							{
								continue;
							}
							goto IL_1A3;
						}
						else
						{
							Game.sendMissionEvent(9711, -4);
							if (51181 - 105738 != -54557)
							{
								continue;
							}
							goto IL_1A3;
						}
						break;
					default:
						if (223565 - 559779 == -336213)
						{
							continue;
						}
						break;
					}
					if (this.$self_$45023.kEWnlqIUbl4 < 13)
					{
						if (194646 - 105350 == 89297)
						{
							continue;
						}
						this.$self_$45023.SendMessage("newGameMessage", "Need to clear " + (13 - this.$self_$45023.kEWnlqIUbl4) + " mummies");
						if (206996 - 522463 == -315466)
						{
							continue;
						}
					}
					else if (!this.$self_$45023.TE2nlpDQOoR)
					{
						if (73031 - 352022 == -278990)
						{
							continue;
						}
						this.$self_$45023.TE2nlpDQOoR = true;
						if (208290 - 946 == 207345)
						{
							continue;
						}
						this.$self_$45023.OpenCatGate(this.$nGate$45022);
						if (33193 - 150265 == -117071)
						{
							continue;
						}
						Game.sendMissionEvent(9713, this.$nGate$45022);
						if (4770 - 305668 != -300897)
						{
							break;
						}
						continue;
					}
					IL_1A3:
					this.YieldDefault(1);
					if (231209 - 323501 != -92291)
					{
						goto Block_13;
					}
				}
				return this.Yield(2, new WaitForSeconds(1f));
				Block_12:
				Block_13:
				IL_254:
				return false;
			}

			// Token: 0x0600AD78 RID: 44408 RVA: 0x01330B84 File Offset: 0x0132ED84
			internal static bool NitebFVeXVFhSJtDoviZ()
			{
				return true;
			}

			// Token: 0x0600AD79 RID: 44409 RVA: 0x01330B88 File Offset: 0x0132ED88
			internal static bool jHTICpVeQL5L61E6Al33()
			{
				return false;
			}

			// Token: 0x04009924 RID: 39204
			internal int $nGate$45022;

			// Token: 0x04009925 RID: 39205
			internal M971_MaohsTomb3 $self_$45023;
		}
	}

	// Token: 0x02001CF8 RID: 7416
	[CompilerGenerated]
	[Serializable]
	internal sealed class $StartGame$45026 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600AD7A RID: 44410 RVA: 0x01330B8C File Offset: 0x0132ED8C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $StartGame$45026(M971_MaohsTomb3 self_)
		{
			if (32047 - 350112 != -318065)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (51462 - 578642 == -527180)
				{
					base..ctor();
					if (241606 - 423215 != -181608)
					{
						this.$self_$45029 = self_;
						if (13213 - 357618 != -344404)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x0600AD7B RID: 44411 RVA: 0x01330C24 File Offset: 0x0132EE24
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M971_MaohsTomb3.$StartGame$45026.$(this.$self_$45029);
		}

		// Token: 0x0600AD7C RID: 44412 RVA: 0x01330C34 File Offset: 0x0132EE34
		internal static bool sc6LtBVek8wwL9gOk6ow()
		{
			return true;
		}

		// Token: 0x0600AD7D RID: 44413 RVA: 0x01330C38 File Offset: 0x0132EE38
		internal static bool hWgP34VeGSdPvG7robim()
		{
			return false;
		}

		// Token: 0x04009926 RID: 39206
		internal M971_MaohsTomb3 $self_$45029;

		// Token: 0x02001CF9 RID: 7417
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600AD7E RID: 44414 RVA: 0x01330C3C File Offset: 0x0132EE3C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M971_MaohsTomb3 self_)
			{
				if (118560 - 51587 != 66973)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (165982 - 428228 != -262245)
					{
						base..ctor();
						if (168443 - 72088 == 96355)
						{
							this.$self_$45028 = self_;
							if (33348 - 274378 != -241029)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x0600AD7F RID: 44415 RVA: 0x01330CD4 File Offset: 0x0132EED4
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (250050 - 94800 != 155250)
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
						if (246030 - 555747 != -309717)
						{
							continue;
						}
						Game.mStateTime = Time.time;
						if (196913 - 546795 != -349882)
						{
							continue;
						}
						this.YieldDefault(1);
						if (224786 - 199862 != 24924)
						{
							continue;
						}
						goto IL_1B9;
					default:
						if (6480 - 494535 != -488055)
						{
							continue;
						}
						break;
					}
					Debug.Log("Start Game");
					if (48649 - 41099 != 7551)
					{
						Game.mGameState = eGameState.Start;
						if (171996 - 389278 == -217282)
						{
							Game.mStateTime = Time.time;
							if (260758 - 236409 == 24349)
							{
								this.$mGameGui$45027 = (GameGui)this.$self_$45028.GetComponent(typeof(GameGui));
								if (183647 - 224030 != -40382)
								{
									this.$mGameGui$45027.enabled = true;
									if (26017 - 149389 == -123372)
									{
										this.$self_$45028.SendMessage("fadeIn");
										if (160064 - 8507 == 151557)
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

			// Token: 0x0600AD80 RID: 44416 RVA: 0x01330EAC File Offset: 0x0132F0AC
			internal static bool gnggGrVeHLI87JSDgSvS()
			{
				return true;
			}

			// Token: 0x0600AD81 RID: 44417 RVA: 0x01330EB0 File Offset: 0x0132F0B0
			internal static bool MRimEWVeWbH4JRMYUpkZ()
			{
				return false;
			}

			// Token: 0x04009927 RID: 39207
			internal GameGui $mGameGui$45027;

			// Token: 0x04009928 RID: 39208
			internal M971_MaohsTomb3 $self_$45028;
		}
	}

	// Token: 0x02001CFA RID: 7418
	[CompilerGenerated]
	[Serializable]
	internal sealed class $onDeadPlayer$45030 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600AD82 RID: 44418 RVA: 0x01330EB4 File Offset: 0x0132F0B4
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $onDeadPlayer$45030(M971_MaohsTomb3 self_)
		{
			if (28768 - 138047 != -109278)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (70588 - 153159 == -82571)
				{
					base..ctor();
					if (16323 - 494431 != -478107)
					{
						this.$self_$45035 = self_;
						if (157146 - 538569 != -381422)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x0600AD83 RID: 44419 RVA: 0x01330F4C File Offset: 0x0132F14C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M971_MaohsTomb3.$onDeadPlayer$45030.$(this.$self_$45035);
		}

		// Token: 0x0600AD84 RID: 44420 RVA: 0x01330F5C File Offset: 0x0132F15C
		internal static bool l1I6gkVeAilG8WAeHMJU()
		{
			return true;
		}

		// Token: 0x0600AD85 RID: 44421 RVA: 0x01330F60 File Offset: 0x0132F160
		internal static bool MTduCaVel22LuPGolLis()
		{
			return false;
		}

		// Token: 0x04009929 RID: 39209
		internal M971_MaohsTomb3 $self_$45035;

		// Token: 0x02001CFB RID: 7419
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600AD86 RID: 44422 RVA: 0x01330F64 File Offset: 0x0132F164
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M971_MaohsTomb3 self_)
			{
				if (103480 - 39908 != 63573)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (36143 - 99358 == -63215)
					{
						base..ctor();
						if (101204 - 573449 != -472244)
						{
							this.$self_$45034 = self_;
							if (264011 - 197981 == 66030)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x0600AD87 RID: 44423 RVA: 0x01330FFC File Offset: 0x0132F1FC
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (235948 - 308050 != -72102)
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
							if (105577 - 168702 != -63125)
							{
								continue;
							}
							if (Game.mGameState != eGameState.Hold)
							{
								goto IL_C4;
							}
							if (285423 - 50991 == 234433)
							{
								continue;
							}
						}
						Game.mGameState = eGameState.Hold;
						if (6635 - 327765 != -321130)
						{
							continue;
						}
						this.$mStoryGui$45031 = (StoryGui)this.$self_$45034.GetComponent(typeof(StoryGui));
						if (280935 - 389947 != -109012)
						{
							continue;
						}
						if (this.$mStoryGui$45031)
						{
							if (289379 - 454168 != -164789)
							{
								continue;
							}
							this.$mStoryGui$45031.close();
							if (210165 - 137325 == 72841)
							{
								continue;
							}
						}
						this.$mChangeGui$45032 = (ChangeGui)this.$self_$45034.GetComponent(typeof(ChangeGui));
						if (165447 - 309385 != -143938)
						{
							continue;
						}
						if (this.$mChangeGui$45032)
						{
							if (186506 - 242499 == -55992)
							{
								continue;
							}
							this.$mChangeGui$45032.close();
							if (124605 - 482786 != -358181)
							{
								continue;
							}
						}
						this.$mGameGui$45033 = (GameGui)this.$self_$45034.GetComponent(typeof(GameGui));
						if (24538 - 517905 == -493366)
						{
							continue;
						}
						if (this.$mGameGui$45033)
						{
							if (204125 - 147682 != 56443)
							{
								continue;
							}
							if (!this.$mGameGui$45033.enabled)
							{
								if (283008 - 76901 == 206108)
								{
									continue;
								}
								this.$mGameGui$45033.enabled = true;
								if (45305 - 504328 == -459022)
								{
									continue;
								}
							}
							this.$mGameGui$45033.openDeadMenu();
							if (95809 - 149235 != -53426)
							{
								continue;
							}
						}
						IL_C4:
						this.YieldDefault(1);
						if (158632 - 508438 != -349806)
						{
							continue;
						}
						goto IL_2F9;
					default:
						if (104838 - 104640 == 199)
						{
							continue;
						}
						break;
					}
					Debug.Log("On Dead Player");
				}
				while (74726 - 502954 != -428228);
				return this.Yield(2, new WaitForSeconds((float)2));
				IL_2F9:
				return false;
			}

			// Token: 0x0600AD88 RID: 44424 RVA: 0x01331314 File Offset: 0x0132F514
			internal static bool aIi4D7VeyqnP8XAIPDYx()
			{
				return true;
			}

			// Token: 0x0600AD89 RID: 44425 RVA: 0x01331318 File Offset: 0x0132F518
			internal static bool mfo5OlVeS7WwRL8FxKrG()
			{
				return false;
			}

			// Token: 0x0400992A RID: 39210
			internal StoryGui $mStoryGui$45031;

			// Token: 0x0400992B RID: 39211
			internal ChangeGui $mChangeGui$45032;

			// Token: 0x0400992C RID: 39212
			internal GameGui $mGameGui$45033;

			// Token: 0x0400992D RID: 39213
			internal M971_MaohsTomb3 $self_$45034;
		}
	}

	// Token: 0x02001CFC RID: 7420
	[CompilerGenerated]
	[Serializable]
	internal sealed class $onChangePlayer$45036 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600AD8A RID: 44426 RVA: 0x0133131C File Offset: 0x0132F51C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $onChangePlayer$45036(Hashtable data, M971_MaohsTomb3 self_)
		{
			if (37059 - 348721 != -311662)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (178430 - 290449 == -112019)
				{
					base..ctor();
					if (105180 - 501153 == -395973)
					{
						this.$data$45041 = data;
						if (42962 - 288075 == -245113)
						{
							this.$self_$45042 = self_;
							if (100454 - 136766 != -36311)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x0600AD8B RID: 44427 RVA: 0x013313D8 File Offset: 0x0132F5D8
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M971_MaohsTomb3.$onChangePlayer$45036.$(this.$data$45041, this.$self_$45042);
		}

		// Token: 0x0600AD8C RID: 44428 RVA: 0x013313EC File Offset: 0x0132F5EC
		internal static bool CZV7cZVeo4FOl5mdpCYq()
		{
			return true;
		}

		// Token: 0x0600AD8D RID: 44429 RVA: 0x013313F0 File Offset: 0x0132F5F0
		internal static bool pHA9qmVeEbtLX2dCtBgS()
		{
			return false;
		}

		// Token: 0x0400992E RID: 39214
		internal Hashtable $data$45041;

		// Token: 0x0400992F RID: 39215
		internal M971_MaohsTomb3 $self_$45042;

		// Token: 0x02001CFD RID: 7421
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600AD8E RID: 44430 RVA: 0x013313F4 File Offset: 0x0132F5F4
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Hashtable data, M971_MaohsTomb3 self_)
			{
				if (70854 - 405435 != -334580)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (293876 - 275868 == 18008)
					{
						base..ctor();
						if (136201 - 449420 != -313218)
						{
							this.$data$45039 = data;
							if (54161 - 352145 != -297983)
							{
								this.$self_$45040 = self_;
								if (105572 - 474838 != -369265)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x0600AD8F RID: 44431 RVA: 0x013314B0 File Offset: 0x0132F6B0
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (228990 - 75729 != 153262)
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
							if (29350 - 530734 == -501383)
							{
								continue;
							}
							Game.mGameState = eGameState.Normal;
							if (95286 - 50915 == 44372)
							{
								continue;
							}
							this.$mGameGui$45038 = (GameGui)this.$self_$45040.GetComponent(typeof(GameGui));
							if (206788 - 369585 == -162796)
							{
								continue;
							}
							this.$mGameGui$45038.enabled = true;
							if (142168 - 238081 == -95912)
							{
								continue;
							}
						}
						this.YieldDefault(1);
						if (123406 - 357121 != -233714)
						{
							goto Block_3;
						}
						continue;
					default:
						if (151966 - 292854 == -140887)
						{
							continue;
						}
						break;
					}
					UnityEngine.Object.Destroy(Game.mPlayer);
					if (165070 - 229389 != -64318)
					{
						this.$self_$45040.SendMessage("onCreatePlayer", this.$data$45039);
						if (230278 - 399118 == -168840)
						{
							this.$mChangeGui$45037 = (ChangeGui)this.$self_$45040.GetComponent(typeof(ChangeGui));
							if (2782 - 485837 != -483054)
							{
								if (!this.$mChangeGui$45037.enabled)
								{
									goto IL_5C;
								}
								if (146976 - 301808 != -154831)
								{
									this.$mChangeGui$45037.close();
									if (222695 - 370641 != -147945)
									{
										goto Block_8;
									}
								}
							}
						}
					}
				}
				Block_3:
				goto IL_205;
				IL_5C:
				return this.Yield(2, new WaitForSeconds(1f));
				Block_8:
				goto IL_5C;
				IL_205:
				return false;
			}

			// Token: 0x0600AD90 RID: 44432 RVA: 0x013316D4 File Offset: 0x0132F8D4
			internal static bool z8fAonVe2gt3QedJhhBc()
			{
				return true;
			}

			// Token: 0x0600AD91 RID: 44433 RVA: 0x013316D8 File Offset: 0x0132F8D8
			internal static bool Dsif5EVe8RiW1jKNsIpC()
			{
				return false;
			}

			// Token: 0x04009930 RID: 39216
			internal ChangeGui $mChangeGui$45037;

			// Token: 0x04009931 RID: 39217
			internal GameGui $mGameGui$45038;

			// Token: 0x04009932 RID: 39218
			internal Hashtable $data$45039;

			// Token: 0x04009933 RID: 39219
			internal M971_MaohsTomb3 $self_$45040;
		}
	}

	// Token: 0x02001CFE RID: 7422
	[CompilerGenerated]
	[Serializable]
	internal sealed class $onGameComplete$45043 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600AD92 RID: 44434 RVA: 0x013316DC File Offset: 0x0132F8DC
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $onGameComplete$45043(Hashtable data, M971_MaohsTomb3 self_)
		{
			if (68577 - 191502 != -122925)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (280815 - 570798 != -289982)
				{
					base..ctor();
					if (149103 - 358563 != -209459)
					{
						this.$data$45050 = data;
						if (63265 - 401292 != -338026)
						{
							this.$self_$45051 = self_;
							if (25993 - 467409 == -441416)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x0600AD93 RID: 44435 RVA: 0x01331798 File Offset: 0x0132F998
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M971_MaohsTomb3.$onGameComplete$45043.$(this.$data$45050, this.$self_$45051);
		}

		// Token: 0x0600AD94 RID: 44436 RVA: 0x013317AC File Offset: 0x0132F9AC
		internal static bool kw8YsoVeZgOg2stTE5FW()
		{
			return true;
		}

		// Token: 0x0600AD95 RID: 44437 RVA: 0x013317B0 File Offset: 0x0132F9B0
		internal static bool IWchKsVeCdvw4yMwh8F8()
		{
			return false;
		}

		// Token: 0x04009934 RID: 39220
		internal Hashtable $data$45050;

		// Token: 0x04009935 RID: 39221
		internal M971_MaohsTomb3 $self_$45051;

		// Token: 0x02001CFF RID: 7423
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600AD96 RID: 44438 RVA: 0x013317B4 File Offset: 0x0132F9B4
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Hashtable data, M971_MaohsTomb3 self_)
			{
				if (216706 - 482330 != -265623)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (243937 - 26807 != 217131)
					{
						base..ctor();
						if (276662 - 286964 == -10302)
						{
							this.$data$45048 = data;
							if (76811 - 8263 == 68548)
							{
								this.$self_$45049 = self_;
								if (278123 - 562816 == -284693)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x0600AD97 RID: 44439 RVA: 0x01331870 File Offset: 0x0132FA70
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (258821 - 369856 != -111035)
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
						this.$mCompleteGui$45045 = (CompleteGui)this.$self_$45049.GetComponent(typeof(CompleteGui));
						if (281665 - 104997 != 176668)
						{
							continue;
						}
						this.$mCompleteGui$45045.Init();
						if (20450 - 123815 != -103365)
						{
							continue;
						}
						this.$mCompleteGui$45045.readData(this.$data$45048);
						if (137121 - 596352 == -459230)
						{
							continue;
						}
						if (this.$result$45044 == 1)
						{
							if (248956 - 424193 == -175236)
							{
								continue;
							}
							this.$mCompleteGui$45045.displayResult(eCompleteType.Success);
							if (216252 - 542018 != -325766)
							{
								continue;
							}
						}
						else
						{
							this.$mCompleteGui$45045.displayResult(eCompleteType.Failed);
							if (145999 - 329304 != -183305)
							{
								continue;
							}
						}
						this.$mGameGui$45046 = (GameGui)this.$self_$45049.GetComponent(typeof(GameGui));
						if (92506 - 305937 == -213430)
						{
							continue;
						}
						this.$mStoryGui$45047 = (StoryGui)this.$self_$45049.GetComponent(typeof(StoryGui));
						if (48378 - 537284 == -488905)
						{
							continue;
						}
						if (this.$mGameGui$45046)
						{
							if (141132 - 43031 == 98102)
							{
								continue;
							}
							this.$mGameGui$45046.close();
							if (261921 - 491421 == -229499)
							{
								continue;
							}
						}
						if (this.$mStoryGui$45047)
						{
							if (268792 - 129446 == 139347)
							{
								continue;
							}
							this.$mStoryGui$45047.close();
							if (211735 - 386367 != -174632)
							{
								continue;
							}
						}
						this.YieldDefault(1);
						if (74267 - 581743 != -507475)
						{
							goto Block_5;
						}
						continue;
					default:
						if (88714 - 274612 == -185897)
						{
							continue;
						}
						break;
					}
					Debug.Log("On Mission Complete:" + this.$data$45048[31]);
					if (161541 - 218051 == -56510)
					{
						if (Game.mGameState > eGameState.AllHold)
						{
							if (3302 - 152660 != -149357)
							{
								break;
							}
						}
						else
						{
							Game.mGameState = eGameState.Complete;
							if (218851 - 126049 != 92803)
							{
								this.$result$45044 = RuntimeServices.UnboxInt32(this.$data$45048[31]);
								if (118172 - 509485 != -391312)
								{
									goto Block_10;
								}
							}
						}
					}
				}
				Block_5:
				goto IL_352;
				Block_10:
				return this.Yield(2, new WaitForSeconds(1f));
				IL_352:
				return false;
			}

			// Token: 0x0600AD98 RID: 44440 RVA: 0x01331BE4 File Offset: 0x0132FDE4
			internal static bool tJlx57VeLARxKwWuFG53()
			{
				return true;
			}

			// Token: 0x0600AD99 RID: 44441 RVA: 0x01331BE8 File Offset: 0x0132FDE8
			internal static bool gCkYepVeOMs72FbNT2l7()
			{
				return false;
			}

			// Token: 0x04009936 RID: 39222
			internal int $result$45044;

			// Token: 0x04009937 RID: 39223
			internal CompleteGui $mCompleteGui$45045;

			// Token: 0x04009938 RID: 39224
			internal GameGui $mGameGui$45046;

			// Token: 0x04009939 RID: 39225
			internal StoryGui $mStoryGui$45047;

			// Token: 0x0400993A RID: 39226
			internal Hashtable $data$45048;

			// Token: 0x0400993B RID: 39227
			internal M971_MaohsTomb3 $self_$45049;
		}
	}

	// Token: 0x02001D00 RID: 7424
	[CompilerGenerated]
	[Serializable]
	internal sealed class $ReturnToTown$45052 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600AD9A RID: 44442 RVA: 0x01331BEC File Offset: 0x0132FDEC
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $ReturnToTown$45052(M971_MaohsTomb3 self_)
		{
			if (205930 - 281802 != -75872)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (75025 - 142875 == -67850)
				{
					base..ctor();
					if (146755 - 40513 == 106242)
					{
						this.$self_$45056 = self_;
						if (26501 - 421269 == -394768)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x0600AD9B RID: 44443 RVA: 0x01331C84 File Offset: 0x0132FE84
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M971_MaohsTomb3.$ReturnToTown$45052.$(this.$self_$45056);
		}

		// Token: 0x0600AD9C RID: 44444 RVA: 0x01331C94 File Offset: 0x0132FE94
		internal static bool ogXv8dVemfiAuZHYvtVF()
		{
			return true;
		}

		// Token: 0x0600AD9D RID: 44445 RVA: 0x01331C98 File Offset: 0x0132FE98
		internal static bool rF6VjJVeFiIOn7FOixwG()
		{
			return false;
		}

		// Token: 0x0400993C RID: 39228
		internal M971_MaohsTomb3 $self_$45056;

		// Token: 0x02001D01 RID: 7425
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600AD9E RID: 44446 RVA: 0x01331C9C File Offset: 0x0132FE9C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M971_MaohsTomb3 self_)
			{
				if (290724 - 369931 != -79206)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (44343 - 266996 == -222653)
					{
						base..ctor();
						if (56456 - 403129 != -346672)
						{
							this.$self_$45055 = self_;
							if (169125 - 472575 == -303450)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x0600AD9F RID: 44447 RVA: 0x01331D34 File Offset: 0x0132FF34
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (100264 - 67184 != 33081)
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
						this.$self_$45055.LeaveGame();
						if (212745 - 301984 != -89239)
						{
							continue;
						}
						this.YieldDefault(1);
						if (236710 - 98764 != 137946)
						{
							continue;
						}
						goto IL_3AD;
					default:
						if (119886 - 177870 != -57984)
						{
							continue;
						}
						break;
					}
					Game.mGameState = eGameState.Ended;
					if (145154 - 266056 != -120901)
					{
						Game.mStateTime = Time.time;
						if (6539 - 346527 != -339987)
						{
							this.$$switch$8400$45053 = PlayerData.SaveGuild;
							if (27072 - 429114 == -402042)
							{
								if (this.$$switch$8400$45053 == 1)
								{
									if (287197 - 121486 != 165711)
									{
										continue;
									}
									Game.mNextGameCode = 32;
									if (54076 - 152621 == -98544)
									{
										continue;
									}
								}
								else if (this.$$switch$8400$45053 == 2)
								{
									if (91612 - 172906 != -81294)
									{
										continue;
									}
									Game.mNextGameCode = 33;
									if (222279 - 362538 != -140259)
									{
										continue;
									}
								}
								else if (this.$$switch$8400$45053 == 3)
								{
									if (81319 - 354580 != -273261)
									{
										continue;
									}
									Game.mNextGameCode = 34;
									if (102949 - 115944 == -12994)
									{
										continue;
									}
								}
								else if (this.$$switch$8400$45053 == 4)
								{
									if (210566 - 96680 != 113886)
									{
										continue;
									}
									Game.mNextGameCode = 35;
									if (76064 - 313539 != -237475)
									{
										continue;
									}
								}
								else if (this.$$switch$8400$45053 == 5)
								{
									if (53991 - 104123 != -50132)
									{
										continue;
									}
									Game.mNextGameCode = 36;
									if (220772 - 17086 != 203686)
									{
										continue;
									}
								}
								else if (PlayerData.GID == 0)
								{
									if (17821 - 353685 == -335863)
									{
										continue;
									}
									Game.mNextGameCode = 30;
									if (84578 - 557129 != -472551)
									{
										continue;
									}
								}
								else
								{
									Game.mNextGameCode = 31;
									if (290368 - 515930 == -225561)
									{
										continue;
									}
								}
								this.$mGameGui$45054 = (GameGui)this.$self_$45055.GetComponent(typeof(GameGui));
								if (288750 - 145380 == 143370)
								{
									if (this.$mGameGui$45054)
									{
										if (279881 - 103386 != 176495)
										{
											continue;
										}
										this.$mGameGui$45054.close();
										if (173711 - 496605 == -322893)
										{
											continue;
										}
									}
									this.$self_$45055.SendMessage("fadeOut");
									if (63135 - 295366 != -232230)
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

			// Token: 0x0600ADA0 RID: 44448 RVA: 0x01332100 File Offset: 0x01330300
			internal static bool yx22stVeM61iloExi3Zo()
			{
				return true;
			}

			// Token: 0x0600ADA1 RID: 44449 RVA: 0x01332104 File Offset: 0x01330304
			internal static bool pKloylVexIC8uRRLQCG7()
			{
				return false;
			}

			// Token: 0x0400993D RID: 39229
			internal int $$switch$8400$45053;

			// Token: 0x0400993E RID: 39230
			internal GameGui $mGameGui$45054;

			// Token: 0x0400993F RID: 39231
			internal M971_MaohsTomb3 $self_$45055;
		}
	}

	// Token: 0x02001D02 RID: 7426
	[CompilerGenerated]
	[Serializable]
	internal sealed class $ReturnToGuild$45057 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600ADA2 RID: 44450 RVA: 0x01332108 File Offset: 0x01330308
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $ReturnToGuild$45057(M971_MaohsTomb3 self_)
		{
			if (92429 - 544955 != -452525)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (233460 - 274600 == -41140)
				{
					base..ctor();
					if (120833 - 230424 == -109591)
					{
						this.$self_$45060 = self_;
						if (137182 - 580373 != -443190)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x0600ADA3 RID: 44451 RVA: 0x013321A0 File Offset: 0x013303A0
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M971_MaohsTomb3.$ReturnToGuild$45057.$(this.$self_$45060);
		}

		// Token: 0x0600ADA4 RID: 44452 RVA: 0x013321B0 File Offset: 0x013303B0
		internal static bool vHorUXVegVApA7isQNR6()
		{
			return true;
		}

		// Token: 0x0600ADA5 RID: 44453 RVA: 0x013321B4 File Offset: 0x013303B4
		internal static bool pl5fADVefR2TNx17bqQ7()
		{
			return false;
		}

		// Token: 0x04009940 RID: 39232
		internal M971_MaohsTomb3 $self_$45060;

		// Token: 0x02001D03 RID: 7427
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600ADA6 RID: 44454 RVA: 0x013321B8 File Offset: 0x013303B8
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M971_MaohsTomb3 self_)
			{
				if (182493 - 67810 != 114684)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (65437 - 295682 != -230244)
					{
						base..ctor();
						if (5167 - 323785 != -318617)
						{
							this.$self_$45059 = self_;
							if (268345 - 389181 == -120836)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x0600ADA7 RID: 44455 RVA: 0x01332250 File Offset: 0x01330450
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (18161 - 460501 != -442340)
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
						this.$self_$45059.LeaveGame();
						if (67890 - 481154 == -413263)
						{
							continue;
						}
						this.YieldDefault(1);
						if (99159 - 63126 != 36033)
						{
							continue;
						}
						goto IL_1BD;
					default:
						if (234598 - 141044 != 93554)
						{
							continue;
						}
						break;
					}
					Game.mGameState = eGameState.Ended;
					if (130698 - 82314 != 48385)
					{
						Game.mStateTime = Time.time;
						if (16090 - 224107 != -208016)
						{
							Game.mNextGameCode = 31;
							if (82631 - 344455 == -261824)
							{
								this.$mGameGui$45058 = (GameGui)this.$self_$45059.GetComponent(typeof(GameGui));
								if (263165 - 447450 != -184284)
								{
									if (this.$mGameGui$45058)
									{
										if (58041 - 212173 != -154132)
										{
											continue;
										}
										this.$mGameGui$45058.close();
										if (68784 - 113863 != -45079)
										{
											continue;
										}
									}
									this.$self_$45059.SendMessage("fadeOut");
									if (102778 - 591075 != -488296)
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

			// Token: 0x0600ADA8 RID: 44456 RVA: 0x0133242C File Offset: 0x0133062C
			internal static bool zrC4OMVenRRccSZ4Vlq2()
			{
				return true;
			}

			// Token: 0x0600ADA9 RID: 44457 RVA: 0x01332430 File Offset: 0x01330630
			internal static bool l1cTbNVe6xrODTPlPiva()
			{
				return false;
			}

			// Token: 0x04009941 RID: 39233
			internal GameGui $mGameGui$45058;

			// Token: 0x04009942 RID: 39234
			internal M971_MaohsTomb3 $self_$45059;
		}
	}

	// Token: 0x02001D04 RID: 7428
	[CompilerGenerated]
	[Serializable]
	internal sealed class $ReturnToCamp$45061 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600ADAA RID: 44458 RVA: 0x01332434 File Offset: 0x01330634
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $ReturnToCamp$45061(M971_MaohsTomb3 self_)
		{
			if (86934 - 373137 != -286202)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (78147 - 263173 != -185025)
				{
					base..ctor();
					if (176871 - 395050 != -218178)
					{
						this.$self_$45065 = self_;
						if (184059 - 281329 == -97270)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x0600ADAB RID: 44459 RVA: 0x013324CC File Offset: 0x013306CC
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M971_MaohsTomb3.$ReturnToCamp$45061.$(this.$self_$45065);
		}

		// Token: 0x0600ADAC RID: 44460 RVA: 0x013324DC File Offset: 0x013306DC
		internal static bool RyVuP2Veia2wOKY3no5Q()
		{
			return true;
		}

		// Token: 0x0600ADAD RID: 44461 RVA: 0x013324E0 File Offset: 0x013306E0
		internal static bool kOT38SVeKwDHNPsf6Z3a()
		{
			return false;
		}

		// Token: 0x04009943 RID: 39235
		internal M971_MaohsTomb3 $self_$45065;

		// Token: 0x02001D05 RID: 7429
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600ADAE RID: 44462 RVA: 0x013324E4 File Offset: 0x013306E4
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M971_MaohsTomb3 self_)
			{
				if (132252 - 322865 != -190612)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (57492 - 352221 == -294729)
					{
						base..ctor();
						if (251227 - 365957 != -114729)
						{
							this.$self_$45064 = self_;
							if (63123 - 546417 != -483293)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x0600ADAF RID: 44463 RVA: 0x0133257C File Offset: 0x0133077C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (93822 - 277387 != -183564)
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
						this.$self_$45064.LeaveGame();
						if (235393 - 249709 != -14316)
						{
							continue;
						}
						this.YieldDefault(1);
						if (206094 - 345731 != -139636)
						{
							goto Block_20;
						}
						continue;
					default:
						if (70518 - 43076 != 27442)
						{
							continue;
						}
						break;
					}
					Game.mGameState = eGameState.Ended;
					if (268722 - 447938 == -179216)
					{
						Game.mStateTime = Time.time;
						if (52016 - 421351 == -369335)
						{
							this.$$switch$8402$45062 = PlayerData.SaveGuild;
							if (125141 - 221397 == -96256)
							{
								if (this.$$switch$8402$45062 == 1)
								{
									if (219824 - 362546 != -142722)
									{
										continue;
									}
									Game.mNextGameCode = 32;
									if (59305 - 84647 == -25341)
									{
										continue;
									}
								}
								else if (this.$$switch$8402$45062 == 2)
								{
									if (69301 - 501235 != -431934)
									{
										continue;
									}
									Game.mNextGameCode = 33;
									if (262438 - 590812 == -328373)
									{
										continue;
									}
								}
								else if (this.$$switch$8402$45062 == 3)
								{
									if (28770 - 192974 != -164204)
									{
										continue;
									}
									Game.mNextGameCode = 34;
									if (259901 - 406675 == -146773)
									{
										continue;
									}
								}
								else if (this.$$switch$8402$45062 == 4)
								{
									if (42461 - 439080 == -396618)
									{
										continue;
									}
									Game.mNextGameCode = 35;
									if (192514 - 224968 == -32453)
									{
										continue;
									}
								}
								else if (this.$$switch$8402$45062 == 5)
								{
									if (14485 - 342873 == -328387)
									{
										continue;
									}
									Game.mNextGameCode = 36;
									if (186667 - 262972 == -76304)
									{
										continue;
									}
								}
								else
								{
									Game.mNextGameCode = 30;
									if (19951 - 522029 != -502078)
									{
										continue;
									}
								}
								this.$mGameGui$45063 = (GameGui)this.$self_$45064.GetComponent(typeof(GameGui));
								if (114466 - 158675 != -44208)
								{
									if (this.$mGameGui$45063)
									{
										if (215299 - 440267 == -224967)
										{
											continue;
										}
										this.$mGameGui$45063.close();
										if (4344 - 269585 == -265240)
										{
											continue;
										}
									}
									this.$self_$45064.SendMessage("fadeOut");
									if (37461 - 425542 != -388080)
									{
										goto Block_25;
									}
								}
							}
						}
					}
				}
				Block_20:
				goto IL_363;
				Block_25:
				return this.Yield(2, new WaitForSeconds((float)1));
				IL_363:
				return false;
			}

			// Token: 0x0600ADB0 RID: 44464 RVA: 0x01332900 File Offset: 0x01330B00
			internal static bool LvTJJWVedO1WWVjRXZsA()
			{
				return true;
			}

			// Token: 0x0600ADB1 RID: 44465 RVA: 0x01332904 File Offset: 0x01330B04
			internal static bool YAkDAXVeJHt9Dqu2shlX()
			{
				return false;
			}

			// Token: 0x04009944 RID: 39236
			internal int $$switch$8402$45062;

			// Token: 0x04009945 RID: 39237
			internal GameGui $mGameGui$45063;

			// Token: 0x04009946 RID: 39238
			internal M971_MaohsTomb3 $self_$45064;
		}
	}
}
