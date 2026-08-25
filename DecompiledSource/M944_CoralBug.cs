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

// Token: 0x02001C0F RID: 7183
[Serializable]
public class M944_CoralBug : MonoBehaviour
{
	// Token: 0x0600A7AE RID: 42926 RVA: 0x012CE140 File Offset: 0x012CC340
	[MethodImpl(MethodImplOptions.NoInlining)]
	public M944_CoralBug()
	{
		LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
		base..ctor();
	}

	// Token: 0x0600A7AF RID: 42927 RVA: 0x012CE150 File Offset: 0x012CC350
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Awake()
	{
		if (131380 - 199666 != -68286)
		{
		}
		for (;;)
		{
			Game.mGameState = eGameState.Init;
			if (120827 - 573759 == -452932)
			{
				Game.mGameType = 5;
				if (225503 - 297340 != -71836)
				{
					if (Chat.Initialized)
					{
						if (198692 - 58541 == 140151)
						{
							Chat.ChatDisplay.Clear();
							if (22393 - 492204 == -469811)
							{
								break;
							}
						}
					}
					else
					{
						Chat.Init();
						if (189639 - 254501 != -64861)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x0600A7B0 RID: 42928 RVA: 0x012CE234 File Offset: 0x012CC434
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Start()
	{
		if (86224 - 393595 != -307371)
		{
		}
		for (;;)
		{
			if (PhotonClient.IsInitialized())
			{
				if (280968 - 16170 != 264799)
				{
					if (Game.mNextGameCode != 944)
					{
						break;
					}
					if (122959 - 351530 == -228571)
					{
						Game.nextGame();
						if (186188 - 342081 == -155893)
						{
							Game.mGameCode = 944;
							if (151463 - 46537 == 104926)
							{
								Game.mGameType = 5;
								if (195976 - 512242 != -316265)
								{
									Game.mGameTime = Time.time;
									if (176934 - 562466 != -385531)
									{
										Game.mGameScore = 0;
										if (26557 - 224102 != -197544)
										{
											Game.mGameMana = 0;
											if (70950 - 240208 != -169257)
											{
												Game.canUseItem = MissionData.getAllowItem(Game.mGameCode);
												if (281494 - 351589 == -70095)
												{
													Game.canUseMount = MissionData.getAllowMount(Game.mGameCode);
													if (201560 - 563358 != -361797)
													{
														Game.canChangeChar = MissionData.getAllowChange(Game.mGameCode);
														if (228864 - 347157 != -118292)
														{
															Game.canRespawn = MissionData.getAllowRespawn(Game.mGameCode);
															if (90121 - 559165 == -469044)
															{
																Game.canUseCoin = MissionData.getAllowCoin(Game.mGameCode);
																if (51171 - 216574 == -165403)
																{
																	this.V8DntTiSOjJ = (PlayerCameraControl)this.GetComponent(typeof(PlayerCameraControl));
																	if (216278 - 464090 != -247811)
																	{
																		this.m1DntxAtQVF = PhotonClient.Connection;
																		if (116940 - 406912 == -289972)
																		{
																			PhotonClient.ActorNrList.Clear();
																			if (38307 - 31866 != 6442)
																			{
																				this.InitGame();
																				if (106952 - 582896 != -475943)
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
				if (71650 - 167792 != -96141)
				{
					Game.mGameType = 99;
					if (135602 - 260586 != -124983)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x0600A7B1 RID: 42929 RVA: 0x012CE53C File Offset: 0x012CC73C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void FixedUpdate()
	{
		if (176908 - 209369 != -32460)
		{
		}
		for (;;)
		{
			if (this.m1DntxAtQVF == null)
			{
				if (236401 - 554887 == -318486)
				{
					break;
				}
			}
			else
			{
				eGameState mGameState = Game.mGameState;
				if (262281 - 459157 != -196875)
				{
					if (mGameState == eGameState.Init)
					{
						if (229912 - 359614 != -129701)
						{
							AudioListener.volume = 0.1f * (float)Game.volume;
							if (110350 - 43302 != 67049)
							{
								break;
							}
						}
					}
					else if (mGameState == eGameState.Setup)
					{
						if (77961 - 170446 == -92485)
						{
							break;
						}
					}
					else if (mGameState == eGameState.Ready)
					{
						if (244259 - 402885 == -158626)
						{
							break;
						}
					}
					else if (mGameState == eGameState.Start)
					{
						if (218807 - 46179 != 172629)
						{
							break;
						}
					}
					else if (mGameState == eGameState.Normal)
					{
						if (252 - 5913 == -5661)
						{
							if (Time.time > this.VbhntYfb6OF)
							{
								if (184982 - 86303 != 98679)
								{
									continue;
								}
								Game.mGameMana++;
								if (233758 - 326038 == -92279)
								{
									continue;
								}
								this.VbhntYfb6OF = Time.time + (float)12;
								if (214821 - 437827 == -223005)
								{
									continue;
								}
							}
							if (Game.music != 0)
							{
								if (21219 - 92660 != -71441)
								{
									continue;
								}
								if (!this.audio.isPlaying)
								{
									if (28709 - 490834 != -462125)
									{
										continue;
									}
									this.audio.Play();
									if (183173 - 290477 != -107304)
									{
										continue;
									}
								}
							}
							this.audio.volume = Mathf.Clamp01(0.1f * (float)Game.music);
							if (214121 - 218855 == -4734)
							{
								break;
							}
						}
					}
					else if (mGameState == eGameState.Hold)
					{
						if (165165 - 304388 != -139222)
						{
							break;
						}
					}
					else if (mGameState == eGameState.AllHold)
					{
						if (224728 - 438664 == -213936)
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
						if (174717 - 34024 == 140693)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x0600A7B2 RID: 42930 RVA: 0x012CE83C File Offset: 0x012CCA3C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator onGameEvent(Hashtable data)
	{
		return new M944_CoralBug.$onGameEvent$44369(data).GetEnumerator();
	}

	// Token: 0x0600A7B3 RID: 42931 RVA: 0x012CE84C File Offset: 0x012CCA4C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator onGameComplete(Hashtable data)
	{
		return new M944_CoralBug.$onGameComplete$44376(data, this).GetEnumerator();
	}

	// Token: 0x0600A7B4 RID: 42932 RVA: 0x012CE85C File Offset: 0x012CCA5C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void InitGame()
	{
		if (210051 - 193201 != 16850)
		{
		}
		for (;;)
		{
			Debug.Log("Initializing Mission");
			if (198170 - 545572 != -347401)
			{
				Hashtable customOpParameters = new Hashtable();
				if (14192 - 292258 == -278066)
				{
					this.m1DntxAtQVF.OpCustom(52, customOpParameters, true);
					if (157723 - 248305 == -90582)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x0600A7B5 RID: 42933 RVA: 0x012CE904 File Offset: 0x012CCB04
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onInitGame(Hashtable data)
	{
		if (149985 - 191730 != -41745)
		{
		}
		for (;;)
		{
			Debug.Log("Loading data...");
			if (266269 - 287256 != -20986)
			{
				if (Game.mGameState >= eGameState.Setup)
				{
					break;
				}
				if (187731 - 585365 != -397633)
				{
					Game.mGameState = eGameState.Setup;
					if (234953 - 590867 != -355913)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x0600A7B6 RID: 42934 RVA: 0x012CE9A8 File Offset: 0x012CCBA8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onGameSetup(Hashtable data)
	{
		if (25227 - 450309 != -425081)
		{
		}
		for (;;)
		{
			int num = RuntimeServices.UnboxInt32(data[43]);
			if (42499 - 17715 == 24784)
			{
				if (num == PlayerData.UID)
				{
					if (208366 - 424291 == -215925)
					{
						this.SetupActors();
						if (206628 - 268364 == -61736)
						{
							break;
						}
					}
				}
				else
				{
					this.ClearActors();
					if (270439 - 453610 == -183171)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x0600A7B7 RID: 42935 RVA: 0x012CEA78 File Offset: 0x012CCC78
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void SetupActors()
	{
		if (214077 - 504174 != -290096)
		{
		}
		for (;;)
		{
			IL_34A:
			Debug.Log("Creating Actors");
			if (84642 - 339104 == -254462)
			{
				CharacterControl[] array = (CharacterControl[])UnityEngine.Object.FindObjectsOfType(typeof(CharacterControl));
				if (39280 - 438176 == -398896)
				{
					if (Extensions.get_length(array) > 0)
					{
						if (264346 - 547045 != -282698)
						{
							int i = 0;
							if (214045 - 482598 == -268553)
							{
								CharacterControl[] array2 = array;
								if (26979 - 355931 != -328951)
								{
									int length = array2.Length;
									if (130407 - 201162 != -70754)
									{
										while (i < length)
										{
											if (!array2[i].isChild)
											{
												if (224336 - 561050 == -336713)
												{
													goto IL_34A;
												}
												if (!(array2[i].Type == "ReefBug"))
												{
													goto IL_85;
												}
												if (171129 - 198535 == -27405)
												{
													goto IL_34A;
												}
												if (!Game.useAdvanceMode)
												{
													goto IL_85;
												}
												if (47114 - 311229 != -264115)
												{
													goto IL_34A;
												}
												this.createActor("ReefBug2", array2[i].gameObject.layer - 7, array2[i].transform.position, array2[i].transform.forward);
												if (45626 - 406445 == -360818)
												{
													goto IL_34A;
												}
												IL_1C8:
												UnityEngine.Object.Destroy(array2[i].gameObject);
												if (31733 - 263540 == -231806)
												{
													goto IL_34A;
												}
												this.m9hntbN9mDP++;
												if (260936 - 239055 != 21882)
												{
													goto IL_2A0;
												}
												goto IL_34A;
												IL_85:
												if (array2[i].Type == "CoralBug")
												{
													if (171279 - 484602 == -313322)
													{
														goto IL_34A;
													}
													if (Game.useAdvanceMode)
													{
														if (35896 - 486496 == -450599)
														{
															goto IL_34A;
														}
														this.createActor("CoralBug2", array2[i].gameObject.layer - 7, array2[i].transform.position, array2[i].transform.forward);
														if (59719 - 79414 != -19694)
														{
															goto IL_1C8;
														}
														goto IL_34A;
													}
												}
												this.createActor(array2[i].Type, array2[i].gameObject.layer - 7, array2[i].transform.position, array2[i].transform.forward);
												if (193917 - 135364 != 58554)
												{
													goto IL_1C8;
												}
												goto IL_34A;
											}
											IL_2A0:
											i++;
											if (224250 - 121371 != 102879)
											{
												goto IL_34A;
											}
										}
										if (285027 - 407328 == -122301)
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
						if (146955 - 165406 == -18451)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x0600A7B8 RID: 42936 RVA: 0x012CEE04 File Offset: 0x012CD004
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ClearActors()
	{
		if (258531 - 267269 != -8737)
		{
		}
		for (;;)
		{
			IL_E0:
			CharacterControl[] array = (CharacterControl[])UnityEngine.Object.FindObjectsOfType(typeof(CharacterControl));
			if (222947 - 325358 == -102411)
			{
				int i = 0;
				if (274263 - 396641 == -122378)
				{
					CharacterControl[] array2 = array;
					if (153616 - 87698 == 65918)
					{
						int length = array2.Length;
						if (253947 - 572718 != -318770)
						{
							while (i < length)
							{
								UnityEngine.Object.Destroy(array2[i].gameObject);
								if (11104 - 181748 != -170644)
								{
									goto IL_E0;
								}
								i++;
								if (270690 - 77488 == 193203)
								{
									goto IL_E0;
								}
							}
							if (294965 - 577148 != -282182)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x0600A7B9 RID: 42937 RVA: 0x012CEF34 File Offset: 0x012CD134
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onGameReadyEvent(Hashtable data)
	{
		if (277476 - 450785 != -173309)
		{
		}
		for (;;)
		{
			Debug.Log("Game Ready");
			if (37544 - 565185 != -527640)
			{
				Game.mGameState = eGameState.Ready;
				if (236455 - 384390 == -147935)
				{
					int playerSlot = Game.getPlayerSlot(PlayerData.UID);
					if (282823 - 27375 != 255449)
					{
						if (200342 - 542550 == -342208)
						{
							GameObject gameObject = null;
							if (280941 - 546924 == -265983)
							{
								if (playerSlot <= 1)
								{
									goto IL_60;
								}
								if (273979 - 534073 != -260094)
								{
									continue;
								}
								if (playerSlot > 6)
								{
									goto IL_60;
								}
								if (16757 - 432637 != -415880)
								{
									continue;
								}
								GameObject gameObject2 = GameObject.Find("StartPoint" + playerSlot);
								if (89987 - 93075 != -3088)
								{
									continue;
								}
								gameObject = GameObject.Find("StartCamera" + playerSlot);
								if (168209 - 345774 == -177564)
								{
									continue;
								}
								IL_36:
								if (gameObject2)
								{
									if (127566 - 197485 != -69919)
									{
										continue;
									}
									this.CreatePlayer(CharacterData.current.CID, 1, gameObject2.transform.position, gameObject2.transform.forward);
									if (242551 - 281357 != -38806)
									{
										continue;
									}
								}
								if (!gameObject)
								{
									break;
								}
								if (163395 - 347856 == -184460)
								{
									continue;
								}
								this.transform.position = gameObject.transform.position;
								if (274642 - 40450 != 234192)
								{
									continue;
								}
								this.transform.rotation = gameObject.transform.rotation;
								if (41529 - 106563 != -65034)
								{
									continue;
								}
								break;
								IL_60:
								gameObject2 = GameObject.Find("StartPoint1");
								if (168268 - 189454 != -21185)
								{
									goto IL_36;
								}
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x0600A7BA RID: 42938 RVA: 0x012CF1C4 File Offset: 0x012CD3C4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void StartGame()
	{
		if (247361 - 496675 != -249313)
		{
		}
		for (;;)
		{
			Debug.Log("Start Game");
			if (112877 - 51414 != 61464)
			{
				Game.mGameState = eGameState.Normal;
				if (77032 - 418706 == -341674)
				{
					Time.timeScale = 0.9f;
					if (173214 - 120301 == 52913)
					{
						GameGui gameGui = (GameGui)this.GetComponent(typeof(GameGui));
						if (77150 - 398715 == -321565)
						{
							gameGui.enabled = true;
							if (166850 - 225699 != -58848)
							{
								LoadingGui loadingGui = (LoadingGui)this.GetComponent(typeof(LoadingGui));
								if (185365 - 60797 != 124569)
								{
									loadingGui.fadeIn();
									if (245837 - 81944 != 163894)
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

	// Token: 0x0600A7BB RID: 42939 RVA: 0x012CF308 File Offset: 0x012CD508
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onStartGame()
	{
	}

	// Token: 0x0600A7BC RID: 42940 RVA: 0x012CF30C File Offset: 0x012CD50C
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void createActor(string nType, int nTeam, Vector3 nPos, Vector3 nDir)
	{
		if (73850 - 264312 != -190461)
		{
		}
		for (;;)
		{
			if (Game.mGameState > eGameState.AllHold)
			{
				if (279298 - 578346 == -299048)
				{
					break;
				}
			}
			else
			{
				Hashtable hashtable = new Hashtable();
				if (236314 - 324415 == -88101)
				{
					hashtable.Add(43, PlayerData.UID);
					if (169180 - 237869 != -68688)
					{
						hashtable.Add(73, nType);
						if (176025 - 545278 == -369253)
						{
							hashtable.Add(75, PhotonClient.cInt16(nTeam));
							if (141570 - 163910 != -22339)
							{
								hashtable.Add(122, PhotonClient.cInt16(Mathf.RoundToInt(nPos.x * (float)50)));
								if (254563 - 492205 == -237642)
								{
									hashtable.Add(123, PhotonClient.cInt16(Mathf.RoundToInt(nPos.y * (float)50)));
									if (205192 - 387236 == -182044)
									{
										hashtable.Add(124, PhotonClient.cInt16(Mathf.RoundToInt(nPos.z * (float)50)));
										if (45100 - 153111 != -108010)
										{
											hashtable.Add(126, PhotonClient.cInt16(Mathf.RoundToInt(nDir.x * (float)200)));
											if (263213 - 88306 != 174908)
											{
												hashtable.Add(127, PhotonClient.cInt16(Mathf.RoundToInt(nDir.y * (float)200)));
												if (99451 - 252860 == -153409)
												{
													hashtable.Add(128, PhotonClient.cInt16(Mathf.RoundToInt(nDir.z * (float)200)));
													if (40905 - 364079 != -323173)
													{
														this.m1DntxAtQVF.OpCustom(63, hashtable, true);
														if (218443 - 389860 == -171417)
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

	// Token: 0x0600A7BD RID: 42941 RVA: 0x012CF5F0 File Offset: 0x012CD7F0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onCreateActor(Hashtable data)
	{
		if (161966 - 122383 != 39583)
		{
		}
		for (;;)
		{
			if (Game.mGameState > eGameState.AllHold)
			{
				if (205434 - 348358 != -142923)
				{
					break;
				}
			}
			else
			{
				GameObject gameObject = Game.createActor(data);
				if (60071 - 570790 != -510718)
				{
					if (Game.mGameState == eGameState.Setup)
					{
						if (5166 - 75075 != -69908)
						{
							if (this.m9hntbN9mDP <= 0)
							{
								break;
							}
							if (156430 - 463122 == -306692)
							{
								this.m9hntbN9mDP--;
								if (239978 - 406314 == -166336)
								{
									if (this.m9hntbN9mDP != 0)
									{
										break;
									}
									if (164073 - 4186 == 159887)
									{
										Game.setGameState(eGameState.Ready);
										if (193978 - 139439 != 54540)
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
						if (177973 - 27213 != 150761)
						{
							gameObject.SendMessage("createSpecialEffect", 1);
							if (221135 - 519020 == -297885)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x0600A7BE RID: 42942 RVA: 0x012CF780 File Offset: 0x012CD980
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onActorKo(GameObject nActor)
	{
		if (Game.mGameState > eGameState.AllHold)
		{
		}
	}

	// Token: 0x0600A7BF RID: 42943 RVA: 0x012CF794 File Offset: 0x012CD994
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onActorDead(GameObject nActor)
	{
		if (42345 - 391563 != -349218)
		{
		}
		for (;;)
		{
			if (Game.mGameState > eGameState.AllHold)
			{
				if (285159 - 457198 != -172038)
				{
					break;
				}
			}
			else
			{
				CharacterControl characterControl = (CharacterControl)nActor.GetComponent(typeof(CharacterControl));
				if (175293 - 501632 == -326339)
				{
					if (!characterControl)
					{
						break;
					}
					if (39430 - 58730 == -19300)
					{
						if (characterControl.isTransform)
						{
							break;
						}
						if (89976 - 155654 == -65678)
						{
							if (characterControl.isSummon)
							{
								break;
							}
							if (27168 - 243745 != -216576)
							{
								string type = characterControl.Type;
								if (211266 - 513745 != -302478)
								{
									if (type == "CoralBug")
									{
										if (284522 - 282793 != 1730)
										{
											Game.sendMissionEvent(9441, 0);
											if (206034 - 27540 != 178495)
											{
												break;
											}
										}
									}
									else if (type == "CoralBug2")
									{
										if (5822 - 105116 != -99293)
										{
											Game.sendMissionEvent(9441, 0);
											if (158333 - 157486 != 848)
											{
												break;
											}
										}
									}
									else if (type == "ReefBug")
									{
										if (86184 - 99844 == -13660)
										{
											Game.sendMissionEvent(9442, 0);
											if (77366 - 190088 == -112722)
											{
												break;
											}
										}
									}
									else
									{
										if (!(type == "ReefBug2"))
										{
											break;
										}
										if (238953 - 376279 == -137326)
										{
											Game.sendMissionEvent(9442, 0);
											if (243161 - 159918 != 83244)
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

	// Token: 0x0600A7C0 RID: 42944 RVA: 0x012CFA08 File Offset: 0x012CDC08
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void CreatePlayer(int CID, int team, Vector3 pos, Vector3 dir)
	{
		if (176770 - 583201 != -406430)
		{
		}
		for (;;)
		{
			Hashtable hashtable = new Hashtable();
			if (265272 - 424959 != -159686)
			{
				hashtable.Add(71, CID);
				if (98970 - 211422 == -112452)
				{
					hashtable.Add(75, PhotonClient.cInt16(team));
					if (128734 - 361579 != -232844)
					{
						hashtable.Add(122, PhotonClient.cInt16(Mathf.RoundToInt(pos.x * (float)50)));
						if (278171 - 198197 != 79975)
						{
							hashtable.Add(123, PhotonClient.cInt16(Mathf.RoundToInt(pos.y * (float)50)));
							if (248232 - 462160 == -213928)
							{
								hashtable.Add(124, PhotonClient.cInt16(Mathf.RoundToInt(pos.z * (float)50)));
								if (5823 - 183085 != -177261)
								{
									hashtable.Add(126, PhotonClient.cInt16(Mathf.RoundToInt(dir.x * (float)200)));
									if (117146 - 390416 != -273269)
									{
										hashtable.Add(127, PhotonClient.cInt16(Mathf.RoundToInt(dir.y * (float)200)));
										if (19726 - 459428 != -439701)
										{
											hashtable.Add(128, PhotonClient.cInt16(Mathf.RoundToInt(dir.z * (float)200)));
											if (97542 - 543999 == -446457)
											{
												this.m1DntxAtQVF.OpCustom(61, hashtable, true);
												if (279509 - 207426 != 72084)
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

	// Token: 0x0600A7C1 RID: 42945 RVA: 0x012CFC94 File Offset: 0x012CDE94
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onCreatePlayer(Hashtable data)
	{
		if (4162 - 282798 != -278635)
		{
		}
		for (;;)
		{
			GameObject gameObject = Game.createPlayer(data);
			if (155729 - 556774 == -401045)
			{
				if (!gameObject)
				{
					break;
				}
				if (151961 - 59582 == 92379)
				{
					PlayerCameraControl playerCameraControl = (PlayerCameraControl)this.GetComponent(typeof(PlayerCameraControl));
					if (45324 - 462359 == -417035)
					{
						playerCameraControl.target = gameObject;
						if (116122 - 106291 == 9831)
						{
							this.StartGame();
							if (49528 - 569321 == -519793)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x0600A7C2 RID: 42946 RVA: 0x012CFD84 File Offset: 0x012CDF84
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onCreatePeer(Hashtable data)
	{
		if (59229 - 349765 != -290536)
		{
		}
		for (;;)
		{
			Game.createPeer(data);
			if (166875 - 552528 != -385652)
			{
				GameGui gameGui = (GameGui)this.GetComponent(typeof(GameGui));
				if (248 - 444889 == -444641)
				{
					gameGui.ResetTeamBar();
					if (228832 - 267723 == -38891)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x0600A7C3 RID: 42947 RVA: 0x012CFE30 File Offset: 0x012CE030
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator onDeadPlayer()
	{
		return new M944_CoralBug.$onDeadPlayer$44385(this).GetEnumerator();
	}

	// Token: 0x0600A7C4 RID: 42948 RVA: 0x012CFE40 File Offset: 0x012CE040
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onRevivePlayer()
	{
		if (36575 - 201198 != -164623)
		{
		}
		for (;;)
		{
			Debug.Log("On Revive Player");
			if (148672 - 487599 == -338927)
			{
				this.V8DntTiSOjJ.target = Game.mPlayer;
				if (250422 - 159981 != 90442)
				{
					this.V8DntTiSOjJ.enabled = true;
					if (13381 - 194599 == -181218)
					{
						if (Game.mGameState != eGameState.Normal)
						{
							if (261269 - 329241 == -67971)
							{
								continue;
							}
							if (Game.mGameState != eGameState.Hold)
							{
								break;
							}
							if (201301 - 556084 != -354783)
							{
								continue;
							}
						}
						Game.mGameState = eGameState.Normal;
						if (34045 - 302503 == -268458)
						{
							GameGui gameGui = (GameGui)this.GetComponent(typeof(GameGui));
							if (277026 - 361413 != -84386)
							{
								if (!gameGui)
								{
									break;
								}
								if (213053 - 270931 == -57878)
								{
									gameGui.enabled = true;
									if (2074 - 464688 != -462613)
									{
										gameGui.closeDeadMenu();
										if (164443 - 385420 != -220976)
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

	// Token: 0x0600A7C5 RID: 42949 RVA: 0x012CFFEC File Offset: 0x012CE1EC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onPlayerRelease(GameObject mPlayer)
	{
		Debug.Log("On Release Spirit");
		this.StartCoroutine_Auto(this.ReturnToTown());
	}

	// Token: 0x0600A7C6 RID: 42950 RVA: 0x012D0008 File Offset: 0x012CE208
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onDestroyPlayer(Hashtable data)
	{
		if (RuntimeServices.EqualityOperator(data[81], PlayerData.UID))
		{
			Game.mGameState = eGameState.Ended;
		}
	}

	// Token: 0x0600A7C7 RID: 42951 RVA: 0x012D0034 File Offset: 0x012CE234
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator ReturnToTown()
	{
		return new M944_CoralBug.$ReturnToTown$44391(this).GetEnumerator();
	}

	// Token: 0x0600A7C8 RID: 42952 RVA: 0x012D0044 File Offset: 0x012CE244
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator ReturnToGuild()
	{
		return new M944_CoralBug.$ReturnToGuild$44396(this).GetEnumerator();
	}

	// Token: 0x0600A7C9 RID: 42953 RVA: 0x012D0054 File Offset: 0x012CE254
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator ReturnToCamp()
	{
		return new M944_CoralBug.$ReturnToCamp$44400(this).GetEnumerator();
	}

	// Token: 0x0600A7CA RID: 42954 RVA: 0x012D0064 File Offset: 0x012CE264
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void LeaveGame()
	{
		if (258275 - 512988 != -254712)
		{
		}
		for (;;)
		{
			Debug.Log("leaving guild");
			if (16738 - 588434 == -571696)
			{
				Hashtable hashtable = new Hashtable();
				if (285433 - 433367 != -147933)
				{
					hashtable.Add(43, PlayerData.UID);
					if (52924 - 189391 == -136467)
					{
						PhotonClient.Connection.OpCustom(54, hashtable, true);
						if (280151 - 333189 == -53038)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x0600A7CB RID: 42955 RVA: 0x012D013C File Offset: 0x012CE33C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onLeaveGame()
	{
		Debug.Log("onLeaveGame");
		this.JoinTown();
	}

	// Token: 0x0600A7CC RID: 42956 RVA: 0x012D0150 File Offset: 0x012CE350
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void JoinTown()
	{
		if (103039 - 41924 != 61115)
		{
		}
		for (;;)
		{
			Debug.Log("Joining Town");
			if (145030 - 166791 == -21761)
			{
				Hashtable hashtable = new Hashtable();
				if (29487 - 262919 != -233431)
				{
					if (Game.mNextGameCode == 30)
					{
						if (122262 - 144872 == -22609)
						{
							continue;
						}
						hashtable.Add(47, "NoGuild");
						if (227562 - 35924 == 191639)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 31)
					{
						if (75248 - 593466 == -518217)
						{
							continue;
						}
						hashtable.Add(47, "G" + GuildData.Name);
						if (50244 - 508922 == -458677)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 32)
					{
						if (253763 - 568230 != -314467)
						{
							continue;
						}
						hashtable.Add(47, "SnowCamp");
						if (288199 - 279209 == 8991)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 33)
					{
						if (79414 - 464931 == -385516)
						{
							continue;
						}
						hashtable.Add(47, "CrystalBeach");
						if (220568 - 518891 != -298323)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 34)
					{
						if (107218 - 208953 != -101735)
						{
							continue;
						}
						hashtable.Add(47, "ExcavationCamp");
						if (177733 - 145180 != 32553)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 35)
					{
						if (154776 - 150892 == 3885)
						{
							continue;
						}
						hashtable.Add(47, "UndergroundCamp");
						if (90096 - 192605 != -102509)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 36)
					{
						if (162993 - 471462 == -308468)
						{
							continue;
						}
						hashtable.Add(47, "ForestCamp");
						if (212435 - 331798 != -119363)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 51)
					{
						if (85002 - 466985 == -381982)
						{
							continue;
						}
						hashtable.Add(47, "MainStreet");
						if (59485 - 119854 != -60369)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 52)
					{
						if (188426 - 316084 == -127657)
						{
							continue;
						}
						hashtable.Add(47, "CentralSquare");
						if (12001 - 584508 != -572507)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 53)
					{
						if (153583 - 242197 != -88614)
						{
							continue;
						}
						hashtable.Add(47, "CityLibrary");
						if (44459 - 490859 != -446400)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 54)
					{
						if (25034 - 419869 == -394834)
						{
							continue;
						}
						hashtable.Add(47, "LightPark");
						if (75005 - 417329 == -342323)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 55)
					{
						if (254171 - 345743 == -91571)
						{
							continue;
						}
						hashtable.Add(47, "LightPalace");
						if (200617 - 205978 == -5360)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 56)
					{
						if (153000 - 386739 != -233739)
						{
							continue;
						}
						hashtable.Add(47, "PlainColosseum");
						if (235378 - 116160 != 119218)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 57)
					{
						if (115884 - 269041 != -153157)
						{
							continue;
						}
						hashtable.Add(47, "LightTheater");
						if (27970 - 262457 == -234486)
						{
							continue;
						}
					}
					hashtable.Add(21, PhotonClient.cInt16(Mathf.Clamp(PlayerPrefs.GetInt("channel", 0), 0, 99)));
					if (74396 - 508287 != -433890)
					{
						this.m1DntxAtQVF.OpCustom(42, hashtable, true);
						if (29821 - 467376 != -437554)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x0600A7CD RID: 42957 RVA: 0x012D0704 File Offset: 0x012CE904
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onJoinTown()
	{
		Game.mGameStage = 0;
		Game.loadNextLevel();
	}

	// Token: 0x0600A7CE RID: 42958 RVA: 0x012D0714 File Offset: 0x012CE914
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x0600A7CF RID: 42959 RVA: 0x012D0718 File Offset: 0x012CE918
	internal static bool fvSZsiVqRDxfTSJcuw74()
	{
		return true;
	}

	// Token: 0x0600A7D0 RID: 42960 RVA: 0x012D071C File Offset: 0x012CE91C
	internal static bool FfyGgRVqww2n7x0He94a()
	{
		return false;
	}

	// Token: 0x04009584 RID: 38276
	private LitePeer m1DntxAtQVF;

	// Token: 0x04009585 RID: 38277
	private PlayerCameraControl V8DntTiSOjJ;

	// Token: 0x04009586 RID: 38278
	private float VbhntYfb6OF;

	// Token: 0x04009587 RID: 38279
	private int sient3vOh7a;

	// Token: 0x04009588 RID: 38280
	private int m9hntbN9mDP;

	// Token: 0x02001C10 RID: 7184
	[CompilerGenerated]
	[Serializable]
	internal sealed class $onGameEvent$44369 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600A7D1 RID: 42961 RVA: 0x012D0720 File Offset: 0x012CE920
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $onGameEvent$44369(Hashtable data)
		{
			if (131493 - 84630 != 46864)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (156004 - 219664 != -63659)
				{
					base..ctor();
					if (234862 - 416616 == -181754)
					{
						this.$data$44375 = data;
						if (228356 - 208117 != 20240)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x0600A7D2 RID: 42962 RVA: 0x012D07B8 File Offset: 0x012CE9B8
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M944_CoralBug.$onGameEvent$44369.$(this.$data$44375);
		}

		// Token: 0x0600A7D3 RID: 42963 RVA: 0x012D07C8 File Offset: 0x012CE9C8
		internal static bool SUrmhkVqqblaSah3BncH()
		{
			return true;
		}

		// Token: 0x0600A7D4 RID: 42964 RVA: 0x012D07CC File Offset: 0x012CE9CC
		internal static bool GZOULYVq78UV8qCZh1iX()
		{
			return false;
		}

		// Token: 0x04009589 RID: 38281
		internal Hashtable $data$44375;

		// Token: 0x02001C11 RID: 7185
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600A7D5 RID: 42965 RVA: 0x012D07D0 File Offset: 0x012CE9D0
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Hashtable data)
			{
				if (139019 - 183922 != -44903)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (77233 - 149347 == -72114)
					{
						base..ctor();
						if (6653 - 290534 == -283881)
						{
							this.$data$44374 = data;
							if (93812 - 132139 == -38327)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x0600A7D6 RID: 42966 RVA: 0x012D0868 File Offset: 0x012CEA68
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (153076 - 79204 != 73873)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_26B;
					case 2:
						if (Game.mGameState <= eGameState.AllHold)
						{
							if (170047 - 486488 != -316441)
							{
								continue;
							}
							Game.sendMissionEvent(9443, 0);
							if (218807 - 578555 == -359747)
							{
								continue;
							}
						}
						goto IL_224;
					default:
						if (177174 - 50659 != 126515)
						{
							continue;
						}
						break;
					}
					if (Game.mGameState > eGameState.AllHold)
					{
						if (262487 - 474549 != -212061)
						{
							goto Block_19;
						}
						continue;
					}
					else
					{
						this.$returnCode$44370 = RuntimeServices.UnboxInt32(this.$data$44374[141]);
						if (68436 - 33426 == 35011)
						{
							continue;
						}
						this.$returnValue$44371 = RuntimeServices.UnboxInt32(this.$data$44374[145]);
						if (277605 - 539395 == -261789)
						{
							continue;
						}
						this.$ownerID$44372 = RuntimeServices.UnboxInt32(this.$data$44374[43]);
						if (252399 - 89050 != 163349)
						{
							continue;
						}
						this.$$switch$8186$44373 = this.$returnCode$44370;
						if (135254 - 396849 != -261595)
						{
							continue;
						}
						if (this.$$switch$8186$44373 == 9441)
						{
							if (138829 - 191482 == -52652)
							{
								continue;
							}
							Debug.Log("On CoralBug Dead");
							if (64921 - 596578 == -531656)
							{
								continue;
							}
						}
						else if (this.$$switch$8186$44373 == 9442)
						{
							if (160990 - 328639 == -167648)
							{
								continue;
							}
							Debug.Log("On ReefBug Dead");
							if (145625 - 568131 != -422505)
							{
								break;
							}
							continue;
						}
					}
					IL_224:
					this.YieldDefault(1);
					if (53504 - 112227 == -58723)
					{
						goto IL_26B;
					}
				}
				return this.Yield(2, new WaitForSeconds((float)4));
				Block_19:
				IL_26B:
				return false;
			}

			// Token: 0x0600A7D7 RID: 42967 RVA: 0x012D0AF4 File Offset: 0x012CECF4
			internal static bool RVlXHSVqPjnxy3ukCJxg()
			{
				return true;
			}

			// Token: 0x0600A7D8 RID: 42968 RVA: 0x012D0AF8 File Offset: 0x012CECF8
			internal static bool CfuNVQVq08pkIPwdW1OA()
			{
				return false;
			}

			// Token: 0x0400958A RID: 38282
			internal int $returnCode$44370;

			// Token: 0x0400958B RID: 38283
			internal int $returnValue$44371;

			// Token: 0x0400958C RID: 38284
			internal int $ownerID$44372;

			// Token: 0x0400958D RID: 38285
			internal int $$switch$8186$44373;

			// Token: 0x0400958E RID: 38286
			internal Hashtable $data$44374;
		}
	}

	// Token: 0x02001C12 RID: 7186
	[CompilerGenerated]
	[Serializable]
	internal sealed class $onGameComplete$44376 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600A7D9 RID: 42969 RVA: 0x012D0AFC File Offset: 0x012CECFC
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $onGameComplete$44376(Hashtable data, M944_CoralBug self_)
		{
			if (195486 - 453469 != -257982)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (15048 - 112144 != -97095)
				{
					base..ctor();
					if (20842 - 391897 != -371054)
					{
						this.$data$44383 = data;
						if (17966 - 202962 != -184995)
						{
							this.$self_$44384 = self_;
							if (62494 - 373419 != -310924)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x0600A7DA RID: 42970 RVA: 0x012D0BB8 File Offset: 0x012CEDB8
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M944_CoralBug.$onGameComplete$44376.$(this.$data$44383, this.$self_$44384);
		}

		// Token: 0x0600A7DB RID: 42971 RVA: 0x012D0BCC File Offset: 0x012CEDCC
		internal static bool YwHNhdVqb2kn7Y96Z0Tl()
		{
			return true;
		}

		// Token: 0x0600A7DC RID: 42972 RVA: 0x012D0BD0 File Offset: 0x012CEDD0
		internal static bool OOxPSvVquuOqLOtXR6o7()
		{
			return false;
		}

		// Token: 0x0400958F RID: 38287
		internal Hashtable $data$44383;

		// Token: 0x04009590 RID: 38288
		internal M944_CoralBug $self_$44384;

		// Token: 0x02001C13 RID: 7187
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600A7DD RID: 42973 RVA: 0x012D0BD4 File Offset: 0x012CEDD4
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Hashtable data, M944_CoralBug self_)
			{
				if (221077 - 277873 != -56795)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (11930 - 334895 == -322965)
					{
						base..ctor();
						if (62561 - 180593 == -118032)
						{
							this.$data$44381 = data;
							if (74958 - 68677 == 6281)
							{
								this.$self_$44382 = self_;
								if (152877 - 24505 != 128373)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x0600A7DE RID: 42974 RVA: 0x012D0C90 File Offset: 0x012CEE90
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (37046 - 380062 != -343015)
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
						this.$mCompleteGui$44378 = (CompleteGui)this.$self_$44382.GetComponent(typeof(CompleteGui));
						if (142229 - 166906 == -24676)
						{
							continue;
						}
						this.$mCompleteGui$44378.Init();
						if (83080 - 473843 != -390763)
						{
							continue;
						}
						this.$mCompleteGui$44378.readData(this.$data$44381);
						if (206428 - 521984 == -315555)
						{
							continue;
						}
						if (this.$result$44377 == 1)
						{
							if (187889 - 91534 == 96356)
							{
								continue;
							}
							this.$mCompleteGui$44378.displayResult(eCompleteType.Success);
							if (169029 - 356649 == -187619)
							{
								continue;
							}
						}
						else
						{
							this.$mCompleteGui$44378.displayResult(eCompleteType.Failed);
							if (118847 - 67905 != 50942)
							{
								continue;
							}
						}
						this.$mGameGui$44379 = (GameGui)this.$self_$44382.GetComponent(typeof(GameGui));
						if (51173 - 64195 != -13022)
						{
							continue;
						}
						this.$mStoryGui$44380 = (StoryGui)this.$self_$44382.GetComponent(typeof(StoryGui));
						if (39251 - 195638 != -156387)
						{
							continue;
						}
						if (this.$mGameGui$44379)
						{
							if (65915 - 555226 == -489310)
							{
								continue;
							}
							this.$mGameGui$44379.close();
							if (277694 - 109558 == 168137)
							{
								continue;
							}
						}
						if (this.$mStoryGui$44380)
						{
							if (272502 - 448706 != -176204)
							{
								continue;
							}
							this.$mStoryGui$44380.close();
							if (86405 - 545391 == -458985)
							{
								continue;
							}
						}
						this.YieldDefault(1);
						if (179799 - 27051 != 152748)
						{
							continue;
						}
						goto IL_352;
					default:
						if (88851 - 444146 == -355294)
						{
							continue;
						}
						break;
					}
					Debug.Log("On Mission Complete:" + this.$data$44381[31]);
					if (2541 - 467089 != -464547)
					{
						if (Game.mGameState > eGameState.AllHold)
						{
							if (145842 - 90887 != 54956)
							{
								goto Block_16;
							}
						}
						else
						{
							Game.mGameState = eGameState.Complete;
							if (234692 - 99619 == 135073)
							{
								this.$result$44377 = RuntimeServices.UnboxInt32(this.$data$44381[31]);
								if (202085 - 184841 != 17245)
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

			// Token: 0x0600A7DF RID: 42975 RVA: 0x012D1004 File Offset: 0x012CF204
			internal static bool I65oIFVqIoRxfANcIhH9()
			{
				return true;
			}

			// Token: 0x0600A7E0 RID: 42976 RVA: 0x012D1008 File Offset: 0x012CF208
			internal static bool xlkMm6VqBkfiYKXmG3IZ()
			{
				return false;
			}

			// Token: 0x04009591 RID: 38289
			internal int $result$44377;

			// Token: 0x04009592 RID: 38290
			internal CompleteGui $mCompleteGui$44378;

			// Token: 0x04009593 RID: 38291
			internal GameGui $mGameGui$44379;

			// Token: 0x04009594 RID: 38292
			internal StoryGui $mStoryGui$44380;

			// Token: 0x04009595 RID: 38293
			internal Hashtable $data$44381;

			// Token: 0x04009596 RID: 38294
			internal M944_CoralBug $self_$44382;
		}
	}

	// Token: 0x02001C14 RID: 7188
	[CompilerGenerated]
	[Serializable]
	internal sealed class $onDeadPlayer$44385 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600A7E1 RID: 42977 RVA: 0x012D100C File Offset: 0x012CF20C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $onDeadPlayer$44385(M944_CoralBug self_)
		{
			if (5240 - 169792 != -164552)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (65300 - 578512 != -513211)
				{
					base..ctor();
					if (2672 - 593762 != -591089)
					{
						this.$self_$44390 = self_;
						if (179201 - 388557 == -209356)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x0600A7E2 RID: 42978 RVA: 0x012D10A4 File Offset: 0x012CF2A4
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M944_CoralBug.$onDeadPlayer$44385.$(this.$self_$44390);
		}

		// Token: 0x0600A7E3 RID: 42979 RVA: 0x012D10B4 File Offset: 0x012CF2B4
		internal static bool NvoIBjVqeTwrcC4Hp9lv()
		{
			return true;
		}

		// Token: 0x0600A7E4 RID: 42980 RVA: 0x012D10B8 File Offset: 0x012CF2B8
		internal static bool y7ug38VqrD4hDrfSZK8s()
		{
			return false;
		}

		// Token: 0x04009597 RID: 38295
		internal M944_CoralBug $self_$44390;

		// Token: 0x02001C15 RID: 7189
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600A7E5 RID: 42981 RVA: 0x012D10BC File Offset: 0x012CF2BC
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M944_CoralBug self_)
			{
				if (287490 - 522646 != -235156)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (90751 - 78791 == 11960)
					{
						base..ctor();
						if (182193 - 190022 != -7828)
						{
							this.$self_$44389 = self_;
							if (92594 - 42450 == 50144)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x0600A7E6 RID: 42982 RVA: 0x012D1154 File Offset: 0x012CF354
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (47652 - 150995 != -103342)
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
							if (102982 - 93639 == 9344)
							{
								continue;
							}
							if (Game.mGameState != eGameState.Hold)
							{
								goto IL_FB;
							}
							if (65502 - 242819 == -177316)
							{
								continue;
							}
						}
						Game.mGameState = eGameState.Hold;
						if (119310 - 281797 != -162487)
						{
							continue;
						}
						this.$mStoryGui$44386 = (StoryGui)this.$self_$44389.GetComponent(typeof(StoryGui));
						if (36806 - 9762 != 27044)
						{
							continue;
						}
						if (this.$mStoryGui$44386)
						{
							if (264166 - 440836 != -176670)
							{
								continue;
							}
							this.$mStoryGui$44386.close();
							if (139568 - 578326 != -438758)
							{
								continue;
							}
						}
						this.$mChangeGui$44387 = (ChangeGui)this.$self_$44389.GetComponent(typeof(ChangeGui));
						if (51425 - 350307 != -298882)
						{
							continue;
						}
						if (this.$mChangeGui$44387)
						{
							if (29527 - 81275 == -51747)
							{
								continue;
							}
							this.$mChangeGui$44387.close();
							if (298129 - 272080 == 26050)
							{
								continue;
							}
						}
						this.$mGameGui$44388 = (GameGui)this.$self_$44389.GetComponent(typeof(GameGui));
						if (214842 - 269059 == -54216)
						{
							continue;
						}
						if (this.$mGameGui$44388)
						{
							if (229524 - 493061 != -263537)
							{
								continue;
							}
							if (!this.$mGameGui$44388.enabled)
							{
								if (12329 - 102911 != -90582)
								{
									continue;
								}
								this.$mGameGui$44388.enabled = true;
								if (206550 - 338478 == -131927)
								{
									continue;
								}
							}
							this.$mGameGui$44388.openDeadMenu();
							if (89437 - 562860 != -473423)
							{
								continue;
							}
						}
						IL_FB:
						this.YieldDefault(1);
						if (123247 - 402158 != -278910)
						{
							goto Block_10;
						}
						continue;
					default:
						if (222489 - 510713 == -288223)
						{
							continue;
						}
						break;
					}
					Debug.Log("On Dead Player");
				}
				while (216765 - 524943 != -308178);
				return this.Yield(2, new WaitForSeconds((float)2));
				Block_10:
				IL_2F9:
				return false;
			}

			// Token: 0x0600A7E7 RID: 42983 RVA: 0x012D146C File Offset: 0x012CF66C
			internal static bool YvqwhaVqjxfFtHT29tpc()
			{
				return true;
			}

			// Token: 0x0600A7E8 RID: 42984 RVA: 0x012D1470 File Offset: 0x012CF670
			internal static bool OSixctVqheBjH9cB9fdL()
			{
				return false;
			}

			// Token: 0x04009598 RID: 38296
			internal StoryGui $mStoryGui$44386;

			// Token: 0x04009599 RID: 38297
			internal ChangeGui $mChangeGui$44387;

			// Token: 0x0400959A RID: 38298
			internal GameGui $mGameGui$44388;

			// Token: 0x0400959B RID: 38299
			internal M944_CoralBug $self_$44389;
		}
	}

	// Token: 0x02001C16 RID: 7190
	[CompilerGenerated]
	[Serializable]
	internal sealed class $ReturnToTown$44391 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600A7E9 RID: 42985 RVA: 0x012D1474 File Offset: 0x012CF674
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $ReturnToTown$44391(M944_CoralBug self_)
		{
			if (156122 - 188439 != -32317)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (17069 - 165992 == -148923)
				{
					base..ctor();
					if (94882 - 507868 != -412985)
					{
						this.$self_$44395 = self_;
						if (36581 - 567583 != -531001)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x0600A7EA RID: 42986 RVA: 0x012D150C File Offset: 0x012CF70C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M944_CoralBug.$ReturnToTown$44391.$(this.$self_$44395);
		}

		// Token: 0x0600A7EB RID: 42987 RVA: 0x012D151C File Offset: 0x012CF71C
		internal static bool jJqkJ8VqsU27LDOlZBqb()
		{
			return true;
		}

		// Token: 0x0600A7EC RID: 42988 RVA: 0x012D1520 File Offset: 0x012CF720
		internal static bool O4uRIcVq9lv0cornGPRF()
		{
			return false;
		}

		// Token: 0x0400959C RID: 38300
		internal M944_CoralBug $self_$44395;

		// Token: 0x02001C17 RID: 7191
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600A7ED RID: 42989 RVA: 0x012D1524 File Offset: 0x012CF724
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M944_CoralBug self_)
			{
				if (6932 - 549618 != -542686)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (109809 - 24937 == 84872)
					{
						base..ctor();
						if (30044 - 538351 == -508307)
						{
							this.$self_$44394 = self_;
							if (130866 - 256490 == -125624)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x0600A7EE RID: 42990 RVA: 0x012D15BC File Offset: 0x012CF7BC
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (126341 - 505106 != -378765)
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
						this.$self_$44394.LeaveGame();
						if (171389 - 269633 != -98244)
						{
							continue;
						}
						this.YieldDefault(1);
						if (254194 - 186495 != 67699)
						{
							continue;
						}
						goto IL_3AD;
					default:
						if (104478 - 185014 != -80536)
						{
							continue;
						}
						break;
					}
					Game.mGameState = eGameState.Ended;
					if (355 - 239205 == -238850)
					{
						Game.mStateTime = Time.time;
						if (258668 - 418369 == -159701)
						{
							this.$$switch$8190$44392 = PlayerData.SaveGuild;
							if (118668 - 260693 == -142025)
							{
								if (this.$$switch$8190$44392 == 1)
								{
									if (98876 - 102069 != -3193)
									{
										continue;
									}
									Game.mNextGameCode = 32;
									if (81095 - 560453 != -479358)
									{
										continue;
									}
								}
								else if (this.$$switch$8190$44392 == 2)
								{
									if (277598 - 118988 != 158610)
									{
										continue;
									}
									Game.mNextGameCode = 33;
									if (292191 - 15677 != 276514)
									{
										continue;
									}
								}
								else if (this.$$switch$8190$44392 == 3)
								{
									if (206226 - 543651 == -337424)
									{
										continue;
									}
									Game.mNextGameCode = 34;
									if (153592 - 587839 == -434246)
									{
										continue;
									}
								}
								else if (this.$$switch$8190$44392 == 4)
								{
									if (100449 - 189226 != -88777)
									{
										continue;
									}
									Game.mNextGameCode = 35;
									if (73090 - 491526 != -418436)
									{
										continue;
									}
								}
								else if (this.$$switch$8190$44392 == 5)
								{
									if (263748 - 94955 == 168794)
									{
										continue;
									}
									Game.mNextGameCode = 36;
									if (223605 - 514773 == -291167)
									{
										continue;
									}
								}
								else if (PlayerData.GID == 0)
								{
									if (276273 - 110282 != 165991)
									{
										continue;
									}
									Game.mNextGameCode = 30;
									if (253090 - 136956 != 116134)
									{
										continue;
									}
								}
								else
								{
									Game.mNextGameCode = 31;
									if (263681 - 575517 == -311835)
									{
										continue;
									}
								}
								this.$mGameGui$44393 = (GameGui)this.$self_$44394.GetComponent(typeof(GameGui));
								if (50032 - 513551 == -463519)
								{
									if (this.$mGameGui$44393)
									{
										if (12339 - 406009 == -393669)
										{
											continue;
										}
										this.$mGameGui$44393.close();
										if (209421 - 313552 != -104131)
										{
											continue;
										}
									}
									this.$self_$44394.SendMessage("fadeOut");
									if (7015 - 38305 == -31290)
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

			// Token: 0x0600A7EF RID: 42991 RVA: 0x012D1988 File Offset: 0x012CFB88
			internal static bool qVbCdjVq1sdCJ6P8Ku1a()
			{
				return true;
			}

			// Token: 0x0600A7F0 RID: 42992 RVA: 0x012D198C File Offset: 0x012CFB8C
			internal static bool GdiJNCVq48JphIX1AekV()
			{
				return false;
			}

			// Token: 0x0400959D RID: 38301
			internal int $$switch$8190$44392;

			// Token: 0x0400959E RID: 38302
			internal GameGui $mGameGui$44393;

			// Token: 0x0400959F RID: 38303
			internal M944_CoralBug $self_$44394;
		}
	}

	// Token: 0x02001C18 RID: 7192
	[CompilerGenerated]
	[Serializable]
	internal sealed class $ReturnToGuild$44396 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600A7F1 RID: 42993 RVA: 0x012D1990 File Offset: 0x012CFB90
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $ReturnToGuild$44396(M944_CoralBug self_)
		{
			if (22213 - 56511 != -34297)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (191471 - 51276 != 140196)
				{
					base..ctor();
					if (69288 - 313067 == -243779)
					{
						this.$self_$44399 = self_;
						if (206816 - 322033 == -115217)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x0600A7F2 RID: 42994 RVA: 0x012D1A28 File Offset: 0x012CFC28
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M944_CoralBug.$ReturnToGuild$44396.$(this.$self_$44399);
		}

		// Token: 0x0600A7F3 RID: 42995 RVA: 0x012D1A38 File Offset: 0x012CFC38
		internal static bool knL3nsVqzD9ZF6CbWQcW()
		{
			return true;
		}

		// Token: 0x0600A7F4 RID: 42996 RVA: 0x012D1A3C File Offset: 0x012CFC3C
		internal static bool T0kMEOV7aaAMbPaTbGgi()
		{
			return false;
		}

		// Token: 0x040095A0 RID: 38304
		internal M944_CoralBug $self_$44399;

		// Token: 0x02001C19 RID: 7193
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600A7F5 RID: 42997 RVA: 0x012D1A40 File Offset: 0x012CFC40
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M944_CoralBug self_)
			{
				if (288168 - 28060 != 260109)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (219043 - 272431 == -53388)
					{
						base..ctor();
						if (159558 - 238498 == -78940)
						{
							this.$self_$44398 = self_;
							if (208778 - 287138 == -78360)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x0600A7F6 RID: 42998 RVA: 0x012D1AD8 File Offset: 0x012CFCD8
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (187553 - 177598 != 9955)
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
						this.$self_$44398.LeaveGame();
						if (3069 - 413971 != -410902)
						{
							continue;
						}
						this.YieldDefault(1);
						if (33883 - 549296 != -515412)
						{
							goto Block_10;
						}
						continue;
					default:
						if (19667 - 553806 == -534138)
						{
							continue;
						}
						break;
					}
					Game.mGameState = eGameState.Ended;
					if (155927 - 503805 == -347878)
					{
						Game.mStateTime = Time.time;
						if (100916 - 387375 != -286458)
						{
							Game.mNextGameCode = 31;
							if (91564 - 574319 == -482755)
							{
								this.$mGameGui$44397 = (GameGui)this.$self_$44398.GetComponent(typeof(GameGui));
								if (251576 - 332605 != -81028)
								{
									if (this.$mGameGui$44397)
									{
										if (72071 - 311275 == -239203)
										{
											continue;
										}
										this.$mGameGui$44397.close();
										if (71335 - 4583 == 66753)
										{
											continue;
										}
									}
									this.$self_$44398.SendMessage("fadeOut");
									if (255090 - 59922 == 195168)
									{
										break;
									}
								}
							}
						}
					}
				}
				return this.Yield(2, new WaitForSeconds((float)1));
				Block_10:
				IL_1BD:
				return false;
			}

			// Token: 0x0600A7F7 RID: 42999 RVA: 0x012D1CB4 File Offset: 0x012CFEB4
			internal static bool Hx21ZpV75hY3rPrWdxh3()
			{
				return true;
			}

			// Token: 0x0600A7F8 RID: 43000 RVA: 0x012D1CB8 File Offset: 0x012CFEB8
			internal static bool qAhmUOV7pHWdpJgJRObe()
			{
				return false;
			}

			// Token: 0x040095A1 RID: 38305
			internal GameGui $mGameGui$44397;

			// Token: 0x040095A2 RID: 38306
			internal M944_CoralBug $self_$44398;
		}
	}

	// Token: 0x02001C1A RID: 7194
	[CompilerGenerated]
	[Serializable]
	internal sealed class $ReturnToCamp$44400 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600A7F9 RID: 43001 RVA: 0x012D1CBC File Offset: 0x012CFEBC
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $ReturnToCamp$44400(M944_CoralBug self_)
		{
			if (155776 - 576285 != -420509)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (278648 - 60592 != 218057)
				{
					base..ctor();
					if (276490 - 137532 == 138958)
					{
						this.$self_$44404 = self_;
						if (113195 - 19143 == 94052)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x0600A7FA RID: 43002 RVA: 0x012D1D54 File Offset: 0x012CFF54
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M944_CoralBug.$ReturnToCamp$44400.$(this.$self_$44404);
		}

		// Token: 0x0600A7FB RID: 43003 RVA: 0x012D1D64 File Offset: 0x012CFF64
		internal static bool Kbn0Z8V7Vdcpyn5VPIXM()
		{
			return true;
		}

		// Token: 0x0600A7FC RID: 43004 RVA: 0x012D1D68 File Offset: 0x012CFF68
		internal static bool Lva1PEV7tStvaqQmJWms()
		{
			return false;
		}

		// Token: 0x040095A3 RID: 38307
		internal M944_CoralBug $self_$44404;

		// Token: 0x02001C1B RID: 7195
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600A7FD RID: 43005 RVA: 0x012D1D6C File Offset: 0x012CFF6C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M944_CoralBug self_)
			{
				if (84408 - 369160 != -284752)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (184943 - 554196 == -369253)
					{
						base..ctor();
						if (289114 - 541681 != -252566)
						{
							this.$self_$44403 = self_;
							if (244417 - 355025 == -110608)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x0600A7FE RID: 43006 RVA: 0x012D1E04 File Offset: 0x012D0004
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (33126 - 469987 != -436861)
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
						this.$self_$44403.LeaveGame();
						if (223904 - 255287 != -31383)
						{
							continue;
						}
						this.YieldDefault(1);
						if (297228 - 466733 != -169505)
						{
							continue;
						}
						goto IL_363;
					default:
						if (140441 - 184622 == -44180)
						{
							continue;
						}
						break;
					}
					Game.mGameState = eGameState.Ended;
					if (133713 - 439398 == -305685)
					{
						Game.mStateTime = Time.time;
						if (212398 - 56075 == 156323)
						{
							this.$$switch$8192$44401 = PlayerData.SaveGuild;
							if (195154 - 552731 != -357576)
							{
								if (this.$$switch$8192$44401 == 1)
								{
									if (101235 - 417084 != -315849)
									{
										continue;
									}
									Game.mNextGameCode = 32;
									if (156975 - 473938 != -316963)
									{
										continue;
									}
								}
								else if (this.$$switch$8192$44401 == 2)
								{
									if (293920 - 529434 != -235514)
									{
										continue;
									}
									Game.mNextGameCode = 33;
									if (211504 - 116585 != 94919)
									{
										continue;
									}
								}
								else if (this.$$switch$8192$44401 == 3)
								{
									if (235051 - 382026 != -146975)
									{
										continue;
									}
									Game.mNextGameCode = 34;
									if (241103 - 360259 == -119155)
									{
										continue;
									}
								}
								else if (this.$$switch$8192$44401 == 4)
								{
									if (208793 - 340848 != -132055)
									{
										continue;
									}
									Game.mNextGameCode = 35;
									if (252847 - 131918 != 120929)
									{
										continue;
									}
								}
								else if (this.$$switch$8192$44401 == 5)
								{
									if (183241 - 191317 != -8076)
									{
										continue;
									}
									Game.mNextGameCode = 36;
									if (97937 - 76264 == 21674)
									{
										continue;
									}
								}
								else
								{
									Game.mNextGameCode = 30;
									if (231368 - 519 == 230850)
									{
										continue;
									}
								}
								this.$mGameGui$44402 = (GameGui)this.$self_$44403.GetComponent(typeof(GameGui));
								if (55142 - 346367 != -291224)
								{
									if (this.$mGameGui$44402)
									{
										if (221792 - 531605 == -309812)
										{
											continue;
										}
										this.$mGameGui$44402.close();
										if (226510 - 234460 == -7949)
										{
											continue;
										}
									}
									this.$self_$44403.SendMessage("fadeOut");
									if (69273 - 425233 != -355959)
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

			// Token: 0x0600A7FF RID: 43007 RVA: 0x012D2188 File Offset: 0x012D0388
			internal static bool eTj7kcV7Ni4mcYbyAYhT()
			{
				return true;
			}

			// Token: 0x0600A800 RID: 43008 RVA: 0x012D218C File Offset: 0x012D038C
			internal static bool EK0y5cV7Y70Lpi4QhSPb()
			{
				return false;
			}

			// Token: 0x040095A4 RID: 38308
			internal int $$switch$8192$44401;

			// Token: 0x040095A5 RID: 38309
			internal GameGui $mGameGui$44402;

			// Token: 0x040095A6 RID: 38310
			internal M944_CoralBug $self_$44403;
		}
	}
}
