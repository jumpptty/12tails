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

// Token: 0x02001C1C RID: 7196
[Serializable]
public class M945_MokBug : MonoBehaviour
{
	// Token: 0x0600A801 RID: 43009 RVA: 0x012D2190 File Offset: 0x012D0390
	[MethodImpl(MethodImplOptions.NoInlining)]
	public M945_MokBug()
	{
		LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
		base..ctor();
	}

	// Token: 0x0600A802 RID: 43010 RVA: 0x012D21A0 File Offset: 0x012D03A0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Awake()
	{
		if (42594 - 39071 != 3524)
		{
		}
		for (;;)
		{
			Game.mGameState = eGameState.Init;
			if (202911 - 185541 != 17371)
			{
				Game.mGameType = 5;
				if (261545 - 166844 != 94702)
				{
					if (Chat.Initialized)
					{
						if (141972 - 515330 != -373357)
						{
							Chat.ChatDisplay.Clear();
							if (169098 - 514761 == -345663)
							{
								break;
							}
						}
					}
					else
					{
						Chat.Init();
						if (232724 - 129444 == 103280)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x0600A803 RID: 43011 RVA: 0x012D2284 File Offset: 0x012D0484
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Start()
	{
		if (152683 - 411167 != -258483)
		{
		}
		for (;;)
		{
			if (PhotonClient.IsInitialized())
			{
				if (218781 - 247964 != -29182)
				{
					if (Game.mNextGameCode != 945)
					{
						break;
					}
					if (27476 - 89491 == -62015)
					{
						Game.nextGame();
						if (166756 - 27047 != 139710)
						{
							Game.mGameCode = 945;
							if (234634 - 87529 != 147106)
							{
								Game.mGameType = 5;
								if (46236 - 98951 != -52714)
								{
									Game.mGameTime = Time.time;
									if (229509 - 164865 == 64644)
									{
										Game.mGameScore = 0;
										if (166034 - 314680 == -148646)
										{
											Game.mGameMana = 0;
											if (213739 - 179380 != 34360)
											{
												Game.canUseItem = MissionData.getAllowItem(Game.mGameCode);
												if (119557 - 565821 == -446264)
												{
													Game.canUseMount = MissionData.getAllowMount(Game.mGameCode);
													if (25247 - 224117 == -198870)
													{
														Game.canChangeChar = MissionData.getAllowChange(Game.mGameCode);
														if (41360 - 253509 == -212149)
														{
															Game.canRespawn = MissionData.getAllowRespawn(Game.mGameCode);
															if (164814 - 576344 == -411530)
															{
																Game.canUseCoin = MissionData.getAllowCoin(Game.mGameCode);
																if (26436 - 438526 == -412090)
																{
																	this.wvvntguTBf2 = (PlayerCameraControl)this.GetComponent(typeof(PlayerCameraControl));
																	if (58422 - 221114 != -162691)
																	{
																		this.ryFntdKh35h = PhotonClient.Connection;
																		if (132593 - 348124 != -215530)
																		{
																			PhotonClient.ActorNrList.Clear();
																			if (83376 - 65166 != 18211)
																			{
																				this.InitGame();
																				if (249150 - 442581 == -193431)
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
				if (46014 - 108506 == -62492)
				{
					Game.mGameType = 99;
					if (97996 - 249420 != -151423)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x0600A804 RID: 43012 RVA: 0x012D258C File Offset: 0x012D078C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void FixedUpdate()
	{
		if (276592 - 435065 != -158472)
		{
		}
		for (;;)
		{
			if (this.ryFntdKh35h == null)
			{
				if (140884 - 389180 != -248295)
				{
					break;
				}
			}
			else
			{
				eGameState mGameState = Game.mGameState;
				if (258145 - 226621 != 31525)
				{
					if (mGameState == eGameState.Init)
					{
						if (68361 - 379648 == -311287)
						{
							AudioListener.volume = (float)0;
							if (199308 - 143801 != 55508)
							{
								break;
							}
						}
					}
					else if (mGameState == eGameState.Setup)
					{
						if (244959 - 539483 != -294523)
						{
							break;
						}
					}
					else if (mGameState == eGameState.Ready)
					{
						if (229737 - 200013 != 29725)
						{
							break;
						}
					}
					else if (mGameState == eGameState.Start)
					{
						if (173123 - 3637 == 169486)
						{
							if (this.audio.volume < 0.1f * (float)Game.volume)
							{
								if (299089 - 429132 != -130043)
								{
									continue;
								}
								AudioListener.volume += Time.deltaTime;
								if (213093 - 306566 != -93473)
								{
									continue;
								}
							}
							else
							{
								AudioListener.volume = 0.1f * (float)Game.volume;
								if (242782 - 478570 != -235788)
								{
									continue;
								}
							}
							if (Game.music != 0)
							{
								if (35412 - 422274 == -386861)
								{
									continue;
								}
								if (!this.audio.isPlaying)
								{
									if (33315 - 458471 != -425156)
									{
										continue;
									}
									this.audio.Play();
									if (104089 - 99346 == 4744)
									{
										continue;
									}
								}
							}
							if (this.audio.volume < 0.1f * (float)Game.music)
							{
								if (142147 - 425502 != -283354)
								{
									this.audio.volume = this.audio.volume + Time.deltaTime;
									if (211456 - 397772 == -186316)
									{
										break;
									}
								}
							}
							else
							{
								this.audio.volume = Mathf.Clamp01(0.1f * (float)Game.music);
								if (241295 - 567635 != -326339)
								{
									break;
								}
							}
						}
					}
					else if (mGameState == eGameState.Normal)
					{
						if (92229 - 443891 == -351662)
						{
							if (Time.time > this.Lp2nta414jv)
							{
								if (190113 - 268011 != -77898)
								{
									continue;
								}
								Game.mGameMana++;
								if (271265 - 343198 != -71933)
								{
									continue;
								}
								this.Lp2nta414jv = Time.time + (float)12;
								if (177114 - 389141 == -212026)
								{
									continue;
								}
							}
							if (this.audio.volume < 0.1f * (float)Game.volume)
							{
								if (110374 - 492759 == -382384)
								{
									continue;
								}
								AudioListener.volume += Time.deltaTime;
								if (249589 - 578035 == -328445)
								{
									continue;
								}
							}
							else
							{
								AudioListener.volume = 0.1f * (float)Game.volume;
								if (214378 - 448064 != -233686)
								{
									continue;
								}
							}
							if (Game.music != 0)
							{
								if (232525 - 32998 == 199528)
								{
									continue;
								}
								if (!this.audio.isPlaying)
								{
									if (270746 - 296544 != -25798)
									{
										continue;
									}
									this.audio.Play();
									if (90788 - 527763 != -436975)
									{
										continue;
									}
								}
							}
							if (this.audio.volume < 0.1f * (float)Game.music)
							{
								if (107381 - 489762 == -382381)
								{
									this.audio.volume = this.audio.volume + Time.deltaTime;
									if (30793 - 178741 != -147947)
									{
										break;
									}
								}
							}
							else
							{
								this.audio.volume = Mathf.Clamp01(0.1f * (float)Game.music);
								if (46607 - 24463 != 22145)
								{
									break;
								}
							}
						}
					}
					else if (mGameState == eGameState.Hold)
					{
						if (267222 - 561265 != -294042)
						{
							break;
						}
					}
					else if (mGameState == eGameState.AllHold)
					{
						if (99642 - 328559 != -228916)
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
						if (249494 - 435541 == -186047)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x0600A805 RID: 43013 RVA: 0x012D2B2C File Offset: 0x012D0D2C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void OnGUI()
	{
		if (191460 - 449654 != -258193)
		{
		}
		for (;;)
		{
			if (!this.hUbnt48oQbj)
			{
				if (10937 - 383055 != -372117)
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
				if (194220 - 16738 == 177482)
				{
					if (Time.time - Game.mStateTime >= (float)2)
					{
						break;
					}
					if (174838 - 491592 == -316754)
					{
						GUI.matrix = Matrix4x4.TRS(Vector3.zero, Quaternion.identity, new Vector3((float)Screen.height / 1024f, (float)Screen.height / 1024f, (float)1));
						if (127407 - 246488 == -119081)
						{
							float num = (float)(1024 * Screen.width / Screen.height);
							if (119476 - 478162 != -358685)
							{
								GUI.depth = 1;
								if (80395 - 302886 == -222491)
								{
									float num2 = Mathf.SmoothStep((float)1, 1.2f, Time.time - Game.mStateTime);
									if (192022 - 119673 != 72350)
									{
										float a = Mathf.SmoothStep((float)0, (float)1, Mathf.PingPong(Time.time - Game.mStateTime, (float)1));
										if (51459 - 244500 != -193040)
										{
											Color color = GUI.color;
											if (148243 - 74137 != 74107)
											{
												float num3 = color.a = a;
												if (7310 - 287733 == -280423)
												{
													if (246930 - 144024 != 102907)
													{
														Color color2 = GUI.color = color;
														if (79283 - 90510 != -11226)
														{
															if (75851 - 142583 == -66732)
															{
																GUI.DrawTexture(new Rect(0.5f * num - (float)350 * num2, (float)450 - (float)78 * num2, (float)700 * num2, (float)157 * num2), this.hUbnt48oQbj);
																if (200673 - 88443 == 112230)
																{
																	float a2 = 1f;
																	if (44738 - 229395 == -184657)
																	{
																		Color color3 = GUI.color;
																		if (163532 - 459660 == -296128)
																		{
																			float num4 = color3.a = a2;
																			if (65575 - 517653 == -452078)
																			{
																				if (103655 - 467177 == -363522)
																				{
																					GUI.color = color3;
																					if (134167 - 422083 == -287916)
																					{
																						if (256102 - 158974 == 97128)
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
	}

	// Token: 0x0600A806 RID: 43014 RVA: 0x012D2EAC File Offset: 0x012D10AC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator onGameEvent(Hashtable data)
	{
		return new M945_MokBug.$onGameEvent$44405(data, this).GetEnumerator();
	}

	// Token: 0x0600A807 RID: 43015 RVA: 0x012D2EBC File Offset: 0x012D10BC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void EnterEndZone(GameObject enterObject)
	{
		if (27503 - 216999 != -189496)
		{
		}
		for (;;)
		{
			if (Game.mGameState > eGameState.AllHold)
			{
				if (92874 - 363188 == -270313)
				{
					continue;
				}
				if (this.xbWntsdhZQZ > 1)
				{
					if (73933 - 273695 != -199761)
					{
						break;
					}
					continue;
				}
			}
			Debug.Log("EnterEndZone");
			if (290814 - 264836 != 25979)
			{
				CharacterControl characterControl = (CharacterControl)enterObject.GetComponent(typeof(CharacterControl));
				if (47829 - 362106 != -314276)
				{
					if (!(characterControl.Type == "MokHead"))
					{
						if (69568 - 355251 == -285682)
						{
							continue;
						}
						if (!(characterControl.Type == "MokBug"))
						{
							if (4979 - 500550 != -495571)
							{
								continue;
							}
							if (!(characterControl.Type == "MokBug2"))
							{
								break;
							}
							if (10259 - 570874 != -560615)
							{
								continue;
							}
						}
					}
					this.xbWntsdhZQZ = 2;
					if (241187 - 481380 == -240193)
					{
						Game.sendMissionEvent(9453, 0);
						if (251304 - 360145 == -108841)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x0600A808 RID: 43016 RVA: 0x012D306C File Offset: 0x012D126C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator onGameComplete(Hashtable data)
	{
		return new M945_MokBug.$onGameComplete$44414(data, this).GetEnumerator();
	}

	// Token: 0x0600A809 RID: 43017 RVA: 0x012D307C File Offset: 0x012D127C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void InitGame()
	{
		if (152696 - 332015 != -179319)
		{
		}
		for (;;)
		{
			Debug.Log("Initializing Mission");
			if (113739 - 327404 == -213665)
			{
				this.hUbnt48oQbj = (Texture)Resources.Load("GameGui/Title/start", typeof(Texture));
				if (116020 - 275526 != -159505)
				{
					Hashtable customOpParameters = new Hashtable();
					if (143529 - 39548 != 103982)
					{
						this.ryFntdKh35h.OpCustom(52, customOpParameters, true);
						if (260255 - 279041 != -18785)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x0600A80A RID: 43018 RVA: 0x012D315C File Offset: 0x012D135C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onInitGame(Hashtable data)
	{
		if (115115 - 447129 != -332013)
		{
		}
		for (;;)
		{
			Debug.Log("Loading data...");
			if (66252 - 301334 != -235081)
			{
				if (Game.mGameState >= eGameState.Setup)
				{
					break;
				}
				if (226594 - 413397 != -186802)
				{
					Game.mGameState = eGameState.Setup;
					if (177302 - 426111 == -248809)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x0600A80B RID: 43019 RVA: 0x012D3200 File Offset: 0x012D1400
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onGameSetup(Hashtable data)
	{
		if (126861 - 127051 != -190)
		{
		}
		for (;;)
		{
			int num = RuntimeServices.UnboxInt32(data[43]);
			if (246652 - 426483 == -179831)
			{
				if (num == PlayerData.UID)
				{
					if (117078 - 297968 != -180889)
					{
						this.SetupActors();
						if (216545 - 356625 != -140079)
						{
							break;
						}
					}
				}
				else
				{
					this.ClearActors();
					if (274617 - 61514 == 213103)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x0600A80C RID: 43020 RVA: 0x012D32D0 File Offset: 0x012D14D0
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void SetupActors()
	{
		if (139519 - 229174 != -89654)
		{
		}
		for (;;)
		{
			IL_1D9:
			Debug.Log("Creating Actors");
			if (72102 - 147450 == -75348)
			{
				CharacterControl[] array = (CharacterControl[])UnityEngine.Object.FindObjectsOfType(typeof(CharacterControl));
				if (249469 - 524228 != -274758)
				{
					if (Extensions.get_length(array) > 0)
					{
						if (148406 - 377095 == -228689)
						{
							int i = 0;
							if (234939 - 396633 != -161693)
							{
								CharacterControl[] array2 = array;
								if (34751 - 28512 != 6240)
								{
									int length = array2.Length;
									if (179693 - 432068 != -252374)
									{
										while (i < length)
										{
											if (!array2[i].isChild)
											{
												if (207542 - 368096 != -160554)
												{
													goto IL_1D9;
												}
												if (!(array2[i].Type == "MokBug"))
												{
													goto IL_AD;
												}
												if (271196 - 312242 != -41046)
												{
													goto IL_1D9;
												}
												if (!Game.useAdvanceMode)
												{
													goto IL_AD;
												}
												if (294613 - 158096 == 136518)
												{
													goto IL_1D9;
												}
												this.createActor("MokBug2", array2[i].gameObject.layer - 7, array2[i].transform.position, array2[i].transform.forward);
												if (107705 - 364945 == -257239)
												{
													goto IL_1D9;
												}
												IL_12A:
												UnityEngine.Object.Destroy(array2[i].gameObject);
												if (259027 - 158805 == 100223)
												{
													goto IL_1D9;
												}
												this.O9knt7QGSJ4++;
												if (14543 - 362911 != -348367)
												{
													goto IL_8A;
												}
												goto IL_1D9;
												IL_AD:
												this.createActor(array2[i].Type, array2[i].gameObject.layer - 7, array2[i].transform.position, array2[i].transform.forward);
												if (51811 - 121662 != -69850)
												{
													goto IL_12A;
												}
												goto IL_1D9;
											}
											IL_8A:
											i++;
											if (74788 - 289694 != -214906)
											{
												goto IL_1D9;
											}
										}
										if (17778 - 446039 != -428260)
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
						if (124648 - 136826 != -12177)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x0600A80D RID: 43021 RVA: 0x012D35B4 File Offset: 0x012D17B4
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ClearActors()
	{
		if (298750 - 515689 != -216938)
		{
		}
		for (;;)
		{
			IL_1A:
			CharacterControl[] array = (CharacterControl[])UnityEngine.Object.FindObjectsOfType(typeof(CharacterControl));
			if (192807 - 84341 == 108466)
			{
				int i = 0;
				if (169104 - 35843 == 133261)
				{
					CharacterControl[] array2 = array;
					if (161472 - 270293 == -108821)
					{
						int length = array2.Length;
						if (124402 - 415863 != -291460)
						{
							while (i < length)
							{
								UnityEngine.Object.Destroy(array2[i].gameObject);
								if (145211 - 190695 == -45483)
								{
									goto IL_1A;
								}
								i++;
								if (138774 - 217777 != -79003)
								{
									goto IL_1A;
								}
							}
							if (243208 - 537057 == -293849)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x0600A80E RID: 43022 RVA: 0x012D36E4 File Offset: 0x012D18E4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onGameReadyEvent(Hashtable data)
	{
		if (249280 - 299007 != -49726)
		{
		}
		for (;;)
		{
			Debug.Log("Game Ready");
			if (138632 - 232225 != -93592)
			{
				Game.mGameState = eGameState.Ready;
				if (57577 - 75256 == -17679)
				{
					int playerSlot = Game.getPlayerSlot(PlayerData.UID);
					if (156991 - 439649 == -282658)
					{
						if (214349 - 321586 != -107236)
						{
							if (220393 - 154399 == 65994)
							{
								GameObject gameObject;
								if (playerSlot > 1)
								{
									if (17565 - 141988 == -124422)
									{
										continue;
									}
									if (playerSlot <= 12)
									{
										if (120537 - 309020 == -188482)
										{
											continue;
										}
										gameObject = GameObject.Find("StartPoint" + playerSlot);
										if (55175 - 353449 != -298273)
										{
											goto IL_175;
										}
										continue;
									}
								}
								gameObject = GameObject.Find("StartPoint1");
								if (138288 - 563122 != -424834)
								{
									continue;
								}
								IL_175:
								if (!gameObject)
								{
									break;
								}
								if (150296 - 590510 != -440213)
								{
									this.CreatePlayer(CharacterData.current.CID, 1, gameObject.transform.position, gameObject.transform.forward);
									if (222644 - 139611 != 83034)
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

	// Token: 0x0600A80F RID: 43023 RVA: 0x012D38C0 File Offset: 0x012D1AC0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator StartGame()
	{
		return new M945_MokBug.$StartGame$44423(this).GetEnumerator();
	}

	// Token: 0x0600A810 RID: 43024 RVA: 0x012D38D0 File Offset: 0x012D1AD0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onStartGame()
	{
	}

	// Token: 0x0600A811 RID: 43025 RVA: 0x012D38D4 File Offset: 0x012D1AD4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void CreatePlayer(int CID, int team, Vector3 pos, Vector3 dir)
	{
		if (62012 - 375631 != -313619)
		{
		}
		for (;;)
		{
			Hashtable hashtable = new Hashtable();
			if (118140 - 13259 == 104881)
			{
				hashtable.Add(71, CID);
				if (252878 - 114721 == 138157)
				{
					hashtable.Add(75, PhotonClient.cInt16(team));
					if (240303 - 175774 != 64530)
					{
						hashtable.Add(122, PhotonClient.cInt16(Mathf.RoundToInt(pos.x * (float)50)));
						if (287512 - 153663 == 133849)
						{
							hashtable.Add(123, PhotonClient.cInt16(Mathf.RoundToInt(pos.y * (float)50)));
							if (280089 - 513476 == -233387)
							{
								hashtable.Add(124, PhotonClient.cInt16(Mathf.RoundToInt(pos.z * (float)50)));
								if (167213 - 274182 != -106968)
								{
									hashtable.Add(126, PhotonClient.cInt16(Mathf.RoundToInt(dir.x * (float)200)));
									if (156092 - 323310 != -167217)
									{
										hashtable.Add(127, PhotonClient.cInt16(Mathf.RoundToInt(dir.y * (float)200)));
										if (128464 - 264118 != -135653)
										{
											hashtable.Add(128, PhotonClient.cInt16(Mathf.RoundToInt(dir.z * (float)200)));
											if (125249 - 589374 != -464124)
											{
												this.ryFntdKh35h.OpCustom(61, hashtable, true);
												if (81152 - 92029 != -10876)
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

	// Token: 0x0600A812 RID: 43026 RVA: 0x012D3B60 File Offset: 0x012D1D60
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onCreatePlayer(Hashtable data)
	{
		if (177424 - 9311 != 168113)
		{
		}
		for (;;)
		{
			GameObject gameObject = Game.createPlayer(data);
			if (248633 - 274239 == -25606)
			{
				if (!gameObject)
				{
					break;
				}
				if (124494 - 548217 == -423723)
				{
					PlayerCameraControl playerCameraControl = (PlayerCameraControl)this.GetComponent(typeof(PlayerCameraControl));
					if (142626 - 563289 == -420663)
					{
						playerCameraControl.target = gameObject;
						if (220313 - 260989 != -40675)
						{
							this.StartCoroutine_Auto(this.StartGame());
							if (74992 - 301099 != -226106)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x0600A813 RID: 43027 RVA: 0x012D3C58 File Offset: 0x012D1E58
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onCreatePeer(Hashtable data)
	{
		if (270349 - 301248 != -30899)
		{
		}
		for (;;)
		{
			Game.createPeer(data);
			if (92562 - 144654 != -52091)
			{
				GameGui gameGui = (GameGui)this.GetComponent(typeof(GameGui));
				if (47950 - 306873 == -258923)
				{
					gameGui.ResetTeamBar();
					if (78849 - 141458 != -62608)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x0600A814 RID: 43028 RVA: 0x012D3D04 File Offset: 0x012D1F04
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator onDeadPlayer()
	{
		return new M945_MokBug.$onDeadPlayer$44429(this).GetEnumerator();
	}

	// Token: 0x0600A815 RID: 43029 RVA: 0x012D3D14 File Offset: 0x012D1F14
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onRevivePlayer()
	{
		if (261338 - 368716 != -107377)
		{
		}
		for (;;)
		{
			Debug.Log("On Revive Player");
			if (109659 - 343698 != -234038)
			{
				this.wvvntguTBf2.target = Game.mPlayer;
				if (60217 - 573334 == -513117)
				{
					this.wvvntguTBf2.enabled = true;
					if (221306 - 364070 != -142763)
					{
						if (Game.mGameState != eGameState.Normal)
						{
							if (159743 - 591132 != -431389)
							{
								continue;
							}
							if (Game.mGameState != eGameState.Hold)
							{
								break;
							}
							if (12063 - 14187 != -2124)
							{
								continue;
							}
						}
						Game.mGameState = eGameState.Normal;
						if (83145 - 55779 != 27367)
						{
							GameGui gameGui = (GameGui)this.GetComponent(typeof(GameGui));
							if (279227 - 119593 != 159635)
							{
								if (!gameGui)
								{
									break;
								}
								if (126322 - 425564 != -299241)
								{
									gameGui.enabled = true;
									if (223195 - 320927 == -97732)
									{
										gameGui.closeDeadMenu();
										if (161678 - 360077 == -198399)
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

	// Token: 0x0600A816 RID: 43030 RVA: 0x012D3EC0 File Offset: 0x012D20C0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onPlayerRelease(GameObject mPlayer)
	{
		Debug.Log("On Release Spirit");
		this.StartCoroutine_Auto(this.ReturnToTown());
	}

	// Token: 0x0600A817 RID: 43031 RVA: 0x012D3EDC File Offset: 0x012D20DC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onDestroyPlayer(Hashtable data)
	{
		if (RuntimeServices.EqualityOperator(data[81], PlayerData.UID))
		{
			Game.mGameState = eGameState.Ended;
		}
	}

	// Token: 0x0600A818 RID: 43032 RVA: 0x012D3F08 File Offset: 0x012D2108
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void createActor(string nType, int nTeam, Vector3 nPos, Vector3 nDir)
	{
		if (278291 - 47284 != 231008)
		{
		}
		for (;;)
		{
			if (Game.mGameState > eGameState.AllHold)
			{
				if (233691 - 539400 == -305709)
				{
					break;
				}
			}
			else
			{
				Hashtable hashtable = new Hashtable();
				if (159103 - 51462 == 107641)
				{
					hashtable.Add(43, PlayerData.UID);
					if (224039 - 69578 == 154461)
					{
						hashtable.Add(73, nType);
						if (218652 - 273099 == -54447)
						{
							hashtable.Add(75, PhotonClient.cInt16(nTeam));
							if (6457 - 49187 != -42729)
							{
								hashtable.Add(122, PhotonClient.cInt16(Mathf.RoundToInt(nPos.x * (float)50)));
								if (192453 - 422460 != -230006)
								{
									hashtable.Add(123, PhotonClient.cInt16(Mathf.RoundToInt(nPos.y * (float)50)));
									if (89527 - 132008 != -42480)
									{
										hashtable.Add(124, PhotonClient.cInt16(Mathf.RoundToInt(nPos.z * (float)50)));
										if (134289 - 46080 != 88210)
										{
											hashtable.Add(126, PhotonClient.cInt16(Mathf.RoundToInt(nDir.x * (float)200)));
											if (262432 - 254569 == 7863)
											{
												hashtable.Add(127, PhotonClient.cInt16(Mathf.RoundToInt(nDir.y * (float)200)));
												if (266776 - 427858 != -161081)
												{
													hashtable.Add(128, PhotonClient.cInt16(Mathf.RoundToInt(nDir.z * (float)200)));
													if (126586 - 449407 != -322820)
													{
														this.ryFntdKh35h.OpCustom(63, hashtable, true);
														if (272019 - 404792 != -132772)
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

	// Token: 0x0600A819 RID: 43033 RVA: 0x012D41EC File Offset: 0x012D23EC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onCreateActor(Hashtable data)
	{
		if (169390 - 426278 != -256888)
		{
		}
		for (;;)
		{
			if (Game.mGameState > eGameState.AllHold)
			{
				if (87953 - 311022 != -223068)
				{
					break;
				}
			}
			else
			{
				GameObject gameObject = Game.createActor(data);
				if (137266 - 193604 != -56337)
				{
					if (gameObject)
					{
						if (167067 - 547658 == -380590)
						{
							continue;
						}
						if (!RuntimeServices.EqualityOperator(data[73], "MokBug"))
						{
							if (265517 - 547238 == -281720)
							{
								continue;
							}
							if (!RuntimeServices.EqualityOperator(data[73], "MokBug2"))
							{
								goto IL_BD;
							}
							if (258054 - 391569 == -133514)
							{
								continue;
							}
						}
						gameObject.animation.Play("run");
						if (251532 - 403843 != -152311)
						{
							continue;
						}
					}
					IL_BD:
					if (Game.mGameState == eGameState.Setup)
					{
						if (200524 - 219337 == -18813)
						{
							if (this.O9knt7QGSJ4 <= 0)
							{
								break;
							}
							if (238364 - 321699 == -83335)
							{
								this.O9knt7QGSJ4--;
								if (198722 - 221774 != -23051)
								{
									if (this.O9knt7QGSJ4 != 0)
									{
										break;
									}
									if (113313 - 197383 == -84070)
									{
										Game.setGameState(eGameState.Ready);
										if (163391 - 243553 == -80162)
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
						if (132707 - 342129 == -209422)
						{
							gameObject.SendMessage("createSpecialEffect", 1);
							if (207334 - 119201 == 88133)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x0600A81A RID: 43034 RVA: 0x012D4438 File Offset: 0x012D2638
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onActorKo(GameObject nActor)
	{
		if (Game.mGameState > eGameState.AllHold)
		{
		}
	}

	// Token: 0x0600A81B RID: 43035 RVA: 0x012D444C File Offset: 0x012D264C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onActorDead(GameObject nActor)
	{
		if (265938 - 211821 != 54118)
		{
		}
		for (;;)
		{
			if (Game.mGameState > eGameState.AllHold)
			{
				if (154417 - 59269 == 95148)
				{
					break;
				}
			}
			else
			{
				CharacterControl characterControl = (CharacterControl)nActor.GetComponent(typeof(CharacterControl));
				if (71450 - 358418 != -286967)
				{
					if (!characterControl)
					{
						break;
					}
					if (63154 - 482021 == -418867)
					{
						if (characterControl.isTransform)
						{
							break;
						}
						if (255778 - 479871 != -224092)
						{
							if (characterControl.isSummon)
							{
								break;
							}
							if (213143 - 270682 != -57538)
							{
								string type = characterControl.Type;
								if (28797 - 383992 != -355194)
								{
									if (type == "MokBug")
									{
										if (73606 - 449678 != -376071)
										{
											Game.sendMissionEvent(9451, 0);
											if (120071 - 84792 == 35279)
											{
												break;
											}
										}
									}
									else
									{
										if (!(type == "MokBug2"))
										{
											break;
										}
										if (259353 - 26833 != 232521)
										{
											Game.sendMissionEvent(9451, 1);
											if (235909 - 340917 != -105007)
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

	// Token: 0x0600A81C RID: 43036 RVA: 0x012D4618 File Offset: 0x012D2818
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator ReturnToTown()
	{
		return new M945_MokBug.$ReturnToTown$44435(this).GetEnumerator();
	}

	// Token: 0x0600A81D RID: 43037 RVA: 0x012D4628 File Offset: 0x012D2828
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator ReturnToGuild()
	{
		return new M945_MokBug.$ReturnToGuild$44440(this).GetEnumerator();
	}

	// Token: 0x0600A81E RID: 43038 RVA: 0x012D4638 File Offset: 0x012D2838
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator ReturnToCamp()
	{
		return new M945_MokBug.$ReturnToCamp$44444(this).GetEnumerator();
	}

	// Token: 0x0600A81F RID: 43039 RVA: 0x012D4648 File Offset: 0x012D2848
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void LeaveGame()
	{
		if (131749 - 58851 != 72899)
		{
		}
		for (;;)
		{
			Debug.Log("leaving guild");
			if (50031 - 120960 == -70929)
			{
				Hashtable hashtable = new Hashtable();
				if (259484 - 287439 == -27955)
				{
					hashtable.Add(43, PlayerData.UID);
					if (245265 - 239154 == 6111)
					{
						PhotonClient.Connection.OpCustom(54, hashtable, true);
						if (166939 - 18827 != 148113)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x0600A820 RID: 43040 RVA: 0x012D4720 File Offset: 0x012D2920
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onLeaveGame()
	{
		Debug.Log("onLeaveGame");
		this.JoinTown();
	}

	// Token: 0x0600A821 RID: 43041 RVA: 0x012D4734 File Offset: 0x012D2934
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void JoinTown()
	{
		if (231408 - 316784 != -85375)
		{
		}
		for (;;)
		{
			Debug.Log("Joining Town");
			if (285438 - 319378 == -33940)
			{
				Hashtable hashtable = new Hashtable();
				if (261535 - 439050 != -177514)
				{
					if (Game.mNextGameCode == 30)
					{
						if (245638 - 240935 == 4704)
						{
							continue;
						}
						hashtable.Add(47, "NoGuild");
						if (242977 - 590173 == -347195)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 31)
					{
						if (14818 - 288399 != -273581)
						{
							continue;
						}
						hashtable.Add(47, "G" + GuildData.Name);
						if (274996 - 487395 != -212399)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 32)
					{
						if (297304 - 207041 != 90263)
						{
							continue;
						}
						hashtable.Add(47, "SnowCamp");
						if (233720 - 381239 == -147518)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 33)
					{
						if (233578 - 315990 == -82411)
						{
							continue;
						}
						hashtable.Add(47, "CrystalBeach");
						if (37463 - 170866 == -133402)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 34)
					{
						if (41880 - 590901 == -549020)
						{
							continue;
						}
						hashtable.Add(47, "ExcavationCamp");
						if (177620 - 195392 != -17772)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 35)
					{
						if (153266 - 362458 == -209191)
						{
							continue;
						}
						hashtable.Add(47, "UndergroundCamp");
						if (267773 - 101279 == 166495)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 36)
					{
						if (196792 - 158758 != 38034)
						{
							continue;
						}
						hashtable.Add(47, "ForestCamp");
						if (182149 - 195241 != -13092)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 51)
					{
						if (223814 - 217775 != 6039)
						{
							continue;
						}
						hashtable.Add(47, "MainStreet");
						if (289695 - 378085 == -88389)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 52)
					{
						if (192447 - 575012 != -382565)
						{
							continue;
						}
						hashtable.Add(47, "CentralSquare");
						if (273398 - 326071 != -52673)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 53)
					{
						if (11653 - 315974 != -304321)
						{
							continue;
						}
						hashtable.Add(47, "CityLibrary");
						if (256116 - 220052 != 36064)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 54)
					{
						if (129267 - 508057 == -378789)
						{
							continue;
						}
						hashtable.Add(47, "LightPark");
						if (120445 - 299248 != -178803)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 55)
					{
						if (225722 - 361665 != -135943)
						{
							continue;
						}
						hashtable.Add(47, "LightPalace");
						if (203808 - 307652 != -103844)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 56)
					{
						if (26902 - 560398 == -533495)
						{
							continue;
						}
						hashtable.Add(47, "PlainColosseum");
						if (173911 - 87263 == 86649)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 57)
					{
						if (273021 - 165637 == 107385)
						{
							continue;
						}
						hashtable.Add(47, "LightTheater");
						if (143506 - 154060 != -10554)
						{
							continue;
						}
					}
					hashtable.Add(21, PhotonClient.cInt16(Mathf.Clamp(PlayerPrefs.GetInt("channel", 0), 0, 99)));
					if (134404 - 385537 != -251132)
					{
						this.ryFntdKh35h.OpCustom(42, hashtable, true);
						if (137284 - 335597 != -198312)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x0600A822 RID: 43042 RVA: 0x012D4CE8 File Offset: 0x012D2EE8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onJoinTown()
	{
		Game.mGameStage = 0;
		Game.loadNextLevel();
	}

	// Token: 0x0600A823 RID: 43043 RVA: 0x012D4CF8 File Offset: 0x012D2EF8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x0600A824 RID: 43044 RVA: 0x012D4CFC File Offset: 0x012D2EFC
	internal static bool zUhMsPV7c1KMkl3Oc7QD()
	{
		return true;
	}

	// Token: 0x0600A825 RID: 43045 RVA: 0x012D4D00 File Offset: 0x012D2F00
	internal static bool n8uLMfV7UK7SIcxII40N()
	{
		return false;
	}

	// Token: 0x040095A7 RID: 38311
	private LitePeer ryFntdKh35h;

	// Token: 0x040095A8 RID: 38312
	private PlayerCameraControl wvvntguTBf2;

	// Token: 0x040095A9 RID: 38313
	private float Lp2nta414jv;

	// Token: 0x040095AA RID: 38314
	private Texture hUbnt48oQbj;

	// Token: 0x040095AB RID: 38315
	private int xbWntsdhZQZ;

	// Token: 0x040095AC RID: 38316
	private int Xi4ntHa8tHG;

	// Token: 0x040095AD RID: 38317
	private int O9knt7QGSJ4;

	// Token: 0x02001C1D RID: 7197
	[CompilerGenerated]
	[Serializable]
	internal sealed class $onGameEvent$44405 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600A826 RID: 43046 RVA: 0x012D4D04 File Offset: 0x012D2F04
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $onGameEvent$44405(Hashtable data, M945_MokBug self_)
		{
			if (229624 - 285085 != -55461)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (97096 - 7767 == 89329)
				{
					base..ctor();
					if (286736 - 265587 != 21150)
					{
						this.$data$44412 = data;
						if (51597 - 405516 == -353919)
						{
							this.$self_$44413 = self_;
							if (190001 - 421689 != -231687)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x0600A827 RID: 43047 RVA: 0x012D4DC0 File Offset: 0x012D2FC0
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M945_MokBug.$onGameEvent$44405.$(this.$data$44412, this.$self_$44413);
		}

		// Token: 0x0600A828 RID: 43048 RVA: 0x012D4DD4 File Offset: 0x012D2FD4
		internal static bool Ssx6ndV7TW9IONIW50c7()
		{
			return true;
		}

		// Token: 0x0600A829 RID: 43049 RVA: 0x012D4DD8 File Offset: 0x012D2FD8
		internal static bool n1FrrMV7335vOp72dx8S()
		{
			return false;
		}

		// Token: 0x040095AE RID: 38318
		internal Hashtable $data$44412;

		// Token: 0x040095AF RID: 38319
		internal M945_MokBug $self_$44413;

		// Token: 0x02001C1E RID: 7198
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600A82A RID: 43050 RVA: 0x012D4DDC File Offset: 0x012D2FDC
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Hashtable data, M945_MokBug self_)
			{
				if (93868 - 425051 != -331183)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (169287 - 33648 == 135639)
					{
						base..ctor();
						if (225651 - 589606 != -363954)
						{
							this.$data$44410 = data;
							if (236508 - 287258 != -50749)
							{
								this.$self_$44411 = self_;
								if (292456 - 378182 != -85725)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x0600A82B RID: 43051 RVA: 0x012D4E98 File Offset: 0x012D3098
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (33450 - 30475 != 2976)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_3D9;
					case 2:
						if (Game.mGameState > eGameState.AllHold)
						{
							goto IL_179;
						}
						if (169235 - 54606 != 114629)
						{
							continue;
						}
						Game.sendMissionEvent(9452, 0);
						if (44985 - 582140 != -537155)
						{
							continue;
						}
						goto IL_179;
					default:
						if (167695 - 471892 == -304196)
						{
							continue;
						}
						break;
					}
					if (Game.mGameState > eGameState.AllHold)
					{
						if (266288 - 377096 != -110808)
						{
							continue;
						}
						goto IL_369;
					}
					else
					{
						this.$returnCode$44406 = RuntimeServices.UnboxInt32(this.$data$44410[141]);
						if (107176 - 238580 != -131404)
						{
							continue;
						}
						this.$returnValue$44407 = RuntimeServices.UnboxInt32(this.$data$44410[145]);
						if (10225 - 590601 != -580376)
						{
							continue;
						}
						this.$ownerID$44408 = RuntimeServices.UnboxInt32(this.$data$44410[43]);
						if (281570 - 127983 != 153587)
						{
							continue;
						}
						this.$$switch$8196$44409 = this.$returnCode$44406;
						if (235387 - 21857 == 213531)
						{
							continue;
						}
						if (this.$$switch$8196$44409 == 9451)
						{
							if (296030 - 519940 != -223910)
							{
								continue;
							}
							Debug.Log("On MokBug Dead");
							if (150148 - 363494 == -213345)
							{
								continue;
							}
							this.$self_$44411.Xi4ntHa8tHG = this.$self_$44411.Xi4ntHa8tHG + 1;
							if (58076 - 418540 != -360464)
							{
								continue;
							}
							this.$self_$44411.SendMessage("newGameMessage", "Mission Objective: Stop MokBug:" + this.$self_$44411.Xi4ntHa8tHG + "/3");
							if (146382 - 123723 != 22659)
							{
								continue;
							}
							Chat.SubmitChat("none", "Mission Objective: Stop MokBug:" + this.$self_$44411.Xi4ntHa8tHG + "/3", eChatType.system, eChatMode.system);
							if (171561 - 377367 == -205805)
							{
								continue;
							}
							if (this.$self_$44411.Xi4ntHa8tHG >= 3)
							{
								if (188987 - 7882 != 181105)
								{
									continue;
								}
								break;
							}
						}
						else if (this.$$switch$8196$44409 == 9452)
						{
							if (276635 - 494467 != -217832)
							{
								continue;
							}
							Debug.Log("On Mission Complete");
							if (291108 - 250849 == 40260)
							{
								continue;
							}
						}
						else if (this.$$switch$8196$44409 == 9453)
						{
							if (193530 - 38664 == 154867)
							{
								continue;
							}
							Debug.Log("On Mission Fail");
							if (297976 - 266844 == 31133)
							{
								continue;
							}
							this.$self_$44411.xbWntsdhZQZ = 2;
							if (283953 - 80881 != 203072)
							{
								continue;
							}
						}
					}
					IL_24A:
					this.YieldDefault(1);
					if (55964 - 397012 != -341048)
					{
						continue;
					}
					goto IL_3D9;
					IL_179:
					goto IL_24A;
				}
				return this.Yield(2, new WaitForSeconds((float)6));
				IL_369:
				IL_3D9:
				return false;
			}

			// Token: 0x0600A82C RID: 43052 RVA: 0x012D5290 File Offset: 0x012D3490
			internal static bool afUjvQV7XjYgx3ohi6xM()
			{
				return true;
			}

			// Token: 0x0600A82D RID: 43053 RVA: 0x012D5294 File Offset: 0x012D3494
			internal static bool ktcMkSV7Q8rnmqMNHPCa()
			{
				return false;
			}

			// Token: 0x040095B0 RID: 38320
			internal int $returnCode$44406;

			// Token: 0x040095B1 RID: 38321
			internal int $returnValue$44407;

			// Token: 0x040095B2 RID: 38322
			internal int $ownerID$44408;

			// Token: 0x040095B3 RID: 38323
			internal int $$switch$8196$44409;

			// Token: 0x040095B4 RID: 38324
			internal Hashtable $data$44410;

			// Token: 0x040095B5 RID: 38325
			internal M945_MokBug $self_$44411;
		}
	}

	// Token: 0x02001C1F RID: 7199
	[CompilerGenerated]
	[Serializable]
	internal sealed class $onGameComplete$44414 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600A82E RID: 43054 RVA: 0x012D5298 File Offset: 0x012D3498
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $onGameComplete$44414(Hashtable data, M945_MokBug self_)
		{
			if (79734 - 29618 != 50117)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (88554 - 218380 == -129826)
				{
					base..ctor();
					if (13652 - 465114 != -451461)
					{
						this.$data$44421 = data;
						if (175343 - 407701 == -232358)
						{
							this.$self_$44422 = self_;
							if (172489 - 13042 == 159447)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x0600A82F RID: 43055 RVA: 0x012D5354 File Offset: 0x012D3554
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M945_MokBug.$onGameComplete$44414.$(this.$data$44421, this.$self_$44422);
		}

		// Token: 0x0600A830 RID: 43056 RVA: 0x012D5368 File Offset: 0x012D3568
		internal static bool zCjeiRV7kdPCc9SMfB7Q()
		{
			return true;
		}

		// Token: 0x0600A831 RID: 43057 RVA: 0x012D536C File Offset: 0x012D356C
		internal static bool QQsX93V7Gf70TXOQd2mD()
		{
			return false;
		}

		// Token: 0x040095B6 RID: 38326
		internal Hashtable $data$44421;

		// Token: 0x040095B7 RID: 38327
		internal M945_MokBug $self_$44422;

		// Token: 0x02001C20 RID: 7200
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600A832 RID: 43058 RVA: 0x012D5370 File Offset: 0x012D3570
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Hashtable data, M945_MokBug self_)
			{
				if (70278 - 157114 != -86836)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (33987 - 538959 != -504971)
					{
						base..ctor();
						if (214338 - 410351 == -196013)
						{
							this.$data$44419 = data;
							if (152499 - 7096 == 145403)
							{
								this.$self_$44420 = self_;
								if (292807 - 249064 != 43744)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x0600A833 RID: 43059 RVA: 0x012D542C File Offset: 0x012D362C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (224594 - 504976 != -280382)
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
						this.$mCompleteGui$44416 = (CompleteGui)this.$self_$44420.GetComponent(typeof(CompleteGui));
						if (30987 - 103752 != -72765)
						{
							continue;
						}
						this.$mCompleteGui$44416.Init();
						if (12703 - 358123 != -345420)
						{
							continue;
						}
						this.$mCompleteGui$44416.readData(this.$data$44419);
						if (214029 - 10891 != 203138)
						{
							continue;
						}
						if (this.$result$44415 == 1)
						{
							if (24875 - 445780 != -420905)
							{
								continue;
							}
							this.$mCompleteGui$44416.displayResult(eCompleteType.Success);
							if (87424 - 334757 != -247333)
							{
								continue;
							}
						}
						else
						{
							this.$mCompleteGui$44416.displayResult(eCompleteType.Failed);
							if (8260 - 369750 != -361490)
							{
								continue;
							}
						}
						this.$mGameGui$44417 = (GameGui)this.$self_$44420.GetComponent(typeof(GameGui));
						if (253466 - 440115 != -186649)
						{
							continue;
						}
						this.$mStoryGui$44418 = (StoryGui)this.$self_$44420.GetComponent(typeof(StoryGui));
						if (14546 - 300019 == -285472)
						{
							continue;
						}
						if (this.$mGameGui$44417)
						{
							if (120924 - 91942 == 28983)
							{
								continue;
							}
							this.$mGameGui$44417.close();
							if (244008 - 123195 != 120813)
							{
								continue;
							}
						}
						if (this.$mStoryGui$44418)
						{
							if (208288 - 383478 != -175190)
							{
								continue;
							}
							this.$mStoryGui$44418.close();
							if (62746 - 254499 == -191752)
							{
								continue;
							}
						}
						this.YieldDefault(1);
						if (243814 - 444576 != -200761)
						{
							goto IL_352;
						}
						continue;
					default:
						if (278551 - 261685 == 16867)
						{
							continue;
						}
						break;
					}
					Debug.Log("On Mission Complete:" + this.$data$44419[31]);
					if (145369 - 7128 != 138242)
					{
						if (Game.mGameState > eGameState.AllHold)
						{
							if (291887 - 525169 != -233281)
							{
								goto Block_12;
							}
						}
						else
						{
							Game.mGameState = eGameState.Complete;
							if (65689 - 224155 == -158466)
							{
								this.$result$44415 = RuntimeServices.UnboxInt32(this.$data$44419[31]);
								if (273028 - 378842 != -105813)
								{
									break;
								}
							}
						}
					}
				}
				return this.Yield(2, new WaitForSeconds(1f));
				Block_12:
				IL_352:
				return false;
			}

			// Token: 0x0600A834 RID: 43060 RVA: 0x012D57A0 File Offset: 0x012D39A0
			internal static bool twOx1HV7Ho31jqp5jaGA()
			{
				return true;
			}

			// Token: 0x0600A835 RID: 43061 RVA: 0x012D57A4 File Offset: 0x012D39A4
			internal static bool rny7bRV7WNb5KmGvNErn()
			{
				return false;
			}

			// Token: 0x040095B8 RID: 38328
			internal int $result$44415;

			// Token: 0x040095B9 RID: 38329
			internal CompleteGui $mCompleteGui$44416;

			// Token: 0x040095BA RID: 38330
			internal GameGui $mGameGui$44417;

			// Token: 0x040095BB RID: 38331
			internal StoryGui $mStoryGui$44418;

			// Token: 0x040095BC RID: 38332
			internal Hashtable $data$44419;

			// Token: 0x040095BD RID: 38333
			internal M945_MokBug $self_$44420;
		}
	}

	// Token: 0x02001C21 RID: 7201
	[CompilerGenerated]
	[Serializable]
	internal sealed class $StartGame$44423 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600A836 RID: 43062 RVA: 0x012D57A8 File Offset: 0x012D39A8
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $StartGame$44423(M945_MokBug self_)
		{
			if (65441 - 70404 != -4963)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (27717 - 372078 != -344360)
				{
					base..ctor();
					if (255452 - 584008 == -328556)
					{
						this.$self_$44428 = self_;
						if (85889 - 270437 != -184547)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x0600A837 RID: 43063 RVA: 0x012D5840 File Offset: 0x012D3A40
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M945_MokBug.$StartGame$44423.$(this.$self_$44428);
		}

		// Token: 0x0600A838 RID: 43064 RVA: 0x012D5850 File Offset: 0x012D3A50
		internal static bool FLu6qyV7AUcwSlbAhuOy()
		{
			return true;
		}

		// Token: 0x0600A839 RID: 43065 RVA: 0x012D5854 File Offset: 0x012D3A54
		internal static bool HnXN1OV7lvfB13epZoJo()
		{
			return false;
		}

		// Token: 0x040095BE RID: 38334
		internal M945_MokBug $self_$44428;

		// Token: 0x02001C22 RID: 7202
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600A83A RID: 43066 RVA: 0x012D5858 File Offset: 0x012D3A58
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M945_MokBug self_)
			{
				if (36653 - 40831 != -4177)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (277605 - 474416 != -196810)
					{
						base..ctor();
						if (114945 - 340649 == -225704)
						{
							this.$self_$44427 = self_;
							if (90856 - 368405 != -277548)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x0600A83B RID: 43067 RVA: 0x012D58F0 File Offset: 0x012D3AF0
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (164889 - 476179 != -311290)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_31F;
					case 2:
						this.$mStartCamera$44426 = GameObject.Find("StartCamera" + Game.getPlayerSlot(PlayerData.UID));
						if (208189 - 465940 == -257750)
						{
							continue;
						}
						if (!this.$mStartCamera$44426)
						{
							goto IL_13E;
						}
						if (66200 - 425814 != -359614)
						{
							continue;
						}
						this.$self_$44427.wvvntguTBf2.setSpecialTarget(this.$mStartCamera$44426, 3f);
						if (129448 - 438631 != -309182)
						{
							goto Block_7;
						}
						continue;
					case 3:
						Game.mGameState = eGameState.Normal;
						if (117406 - 433676 == -316269)
						{
							continue;
						}
						Game.mStateTime = Time.time;
						if (106211 - 153552 == -47340)
						{
							continue;
						}
						this.$self_$44427.wvvntguTBf2.specialTarget = null;
						if (16204 - 165736 != -149532)
						{
							continue;
						}
						this.$self_$44427.wvvntguTBf2.enabled = true;
						if (130021 - 591174 == -461152)
						{
							continue;
						}
						this.YieldDefault(1);
						if (173384 - 228982 != -55597)
						{
							goto Block_8;
						}
						continue;
					default:
						if (11447 - 79310 != -67863)
						{
							continue;
						}
						break;
					}
					Debug.Log("Start Game");
					if (99957 - 281727 == -181770)
					{
						Game.mGameState = eGameState.Start;
						if (201005 - 373152 == -172147)
						{
							Game.mStateTime = Time.time;
							if (127884 - 580733 != -452848)
							{
								Time.timeScale = 1f;
								if (64600 - 217526 == -152926)
								{
									this.$mGameGui$44424 = (GameGui)this.$self_$44427.GetComponent(typeof(GameGui));
									if (29276 - 111989 == -82713)
									{
										this.$mGameGui$44424.enabled = true;
										if (94988 - 349751 != -254762)
										{
											this.$mLoadingGui$44425 = (LoadingGui)this.$self_$44427.GetComponent(typeof(LoadingGui));
											if (139236 - 200164 == -60928)
											{
												this.$mLoadingGui$44425.fadeIn();
												if (258789 - 108783 != 150007)
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
				}
				Block_7:
				goto IL_13E;
				Block_8:
				goto IL_31F;
				IL_13E:
				return this.Yield(3, new WaitForSeconds(2f));
				Block_17:
				return this.Yield(2, new WaitForSeconds(1f));
				IL_31F:
				return false;
			}

			// Token: 0x0600A83C RID: 43068 RVA: 0x012D5C30 File Offset: 0x012D3E30
			internal static bool JXOQWRV7yQBvKFMN9fhA()
			{
				return true;
			}

			// Token: 0x0600A83D RID: 43069 RVA: 0x012D5C34 File Offset: 0x012D3E34
			internal static bool CXdAW3V7SgTvWRnvkjFu()
			{
				return false;
			}

			// Token: 0x040095BF RID: 38335
			internal GameGui $mGameGui$44424;

			// Token: 0x040095C0 RID: 38336
			internal LoadingGui $mLoadingGui$44425;

			// Token: 0x040095C1 RID: 38337
			internal GameObject $mStartCamera$44426;

			// Token: 0x040095C2 RID: 38338
			internal M945_MokBug $self_$44427;
		}
	}

	// Token: 0x02001C23 RID: 7203
	[CompilerGenerated]
	[Serializable]
	internal sealed class $onDeadPlayer$44429 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600A83E RID: 43070 RVA: 0x012D5C38 File Offset: 0x012D3E38
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $onDeadPlayer$44429(M945_MokBug self_)
		{
			if (51296 - 118631 != -67334)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (279219 - 552174 != -272954)
				{
					base..ctor();
					if (146981 - 415204 != -268222)
					{
						this.$self_$44434 = self_;
						if (151384 - 356492 == -205108)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x0600A83F RID: 43071 RVA: 0x012D5CD0 File Offset: 0x012D3ED0
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M945_MokBug.$onDeadPlayer$44429.$(this.$self_$44434);
		}

		// Token: 0x0600A840 RID: 43072 RVA: 0x012D5CE0 File Offset: 0x012D3EE0
		internal static bool M8x2h0V7oylY0gYFM6EX()
		{
			return true;
		}

		// Token: 0x0600A841 RID: 43073 RVA: 0x012D5CE4 File Offset: 0x012D3EE4
		internal static bool EABrUwV7EZ9VPCJqxc9N()
		{
			return false;
		}

		// Token: 0x040095C3 RID: 38339
		internal M945_MokBug $self_$44434;

		// Token: 0x02001C24 RID: 7204
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600A842 RID: 43074 RVA: 0x012D5CE8 File Offset: 0x012D3EE8
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M945_MokBug self_)
			{
				if (46603 - 553771 != -507168)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (216006 - 437547 != -221540)
					{
						base..ctor();
						if (70637 - 72699 != -2061)
						{
							this.$self_$44433 = self_;
							if (159020 - 329529 == -170509)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x0600A843 RID: 43075 RVA: 0x012D5D80 File Offset: 0x012D3F80
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (215507 - 6735 != 208773)
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
							if (81707 - 195030 == -113322)
							{
								continue;
							}
							if (Game.mGameState != eGameState.Hold)
							{
								goto IL_2B3;
							}
							if (100992 - 510206 != -409214)
							{
								continue;
							}
						}
						Game.mGameState = eGameState.Hold;
						if (11405 - 110623 == -99217)
						{
							continue;
						}
						this.$mStoryGui$44430 = (StoryGui)this.$self_$44433.GetComponent(typeof(StoryGui));
						if (182645 - 184867 == -2221)
						{
							continue;
						}
						if (this.$mStoryGui$44430)
						{
							if (276215 - 403752 != -127537)
							{
								continue;
							}
							this.$mStoryGui$44430.close();
							if (21112 - 208500 != -187388)
							{
								continue;
							}
						}
						this.$mChangeGui$44431 = (ChangeGui)this.$self_$44433.GetComponent(typeof(ChangeGui));
						if (274587 - 509088 != -234501)
						{
							continue;
						}
						if (this.$mChangeGui$44431)
						{
							if (223741 - 491290 == -267548)
							{
								continue;
							}
							this.$mChangeGui$44431.close();
							if (157644 - 189223 != -31579)
							{
								continue;
							}
						}
						this.$mGameGui$44432 = (GameGui)this.$self_$44433.GetComponent(typeof(GameGui));
						if (76246 - 548308 == -472061)
						{
							continue;
						}
						if (this.$mGameGui$44432)
						{
							if (299058 - 144555 == 154504)
							{
								continue;
							}
							if (!this.$mGameGui$44432.enabled)
							{
								if (46205 - 170785 == -124579)
								{
									continue;
								}
								this.$mGameGui$44432.enabled = true;
								if (195857 - 556376 == -360518)
								{
									continue;
								}
							}
							this.$mGameGui$44432.openDeadMenu();
							if (151438 - 94159 == 57280)
							{
								continue;
							}
						}
						IL_2B3:
						this.YieldDefault(1);
						if (180808 - 474276 != -293468)
						{
							continue;
						}
						goto IL_2F9;
					default:
						if (195489 - 77949 == 117541)
						{
							continue;
						}
						break;
					}
					Debug.Log("On Dead Player");
				}
				while (144495 - 205622 != -61127);
				return this.Yield(2, new WaitForSeconds((float)2));
				IL_2F9:
				return false;
			}

			// Token: 0x0600A844 RID: 43076 RVA: 0x012D6098 File Offset: 0x012D4298
			internal static bool twnDNUV72tWoBmMGMGua()
			{
				return true;
			}

			// Token: 0x0600A845 RID: 43077 RVA: 0x012D609C File Offset: 0x012D429C
			internal static bool OEvYdJV784UgYCQyf1Z5()
			{
				return false;
			}

			// Token: 0x040095C4 RID: 38340
			internal StoryGui $mStoryGui$44430;

			// Token: 0x040095C5 RID: 38341
			internal ChangeGui $mChangeGui$44431;

			// Token: 0x040095C6 RID: 38342
			internal GameGui $mGameGui$44432;

			// Token: 0x040095C7 RID: 38343
			internal M945_MokBug $self_$44433;
		}
	}

	// Token: 0x02001C25 RID: 7205
	[CompilerGenerated]
	[Serializable]
	internal sealed class $ReturnToTown$44435 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600A846 RID: 43078 RVA: 0x012D60A0 File Offset: 0x012D42A0
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $ReturnToTown$44435(M945_MokBug self_)
		{
			if (172148 - 35801 != 136347)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (112955 - 453316 == -340361)
				{
					base..ctor();
					if (124237 - 55897 == 68340)
					{
						this.$self_$44439 = self_;
						if (32248 - 187955 == -155707)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x0600A847 RID: 43079 RVA: 0x012D6138 File Offset: 0x012D4338
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M945_MokBug.$ReturnToTown$44435.$(this.$self_$44439);
		}

		// Token: 0x0600A848 RID: 43080 RVA: 0x012D6148 File Offset: 0x012D4348
		internal static bool fDNbMhV7ZkCJIccW11ZO()
		{
			return true;
		}

		// Token: 0x0600A849 RID: 43081 RVA: 0x012D614C File Offset: 0x012D434C
		internal static bool KYpBdgV7CpFIqgKicDfL()
		{
			return false;
		}

		// Token: 0x040095C8 RID: 38344
		internal M945_MokBug $self_$44439;

		// Token: 0x02001C26 RID: 7206
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600A84A RID: 43082 RVA: 0x012D6150 File Offset: 0x012D4350
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M945_MokBug self_)
			{
				if (274918 - 336980 != -62062)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (16413 - 82541 != -66127)
					{
						base..ctor();
						if (80001 - 167436 == -87435)
						{
							this.$self_$44438 = self_;
							if (295492 - 365913 == -70421)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x0600A84B RID: 43083 RVA: 0x012D61E8 File Offset: 0x012D43E8
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (138338 - 467993 != -329655)
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
						this.$self_$44438.LeaveGame();
						if (58527 - 122011 == -63483)
						{
							continue;
						}
						this.YieldDefault(1);
						if (47179 - 344244 != -297064)
						{
							goto Block_29;
						}
						continue;
					default:
						if (23751 - 18477 == 5275)
						{
							continue;
						}
						break;
					}
					Game.mGameState = eGameState.Ended;
					if (58684 - 5290 == 53394)
					{
						Game.mStateTime = Time.time;
						if (147140 - 488798 != -341657)
						{
							this.$$switch$8200$44436 = PlayerData.SaveGuild;
							if (74718 - 135707 == -60989)
							{
								if (this.$$switch$8200$44436 == 1)
								{
									if (239781 - 540432 != -300651)
									{
										continue;
									}
									Game.mNextGameCode = 32;
									if (42561 - 33305 != 9256)
									{
										continue;
									}
								}
								else if (this.$$switch$8200$44436 == 2)
								{
									if (7379 - 408461 == -401081)
									{
										continue;
									}
									Game.mNextGameCode = 33;
									if (140638 - 74811 == 65828)
									{
										continue;
									}
								}
								else if (this.$$switch$8200$44436 == 3)
								{
									if (298203 - 339059 != -40856)
									{
										continue;
									}
									Game.mNextGameCode = 34;
									if (176607 - 500563 != -323956)
									{
										continue;
									}
								}
								else if (this.$$switch$8200$44436 == 4)
								{
									if (147368 - 183772 == -36403)
									{
										continue;
									}
									Game.mNextGameCode = 35;
									if (219145 - 486421 == -267275)
									{
										continue;
									}
								}
								else if (this.$$switch$8200$44436 == 5)
								{
									if (109873 - 560933 != -451060)
									{
										continue;
									}
									Game.mNextGameCode = 36;
									if (105128 - 54379 == 50750)
									{
										continue;
									}
								}
								else if (PlayerData.GID == 0)
								{
									if (250346 - 77491 == 172856)
									{
										continue;
									}
									Game.mNextGameCode = 30;
									if (67523 - 538716 != -471193)
									{
										continue;
									}
								}
								else
								{
									Game.mNextGameCode = 31;
									if (236863 - 17762 == 219102)
									{
										continue;
									}
								}
								this.$mGameGui$44437 = (GameGui)this.$self_$44438.GetComponent(typeof(GameGui));
								if (170950 - 392847 != -221896)
								{
									if (this.$mGameGui$44437)
									{
										if (123041 - 593437 == -470395)
										{
											continue;
										}
										this.$mGameGui$44437.close();
										if (2009 - 372399 != -370390)
										{
											continue;
										}
									}
									this.$self_$44438.SendMessage("fadeOut");
									if (19201 - 391339 == -372138)
									{
										break;
									}
								}
							}
						}
					}
				}
				return this.Yield(2, new WaitForSeconds((float)1));
				Block_29:
				IL_3AD:
				return false;
			}

			// Token: 0x0600A84C RID: 43084 RVA: 0x012D65B4 File Offset: 0x012D47B4
			internal static bool NOBI1tV7LZ2A82sRiUM4()
			{
				return true;
			}

			// Token: 0x0600A84D RID: 43085 RVA: 0x012D65B8 File Offset: 0x012D47B8
			internal static bool qy9ICNV7OVbKII5KHILE()
			{
				return false;
			}

			// Token: 0x040095C9 RID: 38345
			internal int $$switch$8200$44436;

			// Token: 0x040095CA RID: 38346
			internal GameGui $mGameGui$44437;

			// Token: 0x040095CB RID: 38347
			internal M945_MokBug $self_$44438;
		}
	}

	// Token: 0x02001C27 RID: 7207
	[CompilerGenerated]
	[Serializable]
	internal sealed class $ReturnToGuild$44440 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600A84E RID: 43086 RVA: 0x012D65BC File Offset: 0x012D47BC
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $ReturnToGuild$44440(M945_MokBug self_)
		{
			if (27653 - 241437 != -213784)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (55078 - 565177 != -510098)
				{
					base..ctor();
					if (85193 - 359380 == -274187)
					{
						this.$self_$44443 = self_;
						if (280993 - 113816 != 167178)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x0600A84F RID: 43087 RVA: 0x012D6654 File Offset: 0x012D4854
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M945_MokBug.$ReturnToGuild$44440.$(this.$self_$44443);
		}

		// Token: 0x0600A850 RID: 43088 RVA: 0x012D6664 File Offset: 0x012D4864
		internal static bool eBnOQIV7mGBMsQXT7auj()
		{
			return true;
		}

		// Token: 0x0600A851 RID: 43089 RVA: 0x012D6668 File Offset: 0x012D4868
		internal static bool W7Ghc2V7FuiK8hBMOZak()
		{
			return false;
		}

		// Token: 0x040095CC RID: 38348
		internal M945_MokBug $self_$44443;

		// Token: 0x02001C28 RID: 7208
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600A852 RID: 43090 RVA: 0x012D666C File Offset: 0x012D486C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M945_MokBug self_)
			{
				if (51834 - 298579 != -246744)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (22337 - 534340 == -512003)
					{
						base..ctor();
						if (157521 - 546044 == -388523)
						{
							this.$self_$44442 = self_;
							if (18386 - 490792 == -472406)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x0600A853 RID: 43091 RVA: 0x012D6704 File Offset: 0x012D4904
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (37780 - 181759 != -143979)
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
						this.$self_$44442.LeaveGame();
						if (202214 - 194841 == 7374)
						{
							continue;
						}
						this.YieldDefault(1);
						if (214265 - 244021 != -29756)
						{
							continue;
						}
						goto IL_1BD;
					default:
						if (197512 - 233119 == -35606)
						{
							continue;
						}
						break;
					}
					Game.mGameState = eGameState.Ended;
					if (26255 - 535452 != -509196)
					{
						Game.mStateTime = Time.time;
						if (2690 - 95127 != -92436)
						{
							Game.mNextGameCode = 31;
							if (14271 - 187795 != -173523)
							{
								this.$mGameGui$44441 = (GameGui)this.$self_$44442.GetComponent(typeof(GameGui));
								if (191262 - 456387 == -265125)
								{
									if (this.$mGameGui$44441)
									{
										if (278500 - 528119 != -249619)
										{
											continue;
										}
										this.$mGameGui$44441.close();
										if (291376 - 111946 != 179430)
										{
											continue;
										}
									}
									this.$self_$44442.SendMessage("fadeOut");
									if (288725 - 109722 != 179004)
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

			// Token: 0x0600A854 RID: 43092 RVA: 0x012D68E0 File Offset: 0x012D4AE0
			internal static bool pRbfcdV7MM0IlrEKw7Eb()
			{
				return true;
			}

			// Token: 0x0600A855 RID: 43093 RVA: 0x012D68E4 File Offset: 0x012D4AE4
			internal static bool KPg5t6V7xq4mT3woMAfq()
			{
				return false;
			}

			// Token: 0x040095CD RID: 38349
			internal GameGui $mGameGui$44441;

			// Token: 0x040095CE RID: 38350
			internal M945_MokBug $self_$44442;
		}
	}

	// Token: 0x02001C29 RID: 7209
	[CompilerGenerated]
	[Serializable]
	internal sealed class $ReturnToCamp$44444 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600A856 RID: 43094 RVA: 0x012D68E8 File Offset: 0x012D4AE8
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $ReturnToCamp$44444(M945_MokBug self_)
		{
			if (299306 - 530562 != -231255)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (80749 - 599033 != -518283)
				{
					base..ctor();
					if (180546 - 373423 == -192877)
					{
						this.$self_$44448 = self_;
						if (287126 - 547497 == -260371)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x0600A857 RID: 43095 RVA: 0x012D6980 File Offset: 0x012D4B80
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M945_MokBug.$ReturnToCamp$44444.$(this.$self_$44448);
		}

		// Token: 0x0600A858 RID: 43096 RVA: 0x012D6990 File Offset: 0x012D4B90
		internal static bool QkiIZIV7gTKUyIy5YIEm()
		{
			return true;
		}

		// Token: 0x0600A859 RID: 43097 RVA: 0x012D6994 File Offset: 0x012D4B94
		internal static bool N2DhpZV7fDC0L0oYySw6()
		{
			return false;
		}

		// Token: 0x040095CF RID: 38351
		internal M945_MokBug $self_$44448;

		// Token: 0x02001C2A RID: 7210
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600A85A RID: 43098 RVA: 0x012D6998 File Offset: 0x012D4B98
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M945_MokBug self_)
			{
				if (185843 - 153014 != 32829)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (86044 - 241153 == -155109)
					{
						base..ctor();
						if (283580 - 519697 != -236116)
						{
							this.$self_$44447 = self_;
							if (293304 - 529978 == -236674)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x0600A85B RID: 43099 RVA: 0x012D6A30 File Offset: 0x012D4C30
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (285993 - 307810 != -21816)
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
						this.$self_$44447.LeaveGame();
						if (206895 - 470382 == -263486)
						{
							continue;
						}
						this.YieldDefault(1);
						if (176528 - 151687 != 24841)
						{
							continue;
						}
						goto IL_363;
					default:
						if (241485 - 210468 == 31018)
						{
							continue;
						}
						break;
					}
					Game.mGameState = eGameState.Ended;
					if (284039 - 427142 != -143102)
					{
						Game.mStateTime = Time.time;
						if (6368 - 593198 == -586830)
						{
							this.$$switch$8202$44445 = PlayerData.SaveGuild;
							if (217528 - 461943 == -244415)
							{
								if (this.$$switch$8202$44445 == 1)
								{
									if (51254 - 253999 != -202745)
									{
										continue;
									}
									Game.mNextGameCode = 32;
									if (129656 - 378622 == -248965)
									{
										continue;
									}
								}
								else if (this.$$switch$8202$44445 == 2)
								{
									if (70850 - 180300 == -109449)
									{
										continue;
									}
									Game.mNextGameCode = 33;
									if (186417 - 36473 != 149944)
									{
										continue;
									}
								}
								else if (this.$$switch$8202$44445 == 3)
								{
									if (36525 - 61850 == -25324)
									{
										continue;
									}
									Game.mNextGameCode = 34;
									if (22859 - 199693 == -176833)
									{
										continue;
									}
								}
								else if (this.$$switch$8202$44445 == 4)
								{
									if (74032 - 76270 == -2237)
									{
										continue;
									}
									Game.mNextGameCode = 35;
									if (239652 - 354702 != -115050)
									{
										continue;
									}
								}
								else if (this.$$switch$8202$44445 == 5)
								{
									if (99728 - 374333 != -274605)
									{
										continue;
									}
									Game.mNextGameCode = 36;
									if (13019 - 334631 != -321612)
									{
										continue;
									}
								}
								else
								{
									Game.mNextGameCode = 30;
									if (113743 - 324154 != -210411)
									{
										continue;
									}
								}
								this.$mGameGui$44446 = (GameGui)this.$self_$44447.GetComponent(typeof(GameGui));
								if (3811 - 74970 != -71158)
								{
									if (this.$mGameGui$44446)
									{
										if (133511 - 277296 != -143785)
										{
											continue;
										}
										this.$mGameGui$44446.close();
										if (124522 - 251786 != -127264)
										{
											continue;
										}
									}
									this.$self_$44447.SendMessage("fadeOut");
									if (52344 - 198172 == -145828)
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

			// Token: 0x0600A85C RID: 43100 RVA: 0x012D6DB4 File Offset: 0x012D4FB4
			internal static bool UrABgyV7nd7ok2axM8ZW()
			{
				return true;
			}

			// Token: 0x0600A85D RID: 43101 RVA: 0x012D6DB8 File Offset: 0x012D4FB8
			internal static bool hP0t3HV76tPAOi2hQleY()
			{
				return false;
			}

			// Token: 0x040095D0 RID: 38352
			internal int $$switch$8202$44445;

			// Token: 0x040095D1 RID: 38353
			internal GameGui $mGameGui$44446;

			// Token: 0x040095D2 RID: 38354
			internal M945_MokBug $self_$44447;
		}
	}
}
