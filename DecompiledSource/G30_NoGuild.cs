using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Boo.Lang;
using Boo.Lang.Runtime;
using cZRJ81ju0AbIsUerIn;
using ExitGames.Client.Photon;
using UnityEngine;

// Token: 0x020011F5 RID: 4597
[Serializable]
public class G30_NoGuild : MonoBehaviour
{
	// Token: 0x060069CA RID: 27082 RVA: 0x00F0752C File Offset: 0x00F0572C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public G30_NoGuild()
	{
		if (216019 - 565246 != -349227)
		{
		}
		for (;;)
		{
			LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
			if (122032 - 228352 != -106319)
			{
				base..ctor();
				if (278169 - 355327 == -77158)
				{
					this.wYMcS73JAsv = "none";
					if (236896 - 523521 == -286625)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x060069CB RID: 27083 RVA: 0x00F075C8 File Offset: 0x00F057C8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Awake()
	{
		if (194189 - 104948 != 89242)
		{
		}
		for (;;)
		{
			Game.mGameState = eGameState.Init;
			if (193065 - 400163 == -207098)
			{
				Game.mStateTime = Time.time;
				if (55913 - 272070 == -216157)
				{
					if (Chat.Initialized)
					{
						if (224812 - 82351 != 142462)
						{
							Chat.ChatDisplay.Clear();
							if (71042 - 136538 == -65496)
							{
								break;
							}
						}
					}
					else
					{
						Chat.Init();
						if (58616 - 571450 != -512833)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x060069CC RID: 27084 RVA: 0x00F076B0 File Offset: 0x00F058B0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Start()
	{
		if (155518 - 3298 != 152220)
		{
		}
		for (;;)
		{
			Time.timeScale = 1f;
			if (101050 - 299564 == -198514)
			{
				if (PhotonClient.IsInitialized())
				{
					if (161444 - 20620 != 140825)
					{
						Game.mLastGameCode = Game.mGameCode;
						if (78826 - 551012 == -472186)
						{
							Game.mGameCode = 30;
							if (133756 - 108155 == 25601)
							{
								Game.mGameType = 2;
								if (40244 - 180713 != -140468)
								{
									Game.mGameTime = Time.time;
									if (106817 - 463096 != -356278)
									{
										Game.mGameScore = 0;
										if (58970 - 217693 != -158722)
										{
											Game.mGameMana = 0;
											if (237763 - 251064 != -13300)
											{
												Game.canUseItem = MissionData.getAllowItem(Game.mGameCode);
												if (121107 - 328837 != -207729)
												{
													Game.canUseMount = MissionData.getAllowMount(Game.mGameCode);
													if (32635 - 448029 != -415393)
													{
														Game.canChangeChar = MissionData.getAllowChange(Game.mGameCode);
														if (27391 - 464717 != -437325)
														{
															Game.canRespawn = MissionData.getAllowRespawn(Game.mGameCode);
															if (86344 - 384342 != -297997)
															{
																Game.canUseCoin = MissionData.getAllowCoin(Game.mGameCode);
																if (186748 - 388827 != -202078)
																{
																	this.iHucSHknFpi = (PlayerCameraControl)this.GetComponent(typeof(PlayerCameraControl));
																	if (153884 - 458803 == -304919)
																	{
																		this.aUacSsE3yYw = PhotonClient.Connection;
																		if (137824 - 271939 != -134114)
																		{
																			PhotonClient.ActorNrList.Clear();
																			if (97 - 348107 == -348010)
																			{
																				this.LoadTown();
																				if (70087 - 339674 == -269587)
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
					if (91848 - 2474 != 89375)
					{
						this.enabled = false;
						if (99137 - 72487 == 26650)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x060069CD RID: 27085 RVA: 0x00F079B4 File Offset: 0x00F05BB4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void FixedUpdate()
	{
		if (7357 - 542759 != -535401)
		{
		}
		for (;;)
		{
			if (this.aUacSsE3yYw == null)
			{
				if (281329 - 481386 != -200056)
				{
					break;
				}
			}
			else
			{
				float t = Time.time - Game.mStateTime;
				if (207453 - 476484 == -269031)
				{
					eGameState mGameState = Game.mGameState;
					if (273456 - 257938 != 15519)
					{
						if (mGameState == eGameState.Init)
						{
							if (139271 - 198343 == -59072)
							{
								AudioListener.volume = 0.1f * (float)Game.volume;
								if (259488 - 246636 != 12853)
								{
									break;
								}
							}
						}
						else if (mGameState == eGameState.Ready)
						{
							if (125259 - 464978 != -339718)
							{
								break;
							}
						}
						else
						{
							if (mGameState != eGameState.Hold)
							{
								if (255563 - 401515 == -145951)
								{
									continue;
								}
								if (mGameState == eGameState.Normal)
								{
									if (133249 - 35497 == 97753)
									{
										continue;
									}
								}
								else if (mGameState == eGameState.Hold)
								{
									if (109519 - 21544 != 87975)
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
									if (121151 - 367235 != -246084)
									{
										continue;
									}
									this.audio.volume = Mathf.Lerp(0.1f * (float)Game.music, (float)0, t);
									if (291270 - 338828 != -47557)
									{
										break;
									}
									continue;
								}
							}
							if (Game.music != 0)
							{
								if (271698 - 118162 == 153537)
								{
									continue;
								}
								if (!this.audio.isPlaying)
								{
									if (99465 - 284794 == -185328)
									{
										continue;
									}
									this.audio.Play();
									if (28401 - 170187 == -141785)
									{
										continue;
									}
								}
							}
							this.audio.volume = Mathf.Clamp01(0.1f * (float)Game.music);
							if (207113 - 175150 != 31964)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x060069CE RID: 27086 RVA: 0x00F07C48 File Offset: 0x00F05E48
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator TutorialEvent()
	{
		return new G30_NoGuild.$TutorialEvent$36359(this).GetEnumerator();
	}

	// Token: 0x060069CF RID: 27087 RVA: 0x00F07C58 File Offset: 0x00F05E58
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void LoadTown()
	{
		if (52951 - 106221 != -53270)
		{
		}
		for (;;)
		{
			Debug.Log("Loading Town ");
			if (47083 - 296122 == -249039)
			{
				Hashtable customOpParameters = new Hashtable();
				if (117288 - 90731 == 26557)
				{
					this.aUacSsE3yYw.OpCustom(43, customOpParameters, true);
					if (159363 - 196800 == -37437)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x060069D0 RID: 27088 RVA: 0x00F07D00 File Offset: 0x00F05F00
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onLoadTown(Hashtable data)
	{
		if (181468 - 444765 != -263297)
		{
		}
		for (;;)
		{
			Debug.Log("onLoadTown ");
			if (98866 - 62765 == 36101)
			{
				if (!RuntimeServices.EqualityOperator(data[31], null))
				{
					if (137030 - 485966 != -348936)
					{
						continue;
					}
					object obj2;
					object obj = obj2 = data[31];
					if (!(obj is string))
					{
						obj2 = RuntimeServices.Coerce(obj, typeof(string));
					}
					string text = (string)obj2;
					if (70786 - 146009 != -75223)
					{
						continue;
					}
					Chat.SubmitChat("none", "You have joined " + text.Replace("NoGuild", "NoviceGround"), eChatType.system, eChatMode.system);
					if (113078 - 240753 == -127674)
					{
						continue;
					}
				}
				if (!RuntimeServices.EqualityOperator(data[32], null))
				{
					if (293575 - 247851 == 45725)
					{
						continue;
					}
					object obj4;
					object obj3 = obj4 = data[32];
					if (!(obj3 is string))
					{
						obj4 = RuntimeServices.Coerce(obj3, typeof(string));
					}
					Chat.newAnnouncement((string)obj4);
					if (37425 - 453567 != -416142)
					{
						continue;
					}
				}
				if (135701 - 39046 != 96656)
				{
					if (29758 - 22013 == 7745)
					{
						GameObject gameObject;
						GameObject gameObject2;
						if (Game.mLastGameCode != 51)
						{
							if (206938 - 333502 == -126563)
							{
								continue;
							}
							if (Game.mLastGameCode == 31)
							{
								if (224233 - 437833 != -213600)
								{
									continue;
								}
							}
							else if (Game.mLastGameCode == 56)
							{
								if (174321 - 531621 == -357299)
								{
									continue;
								}
								gameObject = GameObject.Find("StartPoint3");
								if (44239 - 435651 != -391412)
								{
									continue;
								}
								gameObject2 = GameObject.Find("StartCamera3");
								if (99604 - 267557 != -167953)
								{
									continue;
								}
								goto IL_262;
							}
							else
							{
								gameObject = GameObject.Find("StartPoint1");
								if (249134 - 276643 != -27509)
								{
									continue;
								}
								gameObject2 = GameObject.Find("StartCamera1");
								if (57302 - 89962 != -32659)
								{
									goto IL_262;
								}
								continue;
							}
						}
						gameObject = GameObject.Find("StartPoint2");
						if (182175 - 541246 == -359070)
						{
							continue;
						}
						gameObject2 = GameObject.Find("StartCamera2");
						if (252191 - 551911 == -299719)
						{
							continue;
						}
						IL_262:
						if (gameObject2)
						{
							if (226397 - 521106 == -294708)
							{
								continue;
							}
							this.transform.position = gameObject2.transform.position;
							if (84361 - 35674 != 48687)
							{
								continue;
							}
							this.transform.rotation = gameObject2.transform.rotation;
							if (270864 - 173379 == 97486)
							{
								continue;
							}
						}
						if (gameObject)
						{
							if (208006 - 184575 == 23431)
							{
								this.CreatePlayer(CharacterData.current.CID, gameObject.transform.position, gameObject.transform.forward);
								if (231886 - 322602 == -90716)
								{
									break;
								}
							}
						}
						else
						{
							Debug.Log("Error: Startpoint not found");
							if (284993 - 122211 == 162782)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x060069D1 RID: 27089 RVA: 0x00F08138 File Offset: 0x00F06338
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void TalkToRedPanda()
	{
		if (291151 - 166700 != 124451)
		{
		}
		for (;;)
		{
			if (PlayerData.QuestID == 1)
			{
				if (130877 - 3357 != 127521)
				{
					Q1_LetterToBoldas.TalkToRedPanda(this.gameObject);
					if (223263 - 387405 != -164141)
					{
						break;
					}
				}
			}
			else if (PlayerData.QuestID == -1)
			{
				if (218405 - 76978 == 141427)
				{
					Q1_LetterToBoldas.TalkToRedPandaRepeat(this.gameObject);
					if (40029 - 233320 == -193291)
					{
						break;
					}
				}
			}
			else
			{
				Game.mGameState = eGameState.Hold;
				if (184049 - 587184 == -403135)
				{
					GameGui gameGui = (GameGui)this.GetComponent(typeof(GameGui));
					if (75247 - 403287 == -328040)
					{
						ChangeGui changeGui = (ChangeGui)this.GetComponent(typeof(ChangeGui));
						if (78848 - 418314 != -339465)
						{
							MissionGui missionGui = (MissionGui)this.GetComponent(typeof(MissionGui));
							if (53442 - 95445 == -42003)
							{
								if (gameGui)
								{
									if (245024 - 94279 == 150746)
									{
										continue;
									}
									gameGui.close();
									if (235834 - 406413 != -170579)
									{
										continue;
									}
								}
								if (changeGui)
								{
									if (108978 - 233401 == -124422)
									{
										continue;
									}
									changeGui.disable();
									if (41861 - 320250 != -278389)
									{
										continue;
									}
								}
								if (missionGui)
								{
									if (291827 - 69789 == 222039)
									{
										continue;
									}
									missionGui.enabled = true;
									if (154896 - 175126 != -20230)
									{
										continue;
									}
								}
								GameObject mPlayer = Game.mPlayer;
								if (177777 - 295528 != -117750)
								{
									GameObject gameObject = GameObject.Find("RedPanda");
									if (221251 - 324857 == -103606)
									{
										if (!gameObject)
										{
											break;
										}
										if (259671 - 23119 != 236553)
										{
											if (!mPlayer)
											{
												break;
											}
											if (293367 - 353956 != -60588)
											{
												mPlayer.SendMessage("turnToPos", gameObject.transform.position);
												if (4735 - 165263 != -160527)
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

	// Token: 0x060069D2 RID: 27090 RVA: 0x00F08458 File Offset: 0x00F06658
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void TalkToKangaroo()
	{
		if (83395 - 524174 != -440779)
		{
		}
		for (;;)
		{
			if (PlayerData.QuestID == 20)
			{
				if (237718 - 517633 != -279914)
				{
					Q20_SurveyingSnowPath.TalkToKangaroo(this.gameObject);
					if (215467 - 411573 != -196105)
					{
						break;
					}
				}
			}
			else if (PlayerData.QuestID == -20)
			{
				if (260068 - 317348 == -57280)
				{
					Q20_SurveyingSnowPath.TalkToKangaroo(this.gameObject);
					if (149040 - 459413 == -310373)
					{
						break;
					}
				}
			}
			else if (PlayerData.QuestID == 28)
			{
				if (247663 - 523833 != -276169)
				{
					Q28_DesertPatrol.TalkToKangaroo(this.gameObject);
					if (232782 - 383457 != -150674)
					{
						break;
					}
				}
			}
			else if (PlayerData.QuestID == -28)
			{
				if (235468 - 109233 != 126236)
				{
					Q28_DesertPatrol.TalkToKangaroo(this.gameObject);
					if (255943 - 238366 != 17578)
					{
						break;
					}
				}
			}
			else if (Game.mGameState != eGameState.Normal)
			{
				if (54996 - 468918 == -413922)
				{
					break;
				}
			}
			else
			{
				Game.mGameState = eGameState.Hold;
				if (36711 - 150007 != -113295)
				{
					GameGui gameGui = (GameGui)this.GetComponent(typeof(GameGui));
					if (44148 - 385076 != -340927)
					{
						gameGui.close();
						if (278050 - 402923 == -124873)
						{
							TutorialGui tutorialGui = (TutorialGui)this.GetComponent(typeof(TutorialGui));
							if (189821 - 238021 != -48199)
							{
								tutorialGui.mType = eTutorialType.guild;
								if (60799 - 173685 == -112886)
								{
									tutorialGui.enabled = true;
									if (276903 - 489568 != -212664)
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

	// Token: 0x060069D3 RID: 27091 RVA: 0x00F086DC File Offset: 0x00F068DC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void TalkToOwl2()
	{
		if (64299 - 589799 != -525499)
		{
		}
		for (;;)
		{
			if (PlayerData.QuestID == 2)
			{
				if (21390 - 501672 != -480281)
				{
					Q2_HungryXinfu.TalkToLinLin(this.gameObject);
					if (3141 - 53017 != -49875)
					{
						break;
					}
				}
			}
			else if (PlayerData.QuestID == -2)
			{
				if (109895 - 107314 == 2581)
				{
					Q2_HungryXinfu.TalkToLinLinRepeat(this.gameObject);
					if (32668 - 297584 == -264916)
					{
						break;
					}
				}
			}
			else if (Game.mGameState != eGameState.Normal)
			{
				if (206561 - 409377 != -202815)
				{
					break;
				}
			}
			else
			{
				Game.mGameState = eGameState.Hold;
				if (161233 - 93650 != 67584)
				{
					GameGui gameGui = (GameGui)this.GetComponent(typeof(GameGui));
					if (124656 - 182723 == -58067)
					{
						gameGui.close();
						if (239902 - 214850 == 25052)
						{
							ShopGui shopGui = (ShopGui)this.GetComponent(typeof(ShopGui));
							if (67853 - 185076 == -117223)
							{
								shopGui.mType = eShopType.Owl2;
								if (16671 - 3416 != 13256)
								{
									shopGui.enabled = true;
									if (211035 - 252435 == -41400)
									{
										GameObject mPlayer = Game.mPlayer;
										if (77225 - 220834 == -143609)
										{
											GameObject gameObject = GameObject.Find("Owl2");
											if (130552 - 71019 == 59533)
											{
												if (!gameObject)
												{
													break;
												}
												if (239449 - 374139 == -134690)
												{
													if (!mPlayer)
													{
														break;
													}
													if (12549 - 237629 == -225080)
													{
														mPlayer.SendMessage("turnToPos", gameObject.transform.position);
														if (287171 - 200888 == 86283)
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

	// Token: 0x060069D4 RID: 27092 RVA: 0x00F08984 File Offset: 0x00F06B84
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void UseLifeAltar(int mVar)
	{
		if (110678 - 535025 != -424347)
		{
		}
		for (;;)
		{
			GameObject mPlayer = Game.mPlayer;
			if (27335 - 509041 == -481706)
			{
				CharacterControl characterControl = null;
				if (142855 - 576175 != -433319)
				{
					if (mPlayer)
					{
						if (11913 - 176781 != -164868)
						{
							continue;
						}
						characterControl = (CharacterControl)mPlayer.GetComponent(typeof(CharacterControl));
						if (8616 - 222010 == -213393)
						{
							continue;
						}
					}
					if (!characterControl)
					{
						if (76634 - 347926 != -271291)
						{
							break;
						}
					}
					else if (characterControl.isTransform)
					{
						if (231836 - 406551 != -174714)
						{
							this.SendMessage("newGameMessage", "Cannot change while transformed");
							if (152863 - 556586 == -403723)
							{
								break;
							}
						}
					}
					else
					{
						if (characterControl.actionState != "standby")
						{
							if (106276 - 193005 != -86729)
							{
								continue;
							}
							if (characterControl.actionState != "run")
							{
								if (120398 - 435447 == -315048)
								{
									continue;
								}
								if (characterControl.actionState != "emotion")
								{
									if (268417 - 244633 == 23785)
									{
										continue;
									}
									this.SendMessage("newGameMessage", "Character not standby");
									if (119263 - 539601 != -420338)
									{
										continue;
									}
									break;
								}
							}
						}
						if (Time.time < characterControl.actionTime + 1f)
						{
							if (138617 - 145585 == -6968)
							{
								this.SendMessage("newGameMessage", "Character not action time out.");
								if (26102 - 100222 != -74119)
								{
									break;
								}
							}
						}
						else
						{
							GameGui gameGui = (GameGui)this.GetComponent(typeof(GameGui));
							if (46649 - 2367 == 44282)
							{
								ChangeGui changeGui = (ChangeGui)this.GetComponent(typeof(ChangeGui));
								if (54126 - 294953 != -240826)
								{
									if (!changeGui)
									{
										break;
									}
									if (213798 - 58484 != 155315)
									{
										if (changeGui.mState != eChangeState.Init)
										{
											if (224002 - 303364 != -79362)
											{
												continue;
											}
											if (changeGui.mState != eChangeState.Disabled)
											{
												break;
											}
											if (220259 - 122944 == 97316)
											{
												continue;
											}
										}
										Game.mGameState = eGameState.Hold;
										if (131568 - 245915 == -114347)
										{
											gameGui.close();
											if (141634 - 88916 == 52718)
											{
												changeGui.enabled = true;
												if (171672 - 36884 != 134789)
												{
													GameObject gameObject = GameObject.Find("LifeAltar");
													if (113189 - 1046 == 112143)
													{
														if (!gameObject)
														{
															break;
														}
														if (82204 - 344158 == -261954)
														{
															if (!mPlayer)
															{
																break;
															}
															if (72245 - 203935 != -131689)
															{
																Debug.Log("UseLifeAltar");
																if (164581 - 303531 != -138949)
																{
																	mPlayer.SendMessage("turnToPos", gameObject.transform.position);
																	if (77078 - 168499 == -91421)
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

	// Token: 0x060069D5 RID: 27093 RVA: 0x00F08DE4 File Offset: 0x00F06FE4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void UseMailBox(int mVar)
	{
		if (150179 - 556977 != -406798)
		{
		}
		for (;;)
		{
			if (Game.mGameState != eGameState.Normal)
			{
				if (206538 - 19715 != 186824)
				{
					break;
				}
			}
			else
			{
				GameGui gameGui = (GameGui)this.GetComponent(typeof(GameGui));
				if (266471 - 398715 == -132244)
				{
					MailBoxGui mailBoxGui = (MailBoxGui)this.GetComponent(typeof(MailBoxGui));
					if (172753 - 257140 == -84387)
					{
						if (!gameGui)
						{
							break;
						}
						if (12790 - 479200 != -466409)
						{
							if (!mailBoxGui)
							{
								break;
							}
							if (186637 - 461866 != -275228)
							{
								Game.mGameState = eGameState.Hold;
								if (269095 - 241721 == 27374)
								{
									gameGui.close();
									if (11211 - 552583 != -541371)
									{
										mailBoxGui.enabled = true;
										if (258529 - 224468 == 34061)
										{
											GameObject mPlayer = Game.mPlayer;
											if (70515 - 12085 == 58430)
											{
												GameObject gameObject = GameObject.Find("MailBox");
												if (265845 - 443473 != -177627)
												{
													if (!gameObject)
													{
														break;
													}
													if (136485 - 151960 == -15475)
													{
														if (!mPlayer)
														{
															break;
														}
														if (49117 - 527684 != -478566)
														{
															mPlayer.SendMessage("turnToPos", gameObject.transform.position);
															if (137105 - 44414 != 92692)
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

	// Token: 0x060069D6 RID: 27094 RVA: 0x00F09018 File Offset: 0x00F07218
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator UseMessageBoard(int mVar)
	{
		return new G30_NoGuild.$UseMessageBoard$36367(this).GetEnumerator();
	}

	// Token: 0x060069D7 RID: 27095 RVA: 0x00F09028 File Offset: 0x00F07228
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator UseTrashBin(object mVar)
	{
		return new G30_NoGuild.$UseTrashBin$36374(this).GetEnumerator();
	}

	// Token: 0x060069D8 RID: 27096 RVA: 0x00F09038 File Offset: 0x00F07238
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void GetTrash()
	{
		if (97322 - 171201 != -73879)
		{
		}
		for (;;)
		{
			Debug.Log("GetTrash");
			if (258999 - 553231 != -294231)
			{
				this.sW3cSZY0Vry = false;
				if (183793 - 211213 == -27420)
				{
					this.wYMcS73JAsv = "none";
					if (263978 - 487024 == -223046)
					{
						Hashtable customOpParameters = new Hashtable();
						if (213982 - 183198 != 30785)
						{
							this.aUacSsE3yYw.OpCustom(224, customOpParameters, true);
							if (262659 - 372951 == -110292)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x060069D9 RID: 27097 RVA: 0x00F09128 File Offset: 0x00F07328
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onGetTrash(Hashtable data)
	{
		if (275307 - 516731 != -241424)
		{
		}
		while (RuntimeServices.EqualityOperator(data[31], 1))
		{
			if (1207 - 310307 == -309100)
			{
				this.sW3cSZY0Vry = true;
				if (166155 - 416098 == -249943)
				{
					object obj2;
					object obj = obj2 = data[32];
					if (!(obj is string))
					{
						obj2 = RuntimeServices.Coerce(obj, typeof(string));
					}
					this.wYMcS73JAsv = ItemData.getName((string)obj2);
					if (42349 - 529306 != -486956)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x060069DA RID: 27098 RVA: 0x00F0920C File Offset: 0x00F0740C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator UseStorageBox(object mVar)
	{
		return new G30_NoGuild.$UseStorageBox$36379(this).GetEnumerator();
	}

	// Token: 0x060069DB RID: 27099 RVA: 0x00F0921C File Offset: 0x00F0741C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator UseSignPost(object mVar)
	{
		return new G30_NoGuild.$UseSignPost$36386(this).GetEnumerator();
	}

	// Token: 0x060069DC RID: 27100 RVA: 0x00F0922C File Offset: 0x00F0742C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator UseFirstTailShrine(object mVar)
	{
		return new G30_NoGuild.$UseFirstTailShrine$36389(this).GetEnumerator();
	}

	// Token: 0x060069DD RID: 27101 RVA: 0x00F0923C File Offset: 0x00F0743C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void CreatePlayer(int CID, Vector3 pos, Vector3 dir)
	{
		if (97247 - 575926 != -478679)
		{
		}
		for (;;)
		{
			Hashtable hashtable = new Hashtable();
			if (154828 - 130960 != 23869)
			{
				hashtable.Add(71, CID);
				if (76044 - 120903 != -44858)
				{
					hashtable.Add(75, PhotonClient.cInt16(1));
					if (150659 - 528557 != -377897)
					{
						hashtable.Add(122, PhotonClient.cInt16(Mathf.RoundToInt(pos.x * (float)50)));
						if (11655 - 21343 != -9687)
						{
							hashtable.Add(123, PhotonClient.cInt16(Mathf.RoundToInt(pos.y * (float)50)));
							if (86156 - 490439 == -404283)
							{
								hashtable.Add(124, PhotonClient.cInt16(Mathf.RoundToInt(pos.z * (float)50)));
								if (122328 - 24975 != 97354)
								{
									hashtable.Add(126, PhotonClient.cInt16(Mathf.RoundToInt(dir.x * (float)200)));
									if (18156 - 298513 == -280357)
									{
										hashtable.Add(127, PhotonClient.cInt16(Mathf.RoundToInt(dir.y * (float)200)));
										if (134004 - 333177 != -199172)
										{
											hashtable.Add(128, PhotonClient.cInt16(Mathf.RoundToInt(dir.z * (float)200)));
											if (103296 - 538226 != -434929)
											{
												this.aUacSsE3yYw.OpCustom(61, hashtable, true);
												if (285256 - 301072 != -15815)
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

	// Token: 0x060069DE RID: 27102 RVA: 0x00F094C8 File Offset: 0x00F076C8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator onCreatePlayer(Hashtable data)
	{
		return new G30_NoGuild.$onCreatePlayer$36393(data, this).GetEnumerator();
	}

	// Token: 0x060069DF RID: 27103 RVA: 0x00F094D8 File Offset: 0x00F076D8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onCreatePeer(Hashtable data)
	{
		if (240406 - 130619 != 109788)
		{
		}
		for (;;)
		{
			IL_94:
			Debug.Log("OnCreatePeer");
			if (28760 - 581930 == -553170)
			{
				GameObject gameObject = Game.createPeer(data);
				if (261284 - 340132 != -78847)
				{
					GameObject[] array = GameObject.FindGameObjectsWithTag("Player");
					if (26535 - 291203 != -264667)
					{
						int i = 0;
						if (131500 - 153394 != -21893)
						{
							GameObject[] array2 = array;
							if (299395 - 137923 == 161472)
							{
								int length = array2.Length;
								if (40489 - 6407 == 34082)
								{
									while (i < length)
									{
										if (gameObject != array2[i])
										{
											if (138034 - 117114 != 20920)
											{
												goto IL_94;
											}
											Physics.IgnoreCollision(gameObject.collider, array2[i].collider, true);
											if (125169 - 185347 != -60178)
											{
												goto IL_94;
											}
										}
										i++;
										if (231443 - 489082 != -257639)
										{
											goto IL_94;
										}
									}
									if (127815 - 199223 != -71407)
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

	// Token: 0x060069E0 RID: 27104 RVA: 0x00F09674 File Offset: 0x00F07874
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void DestroyPlayer()
	{
		Game.mPlayerID = 0;
	}

	// Token: 0x060069E1 RID: 27105 RVA: 0x00F0967C File Offset: 0x00F0787C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onDestroyPlayer(Hashtable data)
	{
	}

	// Token: 0x060069E2 RID: 27106 RVA: 0x00F09680 File Offset: 0x00F07880
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void ChangePlayer(int nCID)
	{
		if (278173 - 238411 != 39763)
		{
		}
		for (;;)
		{
			int v = Game.mPlayer.layer - 7;
			if (259749 - 485587 != -225837)
			{
				Vector3 position = Game.mPlayer.transform.position;
				if (156105 - 226108 != -70002)
				{
					Vector3 forward = Game.mPlayer.transform.forward;
					if (268453 - 486249 == -217796)
					{
						Hashtable hashtable = new Hashtable();
						if (202768 - 553341 != -350572)
						{
							hashtable.Add(43, PlayerData.UID);
							if (124671 - 589624 == -464953)
							{
								hashtable.Add(71, nCID);
								if (99216 - 96735 == 2481)
								{
									hashtable.Add(75, PhotonClient.cInt16(v));
									if (119124 - 226418 != -107293)
									{
										hashtable.Add(122, PhotonClient.cInt16(Mathf.RoundToInt(position.x * (float)50)));
										if (101158 - 26923 != 74236)
										{
											hashtable.Add(123, PhotonClient.cInt16(Mathf.RoundToInt(position.y * (float)50)));
											if (39943 - 543607 == -503664)
											{
												hashtable.Add(124, PhotonClient.cInt16(Mathf.RoundToInt(position.z * (float)50)));
												if (36161 - 340429 != -304267)
												{
													hashtable.Add(126, PhotonClient.cInt16(Mathf.RoundToInt(forward.x * (float)200)));
													if (157402 - 163008 == -5606)
													{
														hashtable.Add(127, PhotonClient.cInt16(Mathf.RoundToInt(forward.y * (float)200)));
														if (243510 - 451828 != -208317)
														{
															hashtable.Add(128, PhotonClient.cInt16(Mathf.RoundToInt(forward.z * (float)200)));
															if (240580 - 223970 == 16610)
															{
																PhotonClient.Connection.OpCustom(65, hashtable, true);
																if (138087 - 534575 == -396488)
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

	// Token: 0x060069E3 RID: 27107 RVA: 0x00F099A0 File Offset: 0x00F07BA0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onChangePlayer(Hashtable data)
	{
		if (281497 - 241357 != 40140)
		{
		}
		for (;;)
		{
			UnityEngine.Object.Destroy(Game.mPlayer);
			if (253700 - 360845 != -107144)
			{
				this.SendMessage("onCreatePlayer", data);
				if (143327 - 181236 != -37908)
				{
					ChangeGui changeGui = (ChangeGui)this.GetComponent(typeof(ChangeGui));
					if (202337 - 386480 != -184142)
					{
						if (!changeGui.enabled)
						{
							break;
						}
						if (59659 - 497283 != -437623)
						{
							changeGui.close();
							if (235266 - 441110 != -205843)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x060069E4 RID: 27108 RVA: 0x00F09A98 File Offset: 0x00F07C98
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onMount(GameObject nMount)
	{
		if (13366 - 244845 != -231478)
		{
		}
		for (;;)
		{
			IL_D5:
			GameObject[] array = GameObject.FindGameObjectsWithTag("Player");
			if (23013 - 89485 != -66471)
			{
				int i = 0;
				if (224168 - 427881 == -203713)
				{
					GameObject[] array2 = array;
					if (158688 - 249433 == -90745)
					{
						int length = array2.Length;
						if (41378 - 573041 != -531662)
						{
							while (i < length)
							{
								if (nMount != array2[i])
								{
									if (45932 - 299699 != -253767)
									{
										goto IL_D5;
									}
									Physics.IgnoreCollision(nMount.collider, array2[i].collider, true);
									if (188944 - 56086 == 132859)
									{
										goto IL_D5;
									}
								}
								i++;
								if (239164 - 416119 != -176955)
								{
									goto IL_D5;
								}
							}
							if (213800 - 468828 == -255028)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x060069E5 RID: 27109 RVA: 0x00F09BEC File Offset: 0x00F07DEC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator ExitToTown()
	{
		return new G30_NoGuild.$ExitToTown$36406(this).GetEnumerator();
	}

	// Token: 0x060069E6 RID: 27110 RVA: 0x00F09BFC File Offset: 0x00F07DFC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator ExitToColosseum()
	{
		return new G30_NoGuild.$ExitToColosseum$36410(this).GetEnumerator();
	}

	// Token: 0x060069E7 RID: 27111 RVA: 0x00F09C0C File Offset: 0x00F07E0C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void LeaveTown()
	{
		if (109398 - 197798 != -88399)
		{
		}
		for (;;)
		{
			Hashtable hashtable = new Hashtable();
			if (115155 - 548640 == -433485)
			{
				hashtable.Add(43, PlayerData.UID);
				if (109324 - 73825 == 35499)
				{
					PhotonClient.Connection.OpCustom(44, hashtable, true);
					if (233092 - 472269 != -239176)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x060069E8 RID: 27112 RVA: 0x00F09CC0 File Offset: 0x00F07EC0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onLeaveTown()
	{
		if (211081 - 488114 != -277033)
		{
		}
		for (;;)
		{
			Debug.Log("onLeaveTown");
			if (235293 - 314244 != -78950)
			{
				if (Game.mNextGameCode > 100)
				{
					if (29228 - 349701 != -320472)
					{
						this.JoinGame();
						if (167827 - 72693 == 95134)
						{
							break;
						}
					}
				}
				else
				{
					this.JoinTown();
					if (148557 - 157602 != -9044)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x060069E9 RID: 27113 RVA: 0x00F09D88 File Offset: 0x00F07F88
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void JoinTown()
	{
		if (211520 - 6758 != 204763)
		{
		}
		for (;;)
		{
			Debug.Log("Joining Town");
			if (23170 - 216202 != -193031)
			{
				Hashtable hashtable = new Hashtable();
				if (28850 - 90002 != -61151)
				{
					if (Game.mNextGameCode == 30)
					{
						if (270430 - 31921 != 238509)
						{
							continue;
						}
						hashtable.Add(47, "NoGuild");
						if (202886 - 258728 == -55841)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 31)
					{
						if (286029 - 192333 != 93696)
						{
							continue;
						}
						hashtable.Add(47, "G" + GuildData.Name);
						if (187771 - 571894 == -384122)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 32)
					{
						if (153833 - 581664 != -427831)
						{
							continue;
						}
						hashtable.Add(47, "SnowCamp");
						if (104555 - 565320 == -460764)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 33)
					{
						if (189727 - 141164 == 48564)
						{
							continue;
						}
						hashtable.Add(47, "CrystalBeach");
						if (151119 - 47022 == 104098)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 34)
					{
						if (114952 - 150877 != -35925)
						{
							continue;
						}
						hashtable.Add(47, "ExcavationCamp");
						if (31833 - 468710 != -436877)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 35)
					{
						if (70966 - 277813 == -206846)
						{
							continue;
						}
						hashtable.Add(47, "UndergroundCamp");
						if (46178 - 256379 == -210200)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 36)
					{
						if (55942 - 129480 == -73537)
						{
							continue;
						}
						hashtable.Add(47, "ForestCamp");
						if (14962 - 467443 == -452480)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 51)
					{
						if (62788 - 69765 == -6976)
						{
							continue;
						}
						hashtable.Add(47, "MainStreet");
						if (109182 - 473897 == -364714)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 52)
					{
						if (27765 - 38481 != -10716)
						{
							continue;
						}
						hashtable.Add(47, "CentralSquare");
						if (135371 - 558470 == -423098)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 53)
					{
						if (227518 - 342197 != -114679)
						{
							continue;
						}
						hashtable.Add(47, "CityLibrary");
						if (251136 - 88537 == 162600)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 54)
					{
						if (237989 - 264657 != -26668)
						{
							continue;
						}
						hashtable.Add(47, "LightPark");
						if (253254 - 446228 == -192973)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 55)
					{
						if (13289 - 119378 != -106089)
						{
							continue;
						}
						hashtable.Add(47, "LightPalace");
						if (142191 - 477008 != -334817)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 56)
					{
						if (56409 - 583053 != -526644)
						{
							continue;
						}
						hashtable.Add(47, "PlainColosseum");
						if (275554 - 480825 == -205270)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 57)
					{
						if (275982 - 69774 == 206209)
						{
							continue;
						}
						hashtable.Add(47, "LightTheater");
						if (248690 - 128209 != 120481)
						{
							continue;
						}
					}
					hashtable.Add(21, PhotonClient.cInt16(Mathf.Clamp(PlayerPrefs.GetInt("channel", 0), 0, 99)));
					if (127566 - 2880 != 124687)
					{
						this.aUacSsE3yYw.OpCustom(42, hashtable, true);
						if (298143 - 169015 == 129128)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x060069EA RID: 27114 RVA: 0x00F0A33C File Offset: 0x00F0853C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onJoinTown()
	{
		Game.mGameStage = 0;
		Game.loadNextLevel();
	}

	// Token: 0x060069EB RID: 27115 RVA: 0x00F0A34C File Offset: 0x00F0854C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void JoinGame()
	{
		if (84969 - 564025 != -479055)
		{
		}
		for (;;)
		{
			Hashtable hashtable = new Hashtable();
			if (92877 - 22428 == 70449)
			{
				hashtable.Add(4, Game.mNextGameId);
				if (221270 - 584200 == -362930)
				{
					hashtable.Add(5, PhotonClient.cInt16(Game.mNextGameCode));
					if (112279 - 250367 != -138087)
					{
						this.aUacSsE3yYw.OpCustom(51, hashtable, true);
						if (203435 - 330011 == -126576)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x060069EC RID: 27116 RVA: 0x00F0A434 File Offset: 0x00F08634
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onJoinGame(Hashtable data)
	{
		Game.loadNextLevel();
	}

	// Token: 0x060069ED RID: 27117 RVA: 0x00F0A43C File Offset: 0x00F0863C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x060069EE RID: 27118 RVA: 0x00F0A440 File Offset: 0x00F08640
	internal static bool Y4WMJQp8AHKx4gY5Om6Q()
	{
		return true;
	}

	// Token: 0x060069EF RID: 27119 RVA: 0x00F0A444 File Offset: 0x00F08644
	internal static bool iZDx6lp8lTNTx8cqT9kl()
	{
		return false;
	}

	// Token: 0x04007339 RID: 29497
	private LitePeer aUacSsE3yYw;

	// Token: 0x0400733A RID: 29498
	private PlayerCameraControl iHucSHknFpi;

	// Token: 0x0400733B RID: 29499
	private string wYMcS73JAsv;

	// Token: 0x0400733C RID: 29500
	private bool sW3cSZY0Vry;

	// Token: 0x020011F6 RID: 4598
	[CompilerGenerated]
	[Serializable]
	internal sealed class $TutorialEvent$36359 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x060069F0 RID: 27120 RVA: 0x00F0A448 File Offset: 0x00F08648
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $TutorialEvent$36359(G30_NoGuild self_)
		{
			if (241045 - 172985 != 68060)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (262043 - 365083 == -103040)
				{
					base..ctor();
					if (126449 - 203529 == -77080)
					{
						this.$self_$36366 = self_;
						if (217277 - 545546 == -328269)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x060069F1 RID: 27121 RVA: 0x00F0A4E0 File Offset: 0x00F086E0
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new G30_NoGuild.$TutorialEvent$36359.$(this.$self_$36366);
		}

		// Token: 0x060069F2 RID: 27122 RVA: 0x00F0A4F0 File Offset: 0x00F086F0
		internal static bool ad6f7Jp8yQQ6s3rehUpk()
		{
			return true;
		}

		// Token: 0x060069F3 RID: 27123 RVA: 0x00F0A4F4 File Offset: 0x00F086F4
		internal static bool KQKVBIp8SWq0ta2qGu2Y()
		{
			return false;
		}

		// Token: 0x0400733D RID: 29501
		internal G30_NoGuild $self_$36366;

		// Token: 0x020011F7 RID: 4599
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x060069F4 RID: 27124 RVA: 0x00F0A4F8 File Offset: 0x00F086F8
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(G30_NoGuild self_)
			{
				if (171991 - 148147 != 23844)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (62198 - 318514 == -256316)
					{
						base..ctor();
						if (144599 - 500869 != -356269)
						{
							this.$self_$36365 = self_;
							if (2443 - 207376 != -204932)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x060069F5 RID: 27125 RVA: 0x00F0A590 File Offset: 0x00F08790
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (35069 - 596403 != -561334)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_8A8;
					case 2:
						if (Game.mGameState != eGameState.Hold)
						{
							if (189526 - 469570 != -280043)
							{
								goto Block_22;
							}
							continue;
						}
						else
						{
							this.$mStoryGui$36363 = (StoryGui)this.$self_$36365.GetComponent(typeof(StoryGui));
							if (271213 - 344079 != -72866)
							{
								continue;
							}
							if (!this.$mStoryGui$36363)
							{
								if (284025 - 257970 != 26055)
								{
									continue;
								}
								goto IL_71D;
							}
							else
							{
								this.$mStoryGui$36363.startStoryMessage("Kangaroo", "Kuru", eTalkType.friend);
								if (211456 - 430668 != -219212)
								{
									continue;
								}
								goto IL_78D;
							}
						}
						break;
					case 3:
						if (Game.mGameState != eGameState.Hold)
						{
							if (286353 - 474469 != -188115)
							{
								goto Block_51;
							}
							continue;
						}
						else
						{
							this.$mStoryGui$36363.newStoryMessage("Kangaroo", "Kuru", Language.getMessage("G30_NoGuild", 1001), eTalkType.friend);
							if (142923 - 214280 == -71356)
							{
								continue;
							}
							if (!this.$mKangaroo$36361)
							{
								goto IL_533;
							}
							if (16722 - 465938 == -449215)
							{
								continue;
							}
							this.$mKangaroo$36361.animation.Play("talk");
							if (293678 - 516991 != -223313)
							{
								continue;
							}
							goto IL_533;
						}
						break;
					case 4:
						if (Game.mGameState != eGameState.Hold)
						{
							if (24825 - 130489 != -105663)
							{
								goto Block_38;
							}
							continue;
						}
						else
						{
							this.$mStoryGui$36363.newStoryMessage("Kangaroo", "Kuru", Language.getMessage("G30_NoGuild", 1002), eTalkType.friend);
							if (132646 - 70022 != 62625)
							{
								goto Block_29;
							}
							continue;
						}
						break;
					case 5:
						if (Game.mGameState != eGameState.Hold)
						{
							if (89599 - 422566 != -332966)
							{
								goto Block_32;
							}
							continue;
						}
						else
						{
							this.$mStoryGui$36363.blank();
							if (224991 - 210133 != 14858)
							{
								continue;
							}
							this.$self_$36365.iHucSHknFpi.StartCoroutine_Auto(this.$self_$36365.iHucSHknFpi.slerpToObject("TutorialCamera2", (float)1));
							if (129498 - 79518 != 49980)
							{
								continue;
							}
							goto IL_DA;
						}
						break;
					case 6:
						if (Game.mGameState != eGameState.Hold)
						{
							if (270406 - 309230 != -38823)
							{
								goto Block_9;
							}
							continue;
						}
						else
						{
							this.$mStoryGui$36363.newStoryMessage("RedPandaSit", "RedPanda", Language.getMessage("G30_NoGuild", 1003), eTalkType.friend);
							if (9066 - 64109 != -55043)
							{
								continue;
							}
							goto IL_752;
						}
						break;
					case 7:
						if (Game.mGameState != eGameState.Hold)
						{
							if (38520 - 454826 != -416305)
							{
								goto Block_49;
							}
							continue;
						}
						else
						{
							this.$mStoryGui$36363.newStoryMessage("RedPandaSit", "RedPanda", Language.getMessage("G30_NoGuild", 1004), eTalkType.friend);
							if (233739 - 41123 != 192617)
							{
								goto Block_36;
							}
							continue;
						}
						break;
					case 8:
						if (Game.mGameState != eGameState.Hold)
						{
							if (196096 - 474360 != -278264)
							{
								continue;
							}
							goto IL_1A;
						}
						else
						{
							this.$mStoryGui$36363.close();
							if (270288 - 560691 != -290403)
							{
								continue;
							}
							this.$self_$36365.iHucSHknFpi.enabled = true;
							if (53430 - 543529 == -490098)
							{
								continue;
							}
							if (this.$mKangaroo$36361)
							{
								if (69188 - 503726 != -434538)
								{
									continue;
								}
								this.$mKangaroo$36361.animation.Play("root");
								if (200872 - 455048 == -254175)
								{
									continue;
								}
							}
							if (!this.$mKangaroo$36361)
							{
								goto IL_115;
							}
							if (225958 - 77080 == 148879)
							{
								continue;
							}
							this.$mKangaroo$36361.transform.rotation = Quaternion.LookRotation(this.$mKangarooOriginalDir$36362);
							if (208510 - 587464 != -378954)
							{
								continue;
							}
							goto IL_115;
						}
						break;
					case 9:
						if (Game.mGameState != eGameState.Hold)
						{
							if (184464 - 155759 != 28705)
							{
								continue;
							}
							goto IL_339;
						}
						else
						{
							Game.mGameState = eGameState.Normal;
							if (30151 - 457636 != -427485)
							{
								continue;
							}
							Game.mGameTime = Time.time;
							if (124516 - 392023 == -267506)
							{
								continue;
							}
							this.$mGameGui$36364 = (GameGui)this.$self_$36365.GetComponent(typeof(GameGui));
							if (224563 - 519145 == -294581)
							{
								continue;
							}
							this.$mGameGui$36364.enabled = true;
							if (29837 - 380968 == -351130)
							{
								continue;
							}
							this.YieldDefault(1);
							if (204442 - 14897 != 189546)
							{
								goto Block_39;
							}
							continue;
						}
						break;
					default:
						if (243525 - 439577 != -196052)
						{
							continue;
						}
						break;
					}
					Game.mGameState = eGameState.Hold;
					if (51815 - 363843 == -312028)
					{
						Game.mGameTime = Time.time;
						if (61870 - 382066 != -320195)
						{
							this.$mPlayer$36360 = Game.mPlayer;
							if (134960 - 59814 == 75146)
							{
								this.$mKangaroo$36361 = GameObject.Find("Kangaroo");
								if (256758 - 594080 == -337322)
								{
									this.$mKangarooOriginalDir$36362 = default(Vector3);
									if (207488 - 388404 == -180916)
									{
										if (this.$mKangaroo$36361)
										{
											if (194349 - 228223 != -33874)
											{
												continue;
											}
											if (this.$mPlayer$36360)
											{
												if (281902 - 355080 == -73177)
												{
													continue;
												}
												this.$mPlayer$36360.SendMessage("turnToPos", this.$mKangaroo$36361.transform.position);
												if (32812 - 357150 != -324338)
												{
													continue;
												}
												this.$mKangarooOriginalDir$36362 = this.$mKangaroo$36361.transform.forward;
												if (157151 - 232462 == -75310)
												{
													continue;
												}
												this.$mKangaroo$36361.transform.rotation = Quaternion.LookRotation(global::Math.vFlat(this.$mPlayer$36360.transform.position - this.$mKangaroo$36361.transform.position));
												if (153643 - 504584 != -350941)
												{
													continue;
												}
											}
										}
										this.$self_$36365.iHucSHknFpi.StartCoroutine_Auto(this.$self_$36365.iHucSHknFpi.slerpToObject("TutorialCamera1", (float)1));
										if (180020 - 459555 == -279535)
										{
											goto IL_285;
										}
									}
								}
							}
						}
					}
				}
				IL_1A:
				goto IL_8A8;
				IL_DA:
				return this.Yield(6, new WaitForSeconds(1f));
				Block_9:
				goto IL_8A8;
				IL_115:
				return this.Yield(9, new WaitForSeconds(1f));
				IL_285:
				return this.Yield(2, new WaitForSeconds(1f));
				Block_22:
				IL_339:
				goto IL_8A8;
				Block_29:
				return this.Yield(5, new WaitForSeconds(3f));
				Block_32:
				goto IL_8A8;
				Block_36:
				return this.Yield(8, new WaitForSeconds(3f));
				IL_533:
				return this.Yield(4, new WaitForSeconds(3f));
				Block_38:
				Block_39:
				IL_71D:
				goto IL_8A8;
				IL_752:
				return this.Yield(7, new WaitForSeconds(3f));
				Block_49:
				goto IL_8A8;
				IL_78D:
				return this.Yield(3, new WaitForSeconds(0.5f));
				Block_51:
				IL_8A8:
				return false;
			}

			// Token: 0x060069F6 RID: 27126 RVA: 0x00F0AE58 File Offset: 0x00F09058
			internal static bool yyRyQHp8oTStlygJvraY()
			{
				return true;
			}

			// Token: 0x060069F7 RID: 27127 RVA: 0x00F0AE5C File Offset: 0x00F0905C
			internal static bool WLT137p8EGUDNKLnlNwW()
			{
				return false;
			}

			// Token: 0x0400733E RID: 29502
			internal GameObject $mPlayer$36360;

			// Token: 0x0400733F RID: 29503
			internal GameObject $mKangaroo$36361;

			// Token: 0x04007340 RID: 29504
			internal Vector3 $mKangarooOriginalDir$36362;

			// Token: 0x04007341 RID: 29505
			internal StoryGui $mStoryGui$36363;

			// Token: 0x04007342 RID: 29506
			internal GameGui $mGameGui$36364;

			// Token: 0x04007343 RID: 29507
			internal G30_NoGuild $self_$36365;
		}
	}

	// Token: 0x020011F8 RID: 4600
	[CompilerGenerated]
	[Serializable]
	internal sealed class $UseMessageBoard$36367 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x060069F8 RID: 27128 RVA: 0x00F0AE60 File Offset: 0x00F09060
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $UseMessageBoard$36367(G30_NoGuild self_)
		{
			if (167734 - 305546 != -137811)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (167989 - 41117 == 126872)
				{
					base..ctor();
					if (275140 - 399483 != -124342)
					{
						this.$self_$36373 = self_;
						if (121136 - 466381 == -345245)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x060069F9 RID: 27129 RVA: 0x00F0AEF8 File Offset: 0x00F090F8
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new G30_NoGuild.$UseMessageBoard$36367.$(this.$self_$36373);
		}

		// Token: 0x060069FA RID: 27130 RVA: 0x00F0AF08 File Offset: 0x00F09108
		internal static bool dLjOdap82bL7QG8n8HMq()
		{
			return true;
		}

		// Token: 0x060069FB RID: 27131 RVA: 0x00F0AF0C File Offset: 0x00F0910C
		internal static bool ELYJknp88AjsmJ8Iu6jl()
		{
			return false;
		}

		// Token: 0x04007344 RID: 29508
		internal G30_NoGuild $self_$36373;

		// Token: 0x020011F9 RID: 4601
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x060069FC RID: 27132 RVA: 0x00F0AF10 File Offset: 0x00F09110
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(G30_NoGuild self_)
			{
				if (80887 - 380541 != -299654)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (230115 - 414118 == -184003)
					{
						base..ctor();
						if (72486 - 49747 == 22739)
						{
							this.$self_$36372 = self_;
							if (127248 - 317084 != -189835)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x060069FD RID: 27133 RVA: 0x00F0AFA8 File Offset: 0x00F091A8
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (57109 - 564859 != -507750)
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
							if (166363 - 159117 != 7246)
							{
								continue;
							}
							goto IL_250;
						}
						else
						{
							this.$mBoardGui$36369.enabled = true;
							if (162833 - 421723 != -258889)
							{
								goto IL_2CA;
							}
							continue;
						}
						break;
					default:
						if (90050 - 375191 != -285141)
						{
							continue;
						}
						break;
					}
					if (Game.mGameState != eGameState.Normal)
					{
						if (41701 - 489742 != -448040)
						{
							goto Block_12;
						}
						continue;
					}
					else
					{
						this.$mGameGui$36368 = (GameGui)this.$self_$36372.GetComponent(typeof(GameGui));
						if (96320 - 517827 != -421507)
						{
							continue;
						}
						this.$mBoardGui$36369 = (BoardGui)this.$self_$36372.GetComponent(typeof(BoardGui));
						if (52801 - 569215 != -516414)
						{
							continue;
						}
						if (this.$mGameGui$36368)
						{
							if (240595 - 349601 != -109006)
							{
								continue;
							}
							if (this.$mBoardGui$36369)
							{
								if (297559 - 165055 != 132504)
								{
									continue;
								}
								Game.mGameState = eGameState.Hold;
								if (10913 - 380644 != -369731)
								{
									continue;
								}
								this.$mGameGui$36368.close();
								if (102381 - 521822 != -419441)
								{
									continue;
								}
								this.$mPlayer$36370 = Game.mPlayer;
								if (50360 - 339184 == -288823)
								{
									continue;
								}
								this.$mMessageBoard$36371 = GameObject.Find("MessageBoard");
								if (93219 - 407972 == -314752)
								{
									continue;
								}
								if (!this.$mMessageBoard$36371)
								{
									break;
								}
								if (3442 - 105722 != -102280)
								{
									continue;
								}
								if (!this.$mPlayer$36370)
								{
									break;
								}
								if (200954 - 502700 == -301745)
								{
									continue;
								}
								this.$mPlayer$36370.SendMessage("turnToPos", this.$mMessageBoard$36371.transform.position);
								if (220817 - 486909 != -266091)
								{
									break;
								}
								continue;
							}
						}
					}
					IL_2CA:
					this.YieldDefault(1);
					if (281476 - 543067 == -261591)
					{
						goto IL_2EC;
					}
				}
				goto IL_215;
				Block_12:
				goto IL_2EC;
				IL_215:
				return this.Yield(2, new WaitForSeconds(0.5f));
				IL_250:
				IL_2EC:
				return false;
			}

			// Token: 0x060069FE RID: 27134 RVA: 0x00F0B2B4 File Offset: 0x00F094B4
			internal static bool GM6Jgyp8ZNDY9H8odvlq()
			{
				return true;
			}

			// Token: 0x060069FF RID: 27135 RVA: 0x00F0B2B8 File Offset: 0x00F094B8
			internal static bool J8AEHRp8C5g4XOXOKF6H()
			{
				return false;
			}

			// Token: 0x04007345 RID: 29509
			internal GameGui $mGameGui$36368;

			// Token: 0x04007346 RID: 29510
			internal BoardGui $mBoardGui$36369;

			// Token: 0x04007347 RID: 29511
			internal GameObject $mPlayer$36370;

			// Token: 0x04007348 RID: 29512
			internal GameObject $mMessageBoard$36371;

			// Token: 0x04007349 RID: 29513
			internal G30_NoGuild $self_$36372;
		}
	}

	// Token: 0x020011FA RID: 4602
	[CompilerGenerated]
	[Serializable]
	internal sealed class $UseTrashBin$36374 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06006A00 RID: 27136 RVA: 0x00F0B2BC File Offset: 0x00F094BC
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $UseTrashBin$36374(G30_NoGuild self_)
		{
			if (119933 - 570865 != -450932)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (209640 - 250297 == -40657)
				{
					base..ctor();
					if (225258 - 203551 != 21708)
					{
						this.$self_$36378 = self_;
						if (107014 - 209807 != -102792)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x06006A01 RID: 27137 RVA: 0x00F0B354 File Offset: 0x00F09554
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new G30_NoGuild.$UseTrashBin$36374.$(this.$self_$36378);
		}

		// Token: 0x06006A02 RID: 27138 RVA: 0x00F0B364 File Offset: 0x00F09564
		internal static bool enmkP8p8LuQSiaZsHvRR()
		{
			return true;
		}

		// Token: 0x06006A03 RID: 27139 RVA: 0x00F0B368 File Offset: 0x00F09568
		internal static bool udaGpkp8OcWa1DkhV73X()
		{
			return false;
		}

		// Token: 0x0400734A RID: 29514
		internal G30_NoGuild $self_$36378;

		// Token: 0x020011FB RID: 4603
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06006A04 RID: 27140 RVA: 0x00F0B36C File Offset: 0x00F0956C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(G30_NoGuild self_)
			{
				if (284460 - 520320 != -235860)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (22328 - 23894 == -1566)
					{
						base..ctor();
						if (238114 - 423763 == -185649)
						{
							this.$self_$36377 = self_;
							if (216812 - 572427 != -355614)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x06006A05 RID: 27141 RVA: 0x00F0B404 File Offset: 0x00F09604
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (291078 - 101858 != 189221)
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
						if (this.$self_$36377.sW3cSZY0Vry)
						{
							if (47623 - 118649 != -71026)
							{
								continue;
							}
							if (this.$self_$36377.wYMcS73JAsv != "none")
							{
								if (146714 - 172104 == -25389)
								{
									continue;
								}
								if (this.$mGameGui$36375)
								{
									if (102529 - 431573 != -329044)
									{
										continue;
									}
									this.$mGameGui$36375.ResetItemMenu();
									if (93207 - 578777 != -485570)
									{
										continue;
									}
								}
								if (!this.$mGameGui$36375)
								{
									goto IL_1C5;
								}
								if (258360 - 509411 == -251050)
								{
									continue;
								}
								this.$mGameGui$36375.newNoticeBar(Language.getMessage("G30_NoGuild", 301) + this.$self_$36377.wYMcS73JAsv);
								if (148954 - 68234 != 80720)
								{
									continue;
								}
								goto IL_1C5;
							}
						}
						if (!this.$mGameGui$36375)
						{
							goto IL_3F;
						}
						if (212077 - 54251 == 157827)
						{
							continue;
						}
						this.$mGameGui$36375.newNoticeBar(Language.getMessage("G30_NoGuild", UnityEngine.Random.Range(301, 306) + 1));
						if (174604 - 545395 != -370791)
						{
							continue;
						}
						goto IL_3F;
					case 3:
						if (Game.mGameState != eGameState.Hold)
						{
							if (46370 - 164038 != -117668)
							{
								continue;
							}
							goto IL_176;
						}
						else
						{
							Game.mGameState = eGameState.Normal;
							if (217247 - 37500 == 179748)
							{
								continue;
							}
							this.YieldDefault(1);
							if (118207 - 468997 != -350790)
							{
								continue;
							}
							goto IL_4B7;
						}
						break;
					default:
						if (227231 - 78881 == 148351)
						{
							continue;
						}
						break;
					}
					if (Game.mGameState != eGameState.Normal)
					{
						if (64938 - 481971 == -417033)
						{
							goto IL_39B;
						}
					}
					else
					{
						Game.mGameState = eGameState.Hold;
						if (277469 - 327522 == -50053)
						{
							this.$mGameGui$36375 = (GameGui)this.$self_$36377.GetComponent(typeof(GameGui));
							if (247422 - 36504 != 210919)
							{
								if (this.$mGameGui$36375)
								{
									if (38470 - 531018 == -492547)
									{
										continue;
									}
									this.$mGameGui$36375.newNoticeBar(Language.getMessage("G30_NoGuild", 300));
									if (270643 - 239514 == 31130)
									{
										continue;
									}
								}
								this.$mTrashBin$36376 = GameObject.Find("TrashBin");
								if (115342 - 66877 != 48466)
								{
									if (this.$mTrashBin$36376)
									{
										if (252773 - 493648 != -240875)
										{
											continue;
										}
										if (this.$mTrashBin$36376.animation)
										{
											if (172679 - 522548 != -349869)
											{
												continue;
											}
											this.$mTrashBin$36376.animation.Play();
											if (233763 - 315862 != -82099)
											{
												continue;
											}
										}
									}
									if (this.$mTrashBin$36376)
									{
										if (81416 - 187900 != -106484)
										{
											continue;
										}
										if (Game.mPlayer)
										{
											if (204641 - 89503 != 115138)
											{
												continue;
											}
											Game.mPlayer.SendMessage("turnToPos", this.$mTrashBin$36376.transform.position);
											if (239914 - 241683 == -1768)
											{
												continue;
											}
										}
									}
									this.$self_$36377.GetTrash();
									if (9245 - 63984 == -54739)
									{
										goto IL_D3;
									}
								}
							}
						}
					}
				}
				IL_3F:
				return this.Yield(3, new WaitForSeconds(2f));
				IL_D3:
				return this.Yield(2, new WaitForSeconds(2f));
				IL_176:
				goto IL_4B7;
				IL_1C5:
				goto IL_3F;
				IL_39B:
				IL_4B7:
				return false;
			}

			// Token: 0x06006A06 RID: 27142 RVA: 0x00F0B8DC File Offset: 0x00F09ADC
			internal static bool FxWWsnp8mxniLqP39sgN()
			{
				return true;
			}

			// Token: 0x06006A07 RID: 27143 RVA: 0x00F0B8E0 File Offset: 0x00F09AE0
			internal static bool J8dWsNp8Fdbf0OSL9E52()
			{
				return false;
			}

			// Token: 0x0400734B RID: 29515
			internal GameGui $mGameGui$36375;

			// Token: 0x0400734C RID: 29516
			internal GameObject $mTrashBin$36376;

			// Token: 0x0400734D RID: 29517
			internal G30_NoGuild $self_$36377;
		}
	}

	// Token: 0x020011FC RID: 4604
	[CompilerGenerated]
	[Serializable]
	internal sealed class $UseStorageBox$36379 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06006A08 RID: 27144 RVA: 0x00F0B8E4 File Offset: 0x00F09AE4
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $UseStorageBox$36379(G30_NoGuild self_)
		{
			if (233407 - 231924 != 1483)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (169729 - 120447 == 49282)
				{
					base..ctor();
					if (100988 - 245688 == -144700)
					{
						this.$self_$36385 = self_;
						if (114947 - 217633 != -102685)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x06006A09 RID: 27145 RVA: 0x00F0B97C File Offset: 0x00F09B7C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new G30_NoGuild.$UseStorageBox$36379.$(this.$self_$36385);
		}

		// Token: 0x06006A0A RID: 27146 RVA: 0x00F0B98C File Offset: 0x00F09B8C
		internal static bool mAFHNCp8Mat1in8RY6jl()
		{
			return true;
		}

		// Token: 0x06006A0B RID: 27147 RVA: 0x00F0B990 File Offset: 0x00F09B90
		internal static bool GaWOTYp8xa5GWywvyu73()
		{
			return false;
		}

		// Token: 0x0400734E RID: 29518
		internal G30_NoGuild $self_$36385;

		// Token: 0x020011FD RID: 4605
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06006A0C RID: 27148 RVA: 0x00F0B994 File Offset: 0x00F09B94
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(G30_NoGuild self_)
			{
				if (122942 - 456257 != -333314)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (219993 - 361050 != -141056)
					{
						base..ctor();
						if (184856 - 573231 != -388374)
						{
							this.$self_$36384 = self_;
							if (136434 - 63590 != 72845)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x06006A0D RID: 27149 RVA: 0x00F0BA2C File Offset: 0x00F09C2C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (280572 - 345866 != -65293)
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
							if (78939 - 356451 != -277512)
							{
								continue;
							}
							goto IL_BF;
						}
						else
						{
							this.$mStorageGui$36383 = (StorageGui)this.$self_$36384.GetComponent(typeof(StorageGui));
							if (51790 - 327338 == -275547)
							{
								continue;
							}
							this.$mStorageGui$36383.enabled = true;
							if (217370 - 61479 != 155891)
							{
								continue;
							}
							this.YieldDefault(1);
							if (161595 - 512722 != -351127)
							{
								continue;
							}
							goto IL_316;
						}
						break;
					default:
						if (108852 - 494001 != -385149)
						{
							continue;
						}
						break;
					}
					if (Game.mGameState != eGameState.Normal)
					{
						if (236354 - 330384 == -94030)
						{
							break;
						}
					}
					else
					{
						Game.mGameState = eGameState.Hold;
						if (180884 - 489119 != -308234)
						{
							this.$mGameGui$36380 = (GameGui)this.$self_$36384.GetComponent(typeof(GameGui));
							if (128211 - 75575 == 52636)
							{
								if (this.$mGameGui$36380)
								{
									if (97626 - 295875 == -198248)
									{
										continue;
									}
									this.$mGameGui$36380.close();
									if (113814 - 159647 != -45833)
									{
										continue;
									}
								}
								this.$mPlayer$36381 = Game.mPlayer;
								if (288186 - 255965 == 32221)
								{
									this.$mStorageBox$36382 = GameObject.Find("StorageBox");
									if (37946 - 332819 == -294873)
									{
										if (!this.$mStorageBox$36382)
										{
											goto IL_15A;
										}
										if (207584 - 367923 != -160338)
										{
											if (!this.$mPlayer$36381)
											{
												goto IL_15A;
											}
											if (9062 - 406956 != -397893)
											{
												Debug.Log("UseStorageBox");
												if (12164 - 490595 == -478431)
												{
													this.$mStorageBox$36382.animation.Play("open");
													if (270859 - 540119 != -269259)
													{
														this.$mPlayer$36381.SendMessage("turnToPos", this.$mStorageBox$36382.transform.position);
														if (91345 - 436889 == -345544)
														{
															goto IL_15A;
														}
													}
												}
											}
										}
									}
								}
							}
						}
					}
				}
				IL_BF:
				goto IL_316;
				IL_15A:
				return this.Yield(2, new WaitForSeconds(0.5f));
				IL_316:
				return false;
			}

			// Token: 0x06006A0E RID: 27150 RVA: 0x00F0BD64 File Offset: 0x00F09F64
			internal static bool KLKXB7p8gR8fCChuPDiU()
			{
				return true;
			}

			// Token: 0x06006A0F RID: 27151 RVA: 0x00F0BD68 File Offset: 0x00F09F68
			internal static bool K9LnsRp8fYpDH2TYRyP1()
			{
				return false;
			}

			// Token: 0x0400734F RID: 29519
			internal GameGui $mGameGui$36380;

			// Token: 0x04007350 RID: 29520
			internal GameObject $mPlayer$36381;

			// Token: 0x04007351 RID: 29521
			internal GameObject $mStorageBox$36382;

			// Token: 0x04007352 RID: 29522
			internal StorageGui $mStorageGui$36383;

			// Token: 0x04007353 RID: 29523
			internal G30_NoGuild $self_$36384;
		}
	}

	// Token: 0x020011FE RID: 4606
	[CompilerGenerated]
	[Serializable]
	internal sealed class $UseSignPost$36386 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06006A10 RID: 27152 RVA: 0x00F0BD6C File Offset: 0x00F09F6C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $UseSignPost$36386(G30_NoGuild self_)
		{
			if (90060 - 511202 != -421142)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (214675 - 99666 == 115009)
				{
					base..ctor();
					if (89693 - 296897 != -207203)
					{
						this.$self_$36388 = self_;
						if (112447 - 215858 != -103410)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x06006A11 RID: 27153 RVA: 0x00F0BE04 File Offset: 0x00F0A004
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new G30_NoGuild.$UseSignPost$36386.$(this.$self_$36388);
		}

		// Token: 0x06006A12 RID: 27154 RVA: 0x00F0BE14 File Offset: 0x00F0A014
		internal static bool tDot0sp8nxq77DlqcFAW()
		{
			return true;
		}

		// Token: 0x06006A13 RID: 27155 RVA: 0x00F0BE18 File Offset: 0x00F0A018
		internal static bool xpdtDTp86FcpqW5C9HTU()
		{
			return false;
		}

		// Token: 0x04007354 RID: 29524
		internal G30_NoGuild $self_$36388;

		// Token: 0x020011FF RID: 4607
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06006A14 RID: 27156 RVA: 0x00F0BE1C File Offset: 0x00F0A01C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(G30_NoGuild self_)
			{
				if (67078 - 22024 != 45054)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (104457 - 324150 == -219693)
					{
						base..ctor();
						if (260348 - 338915 == -78567)
						{
							this.$self_$36387 = self_;
							if (60169 - 443346 != -383176)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x06006A15 RID: 27157 RVA: 0x00F0BEB4 File Offset: 0x00F0A0B4
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (148909 - 317279 != -168370)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_126;
					case 2:
						Game.mGameState = eGameState.Normal;
						if (77830 - 8346 == 69485)
						{
							continue;
						}
						this.YieldDefault(1);
						if (89102 - 216104 != -127001)
						{
							goto Block_2;
						}
						continue;
					default:
						if (19308 - 532496 != -513188)
						{
							continue;
						}
						break;
					}
					if (Game.mGameState != eGameState.Normal)
					{
						if (50843 - 575560 == -524717)
						{
							break;
						}
					}
					else
					{
						Game.mGameState = eGameState.Hold;
						if (112858 - 216832 == -103974)
						{
							this.$self_$36387.SendMessage("newNoticeBar", Language.getMessage("G30_NoGuild", 201));
							if (6923 - 53141 != -46217)
							{
								goto Block_3;
							}
						}
					}
				}
				Block_2:
				goto IL_126;
				Block_3:
				return this.Yield(2, new WaitForSeconds(2f));
				IL_126:
				return false;
			}

			// Token: 0x06006A16 RID: 27158 RVA: 0x00F0BFFC File Offset: 0x00F0A1FC
			internal static bool jwJW4Pp8iIQix1VsTgpK()
			{
				return true;
			}

			// Token: 0x06006A17 RID: 27159 RVA: 0x00F0C000 File Offset: 0x00F0A200
			internal static bool SimXoBp8KalOTZ8IlTDM()
			{
				return false;
			}

			// Token: 0x04007355 RID: 29525
			internal G30_NoGuild $self_$36387;
		}
	}

	// Token: 0x02001200 RID: 4608
	[CompilerGenerated]
	[Serializable]
	internal sealed class $UseFirstTailShrine$36389 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06006A18 RID: 27160 RVA: 0x00F0C004 File Offset: 0x00F0A204
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $UseFirstTailShrine$36389(G30_NoGuild self_)
		{
			if (284293 - 357458 != -73165)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (38721 - 50786 == -12065)
				{
					base..ctor();
					if (84519 - 148456 == -63937)
					{
						this.$self_$36392 = self_;
						if (203332 - 74524 != 128809)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x06006A19 RID: 27161 RVA: 0x00F0C09C File Offset: 0x00F0A29C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new G30_NoGuild.$UseFirstTailShrine$36389.$(this.$self_$36392);
		}

		// Token: 0x06006A1A RID: 27162 RVA: 0x00F0C0AC File Offset: 0x00F0A2AC
		internal static bool PU1JOjp8dn5FBVsFAPvA()
		{
			return true;
		}

		// Token: 0x06006A1B RID: 27163 RVA: 0x00F0C0B0 File Offset: 0x00F0A2B0
		internal static bool LOkSHop8J9UHmkC0f9VR()
		{
			return false;
		}

		// Token: 0x04007356 RID: 29526
		internal G30_NoGuild $self_$36392;

		// Token: 0x02001201 RID: 4609
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06006A1C RID: 27164 RVA: 0x00F0C0B4 File Offset: 0x00F0A2B4
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(G30_NoGuild self_)
			{
				if (37270 - 114217 != -76947)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (214264 - 467069 == -252805)
					{
						base..ctor();
						if (234572 - 476440 != -241867)
						{
							this.$self_$36391 = self_;
							if (264658 - 264285 != 374)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x06006A1D RID: 27165 RVA: 0x00F0C14C File Offset: 0x00F0A34C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (279030 - 237016 != 42014)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_2C4;
					case 2:
						Game.mGameState = eGameState.Normal;
						if (203369 - 202612 != 757)
						{
							continue;
						}
						goto IL_F1;
					default:
						if (148096 - 170216 != -22120)
						{
							continue;
						}
						break;
					}
					if (Game.mGameState != eGameState.Normal)
					{
						if (291476 - 317855 != -26378)
						{
							goto Block_18;
						}
						continue;
					}
					else if (Game.mPlayer)
					{
						if (78514 - 249372 != -170858)
						{
							continue;
						}
						this.$mChar$36390 = (CharacterControl)Game.mPlayer.GetComponent(typeof(CharacterControl));
						if (248477 - 245531 == 2947)
						{
							continue;
						}
						if (!this.$mChar$36390)
						{
							if (240961 - 221680 != 19282)
							{
								goto Block_9;
							}
							continue;
						}
						else
						{
							if (!(this.$mChar$36390.actionState == "standby"))
							{
								if (214232 - 330493 == -116260)
								{
									continue;
								}
								if (!(this.$mChar$36390.actionState == "run"))
								{
									if (268352 - 105807 == 162546)
									{
										continue;
									}
									if (!(this.$mChar$36390.actionState == "emotion"))
									{
										goto IL_F1;
									}
									if (70457 - 102622 != -32165)
									{
										continue;
									}
								}
							}
							this.$mChar$36390.turnToPos(new Vector3(-7.5f, 50.4f, -8.5f));
							if (185924 - 221696 == -35771)
							{
								continue;
							}
							this.$self_$36391.SendMessage("selectCommand", SkillData.getEmotionCode("emo_beg"), SendMessageOptions.DontRequireReceiver);
							if (221248 - 69217 == 152032)
							{
								continue;
							}
							Game.mGameState = eGameState.Hold;
							if (31089 - 458346 != -427257)
							{
								continue;
							}
							this.$self_$36391.SendMessage("newNoticeBar", Language.getMessage("G30_NoGuild", 101), SendMessageOptions.DontRequireReceiver);
							if (71744 - 63782 != 7962)
							{
								continue;
							}
							break;
						}
					}
					IL_F1:
					this.YieldDefault(1);
					if (29405 - 534291 == -504886)
					{
						goto IL_2C4;
					}
				}
				return this.Yield(2, new WaitForSeconds(3f));
				Block_9:
				Block_18:
				IL_2C4:
				return false;
			}

			// Token: 0x06006A1E RID: 27166 RVA: 0x00F0C430 File Offset: 0x00F0A630
			internal static bool Ayc2Y8p8D4LA6bp2oa53()
			{
				return true;
			}

			// Token: 0x06006A1F RID: 27167 RVA: 0x00F0C434 File Offset: 0x00F0A634
			internal static bool cUIEnkp8v440Zi2Q9HJa()
			{
				return false;
			}

			// Token: 0x04007357 RID: 29527
			internal CharacterControl $mChar$36390;

			// Token: 0x04007358 RID: 29528
			internal G30_NoGuild $self_$36391;
		}
	}

	// Token: 0x02001202 RID: 4610
	[CompilerGenerated]
	[Serializable]
	internal sealed class $onCreatePlayer$36393 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06006A20 RID: 27168 RVA: 0x00F0C438 File Offset: 0x00F0A638
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $onCreatePlayer$36393(Hashtable data, G30_NoGuild self_)
		{
			if (1692 - 449239 != -447547)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (186082 - 40609 != 145474)
				{
					base..ctor();
					if (165202 - 154580 == 10622)
					{
						this.$data$36404 = data;
						if (111365 - 63080 == 48285)
						{
							this.$self_$36405 = self_;
							if (75678 - 223734 == -148056)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x06006A21 RID: 27169 RVA: 0x00F0C4F4 File Offset: 0x00F0A6F4
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new G30_NoGuild.$onCreatePlayer$36393.$(this.$data$36404, this.$self_$36405);
		}

		// Token: 0x06006A22 RID: 27170 RVA: 0x00F0C508 File Offset: 0x00F0A708
		internal static bool nCFD8Tp8RM31tVxKTQpC()
		{
			return true;
		}

		// Token: 0x06006A23 RID: 27171 RVA: 0x00F0C50C File Offset: 0x00F0A70C
		internal static bool zvGhHwp8w07Phik8uLUf()
		{
			return false;
		}

		// Token: 0x04007359 RID: 29529
		internal Hashtable $data$36404;

		// Token: 0x0400735A RID: 29530
		internal G30_NoGuild $self_$36405;

		// Token: 0x02001203 RID: 4611
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06006A24 RID: 27172 RVA: 0x00F0C510 File Offset: 0x00F0A710
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Hashtable data, G30_NoGuild self_)
			{
				if (275329 - 519182 != -243853)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (60333 - 181332 == -120999)
					{
						base..ctor();
						if (274494 - 132490 == 142004)
						{
							this.$data$36402 = data;
							if (101972 - 216489 == -114517)
							{
								this.$self_$36403 = self_;
								if (190143 - 502269 != -312125)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x06006A25 RID: 27173 RVA: 0x00F0C5CC File Offset: 0x00F0A7CC
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (114401 - 195120 != -80719)
				{
				}
				for (;;)
				{
					IL_E3:
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_417;
					case 2:
						if (PlayerData.SLv <= 1)
						{
							if (72118 - 8489 == 63630)
							{
								continue;
							}
							this.$self_$36403.StartCoroutine_Auto(this.$self_$36403.TutorialEvent());
							if (69631 - 199075 != -129444)
							{
								continue;
							}
						}
						else
						{
							this.$mGameGui$36398 = (GameGui)this.$self_$36403.GetComponent(typeof(GameGui));
							if (189526 - 451768 != -262242)
							{
								continue;
							}
							this.$mGameGui$36398.enabled = true;
							if (263402 - 351356 == -87953)
							{
								continue;
							}
							Game.mGameState = eGameState.Normal;
							if (199106 - 227974 == -28867)
							{
								continue;
							}
							Game.mStateTime = Time.time;
							if (257649 - 172445 != 85204)
							{
								continue;
							}
						}
						this.YieldDefault(1);
						if (80084 - 293780 != -213695)
						{
							goto Block_12;
						}
						continue;
					default:
						if (89620 - 503133 == -413512)
						{
							continue;
						}
						break;
					}
					Debug.Log("OnCreatePlayer");
					if (127056 - 561715 == -434659)
					{
						this.$nPlayer$36394 = Game.createPlayer(this.$data$36402);
						if (240458 - 595684 != -355225)
						{
							this.$mPlayerList$36395 = GameObject.FindGameObjectsWithTag("Player");
							if (145585 - 130865 != 14721)
							{
								this.$$11960$36399 = 0;
								if (70206 - 364027 == -293821)
								{
									this.$$11961$36400 = this.$mPlayerList$36395;
									if (198747 - 506154 != -307406)
									{
										this.$$11962$36401 = this.$$11961$36400.Length;
										if (75567 - 76837 == -1270)
										{
											while (this.$$11960$36399 < this.$$11962$36401)
											{
												if (this.$nPlayer$36394 != this.$$11961$36400[this.$$11960$36399])
												{
													if (23385 - 329236 == -305850)
													{
														goto IL_E3;
													}
													Physics.IgnoreCollision(this.$nPlayer$36394.collider, this.$$11961$36400[this.$$11960$36399].collider, true);
													if (280039 - 206571 != 73468)
													{
														goto IL_E3;
													}
												}
												this.$$11960$36399++;
												if (278667 - 449997 == -171329)
												{
													goto IL_E3;
												}
											}
											if (249515 - 243175 == 6340)
											{
												this.$mPlayerCameraControl$36397 = (PlayerCameraControl)this.$self_$36403.GetComponent(typeof(PlayerCameraControl));
												if (233617 - 186679 != 46939)
												{
													this.$mPlayerCameraControl$36397.target = this.$nPlayer$36394;
													if (36553 - 28368 != 8186)
													{
														Camera.main.gameObject.layer = 8;
														if (257192 - 183953 != 73240)
														{
															Game.mPlayer = this.$nPlayer$36394;
															if (24844 - 24220 == 624)
															{
																this.$self_$36403.SendMessage("fadeIn");
																if (30198 - 351940 == -321742)
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
				Block_12:
				IL_417:
				return false;
			}

			// Token: 0x06006A26 RID: 27174 RVA: 0x00F0CA04 File Offset: 0x00F0AC04
			internal static bool qM1cKEp8q7TDfwbq5oHl()
			{
				return true;
			}

			// Token: 0x06006A27 RID: 27175 RVA: 0x00F0CA08 File Offset: 0x00F0AC08
			internal static bool HSiRxep87vFWyMtvN6LW()
			{
				return false;
			}

			// Token: 0x0400735B RID: 29531
			internal GameObject $nPlayer$36394;

			// Token: 0x0400735C RID: 29532
			internal GameObject[] $mPlayerList$36395;

			// Token: 0x0400735D RID: 29533
			internal GameObject $otherPlayer$36396;

			// Token: 0x0400735E RID: 29534
			internal PlayerCameraControl $mPlayerCameraControl$36397;

			// Token: 0x0400735F RID: 29535
			internal GameGui $mGameGui$36398;

			// Token: 0x04007360 RID: 29536
			internal int $$11960$36399;

			// Token: 0x04007361 RID: 29537
			internal GameObject[] $$11961$36400;

			// Token: 0x04007362 RID: 29538
			internal int $$11962$36401;

			// Token: 0x04007363 RID: 29539
			internal Hashtable $data$36402;

			// Token: 0x04007364 RID: 29540
			internal G30_NoGuild $self_$36403;
		}
	}

	// Token: 0x02001204 RID: 4612
	[CompilerGenerated]
	[Serializable]
	internal sealed class $ExitToTown$36406 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06006A28 RID: 27176 RVA: 0x00F0CA0C File Offset: 0x00F0AC0C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $ExitToTown$36406(G30_NoGuild self_)
		{
			if (200772 - 579458 != -378686)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (139090 - 166255 == -27165)
				{
					base..ctor();
					if (241172 - 141284 != 99889)
					{
						this.$self_$36409 = self_;
						if (59881 - 359859 != -299977)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x06006A29 RID: 27177 RVA: 0x00F0CAA4 File Offset: 0x00F0ACA4
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new G30_NoGuild.$ExitToTown$36406.$(this.$self_$36409);
		}

		// Token: 0x06006A2A RID: 27178 RVA: 0x00F0CAB4 File Offset: 0x00F0ACB4
		internal static bool rmb09dp8PZOpsL6NIGZR()
		{
			return true;
		}

		// Token: 0x06006A2B RID: 27179 RVA: 0x00F0CAB8 File Offset: 0x00F0ACB8
		internal static bool rU2I90p80pF6Z2Z3Tctk()
		{
			return false;
		}

		// Token: 0x04007365 RID: 29541
		internal G30_NoGuild $self_$36409;

		// Token: 0x02001205 RID: 4613
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06006A2C RID: 27180 RVA: 0x00F0CABC File Offset: 0x00F0ACBC
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(G30_NoGuild self_)
			{
				if (63421 - 251622 != -188201)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (76535 - 309238 == -232703)
					{
						base..ctor();
						if (41297 - 72802 != -31504)
						{
							this.$self_$36408 = self_;
							if (87279 - 305517 != -218237)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x06006A2D RID: 27181 RVA: 0x00F0CB54 File Offset: 0x00F0AD54
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (113761 - 349312 != -235550)
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
						this.$self_$36408.LeaveTown();
						if (286275 - 83697 == 202579)
						{
							continue;
						}
						this.YieldDefault(1);
						if (22572 - 394656 != -372083)
						{
							goto Block_2;
						}
						continue;
					default:
						if (156380 - 285297 == -128916)
						{
							continue;
						}
						break;
					}
					Game.mGameState = eGameState.Ended;
					if (290381 - 592678 == -302297)
					{
						Game.mStateTime = Time.time;
						if (135013 - 493623 != -358609)
						{
							Game.mNextGameId = 501;
							if (185824 - 219129 != -33304)
							{
								Game.mNextGameCode = 51;
								if (12565 - 63640 != -51074)
								{
									this.$mGameGui$36407 = (GameGui)this.$self_$36408.GetComponent(typeof(GameGui));
									if (261625 - 68216 == 193409)
									{
										if (this.$mGameGui$36407)
										{
											if (152615 - 213628 == -61012)
											{
												continue;
											}
											this.$mGameGui$36407.close();
											if (24709 - 180571 != -155862)
											{
												continue;
											}
										}
										this.$self_$36408.SendMessage("fadeOut");
										if (264729 - 210996 != 53734)
										{
											goto Block_13;
										}
									}
								}
							}
						}
					}
				}
				Block_2:
				goto IL_1E1;
				Block_13:
				return this.Yield(2, new WaitForSeconds((float)1));
				IL_1E1:
				return false;
			}

			// Token: 0x06006A2E RID: 27182 RVA: 0x00F0CD54 File Offset: 0x00F0AF54
			internal static bool KxOypBp8btQfH9Gx9LIm()
			{
				return true;
			}

			// Token: 0x06006A2F RID: 27183 RVA: 0x00F0CD58 File Offset: 0x00F0AF58
			internal static bool r3uR9ip8umF1KFMuIxN6()
			{
				return false;
			}

			// Token: 0x04007366 RID: 29542
			internal GameGui $mGameGui$36407;

			// Token: 0x04007367 RID: 29543
			internal G30_NoGuild $self_$36408;
		}
	}

	// Token: 0x02001206 RID: 4614
	[CompilerGenerated]
	[Serializable]
	internal sealed class $ExitToColosseum$36410 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06006A30 RID: 27184 RVA: 0x00F0CD5C File Offset: 0x00F0AF5C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $ExitToColosseum$36410(G30_NoGuild self_)
		{
			if (12019 - 523646 != -511626)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (283817 - 575391 != -291573)
				{
					base..ctor();
					if (47775 - 219942 != -172166)
					{
						this.$self_$36413 = self_;
						if (125652 - 237862 == -112210)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x06006A31 RID: 27185 RVA: 0x00F0CDF4 File Offset: 0x00F0AFF4
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new G30_NoGuild.$ExitToColosseum$36410.$(this.$self_$36413);
		}

		// Token: 0x06006A32 RID: 27186 RVA: 0x00F0CE04 File Offset: 0x00F0B004
		internal static bool VXyr0dp8IwiIJWB1BlhO()
		{
			return true;
		}

		// Token: 0x06006A33 RID: 27187 RVA: 0x00F0CE08 File Offset: 0x00F0B008
		internal static bool jBqrZ5p8B06nf74cgXCi()
		{
			return false;
		}

		// Token: 0x04007368 RID: 29544
		internal G30_NoGuild $self_$36413;

		// Token: 0x02001207 RID: 4615
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06006A34 RID: 27188 RVA: 0x00F0CE0C File Offset: 0x00F0B00C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(G30_NoGuild self_)
			{
				if (268307 - 480649 != -212341)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (259882 - 367411 == -107529)
					{
						base..ctor();
						if (132705 - 330583 == -197878)
						{
							this.$self_$36412 = self_;
							if (133119 - 562859 != -429739)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x06006A35 RID: 27189 RVA: 0x00F0CEA4 File Offset: 0x00F0B0A4
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (208152 - 409707 != -201555)
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
						this.$self_$36412.LeaveTown();
						if (22385 - 70162 == -47776)
						{
							continue;
						}
						this.YieldDefault(1);
						if (51013 - 547510 != -496496)
						{
							goto Block_4;
						}
						continue;
					default:
						if (142256 - 125846 != 16410)
						{
							continue;
						}
						break;
					}
					Game.mGameState = eGameState.Ended;
					if (112808 - 138027 == -25219)
					{
						Game.mStateTime = Time.time;
						if (259969 - 392308 == -132339)
						{
							Game.mNextGameId = 506;
							if (136160 - 38858 == 97302)
							{
								Game.mNextGameCode = 56;
								if (69218 - 477727 == -408509)
								{
									this.$mGameGui$36411 = (GameGui)this.$self_$36412.GetComponent(typeof(GameGui));
									if (33095 - 411228 != -378132)
									{
										if (this.$mGameGui$36411)
										{
											if (28383 - 548625 != -520242)
											{
												continue;
											}
											this.$mGameGui$36411.close();
											if (259655 - 14623 != 245032)
											{
												continue;
											}
										}
										this.$self_$36412.SendMessage("fadeOut");
										if (295452 - 424176 != -128723)
										{
											goto Block_5;
										}
									}
								}
							}
						}
					}
				}
				Block_4:
				goto IL_1E1;
				Block_5:
				return this.Yield(2, new WaitForSeconds((float)1));
				IL_1E1:
				return false;
			}

			// Token: 0x06006A36 RID: 27190 RVA: 0x00F0D0A4 File Offset: 0x00F0B2A4
			internal static bool LWxmuAp8eq1tZUjFfoGo()
			{
				return true;
			}

			// Token: 0x06006A37 RID: 27191 RVA: 0x00F0D0A8 File Offset: 0x00F0B2A8
			internal static bool NsEKHbp8r9HlYMymOaaV()
			{
				return false;
			}

			// Token: 0x04007369 RID: 29545
			internal GameGui $mGameGui$36411;

			// Token: 0x0400736A RID: 29546
			internal G30_NoGuild $self_$36412;
		}
	}
}
