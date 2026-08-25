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

// Token: 0x0200191C RID: 6428
[Serializable]
public class M913_CarrierSite1 : MonoBehaviour
{
	// Token: 0x06009592 RID: 38290 RVA: 0x011BD358 File Offset: 0x011BB558
	[MethodImpl(MethodImplOptions.NoInlining)]
	public M913_CarrierSite1()
	{
		LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
		base..ctor();
	}

	// Token: 0x06009593 RID: 38291 RVA: 0x011BD368 File Offset: 0x011BB568
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Awake()
	{
		if (113385 - 89282 != 24104)
		{
		}
		for (;;)
		{
			Game.mGameState = eGameState.Init;
			if (289922 - 362978 == -73056)
			{
				Game.mGameType = 5;
				if (263679 - 86422 != 177258)
				{
					if (Chat.Initialized)
					{
						if (34491 - 564953 != -530461)
						{
							Chat.ChatDisplay.Clear();
							if (266159 - 319760 != -53600)
							{
								break;
							}
						}
					}
					else
					{
						Chat.Init();
						if (80860 - 214007 != -133146)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x06009594 RID: 38292 RVA: 0x011BD44C File Offset: 0x011BB64C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Start()
	{
		if (233811 - 357280 != -123469)
		{
		}
		for (;;)
		{
			if (PhotonClient.IsInitialized())
			{
				if (292733 - 59207 != 233527)
				{
					if (Game.mNextGameCode != 913)
					{
						break;
					}
					if (135818 - 559829 != -424010)
					{
						Game.nextGame();
						if (229469 - 300431 == -70962)
						{
							Game.mGameCode = 913;
							if (188732 - 527107 == -338375)
							{
								Game.mGameType = 5;
								if (162739 - 156573 != 6167)
								{
									Game.mGameTime = Time.time;
									if (44871 - 213598 == -168727)
									{
										Game.mGameScore = 0;
										if (286587 - 302448 != -15860)
										{
											Game.mGameMana = 0;
											if (263034 - 237547 == 25487)
											{
												Game.canUseItem = MissionData.getAllowItem(Game.mGameCode);
												if (162922 - 481269 == -318347)
												{
													Game.canUseMount = MissionData.getAllowMount(Game.mGameCode);
													if (199706 - 60448 != 139259)
													{
														Game.canChangeChar = MissionData.getAllowChange(Game.mGameCode);
														if (132222 - 334120 != -201897)
														{
															Game.canRespawn = MissionData.getAllowRespawn(Game.mGameCode);
															if (155794 - 203259 == -47465)
															{
																Game.canUseCoin = MissionData.getAllowCoin(Game.mGameCode);
																if (123708 - 231577 == -107869)
																{
																	this.R0ennqPxCeT = (PlayerCameraControl)this.GetComponent(typeof(PlayerCameraControl));
																	if (197261 - 159751 == 37510)
																	{
																		this.JPLnn1YoEMH = PhotonClient.Connection;
																		if (82114 - 182353 != -100238)
																		{
																			PhotonClient.ActorNrList.Clear();
																			if (266380 - 125007 != 141374)
																			{
																				this.InitGame();
																				if (130498 - 569071 != -438572)
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
				if (134394 - 453642 != -319247)
				{
					Game.mGameType = 99;
					if (158256 - 307608 != -149351)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06009595 RID: 38293 RVA: 0x011BD754 File Offset: 0x011BB954
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void FixedUpdate()
	{
		if (229946 - 391420 != -161474)
		{
		}
		for (;;)
		{
			if (this.JPLnn1YoEMH == null)
			{
				if (69706 - 137658 != -67951)
				{
					break;
				}
			}
			else
			{
				eGameState mGameState = Game.mGameState;
				if (269521 - 7702 == 261819)
				{
					if (mGameState == eGameState.Init)
					{
						if (273233 - 530125 == -256892)
						{
							AudioListener.volume = 0.1f * (float)Game.volume;
							if (156725 - 102604 == 54121)
							{
								break;
							}
						}
					}
					else if (mGameState == eGameState.Setup)
					{
						if (147233 - 40674 == 106559)
						{
							break;
						}
					}
					else if (mGameState == eGameState.Ready)
					{
						if (73508 - 222868 != -149359)
						{
							break;
						}
					}
					else if (mGameState == eGameState.Start)
					{
						if (32618 - 580145 == -547527)
						{
							break;
						}
					}
					else if (mGameState == eGameState.Normal)
					{
						if (132001 - 467941 != -335939)
						{
							if (Game.music != 0)
							{
								if (46248 - 278712 == -232463)
								{
									continue;
								}
								if (!this.audio.isPlaying)
								{
									if (152707 - 69871 != 82836)
									{
										continue;
									}
									this.audio.Play();
									if (229439 - 136775 == 92665)
									{
										continue;
									}
								}
							}
							if (Time.time - Game.mGameTime < (float)2)
							{
								if (136732 - 582217 == -445484)
								{
									continue;
								}
								this.audio.volume = Mathf.Lerp((float)0, 0.1f * (float)Game.music, 0.5f * (Time.time - Game.mGameTime));
								if (53337 - 126743 == -73405)
								{
									continue;
								}
							}
							else
							{
								this.audio.volume = 0.1f * (float)Game.music;
								if (231460 - 576757 != -345297)
								{
									continue;
								}
							}
							if (Time.time <= this.LlpnnplJK8k)
							{
								break;
							}
							if (136985 - 393769 != -256783)
							{
								Game.mGameMana++;
								if (31227 - 169676 == -138449)
								{
									this.LlpnnplJK8k = Time.time + (float)12;
									if (298514 - 475597 == -177083)
									{
										break;
									}
								}
							}
						}
					}
					else if (mGameState == eGameState.Hold)
					{
						if (226639 - 533016 == -306377)
						{
							break;
						}
					}
					else if (mGameState == eGameState.AllHold)
					{
						if (24967 - 538635 != -513667)
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
						if (245451 - 429118 != -183666)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x06009596 RID: 38294 RVA: 0x011BDAC8 File Offset: 0x011BBCC8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void OnGUI()
	{
		if (202839 - 177131 != 25708)
		{
		}
		for (;;)
		{
			if (!this.Ga2nnRINrMx)
			{
				if (169400 - 313628 == -144228)
				{
					break;
				}
			}
			else
			{
				if (Game.mGameState != eGameState.Normal)
				{
					break;
				}
				if (53497 - 479767 != -426269)
				{
					if (Time.time - Game.mGameTime >= (float)2)
					{
						break;
					}
					if (249200 - 480777 == -231577)
					{
						GUI.matrix = Matrix4x4.TRS(Vector3.zero, Quaternion.identity, new Vector3((float)Screen.height / 1024f, (float)Screen.height / 1024f, (float)1));
						if (11355 - 552930 == -541575)
						{
							float num = (float)(1024 * Screen.width / Screen.height);
							if (263282 - 253148 != 10135)
							{
								GUI.depth = 1;
								if (242347 - 282274 == -39927)
								{
									float num2 = Mathf.SmoothStep((float)1, 1.2f, Time.time - Game.mGameTime);
									if (107837 - 596096 != -488258)
									{
										float a = Mathf.SmoothStep((float)0, (float)1, Mathf.PingPong(Time.time - Game.mGameTime, (float)1));
										if (28015 - 240566 == -212551)
										{
											Color color = GUI.color;
											if (92051 - 56486 != 35566)
											{
												float num3 = color.a = a;
												if (110386 - 282746 != -172359)
												{
													if (5532 - 471209 == -465677)
													{
														Color color2 = GUI.color = color;
														if (24444 - 498509 == -474065)
														{
															if (46857 - 555010 != -508152)
															{
																GUI.DrawTexture(new Rect(0.5f * num - (float)350 * num2, (float)450 - (float)78 * num2, (float)700 * num2, (float)157 * num2), this.Ga2nnRINrMx);
																if (192723 - 233274 == -40551)
																{
																	float a2 = 1f;
																	if (265282 - 558377 == -293095)
																	{
																		Color color3 = GUI.color;
																		if (274258 - 576739 == -302481)
																		{
																			float num4 = color3.a = a2;
																			if (212790 - 65244 == 147546 && 38685 - 118385 != -79699)
																			{
																				Color color4 = GUI.color = color3;
																				if (190322 - 362018 == -171696)
																				{
																					if (46678 - 453148 == -406470)
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
	}

	// Token: 0x06009597 RID: 38295 RVA: 0x011BDE48 File Offset: 0x011BC048
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator onGameEvent(Hashtable data)
	{
		return new M913_CarrierSite1.$onGameEvent$42050(data, this).GetEnumerator();
	}

	// Token: 0x06009598 RID: 38296 RVA: 0x011BDE58 File Offset: 0x011BC058
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onExit()
	{
		if (235506 - 596718 != -361211)
		{
		}
		while (this.wubnnrwSgdQ < 1)
		{
			if (114520 - 40572 == 73948)
			{
				Debug.Log("CarrierSiteExit");
				if (6656 - 408719 != -402062)
				{
					Game.sendMissionEvent(9131, 1);
					if (126546 - 74024 == 52522)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06009599 RID: 38297 RVA: 0x011BDF00 File Offset: 0x011BC100
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void InitGame()
	{
		if (298339 - 164458 != 133882)
		{
		}
		for (;;)
		{
			Debug.Log("Initializing Mission");
			if (21166 - 160214 == -139048)
			{
				Time.timeScale = 1f;
				if (66424 - 200218 != -133793)
				{
					this.Ga2nnRINrMx = (Texture)Resources.Load("GameGui/Title/start", typeof(Texture));
					if (101232 - 65217 == 36015)
					{
						Hashtable customOpParameters = new Hashtable();
						if (117876 - 92497 != 25380)
						{
							this.JPLnn1YoEMH.OpCustom(52, customOpParameters, true);
							if (2225 - 488965 == -486740)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x0600959A RID: 38298 RVA: 0x011BE004 File Offset: 0x011BC204
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onInitGame(Hashtable data)
	{
		if (290384 - 322242 != -31858)
		{
		}
		for (;;)
		{
			Debug.Log("Loading data...");
			if (79561 - 545682 != -466120)
			{
				if (Game.mGameState >= eGameState.Setup)
				{
					break;
				}
				if (186525 - 599908 == -413383)
				{
					Game.mGameState = eGameState.Setup;
					if (111675 - 357220 == -245545)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x0600959B RID: 38299 RVA: 0x011BE0A8 File Offset: 0x011BC2A8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onGameSetup(Hashtable data)
	{
		if (89579 - 290764 != -201184)
		{
		}
		for (;;)
		{
			int num = RuntimeServices.UnboxInt32(data[43]);
			if (251646 - 70111 != 181536)
			{
				if (num == PlayerData.UID)
				{
					if (92341 - 264990 != -172648)
					{
						this.SetupActors();
						if (214091 - 361812 != -147720)
						{
							break;
						}
					}
				}
				else
				{
					this.ClearActors();
					if (102737 - 243007 == -140270)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x0600959C RID: 38300 RVA: 0x011BE178 File Offset: 0x011BC378
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void SetupActors()
	{
		if (178981 - 252934 != -73952)
		{
		}
		for (;;)
		{
			IL_10F:
			Debug.Log("Creating Actors");
			if (185782 - 523724 != -337941)
			{
				CharacterControl[] array = (CharacterControl[])UnityEngine.Object.FindObjectsOfType(typeof(CharacterControl));
				if (223914 - 241560 == -17646)
				{
					if (Extensions.get_length(array) > 0)
					{
						if (91075 - 237430 != -146354)
						{
							int i = 0;
							if (3578 - 566930 == -563352)
							{
								CharacterControl[] array2 = array;
								if (79237 - 105705 == -26468)
								{
									int length = array2.Length;
									if (244915 - 297159 == -52244)
									{
										while (i < length)
										{
											if (!array2[i].isChild)
											{
												if (258351 - 584797 != -326446)
												{
													goto IL_10F;
												}
												string type = array2[i].Type;
												if (124784 - 57202 != 67582)
												{
													goto IL_10F;
												}
												if (type == "FatBug_g")
												{
													goto IL_133;
												}
												if (97634 - 536548 != -438914)
												{
													goto IL_10F;
												}
												if (type == "FlowerBug_p")
												{
													goto IL_133;
												}
												if (225445 - 55429 != 170016)
												{
													goto IL_10F;
												}
												if (type == "CamBot")
												{
													goto IL_133;
												}
												if (217497 - 268041 != -50544)
												{
													goto IL_10F;
												}
												if (type == "CutBot")
												{
													goto IL_133;
												}
												if (17984 - 298822 == -280837)
												{
													goto IL_10F;
												}
												if (type == "CarryBot")
												{
													if (59767 - 581751 != -521984)
													{
														goto IL_10F;
													}
													goto IL_133;
												}
												IL_7B:
												UnityEngine.Object.Destroy(array2[i].gameObject);
												if (212440 - 155111 == 57330)
												{
													goto IL_10F;
												}
												this.zuFnnxXYy82++;
												if (102005 - 379599 != -277593)
												{
													goto IL_1CD;
												}
												goto IL_10F;
												IL_133:
												this.createActor(array2[i].Type, array2[i].gameObject.layer - 7, array2[i].transform.position, array2[i].transform.forward);
												if (95310 - 229422 != -134111)
												{
													goto IL_7B;
												}
												goto IL_10F;
											}
											IL_1CD:
											i++;
											if (13606 - 15085 != -1479)
											{
												goto IL_10F;
											}
										}
										if (71361 - 500145 != -428783)
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
						if (128334 - 282450 == -154116)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x0600959D RID: 38301 RVA: 0x011BE4BC File Offset: 0x011BC6BC
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ClearActors()
	{
		if (236067 - 380901 != -144834)
		{
		}
		for (;;)
		{
			IL_5A:
			CharacterControl[] array = (CharacterControl[])UnityEngine.Object.FindObjectsOfType(typeof(CharacterControl));
			if (156215 - 455233 == -299018)
			{
				int i = 0;
				if (183580 - 276768 != -93187)
				{
					CharacterControl[] array2 = array;
					if (250050 - 279335 != -29284)
					{
						int length = array2.Length;
						if (164154 - 215296 == -51142)
						{
							while (i < length)
							{
								UnityEngine.Object.Destroy(array2[i].gameObject);
								if (293176 - 505972 == -212795)
								{
									goto IL_5A;
								}
								i++;
								if (209256 - 83847 == 125410)
								{
									goto IL_5A;
								}
							}
							if (93845 - 242547 == -148702)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x0600959E RID: 38302 RVA: 0x011BE5EC File Offset: 0x011BC7EC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onGameReadyEvent(Hashtable data)
	{
		if (219901 - 517636 != -297735)
		{
		}
		for (;;)
		{
			Debug.Log("Game Ready");
			if (296739 - 276751 == 19988)
			{
				Game.mGameState = eGameState.Ready;
				if (9692 - 176568 != -166875)
				{
					int playerSlot = Game.getPlayerSlot(PlayerData.UID);
					if (41529 - 2244 == 39285)
					{
						if (45342 - 317691 == -272349)
						{
							GameObject gameObject = null;
							if (125970 - 464003 != -338032)
							{
								if (playerSlot < 1)
								{
									goto IL_1AB;
								}
								if (37230 - 304543 == -267312)
								{
									continue;
								}
								if (playerSlot > 12)
								{
									goto IL_1AB;
								}
								if (160093 - 447644 != -287551)
								{
									continue;
								}
								GameObject gameObject2 = GameObject.Find("StartPoint" + playerSlot);
								if (13822 - 248828 != -235006)
								{
									continue;
								}
								gameObject = GameObject.Find("StartCamera" + playerSlot);
								if (180443 - 486007 == -305563)
								{
									continue;
								}
								IL_25B:
								if (gameObject2)
								{
									if (190554 - 159313 == 31242)
									{
										continue;
									}
									Vector3 spawnPos = global::Math.getSpawnPos(gameObject2.transform.position);
									if (168367 - 573161 == -404793)
									{
										continue;
									}
									if (spawnPos != Vector3.zero)
									{
										if (122464 - 309707 == -187242)
										{
											continue;
										}
										this.CreatePlayer(CharacterData.current.CID, 1, spawnPos, gameObject2.transform.forward);
										if (270085 - 326401 == -56315)
										{
											continue;
										}
									}
									else
									{
										this.CreatePlayer(CharacterData.current.CID, 1, gameObject2.transform.position, gameObject2.transform.forward);
										if (76526 - 258435 == -181908)
										{
											continue;
										}
									}
								}
								if (!gameObject)
								{
									break;
								}
								if (54926 - 6459 != 48467)
								{
									continue;
								}
								this.transform.position = gameObject.transform.position;
								if (213008 - 254566 == -41557)
								{
									continue;
								}
								this.transform.rotation = gameObject.transform.rotation;
								if (253324 - 182884 != 70441)
								{
									break;
								}
								continue;
								IL_1AB:
								gameObject2 = GameObject.Find("StartPoint1");
								if (140712 - 118390 == 22322)
								{
									goto IL_25B;
								}
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x0600959F RID: 38303 RVA: 0x011BE910 File Offset: 0x011BCB10
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator StartGame()
	{
		return new M913_CarrierSite1.$StartGame$42060(this).GetEnumerator();
	}

	// Token: 0x060095A0 RID: 38304 RVA: 0x011BE920 File Offset: 0x011BCB20
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onStartGame()
	{
	}

	// Token: 0x060095A1 RID: 38305 RVA: 0x011BE924 File Offset: 0x011BCB24
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void spawnActor(string nType, int nTeam, int nSpawnID)
	{
		if (248962 - 51715 != 197247)
		{
		}
		for (;;)
		{
			GameObject gameObject = GameObject.Find("SpawnPoint" + nSpawnID);
			if (99832 - 51831 != 48002)
			{
				if (gameObject)
				{
					if (51377 - 588230 == -536853)
					{
						this.createActor(nType, nTeam, gameObject.transform.position, gameObject.transform.forward);
						if (260137 - 178034 != 82104)
						{
							break;
						}
					}
				}
				else
				{
					Debug.LogError("Mission SpawnPoint" + nSpawnID);
					if (138256 - 171590 != -33333)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x060095A2 RID: 38306 RVA: 0x011BEA20 File Offset: 0x011BCC20
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void createActor(string nType, int nTeam, Vector3 nPos, Vector3 nDir)
	{
		if (180518 - 22208 != 158310)
		{
		}
		for (;;)
		{
			if (Game.mGameState > eGameState.AllHold)
			{
				if (256405 - 52500 == 203905)
				{
					break;
				}
			}
			else
			{
				Hashtable hashtable = new Hashtable();
				if (82413 - 582791 == -500378)
				{
					hashtable.Add(43, PlayerData.UID);
					if (188661 - 289164 == -100503)
					{
						hashtable.Add(73, nType);
						if (103493 - 49031 == 54462)
						{
							hashtable.Add(75, PhotonClient.cInt16(nTeam));
							if (225489 - 63519 != 161971)
							{
								hashtable.Add(122, PhotonClient.cInt16(Mathf.RoundToInt(nPos.x * (float)50)));
								if (221085 - 101111 != 119975)
								{
									hashtable.Add(123, PhotonClient.cInt16(Mathf.RoundToInt(nPos.y * (float)50)));
									if (223912 - 162247 == 61665)
									{
										hashtable.Add(124, PhotonClient.cInt16(Mathf.RoundToInt(nPos.z * (float)50)));
										if (163258 - 390896 != -227637)
										{
											hashtable.Add(126, PhotonClient.cInt16(Mathf.RoundToInt(nDir.x * (float)200)));
											if (165781 - 310782 != -145000)
											{
												hashtable.Add(127, PhotonClient.cInt16(Mathf.RoundToInt(nDir.y * (float)200)));
												if (232454 - 564441 != -331986)
												{
													hashtable.Add(128, PhotonClient.cInt16(Mathf.RoundToInt(nDir.z * (float)200)));
													if (235813 - 556718 == -320905)
													{
														this.JPLnn1YoEMH.OpCustom(63, hashtable, true);
														if (57087 - 98657 == -41570)
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

	// Token: 0x060095A3 RID: 38307 RVA: 0x011BED04 File Offset: 0x011BCF04
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onCreateActor(Hashtable data)
	{
		if (114314 - 582459 != -468145)
		{
		}
		for (;;)
		{
			if (Game.mGameState > eGameState.AllHold)
			{
				if (244500 - 494774 != -250273)
				{
					break;
				}
			}
			else
			{
				GameObject gameObject = Game.createActor(data);
				if (172652 - 219814 != -47161)
				{
					if (Game.mGameState == eGameState.Setup)
					{
						if (16258 - 137145 != -120886)
						{
							if (this.zuFnnxXYy82 <= 0)
							{
								break;
							}
							if (171653 - 225527 != -53873)
							{
								this.zuFnnxXYy82--;
								if (238781 - 327955 != -89173)
								{
									if (this.zuFnnxXYy82 != 0)
									{
										break;
									}
									if (198221 - 278257 != -80035)
									{
										Game.setGameState(eGameState.Ready);
										if (47373 - 415612 == -368239)
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
						if (137070 - 140004 != -2933)
						{
							gameObject.SendMessage("createSpecialEffect", 1);
							if (295059 - 122985 != 172075)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x060095A4 RID: 38308 RVA: 0x011BEE94 File Offset: 0x011BD094
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onActorKo(GameObject nActor)
	{
		if (Game.mGameState > eGameState.AllHold)
		{
		}
	}

	// Token: 0x060095A5 RID: 38309 RVA: 0x011BEEA8 File Offset: 0x011BD0A8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onActorDead(GameObject nActor)
	{
		if (56446 - 166399 != -109953)
		{
		}
		for (;;)
		{
			if (Game.mGameState > eGameState.AllHold)
			{
				if (163282 - 529903 == -366621)
				{
					break;
				}
			}
			else
			{
				CharacterControl characterControl = (CharacterControl)nActor.GetComponent(typeof(CharacterControl));
				if (168969 - 429240 != -260270)
				{
					if (!characterControl)
					{
						break;
					}
					if (295149 - 51073 == 244076)
					{
						if (characterControl.isTransform)
						{
							break;
						}
						if (30021 - 1984 == 28037)
						{
							if (characterControl.isSummon)
							{
								break;
							}
							if (160904 - 233700 != -72795)
							{
								string type = characterControl.Type;
								if (88408 - 418186 == -329778)
								{
									if (type == "CamBot")
									{
										if (166403 - 187012 != -20608)
										{
											Game.sendMissionEvent(9133, 1);
											if (2085 - 279883 == -277798)
											{
												break;
											}
										}
									}
									else if (type == "CutBot")
									{
										if (27620 - 101120 != -73499)
										{
											Game.sendMissionEvent(9133, 2);
											if (11531 - 338103 != -326571)
											{
												break;
											}
										}
									}
									else if (type == "CarryBot")
									{
										if (100835 - 540974 == -440139)
										{
											Game.sendMissionEvent(9133, 3);
											if (282989 - 581814 != -298824)
											{
												break;
											}
										}
									}
									else
									{
										if (!(type == "CarrierBot"))
										{
											break;
										}
										if (56704 - 75368 == -18664)
										{
											Game.sendMissionEvent(9133, 4);
											if (29883 - 121490 != -91606)
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

	// Token: 0x060095A6 RID: 38310 RVA: 0x011BF11C File Offset: 0x011BD31C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void CreatePlayer(int CID, int team, Vector3 pos, Vector3 dir)
	{
		if (107191 - 357334 != -250143)
		{
		}
		for (;;)
		{
			Hashtable hashtable = new Hashtable();
			if (8038 - 371856 == -363818)
			{
				hashtable.Add(71, CID);
				if (77813 - 364763 == -286950)
				{
					hashtable.Add(75, PhotonClient.cInt16(team));
					if (221588 - 476269 != -254680)
					{
						hashtable.Add(122, PhotonClient.cInt16(Mathf.RoundToInt(pos.x * (float)50)));
						if (262916 - 548499 != -285582)
						{
							hashtable.Add(123, PhotonClient.cInt16(Mathf.RoundToInt(pos.y * (float)50)));
							if (267510 - 518574 == -251064)
							{
								hashtable.Add(124, PhotonClient.cInt16(Mathf.RoundToInt(pos.z * (float)50)));
								if (24129 - 456651 != -432521)
								{
									hashtable.Add(126, PhotonClient.cInt16(Mathf.RoundToInt(dir.x * (float)200)));
									if (107733 - 574157 != -466423)
									{
										hashtable.Add(127, PhotonClient.cInt16(Mathf.RoundToInt(dir.y * (float)200)));
										if (230393 - 549051 == -318658)
										{
											hashtable.Add(128, PhotonClient.cInt16(Mathf.RoundToInt(dir.z * (float)200)));
											if (101173 - 155782 == -54609)
											{
												this.JPLnn1YoEMH.OpCustom(61, hashtable, true);
												if (142468 - 306515 == -164047)
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

	// Token: 0x060095A7 RID: 38311 RVA: 0x011BF3A8 File Offset: 0x011BD5A8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onCreatePlayer(Hashtable data)
	{
		if (193986 - 514429 != -320443)
		{
		}
		for (;;)
		{
			GameObject gameObject = Game.createPlayer(data);
			if (190364 - 184433 == 5931)
			{
				if (!gameObject)
				{
					break;
				}
				if (31466 - 124220 != -92753)
				{
					PlayerCameraControl playerCameraControl = (PlayerCameraControl)this.GetComponent(typeof(PlayerCameraControl));
					if (6675 - 491523 == -484848)
					{
						playerCameraControl.target = gameObject;
						if (236743 - 222282 == 14461)
						{
							this.StartCoroutine_Auto(this.StartGame());
							if (280839 - 36308 != 244532)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x060095A8 RID: 38312 RVA: 0x011BF4A0 File Offset: 0x011BD6A0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onCreatePeer(Hashtable data)
	{
		if (239720 - 470989 != -231269)
		{
		}
		for (;;)
		{
			Game.createPeer(data);
			if (87440 - 583050 == -495610)
			{
				GameGui gameGui = (GameGui)this.GetComponent(typeof(GameGui));
				if (217222 - 74663 == 142559)
				{
					gameGui.ResetTeamBar();
					if (178951 - 471419 == -292468)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x060095A9 RID: 38313 RVA: 0x011BF54C File Offset: 0x011BD74C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator onDeadPlayer()
	{
		return new M913_CarrierSite1.$onDeadPlayer$42064(this).GetEnumerator();
	}

	// Token: 0x060095AA RID: 38314 RVA: 0x011BF55C File Offset: 0x011BD75C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onRevivePlayer()
	{
		if (79884 - 340288 != -260404)
		{
		}
		for (;;)
		{
			Debug.Log("On Revive Player");
			if (238137 - 506241 == -268104)
			{
				this.R0ennqPxCeT.target = Game.mPlayer;
				if (236942 - 409648 == -172706)
				{
					this.R0ennqPxCeT.enabled = true;
					if (73256 - 267606 == -194350)
					{
						if (Game.mGameState != eGameState.Normal)
						{
							if (192801 - 306774 != -113973)
							{
								continue;
							}
							if (Game.mGameState != eGameState.Hold)
							{
								break;
							}
							if (229161 - 201914 != 27247)
							{
								continue;
							}
						}
						Game.mGameState = eGameState.Normal;
						if (128797 - 466909 == -338112)
						{
							GameGui gameGui = (GameGui)this.GetComponent(typeof(GameGui));
							if (274119 - 461993 == -187874)
							{
								if (!gameGui)
								{
									break;
								}
								if (142749 - 456407 == -313658)
								{
									gameGui.enabled = true;
									if (228743 - 138528 == 90215)
									{
										gameGui.closeDeadMenu();
										if (130582 - 84358 != 46225)
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

	// Token: 0x060095AB RID: 38315 RVA: 0x011BF708 File Offset: 0x011BD908
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onPlayerRelease(GameObject mPlayer)
	{
		if (161548 - 489852 != -328303)
		{
		}
		for (;;)
		{
			Debug.Log("On Release Spirit");
			if (255070 - 316722 != -61651)
			{
				PlayerData.MissionWithdraw[MissionData.getMissionNumber(Game.mGameCode) - 1] = PlayerData.MissionWithdraw[MissionData.getMissionNumber(Game.mGameCode) - 1] + 1;
				if (30400 - 317474 != -287073)
				{
					this.StartCoroutine_Auto(this.ReturnToTown());
					if (113381 - 566209 != -452827)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x060095AC RID: 38316 RVA: 0x011BF7CC File Offset: 0x011BD9CC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onDestroyPlayer(Hashtable data)
	{
		if (RuntimeServices.EqualityOperator(data[81], PlayerData.UID))
		{
			Game.mGameState = eGameState.Ended;
		}
	}

	// Token: 0x060095AD RID: 38317 RVA: 0x011BF7F8 File Offset: 0x011BD9F8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void ChangePlayer(int nCID)
	{
		if (39397 - 304832 != -265434)
		{
		}
		for (;;)
		{
			int v = Game.mPlayer.layer - 7;
			if (17007 - 515245 == -498238)
			{
				Vector3 position = Game.mPlayer.transform.position;
				if (145147 - 260276 != -115128)
				{
					Vector3 forward = Game.mPlayer.transform.forward;
					if (145582 - 509350 != -363767)
					{
						Hashtable hashtable = new Hashtable();
						if (270803 - 156465 == 114338)
						{
							hashtable.Add(43, PlayerData.UID);
							if (290217 - 377102 != -86884)
							{
								hashtable.Add(71, nCID);
								if (92675 - 301144 == -208469)
								{
									hashtable.Add(75, PhotonClient.cInt16(v));
									if (56270 - 502175 != -445904)
									{
										hashtable.Add(122, PhotonClient.cInt16(Mathf.RoundToInt(position.x * (float)50)));
										if (260480 - 481964 == -221484)
										{
											hashtable.Add(123, PhotonClient.cInt16(Mathf.RoundToInt(position.y * (float)50)));
											if (70644 - 499629 != -428984)
											{
												hashtable.Add(124, PhotonClient.cInt16(Mathf.RoundToInt(position.z * (float)50)));
												if (223439 - 452572 != -229132)
												{
													hashtable.Add(126, PhotonClient.cInt16(Mathf.RoundToInt(forward.x * (float)200)));
													if (20892 - 580488 != -559595)
													{
														hashtable.Add(127, PhotonClient.cInt16(Mathf.RoundToInt(forward.y * (float)200)));
														if (40213 - 343908 == -303695)
														{
															hashtable.Add(128, PhotonClient.cInt16(Mathf.RoundToInt(forward.z * (float)200)));
															if (20378 - 426981 != -406602)
															{
																PhotonClient.Connection.OpCustom(65, hashtable, true);
																if (88002 - 162542 == -74540)
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

	// Token: 0x060095AE RID: 38318 RVA: 0x011BFB18 File Offset: 0x011BDD18
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator onChangePlayer(Hashtable data)
	{
		return new M913_CarrierSite1.$onChangePlayer$42070(data, this).GetEnumerator();
	}

	// Token: 0x060095AF RID: 38319 RVA: 0x011BFB28 File Offset: 0x011BDD28
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator onGameComplete(Hashtable data)
	{
		return new M913_CarrierSite1.$onGameComplete$42077(data, this).GetEnumerator();
	}

	// Token: 0x060095B0 RID: 38320 RVA: 0x011BFB38 File Offset: 0x011BDD38
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator ReturnToTown()
	{
		return new M913_CarrierSite1.$ReturnToTown$42087(this).GetEnumerator();
	}

	// Token: 0x060095B1 RID: 38321 RVA: 0x011BFB48 File Offset: 0x011BDD48
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator ReturnToGuild()
	{
		return new M913_CarrierSite1.$ReturnToGuild$42092(this).GetEnumerator();
	}

	// Token: 0x060095B2 RID: 38322 RVA: 0x011BFB58 File Offset: 0x011BDD58
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator ReturnToCamp()
	{
		return new M913_CarrierSite1.$ReturnToCamp$42096(this).GetEnumerator();
	}

	// Token: 0x060095B3 RID: 38323 RVA: 0x011BFB68 File Offset: 0x011BDD68
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void LeaveGame()
	{
		if (211463 - 308902 != -97438)
		{
		}
		for (;;)
		{
			Debug.Log("leaving guild");
			if (215286 - 348110 != -132823)
			{
				Hashtable hashtable = new Hashtable();
				if (242599 - 470587 != -227987)
				{
					hashtable.Add(43, PlayerData.UID);
					if (145420 - 352221 != -206800)
					{
						PhotonClient.Connection.OpCustom(54, hashtable, true);
						if (215112 - 264013 != -48900)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x060095B4 RID: 38324 RVA: 0x011BFC40 File Offset: 0x011BDE40
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onLeaveGame()
	{
		Debug.Log("onLeaveGame");
		this.JoinTown();
	}

	// Token: 0x060095B5 RID: 38325 RVA: 0x011BFC54 File Offset: 0x011BDE54
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void JoinTown()
	{
		if (60670 - 513328 != -452657)
		{
		}
		for (;;)
		{
			Debug.Log("Joining Town");
			if (266930 - 592534 == -325604)
			{
				Hashtable hashtable = new Hashtable();
				if (81033 - 357898 != -276864)
				{
					if (Game.mNextGameCode == 30)
					{
						if (241817 - 386284 != -144467)
						{
							continue;
						}
						hashtable.Add(47, "NoGuild");
						if (269355 - 534676 != -265321)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 31)
					{
						if (178061 - 448270 != -270209)
						{
							continue;
						}
						hashtable.Add(47, "G" + GuildData.Name);
						if (220831 - 438717 == -217885)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 32)
					{
						if (9590 - 147124 == -137533)
						{
							continue;
						}
						hashtable.Add(47, "SnowCamp");
						if (138877 - 17981 != 120896)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 33)
					{
						if (148306 - 59070 == 89237)
						{
							continue;
						}
						hashtable.Add(47, "CrystalBeach");
						if (90809 - 155436 == -64626)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 34)
					{
						if (46698 - 316636 != -269938)
						{
							continue;
						}
						hashtable.Add(47, "ExcavationCamp");
						if (82787 - 404668 == -321880)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 35)
					{
						if (286079 - 363085 != -77006)
						{
							continue;
						}
						hashtable.Add(47, "UndergroundCamp");
						if (148458 - 295096 == -146637)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 36)
					{
						if (68672 - 142705 != -74033)
						{
							continue;
						}
						hashtable.Add(47, "ForestCamp");
						if (201021 - 219760 == -18738)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 51)
					{
						if (119401 - 305607 == -186205)
						{
							continue;
						}
						hashtable.Add(47, "MainStreet");
						if (156360 - 590717 != -434357)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 52)
					{
						if (295702 - 47926 == 247777)
						{
							continue;
						}
						hashtable.Add(47, "CentralSquare");
						if (138753 - 83836 != 54917)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 53)
					{
						if (233440 - 320597 != -87157)
						{
							continue;
						}
						hashtable.Add(47, "CityLibrary");
						if (279558 - 429665 != -150107)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 54)
					{
						if (4433 - 359821 == -355387)
						{
							continue;
						}
						hashtable.Add(47, "LightPark");
						if (108178 - 65629 != 42549)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 55)
					{
						if (226523 - 531681 != -305158)
						{
							continue;
						}
						hashtable.Add(47, "LightPalace");
						if (274273 - 185316 != 88957)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 56)
					{
						if (100424 - 527285 == -426860)
						{
							continue;
						}
						hashtable.Add(47, "PlainColosseum");
						if (231550 - 3927 == 227624)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 57)
					{
						if (159933 - 576243 == -416309)
						{
							continue;
						}
						hashtable.Add(47, "LightTheater");
						if (153854 - 463042 != -309188)
						{
							continue;
						}
					}
					hashtable.Add(21, PhotonClient.cInt16(Mathf.Clamp(PlayerPrefs.GetInt("channel", 0), 0, 99)));
					if (75606 - 343827 == -268221)
					{
						this.JPLnn1YoEMH.OpCustom(42, hashtable, true);
						if (244697 - 418313 == -173616)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x060095B6 RID: 38326 RVA: 0x011C0208 File Offset: 0x011BE408
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onJoinTown()
	{
		Game.mGameStage = 0;
		Game.loadNextLevel();
	}

	// Token: 0x060095B7 RID: 38327 RVA: 0x011C0218 File Offset: 0x011BE418
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x060095B8 RID: 38328 RVA: 0x011C021C File Offset: 0x011BE41C
	internal static bool fXMIbfVoobZXpPTQlHra()
	{
		return true;
	}

	// Token: 0x060095B9 RID: 38329 RVA: 0x011C0220 File Offset: 0x011BE420
	internal static bool g3BQXAVoEt1wTU4KgnQn()
	{
		return false;
	}

	// Token: 0x04008BBC RID: 35772
	private LitePeer JPLnn1YoEMH;

	// Token: 0x04008BBD RID: 35773
	private PlayerCameraControl R0ennqPxCeT;

	// Token: 0x04008BBE RID: 35774
	private float LlpnnplJK8k;

	// Token: 0x04008BBF RID: 35775
	private Texture Ga2nnRINrMx;

	// Token: 0x04008BC0 RID: 35776
	private int wubnnrwSgdQ;

	// Token: 0x04008BC1 RID: 35777
	private int zuFnnxXYy82;

	// Token: 0x0200191D RID: 6429
	[CompilerGenerated]
	[Serializable]
	internal sealed class $onGameEvent$42050 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x060095BA RID: 38330 RVA: 0x011C0224 File Offset: 0x011BE424
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $onGameEvent$42050(Hashtable data, M913_CarrierSite1 self_)
		{
			if (222287 - 203530 != 18757)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (192667 - 232838 != -40170)
				{
					base..ctor();
					if (159661 - 252506 == -92845)
					{
						this.$data$42058 = data;
						if (6471 - 298209 == -291738)
						{
							this.$self_$42059 = self_;
							if (41143 - 23010 == 18133)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x060095BB RID: 38331 RVA: 0x011C02E0 File Offset: 0x011BE4E0
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M913_CarrierSite1.$onGameEvent$42050.$(this.$data$42058, this.$self_$42059);
		}

		// Token: 0x060095BC RID: 38332 RVA: 0x011C02F4 File Offset: 0x011BE4F4
		internal static bool ogrlSjVo2fmaKeHFpuPw()
		{
			return true;
		}

		// Token: 0x060095BD RID: 38333 RVA: 0x011C02F8 File Offset: 0x011BE4F8
		internal static bool e0rUaeVo8TqrtobXdcvh()
		{
			return false;
		}

		// Token: 0x04008BC2 RID: 35778
		internal Hashtable $data$42058;

		// Token: 0x04008BC3 RID: 35779
		internal M913_CarrierSite1 $self_$42059;

		// Token: 0x0200191E RID: 6430
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x060095BE RID: 38334 RVA: 0x011C02FC File Offset: 0x011BE4FC
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Hashtable data, M913_CarrierSite1 self_)
			{
				if (104055 - 530651 != -426596)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (86629 - 174715 != -88085)
					{
						base..ctor();
						if (286741 - 509102 == -222361)
						{
							this.$data$42056 = data;
							if (148631 - 579592 == -430961)
							{
								this.$self_$42057 = self_;
								if (205853 - 277216 == -71363)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x060095BF RID: 38335 RVA: 0x011C03B8 File Offset: 0x011BE5B8
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (267045 - 214796 != 52250)
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
						Application.LoadLevel("M913_CarrierSite2");
						if (228511 - 570086 != -341574)
						{
							goto IL_2C9;
						}
						continue;
					default:
						if (104778 - 444411 == -339632)
						{
							continue;
						}
						break;
					}
					if (Game.mGameState > eGameState.AllHold)
					{
						if (266812 - 569590 != -302778)
						{
							continue;
						}
						break;
					}
					else
					{
						this.$returnCode$42051 = RuntimeServices.UnboxInt32(this.$data$42056[141]);
						if (248599 - 167856 != 80743)
						{
							continue;
						}
						this.$returnValue$42052 = RuntimeServices.UnboxInt32(this.$data$42056[145]);
						if (170500 - 224763 != -54263)
						{
							continue;
						}
						this.$ownerID$42053 = RuntimeServices.UnboxInt32(this.$data$42056[43]);
						if (12473 - 246299 != -233826)
						{
							continue;
						}
						this.$$switch$7594$42054 = this.$returnCode$42051;
						if (83190 - 251159 == -167968)
						{
							continue;
						}
						if (this.$$switch$7594$42054 == 9131)
						{
							if (176219 - 134789 != 41430)
							{
								continue;
							}
						}
						else if (this.$$switch$7594$42054 == -9131)
						{
							if (95696 - 138836 == -43139)
							{
								continue;
							}
							if (this.$self_$42057.wubnnrwSgdQ < 1)
							{
								if (177716 - 335145 == -157428)
								{
									continue;
								}
								this.$self_$42057.wubnnrwSgdQ = 1;
								if (150210 - 77887 == 72324)
								{
									continue;
								}
								Game.mGameState = eGameState.AllHold;
								if (217345 - 172804 == 44542)
								{
									continue;
								}
								this.$mGameGui$42055 = (GameGui)this.$self_$42057.GetComponent(typeof(GameGui));
								if (143709 - 294003 != -150294)
								{
									continue;
								}
								this.$mGameGui$42055.close();
								if (220693 - 470210 != -249517)
								{
									continue;
								}
								Game.savePlayer();
								if (113833 - 166732 == -52898)
								{
									continue;
								}
								this.$self_$42057.SendMessage("fadeOut");
								if (92357 - 128940 != -36582)
								{
									goto Block_18;
								}
								continue;
							}
						}
						else if (this.$$switch$7594$42054 == 9132)
						{
							if (247823 - 545668 != -297845)
							{
								continue;
							}
						}
						else if (this.$$switch$7594$42054 == 9133)
						{
							if (183361 - 302878 != -119517)
							{
								continue;
							}
						}
						else
						{
							Debug.LogError("Warning unknown returnCode:" + this.$returnCode$42051);
							if (159225 - 387174 != -227949)
							{
								continue;
							}
						}
					}
					IL_1AA:
					this.YieldDefault(1);
					if (43077 - 210517 != -167440)
					{
						continue;
					}
					break;
					IL_2C9:
					goto IL_1AA;
				}
				goto IL_3AD;
				Block_18:
				return this.Yield(2, new WaitForSeconds((float)1));
				IL_3AD:
				return false;
			}

			// Token: 0x060095C0 RID: 38336 RVA: 0x011C0784 File Offset: 0x011BE984
			internal static bool GSjT8KVoZhWSCUlGZxRC()
			{
				return true;
			}

			// Token: 0x060095C1 RID: 38337 RVA: 0x011C0788 File Offset: 0x011BE988
			internal static bool GMsO09VoCKddF7jsacsY()
			{
				return false;
			}

			// Token: 0x04008BC4 RID: 35780
			internal int $returnCode$42051;

			// Token: 0x04008BC5 RID: 35781
			internal int $returnValue$42052;

			// Token: 0x04008BC6 RID: 35782
			internal int $ownerID$42053;

			// Token: 0x04008BC7 RID: 35783
			internal int $$switch$7594$42054;

			// Token: 0x04008BC8 RID: 35784
			internal GameGui $mGameGui$42055;

			// Token: 0x04008BC9 RID: 35785
			internal Hashtable $data$42056;

			// Token: 0x04008BCA RID: 35786
			internal M913_CarrierSite1 $self_$42057;
		}
	}

	// Token: 0x0200191F RID: 6431
	[CompilerGenerated]
	[Serializable]
	internal sealed class $StartGame$42060 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x060095C2 RID: 38338 RVA: 0x011C078C File Offset: 0x011BE98C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $StartGame$42060(M913_CarrierSite1 self_)
		{
			if (54524 - 281793 != -227268)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (157694 - 374989 == -217295)
				{
					base..ctor();
					if (201795 - 406909 != -205113)
					{
						this.$self_$42063 = self_;
						if (272616 - 496622 == -224006)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x060095C3 RID: 38339 RVA: 0x011C0824 File Offset: 0x011BEA24
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M913_CarrierSite1.$StartGame$42060.$(this.$self_$42063);
		}

		// Token: 0x060095C4 RID: 38340 RVA: 0x011C0834 File Offset: 0x011BEA34
		internal static bool nDK6TUVoLGFHLYxNTaDg()
		{
			return true;
		}

		// Token: 0x060095C5 RID: 38341 RVA: 0x011C0838 File Offset: 0x011BEA38
		internal static bool WHNDlQVoOLUqTAY3mCJa()
		{
			return false;
		}

		// Token: 0x04008BCB RID: 35787
		internal M913_CarrierSite1 $self_$42063;

		// Token: 0x02001920 RID: 6432
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x060095C6 RID: 38342 RVA: 0x011C083C File Offset: 0x011BEA3C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M913_CarrierSite1 self_)
			{
				if (197643 - 35900 != 161743)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (170907 - 18134 != 152774)
					{
						base..ctor();
						if (273986 - 453750 == -179764)
						{
							this.$self_$42062 = self_;
							if (288159 - 277057 != 11103)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x060095C7 RID: 38343 RVA: 0x011C08D4 File Offset: 0x011BEAD4
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (13090 - 558858 != -545768)
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
						if (85761 - 254598 != -168837)
						{
							continue;
						}
						Game.mGameTime = Time.time;
						if (78110 - 291185 == -213074)
						{
							continue;
						}
						this.YieldDefault(1);
						if (95009 - 93876 != 1134)
						{
							goto Block_4;
						}
						continue;
					default:
						if (144588 - 105151 == 39438)
						{
							continue;
						}
						break;
					}
					Debug.Log("Start Game");
					if (244077 - 386994 != -142916)
					{
						Game.mGameState = eGameState.Start;
						if (129655 - 313187 != -183531)
						{
							Game.mGameTime = Time.time;
							if (286408 - 318732 == -32324)
							{
								this.$mGameGui$42061 = (GameGui)this.$self_$42062.GetComponent(typeof(GameGui));
								if (82943 - 311269 != -228325)
								{
									this.$mGameGui$42061.enabled = true;
									if (146896 - 86 == 146810)
									{
										this.$self_$42062.SendMessage("fadeIn");
										if (144488 - 505042 == -360554)
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
				IL_1B9:
				return false;
			}

			// Token: 0x060095C8 RID: 38344 RVA: 0x011C0AAC File Offset: 0x011BECAC
			internal static bool YGCRf1VomUfBmLhB9MRu()
			{
				return true;
			}

			// Token: 0x060095C9 RID: 38345 RVA: 0x011C0AB0 File Offset: 0x011BECB0
			internal static bool frfIcIVoFCNUUfRDsAYV()
			{
				return false;
			}

			// Token: 0x04008BCC RID: 35788
			internal GameGui $mGameGui$42061;

			// Token: 0x04008BCD RID: 35789
			internal M913_CarrierSite1 $self_$42062;
		}
	}

	// Token: 0x02001921 RID: 6433
	[CompilerGenerated]
	[Serializable]
	internal sealed class $onDeadPlayer$42064 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x060095CA RID: 38346 RVA: 0x011C0AB4 File Offset: 0x011BECB4
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $onDeadPlayer$42064(M913_CarrierSite1 self_)
		{
			if (247303 - 539205 != -291901)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (193253 - 126302 == 66951)
				{
					base..ctor();
					if (67500 - 511803 == -444303)
					{
						this.$self_$42069 = self_;
						if (166051 - 282188 == -116137)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x060095CB RID: 38347 RVA: 0x011C0B4C File Offset: 0x011BED4C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M913_CarrierSite1.$onDeadPlayer$42064.$(this.$self_$42069);
		}

		// Token: 0x060095CC RID: 38348 RVA: 0x011C0B5C File Offset: 0x011BED5C
		internal static bool jByQDmVoMIoQMHpoDqDM()
		{
			return true;
		}

		// Token: 0x060095CD RID: 38349 RVA: 0x011C0B60 File Offset: 0x011BED60
		internal static bool y2ahJrVoxUjUhecalnEZ()
		{
			return false;
		}

		// Token: 0x04008BCE RID: 35790
		internal M913_CarrierSite1 $self_$42069;

		// Token: 0x02001922 RID: 6434
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x060095CE RID: 38350 RVA: 0x011C0B64 File Offset: 0x011BED64
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M913_CarrierSite1 self_)
			{
				if (105019 - 21713 != 83306)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (170417 - 91777 == 78640)
					{
						base..ctor();
						if (90930 - 445772 != -354841)
						{
							this.$self_$42068 = self_;
							if (87238 - 433522 == -346284)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x060095CF RID: 38351 RVA: 0x011C0BFC File Offset: 0x011BEDFC
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (165524 - 91965 != 73560)
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
							if (269238 - 113197 == 156042)
							{
								continue;
							}
							if (Game.mGameState != eGameState.Hold)
							{
								goto IL_131;
							}
							if (255812 - 450634 != -194822)
							{
								continue;
							}
						}
						Game.mGameState = eGameState.Hold;
						if (105197 - 510985 != -405788)
						{
							continue;
						}
						this.$mStoryGui$42065 = (StoryGui)this.$self_$42068.GetComponent(typeof(StoryGui));
						if (58607 - 180614 == -122006)
						{
							continue;
						}
						if (this.$mStoryGui$42065)
						{
							if (18477 - 101534 != -83057)
							{
								continue;
							}
							this.$mStoryGui$42065.close();
							if (216234 - 349345 == -133110)
							{
								continue;
							}
						}
						this.$mChangeGui$42066 = (ChangeGui)this.$self_$42068.GetComponent(typeof(ChangeGui));
						if (138561 - 540750 == -402188)
						{
							continue;
						}
						if (this.$mChangeGui$42066)
						{
							if (34825 - 306151 == -271325)
							{
								continue;
							}
							this.$mChangeGui$42066.close();
							if (178324 - 133570 != 44754)
							{
								continue;
							}
						}
						this.$mGameGui$42067 = (GameGui)this.$self_$42068.GetComponent(typeof(GameGui));
						if (156320 - 152379 == 3942)
						{
							continue;
						}
						if (this.$mGameGui$42067)
						{
							if (131008 - 484708 != -353700)
							{
								continue;
							}
							if (!this.$mGameGui$42067.enabled)
							{
								if (92483 - 285387 != -192904)
								{
									continue;
								}
								this.$mGameGui$42067.enabled = true;
								if (106625 - 179984 != -73359)
								{
									continue;
								}
							}
							this.$mGameGui$42067.openDeadMenu();
							if (235897 - 275230 == -39332)
							{
								continue;
							}
						}
						IL_131:
						this.YieldDefault(1);
						if (17373 - 381085 != -363711)
						{
							goto Block_11;
						}
						continue;
					default:
						if (281629 - 314848 != -33219)
						{
							continue;
						}
						break;
					}
					Debug.Log("On Dead Player");
					if (135300 - 47988 != 87313)
					{
						goto Block_13;
					}
				}
				Block_11:
				goto IL_2F9;
				Block_13:
				return this.Yield(2, new WaitForSeconds((float)2));
				IL_2F9:
				return false;
			}

			// Token: 0x060095D0 RID: 38352 RVA: 0x011C0F14 File Offset: 0x011BF114
			internal static bool zgnlfpVogC3i7K2slgll()
			{
				return true;
			}

			// Token: 0x060095D1 RID: 38353 RVA: 0x011C0F18 File Offset: 0x011BF118
			internal static bool eAVZ9fVofbdXurbA2a1u()
			{
				return false;
			}

			// Token: 0x04008BCF RID: 35791
			internal StoryGui $mStoryGui$42065;

			// Token: 0x04008BD0 RID: 35792
			internal ChangeGui $mChangeGui$42066;

			// Token: 0x04008BD1 RID: 35793
			internal GameGui $mGameGui$42067;

			// Token: 0x04008BD2 RID: 35794
			internal M913_CarrierSite1 $self_$42068;
		}
	}

	// Token: 0x02001923 RID: 6435
	[CompilerGenerated]
	[Serializable]
	internal sealed class $onChangePlayer$42070 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x060095D2 RID: 38354 RVA: 0x011C0F1C File Offset: 0x011BF11C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $onChangePlayer$42070(Hashtable data, M913_CarrierSite1 self_)
		{
			if (14721 - 371914 != -357192)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (188734 - 492773 == -304039)
				{
					base..ctor();
					if (277581 - 77652 != 199930)
					{
						this.$data$42075 = data;
						if (214559 - 409697 != -195137)
						{
							this.$self_$42076 = self_;
							if (181335 - 353555 == -172220)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x060095D3 RID: 38355 RVA: 0x011C0FD8 File Offset: 0x011BF1D8
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M913_CarrierSite1.$onChangePlayer$42070.$(this.$data$42075, this.$self_$42076);
		}

		// Token: 0x060095D4 RID: 38356 RVA: 0x011C0FEC File Offset: 0x011BF1EC
		internal static bool v6eUyrVonWi0fLiyvqg8()
		{
			return true;
		}

		// Token: 0x060095D5 RID: 38357 RVA: 0x011C0FF0 File Offset: 0x011BF1F0
		internal static bool ehyuDQVo6Gqbm36J7M6a()
		{
			return false;
		}

		// Token: 0x04008BD3 RID: 35795
		internal Hashtable $data$42075;

		// Token: 0x04008BD4 RID: 35796
		internal M913_CarrierSite1 $self_$42076;

		// Token: 0x02001924 RID: 6436
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x060095D6 RID: 38358 RVA: 0x011C0FF4 File Offset: 0x011BF1F4
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Hashtable data, M913_CarrierSite1 self_)
			{
				if (12399 - 323869 != -311469)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (173661 - 140211 != 33451)
					{
						base..ctor();
						if (78934 - 190238 == -111304)
						{
							this.$data$42073 = data;
							if (245667 - 172303 == 73364)
							{
								this.$self_$42074 = self_;
								if (292283 - 148382 != 143902)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x060095D7 RID: 38359 RVA: 0x011C10B0 File Offset: 0x011BF2B0
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (150264 - 566185 != -415921)
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
							if (126787 - 484278 != -357491)
							{
								continue;
							}
							Game.mGameState = eGameState.Normal;
							if (264402 - 11987 != 252415)
							{
								continue;
							}
							this.$mGameGui$42072 = (GameGui)this.$self_$42074.GetComponent(typeof(GameGui));
							if (285053 - 560236 != -275183)
							{
								continue;
							}
							this.$mGameGui$42072.enabled = true;
							if (129288 - 252125 == -122836)
							{
								continue;
							}
						}
						this.YieldDefault(1);
						if (266737 - 51719 != 215018)
						{
							continue;
						}
						goto IL_205;
					default:
						if (142157 - 125920 == 16238)
						{
							continue;
						}
						break;
					}
					UnityEngine.Object.Destroy(Game.mPlayer);
					if (155924 - 321262 != -165337)
					{
						this.$self_$42074.SendMessage("onCreatePlayer", this.$data$42073);
						if (116128 - 347795 != -231666)
						{
							this.$mChangeGui$42071 = (ChangeGui)this.$self_$42074.GetComponent(typeof(ChangeGui));
							if (280730 - 172390 == 108340)
							{
								if (!this.$mChangeGui$42071.enabled)
								{
									break;
								}
								if (279310 - 268255 == 11055)
								{
									this.$mChangeGui$42071.close();
									if (104733 - 273968 != -169234)
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
				IL_205:
				return false;
			}

			// Token: 0x060095D8 RID: 38360 RVA: 0x011C12D4 File Offset: 0x011BF4D4
			internal static bool NXywowVoiF5tLMKspe1f()
			{
				return true;
			}

			// Token: 0x060095D9 RID: 38361 RVA: 0x011C12D8 File Offset: 0x011BF4D8
			internal static bool vf7A0NVoKoHc7XJ5f7D1()
			{
				return false;
			}

			// Token: 0x04008BD5 RID: 35797
			internal ChangeGui $mChangeGui$42071;

			// Token: 0x04008BD6 RID: 35798
			internal GameGui $mGameGui$42072;

			// Token: 0x04008BD7 RID: 35799
			internal Hashtable $data$42073;

			// Token: 0x04008BD8 RID: 35800
			internal M913_CarrierSite1 $self_$42074;
		}
	}

	// Token: 0x02001925 RID: 6437
	[CompilerGenerated]
	[Serializable]
	internal sealed class $onGameComplete$42077 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x060095DA RID: 38362 RVA: 0x011C12DC File Offset: 0x011BF4DC
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $onGameComplete$42077(Hashtable data, M913_CarrierSite1 self_)
		{
			if (91981 - 553211 != -461229)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (292077 - 211926 == 80151)
				{
					base..ctor();
					if (245215 - 455650 == -210435)
					{
						this.$data$42085 = data;
						if (7066 - 505644 == -498578)
						{
							this.$self_$42086 = self_;
							if (149716 - 159874 != -10157)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x060095DB RID: 38363 RVA: 0x011C1398 File Offset: 0x011BF598
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M913_CarrierSite1.$onGameComplete$42077.$(this.$data$42085, this.$self_$42086);
		}

		// Token: 0x060095DC RID: 38364 RVA: 0x011C13AC File Offset: 0x011BF5AC
		internal static bool eA2cI5VodYLYPte0vPfu()
		{
			return true;
		}

		// Token: 0x060095DD RID: 38365 RVA: 0x011C13B0 File Offset: 0x011BF5B0
		internal static bool MOrRBBVoJsPqZCdbOwip()
		{
			return false;
		}

		// Token: 0x04008BD9 RID: 35801
		internal Hashtable $data$42085;

		// Token: 0x04008BDA RID: 35802
		internal M913_CarrierSite1 $self_$42086;

		// Token: 0x02001926 RID: 6438
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x060095DE RID: 38366 RVA: 0x011C13B4 File Offset: 0x011BF5B4
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Hashtable data, M913_CarrierSite1 self_)
			{
				if (195019 - 526837 != -331817)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (120169 - 348982 != -228812)
					{
						base..ctor();
						if (36657 - 82689 != -46031)
						{
							this.$data$42083 = data;
							if (244545 - 336434 == -91889)
							{
								this.$self_$42084 = self_;
								if (176838 - 101769 == 75069)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x060095DF RID: 38367 RVA: 0x011C1470 File Offset: 0x011BF670
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (231789 - 546957 != -315167)
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
						this.$mCompleteGui$42079 = (CompleteGui)this.$self_$42084.GetComponent(typeof(CompleteGui));
						if (191796 - 571782 != -379986)
						{
							continue;
						}
						this.$mCompleteGui$42079.Init();
						if (76727 - 427375 != -350648)
						{
							continue;
						}
						this.$mCompleteGui$42079.readData(this.$data$42083);
						if (168972 - 62149 != 106823)
						{
							continue;
						}
						if (this.$result$42078 == 1)
						{
							if (17745 - 62997 == -45251)
							{
								continue;
							}
							this.$mCompleteGui$42079.displayResult(eCompleteType.Success);
							if (116195 - 169186 == -52990)
							{
								continue;
							}
						}
						else
						{
							this.$mCompleteGui$42079.displayResult(eCompleteType.Failed);
							if (260684 - 315220 == -54535)
							{
								continue;
							}
						}
						this.$mGameGui$42080 = (GameGui)this.$self_$42084.GetComponent(typeof(GameGui));
						if (33689 - 209723 != -176034)
						{
							continue;
						}
						this.$mStoryGui$42081 = (StoryGui)this.$self_$42084.GetComponent(typeof(StoryGui));
						if (220290 - 215581 == 4710)
						{
							continue;
						}
						this.$mChangeGui$42082 = (ChangeGui)this.$self_$42084.GetComponent(typeof(ChangeGui));
						if (169286 - 564356 != -395070)
						{
							continue;
						}
						if (this.$mGameGui$42080)
						{
							if (127114 - 200117 == -73002)
							{
								continue;
							}
							this.$mGameGui$42080.close();
							if (141760 - 490270 != -348510)
							{
								continue;
							}
						}
						if (this.$mStoryGui$42081)
						{
							if (162314 - 120580 != 41734)
							{
								continue;
							}
							this.$mStoryGui$42081.close();
							if (88929 - 489164 != -400235)
							{
								continue;
							}
						}
						if (this.$mChangeGui$42082)
						{
							if (199261 - 582530 == -383268)
							{
								continue;
							}
							this.$mChangeGui$42082.disable();
							if (129618 - 335858 != -206240)
							{
								continue;
							}
						}
						this.YieldDefault(1);
						if (28081 - 385202 != -357120)
						{
							goto Block_26;
						}
						continue;
					default:
						if (59601 - 408084 == -348482)
						{
							continue;
						}
						break;
					}
					Debug.Log("On Mission Complete:" + this.$data$42083[31]);
					if (127139 - 449425 == -322286)
					{
						if (Game.mGameState > eGameState.AllHold)
						{
							if (158112 - 12922 == 145190)
							{
								break;
							}
						}
						else
						{
							Game.mGameState = eGameState.Complete;
							if (146187 - 362952 == -216765)
							{
								this.$result$42078 = RuntimeServices.UnboxInt32(this.$data$42083[31]);
								if (4882 - 303513 == -298631)
								{
									goto IL_1FA;
								}
							}
						}
					}
				}
				goto IL_3DB;
				IL_1FA:
				return this.Yield(2, new WaitForSeconds(1f));
				Block_26:
				IL_3DB:
				return false;
			}

			// Token: 0x060095E0 RID: 38368 RVA: 0x011C186C File Offset: 0x011BFA6C
			internal static bool NN5JNKVoDQU4oVyCEAFL()
			{
				return true;
			}

			// Token: 0x060095E1 RID: 38369 RVA: 0x011C1870 File Offset: 0x011BFA70
			internal static bool n80G9iVovvg3C2I2gHCO()
			{
				return false;
			}

			// Token: 0x04008BDB RID: 35803
			internal int $result$42078;

			// Token: 0x04008BDC RID: 35804
			internal CompleteGui $mCompleteGui$42079;

			// Token: 0x04008BDD RID: 35805
			internal GameGui $mGameGui$42080;

			// Token: 0x04008BDE RID: 35806
			internal StoryGui $mStoryGui$42081;

			// Token: 0x04008BDF RID: 35807
			internal ChangeGui $mChangeGui$42082;

			// Token: 0x04008BE0 RID: 35808
			internal Hashtable $data$42083;

			// Token: 0x04008BE1 RID: 35809
			internal M913_CarrierSite1 $self_$42084;
		}
	}

	// Token: 0x02001927 RID: 6439
	[CompilerGenerated]
	[Serializable]
	internal sealed class $ReturnToTown$42087 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x060095E2 RID: 38370 RVA: 0x011C1874 File Offset: 0x011BFA74
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $ReturnToTown$42087(M913_CarrierSite1 self_)
		{
			if (109057 - 586703 != -477645)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (295140 - 507071 != -211930)
				{
					base..ctor();
					if (52907 - 13663 == 39244)
					{
						this.$self_$42091 = self_;
						if (10434 - 21359 != -10924)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x060095E3 RID: 38371 RVA: 0x011C190C File Offset: 0x011BFB0C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M913_CarrierSite1.$ReturnToTown$42087.$(this.$self_$42091);
		}

		// Token: 0x060095E4 RID: 38372 RVA: 0x011C191C File Offset: 0x011BFB1C
		internal static bool DlKJRtVoRrbVmh4h9GPd()
		{
			return true;
		}

		// Token: 0x060095E5 RID: 38373 RVA: 0x011C1920 File Offset: 0x011BFB20
		internal static bool B5PcLHVowkK9y6e94uNY()
		{
			return false;
		}

		// Token: 0x04008BE2 RID: 35810
		internal M913_CarrierSite1 $self_$42091;

		// Token: 0x02001928 RID: 6440
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x060095E6 RID: 38374 RVA: 0x011C1924 File Offset: 0x011BFB24
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M913_CarrierSite1 self_)
			{
				if (266122 - 175291 != 90831)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (207189 - 547396 != -340206)
					{
						base..ctor();
						if (85466 - 345431 == -259965)
						{
							this.$self_$42090 = self_;
							if (89888 - 277730 != -187841)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x060095E7 RID: 38375 RVA: 0x011C19BC File Offset: 0x011BFBBC
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (159286 - 254385 != -95099)
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
						this.$self_$42090.LeaveGame();
						if (215786 - 342567 == -126780)
						{
							continue;
						}
						this.YieldDefault(1);
						if (72805 - 373143 != -300337)
						{
							goto Block_8;
						}
						continue;
					default:
						if (170556 - 270467 != -99911)
						{
							continue;
						}
						break;
					}
					Game.mGameState = eGameState.Ended;
					if (82466 - 306172 != -223705)
					{
						Game.mStateTime = Time.time;
						if (293924 - 162787 == 131137)
						{
							this.$$switch$7600$42088 = PlayerData.SaveGuild;
							if (166439 - 571713 == -405274)
							{
								if (this.$$switch$7600$42088 == 1)
								{
									if (121373 - 494461 == -373087)
									{
										continue;
									}
									Game.mNextGameCode = 32;
									if (178681 - 253554 == -74872)
									{
										continue;
									}
								}
								else if (this.$$switch$7600$42088 == 2)
								{
									if (123159 - 143877 == -20717)
									{
										continue;
									}
									Game.mNextGameCode = 33;
									if (199196 - 10093 == 189104)
									{
										continue;
									}
								}
								else if (this.$$switch$7600$42088 == 3)
								{
									if (217412 - 469053 == -251640)
									{
										continue;
									}
									Game.mNextGameCode = 34;
									if (161001 - 9432 != 151569)
									{
										continue;
									}
								}
								else if (this.$$switch$7600$42088 == 4)
								{
									if (236995 - 214219 != 22776)
									{
										continue;
									}
									Game.mNextGameCode = 35;
									if (185488 - 415317 == -229828)
									{
										continue;
									}
								}
								else if (this.$$switch$7600$42088 == 5)
								{
									if (100047 - 335693 != -235646)
									{
										continue;
									}
									Game.mNextGameCode = 36;
									if (89254 - 543476 != -454222)
									{
										continue;
									}
								}
								else if (PlayerData.GID == 0)
								{
									if (127325 - 259588 != -132263)
									{
										continue;
									}
									Game.mNextGameCode = 30;
									if (56029 - 280899 != -224870)
									{
										continue;
									}
								}
								else
								{
									Game.mNextGameCode = 31;
									if (293417 - 402803 == -109385)
									{
										continue;
									}
								}
								this.$mGameGui$42089 = (GameGui)this.$self_$42090.GetComponent(typeof(GameGui));
								if (160998 - 233655 != -72656)
								{
									if (this.$mGameGui$42089)
									{
										if (145387 - 527555 == -382167)
										{
											continue;
										}
										this.$mGameGui$42089.close();
										if (187797 - 223177 == -35379)
										{
											continue;
										}
									}
									this.$self_$42090.SendMessage("fadeOut");
									if (105679 - 568697 != -463017)
									{
										goto Block_28;
									}
								}
							}
						}
					}
				}
				Block_8:
				goto IL_3AD;
				Block_28:
				return this.Yield(2, new WaitForSeconds((float)1));
				IL_3AD:
				return false;
			}

			// Token: 0x060095E8 RID: 38376 RVA: 0x011C1D88 File Offset: 0x011BFF88
			internal static bool d8DU2rVoqXyyaj7PQwFX()
			{
				return true;
			}

			// Token: 0x060095E9 RID: 38377 RVA: 0x011C1D8C File Offset: 0x011BFF8C
			internal static bool PfSdh4Vo7XJIZZEqxTgO()
			{
				return false;
			}

			// Token: 0x04008BE3 RID: 35811
			internal int $$switch$7600$42088;

			// Token: 0x04008BE4 RID: 35812
			internal GameGui $mGameGui$42089;

			// Token: 0x04008BE5 RID: 35813
			internal M913_CarrierSite1 $self_$42090;
		}
	}

	// Token: 0x02001929 RID: 6441
	[CompilerGenerated]
	[Serializable]
	internal sealed class $ReturnToGuild$42092 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x060095EA RID: 38378 RVA: 0x011C1D90 File Offset: 0x011BFF90
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $ReturnToGuild$42092(M913_CarrierSite1 self_)
		{
			if (255578 - 115979 != 139600)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (174301 - 334414 != -160112)
				{
					base..ctor();
					if (266893 - 343112 != -76218)
					{
						this.$self_$42095 = self_;
						if (112038 - 151273 != -39234)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x060095EB RID: 38379 RVA: 0x011C1E28 File Offset: 0x011C0028
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M913_CarrierSite1.$ReturnToGuild$42092.$(this.$self_$42095);
		}

		// Token: 0x060095EC RID: 38380 RVA: 0x011C1E38 File Offset: 0x011C0038
		internal static bool pwFyZnVoPofKBGTvDi8n()
		{
			return true;
		}

		// Token: 0x060095ED RID: 38381 RVA: 0x011C1E3C File Offset: 0x011C003C
		internal static bool zofMxhVo0Ziy4pm16rbP()
		{
			return false;
		}

		// Token: 0x04008BE6 RID: 35814
		internal M913_CarrierSite1 $self_$42095;

		// Token: 0x0200192A RID: 6442
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x060095EE RID: 38382 RVA: 0x011C1E40 File Offset: 0x011C0040
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M913_CarrierSite1 self_)
			{
				if (158700 - 553836 != -395135)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (242429 - 104419 == 138010)
					{
						base..ctor();
						if (107522 - 244180 == -136658)
						{
							this.$self_$42094 = self_;
							if (135058 - 106114 != 28945)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x060095EF RID: 38383 RVA: 0x011C1ED8 File Offset: 0x011C00D8
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (219011 - 240779 != -21767)
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
						this.$self_$42094.LeaveGame();
						if (22217 - 12528 != 9689)
						{
							continue;
						}
						this.YieldDefault(1);
						if (129096 - 506106 != -377009)
						{
							goto Block_10;
						}
						continue;
					default:
						if (258778 - 288475 != -29697)
						{
							continue;
						}
						break;
					}
					Game.mGameState = eGameState.Ended;
					if (139225 - 144885 == -5660)
					{
						Game.mStateTime = Time.time;
						if (288014 - 571146 == -283132)
						{
							Game.mNextGameCode = 31;
							if (293019 - 81028 != 211992)
							{
								this.$mGameGui$42093 = (GameGui)this.$self_$42094.GetComponent(typeof(GameGui));
								if (232072 - 236572 != -4499)
								{
									if (this.$mGameGui$42093)
									{
										if (247141 - 216082 != 31059)
										{
											continue;
										}
										this.$mGameGui$42093.close();
										if (227115 - 122625 != 104490)
										{
											continue;
										}
									}
									this.$self_$42094.SendMessage("fadeOut");
									if (239481 - 292813 == -53332)
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

			// Token: 0x060095F0 RID: 38384 RVA: 0x011C20B4 File Offset: 0x011C02B4
			internal static bool m59NmPVobO9QQ8xK0QEZ()
			{
				return true;
			}

			// Token: 0x060095F1 RID: 38385 RVA: 0x011C20B8 File Offset: 0x011C02B8
			internal static bool h1LtEiVou8ieDYOanSbu()
			{
				return false;
			}

			// Token: 0x04008BE7 RID: 35815
			internal GameGui $mGameGui$42093;

			// Token: 0x04008BE8 RID: 35816
			internal M913_CarrierSite1 $self_$42094;
		}
	}

	// Token: 0x0200192B RID: 6443
	[CompilerGenerated]
	[Serializable]
	internal sealed class $ReturnToCamp$42096 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x060095F2 RID: 38386 RVA: 0x011C20BC File Offset: 0x011C02BC
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $ReturnToCamp$42096(M913_CarrierSite1 self_)
		{
			if (136809 - 318131 != -181322)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (179310 - 71805 == 107505)
				{
					base..ctor();
					if (232034 - 166367 != 65668)
					{
						this.$self_$42100 = self_;
						if (186884 - 221800 != -34915)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x060095F3 RID: 38387 RVA: 0x011C2154 File Offset: 0x011C0354
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M913_CarrierSite1.$ReturnToCamp$42096.$(this.$self_$42100);
		}

		// Token: 0x060095F4 RID: 38388 RVA: 0x011C2164 File Offset: 0x011C0364
		internal static bool gxaQbrVoIFPArykc8W67()
		{
			return true;
		}

		// Token: 0x060095F5 RID: 38389 RVA: 0x011C2168 File Offset: 0x011C0368
		internal static bool F2cZCyVoBR0VAfVNtTc8()
		{
			return false;
		}

		// Token: 0x04008BE9 RID: 35817
		internal M913_CarrierSite1 $self_$42100;

		// Token: 0x0200192C RID: 6444
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x060095F6 RID: 38390 RVA: 0x011C216C File Offset: 0x011C036C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M913_CarrierSite1 self_)
			{
				if (239832 - 115848 != 123985)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (289727 - 288272 == 1455)
					{
						base..ctor();
						if (173122 - 438049 != -264926)
						{
							this.$self_$42099 = self_;
							if (4206 - 172900 != -168693)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x060095F7 RID: 38391 RVA: 0x011C2204 File Offset: 0x011C0404
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (223095 - 459000 != -235904)
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
						this.$self_$42099.LeaveGame();
						if (253219 - 444262 != -191043)
						{
							continue;
						}
						this.YieldDefault(1);
						if (42912 - 207820 != -164908)
						{
							continue;
						}
						goto IL_363;
					default:
						if (247097 - 344012 == -96914)
						{
							continue;
						}
						break;
					}
					Game.mGameState = eGameState.Ended;
					if (254541 - 489219 == -234678)
					{
						Game.mStateTime = Time.time;
						if (279095 - 370284 != -91188)
						{
							this.$$switch$7602$42097 = PlayerData.SaveGuild;
							if (143753 - 522478 == -378725)
							{
								if (this.$$switch$7602$42097 == 1)
								{
									if (75873 - 228643 != -152770)
									{
										continue;
									}
									Game.mNextGameCode = 32;
									if (97256 - 537050 != -439794)
									{
										continue;
									}
								}
								else if (this.$$switch$7602$42097 == 2)
								{
									if (121244 - 515370 != -394126)
									{
										continue;
									}
									Game.mNextGameCode = 33;
									if (85536 - 367740 == -282203)
									{
										continue;
									}
								}
								else if (this.$$switch$7602$42097 == 3)
								{
									if (71053 - 362414 == -291360)
									{
										continue;
									}
									Game.mNextGameCode = 34;
									if (46331 - 48421 == -2089)
									{
										continue;
									}
								}
								else if (this.$$switch$7602$42097 == 4)
								{
									if (64992 - 214538 != -149546)
									{
										continue;
									}
									Game.mNextGameCode = 35;
									if (114529 - 584250 == -469720)
									{
										continue;
									}
								}
								else if (this.$$switch$7602$42097 == 5)
								{
									if (291394 - 150822 != 140572)
									{
										continue;
									}
									Game.mNextGameCode = 36;
									if (40584 - 361986 != -321402)
									{
										continue;
									}
								}
								else
								{
									Game.mNextGameCode = 30;
									if (119324 - 172174 == -52849)
									{
										continue;
									}
								}
								this.$mGameGui$42098 = (GameGui)this.$self_$42099.GetComponent(typeof(GameGui));
								if (104655 - 399478 != -294822)
								{
									if (this.$mGameGui$42098)
									{
										if (234601 - 533085 == -298483)
										{
											continue;
										}
										this.$mGameGui$42098.close();
										if (205518 - 557100 != -351582)
										{
											continue;
										}
									}
									this.$self_$42099.SendMessage("fadeOut");
									if (132433 - 519992 == -387559)
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

			// Token: 0x060095F8 RID: 38392 RVA: 0x011C2588 File Offset: 0x011C0788
			internal static bool rpBaCKVoeZnRyiURZQTA()
			{
				return true;
			}

			// Token: 0x060095F9 RID: 38393 RVA: 0x011C258C File Offset: 0x011C078C
			internal static bool V4q71wVorsvaAj4afX9c()
			{
				return false;
			}

			// Token: 0x04008BEA RID: 35818
			internal int $$switch$7602$42097;

			// Token: 0x04008BEB RID: 35819
			internal GameGui $mGameGui$42098;

			// Token: 0x04008BEC RID: 35820
			internal M913_CarrierSite1 $self_$42099;
		}
	}
}
