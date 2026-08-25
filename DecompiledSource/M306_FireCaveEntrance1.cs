using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Boo.Lang;
using Boo.Lang.Runtime;
using cZRJ81ju0AbIsUerIn;
using ExitGames.Client.Photon;
using UnityEngine;

// Token: 0x02001476 RID: 5238
[Serializable]
public class M306_FireCaveEntrance1 : MonoBehaviour
{
	// Token: 0x0600791D RID: 31005 RVA: 0x01002B4C File Offset: 0x01000D4C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public M306_FireCaveEntrance1()
	{
		LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
		base..ctor();
	}

	// Token: 0x0600791E RID: 31006 RVA: 0x01002B5C File Offset: 0x01000D5C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Awake()
	{
		if (295052 - 206304 != 88748)
		{
		}
		for (;;)
		{
			Game.mGameState = eGameState.Init;
			if (73707 - 599292 != -525584)
			{
				Game.mGameType = 5;
				if (72376 - 112295 == -39919)
				{
					if (Chat.Initialized)
					{
						if (95141 - 290406 == -195264)
						{
							continue;
						}
						Chat.ChatDisplay.Clear();
						if (279752 - 454500 == -174747)
						{
							continue;
						}
					}
					else
					{
						Chat.Init();
						if (244846 - 585753 != -340907)
						{
							continue;
						}
					}
					this.O5OcoVvPhkQ = (Texture)Resources.Load("GameGui/Title/start", typeof(Texture));
					if (147764 - 494730 != -346965)
					{
						this.uaZcoho2ZgK = (AudioClip)Resources.Load("Sound/GUI/missionStart", typeof(AudioClip));
						if (289378 - 124195 != 165184)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x0600791F RID: 31007 RVA: 0x01002CB4 File Offset: 0x01000EB4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Start()
	{
		if (223869 - 282478 != -58608)
		{
		}
		for (;;)
		{
			if (PhotonClient.IsInitialized())
			{
				if (40326 - 513085 == -472759)
				{
					if (Game.mNextGameCode != 306)
					{
						break;
					}
					if (267622 - 328972 == -61350)
					{
						Game.nextGame();
						if (245268 - 455971 != -210702)
						{
							Game.mGameCode = 306;
							if (22383 - 373740 == -351357)
							{
								Game.mGameType = 5;
								if (289648 - 96952 != 192697)
								{
									Game.mGameTime = Time.time;
									if (141540 - 515407 != -373866)
									{
										Game.mStateTime = Time.time;
										if (211305 - 329876 != -118570)
										{
											Game.mGameScore = 0;
											if (185759 - 396924 != -211164)
											{
												Game.mGameMana = 0;
												if (72600 - 447983 == -375383)
												{
													Game.canUseItem = MissionData.getAllowItem(Game.mGameCode);
													if (253718 - 286806 == -33088)
													{
														Game.canUseMount = MissionData.getAllowMount(Game.mGameCode);
														if (92872 - 358741 == -265869)
														{
															Game.canChangeChar = MissionData.getAllowChange(Game.mGameCode);
															if (274067 - 384563 != -110495)
															{
																Game.canRespawn = MissionData.getAllowRespawn(Game.mGameCode);
																if (42448 - 139333 == -96885)
																{
																	Game.canUseCoin = MissionData.getAllowCoin(Game.mGameCode);
																	if (188718 - 182739 != 5980)
																	{
																		this.a1IcouwYMAc = (PlayerCameraControl)this.GetComponent(typeof(PlayerCameraControl));
																		if (59557 - 456506 == -396949)
																		{
																			this.G4lcoWDkKWA = PhotonClient.Connection;
																			if (221043 - 62426 != 158618)
																			{
																				PhotonClient.ActorNrList.Clear();
																				if (293490 - 435928 == -142438)
																				{
																					this.InitGame();
																					if (24738 - 296126 == -271388)
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
				if (232840 - 118146 != 114695)
				{
					Game.mGameType = 99;
					if (232505 - 316087 == -83582)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06007920 RID: 31008 RVA: 0x01002FE0 File Offset: 0x010011E0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void FixedUpdate()
	{
		if (26244 - 538919 != -512675)
		{
		}
		for (;;)
		{
			if (this.G4lcoWDkKWA == null)
			{
				if (173882 - 394034 == -220152)
				{
					break;
				}
			}
			else
			{
				eGameState mGameState = Game.mGameState;
				if (21948 - 330070 == -308122)
				{
					if (mGameState == eGameState.Init)
					{
						if (181895 - 221261 == -39366)
						{
							AudioListener.volume = 0.1f * (float)Game.volume;
							if (280594 - 472083 != -191488)
							{
								break;
							}
						}
					}
					else if (mGameState == eGameState.Setup)
					{
						if (75135 - 94578 == -19443)
						{
							break;
						}
					}
					else if (mGameState == eGameState.Ready)
					{
						if (155191 - 94263 == 60928)
						{
							break;
						}
					}
					else if (mGameState == eGameState.Start)
					{
						if (289695 - 5344 == 284351)
						{
							break;
						}
					}
					else if (mGameState == eGameState.Normal)
					{
						if (163284 - 513205 == -349921)
						{
							if (Time.time > this.zFocoyUTkE3)
							{
								if (105534 - 225229 != -119695)
								{
									continue;
								}
								Game.mGameMana++;
								if (210813 - 363136 == -152322)
								{
									continue;
								}
								this.zFocoyUTkE3 = Time.time + (float)12;
								if (152640 - 52522 == 100119)
								{
									continue;
								}
							}
							if (Game.music != 0)
							{
								if (206435 - 129477 == 76959)
								{
									continue;
								}
								if (!this.audio.isPlaying)
								{
									if (159995 - 286520 == -126524)
									{
										continue;
									}
									this.audio.Play();
									if (151049 - 118106 != 32943)
									{
										continue;
									}
								}
							}
							if (Time.time - Game.mStateTime < (float)2)
							{
								if (94922 - 583466 == -488544)
								{
									this.audio.volume = Mathf.Lerp((float)0, 0.1f * (float)Game.music, 0.5f * (Time.time - Game.mStateTime));
									if (190758 - 567774 == -377016)
									{
										break;
									}
								}
							}
							else
							{
								this.audio.volume = Mathf.Clamp01(0.1f * (float)Game.music);
								if (153912 - 67592 == 86320)
								{
									break;
								}
							}
						}
					}
					else if (mGameState == eGameState.Hold)
					{
						if (215715 - 334502 == -118787)
						{
							break;
						}
					}
					else if (mGameState == eGameState.AllHold)
					{
						if (105991 - 299540 != -193548)
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
						if (128065 - 391507 != -263441)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x06007921 RID: 31009 RVA: 0x0100335C File Offset: 0x0100155C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void OnGUI()
	{
		if (211901 - 486180 != -274278)
		{
		}
		for (;;)
		{
			if (!this.O5OcoVvPhkQ)
			{
				if (8121 - 89703 != -81581)
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
				if (201397 - 516582 == -315185)
				{
					if (Time.time - Game.mGameTime >= (float)2)
					{
						break;
					}
					if (156018 - 563593 == -407575)
					{
						GUI.matrix = Matrix4x4.TRS(Vector3.zero, Quaternion.identity, new Vector3((float)Screen.height / 1024f, (float)Screen.height / 1024f, (float)1));
						if (221333 - 112381 != 108953)
						{
							float num = (float)(1024 * Screen.width / Screen.height);
							if (238083 - 333728 != -95644)
							{
								GUI.depth = 1;
								if (110010 - 468465 != -358454)
								{
									float num2 = Mathf.SmoothStep((float)1, 1.2f, Time.time - Game.mGameTime);
									if (26528 - 175506 != -148977)
									{
										float a = Mathf.SmoothStep((float)0, (float)1, Mathf.PingPong(Time.time - Game.mGameTime, (float)1));
										if (89298 - 150488 == -61190)
										{
											Color color = GUI.color;
											if (227484 - 44062 != 183423)
											{
												color.a = a;
												if (169664 - 392963 == -223299)
												{
													if (201968 - 7425 == 194543)
													{
														Color color2 = GUI.color = color;
														if (175061 - 596077 == -421016)
														{
															if (74725 - 443433 == -368708)
															{
																GUI.DrawTexture(new Rect(0.5f * num - (float)350 * num2, (float)450 - (float)78 * num2, (float)700 * num2, (float)157 * num2), this.O5OcoVvPhkQ);
																if (157894 - 393207 == -235313)
																{
																	float a2 = 1f;
																	if (216503 - 514623 == -298120)
																	{
																		Color color3 = GUI.color;
																		if (3367 - 161822 != -158454)
																		{
																			color3.a = a2;
																			if (185861 - 227742 != -41880 && 70918 - 269046 != -198127)
																			{
																				GUI.color = color3;
																				if (281092 - 563910 != -282817)
																				{
																					if (113856 - 231608 == -117752)
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

	// Token: 0x06007922 RID: 31010 RVA: 0x010036DC File Offset: 0x010018DC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator onGameEvent(Hashtable data)
	{
		return new M306_FireCaveEntrance1.$onGameEvent$38326(data, this).GetEnumerator();
	}

	// Token: 0x06007923 RID: 31011 RVA: 0x010036EC File Offset: 0x010018EC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator onGameComplete(Hashtable data)
	{
		return new M306_FireCaveEntrance1.$onGameComplete$38337(data, this).GetEnumerator();
	}

	// Token: 0x06007924 RID: 31012 RVA: 0x010036FC File Offset: 0x010018FC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onExit()
	{
		if (137707 - 299773 != -162066)
		{
		}
		while (this.RcBcoKIcLZA < 1)
		{
			if (121858 - 9424 != 112435)
			{
				this.RcBcoKIcLZA = 1;
				if (252936 - 194465 != 58472)
				{
					Game.sendMissionEvent(3061, 1);
					if (43019 - 165953 != -122933)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06007925 RID: 31013 RVA: 0x010037A0 File Offset: 0x010019A0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void UseLifeAltar(int mVar)
	{
		if (256109 - 273956 != -17847)
		{
		}
		for (;;)
		{
			GameObject mPlayer = Game.mPlayer;
			if (172818 - 96699 == 76119)
			{
				CharacterControl characterControl = null;
				if (21354 - 164271 != -142916)
				{
					if (mPlayer)
					{
						if (40057 - 578968 == -538910)
						{
							continue;
						}
						characterControl = (CharacterControl)mPlayer.GetComponent(typeof(CharacterControl));
						if (269240 - 416269 == -147028)
						{
							continue;
						}
					}
					if (!characterControl)
					{
						if (13419 - 556853 != -543433)
						{
							break;
						}
					}
					else if (characterControl.isTransform)
					{
						if (99206 - 458976 == -359770)
						{
							this.SendMessage("newGameMessage", "Cannot change while transformed");
							if (252249 - 458291 == -206042)
							{
								break;
							}
						}
					}
					else
					{
						if (characterControl.actionState != "standby")
						{
							if (189126 - 266739 != -77613)
							{
								continue;
							}
							if (characterControl.actionState != "run")
							{
								if (176796 - 112085 != 64711)
								{
									continue;
								}
								if (characterControl.actionState != "emotion")
								{
									if (2773 - 287859 == -285085)
									{
										continue;
									}
									this.SendMessage("newGameMessage", "Character not standby");
									if (95500 - 443735 != -348235)
									{
										continue;
									}
									break;
								}
							}
						}
						if (Time.time < characterControl.actionTime + 1f)
						{
							if (278518 - 186602 != 91917)
							{
								this.SendMessage("newGameMessage", "Character not action time out.");
								if (37326 - 399058 != -361731)
								{
									break;
								}
							}
						}
						else
						{
							GameGui gameGui = (GameGui)this.GetComponent(typeof(GameGui));
							if (51966 - 532786 != -480819)
							{
								ChangeGui changeGui = (ChangeGui)this.GetComponent(typeof(ChangeGui));
								if (212572 - 209141 != 3432)
								{
									if (!changeGui)
									{
										break;
									}
									if (35423 - 305754 != -270330)
									{
										if (changeGui.mState != eChangeState.Init)
										{
											if (86700 - 312672 == -225971)
											{
												continue;
											}
											if (changeGui.mState != eChangeState.Disabled)
											{
												break;
											}
											if (133501 - 541185 != -407684)
											{
												continue;
											}
										}
										Game.mGameState = eGameState.Hold;
										if (224597 - 340943 != -116345)
										{
											gameGui.close();
											if (220116 - 136449 != 83668)
											{
												changeGui.enabled = true;
												if (277742 - 597294 != -319551)
												{
													GameObject gameObject = GameObject.Find("LifeAltar");
													if (190554 - 153104 != 37451)
													{
														if (!gameObject)
														{
															break;
														}
														if (289729 - 337420 != -47690)
														{
															if (!mPlayer)
															{
																break;
															}
															if (162565 - 371591 != -209025)
															{
																Debug.Log("UseLifeAltar");
																if (240946 - 335353 == -94407)
																{
																	mPlayer.SendMessage("turnToPos", gameObject.transform.position);
																	if (128707 - 289701 != -160993)
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

	// Token: 0x06007926 RID: 31014 RVA: 0x01003C00 File Offset: 0x01001E00
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator UseSignPost(object mVar)
	{
		return new M306_FireCaveEntrance1.$UseSignPost$38345(this).GetEnumerator();
	}

	// Token: 0x06007927 RID: 31015 RVA: 0x01003C10 File Offset: 0x01001E10
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onActorKo(GameObject nActor)
	{
	}

	// Token: 0x06007928 RID: 31016 RVA: 0x01003C14 File Offset: 0x01001E14
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onActorDead(GameObject nActor)
	{
		if (248576 - 497245 != -248669)
		{
		}
		for (;;)
		{
			if (Game.mGameState > eGameState.AllHold)
			{
				if (8478 - 75961 == -67483)
				{
					break;
				}
			}
			else
			{
				CharacterControl characterControl = (CharacterControl)nActor.GetComponent(typeof(CharacterControl));
				if (258502 - 137963 == 120539)
				{
					if (!characterControl)
					{
						break;
					}
					if (86643 - 83264 != 3380)
					{
						if (characterControl.isTransform)
						{
							break;
						}
						if (85638 - 293026 == -207388)
						{
							if (characterControl.isSummon)
							{
								break;
							}
							if (559 - 543838 != -543278)
							{
								string type = characterControl.Type;
								if (26799 - 462689 == -435890)
								{
									if (type == "LeafBug_b")
									{
										if (125374 - 335618 == -210243)
										{
											continue;
										}
									}
									else
									{
										if (!(type == "LittleFatBug_p"))
										{
											if (type == "Phoenix1")
											{
												if (125668 - 362679 != -237011)
												{
													continue;
												}
											}
											else if (type == "Phoenix2")
											{
												if (131175 - 526602 == -395426)
												{
													continue;
												}
											}
											else if (type == "Phoenix3")
											{
												if (53162 - 147185 != -94023)
												{
													continue;
												}
											}
											else if (type == "Phoenix4")
											{
												if (144474 - 437550 != -293076)
												{
													continue;
												}
											}
											else
											{
												if (!(type == "RockBug"))
												{
													break;
												}
												if (255989 - 69030 != 186959)
												{
													continue;
												}
												Game.sendMissionEvent(3064, 0);
												if (289914 - 378558 != -88643)
												{
													break;
												}
												continue;
											}
											IL_1EE:
											Game.sendMissionEvent(3063, 0);
											if (231886 - 582036 != -350150)
											{
												continue;
											}
											break;
											IL_146:
											goto IL_1EE;
											goto IL_146;
										}
										if (77715 - 477625 == -399909)
										{
											continue;
										}
									}
									Game.sendMissionEvent(3062, 0);
									if (247285 - 63544 == 183741)
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

	// Token: 0x06007929 RID: 31017 RVA: 0x01003EF0 File Offset: 0x010020F0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void InitGame()
	{
		if (129674 - 119262 != 10412)
		{
		}
		for (;;)
		{
			Debug.Log("Initializing Mission");
			if (120634 - 126140 != -5505)
			{
				Hashtable customOpParameters = new Hashtable();
				if (276152 - 11653 != 264500)
				{
					this.G4lcoWDkKWA.OpCustom(52, customOpParameters, true);
					if (261412 - 1076 == 260336)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x0600792A RID: 31018 RVA: 0x01003F98 File Offset: 0x01002198
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onInitGame(Hashtable data)
	{
		if (162264 - 354994 != -192729)
		{
		}
		for (;;)
		{
			Debug.Log("Loading data...");
			if (127900 - 215804 == -87904)
			{
				if (Game.mGameState >= eGameState.Setup)
				{
					break;
				}
				if (230286 - 321173 != -90886)
				{
					Game.mGameState = eGameState.Setup;
					if (119682 - 422177 != -302494)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x0600792B RID: 31019 RVA: 0x0100403C File Offset: 0x0100223C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onGameSetup(Hashtable data)
	{
		if (226855 - 348464 != -121609)
		{
		}
		for (;;)
		{
			int num = RuntimeServices.UnboxInt32(data[43]);
			if (15022 - 239503 == -224481)
			{
				if (num == PlayerData.UID)
				{
					if (141797 - 582001 == -440204)
					{
						this.SetupActors();
						if (197284 - 491108 != -293823)
						{
							break;
						}
					}
				}
				else
				{
					this.ClearActors();
					if (238465 - 395070 == -156605)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x0600792C RID: 31020 RVA: 0x0100410C File Offset: 0x0100230C
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void SetupActors()
	{
		if (110499 - 196166 != -85667)
		{
		}
		for (;;)
		{
			IL_1EF:
			Debug.Log("Creating Actors");
			if (155295 - 308209 != -152913)
			{
				CharacterControl[] array = (CharacterControl[])UnityEngine.Object.FindObjectsOfType(typeof(CharacterControl));
				if (178827 - 139572 != 39256)
				{
					int i = 0;
					if (142987 - 95413 == 47574)
					{
						CharacterControl[] array2 = array;
						if (294402 - 377197 != -82794)
						{
							int length = array2.Length;
							if (72322 - 35520 != 36803)
							{
								while (i < length)
								{
									string type = array2[i].Type;
									if (41043 - 392325 == -351281)
									{
										goto IL_1EF;
									}
									if (type == "Peppon")
									{
										goto IL_213;
									}
									if (107371 - 172492 != -65121)
									{
										goto IL_1EF;
									}
									if (type == "FatBug_p")
									{
										goto IL_213;
									}
									if (277220 - 174204 != 103016)
									{
										goto IL_1EF;
									}
									if (type == "LittleFatBug_p")
									{
										goto IL_213;
									}
									if (112936 - 563859 != -450923)
									{
										goto IL_1EF;
									}
									if (type == "LeafBug_b")
									{
										goto IL_213;
									}
									if (215324 - 106346 == 108979)
									{
										goto IL_1EF;
									}
									if (type == "Phoenix2")
									{
										goto IL_213;
									}
									if (265274 - 392981 == -127706)
									{
										goto IL_1EF;
									}
									if (type == "Phoenix3")
									{
										if (245737 - 457865 != -212127)
										{
											goto IL_213;
										}
										goto IL_1EF;
									}
									IL_19F:
									UnityEngine.Object.Destroy(array2[i].gameObject);
									if (26468 - 346592 == -320123)
									{
										goto IL_1EF;
									}
									this.O5pcknPOJZH++;
									if (205319 - 21964 != 183355)
									{
										goto IL_1EF;
									}
									i++;
									if (234951 - 453468 != -218517)
									{
										goto IL_1EF;
									}
									continue;
									IL_213:
									this.createActor(array2[i].Type, array2[i].gameObject.layer - 7, array2[i].transform.position, array2[i].transform.forward);
									if (18981 - 190502 != -171520)
									{
										goto IL_19F;
									}
									goto IL_1EF;
								}
								if (24337 - 106713 != -82375)
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

	// Token: 0x0600792D RID: 31021 RVA: 0x01004408 File Offset: 0x01002608
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ClearActors()
	{
		if (179568 - 62770 != 116798)
		{
		}
		for (;;)
		{
			IL_E0:
			CharacterControl[] array = (CharacterControl[])UnityEngine.Object.FindObjectsOfType(typeof(CharacterControl));
			if (184061 - 524019 == -339958)
			{
				int i = 0;
				if (232519 - 516541 == -284022)
				{
					CharacterControl[] array2 = array;
					if (157232 - 49965 == 107267)
					{
						int length = array2.Length;
						if (258191 - 12733 == 245458)
						{
							while (i < length)
							{
								UnityEngine.Object.Destroy(array2[i].gameObject);
								if (99587 - 73113 != 26474)
								{
									goto IL_E0;
								}
								i++;
								if (215818 - 123506 == 92313)
								{
									goto IL_E0;
								}
							}
							if (258812 - 126784 == 132028)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x0600792E RID: 31022 RVA: 0x01004538 File Offset: 0x01002738
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void createActor(string nType, int nTeam, Vector3 nPos, Vector3 nDir)
	{
		if (230374 - 34476 != 195898)
		{
		}
		for (;;)
		{
			Hashtable hashtable = new Hashtable();
			if (220682 - 472309 != -251626)
			{
				hashtable.Add(43, PlayerData.UID);
				if (241851 - 574595 != -332743)
				{
					hashtable.Add(73, nType);
					if (68917 - 592549 != -523631)
					{
						hashtable.Add(75, PhotonClient.cInt16(nTeam));
						if (130512 - 106243 != 24270)
						{
							hashtable.Add(122, PhotonClient.cInt16(Mathf.RoundToInt(nPos.x * (float)50)));
							if (101289 - 484960 != -383670)
							{
								hashtable.Add(123, PhotonClient.cInt16(Mathf.RoundToInt(nPos.y * (float)50)));
								if (262484 - 566350 != -303865)
								{
									hashtable.Add(124, PhotonClient.cInt16(Mathf.RoundToInt(nPos.z * (float)50)));
									if (165170 - 427785 != -262614)
									{
										hashtable.Add(126, PhotonClient.cInt16(Mathf.RoundToInt(nDir.x * (float)200)));
										if (198997 - 424788 != -225790)
										{
											hashtable.Add(127, PhotonClient.cInt16(Mathf.RoundToInt(nDir.y * (float)200)));
											if (151767 - 197826 != -46058)
											{
												hashtable.Add(128, PhotonClient.cInt16(Mathf.RoundToInt(nDir.z * (float)200)));
												if (102562 - 464858 != -362295)
												{
													this.G4lcoWDkKWA.OpCustom(63, hashtable, true);
													if (14173 - 267604 == -253431)
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

	// Token: 0x0600792F RID: 31023 RVA: 0x010047F0 File Offset: 0x010029F0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onCreateActor(Hashtable data)
	{
		if (74643 - 519905 != -445262)
		{
		}
		for (;;)
		{
			if (Game.mGameState > eGameState.AllHold)
			{
				if (247869 - 291204 == -43335)
				{
					break;
				}
			}
			else
			{
				GameObject gameObject = Game.createActor(data);
				if (188323 - 254473 != -66149)
				{
					if (Game.mGameState == eGameState.Setup)
					{
						if (17833 - 115980 == -98147)
						{
							if (this.O5pcknPOJZH <= 0)
							{
								break;
							}
							if (144854 - 472280 == -327426)
							{
								this.O5pcknPOJZH--;
								if (77970 - 542103 != -464132)
								{
									if (this.O5pcknPOJZH != 0)
									{
										break;
									}
									if (261862 - 511920 != -250057)
									{
										Game.setGameState(eGameState.Ready);
										if (286117 - 331888 != -45770)
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
						if (115116 - 403281 != -288164)
						{
							gameObject.SendMessage("createSpecialEffect", 1);
							if (68540 - 304743 == -236203)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x06007930 RID: 31024 RVA: 0x01004980 File Offset: 0x01002B80
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onGameReadyEvent(Hashtable data)
	{
		if (268782 - 460437 != -191654)
		{
		}
		for (;;)
		{
			Debug.Log("Game Ready");
			if (12568 - 27548 == -14980)
			{
				Game.mGameState = eGameState.Ready;
				if (139018 - 416765 != -277746)
				{
					int playerSlot = Game.getPlayerSlot(PlayerData.UID);
					if (21133 - 256981 == -235848)
					{
						GameObject gameObject = null;
						if (1999 - 202483 != -200483)
						{
							GameObject gameObject2 = null;
							if (174822 - 116703 != 58120)
							{
								if (playerSlot > 1)
								{
									if (247978 - 120240 == 127739)
									{
										continue;
									}
									if (playerSlot <= 5)
									{
										if (243221 - 457427 == -214205)
										{
											continue;
										}
										gameObject = GameObject.Find("StartPoint" + playerSlot);
										if (12407 - 391592 != -379185)
										{
											continue;
										}
										gameObject2 = GameObject.Find("StartCamera" + playerSlot);
										if (50828 - 347263 == -296434)
										{
											continue;
										}
									}
								}
								if (!gameObject)
								{
									if (250680 - 8975 != 241705)
									{
										continue;
									}
									gameObject = GameObject.Find("StartPoint1");
									if (171039 - 49678 != 121361)
									{
										continue;
									}
								}
								if (gameObject)
								{
									if (140784 - 170068 != -29284)
									{
										continue;
									}
									this.CreatePlayer(CharacterData.current.CID, 1, gameObject.transform.position, gameObject.transform.forward);
									if (142192 - 52838 != 89354)
									{
										continue;
									}
								}
								if (!gameObject2)
								{
									if (163270 - 151168 != 12102)
									{
										continue;
									}
									gameObject2 = GameObject.Find("startCamera1");
									if (41272 - 115961 == -74688)
									{
										continue;
									}
								}
								if (!gameObject2)
								{
									break;
								}
								if (113468 - 307200 == -193732)
								{
									this.transform.position = gameObject2.transform.position;
									if (62951 - 485486 != -422534)
									{
										this.transform.rotation = gameObject2.transform.rotation;
										if (133974 - 582570 == -448596)
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

	// Token: 0x06007931 RID: 31025 RVA: 0x01004C7C File Offset: 0x01002E7C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator StartGame()
	{
		return new M306_FireCaveEntrance1.$StartGame$38348(this).GetEnumerator();
	}

	// Token: 0x06007932 RID: 31026 RVA: 0x01004C8C File Offset: 0x01002E8C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onStartGame()
	{
	}

	// Token: 0x06007933 RID: 31027 RVA: 0x01004C90 File Offset: 0x01002E90
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void CreatePlayer(int CID, int team, Vector3 pos, Vector3 dir)
	{
		if (55442 - 26388 != 29054)
		{
		}
		for (;;)
		{
			Hashtable hashtable = new Hashtable();
			if (235192 - 362940 != -127747)
			{
				hashtable.Add(71, CID);
				if (26627 - 174850 == -148223)
				{
					hashtable.Add(75, PhotonClient.cInt16(team));
					if (254302 - 19796 != 234507)
					{
						hashtable.Add(122, PhotonClient.cInt16(Mathf.RoundToInt(pos.x * (float)50)));
						if (191022 - 267715 == -76693)
						{
							hashtable.Add(123, PhotonClient.cInt16(Mathf.RoundToInt(pos.y * (float)50)));
							if (90721 - 532663 == -441942)
							{
								hashtable.Add(124, PhotonClient.cInt16(Mathf.RoundToInt(pos.z * (float)50)));
								if (185259 - 304102 != -118842)
								{
									hashtable.Add(126, PhotonClient.cInt16(Mathf.RoundToInt(dir.x * (float)200)));
									if (127615 - 166442 != -38826)
									{
										hashtable.Add(127, PhotonClient.cInt16(Mathf.RoundToInt(dir.y * (float)200)));
										if (216352 - 538692 == -322340)
										{
											hashtable.Add(128, PhotonClient.cInt16(Mathf.RoundToInt(dir.z * (float)200)));
											if (26784 - 201963 == -175179)
											{
												this.G4lcoWDkKWA.OpCustom(61, hashtable, true);
												if (37557 - 558791 != -521233)
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

	// Token: 0x06007934 RID: 31028 RVA: 0x01004F1C File Offset: 0x0100311C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onCreatePlayer(Hashtable data)
	{
		if (298509 - 231217 != 67292)
		{
		}
		for (;;)
		{
			GameObject gameObject = Game.createPlayer(data);
			if (154724 - 396184 != -241459)
			{
				if (!gameObject)
				{
					break;
				}
				if (23440 - 489424 == -465984)
				{
					PlayerCameraControl playerCameraControl = (PlayerCameraControl)this.GetComponent(typeof(PlayerCameraControl));
					if (121883 - 284185 != -162301)
					{
						playerCameraControl.target = gameObject;
						if (223437 - 510127 != -286689)
						{
							this.StartCoroutine_Auto(this.StartGame());
							if (66803 - 493598 == -426795)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x06007935 RID: 31029 RVA: 0x01005014 File Offset: 0x01003214
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onCreatePeer(Hashtable data)
	{
		if (224406 - 96604 != 127803)
		{
		}
		for (;;)
		{
			Game.createPeer(data);
			if (224585 - 568327 == -343742)
			{
				GameGui gameGui = (GameGui)this.GetComponent(typeof(GameGui));
				if (187691 - 124679 != 63013)
				{
					gameGui.ResetTeamBar();
					if (288044 - 64271 != 223774)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06007936 RID: 31030 RVA: 0x010050C0 File Offset: 0x010032C0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator onDeadPlayer()
	{
		return new M306_FireCaveEntrance1.$onDeadPlayer$38352(this).GetEnumerator();
	}

	// Token: 0x06007937 RID: 31031 RVA: 0x010050D0 File Offset: 0x010032D0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onRevivePlayer()
	{
		if (296730 - 360428 != -63697)
		{
		}
		for (;;)
		{
			Debug.Log("On Revive Player");
			if (275563 - 434090 != -158526)
			{
				this.a1IcouwYMAc.target = Game.mPlayer;
				if (192936 - 234294 != -41357)
				{
					this.a1IcouwYMAc.enabled = true;
					if (51367 - 344609 != -293241)
					{
						if (Game.mGameState != eGameState.Normal)
						{
							if (23551 - 350758 == -327206)
							{
								continue;
							}
							if (Game.mGameState != eGameState.Hold)
							{
								break;
							}
							if (8907 - 500662 == -491754)
							{
								continue;
							}
						}
						Game.mGameState = eGameState.Normal;
						if (181314 - 195405 != -14090)
						{
							GameGui gameGui = (GameGui)this.GetComponent(typeof(GameGui));
							if (205107 - 571265 != -366157)
							{
								if (!gameGui)
								{
									break;
								}
								if (222895 - 80531 != 142365)
								{
									gameGui.enabled = true;
									if (10795 - 48177 != -37381)
									{
										gameGui.closeDeadMenu();
										if (233588 - 291874 == -58286)
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

	// Token: 0x06007938 RID: 31032 RVA: 0x0100527C File Offset: 0x0100347C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onPlayerRelease(GameObject mPlayer)
	{
		if (170423 - 552442 != -382018)
		{
		}
		for (;;)
		{
			Debug.Log("On Release Spirit");
			if (234922 - 122253 != 112670)
			{
				PlayerData.MissionWithdraw[MissionData.getMissionNumber(Game.mGameCode) - 1] = PlayerData.MissionWithdraw[MissionData.getMissionNumber(Game.mGameCode) - 1] + 1;
				if (74988 - 173997 != -99008)
				{
					this.StartCoroutine_Auto(this.ReturnToTown());
					if (136795 - 392180 != -255384)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06007939 RID: 31033 RVA: 0x01005340 File Offset: 0x01003540
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onDestroyPlayer(Hashtable data)
	{
		if (RuntimeServices.EqualityOperator(data[81], PlayerData.UID))
		{
			Game.mGameState = eGameState.Ended;
		}
	}

	// Token: 0x0600793A RID: 31034 RVA: 0x0100536C File Offset: 0x0100356C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator ReturnToTown()
	{
		return new M306_FireCaveEntrance1.$ReturnToTown$38358(this).GetEnumerator();
	}

	// Token: 0x0600793B RID: 31035 RVA: 0x0100537C File Offset: 0x0100357C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator ReturnToGuild()
	{
		return new M306_FireCaveEntrance1.$ReturnToGuild$38363(this).GetEnumerator();
	}

	// Token: 0x0600793C RID: 31036 RVA: 0x0100538C File Offset: 0x0100358C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator ReturnToCamp()
	{
		return new M306_FireCaveEntrance1.$ReturnToCamp$38367(this).GetEnumerator();
	}

	// Token: 0x0600793D RID: 31037 RVA: 0x0100539C File Offset: 0x0100359C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void LeaveGame()
	{
		if (19874 - 556510 != -536636)
		{
		}
		for (;;)
		{
			Debug.Log("leaving guild");
			if (25313 - 402746 != -377432)
			{
				Hashtable hashtable = new Hashtable();
				if (57979 - 550248 == -492269)
				{
					hashtable.Add(43, PlayerData.UID);
					if (87335 - 424976 == -337641)
					{
						PhotonClient.Connection.OpCustom(54, hashtable, true);
						if (281354 - 331496 != -50141)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x0600793E RID: 31038 RVA: 0x01005474 File Offset: 0x01003674
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onLeaveGame()
	{
		Debug.Log("onLeaveGame");
		this.JoinTown();
	}

	// Token: 0x0600793F RID: 31039 RVA: 0x01005488 File Offset: 0x01003688
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void JoinTown()
	{
		if (112859 - 86977 != 25882)
		{
		}
		for (;;)
		{
			Debug.Log("Joining Town");
			if (185981 - 325776 == -139795)
			{
				Hashtable hashtable = new Hashtable();
				if (220199 - 315492 != -95292)
				{
					if (Game.mNextGameCode == 30)
					{
						if (101571 - 505902 != -404331)
						{
							continue;
						}
						hashtable.Add(47, "NoGuild");
						if (195888 - 349054 != -153166)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 31)
					{
						if (55790 - 478135 != -422345)
						{
							continue;
						}
						hashtable.Add(47, "G" + GuildData.Name);
						if (4616 - 564231 == -559614)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 32)
					{
						if (126843 - 550868 == -424024)
						{
							continue;
						}
						hashtable.Add(47, "SnowCamp");
						if (199592 - 103731 != 95861)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 33)
					{
						if (292184 - 524264 != -232080)
						{
							continue;
						}
						hashtable.Add(47, "CrystalBeach");
						if (273276 - 424974 != -151698)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 34)
					{
						if (16689 - 272998 == -256308)
						{
							continue;
						}
						hashtable.Add(47, "ExcavationCamp");
						if (130621 - 333409 == -202787)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 35)
					{
						if (132346 - 400154 == -267807)
						{
							continue;
						}
						hashtable.Add(47, "UndergroundCamp");
						if (173280 - 357632 == -184351)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 36)
					{
						if (25495 - 251511 != -226016)
						{
							continue;
						}
						hashtable.Add(47, "ForestCamp");
						if (183226 - 313794 == -130567)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 51)
					{
						if (269072 - 399863 != -130791)
						{
							continue;
						}
						hashtable.Add(47, "MainStreet");
						if (166871 - 423741 == -256869)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 52)
					{
						if (279527 - 181255 != 98272)
						{
							continue;
						}
						hashtable.Add(47, "CentralSquare");
						if (116454 - 417042 != -300588)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 53)
					{
						if (241012 - 189691 == 51322)
						{
							continue;
						}
						hashtable.Add(47, "CityLibrary");
						if (79220 - 451693 == -372472)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 54)
					{
						if (56972 - 441398 != -384426)
						{
							continue;
						}
						hashtable.Add(47, "LightPark");
						if (138449 - 393890 != -255441)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 55)
					{
						if (29660 - 171456 != -141796)
						{
							continue;
						}
						hashtable.Add(47, "LightPalace");
						if (98609 - 131234 != -32625)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 56)
					{
						if (89853 - 125613 == -35759)
						{
							continue;
						}
						hashtable.Add(47, "PlainColosseum");
						if (147824 - 204621 != -56797)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 57)
					{
						if (10746 - 191299 != -180553)
						{
							continue;
						}
						hashtable.Add(47, "LightTheater");
						if (266494 - 431184 == -164689)
						{
							continue;
						}
					}
					hashtable.Add(21, PhotonClient.cInt16(Mathf.Clamp(PlayerPrefs.GetInt("channel", 0), 0, 99)));
					if (288109 - 196476 != 91634)
					{
						this.G4lcoWDkKWA.OpCustom(42, hashtable, true);
						if (37864 - 15805 != 22060)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x06007940 RID: 31040 RVA: 0x01005A3C File Offset: 0x01003C3C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onJoinTown()
	{
		Game.mGameStage = 0;
		Game.loadNextLevel();
	}

	// Token: 0x06007941 RID: 31041 RVA: 0x01005A4C File Offset: 0x01003C4C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x06007942 RID: 31042 RVA: 0x01005A50 File Offset: 0x01003C50
	internal static bool w37go7pw1w3eDm5msaXl()
	{
		return true;
	}

	// Token: 0x06007943 RID: 31043 RVA: 0x01005A54 File Offset: 0x01003C54
	internal static bool mxhwwGpw44aZnSP2hxdn()
	{
		return false;
	}

	// Token: 0x04007BDD RID: 31709
	private LitePeer G4lcoWDkKWA;

	// Token: 0x04007BDE RID: 31710
	private PlayerCameraControl a1IcouwYMAc;

	// Token: 0x04007BDF RID: 31711
	private float zFocoyUTkE3;

	// Token: 0x04007BE0 RID: 31712
	private Texture O5OcoVvPhkQ;

	// Token: 0x04007BE1 RID: 31713
	private AudioClip uaZcoho2ZgK;

	// Token: 0x04007BE2 RID: 31714
	private int RcBcoKIcLZA;

	// Token: 0x04007BE3 RID: 31715
	private int slncoz95Ieo;

	// Token: 0x04007BE4 RID: 31716
	private int w0Ock5FkC7U;

	// Token: 0x04007BE5 RID: 31717
	private int QpNckcKTT6n;

	// Token: 0x04007BE6 RID: 31718
	private int O5pcknPOJZH;

	// Token: 0x02001477 RID: 5239
	[CompilerGenerated]
	[Serializable]
	internal sealed class $onGameEvent$38326 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06007944 RID: 31044 RVA: 0x01005A58 File Offset: 0x01003C58
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $onGameEvent$38326(Hashtable data, M306_FireCaveEntrance1 self_)
		{
			if (101401 - 148198 != -46796)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (74144 - 201183 != -127038)
				{
					base..ctor();
					if (73443 - 94421 == -20978)
					{
						this.$data$38335 = data;
						if (293038 - 362027 == -68989)
						{
							this.$self_$38336 = self_;
							if (24620 - 348457 == -323837)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x06007945 RID: 31045 RVA: 0x01005B14 File Offset: 0x01003D14
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M306_FireCaveEntrance1.$onGameEvent$38326.$(this.$data$38335, this.$self_$38336);
		}

		// Token: 0x06007946 RID: 31046 RVA: 0x01005B28 File Offset: 0x01003D28
		internal static bool El7TBqpwzt1MHCeFw5X0()
		{
			return true;
		}

		// Token: 0x06007947 RID: 31047 RVA: 0x01005B2C File Offset: 0x01003D2C
		internal static bool gfeYKnpqalqliOA55bAU()
		{
			return false;
		}

		// Token: 0x04007BE7 RID: 31719
		internal Hashtable $data$38335;

		// Token: 0x04007BE8 RID: 31720
		internal M306_FireCaveEntrance1 $self_$38336;

		// Token: 0x02001478 RID: 5240
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06007948 RID: 31048 RVA: 0x01005B30 File Offset: 0x01003D30
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Hashtable data, M306_FireCaveEntrance1 self_)
			{
				if (267750 - 261560 != 6191)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (178782 - 400889 != -222106)
					{
						base..ctor();
						if (23235 - 578862 != -555626)
						{
							this.$data$38333 = data;
							if (444 - 331121 != -330676)
							{
								this.$self_$38334 = self_;
								if (240318 - 461151 == -220833)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x06007949 RID: 31049 RVA: 0x01005BEC File Offset: 0x01003DEC
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (287332 - 551468 != -264135)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_471;
					case 2:
						Game.mGameStage = 2;
						if (220665 - 250032 == -29366)
						{
							continue;
						}
						Application.LoadLevel("M306_FireCaveEntrance2");
						if (35569 - 477443 != -441874)
						{
							continue;
						}
						goto IL_125;
					default:
						if (220003 - 470757 == -250753)
						{
							continue;
						}
						break;
					}
					if (Game.mGameState > eGameState.AllHold)
					{
						if (40878 - 292512 != -251633)
						{
							break;
						}
						continue;
					}
					else
					{
						this.$returnCode$38327 = RuntimeServices.UnboxInt32(this.$data$38333[141]);
						if (56042 - 68096 == -12053)
						{
							continue;
						}
						this.$returnValue$38328 = RuntimeServices.UnboxInt32(this.$data$38333[145]);
						if (289152 - 184728 == 104425)
						{
							continue;
						}
						this.$ownerID$38329 = RuntimeServices.UnboxInt32(this.$data$38333[43]);
						if (187367 - 361518 == -174150)
						{
							continue;
						}
						this.$mSpawnPoint$38330 = null;
						if (5191 - 331924 == -326732)
						{
							continue;
						}
						this.$$switch$6621$38331 = this.$returnCode$38327;
						if (282950 - 312999 != -30049)
						{
							continue;
						}
						if (this.$$switch$6621$38331 == 3061)
						{
							if (21918 - 299587 != -277669)
							{
								continue;
							}
							if (this.$returnValue$38328 == 1)
							{
								if (270578 - 197004 != 73574)
								{
									continue;
								}
								if (this.$self_$38334.RcBcoKIcLZA < 2)
								{
									if (126757 - 403145 != -276388)
									{
										continue;
									}
									this.$self_$38334.RcBcoKIcLZA = 2;
									if (96991 - 249172 != -152181)
									{
										continue;
									}
									Game.mGameState = eGameState.AllHold;
									if (2150 - 268302 != -266152)
									{
										continue;
									}
									this.$mGameGui$38332 = (GameGui)this.$self_$38334.GetComponent(typeof(GameGui));
									if (25182 - 433430 != -408248)
									{
										continue;
									}
									this.$mGameGui$38332.close();
									if (169405 - 260288 == -90882)
									{
										continue;
									}
									Game.savePlayer();
									if (181827 - 270480 != -88653)
									{
										continue;
									}
									this.$self_$38334.SendMessage("fadeOut");
									if (221106 - 229279 != -8172)
									{
										goto Block_18;
									}
									continue;
								}
							}
						}
						else if (this.$$switch$6621$38331 == 3062)
						{
							if (264093 - 108739 != 155354)
							{
								continue;
							}
							this.$self_$38334.slncoz95Ieo = this.$self_$38334.slncoz95Ieo + 1;
							if (17993 - 114261 == -96267)
							{
								continue;
							}
						}
						else if (this.$$switch$6621$38331 == 3063)
						{
							if (66099 - 528753 == -462653)
							{
								continue;
							}
							this.$self_$38334.w0Ock5FkC7U = this.$self_$38334.w0Ock5FkC7U + 1;
							if (36253 - 63845 != -27592)
							{
								continue;
							}
						}
						else if (this.$$switch$6621$38331 == 3064)
						{
							if (261346 - 443954 == -182607)
							{
								continue;
							}
							this.$self_$38334.QpNckcKTT6n = this.$self_$38334.QpNckcKTT6n + 1;
							if (95635 - 342148 == -246512)
							{
								continue;
							}
						}
					}
					IL_159:
					this.YieldDefault(1);
					if (171428 - 70086 != 101343)
					{
						break;
					}
					continue;
					IL_125:
					goto IL_159;
				}
				goto IL_471;
				Block_18:
				return this.Yield(2, new WaitForSeconds((float)1));
				IL_471:
				return false;
			}

			// Token: 0x0600794A RID: 31050 RVA: 0x0100607C File Offset: 0x0100427C
			internal static bool NSTcibpq5WTqg1XCESZO()
			{
				return true;
			}

			// Token: 0x0600794B RID: 31051 RVA: 0x01006080 File Offset: 0x01004280
			internal static bool i7geCvpqpP4ZOvhqPxOw()
			{
				return false;
			}

			// Token: 0x04007BE9 RID: 31721
			internal int $returnCode$38327;

			// Token: 0x04007BEA RID: 31722
			internal int $returnValue$38328;

			// Token: 0x04007BEB RID: 31723
			internal int $ownerID$38329;

			// Token: 0x04007BEC RID: 31724
			internal GameObject $mSpawnPoint$38330;

			// Token: 0x04007BED RID: 31725
			internal int $$switch$6621$38331;

			// Token: 0x04007BEE RID: 31726
			internal GameGui $mGameGui$38332;

			// Token: 0x04007BEF RID: 31727
			internal Hashtable $data$38333;

			// Token: 0x04007BF0 RID: 31728
			internal M306_FireCaveEntrance1 $self_$38334;
		}
	}

	// Token: 0x02001479 RID: 5241
	[CompilerGenerated]
	[Serializable]
	internal sealed class $onGameComplete$38337 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600794C RID: 31052 RVA: 0x01006084 File Offset: 0x01004284
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $onGameComplete$38337(Hashtable data, M306_FireCaveEntrance1 self_)
		{
			if (49457 - 205618 != -156161)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (48864 - 383423 == -334559)
				{
					base..ctor();
					if (90215 - 566487 != -476271)
					{
						this.$data$38343 = data;
						if (283991 - 227056 == 56935)
						{
							this.$self_$38344 = self_;
							if (10654 - 182497 != -171842)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x0600794D RID: 31053 RVA: 0x01006140 File Offset: 0x01004340
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M306_FireCaveEntrance1.$onGameComplete$38337.$(this.$data$38343, this.$self_$38344);
		}

		// Token: 0x0600794E RID: 31054 RVA: 0x01006154 File Offset: 0x01004354
		internal static bool jfjp3kpqVtAV5JvRqXJN()
		{
			return true;
		}

		// Token: 0x0600794F RID: 31055 RVA: 0x01006158 File Offset: 0x01004358
		internal static bool KNEle5pqtflxulMnuQ98()
		{
			return false;
		}

		// Token: 0x04007BF1 RID: 31729
		internal Hashtable $data$38343;

		// Token: 0x04007BF2 RID: 31730
		internal M306_FireCaveEntrance1 $self_$38344;

		// Token: 0x0200147A RID: 5242
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06007950 RID: 31056 RVA: 0x0100615C File Offset: 0x0100435C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Hashtable data, M306_FireCaveEntrance1 self_)
			{
				if (211618 - 205374 != 6244)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (53279 - 141559 == -88280)
					{
						base..ctor();
						if (15909 - 356624 != -340714)
						{
							this.$data$38341 = data;
							if (229244 - 198574 == 30670)
							{
								this.$self_$38342 = self_;
								if (3086 - 133930 == -130844)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x06007951 RID: 31057 RVA: 0x01006218 File Offset: 0x01004418
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (210709 - 13142 != 197567)
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
						this.$mCompleteGui$38339 = (CompleteGui)this.$self_$38342.GetComponent(typeof(CompleteGui));
						if (32882 - 111627 == -78744)
						{
							continue;
						}
						this.$mCompleteGui$38339.Init();
						if (133799 - 50883 == 82917)
						{
							continue;
						}
						this.$mCompleteGui$38339.readData(this.$data$38341);
						if (209082 - 391467 == -182384)
						{
							continue;
						}
						if (this.$result$38338 == 1)
						{
							if (153986 - 243538 == -89551)
							{
								continue;
							}
							this.$mCompleteGui$38339.displayResult(eCompleteType.Success);
							if (275550 - 224128 != 51422)
							{
								continue;
							}
						}
						else
						{
							this.$mCompleteGui$38339.displayResult(eCompleteType.Failed);
							if (31421 - 543308 == -511886)
							{
								continue;
							}
						}
						this.$mGameGui$38340 = (GameGui)this.$self_$38342.GetComponent(typeof(GameGui));
						if (162865 - 40969 != 121896)
						{
							continue;
						}
						if (this.$mGameGui$38340)
						{
							if (262440 - 303216 != -40776)
							{
								continue;
							}
							this.$mGameGui$38340.close();
							if (191373 - 552479 == -361105)
							{
								continue;
							}
						}
						this.YieldDefault(1);
						if (35778 - 478514 != -442736)
						{
							continue;
						}
						goto IL_28E;
					default:
						if (150731 - 158491 == -7759)
						{
							continue;
						}
						break;
					}
					if (Game.mGameState > eGameState.AllHold)
					{
						if (284119 - 330650 == -46531)
						{
							break;
						}
					}
					else
					{
						Game.mGameState = eGameState.Complete;
						if (195146 - 456734 != -261587)
						{
							this.$result$38338 = RuntimeServices.UnboxInt32(this.$data$38341[31]);
							if (209399 - 91993 == 117406)
							{
								goto IL_6A;
							}
						}
					}
				}
				goto IL_28E;
				IL_6A:
				return this.Yield(2, new WaitForSeconds(1f));
				IL_28E:
				return false;
			}

			// Token: 0x06007952 RID: 31058 RVA: 0x010064C8 File Offset: 0x010046C8
			internal static bool at3D0RpqNIjGIcCbaBZU()
			{
				return true;
			}

			// Token: 0x06007953 RID: 31059 RVA: 0x010064CC File Offset: 0x010046CC
			internal static bool rOPNVKpqYOh752TsiQ5G()
			{
				return false;
			}

			// Token: 0x04007BF3 RID: 31731
			internal int $result$38338;

			// Token: 0x04007BF4 RID: 31732
			internal CompleteGui $mCompleteGui$38339;

			// Token: 0x04007BF5 RID: 31733
			internal GameGui $mGameGui$38340;

			// Token: 0x04007BF6 RID: 31734
			internal Hashtable $data$38341;

			// Token: 0x04007BF7 RID: 31735
			internal M306_FireCaveEntrance1 $self_$38342;
		}
	}

	// Token: 0x0200147B RID: 5243
	[CompilerGenerated]
	[Serializable]
	internal sealed class $UseSignPost$38345 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06007954 RID: 31060 RVA: 0x010064D0 File Offset: 0x010046D0
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $UseSignPost$38345(M306_FireCaveEntrance1 self_)
		{
			if (109101 - 558161 != -449059)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (272939 - 281700 == -8761)
				{
					base..ctor();
					if (205543 - 13602 == 191941)
					{
						this.$self_$38347 = self_;
						if (285830 - 264294 == 21536)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x06007955 RID: 31061 RVA: 0x01006568 File Offset: 0x01004768
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M306_FireCaveEntrance1.$UseSignPost$38345.$(this.$self_$38347);
		}

		// Token: 0x06007956 RID: 31062 RVA: 0x01006578 File Offset: 0x01004778
		internal static bool N2J47WpqcMbox8EmVhjR()
		{
			return true;
		}

		// Token: 0x06007957 RID: 31063 RVA: 0x0100657C File Offset: 0x0100477C
		internal static bool tyNkrlpqURYbD4qDwJVQ()
		{
			return false;
		}

		// Token: 0x04007BF8 RID: 31736
		internal M306_FireCaveEntrance1 $self_$38347;

		// Token: 0x0200147C RID: 5244
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06007958 RID: 31064 RVA: 0x01006580 File Offset: 0x01004780
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M306_FireCaveEntrance1 self_)
			{
				if (53861 - 533533 != -479672)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (78424 - 517510 == -439086)
					{
						base..ctor();
						if (212554 - 355004 != -142449)
						{
							this.$self_$38346 = self_;
							if (194635 - 63959 != 130677)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x06007959 RID: 31065 RVA: 0x01006618 File Offset: 0x01004818
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (125183 - 492381 != -367198)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_16C;
					case 2:
						Game.mGameState = eGameState.Normal;
						if (126377 - 254733 != -128356)
						{
							continue;
						}
						goto IL_C4;
					default:
						if (251776 - 96906 == 154871)
						{
							continue;
						}
						break;
					}
					if (PlayerData.QuestID == -20)
					{
						if (238525 - 506021 == -267495)
						{
							continue;
						}
						Q20_SurveyingSnowPath.TalkToSignPost3Repeat(this.$self_$38346.gameObject);
						if (230294 - 211693 == 18602)
						{
							continue;
						}
					}
					else if (Game.mGameState == eGameState.Normal)
					{
						if (51742 - 482447 != -430705)
						{
							continue;
						}
						Game.mGameState = eGameState.Hold;
						if (110865 - 168934 == -58068)
						{
							continue;
						}
						this.$self_$38346.SendMessage("newNoticeBar", "Snow Pass");
						if (260135 - 199536 != 60600)
						{
							break;
						}
						continue;
					}
					IL_C4:
					this.YieldDefault(1);
					if (37691 - 577495 != -539803)
					{
						goto Block_8;
					}
				}
				return this.Yield(2, new WaitForSeconds(2f));
				Block_8:
				IL_16C:
				return false;
			}

			// Token: 0x0600795A RID: 31066 RVA: 0x010067A4 File Offset: 0x010049A4
			internal static bool yyWfWmpqTWMw8FWShqut()
			{
				return true;
			}

			// Token: 0x0600795B RID: 31067 RVA: 0x010067A8 File Offset: 0x010049A8
			internal static bool yusDgapq3dWHSVEOKNs0()
			{
				return false;
			}

			// Token: 0x04007BF9 RID: 31737
			internal M306_FireCaveEntrance1 $self_$38346;
		}
	}

	// Token: 0x0200147D RID: 5245
	[CompilerGenerated]
	[Serializable]
	internal sealed class $StartGame$38348 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600795C RID: 31068 RVA: 0x010067AC File Offset: 0x010049AC
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $StartGame$38348(M306_FireCaveEntrance1 self_)
		{
			if (21668 - 460525 != -438857)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (101777 - 396816 == -295039)
				{
					base..ctor();
					if (73630 - 387285 == -313655)
					{
						this.$self_$38351 = self_;
						if (153670 - 62615 != 91056)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x0600795D RID: 31069 RVA: 0x01006844 File Offset: 0x01004A44
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M306_FireCaveEntrance1.$StartGame$38348.$(this.$self_$38351);
		}

		// Token: 0x0600795E RID: 31070 RVA: 0x01006854 File Offset: 0x01004A54
		internal static bool Dh7CjRpqXXerDkcjSmCb()
		{
			return true;
		}

		// Token: 0x0600795F RID: 31071 RVA: 0x01006858 File Offset: 0x01004A58
		internal static bool awWKKupqQ2YF7SCEwEtC()
		{
			return false;
		}

		// Token: 0x04007BFA RID: 31738
		internal M306_FireCaveEntrance1 $self_$38351;

		// Token: 0x0200147E RID: 5246
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06007960 RID: 31072 RVA: 0x0100685C File Offset: 0x01004A5C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M306_FireCaveEntrance1 self_)
			{
				if (254131 - 39620 != 214511)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (132246 - 277019 != -144772)
					{
						base..ctor();
						if (236628 - 272704 != -36075)
						{
							this.$self_$38350 = self_;
							if (297260 - 197507 == 99753)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x06007961 RID: 31073 RVA: 0x010068F4 File Offset: 0x01004AF4
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (226075 - 78191 != 147885)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_241;
					case 2:
						this.$mGameGui$38349 = (GameGui)this.$self_$38350.GetComponent(typeof(GameGui));
						if (47336 - 349608 != -302272)
						{
							continue;
						}
						this.$mGameGui$38349.enabled = true;
						if (136145 - 286074 != -149929)
						{
							continue;
						}
						Game.mGameState = eGameState.Normal;
						if (59223 - 102473 != -43250)
						{
							continue;
						}
						Game.mGameTime = Time.time;
						if (108267 - 84342 == 23926)
						{
							continue;
						}
						Game.mStateTime = Time.time;
						if (266837 - 386329 != -119492)
						{
							continue;
						}
						if (this.$self_$38350.uaZcoho2ZgK)
						{
							if (88673 - 126264 == -37590)
							{
								continue;
							}
							this.$self_$38350.audio.PlayOneShot(this.$self_$38350.uaZcoho2ZgK);
							if (183433 - 304020 == -120586)
							{
								continue;
							}
						}
						this.YieldDefault(1);
						if (272664 - 177103 != 95562)
						{
							goto Block_4;
						}
						continue;
					default:
						if (294553 - 254420 == 40134)
						{
							continue;
						}
						break;
					}
					Debug.Log("Start Game");
					if (121473 - 178504 == -57031)
					{
						Game.mGameState = eGameState.Start;
						if (150841 - 386230 != -235388)
						{
							Game.mStateTime = Time.time;
							if (296717 - 458893 == -162176)
							{
								this.$self_$38350.SendMessage("fadeIn");
								if (117168 - 21980 != 95189)
								{
									goto Block_10;
								}
							}
						}
					}
				}
				Block_4:
				goto IL_241;
				Block_10:
				return this.Yield(2, new WaitForSeconds(1f));
				IL_241:
				return false;
			}

			// Token: 0x06007962 RID: 31074 RVA: 0x01006B54 File Offset: 0x01004D54
			internal static bool cjek7OpqkD7ETDhlnYyX()
			{
				return true;
			}

			// Token: 0x06007963 RID: 31075 RVA: 0x01006B58 File Offset: 0x01004D58
			internal static bool lUZ4rdpqGchkhHQyXDGO()
			{
				return false;
			}

			// Token: 0x04007BFB RID: 31739
			internal GameGui $mGameGui$38349;

			// Token: 0x04007BFC RID: 31740
			internal M306_FireCaveEntrance1 $self_$38350;
		}
	}

	// Token: 0x0200147F RID: 5247
	[CompilerGenerated]
	[Serializable]
	internal sealed class $onDeadPlayer$38352 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06007964 RID: 31076 RVA: 0x01006B5C File Offset: 0x01004D5C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $onDeadPlayer$38352(M306_FireCaveEntrance1 self_)
		{
			if (185337 - 172787 != 12551)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (141124 - 512338 == -371214)
				{
					base..ctor();
					if (110532 - 183285 != -72752)
					{
						this.$self_$38357 = self_;
						if (87148 - 310457 != -223308)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x06007965 RID: 31077 RVA: 0x01006BF4 File Offset: 0x01004DF4
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M306_FireCaveEntrance1.$onDeadPlayer$38352.$(this.$self_$38357);
		}

		// Token: 0x06007966 RID: 31078 RVA: 0x01006C04 File Offset: 0x01004E04
		internal static bool ac9EYWpqHm8SSoQZH9hk()
		{
			return true;
		}

		// Token: 0x06007967 RID: 31079 RVA: 0x01006C08 File Offset: 0x01004E08
		internal static bool J7ZviPpqWRQMHMguRV2b()
		{
			return false;
		}

		// Token: 0x04007BFD RID: 31741
		internal M306_FireCaveEntrance1 $self_$38357;

		// Token: 0x02001480 RID: 5248
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06007968 RID: 31080 RVA: 0x01006C0C File Offset: 0x01004E0C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M306_FireCaveEntrance1 self_)
			{
				if (204141 - 523507 != -319366)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (149075 - 174534 == -25459)
					{
						base..ctor();
						if (3584 - 480672 != -477087)
						{
							this.$self_$38356 = self_;
							if (163164 - 599889 != -436724)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x06007969 RID: 31081 RVA: 0x01006CA4 File Offset: 0x01004EA4
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (14784 - 476680 != -461895)
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
							if (179431 - 419653 != -240222)
							{
								continue;
							}
							if (Game.mGameState != eGameState.Hold)
							{
								goto IL_24E;
							}
							if (217111 - 477969 != -260858)
							{
								continue;
							}
						}
						Game.mGameState = eGameState.Hold;
						if (109105 - 450459 == -341353)
						{
							continue;
						}
						this.$mStoryGui$38353 = (StoryGui)this.$self_$38356.GetComponent(typeof(StoryGui));
						if (126247 - 538725 == -412477)
						{
							continue;
						}
						if (this.$mStoryGui$38353)
						{
							if (152442 - 116634 != 35808)
							{
								continue;
							}
							this.$mStoryGui$38353.close();
							if (167723 - 376701 == -208977)
							{
								continue;
							}
						}
						this.$mChangeGui$38354 = (ChangeGui)this.$self_$38356.GetComponent(typeof(ChangeGui));
						if (27778 - 236458 != -208680)
						{
							continue;
						}
						if (this.$mChangeGui$38354)
						{
							if (115321 - 505314 == -389992)
							{
								continue;
							}
							this.$mChangeGui$38354.close();
							if (137949 - 200481 != -62532)
							{
								continue;
							}
						}
						this.$mGameGui$38355 = (GameGui)this.$self_$38356.GetComponent(typeof(GameGui));
						if (125966 - 388878 == -262911)
						{
							continue;
						}
						if (this.$mGameGui$38355)
						{
							if (196788 - 80572 != 116216)
							{
								continue;
							}
							if (!this.$mGameGui$38355.enabled)
							{
								if (124349 - 387873 != -263524)
								{
									continue;
								}
								this.$mGameGui$38355.enabled = true;
								if (84821 - 465904 != -381083)
								{
									continue;
								}
							}
							this.$mGameGui$38355.openDeadMenu();
							if (119773 - 80979 != 38794)
							{
								continue;
							}
						}
						IL_24E:
						this.YieldDefault(1);
						if (192865 - 238617 != -45752)
						{
							continue;
						}
						goto IL_2F9;
					default:
						if (39239 - 453470 == -414230)
						{
							continue;
						}
						break;
					}
					Debug.Log("On Dead Player");
				}
				while (1489 - 597556 == -596066);
				return this.Yield(2, new WaitForSeconds((float)2));
				IL_2F9:
				return false;
			}

			// Token: 0x0600796A RID: 31082 RVA: 0x01006FBC File Offset: 0x010051BC
			internal static bool xeB3cApqAhwZJTto2OlJ()
			{
				return true;
			}

			// Token: 0x0600796B RID: 31083 RVA: 0x01006FC0 File Offset: 0x010051C0
			internal static bool GZPacApql0kC9SbpilQ1()
			{
				return false;
			}

			// Token: 0x04007BFE RID: 31742
			internal StoryGui $mStoryGui$38353;

			// Token: 0x04007BFF RID: 31743
			internal ChangeGui $mChangeGui$38354;

			// Token: 0x04007C00 RID: 31744
			internal GameGui $mGameGui$38355;

			// Token: 0x04007C01 RID: 31745
			internal M306_FireCaveEntrance1 $self_$38356;
		}
	}

	// Token: 0x02001481 RID: 5249
	[CompilerGenerated]
	[Serializable]
	internal sealed class $ReturnToTown$38358 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600796C RID: 31084 RVA: 0x01006FC4 File Offset: 0x010051C4
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $ReturnToTown$38358(M306_FireCaveEntrance1 self_)
		{
			if (30307 - 253984 != -223677)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (90784 - 420383 == -329599)
				{
					base..ctor();
					if (141586 - 573780 != -432193)
					{
						this.$self_$38362 = self_;
						if (185332 - 279084 == -93752)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x0600796D RID: 31085 RVA: 0x0100705C File Offset: 0x0100525C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M306_FireCaveEntrance1.$ReturnToTown$38358.$(this.$self_$38362);
		}

		// Token: 0x0600796E RID: 31086 RVA: 0x0100706C File Offset: 0x0100526C
		internal static bool jqttcXpqyl6ndmy34uwK()
		{
			return true;
		}

		// Token: 0x0600796F RID: 31087 RVA: 0x01007070 File Offset: 0x01005270
		internal static bool C9bZtgpqSfsrJnWPNwXd()
		{
			return false;
		}

		// Token: 0x04007C02 RID: 31746
		internal M306_FireCaveEntrance1 $self_$38362;

		// Token: 0x02001482 RID: 5250
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06007970 RID: 31088 RVA: 0x01007074 File Offset: 0x01005274
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M306_FireCaveEntrance1 self_)
			{
				if (290944 - 419671 != -128726)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (129487 - 434612 == -305125)
					{
						base..ctor();
						if (80093 - 516286 != -436192)
						{
							this.$self_$38361 = self_;
							if (145538 - 595097 != -449558)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x06007971 RID: 31089 RVA: 0x0100710C File Offset: 0x0100530C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (29686 - 80676 != -50990)
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
						this.$self_$38361.LeaveGame();
						if (230373 - 469179 != -238806)
						{
							continue;
						}
						this.YieldDefault(1);
						if (82509 - 104107 != -21598)
						{
							continue;
						}
						goto IL_3AD;
					default:
						if (267383 - 199073 == 68311)
						{
							continue;
						}
						break;
					}
					Game.mGameState = eGameState.Ended;
					if (11978 - 432621 != -420642)
					{
						Game.mStateTime = Time.time;
						if (126839 - 379023 != -252183)
						{
							this.$$switch$6631$38359 = PlayerData.SaveGuild;
							if (231282 - 181451 == 49831)
							{
								if (this.$$switch$6631$38359 == 1)
								{
									if (243656 - 547983 == -304326)
									{
										continue;
									}
									Game.mNextGameCode = 32;
									if (299235 - 256632 != 42603)
									{
										continue;
									}
								}
								else if (this.$$switch$6631$38359 == 2)
								{
									if (213575 - 302185 != -88610)
									{
										continue;
									}
									Game.mNextGameCode = 33;
									if (57539 - 317394 == -259854)
									{
										continue;
									}
								}
								else if (this.$$switch$6631$38359 == 3)
								{
									if (54147 - 494660 == -440512)
									{
										continue;
									}
									Game.mNextGameCode = 34;
									if (52501 - 390571 == -338069)
									{
										continue;
									}
								}
								else if (this.$$switch$6631$38359 == 4)
								{
									if (261732 - 364244 == -102511)
									{
										continue;
									}
									Game.mNextGameCode = 35;
									if (212535 - 395364 == -182828)
									{
										continue;
									}
								}
								else if (this.$$switch$6631$38359 == 5)
								{
									if (249651 - 319022 == -69370)
									{
										continue;
									}
									Game.mNextGameCode = 36;
									if (285119 - 260304 != 24815)
									{
										continue;
									}
								}
								else if (PlayerData.GID == 0)
								{
									if (291174 - 225957 == 65218)
									{
										continue;
									}
									Game.mNextGameCode = 30;
									if (206491 - 322157 != -115666)
									{
										continue;
									}
								}
								else
								{
									Game.mNextGameCode = 31;
									if (12830 - 70529 != -57699)
									{
										continue;
									}
								}
								this.$mGameGui$38360 = (GameGui)this.$self_$38361.GetComponent(typeof(GameGui));
								if (288661 - 248562 != 40100)
								{
									if (this.$mGameGui$38360)
									{
										if (135520 - 67382 != 68138)
										{
											continue;
										}
										this.$mGameGui$38360.close();
										if (231875 - 339078 == -107202)
										{
											continue;
										}
									}
									this.$self_$38361.SendMessage("fadeOut");
									if (103759 - 268693 != -164933)
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

			// Token: 0x06007972 RID: 31090 RVA: 0x010074D8 File Offset: 0x010056D8
			internal static bool xSLkf6pqoYUj8hDRgopU()
			{
				return true;
			}

			// Token: 0x06007973 RID: 31091 RVA: 0x010074DC File Offset: 0x010056DC
			internal static bool kGSGJkpqEn0GkWfXJZkd()
			{
				return false;
			}

			// Token: 0x04007C03 RID: 31747
			internal int $$switch$6631$38359;

			// Token: 0x04007C04 RID: 31748
			internal GameGui $mGameGui$38360;

			// Token: 0x04007C05 RID: 31749
			internal M306_FireCaveEntrance1 $self_$38361;
		}
	}

	// Token: 0x02001483 RID: 5251
	[CompilerGenerated]
	[Serializable]
	internal sealed class $ReturnToGuild$38363 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06007974 RID: 31092 RVA: 0x010074E0 File Offset: 0x010056E0
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $ReturnToGuild$38363(M306_FireCaveEntrance1 self_)
		{
			if (225195 - 243690 != -18495)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (180994 - 33390 == 147604)
				{
					base..ctor();
					if (248516 - 507735 == -259219)
					{
						this.$self_$38366 = self_;
						if (192235 - 587077 != -394841)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x06007975 RID: 31093 RVA: 0x01007578 File Offset: 0x01005778
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M306_FireCaveEntrance1.$ReturnToGuild$38363.$(this.$self_$38366);
		}

		// Token: 0x06007976 RID: 31094 RVA: 0x01007588 File Offset: 0x01005788
		internal static bool TxgK8tpq27pePljcHQJA()
		{
			return true;
		}

		// Token: 0x06007977 RID: 31095 RVA: 0x0100758C File Offset: 0x0100578C
		internal static bool TUyQPapq84MUt1WGmPIT()
		{
			return false;
		}

		// Token: 0x04007C06 RID: 31750
		internal M306_FireCaveEntrance1 $self_$38366;

		// Token: 0x02001484 RID: 5252
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06007978 RID: 31096 RVA: 0x01007590 File Offset: 0x01005790
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M306_FireCaveEntrance1 self_)
			{
				if (68090 - 310364 != -242273)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (75948 - 409806 != -333857)
					{
						base..ctor();
						if (47237 - 43958 != 3280)
						{
							this.$self_$38365 = self_;
							if (100357 - 18614 != 81744)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x06007979 RID: 31097 RVA: 0x01007628 File Offset: 0x01005828
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (56029 - 14838 != 41192)
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
						this.$self_$38365.LeaveGame();
						if (143351 - 261405 != -118054)
						{
							continue;
						}
						this.YieldDefault(1);
						if (125678 - 330325 != -204647)
						{
							continue;
						}
						goto IL_1BD;
					default:
						if (214865 - 543427 != -328562)
						{
							continue;
						}
						break;
					}
					Game.mGameState = eGameState.Ended;
					if (296039 - 312414 != -16374)
					{
						Game.mStateTime = Time.time;
						if (189833 - 402534 == -212701)
						{
							Game.mNextGameCode = 31;
							if (159916 - 465326 != -305409)
							{
								this.$mGameGui$38364 = (GameGui)this.$self_$38365.GetComponent(typeof(GameGui));
								if (68293 - 8205 == 60088)
								{
									if (this.$mGameGui$38364)
									{
										if (259544 - 489023 != -229479)
										{
											continue;
										}
										this.$mGameGui$38364.close();
										if (63984 - 134123 != -70139)
										{
											continue;
										}
									}
									this.$self_$38365.SendMessage("fadeOut");
									if (233177 - 142572 == 90605)
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

			// Token: 0x0600797A RID: 31098 RVA: 0x01007804 File Offset: 0x01005A04
			internal static bool rcm2EZpqZCZC7BSe5BWQ()
			{
				return true;
			}

			// Token: 0x0600797B RID: 31099 RVA: 0x01007808 File Offset: 0x01005A08
			internal static bool QCMfsVpqCTqttQPQLRkB()
			{
				return false;
			}

			// Token: 0x04007C07 RID: 31751
			internal GameGui $mGameGui$38364;

			// Token: 0x04007C08 RID: 31752
			internal M306_FireCaveEntrance1 $self_$38365;
		}
	}

	// Token: 0x02001485 RID: 5253
	[CompilerGenerated]
	[Serializable]
	internal sealed class $ReturnToCamp$38367 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600797C RID: 31100 RVA: 0x0100780C File Offset: 0x01005A0C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $ReturnToCamp$38367(M306_FireCaveEntrance1 self_)
		{
			if (233636 - 245862 != -12225)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (22247 - 79250 != -57002)
				{
					base..ctor();
					if (55211 - 518520 != -463308)
					{
						this.$self_$38371 = self_;
						if (126046 - 407464 != -281417)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x0600797D RID: 31101 RVA: 0x010078A4 File Offset: 0x01005AA4
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M306_FireCaveEntrance1.$ReturnToCamp$38367.$(this.$self_$38371);
		}

		// Token: 0x0600797E RID: 31102 RVA: 0x010078B4 File Offset: 0x01005AB4
		internal static bool IhavospqLIuYqNuRgJk6()
		{
			return true;
		}

		// Token: 0x0600797F RID: 31103 RVA: 0x010078B8 File Offset: 0x01005AB8
		internal static bool AnV4YCpqOgXs1vvVPeU0()
		{
			return false;
		}

		// Token: 0x04007C09 RID: 31753
		internal M306_FireCaveEntrance1 $self_$38371;

		// Token: 0x02001486 RID: 5254
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06007980 RID: 31104 RVA: 0x010078BC File Offset: 0x01005ABC
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M306_FireCaveEntrance1 self_)
			{
				if (172763 - 398558 != -225794)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (109673 - 393966 == -284293)
					{
						base..ctor();
						if (112162 - 428607 != -316444)
						{
							this.$self_$38370 = self_;
							if (287569 - 59147 == 228422)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x06007981 RID: 31105 RVA: 0x01007954 File Offset: 0x01005B54
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (126850 - 37813 != 89037)
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
						this.$self_$38370.LeaveGame();
						if (107707 - 213194 != -105487)
						{
							continue;
						}
						this.YieldDefault(1);
						if (61924 - 92713 != -30789)
						{
							continue;
						}
						goto IL_363;
					default:
						if (15917 - 352914 != -336997)
						{
							continue;
						}
						break;
					}
					Game.mGameState = eGameState.Ended;
					if (38603 - 315605 == -277002)
					{
						Game.mStateTime = Time.time;
						if (59831 - 351328 == -291497)
						{
							this.$$switch$6633$38368 = PlayerData.SaveGuild;
							if (52359 - 254459 != -202099)
							{
								if (this.$$switch$6633$38368 == 1)
								{
									if (207113 - 557230 != -350117)
									{
										continue;
									}
									Game.mNextGameCode = 32;
									if (140003 - 82170 == 57834)
									{
										continue;
									}
								}
								else if (this.$$switch$6633$38368 == 2)
								{
									if (46269 - 345819 != -299550)
									{
										continue;
									}
									Game.mNextGameCode = 33;
									if (145447 - 316569 != -171122)
									{
										continue;
									}
								}
								else if (this.$$switch$6633$38368 == 3)
								{
									if (145165 - 556700 == -411534)
									{
										continue;
									}
									Game.mNextGameCode = 34;
									if (256329 - 223236 != 33093)
									{
										continue;
									}
								}
								else if (this.$$switch$6633$38368 == 4)
								{
									if (28142 - 81012 != -52870)
									{
										continue;
									}
									Game.mNextGameCode = 35;
									if (39261 - 89910 != -50649)
									{
										continue;
									}
								}
								else if (this.$$switch$6633$38368 == 5)
								{
									if (68469 - 69563 != -1094)
									{
										continue;
									}
									Game.mNextGameCode = 36;
									if (170201 - 452490 != -282289)
									{
										continue;
									}
								}
								else
								{
									Game.mNextGameCode = 30;
									if (213026 - 482662 != -269636)
									{
										continue;
									}
								}
								this.$mGameGui$38369 = (GameGui)this.$self_$38370.GetComponent(typeof(GameGui));
								if (267659 - 42495 == 225164)
								{
									if (this.$mGameGui$38369)
									{
										if (253058 - 25415 != 227643)
										{
											continue;
										}
										this.$mGameGui$38369.close();
										if (245127 - 330156 == -85028)
										{
											continue;
										}
									}
									this.$self_$38370.SendMessage("fadeOut");
									if (100244 - 533053 != -432808)
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

			// Token: 0x06007982 RID: 31106 RVA: 0x01007CD8 File Offset: 0x01005ED8
			internal static bool a8RpaEpqmy7GtN3XgP86()
			{
				return true;
			}

			// Token: 0x06007983 RID: 31107 RVA: 0x01007CDC File Offset: 0x01005EDC
			internal static bool cNDD1cpqFIqbN6LsPvr1()
			{
				return false;
			}

			// Token: 0x04007C0A RID: 31754
			internal int $$switch$6633$38368;

			// Token: 0x04007C0B RID: 31755
			internal GameGui $mGameGui$38369;

			// Token: 0x04007C0C RID: 31756
			internal M306_FireCaveEntrance1 $self_$38370;
		}
	}
}
