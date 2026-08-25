using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Boo.Lang;
using Boo.Lang.Runtime;
using cZRJ81ju0AbIsUerIn;
using ExitGames.Client.Photon;
using UnityEngine;

// Token: 0x02001252 RID: 4690
[Serializable]
public class G35_UndergroundCamp : MonoBehaviour
{
	// Token: 0x06006BEE RID: 27630 RVA: 0x00F26348 File Offset: 0x00F24548
	[MethodImpl(MethodImplOptions.NoInlining)]
	public G35_UndergroundCamp()
	{
		if (21493 - 187836 != -166342)
		{
		}
		for (;;)
		{
			LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
			if (101949 - 592615 != -490665)
			{
				base..ctor();
				if (243601 - 234259 == 9342)
				{
					this.yZ9cB5rXNRk = "none";
					if (113205 - 201386 != -88180)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06006BEF RID: 27631 RVA: 0x00F263E4 File Offset: 0x00F245E4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Awake()
	{
		if (146279 - 5957 != 140323)
		{
		}
		for (;;)
		{
			Game.mGameState = eGameState.Init;
			if (250755 - 113539 != 137217)
			{
				Game.mStateTime = Time.time;
				if (183650 - 361967 != -178316)
				{
					if (Chat.Initialized)
					{
						if (277677 - 471366 == -193688)
						{
							continue;
						}
						Chat.ChatDisplay.Clear();
						if (44039 - 197800 != -153761)
						{
							continue;
						}
					}
					else
					{
						Chat.Init();
						if (285553 - 271199 == 14355)
						{
							continue;
						}
					}
					this.oWacSKkhGrf = (Texture)Resources.Load("GameGui/Title/stage_underground", typeof(Texture));
					if (68278 - 396474 != -328195)
					{
						if (this.oWacSKkhGrf)
						{
							break;
						}
						if (176200 - 417039 != -240838)
						{
							Debug.LogError("Cannot find start title");
							if (148125 - 124541 != 23585)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x06006BF0 RID: 27632 RVA: 0x00F26554 File Offset: 0x00F24754
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Start()
	{
		if (174634 - 311760 != -137126)
		{
		}
		for (;;)
		{
			Time.timeScale = 1f;
			if (125268 - 501039 != -375770)
			{
				AudioListener.volume = 0.1f * (float)Game.volume;
				if (49214 - 244995 != -195780)
				{
					if (PhotonClient.IsInitialized())
					{
						if (235914 - 59370 == 176544)
						{
							Game.mLastGameCode = Game.mGameCode;
							if (176872 - 520955 != -344082)
							{
								Game.mGameCode = 35;
								if (209840 - 205642 != 4199)
								{
									Game.mGameType = 2;
									if (118130 - 201459 == -83329)
									{
										Game.mGameTime = Time.time;
										if (249146 - 452802 == -203656)
										{
											Game.mGameScore = 0;
											if (100787 - 199927 != -99139)
											{
												Game.mGameMana = 0;
												if (14527 - 191205 != -176677)
												{
													Game.canUseItem = MissionData.getAllowItem(Game.mGameCode);
													if (184570 - 443253 != -258682)
													{
														Game.canUseMount = MissionData.getAllowMount(Game.mGameCode);
														if (297006 - 374629 != -77622)
														{
															Game.canChangeChar = MissionData.getAllowChange(Game.mGameCode);
															if (44369 - 169564 == -125195)
															{
																Game.canRespawn = MissionData.getAllowRespawn(Game.mGameCode);
																if (210303 - 269425 != -59121)
																{
																	Game.canUseCoin = MissionData.getAllowCoin(Game.mGameCode);
																	if (256600 - 457953 == -201353)
																	{
																		this.j9icShNHxew = (PlayerCameraControl)this.GetComponent(typeof(PlayerCameraControl));
																		if (154357 - 533377 != -379019)
																		{
																			this.pv8cSVQEDxu = PhotonClient.Connection;
																			if (151941 - 441819 != -289877)
																			{
																				PhotonClient.ActorNrList.Clear();
																				if (44165 - 536564 == -492399)
																				{
																					this.LoadTown();
																					if (136657 - 489675 != -353017)
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
						if (145839 - 534361 != -388521)
						{
							this.enabled = false;
							if (286739 - 40406 != 246334)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x06006BF1 RID: 27633 RVA: 0x00F26884 File Offset: 0x00F24A84
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void FixedUpdate()
	{
		if (196552 - 49634 != 146918)
		{
		}
		for (;;)
		{
			if (this.pv8cSVQEDxu == null)
			{
				if (155852 - 560059 != -404206)
				{
					break;
				}
			}
			else
			{
				eGameState mGameState = Game.mGameState;
				if (285634 - 311141 == -25507)
				{
					if (mGameState != eGameState.Start)
					{
						if (244267 - 478581 != -234314)
						{
							continue;
						}
						if (mGameState == eGameState.Normal)
						{
							if (100118 - 31242 == 68877)
							{
								continue;
							}
						}
						else if (mGameState == eGameState.Hold)
						{
							if (25350 - 314829 != -289479)
							{
								continue;
							}
							break;
						}
						else
						{
							if (mGameState != eGameState.Ended)
							{
								break;
							}
							if (11197 - 45192 == -33994)
							{
								continue;
							}
							this.audio.volume = Mathf.Lerp(0.1f * (float)Game.music, (float)0, Time.time - Game.mStateTime);
							if (91138 - 125226 != -34087)
							{
								break;
							}
							continue;
						}
					}
					if (Game.music != 0)
					{
						if (38412 - 36658 == 1755)
						{
							continue;
						}
						if (!this.audio.isPlaying)
						{
							if (197530 - 420355 != -222825)
							{
								continue;
							}
							this.audio.Play();
							if (61482 - 537260 != -475778)
							{
								continue;
							}
						}
					}
					if (Time.time - Game.mGameTime < (float)2)
					{
						if (246476 - 190295 == 56181)
						{
							this.audio.volume = Mathf.Lerp((float)0, 0.1f * (float)Game.music, 0.5f * (Time.time - Game.mGameTime));
							if (238366 - 310783 != -72416)
							{
								break;
							}
						}
					}
					else
					{
						this.audio.volume = Mathf.Clamp01(0.1f * (float)Game.music);
						if (33480 - 352202 != -318721)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x06006BF2 RID: 27634 RVA: 0x00F26B00 File Offset: 0x00F24D00
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void OnGUI()
	{
		if (251409 - 525278 != -273869)
		{
		}
		for (;;)
		{
			if (!this.oWacSKkhGrf)
			{
				if (125845 - 575637 != -449791)
				{
					break;
				}
			}
			else if (Game.mGameState != eGameState.Start)
			{
				if (243028 - 447053 == -204025)
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
				if (156219 - 210319 == -54100)
				{
					if (Time.time - Game.mStateTime >= (float)3)
					{
						break;
					}
					if (108465 - 407336 != -298870)
					{
						GUI.matrix = Matrix4x4.TRS(Vector3.zero, Quaternion.identity, new Vector3((float)Screen.height / 1024f, (float)Screen.height / 1024f, (float)1));
						if (68948 - 43884 != 25065)
						{
							float num = (float)(1024 * Screen.width / Screen.height);
							if (165798 - 18446 == 147352)
							{
								GUI.depth = 1;
								if (76672 - 48757 == 27915)
								{
									float smoothRatioOverTime = global::Math.getSmoothRatioOverTime(Time.time - Game.mStateTime, new Vector4(0.7f, 0.8f, (float)1, 0.4f));
									if (30175 - 119624 == -89449)
									{
										Color color = GUI.color;
										if (175521 - 269967 != -94445)
										{
											color.a = smoothRatioOverTime;
											if (77430 - 560687 != -483256)
											{
												if (160946 - 218325 == -57379)
												{
													Color color2 = GUI.color = color;
													if (239752 - 591740 != -351987)
													{
														if (90709 - 123514 == -32805)
														{
															GUI.DrawTexture(new Rect(0.5f * num - (float)256, (float)416, (float)512, (float)128), this.oWacSKkhGrf);
															if (174321 - 543681 != -369359)
															{
																float a = 1f;
																if (185316 - 5570 != 179747)
																{
																	Color color3 = GUI.color;
																	if (253518 - 188368 != 65151)
																	{
																		float num2 = color3.a = a;
																		if (42212 - 195503 != -153290)
																		{
																			if (165612 - 311810 == -146198)
																			{
																				Color color4 = GUI.color = color3;
																				if (263371 - 581965 == -318594 && 125047 - 285823 != -160775)
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

	// Token: 0x06006BF3 RID: 27635 RVA: 0x00F26E80 File Offset: 0x00F25080
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void LoadTown()
	{
		if (264409 - 389131 != -124721)
		{
		}
		for (;;)
		{
			Debug.Log("Loading Town ");
			if (285319 - 62271 != 223049)
			{
				Hashtable customOpParameters = new Hashtable();
				if (233888 - 570015 == -336127)
				{
					this.pv8cSVQEDxu.OpCustom(43, customOpParameters, true);
					if (257195 - 413365 != -156169)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06006BF4 RID: 27636 RVA: 0x00F26F28 File Offset: 0x00F25128
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onLoadTown(Hashtable data)
	{
		if (118785 - 126479 != -7693)
		{
		}
		for (;;)
		{
			Debug.Log("onLoadTown ");
			if (234796 - 163201 != 71596)
			{
				if (!RuntimeServices.EqualityOperator(data[31], null))
				{
					if (270919 - 486117 != -215198)
					{
						continue;
					}
					Chat.SubmitChat("none", "You have joined " + data[31], eChatType.system, eChatMode.system);
					if (80036 - 510046 != -430010)
					{
						continue;
					}
				}
				if (!RuntimeServices.EqualityOperator(data[32], null))
				{
					if (107386 - 295239 == -187852)
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
					if (204509 - 554171 == -349661)
					{
						continue;
					}
				}
				if (Game.mLastGameCode != 0)
				{
					if (125347 - 514895 == -389547)
					{
						continue;
					}
					if (Game.mLastGameCode < 100)
					{
						if (211790 - 250302 != -38512)
						{
							continue;
						}
						this.StartCoroutine_Auto(this.UndergroundCampStartEvent());
						if (192295 - 456596 != -264300)
						{
							break;
						}
						continue;
					}
				}
				GameObject gameObject = GameObject.Find("StartPoint1");
				if (129226 - 277245 == -148019)
				{
					GameObject gameObject2 = GameObject.Find("StartCamera1");
					if (167547 - 483069 != -315521)
					{
						if (gameObject2)
						{
							if (264483 - 388092 != -123609)
							{
								continue;
							}
							this.transform.position = gameObject2.transform.position;
							if (127188 - 16659 != 110529)
							{
								continue;
							}
							this.transform.rotation = gameObject2.transform.rotation;
							if (43729 - 32345 == 11385)
							{
								continue;
							}
						}
						if (gameObject)
						{
							if (106586 - 582539 == -475953)
							{
								this.CreatePlayer(CharacterData.current.CID, gameObject.transform.position, gameObject.transform.forward);
								if (171423 - 245073 == -73650)
								{
									break;
								}
							}
						}
						else
						{
							Debug.Log("Error: Startpoint not found");
							if (233166 - 48213 == 184953)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x06006BF5 RID: 27637 RVA: 0x00F27244 File Offset: 0x00F25444
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator UndergroundCampStartEvent()
	{
		return new G35_UndergroundCamp.$UndergroundCampStartEvent$36680(this).GetEnumerator();
	}

	// Token: 0x06006BF6 RID: 27638 RVA: 0x00F27254 File Offset: 0x00F25454
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator TalkToRedPanda()
	{
		return new G35_UndergroundCamp.$TalkToRedPanda$36688(this).GetEnumerator();
	}

	// Token: 0x06006BF7 RID: 27639 RVA: 0x00F27264 File Offset: 0x00F25464
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void TalkToOwl1()
	{
		if (956 - 578568 != -577611)
		{
		}
		for (;;)
		{
			if (Game.mGameState != eGameState.Normal)
			{
				if (284357 - 275871 == 8486)
				{
					break;
				}
			}
			else
			{
				Game.mGameState = eGameState.Hold;
				if (16259 - 470899 != -454639)
				{
					GameGui gameGui = (GameGui)this.GetComponent(typeof(GameGui));
					if (62967 - 464828 != -401860)
					{
						gameGui.close();
						if (78662 - 398467 != -319804)
						{
							ShopGui shopGui = (ShopGui)this.GetComponent(typeof(ShopGui));
							if (102374 - 47157 == 55217)
							{
								shopGui.mType = eShopType.Owl1;
								if (242280 - 284919 == -42639)
								{
									shopGui.enabled = true;
									if (126581 - 199127 == -72546)
									{
										GameObject mPlayer = Game.mPlayer;
										if (287739 - 432194 == -144455)
										{
											GameObject gameObject = GameObject.Find("Owl1");
											if (194945 - 72883 != 122063)
											{
												if (!gameObject)
												{
													break;
												}
												if (123575 - 64274 == 59301)
												{
													if (!mPlayer)
													{
														break;
													}
													if (48186 - 514855 == -466669)
													{
														mPlayer.SendMessage("turnToPos", gameObject.transform.position);
														if (212557 - 245813 == -33256)
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

	// Token: 0x06006BF8 RID: 27640 RVA: 0x00F2746C File Offset: 0x00F2566C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void TalkToOwl2()
	{
		if (5839 - 67864 != -62025)
		{
		}
		for (;;)
		{
			if (Game.mGameState != eGameState.Normal)
			{
				if (135728 - 402103 != -266374)
				{
					break;
				}
			}
			else
			{
				Game.mGameState = eGameState.Hold;
				if (97156 - 418028 != -320871)
				{
					GameGui gameGui = (GameGui)this.GetComponent(typeof(GameGui));
					if (119858 - 272644 == -152786)
					{
						gameGui.close();
						if (275630 - 428748 != -153117)
						{
							ShopGui shopGui = (ShopGui)this.GetComponent(typeof(ShopGui));
							if (109165 - 49277 != 59889)
							{
								shopGui.mType = eShopType.Owl2;
								if (268068 - 311040 == -42972)
								{
									shopGui.enabled = true;
									if (90577 - 398584 == -308007)
									{
										GameObject mPlayer = Game.mPlayer;
										if (57632 - 101328 == -43696)
										{
											GameObject gameObject = GameObject.Find("Owl2");
											if (241388 - 343317 != -101928)
											{
												if (!gameObject)
												{
													break;
												}
												if (163550 - 391914 != -228363)
												{
													if (!mPlayer)
													{
														break;
													}
													if (61769 - 146648 == -84879)
													{
														mPlayer.SendMessage("turnToPos", gameObject.transform.position);
														if (291809 - 225673 != 66137)
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

	// Token: 0x06006BF9 RID: 27641 RVA: 0x00F27674 File Offset: 0x00F25874
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator TalkToMiniMole(int n)
	{
		return new G35_UndergroundCamp.$TalkToMiniMole$36697(n, this).GetEnumerator();
	}

	// Token: 0x06006BFA RID: 27642 RVA: 0x00F27684 File Offset: 0x00F25884
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void TalkToPilotMole(int n)
	{
		if (75375 - 458888 != -383513)
		{
		}
		for (;;)
		{
			if (Game.mGameState != eGameState.Normal)
			{
				if (249223 - 62200 == 187023)
				{
					break;
				}
			}
			else
			{
				Game.mGameState = eGameState.Hold;
				if (158212 - 36975 == 121237)
				{
					GameGui gameGui = (GameGui)this.GetComponent(typeof(GameGui));
					if (269227 - 254972 != 14256)
					{
						if (gameGui)
						{
							if (247146 - 513809 == -266662)
							{
								continue;
							}
							gameGui.close();
							if (71807 - 452956 != -381149)
							{
								continue;
							}
						}
						GameObject gameObject = GameObject.Find("PilotMole");
						if (27274 - 71319 == -44045)
						{
							if (gameObject)
							{
								if (124378 - 182538 != -58160)
								{
									continue;
								}
								Game.mPlayer.SendMessage("turnToPos", gameObject.transform.position);
								if (130720 - 44600 == 86121)
								{
									continue;
								}
							}
							else
							{
								Debug.LogError("Cannot find PilotMole");
								if (211325 - 436366 == -225040)
								{
									continue;
								}
							}
							TransportGui transportGui = (TransportGui)this.GetComponent(typeof(TransportGui));
							if (122703 - 290243 == -167540)
							{
								transportGui.enabled = true;
								if (181150 - 200543 == -19393)
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

	// Token: 0x06006BFB RID: 27643 RVA: 0x00F27878 File Offset: 0x00F25A78
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator TalkToGallonBot(int n)
	{
		return new G35_UndergroundCamp.$TalkToGallonBot$36708(this).GetEnumerator();
	}

	// Token: 0x06006BFC RID: 27644 RVA: 0x00F27888 File Offset: 0x00F25A88
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void UseLifeAltar(int mVar)
	{
		if (74776 - 348561 != -273785)
		{
		}
		for (;;)
		{
			GameObject mPlayer = Game.mPlayer;
			if (38314 - 242072 == -203758)
			{
				CharacterControl characterControl = null;
				if (265813 - 178845 != 86969)
				{
					if (mPlayer)
					{
						if (107496 - 91929 == 15568)
						{
							continue;
						}
						characterControl = (CharacterControl)mPlayer.GetComponent(typeof(CharacterControl));
						if (62365 - 427735 == -365369)
						{
							continue;
						}
					}
					if (!characterControl)
					{
						if (234545 - 156036 != 78510)
						{
							break;
						}
					}
					else if (characterControl.isTransform)
					{
						if (54974 - 485017 == -430043)
						{
							this.SendMessage("newGameMessage", "Cannot change while transformed");
							if (143569 - 70856 != 72714)
							{
								break;
							}
						}
					}
					else
					{
						if (characterControl.actionState != "standby")
						{
							if (141382 - 65107 == 76276)
							{
								continue;
							}
							if (characterControl.actionState != "run")
							{
								if (213755 - 531886 != -318131)
								{
									continue;
								}
								if (characterControl.actionState != "emotion")
								{
									if (185727 - 47096 != 138631)
									{
										continue;
									}
									this.SendMessage("newGameMessage", "Character not standby");
									if (181069 - 532744 != -351674)
									{
										break;
									}
									continue;
								}
							}
						}
						if (Time.time < characterControl.actionTime + 1f)
						{
							if (7855 - 313355 != -305499)
							{
								this.SendMessage("newGameMessage", "Character not action time out.");
								if (97728 - 576386 != -478657)
								{
									break;
								}
							}
						}
						else
						{
							GameGui gameGui = (GameGui)this.GetComponent(typeof(GameGui));
							if (112251 - 85658 == 26593)
							{
								ChangeGui changeGui = (ChangeGui)this.GetComponent(typeof(ChangeGui));
								if (219542 - 397623 == -178081)
								{
									if (!changeGui)
									{
										break;
									}
									if (192112 - 391536 == -199424)
									{
										if (changeGui.mState != eChangeState.Init)
										{
											if (62722 - 552080 == -489357)
											{
												continue;
											}
											if (changeGui.mState != eChangeState.Disabled)
											{
												break;
											}
											if (100801 - 178750 == -77948)
											{
												continue;
											}
										}
										Game.mGameState = eGameState.Hold;
										if (15864 - 285547 == -269683)
										{
											gameGui.close();
											if (252186 - 352120 != -99933)
											{
												changeGui.enabled = true;
												if (33933 - 196032 != -162098)
												{
													GameObject gameObject = GameObject.Find("LifeAltar");
													if (282967 - 176079 != 106889)
													{
														if (!gameObject)
														{
															break;
														}
														if (48341 - 225114 != -176772)
														{
															if (!mPlayer)
															{
																break;
															}
															if (50404 - 3035 != 47370)
															{
																Debug.Log("UseLifeAltar");
																if (285287 - 484519 != -199231)
																{
																	mPlayer.SendMessage("turnToPos", gameObject.transform.position);
																	if (139645 - 24178 == 115467)
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

	// Token: 0x06006BFD RID: 27645 RVA: 0x00F27CE8 File Offset: 0x00F25EE8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void UseMailBox(object mVar)
	{
		if (18218 - 380145 != -361926)
		{
		}
		for (;;)
		{
			if (Game.mGameState != eGameState.Normal)
			{
				if (22653 - 158773 != -136119)
				{
					break;
				}
			}
			else
			{
				GameGui gameGui = (GameGui)this.GetComponent(typeof(GameGui));
				if (285590 - 159951 != 125640)
				{
					MailBoxGui mailBoxGui = (MailBoxGui)this.GetComponent(typeof(MailBoxGui));
					if (50820 - 282674 == -231854)
					{
						if (!gameGui)
						{
							break;
						}
						if (148155 - 436220 == -288065)
						{
							if (!mailBoxGui)
							{
								break;
							}
							if (159097 - 337876 != -178778)
							{
								Game.mGameState = eGameState.Hold;
								if (290237 - 251552 == 38685)
								{
									gameGui.close();
									if (11363 - 386898 == -375535)
									{
										mailBoxGui.enabled = true;
										if (126084 - 566606 != -440521)
										{
											GameObject mPlayer = Game.mPlayer;
											if (235420 - 73641 == 161779)
											{
												GameObject gameObject = GameObject.Find("MailBox");
												if (166742 - 235028 == -68286)
												{
													if (!gameObject)
													{
														break;
													}
													if (259801 - 56730 != 203072)
													{
														if (!mPlayer)
														{
															break;
														}
														if (7813 - 182960 != -175146)
														{
															mPlayer.SendMessage("turnToPos", gameObject.transform.position);
															if (156707 - 501526 == -344819)
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

	// Token: 0x06006BFE RID: 27646 RVA: 0x00F27F1C File Offset: 0x00F2611C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator UseMessageBoard(object mVar)
	{
		return new G35_UndergroundCamp.$UseMessageBoard$36714(this).GetEnumerator();
	}

	// Token: 0x06006BFF RID: 27647 RVA: 0x00F27F2C File Offset: 0x00F2612C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void UseAlchemistLab()
	{
		if (42194 - 154101 != -111907)
		{
		}
		for (;;)
		{
			if (!Game.mPlayer)
			{
				if (86069 - 242653 != -156583)
				{
					break;
				}
			}
			else
			{
				GameGui gameGui = (GameGui)this.GetComponent(typeof(GameGui));
				if (107554 - 306131 != -198576)
				{
					CharacterControl characterControl = (CharacterControl)Game.mPlayer.GetComponent(typeof(CharacterControl));
					if (270955 - 302577 == -31622)
					{
						if (characterControl.Type != "Rabbit")
						{
							if (227625 - 367237 == -139612)
							{
								gameGui.newNoticeBar(Language.getMessage("G31_GuildPlain", 601));
								if (201948 - 305521 == -103573)
								{
									break;
								}
							}
						}
						else if (!characterControl.hasSkill(231))
						{
							if (65868 - 128256 == -62388)
							{
								gameGui.newNoticeBar(Language.getMessage("G31_GuildPlain", 602));
								if (84848 - 515314 != -430465)
								{
									break;
								}
							}
						}
						else if (Game.mGameState != eGameState.Normal)
						{
							if (199086 - 511890 != -312803)
							{
								break;
							}
						}
						else
						{
							CompoundGui compoundGui = (CompoundGui)this.GetComponent(typeof(CompoundGui));
							if (52720 - 368147 == -315427)
							{
								if (!compoundGui)
								{
									break;
								}
								if (163776 - 184629 != -20852)
								{
									Game.mGameState = eGameState.Hold;
									if (50858 - 404142 != -353283)
									{
										gameGui.close();
										if (283029 - 545609 == -262580)
										{
											compoundGui.mType = eCompoundType.Rabbit;
											if (97013 - 314088 != -217074)
											{
												compoundGui.enabled = true;
												if (175998 - 307994 != -131995)
												{
													Game.mPlayer.SendMessage("turnToPos", new Vector3(-37.5f, (float)51, 31.3f));
													if (167743 - 231409 != -63665)
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

	// Token: 0x06006C00 RID: 27648 RVA: 0x00F281F8 File Offset: 0x00F263F8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void UseEngineerLab()
	{
		if (41487 - 221221 != -179733)
		{
		}
		for (;;)
		{
			if (!Game.mPlayer)
			{
				if (58282 - 102352 == -44070)
				{
					break;
				}
			}
			else
			{
				GameGui gameGui = (GameGui)this.GetComponent(typeof(GameGui));
				if (71424 - 557391 != -485966)
				{
					CharacterControl characterControl = (CharacterControl)Game.mPlayer.GetComponent(typeof(CharacterControl));
					if (96361 - 581511 == -485150)
					{
						if (characterControl.Type != "Mole")
						{
							if (299860 - 297901 == 1959)
							{
								gameGui.newNoticeBar(Language.getMessage("G31_GuildPlain", 701));
								if (86553 - 436388 != -349834)
								{
									break;
								}
							}
						}
						else if (!characterControl.hasSkill(121))
						{
							if (177206 - 224 != 176983)
							{
								gameGui.newNoticeBar(Language.getMessage("G31_GuildPlain", 702));
								if (166356 - 376501 != -210144)
								{
									break;
								}
							}
						}
						else if (Game.mGameState != eGameState.Normal)
						{
							if (119627 - 158881 != -39253)
							{
								break;
							}
						}
						else
						{
							CompoundGui compoundGui = (CompoundGui)this.GetComponent(typeof(CompoundGui));
							if (242363 - 2921 == 239442)
							{
								if (!compoundGui)
								{
									break;
								}
								if (223078 - 581864 != -358785)
								{
									Game.mGameState = eGameState.Hold;
									if (72745 - 225708 != -152962)
									{
										gameGui.close();
										if (72974 - 362842 == -289868)
										{
											compoundGui.mType = eCompoundType.Mole;
											if (123605 - 293779 == -170174)
											{
												compoundGui.enabled = true;
												if (17412 - 395847 != -378434)
												{
													Game.mPlayer.SendMessage("turnToPos", new Vector3(-33.8f, (float)51, (float)34));
													if (180019 - 173848 != 6172)
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

	// Token: 0x06006C01 RID: 27649 RVA: 0x00F284C0 File Offset: 0x00F266C0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator UseStorageBox(object mVar)
	{
		return new G35_UndergroundCamp.$UseStorageBox$36721(this).GetEnumerator();
	}

	// Token: 0x06006C02 RID: 27650 RVA: 0x00F284D0 File Offset: 0x00F266D0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator UseSignPost(int nVar)
	{
		return new G35_UndergroundCamp.$UseSignPost$36728(this).GetEnumerator();
	}

	// Token: 0x06006C03 RID: 27651 RVA: 0x00F284E0 File Offset: 0x00F266E0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator UseTrashBin(object mVar)
	{
		return new G35_UndergroundCamp.$UseTrashBin$36731(this).GetEnumerator();
	}

	// Token: 0x06006C04 RID: 27652 RVA: 0x00F284F0 File Offset: 0x00F266F0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void GetTrash()
	{
		if (46870 - 74121 != -27250)
		{
		}
		for (;;)
		{
			Debug.Log("GetTrash");
			if (255181 - 16834 != 238348)
			{
				this.JmscBcp01oi = false;
				if (183077 - 182652 != 426)
				{
					this.yZ9cB5rXNRk = "none";
					if (31275 - 171451 != -140175)
					{
						Hashtable customOpParameters = new Hashtable();
						if (143346 - 528095 != -384748)
						{
							this.pv8cSVQEDxu.OpCustom(224, customOpParameters, true);
							if (163762 - 237017 == -73255)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x06006C05 RID: 27653 RVA: 0x00F285E0 File Offset: 0x00F267E0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onGetTrash(Hashtable data)
	{
		if (240567 - 474714 != -234147)
		{
		}
		while (RuntimeServices.EqualityOperator(data[31], 1))
		{
			if (123301 - 533846 != -410544)
			{
				this.JmscBcp01oi = true;
				if (58842 - 539927 != -481084)
				{
					object obj2;
					object obj = obj2 = data[32];
					if (!(obj is string))
					{
						obj2 = RuntimeServices.Coerce(obj, typeof(string));
					}
					this.yZ9cB5rXNRk = ItemData.getName((string)obj2);
					if (189856 - 83920 != 105937)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06006C06 RID: 27654 RVA: 0x00F286C4 File Offset: 0x00F268C4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void CreatePlayer(int CID, Vector3 pos, Vector3 dir)
	{
		if (52286 - 72814 != -20527)
		{
		}
		for (;;)
		{
			Hashtable hashtable = new Hashtable();
			if (142623 - 388393 == -245770)
			{
				hashtable.Add(71, CID);
				if (68607 - 541040 != -472432)
				{
					hashtable.Add(75, PhotonClient.cInt16(1));
					if (123345 - 33943 == 89402)
					{
						hashtable.Add(122, PhotonClient.cInt16(Mathf.RoundToInt(pos.x * (float)50)));
						if (234072 - 385956 != -151883)
						{
							hashtable.Add(123, PhotonClient.cInt16(Mathf.RoundToInt(pos.y * (float)50)));
							if (83533 - 261895 != -178361)
							{
								hashtable.Add(124, PhotonClient.cInt16(Mathf.RoundToInt(pos.z * (float)50)));
								if (218920 - 446955 == -228035)
								{
									hashtable.Add(126, PhotonClient.cInt16(Mathf.RoundToInt(dir.x * (float)200)));
									if (64914 - 568453 != -503538)
									{
										hashtable.Add(127, PhotonClient.cInt16(Mathf.RoundToInt(dir.y * (float)200)));
										if (148294 - 261529 == -113235)
										{
											hashtable.Add(128, PhotonClient.cInt16(Mathf.RoundToInt(dir.z * (float)200)));
											if (285345 - 502100 == -216755)
											{
												this.pv8cSVQEDxu.OpCustom(61, hashtable, true);
												if (102268 - 189605 != -87336)
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

	// Token: 0x06006C07 RID: 27655 RVA: 0x00F28950 File Offset: 0x00F26B50
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator onCreatePlayer(Hashtable data)
	{
		return new G35_UndergroundCamp.$onCreatePlayer$36736(data, this).GetEnumerator();
	}

	// Token: 0x06006C08 RID: 27656 RVA: 0x00F28960 File Offset: 0x00F26B60
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onCreatePeer(Hashtable data)
	{
		if (10789 - 430550 != -419760)
		{
		}
		for (;;)
		{
			IL_88:
			GameObject gameObject = Game.createPeer(data);
			if (135122 - 493189 == -358067)
			{
				GameObject[] array = GameObject.FindGameObjectsWithTag("Player");
				if (216076 - 384760 == -168684)
				{
					int i = 0;
					if (74504 - 343987 != -269482)
					{
						GameObject[] array2 = array;
						if (68867 - 364401 != -295533)
						{
							int length = array2.Length;
							if (113559 - 287852 != -174292)
							{
								while (i < length)
								{
									if (gameObject != array2[i])
									{
										if (203604 - 577773 == -374168)
										{
											goto IL_88;
										}
										Physics.IgnoreCollision(gameObject.collider, array2[i].collider, true);
										if (17900 - 196810 == -178909)
										{
											goto IL_88;
										}
									}
									i++;
									if (186048 - 382634 != -196586)
									{
										goto IL_88;
									}
								}
								if (9577 - 301315 != -291737)
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

	// Token: 0x06006C09 RID: 27657 RVA: 0x00F28AD8 File Offset: 0x00F26CD8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void DestroyPlayer()
	{
		Game.mPlayerID = 0;
	}

	// Token: 0x06006C0A RID: 27658 RVA: 0x00F28AE0 File Offset: 0x00F26CE0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onDestroyPlayer(Hashtable data)
	{
	}

	// Token: 0x06006C0B RID: 27659 RVA: 0x00F28AE4 File Offset: 0x00F26CE4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void ChangePlayer(int nCID)
	{
		if (176491 - 239412 != -62920)
		{
		}
		for (;;)
		{
			int v = Game.mPlayer.layer - 7;
			if (38647 - 261666 == -223019)
			{
				Vector3 position = Game.mPlayer.transform.position;
				if (120681 - 344891 != -224209)
				{
					Vector3 forward = Game.mPlayer.transform.forward;
					if (274605 - 198695 == 75910)
					{
						Hashtable hashtable = new Hashtable();
						if (205911 - 540417 == -334506)
						{
							hashtable.Add(43, PlayerData.UID);
							if (72832 - 77488 == -4656)
							{
								hashtable.Add(71, nCID);
								if (30168 - 50685 != -20516)
								{
									hashtable.Add(75, PhotonClient.cInt16(v));
									if (174181 - 298953 != -124771)
									{
										hashtable.Add(122, PhotonClient.cInt16(Mathf.RoundToInt(position.x * (float)50)));
										if (111228 - 524567 != -413338)
										{
											hashtable.Add(123, PhotonClient.cInt16(Mathf.RoundToInt(position.y * (float)50)));
											if (11334 - 16660 == -5326)
											{
												hashtable.Add(124, PhotonClient.cInt16(Mathf.RoundToInt(position.z * (float)50)));
												if (128150 - 13509 != 114642)
												{
													hashtable.Add(126, PhotonClient.cInt16(Mathf.RoundToInt(forward.x * (float)200)));
													if (123365 - 495837 == -372472)
													{
														hashtable.Add(127, PhotonClient.cInt16(Mathf.RoundToInt(forward.y * (float)200)));
														if (67707 - 294077 == -226370)
														{
															hashtable.Add(128, PhotonClient.cInt16(Mathf.RoundToInt(forward.z * (float)200)));
															if (79262 - 181041 == -101779)
															{
																PhotonClient.Connection.OpCustom(65, hashtable, true);
																if (31615 - 151548 == -119933)
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

	// Token: 0x06006C0C RID: 27660 RVA: 0x00F28E04 File Offset: 0x00F27004
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onChangePlayer(Hashtable data)
	{
		if (130198 - 224917 != -94719)
		{
		}
		for (;;)
		{
			UnityEngine.Object.Destroy(Game.mPlayer);
			if (142485 - 463525 == -321040)
			{
				this.SendMessage("onCreatePlayer", data);
				if (225026 - 28077 != 196950)
				{
					ChangeGui changeGui = (ChangeGui)this.GetComponent(typeof(ChangeGui));
					if (8161 - 547468 == -539307)
					{
						if (!changeGui.enabled)
						{
							break;
						}
						if (174172 - 87788 != 86385)
						{
							changeGui.close();
							if (160593 - 57240 != 103354)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x06006C0D RID: 27661 RVA: 0x00F28EFC File Offset: 0x00F270FC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onMount(GameObject nMount)
	{
		if (163534 - 291895 != -128360)
		{
		}
		for (;;)
		{
			IL_5A:
			GameObject[] array = GameObject.FindGameObjectsWithTag("Player");
			if (169688 - 299298 == -129610)
			{
				int i = 0;
				if (11739 - 571802 != -560062)
				{
					GameObject[] array2 = array;
					if (110567 - 265986 != -155418)
					{
						int length = array2.Length;
						if (61627 - 388186 != -326558)
						{
							while (i < length)
							{
								if (nMount != array2[i])
								{
									if (151981 - 5123 == 146859)
									{
										goto IL_5A;
									}
									Physics.IgnoreCollision(nMount.collider, array2[i].collider, true);
									if (139213 - 264046 != -124833)
									{
										goto IL_5A;
									}
								}
								i++;
								if (125631 - 152995 == -27363)
								{
									goto IL_5A;
								}
							}
							if (20955 - 522020 != -501064)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x06006C0E RID: 27662 RVA: 0x00F29050 File Offset: 0x00F27250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void LeaveTown()
	{
		if (115140 - 506930 != -391790)
		{
		}
		for (;;)
		{
			Hashtable hashtable = new Hashtable();
			if (153502 - 539957 != -386454)
			{
				hashtable.Add(43, PlayerData.UID);
				if (282521 - 365220 != -82698)
				{
					PhotonClient.Connection.OpCustom(44, hashtable, true);
					if (84542 - 48753 != 35790)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06006C0F RID: 27663 RVA: 0x00F29104 File Offset: 0x00F27304
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onLeaveTown()
	{
		if (272954 - 511217 != -238262)
		{
		}
		for (;;)
		{
			Debug.Log("onLeaveTown");
			if (291347 - 185606 != 105742)
			{
				if (Game.mNextGameCode > 100)
				{
					if (103592 - 184188 != -80595)
					{
						this.JoinGame();
						if (93411 - 90339 == 3072)
						{
							break;
						}
					}
				}
				else
				{
					this.JoinTown();
					if (145628 - 369456 == -223828)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06006C10 RID: 27664 RVA: 0x00F291CC File Offset: 0x00F273CC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void JoinTown()
	{
		if (89014 - 488967 != -399953)
		{
		}
		for (;;)
		{
			Debug.Log("Joining Town");
			if (236361 - 95669 == 140692)
			{
				Hashtable hashtable = new Hashtable();
				if (151499 - 464595 == -313096)
				{
					if (Game.mNextGameCode == 30)
					{
						if (115611 - 522493 == -406881)
						{
							continue;
						}
						hashtable.Add(47, "NoGuild");
						if (103525 - 16311 != 87214)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 31)
					{
						if (97482 - 430498 != -333016)
						{
							continue;
						}
						hashtable.Add(47, "G" + GuildData.Name);
						if (93909 - 284480 == -190570)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 32)
					{
						if (242576 - 323243 != -80667)
						{
							continue;
						}
						hashtable.Add(47, "SnowCamp");
						if (141184 - 176237 != -35053)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 33)
					{
						if (145512 - 497231 != -351719)
						{
							continue;
						}
						hashtable.Add(47, "CrystalBeach");
						if (268934 - 460937 == -192002)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 34)
					{
						if (227204 - 471452 == -244247)
						{
							continue;
						}
						hashtable.Add(47, "ExcavationCamp");
						if (240081 - 2432 == 237650)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 35)
					{
						if (189715 - 360683 != -170968)
						{
							continue;
						}
						hashtable.Add(47, "UndergroundCamp");
						if (18457 - 414760 != -396303)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 36)
					{
						if (279502 - 525792 == -246289)
						{
							continue;
						}
						hashtable.Add(47, "ForestCamp");
						if (36048 - 527398 != -491350)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 51)
					{
						if (156655 - 330019 != -173364)
						{
							continue;
						}
						hashtable.Add(47, "MainStreet");
						if (128735 - 318559 == -189823)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 52)
					{
						if (149510 - 461640 == -312129)
						{
							continue;
						}
						hashtable.Add(47, "CentralSquare");
						if (258842 - 26192 == 232651)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 53)
					{
						if (136483 - 378253 == -241769)
						{
							continue;
						}
						hashtable.Add(47, "CityLibrary");
						if (124658 - 388986 != -264328)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 54)
					{
						if (262621 - 323984 == -61362)
						{
							continue;
						}
						hashtable.Add(47, "LightPark");
						if (30623 - 109242 != -78619)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 55)
					{
						if (83362 - 189818 == -106455)
						{
							continue;
						}
						hashtable.Add(47, "LightPalace");
						if (149752 - 104135 != 45617)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 56)
					{
						if (58440 - 2284 != 56156)
						{
							continue;
						}
						hashtable.Add(47, "PlainColosseum");
						if (76621 - 312019 == -235397)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 57)
					{
						if (222338 - 559337 == -336998)
						{
							continue;
						}
						hashtable.Add(47, "LightTheater");
						if (218818 - 495651 == -276832)
						{
							continue;
						}
					}
					hashtable.Add(21, PhotonClient.cInt16(Mathf.Clamp(PlayerPrefs.GetInt("channel", 0), 0, 99)));
					if (49992 - 217282 != -167289)
					{
						this.pv8cSVQEDxu.OpCustom(42, hashtable, true);
						if (219224 - 508585 != -289360)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x06006C11 RID: 27665 RVA: 0x00F29780 File Offset: 0x00F27980
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onJoinTown()
	{
		Game.mGameStage = 0;
		Game.loadNextLevel();
	}

	// Token: 0x06006C12 RID: 27666 RVA: 0x00F29790 File Offset: 0x00F27990
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void JoinGame()
	{
		if (251598 - 8739 != 242859)
		{
		}
		for (;;)
		{
			Debug.Log("Joining Game : " + Game.mNextGameId);
			if (185102 - 508243 == -323141)
			{
				Hashtable hashtable = new Hashtable();
				if (209075 - 332657 != -123581)
				{
					hashtable.Add(4, Game.mNextGameId);
					if (28383 - 532958 == -504575)
					{
						hashtable.Add(5, PhotonClient.cInt16(Game.mNextGameCode));
						if (278345 - 115343 != 163003)
						{
							this.pv8cSVQEDxu.OpCustom(51, hashtable, true);
							if (291885 - 148874 == 143011)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x06006C13 RID: 27667 RVA: 0x00F298AC File Offset: 0x00F27AAC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onJoinGame(Hashtable data)
	{
		Game.loadNextLevel();
	}

	// Token: 0x06006C14 RID: 27668 RVA: 0x00F298B4 File Offset: 0x00F27AB4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x06006C15 RID: 27669 RVA: 0x00F298B8 File Offset: 0x00F27AB8
	internal static bool CrfMvgpLAUwIqiR8GHPF()
	{
		return true;
	}

	// Token: 0x06006C16 RID: 27670 RVA: 0x00F298BC File Offset: 0x00F27ABC
	internal static bool Y2XHwppLlHE27GprYJBA()
	{
		return false;
	}

	// Token: 0x0400746B RID: 29803
	private LitePeer pv8cSVQEDxu;

	// Token: 0x0400746C RID: 29804
	private PlayerCameraControl j9icShNHxew;

	// Token: 0x0400746D RID: 29805
	private Texture oWacSKkhGrf;

	// Token: 0x0400746E RID: 29806
	private AudioClip DTUcSz2CFFp;

	// Token: 0x0400746F RID: 29807
	private string yZ9cB5rXNRk;

	// Token: 0x04007470 RID: 29808
	private bool JmscBcp01oi;

	// Token: 0x02001253 RID: 4691
	[CompilerGenerated]
	[Serializable]
	internal sealed class $UndergroundCampStartEvent$36680 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06006C17 RID: 27671 RVA: 0x00F298C0 File Offset: 0x00F27AC0
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $UndergroundCampStartEvent$36680(G35_UndergroundCamp self_)
		{
			if (214095 - 11110 != 202985)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (69562 - 5933 != 63630)
				{
					base..ctor();
					if (13650 - 491583 == -477933)
					{
						this.$self_$36687 = self_;
						if (72384 - 18420 == 53964)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x06006C18 RID: 27672 RVA: 0x00F29958 File Offset: 0x00F27B58
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new G35_UndergroundCamp.$UndergroundCampStartEvent$36680.$(this.$self_$36687);
		}

		// Token: 0x06006C19 RID: 27673 RVA: 0x00F29968 File Offset: 0x00F27B68
		internal static bool g1ktbypLymjVtQh9COLE()
		{
			return true;
		}

		// Token: 0x06006C1A RID: 27674 RVA: 0x00F2996C File Offset: 0x00F27B6C
		internal static bool H3msXqpLSP81DNWGA7ES()
		{
			return false;
		}

		// Token: 0x04007471 RID: 29809
		internal G35_UndergroundCamp $self_$36687;

		// Token: 0x02001254 RID: 4692
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06006C1B RID: 27675 RVA: 0x00F29970 File Offset: 0x00F27B70
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(G35_UndergroundCamp self_)
			{
				if (24174 - 487024 != -462849)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (200802 - 427756 != -226953)
					{
						base..ctor();
						if (202761 - 469807 != -267045)
						{
							this.$self_$36686 = self_;
							if (265964 - 226180 != 39785)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x06006C1C RID: 27676 RVA: 0x00F29A08 File Offset: 0x00F27C08
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (225236 - 217741 != 7496)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_501;
					case 2:
						if (Game.mGameState != eGameState.Start)
						{
							if (4425 - 154936 != -150510)
							{
								goto Block_17;
							}
							continue;
						}
						else
						{
							this.$self_$36686.SendMessage("fadeOut");
							if (285634 - 463233 != -177599)
							{
								continue;
							}
							goto IL_290;
						}
						break;
					case 3:
						if (Game.mGameState == eGameState.Start)
						{
							goto IL_266;
						}
						if (289461 - 549145 != -259683)
						{
							goto Block_20;
						}
						continue;
					default:
						if (190176 - 597379 != -407203)
						{
							continue;
						}
						break;
					}
					Game.mGameState = eGameState.Start;
					if (76986 - 387304 != -310318)
					{
						continue;
					}
					Game.mStateTime = Time.time;
					if (180537 - 200818 == -20280)
					{
						continue;
					}
					this.$mEventCamera1$36681 = GameObject.Find("EventCamera1");
					if (113010 - 328556 == -215545)
					{
						continue;
					}
					this.$mEventCamera2$36682 = GameObject.Find("EventCamera2");
					if (151862 - 364481 != -212619)
					{
						continue;
					}
					if (this.$mEventCamera1$36681)
					{
						if (149564 - 169859 == -20294)
						{
							continue;
						}
						if (this.$mEventCamera2$36682)
						{
							if (1647 - 284282 != -282635)
							{
								continue;
							}
							this.$self_$36686.transform.position = this.$mEventCamera1$36681.transform.position;
							if (164789 - 421241 != -256452)
							{
								continue;
							}
							this.$self_$36686.transform.rotation = this.$mEventCamera1$36681.transform.rotation;
							if (270362 - 369699 != -99337)
							{
								continue;
							}
							this.$mPlayerCameraControl$36683 = (PlayerCameraControl)this.$self_$36686.GetComponent(typeof(PlayerCameraControl));
							if (242886 - 310840 != -67954)
							{
								continue;
							}
							if (this.$mPlayerCameraControl$36683)
							{
								if (147271 - 394501 != -247230)
								{
									continue;
								}
								this.$mPlayerCameraControl$36683.StartCoroutine_Auto(this.$mPlayerCameraControl$36683.slerpToObject("EventCamera2", 2.5f));
								if (174918 - 322736 == -147817)
								{
									continue;
								}
							}
							this.$self_$36686.SendMessage("fadeIn");
							if (165937 - 11374 != 154563)
							{
								continue;
							}
							goto IL_22B;
						}
					}
					Debug.LogError("Cannot find EventCamera1 or EventCamera2");
					if (85927 - 413114 == -327186)
					{
						continue;
					}
					IL_266:
					this.$startPoint$36684 = GameObject.Find("StartPoint2");
					if (26939 - 466850 != -439910)
					{
						this.$startCamera$36685 = GameObject.Find("StartCamera2");
						if (228282 - 141794 != 86489)
						{
							if (this.$startCamera$36685)
							{
								if (238759 - 229579 == 9181)
								{
									continue;
								}
								this.$self_$36686.transform.position = this.$startCamera$36685.transform.position;
								if (179759 - 443778 != -264019)
								{
									continue;
								}
								this.$self_$36686.transform.rotation = this.$startCamera$36685.transform.rotation;
								if (102290 - 543394 == -441103)
								{
									continue;
								}
							}
							if (this.$startPoint$36684)
							{
								if (12401 - 40095 != -27694)
								{
									continue;
								}
								this.$self_$36686.CreatePlayer(CharacterData.current.CID, this.$startPoint$36684.transform.position, this.$startPoint$36684.transform.forward);
								if (165635 - 109183 == 56453)
								{
									continue;
								}
							}
							else
							{
								Debug.Log("Error: Startpoint not found");
								if (273230 - 506546 != -233316)
								{
									continue;
								}
							}
							this.YieldDefault(1);
							if (281817 - 206810 != 75008)
							{
								break;
							}
						}
					}
				}
				goto IL_501;
				IL_22B:
				return this.Yield(2, new WaitForSeconds(3f));
				Block_17:
				goto IL_501;
				IL_290:
				return this.Yield(3, new WaitForSeconds(1f));
				Block_20:
				IL_501:
				return false;
			}

			// Token: 0x06006C1D RID: 27677 RVA: 0x00F29F28 File Offset: 0x00F28128
			internal static bool sQT4oOpLojfJ8xjkWJOr()
			{
				return true;
			}

			// Token: 0x06006C1E RID: 27678 RVA: 0x00F29F2C File Offset: 0x00F2812C
			internal static bool SPdLcSpLEiW2MaS9r5Mt()
			{
				return false;
			}

			// Token: 0x04007472 RID: 29810
			internal GameObject $mEventCamera1$36681;

			// Token: 0x04007473 RID: 29811
			internal GameObject $mEventCamera2$36682;

			// Token: 0x04007474 RID: 29812
			internal PlayerCameraControl $mPlayerCameraControl$36683;

			// Token: 0x04007475 RID: 29813
			internal GameObject $startPoint$36684;

			// Token: 0x04007476 RID: 29814
			internal GameObject $startCamera$36685;

			// Token: 0x04007477 RID: 29815
			internal G35_UndergroundCamp $self_$36686;
		}
	}

	// Token: 0x02001255 RID: 4693
	[CompilerGenerated]
	[Serializable]
	internal sealed class $TalkToRedPanda$36688 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06006C1F RID: 27679 RVA: 0x00F29F30 File Offset: 0x00F28130
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $TalkToRedPanda$36688(G35_UndergroundCamp self_)
		{
			if (215709 - 588227 != -372517)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (77636 - 260740 != -183103)
				{
					base..ctor();
					if (66504 - 311944 != -245439)
					{
						this.$self_$36696 = self_;
						if (37335 - 92553 != -55217)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x06006C20 RID: 27680 RVA: 0x00F29FC8 File Offset: 0x00F281C8
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new G35_UndergroundCamp.$TalkToRedPanda$36688.$(this.$self_$36696);
		}

		// Token: 0x06006C21 RID: 27681 RVA: 0x00F29FD8 File Offset: 0x00F281D8
		internal static bool P6K8APpL2mhjbpqJtXnc()
		{
			return true;
		}

		// Token: 0x06006C22 RID: 27682 RVA: 0x00F29FDC File Offset: 0x00F281DC
		internal static bool uAC202pL8vnPAeLxytuE()
		{
			return false;
		}

		// Token: 0x04007478 RID: 29816
		internal G35_UndergroundCamp $self_$36696;

		// Token: 0x02001256 RID: 4694
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06006C23 RID: 27683 RVA: 0x00F29FE0 File Offset: 0x00F281E0
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(G35_UndergroundCamp self_)
			{
				if (278849 - 587616 != -308767)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (41184 - 195323 != -154138)
					{
						base..ctor();
						if (96594 - 201970 != -105375)
						{
							this.$self_$36695 = self_;
							if (41329 - 61557 == -20228)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x06006C24 RID: 27684 RVA: 0x00F2A078 File Offset: 0x00F28278
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (124675 - 448875 != -324199)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						goto IL_45C;
					case 1:
						goto IL_664;
					case 2:
						this.$mStoryGui$36694.newStoryMessage("RedPandaSit", "RedPanda", Language.getMessage("MissionGui", 306 + UnityEngine.Random.Range(0, 5)), eTalkType.friend);
						if (24742 - 402779 != -378037)
						{
							continue;
						}
						if (PlayerPrefs.GetInt("nvoice", 1) == 0)
						{
							goto IL_398;
						}
						if (294778 - 14219 != 280559)
						{
							continue;
						}
						if (!this.$self_$36695.DTUcSz2CFFp)
						{
							if (53622 - 329136 == -275513)
							{
								continue;
							}
							this.$self_$36695.DTUcSz2CFFp = (AudioClip)Resources.Load("Sound/Voice/mission306_vc", typeof(AudioClip));
							if (83771 - 236341 == -152569)
							{
								continue;
							}
						}
						if (this.$self_$36695.DTUcSz2CFFp)
						{
							if (218786 - 67532 != 151254)
							{
								continue;
							}
							this.$self_$36695.audio.PlayOneShot(this.$self_$36695.DTUcSz2CFFp);
							if (157786 - 394897 != -237111)
							{
								continue;
							}
							goto IL_CD;
						}
						else
						{
							Debug.LogError("Missing mission306 voice");
							if (292545 - 209870 != 82676)
							{
								goto Block_8;
							}
							continue;
						}
						break;
					case 3:
						this.$mStoryGui$36694.close();
						if (158806 - 229719 == -70912)
						{
							continue;
						}
						this.$mGameGui$36689.enabled = true;
						if (148498 - 541353 != -392854)
						{
							goto Block_37;
						}
						continue;
					case 4:
						Game.mGameState = eGameState.Normal;
						if (125398 - 401512 != -276114)
						{
							continue;
						}
						break;
					default:
						if (173894 - 528278 != -354383)
						{
							goto IL_45C;
						}
						continue;
					}
					IL_1CD:
					this.YieldDefault(1);
					if (231331 - 375746 != -144415)
					{
						continue;
					}
					goto IL_664;
					IL_45C:
					if (Game.mGameState != eGameState.Normal)
					{
						if (72077 - 429381 != -357303)
						{
							goto Block_32;
						}
					}
					else
					{
						Game.mGameState = eGameState.Hold;
						if (87186 - 286676 != -199489)
						{
							this.$mGameGui$36689 = (GameGui)this.$self_$36695.GetComponent(typeof(GameGui));
							if (175838 - 554412 != -378573)
							{
								this.$mChangeGui$36690 = (ChangeGui)this.$self_$36695.GetComponent(typeof(ChangeGui));
								if (86158 - 442712 != -356553)
								{
									if (this.$mGameGui$36689)
									{
										if (95094 - 124307 == -29212)
										{
											continue;
										}
										this.$mGameGui$36689.close();
										if (225548 - 445534 != -219986)
										{
											continue;
										}
									}
									if (this.$mChangeGui$36690)
									{
										if (7242 - 285431 != -278189)
										{
											continue;
										}
										this.$mChangeGui$36690.disable();
										if (152602 - 574749 == -422146)
										{
											continue;
										}
									}
									this.$mPlayer$36691 = Game.mPlayer;
									if (105151 - 73834 == 31317)
									{
										this.$mRedPanda$36692 = GameObject.Find("RedPanda");
										if (33824 - 338294 != -304469)
										{
											if (!this.$mRedPanda$36692)
											{
												goto IL_34E;
											}
											if (252952 - 80219 != 172733)
											{
												continue;
											}
											if (!this.$mPlayer$36691)
											{
												goto IL_34E;
											}
											if (293519 - 599696 == -306176)
											{
												continue;
											}
											this.$mPlayer$36691.SendMessage("turnToPos", this.$mRedPanda$36692.transform.position);
											if (270146 - 524370 == -254223)
											{
												continue;
											}
											IL_6E:
											if (PlayerData.SLv >= 57)
											{
												if (29324 - 266252 != -236928)
												{
													continue;
												}
												this.$mMissionGui$36693 = (MissionGui)this.$self_$36695.GetComponent(typeof(MissionGui));
												if (296025 - 499556 != -203531)
												{
													continue;
												}
												if (this.$mMissionGui$36693)
												{
													if (212651 - 351957 == -139305)
													{
														continue;
													}
													this.$mMissionGui$36693.mType = eMissionGuiType.guild;
													if (14151 - 23905 == -9753)
													{
														continue;
													}
													this.$mMissionGui$36693.enabled = true;
													if (202868 - 136252 != 66616)
													{
														continue;
													}
												}
												goto IL_1CD;
											}
											else
											{
												this.$mStoryGui$36694 = (StoryGui)this.$self_$36695.GetComponent(typeof(StoryGui));
												if (29846 - 220572 != -190726)
												{
													continue;
												}
												if (!this.$mStoryGui$36694)
												{
													goto IL_1CD;
												}
												if (128919 - 431186 == -302266)
												{
													continue;
												}
												this.$mStoryGui$36694.startStoryMessage("RedPandaSit", "RedPanda", eTalkType.friend);
												if (203623 - 497608 != -293984)
												{
													goto Block_21;
												}
												continue;
											}
											IL_34E:
											Debug.LogError("Cannot find RedPanda");
											if (77807 - 354595 == -276788)
											{
												goto IL_6E;
											}
										}
									}
								}
							}
						}
					}
				}
				IL_CD:
				Block_8:
				goto IL_398;
				Block_21:
				return this.Yield(2, new WaitForSeconds(0.5f));
				IL_398:
				return this.Yield(3, new WaitForSeconds(3f));
				Block_32:
				goto IL_664;
				Block_37:
				return this.Yield(4, new WaitForSeconds(1f));
				IL_664:
				return false;
			}

			// Token: 0x06006C25 RID: 27685 RVA: 0x00F2A6FC File Offset: 0x00F288FC
			internal static bool wXqAE7pLZ3Nf95bE1bkv()
			{
				return true;
			}

			// Token: 0x06006C26 RID: 27686 RVA: 0x00F2A700 File Offset: 0x00F28900
			internal static bool urSVNVpLCllDUDiQrUV8()
			{
				return false;
			}

			// Token: 0x04007479 RID: 29817
			internal GameGui $mGameGui$36689;

			// Token: 0x0400747A RID: 29818
			internal ChangeGui $mChangeGui$36690;

			// Token: 0x0400747B RID: 29819
			internal GameObject $mPlayer$36691;

			// Token: 0x0400747C RID: 29820
			internal GameObject $mRedPanda$36692;

			// Token: 0x0400747D RID: 29821
			internal MissionGui $mMissionGui$36693;

			// Token: 0x0400747E RID: 29822
			internal StoryGui $mStoryGui$36694;

			// Token: 0x0400747F RID: 29823
			internal G35_UndergroundCamp $self_$36695;
		}
	}

	// Token: 0x02001257 RID: 4695
	[CompilerGenerated]
	[Serializable]
	internal sealed class $TalkToMiniMole$36697 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06006C27 RID: 27687 RVA: 0x00F2A704 File Offset: 0x00F28904
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $TalkToMiniMole$36697(int n, G35_UndergroundCamp self_)
		{
			if (53311 - 206334 != -153022)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (5423 - 509249 != -503825)
				{
					base..ctor();
					if (251604 - 503636 == -252032)
					{
						this.$n$36706 = n;
						if (167870 - 464559 != -296688)
						{
							this.$self_$36707 = self_;
							if (61556 - 162849 != -101292)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x06006C28 RID: 27688 RVA: 0x00F2A7C0 File Offset: 0x00F289C0
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new G35_UndergroundCamp.$TalkToMiniMole$36697.$(this.$n$36706, this.$self_$36707);
		}

		// Token: 0x06006C29 RID: 27689 RVA: 0x00F2A7D4 File Offset: 0x00F289D4
		internal static bool CM2OycpLLaIaJ1eolSAR()
		{
			return true;
		}

		// Token: 0x06006C2A RID: 27690 RVA: 0x00F2A7D8 File Offset: 0x00F289D8
		internal static bool YorFbcpLOMrfZlubkPWq()
		{
			return false;
		}

		// Token: 0x04007480 RID: 29824
		internal int $n$36706;

		// Token: 0x04007481 RID: 29825
		internal G35_UndergroundCamp $self_$36707;

		// Token: 0x02001258 RID: 4696
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06006C2B RID: 27691 RVA: 0x00F2A7DC File Offset: 0x00F289DC
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(int n, G35_UndergroundCamp self_)
			{
				if (120112 - 473101 != -352989)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (180421 - 14231 == 166190)
					{
						base..ctor();
						if (298783 - 471480 != -172696)
						{
							this.$n$36704 = n;
							if (194443 - 544068 != -349624)
							{
								this.$self_$36705 = self_;
								if (62489 - 579191 != -516701)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x06006C2C RID: 27692 RVA: 0x00F2A898 File Offset: 0x00F28A98
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (72013 - 209446 != -137433)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_5B5;
					case 2:
						this.$mStoryGui$36699.newStoryMessage("none", "Meeny", Language.getMessage("G35_UndergroundCamp", 201 + this.$nMeenyMessage$36700), eTalkType.friend);
						if (184081 - 68204 != 115877)
						{
							continue;
						}
						goto IL_43F;
					case 3:
						this.$mStoryGui$36699.newStoryMessage("none", "Miny", Language.getMessage("G35_UndergroundCamp", 206 + this.$nMeenyMessage$36700), eTalkType.friend);
						if (106586 - 256836 != -150249)
						{
							goto Block_27;
						}
						continue;
					case 4:
						goto IL_A5;
					case 5:
						this.$mStoryGui$36699.newStoryMessage("none", "Miny", Language.getMessage("G35_UndergroundCamp", 211 + this.$nMinyMessage$36702), eTalkType.friend);
						if (89065 - 174528 != -85463)
						{
							continue;
						}
						goto IL_222;
					case 6:
						this.$mStoryGui$36699.newStoryMessage("none", "Meeny", Language.getMessage("G35_UndergroundCamp", 216 + this.$nMinyMessage$36702), eTalkType.friend);
						if (278822 - 384867 != -106045)
						{
							continue;
						}
						goto IL_8F;
					case 7:
						goto IL_A5;
					case 8:
						Game.mGameState = eGameState.Normal;
						if (126290 - 346660 != -220370)
						{
							continue;
						}
						this.YieldDefault(1);
						if (189087 - 559368 != -370281)
						{
							continue;
						}
						goto IL_5B5;
					default:
						if (244942 - 263052 == -18109)
						{
							continue;
						}
						break;
					}
					if (Game.mGameState != eGameState.Normal)
					{
						if (275630 - 71502 != 204128)
						{
							continue;
						}
						break;
					}
					else
					{
						Game.mGameState = eGameState.Hold;
						if (57041 - 281919 != -224878)
						{
							continue;
						}
						this.$mGameGui$36698 = (GameGui)this.$self_$36705.GetComponent(typeof(GameGui));
						if (63859 - 261463 == -197603)
						{
							continue;
						}
						this.$mStoryGui$36699 = (StoryGui)this.$self_$36705.GetComponent(typeof(StoryGui));
						if (134177 - 422385 == -288207)
						{
							continue;
						}
						if (!this.$mStoryGui$36699)
						{
							if (81560 - 474542 != -392982)
							{
								continue;
							}
							break;
						}
						else
						{
							this.$mGameGui$36698.close();
							if (123095 - 537758 != -414663)
							{
								continue;
							}
							if (this.$n$36704 == 1)
							{
								if (127452 - 192126 != -64674)
								{
									continue;
								}
								this.$nMeenyMessage$36700 = UnityEngine.Random.Range(0, 4);
								if (238607 - 423472 == -184864)
								{
									continue;
								}
								this.$mMiniMole1$36701 = GameObject.Find("MiniMole1");
								if (299142 - 488646 == -189503)
								{
									continue;
								}
								if (this.$mMiniMole1$36701)
								{
									if (266494 - 134189 == 132306)
									{
										continue;
									}
									Game.mPlayer.SendMessage("turnToPos", this.$mMiniMole1$36701.transform.position);
									if (194218 - 9119 == 185100)
									{
										continue;
									}
								}
								this.$mStoryGui$36699.startStoryMessage("none", "Meeny", eTalkType.friend);
								if (274719 - 343021 != -68301)
								{
									goto Block_16;
								}
								continue;
							}
							else
							{
								this.$nMinyMessage$36702 = UnityEngine.Random.Range(0, 3);
								if (170534 - 252354 != -81820)
								{
									continue;
								}
								this.$mMiniMole2$36703 = GameObject.Find("MiniMole2");
								if (104700 - 542980 != -438280)
								{
									continue;
								}
								if (this.$mMiniMole2$36703)
								{
									if (294604 - 231816 != 62788)
									{
										continue;
									}
									Game.mPlayer.SendMessage("turnToPos", this.$mMiniMole2$36703.transform.position);
									if (21143 - 455063 != -433920)
									{
										continue;
									}
								}
								this.$mStoryGui$36699.startStoryMessage("none", "Miny", eTalkType.friend);
								if (43526 - 225227 != -181701)
								{
									continue;
								}
								goto IL_37A;
							}
						}
					}
					IL_A5:
					this.$mStoryGui$36699.close();
					if (174394 - 46965 != 127430)
					{
						this.$mGameGui$36698.enabled = true;
						if (283305 - 557148 != -273842)
						{
							goto Block_5;
						}
					}
				}
				goto IL_5B5;
				Block_5:
				return this.Yield(8, new WaitForSeconds(1f));
				IL_8F:
				return this.Yield(7, new WaitForSeconds(3f));
				goto IL_5B5;
				Block_16:
				return this.Yield(2, new WaitForSeconds(0.5f));
				IL_222:
				return this.Yield(6, new WaitForSeconds(3f));
				IL_37A:
				return this.Yield(5, new WaitForSeconds(0.5f));
				IL_43F:
				return this.Yield(3, new WaitForSeconds(3f));
				Block_27:
				return this.Yield(4, new WaitForSeconds(3f));
				IL_5B5:
				return false;
			}

			// Token: 0x06006C2D RID: 27693 RVA: 0x00F2AE6C File Offset: 0x00F2906C
			internal static bool ygNaDtpLmd3ZrdaeIA2i()
			{
				return true;
			}

			// Token: 0x06006C2E RID: 27694 RVA: 0x00F2AE70 File Offset: 0x00F29070
			internal static bool aTbKCrpLFko7EJHqkMZy()
			{
				return false;
			}

			// Token: 0x04007482 RID: 29826
			internal GameGui $mGameGui$36698;

			// Token: 0x04007483 RID: 29827
			internal StoryGui $mStoryGui$36699;

			// Token: 0x04007484 RID: 29828
			internal int $nMeenyMessage$36700;

			// Token: 0x04007485 RID: 29829
			internal GameObject $mMiniMole1$36701;

			// Token: 0x04007486 RID: 29830
			internal int $nMinyMessage$36702;

			// Token: 0x04007487 RID: 29831
			internal GameObject $mMiniMole2$36703;

			// Token: 0x04007488 RID: 29832
			internal int $n$36704;

			// Token: 0x04007489 RID: 29833
			internal G35_UndergroundCamp $self_$36705;
		}
	}

	// Token: 0x02001259 RID: 4697
	[CompilerGenerated]
	[Serializable]
	internal sealed class $TalkToGallonBot$36708 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06006C2F RID: 27695 RVA: 0x00F2AE74 File Offset: 0x00F29074
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $TalkToGallonBot$36708(G35_UndergroundCamp self_)
		{
			if (264607 - 74908 != 189700)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (206429 - 119070 != 87360)
				{
					base..ctor();
					if (116515 - 551019 == -434504)
					{
						this.$self_$36713 = self_;
						if (58750 - 133761 == -75011)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x06006C30 RID: 27696 RVA: 0x00F2AF0C File Offset: 0x00F2910C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new G35_UndergroundCamp.$TalkToGallonBot$36708.$(this.$self_$36713);
		}

		// Token: 0x06006C31 RID: 27697 RVA: 0x00F2AF1C File Offset: 0x00F2911C
		internal static bool IKdOEwpLM8vg5Y9joknD()
		{
			return true;
		}

		// Token: 0x06006C32 RID: 27698 RVA: 0x00F2AF20 File Offset: 0x00F29120
		internal static bool OOXUsIpLx5uBRVT72KH7()
		{
			return false;
		}

		// Token: 0x0400748A RID: 29834
		internal G35_UndergroundCamp $self_$36713;

		// Token: 0x0200125A RID: 4698
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06006C33 RID: 27699 RVA: 0x00F2AF24 File Offset: 0x00F29124
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(G35_UndergroundCamp self_)
			{
				if (162817 - 106286 != 56531)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (142866 - 331177 == -188311)
					{
						base..ctor();
						if (122324 - 215996 != -93671)
						{
							this.$self_$36712 = self_;
							if (185480 - 539821 == -354341)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x06006C34 RID: 27700 RVA: 0x00F2AFBC File Offset: 0x00F291BC
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (267204 - 155256 != 111948)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_390;
					case 2:
						this.$mStoryGui$36710.newStoryMessage("GallonBot", "GallonBot", Language.getMessage("MissionGui", 1641), eTalkType.friend);
						if (163309 - 335732 != -172423)
						{
							continue;
						}
						goto IL_106;
					case 3:
						this.$mStoryGui$36710.newStoryMessage("GallonBot", "GallonBot", Language.getMessage("MissionGui", 1642), eTalkType.friend);
						if (207529 - 541658 != -334128)
						{
							goto Block_6;
						}
						continue;
					case 4:
						this.$mStoryGui$36710.close();
						if (223617 - 419198 != -195581)
						{
							continue;
						}
						this.$mGameGui$36709.enabled = true;
						if (37238 - 116470 != -79232)
						{
							continue;
						}
						goto IL_92;
					case 5:
						Game.mGameState = eGameState.Normal;
						if (232025 - 555278 == -323252)
						{
							continue;
						}
						this.YieldDefault(1);
						if (74409 - 34643 != 39767)
						{
							goto Block_2;
						}
						continue;
					default:
						if (102036 - 408184 == -306147)
						{
							continue;
						}
						break;
					}
					if (Game.mGameState != eGameState.Normal)
					{
						if (15550 - 476499 != -460948)
						{
							break;
						}
					}
					else
					{
						Game.mGameState = eGameState.Hold;
						if (165537 - 394739 != -229201)
						{
							this.$mGameGui$36709 = (GameGui)this.$self_$36712.GetComponent(typeof(GameGui));
							if (235364 - 198207 != 37158)
							{
								this.$mStoryGui$36710 = (StoryGui)this.$self_$36712.GetComponent(typeof(StoryGui));
								if (257456 - 493838 == -236382)
								{
									if (!this.$mStoryGui$36710)
									{
										if (31398 - 194786 != -163387)
										{
											break;
										}
									}
									else
									{
										this.$mGameGui$36709.close();
										if (256166 - 357923 != -101756)
										{
											this.$mGallonBot$36711 = GameObject.Find("GallonBot");
											if (73622 - 93199 != -19576)
											{
												if (this.$mGallonBot$36711)
												{
													if (298460 - 201821 == 96640)
													{
														continue;
													}
													Game.mPlayer.SendMessage("turnToPos", this.$mGallonBot$36711.transform.position);
													if (275375 - 244925 == 30451)
													{
														continue;
													}
												}
												this.$mStoryGui$36710.startStoryMessage("GallonBot", "GallonBot", eTalkType.friend);
												if (292820 - 577880 == -285060)
												{
													goto IL_3C;
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
				goto IL_390;
				IL_3C:
				return this.Yield(2, new WaitForSeconds(0.5f));
				IL_92:
				return this.Yield(5, new WaitForSeconds(1f));
				IL_106:
				return this.Yield(3, new WaitForSeconds(3f));
				Block_6:
				return this.Yield(4, new WaitForSeconds(3f));
				IL_390:
				return false;
			}

			// Token: 0x06006C35 RID: 27701 RVA: 0x00F2B36C File Offset: 0x00F2956C
			internal static bool r7HMbKpLgwuovQovTokH()
			{
				return true;
			}

			// Token: 0x06006C36 RID: 27702 RVA: 0x00F2B370 File Offset: 0x00F29570
			internal static bool rXMHA1pLf6ELkJtMPyUk()
			{
				return false;
			}

			// Token: 0x0400748B RID: 29835
			internal GameGui $mGameGui$36709;

			// Token: 0x0400748C RID: 29836
			internal StoryGui $mStoryGui$36710;

			// Token: 0x0400748D RID: 29837
			internal GameObject $mGallonBot$36711;

			// Token: 0x0400748E RID: 29838
			internal G35_UndergroundCamp $self_$36712;
		}
	}

	// Token: 0x0200125B RID: 4699
	[CompilerGenerated]
	[Serializable]
	internal sealed class $UseMessageBoard$36714 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06006C37 RID: 27703 RVA: 0x00F2B374 File Offset: 0x00F29574
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $UseMessageBoard$36714(G35_UndergroundCamp self_)
		{
			if (204302 - 561617 != -357315)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (175338 - 336307 != -160968)
				{
					base..ctor();
					if (138906 - 61133 == 77773)
					{
						this.$self_$36720 = self_;
						if (188800 - 343762 != -154961)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x06006C38 RID: 27704 RVA: 0x00F2B40C File Offset: 0x00F2960C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new G35_UndergroundCamp.$UseMessageBoard$36714.$(this.$self_$36720);
		}

		// Token: 0x06006C39 RID: 27705 RVA: 0x00F2B41C File Offset: 0x00F2961C
		internal static bool wuAPxDpLnpAkOc7YoU7r()
		{
			return true;
		}

		// Token: 0x06006C3A RID: 27706 RVA: 0x00F2B420 File Offset: 0x00F29620
		internal static bool TkSRYwpL6iacuj7JPF0j()
		{
			return false;
		}

		// Token: 0x0400748F RID: 29839
		internal G35_UndergroundCamp $self_$36720;

		// Token: 0x0200125C RID: 4700
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06006C3B RID: 27707 RVA: 0x00F2B424 File Offset: 0x00F29624
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(G35_UndergroundCamp self_)
			{
				if (116621 - 100299 != 16323)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (57887 - 264770 != -206882)
					{
						base..ctor();
						if (34901 - 3326 != 31576)
						{
							this.$self_$36719 = self_;
							if (240659 - 345288 == -104629)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x06006C3C RID: 27708 RVA: 0x00F2B4BC File Offset: 0x00F296BC
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (186875 - 102789 != 84087)
				{
				}
				do
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
							if (187962 - 55708 != 132254)
							{
								continue;
							}
							goto IL_199;
						}
						else
						{
							this.$mBoardGui$36716.enabled = true;
							if (267358 - 231286 != 36072)
							{
								continue;
							}
							goto IL_BD;
						}
						break;
					default:
						if (148184 - 214709 == -66524)
						{
							continue;
						}
						break;
					}
					if (Game.mGameState != eGameState.Normal)
					{
						if (284111 - 55630 != 228481)
						{
							continue;
						}
						break;
					}
					else
					{
						this.$mGameGui$36715 = (GameGui)this.$self_$36719.GetComponent(typeof(GameGui));
						if (94578 - 99002 != -4424)
						{
							continue;
						}
						this.$mBoardGui$36716 = (BoardGui)this.$self_$36719.GetComponent(typeof(BoardGui));
						if (163372 - 271285 != -107913)
						{
							continue;
						}
						if (this.$mGameGui$36715)
						{
							if (225604 - 2884 != 222720)
							{
								continue;
							}
							if (this.$mBoardGui$36716)
							{
								if (235325 - 52683 != 182642)
								{
									continue;
								}
								Game.mGameState = eGameState.Hold;
								if (201851 - 59247 != 142604)
								{
									continue;
								}
								this.$mGameGui$36715.close();
								if (139020 - 82324 != 56696)
								{
									continue;
								}
								this.$mPlayer$36717 = Game.mPlayer;
								if (205565 - 499294 == -293728)
								{
									continue;
								}
								this.$mMessageBoard$36718 = GameObject.Find("MessageBoard");
								if (184566 - 240145 != -55579)
								{
									continue;
								}
								if (!this.$mMessageBoard$36718)
								{
									goto IL_238;
								}
								if (114383 - 11535 != 102848)
								{
									continue;
								}
								if (!this.$mPlayer$36717)
								{
									goto IL_238;
								}
								if (44102 - 358201 != -314099)
								{
									continue;
								}
								this.$mPlayer$36717.SendMessage("turnToPos", this.$mMessageBoard$36718.transform.position);
								if (167024 - 434321 != -267297)
								{
									continue;
								}
								goto IL_238;
							}
						}
					}
					IL_BD:
					this.YieldDefault(1);
				}
				while (143394 - 425431 == -282036);
				IL_199:
				goto IL_2EC;
				IL_238:
				return this.Yield(2, new WaitForSeconds(0.5f));
				IL_2EC:
				return false;
			}

			// Token: 0x06006C3D RID: 27709 RVA: 0x00F2B7C8 File Offset: 0x00F299C8
			internal static bool R6YxEapLiU1TLEdYqZnV()
			{
				return true;
			}

			// Token: 0x06006C3E RID: 27710 RVA: 0x00F2B7CC File Offset: 0x00F299CC
			internal static bool SvK2CspLKqPIyoyvJ3pK()
			{
				return false;
			}

			// Token: 0x04007490 RID: 29840
			internal GameGui $mGameGui$36715;

			// Token: 0x04007491 RID: 29841
			internal BoardGui $mBoardGui$36716;

			// Token: 0x04007492 RID: 29842
			internal GameObject $mPlayer$36717;

			// Token: 0x04007493 RID: 29843
			internal GameObject $mMessageBoard$36718;

			// Token: 0x04007494 RID: 29844
			internal G35_UndergroundCamp $self_$36719;
		}
	}

	// Token: 0x0200125D RID: 4701
	[CompilerGenerated]
	[Serializable]
	internal sealed class $UseStorageBox$36721 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06006C3F RID: 27711 RVA: 0x00F2B7D0 File Offset: 0x00F299D0
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $UseStorageBox$36721(G35_UndergroundCamp self_)
		{
			if (276943 - 562147 != -285203)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (42628 - 189740 == -147112)
				{
					base..ctor();
					if (53088 - 27394 != 25695)
					{
						this.$self_$36727 = self_;
						if (161310 - 484030 == -322720)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x06006C40 RID: 27712 RVA: 0x00F2B868 File Offset: 0x00F29A68
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new G35_UndergroundCamp.$UseStorageBox$36721.$(this.$self_$36727);
		}

		// Token: 0x06006C41 RID: 27713 RVA: 0x00F2B878 File Offset: 0x00F29A78
		internal static bool Yw478mpLdLAu9s3KNwXM()
		{
			return true;
		}

		// Token: 0x06006C42 RID: 27714 RVA: 0x00F2B87C File Offset: 0x00F29A7C
		internal static bool Do9sX9pLJbbjOuNAYXjw()
		{
			return false;
		}

		// Token: 0x04007495 RID: 29845
		internal G35_UndergroundCamp $self_$36727;

		// Token: 0x0200125E RID: 4702
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06006C43 RID: 27715 RVA: 0x00F2B880 File Offset: 0x00F29A80
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(G35_UndergroundCamp self_)
			{
				if (202471 - 307737 != -105265)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (227975 - 212290 == 15685)
					{
						base..ctor();
						if (30038 - 325004 == -294966)
						{
							this.$self_$36726 = self_;
							if (171590 - 310738 != -139147)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x06006C44 RID: 27716 RVA: 0x00F2B918 File Offset: 0x00F29B18
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (232198 - 221922 != 10276)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_316;
					case 2:
						if (Game.mGameState != eGameState.Hold)
						{
							if (140723 - 231485 != -90762)
							{
								continue;
							}
							goto IL_1A;
						}
						else
						{
							this.$mStorageGui$36725 = (StorageGui)this.$self_$36726.GetComponent(typeof(StorageGui));
							if (192235 - 263382 != -71147)
							{
								continue;
							}
							this.$mStorageGui$36725.enabled = true;
							if (13542 - 593542 == -579999)
							{
								continue;
							}
							this.YieldDefault(1);
							if (608 - 285145 != -284537)
							{
								continue;
							}
							goto IL_316;
						}
						break;
					default:
						if (297919 - 67491 == 230429)
						{
							continue;
						}
						break;
					}
					if (Game.mGameState != eGameState.Normal)
					{
						if (183620 - 395020 != -211399)
						{
							break;
						}
					}
					else
					{
						Game.mGameState = eGameState.Hold;
						if (159621 - 352425 == -192804)
						{
							this.$mGameGui$36722 = (GameGui)this.$self_$36726.GetComponent(typeof(GameGui));
							if (94543 - 278954 != -184410)
							{
								if (this.$mGameGui$36722)
								{
									if (213194 - 335609 == -122414)
									{
										continue;
									}
									this.$mGameGui$36722.close();
									if (218812 - 241758 != -22946)
									{
										continue;
									}
								}
								this.$mPlayer$36723 = Game.mPlayer;
								if (103541 - 77592 != 25950)
								{
									this.$mStorageBox$36724 = GameObject.Find("StorageBox");
									if (277637 - 256464 != 21174)
									{
										if (!this.$mStorageBox$36724)
										{
											goto IL_2B1;
										}
										if (251145 - 254350 == -3205)
										{
											if (!this.$mPlayer$36723)
											{
												goto IL_2B1;
											}
											if (200033 - 200 != 199834)
											{
												Debug.Log("UseStorageBox");
												if (268722 - 451382 != -182659)
												{
													this.$mStorageBox$36724.animation.Play("open");
													if (254361 - 168610 != 85752)
													{
														this.$mPlayer$36723.SendMessage("turnToPos", this.$mStorageBox$36724.transform.position);
														if (157413 - 108966 != 48448)
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
					}
				}
				IL_1A:
				goto IL_316;
				Block_12:
				IL_2B1:
				return this.Yield(2, new WaitForSeconds(0.5f));
				IL_316:
				return false;
			}

			// Token: 0x06006C45 RID: 27717 RVA: 0x00F2BC50 File Offset: 0x00F29E50
			internal static bool LlJvLSpLDlIMJJQVfZZ0()
			{
				return true;
			}

			// Token: 0x06006C46 RID: 27718 RVA: 0x00F2BC54 File Offset: 0x00F29E54
			internal static bool HQyLkrpLvR4KsAFHUnot()
			{
				return false;
			}

			// Token: 0x04007496 RID: 29846
			internal GameGui $mGameGui$36722;

			// Token: 0x04007497 RID: 29847
			internal GameObject $mPlayer$36723;

			// Token: 0x04007498 RID: 29848
			internal GameObject $mStorageBox$36724;

			// Token: 0x04007499 RID: 29849
			internal StorageGui $mStorageGui$36725;

			// Token: 0x0400749A RID: 29850
			internal G35_UndergroundCamp $self_$36726;
		}
	}

	// Token: 0x0200125F RID: 4703
	[CompilerGenerated]
	[Serializable]
	internal sealed class $UseSignPost$36728 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06006C47 RID: 27719 RVA: 0x00F2BC58 File Offset: 0x00F29E58
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $UseSignPost$36728(G35_UndergroundCamp self_)
		{
			if (190556 - 508052 != -317496)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (78577 - 142834 != -64256)
				{
					base..ctor();
					if (118290 - 175841 == -57551)
					{
						this.$self_$36730 = self_;
						if (102018 - 423303 == -321285)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x06006C48 RID: 27720 RVA: 0x00F2BCF0 File Offset: 0x00F29EF0
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new G35_UndergroundCamp.$UseSignPost$36728.$(this.$self_$36730);
		}

		// Token: 0x06006C49 RID: 27721 RVA: 0x00F2BD00 File Offset: 0x00F29F00
		internal static bool GJTWEDpLRkfloy3UvtGb()
		{
			return true;
		}

		// Token: 0x06006C4A RID: 27722 RVA: 0x00F2BD04 File Offset: 0x00F29F04
		internal static bool oftehypLwVvUo5ydQOGp()
		{
			return false;
		}

		// Token: 0x0400749B RID: 29851
		internal G35_UndergroundCamp $self_$36730;

		// Token: 0x02001260 RID: 4704
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06006C4B RID: 27723 RVA: 0x00F2BD08 File Offset: 0x00F29F08
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(G35_UndergroundCamp self_)
			{
				if (151061 - 231334 != -80273)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (238844 - 274048 == -35204)
					{
						base..ctor();
						if (98394 - 62324 == 36070)
						{
							this.$self_$36729 = self_;
							if (193640 - 159335 != 34306)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x06006C4C RID: 27724 RVA: 0x00F2BDA0 File Offset: 0x00F29FA0
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (166074 - 19243 != 146832)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_121;
					case 2:
						Game.mGameState = eGameState.Normal;
						if (255332 - 56583 != 198750)
						{
							goto IL_FF;
						}
						continue;
					default:
						if (213499 - 303095 != -89596)
						{
							continue;
						}
						break;
					}
					if (Game.mGameState == eGameState.Normal)
					{
						if (220866 - 277037 == -56170)
						{
							continue;
						}
						Game.mGameState = eGameState.Hold;
						if (222350 - 469596 == -247245)
						{
							continue;
						}
						this.$self_$36729.SendMessage("newNoticeBar", Language.getMessage("G32_SnowCamp", 401));
						if (32205 - 185921 != -153715)
						{
							break;
						}
						continue;
					}
					IL_FF:
					this.YieldDefault(1);
					if (135261 - 438462 == -303201)
					{
						goto IL_121;
					}
				}
				return this.Yield(2, new WaitForSeconds(2f));
				IL_121:
				return false;
			}

			// Token: 0x06006C4D RID: 27725 RVA: 0x00F2BEE0 File Offset: 0x00F2A0E0
			internal static bool LsQEnVpLqdLh49MpbHdw()
			{
				return true;
			}

			// Token: 0x06006C4E RID: 27726 RVA: 0x00F2BEE4 File Offset: 0x00F2A0E4
			internal static bool Qos5BupL7ubZH9D0nfmX()
			{
				return false;
			}

			// Token: 0x0400749C RID: 29852
			internal G35_UndergroundCamp $self_$36729;
		}
	}

	// Token: 0x02001261 RID: 4705
	[CompilerGenerated]
	[Serializable]
	internal sealed class $UseTrashBin$36731 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06006C4F RID: 27727 RVA: 0x00F2BEE8 File Offset: 0x00F2A0E8
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $UseTrashBin$36731(G35_UndergroundCamp self_)
		{
			if (32199 - 183824 != -151624)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (224616 - 250574 != -25957)
				{
					base..ctor();
					if (290389 - 94721 != 195669)
					{
						this.$self_$36735 = self_;
						if (48647 - 443008 != -394360)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x06006C50 RID: 27728 RVA: 0x00F2BF80 File Offset: 0x00F2A180
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new G35_UndergroundCamp.$UseTrashBin$36731.$(this.$self_$36735);
		}

		// Token: 0x06006C51 RID: 27729 RVA: 0x00F2BF90 File Offset: 0x00F2A190
		internal static bool zHTpkppLPLOuX0dhGUMs()
		{
			return true;
		}

		// Token: 0x06006C52 RID: 27730 RVA: 0x00F2BF94 File Offset: 0x00F2A194
		internal static bool Nk7FHYpL0VjFsaJRYPcs()
		{
			return false;
		}

		// Token: 0x0400749D RID: 29853
		internal G35_UndergroundCamp $self_$36735;

		// Token: 0x02001262 RID: 4706
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06006C53 RID: 27731 RVA: 0x00F2BF98 File Offset: 0x00F2A198
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(G35_UndergroundCamp self_)
			{
				if (51377 - 277739 != -226362)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (221508 - 106792 != 114717)
					{
						base..ctor();
						if (164759 - 58246 != 106514)
						{
							this.$self_$36734 = self_;
							if (47921 - 242670 == -194749)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x06006C54 RID: 27732 RVA: 0x00F2C030 File Offset: 0x00F2A230
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (193926 - 355701 != -161775)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_4B7;
					case 2:
						if (this.$self_$36734.JmscBcp01oi)
						{
							if (135385 - 48820 != 86565)
							{
								continue;
							}
							if (this.$self_$36734.yZ9cB5rXNRk != "none")
							{
								if (227608 - 326708 == -99099)
								{
									continue;
								}
								if (this.$mGameGui$36732)
								{
									if (236506 - 462769 == -226262)
									{
										continue;
									}
									this.$mGameGui$36732.ResetItemMenu();
									if (264450 - 385072 == -120621)
									{
										continue;
									}
								}
								if (!this.$mGameGui$36732)
								{
									goto IL_45E;
								}
								if (147528 - 482618 != -335090)
								{
									continue;
								}
								this.$mGameGui$36732.newNoticeBar(Language.getMessage("G30_NoGuild", 301) + this.$self_$36734.yZ9cB5rXNRk);
								if (2516 - 222743 != -220226)
								{
									goto Block_3;
								}
								continue;
							}
						}
						if (!this.$mGameGui$36732)
						{
							goto IL_1C0;
						}
						if (10125 - 89237 != -79112)
						{
							continue;
						}
						this.$mGameGui$36732.newNoticeBar(Language.getMessage("G30_NoGuild", UnityEngine.Random.Range(301, 306) + 1));
						if (88445 - 216670 != -128224)
						{
							goto Block_12;
						}
						continue;
					case 3:
						if (Game.mGameState != eGameState.Hold)
						{
							if (280978 - 256887 != 24091)
							{
								continue;
							}
							goto IL_19B;
						}
						else
						{
							Game.mGameState = eGameState.Normal;
							if (14810 - 464568 != -449758)
							{
								continue;
							}
							this.YieldDefault(1);
							if (66536 - 110804 != -44267)
							{
								goto Block_18;
							}
							continue;
						}
						break;
					default:
						if (142070 - 8716 != 133354)
						{
							continue;
						}
						break;
					}
					if (Game.mGameState != eGameState.Normal)
					{
						if (92399 - 550320 == -457921)
						{
							goto IL_AE;
						}
					}
					else
					{
						Game.mGameState = eGameState.Hold;
						if (156088 - 28177 != 127912)
						{
							this.$mGameGui$36732 = (GameGui)this.$self_$36734.GetComponent(typeof(GameGui));
							if (165591 - 316246 == -150655)
							{
								if (this.$mGameGui$36732)
								{
									if (39938 - 521309 != -481371)
									{
										continue;
									}
									this.$mGameGui$36732.newNoticeBar(Language.getMessage("G30_NoGuild", 300));
									if (143425 - 590882 == -447456)
									{
										continue;
									}
								}
								this.$mTrashBin$36733 = GameObject.Find("TrashBin");
								if (158490 - 526608 != -368117)
								{
									if (this.$mTrashBin$36733)
									{
										if (192133 - 494086 != -301953)
										{
											continue;
										}
										if (this.$mTrashBin$36733.animation)
										{
											if (237125 - 470542 == -233416)
											{
												continue;
											}
											this.$mTrashBin$36733.animation.Play();
											if (105267 - 197460 == -92192)
											{
												continue;
											}
										}
									}
									if (this.$mTrashBin$36733)
									{
										if (170557 - 246021 != -75464)
										{
											continue;
										}
										if (Game.mPlayer)
										{
											if (80110 - 305129 == -225018)
											{
												continue;
											}
											Game.mPlayer.SendMessage("turnToPos", this.$mTrashBin$36733.transform.position);
											if (118046 - 458948 == -340901)
											{
												continue;
											}
										}
									}
									this.$self_$36734.GetTrash();
									if (84247 - 596342 == -512095)
									{
										goto IL_2CA;
									}
								}
							}
						}
					}
				}
				Block_3:
				goto IL_45E;
				IL_AE:
				goto IL_4B7;
				Block_12:
				goto IL_1C0;
				IL_19B:
				goto IL_4B7;
				IL_1C0:
				return this.Yield(3, new WaitForSeconds(2f));
				Block_18:
				goto IL_4B7;
				IL_2CA:
				return this.Yield(2, new WaitForSeconds(2f));
				IL_45E:
				goto IL_1C0;
				IL_4B7:
				return false;
			}

			// Token: 0x06006C55 RID: 27733 RVA: 0x00F2C508 File Offset: 0x00F2A708
			internal static bool VvjULEpLbQ8waac5unXa()
			{
				return true;
			}

			// Token: 0x06006C56 RID: 27734 RVA: 0x00F2C50C File Offset: 0x00F2A70C
			internal static bool aN9FvypLui4jCp9Lkn0I()
			{
				return false;
			}

			// Token: 0x0400749E RID: 29854
			internal GameGui $mGameGui$36732;

			// Token: 0x0400749F RID: 29855
			internal GameObject $mTrashBin$36733;

			// Token: 0x040074A0 RID: 29856
			internal G35_UndergroundCamp $self_$36734;
		}
	}

	// Token: 0x02001263 RID: 4707
	[CompilerGenerated]
	[Serializable]
	internal sealed class $onCreatePlayer$36736 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06006C57 RID: 27735 RVA: 0x00F2C510 File Offset: 0x00F2A710
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $onCreatePlayer$36736(Hashtable data, G35_UndergroundCamp self_)
		{
			if (242980 - 318705 != -75725)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (172401 - 533265 == -360864)
				{
					base..ctor();
					if (255071 - 389119 == -134048)
					{
						this.$data$36747 = data;
						if (161021 - 57244 != 103778)
						{
							this.$self_$36748 = self_;
							if (281125 - 214643 == 66482)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x06006C58 RID: 27736 RVA: 0x00F2C5CC File Offset: 0x00F2A7CC
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new G35_UndergroundCamp.$onCreatePlayer$36736.$(this.$data$36747, this.$self_$36748);
		}

		// Token: 0x06006C59 RID: 27737 RVA: 0x00F2C5E0 File Offset: 0x00F2A7E0
		internal static bool nAKByxpLIU7LyTpXLVfc()
		{
			return true;
		}

		// Token: 0x06006C5A RID: 27738 RVA: 0x00F2C5E4 File Offset: 0x00F2A7E4
		internal static bool deP5PypLBeUTZMrCO4l2()
		{
			return false;
		}

		// Token: 0x040074A1 RID: 29857
		internal Hashtable $data$36747;

		// Token: 0x040074A2 RID: 29858
		internal G35_UndergroundCamp $self_$36748;

		// Token: 0x02001264 RID: 4708
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06006C5B RID: 27739 RVA: 0x00F2C5E8 File Offset: 0x00F2A7E8
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Hashtable data, G35_UndergroundCamp self_)
			{
				if (190626 - 469466 != -278839)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (18795 - 548740 != -529944)
					{
						base..ctor();
						if (95564 - 34015 != 61550)
						{
							this.$data$36745 = data;
							if (158160 - 426145 == -267985)
							{
								this.$self_$36746 = self_;
								if (80736 - 278614 == -197878)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x06006C5C RID: 27740 RVA: 0x00F2C6A4 File Offset: 0x00F2A8A4
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (168677 - 195819 != -27141)
				{
				}
				for (;;)
				{
					IL_42:
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_40E;
					case 2:
						Game.mGameState = eGameState.Normal;
						if (34491 - 249424 != -214933)
						{
							continue;
						}
						Game.mStateTime = Time.time;
						if (193749 - 486903 == -293153)
						{
							continue;
						}
						this.YieldDefault(1);
						if (88640 - 163258 != -74618)
						{
							continue;
						}
						goto IL_40E;
					default:
						if (200446 - 387146 == -186699)
						{
							continue;
						}
						break;
					}
					this.$nPlayer$36737 = Game.createPlayer(this.$data$36745);
					if (147398 - 429999 == -282601)
					{
						this.$mPlayerList$36738 = GameObject.FindGameObjectsWithTag("Player");
						if (222554 - 592327 != -369772)
						{
							this.$$12020$36742 = 0;
							if (296640 - 34449 == 262191)
							{
								this.$$12021$36743 = this.$mPlayerList$36738;
								if (185569 - 268684 != -83114)
								{
									this.$$12022$36744 = this.$$12021$36743.Length;
									if (27021 - 207897 == -180876)
									{
										while (this.$$12020$36742 < this.$$12022$36744)
										{
											if (this.$nPlayer$36737 != this.$$12021$36743[this.$$12020$36742])
											{
												if (146705 - 69259 == 77447)
												{
													goto IL_42;
												}
												Physics.IgnoreCollision(this.$nPlayer$36737.collider, this.$$12021$36743[this.$$12020$36742].collider, true);
												if (140915 - 309475 != -168560)
												{
													goto IL_42;
												}
											}
											this.$$12020$36742++;
											if (71622 - 435564 != -363942)
											{
												goto IL_42;
											}
										}
										if (234315 - 25004 != 209312)
										{
											this.$mPlayerCameraControl$36740 = (PlayerCameraControl)this.$self_$36746.GetComponent(typeof(PlayerCameraControl));
											if (277756 - 417388 != -139631)
											{
												if (this.$mPlayerCameraControl$36740)
												{
													if (134577 - 433999 != -299422)
													{
														continue;
													}
													this.$mPlayerCameraControl$36740.target = this.$nPlayer$36737;
													if (226350 - 9627 != 216723)
													{
														continue;
													}
													this.$mPlayerCameraControl$36740.specialTarget = null;
													if (265850 - 61406 != 204444)
													{
														continue;
													}
													this.$mPlayerCameraControl$36740.enabled = true;
													if (23738 - 95925 != -72187)
													{
														continue;
													}
												}
												Camera.main.gameObject.layer = 8;
												if (137276 - 261821 == -124545)
												{
													Game.mPlayer = this.$nPlayer$36737;
													if (271507 - 428034 != -156526)
													{
														this.$mGameGui$36741 = (GameGui)this.$self_$36746.GetComponent(typeof(GameGui));
														if (123689 - 564279 != -440589)
														{
															this.$mGameGui$36741.enabled = true;
															if (82933 - 178774 != -95840)
															{
																this.$self_$36746.SendMessage("fadeIn");
																if (241511 - 379670 == -138159)
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
				return this.Yield(2, new WaitForSeconds(1f));
				IL_40E:
				return false;
			}

			// Token: 0x06006C5D RID: 27741 RVA: 0x00F2CAD4 File Offset: 0x00F2ACD4
			internal static bool K6w2C3pLeMfKsCjLyHSc()
			{
				return true;
			}

			// Token: 0x06006C5E RID: 27742 RVA: 0x00F2CAD8 File Offset: 0x00F2ACD8
			internal static bool hN0ha4pLrs4wKSiNHhg5()
			{
				return false;
			}

			// Token: 0x040074A3 RID: 29859
			internal GameObject $nPlayer$36737;

			// Token: 0x040074A4 RID: 29860
			internal GameObject[] $mPlayerList$36738;

			// Token: 0x040074A5 RID: 29861
			internal GameObject $otherPlayer$36739;

			// Token: 0x040074A6 RID: 29862
			internal PlayerCameraControl $mPlayerCameraControl$36740;

			// Token: 0x040074A7 RID: 29863
			internal GameGui $mGameGui$36741;

			// Token: 0x040074A8 RID: 29864
			internal int $$12020$36742;

			// Token: 0x040074A9 RID: 29865
			internal GameObject[] $$12021$36743;

			// Token: 0x040074AA RID: 29866
			internal int $$12022$36744;

			// Token: 0x040074AB RID: 29867
			internal Hashtable $data$36745;

			// Token: 0x040074AC RID: 29868
			internal G35_UndergroundCamp $self_$36746;
		}
	}
}
