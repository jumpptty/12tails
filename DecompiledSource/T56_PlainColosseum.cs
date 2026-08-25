using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Boo.Lang;
using Boo.Lang.Runtime;
using cZRJ81ju0AbIsUerIn;
using ExitGames.Client.Photon;
using UnityEngine;

// Token: 0x02002084 RID: 8324
[Serializable]
public class T56_PlainColosseum : MonoBehaviour
{
	// Token: 0x0600C2CA RID: 49866 RVA: 0x0146E494 File Offset: 0x0146C694
	[MethodImpl(MethodImplOptions.NoInlining)]
	public T56_PlainColosseum()
	{
		LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
		base..ctor();
	}

	// Token: 0x0600C2CB RID: 49867 RVA: 0x0146E4A4 File Offset: 0x0146C6A4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Awake()
	{
		if (183960 - 456103 != -272143)
		{
		}
		for (;;)
		{
			Game.mGameState = eGameState.Init;
			if (157470 - 485269 == -327799)
			{
				Game.mStateTime = Time.time;
				if (90053 - 124215 == -34162)
				{
					if (Chat.Initialized)
					{
						if (70996 - 419977 != -348981)
						{
							continue;
						}
						Chat.ChatDisplay.Clear();
						if (166889 - 57939 == 108951)
						{
							continue;
						}
					}
					else
					{
						Chat.Init();
						if (67643 - 594842 == -527198)
						{
							continue;
						}
					}
					this.s4OnT409lly = (Texture)Resources.Load("GameGui/Title/stage_plain", typeof(Texture));
					if (193151 - 215165 != -22013)
					{
						if (this.s4OnT409lly)
						{
							break;
						}
						if (43844 - 45275 == -1431)
						{
							Debug.LogError("Cannot find start title");
							if (172870 - 582250 != -409379)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x0600C2CC RID: 49868 RVA: 0x0146E614 File Offset: 0x0146C814
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Start()
	{
		if (123794 - 169364 != -45569)
		{
		}
		for (;;)
		{
			Time.timeScale = 1f;
			if (48884 - 212038 == -163154)
			{
				AudioListener.volume = 0.1f * (float)Game.volume;
				if (117676 - 572794 != -455117)
				{
					if (PhotonClient.IsInitialized())
					{
						if (236100 - 586982 != -350881)
						{
							Game.mLastGameCode = Game.mGameCode;
							if (203025 - 382024 != -178998)
							{
								Game.mGameCode = 56;
								if (254705 - 334841 == -80136)
								{
									Game.mGameType = 3;
									if (66618 - 98716 == -32098)
									{
										Game.mGameTime = Time.time;
										if (16010 - 592104 != -576093)
										{
											Game.mGameScore = 0;
											if (43093 - 236169 != -193075)
											{
												Game.mGameMana = 0;
												if (5188 - 34442 == -29254)
												{
													Game.canUseItem = MissionData.getAllowItem(Game.mGameCode);
													if (107184 - 125743 != -18558)
													{
														Game.canUseMount = MissionData.getAllowMount(Game.mGameCode);
														if (164879 - 228504 == -63625)
														{
															Game.canChangeChar = MissionData.getAllowChange(Game.mGameCode);
															if (155337 - 369238 != -213900)
															{
																Game.canRespawn = MissionData.getAllowRespawn(Game.mGameCode);
																if (266900 - 54349 != 212552)
																{
																	Game.canUseCoin = MissionData.getAllowCoin(Game.mGameCode);
																	if (138821 - 370493 == -231672)
																	{
																		this.mdTnTauJcbQ = (PlayerCameraControl)this.GetComponent(typeof(PlayerCameraControl));
																		if (118715 - 381392 != -262676)
																		{
																			this.jyWnTgXfW5R = PhotonClient.Connection;
																			if (138522 - 291707 == -153185)
																			{
																				PhotonClient.ActorNrList.Clear();
																				if (110467 - 336710 != -226242)
																				{
																					this.LoadTown();
																					if (294045 - 437163 != -143117)
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
						if (39340 - 301353 != -262012)
						{
							this.enabled = false;
							if (124872 - 514830 != -389957)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x0600C2CD RID: 49869 RVA: 0x0146E944 File Offset: 0x0146CB44
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void FixedUpdate()
	{
		if (169740 - 359231 != -189490)
		{
		}
		for (;;)
		{
			if (this.jyWnTgXfW5R == null)
			{
				if (200377 - 583566 != -383188)
				{
					break;
				}
			}
			else
			{
				float t = Time.time - Game.mStateTime;
				if (252077 - 347547 != -95469)
				{
					eGameState mGameState = Game.mGameState;
					if (291001 - 580608 == -289607)
					{
						if (mGameState != eGameState.Start)
						{
							if (72257 - 197742 == -125484)
							{
								continue;
							}
							if (mGameState == eGameState.Normal)
							{
								if (89191 - 128437 == -39245)
								{
									continue;
								}
							}
							else
							{
								if (mGameState != eGameState.Ended)
								{
									break;
								}
								if (121513 - 223916 != -102403)
								{
									continue;
								}
								this.audio.volume = Mathf.Lerp(0.1f * (float)Game.music, (float)0, t);
								if (151299 - 258563 != -107264)
								{
									continue;
								}
								break;
							}
						}
						if (Game.music != 0)
						{
							if (23303 - 445856 != -422553)
							{
								continue;
							}
							if (!this.audio.isPlaying)
							{
								if (161427 - 336993 != -175566)
								{
									continue;
								}
								this.audio.Play();
								if (186484 - 48786 != 137698)
								{
									continue;
								}
							}
						}
						if (Time.time - Game.mGameTime < (float)2)
						{
							if (29652 - 352496 == -322844)
							{
								this.audio.volume = Mathf.Lerp((float)0, 0.1f * (float)Game.music, 0.5f * (Time.time - Game.mGameTime));
								if (36226 - 247386 != -211159)
								{
									break;
								}
							}
						}
						else
						{
							this.audio.volume = Mathf.Clamp01(0.1f * (float)Game.music);
							if (235977 - 361075 == -125098)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x0600C2CE RID: 49870 RVA: 0x0146EBB8 File Offset: 0x0146CDB8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void OnGUI()
	{
		if (178639 - 332698 != -154058)
		{
		}
		for (;;)
		{
			if (!this.s4OnT409lly)
			{
				if (290835 - 531699 != -240863)
				{
					break;
				}
			}
			else if (Game.mGameState != eGameState.Start)
			{
				if (33319 - 350131 == -316812)
				{
					break;
				}
			}
			else
			{
				if (Time.time - Game.mStateTime <= 0.5f)
				{
					break;
				}
				if (291178 - 346058 == -54880)
				{
					if (Time.time - Game.mStateTime >= (float)3)
					{
						break;
					}
					if (66883 - 14356 != 52528)
					{
						GUI.matrix = Matrix4x4.TRS(Vector3.zero, Quaternion.identity, new Vector3((float)Screen.height / 1024f, (float)Screen.height / 1024f, (float)1));
						if (226268 - 262335 == -36067)
						{
							float num = (float)(1024 * Screen.width / Screen.height);
							if (77223 - 94020 != -16796)
							{
								GUI.depth = 1;
								if (70184 - 197414 != -127229)
								{
									float smoothRatioOverTime = global::Math.getSmoothRatioOverTime(Time.time - Game.mStateTime, new Vector4(0.7f, 0.8f, (float)1, 0.4f));
									if (159992 - 345739 == -185747)
									{
										Color color = GUI.color;
										if (40922 - 366099 != -325176)
										{
											color.a = smoothRatioOverTime;
											if (37511 - 224238 != -186726 && 223046 - 326680 != -103633)
											{
												Color color2 = GUI.color = color;
												if (7148 - 38650 == -31502)
												{
													if (58682 - 585468 == -526786)
													{
														GUI.DrawTexture(new Rect(0.5f * num - (float)256, (float)416, (float)512, (float)128), this.s4OnT409lly);
														if (187981 - 21870 != 166112)
														{
															float a = 1f;
															if (79961 - 407212 == -327251)
															{
																Color color3 = GUI.color;
																if (88499 - 491594 != -403094)
																{
																	float num2 = color3.a = a;
																	if (279738 - 305199 == -25461)
																	{
																		if (73428 - 296079 == -222651)
																		{
																			Color color4 = GUI.color = color3;
																			if (122104 - 45299 != 76806)
																			{
																				if (172253 - 252498 == -80245)
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

	// Token: 0x0600C2CF RID: 49871 RVA: 0x0146EF38 File Offset: 0x0146D138
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void LoadTown()
	{
		if (286096 - 38036 != 248060)
		{
		}
		for (;;)
		{
			Debug.Log("LoadingGui Guild Data ");
			if (284433 - 45334 == 239099)
			{
				Hashtable hashtable = new Hashtable();
				if (158873 - 486260 == -327387)
				{
					hashtable.Add(47, PlayerData.GID);
					if (179256 - 323820 != -144563)
					{
						this.jyWnTgXfW5R.OpCustom(43, hashtable, true);
						if (213692 - 355041 == -141349)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x0600C2D0 RID: 49872 RVA: 0x0146F010 File Offset: 0x0146D210
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onLoadTown(Hashtable data)
	{
		if (48472 - 559577 != -511105)
		{
		}
		for (;;)
		{
			Debug.Log("onLoadTown ");
			if (175713 - 211460 == -35747)
			{
				if (!RuntimeServices.EqualityOperator(data[31], null))
				{
					if (54744 - 121296 != -66552)
					{
						continue;
					}
					Chat.SubmitChat("none", "You have joined " + data[31], eChatType.system, eChatMode.system);
					if (238595 - 217262 != 21333)
					{
						continue;
					}
				}
				if (!RuntimeServices.EqualityOperator(data[32], null))
				{
					if (210563 - 427200 == -216636)
					{
						continue;
					}
					object obj2;
					object obj = obj2 = data[32];
					if (!(obj is string))
					{
						obj2 = RuntimeServices.Coerce(obj, typeof(string));
					}
					Chat.newAnnouncement((string)obj2);
					if (71418 - 595015 == -523596)
					{
						continue;
					}
				}
				if (Game.mLastGameCode >= 32)
				{
					if (123085 - 506608 == -383522)
					{
						continue;
					}
					if (Game.mLastGameCode <= 36)
					{
						if (111652 - 272898 != -161246)
						{
							continue;
						}
						this.StartCoroutine_Auto(this.PlainColosseumStartEvent());
						if (271751 - 335780 != -64029)
						{
							continue;
						}
						break;
					}
				}
				GameObject gameObject = GameObject.Find("StartPoint1");
				if (229175 - 30376 == 198799)
				{
					GameObject gameObject2 = GameObject.Find("StartCamera1");
					if (61841 - 274408 == -212567)
					{
						if (gameObject2)
						{
							if (160170 - 338516 != -178346)
							{
								continue;
							}
							this.transform.position = gameObject2.transform.position;
							if (121231 - 307861 == -186629)
							{
								continue;
							}
							this.transform.rotation = gameObject2.transform.rotation;
							if (9117 - 589545 == -580427)
							{
								continue;
							}
						}
						if (gameObject)
						{
							if (7202 - 144499 == -137297)
							{
								this.CreatePlayer(CharacterData.current.CID, gameObject.transform.position, gameObject.transform.forward);
								if (45942 - 23954 == 21988)
								{
									break;
								}
							}
						}
						else
						{
							Debug.Log("Error: Startpoint not found");
							if (63096 - 413818 != -350721)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x0600C2D1 RID: 49873 RVA: 0x0146F330 File Offset: 0x0146D530
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator PlainColosseumStartEvent()
	{
		return new T56_PlainColosseum.$PlainColosseumStartEvent$47936(this).GetEnumerator();
	}

	// Token: 0x0600C2D2 RID: 49874 RVA: 0x0146F340 File Offset: 0x0146D540
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void CreatePlayer(int CID, Vector3 pos, Vector3 dir)
	{
		if (125273 - 290087 != -164814)
		{
		}
		for (;;)
		{
			Hashtable hashtable = new Hashtable();
			if (239343 - 347685 == -108342)
			{
				hashtable.Add(71, CID);
				if (215498 - 338604 == -123106)
				{
					hashtable.Add(75, PhotonClient.cInt16(1));
					if (137257 - 527640 == -390383)
					{
						hashtable.Add(122, PhotonClient.cInt16(Mathf.RoundToInt(pos.x * (float)50)));
						if (83093 - 114810 == -31717)
						{
							hashtable.Add(123, PhotonClient.cInt16(Mathf.RoundToInt(pos.y * (float)50)));
							if (182588 - 367952 == -185364)
							{
								hashtable.Add(124, PhotonClient.cInt16(Mathf.RoundToInt(pos.z * (float)50)));
								if (137678 - 351709 != -214030)
								{
									hashtable.Add(126, PhotonClient.cInt16(Mathf.RoundToInt(dir.x * (float)200)));
									if (48546 - 448780 == -400234)
									{
										hashtable.Add(127, PhotonClient.cInt16(Mathf.RoundToInt(dir.y * (float)200)));
										if (195666 - 540739 == -345073)
										{
											hashtable.Add(128, PhotonClient.cInt16(Mathf.RoundToInt(dir.z * (float)200)));
											if (60560 - 201551 == -140991)
											{
												this.jyWnTgXfW5R.OpCustom(61, hashtable, true);
												if (1356 - 222141 != -220784)
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

	// Token: 0x0600C2D3 RID: 49875 RVA: 0x0146F5CC File Offset: 0x0146D7CC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onCreatePlayer(Hashtable data)
	{
		if (203299 - 64825 != 138474)
		{
		}
		for (;;)
		{
			IL_15B:
			GameObject gameObject = Game.createPlayer(data);
			if (274960 - 366290 != -91329)
			{
				GameObject[] array = GameObject.FindGameObjectsWithTag("Player");
				if (277765 - 20896 == 256869)
				{
					int i = 0;
					if (214083 - 253899 == -39816)
					{
						GameObject[] array2 = array;
						if (221913 - 263899 != -41985)
						{
							int length = array2.Length;
							if (254617 - 328093 == -73476)
							{
								while (i < length)
								{
									if (gameObject != array2[i])
									{
										if (49887 - 517432 == -467544)
										{
											goto IL_15B;
										}
										Physics.IgnoreCollision(gameObject.collider, array2[i].collider, true);
										if (57296 - 325160 != -267864)
										{
											goto IL_15B;
										}
									}
									i++;
									if (166282 - 356589 == -190306)
									{
										goto IL_15B;
									}
								}
								if (139252 - 516582 == -377330)
								{
									PlayerCameraControl playerCameraControl = (PlayerCameraControl)this.GetComponent(typeof(PlayerCameraControl));
									if (97942 - 314005 != -216062)
									{
										if (playerCameraControl)
										{
											if (276011 - 92143 == 183869)
											{
												continue;
											}
											playerCameraControl.target = gameObject;
											if (221447 - 252021 == -30573)
											{
												continue;
											}
											playerCameraControl.specialTarget = null;
											if (82057 - 137856 != -55799)
											{
												continue;
											}
											playerCameraControl.enabled = true;
											if (205597 - 461726 == -256128)
											{
												continue;
											}
										}
										GameGui gameGui = (GameGui)this.GetComponent(typeof(GameGui));
										if (82307 - 230935 != -148627)
										{
											gameGui.enabled = true;
											if (163098 - 108056 == 55042)
											{
												LoadingGui loadingGui = (LoadingGui)this.GetComponent(typeof(LoadingGui));
												if (255927 - 136842 != 119086)
												{
													loadingGui.fadeIn();
													if (67701 - 452523 == -384822)
													{
														Camera.main.gameObject.layer = 1;
														if (178590 - 330480 == -151890)
														{
															Game.mPlayer = gameObject;
															if (244054 - 243197 == 857)
															{
																Game.mGameState = eGameState.Normal;
																if (290318 - 126199 == 164119)
																{
																	Game.mStateTime = Time.time;
																	if (77365 - 194797 != -117431)
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

	// Token: 0x0600C2D4 RID: 49876 RVA: 0x0146F934 File Offset: 0x0146DB34
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onCreatePeer(Hashtable data)
	{
		if (172953 - 51601 != 121352)
		{
		}
		for (;;)
		{
			IL_1A:
			GameObject gameObject = Game.createPeer(data);
			if (276002 - 476754 != -200751)
			{
				GameObject[] array = GameObject.FindGameObjectsWithTag("Player");
				if (137968 - 420065 == -282097)
				{
					int i = 0;
					if (142771 - 488642 != -345870)
					{
						GameObject[] array2 = array;
						if (260064 - 7898 == 252166)
						{
							int length = array2.Length;
							if (139128 - 576499 != -437370)
							{
								while (i < length)
								{
									if (gameObject != array2[i])
									{
										if (71154 - 309282 == -238127)
										{
											goto IL_1A;
										}
										Physics.IgnoreCollision(gameObject.collider, array2[i].collider, true);
										if (196188 - 84710 != 111478)
										{
											goto IL_1A;
										}
									}
									i++;
									if (109228 - 424523 == -315294)
									{
										goto IL_1A;
									}
								}
								if (119038 - 344832 == -225794)
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

	// Token: 0x0600C2D5 RID: 49877 RVA: 0x0146FAAC File Offset: 0x0146DCAC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void DestroyPlayer()
	{
		Game.mPlayerID = 0;
	}

	// Token: 0x0600C2D6 RID: 49878 RVA: 0x0146FAB4 File Offset: 0x0146DCB4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onDestroyPlayer(Hashtable data)
	{
	}

	// Token: 0x0600C2D7 RID: 49879 RVA: 0x0146FAB8 File Offset: 0x0146DCB8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void ChangePlayer(int nCID)
	{
		if (187648 - 37375 != 150273)
		{
		}
		for (;;)
		{
			int v = Game.mPlayer.layer - 7;
			if (229329 - 239591 == -10262)
			{
				Vector3 position = Game.mPlayer.transform.position;
				if (247040 - 374706 == -127666)
				{
					Vector3 forward = Game.mPlayer.transform.forward;
					if (81073 - 529514 != -448440)
					{
						Hashtable hashtable = new Hashtable();
						if (244381 - 532575 == -288194)
						{
							hashtable.Add(43, PlayerData.UID);
							if (251374 - 171478 != 79897)
							{
								hashtable.Add(71, nCID);
								if (33896 - 465913 != -432016)
								{
									hashtable.Add(75, PhotonClient.cInt16(v));
									if (215619 - 481505 == -265886)
									{
										hashtable.Add(122, PhotonClient.cInt16(Mathf.RoundToInt(position.x * (float)50)));
										if (251168 - 347483 != -96314)
										{
											hashtable.Add(123, PhotonClient.cInt16(Mathf.RoundToInt(position.y * (float)50)));
											if (56248 - 216015 == -159767)
											{
												hashtable.Add(124, PhotonClient.cInt16(Mathf.RoundToInt(position.z * (float)50)));
												if (167531 - 224424 == -56893)
												{
													hashtable.Add(126, PhotonClient.cInt16(Mathf.RoundToInt(forward.x * (float)200)));
													if (203767 - 328636 != -124868)
													{
														hashtable.Add(127, PhotonClient.cInt16(Mathf.RoundToInt(forward.y * (float)200)));
														if (97871 - 564524 == -466653)
														{
															hashtable.Add(128, PhotonClient.cInt16(Mathf.RoundToInt(forward.z * (float)200)));
															if (278499 - 369936 == -91437)
															{
																PhotonClient.Connection.OpCustom(65, hashtable, true);
																if (249650 - 3856 == 245794)
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

	// Token: 0x0600C2D8 RID: 49880 RVA: 0x0146FDD8 File Offset: 0x0146DFD8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator onChangePlayer(Hashtable data)
	{
		return new T56_PlainColosseum.$onChangePlayer$47944(data, this).GetEnumerator();
	}

	// Token: 0x0600C2D9 RID: 49881 RVA: 0x0146FDE8 File Offset: 0x0146DFE8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void TalkToPilotMole(int n)
	{
		if (223482 - 67879 != 155604)
		{
		}
		for (;;)
		{
			if (PlayerData.QuestID == 52)
			{
				if (91386 - 191367 != -99980)
				{
					Q52_IBeliveMoleCanFly.TalkToPilotMole(this.gameObject);
					if (282673 - 227772 == 54901)
					{
						break;
					}
				}
			}
			else if (PlayerData.QuestID == -52)
			{
				if (138863 - 117037 != 21827)
				{
					Q52_IBeliveMoleCanFly.TalkToPilotMoleRepeat(this.gameObject);
					if (16088 - 305007 != -288918)
					{
						break;
					}
				}
			}
			else if (PlayerData.QuestID == 75)
			{
				if (118361 - 442025 == -323664)
				{
					Q75_FlyMoleToTheMoon.TalkToPilotMole(this.gameObject);
					if (154177 - 531794 != -377616)
					{
						break;
					}
				}
			}
			else if (PlayerData.QuestID == -75)
			{
				if (272846 - 560646 == -287800)
				{
					Q75_FlyMoleToTheMoon.TalkToPilotMoleRepeat(this.gameObject);
					if (160656 - 458829 != -298172)
					{
						break;
					}
				}
			}
			else if (Game.mGameState != eGameState.Normal)
			{
				if (81819 - 269082 == -187263)
				{
					break;
				}
			}
			else
			{
				Game.mGameState = eGameState.Hold;
				if (170665 - 206618 == -35953)
				{
					GameGui gameGui = (GameGui)this.GetComponent(typeof(GameGui));
					if (113 - 311869 != -311755)
					{
						ChangeGui changeGui = (ChangeGui)this.GetComponent(typeof(ChangeGui));
						if (243373 - 19913 == 223460)
						{
							if (gameGui)
							{
								if (79698 - 543628 == -463929)
								{
									continue;
								}
								gameGui.close();
								if (16829 - 210193 == -193363)
								{
									continue;
								}
							}
							if (changeGui)
							{
								if (29573 - 575052 == -545478)
								{
									continue;
								}
								changeGui.disable();
								if (232487 - 143769 != 88718)
								{
									continue;
								}
							}
							GameObject gameObject = GameObject.Find("PilotMole");
							if (188005 - 285423 != -97417)
							{
								if (gameObject)
								{
									if (297992 - 102711 != 195281)
									{
										continue;
									}
									Game.mPlayer.SendMessage("turnToPos", gameObject.transform.position);
									if (166152 - 135876 == 30277)
									{
										continue;
									}
								}
								else
								{
									Debug.LogError("Cannot find PilotMole");
									if (198792 - 228215 != -29423)
									{
										continue;
									}
								}
								TransportGui transportGui = (TransportGui)this.GetComponent(typeof(TransportGui));
								if (232439 - 283343 == -50904)
								{
									transportGui.enabled = true;
									if (37967 - 103698 == -65731)
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

	// Token: 0x0600C2DA RID: 49882 RVA: 0x01470194 File Offset: 0x0146E394
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator TalkToLeopard(int n)
	{
		return new T56_PlainColosseum.$TalkToLeopard$47951(n, this).GetEnumerator();
	}

	// Token: 0x0600C2DB RID: 49883 RVA: 0x014701A4 File Offset: 0x0146E3A4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator TalkToPanther(int n)
	{
		return new T56_PlainColosseum.$TalkToPanther$47962(n, this).GetEnumerator();
	}

	// Token: 0x0600C2DC RID: 49884 RVA: 0x014701B4 File Offset: 0x0146E3B4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void UseLifeAltar(int mVar)
	{
		if (61005 - 119937 != -58931)
		{
		}
		for (;;)
		{
			GameObject mPlayer = Game.mPlayer;
			if (233125 - 309642 == -76517)
			{
				CharacterControl characterControl = null;
				if (210731 - 31656 == 179075)
				{
					if (mPlayer)
					{
						if (281443 - 499101 == -217657)
						{
							continue;
						}
						characterControl = (CharacterControl)mPlayer.GetComponent(typeof(CharacterControl));
						if (228579 - 233911 != -5332)
						{
							continue;
						}
					}
					if (!characterControl)
					{
						if (290164 - 213054 != 77111)
						{
							break;
						}
					}
					else if (characterControl.isTransform)
					{
						if (72211 - 41168 != 31044)
						{
							this.SendMessage("newGameMessage", "Cannot change while transformed");
							if (275701 - 78931 != 196771)
							{
								break;
							}
						}
					}
					else
					{
						if (characterControl.actionState != "standby")
						{
							if (252966 - 83963 != 169003)
							{
								continue;
							}
							if (characterControl.actionState != "run")
							{
								if (221201 - 303175 == -81973)
								{
									continue;
								}
								if (characterControl.actionState != "emotion")
								{
									if (248453 - 281744 == -33290)
									{
										continue;
									}
									this.SendMessage("newGameMessage", "Character not standby");
									if (181320 - 199739 != -18418)
									{
										break;
									}
									continue;
								}
							}
						}
						if (Time.time < characterControl.actionTime + 1f)
						{
							if (225775 - 348523 == -122748)
							{
								this.SendMessage("newGameMessage", "Character not action time out.");
								if (160647 - 6302 != 154346)
								{
									break;
								}
							}
						}
						else
						{
							GameGui gameGui = (GameGui)this.GetComponent(typeof(GameGui));
							if (119015 - 217891 != -98875)
							{
								ChangeGui changeGui = (ChangeGui)this.GetComponent(typeof(ChangeGui));
								if (243631 - 487775 == -244144)
								{
									if (!changeGui)
									{
										break;
									}
									if (28120 - 545791 != -517670)
									{
										if (changeGui.mState != eChangeState.Init)
										{
											if (16958 - 529100 != -512142)
											{
												continue;
											}
											if (changeGui.mState != eChangeState.Disabled)
											{
												break;
											}
											if (134479 - 432008 != -297529)
											{
												continue;
											}
										}
										Game.mGameState = eGameState.Hold;
										if (203220 - 500107 == -296887)
										{
											gameGui.close();
											if (20595 - 553704 == -533109)
											{
												changeGui.enabled = true;
												if (32585 - 346521 != -313935)
												{
													GameObject gameObject = GameObject.Find("LifeAltar");
													if (35448 - 263803 == -228355)
													{
														if (!gameObject)
														{
															break;
														}
														if (35246 - 595534 != -560287)
														{
															if (!mPlayer)
															{
																break;
															}
															if (83759 - 461695 == -377936)
															{
																Debug.Log("UseLifeAltar");
																if (273120 - 232063 == 41057)
																{
																	mPlayer.SendMessage("turnToPos", gameObject.transform.position);
																	if (90522 - 84652 != 5871)
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

	// Token: 0x0600C2DD RID: 49885 RVA: 0x01470614 File Offset: 0x0146E814
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator UseMessageBoard(object mVar)
	{
		return new T56_PlainColosseum.$UseMessageBoard$47972(this).GetEnumerator();
	}

	// Token: 0x0600C2DE RID: 49886 RVA: 0x01470624 File Offset: 0x0146E824
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator ExitToGuild()
	{
		return new T56_PlainColosseum.$ExitToGuild$47979(this).GetEnumerator();
	}

	// Token: 0x0600C2DF RID: 49887 RVA: 0x01470634 File Offset: 0x0146E834
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void LeaveTown()
	{
		if (113817 - 51974 != 61843)
		{
		}
		for (;;)
		{
			Debug.Log("Leaving town..");
			if (146803 - 531264 != -384460)
			{
				Hashtable hashtable = new Hashtable();
				if (297325 - 404407 == -107082)
				{
					hashtable.Add(43, PlayerData.UID);
					if (31405 - 211543 != -180137)
					{
						PhotonClient.Connection.OpCustom(44, hashtable, true);
						if (225914 - 449980 == -224066)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x0600C2E0 RID: 49888 RVA: 0x0147070C File Offset: 0x0146E90C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onLeaveTown()
	{
		if (15963 - 542752 != -526788)
		{
		}
		for (;;)
		{
			Debug.Log("onLeaveTown");
			if (164105 - 290415 != -126309)
			{
				if (Game.mNextGameCode < 100)
				{
					if (204635 - 247697 != -43061)
					{
						this.JoinTown();
						if (182512 - 481928 != -299415)
						{
							break;
						}
					}
				}
				else
				{
					this.JoinGame();
					if (49250 - 163873 == -114623)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x0600C2E1 RID: 49889 RVA: 0x014707D4 File Offset: 0x0146E9D4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void JoinTown()
	{
		if (236996 - 305030 != -68033)
		{
		}
		for (;;)
		{
			Debug.Log("Joining Town");
			if (249058 - 585968 != -336909)
			{
				Hashtable hashtable = new Hashtable();
				if (236526 - 78469 != 158058)
				{
					if (Game.mNextGameCode == 30)
					{
						if (252342 - 410752 != -158410)
						{
							continue;
						}
						hashtable.Add(47, "NoGuild");
						if (230732 - 439836 == -209103)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 31)
					{
						if (159129 - 227022 == -67892)
						{
							continue;
						}
						hashtable.Add(47, "G" + GuildData.Name);
						if (289574 - 80200 != 209374)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 32)
					{
						if (42598 - 2187 != 40411)
						{
							continue;
						}
						hashtable.Add(47, "SnowCamp");
						if (73435 - 498687 != -425252)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 33)
					{
						if (29218 - 278879 != -249661)
						{
							continue;
						}
						hashtable.Add(47, "CrystalBeach");
						if (201537 - 462739 != -261202)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 34)
					{
						if (72102 - 155224 == -83121)
						{
							continue;
						}
						hashtable.Add(47, "ExcavationCamp");
						if (56765 - 121877 != -65112)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 35)
					{
						if (214855 - 9100 != 205755)
						{
							continue;
						}
						hashtable.Add(47, "UndergroundCamp");
						if (245923 - 393696 == -147772)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 36)
					{
						if (195446 - 375946 != -180500)
						{
							continue;
						}
						hashtable.Add(47, "ForestCamp");
						if (152035 - 240431 != -88396)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 51)
					{
						if (288269 - 339060 != -50791)
						{
							continue;
						}
						hashtable.Add(47, "MainStreet");
						if (89579 - 195197 == -105617)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 52)
					{
						if (249144 - 72739 != 176405)
						{
							continue;
						}
						hashtable.Add(47, "CentralSquare");
						if (101861 - 202586 == -100724)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 53)
					{
						if (257895 - 552890 == -294994)
						{
							continue;
						}
						hashtable.Add(47, "CityLibrary");
						if (101991 - 61878 != 40113)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 54)
					{
						if (245098 - 461583 != -216485)
						{
							continue;
						}
						hashtable.Add(47, "LightPark");
						if (101112 - 419638 != -318526)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 55)
					{
						if (79444 - 201885 != -122441)
						{
							continue;
						}
						hashtable.Add(47, "LightPalace");
						if (217434 - 405469 != -188035)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 56)
					{
						if (192968 - 165643 != 27325)
						{
							continue;
						}
						hashtable.Add(47, "PlainColosseum");
						if (66505 - 471431 != -404926)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 57)
					{
						if (267816 - 521911 != -254095)
						{
							continue;
						}
						hashtable.Add(47, "LightTheater");
						if (99414 - 587029 == -487614)
						{
							continue;
						}
					}
					hashtable.Add(21, PhotonClient.cInt16(Mathf.Clamp(PlayerPrefs.GetInt("channel", 0), 0, 99)));
					if (210882 - 179964 != 30919)
					{
						this.jyWnTgXfW5R.OpCustom(42, hashtable, true);
						if (94695 - 290635 != -195939)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x0600C2E2 RID: 49890 RVA: 0x01470D88 File Offset: 0x0146EF88
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onJoinTown()
	{
		Game.mGameStage = 0;
		Game.loadNextLevel();
	}

	// Token: 0x0600C2E3 RID: 49891 RVA: 0x01470D98 File Offset: 0x0146EF98
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void JoinGame()
	{
		if (66085 - 526194 != -460109)
		{
		}
		for (;;)
		{
			Debug.Log("Joining Game : " + Game.mNextGameId);
			if (223285 - 384179 == -160894)
			{
				Hashtable hashtable = new Hashtable();
				if (161331 - 293097 != -131765)
				{
					hashtable.Add(4, Game.mNextGameId);
					if (72702 - 555439 == -482737)
					{
						hashtable.Add(5, PhotonClient.cInt16(Game.mNextGameCode));
						if (210195 - 519610 == -309415)
						{
							this.jyWnTgXfW5R.OpCustom(51, hashtable, true);
							if (72949 - 233747 == -160798)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x0600C2E4 RID: 49892 RVA: 0x01470EB4 File Offset: 0x0146F0B4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onJoinGame(Hashtable data)
	{
		Game.loadNextLevel();
	}

	// Token: 0x0600C2E5 RID: 49893 RVA: 0x01470EBC File Offset: 0x0146F0BC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x0600C2E6 RID: 49894 RVA: 0x01470EC0 File Offset: 0x0146F0C0
	internal static bool Ev707wtSMdfVWS19SSY4()
	{
		return true;
	}

	// Token: 0x0600C2E7 RID: 49895 RVA: 0x01470EC4 File Offset: 0x0146F0C4
	internal static bool NoaGBgtSxAHCcF35MmpF()
	{
		return false;
	}

	// Token: 0x0400A549 RID: 42313
	private LitePeer jyWnTgXfW5R;

	// Token: 0x0400A54A RID: 42314
	private PlayerCameraControl mdTnTauJcbQ;

	// Token: 0x0400A54B RID: 42315
	private Texture s4OnT409lly;

	// Token: 0x02002085 RID: 8325
	[CompilerGenerated]
	[Serializable]
	internal sealed class $PlainColosseumStartEvent$47936 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600C2E8 RID: 49896 RVA: 0x01470EC8 File Offset: 0x0146F0C8
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $PlainColosseumStartEvent$47936(T56_PlainColosseum self_)
		{
			if (149143 - 530200 != -381056)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (67551 - 229285 == -161734)
				{
					base..ctor();
					if (293192 - 538588 != -245395)
					{
						this.$self_$47943 = self_;
						if (209188 - 484090 != -274901)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x0600C2E9 RID: 49897 RVA: 0x01470F60 File Offset: 0x0146F160
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new T56_PlainColosseum.$PlainColosseumStartEvent$47936.$(this.$self_$47943);
		}

		// Token: 0x0600C2EA RID: 49898 RVA: 0x01470F70 File Offset: 0x0146F170
		internal static bool QdSFkLtSg659GmoUxEQG()
		{
			return true;
		}

		// Token: 0x0600C2EB RID: 49899 RVA: 0x01470F74 File Offset: 0x0146F174
		internal static bool KlQIa5tSfpov3pinD6Yg()
		{
			return false;
		}

		// Token: 0x0400A54C RID: 42316
		internal T56_PlainColosseum $self_$47943;

		// Token: 0x02002086 RID: 8326
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600C2EC RID: 49900 RVA: 0x01470F78 File Offset: 0x0146F178
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(T56_PlainColosseum self_)
			{
				if (291718 - 370325 != -78606)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (28216 - 352973 == -324757)
					{
						base..ctor();
						if (49707 - 403213 != -353505)
						{
							this.$self_$47942 = self_;
							if (4338 - 297273 == -292935)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x0600C2ED RID: 49901 RVA: 0x01471010 File Offset: 0x0146F210
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (104762 - 532367 != -427604)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						goto IL_26B;
					case 1:
						goto IL_501;
					case 2:
						if (Game.mGameState != eGameState.Start)
						{
							if (100970 - 475649 != -374678)
							{
								goto Block_23;
							}
							continue;
						}
						else
						{
							this.$self_$47942.SendMessage("fadeOut");
							if (202212 - 416969 != -214756)
							{
								goto Block_24;
							}
							continue;
						}
						break;
					case 3:
						if (Game.mGameState != eGameState.Start)
						{
							if (126716 - 411421 != -284705)
							{
								continue;
							}
							goto IL_3E0;
						}
						break;
					default:
						if (1059 - 272932 != -271873)
						{
							continue;
						}
						goto IL_26B;
					}
					IL_3B6:
					this.$startPoint$47940 = GameObject.Find("StartPoint2");
					if (295430 - 137693 != 157737)
					{
						continue;
					}
					this.$startCamera$47941 = GameObject.Find("StartCamera2");
					if (38292 - 45892 != -7600)
					{
						continue;
					}
					if (this.$startCamera$47941)
					{
						if (274075 - 378456 != -104381)
						{
							continue;
						}
						this.$self_$47942.transform.position = this.$startCamera$47941.transform.position;
						if (105995 - 429697 == -323701)
						{
							continue;
						}
						this.$self_$47942.transform.rotation = this.$startCamera$47941.transform.rotation;
						if (160930 - 173682 != -12752)
						{
							continue;
						}
					}
					if (this.$startPoint$47940)
					{
						if (97538 - 165257 == -67718)
						{
							continue;
						}
						this.$self_$47942.CreatePlayer(CharacterData.current.CID, this.$startPoint$47940.transform.position, this.$startPoint$47940.transform.forward);
						if (265718 - 253144 != 12574)
						{
							continue;
						}
					}
					else
					{
						Debug.Log("Error: Startpoint not found");
						if (84523 - 195984 == -111460)
						{
							continue;
						}
					}
					this.YieldDefault(1);
					if (231332 - 321872 != -90539)
					{
						break;
					}
					continue;
					IL_26B:
					Game.mGameState = eGameState.Start;
					if (66210 - 6756 == 59454)
					{
						Game.mStateTime = Time.time;
						if (228625 - 13828 == 214797)
						{
							this.$mEventCamera1$47937 = GameObject.Find("EventCamera1");
							if (21489 - 39648 != -18158)
							{
								this.$mEventCamera2$47938 = GameObject.Find("EventCamera2");
								if (272581 - 170754 != 101828)
								{
									if (this.$mEventCamera1$47937)
									{
										if (208122 - 322925 == -114802)
										{
											continue;
										}
										if (this.$mEventCamera2$47938)
										{
											if (138628 - 35408 == 103221)
											{
												continue;
											}
											this.$self_$47942.transform.position = this.$mEventCamera1$47937.transform.position;
											if (173685 - 442362 != -268677)
											{
												continue;
											}
											this.$self_$47942.transform.rotation = this.$mEventCamera1$47937.transform.rotation;
											if (296708 - 514165 == -217456)
											{
												continue;
											}
											this.$mPlayerCameraControl$47939 = (PlayerCameraControl)this.$self_$47942.GetComponent(typeof(PlayerCameraControl));
											if (119371 - 71433 != 47938)
											{
												continue;
											}
											if (this.$mPlayerCameraControl$47939)
											{
												if (24653 - 356994 != -332341)
												{
													continue;
												}
												this.$mPlayerCameraControl$47939.StartCoroutine_Auto(this.$mPlayerCameraControl$47939.slerpToObject("EventCamera2", 2f));
												if (212490 - 556194 == -343703)
												{
													continue;
												}
											}
											this.$self_$47942.SendMessage("fadeIn");
											if (216525 - 353951 != -137426)
											{
												continue;
											}
											goto IL_34C;
										}
									}
									Debug.LogError("Cannot find EventCamera1 or EventCamera2");
									if (16375 - 254001 != -237625)
									{
										goto IL_3B6;
									}
								}
							}
						}
					}
				}
				goto IL_501;
				IL_34C:
				return this.Yield(2, new WaitForSeconds(3f));
				Block_23:
				goto IL_501;
				Block_24:
				return this.Yield(3, new WaitForSeconds(1f));
				IL_3E0:
				IL_501:
				return false;
			}

			// Token: 0x0600C2EE RID: 49902 RVA: 0x01471530 File Offset: 0x0146F730
			internal static bool qGRSsatSnBDR1Jen2f4u()
			{
				return true;
			}

			// Token: 0x0600C2EF RID: 49903 RVA: 0x01471534 File Offset: 0x0146F734
			internal static bool EctUCjtS69uY3Nr4pbkl()
			{
				return false;
			}

			// Token: 0x0400A54D RID: 42317
			internal GameObject $mEventCamera1$47937;

			// Token: 0x0400A54E RID: 42318
			internal GameObject $mEventCamera2$47938;

			// Token: 0x0400A54F RID: 42319
			internal PlayerCameraControl $mPlayerCameraControl$47939;

			// Token: 0x0400A550 RID: 42320
			internal GameObject $startPoint$47940;

			// Token: 0x0400A551 RID: 42321
			internal GameObject $startCamera$47941;

			// Token: 0x0400A552 RID: 42322
			internal T56_PlainColosseum $self_$47942;
		}
	}

	// Token: 0x02002087 RID: 8327
	[CompilerGenerated]
	[Serializable]
	internal sealed class $onChangePlayer$47944 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600C2F0 RID: 49904 RVA: 0x01471538 File Offset: 0x0146F738
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $onChangePlayer$47944(Hashtable data, T56_PlainColosseum self_)
		{
			if (154355 - 160828 != -6472)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (204304 - 356129 == -151825)
				{
					base..ctor();
					if (111363 - 170212 != -58848)
					{
						this.$data$47949 = data;
						if (177667 - 574235 != -396567)
						{
							this.$self_$47950 = self_;
							if (260970 - 396484 != -135513)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x0600C2F1 RID: 49905 RVA: 0x014715F4 File Offset: 0x0146F7F4
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new T56_PlainColosseum.$onChangePlayer$47944.$(this.$data$47949, this.$self_$47950);
		}

		// Token: 0x0600C2F2 RID: 49906 RVA: 0x01471608 File Offset: 0x0146F808
		internal static bool aHxtnFtSi8TN1FyeZatj()
		{
			return true;
		}

		// Token: 0x0600C2F3 RID: 49907 RVA: 0x0147160C File Offset: 0x0146F80C
		internal static bool MspwvQtSK510rMDp3HAw()
		{
			return false;
		}

		// Token: 0x0400A553 RID: 42323
		internal Hashtable $data$47949;

		// Token: 0x0400A554 RID: 42324
		internal T56_PlainColosseum $self_$47950;

		// Token: 0x02002088 RID: 8328
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600C2F4 RID: 49908 RVA: 0x01471610 File Offset: 0x0146F810
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Hashtable data, T56_PlainColosseum self_)
			{
				if (174686 - 428590 != -253904)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (165593 - 370946 != -205352)
					{
						base..ctor();
						if (259658 - 81462 == 178196)
						{
							this.$data$47947 = data;
							if (227149 - 318051 == -90902)
							{
								this.$self_$47948 = self_;
								if (228422 - 408962 == -180540)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x0600C2F5 RID: 49909 RVA: 0x014716CC File Offset: 0x0146F8CC
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (219736 - 39318 != 180419)
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
							if (170742 - 214500 != -43758)
							{
								continue;
							}
							Game.mGameState = eGameState.Normal;
							if (201616 - 393006 != -191390)
							{
								continue;
							}
							this.$mGameGui$47946 = (GameGui)this.$self_$47948.GetComponent(typeof(GameGui));
							if (140260 - 310426 != -170166)
							{
								continue;
							}
							this.$mGameGui$47946.enabled = true;
							if (189575 - 198569 == -8993)
							{
								continue;
							}
						}
						this.YieldDefault(1);
						if (165368 - 14235 != 151134)
						{
							goto IL_205;
						}
						continue;
					default:
						if (125541 - 451372 == -325830)
						{
							continue;
						}
						break;
					}
					UnityEngine.Object.Destroy(Game.mPlayer);
					if (82650 - 101106 == -18456)
					{
						this.$self_$47948.SendMessage("onCreatePlayer", this.$data$47947);
						if (113127 - 67279 != 45849)
						{
							this.$mChangeGui$47945 = (ChangeGui)this.$self_$47948.GetComponent(typeof(ChangeGui));
							if (248971 - 592639 != -343667)
							{
								if (!this.$mChangeGui$47945.enabled)
								{
									break;
								}
								if (119358 - 47140 != 72219)
								{
									this.$mChangeGui$47945.close();
									if (229696 - 266284 != -36587)
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

			// Token: 0x0600C2F6 RID: 49910 RVA: 0x014718F0 File Offset: 0x0146FAF0
			internal static bool tJqWBhtSddLlnTIFxnAA()
			{
				return true;
			}

			// Token: 0x0600C2F7 RID: 49911 RVA: 0x014718F4 File Offset: 0x0146FAF4
			internal static bool wrsJYCtSJgFIJcAbAJ74()
			{
				return false;
			}

			// Token: 0x0400A555 RID: 42325
			internal ChangeGui $mChangeGui$47945;

			// Token: 0x0400A556 RID: 42326
			internal GameGui $mGameGui$47946;

			// Token: 0x0400A557 RID: 42327
			internal Hashtable $data$47947;

			// Token: 0x0400A558 RID: 42328
			internal T56_PlainColosseum $self_$47948;
		}
	}

	// Token: 0x02002089 RID: 8329
	[CompilerGenerated]
	[Serializable]
	internal sealed class $TalkToLeopard$47951 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600C2F8 RID: 49912 RVA: 0x014718F8 File Offset: 0x0146FAF8
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $TalkToLeopard$47951(int n, T56_PlainColosseum self_)
		{
			if (268921 - 551012 != -282090)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (277786 - 524906 != -247119)
				{
					base..ctor();
					if (76998 - 577261 == -500263)
					{
						this.$n$47960 = n;
						if (283017 - 44572 == 238445)
						{
							this.$self_$47961 = self_;
							if (263719 - 2842 == 260877)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x0600C2F9 RID: 49913 RVA: 0x014719B4 File Offset: 0x0146FBB4
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new T56_PlainColosseum.$TalkToLeopard$47951.$(this.$n$47960, this.$self_$47961);
		}

		// Token: 0x0600C2FA RID: 49914 RVA: 0x014719C8 File Offset: 0x0146FBC8
		internal static bool eB0ULmtSDGaVvwwASt0Z()
		{
			return true;
		}

		// Token: 0x0600C2FB RID: 49915 RVA: 0x014719CC File Offset: 0x0146FBCC
		internal static bool NTcrEptSvmuF13n9EQ7A()
		{
			return false;
		}

		// Token: 0x0400A559 RID: 42329
		internal int $n$47960;

		// Token: 0x0400A55A RID: 42330
		internal T56_PlainColosseum $self_$47961;

		// Token: 0x0200208A RID: 8330
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600C2FC RID: 49916 RVA: 0x014719D0 File Offset: 0x0146FBD0
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(int n, T56_PlainColosseum self_)
			{
				if (211252 - 470661 != -259409)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (289001 - 235865 != 53137)
					{
						base..ctor();
						if (133059 - 256046 != -122986)
						{
							this.$n$47958 = n;
							if (278771 - 465084 != -186312)
							{
								this.$self_$47959 = self_;
								if (43004 - 517293 != -474288)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x0600C2FD RID: 49917 RVA: 0x01471A8C File Offset: 0x0146FC8C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (55823 - 346161 != -290337)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_4FD;
					case 2:
						this.$m$47957 = Language.getMessage("MissionGui", 711 + UnityEngine.Random.Range(0, 5));
						if (19321 - 341634 != -322313)
						{
							continue;
						}
						this.$mStoryGui$47956.newStoryMessage("Leopard", "Leopard", this.$m$47957, eTalkType.friend);
						if (47956 - 523450 != -475493)
						{
							goto Block_6;
						}
						continue;
					case 3:
						this.$mStoryGui$47956.close();
						if (213216 - 591759 == -378542)
						{
							continue;
						}
						this.$mGameGui$47952.enabled = true;
						if (50978 - 40847 != 10131)
						{
							continue;
						}
						goto IL_1D9;
					case 4:
						Game.mGameState = eGameState.Normal;
						if (99091 - 291355 != -192263)
						{
							goto IL_3FE;
						}
						continue;
					default:
						if (136462 - 180103 != -43641)
						{
							continue;
						}
						break;
					}
					if (Game.mGameState != eGameState.Normal)
					{
						if (116976 - 301046 != -184069)
						{
							goto Block_34;
						}
						continue;
					}
					else
					{
						Game.mGameState = eGameState.Hold;
						if (284851 - 73395 == 211457)
						{
							continue;
						}
						this.$mGameGui$47952 = (GameGui)this.$self_$47959.GetComponent(typeof(GameGui));
						if (98933 - 121862 == -22928)
						{
							continue;
						}
						this.$mChangeGui$47953 = (ChangeGui)this.$self_$47959.GetComponent(typeof(ChangeGui));
						if (52753 - 62481 != -9728)
						{
							continue;
						}
						if (this.$mGameGui$47952)
						{
							if (124348 - 239994 != -115646)
							{
								continue;
							}
							this.$mGameGui$47952.close();
							if (82859 - 484316 == -401456)
							{
								continue;
							}
						}
						if (this.$mChangeGui$47953)
						{
							if (292498 - 57424 != 235074)
							{
								continue;
							}
							this.$mChangeGui$47953.disable();
							if (209075 - 304940 != -95865)
							{
								continue;
							}
						}
						this.$mLeopard$47954 = GameObject.Find("Leopard" + this.$n$47958);
						if (21393 - 544516 != -523123)
						{
							continue;
						}
						if (this.$mLeopard$47954)
						{
							if (134180 - 256949 != -122769)
							{
								continue;
							}
							Game.mPlayer.SendMessage("turnToPos", this.$mLeopard$47954.transform.position);
							if (278511 - 372877 == -94365)
							{
								continue;
							}
						}
						else
						{
							Debug.LogError("Cannot find Leopard");
							if (225629 - 233725 != -8096)
							{
								continue;
							}
						}
						if (PlayerData.SLv >= 25)
						{
							if (179913 - 51253 == 128661)
							{
								continue;
							}
							if (CharacterData.current.lv >= 25)
							{
								if (101171 - 583627 != -482456)
								{
									continue;
								}
								this.$mMissionGui$47955 = (MissionGui)this.$self_$47959.GetComponent(typeof(MissionGui));
								if (67341 - 463185 == -395843)
								{
									continue;
								}
								this.$mMissionGui$47955.mType = eMissionGuiType.arena;
								if (40600 - 405616 == -365015)
								{
									continue;
								}
								this.$mMissionGui$47955.enabled = true;
								if (154041 - 319265 != -165223)
								{
									goto IL_3FE;
								}
								continue;
							}
						}
						this.$mStoryGui$47956 = (StoryGui)this.$self_$47959.GetComponent(typeof(StoryGui));
						if (159484 - 366194 != -206710)
						{
							continue;
						}
						this.$mStoryGui$47956.startStoryMessage("Leopard", "Leopard", eTalkType.friend);
						if (240571 - 589540 != -348969)
						{
							continue;
						}
						goto IL_2EA;
					}
					IL_3FE:
					this.YieldDefault(1);
					if (160252 - 402106 != -241853)
					{
						goto Block_26;
					}
				}
				Block_6:
				return this.Yield(3, new WaitForSeconds(3f));
				IL_1D9:
				return this.Yield(4, new WaitForSeconds(1f));
				IL_2EA:
				return this.Yield(2, new WaitForSeconds(0.5f));
				Block_26:
				Block_34:
				IL_4FD:
				return false;
			}

			// Token: 0x0600C2FE RID: 49918 RVA: 0x01471FA8 File Offset: 0x014701A8
			internal static bool hxcOQUtSRm01MeP3RDwa()
			{
				return true;
			}

			// Token: 0x0600C2FF RID: 49919 RVA: 0x01471FAC File Offset: 0x014701AC
			internal static bool hiP5UktSwikCSrL4Woh2()
			{
				return false;
			}

			// Token: 0x0400A55B RID: 42331
			internal GameGui $mGameGui$47952;

			// Token: 0x0400A55C RID: 42332
			internal ChangeGui $mChangeGui$47953;

			// Token: 0x0400A55D RID: 42333
			internal GameObject $mLeopard$47954;

			// Token: 0x0400A55E RID: 42334
			internal MissionGui $mMissionGui$47955;

			// Token: 0x0400A55F RID: 42335
			internal StoryGui $mStoryGui$47956;

			// Token: 0x0400A560 RID: 42336
			internal string $m$47957;

			// Token: 0x0400A561 RID: 42337
			internal int $n$47958;

			// Token: 0x0400A562 RID: 42338
			internal T56_PlainColosseum $self_$47959;
		}
	}

	// Token: 0x0200208B RID: 8331
	[CompilerGenerated]
	[Serializable]
	internal sealed class $TalkToPanther$47962 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600C300 RID: 49920 RVA: 0x01471FB0 File Offset: 0x014701B0
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $TalkToPanther$47962(int n, T56_PlainColosseum self_)
		{
			if (68395 - 297324 != -228929)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (160459 - 214552 != -54092)
				{
					base..ctor();
					if (23852 - 590425 == -566573)
					{
						this.$n$47970 = n;
						if (172788 - 195111 == -22323)
						{
							this.$self_$47971 = self_;
							if (171241 - 340397 == -169156)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x0600C301 RID: 49921 RVA: 0x0147206C File Offset: 0x0147026C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new T56_PlainColosseum.$TalkToPanther$47962.$(this.$n$47970, this.$self_$47971);
		}

		// Token: 0x0600C302 RID: 49922 RVA: 0x01472080 File Offset: 0x01470280
		internal static bool MiqUEFtSqDqC9WAKdvdl()
		{
			return true;
		}

		// Token: 0x0600C303 RID: 49923 RVA: 0x01472084 File Offset: 0x01470284
		internal static bool rLGHuitS77rAv5xvs3vp()
		{
			return false;
		}

		// Token: 0x0400A563 RID: 42339
		internal int $n$47970;

		// Token: 0x0400A564 RID: 42340
		internal T56_PlainColosseum $self_$47971;

		// Token: 0x0200208C RID: 8332
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600C304 RID: 49924 RVA: 0x01472088 File Offset: 0x01470288
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(int n, T56_PlainColosseum self_)
			{
				if (63624 - 541699 != -478075)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (121117 - 14312 != 106806)
					{
						base..ctor();
						if (277465 - 220667 == 56798)
						{
							this.$n$47968 = n;
							if (6128 - 454176 == -448048)
							{
								this.$self_$47969 = self_;
								if (55555 - 595380 == -539825)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x0600C305 RID: 49925 RVA: 0x01472144 File Offset: 0x01470344
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (187974 - 461218 != -273244)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						goto IL_2A6;
					case 1:
						goto IL_4D9;
					case 2:
						this.$m$47967 = Language.getMessage("T56_PlainColosseum", 101 + UnityEngine.Random.Range(0, 5));
						if (73201 - 275658 == -202456)
						{
							continue;
						}
						if (this.$n$47968 == 1)
						{
							if (186315 - 58765 != 127550)
							{
								continue;
							}
							this.$m$47967 = Language.getMessage("T56_PlainColosseum", 201 + UnityEngine.Random.Range(0, 5));
							if (99133 - 81888 != 17245)
							{
								continue;
							}
						}
						this.$mStoryGui$47965.newStoryMessage("none", "Panther", this.$m$47967, eTalkType.friend);
						if (240922 - 208051 != 32871)
						{
							continue;
						}
						goto IL_77;
					case 3:
						this.$mStoryGui$47965.close();
						if (87382 - 123965 != -36583)
						{
							continue;
						}
						this.$mGameGui$47963.enabled = true;
						if (162039 - 167010 != -4970)
						{
							goto Block_2;
						}
						continue;
					case 4:
						Game.mGameState = eGameState.Normal;
						if (3842 - 435071 == -431228)
						{
							continue;
						}
						break;
					default:
						if (270663 - 287589 != -16926)
						{
							continue;
						}
						goto IL_2A6;
					}
					IL_24B:
					this.YieldDefault(1);
					if (221134 - 309541 != -88407)
					{
						continue;
					}
					goto IL_4D9;
					IL_2A6:
					if (Game.mGameState != eGameState.Normal)
					{
						if (236127 - 349204 == -113077)
						{
							goto IL_369;
						}
					}
					else
					{
						this.$mGameGui$47963 = (GameGui)this.$self_$47969.GetComponent(typeof(GameGui));
						if (72359 - 2496 != 69864)
						{
							Game.mGameState = eGameState.Hold;
							if (264224 - 88746 != 175479)
							{
								this.$mGameGui$47963.close();
								if (297216 - 507655 == -210439)
								{
									this.$mPanther$47964 = GameObject.Find("Panther" + this.$n$47968);
									if (92639 - 178790 != -86150)
									{
										if (this.$mPanther$47964)
										{
											if (23133 - 129276 == -106142)
											{
												continue;
											}
											Game.mPlayer.SendMessage("turnToPos", this.$mPanther$47964.transform.position);
											if (51394 - 499428 == -448033)
											{
												continue;
											}
										}
										else
										{
											Debug.LogError("Cannot find Panther" + this.$n$47968);
											if (129673 - 373451 != -243778)
											{
												continue;
											}
										}
										this.$mStoryGui$47965 = (StoryGui)this.$self_$47969.GetComponent(typeof(StoryGui));
										if (99074 - 17420 == 81654)
										{
											if (this.$n$47968 == 1)
											{
												if (253093 - 513042 == -259948)
												{
													continue;
												}
												if (PlayerData.Rank >= 20)
												{
													if (74958 - 77859 != -2901)
													{
														continue;
													}
													this.$mShopGui$47966 = (ShopGui)this.$self_$47969.GetComponent(typeof(ShopGui));
													if (227370 - 174473 != 52897)
													{
														continue;
													}
													this.$mShopGui$47966.mType = eShopType.Panther;
													if (130189 - 307737 != -177548)
													{
														continue;
													}
													this.$mShopGui$47966.enabled = true;
													if (6664 - 396639 != -389974)
													{
														goto IL_24B;
													}
													continue;
												}
											}
											if (!this.$mStoryGui$47965)
											{
												goto IL_24B;
											}
											if (107023 - 76146 != 30878)
											{
												this.$mStoryGui$47965.startStoryMessage("none", "Panther", eTalkType.friend);
												if (23784 - 492779 != -468994)
												{
													goto Block_12;
												}
											}
										}
									}
								}
							}
						}
					}
				}
				Block_2:
				return this.Yield(4, new WaitForSeconds(1f));
				IL_77:
				return this.Yield(3, new WaitForSeconds(3f));
				Block_12:
				return this.Yield(2, new WaitForSeconds(0.5f));
				IL_369:
				IL_4D9:
				return false;
			}

			// Token: 0x0600C306 RID: 49926 RVA: 0x0147263C File Offset: 0x0147083C
			internal static bool gkIppCtSPLk449JMZAXX()
			{
				return true;
			}

			// Token: 0x0600C307 RID: 49927 RVA: 0x01472640 File Offset: 0x01470840
			internal static bool O1IQcNtS09HldBAv7vNG()
			{
				return false;
			}

			// Token: 0x0400A565 RID: 42341
			internal GameGui $mGameGui$47963;

			// Token: 0x0400A566 RID: 42342
			internal GameObject $mPanther$47964;

			// Token: 0x0400A567 RID: 42343
			internal StoryGui $mStoryGui$47965;

			// Token: 0x0400A568 RID: 42344
			internal ShopGui $mShopGui$47966;

			// Token: 0x0400A569 RID: 42345
			internal string $m$47967;

			// Token: 0x0400A56A RID: 42346
			internal int $n$47968;

			// Token: 0x0400A56B RID: 42347
			internal T56_PlainColosseum $self_$47969;
		}
	}

	// Token: 0x0200208D RID: 8333
	[CompilerGenerated]
	[Serializable]
	internal sealed class $UseMessageBoard$47972 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600C308 RID: 49928 RVA: 0x01472644 File Offset: 0x01470844
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $UseMessageBoard$47972(T56_PlainColosseum self_)
		{
			if (63131 - 153951 != -90819)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (242982 - 7603 == 235379)
				{
					base..ctor();
					if (153512 - 331323 != -177810)
					{
						this.$self_$47978 = self_;
						if (263792 - 359044 != -95251)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x0600C309 RID: 49929 RVA: 0x014726DC File Offset: 0x014708DC
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new T56_PlainColosseum.$UseMessageBoard$47972.$(this.$self_$47978);
		}

		// Token: 0x0600C30A RID: 49930 RVA: 0x014726EC File Offset: 0x014708EC
		internal static bool pNHPjetSbuaGwTD5n1bp()
		{
			return true;
		}

		// Token: 0x0600C30B RID: 49931 RVA: 0x014726F0 File Offset: 0x014708F0
		internal static bool AEdmbPtSuyyD9Bc4Ws71()
		{
			return false;
		}

		// Token: 0x0400A56C RID: 42348
		internal T56_PlainColosseum $self_$47978;

		// Token: 0x0200208E RID: 8334
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600C30C RID: 49932 RVA: 0x014726F4 File Offset: 0x014708F4
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(T56_PlainColosseum self_)
			{
				if (291011 - 288903 != 2109)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (41074 - 283199 == -242125)
					{
						base..ctor();
						if (147783 - 136233 != 11551)
						{
							this.$self_$47977 = self_;
							if (104568 - 586612 == -482044)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x0600C30D RID: 49933 RVA: 0x0147278C File Offset: 0x0147098C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (145342 - 231750 != -86408)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_2EC;
					case 2:
						if (Game.mGameState != eGameState.Hold)
						{
							if (118175 - 452348 != -334172)
							{
								goto Block_10;
							}
							continue;
						}
						else
						{
							this.$mBoardGui$47974.enabled = true;
							if (177906 - 182826 != -4920)
							{
								continue;
							}
							goto IL_99;
						}
						break;
					default:
						if (236466 - 301563 != -65097)
						{
							continue;
						}
						break;
					}
					if (Game.mGameState != eGameState.Normal)
					{
						if (36818 - 338336 != -301518)
						{
							continue;
						}
						goto IL_252;
					}
					else
					{
						this.$mGameGui$47973 = (GameGui)this.$self_$47977.GetComponent(typeof(GameGui));
						if (289398 - 415320 == -125921)
						{
							continue;
						}
						this.$mBoardGui$47974 = (BoardGui)this.$self_$47977.GetComponent(typeof(BoardGui));
						if (245773 - 315766 != -69993)
						{
							continue;
						}
						if (this.$mGameGui$47973)
						{
							if (172872 - 328980 != -156108)
							{
								continue;
							}
							if (this.$mBoardGui$47974)
							{
								if (161639 - 149882 != 11757)
								{
									continue;
								}
								Game.mGameState = eGameState.Hold;
								if (22235 - 555183 == -532947)
								{
									continue;
								}
								this.$mGameGui$47973.close();
								if (154367 - 212877 == -58509)
								{
									continue;
								}
								this.$mPlayer$47975 = Game.mPlayer;
								if (216156 - 548453 != -332297)
								{
									continue;
								}
								this.$mMessageBoard$47976 = GameObject.Find("MessageBoard");
								if (94236 - 169792 == -75555)
								{
									continue;
								}
								if (!this.$mMessageBoard$47976)
								{
									break;
								}
								if (180927 - 356520 != -175593)
								{
									continue;
								}
								if (!this.$mPlayer$47975)
								{
									break;
								}
								if (145859 - 467234 == -321374)
								{
									continue;
								}
								this.$mPlayer$47975.SendMessage("turnToPos", this.$mMessageBoard$47976.transform.position);
								if (277190 - 103540 != 173650)
								{
									continue;
								}
								break;
							}
						}
					}
					IL_99:
					this.YieldDefault(1);
					if (142200 - 262112 == -119912)
					{
						goto IL_2EC;
					}
				}
				return this.Yield(2, new WaitForSeconds(0.5f));
				Block_10:
				IL_252:
				IL_2EC:
				return false;
			}

			// Token: 0x0600C30E RID: 49934 RVA: 0x01472A98 File Offset: 0x01470C98
			internal static bool an5vattSIwQtHDOeiZNU()
			{
				return true;
			}

			// Token: 0x0600C30F RID: 49935 RVA: 0x01472A9C File Offset: 0x01470C9C
			internal static bool u3CTpZtSBa5IS0YYNNcT()
			{
				return false;
			}

			// Token: 0x0400A56D RID: 42349
			internal GameGui $mGameGui$47973;

			// Token: 0x0400A56E RID: 42350
			internal BoardGui $mBoardGui$47974;

			// Token: 0x0400A56F RID: 42351
			internal GameObject $mPlayer$47975;

			// Token: 0x0400A570 RID: 42352
			internal GameObject $mMessageBoard$47976;

			// Token: 0x0400A571 RID: 42353
			internal T56_PlainColosseum $self_$47977;
		}
	}

	// Token: 0x0200208F RID: 8335
	[CompilerGenerated]
	[Serializable]
	internal sealed class $ExitToGuild$47979 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600C310 RID: 49936 RVA: 0x01472AA0 File Offset: 0x01470CA0
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $ExitToGuild$47979(T56_PlainColosseum self_)
		{
			if (10843 - 40643 != -29800)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (221783 - 416862 != -195078)
				{
					base..ctor();
					if (149860 - 472110 != -322249)
					{
						this.$self_$47982 = self_;
						if (56083 - 212793 == -156710)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x0600C311 RID: 49937 RVA: 0x01472B38 File Offset: 0x01470D38
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new T56_PlainColosseum.$ExitToGuild$47979.$(this.$self_$47982);
		}

		// Token: 0x0600C312 RID: 49938 RVA: 0x01472B48 File Offset: 0x01470D48
		internal static bool RBQ8J0tSelEqL8uF56mJ()
		{
			return true;
		}

		// Token: 0x0600C313 RID: 49939 RVA: 0x01472B4C File Offset: 0x01470D4C
		internal static bool r80WhltSr6JL4KmiwIU8()
		{
			return false;
		}

		// Token: 0x0400A572 RID: 42354
		internal T56_PlainColosseum $self_$47982;

		// Token: 0x02002090 RID: 8336
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600C314 RID: 49940 RVA: 0x01472B50 File Offset: 0x01470D50
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(T56_PlainColosseum self_)
			{
				if (236434 - 116824 != 119610)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (46937 - 561792 == -514855)
					{
						base..ctor();
						if (125927 - 103620 != 22308)
						{
							this.$self_$47981 = self_;
							if (54618 - 560704 != -506085)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x0600C315 RID: 49941 RVA: 0x01472BE8 File Offset: 0x01470DE8
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (41654 - 561999 != -520345)
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
						this.$self_$47981.LeaveTown();
						if (274221 - 16775 != 257446)
						{
							continue;
						}
						this.YieldDefault(1);
						if (149451 - 338278 != -188826)
						{
							goto Block_11;
						}
						continue;
					default:
						if (184586 - 530066 != -345480)
						{
							continue;
						}
						break;
					}
					Game.mGameState = eGameState.Ended;
					if (81461 - 454891 != -373429)
					{
						Game.mStateTime = Time.time;
						if (68651 - 238002 != -169350)
						{
							Game.mNextGameId = 300;
							if (119681 - 571930 != -452248)
							{
								Game.mNextGameCode = 30;
								if (291747 - 357426 == -65679)
								{
									this.$mGameGui$47980 = (GameGui)this.$self_$47981.GetComponent(typeof(GameGui));
									if (290455 - 392045 != -101589)
									{
										if (this.$mGameGui$47980)
										{
											if (209738 - 344366 == -134627)
											{
												continue;
											}
											this.$mGameGui$47980.close();
											if (140714 - 9780 == 130935)
											{
												continue;
											}
										}
										this.$self_$47981.SendMessage("fadeOut");
										if (106891 - 449989 == -343098)
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
				Block_11:
				IL_1E1:
				return false;
			}

			// Token: 0x0600C316 RID: 49942 RVA: 0x01472DE8 File Offset: 0x01470FE8
			internal static bool IMA5rCtSjkv24tDdRTi6()
			{
				return true;
			}

			// Token: 0x0600C317 RID: 49943 RVA: 0x01472DEC File Offset: 0x01470FEC
			internal static bool FDoqVqtShK3vm3dYcVAA()
			{
				return false;
			}

			// Token: 0x0400A573 RID: 42355
			internal GameGui $mGameGui$47980;

			// Token: 0x0400A574 RID: 42356
			internal T56_PlainColosseum $self_$47981;
		}
	}
}
