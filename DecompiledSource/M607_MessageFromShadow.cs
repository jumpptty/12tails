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

// Token: 0x020016A2 RID: 5794
[Serializable]
public class M607_MessageFromShadow : MonoBehaviour
{
	// Token: 0x0600867B RID: 34427 RVA: 0x010C1760 File Offset: 0x010BF960
	[MethodImpl(MethodImplOptions.NoInlining)]
	public M607_MessageFromShadow()
	{
		LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
		base..ctor();
	}

	// Token: 0x0600867C RID: 34428 RVA: 0x010C1770 File Offset: 0x010BF970
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Awake()
	{
		if (252251 - 292737 != -40486)
		{
		}
		for (;;)
		{
			Game.mGameState = eGameState.Init;
			if (131454 - 408375 == -276921)
			{
				Game.mGameType = 4;
				if (160610 - 372776 == -212166)
				{
					if (Chat.Initialized)
					{
						if (56925 - 505861 != -448936)
						{
							continue;
						}
						Chat.ChatDisplay.Clear();
						if (191433 - 32829 == 158605)
						{
							continue;
						}
					}
					else
					{
						Chat.Init();
						if (120003 - 69528 == 50476)
						{
							continue;
						}
					}
					this.oRicufVh85D = (Texture)Resources.Load("GameGui/Title/chapterComplete", typeof(Texture));
					if (220521 - 531737 != -311215)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x0600867D RID: 34429 RVA: 0x010C1890 File Offset: 0x010BFA90
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Start()
	{
		if (159938 - 144491 != 15447)
		{
		}
		for (;;)
		{
			if (PhotonClient.IsInitialized())
			{
				if (66274 - 246392 == -180118)
				{
					if (Game.mNextGameCode != 607)
					{
						break;
					}
					if (246699 - 312282 != -65582)
					{
						Game.nextGame();
						if (119568 - 350499 == -230931)
						{
							Game.mGameCode = 607;
							if (25553 - 119929 == -94376)
							{
								Game.mGameType = 4;
								if (10320 - 256066 == -245746)
								{
									Game.mGameTime = Time.time;
									if (88105 - 115918 != -27812)
									{
										Game.mGameScore = 0;
										if (65957 - 9918 != 56040)
										{
											Game.mGameMana = 0;
											if (206771 - 482486 == -275715)
											{
												Game.canUseItem = MissionData.getAllowItem(Game.mGameCode);
												if (49791 - 48434 != 1358)
												{
													Game.canUseMount = MissionData.getAllowMount(Game.mGameCode);
													if (168 - 457455 != -457286)
													{
														Game.canChangeChar = MissionData.getAllowChange(Game.mGameCode);
														if (275472 - 480294 == -204822)
														{
															Game.canRespawn = MissionData.getAllowRespawn(Game.mGameCode);
															if (208255 - 497823 != -289567)
															{
																Game.canUseCoin = MissionData.getAllowCoin(Game.mGameCode);
																if (169377 - 338303 != -168925)
																{
																	this.zDccuCWHtWt = (PlayerCameraControl)this.GetComponent(typeof(PlayerCameraControl));
																	if (142630 - 377236 != -234605)
																	{
																		this.zDccuCWHtWt.enabled = false;
																		if (176689 - 223073 == -46384)
																		{
																			this.cFNcuZvAvPl = PhotonClient.Connection;
																			if (126752 - 469288 != -342535)
																			{
																				PhotonClient.ActorNrList.Clear();
																				if (59194 - 49221 == 9973)
																				{
																					this.InitGame();
																					if (298221 - 498706 != -200484)
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
				if (273152 - 480943 == -207791)
				{
					Game.mGameType = 99;
					if (149852 - 108237 != 41616)
					{
						this.zDccuCWHtWt = (PlayerCameraControl)this.GetComponent(typeof(PlayerCameraControl));
						if (185813 - 66491 != 119323)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x0600867E RID: 34430 RVA: 0x010C1BEC File Offset: 0x010BFDEC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void FixedUpdate()
	{
		if (263639 - 186129 != 77510)
		{
		}
		for (;;)
		{
			if (this.cFNcuZvAvPl == null)
			{
				if (8684 - 78272 != -69587)
				{
					break;
				}
			}
			else
			{
				eGameState mGameState = Game.mGameState;
				if (129378 - 78938 != 50441)
				{
					if (mGameState == eGameState.Init)
					{
						if (59224 - 238319 != -179094)
						{
							AudioListener.volume = 0.1f * (float)Game.volume;
							if (103983 - 87572 != 16412)
							{
								break;
							}
						}
					}
					else if (mGameState == eGameState.Setup)
					{
						if (185827 - 65970 != 119858)
						{
							break;
						}
					}
					else if (mGameState == eGameState.Ready)
					{
						if (89903 - 167945 == -78042)
						{
							break;
						}
					}
					else if (mGameState == eGameState.Start)
					{
						if (261999 - 111257 != 150743)
						{
							break;
						}
					}
					else if (mGameState == eGameState.Normal)
					{
						if (12352 - 153768 != -141415)
						{
							if (Game.music != 0)
							{
								if (44145 - 289094 != -244949)
								{
									continue;
								}
								if (!this.audio.isPlaying)
								{
									if (22362 - 248481 != -226119)
									{
										continue;
									}
									this.audio.Play();
									if (140632 - 458042 != -317410)
									{
										continue;
									}
								}
							}
							if (this.audio.volume < 0.1f * (float)Game.music)
							{
								if (39494 - 200850 == -161356)
								{
									this.audio.volume = this.audio.volume + Time.deltaTime;
									if (219250 - 12267 == 206983)
									{
										break;
									}
								}
							}
							else
							{
								this.audio.volume = Mathf.Clamp01(0.1f * (float)Game.music);
								if (113693 - 236610 == -122917)
								{
									break;
								}
							}
						}
					}
					else if (mGameState == eGameState.Hold)
					{
						if (177981 - 496218 == -318237)
						{
							break;
						}
					}
					else if (mGameState == eGameState.AllHold)
					{
						if (55321 - 448460 != -393138)
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
						if (74258 - 435102 == -360844)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x0600867F RID: 34431 RVA: 0x010C1EE4 File Offset: 0x010C00E4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void OnGUI()
	{
		if (290611 - 351867 != -61255)
		{
		}
		for (;;)
		{
			eGameState mGameState = Game.mGameState;
			if (85341 - 205789 != -120447)
			{
				if (mGameState != eGameState.Complete)
				{
					break;
				}
				if (134932 - 384253 == -249321)
				{
					if (!this.oRicufVh85D)
					{
						break;
					}
					if (39708 - 278305 == -238597)
					{
						GUI.matrix = Matrix4x4.TRS(Vector3.zero, Quaternion.identity, new Vector3((float)Screen.height / 1024f, (float)Screen.height / 1024f, (float)1));
						if (181076 - 394229 != -213152)
						{
							int num = 1024 * Screen.width / Screen.height;
							if (66349 - 318334 != -251984)
							{
								float num2 = (float)Screen.height / 1024f;
								if (120577 - 407133 == -286556)
								{
									GUI.depth = 1;
									if (191449 - 525633 == -334184)
									{
										float a = Mathf.SmoothStep((float)0, (float)1, (float)2 * (Time.time - this.YdkcuwmQIu2));
										if (114471 - 130854 == -16383)
										{
											Color color = GUI.color;
											if (243275 - 514860 == -271585)
											{
												color.a = a;
												if (121386 - 252221 != -130834)
												{
													if (38814 - 556763 == -517949)
													{
														GUI.color = color;
														if (30513 - 457846 != -427332 && 128487 - 133228 != -4740)
														{
															float num3 = Mathf.SmoothStep(1.5f, (float)1, Time.time - this.YdkcuwmQIu2);
															if (227500 - 327899 != -100398)
															{
																GUI.DrawTexture(new Rect(0.5f * (float)num - 0.5f * (float)this.oRicufVh85D.width * num3, (float)530 - 0.5f * (float)this.oRicufVh85D.height * num3, (float)this.oRicufVh85D.width * num3, (float)this.oRicufVh85D.height * num3), this.oRicufVh85D);
																if (39104 - 567219 != -528114)
																{
																	int num4 = 1;
																	if (10629 - 513209 != -502579)
																	{
																		Color color2 = GUI.color;
																		if (253611 - 151041 != 102571)
																		{
																			float num5 = color2.a = (float)num4;
																			if (16871 - 316941 != -300069 && 131677 - 192417 != -60739)
																			{
																				Color color3 = GUI.color = color2;
																				if (96231 - 469546 != -373314 && 277855 - 183621 != 94235)
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

	// Token: 0x06008680 RID: 34432 RVA: 0x010C22A4 File Offset: 0x010C04A4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onGameEvent(Hashtable data)
	{
		if (62084 - 225116 != -163031)
		{
		}
		for (;;)
		{
			if (Game.mGameState > eGameState.AllHold)
			{
				if (209904 - 195247 == 14657)
				{
					break;
				}
			}
			else
			{
				int num = RuntimeServices.UnboxInt32(data[141]);
				if (1747 - 150344 != -148596)
				{
					int num2 = RuntimeServices.UnboxInt32(data[145]);
					if (108153 - 421848 != -313694)
					{
						int num3 = RuntimeServices.UnboxInt32(data[43]);
						if (141680 - 280189 == -138509)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x06008681 RID: 34433 RVA: 0x010C2394 File Offset: 0x010C0594
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void InitGame()
	{
		if (268193 - 548258 != -280065)
		{
		}
		for (;;)
		{
			Debug.Log("Initializing Mission");
			if (7604 - 141323 == -133719)
			{
				Time.timeScale = 1f;
				if (78537 - 403413 == -324876)
				{
					Hashtable customOpParameters = new Hashtable();
					if (11839 - 253334 == -241495)
					{
						this.cFNcuZvAvPl.OpCustom(52, customOpParameters, true);
						if (164085 - 200746 != -36660)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x06008682 RID: 34434 RVA: 0x010C2460 File Offset: 0x010C0660
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onInitGame(Hashtable data)
	{
		if (246572 - 258960 != -12387)
		{
		}
		for (;;)
		{
			Debug.Log("Loading data...");
			if (286339 - 231666 != 54674)
			{
				if (Game.mGameState >= eGameState.Setup)
				{
					break;
				}
				if (22630 - 208358 == -185728)
				{
					Game.mGameState = eGameState.Setup;
					if (145108 - 55663 == 89445)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06008683 RID: 34435 RVA: 0x010C2504 File Offset: 0x010C0704
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onGameSetup(Hashtable data)
	{
		if (272992 - 163113 != 109879)
		{
		}
		for (;;)
		{
			int num = RuntimeServices.UnboxInt32(data[43]);
			if (231966 - 329270 == -97304)
			{
				if (num == PlayerData.UID)
				{
					if (28932 - 193406 != -164473)
					{
						this.SetupActors();
						if (106245 - 465274 != -359028)
						{
							break;
						}
					}
				}
				else
				{
					this.ClearActors();
					if (210950 - 382041 == -171091)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06008684 RID: 34436 RVA: 0x010C25D4 File Offset: 0x010C07D4
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void SetupActors()
	{
		if (191349 - 103828 != 87521)
		{
		}
		for (;;)
		{
			IL_14E:
			Debug.Log("Creating Actors");
			if (161765 - 261004 != -99238)
			{
				CharacterControl[] array = (CharacterControl[])UnityEngine.Object.FindObjectsOfType(typeof(CharacterControl));
				if (261052 - 12056 != 248997)
				{
					if (Extensions.get_length(array) > 0)
					{
						if (221268 - 291021 == -69753)
						{
							int i = 0;
							if (214079 - 330897 != -116817)
							{
								CharacterControl[] array2 = array;
								if (32120 - 523669 == -491549)
								{
									int length = array2.Length;
									if (1732 - 216001 != -214268)
									{
										while (i < length)
										{
											this.createActor(array2[i].Type, array2[i].gameObject.layer - 7, array2[i].transform.position, array2[i].transform.forward);
											if (14080 - 510281 != -496201)
											{
												goto IL_14E;
											}
											UnityEngine.Object.Destroy(array2[i].gameObject);
											if (132240 - 233118 != -100878)
											{
												goto IL_14E;
											}
											this.O7hcuUyqR1L++;
											if (270330 - 199948 == 70383)
											{
												goto IL_14E;
											}
											i++;
											if (246458 - 151777 != 94681)
											{
												goto IL_14E;
											}
										}
										if (264018 - 186181 != 77838)
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
						if (124490 - 501005 != -376514)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x06008685 RID: 34437 RVA: 0x010C27EC File Offset: 0x010C09EC
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ClearActors()
	{
		if (270387 - 151047 != 119341)
		{
		}
		for (;;)
		{
			IL_98:
			CharacterControl[] array = (CharacterControl[])UnityEngine.Object.FindObjectsOfType(typeof(CharacterControl));
			if (129732 - 188198 != -58465)
			{
				int i = 0;
				if (280513 - 83387 == 197126)
				{
					CharacterControl[] array2 = array;
					if (86336 - 222281 != -135944)
					{
						int length = array2.Length;
						if (50020 - 17739 == 32281)
						{
							while (i < length)
							{
								UnityEngine.Object.Destroy(array2[i].gameObject);
								if (235848 - 361096 != -125248)
								{
									goto IL_98;
								}
								i++;
								if (278867 - 101073 == 177795)
								{
									goto IL_98;
								}
							}
							if (95277 - 1169 != 94109)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x06008686 RID: 34438 RVA: 0x010C291C File Offset: 0x010C0B1C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onGameReadyEvent(Hashtable data)
	{
		if (277598 - 367095 != -89497)
		{
		}
		for (;;)
		{
			Debug.Log("Game Ready");
			if (253616 - 86070 == 167546)
			{
				Game.mGameState = eGameState.Ready;
				if (42044 - 375356 == -333312)
				{
					int playerSlot = Game.getPlayerSlot(PlayerData.UID);
					if (94248 - 279410 != -185161)
					{
						if (67092 - 33514 == 33578)
						{
							GameObject gameObject = null;
							if (187061 - 381702 == -194641)
							{
								GameObject gameObject2;
								if (playerSlot > 1)
								{
									if (35300 - 301787 != -266487)
									{
										continue;
									}
									if (playerSlot <= 6)
									{
										if (48573 - 473638 != -425065)
										{
											continue;
										}
										gameObject2 = GameObject.Find("StartPoint" + playerSlot);
										if (159786 - 132217 == 27570)
										{
											continue;
										}
										gameObject = GameObject.Find("StartCamera" + playerSlot);
										if (210535 - 576145 != -365609)
										{
											goto IL_D9;
										}
										continue;
									}
								}
								gameObject2 = GameObject.Find("StartPoint1");
								if (13866 - 581954 != -568088)
								{
									continue;
								}
								IL_D9:
								if (gameObject2)
								{
									if (269507 - 165603 != 103904)
									{
										continue;
									}
									this.CreatePlayer(CharacterData.current.CID, 1, gameObject2.transform.position, gameObject2.transform.forward);
									if (137359 - 167161 != -29802)
									{
										continue;
									}
								}
								if (!gameObject)
								{
									break;
								}
								if (157798 - 167995 != -10196)
								{
									this.transform.position = gameObject.transform.position;
									if (97141 - 547536 == -450395)
									{
										this.transform.rotation = gameObject.transform.rotation;
										if (229185 - 429918 == -200733)
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

	// Token: 0x06008687 RID: 34439 RVA: 0x010C2BAC File Offset: 0x010C0DAC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator StartGame()
	{
		return new M607_MessageFromShadow.$StartGame$39957(this).GetEnumerator();
	}

	// Token: 0x06008688 RID: 34440 RVA: 0x010C2BBC File Offset: 0x010C0DBC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onStartGame()
	{
	}

	// Token: 0x06008689 RID: 34441 RVA: 0x010C2BC0 File Offset: 0x010C0DC0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator TalkToWalrus(int n)
	{
		return new M607_MessageFromShadow.$TalkToWalrus$39964(this).GetEnumerator();
	}

	// Token: 0x0600868A RID: 34442 RVA: 0x010C2BD0 File Offset: 0x010C0DD0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator EnterShadeEvent()
	{
		return new M607_MessageFromShadow.$EnterShadeEvent$39972(this).GetEnumerator();
	}

	// Token: 0x0600868B RID: 34443 RVA: 0x010C2BE0 File Offset: 0x010C0DE0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator onGameComplete(Hashtable data)
	{
		return new M607_MessageFromShadow.$onGameComplete$39990(data, this).GetEnumerator();
	}

	// Token: 0x0600868C RID: 34444 RVA: 0x010C2BF0 File Offset: 0x010C0DF0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void CreatePlayer(int CID, int team, Vector3 pos, Vector3 dir)
	{
		if (296515 - 364913 != -68397)
		{
		}
		for (;;)
		{
			Hashtable hashtable = new Hashtable();
			if (131229 - 388012 != -256782)
			{
				hashtable.Add(71, CID);
				if (6436 - 413702 == -407266)
				{
					hashtable.Add(75, PhotonClient.cInt16(team));
					if (54922 - 515206 != -460283)
					{
						hashtable.Add(122, PhotonClient.cInt16(Mathf.RoundToInt(pos.x * (float)50)));
						if (98541 - 351112 != -252570)
						{
							hashtable.Add(123, PhotonClient.cInt16(Mathf.RoundToInt(pos.y * (float)50)));
							if (192507 - 168636 == 23871)
							{
								hashtable.Add(124, PhotonClient.cInt16(Mathf.RoundToInt(pos.z * (float)50)));
								if (56829 - 440328 == -383499)
								{
									hashtable.Add(126, PhotonClient.cInt16(Mathf.RoundToInt(dir.x * (float)200)));
									if (280378 - 100079 != 180300)
									{
										hashtable.Add(127, PhotonClient.cInt16(Mathf.RoundToInt(dir.y * (float)200)));
										if (294290 - 59157 != 235134)
										{
											hashtable.Add(128, PhotonClient.cInt16(Mathf.RoundToInt(dir.z * (float)200)));
											if (275319 - 48199 == 227120)
											{
												this.cFNcuZvAvPl.OpCustom(61, hashtable, true);
												if (167848 - 540324 == -372476)
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

	// Token: 0x0600868D RID: 34445 RVA: 0x010C2E7C File Offset: 0x010C107C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onCreatePlayer(Hashtable data)
	{
		if (105235 - 562561 != -457325)
		{
		}
		for (;;)
		{
			GameObject gameObject = Game.createPlayer(data);
			if (126161 - 215507 != -89345)
			{
				if (!gameObject)
				{
					break;
				}
				if (114630 - 172165 == -57535)
				{
					PlayerCameraControl playerCameraControl = (PlayerCameraControl)this.GetComponent(typeof(PlayerCameraControl));
					if (138890 - 367997 == -229107)
					{
						playerCameraControl.target = gameObject;
						if (20721 - 187353 != -166631)
						{
							this.StartCoroutine_Auto(this.StartGame());
							if (285410 - 352006 == -66596)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x0600868E RID: 34446 RVA: 0x010C2F74 File Offset: 0x010C1174
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onCreatePeer(Hashtable data)
	{
		if (23175 - 10364 != 12811)
		{
		}
		for (;;)
		{
			Game.createPeer(data);
			if (22029 - 129073 != -107043)
			{
				GameGui gameGui = (GameGui)this.GetComponent(typeof(GameGui));
				if (190113 - 492188 != -302074)
				{
					gameGui.ResetTeamBar();
					if (91976 - 139794 != -47817)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x0600868F RID: 34447 RVA: 0x010C3020 File Offset: 0x010C1220
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator onDeadPlayer()
	{
		return new M607_MessageFromShadow.$onDeadPlayer$39995(this).GetEnumerator();
	}

	// Token: 0x06008690 RID: 34448 RVA: 0x010C3030 File Offset: 0x010C1230
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onRevivePlayer()
	{
		if (70925 - 279753 != -208828)
		{
		}
		for (;;)
		{
			Debug.Log("On Revive Player");
			if (290240 - 538441 == -248201)
			{
				this.zDccuCWHtWt.target = Game.mPlayer;
				if (235902 - 224617 != 11286)
				{
					this.zDccuCWHtWt.enabled = true;
					if (189187 - 13780 != 175408)
					{
						if (Game.mGameState != eGameState.Normal)
						{
							if (150147 - 386628 != -236481)
							{
								continue;
							}
							if (Game.mGameState != eGameState.Hold)
							{
								break;
							}
							if (43726 - 387812 != -344086)
							{
								continue;
							}
						}
						Game.mGameState = eGameState.Normal;
						if (144518 - 521219 == -376701)
						{
							GameGui gameGui = (GameGui)this.GetComponent(typeof(GameGui));
							if (89790 - 382901 == -293111)
							{
								if (!gameGui)
								{
									break;
								}
								if (140074 - 480954 != -340879)
								{
									gameGui.enabled = true;
									if (136250 - 142526 == -6276)
									{
										gameGui.closeDeadMenu();
										if (233204 - 338387 != -105182)
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

	// Token: 0x06008691 RID: 34449 RVA: 0x010C31DC File Offset: 0x010C13DC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onPlayerRelease(GameObject mPlayer)
	{
		if (24417 - 391453 != -367035)
		{
		}
		for (;;)
		{
			Debug.Log("On Release Spirit");
			if (32662 - 449432 != -416769)
			{
				PlayerData.MissionWithdraw[MissionData.getMissionNumber(Game.mGameCode) - 1] = PlayerData.MissionWithdraw[MissionData.getMissionNumber(Game.mGameCode) - 1] + 1;
				if (28472 - 588061 != -559588)
				{
					this.StartCoroutine_Auto(this.ReturnToTown());
					if (285566 - 424747 != -139180)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06008692 RID: 34450 RVA: 0x010C32A0 File Offset: 0x010C14A0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onDestroyPlayer(Hashtable data)
	{
		if (RuntimeServices.EqualityOperator(data[81], PlayerData.UID))
		{
			Game.mGameState = eGameState.Ended;
		}
	}

	// Token: 0x06008693 RID: 34451 RVA: 0x010C32CC File Offset: 0x010C14CC
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void createActor(string nType, int nTeam, Vector3 nPos, Vector3 nDir)
	{
		if (266419 - 5799 != 260620)
		{
		}
		for (;;)
		{
			if (Game.mGameState > eGameState.AllHold)
			{
				if (25422 - 130475 != -105052)
				{
					break;
				}
			}
			else
			{
				Hashtable hashtable = new Hashtable();
				if (282845 - 243890 == 38955)
				{
					hashtable.Add(43, PlayerData.UID);
					if (239691 - 522665 != -282973)
					{
						hashtable.Add(73, nType);
						if (236304 - 185250 == 51054)
						{
							hashtable.Add(75, PhotonClient.cInt16(nTeam));
							if (46597 - 458879 == -412282)
							{
								hashtable.Add(122, PhotonClient.cInt16(Mathf.RoundToInt(nPos.x * (float)50)));
								if (84668 - 272255 == -187587)
								{
									hashtable.Add(123, PhotonClient.cInt16(Mathf.RoundToInt(nPos.y * (float)50)));
									if (207525 - 583006 == -375481)
									{
										hashtable.Add(124, PhotonClient.cInt16(Mathf.RoundToInt(nPos.z * (float)50)));
										if (112375 - 212005 == -99630)
										{
											hashtable.Add(126, PhotonClient.cInt16(Mathf.RoundToInt(nDir.x * (float)200)));
											if (129362 - 49361 != 80002)
											{
												hashtable.Add(127, PhotonClient.cInt16(Mathf.RoundToInt(nDir.y * (float)200)));
												if (52548 - 222013 == -169465)
												{
													hashtable.Add(128, PhotonClient.cInt16(Mathf.RoundToInt(nDir.z * (float)200)));
													if (277913 - 287227 != -9313)
													{
														this.cFNcuZvAvPl.OpCustom(63, hashtable, true);
														if (221590 - 245160 == -23570)
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

	// Token: 0x06008694 RID: 34452 RVA: 0x010C35B0 File Offset: 0x010C17B0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onCreateActor(Hashtable data)
	{
		if (493 - 423424 != -422930)
		{
		}
		for (;;)
		{
			if (Game.mGameState > eGameState.AllHold)
			{
				if (205072 - 566224 == -361152)
				{
					break;
				}
			}
			else
			{
				GameObject gameObject = Game.createActor(data);
				if (106690 - 4963 != 101728)
				{
					if (Game.mGameState == eGameState.Setup)
					{
						if (255116 - 497481 != -242364)
						{
							if (this.O7hcuUyqR1L <= 0)
							{
								break;
							}
							if (186825 - 521883 != -335057)
							{
								this.O7hcuUyqR1L--;
								if (179254 - 230984 != -51729)
								{
									if (this.O7hcuUyqR1L != 0)
									{
										break;
									}
									if (71176 - 44575 == 26601)
									{
										Game.setGameState(eGameState.Ready);
										if (93016 - 354542 != -261525)
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
						if (22429 - 380235 == -357806)
						{
							gameObject.SendMessage("createSpecialEffect", 1);
							if (218592 - 426928 != -208335)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x06008695 RID: 34453 RVA: 0x010C3740 File Offset: 0x010C1940
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onActorKo(GameObject nActor)
	{
		if (Game.mGameState > eGameState.AllHold)
		{
		}
	}

	// Token: 0x06008696 RID: 34454 RVA: 0x010C3754 File Offset: 0x010C1954
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onActorDead(GameObject nActor)
	{
		if (Game.mGameState > eGameState.AllHold)
		{
		}
	}

	// Token: 0x06008697 RID: 34455 RVA: 0x010C3768 File Offset: 0x010C1968
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator ReturnToTown()
	{
		return new M607_MessageFromShadow.$ReturnToTown$40001(this).GetEnumerator();
	}

	// Token: 0x06008698 RID: 34456 RVA: 0x010C3778 File Offset: 0x010C1978
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator ReturnToGuild()
	{
		return new M607_MessageFromShadow.$ReturnToGuild$40006(this).GetEnumerator();
	}

	// Token: 0x06008699 RID: 34457 RVA: 0x010C3788 File Offset: 0x010C1988
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator ReturnToCamp()
	{
		return new M607_MessageFromShadow.$ReturnToCamp$40010(this).GetEnumerator();
	}

	// Token: 0x0600869A RID: 34458 RVA: 0x010C3798 File Offset: 0x010C1998
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void LeaveGame()
	{
		if (110157 - 22055 != 88102)
		{
		}
		for (;;)
		{
			Debug.Log("leaving guild");
			if (178787 - 467106 == -288319)
			{
				Hashtable hashtable = new Hashtable();
				if (259500 - 450083 == -190583)
				{
					hashtable.Add(43, PlayerData.UID);
					if (143184 - 75510 != 67675)
					{
						PhotonClient.Connection.OpCustom(54, hashtable, true);
						if (113207 - 232432 == -119225)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x0600869B RID: 34459 RVA: 0x010C3870 File Offset: 0x010C1A70
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onLeaveGame()
	{
		Debug.Log("onLeaveGame");
		this.JoinTown();
	}

	// Token: 0x0600869C RID: 34460 RVA: 0x010C3884 File Offset: 0x010C1A84
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void JoinTown()
	{
		if (252862 - 359036 != -106174)
		{
		}
		for (;;)
		{
			Debug.Log("Joining Town");
			if (51899 - 484344 == -432445)
			{
				Hashtable hashtable = new Hashtable();
				if (85547 - 97986 == -12439)
				{
					if (Game.mNextGameCode == 30)
					{
						if (179199 - 487572 != -308373)
						{
							continue;
						}
						hashtable.Add(47, "NoGuild");
						if (237505 - 11491 != 226014)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 31)
					{
						if (35292 - 323883 != -288591)
						{
							continue;
						}
						hashtable.Add(47, "G" + GuildData.Name);
						if (266352 - 40807 != 225545)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 32)
					{
						if (271215 - 172812 == 98404)
						{
							continue;
						}
						hashtable.Add(47, "SnowCamp");
						if (155743 - 68146 == 87598)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 33)
					{
						if (268838 - 201032 != 67806)
						{
							continue;
						}
						hashtable.Add(47, "CrystalBeach");
						if (241836 - 254848 != -13012)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 34)
					{
						if (261081 - 597352 == -336270)
						{
							continue;
						}
						hashtable.Add(47, "ExcavationCamp");
						if (164485 - 8215 == 156271)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 35)
					{
						if (239898 - 382199 == -142300)
						{
							continue;
						}
						hashtable.Add(47, "UndergroundCamp");
						if (29355 - 225691 != -196336)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 36)
					{
						if (198202 - 504011 == -305808)
						{
							continue;
						}
						hashtable.Add(47, "ForestCamp");
						if (202119 - 26593 != 175526)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 51)
					{
						if (22439 - 262773 != -240334)
						{
							continue;
						}
						hashtable.Add(47, "MainStreet");
						if (4078 - 77223 != -73145)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 52)
					{
						if (286146 - 78407 != 207739)
						{
							continue;
						}
						hashtable.Add(47, "CentralSquare");
						if (71186 - 388873 != -317687)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 53)
					{
						if (36968 - 498828 == -461859)
						{
							continue;
						}
						hashtable.Add(47, "CityLibrary");
						if (203335 - 553603 == -350267)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 54)
					{
						if (19855 - 391291 != -371436)
						{
							continue;
						}
						hashtable.Add(47, "LightPark");
						if (152591 - 57531 != 95060)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 55)
					{
						if (90776 - 299526 == -208749)
						{
							continue;
						}
						hashtable.Add(47, "LightPalace");
						if (244097 - 98234 == 145864)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 56)
					{
						if (265586 - 256159 == 9428)
						{
							continue;
						}
						hashtable.Add(47, "PlainColosseum");
						if (105780 - 398657 == -292876)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 57)
					{
						if (267973 - 373230 != -105257)
						{
							continue;
						}
						hashtable.Add(47, "LightTheater");
						if (244825 - 244466 != 359)
						{
							continue;
						}
					}
					hashtable.Add(21, PhotonClient.cInt16(Mathf.Clamp(PlayerPrefs.GetInt("channel", 0), 0, 99)));
					if (92109 - 470763 != -378653)
					{
						this.cFNcuZvAvPl.OpCustom(42, hashtable, true);
						if (65358 - 425411 == -360053)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x0600869D RID: 34461 RVA: 0x010C3E38 File Offset: 0x010C2038
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onJoinTown()
	{
		Game.mGameStage = 0;
		Game.loadNextLevel();
	}

	// Token: 0x0600869E RID: 34462 RVA: 0x010C3E48 File Offset: 0x010C2048
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x0600869F RID: 34463 RVA: 0x010C3E4C File Offset: 0x010C204C
	internal static bool s3ny3FVajsI31V13UgaF()
	{
		return true;
	}

	// Token: 0x060086A0 RID: 34464 RVA: 0x010C3E50 File Offset: 0x010C2050
	internal static bool jnCpvSVahottSe2YLrLb()
	{
		return false;
	}

	// Token: 0x040082AF RID: 33455
	private LitePeer cFNcuZvAvPl;

	// Token: 0x040082B0 RID: 33456
	private PlayerCameraControl zDccuCWHtWt;

	// Token: 0x040082B1 RID: 33457
	private float Kc1cuMJgQdA;

	// Token: 0x040082B2 RID: 33458
	private Texture oRicufVh85D;

	// Token: 0x040082B3 RID: 33459
	private int epocuLlgwy4;

	// Token: 0x040082B4 RID: 33460
	private float YdkcuwmQIu2;

	// Token: 0x040082B5 RID: 33461
	private int O7hcuUyqR1L;

	// Token: 0x040082B6 RID: 33462
	public AudioClip dead_vc;

	// Token: 0x040082B7 RID: 33463
	public GameObject thousandShot;

	// Token: 0x040082B8 RID: 33464
	public GameObject thousandShot_hit;

	// Token: 0x020016A3 RID: 5795
	[CompilerGenerated]
	[Serializable]
	internal sealed class $StartGame$39957 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x060086A1 RID: 34465 RVA: 0x010C3E54 File Offset: 0x010C2054
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $StartGame$39957(M607_MessageFromShadow self_)
		{
			if (187878 - 70949 != 116929)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (96696 - 242856 != -146159)
				{
					base..ctor();
					if (165755 - 458360 != -292604)
					{
						this.$self_$39963 = self_;
						if (209343 - 413883 != -204539)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x060086A2 RID: 34466 RVA: 0x010C3EEC File Offset: 0x010C20EC
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M607_MessageFromShadow.$StartGame$39957.$(this.$self_$39963);
		}

		// Token: 0x060086A3 RID: 34467 RVA: 0x010C3EFC File Offset: 0x010C20FC
		internal static bool O4ccnXVas7PT4JlOhemo()
		{
			return true;
		}

		// Token: 0x060086A4 RID: 34468 RVA: 0x010C3F00 File Offset: 0x010C2100
		internal static bool RLuJU8Va9KvtTS0fxIa3()
		{
			return false;
		}

		// Token: 0x040082B9 RID: 33465
		internal M607_MessageFromShadow $self_$39963;

		// Token: 0x020016A4 RID: 5796
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x060086A5 RID: 34469 RVA: 0x010C3F04 File Offset: 0x010C2104
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M607_MessageFromShadow self_)
			{
				if (149999 - 227886 != -77886)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (161728 - 24254 != 137475)
					{
						base..ctor();
						if (48091 - 419916 == -371825)
						{
							this.$self_$39962 = self_;
							if (232354 - 375509 != -143154)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x060086A6 RID: 34470 RVA: 0x010C3F9C File Offset: 0x010C219C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (14453 - 201566 != -187112)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						goto IL_1CE;
					case 1:
						goto IL_7D5;
					case 2:
						if (Game.mGameState != eGameState.Hold)
						{
							if (85686 - 268724 != -183037)
							{
								goto Block_55;
							}
							continue;
						}
						else
						{
							Game.mGameState = eGameState.Hold;
							if (296840 - 167892 == 128949)
							{
								continue;
							}
							this.$mStoryGui$39959 = (StoryGui)this.$self_$39962.GetComponent(typeof(StoryGui));
							if (94970 - 455168 == -360197)
							{
								continue;
							}
							this.$mStoryTimer$39960 = 0f;
							if (37175 - 63097 != -25922)
							{
								continue;
							}
							this.$mStoryGui$39959.startStoryMessage("Walrus", "Reggu", eTalkType.friend);
							if (58176 - 540416 != -482239)
							{
								goto Block_32;
							}
							continue;
						}
						break;
					case 3:
						if (Game.mGameState != eGameState.Hold)
						{
							if (33436 - 27489 != 5947)
							{
								continue;
							}
							goto IL_2E5;
						}
						else
						{
							this.$mStoryGui$39959.newStoryMessage("Walrus", "Reggu", Language.getMessage("M607_MessageFromShadow", 101), eTalkType.friend);
							if (3648 - 219877 == -216228)
							{
								continue;
							}
							this.$mStoryTimer$39960 = Time.time + 5f;
							if (10581 - 530772 != -520191)
							{
								continue;
							}
							goto IL_152;
						}
						break;
					case 4:
						break;
					case 5:
						break;
					case 6:
						goto IL_3DC;
					case 7:
						goto IL_3DC;
					case 8:
						goto IL_734;
					case 9:
						goto IL_734;
					case 10:
						if (Game.mGameState != eGameState.Hold)
						{
							if (65272 - 296067 != -230794)
							{
								goto Block_57;
							}
							continue;
						}
						else
						{
							this.$mGameGui$39961 = (GameGui)this.$self_$39962.GetComponent(typeof(GameGui));
							if (165573 - 81471 == 84103)
							{
								continue;
							}
							this.$mGameGui$39961.enabled = true;
							if (87074 - 355825 != -268751)
							{
								continue;
							}
							this.$self_$39962.zDccuCWHtWt.enabled = true;
							if (94686 - 277965 != -183279)
							{
								continue;
							}
							goto IL_534;
						}
						break;
					case 11:
						if (Game.mGameState != eGameState.Hold)
						{
							if (180390 - 405757 != -225366)
							{
								goto Block_41;
							}
							continue;
						}
						else
						{
							Game.mGameState = eGameState.Normal;
							if (81888 - 398542 == -316653)
							{
								continue;
							}
							this.YieldDefault(1);
							if (199534 - 546287 != -346753)
							{
								continue;
							}
							goto IL_7D5;
						}
						break;
					default:
						if (292213 - 222889 != 69325)
						{
							goto IL_1CE;
						}
						continue;
					}
					if (this.$mStoryTimer$39960 > Time.time)
					{
						if (31520 - 96364 == -64843)
						{
							continue;
						}
						if (!Input.GetKeyDown(KeyCode.Mouse0))
						{
							goto IL_16D;
						}
						if (237165 - 590690 == -353524)
						{
							continue;
						}
					}
					if (Game.mGameState != eGameState.Hold)
					{
						if (42090 - 536156 != -494065)
						{
							break;
						}
						continue;
					}
					else
					{
						this.$mWalrus$39958.animation.CrossFade("kotalk");
						if (79167 - 127059 == -47891)
						{
							continue;
						}
						this.$mStoryGui$39959.newStoryMessage("Walrus", "Reggu", Language.getMessage("M607_MessageFromShadow", 102), eTalkType.friend);
						if (25773 - 84708 != -58935)
						{
							continue;
						}
						this.$mStoryTimer$39960 = Time.time + 5f;
						if (210739 - 201149 != 9590)
						{
							continue;
						}
						goto IL_3B5;
					}
					IL_734:
					if (this.$mStoryTimer$39960 > Time.time)
					{
						if (63089 - 125871 == -62781)
						{
							continue;
						}
						if (!Input.GetKeyDown(KeyCode.Mouse0))
						{
							goto IL_727;
						}
						if (108793 - 508790 == -399996)
						{
							continue;
						}
					}
					if (Game.mGameState != eGameState.Hold)
					{
						if (129332 - 300072 != -170739)
						{
							break;
						}
						continue;
					}
					else
					{
						if (this.$mWalrus$39958)
						{
							if (288159 - 271300 != 16859)
							{
								continue;
							}
							this.$mWalrus$39958.animation.CrossFade("kosleep");
							if (178697 - 164514 != 14183)
							{
								continue;
							}
						}
						this.$mStoryGui$39959.close();
						if (207711 - 451100 != -243388)
						{
							goto Block_45;
						}
						continue;
					}
					IL_1CE:
					Debug.Log("Start Game");
					if (112160 - 265683 == -153522)
					{
						continue;
					}
					Game.mGameState = eGameState.Hold;
					if (50580 - 512824 != -462244)
					{
						continue;
					}
					Game.mGameTime = Time.time;
					if (203931 - 482998 == -279066)
					{
						continue;
					}
					this.$mWalrus$39958 = GameObject.Find("Walrus");
					if (236648 - 174645 == 62004)
					{
						continue;
					}
					if (this.$mWalrus$39958)
					{
						if (247645 - 373076 == -125430)
						{
							continue;
						}
						this.$mWalrus$39958.animation.CrossFade("kosleep");
						if (75694 - 9624 != 66070)
						{
							continue;
						}
					}
					this.$self_$39962.SendMessage("fadeIn");
					if (146085 - 308713 != -162628)
					{
						continue;
					}
					goto IL_75E;
					IL_3DC:
					if (this.$mStoryTimer$39960 > Time.time)
					{
						if (142834 - 253156 == -110321)
						{
							continue;
						}
						if (!Input.GetKeyDown(KeyCode.Mouse0))
						{
							goto IL_3D0;
						}
						if (211868 - 508323 != -296455)
						{
							continue;
						}
					}
					if (Game.mGameState != eGameState.Hold)
					{
						if (163839 - 236696 == -72857)
						{
							break;
						}
					}
					else
					{
						this.$mStoryGui$39959.newStoryMessage("Walrus", "Reggu", Language.getMessage("M607_MessageFromShadow", 103), eTalkType.friend);
						if (88007 - 438000 == -349993)
						{
							this.$mStoryTimer$39960 = Time.time + 5f;
							if (15827 - 330095 != -314267)
							{
								goto Block_43;
							}
						}
					}
				}
				goto IL_7D5;
				IL_152:
				return this.Yield(4, new WaitForSeconds(1f));
				IL_16D:
				return this.YieldDefault(5);
				IL_2E5:
				goto IL_7D5;
				IL_3B5:
				return this.Yield(6, new WaitForSeconds(1f));
				IL_3D0:
				return this.YieldDefault(7);
				Block_32:
				return this.Yield(3, new WaitForSeconds(0.5f));
				IL_534:
				return this.Yield(11, new WaitForSeconds(1f));
				Block_41:
				goto IL_7D5;
				Block_43:
				return this.Yield(8, new WaitForSeconds(1f));
				goto IL_7D5;
				Block_45:
				return this.Yield(10, new WaitForSeconds(0.5f));
				IL_727:
				return this.YieldDefault(9);
				IL_75E:
				return this.Yield(2, new WaitForSeconds(1f));
				Block_55:
				Block_57:
				IL_7D5:
				return false;
			}

			// Token: 0x060086A7 RID: 34471 RVA: 0x010C4790 File Offset: 0x010C2990
			internal static bool mPGprHVa1wlWixymUZeb()
			{
				return true;
			}

			// Token: 0x060086A8 RID: 34472 RVA: 0x010C4794 File Offset: 0x010C2994
			internal static bool Uf7nYdVa43X5OIX2SJJw()
			{
				return false;
			}

			// Token: 0x040082BA RID: 33466
			internal GameObject $mWalrus$39958;

			// Token: 0x040082BB RID: 33467
			internal StoryGui $mStoryGui$39959;

			// Token: 0x040082BC RID: 33468
			internal float $mStoryTimer$39960;

			// Token: 0x040082BD RID: 33469
			internal GameGui $mGameGui$39961;

			// Token: 0x040082BE RID: 33470
			internal M607_MessageFromShadow $self_$39962;
		}
	}

	// Token: 0x020016A5 RID: 5797
	[CompilerGenerated]
	[Serializable]
	internal sealed class $TalkToWalrus$39964 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x060086A9 RID: 34473 RVA: 0x010C4798 File Offset: 0x010C2998
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $TalkToWalrus$39964(M607_MessageFromShadow self_)
		{
			if (218564 - 546615 != -328050)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (241229 - 240068 == 1161)
				{
					base..ctor();
					if (187450 - 357260 != -169809)
					{
						this.$self_$39971 = self_;
						if (150328 - 428521 == -278193)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x060086AA RID: 34474 RVA: 0x010C4830 File Offset: 0x010C2A30
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M607_MessageFromShadow.$TalkToWalrus$39964.$(this.$self_$39971);
		}

		// Token: 0x060086AB RID: 34475 RVA: 0x010C4840 File Offset: 0x010C2A40
		internal static bool uPk46hVazqy56e1Ff3UX()
		{
			return true;
		}

		// Token: 0x060086AC RID: 34476 RVA: 0x010C4844 File Offset: 0x010C2A44
		internal static bool wk3LCLV5ajNK7XoX4uRJ()
		{
			return false;
		}

		// Token: 0x040082BF RID: 33471
		internal M607_MessageFromShadow $self_$39971;

		// Token: 0x020016A6 RID: 5798
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x060086AD RID: 34477 RVA: 0x010C4848 File Offset: 0x010C2A48
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M607_MessageFromShadow self_)
			{
				if (221661 - 183688 != 37974)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (22446 - 358258 != -335811)
					{
						base..ctor();
						if (7289 - 94636 != -87346)
						{
							this.$self_$39970 = self_;
							if (147930 - 438812 != -290881)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x060086AE RID: 34478 RVA: 0x010C48E0 File Offset: 0x010C2AE0
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (105882 - 181415 != -75532)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						goto IL_422;
					case 1:
						goto IL_660;
					case 2:
						if (Game.mGameState != eGameState.Hold)
						{
							if (21302 - 545246 != -523943)
							{
								goto Block_44;
							}
							continue;
						}
						else
						{
							this.$mStoryGui$39968.newStoryMessage("none", "Walrus", Language.getMessage("M607_MessageFromShadow", 104), eTalkType.friend);
							if (47627 - 205634 == -158006)
							{
								continue;
							}
							if (PlayerPrefs.GetInt("nvoice", 1) != 0)
							{
								if (92243 - 159408 != -67165)
								{
									continue;
								}
								if (this.$self_$39970.dead_vc)
								{
									if (7529 - 595989 != -588460)
									{
										continue;
									}
									this.$self_$39970.audio.PlayOneShot(this.$self_$39970.dead_vc);
									if (111031 - 147837 != -36806)
									{
										continue;
									}
								}
								else
								{
									Debug.LogError("Cannot find dead voice");
									if (297238 - 210777 != 86461)
									{
										continue;
									}
								}
							}
							this.$mStoryTimer$39969 = Time.time + 5f;
							if (133094 - 399214 != -266120)
							{
								continue;
							}
							goto IL_5C;
						}
						break;
					case 3:
						break;
					case 4:
						break;
					case 5:
						if (Game.mGameState != eGameState.Hold)
						{
							if (138255 - 112706 != 25550)
							{
								goto Block_40;
							}
							continue;
						}
						else
						{
							this.$mGameGui$39967.enabled = true;
							if (211233 - 45785 != 165449)
							{
								goto Block_25;
							}
							continue;
						}
						break;
					case 6:
						if (Game.mGameState != eGameState.Hold)
						{
							if (151045 - 114711 != 36334)
							{
								continue;
							}
							goto IL_616;
						}
						else
						{
							Game.mGameState = eGameState.Normal;
							if (187285 - 145305 == 41981)
							{
								continue;
							}
							this.YieldDefault(1);
							if (41139 - 124982 != -83843)
							{
								continue;
							}
							goto IL_660;
						}
						break;
					default:
						if (261680 - 205954 != 55726)
						{
							continue;
						}
						goto IL_422;
					}
					if (this.$mStoryTimer$39969 > Time.time)
					{
						if (290724 - 71619 != 219105)
						{
							continue;
						}
						if (!Input.GetKeyDown(KeyCode.Mouse0))
						{
							goto IL_77;
						}
						if (42365 - 271827 == -229461)
						{
							continue;
						}
					}
					if (Game.mGameState != eGameState.Hold)
					{
						if (243554 - 518285 != -274730)
						{
							goto Block_42;
						}
						continue;
					}
					else
					{
						if (this.$mWalrus$39966)
						{
							if (173551 - 563535 == -389983)
							{
								continue;
							}
							this.$mWalrus$39966.animation.CrossFade("kosleep");
							if (240784 - 373866 == -133081)
							{
								continue;
							}
						}
						this.$mStoryGui$39968.close();
						if (205212 - 381613 != -176401)
						{
							continue;
						}
						goto IL_526;
					}
					IL_422:
					Debug.Log("OnTalkToWalrus");
					if (119169 - 492243 != -373073)
					{
						if (Game.mGameState != eGameState.Normal)
						{
							if (212128 - 208721 != 3408)
							{
								goto Block_50;
							}
						}
						else
						{
							Game.mGameState = eGameState.Hold;
							if (119304 - 564684 == -445380)
							{
								this.$mPlayer$39965 = Game.mPlayer;
								if (260920 - 482988 == -222068)
								{
									this.$mWalrus$39966 = GameObject.Find("Walrus");
									if (190856 - 176812 != 14045)
									{
										if (this.$mWalrus$39966)
										{
											if (81444 - 36084 == 45361)
											{
												continue;
											}
											if (this.$mPlayer$39965)
											{
												if (247279 - 246179 != 1100)
												{
													continue;
												}
												this.$mPlayer$39965.SendMessage("turnToPos", this.$mWalrus$39966.transform.position);
												if (75635 - 326592 == -250956)
												{
													continue;
												}
											}
										}
										if (this.$mWalrus$39966)
										{
											if (265373 - 574042 != -308669)
											{
												continue;
											}
											this.$mWalrus$39966.animation.CrossFade("kotalk");
											if (241398 - 414434 != -173036)
											{
												continue;
											}
										}
										this.$mGameGui$39967 = (GameGui)this.$self_$39970.GetComponent(typeof(GameGui));
										if (178128 - 391005 != -212876)
										{
											if (this.$mGameGui$39967)
											{
												if (287247 - 246809 != 40438)
												{
													continue;
												}
												this.$mGameGui$39967.close();
												if (16329 - 19644 == -3314)
												{
													continue;
												}
											}
											this.$mStoryGui$39968 = (StoryGui)this.$self_$39970.GetComponent(typeof(StoryGui));
											if (76733 - 126103 != -49369)
											{
												this.$mStoryGui$39968.startStoryMessage("none", "Walrus", eTalkType.friend);
												if (155638 - 41792 != 113847)
												{
													goto Block_37;
												}
											}
										}
									}
								}
							}
						}
					}
				}
				IL_5C:
				return this.Yield(3, new WaitForSeconds(1f));
				IL_77:
				return this.YieldDefault(4);
				Block_25:
				return this.Yield(6, new WaitForSeconds(1f));
				Block_37:
				return this.Yield(2, new WaitForSeconds(0.5f));
				IL_526:
				return this.Yield(5, new WaitForSeconds(0.5f));
				Block_40:
				Block_42:
				Block_44:
				IL_616:
				Block_50:
				IL_660:
				return false;
			}

			// Token: 0x060086AF RID: 34479 RVA: 0x010C4F60 File Offset: 0x010C3160
			internal static bool fBJaLZV55R6hF9x0qvDm()
			{
				return true;
			}

			// Token: 0x060086B0 RID: 34480 RVA: 0x010C4F64 File Offset: 0x010C3164
			internal static bool OEBiFQV5p62oWcYHjV7u()
			{
				return false;
			}

			// Token: 0x040082C0 RID: 33472
			internal GameObject $mPlayer$39965;

			// Token: 0x040082C1 RID: 33473
			internal GameObject $mWalrus$39966;

			// Token: 0x040082C2 RID: 33474
			internal GameGui $mGameGui$39967;

			// Token: 0x040082C3 RID: 33475
			internal StoryGui $mStoryGui$39968;

			// Token: 0x040082C4 RID: 33476
			internal float $mStoryTimer$39969;

			// Token: 0x040082C5 RID: 33477
			internal M607_MessageFromShadow $self_$39970;
		}
	}

	// Token: 0x020016A7 RID: 5799
	[CompilerGenerated]
	[Serializable]
	internal sealed class $EnterShadeEvent$39972 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x060086B1 RID: 34481 RVA: 0x010C4F68 File Offset: 0x010C3168
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $EnterShadeEvent$39972(M607_MessageFromShadow self_)
		{
			if (269690 - 511813 != -242122)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (284728 - 2178 == 282550)
				{
					base..ctor();
					if (117312 - 94660 != 22653)
					{
						this.$self_$39989 = self_;
						if (53925 - 339425 != -285499)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x060086B2 RID: 34482 RVA: 0x010C5000 File Offset: 0x010C3200
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M607_MessageFromShadow.$EnterShadeEvent$39972.$(this.$self_$39989);
		}

		// Token: 0x060086B3 RID: 34483 RVA: 0x010C5010 File Offset: 0x010C3210
		internal static bool laA4viV5V9XH9t47i1Pj()
		{
			return true;
		}

		// Token: 0x060086B4 RID: 34484 RVA: 0x010C5014 File Offset: 0x010C3214
		internal static bool enxplQV5tarftuWCdPUf()
		{
			return false;
		}

		// Token: 0x040082C6 RID: 33478
		internal M607_MessageFromShadow $self_$39989;

		// Token: 0x020016A8 RID: 5800
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x060086B5 RID: 34485 RVA: 0x010C5018 File Offset: 0x010C3218
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M607_MessageFromShadow self_)
			{
				if (75180 - 14999 != 60182)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (76638 - 141642 != -65003)
					{
						base..ctor();
						if (198 - 262137 != -261938)
						{
							this.$self_$39988 = self_;
							if (72247 - 242599 != -170351)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x060086B6 RID: 34486 RVA: 0x010C50B0 File Offset: 0x010C32B0
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (178752 - 465102 != -286350)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						goto IL_2ECA;
					case 1:
						goto IL_3892;
					case 2:
						if (Game.mGameState != eGameState.Hold)
						{
							if (270992 - 186413 != 84580)
							{
								goto Block_234;
							}
							continue;
						}
						else
						{
							this.$self_$39988.SendMessage("fadeOut");
							if (107149 - 168306 != -61157)
							{
								continue;
							}
							goto IL_3668;
						}
						break;
					case 3:
						if (Game.mGameState != eGameState.Hold)
						{
							if (182293 - 431872 != -249578)
							{
								goto Block_383;
							}
							continue;
						}
						else
						{
							this.$self_$39988.zDccuCWHtWt.enabled = false;
							if (294330 - 48398 != 245932)
							{
								continue;
							}
							this.$self_$39988.SendMessage("alignToObject", "EventCamera1");
							if (1221 - 413124 != -411903)
							{
								continue;
							}
							this.$mPlayer$39974 = Game.mPlayer;
							if (147275 - 102339 != 44936)
							{
								continue;
							}
							this.$mLightGod$39975 = GameObject.Find("LightGod");
							if (17590 - 51639 != -34049)
							{
								continue;
							}
							this.$mFalcon$39976 = GameObject.Find("Falcon");
							if (238987 - 490628 == -251640)
							{
								continue;
							}
							this.$mShade$39977 = GameObject.Find("Shade4");
							if (181315 - 106225 != 75090)
							{
								continue;
							}
							this.$mSpawnPoint1$39978 = GameObject.Find("SpawnPoint1");
							if (216954 - 549858 == -332903)
							{
								continue;
							}
							if (this.$mPlayer$39974)
							{
								if (55109 - 310430 == -255320)
								{
									continue;
								}
								if (this.$mSpawnPoint1$39978)
								{
									if (225645 - 509791 != -284146)
									{
										continue;
									}
									this.$mPlayer$39974.transform.position = this.$mSpawnPoint1$39978.transform.position;
									if (283628 - 214993 != 68635)
									{
										continue;
									}
									this.$mPlayer$39974.transform.rotation = this.$mSpawnPoint1$39978.transform.rotation;
									if (276426 - 85416 != 191010)
									{
										continue;
									}
								}
							}
							this.$mCDat2$39979 = null;
							if (139851 - 337274 != -197423)
							{
								continue;
							}
							this.$mCDat3$39980 = null;
							if (129959 - 412208 == -282248)
							{
								continue;
							}
							this.$$switch$7065$39981 = CharacterData.mSlot;
							if (136295 - 122145 == 14151)
							{
								continue;
							}
							if (this.$$switch$7065$39981 == 1)
							{
								if (94859 - 200013 != -105154)
								{
									continue;
								}
								this.$mCDat2$39979 = CharacterData.getCDat(2);
								if (180988 - 208782 != -27794)
								{
									continue;
								}
								this.$mCDat3$39980 = CharacterData.getCDat(3);
								if (117914 - 275486 != -157572)
								{
									continue;
								}
							}
							else if (this.$$switch$7065$39981 == 2)
							{
								if (44058 - 430698 != -386640)
								{
									continue;
								}
								this.$mCDat2$39979 = CharacterData.getCDat(1);
								if (4993 - 535950 != -530957)
								{
									continue;
								}
								this.$mCDat3$39980 = CharacterData.getCDat(3);
								if (286680 - 543153 == -256472)
								{
									continue;
								}
							}
							else if (this.$$switch$7065$39981 == 3)
							{
								if (100010 - 414200 == -314189)
								{
									continue;
								}
								this.$mCDat2$39979 = CharacterData.getCDat(1);
								if (66000 - 490572 != -424572)
								{
									continue;
								}
								this.$mCDat3$39980 = CharacterData.getCDat(2);
								if (155633 - 105170 != 50463)
								{
									continue;
								}
							}
							this.$mSpawnPoint2$39982 = GameObject.Find("SpawnPoint2");
							if (78239 - 418094 != -339855)
							{
								continue;
							}
							if (this.$mSpawnPoint2$39982)
							{
								if (175109 - 474123 == -299013)
								{
									continue;
								}
								if (this.$mCDat2$39979 != null)
								{
									if (159505 - 276363 == -116857)
									{
										continue;
									}
									if (this.$mCDat2$39979.Type != "none")
									{
										if (256160 - 428364 != -172204)
										{
											continue;
										}
										this.$mPlayer2$39983 = (GameObject)UnityEngine.Object.Instantiate((GameObject)Resources.Load("GameAssets/Characters/Lobby/viewChar/" + this.$mCDat2$39979.Type, typeof(GameObject)), this.$mSpawnPoint2$39982.transform.position, this.$mSpawnPoint2$39982.transform.rotation * Quaternion.Euler((float)270, (float)90, (float)0));
										if (283685 - 341104 != -57419)
										{
											continue;
										}
										if (this.$mPlayer2$39983)
										{
											if (11618 - 212189 == -200570)
											{
												continue;
											}
											this.$mPlayer2$39983.SendMessage("EquipCDat", this.$mCDat2$39979.slot);
											if (34391 - 161135 != -126744)
											{
												continue;
											}
										}
									}
								}
							}
							this.$mSpawnPoint3$39984 = GameObject.Find("SpawnPoint3");
							if (109505 - 316974 == -207468)
							{
								continue;
							}
							if (!this.$mSpawnPoint3$39984)
							{
								goto IL_1375;
							}
							if (147758 - 403434 != -255676)
							{
								continue;
							}
							if (this.$mCDat3$39980 == null)
							{
								goto IL_1375;
							}
							if (33776 - 491399 != -457623)
							{
								continue;
							}
							if (!(this.$mCDat3$39980.Type != "none"))
							{
								goto IL_1375;
							}
							if (260760 - 206054 == 54707)
							{
								continue;
							}
							this.$mPlayer3$39985 = (GameObject)UnityEngine.Object.Instantiate((GameObject)Resources.Load("GameAssets/Characters/Lobby/viewChar/" + this.$mCDat3$39980.Type, typeof(GameObject)), this.$mSpawnPoint3$39984.transform.position, this.$mSpawnPoint3$39984.transform.rotation * Quaternion.Euler((float)270, (float)90, (float)0));
							if (203365 - 257098 != -53733)
							{
								continue;
							}
							if (!this.$mPlayer3$39985)
							{
								goto IL_1375;
							}
							if (232311 - 88886 == 143426)
							{
								continue;
							}
							this.$mPlayer3$39985.SendMessage("EquipCDat", this.$mCDat3$39980.slot);
							if (190999 - 328946 != -137947)
							{
								continue;
							}
							goto IL_1375;
						}
						break;
					case 4:
						if (Game.mGameState != eGameState.Hold)
						{
							if (293713 - 436820 != -143107)
							{
								continue;
							}
							goto IL_1F6D;
						}
						else
						{
							this.$self_$39988.SendMessage("fadeIn");
							if (118953 - 326197 != -207244)
							{
								continue;
							}
							goto IL_4F3;
						}
						break;
					case 5:
						if (Game.mGameState != eGameState.Hold)
						{
							if (243004 - 387179 != -144174)
							{
								goto Block_38;
							}
							continue;
						}
						else
						{
							this.$mStoryGui$39986 = (StoryGui)this.$self_$39988.GetComponent(typeof(StoryGui));
							if (40529 - 12888 == 27642)
							{
								continue;
							}
							this.$mStoryTimer$39987 = 0f;
							if (134115 - 598760 == -464644)
							{
								continue;
							}
							this.$mStoryGui$39986.startStoryMessage("Falcon", "Italus", eTalkType.friend);
							if (41536 - 453343 == -411806)
							{
								continue;
							}
							this.$mFalcon$39976.animation.CrossFade("talk");
							if (115028 - 487100 != -372072)
							{
								continue;
							}
							goto IL_DDF;
						}
						break;
					case 6:
						this.$mStoryGui$39986.newStoryMessage("Falcon", "Italus", Language.getMessage("M607_MessageFromShadow", 201), eTalkType.friend);
						if (76978 - 229506 == -152527)
						{
							continue;
						}
						this.$mStoryTimer$39987 = Time.time + 5f;
						if (30538 - 514268 != -483729)
						{
							goto Block_67;
						}
						continue;
					case 7:
						goto IL_2566;
					case 8:
						goto IL_2566;
					case 9:
						goto IL_17EC;
					case 10:
						goto IL_17EC;
					case 11:
						goto IL_6A8;
					case 12:
						goto IL_6A8;
					case 13:
						break;
					case 14:
						break;
					case 15:
						goto IL_2765;
					case 16:
						goto IL_2765;
					case 17:
						goto IL_243F;
					case 18:
						goto IL_243F;
					case 19:
						goto IL_3744;
					case 20:
						goto IL_3744;
					case 21:
						goto IL_16B1;
					case 22:
						goto IL_16B1;
					case 23:
						goto IL_1CBB;
					case 24:
						goto IL_1CBB;
					case 25:
						goto IL_EAE;
					case 26:
						goto IL_EAE;
					case 27:
						goto IL_1A22;
					case 28:
						goto IL_1A22;
					case 29:
						goto IL_2123;
					case 30:
						goto IL_2123;
					case 31:
						goto IL_30A9;
					case 32:
						goto IL_30A9;
					case 33:
						goto IL_B03;
					case 34:
						goto IL_B03;
					case 35:
						goto IL_3F4;
					case 36:
						goto IL_3F4;
					case 37:
						goto IL_8FE;
					case 38:
						goto IL_8FE;
					case 39:
						goto IL_245;
					case 40:
						goto IL_245;
					case 41:
						goto IL_2FE2;
					case 42:
						goto IL_2FE2;
					case 43:
						goto IL_10FB;
					case 44:
						goto IL_10FB;
					case 45:
						goto IL_586;
					case 46:
						goto IL_586;
					case 47:
						goto IL_359F;
					case 48:
						goto IL_359F;
					case 49:
						goto IL_2CD4;
					case 50:
						goto IL_2CD4;
					case 51:
						goto IL_16E;
					case 52:
						goto IL_16E;
					case 53:
						if (Game.mGameState != eGameState.Hold)
						{
							if (15449 - 530486 != -515037)
							{
								continue;
							}
							goto IL_41E;
						}
						else
						{
							if (!this.$self_$39988.thousandShot_hit)
							{
								goto IL_19BD;
							}
							if (23369 - 241280 != -217911)
							{
								continue;
							}
							UnityEngine.Object.Instantiate(this.$self_$39988.thousandShot_hit, this.$mShade$39977.transform.position + 2.5f * Vector3.up, Quaternion.identity);
							if (187544 - 136175 != 51370)
							{
								goto Block_90;
							}
							continue;
						}
						break;
					case 54:
						if (Game.mGameState != eGameState.Hold)
						{
							if (9269 - 550086 != -540817)
							{
								continue;
							}
							goto IL_74B;
						}
						else
						{
							this.$mShade$39977.animation.Play("ko");
							if (43191 - 235525 != -192333)
							{
								goto Block_56;
							}
							continue;
						}
						break;
					case 55:
						if (Game.mGameState != eGameState.Hold)
						{
							if (23601 - 548229 != -524627)
							{
								goto Block_282;
							}
							continue;
						}
						else
						{
							this.$mFalcon$39976.animation.CrossFade("root");
							if (157495 - 331563 != -174067)
							{
								goto Block_5;
							}
							continue;
						}
						break;
					case 56:
						if (Game.mGameState != eGameState.Hold)
						{
							if (12505 - 392986 != -380480)
							{
								goto Block_255;
							}
							continue;
						}
						else
						{
							this.$self_$39988.SendMessage("alignToObject", "EventCamera4");
							if (198436 - 592378 != -393942)
							{
								continue;
							}
							if (this.$mShade$39977)
							{
								if (19213 - 42111 == -22897)
								{
									continue;
								}
								UnityEngine.Object.Destroy(this.$mShade$39977);
								if (177190 - 407444 == -230253)
								{
									continue;
								}
							}
							this.$mStoryGui$39986.newStoryMessage("none", "Shade Demon", Language.getMessage("M607_MessageFromShadow", 225), eTalkType.enemy);
							if (9343 - 34046 == -24702)
							{
								continue;
							}
							this.$mStoryTimer$39987 = Time.time + 5f;
							if (166085 - 156292 != 9794)
							{
								goto Block_237;
							}
							continue;
						}
						break;
					case 57:
						goto IL_2D56;
					case 58:
						goto IL_2D56;
					case 59:
						goto IL_31F9;
					case 60:
						goto IL_31F9;
					case 61:
						goto IL_3614;
					case 62:
						goto IL_3614;
					case 63:
						goto IL_2A0F;
					case 64:
						goto IL_2A0F;
					case 65:
						goto IL_114E;
					case 66:
						goto IL_114E;
					case 67:
						goto IL_24EB;
					case 68:
						goto IL_24EB;
					case 69:
						goto IL_4C9;
					case 70:
						goto IL_4C9;
					case 71:
						goto IL_2F17;
					case 72:
						goto IL_2F17;
					case 73:
						goto IL_302;
					case 74:
						goto IL_302;
					case 75:
						goto IL_2830;
					case 76:
						goto IL_2830;
					case 77:
						goto IL_1923;
					case 78:
						goto IL_1923;
					case 79:
						goto IL_1E98;
					case 80:
						goto IL_1E98;
					case 81:
						if (Game.mGameState != eGameState.Hold)
						{
							if (39275 - 503685 != -464409)
							{
								goto Block_220;
							}
							continue;
						}
						else
						{
							Game.sendMissionEvent(6071, 0);
							if (100479 - 248902 == -148422)
							{
								continue;
							}
							this.YieldDefault(1);
							if (233763 - 230158 != 3605)
							{
								continue;
							}
							goto IL_3892;
						}
						break;
					default:
						if (1388 - 487674 != -486285)
						{
							goto IL_2ECA;
						}
						continue;
					}
					if (this.$mStoryTimer$39987 > Time.time)
					{
						if (159698 - 452754 == -293055)
						{
							continue;
						}
						if (!Input.GetKeyDown(KeyCode.Mouse0))
						{
							goto IL_27AB;
						}
						if (205693 - 44109 == 161585)
						{
							continue;
						}
					}
					if (Game.mGameState != eGameState.Hold)
					{
						if (57752 - 404582 != -346830)
						{
							continue;
						}
						break;
					}
					else
					{
						this.$self_$39988.SendMessage("alignToObject", "EventCamera4");
						if (277863 - 366874 == -89010)
						{
							continue;
						}
						this.$mLightGod$39975.animation.CrossFade("root", 0.5f);
						if (162444 - 311658 != -149214)
						{
							continue;
						}
						this.$mStoryGui$39986.newStoryMessage("none", "Shade Demon", Language.getMessage("M607_MessageFromShadow", 205), eTalkType.enemy);
						if (169720 - 560474 == -390753)
						{
							continue;
						}
						this.$mStoryTimer$39987 = Time.time + 5f;
						if (34475 - 44076 != -9601)
						{
							continue;
						}
						goto IL_273C;
					}
					IL_586:
					if (this.$mStoryTimer$39987 > Time.time)
					{
						if (211614 - 510416 != -298802)
						{
							continue;
						}
						if (!Input.GetKeyDown(KeyCode.Mouse0))
						{
							goto IL_579;
						}
						if (68800 - 37619 != 31181)
						{
							continue;
						}
					}
					if (Game.mGameState != eGameState.Hold)
					{
						if (29847 - 334926 != -305079)
						{
							continue;
						}
						break;
					}
					else
					{
						this.$mStoryGui$39986.newStoryMessage("none", "Shade Demon", Language.getMessage("M607_MessageFromShadow", 221), eTalkType.enemy);
						if (227612 - 58459 != 169153)
						{
							continue;
						}
						this.$mStoryTimer$39987 = Time.time + 5f;
						if (69373 - 107266 != -37893)
						{
							continue;
						}
						goto IL_3576;
					}
					IL_16E:
					if (this.$mStoryTimer$39987 > Time.time)
					{
						if (166871 - 432919 == -266047)
						{
							continue;
						}
						if (!Input.GetKeyDown(KeyCode.Mouse0))
						{
							goto IL_161;
						}
						if (74182 - 369421 == -295238)
						{
							continue;
						}
					}
					if (Game.mGameState != eGameState.Hold)
					{
						if (29132 - 180558 != -151426)
						{
							continue;
						}
						break;
					}
					else
					{
						this.$mFalcon$39976.animation.Play("thousandShot");
						if (143549 - 307332 == -163782)
						{
							continue;
						}
						if (this.$self_$39988.thousandShot)
						{
							if (79346 - 487043 != -407697)
							{
								continue;
							}
							UnityEngine.Object.Instantiate(this.$self_$39988.thousandShot, this.$mFalcon$39976.transform.position, this.$mFalcon$39976.transform.rotation);
							if (284602 - 67532 == 217071)
							{
								continue;
							}
						}
						this.$mStoryGui$39986.newStoryMessage("Falcon", "Italus", Language.getMessage("M607_MessageFromShadow", 224), eTalkType.enemy);
						if (22995 - 4779 != 18216)
						{
							continue;
						}
						goto IL_23DA;
					}
					IL_3744:
					if (this.$mStoryTimer$39987 > Time.time)
					{
						if (282155 - 849 == 281307)
						{
							continue;
						}
						if (!Input.GetKeyDown(KeyCode.Mouse0))
						{
							goto IL_3737;
						}
						if (206419 - 258827 == -52407)
						{
							continue;
						}
					}
					if (Game.mGameState != eGameState.Hold)
					{
						if (239567 - 198091 != 41476)
						{
							continue;
						}
						break;
					}
					else
					{
						this.$mStoryGui$39986.newStoryMessage("none", "Shade Demon", Language.getMessage("M607_MessageFromShadow", 208), eTalkType.enemy);
						if (141211 - 468288 == -327076)
						{
							continue;
						}
						this.$mStoryTimer$39987 = Time.time + 5f;
						if (163696 - 570043 != -406347)
						{
							continue;
						}
						goto IL_1688;
					}
					IL_245:
					if (this.$mStoryTimer$39987 > Time.time)
					{
						if (192357 - 70923 != 121434)
						{
							continue;
						}
						if (!Input.GetKeyDown(KeyCode.Mouse0))
						{
							goto IL_238;
						}
						if (210867 - 145445 == 65423)
						{
							continue;
						}
					}
					if (Game.mGameState != eGameState.Hold)
					{
						if (20180 - 86280 != -66099)
						{
							break;
						}
						continue;
					}
					else
					{
						this.$mStoryGui$39986.newStoryMessage("none", "Shade Demon", Language.getMessage("M607_MessageFromShadow", 218), eTalkType.enemy);
						if (104804 - 324423 == -219618)
						{
							continue;
						}
						this.$mStoryTimer$39987 = Time.time + 5f;
						if (114342 - 183066 != -68723)
						{
							goto Block_262;
						}
						continue;
					}
					IL_302:
					if (this.$mStoryTimer$39987 > Time.time)
					{
						if (291635 - 184594 == 107042)
						{
							continue;
						}
						if (!Input.GetKeyDown(KeyCode.Mouse0))
						{
							goto IL_2F5;
						}
						if (244104 - 485215 == -241110)
						{
							continue;
						}
					}
					if (Game.mGameState != eGameState.Hold)
					{
						if (214807 - 28172 != 186635)
						{
							continue;
						}
						break;
					}
					else
					{
						this.$mStoryGui$39986.newStoryMessage("LightGod", "Alcacia", Language.getMessage("M607_MessageFromShadow", 234), eTalkType.friend);
						if (125198 - 428779 != -303581)
						{
							continue;
						}
						this.$mStoryTimer$39987 = Time.time + 5f;
						if (299555 - 138456 != 161099)
						{
							continue;
						}
						goto IL_2807;
					}
					IL_2123:
					if (this.$mStoryTimer$39987 > Time.time)
					{
						if (40557 - 245803 == -205245)
						{
							continue;
						}
						if (!Input.GetKeyDown(KeyCode.Mouse0))
						{
							goto IL_2116;
						}
						if (53653 - 492068 == -438414)
						{
							continue;
						}
					}
					if (Game.mGameState != eGameState.Hold)
					{
						if (230872 - 410018 != -179146)
						{
							continue;
						}
						break;
					}
					else
					{
						this.$mStoryGui$39986.newStoryMessage("LightGod", "Alcacia", Language.getMessage("M607_MessageFromShadow", 213), eTalkType.enemy);
						if (124306 - 432406 != -308100)
						{
							continue;
						}
						this.$mStoryTimer$39987 = Time.time + 5f;
						if (188163 - 194526 != -6363)
						{
							continue;
						}
						goto IL_3080;
					}
					IL_2F17:
					if (this.$mStoryTimer$39987 > Time.time)
					{
						if (242279 - 387983 != -145704)
						{
							continue;
						}
						if (!Input.GetKeyDown(KeyCode.Mouse0))
						{
							goto IL_2F0A;
						}
						if (116210 - 206751 != -90541)
						{
							continue;
						}
					}
					if (Game.mGameState != eGameState.Hold)
					{
						if (148068 - 172493 != -24425)
						{
							continue;
						}
						break;
					}
					else
					{
						this.$mStoryGui$39986.newStoryMessage("LightGod", "Alcacia", Language.getMessage("M607_MessageFromShadow", 233), eTalkType.friend);
						if (240732 - 291311 != -50579)
						{
							continue;
						}
						this.$mStoryTimer$39987 = Time.time + 5f;
						if (211817 - 69860 != 141957)
						{
							continue;
						}
						goto IL_2D9;
					}
					IL_3F4:
					if (this.$mStoryTimer$39987 > Time.time)
					{
						if (178439 - 133694 != 44745)
						{
							continue;
						}
						if (!Input.GetKeyDown(KeyCode.Mouse0))
						{
							goto IL_3E7;
						}
						if (88977 - 580277 == -491299)
						{
							continue;
						}
					}
					if (Game.mGameState != eGameState.Hold)
					{
						if (276755 - 479239 != -202484)
						{
							continue;
						}
						break;
					}
					else
					{
						this.$mStoryGui$39986.newStoryMessage("none", "Shade Demon", Language.getMessage("M607_MessageFromShadow", 216), eTalkType.enemy);
						if (195053 - 62101 != 132952)
						{
							continue;
						}
						this.$mStoryTimer$39987 = Time.time + 5f;
						if (246039 - 543700 != -297660)
						{
							goto Block_172;
						}
						continue;
					}
					IL_EAE:
					if (this.$mStoryTimer$39987 > Time.time)
					{
						if (51145 - 26953 != 24192)
						{
							continue;
						}
						if (!Input.GetKeyDown(KeyCode.Mouse0))
						{
							goto IL_EA1;
						}
						if (280283 - 530186 == -249902)
						{
							continue;
						}
					}
					if (Game.mGameState != eGameState.Hold)
					{
						if (194421 - 107320 != 87101)
						{
							continue;
						}
						break;
					}
					else
					{
						this.$self_$39988.SendMessage("alignToObject", "EventCamera2");
						if (84328 - 516035 == -431706)
						{
							continue;
						}
						this.$mStoryGui$39986.newStoryMessage("none", "Shade Demon", Language.getMessage("M607_MessageFromShadow", 211), eTalkType.enemy);
						if (299679 - 52769 != 246910)
						{
							continue;
						}
						this.$mStoryTimer$39987 = Time.time + 5f;
						if (163432 - 437925 != -274493)
						{
							continue;
						}
						goto IL_19F9;
					}
					IL_4C9:
					if (this.$mStoryTimer$39987 > Time.time)
					{
						if (240152 - 297982 != -57830)
						{
							continue;
						}
						if (!Input.GetKeyDown(KeyCode.Mouse0))
						{
							goto IL_4BC;
						}
						if (285583 - 186116 == 99468)
						{
							continue;
						}
					}
					if (Game.mGameState != eGameState.Hold)
					{
						if (205991 - 471609 != -265617)
						{
							break;
						}
						continue;
					}
					else
					{
						this.$mLightGod$39975.animation.CrossFade("talk", 0.5f);
						if (168478 - 69667 != 98811)
						{
							continue;
						}
						this.$mStoryGui$39986.newStoryMessage("LightGod", "Alcacia", Language.getMessage("M607_MessageFromShadow", 232), eTalkType.friend);
						if (23849 - 448733 == -424883)
						{
							continue;
						}
						this.$mStoryTimer$39987 = Time.time + 5f;
						if (35809 - 463342 != -427532)
						{
							goto Block_136;
						}
						continue;
					}
					IL_2FE2:
					if (this.$mStoryTimer$39987 > Time.time)
					{
						if (217834 - 174584 != 43250)
						{
							continue;
						}
						if (!Input.GetKeyDown(KeyCode.Mouse0))
						{
							goto IL_2FD5;
						}
						if (125249 - 464429 != -339180)
						{
							continue;
						}
					}
					if (Game.mGameState != eGameState.Hold)
					{
						if (59069 - 188659 != -129589)
						{
							break;
						}
						continue;
					}
					else
					{
						this.$mStoryGui$39986.newStoryMessage("none", "Shade Demon", Language.getMessage("M607_MessageFromShadow", 219), eTalkType.enemy);
						if (146219 - 265699 != -119480)
						{
							continue;
						}
						this.$mStoryTimer$39987 = Time.time + 5f;
						if (114359 - 103927 != 10432)
						{
							continue;
						}
						goto IL_10D2;
					}
					IL_24EB:
					if (this.$mStoryTimer$39987 > Time.time)
					{
						if (186248 - 387997 == -201748)
						{
							continue;
						}
						if (!Input.GetKeyDown(KeyCode.Mouse0))
						{
							goto IL_24DE;
						}
						if (217575 - 192516 != 25059)
						{
							continue;
						}
					}
					if (Game.mGameState != eGameState.Hold)
					{
						if (98935 - 440656 != -341721)
						{
							continue;
						}
						break;
					}
					else
					{
						this.$mStoryGui$39986.newStoryMessage("LightGod", "Alcacia", Language.getMessage("M607_MessageFromShadow", 231), eTalkType.friend);
						if (260271 - 553662 != -293391)
						{
							continue;
						}
						this.$mStoryTimer$39987 = Time.time + 5f;
						if (290371 - 527907 != -237535)
						{
							goto Block_45;
						}
						continue;
					}
					IL_6A8:
					if (this.$mStoryTimer$39987 > Time.time)
					{
						if (70378 - 199734 == -129355)
						{
							continue;
						}
						if (!Input.GetKeyDown(KeyCode.Mouse0))
						{
							goto IL_69B;
						}
						if (189944 - 549295 != -359351)
						{
							continue;
						}
					}
					if (Game.mGameState != eGameState.Hold)
					{
						if (49794 - 93384 != -43589)
						{
							break;
						}
						continue;
					}
					else
					{
						this.$mStoryGui$39986.newStoryMessage("LightGod", "Alcacia", Language.getMessage("M607_MessageFromShadow", 204), eTalkType.friend);
						if (170732 - 203758 == -33025)
						{
							continue;
						}
						this.$mStoryTimer$39987 = Time.time + 5f;
						if (36523 - 22151 != 14372)
						{
							continue;
						}
						goto IL_278F;
					}
					IL_8FE:
					if (this.$mStoryTimer$39987 > Time.time)
					{
						if (176463 - 540400 == -363936)
						{
							continue;
						}
						if (!Input.GetKeyDown(KeyCode.Mouse0))
						{
							goto IL_8F1;
						}
						if (73388 - 2106 != 71282)
						{
							continue;
						}
					}
					if (Game.mGameState != eGameState.Hold)
					{
						if (258282 - 67786 != 190497)
						{
							break;
						}
						continue;
					}
					else
					{
						this.$mStoryGui$39986.newStoryMessage("none", "Shade Demon", Language.getMessage("M607_MessageFromShadow", 217), eTalkType.enemy);
						if (200105 - 158384 == 41722)
						{
							continue;
						}
						this.$mStoryTimer$39987 = Time.time + 5f;
						if (275290 - 187250 != 88041)
						{
							goto Block_361;
						}
						continue;
					}
					IL_17EC:
					if (this.$mStoryTimer$39987 > Time.time)
					{
						if (115190 - 540459 == -425268)
						{
							continue;
						}
						if (!Input.GetKeyDown(KeyCode.Mouse0))
						{
							goto IL_17DF;
						}
						if (232266 - 583218 == -350951)
						{
							continue;
						}
					}
					if (Game.mGameState != eGameState.Hold)
					{
						if (167387 - 494359 != -326972)
						{
							continue;
						}
						break;
					}
					else
					{
						this.$mLightGod$39975.animation.CrossFade("talk", 0.5f);
						if (136662 - 169552 != -32890)
						{
							continue;
						}
						this.$mFalcon$39976.animation.CrossFade("root");
						if (88674 - 480661 != -391987)
						{
							continue;
						}
						this.$mStoryGui$39986.newStoryMessage("LightGod", "Alcacia", Language.getMessage("M607_MessageFromShadow", 203), eTalkType.friend);
						if (151125 - 344321 == -193195)
						{
							continue;
						}
						this.$mStoryTimer$39987 = Time.time + 5f;
						if (223072 - 337841 != -114769)
						{
							continue;
						}
						goto IL_67F;
					}
					IL_1A22:
					if (this.$mStoryTimer$39987 > Time.time)
					{
						if (92236 - 276744 != -184508)
						{
							continue;
						}
						if (!Input.GetKeyDown(KeyCode.Mouse0))
						{
							goto IL_1A15;
						}
						if (125890 - 335388 == -209497)
						{
							continue;
						}
					}
					if (Game.mGameState != eGameState.Hold)
					{
						if (140223 - 272627 != -132403)
						{
							break;
						}
						continue;
					}
					else
					{
						this.$mStoryGui$39986.newStoryMessage("none", "Shade Demon", Language.getMessage("M607_MessageFromShadow", 212), eTalkType.enemy);
						if (183443 - 397810 == -214366)
						{
							continue;
						}
						this.$mStoryTimer$39987 = Time.time + 5f;
						if (280026 - 142517 != 137510)
						{
							goto Block_74;
						}
						continue;
					}
					IL_2CD4:
					if (this.$mStoryTimer$39987 > Time.time)
					{
						if (188995 - 393914 != -204919)
						{
							continue;
						}
						if (!Input.GetKeyDown(KeyCode.Mouse0))
						{
							goto IL_2CC7;
						}
						if (146734 - 546495 != -399761)
						{
							continue;
						}
					}
					if (Game.mGameState != eGameState.Hold)
					{
						if (40445 - 552492 != -512047)
						{
							continue;
						}
						break;
					}
					else
					{
						this.$self_$39988.SendMessage("alignToObject", "EventCamera6");
						if (25763 - 105945 == -80181)
						{
							continue;
						}
						if (this.$mShade$39977)
						{
							if (271604 - 42844 == 228761)
							{
								continue;
							}
							this.$mShade$39977.animation.CrossFade("root");
							if (287940 - 125731 != 162209)
							{
								continue;
							}
						}
						this.$mStoryGui$39986.newStoryMessage("Falcon", "Italus", Language.getMessage("M607_MessageFromShadow", 223), eTalkType.enemy);
						if (115339 - 143871 == -28531)
						{
							continue;
						}
						this.$mStoryTimer$39987 = Time.time + 5f;
						if (107142 - 211201 != -104058)
						{
							goto Block_198;
						}
						continue;
					}
					IL_114E:
					if (this.$mStoryTimer$39987 > Time.time)
					{
						if (143521 - 597297 != -453776)
						{
							continue;
						}
						if (!Input.GetKeyDown(KeyCode.Mouse0))
						{
							goto IL_1141;
						}
						if (213393 - 21746 != 191647)
						{
							continue;
						}
					}
					if (Game.mGameState != eGameState.Hold)
					{
						if (133183 - 7831 != 125353)
						{
							break;
						}
						continue;
					}
					else
					{
						this.$mFalcon$39976.transform.rotation = Quaternion.LookRotation(global::Math.vFlat(this.$mPlayer$39974.transform.position - this.$mFalcon$39976.transform.position));
						if (269855 - 385527 == -115671)
						{
							continue;
						}
						this.$mStoryGui$39986.newStoryMessage("LightGod", "Alcacia", Language.getMessage("M607_MessageFromShadow", 230), eTalkType.friend);
						if (173008 - 155372 == 17637)
						{
							continue;
						}
						this.$mStoryTimer$39987 = Time.time + 5f;
						if (239053 - 177053 != 62001)
						{
							goto Block_9;
						}
						continue;
					}
					IL_2765:
					if (this.$mStoryTimer$39987 > Time.time)
					{
						if (211093 - 566992 != -355899)
						{
							continue;
						}
						if (!Input.GetKeyDown(KeyCode.Mouse0))
						{
							goto IL_2758;
						}
						if (211020 - 41597 != 169423)
						{
							continue;
						}
					}
					if (Game.mGameState != eGameState.Hold)
					{
						if (199243 - 335758 != -136515)
						{
							continue;
						}
						break;
					}
					else
					{
						this.$mStoryGui$39986.newStoryMessage("none", "Shade Demon", Language.getMessage("M607_MessageFromShadow", 206), eTalkType.enemy);
						if (172379 - 45461 == 126919)
						{
							continue;
						}
						this.$mStoryTimer$39987 = Time.time + 5f;
						if (114541 - 121977 != -7436)
						{
							continue;
						}
						goto IL_2416;
					}
					IL_1CBB:
					if (this.$mStoryTimer$39987 > Time.time)
					{
						if (136942 - 404560 == -267617)
						{
							continue;
						}
						if (!Input.GetKeyDown(KeyCode.Mouse0))
						{
							goto IL_1CAE;
						}
						if (39745 - 322978 != -283233)
						{
							continue;
						}
					}
					if (Game.mGameState != eGameState.Hold)
					{
						if (255742 - 394865 != -139123)
						{
							continue;
						}
						break;
					}
					else
					{
						this.$mStoryGui$39986.newStoryMessage("Falcon", "Italus", Language.getMessage("M607_MessageFromShadow", 210), eTalkType.friend);
						if (158969 - 306528 == -147558)
						{
							continue;
						}
						this.$mStoryTimer$39987 = Time.time + 5f;
						if (161229 - 125230 != 35999)
						{
							continue;
						}
						goto IL_E85;
					}
					IL_2ECA:
					Debug.Log("EnterShadeEvent");
					if (230508 - 443299 != -212791)
					{
						continue;
					}
					if (Game.mGameState != eGameState.Normal)
					{
						if (44318 - 288236 != -243918)
						{
							continue;
						}
						break;
					}
					else
					{
						Game.mGameState = eGameState.Hold;
						if (211624 - 66504 != 145120)
						{
							continue;
						}
						this.$mGameGui$39973 = (GameGui)this.$self_$39988.GetComponent(typeof(GameGui));
						if (224793 - 439976 != -215183)
						{
							continue;
						}
						if (!this.$mGameGui$39973)
						{
							goto IL_22A0;
						}
						if (153238 - 402485 != -249247)
						{
							continue;
						}
						this.$mGameGui$39973.close();
						if (185187 - 18092 != 167095)
						{
							continue;
						}
						goto IL_22A0;
					}
					IL_B03:
					if (this.$mStoryTimer$39987 > Time.time)
					{
						if (118161 - 171539 != -53378)
						{
							continue;
						}
						if (!Input.GetKeyDown(KeyCode.Mouse0))
						{
							goto IL_AF6;
						}
						if (12089 - 477076 != -464987)
						{
							continue;
						}
					}
					if (Game.mGameState != eGameState.Hold)
					{
						if (5916 - 317861 != -311944)
						{
							break;
						}
						continue;
					}
					else
					{
						this.$self_$39988.SendMessage("alignToObject", "EventCamera5");
						if (227957 - 381071 == -153113)
						{
							continue;
						}
						if (this.$mShade$39977)
						{
							if (46416 - 498904 != -452488)
							{
								continue;
							}
							this.$mShade$39977.animation.CrossFade("turn");
							if (5731 - 592957 != -587226)
							{
								continue;
							}
						}
						this.$mStoryGui$39986.newStoryMessage("none", "Shade Demon", Language.getMessage("M607_MessageFromShadow", 215), eTalkType.enemy);
						if (288140 - 489908 != -201768)
						{
							continue;
						}
						this.$mStoryTimer$39987 = Time.time + 5f;
						if (247770 - 106962 != 140808)
						{
							continue;
						}
						goto IL_3CB;
					}
					IL_2830:
					if (this.$mStoryTimer$39987 > Time.time)
					{
						if (89690 - 163181 == -73490)
						{
							continue;
						}
						if (!Input.GetKeyDown(KeyCode.Mouse0))
						{
							goto IL_2823;
						}
						if (88370 - 184979 != -96609)
						{
							continue;
						}
					}
					if (Game.mGameState != eGameState.Hold)
					{
						if (106834 - 201892 != -95058)
						{
							continue;
						}
						break;
					}
					else
					{
						this.$mLightGod$39975.animation.CrossFade("root", 0.5f);
						if (95112 - 209272 == -114159)
						{
							continue;
						}
						this.$mStoryGui$39986.newStoryMessage("LightGod", "Alcacia", Language.getMessage("M607_MessageFromShadow", 235), eTalkType.friend);
						if (132049 - 253294 == -121244)
						{
							continue;
						}
						this.$mStoryTimer$39987 = Time.time + 5f;
						if (172690 - 352825 != -180134)
						{
							goto Block_98;
						}
						continue;
					}
					IL_30A9:
					if (this.$mStoryTimer$39987 > Time.time)
					{
						if (174590 - 417600 == -243009)
						{
							continue;
						}
						if (!Input.GetKeyDown(KeyCode.Mouse0))
						{
							goto IL_309C;
						}
						if (47269 - 234148 == -186878)
						{
							continue;
						}
					}
					if (Game.mGameState != eGameState.Hold)
					{
						if (5721 - 369196 != -363475)
						{
							continue;
						}
						break;
					}
					else
					{
						this.$mStoryGui$39986.newStoryMessage("none", "Shade Demon", Language.getMessage("M607_MessageFromShadow", 214), eTalkType.enemy);
						if (26508 - 67789 != -41281)
						{
							continue;
						}
						this.$mStoryTimer$39987 = Time.time + 5f;
						if (20249 - 566359 != -546110)
						{
							continue;
						}
						goto IL_ADA;
					}
					IL_31F9:
					if (this.$mStoryTimer$39987 > Time.time)
					{
						if (212699 - 229536 == -16836)
						{
							continue;
						}
						if (!Input.GetKeyDown(KeyCode.Mouse0))
						{
							goto IL_31EC;
						}
						if (265423 - 190159 != 75264)
						{
							continue;
						}
					}
					if (Game.mGameState != eGameState.Hold)
					{
						if (74733 - 96077 != -21343)
						{
							break;
						}
						continue;
					}
					else
					{
						this.$self_$39988.SendMessage("alignToObject", "EventCamera3");
						if (283090 - 531512 == -248421)
						{
							continue;
						}
						this.$mStoryGui$39986.newStoryMessage("LightGod", "Alcacia", Language.getMessage("M607_MessageFromShadow", 227), eTalkType.friend);
						if (262377 - 449060 == -186682)
						{
							continue;
						}
						this.$mStoryTimer$39987 = Time.time + 5f;
						if (91183 - 438093 != -346909)
						{
							goto Block_297;
						}
						continue;
					}
					IL_10FB:
					if (this.$mStoryTimer$39987 > Time.time)
					{
						if (35097 - 484243 != -449146)
						{
							continue;
						}
						if (!Input.GetKeyDown(KeyCode.Mouse0))
						{
							goto IL_10EE;
						}
						if (192452 - 75739 == 116714)
						{
							continue;
						}
					}
					if (Game.mGameState != eGameState.Hold)
					{
						if (259864 - 429629 != -169764)
						{
							break;
						}
						continue;
					}
					else
					{
						this.$mStoryGui$39986.newStoryMessage("none", "Shade Demon", Language.getMessage("M607_MessageFromShadow", 220), eTalkType.enemy);
						if (128986 - 416070 == -287083)
						{
							continue;
						}
						this.$mStoryTimer$39987 = Time.time + 5f;
						if (262873 - 10360 != 252514)
						{
							goto Block_368;
						}
						continue;
					}
					IL_2D56:
					if (this.$mStoryTimer$39987 > Time.time)
					{
						if (167474 - 478436 == -310961)
						{
							continue;
						}
						if (!Input.GetKeyDown(KeyCode.Mouse0))
						{
							goto IL_2D49;
						}
						if (286678 - 117032 != 169646)
						{
							continue;
						}
					}
					if (Game.mGameState != eGameState.Hold)
					{
						if (78287 - 431824 != -353537)
						{
							continue;
						}
						break;
					}
					else
					{
						this.$mStoryGui$39986.newStoryMessage("none", "Shade Demon", Language.getMessage("M607_MessageFromShadow", 226), eTalkType.enemy);
						if (17927 - 140649 != -122722)
						{
							continue;
						}
						this.$mStoryTimer$39987 = Time.time + 5f;
						if (65168 - 213157 != -147988)
						{
							goto Block_229;
						}
						continue;
					}
					IL_2A0F:
					if (this.$mStoryTimer$39987 > Time.time)
					{
						if (233748 - 580612 == -346863)
						{
							continue;
						}
						if (!Input.GetKeyDown(KeyCode.Mouse0))
						{
							goto IL_2A02;
						}
						if (180485 - 536671 == -356185)
						{
							continue;
						}
					}
					if (Game.mGameState != eGameState.Hold)
					{
						if (253372 - 222650 != 30722)
						{
							continue;
						}
						break;
					}
					else
					{
						this.$self_$39988.SendMessage("alignToObject", "EventCamera7");
						if (172292 - 586236 == -413943)
						{
							continue;
						}
						this.$mStoryGui$39986.newStoryMessage("LightGod", "Alcacia", Language.getMessage("M607_MessageFromShadow", 229), eTalkType.friend);
						if (15947 - 416170 == -400222)
						{
							continue;
						}
						this.$mStoryTimer$39987 = Time.time + 5f;
						if (69982 - 552148 != -482165)
						{
							goto Block_147;
						}
						continue;
					}
					IL_16B1:
					if (this.$mStoryTimer$39987 > Time.time)
					{
						if (217281 - 420697 == -203415)
						{
							continue;
						}
						if (!Input.GetKeyDown(KeyCode.Mouse0))
						{
							goto IL_16A4;
						}
						if (39966 - 501173 != -461207)
						{
							continue;
						}
					}
					if (Game.mGameState != eGameState.Hold)
					{
						if (85201 - 440761 != -355560)
						{
							continue;
						}
						break;
					}
					else
					{
						this.$mFalcon$39976.animation.CrossFade("talk");
						if (1645 - 556309 != -554664)
						{
							continue;
						}
						this.$mStoryGui$39986.newStoryMessage("Falcon", "Italus", Language.getMessage("M607_MessageFromShadow", 209), eTalkType.friend);
						if (251672 - 556717 == -305044)
						{
							continue;
						}
						this.$mStoryTimer$39987 = Time.time + 5f;
						if (93396 - 337401 != -244005)
						{
							continue;
						}
						goto IL_1C92;
					}
					IL_1E98:
					if (this.$mStoryTimer$39987 > Time.time)
					{
						if (189506 - 149776 == 39731)
						{
							continue;
						}
						if (!Input.GetKeyDown(KeyCode.Mouse0))
						{
							goto IL_1E8B;
						}
						if (261416 - 486299 == -224882)
						{
							continue;
						}
					}
					if (Game.mGameState != eGameState.Hold)
					{
						if (70181 - 299022 != -228841)
						{
							continue;
						}
						break;
					}
					else
					{
						this.$mStoryGui$39986.close();
						if (226350 - 528052 != -301701)
						{
							goto Block_247;
						}
						continue;
					}
					IL_2566:
					if (this.$mStoryTimer$39987 > Time.time)
					{
						if (256898 - 431806 != -174908)
						{
							continue;
						}
						if (!Input.GetKeyDown(KeyCode.Mouse0))
						{
							goto IL_255A;
						}
						if (240284 - 496941 == -256656)
						{
							continue;
						}
					}
					if (Game.mGameState != eGameState.Hold)
					{
						if (4091 - 355287 != -351196)
						{
							continue;
						}
						break;
					}
					else
					{
						this.$mStoryGui$39986.newStoryMessage("Falcon", "Italus", Language.getMessage("M607_MessageFromShadow", 202), eTalkType.friend);
						if (250833 - 139646 == 111188)
						{
							continue;
						}
						this.$mStoryTimer$39987 = Time.time + 5f;
						if (43304 - 398173 != -354868)
						{
							goto Block_178;
						}
						continue;
					}
					IL_1923:
					if (this.$mStoryTimer$39987 > Time.time)
					{
						if (288201 - 302953 == -14751)
						{
							continue;
						}
						if (!Input.GetKeyDown(KeyCode.Mouse0))
						{
							goto IL_1916;
						}
						if (133625 - 568045 == -434419)
						{
							continue;
						}
					}
					if (Game.mGameState != eGameState.Hold)
					{
						if (258517 - 353707 != -95189)
						{
							break;
						}
						continue;
					}
					else
					{
						this.$mStoryGui$39986.newStoryMessage("LightGod", "Alcacia", Language.getMessage("M607_MessageFromShadow", 236), eTalkType.friend);
						if (270668 - 551427 != -280759)
						{
							continue;
						}
						this.$mStoryTimer$39987 = Time.time + 5f;
						if (273554 - 474770 != -201215)
						{
							goto Block_345;
						}
						continue;
					}
					IL_243F:
					if (this.$mStoryTimer$39987 > Time.time)
					{
						if (228892 - 179550 == 49343)
						{
							continue;
						}
						if (!Input.GetKeyDown(KeyCode.Mouse0))
						{
							goto IL_2432;
						}
						if (84626 - 60476 == 24151)
						{
							continue;
						}
					}
					if (Game.mGameState != eGameState.Hold)
					{
						if (150460 - 297554 != -147094)
						{
							continue;
						}
						break;
					}
					else
					{
						this.$mStoryGui$39986.newStoryMessage("none", "Shade Demon", Language.getMessage("M607_MessageFromShadow", 207), eTalkType.enemy);
						if (22839 - 428227 == -405387)
						{
							continue;
						}
						this.$mStoryTimer$39987 = Time.time + 5f;
						if (291362 - 669 != 290694)
						{
							goto Block_190;
						}
						continue;
					}
					IL_359F:
					if (this.$mStoryTimer$39987 > Time.time)
					{
						if (125326 - 467876 != -342550)
						{
							continue;
						}
						if (!Input.GetKeyDown(KeyCode.Mouse0))
						{
							goto IL_3592;
						}
						if (298743 - 62076 != 236667)
						{
							continue;
						}
					}
					if (Game.mGameState != eGameState.Hold)
					{
						if (116036 - 567134 != -451098)
						{
							continue;
						}
						break;
					}
					else
					{
						this.$mStoryGui$39986.newStoryMessage("none", "Shade Demon", Language.getMessage("M607_MessageFromShadow", 222), eTalkType.enemy);
						if (89498 - 30183 == 59316)
						{
							continue;
						}
						this.$mStoryTimer$39987 = Time.time + 5f;
						if (41186 - 348489 != -307302)
						{
							goto Block_12;
						}
						continue;
					}
					IL_3614:
					if (this.$mStoryTimer$39987 > Time.time)
					{
						if (214832 - 304347 != -89515)
						{
							continue;
						}
						if (!Input.GetKeyDown(KeyCode.Mouse0))
						{
							goto IL_3607;
						}
						if (283429 - 487586 == -204156)
						{
							continue;
						}
					}
					if (Game.mGameState != eGameState.Hold)
					{
						if (157507 - 356205 == -198698)
						{
							break;
						}
					}
					else
					{
						this.$mStoryGui$39986.newStoryMessage("Falcon", "Italus", Language.getMessage("M607_MessageFromShadow", 228), eTalkType.enemy);
						if (84702 - 336346 != -251643)
						{
							this.$mFalcon$39976.transform.rotation = Quaternion.LookRotation(global::Math.vFlat(this.$mLightGod$39975.transform.position - this.$mFalcon$39976.transform.position));
							if (271025 - 348413 == -77388)
							{
								this.$mStoryTimer$39987 = Time.time + 5f;
								if (20673 - 461443 != -440769)
								{
									goto Block_340;
								}
							}
						}
					}
				}
				goto IL_3892;
				Block_5:
				return this.Yield(56, new WaitForSeconds(1.2f));
				goto IL_3892;
				Block_9:
				return this.Yield(67, new WaitForSeconds(0.5f));
				IL_161:
				return this.YieldDefault(52);
				Block_12:
				return this.Yield(49, new WaitForSeconds(0.5f));
				IL_238:
				return this.YieldDefault(40);
				IL_2D9:
				return this.Yield(73, new WaitForSeconds(0.5f));
				IL_2F5:
				return this.YieldDefault(74);
				goto IL_3892;
				IL_3CB:
				return this.Yield(35, new WaitForSeconds(0.5f));
				IL_3E7:
				return this.YieldDefault(36);
				IL_41E:
				goto IL_3892;
				IL_4BC:
				return this.YieldDefault(70);
				IL_4F3:
				return this.Yield(5, new WaitForSeconds(1f));
				Block_38:
				goto IL_3892;
				IL_579:
				return this.YieldDefault(46);
				goto IL_3892;
				Block_45:
				return this.Yield(69, new WaitForSeconds(0.5f));
				IL_67F:
				return this.Yield(11, new WaitForSeconds(0.5f));
				IL_69B:
				return this.YieldDefault(12);
				IL_74B:
				goto IL_3892;
				Block_56:
				return this.Yield(55, new WaitForSeconds(0.4f));
				goto IL_3892;
				Block_67:
				return this.Yield(7, new WaitForSeconds(0.5f));
				IL_8F1:
				return this.YieldDefault(38);
				Block_74:
				return this.Yield(29, new WaitForSeconds(0.5f));
				goto IL_3892;
				IL_ADA:
				return this.Yield(33, new WaitForSeconds(0.5f));
				IL_AF6:
				return this.YieldDefault(34);
				Block_90:
				goto IL_19BD;
				IL_DDF:
				return this.Yield(6, new WaitForSeconds(0.5f));
				Block_98:
				return this.Yield(77, new WaitForSeconds(0.5f));
				IL_E85:
				return this.Yield(25, new WaitForSeconds(0.5f));
				IL_EA1:
				return this.YieldDefault(26);
				goto IL_3892;
				IL_10D2:
				return this.Yield(43, new WaitForSeconds(0.5f));
				IL_10EE:
				return this.YieldDefault(44);
				IL_1141:
				return this.YieldDefault(66);
				goto IL_3892;
				Block_136:
				return this.Yield(71, new WaitForSeconds(0.5f));
				IL_1375:
				return this.Yield(4, new WaitForSeconds(0.1f));
				goto IL_3892;
				Block_147:
				return this.Yield(65, new WaitForSeconds(0.5f));
				IL_1688:
				return this.Yield(21, new WaitForSeconds(0.5f));
				IL_16A4:
				return this.YieldDefault(22);
				IL_17DF:
				return this.YieldDefault(10);
				goto IL_3892;
				IL_1916:
				return this.YieldDefault(78);
				Block_172:
				return this.Yield(37, new WaitForSeconds(0.5f));
				IL_19BD:
				return this.Yield(54, new WaitForSeconds(0.4f));
				IL_19F9:
				return this.Yield(27, new WaitForSeconds(0.5f));
				IL_1A15:
				return this.YieldDefault(28);
				Block_178:
				return this.Yield(9, new WaitForSeconds(0.5f));
				goto IL_3892;
				Block_190:
				return this.Yield(19, new WaitForSeconds(0.5f));
				goto IL_3892;
				IL_1C92:
				return this.Yield(23, new WaitForSeconds(0.5f));
				IL_1CAE:
				return this.YieldDefault(24);
				goto IL_3892;
				Block_198:
				return this.Yield(51, new WaitForSeconds(0.5f));
				IL_1E8B:
				return this.YieldDefault(80);
				IL_1F6D:
				Block_220:
				goto IL_3892;
				IL_2116:
				return this.YieldDefault(30);
				Block_229:
				return this.Yield(59, new WaitForSeconds(0.5f));
				IL_22A0:
				return this.Yield(2, new WaitForSeconds(0.5f));
				Block_234:
				goto IL_3892;
				Block_237:
				return this.Yield(57, new WaitForSeconds(0.5f));
				IL_23DA:
				return this.Yield(53, new WaitForSeconds(1f));
				IL_2416:
				return this.Yield(17, new WaitForSeconds(0.5f));
				IL_2432:
				return this.YieldDefault(18);
				goto IL_3892;
				Block_247:
				return this.Yield(81, new WaitForSeconds(1f));
				IL_24DE:
				return this.YieldDefault(68);
				IL_255A:
				return this.YieldDefault(8);
				Block_255:
				goto IL_3892;
				Block_262:
				return this.Yield(41, new WaitForSeconds(0.5f));
				goto IL_3892;
				IL_273C:
				return this.Yield(15, new WaitForSeconds(0.5f));
				IL_2758:
				return this.YieldDefault(16);
				IL_278F:
				return this.Yield(13, new WaitForSeconds(0.5f));
				IL_27AB:
				return this.YieldDefault(14);
				goto IL_3892;
				IL_2807:
				return this.Yield(75, new WaitForSeconds(0.5f));
				IL_2823:
				return this.YieldDefault(76);
				Block_282:
				goto IL_3892;
				IL_2A02:
				return this.YieldDefault(64);
				goto IL_3892;
				Block_297:
				return this.Yield(61, new WaitForSeconds(0.5f));
				goto IL_3892;
				IL_2CC7:
				return this.YieldDefault(50);
				IL_2D49:
				return this.YieldDefault(58);
				goto IL_3892;
				IL_2F0A:
				return this.YieldDefault(72);
				goto IL_3892;
				IL_2FD5:
				return this.YieldDefault(42);
				IL_3080:
				return this.Yield(31, new WaitForSeconds(0.5f));
				IL_309C:
				return this.YieldDefault(32);
				goto IL_3892;
				Block_340:
				return this.Yield(63, new WaitForSeconds(0.5f));
				Block_345:
				return this.Yield(79, new WaitForSeconds(0.5f));
				IL_31EC:
				return this.YieldDefault(60);
				goto IL_3892;
				Block_361:
				return this.Yield(39, new WaitForSeconds(0.5f));
				goto IL_3892;
				Block_368:
				return this.Yield(45, new WaitForSeconds(0.5f));
				IL_3576:
				return this.Yield(47, new WaitForSeconds(0.5f));
				IL_3592:
				return this.YieldDefault(48);
				IL_3607:
				return this.YieldDefault(62);
				IL_3668:
				return this.Yield(3, new WaitForSeconds(1f));
				Block_383:
				goto IL_3892;
				IL_3737:
				return this.YieldDefault(20);
				IL_3892:
				return false;
			}

			// Token: 0x060086B7 RID: 34487 RVA: 0x010C8964 File Offset: 0x010C6B64
			internal static bool DxguRTV5NLYf1wEkvSag()
			{
				return true;
			}

			// Token: 0x060086B8 RID: 34488 RVA: 0x010C8968 File Offset: 0x010C6B68
			internal static bool PO8n1AV5Y0LtquH2XvdL()
			{
				return false;
			}

			// Token: 0x040082C7 RID: 33479
			internal GameGui $mGameGui$39973;

			// Token: 0x040082C8 RID: 33480
			internal GameObject $mPlayer$39974;

			// Token: 0x040082C9 RID: 33481
			internal GameObject $mLightGod$39975;

			// Token: 0x040082CA RID: 33482
			internal GameObject $mFalcon$39976;

			// Token: 0x040082CB RID: 33483
			internal GameObject $mShade$39977;

			// Token: 0x040082CC RID: 33484
			internal GameObject $mSpawnPoint1$39978;

			// Token: 0x040082CD RID: 33485
			internal CharacterDataClass $mCDat2$39979;

			// Token: 0x040082CE RID: 33486
			internal CharacterDataClass $mCDat3$39980;

			// Token: 0x040082CF RID: 33487
			internal int $$switch$7065$39981;

			// Token: 0x040082D0 RID: 33488
			internal GameObject $mSpawnPoint2$39982;

			// Token: 0x040082D1 RID: 33489
			internal GameObject $mPlayer2$39983;

			// Token: 0x040082D2 RID: 33490
			internal GameObject $mSpawnPoint3$39984;

			// Token: 0x040082D3 RID: 33491
			internal GameObject $mPlayer3$39985;

			// Token: 0x040082D4 RID: 33492
			internal StoryGui $mStoryGui$39986;

			// Token: 0x040082D5 RID: 33493
			internal float $mStoryTimer$39987;

			// Token: 0x040082D6 RID: 33494
			internal M607_MessageFromShadow $self_$39988;
		}
	}

	// Token: 0x020016A9 RID: 5801
	[CompilerGenerated]
	[Serializable]
	internal sealed class $onGameComplete$39990 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x060086B9 RID: 34489 RVA: 0x010C896C File Offset: 0x010C6B6C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $onGameComplete$39990(Hashtable data, M607_MessageFromShadow self_)
		{
			if (176626 - 389722 != -213095)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (132650 - 79899 == 52751)
				{
					base..ctor();
					if (254945 - 90580 == 164365)
					{
						this.$data$39993 = data;
						if (219110 - 29404 == 189706)
						{
							this.$self_$39994 = self_;
							if (84236 - 131160 != -46923)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x060086BA RID: 34490 RVA: 0x010C8A28 File Offset: 0x010C6C28
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M607_MessageFromShadow.$onGameComplete$39990.$(this.$data$39993, this.$self_$39994);
		}

		// Token: 0x060086BB RID: 34491 RVA: 0x010C8A3C File Offset: 0x010C6C3C
		internal static bool Gyyt9iV5c2rXIhpHhj1E()
		{
			return true;
		}

		// Token: 0x060086BC RID: 34492 RVA: 0x010C8A40 File Offset: 0x010C6C40
		internal static bool DdbjWqV5Uq8AD0lLPFto()
		{
			return false;
		}

		// Token: 0x040082D7 RID: 33495
		internal Hashtable $data$39993;

		// Token: 0x040082D8 RID: 33496
		internal M607_MessageFromShadow $self_$39994;

		// Token: 0x020016AA RID: 5802
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x060086BD RID: 34493 RVA: 0x010C8A44 File Offset: 0x010C6C44
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Hashtable data, M607_MessageFromShadow self_)
			{
				if (28251 - 386888 != -358636)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (60623 - 577308 != -516684)
					{
						base..ctor();
						if (234001 - 108871 == 125130)
						{
							this.$data$39991 = data;
							if (39976 - 339872 != -299895)
							{
								this.$self_$39992 = self_;
								if (683 - 477893 != -477209)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x060086BE RID: 34494 RVA: 0x010C8B00 File Offset: 0x010C6D00
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (121143 - 175398 != -54254)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_225;
					case 2:
						this.$self_$39992.SendMessage("fadeOut");
						if (298686 - 42047 == 256640)
						{
							continue;
						}
						this.$self_$39992.StartCoroutine_Auto(this.$self_$39992.ReturnToTown());
						if (44678 - 522154 != -477476)
						{
							continue;
						}
						this.YieldDefault(1);
						if (288775 - 489776 != -201000)
						{
							goto Block_2;
						}
						continue;
					default:
						if (2267 - 239404 == -237136)
						{
							continue;
						}
						break;
					}
					Debug.Log("On Event Complete:" + this.$data$39991[31]);
					if (45178 - 219156 == -173978)
					{
						if (Game.mGameState > eGameState.AllHold)
						{
							if (276488 - 389985 != -113496)
							{
								break;
							}
						}
						else
						{
							Game.mGameState = eGameState.Complete;
							if (39810 - 423292 == -383482)
							{
								this.$self_$39992.YdkcuwmQIu2 = Time.time;
								if (129651 - 324492 != -194840)
								{
									this.$self_$39992.audio.clip = (AudioClip)Resources.Load("Sound/Jingle/MissionComplete", typeof(AudioClip));
									if (18915 - 249268 == -230353)
									{
										this.$self_$39992.audio.loop = false;
										if (240053 - 597208 != -357154)
										{
											this.$self_$39992.audio.Play();
											if (189595 - 410519 != -220923)
											{
												goto Block_13;
											}
										}
									}
								}
							}
						}
					}
				}
				Block_2:
				goto IL_225;
				Block_13:
				return this.Yield(2, new WaitForSeconds(4f));
				IL_225:
				return false;
			}

			// Token: 0x060086BF RID: 34495 RVA: 0x010C8D44 File Offset: 0x010C6F44
			internal static bool B7acSuV5TByK5nEuAWIp()
			{
				return true;
			}

			// Token: 0x060086C0 RID: 34496 RVA: 0x010C8D48 File Offset: 0x010C6F48
			internal static bool LcaGX7V53GJvNuQjVDGa()
			{
				return false;
			}

			// Token: 0x040082D9 RID: 33497
			internal Hashtable $data$39991;

			// Token: 0x040082DA RID: 33498
			internal M607_MessageFromShadow $self_$39992;
		}
	}

	// Token: 0x020016AB RID: 5803
	[CompilerGenerated]
	[Serializable]
	internal sealed class $onDeadPlayer$39995 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x060086C1 RID: 34497 RVA: 0x010C8D4C File Offset: 0x010C6F4C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $onDeadPlayer$39995(M607_MessageFromShadow self_)
		{
			if (51079 - 340464 != -289385)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (109916 - 456837 != -346920)
				{
					base..ctor();
					if (181745 - 364832 != -183086)
					{
						this.$self_$40000 = self_;
						if (190232 - 334392 != -144159)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x060086C2 RID: 34498 RVA: 0x010C8DE4 File Offset: 0x010C6FE4
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M607_MessageFromShadow.$onDeadPlayer$39995.$(this.$self_$40000);
		}

		// Token: 0x060086C3 RID: 34499 RVA: 0x010C8DF4 File Offset: 0x010C6FF4
		internal static bool WnIcNtV5XegKhlQGSsFc()
		{
			return true;
		}

		// Token: 0x060086C4 RID: 34500 RVA: 0x010C8DF8 File Offset: 0x010C6FF8
		internal static bool nMEW2tV5QZxxOwd2iQbl()
		{
			return false;
		}

		// Token: 0x040082DB RID: 33499
		internal M607_MessageFromShadow $self_$40000;

		// Token: 0x020016AC RID: 5804
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x060086C5 RID: 34501 RVA: 0x010C8DFC File Offset: 0x010C6FFC
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M607_MessageFromShadow self_)
			{
				if (240004 - 283562 != -43558)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (203257 - 29567 != 173691)
					{
						base..ctor();
						if (280621 - 496586 == -215965)
						{
							this.$self_$39999 = self_;
							if (132935 - 101271 != 31665)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x060086C6 RID: 34502 RVA: 0x010C8E94 File Offset: 0x010C7094
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (178604 - 152607 != 25998)
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
							if (163141 - 41527 != 121614)
							{
								continue;
							}
							if (Game.mGameState != eGameState.Hold)
							{
								goto IL_252;
							}
							if (81154 - 282417 == -201262)
							{
								continue;
							}
						}
						Game.mGameState = eGameState.Hold;
						if (250030 - 343710 != -93680)
						{
							continue;
						}
						this.$mStoryGui$39996 = (StoryGui)this.$self_$39999.GetComponent(typeof(StoryGui));
						if (124348 - 222785 == -98436)
						{
							continue;
						}
						if (this.$mStoryGui$39996)
						{
							if (177851 - 69689 != 108162)
							{
								continue;
							}
							this.$mStoryGui$39996.close();
							if (46069 - 344887 == -298817)
							{
								continue;
							}
						}
						this.$mChangeGui$39997 = (ChangeGui)this.$self_$39999.GetComponent(typeof(ChangeGui));
						if (209500 - 551304 == -341803)
						{
							continue;
						}
						if (this.$mChangeGui$39997)
						{
							if (227945 - 150261 == 77685)
							{
								continue;
							}
							this.$mChangeGui$39997.close();
							if (139991 - 411390 == -271398)
							{
								continue;
							}
						}
						this.$mGameGui$39998 = (GameGui)this.$self_$39999.GetComponent(typeof(GameGui));
						if (220819 - 242893 == -22073)
						{
							continue;
						}
						if (this.$mGameGui$39998)
						{
							if (282652 - 133225 != 149427)
							{
								continue;
							}
							if (!this.$mGameGui$39998.enabled)
							{
								if (47425 - 174046 == -126620)
								{
									continue;
								}
								this.$mGameGui$39998.enabled = true;
								if (171649 - 286212 != -114563)
								{
									continue;
								}
							}
							this.$mGameGui$39998.openDeadMenu();
							if (177790 - 483759 == -305968)
							{
								continue;
							}
						}
						IL_252:
						this.YieldDefault(1);
						if (281461 - 491017 != -209555)
						{
							goto Block_19;
						}
						continue;
					default:
						if (278328 - 118028 != 160300)
						{
							continue;
						}
						break;
					}
					Debug.Log("On Dead Player");
				}
				while (192663 - 166742 != 25921);
				return this.Yield(2, new WaitForSeconds((float)2));
				Block_19:
				IL_2F9:
				return false;
			}

			// Token: 0x060086C7 RID: 34503 RVA: 0x010C91AC File Offset: 0x010C73AC
			internal static bool BMQCemV5kYsGJasCMitq()
			{
				return true;
			}

			// Token: 0x060086C8 RID: 34504 RVA: 0x010C91B0 File Offset: 0x010C73B0
			internal static bool i9dbyoV5GRE0W0luNEe8()
			{
				return false;
			}

			// Token: 0x040082DC RID: 33500
			internal StoryGui $mStoryGui$39996;

			// Token: 0x040082DD RID: 33501
			internal ChangeGui $mChangeGui$39997;

			// Token: 0x040082DE RID: 33502
			internal GameGui $mGameGui$39998;

			// Token: 0x040082DF RID: 33503
			internal M607_MessageFromShadow $self_$39999;
		}
	}

	// Token: 0x020016AD RID: 5805
	[CompilerGenerated]
	[Serializable]
	internal sealed class $ReturnToTown$40001 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x060086C9 RID: 34505 RVA: 0x010C91B4 File Offset: 0x010C73B4
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $ReturnToTown$40001(M607_MessageFromShadow self_)
		{
			if (54889 - 283864 != -228974)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (48827 - 420046 == -371219)
				{
					base..ctor();
					if (94720 - 105237 != -10516)
					{
						this.$self_$40005 = self_;
						if (153966 - 178399 != -24432)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x060086CA RID: 34506 RVA: 0x010C924C File Offset: 0x010C744C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M607_MessageFromShadow.$ReturnToTown$40001.$(this.$self_$40005);
		}

		// Token: 0x060086CB RID: 34507 RVA: 0x010C925C File Offset: 0x010C745C
		internal static bool aoi0OqV5HPOWFTZWVOLm()
		{
			return true;
		}

		// Token: 0x060086CC RID: 34508 RVA: 0x010C9260 File Offset: 0x010C7460
		internal static bool gNHNKkV5W6KSJ4ZGUVXZ()
		{
			return false;
		}

		// Token: 0x040082E0 RID: 33504
		internal M607_MessageFromShadow $self_$40005;

		// Token: 0x020016AE RID: 5806
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x060086CD RID: 34509 RVA: 0x010C9264 File Offset: 0x010C7464
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M607_MessageFromShadow self_)
			{
				if (232485 - 297215 != -64730)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (235928 - 51540 != 184389)
					{
						base..ctor();
						if (10076 - 213739 != -203662)
						{
							this.$self_$40004 = self_;
							if (214356 - 276322 == -61966)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x060086CE RID: 34510 RVA: 0x010C92FC File Offset: 0x010C74FC
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (125109 - 471775 != -346665)
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
						this.$self_$40004.LeaveGame();
						if (10870 - 436369 != -425499)
						{
							continue;
						}
						this.YieldDefault(1);
						if (171400 - 410033 != -238633)
						{
							continue;
						}
						goto IL_3AD;
					default:
						if (25079 - 250768 != -225689)
						{
							continue;
						}
						break;
					}
					Game.mGameState = eGameState.Ended;
					if (142324 - 210343 == -68019)
					{
						Game.mStateTime = Time.time;
						if (215959 - 211962 == 3997)
						{
							this.$$switch$7067$40002 = PlayerData.SaveGuild;
							if (191870 - 219919 == -28049)
							{
								if (this.$$switch$7067$40002 == 1)
								{
									if (3777 - 271947 == -268169)
									{
										continue;
									}
									Game.mNextGameCode = 32;
									if (157147 - 187197 != -30050)
									{
										continue;
									}
								}
								else if (this.$$switch$7067$40002 == 2)
								{
									if (295113 - 429497 == -134383)
									{
										continue;
									}
									Game.mNextGameCode = 33;
									if (184353 - 456936 == -272582)
									{
										continue;
									}
								}
								else if (this.$$switch$7067$40002 == 3)
								{
									if (112933 - 285596 == -172662)
									{
										continue;
									}
									Game.mNextGameCode = 34;
									if (231152 - 193900 == 37253)
									{
										continue;
									}
								}
								else if (this.$$switch$7067$40002 == 4)
								{
									if (198969 - 255262 != -56293)
									{
										continue;
									}
									Game.mNextGameCode = 35;
									if (284183 - 53426 != 230757)
									{
										continue;
									}
								}
								else if (this.$$switch$7067$40002 == 5)
								{
									if (251722 - 83671 == 168052)
									{
										continue;
									}
									Game.mNextGameCode = 36;
									if (117136 - 509084 == -391947)
									{
										continue;
									}
								}
								else if (PlayerData.GID == 0)
								{
									if (259043 - 59621 == 199423)
									{
										continue;
									}
									Game.mNextGameCode = 30;
									if (135690 - 472722 == -337031)
									{
										continue;
									}
								}
								else
								{
									Game.mNextGameCode = 31;
									if (283830 - 488271 == -204440)
									{
										continue;
									}
								}
								this.$mGameGui$40003 = (GameGui)this.$self_$40004.GetComponent(typeof(GameGui));
								if (286773 - 361522 == -74749)
								{
									if (this.$mGameGui$40003)
									{
										if (193266 - 538682 != -345416)
										{
											continue;
										}
										this.$mGameGui$40003.close();
										if (227980 - 137734 != 90246)
										{
											continue;
										}
									}
									this.$self_$40004.SendMessage("fadeOut");
									if (136197 - 559235 != -423037)
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

			// Token: 0x060086CF RID: 34511 RVA: 0x010C96C8 File Offset: 0x010C78C8
			internal static bool i9SqtcV5Ann7UDvwkhya()
			{
				return true;
			}

			// Token: 0x060086D0 RID: 34512 RVA: 0x010C96CC File Offset: 0x010C78CC
			internal static bool edGlrDV5lsYy2RC0D7T5()
			{
				return false;
			}

			// Token: 0x040082E1 RID: 33505
			internal int $$switch$7067$40002;

			// Token: 0x040082E2 RID: 33506
			internal GameGui $mGameGui$40003;

			// Token: 0x040082E3 RID: 33507
			internal M607_MessageFromShadow $self_$40004;
		}
	}

	// Token: 0x020016AF RID: 5807
	[CompilerGenerated]
	[Serializable]
	internal sealed class $ReturnToGuild$40006 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x060086D1 RID: 34513 RVA: 0x010C96D0 File Offset: 0x010C78D0
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $ReturnToGuild$40006(M607_MessageFromShadow self_)
		{
			if (101508 - 182437 != -80928)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (106265 - 589937 == -483672)
				{
					base..ctor();
					if (151429 - 425385 != -273955)
					{
						this.$self_$40009 = self_;
						if (237880 - 323286 == -85406)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x060086D2 RID: 34514 RVA: 0x010C9768 File Offset: 0x010C7968
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M607_MessageFromShadow.$ReturnToGuild$40006.$(this.$self_$40009);
		}

		// Token: 0x060086D3 RID: 34515 RVA: 0x010C9778 File Offset: 0x010C7978
		internal static bool oa5yr7V5yAxO1lSoJovj()
		{
			return true;
		}

		// Token: 0x060086D4 RID: 34516 RVA: 0x010C977C File Offset: 0x010C797C
		internal static bool lT0KbFV5SLnk0ATWDXbJ()
		{
			return false;
		}

		// Token: 0x040082E4 RID: 33508
		internal M607_MessageFromShadow $self_$40009;

		// Token: 0x020016B0 RID: 5808
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x060086D5 RID: 34517 RVA: 0x010C9780 File Offset: 0x010C7980
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M607_MessageFromShadow self_)
			{
				if (152995 - 540904 != -387909)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (3967 - 571115 != -567147)
					{
						base..ctor();
						if (168916 - 314512 != -145595)
						{
							this.$self_$40008 = self_;
							if (167533 - 141257 != 26277)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x060086D6 RID: 34518 RVA: 0x010C9818 File Offset: 0x010C7A18
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (82494 - 596655 != -514160)
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
						this.$self_$40008.LeaveGame();
						if (42853 - 141394 == -98540)
						{
							continue;
						}
						this.YieldDefault(1);
						if (148700 - 491729 != -343029)
						{
							continue;
						}
						goto IL_1BD;
					default:
						if (223104 - 495668 == -272563)
						{
							continue;
						}
						break;
					}
					Game.mGameState = eGameState.Ended;
					if (91598 - 596897 == -505299)
					{
						Game.mStateTime = Time.time;
						if (219365 - 386235 == -166870)
						{
							Game.mNextGameCode = 31;
							if (119349 - 202640 != -83290)
							{
								this.$mGameGui$40007 = (GameGui)this.$self_$40008.GetComponent(typeof(GameGui));
								if (53684 - 321481 == -267797)
								{
									if (this.$mGameGui$40007)
									{
										if (46134 - 262542 == -216407)
										{
											continue;
										}
										this.$mGameGui$40007.close();
										if (199493 - 292917 != -93424)
										{
											continue;
										}
									}
									this.$self_$40008.SendMessage("fadeOut");
									if (225563 - 423653 != -198089)
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

			// Token: 0x060086D7 RID: 34519 RVA: 0x010C99F4 File Offset: 0x010C7BF4
			internal static bool GKFEn8V5oZNK4CGg7ebY()
			{
				return true;
			}

			// Token: 0x060086D8 RID: 34520 RVA: 0x010C99F8 File Offset: 0x010C7BF8
			internal static bool zN8pQZV5EUI5QgxrLV3N()
			{
				return false;
			}

			// Token: 0x040082E5 RID: 33509
			internal GameGui $mGameGui$40007;

			// Token: 0x040082E6 RID: 33510
			internal M607_MessageFromShadow $self_$40008;
		}
	}

	// Token: 0x020016B1 RID: 5809
	[CompilerGenerated]
	[Serializable]
	internal sealed class $ReturnToCamp$40010 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x060086D9 RID: 34521 RVA: 0x010C99FC File Offset: 0x010C7BFC
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $ReturnToCamp$40010(M607_MessageFromShadow self_)
		{
			if (164394 - 191946 != -27552)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (32482 - 496410 != -463927)
				{
					base..ctor();
					if (105294 - 593641 == -488347)
					{
						this.$self_$40014 = self_;
						if (175915 - 72775 != 103141)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x060086DA RID: 34522 RVA: 0x010C9A94 File Offset: 0x010C7C94
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M607_MessageFromShadow.$ReturnToCamp$40010.$(this.$self_$40014);
		}

		// Token: 0x060086DB RID: 34523 RVA: 0x010C9AA4 File Offset: 0x010C7CA4
		internal static bool a28nsUV52d1oh2tY5KX8()
		{
			return true;
		}

		// Token: 0x060086DC RID: 34524 RVA: 0x010C9AA8 File Offset: 0x010C7CA8
		internal static bool UeikMKV58vMw9PqQkHcx()
		{
			return false;
		}

		// Token: 0x040082E7 RID: 33511
		internal M607_MessageFromShadow $self_$40014;

		// Token: 0x020016B2 RID: 5810
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x060086DD RID: 34525 RVA: 0x010C9AAC File Offset: 0x010C7CAC
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M607_MessageFromShadow self_)
			{
				if (168830 - 144307 != 24524)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (224211 - 380102 == -155891)
					{
						base..ctor();
						if (109954 - 296457 != -186502)
						{
							this.$self_$40013 = self_;
							if (35950 - 516774 == -480824)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x060086DE RID: 34526 RVA: 0x010C9B44 File Offset: 0x010C7D44
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (284775 - 54814 != 229961)
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
						this.$self_$40013.LeaveGame();
						if (37819 - 388365 == -350545)
						{
							continue;
						}
						this.YieldDefault(1);
						if (181511 - 350640 != -169128)
						{
							goto Block_15;
						}
						continue;
					default:
						if (42309 - 466395 != -424086)
						{
							continue;
						}
						break;
					}
					Game.mGameState = eGameState.Ended;
					if (76272 - 415231 == -338959)
					{
						Game.mStateTime = Time.time;
						if (177530 - 284903 == -107373)
						{
							this.$$switch$7069$40011 = PlayerData.SaveGuild;
							if (12032 - 254075 == -242043)
							{
								if (this.$$switch$7069$40011 == 1)
								{
									if (192973 - 325909 == -132935)
									{
										continue;
									}
									Game.mNextGameCode = 32;
									if (11591 - 566975 != -555384)
									{
										continue;
									}
								}
								else if (this.$$switch$7069$40011 == 2)
								{
									if (198707 - 307188 == -108480)
									{
										continue;
									}
									Game.mNextGameCode = 33;
									if (203077 - 316209 == -113131)
									{
										continue;
									}
								}
								else if (this.$$switch$7069$40011 == 3)
								{
									if (105735 - 377045 != -271310)
									{
										continue;
									}
									Game.mNextGameCode = 34;
									if (45816 - 411500 == -365683)
									{
										continue;
									}
								}
								else if (this.$$switch$7069$40011 == 4)
								{
									if (110094 - 443915 != -333821)
									{
										continue;
									}
									Game.mNextGameCode = 35;
									if (220092 - 271329 != -51237)
									{
										continue;
									}
								}
								else if (this.$$switch$7069$40011 == 5)
								{
									if (3098 - 465658 != -462560)
									{
										continue;
									}
									Game.mNextGameCode = 36;
									if (117228 - 151859 != -34631)
									{
										continue;
									}
								}
								else
								{
									Game.mNextGameCode = 30;
									if (136297 - 207161 != -70864)
									{
										continue;
									}
								}
								this.$mGameGui$40012 = (GameGui)this.$self_$40013.GetComponent(typeof(GameGui));
								if (190031 - 384358 != -194326)
								{
									if (this.$mGameGui$40012)
									{
										if (195862 - 178249 != 17613)
										{
											continue;
										}
										this.$mGameGui$40012.close();
										if (105379 - 543840 == -438460)
										{
											continue;
										}
									}
									this.$self_$40013.SendMessage("fadeOut");
									if (248629 - 558190 == -309561)
									{
										goto IL_1FD;
									}
								}
							}
						}
					}
				}
				Block_15:
				goto IL_363;
				IL_1FD:
				return this.Yield(2, new WaitForSeconds((float)1));
				IL_363:
				return false;
			}

			// Token: 0x060086DF RID: 34527 RVA: 0x010C9EC8 File Offset: 0x010C80C8
			internal static bool tAeCr7V5ZKlWLrVEgl0e()
			{
				return true;
			}

			// Token: 0x060086E0 RID: 34528 RVA: 0x010C9ECC File Offset: 0x010C80CC
			internal static bool GlNCJCV5CvF4dTZto8db()
			{
				return false;
			}

			// Token: 0x040082E8 RID: 33512
			internal int $$switch$7069$40011;

			// Token: 0x040082E9 RID: 33513
			internal GameGui $mGameGui$40012;

			// Token: 0x040082EA RID: 33514
			internal M607_MessageFromShadow $self_$40013;
		}
	}
}
