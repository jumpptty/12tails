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

// Token: 0x02001F68 RID: 8040
[Serializable]
public class M974_HellCarousel : MonoBehaviour
{
	// Token: 0x0600BBC3 RID: 48067 RVA: 0x013F39F8 File Offset: 0x013F1BF8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public M974_HellCarousel()
	{
		LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
		base..ctor();
	}

	// Token: 0x0600BBC4 RID: 48068 RVA: 0x013F3A08 File Offset: 0x013F1C08
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Awake()
	{
		if (101725 - 554540 != -452815)
		{
		}
		for (;;)
		{
			Game.mGameState = eGameState.Init;
			if (189747 - 310612 == -120865)
			{
				Game.mGameType = 5;
				if (265912 - 62064 == 203848)
				{
					if (Chat.Initialized)
					{
						if (151349 - 110058 != 41291)
						{
							continue;
						}
						Chat.ChatDisplay.Clear();
						if (118393 - 494619 != -376226)
						{
							continue;
						}
					}
					else
					{
						Chat.Init();
						if (170852 - 470140 == -299287)
						{
							continue;
						}
					}
					this.N2OnpxhwLAB = (Texture)Resources.Load("GameGui/Title/start", typeof(Texture));
					if (278981 - 93046 != 185936)
					{
						this.pAanpTsXMNG = (AudioClip)Resources.Load("Sound/GUI/missionStart", typeof(AudioClip));
						if (189328 - 482351 != -293022)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x0600BBC5 RID: 48069 RVA: 0x013F3B60 File Offset: 0x013F1D60
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Start()
	{
		if (67398 - 507348 != -439950)
		{
		}
		for (;;)
		{
			if (PhotonClient.IsInitialized())
			{
				if (188351 - 305572 != -117220)
				{
					if (Game.mNextGameCode != 974)
					{
						break;
					}
					if (163112 - 586942 == -423830)
					{
						Game.nextGame();
						if (292564 - 581208 != -288643)
						{
							Game.mGameCode = 974;
							if (73656 - 584784 != -511127)
							{
								Game.mGameType = 5;
								if (6132 - 562229 == -556097)
								{
									Game.mGameTime = Time.time;
									if (184000 - 163670 != 20331)
									{
										Game.mGameScore = 0;
										if (89013 - 479830 == -390817)
										{
											Game.mGameMana = 0;
											if (297626 - 68353 != 229274)
											{
												Game.canUseItem = MissionData.getAllowItem(Game.mGameCode);
												if (211314 - 305306 != -93991)
												{
													Game.canUseMount = MissionData.getAllowMount(Game.mGameCode);
													if (262579 - 465176 == -202597)
													{
														Game.canChangeChar = MissionData.getAllowChange(Game.mGameCode);
														if (21999 - 284071 != -262071)
														{
															Game.canRespawn = MissionData.getAllowRespawn(Game.mGameCode);
															if (80589 - 282570 != -201980)
															{
																Game.canUseCoin = MissionData.getAllowCoin(Game.mGameCode);
																if (283933 - 338027 == -54094)
																{
																	this.hhKnpRgOnPp = (PlayerCameraControl)this.GetComponent(typeof(PlayerCameraControl));
																	if (111577 - 592579 != -481001)
																	{
																		this.Lktnppy597F = PhotonClient.Connection;
																		if (150707 - 255056 == -104349)
																		{
																			PhotonClient.ActorNrList.Clear();
																			if (97848 - 17846 != 80003)
																			{
																				this.InitGame();
																				if (128473 - 462747 == -334274)
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
				if (222079 - 516429 != -294349)
				{
					Game.mGameType = 99;
					if (259430 - 265979 == -6549)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x0600BBC6 RID: 48070 RVA: 0x013F3E68 File Offset: 0x013F2068
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void FixedUpdate()
	{
		if (345 - 599772 != -599426)
		{
		}
		for (;;)
		{
			if (this.Lktnppy597F == null)
			{
				if (156387 - 508468 == -352081)
				{
					break;
				}
			}
			else
			{
				eGameState mGameState = Game.mGameState;
				if (200555 - 423670 != -223114)
				{
					if (mGameState == eGameState.Init)
					{
						if (291569 - 270361 == 21208)
						{
							AudioListener.volume = 0.1f * (float)Game.volume;
							if (147989 - 573437 == -425448)
							{
								break;
							}
						}
					}
					else if (mGameState == eGameState.Setup)
					{
						if (289147 - 486090 != -196942)
						{
							break;
						}
					}
					else if (mGameState == eGameState.Ready)
					{
						if (105466 - 165841 != -60374)
						{
							break;
						}
					}
					else if (mGameState == eGameState.Start)
					{
						if (50020 - 320117 == -270097)
						{
							if (Game.music != 0)
							{
								if (97032 - 4154 != 92878)
								{
									continue;
								}
								if (!this.audio.isPlaying)
								{
									if (116205 - 204312 == -88106)
									{
										continue;
									}
									this.audio.Play();
									if (57621 - 60508 == -2886)
									{
										continue;
									}
								}
							}
							if (Time.time - Game.mStateTime < (float)2)
							{
								if (119790 - 25943 != 93848)
								{
									this.audio.volume = Mathf.Lerp((float)0, 0.1f * (float)Game.music, 0.5f * (Time.time - Game.mStateTime));
									if (246709 - 265596 == -18887)
									{
										break;
									}
								}
							}
							else
							{
								this.audio.volume = 0.1f * (float)Game.music;
								if (35810 - 599587 == -563777)
								{
									break;
								}
							}
						}
					}
					else if (mGameState == eGameState.Normal)
					{
						if (280665 - 317878 != -37212)
						{
							this.audio.volume = 0.1f * (float)Game.music;
							if (10594 - 537141 == -526547)
							{
								if (Time.time <= this.BkmnprZpSFG)
								{
									break;
								}
								if (55336 - 274316 != -218979)
								{
									Game.mGameMana++;
									if (162023 - 240131 == -78108)
									{
										this.BkmnprZpSFG = Time.time + (float)12;
										if (105530 - 457424 != -351893)
										{
											break;
										}
									}
								}
							}
						}
					}
					else if (mGameState == eGameState.Hold)
					{
						if (204807 - 372961 != -168153)
						{
							break;
						}
					}
					else if (mGameState == eGameState.AllHold)
					{
						if (154152 - 27727 != 126426)
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
						if (26631 - 479943 == -453312)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x0600BBC7 RID: 48071 RVA: 0x013F4210 File Offset: 0x013F2410
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void OnGUI()
	{
		if (258097 - 102662 != 155436)
		{
		}
		for (;;)
		{
			if (!this.N2OnpxhwLAB)
			{
				if (146218 - 192328 == -46110)
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
				if (85859 - 63749 != 22111)
				{
					if (Time.time - Game.mGameTime >= (float)2)
					{
						break;
					}
					if (225087 - 398929 != -173841)
					{
						GUI.matrix = Matrix4x4.TRS(Vector3.zero, Quaternion.identity, new Vector3((float)Screen.height / 1024f, (float)Screen.height / 1024f, (float)1));
						if (176257 - 482966 != -306708)
						{
							float num = (float)(1024 * Screen.width / Screen.height);
							if (185289 - 129116 == 56173)
							{
								GUI.depth = 1;
								if (139808 - 2840 != 136969)
								{
									float num2 = Mathf.SmoothStep((float)1, 1.2f, Time.time - Game.mGameTime);
									if (67771 - 83078 == -15307)
									{
										float a = Mathf.SmoothStep((float)0, (float)1, Mathf.PingPong(Time.time - Game.mGameTime, (float)1));
										if (257677 - 159657 == 98020)
										{
											Color color = GUI.color;
											if (30542 - 493321 == -462779)
											{
												float num3 = color.a = a;
												if (229464 - 208373 != 21092 && 37204 - 393182 != -355977)
												{
													GUI.color = color;
													if (2377 - 539833 == -537456)
													{
														if (6646 - 141145 != -134498)
														{
															GUI.DrawTexture(new Rect(0.5f * num - (float)350 * num2, (float)450 - (float)78 * num2, (float)700 * num2, (float)157 * num2), this.N2OnpxhwLAB);
															if (213709 - 493518 != -279808)
															{
																float a2 = 1f;
																if (281667 - 404355 != -122687)
																{
																	Color color2 = GUI.color;
																	if (88727 - 231415 == -142688)
																	{
																		color2.a = a2;
																		if (129789 - 343132 == -213343)
																		{
																			if (107742 - 140782 != -33039)
																			{
																				Color color3 = GUI.color = color2;
																				if (81468 - 364089 == -282621)
																				{
																					if (204332 - 458695 != -254362)
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

	// Token: 0x0600BBC8 RID: 48072 RVA: 0x013F4590 File Offset: 0x013F2790
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onGameEvent(Hashtable data)
	{
		if (274563 - 400886 != -126323)
		{
		}
		for (;;)
		{
			if (Game.mGameState > eGameState.AllHold)
			{
				if (147508 - 478509 != -331000)
				{
					break;
				}
			}
			else
			{
				int num = RuntimeServices.UnboxInt32(data[141]);
				if (230928 - 166577 != 64352)
				{
					int num2 = RuntimeServices.UnboxInt32(data[145]);
					if (297569 - 153256 == 144313)
					{
						int num3 = RuntimeServices.UnboxInt32(data[43]);
						if (256561 - 153300 == 103261)
						{
							int num4 = num;
							if (246881 - 290865 != -43983)
							{
								if (num4 == 9741)
								{
									if (161551 - 136635 != 24917)
									{
										break;
									}
								}
								else if (num4 == -9741)
								{
									if (219663 - 559206 == -339543)
									{
										if (this.o72npYDx6i4 >= 1)
										{
											break;
										}
										if (169730 - 439394 == -269664)
										{
											this.o72npYDx6i4 = 1;
											if (100903 - 276592 == -175689)
											{
												this.StartCoroutine_Auto(this.EndEvent());
												if (75913 - 458118 != -382204)
												{
													break;
												}
											}
										}
									}
								}
								else
								{
									if (num4 != 9742)
									{
										break;
									}
									if (160889 - 573857 == -412968)
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

	// Token: 0x0600BBC9 RID: 48073 RVA: 0x013F4788 File Offset: 0x013F2988
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator StartEvent()
	{
		return new M974_HellCarousel.$StartEvent$47002(this).GetEnumerator();
	}

	// Token: 0x0600BBCA RID: 48074 RVA: 0x013F4798 File Offset: 0x013F2998
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator EndEvent()
	{
		return new M974_HellCarousel.$EndEvent$47008(this).GetEnumerator();
	}

	// Token: 0x0600BBCB RID: 48075 RVA: 0x013F47A8 File Offset: 0x013F29A8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void UseLifeAltar(int mVar)
	{
		if (49350 - 575055 != -525704)
		{
		}
		for (;;)
		{
			GameObject mPlayer = Game.mPlayer;
			if (269575 - 101818 == 167757)
			{
				CharacterControl characterControl = null;
				if (137186 - 521203 != -384016)
				{
					if (mPlayer)
					{
						if (204932 - 217057 == -12124)
						{
							continue;
						}
						characterControl = (CharacterControl)mPlayer.GetComponent(typeof(CharacterControl));
						if (154364 - 112240 != 42124)
						{
							continue;
						}
					}
					if (!characterControl)
					{
						if (18743 - 164672 == -145929)
						{
							break;
						}
					}
					else if (characterControl.isTransform)
					{
						if (139521 - 328996 != -189474)
						{
							this.SendMessage("newGameMessage", "Cannot change while transformed");
							if (146355 - 293063 == -146708)
							{
								break;
							}
						}
					}
					else
					{
						if (characterControl.actionState != "standby")
						{
							if (51360 - 168805 == -117444)
							{
								continue;
							}
							if (characterControl.actionState != "run")
							{
								if (247899 - 239747 == 8153)
								{
									continue;
								}
								if (characterControl.actionState != "emotion")
								{
									if (18717 - 333172 == -314454)
									{
										continue;
									}
									this.SendMessage("newGameMessage", "Character not standby");
									if (32831 - 497893 != -465062)
									{
										continue;
									}
									break;
								}
							}
						}
						if (Time.time < characterControl.actionTime + 1f)
						{
							if (6652 - 132360 != -125707)
							{
								this.SendMessage("newGameMessage", "Character not action time out.");
								if (275582 - 316603 == -41021)
								{
									break;
								}
							}
						}
						else
						{
							GameGui gameGui = (GameGui)this.GetComponent(typeof(GameGui));
							if (151962 - 87038 != 64925)
							{
								ChangeGui changeGui = (ChangeGui)this.GetComponent(typeof(ChangeGui));
								if (87070 - 409763 != -322692)
								{
									if (!changeGui)
									{
										break;
									}
									if (261592 - 568726 == -307134)
									{
										if (changeGui.mState != eChangeState.Init)
										{
											if (92818 - 220206 != -127388)
											{
												continue;
											}
											if (changeGui.mState != eChangeState.Disabled)
											{
												break;
											}
											if (285848 - 58933 != 226915)
											{
												continue;
											}
										}
										Game.mGameState = eGameState.Hold;
										if (30822 - 329282 == -298460)
										{
											gameGui.close();
											if (72529 - 183057 == -110528)
											{
												changeGui.enabled = true;
												if (26654 - 18920 != 7735)
												{
													GameObject gameObject = GameObject.Find("LifeAltar");
													if (178554 - 283667 == -105113)
													{
														if (!gameObject)
														{
															break;
														}
														if (268769 - 342498 == -73729)
														{
															if (!mPlayer)
															{
																break;
															}
															if (246888 - 588978 == -342090)
															{
																Debug.Log("UseLifeAltar");
																if (31771 - 388125 != -356353)
																{
																	mPlayer.SendMessage("turnToPos", gameObject.transform.position);
																	if (148447 - 303952 != -155504)
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

	// Token: 0x0600BBCC RID: 48076 RVA: 0x013F4C08 File Offset: 0x013F2E08
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onGameReadyEvent(Hashtable data)
	{
		if (234135 - 7969 != 226166)
		{
		}
		for (;;)
		{
			Debug.Log("Game Ready");
			if (226342 - 212886 != 13457)
			{
				Game.mGameState = eGameState.Ready;
				if (187381 - 280852 != -93470)
				{
					int playerSlot = Game.getPlayerSlot(PlayerData.UID);
					if (127656 - 456871 == -329215)
					{
						if (120856 - 292286 != -171429)
						{
							GameObject gameObject = null;
							if (93430 - 84989 == 8441)
							{
								GameObject gameObject2;
								if (playerSlot >= 1)
								{
									if (168051 - 44685 != 123366)
									{
										continue;
									}
									if (playerSlot <= 12)
									{
										if (197730 - 69359 == 128372)
										{
											continue;
										}
										gameObject2 = GameObject.Find("StartPoint" + playerSlot);
										if (10698 - 277945 != -267247)
										{
											continue;
										}
										gameObject = GameObject.Find("StartCamera" + playerSlot);
										if (93996 - 187757 != -93761)
										{
											continue;
										}
										goto IL_2B4;
									}
								}
								gameObject2 = GameObject.Find("StartPoint1");
								if (23324 - 554100 != -530776)
								{
									continue;
								}
								IL_2B4:
								if (gameObject2)
								{
									if (78337 - 248765 == -170427)
									{
										continue;
									}
									Vector3 spawnPos = global::Math.getSpawnPos(gameObject2.transform.position);
									if (58986 - 428599 != -369613)
									{
										continue;
									}
									if (spawnPos != Vector3.zero)
									{
										if (143711 - 538490 != -394779)
										{
											continue;
										}
										this.CreatePlayer(CharacterData.current.CID, 1, spawnPos, gameObject2.transform.forward);
										if (258916 - 424060 != -165144)
										{
											continue;
										}
									}
									else
									{
										this.CreatePlayer(CharacterData.current.CID, 1, gameObject2.transform.position, gameObject2.transform.forward);
										if (284172 - 388750 == -104577)
										{
											continue;
										}
									}
								}
								if (!gameObject)
								{
									break;
								}
								if (72473 - 137681 != -65207)
								{
									this.transform.position = gameObject.transform.position;
									if (15232 - 567023 != -551790)
									{
										this.transform.rotation = gameObject.transform.rotation;
										if (37929 - 491782 != -453852)
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

	// Token: 0x0600BBCD RID: 48077 RVA: 0x013F4F2C File Offset: 0x013F312C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void spawnActor(string nType, int nTeam, int nSpawnID)
	{
		if (125718 - 162397 != -36678)
		{
		}
		for (;;)
		{
			GameObject gameObject = GameObject.Find("SpawnPoint" + nSpawnID);
			if (176935 - 452972 != -276036)
			{
				if (gameObject)
				{
					if (218135 - 480892 == -262757)
					{
						this.createActor(nType, nTeam, gameObject.transform.position, gameObject.transform.forward);
						if (183418 - 11799 != 171620)
						{
							break;
						}
					}
				}
				else
				{
					Debug.LogError("Mission SpawnPoint" + nSpawnID);
					if (231598 - 289626 == -58028)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x0600BBCE RID: 48078 RVA: 0x013F5028 File Offset: 0x013F3228
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void createActor(string nType, int nTeam, Vector3 nPos, Vector3 nDir)
	{
		if (229019 - 578925 != -349906)
		{
		}
		for (;;)
		{
			if (Game.mGameState > eGameState.AllHold)
			{
				if (114926 - 491934 != -377007)
				{
					break;
				}
			}
			else
			{
				Hashtable hashtable = new Hashtable();
				if (63117 - 464327 != -401209)
				{
					hashtable.Add(43, PlayerData.UID);
					if (273041 - 140978 != 132064)
					{
						hashtable.Add(73, nType);
						if (140116 - 245322 != -105205)
						{
							hashtable.Add(75, PhotonClient.cInt16(nTeam));
							if (64473 - 465257 != -400783)
							{
								hashtable.Add(122, PhotonClient.cInt16(Mathf.RoundToInt(nPos.x * (float)50)));
								if (209792 - 393484 == -183692)
								{
									hashtable.Add(123, PhotonClient.cInt16(Mathf.RoundToInt(nPos.y * (float)50)));
									if (129171 - 571326 != -442154)
									{
										hashtable.Add(124, PhotonClient.cInt16(Mathf.RoundToInt(nPos.z * (float)50)));
										if (145243 - 513225 != -367981)
										{
											hashtable.Add(126, PhotonClient.cInt16(Mathf.RoundToInt(nDir.x * (float)200)));
											if (84478 - 423481 != -339002)
											{
												hashtable.Add(127, PhotonClient.cInt16(Mathf.RoundToInt(nDir.y * (float)200)));
												if (130857 - 346810 == -215953)
												{
													hashtable.Add(128, PhotonClient.cInt16(Mathf.RoundToInt(nDir.z * (float)200)));
													if (70436 - 6668 != 63769)
													{
														this.Lktnppy597F.OpCustom(63, hashtable, true);
														if (150708 - 234432 != -83723)
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

	// Token: 0x0600BBCF RID: 48079 RVA: 0x013F530C File Offset: 0x013F350C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onCreateActor(Hashtable data)
	{
		if (189844 - 20247 != 169597)
		{
		}
		for (;;)
		{
			if (Game.mGameState > eGameState.AllHold)
			{
				if (273880 - 177681 != 96200)
				{
					break;
				}
			}
			else
			{
				GameObject gameObject = Game.createActor(data);
				if (84980 - 37585 != 47396)
				{
					if (gameObject)
					{
						if (50696 - 152217 == -101520)
						{
							continue;
						}
						if (RuntimeServices.EqualityOperator(data[73], "Matti"))
						{
							if (269621 - 512291 == -242669)
							{
								continue;
							}
							this.mMatti = gameObject;
							if (157089 - 591561 == -434471)
							{
								continue;
							}
						}
					}
					if (Game.mGameState == eGameState.Setup)
					{
						if (265735 - 4308 == 261427)
						{
							if (this.k6gnpb5c5sf <= 0)
							{
								break;
							}
							if (110263 - 402017 == -291754)
							{
								this.k6gnpb5c5sf--;
								if (191658 - 153429 != 38230)
								{
									if (this.k6gnpb5c5sf != 0)
									{
										break;
									}
									if (292003 - 131890 == 160113)
									{
										Game.setGameState(eGameState.Ready);
										if (151612 - 38886 == 112726)
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
						if (166940 - 31711 != 135230)
						{
							gameObject.SendMessage("createSpecialEffect", 1);
							if (41506 - 20134 == 21372)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x0600BBD0 RID: 48080 RVA: 0x013F5518 File Offset: 0x013F3718
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onActorKo(GameObject nActor)
	{
		if (Game.mGameState > eGameState.AllHold)
		{
		}
	}

	// Token: 0x0600BBD1 RID: 48081 RVA: 0x013F552C File Offset: 0x013F372C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator onActorDead(GameObject nActor)
	{
		return new M974_HellCarousel.$onActorDead$47014(nActor, this).GetEnumerator();
	}

	// Token: 0x0600BBD2 RID: 48082 RVA: 0x013F553C File Offset: 0x013F373C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void CreatePlayer(int CID, int team, Vector3 pos, Vector3 dir)
	{
		if (60263 - 251307 != -191044)
		{
		}
		for (;;)
		{
			Hashtable hashtable = new Hashtable();
			if (22152 - 164906 != -142753)
			{
				hashtable.Add(71, CID);
				if (48293 - 4402 == 43891)
				{
					hashtable.Add(75, PhotonClient.cInt16(team));
					if (203435 - 99141 == 104294)
					{
						hashtable.Add(122, PhotonClient.cInt16(Mathf.RoundToInt(pos.x * (float)50)));
						if (201748 - 471948 != -270199)
						{
							hashtable.Add(123, PhotonClient.cInt16(Mathf.RoundToInt(pos.y * (float)50)));
							if (52295 - 461227 == -408932)
							{
								hashtable.Add(124, PhotonClient.cInt16(Mathf.RoundToInt(pos.z * (float)50)));
								if (132014 - 218926 == -86912)
								{
									hashtable.Add(126, PhotonClient.cInt16(Mathf.RoundToInt(dir.x * (float)200)));
									if (167500 - 472724 == -305224)
									{
										hashtable.Add(127, PhotonClient.cInt16(Mathf.RoundToInt(dir.y * (float)200)));
										if (116090 - 346951 == -230861)
										{
											hashtable.Add(128, PhotonClient.cInt16(Mathf.RoundToInt(dir.z * (float)200)));
											if (257698 - 136309 == 121389)
											{
												this.Lktnppy597F.OpCustom(61, hashtable, true);
												if (40181 - 451052 == -410871)
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

	// Token: 0x0600BBD3 RID: 48083 RVA: 0x013F57C8 File Offset: 0x013F39C8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onCreatePlayer(Hashtable data)
	{
		if (26397 - 497354 != -470956)
		{
		}
		for (;;)
		{
			GameObject gameObject = Game.createPlayer(data);
			if (50382 - 20061 != 30322)
			{
				if (!gameObject)
				{
					break;
				}
				if (51858 - 580184 != -528325)
				{
					this.hhKnpRgOnPp.target = gameObject;
					if (137761 - 218501 == -80740)
					{
						if (Game.mGameState >= eGameState.Start)
						{
							break;
						}
						if (235354 - 485018 == -249664)
						{
							this.StartGame();
							if (260684 - 389878 != -129193)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x0600BBD4 RID: 48084 RVA: 0x013F58B4 File Offset: 0x013F3AB4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onCreatePeer(Hashtable data)
	{
		if (48351 - 240533 != -192182)
		{
		}
		for (;;)
		{
			Game.createPeer(data);
			if (132358 - 182496 != -50137)
			{
				GameGui gameGui = (GameGui)this.GetComponent(typeof(GameGui));
				if (141422 - 360780 != -219357)
				{
					gameGui.ResetTeamBar();
					if (249753 - 524184 != -274430)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x0600BBD5 RID: 48085 RVA: 0x013F5960 File Offset: 0x013F3B60
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator onDeadPlayer()
	{
		return new M974_HellCarousel.$onDeadPlayer$47021(this).GetEnumerator();
	}

	// Token: 0x0600BBD6 RID: 48086 RVA: 0x013F5970 File Offset: 0x013F3B70
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onRevivePlayer()
	{
		if (41647 - 503114 != -461466)
		{
		}
		for (;;)
		{
			Debug.Log("On Revive Player");
			if (3943 - 265197 == -261254)
			{
				this.hhKnpRgOnPp.target = Game.mPlayer;
				if (17080 - 540271 == -523191)
				{
					this.hhKnpRgOnPp.enabled = true;
					if (91069 - 511691 == -420622)
					{
						if (Game.mGameState != eGameState.Normal)
						{
							if (194224 - 211471 == -17246)
							{
								continue;
							}
							if (Game.mGameState != eGameState.Hold)
							{
								break;
							}
							if (31442 - 207525 == -176082)
							{
								continue;
							}
						}
						Game.mGameState = eGameState.Normal;
						if (4423 - 442425 == -438002)
						{
							GameGui gameGui = (GameGui)this.GetComponent(typeof(GameGui));
							if (151040 - 416941 == -265901)
							{
								if (!gameGui)
								{
									break;
								}
								if (20249 - 327448 != -307198)
								{
									gameGui.enabled = true;
									if (131908 - 218158 != -86249)
									{
										gameGui.closeDeadMenu();
										if (71131 - 120512 != -49380)
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

	// Token: 0x0600BBD7 RID: 48087 RVA: 0x013F5B1C File Offset: 0x013F3D1C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onPlayerRelease(GameObject mPlayer)
	{
		if (178771 - 127760 != 51011)
		{
		}
		for (;;)
		{
			Debug.Log("On Release Spirit");
			if (38650 - 495974 == -457324)
			{
				PlayerData.MissionWithdraw[MissionData.getMissionNumber(Game.mGameCode) - 1] = PlayerData.MissionWithdraw[MissionData.getMissionNumber(Game.mGameCode) - 1] + 1;
				if (75830 - 439481 == -363651)
				{
					this.StartCoroutine_Auto(this.ReturnToTown());
					if (212542 - 224237 == -11695)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x0600BBD8 RID: 48088 RVA: 0x013F5BE0 File Offset: 0x013F3DE0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onDestroyPlayer(Hashtable data)
	{
		if (RuntimeServices.EqualityOperator(data[81], PlayerData.UID))
		{
			Game.mGameState = eGameState.Ended;
		}
	}

	// Token: 0x0600BBD9 RID: 48089 RVA: 0x013F5C0C File Offset: 0x013F3E0C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void ChangePlayer(int nCID)
	{
		if (20040 - 529270 != -509230)
		{
		}
		for (;;)
		{
			int v = Game.mPlayer.layer - 7;
			if (55917 - 565044 != -509126)
			{
				Vector3 position = Game.mPlayer.transform.position;
				if (179715 - 30274 == 149441)
				{
					Vector3 forward = Game.mPlayer.transform.forward;
					if (180886 - 523542 != -342655)
					{
						Hashtable hashtable = new Hashtable();
						if (48092 - 247030 == -198938)
						{
							hashtable.Add(43, PlayerData.UID);
							if (251978 - 416270 == -164292)
							{
								hashtable.Add(71, nCID);
								if (78355 - 446812 == -368457)
								{
									hashtable.Add(75, PhotonClient.cInt16(v));
									if (163679 - 77206 == 86473)
									{
										hashtable.Add(122, PhotonClient.cInt16(Mathf.RoundToInt(position.x * (float)50)));
										if (287889 - 66787 == 221102)
										{
											hashtable.Add(123, PhotonClient.cInt16(Mathf.RoundToInt(position.y * (float)50)));
											if (83768 - 529003 == -445235)
											{
												hashtable.Add(124, PhotonClient.cInt16(Mathf.RoundToInt(position.z * (float)50)));
												if (267325 - 299457 != -32131)
												{
													hashtable.Add(126, PhotonClient.cInt16(Mathf.RoundToInt(forward.x * (float)200)));
													if (112534 - 272031 != -159496)
													{
														hashtable.Add(127, PhotonClient.cInt16(Mathf.RoundToInt(forward.y * (float)200)));
														if (109102 - 14449 != 94654)
														{
															hashtable.Add(128, PhotonClient.cInt16(Mathf.RoundToInt(forward.z * (float)200)));
															if (235888 - 212624 == 23264)
															{
																PhotonClient.Connection.OpCustom(65, hashtable, true);
																if (150322 - 67808 != 82515)
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

	// Token: 0x0600BBDA RID: 48090 RVA: 0x013F5F2C File Offset: 0x013F412C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator onChangePlayer(Hashtable data)
	{
		return new M974_HellCarousel.$onChangePlayer$47027(data, this).GetEnumerator();
	}

	// Token: 0x0600BBDB RID: 48091 RVA: 0x013F5F3C File Offset: 0x013F413C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void InitGame()
	{
		if (79004 - 256244 != -177239)
		{
		}
		for (;;)
		{
			Debug.Log("Initializing Mission");
			if (146995 - 247872 == -100877)
			{
				Time.timeScale = 1f;
				if (95255 - 192173 == -96918)
				{
					CharacterData.current.removeInventory("k_dun6", 1);
					if (78626 - 196915 != -118288)
					{
						Hashtable customOpParameters = new Hashtable();
						if (88222 - 477401 == -389179)
						{
							this.Lktnppy597F.OpCustom(52, customOpParameters, true);
							if (94993 - 206402 == -111409)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x0600BBDC RID: 48092 RVA: 0x013F6034 File Offset: 0x013F4234
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onInitGame(Hashtable data)
	{
		if (68351 - 163620 != -95268)
		{
		}
		for (;;)
		{
			Debug.Log("Loading data...");
			if (57768 - 355878 == -298110)
			{
				if (Game.mGameState >= eGameState.Setup)
				{
					break;
				}
				if (198005 - 463846 == -265841)
				{
					Game.mGameState = eGameState.Setup;
					if (35090 - 7362 == 27728)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x0600BBDD RID: 48093 RVA: 0x013F60D8 File Offset: 0x013F42D8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onGameSetup(Hashtable data)
	{
		if (30019 - 576702 != -546683)
		{
		}
		for (;;)
		{
			int num = RuntimeServices.UnboxInt32(data[43]);
			if (65110 - 453701 != -388590)
			{
				if (num == PlayerData.UID)
				{
					if (269774 - 406526 != -136751)
					{
						this.SetupActors();
						if (71917 - 270176 == -198259)
						{
							break;
						}
					}
				}
				else
				{
					this.ClearActors();
					if (231900 - 29073 != 202828)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x0600BBDE RID: 48094 RVA: 0x013F61A8 File Offset: 0x013F43A8
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void SetupActors()
	{
		if (3515 - 141720 != -138205)
		{
		}
		for (;;)
		{
			IL_287:
			Debug.Log("Creating Actors");
			if (295282 - 15009 == 280273)
			{
				CharacterControl[] array = (CharacterControl[])UnityEngine.Object.FindObjectsOfType(typeof(CharacterControl));
				if (249419 - 536096 == -286677)
				{
					if (Extensions.get_length(array) > 0)
					{
						if (70638 - 212311 == -141673)
						{
							int i = 0;
							if (82021 - 150554 != -68532)
							{
								CharacterControl[] array2 = array;
								if (216780 - 42334 == 174446)
								{
									int length = array2.Length;
									if (81524 - 56370 == 25154)
									{
										while (i < length)
										{
											string type = array2[i].Type;
											if (211524 - 287250 != -75726)
											{
												goto IL_287;
											}
											if (type == "Matti")
											{
												if (210457 - 16313 == 194145)
												{
													goto IL_287;
												}
												this.createActor(array2[i].Type, array2[i].gameObject.layer - 7, array2[i].transform.position, array2[i].transform.forward);
												if (287761 - 596508 == -308746)
												{
													goto IL_287;
												}
											}
											else if (type == "Doov")
											{
												if (70911 - 440331 == -369419)
												{
													goto IL_287;
												}
												this.createActor(array2[i].Type, array2[i].gameObject.layer - 7, array2[i].transform.position, array2[i].transform.forward);
												if (175292 - 449970 == -274677)
												{
													goto IL_287;
												}
											}
											UnityEngine.Object.Destroy(array2[i].gameObject);
											if (55777 - 44502 != 11275)
											{
												goto IL_287;
											}
											this.k6gnpb5c5sf++;
											if (61218 - 519660 == -458441)
											{
												goto IL_287;
											}
											i++;
											if (153040 - 217438 == -64397)
											{
												goto IL_287;
											}
										}
										if (93490 - 35975 != 57516)
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
						if (248877 - 380658 != -131780)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x0600BBDF RID: 48095 RVA: 0x013F64A0 File Offset: 0x013F46A0
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ClearActors()
	{
		if (4435 - 191302 != -186867)
		{
		}
		for (;;)
		{
			IL_46:
			CharacterControl[] array = (CharacterControl[])UnityEngine.Object.FindObjectsOfType(typeof(CharacterControl));
			if (42495 - 259903 == -217408)
			{
				int i = 0;
				if (219151 - 317971 == -98820)
				{
					CharacterControl[] array2 = array;
					if (280732 - 164317 == 116415)
					{
						int length = array2.Length;
						if (258500 - 177329 == 81171)
						{
							while (i < length)
							{
								UnityEngine.Object.Destroy(array2[i].gameObject);
								if (175523 - 586663 != -411140)
								{
									goto IL_46;
								}
								i++;
								if (218384 - 38249 != 180135)
								{
									goto IL_46;
								}
							}
							if (51074 - 167441 == -116367)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x0600BBE0 RID: 48096 RVA: 0x013F65D0 File Offset: 0x013F47D0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void StartGame()
	{
		if (221412 - 333950 != -112537)
		{
		}
		for (;;)
		{
			Debug.Log("Start Game");
			if (222808 - 304716 == -81908)
			{
				Game.mGameState = eGameState.Start;
				if (15273 - 434858 == -419585)
				{
					Game.mGameTime = Time.time;
					if (254373 - 355318 != -100944)
					{
						Game.mStateTime = Time.time;
						if (52135 - 267610 != -215474)
						{
							this.StartCoroutine_Auto(this.StartEvent());
							if (193917 - 228684 != -34766)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x0600BBE1 RID: 48097 RVA: 0x013F66BC File Offset: 0x013F48BC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onStartGame()
	{
	}

	// Token: 0x0600BBE2 RID: 48098 RVA: 0x013F66C0 File Offset: 0x013F48C0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator onGameComplete(Hashtable data)
	{
		return new M974_HellCarousel.$onGameComplete$47034(data, this).GetEnumerator();
	}

	// Token: 0x0600BBE3 RID: 48099 RVA: 0x013F66D0 File Offset: 0x013F48D0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator ReturnToTown()
	{
		return new M974_HellCarousel.$ReturnToTown$47044(this).GetEnumerator();
	}

	// Token: 0x0600BBE4 RID: 48100 RVA: 0x013F66E0 File Offset: 0x013F48E0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator ReturnToGuild()
	{
		return new M974_HellCarousel.$ReturnToGuild$47049(this).GetEnumerator();
	}

	// Token: 0x0600BBE5 RID: 48101 RVA: 0x013F66F0 File Offset: 0x013F48F0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator ReturnToCamp()
	{
		return new M974_HellCarousel.$ReturnToCamp$47053(this).GetEnumerator();
	}

	// Token: 0x0600BBE6 RID: 48102 RVA: 0x013F6700 File Offset: 0x013F4900
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void LeaveGame()
	{
		if (83169 - 180228 != -97058)
		{
		}
		for (;;)
		{
			Debug.Log("leaving guild");
			if (203922 - 103938 != 99985)
			{
				Hashtable hashtable = new Hashtable();
				if (82430 - 574533 != -492102)
				{
					hashtable.Add(43, PlayerData.UID);
					if (291200 - 17553 != 273648)
					{
						PhotonClient.Connection.OpCustom(54, hashtable, true);
						if (5909 - 44500 == -38591)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x0600BBE7 RID: 48103 RVA: 0x013F67D8 File Offset: 0x013F49D8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onLeaveGame()
	{
		Debug.Log("onLeaveGame");
		this.JoinTown();
	}

	// Token: 0x0600BBE8 RID: 48104 RVA: 0x013F67EC File Offset: 0x013F49EC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void JoinTown()
	{
		if (4155 - 300791 != -296636)
		{
		}
		for (;;)
		{
			Debug.Log("Joining Town");
			if (79737 - 56920 != 22818)
			{
				Hashtable hashtable = new Hashtable();
				if (133622 - 228642 != -95019)
				{
					if (Game.mNextGameCode == 30)
					{
						if (26211 - 205425 == -179213)
						{
							continue;
						}
						hashtable.Add(47, "NoGuild");
						if (123188 - 336170 == -212981)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 31)
					{
						if (138044 - 549594 != -411550)
						{
							continue;
						}
						hashtable.Add(47, "G" + GuildData.Name);
						if (213363 - 378781 == -165417)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 32)
					{
						if (254091 - 528960 != -274869)
						{
							continue;
						}
						hashtable.Add(47, "SnowCamp");
						if (89261 - 30234 != 59027)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 33)
					{
						if (121479 - 280954 == -159474)
						{
							continue;
						}
						hashtable.Add(47, "CrystalBeach");
						if (128077 - 168158 == -40080)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 34)
					{
						if (98219 - 246824 != -148605)
						{
							continue;
						}
						hashtable.Add(47, "ExcavationCamp");
						if (71515 - 557289 != -485774)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 35)
					{
						if (64991 - 149619 != -84628)
						{
							continue;
						}
						hashtable.Add(47, "UndergroundCamp");
						if (10313 - 346312 != -335999)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 36)
					{
						if (139964 - 53782 == 86183)
						{
							continue;
						}
						hashtable.Add(47, "ForestCamp");
						if (88259 - 150122 != -61863)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 51)
					{
						if (51436 - 531078 != -479642)
						{
							continue;
						}
						hashtable.Add(47, "MainStreet");
						if (126042 - 230707 != -104665)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 52)
					{
						if (118763 - 294225 == -175461)
						{
							continue;
						}
						hashtable.Add(47, "CentralSquare");
						if (248532 - 265845 == -17312)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 53)
					{
						if (204743 - 524749 == -320005)
						{
							continue;
						}
						hashtable.Add(47, "CityLibrary");
						if (81150 - 215791 != -134641)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 54)
					{
						if (160502 - 114821 != 45681)
						{
							continue;
						}
						hashtable.Add(47, "LightPark");
						if (56335 - 24684 != 31651)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 55)
					{
						if (85262 - 557710 != -472448)
						{
							continue;
						}
						hashtable.Add(47, "LightPalace");
						if (60223 - 273500 != -213277)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 56)
					{
						if (14127 - 77219 == -63091)
						{
							continue;
						}
						hashtable.Add(47, "PlainColosseum");
						if (82220 - 134045 != -51825)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 57)
					{
						if (24435 - 57825 != -33390)
						{
							continue;
						}
						hashtable.Add(47, "LightTheater");
						if (47460 - 557418 != -509958)
						{
							continue;
						}
					}
					hashtable.Add(21, PhotonClient.cInt16(Mathf.Clamp(PlayerPrefs.GetInt("channel", 0), 0, 99)));
					if (70763 - 548983 == -478220)
					{
						this.Lktnppy597F.OpCustom(42, hashtable, true);
						if (141480 - 204018 == -62538)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x0600BBE9 RID: 48105 RVA: 0x013F6DA0 File Offset: 0x013F4FA0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onJoinTown()
	{
		Game.mGameStage = 0;
		Game.loadNextLevel();
	}

	// Token: 0x0600BBEA RID: 48106 RVA: 0x013F6DB0 File Offset: 0x013F4FB0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x0600BBEB RID: 48107 RVA: 0x013F6DB4 File Offset: 0x013F4FB4
	internal static bool G66vPWtXo8Q05P8IlxII()
	{
		return true;
	}

	// Token: 0x0600BBEC RID: 48108 RVA: 0x013F6DB8 File Offset: 0x013F4FB8
	internal static bool OF52JDtXEShcyUuldChV()
	{
		return false;
	}

	// Token: 0x0400A0C9 RID: 41161
	private LitePeer Lktnppy597F;

	// Token: 0x0400A0CA RID: 41162
	private PlayerCameraControl hhKnpRgOnPp;

	// Token: 0x0400A0CB RID: 41163
	private float BkmnprZpSFG;

	// Token: 0x0400A0CC RID: 41164
	private Texture N2OnpxhwLAB;

	// Token: 0x0400A0CD RID: 41165
	private AudioClip pAanpTsXMNG;

	// Token: 0x0400A0CE RID: 41166
	private int o72npYDx6i4;

	// Token: 0x0400A0CF RID: 41167
	private int Q4rnp3aTyb0;

	// Token: 0x0400A0D0 RID: 41168
	public GameObject mMatti;

	// Token: 0x0400A0D1 RID: 41169
	private int k6gnpb5c5sf;

	// Token: 0x02001F69 RID: 8041
	[CompilerGenerated]
	[Serializable]
	internal sealed class $StartEvent$47002 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600BBED RID: 48109 RVA: 0x013F6DBC File Offset: 0x013F4FBC
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $StartEvent$47002(M974_HellCarousel self_)
		{
			if (160876 - 469859 != -308983)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (94383 - 539500 != -445116)
				{
					base..ctor();
					if (295404 - 596827 == -301423)
					{
						this.$self_$47007 = self_;
						if (4919 - 207489 != -202569)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x0600BBEE RID: 48110 RVA: 0x013F6E54 File Offset: 0x013F5054
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M974_HellCarousel.$StartEvent$47002.$(this.$self_$47007);
		}

		// Token: 0x0600BBEF RID: 48111 RVA: 0x013F6E64 File Offset: 0x013F5064
		internal static bool Se0JlAtX25v9ZLnSIIYj()
		{
			return true;
		}

		// Token: 0x0600BBF0 RID: 48112 RVA: 0x013F6E68 File Offset: 0x013F5068
		internal static bool wG2TQjtX8FORKRlKfGxE()
		{
			return false;
		}

		// Token: 0x0400A0D2 RID: 41170
		internal M974_HellCarousel $self_$47007;

		// Token: 0x02001F6A RID: 8042
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600BBF1 RID: 48113 RVA: 0x013F6E6C File Offset: 0x013F506C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M974_HellCarousel self_)
			{
				if (164457 - 571121 != -406663)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (132408 - 186924 == -54516)
					{
						base..ctor();
						if (208142 - 96572 == 111570)
						{
							this.$self_$47006 = self_;
							if (126740 - 129860 != -3119)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x0600BBF2 RID: 48114 RVA: 0x013F6F04 File Offset: 0x013F5104
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (97468 - 347512 != -250043)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						goto IL_383;
					case 1:
						goto IL_A74;
					case 2:
						if (Game.mGameState != eGameState.Start)
						{
							if (52164 - 323485 != -271321)
							{
								continue;
							}
							goto IL_A3B;
						}
						else
						{
							this.$self_$47006.SendMessage("blackInTimer", 2f);
							if (176841 - 376903 != -200062)
							{
								continue;
							}
							goto IL_8F7;
						}
						break;
					case 3:
						if (Game.mGameState != eGameState.Start)
						{
							if (31521 - 415223 != -383701)
							{
								goto Block_64;
							}
							continue;
						}
						else
						{
							this.$mStoryGui$47003 = (StoryGui)this.$self_$47006.GetComponent(typeof(StoryGui));
							if (219197 - 340831 == -121633)
							{
								continue;
							}
							this.$mStoryTimer$47004 = 0f;
							if (107709 - 306403 == -198693)
							{
								continue;
							}
							if (!this.$mStoryGui$47003)
							{
								if (143952 - 256130 != -112177)
								{
									goto Block_9;
								}
								continue;
							}
							else
							{
								this.$mStoryGui$47003.startStoryMessage(CharacterData.current.Type, CharacterData.current.Name, eTalkType.friend);
								if (88851 - 317862 != -229010)
								{
									goto Block_19;
								}
								continue;
							}
						}
						break;
					case 4:
						if (Game.mGameState != eGameState.Start)
						{
							if (292414 - 145005 != 147409)
							{
								continue;
							}
							goto IL_20E;
						}
						else
						{
							this.$self_$47006.hhKnpRgOnPp.StartCoroutine_Auto(this.$self_$47006.hhKnpRgOnPp.slerpToObject("EventCamera2", (float)2));
							if (28049 - 507706 == -479656)
							{
								continue;
							}
							this.$mStoryGui$47003.newStoryMessage(CharacterData.current.Type, CharacterData.current.Name, Language.getMessage("M974_HellCarousel", 101), eTalkType.friend);
							if (271614 - 328033 == -56418)
							{
								continue;
							}
							this.$mStoryTimer$47004 = Time.time + 3.5f;
							if (199234 - 272538 != -73304)
							{
								continue;
							}
							goto IL_2D0;
						}
						break;
					case 5:
						break;
					case 6:
						break;
					case 7:
						goto IL_537;
					case 8:
						goto IL_537;
					case 9:
						goto IL_1B9;
					case 10:
						goto IL_1B9;
					case 11:
						goto IL_473;
					case 12:
						goto IL_473;
					case 13:
						goto IL_86F;
					case 14:
						goto IL_86F;
					case 15:
						if (Game.mGameState != eGameState.Start)
						{
							if (243366 - 211829 != 31537)
							{
								continue;
							}
							goto IL_9A4;
						}
						else
						{
							this.$mGameGui$47005 = (GameGui)this.$self_$47006.GetComponent(typeof(GameGui));
							if (274236 - 162569 == 111668)
							{
								continue;
							}
							this.$mGameGui$47005.enabled = true;
							if (221082 - 170211 == 50872)
							{
								continue;
							}
							Game.mGameState = eGameState.Normal;
							if (1410 - 591998 != -590588)
							{
								continue;
							}
							Game.mStateTime = Time.time;
							if (127278 - 482615 == -355336)
							{
								continue;
							}
							if (this.$self_$47006.pAanpTsXMNG)
							{
								if (299579 - 266378 != 33201)
								{
									continue;
								}
								this.$self_$47006.audio.PlayOneShot(this.$self_$47006.pAanpTsXMNG);
								if (153387 - 218637 != -65250)
								{
									continue;
								}
							}
							this.YieldDefault(1);
							if (114410 - 458548 != -344137)
							{
								goto Block_39;
							}
							continue;
						}
						break;
					default:
						if (3148 - 120924 != -117775)
						{
							goto IL_383;
						}
						continue;
					}
					if (this.$mStoryTimer$47004 > Time.time)
					{
						if (265849 - 197251 == 68599)
						{
							continue;
						}
						if (!Input.GetKeyDown(KeyCode.Mouse0))
						{
							goto IL_2EB;
						}
						if (141256 - 166706 == -25449)
						{
							continue;
						}
					}
					if (Game.mGameState != eGameState.Start)
					{
						if (49228 - 69238 != -20009)
						{
							break;
						}
						continue;
					}
					else
					{
						this.$mStoryGui$47003.newStoryMessage(CharacterData.current.Type, CharacterData.current.Name, Language.getMessage("M974_HellCarousel", 102), eTalkType.friend);
						if (244990 - 551481 == -306490)
						{
							continue;
						}
						this.$mStoryTimer$47004 = Time.time + 3.5f;
						if (19909 - 430017 != -410108)
						{
							continue;
						}
						goto IL_510;
					}
					IL_86F:
					if (this.$mStoryTimer$47004 > Time.time)
					{
						if (280450 - 479953 != -199503)
						{
							continue;
						}
						if (!Input.GetKeyDown(KeyCode.Mouse0))
						{
							goto IL_862;
						}
						if (79676 - 90394 != -10718)
						{
							continue;
						}
					}
					if (Game.mGameState != eGameState.Start)
					{
						if (209101 - 67013 != 142088)
						{
							continue;
						}
						break;
					}
					else
					{
						this.$mStoryGui$47003.close();
						if (113664 - 401872 != -288208)
						{
							continue;
						}
						this.$self_$47006.hhKnpRgOnPp.enabled = true;
						if (24097 - 316628 != -292530)
						{
							goto Block_49;
						}
						continue;
					}
					IL_1B9:
					if (this.$mStoryTimer$47004 > Time.time)
					{
						if (192914 - 195335 == -2420)
						{
							continue;
						}
						if (!Input.GetKeyDown(KeyCode.Mouse0))
						{
							goto IL_1AC;
						}
						if (267367 - 424510 == -157142)
						{
							continue;
						}
					}
					if (Game.mGameState != eGameState.Start)
					{
						if (123262 - 428297 != -305034)
						{
							break;
						}
						continue;
					}
					else
					{
						this.$mStoryGui$47003.newStoryMessage("Matti", "Matti", Language.getMessage("M974_HellCarousel", 104), eTalkType.enemy);
						if (189484 - 416434 != -226950)
						{
							continue;
						}
						this.$mStoryTimer$47004 = Time.time + 3f;
						if (278137 - 452901 != -174764)
						{
							continue;
						}
						goto IL_44A;
					}
					IL_473:
					if (this.$mStoryTimer$47004 > Time.time)
					{
						if (260044 - 564486 == -304441)
						{
							continue;
						}
						if (!Input.GetKeyDown(KeyCode.Mouse0))
						{
							goto IL_466;
						}
						if (59510 - 492935 != -433425)
						{
							continue;
						}
					}
					if (Game.mGameState != eGameState.Start)
					{
						if (208795 - 452452 != -243657)
						{
							continue;
						}
						break;
					}
					else
					{
						this.$mStoryGui$47003.newStoryMessage("Matti", "Matti", Language.getMessage("M974_HellCarousel", 105), eTalkType.enemy);
						if (19658 - 454754 != -435096)
						{
							continue;
						}
						this.$mStoryTimer$47004 = Time.time + 3f;
						if (104806 - 289198 != -184391)
						{
							goto Block_15;
						}
						continue;
					}
					IL_383:
					Game.mGameState = eGameState.Start;
					if (274289 - 355266 != -80977)
					{
						continue;
					}
					Game.mStateTime = Time.time;
					if (52930 - 441593 == -388662)
					{
						continue;
					}
					this.$self_$47006.hhKnpRgOnPp.alignToObject("EventCamera1");
					if (279443 - 349428 != -69985)
					{
						continue;
					}
					this.$self_$47006.SendMessage("blackOutTimer", 0);
					if (204057 - 550654 != -346596)
					{
						goto Block_56;
					}
					continue;
					IL_537:
					if (this.$mStoryTimer$47004 > Time.time)
					{
						if (23866 - 556911 == -533044)
						{
							continue;
						}
						if (!Input.GetKeyDown(KeyCode.Mouse0))
						{
							goto IL_52B;
						}
						if (1896 - 585261 != -583365)
						{
							continue;
						}
					}
					if (Game.mGameState != eGameState.Start)
					{
						if (292744 - 27699 == 265045)
						{
							break;
						}
					}
					else
					{
						this.$self_$47006.hhKnpRgOnPp.StartCoroutine_Auto(this.$self_$47006.hhKnpRgOnPp.slerpToObject("EventCamera3", (float)2));
						if (78149 - 478875 != -400725)
						{
							this.$mStoryGui$47003.newStoryMessage("Matti", "???", Language.getMessage("M974_HellCarousel", 103), eTalkType.enemy);
							if (277928 - 109456 != 168473)
							{
								this.$mStoryTimer$47004 = Time.time + 3f;
								if (123724 - 506218 != -382493)
								{
									goto Block_10;
								}
							}
						}
					}
				}
				Block_9:
				goto IL_A74;
				Block_10:
				return this.Yield(9, new WaitForSeconds(0.5f));
				goto IL_A74;
				IL_1AC:
				return this.YieldDefault(10);
				Block_15:
				return this.Yield(13, new WaitForSeconds(0.5f));
				IL_20E:
				goto IL_A74;
				Block_19:
				return this.Yield(4, new WaitForSeconds(0.5f));
				IL_2D0:
				return this.Yield(5, new WaitForSeconds(0.5f));
				IL_2EB:
				return this.YieldDefault(6);
				goto IL_A74;
				IL_44A:
				return this.Yield(11, new WaitForSeconds(0.5f));
				IL_466:
				return this.YieldDefault(12);
				IL_510:
				return this.Yield(7, new WaitForSeconds(0.5f));
				IL_52B:
				return this.YieldDefault(8);
				Block_39:
				goto IL_A74;
				Block_49:
				return this.Yield(15, new WaitForSeconds(1f));
				Block_56:
				return this.Yield(2, new WaitForSeconds(1.5f));
				IL_862:
				return this.YieldDefault(14);
				IL_8F7:
				return this.Yield(3, new WaitForSeconds(2f));
				Block_64:
				IL_9A4:
				IL_A3B:
				IL_A74:
				return false;
			}

			// Token: 0x0600BBF3 RID: 48115 RVA: 0x013F7998 File Offset: 0x013F5B98
			internal static bool LKvShEtXZeNvCI0LDyy2()
			{
				return true;
			}

			// Token: 0x0600BBF4 RID: 48116 RVA: 0x013F799C File Offset: 0x013F5B9C
			internal static bool wbPvqgtXC1mlrIIEhBKk()
			{
				return false;
			}

			// Token: 0x0400A0D3 RID: 41171
			internal StoryGui $mStoryGui$47003;

			// Token: 0x0400A0D4 RID: 41172
			internal float $mStoryTimer$47004;

			// Token: 0x0400A0D5 RID: 41173
			internal GameGui $mGameGui$47005;

			// Token: 0x0400A0D6 RID: 41174
			internal M974_HellCarousel $self_$47006;
		}
	}

	// Token: 0x02001F6B RID: 8043
	[CompilerGenerated]
	[Serializable]
	internal sealed class $EndEvent$47008 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600BBF5 RID: 48117 RVA: 0x013F79A0 File Offset: 0x013F5BA0
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $EndEvent$47008(M974_HellCarousel self_)
		{
			if (12077 - 458352 != -446274)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (261435 - 389893 != -128457)
				{
					base..ctor();
					if (78201 - 91845 == -13644)
					{
						this.$self_$47013 = self_;
						if (113163 - 581480 != -468316)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x0600BBF6 RID: 48118 RVA: 0x013F7A38 File Offset: 0x013F5C38
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M974_HellCarousel.$EndEvent$47008.$(this.$self_$47013);
		}

		// Token: 0x0600BBF7 RID: 48119 RVA: 0x013F7A48 File Offset: 0x013F5C48
		internal static bool nEMRVbtXLGlUQcEKyt6N()
		{
			return true;
		}

		// Token: 0x0600BBF8 RID: 48120 RVA: 0x013F7A4C File Offset: 0x013F5C4C
		internal static bool Ae6Ln2tXOrYRQRCuL9h4()
		{
			return false;
		}

		// Token: 0x0400A0D7 RID: 41175
		internal M974_HellCarousel $self_$47013;

		// Token: 0x02001F6C RID: 8044
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600BBF9 RID: 48121 RVA: 0x013F7A50 File Offset: 0x013F5C50
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M974_HellCarousel self_)
			{
				if (136630 - 295029 != -158398)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (12993 - 463973 != -450979)
					{
						base..ctor();
						if (81027 - 593363 == -512336)
						{
							this.$self_$47012 = self_;
							if (142562 - 65396 == 77166)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x0600BBFA RID: 48122 RVA: 0x013F7AE8 File Offset: 0x013F5CE8
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (203542 - 544983 != -341440)
				{
				}
				do
				{
					switch (this._state)
					{
					case 0:
						goto IL_412;
					case 1:
						goto IL_567;
					case 2:
						if (Game.mGameState != eGameState.AllHold)
						{
							if (240199 - 380682 != -140482)
							{
								goto Block_37;
							}
							continue;
						}
						else
						{
							this.$mStoryGui$47010.newStoryMessage("Matti", "Matti", Language.getMessage("M974_HellCarousel", 201), eTalkType.enemy);
							if (173752 - 364580 == -190827)
							{
								continue;
							}
							this.$mStoryTimer$47011 = Time.time + 3f;
							if (201332 - 57745 != 143588)
							{
								goto Block_14;
							}
							continue;
						}
						break;
					case 3:
						goto IL_299;
					case 4:
						goto IL_299;
					case 5:
						break;
					case 6:
						break;
					case 7:
						if (Game.mGameState != eGameState.AllHold)
						{
							if (217185 - 111361 != 105824)
							{
								continue;
							}
							goto IL_437;
						}
						else
						{
							Game.mGameState = eGameState.Normal;
							if (185058 - 305697 == -120638)
							{
								continue;
							}
							Game.sendMissionEvent(9742, 1);
							if (231178 - 30073 != 201105)
							{
								continue;
							}
							goto IL_3F0;
						}
						break;
					default:
						if (228415 - 550670 != -322255)
						{
							continue;
						}
						goto IL_412;
					}
					if (this.$mStoryTimer$47011 > Time.time)
					{
						if (261520 - 274573 != -13053)
						{
							continue;
						}
						if (!Input.GetKeyDown(KeyCode.Mouse0))
						{
							goto IL_49D;
						}
						if (143460 - 551594 != -408134)
						{
							continue;
						}
					}
					if (Game.mGameState != eGameState.AllHold)
					{
						if (92357 - 262036 != -169679)
						{
							continue;
						}
						break;
					}
					else
					{
						this.$mStoryGui$47010.close();
						if (159493 - 438978 == -279484)
						{
							continue;
						}
						this.$mGameGui$47009.enabled = true;
						if (59274 - 271916 != -212642)
						{
							continue;
						}
						goto IL_338;
					}
					IL_412:
					if (Game.mGameState != eGameState.Normal)
					{
						if (165968 - 71222 != 94747)
						{
							break;
						}
						continue;
					}
					else
					{
						this.$mGameGui$47009 = (GameGui)this.$self_$47012.GetComponent(typeof(GameGui));
						if (166880 - 4549 == 162332)
						{
							continue;
						}
						this.$mStoryGui$47010 = (StoryGui)this.$self_$47012.GetComponent(typeof(StoryGui));
						if (222347 - 34712 == 187636)
						{
							continue;
						}
						this.$mStoryTimer$47011 = 0f;
						if (20521 - 184549 != -164028)
						{
							continue;
						}
						if (!this.$mGameGui$47009)
						{
							goto IL_3F0;
						}
						if (198592 - 376341 == -177748)
						{
							continue;
						}
						if (!this.$mStoryGui$47010)
						{
							goto IL_3F0;
						}
						if (90269 - 217561 == -127291)
						{
							continue;
						}
						Game.mGameState = eGameState.AllHold;
						if (53073 - 218590 == -165516)
						{
							continue;
						}
						this.$self_$47012.hhKnpRgOnPp.enabled = false;
						if (269151 - 356399 != -87248)
						{
							continue;
						}
						this.$mGameGui$47009.close();
						if (296011 - 295816 != 195)
						{
							continue;
						}
						this.$mStoryGui$47010.startStoryMessage("Matti", "Matti", eTalkType.enemy);
						if (171677 - 400212 != -228534)
						{
							goto Block_38;
						}
						continue;
					}
					IL_299:
					if (this.$mStoryTimer$47011 > Time.time)
					{
						if (214963 - 267308 != -52345)
						{
							continue;
						}
						if (!Input.GetKeyDown(KeyCode.Mouse0))
						{
							goto IL_28D;
						}
						if (45399 - 552356 == -506956)
						{
							continue;
						}
					}
					if (Game.mGameState != eGameState.AllHold)
					{
						if (71401 - 581138 != -509737)
						{
							continue;
						}
						break;
					}
					else
					{
						this.$mStoryGui$47010.newStoryMessage("Matti", "Matti", Language.getMessage("M974_HellCarousel", 202), eTalkType.enemy);
						if (262277 - 331083 == -68805)
						{
							continue;
						}
						this.$mStoryTimer$47011 = Time.time + 3f;
						if (161445 - 105709 != 55736)
						{
							continue;
						}
						goto IL_482;
					}
					IL_3F0:
					this.YieldDefault(1);
				}
				while (195412 - 183177 != 12235);
				goto IL_567;
				Block_14:
				return this.Yield(3, new WaitForSeconds(0.5f));
				IL_28D:
				return this.YieldDefault(4);
				IL_338:
				return this.Yield(7, new WaitForSeconds(1f));
				IL_437:
				goto IL_567;
				IL_482:
				return this.Yield(5, new WaitForSeconds(0.5f));
				IL_49D:
				return this.YieldDefault(6);
				Block_37:
				goto IL_567;
				Block_38:
				return this.Yield(2, new WaitForSeconds(0.5f));
				IL_567:
				return false;
			}

			// Token: 0x0600BBFB RID: 48123 RVA: 0x013F8070 File Offset: 0x013F6270
			internal static bool OcnfUOtXm9j5xR1ebQpM()
			{
				return true;
			}

			// Token: 0x0600BBFC RID: 48124 RVA: 0x013F8074 File Offset: 0x013F6274
			internal static bool EOI8i1tXFGfVQBoCgEQ0()
			{
				return false;
			}

			// Token: 0x0400A0D8 RID: 41176
			internal GameGui $mGameGui$47009;

			// Token: 0x0400A0D9 RID: 41177
			internal StoryGui $mStoryGui$47010;

			// Token: 0x0400A0DA RID: 41178
			internal float $mStoryTimer$47011;

			// Token: 0x0400A0DB RID: 41179
			internal M974_HellCarousel $self_$47012;
		}
	}

	// Token: 0x02001F6D RID: 8045
	[CompilerGenerated]
	[Serializable]
	internal sealed class $onActorDead$47014 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600BBFD RID: 48125 RVA: 0x013F8078 File Offset: 0x013F6278
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $onActorDead$47014(GameObject nActor, M974_HellCarousel self_)
		{
			if (178049 - 407198 != -229149)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (133696 - 374220 == -240524)
				{
					base..ctor();
					if (132679 - 415402 == -282723)
					{
						this.$nActor$47019 = nActor;
						if (162050 - 131498 != 30553)
						{
							this.$self_$47020 = self_;
							if (39006 - 558536 != -519529)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x0600BBFE RID: 48126 RVA: 0x013F8134 File Offset: 0x013F6334
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M974_HellCarousel.$onActorDead$47014.$(this.$nActor$47019, this.$self_$47020);
		}

		// Token: 0x0600BBFF RID: 48127 RVA: 0x013F8148 File Offset: 0x013F6348
		internal static bool FTpfejtXMkoe6nxXqsQ6()
		{
			return true;
		}

		// Token: 0x0600BC00 RID: 48128 RVA: 0x013F814C File Offset: 0x013F634C
		internal static bool vqPDYbtXxhEO8JsOiZxx()
		{
			return false;
		}

		// Token: 0x0400A0DC RID: 41180
		internal GameObject $nActor$47019;

		// Token: 0x0400A0DD RID: 41181
		internal M974_HellCarousel $self_$47020;

		// Token: 0x02001F6E RID: 8046
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600BC01 RID: 48129 RVA: 0x013F8150 File Offset: 0x013F6350
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(GameObject nActor, M974_HellCarousel self_)
			{
				if (273980 - 461248 != -187268)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (172446 - 86090 == 86356)
					{
						base..ctor();
						if (180733 - 122539 == 58194)
						{
							this.$nActor$47017 = nActor;
							if (83413 - 43026 == 40387)
							{
								this.$self_$47018 = self_;
								if (40018 - 26730 != 13289)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x0600BC02 RID: 48130 RVA: 0x013F820C File Offset: 0x013F640C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (153105 - 178453 != -25348)
				{
				}
				do
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_2D5;
					case 2:
						if (Game.mGameState > eGameState.AllHold)
						{
							if (285361 - 307336 != -21974)
							{
								goto Block_20;
							}
							continue;
						}
						else
						{
							this.$self_$47018.spawnActor("Doov", 8, UnityEngine.Random.Range(1, 8));
							if (8274 - 534381 != -526107)
							{
								continue;
							}
							goto IL_73;
						}
						break;
					default:
						if (196946 - 57673 == 139274)
						{
							continue;
						}
						break;
					}
					if (Game.mGameState > eGameState.AllHold)
					{
						if (42125 - 579974 != -537848)
						{
							break;
						}
						continue;
					}
					else
					{
						this.$mChar$47015 = (CharacterControl)this.$nActor$47017.GetComponent(typeof(CharacterControl));
						if (125788 - 515508 == -389719)
						{
							continue;
						}
						if (this.$mChar$47015)
						{
							if (32836 - 451026 != -418190)
							{
								continue;
							}
							if (!this.$mChar$47015.isTransform)
							{
								if (231212 - 563111 != -331899)
								{
									continue;
								}
								if (!this.$mChar$47015.isSummon)
								{
									if (254156 - 273055 != -18899)
									{
										continue;
									}
									this.$$switch$8771$47016 = this.$mChar$47015.Type;
									if (140658 - 399457 != -258799)
									{
										continue;
									}
									if (this.$$switch$8771$47016 == "Matti")
									{
										if (13384 - 171859 != -158475)
										{
											continue;
										}
										Game.sendMissionEvent(9741, 1);
										if (277036 - 431591 != -154555)
										{
											continue;
										}
									}
									else if (this.$$switch$8771$47016 == "Doov")
									{
										if (238521 - 61469 == 177053)
										{
											continue;
										}
										this.$self_$47018.Q4rnp3aTyb0 = this.$self_$47018.Q4rnp3aTyb0 + 1;
										if (42762 - 377623 != -334861)
										{
											continue;
										}
										if (this.$self_$47018.Q4rnp3aTyb0 <= 666)
										{
											if (245746 - 59291 != 186456)
											{
												goto Block_15;
											}
											continue;
										}
									}
								}
							}
						}
					}
					IL_73:
					this.YieldDefault(1);
				}
				while (199875 - 488515 == -288639);
				goto IL_2D5;
				Block_15:
				return this.Yield(2, new WaitForSeconds(6f));
				Block_20:
				IL_2D5:
				return false;
			}

			// Token: 0x0600BC03 RID: 48131 RVA: 0x013F8500 File Offset: 0x013F6700
			internal static bool yeHUHZtXgZ3wAfnmhPIW()
			{
				return true;
			}

			// Token: 0x0600BC04 RID: 48132 RVA: 0x013F8504 File Offset: 0x013F6704
			internal static bool aHhqWvtXfQBHq8G8lC4a()
			{
				return false;
			}

			// Token: 0x0400A0DE RID: 41182
			internal CharacterControl $mChar$47015;

			// Token: 0x0400A0DF RID: 41183
			internal string $$switch$8771$47016;

			// Token: 0x0400A0E0 RID: 41184
			internal GameObject $nActor$47017;

			// Token: 0x0400A0E1 RID: 41185
			internal M974_HellCarousel $self_$47018;
		}
	}

	// Token: 0x02001F6F RID: 8047
	[CompilerGenerated]
	[Serializable]
	internal sealed class $onDeadPlayer$47021 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600BC05 RID: 48133 RVA: 0x013F8508 File Offset: 0x013F6708
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $onDeadPlayer$47021(M974_HellCarousel self_)
		{
			if (114761 - 304255 != -189493)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (131238 - 296769 != -165530)
				{
					base..ctor();
					if (44641 - 384273 != -339631)
					{
						this.$self_$47026 = self_;
						if (221369 - 213799 != 7571)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x0600BC06 RID: 48134 RVA: 0x013F85A0 File Offset: 0x013F67A0
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M974_HellCarousel.$onDeadPlayer$47021.$(this.$self_$47026);
		}

		// Token: 0x0600BC07 RID: 48135 RVA: 0x013F85B0 File Offset: 0x013F67B0
		internal static bool VDs6t4tXnTZ9iABDfgkn()
		{
			return true;
		}

		// Token: 0x0600BC08 RID: 48136 RVA: 0x013F85B4 File Offset: 0x013F67B4
		internal static bool FA1mkVtX6SBoWxaOSn2F()
		{
			return false;
		}

		// Token: 0x0400A0E2 RID: 41186
		internal M974_HellCarousel $self_$47026;

		// Token: 0x02001F70 RID: 8048
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600BC09 RID: 48137 RVA: 0x013F85B8 File Offset: 0x013F67B8
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M974_HellCarousel self_)
			{
				if (294129 - 59809 != 234320)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (125174 - 289495 == -164321)
					{
						base..ctor();
						if (54278 - 459162 != -404883)
						{
							this.$self_$47025 = self_;
							if (5762 - 381752 == -375990)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x0600BC0A RID: 48138 RVA: 0x013F8650 File Offset: 0x013F6850
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (295703 - 202768 != 92936)
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
							goto IL_E8;
						}
						if (153240 - 140574 == 12667)
						{
							continue;
						}
						if (Game.mGameState == eGameState.Hold)
						{
							if (250063 - 171122 != 78941)
							{
								continue;
							}
							goto IL_E8;
						}
						IL_1A:
						this.YieldDefault(1);
						if (100546 - 368127 != -267580)
						{
							goto Block_2;
						}
						continue;
						IL_E8:
						Game.mGameState = eGameState.Hold;
						if (41663 - 562080 != -520417)
						{
							continue;
						}
						this.$mStoryGui$47022 = (StoryGui)this.$self_$47025.GetComponent(typeof(StoryGui));
						if (120867 - 96188 != 24679)
						{
							continue;
						}
						if (this.$mStoryGui$47022)
						{
							if (89540 - 123810 == -34269)
							{
								continue;
							}
							this.$mStoryGui$47022.close();
							if (47312 - 77471 == -30158)
							{
								continue;
							}
						}
						this.$mChangeGui$47023 = (ChangeGui)this.$self_$47025.GetComponent(typeof(ChangeGui));
						if (1087 - 496923 != -495836)
						{
							continue;
						}
						if (this.$mChangeGui$47023)
						{
							if (276605 - 304469 != -27864)
							{
								continue;
							}
							this.$mChangeGui$47023.close();
							if (169649 - 129269 == 40381)
							{
								continue;
							}
						}
						this.$mGameGui$47024 = (GameGui)this.$self_$47025.GetComponent(typeof(GameGui));
						if (67750 - 326399 != -258649)
						{
							continue;
						}
						if (!this.$mGameGui$47024)
						{
							goto IL_1A;
						}
						if (65177 - 330532 != -265355)
						{
							continue;
						}
						if (!this.$mGameGui$47024.enabled)
						{
							if (80246 - 305573 == -225326)
							{
								continue;
							}
							this.$mGameGui$47024.enabled = true;
							if (284839 - 243378 == 41462)
							{
								continue;
							}
						}
						this.$mGameGui$47024.openDeadMenu();
						if (281282 - 309175 != -27893)
						{
							continue;
						}
						goto IL_1A;
					default:
						if (113107 - 129715 == -16607)
						{
							continue;
						}
						break;
					}
					Debug.Log("On Dead Player");
					if (195134 - 533569 != -338434)
					{
						goto Block_8;
					}
				}
				Block_2:
				goto IL_2F9;
				Block_8:
				return this.Yield(2, new WaitForSeconds((float)2));
				IL_2F9:
				return false;
			}

			// Token: 0x0600BC0B RID: 48139 RVA: 0x013F8968 File Offset: 0x013F6B68
			internal static bool t8cb7ctXiJKSfjSK4As9()
			{
				return true;
			}

			// Token: 0x0600BC0C RID: 48140 RVA: 0x013F896C File Offset: 0x013F6B6C
			internal static bool GaCCp5tXKeTP1OC8yMEb()
			{
				return false;
			}

			// Token: 0x0400A0E3 RID: 41187
			internal StoryGui $mStoryGui$47022;

			// Token: 0x0400A0E4 RID: 41188
			internal ChangeGui $mChangeGui$47023;

			// Token: 0x0400A0E5 RID: 41189
			internal GameGui $mGameGui$47024;

			// Token: 0x0400A0E6 RID: 41190
			internal M974_HellCarousel $self_$47025;
		}
	}

	// Token: 0x02001F71 RID: 8049
	[CompilerGenerated]
	[Serializable]
	internal sealed class $onChangePlayer$47027 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600BC0D RID: 48141 RVA: 0x013F8970 File Offset: 0x013F6B70
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $onChangePlayer$47027(Hashtable data, M974_HellCarousel self_)
		{
			if (197695 - 303644 != -105948)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (134838 - 152578 != -17739)
				{
					base..ctor();
					if (37960 - 103756 == -65796)
					{
						this.$data$47032 = data;
						if (112506 - 233398 == -120892)
						{
							this.$self_$47033 = self_;
							if (115204 - 21737 != 93468)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x0600BC0E RID: 48142 RVA: 0x013F8A2C File Offset: 0x013F6C2C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M974_HellCarousel.$onChangePlayer$47027.$(this.$data$47032, this.$self_$47033);
		}

		// Token: 0x0600BC0F RID: 48143 RVA: 0x013F8A40 File Offset: 0x013F6C40
		internal static bool scFg7ttXdKSTQgWXITTd()
		{
			return true;
		}

		// Token: 0x0600BC10 RID: 48144 RVA: 0x013F8A44 File Offset: 0x013F6C44
		internal static bool ehi4LItXJQsJOyqcNauu()
		{
			return false;
		}

		// Token: 0x0400A0E7 RID: 41191
		internal Hashtable $data$47032;

		// Token: 0x0400A0E8 RID: 41192
		internal M974_HellCarousel $self_$47033;

		// Token: 0x02001F72 RID: 8050
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600BC11 RID: 48145 RVA: 0x013F8A48 File Offset: 0x013F6C48
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Hashtable data, M974_HellCarousel self_)
			{
				if (99583 - 47023 != 52560)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (279719 - 244852 == 34867)
					{
						base..ctor();
						if (93059 - 104591 == -11532)
						{
							this.$data$47030 = data;
							if (65577 - 114608 == -49031)
							{
								this.$self_$47031 = self_;
								if (278233 - 277406 != 828)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x0600BC12 RID: 48146 RVA: 0x013F8B04 File Offset: 0x013F6D04
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (284708 - 483494 != -198786)
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
							if (95182 - 547977 == -452794)
							{
								continue;
							}
							Game.mGameState = eGameState.Normal;
							if (220867 - 88662 != 132205)
							{
								continue;
							}
							this.$mGameGui$47029 = (GameGui)this.$self_$47031.GetComponent(typeof(GameGui));
							if (112911 - 53445 != 59466)
							{
								continue;
							}
							this.$mGameGui$47029.enabled = true;
							if (113798 - 483741 != -369943)
							{
								continue;
							}
						}
						this.YieldDefault(1);
						if (155390 - 138625 != 16765)
						{
							continue;
						}
						goto IL_205;
					default:
						if (68892 - 200447 == -131554)
						{
							continue;
						}
						break;
					}
					UnityEngine.Object.Destroy(Game.mPlayer);
					if (68926 - 184571 == -115645)
					{
						this.$self_$47031.SendMessage("onCreatePlayer", this.$data$47030);
						if (63506 - 316795 != -253288)
						{
							this.$mChangeGui$47028 = (ChangeGui)this.$self_$47031.GetComponent(typeof(ChangeGui));
							if (187812 - 72324 == 115488)
							{
								if (!this.$mChangeGui$47028.enabled)
								{
									break;
								}
								if (7526 - 315934 == -308408)
								{
									this.$mChangeGui$47028.close();
									if (211383 - 488638 != -277254)
									{
										break;
									}
								}
							}
						}
					}
				}
				return this.Yield(2, new WaitForSeconds(1f));
				IL_205:
				return false;
			}

			// Token: 0x0600BC13 RID: 48147 RVA: 0x013F8D28 File Offset: 0x013F6F28
			internal static bool U4mgvItXDTojCmWmdfuj()
			{
				return true;
			}

			// Token: 0x0600BC14 RID: 48148 RVA: 0x013F8D2C File Offset: 0x013F6F2C
			internal static bool UxMaHctXv4GHGBvE5d6L()
			{
				return false;
			}

			// Token: 0x0400A0E9 RID: 41193
			internal ChangeGui $mChangeGui$47028;

			// Token: 0x0400A0EA RID: 41194
			internal GameGui $mGameGui$47029;

			// Token: 0x0400A0EB RID: 41195
			internal Hashtable $data$47030;

			// Token: 0x0400A0EC RID: 41196
			internal M974_HellCarousel $self_$47031;
		}
	}

	// Token: 0x02001F73 RID: 8051
	[CompilerGenerated]
	[Serializable]
	internal sealed class $onGameComplete$47034 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600BC15 RID: 48149 RVA: 0x013F8D30 File Offset: 0x013F6F30
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $onGameComplete$47034(Hashtable data, M974_HellCarousel self_)
		{
			if (64184 - 468418 != -404233)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (112672 - 295289 != -182616)
				{
					base..ctor();
					if (37683 - 257947 != -220263)
					{
						this.$data$47042 = data;
						if (294108 - 361399 == -67291)
						{
							this.$self_$47043 = self_;
							if (123720 - 200715 == -76995)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x0600BC16 RID: 48150 RVA: 0x013F8DEC File Offset: 0x013F6FEC
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M974_HellCarousel.$onGameComplete$47034.$(this.$data$47042, this.$self_$47043);
		}

		// Token: 0x0600BC17 RID: 48151 RVA: 0x013F8E00 File Offset: 0x013F7000
		internal static bool T378nHtXRwEwPXn63K5W()
		{
			return true;
		}

		// Token: 0x0600BC18 RID: 48152 RVA: 0x013F8E04 File Offset: 0x013F7004
		internal static bool rgm5TwtXwhrMFadOGow4()
		{
			return false;
		}

		// Token: 0x0400A0ED RID: 41197
		internal Hashtable $data$47042;

		// Token: 0x0400A0EE RID: 41198
		internal M974_HellCarousel $self_$47043;

		// Token: 0x02001F74 RID: 8052
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600BC19 RID: 48153 RVA: 0x013F8E08 File Offset: 0x013F7008
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Hashtable data, M974_HellCarousel self_)
			{
				if (262054 - 404191 != -142136)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (232378 - 556426 == -324048)
					{
						base..ctor();
						if (91463 - 503401 == -411938)
						{
							this.$data$47040 = data;
							if (289083 - 518558 != -229474)
							{
								this.$self_$47041 = self_;
								if (99303 - 507087 != -407783)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x0600BC1A RID: 48154 RVA: 0x013F8EC4 File Offset: 0x013F70C4
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (223826 - 103730 != 120096)
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
						this.$mCompleteGui$47036 = (CompleteGui)this.$self_$47041.GetComponent(typeof(CompleteGui));
						if (82888 - 420303 != -337415)
						{
							continue;
						}
						this.$mCompleteGui$47036.Init();
						if (243334 - 193317 != 50017)
						{
							continue;
						}
						this.$mCompleteGui$47036.readData(this.$data$47040);
						if (146718 - 357133 == -210414)
						{
							continue;
						}
						if (this.$result$47035 == 1)
						{
							if (136442 - 340192 == -203749)
							{
								continue;
							}
							this.$mCompleteGui$47036.displayResult(eCompleteType.Success);
							if (64505 - 115784 == -51278)
							{
								continue;
							}
						}
						else
						{
							this.$mCompleteGui$47036.displayResult(eCompleteType.Failed);
							if (88236 - 91828 != -3592)
							{
								continue;
							}
						}
						this.$mGameGui$47037 = (GameGui)this.$self_$47041.GetComponent(typeof(GameGui));
						if (214713 - 378374 == -163660)
						{
							continue;
						}
						this.$mStoryGui$47038 = (StoryGui)this.$self_$47041.GetComponent(typeof(StoryGui));
						if (257268 - 399367 != -142099)
						{
							continue;
						}
						this.$mChangeGui$47039 = (ChangeGui)this.$self_$47041.GetComponent(typeof(ChangeGui));
						if (211339 - 92513 != 118826)
						{
							continue;
						}
						if (this.$mGameGui$47037)
						{
							if (93799 - 212106 != -118307)
							{
								continue;
							}
							this.$mGameGui$47037.close();
							if (249659 - 493970 != -244311)
							{
								continue;
							}
						}
						if (this.$mStoryGui$47038)
						{
							if (249463 - 204228 == 45236)
							{
								continue;
							}
							this.$mStoryGui$47038.close();
							if (31310 - 483612 != -452302)
							{
								continue;
							}
						}
						if (this.$mChangeGui$47039)
						{
							if (103584 - 595300 != -491716)
							{
								continue;
							}
							this.$mChangeGui$47039.disable();
							if (258857 - 392479 != -133622)
							{
								continue;
							}
						}
						this.YieldDefault(1);
						if (182793 - 236614 != -53821)
						{
							continue;
						}
						goto IL_3DB;
					default:
						if (293706 - 435285 == -141578)
						{
							continue;
						}
						break;
					}
					Debug.Log("On Mission Complete:" + this.$data$47040[31]);
					if (187455 - 255981 == -68526)
					{
						if (Game.mGameState > eGameState.AllHold)
						{
							if (194118 - 321826 != -127707)
							{
								goto Block_25;
							}
						}
						else
						{
							Game.mGameState = eGameState.Complete;
							if (2329 - 325018 != -322688)
							{
								this.$result$47035 = RuntimeServices.UnboxInt32(this.$data$47040[31]);
								if (232059 - 78949 == 153110)
								{
									break;
								}
							}
						}
					}
				}
				return this.Yield(2, new WaitForSeconds(1f));
				Block_25:
				IL_3DB:
				return false;
			}

			// Token: 0x0600BC1B RID: 48155 RVA: 0x013F92C0 File Offset: 0x013F74C0
			internal static bool ryq2VatXqpE9rGOMwKD6()
			{
				return true;
			}

			// Token: 0x0600BC1C RID: 48156 RVA: 0x013F92C4 File Offset: 0x013F74C4
			internal static bool LYHNb0tX7HZQxiFm2XVF()
			{
				return false;
			}

			// Token: 0x0400A0EF RID: 41199
			internal int $result$47035;

			// Token: 0x0400A0F0 RID: 41200
			internal CompleteGui $mCompleteGui$47036;

			// Token: 0x0400A0F1 RID: 41201
			internal GameGui $mGameGui$47037;

			// Token: 0x0400A0F2 RID: 41202
			internal StoryGui $mStoryGui$47038;

			// Token: 0x0400A0F3 RID: 41203
			internal ChangeGui $mChangeGui$47039;

			// Token: 0x0400A0F4 RID: 41204
			internal Hashtable $data$47040;

			// Token: 0x0400A0F5 RID: 41205
			internal M974_HellCarousel $self_$47041;
		}
	}

	// Token: 0x02001F75 RID: 8053
	[CompilerGenerated]
	[Serializable]
	internal sealed class $ReturnToTown$47044 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600BC1D RID: 48157 RVA: 0x013F92C8 File Offset: 0x013F74C8
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $ReturnToTown$47044(M974_HellCarousel self_)
		{
			if (166448 - 534922 != -368473)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (64595 - 565395 != -500799)
				{
					base..ctor();
					if (134325 - 441090 == -306765)
					{
						this.$self_$47048 = self_;
						if (201746 - 75607 == 126139)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x0600BC1E RID: 48158 RVA: 0x013F9360 File Offset: 0x013F7560
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M974_HellCarousel.$ReturnToTown$47044.$(this.$self_$47048);
		}

		// Token: 0x0600BC1F RID: 48159 RVA: 0x013F9370 File Offset: 0x013F7570
		internal static bool oGQXJYtXP7YJIZ52KFYh()
		{
			return true;
		}

		// Token: 0x0600BC20 RID: 48160 RVA: 0x013F9374 File Offset: 0x013F7574
		internal static bool ycftUjtX0n3vX7yyxDuh()
		{
			return false;
		}

		// Token: 0x0400A0F6 RID: 41206
		internal M974_HellCarousel $self_$47048;

		// Token: 0x02001F76 RID: 8054
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600BC21 RID: 48161 RVA: 0x013F9378 File Offset: 0x013F7578
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M974_HellCarousel self_)
			{
				if (56967 - 533214 != -476246)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (184849 - 175147 != 9703)
					{
						base..ctor();
						if (22764 - 246130 == -223366)
						{
							this.$self_$47047 = self_;
							if (249141 - 412166 == -163025)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x0600BC22 RID: 48162 RVA: 0x013F9410 File Offset: 0x013F7610
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (105190 - 19648 != 85543)
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
						this.$self_$47047.LeaveGame();
						if (3054 - 37383 == -34328)
						{
							continue;
						}
						this.YieldDefault(1);
						if (133757 - 399433 != -265675)
						{
							goto Block_11;
						}
						continue;
					default:
						if (94359 - 42813 == 51547)
						{
							continue;
						}
						break;
					}
					Game.mGameState = eGameState.Ended;
					if (156304 - 594124 != -437819)
					{
						Game.mStateTime = Time.time;
						if (18477 - 308580 == -290103)
						{
							this.$$switch$8775$47045 = PlayerData.SaveGuild;
							if (61054 - 57146 == 3908)
							{
								if (this.$$switch$8775$47045 == 1)
								{
									if (39809 - 506666 != -466857)
									{
										continue;
									}
									Game.mNextGameCode = 32;
									if (180250 - 294629 != -114379)
									{
										continue;
									}
								}
								else if (this.$$switch$8775$47045 == 2)
								{
									if (97521 - 172932 != -75411)
									{
										continue;
									}
									Game.mNextGameCode = 33;
									if (107839 - 414241 != -306402)
									{
										continue;
									}
								}
								else if (this.$$switch$8775$47045 == 3)
								{
									if (298778 - 331632 != -32854)
									{
										continue;
									}
									Game.mNextGameCode = 34;
									if (295884 - 402411 != -106527)
									{
										continue;
									}
								}
								else if (this.$$switch$8775$47045 == 4)
								{
									if (212159 - 409021 != -196862)
									{
										continue;
									}
									Game.mNextGameCode = 35;
									if (243159 - 107283 != 135876)
									{
										continue;
									}
								}
								else if (this.$$switch$8775$47045 == 5)
								{
									if (225614 - 584168 != -358554)
									{
										continue;
									}
									Game.mNextGameCode = 36;
									if (36780 - 561015 != -524235)
									{
										continue;
									}
								}
								else if (PlayerData.GID == 0)
								{
									if (164070 - 312390 != -148320)
									{
										continue;
									}
									Game.mNextGameCode = 30;
									if (193355 - 85140 != 108215)
									{
										continue;
									}
								}
								else
								{
									Game.mNextGameCode = 31;
									if (258436 - 302947 != -44511)
									{
										continue;
									}
								}
								this.$mGameGui$47046 = (GameGui)this.$self_$47047.GetComponent(typeof(GameGui));
								if (375 - 373604 != -373228)
								{
									if (this.$mGameGui$47046)
									{
										if (3454 - 342670 == -339215)
										{
											continue;
										}
										this.$mGameGui$47046.close();
										if (165938 - 62402 == 103537)
										{
											continue;
										}
									}
									this.$self_$47047.SendMessage("fadeOut");
									if (121643 - 86819 != 34825)
									{
										break;
									}
								}
							}
						}
					}
				}
				return this.Yield(2, new WaitForSeconds((float)1));
				Block_11:
				IL_3AD:
				return false;
			}

			// Token: 0x0600BC23 RID: 48163 RVA: 0x013F97DC File Offset: 0x013F79DC
			internal static bool tLwoGMtXbEKIwbfxJl3a()
			{
				return true;
			}

			// Token: 0x0600BC24 RID: 48164 RVA: 0x013F97E0 File Offset: 0x013F79E0
			internal static bool CfaOQ0tXuuLWVghlmI4Y()
			{
				return false;
			}

			// Token: 0x0400A0F7 RID: 41207
			internal int $$switch$8775$47045;

			// Token: 0x0400A0F8 RID: 41208
			internal GameGui $mGameGui$47046;

			// Token: 0x0400A0F9 RID: 41209
			internal M974_HellCarousel $self_$47047;
		}
	}

	// Token: 0x02001F77 RID: 8055
	[CompilerGenerated]
	[Serializable]
	internal sealed class $ReturnToGuild$47049 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600BC25 RID: 48165 RVA: 0x013F97E4 File Offset: 0x013F79E4
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $ReturnToGuild$47049(M974_HellCarousel self_)
		{
			if (95987 - 248362 != -152374)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (177821 - 302273 != -124451)
				{
					base..ctor();
					if (186773 - 536595 != -349821)
					{
						this.$self_$47052 = self_;
						if (267469 - 266979 == 490)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x0600BC26 RID: 48166 RVA: 0x013F987C File Offset: 0x013F7A7C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M974_HellCarousel.$ReturnToGuild$47049.$(this.$self_$47052);
		}

		// Token: 0x0600BC27 RID: 48167 RVA: 0x013F988C File Offset: 0x013F7A8C
		internal static bool PmloydtXIH7TTjOrg9i0()
		{
			return true;
		}

		// Token: 0x0600BC28 RID: 48168 RVA: 0x013F9890 File Offset: 0x013F7A90
		internal static bool yfT4GBtXBpU352qiZZaF()
		{
			return false;
		}

		// Token: 0x0400A0FA RID: 41210
		internal M974_HellCarousel $self_$47052;

		// Token: 0x02001F78 RID: 8056
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600BC29 RID: 48169 RVA: 0x013F9894 File Offset: 0x013F7A94
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M974_HellCarousel self_)
			{
				if (278513 - 489462 != -210948)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (196153 - 62848 == 133305)
					{
						base..ctor();
						if (209391 - 14311 != 195081)
						{
							this.$self_$47051 = self_;
							if (55996 - 560862 == -504866)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x0600BC2A RID: 48170 RVA: 0x013F992C File Offset: 0x013F7B2C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (155565 - 128155 != 27411)
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
						this.$self_$47051.LeaveGame();
						if (157444 - 209460 == -52015)
						{
							continue;
						}
						this.YieldDefault(1);
						if (212408 - 525981 != -313573)
						{
							continue;
						}
						goto IL_1BD;
					default:
						if (254011 - 381173 == -127161)
						{
							continue;
						}
						break;
					}
					Game.mGameState = eGameState.Ended;
					if (216283 - 253142 == -36859)
					{
						Game.mStateTime = Time.time;
						if (297918 - 133224 == 164694)
						{
							Game.mNextGameCode = 31;
							if (86848 - 299915 != -213066)
							{
								this.$mGameGui$47050 = (GameGui)this.$self_$47051.GetComponent(typeof(GameGui));
								if (298646 - 204386 == 94260)
								{
									if (this.$mGameGui$47050)
									{
										if (154383 - 445768 != -291385)
										{
											continue;
										}
										this.$mGameGui$47050.close();
										if (216627 - 504481 == -287853)
										{
											continue;
										}
									}
									this.$self_$47051.SendMessage("fadeOut");
									if (92075 - 109528 == -17453)
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

			// Token: 0x0600BC2B RID: 48171 RVA: 0x013F9B08 File Offset: 0x013F7D08
			internal static bool p4CKS3tXeXXMKRYnaadu()
			{
				return true;
			}

			// Token: 0x0600BC2C RID: 48172 RVA: 0x013F9B0C File Offset: 0x013F7D0C
			internal static bool CsByQRtXrH4T9FvGLUmD()
			{
				return false;
			}

			// Token: 0x0400A0FB RID: 41211
			internal GameGui $mGameGui$47050;

			// Token: 0x0400A0FC RID: 41212
			internal M974_HellCarousel $self_$47051;
		}
	}

	// Token: 0x02001F79 RID: 8057
	[CompilerGenerated]
	[Serializable]
	internal sealed class $ReturnToCamp$47053 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600BC2D RID: 48173 RVA: 0x013F9B10 File Offset: 0x013F7D10
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $ReturnToCamp$47053(M974_HellCarousel self_)
		{
			if (152888 - 584282 != -431394)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (6598 - 148965 != -142366)
				{
					base..ctor();
					if (109262 - 194479 == -85217)
					{
						this.$self_$47056 = self_;
						if (32861 - 391713 != -358851)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x0600BC2E RID: 48174 RVA: 0x013F9BA8 File Offset: 0x013F7DA8
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M974_HellCarousel.$ReturnToCamp$47053.$(this.$self_$47056);
		}

		// Token: 0x0600BC2F RID: 48175 RVA: 0x013F9BB8 File Offset: 0x013F7DB8
		internal static bool LYmG5gtXjsaguBShaEcS()
		{
			return true;
		}

		// Token: 0x0600BC30 RID: 48176 RVA: 0x013F9BBC File Offset: 0x013F7DBC
		internal static bool vdShWDtXhuGDIrKX2CZd()
		{
			return false;
		}

		// Token: 0x0400A0FD RID: 41213
		internal M974_HellCarousel $self_$47056;

		// Token: 0x02001F7A RID: 8058
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600BC31 RID: 48177 RVA: 0x013F9BC0 File Offset: 0x013F7DC0
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M974_HellCarousel self_)
			{
				if (47195 - 373539 != -326343)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (220015 - 443962 == -223947)
					{
						base..ctor();
						if (120129 - 88825 != 31305)
						{
							this.$self_$47055 = self_;
							if (146910 - 37320 == 109590)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x0600BC32 RID: 48178 RVA: 0x013F9C58 File Offset: 0x013F7E58
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (48487 - 15417 != 33070)
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
						this.$self_$47055.LeaveGame();
						if (77773 - 453620 != -375847)
						{
							continue;
						}
						this.YieldDefault(1);
						if (213792 - 62845 != 150947)
						{
							continue;
						}
						goto IL_1BD;
					default:
						if (125325 - 156531 == -31205)
						{
							continue;
						}
						break;
					}
					Game.mGameState = eGameState.Ended;
					if (225014 - 84526 == 140488)
					{
						Game.mStateTime = Time.time;
						if (242041 - 52813 != 189229)
						{
							Game.mNextGameCode = 35;
							if (255662 - 155957 == 99705)
							{
								this.$mGameGui$47054 = (GameGui)this.$self_$47055.GetComponent(typeof(GameGui));
								if (77992 - 475087 != -397094)
								{
									if (this.$mGameGui$47054)
									{
										if (230186 - 549639 != -319453)
										{
											continue;
										}
										this.$mGameGui$47054.close();
										if (209739 - 39792 != 169947)
										{
											continue;
										}
									}
									this.$self_$47055.SendMessage("fadeOut");
									if (115997 - 6533 == 109464)
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

			// Token: 0x0600BC33 RID: 48179 RVA: 0x013F9E34 File Offset: 0x013F8034
			internal static bool T8RDUJtXsXgHQ4pxErUM()
			{
				return true;
			}

			// Token: 0x0600BC34 RID: 48180 RVA: 0x013F9E38 File Offset: 0x013F8038
			internal static bool zcFeNMtX95Us82MvJpQu()
			{
				return false;
			}

			// Token: 0x0400A0FE RID: 41214
			internal GameGui $mGameGui$47054;

			// Token: 0x0400A0FF RID: 41215
			internal M974_HellCarousel $self_$47055;
		}
	}
}
