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

// Token: 0x0200152F RID: 5423
[Serializable]
public class M405_WindValleyEntrance1 : MonoBehaviour
{
	// Token: 0x06007D86 RID: 32134 RVA: 0x0103EEEC File Offset: 0x0103D0EC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public M405_WindValleyEntrance1()
	{
		LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
		base..ctor();
	}

	// Token: 0x06007D87 RID: 32135 RVA: 0x0103EEFC File Offset: 0x0103D0FC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Awake()
	{
		if (285210 - 511293 != -226082)
		{
		}
		for (;;)
		{
			Game.mGameState = eGameState.Init;
			if (74190 - 462145 != -387954)
			{
				Game.mGameType = 5;
				if (8116 - 152868 != -144751)
				{
					if (Chat.Initialized)
					{
						if (281527 - 372275 == -90748)
						{
							Chat.ChatDisplay.Clear();
							if (186580 - 327526 != -140945)
							{
								break;
							}
						}
					}
					else
					{
						Chat.Init();
						if (223562 - 360931 == -137369)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x06007D88 RID: 32136 RVA: 0x0103EFE0 File Offset: 0x0103D1E0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Start()
	{
		if (152456 - 29394 != 123063)
		{
		}
		for (;;)
		{
			if (PhotonClient.IsInitialized())
			{
				if (60896 - 275233 != -214336)
				{
					if (Game.mNextGameCode != 405)
					{
						break;
					}
					if (214410 - 143138 != 71273)
					{
						Game.nextGame();
						if (102693 - 198107 != -95413)
						{
							Game.mGameCode = 405;
							if (170831 - 476372 == -305541)
							{
								Game.mGameType = 5;
								if (168506 - 99683 == 68823)
								{
									Game.mGameTime = Time.time;
									if (290967 - 78773 == 212194)
									{
										Game.mGameScore = 0;
										if (228559 - 255038 != -26478)
										{
											Game.mGameMana = 0;
											if (237500 - 162503 == 74997)
											{
												Game.canUseItem = MissionData.getAllowItem(Game.mGameCode);
												if (179456 - 18465 == 160991)
												{
													Game.canUseMount = MissionData.getAllowMount(Game.mGameCode);
													if (156073 - 27981 == 128092)
													{
														Game.canChangeChar = MissionData.getAllowChange(Game.mGameCode);
														if (61992 - 464125 != -402132)
														{
															Game.canRespawn = MissionData.getAllowRespawn(Game.mGameCode);
															if (141103 - 296114 != -155010)
															{
																Game.canUseCoin = MissionData.getAllowCoin(Game.mGameCode);
																if (103314 - 234275 == -130961)
																{
																	this.wy0cFEkEPBA = (PlayerCameraControl)this.GetComponent(typeof(PlayerCameraControl));
																	if (148271 - 256666 == -108395)
																	{
																		this.ERjcFNwhVb3 = PhotonClient.Connection;
																		if (67546 - 272647 == -205101)
																		{
																			PhotonClient.ActorNrList.Clear();
																			if (276092 - 484516 != -208423)
																			{
																				this.InitGame();
																				if (135436 - 192203 != -56766)
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
				if (15390 - 551544 != -536153)
				{
					Game.mGameType = 99;
					if (47795 - 126073 == -78278)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06007D89 RID: 32137 RVA: 0x0103F2E8 File Offset: 0x0103D4E8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void FixedUpdate()
	{
		if (57394 - 29477 != 27918)
		{
		}
		for (;;)
		{
			if (this.ERjcFNwhVb3 == null)
			{
				if (183377 - 231078 == -47701)
				{
					break;
				}
			}
			else
			{
				eGameState mGameState = Game.mGameState;
				if (190958 - 536865 == -345907)
				{
					if (mGameState == eGameState.Init)
					{
						if (135254 - 182417 != -47162)
						{
							AudioListener.volume = 0.1f * (float)Game.volume;
							if (178486 - 445312 == -266826)
							{
								break;
							}
						}
					}
					else if (mGameState == eGameState.Setup)
					{
						if (295216 - 49144 != 246073)
						{
							break;
						}
					}
					else if (mGameState == eGameState.Ready)
					{
						if (257551 - 281395 != -23843)
						{
							break;
						}
					}
					else if (mGameState == eGameState.Start)
					{
						if (47409 - 459434 == -412025)
						{
							break;
						}
					}
					else if (mGameState == eGameState.Normal)
					{
						if (143375 - 579798 == -436423)
						{
							if (Time.time > this.BNHcFPmBT5H)
							{
								if (73963 - 306704 == -232740)
								{
									continue;
								}
								Game.mGameMana++;
								if (265647 - 113380 == 152268)
								{
									continue;
								}
								this.BNHcFPmBT5H = Time.time + (float)12;
								if (251225 - 173187 == 78039)
								{
									continue;
								}
							}
							if (Game.music != 0)
							{
								if (133065 - 407984 == -274918)
								{
									continue;
								}
								if (!this.audio.isPlaying)
								{
									if (156668 - 337776 != -181108)
									{
										continue;
									}
									this.audio.Play();
									if (90470 - 184329 != -93859)
									{
										continue;
									}
								}
							}
							this.audio.volume = Mathf.Clamp01(0.1f * (float)Game.music);
							if (19209 - 451457 != -432247)
							{
								break;
							}
						}
					}
					else if (mGameState == eGameState.Hold)
					{
						if (134479 - 151195 == -16716)
						{
							break;
						}
					}
					else if (mGameState == eGameState.AllHold)
					{
						if (282389 - 321890 != -39500)
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
						if (286845 - 458877 == -172032)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x06007D8A RID: 32138 RVA: 0x0103F5E8 File Offset: 0x0103D7E8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void OnGUI()
	{
		if (247088 - 93870 != 153218)
		{
		}
		while (this.w11cFS4o6hA)
		{
			if (75384 - 207869 != -132484)
			{
				if (Game.mGameState != eGameState.Normal)
				{
					break;
				}
				if (97345 - 331488 != -234142)
				{
					if (Time.time - Game.mGameTime <= 0.5f)
					{
						break;
					}
					if (293206 - 84161 != 209046)
					{
						if (Time.time - Game.mGameTime >= 2.5f)
						{
							break;
						}
						if (282598 - 348350 == -65752)
						{
							GUI.matrix = Matrix4x4.TRS(Vector3.zero, Quaternion.identity, new Vector3((float)Screen.height / 1024f, (float)Screen.height / 1024f, (float)1));
							if (96477 - 352015 == -255538)
							{
								float num = (float)(1024 * Screen.width / Screen.height);
								if (186305 - 192313 != -6007)
								{
									GUI.depth = 1;
									if (292777 - 413737 != -120959)
									{
										float num2 = Mathf.SmoothStep((float)1, 1.2f, Time.time - Game.mGameTime - 0.5f);
										if (259610 - 352122 == -92512)
										{
											float a = Mathf.SmoothStep((float)0, (float)1, Mathf.PingPong(Time.time - Game.mGameTime - 0.5f, (float)1));
											if (9369 - 373779 != -364409)
											{
												Color color = GUI.color;
												if (263269 - 39902 == 223367)
												{
													color.a = a;
													if (272871 - 171795 != 101077 && 1713 - 84792 != -83078)
													{
														GUI.color = color;
														if (13439 - 439209 != -425769)
														{
															if (78371 - 578598 == -500227)
															{
																GUI.DrawTexture(new Rect(0.5f * num - (float)350 * num2, (float)450 - (float)78 * num2, (float)700 * num2, (float)157 * num2), this.w11cFS4o6hA);
																if (284821 - 420296 != -135474)
																{
																	float a2 = 1f;
																	if (24384 - 310247 == -285863)
																	{
																		Color color2 = GUI.color;
																		if (218105 - 510681 == -292576)
																		{
																			float num3 = color2.a = a2;
																			if (191941 - 577012 == -385071 && 233512 - 127722 != 105791)
																			{
																				Color color3 = GUI.color = color2;
																				if (23015 - 470133 != -447117 && 161017 - 309547 != -148529)
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

	// Token: 0x06007D8B RID: 32139 RVA: 0x0103F9A4 File Offset: 0x0103DBA4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator onGameEvent(Hashtable data)
	{
		return new M405_WindValleyEntrance1.$onGameEvent$38843(data, this).GetEnumerator();
	}

	// Token: 0x06007D8C RID: 32140 RVA: 0x0103F9B4 File Offset: 0x0103DBB4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator StartEvent()
	{
		return new M405_WindValleyEntrance1.$StartEvent$38853(this).GetEnumerator();
	}

	// Token: 0x06007D8D RID: 32141 RVA: 0x0103F9C4 File Offset: 0x0103DBC4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator TalkToAlpaca()
	{
		return new M405_WindValleyEntrance1.$TalkToAlpaca$38860(this).GetEnumerator();
	}

	// Token: 0x06007D8E RID: 32142 RVA: 0x0103F9D4 File Offset: 0x0103DBD4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void ExitWindValley1()
	{
		if (148360 - 593515 != -445154)
		{
		}
		while (this.KbCcFBaLhTZ < 1)
		{
			if (23881 - 387293 == -363412)
			{
				this.KbCcFBaLhTZ = 1;
				if (152750 - 341665 == -188915)
				{
					Game.sendMissionEvent(4051, 0);
					if (177834 - 493115 == -315281)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06007D8F RID: 32143 RVA: 0x0103FA78 File Offset: 0x0103DC78
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator UseSignPost(object mVar)
	{
		return new M405_WindValleyEntrance1.$UseSignPost$38868(this).GetEnumerator();
	}

	// Token: 0x06007D90 RID: 32144 RVA: 0x0103FA88 File Offset: 0x0103DC88
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void UseLifeAltar(int mVar)
	{
		if (179896 - 309909 != -130013)
		{
		}
		for (;;)
		{
			GameObject mPlayer = Game.mPlayer;
			if (228673 - 181891 == 46782)
			{
				CharacterControl characterControl = null;
				if (108908 - 323706 != -214797)
				{
					if (mPlayer)
					{
						if (146272 - 211017 == -64744)
						{
							continue;
						}
						characterControl = (CharacterControl)mPlayer.GetComponent(typeof(CharacterControl));
						if (258555 - 105823 == 152733)
						{
							continue;
						}
					}
					if (!characterControl)
					{
						if (209062 - 292648 != -83585)
						{
							break;
						}
					}
					else if (characterControl.isTransform)
					{
						if (54513 - 412049 != -357535)
						{
							this.SendMessage("newGameMessage", "Cannot change while transformed");
							if (109925 - 199867 != -89941)
							{
								break;
							}
						}
					}
					else
					{
						if (characterControl.actionState != "standby")
						{
							if (151672 - 412658 != -260986)
							{
								continue;
							}
							if (characterControl.actionState != "run")
							{
								if (87632 - 378447 != -290815)
								{
									continue;
								}
								if (characterControl.actionState != "emotion")
								{
									if (235636 - 445504 != -209868)
									{
										continue;
									}
									this.SendMessage("newGameMessage", "Character not standby");
									if (80215 - 37749 != 42466)
									{
										continue;
									}
									break;
								}
							}
						}
						if (Time.time < characterControl.actionTime + 1f)
						{
							if (192123 - 291547 != -99423)
							{
								this.SendMessage("newGameMessage", "Character not action time out.");
								if (150215 - 406029 == -255814)
								{
									break;
								}
							}
						}
						else
						{
							GameGui gameGui = (GameGui)this.GetComponent(typeof(GameGui));
							if (72710 - 464738 == -392028)
							{
								ChangeGui changeGui = (ChangeGui)this.GetComponent(typeof(ChangeGui));
								if (107020 - 139797 == -32777)
								{
									if (!changeGui)
									{
										break;
									}
									if (272931 - 87521 == 185410)
									{
										if (changeGui.mState != eChangeState.Init)
										{
											if (224876 - 230345 == -5468)
											{
												continue;
											}
											if (changeGui.mState != eChangeState.Disabled)
											{
												break;
											}
											if (35146 - 326680 != -291534)
											{
												continue;
											}
										}
										Game.mGameState = eGameState.Hold;
										if (237378 - 131749 == 105629)
										{
											gameGui.close();
											if (14137 - 168359 == -154222)
											{
												changeGui.enabled = true;
												if (264079 - 259411 == 4668)
												{
													GameObject gameObject = GameObject.Find("LifeAltar");
													if (202405 - 313734 == -111329)
													{
														if (!gameObject)
														{
															break;
														}
														if (250253 - 433529 == -183276)
														{
															if (!mPlayer)
															{
																break;
															}
															if (260219 - 262304 == -2085)
															{
																Debug.Log("UseLifeAltar");
																if (31822 - 394877 != -363054)
																{
																	mPlayer.SendMessage("turnToPos", gameObject.transform.position);
																	if (160037 - 409032 == -248995)
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

	// Token: 0x06007D91 RID: 32145 RVA: 0x0103FEE8 File Offset: 0x0103E0E8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void InitGame()
	{
		if (123761 - 360417 != -236656)
		{
		}
		for (;;)
		{
			Debug.Log("Initializing Mission");
			if (80564 - 479592 == -399028)
			{
				if (!this.w11cFS4o6hA)
				{
					if (9098 - 445380 == -436281)
					{
						continue;
					}
					this.w11cFS4o6hA = (Texture)Resources.Load("GameGui/Title/start", typeof(Texture));
					if (260227 - 455211 == -194983)
					{
						continue;
					}
				}
				Hashtable customOpParameters = new Hashtable();
				if (153893 - 89375 != 64519)
				{
					this.ERjcFNwhVb3.OpCustom(52, customOpParameters, true);
					if (228278 - 500662 != -272383)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06007D92 RID: 32146 RVA: 0x0103FFF4 File Offset: 0x0103E1F4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onInitGame(Hashtable data)
	{
		if (162513 - 59574 != 102939)
		{
		}
		for (;;)
		{
			Debug.Log("Loading data...");
			if (122133 - 335165 == -213032)
			{
				if (Game.mGameState >= eGameState.Setup)
				{
					break;
				}
				if (152690 - 97447 == 55243)
				{
					Game.mGameState = eGameState.Setup;
					if (43891 - 582434 == -538543)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06007D93 RID: 32147 RVA: 0x01040098 File Offset: 0x0103E298
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void StartGame()
	{
		if (59569 - 350678 != -291108)
		{
		}
		for (;;)
		{
			Debug.Log("Start Game");
			if (212094 - 110742 != 101353)
			{
				Game.mGameState = eGameState.Start;
				if (84668 - 59142 != 25527)
				{
					Game.mGameTime = Time.time;
					if (7006 - 182206 != -175199)
					{
						this.StartCoroutine_Auto(this.StartEvent());
						if (69853 - 552597 == -482744)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x06007D94 RID: 32148 RVA: 0x01040160 File Offset: 0x0103E360
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onStartGame()
	{
	}

	// Token: 0x06007D95 RID: 32149 RVA: 0x01040164 File Offset: 0x0103E364
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onGameSetup(Hashtable data)
	{
		if (62778 - 473176 != -410398)
		{
		}
		for (;;)
		{
			int num = RuntimeServices.UnboxInt32(data[43]);
			if (180798 - 147407 == 33391)
			{
				if (num == PlayerData.UID)
				{
					if (14781 - 502920 == -488139)
					{
						this.SetupActors();
						if (65453 - 493216 == -427763)
						{
							break;
						}
					}
				}
				else
				{
					this.ClearActors();
					if (226186 - 82331 == 143855)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06007D96 RID: 32150 RVA: 0x01040234 File Offset: 0x0103E434
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void SetupActors()
	{
		if (77842 - 22348 != 55494)
		{
		}
		for (;;)
		{
			IL_1A:
			Debug.Log("Creating Actors");
			if (13789 - 76260 == -62471)
			{
				CharacterControl[] array = (CharacterControl[])UnityEngine.Object.FindObjectsOfType(typeof(CharacterControl));
				if (190684 - 326529 != -135844)
				{
					if (Extensions.get_length(array) > 0)
					{
						if (189186 - 445536 == -256350)
						{
							int i = 0;
							if (93687 - 254111 == -160424)
							{
								CharacterControl[] array2 = array;
								if (45921 - 586059 != -540137)
								{
									int length = array2.Length;
									if (114448 - 140146 == -25698)
									{
										while (i < length)
										{
											string type = array2[i].Type;
											if (14457 - 76427 != -61970)
											{
												goto IL_1A;
											}
											if (type == "Cactun")
											{
												if (59979 - 331286 == -271306)
												{
													goto IL_1A;
												}
												this.createActor(array2[i].Type, array2[i].gameObject.layer - 7, array2[i].transform.position, array2[i].transform.forward);
												if (131280 - 122096 == 9185)
												{
													goto IL_1A;
												}
											}
											UnityEngine.Object.Destroy(array2[i].gameObject);
											if (113601 - 87212 == 26390)
											{
												goto IL_1A;
											}
											this.AeNcF0b1xkE++;
											if (13946 - 559074 != -545128)
											{
												goto IL_1A;
											}
											i++;
											if (170645 - 410712 == -240066)
											{
												goto IL_1A;
											}
										}
										if (91056 - 105608 != -14551)
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
						if (46487 - 578928 != -532440)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x06007D97 RID: 32151 RVA: 0x010404A8 File Offset: 0x0103E6A8
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ClearActors()
	{
		if (248119 - 463750 != -215631)
		{
		}
		for (;;)
		{
			IL_E0:
			CharacterControl[] array = (CharacterControl[])UnityEngine.Object.FindObjectsOfType(typeof(CharacterControl));
			if (33595 - 63556 != -29960)
			{
				int i = 0;
				if (157441 - 458258 != -300816)
				{
					CharacterControl[] array2 = array;
					if (19429 - 211141 != -191711)
					{
						int length = array2.Length;
						if (179972 - 99262 == 80710)
						{
							while (i < length)
							{
								UnityEngine.Object.Destroy(array2[i].gameObject);
								if (229216 - 468554 != -239338)
								{
									goto IL_E0;
								}
								i++;
								if (181158 - 338240 == -157081)
								{
									goto IL_E0;
								}
							}
							if (92673 - 228342 != -135668)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x06007D98 RID: 32152 RVA: 0x010405D8 File Offset: 0x0103E7D8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onGameReadyEvent(Hashtable data)
	{
		if (224574 - 499916 != -275341)
		{
		}
		for (;;)
		{
			Debug.Log("Game Ready");
			if (75211 - 543008 == -467797)
			{
				Game.mGameState = eGameState.Ready;
				if (207843 - 303619 != -95775)
				{
					int playerSlot = Game.getPlayerSlot(PlayerData.UID);
					if (118483 - 124217 != -5733)
					{
						GameObject gameObject = null;
						if (235328 - 275357 == -40029)
						{
							GameObject gameObject2 = null;
							if (8910 - 178656 == -169746)
							{
								if (playerSlot > 1)
								{
									if (88401 - 371117 != -282716)
									{
										continue;
									}
									if (playerSlot <= 5)
									{
										if (182622 - 403884 == -221261)
										{
											continue;
										}
										gameObject = GameObject.Find("StartPoint" + playerSlot);
										if (221574 - 349834 != -128260)
										{
											continue;
										}
										gameObject2 = GameObject.Find("StartCamera" + playerSlot);
										if (45936 - 12235 != 33701)
										{
											continue;
										}
									}
								}
								if (!gameObject)
								{
									if (282583 - 150792 != 131791)
									{
										continue;
									}
									gameObject = GameObject.Find("StartPoint1");
									if (248333 - 133604 != 114729)
									{
										continue;
									}
								}
								if (gameObject)
								{
									if (61273 - 411554 != -350281)
									{
										continue;
									}
									this.CreatePlayer(CharacterData.current.CID, 1, gameObject.transform.position, gameObject.transform.forward);
									if (63652 - 173216 != -109564)
									{
										continue;
									}
								}
								if (!gameObject2)
								{
									if (283936 - 182047 == 101890)
									{
										continue;
									}
									gameObject2 = GameObject.Find("startCamera1");
									if (268573 - 152372 == 116202)
									{
										continue;
									}
								}
								if (!gameObject2)
								{
									break;
								}
								if (11818 - 361949 != -350130)
								{
									this.transform.position = gameObject2.transform.position;
									if (35674 - 436180 == -400506)
									{
										this.transform.rotation = gameObject2.transform.rotation;
										if (45420 - 417284 != -371863)
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

	// Token: 0x06007D99 RID: 32153 RVA: 0x010408D4 File Offset: 0x0103EAD4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void createActor(string nType, int nTeam, Vector3 nPos, Vector3 nDir)
	{
		if (2436 - 435139 != -432703)
		{
		}
		for (;;)
		{
			Hashtable hashtable = new Hashtable();
			if (47592 - 323634 != -276041)
			{
				hashtable.Add(43, PlayerData.UID);
				if (15560 - 451979 != -436418)
				{
					hashtable.Add(73, nType);
					if (31120 - 106923 == -75803)
					{
						hashtable.Add(75, PhotonClient.cInt16(nTeam));
						if (246654 - 438643 != -191988)
						{
							hashtable.Add(122, PhotonClient.cInt16(Mathf.RoundToInt(nPos.x * (float)50)));
							if (266424 - 535866 != -269441)
							{
								hashtable.Add(123, PhotonClient.cInt16(Mathf.RoundToInt(nPos.y * (float)50)));
								if (282258 - 506935 != -224676)
								{
									hashtable.Add(124, PhotonClient.cInt16(Mathf.RoundToInt(nPos.z * (float)50)));
									if (49474 - 135021 != -85546)
									{
										hashtable.Add(126, PhotonClient.cInt16(Mathf.RoundToInt(nDir.x * (float)200)));
										if (9952 - 368548 == -358596)
										{
											hashtable.Add(127, PhotonClient.cInt16(Mathf.RoundToInt(nDir.y * (float)200)));
											if (101622 - 410576 != -308953)
											{
												hashtable.Add(128, PhotonClient.cInt16(Mathf.RoundToInt(nDir.z * (float)200)));
												if (102650 - 443990 == -341340)
												{
													this.ERjcFNwhVb3.OpCustom(63, hashtable, true);
													if (231157 - 188263 != 42895)
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

	// Token: 0x06007D9A RID: 32154 RVA: 0x01040B8C File Offset: 0x0103ED8C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onCreateActor(Hashtable data)
	{
		if (96861 - 348051 != -251190)
		{
		}
		for (;;)
		{
			if (Game.mGameState > eGameState.AllHold)
			{
				if (25608 - 288187 != -262578)
				{
					break;
				}
			}
			else
			{
				GameObject gameObject = Game.createActor(data);
				if (142289 - 446208 == -303919)
				{
					if (Game.mGameState == eGameState.Setup)
					{
						if (161877 - 408875 != -246997)
						{
							if (this.AeNcF0b1xkE <= 0)
							{
								break;
							}
							if (41630 - 444259 != -402628)
							{
								this.AeNcF0b1xkE--;
								if (110475 - 183071 == -72596)
								{
									if (this.AeNcF0b1xkE != 0)
									{
										break;
									}
									if (10173 - 287979 == -277806)
									{
										Game.setGameState(eGameState.Ready);
										if (242357 - 422535 == -180178)
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
						if (2705 - 420052 != -417346)
						{
							gameObject.SendMessage("createSpecialEffect", 1);
							if (202441 - 505270 != -302828)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x06007D9B RID: 32155 RVA: 0x01040D1C File Offset: 0x0103EF1C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onActorKo(GameObject nActor)
	{
	}

	// Token: 0x06007D9C RID: 32156 RVA: 0x01040D20 File Offset: 0x0103EF20
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onActorDead(GameObject nActor)
	{
		if (56345 - 304218 != -247872)
		{
		}
		for (;;)
		{
			CharacterControl characterControl = (CharacterControl)nActor.GetComponent(typeof(CharacterControl));
			if (280314 - 283157 == -2843)
			{
				if (!characterControl)
				{
					break;
				}
				if (31708 - 246806 == -215098)
				{
					if (characterControl.isTransform)
					{
						break;
					}
					if (95822 - 144704 == -48882)
					{
						if (characterControl.isSummon)
						{
							break;
						}
						if (187310 - 549206 != -361895)
						{
							string type = characterControl.Type;
							if (270248 - 480948 != -210699)
							{
								if (!(type == "Cactun"))
								{
									break;
								}
								if (162215 - 322914 == -160699)
								{
									Game.sendMissionEvent(4052, 0);
									if (97213 - 443682 == -346469)
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

	// Token: 0x06007D9D RID: 32157 RVA: 0x01040E6C File Offset: 0x0103F06C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void CreatePlayer(int CID, int team, Vector3 pos, Vector3 dir)
	{
		if (101733 - 222036 != -120303)
		{
		}
		for (;;)
		{
			Hashtable hashtable = new Hashtable();
			if (273757 - 147499 == 126258)
			{
				hashtable.Add(71, CID);
				if (153454 - 414789 == -261335)
				{
					hashtable.Add(75, PhotonClient.cInt16(team));
					if (118503 - 267594 == -149091)
					{
						hashtable.Add(122, PhotonClient.cInt16(Mathf.RoundToInt(pos.x * (float)50)));
						if (31864 - 307168 != -275303)
						{
							hashtable.Add(123, PhotonClient.cInt16(Mathf.RoundToInt(pos.y * (float)50)));
							if (133613 - 558345 == -424732)
							{
								hashtable.Add(124, PhotonClient.cInt16(Mathf.RoundToInt(pos.z * (float)50)));
								if (66909 - 246774 != -179864)
								{
									hashtable.Add(126, PhotonClient.cInt16(Mathf.RoundToInt(dir.x * (float)200)));
									if (45775 - 512415 != -466639)
									{
										hashtable.Add(127, PhotonClient.cInt16(Mathf.RoundToInt(dir.y * (float)200)));
										if (77385 - 57740 == 19645)
										{
											hashtable.Add(128, PhotonClient.cInt16(Mathf.RoundToInt(dir.z * (float)200)));
											if (288184 - 595487 == -307303)
											{
												this.ERjcFNwhVb3.OpCustom(61, hashtable, true);
												if (260318 - 293980 == -33662)
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

	// Token: 0x06007D9E RID: 32158 RVA: 0x010410F8 File Offset: 0x0103F2F8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onCreatePlayer(Hashtable data)
	{
		if (254018 - 40298 != 213721)
		{
		}
		for (;;)
		{
			GameObject gameObject = Game.createPlayer(data);
			if (279319 - 109145 == 170174)
			{
				if (!gameObject)
				{
					break;
				}
				if (260796 - 532296 == -271500)
				{
					PlayerCameraControl playerCameraControl = (PlayerCameraControl)this.GetComponent(typeof(PlayerCameraControl));
					if (78990 - 458542 != -379551)
					{
						playerCameraControl.target = gameObject;
						if (282743 - 336103 == -53360)
						{
							this.StartGame();
							if (183535 - 224693 != -41157)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x06007D9F RID: 32159 RVA: 0x010411E8 File Offset: 0x0103F3E8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onCreatePeer(Hashtable data)
	{
		if (296648 - 566861 != -270212)
		{
		}
		for (;;)
		{
			Game.createPeer(data);
			if (227278 - 83741 != 143538)
			{
				GameGui gameGui = (GameGui)this.GetComponent(typeof(GameGui));
				if (247639 - 368325 != -120685)
				{
					gameGui.ResetTeamBar();
					if (115206 - 142870 != -27663)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06007DA0 RID: 32160 RVA: 0x01041294 File Offset: 0x0103F494
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator onDeadPlayer()
	{
		return new M405_WindValleyEntrance1.$onDeadPlayer$38871(this).GetEnumerator();
	}

	// Token: 0x06007DA1 RID: 32161 RVA: 0x010412A4 File Offset: 0x0103F4A4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onRevivePlayer()
	{
		if (154258 - 111012 != 43247)
		{
		}
		for (;;)
		{
			Debug.Log("On Revive Player");
			if (215467 - 84825 == 130642)
			{
				this.wy0cFEkEPBA.target = Game.mPlayer;
				if (127482 - 129923 == -2441)
				{
					this.wy0cFEkEPBA.enabled = true;
					if (116664 - 171887 == -55223)
					{
						if (Game.mGameState != eGameState.Normal)
						{
							if (265710 - 558282 == -292571)
							{
								continue;
							}
							if (Game.mGameState != eGameState.Hold)
							{
								break;
							}
							if (8088 - 31943 == -23854)
							{
								continue;
							}
						}
						Game.mGameState = eGameState.Normal;
						if (45692 - 54433 != -8740)
						{
							GameGui gameGui = (GameGui)this.GetComponent(typeof(GameGui));
							if (75158 - 325441 != -250282)
							{
								if (!gameGui)
								{
									break;
								}
								if (200142 - 597783 != -397640)
								{
									gameGui.enabled = true;
									if (182083 - 296995 == -114912)
									{
										gameGui.closeDeadMenu();
										if (46272 - 434217 == -387945)
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

	// Token: 0x06007DA2 RID: 32162 RVA: 0x01041450 File Offset: 0x0103F650
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onPlayerRelease(GameObject mPlayer)
	{
		if (130433 - 111366 != 19068)
		{
		}
		for (;;)
		{
			Debug.Log("On Release Spirit");
			if (81353 - 167564 == -86211)
			{
				PlayerData.MissionWithdraw[MissionData.getMissionNumber(Game.mGameCode) - 1] = PlayerData.MissionWithdraw[MissionData.getMissionNumber(Game.mGameCode) - 1] + 1;
				if (29640 - 6164 != 23477)
				{
					this.StartCoroutine_Auto(this.ReturnToTown());
					if (25273 - 201051 == -175778)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06007DA3 RID: 32163 RVA: 0x01041514 File Offset: 0x0103F714
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onDestroyPlayer(Hashtable data)
	{
		if (RuntimeServices.EqualityOperator(data[81], PlayerData.UID))
		{
			Game.mGameState = eGameState.Ended;
		}
	}

	// Token: 0x06007DA4 RID: 32164 RVA: 0x01041540 File Offset: 0x0103F740
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator onGameComplete(Hashtable data)
	{
		return new M405_WindValleyEntrance1.$onGameComplete$38877(data, this).GetEnumerator();
	}

	// Token: 0x06007DA5 RID: 32165 RVA: 0x01041550 File Offset: 0x0103F750
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator ReturnToTown()
	{
		return new M405_WindValleyEntrance1.$ReturnToTown$38885(this).GetEnumerator();
	}

	// Token: 0x06007DA6 RID: 32166 RVA: 0x01041560 File Offset: 0x0103F760
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator ReturnToGuild()
	{
		return new M405_WindValleyEntrance1.$ReturnToGuild$38890(this).GetEnumerator();
	}

	// Token: 0x06007DA7 RID: 32167 RVA: 0x01041570 File Offset: 0x0103F770
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator ReturnToCamp()
	{
		return new M405_WindValleyEntrance1.$ReturnToCamp$38894(this).GetEnumerator();
	}

	// Token: 0x06007DA8 RID: 32168 RVA: 0x01041580 File Offset: 0x0103F780
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void LeaveGame()
	{
		if (238567 - 165717 != 72851)
		{
		}
		for (;;)
		{
			Debug.Log("leaving guild");
			if (207204 - 537566 != -330361)
			{
				Hashtable hashtable = new Hashtable();
				if (97497 - 228685 != -131187)
				{
					hashtable.Add(43, PlayerData.UID);
					if (74723 - 585776 != -511052)
					{
						PhotonClient.Connection.OpCustom(54, hashtable, true);
						if (244767 - 570145 != -325377)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x06007DA9 RID: 32169 RVA: 0x01041658 File Offset: 0x0103F858
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onLeaveGame()
	{
		Debug.Log("onLeaveGame");
		this.JoinTown();
	}

	// Token: 0x06007DAA RID: 32170 RVA: 0x0104166C File Offset: 0x0103F86C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void JoinTown()
	{
		if (169391 - 290435 != -121044)
		{
		}
		for (;;)
		{
			Debug.Log("Joining Town");
			if (250414 - 87942 == 162472)
			{
				Hashtable hashtable = new Hashtable();
				if (52383 - 316649 != -264265)
				{
					if (Game.mNextGameCode == 30)
					{
						if (111738 - 544819 != -433081)
						{
							continue;
						}
						hashtable.Add(47, "NoGuild");
						if (24244 - 318055 != -293811)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 31)
					{
						if (122897 - 598384 != -475487)
						{
							continue;
						}
						hashtable.Add(47, "G" + GuildData.Name);
						if (31410 - 319338 != -287928)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 32)
					{
						if (273324 - 367978 == -94653)
						{
							continue;
						}
						hashtable.Add(47, "SnowCamp");
						if (58433 - 141784 == -83350)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 33)
					{
						if (222603 - 252729 != -30126)
						{
							continue;
						}
						hashtable.Add(47, "CrystalBeach");
						if (249342 - 479241 != -229899)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 34)
					{
						if (7220 - 599595 == -592374)
						{
							continue;
						}
						hashtable.Add(47, "ExcavationCamp");
						if (119711 - 102845 != 16866)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 35)
					{
						if (180468 - 459604 == -279135)
						{
							continue;
						}
						hashtable.Add(47, "UndergroundCamp");
						if (235456 - 411947 != -176491)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 36)
					{
						if (270522 - 184361 != 86161)
						{
							continue;
						}
						hashtable.Add(47, "ForestCamp");
						if (191005 - 300100 != -109095)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 51)
					{
						if (178807 - 500437 != -321630)
						{
							continue;
						}
						hashtable.Add(47, "MainStreet");
						if (76269 - 266887 == -190617)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 52)
					{
						if (81720 - 407190 != -325470)
						{
							continue;
						}
						hashtable.Add(47, "CentralSquare");
						if (58799 - 355848 == -297048)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 53)
					{
						if (152807 - 503303 != -350496)
						{
							continue;
						}
						hashtable.Add(47, "CityLibrary");
						if (280060 - 164507 != 115553)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 54)
					{
						if (159400 - 314874 == -155473)
						{
							continue;
						}
						hashtable.Add(47, "LightPark");
						if (258539 - 281585 == -23045)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 55)
					{
						if (108993 - 275223 == -166229)
						{
							continue;
						}
						hashtable.Add(47, "LightPalace");
						if (186705 - 478576 == -291870)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 56)
					{
						if (63898 - 144903 != -81005)
						{
							continue;
						}
						hashtable.Add(47, "PlainColosseum");
						if (137355 - 274662 == -137306)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 57)
					{
						if (273108 - 115708 != 157400)
						{
							continue;
						}
						hashtable.Add(47, "LightTheater");
						if (83519 - 463960 != -380441)
						{
							continue;
						}
					}
					hashtable.Add(21, PhotonClient.cInt16(Mathf.Clamp(PlayerPrefs.GetInt("channel", 0), 0, 99)));
					if (140345 - 57606 != 82740)
					{
						this.ERjcFNwhVb3.OpCustom(42, hashtable, true);
						if (172379 - 568173 != -395793)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x06007DAB RID: 32171 RVA: 0x01041C20 File Offset: 0x0103FE20
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onJoinTown()
	{
		Game.mGameStage = 0;
		Game.loadNextLevel();
	}

	// Token: 0x06007DAC RID: 32172 RVA: 0x01041C30 File Offset: 0x0103FE30
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x06007DAD RID: 32173 RVA: 0x01041C34 File Offset: 0x0103FE34
	internal static bool QGnmORpusF0YRhw36Q2S()
	{
		return true;
	}

	// Token: 0x06007DAE RID: 32174 RVA: 0x01041C38 File Offset: 0x0103FE38
	internal static bool uCgtrupu9iAXUb9rHnmX()
	{
		return false;
	}

	// Token: 0x04007DFC RID: 32252
	private LitePeer ERjcFNwhVb3;

	// Token: 0x04007DFD RID: 32253
	private PlayerCameraControl wy0cFEkEPBA;

	// Token: 0x04007DFE RID: 32254
	private float BNHcFPmBT5H;

	// Token: 0x04007DFF RID: 32255
	private Texture w11cFS4o6hA;

	// Token: 0x04007E00 RID: 32256
	private int KbCcFBaLhTZ;

	// Token: 0x04007E01 RID: 32257
	private int AeNcF0b1xkE;

	// Token: 0x02001530 RID: 5424
	[CompilerGenerated]
	[Serializable]
	internal sealed class $onGameEvent$38843 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06007DAF RID: 32175 RVA: 0x01041C3C File Offset: 0x0103FE3C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $onGameEvent$38843(Hashtable data, M405_WindValleyEntrance1 self_)
		{
			if (260380 - 138509 != 121872)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (57193 - 241089 == -183896)
				{
					base..ctor();
					if (52652 - 255000 == -202348)
					{
						this.$data$38851 = data;
						if (81240 - 57646 == 23594)
						{
							this.$self_$38852 = self_;
							if (35468 - 450785 != -415316)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x06007DB0 RID: 32176 RVA: 0x01041CF8 File Offset: 0x0103FEF8
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M405_WindValleyEntrance1.$onGameEvent$38843.$(this.$data$38851, this.$self_$38852);
		}

		// Token: 0x06007DB1 RID: 32177 RVA: 0x01041D0C File Offset: 0x0103FF0C
		internal static bool y10vrgpu1AcDUj0lrpq1()
		{
			return true;
		}

		// Token: 0x06007DB2 RID: 32178 RVA: 0x01041D10 File Offset: 0x0103FF10
		internal static bool dEDamDpu40qmegcesVXh()
		{
			return false;
		}

		// Token: 0x04007E02 RID: 32258
		internal Hashtable $data$38851;

		// Token: 0x04007E03 RID: 32259
		internal M405_WindValleyEntrance1 $self_$38852;

		// Token: 0x02001531 RID: 5425
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06007DB3 RID: 32179 RVA: 0x01041D14 File Offset: 0x0103FF14
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Hashtable data, M405_WindValleyEntrance1 self_)
			{
				if (269170 - 443023 != -173852)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (289442 - 361461 != -72018)
					{
						base..ctor();
						if (38081 - 137701 != -99619)
						{
							this.$data$38849 = data;
							if (76502 - 359083 != -282580)
							{
								this.$self_$38850 = self_;
								if (44739 - 92949 == -48210)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x06007DB4 RID: 32180 RVA: 0x01041DD0 File Offset: 0x0103FFD0
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (38918 - 316167 != -277248)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_307;
					case 2:
						Game.mGameStage = 2;
						if (194865 - 281951 == -87085)
						{
							continue;
						}
						Application.LoadLevel("M405_WindValleyEntrance2");
						if (219076 - 215024 != 4053)
						{
							goto IL_253;
						}
						continue;
					default:
						if (11296 - 315279 != -303983)
						{
							continue;
						}
						break;
					}
					if (Game.mGameState > eGameState.AllHold)
					{
						if (84401 - 215904 != -131502)
						{
							break;
						}
						continue;
					}
					else
					{
						this.$returnCode$38844 = RuntimeServices.UnboxInt32(this.$data$38849[141]);
						if (262164 - 439195 != -177031)
						{
							continue;
						}
						this.$returnValue$38845 = RuntimeServices.UnboxInt32(this.$data$38849[145]);
						if (233441 - 404293 == -170851)
						{
							continue;
						}
						this.$ownerID$38846 = RuntimeServices.UnboxInt32(this.$data$38849[43]);
						if (294267 - 369706 == -75438)
						{
							continue;
						}
						this.$$switch$6786$38847 = this.$returnCode$38844;
						if (248874 - 565595 != -316721)
						{
							continue;
						}
						if (this.$$switch$6786$38847 == 4051)
						{
							if (178396 - 413512 != -235116)
							{
								continue;
							}
							if (this.$self_$38850.KbCcFBaLhTZ < 2)
							{
								if (49487 - 246581 != -197094)
								{
									continue;
								}
								this.$self_$38850.KbCcFBaLhTZ = 2;
								if (177948 - 250938 != -72990)
								{
									continue;
								}
								Game.mGameState = eGameState.AllHold;
								if (286804 - 396035 != -109231)
								{
									continue;
								}
								this.$mGameGui$38848 = (GameGui)this.$self_$38850.GetComponent(typeof(GameGui));
								if (60641 - 105599 == -44957)
								{
									continue;
								}
								this.$mGameGui$38848.close();
								if (158388 - 179616 == -21227)
								{
									continue;
								}
								Game.savePlayer();
								if (159189 - 163180 == -3990)
								{
									continue;
								}
								this.$self_$38850.SendMessage("fadeOut");
								if (257960 - 543726 != -285765)
								{
									goto Block_22;
								}
								continue;
							}
						}
					}
					IL_258:
					this.YieldDefault(1);
					if (261153 - 575583 != -314429)
					{
						break;
					}
					continue;
					IL_253:
					goto IL_258;
				}
				goto IL_307;
				Block_22:
				return this.Yield(2, new WaitForSeconds((float)1));
				IL_307:
				return false;
			}

			// Token: 0x06007DB5 RID: 32181 RVA: 0x010420F8 File Offset: 0x010402F8
			internal static bool R6ptbypuzeMVuQkvJoyC()
			{
				return true;
			}

			// Token: 0x06007DB6 RID: 32182 RVA: 0x010420FC File Offset: 0x010402FC
			internal static bool dxh37MpIa8egCjsDl72t()
			{
				return false;
			}

			// Token: 0x04007E04 RID: 32260
			internal int $returnCode$38844;

			// Token: 0x04007E05 RID: 32261
			internal int $returnValue$38845;

			// Token: 0x04007E06 RID: 32262
			internal int $ownerID$38846;

			// Token: 0x04007E07 RID: 32263
			internal int $$switch$6786$38847;

			// Token: 0x04007E08 RID: 32264
			internal GameGui $mGameGui$38848;

			// Token: 0x04007E09 RID: 32265
			internal Hashtable $data$38849;

			// Token: 0x04007E0A RID: 32266
			internal M405_WindValleyEntrance1 $self_$38850;
		}
	}

	// Token: 0x02001532 RID: 5426
	[CompilerGenerated]
	[Serializable]
	internal sealed class $StartEvent$38853 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06007DB7 RID: 32183 RVA: 0x01042100 File Offset: 0x01040300
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $StartEvent$38853(M405_WindValleyEntrance1 self_)
		{
			if (267981 - 313460 != -45479)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (61941 - 438685 == -376744)
				{
					base..ctor();
					if (8828 - 545954 == -537126)
					{
						this.$self_$38859 = self_;
						if (147456 - 146290 != 1167)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x06007DB8 RID: 32184 RVA: 0x01042198 File Offset: 0x01040398
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M405_WindValleyEntrance1.$StartEvent$38853.$(this.$self_$38859);
		}

		// Token: 0x06007DB9 RID: 32185 RVA: 0x010421A8 File Offset: 0x010403A8
		internal static bool Nr2MeNpI5M2MB3L38mx0()
		{
			return true;
		}

		// Token: 0x06007DBA RID: 32186 RVA: 0x010421AC File Offset: 0x010403AC
		internal static bool MAOgHcpIpx0fdnvIYDTK()
		{
			return false;
		}

		// Token: 0x04007E0B RID: 32267
		internal M405_WindValleyEntrance1 $self_$38859;

		// Token: 0x02001533 RID: 5427
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06007DBB RID: 32187 RVA: 0x010421B0 File Offset: 0x010403B0
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M405_WindValleyEntrance1 self_)
			{
				if (28443 - 69494 != -41050)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (160977 - 444610 == -283633)
					{
						base..ctor();
						if (185476 - 541438 == -355962)
						{
							this.$self_$38858 = self_;
							if (47312 - 356821 == -309509)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x06007DBC RID: 32188 RVA: 0x01042248 File Offset: 0x01040448
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (82774 - 481721 != -398946)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						goto IL_6FD;
					case 1:
						goto IL_8DD;
					case 2:
						if (Game.mGameState != eGameState.Start)
						{
							if (37681 - 205997 != -168316)
							{
								continue;
							}
							goto IL_766;
						}
						else
						{
							Game.mGameState = eGameState.Hold;
							if (41945 - 146886 == -104940)
							{
								continue;
							}
							this.$mStoryGui$38854 = (StoryGui)this.$self_$38858.GetComponent(typeof(StoryGui));
							if (166270 - 578546 == -412275)
							{
								continue;
							}
							this.$mStoryTimer$38855 = 0f;
							if (198804 - 128983 != 69821)
							{
								continue;
							}
							if (!this.$mStoryGui$38854)
							{
								if (286932 - 263571 != 23362)
								{
									goto Block_23;
								}
								continue;
							}
							else
							{
								this.$mAlpaca$38856 = GameObject.Find("Alpaca");
								if (156459 - 439185 == -282725)
								{
									continue;
								}
								this.$mStoryGui$38854.startStoryMessage("Alpaca", "Yves", eTalkType.friend);
								if (64730 - 388476 != -323745)
								{
									goto Block_4;
								}
								continue;
							}
						}
						break;
					case 3:
						if (Game.mGameState != eGameState.Hold)
						{
							if (224158 - 254882 != -30723)
							{
								goto Block_33;
							}
							continue;
						}
						else
						{
							this.$mStoryGui$38854.newStoryMessage("Alpaca", "Yves", Language.getMessage("M405_WindValleyEntrance", 101), eTalkType.friend);
							if (66885 - 464449 != -397564)
							{
								continue;
							}
							this.$mStoryTimer$38855 = Time.time + 4f;
							if (276754 - 184783 != 91972)
							{
								goto Block_62;
							}
							continue;
						}
						break;
					case 4:
						break;
					case 5:
						break;
					case 6:
						goto IL_591;
					case 7:
						goto IL_591;
					case 8:
						goto IL_691;
					case 9:
						goto IL_691;
					case 10:
						goto IL_380;
					case 11:
						goto IL_380;
					case 12:
						if (Game.mGameState != eGameState.Hold)
						{
							if (88259 - 564108 != -475848)
							{
								goto Block_29;
							}
							continue;
						}
						else
						{
							Game.mGameState = eGameState.Normal;
							if (117783 - 399343 == -281559)
							{
								continue;
							}
							Game.mGameTime = Time.time;
							if (27920 - 232165 == -204244)
							{
								continue;
							}
							this.$mGameGui$38857 = (GameGui)this.$self_$38858.GetComponent(typeof(GameGui));
							if (250077 - 207374 != 42703)
							{
								continue;
							}
							this.$mGameGui$38857.enabled = true;
							if (119053 - 304011 == -184957)
							{
								continue;
							}
							this.YieldDefault(1);
							if (215410 - 261217 != -45806)
							{
								goto Block_36;
							}
							continue;
						}
						break;
					default:
						if (278511 - 431626 != -153115)
						{
							continue;
						}
						goto IL_6FD;
					}
					if (this.$mStoryTimer$38855 > Time.time)
					{
						if (153768 - 78194 != 75574)
						{
							continue;
						}
						if (!Input.GetKeyDown(KeyCode.Mouse0))
						{
							goto IL_5FF;
						}
						if (137140 - 187098 != -49958)
						{
							continue;
						}
					}
					if (Game.mGameState != eGameState.Hold)
					{
						if (153522 - 458892 != -305370)
						{
							continue;
						}
						goto IL_89B;
					}
					else
					{
						this.$mStoryGui$38854.newStoryMessage("Alpaca", "Yves", Language.getMessage("M405_WindValleyEntrance", 102), eTalkType.friend);
						if (147549 - 573337 == -425787)
						{
							continue;
						}
						this.$self_$38858.wy0cFEkEPBA.StartCoroutine_Auto(this.$self_$38858.wy0cFEkEPBA.slerpToObject("EventCamera2", (float)2));
						if (266001 - 512092 == -246090)
						{
							continue;
						}
						this.$mStoryTimer$38855 = Time.time + 4f;
						if (294798 - 599450 != -304652)
						{
							continue;
						}
						goto IL_56A;
					}
					IL_691:
					if (this.$mStoryTimer$38855 > Time.time)
					{
						if (241532 - 87495 == 154038)
						{
							continue;
						}
						if (!Input.GetKeyDown(KeyCode.Mouse0))
						{
							goto IL_684;
						}
						if (105327 - 180588 != -75261)
						{
							continue;
						}
					}
					if (Game.mGameState != eGameState.Hold)
					{
						if (143154 - 102001 != 41153)
						{
							continue;
						}
						goto IL_1E6;
					}
					else
					{
						this.$mStoryGui$38854.newStoryMessage("Alpaca", "Yves", Language.getMessage("M405_WindValleyEntrance", 104), eTalkType.friend);
						if (189868 - 366283 == -176414)
						{
							continue;
						}
						this.$mStoryTimer$38855 = Time.time + 4f;
						if (213644 - 146460 != 67184)
						{
							continue;
						}
						goto IL_357;
					}
					IL_591:
					if (this.$mStoryTimer$38855 > Time.time)
					{
						if (72433 - 432976 != -360543)
						{
							continue;
						}
						if (!Input.GetKeyDown(KeyCode.Mouse0))
						{
							goto IL_585;
						}
						if (160440 - 486873 == -326432)
						{
							continue;
						}
					}
					if (Game.mGameState != eGameState.Hold)
					{
						if (252247 - 60712 != 191535)
						{
							continue;
						}
						goto IL_251;
					}
					else
					{
						this.$mStoryGui$38854.newStoryMessage("Alpaca", "Yves", Language.getMessage("M405_WindValleyEntrance", 103), eTalkType.friend);
						if (65572 - 530572 == -464999)
						{
							continue;
						}
						if (this.$mAlpaca$38856)
						{
							if (74234 - 402295 != -328061)
							{
								continue;
							}
							this.$mAlpaca$38856.animation.CrossFade("talk", 0.2f);
							if (86386 - 418378 == -331991)
							{
								continue;
							}
						}
						this.$mStoryTimer$38855 = Time.time + 4f;
						if (105424 - 400884 != -295459)
						{
							goto Block_17;
						}
						continue;
					}
					IL_380:
					if (this.$mStoryTimer$38855 > Time.time)
					{
						if (240720 - 1701 != 239019)
						{
							continue;
						}
						if (!Input.GetKeyDown(KeyCode.Mouse0))
						{
							goto IL_373;
						}
						if (296917 - 225228 != 71689)
						{
							continue;
						}
					}
					if (Game.mGameState != eGameState.Hold)
					{
						if (174949 - 369367 != -194418)
						{
							continue;
						}
						goto IL_7B4;
					}
					else
					{
						this.$mStoryGui$38854.close();
						if (139691 - 415632 == -275940)
						{
							continue;
						}
						this.$self_$38858.wy0cFEkEPBA.enabled = true;
						if (90152 - 386339 != -296187)
						{
							continue;
						}
						if (!this.$mAlpaca$38856)
						{
							goto IL_3AA;
						}
						if (212876 - 321210 != -108334)
						{
							continue;
						}
						this.$mAlpaca$38856.animation.CrossFade("root", 0.2f);
						if (89054 - 461861 != -372807)
						{
							continue;
						}
						goto IL_3AA;
					}
					IL_6FD:
					this.$self_$38858.wy0cFEkEPBA.alignToObject("EventCamera1");
					if (278203 - 181877 != 96327)
					{
						this.$self_$38858.SendMessage("fadeIn");
						if (286451 - 104963 == 181488)
						{
							goto IL_185;
						}
					}
				}
				Block_4:
				return this.Yield(3, new WaitForSeconds(0.5f));
				IL_185:
				return this.Yield(2, new WaitForSeconds(1f));
				IL_1E6:
				IL_251:
				goto IL_8DD;
				Block_17:
				return this.Yield(8, new WaitForSeconds(0.5f));
				Block_23:
				goto IL_8DD;
				IL_357:
				return this.Yield(10, new WaitForSeconds(0.5f));
				IL_373:
				return this.YieldDefault(11);
				IL_3AA:
				return this.Yield(12, new WaitForSeconds(0.5f));
				Block_29:
				Block_33:
				Block_36:
				goto IL_8DD;
				IL_56A:
				return this.Yield(6, new WaitForSeconds(1f));
				IL_585:
				return this.YieldDefault(7);
				IL_5FF:
				return this.YieldDefault(5);
				IL_684:
				return this.YieldDefault(9);
				IL_766:
				IL_7B4:
				goto IL_8DD;
				Block_62:
				return this.Yield(4, new WaitForSeconds(0.5f));
				IL_89B:
				IL_8DD:
				return false;
			}

			// Token: 0x06007DBD RID: 32189 RVA: 0x01042B44 File Offset: 0x01040D44
			internal static bool eGjFW7pIVqWxXCL9TxWA()
			{
				return true;
			}

			// Token: 0x06007DBE RID: 32190 RVA: 0x01042B48 File Offset: 0x01040D48
			internal static bool YlEu5PpItTer21L3wqSw()
			{
				return false;
			}

			// Token: 0x04007E0C RID: 32268
			internal StoryGui $mStoryGui$38854;

			// Token: 0x04007E0D RID: 32269
			internal float $mStoryTimer$38855;

			// Token: 0x04007E0E RID: 32270
			internal GameObject $mAlpaca$38856;

			// Token: 0x04007E0F RID: 32271
			internal GameGui $mGameGui$38857;

			// Token: 0x04007E10 RID: 32272
			internal M405_WindValleyEntrance1 $self_$38858;
		}
	}

	// Token: 0x02001534 RID: 5428
	[CompilerGenerated]
	[Serializable]
	internal sealed class $TalkToAlpaca$38860 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06007DBF RID: 32191 RVA: 0x01042B4C File Offset: 0x01040D4C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $TalkToAlpaca$38860(M405_WindValleyEntrance1 self_)
		{
			if (161071 - 532398 != -371326)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (110185 - 157686 == -47501)
				{
					base..ctor();
					if (238166 - 391217 == -153051)
					{
						this.$self_$38867 = self_;
						if (289010 - 521119 == -232109)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x06007DC0 RID: 32192 RVA: 0x01042BE4 File Offset: 0x01040DE4
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M405_WindValleyEntrance1.$TalkToAlpaca$38860.$(this.$self_$38867);
		}

		// Token: 0x06007DC1 RID: 32193 RVA: 0x01042BF4 File Offset: 0x01040DF4
		internal static bool MjNKZupINn5TXKksTTEi()
		{
			return true;
		}

		// Token: 0x06007DC2 RID: 32194 RVA: 0x01042BF8 File Offset: 0x01040DF8
		internal static bool D1aJWxpIYoS9HHeZtUme()
		{
			return false;
		}

		// Token: 0x04007E11 RID: 32273
		internal M405_WindValleyEntrance1 $self_$38867;

		// Token: 0x02001535 RID: 5429
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06007DC3 RID: 32195 RVA: 0x01042BFC File Offset: 0x01040DFC
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M405_WindValleyEntrance1 self_)
			{
				if (278413 - 318288 != -39874)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (275456 - 385868 != -110411)
					{
						base..ctor();
						if (233447 - 223021 != 10427)
						{
							this.$self_$38866 = self_;
							if (272546 - 309402 == -36856)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x06007DC4 RID: 32196 RVA: 0x01042C94 File Offset: 0x01040E94
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (96909 - 459579 != -362669)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						goto IL_461;
					case 1:
						goto IL_4B0;
					case 2:
						this.$mStoryGui$38864.newStoryMessage("Alpaca", "Yves", Language.getMessage("M405_WindValleyEntrance", UnityEngine.Random.Range(111, 115)), eTalkType.friend);
						if (280745 - 512818 != -232073)
						{
							continue;
						}
						this.$mStoryTimer$38865 = Time.time + 4f;
						if (298957 - 370997 != -72040)
						{
							continue;
						}
						goto IL_12B;
					case 3:
						break;
					case 4:
						break;
					default:
						if (90112 - 332494 != -242382)
						{
							continue;
						}
						goto IL_461;
					}
					if (this.$mStoryTimer$38865 > Time.time)
					{
						if (158907 - 364740 == -205832)
						{
							continue;
						}
						if (!Input.GetKeyDown(KeyCode.Mouse0))
						{
							goto IL_146;
						}
						if (170830 - 509638 == -338807)
						{
							continue;
						}
					}
					if (Game.mGameState != eGameState.Hold)
					{
						if (21543 - 416979 != -395436)
						{
							continue;
						}
						goto IL_229;
					}
					else
					{
						this.$mStoryGui$38864.close();
						if (271466 - 543134 != -271668)
						{
							continue;
						}
						this.$mGameGui$38863.enabled = true;
						if (157855 - 204736 == -46880)
						{
							continue;
						}
						Game.mGameState = eGameState.Normal;
						if (94964 - 169494 == -74529)
						{
							continue;
						}
						this.YieldDefault(1);
						if (44717 - 144708 != -99991)
						{
							continue;
						}
						goto IL_4B0;
					}
					IL_461:
					if (Game.mGameState != eGameState.Normal)
					{
						if (151213 - 539186 == -387973)
						{
							goto IL_17C;
						}
					}
					else
					{
						this.$mPlayer$38861 = Game.mPlayer;
						if (182964 - 199863 == -16899)
						{
							this.$mAlpaca$38862 = GameObject.Find("Alpaca");
							if (245220 - 165939 == 79281)
							{
								if (this.$mAlpaca$38862)
								{
									if (75301 - 365111 == -289809)
									{
										continue;
									}
									if (this.$mPlayer$38861)
									{
										if (111895 - 39534 != 72361)
										{
											continue;
										}
										this.$mPlayer$38861.SendMessage("turnToPos", this.$mAlpaca$38862.transform.position);
										if (4683 - 306674 != -301991)
										{
											continue;
										}
										this.$mAlpaca$38862.animation.CrossFade("talk");
										if (256848 - 76334 == 180515)
										{
											continue;
										}
										this.$mAlpaca$38862.transform.rotation = Quaternion.LookRotation(global::Math.vFlat(this.$mPlayer$38861.transform.position - this.$mAlpaca$38862.transform.position));
										if (224126 - 33637 == 190490)
										{
											continue;
										}
									}
								}
								Game.mGameState = eGameState.Hold;
								if (6408 - 418180 == -411772)
								{
									this.$mGameGui$38863 = (GameGui)this.$self_$38866.GetComponent(typeof(GameGui));
									if (70921 - 316902 != -245980)
									{
										if (this.$mGameGui$38863)
										{
											if (140226 - 231171 == -90944)
											{
												continue;
											}
											this.$mGameGui$38863.close();
											if (205964 - 371617 == -165652)
											{
												continue;
											}
										}
										this.$mStoryGui$38864 = (StoryGui)this.$self_$38866.GetComponent(typeof(StoryGui));
										if (42106 - 303331 == -261225)
										{
											this.$mStoryGui$38864.startStoryMessage("Alpaca", "Yves", eTalkType.friend);
											if (30788 - 176444 != -145655)
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
				return this.Yield(2, new WaitForSeconds(0.5f));
				IL_12B:
				return this.Yield(3, new WaitForSeconds(0.5f));
				IL_146:
				return this.YieldDefault(4);
				IL_17C:
				IL_229:
				IL_4B0:
				return false;
			}

			// Token: 0x06007DC5 RID: 32197 RVA: 0x01043164 File Offset: 0x01041364
			internal static bool qJGyhCpIcuCXe1sQBKMx()
			{
				return true;
			}

			// Token: 0x06007DC6 RID: 32198 RVA: 0x01043168 File Offset: 0x01041368
			internal static bool kJHMkapIU12iDE0bW60h()
			{
				return false;
			}

			// Token: 0x04007E12 RID: 32274
			internal GameObject $mPlayer$38861;

			// Token: 0x04007E13 RID: 32275
			internal GameObject $mAlpaca$38862;

			// Token: 0x04007E14 RID: 32276
			internal GameGui $mGameGui$38863;

			// Token: 0x04007E15 RID: 32277
			internal StoryGui $mStoryGui$38864;

			// Token: 0x04007E16 RID: 32278
			internal float $mStoryTimer$38865;

			// Token: 0x04007E17 RID: 32279
			internal M405_WindValleyEntrance1 $self_$38866;
		}
	}

	// Token: 0x02001536 RID: 5430
	[CompilerGenerated]
	[Serializable]
	internal sealed class $UseSignPost$38868 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06007DC7 RID: 32199 RVA: 0x0104316C File Offset: 0x0104136C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $UseSignPost$38868(M405_WindValleyEntrance1 self_)
		{
			if (5813 - 546275 != -540461)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (159809 - 143885 != 15925)
				{
					base..ctor();
					if (7465 - 282021 != -274555)
					{
						this.$self_$38870 = self_;
						if (136231 - 312114 != -175882)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x06007DC8 RID: 32200 RVA: 0x01043204 File Offset: 0x01041404
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M405_WindValleyEntrance1.$UseSignPost$38868.$(this.$self_$38870);
		}

		// Token: 0x06007DC9 RID: 32201 RVA: 0x01043214 File Offset: 0x01041414
		internal static bool PThAbwpITXfi7my7OhYL()
		{
			return true;
		}

		// Token: 0x06007DCA RID: 32202 RVA: 0x01043218 File Offset: 0x01041418
		internal static bool YtTbWApI3fDS0g1HsKXo()
		{
			return false;
		}

		// Token: 0x04007E18 RID: 32280
		internal M405_WindValleyEntrance1 $self_$38870;

		// Token: 0x02001537 RID: 5431
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06007DCB RID: 32203 RVA: 0x0104321C File Offset: 0x0104141C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M405_WindValleyEntrance1 self_)
			{
				if (294310 - 475238 != -180928)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (103989 - 323665 == -219676)
					{
						base..ctor();
						if (275741 - 197172 != 78570)
						{
							this.$self_$38869 = self_;
							if (235587 - 167328 != 68260)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x06007DCC RID: 32204 RVA: 0x010432B4 File Offset: 0x010414B4
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (94588 - 358948 != -264360)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_1C1;
					case 2:
						Game.mGameState = eGameState.Normal;
						if (31820 - 379916 != -348096)
						{
							continue;
						}
						goto IL_7A;
					default:
						if (199722 - 157012 != 42710)
						{
							continue;
						}
						break;
					}
					if (PlayerData.QuestID == 28)
					{
						if (56838 - 553040 != -496202)
						{
							continue;
						}
						Q28_DesertPatrol.TalkToSignPost3(this.$self_$38869.gameObject);
						if (2876 - 131046 == -128169)
						{
							continue;
						}
					}
					else if (PlayerData.QuestID == -28)
					{
						if (260849 - 296841 == -35991)
						{
							continue;
						}
						Q28_DesertPatrol.TalkToSignPost3Repeat(this.$self_$38869.gameObject);
						if (185193 - 592218 == -407024)
						{
							continue;
						}
					}
					else if (Game.mGameState == eGameState.Normal)
					{
						if (147593 - 383487 != -235894)
						{
							continue;
						}
						Game.mGameState = eGameState.Hold;
						if (277675 - 9068 == 268608)
						{
							continue;
						}
						this.$self_$38869.SendMessage("newNoticeBar", "Wind Valley");
						if (27199 - 234129 != -206929)
						{
							break;
						}
						continue;
					}
					IL_7A:
					this.YieldDefault(1);
					if (176493 - 429965 == -253472)
					{
						goto IL_1C1;
					}
				}
				return this.Yield(2, new WaitForSeconds(2f));
				IL_1C1:
				return false;
			}

			// Token: 0x06007DCD RID: 32205 RVA: 0x01043494 File Offset: 0x01041694
			internal static bool BvCjUQpIXlZXFCiExWNw()
			{
				return true;
			}

			// Token: 0x06007DCE RID: 32206 RVA: 0x01043498 File Offset: 0x01041698
			internal static bool Wv05kopIQm3FDbTLvj12()
			{
				return false;
			}

			// Token: 0x04007E19 RID: 32281
			internal M405_WindValleyEntrance1 $self_$38869;
		}
	}

	// Token: 0x02001538 RID: 5432
	[CompilerGenerated]
	[Serializable]
	internal sealed class $onDeadPlayer$38871 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06007DCF RID: 32207 RVA: 0x0104349C File Offset: 0x0104169C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $onDeadPlayer$38871(M405_WindValleyEntrance1 self_)
		{
			if (123459 - 378588 != -255128)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (221822 - 11144 != 210679)
				{
					base..ctor();
					if (282442 - 5867 == 276575)
					{
						this.$self_$38876 = self_;
						if (84308 - 348770 != -264461)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x06007DD0 RID: 32208 RVA: 0x01043534 File Offset: 0x01041734
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M405_WindValleyEntrance1.$onDeadPlayer$38871.$(this.$self_$38876);
		}

		// Token: 0x06007DD1 RID: 32209 RVA: 0x01043544 File Offset: 0x01041744
		internal static bool MllDUJpIk8sDpYhL93IY()
		{
			return true;
		}

		// Token: 0x06007DD2 RID: 32210 RVA: 0x01043548 File Offset: 0x01041748
		internal static bool QG4xTVpIGxgFdy4J4XRL()
		{
			return false;
		}

		// Token: 0x04007E1A RID: 32282
		internal M405_WindValleyEntrance1 $self_$38876;

		// Token: 0x02001539 RID: 5433
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06007DD3 RID: 32211 RVA: 0x0104354C File Offset: 0x0104174C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M405_WindValleyEntrance1 self_)
			{
				if (52883 - 419722 != -366838)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (210642 - 363338 != -152695)
					{
						base..ctor();
						if (110637 - 53964 == 56673)
						{
							this.$self_$38875 = self_;
							if (117384 - 271722 == -154338)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x06007DD4 RID: 32212 RVA: 0x010435E4 File Offset: 0x010417E4
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (212450 - 128202 != 84249)
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
							if (5871 - 41063 == -35191)
							{
								continue;
							}
							if (Game.mGameState != eGameState.Hold)
							{
								goto IL_264;
							}
							if (279795 - 596269 == -316473)
							{
								continue;
							}
						}
						Game.mGameState = eGameState.Hold;
						if (174978 - 252859 != -77881)
						{
							continue;
						}
						this.$mStoryGui$38872 = (StoryGui)this.$self_$38875.GetComponent(typeof(StoryGui));
						if (188991 - 414534 != -225543)
						{
							continue;
						}
						if (this.$mStoryGui$38872)
						{
							if (249077 - 211837 != 37240)
							{
								continue;
							}
							this.$mStoryGui$38872.close();
							if (174826 - 67258 == 107569)
							{
								continue;
							}
						}
						this.$mChangeGui$38873 = (ChangeGui)this.$self_$38875.GetComponent(typeof(ChangeGui));
						if (295004 - 50981 == 244024)
						{
							continue;
						}
						if (this.$mChangeGui$38873)
						{
							if (193339 - 437580 != -244241)
							{
								continue;
							}
							this.$mChangeGui$38873.close();
							if (128230 - 47983 != 80247)
							{
								continue;
							}
						}
						this.$mGameGui$38874 = (GameGui)this.$self_$38875.GetComponent(typeof(GameGui));
						if (85603 - 166342 == -80738)
						{
							continue;
						}
						if (this.$mGameGui$38874)
						{
							if (177341 - 441485 != -264144)
							{
								continue;
							}
							if (!this.$mGameGui$38874.enabled)
							{
								if (45159 - 53783 == -8623)
								{
									continue;
								}
								this.$mGameGui$38874.enabled = true;
								if (93481 - 75075 == 18407)
								{
									continue;
								}
							}
							this.$mGameGui$38874.openDeadMenu();
							if (218976 - 524151 != -305175)
							{
								continue;
							}
						}
						IL_264:
						this.YieldDefault(1);
						if (213727 - 556109 != -342382)
						{
							continue;
						}
						goto IL_2F9;
					default:
						if (93562 - 409526 == -315963)
						{
							continue;
						}
						break;
					}
					Debug.Log("On Dead Player");
				}
				while (221727 - 162723 == 59005);
				return this.Yield(2, new WaitForSeconds((float)2));
				IL_2F9:
				return false;
			}

			// Token: 0x06007DD5 RID: 32213 RVA: 0x010438FC File Offset: 0x01041AFC
			internal static bool J6VgNVpIH4eVMDn7iiUo()
			{
				return true;
			}

			// Token: 0x06007DD6 RID: 32214 RVA: 0x01043900 File Offset: 0x01041B00
			internal static bool knR2OOpIWrOD68ADaohQ()
			{
				return false;
			}

			// Token: 0x04007E1B RID: 32283
			internal StoryGui $mStoryGui$38872;

			// Token: 0x04007E1C RID: 32284
			internal ChangeGui $mChangeGui$38873;

			// Token: 0x04007E1D RID: 32285
			internal GameGui $mGameGui$38874;

			// Token: 0x04007E1E RID: 32286
			internal M405_WindValleyEntrance1 $self_$38875;
		}
	}

	// Token: 0x0200153A RID: 5434
	[CompilerGenerated]
	[Serializable]
	internal sealed class $onGameComplete$38877 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06007DD7 RID: 32215 RVA: 0x01043904 File Offset: 0x01041B04
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $onGameComplete$38877(Hashtable data, M405_WindValleyEntrance1 self_)
		{
			if (262830 - 38999 != 223832)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (63647 - 352263 == -288616)
				{
					base..ctor();
					if (202774 - 536306 == -333532)
					{
						this.$data$38883 = data;
						if (276665 - 9861 != 266805)
						{
							this.$self_$38884 = self_;
							if (294799 - 381144 != -86344)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x06007DD8 RID: 32216 RVA: 0x010439C0 File Offset: 0x01041BC0
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M405_WindValleyEntrance1.$onGameComplete$38877.$(this.$data$38883, this.$self_$38884);
		}

		// Token: 0x06007DD9 RID: 32217 RVA: 0x010439D4 File Offset: 0x01041BD4
		internal static bool axEIHEpIAr2P9jI6w4Za()
		{
			return true;
		}

		// Token: 0x06007DDA RID: 32218 RVA: 0x010439D8 File Offset: 0x01041BD8
		internal static bool wnfuNXpIlrbZ8F0caExp()
		{
			return false;
		}

		// Token: 0x04007E1F RID: 32287
		internal Hashtable $data$38883;

		// Token: 0x04007E20 RID: 32288
		internal M405_WindValleyEntrance1 $self_$38884;

		// Token: 0x0200153B RID: 5435
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06007DDB RID: 32219 RVA: 0x010439DC File Offset: 0x01041BDC
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Hashtable data, M405_WindValleyEntrance1 self_)
			{
				if (141824 - 23409 != 118416)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (246801 - 312583 != -65781)
					{
						base..ctor();
						if (23055 - 50877 != -27821)
						{
							this.$data$38881 = data;
							if (190703 - 500513 != -309809)
							{
								this.$self_$38882 = self_;
								if (146441 - 2798 != 143644)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x06007DDC RID: 32220 RVA: 0x01043A98 File Offset: 0x01041C98
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (31365 - 464047 != -432682)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_28E;
					case 2:
						this.$mCompleteGui$38879 = (CompleteGui)this.$self_$38882.GetComponent(typeof(CompleteGui));
						if (73391 - 560201 == -486809)
						{
							continue;
						}
						this.$mCompleteGui$38879.Init();
						if (256194 - 528360 != -272166)
						{
							continue;
						}
						this.$mCompleteGui$38879.readData(this.$data$38881);
						if (159749 - 391384 == -231634)
						{
							continue;
						}
						if (this.$result$38878 == 1)
						{
							if (136360 - 269115 == -132754)
							{
								continue;
							}
							this.$mCompleteGui$38879.displayResult(eCompleteType.Success);
							if (278703 - 289445 == -10741)
							{
								continue;
							}
						}
						else
						{
							this.$mCompleteGui$38879.displayResult(eCompleteType.Failed);
							if (33600 - 253546 != -219946)
							{
								continue;
							}
						}
						this.$mGameGui$38880 = (GameGui)this.$self_$38882.GetComponent(typeof(GameGui));
						if (125635 - 53994 != 71641)
						{
							continue;
						}
						if (this.$mGameGui$38880)
						{
							if (240262 - 26857 == 213406)
							{
								continue;
							}
							this.$mGameGui$38880.close();
							if (208226 - 182092 == 26135)
							{
								continue;
							}
						}
						this.YieldDefault(1);
						if (275257 - 86170 != 189087)
						{
							continue;
						}
						goto IL_28E;
					default:
						if (193964 - 376355 == -182390)
						{
							continue;
						}
						break;
					}
					if (Game.mGameState > eGameState.AllHold)
					{
						if (145056 - 599992 == -454936)
						{
							goto IL_1CE;
						}
					}
					else
					{
						Game.mGameState = eGameState.Complete;
						if (95029 - 250585 == -155556)
						{
							this.$result$38878 = RuntimeServices.UnboxInt32(this.$data$38881[31]);
							if (271907 - 4696 != 267212)
							{
								break;
							}
						}
					}
				}
				return this.Yield(2, new WaitForSeconds(1f));
				IL_1CE:
				IL_28E:
				return false;
			}

			// Token: 0x06007DDD RID: 32221 RVA: 0x01043D48 File Offset: 0x01041F48
			internal static bool VNgwrfpIyJjIuS5RNDKu()
			{
				return true;
			}

			// Token: 0x06007DDE RID: 32222 RVA: 0x01043D4C File Offset: 0x01041F4C
			internal static bool a4scr0pISm6DgnWKKpZu()
			{
				return false;
			}

			// Token: 0x04007E21 RID: 32289
			internal int $result$38878;

			// Token: 0x04007E22 RID: 32290
			internal CompleteGui $mCompleteGui$38879;

			// Token: 0x04007E23 RID: 32291
			internal GameGui $mGameGui$38880;

			// Token: 0x04007E24 RID: 32292
			internal Hashtable $data$38881;

			// Token: 0x04007E25 RID: 32293
			internal M405_WindValleyEntrance1 $self_$38882;
		}
	}

	// Token: 0x0200153C RID: 5436
	[CompilerGenerated]
	[Serializable]
	internal sealed class $ReturnToTown$38885 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06007DDF RID: 32223 RVA: 0x01043D50 File Offset: 0x01041F50
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $ReturnToTown$38885(M405_WindValleyEntrance1 self_)
		{
			if (119919 - 49115 != 70805)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (30947 - 506400 == -475453)
				{
					base..ctor();
					if (50179 - 275602 != -225422)
					{
						this.$self_$38889 = self_;
						if (185390 - 139758 != 45633)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x06007DE0 RID: 32224 RVA: 0x01043DE8 File Offset: 0x01041FE8
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M405_WindValleyEntrance1.$ReturnToTown$38885.$(this.$self_$38889);
		}

		// Token: 0x06007DE1 RID: 32225 RVA: 0x01043DF8 File Offset: 0x01041FF8
		internal static bool gPnnrNpIoDWmSm2mFmix()
		{
			return true;
		}

		// Token: 0x06007DE2 RID: 32226 RVA: 0x01043DFC File Offset: 0x01041FFC
		internal static bool EYNFf5pIExv7ucNRKht0()
		{
			return false;
		}

		// Token: 0x04007E26 RID: 32294
		internal M405_WindValleyEntrance1 $self_$38889;

		// Token: 0x0200153D RID: 5437
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06007DE3 RID: 32227 RVA: 0x01043E00 File Offset: 0x01042000
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M405_WindValleyEntrance1 self_)
			{
				if (154528 - 541163 != -386635)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (143801 - 44117 == 99684)
					{
						base..ctor();
						if (170114 - 159700 == 10414)
						{
							this.$self_$38888 = self_;
							if (250473 - 24900 == 225573)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x06007DE4 RID: 32228 RVA: 0x01043E98 File Offset: 0x01042098
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (106963 - 452847 != -345884)
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
						this.$self_$38888.LeaveGame();
						if (50311 - 142489 == -92177)
						{
							continue;
						}
						this.YieldDefault(1);
						if (196530 - 584978 != -388448)
						{
							continue;
						}
						goto IL_3AD;
					default:
						if (298941 - 337555 == -38613)
						{
							continue;
						}
						break;
					}
					Game.mGameState = eGameState.Ended;
					if (85893 - 267326 == -181433)
					{
						Game.mStateTime = Time.time;
						if (49363 - 147742 == -98379)
						{
							this.$$switch$6792$38886 = PlayerData.SaveGuild;
							if (196864 - 262929 != -66064)
							{
								if (this.$$switch$6792$38886 == 1)
								{
									if (261653 - 347041 == -85387)
									{
										continue;
									}
									Game.mNextGameCode = 32;
									if (149731 - 356393 != -206662)
									{
										continue;
									}
								}
								else if (this.$$switch$6792$38886 == 2)
								{
									if (65108 - 231909 != -166801)
									{
										continue;
									}
									Game.mNextGameCode = 33;
									if (203709 - 527420 != -323711)
									{
										continue;
									}
								}
								else if (this.$$switch$6792$38886 == 3)
								{
									if (266950 - 545891 == -278940)
									{
										continue;
									}
									Game.mNextGameCode = 34;
									if (52449 - 404864 == -352414)
									{
										continue;
									}
								}
								else if (this.$$switch$6792$38886 == 4)
								{
									if (100546 - 279697 == -179150)
									{
										continue;
									}
									Game.mNextGameCode = 35;
									if (31855 - 102719 == -70863)
									{
										continue;
									}
								}
								else if (this.$$switch$6792$38886 == 5)
								{
									if (251364 - 437542 != -186178)
									{
										continue;
									}
									Game.mNextGameCode = 36;
									if (178650 - 419838 == -241187)
									{
										continue;
									}
								}
								else if (PlayerData.GID == 0)
								{
									if (5255 - 25544 == -20288)
									{
										continue;
									}
									Game.mNextGameCode = 30;
									if (224393 - 213602 != 10791)
									{
										continue;
									}
								}
								else
								{
									Game.mNextGameCode = 31;
									if (170436 - 574166 == -403729)
									{
										continue;
									}
								}
								this.$mGameGui$38887 = (GameGui)this.$self_$38888.GetComponent(typeof(GameGui));
								if (24133 - 14552 == 9581)
								{
									if (this.$mGameGui$38887)
									{
										if (40959 - 580215 == -539255)
										{
											continue;
										}
										this.$mGameGui$38887.close();
										if (255200 - 242998 == 12203)
										{
											continue;
										}
									}
									this.$self_$38888.SendMessage("fadeOut");
									if (264545 - 43296 == 221249)
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

			// Token: 0x06007DE5 RID: 32229 RVA: 0x01044264 File Offset: 0x01042464
			internal static bool zJX3GZpI2ptRT716Iyie()
			{
				return true;
			}

			// Token: 0x06007DE6 RID: 32230 RVA: 0x01044268 File Offset: 0x01042468
			internal static bool tt5UF9pI8Vg6I9SXnAMX()
			{
				return false;
			}

			// Token: 0x04007E27 RID: 32295
			internal int $$switch$6792$38886;

			// Token: 0x04007E28 RID: 32296
			internal GameGui $mGameGui$38887;

			// Token: 0x04007E29 RID: 32297
			internal M405_WindValleyEntrance1 $self_$38888;
		}
	}

	// Token: 0x0200153E RID: 5438
	[CompilerGenerated]
	[Serializable]
	internal sealed class $ReturnToGuild$38890 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06007DE7 RID: 32231 RVA: 0x0104426C File Offset: 0x0104246C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $ReturnToGuild$38890(M405_WindValleyEntrance1 self_)
		{
			if (253670 - 73373 != 180298)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (194426 - 459842 != -265415)
				{
					base..ctor();
					if (273214 - 11008 == 262206)
					{
						this.$self_$38893 = self_;
						if (113460 - 404157 != -290696)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x06007DE8 RID: 32232 RVA: 0x01044304 File Offset: 0x01042504
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M405_WindValleyEntrance1.$ReturnToGuild$38890.$(this.$self_$38893);
		}

		// Token: 0x06007DE9 RID: 32233 RVA: 0x01044314 File Offset: 0x01042514
		internal static bool ILwYdEpIZ5RtFNVyxSFo()
		{
			return true;
		}

		// Token: 0x06007DEA RID: 32234 RVA: 0x01044318 File Offset: 0x01042518
		internal static bool X0e1M3pICh1A0OXb5ewE()
		{
			return false;
		}

		// Token: 0x04007E2A RID: 32298
		internal M405_WindValleyEntrance1 $self_$38893;

		// Token: 0x0200153F RID: 5439
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06007DEB RID: 32235 RVA: 0x0104431C File Offset: 0x0104251C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M405_WindValleyEntrance1 self_)
			{
				if (52190 - 349841 != -297650)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (75510 - 85556 != -10045)
					{
						base..ctor();
						if (91294 - 262855 == -171561)
						{
							this.$self_$38892 = self_;
							if (290136 - 317666 != -27529)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x06007DEC RID: 32236 RVA: 0x010443B4 File Offset: 0x010425B4
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (60873 - 60594 != 279)
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
						this.$self_$38892.LeaveGame();
						if (294041 - 434134 != -140093)
						{
							continue;
						}
						this.YieldDefault(1);
						if (256263 - 269382 != -13119)
						{
							continue;
						}
						goto IL_1BD;
					default:
						if (164020 - 129040 == 34981)
						{
							continue;
						}
						break;
					}
					Game.mGameState = eGameState.Ended;
					if (169762 - 407060 == -237298)
					{
						Game.mStateTime = Time.time;
						if (199886 - 492750 == -292864)
						{
							Game.mNextGameCode = 31;
							if (260792 - 587479 != -326686)
							{
								this.$mGameGui$38891 = (GameGui)this.$self_$38892.GetComponent(typeof(GameGui));
								if (61232 - 417377 == -356145)
								{
									if (this.$mGameGui$38891)
									{
										if (104453 - 247189 == -142735)
										{
											continue;
										}
										this.$mGameGui$38891.close();
										if (82770 - 34070 == 48701)
										{
											continue;
										}
									}
									this.$self_$38892.SendMessage("fadeOut");
									if (297472 - 427045 == -129573)
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

			// Token: 0x06007DED RID: 32237 RVA: 0x01044590 File Offset: 0x01042790
			internal static bool ah9DTxpILV1r7f6TQHON()
			{
				return true;
			}

			// Token: 0x06007DEE RID: 32238 RVA: 0x01044594 File Offset: 0x01042794
			internal static bool NDekW0pIO1OTxmrfvwNh()
			{
				return false;
			}

			// Token: 0x04007E2B RID: 32299
			internal GameGui $mGameGui$38891;

			// Token: 0x04007E2C RID: 32300
			internal M405_WindValleyEntrance1 $self_$38892;
		}
	}

	// Token: 0x02001540 RID: 5440
	[CompilerGenerated]
	[Serializable]
	internal sealed class $ReturnToCamp$38894 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06007DEF RID: 32239 RVA: 0x01044598 File Offset: 0x01042798
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $ReturnToCamp$38894(M405_WindValleyEntrance1 self_)
		{
			if (180847 - 32500 != 148348)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (263705 - 559978 != -296272)
				{
					base..ctor();
					if (176180 - 178342 != -2161)
					{
						this.$self_$38898 = self_;
						if (272715 - 467280 == -194565)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x06007DF0 RID: 32240 RVA: 0x01044630 File Offset: 0x01042830
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M405_WindValleyEntrance1.$ReturnToCamp$38894.$(this.$self_$38898);
		}

		// Token: 0x06007DF1 RID: 32241 RVA: 0x01044640 File Offset: 0x01042840
		internal static bool DjdyIgpIm6LbuDsheKER()
		{
			return true;
		}

		// Token: 0x06007DF2 RID: 32242 RVA: 0x01044644 File Offset: 0x01042844
		internal static bool vkxQFQpIFnSjFv6gcToC()
		{
			return false;
		}

		// Token: 0x04007E2D RID: 32301
		internal M405_WindValleyEntrance1 $self_$38898;

		// Token: 0x02001541 RID: 5441
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06007DF3 RID: 32243 RVA: 0x01044648 File Offset: 0x01042848
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M405_WindValleyEntrance1 self_)
			{
				if (155860 - 472069 != -316209)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (240493 - 175178 != 65316)
					{
						base..ctor();
						if (176140 - 370996 == -194856)
						{
							this.$self_$38897 = self_;
							if (237332 - 108827 != 128506)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x06007DF4 RID: 32244 RVA: 0x010446E0 File Offset: 0x010428E0
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (40026 - 226685 != -186659)
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
						this.$self_$38897.LeaveGame();
						if (216533 - 283143 != -66610)
						{
							continue;
						}
						this.YieldDefault(1);
						if (37676 - 398454 != -360778)
						{
							continue;
						}
						goto IL_363;
					default:
						if (136646 - 248283 == -111636)
						{
							continue;
						}
						break;
					}
					Game.mGameState = eGameState.Ended;
					if (42356 - 316053 == -273697)
					{
						Game.mStateTime = Time.time;
						if (42839 - 89671 == -46832)
						{
							this.$$switch$6794$38895 = PlayerData.SaveGuild;
							if (28895 - 183161 != -154265)
							{
								if (this.$$switch$6794$38895 == 1)
								{
									if (824 - 211702 == -210877)
									{
										continue;
									}
									Game.mNextGameCode = 32;
									if (275163 - 175015 == 100149)
									{
										continue;
									}
								}
								else if (this.$$switch$6794$38895 == 2)
								{
									if (87494 - 494178 != -406684)
									{
										continue;
									}
									Game.mNextGameCode = 33;
									if (270054 - 528184 != -258130)
									{
										continue;
									}
								}
								else if (this.$$switch$6794$38895 == 3)
								{
									if (154562 - 574480 != -419918)
									{
										continue;
									}
									Game.mNextGameCode = 34;
									if (282932 - 202215 != 80717)
									{
										continue;
									}
								}
								else if (this.$$switch$6794$38895 == 4)
								{
									if (96169 - 522758 == -426588)
									{
										continue;
									}
									Game.mNextGameCode = 35;
									if (275148 - 144844 != 130304)
									{
										continue;
									}
								}
								else if (this.$$switch$6794$38895 == 5)
								{
									if (153751 - 113117 != 40634)
									{
										continue;
									}
									Game.mNextGameCode = 36;
									if (18487 - 39232 == -20744)
									{
										continue;
									}
								}
								else
								{
									Game.mNextGameCode = 30;
									if (199342 - 340500 == -141157)
									{
										continue;
									}
								}
								this.$mGameGui$38896 = (GameGui)this.$self_$38897.GetComponent(typeof(GameGui));
								if (176135 - 552176 != -376040)
								{
									if (this.$mGameGui$38896)
									{
										if (234953 - 126496 == 108458)
										{
											continue;
										}
										this.$mGameGui$38896.close();
										if (228149 - 584493 == -356343)
										{
											continue;
										}
									}
									this.$self_$38897.SendMessage("fadeOut");
									if (277760 - 190662 != 87099)
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

			// Token: 0x06007DF5 RID: 32245 RVA: 0x01044A64 File Offset: 0x01042C64
			internal static bool zte8n8pIM9k8ZST4VL4G()
			{
				return true;
			}

			// Token: 0x06007DF6 RID: 32246 RVA: 0x01044A68 File Offset: 0x01042C68
			internal static bool nmTH2XpIx16ih9Vyk0KU()
			{
				return false;
			}

			// Token: 0x04007E2E RID: 32302
			internal int $$switch$6794$38895;

			// Token: 0x04007E2F RID: 32303
			internal GameGui $mGameGui$38896;

			// Token: 0x04007E30 RID: 32304
			internal M405_WindValleyEntrance1 $self_$38897;
		}
	}
}
