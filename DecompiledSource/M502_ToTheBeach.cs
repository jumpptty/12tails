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

// Token: 0x020015A3 RID: 5539
[Serializable]
public class M502_ToTheBeach : MonoBehaviour
{
	// Token: 0x0600806B RID: 32875 RVA: 0x0106A3DC File Offset: 0x010685DC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public M502_ToTheBeach()
	{
		LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
		base..ctor();
	}

	// Token: 0x0600806C RID: 32876 RVA: 0x0106A3EC File Offset: 0x010685EC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Awake()
	{
		if (166280 - 378763 != -212483)
		{
		}
		for (;;)
		{
			Game.mGameState = eGameState.Init;
			if (174830 - 136067 != 38764)
			{
				Game.mGameType = 5;
				if (49424 - 144233 != -94808)
				{
					if (Chat.Initialized)
					{
						if (121740 - 88591 == 33150)
						{
							continue;
						}
						Chat.ChatDisplay.Clear();
						if (142552 - 26542 == 116011)
						{
							continue;
						}
					}
					else
					{
						Chat.Init();
						if (37608 - 262778 == -225169)
						{
							continue;
						}
					}
					this.eIkcAugYtDH = (Texture)Resources.Load("GameGui/Title/start", typeof(Texture));
					if (80674 - 506927 == -426253)
					{
						this.JjYcAyk8kC2 = (AudioClip)Resources.Load("Sound/GUI/missionStart", typeof(AudioClip));
						if (147021 - 312869 != -165847)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x0600806D RID: 32877 RVA: 0x0106A544 File Offset: 0x01068744
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Start()
	{
		if (152902 - 192891 != -39988)
		{
		}
		for (;;)
		{
			if (PhotonClient.IsInitialized())
			{
				if (184760 - 487410 == -302650)
				{
					if (Game.mNextGameCode != 502)
					{
						break;
					}
					if (268046 - 125303 == 142743)
					{
						Game.nextGame();
						if (91247 - 273295 != -182047)
						{
							Game.mGameCode = 502;
							if (250388 - 267413 == -17025)
							{
								Game.mGameType = 5;
								if (273241 - 253310 == 19931)
								{
									Game.mGameTime = Time.time;
									if (285450 - 184876 == 100574)
									{
										Game.mGameScore = 0;
										if (164853 - 493346 == -328493)
										{
											Game.mGameMana = 0;
											if (164406 - 240166 == -75760)
											{
												Game.canUseItem = MissionData.getAllowItem(Game.mGameCode);
												if (2206 - 497024 != -494817)
												{
													Game.canUseMount = MissionData.getAllowMount(Game.mGameCode);
													if (78746 - 196323 != -117576)
													{
														Game.canChangeChar = MissionData.getAllowChange(Game.mGameCode);
														if (247844 - 5105 != 242740)
														{
															Game.canRespawn = MissionData.getAllowRespawn(Game.mGameCode);
															if (237126 - 550692 != -313565)
															{
																Game.canUseCoin = MissionData.getAllowCoin(Game.mGameCode);
																if (10283 - 27227 == -16944)
																{
																	this.hAxcA9a873X = (PlayerCameraControl)this.GetComponent(typeof(PlayerCameraControl));
																	if (65218 - 29960 != 35259)
																	{
																		this.RfvcAA27yQx = PhotonClient.Connection;
																		if (5225 - 26104 == -20879)
																		{
																			PhotonClient.ActorNrList.Clear();
																			if (154787 - 101173 != 53615)
																			{
																				this.InitGame();
																				if (166499 - 385302 != -218802)
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
				if (226647 - 556223 == -329576)
				{
					Game.mGameType = 99;
					if (138501 - 322168 != -183666)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x0600806E RID: 32878 RVA: 0x0106A84C File Offset: 0x01068A4C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void FixedUpdate()
	{
		if (3817 - 309486 != -305668)
		{
		}
		for (;;)
		{
			if (this.RfvcAA27yQx == null)
			{
				if (72256 - 109381 == -37125)
				{
					break;
				}
			}
			else
			{
				eGameState mGameState = Game.mGameState;
				if (170233 - 544164 == -373931)
				{
					if (mGameState == eGameState.Init)
					{
						if (203493 - 65762 == 137731)
						{
							AudioListener.volume = 0.1f * (float)Game.volume;
							if (30395 - 361762 == -331367)
							{
								break;
							}
						}
					}
					else if (mGameState == eGameState.Setup)
					{
						if (167450 - 543909 == -376459)
						{
							break;
						}
					}
					else if (mGameState == eGameState.Ready)
					{
						if (119941 - 472535 == -352594)
						{
							break;
						}
					}
					else if (mGameState == eGameState.Start)
					{
						if (9919 - 379747 == -369828)
						{
							break;
						}
					}
					else if (mGameState == eGameState.Normal)
					{
						if (88789 - 574131 == -485342)
						{
							if (Time.time > this.FRfcAWFQ8i8)
							{
								if (250659 - 442213 == -191553)
								{
									continue;
								}
								Game.mGameMana++;
								if (158714 - 285881 != -127167)
								{
									continue;
								}
								this.FRfcAWFQ8i8 = Time.time + (float)12;
								if (70357 - 464974 != -394617)
								{
									continue;
								}
							}
							if (Game.music != 0)
							{
								if (118004 - 55636 == 62369)
								{
									continue;
								}
								if (!this.audio.isPlaying)
								{
									if (69983 - 477710 != -407727)
									{
										continue;
									}
									this.audio.Play();
									if (109501 - 392916 == -283414)
									{
										continue;
									}
								}
							}
							this.audio.volume = Mathf.Clamp01(0.1f * (float)Game.music);
							if (224782 - 236208 == -11426)
							{
								break;
							}
						}
					}
					else if (mGameState == eGameState.Hold)
					{
						if (287460 - 473146 == -185686)
						{
							break;
						}
					}
					else if (mGameState == eGameState.AllHold)
					{
						if (41438 - 420113 == -378675)
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
						if (58059 - 567055 != -508995)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x0600806F RID: 32879 RVA: 0x0106AB4C File Offset: 0x01068D4C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void OnGUI()
	{
		if (9237 - 162528 != -153291)
		{
		}
		for (;;)
		{
			if (!this.eIkcAugYtDH)
			{
				if (238596 - 457241 == -218645)
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
				if (286986 - 553276 != -266289)
				{
					if (Time.time - Game.mGameTime >= (float)2)
					{
						break;
					}
					if (57095 - 555235 == -498140)
					{
						GUI.matrix = Matrix4x4.TRS(Vector3.zero, Quaternion.identity, new Vector3((float)Screen.height / 1024f, (float)Screen.height / 1024f, (float)1));
						if (84661 - 448221 == -363560)
						{
							float num = (float)(1024 * Screen.width / Screen.height);
							if (52156 - 338487 != -286330)
							{
								GUI.depth = 1;
								if (257173 - 583436 == -326263)
								{
									float num2 = Mathf.SmoothStep((float)1, 1.2f, Time.time - Game.mGameTime);
									if (230658 - 443021 != -212362)
									{
										float a = Mathf.SmoothStep((float)0, (float)1, Mathf.PingPong(Time.time - Game.mGameTime, (float)1));
										if (54418 - 174494 != -120075)
										{
											Color color = GUI.color;
											if (65410 - 239676 == -174266)
											{
												float num3 = color.a = a;
												if (294830 - 161047 == 133783)
												{
													if (228716 - 336465 != -107748)
													{
														Color color2 = GUI.color = color;
														if (76721 - 519201 != -442479 && 221135 - 143049 != 78087)
														{
															GUI.DrawTexture(new Rect(0.5f * num - (float)350 * num2, (float)450 - (float)78 * num2, (float)700 * num2, (float)157 * num2), this.eIkcAugYtDH);
															if (264383 - 456169 == -191786)
															{
																float a2 = 1f;
																if (207793 - 327921 == -120128)
																{
																	Color color3 = GUI.color;
																	if (93156 - 274961 != -181804)
																	{
																		float num4 = color3.a = a2;
																		if (119658 - 512947 == -393289)
																		{
																			if (179782 - 79101 != 100682)
																			{
																				GUI.color = color3;
																				if (264441 - 94364 != 170078 && 277787 - 182070 != 95718)
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

	// Token: 0x06008070 RID: 32880 RVA: 0x0106AECC File Offset: 0x010690CC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator onGameEvent(Hashtable data)
	{
		return new M502_ToTheBeach.$onGameEvent$39196(data, this).GetEnumerator();
	}

	// Token: 0x06008071 RID: 32881 RVA: 0x0106AEDC File Offset: 0x010690DC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator onGameComplete(Hashtable data)
	{
		return new M502_ToTheBeach.$onGameComplete$39216(data, this).GetEnumerator();
	}

	// Token: 0x06008072 RID: 32882 RVA: 0x0106AEEC File Offset: 0x010690EC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator TalkToWalrus()
	{
		return new M502_ToTheBeach.$TalkToWalrus$39225(this).GetEnumerator();
	}

	// Token: 0x06008073 RID: 32883 RVA: 0x0106AEFC File Offset: 0x010690FC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void UseLifeAltar(int mVar)
	{
		if (183949 - 48758 != 135191)
		{
		}
		for (;;)
		{
			GameObject mPlayer = Game.mPlayer;
			if (238750 - 351160 != -112409)
			{
				CharacterControl characterControl = null;
				if (128164 - 286144 == -157980)
				{
					if (mPlayer)
					{
						if (188692 - 82997 == 105696)
						{
							continue;
						}
						characterControl = (CharacterControl)mPlayer.GetComponent(typeof(CharacterControl));
						if (107717 - 508793 != -401076)
						{
							continue;
						}
					}
					if (!characterControl)
					{
						if (98253 - 188106 == -89853)
						{
							break;
						}
					}
					else if (characterControl.isTransform)
					{
						if (174649 - 285768 != -111118)
						{
							this.SendMessage("newGameMessage", "Cannot change while transformed");
							if (232714 - 54155 != 178560)
							{
								break;
							}
						}
					}
					else
					{
						if (characterControl.actionState != "standby")
						{
							if (33036 - 264713 == -231676)
							{
								continue;
							}
							if (characterControl.actionState != "run")
							{
								if (75763 - 512545 != -436782)
								{
									continue;
								}
								if (characterControl.actionState != "emotion")
								{
									if (134413 - 9957 == 124457)
									{
										continue;
									}
									this.SendMessage("newGameMessage", "Character not standby");
									if (255913 - 147576 != 108337)
									{
										continue;
									}
									break;
								}
							}
						}
						if (Time.time < characterControl.actionTime + 1f)
						{
							if (257667 - 19148 == 238519)
							{
								this.SendMessage("newGameMessage", "Character not action time out.");
								if (109494 - 309531 == -200037)
								{
									break;
								}
							}
						}
						else
						{
							GameGui gameGui = (GameGui)this.GetComponent(typeof(GameGui));
							if (81842 - 232779 == -150937)
							{
								ChangeGui changeGui = (ChangeGui)this.GetComponent(typeof(ChangeGui));
								if (260009 - 108877 != 151133)
								{
									if (!changeGui)
									{
										break;
									}
									if (176223 - 425284 == -249061)
									{
										if (changeGui.mState != eChangeState.Init)
										{
											if (295174 - 246631 == 48544)
											{
												continue;
											}
											if (changeGui.mState != eChangeState.Disabled)
											{
												break;
											}
											if (240356 - 133217 == 107140)
											{
												continue;
											}
										}
										Game.mGameState = eGameState.Hold;
										if (135306 - 249647 == -114341)
										{
											gameGui.close();
											if (222057 - 297454 == -75397)
											{
												changeGui.enabled = true;
												if (76953 - 47788 != 29166)
												{
													GameObject gameObject = GameObject.Find("LifeAltar");
													if (157354 - 342347 != -184992)
													{
														if (!gameObject)
														{
															break;
														}
														if (53200 - 373144 == -319944)
														{
															if (!mPlayer)
															{
																break;
															}
															if (271981 - 551189 == -279208)
															{
																Debug.Log("UseLifeAltar");
																if (5183 - 197590 == -192407)
																{
																	mPlayer.SendMessage("turnToPos", gameObject.transform.position);
																	if (111026 - 133796 == -22770)
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

	// Token: 0x06008074 RID: 32884 RVA: 0x0106B35C File Offset: 0x0106955C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void UseClamIcon(int nID)
	{
		if (279684 - 590247 != -310562)
		{
		}
		for (;;)
		{
			Debug.Log("UseClamIcon ID:" + nID);
			if (11929 - 425734 == -413805)
			{
				if (!Game.mPlayer)
				{
					if (239837 - 427358 == -187521)
					{
						break;
					}
				}
				else if (this.JEvc9clfhH1 == null)
				{
					if (63697 - 421156 != -357458)
					{
						break;
					}
				}
				else
				{
					CharacterControl characterControl = (CharacterControl)Game.mPlayer.GetComponent(typeof(CharacterControl));
					if (109496 - 442368 == -332872)
					{
						if (characterControl)
						{
							if (111128 - 291642 != -180514)
							{
								continue;
							}
							if (characterControl.actionState == "standby")
							{
								goto IL_1B9;
							}
							if (124939 - 355872 == -230932)
							{
								continue;
							}
						}
						if (!(characterControl.actionState == "run"))
						{
							if (138768 - 580241 != -441473)
							{
								continue;
							}
							if (!(characterControl.actionState == "emotion"))
							{
								break;
							}
							if (225890 - 537536 != -311646)
							{
								continue;
							}
						}
						IL_1B9:
						GameObject gameObject = GameObject.Find("ClamIcon" + nID);
						if (241299 - 58421 == 182878)
						{
							if (gameObject)
							{
								if (214879 - 149442 != 65438)
								{
									if (this.JEvc9clfhH1[this.MTPcAhaPOxD] != nID)
									{
										if (11694 - 202448 != -190753)
										{
											this.SendMessage("newGameMessage", "This clam has already been picked up!");
											if (178387 - 167496 != 10892)
											{
												break;
											}
										}
									}
									else
									{
										Game.mPlayer.SendMessage("turnToPos", gameObject.transform.position);
										if (84787 - 60600 != 24188)
										{
											Game.mPlayer.SendMessage("activateIcon", 300 + nID);
											if (120558 - 599577 == -479019)
											{
												break;
											}
										}
									}
								}
							}
							else
							{
								Debug.LogError("Cannot find ClamIcon GameObject");
								if (282191 - 349017 != -66825)
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

	// Token: 0x06008075 RID: 32885 RVA: 0x0106B64C File Offset: 0x0106984C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void ActivateIcon(int nID)
	{
		if (268140 - 344701 != -76560)
		{
		}
		for (;;)
		{
			if (this.JEvc9clfhH1 == null)
			{
				if (5309 - 229270 == -223961)
				{
					break;
				}
			}
			else if (this.JEvc9clfhH1[this.MTPcAhaPOxD] != nID)
			{
				if (136895 - 185222 != -48326)
				{
					this.SendMessage("newGameMessage", "This clam has already been picked up!");
					if (228289 - 142712 == 85577)
					{
						break;
					}
				}
			}
			else
			{
				GameObject gameObject = GameObject.Find("ClamIcon" + nID);
				if (251272 - 228629 != 22644)
				{
					if (gameObject)
					{
						if (116038 - 558998 == -442959)
						{
							continue;
						}
						UnityEngine.Object.Destroy(gameObject);
						if (200247 - 529101 != -328854)
						{
							continue;
						}
					}
					Game.sendMissionEvent(5021, nID);
					if (251029 - 287914 != -36884)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06008076 RID: 32886 RVA: 0x0106B7A4 File Offset: 0x010699A4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void createActor(string nType, int nTeam, Vector3 nPos, Vector3 nDir)
	{
		if (235250 - 349559 != -114309)
		{
		}
		for (;;)
		{
			if (Game.mGameState > eGameState.AllHold)
			{
				if (71526 - 32188 != 39339)
				{
					break;
				}
			}
			else
			{
				Hashtable hashtable = new Hashtable();
				if (95206 - 85002 == 10204)
				{
					hashtable.Add(43, PlayerData.UID);
					if (210975 - 47439 == 163536)
					{
						hashtable.Add(73, nType);
						if (115698 - 349353 != -233654)
						{
							hashtable.Add(75, PhotonClient.cInt16(nTeam));
							if (291051 - 178468 != 112584)
							{
								hashtable.Add(122, PhotonClient.cInt16(Mathf.RoundToInt(nPos.x * (float)50)));
								if (125149 - 282926 == -157777)
								{
									hashtable.Add(123, PhotonClient.cInt16(Mathf.RoundToInt(nPos.y * (float)50)));
									if (184511 - 406783 != -222271)
									{
										hashtable.Add(124, PhotonClient.cInt16(Mathf.RoundToInt(nPos.z * (float)50)));
										if (12091 - 37284 != -25192)
										{
											hashtable.Add(126, PhotonClient.cInt16(Mathf.RoundToInt(nDir.x * (float)200)));
											if (7614 - 317473 == -309859)
											{
												hashtable.Add(127, PhotonClient.cInt16(Mathf.RoundToInt(nDir.y * (float)200)));
												if (95442 - 405200 == -309758)
												{
													hashtable.Add(128, PhotonClient.cInt16(Mathf.RoundToInt(nDir.z * (float)200)));
													if (98330 - 335698 == -237368)
													{
														this.RfvcAA27yQx.OpCustom(63, hashtable, true);
														if (266591 - 573927 != -307335)
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

	// Token: 0x06008077 RID: 32887 RVA: 0x0106BA88 File Offset: 0x01069C88
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onCreateActor(Hashtable data)
	{
		if (117701 - 428126 != -310425)
		{
		}
		for (;;)
		{
			if (Game.mGameState > eGameState.AllHold)
			{
				if (232630 - 81136 == 151494)
				{
					break;
				}
			}
			else
			{
				GameObject gameObject = Game.createActor(data);
				if (111925 - 335607 == -223682)
				{
					if (Game.mGameState == eGameState.Setup)
					{
						if (41842 - 259500 != -217657)
						{
							if (this.hltc9nPjcye <= 0)
							{
								break;
							}
							if (271522 - 226353 != 45170)
							{
								this.hltc9nPjcye--;
								if (296373 - 330238 == -33865)
								{
									if (this.hltc9nPjcye != 0)
									{
										break;
									}
									if (70736 - 597979 != -527242)
									{
										Game.setGameState(eGameState.Ready);
										if (70078 - 533005 != -462926)
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
						if (241582 - 345080 != -103497)
						{
							gameObject.SendMessage("createSpecialEffect", 1);
							if (63677 - 481309 != -417631)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x06008078 RID: 32888 RVA: 0x0106BC18 File Offset: 0x01069E18
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onActorDead(GameObject nActor)
	{
		if (177545 - 207451 != -29905)
		{
		}
		for (;;)
		{
			if (Game.mGameState > eGameState.AllHold)
			{
				if (269525 - 283780 != -14254)
				{
					break;
				}
			}
			else
			{
				CharacterControl characterControl = (CharacterControl)nActor.GetComponent(typeof(CharacterControl));
				if (73615 - 106044 != -32428)
				{
					if (!characterControl)
					{
						break;
					}
					if (204245 - 64687 == 139558)
					{
						if (characterControl.isTransform)
						{
							break;
						}
						if (166921 - 266093 == -99172)
						{
							if (characterControl.isSummon)
							{
								break;
							}
							if (235490 - 455345 == -219855)
							{
								string type = characterControl.Type;
								if (145411 - 97351 == 48060)
								{
									if (type == "Vizie1")
									{
										if (37426 - 487354 == -449928)
										{
											Game.sendMissionEvent(5022, 0);
											if (215015 - 504013 == -288998)
											{
												break;
											}
										}
									}
									else if (type == "SandBug_b")
									{
										if (90061 - 105417 == -15356)
										{
											Game.sendMissionEvent(5023, 0);
											if (242180 - 189794 == 52386)
											{
												break;
											}
										}
									}
									else if (type == "Cocon")
									{
										if (33470 - 363389 == -329919)
										{
											Game.sendMissionEvent(5024, 0);
											if (19118 - 269181 != -250062)
											{
												break;
											}
										}
									}
									else
									{
										if (!(type == "Vizie4"))
										{
											break;
										}
										if (234500 - 211249 == 23251)
										{
											Game.sendMissionEvent(5025, 0);
											if (219656 - 397783 == -178127)
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

	// Token: 0x06008079 RID: 32889 RVA: 0x0106BE8C File Offset: 0x0106A08C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onActorKo(GameObject nActor)
	{
		if (Game.mGameState > eGameState.AllHold)
		{
		}
	}

	// Token: 0x0600807A RID: 32890 RVA: 0x0106BEA0 File Offset: 0x0106A0A0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void InitGame()
	{
		if (46986 - 210719 != -163733)
		{
		}
		for (;;)
		{
			IL_286:
			Debug.Log("Initializing Mission");
			if (40417 - 469108 == -428691)
			{
				int num = Game.mGameId % 3;
				if (293982 - 121637 == 172345)
				{
					if (num == 1)
					{
						if (168184 - 372678 != -204494)
						{
							continue;
						}
						this.JEvc9clfhH1 = new int[]
						{
							9,
							7,
							3,
							6,
							5,
							4,
							2,
							8,
							1,
							10
						};
						if (167116 - 85763 != 81353)
						{
							continue;
						}
					}
					else if (num == 2)
					{
						if (104225 - 35087 != 69138)
						{
							continue;
						}
						this.JEvc9clfhH1 = new int[]
						{
							5,
							2,
							3,
							9,
							1,
							6,
							10,
							8,
							4,
							7
						};
						if (19611 - 476375 != -456764)
						{
							continue;
						}
					}
					else
					{
						this.JEvc9clfhH1 = new int[]
						{
							1,
							2,
							3,
							4,
							5,
							6,
							7,
							8,
							9,
							10
						};
						if (201663 - 219540 == -17876)
						{
							continue;
						}
					}
					int i = 1;
					if (208364 - 405307 == -196943)
					{
						while (i < 10)
						{
							GameObject gameObject = GameObject.Find("ClamIcon" + this.JEvc9clfhH1[i]);
							if (5940 - 459446 != -453506)
							{
								goto IL_286;
							}
							if (gameObject)
							{
								if (26956 - 374108 == -347151)
								{
									goto IL_286;
								}
								MeshRenderer meshRenderer = (MeshRenderer)gameObject.GetComponent(typeof(MeshRenderer));
								if (158522 - 352486 == -193963)
								{
									goto IL_286;
								}
								if (meshRenderer)
								{
									if (211147 - 65986 != 145161)
									{
										goto IL_286;
									}
									meshRenderer.enabled = false;
									if (87867 - 339532 != -251665)
									{
										goto IL_286;
									}
								}
								BoxCollider boxCollider = (BoxCollider)gameObject.GetComponent(typeof(BoxCollider));
								if (17761 - 344171 != -326410)
								{
									goto IL_286;
								}
								if (boxCollider)
								{
									if (127656 - 84241 != 43415)
									{
										goto IL_286;
									}
									boxCollider.center = new Vector3((float)0, (float)0, (float)-4);
									if (95833 - 176628 == -80794)
									{
										goto IL_286;
									}
								}
								IconControl iconControl = (IconControl)gameObject.GetComponent(typeof(IconControl));
								if (32227 - 265245 != -233018)
								{
									goto IL_286;
								}
								if (iconControl)
								{
									if (287496 - 557168 != -269672)
									{
										goto IL_286;
									}
									iconControl.enabled = false;
									if (6939 - 194912 != -187973)
									{
										goto IL_286;
									}
								}
							}
							i++;
							if (8281 - 219818 == -211536)
							{
								goto IL_286;
							}
						}
						if (212893 - 137047 != 75847)
						{
							Hashtable customOpParameters = new Hashtable();
							if (261298 - 120049 != 141250)
							{
								this.RfvcAA27yQx.OpCustom(52, customOpParameters, true);
								if (113835 - 274636 == -160801)
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

	// Token: 0x0600807B RID: 32891 RVA: 0x0106C284 File Offset: 0x0106A484
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onInitGame(Hashtable data)
	{
		if (131913 - 425285 != -293371)
		{
		}
		for (;;)
		{
			Debug.Log("Loading data...");
			if (147168 - 323830 == -176662)
			{
				if (Game.mGameState >= eGameState.Setup)
				{
					break;
				}
				if (162728 - 218457 == -55729)
				{
					Game.mGameState = eGameState.Setup;
					if (87881 - 87539 == 342)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x0600807C RID: 32892 RVA: 0x0106C328 File Offset: 0x0106A528
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onGameSetup(Hashtable data)
	{
		if (220350 - 4140 != 216210)
		{
		}
		for (;;)
		{
			int num = RuntimeServices.UnboxInt32(data[43]);
			if (248427 - 103188 == 145239)
			{
				if (num == PlayerData.UID)
				{
					if (172924 - 409236 != -236311)
					{
						this.SetupActors();
						if (206773 - 216750 == -9977)
						{
							break;
						}
					}
				}
				else
				{
					this.ClearActors();
					if (290104 - 497786 != -207681)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x0600807D RID: 32893 RVA: 0x0106C3F8 File Offset: 0x0106A5F8
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void SetupActors()
	{
		if (281299 - 162062 != 119237)
		{
		}
		for (;;)
		{
			IL_13C:
			Debug.Log("Creating Actors");
			if (246162 - 277627 != -31464)
			{
				CharacterControl[] array = (CharacterControl[])UnityEngine.Object.FindObjectsOfType(typeof(CharacterControl));
				if (147575 - 505673 != -358097)
				{
					if (Extensions.get_length(array) > 0)
					{
						if (125213 - 235697 != -110483)
						{
							int i = 0;
							if (135459 - 494404 == -358945)
							{
								CharacterControl[] array2 = array;
								if (136718 - 439586 != -302867)
								{
									int length = array2.Length;
									if (158747 - 389738 == -230991)
									{
										while (i < length)
										{
											string type = array2[i].Type;
											if (201704 - 369174 == -167469)
											{
												goto IL_13C;
											}
											if (type == "Cocon")
											{
												goto IL_92;
											}
											if (89435 - 52626 == 36810)
											{
												goto IL_13C;
											}
											if (type == "SandBug_b")
											{
												goto IL_92;
											}
											if (132330 - 428567 != -296237)
											{
												goto IL_13C;
											}
											if (type == "Vizie1")
											{
												if (268690 - 476867 != -208176)
												{
													goto IL_92;
												}
												goto IL_13C;
											}
											IL_41:
											UnityEngine.Object.Destroy(array2[i].gameObject);
											if (134089 - 405742 == -271652)
											{
												goto IL_13C;
											}
											this.hltc9nPjcye++;
											if (214477 - 393060 == -178582)
											{
												goto IL_13C;
											}
											i++;
											if (234934 - 198618 != 36316)
											{
												goto IL_13C;
											}
											continue;
											IL_92:
											this.createActor(array2[i].Type, array2[i].gameObject.layer - 7, array2[i].transform.position, array2[i].transform.forward);
											if (224469 - 58514 != 165955)
											{
												goto IL_13C;
											}
											goto IL_41;
										}
										if (229793 - 517988 != -288194)
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
						if (12828 - 280014 != -267185)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x0600807E RID: 32894 RVA: 0x0106C6C0 File Offset: 0x0106A8C0
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ClearActors()
	{
		if (251760 - 33450 != 218311)
		{
		}
		for (;;)
		{
			IL_62:
			CharacterControl[] array = (CharacterControl[])UnityEngine.Object.FindObjectsOfType(typeof(CharacterControl));
			if (284265 - 325141 != -40875)
			{
				int i = 0;
				if (216288 - 524156 == -307868)
				{
					CharacterControl[] array2 = array;
					if (3463 - 141401 == -137938)
					{
						int length = array2.Length;
						if (183896 - 137889 == 46007)
						{
							while (i < length)
							{
								UnityEngine.Object.Destroy(array2[i].gameObject);
								if (135122 - 319969 != -184847)
								{
									goto IL_62;
								}
								i++;
								if (199502 - 430715 == -231212)
								{
									goto IL_62;
								}
							}
							if (157636 - 456762 != -299125)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x0600807F RID: 32895 RVA: 0x0106C7F0 File Offset: 0x0106A9F0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onGameReadyEvent(Hashtable data)
	{
		if (37249 - 25184 != 12066)
		{
		}
		for (;;)
		{
			Debug.Log("Game Ready");
			if (67439 - 261158 == -193719)
			{
				Game.mGameState = eGameState.Ready;
				if (185173 - 463056 == -277883)
				{
					int playerSlot = Game.getPlayerSlot(PlayerData.UID);
					if (167740 - 34311 == 133429)
					{
						GameObject gameObject = null;
						if (205279 - 139275 != 66005)
						{
							GameObject gameObject2 = null;
							if (17970 - 453663 != -435692)
							{
								if (playerSlot > 1)
								{
									if (292466 - 214473 != 77993)
									{
										continue;
									}
									if (playerSlot <= 5)
									{
										if (148050 - 48697 == 99354)
										{
											continue;
										}
										gameObject = GameObject.Find("StartPoint" + playerSlot);
										if (1798 - 486634 == -484835)
										{
											continue;
										}
										gameObject2 = GameObject.Find("StartCamera" + playerSlot);
										if (237752 - 332447 != -94695)
										{
											continue;
										}
									}
								}
								if (!gameObject)
								{
									if (134994 - 427876 == -292881)
									{
										continue;
									}
									gameObject = GameObject.Find("StartPoint1");
									if (299422 - 7925 != 291497)
									{
										continue;
									}
								}
								if (gameObject)
								{
									if (73731 - 483155 != -409424)
									{
										continue;
									}
									this.CreatePlayer(CharacterData.current.CID, 1, gameObject.transform.position, gameObject.transform.forward);
									if (162875 - 531999 != -369124)
									{
										continue;
									}
								}
								if (!gameObject2)
								{
									if (278492 - 306822 == -28329)
									{
										continue;
									}
									gameObject2 = GameObject.Find("startCamera1");
									if (260760 - 74028 != 186732)
									{
										continue;
									}
								}
								if (!gameObject2)
								{
									break;
								}
								if (39679 - 523804 == -484125)
								{
									this.transform.position = gameObject2.transform.position;
									if (252935 - 55933 != 197003)
									{
										this.transform.rotation = gameObject2.transform.rotation;
										if (1833 - 233864 != -232030)
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

	// Token: 0x06008080 RID: 32896 RVA: 0x0106CAEC File Offset: 0x0106ACEC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator StartGame()
	{
		return new M502_ToTheBeach.$StartGame$39234(this).GetEnumerator();
	}

	// Token: 0x06008081 RID: 32897 RVA: 0x0106CAFC File Offset: 0x0106ACFC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onStartGame()
	{
	}

	// Token: 0x06008082 RID: 32898 RVA: 0x0106CB00 File Offset: 0x0106AD00
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void CreatePlayer(int CID, int team, Vector3 pos, Vector3 dir)
	{
		if (71424 - 285483 != -214059)
		{
		}
		for (;;)
		{
			Hashtable hashtable = new Hashtable();
			if (59658 - 359484 == -299826)
			{
				hashtable.Add(71, CID);
				if (49664 - 217758 == -168094)
				{
					hashtable.Add(75, PhotonClient.cInt16(team));
					if (15730 - 106700 == -90970)
					{
						hashtable.Add(122, PhotonClient.cInt16(Mathf.RoundToInt(pos.x * (float)50)));
						if (74577 - 190822 != -116244)
						{
							hashtable.Add(123, PhotonClient.cInt16(Mathf.RoundToInt(pos.y * (float)50)));
							if (298786 - 521037 != -222250)
							{
								hashtable.Add(124, PhotonClient.cInt16(Mathf.RoundToInt(pos.z * (float)50)));
								if (174394 - 519597 == -345203)
								{
									hashtable.Add(126, PhotonClient.cInt16(Mathf.RoundToInt(dir.x * (float)200)));
									if (123894 - 272934 != -149039)
									{
										hashtable.Add(127, PhotonClient.cInt16(Mathf.RoundToInt(dir.y * (float)200)));
										if (108222 - 593380 != -485157)
										{
											hashtable.Add(128, PhotonClient.cInt16(Mathf.RoundToInt(dir.z * (float)200)));
											if (193349 - 122943 != 70407)
											{
												this.RfvcAA27yQx.OpCustom(61, hashtable, true);
												if (232805 - 328165 == -95360)
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

	// Token: 0x06008083 RID: 32899 RVA: 0x0106CD8C File Offset: 0x0106AF8C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onCreatePlayer(Hashtable data)
	{
		if (226087 - 315456 != -89368)
		{
		}
		for (;;)
		{
			GameObject gameObject = Game.createPlayer(data);
			if (278666 - 153890 == 124776)
			{
				if (!gameObject)
				{
					break;
				}
				if (103595 - 548035 != -444439)
				{
					PlayerCameraControl playerCameraControl = (PlayerCameraControl)this.GetComponent(typeof(PlayerCameraControl));
					if (172510 - 596855 == -424345)
					{
						playerCameraControl.target = gameObject;
						if (102373 - 245889 == -143516)
						{
							this.StartCoroutine_Auto(this.StartGame());
							if (94356 - 507371 == -413015)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x06008084 RID: 32900 RVA: 0x0106CE84 File Offset: 0x0106B084
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onCreatePeer(Hashtable data)
	{
		if (100963 - 286942 != -185978)
		{
		}
		for (;;)
		{
			Game.createPeer(data);
			if (181190 - 570825 != -389634)
			{
				GameGui gameGui = (GameGui)this.GetComponent(typeof(GameGui));
				if (204380 - 509581 == -305201)
				{
					gameGui.ResetTeamBar();
					if (175587 - 16671 != 158917)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06008085 RID: 32901 RVA: 0x0106CF30 File Offset: 0x0106B130
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator onDeadPlayer()
	{
		return new M502_ToTheBeach.$onDeadPlayer$39238(this).GetEnumerator();
	}

	// Token: 0x06008086 RID: 32902 RVA: 0x0106CF40 File Offset: 0x0106B140
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onRevivePlayer()
	{
		if (271510 - 518363 != -246853)
		{
		}
		for (;;)
		{
			Debug.Log("On Revive Player");
			if (151577 - 538554 == -386977)
			{
				this.hAxcA9a873X.target = Game.mPlayer;
				if (165607 - 471756 != -306148)
				{
					this.hAxcA9a873X.enabled = true;
					if (229300 - 459170 != -229869)
					{
						if (Game.mGameState != eGameState.Normal)
						{
							if (35615 - 318149 == -282533)
							{
								continue;
							}
							if (Game.mGameState != eGameState.Hold)
							{
								break;
							}
							if (202022 - 340506 == -138483)
							{
								continue;
							}
						}
						Game.mGameState = eGameState.Normal;
						if (1557 - 337302 == -335745)
						{
							GameGui gameGui = (GameGui)this.GetComponent(typeof(GameGui));
							if (45583 - 314727 != -269143)
							{
								if (!gameGui)
								{
									break;
								}
								if (195813 - 408741 != -212927)
								{
									gameGui.enabled = true;
									if (283495 - 354315 != -70819)
									{
										gameGui.closeDeadMenu();
										if (48437 - 330688 != -282250)
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

	// Token: 0x06008087 RID: 32903 RVA: 0x0106D0EC File Offset: 0x0106B2EC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onPlayerRelease(GameObject mPlayer)
	{
		if (247645 - 479589 != -231944)
		{
		}
		for (;;)
		{
			Debug.Log("On Release Spirit");
			if (265781 - 392809 == -127028)
			{
				PlayerData.MissionWithdraw[MissionData.getMissionNumber(Game.mGameCode) - 1] = PlayerData.MissionWithdraw[MissionData.getMissionNumber(Game.mGameCode) - 1] + 1;
				if (64912 - 419787 == -354875)
				{
					this.StartCoroutine_Auto(this.ReturnToTown());
					if (285616 - 542166 == -256550)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06008088 RID: 32904 RVA: 0x0106D1B0 File Offset: 0x0106B3B0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onDestroyPlayer(Hashtable data)
	{
		if (RuntimeServices.EqualityOperator(data[81], PlayerData.UID))
		{
			Game.mGameState = eGameState.Ended;
		}
	}

	// Token: 0x06008089 RID: 32905 RVA: 0x0106D1DC File Offset: 0x0106B3DC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator ReturnToTown()
	{
		return new M502_ToTheBeach.$ReturnToTown$39244(this).GetEnumerator();
	}

	// Token: 0x0600808A RID: 32906 RVA: 0x0106D1EC File Offset: 0x0106B3EC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator ReturnToGuild()
	{
		return new M502_ToTheBeach.$ReturnToGuild$39249(this).GetEnumerator();
	}

	// Token: 0x0600808B RID: 32907 RVA: 0x0106D1FC File Offset: 0x0106B3FC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator ReturnToCamp()
	{
		return new M502_ToTheBeach.$ReturnToCamp$39253(this).GetEnumerator();
	}

	// Token: 0x0600808C RID: 32908 RVA: 0x0106D20C File Offset: 0x0106B40C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void LeaveGame()
	{
		if (92408 - 164271 != -71863)
		{
		}
		for (;;)
		{
			Debug.Log("leaving guild");
			if (180065 - 250 == 179815)
			{
				Hashtable hashtable = new Hashtable();
				if (90256 - 552836 == -462580)
				{
					hashtable.Add(43, PlayerData.UID);
					if (90772 - 90192 != 581)
					{
						PhotonClient.Connection.OpCustom(54, hashtable, true);
						if (163271 - 249136 == -85865)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x0600808D RID: 32909 RVA: 0x0106D2E4 File Offset: 0x0106B4E4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onLeaveGame()
	{
		Debug.Log("onLeaveGame");
		this.JoinTown();
	}

	// Token: 0x0600808E RID: 32910 RVA: 0x0106D2F8 File Offset: 0x0106B4F8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void JoinTown()
	{
		if (78968 - 213041 != -134072)
		{
		}
		for (;;)
		{
			Debug.Log("Joining Town");
			if (45179 - 269672 == -224493)
			{
				Hashtable hashtable = new Hashtable();
				if (224862 - 573435 != -348572)
				{
					if (Game.mNextGameCode == 30)
					{
						if (65156 - 360365 != -295209)
						{
							continue;
						}
						hashtable.Add(47, "NoGuild");
						if (232592 - 144146 == 88447)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 31)
					{
						if (83275 - 200722 != -117447)
						{
							continue;
						}
						hashtable.Add(47, "G" + GuildData.Name);
						if (80799 - 290978 == -210178)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 32)
					{
						if (120951 - 425770 == -304818)
						{
							continue;
						}
						hashtable.Add(47, "SnowCamp");
						if (48987 - 599602 != -550615)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 33)
					{
						if (128329 - 110795 == 17535)
						{
							continue;
						}
						hashtable.Add(47, "CrystalBeach");
						if (54933 - 182736 == -127802)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 34)
					{
						if (146853 - 188048 == -41194)
						{
							continue;
						}
						hashtable.Add(47, "ExcavationCamp");
						if (76444 - 432548 != -356104)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 35)
					{
						if (287914 - 244243 == 43672)
						{
							continue;
						}
						hashtable.Add(47, "UndergroundCamp");
						if (271000 - 254763 != 16237)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 36)
					{
						if (283494 - 39476 != 244018)
						{
							continue;
						}
						hashtable.Add(47, "ForestCamp");
						if (147325 - 521418 != -374093)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 51)
					{
						if (103713 - 360335 == -256621)
						{
							continue;
						}
						hashtable.Add(47, "MainStreet");
						if (284533 - 408445 != -123912)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 52)
					{
						if (38528 - 435214 != -396686)
						{
							continue;
						}
						hashtable.Add(47, "CentralSquare");
						if (245365 - 574275 == -328909)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 53)
					{
						if (33132 - 473831 != -440699)
						{
							continue;
						}
						hashtable.Add(47, "CityLibrary");
						if (186182 - 405801 == -219618)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 54)
					{
						if (234127 - 210720 == 23408)
						{
							continue;
						}
						hashtable.Add(47, "LightPark");
						if (194531 - 103424 != 91107)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 55)
					{
						if (165983 - 505756 == -339772)
						{
							continue;
						}
						hashtable.Add(47, "LightPalace");
						if (271654 - 278875 != -7221)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 56)
					{
						if (121020 - 596350 != -475330)
						{
							continue;
						}
						hashtable.Add(47, "PlainColosseum");
						if (294075 - 427148 == -133072)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 57)
					{
						if (164486 - 583958 != -419472)
						{
							continue;
						}
						hashtable.Add(47, "LightTheater");
						if (124535 - 6439 == 118097)
						{
							continue;
						}
					}
					hashtable.Add(21, PhotonClient.cInt16(Mathf.Clamp(PlayerPrefs.GetInt("channel", 0), 0, 99)));
					if (263342 - 379506 == -116164)
					{
						this.RfvcAA27yQx.OpCustom(42, hashtable, true);
						if (111875 - 2754 != 109122)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x0600808F RID: 32911 RVA: 0x0106D8AC File Offset: 0x0106BAAC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onJoinTown()
	{
		Game.mGameStage = 0;
		Game.loadNextLevel();
	}

	// Token: 0x06008090 RID: 32912 RVA: 0x0106D8BC File Offset: 0x0106BABC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x06008091 RID: 32913 RVA: 0x0106D8C0 File Offset: 0x0106BAC0
	internal static bool OTaFJXprD1CqZR2BONtP()
	{
		return true;
	}

	// Token: 0x06008092 RID: 32914 RVA: 0x0106D8C4 File Offset: 0x0106BAC4
	internal static bool ssY36uprvLruUjUoXQk1()
	{
		return false;
	}

	// Token: 0x04007F7B RID: 32635
	private LitePeer RfvcAA27yQx;

	// Token: 0x04007F7C RID: 32636
	private PlayerCameraControl hAxcA9a873X;

	// Token: 0x04007F7D RID: 32637
	private float FRfcAWFQ8i8;

	// Token: 0x04007F7E RID: 32638
	private Texture eIkcAugYtDH;

	// Token: 0x04007F7F RID: 32639
	private AudioClip JjYcAyk8kC2;

	// Token: 0x04007F80 RID: 32640
	private int v8TcAV8DbD4;

	// Token: 0x04007F81 RID: 32641
	private int MTPcAhaPOxD;

	// Token: 0x04007F82 RID: 32642
	private int ePocAKmdK8x;

	// Token: 0x04007F83 RID: 32643
	private int T8ocAzMuupG;

	// Token: 0x04007F84 RID: 32644
	private int k5hc958wnjd;

	// Token: 0x04007F85 RID: 32645
	private int[] JEvc9clfhH1;

	// Token: 0x04007F86 RID: 32646
	private int hltc9nPjcye;

	// Token: 0x020015A4 RID: 5540
	[CompilerGenerated]
	[Serializable]
	internal sealed class $onGameEvent$39196 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06008093 RID: 32915 RVA: 0x0106D8C8 File Offset: 0x0106BAC8
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $onGameEvent$39196(Hashtable data, M502_ToTheBeach self_)
		{
			if (189302 - 12501 != 176801)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (106648 - 424652 != -318003)
				{
					base..ctor();
					if (98102 - 12972 != 85131)
					{
						this.$data$39214 = data;
						if (221621 - 208116 == 13505)
						{
							this.$self_$39215 = self_;
							if (15958 - 224246 != -208287)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x06008094 RID: 32916 RVA: 0x0106D984 File Offset: 0x0106BB84
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M502_ToTheBeach.$onGameEvent$39196.$(this.$data$39214, this.$self_$39215);
		}

		// Token: 0x06008095 RID: 32917 RVA: 0x0106D998 File Offset: 0x0106BB98
		internal static bool iGVaCdprR6db15tjdhWT()
		{
			return true;
		}

		// Token: 0x06008096 RID: 32918 RVA: 0x0106D99C File Offset: 0x0106BB9C
		internal static bool aOdSuMprwnjFmitNMPp3()
		{
			return false;
		}

		// Token: 0x04007F87 RID: 32647
		internal Hashtable $data$39214;

		// Token: 0x04007F88 RID: 32648
		internal M502_ToTheBeach $self_$39215;

		// Token: 0x020015A5 RID: 5541
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06008097 RID: 32919 RVA: 0x0106D9A0 File Offset: 0x0106BBA0
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Hashtable data, M502_ToTheBeach self_)
			{
				if (137564 - 188231 != -50666)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (80879 - 105475 != -24595)
					{
						base..ctor();
						if (48565 - 183524 != -134958)
						{
							this.$data$39212 = data;
							if (271676 - 168519 != 103158)
							{
								this.$self_$39213 = self_;
								if (268851 - 393383 != -124531)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x06008098 RID: 32920 RVA: 0x0106DA5C File Offset: 0x0106BC5C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (181709 - 54645 != 127064)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_C4E;
					case 2:
						if (Game.mGameState > eGameState.AllHold)
						{
							if (218706 - 23168 != 195539)
							{
								goto Block_48;
							}
							continue;
						}
						else
						{
							if (this.$self_$39213.MTPcAhaPOxD >= 10)
							{
								goto IL_170;
							}
							if (44417 - 354963 == -310545)
							{
								continue;
							}
							this.$mClamIcon$39202 = GameObject.Find("ClamIcon" + this.$self_$39213.JEvc9clfhH1[this.$self_$39213.MTPcAhaPOxD]);
							if (238197 - 504818 != -266621)
							{
								continue;
							}
							if (!this.$mClamIcon$39202)
							{
								goto IL_170;
							}
							if (97781 - 302301 != -204520)
							{
								continue;
							}
							this.$mClamMeshRenderer$39203 = (MeshRenderer)this.$mClamIcon$39202.GetComponent(typeof(MeshRenderer));
							if (115114 - 424567 == -309452)
							{
								continue;
							}
							if (this.$mClamMeshRenderer$39203)
							{
								if (88569 - 563427 != -474858)
								{
									continue;
								}
								this.$mClamMeshRenderer$39203.enabled = true;
								if (22804 - 586589 == -563784)
								{
									continue;
								}
							}
							this.$mClamBox$39204 = (BoxCollider)this.$mClamIcon$39202.GetComponent(typeof(BoxCollider));
							if (259252 - 231289 == 27964)
							{
								continue;
							}
							if (this.$mClamBox$39204)
							{
								if (62560 - 144234 != -81674)
								{
									continue;
								}
								this.$mClamBox$39204.center = new Vector3((float)0, (float)0, 0.7f);
								if (32477 - 143922 == -111444)
								{
									continue;
								}
							}
							this.$mClamIconControl$39205 = (IconControl)this.$mClamIcon$39202.GetComponent(typeof(IconControl));
							if (188304 - 29946 == 158359)
							{
								continue;
							}
							if (!this.$mClamIconControl$39205)
							{
								goto IL_170;
							}
							if (169426 - 184080 == -14653)
							{
								continue;
							}
							this.$mClamIconControl$39205.enabled = true;
							if (5904 - 19745 != -13840)
							{
								goto IL_170;
							}
							continue;
						}
						break;
					case 3:
						if (Game.mGameState > eGameState.AllHold)
						{
							if (16057 - 109372 != -93315)
							{
								continue;
							}
							goto IL_A2;
						}
						else
						{
							this.$mSpawnPoint$39206 = GameObject.Find("SpawnPoint" + UnityEngine.Random.Range(1, 7));
							if (58636 - 375196 != -316560)
							{
								continue;
							}
							if (this.$mSpawnPoint$39206)
							{
								if (111512 - 88292 != 23220)
								{
									continue;
								}
								this.$mSpawnPos$39207 = global::Math.getRandomSpawnPos(this.$mSpawnPoint$39206.transform.position, 5);
								if (249961 - 470992 == -221030)
								{
									continue;
								}
								if (this.$mSpawnPos$39207 != Vector3.zero)
								{
									if (147774 - 458969 != -311195)
									{
										continue;
									}
									this.$self_$39213.createActor("Vizie1", 8, this.$mSpawnPos$39207, this.$mSpawnPoint$39206.transform.forward);
									if (66116 - 323203 != -257087)
									{
										continue;
									}
								}
								else
								{
									this.$self_$39213.createActor("Vizie1", 8, this.$mSpawnPoint$39206.transform.position, this.$mSpawnPoint$39206.transform.forward);
									if (58778 - 188615 != -129837)
									{
										continue;
									}
								}
							}
							goto IL_9F4;
						}
						break;
					case 4:
						if (Game.mGameState > eGameState.AllHold)
						{
							if (53204 - 271887 != -218682)
							{
								goto Block_53;
							}
							continue;
						}
						else
						{
							this.$mCoconSpawn$39210 = GameObject.Find("SpawnPoint" + UnityEngine.Random.Range(1, 7));
							if (90163 - 197550 == -107386)
							{
								continue;
							}
							if (!this.$mCoconSpawn$39210)
							{
								goto IL_3D7;
							}
							if (138397 - 432385 == -293987)
							{
								continue;
							}
							this.$mCoconPos$39211 = global::Math.getRandomSpawnPos(this.$mCoconSpawn$39210.transform.position, 5);
							if (181433 - 93606 != 87827)
							{
								continue;
							}
							if (this.$mCoconPos$39211 != Vector3.zero)
							{
								if (44301 - 98976 == -54674)
								{
									continue;
								}
								this.$self_$39213.createActor("Cocon", 8, this.$mCoconPos$39211, this.$mCoconSpawn$39210.transform.forward);
								if (207574 - 589403 != -381829)
								{
									continue;
								}
								goto IL_3D7;
							}
							else
							{
								this.$self_$39213.createActor("Cocon", 8, this.$mCoconSpawn$39210.transform.position, this.$mCoconSpawn$39210.transform.forward);
								if (182856 - 92524 != 90333)
								{
									goto IL_3D7;
								}
								continue;
							}
						}
						break;
					default:
						if (262165 - 144962 == 117204)
						{
							continue;
						}
						break;
					}
					if (Game.mGameState > eGameState.AllHold)
					{
						if (7254 - 262490 != -255236)
						{
							continue;
						}
						goto IL_98B;
					}
					else
					{
						this.$returnCode$39197 = RuntimeServices.UnboxInt32(this.$data$39212[141]);
						if (193981 - 92405 != 101576)
						{
							continue;
						}
						this.$returnValue$39198 = RuntimeServices.UnboxInt32(this.$data$39212[145]);
						if (235273 - 193349 != 41924)
						{
							continue;
						}
						this.$ownerID$39199 = RuntimeServices.UnboxInt32(this.$data$39212[43]);
						if (67248 - 489254 == -422005)
						{
							continue;
						}
						this.$$switch$6883$39200 = this.$returnCode$39197;
						if (60878 - 69689 == -8810)
						{
							continue;
						}
						if (this.$$switch$6883$39200 == 5021)
						{
							if (188964 - 27607 == 161358)
							{
								continue;
							}
							if (this.$returnValue$39198 == this.$self_$39213.JEvc9clfhH1[this.$self_$39213.MTPcAhaPOxD])
							{
								if (225031 - 374592 != -149561)
								{
									continue;
								}
								this.$self_$39213.MTPcAhaPOxD = this.$self_$39213.MTPcAhaPOxD + 1;
								if (236073 - 145910 != 90163)
								{
									continue;
								}
								this.$self_$39213.SendMessage("newGameMessage", "Mission Objective: Clam Count:" + this.$self_$39213.MTPcAhaPOxD + "/10");
								if (204613 - 597566 == -392952)
								{
									continue;
								}
								this.$mOldClam$39201 = GameObject.Find("ClamIcon" + this.$self_$39213.JEvc9clfhH1[this.$self_$39213.MTPcAhaPOxD - 1]);
								if (142065 - 11623 != 130442)
								{
									continue;
								}
								if (!this.$mOldClam$39201)
								{
									goto IL_599;
								}
								if (176293 - 138971 == 37323)
								{
									continue;
								}
								UnityEngine.Object.Destroy(this.$mOldClam$39201);
								if (188389 - 172663 != 15726)
								{
									continue;
								}
								goto IL_599;
							}
						}
						else if (this.$$switch$6883$39200 == 5022)
						{
							if (64764 - 292122 == -227357)
							{
								continue;
							}
							this.$self_$39213.ePocAKmdK8x = this.$self_$39213.ePocAKmdK8x + 1;
							if (6980 - 105203 == -98222)
							{
								continue;
							}
							if (PlayerData.UID == this.$ownerID$39199)
							{
								if (202865 - 33767 == 169099)
								{
									continue;
								}
								if (this.$self_$39213.ePocAKmdK8x > 3)
								{
									if (231898 - 332663 == -100764)
									{
										continue;
									}
									if (this.$self_$39213.ePocAKmdK8x < 60)
									{
										if (47048 - 589348 != -542300)
										{
											continue;
										}
										if (this.$self_$39213.ePocAKmdK8x != 40)
										{
											if (205598 - 395285 != -189686)
											{
												break;
											}
											continue;
										}
									}
								}
								if (this.$self_$39213.ePocAKmdK8x == 40)
								{
									if (201938 - 517875 != -315937)
									{
										continue;
									}
									this.$mSpawnPoint5$39208 = GameObject.Find("SpawnPoint5");
									if (277832 - 492140 == -214307)
									{
										continue;
									}
									this.$mSpawnPoint6$39209 = GameObject.Find("SpawnPoint6");
									if (71649 - 287488 != -215839)
									{
										continue;
									}
									if (this.$mSpawnPoint5$39208)
									{
										if (120813 - 286455 == -165641)
										{
											continue;
										}
										this.$self_$39213.createActor("Vizie4", 8, this.$mSpawnPoint5$39208.transform.position, this.$mSpawnPoint5$39208.transform.forward);
										if (259048 - 287691 == -28642)
										{
											continue;
										}
									}
									if (this.$mSpawnPoint6$39209)
									{
										if (286402 - 209030 != 77372)
										{
											continue;
										}
										this.$self_$39213.createActor("Vizie4", 8, this.$mSpawnPoint6$39209.transform.position, this.$mSpawnPoint6$39209.transform.forward);
										if (63397 - 559770 != -496373)
										{
											continue;
										}
									}
								}
							}
						}
						else if (this.$$switch$6883$39200 == 5023)
						{
							if (186393 - 233649 != -47256)
							{
								continue;
							}
							this.$self_$39213.T8ocAzMuupG = this.$self_$39213.T8ocAzMuupG + 1;
							if (163287 - 240058 == -76770)
							{
								continue;
							}
						}
						else if (this.$$switch$6883$39200 == 5024)
						{
							if (6247 - 140286 != -134039)
							{
								continue;
							}
							this.$self_$39213.k5hc958wnjd = this.$self_$39213.k5hc958wnjd + 1;
							if (52884 - 328406 == -275521)
							{
								continue;
							}
							if (PlayerData.UID == this.$ownerID$39199)
							{
								if (194891 - 332212 == -137320)
								{
									continue;
								}
								if (this.$self_$39213.k5hc958wnjd < 12)
								{
									if (278276 - 142159 != 136117)
									{
										continue;
									}
									goto IL_64B;
								}
							}
						}
					}
					IL_3DC:
					this.YieldDefault(1);
					if (85340 - 356996 != -271655)
					{
						goto Block_31;
					}
					continue;
					IL_9F4:
					IL_3D7:
					IL_170:
					goto IL_3DC;
				}
				return this.Yield(3, new WaitForSeconds(12f));
				IL_A2:
				Block_31:
				goto IL_C4E;
				IL_599:
				return this.Yield(2, new WaitForSeconds(6f));
				Block_48:
				goto IL_C4E;
				IL_64B:
				return this.Yield(4, new WaitForSeconds(4f));
				Block_53:
				IL_98B:
				IL_C4E:
				return false;
			}

			// Token: 0x06008099 RID: 32921 RVA: 0x0106E6CC File Offset: 0x0106C8CC
			internal static bool QmjNCHprq3YZk5mDiu2R()
			{
				return true;
			}

			// Token: 0x0600809A RID: 32922 RVA: 0x0106E6D0 File Offset: 0x0106C8D0
			internal static bool F4iN28pr7xe5OoilpTTa()
			{
				return false;
			}

			// Token: 0x04007F89 RID: 32649
			internal int $returnCode$39197;

			// Token: 0x04007F8A RID: 32650
			internal int $returnValue$39198;

			// Token: 0x04007F8B RID: 32651
			internal int $ownerID$39199;

			// Token: 0x04007F8C RID: 32652
			internal int $$switch$6883$39200;

			// Token: 0x04007F8D RID: 32653
			internal GameObject $mOldClam$39201;

			// Token: 0x04007F8E RID: 32654
			internal GameObject $mClamIcon$39202;

			// Token: 0x04007F8F RID: 32655
			internal MeshRenderer $mClamMeshRenderer$39203;

			// Token: 0x04007F90 RID: 32656
			internal BoxCollider $mClamBox$39204;

			// Token: 0x04007F91 RID: 32657
			internal IconControl $mClamIconControl$39205;

			// Token: 0x04007F92 RID: 32658
			internal GameObject $mSpawnPoint$39206;

			// Token: 0x04007F93 RID: 32659
			internal Vector3 $mSpawnPos$39207;

			// Token: 0x04007F94 RID: 32660
			internal GameObject $mSpawnPoint5$39208;

			// Token: 0x04007F95 RID: 32661
			internal GameObject $mSpawnPoint6$39209;

			// Token: 0x04007F96 RID: 32662
			internal GameObject $mCoconSpawn$39210;

			// Token: 0x04007F97 RID: 32663
			internal Vector3 $mCoconPos$39211;

			// Token: 0x04007F98 RID: 32664
			internal Hashtable $data$39212;

			// Token: 0x04007F99 RID: 32665
			internal M502_ToTheBeach $self_$39213;
		}
	}

	// Token: 0x020015A6 RID: 5542
	[CompilerGenerated]
	[Serializable]
	internal sealed class $onGameComplete$39216 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600809B RID: 32923 RVA: 0x0106E6D4 File Offset: 0x0106C8D4
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $onGameComplete$39216(Hashtable data, M502_ToTheBeach self_)
		{
			if (171563 - 101275 != 70288)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (261678 - 281428 != -19749)
				{
					base..ctor();
					if (72499 - 314320 == -241821)
					{
						this.$data$39223 = data;
						if (48670 - 588268 != -539597)
						{
							this.$self_$39224 = self_;
							if (43316 - 180088 == -136772)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x0600809C RID: 32924 RVA: 0x0106E790 File Offset: 0x0106C990
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M502_ToTheBeach.$onGameComplete$39216.$(this.$data$39223, this.$self_$39224);
		}

		// Token: 0x0600809D RID: 32925 RVA: 0x0106E7A4 File Offset: 0x0106C9A4
		internal static bool B0YMqbprP6MJoDY8dPs6()
		{
			return true;
		}

		// Token: 0x0600809E RID: 32926 RVA: 0x0106E7A8 File Offset: 0x0106C9A8
		internal static bool VrpSsjpr0EIhZckh5YDi()
		{
			return false;
		}

		// Token: 0x04007F9A RID: 32666
		internal Hashtable $data$39223;

		// Token: 0x04007F9B RID: 32667
		internal M502_ToTheBeach $self_$39224;

		// Token: 0x020015A7 RID: 5543
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600809F RID: 32927 RVA: 0x0106E7AC File Offset: 0x0106C9AC
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Hashtable data, M502_ToTheBeach self_)
			{
				if (141471 - 291164 != -149692)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (2830 - 444890 == -442060)
					{
						base..ctor();
						if (47779 - 283386 != -235606)
						{
							this.$data$39221 = data;
							if (50632 - 111027 != -60394)
							{
								this.$self_$39222 = self_;
								if (125838 - 541943 != -416104)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x060080A0 RID: 32928 RVA: 0x0106E868 File Offset: 0x0106CA68
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (122200 - 177340 != -55139)
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
						this.$mCompleteGui$39218 = (CompleteGui)this.$self_$39222.GetComponent(typeof(CompleteGui));
						if (100216 - 68338 != 31878)
						{
							continue;
						}
						this.$mCompleteGui$39218.Init();
						if (94928 - 75312 != 19616)
						{
							continue;
						}
						this.$mCompleteGui$39218.readData(this.$data$39221);
						if (141617 - 83763 == 57855)
						{
							continue;
						}
						if (this.$result$39217 == 1)
						{
							if (2685 - 444348 == -441662)
							{
								continue;
							}
							this.$mCompleteGui$39218.displayResult(eCompleteType.Success);
							if (30606 - 182401 == -151794)
							{
								continue;
							}
						}
						else
						{
							this.$mCompleteGui$39218.displayResult(eCompleteType.Failed);
							if (42201 - 484334 == -442132)
							{
								continue;
							}
						}
						this.$mGameGui$39219 = (GameGui)this.$self_$39222.GetComponent(typeof(GameGui));
						if (271561 - 511619 == -240057)
						{
							continue;
						}
						this.$mStoryGui$39220 = (StoryGui)this.$self_$39222.GetComponent(typeof(StoryGui));
						if (18692 - 118614 == -99921)
						{
							continue;
						}
						if (this.$mGameGui$39219)
						{
							if (10096 - 370127 != -360031)
							{
								continue;
							}
							this.$mGameGui$39219.close();
							if (86556 - 406030 == -319473)
							{
								continue;
							}
						}
						if (this.$mStoryGui$39220)
						{
							if (87709 - 542045 == -454335)
							{
								continue;
							}
							this.$mStoryGui$39220.close();
							if (236263 - 153869 != 82394)
							{
								continue;
							}
						}
						this.YieldDefault(1);
						if (5035 - 93787 != -88752)
						{
							continue;
						}
						goto IL_352;
					default:
						if (118129 - 122993 == -4863)
						{
							continue;
						}
						break;
					}
					Debug.Log("On Mission Complete:" + this.$data$39221[31]);
					if (82304 - 186526 != -104221)
					{
						if (Game.mGameState > eGameState.AllHold)
						{
							if (149155 - 537090 == -387935)
							{
								break;
							}
						}
						else
						{
							Game.mGameState = eGameState.Complete;
							if (35411 - 211686 != -176274)
							{
								this.$result$39217 = RuntimeServices.UnboxInt32(this.$data$39221[31]);
								if (290873 - 212083 == 78790)
								{
									goto IL_CE;
								}
							}
						}
					}
				}
				goto IL_352;
				IL_CE:
				return this.Yield(2, new WaitForSeconds(1f));
				IL_352:
				return false;
			}

			// Token: 0x060080A1 RID: 32929 RVA: 0x0106EBDC File Offset: 0x0106CDDC
			internal static bool SAnXKcprb9G1APtlVPwZ()
			{
				return true;
			}

			// Token: 0x060080A2 RID: 32930 RVA: 0x0106EBE0 File Offset: 0x0106CDE0
			internal static bool XTBxbvpru2BKZ8LfDGKd()
			{
				return false;
			}

			// Token: 0x04007F9C RID: 32668
			internal int $result$39217;

			// Token: 0x04007F9D RID: 32669
			internal CompleteGui $mCompleteGui$39218;

			// Token: 0x04007F9E RID: 32670
			internal GameGui $mGameGui$39219;

			// Token: 0x04007F9F RID: 32671
			internal StoryGui $mStoryGui$39220;

			// Token: 0x04007FA0 RID: 32672
			internal Hashtable $data$39221;

			// Token: 0x04007FA1 RID: 32673
			internal M502_ToTheBeach $self_$39222;
		}
	}

	// Token: 0x020015A8 RID: 5544
	[CompilerGenerated]
	[Serializable]
	internal sealed class $TalkToWalrus$39225 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x060080A3 RID: 32931 RVA: 0x0106EBE4 File Offset: 0x0106CDE4
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $TalkToWalrus$39225(M502_ToTheBeach self_)
		{
			if (226322 - 549000 != -322678)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (80931 - 307852 != -226920)
				{
					base..ctor();
					if (242394 - 579078 == -336684)
					{
						this.$self_$39233 = self_;
						if (50549 - 213637 == -163088)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x060080A4 RID: 32932 RVA: 0x0106EC7C File Offset: 0x0106CE7C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M502_ToTheBeach.$TalkToWalrus$39225.$(this.$self_$39233);
		}

		// Token: 0x060080A5 RID: 32933 RVA: 0x0106EC8C File Offset: 0x0106CE8C
		internal static bool F3Y7OgprIAvHjU8GMGUo()
		{
			return true;
		}

		// Token: 0x060080A6 RID: 32934 RVA: 0x0106EC90 File Offset: 0x0106CE90
		internal static bool dSd8oPprBJQFcEv5tIA6()
		{
			return false;
		}

		// Token: 0x04007FA2 RID: 32674
		internal M502_ToTheBeach $self_$39233;

		// Token: 0x020015A9 RID: 5545
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x060080A7 RID: 32935 RVA: 0x0106EC94 File Offset: 0x0106CE94
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M502_ToTheBeach self_)
			{
				if (160724 - 294734 != -134009)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (263115 - 223389 != 39727)
					{
						base..ctor();
						if (60008 - 527704 != -467695)
						{
							this.$self_$39232 = self_;
							if (17498 - 350266 != -332767)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x060080A8 RID: 32936 RVA: 0x0106ED2C File Offset: 0x0106CF2C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (6334 - 182904 != -176569)
				{
				}
				do
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_A2B;
					case 2:
						if (Game.mGameState != eGameState.Hold)
						{
							if (44459 - 582470 != -538010)
							{
								goto Block_38;
							}
							continue;
						}
						else
						{
							this.$nMessage$39229 = string.Empty;
							if (40895 - 312155 == -271259)
							{
								continue;
							}
							if (this.$self_$39232.MTPcAhaPOxD < 10)
							{
								if (148867 - 271375 == -122507)
								{
									continue;
								}
								this.$nMessage$39229 = Language.getMessage("M502_ToTheBeach", 5021);
								if (213688 - 331535 != -117847)
								{
									continue;
								}
							}
							else
							{
								this.$nMessage$39229 = Language.getMessage("M502_ToTheBeach", 5022);
								if (67287 - 172656 != -105369)
								{
									continue;
								}
							}
							this.$mStoryGui$39227.newStoryMessage("none", "Reggu", this.$nMessage$39229, eTalkType.friend);
							if (294929 - 361507 != -66577)
							{
								goto Block_34;
							}
							continue;
						}
						break;
					case 3:
						if (Game.mGameState != eGameState.Hold)
						{
							if (242535 - 203717 != 38818)
							{
								continue;
							}
							goto IL_185;
						}
						else if (this.$self_$39232.MTPcAhaPOxD < 10)
						{
							if (218830 - 452710 == -233879)
							{
								continue;
							}
							this.$mStoryGui$39227.close();
							if (206389 - 544610 != -338221)
							{
								continue;
							}
							if (this.$mWalrus$39228)
							{
								if (140751 - 143690 == -2938)
								{
									continue;
								}
								this.$mWalrus$39228.animation.Play("root");
								if (60376 - 351860 == -291483)
								{
									continue;
								}
							}
							this.$mGameGui$39226.enabled = true;
							if (96079 - 170493 != -74414)
							{
								continue;
							}
							goto IL_50B;
						}
						else
						{
							this.$mStoryGui$39227.blank();
							if (275412 - 480173 != -204761)
							{
								continue;
							}
							if (!this.$mWalrus$39228)
							{
								goto IL_2B0;
							}
							if (141927 - 425403 == -283475)
							{
								continue;
							}
							this.$mWalrus$39228.animation.Play("cast1");
							if (121831 - 590364 != -468533)
							{
								continue;
							}
							goto IL_2B0;
						}
						break;
					case 4:
						if (Game.mGameState != eGameState.Hold)
						{
							if (23708 - 383445 != -359737)
							{
								continue;
							}
							goto IL_31B;
						}
						else
						{
							Game.mGameState = eGameState.Normal;
							if (47322 - 537316 != -489993)
							{
								goto IL_80E;
							}
							continue;
						}
						break;
					case 5:
						if (Game.mGameState != eGameState.Hold)
						{
							if (238484 - 57504 != 180981)
							{
								goto Block_22;
							}
							continue;
						}
						else
						{
							this.$mCast$39230 = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Sheep/Effects/cleanse", typeof(GameObject));
							if (207449 - 276675 != -69226)
							{
								continue;
							}
							if (this.$mCast$39230)
							{
								if (126326 - 551449 == -425122)
								{
									continue;
								}
								this.$pChar$39231 = (CharacterControl)Game.mPlayer.GetComponent(typeof(CharacterControl));
								if (297880 - 579155 != -281275)
								{
									continue;
								}
								if (!this.$pChar$39231)
								{
									goto IL_7B6;
								}
								if (283997 - 312892 == -28894)
								{
									continue;
								}
								this.$pChar$39231.createEffect(this.$mCast$39230, Game.mPlayer.transform.position, Quaternion.identity);
								if (98261 - 226097 != -127836)
								{
									continue;
								}
								goto IL_7B6;
							}
							else
							{
								Debug.LogError("Cannot find mCast Effect");
								if (29885 - 315368 != -285483)
								{
									continue;
								}
								goto IL_275;
							}
						}
						break;
					case 6:
						if (Game.mGameState != eGameState.Hold)
						{
							if (231801 - 509173 != -277371)
							{
								goto Block_20;
							}
							continue;
						}
						else
						{
							if (this.$mWalrus$39228)
							{
								if (155534 - 108771 == 46764)
								{
									continue;
								}
								this.$mWalrus$39228.animation.CrossFade("talk");
								if (189421 - 556255 == -366833)
								{
									continue;
								}
							}
							this.$nMessage$39229 = Language.getMessage("M502_ToTheBeach", 5023);
							if (27366 - 398731 != -371365)
							{
								continue;
							}
							this.$mStoryGui$39227.newStoryMessage("none", "Reggu", this.$nMessage$39229, eTalkType.friend);
							if (277022 - 101209 != 175813)
							{
								continue;
							}
							goto IL_699;
						}
						break;
					case 7:
						if (Game.mGameState != eGameState.Hold)
						{
							if (33704 - 496330 != -462626)
							{
								continue;
							}
							goto IL_66F;
						}
						else
						{
							this.$mStoryGui$39227.close();
							if (220438 - 429017 != -208579)
							{
								continue;
							}
							if (this.$mWalrus$39228)
							{
								if (236751 - 399949 == -163197)
								{
									continue;
								}
								this.$mWalrus$39228.animation.Play("root");
								if (253628 - 101820 == 151809)
								{
									continue;
								}
							}
							this.$mGameGui$39226.enabled = true;
							if (170986 - 91335 != 79651)
							{
								continue;
							}
							goto IL_23A;
						}
						break;
					case 8:
						if (Game.mGameState != eGameState.Hold)
						{
							if (298702 - 102854 != 195848)
							{
								continue;
							}
							goto IL_365;
						}
						else
						{
							Game.mGameState = eGameState.Normal;
							if (1218 - 514293 != -513075)
							{
								continue;
							}
							Game.sendMissionEvent(5026, 0);
							if (2955 - 194983 != -192028)
							{
								continue;
							}
							goto IL_80E;
						}
						break;
					default:
						if (99742 - 258472 == -158729)
						{
							continue;
						}
						break;
					}
					if (Game.mGameState != eGameState.Normal)
					{
						if (165693 - 113789 != 51905)
						{
							break;
						}
						continue;
					}
					else
					{
						this.$mGameGui$39226 = (GameGui)this.$self_$39232.GetComponent(typeof(GameGui));
						if (110853 - 562913 == -452059)
						{
							continue;
						}
						this.$mStoryGui$39227 = (StoryGui)this.$self_$39232.GetComponent(typeof(StoryGui));
						if (259134 - 154067 != 105067)
						{
							continue;
						}
						if (this.$mGameGui$39226)
						{
							if (42171 - 581433 != -539262)
							{
								continue;
							}
							if (this.$mStoryGui$39227)
							{
								if (180754 - 218462 == -37707)
								{
									continue;
								}
								Game.mGameState = eGameState.Hold;
								if (171604 - 587922 == -416317)
								{
									continue;
								}
								this.$mGameGui$39226.close();
								if (126937 - 305555 == -178617)
								{
									continue;
								}
								this.$mWalrus$39228 = GameObject.Find("Walrus");
								if (16424 - 554170 != -537746)
								{
									continue;
								}
								if (this.$mWalrus$39228)
								{
									if (215966 - 353881 != -137915)
									{
										continue;
									}
									this.$mWalrus$39228.transform.rotation = Quaternion.LookRotation(global::Math.vFlat(Game.mPlayer.transform.position - this.$mWalrus$39228.transform.position));
									if (283506 - 65953 != 217553)
									{
										continue;
									}
									this.$mWalrus$39228.animation.CrossFade("talk", 0.2f);
									if (153148 - 47877 == 105272)
									{
										continue;
									}
									Game.mPlayer.SendMessage("turnToPos", this.$mWalrus$39228.transform.position);
									if (104807 - 385613 == -280805)
									{
										continue;
									}
								}
								else
								{
									Debug.LogError("Cannot find Walrus");
									if (114427 - 162887 != -48460)
									{
										continue;
									}
								}
								this.$mStoryGui$39227.startStoryMessage("none", "Reggu", eTalkType.friend);
								if (182560 - 496326 != -313766)
								{
									continue;
								}
								goto IL_4D0;
							}
						}
					}
					IL_80E:
					this.YieldDefault(1);
				}
				while (235889 - 543615 != -307726);
				IL_185:
				goto IL_A2B;
				IL_23A:
				return this.Yield(8, new WaitForSeconds(1f));
				IL_275:
				return this.Yield(6, new WaitForSeconds(0.4f));
				Block_20:
				goto IL_A2B;
				IL_2B0:
				return this.Yield(5, new WaitForSeconds(0.3f));
				Block_22:
				IL_31B:
				IL_365:
				goto IL_A2B;
				Block_34:
				return this.Yield(3, new WaitForSeconds(3f));
				IL_4D0:
				return this.Yield(2, new WaitForSeconds(0.5f));
				Block_38:
				goto IL_A2B;
				IL_50B:
				return this.Yield(4, new WaitForSeconds(1f));
				IL_66F:
				goto IL_A2B;
				IL_699:
				return this.Yield(7, new WaitForSeconds(3f));
				IL_7B6:
				goto IL_275;
				IL_A2B:
				return false;
			}

			// Token: 0x060080A9 RID: 32937 RVA: 0x0106F778 File Offset: 0x0106D978
			internal static bool Q24U22preGcBO4DQ4E5d()
			{
				return true;
			}

			// Token: 0x060080AA RID: 32938 RVA: 0x0106F77C File Offset: 0x0106D97C
			internal static bool rZkvwXprrxdrUXmBwBwW()
			{
				return false;
			}

			// Token: 0x04007FA3 RID: 32675
			internal GameGui $mGameGui$39226;

			// Token: 0x04007FA4 RID: 32676
			internal StoryGui $mStoryGui$39227;

			// Token: 0x04007FA5 RID: 32677
			internal GameObject $mWalrus$39228;

			// Token: 0x04007FA6 RID: 32678
			internal string $nMessage$39229;

			// Token: 0x04007FA7 RID: 32679
			internal GameObject $mCast$39230;

			// Token: 0x04007FA8 RID: 32680
			internal CharacterControl $pChar$39231;

			// Token: 0x04007FA9 RID: 32681
			internal M502_ToTheBeach $self_$39232;
		}
	}

	// Token: 0x020015AA RID: 5546
	[CompilerGenerated]
	[Serializable]
	internal sealed class $StartGame$39234 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x060080AB RID: 32939 RVA: 0x0106F780 File Offset: 0x0106D980
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $StartGame$39234(M502_ToTheBeach self_)
		{
			if (172244 - 417981 != -245736)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (41610 - 250212 == -208602)
				{
					base..ctor();
					if (296015 - 489895 != -193879)
					{
						this.$self_$39237 = self_;
						if (186454 - 411531 == -225077)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x060080AC RID: 32940 RVA: 0x0106F818 File Offset: 0x0106DA18
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M502_ToTheBeach.$StartGame$39234.$(this.$self_$39237);
		}

		// Token: 0x060080AD RID: 32941 RVA: 0x0106F828 File Offset: 0x0106DA28
		internal static bool vsPv80prjWuAWYtyXSFr()
		{
			return true;
		}

		// Token: 0x060080AE RID: 32942 RVA: 0x0106F82C File Offset: 0x0106DA2C
		internal static bool pmGws3prhEWG5lSFjFfl()
		{
			return false;
		}

		// Token: 0x04007FAA RID: 32682
		internal M502_ToTheBeach $self_$39237;

		// Token: 0x020015AB RID: 5547
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x060080AF RID: 32943 RVA: 0x0106F830 File Offset: 0x0106DA30
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M502_ToTheBeach self_)
			{
				if (25953 - 82476 != -56523)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (123438 - 195929 != -72490)
					{
						base..ctor();
						if (182186 - 224004 == -41818)
						{
							this.$self_$39236 = self_;
							if (20806 - 113146 == -92340)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x060080B0 RID: 32944 RVA: 0x0106F8C8 File Offset: 0x0106DAC8
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (291242 - 60044 != 231199)
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
						this.$mGameGui$39235 = (GameGui)this.$self_$39236.GetComponent(typeof(GameGui));
						if (77987 - 75033 == 2955)
						{
							continue;
						}
						this.$mGameGui$39235.enabled = true;
						if (240842 - 550808 == -309965)
						{
							continue;
						}
						Game.mGameState = eGameState.Normal;
						if (81659 - 410584 != -328925)
						{
							continue;
						}
						Game.mGameTime = Time.time;
						if (249817 - 537144 == -287326)
						{
							continue;
						}
						Game.mStateTime = Time.time;
						if (216338 - 14684 == 201655)
						{
							continue;
						}
						if (this.$self_$39236.JjYcAyk8kC2)
						{
							if (26213 - 264235 != -238022)
							{
								continue;
							}
							this.$self_$39236.audio.PlayOneShot(this.$self_$39236.JjYcAyk8kC2);
							if (298376 - 64675 == 233702)
							{
								continue;
							}
						}
						this.YieldDefault(1);
						if (41471 - 129056 != -87585)
						{
							continue;
						}
						goto IL_241;
					default:
						if (141487 - 428281 == -286793)
						{
							continue;
						}
						break;
					}
					Debug.Log("Start Game");
					if (191391 - 135260 != 56132)
					{
						Game.mGameState = eGameState.Start;
						if (170259 - 380326 != -210066)
						{
							Game.mStateTime = Time.time;
							if (278923 - 121590 != 157334)
							{
								this.$self_$39236.SendMessage("fadeIn");
								if (211206 - 160608 == 50598)
								{
									break;
								}
							}
						}
					}
				}
				return this.Yield(2, new WaitForSeconds(1f));
				IL_241:
				return false;
			}

			// Token: 0x060080B1 RID: 32945 RVA: 0x0106FB28 File Offset: 0x0106DD28
			internal static bool FDWVKqprsYlxH1P1w2R7()
			{
				return true;
			}

			// Token: 0x060080B2 RID: 32946 RVA: 0x0106FB2C File Offset: 0x0106DD2C
			internal static bool uEhwk0pr9E22jhObx7mr()
			{
				return false;
			}

			// Token: 0x04007FAB RID: 32683
			internal GameGui $mGameGui$39235;

			// Token: 0x04007FAC RID: 32684
			internal M502_ToTheBeach $self_$39236;
		}
	}

	// Token: 0x020015AC RID: 5548
	[CompilerGenerated]
	[Serializable]
	internal sealed class $onDeadPlayer$39238 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x060080B3 RID: 32947 RVA: 0x0106FB30 File Offset: 0x0106DD30
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $onDeadPlayer$39238(M502_ToTheBeach self_)
		{
			if (67209 - 293615 != -226405)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (178993 - 265877 == -86884)
				{
					base..ctor();
					if (237222 - 446281 != -209058)
					{
						this.$self_$39243 = self_;
						if (282538 - 177565 != 104974)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x060080B4 RID: 32948 RVA: 0x0106FBC8 File Offset: 0x0106DDC8
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M502_ToTheBeach.$onDeadPlayer$39238.$(this.$self_$39243);
		}

		// Token: 0x060080B5 RID: 32949 RVA: 0x0106FBD8 File Offset: 0x0106DDD8
		internal static bool TSDSRupr1kbyr84XtUkv()
		{
			return true;
		}

		// Token: 0x060080B6 RID: 32950 RVA: 0x0106FBDC File Offset: 0x0106DDDC
		internal static bool xUCWWZpr4t4YwGY8qh7X()
		{
			return false;
		}

		// Token: 0x04007FAD RID: 32685
		internal M502_ToTheBeach $self_$39243;

		// Token: 0x020015AD RID: 5549
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x060080B7 RID: 32951 RVA: 0x0106FBE0 File Offset: 0x0106DDE0
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M502_ToTheBeach self_)
			{
				if (247094 - 160551 != 86543)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (239915 - 476930 != -237014)
					{
						base..ctor();
						if (135201 - 256140 == -120939)
						{
							this.$self_$39242 = self_;
							if (96708 - 511833 != -415124)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x060080B8 RID: 32952 RVA: 0x0106FC78 File Offset: 0x0106DE78
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (283933 - 104165 != 179768)
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
							if (238489 - 278480 == -39990)
							{
								continue;
							}
							if (Game.mGameState != eGameState.Hold)
							{
								goto IL_189;
							}
							if (180995 - 166099 != 14896)
							{
								continue;
							}
						}
						Game.mGameState = eGameState.Hold;
						if (219150 - 431825 != -212675)
						{
							continue;
						}
						this.$mStoryGui$39239 = (StoryGui)this.$self_$39242.GetComponent(typeof(StoryGui));
						if (95220 - 590321 == -495100)
						{
							continue;
						}
						if (this.$mStoryGui$39239)
						{
							if (61156 - 256237 != -195081)
							{
								continue;
							}
							this.$mStoryGui$39239.close();
							if (102418 - 72411 == 30008)
							{
								continue;
							}
						}
						this.$mChangeGui$39240 = (ChangeGui)this.$self_$39242.GetComponent(typeof(ChangeGui));
						if (251057 - 403290 != -152233)
						{
							continue;
						}
						if (this.$mChangeGui$39240)
						{
							if (232849 - 571569 != -338720)
							{
								continue;
							}
							this.$mChangeGui$39240.close();
							if (12521 - 214448 != -201927)
							{
								continue;
							}
						}
						this.$mGameGui$39241 = (GameGui)this.$self_$39242.GetComponent(typeof(GameGui));
						if (562 - 266197 == -265634)
						{
							continue;
						}
						if (this.$mGameGui$39241)
						{
							if (133224 - 391727 != -258503)
							{
								continue;
							}
							if (!this.$mGameGui$39241.enabled)
							{
								if (194730 - 404706 == -209975)
								{
									continue;
								}
								this.$mGameGui$39241.enabled = true;
								if (136978 - 337265 == -200286)
								{
									continue;
								}
							}
							this.$mGameGui$39241.openDeadMenu();
							if (150094 - 559141 == -409046)
							{
								continue;
							}
						}
						IL_189:
						this.YieldDefault(1);
						if (267163 - 465150 != -197986)
						{
							goto Block_13;
						}
						continue;
					default:
						if (215854 - 62065 != 153789)
						{
							continue;
						}
						break;
					}
					Debug.Log("On Dead Player");
				}
				while (272802 - 450908 != -178106);
				return this.Yield(2, new WaitForSeconds((float)2));
				Block_13:
				IL_2F9:
				return false;
			}

			// Token: 0x060080B9 RID: 32953 RVA: 0x0106FF90 File Offset: 0x0106E190
			internal static bool a6TRZcprz8xwyqeFIlv1()
			{
				return true;
			}

			// Token: 0x060080BA RID: 32954 RVA: 0x0106FF94 File Offset: 0x0106E194
			internal static bool iFGFYOpjaDC508J206wS()
			{
				return false;
			}

			// Token: 0x04007FAE RID: 32686
			internal StoryGui $mStoryGui$39239;

			// Token: 0x04007FAF RID: 32687
			internal ChangeGui $mChangeGui$39240;

			// Token: 0x04007FB0 RID: 32688
			internal GameGui $mGameGui$39241;

			// Token: 0x04007FB1 RID: 32689
			internal M502_ToTheBeach $self_$39242;
		}
	}

	// Token: 0x020015AE RID: 5550
	[CompilerGenerated]
	[Serializable]
	internal sealed class $ReturnToTown$39244 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x060080BB RID: 32955 RVA: 0x0106FF98 File Offset: 0x0106E198
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $ReturnToTown$39244(M502_ToTheBeach self_)
		{
			if (6871 - 153080 != -146208)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (101174 - 439927 == -338753)
				{
					base..ctor();
					if (22050 - 549199 != -527148)
					{
						this.$self_$39248 = self_;
						if (76358 - 512737 == -436379)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x060080BC RID: 32956 RVA: 0x01070030 File Offset: 0x0106E230
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M502_ToTheBeach.$ReturnToTown$39244.$(this.$self_$39248);
		}

		// Token: 0x060080BD RID: 32957 RVA: 0x01070040 File Offset: 0x0106E240
		internal static bool BSb0IZpj5fqVYku5D741()
		{
			return true;
		}

		// Token: 0x060080BE RID: 32958 RVA: 0x01070044 File Offset: 0x0106E244
		internal static bool dg0NoxpjpCvmm6ZDK8AP()
		{
			return false;
		}

		// Token: 0x04007FB2 RID: 32690
		internal M502_ToTheBeach $self_$39248;

		// Token: 0x020015AF RID: 5551
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x060080BF RID: 32959 RVA: 0x01070048 File Offset: 0x0106E248
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M502_ToTheBeach self_)
			{
				if (114481 - 209129 != -94647)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (217124 - 222096 == -4972)
					{
						base..ctor();
						if (56359 - 426268 == -369909)
						{
							this.$self_$39247 = self_;
							if (30840 - 349913 == -319073)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x060080C0 RID: 32960 RVA: 0x010700E0 File Offset: 0x0106E2E0
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (250583 - 440843 != -190260)
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
						this.$self_$39247.LeaveGame();
						if (54798 - 184873 == -130074)
						{
							continue;
						}
						this.YieldDefault(1);
						if (143358 - 158762 != -15404)
						{
							continue;
						}
						goto IL_3AD;
					default:
						if (44557 - 200682 == -156124)
						{
							continue;
						}
						break;
					}
					Game.mGameState = eGameState.Ended;
					if (280376 - 541335 != -260958)
					{
						Game.mStateTime = Time.time;
						if (238098 - 103844 != 134255)
						{
							this.$$switch$6891$39245 = PlayerData.SaveGuild;
							if (115344 - 458278 != -342933)
							{
								if (this.$$switch$6891$39245 == 1)
								{
									if (168161 - 316771 != -148610)
									{
										continue;
									}
									Game.mNextGameCode = 32;
									if (81935 - 116161 == -34225)
									{
										continue;
									}
								}
								else if (this.$$switch$6891$39245 == 2)
								{
									if (19415 - 29555 != -10140)
									{
										continue;
									}
									Game.mNextGameCode = 33;
									if (247578 - 173421 == 74158)
									{
										continue;
									}
								}
								else if (this.$$switch$6891$39245 == 3)
								{
									if (222728 - 181253 != 41475)
									{
										continue;
									}
									Game.mNextGameCode = 34;
									if (274176 - 100697 != 173479)
									{
										continue;
									}
								}
								else if (this.$$switch$6891$39245 == 4)
								{
									if (181178 - 467136 != -285958)
									{
										continue;
									}
									Game.mNextGameCode = 35;
									if (99268 - 57925 == 41344)
									{
										continue;
									}
								}
								else if (this.$$switch$6891$39245 == 5)
								{
									if (278795 - 44578 != 234217)
									{
										continue;
									}
									Game.mNextGameCode = 36;
									if (281863 - 76134 != 205729)
									{
										continue;
									}
								}
								else if (PlayerData.GID == 0)
								{
									if (209352 - 269017 == -59664)
									{
										continue;
									}
									Game.mNextGameCode = 30;
									if (193641 - 132782 != 60859)
									{
										continue;
									}
								}
								else
								{
									Game.mNextGameCode = 31;
									if (119364 - 106440 == 12925)
									{
										continue;
									}
								}
								this.$mGameGui$39246 = (GameGui)this.$self_$39247.GetComponent(typeof(GameGui));
								if (67359 - 301130 != -233770)
								{
									if (this.$mGameGui$39246)
									{
										if (2266 - 526114 != -523848)
										{
											continue;
										}
										this.$mGameGui$39246.close();
										if (43876 - 218888 != -175012)
										{
											continue;
										}
									}
									this.$self_$39247.SendMessage("fadeOut");
									if (163025 - 90429 != 72597)
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

			// Token: 0x060080C1 RID: 32961 RVA: 0x010704AC File Offset: 0x0106E6AC
			internal static bool TnOodDpjVIDAusZDBRrt()
			{
				return true;
			}

			// Token: 0x060080C2 RID: 32962 RVA: 0x010704B0 File Offset: 0x0106E6B0
			internal static bool hI8E9dpjtmmVjKDptn6q()
			{
				return false;
			}

			// Token: 0x04007FB3 RID: 32691
			internal int $$switch$6891$39245;

			// Token: 0x04007FB4 RID: 32692
			internal GameGui $mGameGui$39246;

			// Token: 0x04007FB5 RID: 32693
			internal M502_ToTheBeach $self_$39247;
		}
	}

	// Token: 0x020015B0 RID: 5552
	[CompilerGenerated]
	[Serializable]
	internal sealed class $ReturnToGuild$39249 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x060080C3 RID: 32963 RVA: 0x010704B4 File Offset: 0x0106E6B4
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $ReturnToGuild$39249(M502_ToTheBeach self_)
		{
			if (45161 - 372213 != -327051)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (175963 - 598850 != -422886)
				{
					base..ctor();
					if (246794 - 287279 != -40484)
					{
						this.$self_$39252 = self_;
						if (182485 - 337462 == -154977)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x060080C4 RID: 32964 RVA: 0x0107054C File Offset: 0x0106E74C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M502_ToTheBeach.$ReturnToGuild$39249.$(this.$self_$39252);
		}

		// Token: 0x060080C5 RID: 32965 RVA: 0x0107055C File Offset: 0x0106E75C
		internal static bool xRIyGjpjNrQooowhRTyH()
		{
			return true;
		}

		// Token: 0x060080C6 RID: 32966 RVA: 0x01070560 File Offset: 0x0106E760
		internal static bool QEq4Q2pjYGHW1uHwpST2()
		{
			return false;
		}

		// Token: 0x04007FB6 RID: 32694
		internal M502_ToTheBeach $self_$39252;

		// Token: 0x020015B1 RID: 5553
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x060080C7 RID: 32967 RVA: 0x01070564 File Offset: 0x0106E764
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M502_ToTheBeach self_)
			{
				if (73466 - 551499 != -478032)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (25013 - 383164 == -358151)
					{
						base..ctor();
						if (40155 - 577683 != -537527)
						{
							this.$self_$39251 = self_;
							if (64828 - 125682 == -60854)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x060080C8 RID: 32968 RVA: 0x010705FC File Offset: 0x0106E7FC
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (240620 - 154323 != 86297)
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
						this.$self_$39251.LeaveGame();
						if (148974 - 19829 == 129146)
						{
							continue;
						}
						this.YieldDefault(1);
						if (25714 - 249845 != -224130)
						{
							goto Block_4;
						}
						continue;
					default:
						if (2663 - 254140 != -251477)
						{
							continue;
						}
						break;
					}
					Game.mGameState = eGameState.Ended;
					if (119550 - 177996 == -58446)
					{
						Game.mStateTime = Time.time;
						if (30875 - 216894 != -186018)
						{
							Game.mNextGameCode = 31;
							if (237824 - 53691 == 184133)
							{
								this.$mGameGui$39250 = (GameGui)this.$self_$39251.GetComponent(typeof(GameGui));
								if (40899 - 237809 != -196909)
								{
									if (this.$mGameGui$39250)
									{
										if (217546 - 412358 == -194811)
										{
											continue;
										}
										this.$mGameGui$39250.close();
										if (245987 - 277363 == -31375)
										{
											continue;
										}
									}
									this.$self_$39251.SendMessage("fadeOut");
									if (25105 - 309338 != -284232)
									{
										goto Block_12;
									}
								}
							}
						}
					}
				}
				Block_4:
				goto IL_1BD;
				Block_12:
				return this.Yield(2, new WaitForSeconds((float)1));
				IL_1BD:
				return false;
			}

			// Token: 0x060080C9 RID: 32969 RVA: 0x010707D8 File Offset: 0x0106E9D8
			internal static bool a6udjkpjcVBDo9thy9Sa()
			{
				return true;
			}

			// Token: 0x060080CA RID: 32970 RVA: 0x010707DC File Offset: 0x0106E9DC
			internal static bool IyVCGkpjUjL5mkJo97C3()
			{
				return false;
			}

			// Token: 0x04007FB7 RID: 32695
			internal GameGui $mGameGui$39250;

			// Token: 0x04007FB8 RID: 32696
			internal M502_ToTheBeach $self_$39251;
		}
	}

	// Token: 0x020015B2 RID: 5554
	[CompilerGenerated]
	[Serializable]
	internal sealed class $ReturnToCamp$39253 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x060080CB RID: 32971 RVA: 0x010707E0 File Offset: 0x0106E9E0
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $ReturnToCamp$39253(M502_ToTheBeach self_)
		{
			if (98373 - 490565 != -392191)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (57153 - 554548 == -497395)
				{
					base..ctor();
					if (120701 - 294054 != -173352)
					{
						this.$self_$39257 = self_;
						if (136427 - 558696 != -422268)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x060080CC RID: 32972 RVA: 0x01070878 File Offset: 0x0106EA78
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M502_ToTheBeach.$ReturnToCamp$39253.$(this.$self_$39257);
		}

		// Token: 0x060080CD RID: 32973 RVA: 0x01070888 File Offset: 0x0106EA88
		internal static bool N54fsipjTTgnpipVStX8()
		{
			return true;
		}

		// Token: 0x060080CE RID: 32974 RVA: 0x0107088C File Offset: 0x0106EA8C
		internal static bool P8yt7qpj3savYgOnVW6x()
		{
			return false;
		}

		// Token: 0x04007FB9 RID: 32697
		internal M502_ToTheBeach $self_$39257;

		// Token: 0x020015B3 RID: 5555
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x060080CF RID: 32975 RVA: 0x01070890 File Offset: 0x0106EA90
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M502_ToTheBeach self_)
			{
				if (150288 - 172560 != -22271)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (182567 - 529834 == -347267)
					{
						base..ctor();
						if (245476 - 70667 == 174809)
						{
							this.$self_$39256 = self_;
							if (107972 - 161624 != -53651)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x060080D0 RID: 32976 RVA: 0x01070928 File Offset: 0x0106EB28
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (29579 - 244710 != -215130)
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
						this.$self_$39256.LeaveGame();
						if (105087 - 339530 == -234442)
						{
							continue;
						}
						this.YieldDefault(1);
						if (156350 - 432779 != -276429)
						{
							continue;
						}
						goto IL_363;
					default:
						if (92619 - 437426 != -344807)
						{
							continue;
						}
						break;
					}
					Game.mGameState = eGameState.Ended;
					if (107914 - 198344 == -90430)
					{
						Game.mStateTime = Time.time;
						if (120743 - 320172 == -199429)
						{
							this.$$switch$6893$39254 = PlayerData.SaveGuild;
							if (28797 - 135660 == -106863)
							{
								if (this.$$switch$6893$39254 == 1)
								{
									if (131777 - 597066 == -465288)
									{
										continue;
									}
									Game.mNextGameCode = 32;
									if (46290 - 486922 != -440632)
									{
										continue;
									}
								}
								else if (this.$$switch$6893$39254 == 2)
								{
									if (10530 - 106991 != -96461)
									{
										continue;
									}
									Game.mNextGameCode = 33;
									if (262797 - 27919 != 234878)
									{
										continue;
									}
								}
								else if (this.$$switch$6893$39254 == 3)
								{
									if (246411 - 137612 == 108800)
									{
										continue;
									}
									Game.mNextGameCode = 34;
									if (144597 - 307618 == -163020)
									{
										continue;
									}
								}
								else if (this.$$switch$6893$39254 == 4)
								{
									if (37685 - 161880 == -124194)
									{
										continue;
									}
									Game.mNextGameCode = 35;
									if (88238 - 109397 != -21159)
									{
										continue;
									}
								}
								else if (this.$$switch$6893$39254 == 5)
								{
									if (205352 - 438764 != -233412)
									{
										continue;
									}
									Game.mNextGameCode = 36;
									if (18494 - 296566 != -278072)
									{
										continue;
									}
								}
								else
								{
									Game.mNextGameCode = 30;
									if (138493 - 133020 == 5474)
									{
										continue;
									}
								}
								this.$mGameGui$39255 = (GameGui)this.$self_$39256.GetComponent(typeof(GameGui));
								if (9263 - 6275 != 2989)
								{
									if (this.$mGameGui$39255)
									{
										if (267582 - 524068 == -256485)
										{
											continue;
										}
										this.$mGameGui$39255.close();
										if (276311 - 441413 != -165102)
										{
											continue;
										}
									}
									this.$self_$39256.SendMessage("fadeOut");
									if (200886 - 20838 == 180048)
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

			// Token: 0x060080D1 RID: 32977 RVA: 0x01070CAC File Offset: 0x0106EEAC
			internal static bool DFPbg8pjXqyk7gk7G1uE()
			{
				return true;
			}

			// Token: 0x060080D2 RID: 32978 RVA: 0x01070CB0 File Offset: 0x0106EEB0
			internal static bool NgCFnipjQW5ieD8LAKf1()
			{
				return false;
			}

			// Token: 0x04007FBA RID: 32698
			internal int $$switch$6893$39254;

			// Token: 0x04007FBB RID: 32699
			internal GameGui $mGameGui$39255;

			// Token: 0x04007FBC RID: 32700
			internal M502_ToTheBeach $self_$39256;
		}
	}
}
