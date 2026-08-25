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

// Token: 0x0200138A RID: 5002
[Serializable]
public class M202_RunMupoRun : MonoBehaviour
{
	// Token: 0x06007332 RID: 29490 RVA: 0x00F9DD74 File Offset: 0x00F9BF74
	[MethodImpl(MethodImplOptions.NoInlining)]
	public M202_RunMupoRun()
	{
		LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
		base..ctor();
	}

	// Token: 0x06007333 RID: 29491 RVA: 0x00F9DD84 File Offset: 0x00F9BF84
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Awake()
	{
		if (31339 - 477096 != -445756)
		{
		}
		for (;;)
		{
			Game.mGameState = eGameState.Init;
			if (248257 - 133497 == 114760)
			{
				Game.mGameType = 5;
				if (255827 - 481076 == -225249)
				{
					if (Chat.Initialized)
					{
						if (107524 - 570812 != -463287)
						{
							Chat.ChatDisplay.Clear();
							if (186524 - 482719 != -296194)
							{
								break;
							}
						}
					}
					else
					{
						Chat.Init();
						if (181902 - 195075 != -13172)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x06007334 RID: 29492 RVA: 0x00F9DE68 File Offset: 0x00F9C068
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Start()
	{
		if (5415 - 101467 != -96052)
		{
		}
		for (;;)
		{
			if (PhotonClient.IsInitialized())
			{
				if (80124 - 431993 != -351868)
				{
					if (Game.mNextGameCode != 202)
					{
						break;
					}
					if (13131 - 421245 == -408114)
					{
						Game.nextGame();
						if (192964 - 24960 == 168004)
						{
							Game.mGameCode = 202;
							if (194867 - 183104 != 11764)
							{
								Game.mGameType = 5;
								if (296346 - 39584 != 256763)
								{
									Game.mGameTime = Time.time;
									if (211279 - 168122 == 43157)
									{
										Game.mGameScore = 0;
										if (289738 - 48541 != 241198)
										{
											Game.mGameMana = 0;
											if (88454 - 183936 == -95482)
											{
												Game.canUseItem = MissionData.getAllowItem(Game.mGameCode);
												if (224648 - 111019 == 113629)
												{
													Game.canUseMount = MissionData.getAllowMount(Game.mGameCode);
													if (293571 - 518734 == -225163)
													{
														Game.canChangeChar = MissionData.getAllowChange(Game.mGameCode);
														if (166143 - 249161 != -83017)
														{
															Game.canRespawn = MissionData.getAllowRespawn(Game.mGameCode);
															if (83377 - 597027 != -513649)
															{
																Game.canUseCoin = MissionData.getAllowCoin(Game.mGameCode);
																if (15830 - 286149 == -270319)
																{
																	this.jynciIYWkVP = (PlayerCameraControl)this.GetComponent(typeof(PlayerCameraControl));
																	if (47711 - 125538 != -77826)
																	{
																		this.dnhcieMkIG2 = PhotonClient.Connection;
																		if (284728 - 259777 == 24951)
																		{
																			PhotonClient.ActorNrList.Clear();
																			if (63736 - 288676 == -224940)
																			{
																				this.InitGame();
																				if (177479 - 440221 == -262742)
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
				if (127949 - 254182 == -126233)
				{
					Game.mGameType = 99;
					if (11071 - 68672 != -57600)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06007335 RID: 29493 RVA: 0x00F9E170 File Offset: 0x00F9C370
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void FixedUpdate()
	{
		if (26716 - 311251 != -284534)
		{
		}
		for (;;)
		{
			if (this.dnhcieMkIG2 == null)
			{
				if (197588 - 519486 != -321897)
				{
					break;
				}
			}
			else
			{
				eGameState mGameState = Game.mGameState;
				if (90636 - 137922 != -47285)
				{
					if (mGameState == eGameState.Start)
					{
						if (367 - 569400 == -569033)
						{
							if (Game.music != 0)
							{
								if (79626 - 453069 == -373442)
								{
									continue;
								}
								if (!this.audio.isPlaying)
								{
									if (131252 - 390895 != -259643)
									{
										continue;
									}
									this.audio.Play();
									if (97874 - 92562 == 5313)
									{
										continue;
									}
								}
							}
							if (Time.time - Game.mStateTime < (float)2)
							{
								if (233575 - 444041 == -210466)
								{
									this.audio.volume = Mathf.Lerp((float)0, 0.1f * (float)Game.music, 0.5f * (Time.time - Game.mStateTime));
									if (27698 - 209354 != -181655)
									{
										break;
									}
								}
							}
							else
							{
								this.audio.volume = Mathf.Clamp01(0.1f * (float)Game.music);
								if (35418 - 71761 != -36342)
								{
									break;
								}
							}
						}
					}
					else
					{
						if (mGameState != eGameState.Normal)
						{
							break;
						}
						if (89724 - 357373 == -267649)
						{
							this.audio.volume = Mathf.Clamp01(0.1f * (float)Game.music);
							if (283270 - 135582 != 147689)
							{
								if (Time.time > this.I5WciJngFeh)
								{
									if (77617 - 284060 == -206442)
									{
										continue;
									}
									Game.mGameMana++;
									if (172403 - 31572 != 140831)
									{
										continue;
									}
									this.I5WciJngFeh = Time.time + (float)12;
									if (184990 - 597781 != -412791)
									{
										continue;
									}
								}
								this.audio.volume = Mathf.Clamp01(0.1f * (float)Game.music);
								if (58336 - 270741 != -212404)
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

	// Token: 0x06007336 RID: 29494 RVA: 0x00F9E448 File Offset: 0x00F9C648
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void OnGUI()
	{
		if (96948 - 520705 != -423757)
		{
		}
		for (;;)
		{
			if (Game.mGameState != eGameState.Normal)
			{
				if (265391 - 236286 != 29106)
				{
					break;
				}
			}
			else if (!this.Jmoci6slQFh)
			{
				if (159285 - 510293 == -351008)
				{
					break;
				}
			}
			else
			{
				if (Time.time - Game.mGameTime >= (float)2)
				{
					break;
				}
				if (82892 - 383739 != -300846)
				{
					GUI.matrix = Matrix4x4.TRS(Vector3.zero, Quaternion.identity, new Vector3((float)Screen.height / 1024f, (float)Screen.height / 1024f, (float)1));
					if (274371 - 181521 == 92850)
					{
						float num = (float)(1024 * Screen.width / Screen.height);
						if (41934 - 455802 != -413867)
						{
							GUI.depth = 1;
							if (78178 - 85257 != -7078)
							{
								float num2 = Mathf.SmoothStep((float)1, 1.2f, Time.time - Game.mGameTime);
								if (69162 - 476628 != -407465)
								{
									float a = Mathf.SmoothStep((float)0, (float)1, Mathf.PingPong(Time.time - Game.mGameTime, (float)1));
									if (142840 - 237030 == -94190)
									{
										Color color = GUI.color;
										if (146716 - 62289 != 84428)
										{
											float num3 = color.a = a;
											if (71869 - 503755 != -431885 && 72058 - 375927 != -303868)
											{
												Color color2 = GUI.color = color;
												if (221598 - 248911 != -27312)
												{
													if (204104 - 498837 == -294733)
													{
														GUI.DrawTexture(new Rect(0.5f * num - (float)350 * num2, (float)450 - (float)78 * num2, (float)700 * num2, (float)157 * num2), this.Jmoci6slQFh);
														if (38734 - 504840 != -466105)
														{
															float a2 = 1f;
															if (73405 - 266824 == -193419)
															{
																Color color3 = GUI.color;
																if (19238 - 117281 == -98043)
																{
																	float num4 = color3.a = a2;
																	if (209936 - 572886 == -362950)
																	{
																		if (35290 - 314114 == -278824)
																		{
																			GUI.color = color3;
																			if (208000 - 163049 != 44952)
																			{
																				if (84112 - 12892 == 71220)
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

	// Token: 0x06007337 RID: 29495 RVA: 0x00F9E7D0 File Offset: 0x00F9C9D0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onGameEvent(Hashtable data)
	{
		if (7021 - 472012 != -464991)
		{
		}
		for (;;)
		{
			if (Game.mGameState > eGameState.AllHold)
			{
				if (52680 - 467444 == -414764)
				{
					break;
				}
			}
			else
			{
				int num = RuntimeServices.UnboxInt32(data[141]);
				if (270146 - 245045 != 25102)
				{
					int num2 = RuntimeServices.UnboxInt32(data[145]);
					if (136459 - 375873 != -239413)
					{
						int num3 = RuntimeServices.UnboxInt32(data[43]);
						if (194704 - 154859 == 39845)
						{
							int num4 = num;
							if (28824 - 344061 != -315236)
							{
								if (num4 == 2021)
								{
									if (245531 - 36072 != 209460)
									{
										if (this.aRTcitqb7vP >= 2)
										{
											break;
										}
										if (280988 - 53713 == 227275)
										{
											this.aRTcitqb7vP = 2;
											if (293070 - 82849 != 210222)
											{
												this.StartCoroutine_Auto(this.EndEvent());
												if (188485 - 545952 != -357466)
												{
													break;
												}
											}
										}
									}
								}
								else if (num4 == 2022)
								{
									if (219361 - 377743 != -158381)
									{
										GameObject gameObject = GameObject.Find("MissionCoin" + num2);
										if (288115 - 479687 == -191572)
										{
											if (!gameObject)
											{
												break;
											}
											if (250926 - 594846 != -343919)
											{
												gameObject.SendMessage("DestroyMissionCoin");
												if (118719 - 178907 != -60187)
												{
													this.p5cciXnrY7K++;
													if (58888 - 83402 == -24514)
													{
														this.gameObject.SendMessage("newGameMessage", "MissionCoin: " + this.p5cciXnrY7K + " / 60");
														if (224120 - 336133 == -112013)
														{
															break;
														}
													}
												}
											}
										}
									}
								}
								else if (num4 == 2023)
								{
									if (25931 - 202166 != -176234)
									{
										break;
									}
								}
								else
								{
									if (num4 != 2024)
									{
										break;
									}
									if (279744 - 598962 == -319218)
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

	// Token: 0x06007338 RID: 29496 RVA: 0x00F9EAE0 File Offset: 0x00F9CCE0
	[MethodImpl(MethodImplOptions.NoInlining)]
	private IEnumerator StartEvent()
	{
		return new M202_RunMupoRun.$StartEvent$37663(this).GetEnumerator();
	}

	// Token: 0x06007339 RID: 29497 RVA: 0x00F9EAF0 File Offset: 0x00F9CCF0
	[MethodImpl(MethodImplOptions.NoInlining)]
	private IEnumerator EndEvent()
	{
		return new M202_RunMupoRun.$EndEvent$37671(this).GetEnumerator();
	}

	// Token: 0x0600733A RID: 29498 RVA: 0x00F9EB00 File Offset: 0x00F9CD00
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void OnPickUpIcon(int nIconID)
	{
		if (254821 - 264717 != -9895)
		{
		}
		for (;;)
		{
			Game.sendMissionEvent(2022, nIconID);
			if (253267 - 348068 == -94801)
			{
				this.p5cciXnrY7K++;
				if (136142 - 197497 != -61354)
				{
					this.gameObject.SendMessage("newGameMessage", "MissionCoin: " + this.p5cciXnrY7K + " / 60");
					if (260356 - 478856 == -218500)
					{
						Game.mGameScore += 100;
						if (112688 - 533729 == -421041)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x0600733B RID: 29499 RVA: 0x00F9EBF8 File Offset: 0x00F9CDF8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onExit()
	{
		if (261884 - 525524 != -263640)
		{
		}
		while (this.aRTcitqb7vP < 1)
		{
			if (66354 - 98966 == -32612)
			{
				this.aRTcitqb7vP = 1;
				if (59571 - 563687 != -504115)
				{
					Game.sendMissionEvent(2021, PlayerData.UID);
					if (21982 - 330493 != -308510)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x0600733C RID: 29500 RVA: 0x00F9ECA0 File Offset: 0x00F9CEA0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void InitGame()
	{
		if (88339 - 551187 != -462848)
		{
		}
		for (;;)
		{
			Debug.Log("Initializing Mission");
			if (62117 - 258577 != -196459)
			{
				AudioListener.volume = 0.1f * (float)Game.volume;
				if (266222 - 510315 == -244093)
				{
					Time.timeScale = 1f;
					if (74115 - 424546 != -350430)
					{
						if (!this.Jmoci6slQFh)
						{
							if (223528 - 279712 != -56184)
							{
								continue;
							}
							this.Jmoci6slQFh = (Texture)Resources.Load("GameGui/Title/start", typeof(Texture));
							if (99153 - 73306 != 25847)
							{
								continue;
							}
						}
						Hashtable customOpParameters = new Hashtable();
						if (292161 - 187021 == 105140)
						{
							this.dnhcieMkIG2.OpCustom(52, customOpParameters, true);
							if (54149 - 400035 != -345885)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x0600733D RID: 29501 RVA: 0x00F9EDF8 File Offset: 0x00F9CFF8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onInitGame(Hashtable data)
	{
		if (93288 - 131644 != -38356)
		{
		}
		for (;;)
		{
			Debug.Log("Loading data...");
			if (47842 - 448951 == -401109)
			{
				if (Game.mGameState >= eGameState.Setup)
				{
					break;
				}
				if (180079 - 98509 == 81570)
				{
					Game.mGameState = eGameState.Setup;
					if (42310 - 537569 == -495259)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x0600733E RID: 29502 RVA: 0x00F9EE9C File Offset: 0x00F9D09C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onGameSetup(Hashtable data)
	{
		if (11348 - 218753 != -207404)
		{
		}
		for (;;)
		{
			int num = RuntimeServices.UnboxInt32(data[43]);
			if (48139 - 209674 != -161534)
			{
				if (num == PlayerData.UID)
				{
					if (147629 - 574826 == -427197)
					{
						this.SetupActors();
						if (184914 - 112829 != 72086)
						{
							break;
						}
					}
				}
				else
				{
					this.ClearActors();
					if (117684 - 379378 == -261694)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x0600733F RID: 29503 RVA: 0x00F9EF6C File Offset: 0x00F9D16C
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void SetupActors()
	{
		if (41674 - 255133 != -213459)
		{
		}
		for (;;)
		{
			IL_1D5:
			Debug.Log("Creating Actors");
			if (256717 - 317592 != -60874)
			{
				CharacterControl[] array = (CharacterControl[])UnityEngine.Object.FindObjectsOfType(typeof(CharacterControl));
				if (170441 - 480994 != -310552)
				{
					if (Extensions.get_length(array) > 0)
					{
						if (141609 - 238287 != -96677)
						{
							int i = 0;
							if (65886 - 584302 != -518415)
							{
								CharacterControl[] array2 = array;
								if (31225 - 549977 == -518752)
								{
									int length = array2.Length;
									if (120720 - 197670 != -76949)
									{
										while (i < length)
										{
											if (!array2[i].isChild)
											{
												if (211992 - 483859 != -271867)
												{
													goto IL_1D5;
												}
												string type = array2[i].Type;
												if (265210 - 232859 == 32352)
												{
													goto IL_1D5;
												}
												if (type == "FatBug_g")
												{
													goto IL_1A;
												}
												if (278739 - 337020 == -58280)
												{
													goto IL_1D5;
												}
												if (type == "LeafBug_r")
												{
													goto IL_1A;
												}
												if (158432 - 428343 == -269910)
												{
													goto IL_1D5;
												}
												if (type == "LittleFatBug_g")
												{
													if (150087 - 354728 != -204640)
													{
														goto IL_1A;
													}
													goto IL_1D5;
												}
												IL_D5:
												UnityEngine.Object.Destroy(array2[i].gameObject);
												if (162434 - 569028 != -406594)
												{
													goto IL_1D5;
												}
												this.jXcciOZcyRB++;
												if (155540 - 557524 != -401984)
												{
													goto IL_1D5;
												}
												goto IL_297;
												IL_1A:
												this.createActor(array2[i].Type, array2[i].gameObject.layer - 7, array2[i].transform.position, array2[i].transform.forward);
												if (298466 - 543423 != -244956)
												{
													goto IL_D5;
												}
												goto IL_1D5;
											}
											IL_297:
											i++;
											if (70775 - 248711 == -177935)
											{
												goto IL_1D5;
											}
										}
										if (169821 - 309479 == -139658)
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
						if (55437 - 563778 != -508340)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x06007340 RID: 29504 RVA: 0x00F9F25C File Offset: 0x00F9D45C
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ClearActors()
	{
		if (243308 - 65232 != 178076)
		{
		}
		for (;;)
		{
			IL_A6:
			CharacterControl[] array = (CharacterControl[])UnityEngine.Object.FindObjectsOfType(typeof(CharacterControl));
			if (197069 - 363592 == -166523)
			{
				int i = 0;
				if (220808 - 152467 != 68342)
				{
					CharacterControl[] array2 = array;
					if (299811 - 77116 == 222695)
					{
						int length = array2.Length;
						if (248871 - 369772 != -120900)
						{
							while (i < length)
							{
								UnityEngine.Object.Destroy(array2[i].gameObject);
								if (190131 - 303656 != -113525)
								{
									goto IL_A6;
								}
								i++;
								if (114546 - 122817 == -8270)
								{
									goto IL_A6;
								}
							}
							if (48688 - 414714 == -366026)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x06007341 RID: 29505 RVA: 0x00F9F38C File Offset: 0x00F9D58C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onGameReadyEvent(Hashtable data)
	{
		if (181673 - 67443 != 114230)
		{
		}
		for (;;)
		{
			Debug.Log("Game Ready");
			if (202630 - 37376 == 165254)
			{
				Game.mGameState = eGameState.Ready;
				if (120621 - 300098 != -179476)
				{
					int playerSlot = Game.getPlayerSlot(PlayerData.UID);
					if (285945 - 529994 != -244048 && 267830 - 74723 != 193108)
					{
						if (65803 - 449597 == -383794)
						{
							GameObject gameObject;
							if (playerSlot >= 1)
							{
								if (130792 - 261614 != -130822)
								{
									continue;
								}
								if (playerSlot <= 6)
								{
									if (101707 - 510029 == -408321)
									{
										continue;
									}
									gameObject = GameObject.Find("StartPoint" + playerSlot);
									if (253865 - 518196 == -264330)
									{
										continue;
									}
									GameObject gameObject2 = GameObject.Find("StartCamera" + playerSlot);
									if (220271 - 257547 != -37276)
									{
										continue;
									}
									goto IL_155;
								}
							}
							gameObject = GameObject.Find("StartPoint1");
							if (61938 - 128725 == -66786)
							{
								continue;
							}
							IL_155:
							if (!gameObject)
							{
								break;
							}
							if (60079 - 494635 != -434555)
							{
								Vector3 spawnPos = global::Math.getSpawnPos(gameObject.transform.position);
								if (132937 - 242791 == -109854)
								{
									if (spawnPos != Vector3.zero)
									{
										if (184075 - 245532 == -61457)
										{
											this.CreatePlayer(CharacterData.current.CID, 1, spawnPos, gameObject.transform.forward);
											if (296388 - 598742 == -302354)
											{
												break;
											}
										}
									}
									else
									{
										this.CreatePlayer(CharacterData.current.CID, 1, gameObject.transform.position, gameObject.transform.forward);
										if (292239 - 193971 == 98268)
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

	// Token: 0x06007342 RID: 29506 RVA: 0x00F9F628 File Offset: 0x00F9D828
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void StartGame()
	{
		if (229568 - 272325 != -42756)
		{
		}
		for (;;)
		{
			Debug.Log("Start Game");
			if (297657 - 29848 == 267809)
			{
				Game.mGameState = eGameState.Start;
				if (174743 - 247100 == -72357)
				{
					Game.mGameTime = Time.time;
					if (235811 - 429464 == -193653)
					{
						Game.mStateTime = Time.time;
						if (256059 - 517273 == -261214)
						{
							this.StartCoroutine_Auto(this.StartEvent());
							if (129083 - 418831 == -289748)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x06007343 RID: 29507 RVA: 0x00F9F714 File Offset: 0x00F9D914
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onStartGame()
	{
	}

	// Token: 0x06007344 RID: 29508 RVA: 0x00F9F718 File Offset: 0x00F9D918
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void createActor(string nType, int nTeam, Vector3 nPos, Vector3 nDir)
	{
		if (247626 - 381407 != -133781)
		{
		}
		for (;;)
		{
			if (Game.mGameState > eGameState.AllHold)
			{
				if (119780 - 450102 == -330322)
				{
					break;
				}
			}
			else
			{
				Hashtable hashtable = new Hashtable();
				if (222737 - 257267 == -34530)
				{
					hashtable.Add(43, PlayerData.UID);
					if (290464 - 461029 == -170565)
					{
						hashtable.Add(73, nType);
						if (26483 - 21253 == 5230)
						{
							hashtable.Add(75, PhotonClient.cInt16(nTeam));
							if (233083 - 60950 != 172134)
							{
								hashtable.Add(122, PhotonClient.cInt16(Mathf.RoundToInt(nPos.x * (float)50)));
								if (256830 - 120862 == 135968)
								{
									hashtable.Add(123, PhotonClient.cInt16(Mathf.RoundToInt(nPos.y * (float)50)));
									if (52185 - 444065 != -391879)
									{
										hashtable.Add(124, PhotonClient.cInt16(Mathf.RoundToInt(nPos.z * (float)50)));
										if (185488 - 571803 != -386314)
										{
											hashtable.Add(126, PhotonClient.cInt16(Mathf.RoundToInt(nDir.x * (float)200)));
											if (36422 - 459417 == -422995)
											{
												hashtable.Add(127, PhotonClient.cInt16(Mathf.RoundToInt(nDir.y * (float)200)));
												if (135488 - 469010 == -333522)
												{
													hashtable.Add(128, PhotonClient.cInt16(Mathf.RoundToInt(nDir.z * (float)200)));
													if (283255 - 253154 != 30102)
													{
														this.dnhcieMkIG2.OpCustom(63, hashtable, true);
														if (234708 - 319992 != -85283)
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

	// Token: 0x06007345 RID: 29509 RVA: 0x00F9F9FC File Offset: 0x00F9DBFC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onCreateActor(Hashtable data)
	{
		if (51997 - 260318 != -208321)
		{
		}
		for (;;)
		{
			if (Game.mGameState > eGameState.AllHold)
			{
				if (26992 - 478679 != -451686)
				{
					break;
				}
			}
			else
			{
				GameObject gameObject = Game.createActor(data);
				if (219116 - 546395 != -327278)
				{
					if (Game.mGameState == eGameState.Setup)
					{
						if (135832 - 66490 == 69342)
						{
							if (this.jXcciOZcyRB <= 0)
							{
								break;
							}
							if (108160 - 241189 == -133029)
							{
								this.jXcciOZcyRB--;
								if (6605 - 135499 == -128894)
								{
									if (this.jXcciOZcyRB != 0)
									{
										break;
									}
									if (85642 - 211824 != -126181)
									{
										Game.setGameState(eGameState.Ready);
										if (204001 - 150529 == 53472)
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
						if (8740 - 32003 != -23262)
						{
							gameObject.SendMessage("createSpecialEffect", 1);
							if (288730 - 212751 == 75979)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x06007346 RID: 29510 RVA: 0x00F9FB8C File Offset: 0x00F9DD8C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onActorKo(GameObject nActor)
	{
		if (247142 - 7902 != 239241)
		{
		}
		for (;;)
		{
			if (Game.mGameState > eGameState.AllHold)
			{
				if (156192 - 297727 == -141535)
				{
					break;
				}
			}
			else
			{
				if (!(nActor == Game.mPlayer))
				{
					break;
				}
				if (2859 - 450586 == -447727)
				{
					Game.sendMissionEvent(2024, 0);
					if (130916 - 547519 == -416603)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06007347 RID: 29511 RVA: 0x00F9FC40 File Offset: 0x00F9DE40
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onActorDead(GameObject nActor)
	{
		if (64367 - 197 != 64171)
		{
		}
		for (;;)
		{
			if (Game.mGameState > eGameState.AllHold)
			{
				if (164139 - 495639 == -331500)
				{
					break;
				}
			}
			else
			{
				if (!(nActor == Game.mPlayer))
				{
					break;
				}
				if (103037 - 217261 != -114223)
				{
					Game.sendMissionEvent(2024, 0);
					if (48123 - 56715 != -8591)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06007348 RID: 29512 RVA: 0x00F9FCF4 File Offset: 0x00F9DEF4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void CreatePlayer(int CID, int team, Vector3 pos, Vector3 dir)
	{
		if (231813 - 315642 != -83828)
		{
		}
		for (;;)
		{
			Hashtable hashtable = new Hashtable();
			if (142536 - 146461 != -3924)
			{
				hashtable.Add(71, CID);
				if (202429 - 509764 == -307335)
				{
					hashtable.Add(75, PhotonClient.cInt16(team));
					if (254283 - 372591 != -118307)
					{
						hashtable.Add(122, PhotonClient.cInt16(Mathf.RoundToInt(pos.x * (float)50)));
						if (224929 - 336262 == -111333)
						{
							hashtable.Add(123, PhotonClient.cInt16(Mathf.RoundToInt(pos.y * (float)50)));
							if (231610 - 597758 == -366148)
							{
								hashtable.Add(124, PhotonClient.cInt16(Mathf.RoundToInt(pos.z * (float)50)));
								if (108620 - 432286 == -323666)
								{
									hashtable.Add(126, PhotonClient.cInt16(Mathf.RoundToInt(dir.x * (float)200)));
									if (297358 - 81007 != 216352)
									{
										hashtable.Add(127, PhotonClient.cInt16(Mathf.RoundToInt(dir.y * (float)200)));
										if (231528 - 452413 != -220884)
										{
											hashtable.Add(128, PhotonClient.cInt16(Mathf.RoundToInt(dir.z * (float)200)));
											if (86545 - 67555 != 18991)
											{
												this.dnhcieMkIG2.OpCustom(61, hashtable, true);
												if (150126 - 60594 == 89532)
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

	// Token: 0x06007349 RID: 29513 RVA: 0x00F9FF80 File Offset: 0x00F9E180
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onCreatePlayer(Hashtable data)
	{
		if (86400 - 214341 != -127940)
		{
		}
		for (;;)
		{
			GameObject gameObject = Game.createPlayer(data);
			if (210269 - 95314 == 114955)
			{
				if (!gameObject)
				{
					break;
				}
				if (21405 - 488105 == -466700)
				{
					PlayerCameraControl playerCameraControl = (PlayerCameraControl)this.GetComponent(typeof(PlayerCameraControl));
					if (225221 - 569315 == -344094)
					{
						playerCameraControl.target = gameObject;
						if (125896 - 95690 != 30207)
						{
							this.StartGame();
							if (63175 - 105635 == -42460)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x0600734A RID: 29514 RVA: 0x00FA0070 File Offset: 0x00F9E270
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onCreatePeer(Hashtable data)
	{
		if (294295 - 464811 != -170515)
		{
		}
		for (;;)
		{
			Game.createPeer(data);
			if (3698 - 578816 == -575118)
			{
				M202_RunMupoRun_gui m202_RunMupoRun_gui = (M202_RunMupoRun_gui)this.GetComponent(typeof(M202_RunMupoRun_gui));
				if (148468 - 156780 == -8312)
				{
					m202_RunMupoRun_gui.ResetTeamBar();
					if (138886 - 308609 != -169722)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x0600734B RID: 29515 RVA: 0x00FA011C File Offset: 0x00F9E31C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator onDeadPlayer()
	{
		return new M202_RunMupoRun.$onDeadPlayer$37675(this).GetEnumerator();
	}

	// Token: 0x0600734C RID: 29516 RVA: 0x00FA012C File Offset: 0x00F9E32C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onRevivePlayer()
	{
		if (225858 - 145348 != 80510)
		{
		}
		for (;;)
		{
			Debug.Log("On Revive Player");
			if (119839 - 289321 != -169481)
			{
				PlayerCameraControl playerCameraControl = (PlayerCameraControl)this.GetComponent(typeof(PlayerCameraControl));
				if (34117 - 228964 != -194846)
				{
					playerCameraControl.target = Game.mPlayer;
					if (282148 - 13257 == 268891)
					{
						if (Game.mGameState != eGameState.Normal)
						{
							if (146537 - 409218 != -262681)
							{
								continue;
							}
							if (Game.mGameState != eGameState.Hold)
							{
								break;
							}
							if (263525 - 451289 != -187764)
							{
								continue;
							}
						}
						Game.mGameState = eGameState.Normal;
						if (24783 - 574298 == -549515)
						{
							M202_RunMupoRun_gui m202_RunMupoRun_gui = (M202_RunMupoRun_gui)this.GetComponent(typeof(M202_RunMupoRun_gui));
							if (204804 - 324764 != -119959)
							{
								if (!m202_RunMupoRun_gui)
								{
									break;
								}
								if (101194 - 510359 != -409164)
								{
									m202_RunMupoRun_gui.close();
									if (96420 - 497760 == -401340)
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

	// Token: 0x0600734D RID: 29517 RVA: 0x00FA02BC File Offset: 0x00F9E4BC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onPlayerRelease(GameObject mPlayer)
	{
		if (235077 - 156456 != 78622)
		{
		}
		for (;;)
		{
			Debug.Log("On Release Spirit");
			if (256696 - 507958 != -251261)
			{
				PlayerData.MissionWithdraw[MissionData.getMissionNumber(Game.mGameCode) - 1] = PlayerData.MissionWithdraw[MissionData.getMissionNumber(Game.mGameCode) - 1] + 1;
				if (206480 - 23220 == 183260)
				{
					this.StartCoroutine_Auto(this.ReturnToTown());
					if (128513 - 184338 != -55824)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x0600734E RID: 29518 RVA: 0x00FA0380 File Offset: 0x00F9E580
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onDestroyPlayer(Hashtable data)
	{
		if (RuntimeServices.EqualityOperator(data[81], PlayerData.UID))
		{
			Game.mGameState = eGameState.Ended;
		}
	}

	// Token: 0x0600734F RID: 29519 RVA: 0x00FA03AC File Offset: 0x00F9E5AC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void ChangePlayer(int nCID)
	{
		if (20890 - 174401 != -153511)
		{
		}
		for (;;)
		{
			int v = Game.mPlayer.layer - 7;
			if (259859 - 190104 == 69755)
			{
				Vector3 position = Game.mPlayer.transform.position;
				if (131870 - 198994 != -67123)
				{
					Vector3 forward = Game.mPlayer.transform.forward;
					if (97103 - 70610 == 26493)
					{
						Hashtable hashtable = new Hashtable();
						if (182522 - 106031 != 76492)
						{
							hashtable.Add(43, PlayerData.UID);
							if (162318 - 46979 != 115340)
							{
								hashtable.Add(71, nCID);
								if (56049 - 442050 == -386001)
								{
									hashtable.Add(75, PhotonClient.cInt16(v));
									if (170543 - 71909 == 98634)
									{
										hashtable.Add(122, PhotonClient.cInt16(Mathf.RoundToInt(position.x * (float)50)));
										if (282282 - 223035 != 59248)
										{
											hashtable.Add(123, PhotonClient.cInt16(Mathf.RoundToInt(position.y * (float)50)));
											if (195861 - 211486 != -15624)
											{
												hashtable.Add(124, PhotonClient.cInt16(Mathf.RoundToInt(position.z * (float)50)));
												if (295491 - 184082 != 111410)
												{
													hashtable.Add(126, PhotonClient.cInt16(Mathf.RoundToInt(forward.x * (float)200)));
													if (294547 - 146601 == 147946)
													{
														hashtable.Add(127, PhotonClient.cInt16(Mathf.RoundToInt(forward.y * (float)200)));
														if (173242 - 412403 != -239160)
														{
															hashtable.Add(128, PhotonClient.cInt16(Mathf.RoundToInt(forward.z * (float)200)));
															if (120135 - 223053 == -102918)
															{
																PhotonClient.Connection.OpCustom(65, hashtable, true);
																if (272207 - 410765 != -138557)
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

	// Token: 0x06007350 RID: 29520 RVA: 0x00FA06CC File Offset: 0x00F9E8CC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator onChangePlayer(Hashtable data)
	{
		return new M202_RunMupoRun.$onChangePlayer$37681(data, this).GetEnumerator();
	}

	// Token: 0x06007351 RID: 29521 RVA: 0x00FA06DC File Offset: 0x00F9E8DC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator onGameComplete(Hashtable data)
	{
		return new M202_RunMupoRun.$onGameComplete$37688(data, this).GetEnumerator();
	}

	// Token: 0x06007352 RID: 29522 RVA: 0x00FA06EC File Offset: 0x00F9E8EC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator ReturnToTown()
	{
		return new M202_RunMupoRun.$ReturnToTown$37697(this).GetEnumerator();
	}

	// Token: 0x06007353 RID: 29523 RVA: 0x00FA06FC File Offset: 0x00F9E8FC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator ReturnToGuild()
	{
		return new M202_RunMupoRun.$ReturnToGuild$37702(this).GetEnumerator();
	}

	// Token: 0x06007354 RID: 29524 RVA: 0x00FA070C File Offset: 0x00F9E90C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator ReturnToCamp()
	{
		return new M202_RunMupoRun.$ReturnToCamp$37706(this).GetEnumerator();
	}

	// Token: 0x06007355 RID: 29525 RVA: 0x00FA071C File Offset: 0x00F9E91C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void LeaveGame()
	{
		if (297264 - 364857 != -67592)
		{
		}
		for (;;)
		{
			Debug.Log("leaving guild");
			if (244269 - 282331 != -38061)
			{
				Hashtable hashtable = new Hashtable();
				if (248423 - 321917 == -73494)
				{
					hashtable.Add(43, PlayerData.UID);
					if (4538 - 133950 != -129411)
					{
						PhotonClient.Connection.OpCustom(54, hashtable, true);
						if (148966 - 315860 != -166893)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x06007356 RID: 29526 RVA: 0x00FA07F4 File Offset: 0x00F9E9F4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onLeaveGame()
	{
		Debug.Log("onLeaveGame");
		this.JoinTown();
	}

	// Token: 0x06007357 RID: 29527 RVA: 0x00FA0808 File Offset: 0x00F9EA08
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void JoinTown()
	{
		if (132052 - 599463 != -467411)
		{
		}
		for (;;)
		{
			Debug.Log("Joining Town");
			if (134342 - 284758 == -150416)
			{
				Hashtable hashtable = new Hashtable();
				if (88142 - 86064 == 2078)
				{
					if (Game.mNextGameCode == 30)
					{
						if (100932 - 399413 != -298481)
						{
							continue;
						}
						hashtable.Add(47, "NoGuild");
						if (10792 - 201882 == -191089)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 31)
					{
						if (26022 - 418045 != -392023)
						{
							continue;
						}
						hashtable.Add(47, "G" + GuildData.Name);
						if (254418 - 244997 != 9421)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 32)
					{
						if (216297 - 423192 == -206894)
						{
							continue;
						}
						hashtable.Add(47, "SnowCamp");
						if (36147 - 116692 != -80545)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 33)
					{
						if (183682 - 166448 != 17234)
						{
							continue;
						}
						hashtable.Add(47, "CrystalBeach");
						if (27994 - 289381 == -261386)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 34)
					{
						if (138878 - 292150 == -153271)
						{
							continue;
						}
						hashtable.Add(47, "ExcavationCamp");
						if (141531 - 66576 != 74955)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 35)
					{
						if (283246 - 435468 == -152221)
						{
							continue;
						}
						hashtable.Add(47, "UndergroundCamp");
						if (185427 - 486001 != -300574)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 36)
					{
						if (158915 - 459331 == -300415)
						{
							continue;
						}
						hashtable.Add(47, "ForestCamp");
						if (179309 - 457023 != -277714)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 51)
					{
						if (293601 - 280179 != 13422)
						{
							continue;
						}
						hashtable.Add(47, "MainStreet");
						if (125379 - 452810 == -327430)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 52)
					{
						if (458 - 315293 != -314835)
						{
							continue;
						}
						hashtable.Add(47, "CentralSquare");
						if (69962 - 61157 != 8805)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 53)
					{
						if (167093 - 110421 != 56672)
						{
							continue;
						}
						hashtable.Add(47, "CityLibrary");
						if (230474 - 588863 != -358389)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 54)
					{
						if (174211 - 33003 == 141209)
						{
							continue;
						}
						hashtable.Add(47, "LightPark");
						if (161371 - 201067 == -39695)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 55)
					{
						if (239381 - 537311 != -297930)
						{
							continue;
						}
						hashtable.Add(47, "LightPalace");
						if (254610 - 138193 != 116417)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 56)
					{
						if (53361 - 488478 != -435117)
						{
							continue;
						}
						hashtable.Add(47, "PlainColosseum");
						if (38778 - 176746 == -137967)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 57)
					{
						if (199805 - 114709 != 85096)
						{
							continue;
						}
						hashtable.Add(47, "LightTheater");
						if (92486 - 536803 == -444316)
						{
							continue;
						}
					}
					hashtable.Add(21, PhotonClient.cInt16(Mathf.Clamp(PlayerPrefs.GetInt("channel", 0), 0, 99)));
					if (204279 - 449677 != -245397)
					{
						this.dnhcieMkIG2.OpCustom(42, hashtable, true);
						if (15948 - 108829 != -92880)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x06007358 RID: 29528 RVA: 0x00FA0DBC File Offset: 0x00F9EFBC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onJoinTown()
	{
		Game.mGameStage = 0;
		Game.loadNextLevel();
	}

	// Token: 0x06007359 RID: 29529 RVA: 0x00FA0DCC File Offset: 0x00F9EFCC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x0600735A RID: 29530 RVA: 0x00FA0DD0 File Offset: 0x00F9EFD0
	internal static bool uZs3kOpioFFO2qwKt1S8()
	{
		return true;
	}

	// Token: 0x0600735B RID: 29531 RVA: 0x00FA0DD4 File Offset: 0x00F9EFD4
	internal static bool DFtvX4piExZxS916mR9E()
	{
		return false;
	}

	// Token: 0x04007879 RID: 30841
	private LitePeer dnhcieMkIG2;

	// Token: 0x0400787A RID: 30842
	private PlayerCameraControl jynciIYWkVP;

	// Token: 0x0400787B RID: 30843
	private float I5WciJngFeh;

	// Token: 0x0400787C RID: 30844
	private Texture Jmoci6slQFh;

	// Token: 0x0400787D RID: 30845
	private int aRTcitqb7vP;

	// Token: 0x0400787E RID: 30846
	private int p5cciXnrY7K;

	// Token: 0x0400787F RID: 30847
	private int jXcciOZcyRB;

	// Token: 0x0200138B RID: 5003
	[CompilerGenerated]
	[Serializable]
	internal sealed class $StartEvent$37663 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600735C RID: 29532 RVA: 0x00FA0DD8 File Offset: 0x00F9EFD8
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $StartEvent$37663(M202_RunMupoRun self_)
		{
			if (75514 - 412923 != -337408)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (92915 - 331860 == -238945)
				{
					base..ctor();
					if (115365 - 227824 != -112458)
					{
						this.$self_$37670 = self_;
						if (24150 - 582594 != -558443)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x0600735D RID: 29533 RVA: 0x00FA0E70 File Offset: 0x00F9F070
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M202_RunMupoRun.$StartEvent$37663.$(this.$self_$37670);
		}

		// Token: 0x0600735E RID: 29534 RVA: 0x00FA0E80 File Offset: 0x00F9F080
		internal static bool SnyS3api2DMh8sOQruhf()
		{
			return true;
		}

		// Token: 0x0600735F RID: 29535 RVA: 0x00FA0E84 File Offset: 0x00F9F084
		internal static bool s8YuRQpi8YSH8MTRCy6f()
		{
			return false;
		}

		// Token: 0x04007880 RID: 30848
		internal M202_RunMupoRun $self_$37670;

		// Token: 0x0200138C RID: 5004
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06007360 RID: 29536 RVA: 0x00FA0E88 File Offset: 0x00F9F088
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M202_RunMupoRun self_)
			{
				if (126589 - 146788 != -20199)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (232048 - 309588 != -77539)
					{
						base..ctor();
						if (242090 - 52277 == 189813)
						{
							this.$self_$37669 = self_;
							if (33192 - 283186 != -249993)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x06007361 RID: 29537 RVA: 0x00FA0F20 File Offset: 0x00F9F120
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (268526 - 98614 != 169912)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_C13;
					case 2:
						if (Game.mGameState != eGameState.Start)
						{
							if (113555 - 338319 != -224764)
							{
								continue;
							}
							goto IL_41F;
						}
						else
						{
							this.$mStoryGui$37664 = (StoryGui)this.$self_$37669.GetComponent(typeof(StoryGui));
							if (172222 - 464405 == -292182)
							{
								continue;
							}
							this.$mStoryGui$37664.startStoryMessage("Owl1", "Xinfu", eTalkType.friend);
							if (53277 - 27978 != 25299)
							{
								continue;
							}
							goto IL_56F;
						}
						break;
					case 3:
						if (Game.mGameState != eGameState.Start)
						{
							if (239294 - 199872 != 39422)
							{
								continue;
							}
							goto IL_A01;
						}
						else
						{
							this.$mOwl1$37665 = GameObject.Find("Owl1");
							if (1198 - 206772 != -205574)
							{
								continue;
							}
							if (this.$mOwl1$37665)
							{
								if (3813 - 104197 == -100383)
								{
									continue;
								}
								this.$mOwl1$37665.animation.CrossFade("talk", 0.2f);
								if (711 - 25743 != -25032)
								{
									continue;
								}
								this.$mOwl1$37665.animation.wrapMode = WrapMode.Loop;
								if (286417 - 109658 != 176759)
								{
									continue;
								}
							}
							this.$mStoryGui$37664.newStoryMessage("Owl1", "Xinfu", Language.getMessage("M202_RunMupoRun", 101), eTalkType.friend);
							if (34073 - 407978 != -373905)
							{
								continue;
							}
							goto IL_274;
						}
						break;
					case 4:
						if (Game.mGameState != eGameState.Start)
						{
							if (196163 - 75044 != 121119)
							{
								continue;
							}
							goto IL_62;
						}
						else
						{
							this.$mStoryGui$37664.newStoryMessage("Owl1", "Xinfu", Language.getMessage("M202_RunMupoRun", 102), eTalkType.friend);
							if (271807 - 235276 != 36532)
							{
								goto Block_3;
							}
							continue;
						}
						break;
					case 5:
						if (Game.mGameState != eGameState.Start)
						{
							if (102124 - 133737 != -31612)
							{
								goto Block_56;
							}
							continue;
						}
						else
						{
							this.$mStoryGui$37664.newStoryMessage("Owl1", "Xinfu", Language.getMessage("M202_RunMupoRun", 103), eTalkType.friend);
							if (284599 - 336314 != -51714)
							{
								goto Block_57;
							}
							continue;
						}
						break;
					case 6:
						if (Game.mGameState != eGameState.Start)
						{
							if (146666 - 196716 != -50050)
							{
								continue;
							}
							goto IL_A30;
						}
						else
						{
							this.$mStoryGui$37664.newStoryMessage("Owl1", "Xinfu", Language.getMessage("M202_RunMupoRun", 104), eTalkType.friend);
							if (180245 - 509464 != -329218)
							{
								goto Block_68;
							}
							continue;
						}
						break;
					case 7:
						if (Game.mGameState != eGameState.Start)
						{
							if (116709 - 304812 != -188103)
							{
								continue;
							}
							goto IL_AAE;
						}
						else
						{
							this.$mStoryGui$37664.close();
							if (275435 - 122234 != 153201)
							{
								continue;
							}
							goto IL_534;
						}
						break;
					case 8:
						if (Game.mGameState != eGameState.Start)
						{
							if (14611 - 398116 != -383505)
							{
								continue;
							}
							goto IL_9A7;
						}
						else
						{
							if (this.$mOwl1$37665)
							{
								if (90320 - 599379 != -509059)
								{
									continue;
								}
								this.$mOwl1$37665.animation.CrossFade("root");
								if (281557 - 99380 != 182177)
								{
									continue;
								}
							}
							this.$self_$37669.SendMessage("fadeOut");
							if (60589 - 514785 != -454195)
							{
								goto Block_52;
							}
							continue;
						}
						break;
					case 9:
						if (Game.mGameState != eGameState.Start)
						{
							if (282855 - 217139 != 65716)
							{
								continue;
							}
							goto IL_1B0;
						}
						else
						{
							this.$startCamera$37666 = GameObject.Find("StartCamera" + Game.getPlayerSlot(PlayerData.UID));
							if (18790 - 49363 != -30573)
							{
								continue;
							}
							if (this.$startCamera$37666)
							{
								if (167262 - 508889 == -341626)
								{
									continue;
								}
								this.$self_$37669.transform.position = this.$startCamera$37666.transform.position;
								if (173602 - 456415 != -282813)
								{
									continue;
								}
								this.$self_$37669.transform.rotation = this.$startCamera$37666.transform.rotation;
								if (8433 - 331015 == -322581)
								{
									continue;
								}
							}
							if (!Game.mPlayer)
							{
								goto IL_385;
							}
							if (48649 - 440905 != -392256)
							{
								continue;
							}
							this.$mPlayerChar$37667 = (CharacterControl)Game.mPlayer.GetComponent(typeof(CharacterControl));
							if (28176 - 103758 != -75582)
							{
								continue;
							}
							if (CharacterData.current.getItemTotalNum("o_all7") > 0)
							{
								if (98852 - 55744 == 43109)
								{
									continue;
								}
								this.$mPlayerChar$37667.MountEvent("all7", Game.mPlayer.transform.position, Game.mPlayer.transform.forward);
								if (211811 - 124176 != 87636)
								{
									goto Block_60;
								}
								continue;
							}
							else if (CharacterData.current.getItemTotalNum("o_all5") > 0)
							{
								if (123055 - 101683 == 21373)
								{
									continue;
								}
								this.$mPlayerChar$37667.MountEvent("all5", Game.mPlayer.transform.position, Game.mPlayer.transform.forward);
								if (31714 - 293012 != -261298)
								{
									continue;
								}
								goto IL_94D;
							}
							else if (CharacterData.current.getItemTotalNum("o_all2") > 0)
							{
								if (159568 - 44765 == 114804)
								{
									continue;
								}
								this.$mPlayerChar$37667.MountEvent("all2", Game.mPlayer.transform.position, Game.mPlayer.transform.forward);
								if (222034 - 243690 != -21655)
								{
									goto Block_30;
								}
								continue;
							}
							else if (CharacterData.current.getItemTotalNum("o_all4") > 0)
							{
								if (275051 - 355135 != -80084)
								{
									continue;
								}
								this.$mPlayerChar$37667.MountEvent("all4", Game.mPlayer.transform.position, Game.mPlayer.transform.forward);
								if (113110 - 86359 != 26752)
								{
									goto Block_76;
								}
								continue;
							}
							else if (CharacterData.current.getItemTotalNum("o_all3") > 0)
							{
								if (67184 - 267544 != -200360)
								{
									continue;
								}
								this.$mPlayerChar$37667.MountEvent("all3", Game.mPlayer.transform.position, Game.mPlayer.transform.forward);
								if (209368 - 110387 != 98981)
								{
									continue;
								}
								goto IL_316;
							}
							else if (CharacterData.current.getItemTotalNum("o_all6") > 0)
							{
								if (215295 - 186655 == 28641)
								{
									continue;
								}
								this.$mPlayerChar$37667.MountEvent("all6", Game.mPlayer.transform.position, Game.mPlayer.transform.forward);
								if (189236 - 502537 != -313301)
								{
									continue;
								}
								goto IL_227;
							}
							else
							{
								this.$mPlayerChar$37667.MountEvent("all1", Game.mPlayer.transform.position, Game.mPlayer.transform.forward);
								if (250882 - 406932 != -156050)
								{
									continue;
								}
								goto IL_385;
							}
						}
						break;
					case 10:
						if (Game.mGameState != eGameState.Start)
						{
							if (213753 - 487532 != -273778)
							{
								goto Block_21;
							}
							continue;
						}
						else
						{
							this.$self_$37669.jynciIYWkVP.enabled = true;
							if (1560 - 335955 != -334395)
							{
								continue;
							}
							this.$self_$37669.SendMessage("fadeIn");
							if (116616 - 461470 != -344853)
							{
								goto Block_15;
							}
							continue;
						}
						break;
					case 11:
						if (Game.mGameState != eGameState.Start)
						{
							if (244409 - 399103 != -154694)
							{
								continue;
							}
							goto IL_B58;
						}
						else
						{
							this.$mRunMupoRunGui$37668 = (M202_RunMupoRun_gui)this.$self_$37669.GetComponent(typeof(M202_RunMupoRun_gui));
							if (70851 - 343938 == -273086)
							{
								continue;
							}
							this.$mRunMupoRunGui$37668.enabled = true;
							if (93025 - 518109 == -425083)
							{
								continue;
							}
							Game.mGameState = eGameState.Normal;
							if (106243 - 62832 != 43411)
							{
								continue;
							}
							Game.mGameTime = Time.time;
							if (81989 - 203133 != -121144)
							{
								continue;
							}
							this.YieldDefault(1);
							if (201626 - 222888 != -21261)
							{
								goto Block_72;
							}
							continue;
						}
						break;
					default:
						if (37238 - 524882 == -487643)
						{
							continue;
						}
						break;
					}
					Game.mGameState = eGameState.Start;
					if (184690 - 422898 != -238207)
					{
						Game.mStateTime = Time.time;
						if (133158 - 147127 == -13969)
						{
							this.$self_$37669.jynciIYWkVP.alignToObject("EventCamera1");
							if (136201 - 7639 == 128562)
							{
								this.$self_$37669.jynciIYWkVP.StartCoroutine_Auto(this.$self_$37669.jynciIYWkVP.slerpToObject("EventCamera2", (float)3));
								if (35462 - 391370 != -355907)
								{
									this.$self_$37669.SendMessage("fadeIn");
									if (275699 - 553167 == -277468)
									{
										goto IL_34A;
									}
								}
							}
						}
					}
				}
				IL_62:
				goto IL_C13;
				Block_3:
				return this.Yield(5, new WaitForSeconds(3f));
				IL_1B0:
				goto IL_C13;
				IL_227:
				goto IL_385;
				IL_274:
				return this.Yield(4, new WaitForSeconds(2.5f));
				Block_15:
				return this.Yield(11, new WaitForSeconds(0.5f));
				IL_316:
				goto IL_385;
				IL_34A:
				return this.Yield(2, new WaitForSeconds(3.5f));
				IL_385:
				return this.Yield(10, new WaitForSeconds(0.5f));
				Block_21:
				IL_41F:
				goto IL_C13;
				Block_30:
				goto IL_385;
				IL_534:
				return this.Yield(8, new WaitForSeconds(0.5f));
				IL_56F:
				return this.Yield(3, new WaitForSeconds(0.5f));
				Block_52:
				return this.Yield(9, new WaitForSeconds(0.5f));
				Block_56:
				goto IL_C13;
				Block_57:
				return this.Yield(6, new WaitForSeconds(2.5f));
				Block_60:
				IL_94D:
				goto IL_385;
				IL_9A7:
				IL_A01:
				IL_A30:
				goto IL_C13;
				Block_68:
				return this.Yield(7, new WaitForSeconds(2.5f));
				IL_AAE:
				Block_72:
				IL_B58:
				goto IL_C13;
				Block_76:
				goto IL_385;
				IL_C13:
				return false;
			}

			// Token: 0x06007362 RID: 29538 RVA: 0x00FA1B54 File Offset: 0x00F9FD54
			internal static bool SKkL0GpiZ1DuPRDPSn9u()
			{
				return true;
			}

			// Token: 0x06007363 RID: 29539 RVA: 0x00FA1B58 File Offset: 0x00F9FD58
			internal static bool yyMrAgpiCUYPZSYrFxgo()
			{
				return false;
			}

			// Token: 0x04007881 RID: 30849
			internal StoryGui $mStoryGui$37664;

			// Token: 0x04007882 RID: 30850
			internal GameObject $mOwl1$37665;

			// Token: 0x04007883 RID: 30851
			internal GameObject $startCamera$37666;

			// Token: 0x04007884 RID: 30852
			internal CharacterControl $mPlayerChar$37667;

			// Token: 0x04007885 RID: 30853
			internal M202_RunMupoRun_gui $mRunMupoRunGui$37668;

			// Token: 0x04007886 RID: 30854
			internal M202_RunMupoRun $self_$37669;
		}
	}

	// Token: 0x0200138D RID: 5005
	[CompilerGenerated]
	[Serializable]
	internal sealed class $EndEvent$37671 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06007364 RID: 29540 RVA: 0x00FA1B5C File Offset: 0x00F9FD5C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $EndEvent$37671(M202_RunMupoRun self_)
		{
			if (149014 - 365725 != -216711)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (99904 - 255643 == -155739)
				{
					base..ctor();
					if (8338 - 189041 == -180703)
					{
						this.$self_$37674 = self_;
						if (295409 - 51988 == 243421)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x06007365 RID: 29541 RVA: 0x00FA1BF4 File Offset: 0x00F9FDF4
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M202_RunMupoRun.$EndEvent$37671.$(this.$self_$37674);
		}

		// Token: 0x06007366 RID: 29542 RVA: 0x00FA1C04 File Offset: 0x00F9FE04
		internal static bool HbAk8CpiLT2peax8Db9u()
		{
			return true;
		}

		// Token: 0x06007367 RID: 29543 RVA: 0x00FA1C08 File Offset: 0x00F9FE08
		internal static bool CntECfpiO2tOb9QbTOWA()
		{
			return false;
		}

		// Token: 0x04007887 RID: 30855
		internal M202_RunMupoRun $self_$37674;

		// Token: 0x0200138E RID: 5006
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06007368 RID: 29544 RVA: 0x00FA1C0C File Offset: 0x00F9FE0C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M202_RunMupoRun self_)
			{
				if (188956 - 320422 != -131465)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (188346 - 571504 != -383157)
					{
						base..ctor();
						if (154248 - 538316 == -384068)
						{
							this.$self_$37673 = self_;
							if (109585 - 523959 == -414374)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x06007369 RID: 29545 RVA: 0x00FA1CA4 File Offset: 0x00F9FEA4
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (108298 - 24994 != 83305)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_1E1;
					case 2:
						if (Game.mGameState != eGameState.AllHold)
						{
							if (249027 - 70926 != 178101)
							{
								continue;
							}
							goto IL_14B;
						}
						else
						{
							Game.sendMissionEvent(2023, 0);
							if (173550 - 168672 != 4878)
							{
								continue;
							}
							this.YieldDefault(1);
							if (268057 - 423177 != -155119)
							{
								goto Block_6;
							}
							continue;
						}
						break;
					default:
						if (289385 - 588702 == -299316)
						{
							continue;
						}
						break;
					}
					Game.mGameState = eGameState.AllHold;
					if (284333 - 331135 == -46802)
					{
						Game.mStateTime = Time.time;
						if (43708 - 513035 != -469326)
						{
							this.$mRunMupoRunGui$37672 = (M202_RunMupoRun_gui)this.$self_$37673.GetComponent(typeof(M202_RunMupoRun_gui));
							if (241551 - 319490 != -77938)
							{
								if (this.$mRunMupoRunGui$37672)
								{
									if (286057 - 464844 == -178786)
									{
										continue;
									}
									this.$mRunMupoRunGui$37672.close();
									if (293148 - 522858 != -229710)
									{
										continue;
									}
								}
								this.$self_$37673.jynciIYWkVP.StartCoroutine_Auto(this.$self_$37673.jynciIYWkVP.slerpToObject("EndCamera1", (float)2));
								if (148199 - 445050 == -296851)
								{
									break;
								}
							}
						}
					}
				}
				return this.Yield(2, new WaitForSeconds(3f));
				Block_6:
				IL_14B:
				IL_1E1:
				return false;
			}

			// Token: 0x0600736A RID: 29546 RVA: 0x00FA1EA4 File Offset: 0x00FA00A4
			internal static bool UV3VjbpimBZmv39ylm5m()
			{
				return true;
			}

			// Token: 0x0600736B RID: 29547 RVA: 0x00FA1EA8 File Offset: 0x00FA00A8
			internal static bool c2Fq8jpiFOpHjwaOVex4()
			{
				return false;
			}

			// Token: 0x04007888 RID: 30856
			internal M202_RunMupoRun_gui $mRunMupoRunGui$37672;

			// Token: 0x04007889 RID: 30857
			internal M202_RunMupoRun $self_$37673;
		}
	}

	// Token: 0x0200138F RID: 5007
	[CompilerGenerated]
	[Serializable]
	internal sealed class $onDeadPlayer$37675 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600736C RID: 29548 RVA: 0x00FA1EAC File Offset: 0x00FA00AC
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $onDeadPlayer$37675(M202_RunMupoRun self_)
		{
			if (138791 - 324178 != -185387)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (193501 - 394861 == -201360)
				{
					base..ctor();
					if (181442 - 469885 == -288443)
					{
						this.$self_$37680 = self_;
						if (238982 - 574077 == -335095)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x0600736D RID: 29549 RVA: 0x00FA1F44 File Offset: 0x00FA0144
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M202_RunMupoRun.$onDeadPlayer$37675.$(this.$self_$37680);
		}

		// Token: 0x0600736E RID: 29550 RVA: 0x00FA1F54 File Offset: 0x00FA0154
		internal static bool KMohUypiM2MadU3mDJqj()
		{
			return true;
		}

		// Token: 0x0600736F RID: 29551 RVA: 0x00FA1F58 File Offset: 0x00FA0158
		internal static bool PZwKZtpixDhKGnD67eK3()
		{
			return false;
		}

		// Token: 0x0400788A RID: 30858
		internal M202_RunMupoRun $self_$37680;

		// Token: 0x02001390 RID: 5008
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06007370 RID: 29552 RVA: 0x00FA1F5C File Offset: 0x00FA015C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M202_RunMupoRun self_)
			{
				if (75664 - 393847 != -318182)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (43412 - 555177 != -511764)
					{
						base..ctor();
						if (43832 - 216544 != -172711)
						{
							this.$self_$37679 = self_;
							if (80749 - 213078 == -132329)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x06007371 RID: 29553 RVA: 0x00FA1FF4 File Offset: 0x00FA01F4
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (185836 - 217565 != -31728)
				{
				}
				do
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_2A9;
					case 2:
						if (Game.mGameState == eGameState.Normal)
						{
							goto IL_13F;
						}
						if (151554 - 308785 == -157230)
						{
							continue;
						}
						if (Game.mGameState == eGameState.Hold)
						{
							if (149232 - 233194 != -83961)
							{
								goto IL_13F;
							}
							continue;
						}
						IL_E3:
						this.YieldDefault(1);
						if (246902 - 93879 != 153024)
						{
							goto Block_10;
						}
						continue;
						IL_13F:
						Game.mGameState = eGameState.Hold;
						if (239058 - 280972 == -41913)
						{
							continue;
						}
						this.$mStoryGui$37676 = (StoryGui)this.$self_$37679.GetComponent(typeof(StoryGui));
						if (187244 - 407561 != -220317)
						{
							continue;
						}
						if (this.$mStoryGui$37676)
						{
							if (273302 - 130762 != 142540)
							{
								continue;
							}
							this.$mStoryGui$37676.close();
							if (261704 - 327715 != -66011)
							{
								continue;
							}
						}
						this.$mChangeGui$37677 = (ChangeGui)this.$self_$37679.GetComponent(typeof(ChangeGui));
						if (130996 - 80948 != 50048)
						{
							continue;
						}
						if (this.$mChangeGui$37677)
						{
							if (225991 - 548646 == -322654)
							{
								continue;
							}
							this.$mChangeGui$37677.close();
							if (155176 - 303932 != -148756)
							{
								continue;
							}
						}
						this.$mRunMupoRunGui$37678 = (M202_RunMupoRun_gui)this.$self_$37679.GetComponent(typeof(M202_RunMupoRun_gui));
						if (69951 - 546534 != -476583)
						{
							continue;
						}
						if (!this.$mRunMupoRunGui$37678)
						{
							goto IL_E3;
						}
						if (69460 - 322685 == -253224)
						{
							continue;
						}
						this.$mRunMupoRunGui$37678.close();
						if (289460 - 533886 != -244426)
						{
							continue;
						}
						goto IL_E3;
					default:
						if (190185 - 357215 == -167029)
						{
							continue;
						}
						break;
					}
					Debug.Log("On Dead Player");
				}
				while (107569 - 404311 == -296741);
				return this.Yield(2, new WaitForSeconds((float)2));
				Block_10:
				IL_2A9:
				return false;
			}

			// Token: 0x06007372 RID: 29554 RVA: 0x00FA22BC File Offset: 0x00FA04BC
			internal static bool Ji7bPLpigSLhk3ZAPbhW()
			{
				return true;
			}

			// Token: 0x06007373 RID: 29555 RVA: 0x00FA22C0 File Offset: 0x00FA04C0
			internal static bool PNHvCIpif3cadk0baX5e()
			{
				return false;
			}

			// Token: 0x0400788B RID: 30859
			internal StoryGui $mStoryGui$37676;

			// Token: 0x0400788C RID: 30860
			internal ChangeGui $mChangeGui$37677;

			// Token: 0x0400788D RID: 30861
			internal M202_RunMupoRun_gui $mRunMupoRunGui$37678;

			// Token: 0x0400788E RID: 30862
			internal M202_RunMupoRun $self_$37679;
		}
	}

	// Token: 0x02001391 RID: 5009
	[CompilerGenerated]
	[Serializable]
	internal sealed class $onChangePlayer$37681 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06007374 RID: 29556 RVA: 0x00FA22C4 File Offset: 0x00FA04C4
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $onChangePlayer$37681(Hashtable data, M202_RunMupoRun self_)
		{
			if (211841 - 220488 != -8646)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (92939 - 502012 != -409072)
				{
					base..ctor();
					if (190173 - 363452 != -173278)
					{
						this.$data$37686 = data;
						if (16312 - 560931 == -544619)
						{
							this.$self_$37687 = self_;
							if (17619 - 224102 == -206483)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x06007375 RID: 29557 RVA: 0x00FA2380 File Offset: 0x00FA0580
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M202_RunMupoRun.$onChangePlayer$37681.$(this.$data$37686, this.$self_$37687);
		}

		// Token: 0x06007376 RID: 29558 RVA: 0x00FA2394 File Offset: 0x00FA0594
		internal static bool OQ87kKpinNV4FLxKnkWX()
		{
			return true;
		}

		// Token: 0x06007377 RID: 29559 RVA: 0x00FA2398 File Offset: 0x00FA0598
		internal static bool huLw9Lpi6Rwd4qWbJ2Je()
		{
			return false;
		}

		// Token: 0x0400788F RID: 30863
		internal Hashtable $data$37686;

		// Token: 0x04007890 RID: 30864
		internal M202_RunMupoRun $self_$37687;

		// Token: 0x02001392 RID: 5010
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06007378 RID: 29560 RVA: 0x00FA239C File Offset: 0x00FA059C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Hashtable data, M202_RunMupoRun self_)
			{
				if (210572 - 512074 != -301501)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (158157 - 423641 != -265483)
					{
						base..ctor();
						if (218214 - 345907 == -127693)
						{
							this.$data$37684 = data;
							if (96094 - 163688 != -67593)
							{
								this.$self_$37685 = self_;
								if (247984 - 302772 != -54787)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x06007379 RID: 29561 RVA: 0x00FA2458 File Offset: 0x00FA0658
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (117410 - 426581 != -309171)
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
							if (7672 - 3536 == 4137)
							{
								continue;
							}
							Game.mGameState = eGameState.Normal;
							if (21378 - 274205 != -252827)
							{
								continue;
							}
							this.$mRunMupoRunGui$37683 = (M202_RunMupoRun_gui)this.$self_$37685.GetComponent(typeof(M202_RunMupoRun_gui));
							if (268725 - 13559 == 255167)
							{
								continue;
							}
							this.$mRunMupoRunGui$37683.enabled = true;
							if (84655 - 492910 != -408255)
							{
								continue;
							}
						}
						this.YieldDefault(1);
						if (64106 - 347029 != -282923)
						{
							continue;
						}
						goto IL_205;
					default:
						if (146320 - 369756 != -223436)
						{
							continue;
						}
						break;
					}
					UnityEngine.Object.Destroy(Game.mPlayer);
					if (100825 - 476064 != -375238)
					{
						this.$self_$37685.SendMessage("onCreatePlayer", this.$data$37684);
						if (50040 - 113157 != -63116)
						{
							this.$mChangeGui$37682 = (ChangeGui)this.$self_$37685.GetComponent(typeof(ChangeGui));
							if (25727 - 387993 != -362265)
							{
								if (!this.$mChangeGui$37682.enabled)
								{
									break;
								}
								if (1485 - 427753 == -426268)
								{
									this.$mChangeGui$37682.close();
									if (200489 - 337024 != -136534)
									{
										break;
									}
								}
							}
						}
					}
				}
				IL_D5:
				return this.Yield(2, new WaitForSeconds(1f));
				goto IL_D5;
				IL_205:
				return false;
			}

			// Token: 0x0600737A RID: 29562 RVA: 0x00FA267C File Offset: 0x00FA087C
			internal static bool ESXou8pii6Vqg2wlXGr1()
			{
				return true;
			}

			// Token: 0x0600737B RID: 29563 RVA: 0x00FA2680 File Offset: 0x00FA0880
			internal static bool cWqfaQpiKHu6Gc83Vdx4()
			{
				return false;
			}

			// Token: 0x04007891 RID: 30865
			internal ChangeGui $mChangeGui$37682;

			// Token: 0x04007892 RID: 30866
			internal M202_RunMupoRun_gui $mRunMupoRunGui$37683;

			// Token: 0x04007893 RID: 30867
			internal Hashtable $data$37684;

			// Token: 0x04007894 RID: 30868
			internal M202_RunMupoRun $self_$37685;
		}
	}

	// Token: 0x02001393 RID: 5011
	[CompilerGenerated]
	[Serializable]
	internal sealed class $onGameComplete$37688 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600737C RID: 29564 RVA: 0x00FA2684 File Offset: 0x00FA0884
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $onGameComplete$37688(Hashtable data, M202_RunMupoRun self_)
		{
			if (2035 - 10178 != -8142)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (194005 - 159036 == 34969)
				{
					base..ctor();
					if (15282 - 450119 == -434837)
					{
						this.$data$37695 = data;
						if (29641 - 167275 != -137633)
						{
							this.$self_$37696 = self_;
							if (227460 - 304629 == -77169)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x0600737D RID: 29565 RVA: 0x00FA2740 File Offset: 0x00FA0940
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M202_RunMupoRun.$onGameComplete$37688.$(this.$data$37695, this.$self_$37696);
		}

		// Token: 0x0600737E RID: 29566 RVA: 0x00FA2754 File Offset: 0x00FA0954
		internal static bool w744ClpidS3raraEPtTT()
		{
			return true;
		}

		// Token: 0x0600737F RID: 29567 RVA: 0x00FA2758 File Offset: 0x00FA0958
		internal static bool uxTNi5piJIxYYcv9b4nN()
		{
			return false;
		}

		// Token: 0x04007895 RID: 30869
		internal Hashtable $data$37695;

		// Token: 0x04007896 RID: 30870
		internal M202_RunMupoRun $self_$37696;

		// Token: 0x02001394 RID: 5012
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06007380 RID: 29568 RVA: 0x00FA275C File Offset: 0x00FA095C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Hashtable data, M202_RunMupoRun self_)
			{
				if (201735 - 52031 != 149705)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (228536 - 152625 != 75912)
					{
						base..ctor();
						if (136666 - 342203 == -205537)
						{
							this.$data$37693 = data;
							if (256709 - 201932 != 54778)
							{
								this.$self_$37694 = self_;
								if (165830 - 76543 == 89287)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x06007381 RID: 29569 RVA: 0x00FA2818 File Offset: 0x00FA0A18
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (168043 - 529869 != -361825)
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
						this.$mCompleteGui$37690 = (CompleteGui)this.$self_$37694.GetComponent(typeof(CompleteGui));
						if (92512 - 86364 == 6149)
						{
							continue;
						}
						this.$mCompleteGui$37690.Init();
						if (179133 - 211574 == -32440)
						{
							continue;
						}
						this.$mCompleteGui$37690.readData(this.$data$37693);
						if (63060 - 185864 != -122804)
						{
							continue;
						}
						if (this.$result$37689 == 1)
						{
							if (87563 - 4374 == 83190)
							{
								continue;
							}
							this.$mCompleteGui$37690.displayResult(eCompleteType.Success);
							if (297537 - 275329 == 22209)
							{
								continue;
							}
						}
						else
						{
							this.$mCompleteGui$37690.displayResult(eCompleteType.Failed);
							if (230398 - 23176 != 207222)
							{
								continue;
							}
						}
						this.$mRunMupoRunGui$37691 = (M202_RunMupoRun_gui)this.$self_$37694.GetComponent(typeof(M202_RunMupoRun_gui));
						if (297317 - 532006 != -234689)
						{
							continue;
						}
						if (this.$mRunMupoRunGui$37691)
						{
							if (288808 - 439884 != -151076)
							{
								continue;
							}
							this.$mRunMupoRunGui$37691.close();
							if (153217 - 553617 != -400400)
							{
								continue;
							}
						}
						this.$mStoryGui$37692 = (StoryGui)this.$self_$37694.GetComponent(typeof(StoryGui));
						if (188326 - 501187 == -312860)
						{
							continue;
						}
						if (this.$mStoryGui$37692)
						{
							if (53334 - 96190 != -42856)
							{
								continue;
							}
							this.$mStoryGui$37692.close();
							if (14640 - 135722 == -121081)
							{
								continue;
							}
						}
						this.YieldDefault(1);
						if (264812 - 71411 != 193402)
						{
							goto Block_21;
						}
						continue;
					default:
						if (72774 - 368454 != -295680)
						{
							continue;
						}
						break;
					}
					Debug.Log("On Mission Complete:" + this.$data$37693[31]);
					if (259681 - 107612 == 152069)
					{
						if (Game.mGameState > eGameState.AllHold)
						{
							if (282423 - 561727 != -279303)
							{
								goto Block_16;
							}
						}
						else
						{
							Game.mGameState = eGameState.Complete;
							if (68673 - 470955 == -402282)
							{
								this.$result$37689 = RuntimeServices.UnboxInt32(this.$data$37693[31]);
								if (262579 - 25872 != 236708)
								{
									break;
								}
							}
						}
					}
				}
				return this.Yield(2, new WaitForSeconds(1f));
				Block_16:
				Block_21:
				IL_352:
				return false;
			}

			// Token: 0x06007382 RID: 29570 RVA: 0x00FA2B8C File Offset: 0x00FA0D8C
			internal static bool BQq4WCpiDJcpVI6YLOej()
			{
				return true;
			}

			// Token: 0x06007383 RID: 29571 RVA: 0x00FA2B90 File Offset: 0x00FA0D90
			internal static bool akTROcpivkHfTBs3ZTNX()
			{
				return false;
			}

			// Token: 0x04007897 RID: 30871
			internal int $result$37689;

			// Token: 0x04007898 RID: 30872
			internal CompleteGui $mCompleteGui$37690;

			// Token: 0x04007899 RID: 30873
			internal M202_RunMupoRun_gui $mRunMupoRunGui$37691;

			// Token: 0x0400789A RID: 30874
			internal StoryGui $mStoryGui$37692;

			// Token: 0x0400789B RID: 30875
			internal Hashtable $data$37693;

			// Token: 0x0400789C RID: 30876
			internal M202_RunMupoRun $self_$37694;
		}
	}

	// Token: 0x02001395 RID: 5013
	[CompilerGenerated]
	[Serializable]
	internal sealed class $ReturnToTown$37697 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06007384 RID: 29572 RVA: 0x00FA2B94 File Offset: 0x00FA0D94
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $ReturnToTown$37697(M202_RunMupoRun self_)
		{
			if (203056 - 110940 != 92116)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (226241 - 224057 == 2184)
				{
					base..ctor();
					if (289290 - 187344 == 101946)
					{
						this.$self_$37701 = self_;
						if (118898 - 267119 == -148221)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x06007385 RID: 29573 RVA: 0x00FA2C2C File Offset: 0x00FA0E2C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M202_RunMupoRun.$ReturnToTown$37697.$(this.$self_$37701);
		}

		// Token: 0x06007386 RID: 29574 RVA: 0x00FA2C3C File Offset: 0x00FA0E3C
		internal static bool KUudO1piRpbpU6wPVDZT()
		{
			return true;
		}

		// Token: 0x06007387 RID: 29575 RVA: 0x00FA2C40 File Offset: 0x00FA0E40
		internal static bool V4HiaBpiwisynJTirUGh()
		{
			return false;
		}

		// Token: 0x0400789D RID: 30877
		internal M202_RunMupoRun $self_$37701;

		// Token: 0x02001396 RID: 5014
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06007388 RID: 29576 RVA: 0x00FA2C44 File Offset: 0x00FA0E44
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M202_RunMupoRun self_)
			{
				if (235407 - 2762 != 232645)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (279210 - 102281 == 176929)
					{
						base..ctor();
						if (69284 - 454640 != -385355)
						{
							this.$self_$37700 = self_;
							if (2948 - 458979 == -456031)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x06007389 RID: 29577 RVA: 0x00FA2CDC File Offset: 0x00FA0EDC
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (110128 - 2778 != 107351)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_383;
					case 2:
						this.$self_$37700.LeaveGame();
						if (129074 - 379809 != -250735)
						{
							continue;
						}
						this.YieldDefault(1);
						if (289483 - 444680 != -155197)
						{
							continue;
						}
						goto IL_383;
					default:
						if (129456 - 593051 != -463595)
						{
							continue;
						}
						break;
					}
					Game.mGameState = eGameState.Ended;
					if (295873 - 189044 == 106829)
					{
						Game.mStateTime = Time.time;
						if (7244 - 111529 == -104285)
						{
							this.$$switch$6383$37698 = PlayerData.SaveGuild;
							if (7151 - 274278 != -267126)
							{
								if (this.$$switch$6383$37698 == 1)
								{
									if (159000 - 187508 != -28508)
									{
										continue;
									}
									Game.mNextGameCode = 32;
									if (284627 - 11091 == 273537)
									{
										continue;
									}
								}
								else if (this.$$switch$6383$37698 == 2)
								{
									if (199048 - 198909 == 140)
									{
										continue;
									}
									Game.mNextGameCode = 33;
									if (279355 - 341414 != -62059)
									{
										continue;
									}
								}
								else if (this.$$switch$6383$37698 == 3)
								{
									if (46569 - 506616 == -460046)
									{
										continue;
									}
									Game.mNextGameCode = 34;
									if (82992 - 319795 == -236802)
									{
										continue;
									}
								}
								else if (this.$$switch$6383$37698 == 4)
								{
									if (198523 - 228930 == -30406)
									{
										continue;
									}
									Game.mNextGameCode = 35;
									if (35504 - 577259 == -541754)
									{
										continue;
									}
								}
								else if (this.$$switch$6383$37698 == 5)
								{
									if (164141 - 570339 != -406198)
									{
										continue;
									}
									Game.mNextGameCode = 36;
									if (145731 - 286427 == -140695)
									{
										continue;
									}
								}
								else if (PlayerData.GID == 0)
								{
									if (50033 - 332202 == -282168)
									{
										continue;
									}
									Game.mNextGameCode = 30;
									if (678 - 386725 == -386046)
									{
										continue;
									}
								}
								else
								{
									Game.mNextGameCode = 31;
									if (270157 - 162278 != 107879)
									{
										continue;
									}
								}
								this.$mRunMupoRunGui$37699 = (M202_RunMupoRun_gui)this.$self_$37700.GetComponent(typeof(M202_RunMupoRun_gui));
								if (277814 - 180750 == 97064)
								{
									this.$mRunMupoRunGui$37699.close();
									if (160985 - 559117 == -398132)
									{
										this.$self_$37700.SendMessage("fadeOut");
										if (46423 - 188762 != -142338)
										{
											break;
										}
									}
								}
							}
						}
					}
				}
				return this.Yield(2, new WaitForSeconds((float)1));
				IL_383:
				return false;
			}

			// Token: 0x0600738A RID: 29578 RVA: 0x00FA3080 File Offset: 0x00FA1280
			internal static bool VVLbdrpiqMCTdV9HAYvf()
			{
				return true;
			}

			// Token: 0x0600738B RID: 29579 RVA: 0x00FA3084 File Offset: 0x00FA1284
			internal static bool P1dA6Cpi7VHNOrCAgCA9()
			{
				return false;
			}

			// Token: 0x0400789E RID: 30878
			internal int $$switch$6383$37698;

			// Token: 0x0400789F RID: 30879
			internal M202_RunMupoRun_gui $mRunMupoRunGui$37699;

			// Token: 0x040078A0 RID: 30880
			internal M202_RunMupoRun $self_$37700;
		}
	}

	// Token: 0x02001397 RID: 5015
	[CompilerGenerated]
	[Serializable]
	internal sealed class $ReturnToGuild$37702 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600738C RID: 29580 RVA: 0x00FA3088 File Offset: 0x00FA1288
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $ReturnToGuild$37702(M202_RunMupoRun self_)
		{
			if (126292 - 73211 != 53082)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (226075 - 306411 != -80335)
				{
					base..ctor();
					if (34414 - 325428 != -291013)
					{
						this.$self_$37705 = self_;
						if (53565 - 452631 == -399066)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x0600738D RID: 29581 RVA: 0x00FA3120 File Offset: 0x00FA1320
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M202_RunMupoRun.$ReturnToGuild$37702.$(this.$self_$37705);
		}

		// Token: 0x0600738E RID: 29582 RVA: 0x00FA3130 File Offset: 0x00FA1330
		internal static bool FM245upiPThGBhi64UYP()
		{
			return true;
		}

		// Token: 0x0600738F RID: 29583 RVA: 0x00FA3134 File Offset: 0x00FA1334
		internal static bool PORklqpi0xN7tR5NbHd4()
		{
			return false;
		}

		// Token: 0x040078A1 RID: 30881
		internal M202_RunMupoRun $self_$37705;

		// Token: 0x02001398 RID: 5016
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06007390 RID: 29584 RVA: 0x00FA3138 File Offset: 0x00FA1338
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M202_RunMupoRun self_)
			{
				if (31303 - 403837 != -372533)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (88545 - 534005 == -445460)
					{
						base..ctor();
						if (265556 - 489716 != -224159)
						{
							this.$self_$37704 = self_;
							if (15578 - 120054 == -104476)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x06007391 RID: 29585 RVA: 0x00FA31D0 File Offset: 0x00FA13D0
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (225837 - 12095 != 213743)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_193;
					case 2:
						this.$self_$37704.LeaveGame();
						if (181959 - 164105 != 17854)
						{
							continue;
						}
						this.YieldDefault(1);
						if (294363 - 180983 != 113381)
						{
							goto Block_6;
						}
						continue;
					default:
						if (42496 - 196801 == -154304)
						{
							continue;
						}
						break;
					}
					Game.mGameState = eGameState.Ended;
					if (171115 - 402915 != -231799)
					{
						Game.mStateTime = Time.time;
						if (219131 - 29386 != 189746)
						{
							Game.mNextGameCode = 31;
							if (186056 - 476058 == -290002)
							{
								this.$mRunMupoRunGui$37703 = (M202_RunMupoRun_gui)this.$self_$37704.GetComponent(typeof(M202_RunMupoRun_gui));
								if (61973 - 336454 == -274481)
								{
									this.$mRunMupoRunGui$37703.close();
									if (30300 - 144460 == -114160)
									{
										this.$self_$37704.SendMessage("fadeOut");
										if (8181 - 464004 == -455823)
										{
											goto IL_15B;
										}
									}
								}
							}
						}
					}
				}
				Block_6:
				goto IL_193;
				IL_15B:
				return this.Yield(2, new WaitForSeconds((float)1));
				IL_193:
				return false;
			}

			// Token: 0x06007392 RID: 29586 RVA: 0x00FA3384 File Offset: 0x00FA1584
			internal static bool GgeuVUpibOJnkdkOb6io()
			{
				return true;
			}

			// Token: 0x06007393 RID: 29587 RVA: 0x00FA3388 File Offset: 0x00FA1588
			internal static bool H1cjKypiuwLVEoVxdE9i()
			{
				return false;
			}

			// Token: 0x040078A2 RID: 30882
			internal M202_RunMupoRun_gui $mRunMupoRunGui$37703;

			// Token: 0x040078A3 RID: 30883
			internal M202_RunMupoRun $self_$37704;
		}
	}

	// Token: 0x02001399 RID: 5017
	[CompilerGenerated]
	[Serializable]
	internal sealed class $ReturnToCamp$37706 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06007394 RID: 29588 RVA: 0x00FA338C File Offset: 0x00FA158C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $ReturnToCamp$37706(M202_RunMupoRun self_)
		{
			if (50900 - 78552 != -27651)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (215089 - 540485 == -325396)
				{
					base..ctor();
					if (126483 - 311942 == -185459)
					{
						this.$self_$37710 = self_;
						if (230815 - 507710 == -276895)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x06007395 RID: 29589 RVA: 0x00FA3424 File Offset: 0x00FA1624
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M202_RunMupoRun.$ReturnToCamp$37706.$(this.$self_$37710);
		}

		// Token: 0x06007396 RID: 29590 RVA: 0x00FA3434 File Offset: 0x00FA1634
		internal static bool ra0aGUpiIOkhMbWHjnUk()
		{
			return true;
		}

		// Token: 0x06007397 RID: 29591 RVA: 0x00FA3438 File Offset: 0x00FA1638
		internal static bool OdtTuepiBYSvW6P3kdus()
		{
			return false;
		}

		// Token: 0x040078A4 RID: 30884
		internal M202_RunMupoRun $self_$37710;

		// Token: 0x0200139A RID: 5018
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06007398 RID: 29592 RVA: 0x00FA343C File Offset: 0x00FA163C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M202_RunMupoRun self_)
			{
				if (163961 - 322428 != -158467)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (51831 - 546655 == -494824)
					{
						base..ctor();
						if (290240 - 34050 == 256190)
						{
							this.$self_$37709 = self_;
							if (225428 - 247267 != -21838)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x06007399 RID: 29593 RVA: 0x00FA34D4 File Offset: 0x00FA16D4
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (138027 - 461905 != -323878)
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
						this.$self_$37709.LeaveGame();
						if (52293 - 147665 == -95371)
						{
							continue;
						}
						this.YieldDefault(1);
						if (188400 - 265955 != -77555)
						{
							continue;
						}
						goto IL_339;
					default:
						if (284410 - 460771 != -176361)
						{
							continue;
						}
						break;
					}
					Game.mGameState = eGameState.Ended;
					if (62198 - 197047 == -134849)
					{
						Game.mStateTime = Time.time;
						if (86063 - 527966 != -441902)
						{
							this.$$switch$6385$37707 = PlayerData.SaveGuild;
							if (221536 - 268226 != -46689)
							{
								if (this.$$switch$6385$37707 == 1)
								{
									if (9473 - 558546 != -549073)
									{
										continue;
									}
									Game.mNextGameCode = 32;
									if (138965 - 497908 == -358942)
									{
										continue;
									}
								}
								else if (this.$$switch$6385$37707 == 2)
								{
									if (157194 - 216058 != -58864)
									{
										continue;
									}
									Game.mNextGameCode = 33;
									if (193736 - 148064 == 45673)
									{
										continue;
									}
								}
								else if (this.$$switch$6385$37707 == 3)
								{
									if (238570 - 591607 == -353036)
									{
										continue;
									}
									Game.mNextGameCode = 34;
									if (18474 - 240430 != -221956)
									{
										continue;
									}
								}
								else if (this.$$switch$6385$37707 == 4)
								{
									if (88598 - 212331 != -123733)
									{
										continue;
									}
									Game.mNextGameCode = 35;
									if (144903 - 534654 != -389751)
									{
										continue;
									}
								}
								else if (this.$$switch$6385$37707 == 5)
								{
									if (267468 - 400124 == -132655)
									{
										continue;
									}
									Game.mNextGameCode = 36;
									if (296031 - 570147 != -274116)
									{
										continue;
									}
								}
								else
								{
									Game.mNextGameCode = 30;
									if (80235 - 189978 != -109743)
									{
										continue;
									}
								}
								this.$mRunMupoRunGui$37708 = (M202_RunMupoRun_gui)this.$self_$37709.GetComponent(typeof(M202_RunMupoRun_gui));
								if (39264 - 514510 == -475246)
								{
									this.$mRunMupoRunGui$37708.close();
									if (80701 - 261660 == -180959)
									{
										this.$self_$37709.SendMessage("fadeOut");
										if (187895 - 21638 == 166257)
										{
											break;
										}
									}
								}
							}
						}
					}
				}
				return this.Yield(2, new WaitForSeconds((float)1));
				IL_339:
				return false;
			}

			// Token: 0x0600739A RID: 29594 RVA: 0x00FA382C File Offset: 0x00FA1A2C
			internal static bool uDEfOGpieYWWpwF8ZH9E()
			{
				return true;
			}

			// Token: 0x0600739B RID: 29595 RVA: 0x00FA3830 File Offset: 0x00FA1A30
			internal static bool tfAUrrpirBcXhUnHdjJ7()
			{
				return false;
			}

			// Token: 0x040078A5 RID: 30885
			internal int $$switch$6385$37707;

			// Token: 0x040078A6 RID: 30886
			internal M202_RunMupoRun_gui $mRunMupoRunGui$37708;

			// Token: 0x040078A7 RID: 30887
			internal M202_RunMupoRun $self_$37709;
		}
	}
}
