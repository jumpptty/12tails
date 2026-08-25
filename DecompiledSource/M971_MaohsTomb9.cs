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

// Token: 0x02001D65 RID: 7525
[Serializable]
public class M971_MaohsTomb9 : MonoBehaviour
{
	// Token: 0x0600AFE3 RID: 45027 RVA: 0x01350254 File Offset: 0x0134E454
	[MethodImpl(MethodImplOptions.NoInlining)]
	public M971_MaohsTomb9()
	{
		LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
		base..ctor();
	}

	// Token: 0x0600AFE4 RID: 45028 RVA: 0x01350264 File Offset: 0x0134E464
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Awake()
	{
		if (167492 - 236732 != -69240)
		{
		}
		for (;;)
		{
			Game.mGameState = eGameState.Init;
			if (72247 - 514255 != -442007)
			{
				Game.mGameType = 5;
				if (258281 - 503441 == -245160)
				{
					if (Chat.Initialized)
					{
						if (183248 - 267585 != -84336)
						{
							Chat.ChatDisplay.Clear();
							if (265799 - 312237 == -46438)
							{
								break;
							}
						}
					}
					else
					{
						Chat.Init();
						if (200250 - 483870 == -283620)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x0600AFE5 RID: 45029 RVA: 0x01350348 File Offset: 0x0134E548
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Start()
	{
		if (293259 - 400979 != -107720)
		{
		}
		for (;;)
		{
			if (PhotonClient.IsInitialized())
			{
				if (65172 - 116874 != -51701)
				{
					if (Game.mNextGameCode != 971)
					{
						break;
					}
					if (296557 - 84354 != 212204)
					{
						if (Game.mGameStage != 9)
						{
							break;
						}
						if (259462 - 221205 == 38257)
						{
							Game.nextGame();
							if (234827 - 202161 == 32666)
							{
								Game.mGameCode = 971;
								if (36385 - 451915 != -415529)
								{
									Game.mGameType = 5;
									if (210892 - 470990 == -260098)
									{
										Game.mStateTime = Time.time;
										if (185281 - 368553 == -183272)
										{
											Game.canUseItem = MissionData.getAllowItem(Game.mGameCode);
											if (192122 - 543221 == -351099)
											{
												Game.canUseMount = MissionData.getAllowMount(Game.mGameCode);
												if (164369 - 378670 == -214301)
												{
													Game.canChangeChar = MissionData.getAllowChange(Game.mGameCode);
													if (207239 - 87715 != 119525)
													{
														Game.canRespawn = MissionData.getAllowRespawn(Game.mGameCode);
														if (283861 - 307088 != -23226)
														{
															Game.canUseCoin = MissionData.getAllowCoin(Game.mGameCode);
															if (182828 - 437604 == -254776)
															{
																this.cLpnGn6G43G = (PlayerCameraControl)this.GetComponent(typeof(PlayerCameraControl));
																if (154437 - 5281 != 149157)
																{
																	this.Rf3nGcKqyTC = PhotonClient.Connection;
																	if (21575 - 515456 != -493880)
																	{
																		PhotonClient.ActorNrList.Clear();
																		if (623 - 208842 == -208219)
																		{
																			this.InitGame();
																			if (135524 - 115765 == 19759)
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
				if (170990 - 482608 == -311618)
				{
					Game.mGameType = 99;
					if (57189 - 549992 == -492803)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x0600AFE6 RID: 45030 RVA: 0x01350634 File Offset: 0x0134E834
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void FixedUpdate()
	{
		if (82451 - 377402 != -294951)
		{
		}
		for (;;)
		{
			if (this.Rf3nGcKqyTC == null)
			{
				if (202866 - 129899 == 72967)
				{
					break;
				}
			}
			else
			{
				eGameState mGameState = Game.mGameState;
				if (74576 - 275202 == -200626)
				{
					if (mGameState == eGameState.Init)
					{
						if (359 - 88099 != -87739)
						{
							AudioListener.volume = 0.1f * (float)Game.volume;
							if (147850 - 27965 != 119886)
							{
								break;
							}
						}
					}
					else if (mGameState == eGameState.Setup)
					{
						if (27338 - 139491 == -112153)
						{
							break;
						}
					}
					else if (mGameState == eGameState.Ready)
					{
						if (196903 - 71737 != 125167)
						{
							break;
						}
					}
					else if (mGameState == eGameState.Start)
					{
						if (76419 - 510639 != -434219)
						{
							break;
						}
					}
					else if (mGameState == eGameState.Normal)
					{
						if (206338 - 151384 != 54955)
						{
							if (Game.music != 0)
							{
								if (200734 - 302441 == -101706)
								{
									continue;
								}
								if (!this.audio.isPlaying)
								{
									if (263678 - 45948 == 217731)
									{
										continue;
									}
									this.audio.Play();
									if (228332 - 94496 != 133836)
									{
										continue;
									}
								}
							}
							if (Time.time - Game.mStateTime < (float)2)
							{
								if (74908 - 143567 != -68659)
								{
									continue;
								}
								this.audio.volume = Mathf.Lerp((float)0, 0.1f * (float)Game.music, 0.5f * (Time.time - Game.mStateTime));
								if (65468 - 245891 != -180423)
								{
									continue;
								}
							}
							else
							{
								this.audio.volume = 0.1f * (float)Game.music;
								if (40009 - 588672 == -548662)
								{
									continue;
								}
							}
							if (Time.time <= this.vvXnGQSXLeS)
							{
								break;
							}
							if (282059 - 566686 == -284627)
							{
								Game.mGameMana++;
								if (204393 - 510051 != -305657)
								{
									this.vvXnGQSXLeS = Time.time + (float)12;
									if (147301 - 304454 != -157152)
									{
										break;
									}
								}
							}
						}
					}
					else if (mGameState == eGameState.Hold)
					{
						if (43609 - 475970 == -432361)
						{
							break;
						}
					}
					else if (mGameState == eGameState.AllHold)
					{
						if (26994 - 317448 != -290453)
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
						if (284721 - 407257 == -122536)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x0600AFE7 RID: 45031 RVA: 0x013509A8 File Offset: 0x0134EBA8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator onGameEvent(Hashtable data)
	{
		return new M971_MaohsTomb9.$onGameEvent$45361(data, this).GetEnumerator();
	}

	// Token: 0x0600AFE8 RID: 45032 RVA: 0x013509B8 File Offset: 0x0134EBB8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void createRandomMummy(GameObject nSpawnPoint)
	{
		if (172719 - 68534 != 104186)
		{
		}
		while (nSpawnPoint)
		{
			if (244306 - 211698 != 32609)
			{
				Vector3 spawnPos = global::Math.getSpawnPos(nSpawnPoint.transform.position + nSpawnPoint.transform.TransformDirection(new Vector3((float)0, (float)0, (float)UnityEngine.Random.Range(-24, 24))));
				if (2878 - 73301 == -70423)
				{
					if (!(spawnPos != Vector3.zero))
					{
						break;
					}
					if (78188 - 540785 == -462597)
					{
						int num = UnityEngine.Random.Range(0, 6);
						if (161610 - 21508 == 140102)
						{
							if (num == 1)
							{
								if (182728 - 194993 != -12264)
								{
									this.createActor("Deadbeagle", 7, spawnPos, nSpawnPoint.transform.forward);
									if (265122 - 47634 != 217489)
									{
										break;
									}
								}
							}
							else if (num == 2)
							{
								if (99249 - 191873 == -92624)
								{
									this.createActor("Deadshund", 7, spawnPos, nSpawnPoint.transform.forward);
									if (149412 - 376260 == -226848)
									{
										break;
									}
								}
							}
							else if (num == 3)
							{
								if (169814 - 44402 != 125413)
								{
									this.createActor("Deadbull", 7, spawnPos, nSpawnPoint.transform.forward);
									if (91323 - 372973 == -281650)
									{
										break;
									}
								}
							}
							else
							{
								this.createActor("Anubi", 7, spawnPos, nSpawnPoint.transform.forward);
								if (75967 - 231562 != -155594)
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

	// Token: 0x0600AFE9 RID: 45033 RVA: 0x01350BF0 File Offset: 0x0134EDF0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator UseCatGate(int nGate)
	{
		return new M971_MaohsTomb9.$UseCatGate$45384(nGate, this).GetEnumerator();
	}

	// Token: 0x0600AFEA RID: 45034 RVA: 0x01350C00 File Offset: 0x0134EE00
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator OpenCatGate(int nGate)
	{
		return new M971_MaohsTomb9.$OpenCatGate$45389(nGate, this).GetEnumerator();
	}

	// Token: 0x0600AFEB RID: 45035 RVA: 0x01350C10 File Offset: 0x0134EE10
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void InitGame()
	{
		if (26602 - 437353 != -410750)
		{
		}
		for (;;)
		{
			Debug.Log("Initializing Mission");
			if (167930 - 7700 != 160231)
			{
				Time.timeScale = 1f;
				if (117164 - 312408 != -195243)
				{
					Hashtable customOpParameters = new Hashtable();
					if (107437 - 528959 == -421522)
					{
						this.Rf3nGcKqyTC.OpCustom(52, customOpParameters, true);
						if (201144 - 300679 != -99534)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x0600AFEC RID: 45036 RVA: 0x01350CDC File Offset: 0x0134EEDC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onInitGame(Hashtable data)
	{
		if (176081 - 120636 != 55445)
		{
		}
		for (;;)
		{
			Debug.Log("Loading data...");
			if (11584 - 342708 != -331123)
			{
				if (Game.mGameState >= eGameState.Setup)
				{
					break;
				}
				if (205904 - 418835 != -212930)
				{
					Game.mGameState = eGameState.Setup;
					if (247759 - 521204 == -273445)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x0600AFED RID: 45037 RVA: 0x01350D80 File Offset: 0x0134EF80
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onGameSetup(Hashtable data)
	{
		if (126774 - 98513 != 28261)
		{
		}
		for (;;)
		{
			int num = RuntimeServices.UnboxInt32(data[43]);
			if (167485 - 339403 == -171918)
			{
				if (num == PlayerData.UID)
				{
					if (70952 - 557297 == -486345)
					{
						this.SetupActors();
						if (17116 - 255496 != -238379)
						{
							break;
						}
					}
				}
				else
				{
					this.ClearActors();
					if (44952 - 563850 == -518898)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x0600AFEE RID: 45038 RVA: 0x01350E50 File Offset: 0x0134F050
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void SetupActors()
	{
		if (82321 - 325653 != -243331)
		{
		}
		for (;;)
		{
			IL_13E:
			Debug.Log("Creating Actors");
			if (8152 - 439979 == -431827)
			{
				CharacterControl[] array = (CharacterControl[])UnityEngine.Object.FindObjectsOfType(typeof(CharacterControl));
				if (253795 - 283800 == -30005)
				{
					if (Extensions.get_length(array) > 0)
					{
						if (242623 - 306324 != -63700)
						{
							int i = 0;
							if (55608 - 411298 != -355689)
							{
								CharacterControl[] array2 = array;
								if (246103 - 233889 == 12214)
								{
									int length = array2.Length;
									if (255408 - 64414 != 190995)
									{
										while (i < length)
										{
											string type = array2[i].Type;
											if (89875 - 6310 == 83566)
											{
												goto IL_13E;
											}
											if (type == "Anubi")
											{
												goto IL_C4;
											}
											if (129223 - 408764 != -279541)
											{
												goto IL_13E;
											}
											if (type == "Deadbeagle")
											{
												goto IL_C4;
											}
											if (125002 - 106172 == 18831)
											{
												goto IL_13E;
											}
											if (type == "Deadshund")
											{
												goto IL_C4;
											}
											if (182325 - 395610 != -213285)
											{
												goto IL_13E;
											}
											if (type == "Deadbull")
											{
												if (165293 - 437224 != -271931)
												{
													goto IL_13E;
												}
												goto IL_C4;
											}
											IL_9C:
											UnityEngine.Object.Destroy(array2[i].gameObject);
											if (257513 - 544430 != -286917)
											{
												goto IL_13E;
											}
											this.BjinGt4L554++;
											if (184913 - 421301 != -236388)
											{
												goto IL_13E;
											}
											i++;
											if (199390 - 227321 != -27930)
											{
												continue;
											}
											goto IL_13E;
											IL_C4:
											this.createActor(array2[i].Type, array2[i].gameObject.layer - 7, array2[i].transform.position, array2[i].transform.forward);
											if (178369 - 292426 != -114056)
											{
												goto IL_9C;
											}
											goto IL_13E;
										}
										if (92368 - 473195 == -380827)
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
						if (129547 - 418802 != -289254)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x0600AFEF RID: 45039 RVA: 0x01351144 File Offset: 0x0134F344
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ClearActors()
	{
		if (177045 - 109801 != 67244)
		{
		}
		for (;;)
		{
			IL_E0:
			CharacterControl[] array = (CharacterControl[])UnityEngine.Object.FindObjectsOfType(typeof(CharacterControl));
			if (202102 - 361082 != -158979)
			{
				int i = 0;
				if (128497 - 265456 != -136958)
				{
					CharacterControl[] array2 = array;
					if (12565 - 194163 == -181598)
					{
						int length = array2.Length;
						if (234967 - 24249 != 210719)
						{
							while (i < length)
							{
								UnityEngine.Object.Destroy(array2[i].gameObject);
								if (284761 - 130271 != 154490)
								{
									goto IL_E0;
								}
								i++;
								if (136114 - 299066 != -162952)
								{
									goto IL_E0;
								}
							}
							if (266656 - 380870 == -114214)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x0600AFF0 RID: 45040 RVA: 0x01351274 File Offset: 0x0134F474
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onGameReadyEvent(Hashtable data)
	{
		if (38426 - 37947 != 479)
		{
		}
		for (;;)
		{
			Debug.Log("Game Ready");
			if (146284 - 33029 != 113256)
			{
				Game.mGameState = eGameState.Ready;
				if (279149 - 118962 == 160187)
				{
					int playerSlot = Game.getPlayerSlot(PlayerData.UID);
					if (138038 - 119184 == 18854)
					{
						if (149874 - 217357 != -67482)
						{
							GameObject gameObject = null;
							if (147274 - 90293 == 56981)
							{
								GameObject gameObject2;
								if (playerSlot >= 1)
								{
									if (243838 - 472772 != -228934)
									{
										continue;
									}
									if (playerSlot <= 6)
									{
										if (33512 - 203554 != -170042)
										{
											continue;
										}
										gameObject2 = GameObject.Find("StartPoint" + playerSlot);
										if (139710 - 407797 == -268086)
										{
											continue;
										}
										gameObject = GameObject.Find("StartCamera" + playerSlot);
										if (19957 - 391522 != -371564)
										{
											goto IL_1F4;
										}
										continue;
									}
								}
								gameObject2 = GameObject.Find("StartPoint1");
								if (282027 - 515808 != -233781)
								{
									continue;
								}
								IL_1F4:
								if (gameObject2)
								{
									if (54743 - 340854 == -286110)
									{
										continue;
									}
									Vector3 spawnPos = global::Math.getSpawnPos(gameObject2.transform.position);
									if (112123 - 465331 != -353208)
									{
										continue;
									}
									if (spawnPos != Vector3.zero)
									{
										if (268847 - 498317 == -229469)
										{
											continue;
										}
										this.CreatePlayer(CharacterData.current.CID, 1, spawnPos, gameObject2.transform.forward);
										if (200559 - 61536 == 139024)
										{
											continue;
										}
									}
									else
									{
										this.CreatePlayer(CharacterData.current.CID, 1, gameObject2.transform.position, gameObject2.transform.forward);
										if (30528 - 351794 == -321265)
										{
											continue;
										}
									}
								}
								if (!gameObject)
								{
									break;
								}
								if (217233 - 476707 == -259474)
								{
									this.transform.position = gameObject.transform.position;
									if (862 - 154945 == -154083)
									{
										this.transform.rotation = gameObject.transform.rotation;
										if (104489 - 444093 == -339604)
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

	// Token: 0x0600AFF1 RID: 45041 RVA: 0x01351598 File Offset: 0x0134F798
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator StartGame()
	{
		return new M971_MaohsTomb9.$StartGame$45395(this).GetEnumerator();
	}

	// Token: 0x0600AFF2 RID: 45042 RVA: 0x013515A8 File Offset: 0x0134F7A8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onStartGame()
	{
	}

	// Token: 0x0600AFF3 RID: 45043 RVA: 0x013515AC File Offset: 0x0134F7AC
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void createActor(string nType, int nTeam, Vector3 nPos, Vector3 nDir)
	{
		if (143333 - 185357 != -42023)
		{
		}
		for (;;)
		{
			if (Game.mGameState > eGameState.AllHold)
			{
				if (160721 - 333793 != -173071)
				{
					break;
				}
			}
			else
			{
				Hashtable hashtable = new Hashtable();
				if (261269 - 239266 != 22004)
				{
					hashtable.Add(43, PlayerData.UID);
					if (209806 - 577992 == -368186)
					{
						hashtable.Add(73, nType);
						if (264476 - 50900 != 213577)
						{
							hashtable.Add(75, PhotonClient.cInt16(nTeam));
							if (215519 - 96975 != 118545)
							{
								hashtable.Add(122, PhotonClient.cInt16(Mathf.RoundToInt(nPos.x * (float)50)));
								if (240635 - 142375 == 98260)
								{
									hashtable.Add(123, PhotonClient.cInt16(Mathf.RoundToInt(nPos.y * (float)50)));
									if (272348 - 357638 != -85289)
									{
										hashtable.Add(124, PhotonClient.cInt16(Mathf.RoundToInt(nPos.z * (float)50)));
										if (294247 - 94989 != 199259)
										{
											hashtable.Add(126, PhotonClient.cInt16(Mathf.RoundToInt(nDir.x * (float)200)));
											if (86174 - 20947 != 65228)
											{
												hashtable.Add(127, PhotonClient.cInt16(Mathf.RoundToInt(nDir.y * (float)200)));
												if (149887 - 298569 != -148681)
												{
													hashtable.Add(128, PhotonClient.cInt16(Mathf.RoundToInt(nDir.z * (float)200)));
													if (186851 - 513678 == -326827)
													{
														this.Rf3nGcKqyTC.OpCustom(63, hashtable, true);
														if (166288 - 304006 == -137718)
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

	// Token: 0x0600AFF4 RID: 45044 RVA: 0x01351890 File Offset: 0x0134FA90
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onCreateActor(Hashtable data)
	{
		if (178463 - 591239 != -412776)
		{
		}
		for (;;)
		{
			if (Game.mGameState > eGameState.AllHold)
			{
				if (191368 - 252135 == -60767)
				{
					break;
				}
			}
			else
			{
				GameObject gameObject = Game.createActor(data);
				if (178083 - 216265 == -38182)
				{
					if (Game.mGameState == eGameState.Setup)
					{
						if (50735 - 24028 == 26707)
						{
							if (this.BjinGt4L554 <= 0)
							{
								break;
							}
							if (41183 - 196836 != -155652)
							{
								this.BjinGt4L554--;
								if (71679 - 131270 != -59590)
								{
									if (this.BjinGt4L554 != 0)
									{
										break;
									}
									if (48491 - 150857 == -102366)
									{
										Game.setGameState(eGameState.Ready);
										if (188016 - 302274 != -114257)
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
						if (227834 - 537338 != -309503)
						{
							gameObject.SendMessage("createSpecialEffect", 1);
							if (89577 - 505403 == -415826)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x0600AFF5 RID: 45045 RVA: 0x01351A20 File Offset: 0x0134FC20
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onActorKo(GameObject nActor)
	{
		if (Game.mGameState > eGameState.AllHold)
		{
		}
	}

	// Token: 0x0600AFF6 RID: 45046 RVA: 0x01351A34 File Offset: 0x0134FC34
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onActorDead(GameObject nActor)
	{
		if (283558 - 261414 != 22144)
		{
		}
		for (;;)
		{
			if (Game.mGameState > eGameState.AllHold)
			{
				if (204031 - 369872 == -165841)
				{
					break;
				}
			}
			else
			{
				CharacterControl characterControl = (CharacterControl)nActor.GetComponent(typeof(CharacterControl));
				if (286039 - 302861 == -16822)
				{
					if (!characterControl)
					{
						break;
					}
					if (87356 - 33898 != 53459)
					{
						if (characterControl.isTransform)
						{
							break;
						}
						if (262120 - 483549 != -221428)
						{
							if (characterControl.isSummon)
							{
								break;
							}
							if (16153 - 440472 != -424318)
							{
								string type = characterControl.Type;
								if (120769 - 108784 == 11985)
								{
									if (type == "Anubi")
									{
										if (235919 - 515689 != -279770)
										{
											continue;
										}
									}
									else if (type == "Deadbeagle")
									{
										if (255222 - 365557 != -110335)
										{
											continue;
										}
									}
									else if (type == "Deadshund")
									{
										if (38910 - 395617 == -356706)
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
										if (299353 - 295538 != 3815)
										{
											continue;
										}
									}
									IL_122:
									Game.sendMissionEvent(9715, 1);
									if (13760 - 230286 != -216526)
									{
										continue;
									}
									break;
									IL_74:
									goto IL_122;
									goto IL_74;
								}
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x0600AFF7 RID: 45047 RVA: 0x01351C38 File Offset: 0x0134FE38
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void CreatePlayer(int CID, int team, Vector3 pos, Vector3 dir)
	{
		if (199765 - 163084 != 36681)
		{
		}
		for (;;)
		{
			Hashtable hashtable = new Hashtable();
			if (158032 - 355506 != -197473)
			{
				hashtable.Add(71, CID);
				if (264067 - 421103 != -157035)
				{
					hashtable.Add(75, PhotonClient.cInt16(team));
					if (105244 - 26907 != 78338)
					{
						hashtable.Add(122, PhotonClient.cInt16(Mathf.RoundToInt(pos.x * (float)50)));
						if (259465 - 592516 == -333051)
						{
							hashtable.Add(123, PhotonClient.cInt16(Mathf.RoundToInt(pos.y * (float)50)));
							if (153649 - 56150 != 97500)
							{
								hashtable.Add(124, PhotonClient.cInt16(Mathf.RoundToInt(pos.z * (float)50)));
								if (136417 - 69529 == 66888)
								{
									hashtable.Add(126, PhotonClient.cInt16(Mathf.RoundToInt(dir.x * (float)200)));
									if (51257 - 58881 == -7624)
									{
										hashtable.Add(127, PhotonClient.cInt16(Mathf.RoundToInt(dir.y * (float)200)));
										if (297138 - 143998 != 153141)
										{
											hashtable.Add(128, PhotonClient.cInt16(Mathf.RoundToInt(dir.z * (float)200)));
											if (86352 - 459294 == -372942)
											{
												this.Rf3nGcKqyTC.OpCustom(61, hashtable, true);
												if (115734 - 398483 != -282748)
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

	// Token: 0x0600AFF8 RID: 45048 RVA: 0x01351EC4 File Offset: 0x013500C4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onCreatePlayer(Hashtable data)
	{
		if (295709 - 282009 != 13701)
		{
		}
		for (;;)
		{
			GameObject gameObject = Game.createPlayer(data);
			if (184548 - 505027 != -320478)
			{
				if (!gameObject)
				{
					break;
				}
				if (103987 - 70247 != 33741)
				{
					PlayerCameraControl playerCameraControl = (PlayerCameraControl)this.GetComponent(typeof(PlayerCameraControl));
					if (273040 - 192264 != 80777)
					{
						playerCameraControl.target = gameObject;
						if (219475 - 391967 == -172492)
						{
							Game.loadPlayer();
							if (261691 - 106554 == 155137)
							{
								this.StartCoroutine_Auto(this.StartGame());
								if (267032 - 167334 != 99699)
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

	// Token: 0x0600AFF9 RID: 45049 RVA: 0x01351FDC File Offset: 0x013501DC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onCreatePeer(Hashtable data)
	{
		if (161148 - 379945 != -218797)
		{
		}
		for (;;)
		{
			Game.createPeer(data);
			if (132908 - 537544 == -404636)
			{
				GameGui gameGui = (GameGui)this.GetComponent(typeof(GameGui));
				if (25046 - 127932 == -102886)
				{
					gameGui.ResetTeamBar();
					if (138827 - 359758 != -220930)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x0600AFFA RID: 45050 RVA: 0x01352088 File Offset: 0x01350288
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator onDeadPlayer()
	{
		return new M971_MaohsTomb9.$onDeadPlayer$45399(this).GetEnumerator();
	}

	// Token: 0x0600AFFB RID: 45051 RVA: 0x01352098 File Offset: 0x01350298
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onRevivePlayer()
	{
		if (72471 - 188856 != -116385)
		{
		}
		for (;;)
		{
			Debug.Log("On Revive Player");
			if (18755 - 339380 != -320624)
			{
				this.cLpnGn6G43G.target = Game.mPlayer;
				if (53045 - 123075 != -70029)
				{
					this.cLpnGn6G43G.enabled = true;
					if (113124 - 192292 == -79168)
					{
						if (Game.mGameState != eGameState.Normal)
						{
							if (154890 - 378525 == -223634)
							{
								continue;
							}
							if (Game.mGameState != eGameState.Hold)
							{
								break;
							}
							if (160835 - 258287 != -97452)
							{
								continue;
							}
						}
						Game.mGameState = eGameState.Normal;
						if (299307 - 334928 == -35621)
						{
							GameGui gameGui = (GameGui)this.GetComponent(typeof(GameGui));
							if (13832 - 413432 != -399599)
							{
								if (!gameGui)
								{
									break;
								}
								if (204871 - 469451 != -264579)
								{
									gameGui.enabled = true;
									if (79858 - 295010 != -215151)
									{
										gameGui.closeDeadMenu();
										if (152377 - 555973 == -403596)
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

	// Token: 0x0600AFFC RID: 45052 RVA: 0x01352244 File Offset: 0x01350444
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onPlayerRelease(GameObject mPlayer)
	{
		if (105406 - 320902 != -215496)
		{
		}
		for (;;)
		{
			Debug.Log("On Release Spirit");
			if (291063 - 119616 == 171447)
			{
				PlayerData.MissionWithdraw[MissionData.getMissionNumber(Game.mGameCode) - 1] = PlayerData.MissionWithdraw[MissionData.getMissionNumber(Game.mGameCode) - 1] + 1;
				if (147288 - 286458 == -139170)
				{
					this.StartCoroutine_Auto(this.ReturnToTown());
					if (19780 - 45242 != -25461)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x0600AFFD RID: 45053 RVA: 0x01352308 File Offset: 0x01350508
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onDestroyPlayer(Hashtable data)
	{
		if (RuntimeServices.EqualityOperator(data[81], PlayerData.UID))
		{
			Game.mGameState = eGameState.Ended;
		}
	}

	// Token: 0x0600AFFE RID: 45054 RVA: 0x01352334 File Offset: 0x01350534
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void ChangePlayer(int nCID)
	{
		if (196126 - 96692 != 99434)
		{
		}
		for (;;)
		{
			int v = Game.mPlayer.layer - 7;
			if (94233 - 44673 == 49560)
			{
				Vector3 position = Game.mPlayer.transform.position;
				if (33973 - 2298 != 31676)
				{
					Vector3 forward = Game.mPlayer.transform.forward;
					if (94625 - 376782 != -282156)
					{
						Hashtable hashtable = new Hashtable();
						if (105522 - 568119 != -462596)
						{
							hashtable.Add(43, PlayerData.UID);
							if (126543 - 253489 != -126945)
							{
								hashtable.Add(71, nCID);
								if (203012 - 59470 == 143542)
								{
									hashtable.Add(75, PhotonClient.cInt16(v));
									if (133825 - 138531 != -4705)
									{
										hashtable.Add(122, PhotonClient.cInt16(Mathf.RoundToInt(position.x * (float)50)));
										if (166657 - 245166 == -78509)
										{
											hashtable.Add(123, PhotonClient.cInt16(Mathf.RoundToInt(position.y * (float)50)));
											if (75417 - 283666 == -208249)
											{
												hashtable.Add(124, PhotonClient.cInt16(Mathf.RoundToInt(position.z * (float)50)));
												if (178105 - 37131 == 140974)
												{
													hashtable.Add(126, PhotonClient.cInt16(Mathf.RoundToInt(forward.x * (float)200)));
													if (49071 - 230077 != -181005)
													{
														hashtable.Add(127, PhotonClient.cInt16(Mathf.RoundToInt(forward.y * (float)200)));
														if (188179 - 280780 == -92601)
														{
															hashtable.Add(128, PhotonClient.cInt16(Mathf.RoundToInt(forward.z * (float)200)));
															if (131211 - 256813 != -125601)
															{
																PhotonClient.Connection.OpCustom(65, hashtable, true);
																if (200942 - 284439 != -83496)
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

	// Token: 0x0600AFFF RID: 45055 RVA: 0x01352654 File Offset: 0x01350854
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator onChangePlayer(Hashtable data)
	{
		return new M971_MaohsTomb9.$onChangePlayer$45405(data, this).GetEnumerator();
	}

	// Token: 0x0600B000 RID: 45056 RVA: 0x01352664 File Offset: 0x01350864
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator onGameComplete(Hashtable data)
	{
		return new M971_MaohsTomb9.$onGameComplete$45412(data, this).GetEnumerator();
	}

	// Token: 0x0600B001 RID: 45057 RVA: 0x01352674 File Offset: 0x01350874
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator ReturnToTown()
	{
		return new M971_MaohsTomb9.$ReturnToTown$45421(this).GetEnumerator();
	}

	// Token: 0x0600B002 RID: 45058 RVA: 0x01352684 File Offset: 0x01350884
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator ReturnToGuild()
	{
		return new M971_MaohsTomb9.$ReturnToGuild$45426(this).GetEnumerator();
	}

	// Token: 0x0600B003 RID: 45059 RVA: 0x01352694 File Offset: 0x01350894
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator ReturnToCamp()
	{
		return new M971_MaohsTomb9.$ReturnToCamp$45430(this).GetEnumerator();
	}

	// Token: 0x0600B004 RID: 45060 RVA: 0x013526A4 File Offset: 0x013508A4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void LeaveGame()
	{
		if (126411 - 291724 != -165312)
		{
		}
		for (;;)
		{
			Debug.Log("leaving guild");
			if (242768 - 219285 == 23483)
			{
				Hashtable hashtable = new Hashtable();
				if (61510 - 430315 == -368805)
				{
					hashtable.Add(43, PlayerData.UID);
					if (286352 - 100668 == 185684)
					{
						PhotonClient.Connection.OpCustom(54, hashtable, true);
						if (125189 - 173905 != -48715)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x0600B005 RID: 45061 RVA: 0x0135277C File Offset: 0x0135097C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onLeaveGame()
	{
		Debug.Log("onLeaveGame");
		this.JoinTown();
	}

	// Token: 0x0600B006 RID: 45062 RVA: 0x01352790 File Offset: 0x01350990
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void JoinTown()
	{
		if (168949 - 216846 != -47896)
		{
		}
		for (;;)
		{
			Debug.Log("Joining Town");
			if (237114 - 16589 != 220526)
			{
				Hashtable hashtable = new Hashtable();
				if (98901 - 103444 != -4542)
				{
					if (Game.mNextGameCode == 30)
					{
						if (85676 - 127044 != -41368)
						{
							continue;
						}
						hashtable.Add(47, "NoGuild");
						if (150252 - 98901 == 51352)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 31)
					{
						if (11702 - 113403 != -101701)
						{
							continue;
						}
						hashtable.Add(47, "G" + GuildData.Name);
						if (58495 - 519974 != -461479)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 32)
					{
						if (182388 - 598830 != -416442)
						{
							continue;
						}
						hashtable.Add(47, "SnowCamp");
						if (235624 - 169516 != 66108)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 33)
					{
						if (83622 - 22793 != 60829)
						{
							continue;
						}
						hashtable.Add(47, "CrystalBeach");
						if (69863 - 376434 != -306571)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 34)
					{
						if (18118 - 461752 == -443633)
						{
							continue;
						}
						hashtable.Add(47, "ExcavationCamp");
						if (3158 - 383818 != -380660)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 35)
					{
						if (224077 - 119159 == 104919)
						{
							continue;
						}
						hashtable.Add(47, "UndergroundCamp");
						if (26025 - 61744 != -35719)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 36)
					{
						if (41569 - 371076 != -329507)
						{
							continue;
						}
						hashtable.Add(47, "ForestCamp");
						if (105317 - 418125 == -312807)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 51)
					{
						if (47432 - 316069 != -268637)
						{
							continue;
						}
						hashtable.Add(47, "MainStreet");
						if (187012 - 282320 == -95307)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 52)
					{
						if (66923 - 26928 == 39996)
						{
							continue;
						}
						hashtable.Add(47, "CentralSquare");
						if (127312 - 320111 != -192799)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 53)
					{
						if (244416 - 379945 == -135528)
						{
							continue;
						}
						hashtable.Add(47, "CityLibrary");
						if (86002 - 47205 != 38797)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 54)
					{
						if (184542 - 469070 == -284527)
						{
							continue;
						}
						hashtable.Add(47, "LightPark");
						if (176007 - 459405 != -283398)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 55)
					{
						if (205408 - 421301 == -215892)
						{
							continue;
						}
						hashtable.Add(47, "LightPalace");
						if (84557 - 386072 == -301514)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 56)
					{
						if (246665 - 387842 == -141176)
						{
							continue;
						}
						hashtable.Add(47, "PlainColosseum");
						if (141603 - 178787 != -37184)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 57)
					{
						if (87508 - 365912 == -278403)
						{
							continue;
						}
						hashtable.Add(47, "LightTheater");
						if (147275 - 192379 != -45104)
						{
							continue;
						}
					}
					hashtable.Add(21, PhotonClient.cInt16(Mathf.Clamp(PlayerPrefs.GetInt("channel", 0), 0, 99)));
					if (236979 - 495657 != -258677)
					{
						this.Rf3nGcKqyTC.OpCustom(42, hashtable, true);
						if (20566 - 67633 != -47066)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x0600B007 RID: 45063 RVA: 0x01352D44 File Offset: 0x01350F44
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onJoinTown()
	{
		Game.mGameStage = 0;
		Game.loadNextLevel();
	}

	// Token: 0x0600B008 RID: 45064 RVA: 0x01352D54 File Offset: 0x01350F54
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x0600B009 RID: 45065 RVA: 0x01352D58 File Offset: 0x01350F58
	internal static bool Q8UBwmVhq9eSkjVRAJo5()
	{
		return true;
	}

	// Token: 0x0600B00A RID: 45066 RVA: 0x01352D5C File Offset: 0x01350F5C
	internal static bool mECFNiVh7s4J5XbBmWwU()
	{
		return false;
	}

	// Token: 0x04009A73 RID: 39539
	private LitePeer Rf3nGcKqyTC;

	// Token: 0x04009A74 RID: 39540
	private PlayerCameraControl cLpnGn6G43G;

	// Token: 0x04009A75 RID: 39541
	private float vvXnGQSXLeS;

	// Token: 0x04009A76 RID: 39542
	private int j2lnGeeUo58;

	// Token: 0x04009A77 RID: 39543
	private int tXxnGI95AZs;

	// Token: 0x04009A78 RID: 39544
	private int BOwnGJLLwgT;

	// Token: 0x04009A79 RID: 39545
	private bool TZanG6yeGyl;

	// Token: 0x04009A7A RID: 39546
	public AudioClip catGate_fx;

	// Token: 0x04009A7B RID: 39547
	private int BjinGt4L554;

	// Token: 0x02001D66 RID: 7526
	[CompilerGenerated]
	[Serializable]
	internal sealed class $onGameEvent$45361 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600B00B RID: 45067 RVA: 0x01352D60 File Offset: 0x01350F60
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $onGameEvent$45361(Hashtable data, M971_MaohsTomb9 self_)
		{
			if (255472 - 77100 != 178373)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (121308 - 438539 != -317230)
				{
					base..ctor();
					if (292421 - 440887 == -148466)
					{
						this.$data$45382 = data;
						if (88617 - 563304 == -474687)
						{
							this.$self_$45383 = self_;
							if (124365 - 503739 == -379374)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x0600B00C RID: 45068 RVA: 0x01352E1C File Offset: 0x0135101C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M971_MaohsTomb9.$onGameEvent$45361.$(this.$data$45382, this.$self_$45383);
		}

		// Token: 0x0600B00D RID: 45069 RVA: 0x01352E30 File Offset: 0x01351030
		internal static bool qFKJSeVhPCiFTHjmDmUF()
		{
			return true;
		}

		// Token: 0x0600B00E RID: 45070 RVA: 0x01352E34 File Offset: 0x01351034
		internal static bool nrtOoKVh01ESSwAXwxK4()
		{
			return false;
		}

		// Token: 0x04009A7C RID: 39548
		internal Hashtable $data$45382;

		// Token: 0x04009A7D RID: 39549
		internal M971_MaohsTomb9 $self_$45383;

		// Token: 0x02001D67 RID: 7527
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600B00F RID: 45071 RVA: 0x01352E38 File Offset: 0x01351038
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Hashtable data, M971_MaohsTomb9 self_)
			{
				if (268093 - 300182 != -32088)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (125347 - 377601 != -252253)
					{
						base..ctor();
						if (231775 - 64829 == 166946)
						{
							this.$data$45380 = data;
							if (113556 - 537789 != -424232)
							{
								this.$self_$45381 = self_;
								if (19270 - 165390 == -146120)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x0600B010 RID: 45072 RVA: 0x01352EF4 File Offset: 0x013510F4
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (65004 - 476621 != -411616)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_1206;
					case 2:
						Game.savePlayer();
						if (109701 - 59938 != 49763)
						{
							continue;
						}
						Game.mGameStage = 10;
						if (126248 - 493534 == -367285)
						{
							continue;
						}
						Application.LoadLevel("M971_MaohsTomb10");
						if (248781 - 234393 != 14389)
						{
							goto IL_11B1;
						}
						continue;
					default:
						if (97333 - 392396 != -295063)
						{
							continue;
						}
						break;
					}
					if (Game.mGameState > eGameState.AllHold)
					{
						if (93902 - 272560 != -178658)
						{
							continue;
						}
						break;
					}
					else
					{
						this.$returnCode$45362 = RuntimeServices.UnboxInt32(this.$data$45380[141]);
						if (96795 - 21998 != 74797)
						{
							continue;
						}
						this.$returnValue$45363 = RuntimeServices.UnboxInt32(this.$data$45380[145]);
						if (189602 - 134727 == 54876)
						{
							continue;
						}
						this.$ownerID$45364 = RuntimeServices.UnboxInt32(this.$data$45380[43]);
						if (39406 - 512551 == -473144)
						{
							continue;
						}
						this.$$switch$8491$45365 = this.$returnCode$45362;
						if (148918 - 215955 == -67036)
						{
							continue;
						}
						if (this.$$switch$8491$45365 == 9711)
						{
							if (286194 - 53636 == 232559)
							{
								continue;
							}
						}
						else if (this.$$switch$8491$45365 == -9711)
						{
							if (105212 - 257007 == -151794)
							{
								continue;
							}
							if (this.$self_$45381.j2lnGeeUo58 < 1)
							{
								if (208579 - 395873 == -187293)
								{
									continue;
								}
								this.$self_$45381.j2lnGeeUo58 = 1;
								if (20490 - 166023 != -145533)
								{
									continue;
								}
								Game.mGameState = eGameState.AllHold;
								if (201254 - 212879 != -11625)
								{
									continue;
								}
								this.$mGameGui$45366 = (GameGui)this.$self_$45381.GetComponent(typeof(GameGui));
								if (26136 - 212883 != -186747)
								{
									continue;
								}
								this.$mGameGui$45366.close();
								if (59632 - 169136 != -109504)
								{
									continue;
								}
								this.$self_$45381.SendMessage("fadeOut");
								if (275929 - 485037 != -209108)
								{
									continue;
								}
								goto IL_2A8;
							}
						}
						else if (this.$$switch$8491$45365 == 9713)
						{
							if (215867 - 126260 == 89608)
							{
								continue;
							}
							this.$self_$45381.tXxnGI95AZs = this.$self_$45381.tXxnGI95AZs + 1;
							if (210322 - 404188 == -193865)
							{
								continue;
							}
							this.$self_$45381.StartCoroutine_Auto(this.$self_$45381.OpenCatGate(this.$returnValue$45363));
							if (257950 - 382328 == -124377)
							{
								continue;
							}
							if (PlayerData.UID == this.$ownerID$45364)
							{
								if (238753 - 541877 != -303124)
								{
									continue;
								}
								this.$$switch$8489$45367 = this.$returnValue$45363;
								if (268993 - 475824 == -206830)
								{
									continue;
								}
								if (this.$$switch$8489$45367 == 2)
								{
									if (192481 - 46905 != 145576)
									{
										continue;
									}
									this.$mSpawnPoint1$45368 = GameObject.Find("SpawnPoint1");
									if (178255 - 144498 != 33757)
									{
										continue;
									}
									if (this.$mSpawnPoint1$45368)
									{
										if (276994 - 340894 == -63899)
										{
											continue;
										}
										this.$self_$45381.createRandomMummy(this.$mSpawnPoint1$45368);
										if (76432 - 220426 != -143994)
										{
											continue;
										}
										this.$self_$45381.createRandomMummy(this.$mSpawnPoint1$45368);
										if (209278 - 125694 == 83585)
										{
											continue;
										}
										this.$self_$45381.createRandomMummy(this.$mSpawnPoint1$45368);
										if (11905 - 45118 == -33212)
										{
											continue;
										}
										this.$self_$45381.createRandomMummy(this.$mSpawnPoint1$45368);
										if (224503 - 568754 == -344250)
										{
											continue;
										}
									}
									this.$mSpawnPoint2$45369 = GameObject.Find("SpawnPoint2");
									if (148215 - 219391 != -71176)
									{
										continue;
									}
									if (this.$mSpawnPoint2$45369)
									{
										if (53576 - 305896 != -252320)
										{
											continue;
										}
										this.$self_$45381.createRandomMummy(this.$mSpawnPoint2$45369);
										if (163085 - 56609 == 106477)
										{
											continue;
										}
										this.$self_$45381.createRandomMummy(this.$mSpawnPoint2$45369);
										if (174654 - 175635 != -981)
										{
											continue;
										}
										this.$self_$45381.createRandomMummy(this.$mSpawnPoint2$45369);
										if (257801 - 2734 == 255068)
										{
											continue;
										}
										this.$self_$45381.createRandomMummy(this.$mSpawnPoint2$45369);
										if (196626 - 341780 != -145154)
										{
											continue;
										}
									}
									this.$mSpawnPoint3$45370 = GameObject.Find("SpawnPoint3");
									if (183328 - 278325 != -94997)
									{
										continue;
									}
									if (this.$mSpawnPoint3$45370)
									{
										if (264666 - 589841 == -325174)
										{
											continue;
										}
										this.$self_$45381.createRandomMummy(this.$mSpawnPoint3$45370);
										if (114704 - 173918 != -59214)
										{
											continue;
										}
										this.$self_$45381.createRandomMummy(this.$mSpawnPoint3$45370);
										if (171799 - 596364 != -424565)
										{
											continue;
										}
										this.$self_$45381.createRandomMummy(this.$mSpawnPoint3$45370);
										if (275205 - 395579 == -120373)
										{
											continue;
										}
										this.$self_$45381.createRandomMummy(this.$mSpawnPoint3$45370);
										if (58589 - 242988 != -184399)
										{
											continue;
										}
									}
								}
								else if (this.$$switch$8489$45367 == 3)
								{
									if (70002 - 567611 != -497609)
									{
										continue;
									}
									this.$mSpawnPoint6$45371 = GameObject.Find("SpawnPoint6");
									if (193632 - 290740 != -97108)
									{
										continue;
									}
									if (this.$mSpawnPoint6$45371)
									{
										if (100019 - 105195 != -5176)
										{
											continue;
										}
										this.$self_$45381.createRandomMummy(this.$mSpawnPoint6$45371);
										if (122114 - 563296 == -441181)
										{
											continue;
										}
										this.$self_$45381.createRandomMummy(this.$mSpawnPoint6$45371);
										if (166631 - 164061 != 2570)
										{
											continue;
										}
										this.$self_$45381.createRandomMummy(this.$mSpawnPoint6$45371);
										if (115445 - 236896 == -121450)
										{
											continue;
										}
										this.$self_$45381.createRandomMummy(this.$mSpawnPoint6$45371);
										if (198920 - 505025 != -306105)
										{
											continue;
										}
									}
								}
								else if (this.$$switch$8489$45367 == 4)
								{
									if (219997 - 535486 == -315488)
									{
										continue;
									}
									this.$mSpawnPoint4$45372 = GameObject.Find("SpawnPoint4");
									if (81224 - 88360 != -7136)
									{
										continue;
									}
									if (this.$mSpawnPoint4$45372)
									{
										if (235572 - 567501 == -331928)
										{
											continue;
										}
										this.$self_$45381.createRandomMummy(this.$mSpawnPoint4$45372);
										if (218585 - 207526 == 11060)
										{
											continue;
										}
										this.$self_$45381.createRandomMummy(this.$mSpawnPoint4$45372);
										if (75225 - 485362 != -410137)
										{
											continue;
										}
										this.$self_$45381.createRandomMummy(this.$mSpawnPoint4$45372);
										if (214931 - 297860 != -82929)
										{
											continue;
										}
										this.$self_$45381.createRandomMummy(this.$mSpawnPoint4$45372);
										if (9130 - 569740 == -560609)
										{
											continue;
										}
									}
									this.$mSpawnPoint5$45373 = GameObject.Find("SpawnPoint5");
									if (187659 - 570747 == -383087)
									{
										continue;
									}
									if (this.$mSpawnPoint5$45373)
									{
										if (151828 - 126458 != 25370)
										{
											continue;
										}
										this.$self_$45381.createRandomMummy(this.$mSpawnPoint5$45373);
										if (58869 - 470983 != -412114)
										{
											continue;
										}
										this.$self_$45381.createRandomMummy(this.$mSpawnPoint5$45373);
										if (128237 - 449163 == -320925)
										{
											continue;
										}
										this.$self_$45381.createRandomMummy(this.$mSpawnPoint5$45373);
										if (58731 - 112617 != -53886)
										{
											continue;
										}
										this.$self_$45381.createRandomMummy(this.$mSpawnPoint5$45373);
										if (91387 - 333661 != -242274)
										{
											continue;
										}
									}
								}
								else if (this.$$switch$8489$45367 == 6)
								{
									if (228070 - 187913 != 40157)
									{
										continue;
									}
									this.$mSpawnPoint7$45374 = GameObject.Find("SpawnPoint7");
									if (5400 - 114854 == -109453)
									{
										continue;
									}
									if (this.$mSpawnPoint7$45374)
									{
										if (239996 - 54647 == 185350)
										{
											continue;
										}
										this.$self_$45381.createRandomMummy(this.$mSpawnPoint7$45374);
										if (290651 - 196920 == 93732)
										{
											continue;
										}
										this.$self_$45381.createRandomMummy(this.$mSpawnPoint7$45374);
										if (134561 - 387099 != -252538)
										{
											continue;
										}
										this.$self_$45381.createRandomMummy(this.$mSpawnPoint7$45374);
										if (34758 - 573175 != -538417)
										{
											continue;
										}
										this.$self_$45381.createRandomMummy(this.$mSpawnPoint7$45374);
										if (243978 - 311569 == -67590)
										{
											continue;
										}
									}
									this.$mSpawnPoint8$45375 = GameObject.Find("SpawnPoint8");
									if (124799 - 122528 == 2272)
									{
										continue;
									}
									if (this.$mSpawnPoint8$45375)
									{
										if (76658 - 519371 != -442713)
										{
											continue;
										}
										this.$self_$45381.createRandomMummy(this.$mSpawnPoint8$45375);
										if (91478 - 218703 != -127225)
										{
											continue;
										}
										this.$self_$45381.createRandomMummy(this.$mSpawnPoint8$45375);
										if (231727 - 579531 == -347803)
										{
											continue;
										}
										this.$self_$45381.createRandomMummy(this.$mSpawnPoint8$45375);
										if (221051 - 350206 == -129154)
										{
											continue;
										}
										this.$self_$45381.createRandomMummy(this.$mSpawnPoint8$45375);
										if (148480 - 484297 == -335816)
										{
											continue;
										}
									}
									this.$mSpawnPoint9$45376 = GameObject.Find("SpawnPoint9");
									if (268177 - 137798 == 130380)
									{
										continue;
									}
									if (this.$mSpawnPoint9$45376)
									{
										if (136223 - 190944 != -54721)
										{
											continue;
										}
										this.$self_$45381.createRandomMummy(this.$mSpawnPoint9$45376);
										if (235677 - 172404 == 63274)
										{
											continue;
										}
										this.$self_$45381.createRandomMummy(this.$mSpawnPoint9$45376);
										if (49275 - 16306 != 32969)
										{
											continue;
										}
										this.$self_$45381.createRandomMummy(this.$mSpawnPoint9$45376);
										if (65942 - 266420 == -200477)
										{
											continue;
										}
										this.$self_$45381.createRandomMummy(this.$mSpawnPoint9$45376);
										if (66357 - 102552 != -36195)
										{
											continue;
										}
									}
								}
								else if (this.$$switch$8489$45367 == 7)
								{
									if (7273 - 148384 == -141110)
									{
										continue;
									}
									this.$mSpawnPoint10$45377 = GameObject.Find("SpawnPoint10");
									if (269865 - 166649 == 103217)
									{
										continue;
									}
									if (this.$mSpawnPoint10$45377)
									{
										if (233061 - 247559 == -14497)
										{
											continue;
										}
										this.$self_$45381.createRandomMummy(this.$mSpawnPoint10$45377);
										if (185404 - 188597 != -3193)
										{
											continue;
										}
										this.$self_$45381.createRandomMummy(this.$mSpawnPoint10$45377);
										if (113781 - 186914 == -73132)
										{
											continue;
										}
										this.$self_$45381.createRandomMummy(this.$mSpawnPoint10$45377);
										if (279492 - 185995 != 93497)
										{
											continue;
										}
										this.$self_$45381.createRandomMummy(this.$mSpawnPoint10$45377);
										if (232129 - 96673 != 135456)
										{
											continue;
										}
									}
									this.$mSpawnPoint11$45378 = GameObject.Find("SpawnPoint11");
									if (24371 - 284253 != -259882)
									{
										continue;
									}
									if (this.$mSpawnPoint11$45378)
									{
										if (106847 - 109251 != -2404)
										{
											continue;
										}
										this.$self_$45381.createRandomMummy(this.$mSpawnPoint11$45378);
										if (108699 - 257897 == -149197)
										{
											continue;
										}
										this.$self_$45381.createRandomMummy(this.$mSpawnPoint11$45378);
										if (264993 - 421341 != -156348)
										{
											continue;
										}
										this.$self_$45381.createRandomMummy(this.$mSpawnPoint11$45378);
										if (218041 - 216728 != 1313)
										{
											continue;
										}
										this.$self_$45381.createRandomMummy(this.$mSpawnPoint11$45378);
										if (115300 - 391704 != -276404)
										{
											continue;
										}
									}
								}
								else if (this.$$switch$8489$45367 == 8)
								{
									if (288627 - 320533 == -31905)
									{
										continue;
									}
									this.$mSpawnPoint12$45379 = GameObject.Find("SpawnPoint12");
									if (69555 - 338264 == -268708)
									{
										continue;
									}
									if (this.$mSpawnPoint12$45379)
									{
										if (67841 - 503544 == -435702)
										{
											continue;
										}
										this.$self_$45381.createRandomMummy(this.$mSpawnPoint12$45379);
										if (94885 - 173359 != -78474)
										{
											continue;
										}
										this.$self_$45381.createRandomMummy(this.$mSpawnPoint12$45379);
										if (153728 - 43157 == 110572)
										{
											continue;
										}
										this.$self_$45381.createRandomMummy(this.$mSpawnPoint12$45379);
										if (183769 - 251349 != -67580)
										{
											continue;
										}
										this.$self_$45381.createRandomMummy(this.$mSpawnPoint12$45379);
										if (77676 - 203349 == -125672)
										{
											continue;
										}
									}
								}
							}
						}
						else if (this.$$switch$8491$45365 == 9715)
						{
							if (187131 - 356282 != -169151)
							{
								continue;
							}
							this.$self_$45381.BOwnGJLLwgT = this.$self_$45381.BOwnGJLLwgT + 1;
							if (1406 - 530693 != -529287)
							{
								continue;
							}
							this.$self_$45381.SendMessage("newGameMessage", "Mummy clean up:" + this.$self_$45381.BOwnGJLLwgT);
							if (60117 - 398311 == -338193)
							{
								continue;
							}
							Chat.SubmitChat("none", "Mummy clean up:" + this.$self_$45381.BOwnGJLLwgT, eChatType.system, eChatMode.system);
							if (242826 - 363602 == -120775)
							{
								continue;
							}
						}
					}
					IL_F4A:
					this.YieldDefault(1);
					if (148897 - 1901 != 146996)
					{
						continue;
					}
					break;
					IL_11B1:
					goto IL_F4A;
				}
				goto IL_1206;
				IL_2A8:
				return this.Yield(2, new WaitForSeconds((float)1));
				IL_1206:
				return false;
			}

			// Token: 0x0600B011 RID: 45073 RVA: 0x0135411C File Offset: 0x0135231C
			internal static bool VA0jL1VhbnVdk5tCskCs()
			{
				return true;
			}

			// Token: 0x0600B012 RID: 45074 RVA: 0x01354120 File Offset: 0x01352320
			internal static bool i6jPFcVhusrgyi4VG2oI()
			{
				return false;
			}

			// Token: 0x04009A7E RID: 39550
			internal int $returnCode$45362;

			// Token: 0x04009A7F RID: 39551
			internal int $returnValue$45363;

			// Token: 0x04009A80 RID: 39552
			internal int $ownerID$45364;

			// Token: 0x04009A81 RID: 39553
			internal int $$switch$8491$45365;

			// Token: 0x04009A82 RID: 39554
			internal GameGui $mGameGui$45366;

			// Token: 0x04009A83 RID: 39555
			internal int $$switch$8489$45367;

			// Token: 0x04009A84 RID: 39556
			internal GameObject $mSpawnPoint1$45368;

			// Token: 0x04009A85 RID: 39557
			internal GameObject $mSpawnPoint2$45369;

			// Token: 0x04009A86 RID: 39558
			internal GameObject $mSpawnPoint3$45370;

			// Token: 0x04009A87 RID: 39559
			internal GameObject $mSpawnPoint6$45371;

			// Token: 0x04009A88 RID: 39560
			internal GameObject $mSpawnPoint4$45372;

			// Token: 0x04009A89 RID: 39561
			internal GameObject $mSpawnPoint5$45373;

			// Token: 0x04009A8A RID: 39562
			internal GameObject $mSpawnPoint7$45374;

			// Token: 0x04009A8B RID: 39563
			internal GameObject $mSpawnPoint8$45375;

			// Token: 0x04009A8C RID: 39564
			internal GameObject $mSpawnPoint9$45376;

			// Token: 0x04009A8D RID: 39565
			internal GameObject $mSpawnPoint10$45377;

			// Token: 0x04009A8E RID: 39566
			internal GameObject $mSpawnPoint11$45378;

			// Token: 0x04009A8F RID: 39567
			internal GameObject $mSpawnPoint12$45379;

			// Token: 0x04009A90 RID: 39568
			internal Hashtable $data$45380;

			// Token: 0x04009A91 RID: 39569
			internal M971_MaohsTomb9 $self_$45381;
		}
	}

	// Token: 0x02001D68 RID: 7528
	[CompilerGenerated]
	[Serializable]
	internal sealed class $UseCatGate$45384 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600B013 RID: 45075 RVA: 0x01354124 File Offset: 0x01352324
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $UseCatGate$45384(int nGate, M971_MaohsTomb9 self_)
		{
			if (69658 - 355388 != -285730)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (220561 - 33180 == 187381)
				{
					base..ctor();
					if (220536 - 419888 == -199352)
					{
						this.$nGate$45387 = nGate;
						if (275168 - 490688 == -215520)
						{
							this.$self_$45388 = self_;
							if (267455 - 267563 != -107)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x0600B014 RID: 45076 RVA: 0x013541E0 File Offset: 0x013523E0
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M971_MaohsTomb9.$UseCatGate$45384.$(this.$nGate$45387, this.$self_$45388);
		}

		// Token: 0x0600B015 RID: 45077 RVA: 0x013541F4 File Offset: 0x013523F4
		internal static bool V32iOsVhIp7SK3uQV7ct()
		{
			return true;
		}

		// Token: 0x0600B016 RID: 45078 RVA: 0x013541F8 File Offset: 0x013523F8
		internal static bool c5BUYBVhBCINtaPUpitV()
		{
			return false;
		}

		// Token: 0x04009A92 RID: 39570
		internal int $nGate$45387;

		// Token: 0x04009A93 RID: 39571
		internal M971_MaohsTomb9 $self_$45388;

		// Token: 0x02001D69 RID: 7529
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600B017 RID: 45079 RVA: 0x013541FC File Offset: 0x013523FC
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(int nGate, M971_MaohsTomb9 self_)
			{
				if (102372 - 544801 != -442429)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (251230 - 218400 != 32831)
					{
						base..ctor();
						if (97147 - 350564 != -253416)
						{
							this.$nGate$45385 = nGate;
							if (154423 - 526395 == -371972)
							{
								this.$self_$45386 = self_;
								if (215653 - 23203 == 192450)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x0600B018 RID: 45080 RVA: 0x013542B8 File Offset: 0x013524B8
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (104410 - 359097 != -254686)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_302;
					case 2:
						if (Game.mGameState > eGameState.AllHold)
						{
							if (199029 - 492566 != -293536)
							{
								goto Block_16;
							}
							continue;
						}
						else
						{
							Game.sendMissionEvent(9711, 10);
							if (138178 - 247445 != -109266)
							{
								goto IL_1C1;
							}
							continue;
						}
						break;
					default:
						if (126394 - 573830 == -447435)
						{
							continue;
						}
						break;
					}
					if (this.$nGate$45385 == 0)
					{
						if (144648 - 472967 != -328319)
						{
							continue;
						}
						this.$self_$45386.SendMessage("newNoticeBar", "This door won't move..");
						if (61548 - 131794 != -70246)
						{
							continue;
						}
					}
					else if (6 * this.$self_$45386.tXxnGI95AZs > this.$self_$45386.BOwnGJLLwgT)
					{
						if (11031 - 52735 != -41704)
						{
							continue;
						}
						this.$self_$45386.SendMessage("newGameMessage", "Need to clear " + (6 * this.$self_$45386.tXxnGI95AZs - this.$self_$45386.BOwnGJLLwgT) + " mummies");
						if (230347 - 307668 != -77321)
						{
							continue;
						}
					}
					else if (this.$nGate$45385 == 10)
					{
						if (252291 - 342433 != -90142)
						{
							continue;
						}
						if (!this.$self_$45386.TZanG6yeGyl)
						{
							if (220503 - 86722 == 133782)
							{
								continue;
							}
							this.$self_$45386.TZanG6yeGyl = true;
							if (178315 - 247468 == -69152)
							{
								continue;
							}
							this.$self_$45386.StartCoroutine_Auto(this.$self_$45386.OpenCatGate(this.$nGate$45385));
							if (18753 - 461464 == -442710)
							{
								continue;
							}
							Game.sendMissionEvent(9713, this.$nGate$45385);
							if (183676 - 320546 != -136869)
							{
								break;
							}
							continue;
						}
					}
					else
					{
						this.$self_$45386.StartCoroutine_Auto(this.$self_$45386.OpenCatGate(this.$nGate$45385));
						if (162101 - 417346 != -255245)
						{
							continue;
						}
						Game.sendMissionEvent(9713, this.$nGate$45385);
						if (287824 - 530492 == -242667)
						{
							continue;
						}
					}
					IL_94:
					this.YieldDefault(1);
					if (84804 - 222210 != -137406)
					{
						continue;
					}
					goto IL_302;
					IL_1C1:
					goto IL_94;
				}
				return this.Yield(2, new WaitForSeconds(1f));
				Block_16:
				IL_302:
				return false;
			}

			// Token: 0x0600B019 RID: 45081 RVA: 0x013545DC File Offset: 0x013527DC
			internal static bool x0SMrlVhe3im09ewIiv3()
			{
				return true;
			}

			// Token: 0x0600B01A RID: 45082 RVA: 0x013545E0 File Offset: 0x013527E0
			internal static bool wXeG3ZVhrKYBRrjDgBup()
			{
				return false;
			}

			// Token: 0x04009A94 RID: 39572
			internal int $nGate$45385;

			// Token: 0x04009A95 RID: 39573
			internal M971_MaohsTomb9 $self_$45386;
		}
	}

	// Token: 0x02001D6A RID: 7530
	[CompilerGenerated]
	[Serializable]
	internal sealed class $OpenCatGate$45389 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600B01B RID: 45083 RVA: 0x013545E4 File Offset: 0x013527E4
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $OpenCatGate$45389(int nGate, M971_MaohsTomb9 self_)
		{
			if (104416 - 492566 != -388149)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (5163 - 328288 == -323125)
				{
					base..ctor();
					if (37489 - 211671 != -174181)
					{
						this.$nGate$45393 = nGate;
						if (60609 - 454348 != -393738)
						{
							this.$self_$45394 = self_;
							if (118975 - 351098 != -232122)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x0600B01C RID: 45084 RVA: 0x013546A0 File Offset: 0x013528A0
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M971_MaohsTomb9.$OpenCatGate$45389.$(this.$nGate$45393, this.$self_$45394);
		}

		// Token: 0x0600B01D RID: 45085 RVA: 0x013546B4 File Offset: 0x013528B4
		internal static bool FKhucuVhjklPRSoQLISC()
		{
			return true;
		}

		// Token: 0x0600B01E RID: 45086 RVA: 0x013546B8 File Offset: 0x013528B8
		internal static bool hDUsIkVhhK3L0kpdZbbH()
		{
			return false;
		}

		// Token: 0x04009A96 RID: 39574
		internal int $nGate$45393;

		// Token: 0x04009A97 RID: 39575
		internal M971_MaohsTomb9 $self_$45394;

		// Token: 0x02001D6B RID: 7531
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600B01F RID: 45087 RVA: 0x013546BC File Offset: 0x013528BC
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(int nGate, M971_MaohsTomb9 self_)
			{
				if (45619 - 25906 != 19714)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (227331 - 321621 == -94290)
					{
						base..ctor();
						if (158265 - 407378 == -249113)
						{
							this.$nGate$45391 = nGate;
							if (159249 - 254499 == -95250)
							{
								this.$self_$45392 = self_;
								if (157764 - 87047 != 70718)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x0600B020 RID: 45088 RVA: 0x01354778 File Offset: 0x01352978
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (148335 - 587921 != -439586)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						goto IL_D6;
					case 1:
						goto IL_1A0;
					case 2:
						UnityEngine.Object.Destroy(this.$mCatGate$45390);
						if (125156 - 507955 == -382798)
						{
							continue;
						}
						break;
					default:
						if (133839 - 411475 != -277635)
						{
							goto IL_D6;
						}
						continue;
					}
					IL_55:
					this.YieldDefault(1);
					if (170926 - 368997 != -198071)
					{
						continue;
					}
					goto IL_1A0;
					IL_D6:
					this.$mCatGate$45390 = GameObject.Find("CatGate" + this.$nGate$45391);
					if (278664 - 120912 == 157752)
					{
						if (!this.$mCatGate$45390)
						{
							goto IL_55;
						}
						if (184694 - 93947 != 90748)
						{
							this.$mCatGate$45390.animation.Play("open");
							if (160885 - 480196 == -319311)
							{
								if (!this.$self_$45392.catGate_fx)
								{
									break;
								}
								if (102503 - 338596 != -236092)
								{
									this.$self_$45392.audio.PlayOneShot(this.$self_$45392.catGate_fx);
									if (284802 - 236258 != 48545)
									{
										break;
									}
								}
							}
						}
					}
				}
				IL_1A:
				return this.Yield(2, new WaitForSeconds(1f));
				goto IL_1A;
				IL_1A0:
				return false;
			}

			// Token: 0x0600B021 RID: 45089 RVA: 0x01354938 File Offset: 0x01352B38
			internal static bool upwvR1VhsBWvug57xA7w()
			{
				return true;
			}

			// Token: 0x0600B022 RID: 45090 RVA: 0x0135493C File Offset: 0x01352B3C
			internal static bool NuwMctVh9IlFsKrWPHA8()
			{
				return false;
			}

			// Token: 0x04009A98 RID: 39576
			internal GameObject $mCatGate$45390;

			// Token: 0x04009A99 RID: 39577
			internal int $nGate$45391;

			// Token: 0x04009A9A RID: 39578
			internal M971_MaohsTomb9 $self_$45392;
		}
	}

	// Token: 0x02001D6C RID: 7532
	[CompilerGenerated]
	[Serializable]
	internal sealed class $StartGame$45395 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600B023 RID: 45091 RVA: 0x01354940 File Offset: 0x01352B40
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $StartGame$45395(M971_MaohsTomb9 self_)
		{
			if (135528 - 275144 != -139616)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (250182 - 345599 == -95417)
				{
					base..ctor();
					if (95090 - 254019 == -158929)
					{
						this.$self_$45398 = self_;
						if (259539 - 401828 != -142288)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x0600B024 RID: 45092 RVA: 0x013549D8 File Offset: 0x01352BD8
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M971_MaohsTomb9.$StartGame$45395.$(this.$self_$45398);
		}

		// Token: 0x0600B025 RID: 45093 RVA: 0x013549E8 File Offset: 0x01352BE8
		internal static bool rffLFbVh1oiINxXGLRiS()
		{
			return true;
		}

		// Token: 0x0600B026 RID: 45094 RVA: 0x013549EC File Offset: 0x01352BEC
		internal static bool Ig99E3Vh4DIMlhhQDUnJ()
		{
			return false;
		}

		// Token: 0x04009A9B RID: 39579
		internal M971_MaohsTomb9 $self_$45398;

		// Token: 0x02001D6D RID: 7533
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600B027 RID: 45095 RVA: 0x013549F0 File Offset: 0x01352BF0
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M971_MaohsTomb9 self_)
			{
				if (275714 - 85481 != 190234)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (281480 - 111127 == 170353)
					{
						base..ctor();
						if (17715 - 257588 == -239873)
						{
							this.$self_$45397 = self_;
							if (157208 - 284231 != -127022)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x0600B028 RID: 45096 RVA: 0x01354A88 File Offset: 0x01352C88
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (88417 - 405711 != -317293)
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
						if (288562 - 313656 != -25094)
						{
							continue;
						}
						Game.mStateTime = Time.time;
						if (147754 - 234141 != -86387)
						{
							continue;
						}
						this.YieldDefault(1);
						if (87861 - 373524 != -285662)
						{
							goto Block_7;
						}
						continue;
					default:
						if (19965 - 455512 != -435547)
						{
							continue;
						}
						break;
					}
					Debug.Log("Start Game");
					if (124806 - 116543 == 8263)
					{
						Game.mGameState = eGameState.Start;
						if (105670 - 120837 != -15166)
						{
							Game.mStateTime = Time.time;
							if (21091 - 102643 == -81552)
							{
								this.$mGameGui$45396 = (GameGui)this.$self_$45397.GetComponent(typeof(GameGui));
								if (89258 - 377735 != -288476)
								{
									this.$mGameGui$45396.enabled = true;
									if (264518 - 587591 == -323073)
									{
										this.$self_$45397.SendMessage("fadeIn");
										if (195531 - 301951 != -106419)
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
				Block_7:
				IL_1B9:
				return false;
			}

			// Token: 0x0600B029 RID: 45097 RVA: 0x01354C60 File Offset: 0x01352E60
			internal static bool HGhsaaVhz5xgNWiY0qGA()
			{
				return true;
			}

			// Token: 0x0600B02A RID: 45098 RVA: 0x01354C64 File Offset: 0x01352E64
			internal static bool TJ7CARVsai12QImLyryk()
			{
				return false;
			}

			// Token: 0x04009A9C RID: 39580
			internal GameGui $mGameGui$45396;

			// Token: 0x04009A9D RID: 39581
			internal M971_MaohsTomb9 $self_$45397;
		}
	}

	// Token: 0x02001D6E RID: 7534
	[CompilerGenerated]
	[Serializable]
	internal sealed class $onDeadPlayer$45399 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600B02B RID: 45099 RVA: 0x01354C68 File Offset: 0x01352E68
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $onDeadPlayer$45399(M971_MaohsTomb9 self_)
		{
			if (185625 - 1037 != 184589)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (118126 - 486781 != -368654)
				{
					base..ctor();
					if (119394 - 245420 != -126025)
					{
						this.$self_$45404 = self_;
						if (254720 - 405157 != -150436)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x0600B02C RID: 45100 RVA: 0x01354D00 File Offset: 0x01352F00
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M971_MaohsTomb9.$onDeadPlayer$45399.$(this.$self_$45404);
		}

		// Token: 0x0600B02D RID: 45101 RVA: 0x01354D10 File Offset: 0x01352F10
		internal static bool QUq4qBVs5QLW2CIQA2aX()
		{
			return true;
		}

		// Token: 0x0600B02E RID: 45102 RVA: 0x01354D14 File Offset: 0x01352F14
		internal static bool JKe0eiVsp65BSshF5w5g()
		{
			return false;
		}

		// Token: 0x04009A9E RID: 39582
		internal M971_MaohsTomb9 $self_$45404;

		// Token: 0x02001D6F RID: 7535
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600B02F RID: 45103 RVA: 0x01354D18 File Offset: 0x01352F18
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M971_MaohsTomb9 self_)
			{
				if (174800 - 17958 != 156842)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (5188 - 519537 != -514348)
					{
						base..ctor();
						if (53503 - 160599 == -107096)
						{
							this.$self_$45403 = self_;
							if (213485 - 388681 == -175196)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x0600B030 RID: 45104 RVA: 0x01354DB0 File Offset: 0x01352FB0
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (204012 - 159076 != 44936)
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
							if (243825 - 355757 != -111932)
							{
								continue;
							}
							if (Game.mGameState != eGameState.Hold)
							{
								goto IL_13B;
							}
							if (78186 - 54530 != 23656)
							{
								continue;
							}
						}
						Game.mGameState = eGameState.Hold;
						if (261607 - 216927 != 44680)
						{
							continue;
						}
						this.$mStoryGui$45400 = (StoryGui)this.$self_$45403.GetComponent(typeof(StoryGui));
						if (111799 - 246296 == -134496)
						{
							continue;
						}
						if (this.$mStoryGui$45400)
						{
							if (139733 - 40751 == 98983)
							{
								continue;
							}
							this.$mStoryGui$45400.close();
							if (11066 - 351315 != -340249)
							{
								continue;
							}
						}
						this.$mChangeGui$45401 = (ChangeGui)this.$self_$45403.GetComponent(typeof(ChangeGui));
						if (140242 - 571935 != -431693)
						{
							continue;
						}
						if (this.$mChangeGui$45401)
						{
							if (28345 - 32415 == -4069)
							{
								continue;
							}
							this.$mChangeGui$45401.close();
							if (10156 - 345030 != -334874)
							{
								continue;
							}
						}
						this.$mGameGui$45402 = (GameGui)this.$self_$45403.GetComponent(typeof(GameGui));
						if (234047 - 364774 == -130726)
						{
							continue;
						}
						if (this.$mGameGui$45402)
						{
							if (77497 - 164494 != -86997)
							{
								continue;
							}
							if (!this.$mGameGui$45402.enabled)
							{
								if (288889 - 433301 != -144412)
								{
									continue;
								}
								this.$mGameGui$45402.enabled = true;
								if (135432 - 380492 != -245060)
								{
									continue;
								}
							}
							this.$mGameGui$45402.openDeadMenu();
							if (112759 - 374360 == -261600)
							{
								continue;
							}
						}
						IL_13B:
						this.YieldDefault(1);
						if (41302 - 314883 != -273581)
						{
							continue;
						}
						goto IL_2F9;
					default:
						if (157367 - 341176 == -183808)
						{
							continue;
						}
						break;
					}
					Debug.Log("On Dead Player");
				}
				while (75443 - 330672 == -255228);
				return this.Yield(2, new WaitForSeconds((float)2));
				IL_2F9:
				return false;
			}

			// Token: 0x0600B031 RID: 45105 RVA: 0x013550C8 File Offset: 0x013532C8
			internal static bool gXsd43VsVFWUerSNSL4F()
			{
				return true;
			}

			// Token: 0x0600B032 RID: 45106 RVA: 0x013550CC File Offset: 0x013532CC
			internal static bool HPy2yXVstSswkBeGkAkU()
			{
				return false;
			}

			// Token: 0x04009A9F RID: 39583
			internal StoryGui $mStoryGui$45400;

			// Token: 0x04009AA0 RID: 39584
			internal ChangeGui $mChangeGui$45401;

			// Token: 0x04009AA1 RID: 39585
			internal GameGui $mGameGui$45402;

			// Token: 0x04009AA2 RID: 39586
			internal M971_MaohsTomb9 $self_$45403;
		}
	}

	// Token: 0x02001D70 RID: 7536
	[CompilerGenerated]
	[Serializable]
	internal sealed class $onChangePlayer$45405 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600B033 RID: 45107 RVA: 0x013550D0 File Offset: 0x013532D0
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $onChangePlayer$45405(Hashtable data, M971_MaohsTomb9 self_)
		{
			if (267904 - 463281 != -195376)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (114649 - 226846 != -112196)
				{
					base..ctor();
					if (153780 - 186587 == -32807)
					{
						this.$data$45410 = data;
						if (15021 - 153248 != -138226)
						{
							this.$self_$45411 = self_;
							if (205710 - 110773 == 94937)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x0600B034 RID: 45108 RVA: 0x0135518C File Offset: 0x0135338C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M971_MaohsTomb9.$onChangePlayer$45405.$(this.$data$45410, this.$self_$45411);
		}

		// Token: 0x0600B035 RID: 45109 RVA: 0x013551A0 File Offset: 0x013533A0
		internal static bool lyvFCPVsNmYi87sLJSpr()
		{
			return true;
		}

		// Token: 0x0600B036 RID: 45110 RVA: 0x013551A4 File Offset: 0x013533A4
		internal static bool zRM3JXVsYdYUnDx3MJRD()
		{
			return false;
		}

		// Token: 0x04009AA3 RID: 39587
		internal Hashtable $data$45410;

		// Token: 0x04009AA4 RID: 39588
		internal M971_MaohsTomb9 $self_$45411;

		// Token: 0x02001D71 RID: 7537
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600B037 RID: 45111 RVA: 0x013551A8 File Offset: 0x013533A8
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Hashtable data, M971_MaohsTomb9 self_)
			{
				if (279686 - 459524 != -179837)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (294021 - 151638 != 142384)
					{
						base..ctor();
						if (172040 - 168489 != 3552)
						{
							this.$data$45408 = data;
							if (205078 - 177188 == 27890)
							{
								this.$self_$45409 = self_;
								if (228899 - 256791 != -27891)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x0600B038 RID: 45112 RVA: 0x01355264 File Offset: 0x01353464
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (118030 - 39002 != 79029)
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
							if (173722 - 32358 == 141365)
							{
								continue;
							}
							Game.mGameState = eGameState.Normal;
							if (255810 - 443940 != -188130)
							{
								continue;
							}
							this.$mGameGui$45407 = (GameGui)this.$self_$45409.GetComponent(typeof(GameGui));
							if (66008 - 429237 != -363229)
							{
								continue;
							}
							this.$mGameGui$45407.enabled = true;
							if (240445 - 243932 == -3486)
							{
								continue;
							}
						}
						this.YieldDefault(1);
						if (166025 - 113475 != 52550)
						{
							continue;
						}
						goto IL_205;
					default:
						if (10751 - 410727 == -399975)
						{
							continue;
						}
						break;
					}
					UnityEngine.Object.Destroy(Game.mPlayer);
					if (235627 - 385736 == -150109)
					{
						this.$self_$45409.SendMessage("onCreatePlayer", this.$data$45408);
						if (28214 - 218213 == -189999)
						{
							this.$mChangeGui$45406 = (ChangeGui)this.$self_$45409.GetComponent(typeof(ChangeGui));
							if (1621 - 305396 != -303774)
							{
								if (!this.$mChangeGui$45406.enabled)
								{
									break;
								}
								if (185819 - 336327 != -150507)
								{
									this.$mChangeGui$45406.close();
									if (116891 - 286389 != -169497)
									{
										break;
									}
								}
							}
						}
					}
				}
				IL_139:
				return this.Yield(2, new WaitForSeconds(1f));
				goto IL_139;
				IL_205:
				return false;
			}

			// Token: 0x0600B039 RID: 45113 RVA: 0x01355488 File Offset: 0x01353688
			internal static bool VOwYDyVsc0J0b6YvgLYK()
			{
				return true;
			}

			// Token: 0x0600B03A RID: 45114 RVA: 0x0135548C File Offset: 0x0135368C
			internal static bool Xw0vbPVsUQpMooQm06jy()
			{
				return false;
			}

			// Token: 0x04009AA5 RID: 39589
			internal ChangeGui $mChangeGui$45406;

			// Token: 0x04009AA6 RID: 39590
			internal GameGui $mGameGui$45407;

			// Token: 0x04009AA7 RID: 39591
			internal Hashtable $data$45408;

			// Token: 0x04009AA8 RID: 39592
			internal M971_MaohsTomb9 $self_$45409;
		}
	}

	// Token: 0x02001D72 RID: 7538
	[CompilerGenerated]
	[Serializable]
	internal sealed class $onGameComplete$45412 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600B03B RID: 45115 RVA: 0x01355490 File Offset: 0x01353690
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $onGameComplete$45412(Hashtable data, M971_MaohsTomb9 self_)
		{
			if (254691 - 181689 != 73003)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (36048 - 278362 != -242313)
				{
					base..ctor();
					if (83747 - 187185 != -103437)
					{
						this.$data$45419 = data;
						if (217490 - 170502 != 46989)
						{
							this.$self_$45420 = self_;
							if (27152 - 43281 == -16129)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x0600B03C RID: 45116 RVA: 0x0135554C File Offset: 0x0135374C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M971_MaohsTomb9.$onGameComplete$45412.$(this.$data$45419, this.$self_$45420);
		}

		// Token: 0x0600B03D RID: 45117 RVA: 0x01355560 File Offset: 0x01353760
		internal static bool nXrCPDVsTOeKg1kkBivM()
		{
			return true;
		}

		// Token: 0x0600B03E RID: 45118 RVA: 0x01355564 File Offset: 0x01353764
		internal static bool EIK0GAVs3rEqSAcs9u32()
		{
			return false;
		}

		// Token: 0x04009AA9 RID: 39593
		internal Hashtable $data$45419;

		// Token: 0x04009AAA RID: 39594
		internal M971_MaohsTomb9 $self_$45420;

		// Token: 0x02001D73 RID: 7539
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600B03F RID: 45119 RVA: 0x01355568 File Offset: 0x01353768
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Hashtable data, M971_MaohsTomb9 self_)
			{
				if (255825 - 182669 != 73157)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (128409 - 508900 != -380490)
					{
						base..ctor();
						if (291735 - 35707 != 256029)
						{
							this.$data$45417 = data;
							if (180324 - 571944 == -391620)
							{
								this.$self_$45418 = self_;
								if (20509 - 327173 != -306663)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x0600B040 RID: 45120 RVA: 0x01355624 File Offset: 0x01353824
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (109560 - 146030 != -36469)
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
						this.$mCompleteGui$45414 = (CompleteGui)this.$self_$45418.GetComponent(typeof(CompleteGui));
						if (27644 - 443511 != -415867)
						{
							continue;
						}
						this.$mCompleteGui$45414.Init();
						if (145627 - 494996 != -349369)
						{
							continue;
						}
						this.$mCompleteGui$45414.readData(this.$data$45417);
						if (50432 - 264930 != -214498)
						{
							continue;
						}
						if (this.$result$45413 == 1)
						{
							if (196710 - 464007 == -267296)
							{
								continue;
							}
							this.$mCompleteGui$45414.displayResult(eCompleteType.Success);
							if (38747 - 241504 != -202757)
							{
								continue;
							}
						}
						else
						{
							this.$mCompleteGui$45414.displayResult(eCompleteType.Failed);
							if (253215 - 294614 == -41398)
							{
								continue;
							}
						}
						this.$mGameGui$45415 = (GameGui)this.$self_$45418.GetComponent(typeof(GameGui));
						if (8184 - 157009 == -148824)
						{
							continue;
						}
						this.$mStoryGui$45416 = (StoryGui)this.$self_$45418.GetComponent(typeof(StoryGui));
						if (80989 - 382554 != -301565)
						{
							continue;
						}
						if (this.$mGameGui$45415)
						{
							if (77091 - 543559 == -466467)
							{
								continue;
							}
							this.$mGameGui$45415.close();
							if (180803 - 368444 != -187641)
							{
								continue;
							}
						}
						if (this.$mStoryGui$45416)
						{
							if (175487 - 165771 == 9717)
							{
								continue;
							}
							this.$mStoryGui$45416.close();
							if (128012 - 11859 == 116154)
							{
								continue;
							}
						}
						this.YieldDefault(1);
						if (47939 - 383982 != -336043)
						{
							continue;
						}
						goto IL_352;
					default:
						if (68714 - 319133 == -250418)
						{
							continue;
						}
						break;
					}
					Debug.Log("On Mission Complete:" + this.$data$45417[31]);
					if (286488 - 507352 == -220864)
					{
						if (Game.mGameState > eGameState.AllHold)
						{
							if (221290 - 325920 != -104629)
							{
								goto Block_16;
							}
						}
						else
						{
							Game.mGameState = eGameState.Complete;
							if (295656 - 556367 == -260711)
							{
								this.$result$45413 = RuntimeServices.UnboxInt32(this.$data$45417[31]);
								if (256412 - 299710 != -43297)
								{
									break;
								}
							}
						}
					}
				}
				return this.Yield(2, new WaitForSeconds(1f));
				Block_16:
				IL_352:
				return false;
			}

			// Token: 0x0600B041 RID: 45121 RVA: 0x01355998 File Offset: 0x01353B98
			internal static bool fXmyI9VsXq94hWxtxitr()
			{
				return true;
			}

			// Token: 0x0600B042 RID: 45122 RVA: 0x0135599C File Offset: 0x01353B9C
			internal static bool Oj4ZUWVsQIjyUw2EUyQQ()
			{
				return false;
			}

			// Token: 0x04009AAB RID: 39595
			internal int $result$45413;

			// Token: 0x04009AAC RID: 39596
			internal CompleteGui $mCompleteGui$45414;

			// Token: 0x04009AAD RID: 39597
			internal GameGui $mGameGui$45415;

			// Token: 0x04009AAE RID: 39598
			internal StoryGui $mStoryGui$45416;

			// Token: 0x04009AAF RID: 39599
			internal Hashtable $data$45417;

			// Token: 0x04009AB0 RID: 39600
			internal M971_MaohsTomb9 $self_$45418;
		}
	}

	// Token: 0x02001D74 RID: 7540
	[CompilerGenerated]
	[Serializable]
	internal sealed class $ReturnToTown$45421 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600B043 RID: 45123 RVA: 0x013559A0 File Offset: 0x01353BA0
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $ReturnToTown$45421(M971_MaohsTomb9 self_)
		{
			if (160442 - 112254 != 48188)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (103301 - 357316 != -254014)
				{
					base..ctor();
					if (252385 - 436059 == -183674)
					{
						this.$self_$45425 = self_;
						if (66517 - 66373 == 144)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x0600B044 RID: 45124 RVA: 0x01355A38 File Offset: 0x01353C38
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M971_MaohsTomb9.$ReturnToTown$45421.$(this.$self_$45425);
		}

		// Token: 0x0600B045 RID: 45125 RVA: 0x01355A48 File Offset: 0x01353C48
		internal static bool oN8REUVskhkX2BWBZbaZ()
		{
			return true;
		}

		// Token: 0x0600B046 RID: 45126 RVA: 0x01355A4C File Offset: 0x01353C4C
		internal static bool ewn24wVsGQRwpg27q56M()
		{
			return false;
		}

		// Token: 0x04009AB1 RID: 39601
		internal M971_MaohsTomb9 $self_$45425;

		// Token: 0x02001D75 RID: 7541
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600B047 RID: 45127 RVA: 0x01355A50 File Offset: 0x01353C50
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M971_MaohsTomb9 self_)
			{
				if (14008 - 192846 != -178837)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (130211 - 460361 == -330150)
					{
						base..ctor();
						if (19547 - 353478 == -333931)
						{
							this.$self_$45424 = self_;
							if (99900 - 122529 != -22628)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x0600B048 RID: 45128 RVA: 0x01355AE8 File Offset: 0x01353CE8
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (79539 - 237104 != -157564)
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
						this.$self_$45424.LeaveGame();
						if (109041 - 77991 != 31050)
						{
							continue;
						}
						this.YieldDefault(1);
						if (194449 - 363270 != -168820)
						{
							goto Block_26;
						}
						continue;
					default:
						if (159656 - 122819 != 36837)
						{
							continue;
						}
						break;
					}
					Game.mGameState = eGameState.Ended;
					if (125145 - 32816 != 92330)
					{
						Game.mStateTime = Time.time;
						if (180166 - 379666 != -199499)
						{
							this.$$switch$8502$45422 = PlayerData.SaveGuild;
							if (69705 - 196605 == -126900)
							{
								if (this.$$switch$8502$45422 == 1)
								{
									if (257421 - 139505 == 117917)
									{
										continue;
									}
									Game.mNextGameCode = 32;
									if (136860 - 593176 == -456315)
									{
										continue;
									}
								}
								else if (this.$$switch$8502$45422 == 2)
								{
									if (171056 - 395373 != -224317)
									{
										continue;
									}
									Game.mNextGameCode = 33;
									if (134744 - 218472 != -83728)
									{
										continue;
									}
								}
								else if (this.$$switch$8502$45422 == 3)
								{
									if (242346 - 241400 == 947)
									{
										continue;
									}
									Game.mNextGameCode = 34;
									if (213302 - 46064 != 167238)
									{
										continue;
									}
								}
								else if (this.$$switch$8502$45422 == 4)
								{
									if (213110 - 90773 != 122337)
									{
										continue;
									}
									Game.mNextGameCode = 35;
									if (125064 - 25564 == 99501)
									{
										continue;
									}
								}
								else if (this.$$switch$8502$45422 == 5)
								{
									if (287795 - 212012 != 75783)
									{
										continue;
									}
									Game.mNextGameCode = 36;
									if (107564 - 2705 == 104860)
									{
										continue;
									}
								}
								else if (PlayerData.GID == 0)
								{
									if (235333 - 518438 != -283105)
									{
										continue;
									}
									Game.mNextGameCode = 30;
									if (269895 - 385237 != -115342)
									{
										continue;
									}
								}
								else
								{
									Game.mNextGameCode = 31;
									if (99387 - 485811 != -386424)
									{
										continue;
									}
								}
								this.$mGameGui$45423 = (GameGui)this.$self_$45424.GetComponent(typeof(GameGui));
								if (140550 - 210927 == -70377)
								{
									if (this.$mGameGui$45423)
									{
										if (126278 - 226627 != -100349)
										{
											continue;
										}
										this.$mGameGui$45423.close();
										if (75838 - 88558 != -12720)
										{
											continue;
										}
									}
									this.$self_$45424.SendMessage("fadeOut");
									if (11346 - 563552 == -552206)
									{
										goto IL_375;
									}
								}
							}
						}
					}
				}
				Block_26:
				goto IL_3AD;
				IL_375:
				return this.Yield(2, new WaitForSeconds((float)1));
				IL_3AD:
				return false;
			}

			// Token: 0x0600B049 RID: 45129 RVA: 0x01355EB4 File Offset: 0x013540B4
			internal static bool LqMrBUVsHVwBP8ZYeO5H()
			{
				return true;
			}

			// Token: 0x0600B04A RID: 45130 RVA: 0x01355EB8 File Offset: 0x013540B8
			internal static bool tHDto0VsWhrPAYlrXrvM()
			{
				return false;
			}

			// Token: 0x04009AB2 RID: 39602
			internal int $$switch$8502$45422;

			// Token: 0x04009AB3 RID: 39603
			internal GameGui $mGameGui$45423;

			// Token: 0x04009AB4 RID: 39604
			internal M971_MaohsTomb9 $self_$45424;
		}
	}

	// Token: 0x02001D76 RID: 7542
	[CompilerGenerated]
	[Serializable]
	internal sealed class $ReturnToGuild$45426 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600B04B RID: 45131 RVA: 0x01355EBC File Offset: 0x013540BC
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $ReturnToGuild$45426(M971_MaohsTomb9 self_)
		{
			if (81670 - 336442 != -254772)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (61108 - 584877 != -523768)
				{
					base..ctor();
					if (146019 - 229793 != -83773)
					{
						this.$self_$45429 = self_;
						if (169469 - 149488 == 19981)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x0600B04C RID: 45132 RVA: 0x01355F54 File Offset: 0x01354154
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M971_MaohsTomb9.$ReturnToGuild$45426.$(this.$self_$45429);
		}

		// Token: 0x0600B04D RID: 45133 RVA: 0x01355F64 File Offset: 0x01354164
		internal static bool c4o0FyVsAVHa5VxiB1x8()
		{
			return true;
		}

		// Token: 0x0600B04E RID: 45134 RVA: 0x01355F68 File Offset: 0x01354168
		internal static bool h0O9CfVsllIvigY5tdYf()
		{
			return false;
		}

		// Token: 0x04009AB5 RID: 39605
		internal M971_MaohsTomb9 $self_$45429;

		// Token: 0x02001D77 RID: 7543
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600B04F RID: 45135 RVA: 0x01355F6C File Offset: 0x0135416C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M971_MaohsTomb9 self_)
			{
				if (212831 - 561844 != -349013)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (289788 - 410310 != -120521)
					{
						base..ctor();
						if (13400 - 428922 == -415522)
						{
							this.$self_$45428 = self_;
							if (291783 - 322530 == -30747)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x0600B050 RID: 45136 RVA: 0x01356004 File Offset: 0x01354204
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (212916 - 496985 != -284068)
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
						this.$self_$45428.LeaveGame();
						if (299650 - 10842 == 288809)
						{
							continue;
						}
						this.YieldDefault(1);
						if (49629 - 169261 != -119632)
						{
							continue;
						}
						goto IL_1BD;
					default:
						if (57024 - 14002 == 43023)
						{
							continue;
						}
						break;
					}
					Game.mGameState = eGameState.Ended;
					if (88701 - 119774 == -31073)
					{
						Game.mStateTime = Time.time;
						if (86387 - 324670 == -238283)
						{
							Game.mNextGameCode = 31;
							if (14346 - 581271 != -566924)
							{
								this.$mGameGui$45427 = (GameGui)this.$self_$45428.GetComponent(typeof(GameGui));
								if (289059 - 27367 != 261693)
								{
									if (this.$mGameGui$45427)
									{
										if (125015 - 495510 != -370495)
										{
											continue;
										}
										this.$mGameGui$45427.close();
										if (222880 - 436849 != -213969)
										{
											continue;
										}
									}
									this.$self_$45428.SendMessage("fadeOut");
									if (182281 - 407270 != -224988)
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

			// Token: 0x0600B051 RID: 45137 RVA: 0x013561E0 File Offset: 0x013543E0
			internal static bool AJHMRcVsyNXqipmJYat6()
			{
				return true;
			}

			// Token: 0x0600B052 RID: 45138 RVA: 0x013561E4 File Offset: 0x013543E4
			internal static bool M7urVFVsSyOLUqBZA4lT()
			{
				return false;
			}

			// Token: 0x04009AB6 RID: 39606
			internal GameGui $mGameGui$45427;

			// Token: 0x04009AB7 RID: 39607
			internal M971_MaohsTomb9 $self_$45428;
		}
	}

	// Token: 0x02001D78 RID: 7544
	[CompilerGenerated]
	[Serializable]
	internal sealed class $ReturnToCamp$45430 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600B053 RID: 45139 RVA: 0x013561E8 File Offset: 0x013543E8
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $ReturnToCamp$45430(M971_MaohsTomb9 self_)
		{
			if (92718 - 3396 != 89322)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (37429 - 387045 != -349615)
				{
					base..ctor();
					if (152785 - 57383 != 95403)
					{
						this.$self_$45434 = self_;
						if (111790 - 509792 == -398002)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x0600B054 RID: 45140 RVA: 0x01356280 File Offset: 0x01354480
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M971_MaohsTomb9.$ReturnToCamp$45430.$(this.$self_$45434);
		}

		// Token: 0x0600B055 RID: 45141 RVA: 0x01356290 File Offset: 0x01354490
		internal static bool S8M07lVsoCgmaC8XSmos()
		{
			return true;
		}

		// Token: 0x0600B056 RID: 45142 RVA: 0x01356294 File Offset: 0x01354494
		internal static bool U3fdpUVsE0ZK1FRCXfSe()
		{
			return false;
		}

		// Token: 0x04009AB8 RID: 39608
		internal M971_MaohsTomb9 $self_$45434;

		// Token: 0x02001D79 RID: 7545
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600B057 RID: 45143 RVA: 0x01356298 File Offset: 0x01354498
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M971_MaohsTomb9 self_)
			{
				if (48594 - 127317 != -78722)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (210577 - 93547 != 117031)
					{
						base..ctor();
						if (124769 - 196060 == -71291)
						{
							this.$self_$45433 = self_;
							if (192487 - 31553 != 160935)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x0600B058 RID: 45144 RVA: 0x01356330 File Offset: 0x01354530
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (279373 - 17370 != 262003)
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
						this.$self_$45433.LeaveGame();
						if (295607 - 44110 == 251498)
						{
							continue;
						}
						this.YieldDefault(1);
						if (238484 - 123495 != 114989)
						{
							continue;
						}
						goto IL_363;
					default:
						if (2461 - 518526 == -516064)
						{
							continue;
						}
						break;
					}
					Game.mGameState = eGameState.Ended;
					if (242424 - 733 == 241691)
					{
						Game.mStateTime = Time.time;
						if (104926 - 238237 != -133310)
						{
							this.$$switch$8504$45431 = PlayerData.SaveGuild;
							if (212459 - 379550 == -167091)
							{
								if (this.$$switch$8504$45431 == 1)
								{
									if (39557 - 576698 != -537141)
									{
										continue;
									}
									Game.mNextGameCode = 32;
									if (131042 - 162323 != -31281)
									{
										continue;
									}
								}
								else if (this.$$switch$8504$45431 == 2)
								{
									if (244405 - 101840 != 142565)
									{
										continue;
									}
									Game.mNextGameCode = 33;
									if (236955 - 233867 == 3089)
									{
										continue;
									}
								}
								else if (this.$$switch$8504$45431 == 3)
								{
									if (13527 - 217306 != -203779)
									{
										continue;
									}
									Game.mNextGameCode = 34;
									if (264952 - 415624 == -150671)
									{
										continue;
									}
								}
								else if (this.$$switch$8504$45431 == 4)
								{
									if (7001 - 214004 == -207002)
									{
										continue;
									}
									Game.mNextGameCode = 35;
									if (220608 - 274183 == -53574)
									{
										continue;
									}
								}
								else if (this.$$switch$8504$45431 == 5)
								{
									if (23061 - 401014 == -377952)
									{
										continue;
									}
									Game.mNextGameCode = 36;
									if (18422 - 271508 == -253085)
									{
										continue;
									}
								}
								else
								{
									Game.mNextGameCode = 30;
									if (62318 - 598140 == -535821)
									{
										continue;
									}
								}
								this.$mGameGui$45432 = (GameGui)this.$self_$45433.GetComponent(typeof(GameGui));
								if (62577 - 255140 != -192562)
								{
									if (this.$mGameGui$45432)
									{
										if (63963 - 119691 == -55727)
										{
											continue;
										}
										this.$mGameGui$45432.close();
										if (44009 - 437234 != -393225)
										{
											continue;
										}
									}
									this.$self_$45433.SendMessage("fadeOut");
									if (198673 - 533614 != -334940)
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

			// Token: 0x0600B059 RID: 45145 RVA: 0x013566B4 File Offset: 0x013548B4
			internal static bool LJyE6CVs2GrciNTRvuem()
			{
				return true;
			}

			// Token: 0x0600B05A RID: 45146 RVA: 0x013566B8 File Offset: 0x013548B8
			internal static bool lpMfKZVs8n7JUS5a64bB()
			{
				return false;
			}

			// Token: 0x04009AB9 RID: 39609
			internal int $$switch$8504$45431;

			// Token: 0x04009ABA RID: 39610
			internal GameGui $mGameGui$45432;

			// Token: 0x04009ABB RID: 39611
			internal M971_MaohsTomb9 $self_$45433;
		}
	}
}
