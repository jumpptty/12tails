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

// Token: 0x020013F6 RID: 5110
[Serializable]
public class M207_TroublingGiant : MonoBehaviour
{
	// Token: 0x06007602 RID: 30210 RVA: 0x00FD46D0 File Offset: 0x00FD28D0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public M207_TroublingGiant()
	{
		LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
		base..ctor();
	}

	// Token: 0x06007603 RID: 30211 RVA: 0x00FD46E0 File Offset: 0x00FD28E0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Awake()
	{
		if (242483 - 514127 != -271644)
		{
		}
		for (;;)
		{
			Game.mGameState = eGameState.Init;
			if (295452 - 244455 != 50998)
			{
				Game.mGameType = 4;
				if (54002 - 89558 != -35555)
				{
					if (Chat.Initialized)
					{
						if (31949 - 369248 == -337298)
						{
							continue;
						}
						Chat.ChatDisplay.Clear();
						if (5128 - 7500 == -2371)
						{
							continue;
						}
					}
					else
					{
						Chat.Init();
						if (20094 - 51680 != -31586)
						{
							continue;
						}
					}
					this.MZCcjEdjkqU = (Texture)Resources.Load("GameGui/Title/chapterComplete", typeof(Texture));
					if (201107 - 351883 == -150776)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06007604 RID: 30212 RVA: 0x00FD4800 File Offset: 0x00FD2A00
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Start()
	{
		if (101899 - 127652 != -25753)
		{
		}
		for (;;)
		{
			if (PhotonClient.IsInitialized())
			{
				if (72346 - 474552 != -402205)
				{
					if (Game.mNextGameCode != 207)
					{
						break;
					}
					if (281173 - 116210 != 164964)
					{
						Game.nextGame();
						if (138720 - 529277 != -390556)
						{
							Game.mGameCode = 207;
							if (207692 - 133450 != 74243)
							{
								Game.mGameType = 4;
								if (216033 - 491380 != -275346)
								{
									Game.mGameTime = Time.time;
									if (206312 - 455981 != -249668)
									{
										Game.mGameScore = 0;
										if (201506 - 280993 != -79486)
										{
											Game.mGameMana = 0;
											if (206244 - 364208 == -157964)
											{
												Game.canUseItem = MissionData.getAllowItem(Game.mGameCode);
												if (88298 - 43681 == 44617)
												{
													Game.canUseMount = MissionData.getAllowMount(Game.mGameCode);
													if (277856 - 261492 == 16364)
													{
														Game.canChangeChar = MissionData.getAllowChange(Game.mGameCode);
														if (151676 - 433635 != -281958)
														{
															Game.canRespawn = MissionData.getAllowRespawn(Game.mGameCode);
															if (52819 - 521828 != -469008)
															{
																Game.canUseCoin = MissionData.getAllowCoin(Game.mGameCode);
																if (85022 - 564459 != -479436)
																{
																	this.EBdcjUGGMxW = (PlayerCameraControl)this.GetComponent(typeof(PlayerCameraControl));
																	if (21552 - 114869 != -93316)
																	{
																		this.EBdcjUGGMxW.enabled = false;
																		if (228809 - 565395 != -336585)
																		{
																			this.USMcjwuQVqa = PhotonClient.Connection;
																			if (65188 - 575634 == -510446)
																			{
																				PhotonClient.ActorNrList.Clear();
																				if (95884 - 233738 == -137854)
																				{
																					this.InitGame();
																					if (92477 - 333238 != -240760)
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
			else
			{
				Debug.Log("Not Connected");
				if (206097 - 415408 != -209310)
				{
					Game.mGameType = 99;
					if (71729 - 238940 != -167210)
					{
						this.EBdcjUGGMxW = (PlayerCameraControl)this.GetComponent(typeof(PlayerCameraControl));
						if (130921 - 596389 != -465467)
						{
							this.EBdcjUGGMxW.enabled = false;
							if (7949 - 401547 != -393597)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x06007605 RID: 30213 RVA: 0x00FD4B84 File Offset: 0x00FD2D84
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void FixedUpdate()
	{
		if (192196 - 484616 != -292420)
		{
		}
		for (;;)
		{
			if (this.USMcjwuQVqa == null)
			{
				if (37314 - 424295 != -386980)
				{
					break;
				}
			}
			else
			{
				eGameState mGameState = Game.mGameState;
				if (184740 - 134136 != 50605)
				{
					if (mGameState == eGameState.Init)
					{
						if (45088 - 342397 != -297309)
						{
							continue;
						}
						AudioListener.volume = 0.1f * (float)Game.volume;
						if (211056 - 222776 == -11719)
						{
							continue;
						}
					}
					else if (mGameState == eGameState.Setup)
					{
						if (174766 - 565026 == -390259)
						{
							continue;
						}
					}
					else
					{
						if (mGameState != eGameState.Ready)
						{
							if (mGameState == eGameState.Start)
							{
								if (264180 - 46779 != 217401)
								{
									continue;
								}
							}
							else if (mGameState == eGameState.Normal)
							{
								if (210172 - 99656 != 110516)
								{
									continue;
								}
							}
							else if (mGameState == eGameState.Hold)
							{
								if (165456 - 585361 != -419905)
								{
									continue;
								}
							}
							else if (mGameState == eGameState.AllHold)
							{
								if (275886 - 307722 != -31835)
								{
									goto IL_70;
								}
								continue;
							}
							else
							{
								if (mGameState != eGameState.Ended)
								{
									goto IL_70;
								}
								if (85358 - 450906 != -365548)
								{
									continue;
								}
								goto IL_70;
							}
							IL_23C:
							if (Game.music != 0)
							{
								if (243625 - 465854 != -222229)
								{
									continue;
								}
								if (!this.audio.isPlaying)
								{
									if (208799 - 211160 == -2360)
									{
										continue;
									}
									this.audio.Play();
									if (18853 - 462146 != -443293)
									{
										continue;
									}
								}
							}
							if (this.audio.volume < 0.1f * (float)Game.music)
							{
								if (5773 - 375177 == -369403)
								{
									continue;
								}
								this.audio.volume = this.audio.volume + Time.deltaTime;
								if (134229 - 66774 == 67456)
								{
									continue;
								}
							}
							else
							{
								this.audio.volume = Mathf.Clamp01(0.1f * (float)Game.music);
								if (232570 - 531377 == -298806)
								{
									continue;
								}
							}
							goto IL_70;
							goto IL_23C;
						}
						if (90782 - 477277 != -386495)
						{
							continue;
						}
					}
					IL_70:
					if (this.S2YcjBN7gWc)
					{
						if (232541 - 133201 == 99341)
						{
							continue;
						}
						if (this.K8pcj0B6eUy)
						{
							if (192309 - 59477 != 132832)
							{
								continue;
							}
							if (this.BA4cjPB4LEs >= 1)
							{
								if (73807 - 183257 != -109450)
								{
									continue;
								}
								if (this.BA4cjPB4LEs <= 3)
								{
									if (22833 - 564627 == -541793)
									{
										continue;
									}
									Vector3 vector = Vector3.zero;
									if (175983 - 236623 == -60639)
									{
										continue;
									}
									int ba4cjPB4LEs = this.BA4cjPB4LEs;
									if (88930 - 443788 != -354858)
									{
										continue;
									}
									if (ba4cjPB4LEs == 1)
									{
										if (26698 - 165228 == -138529)
										{
											continue;
										}
										if (this.nXwcj8b5d5H)
										{
											if (236677 - 367151 == -130473)
											{
												continue;
											}
											vector = this.nXwcj8b5d5H.transform.position;
											if (211164 - 474273 == -263108)
											{
												continue;
											}
										}
									}
									else if (ba4cjPB4LEs == 2)
									{
										if (49645 - 43484 == 6162)
										{
											continue;
										}
										if (this.ww8cjiZBGBm)
										{
											if (203519 - 261953 == -58433)
											{
												continue;
											}
											vector = this.ww8cjiZBGBm.transform.position;
											if (120753 - 337708 == -216954)
											{
												continue;
											}
										}
									}
									else if (ba4cjPB4LEs == 3)
									{
										if (134815 - 178494 != -43679)
										{
											continue;
										}
										if (this.llKcjDsGd5x)
										{
											if (228004 - 541703 == -313698)
											{
												continue;
											}
											vector = this.llKcjDsGd5x.transform.position;
											if (1502 - 150866 != -149364)
											{
												continue;
											}
										}
									}
									if (!(vector != Vector3.zero))
									{
										break;
									}
									if (237784 - 325651 != -87867)
									{
										continue;
									}
									Vector3 vector2 = global::Math.vFlat(vector - this.S2YcjBN7gWc.transform.position);
									if (285007 - 299362 == -14354)
									{
										continue;
									}
									if (vector2.sqrMagnitude < (float)4)
									{
										if (174938 - 450685 == -275746)
										{
											continue;
										}
										this.BA4cjPB4LEs++;
										if (220755 - 54492 != 166264)
										{
											break;
										}
										continue;
									}
									else
									{
										this.S2YcjBN7gWc.animation.CrossFade("walk", 0.5f);
										if (17951 - 429364 != -411413)
										{
											continue;
										}
										this.S2YcjBN7gWc.transform.rotation = Quaternion.Slerp(this.S2YcjBN7gWc.transform.rotation, Quaternion.LookRotation(vector2.normalized), Time.deltaTime);
										if (66044 - 439954 != -373910)
										{
											continue;
										}
										this.K8pcj0B6eUy.Move(((float)2 * vector2.normalized - Vector3.up) * Time.deltaTime);
										if (232593 - 80755 != 151838)
										{
											continue;
										}
										break;
									}
								}
							}
						}
					}
					if (this.BA4cjPB4LEs != 4)
					{
						break;
					}
					if (114586 - 266577 != -151990)
					{
						this.S2YcjBN7gWc.animation.CrossFade("root", 0.5f);
						if (258230 - 308857 == -50627)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x06007606 RID: 30214 RVA: 0x00FD52B0 File Offset: 0x00FD34B0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void OnGUI()
	{
		if (246477 - 31769 != 214708)
		{
		}
		for (;;)
		{
			eGameState mGameState = Game.mGameState;
			if (67795 - 279472 != -211676)
			{
				if (mGameState != eGameState.Complete)
				{
					break;
				}
				if (273293 - 3289 != 270005)
				{
					if (!this.MZCcjEdjkqU)
					{
						break;
					}
					if (221429 - 589890 == -368461)
					{
						GUI.matrix = Matrix4x4.TRS(Vector3.zero, Quaternion.identity, new Vector3((float)Screen.height / 1024f, (float)Screen.height / 1024f, (float)1));
						if (92418 - 195044 == -102626)
						{
							int num = 1024 * Screen.width / Screen.height;
							if (87165 - 556403 == -469238)
							{
								float num2 = (float)Screen.height / 1024f;
								if (150832 - 466523 != -315690)
								{
									GUI.depth = 1;
									if (163786 - 388950 != -225163)
									{
										float a = Mathf.SmoothStep((float)0, (float)1, (float)2 * (Time.time - this.FYMcjSPBsMO));
										if (267409 - 270008 != -2598)
										{
											Color color = GUI.color;
											if (273129 - 323215 != -50085)
											{
												float num3 = color.a = a;
												if (192469 - 518721 != -326251 && 68551 - 268902 != -200350)
												{
													GUI.color = color;
													if (102821 - 356043 != -253221 && 4331 - 435792 != -431460)
													{
														float num4 = Mathf.SmoothStep(1.5f, (float)1, Time.time - this.FYMcjSPBsMO);
														if (187574 - 117880 != 69695)
														{
															GUI.DrawTexture(new Rect(0.5f * (float)num - 0.5f * (float)this.MZCcjEdjkqU.width * num4, (float)530 - 0.5f * (float)this.MZCcjEdjkqU.height * num4, (float)this.MZCcjEdjkqU.width * num4, (float)this.MZCcjEdjkqU.height * num4), this.MZCcjEdjkqU);
															if (169317 - 420241 != -250923)
															{
																int num5 = 1;
																if (27295 - 210241 == -182946)
																{
																	Color color2 = GUI.color;
																	if (204735 - 553542 == -348807)
																	{
																		float num6 = color2.a = (float)num5;
																		if (132131 - 280326 != -148194)
																		{
																			if (288829 - 306024 == -17195)
																			{
																				GUI.color = color2;
																				if (82968 - 31246 != 51723 && 145559 - 221757 != -76197)
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

	// Token: 0x06007607 RID: 30215 RVA: 0x00FD5670 File Offset: 0x00FD3870
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onGameEvent(Hashtable data)
	{
		if (260350 - 231221 != 29129)
		{
		}
		for (;;)
		{
			if (Game.mGameState > eGameState.AllHold)
			{
				if (14480 - 303079 != -288598)
				{
					break;
				}
			}
			else
			{
				int num = RuntimeServices.UnboxInt32(data[141]);
				if (136777 - 383126 == -246349)
				{
					int num2 = RuntimeServices.UnboxInt32(data[145]);
					if (193511 - 256688 == -63177)
					{
						int num3 = RuntimeServices.UnboxInt32(data[43]);
						if (144024 - 505434 != -361409)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x06007608 RID: 30216 RVA: 0x00FD5760 File Offset: 0x00FD3960
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void InitGame()
	{
		if (141124 - 315434 != -174309)
		{
		}
		for (;;)
		{
			Debug.Log("Initializing Mission");
			if (176112 - 315917 != -139804)
			{
				Time.timeScale = 1f;
				if (295985 - 97113 == 198872)
				{
					this.S2YcjBN7gWc = GameObject.Find("EarthGod");
					if (274445 - 337116 == -62671)
					{
						if (this.S2YcjBN7gWc)
						{
							if (89843 - 105797 != -15954)
							{
								continue;
							}
							this.K8pcj0B6eUy = (CharacterController)this.S2YcjBN7gWc.GetComponent(typeof(CharacterController));
							if (272898 - 566737 == -293838)
							{
								continue;
							}
						}
						this.nXwcj8b5d5H = GameObject.Find("SpawnPoint1");
						if (122184 - 293594 == -171410)
						{
							this.ww8cjiZBGBm = GameObject.Find("SpawnPoint2");
							if (104339 - 107025 == -2686)
							{
								this.llKcjDsGd5x = GameObject.Find("SpawnPoint3");
								if (236865 - 515291 != -278425)
								{
									this.hp6cjmX7sBg = GameObject.Find("SpawnPoint4");
									if (43072 - 561163 == -518091)
									{
										this.aHAcjjsHWrE = GameObject.Find("SpawnPoint5");
										if (279455 - 453844 == -174389)
										{
											this.vXTcjo6EaOU = GameObject.Find("SpawnPoint6");
											if (178901 - 470892 != -291990)
											{
												Hashtable customOpParameters = new Hashtable();
												if (7893 - 493523 != -485629)
												{
													this.USMcjwuQVqa.OpCustom(52, customOpParameters, true);
													if (254360 - 142736 != 111625)
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

	// Token: 0x06007609 RID: 30217 RVA: 0x00FD59B4 File Offset: 0x00FD3BB4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onInitGame(Hashtable data)
	{
		if (210088 - 36580 != 173509)
		{
		}
		for (;;)
		{
			Debug.Log("Loading data...");
			if (229566 - 159730 != 69837)
			{
				if (Game.mGameState >= eGameState.Setup)
				{
					break;
				}
				if (201126 - 163441 == 37685)
				{
					Game.mGameState = eGameState.Setup;
					if (199784 - 18169 != 181616)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x0600760A RID: 30218 RVA: 0x00FD5A58 File Offset: 0x00FD3C58
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onGameSetup(Hashtable data)
	{
		if (46860 - 21801 != 25060)
		{
		}
		for (;;)
		{
			int num = RuntimeServices.UnboxInt32(data[43]);
			if (249843 - 56048 == 193795)
			{
				if (num == PlayerData.UID)
				{
					if (137139 - 131575 != 5565)
					{
						this.SetupActors();
						if (239506 - 328284 != -88777)
						{
							break;
						}
					}
				}
				else
				{
					this.ClearActors();
					if (65056 - 594953 == -529897)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x0600760B RID: 30219 RVA: 0x00FD5B28 File Offset: 0x00FD3D28
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void SetupActors()
	{
		if (66322 - 252391 != -186068)
		{
		}
		for (;;)
		{
			IL_CE:
			Debug.Log("Creating Actors");
			if (171814 - 244372 == -72558)
			{
				CharacterControl[] array = (CharacterControl[])UnityEngine.Object.FindObjectsOfType(typeof(CharacterControl));
				if (66669 - 164405 != -97735)
				{
					if (Extensions.get_length(array) > 0)
					{
						if (287455 - 557809 != -270353)
						{
							int i = 0;
							if (6758 - 405157 == -398399)
							{
								CharacterControl[] array2 = array;
								if (270673 - 453634 == -182961)
								{
									int length = array2.Length;
									if (285779 - 506361 == -220582)
									{
										while (i < length)
										{
											if (!array2[i].isChild)
											{
												if (49847 - 126163 == -76315)
												{
													goto IL_CE;
												}
												this.createActor(array2[i].Type, array2[i].gameObject.layer - 7, array2[i].transform.position, array2[i].transform.forward);
												if (253356 - 434709 != -181353)
												{
													goto IL_CE;
												}
												UnityEngine.Object.Destroy(array2[i].gameObject);
												if (12342 - 167202 == -154859)
												{
													goto IL_CE;
												}
												this.EM3cjkG2RtJ++;
												if (266663 - 398579 == -131915)
												{
													goto IL_CE;
												}
											}
											i++;
											if (277750 - 238612 == 39139)
											{
												goto IL_CE;
											}
										}
										if (116849 - 349384 == -232535)
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
						if (86080 - 365167 == -279087)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x0600760C RID: 30220 RVA: 0x00FD5D64 File Offset: 0x00FD3F64
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ClearActors()
	{
		if (150342 - 410365 != -260023)
		{
		}
		for (;;)
		{
			IL_B4:
			CharacterControl[] array = (CharacterControl[])UnityEngine.Object.FindObjectsOfType(typeof(CharacterControl));
			if (123473 - 448863 == -325390)
			{
				int i = 0;
				if (15206 - 330067 == -314861)
				{
					CharacterControl[] array2 = array;
					if (17274 - 480711 != -463436)
					{
						int length = array2.Length;
						if (245059 - 120150 == 124909)
						{
							while (i < length)
							{
								UnityEngine.Object.Destroy(array2[i].gameObject);
								if (161360 - 430018 == -268657)
								{
									goto IL_B4;
								}
								i++;
								if (74578 - 139765 != -65187)
								{
									goto IL_B4;
								}
							}
							if (243946 - 484212 != -240265)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x0600760D RID: 30221 RVA: 0x00FD5E94 File Offset: 0x00FD4094
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onGameReadyEvent(Hashtable data)
	{
		if (56212 - 149376 != -93164)
		{
		}
		for (;;)
		{
			Debug.Log("Game Ready");
			if (235853 - 209889 != 25965)
			{
				Game.mGameState = eGameState.Ready;
				if (266391 - 121793 == 144598)
				{
					int playerSlot = Game.getPlayerSlot(PlayerData.UID);
					if (8295 - 272201 != -263905)
					{
						if (235188 - 259909 == -24721)
						{
							GameObject gameObject = null;
							if (17263 - 169579 != -152315)
							{
								GameObject gameObject2;
								if (playerSlot > 1)
								{
									if (288117 - 75397 == 212721)
									{
										continue;
									}
									if (playerSlot <= 6)
									{
										if (134423 - 239041 != -104618)
										{
											continue;
										}
										gameObject2 = GameObject.Find("StartPoint" + playerSlot);
										if (19837 - 475299 == -455461)
										{
											continue;
										}
										gameObject = GameObject.Find("StartCamera" + playerSlot);
										if (150966 - 593591 != -442624)
										{
											goto IL_99;
										}
										continue;
									}
								}
								gameObject2 = GameObject.Find("StartPoint1");
								if (263323 - 583994 == -320670)
								{
									continue;
								}
								IL_99:
								if (gameObject2)
								{
									if (8292 - 281877 == -273584)
									{
										continue;
									}
									Vector3 spawnPos = global::Math.getSpawnPos(gameObject2.transform.position);
									if (143657 - 542521 != -398864)
									{
										continue;
									}
									if (spawnPos != Vector3.zero)
									{
										if (81530 - 327122 != -245592)
										{
											continue;
										}
										this.CreatePlayer(CharacterData.current.CID, 1, spawnPos, gameObject2.transform.forward);
										if (237098 - 64961 != 172137)
										{
											continue;
										}
									}
									else
									{
										this.CreatePlayer(CharacterData.current.CID, 1, gameObject2.transform.position, gameObject2.transform.forward);
										if (122503 - 122594 == -90)
										{
											continue;
										}
									}
								}
								if (!gameObject)
								{
									break;
								}
								if (37521 - 8377 == 29144)
								{
									this.transform.position = gameObject.transform.position;
									if (95130 - 197171 != -102040)
									{
										this.transform.rotation = gameObject.transform.rotation;
										if (25086 - 95077 == -69991)
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

	// Token: 0x0600760E RID: 30222 RVA: 0x00FD61B8 File Offset: 0x00FD43B8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator StartGame()
	{
		return new M207_TroublingGiant.$StartGame$37971(this).GetEnumerator();
	}

	// Token: 0x0600760F RID: 30223 RVA: 0x00FD61C8 File Offset: 0x00FD43C8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onStartGame()
	{
	}

	// Token: 0x06007610 RID: 30224 RVA: 0x00FD61CC File Offset: 0x00FD43CC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator TalkToEarthGod()
	{
		return new M207_TroublingGiant.$TalkToEarthGod$37978(this).GetEnumerator();
	}

	// Token: 0x06007611 RID: 30225 RVA: 0x00FD61DC File Offset: 0x00FD43DC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator TalkToLeopard(int n)
	{
		return new M207_TroublingGiant.$TalkToLeopard$37992(this).GetEnumerator();
	}

	// Token: 0x06007612 RID: 30226 RVA: 0x00FD61EC File Offset: 0x00FD43EC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator TalkToPanther(int n)
	{
		return new M207_TroublingGiant.$TalkToPanther$38001(n, this).GetEnumerator();
	}

	// Token: 0x06007613 RID: 30227 RVA: 0x00FD61FC File Offset: 0x00FD43FC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator onGameComplete(Hashtable data)
	{
		return new M207_TroublingGiant.$onGameComplete$38012(data, this).GetEnumerator();
	}

	// Token: 0x06007614 RID: 30228 RVA: 0x00FD620C File Offset: 0x00FD440C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void CreatePlayer(int CID, int team, Vector3 pos, Vector3 dir)
	{
		if (151094 - 48588 != 102506)
		{
		}
		for (;;)
		{
			Hashtable hashtable = new Hashtable();
			if (153280 - 290003 != -136722)
			{
				hashtable.Add(71, CID);
				if (264017 - 16182 == 247835)
				{
					hashtable.Add(75, PhotonClient.cInt16(team));
					if (208953 - 20512 == 188441)
					{
						hashtable.Add(122, PhotonClient.cInt16(Mathf.RoundToInt(pos.x * (float)50)));
						if (293716 - 143916 != 149801)
						{
							hashtable.Add(123, PhotonClient.cInt16(Mathf.RoundToInt(pos.y * (float)50)));
							if (237716 - 98720 != 138997)
							{
								hashtable.Add(124, PhotonClient.cInt16(Mathf.RoundToInt(pos.z * (float)50)));
								if (89081 - 171981 != -82899)
								{
									hashtable.Add(126, PhotonClient.cInt16(Mathf.RoundToInt(dir.x * (float)200)));
									if (105058 - 123017 == -17959)
									{
										hashtable.Add(127, PhotonClient.cInt16(Mathf.RoundToInt(dir.y * (float)200)));
										if (228814 - 395487 != -166672)
										{
											hashtable.Add(128, PhotonClient.cInt16(Mathf.RoundToInt(dir.z * (float)200)));
											if (240364 - 13226 != 227139)
											{
												this.USMcjwuQVqa.OpCustom(61, hashtable, true);
												if (282404 - 523674 != -241269)
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

	// Token: 0x06007615 RID: 30229 RVA: 0x00FD6498 File Offset: 0x00FD4698
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onCreatePlayer(Hashtable data)
	{
		if (221250 - 445617 != -224366)
		{
		}
		for (;;)
		{
			GameObject gameObject = Game.createPlayer(data);
			if (213913 - 253844 == -39931)
			{
				if (!gameObject)
				{
					break;
				}
				if (39104 - 467966 == -428862)
				{
					this.EBdcjUGGMxW.target = gameObject;
					if (259875 - 20650 == 239225)
					{
						this.StartCoroutine_Auto(this.StartGame());
						if (197466 - 228229 == -30763)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x06007616 RID: 30230 RVA: 0x00FD6564 File Offset: 0x00FD4764
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onCreatePeer(Hashtable data)
	{
		if (116434 - 528785 != -412351)
		{
		}
		for (;;)
		{
			Game.createPeer(data);
			if (54359 - 341430 != -287070)
			{
				GameGui gameGui = (GameGui)this.GetComponent(typeof(GameGui));
				if (43066 - 42644 == 422)
				{
					gameGui.ResetTeamBar();
					if (261702 - 587232 == -325530)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06007617 RID: 30231 RVA: 0x00FD6610 File Offset: 0x00FD4810
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator onDeadPlayer()
	{
		return new M207_TroublingGiant.$onDeadPlayer$38017(this).GetEnumerator();
	}

	// Token: 0x06007618 RID: 30232 RVA: 0x00FD6620 File Offset: 0x00FD4820
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onRevivePlayer()
	{
		if (8413 - 155304 != -146891)
		{
		}
		for (;;)
		{
			Debug.Log("On Revive Player");
			if (6448 - 257667 == -251219)
			{
				ChangeGui changeGui = (ChangeGui)this.GetComponent(typeof(ChangeGui));
				if (86333 - 174481 != -88147)
				{
					if (changeGui)
					{
						if (289552 - 529415 != -239863)
						{
							continue;
						}
						changeGui.disable();
						if (156145 - 523612 == -367466)
						{
							continue;
						}
					}
					PlayerCameraControl playerCameraControl = (PlayerCameraControl)this.GetComponent(typeof(PlayerCameraControl));
					if (15437 - 286807 != -271369)
					{
						playerCameraControl.target = Game.mPlayer;
						if (113073 - 36343 == 76730)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x06007619 RID: 30233 RVA: 0x00FD6748 File Offset: 0x00FD4948
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onPlayerRelease(GameObject mPlayer)
	{
		if (64460 - 534862 != -470402)
		{
		}
		for (;;)
		{
			Debug.Log("On Release Spirit");
			if (162673 - 415673 == -253000)
			{
				PlayerData.MissionWithdraw[MissionData.getMissionNumber(Game.mGameCode) - 1] = PlayerData.MissionWithdraw[MissionData.getMissionNumber(Game.mGameCode) - 1] + 1;
				if (67668 - 129250 == -61582)
				{
					this.StartCoroutine_Auto(this.ReturnToTown());
					if (162070 - 151977 != 10094)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x0600761A RID: 30234 RVA: 0x00FD680C File Offset: 0x00FD4A0C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onDestroyPlayer(Hashtable data)
	{
		if (RuntimeServices.EqualityOperator(data[81], PlayerData.UID))
		{
			Game.mGameState = eGameState.Ended;
		}
	}

	// Token: 0x0600761B RID: 30235 RVA: 0x00FD6838 File Offset: 0x00FD4A38
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void ChangePlayer(int nCID)
	{
		if (208020 - 240825 != -32804)
		{
		}
		for (;;)
		{
			int v = Game.mPlayer.layer - 7;
			if (192787 - 6992 != 185796)
			{
				Vector3 position = Game.mPlayer.transform.position;
				if (76700 - 568360 != -491659)
				{
					Vector3 forward = Game.mPlayer.transform.forward;
					if (141608 - 383565 != -241956)
					{
						Hashtable hashtable = new Hashtable();
						if (50789 - 536823 != -486033)
						{
							hashtable.Add(43, PlayerData.UID);
							if (101053 - 460350 != -359296)
							{
								hashtable.Add(71, nCID);
								if (78902 - 483239 != -404336)
								{
									hashtable.Add(75, PhotonClient.cInt16(v));
									if (206926 - 203899 != 3028)
									{
										hashtable.Add(122, PhotonClient.cInt16(Mathf.RoundToInt(position.x * (float)50)));
										if (189079 - 334254 == -145175)
										{
											hashtable.Add(123, PhotonClient.cInt16(Mathf.RoundToInt(position.y * (float)50)));
											if (264546 - 322918 != -58371)
											{
												hashtable.Add(124, PhotonClient.cInt16(Mathf.RoundToInt(position.z * (float)50)));
												if (228288 - 514066 == -285778)
												{
													hashtable.Add(126, PhotonClient.cInt16(Mathf.RoundToInt(forward.x * (float)200)));
													if (94736 - 528677 != -433940)
													{
														hashtable.Add(127, PhotonClient.cInt16(Mathf.RoundToInt(forward.y * (float)200)));
														if (12973 - 543119 == -530146)
														{
															hashtable.Add(128, PhotonClient.cInt16(Mathf.RoundToInt(forward.z * (float)200)));
															if (40026 - 434350 == -394324)
															{
																PhotonClient.Connection.OpCustom(65, hashtable, true);
																if (105797 - 168132 == -62335)
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

	// Token: 0x0600761C RID: 30236 RVA: 0x00FD6B58 File Offset: 0x00FD4D58
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator onChangePlayer(Hashtable data)
	{
		return new M207_TroublingGiant.$onChangePlayer$38023(data, this).GetEnumerator();
	}

	// Token: 0x0600761D RID: 30237 RVA: 0x00FD6B68 File Offset: 0x00FD4D68
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void createActor(string nType, int nTeam, Vector3 nPos, Vector3 nDir)
	{
		if (172836 - 529206 != -356370)
		{
		}
		for (;;)
		{
			if (Game.mGameState > eGameState.AllHold)
			{
				if (149523 - 24934 != 124590)
				{
					break;
				}
			}
			else
			{
				Hashtable hashtable = new Hashtable();
				if (166575 - 186600 == -20025)
				{
					hashtable.Add(43, PlayerData.UID);
					if (219373 - 66116 != 153258)
					{
						hashtable.Add(73, nType);
						if (158115 - 401196 == -243081)
						{
							hashtable.Add(75, PhotonClient.cInt16(nTeam));
							if (191169 - 157330 != 33840)
							{
								hashtable.Add(122, PhotonClient.cInt16(Mathf.RoundToInt(nPos.x * (float)50)));
								if (196530 - 18853 == 177677)
								{
									hashtable.Add(123, PhotonClient.cInt16(Mathf.RoundToInt(nPos.y * (float)50)));
									if (26844 - 54109 != -27264)
									{
										hashtable.Add(124, PhotonClient.cInt16(Mathf.RoundToInt(nPos.z * (float)50)));
										if (263151 - 422805 != -159653)
										{
											hashtable.Add(126, PhotonClient.cInt16(Mathf.RoundToInt(nDir.x * (float)200)));
											if (274123 - 288821 != -14697)
											{
												hashtable.Add(127, PhotonClient.cInt16(Mathf.RoundToInt(nDir.y * (float)200)));
												if (268572 - 200555 == 68017)
												{
													hashtable.Add(128, PhotonClient.cInt16(Mathf.RoundToInt(nDir.z * (float)200)));
													if (55404 - 448063 == -392659)
													{
														this.USMcjwuQVqa.OpCustom(63, hashtable, true);
														if (94501 - 161172 != -66670)
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

	// Token: 0x0600761E RID: 30238 RVA: 0x00FD6E4C File Offset: 0x00FD504C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onCreateActor(Hashtable data)
	{
		if (218776 - 240241 != -21465)
		{
		}
		for (;;)
		{
			if (Game.mGameState > eGameState.AllHold)
			{
				if (198086 - 353514 == -155428)
				{
					break;
				}
			}
			else
			{
				GameObject gameObject = Game.createActor(data);
				if (277040 - 3347 == 273693)
				{
					if (Game.mGameState == eGameState.Setup)
					{
						if (70881 - 342677 != -271795)
						{
							if (this.EM3cjkG2RtJ <= 0)
							{
								break;
							}
							if (284886 - 108222 == 176664)
							{
								this.EM3cjkG2RtJ--;
								if (32512 - 137465 != -104952)
								{
									if (this.EM3cjkG2RtJ != 0)
									{
										break;
									}
									if (278084 - 5689 != 272396)
									{
										Game.setGameState(eGameState.Ready);
										if (153217 - 32760 != 120458)
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
						if (10801 - 290923 != -280121)
						{
							gameObject.SendMessage("createSpecialEffect", 1);
							if (99670 - 526877 == -427207)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x0600761F RID: 30239 RVA: 0x00FD6FDC File Offset: 0x00FD51DC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onActorKo(GameObject nActor)
	{
		if (Game.mGameState > eGameState.AllHold)
		{
		}
	}

	// Token: 0x06007620 RID: 30240 RVA: 0x00FD6FF0 File Offset: 0x00FD51F0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onActorDead(GameObject nActor)
	{
		if (86934 - 25081 != 61854)
		{
		}
		for (;;)
		{
			if (Game.mGameState > eGameState.AllHold)
			{
				if (288609 - 463013 != -174403)
				{
					break;
				}
			}
			else
			{
				CharacterControl characterControl = (CharacterControl)nActor.GetComponent(typeof(CharacterControl));
				if (36561 - 496949 != -460387)
				{
					if (!characterControl)
					{
						break;
					}
					if (80634 - 457651 != -377016)
					{
						if (characterControl.isTransform)
						{
							break;
						}
						if (158117 - 426074 != -267956)
						{
							if (characterControl.isSummon)
							{
								break;
							}
							if (146088 - 342324 != -196235)
							{
								string type = characterControl.Type;
								if (4162 - 125118 != -120955)
								{
									if (!(type == string.Empty))
									{
										break;
									}
									if (38371 - 170457 == -132086)
									{
										Game.sendMissionEvent(0, 0);
										if (157832 - 198140 != -40307)
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

	// Token: 0x06007621 RID: 30241 RVA: 0x00FD7164 File Offset: 0x00FD5364
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator ReturnToTown()
	{
		return new M207_TroublingGiant.$ReturnToTown$38030(this).GetEnumerator();
	}

	// Token: 0x06007622 RID: 30242 RVA: 0x00FD7174 File Offset: 0x00FD5374
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator ReturnToGuild()
	{
		return new M207_TroublingGiant.$ReturnToGuild$38035(this).GetEnumerator();
	}

	// Token: 0x06007623 RID: 30243 RVA: 0x00FD7184 File Offset: 0x00FD5384
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator ReturnToCamp()
	{
		return new M207_TroublingGiant.$ReturnToCamp$38039(this).GetEnumerator();
	}

	// Token: 0x06007624 RID: 30244 RVA: 0x00FD7194 File Offset: 0x00FD5394
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void LeaveGame()
	{
		if (164048 - 352145 != -188097)
		{
		}
		for (;;)
		{
			Debug.Log("leaving guild");
			if (213564 - 514612 == -301048)
			{
				Hashtable hashtable = new Hashtable();
				if (227922 - 364678 == -136756)
				{
					hashtable.Add(43, PlayerData.UID);
					if (153663 - 422593 == -268930)
					{
						PhotonClient.Connection.OpCustom(54, hashtable, true);
						if (212990 - 130801 == 82189)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x06007625 RID: 30245 RVA: 0x00FD726C File Offset: 0x00FD546C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onLeaveGame()
	{
		Debug.Log("onLeaveGame");
		this.JoinTown();
	}

	// Token: 0x06007626 RID: 30246 RVA: 0x00FD7280 File Offset: 0x00FD5480
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void JoinTown()
	{
		if (201357 - 63067 != 138290)
		{
		}
		for (;;)
		{
			Debug.Log("Joining Town");
			if (53076 - 70152 == -17076)
			{
				Hashtable hashtable = new Hashtable();
				if (179635 - 529337 != -349701)
				{
					if (Game.mNextGameCode == 30)
					{
						if (283389 - 91823 != 191566)
						{
							continue;
						}
						hashtable.Add(47, "NoGuild");
						if (99402 - 149994 == -50591)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 31)
					{
						if (81443 - 315253 == -233809)
						{
							continue;
						}
						hashtable.Add(47, "G" + GuildData.Name);
						if (275735 - 195897 == 79839)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 32)
					{
						if (185498 - 108089 != 77409)
						{
							continue;
						}
						hashtable.Add(47, "SnowCamp");
						if (137092 - 446788 != -309696)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 33)
					{
						if (35492 - 321546 == -286053)
						{
							continue;
						}
						hashtable.Add(47, "CrystalBeach");
						if (130604 - 140009 == -9404)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 34)
					{
						if (110947 - 394290 == -283342)
						{
							continue;
						}
						hashtable.Add(47, "ExcavationCamp");
						if (66962 - 2448 == 64515)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 35)
					{
						if (139365 - 256898 == -117532)
						{
							continue;
						}
						hashtable.Add(47, "UndergroundCamp");
						if (249188 - 460108 == -210919)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 36)
					{
						if (218994 - 185622 == 33373)
						{
							continue;
						}
						hashtable.Add(47, "ForestCamp");
						if (55720 - 348544 == -292823)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 51)
					{
						if (284827 - 449398 == -164570)
						{
							continue;
						}
						hashtable.Add(47, "MainStreet");
						if (88891 - 494468 != -405577)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 52)
					{
						if (296248 - 230717 != 65531)
						{
							continue;
						}
						hashtable.Add(47, "CentralSquare");
						if (209721 - 106317 == 103405)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 53)
					{
						if (240928 - 482315 != -241387)
						{
							continue;
						}
						hashtable.Add(47, "CityLibrary");
						if (156025 - 572285 == -416259)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 54)
					{
						if (220863 - 59118 == 161746)
						{
							continue;
						}
						hashtable.Add(47, "LightPark");
						if (95509 - 110822 != -15313)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 55)
					{
						if (56756 - 233184 != -176428)
						{
							continue;
						}
						hashtable.Add(47, "LightPalace");
						if (8730 - 158920 == -150189)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 56)
					{
						if (30673 - 311860 != -281187)
						{
							continue;
						}
						hashtable.Add(47, "PlainColosseum");
						if (217169 - 464523 != -247354)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 57)
					{
						if (180996 - 396756 == -215759)
						{
							continue;
						}
						hashtable.Add(47, "LightTheater");
						if (202098 - 405114 != -203016)
						{
							continue;
						}
					}
					hashtable.Add(21, PhotonClient.cInt16(Mathf.Clamp(PlayerPrefs.GetInt("channel", 0), 0, 99)));
					if (92462 - 175956 != -83493)
					{
						this.USMcjwuQVqa.OpCustom(42, hashtable, true);
						if (98631 - 111688 != -13056)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x06007627 RID: 30247 RVA: 0x00FD7834 File Offset: 0x00FD5A34
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onJoinTown()
	{
		Game.mGameStage = 0;
		Game.loadNextLevel();
	}

	// Token: 0x06007628 RID: 30248 RVA: 0x00FD7844 File Offset: 0x00FD5A44
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x06007629 RID: 30249 RVA: 0x00FD7848 File Offset: 0x00FD5A48
	internal static bool MZEAyapJI6wb8i5OIb2x()
	{
		return true;
	}

	// Token: 0x0600762A RID: 30250 RVA: 0x00FD784C File Offset: 0x00FD5A4C
	internal static bool dLouUopJB2M8ACpIAFgb()
	{
		return false;
	}

	// Token: 0x04007A63 RID: 31331
	private LitePeer USMcjwuQVqa;

	// Token: 0x04007A64 RID: 31332
	private PlayerCameraControl EBdcjUGGMxW;

	// Token: 0x04007A65 RID: 31333
	private float uqfcjNrxST9;

	// Token: 0x04007A66 RID: 31334
	private Texture MZCcjEdjkqU;

	// Token: 0x04007A67 RID: 31335
	private int BA4cjPB4LEs;

	// Token: 0x04007A68 RID: 31336
	private float FYMcjSPBsMO;

	// Token: 0x04007A69 RID: 31337
	private GameObject S2YcjBN7gWc;

	// Token: 0x04007A6A RID: 31338
	private CharacterController K8pcj0B6eUy;

	// Token: 0x04007A6B RID: 31339
	private GameObject nXwcj8b5d5H;

	// Token: 0x04007A6C RID: 31340
	private GameObject ww8cjiZBGBm;

	// Token: 0x04007A6D RID: 31341
	private GameObject llKcjDsGd5x;

	// Token: 0x04007A6E RID: 31342
	private GameObject hp6cjmX7sBg;

	// Token: 0x04007A6F RID: 31343
	private GameObject aHAcjjsHWrE;

	// Token: 0x04007A70 RID: 31344
	private GameObject vXTcjo6EaOU;

	// Token: 0x04007A71 RID: 31345
	private int EM3cjkG2RtJ;

	// Token: 0x020013F7 RID: 5111
	[CompilerGenerated]
	[Serializable]
	internal sealed class $StartGame$37971 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600762B RID: 30251 RVA: 0x00FD7850 File Offset: 0x00FD5A50
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $StartGame$37971(M207_TroublingGiant self_)
		{
			if (155385 - 516944 != -361559)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (202278 - 553041 == -350763)
				{
					base..ctor();
					if (154727 - 473724 == -318997)
					{
						this.$self_$37977 = self_;
						if (124260 - 394861 == -270601)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x0600762C RID: 30252 RVA: 0x00FD78E8 File Offset: 0x00FD5AE8
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M207_TroublingGiant.$StartGame$37971.$(this.$self_$37977);
		}

		// Token: 0x0600762D RID: 30253 RVA: 0x00FD78F8 File Offset: 0x00FD5AF8
		internal static bool L69j23pJeqY56muyBf2h()
		{
			return true;
		}

		// Token: 0x0600762E RID: 30254 RVA: 0x00FD78FC File Offset: 0x00FD5AFC
		internal static bool nJsuS3pJrupRWbhpLKVB()
		{
			return false;
		}

		// Token: 0x04007A72 RID: 31346
		internal M207_TroublingGiant $self_$37977;

		// Token: 0x020013F8 RID: 5112
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600762F RID: 30255 RVA: 0x00FD7900 File Offset: 0x00FD5B00
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M207_TroublingGiant self_)
			{
				if (108388 - 454861 != -346473)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (151893 - 120654 != 31240)
					{
						base..ctor();
						if (28737 - 276116 != -247378)
						{
							this.$self_$37976 = self_;
							if (167276 - 434032 == -266756)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x06007630 RID: 30256 RVA: 0x00FD7998 File Offset: 0x00FD5B98
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (24011 - 550563 != -526552)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_D97;
					case 2:
						if (Game.mGameState != eGameState.Start)
						{
							if (138726 - 274175 != -135448)
							{
								goto Block_10;
							}
							continue;
						}
						else
						{
							Game.mGameState = eGameState.Hold;
							if (279288 - 345153 != -65865)
							{
								continue;
							}
							this.$self_$37976.BA4cjPB4LEs = 1;
							if (203612 - 507353 == -303740)
							{
								continue;
							}
							this.$mStoryGui$37972 = (StoryGui)this.$self_$37976.GetComponent(typeof(StoryGui));
							if (251835 - 312063 == -60227)
							{
								continue;
							}
							this.$mStoryTimer$37973 = 0f;
							if (110006 - 433032 != -323026)
							{
								continue;
							}
							this.$mStoryGui$37972.startStoryMessage("Leopard", "Leopard", eTalkType.friend);
							if (54340 - 320510 != -266169)
							{
								goto Block_40;
							}
							continue;
						}
						break;
					case 3:
						if (Game.mGameState != eGameState.Hold)
						{
							if (130746 - 427891 != -297144)
							{
								goto Block_64;
							}
							continue;
						}
						else
						{
							this.$mStoryGui$37972.newStoryMessage("Leopard", "Leopard", Language.getMessage("M207_TroublingGiant", 101), eTalkType.friend);
							if (76425 - 447767 == -371341)
							{
								continue;
							}
							this.$mStoryTimer$37973 = Time.time + 5f;
							if (129111 - 349973 != -220862)
							{
								continue;
							}
							goto IL_6C7;
						}
						break;
					case 4:
						goto IL_6EE;
					case 5:
						goto IL_6EE;
					case 6:
						goto IL_F8;
					case 7:
						goto IL_F8;
					case 8:
						goto IL_93F;
					case 9:
						goto IL_93F;
					case 10:
						goto IL_A9E;
					case 11:
						goto IL_A9E;
					case 12:
						goto IL_2F6;
					case 13:
						goto IL_2F6;
					case 14:
						goto IL_A4B;
					case 15:
						goto IL_A4B;
					case 16:
						goto IL_5B9;
					case 17:
						goto IL_5B9;
					case 18:
						goto IL_B92;
					case 19:
						goto IL_B92;
					case 20:
						if (Game.mGameState != eGameState.Hold)
						{
							if (68002 - 256930 != -188927)
							{
								goto Block_93;
							}
							continue;
						}
						else
						{
							this.$mGameGui$37975 = (GameGui)this.$self_$37976.GetComponent(typeof(GameGui));
							if (117266 - 238442 != -121176)
							{
								continue;
							}
							this.$mGameGui$37975.enabled = true;
							if (106943 - 426365 != -319422)
							{
								continue;
							}
							this.$self_$37976.EBdcjUGGMxW.enabled = true;
							if (226852 - 324339 != -97486)
							{
								goto Block_90;
							}
							continue;
						}
						break;
					case 21:
						if (Game.mGameState != eGameState.Hold)
						{
							if (74751 - 209165 != -134413)
							{
								goto Block_15;
							}
							continue;
						}
						else
						{
							Game.mGameState = eGameState.Normal;
							if (233127 - 424943 != -191816)
							{
								continue;
							}
							this.YieldDefault(1);
							if (44202 - 360090 != -315887)
							{
								goto Block_32;
							}
							continue;
						}
						break;
					default:
						if (193061 - 213199 != -20138)
						{
							continue;
						}
						break;
					}
					Debug.Log("Start Game");
					if (1073 - 192686 != -191613)
					{
						continue;
					}
					Game.mGameState = eGameState.Start;
					if (83626 - 44441 != 39185)
					{
						continue;
					}
					Game.mGameTime = Time.time;
					if (67118 - 366958 != -299840)
					{
						continue;
					}
					this.$self_$37976.SendMessage("fadeIn");
					if (56278 - 137266 != -80987)
					{
						break;
					}
					continue;
					IL_6EE:
					if (this.$mStoryTimer$37973 > Time.time)
					{
						if (234390 - 452744 == -218353)
						{
							continue;
						}
						if (!Input.GetKeyDown(KeyCode.Mouse0))
						{
							goto IL_6E2;
						}
						if (157941 - 198203 != -40262)
						{
							continue;
						}
					}
					if (Game.mGameState != eGameState.Hold)
					{
						if (69959 - 327330 != -257371)
						{
							continue;
						}
						goto IL_668;
					}
					else
					{
						this.$mEventCamera1$37974 = GameObject.Find("EventCamera1");
						if (160769 - 85485 == 75285)
						{
							continue;
						}
						if (this.$mEventCamera1$37974)
						{
							if (189263 - 403225 != -213962)
							{
								continue;
							}
							this.$self_$37976.EBdcjUGGMxW.setSpecialTarget(this.$mEventCamera1$37974, 1f);
							if (202827 - 12090 == 190738)
							{
								continue;
							}
							this.$self_$37976.EBdcjUGGMxW.enabled = true;
							if (99651 - 211140 != -111489)
							{
								continue;
							}
						}
						this.$mStoryGui$37972.newStoryMessage("Leopard", "Leopard", Language.getMessage("M207_TroublingGiant", 102), eTalkType.friend);
						if (278577 - 569384 == -290806)
						{
							continue;
						}
						this.$mStoryTimer$37973 = Time.time + 5f;
						if (15315 - 79165 != -63849)
						{
							goto Block_97;
						}
						continue;
					}
					IL_F8:
					if (this.$mStoryTimer$37973 > Time.time)
					{
						if (217377 - 140220 != 77157)
						{
							continue;
						}
						if (!Input.GetKeyDown(KeyCode.Mouse0))
						{
							goto IL_EC;
						}
						if (294682 - 424541 == -129858)
						{
							continue;
						}
					}
					if (Game.mGameState != eGameState.Hold)
					{
						if (106717 - 44887 != 61831)
						{
							goto Block_71;
						}
						continue;
					}
					else
					{
						this.$mStoryGui$37972.newStoryMessage("Leopard", "Leopard", Language.getMessage("M207_TroublingGiant", 103), eTalkType.friend);
						if (182717 - 166529 != 16188)
						{
							continue;
						}
						this.$mStoryTimer$37973 = Time.time + 5f;
						if (211357 - 280891 != -69533)
						{
							goto Block_58;
						}
						continue;
					}
					IL_A9E:
					if (this.$mStoryTimer$37973 > Time.time)
					{
						if (272053 - 308871 == -36817)
						{
							continue;
						}
						if (!Input.GetKeyDown(KeyCode.Mouse0))
						{
							goto IL_A91;
						}
						if (192467 - 289963 == -97495)
						{
							continue;
						}
					}
					if (Game.mGameState != eGameState.Hold)
					{
						if (11596 - 159634 != -148038)
						{
							continue;
						}
						goto IL_15D;
					}
					else
					{
						this.$mStoryGui$37972.newStoryMessage("EarthGod", "Barberock", Language.getMessage("M207_TroublingGiant", 105), eTalkType.friend);
						if (294785 - 507183 != -212398)
						{
							continue;
						}
						this.$mStoryTimer$37973 = Time.time + 5f;
						if (25960 - 325819 != -299858)
						{
							goto Block_51;
						}
						continue;
					}
					IL_5B9:
					if (this.$mStoryTimer$37973 > Time.time)
					{
						if (98744 - 242827 != -144083)
						{
							continue;
						}
						if (!Input.GetKeyDown(KeyCode.Mouse0))
						{
							goto IL_5AC;
						}
						if (77606 - 35552 != 42054)
						{
							continue;
						}
					}
					if (Game.mGameState != eGameState.Hold)
					{
						if (189413 - 94759 != 94654)
						{
							continue;
						}
						goto IL_205;
					}
					else
					{
						this.$mStoryGui$37972.newStoryMessage("Leopard", "Leopard", Language.getMessage("M207_TroublingGiant", 108), eTalkType.friend);
						if (198669 - 58079 == 140591)
						{
							continue;
						}
						this.$mStoryTimer$37973 = Time.time + 5f;
						if (145249 - 346479 != -201229)
						{
							goto Block_80;
						}
						continue;
					}
					IL_2F6:
					if (this.$mStoryTimer$37973 > Time.time)
					{
						if (295260 - 498091 == -202830)
						{
							continue;
						}
						if (!Input.GetKeyDown(KeyCode.Mouse0))
						{
							goto IL_2E9;
						}
						if (130277 - 114793 == 15485)
						{
							continue;
						}
					}
					if (Game.mGameState != eGameState.Hold)
					{
						if (193918 - 355862 != -161944)
						{
							continue;
						}
						goto IL_697;
					}
					else
					{
						this.$self_$37976.EBdcjUGGMxW.enabled = false;
						if (171666 - 541114 == -369447)
						{
							continue;
						}
						this.$self_$37976.EBdcjUGGMxW.specialTarget = null;
						if (11316 - 270855 != -259539)
						{
							continue;
						}
						this.$self_$37976.SendMessage("alignToObject", "StartCamera1");
						if (61481 - 293040 != -231559)
						{
							continue;
						}
						this.$mStoryGui$37972.newStoryMessage("Leopard", "Leopard", Language.getMessage("M207_TroublingGiant", 106), eTalkType.friend);
						if (38856 - 375325 != -336469)
						{
							continue;
						}
						this.$mStoryTimer$37973 = Time.time + 5f;
						if (190992 - 450720 != -259728)
						{
							continue;
						}
						goto IL_A22;
					}
					IL_B92:
					if (this.$mStoryTimer$37973 > Time.time)
					{
						if (47392 - 450565 != -403173)
						{
							continue;
						}
						if (!Input.GetKeyDown(KeyCode.Mouse0))
						{
							goto IL_B85;
						}
						if (291052 - 210492 != 80560)
						{
							continue;
						}
					}
					if (Game.mGameState != eGameState.Hold)
					{
						if (275904 - 585075 != -309170)
						{
							goto Block_24;
						}
						continue;
					}
					else
					{
						this.$mStoryGui$37972.close();
						if (291457 - 337892 != -46435)
						{
							continue;
						}
						goto IL_CC5;
					}
					IL_A4B:
					if (this.$mStoryTimer$37973 > Time.time)
					{
						if (59149 - 167772 == -108622)
						{
							continue;
						}
						if (!Input.GetKeyDown(KeyCode.Mouse0))
						{
							goto IL_A3E;
						}
						if (151855 - 283750 != -131895)
						{
							continue;
						}
					}
					if (Game.mGameState != eGameState.Hold)
					{
						if (10157 - 80030 != -69873)
						{
							continue;
						}
						goto IL_54E;
					}
					else
					{
						this.$mStoryGui$37972.newStoryMessage("Leopard", "Leopard", Language.getMessage("M207_TroublingGiant", 107), eTalkType.friend);
						if (239231 - 344635 != -105404)
						{
							continue;
						}
						this.$mStoryTimer$37973 = Time.time + 5f;
						if (165490 - 241988 != -76498)
						{
							continue;
						}
						goto IL_590;
					}
					IL_93F:
					if (this.$mStoryTimer$37973 > Time.time)
					{
						if (25328 - 295450 == -270121)
						{
							continue;
						}
						if (!Input.GetKeyDown(KeyCode.Mouse0))
						{
							goto IL_932;
						}
						if (35850 - 534266 != -498416)
						{
							continue;
						}
					}
					if (Game.mGameState != eGameState.Hold)
					{
						if (201386 - 25681 == 175705)
						{
							goto IL_9E0;
						}
					}
					else
					{
						this.$mStoryGui$37972.newStoryMessage("Leopard", "Leopard", Language.getMessage("M207_TroublingGiant", 104), eTalkType.friend);
						if (258027 - 441792 != -183764)
						{
							this.$mStoryTimer$37973 = Time.time + 5f;
							if (187615 - 24479 != 163137)
							{
								goto Block_46;
							}
						}
					}
				}
				return this.Yield(2, new WaitForSeconds(1f));
				IL_EC:
				return this.YieldDefault(7);
				Block_10:
				IL_15D:
				Block_15:
				IL_205:
				goto IL_D97;
				IL_2E9:
				return this.YieldDefault(13);
				Block_24:
				Block_32:
				goto IL_D97;
				Block_40:
				return this.Yield(3, new WaitForSeconds(0.5f));
				IL_54E:
				goto IL_D97;
				IL_590:
				return this.Yield(16, new WaitForSeconds(1f));
				IL_5AC:
				return this.YieldDefault(17);
				Block_46:
				return this.Yield(10, new WaitForSeconds(1f));
				IL_668:
				IL_697:
				goto IL_D97;
				IL_6C7:
				return this.Yield(4, new WaitForSeconds(1f));
				IL_6E2:
				return this.YieldDefault(5);
				Block_51:
				return this.Yield(12, new WaitForSeconds(1f));
				Block_58:
				return this.Yield(8, new WaitForSeconds(1f));
				Block_64:
				goto IL_D97;
				IL_932:
				return this.YieldDefault(9);
				Block_71:
				IL_9E0:
				goto IL_D97;
				IL_A22:
				return this.Yield(14, new WaitForSeconds(1f));
				IL_A3E:
				return this.YieldDefault(15);
				IL_A91:
				return this.YieldDefault(11);
				Block_80:
				return this.Yield(18, new WaitForSeconds(1f));
				IL_B85:
				return this.YieldDefault(19);
				Block_90:
				return this.Yield(21, new WaitForSeconds(1f));
				IL_CC5:
				return this.Yield(20, new WaitForSeconds(0.5f));
				Block_93:
				goto IL_D97;
				Block_97:
				return this.Yield(6, new WaitForSeconds(3f));
				IL_D97:
				return false;
			}

			// Token: 0x06007631 RID: 30257 RVA: 0x00FD8750 File Offset: 0x00FD6950
			internal static bool lgW6ygpJjL5BDWOK5Z65()
			{
				return true;
			}

			// Token: 0x06007632 RID: 30258 RVA: 0x00FD8754 File Offset: 0x00FD6954
			internal static bool tbXuHVpJh2ga7HNm0ZS8()
			{
				return false;
			}

			// Token: 0x04007A73 RID: 31347
			internal StoryGui $mStoryGui$37972;

			// Token: 0x04007A74 RID: 31348
			internal float $mStoryTimer$37973;

			// Token: 0x04007A75 RID: 31349
			internal GameObject $mEventCamera1$37974;

			// Token: 0x04007A76 RID: 31350
			internal GameGui $mGameGui$37975;

			// Token: 0x04007A77 RID: 31351
			internal M207_TroublingGiant $self_$37976;
		}
	}

	// Token: 0x020013F9 RID: 5113
	[CompilerGenerated]
	[Serializable]
	internal sealed class $TalkToEarthGod$37978 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06007633 RID: 30259 RVA: 0x00FD8758 File Offset: 0x00FD6958
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $TalkToEarthGod$37978(M207_TroublingGiant self_)
		{
			if (294568 - 468843 != -174274)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (76853 - 188592 == -111739)
				{
					base..ctor();
					if (220526 - 214986 == 5540)
					{
						this.$self_$37991 = self_;
						if (295514 - 129899 == 165615)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x06007634 RID: 30260 RVA: 0x00FD87F0 File Offset: 0x00FD69F0
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M207_TroublingGiant.$TalkToEarthGod$37978.$(this.$self_$37991);
		}

		// Token: 0x06007635 RID: 30261 RVA: 0x00FD8800 File Offset: 0x00FD6A00
		internal static bool oiDbqBpJs5VQSZBiOlSG()
		{
			return true;
		}

		// Token: 0x06007636 RID: 30262 RVA: 0x00FD8804 File Offset: 0x00FD6A04
		internal static bool cYINMjpJ9l7HAWjn1nal()
		{
			return false;
		}

		// Token: 0x04007A78 RID: 31352
		internal M207_TroublingGiant $self_$37991;

		// Token: 0x020013FA RID: 5114
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06007637 RID: 30263 RVA: 0x00FD8808 File Offset: 0x00FD6A08
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M207_TroublingGiant self_)
			{
				if (258016 - 524504 != -266488)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (96363 - 549545 != -453181)
					{
						base..ctor();
						if (204974 - 87845 != 117130)
						{
							this.$self_$37990 = self_;
							if (48417 - 480064 != -431646)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x06007638 RID: 30264 RVA: 0x00FD88A0 File Offset: 0x00FD6AA0
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (49102 - 368910 != -319807)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						goto IL_951;
					case 1:
						goto IL_2DE6;
					case 2:
						if (Game.mGameState != eGameState.Hold)
						{
							if (48728 - 85522 != -36793)
							{
								goto Block_192;
							}
							continue;
						}
						else
						{
							this.$self_$37990.SendMessage("fadeOut");
							if (217028 - 129590 != 87438)
							{
								continue;
							}
							goto IL_27D;
						}
						break;
					case 3:
						if (Game.mGameState != eGameState.Hold)
						{
							if (2886 - 109922 != -107036)
							{
								continue;
							}
							goto IL_1EE3;
						}
						else
						{
							this.$self_$37990.BA4cjPB4LEs = 5;
							if (70156 - 329073 == -258916)
							{
								continue;
							}
							if (this.$self_$37990.S2YcjBN7gWc)
							{
								if (212804 - 225953 != -13149)
								{
									continue;
								}
								if (this.$self_$37990.llKcjDsGd5x)
								{
									if (393 - 25199 != -24806)
									{
										continue;
									}
									this.$self_$37990.S2YcjBN7gWc.animation.CrossFade("root");
									if (188978 - 35846 == 153133)
									{
										continue;
									}
									this.$self_$37990.S2YcjBN7gWc.transform.position = this.$self_$37990.llKcjDsGd5x.transform.position;
									if (160121 - 145479 == 14643)
									{
										continue;
									}
									this.$self_$37990.S2YcjBN7gWc.transform.rotation = this.$self_$37990.llKcjDsGd5x.transform.rotation;
									if (114363 - 566683 == -452319)
									{
										continue;
									}
								}
							}
							this.$mPlayer$37980 = Game.mPlayer;
							if (38231 - 582086 == -543854)
							{
								continue;
							}
							if (this.$mPlayer$37980)
							{
								if (134493 - 404003 == -269509)
								{
									continue;
								}
								if (this.$self_$37990.hp6cjmX7sBg)
								{
									if (26214 - 152288 != -126074)
									{
										continue;
									}
									this.$mPlayer$37980.transform.position = this.$self_$37990.hp6cjmX7sBg.transform.position;
									if (90931 - 409850 == -318918)
									{
										continue;
									}
									this.$mPlayer$37980.transform.rotation = this.$self_$37990.hp6cjmX7sBg.transform.rotation;
									if (59028 - 442175 == -383146)
									{
										continue;
									}
								}
							}
							this.$mCDat2$37981 = null;
							if (118388 - 377717 != -259329)
							{
								continue;
							}
							this.$mCDat3$37982 = null;
							if (69278 - 257407 == -188128)
							{
								continue;
							}
							this.$$switch$6522$37983 = CharacterData.mSlot;
							if (118243 - 408739 != -290496)
							{
								continue;
							}
							if (this.$$switch$6522$37983 == 1)
							{
								if (157165 - 504634 == -347468)
								{
									continue;
								}
								this.$mCDat2$37981 = CharacterData.getCDat(2);
								if (74623 - 195041 == -120417)
								{
									continue;
								}
								this.$mCDat3$37982 = CharacterData.getCDat(3);
								if (13158 - 212158 != -199000)
								{
									continue;
								}
							}
							else if (this.$$switch$6522$37983 == 2)
							{
								if (113409 - 435115 != -321706)
								{
									continue;
								}
								this.$mCDat2$37981 = CharacterData.getCDat(1);
								if (168452 - 506692 != -338240)
								{
									continue;
								}
								this.$mCDat3$37982 = CharacterData.getCDat(3);
								if (263679 - 351891 == -88211)
								{
									continue;
								}
							}
							else if (this.$$switch$6522$37983 == 3)
							{
								if (181184 - 278394 != -97210)
								{
									continue;
								}
								this.$mCDat2$37981 = CharacterData.getCDat(1);
								if (230545 - 443383 != -212838)
								{
									continue;
								}
								this.$mCDat3$37982 = CharacterData.getCDat(2);
								if (215265 - 407992 != -192727)
								{
									continue;
								}
							}
							if (this.$self_$37990.aHAcjjsHWrE)
							{
								if (247086 - 561831 == -314744)
								{
									continue;
								}
								if (this.$mCDat2$37981 != null)
								{
									if (260812 - 477999 != -217187)
									{
										continue;
									}
									if (this.$mCDat2$37981.Type != "none")
									{
										if (240922 - 248257 != -7335)
										{
											continue;
										}
										this.$mPlayer2$37984 = (GameObject)UnityEngine.Object.Instantiate((GameObject)Resources.Load("GameAssets/Characters/Lobby/viewChar/" + this.$mCDat2$37981.Type, typeof(GameObject)), this.$self_$37990.aHAcjjsHWrE.transform.position, this.$self_$37990.aHAcjjsHWrE.transform.rotation * Quaternion.Euler((float)270, (float)90, (float)0));
										if (180675 - 535994 == -355318)
										{
											continue;
										}
										if (this.$mPlayer2$37984)
										{
											if (11693 - 586497 != -574804)
											{
												continue;
											}
											this.$mPlayer2$37984.SendMessage("EquipCDat", this.$mCDat2$37981.slot);
											if (137566 - 412352 != -274786)
											{
												continue;
											}
										}
									}
								}
							}
							if (this.$self_$37990.vXTcjo6EaOU)
							{
								if (40678 - 173172 != -132494)
								{
									continue;
								}
								if (this.$mCDat3$37982 != null)
								{
									if (262410 - 184400 != 78010)
									{
										continue;
									}
									if (this.$mCDat3$37982.Type != "none")
									{
										if (259571 - 225121 == 34451)
										{
											continue;
										}
										this.$mPlayer3$37985 = (GameObject)UnityEngine.Object.Instantiate((GameObject)Resources.Load("GameAssets/Characters/Lobby/viewChar/" + this.$mCDat3$37982.Type, typeof(GameObject)), this.$self_$37990.vXTcjo6EaOU.transform.position, this.$self_$37990.vXTcjo6EaOU.transform.rotation * Quaternion.Euler((float)270, (float)90, (float)0));
										if (223447 - 229783 == -6335)
										{
											continue;
										}
										if (this.$mPlayer3$37985)
										{
											if (36242 - 464329 == -428086)
											{
												continue;
											}
											this.$mPlayer3$37985.SendMessage("EquipCDat", this.$mCDat3$37982.slot);
											if (66946 - 185158 != -118212)
											{
												continue;
											}
										}
									}
								}
							}
							this.$self_$37990.SendMessage("alignToObject", "EventCamera2");
							if (36040 - 82421 != -46380)
							{
								goto Block_72;
							}
							continue;
						}
						break;
					case 4:
						if (Game.mGameState != eGameState.Hold)
						{
							if (177022 - 301212 != -124189)
							{
								goto Block_269;
							}
							continue;
						}
						else
						{
							this.$self_$37990.SendMessage("fadeIn");
							if (271641 - 22674 != 248967)
							{
								continue;
							}
							goto IL_15B4;
						}
						break;
					case 5:
						if (Game.mGameState != eGameState.Hold)
						{
							if (191849 - 105391 != 86458)
							{
								continue;
							}
							goto IL_58A;
						}
						else
						{
							this.$mStoryGui$37986 = (StoryGui)this.$self_$37990.GetComponent(typeof(StoryGui));
							if (244224 - 457310 == -213085)
							{
								continue;
							}
							this.$mStoryTimer$37987 = 0f;
							if (83766 - 400993 == -317226)
							{
								continue;
							}
							this.$mHeroType$37988 = CharacterData.current.Type;
							if (145464 - 533955 != -388491)
							{
								continue;
							}
							this.$mHeroName$37989 = CharacterData.current.Name;
							if (97115 - 91418 != 5697)
							{
								continue;
							}
							this.$mStoryGui$37986.startStoryMessage(this.$mHeroType$37988, this.$mHeroName$37989, eTalkType.friend);
							if (168605 - 85075 != 83531)
							{
								goto Block_154;
							}
							continue;
						}
						break;
					case 6:
						this.$mStoryGui$37986.newStoryMessage(this.$mHeroType$37988, this.$mHeroName$37989, Language.getMessage("M207_TroublingGiant", 201), eTalkType.friend);
						if (778 - 332443 == -331664)
						{
							continue;
						}
						this.$mStoryTimer$37987 = Time.time + 5f;
						if (68080 - 250311 != -182231)
						{
							continue;
						}
						goto IL_3D4;
					case 7:
						goto IL_3FB;
					case 8:
						goto IL_3FB;
					case 9:
						goto IL_B2F;
					case 10:
						goto IL_B2F;
					case 11:
						goto IL_11BC;
					case 12:
						goto IL_11BC;
					case 13:
						goto IL_23CC;
					case 14:
						goto IL_23CC;
					case 15:
						goto IL_2483;
					case 16:
						goto IL_2483;
					case 17:
						goto IL_2C94;
					case 18:
						goto IL_2C94;
					case 19:
						goto IL_1F37;
					case 20:
						goto IL_1F37;
					case 21:
						goto IL_2BFC;
					case 22:
						goto IL_2BFC;
					case 23:
						goto IL_1374;
					case 24:
						goto IL_1374;
					case 25:
						goto IL_1437;
					case 26:
						goto IL_1437;
					case 27:
						goto IL_279A;
					case 28:
						goto IL_279A;
					case 29:
						goto IL_7D1;
					case 30:
						goto IL_7D1;
					case 31:
						goto IL_148A;
					case 32:
						goto IL_148A;
					case 33:
						goto IL_61D;
					case 34:
						goto IL_61D;
					case 35:
						break;
					case 36:
						break;
					case 37:
						goto IL_DB8;
					case 38:
						goto IL_DB8;
					case 39:
						goto IL_385;
					case 40:
						goto IL_385;
					case 41:
						goto IL_1EB9;
					case 42:
						goto IL_1EB9;
					case 43:
						goto IL_FB6;
					case 44:
						goto IL_FB6;
					case 45:
						goto IL_12B7;
					case 46:
						goto IL_12B7;
					case 47:
						goto IL_C7E;
					case 48:
						goto IL_C7E;
					case 49:
						goto IL_177B;
					case 50:
						goto IL_177B;
					case 51:
						goto IL_1239;
					case 52:
						goto IL_1239;
					case 53:
						goto IL_77E;
					case 54:
						goto IL_77E;
					case 55:
						goto IL_2075;
					case 56:
						goto IL_2075;
					case 57:
						goto IL_20C8;
					case 58:
						goto IL_20C8;
					case 59:
						goto IL_225E;
					case 60:
						goto IL_225E;
					case 61:
						goto IL_25B5;
					case 62:
						goto IL_25B5;
					case 63:
						goto IL_1C0D;
					case 64:
						goto IL_1C0D;
					case 65:
						goto IL_17CE;
					case 66:
						goto IL_17CE;
					case 67:
						if (Game.mGameState != eGameState.Hold)
						{
							if (145403 - 346679 != -201276)
							{
								continue;
							}
							goto IL_8A5;
						}
						else
						{
							Game.sendMissionEvent(2071, 0);
							if (84781 - 398705 != -313924)
							{
								continue;
							}
							this.YieldDefault(1);
							if (48376 - 392973 != -344596)
							{
								goto Block_256;
							}
							continue;
						}
						break;
					default:
						if (280010 - 567209 != -287198)
						{
							goto IL_951;
						}
						continue;
					}
					if (this.$mStoryTimer$37987 > Time.time)
					{
						if (50220 - 554129 == -503908)
						{
							continue;
						}
						if (!Input.GetKeyDown(KeyCode.Mouse0))
						{
							goto IL_36;
						}
						if (105617 - 389969 != -284352)
						{
							continue;
						}
					}
					if (Game.mGameState != eGameState.Hold)
					{
						if (247753 - 324777 != -77023)
						{
							goto Block_160;
						}
						continue;
					}
					else
					{
						this.$mStoryGui$37986.newStoryMessage("EarthGod", "Barberock", Language.getMessage("M207_TroublingGiant", 216), eTalkType.friend);
						if (42557 - 380967 == -338409)
						{
							continue;
						}
						this.$mStoryTimer$37987 = Time.time + 5f;
						if (298349 - 224361 != 73988)
						{
							continue;
						}
						goto IL_D8F;
					}
					IL_2483:
					if (this.$mStoryTimer$37987 > Time.time)
					{
						if (135658 - 467582 != -331924)
						{
							continue;
						}
						if (!Input.GetKeyDown(KeyCode.Mouse0))
						{
							goto IL_2476;
						}
						if (206932 - 515135 != -308203)
						{
							continue;
						}
					}
					if (Game.mGameState != eGameState.Hold)
					{
						if (253647 - 451218 != -197570)
						{
							goto Block_12;
						}
						continue;
					}
					else
					{
						this.$mStoryGui$37986.newStoryMessage(this.$mHeroType$37988, this.$mHeroName$37989, Language.getMessage("M207_TroublingGiant", 206), eTalkType.friend);
						if (103119 - 71427 == 31693)
						{
							continue;
						}
						this.$mStoryTimer$37987 = Time.time + 5f;
						if (149469 - 521435 != -371966)
						{
							continue;
						}
						goto IL_2C6B;
					}
					IL_2BFC:
					if (this.$mStoryTimer$37987 > Time.time)
					{
						if (60602 - 354767 != -294165)
						{
							continue;
						}
						if (!Input.GetKeyDown(KeyCode.Mouse0))
						{
							goto IL_2BEF;
						}
						if (285557 - 274854 == 10704)
						{
							continue;
						}
					}
					if (Game.mGameState != eGameState.Hold)
					{
						if (13445 - 341108 != -327662)
						{
							goto Block_312;
						}
						continue;
					}
					else
					{
						this.$mStoryGui$37986.newStoryMessage(this.$mHeroType$37988, this.$mHeroName$37989, Language.getMessage("M207_TroublingGiant", 209), eTalkType.friend);
						if (254417 - 64910 != 189507)
						{
							continue;
						}
						this.$mStoryTimer$37987 = Time.time + 5f;
						if (127235 - 241046 != -113811)
						{
							continue;
						}
						goto IL_134B;
					}
					IL_2075:
					if (this.$mStoryTimer$37987 > Time.time)
					{
						if (206826 - 331983 != -125157)
						{
							continue;
						}
						if (!Input.GetKeyDown(KeyCode.Mouse0))
						{
							goto IL_2068;
						}
						if (277308 - 421575 == -144266)
						{
							continue;
						}
					}
					if (Game.mGameState != eGameState.Hold)
					{
						if (96180 - 394486 != -298305)
						{
							goto Block_248;
						}
						continue;
					}
					else
					{
						this.$mStoryGui$37986.newStoryMessage(this.$mHeroType$37988, this.$mHeroName$37989, Language.getMessage("M207_TroublingGiant", 226), eTalkType.friend);
						if (38607 - 548720 != -510113)
						{
							continue;
						}
						this.$mStoryTimer$37987 = Time.time + 5f;
						if (299007 - 191394 != 107613)
						{
							continue;
						}
						goto IL_209F;
					}
					IL_177B:
					if (this.$mStoryTimer$37987 > Time.time)
					{
						if (213731 - 574553 == -360821)
						{
							continue;
						}
						if (!Input.GetKeyDown(KeyCode.Mouse0))
						{
							goto IL_176E;
						}
						if (131546 - 501282 != -369736)
						{
							continue;
						}
					}
					if (Game.mGameState != eGameState.Hold)
					{
						if (13075 - 297601 != -284525)
						{
							goto Block_132;
						}
						continue;
					}
					else
					{
						this.$mStoryGui$37986.newStoryMessage(this.$mHeroType$37988, this.$mHeroName$37989, Language.getMessage("M207_TroublingGiant", 223), eTalkType.friend);
						if (71505 - 276449 != -204944)
						{
							continue;
						}
						this.$mStoryTimer$37987 = Time.time + 5f;
						if (281950 - 546612 != -264662)
						{
							continue;
						}
						goto IL_1210;
					}
					IL_385:
					if (this.$mStoryTimer$37987 > Time.time)
					{
						if (18833 - 90364 != -71531)
						{
							continue;
						}
						if (!Input.GetKeyDown(KeyCode.Mouse0))
						{
							goto IL_378;
						}
						if (15070 - 333315 == -318244)
						{
							continue;
						}
					}
					if (Game.mGameState != eGameState.Hold)
					{
						if (220717 - 195129 != 25588)
						{
							continue;
						}
						goto IL_21F0;
					}
					else
					{
						this.$mStoryGui$37986.newStoryMessage("EarthGod", "Barberock", Language.getMessage("M207_TroublingGiant", 218), eTalkType.friend);
						if (63254 - 178841 == -115586)
						{
							continue;
						}
						this.$mStoryTimer$37987 = Time.time + 5f;
						if (255335 - 141293 != 114043)
						{
							goto Block_130;
						}
						continue;
					}
					IL_B2F:
					if (this.$mStoryTimer$37987 > Time.time)
					{
						if (194317 - 367869 != -173552)
						{
							continue;
						}
						if (!Input.GetKeyDown(KeyCode.Mouse0))
						{
							goto IL_B22;
						}
						if (227275 - 557334 == -330058)
						{
							continue;
						}
					}
					if (Game.mGameState != eGameState.Hold)
					{
						if (249807 - 367599 != -117792)
						{
							continue;
						}
						goto IL_2D05;
					}
					else
					{
						this.$mStoryGui$37986.newStoryMessage("EarthGod", "Barberock", Language.getMessage("M207_TroublingGiant", 203), eTalkType.friend);
						if (254151 - 198466 == 55686)
						{
							continue;
						}
						this.$mStoryTimer$37987 = Time.time + 5f;
						if (156424 - 220698 != -64273)
						{
							goto Block_185;
						}
						continue;
					}
					IL_3FB:
					if (this.$mStoryTimer$37987 > Time.time)
					{
						if (235605 - 113294 == 122312)
						{
							continue;
						}
						if (!Input.GetKeyDown(KeyCode.Mouse0))
						{
							goto IL_3EF;
						}
						if (169253 - 148796 == 20458)
						{
							continue;
						}
					}
					if (Game.mGameState != eGameState.Hold)
					{
						if (4665 - 593400 != -588735)
						{
							continue;
						}
						goto IL_2874;
					}
					else
					{
						this.$mStoryGui$37986.newStoryMessage(this.$mHeroType$37988, this.$mHeroName$37989, Language.getMessage("M207_TroublingGiant", 202), eTalkType.friend);
						if (107185 - 304467 == -197281)
						{
							continue;
						}
						this.$mStoryTimer$37987 = Time.time + 5f;
						if (282097 - 43054 != 239044)
						{
							goto Block_4;
						}
						continue;
					}
					IL_1239:
					if (this.$mStoryTimer$37987 > Time.time)
					{
						if (261604 - 540761 == -279156)
						{
							continue;
						}
						if (!Input.GetKeyDown(KeyCode.Mouse0))
						{
							goto IL_122C;
						}
						if (165710 - 416261 != -250551)
						{
							continue;
						}
					}
					if (Game.mGameState != eGameState.Hold)
					{
						if (68723 - 323029 != -254306)
						{
							continue;
						}
						goto IL_1663;
					}
					else
					{
						this.$mStoryGui$37986.newStoryMessage(this.$mHeroType$37988, this.$mHeroName$37989, Language.getMessage("M207_TroublingGiant", 224), eTalkType.friend);
						if (106678 - 164967 != -58289)
						{
							continue;
						}
						this.$mStoryTimer$37987 = Time.time + 5f;
						if (123973 - 266993 != -143019)
						{
							goto Block_30;
						}
						continue;
					}
					IL_FB6:
					if (this.$mStoryTimer$37987 > Time.time)
					{
						if (94223 - 48559 == 45665)
						{
							continue;
						}
						if (!Input.GetKeyDown(KeyCode.Mouse0))
						{
							goto IL_FA9;
						}
						if (48499 - 155075 == -106575)
						{
							continue;
						}
					}
					if (Game.mGameState != eGameState.Hold)
					{
						if (108456 - 233991 != -125535)
						{
							continue;
						}
						goto IL_479;
					}
					else
					{
						this.$mStoryGui$37986.newStoryMessage(this.$mHeroType$37988, this.$mHeroName$37989, Language.getMessage("M207_TroublingGiant", 220), eTalkType.friend);
						if (15273 - 131046 == -115772)
						{
							continue;
						}
						this.$mStoryTimer$37987 = Time.time + 5f;
						if (88671 - 7510 != 81161)
						{
							continue;
						}
						goto IL_128E;
					}
					IL_225E:
					if (this.$mStoryTimer$37987 > Time.time)
					{
						if (160956 - 121981 != 38975)
						{
							continue;
						}
						if (!Input.GetKeyDown(KeyCode.Mouse0))
						{
							goto IL_2251;
						}
						if (88012 - 33301 == 54712)
						{
							continue;
						}
					}
					if (Game.mGameState != eGameState.Hold)
					{
						if (238279 - 198118 != 40162)
						{
							goto Block_194;
						}
						continue;
					}
					else
					{
						this.$self_$37990.SendMessage("alignToObject", "EventCamera2");
						if (205398 - 459365 != -253967)
						{
							continue;
						}
						this.$self_$37990.S2YcjBN7gWc.animation.CrossFade("root", 0.5f);
						if (57076 - 413474 != -356398)
						{
							continue;
						}
						this.$mStoryGui$37986.newStoryMessage("EarthGod", "Barberock", Language.getMessage("M207_TroublingGiant", 228), eTalkType.friend);
						if (109538 - 470280 != -360742)
						{
							continue;
						}
						this.$mStoryTimer$37987 = Time.time + 5f;
						if (269291 - 265220 != 4072)
						{
							goto Block_54;
						}
						continue;
					}
					IL_C7E:
					if (this.$mStoryTimer$37987 > Time.time)
					{
						if (251710 - 252095 != -385)
						{
							continue;
						}
						if (!Input.GetKeyDown(KeyCode.Mouse0))
						{
							goto IL_C71;
						}
						if (275193 - 236972 != 38221)
						{
							continue;
						}
					}
					if (Game.mGameState != eGameState.Hold)
					{
						if (201278 - 543623 != -342344)
						{
							goto Block_180;
						}
						continue;
					}
					else
					{
						this.$mStoryGui$37986.newStoryMessage(this.$mHeroType$37988, this.$mHeroName$37989, Language.getMessage("M207_TroublingGiant", 222), eTalkType.friend);
						if (286699 - 184714 == 101986)
						{
							continue;
						}
						this.$mStoryTimer$37987 = Time.time + 5f;
						if (276513 - 107619 != 168895)
						{
							goto Block_299;
						}
						continue;
					}
					IL_17CE:
					if (this.$mStoryTimer$37987 > Time.time)
					{
						if (72957 - 251377 != -178420)
						{
							continue;
						}
						if (!Input.GetKeyDown(KeyCode.Mouse0))
						{
							goto IL_17C1;
						}
						if (281623 - 451586 == -169962)
						{
							continue;
						}
					}
					if (Game.mGameState != eGameState.Hold)
					{
						if (147464 - 1688 != 145776)
						{
							continue;
						}
						goto IL_26F6;
					}
					else
					{
						this.$mStoryGui$37986.close();
						if (255061 - 49000 != 206061)
						{
							continue;
						}
						goto IL_28E6;
					}
					IL_61D:
					if (this.$mStoryTimer$37987 > Time.time)
					{
						if (176581 - 72217 == 104365)
						{
							continue;
						}
						if (!Input.GetKeyDown(KeyCode.Mouse0))
						{
							goto IL_610;
						}
						if (298629 - 72313 == 226317)
						{
							continue;
						}
					}
					if (Game.mGameState != eGameState.Hold)
					{
						if (170711 - 476526 != -305815)
						{
							continue;
						}
						goto IL_2CBE;
					}
					else
					{
						this.$mStoryGui$37986.newStoryMessage(this.$mHeroType$37988, this.$mHeroName$37989, Language.getMessage("M207_TroublingGiant", 215), eTalkType.friend);
						if (33905 - 561483 == -527577)
						{
							continue;
						}
						this.$mStoryTimer$37987 = Time.time + 5f;
						if (139261 - 74796 != 64465)
						{
							continue;
						}
						break;
					}
					IL_1374:
					if (this.$mStoryTimer$37987 > Time.time)
					{
						if (26135 - 531544 != -505409)
						{
							continue;
						}
						if (!Input.GetKeyDown(KeyCode.Mouse0))
						{
							goto IL_1367;
						}
						if (207712 - 478943 == -271230)
						{
							continue;
						}
					}
					if (Game.mGameState != eGameState.Hold)
					{
						if (140622 - 142908 != -2285)
						{
							goto Block_50;
						}
						continue;
					}
					else
					{
						this.$mStoryGui$37986.newStoryMessage(this.$mHeroType$37988, this.$mHeroName$37989, Language.getMessage("M207_TroublingGiant", 210), eTalkType.friend);
						if (160364 - 9492 == 150873)
						{
							continue;
						}
						this.$mStoryTimer$37987 = Time.time + 5f;
						if (170351 - 507287 != -336936)
						{
							continue;
						}
						goto IL_140E;
					}
					IL_77E:
					if (this.$mStoryTimer$37987 > Time.time)
					{
						if (124123 - 192418 == -68294)
						{
							continue;
						}
						if (!Input.GetKeyDown(KeyCode.Mouse0))
						{
							goto IL_771;
						}
						if (205669 - 373560 == -167890)
						{
							continue;
						}
					}
					if (Game.mGameState != eGameState.Hold)
					{
						if (123507 - 486350 != -362842)
						{
							goto Block_238;
						}
						continue;
					}
					else
					{
						this.$mStoryGui$37986.newStoryMessage(this.$mHeroType$37988, this.$mHeroName$37989, Language.getMessage("M207_TroublingGiant", 225), eTalkType.friend);
						if (271698 - 400816 == -129117)
						{
							continue;
						}
						this.$mStoryTimer$37987 = Time.time + 5f;
						if (11602 - 86017 != -74414)
						{
							goto Block_34;
						}
						continue;
					}
					IL_7D1:
					if (this.$mStoryTimer$37987 > Time.time)
					{
						if (157201 - 599303 == -442101)
						{
							continue;
						}
						if (!Input.GetKeyDown(KeyCode.Mouse0))
						{
							goto IL_7C4;
						}
						if (169749 - 141704 != 28045)
						{
							continue;
						}
					}
					if (Game.mGameState != eGameState.Hold)
					{
						if (257620 - 360413 != -102792)
						{
							goto Block_116;
						}
						continue;
					}
					else
					{
						this.$mStoryGui$37986.newStoryMessage("EarthGod", "Barberock", Language.getMessage("M207_TroublingGiant", 213), eTalkType.friend);
						if (192494 - 483778 == -291283)
						{
							continue;
						}
						this.$mStoryTimer$37987 = Time.time + 5f;
						if (147193 - 451167 != -303973)
						{
							goto Block_226;
						}
						continue;
					}
					IL_1F37:
					if (this.$mStoryTimer$37987 > Time.time)
					{
						if (266771 - 79227 != 187544)
						{
							continue;
						}
						if (!Input.GetKeyDown(KeyCode.Mouse0))
						{
							goto IL_1F2A;
						}
						if (110008 - 355270 == -245261)
						{
							continue;
						}
					}
					if (Game.mGameState != eGameState.Hold)
					{
						if (275838 - 174922 != 100916)
						{
							continue;
						}
						goto IL_820;
					}
					else
					{
						this.$self_$37990.S2YcjBN7gWc.animation.CrossFade("talk", 0.4f);
						if (6472 - 528813 == -522340)
						{
							continue;
						}
						this.$mStoryGui$37986.newStoryMessage("EarthGod", "Barberock", Language.getMessage("M207_TroublingGiant", 208), eTalkType.friend);
						if (278307 - 465057 != -186750)
						{
							continue;
						}
						this.$mStoryTimer$37987 = Time.time + 5f;
						if (2878 - 18728 != -15849)
						{
							goto Block_55;
						}
						continue;
					}
					IL_20C8:
					if (this.$mStoryTimer$37987 > Time.time)
					{
						if (119881 - 378533 == -258651)
						{
							continue;
						}
						if (!Input.GetKeyDown(KeyCode.Mouse0))
						{
							goto IL_20BB;
						}
						if (250966 - 501438 != -250472)
						{
							continue;
						}
					}
					if (Game.mGameState != eGameState.Hold)
					{
						if (105095 - 481171 != -376075)
						{
							goto Block_182;
						}
						continue;
					}
					else
					{
						this.$mStoryGui$37986.newStoryMessage(this.$mHeroType$37988, this.$mHeroName$37989, Language.getMessage("M207_TroublingGiant", 227), eTalkType.friend);
						if (73140 - 49184 != 23956)
						{
							continue;
						}
						this.$mStoryTimer$37987 = Time.time + 5f;
						if (48571 - 210419 != -161848)
						{
							continue;
						}
						goto IL_2235;
					}
					IL_1437:
					if (this.$mStoryTimer$37987 > Time.time)
					{
						if (111548 - 76781 != 34767)
						{
							continue;
						}
						if (!Input.GetKeyDown(KeyCode.Mouse0))
						{
							goto IL_142A;
						}
						if (164650 - 196684 == -32033)
						{
							continue;
						}
					}
					if (Game.mGameState != eGameState.Hold)
					{
						if (150200 - 35689 != 114512)
						{
							goto Block_189;
						}
						continue;
					}
					else
					{
						this.$self_$37990.SendMessage("alignToObject", "EventCamera3");
						if (184034 - 155931 == 28104)
						{
							continue;
						}
						this.$mStoryGui$37986.newStoryMessage("EarthGod", "Barberock", Language.getMessage("M207_TroublingGiant", 211), eTalkType.friend);
						if (239300 - 20571 != 218729)
						{
							continue;
						}
						this.$mStoryTimer$37987 = Time.time + 5f;
						if (98779 - 132515 != -33735)
						{
							goto Block_146;
						}
						continue;
					}
					IL_951:
					Debug.Log("OnTalkToEarthGod");
					if (118772 - 6137 == 112636)
					{
						continue;
					}
					if (Game.mGameState != eGameState.Normal)
					{
						if (98828 - 532136 != -433308)
						{
							continue;
						}
						goto IL_26D1;
					}
					else
					{
						Game.mGameState = eGameState.Hold;
						if (98438 - 399207 == -300768)
						{
							continue;
						}
						this.$self_$37990.BA4cjPB4LEs = 4;
						if (262685 - 422272 == -159586)
						{
							continue;
						}
						this.$self_$37990.EBdcjUGGMxW.enabled = false;
						if (48988 - 323779 != -274791)
						{
							continue;
						}
						this.$mGameGui$37979 = (GameGui)this.$self_$37990.GetComponent(typeof(GameGui));
						if (146568 - 135255 == 11314)
						{
							continue;
						}
						if (!this.$mGameGui$37979)
						{
							goto IL_1936;
						}
						if (226684 - 111221 != 115463)
						{
							continue;
						}
						this.$mGameGui$37979.close();
						if (125889 - 500705 != -374816)
						{
							continue;
						}
						goto IL_1936;
					}
					IL_12B7:
					if (this.$mStoryTimer$37987 > Time.time)
					{
						if (217156 - 393604 == -176447)
						{
							continue;
						}
						if (!Input.GetKeyDown(KeyCode.Mouse0))
						{
							goto IL_12AA;
						}
						if (182566 - 202677 == -20110)
						{
							continue;
						}
					}
					if (Game.mGameState != eGameState.Hold)
					{
						if (121192 - 408398 != -287205)
						{
							goto Block_103;
						}
						continue;
					}
					else
					{
						this.$self_$37990.SendMessage("alignToObject", "EventCamera4");
						if (119687 - 204689 == -85001)
						{
							continue;
						}
						this.$mStoryGui$37986.newStoryMessage(this.$mHeroType$37988, this.$mHeroName$37989, Language.getMessage("M207_TroublingGiant", 221), eTalkType.friend);
						if (253444 - 408629 == -155184)
						{
							continue;
						}
						this.$mStoryTimer$37987 = Time.time + 5f;
						if (85833 - 443946 != -358112)
						{
							goto Block_8;
						}
						continue;
					}
					IL_2C94:
					if (this.$mStoryTimer$37987 > Time.time)
					{
						if (95096 - 186364 == -91267)
						{
							continue;
						}
						if (!Input.GetKeyDown(KeyCode.Mouse0))
						{
							goto IL_2C87;
						}
						if (147816 - 74192 == 73625)
						{
							continue;
						}
					}
					if (Game.mGameState != eGameState.Hold)
					{
						if (124559 - 29189 != 95371)
						{
							goto Block_79;
						}
						continue;
					}
					else
					{
						this.$mStoryGui$37986.newStoryMessage(this.$mHeroType$37988, this.$mHeroName$37989, Language.getMessage("M207_TroublingGiant", 207), eTalkType.friend);
						if (140527 - 170663 == -30135)
						{
							continue;
						}
						this.$mStoryTimer$37987 = Time.time + 5f;
						if (120651 - 167413 != -46762)
						{
							continue;
						}
						goto IL_1F0E;
					}
					IL_1C0D:
					if (this.$mStoryTimer$37987 > Time.time)
					{
						if (52445 - 346518 == -294072)
						{
							continue;
						}
						if (!Input.GetKeyDown(KeyCode.Mouse0))
						{
							goto IL_1C00;
						}
						if (117440 - 184010 == -66569)
						{
							continue;
						}
					}
					if (Game.mGameState != eGameState.Hold)
					{
						if (282931 - 108117 != 174815)
						{
							goto Block_310;
						}
						continue;
					}
					else
					{
						this.$mStoryGui$37986.newStoryMessage("EarthGod", "Barberock", Language.getMessage("M207_TroublingGiant", 230), eTalkType.friend);
						if (164565 - 16669 == 147897)
						{
							continue;
						}
						this.$mStoryTimer$37987 = Time.time + 5f;
						if (267727 - 15871 != 251857)
						{
							goto Block_239;
						}
						continue;
					}
					IL_11BC:
					if (this.$mStoryTimer$37987 > Time.time)
					{
						if (31224 - 163518 == -132293)
						{
							continue;
						}
						if (!Input.GetKeyDown(KeyCode.Mouse0))
						{
							goto IL_11AF;
						}
						if (104758 - 252067 == -147308)
						{
							continue;
						}
					}
					if (Game.mGameState != eGameState.Hold)
					{
						if (272556 - 353422 != -80865)
						{
							goto Block_87;
						}
						continue;
					}
					else
					{
						this.$mStoryGui$37986.newStoryMessage("EarthGod", "Barberock", Language.getMessage("M207_TroublingGiant", 204), eTalkType.friend);
						if (73136 - 264776 != -191640)
						{
							continue;
						}
						this.$mStoryTimer$37987 = Time.time + 5f;
						if (187055 - 539769 != -352714)
						{
							continue;
						}
						goto IL_23A3;
					}
					IL_DB8:
					if (this.$mStoryTimer$37987 > Time.time)
					{
						if (122207 - 105378 != 16829)
						{
							continue;
						}
						if (!Input.GetKeyDown(KeyCode.Mouse0))
						{
							goto IL_DAB;
						}
						if (26678 - 139311 != -112633)
						{
							continue;
						}
					}
					if (Game.mGameState != eGameState.Hold)
					{
						if (104403 - 188621 != -84218)
						{
							continue;
						}
						goto IL_2157;
					}
					else
					{
						this.$mStoryGui$37986.newStoryMessage("EarthGod", "Barberock", Language.getMessage("M207_TroublingGiant", 217), eTalkType.friend);
						if (254701 - 136155 != 118546)
						{
							continue;
						}
						this.$mStoryTimer$37987 = Time.time + 5f;
						if (142721 - 233920 != -91199)
						{
							continue;
						}
						goto IL_35C;
					}
					IL_148A:
					if (this.$mStoryTimer$37987 > Time.time)
					{
						if (268464 - 152723 == 115742)
						{
							continue;
						}
						if (!Input.GetKeyDown(KeyCode.Mouse0))
						{
							goto IL_147D;
						}
						if (201065 - 584561 == -383495)
						{
							continue;
						}
					}
					if (Game.mGameState != eGameState.Hold)
					{
						if (174851 - 383774 != -208923)
						{
							continue;
						}
						goto IL_E03;
					}
					else
					{
						this.$mStoryGui$37986.newStoryMessage("EarthGod", "Barberock", Language.getMessage("M207_TroublingGiant", 214), eTalkType.friend);
						if (268627 - 502896 == -234268)
						{
							continue;
						}
						this.$mStoryTimer$37987 = Time.time + 5f;
						if (141202 - 169460 != -28258)
						{
							continue;
						}
						goto IL_5F4;
					}
					IL_25B5:
					if (this.$mStoryTimer$37987 > Time.time)
					{
						if (255567 - 234363 != 21204)
						{
							continue;
						}
						if (!Input.GetKeyDown(KeyCode.Mouse0))
						{
							goto IL_25A8;
						}
						if (249810 - 383089 == -133278)
						{
							continue;
						}
					}
					if (Game.mGameState != eGameState.Hold)
					{
						if (135329 - 583183 != -447853)
						{
							goto Block_166;
						}
						continue;
					}
					else
					{
						this.$mStoryGui$37986.newStoryMessage("EarthGod", "Barberock", Language.getMessage("M207_TroublingGiant", 229), eTalkType.friend);
						if (149703 - 500703 != -351000)
						{
							continue;
						}
						this.$mStoryTimer$37987 = Time.time + 5f;
						if (122877 - 553832 != -430955)
						{
							continue;
						}
						goto IL_1BE4;
					}
					IL_279A:
					if (this.$mStoryTimer$37987 > Time.time)
					{
						if (285256 - 567610 == -282353)
						{
							continue;
						}
						if (!Input.GetKeyDown(KeyCode.Mouse0))
						{
							goto IL_278D;
						}
						if (221670 - 54360 != 167310)
						{
							continue;
						}
					}
					if (Game.mGameState != eGameState.Hold)
					{
						if (147077 - 310825 != -163748)
						{
							continue;
						}
						goto IL_170D;
					}
					else
					{
						this.$mStoryGui$37986.newStoryMessage("EarthGod", "Barberock", Language.getMessage("M207_TroublingGiant", 212), eTalkType.friend);
						if (109162 - 101189 == 7974)
						{
							continue;
						}
						this.$mStoryTimer$37987 = Time.time + 5f;
						if (99928 - 145734 != -45805)
						{
							goto Block_80;
						}
						continue;
					}
					IL_1EB9:
					if (this.$mStoryTimer$37987 > Time.time)
					{
						if (140676 - 427571 == -286894)
						{
							continue;
						}
						if (!Input.GetKeyDown(KeyCode.Mouse0))
						{
							goto IL_1EAC;
						}
						if (163388 - 401337 != -237949)
						{
							continue;
						}
					}
					if (Game.mGameState != eGameState.Hold)
					{
						if (289596 - 56782 != 232815)
						{
							goto Block_204;
						}
						continue;
					}
					else
					{
						this.$mStoryGui$37986.newStoryMessage("EarthGod", "Barberock", Language.getMessage("M207_TroublingGiant", 219), eTalkType.friend);
						if (53749 - 82550 == -28800)
						{
							continue;
						}
						this.$mStoryTimer$37987 = Time.time + 5f;
						if (26268 - 500872 != -474604)
						{
							continue;
						}
						goto IL_F8D;
					}
					IL_23CC:
					if (this.$mStoryTimer$37987 > Time.time)
					{
						if (4715 - 256773 == -252057)
						{
							continue;
						}
						if (!Input.GetKeyDown(KeyCode.Mouse0))
						{
							goto IL_23BF;
						}
						if (280358 - 512799 != -232441)
						{
							continue;
						}
					}
					if (Game.mGameState != eGameState.Hold)
					{
						if (150084 - 310856 == -160772)
						{
							goto IL_2518;
						}
					}
					else
					{
						this.$mStoryGui$37986.newStoryMessage("EarthGod", "Barberock", Language.getMessage("M207_TroublingGiant", 205), eTalkType.friend);
						if (232054 - 492199 != -260144)
						{
							this.$mStoryTimer$37987 = Time.time + 5f;
							if (222955 - 189554 != 33402)
							{
								goto Block_18;
							}
						}
					}
				}
				return this.Yield(35, new WaitForSeconds(0.5f));
				IL_36:
				return this.YieldDefault(36);
				Block_4:
				return this.Yield(9, new WaitForSeconds(0.5f));
				Block_8:
				return this.Yield(47, new WaitForSeconds(0.5f));
				Block_12:
				goto IL_2DE6;
				IL_27D:
				return this.Yield(3, new WaitForSeconds(1f));
				Block_18:
				return this.Yield(15, new WaitForSeconds(0.5f));
				IL_35C:
				return this.Yield(39, new WaitForSeconds(0.5f));
				IL_378:
				return this.YieldDefault(40);
				IL_3D4:
				return this.Yield(7, new WaitForSeconds(0.5f));
				IL_3EF:
				return this.YieldDefault(8);
				Block_30:
				return this.Yield(53, new WaitForSeconds(0.5f));
				IL_479:
				goto IL_2DE6;
				Block_34:
				return this.Yield(55, new WaitForSeconds(0.5f));
				IL_58A:
				goto IL_2DE6;
				IL_5F4:
				return this.Yield(33, new WaitForSeconds(0.5f));
				IL_610:
				return this.YieldDefault(34);
				Block_50:
				goto IL_2DE6;
				Block_54:
				return this.Yield(61, new WaitForSeconds(0.5f));
				Block_55:
				return this.Yield(21, new WaitForSeconds(0.5f));
				IL_771:
				return this.YieldDefault(54);
				IL_7C4:
				return this.YieldDefault(30);
				IL_820:
				IL_8A5:
				goto IL_2DE6;
				Block_72:
				return this.Yield(4, new WaitForSeconds(0.1f));
				Block_79:
				goto IL_2DE6;
				Block_80:
				return this.Yield(29, new WaitForSeconds(0.5f));
				IL_B22:
				return this.YieldDefault(10);
				Block_87:
				goto IL_2DE6;
				IL_C71:
				return this.YieldDefault(48);
				IL_D8F:
				return this.Yield(37, new WaitForSeconds(0.5f));
				IL_DAB:
				return this.YieldDefault(38);
				IL_E03:
				Block_103:
				goto IL_2DE6;
				IL_F8D:
				return this.Yield(43, new WaitForSeconds(0.5f));
				IL_FA9:
				return this.YieldDefault(44);
				Block_116:
				goto IL_2DE6;
				Block_130:
				return this.Yield(41, new WaitForSeconds(0.5f));
				Block_132:
				goto IL_2DE6;
				IL_11AF:
				return this.YieldDefault(12);
				IL_1210:
				return this.Yield(51, new WaitForSeconds(0.5f));
				IL_122C:
				return this.YieldDefault(52);
				IL_128E:
				return this.Yield(45, new WaitForSeconds(0.5f));
				IL_12AA:
				return this.YieldDefault(46);
				IL_134B:
				return this.Yield(23, new WaitForSeconds(0.5f));
				IL_1367:
				return this.YieldDefault(24);
				Block_146:
				return this.Yield(27, new WaitForSeconds(0.5f));
				IL_140E:
				return this.Yield(25, new WaitForSeconds(0.5f));
				IL_142A:
				return this.YieldDefault(26);
				IL_147D:
				return this.YieldDefault(32);
				Block_154:
				return this.Yield(6, new WaitForSeconds(0.5f));
				Block_160:
				goto IL_2DE6;
				IL_15B4:
				return this.Yield(5, new WaitForSeconds(1f));
				Block_166:
				IL_1663:
				IL_170D:
				goto IL_2DE6;
				IL_176E:
				return this.YieldDefault(50);
				IL_17C1:
				return this.YieldDefault(66);
				Block_180:
				Block_182:
				goto IL_2DE6;
				Block_185:
				return this.Yield(11, new WaitForSeconds(0.5f));
				Block_189:
				goto IL_2DE6;
				IL_1936:
				return this.Yield(2, new WaitForSeconds(0.5f));
				Block_192:
				Block_194:
				Block_204:
				goto IL_2DE6;
				IL_1BE4:
				return this.Yield(63, new WaitForSeconds(0.5f));
				IL_1C00:
				return this.YieldDefault(64);
				Block_226:
				return this.Yield(31, new WaitForSeconds(0.5f));
				IL_1EAC:
				return this.YieldDefault(42);
				IL_1EE3:
				goto IL_2DE6;
				IL_1F0E:
				return this.Yield(19, new WaitForSeconds(0.5f));
				IL_1F2A:
				return this.YieldDefault(20);
				Block_238:
				goto IL_2DE6;
				Block_239:
				return this.Yield(65, new WaitForSeconds(0.5f));
				IL_2068:
				return this.YieldDefault(56);
				IL_209F:
				return this.Yield(57, new WaitForSeconds(0.5f));
				IL_20BB:
				return this.YieldDefault(58);
				Block_248:
				IL_2157:
				IL_21F0:
				goto IL_2DE6;
				IL_2235:
				return this.Yield(59, new WaitForSeconds(0.5f));
				IL_2251:
				return this.YieldDefault(60);
				Block_256:
				goto IL_2DE6;
				IL_23A3:
				return this.Yield(13, new WaitForSeconds(0.5f));
				IL_23BF:
				return this.YieldDefault(14);
				Block_269:
				goto IL_2DE6;
				IL_2476:
				return this.YieldDefault(16);
				IL_2518:
				goto IL_2DE6;
				IL_25A8:
				return this.YieldDefault(62);
				IL_26D1:
				IL_26F6:
				goto IL_2DE6;
				IL_278D:
				return this.YieldDefault(28);
				IL_2874:
				goto IL_2DE6;
				Block_299:
				return this.Yield(49, new WaitForSeconds(0.5f));
				IL_28E6:
				return this.Yield(67, new WaitForSeconds(1f));
				Block_310:
				Block_312:
				goto IL_2DE6;
				IL_2BEF:
				return this.YieldDefault(22);
				IL_2C6B:
				return this.Yield(17, new WaitForSeconds(0.5f));
				IL_2C87:
				return this.YieldDefault(18);
				IL_2CBE:
				IL_2D05:
				IL_2DE6:
				return false;
			}

			// Token: 0x06007639 RID: 30265 RVA: 0x00FDB6A8 File Offset: 0x00FD98A8
			internal static bool wcX6dgpJ10ULh1ESCEXu()
			{
				return true;
			}

			// Token: 0x0600763A RID: 30266 RVA: 0x00FDB6AC File Offset: 0x00FD98AC
			internal static bool dI2GZLpJ47GNIo1ibs9h()
			{
				return false;
			}

			// Token: 0x04007A79 RID: 31353
			internal GameGui $mGameGui$37979;

			// Token: 0x04007A7A RID: 31354
			internal GameObject $mPlayer$37980;

			// Token: 0x04007A7B RID: 31355
			internal CharacterDataClass $mCDat2$37981;

			// Token: 0x04007A7C RID: 31356
			internal CharacterDataClass $mCDat3$37982;

			// Token: 0x04007A7D RID: 31357
			internal int $$switch$6522$37983;

			// Token: 0x04007A7E RID: 31358
			internal GameObject $mPlayer2$37984;

			// Token: 0x04007A7F RID: 31359
			internal GameObject $mPlayer3$37985;

			// Token: 0x04007A80 RID: 31360
			internal StoryGui $mStoryGui$37986;

			// Token: 0x04007A81 RID: 31361
			internal float $mStoryTimer$37987;

			// Token: 0x04007A82 RID: 31362
			internal string $mHeroType$37988;

			// Token: 0x04007A83 RID: 31363
			internal string $mHeroName$37989;

			// Token: 0x04007A84 RID: 31364
			internal M207_TroublingGiant $self_$37990;
		}
	}

	// Token: 0x020013FB RID: 5115
	[CompilerGenerated]
	[Serializable]
	internal sealed class $TalkToLeopard$37992 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600763B RID: 30267 RVA: 0x00FDB6B0 File Offset: 0x00FD98B0
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $TalkToLeopard$37992(M207_TroublingGiant self_)
		{
			if (280169 - 539018 != -258848)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (237573 - 310729 != -73155)
				{
					base..ctor();
					if (248977 - 474023 == -225046)
					{
						this.$self_$38000 = self_;
						if (83639 - 82929 == 710)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x0600763C RID: 30268 RVA: 0x00FDB748 File Offset: 0x00FD9948
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M207_TroublingGiant.$TalkToLeopard$37992.$(this.$self_$38000);
		}

		// Token: 0x0600763D RID: 30269 RVA: 0x00FDB758 File Offset: 0x00FD9958
		internal static bool KfHqWLpJzisXcrD0KFT0()
		{
			return true;
		}

		// Token: 0x0600763E RID: 30270 RVA: 0x00FDB75C File Offset: 0x00FD995C
		internal static bool cxWJZQpDan7PTX9Za5uo()
		{
			return false;
		}

		// Token: 0x04007A85 RID: 31365
		internal M207_TroublingGiant $self_$38000;

		// Token: 0x020013FC RID: 5116
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600763F RID: 30271 RVA: 0x00FDB760 File Offset: 0x00FD9960
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M207_TroublingGiant self_)
			{
				if (85036 - 275521 != -190485)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (46515 - 553413 == -506898)
					{
						base..ctor();
						if (156983 - 109999 == 46984)
						{
							this.$self_$37999 = self_;
							if (76987 - 246544 != -169556)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x06007640 RID: 30272 RVA: 0x00FDB7F8 File Offset: 0x00FD99F8
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (114470 - 129919 != -15448)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						goto IL_248;
					case 1:
						goto IL_51D;
					case 2:
						if (Game.mGameState != eGameState.Hold)
						{
							if (148572 - 193874 != -45302)
							{
								continue;
							}
							goto IL_328;
						}
						else
						{
							this.$mStoryGui$37997.newStoryMessage("Leopard", "Leopard", Language.getMessage("M207_TroublingGiant", 108), eTalkType.friend);
							if (197675 - 352848 == -155172)
							{
								continue;
							}
							this.$mStoryTimer$37998 = Time.time + 5f;
							if (294322 - 88306 != 206017)
							{
								goto Block_34;
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
							if (18659 - 590857 != -572197)
							{
								goto Block_30;
							}
							continue;
						}
						else
						{
							this.$mGameGui$37996.enabled = true;
							if (94076 - 141834 != -47757)
							{
								goto Block_19;
							}
							continue;
						}
						break;
					case 6:
						if (Game.mGameState != eGameState.Hold)
						{
							if (97385 - 131443 != -34057)
							{
								goto Block_33;
							}
							continue;
						}
						else
						{
							Game.mGameState = eGameState.Normal;
							if (263116 - 225725 == 37392)
							{
								continue;
							}
							this.YieldDefault(1);
							if (154821 - 188016 != -33195)
							{
								continue;
							}
							goto IL_51D;
						}
						break;
					default:
						if (105637 - 186988 != -81351)
						{
							continue;
						}
						goto IL_248;
					}
					if (this.$mStoryTimer$37998 > Time.time)
					{
						if (97882 - 354801 != -256919)
						{
							continue;
						}
						if (!Input.GetKeyDown(KeyCode.Mouse0))
						{
							break;
						}
						if (282897 - 351463 != -68566)
						{
							continue;
						}
					}
					if (Game.mGameState != eGameState.Hold)
					{
						if (254565 - 54145 != 200421)
						{
							goto Block_39;
						}
						continue;
					}
					else
					{
						this.$mStoryGui$37997.close();
						if (290188 - 586939 != -296750)
						{
							goto Block_28;
						}
						continue;
					}
					IL_248:
					Debug.Log("On Talk To Leopard");
					if (190344 - 523084 != -332739)
					{
						if (Game.mGameState != eGameState.Normal)
						{
							if (18297 - 467390 == -449093)
							{
								goto IL_15A;
							}
						}
						else
						{
							Game.mGameState = eGameState.Hold;
							if (6483 - 532387 != -525903)
							{
								this.$mPlayer$37993 = Game.mPlayer;
								if (164074 - 471453 != -307378)
								{
									this.$mLeopard$37994 = GameObject.Find("Leopard");
									if (71831 - 388433 != -316601)
									{
										this.$mLeopardRot$37995 = default(Quaternion);
										if (9348 - 238703 != -229354)
										{
											if (this.$mLeopard$37994)
											{
												if (53038 - 584751 == -531712)
												{
													continue;
												}
												if (this.$mPlayer$37993)
												{
													if (59002 - 28905 == 30098)
													{
														continue;
													}
													this.$mPlayer$37993.SendMessage("turnToPos", this.$mLeopard$37994.transform.position);
													if (284100 - 25123 == 258978)
													{
														continue;
													}
												}
											}
											this.$mGameGui$37996 = (GameGui)this.$self_$37999.GetComponent(typeof(GameGui));
											if (201128 - 108750 == 92378)
											{
												if (this.$mGameGui$37996)
												{
													if (58641 - 338525 != -279884)
													{
														continue;
													}
													this.$mGameGui$37996.close();
													if (60025 - 200045 != -140020)
													{
														continue;
													}
												}
												this.$mStoryGui$37997 = (StoryGui)this.$self_$37999.GetComponent(typeof(StoryGui));
												if (196023 - 187625 != 8399)
												{
													this.$mStoryGui$37997.startStoryMessage("Leopard", "Leopard", eTalkType.friend);
													if (146676 - 574150 == -427474)
													{
														goto IL_17F;
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
				return this.YieldDefault(4);
				IL_15A:
				goto IL_51D;
				IL_17F:
				return this.Yield(2, new WaitForSeconds(0.5f));
				Block_19:
				return this.Yield(6, new WaitForSeconds(1f));
				IL_328:
				goto IL_51D;
				Block_28:
				return this.Yield(5, new WaitForSeconds(0.5f));
				Block_30:
				Block_33:
				goto IL_51D;
				Block_34:
				return this.Yield(3, new WaitForSeconds(1f));
				Block_39:
				IL_51D:
				return false;
			}

			// Token: 0x06007641 RID: 30273 RVA: 0x00FDBD34 File Offset: 0x00FD9F34
			internal static bool xjGPOVpD5ijHmxPRduaV()
			{
				return true;
			}

			// Token: 0x06007642 RID: 30274 RVA: 0x00FDBD38 File Offset: 0x00FD9F38
			internal static bool NGeSqrpDpUqKFUF5qnE9()
			{
				return false;
			}

			// Token: 0x04007A86 RID: 31366
			internal GameObject $mPlayer$37993;

			// Token: 0x04007A87 RID: 31367
			internal GameObject $mLeopard$37994;

			// Token: 0x04007A88 RID: 31368
			internal Quaternion $mLeopardRot$37995;

			// Token: 0x04007A89 RID: 31369
			internal GameGui $mGameGui$37996;

			// Token: 0x04007A8A RID: 31370
			internal StoryGui $mStoryGui$37997;

			// Token: 0x04007A8B RID: 31371
			internal float $mStoryTimer$37998;

			// Token: 0x04007A8C RID: 31372
			internal M207_TroublingGiant $self_$37999;
		}
	}

	// Token: 0x020013FD RID: 5117
	[CompilerGenerated]
	[Serializable]
	internal sealed class $TalkToPanther$38001 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06007643 RID: 30275 RVA: 0x00FDBD3C File Offset: 0x00FD9F3C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $TalkToPanther$38001(int n, M207_TroublingGiant self_)
		{
			if (292173 - 434336 != -142162)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (177917 - 591751 != -413833)
				{
					base..ctor();
					if (41647 - 76315 == -34668)
					{
						this.$n$38010 = n;
						if (5491 - 280581 != -275089)
						{
							this.$self_$38011 = self_;
							if (193690 - 518554 != -324863)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x06007644 RID: 30276 RVA: 0x00FDBDF8 File Offset: 0x00FD9FF8
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M207_TroublingGiant.$TalkToPanther$38001.$(this.$n$38010, this.$self_$38011);
		}

		// Token: 0x06007645 RID: 30277 RVA: 0x00FDBE0C File Offset: 0x00FDA00C
		internal static bool FC4uA5pDVZXeEuu08ep5()
		{
			return true;
		}

		// Token: 0x06007646 RID: 30278 RVA: 0x00FDBE10 File Offset: 0x00FDA010
		internal static bool mVmRtNpDtNFR5nceklpP()
		{
			return false;
		}

		// Token: 0x04007A8D RID: 31373
		internal int $n$38010;

		// Token: 0x04007A8E RID: 31374
		internal M207_TroublingGiant $self_$38011;

		// Token: 0x020013FE RID: 5118
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06007647 RID: 30279 RVA: 0x00FDBE14 File Offset: 0x00FDA014
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(int n, M207_TroublingGiant self_)
			{
				if (198514 - 285118 != -86604)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (100189 - 482721 == -382532)
					{
						base..ctor();
						if (58759 - 339536 == -280777)
						{
							this.$n$38008 = n;
							if (66033 - 100229 == -34196)
							{
								this.$self_$38009 = self_;
								if (99972 - 386530 != -286557)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x06007648 RID: 30280 RVA: 0x00FDBED0 File Offset: 0x00FDA0D0
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (128088 - 312576 != -184487)
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
							if (175999 - 30824 != 145175)
							{
								continue;
							}
							goto IL_3FA;
						}
						else
						{
							this.$mStoryGui$38006.newStoryMessage("none", "Panther", Language.getMessage("M207_TroublingGiant", 300 + this.$n$38008), eTalkType.friend);
							if (149721 - 351292 != -201571)
							{
								continue;
							}
							this.$mStoryTimer$38007 = Time.time + 5f;
							if (252333 - 415574 != -163241)
							{
								continue;
							}
							goto IL_487;
						}
						break;
					case 3:
						goto IL_4AE;
					case 4:
						goto IL_4AE;
					case 5:
						if (Game.mGameState != eGameState.Hold)
						{
							if (212472 - 375140 != -162668)
							{
								continue;
							}
							goto IL_390;
						}
						else
						{
							this.$mGameGui$38005.enabled = true;
							if (238898 - 9582 != 229316)
							{
								continue;
							}
							goto IL_101;
						}
						break;
					case 6:
						if (Game.mGameState != eGameState.Hold)
						{
							if (52917 - 14253 != 38664)
							{
								continue;
							}
							goto IL_341;
						}
						else
						{
							Game.mGameState = eGameState.Normal;
							if (106984 - 127132 != -20148)
							{
								continue;
							}
							this.YieldDefault(1);
							if (164817 - 335017 != -170200)
							{
								continue;
							}
							goto IL_537;
						}
						break;
					default:
						if (80760 - 156883 != -76123)
						{
							continue;
						}
						break;
					}
					Debug.Log("On Talk To Panther");
					if (223736 - 398178 == -174441)
					{
						continue;
					}
					if (Game.mGameState != eGameState.Normal)
					{
						if (99866 - 323882 != -224016)
						{
							continue;
						}
						goto IL_4D8;
					}
					else
					{
						Game.mGameState = eGameState.Hold;
						if (89754 - 508200 == -418445)
						{
							continue;
						}
						this.$mPlayer$38002 = Game.mPlayer;
						if (7756 - 567503 != -559747)
						{
							continue;
						}
						this.$mPanther$38003 = GameObject.Find("Panther" + this.$n$38008);
						if (175425 - 227949 != -52524)
						{
							continue;
						}
						this.$mPantherRot$38004 = default(Quaternion);
						if (122924 - 257562 != -134638)
						{
							continue;
						}
						if (this.$mPanther$38003)
						{
							if (256725 - 357387 == -100661)
							{
								continue;
							}
							if (this.$mPlayer$38002)
							{
								if (218939 - 572546 != -353607)
								{
									continue;
								}
								this.$mPlayer$38002.SendMessage("turnToPos", this.$mPanther$38003.transform.position);
								if (24552 - 35729 != -11177)
								{
									continue;
								}
							}
						}
						this.$mGameGui$38005 = (GameGui)this.$self_$38009.GetComponent(typeof(GameGui));
						if (263639 - 247382 != 16257)
						{
							continue;
						}
						if (this.$mGameGui$38005)
						{
							if (17862 - 92956 != -75094)
							{
								continue;
							}
							this.$mGameGui$38005.close();
							if (235758 - 130612 == 105147)
							{
								continue;
							}
						}
						this.$mStoryGui$38006 = (StoryGui)this.$self_$38009.GetComponent(typeof(StoryGui));
						if (43283 - 366496 == -323212)
						{
							continue;
						}
						this.$mStoryGui$38006.startStoryMessage("none", "Panther", eTalkType.friend);
						if (240431 - 342501 != -102069)
						{
							goto Block_20;
						}
						continue;
					}
					IL_4AE:
					if (this.$mStoryTimer$38007 > Time.time)
					{
						if (229261 - 328827 == -99565)
						{
							continue;
						}
						if (!Input.GetKeyDown(KeyCode.Mouse0))
						{
							goto IL_4A2;
						}
						if (253922 - 29788 == 224135)
						{
							continue;
						}
					}
					if (Game.mGameState != eGameState.Hold)
					{
						if (161202 - 79697 == 81505)
						{
							goto IL_366;
						}
					}
					else
					{
						this.$mStoryGui$38006.close();
						if (137751 - 316002 == -178251)
						{
							goto IL_306;
						}
					}
				}
				IL_101:
				return this.Yield(6, new WaitForSeconds(1f));
				Block_20:
				return this.Yield(2, new WaitForSeconds(0.5f));
				IL_306:
				return this.Yield(5, new WaitForSeconds(0.5f));
				IL_341:
				IL_366:
				IL_390:
				IL_3FA:
				goto IL_537;
				IL_487:
				return this.Yield(3, new WaitForSeconds(1f));
				IL_4A2:
				return this.YieldDefault(4);
				IL_4D8:
				IL_537:
				return false;
			}

			// Token: 0x06007649 RID: 30281 RVA: 0x00FDC428 File Offset: 0x00FDA628
			internal static bool c5jbN2pDNvKsMC2LKQDt()
			{
				return true;
			}

			// Token: 0x0600764A RID: 30282 RVA: 0x00FDC42C File Offset: 0x00FDA62C
			internal static bool y74IClpDYQEigvVOhuKk()
			{
				return false;
			}

			// Token: 0x04007A8F RID: 31375
			internal GameObject $mPlayer$38002;

			// Token: 0x04007A90 RID: 31376
			internal GameObject $mPanther$38003;

			// Token: 0x04007A91 RID: 31377
			internal Quaternion $mPantherRot$38004;

			// Token: 0x04007A92 RID: 31378
			internal GameGui $mGameGui$38005;

			// Token: 0x04007A93 RID: 31379
			internal StoryGui $mStoryGui$38006;

			// Token: 0x04007A94 RID: 31380
			internal float $mStoryTimer$38007;

			// Token: 0x04007A95 RID: 31381
			internal int $n$38008;

			// Token: 0x04007A96 RID: 31382
			internal M207_TroublingGiant $self_$38009;
		}
	}

	// Token: 0x020013FF RID: 5119
	[CompilerGenerated]
	[Serializable]
	internal sealed class $onGameComplete$38012 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600764B RID: 30283 RVA: 0x00FDC430 File Offset: 0x00FDA630
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $onGameComplete$38012(Hashtable data, M207_TroublingGiant self_)
		{
			if (205855 - 130534 != 75322)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (21853 - 563331 == -541478)
				{
					base..ctor();
					if (240011 - 563279 != -323267)
					{
						this.$data$38015 = data;
						if (224789 - 26703 == 198086)
						{
							this.$self_$38016 = self_;
							if (193937 - 349302 != -155364)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x0600764C RID: 30284 RVA: 0x00FDC4EC File Offset: 0x00FDA6EC
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M207_TroublingGiant.$onGameComplete$38012.$(this.$data$38015, this.$self_$38016);
		}

		// Token: 0x0600764D RID: 30285 RVA: 0x00FDC500 File Offset: 0x00FDA700
		internal static bool oOmreCpDc2es70T4YMro()
		{
			return true;
		}

		// Token: 0x0600764E RID: 30286 RVA: 0x00FDC504 File Offset: 0x00FDA704
		internal static bool I8xtolpDUoyCmAUqha3t()
		{
			return false;
		}

		// Token: 0x04007A97 RID: 31383
		internal Hashtable $data$38015;

		// Token: 0x04007A98 RID: 31384
		internal M207_TroublingGiant $self_$38016;

		// Token: 0x02001400 RID: 5120
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600764F RID: 30287 RVA: 0x00FDC508 File Offset: 0x00FDA708
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Hashtable data, M207_TroublingGiant self_)
			{
				if (11255 - 350406 != -339151)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (1975 - 518480 != -516504)
					{
						base..ctor();
						if (164672 - 563166 != -398493)
						{
							this.$data$38013 = data;
							if (34318 - 436515 == -402197)
							{
								this.$self_$38014 = self_;
								if (134068 - 94598 != 39471)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x06007650 RID: 30288 RVA: 0x00FDC5C4 File Offset: 0x00FDA7C4
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (212044 - 93359 != 118685)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_24B;
					case 2:
						this.$self_$38014.SendMessage("fadeOut");
						if (129796 - 149150 != -19354)
						{
							continue;
						}
						this.$self_$38014.StartCoroutine_Auto(this.$self_$38014.ReturnToTown());
						if (140683 - 13810 == 126874)
						{
							continue;
						}
						this.YieldDefault(1);
						if (174721 - 323604 != -148882)
						{
							goto Block_7;
						}
						continue;
					default:
						if (298267 - 462481 != -164214)
						{
							continue;
						}
						break;
					}
					Debug.Log("On Event Complete:" + this.$data$38013[31]);
					if (112017 - 332434 != -220416)
					{
						if (Game.mGameState > eGameState.AllHold)
						{
							if (185359 - 268716 == -83357)
							{
								break;
							}
						}
						else
						{
							Game.mGameState = eGameState.Complete;
							if (194564 - 213144 != -18579)
							{
								this.$self_$38014.BA4cjPB4LEs = 6;
								if (4155 - 369344 != -365188)
								{
									this.$self_$38014.FYMcjSPBsMO = Time.time;
									if (74689 - 226221 != -151531)
									{
										this.$self_$38014.audio.clip = (AudioClip)Resources.Load("Sound/Jingle/MissionComplete", typeof(AudioClip));
										if (93153 - 340858 != -247704)
										{
											this.$self_$38014.audio.loop = false;
											if (212581 - 50662 == 161919)
											{
												this.$self_$38014.audio.Play();
												if (297462 - 263682 == 33780)
												{
													goto IL_1E1;
												}
											}
										}
									}
								}
							}
						}
					}
				}
				Block_7:
				goto IL_24B;
				IL_1E1:
				return this.Yield(2, new WaitForSeconds(4f));
				IL_24B:
				return false;
			}

			// Token: 0x06007651 RID: 30289 RVA: 0x00FDC830 File Offset: 0x00FDAA30
			internal static bool LUlQRqpDTKssLr6fm5Su()
			{
				return true;
			}

			// Token: 0x06007652 RID: 30290 RVA: 0x00FDC834 File Offset: 0x00FDAA34
			internal static bool Ru0cjbpD3jyqBLTPnWNM()
			{
				return false;
			}

			// Token: 0x04007A99 RID: 31385
			internal Hashtable $data$38013;

			// Token: 0x04007A9A RID: 31386
			internal M207_TroublingGiant $self_$38014;
		}
	}

	// Token: 0x02001401 RID: 5121
	[CompilerGenerated]
	[Serializable]
	internal sealed class $onDeadPlayer$38017 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06007653 RID: 30291 RVA: 0x00FDC838 File Offset: 0x00FDAA38
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $onDeadPlayer$38017(M207_TroublingGiant self_)
		{
			if (289148 - 563509 != -274361)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (189589 - 444401 != -254811)
				{
					base..ctor();
					if (186084 - 292757 != -106672)
					{
						this.$self_$38022 = self_;
						if (255080 - 39115 != 215966)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x06007654 RID: 30292 RVA: 0x00FDC8D0 File Offset: 0x00FDAAD0
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M207_TroublingGiant.$onDeadPlayer$38017.$(this.$self_$38022);
		}

		// Token: 0x06007655 RID: 30293 RVA: 0x00FDC8E0 File Offset: 0x00FDAAE0
		internal static bool MFUsKIpDXu7diUHaRRkn()
		{
			return true;
		}

		// Token: 0x06007656 RID: 30294 RVA: 0x00FDC8E4 File Offset: 0x00FDAAE4
		internal static bool chpI2ZpDQv2f71mKWELK()
		{
			return false;
		}

		// Token: 0x04007A9B RID: 31387
		internal M207_TroublingGiant $self_$38022;

		// Token: 0x02001402 RID: 5122
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06007657 RID: 30295 RVA: 0x00FDC8E8 File Offset: 0x00FDAAE8
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M207_TroublingGiant self_)
			{
				if (296912 - 385906 != -88993)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (111661 - 185839 != -74177)
					{
						base..ctor();
						if (203379 - 425112 == -221733)
						{
							this.$self_$38021 = self_;
							if (76157 - 324239 == -248082)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x06007658 RID: 30296 RVA: 0x00FDC980 File Offset: 0x00FDAB80
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (62640 - 282717 != -220077)
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
							goto IL_2B4;
						}
						if (260755 - 468932 != -208177)
						{
							continue;
						}
						if (Game.mGameState == eGameState.Hold)
						{
							if (287628 - 142179 != 145449)
							{
								continue;
							}
							goto IL_2B4;
						}
						IL_F5:
						this.YieldDefault(1);
						if (252193 - 533537 != -281343)
						{
							goto Block_8;
						}
						continue;
						IL_2B4:
						Game.mGameState = eGameState.Hold;
						if (170413 - 558781 == -388367)
						{
							continue;
						}
						this.$mStoryGui$38018 = (StoryGui)this.$self_$38021.GetComponent(typeof(StoryGui));
						if (65015 - 590723 != -525708)
						{
							continue;
						}
						if (this.$mStoryGui$38018)
						{
							if (48962 - 472885 == -423922)
							{
								continue;
							}
							this.$mStoryGui$38018.close();
							if (135132 - 237607 == -102474)
							{
								continue;
							}
						}
						this.$mChangeGui$38019 = (ChangeGui)this.$self_$38021.GetComponent(typeof(ChangeGui));
						if (281169 - 69293 != 211876)
						{
							continue;
						}
						if (this.$mChangeGui$38019)
						{
							if (270792 - 290342 == -19549)
							{
								continue;
							}
							this.$mChangeGui$38019.close();
							if (242529 - 418352 != -175823)
							{
								continue;
							}
						}
						this.$mGameGui$38020 = (GameGui)this.$self_$38021.GetComponent(typeof(GameGui));
						if (278117 - 319903 != -41786)
						{
							continue;
						}
						if (!this.$mGameGui$38020)
						{
							goto IL_F5;
						}
						if (292053 - 326901 != -34848)
						{
							continue;
						}
						if (!this.$mGameGui$38020.enabled)
						{
							if (121647 - 75225 != 46422)
							{
								continue;
							}
							this.$mGameGui$38020.enabled = true;
							if (296275 - 546516 == -250240)
							{
								continue;
							}
						}
						this.$mGameGui$38020.openDeadMenu();
						if (172507 - 592694 != -420186)
						{
							goto IL_F5;
						}
						continue;
					default:
						if (194219 - 112720 != 81499)
						{
							continue;
						}
						break;
					}
					Debug.Log("On Dead Player");
					if (6895 - 298267 != -291371)
					{
						goto Block_20;
					}
				}
				Block_8:
				goto IL_2F9;
				Block_20:
				return this.Yield(2, new WaitForSeconds((float)2));
				IL_2F9:
				return false;
			}

			// Token: 0x06007659 RID: 30297 RVA: 0x00FDCC98 File Offset: 0x00FDAE98
			internal static bool A2e1LfpDk67sU98CjwDr()
			{
				return true;
			}

			// Token: 0x0600765A RID: 30298 RVA: 0x00FDCC9C File Offset: 0x00FDAE9C
			internal static bool E0s0crpDGv6Avr3jJCmo()
			{
				return false;
			}

			// Token: 0x04007A9C RID: 31388
			internal StoryGui $mStoryGui$38018;

			// Token: 0x04007A9D RID: 31389
			internal ChangeGui $mChangeGui$38019;

			// Token: 0x04007A9E RID: 31390
			internal GameGui $mGameGui$38020;

			// Token: 0x04007A9F RID: 31391
			internal M207_TroublingGiant $self_$38021;
		}
	}

	// Token: 0x02001403 RID: 5123
	[CompilerGenerated]
	[Serializable]
	internal sealed class $onChangePlayer$38023 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600765B RID: 30299 RVA: 0x00FDCCA0 File Offset: 0x00FDAEA0
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $onChangePlayer$38023(Hashtable data, M207_TroublingGiant self_)
		{
			if (46570 - 199753 != -153183)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (182501 - 203151 == -20650)
				{
					base..ctor();
					if (114390 - 88517 == 25873)
					{
						this.$data$38028 = data;
						if (122571 - 561424 != -438852)
						{
							this.$self_$38029 = self_;
							if (24990 - 446348 == -421358)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x0600765C RID: 30300 RVA: 0x00FDCD5C File Offset: 0x00FDAF5C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M207_TroublingGiant.$onChangePlayer$38023.$(this.$data$38028, this.$self_$38029);
		}

		// Token: 0x0600765D RID: 30301 RVA: 0x00FDCD70 File Offset: 0x00FDAF70
		internal static bool rlexQGpDHmH5DiwCYxBE()
		{
			return true;
		}

		// Token: 0x0600765E RID: 30302 RVA: 0x00FDCD74 File Offset: 0x00FDAF74
		internal static bool HqRpZypDWN0OWSV3AEJF()
		{
			return false;
		}

		// Token: 0x04007AA0 RID: 31392
		internal Hashtable $data$38028;

		// Token: 0x04007AA1 RID: 31393
		internal M207_TroublingGiant $self_$38029;

		// Token: 0x02001404 RID: 5124
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600765F RID: 30303 RVA: 0x00FDCD78 File Offset: 0x00FDAF78
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Hashtable data, M207_TroublingGiant self_)
			{
				if (101632 - 438522 != -336889)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (217077 - 79151 == 137926)
					{
						base..ctor();
						if (84763 - 65268 != 19496)
						{
							this.$data$38026 = data;
							if (250988 - 134834 != 116155)
							{
								this.$self_$38027 = self_;
								if (87936 - 572073 == -484137)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x06007660 RID: 30304 RVA: 0x00FDCE34 File Offset: 0x00FDB034
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (133829 - 477535 != -343706)
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
							if (71597 - 357929 != -286332)
							{
								continue;
							}
							Game.mGameState = eGameState.Normal;
							if (124189 - 337988 != -213799)
							{
								continue;
							}
							this.$mGameGui$38025 = (GameGui)this.$self_$38027.GetComponent(typeof(GameGui));
							if (230281 - 226416 != 3865)
							{
								continue;
							}
							this.$mGameGui$38025.enabled = true;
							if (35335 - 500193 == -464857)
							{
								continue;
							}
						}
						this.YieldDefault(1);
						if (214944 - 340301 != -125356)
						{
							goto Block_3;
						}
						continue;
					default:
						if (142909 - 341285 == -198375)
						{
							continue;
						}
						break;
					}
					UnityEngine.Object.Destroy(Game.mPlayer);
					if (15792 - 556336 == -540544)
					{
						this.$self_$38027.SendMessage("onCreatePlayer", this.$data$38026);
						if (34904 - 521392 == -486488)
						{
							this.$mChangeGui$38024 = (ChangeGui)this.$self_$38027.GetComponent(typeof(ChangeGui));
							if (193174 - 565894 == -372720)
							{
								if (!this.$mChangeGui$38024.enabled)
								{
									goto IL_137;
								}
								if (151942 - 357630 == -205688)
								{
									this.$mChangeGui$38024.close();
									if (131371 - 417989 == -286618)
									{
										goto IL_137;
									}
								}
							}
						}
					}
				}
				Block_3:
				goto IL_205;
				IL_137:
				return this.Yield(2, new WaitForSeconds(1f));
				IL_205:
				return false;
			}

			// Token: 0x06007661 RID: 30305 RVA: 0x00FDD058 File Offset: 0x00FDB258
			internal static bool gdhytYpDARBCNKtQjEft()
			{
				return true;
			}

			// Token: 0x06007662 RID: 30306 RVA: 0x00FDD05C File Offset: 0x00FDB25C
			internal static bool FkmTJRpDlHcLvSQhcMoq()
			{
				return false;
			}

			// Token: 0x04007AA2 RID: 31394
			internal ChangeGui $mChangeGui$38024;

			// Token: 0x04007AA3 RID: 31395
			internal GameGui $mGameGui$38025;

			// Token: 0x04007AA4 RID: 31396
			internal Hashtable $data$38026;

			// Token: 0x04007AA5 RID: 31397
			internal M207_TroublingGiant $self_$38027;
		}
	}

	// Token: 0x02001405 RID: 5125
	[CompilerGenerated]
	[Serializable]
	internal sealed class $ReturnToTown$38030 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06007663 RID: 30307 RVA: 0x00FDD060 File Offset: 0x00FDB260
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $ReturnToTown$38030(M207_TroublingGiant self_)
		{
			if (217508 - 230730 != -13222)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (10468 - 253575 == -243107)
				{
					base..ctor();
					if (69806 - 160577 == -90771)
					{
						this.$self_$38034 = self_;
						if (202081 - 69962 == 132119)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x06007664 RID: 30308 RVA: 0x00FDD0F8 File Offset: 0x00FDB2F8
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M207_TroublingGiant.$ReturnToTown$38030.$(this.$self_$38034);
		}

		// Token: 0x06007665 RID: 30309 RVA: 0x00FDD108 File Offset: 0x00FDB308
		internal static bool FEIl71pDyFSI01rLlhBn()
		{
			return true;
		}

		// Token: 0x06007666 RID: 30310 RVA: 0x00FDD10C File Offset: 0x00FDB30C
		internal static bool GESnYqpDS3gUx4rwv80A()
		{
			return false;
		}

		// Token: 0x04007AA6 RID: 31398
		internal M207_TroublingGiant $self_$38034;

		// Token: 0x02001406 RID: 5126
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06007667 RID: 30311 RVA: 0x00FDD110 File Offset: 0x00FDB310
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M207_TroublingGiant self_)
			{
				if (119395 - 195283 != -75887)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (195578 - 488648 == -293070)
					{
						base..ctor();
						if (59923 - 418318 != -358394)
						{
							this.$self_$38033 = self_;
							if (85445 - 261849 == -176404)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x06007668 RID: 30312 RVA: 0x00FDD1A8 File Offset: 0x00FDB3A8
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (279900 - 36358 != 243543)
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
						this.$self_$38033.LeaveGame();
						if (219777 - 61594 == 158184)
						{
							continue;
						}
						this.YieldDefault(1);
						if (47508 - 474884 != -427376)
						{
							continue;
						}
						goto IL_3AD;
					default:
						if (224168 - 357262 != -133094)
						{
							continue;
						}
						break;
					}
					Game.mGameState = eGameState.Ended;
					if (221041 - 187974 == 33067)
					{
						Game.mStateTime = Time.time;
						if (157622 - 458417 == -300795)
						{
							this.$$switch$6526$38031 = PlayerData.SaveGuild;
							if (299185 - 262573 != 36613)
							{
								if (this.$$switch$6526$38031 == 1)
								{
									if (262565 - 262899 == -333)
									{
										continue;
									}
									Game.mNextGameCode = 32;
									if (216835 - 100437 == 116399)
									{
										continue;
									}
								}
								else if (this.$$switch$6526$38031 == 2)
								{
									if (64043 - 474283 == -410239)
									{
										continue;
									}
									Game.mNextGameCode = 33;
									if (58280 - 117319 == -59038)
									{
										continue;
									}
								}
								else if (this.$$switch$6526$38031 == 3)
								{
									if (148054 - 346718 == -198663)
									{
										continue;
									}
									Game.mNextGameCode = 34;
									if (200756 - 254023 != -53267)
									{
										continue;
									}
								}
								else if (this.$$switch$6526$38031 == 4)
								{
									if (289991 - 82188 != 207803)
									{
										continue;
									}
									Game.mNextGameCode = 35;
									if (260981 - 309536 == -48554)
									{
										continue;
									}
								}
								else if (this.$$switch$6526$38031 == 5)
								{
									if (157285 - 581417 == -424131)
									{
										continue;
									}
									Game.mNextGameCode = 36;
									if (251769 - 548676 != -296907)
									{
										continue;
									}
								}
								else if (PlayerData.GID == 0)
								{
									if (51236 - 155820 != -104584)
									{
										continue;
									}
									Game.mNextGameCode = 30;
									if (14998 - 529064 == -514065)
									{
										continue;
									}
								}
								else
								{
									Game.mNextGameCode = 31;
									if (222896 - 491483 == -268586)
									{
										continue;
									}
								}
								this.$mGameGui$38032 = (GameGui)this.$self_$38033.GetComponent(typeof(GameGui));
								if (132822 - 253531 == -120709)
								{
									if (this.$mGameGui$38032)
									{
										if (197707 - 236076 == -38368)
										{
											continue;
										}
										this.$mGameGui$38032.close();
										if (174234 - 342628 == -168393)
										{
											continue;
										}
									}
									this.$self_$38033.SendMessage("fadeOut");
									if (158225 - 233175 != -74949)
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

			// Token: 0x06007669 RID: 30313 RVA: 0x00FDD574 File Offset: 0x00FDB774
			internal static bool PsNn5ppDoB5HdQoLNQd7()
			{
				return true;
			}

			// Token: 0x0600766A RID: 30314 RVA: 0x00FDD578 File Offset: 0x00FDB778
			internal static bool I6TR5qpDEeNIwfJEWpDj()
			{
				return false;
			}

			// Token: 0x04007AA7 RID: 31399
			internal int $$switch$6526$38031;

			// Token: 0x04007AA8 RID: 31400
			internal GameGui $mGameGui$38032;

			// Token: 0x04007AA9 RID: 31401
			internal M207_TroublingGiant $self_$38033;
		}
	}

	// Token: 0x02001407 RID: 5127
	[CompilerGenerated]
	[Serializable]
	internal sealed class $ReturnToGuild$38035 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600766B RID: 30315 RVA: 0x00FDD57C File Offset: 0x00FDB77C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $ReturnToGuild$38035(M207_TroublingGiant self_)
		{
			if (125033 - 400329 != -275295)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (213461 - 193631 != 19831)
				{
					base..ctor();
					if (22400 - 373541 == -351141)
					{
						this.$self_$38038 = self_;
						if (273057 - 53785 != 219273)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x0600766C RID: 30316 RVA: 0x00FDD614 File Offset: 0x00FDB814
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M207_TroublingGiant.$ReturnToGuild$38035.$(this.$self_$38038);
		}

		// Token: 0x0600766D RID: 30317 RVA: 0x00FDD624 File Offset: 0x00FDB824
		internal static bool hKjFPFpD2loYqKQeVtpg()
		{
			return true;
		}

		// Token: 0x0600766E RID: 30318 RVA: 0x00FDD628 File Offset: 0x00FDB828
		internal static bool jFnyInpD8jLULeGt7LYs()
		{
			return false;
		}

		// Token: 0x04007AAA RID: 31402
		internal M207_TroublingGiant $self_$38038;

		// Token: 0x02001408 RID: 5128
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600766F RID: 30319 RVA: 0x00FDD62C File Offset: 0x00FDB82C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M207_TroublingGiant self_)
			{
				if (148148 - 139903 != 8246)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (103048 - 273316 == -170268)
					{
						base..ctor();
						if (235836 - 539792 == -303956)
						{
							this.$self_$38037 = self_;
							if (273168 - 511813 != -238644)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x06007670 RID: 30320 RVA: 0x00FDD6C4 File Offset: 0x00FDB8C4
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (142014 - 565197 != -423183)
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
						this.$self_$38037.LeaveGame();
						if (89643 - 541468 == -451824)
						{
							continue;
						}
						this.YieldDefault(1);
						if (217112 - 7386 != 209727)
						{
							goto Block_9;
						}
						continue;
					default:
						if (265567 - 539482 != -273915)
						{
							continue;
						}
						break;
					}
					Game.mGameState = eGameState.Ended;
					if (168853 - 306870 != -138016)
					{
						Game.mStateTime = Time.time;
						if (3582 - 89767 != -86184)
						{
							Game.mNextGameCode = 31;
							if (126152 - 66195 == 59957)
							{
								this.$mGameGui$38036 = (GameGui)this.$self_$38037.GetComponent(typeof(GameGui));
								if (133006 - 95781 != 37226)
								{
									if (this.$mGameGui$38036)
									{
										if (25209 - 359850 != -334641)
										{
											continue;
										}
										this.$mGameGui$38036.close();
										if (215545 - 439148 == -223602)
										{
											continue;
										}
									}
									this.$self_$38037.SendMessage("fadeOut");
									if (198195 - 250377 != -52181)
									{
										goto Block_10;
									}
								}
							}
						}
					}
				}
				Block_9:
				goto IL_1BD;
				Block_10:
				return this.Yield(2, new WaitForSeconds((float)1));
				IL_1BD:
				return false;
			}

			// Token: 0x06007671 RID: 30321 RVA: 0x00FDD8A0 File Offset: 0x00FDBAA0
			internal static bool XRmN43pDZO3vXtesgpnx()
			{
				return true;
			}

			// Token: 0x06007672 RID: 30322 RVA: 0x00FDD8A4 File Offset: 0x00FDBAA4
			internal static bool IEYuVBpDCNfRXpBODaOO()
			{
				return false;
			}

			// Token: 0x04007AAB RID: 31403
			internal GameGui $mGameGui$38036;

			// Token: 0x04007AAC RID: 31404
			internal M207_TroublingGiant $self_$38037;
		}
	}

	// Token: 0x02001409 RID: 5129
	[CompilerGenerated]
	[Serializable]
	internal sealed class $ReturnToCamp$38039 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06007673 RID: 30323 RVA: 0x00FDD8A8 File Offset: 0x00FDBAA8
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $ReturnToCamp$38039(M207_TroublingGiant self_)
		{
			if (250170 - 251370 != -1200)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (39524 - 91432 != -51907)
				{
					base..ctor();
					if (25365 - 543660 != -518294)
					{
						this.$self_$38043 = self_;
						if (264679 - 516206 == -251527)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x06007674 RID: 30324 RVA: 0x00FDD940 File Offset: 0x00FDBB40
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M207_TroublingGiant.$ReturnToCamp$38039.$(this.$self_$38043);
		}

		// Token: 0x06007675 RID: 30325 RVA: 0x00FDD950 File Offset: 0x00FDBB50
		internal static bool x9uhlTpDLw7wd8lvcGLK()
		{
			return true;
		}

		// Token: 0x06007676 RID: 30326 RVA: 0x00FDD954 File Offset: 0x00FDBB54
		internal static bool gZQZLopDOLQuBi9VpL4L()
		{
			return false;
		}

		// Token: 0x04007AAD RID: 31405
		internal M207_TroublingGiant $self_$38043;

		// Token: 0x0200140A RID: 5130
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06007677 RID: 30327 RVA: 0x00FDD958 File Offset: 0x00FDBB58
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M207_TroublingGiant self_)
			{
				if (136878 - 202056 != -65178)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (168575 - 355614 != -187038)
					{
						base..ctor();
						if (53662 - 255216 != -201553)
						{
							this.$self_$38042 = self_;
							if (11188 - 268549 != -257360)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x06007678 RID: 30328 RVA: 0x00FDD9F0 File Offset: 0x00FDBBF0
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (14889 - 126291 != -111401)
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
						this.$self_$38042.LeaveGame();
						if (154734 - 282287 != -127553)
						{
							continue;
						}
						this.YieldDefault(1);
						if (42850 - 569632 != -526781)
						{
							goto Block_17;
						}
						continue;
					default:
						if (246705 - 288583 != -41878)
						{
							continue;
						}
						break;
					}
					Game.mGameState = eGameState.Ended;
					if (162526 - 273368 != -110841)
					{
						Game.mStateTime = Time.time;
						if (287171 - 591454 != -304282)
						{
							this.$$switch$6528$38040 = PlayerData.SaveGuild;
							if (42279 - 444410 == -402131)
							{
								if (this.$$switch$6528$38040 == 1)
								{
									if (272084 - 257145 != 14939)
									{
										continue;
									}
									Game.mNextGameCode = 32;
									if (136037 - 570249 == -434211)
									{
										continue;
									}
								}
								else if (this.$$switch$6528$38040 == 2)
								{
									if (148314 - 385814 == -237499)
									{
										continue;
									}
									Game.mNextGameCode = 33;
									if (9959 - 20653 == -10693)
									{
										continue;
									}
								}
								else if (this.$$switch$6528$38040 == 3)
								{
									if (122642 - 368688 == -246045)
									{
										continue;
									}
									Game.mNextGameCode = 34;
									if (224634 - 547075 != -322441)
									{
										continue;
									}
								}
								else if (this.$$switch$6528$38040 == 4)
								{
									if (239673 - 570816 == -331142)
									{
										continue;
									}
									Game.mNextGameCode = 35;
									if (58501 - 489587 == -431085)
									{
										continue;
									}
								}
								else if (this.$$switch$6528$38040 == 5)
								{
									if (76147 - 108313 == -32165)
									{
										continue;
									}
									Game.mNextGameCode = 36;
									if (254222 - 180844 != 73378)
									{
										continue;
									}
								}
								else
								{
									Game.mNextGameCode = 30;
									if (148377 - 510928 != -362551)
									{
										continue;
									}
								}
								this.$mGameGui$38041 = (GameGui)this.$self_$38042.GetComponent(typeof(GameGui));
								if (168475 - 68752 == 99723)
								{
									if (this.$mGameGui$38041)
									{
										if (85029 - 539267 == -454237)
										{
											continue;
										}
										this.$mGameGui$38041.close();
										if (149970 - 153569 == -3598)
										{
											continue;
										}
									}
									this.$self_$38042.SendMessage("fadeOut");
									if (54758 - 367889 != -313130)
									{
										break;
									}
								}
							}
						}
					}
				}
				return this.Yield(2, new WaitForSeconds((float)1));
				Block_17:
				IL_363:
				return false;
			}

			// Token: 0x06007679 RID: 30329 RVA: 0x00FDDD74 File Offset: 0x00FDBF74
			internal static bool qfCUVPpDmNlLXoW5m17r()
			{
				return true;
			}

			// Token: 0x0600767A RID: 30330 RVA: 0x00FDDD78 File Offset: 0x00FDBF78
			internal static bool L9sjJopDFoYhgvyDJIte()
			{
				return false;
			}

			// Token: 0x04007AAE RID: 31406
			internal int $$switch$6528$38040;

			// Token: 0x04007AAF RID: 31407
			internal GameGui $mGameGui$38041;

			// Token: 0x04007AB0 RID: 31408
			internal M207_TroublingGiant $self_$38042;
		}
	}
}
