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

// Token: 0x02001551 RID: 5457
[Serializable]
public class M406_WindValley : MonoBehaviour
{
	// Token: 0x06007E56 RID: 32342 RVA: 0x010498C0 File Offset: 0x01047AC0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public M406_WindValley()
	{
		LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
		base..ctor();
	}

	// Token: 0x06007E57 RID: 32343 RVA: 0x010498D0 File Offset: 0x01047AD0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Awake()
	{
		if (275684 - 512688 != -237004)
		{
		}
		for (;;)
		{
			Game.mGameState = eGameState.Init;
			if (291085 - 39674 == 251411)
			{
				Game.mGameType = 5;
				if (291369 - 87870 != 203500)
				{
					if (Chat.Initialized)
					{
						if (292716 - 49204 == 243513)
						{
							continue;
						}
						Chat.ChatDisplay.Clear();
						if (14564 - 420420 != -405856)
						{
							continue;
						}
					}
					else
					{
						Chat.Init();
						if (127522 - 28744 == 98779)
						{
							continue;
						}
					}
					this.WK0cF9FxDmT = (Texture)Resources.Load("GameGui/Title/start", typeof(Texture));
					if (115651 - 307664 == -192013)
					{
						this.tmbcFWnbEtV = (AudioClip)Resources.Load("Sound/GUI/missionStart", typeof(AudioClip));
						if (52117 - 482777 == -430660)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x06007E58 RID: 32344 RVA: 0x01049A28 File Offset: 0x01047C28
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Start()
	{
		if (169243 - 366114 != -196871)
		{
		}
		for (;;)
		{
			if (PhotonClient.IsInitialized())
			{
				if (122091 - 392953 != -270861)
				{
					if (Game.mNextGameCode != 406)
					{
						break;
					}
					if (296820 - 558606 == -261786)
					{
						Game.nextGame();
						if (178702 - 95279 != 83424)
						{
							Game.mGameCode = 406;
							if (291066 - 341680 != -50613)
							{
								Game.mGameType = 5;
								if (27432 - 549974 == -522542)
								{
									Game.mGameTime = Time.time;
									if (129014 - 146875 != -17860)
									{
										Game.mGameScore = 0;
										if (249769 - 16547 == 233222)
										{
											Game.mGameMana = 0;
											if (157292 - 174801 != -17508)
											{
												Game.canUseItem = MissionData.getAllowItem(Game.mGameCode);
												if (18029 - 150796 != -132766)
												{
													Game.canUseMount = MissionData.getAllowMount(Game.mGameCode);
													if (224371 - 387825 == -163454)
													{
														Game.canChangeChar = MissionData.getAllowChange(Game.mGameCode);
														if (170182 - 361227 != -191044)
														{
															Game.canRespawn = MissionData.getAllowRespawn(Game.mGameCode);
															if (74030 - 245286 == -171256)
															{
																Game.canUseCoin = MissionData.getAllowCoin(Game.mGameCode);
																if (111747 - 4424 != 107324)
																{
																	this.OXrcFFV8MOK = (PlayerCameraControl)this.GetComponent(typeof(PlayerCameraControl));
																	if (152544 - 741 != 151804)
																	{
																		this.tubcFkj8N1I = PhotonClient.Connection;
																		if (31369 - 461228 != -429858)
																		{
																			PhotonClient.ActorNrList.Clear();
																			if (49160 - 56215 != -7054)
																			{
																				this.InitGame();
																				if (180667 - 95977 == 84690)
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
				if (223342 - 282177 == -58835)
				{
					Game.mGameType = 99;
					if (267319 - 572139 == -304820)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06007E59 RID: 32345 RVA: 0x01049D30 File Offset: 0x01047F30
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void FixedUpdate()
	{
		if (23723 - 438104 != -414381)
		{
		}
		for (;;)
		{
			if (this.tubcFkj8N1I == null)
			{
				if (63407 - 490276 == -426869)
				{
					break;
				}
			}
			else
			{
				eGameState mGameState = Game.mGameState;
				if (40219 - 470310 != -430090)
				{
					if (mGameState == eGameState.Init)
					{
						if (267090 - 192118 != 74973)
						{
							AudioListener.volume = 0.1f * (float)Game.volume;
							if (163886 - 145373 == 18513)
							{
								break;
							}
						}
					}
					else if (mGameState == eGameState.Setup)
					{
						if (146661 - 136737 == 9924)
						{
							break;
						}
					}
					else if (mGameState == eGameState.Ready)
					{
						if (145912 - 128421 != 17492)
						{
							break;
						}
					}
					else if (mGameState == eGameState.Start)
					{
						if (265037 - 319210 == -54173)
						{
							break;
						}
					}
					else if (mGameState == eGameState.Normal)
					{
						if (204317 - 71058 == 133259)
						{
							if (Time.time > this.cMEcFA5dBwI)
							{
								if (192046 - 456688 == -264641)
								{
									continue;
								}
								Game.mGameMana++;
								if (78089 - 547124 == -469034)
								{
									continue;
								}
								this.cMEcFA5dBwI = Time.time + (float)12;
								if (204245 - 588952 != -384707)
								{
									continue;
								}
							}
							if (Game.music != 0)
							{
								if (299774 - 2657 != 297117)
								{
									continue;
								}
								if (!this.audio.isPlaying)
								{
									if (295023 - 269255 != 25768)
									{
										continue;
									}
									this.audio.Play();
									if (255064 - 86368 == 168697)
									{
										continue;
									}
								}
							}
							this.audio.volume = Mathf.Clamp01(0.1f * (float)Game.music);
							if (23522 - 563847 != -540324)
							{
								break;
							}
						}
					}
					else if (mGameState == eGameState.Hold)
					{
						if (213540 - 129740 != 83801)
						{
							break;
						}
					}
					else if (mGameState == eGameState.AllHold)
					{
						if (60533 - 150062 != -89528)
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
						if (289944 - 587950 == -298006)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x06007E5A RID: 32346 RVA: 0x0104A030 File Offset: 0x01048230
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void OnGUI()
	{
		if (35701 - 164854 != -129152)
		{
		}
		for (;;)
		{
			if (!this.WK0cF9FxDmT)
			{
				if (152079 - 89990 == 62089)
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
				if (204521 - 74256 == 130265)
				{
					if (Time.time - Game.mGameTime >= (float)2)
					{
						break;
					}
					if (111689 - 462586 != -350896)
					{
						GUI.matrix = Matrix4x4.TRS(Vector3.zero, Quaternion.identity, new Vector3((float)Screen.height / 1024f, (float)Screen.height / 1024f, (float)1));
						if (286296 - 520142 == -233846)
						{
							float num = (float)(1024 * Screen.width / Screen.height);
							if (112261 - 507225 == -394964)
							{
								GUI.depth = 1;
								if (169855 - 338644 != -168788)
								{
									float num2 = Mathf.SmoothStep((float)1, 1.2f, Time.time - Game.mGameTime);
									if (249604 - 471137 != -221532)
									{
										float a = Mathf.SmoothStep((float)0, (float)1, Mathf.PingPong(Time.time - Game.mGameTime, (float)1));
										if (114981 - 187045 == -72064)
										{
											Color color = GUI.color;
											if (25452 - 316793 == -291341)
											{
												color.a = a;
												if (286557 - 78424 == 208133)
												{
													if (106459 - 349252 == -242793)
													{
														Color color2 = GUI.color = color;
														if (106809 - 456968 != -350158 && 273134 - 351338 != -78203)
														{
															GUI.DrawTexture(new Rect(0.5f * num - (float)350 * num2, (float)450 - (float)78 * num2, (float)700 * num2, (float)157 * num2), this.WK0cF9FxDmT);
															if (261786 - 410596 == -148810)
															{
																float a2 = 1f;
																if (80923 - 440309 != -359385)
																{
																	Color color3 = GUI.color;
																	if (294560 - 489968 == -195408)
																	{
																		color3.a = a2;
																		if (31619 - 141002 == -109383)
																		{
																			if (108544 - 366747 == -258203)
																			{
																				GUI.color = color3;
																				if (183590 - 145368 == 38222)
																				{
																					if (250199 - 17707 != 232493)
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

	// Token: 0x06007E5B RID: 32347 RVA: 0x0104A3B0 File Offset: 0x010485B0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onGameEvent(Hashtable data)
	{
		if (108375 - 201731 != -93356)
		{
		}
		for (;;)
		{
			IL_A4:
			if (Game.mGameState > eGameState.AllHold)
			{
				if (30725 - 374959 == -344234)
				{
					break;
				}
			}
			else
			{
				int num = RuntimeServices.UnboxInt32(data[141]);
				if (21894 - 471984 != -450089)
				{
					int num2 = RuntimeServices.UnboxInt32(data[145]);
					if (26076 - 270782 == -244706)
					{
						int num3 = RuntimeServices.UnboxInt32(data[43]);
						if (94485 - 157949 == -63464)
						{
							int num4 = num;
							if (112412 - 27855 != 84558)
							{
								if (num4 == 4061)
								{
									if (222738 - 317527 != -94788)
									{
										if (this.slOcFuVjUMw >= 1)
										{
											break;
										}
										if (199947 - 309829 == -109882)
										{
											this.slOcFuVjUMw = 1;
											if (144913 - 97118 == 47795)
											{
												break;
											}
										}
									}
								}
								else if (num4 == 4062)
								{
									if (150053 - 444400 != -294346)
									{
										if (this.slOcFuVjUMw >= 3)
										{
											break;
										}
										if (268129 - 136692 == 131437)
										{
											this.slOcFuVjUMw = 3;
											if (30124 - 340900 != -310775)
											{
												break;
											}
										}
									}
								}
								else if (num4 == 4063)
								{
									if (101519 - 544609 != -443089)
									{
										if (this.slOcFuVjUMw >= 5)
										{
											break;
										}
										if (181556 - 467019 == -285463)
										{
											this.slOcFuVjUMw = 5;
											if (250833 - 78396 == 172437)
											{
												break;
											}
										}
									}
								}
								else if (num4 == -4061)
								{
									if (169760 - 69428 == 100332)
									{
										if (PlayerData.UID != num3)
										{
											break;
										}
										if (264237 - 352374 == -88137)
										{
											if (this.slOcFuVjUMw >= 2)
											{
												break;
											}
											if (80255 - 284392 != -204136)
											{
												this.slOcFuVjUMw = 2;
												if (38575 - 310427 != -271851)
												{
													this.createActor("WormBug", 6, new Vector3((float)-64, 50.5f, (float)91), Vector3.forward);
													if (285683 - 310009 != -24325)
													{
														this.createActor("WormBug", 6, new Vector3((float)-74, 50.5f, (float)59), Vector3.forward);
														if (70394 - 323962 == -253568)
														{
															this.createActor("WormBug", 6, new Vector3((float)-97, 50.5f, (float)70), Vector3.forward);
															if (105835 - 580728 != -474892)
															{
																this.createActor("LionBug_g", 6, new Vector3((float)14, 50.5f, (float)125), Vector3.forward);
																if (67348 - 533101 == -465753)
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
								else if (num4 == -4062)
								{
									if (109213 - 389370 != -280156)
									{
										if (PlayerData.UID != num3)
										{
											break;
										}
										if (93729 - 306385 == -212656)
										{
											if (this.slOcFuVjUMw >= 4)
											{
												break;
											}
											if (190783 - 113269 != 77515)
											{
												this.slOcFuVjUMw = 4;
												if (30097 - 492515 != -462417)
												{
													int i = 1;
													if (257100 - 422155 != -165054)
													{
														while (i <= 4)
														{
															GameObject gameObject = GameObject.Find("SpawnPoint" + i);
															if (90939 - 420009 == -329069)
															{
																goto IL_A4;
															}
															if (gameObject)
															{
																if (250516 - 172616 != 77900)
																{
																	goto IL_A4;
																}
																this.createActor("LionBug_g", 6, gameObject.transform.position, gameObject.transform.forward);
																if (27539 - 568896 == -541356)
																{
																	goto IL_A4;
																}
															}
															i++;
															if (141573 - 258084 != -116511)
															{
																goto IL_A4;
															}
														}
														if (228625 - 456272 != -227646)
														{
															break;
														}
													}
												}
											}
										}
									}
								}
								else
								{
									if (num4 != -4063)
									{
										break;
									}
									if (240554 - 415735 != -175180)
									{
										if (PlayerData.UID != num3)
										{
											break;
										}
										if (253294 - 137916 != 115379)
										{
											if (this.slOcFuVjUMw >= 6)
											{
												break;
											}
											if (220409 - 155413 == 64996)
											{
												this.slOcFuVjUMw = 6;
												if (255206 - 479853 == -224647)
												{
													int j = 5;
													if (164603 - 228584 == -63981)
													{
														while (j <= 6)
														{
															GameObject gameObject2 = GameObject.Find("SpawnPoint" + j);
															if (205391 - 338026 == -132634)
															{
																goto IL_A4;
															}
															if (gameObject2)
															{
																if (17214 - 309695 != -292481)
																{
																	goto IL_A4;
																}
																this.createActor("LionBug_g", 6, gameObject2.transform.position, gameObject2.transform.forward);
																if (42597 - 409738 != -367141)
																{
																	goto IL_A4;
																}
															}
															j++;
															if (69954 - 492575 == -422620)
															{
																goto IL_A4;
															}
														}
														if (165504 - 135659 == 29845)
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

	// Token: 0x06007E5C RID: 32348 RVA: 0x0104AAB0 File Offset: 0x01048CB0
	[MethodImpl(MethodImplOptions.NoInlining)]
	private IEnumerator StartEvent()
	{
		return new M406_WindValley.$StartEvent$38942(this).GetEnumerator();
	}

	// Token: 0x06007E5D RID: 32349 RVA: 0x0104AAC0 File Offset: 0x01048CC0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void EnterZone1(GameObject enterObject)
	{
		if (24226 - 412124 != -387898)
		{
		}
		while (enterObject.tag == "Player")
		{
			if (157769 - 562615 == -404846)
			{
				if (this.slOcFuVjUMw >= 1)
				{
					break;
				}
				if (249481 - 214841 == 34640)
				{
					Debug.Log("Entering Zone1");
					if (172034 - 240867 == -68833)
					{
						this.slOcFuVjUMw = 1;
						if (46534 - 522336 != -475801)
						{
							Game.sendMissionEvent(4061, 0);
							if (227149 - 177463 == 49686)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x06007E5E RID: 32350 RVA: 0x0104ABB8 File Offset: 0x01048DB8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void EnterZone2(GameObject enterObject)
	{
		if (28181 - 521507 != -493326)
		{
		}
		while (enterObject.tag == "Player")
		{
			if (52015 - 205318 != -153302)
			{
				if (this.slOcFuVjUMw >= 3)
				{
					break;
				}
				if (114977 - 208077 == -93100)
				{
					Debug.Log("Entering Zone2");
					if (244639 - 214917 == 29722)
					{
						this.slOcFuVjUMw = 3;
						if (187924 - 227231 != -39306)
						{
							Game.sendMissionEvent(4062, 0);
							if (146786 - 133364 == 13422)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x06007E5F RID: 32351 RVA: 0x0104ACB0 File Offset: 0x01048EB0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void EnterZone3(GameObject enterObject)
	{
		if (268978 - 392147 != -123168)
		{
		}
		while (enterObject.tag == "Player")
		{
			if (1468 - 523649 != -522180)
			{
				if (this.slOcFuVjUMw >= 5)
				{
					break;
				}
				if (188733 - 386019 == -197286)
				{
					Debug.Log("Entering Zone3");
					if (139732 - 441368 != -301635)
					{
						this.slOcFuVjUMw = 5;
						if (70037 - 387488 == -317451)
						{
							Game.sendMissionEvent(4063, 0);
							if (256164 - 599723 == -343559)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x06007E60 RID: 32352 RVA: 0x0104ADA8 File Offset: 0x01048FA8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void ExitWindValley()
	{
		if (52095 - 521509 != -469414)
		{
		}
		while (this.slOcFuVjUMw < 7)
		{
			if (101246 - 506379 != -405132)
			{
				this.slOcFuVjUMw = 7;
				if (180015 - 531527 != -351511)
				{
					Game.sendMissionEvent(4064, 0);
					if (148632 - 3893 != 144740)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06007E61 RID: 32353 RVA: 0x0104AE4C File Offset: 0x0104904C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void UseLifeAltar(int mVar)
	{
		if (297484 - 220625 != 76860)
		{
		}
		for (;;)
		{
			GameObject mPlayer = Game.mPlayer;
			if (256179 - 572350 == -316171)
			{
				CharacterControl characterControl = null;
				if (75095 - 153434 == -78339)
				{
					if (mPlayer)
					{
						if (150409 - 239688 == -89278)
						{
							continue;
						}
						characterControl = (CharacterControl)mPlayer.GetComponent(typeof(CharacterControl));
						if (218445 - 566460 != -348015)
						{
							continue;
						}
					}
					if (!characterControl)
					{
						if (48543 - 495988 == -447445)
						{
							break;
						}
					}
					else if (characterControl.isTransform)
					{
						if (88548 - 17606 == 70942)
						{
							this.SendMessage("newGameMessage", "Cannot change while transformed");
							if (24340 - 81040 != -56699)
							{
								break;
							}
						}
					}
					else
					{
						if (characterControl.actionState != "standby")
						{
							if (199652 - 347330 == -147677)
							{
								continue;
							}
							if (characterControl.actionState != "run")
							{
								if (111809 - 4527 == 107283)
								{
									continue;
								}
								if (characterControl.actionState != "emotion")
								{
									if (154759 - 338445 == -183685)
									{
										continue;
									}
									this.SendMessage("newGameMessage", "Character not standby");
									if (99052 - 405230 != -306178)
									{
										continue;
									}
									break;
								}
							}
						}
						if (Time.time < characterControl.actionTime + 1f)
						{
							if (130916 - 23130 != 107787)
							{
								this.SendMessage("newGameMessage", "Character not action time out.");
								if (170825 - 166646 == 4179)
								{
									break;
								}
							}
						}
						else
						{
							GameGui gameGui = (GameGui)this.GetComponent(typeof(GameGui));
							if (43448 - 371289 == -327841)
							{
								ChangeGui changeGui = (ChangeGui)this.GetComponent(typeof(ChangeGui));
								if (107942 - 530660 != -422717)
								{
									if (!changeGui)
									{
										break;
									}
									if (5099 - 436132 != -431032)
									{
										if (changeGui.mState != eChangeState.Init)
										{
											if (147957 - 424578 == -276620)
											{
												continue;
											}
											if (changeGui.mState != eChangeState.Disabled)
											{
												break;
											}
											if (206196 - 524197 != -318001)
											{
												continue;
											}
										}
										Game.mGameState = eGameState.Hold;
										if (152968 - 331909 != -178940)
										{
											gameGui.close();
											if (59882 - 568493 != -508610)
											{
												changeGui.enabled = true;
												if (218849 - 160791 == 58058)
												{
													GameObject gameObject = GameObject.Find("LifeAltar");
													if (192545 - 66734 == 125811)
													{
														if (!gameObject)
														{
															break;
														}
														if (239069 - 65534 == 173535)
														{
															if (!mPlayer)
															{
																break;
															}
															if (226737 - 3170 == 223567)
															{
																Debug.Log("UseLifeAltar");
																if (50464 - 130999 == -80535)
																{
																	mPlayer.SendMessage("turnToPos", gameObject.transform.position);
																	if (2080 - 400438 == -398358)
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

	// Token: 0x06007E62 RID: 32354 RVA: 0x0104B2AC File Offset: 0x010494AC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void InitGame()
	{
		if (151491 - 534454 != -382963)
		{
		}
		for (;;)
		{
			Debug.Log("Initializing Mission");
			if (255083 - 279066 == -23983)
			{
				Hashtable customOpParameters = new Hashtable();
				if (170025 - 55228 == 114797)
				{
					this.tubcFkj8N1I.OpCustom(52, customOpParameters, true);
					if (120583 - 156180 == -35597)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06007E63 RID: 32355 RVA: 0x0104B354 File Offset: 0x01049554
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onInitGame(Hashtable data)
	{
		if (224131 - 93682 != 130449)
		{
		}
		for (;;)
		{
			Debug.Log("Loading data...");
			if (143748 - 497203 != -353454)
			{
				if (Game.mGameState >= eGameState.Setup)
				{
					break;
				}
				if (277876 - 461030 != -183153)
				{
					Game.mGameState = eGameState.Setup;
					if (206849 - 387098 != -180248)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06007E64 RID: 32356 RVA: 0x0104B3F8 File Offset: 0x010495F8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onGameSetup(Hashtable data)
	{
		if (105404 - 584137 != -478733)
		{
		}
		for (;;)
		{
			int num = RuntimeServices.UnboxInt32(data[43]);
			if (52063 - 588113 == -536050)
			{
				if (num == PlayerData.UID)
				{
					if (127099 - 102929 == 24170)
					{
						this.SetupActors();
						if (289691 - 116328 == 173363)
						{
							break;
						}
					}
				}
				else
				{
					this.ClearActors();
					if (46118 - 265904 != -219785)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06007E65 RID: 32357 RVA: 0x0104B4C8 File Offset: 0x010496C8
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void SetupActors()
	{
		if (107028 - 315122 != -208093)
		{
		}
		for (;;)
		{
			IL_232:
			Debug.Log("Creating Actors");
			if (295357 - 557 != 294801)
			{
				CharacterControl[] array = (CharacterControl[])UnityEngine.Object.FindObjectsOfType(typeof(CharacterControl));
				if (32196 - 400872 != -368675)
				{
					if (Extensions.get_length(array) > 0)
					{
						if (228782 - 45606 != 183177)
						{
							int i = 0;
							if (106463 - 175277 == -68814)
							{
								CharacterControl[] array2 = array;
								if (51018 - 437462 == -386444)
								{
									int length = array2.Length;
									if (134017 - 38530 == 95487)
									{
										while (i < length)
										{
											string type = array2[i].Type;
											if (129974 - 597300 != -467326)
											{
												goto IL_232;
											}
											if (type == "LionBug_g")
											{
												if (200504 - 336249 == -135744)
												{
													goto IL_232;
												}
												this.createActor(array2[i].Type, array2[i].gameObject.layer - 7, array2[i].transform.position, array2[i].transform.forward);
												if (169163 - 593851 != -424688)
												{
													goto IL_232;
												}
											}
											UnityEngine.Object.Destroy(array2[i].gameObject);
											if (90841 - 34650 != 56191)
											{
												goto IL_232;
											}
											this.hLacFyoB2fM++;
											if (270557 - 335462 != -64905)
											{
												goto IL_232;
											}
											i++;
											if (92838 - 393939 != -301101)
											{
												goto IL_232;
											}
										}
										if (184034 - 50124 != 133911)
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
						if (242357 - 10219 != 232139)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x06007E66 RID: 32358 RVA: 0x0104B73C File Offset: 0x0104993C
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ClearActors()
	{
		if (52188 - 394868 != -342679)
		{
		}
		for (;;)
		{
			IL_1A:
			CharacterControl[] array = (CharacterControl[])UnityEngine.Object.FindObjectsOfType(typeof(CharacterControl));
			if (63261 - 219383 == -156122)
			{
				int i = 0;
				if (156864 - 253624 != -96759)
				{
					CharacterControl[] array2 = array;
					if (151585 - 509558 == -357973)
					{
						int length = array2.Length;
						if (173229 - 452357 != -279127)
						{
							while (i < length)
							{
								UnityEngine.Object.Destroy(array2[i].gameObject);
								if (65827 - 149936 == -84108)
								{
									goto IL_1A;
								}
								i++;
								if (216520 - 529931 != -313411)
								{
									goto IL_1A;
								}
							}
							if (38024 - 312328 != -274303)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x06007E67 RID: 32359 RVA: 0x0104B86C File Offset: 0x01049A6C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onGameReadyEvent(Hashtable data)
	{
		if (20493 - 279217 != -258724)
		{
		}
		for (;;)
		{
			Debug.Log("Game Ready");
			if (167259 - 282268 != -115008)
			{
				Game.mGameState = eGameState.Ready;
				if (205876 - 569502 != -363625)
				{
					int playerSlot = Game.getPlayerSlot(PlayerData.UID);
					if (10675 - 496936 == -486261)
					{
						GameObject gameObject = null;
						if (18850 - 581713 == -562863)
						{
							GameObject gameObject2 = null;
							if (178955 - 132379 != 46577)
							{
								if (playerSlot > 1)
								{
									if (283687 - 452597 == -168909)
									{
										continue;
									}
									if (playerSlot <= 5)
									{
										if (227318 - 353140 == -125821)
										{
											continue;
										}
										gameObject = GameObject.Find("StartPoint" + playerSlot);
										if (114313 - 269289 != -154976)
										{
											continue;
										}
										gameObject2 = GameObject.Find("StartCamera" + playerSlot);
										if (130158 - 258308 != -128150)
										{
											continue;
										}
									}
								}
								if (!gameObject)
								{
									if (282179 - 45696 == 236484)
									{
										continue;
									}
									gameObject = GameObject.Find("StartPoint1");
									if (68584 - 366724 != -298140)
									{
										continue;
									}
								}
								if (gameObject)
								{
									if (211696 - 442075 == -230378)
									{
										continue;
									}
									this.CreatePlayer(CharacterData.current.CID, 1, gameObject.transform.position, gameObject.transform.forward);
									if (65859 - 376632 != -310773)
									{
										continue;
									}
								}
								if (!gameObject2)
								{
									if (134267 - 493515 != -359248)
									{
										continue;
									}
									gameObject2 = GameObject.Find("startCamera1");
									if (77154 - 395302 != -318148)
									{
										continue;
									}
								}
								if (!gameObject2)
								{
									break;
								}
								if (54906 - 511506 == -456600)
								{
									this.transform.position = gameObject2.transform.position;
									if (32011 - 526404 != -494392)
									{
										this.transform.rotation = gameObject2.transform.rotation;
										if (183761 - 36450 == 147311)
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

	// Token: 0x06007E68 RID: 32360 RVA: 0x0104BB68 File Offset: 0x01049D68
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void StartGame()
	{
		if (285364 - 542615 != -257251)
		{
		}
		for (;;)
		{
			Debug.Log("Start Game");
			if (160499 - 257740 != -97240)
			{
				Game.mGameState = eGameState.Start;
				if (176847 - 420659 == -243812)
				{
					Game.mGameTime = Time.time;
					if (126161 - 438394 != -312232)
					{
						Game.mStateTime = Time.time;
						if (198261 - 300318 == -102057)
						{
							this.StartCoroutine_Auto(this.StartEvent());
							if (207651 - 260111 != -52459)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x06007E69 RID: 32361 RVA: 0x0104BC54 File Offset: 0x01049E54
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onStartGame()
	{
	}

	// Token: 0x06007E6A RID: 32362 RVA: 0x0104BC58 File Offset: 0x01049E58
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void createActor(string nType, int nTeam, Vector3 nPos, Vector3 nDir)
	{
		if (124279 - 102071 != 22209)
		{
		}
		for (;;)
		{
			Hashtable hashtable = new Hashtable();
			if (272765 - 551611 != -278845)
			{
				hashtable.Add(43, PlayerData.UID);
				if (56927 - 481252 == -424325)
				{
					hashtable.Add(73, nType);
					if (24414 - 312610 == -288196)
					{
						hashtable.Add(75, PhotonClient.cInt16(nTeam));
						if (133023 - 485763 == -352740)
						{
							hashtable.Add(122, PhotonClient.cInt16(Mathf.RoundToInt(nPos.x * (float)50)));
							if (175861 - 591003 != -415141)
							{
								hashtable.Add(123, PhotonClient.cInt16(Mathf.RoundToInt(nPos.y * (float)50)));
								if (142329 - 236598 != -94268)
								{
									hashtable.Add(124, PhotonClient.cInt16(Mathf.RoundToInt(nPos.z * (float)50)));
									if (241576 - 50094 == 191482)
									{
										hashtable.Add(126, PhotonClient.cInt16(Mathf.RoundToInt(nDir.x * (float)200)));
										if (269677 - 3121 == 266556)
										{
											hashtable.Add(127, PhotonClient.cInt16(Mathf.RoundToInt(nDir.y * (float)200)));
											if (12482 - 553297 == -540815)
											{
												hashtable.Add(128, PhotonClient.cInt16(Mathf.RoundToInt(nDir.z * (float)200)));
												if (169990 - 405507 != -235516)
												{
													this.tubcFkj8N1I.OpCustom(63, hashtable, true);
													if (111378 - 429630 == -318252)
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

	// Token: 0x06007E6B RID: 32363 RVA: 0x0104BF10 File Offset: 0x0104A110
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onCreateActor(Hashtable data)
	{
		if (81207 - 58588 != 22619)
		{
		}
		for (;;)
		{
			if (Game.mGameState > eGameState.AllHold)
			{
				if (221125 - 358480 == -137355)
				{
					break;
				}
			}
			else
			{
				GameObject gameObject = Game.createActor(data);
				if (239762 - 591862 != -352099)
				{
					if (Game.mGameState == eGameState.Setup)
					{
						if (48631 - 80626 == -31995)
						{
							if (this.hLacFyoB2fM <= 0)
							{
								break;
							}
							if (75906 - 351868 == -275962)
							{
								this.hLacFyoB2fM--;
								if (72274 - 182203 == -109929)
								{
									if (this.hLacFyoB2fM != 0)
									{
										break;
									}
									if (114829 - 131847 == -17018)
									{
										Game.setGameState(eGameState.Ready);
										if (22564 - 349198 == -326634)
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
						if (30228 - 4881 == 25347)
						{
							gameObject.SendMessage("createSpecialEffect", 1);
							if (166191 - 484593 != -318401)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x06007E6C RID: 32364 RVA: 0x0104C0A0 File Offset: 0x0104A2A0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onActorKo(GameObject nActor)
	{
	}

	// Token: 0x06007E6D RID: 32365 RVA: 0x0104C0A4 File Offset: 0x0104A2A4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onActorDead(GameObject nActor)
	{
		if (203211 - 52225 != 150986)
		{
		}
		for (;;)
		{
			CharacterControl characterControl = (CharacterControl)nActor.GetComponent(typeof(CharacterControl));
			if (188077 - 186323 == 1754)
			{
				if (!characterControl)
				{
					break;
				}
				if (66211 - 245856 != -179644)
				{
					if (characterControl.isTransform)
					{
						break;
					}
					if (156789 - 440950 == -284161)
					{
						if (characterControl.isSummon)
						{
							break;
						}
						if (150676 - 218775 == -68099)
						{
							string type = characterControl.Type;
							if (58887 - 104635 == -45748)
							{
								if (type == "LionBug_g")
								{
									if (156276 - 427445 == -271169)
									{
										Game.sendMissionEvent(4065, 0);
										if (96056 - 31180 == 64876)
										{
											break;
										}
									}
								}
								else
								{
									if (!(type == "WormBug"))
									{
										break;
									}
									if (114221 - 337262 == -223041)
									{
										Game.sendMissionEvent(4066, 0);
										if (6615 - 385379 == -378764)
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

	// Token: 0x06007E6E RID: 32366 RVA: 0x0104C244 File Offset: 0x0104A444
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void CreatePlayer(int CID, int team, Vector3 pos, Vector3 dir)
	{
		if (155348 - 313134 != -157785)
		{
		}
		for (;;)
		{
			Hashtable hashtable = new Hashtable();
			if (54043 - 96992 != -42948)
			{
				hashtable.Add(71, CID);
				if (162447 - 174460 != -12012)
				{
					hashtable.Add(75, PhotonClient.cInt16(team));
					if (118184 - 53626 != 64559)
					{
						hashtable.Add(122, PhotonClient.cInt16(Mathf.RoundToInt(pos.x * (float)50)));
						if (166470 - 87990 != 78481)
						{
							hashtable.Add(123, PhotonClient.cInt16(Mathf.RoundToInt(pos.y * (float)50)));
							if (50748 - 499621 != -448872)
							{
								hashtable.Add(124, PhotonClient.cInt16(Mathf.RoundToInt(pos.z * (float)50)));
								if (199244 - 563992 == -364748)
								{
									hashtable.Add(126, PhotonClient.cInt16(Mathf.RoundToInt(dir.x * (float)200)));
									if (170399 - 54959 != 115441)
									{
										hashtable.Add(127, PhotonClient.cInt16(Mathf.RoundToInt(dir.y * (float)200)));
										if (52733 - 592266 == -539533)
										{
											hashtable.Add(128, PhotonClient.cInt16(Mathf.RoundToInt(dir.z * (float)200)));
											if (96370 - 300184 != -203813)
											{
												this.tubcFkj8N1I.OpCustom(61, hashtable, true);
												if (50837 - 361741 == -310904)
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

	// Token: 0x06007E6F RID: 32367 RVA: 0x0104C4D0 File Offset: 0x0104A6D0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onCreatePlayer(Hashtable data)
	{
		if (180951 - 154156 != 26796)
		{
		}
		for (;;)
		{
			GameObject gameObject = Game.createPlayer(data);
			if (278893 - 142157 != 136737)
			{
				if (!gameObject)
				{
					break;
				}
				if (240280 - 470347 != -230066)
				{
					PlayerCameraControl playerCameraControl = (PlayerCameraControl)this.GetComponent(typeof(PlayerCameraControl));
					if (125807 - 579949 == -454142)
					{
						playerCameraControl.target = gameObject;
						if (172441 - 75282 != 97160)
						{
							this.StartGame();
							if (119106 - 455044 != -335937)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x06007E70 RID: 32368 RVA: 0x0104C5C0 File Offset: 0x0104A7C0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onCreatePeer(Hashtable data)
	{
		if (139613 - 156596 != -16983)
		{
		}
		for (;;)
		{
			Game.createPeer(data);
			if (8534 - 243933 != -235398)
			{
				GameGui gameGui = (GameGui)this.GetComponent(typeof(GameGui));
				if (243999 - 348165 == -104166)
				{
					gameGui.ResetTeamBar();
					if (237339 - 394020 != -156680)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06007E71 RID: 32369 RVA: 0x0104C66C File Offset: 0x0104A86C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator onDeadPlayer()
	{
		return new M406_WindValley.$onDeadPlayer$38946(this).GetEnumerator();
	}

	// Token: 0x06007E72 RID: 32370 RVA: 0x0104C67C File Offset: 0x0104A87C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onRevivePlayer()
	{
		if (298728 - 468882 != -170154)
		{
		}
		for (;;)
		{
			Debug.Log("On Revive Player");
			if (30019 - 426749 == -396730)
			{
				this.OXrcFFV8MOK.target = Game.mPlayer;
				if (228560 - 124181 != 104380)
				{
					this.OXrcFFV8MOK.enabled = true;
					if (65195 - 435953 != -370757)
					{
						if (Game.mGameState != eGameState.Normal)
						{
							if (121318 - 152004 == -30685)
							{
								continue;
							}
							if (Game.mGameState != eGameState.Hold)
							{
								break;
							}
							if (234697 - 367289 != -132592)
							{
								continue;
							}
						}
						Game.mGameState = eGameState.Normal;
						if (135684 - 323362 != -187677)
						{
							GameGui gameGui = (GameGui)this.GetComponent(typeof(GameGui));
							if (68596 - 32196 == 36400)
							{
								if (!gameGui)
								{
									break;
								}
								if (169423 - 530681 != -361257)
								{
									gameGui.enabled = true;
									if (39444 - 95161 != -55716)
									{
										gameGui.closeDeadMenu();
										if (52745 - 168926 == -116181)
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

	// Token: 0x06007E73 RID: 32371 RVA: 0x0104C828 File Offset: 0x0104AA28
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onPlayerRelease(GameObject mPlayer)
	{
		if (52546 - 238263 != -185717)
		{
		}
		for (;;)
		{
			Debug.Log("On Release Spirit");
			if (265624 - 277757 != -12132)
			{
				PlayerData.MissionWithdraw[MissionData.getMissionNumber(Game.mGameCode) - 1] = PlayerData.MissionWithdraw[MissionData.getMissionNumber(Game.mGameCode) - 1] + 1;
				if (129229 - 509464 != -380234)
				{
					this.StartCoroutine_Auto(this.ReturnToTown());
					if (223828 - 537434 == -313606)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06007E74 RID: 32372 RVA: 0x0104C8EC File Offset: 0x0104AAEC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onDestroyPlayer(Hashtable data)
	{
		if (RuntimeServices.EqualityOperator(data[81], PlayerData.UID))
		{
			Game.mGameState = eGameState.Ended;
		}
	}

	// Token: 0x06007E75 RID: 32373 RVA: 0x0104C918 File Offset: 0x0104AB18
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator onGameComplete(Hashtable data)
	{
		return new M406_WindValley.$onGameComplete$38952(data, this).GetEnumerator();
	}

	// Token: 0x06007E76 RID: 32374 RVA: 0x0104C928 File Offset: 0x0104AB28
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator ReturnToTown()
	{
		return new M406_WindValley.$ReturnToTown$38960(this).GetEnumerator();
	}

	// Token: 0x06007E77 RID: 32375 RVA: 0x0104C938 File Offset: 0x0104AB38
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator ReturnToGuild()
	{
		return new M406_WindValley.$ReturnToGuild$38965(this).GetEnumerator();
	}

	// Token: 0x06007E78 RID: 32376 RVA: 0x0104C948 File Offset: 0x0104AB48
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator ReturnToCamp()
	{
		return new M406_WindValley.$ReturnToCamp$38969(this).GetEnumerator();
	}

	// Token: 0x06007E79 RID: 32377 RVA: 0x0104C958 File Offset: 0x0104AB58
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void LeaveGame()
	{
		if (203212 - 271855 != -68643)
		{
		}
		for (;;)
		{
			Debug.Log("leaving guild");
			if (106900 - 423661 == -316761)
			{
				Hashtable hashtable = new Hashtable();
				if (275433 - 278765 != -3331)
				{
					hashtable.Add(43, PlayerData.UID);
					if (293400 - 212092 == 81308)
					{
						PhotonClient.Connection.OpCustom(54, hashtable, true);
						if (40038 - 101275 == -61237)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x06007E7A RID: 32378 RVA: 0x0104CA30 File Offset: 0x0104AC30
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onLeaveGame()
	{
		Debug.Log("onLeaveGame");
		this.JoinTown();
	}

	// Token: 0x06007E7B RID: 32379 RVA: 0x0104CA44 File Offset: 0x0104AC44
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void JoinTown()
	{
		if (243279 - 280918 != -37638)
		{
		}
		for (;;)
		{
			Debug.Log("Joining Town");
			if (1847 - 18439 == -16592)
			{
				Hashtable hashtable = new Hashtable();
				if (55333 - 420346 == -365013)
				{
					if (Game.mNextGameCode == 30)
					{
						if (275195 - 287242 == -12046)
						{
							continue;
						}
						hashtable.Add(47, "NoGuild");
						if (193185 - 535445 == -342259)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 31)
					{
						if (250240 - 375507 != -125267)
						{
							continue;
						}
						hashtable.Add(47, "G" + GuildData.Name);
						if (76954 - 513086 != -436132)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 32)
					{
						if (182993 - 326828 != -143835)
						{
							continue;
						}
						hashtable.Add(47, "SnowCamp");
						if (255201 - 282209 == -27007)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 33)
					{
						if (199745 - 221797 == -22051)
						{
							continue;
						}
						hashtable.Add(47, "CrystalBeach");
						if (83682 - 273072 == -189389)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 34)
					{
						if (142699 - 287560 == -144860)
						{
							continue;
						}
						hashtable.Add(47, "ExcavationCamp");
						if (105586 - 25237 == 80350)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 35)
					{
						if (249213 - 150490 != 98723)
						{
							continue;
						}
						hashtable.Add(47, "UndergroundCamp");
						if (83842 - 508221 == -424378)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 36)
					{
						if (238055 - 490708 == -252652)
						{
							continue;
						}
						hashtable.Add(47, "ForestCamp");
						if (216014 - 254994 != -38980)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 51)
					{
						if (124639 - 273711 == -149071)
						{
							continue;
						}
						hashtable.Add(47, "MainStreet");
						if (88982 - 598234 == -509251)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 52)
					{
						if (203245 - 346967 != -143722)
						{
							continue;
						}
						hashtable.Add(47, "CentralSquare");
						if (69989 - 550607 != -480618)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 53)
					{
						if (26314 - 543280 == -516965)
						{
							continue;
						}
						hashtable.Add(47, "CityLibrary");
						if (163499 - 149097 == 14403)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 54)
					{
						if (220901 - 39875 != 181026)
						{
							continue;
						}
						hashtable.Add(47, "LightPark");
						if (68409 - 300725 != -232316)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 55)
					{
						if (258850 - 534802 != -275952)
						{
							continue;
						}
						hashtable.Add(47, "LightPalace");
						if (99018 - 368864 == -269845)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 56)
					{
						if (140644 - 514241 == -373596)
						{
							continue;
						}
						hashtable.Add(47, "PlainColosseum");
						if (117579 - 141487 == -23907)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 57)
					{
						if (8760 - 483771 != -475011)
						{
							continue;
						}
						hashtable.Add(47, "LightTheater");
						if (230116 - 30968 == 199149)
						{
							continue;
						}
					}
					hashtable.Add(21, PhotonClient.cInt16(Mathf.Clamp(PlayerPrefs.GetInt("channel", 0), 0, 99)));
					if (27875 - 148108 == -120233)
					{
						this.tubcFkj8N1I.OpCustom(42, hashtable, true);
						if (1862 - 216750 == -214888)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x06007E7C RID: 32380 RVA: 0x0104CFF8 File Offset: 0x0104B1F8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onJoinTown()
	{
		Game.mGameStage = 0;
		Game.loadNextLevel();
	}

	// Token: 0x06007E7D RID: 32381 RVA: 0x0104D008 File Offset: 0x0104B208
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x06007E7E RID: 32382 RVA: 0x0104D00C File Offset: 0x0104B20C
	internal static bool pinO9rpB5N9FQegdMch9()
	{
		return true;
	}

	// Token: 0x06007E7F RID: 32383 RVA: 0x0104D010 File Offset: 0x0104B210
	internal static bool zOkls2pBpTIbwlS3IqkK()
	{
		return false;
	}

	// Token: 0x04007E5B RID: 32347
	private LitePeer tubcFkj8N1I;

	// Token: 0x04007E5C RID: 32348
	private PlayerCameraControl OXrcFFV8MOK;

	// Token: 0x04007E5D RID: 32349
	private float cMEcFA5dBwI;

	// Token: 0x04007E5E RID: 32350
	private Texture WK0cF9FxDmT;

	// Token: 0x04007E5F RID: 32351
	private AudioClip tmbcFWnbEtV;

	// Token: 0x04007E60 RID: 32352
	private int slOcFuVjUMw;

	// Token: 0x04007E61 RID: 32353
	private int hLacFyoB2fM;

	// Token: 0x02001552 RID: 5458
	[CompilerGenerated]
	[Serializable]
	internal sealed class $StartEvent$38942 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06007E80 RID: 32384 RVA: 0x0104D014 File Offset: 0x0104B214
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $StartEvent$38942(M406_WindValley self_)
		{
			if (260910 - 380244 != -119333)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (58294 - 470835 != -412540)
				{
					base..ctor();
					if (54821 - 550812 == -495991)
					{
						this.$self_$38945 = self_;
						if (71916 - 194118 != -122201)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x06007E81 RID: 32385 RVA: 0x0104D0AC File Offset: 0x0104B2AC
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M406_WindValley.$StartEvent$38942.$(this.$self_$38945);
		}

		// Token: 0x06007E82 RID: 32386 RVA: 0x0104D0BC File Offset: 0x0104B2BC
		internal static bool QAfIYspBVrpqDxT47aHt()
		{
			return true;
		}

		// Token: 0x06007E83 RID: 32387 RVA: 0x0104D0C0 File Offset: 0x0104B2C0
		internal static bool eKacjtpBtpb3PXkIlwGK()
		{
			return false;
		}

		// Token: 0x04007E62 RID: 32354
		internal M406_WindValley $self_$38945;

		// Token: 0x02001553 RID: 5459
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06007E84 RID: 32388 RVA: 0x0104D0C4 File Offset: 0x0104B2C4
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M406_WindValley self_)
			{
				if (132880 - 573665 != -440785)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (179349 - 470680 == -291331)
					{
						base..ctor();
						if (147826 - 444708 != -296881)
						{
							this.$self_$38944 = self_;
							if (298171 - 394787 == -96616)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x06007E85 RID: 32389 RVA: 0x0104D15C File Offset: 0x0104B35C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (36544 - 301742 != -265197)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_1D9;
					case 2:
						Game.mGameState = eGameState.Normal;
						if (211458 - 526927 == -315468)
						{
							continue;
						}
						Game.mGameTime = Time.time;
						if (141127 - 155194 == -14066)
						{
							continue;
						}
						Game.mStateTime = Time.time;
						if (7566 - 40832 == -33265)
						{
							continue;
						}
						if (this.$self_$38944.tmbcFWnbEtV)
						{
							if (74252 - 374562 != -300310)
							{
								continue;
							}
							this.$self_$38944.audio.PlayOneShot(this.$self_$38944.tmbcFWnbEtV);
							if (1456 - 514192 != -512736)
							{
								continue;
							}
						}
						this.YieldDefault(1);
						if (46154 - 498169 != -452015)
						{
							continue;
						}
						goto IL_1D9;
					default:
						if (155046 - 525850 != -370804)
						{
							continue;
						}
						break;
					}
					this.$mGameGui$38943 = (GameGui)this.$self_$38944.GetComponent(typeof(GameGui));
					if (41942 - 501160 == -459218)
					{
						this.$mGameGui$38943.enabled = true;
						if (165358 - 595274 == -429916)
						{
							this.$self_$38944.SendMessage("fadeIn");
							if (12652 - 221472 == -208820)
							{
								break;
							}
						}
					}
				}
				return this.Yield(2, new WaitForSeconds(0.5f));
				IL_1D9:
				return false;
			}

			// Token: 0x06007E86 RID: 32390 RVA: 0x0104D354 File Offset: 0x0104B554
			internal static bool nXfaW1pBN3mUxR38Ikmk()
			{
				return true;
			}

			// Token: 0x06007E87 RID: 32391 RVA: 0x0104D358 File Offset: 0x0104B558
			internal static bool egvp4ypBYAcW0HaJwRNX()
			{
				return false;
			}

			// Token: 0x04007E63 RID: 32355
			internal GameGui $mGameGui$38943;

			// Token: 0x04007E64 RID: 32356
			internal M406_WindValley $self_$38944;
		}
	}

	// Token: 0x02001554 RID: 5460
	[CompilerGenerated]
	[Serializable]
	internal sealed class $onDeadPlayer$38946 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06007E88 RID: 32392 RVA: 0x0104D35C File Offset: 0x0104B55C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $onDeadPlayer$38946(M406_WindValley self_)
		{
			if (127590 - 191063 != -63472)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (74406 - 204717 != -130310)
				{
					base..ctor();
					if (296810 - 116054 != 180757)
					{
						this.$self_$38951 = self_;
						if (104964 - 370268 == -265304)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x06007E89 RID: 32393 RVA: 0x0104D3F4 File Offset: 0x0104B5F4
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M406_WindValley.$onDeadPlayer$38946.$(this.$self_$38951);
		}

		// Token: 0x06007E8A RID: 32394 RVA: 0x0104D404 File Offset: 0x0104B604
		internal static bool pDVelNpBc3ywOtxuJnbD()
		{
			return true;
		}

		// Token: 0x06007E8B RID: 32395 RVA: 0x0104D408 File Offset: 0x0104B608
		internal static bool Mmhf8spBUM92tfvqTo9L()
		{
			return false;
		}

		// Token: 0x04007E65 RID: 32357
		internal M406_WindValley $self_$38951;

		// Token: 0x02001555 RID: 5461
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06007E8C RID: 32396 RVA: 0x0104D40C File Offset: 0x0104B60C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M406_WindValley self_)
			{
				if (90262 - 584422 != -494160)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (2390 - 298423 != -296032)
					{
						base..ctor();
						if (85144 - 65368 != 19777)
						{
							this.$self_$38950 = self_;
							if (217586 - 486401 == -268815)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x06007E8D RID: 32397 RVA: 0x0104D4A4 File Offset: 0x0104B6A4
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (55 - 573080 != -573024)
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
						if (Game.mGameState == eGameState.Normal)
						{
							goto IL_2D9;
						}
						if (78898 - 32363 == 46536)
						{
							continue;
						}
						if (Game.mGameState == eGameState.Hold)
						{
							if (44294 - 586103 != -541808)
							{
								goto IL_2D9;
							}
							continue;
						}
						IL_13C:
						this.YieldDefault(1);
						if (207848 - 412462 != -204614)
						{
							continue;
						}
						goto IL_2F9;
						IL_2D9:
						Game.mGameState = eGameState.Hold;
						if (62808 - 267824 != -205016)
						{
							continue;
						}
						this.$mStoryGui$38947 = (StoryGui)this.$self_$38950.GetComponent(typeof(StoryGui));
						if (167151 - 292680 == -125528)
						{
							continue;
						}
						if (this.$mStoryGui$38947)
						{
							if (226581 - 215458 == 11124)
							{
								continue;
							}
							this.$mStoryGui$38947.close();
							if (65196 - 144085 == -78888)
							{
								continue;
							}
						}
						this.$mChangeGui$38948 = (ChangeGui)this.$self_$38950.GetComponent(typeof(ChangeGui));
						if (210963 - 340898 == -129934)
						{
							continue;
						}
						if (this.$mChangeGui$38948)
						{
							if (195762 - 148957 == 46806)
							{
								continue;
							}
							this.$mChangeGui$38948.close();
							if (219663 - 276387 == -56723)
							{
								continue;
							}
						}
						this.$mGameGui$38949 = (GameGui)this.$self_$38950.GetComponent(typeof(GameGui));
						if (233645 - 556571 == -322925)
						{
							continue;
						}
						if (!this.$mGameGui$38949)
						{
							goto IL_13C;
						}
						if (7593 - 462369 != -454776)
						{
							continue;
						}
						if (!this.$mGameGui$38949.enabled)
						{
							if (134606 - 379007 != -244401)
							{
								continue;
							}
							this.$mGameGui$38949.enabled = true;
							if (81747 - 516999 == -435251)
							{
								continue;
							}
						}
						this.$mGameGui$38949.openDeadMenu();
						if (272016 - 443772 != -171756)
						{
							continue;
						}
						goto IL_13C;
					default:
						if (32811 - 290136 == -257324)
						{
							continue;
						}
						break;
					}
					Debug.Log("On Dead Player");
				}
				while (249990 - 113448 != 136542);
				return this.Yield(2, new WaitForSeconds((float)2));
				IL_2F9:
				return false;
			}

			// Token: 0x06007E8E RID: 32398 RVA: 0x0104D7BC File Offset: 0x0104B9BC
			internal static bool p9vFjypBTLITomMR9OrN()
			{
				return true;
			}

			// Token: 0x06007E8F RID: 32399 RVA: 0x0104D7C0 File Offset: 0x0104B9C0
			internal static bool C7KYdipB3lNm4oKiOUKg()
			{
				return false;
			}

			// Token: 0x04007E66 RID: 32358
			internal StoryGui $mStoryGui$38947;

			// Token: 0x04007E67 RID: 32359
			internal ChangeGui $mChangeGui$38948;

			// Token: 0x04007E68 RID: 32360
			internal GameGui $mGameGui$38949;

			// Token: 0x04007E69 RID: 32361
			internal M406_WindValley $self_$38950;
		}
	}

	// Token: 0x02001556 RID: 5462
	[CompilerGenerated]
	[Serializable]
	internal sealed class $onGameComplete$38952 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06007E90 RID: 32400 RVA: 0x0104D7C4 File Offset: 0x0104B9C4
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $onGameComplete$38952(Hashtable data, M406_WindValley self_)
		{
			if (30944 - 281494 != -250550)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (86442 - 253481 != -167038)
				{
					base..ctor();
					if (7107 - 194231 == -187124)
					{
						this.$data$38958 = data;
						if (15553 - 337088 != -321534)
						{
							this.$self_$38959 = self_;
							if (263666 - 452814 != -189147)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x06007E91 RID: 32401 RVA: 0x0104D880 File Offset: 0x0104BA80
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M406_WindValley.$onGameComplete$38952.$(this.$data$38958, this.$self_$38959);
		}

		// Token: 0x06007E92 RID: 32402 RVA: 0x0104D894 File Offset: 0x0104BA94
		internal static bool pMcfe3pBXtDq2UPa4TUh()
		{
			return true;
		}

		// Token: 0x06007E93 RID: 32403 RVA: 0x0104D898 File Offset: 0x0104BA98
		internal static bool m4p5kWpBQRIbj0coYMPp()
		{
			return false;
		}

		// Token: 0x04007E6A RID: 32362
		internal Hashtable $data$38958;

		// Token: 0x04007E6B RID: 32363
		internal M406_WindValley $self_$38959;

		// Token: 0x02001557 RID: 5463
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06007E94 RID: 32404 RVA: 0x0104D89C File Offset: 0x0104BA9C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Hashtable data, M406_WindValley self_)
			{
				if (197936 - 140802 != 57135)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (102987 - 454135 == -351148)
					{
						base..ctor();
						if (297139 - 386725 != -89585)
						{
							this.$data$38956 = data;
							if (9861 - 332461 != -322599)
							{
								this.$self_$38957 = self_;
								if (81287 - 66933 != 14355)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x06007E95 RID: 32405 RVA: 0x0104D958 File Offset: 0x0104BB58
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (254993 - 211181 != 43813)
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
						this.$mCompleteGui$38954 = (CompleteGui)this.$self_$38957.GetComponent(typeof(CompleteGui));
						if (7616 - 326616 == -318999)
						{
							continue;
						}
						this.$mCompleteGui$38954.Init();
						if (94358 - 394657 != -300299)
						{
							continue;
						}
						this.$mCompleteGui$38954.readData(this.$data$38956);
						if (129778 - 59164 != 70614)
						{
							continue;
						}
						if (this.$result$38953 == 1)
						{
							if (258223 - 153599 != 104624)
							{
								continue;
							}
							this.$mCompleteGui$38954.displayResult(eCompleteType.Success);
							if (161084 - 361217 != -200133)
							{
								continue;
							}
						}
						else
						{
							this.$mCompleteGui$38954.displayResult(eCompleteType.Failed);
							if (95781 - 267447 != -171666)
							{
								continue;
							}
						}
						this.$mGameGui$38955 = (GameGui)this.$self_$38957.GetComponent(typeof(GameGui));
						if (128053 - 527264 == -399210)
						{
							continue;
						}
						if (this.$mGameGui$38955)
						{
							if (204362 - 558088 == -353725)
							{
								continue;
							}
							this.$mGameGui$38955.close();
							if (52071 - 370737 != -318666)
							{
								continue;
							}
						}
						this.YieldDefault(1);
						if (187386 - 475868 != -288482)
						{
							continue;
						}
						goto IL_28E;
					default:
						if (106955 - 155067 != -48112)
						{
							continue;
						}
						break;
					}
					if (Game.mGameState > eGameState.AllHold)
					{
						if (243291 - 416861 == -173570)
						{
							break;
						}
					}
					else
					{
						Game.mGameState = eGameState.Complete;
						if (111850 - 184167 == -72317)
						{
							this.$result$38953 = RuntimeServices.UnboxInt32(this.$data$38956[31]);
							if (131834 - 449956 != -318121)
							{
								goto Block_15;
							}
						}
					}
				}
				goto IL_28E;
				Block_15:
				return this.Yield(2, new WaitForSeconds(1f));
				IL_28E:
				return false;
			}

			// Token: 0x06007E96 RID: 32406 RVA: 0x0104DC08 File Offset: 0x0104BE08
			internal static bool fb5p6spBkciTLGKdYHHI()
			{
				return true;
			}

			// Token: 0x06007E97 RID: 32407 RVA: 0x0104DC0C File Offset: 0x0104BE0C
			internal static bool hS4mJXpBGDcrGSc30PN2()
			{
				return false;
			}

			// Token: 0x04007E6C RID: 32364
			internal int $result$38953;

			// Token: 0x04007E6D RID: 32365
			internal CompleteGui $mCompleteGui$38954;

			// Token: 0x04007E6E RID: 32366
			internal GameGui $mGameGui$38955;

			// Token: 0x04007E6F RID: 32367
			internal Hashtable $data$38956;

			// Token: 0x04007E70 RID: 32368
			internal M406_WindValley $self_$38957;
		}
	}

	// Token: 0x02001558 RID: 5464
	[CompilerGenerated]
	[Serializable]
	internal sealed class $ReturnToTown$38960 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06007E98 RID: 32408 RVA: 0x0104DC10 File Offset: 0x0104BE10
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $ReturnToTown$38960(M406_WindValley self_)
		{
			if (190610 - 51628 != 138983)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (55472 - 426929 == -371457)
				{
					base..ctor();
					if (260844 - 151285 == 109559)
					{
						this.$self_$38964 = self_;
						if (168463 - 530673 == -362210)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x06007E99 RID: 32409 RVA: 0x0104DCA8 File Offset: 0x0104BEA8
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M406_WindValley.$ReturnToTown$38960.$(this.$self_$38964);
		}

		// Token: 0x06007E9A RID: 32410 RVA: 0x0104DCB8 File Offset: 0x0104BEB8
		internal static bool Nly5CLpBHuyoM6c8tmia()
		{
			return true;
		}

		// Token: 0x06007E9B RID: 32411 RVA: 0x0104DCBC File Offset: 0x0104BEBC
		internal static bool csBJtWpBWpCbo9f5IOCU()
		{
			return false;
		}

		// Token: 0x04007E71 RID: 32369
		internal M406_WindValley $self_$38964;

		// Token: 0x02001559 RID: 5465
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06007E9C RID: 32412 RVA: 0x0104DCC0 File Offset: 0x0104BEC0
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M406_WindValley self_)
			{
				if (168632 - 448801 != -280168)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (84865 - 575441 == -490576)
					{
						base..ctor();
						if (113457 - 262762 == -149305)
						{
							this.$self_$38963 = self_;
							if (35925 - 578663 == -542738)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x06007E9D RID: 32413 RVA: 0x0104DD58 File Offset: 0x0104BF58
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (204638 - 225389 != -20751)
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
						this.$self_$38963.LeaveGame();
						if (196541 - 595272 == -398730)
						{
							continue;
						}
						this.YieldDefault(1);
						if (227424 - 516089 != -288665)
						{
							continue;
						}
						goto IL_3AD;
					default:
						if (206631 - 73360 != 133271)
						{
							continue;
						}
						break;
					}
					Game.mGameState = eGameState.Ended;
					if (85125 - 230230 != -145104)
					{
						Game.mStateTime = Time.time;
						if (297274 - 398811 != -101536)
						{
							this.$$switch$6816$38961 = PlayerData.SaveGuild;
							if (57138 - 396060 != -338921)
							{
								if (this.$$switch$6816$38961 == 1)
								{
									if (88694 - 251730 == -163035)
									{
										continue;
									}
									Game.mNextGameCode = 32;
									if (147726 - 170256 == -22529)
									{
										continue;
									}
								}
								else if (this.$$switch$6816$38961 == 2)
								{
									if (155188 - 302336 == -147147)
									{
										continue;
									}
									Game.mNextGameCode = 33;
									if (221936 - 192663 != 29273)
									{
										continue;
									}
								}
								else if (this.$$switch$6816$38961 == 3)
								{
									if (155797 - 108108 == 47690)
									{
										continue;
									}
									Game.mNextGameCode = 34;
									if (195416 - 426650 != -231234)
									{
										continue;
									}
								}
								else if (this.$$switch$6816$38961 == 4)
								{
									if (236102 - 235511 != 591)
									{
										continue;
									}
									Game.mNextGameCode = 35;
									if (262559 - 530729 != -268170)
									{
										continue;
									}
								}
								else if (this.$$switch$6816$38961 == 5)
								{
									if (191916 - 100682 == 91235)
									{
										continue;
									}
									Game.mNextGameCode = 36;
									if (122822 - 554665 == -431842)
									{
										continue;
									}
								}
								else if (PlayerData.GID == 0)
								{
									if (100294 - 174605 == -74310)
									{
										continue;
									}
									Game.mNextGameCode = 30;
									if (194522 - 220119 != -25597)
									{
										continue;
									}
								}
								else
								{
									Game.mNextGameCode = 31;
									if (211515 - 525874 != -314359)
									{
										continue;
									}
								}
								this.$mGameGui$38962 = (GameGui)this.$self_$38963.GetComponent(typeof(GameGui));
								if (250538 - 339851 == -89313)
								{
									if (this.$mGameGui$38962)
									{
										if (42610 - 396471 != -353861)
										{
											continue;
										}
										this.$mGameGui$38962.close();
										if (191051 - 236870 == -45818)
										{
											continue;
										}
									}
									this.$self_$38963.SendMessage("fadeOut");
									if (123661 - 573021 == -449360)
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

			// Token: 0x06007E9E RID: 32414 RVA: 0x0104E124 File Offset: 0x0104C324
			internal static bool WrEnsbpBASPJ48sXqX2t()
			{
				return true;
			}

			// Token: 0x06007E9F RID: 32415 RVA: 0x0104E128 File Offset: 0x0104C328
			internal static bool IVZlM6pBltUpjgZGUNL2()
			{
				return false;
			}

			// Token: 0x04007E72 RID: 32370
			internal int $$switch$6816$38961;

			// Token: 0x04007E73 RID: 32371
			internal GameGui $mGameGui$38962;

			// Token: 0x04007E74 RID: 32372
			internal M406_WindValley $self_$38963;
		}
	}

	// Token: 0x0200155A RID: 5466
	[CompilerGenerated]
	[Serializable]
	internal sealed class $ReturnToGuild$38965 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06007EA0 RID: 32416 RVA: 0x0104E12C File Offset: 0x0104C32C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $ReturnToGuild$38965(M406_WindValley self_)
		{
			if (270041 - 509305 != -239264)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (117908 - 583767 != -465858)
				{
					base..ctor();
					if (162505 - 12274 != 150232)
					{
						this.$self_$38968 = self_;
						if (85167 - 369781 != -284613)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x06007EA1 RID: 32417 RVA: 0x0104E1C4 File Offset: 0x0104C3C4
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M406_WindValley.$ReturnToGuild$38965.$(this.$self_$38968);
		}

		// Token: 0x06007EA2 RID: 32418 RVA: 0x0104E1D4 File Offset: 0x0104C3D4
		internal static bool lTvPJ0pBy0OElRWBs3XG()
		{
			return true;
		}

		// Token: 0x06007EA3 RID: 32419 RVA: 0x0104E1D8 File Offset: 0x0104C3D8
		internal static bool k0iy2ypBSq3awa95XRZO()
		{
			return false;
		}

		// Token: 0x04007E75 RID: 32373
		internal M406_WindValley $self_$38968;

		// Token: 0x0200155B RID: 5467
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06007EA4 RID: 32420 RVA: 0x0104E1DC File Offset: 0x0104C3DC
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M406_WindValley self_)
			{
				if (88814 - 431118 != -342303)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (118932 - 229629 != -110696)
					{
						base..ctor();
						if (92974 - 457330 != -364355)
						{
							this.$self_$38967 = self_;
							if (97745 - 398167 != -300421)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x06007EA5 RID: 32421 RVA: 0x0104E274 File Offset: 0x0104C474
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (283479 - 82782 != 200698)
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
						this.$self_$38967.LeaveGame();
						if (43870 - 498642 == -454771)
						{
							continue;
						}
						this.YieldDefault(1);
						if (174778 - 480379 != -305600)
						{
							goto Block_9;
						}
						continue;
					default:
						if (108631 - 351500 == -242868)
						{
							continue;
						}
						break;
					}
					Game.mGameState = eGameState.Ended;
					if (34741 - 504249 != -469507)
					{
						Game.mStateTime = Time.time;
						if (254867 - 557872 == -303005)
						{
							Game.mNextGameCode = 31;
							if (3261 - 146993 != -143731)
							{
								this.$mGameGui$38966 = (GameGui)this.$self_$38967.GetComponent(typeof(GameGui));
								if (287815 - 422464 == -134649)
								{
									if (this.$mGameGui$38966)
									{
										if (202343 - 319773 == -117429)
										{
											continue;
										}
										this.$mGameGui$38966.close();
										if (68550 - 459287 == -390736)
										{
											continue;
										}
									}
									this.$self_$38967.SendMessage("fadeOut");
									if (247872 - 40887 != 206986)
									{
										break;
									}
								}
							}
						}
					}
				}
				return this.Yield(2, new WaitForSeconds((float)1));
				Block_9:
				IL_1BD:
				return false;
			}

			// Token: 0x06007EA6 RID: 32422 RVA: 0x0104E450 File Offset: 0x0104C650
			internal static bool GuKlvLpBoIyOHJT8QlCh()
			{
				return true;
			}

			// Token: 0x06007EA7 RID: 32423 RVA: 0x0104E454 File Offset: 0x0104C654
			internal static bool wI6EqPpBEmtGntIygQG3()
			{
				return false;
			}

			// Token: 0x04007E76 RID: 32374
			internal GameGui $mGameGui$38966;

			// Token: 0x04007E77 RID: 32375
			internal M406_WindValley $self_$38967;
		}
	}

	// Token: 0x0200155C RID: 5468
	[CompilerGenerated]
	[Serializable]
	internal sealed class $ReturnToCamp$38969 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06007EA8 RID: 32424 RVA: 0x0104E458 File Offset: 0x0104C658
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $ReturnToCamp$38969(M406_WindValley self_)
		{
			if (33219 - 225546 != -192326)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (226956 - 62320 != 164637)
				{
					base..ctor();
					if (11920 - 338422 == -326502)
					{
						this.$self_$38973 = self_;
						if (209977 - 542735 != -332757)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x06007EA9 RID: 32425 RVA: 0x0104E4F0 File Offset: 0x0104C6F0
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M406_WindValley.$ReturnToCamp$38969.$(this.$self_$38973);
		}

		// Token: 0x06007EAA RID: 32426 RVA: 0x0104E500 File Offset: 0x0104C700
		internal static bool gsmSeIpB2fNn0bWTOg23()
		{
			return true;
		}

		// Token: 0x06007EAB RID: 32427 RVA: 0x0104E504 File Offset: 0x0104C704
		internal static bool BNe058pB8bNKDpCRG8SF()
		{
			return false;
		}

		// Token: 0x04007E78 RID: 32376
		internal M406_WindValley $self_$38973;

		// Token: 0x0200155D RID: 5469
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06007EAC RID: 32428 RVA: 0x0104E508 File Offset: 0x0104C708
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M406_WindValley self_)
			{
				if (132095 - 327230 != -195135)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (95768 - 536354 != -440585)
					{
						base..ctor();
						if (113573 - 576870 == -463297)
						{
							this.$self_$38972 = self_;
							if (170601 - 382452 == -211851)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x06007EAD RID: 32429 RVA: 0x0104E5A0 File Offset: 0x0104C7A0
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (120487 - 215573 != -95085)
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
						this.$self_$38972.LeaveGame();
						if (164818 - 140574 != 24244)
						{
							continue;
						}
						this.YieldDefault(1);
						if (235985 - 256353 != -20368)
						{
							continue;
						}
						goto IL_363;
					default:
						if (115360 - 305878 != -190518)
						{
							continue;
						}
						break;
					}
					Game.mGameState = eGameState.Ended;
					if (58687 - 502596 != -443908)
					{
						Game.mStateTime = Time.time;
						if (270413 - 280542 != -10128)
						{
							this.$$switch$6818$38970 = PlayerData.SaveGuild;
							if (33329 - 591260 != -557930)
							{
								if (this.$$switch$6818$38970 == 1)
								{
									if (83533 - 518796 == -435262)
									{
										continue;
									}
									Game.mNextGameCode = 32;
									if (145339 - 282260 == -136920)
									{
										continue;
									}
								}
								else if (this.$$switch$6818$38970 == 2)
								{
									if (263445 - 418049 == -154603)
									{
										continue;
									}
									Game.mNextGameCode = 33;
									if (281306 - 234494 != 46812)
									{
										continue;
									}
								}
								else if (this.$$switch$6818$38970 == 3)
								{
									if (29908 - 324442 == -294533)
									{
										continue;
									}
									Game.mNextGameCode = 34;
									if (111690 - 252232 != -140542)
									{
										continue;
									}
								}
								else if (this.$$switch$6818$38970 == 4)
								{
									if (297634 - 512002 != -214368)
									{
										continue;
									}
									Game.mNextGameCode = 35;
									if (154460 - 386930 == -232469)
									{
										continue;
									}
								}
								else if (this.$$switch$6818$38970 == 5)
								{
									if (272539 - 56906 != 215633)
									{
										continue;
									}
									Game.mNextGameCode = 36;
									if (179691 - 589779 == -410087)
									{
										continue;
									}
								}
								else
								{
									Game.mNextGameCode = 30;
									if (119886 - 187068 != -67182)
									{
										continue;
									}
								}
								this.$mGameGui$38971 = (GameGui)this.$self_$38972.GetComponent(typeof(GameGui));
								if (290934 - 570897 == -279963)
								{
									if (this.$mGameGui$38971)
									{
										if (34288 - 584512 == -550223)
										{
											continue;
										}
										this.$mGameGui$38971.close();
										if (115434 - 250688 != -135254)
										{
											continue;
										}
									}
									this.$self_$38972.SendMessage("fadeOut");
									if (30860 - 267130 == -236270)
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

			// Token: 0x06007EAE RID: 32430 RVA: 0x0104E924 File Offset: 0x0104CB24
			internal static bool D4NX0hpBZCo4yo1ubSZJ()
			{
				return true;
			}

			// Token: 0x06007EAF RID: 32431 RVA: 0x0104E928 File Offset: 0x0104CB28
			internal static bool KLklZypBCPMep1wCuWsy()
			{
				return false;
			}

			// Token: 0x04007E79 RID: 32377
			internal int $$switch$6818$38970;

			// Token: 0x04007E7A RID: 32378
			internal GameGui $mGameGui$38971;

			// Token: 0x04007E7B RID: 32379
			internal M406_WindValley $self_$38972;
		}
	}
}
