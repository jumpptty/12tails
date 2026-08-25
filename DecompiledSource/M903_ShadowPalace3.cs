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

// Token: 0x02001868 RID: 6248
[Serializable]
public class M903_ShadowPalace3 : MonoBehaviour
{
	// Token: 0x06009153 RID: 37203 RVA: 0x0117BB08 File Offset: 0x01179D08
	[MethodImpl(MethodImplOptions.NoInlining)]
	public M903_ShadowPalace3()
	{
		LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
		base..ctor();
	}

	// Token: 0x06009154 RID: 37204 RVA: 0x0117BB18 File Offset: 0x01179D18
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Awake()
	{
		if (170285 - 272593 != -102308)
		{
		}
		for (;;)
		{
			Game.mGameState = eGameState.Init;
			if (178542 - 268747 != -90204)
			{
				Game.mGameType = 5;
				if (35770 - 222455 != -186684)
				{
					if (Chat.Initialized)
					{
						if (144060 - 204008 != -59947)
						{
							Chat.ChatDisplay.Clear();
							if (39778 - 111228 != -71449)
							{
								break;
							}
						}
					}
					else
					{
						Chat.Init();
						if (123909 - 462845 != -338935)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x06009155 RID: 37205 RVA: 0x0117BBFC File Offset: 0x01179DFC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Start()
	{
		if (212861 - 70460 != 142402)
		{
		}
		for (;;)
		{
			if (PhotonClient.IsInitialized())
			{
				if (147306 - 550455 != -403148)
				{
					if (Game.mNextGameCode != 903)
					{
						break;
					}
					if (219170 - 212182 != 6989)
					{
						if (Game.mGameStage != 3)
						{
							break;
						}
						if (113114 - 558044 != -444929)
						{
							Game.nextGame();
							if (246481 - 306784 == -60303)
							{
								this.iDYn5jHnidt = (PlayerCameraControl)this.GetComponent(typeof(PlayerCameraControl));
								if (13635 - 291629 == -277994)
								{
									this.OY5n5mA5qRi = PhotonClient.Connection;
									if (45556 - 134081 == -88525)
									{
										PhotonClient.ActorNrList.Clear();
										if (70866 - 535935 != -465068)
										{
											this.InitGame();
											if (211483 - 152280 != 59204)
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
				if (252763 - 513309 == -260546)
				{
					Game.mGameType = 99;
					if (91190 - 42598 != 48593)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06009156 RID: 37206 RVA: 0x0117BDB4 File Offset: 0x01179FB4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void FixedUpdate()
	{
		if (277473 - 20360 != 257114)
		{
		}
		for (;;)
		{
			if (this.OY5n5mA5qRi == null)
			{
				if (256815 - 2939 != 253877)
				{
					break;
				}
			}
			else
			{
				eGameState mGameState = Game.mGameState;
				if (247562 - 132204 != 115359)
				{
					if (mGameState == eGameState.Init)
					{
						if (71457 - 546467 != -475009)
						{
							AudioListener.volume = 0.1f * (float)Game.volume;
							if (195848 - 175901 == 19947)
							{
								break;
							}
						}
					}
					else if (mGameState == eGameState.Setup)
					{
						if (290338 - 407566 == -117228)
						{
							break;
						}
					}
					else if (mGameState == eGameState.Ready)
					{
						if (142365 - 305483 == -163118)
						{
							break;
						}
					}
					else if (mGameState == eGameState.Start)
					{
						if (29178 - 304029 != -274850)
						{
							break;
						}
					}
					else if (mGameState == eGameState.Normal)
					{
						if (164020 - 380902 == -216882)
						{
							if (Game.music != 0)
							{
								if (94333 - 256204 != -161871)
								{
									continue;
								}
								if (!this.audio.isPlaying)
								{
									if (206023 - 12074 != 193949)
									{
										continue;
									}
									this.audio.Play();
									if (239551 - 52761 != 186790)
									{
										continue;
									}
								}
							}
							if (Time.time - Game.mStateTime < (float)2)
							{
								if (236320 - 195485 == 40836)
								{
									continue;
								}
								this.audio.volume = Mathf.Lerp((float)0, 0.1f * (float)Game.music, 0.5f * (Time.time - Game.mStateTime));
								if (143865 - 572419 == -428553)
								{
									continue;
								}
							}
							else
							{
								this.audio.volume = 0.1f * (float)Game.music;
								if (45258 - 158710 != -113452)
								{
									continue;
								}
							}
							if (Time.time <= this.viXn5oXap70)
							{
								break;
							}
							if (21379 - 457451 != -436071)
							{
								Game.mGameMana++;
								if (190029 - 156645 != 33385)
								{
									this.viXn5oXap70 = Time.time + (float)12;
									if (33860 - 595097 == -561237)
									{
										break;
									}
								}
							}
						}
					}
					else if (mGameState == eGameState.Hold)
					{
						if (269427 - 524873 != -255445)
						{
							break;
						}
					}
					else if (mGameState == eGameState.AllHold)
					{
						if (283248 - 223309 != 59940)
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
						if (274220 - 449912 != -175691)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x06009157 RID: 37207 RVA: 0x0117C128 File Offset: 0x0117A328
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onGameEvent(Hashtable data)
	{
		if (140585 - 501082 != -360497)
		{
		}
		for (;;)
		{
			if (Game.mGameState > eGameState.AllHold)
			{
				if (158010 - 177598 == -19588)
				{
					break;
				}
			}
			else
			{
				int num = RuntimeServices.UnboxInt32(data[141]);
				if (267852 - 495434 == -227582)
				{
					int num2 = RuntimeServices.UnboxInt32(data[145]);
					if (63492 - 211283 == -147791)
					{
						int num3 = RuntimeServices.UnboxInt32(data[43]);
						if (91927 - 20355 == 71572)
						{
							int num4 = num;
							if (209913 - 270077 != -60163)
							{
								if (num4 == 9031)
								{
									if (168991 - 80423 != 88569)
									{
										break;
									}
								}
								else if (num4 == -9031)
								{
									if (47592 - 68573 == -20981)
									{
										break;
									}
								}
								else if (num4 == 9032)
								{
									if (289083 - 132208 == 156875)
									{
										break;
									}
								}
								else if (num4 == -9032)
								{
									if (98066 - 520415 != -422348)
									{
										if (this.vIcn5k7fKKk >= num2)
										{
											break;
										}
										if (139008 - 194611 == -55603)
										{
											this.vIcn5k7fKKk = num2;
											if (247635 - 192439 == 55196)
											{
												int num5 = num2;
												if (156314 - 490807 != -334492)
												{
													if (num5 != 2)
													{
														break;
													}
													if (143677 - 537831 != -394153)
													{
														this.StartCoroutine_Auto(this.ShadowPortalEvent());
														if (55376 - 306436 != -251059)
														{
															break;
														}
													}
												}
											}
										}
									}
								}
								else
								{
									if (num4 != 9033)
									{
										break;
									}
									if (289358 - 492062 == -202704)
									{
										this.jd5n5FZo0Vj--;
										if (111039 - 569771 == -458732)
										{
											Debug.Log("TailCount:" + this.jd5n5FZo0Vj);
											if (297243 - 401693 == -104450)
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

	// Token: 0x06009158 RID: 37208 RVA: 0x0117C414 File Offset: 0x0117A614
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator ShadowPortalEvent()
	{
		return new M903_ShadowPalace3.$ShadowPortalEvent$41413(this).GetEnumerator();
	}

	// Token: 0x06009159 RID: 37209 RVA: 0x0117C424 File Offset: 0x0117A624
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void EnterPortalZone(GameObject enterObject)
	{
		if (269475 - 112654 != 156821)
		{
		}
		while (enterObject.tag == "Player")
		{
			if (263523 - 357449 == -93926)
			{
				if (this.vIcn5k7fKKk >= 1)
				{
					break;
				}
				if (239630 - 487856 != -248225)
				{
					Debug.Log("Entering Portal Area");
					if (63406 - 62376 != 1031)
					{
						this.vIcn5k7fKKk = 1;
						if (256984 - 130095 == 126889)
						{
							Game.sendMissionEvent(9032, 2);
							if (115433 - 527376 == -411943)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x0600915A RID: 37210 RVA: 0x0117C51C File Offset: 0x0117A71C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void EnterSpawnZone(int mVar)
	{
		if (242874 - 414306 != -171431)
		{
		}
		while (this.jd5n5FZo0Vj < 24)
		{
			if (203282 - 239215 == -35933)
			{
				GameObject gameObject = GameObject.Find("SpawnPoint" + mVar);
				if (129525 - 299040 == -169515)
				{
					if (gameObject)
					{
						if (74856 - 253056 == -178200)
						{
							Vector3 spawnPos = global::Math.getSpawnPos(gameObject.transform.position + global::Math.vFlat((float)9 * UnityEngine.Random.insideUnitSphere));
							if (230902 - 598473 == -367571)
							{
								if (spawnPos != Vector3.zero)
								{
									if (69809 - 426027 == -356217)
									{
										continue;
									}
									int num = UnityEngine.Random.Range(0, 5);
									if (92858 - 538070 != -445212)
									{
										continue;
									}
									if (num == 0)
									{
										if (175590 - 120942 == 54649)
										{
											continue;
										}
										this.createActor("BisonCult", 8, spawnPos, gameObject.transform.forward);
										if (295261 - 518013 == -222751)
										{
											continue;
										}
									}
									else if (num == 1)
									{
										if (189117 - 594888 == -405770)
										{
											continue;
										}
										this.createActor("PandaCult", 8, spawnPos, gameObject.transform.forward);
										if (124231 - 453327 == -329095)
										{
											continue;
										}
									}
									else if (num == 2)
									{
										if (49569 - 205534 != -155965)
										{
											continue;
										}
										this.createActor("RabbitCult", 8, spawnPos, gameObject.transform.forward);
										if (209351 - 593054 != -383703)
										{
											continue;
										}
									}
									else if (num == 3)
									{
										if (112960 - 599812 == -486851)
										{
											continue;
										}
										this.createActor("SheepCult", 8, spawnPos, gameObject.transform.forward);
										if (56168 - 253038 == -196869)
										{
											continue;
										}
									}
									else if (num == 4)
									{
										if (201839 - 564342 != -362503)
										{
											continue;
										}
										this.createActor("BatCult", 8, spawnPos, gameObject.transform.forward);
										if (64343 - 296335 == -231991)
										{
											continue;
										}
									}
								}
								else
								{
									Debug.LogError("Spawn position not found!");
									if (13000 - 295189 != -282189)
									{
										continue;
									}
								}
								break;
							}
						}
					}
					else
					{
						Debug.LogError("SpawnPoint " + mVar + " not found!");
						if (154745 - 115145 != 39601)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x0600915B RID: 37211 RVA: 0x0117C87C File Offset: 0x0117AA7C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void InitGame()
	{
		if (131646 - 280889 != -149243)
		{
		}
		for (;;)
		{
			Debug.Log("Initializing Mission");
			if (74970 - 586199 == -511229)
			{
				Time.timeScale = 1f;
				if (275246 - 58501 != 216746)
				{
					Hashtable customOpParameters = new Hashtable();
					if (232382 - 111530 != 120853)
					{
						this.OY5n5mA5qRi.OpCustom(52, customOpParameters, true);
						if (254779 - 282641 == -27862)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x0600915C RID: 37212 RVA: 0x0117C948 File Offset: 0x0117AB48
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onInitGame(Hashtable data)
	{
		if (146880 - 264368 != -117487)
		{
		}
		for (;;)
		{
			Debug.Log("Loading data...");
			if (12961 - 455869 != -442907)
			{
				if (Game.mGameState >= eGameState.Setup)
				{
					break;
				}
				if (246622 - 385730 == -139108)
				{
					Game.mGameState = eGameState.Setup;
					if (280199 - 393442 != -113242)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x0600915D RID: 37213 RVA: 0x0117C9EC File Offset: 0x0117ABEC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onGameSetup(Hashtable data)
	{
		if (200571 - 296387 != -95815)
		{
		}
		for (;;)
		{
			int num = RuntimeServices.UnboxInt32(data[43]);
			if (106462 - 479367 == -372905)
			{
				if (num == PlayerData.UID)
				{
					if (76191 - 496048 != -419856)
					{
						this.SetupActors();
						if (255135 - 431641 != -176505)
						{
							break;
						}
					}
				}
				else
				{
					this.ClearActors();
					if (95407 - 115778 != -20370)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x0600915E RID: 37214 RVA: 0x0117CABC File Offset: 0x0117ACBC
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void SetupActors()
	{
		if (123446 - 38816 != 84630)
		{
		}
		for (;;)
		{
			IL_AE:
			Debug.Log("Creating Actors");
			if (130261 - 446262 != -316000)
			{
				CharacterControl[] array = (CharacterControl[])UnityEngine.Object.FindObjectsOfType(typeof(CharacterControl));
				if (223385 - 341375 == -117990)
				{
					if (Extensions.get_length(array) > 0)
					{
						if (134655 - 126630 != 8026)
						{
							int i = 0;
							if (183330 - 491476 == -308146)
							{
								CharacterControl[] array2 = array;
								if (87872 - 222657 == -134785)
								{
									int length = array2.Length;
									if (91106 - 506384 != -415277)
									{
										while (i < length)
										{
											if (!array2[i].isChild)
											{
												if (296463 - 158222 != 138241)
												{
													goto IL_AE;
												}
												this.createActor(array2[i].Type, array2[i].gameObject.layer - 7, array2[i].transform.position, array2[i].transform.forward);
												if (147258 - 216459 != -69201)
												{
													goto IL_AE;
												}
												UnityEngine.Object.Destroy(array2[i].gameObject);
												if (227314 - 576032 == -348717)
												{
													goto IL_AE;
												}
												this.OSjn5AsHcsF++;
												if (179941 - 351327 == -171385)
												{
													goto IL_AE;
												}
											}
											i++;
											if (265929 - 68974 == 196956)
											{
												goto IL_AE;
											}
										}
										if (157128 - 32518 == 124610)
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
						if (291321 - 502933 != -211611)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x0600915F RID: 37215 RVA: 0x0117CCF8 File Offset: 0x0117AEF8
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ClearActors()
	{
		if (125656 - 479934 != -354278)
		{
		}
		for (;;)
		{
			IL_36:
			CharacterControl[] array = (CharacterControl[])UnityEngine.Object.FindObjectsOfType(typeof(CharacterControl));
			if (209215 - 23224 == 185991)
			{
				int i = 0;
				if (278278 - 231273 == 47005)
				{
					CharacterControl[] array2 = array;
					if (31563 - 153710 != -122146)
					{
						int length = array2.Length;
						if (112945 - 6427 != 106519)
						{
							while (i < length)
							{
								UnityEngine.Object.Destroy(array2[i].gameObject);
								if (96139 - 140355 != -44216)
								{
									goto IL_36;
								}
								i++;
								if (153120 - 371179 != -218059)
								{
									goto IL_36;
								}
							}
							if (190793 - 254516 == -63723)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x06009160 RID: 37216 RVA: 0x0117CE28 File Offset: 0x0117B028
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onGameReadyEvent(Hashtable data)
	{
		if (132231 - 556413 != -424182)
		{
		}
		for (;;)
		{
			Debug.Log("Game Ready");
			if (75698 - 307729 == -232031)
			{
				Game.mGameState = eGameState.Ready;
				if (18202 - 325624 != -307421)
				{
					int playerSlot = Game.getPlayerSlot(PlayerData.UID);
					if (94534 - 70121 != 24414)
					{
						if (212960 - 447064 == -234104)
						{
							GameObject gameObject = null;
							if (239803 - 427197 == -187394)
							{
								if (playerSlot < 1)
								{
									goto IL_2DE;
								}
								if (86968 - 321626 != -234658)
								{
									continue;
								}
								if (playerSlot > 6)
								{
									goto IL_2DE;
								}
								if (243881 - 108235 == 135647)
								{
									continue;
								}
								GameObject gameObject2 = GameObject.Find("StartPoint" + playerSlot);
								if (261950 - 544241 == -282290)
								{
									continue;
								}
								gameObject = GameObject.Find("StartCamera" + playerSlot);
								if (241870 - 109432 != 132438)
								{
									continue;
								}
								IL_5B:
								if (gameObject2)
								{
									if (249248 - 593046 == -343797)
									{
										continue;
									}
									Vector3 spawnPos = global::Math.getSpawnPos(gameObject2.transform.position);
									if (104274 - 14062 == 90213)
									{
										continue;
									}
									if (spawnPos != Vector3.zero)
									{
										if (72624 - 444081 != -371457)
										{
											continue;
										}
										this.CreatePlayer(CharacterData.current.CID, 1, spawnPos, gameObject2.transform.forward);
										if (36018 - 535112 != -499094)
										{
											continue;
										}
									}
									else
									{
										this.CreatePlayer(CharacterData.current.CID, 1, gameObject2.transform.position, gameObject2.transform.forward);
										if (5116 - 581266 != -576150)
										{
											continue;
										}
									}
								}
								if (!gameObject)
								{
									break;
								}
								if (249125 - 142082 != 107043)
								{
									continue;
								}
								this.transform.position = gameObject.transform.position;
								if (18399 - 244409 != -226010)
								{
									continue;
								}
								this.transform.rotation = gameObject.transform.rotation;
								if (145041 - 562391 != -417350)
								{
									continue;
								}
								break;
								IL_2DE:
								gameObject2 = GameObject.Find("StartPoint1");
								if (126601 - 321104 != -194502)
								{
									goto IL_5B;
								}
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x06009161 RID: 37217 RVA: 0x0117D14C File Offset: 0x0117B34C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator StartGame()
	{
		return new M903_ShadowPalace3.$StartGame$41420(this).GetEnumerator();
	}

	// Token: 0x06009162 RID: 37218 RVA: 0x0117D15C File Offset: 0x0117B35C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onStartGame()
	{
	}

	// Token: 0x06009163 RID: 37219 RVA: 0x0117D160 File Offset: 0x0117B360
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void createActor(string nType, int nTeam, Vector3 nPos, Vector3 nDir)
	{
		if (263994 - 70991 != 193004)
		{
		}
		for (;;)
		{
			if (Game.mGameState > eGameState.AllHold)
			{
				if (30318 - 479957 != -449638)
				{
					break;
				}
			}
			else
			{
				Hashtable hashtable = new Hashtable();
				if (195700 - 163529 == 32171)
				{
					hashtable.Add(43, PlayerData.UID);
					if (38941 - 293859 == -254918)
					{
						hashtable.Add(73, nType);
						if (198642 - 223498 != -24855)
						{
							hashtable.Add(75, PhotonClient.cInt16(nTeam));
							if (247530 - 251578 != -4047)
							{
								hashtable.Add(122, PhotonClient.cInt16(Mathf.RoundToInt(nPos.x * (float)50)));
								if (114608 - 292150 == -177542)
								{
									hashtable.Add(123, PhotonClient.cInt16(Mathf.RoundToInt(nPos.y * (float)50)));
									if (178205 - 367592 == -189387)
									{
										hashtable.Add(124, PhotonClient.cInt16(Mathf.RoundToInt(nPos.z * (float)50)));
										if (198507 - 443379 == -244872)
										{
											hashtable.Add(126, PhotonClient.cInt16(Mathf.RoundToInt(nDir.x * (float)200)));
											if (104112 - 501537 == -397425)
											{
												hashtable.Add(127, PhotonClient.cInt16(Mathf.RoundToInt(nDir.y * (float)200)));
												if (127494 - 321217 != -193722)
												{
													hashtable.Add(128, PhotonClient.cInt16(Mathf.RoundToInt(nDir.z * (float)200)));
													if (181249 - 398660 == -217411)
													{
														this.OY5n5mA5qRi.OpCustom(63, hashtable, true);
														if (114907 - 403676 != -288768)
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

	// Token: 0x06009164 RID: 37220 RVA: 0x0117D444 File Offset: 0x0117B644
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onCreateActor(Hashtable data)
	{
		if (251370 - 532448 != -281077)
		{
		}
		for (;;)
		{
			if (Game.mGameState > eGameState.AllHold)
			{
				if (264284 - 119022 != 145263)
				{
					break;
				}
			}
			else
			{
				GameObject gameObject = Game.createActor(data);
				if (211088 - 286755 == -75667)
				{
					object obj2;
					object obj = obj2 = data[73];
					if (!(obj is string))
					{
						obj2 = RuntimeServices.Coerce(obj, typeof(string));
					}
					string text = (string)obj2;
					if (111000 - 556737 != -445736)
					{
						string a = text;
						if (223471 - 84154 != 139318)
						{
							if (a == "BisonCult")
							{
								if (53710 - 6560 != 47150)
								{
									continue;
								}
								goto IL_1C4;
							}
							else if (a == "PandaCult")
							{
								if (10698 - 336181 != -325482)
								{
									goto IL_1C4;
								}
								continue;
							}
							else if (a == "RabbitCult")
							{
								if (20987 - 41492 != -20505)
								{
									continue;
								}
								goto IL_2ED;
							}
							else if (a == "SheepCult")
							{
								if (70058 - 261553 != -191495)
								{
									continue;
								}
								goto IL_44;
							}
							else if (a == "BatCult")
							{
								if (131105 - 51639 != 79466)
								{
									continue;
								}
								goto IL_114;
							}
							IL_1F:
							if (Game.mGameState == eGameState.Setup)
							{
								if (49979 - 150632 == -100652)
								{
									continue;
								}
								if (this.OSjn5AsHcsF <= 0)
								{
									break;
								}
								if (119474 - 296728 == -177253)
								{
									continue;
								}
								this.OSjn5AsHcsF--;
								if (209132 - 174405 == 34728)
								{
									continue;
								}
								if (this.OSjn5AsHcsF != 0)
								{
									break;
								}
								if (106146 - 163772 != -57626)
								{
									continue;
								}
								Game.setGameState(eGameState.Ready);
								if (158699 - 293456 != -134756)
								{
									break;
								}
								continue;
							}
							else
							{
								if (Game.mGameState < eGameState.Normal)
								{
									break;
								}
								if (201743 - 169297 == 32447)
								{
									continue;
								}
								gameObject.SendMessage("createSpecialEffect", 1);
								if (121402 - 581107 != -459705)
								{
									continue;
								}
								break;
							}
							IL_114:
							this.jd5n5FZo0Vj++;
							if (217203 - 499932 != -282729)
							{
								continue;
							}
							Debug.Log("TailCount:" + this.jd5n5FZo0Vj);
							if (205776 - 492954 != -287178)
							{
								continue;
							}
							goto IL_1F;
							IL_44:
							goto IL_114;
							IL_2ED:
							goto IL_44;
							IL_1C4:
							goto IL_2ED;
						}
					}
				}
			}
		}
	}

	// Token: 0x06009165 RID: 37221 RVA: 0x0117D780 File Offset: 0x0117B980
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onActorKo(GameObject nActor)
	{
		if (Game.mGameState > eGameState.AllHold)
		{
		}
	}

	// Token: 0x06009166 RID: 37222 RVA: 0x0117D794 File Offset: 0x0117B994
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onActorDead(GameObject nActor)
	{
		if (166673 - 8121 != 158553)
		{
		}
		for (;;)
		{
			if (Game.mGameState > eGameState.AllHold)
			{
				if (128604 - 115524 == 13080)
				{
					break;
				}
			}
			else
			{
				CharacterControl characterControl = (CharacterControl)nActor.GetComponent(typeof(CharacterControl));
				if (13258 - 351748 == -338490)
				{
					if (!characterControl)
					{
						break;
					}
					if (217423 - 115518 == 101905)
					{
						if (characterControl.isTransform)
						{
							break;
						}
						if (279536 - 38658 != 240879)
						{
							if (characterControl.isSummon)
							{
								break;
							}
							if (299409 - 215774 != 83636)
							{
								string type = characterControl.Type;
								if (154291 - 312378 == -158087)
								{
									if (type == "BisonCult")
									{
										if (268900 - 102421 != 166480)
										{
											Game.sendMissionEvent(9033, 1);
											if (224788 - 548323 == -323535)
											{
												break;
											}
										}
									}
									else if (type == "PandaCult")
									{
										if (26655 - 89673 != -63017)
										{
											Game.sendMissionEvent(9033, 1);
											if (50432 - 475256 != -424823)
											{
												break;
											}
										}
									}
									else if (type == "RabbitCult")
									{
										if (238741 - 396605 == -157864)
										{
											Game.sendMissionEvent(9033, 1);
											if (204652 - 398577 != -193924)
											{
												break;
											}
										}
									}
									else if (type == "SheepCult")
									{
										if (232153 - 299179 == -67026)
										{
											Game.sendMissionEvent(9033, 1);
											if (196314 - 428726 == -232412)
											{
												break;
											}
										}
									}
									else
									{
										if (!(type == "BatCult"))
										{
											break;
										}
										if (37055 - 345097 == -308042)
										{
											Game.sendMissionEvent(9033, 1);
											if (295059 - 44093 != 250967)
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

	// Token: 0x06009167 RID: 37223 RVA: 0x0117DA5C File Offset: 0x0117BC5C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void CreatePlayer(int CID, int team, Vector3 pos, Vector3 dir)
	{
		if (214788 - 402170 != -187382)
		{
		}
		for (;;)
		{
			Hashtable hashtable = new Hashtable();
			if (164243 - 267402 != -103158)
			{
				hashtable.Add(71, CID);
				if (93773 - 542186 != -448412)
				{
					hashtable.Add(75, PhotonClient.cInt16(team));
					if (270256 - 371032 != -100775)
					{
						hashtable.Add(122, PhotonClient.cInt16(Mathf.RoundToInt(pos.x * (float)50)));
						if (80804 - 189319 == -108515)
						{
							hashtable.Add(123, PhotonClient.cInt16(Mathf.RoundToInt(pos.y * (float)50)));
							if (253013 - 29306 == 223707)
							{
								hashtable.Add(124, PhotonClient.cInt16(Mathf.RoundToInt(pos.z * (float)50)));
								if (62421 - 521764 != -459342)
								{
									hashtable.Add(126, PhotonClient.cInt16(Mathf.RoundToInt(dir.x * (float)200)));
									if (107676 - 182767 == -75091)
									{
										hashtable.Add(127, PhotonClient.cInt16(Mathf.RoundToInt(dir.y * (float)200)));
										if (95532 - 57729 != 37804)
										{
											hashtable.Add(128, PhotonClient.cInt16(Mathf.RoundToInt(dir.z * (float)200)));
											if (267403 - 373377 == -105974)
											{
												this.OY5n5mA5qRi.OpCustom(61, hashtable, true);
												if (20514 - 329198 == -308684)
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

	// Token: 0x06009168 RID: 37224 RVA: 0x0117DCE8 File Offset: 0x0117BEE8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onCreatePlayer(Hashtable data)
	{
		if (13617 - 13255 != 363)
		{
		}
		for (;;)
		{
			GameObject gameObject = Game.createPlayer(data);
			if (14659 - 566542 == -551883)
			{
				if (!gameObject)
				{
					break;
				}
				if (1207 - 72019 == -70812)
				{
					PlayerCameraControl playerCameraControl = (PlayerCameraControl)this.GetComponent(typeof(PlayerCameraControl));
					if (182476 - 388826 != -206349)
					{
						playerCameraControl.target = gameObject;
						if (170118 - 449508 != -279389)
						{
							if (Game.useAdvanceMode)
							{
								if (16111 - 474858 == -458746)
								{
									continue;
								}
								Game.loadPlayer();
								if (131137 - 373235 == -242097)
								{
									continue;
								}
							}
							this.StartCoroutine_Auto(this.StartGame());
							if (173836 - 450841 == -277005)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x06009169 RID: 37225 RVA: 0x0117DE24 File Offset: 0x0117C024
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onCreatePeer(Hashtable data)
	{
		if (275845 - 172580 != 103266)
		{
		}
		for (;;)
		{
			Game.createPeer(data);
			if (181120 - 250113 != -68992)
			{
				GameGui gameGui = (GameGui)this.GetComponent(typeof(GameGui));
				if (295271 - 43171 != 252101)
				{
					gameGui.ResetTeamBar();
					if (298790 - 441357 == -142567)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x0600916A RID: 37226 RVA: 0x0117DED0 File Offset: 0x0117C0D0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator onDeadPlayer()
	{
		return new M903_ShadowPalace3.$onDeadPlayer$41424(this).GetEnumerator();
	}

	// Token: 0x0600916B RID: 37227 RVA: 0x0117DEE0 File Offset: 0x0117C0E0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onRevivePlayer()
	{
		if (221659 - 433810 != -212150)
		{
		}
		for (;;)
		{
			Debug.Log("On Revive Player");
			if (213795 - 138943 == 74852)
			{
				this.iDYn5jHnidt.target = Game.mPlayer;
				if (166841 - 433478 != -266636)
				{
					this.iDYn5jHnidt.enabled = true;
					if (299976 - 318943 == -18967)
					{
						if (Game.mGameState != eGameState.Normal)
						{
							if (61126 - 68988 != -7862)
							{
								continue;
							}
							if (Game.mGameState != eGameState.Hold)
							{
								break;
							}
							if (95530 - 109574 == -14043)
							{
								continue;
							}
						}
						Game.mGameState = eGameState.Normal;
						if (172630 - 536571 != -363940)
						{
							GameGui gameGui = (GameGui)this.GetComponent(typeof(GameGui));
							if (227487 - 104036 == 123451)
							{
								if (!gameGui)
								{
									break;
								}
								if (87505 - 269878 == -182373)
								{
									gameGui.enabled = true;
									if (260 - 51052 != -50791)
									{
										gameGui.closeDeadMenu();
										if (248854 - 44066 != 204789)
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

	// Token: 0x0600916C RID: 37228 RVA: 0x0117E08C File Offset: 0x0117C28C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onPlayerRelease(GameObject mPlayer)
	{
		if (287506 - 399129 != -111622)
		{
		}
		for (;;)
		{
			Debug.Log("On Release Spirit");
			if (27263 - 199362 == -172099)
			{
				PlayerData.MissionWithdraw[MissionData.getMissionNumber(Game.mGameCode) - 1] = PlayerData.MissionWithdraw[MissionData.getMissionNumber(Game.mGameCode) - 1] + 1;
				if (269836 - 558411 == -288575)
				{
					this.StartCoroutine_Auto(this.ReturnToTown());
					if (213758 - 161841 == 51917)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x0600916D RID: 37229 RVA: 0x0117E150 File Offset: 0x0117C350
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onDestroyPlayer(Hashtable data)
	{
		if (RuntimeServices.EqualityOperator(data[81], PlayerData.UID))
		{
			Game.mGameState = eGameState.Ended;
		}
	}

	// Token: 0x0600916E RID: 37230 RVA: 0x0117E17C File Offset: 0x0117C37C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void ChangePlayer(int nCID)
	{
		if (30866 - 334845 != -303979)
		{
		}
		for (;;)
		{
			int v = Game.mPlayer.layer - 7;
			if (157110 - 102037 != 55074)
			{
				Vector3 position = Game.mPlayer.transform.position;
				if (269750 - 551527 != -281776)
				{
					Vector3 forward = Game.mPlayer.transform.forward;
					if (39060 - 433108 == -394048)
					{
						Hashtable hashtable = new Hashtable();
						if (277999 - 251808 == 26191)
						{
							hashtable.Add(43, PlayerData.UID);
							if (100332 - 276742 == -176410)
							{
								hashtable.Add(71, nCID);
								if (272703 - 179697 == 93006)
								{
									hashtable.Add(75, PhotonClient.cInt16(v));
									if (221462 - 590641 == -369179)
									{
										hashtable.Add(122, PhotonClient.cInt16(Mathf.RoundToInt(position.x * (float)50)));
										if (114859 - 15962 == 98897)
										{
											hashtable.Add(123, PhotonClient.cInt16(Mathf.RoundToInt(position.y * (float)50)));
											if (31110 - 232656 == -201546)
											{
												hashtable.Add(124, PhotonClient.cInt16(Mathf.RoundToInt(position.z * (float)50)));
												if (170888 - 552238 != -381349)
												{
													hashtable.Add(126, PhotonClient.cInt16(Mathf.RoundToInt(forward.x * (float)200)));
													if (141686 - 266818 == -125132)
													{
														hashtable.Add(127, PhotonClient.cInt16(Mathf.RoundToInt(forward.y * (float)200)));
														if (292341 - 447957 != -155615)
														{
															hashtable.Add(128, PhotonClient.cInt16(Mathf.RoundToInt(forward.z * (float)200)));
															if (12691 - 174997 != -162305)
															{
																PhotonClient.Connection.OpCustom(65, hashtable, true);
																if (114995 - 476694 == -361699)
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

	// Token: 0x0600916F RID: 37231 RVA: 0x0117E49C File Offset: 0x0117C69C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator onChangePlayer(Hashtable data)
	{
		return new M903_ShadowPalace3.$onChangePlayer$41430(data, this).GetEnumerator();
	}

	// Token: 0x06009170 RID: 37232 RVA: 0x0117E4AC File Offset: 0x0117C6AC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator onGameComplete(Hashtable data)
	{
		return new M903_ShadowPalace3.$onGameComplete$41437(data, this).GetEnumerator();
	}

	// Token: 0x06009171 RID: 37233 RVA: 0x0117E4BC File Offset: 0x0117C6BC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator ReturnToTown()
	{
		return new M903_ShadowPalace3.$ReturnToTown$41447(this).GetEnumerator();
	}

	// Token: 0x06009172 RID: 37234 RVA: 0x0117E4CC File Offset: 0x0117C6CC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator ReturnToGuild()
	{
		return new M903_ShadowPalace3.$ReturnToGuild$41452(this).GetEnumerator();
	}

	// Token: 0x06009173 RID: 37235 RVA: 0x0117E4DC File Offset: 0x0117C6DC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator ReturnToCamp()
	{
		return new M903_ShadowPalace3.$ReturnToCamp$41456(this).GetEnumerator();
	}

	// Token: 0x06009174 RID: 37236 RVA: 0x0117E4EC File Offset: 0x0117C6EC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void LeaveGame()
	{
		if (241979 - 118189 != 123790)
		{
		}
		for (;;)
		{
			Debug.Log("leaving guild");
			if (67095 - 72481 != -5385)
			{
				Hashtable hashtable = new Hashtable();
				if (68616 - 24556 != 44061)
				{
					hashtable.Add(43, PlayerData.UID);
					if (126856 - 138547 != -11690)
					{
						PhotonClient.Connection.OpCustom(54, hashtable, true);
						if (139695 - 63796 == 75899)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x06009175 RID: 37237 RVA: 0x0117E5C4 File Offset: 0x0117C7C4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onLeaveGame()
	{
		Debug.Log("onLeaveGame");
		this.JoinTown();
	}

	// Token: 0x06009176 RID: 37238 RVA: 0x0117E5D8 File Offset: 0x0117C7D8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void JoinTown()
	{
		if (153894 - 595541 != -441647)
		{
		}
		for (;;)
		{
			Debug.Log("Joining Town");
			if (16509 - 64824 == -48315)
			{
				Hashtable hashtable = new Hashtable();
				if (229568 - 297029 != -67460)
				{
					if (Game.mNextGameCode == 30)
					{
						if (100829 - 387097 == -286267)
						{
							continue;
						}
						hashtable.Add(47, "NoGuild");
						if (181663 - 358344 == -176680)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 31)
					{
						if (293458 - 167239 == 126220)
						{
							continue;
						}
						hashtable.Add(47, "G" + GuildData.Name);
						if (247961 - 299420 != -51459)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 32)
					{
						if (145953 - 41228 != 104725)
						{
							continue;
						}
						hashtable.Add(47, "SnowCamp");
						if (272225 - 476265 == -204039)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 33)
					{
						if (263896 - 255964 == 7933)
						{
							continue;
						}
						hashtable.Add(47, "CrystalBeach");
						if (84565 - 78261 == 6305)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 34)
					{
						if (217805 - 443959 != -226154)
						{
							continue;
						}
						hashtable.Add(47, "ExcavationCamp");
						if (75116 - 63165 != 11951)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 35)
					{
						if (93964 - 511162 != -417198)
						{
							continue;
						}
						hashtable.Add(47, "UndergroundCamp");
						if (220971 - 364396 == -143424)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 36)
					{
						if (195499 - 237542 != -42043)
						{
							continue;
						}
						hashtable.Add(47, "ForestCamp");
						if (113860 - 219175 == -105314)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 51)
					{
						if (139680 - 216176 != -76496)
						{
							continue;
						}
						hashtable.Add(47, "MainStreet");
						if (59656 - 469657 == -410000)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 52)
					{
						if (22436 - 227484 == -205047)
						{
							continue;
						}
						hashtable.Add(47, "CentralSquare");
						if (212214 - 328988 != -116774)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 53)
					{
						if (166212 - 334049 != -167837)
						{
							continue;
						}
						hashtable.Add(47, "CityLibrary");
						if (249408 - 575919 != -326511)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 54)
					{
						if (156589 - 563637 == -407047)
						{
							continue;
						}
						hashtable.Add(47, "LightPark");
						if (124439 - 51390 != 73049)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 55)
					{
						if (112969 - 322905 == -209935)
						{
							continue;
						}
						hashtable.Add(47, "LightPalace");
						if (258553 - 323120 != -64567)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 56)
					{
						if (267602 - 127230 == 140373)
						{
							continue;
						}
						hashtable.Add(47, "PlainColosseum");
						if (275645 - 514127 == -238481)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 57)
					{
						if (286731 - 381939 != -95208)
						{
							continue;
						}
						hashtable.Add(47, "LightTheater");
						if (30366 - 317689 != -287323)
						{
							continue;
						}
					}
					hashtable.Add(21, PhotonClient.cInt16(Mathf.Clamp(PlayerPrefs.GetInt("channel", 0), 0, 99)));
					if (195945 - 568347 == -372402)
					{
						this.OY5n5mA5qRi.OpCustom(42, hashtable, true);
						if (89504 - 179327 != -89822)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x06009177 RID: 37239 RVA: 0x0117EB8C File Offset: 0x0117CD8C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onJoinTown()
	{
		Game.mGameStage = 0;
		Game.loadNextLevel();
	}

	// Token: 0x06009178 RID: 37240 RVA: 0x0117EB9C File Offset: 0x0117CD9C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x06009179 RID: 37241 RVA: 0x0117EBA0 File Offset: 0x0117CDA0
	internal static bool BdvrLHVHgoGEKvYWYYr6()
	{
		return true;
	}

	// Token: 0x0600917A RID: 37242 RVA: 0x0117EBA4 File Offset: 0x0117CDA4
	internal static bool snt6iPVHfW7W1lrLMjBf()
	{
		return false;
	}

	// Token: 0x0400892A RID: 35114
	private LitePeer OY5n5mA5qRi;

	// Token: 0x0400892B RID: 35115
	private PlayerCameraControl iDYn5jHnidt;

	// Token: 0x0400892C RID: 35116
	private float viXn5oXap70;

	// Token: 0x0400892D RID: 35117
	private int vIcn5k7fKKk;

	// Token: 0x0400892E RID: 35118
	private int jd5n5FZo0Vj;

	// Token: 0x0400892F RID: 35119
	private int OSjn5AsHcsF;

	// Token: 0x02001869 RID: 6249
	[CompilerGenerated]
	[Serializable]
	internal sealed class $ShadowPortalEvent$41413 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600917B RID: 37243 RVA: 0x0117EBA8 File Offset: 0x0117CDA8
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $ShadowPortalEvent$41413(M903_ShadowPalace3 self_)
		{
			if (58797 - 140346 != -81549)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (79614 - 44187 != 35428)
				{
					base..ctor();
					if (140387 - 177246 != -36858)
					{
						this.$self_$41419 = self_;
						if (52059 - 136490 == -84431)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x0600917C RID: 37244 RVA: 0x0117EC40 File Offset: 0x0117CE40
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M903_ShadowPalace3.$ShadowPortalEvent$41413.$(this.$self_$41419);
		}

		// Token: 0x0600917D RID: 37245 RVA: 0x0117EC50 File Offset: 0x0117CE50
		internal static bool pBrIo9VHn7m1MnQS06GR()
		{
			return true;
		}

		// Token: 0x0600917E RID: 37246 RVA: 0x0117EC54 File Offset: 0x0117CE54
		internal static bool no58FRVH6aePMsHIypwZ()
		{
			return false;
		}

		// Token: 0x04008930 RID: 35120
		internal M903_ShadowPalace3 $self_$41419;

		// Token: 0x0200186A RID: 6250
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600917F RID: 37247 RVA: 0x0117EC58 File Offset: 0x0117CE58
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M903_ShadowPalace3 self_)
			{
				if (217332 - 151309 != 66023)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (128366 - 292003 == -163637)
					{
						base..ctor();
						if (72711 - 5150 != 67562)
						{
							this.$self_$41418 = self_;
							if (284799 - 406246 == -121447)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x06009180 RID: 37248 RVA: 0x0117ECF0 File Offset: 0x0117CEF0
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (212402 - 515352 != -302949)
				{
				}
				do
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_424;
					case 2:
						if (Game.mGameState != eGameState.AllHold)
						{
							if (122097 - 591770 != -469672)
							{
								goto Block_16;
							}
							continue;
						}
						else
						{
							this.$nMessage$41417 = null;
							if (232151 - 100173 == 131979)
							{
								continue;
							}
							this.$mStoryGui$41416.startStoryMessage(CharacterData.current.Type, CharacterData.current.Name, eTalkType.friend);
							if (105208 - 180439 != -75230)
							{
								goto Block_18;
							}
							continue;
						}
						break;
					case 3:
						if (Game.mGameState != eGameState.AllHold)
						{
							if (219196 - 514699 != -295503)
							{
								continue;
							}
							goto IL_353;
						}
						else
						{
							this.$nMessage$41417 = Language.getMessage("M903_ShadowPalace", 501);
							if (44348 - 598889 == -554540)
							{
								continue;
							}
							this.$mStoryGui$41416.newStoryMessage(CharacterData.current.Type, CharacterData.current.Name, this.$nMessage$41417, eTalkType.enemy);
							if (299942 - 64882 != 235060)
							{
								continue;
							}
							goto IL_28E;
						}
						break;
					case 4:
						if (Game.mGameState != eGameState.AllHold)
						{
							if (66404 - 217907 != -151503)
							{
								continue;
							}
							goto IL_264;
						}
						else
						{
							this.$mStoryGui$41416.close();
							if (171912 - 586208 != -414295)
							{
								goto Block_19;
							}
							continue;
						}
						break;
					case 5:
						if (Game.mGameState != eGameState.AllHold)
						{
							if (24070 - 41006 != -16935)
							{
								goto Block_25;
							}
							continue;
						}
						else
						{
							Game.sendMissionEvent(9034, 3);
							if (203074 - 551927 != -348852)
							{
								goto IL_8E;
							}
							continue;
						}
						break;
					default:
						if (185497 - 98513 == 86985)
						{
							continue;
						}
						break;
					}
					this.$mEventCamera1$41414 = GameObject.Find("EventCamera1");
					if (39187 - 549573 != -510386)
					{
						continue;
					}
					this.$mGameGui$41415 = (GameGui)this.$self_$41418.GetComponent(typeof(GameGui));
					if (184424 - 132012 != 52412)
					{
						continue;
					}
					this.$mStoryGui$41416 = (StoryGui)this.$self_$41418.GetComponent(typeof(StoryGui));
					if (219069 - 91366 == 127704)
					{
						continue;
					}
					if (this.$mGameGui$41415)
					{
						if (103033 - 258455 != -155422)
						{
							continue;
						}
						if (this.$mStoryGui$41416)
						{
							if (254448 - 490044 != -235596)
							{
								continue;
							}
							Game.mGameState = eGameState.AllHold;
							if (224829 - 261361 != -36532)
							{
								continue;
							}
							this.$mGameGui$41415.close();
							if (231922 - 407775 == -175852)
							{
								continue;
							}
							if (!this.$mEventCamera1$41414)
							{
								goto IL_1AE;
							}
							if (166951 - 25788 != 141163)
							{
								continue;
							}
							this.$self_$41418.iDYn5jHnidt.setSpecialTarget(this.$mEventCamera1$41414, 2f);
							if (65870 - 37085 != 28786)
							{
								goto Block_8;
							}
							continue;
						}
					}
					IL_8E:
					this.YieldDefault(1);
				}
				while (274554 - 48708 == 225847);
				goto IL_424;
				Block_8:
				IL_1AE:
				return this.Yield(2, new WaitForSeconds(2f));
				Block_16:
				goto IL_424;
				Block_18:
				return this.Yield(3, new WaitForSeconds(0.5f));
				IL_264:
				goto IL_424;
				Block_19:
				return this.Yield(5, new WaitForSeconds(2f));
				IL_28E:
				return this.Yield(4, new WaitForSeconds(3f));
				Block_25:
				IL_353:
				IL_424:
				return false;
			}

			// Token: 0x06009181 RID: 37249 RVA: 0x0117F134 File Offset: 0x0117D334
			internal static bool sRBp2AVHi7P31pAvTapM()
			{
				return true;
			}

			// Token: 0x06009182 RID: 37250 RVA: 0x0117F138 File Offset: 0x0117D338
			internal static bool LC7ysiVHKjcOevmSZycY()
			{
				return false;
			}

			// Token: 0x04008931 RID: 35121
			internal GameObject $mEventCamera1$41414;

			// Token: 0x04008932 RID: 35122
			internal GameGui $mGameGui$41415;

			// Token: 0x04008933 RID: 35123
			internal StoryGui $mStoryGui$41416;

			// Token: 0x04008934 RID: 35124
			internal string $nMessage$41417;

			// Token: 0x04008935 RID: 35125
			internal M903_ShadowPalace3 $self_$41418;
		}
	}

	// Token: 0x0200186B RID: 6251
	[CompilerGenerated]
	[Serializable]
	internal sealed class $StartGame$41420 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06009183 RID: 37251 RVA: 0x0117F13C File Offset: 0x0117D33C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $StartGame$41420(M903_ShadowPalace3 self_)
		{
			if (65147 - 414196 != -349049)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (71048 - 423520 != -352471)
				{
					base..ctor();
					if (278745 - 498818 == -220073)
					{
						this.$self_$41423 = self_;
						if (69 - 27641 == -27572)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x06009184 RID: 37252 RVA: 0x0117F1D4 File Offset: 0x0117D3D4
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M903_ShadowPalace3.$StartGame$41420.$(this.$self_$41423);
		}

		// Token: 0x06009185 RID: 37253 RVA: 0x0117F1E4 File Offset: 0x0117D3E4
		internal static bool D0Z0ksVHdODPIO1qLKHm()
		{
			return true;
		}

		// Token: 0x06009186 RID: 37254 RVA: 0x0117F1E8 File Offset: 0x0117D3E8
		internal static bool xNKgnTVHJTEjimOmXYHS()
		{
			return false;
		}

		// Token: 0x04008936 RID: 35126
		internal M903_ShadowPalace3 $self_$41423;

		// Token: 0x0200186C RID: 6252
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06009187 RID: 37255 RVA: 0x0117F1EC File Offset: 0x0117D3EC
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M903_ShadowPalace3 self_)
			{
				if (80927 - 173828 != -92901)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (71696 - 33438 == 38258)
					{
						base..ctor();
						if (256503 - 351343 != -94839)
						{
							this.$self_$41422 = self_;
							if (248685 - 4501 == 244184)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x06009188 RID: 37256 RVA: 0x0117F284 File Offset: 0x0117D484
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (245495 - 183380 != 62116)
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
						if (27392 - 362159 == -334766)
						{
							continue;
						}
						Game.mStateTime = Time.time;
						if (138539 - 228458 == -89918)
						{
							continue;
						}
						this.YieldDefault(1);
						if (117355 - 488036 != -370681)
						{
							continue;
						}
						goto IL_1B9;
					default:
						if (47484 - 46430 != 1054)
						{
							continue;
						}
						break;
					}
					Debug.Log("Start Game");
					if (82335 - 166976 == -84641)
					{
						Game.mGameState = eGameState.Start;
						if (241262 - 373726 != -132463)
						{
							Game.mStateTime = Time.time;
							if (123323 - 379068 != -255744)
							{
								this.$mGameGui$41421 = (GameGui)this.$self_$41422.GetComponent(typeof(GameGui));
								if (218161 - 113121 == 105040)
								{
									this.$mGameGui$41421.enabled = true;
									if (233034 - 104890 != 128145)
									{
										this.$self_$41422.SendMessage("fadeIn");
										if (59582 - 104198 != -44615)
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

			// Token: 0x06009189 RID: 37257 RVA: 0x0117F45C File Offset: 0x0117D65C
			internal static bool cQd6f9VHDjNQ8BSPmck0()
			{
				return true;
			}

			// Token: 0x0600918A RID: 37258 RVA: 0x0117F460 File Offset: 0x0117D660
			internal static bool q49LtfVHv1pfHFMVpfRZ()
			{
				return false;
			}

			// Token: 0x04008937 RID: 35127
			internal GameGui $mGameGui$41421;

			// Token: 0x04008938 RID: 35128
			internal M903_ShadowPalace3 $self_$41422;
		}
	}

	// Token: 0x0200186D RID: 6253
	[CompilerGenerated]
	[Serializable]
	internal sealed class $onDeadPlayer$41424 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600918B RID: 37259 RVA: 0x0117F464 File Offset: 0x0117D664
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $onDeadPlayer$41424(M903_ShadowPalace3 self_)
		{
			if (292903 - 522855 != -229951)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (251932 - 378032 != -126099)
				{
					base..ctor();
					if (276520 - 528094 == -251574)
					{
						this.$self_$41429 = self_;
						if (266511 - 449729 != -183217)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x0600918C RID: 37260 RVA: 0x0117F4FC File Offset: 0x0117D6FC
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M903_ShadowPalace3.$onDeadPlayer$41424.$(this.$self_$41429);
		}

		// Token: 0x0600918D RID: 37261 RVA: 0x0117F50C File Offset: 0x0117D70C
		internal static bool WEN14bVHRSqK11bPnx0N()
		{
			return true;
		}

		// Token: 0x0600918E RID: 37262 RVA: 0x0117F510 File Offset: 0x0117D710
		internal static bool HgGfqoVHwwhxvbWLcOIL()
		{
			return false;
		}

		// Token: 0x04008939 RID: 35129
		internal M903_ShadowPalace3 $self_$41429;

		// Token: 0x0200186E RID: 6254
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600918F RID: 37263 RVA: 0x0117F514 File Offset: 0x0117D714
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M903_ShadowPalace3 self_)
			{
				if (73879 - 530990 != -457111)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (273209 - 336938 == -63729)
					{
						base..ctor();
						if (163668 - 298734 != -135065)
						{
							this.$self_$41428 = self_;
							if (156988 - 150700 == 6288)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x06009190 RID: 37264 RVA: 0x0117F5AC File Offset: 0x0117D7AC
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (269661 - 384749 != -115088)
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
							if (15882 - 151680 == -135797)
							{
								continue;
							}
							if (Game.mGameState != eGameState.Hold)
							{
								goto IL_89;
							}
							if (128408 - 29950 == 98459)
							{
								continue;
							}
						}
						Game.mGameState = eGameState.Hold;
						if (243412 - 134048 != 109364)
						{
							continue;
						}
						this.$mStoryGui$41425 = (StoryGui)this.$self_$41428.GetComponent(typeof(StoryGui));
						if (245434 - 408648 == -163213)
						{
							continue;
						}
						if (this.$mStoryGui$41425)
						{
							if (264385 - 183838 == 80548)
							{
								continue;
							}
							this.$mStoryGui$41425.close();
							if (126918 - 194731 == -67812)
							{
								continue;
							}
						}
						this.$mChangeGui$41426 = (ChangeGui)this.$self_$41428.GetComponent(typeof(ChangeGui));
						if (259156 - 524332 != -265176)
						{
							continue;
						}
						if (this.$mChangeGui$41426)
						{
							if (56706 - 451615 == -394908)
							{
								continue;
							}
							this.$mChangeGui$41426.close();
							if (157714 - 395834 != -238120)
							{
								continue;
							}
						}
						this.$mGameGui$41427 = (GameGui)this.$self_$41428.GetComponent(typeof(GameGui));
						if (148443 - 193412 != -44969)
						{
							continue;
						}
						if (this.$mGameGui$41427)
						{
							if (17013 - 41265 != -24252)
							{
								continue;
							}
							if (!this.$mGameGui$41427.enabled)
							{
								if (96129 - 284018 == -187888)
								{
									continue;
								}
								this.$mGameGui$41427.enabled = true;
								if (195542 - 474559 != -279017)
								{
									continue;
								}
							}
							this.$mGameGui$41427.openDeadMenu();
							if (255198 - 352173 != -96975)
							{
								continue;
							}
						}
						IL_89:
						this.YieldDefault(1);
						if (186284 - 225764 != -39480)
						{
							continue;
						}
						goto IL_2F9;
					default:
						if (239581 - 472280 == -232698)
						{
							continue;
						}
						break;
					}
					Debug.Log("On Dead Player");
				}
				while (238992 - 332762 == -93769);
				return this.Yield(2, new WaitForSeconds((float)2));
				IL_2F9:
				return false;
			}

			// Token: 0x06009191 RID: 37265 RVA: 0x0117F8C4 File Offset: 0x0117DAC4
			internal static bool Hfh6SkVHqlrdJqQm6FuM()
			{
				return true;
			}

			// Token: 0x06009192 RID: 37266 RVA: 0x0117F8C8 File Offset: 0x0117DAC8
			internal static bool e9qFbsVH70mgAPEXZFxo()
			{
				return false;
			}

			// Token: 0x0400893A RID: 35130
			internal StoryGui $mStoryGui$41425;

			// Token: 0x0400893B RID: 35131
			internal ChangeGui $mChangeGui$41426;

			// Token: 0x0400893C RID: 35132
			internal GameGui $mGameGui$41427;

			// Token: 0x0400893D RID: 35133
			internal M903_ShadowPalace3 $self_$41428;
		}
	}

	// Token: 0x0200186F RID: 6255
	[CompilerGenerated]
	[Serializable]
	internal sealed class $onChangePlayer$41430 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06009193 RID: 37267 RVA: 0x0117F8CC File Offset: 0x0117DACC
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $onChangePlayer$41430(Hashtable data, M903_ShadowPalace3 self_)
		{
			if (239574 - 359330 != -119756)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (291340 - 173942 == 117398)
				{
					base..ctor();
					if (91941 - 201908 != -109966)
					{
						this.$data$41435 = data;
						if (257719 - 120829 == 136890)
						{
							this.$self_$41436 = self_;
							if (149928 - 581375 != -431446)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x06009194 RID: 37268 RVA: 0x0117F988 File Offset: 0x0117DB88
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M903_ShadowPalace3.$onChangePlayer$41430.$(this.$data$41435, this.$self_$41436);
		}

		// Token: 0x06009195 RID: 37269 RVA: 0x0117F99C File Offset: 0x0117DB9C
		internal static bool x4ANkyVHPrrTsDSpUaEO()
		{
			return true;
		}

		// Token: 0x06009196 RID: 37270 RVA: 0x0117F9A0 File Offset: 0x0117DBA0
		internal static bool ahX4hXVH0MqJfBsVmmEQ()
		{
			return false;
		}

		// Token: 0x0400893E RID: 35134
		internal Hashtable $data$41435;

		// Token: 0x0400893F RID: 35135
		internal M903_ShadowPalace3 $self_$41436;

		// Token: 0x02001870 RID: 6256
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06009197 RID: 37271 RVA: 0x0117F9A4 File Offset: 0x0117DBA4
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Hashtable data, M903_ShadowPalace3 self_)
			{
				if (294846 - 435900 != -141053)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (146143 - 197910 != -51766)
					{
						base..ctor();
						if (237326 - 61147 != 176180)
						{
							this.$data$41433 = data;
							if (228579 - 111672 == 116907)
							{
								this.$self_$41434 = self_;
								if (51747 - 303972 == -252225)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x06009198 RID: 37272 RVA: 0x0117FA60 File Offset: 0x0117DC60
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (161538 - 118206 != 43333)
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
							if (254818 - 389953 != -135135)
							{
								continue;
							}
							Game.mGameState = eGameState.Normal;
							if (123101 - 149622 != -26521)
							{
								continue;
							}
							this.$mGameGui$41432 = (GameGui)this.$self_$41434.GetComponent(typeof(GameGui));
							if (81326 - 181248 != -99922)
							{
								continue;
							}
							this.$mGameGui$41432.enabled = true;
							if (82539 - 118165 != -35626)
							{
								continue;
							}
						}
						this.YieldDefault(1);
						if (9070 - 129760 != -120690)
						{
							continue;
						}
						goto IL_205;
					default:
						if (91387 - 3687 == 87701)
						{
							continue;
						}
						break;
					}
					UnityEngine.Object.Destroy(Game.mPlayer);
					if (243328 - 219206 != 24123)
					{
						this.$self_$41434.SendMessage("onCreatePlayer", this.$data$41433);
						if (73447 - 558062 == -484615)
						{
							this.$mChangeGui$41431 = (ChangeGui)this.$self_$41434.GetComponent(typeof(ChangeGui));
							if (223199 - 540261 == -317062)
							{
								if (!this.$mChangeGui$41431.enabled)
								{
									break;
								}
								if (59513 - 139664 == -80151)
								{
									this.$mChangeGui$41431.close();
									if (32577 - 261938 == -229361)
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

			// Token: 0x06009199 RID: 37273 RVA: 0x0117FC84 File Offset: 0x0117DE84
			internal static bool aBLcPvVHbHYC8IiHpBPZ()
			{
				return true;
			}

			// Token: 0x0600919A RID: 37274 RVA: 0x0117FC88 File Offset: 0x0117DE88
			internal static bool qY8s1QVHuFCgZjPDOfK2()
			{
				return false;
			}

			// Token: 0x04008940 RID: 35136
			internal ChangeGui $mChangeGui$41431;

			// Token: 0x04008941 RID: 35137
			internal GameGui $mGameGui$41432;

			// Token: 0x04008942 RID: 35138
			internal Hashtable $data$41433;

			// Token: 0x04008943 RID: 35139
			internal M903_ShadowPalace3 $self_$41434;
		}
	}

	// Token: 0x02001871 RID: 6257
	[CompilerGenerated]
	[Serializable]
	internal sealed class $onGameComplete$41437 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600919B RID: 37275 RVA: 0x0117FC8C File Offset: 0x0117DE8C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $onGameComplete$41437(Hashtable data, M903_ShadowPalace3 self_)
		{
			if (192429 - 321760 != -129330)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (98736 - 201931 != -103194)
				{
					base..ctor();
					if (192236 - 587556 == -395320)
					{
						this.$data$41445 = data;
						if (192583 - 200136 == -7553)
						{
							this.$self_$41446 = self_;
							if (16506 - 58949 != -42442)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x0600919C RID: 37276 RVA: 0x0117FD48 File Offset: 0x0117DF48
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M903_ShadowPalace3.$onGameComplete$41437.$(this.$data$41445, this.$self_$41446);
		}

		// Token: 0x0600919D RID: 37277 RVA: 0x0117FD5C File Offset: 0x0117DF5C
		internal static bool y0egQhVHICR6cZaudhmE()
		{
			return true;
		}

		// Token: 0x0600919E RID: 37278 RVA: 0x0117FD60 File Offset: 0x0117DF60
		internal static bool sfq7FKVHBX8FTlOCj39t()
		{
			return false;
		}

		// Token: 0x04008944 RID: 35140
		internal Hashtable $data$41445;

		// Token: 0x04008945 RID: 35141
		internal M903_ShadowPalace3 $self_$41446;

		// Token: 0x02001872 RID: 6258
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600919F RID: 37279 RVA: 0x0117FD64 File Offset: 0x0117DF64
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Hashtable data, M903_ShadowPalace3 self_)
			{
				if (277015 - 230167 != 46848)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (292926 - 5915 == 287011)
					{
						base..ctor();
						if (123982 - 89349 == 34633)
						{
							this.$data$41443 = data;
							if (21851 - 56430 != -34578)
							{
								this.$self_$41444 = self_;
								if (235706 - 577147 == -341441)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x060091A0 RID: 37280 RVA: 0x0117FE20 File Offset: 0x0117E020
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (200177 - 366314 != -166136)
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
						this.$mCompleteGui$41439 = (CompleteGui)this.$self_$41444.GetComponent(typeof(CompleteGui));
						if (243973 - 357682 == -113708)
						{
							continue;
						}
						this.$mCompleteGui$41439.Init();
						if (45273 - 262869 != -217596)
						{
							continue;
						}
						this.$mCompleteGui$41439.readData(this.$data$41443);
						if (227066 - 578326 == -351259)
						{
							continue;
						}
						if (this.$result$41438 == 1)
						{
							if (181599 - 152805 != 28794)
							{
								continue;
							}
							this.$mCompleteGui$41439.displayResult(eCompleteType.Success);
							if (115986 - 152606 != -36620)
							{
								continue;
							}
						}
						else
						{
							this.$mCompleteGui$41439.displayResult(eCompleteType.Failed);
							if (79718 - 548847 != -469129)
							{
								continue;
							}
						}
						this.$mGameGui$41440 = (GameGui)this.$self_$41444.GetComponent(typeof(GameGui));
						if (95268 - 83338 == 11931)
						{
							continue;
						}
						this.$mStoryGui$41441 = (StoryGui)this.$self_$41444.GetComponent(typeof(StoryGui));
						if (229524 - 479954 != -250430)
						{
							continue;
						}
						this.$mChangeGui$41442 = (ChangeGui)this.$self_$41444.GetComponent(typeof(ChangeGui));
						if (125593 - 174212 != -48619)
						{
							continue;
						}
						if (this.$mGameGui$41440)
						{
							if (247532 - 511750 != -264218)
							{
								continue;
							}
							this.$mGameGui$41440.close();
							if (128055 - 257791 == -129735)
							{
								continue;
							}
						}
						if (this.$mStoryGui$41441)
						{
							if (140679 - 88696 == 51984)
							{
								continue;
							}
							this.$mStoryGui$41441.close();
							if (11734 - 107608 != -95874)
							{
								continue;
							}
						}
						if (this.$mChangeGui$41442)
						{
							if (178369 - 320990 != -142621)
							{
								continue;
							}
							this.$mChangeGui$41442.disable();
							if (183244 - 409263 != -226019)
							{
								continue;
							}
						}
						this.YieldDefault(1);
						if (72047 - 195299 != -123252)
						{
							continue;
						}
						goto IL_3DB;
					default:
						if (86682 - 260209 != -173527)
						{
							continue;
						}
						break;
					}
					Debug.Log("On Mission Complete:" + this.$data$41443[31]);
					if (52952 - 512963 == -460011)
					{
						if (Game.mGameState > eGameState.AllHold)
						{
							if (230636 - 350211 == -119575)
							{
								break;
							}
						}
						else
						{
							Game.mGameState = eGameState.Complete;
							if (63551 - 321025 == -257474)
							{
								this.$result$41438 = RuntimeServices.UnboxInt32(this.$data$41443[31]);
								if (282674 - 72396 != 210279)
								{
									goto Block_25;
								}
							}
						}
					}
				}
				goto IL_3DB;
				Block_25:
				return this.Yield(2, new WaitForSeconds(1f));
				IL_3DB:
				return false;
			}

			// Token: 0x060091A1 RID: 37281 RVA: 0x0118021C File Offset: 0x0117E41C
			internal static bool jqV74KVHePhvI2Voqacb()
			{
				return true;
			}

			// Token: 0x060091A2 RID: 37282 RVA: 0x01180220 File Offset: 0x0117E420
			internal static bool yHugm3VHrGFa3CSTmioE()
			{
				return false;
			}

			// Token: 0x04008946 RID: 35142
			internal int $result$41438;

			// Token: 0x04008947 RID: 35143
			internal CompleteGui $mCompleteGui$41439;

			// Token: 0x04008948 RID: 35144
			internal GameGui $mGameGui$41440;

			// Token: 0x04008949 RID: 35145
			internal StoryGui $mStoryGui$41441;

			// Token: 0x0400894A RID: 35146
			internal ChangeGui $mChangeGui$41442;

			// Token: 0x0400894B RID: 35147
			internal Hashtable $data$41443;

			// Token: 0x0400894C RID: 35148
			internal M903_ShadowPalace3 $self_$41444;
		}
	}

	// Token: 0x02001873 RID: 6259
	[CompilerGenerated]
	[Serializable]
	internal sealed class $ReturnToTown$41447 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x060091A3 RID: 37283 RVA: 0x01180224 File Offset: 0x0117E424
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $ReturnToTown$41447(M903_ShadowPalace3 self_)
		{
			if (237293 - 221879 != 15415)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (187668 - 314802 == -127134)
				{
					base..ctor();
					if (44486 - 379553 == -335067)
					{
						this.$self_$41451 = self_;
						if (276424 - 297875 == -21451)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x060091A4 RID: 37284 RVA: 0x011802BC File Offset: 0x0117E4BC
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M903_ShadowPalace3.$ReturnToTown$41447.$(this.$self_$41451);
		}

		// Token: 0x060091A5 RID: 37285 RVA: 0x011802CC File Offset: 0x0117E4CC
		internal static bool GjJvkSVHjMfXSAxGdUZh()
		{
			return true;
		}

		// Token: 0x060091A6 RID: 37286 RVA: 0x011802D0 File Offset: 0x0117E4D0
		internal static bool TmNnv1VHhYoLikVlTI2E()
		{
			return false;
		}

		// Token: 0x0400894D RID: 35149
		internal M903_ShadowPalace3 $self_$41451;

		// Token: 0x02001874 RID: 6260
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x060091A7 RID: 37287 RVA: 0x011802D4 File Offset: 0x0117E4D4
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M903_ShadowPalace3 self_)
			{
				if (234677 - 459977 != -225299)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (61318 - 556619 == -495301)
					{
						base..ctor();
						if (173670 - 139489 != 34182)
						{
							this.$self_$41450 = self_;
							if (7616 - 13389 != -5772)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x060091A8 RID: 37288 RVA: 0x0118036C File Offset: 0x0117E56C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (117675 - 570969 != -453294)
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
						this.$self_$41450.LeaveGame();
						if (180272 - 179151 != 1121)
						{
							continue;
						}
						this.YieldDefault(1);
						if (176650 - 391424 != -214773)
						{
							goto Block_20;
						}
						continue;
					default:
						if (10442 - 132551 != -122109)
						{
							continue;
						}
						break;
					}
					Game.mGameState = eGameState.Ended;
					if (198690 - 547288 != -348597)
					{
						Game.mStateTime = Time.time;
						if (150584 - 181513 == -30929)
						{
							this.$$switch$7458$41448 = PlayerData.SaveGuild;
							if (68391 - 167800 == -99409)
							{
								if (this.$$switch$7458$41448 == 1)
								{
									if (167852 - 202127 != -34275)
									{
										continue;
									}
									Game.mNextGameCode = 32;
									if (224301 - 557973 != -333672)
									{
										continue;
									}
								}
								else if (this.$$switch$7458$41448 == 2)
								{
									if (97206 - 504991 == -407784)
									{
										continue;
									}
									Game.mNextGameCode = 33;
									if (61501 - 595355 != -533854)
									{
										continue;
									}
								}
								else if (this.$$switch$7458$41448 == 3)
								{
									if (173807 - 284003 != -110196)
									{
										continue;
									}
									Game.mNextGameCode = 34;
									if (87310 - 210520 != -123210)
									{
										continue;
									}
								}
								else if (this.$$switch$7458$41448 == 4)
								{
									if (285309 - 419561 == -134251)
									{
										continue;
									}
									Game.mNextGameCode = 35;
									if (122516 - 103932 == 18585)
									{
										continue;
									}
								}
								else if (this.$$switch$7458$41448 == 5)
								{
									if (4584 - 27094 != -22510)
									{
										continue;
									}
									Game.mNextGameCode = 36;
									if (182119 - 499419 != -317300)
									{
										continue;
									}
								}
								else if (PlayerData.GID == 0)
								{
									if (178337 - 166026 != 12311)
									{
										continue;
									}
									Game.mNextGameCode = 30;
									if (281314 - 64929 == 216386)
									{
										continue;
									}
								}
								else
								{
									Game.mNextGameCode = 31;
									if (284992 - 271771 != 13221)
									{
										continue;
									}
								}
								this.$mGameGui$41449 = (GameGui)this.$self_$41450.GetComponent(typeof(GameGui));
								if (37698 - 223031 == -185333)
								{
									if (this.$mGameGui$41449)
									{
										if (250538 - 407984 != -157446)
										{
											continue;
										}
										this.$mGameGui$41449.close();
										if (169380 - 46861 != 122519)
										{
											continue;
										}
									}
									this.$self_$41450.SendMessage("fadeOut");
									if (252247 - 20014 != 232234)
									{
										goto Block_24;
									}
								}
							}
						}
					}
				}
				Block_20:
				goto IL_3AD;
				Block_24:
				return this.Yield(2, new WaitForSeconds((float)1));
				IL_3AD:
				return false;
			}

			// Token: 0x060091A9 RID: 37289 RVA: 0x01180738 File Offset: 0x0117E938
			internal static bool AT69lrVHsYxla8wPOYpT()
			{
				return true;
			}

			// Token: 0x060091AA RID: 37290 RVA: 0x0118073C File Offset: 0x0117E93C
			internal static bool PwxcJDVH9El5vjqrPeUC()
			{
				return false;
			}

			// Token: 0x0400894E RID: 35150
			internal int $$switch$7458$41448;

			// Token: 0x0400894F RID: 35151
			internal GameGui $mGameGui$41449;

			// Token: 0x04008950 RID: 35152
			internal M903_ShadowPalace3 $self_$41450;
		}
	}

	// Token: 0x02001875 RID: 6261
	[CompilerGenerated]
	[Serializable]
	internal sealed class $ReturnToGuild$41452 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x060091AB RID: 37291 RVA: 0x01180740 File Offset: 0x0117E940
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $ReturnToGuild$41452(M903_ShadowPalace3 self_)
		{
			if (197352 - 445438 != -248085)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (258915 - 130411 == 128504)
				{
					base..ctor();
					if (118659 - 146232 == -27573)
					{
						this.$self_$41455 = self_;
						if (140344 - 74843 != 65502)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x060091AC RID: 37292 RVA: 0x011807D8 File Offset: 0x0117E9D8
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M903_ShadowPalace3.$ReturnToGuild$41452.$(this.$self_$41455);
		}

		// Token: 0x060091AD RID: 37293 RVA: 0x011807E8 File Offset: 0x0117E9E8
		internal static bool L0inLxVH1byvjhso7ace()
		{
			return true;
		}

		// Token: 0x060091AE RID: 37294 RVA: 0x011807EC File Offset: 0x0117E9EC
		internal static bool ufKtofVH4YpiSk80dsWp()
		{
			return false;
		}

		// Token: 0x04008951 RID: 35153
		internal M903_ShadowPalace3 $self_$41455;

		// Token: 0x02001876 RID: 6262
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x060091AF RID: 37295 RVA: 0x011807F0 File Offset: 0x0117E9F0
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M903_ShadowPalace3 self_)
			{
				if (56496 - 479319 != -422822)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (169790 - 35195 == 134595)
					{
						base..ctor();
						if (55686 - 392284 == -336598)
						{
							this.$self_$41454 = self_;
							if (283196 - 584056 == -300860)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x060091B0 RID: 37296 RVA: 0x01180888 File Offset: 0x0117EA88
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (256622 - 210910 != 45712)
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
						this.$self_$41454.LeaveGame();
						if (150830 - 451837 != -301007)
						{
							continue;
						}
						this.YieldDefault(1);
						if (271770 - 480427 != -208657)
						{
							continue;
						}
						goto IL_1BD;
					default:
						if (277938 - 504126 == -226187)
						{
							continue;
						}
						break;
					}
					Game.mGameState = eGameState.Ended;
					if (14331 - 313825 != -299493)
					{
						Game.mStateTime = Time.time;
						if (191909 - 281883 == -89974)
						{
							Game.mNextGameCode = 31;
							if (165679 - 126132 == 39547)
							{
								this.$mGameGui$41453 = (GameGui)this.$self_$41454.GetComponent(typeof(GameGui));
								if (270009 - 229944 != 40066)
								{
									if (this.$mGameGui$41453)
									{
										if (281111 - 177438 != 103673)
										{
											continue;
										}
										this.$mGameGui$41453.close();
										if (121200 - 315785 != -194585)
										{
											continue;
										}
									}
									this.$self_$41454.SendMessage("fadeOut");
									if (196860 - 386960 != -190099)
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

			// Token: 0x060091B1 RID: 37297 RVA: 0x01180A64 File Offset: 0x0117EC64
			internal static bool ac9OcnVHzUIn9AbW3RRR()
			{
				return true;
			}

			// Token: 0x060091B2 RID: 37298 RVA: 0x01180A68 File Offset: 0x0117EC68
			internal static bool MRya3SVWacIug5fCAfKM()
			{
				return false;
			}

			// Token: 0x04008952 RID: 35154
			internal GameGui $mGameGui$41453;

			// Token: 0x04008953 RID: 35155
			internal M903_ShadowPalace3 $self_$41454;
		}
	}

	// Token: 0x02001877 RID: 6263
	[CompilerGenerated]
	[Serializable]
	internal sealed class $ReturnToCamp$41456 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x060091B3 RID: 37299 RVA: 0x01180A6C File Offset: 0x0117EC6C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $ReturnToCamp$41456(M903_ShadowPalace3 self_)
		{
			if (69173 - 276989 != -207815)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (30262 - 58529 == -28267)
				{
					base..ctor();
					if (236423 - 173260 != 63164)
					{
						this.$self_$41460 = self_;
						if (225354 - 576367 == -351013)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x060091B4 RID: 37300 RVA: 0x01180B04 File Offset: 0x0117ED04
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M903_ShadowPalace3.$ReturnToCamp$41456.$(this.$self_$41460);
		}

		// Token: 0x060091B5 RID: 37301 RVA: 0x01180B14 File Offset: 0x0117ED14
		internal static bool EoGCimVW5CCvvUP4ludG()
		{
			return true;
		}

		// Token: 0x060091B6 RID: 37302 RVA: 0x01180B18 File Offset: 0x0117ED18
		internal static bool sXwZ5yVWpLXupPyRi7lr()
		{
			return false;
		}

		// Token: 0x04008954 RID: 35156
		internal M903_ShadowPalace3 $self_$41460;

		// Token: 0x02001878 RID: 6264
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x060091B7 RID: 37303 RVA: 0x01180B1C File Offset: 0x0117ED1C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M903_ShadowPalace3 self_)
			{
				if (189317 - 97615 != 91703)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (195240 - 228138 != -32897)
					{
						base..ctor();
						if (281354 - 303897 != -22542)
						{
							this.$self_$41459 = self_;
							if (41820 - 235585 != -193764)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x060091B8 RID: 37304 RVA: 0x01180BB4 File Offset: 0x0117EDB4
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (59328 - 382732 != -323404)
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
						this.$self_$41459.LeaveGame();
						if (274571 - 587633 != -313062)
						{
							continue;
						}
						this.YieldDefault(1);
						if (244069 - 193382 != 50687)
						{
							continue;
						}
						goto IL_363;
					default:
						if (117059 - 193776 == -76716)
						{
							continue;
						}
						break;
					}
					Game.mGameState = eGameState.Ended;
					if (81368 - 134580 == -53212)
					{
						Game.mStateTime = Time.time;
						if (281581 - 482620 != -201038)
						{
							this.$$switch$7460$41457 = PlayerData.SaveGuild;
							if (182850 - 111024 == 71826)
							{
								if (this.$$switch$7460$41457 == 1)
								{
									if (141506 - 393271 != -251765)
									{
										continue;
									}
									Game.mNextGameCode = 32;
									if (99771 - 110591 == -10819)
									{
										continue;
									}
								}
								else if (this.$$switch$7460$41457 == 2)
								{
									if (294264 - 418338 != -124074)
									{
										continue;
									}
									Game.mNextGameCode = 33;
									if (33737 - 149919 != -116182)
									{
										continue;
									}
								}
								else if (this.$$switch$7460$41457 == 3)
								{
									if (53841 - 228416 == -174574)
									{
										continue;
									}
									Game.mNextGameCode = 34;
									if (101755 - 573375 != -471620)
									{
										continue;
									}
								}
								else if (this.$$switch$7460$41457 == 4)
								{
									if (277175 - 66549 == 210627)
									{
										continue;
									}
									Game.mNextGameCode = 35;
									if (49959 - 544729 != -494770)
									{
										continue;
									}
								}
								else if (this.$$switch$7460$41457 == 5)
								{
									if (235005 - 553868 != -318863)
									{
										continue;
									}
									Game.mNextGameCode = 36;
									if (82045 - 452359 == -370313)
									{
										continue;
									}
								}
								else
								{
									Game.mNextGameCode = 30;
									if (75023 - 74687 != 336)
									{
										continue;
									}
								}
								this.$mGameGui$41458 = (GameGui)this.$self_$41459.GetComponent(typeof(GameGui));
								if (25640 - 292428 == -266788)
								{
									if (this.$mGameGui$41458)
									{
										if (205925 - 421753 != -215828)
										{
											continue;
										}
										this.$mGameGui$41458.close();
										if (248824 - 417286 != -168462)
										{
											continue;
										}
									}
									this.$self_$41459.SendMessage("fadeOut");
									if (38260 - 201881 == -163621)
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

			// Token: 0x060091B9 RID: 37305 RVA: 0x01180F38 File Offset: 0x0117F138
			internal static bool JdDWqWVWVxR2JK78hPAH()
			{
				return true;
			}

			// Token: 0x060091BA RID: 37306 RVA: 0x01180F3C File Offset: 0x0117F13C
			internal static bool tKQZS5VWtcZde7YHmIKy()
			{
				return false;
			}

			// Token: 0x04008955 RID: 35157
			internal int $$switch$7460$41457;

			// Token: 0x04008956 RID: 35158
			internal GameGui $mGameGui$41458;

			// Token: 0x04008957 RID: 35159
			internal M903_ShadowPalace3 $self_$41459;
		}
	}
}
