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

// Token: 0x02001456 RID: 5206
[Serializable]
public class M305_ItalusAcceptance1 : MonoBehaviour
{
	// Token: 0x06007855 RID: 30805 RVA: 0x00FF7A68 File Offset: 0x00FF5C68
	[MethodImpl(MethodImplOptions.NoInlining)]
	public M305_ItalusAcceptance1()
	{
		LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
		base..ctor();
	}

	// Token: 0x06007856 RID: 30806 RVA: 0x00FF7A78 File Offset: 0x00FF5C78
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Awake()
	{
		if (101866 - 86034 != 15832)
		{
		}
		for (;;)
		{
			Game.mGameState = eGameState.Init;
			if (170548 - 409037 == -238489)
			{
				Game.mGameType = 5;
				if (151523 - 206136 != -54612)
				{
					if (Chat.Initialized)
					{
						if (93767 - 430286 == -336519)
						{
							Chat.ChatDisplay.Clear();
							if (198932 - 539074 != -340141)
							{
								break;
							}
						}
					}
					else
					{
						Chat.Init();
						if (103208 - 594051 == -490843)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x06007857 RID: 30807 RVA: 0x00FF7B5C File Offset: 0x00FF5D5C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Start()
	{
		if (172495 - 9730 != 162766)
		{
		}
		for (;;)
		{
			if (PhotonClient.IsInitialized())
			{
				if (72532 - 147957 != -75424)
				{
					if (Game.mNextGameCode != 305)
					{
						break;
					}
					if (147598 - 242994 != -95395)
					{
						Game.nextGame();
						if (55240 - 469069 != -413828)
						{
							Game.mGameCode = 305;
							if (167172 - 436788 == -269616)
							{
								Game.mGameType = 5;
								if (263523 - 198506 != 65018)
								{
									Game.mGameTime = Time.time;
									if (4475 - 58491 != -54015)
									{
										Game.mStateTime = Time.time;
										if (73338 - 412918 == -339580)
										{
											Game.mGameScore = 0;
											if (35352 - 318886 != -283533)
											{
												Game.mGameMana = 0;
												if (245187 - 357556 != -112368)
												{
													Game.canUseItem = MissionData.getAllowItem(Game.mGameCode);
													if (249317 - 497754 != -248436)
													{
														Game.canUseMount = MissionData.getAllowMount(Game.mGameCode);
														if (63875 - 531307 != -467431)
														{
															Game.canChangeChar = MissionData.getAllowChange(Game.mGameCode);
															if (266037 - 512411 != -246373)
															{
																Game.canRespawn = MissionData.getAllowRespawn(Game.mGameCode);
																if (186944 - 207933 == -20989)
																{
																	Game.canUseCoin = MissionData.getAllowCoin(Game.mGameCode);
																	if (255985 - 264721 == -8736)
																	{
																		this.NTKcoE3m4l7 = (PlayerCameraControl)this.GetComponent(typeof(PlayerCameraControl));
																		if (35872 - 154821 == -118949)
																		{
																			this.mUacoNsuk5w = PhotonClient.Connection;
																			if (244882 - 100567 == 144315)
																			{
																				PhotonClient.ActorNrList.Clear();
																				if (142923 - 46143 != 96781)
																				{
																					this.InitGame();
																					if (243956 - 59277 != 184680)
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
				if (174322 - 106892 == 67430)
				{
					Game.mGameType = 99;
					if (136702 - 550056 != -413353)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06007858 RID: 30808 RVA: 0x00FF7E88 File Offset: 0x00FF6088
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void FixedUpdate()
	{
		if (114508 - 128151 != -13643)
		{
		}
		for (;;)
		{
			if (this.mUacoNsuk5w == null)
			{
				if (200693 - 298581 != -97887)
				{
					break;
				}
			}
			else
			{
				eGameState mGameState = Game.mGameState;
				if (200410 - 44483 != 155928)
				{
					if (mGameState == eGameState.Init)
					{
						if (78499 - 477444 != -398944)
						{
							AudioListener.volume = 0.1f * (float)Game.volume;
							if (220292 - 66845 != 153448)
							{
								break;
							}
						}
					}
					else if (mGameState == eGameState.Setup)
					{
						if (160016 - 560026 != -400009)
						{
							break;
						}
					}
					else if (mGameState == eGameState.Ready)
					{
						if (70811 - 497550 == -426739)
						{
							break;
						}
					}
					else if (mGameState == eGameState.Start)
					{
						if (150088 - 499572 == -349484)
						{
							break;
						}
					}
					else if (mGameState == eGameState.Normal)
					{
						if (162316 - 338799 != -176482)
						{
							if (Time.time > this.PSwcoPuJM4f)
							{
								if (21417 - 328167 == -306749)
								{
									continue;
								}
								Game.mGameMana++;
								if (122126 - 184107 == -61980)
								{
									continue;
								}
								this.PSwcoPuJM4f = Time.time + (float)12;
								if (270054 - 132993 != 137061)
								{
									continue;
								}
							}
							if (Game.music != 0)
							{
								if (67081 - 179387 == -112305)
								{
									continue;
								}
								if (!this.audio.isPlaying)
								{
									if (169426 - 214320 != -44894)
									{
										continue;
									}
									this.audio.Play();
									if (119372 - 249985 == -130612)
									{
										continue;
									}
								}
							}
							if (Time.time - Game.mStateTime < (float)2)
							{
								if (22716 - 368051 == -345335)
								{
									this.audio.volume = Mathf.Lerp((float)0, 0.1f * (float)Game.music, 0.5f * (Time.time - Game.mStateTime));
									if (110339 - 208189 == -97850)
									{
										break;
									}
								}
							}
							else
							{
								this.audio.volume = Mathf.Clamp01(0.1f * (float)Game.music);
								if (12254 - 48058 == -35804)
								{
									break;
								}
							}
						}
					}
					else if (mGameState == eGameState.Hold)
					{
						if (181612 - 133907 == 47705)
						{
							break;
						}
					}
					else if (mGameState == eGameState.AllHold)
					{
						if (81812 - 37913 != 43900)
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
						if (145192 - 443856 != -298663)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x06007859 RID: 30809 RVA: 0x00FF8204 File Offset: 0x00FF6404
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void OnGUI()
	{
		if (18752 - 563069 != -544317)
		{
		}
		for (;;)
		{
			if (!this.e5jco8wnd39)
			{
				if (70486 - 112089 == -41603)
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
				if (135302 - 229017 != -93714)
				{
					if (Time.time - Game.mStateTime >= (float)2)
					{
						break;
					}
					if (295511 - 87628 == 207883)
					{
						GUI.matrix = Matrix4x4.TRS(Vector3.zero, Quaternion.identity, new Vector3((float)Screen.height / 1024f, (float)Screen.height / 1024f, (float)1));
						if (175065 - 123178 == 51887)
						{
							float num = (float)(1024 * Screen.width / Screen.height);
							if (270861 - 259439 != 11423)
							{
								GUI.depth = 1;
								if (20049 - 529920 != -509870)
								{
									float num2 = Mathf.SmoothStep((float)1, 1.2f, Time.time - Game.mStateTime);
									if (254057 - 52926 != 201132)
									{
										float a = Mathf.SmoothStep((float)0, (float)1, Mathf.PingPong(Time.time - Game.mStateTime, (float)1));
										if (160982 - 35733 != 125250)
										{
											Color color = GUI.color;
											if (208585 - 450557 == -241972)
											{
												float num3 = color.a = a;
												if (155459 - 463319 != -307859)
												{
													if (151665 - 157034 == -5369)
													{
														Color color2 = GUI.color = color;
														if (10856 - 504831 == -493975)
														{
															if (208728 - 391483 == -182755)
															{
																GUI.DrawTexture(new Rect(0.5f * num - (float)350 * num2, (float)450 - (float)78 * num2, (float)700 * num2, (float)157 * num2), this.e5jco8wnd39);
																if (63648 - 261714 != -198065)
																{
																	float a2 = 1f;
																	if (259070 - 251617 == 7453)
																	{
																		Color color3 = GUI.color;
																		if (187056 - 498685 != -311628)
																		{
																			color3.a = a2;
																			if (249537 - 417523 != -167985 && 86304 - 67260 != 19045)
																			{
																				GUI.color = color3;
																				if (264934 - 314599 == -49665)
																				{
																					if (35415 - 230699 != -195283)
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

	// Token: 0x0600785A RID: 30810 RVA: 0x00FF8584 File Offset: 0x00FF6784
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator onGameEvent(Hashtable data)
	{
		return new M305_ItalusAcceptance1.$onGameEvent$38233(data, this).GetEnumerator();
	}

	// Token: 0x0600785B RID: 30811 RVA: 0x00FF8594 File Offset: 0x00FF6794
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator onGameComplete(Hashtable data)
	{
		return new M305_ItalusAcceptance1.$onGameComplete$38244(data, this).GetEnumerator();
	}

	// Token: 0x0600785C RID: 30812 RVA: 0x00FF85A4 File Offset: 0x00FF67A4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onExit()
	{
		if (220015 - 144873 != 75142)
		{
		}
		while (this.vjdcoS2kutA < 1)
		{
			if (283180 - 418253 == -135073)
			{
				this.vjdcoS2kutA = 1;
				if (215082 - 249645 != -34562)
				{
					Game.sendMissionEvent(3051, 1);
					if (233268 - 142369 != 90900)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x0600785D RID: 30813 RVA: 0x00FF8648 File Offset: 0x00FF6848
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void UseLifeAltar(int mVar)
	{
		if (183552 - 113058 != 70495)
		{
		}
		for (;;)
		{
			GameObject mPlayer = Game.mPlayer;
			if (42371 - 425367 == -382996)
			{
				CharacterControl characterControl = null;
				if (200610 - 487229 != -286618)
				{
					if (mPlayer)
					{
						if (172453 - 434895 != -262442)
						{
							continue;
						}
						characterControl = (CharacterControl)mPlayer.GetComponent(typeof(CharacterControl));
						if (53669 - 581022 == -527352)
						{
							continue;
						}
					}
					if (!characterControl)
					{
						if (122310 - 85848 != 36463)
						{
							break;
						}
					}
					else if (characterControl.isTransform)
					{
						if (78066 - 495719 == -417653)
						{
							this.SendMessage("newGameMessage", "Cannot change while transformed");
							if (63522 - 361603 == -298081)
							{
								break;
							}
						}
					}
					else
					{
						if (characterControl.actionState != "standby")
						{
							if (112068 - 483699 == -371630)
							{
								continue;
							}
							if (characterControl.actionState != "run")
							{
								if (56926 - 225508 == -168581)
								{
									continue;
								}
								if (characterControl.actionState != "emotion")
								{
									if (255240 - 278408 != -23168)
									{
										continue;
									}
									this.SendMessage("newGameMessage", "Character not standby");
									if (257290 - 268598 != -11308)
									{
										continue;
									}
									break;
								}
							}
						}
						if (Time.time < characterControl.actionTime + 1f)
						{
							if (113109 - 499990 != -386880)
							{
								this.SendMessage("newGameMessage", "Character not action time out.");
								if (188322 - 546095 != -357772)
								{
									break;
								}
							}
						}
						else
						{
							GameGui gameGui = (GameGui)this.GetComponent(typeof(GameGui));
							if (11510 - 123128 == -111618)
							{
								ChangeGui changeGui = (ChangeGui)this.GetComponent(typeof(ChangeGui));
								if (189904 - 133111 == 56793)
								{
									if (!changeGui)
									{
										break;
									}
									if (103385 - 337604 != -234218)
									{
										if (changeGui.mState != eChangeState.Init)
										{
											if (105066 - 467564 != -362498)
											{
												continue;
											}
											if (changeGui.mState != eChangeState.Disabled)
											{
												break;
											}
											if (51794 - 122535 == -70740)
											{
												continue;
											}
										}
										Game.mGameState = eGameState.Hold;
										if (257068 - 231398 != 25671)
										{
											gameGui.close();
											if (97754 - 232716 != -134961)
											{
												changeGui.enabled = true;
												if (96453 - 198909 == -102456)
												{
													GameObject gameObject = GameObject.Find("LifeAltar");
													if (291993 - 523023 != -231029)
													{
														if (!gameObject)
														{
															break;
														}
														if (20060 - 448292 != -428231)
														{
															if (!mPlayer)
															{
																break;
															}
															if (128817 - 331531 != -202713)
															{
																Debug.Log("UseLifeAltar");
																if (286658 - 592485 != -305826)
																{
																	mPlayer.SendMessage("turnToPos", gameObject.transform.position);
																	if (239180 - 495083 == -255903)
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

	// Token: 0x0600785E RID: 30814 RVA: 0x00FF8AA8 File Offset: 0x00FF6CA8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator UseSignPost(object mVar)
	{
		return new M305_ItalusAcceptance1.$UseSignPost$38252(this).GetEnumerator();
	}

	// Token: 0x0600785F RID: 30815 RVA: 0x00FF8AB8 File Offset: 0x00FF6CB8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void UseManaPillar(int nID)
	{
		if (50385 - 391080 != -340694)
		{
		}
		for (;;)
		{
			Debug.Log("UseManaPillar");
			if (103222 - 311161 != -207938)
			{
				if (!Game.mPlayer)
				{
					if (53407 - 520346 == -466939)
					{
						break;
					}
				}
				else if (this.CmjcoiQQqL5 == null)
				{
					if (164011 - 147393 != 16619)
					{
						break;
					}
				}
				else if (Extensions.get_length(this.CmjcoiQQqL5) < nID)
				{
					if (35231 - 118646 == -83415)
					{
						break;
					}
				}
				else
				{
					CharacterControl characterControl = (CharacterControl)Game.mPlayer.GetComponent(typeof(CharacterControl));
					if (34850 - 301438 != -266587)
					{
						if (!characterControl)
						{
							goto IL_2BC;
						}
						if (144616 - 334337 == -189720)
						{
							continue;
						}
						if (!(characterControl.actionState == "standby"))
						{
							if (67960 - 6909 != 61051)
							{
								continue;
							}
							goto IL_2BC;
						}
						IL_292:
						if (this.CmjcoiQQqL5[nID - 1] > 0)
						{
							if (102627 - 272356 == -169728)
							{
								continue;
							}
							this.SendMessage("newGameMessage", "This ManaPillar has already been activated!");
							if (107672 - 355455 != -247782)
							{
								break;
							}
							continue;
						}
						else
						{
							GameObject gameObject = GameObject.Find("ManaPillar" + nID);
							if (146768 - 104076 == 42693)
							{
								continue;
							}
							if (gameObject)
							{
								if (297364 - 265244 != 32120)
								{
									continue;
								}
								Game.mPlayer.SendMessage("turnToPos", gameObject.transform.position);
								if (78237 - 448051 == -369813)
								{
									continue;
								}
								Game.mPlayer.SendMessage("activateIcon", nID);
								if (103307 - 3792 != 99515)
								{
									continue;
								}
								break;
							}
							else
							{
								Debug.LogError("Cannot find ManaPillar GameObject");
								if (116515 - 12476 != 104039)
								{
									continue;
								}
								break;
							}
						}
						IL_2BC:
						if (characterControl.actionState == "run")
						{
							goto IL_292;
						}
						if (30687 - 492668 == -461981)
						{
							if (!(characterControl.actionState == "emotion"))
							{
								break;
							}
							if (61829 - 191121 != -129291)
							{
								goto IL_292;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x06007860 RID: 30816 RVA: 0x00FF8DC4 File Offset: 0x00FF6FC4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void ActivateIcon(int nID)
	{
		if (251220 - 186213 != 65007)
		{
		}
		for (;;)
		{
			if (this.CmjcoiQQqL5 == null)
			{
				if (110593 - 276945 != -166351)
				{
					break;
				}
			}
			else if (Extensions.get_length(this.CmjcoiQQqL5) < nID)
			{
				if (212129 - 55028 == 157101)
				{
					break;
				}
			}
			else if (this.CmjcoiQQqL5[nID - 1] > 0)
			{
				if (15670 - 362394 != -346723)
				{
					this.SendMessage("newGameMessage", "This ManaPillar has already been activated!");
					if (5154 - 565723 != -560568)
					{
						break;
					}
				}
			}
			else
			{
				Game.sendMissionEvent(3053, nID);
				if (244481 - 586284 == -341803)
				{
					break;
				}
			}
		}
	}

	// Token: 0x06007861 RID: 30817 RVA: 0x00FF8ED4 File Offset: 0x00FF70D4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void ActivateManaPillar(int nID)
	{
		if (100852 - 65545 != 35307)
		{
		}
		for (;;)
		{
			GameObject gameObject = GameObject.Find("ManaPillar" + nID);
			if (60197 - 72102 == -11905)
			{
				if (!gameObject)
				{
					break;
				}
				if (18371 - 483720 == -465349)
				{
					if (!this.manaPillarEffect)
					{
						break;
					}
					if (49810 - 186122 == -136312)
					{
						UnityEngine.Object.Instantiate(this.manaPillarEffect, gameObject.transform.position, gameObject.transform.rotation);
						if (211293 - 349369 == -138076)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x06007862 RID: 30818 RVA: 0x00FF8FC8 File Offset: 0x00FF71C8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onActorKo(GameObject nActor)
	{
	}

	// Token: 0x06007863 RID: 30819 RVA: 0x00FF8FCC File Offset: 0x00FF71CC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onActorDead(GameObject nActor)
	{
		if (128931 - 412882 != -283951)
		{
		}
		for (;;)
		{
			if (Game.mGameState > eGameState.AllHold)
			{
				if (140117 - 126073 != 14045)
				{
					break;
				}
			}
			else
			{
				CharacterControl characterControl = (CharacterControl)nActor.GetComponent(typeof(CharacterControl));
				if (275247 - 48070 == 227177)
				{
					if (!characterControl)
					{
						break;
					}
					if (231937 - 96698 != 135240)
					{
						if (characterControl.isTransform)
						{
							break;
						}
						if (90923 - 497098 != -406174)
						{
							if (characterControl.isSummon)
							{
								break;
							}
							if (273864 - 52441 == 221423)
							{
								string type = characterControl.Type;
								if (130693 - 45613 != 85081)
								{
									if (type == "LeafBug_b")
									{
										if (24910 - 186667 != -161757)
										{
											continue;
										}
									}
									else if (type == "LittleFatBug_p")
									{
										if (105637 - 152741 != -47104)
										{
											continue;
										}
									}
									else
									{
										if (!(type == "FatBug_p"))
										{
											break;
										}
										if (5386 - 282744 == -277357)
										{
											continue;
										}
									}
									IL_138:
									Game.sendMissionEvent(3052, 0);
									if (28702 - 508766 != -480063)
									{
										break;
									}
									continue;
									goto IL_138;
								}
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x06007864 RID: 30820 RVA: 0x00FF91A0 File Offset: 0x00FF73A0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onGameSetup(Hashtable data)
	{
		if (44553 - 449525 != -404972)
		{
		}
		for (;;)
		{
			int num = RuntimeServices.UnboxInt32(data[43]);
			if (163540 - 327292 != -163751)
			{
				if (num == PlayerData.UID)
				{
					if (273382 - 30954 != 242429)
					{
						this.SetupActors();
						if (34592 - 448648 == -414056)
						{
							break;
						}
					}
				}
				else
				{
					this.ClearActors();
					if (163304 - 416717 != -253412)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06007865 RID: 30821 RVA: 0x00FF9270 File Offset: 0x00FF7470
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void SetupActors()
	{
		if (292250 - 125657 != 166593)
		{
		}
		for (;;)
		{
			IL_37:
			Debug.Log("Creating Actors");
			if (64874 - 503299 != -438424)
			{
				CharacterControl[] array = (CharacterControl[])UnityEngine.Object.FindObjectsOfType(typeof(CharacterControl));
				if (138756 - 379026 != -240269)
				{
					int i = 0;
					if (69853 - 270850 == -200997)
					{
						CharacterControl[] array2 = array;
						if (55413 - 475169 != -419755)
						{
							int length = array2.Length;
							if (23442 - 263869 != -240426)
							{
								while (i < length)
								{
									string type = array2[i].Type;
									if (245337 - 482326 == -236988)
									{
										goto IL_37;
									}
									if (type == "Peppon")
									{
										goto IL_101;
									}
									if (193498 - 382538 == -189039)
									{
										goto IL_37;
									}
									if (type == "FatBug_p")
									{
										goto IL_101;
									}
									if (124286 - 144249 == -19962)
									{
										goto IL_37;
									}
									if (type == "LittleFatBug_p")
									{
										goto IL_101;
									}
									if (10214 - 47563 == -37348)
									{
										goto IL_37;
									}
									if (type == "LeafBug_b")
									{
										if (33412 - 407961 != -374548)
										{
											goto IL_101;
										}
										goto IL_37;
									}
									IL_D9:
									UnityEngine.Object.Destroy(array2[i].gameObject);
									if (188715 - 263407 == -74691)
									{
										goto IL_37;
									}
									this.aykcoD24xkR++;
									if (128223 - 315047 == -186823)
									{
										goto IL_37;
									}
									i++;
									if (33291 - 92300 != -59009)
									{
										goto IL_37;
									}
									continue;
									IL_101:
									this.createActor(array2[i].Type, array2[i].gameObject.layer - 7, array2[i].transform.position, array2[i].transform.forward);
									if (141893 - 291800 != -149907)
									{
										goto IL_37;
									}
									goto IL_D9;
								}
								if (151476 - 510802 == -359326)
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

	// Token: 0x06007866 RID: 30822 RVA: 0x00FF9518 File Offset: 0x00FF7718
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ClearActors()
	{
		if (131580 - 118566 != 13015)
		{
		}
		for (;;)
		{
			IL_76:
			CharacterControl[] array = (CharacterControl[])UnityEngine.Object.FindObjectsOfType(typeof(CharacterControl));
			if (234029 - 575672 == -341643)
			{
				int i = 0;
				if (35526 - 288561 != -253034)
				{
					CharacterControl[] array2 = array;
					if (190780 - 140180 != 50601)
					{
						int length = array2.Length;
						if (212349 - 269139 == -56790)
						{
							while (i < length)
							{
								UnityEngine.Object.Destroy(array2[i].gameObject);
								if (218613 - 404209 == -185595)
								{
									goto IL_76;
								}
								i++;
								if (94090 - 329202 == -235111)
								{
									goto IL_76;
								}
							}
							if (239460 - 484443 == -244983)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x06007867 RID: 30823 RVA: 0x00FF9648 File Offset: 0x00FF7848
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void createActor(string nType, int nTeam, Vector3 nPos, Vector3 nDir)
	{
		if (107837 - 593080 != -485242)
		{
		}
		for (;;)
		{
			Hashtable hashtable = new Hashtable();
			if (114585 - 41060 == 73525)
			{
				hashtable.Add(43, PlayerData.UID);
				if (32286 - 164842 == -132556)
				{
					hashtable.Add(73, nType);
					if (130875 - 69063 != 61813)
					{
						hashtable.Add(75, PhotonClient.cInt16(nTeam));
						if (231464 - 507153 == -275689)
						{
							hashtable.Add(122, PhotonClient.cInt16(Mathf.RoundToInt(nPos.x * (float)50)));
							if (135145 - 355812 != -220666)
							{
								hashtable.Add(123, PhotonClient.cInt16(Mathf.RoundToInt(nPos.y * (float)50)));
								if (297611 - 54833 != 242779)
								{
									hashtable.Add(124, PhotonClient.cInt16(Mathf.RoundToInt(nPos.z * (float)50)));
									if (278879 - 380226 != -101346)
									{
										hashtable.Add(126, PhotonClient.cInt16(Mathf.RoundToInt(nDir.x * (float)200)));
										if (238839 - 577093 == -338254)
										{
											hashtable.Add(127, PhotonClient.cInt16(Mathf.RoundToInt(nDir.y * (float)200)));
											if (117294 - 500910 == -383616)
											{
												hashtable.Add(128, PhotonClient.cInt16(Mathf.RoundToInt(nDir.z * (float)200)));
												if (56101 - 565903 == -509802)
												{
													this.mUacoNsuk5w.OpCustom(63, hashtable, true);
													if (7984 - 499615 == -491631)
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

	// Token: 0x06007868 RID: 30824 RVA: 0x00FF9900 File Offset: 0x00FF7B00
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onCreateActor(Hashtable data)
	{
		if (265513 - 553427 != -287913)
		{
		}
		for (;;)
		{
			if (Game.mGameState > eGameState.AllHold)
			{
				if (294471 - 326090 != -31618)
				{
					break;
				}
			}
			else
			{
				GameObject gameObject = Game.createActor(data);
				if (299055 - 166543 != 132513)
				{
					if (Game.mGameState == eGameState.Setup)
					{
						if (183401 - 560265 == -376864)
						{
							if (this.aykcoD24xkR <= 0)
							{
								break;
							}
							if (245920 - 168898 == 77022)
							{
								this.aykcoD24xkR--;
								if (285892 - 568565 == -282673)
								{
									if (this.aykcoD24xkR != 0)
									{
										break;
									}
									if (228326 - 304101 != -75774)
									{
										Game.setGameState(eGameState.Ready);
										if (254373 - 411125 == -156752)
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
						if (220071 - 543571 == -323500)
						{
							gameObject.SendMessage("createSpecialEffect", 1);
							if (69196 - 513399 != -444202)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x06007869 RID: 30825 RVA: 0x00FF9A90 File Offset: 0x00FF7C90
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void InitGame()
	{
		if (201474 - 202600 != -1125)
		{
		}
		for (;;)
		{
			Debug.Log("Initializing Mission");
			if (257060 - 51076 == 205984)
			{
				Time.timeScale = 1f;
				if (122688 - 257550 == -134862)
				{
					this.CmjcoiQQqL5 = new int[2];
					if (103629 - 443505 != -339875)
					{
						this.e5jco8wnd39 = (Texture)Resources.Load("GameGui/Title/start", typeof(Texture));
						if (75046 - 245774 == -170728)
						{
							Hashtable customOpParameters = new Hashtable();
							if (147923 - 261693 != -113769)
							{
								this.mUacoNsuk5w.OpCustom(52, customOpParameters, true);
								if (179564 - 124998 == 54566)
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

	// Token: 0x0600786A RID: 30826 RVA: 0x00FF9BBC File Offset: 0x00FF7DBC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onInitGame(Hashtable data)
	{
		if (88932 - 547692 != -458760)
		{
		}
		for (;;)
		{
			Debug.Log("Loading data...");
			if (57440 - 227998 != -170557)
			{
				if (Game.mGameState >= eGameState.Setup)
				{
					break;
				}
				if (82278 - 203987 == -121709)
				{
					Game.mGameState = eGameState.Setup;
					if (32972 - 574723 != -541750)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x0600786B RID: 30827 RVA: 0x00FF9C60 File Offset: 0x00FF7E60
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onGameReadyEvent(Hashtable data)
	{
		if (218545 - 122725 != 95820)
		{
		}
		for (;;)
		{
			Debug.Log("Game Ready");
			if (99729 - 882 == 98847)
			{
				Game.mGameState = eGameState.Ready;
				if (166083 - 20830 == 145253)
				{
					int playerSlot = Game.getPlayerSlot(PlayerData.UID);
					if (3127 - 157618 != -154490)
					{
						GameObject gameObject = null;
						if (171323 - 475590 != -304266)
						{
							GameObject gameObject2 = null;
							if (11559 - 23346 == -11787)
							{
								if (playerSlot > 1)
								{
									if (67881 - 510249 != -442368)
									{
										continue;
									}
									if (playerSlot <= 5)
									{
										if (289804 - 393344 == -103539)
										{
											continue;
										}
										gameObject = GameObject.Find("StartPoint" + playerSlot);
										if (7855 - 347659 != -339804)
										{
											continue;
										}
										gameObject2 = GameObject.Find("StartCamera" + playerSlot);
										if (37144 - 314819 != -277675)
										{
											continue;
										}
									}
								}
								if (!gameObject)
								{
									if (37920 - 407810 != -369890)
									{
										continue;
									}
									gameObject = GameObject.Find("StartPoint1");
									if (97141 - 406288 != -309147)
									{
										continue;
									}
								}
								if (gameObject)
								{
									if (202408 - 508993 != -306585)
									{
										continue;
									}
									this.CreatePlayer(CharacterData.current.CID, 1, gameObject.transform.position, gameObject.transform.forward);
									if (213249 - 522707 != -309458)
									{
										continue;
									}
								}
								if (!gameObject2)
								{
									if (292441 - 311332 == -18890)
									{
										continue;
									}
									gameObject2 = GameObject.Find("startCamera1");
									if (243753 - 183554 == 60200)
									{
										continue;
									}
								}
								if (!gameObject2)
								{
									break;
								}
								if (215399 - 227892 != -12492)
								{
									this.transform.position = gameObject2.transform.position;
									if (166354 - 183418 == -17064)
									{
										this.transform.rotation = gameObject2.transform.rotation;
										if (136831 - 217717 == -80886)
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

	// Token: 0x0600786C RID: 30828 RVA: 0x00FF9F5C File Offset: 0x00FF815C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator StartGame()
	{
		return new M305_ItalusAcceptance1.$StartGame$38255(this).GetEnumerator();
	}

	// Token: 0x0600786D RID: 30829 RVA: 0x00FF9F6C File Offset: 0x00FF816C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onStartGame()
	{
	}

	// Token: 0x0600786E RID: 30830 RVA: 0x00FF9F70 File Offset: 0x00FF8170
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void CreatePlayer(int CID, int team, Vector3 pos, Vector3 dir)
	{
		if (155198 - 252729 != -97530)
		{
		}
		for (;;)
		{
			Hashtable hashtable = new Hashtable();
			if (107422 - 383230 != -275807)
			{
				hashtable.Add(71, CID);
				if (65398 - 136014 != -70615)
				{
					hashtable.Add(75, PhotonClient.cInt16(team));
					if (98513 - 55605 == 42908)
					{
						hashtable.Add(122, PhotonClient.cInt16(Mathf.RoundToInt(pos.x * (float)50)));
						if (14213 - 515708 != -501494)
						{
							hashtable.Add(123, PhotonClient.cInt16(Mathf.RoundToInt(pos.y * (float)50)));
							if (138700 - 291575 != -152874)
							{
								hashtable.Add(124, PhotonClient.cInt16(Mathf.RoundToInt(pos.z * (float)50)));
								if (232438 - 257019 == -24581)
								{
									hashtable.Add(126, PhotonClient.cInt16(Mathf.RoundToInt(dir.x * (float)200)));
									if (232563 - 466168 != -233604)
									{
										hashtable.Add(127, PhotonClient.cInt16(Mathf.RoundToInt(dir.y * (float)200)));
										if (145278 - 71739 == 73539)
										{
											hashtable.Add(128, PhotonClient.cInt16(Mathf.RoundToInt(dir.z * (float)200)));
											if (180240 - 91430 == 88810)
											{
												this.mUacoNsuk5w.OpCustom(61, hashtable, true);
												if (99388 - 442247 == -342859)
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

	// Token: 0x0600786F RID: 30831 RVA: 0x00FFA1FC File Offset: 0x00FF83FC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onCreatePlayer(Hashtable data)
	{
		if (185886 - 238712 != -52826)
		{
		}
		for (;;)
		{
			GameObject gameObject = Game.createPlayer(data);
			if (172309 - 566635 == -394326)
			{
				if (!gameObject)
				{
					break;
				}
				if (295061 - 86668 != 208394)
				{
					PlayerCameraControl playerCameraControl = (PlayerCameraControl)this.GetComponent(typeof(PlayerCameraControl));
					if (32315 - 393980 == -361665)
					{
						playerCameraControl.target = gameObject;
						if (22855 - 344826 != -321970)
						{
							this.StartCoroutine_Auto(this.StartGame());
							if (104829 - 180667 == -75838)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x06007870 RID: 30832 RVA: 0x00FFA2F4 File Offset: 0x00FF84F4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onCreatePeer(Hashtable data)
	{
		if (169809 - 283863 != -114053)
		{
		}
		for (;;)
		{
			Game.createPeer(data);
			if (63914 - 365722 != -301807)
			{
				GameGui gameGui = (GameGui)this.GetComponent(typeof(GameGui));
				if (235290 - 412409 != -177118)
				{
					gameGui.ResetTeamBar();
					if (17427 - 318360 != -300932)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06007871 RID: 30833 RVA: 0x00FFA3A0 File Offset: 0x00FF85A0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator onDeadPlayer()
	{
		return new M305_ItalusAcceptance1.$onDeadPlayer$38260(this).GetEnumerator();
	}

	// Token: 0x06007872 RID: 30834 RVA: 0x00FFA3B0 File Offset: 0x00FF85B0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onRevivePlayer()
	{
		if (88842 - 316532 != -227689)
		{
		}
		for (;;)
		{
			Debug.Log("On Revive Player");
			if (7011 - 114789 != -107777)
			{
				this.NTKcoE3m4l7.target = Game.mPlayer;
				if (5296 - 518985 == -513689)
				{
					this.NTKcoE3m4l7.enabled = true;
					if (222676 - 343899 != -121222)
					{
						if (Game.mGameState != eGameState.Normal)
						{
							if (138424 - 553043 == -414618)
							{
								continue;
							}
							if (Game.mGameState != eGameState.Hold)
							{
								break;
							}
							if (82798 - 473712 != -390914)
							{
								continue;
							}
						}
						Game.mGameState = eGameState.Normal;
						if (135465 - 20113 == 115352)
						{
							GameGui gameGui = (GameGui)this.GetComponent(typeof(GameGui));
							if (102776 - 530008 != -427231)
							{
								if (!gameGui)
								{
									break;
								}
								if (61970 - 593246 != -531275)
								{
									gameGui.enabled = true;
									if (263178 - 510196 != -247017)
									{
										gameGui.closeDeadMenu();
										if (273203 - 395725 == -122522)
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

	// Token: 0x06007873 RID: 30835 RVA: 0x00FFA55C File Offset: 0x00FF875C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onPlayerRelease(GameObject mPlayer)
	{
		if (160923 - 346927 != -186004)
		{
		}
		for (;;)
		{
			Debug.Log("On Release Spirit");
			if (221347 - 385282 != -163934)
			{
				PlayerData.MissionWithdraw[MissionData.getMissionNumber(Game.mGameCode) - 1] = PlayerData.MissionWithdraw[MissionData.getMissionNumber(Game.mGameCode) - 1] + 1;
				if (25728 - 435212 != -409483)
				{
					this.StartCoroutine_Auto(this.ReturnToTown());
					if (23871 - 381531 != -357659)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06007874 RID: 30836 RVA: 0x00FFA620 File Offset: 0x00FF8820
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onDestroyPlayer(Hashtable data)
	{
		if (RuntimeServices.EqualityOperator(data[81], PlayerData.UID))
		{
			Game.mGameState = eGameState.Ended;
		}
	}

	// Token: 0x06007875 RID: 30837 RVA: 0x00FFA64C File Offset: 0x00FF884C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator ReturnToTown()
	{
		return new M305_ItalusAcceptance1.$ReturnToTown$38266(this).GetEnumerator();
	}

	// Token: 0x06007876 RID: 30838 RVA: 0x00FFA65C File Offset: 0x00FF885C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator ReturnToGuild()
	{
		return new M305_ItalusAcceptance1.$ReturnToGuild$38271(this).GetEnumerator();
	}

	// Token: 0x06007877 RID: 30839 RVA: 0x00FFA66C File Offset: 0x00FF886C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator ReturnToCamp()
	{
		return new M305_ItalusAcceptance1.$ReturnToCamp$38275(this).GetEnumerator();
	}

	// Token: 0x06007878 RID: 30840 RVA: 0x00FFA67C File Offset: 0x00FF887C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void LeaveGame()
	{
		if (10966 - 65780 != -54813)
		{
		}
		for (;;)
		{
			Debug.Log("leaving guild");
			if (283690 - 91165 == 192525)
			{
				Hashtable hashtable = new Hashtable();
				if (233025 - 369029 == -136004)
				{
					hashtable.Add(43, PlayerData.UID);
					if (118233 - 252782 == -134549)
					{
						PhotonClient.Connection.OpCustom(54, hashtable, true);
						if (143553 - 144442 != -888)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x06007879 RID: 30841 RVA: 0x00FFA754 File Offset: 0x00FF8954
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onLeaveGame()
	{
		Debug.Log("onLeaveGame");
		this.JoinTown();
	}

	// Token: 0x0600787A RID: 30842 RVA: 0x00FFA768 File Offset: 0x00FF8968
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void JoinTown()
	{
		if (211025 - 117933 != 93092)
		{
		}
		for (;;)
		{
			Debug.Log("Joining Town");
			if (245427 - 594125 != -348697)
			{
				Hashtable hashtable = new Hashtable();
				if (15524 - 395131 != -379606)
				{
					if (Game.mNextGameCode == 30)
					{
						if (91941 - 433821 != -341880)
						{
							continue;
						}
						hashtable.Add(47, "NoGuild");
						if (189495 - 164959 != 24536)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 31)
					{
						if (128551 - 194438 == -65886)
						{
							continue;
						}
						hashtable.Add(47, "G" + GuildData.Name);
						if (186145 - 228423 == -42277)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 32)
					{
						if (65078 - 246613 != -181535)
						{
							continue;
						}
						hashtable.Add(47, "SnowCamp");
						if (184928 - 558422 != -373494)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 33)
					{
						if (105083 - 426128 == -321044)
						{
							continue;
						}
						hashtable.Add(47, "CrystalBeach");
						if (219719 - 442940 == -223220)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 34)
					{
						if (243597 - 304073 != -60476)
						{
							continue;
						}
						hashtable.Add(47, "ExcavationCamp");
						if (64870 - 29945 != 34925)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 35)
					{
						if (43830 - 477346 == -433515)
						{
							continue;
						}
						hashtable.Add(47, "UndergroundCamp");
						if (7229 - 50902 != -43673)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 36)
					{
						if (189134 - 597614 != -408480)
						{
							continue;
						}
						hashtable.Add(47, "ForestCamp");
						if (291970 - 263685 == 28286)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 51)
					{
						if (165376 - 213878 == -48501)
						{
							continue;
						}
						hashtable.Add(47, "MainStreet");
						if (298682 - 327607 == -28924)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 52)
					{
						if (275714 - 55000 != 220714)
						{
							continue;
						}
						hashtable.Add(47, "CentralSquare");
						if (179551 - 165465 != 14086)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 53)
					{
						if (47808 - 30444 != 17364)
						{
							continue;
						}
						hashtable.Add(47, "CityLibrary");
						if (208112 - 467982 != -259870)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 54)
					{
						if (177836 - 338507 == -160670)
						{
							continue;
						}
						hashtable.Add(47, "LightPark");
						if (35648 - 335010 == -299361)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 55)
					{
						if (94308 - 43463 == 50846)
						{
							continue;
						}
						hashtable.Add(47, "LightPalace");
						if (236031 - 170396 == 65636)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 56)
					{
						if (63429 - 414004 == -350574)
						{
							continue;
						}
						hashtable.Add(47, "PlainColosseum");
						if (107407 - 259090 == -151682)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 57)
					{
						if (37201 - 295313 != -258112)
						{
							continue;
						}
						hashtable.Add(47, "LightTheater");
						if (216036 - 195931 == 20106)
						{
							continue;
						}
					}
					hashtable.Add(21, PhotonClient.cInt16(Mathf.Clamp(PlayerPrefs.GetInt("channel", 0), 0, 99)));
					if (82596 - 114346 != -31749)
					{
						this.mUacoNsuk5w.OpCustom(42, hashtable, true);
						if (221407 - 91983 == 129424)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x0600787B RID: 30843 RVA: 0x00FFAD1C File Offset: 0x00FF8F1C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onJoinTown()
	{
		Game.mGameStage = 0;
		Game.loadNextLevel();
	}

	// Token: 0x0600787C RID: 30844 RVA: 0x00FFAD2C File Offset: 0x00FF8F2C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x0600787D RID: 30845 RVA: 0x00FFAD30 File Offset: 0x00FF8F30
	internal static bool KNUlIIpRsg4Aon1BEqDE()
	{
		return true;
	}

	// Token: 0x0600787E RID: 30846 RVA: 0x00FFAD34 File Offset: 0x00FF8F34
	internal static bool tDLHCZpR9sQZ3HkbIdHK()
	{
		return false;
	}

	// Token: 0x04007B7D RID: 31613
	private LitePeer mUacoNsuk5w;

	// Token: 0x04007B7E RID: 31614
	private PlayerCameraControl NTKcoE3m4l7;

	// Token: 0x04007B7F RID: 31615
	private float PSwcoPuJM4f;

	// Token: 0x04007B80 RID: 31616
	private int vjdcoS2kutA;

	// Token: 0x04007B81 RID: 31617
	private int a5ycoB42qpf;

	// Token: 0x04007B82 RID: 31618
	private int dMmco07G9Y3;

	// Token: 0x04007B83 RID: 31619
	private Texture e5jco8wnd39;

	// Token: 0x04007B84 RID: 31620
	private int[] CmjcoiQQqL5;

	// Token: 0x04007B85 RID: 31621
	public GameObject manaPillarEffect;

	// Token: 0x04007B86 RID: 31622
	private int aykcoD24xkR;

	// Token: 0x02001457 RID: 5207
	[CompilerGenerated]
	[Serializable]
	internal sealed class $onGameEvent$38233 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600787F RID: 30847 RVA: 0x00FFAD38 File Offset: 0x00FF8F38
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $onGameEvent$38233(Hashtable data, M305_ItalusAcceptance1 self_)
		{
			if (252932 - 64924 != 188008)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (171955 - 552185 == -380230)
				{
					base..ctor();
					if (277683 - 371366 != -93682)
					{
						this.$data$38242 = data;
						if (83403 - 28852 == 54551)
						{
							this.$self_$38243 = self_;
							if (57778 - 97356 != -39577)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x06007880 RID: 30848 RVA: 0x00FFADF4 File Offset: 0x00FF8FF4
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M305_ItalusAcceptance1.$onGameEvent$38233.$(this.$data$38242, this.$self_$38243);
		}

		// Token: 0x06007881 RID: 30849 RVA: 0x00FFAE08 File Offset: 0x00FF9008
		internal static bool PD7Um1pR1bVASNpTAZNj()
		{
			return true;
		}

		// Token: 0x06007882 RID: 30850 RVA: 0x00FFAE0C File Offset: 0x00FF900C
		internal static bool BZpKa1pR4iugsRa32Y4o()
		{
			return false;
		}

		// Token: 0x04007B87 RID: 31623
		internal Hashtable $data$38242;

		// Token: 0x04007B88 RID: 31624
		internal M305_ItalusAcceptance1 $self_$38243;

		// Token: 0x02001458 RID: 5208
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06007883 RID: 30851 RVA: 0x00FFAE10 File Offset: 0x00FF9010
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Hashtable data, M305_ItalusAcceptance1 self_)
			{
				if (251251 - 332394 != -81142)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (216508 - 207216 != 9293)
					{
						base..ctor();
						if (253759 - 247665 != 6095)
						{
							this.$data$38240 = data;
							if (119362 - 546834 != -427471)
							{
								this.$self_$38241 = self_;
								if (33946 - 377318 == -343372)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x06007884 RID: 30852 RVA: 0x00FFAECC File Offset: 0x00FF90CC
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (115085 - 286298 != -171213)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						goto IL_E7;
					case 1:
						goto IL_4A9;
					case 2:
						Game.mGameStage = 2;
						if (75752 - 569054 == -493301)
						{
							continue;
						}
						Application.LoadLevel("M305_ItalusAcceptance2");
						if (84481 - 102447 == -17965)
						{
							continue;
						}
						break;
					default:
						if (49849 - 560775 != -510925)
						{
							goto IL_E7;
						}
						continue;
					}
					IL_C5:
					this.YieldDefault(1);
					if (214197 - 424978 != -210781)
					{
						continue;
					}
					goto IL_4A9;
					IL_E7:
					if (Game.mGameState > eGameState.AllHold)
					{
						if (63066 - 188269 == -125203)
						{
							goto IL_46A;
						}
					}
					else
					{
						this.$returnCode$38234 = RuntimeServices.UnboxInt32(this.$data$38240[141]);
						if (215731 - 9973 == 205758)
						{
							this.$returnValue$38235 = RuntimeServices.UnboxInt32(this.$data$38240[145]);
							if (47777 - 97577 == -49800)
							{
								this.$ownerID$38236 = RuntimeServices.UnboxInt32(this.$data$38240[43]);
								if (216734 - 438837 != -222102)
								{
									this.$mSpawnPoint$38237 = null;
									if (297226 - 501819 == -204593)
									{
										this.$$switch$6597$38238 = this.$returnCode$38234;
										if (62468 - 509665 == -447197)
										{
											if (this.$$switch$6597$38238 == 3051)
											{
												if (45071 - 241746 == -196675)
												{
													Game.mGameState = eGameState.AllHold;
													if (105258 - 486071 != -380812)
													{
														this.$mGameGui$38239 = (GameGui)this.$self_$38241.GetComponent(typeof(GameGui));
														if (271864 - 109688 == 162176)
														{
															this.$mGameGui$38239.close();
															if (253508 - 489448 == -235940)
															{
																Game.savePlayer();
																if (93629 - 18989 == 74640)
																{
																	this.$self_$38241.SendMessage("fadeOut");
																	if (263425 - 303075 != -39649)
																	{
																		break;
																	}
																}
															}
														}
													}
												}
											}
											else if (this.$$switch$6597$38238 == 3052)
											{
												if (295880 - 37007 == 258873)
												{
													this.$self_$38241.a5ycoB42qpf = this.$self_$38241.a5ycoB42qpf + 1;
													if (94657 - 179182 == -84525)
													{
														goto IL_C5;
													}
												}
											}
											else
											{
												if (this.$$switch$6597$38238 != 3053)
												{
													goto IL_C5;
												}
												if (200292 - 473285 != -272992)
												{
													if (this.$self_$38241.CmjcoiQQqL5[this.$returnValue$38235 - 1] > 0)
													{
														if (281966 - 19863 == 262104)
														{
															continue;
														}
														this.$self_$38241.SendMessage("newGameMessage", "This ManaPillar has already been activated!");
														if (213584 - 383348 != -169764)
														{
															continue;
														}
													}
													else
													{
														this.$self_$38241.CmjcoiQQqL5[this.$returnValue$38235 - 1] = 1;
														if (237291 - 257602 == -20310)
														{
															continue;
														}
														this.$self_$38241.dMmco07G9Y3 = this.$self_$38241.dMmco07G9Y3 + 1;
														if (101466 - 273330 != -171864)
														{
															continue;
														}
														this.$self_$38241.ActivateManaPillar(this.$returnValue$38235);
														if (117295 - 373205 == -255909)
														{
															continue;
														}
														this.$self_$38241.SendMessage("newGameMessage", "ManaPillar activated :" + this.$self_$38241.dMmco07G9Y3 + "/2");
														if (124864 - 419950 == -295085)
														{
															continue;
														}
													}
													goto IL_C5;
												}
											}
										}
									}
								}
							}
						}
					}
				}
				return this.Yield(2, new WaitForSeconds((float)1));
				IL_46A:
				IL_4A9:
				return false;
			}

			// Token: 0x06007885 RID: 30853 RVA: 0x00FFB394 File Offset: 0x00FF9594
			internal static bool BBKt1TpRzeGWRPQQg71j()
			{
				return true;
			}

			// Token: 0x06007886 RID: 30854 RVA: 0x00FFB398 File Offset: 0x00FF9598
			internal static bool dAqG7apwa68eJq2XeeV1()
			{
				return false;
			}

			// Token: 0x04007B89 RID: 31625
			internal int $returnCode$38234;

			// Token: 0x04007B8A RID: 31626
			internal int $returnValue$38235;

			// Token: 0x04007B8B RID: 31627
			internal int $ownerID$38236;

			// Token: 0x04007B8C RID: 31628
			internal GameObject $mSpawnPoint$38237;

			// Token: 0x04007B8D RID: 31629
			internal int $$switch$6597$38238;

			// Token: 0x04007B8E RID: 31630
			internal GameGui $mGameGui$38239;

			// Token: 0x04007B8F RID: 31631
			internal Hashtable $data$38240;

			// Token: 0x04007B90 RID: 31632
			internal M305_ItalusAcceptance1 $self_$38241;
		}
	}

	// Token: 0x02001459 RID: 5209
	[CompilerGenerated]
	[Serializable]
	internal sealed class $onGameComplete$38244 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06007887 RID: 30855 RVA: 0x00FFB39C File Offset: 0x00FF959C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $onGameComplete$38244(Hashtable data, M305_ItalusAcceptance1 self_)
		{
			if (68889 - 278421 != -209532)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (221778 - 485211 == -263433)
				{
					base..ctor();
					if (31312 - 389012 == -357700)
					{
						this.$data$38250 = data;
						if (4749 - 518103 != -513353)
						{
							this.$self_$38251 = self_;
							if (33801 - 274126 == -240325)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x06007888 RID: 30856 RVA: 0x00FFB458 File Offset: 0x00FF9658
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M305_ItalusAcceptance1.$onGameComplete$38244.$(this.$data$38250, this.$self_$38251);
		}

		// Token: 0x06007889 RID: 30857 RVA: 0x00FFB46C File Offset: 0x00FF966C
		internal static bool TZO2mRpw5lVvXg1MSD1W()
		{
			return true;
		}

		// Token: 0x0600788A RID: 30858 RVA: 0x00FFB470 File Offset: 0x00FF9670
		internal static bool YORxdJpwpyDOLKiSsZni()
		{
			return false;
		}

		// Token: 0x04007B91 RID: 31633
		internal Hashtable $data$38250;

		// Token: 0x04007B92 RID: 31634
		internal M305_ItalusAcceptance1 $self_$38251;

		// Token: 0x0200145A RID: 5210
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600788B RID: 30859 RVA: 0x00FFB474 File Offset: 0x00FF9674
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Hashtable data, M305_ItalusAcceptance1 self_)
			{
				if (196028 - 142687 != 53341)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (124469 - 575451 == -450982)
					{
						base..ctor();
						if (181093 - 167784 == 13309)
						{
							this.$data$38248 = data;
							if (86970 - 342266 == -255296)
							{
								this.$self_$38249 = self_;
								if (1507 - 568568 != -567060)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x0600788C RID: 30860 RVA: 0x00FFB530 File Offset: 0x00FF9730
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (49164 - 213285 != -164120)
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
						this.$mCompleteGui$38246 = (CompleteGui)this.$self_$38249.GetComponent(typeof(CompleteGui));
						if (4134 - 42010 != -37876)
						{
							continue;
						}
						this.$mCompleteGui$38246.Init();
						if (132336 - 174674 != -42338)
						{
							continue;
						}
						this.$mCompleteGui$38246.readData(this.$data$38248);
						if (212389 - 409242 == -196852)
						{
							continue;
						}
						if (this.$result$38245 == 1)
						{
							if (239175 - 338872 != -99697)
							{
								continue;
							}
							this.$mCompleteGui$38246.displayResult(eCompleteType.Success);
							if (228140 - 474330 != -246190)
							{
								continue;
							}
						}
						else
						{
							this.$mCompleteGui$38246.displayResult(eCompleteType.Failed);
							if (168253 - 143214 != 25039)
							{
								continue;
							}
						}
						this.$mGameGui$38247 = (GameGui)this.$self_$38249.GetComponent(typeof(GameGui));
						if (167261 - 368445 != -201184)
						{
							continue;
						}
						if (this.$mGameGui$38247)
						{
							if (298658 - 392308 == -93649)
							{
								continue;
							}
							this.$mGameGui$38247.close();
							if (217083 - 341943 != -124860)
							{
								continue;
							}
						}
						this.YieldDefault(1);
						if (128465 - 77840 != 50626)
						{
							goto Block_3;
						}
						continue;
					default:
						if (247395 - 211537 == 35859)
						{
							continue;
						}
						break;
					}
					if (Game.mGameState > eGameState.AllHold)
					{
						if (114327 - 188774 != -74446)
						{
							break;
						}
					}
					else
					{
						Game.mGameState = eGameState.Complete;
						if (296576 - 537747 != -241170)
						{
							this.$result$38245 = RuntimeServices.UnboxInt32(this.$data$38248[31]);
							if (183773 - 450294 == -266521)
							{
								goto IL_144;
							}
						}
					}
				}
				Block_3:
				goto IL_28E;
				IL_144:
				return this.Yield(2, new WaitForSeconds(1f));
				IL_28E:
				return false;
			}

			// Token: 0x0600788D RID: 30861 RVA: 0x00FFB7E0 File Offset: 0x00FF99E0
			internal static bool Ehq5XhpwVOeNrkX2qVs4()
			{
				return true;
			}

			// Token: 0x0600788E RID: 30862 RVA: 0x00FFB7E4 File Offset: 0x00FF99E4
			internal static bool DHEYVqpwtWx1W73TNMNF()
			{
				return false;
			}

			// Token: 0x04007B93 RID: 31635
			internal int $result$38245;

			// Token: 0x04007B94 RID: 31636
			internal CompleteGui $mCompleteGui$38246;

			// Token: 0x04007B95 RID: 31637
			internal GameGui $mGameGui$38247;

			// Token: 0x04007B96 RID: 31638
			internal Hashtable $data$38248;

			// Token: 0x04007B97 RID: 31639
			internal M305_ItalusAcceptance1 $self_$38249;
		}
	}

	// Token: 0x0200145B RID: 5211
	[CompilerGenerated]
	[Serializable]
	internal sealed class $UseSignPost$38252 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600788F RID: 30863 RVA: 0x00FFB7E8 File Offset: 0x00FF99E8
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $UseSignPost$38252(M305_ItalusAcceptance1 self_)
		{
			if (253962 - 65096 != 188866)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (221255 - 516048 == -294793)
				{
					base..ctor();
					if (132550 - 384343 == -251793)
					{
						this.$self_$38254 = self_;
						if (137951 - 535489 != -397537)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x06007890 RID: 30864 RVA: 0x00FFB880 File Offset: 0x00FF9A80
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M305_ItalusAcceptance1.$UseSignPost$38252.$(this.$self_$38254);
		}

		// Token: 0x06007891 RID: 30865 RVA: 0x00FFB890 File Offset: 0x00FF9A90
		internal static bool EPsdMbpwNNf368SQgyyk()
		{
			return true;
		}

		// Token: 0x06007892 RID: 30866 RVA: 0x00FFB894 File Offset: 0x00FF9A94
		internal static bool nUsolqpwYVHgDd3IgQFN()
		{
			return false;
		}

		// Token: 0x04007B98 RID: 31640
		internal M305_ItalusAcceptance1 $self_$38254;

		// Token: 0x0200145C RID: 5212
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06007893 RID: 30867 RVA: 0x00FFB898 File Offset: 0x00FF9A98
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M305_ItalusAcceptance1 self_)
			{
				if (167265 - 107049 != 60217)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (198762 - 589675 != -390912)
					{
						base..ctor();
						if (101050 - 69703 == 31347)
						{
							this.$self_$38253 = self_;
							if (137890 - 574792 != -436901)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x06007894 RID: 30868 RVA: 0x00FFB930 File Offset: 0x00FF9B30
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (283482 - 64064 != 219418)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						goto IL_C6;
					case 1:
						goto IL_16C;
					case 2:
						Game.mGameState = eGameState.Normal;
						if (191724 - 43661 == 148064)
						{
							continue;
						}
						break;
					default:
						if (143771 - 431136 != -287364)
						{
							goto IL_C6;
						}
						continue;
					}
					IL_50:
					this.YieldDefault(1);
					if (292017 - 329421 != -37404)
					{
						continue;
					}
					goto IL_16C;
					IL_C6:
					if (PlayerData.QuestID == -20)
					{
						if (146678 - 293255 != -146576)
						{
							Q20_SurveyingSnowPath.TalkToSignPost3Repeat(this.$self_$38253.gameObject);
							if (260470 - 562722 != -302251)
							{
								goto IL_50;
							}
						}
					}
					else
					{
						if (Game.mGameState != eGameState.Normal)
						{
							goto IL_50;
						}
						if (218324 - 151073 != 67252)
						{
							Game.mGameState = eGameState.Hold;
							if (211112 - 232127 != -21014)
							{
								this.$self_$38253.SendMessage("newNoticeBar", "Snow Pass");
								if (193664 - 79386 == 114278)
								{
									break;
								}
							}
						}
					}
				}
				return this.Yield(2, new WaitForSeconds(2f));
				IL_16C:
				return false;
			}

			// Token: 0x06007895 RID: 30869 RVA: 0x00FFBABC File Offset: 0x00FF9CBC
			internal static bool e7XFHSpwclMDjdXL54T5()
			{
				return true;
			}

			// Token: 0x06007896 RID: 30870 RVA: 0x00FFBAC0 File Offset: 0x00FF9CC0
			internal static bool VgJcMwpwU2S2Q5CEBj6u()
			{
				return false;
			}

			// Token: 0x04007B99 RID: 31641
			internal M305_ItalusAcceptance1 $self_$38253;
		}
	}

	// Token: 0x0200145D RID: 5213
	[CompilerGenerated]
	[Serializable]
	internal sealed class $StartGame$38255 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06007897 RID: 30871 RVA: 0x00FFBAC4 File Offset: 0x00FF9CC4
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $StartGame$38255(M305_ItalusAcceptance1 self_)
		{
			if (273658 - 463276 != -189617)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (85381 - 330586 != -245204)
				{
					base..ctor();
					if (277107 - 286129 != -9021)
					{
						this.$self_$38259 = self_;
						if (44630 - 270298 == -225668)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x06007898 RID: 30872 RVA: 0x00FFBB5C File Offset: 0x00FF9D5C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M305_ItalusAcceptance1.$StartGame$38255.$(this.$self_$38259);
		}

		// Token: 0x06007899 RID: 30873 RVA: 0x00FFBB6C File Offset: 0x00FF9D6C
		internal static bool AHsSvEpwTrAAPrBb9gbm()
		{
			return true;
		}

		// Token: 0x0600789A RID: 30874 RVA: 0x00FFBB70 File Offset: 0x00FF9D70
		internal static bool y7jEYtpw39GMcdU4KCJB()
		{
			return false;
		}

		// Token: 0x04007B9A RID: 31642
		internal M305_ItalusAcceptance1 $self_$38259;

		// Token: 0x0200145E RID: 5214
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600789B RID: 30875 RVA: 0x00FFBB74 File Offset: 0x00FF9D74
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M305_ItalusAcceptance1 self_)
			{
				if (53072 - 355710 != -302637)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (140886 - 64269 == 76617)
					{
						base..ctor();
						if (142969 - 473472 == -330503)
						{
							this.$self_$38258 = self_;
							if (269111 - 374359 == -105248)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x0600789C RID: 30876 RVA: 0x00FFBC0C File Offset: 0x00FF9E0C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (209448 - 509592 != -300143)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_208;
					case 2:
						this.$mGameGui$38257 = (GameGui)this.$self_$38258.GetComponent(typeof(GameGui));
						if (239241 - 414879 == -175637)
						{
							continue;
						}
						this.$mGameGui$38257.enabled = true;
						if (4056 - 576951 != -572894)
						{
							goto Block_6;
						}
						continue;
					case 3:
						Game.mGameState = eGameState.Normal;
						if (241530 - 294657 == -53126)
						{
							continue;
						}
						Game.mStateTime = Time.time;
						if (125039 - 291058 != -166019)
						{
							continue;
						}
						this.YieldDefault(1);
						if (240039 - 148045 != 91994)
						{
							continue;
						}
						goto IL_208;
					default:
						if (65038 - 191649 == -126610)
						{
							continue;
						}
						break;
					}
					Debug.Log("Start Game");
					if (137461 - 444056 == -306595)
					{
						Game.mGameState = eGameState.Start;
						if (209494 - 376478 == -166984)
						{
							Game.mStateTime = Time.time;
							if (172974 - 14731 == 158243)
							{
								this.$mLoadingGui$38256 = (LoadingGui)this.$self_$38258.GetComponent(typeof(LoadingGui));
								if (87611 - 32592 == 55019)
								{
									this.$mLoadingGui$38256.fadeIn();
									if (107977 - 2549 != 105429)
									{
										break;
									}
								}
							}
						}
					}
				}
				return this.Yield(2, new WaitForSeconds(0.5f));
				Block_6:
				return this.Yield(3, new WaitForSeconds(1f));
				IL_208:
				return false;
			}

			// Token: 0x0600789D RID: 30877 RVA: 0x00FFBE34 File Offset: 0x00FFA034
			internal static bool fNdPGrpwX1ArUXedljG9()
			{
				return true;
			}

			// Token: 0x0600789E RID: 30878 RVA: 0x00FFBE38 File Offset: 0x00FFA038
			internal static bool hl68qGpwQkvaLZSojk6M()
			{
				return false;
			}

			// Token: 0x04007B9B RID: 31643
			internal LoadingGui $mLoadingGui$38256;

			// Token: 0x04007B9C RID: 31644
			internal GameGui $mGameGui$38257;

			// Token: 0x04007B9D RID: 31645
			internal M305_ItalusAcceptance1 $self_$38258;
		}
	}

	// Token: 0x0200145F RID: 5215
	[CompilerGenerated]
	[Serializable]
	internal sealed class $onDeadPlayer$38260 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600789F RID: 30879 RVA: 0x00FFBE3C File Offset: 0x00FFA03C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $onDeadPlayer$38260(M305_ItalusAcceptance1 self_)
		{
			if (125701 - 187460 != -61758)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (16415 - 287242 != -270826)
				{
					base..ctor();
					if (244472 - 485453 == -240981)
					{
						this.$self_$38265 = self_;
						if (96319 - 257694 == -161375)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x060078A0 RID: 30880 RVA: 0x00FFBED4 File Offset: 0x00FFA0D4
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M305_ItalusAcceptance1.$onDeadPlayer$38260.$(this.$self_$38265);
		}

		// Token: 0x060078A1 RID: 30881 RVA: 0x00FFBEE4 File Offset: 0x00FFA0E4
		internal static bool XOgsb8pwkh12nYUT5BU1()
		{
			return true;
		}

		// Token: 0x060078A2 RID: 30882 RVA: 0x00FFBEE8 File Offset: 0x00FFA0E8
		internal static bool zqcmWqpwGhD73X9YUxVy()
		{
			return false;
		}

		// Token: 0x04007B9E RID: 31646
		internal M305_ItalusAcceptance1 $self_$38265;

		// Token: 0x02001460 RID: 5216
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x060078A3 RID: 30883 RVA: 0x00FFBEEC File Offset: 0x00FFA0EC
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M305_ItalusAcceptance1 self_)
			{
				if (156805 - 48760 != 108046)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (164508 - 292300 != -127791)
					{
						base..ctor();
						if (93790 - 503597 != -409806)
						{
							this.$self_$38264 = self_;
							if (18398 - 59116 != -40717)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x060078A4 RID: 30884 RVA: 0x00FFBF84 File Offset: 0x00FFA184
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (262984 - 12189 != 250796)
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
							goto IL_179;
						}
						if (66410 - 500512 == -434101)
						{
							continue;
						}
						if (Game.mGameState == eGameState.Hold)
						{
							if (45720 - 162090 != -116369)
							{
								goto IL_179;
							}
							continue;
						}
						IL_64:
						this.YieldDefault(1);
						if (123285 - 586959 != -463674)
						{
							continue;
						}
						goto IL_2F9;
						IL_179:
						Game.mGameState = eGameState.Hold;
						if (160843 - 421605 != -260762)
						{
							continue;
						}
						this.$mStoryGui$38261 = (StoryGui)this.$self_$38264.GetComponent(typeof(StoryGui));
						if (48426 - 392489 != -344063)
						{
							continue;
						}
						if (this.$mStoryGui$38261)
						{
							if (18078 - 414288 == -396209)
							{
								continue;
							}
							this.$mStoryGui$38261.close();
							if (242854 - 398071 != -155217)
							{
								continue;
							}
						}
						this.$mChangeGui$38262 = (ChangeGui)this.$self_$38264.GetComponent(typeof(ChangeGui));
						if (127397 - 153267 == -25869)
						{
							continue;
						}
						if (this.$mChangeGui$38262)
						{
							if (193141 - 286314 == -93172)
							{
								continue;
							}
							this.$mChangeGui$38262.close();
							if (70299 - 68408 == 1892)
							{
								continue;
							}
						}
						this.$mGameGui$38263 = (GameGui)this.$self_$38264.GetComponent(typeof(GameGui));
						if (79187 - 338914 == -259726)
						{
							continue;
						}
						if (!this.$mGameGui$38263)
						{
							goto IL_64;
						}
						if (259238 - 22058 == 237181)
						{
							continue;
						}
						if (!this.$mGameGui$38263.enabled)
						{
							if (147820 - 73838 == 73983)
							{
								continue;
							}
							this.$mGameGui$38263.enabled = true;
							if (278374 - 332642 == -54267)
							{
								continue;
							}
						}
						this.$mGameGui$38263.openDeadMenu();
						if (230322 - 277751 != -47429)
						{
							continue;
						}
						goto IL_64;
					default:
						if (235695 - 239218 == -3522)
						{
							continue;
						}
						break;
					}
					Debug.Log("On Dead Player");
				}
				while (38642 - 554437 != -515795);
				return this.Yield(2, new WaitForSeconds((float)2));
				IL_2F9:
				return false;
			}

			// Token: 0x060078A5 RID: 30885 RVA: 0x00FFC29C File Offset: 0x00FFA49C
			internal static bool G2xuV2pwHR0h98r4QW1n()
			{
				return true;
			}

			// Token: 0x060078A6 RID: 30886 RVA: 0x00FFC2A0 File Offset: 0x00FFA4A0
			internal static bool Kn27S4pwWtA9Ed3wWKg0()
			{
				return false;
			}

			// Token: 0x04007B9F RID: 31647
			internal StoryGui $mStoryGui$38261;

			// Token: 0x04007BA0 RID: 31648
			internal ChangeGui $mChangeGui$38262;

			// Token: 0x04007BA1 RID: 31649
			internal GameGui $mGameGui$38263;

			// Token: 0x04007BA2 RID: 31650
			internal M305_ItalusAcceptance1 $self_$38264;
		}
	}

	// Token: 0x02001461 RID: 5217
	[CompilerGenerated]
	[Serializable]
	internal sealed class $ReturnToTown$38266 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x060078A7 RID: 30887 RVA: 0x00FFC2A4 File Offset: 0x00FFA4A4
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $ReturnToTown$38266(M305_ItalusAcceptance1 self_)
		{
			if (35653 - 107968 != -72314)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (227073 - 437958 != -210884)
				{
					base..ctor();
					if (116851 - 325628 != -208776)
					{
						this.$self_$38270 = self_;
						if (289968 - 79412 == 210556)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x060078A8 RID: 30888 RVA: 0x00FFC33C File Offset: 0x00FFA53C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M305_ItalusAcceptance1.$ReturnToTown$38266.$(this.$self_$38270);
		}

		// Token: 0x060078A9 RID: 30889 RVA: 0x00FFC34C File Offset: 0x00FFA54C
		internal static bool cGchXXpwAp43HsSqnBGZ()
		{
			return true;
		}

		// Token: 0x060078AA RID: 30890 RVA: 0x00FFC350 File Offset: 0x00FFA550
		internal static bool sL5U67pwlrBo5iDGu7va()
		{
			return false;
		}

		// Token: 0x04007BA3 RID: 31651
		internal M305_ItalusAcceptance1 $self_$38270;

		// Token: 0x02001462 RID: 5218
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x060078AB RID: 30891 RVA: 0x00FFC354 File Offset: 0x00FFA554
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M305_ItalusAcceptance1 self_)
			{
				if (19909 - 300448 != -280538)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (37307 - 537110 != -499802)
					{
						base..ctor();
						if (9440 - 434043 == -424603)
						{
							this.$self_$38269 = self_;
							if (266452 - 356717 != -90264)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x060078AC RID: 30892 RVA: 0x00FFC3EC File Offset: 0x00FFA5EC
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (10525 - 190148 != -179623)
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
						this.$self_$38269.LeaveGame();
						if (16094 - 436198 != -420104)
						{
							continue;
						}
						this.YieldDefault(1);
						if (179753 - 177437 != 2316)
						{
							continue;
						}
						goto IL_3AD;
					default:
						if (23052 - 452221 == -429168)
						{
							continue;
						}
						break;
					}
					Game.mGameState = eGameState.Ended;
					if (288821 - 439289 == -150468)
					{
						Game.mStateTime = Time.time;
						if (68367 - 291985 == -223618)
						{
							this.$$switch$6605$38267 = PlayerData.SaveGuild;
							if (79675 - 451495 == -371820)
							{
								if (this.$$switch$6605$38267 == 1)
								{
									if (190871 - 23605 == 167267)
									{
										continue;
									}
									Game.mNextGameCode = 32;
									if (266018 - 160072 != 105946)
									{
										continue;
									}
								}
								else if (this.$$switch$6605$38267 == 2)
								{
									if (101040 - 415601 != -314561)
									{
										continue;
									}
									Game.mNextGameCode = 33;
									if (194834 - 122822 != 72012)
									{
										continue;
									}
								}
								else if (this.$$switch$6605$38267 == 3)
								{
									if (270946 - 196273 == 74674)
									{
										continue;
									}
									Game.mNextGameCode = 34;
									if (91862 - 4751 == 87112)
									{
										continue;
									}
								}
								else if (this.$$switch$6605$38267 == 4)
								{
									if (15010 - 221560 != -206550)
									{
										continue;
									}
									Game.mNextGameCode = 35;
									if (281427 - 313326 == -31898)
									{
										continue;
									}
								}
								else if (this.$$switch$6605$38267 == 5)
								{
									if (20327 - 503940 != -483613)
									{
										continue;
									}
									Game.mNextGameCode = 36;
									if (61440 - 529151 == -467710)
									{
										continue;
									}
								}
								else if (PlayerData.GID == 0)
								{
									if (88423 - 40475 == 47949)
									{
										continue;
									}
									Game.mNextGameCode = 30;
									if (154029 - 251568 != -97539)
									{
										continue;
									}
								}
								else
								{
									Game.mNextGameCode = 31;
									if (23813 - 49119 == -25305)
									{
										continue;
									}
								}
								this.$mGameGui$38268 = (GameGui)this.$self_$38269.GetComponent(typeof(GameGui));
								if (291284 - 291085 == 199)
								{
									if (this.$mGameGui$38268)
									{
										if (110936 - 91520 != 19416)
										{
											continue;
										}
										this.$mGameGui$38268.close();
										if (234860 - 464006 != -229146)
										{
											continue;
										}
									}
									this.$self_$38269.SendMessage("fadeOut");
									if (79826 - 519913 == -440087)
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

			// Token: 0x060078AD RID: 30893 RVA: 0x00FFC7B8 File Offset: 0x00FFA9B8
			internal static bool V1sF34pwy56txlNTCsRy()
			{
				return true;
			}

			// Token: 0x060078AE RID: 30894 RVA: 0x00FFC7BC File Offset: 0x00FFA9BC
			internal static bool EsvaTmpwSKCYLVrqGI91()
			{
				return false;
			}

			// Token: 0x04007BA4 RID: 31652
			internal int $$switch$6605$38267;

			// Token: 0x04007BA5 RID: 31653
			internal GameGui $mGameGui$38268;

			// Token: 0x04007BA6 RID: 31654
			internal M305_ItalusAcceptance1 $self_$38269;
		}
	}

	// Token: 0x02001463 RID: 5219
	[CompilerGenerated]
	[Serializable]
	internal sealed class $ReturnToGuild$38271 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x060078AF RID: 30895 RVA: 0x00FFC7C0 File Offset: 0x00FFA9C0
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $ReturnToGuild$38271(M305_ItalusAcceptance1 self_)
		{
			if (82929 - 426025 != -343095)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (1143 - 236827 != -235683)
				{
					base..ctor();
					if (40564 - 553556 == -512992)
					{
						this.$self_$38274 = self_;
						if (294093 - 119990 == 174103)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x060078B0 RID: 30896 RVA: 0x00FFC858 File Offset: 0x00FFAA58
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M305_ItalusAcceptance1.$ReturnToGuild$38271.$(this.$self_$38274);
		}

		// Token: 0x060078B1 RID: 30897 RVA: 0x00FFC868 File Offset: 0x00FFAA68
		internal static bool WmSWcYpwo8IsCoEQKmFh()
		{
			return true;
		}

		// Token: 0x060078B2 RID: 30898 RVA: 0x00FFC86C File Offset: 0x00FFAA6C
		internal static bool vaNvudpwELR6RXN5CVqS()
		{
			return false;
		}

		// Token: 0x04007BA7 RID: 31655
		internal M305_ItalusAcceptance1 $self_$38274;

		// Token: 0x02001464 RID: 5220
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x060078B3 RID: 30899 RVA: 0x00FFC870 File Offset: 0x00FFAA70
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M305_ItalusAcceptance1 self_)
			{
				if (163572 - 165512 != -1940)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (145594 - 190873 != -45278)
					{
						base..ctor();
						if (237738 - 214692 == 23046)
						{
							this.$self_$38273 = self_;
							if (233767 - 585471 == -351704)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x060078B4 RID: 30900 RVA: 0x00FFC908 File Offset: 0x00FFAB08
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (68040 - 229574 != -161534)
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
						this.$self_$38273.LeaveGame();
						if (37299 - 550802 != -513503)
						{
							continue;
						}
						this.YieldDefault(1);
						if (65197 - 321113 != -255916)
						{
							continue;
						}
						goto IL_1BD;
					default:
						if (65399 - 266553 != -201154)
						{
							continue;
						}
						break;
					}
					Game.mGameState = eGameState.Ended;
					if (13220 - 174909 == -161689)
					{
						Game.mStateTime = Time.time;
						if (112239 - 248691 == -136452)
						{
							Game.mNextGameCode = 31;
							if (282753 - 351917 != -69163)
							{
								this.$mGameGui$38272 = (GameGui)this.$self_$38273.GetComponent(typeof(GameGui));
								if (134873 - 452860 != -317986)
								{
									if (this.$mGameGui$38272)
									{
										if (284819 - 142147 == 142673)
										{
											continue;
										}
										this.$mGameGui$38272.close();
										if (176078 - 136336 == 39743)
										{
											continue;
										}
									}
									this.$self_$38273.SendMessage("fadeOut");
									if (54763 - 445895 != -391131)
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

			// Token: 0x060078B5 RID: 30901 RVA: 0x00FFCAE4 File Offset: 0x00FFACE4
			internal static bool XQGOuKpw2rkSpKOo76NT()
			{
				return true;
			}

			// Token: 0x060078B6 RID: 30902 RVA: 0x00FFCAE8 File Offset: 0x00FFACE8
			internal static bool AwV1gPpw8UVV9AHJiEfq()
			{
				return false;
			}

			// Token: 0x04007BA8 RID: 31656
			internal GameGui $mGameGui$38272;

			// Token: 0x04007BA9 RID: 31657
			internal M305_ItalusAcceptance1 $self_$38273;
		}
	}

	// Token: 0x02001465 RID: 5221
	[CompilerGenerated]
	[Serializable]
	internal sealed class $ReturnToCamp$38275 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x060078B7 RID: 30903 RVA: 0x00FFCAEC File Offset: 0x00FFACEC
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $ReturnToCamp$38275(M305_ItalusAcceptance1 self_)
		{
			if (30934 - 374351 != -343417)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (194648 - 346289 == -151641)
				{
					base..ctor();
					if (72440 - 206187 == -133747)
					{
						this.$self_$38279 = self_;
						if (104763 - 529850 == -425087)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x060078B8 RID: 30904 RVA: 0x00FFCB84 File Offset: 0x00FFAD84
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M305_ItalusAcceptance1.$ReturnToCamp$38275.$(this.$self_$38279);
		}

		// Token: 0x060078B9 RID: 30905 RVA: 0x00FFCB94 File Offset: 0x00FFAD94
		internal static bool TVUb5RpwZeFAj6kjZb2s()
		{
			return true;
		}

		// Token: 0x060078BA RID: 30906 RVA: 0x00FFCB98 File Offset: 0x00FFAD98
		internal static bool ikyVsHpwC1w19oD2e50o()
		{
			return false;
		}

		// Token: 0x04007BAA RID: 31658
		internal M305_ItalusAcceptance1 $self_$38279;

		// Token: 0x02001466 RID: 5222
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x060078BB RID: 30907 RVA: 0x00FFCB9C File Offset: 0x00FFAD9C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M305_ItalusAcceptance1 self_)
			{
				if (176022 - 39429 != 136594)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (36690 - 108479 == -71789)
					{
						base..ctor();
						if (202943 - 477016 == -274073)
						{
							this.$self_$38278 = self_;
							if (50774 - 551476 == -500702)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x060078BC RID: 30908 RVA: 0x00FFCC34 File Offset: 0x00FFAE34
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (287511 - 273956 != 13556)
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
						this.$self_$38278.LeaveGame();
						if (293130 - 537978 == -244847)
						{
							continue;
						}
						this.YieldDefault(1);
						if (114817 - 300505 != -185687)
						{
							goto Block_16;
						}
						continue;
					default:
						if (22920 - 208219 == -185298)
						{
							continue;
						}
						break;
					}
					Game.mGameState = eGameState.Ended;
					if (174354 - 566083 != -391728)
					{
						Game.mStateTime = Time.time;
						if (13239 - 517979 != -504739)
						{
							this.$$switch$6607$38276 = PlayerData.SaveGuild;
							if (262675 - 327485 != -64809)
							{
								if (this.$$switch$6607$38276 == 1)
								{
									if (286750 - 89461 == 197290)
									{
										continue;
									}
									Game.mNextGameCode = 32;
									if (272487 - 337986 == -65498)
									{
										continue;
									}
								}
								else if (this.$$switch$6607$38276 == 2)
								{
									if (237293 - 28784 != 208509)
									{
										continue;
									}
									Game.mNextGameCode = 33;
									if (220502 - 361582 == -141079)
									{
										continue;
									}
								}
								else if (this.$$switch$6607$38276 == 3)
								{
									if (233457 - 129923 != 103534)
									{
										continue;
									}
									Game.mNextGameCode = 34;
									if (215840 - 458092 != -242252)
									{
										continue;
									}
								}
								else if (this.$$switch$6607$38276 == 4)
								{
									if (136885 - 424749 != -287864)
									{
										continue;
									}
									Game.mNextGameCode = 35;
									if (87213 - 164279 != -77066)
									{
										continue;
									}
								}
								else if (this.$$switch$6607$38276 == 5)
								{
									if (27183 - 5878 == 21306)
									{
										continue;
									}
									Game.mNextGameCode = 36;
									if (14865 - 320230 != -305365)
									{
										continue;
									}
								}
								else
								{
									Game.mNextGameCode = 30;
									if (240710 - 439628 != -198918)
									{
										continue;
									}
								}
								this.$mGameGui$38277 = (GameGui)this.$self_$38278.GetComponent(typeof(GameGui));
								if (94969 - 517994 != -423024)
								{
									if (this.$mGameGui$38277)
									{
										if (29529 - 63106 != -33577)
										{
											continue;
										}
										this.$mGameGui$38277.close();
										if (154360 - 37116 != 117244)
										{
											continue;
										}
									}
									this.$self_$38278.SendMessage("fadeOut");
									if (178202 - 522955 != -344752)
									{
										goto Block_19;
									}
								}
							}
						}
					}
				}
				Block_16:
				goto IL_363;
				Block_19:
				return this.Yield(2, new WaitForSeconds((float)1));
				IL_363:
				return false;
			}

			// Token: 0x060078BD RID: 30909 RVA: 0x00FFCFB8 File Offset: 0x00FFB1B8
			internal static bool GXL6Y0pwLDbG13mTuDSF()
			{
				return true;
			}

			// Token: 0x060078BE RID: 30910 RVA: 0x00FFCFBC File Offset: 0x00FFB1BC
			internal static bool sQYgNwpwOlX5SrobqfmC()
			{
				return false;
			}

			// Token: 0x04007BAB RID: 31659
			internal int $$switch$6607$38276;

			// Token: 0x04007BAC RID: 31660
			internal GameGui $mGameGui$38277;

			// Token: 0x04007BAD RID: 31661
			internal M305_ItalusAcceptance1 $self_$38278;
		}
	}
}
