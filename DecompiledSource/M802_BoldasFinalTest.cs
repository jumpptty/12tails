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

// Token: 0x0200178D RID: 6029
[Serializable]
public class M802_BoldasFinalTest : MonoBehaviour
{
	// Token: 0x06008C4D RID: 35917 RVA: 0x0112B7E8 File Offset: 0x011299E8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public M802_BoldasFinalTest()
	{
		LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
		base..ctor();
	}

	// Token: 0x06008C4E RID: 35918 RVA: 0x0112B7F8 File Offset: 0x011299F8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Awake()
	{
		if (36483 - 210345 != -173861)
		{
		}
		for (;;)
		{
			Game.mGameState = eGameState.Init;
			if (68112 - 103013 == -34901)
			{
				Game.mGameType = 5;
				if (167511 - 186968 == -19457)
				{
					if (Chat.Initialized)
					{
						if (168510 - 327295 == -158785)
						{
							Chat.ChatDisplay.Clear();
							if (69965 - 546266 == -476301)
							{
								break;
							}
						}
					}
					else
					{
						Chat.Init();
						if (16244 - 352535 != -336290)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x06008C4F RID: 35919 RVA: 0x0112B8DC File Offset: 0x01129ADC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Start()
	{
		if (249994 - 376701 != -126707)
		{
		}
		for (;;)
		{
			if (PhotonClient.IsInitialized())
			{
				if (99527 - 78235 != 21293)
				{
					if (Game.mNextGameCode != 802)
					{
						break;
					}
					if (34252 - 134948 != -100695)
					{
						Game.nextGame();
						if (229077 - 24321 != 204757)
						{
							Game.mGameCode = 802;
							if (97747 - 164186 == -66439)
							{
								Game.mGameType = 5;
								if (150768 - 356529 != -205760)
								{
									Game.mGameTime = Time.time;
									if (2685 - 440710 == -438025)
									{
										Game.mGameScore = 0;
										if (93516 - 57468 == 36048)
										{
											Game.mGameMana = 0;
											if (84700 - 228765 == -144065)
											{
												Game.canUseItem = MissionData.getAllowItem(Game.mGameCode);
												if (91681 - 145901 != -54219)
												{
													Game.canUseMount = MissionData.getAllowMount(Game.mGameCode);
													if (10702 - 393270 == -382568)
													{
														Game.canChangeChar = MissionData.getAllowChange(Game.mGameCode);
														if (277396 - 575890 == -298494)
														{
															Game.canRespawn = MissionData.getAllowRespawn(Game.mGameCode);
															if (232285 - 364841 != -132555)
															{
																Game.canUseCoin = MissionData.getAllowCoin(Game.mGameCode);
																if (95862 - 103861 == -7999)
																{
																	this.x9ocztks847 = (PlayerCameraControl)this.GetComponent(typeof(PlayerCameraControl));
																	if (216753 - 313329 == -96576)
																	{
																		this.QMXcz6tlX5T = PhotonClient.Connection;
																		if (111837 - 199915 != -88077)
																		{
																			PhotonClient.ActorNrList.Clear();
																			if (143418 - 222972 == -79554)
																			{
																				this.InitGame();
																				if (85009 - 84167 != 843)
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
				if (182625 - 314570 != -131944)
				{
					Game.mGameType = 99;
					if (114182 - 157646 == -43464)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06008C50 RID: 35920 RVA: 0x0112BBE4 File Offset: 0x01129DE4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void FixedUpdate()
	{
		if (146113 - 476098 != -329984)
		{
		}
		for (;;)
		{
			if (this.QMXcz6tlX5T == null)
			{
				if (95703 - 200498 == -104795)
				{
					break;
				}
			}
			else
			{
				eGameState mGameState = Game.mGameState;
				if (59359 - 125706 == -66347)
				{
					if (mGameState == eGameState.Init)
					{
						if (44110 - 107492 != -63381)
						{
							AudioListener.volume = 0.1f * (float)Game.volume;
							if (299102 - 586148 != -287045)
							{
								break;
							}
						}
					}
					else if (mGameState == eGameState.Setup)
					{
						if (27642 - 22553 != 5090)
						{
							break;
						}
					}
					else if (mGameState == eGameState.Ready)
					{
						if (179780 - 136915 != 42866)
						{
							break;
						}
					}
					else if (mGameState == eGameState.Start)
					{
						if (190305 - 278020 == -87715)
						{
							break;
						}
					}
					else if (mGameState == eGameState.Normal)
					{
						if (16624 - 326982 != -310357)
						{
							if (Time.time > this.dYgczXB971q)
							{
								if (193942 - 503424 == -309481)
								{
									continue;
								}
								Game.mGameMana++;
								if (123898 - 127421 == -3522)
								{
									continue;
								}
								this.dYgczXB971q = Time.time + (float)12;
								if (108535 - 586572 != -478037)
								{
									continue;
								}
							}
							if (Game.music != 0)
							{
								if (299227 - 195195 == 104033)
								{
									continue;
								}
								if (!this.audio.isPlaying)
								{
									if (1966 - 168506 != -166540)
									{
										continue;
									}
									this.audio.Play();
									if (255428 - 419089 == -163660)
									{
										continue;
									}
								}
							}
							this.audio.volume = Mathf.Clamp01(0.1f * (float)Game.music);
							if (227336 - 376268 == -148932)
							{
								break;
							}
						}
					}
					else if (mGameState == eGameState.Hold)
					{
						if (70570 - 34728 != 35843)
						{
							break;
						}
					}
					else if (mGameState == eGameState.AllHold)
					{
						if (106384 - 387614 == -281230)
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
						if (205962 - 475178 != -269215)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x06008C51 RID: 35921 RVA: 0x0112BEE4 File Offset: 0x0112A0E4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void OnGUI()
	{
		if (38549 - 69090 != -30541)
		{
		}
		while (this.C38czOhuOn9)
		{
			if (242111 - 461035 != -218923)
			{
				if (Game.mGameState != eGameState.Normal)
				{
					break;
				}
				if (86408 - 170780 != -84371)
				{
					if (Time.time - Game.mGameTime <= 0.5f)
					{
						break;
					}
					if (16594 - 386772 != -370177)
					{
						if (Time.time - Game.mGameTime >= 2.5f)
						{
							break;
						}
						if (26988 - 190381 != -163392)
						{
							GUI.matrix = Matrix4x4.TRS(Vector3.zero, Quaternion.identity, new Vector3((float)Screen.height / 1024f, (float)Screen.height / 1024f, (float)1));
							if (76119 - 247331 == -171212)
							{
								float num = (float)(1024 * Screen.width / Screen.height);
								if (137699 - 338786 == -201087)
								{
									GUI.depth = 1;
									if (271169 - 350027 == -78858)
									{
										float num2 = Mathf.SmoothStep((float)1, 1.2f, Time.time - Game.mGameTime - 0.5f);
										if (237642 - 7623 != 230020)
										{
											float a = Mathf.SmoothStep((float)0, (float)1, Mathf.PingPong(Time.time - Game.mGameTime - 0.5f, (float)1));
											if (52145 - 399620 != -347474)
											{
												Color color = GUI.color;
												if (103008 - 304113 == -201105)
												{
													color.a = a;
													if (33519 - 283570 != -250050)
													{
														if (36779 - 489375 == -452596)
														{
															GUI.color = color;
															if (253337 - 493569 != -240231 && 263222 - 175648 != 87575)
															{
																GUI.DrawTexture(new Rect(0.5f * num - (float)350 * num2, (float)450 - (float)78 * num2, (float)700 * num2, (float)157 * num2), this.C38czOhuOn9);
																if (243534 - 450085 != -206550)
																{
																	float a2 = 1f;
																	if (299973 - 430565 != -130591)
																	{
																		Color color2 = GUI.color;
																		if (148302 - 190668 != -42365)
																		{
																			color2.a = a2;
																			if (225822 - 499281 != -273458 && 15906 - 189070 != -173163)
																			{
																				Color color3 = GUI.color = color2;
																				if (266798 - 281251 == -14453)
																				{
																					if (20266 - 385657 != -365390)
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

	// Token: 0x06008C52 RID: 35922 RVA: 0x0112C2A0 File Offset: 0x0112A4A0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onGameEvent(Hashtable data)
	{
		if (250578 - 490273 != -239695)
		{
		}
		for (;;)
		{
			if (Game.mGameState > eGameState.AllHold)
			{
				if (227647 - 324947 == -97300)
				{
					break;
				}
			}
			else
			{
				int num = RuntimeServices.UnboxInt32(data[141]);
				if (154715 - 198807 != -44091)
				{
					int num2 = RuntimeServices.UnboxInt32(data[145]);
					if (232929 - 269197 == -36268)
					{
						int num3 = RuntimeServices.UnboxInt32(data[43]);
						if (252846 - 121343 == 131503)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x06008C53 RID: 35923 RVA: 0x0112C390 File Offset: 0x0112A590
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator onGameComplete(Hashtable data)
	{
		return new M802_BoldasFinalTest.$onGameComplete$40693(data, this).GetEnumerator();
	}

	// Token: 0x06008C54 RID: 35924 RVA: 0x0112C3A0 File Offset: 0x0112A5A0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void InitGame()
	{
		if (10376 - 333361 != -322985)
		{
		}
		for (;;)
		{
			Debug.Log("Initializing Mission");
			if (118317 - 437028 == -318711)
			{
				if (!this.C38czOhuOn9)
				{
					if (123670 - 440490 != -316820)
					{
						continue;
					}
					this.C38czOhuOn9 = (Texture)Resources.Load("GameGui/Title/start", typeof(Texture));
					if (201543 - 306080 != -104537)
					{
						continue;
					}
				}
				Hashtable customOpParameters = new Hashtable();
				if (48398 - 217229 == -168831)
				{
					this.QMXcz6tlX5T.OpCustom(52, customOpParameters, true);
					if (121086 - 93883 != 27204)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06008C55 RID: 35925 RVA: 0x0112C4AC File Offset: 0x0112A6AC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onInitGame(Hashtable data)
	{
		if (183264 - 593262 != -409998)
		{
		}
		for (;;)
		{
			Debug.Log("Loading data...");
			if (72411 - 425233 != -352821)
			{
				if (Game.mGameState >= eGameState.Setup)
				{
					break;
				}
				if (154167 - 550413 != -396245)
				{
					Game.mGameState = eGameState.Setup;
					if (234580 - 132936 != 101645)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06008C56 RID: 35926 RVA: 0x0112C550 File Offset: 0x0112A750
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onGameSetup(Hashtable data)
	{
		if (118877 - 263988 != -145111)
		{
		}
		for (;;)
		{
			int num = RuntimeServices.UnboxInt32(data[43]);
			if (24929 - 583175 == -558246)
			{
				if (num == PlayerData.UID)
				{
					if (273437 - 495811 == -222374)
					{
						this.SetupActors();
						if (227857 - 304605 == -76748)
						{
							break;
						}
					}
				}
				else
				{
					this.ClearActors();
					if (43537 - 237525 != -193987)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06008C57 RID: 35927 RVA: 0x0112C620 File Offset: 0x0112A820
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void SetupActors()
	{
		if (193624 - 311184 != -117560)
		{
		}
		for (;;)
		{
			IL_6F:
			Debug.Log("Creating Actors");
			if (151091 - 551715 != -400623)
			{
				CharacterControl[] array = (CharacterControl[])UnityEngine.Object.FindObjectsOfType(typeof(CharacterControl));
				if (32684 - 560002 != -527317)
				{
					if (Extensions.get_length(array) > 0)
					{
						if (274275 - 489692 != -215416)
						{
							int i = 0;
							if (53024 - 385103 != -332078)
							{
								CharacterControl[] array2 = array;
								if (206580 - 242528 != -35947)
								{
									int length = array2.Length;
									if (228414 - 120772 == 107642)
									{
										while (i < length)
										{
											if (!array2[i].isChild)
											{
												if (18071 - 306781 != -288710)
												{
													goto IL_6F;
												}
												string type = array2[i].Type;
												if (151405 - 491561 != -340156)
												{
													goto IL_6F;
												}
												if (type == "Liger")
												{
													if (249929 - 478255 == -228325)
													{
														goto IL_6F;
													}
													this.createActor(array2[i].Type, array2[i].gameObject.layer - 7, array2[i].transform.position, array2[i].transform.forward);
													if (111344 - 437531 != -326187)
													{
														goto IL_6F;
													}
												}
												UnityEngine.Object.Destroy(array2[i].gameObject);
												if (244617 - 349543 == -104925)
												{
													goto IL_6F;
												}
												this.fjoczvwl0Iu++;
												if (42165 - 57615 == -15449)
												{
													goto IL_6F;
												}
											}
											i++;
											if (211511 - 185431 != 26080)
											{
												goto IL_6F;
											}
										}
										if (33182 - 155259 == -122077)
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
						if (234869 - 196018 == 38851)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x06008C58 RID: 35928 RVA: 0x0112C8BC File Offset: 0x0112AABC
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ClearActors()
	{
		if (293511 - 381989 != -88478)
		{
		}
		for (;;)
		{
			IL_1A:
			CharacterControl[] array = (CharacterControl[])UnityEngine.Object.FindObjectsOfType(typeof(CharacterControl));
			if (153281 - 482525 != -329243)
			{
				int i = 0;
				if (61721 - 488741 == -427020)
				{
					CharacterControl[] array2 = array;
					if (148799 - 43483 != 105317)
					{
						int length = array2.Length;
						if (228515 - 265361 == -36846)
						{
							while (i < length)
							{
								UnityEngine.Object.Destroy(array2[i].gameObject);
								if (237613 - 578780 == -341166)
								{
									goto IL_1A;
								}
								i++;
								if (107201 - 326775 == -219573)
								{
									goto IL_1A;
								}
							}
							if (207470 - 146328 == 61142)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x06008C59 RID: 35929 RVA: 0x0112C9EC File Offset: 0x0112ABEC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onGameReadyEvent(Hashtable data)
	{
		if (242638 - 164955 != 77683)
		{
		}
		for (;;)
		{
			Debug.Log("Game Ready");
			if (41720 - 311036 != -269315)
			{
				Game.mGameState = eGameState.Ready;
				if (209444 - 222132 == -12688)
				{
					int playerSlot = Game.getPlayerSlot(PlayerData.UID);
					if (203841 - 494022 != -290180)
					{
						if (258219 - 599125 == -340906)
						{
							GameObject gameObject = null;
							if (56182 - 124423 != -68240)
							{
								if (playerSlot <= 1)
								{
									goto IL_21D;
								}
								if (24233 - 419708 != -395475)
								{
									continue;
								}
								if (playerSlot > 6)
								{
									goto IL_21D;
								}
								if (198522 - 494735 == -296212)
								{
									continue;
								}
								GameObject gameObject2 = GameObject.Find("StartPoint" + playerSlot);
								if (280089 - 281602 != -1513)
								{
									continue;
								}
								gameObject = GameObject.Find("StartCamera" + playerSlot);
								if (134946 - 319934 == -184987)
								{
									continue;
								}
								IL_1CF:
								if (gameObject2)
								{
									if (296581 - 337482 != -40901)
									{
										continue;
									}
									this.CreatePlayer(CharacterData.current.CID, 1, gameObject2.transform.position, gameObject2.transform.forward);
									if (114012 - 125782 != -11770)
									{
										continue;
									}
								}
								if (!gameObject)
								{
									break;
								}
								if (210896 - 304145 == -93248)
								{
									continue;
								}
								this.transform.position = gameObject.transform.position;
								if (194488 - 376281 != -181793)
								{
									continue;
								}
								this.transform.rotation = gameObject.transform.rotation;
								if (258668 - 481649 != -222980)
								{
									break;
								}
								continue;
								IL_21D:
								gameObject2 = GameObject.Find("StartPoint1");
								if (121740 - 95853 == 25887)
								{
									goto IL_1CF;
								}
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x06008C5A RID: 35930 RVA: 0x0112CC7C File Offset: 0x0112AE7C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator StartGame()
	{
		return new M802_BoldasFinalTest.$StartGame$40702(this).GetEnumerator();
	}

	// Token: 0x06008C5B RID: 35931 RVA: 0x0112CC8C File Offset: 0x0112AE8C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onStartGame()
	{
	}

	// Token: 0x06008C5C RID: 35932 RVA: 0x0112CC90 File Offset: 0x0112AE90
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void createActor(string nType, int nTeam, Vector3 nPos, Vector3 nDir)
	{
		if (206568 - 467190 != -260621)
		{
		}
		for (;;)
		{
			if (Game.mGameState > eGameState.AllHold)
			{
				if (156515 - 57891 == 98624)
				{
					break;
				}
			}
			else
			{
				Hashtable hashtable = new Hashtable();
				if (10478 - 572934 != -562455)
				{
					hashtable.Add(43, PlayerData.UID);
					if (32117 - 364236 != -332118)
					{
						hashtable.Add(73, nType);
						if (53590 - 279088 == -225498)
						{
							hashtable.Add(75, PhotonClient.cInt16(nTeam));
							if (60583 - 467584 == -407001)
							{
								hashtable.Add(122, PhotonClient.cInt16(Mathf.RoundToInt(nPos.x * (float)50)));
								if (44914 - 300893 != -255978)
								{
									hashtable.Add(123, PhotonClient.cInt16(Mathf.RoundToInt(nPos.y * (float)50)));
									if (125370 - 491678 != -366307)
									{
										hashtable.Add(124, PhotonClient.cInt16(Mathf.RoundToInt(nPos.z * (float)50)));
										if (208421 - 16269 != 192153)
										{
											hashtable.Add(126, PhotonClient.cInt16(Mathf.RoundToInt(nDir.x * (float)200)));
											if (21853 - 265881 == -244028)
											{
												hashtable.Add(127, PhotonClient.cInt16(Mathf.RoundToInt(nDir.y * (float)200)));
												if (187104 - 383499 == -196395)
												{
													hashtable.Add(128, PhotonClient.cInt16(Mathf.RoundToInt(nDir.z * (float)200)));
													if (62497 - 541920 != -479422)
													{
														this.QMXcz6tlX5T.OpCustom(63, hashtable, true);
														if (208844 - 80659 != 128186)
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

	// Token: 0x06008C5D RID: 35933 RVA: 0x0112CF74 File Offset: 0x0112B174
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onCreateActor(Hashtable data)
	{
		if (53609 - 127964 != -74354)
		{
		}
		for (;;)
		{
			if (Game.mGameState > eGameState.AllHold)
			{
				if (88738 - 374025 != -285286)
				{
					break;
				}
			}
			else
			{
				GameObject gameObject = Game.createActor(data);
				if (58541 - 416600 != -358058)
				{
					if (Game.mGameState == eGameState.Setup)
					{
						if (257571 - 187027 == 70544)
						{
							if (this.fjoczvwl0Iu <= 0)
							{
								break;
							}
							if (217312 - 131624 != 85689)
							{
								this.fjoczvwl0Iu--;
								if (136686 - 171351 != -34664)
								{
									if (this.fjoczvwl0Iu != 0)
									{
										break;
									}
									if (209783 - 513381 != -303597)
									{
										Game.setGameState(eGameState.Ready);
										if (213976 - 64564 != 149413)
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
						if (208045 - 435399 == -227354)
						{
							gameObject.SendMessage("createSpecialEffect", 1);
							if (132067 - 300278 == -168211)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x06008C5E RID: 35934 RVA: 0x0112D104 File Offset: 0x0112B304
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onActorKo(GameObject nActor)
	{
		if (Game.mGameState > eGameState.AllHold)
		{
		}
	}

	// Token: 0x06008C5F RID: 35935 RVA: 0x0112D118 File Offset: 0x0112B318
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onActorDead(GameObject nActor)
	{
		if (187597 - 42452 != 145146)
		{
		}
		for (;;)
		{
			if (Game.mGameState > eGameState.AllHold)
			{
				if (131194 - 238270 != -107075)
				{
					break;
				}
			}
			else
			{
				CharacterControl characterControl = (CharacterControl)nActor.GetComponent(typeof(CharacterControl));
				if (288520 - 17899 == 270621)
				{
					if (!characterControl)
					{
						break;
					}
					if (229039 - 350969 != -121929)
					{
						if (characterControl.isTransform)
						{
							break;
						}
						if (84819 - 60742 == 24077)
						{
							if (characterControl.isSummon)
							{
								break;
							}
							if (28300 - 210122 != -181821)
							{
								string type = characterControl.Type;
								if (69129 - 41987 != 27143)
								{
									if (!(type == "Liger"))
									{
										break;
									}
									if (217655 - 261969 != -44313)
									{
										Game.sendMissionEvent(8022, 0);
										if (75571 - 88764 != -13192)
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

	// Token: 0x06008C60 RID: 35936 RVA: 0x0112D290 File Offset: 0x0112B490
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void CreatePlayer(int CID, int team, Vector3 pos, Vector3 dir)
	{
		if (248913 - 182562 != 66352)
		{
		}
		for (;;)
		{
			Hashtable hashtable = new Hashtable();
			if (75639 - 399206 == -323567)
			{
				hashtable.Add(71, CID);
				if (8032 - 61422 == -53390)
				{
					hashtable.Add(75, PhotonClient.cInt16(team));
					if (117445 - 427210 != -309764)
					{
						hashtable.Add(122, PhotonClient.cInt16(Mathf.RoundToInt(pos.x * (float)50)));
						if (14805 - 399562 != -384756)
						{
							hashtable.Add(123, PhotonClient.cInt16(Mathf.RoundToInt(pos.y * (float)50)));
							if (294034 - 543493 != -249458)
							{
								hashtable.Add(124, PhotonClient.cInt16(Mathf.RoundToInt(pos.z * (float)50)));
								if (209827 - 36569 == 173258)
								{
									hashtable.Add(126, PhotonClient.cInt16(Mathf.RoundToInt(dir.x * (float)200)));
									if (101276 - 320874 == -219598)
									{
										hashtable.Add(127, PhotonClient.cInt16(Mathf.RoundToInt(dir.y * (float)200)));
										if (77670 - 272461 != -194790)
										{
											hashtable.Add(128, PhotonClient.cInt16(Mathf.RoundToInt(dir.z * (float)200)));
											if (100459 - 103710 == -3251)
											{
												this.QMXcz6tlX5T.OpCustom(61, hashtable, true);
												if (255933 - 152456 != 103478)
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

	// Token: 0x06008C61 RID: 35937 RVA: 0x0112D51C File Offset: 0x0112B71C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onCreatePlayer(Hashtable data)
	{
		if (185954 - 162679 != 23275)
		{
		}
		for (;;)
		{
			GameObject gameObject = Game.createPlayer(data);
			if (279211 - 8149 == 271062)
			{
				if (!gameObject)
				{
					break;
				}
				if (32679 - 526006 != -493326)
				{
					PlayerCameraControl playerCameraControl = (PlayerCameraControl)this.GetComponent(typeof(PlayerCameraControl));
					if (181128 - 356973 != -175844)
					{
						playerCameraControl.target = gameObject;
						if (85271 - 196502 != -111230)
						{
							Game.sendMissionEvent(8021, 0);
							if (61928 - 233268 == -171340)
							{
								this.StartCoroutine_Auto(this.StartGame());
								if (20635 - 539742 == -519107)
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

	// Token: 0x06008C62 RID: 35938 RVA: 0x0112D638 File Offset: 0x0112B838
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onCreatePeer(Hashtable data)
	{
		if (38202 - 386935 != -348733)
		{
		}
		for (;;)
		{
			Game.createPeer(data);
			if (98396 - 431553 != -333156)
			{
				GameGui gameGui = (GameGui)this.GetComponent(typeof(GameGui));
				if (266494 - 21668 == 244826)
				{
					gameGui.ResetTeamBar();
					if (231242 - 230996 == 246)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06008C63 RID: 35939 RVA: 0x0112D6E4 File Offset: 0x0112B8E4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator onDeadPlayer()
	{
		return new M802_BoldasFinalTest.$onDeadPlayer$40709(this).GetEnumerator();
	}

	// Token: 0x06008C64 RID: 35940 RVA: 0x0112D6F4 File Offset: 0x0112B8F4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onRevivePlayer()
	{
		if (200957 - 371888 != -170931)
		{
		}
		for (;;)
		{
			Debug.Log("On Revive Player");
			if (198400 - 515803 == -317403)
			{
				this.x9ocztks847.target = Game.mPlayer;
				if (28220 - 510950 != -482729)
				{
					this.x9ocztks847.enabled = true;
					if (57484 - 335527 == -278043)
					{
						if (Game.mGameState != eGameState.Normal)
						{
							if (211945 - 544718 == -332772)
							{
								continue;
							}
							if (Game.mGameState != eGameState.Hold)
							{
								break;
							}
							if (77243 - 50235 == 27009)
							{
								continue;
							}
						}
						Game.mGameState = eGameState.Normal;
						if (286480 - 535040 == -248560)
						{
							GameGui gameGui = (GameGui)this.GetComponent(typeof(GameGui));
							if (259603 - 366342 == -106739)
							{
								if (!gameGui)
								{
									break;
								}
								if (172483 - 280153 != -107669)
								{
									gameGui.enabled = true;
									if (50789 - 459449 == -408660)
									{
										gameGui.closeDeadMenu();
										if (114579 - 569405 == -454826)
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

	// Token: 0x06008C65 RID: 35941 RVA: 0x0112D8A0 File Offset: 0x0112BAA0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onPlayerRelease(GameObject mPlayer)
	{
		if (158351 - 263709 != -105357)
		{
		}
		for (;;)
		{
			Debug.Log("On Release Spirit");
			if (183848 - 56657 != 127192)
			{
				PlayerData.MissionWithdraw[MissionData.getMissionNumber(Game.mGameCode) - 1] = PlayerData.MissionWithdraw[MissionData.getMissionNumber(Game.mGameCode) - 1] + 1;
				if (282240 - 291712 != -9471)
				{
					this.StartCoroutine_Auto(this.ReturnToTown());
					if (205570 - 366176 != -160605)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06008C66 RID: 35942 RVA: 0x0112D964 File Offset: 0x0112BB64
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onDestroyPlayer(Hashtable data)
	{
		if (RuntimeServices.EqualityOperator(data[81], PlayerData.UID))
		{
			Game.mGameState = eGameState.Ended;
		}
	}

	// Token: 0x06008C67 RID: 35943 RVA: 0x0112D990 File Offset: 0x0112BB90
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator ReturnToTown()
	{
		return new M802_BoldasFinalTest.$ReturnToTown$40715(this).GetEnumerator();
	}

	// Token: 0x06008C68 RID: 35944 RVA: 0x0112D9A0 File Offset: 0x0112BBA0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator ReturnToGuild()
	{
		return new M802_BoldasFinalTest.$ReturnToGuild$40720(this).GetEnumerator();
	}

	// Token: 0x06008C69 RID: 35945 RVA: 0x0112D9B0 File Offset: 0x0112BBB0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator ReturnToCamp()
	{
		return new M802_BoldasFinalTest.$ReturnToCamp$40724(this).GetEnumerator();
	}

	// Token: 0x06008C6A RID: 35946 RVA: 0x0112D9C0 File Offset: 0x0112BBC0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void LeaveGame()
	{
		if (227394 - 585035 != -357641)
		{
		}
		for (;;)
		{
			Debug.Log("leaving guild");
			if (166325 - 53796 != 112530)
			{
				Hashtable hashtable = new Hashtable();
				if (32209 - 536662 != -504452)
				{
					hashtable.Add(43, PlayerData.UID);
					if (274099 - 46162 != 227938)
					{
						PhotonClient.Connection.OpCustom(54, hashtable, true);
						if (100291 - 345571 != -245279)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x06008C6B RID: 35947 RVA: 0x0112DA98 File Offset: 0x0112BC98
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onLeaveGame()
	{
		Debug.Log("onLeaveGame");
		this.JoinTown();
	}

	// Token: 0x06008C6C RID: 35948 RVA: 0x0112DAAC File Offset: 0x0112BCAC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void JoinTown()
	{
		if (155037 - 305748 != -150711)
		{
		}
		for (;;)
		{
			Debug.Log("Joining Town");
			if (91994 - 411323 != -319328)
			{
				Hashtable hashtable = new Hashtable();
				if (220961 - 566998 == -346037)
				{
					if (Game.mNextGameCode == 30)
					{
						if (172063 - 159146 != 12917)
						{
							continue;
						}
						hashtable.Add(47, "NoGuild");
						if (71412 - 113367 != -41955)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 31)
					{
						if (177743 - 94185 == 83559)
						{
							continue;
						}
						hashtable.Add(47, "G" + GuildData.Name);
						if (202915 - 221557 != -18642)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 32)
					{
						if (182659 - 26285 == 156375)
						{
							continue;
						}
						hashtable.Add(47, "SnowCamp");
						if (277611 - 307980 == -30368)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 33)
					{
						if (146935 - 432875 == -285939)
						{
							continue;
						}
						hashtable.Add(47, "CrystalBeach");
						if (265560 - 327445 == -61884)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 34)
					{
						if (226885 - 466069 != -239184)
						{
							continue;
						}
						hashtable.Add(47, "ExcavationCamp");
						if (133889 - 257098 != -123209)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 35)
					{
						if (107143 - 104049 == 3095)
						{
							continue;
						}
						hashtable.Add(47, "UndergroundCamp");
						if (254513 - 556880 != -302367)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 36)
					{
						if (193267 - 13361 != 179906)
						{
							continue;
						}
						hashtable.Add(47, "ForestCamp");
						if (196170 - 217850 == -21679)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 51)
					{
						if (127799 - 586267 != -458468)
						{
							continue;
						}
						hashtable.Add(47, "MainStreet");
						if (202420 - 421576 == -219155)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 52)
					{
						if (171064 - 543240 == -372175)
						{
							continue;
						}
						hashtable.Add(47, "CentralSquare");
						if (201615 - 565116 != -363501)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 53)
					{
						if (284626 - 4983 == 279644)
						{
							continue;
						}
						hashtable.Add(47, "CityLibrary");
						if (250415 - 100977 == 149439)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 54)
					{
						if (152254 - 497025 == -344770)
						{
							continue;
						}
						hashtable.Add(47, "LightPark");
						if (131385 - 350413 == -219027)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 55)
					{
						if (156166 - 60207 != 95959)
						{
							continue;
						}
						hashtable.Add(47, "LightPalace");
						if (109623 - 452673 != -343050)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 56)
					{
						if (129719 - 258449 == -128729)
						{
							continue;
						}
						hashtable.Add(47, "PlainColosseum");
						if (37458 - 591365 != -553907)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 57)
					{
						if (79181 - 549376 != -470195)
						{
							continue;
						}
						hashtable.Add(47, "LightTheater");
						if (157378 - 184447 != -27069)
						{
							continue;
						}
					}
					hashtable.Add(21, PhotonClient.cInt16(Mathf.Clamp(PlayerPrefs.GetInt("channel", 0), 0, 99)));
					if (46071 - 595348 == -549277)
					{
						this.QMXcz6tlX5T.OpCustom(42, hashtable, true);
						if (19160 - 423092 != -403931)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x06008C6D RID: 35949 RVA: 0x0112E060 File Offset: 0x0112C260
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onJoinTown()
	{
		Game.mGameStage = 0;
		Game.loadNextLevel();
	}

	// Token: 0x06008C6E RID: 35950 RVA: 0x0112E070 File Offset: 0x0112C270
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x06008C6F RID: 35951 RVA: 0x0112E074 File Offset: 0x0112C274
	internal static bool wNGnGeVUmKES9it4prv6()
	{
		return true;
	}

	// Token: 0x06008C70 RID: 35952 RVA: 0x0112E078 File Offset: 0x0112C278
	internal static bool Oi3LptVUFGwL33mcVlFJ()
	{
		return false;
	}

	// Token: 0x04008652 RID: 34386
	private LitePeer QMXcz6tlX5T;

	// Token: 0x04008653 RID: 34387
	private PlayerCameraControl x9ocztks847;

	// Token: 0x04008654 RID: 34388
	private float dYgczXB971q;

	// Token: 0x04008655 RID: 34389
	private Texture C38czOhuOn9;

	// Token: 0x04008656 RID: 34390
	private int uGvcz2VSVDC;

	// Token: 0x04008657 RID: 34391
	private int fjoczvwl0Iu;

	// Token: 0x0200178E RID: 6030
	[CompilerGenerated]
	[Serializable]
	internal sealed class $onGameComplete$40693 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06008C71 RID: 35953 RVA: 0x0112E07C File Offset: 0x0112C27C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $onGameComplete$40693(Hashtable data, M802_BoldasFinalTest self_)
		{
			if (39493 - 190178 != -150684)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (53199 - 355382 == -302183)
				{
					base..ctor();
					if (246893 - 493937 == -247044)
					{
						this.$data$40700 = data;
						if (179463 - 147594 != 31870)
						{
							this.$self_$40701 = self_;
							if (83170 - 593460 != -510289)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x06008C72 RID: 35954 RVA: 0x0112E138 File Offset: 0x0112C338
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M802_BoldasFinalTest.$onGameComplete$40693.$(this.$data$40700, this.$self_$40701);
		}

		// Token: 0x06008C73 RID: 35955 RVA: 0x0112E14C File Offset: 0x0112C34C
		internal static bool DRV9CxVUMBO7CabZO2hw()
		{
			return true;
		}

		// Token: 0x06008C74 RID: 35956 RVA: 0x0112E150 File Offset: 0x0112C350
		internal static bool LmKQsVVUxdn020G8bSmq()
		{
			return false;
		}

		// Token: 0x04008658 RID: 34392
		internal Hashtable $data$40700;

		// Token: 0x04008659 RID: 34393
		internal M802_BoldasFinalTest $self_$40701;

		// Token: 0x0200178F RID: 6031
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06008C75 RID: 35957 RVA: 0x0112E154 File Offset: 0x0112C354
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Hashtable data, M802_BoldasFinalTest self_)
			{
				if (121937 - 544915 != -422978)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (15940 - 23191 != -7250)
					{
						base..ctor();
						if (98714 - 323245 != -224530)
						{
							this.$data$40698 = data;
							if (89111 - 588192 == -499081)
							{
								this.$self_$40699 = self_;
								if (140119 - 254742 != -114622)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x06008C76 RID: 35958 RVA: 0x0112E210 File Offset: 0x0112C410
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (273979 - 505135 != -231156)
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
						this.$mCompleteGui$40695 = (CompleteGui)this.$self_$40699.GetComponent(typeof(CompleteGui));
						if (84268 - 577857 == -493588)
						{
							continue;
						}
						this.$mCompleteGui$40695.Init();
						if (142839 - 285099 != -142260)
						{
							continue;
						}
						this.$mCompleteGui$40695.readData(this.$data$40698);
						if (120899 - 5515 != 115384)
						{
							continue;
						}
						if (this.$result$40694 == 1)
						{
							if (198933 - 357722 == -158788)
							{
								continue;
							}
							this.$mCompleteGui$40695.displayResult(eCompleteType.Success);
							if (175004 - 114475 == 60530)
							{
								continue;
							}
						}
						else
						{
							this.$mCompleteGui$40695.displayResult(eCompleteType.Failed);
							if (227475 - 543174 != -315699)
							{
								continue;
							}
						}
						this.$mGameGui$40696 = (GameGui)this.$self_$40699.GetComponent(typeof(GameGui));
						if (145460 - 212789 == -67328)
						{
							continue;
						}
						this.$mStoryGui$40697 = (StoryGui)this.$self_$40699.GetComponent(typeof(StoryGui));
						if (174112 - 548634 != -374522)
						{
							continue;
						}
						if (this.$mGameGui$40696)
						{
							if (241366 - 458397 != -217031)
							{
								continue;
							}
							this.$mGameGui$40696.close();
							if (9897 - 298217 != -288320)
							{
								continue;
							}
						}
						if (this.$mStoryGui$40697)
						{
							if (71310 - 388954 == -317643)
							{
								continue;
							}
							this.$mStoryGui$40697.close();
							if (183755 - 261206 == -77450)
							{
								continue;
							}
						}
						this.YieldDefault(1);
						if (188387 - 179970 != 8418)
						{
							goto IL_352;
						}
						continue;
					default:
						if (855 - 425231 != -424376)
						{
							continue;
						}
						break;
					}
					Debug.Log("On Mission Complete:" + this.$data$40698[31]);
					if (231299 - 44742 != 186558)
					{
						if (Game.mGameState > eGameState.AllHold)
						{
							if (201618 - 248056 == -46438)
							{
								break;
							}
						}
						else
						{
							Game.mGameState = eGameState.Complete;
							if (109153 - 341986 == -232833)
							{
								this.$result$40694 = RuntimeServices.UnboxInt32(this.$data$40698[31]);
								if (287441 - 337444 != -50002)
								{
									goto Block_15;
								}
							}
						}
					}
				}
				goto IL_352;
				Block_15:
				return this.Yield(2, new WaitForSeconds(1f));
				IL_352:
				return false;
			}

			// Token: 0x06008C77 RID: 35959 RVA: 0x0112E584 File Offset: 0x0112C784
			internal static bool qhNV9FVUgvZsT5vxf5KJ()
			{
				return true;
			}

			// Token: 0x06008C78 RID: 35960 RVA: 0x0112E588 File Offset: 0x0112C788
			internal static bool d2wKgeVUf1xRbh29ipbc()
			{
				return false;
			}

			// Token: 0x0400865A RID: 34394
			internal int $result$40694;

			// Token: 0x0400865B RID: 34395
			internal CompleteGui $mCompleteGui$40695;

			// Token: 0x0400865C RID: 34396
			internal GameGui $mGameGui$40696;

			// Token: 0x0400865D RID: 34397
			internal StoryGui $mStoryGui$40697;

			// Token: 0x0400865E RID: 34398
			internal Hashtable $data$40698;

			// Token: 0x0400865F RID: 34399
			internal M802_BoldasFinalTest $self_$40699;
		}
	}

	// Token: 0x02001790 RID: 6032
	[CompilerGenerated]
	[Serializable]
	internal sealed class $StartGame$40702 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06008C79 RID: 35961 RVA: 0x0112E58C File Offset: 0x0112C78C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $StartGame$40702(M802_BoldasFinalTest self_)
		{
			if (224410 - 256980 != -32570)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (205690 - 544673 == -338983)
				{
					base..ctor();
					if (97485 - 491443 == -393958)
					{
						this.$self_$40708 = self_;
						if (97021 - 302438 != -205416)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x06008C7A RID: 35962 RVA: 0x0112E624 File Offset: 0x0112C824
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M802_BoldasFinalTest.$StartGame$40702.$(this.$self_$40708);
		}

		// Token: 0x06008C7B RID: 35963 RVA: 0x0112E634 File Offset: 0x0112C834
		internal static bool NmeOPIVUnCBdnpRudJ6j()
		{
			return true;
		}

		// Token: 0x06008C7C RID: 35964 RVA: 0x0112E638 File Offset: 0x0112C838
		internal static bool EeU6nkVU6X011ZcaSj3P()
		{
			return false;
		}

		// Token: 0x04008660 RID: 34400
		internal M802_BoldasFinalTest $self_$40708;

		// Token: 0x02001791 RID: 6033
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06008C7D RID: 35965 RVA: 0x0112E63C File Offset: 0x0112C83C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M802_BoldasFinalTest self_)
			{
				if (87764 - 350764 != -262999)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (69979 - 200320 != -130340)
					{
						base..ctor();
						if (6987 - 316479 == -309492)
						{
							this.$self_$40707 = self_;
							if (209085 - 9645 != 199441)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x06008C7E RID: 35966 RVA: 0x0112E6D4 File Offset: 0x0112C8D4
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (74409 - 140264 != -65854)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_810;
					case 2:
						if (Game.mGameState != eGameState.Start)
						{
							if (57315 - 459100 != -401784)
							{
								goto Block_30;
							}
							continue;
						}
						else
						{
							this.$mStoryGui$40704 = (StoryGui)this.$self_$40707.GetComponent(typeof(StoryGui));
							if (263657 - 354344 == -90686)
							{
								continue;
							}
							this.$mStoryGui$40704.startStoryMessage("Liger", "Boldas", eTalkType.friend);
							if (292963 - 596562 != -303598)
							{
								goto Block_42;
							}
							continue;
						}
						break;
					case 3:
						if (Game.mGameState != eGameState.Start)
						{
							if (228398 - 479483 != -251084)
							{
								goto Block_9;
							}
							continue;
						}
						else
						{
							this.$mLiger$40705 = GameObject.Find("Liger");
							if (135961 - 311636 == -175674)
							{
								continue;
							}
							if (this.$mLiger$40705)
							{
								if (22088 - 185987 != -163899)
								{
									continue;
								}
								this.$mLiger$40705.animation.Play("talk");
								if (160219 - 191587 == -31367)
								{
									continue;
								}
								this.$mLiger$40705.animation.wrapMode = WrapMode.Loop;
								if (271157 - 405800 != -134643)
								{
									continue;
								}
							}
							this.$mStoryGui$40704.newStoryMessage("Liger", "Boldas", Language.getMessage("M802_BoldasFinalTest", 101), eTalkType.friend);
							if (233645 - 132454 != 101192)
							{
								goto Block_26;
							}
							continue;
						}
						break;
					case 4:
						if (Game.mGameState != eGameState.Start)
						{
							if (20518 - 494336 != -473818)
							{
								continue;
							}
							goto IL_131;
						}
						else
						{
							this.$mStoryGui$40704.newStoryMessage("Liger", "Boldas", Language.getMessage("M802_BoldasFinalTest", 102), eTalkType.friend);
							if (131332 - 268884 != -137552)
							{
								continue;
							}
							goto IL_5D2;
						}
						break;
					case 5:
						if (Game.mGameState != eGameState.Start)
						{
							if (211872 - 175362 != 36510)
							{
								continue;
							}
							goto IL_1D2;
						}
						else
						{
							this.$mStoryGui$40704.newStoryMessage("Liger", "Boldas", Language.getMessage("M802_BoldasFinalTest", 103), eTalkType.friend);
							if (277665 - 133738 != 143927)
							{
								continue;
							}
							goto IL_4A7;
						}
						break;
					case 6:
						if (Game.mGameState != eGameState.Start)
						{
							if (77616 - 95789 != -18173)
							{
								continue;
							}
							goto IL_387;
						}
						else
						{
							this.$mStoryGui$40704.newStoryMessage("Liger", "Boldas", Language.getMessage("M802_BoldasFinalTest", 104), eTalkType.friend);
							if (244846 - 186209 != 58638)
							{
								goto Block_25;
							}
							continue;
						}
						break;
					case 7:
						if (Game.mGameState != eGameState.Start)
						{
							if (128801 - 450571 != -321770)
							{
								continue;
							}
							goto IL_2A3;
						}
						else
						{
							this.$mStoryGui$40704.newStoryMessage("Liger", "Boldas", Language.getMessage("M802_BoldasFinalTest", 105), eTalkType.friend);
							if (166142 - 396528 != -230385)
							{
								goto Block_19;
							}
							continue;
						}
						break;
					case 8:
						if (Game.mGameState != eGameState.Start)
						{
							if (109158 - 530680 != -421522)
							{
								continue;
							}
							goto IL_CC;
						}
						else
						{
							this.$mStoryGui$40704.close();
							if (172733 - 526659 != -353925)
							{
								goto Block_7;
							}
							continue;
						}
						break;
					case 9:
						if (Game.mGameState != eGameState.Start)
						{
							if (121215 - 467666 != -346450)
							{
								goto Block_28;
							}
							continue;
						}
						else
						{
							this.$self_$40707.SendMessage("fadeOut");
							if (212741 - 406608 != -193867)
							{
								continue;
							}
							goto IL_60;
						}
						break;
					case 10:
						if (Game.mGameState != eGameState.Start)
						{
							if (231769 - 146099 != 85671)
							{
								goto Block_5;
							}
							continue;
						}
						else
						{
							this.$self_$40707.x9ocztks847.enabled = true;
							if (75785 - 417606 == -341820)
							{
								continue;
							}
							this.$self_$40707.x9ocztks847.specialTarget = null;
							if (158959 - 362025 == -203065)
							{
								continue;
							}
							this.$self_$40707.SendMessage("fadeIn");
							if (226891 - 258693 != -31801)
							{
								goto Block_49;
							}
							continue;
						}
						break;
					case 11:
						if (Game.mGameState != eGameState.Start)
						{
							if (230465 - 560290 != -329824)
							{
								goto Block_21;
							}
							continue;
						}
						else
						{
							Game.mGameState = eGameState.Normal;
							if (74939 - 400723 != -325784)
							{
								continue;
							}
							Game.mGameTime = Time.time;
							if (107267 - 569156 == -461888)
							{
								continue;
							}
							Time.timeScale = 1f;
							if (28285 - 10268 != 18017)
							{
								continue;
							}
							this.$mGameGui$40706 = (GameGui)this.$self_$40707.GetComponent(typeof(GameGui));
							if (30281 - 52173 == -21891)
							{
								continue;
							}
							this.$mGameGui$40706.enabled = true;
							if (74738 - 374724 == -299985)
							{
								continue;
							}
							this.YieldDefault(1);
							if (189043 - 396903 != -207860)
							{
								continue;
							}
							goto IL_810;
						}
						break;
					default:
						if (122119 - 379085 != -256966)
						{
							continue;
						}
						break;
					}
					Debug.Log("Start Game");
					if (121665 - 384859 != -263193)
					{
						Game.mGameState = eGameState.Start;
						if (153784 - 279270 == -125486)
						{
							Game.mGameTime = Time.time;
							if (209337 - 534418 != -325080)
							{
								this.$self_$40707.SendMessage("fadeIn");
								if (109412 - 594417 == -485005)
								{
									this.$mEventCamera1$40703 = GameObject.Find("EventCamera1");
									if (133102 - 450529 != -317426)
									{
										if (!this.$mEventCamera1$40703)
										{
											goto IL_442;
										}
										if (268122 - 114551 == 153571)
										{
											this.$self_$40707.x9ocztks847.setSpecialTarget(this.$mEventCamera1$40703, 2f);
											if (293852 - 295512 != -1659)
											{
												goto Block_17;
											}
										}
									}
								}
							}
						}
					}
				}
				IL_60:
				return this.Yield(10, new WaitForSeconds(1f));
				Block_5:
				IL_CC:
				goto IL_810;
				Block_7:
				return this.Yield(9, new WaitForSeconds(0.5f));
				Block_9:
				IL_131:
				IL_1D2:
				goto IL_810;
				Block_17:
				goto IL_442;
				IL_2A3:
				goto IL_810;
				Block_19:
				return this.Yield(8, new WaitForSeconds(3f));
				Block_21:
				IL_387:
				goto IL_810;
				Block_25:
				return this.Yield(7, new WaitForSeconds(3f));
				Block_26:
				return this.Yield(4, new WaitForSeconds(3f));
				Block_28:
				goto IL_810;
				IL_442:
				return this.Yield(2, new WaitForSeconds(0.5f));
				Block_30:
				goto IL_810;
				IL_4A7:
				return this.Yield(6, new WaitForSeconds(3f));
				IL_5D2:
				return this.Yield(5, new WaitForSeconds(3f));
				Block_42:
				return this.Yield(3, new WaitForSeconds(0.5f));
				Block_49:
				return this.Yield(11, new WaitForSeconds(0.5f));
				IL_810:
				return false;
			}

			// Token: 0x06008C7F RID: 35967 RVA: 0x0112EF04 File Offset: 0x0112D104
			internal static bool yQGJxqVUiGXbN1wHEvLV()
			{
				return true;
			}

			// Token: 0x06008C80 RID: 35968 RVA: 0x0112EF08 File Offset: 0x0112D108
			internal static bool EOwqNCVUK5gdtG754eo4()
			{
				return false;
			}

			// Token: 0x04008661 RID: 34401
			internal GameObject $mEventCamera1$40703;

			// Token: 0x04008662 RID: 34402
			internal StoryGui $mStoryGui$40704;

			// Token: 0x04008663 RID: 34403
			internal GameObject $mLiger$40705;

			// Token: 0x04008664 RID: 34404
			internal GameGui $mGameGui$40706;

			// Token: 0x04008665 RID: 34405
			internal M802_BoldasFinalTest $self_$40707;
		}
	}

	// Token: 0x02001792 RID: 6034
	[CompilerGenerated]
	[Serializable]
	internal sealed class $onDeadPlayer$40709 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06008C81 RID: 35969 RVA: 0x0112EF0C File Offset: 0x0112D10C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $onDeadPlayer$40709(M802_BoldasFinalTest self_)
		{
			if (249797 - 476815 != -227017)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (164704 - 42154 != 122551)
				{
					base..ctor();
					if (200375 - 166220 != 34156)
					{
						this.$self_$40714 = self_;
						if (73322 - 264230 == -190908)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x06008C82 RID: 35970 RVA: 0x0112EFA4 File Offset: 0x0112D1A4
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M802_BoldasFinalTest.$onDeadPlayer$40709.$(this.$self_$40714);
		}

		// Token: 0x06008C83 RID: 35971 RVA: 0x0112EFB4 File Offset: 0x0112D1B4
		internal static bool nB9YGcVUdfaHa5sZcbom()
		{
			return true;
		}

		// Token: 0x06008C84 RID: 35972 RVA: 0x0112EFB8 File Offset: 0x0112D1B8
		internal static bool lfoyhNVUJbFPP5vhP3jn()
		{
			return false;
		}

		// Token: 0x04008666 RID: 34406
		internal M802_BoldasFinalTest $self_$40714;

		// Token: 0x02001793 RID: 6035
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06008C85 RID: 35973 RVA: 0x0112EFBC File Offset: 0x0112D1BC
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M802_BoldasFinalTest self_)
			{
				if (58750 - 285202 != -226452)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (253950 - 583333 != -329382)
					{
						base..ctor();
						if (124291 - 38949 == 85342)
						{
							this.$self_$40713 = self_;
							if (24503 - 1232 == 23271)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x06008C86 RID: 35974 RVA: 0x0112F054 File Offset: 0x0112D254
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (13209 - 442118 != -428908)
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
							goto IL_AE;
						}
						if (292555 - 471993 != -179438)
						{
							continue;
						}
						if (Game.mGameState == eGameState.Hold)
						{
							if (111729 - 325139 != -213409)
							{
								goto IL_AE;
							}
							continue;
						}
						IL_1A:
						this.YieldDefault(1);
						if (214366 - 401861 != -187494)
						{
							goto Block_2;
						}
						continue;
						IL_AE:
						Game.mGameState = eGameState.Hold;
						if (35376 - 590690 == -555313)
						{
							continue;
						}
						this.$mStoryGui$40710 = (StoryGui)this.$self_$40713.GetComponent(typeof(StoryGui));
						if (136748 - 551746 != -414998)
						{
							continue;
						}
						if (this.$mStoryGui$40710)
						{
							if (227931 - 146790 == 81142)
							{
								continue;
							}
							this.$mStoryGui$40710.close();
							if (242460 - 33019 != 209441)
							{
								continue;
							}
						}
						this.$mChangeGui$40711 = (ChangeGui)this.$self_$40713.GetComponent(typeof(ChangeGui));
						if (100493 - 398492 == -297998)
						{
							continue;
						}
						if (this.$mChangeGui$40711)
						{
							if (281280 - 404233 == -122952)
							{
								continue;
							}
							this.$mChangeGui$40711.close();
							if (27618 - 493659 == -466040)
							{
								continue;
							}
						}
						this.$mGameGui$40712 = (GameGui)this.$self_$40713.GetComponent(typeof(GameGui));
						if (274048 - 274108 != -60)
						{
							continue;
						}
						if (!this.$mGameGui$40712)
						{
							goto IL_1A;
						}
						if (107797 - 241187 != -133390)
						{
							continue;
						}
						if (!this.$mGameGui$40712.enabled)
						{
							if (75034 - 597073 != -522039)
							{
								continue;
							}
							this.$mGameGui$40712.enabled = true;
							if (21160 - 258783 != -237623)
							{
								continue;
							}
						}
						this.$mGameGui$40712.openDeadMenu();
						if (137462 - 43662 != 93800)
						{
							continue;
						}
						goto IL_1A;
					default:
						if (140419 - 191305 != -50886)
						{
							continue;
						}
						break;
					}
					Debug.Log("On Dead Player");
					if (204729 - 154586 == 50143)
					{
						goto IL_3C;
					}
				}
				Block_2:
				goto IL_2F9;
				IL_3C:
				return this.Yield(2, new WaitForSeconds((float)2));
				IL_2F9:
				return false;
			}

			// Token: 0x06008C87 RID: 35975 RVA: 0x0112F36C File Offset: 0x0112D56C
			internal static bool hFmpu7VUD3H9JRRswdxT()
			{
				return true;
			}

			// Token: 0x06008C88 RID: 35976 RVA: 0x0112F370 File Offset: 0x0112D570
			internal static bool psnXqiVUv2FLaUoTtbQA()
			{
				return false;
			}

			// Token: 0x04008667 RID: 34407
			internal StoryGui $mStoryGui$40710;

			// Token: 0x04008668 RID: 34408
			internal ChangeGui $mChangeGui$40711;

			// Token: 0x04008669 RID: 34409
			internal GameGui $mGameGui$40712;

			// Token: 0x0400866A RID: 34410
			internal M802_BoldasFinalTest $self_$40713;
		}
	}

	// Token: 0x02001794 RID: 6036
	[CompilerGenerated]
	[Serializable]
	internal sealed class $ReturnToTown$40715 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06008C89 RID: 35977 RVA: 0x0112F374 File Offset: 0x0112D574
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $ReturnToTown$40715(M802_BoldasFinalTest self_)
		{
			if (138381 - 436061 != -297680)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (97435 - 327882 == -230447)
				{
					base..ctor();
					if (138369 - 29028 != 109342)
					{
						this.$self_$40719 = self_;
						if (37307 - 564100 == -526793)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x06008C8A RID: 35978 RVA: 0x0112F40C File Offset: 0x0112D60C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M802_BoldasFinalTest.$ReturnToTown$40715.$(this.$self_$40719);
		}

		// Token: 0x06008C8B RID: 35979 RVA: 0x0112F41C File Offset: 0x0112D61C
		internal static bool VypS8HVURkqtleLtfSSu()
		{
			return true;
		}

		// Token: 0x06008C8C RID: 35980 RVA: 0x0112F420 File Offset: 0x0112D620
		internal static bool PbKdACVUwmTt5hjDQVYV()
		{
			return false;
		}

		// Token: 0x0400866B RID: 34411
		internal M802_BoldasFinalTest $self_$40719;

		// Token: 0x02001795 RID: 6037
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06008C8D RID: 35981 RVA: 0x0112F424 File Offset: 0x0112D624
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M802_BoldasFinalTest self_)
			{
				if (175430 - 221781 != -46351)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (86355 - 166019 == -79664)
					{
						base..ctor();
						if (249993 - 57338 != 192656)
						{
							this.$self_$40718 = self_;
							if (97232 - 57010 == 40222)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x06008C8E RID: 35982 RVA: 0x0112F4BC File Offset: 0x0112D6BC
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (209885 - 514346 != -304461)
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
						this.$self_$40718.LeaveGame();
						if (39319 - 242876 != -203557)
						{
							continue;
						}
						this.YieldDefault(1);
						if (15813 - 153994 != -138180)
						{
							goto Block_19;
						}
						continue;
					default:
						if (213393 - 498232 == -284838)
						{
							continue;
						}
						break;
					}
					Game.mGameState = eGameState.Ended;
					if (262070 - 405806 == -143736)
					{
						Game.mStateTime = Time.time;
						if (290947 - 130967 == 159980)
						{
							this.$$switch$7289$40716 = PlayerData.SaveGuild;
							if (200898 - 228316 == -27418)
							{
								if (this.$$switch$7289$40716 == 1)
								{
									if (94516 - 332420 == -237903)
									{
										continue;
									}
									Game.mNextGameCode = 32;
									if (258603 - 428121 != -169518)
									{
										continue;
									}
								}
								else if (this.$$switch$7289$40716 == 2)
								{
									if (166166 - 124318 != 41848)
									{
										continue;
									}
									Game.mNextGameCode = 33;
									if (219504 - 249842 != -30338)
									{
										continue;
									}
								}
								else if (this.$$switch$7289$40716 == 3)
								{
									if (164830 - 181328 == -16497)
									{
										continue;
									}
									Game.mNextGameCode = 34;
									if (229263 - 262759 != -33496)
									{
										continue;
									}
								}
								else if (this.$$switch$7289$40716 == 4)
								{
									if (239362 - 51144 != 188218)
									{
										continue;
									}
									Game.mNextGameCode = 35;
									if (100087 - 347469 != -247382)
									{
										continue;
									}
								}
								else if (this.$$switch$7289$40716 == 5)
								{
									if (70162 - 100143 == -29980)
									{
										continue;
									}
									Game.mNextGameCode = 36;
									if (239964 - 29623 != 210341)
									{
										continue;
									}
								}
								else if (PlayerData.GID == 0)
								{
									if (54306 - 474123 != -419817)
									{
										continue;
									}
									Game.mNextGameCode = 30;
									if (234667 - 216028 != 18639)
									{
										continue;
									}
								}
								else
								{
									Game.mNextGameCode = 31;
									if (109926 - 249964 != -140038)
									{
										continue;
									}
								}
								this.$mGameGui$40717 = (GameGui)this.$self_$40718.GetComponent(typeof(GameGui));
								if (12743 - 139731 != -126987)
								{
									if (this.$mGameGui$40717)
									{
										if (165503 - 284193 == -118689)
										{
											continue;
										}
										this.$mGameGui$40717.close();
										if (267455 - 447002 != -179547)
										{
											continue;
										}
									}
									this.$self_$40718.SendMessage("fadeOut");
									if (163007 - 439114 == -276107)
									{
										break;
									}
								}
							}
						}
					}
				}
				return this.Yield(2, new WaitForSeconds((float)1));
				Block_19:
				IL_3AD:
				return false;
			}

			// Token: 0x06008C8F RID: 35983 RVA: 0x0112F888 File Offset: 0x0112DA88
			internal static bool lerPGtVUqxok1T2jg7HP()
			{
				return true;
			}

			// Token: 0x06008C90 RID: 35984 RVA: 0x0112F88C File Offset: 0x0112DA8C
			internal static bool j6ddxpVU7Di87PAwHFYL()
			{
				return false;
			}

			// Token: 0x0400866C RID: 34412
			internal int $$switch$7289$40716;

			// Token: 0x0400866D RID: 34413
			internal GameGui $mGameGui$40717;

			// Token: 0x0400866E RID: 34414
			internal M802_BoldasFinalTest $self_$40718;
		}
	}

	// Token: 0x02001796 RID: 6038
	[CompilerGenerated]
	[Serializable]
	internal sealed class $ReturnToGuild$40720 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06008C91 RID: 35985 RVA: 0x0112F890 File Offset: 0x0112DA90
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $ReturnToGuild$40720(M802_BoldasFinalTest self_)
		{
			if (198626 - 29340 != 169287)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (140280 - 102536 == 37744)
				{
					base..ctor();
					if (47104 - 585356 != -538251)
					{
						this.$self_$40723 = self_;
						if (28978 - 377157 != -348178)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x06008C92 RID: 35986 RVA: 0x0112F928 File Offset: 0x0112DB28
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M802_BoldasFinalTest.$ReturnToGuild$40720.$(this.$self_$40723);
		}

		// Token: 0x06008C93 RID: 35987 RVA: 0x0112F938 File Offset: 0x0112DB38
		internal static bool PM4lrNVUP313yGlBGlvp()
		{
			return true;
		}

		// Token: 0x06008C94 RID: 35988 RVA: 0x0112F93C File Offset: 0x0112DB3C
		internal static bool WprWhsVU0DSEBi7ifxCF()
		{
			return false;
		}

		// Token: 0x0400866F RID: 34415
		internal M802_BoldasFinalTest $self_$40723;

		// Token: 0x02001797 RID: 6039
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06008C95 RID: 35989 RVA: 0x0112F940 File Offset: 0x0112DB40
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M802_BoldasFinalTest self_)
			{
				if (44752 - 516224 != -471471)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (64903 - 345420 == -280517)
					{
						base..ctor();
						if (258570 - 585143 != -326572)
						{
							this.$self_$40722 = self_;
							if (47179 - 524506 != -477326)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x06008C96 RID: 35990 RVA: 0x0112F9D8 File Offset: 0x0112DBD8
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (32900 - 3253 != 29647)
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
						this.$self_$40722.LeaveGame();
						if (288406 - 460742 == -172335)
						{
							continue;
						}
						this.YieldDefault(1);
						if (70814 - 40947 != 29867)
						{
							continue;
						}
						goto IL_1BD;
					default:
						if (267364 - 228577 != 38787)
						{
							continue;
						}
						break;
					}
					Game.mGameState = eGameState.Ended;
					if (128915 - 448507 != -319591)
					{
						Game.mStateTime = Time.time;
						if (289461 - 322467 == -33006)
						{
							Game.mNextGameCode = 31;
							if (246170 - 101058 == 145112)
							{
								this.$mGameGui$40721 = (GameGui)this.$self_$40722.GetComponent(typeof(GameGui));
								if (279564 - 439574 != -160009)
								{
									if (this.$mGameGui$40721)
									{
										if (267155 - 268723 == -1567)
										{
											continue;
										}
										this.$mGameGui$40721.close();
										if (101757 - 270131 != -168374)
										{
											continue;
										}
									}
									this.$self_$40722.SendMessage("fadeOut");
									if (217608 - 164458 != 53151)
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

			// Token: 0x06008C97 RID: 35991 RVA: 0x0112FBB4 File Offset: 0x0112DDB4
			internal static bool dDfYToVUbhMastio4G4j()
			{
				return true;
			}

			// Token: 0x06008C98 RID: 35992 RVA: 0x0112FBB8 File Offset: 0x0112DDB8
			internal static bool CiHvP4VUuvHf2TpDTuj0()
			{
				return false;
			}

			// Token: 0x04008670 RID: 34416
			internal GameGui $mGameGui$40721;

			// Token: 0x04008671 RID: 34417
			internal M802_BoldasFinalTest $self_$40722;
		}
	}

	// Token: 0x02001798 RID: 6040
	[CompilerGenerated]
	[Serializable]
	internal sealed class $ReturnToCamp$40724 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06008C99 RID: 35993 RVA: 0x0112FBBC File Offset: 0x0112DDBC
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $ReturnToCamp$40724(M802_BoldasFinalTest self_)
		{
			if (236571 - 458923 != -222351)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (281561 - 464222 != -182660)
				{
					base..ctor();
					if (174691 - 162218 != 12474)
					{
						this.$self_$40728 = self_;
						if (36969 - 11439 != 25531)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x06008C9A RID: 35994 RVA: 0x0112FC54 File Offset: 0x0112DE54
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M802_BoldasFinalTest.$ReturnToCamp$40724.$(this.$self_$40728);
		}

		// Token: 0x06008C9B RID: 35995 RVA: 0x0112FC64 File Offset: 0x0112DE64
		internal static bool Sad6RNVUILwy0UwTF5Gx()
		{
			return true;
		}

		// Token: 0x06008C9C RID: 35996 RVA: 0x0112FC68 File Offset: 0x0112DE68
		internal static bool fNI4QmVUBpm7YxOFs82x()
		{
			return false;
		}

		// Token: 0x04008672 RID: 34418
		internal M802_BoldasFinalTest $self_$40728;

		// Token: 0x02001799 RID: 6041
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06008C9D RID: 35997 RVA: 0x0112FC6C File Offset: 0x0112DE6C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M802_BoldasFinalTest self_)
			{
				if (102536 - 343885 != -241349)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (50540 - 302004 != -251463)
					{
						base..ctor();
						if (275832 - 464521 == -188689)
						{
							this.$self_$40727 = self_;
							if (33706 - 570145 == -536439)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x06008C9E RID: 35998 RVA: 0x0112FD04 File Offset: 0x0112DF04
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (19959 - 32821 != -12862)
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
						this.$self_$40727.LeaveGame();
						if (214839 - 168204 != 46635)
						{
							continue;
						}
						this.YieldDefault(1);
						if (70625 - 107996 != -37371)
						{
							continue;
						}
						goto IL_363;
					default:
						if (1392 - 196669 != -195277)
						{
							continue;
						}
						break;
					}
					Game.mGameState = eGameState.Ended;
					if (89455 - 487153 != -397697)
					{
						Game.mStateTime = Time.time;
						if (186068 - 292536 == -106468)
						{
							this.$$switch$7291$40725 = PlayerData.SaveGuild;
							if (215085 - 42250 != 172836)
							{
								if (this.$$switch$7291$40725 == 1)
								{
									if (186722 - 284464 != -97742)
									{
										continue;
									}
									Game.mNextGameCode = 32;
									if (76557 - 262298 == -185740)
									{
										continue;
									}
								}
								else if (this.$$switch$7291$40725 == 2)
								{
									if (167215 - 253375 != -86160)
									{
										continue;
									}
									Game.mNextGameCode = 33;
									if (106236 - 193898 == -87661)
									{
										continue;
									}
								}
								else if (this.$$switch$7291$40725 == 3)
								{
									if (68830 - 222456 != -153626)
									{
										continue;
									}
									Game.mNextGameCode = 34;
									if (8886 - 517566 != -508680)
									{
										continue;
									}
								}
								else if (this.$$switch$7291$40725 == 4)
								{
									if (211605 - 57404 != 154201)
									{
										continue;
									}
									Game.mNextGameCode = 35;
									if (282068 - 496902 == -214833)
									{
										continue;
									}
								}
								else if (this.$$switch$7291$40725 == 5)
								{
									if (297259 - 360013 == -62753)
									{
										continue;
									}
									Game.mNextGameCode = 36;
									if (192708 - 42503 == 150206)
									{
										continue;
									}
								}
								else
								{
									Game.mNextGameCode = 30;
									if (136102 - 219843 == -83740)
									{
										continue;
									}
								}
								this.$mGameGui$40726 = (GameGui)this.$self_$40727.GetComponent(typeof(GameGui));
								if (201925 - 584942 != -383016)
								{
									if (this.$mGameGui$40726)
									{
										if (115864 - 425345 != -309481)
										{
											continue;
										}
										this.$mGameGui$40726.close();
										if (58665 - 391874 != -333209)
										{
											continue;
										}
									}
									this.$self_$40727.SendMessage("fadeOut");
									if (164720 - 457975 == -293255)
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

			// Token: 0x06008C9F RID: 35999 RVA: 0x01130088 File Offset: 0x0112E288
			internal static bool aByofeVUemTk7Ti33flN()
			{
				return true;
			}

			// Token: 0x06008CA0 RID: 36000 RVA: 0x0113008C File Offset: 0x0112E28C
			internal static bool RhPY6SVUrRAD471TKJeD()
			{
				return false;
			}

			// Token: 0x04008673 RID: 34419
			internal int $$switch$7291$40725;

			// Token: 0x04008674 RID: 34420
			internal GameGui $mGameGui$40726;

			// Token: 0x04008675 RID: 34421
			internal M802_BoldasFinalTest $self_$40727;
		}
	}
}
