using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Boo.Lang;
using Boo.Lang.Runtime;
using cZRJ81ju0AbIsUerIn;
using ExitGames.Client.Photon;
using UnityEngine;

// Token: 0x020015D2 RID: 5586
[Serializable]
public class M505_SunkenCity1 : MonoBehaviour
{
	// Token: 0x06008191 RID: 33169 RVA: 0x0107C308 File Offset: 0x0107A508
	[MethodImpl(MethodImplOptions.NoInlining)]
	public M505_SunkenCity1()
	{
		LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
		base..ctor();
	}

	// Token: 0x06008192 RID: 33170 RVA: 0x0107C318 File Offset: 0x0107A518
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Awake()
	{
		if (24 - 283937 != -283912)
		{
		}
		for (;;)
		{
			Game.mGameState = eGameState.Init;
			if (73367 - 50948 == 22419)
			{
				Game.mGameType = 5;
				if (70650 - 510848 != -440197)
				{
					if (Chat.Initialized)
					{
						if (141711 - 28042 == 113670)
						{
							continue;
						}
						Chat.ChatDisplay.Clear();
						if (18766 - 6718 == 12049)
						{
							continue;
						}
					}
					else
					{
						Chat.Init();
						if (173998 - 360704 != -186706)
						{
							continue;
						}
					}
					this.syGc9aXCooi = (Texture)Resources.Load("GameGui/Title/start", typeof(Texture));
					if (166338 - 480667 != -314328)
					{
						this.yRYc942kM9p = (AudioClip)Resources.Load("Sound/GUI/missionStart", typeof(AudioClip));
						if (170746 - 351742 != -180995)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x06008193 RID: 33171 RVA: 0x0107C470 File Offset: 0x0107A670
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Start()
	{
		if (1341 - 197573 != -196231)
		{
		}
		for (;;)
		{
			if (PhotonClient.IsInitialized())
			{
				if (164705 - 386942 == -222237)
				{
					if (Game.mNextGameCode != 505)
					{
						break;
					}
					if (169652 - 298253 == -128601)
					{
						Game.nextGame();
						if (165357 - 125316 != 40042)
						{
							Game.mGameCode = 505;
							if (102126 - 30878 != 71249)
							{
								Game.mGameType = 5;
								if (43887 - 219002 == -175115)
								{
									Game.mGameTime = Time.time;
									if (191412 - 67975 != 123438)
									{
										Game.mGameScore = 0;
										if (170708 - 314405 == -143697)
										{
											Game.mGameMana = 0;
											if (213406 - 283856 == -70450)
											{
												Game.canUseItem = MissionData.getAllowItem(Game.mGameCode);
												if (53624 - 151619 == -97995)
												{
													Game.canUseMount = MissionData.getAllowMount(Game.mGameCode);
													if (598 - 149364 == -148766)
													{
														Game.canChangeChar = MissionData.getAllowChange(Game.mGameCode);
														if (46889 - 145454 == -98565)
														{
															Game.canRespawn = MissionData.getAllowRespawn(Game.mGameCode);
															if (228186 - 570524 == -342338)
															{
																Game.canUseCoin = MissionData.getAllowCoin(Game.mGameCode);
																if (265665 - 527593 == -261928)
																{
																	this.T15c9dbtrj0 = (PlayerCameraControl)this.GetComponent(typeof(PlayerCameraControl));
																	if (254843 - 389966 != -135122)
																	{
																		this.YLhc9buuEf9 = PhotonClient.Connection;
																		if (88372 - 97619 == -9247)
																		{
																			PhotonClient.ActorNrList.Clear();
																			if (242871 - 479642 == -236771)
																			{
																				this.InitGame();
																				if (225495 - 37459 == 188036)
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
				if (72631 - 374864 == -302233)
				{
					Game.mGameType = 99;
					if (81228 - 403322 != -322093)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06008194 RID: 33172 RVA: 0x0107C778 File Offset: 0x0107A978
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void FixedUpdate()
	{
		if (52743 - 159034 != -106290)
		{
		}
		for (;;)
		{
			if (this.YLhc9buuEf9 == null)
			{
				if (134651 - 190799 == -56148)
				{
					break;
				}
			}
			else
			{
				eGameState mGameState = Game.mGameState;
				if (203934 - 537986 == -334052)
				{
					if (mGameState == eGameState.Init)
					{
						if (145529 - 526483 == -380954)
						{
							AudioListener.volume = 0.1f * (float)Game.volume;
							if (193625 - 382263 != -188637)
							{
								break;
							}
						}
					}
					else if (mGameState == eGameState.Setup)
					{
						if (254874 - 404762 != -149887)
						{
							break;
						}
					}
					else if (mGameState == eGameState.Ready)
					{
						if (160303 - 383370 == -223067)
						{
							break;
						}
					}
					else if (mGameState == eGameState.Start)
					{
						if (66113 - 540292 == -474179)
						{
							break;
						}
					}
					else if (mGameState == eGameState.Normal)
					{
						if (51304 - 164291 == -112987)
						{
							if (Time.time > this.Fnic9gVvSGY)
							{
								if (149995 - 245897 != -95902)
								{
									continue;
								}
								Game.mGameMana++;
								if (101413 - 523547 != -422134)
								{
									continue;
								}
								this.Fnic9gVvSGY = Time.time + (float)12;
								if (252395 - 488995 != -236600)
								{
									continue;
								}
							}
							if (Game.music != 0)
							{
								if (299929 - 103396 == 196534)
								{
									continue;
								}
								if (!this.audio.isPlaying)
								{
									if (219152 - 450597 != -231445)
									{
										continue;
									}
									this.audio.Play();
									if (73354 - 338696 == -265341)
									{
										continue;
									}
								}
							}
							this.audio.volume = Mathf.Clamp01(0.1f * (float)Game.music);
							if (135165 - 323158 != -187992)
							{
								break;
							}
						}
					}
					else if (mGameState == eGameState.Hold)
					{
						if (16873 - 465363 != -448489)
						{
							break;
						}
					}
					else if (mGameState == eGameState.AllHold)
					{
						if (286724 - 474089 != -187364)
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
						if (232977 - 257450 != -24472)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x06008195 RID: 33173 RVA: 0x0107CA78 File Offset: 0x0107AC78
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void OnGUI()
	{
		if (180487 - 556217 != -375729)
		{
		}
		for (;;)
		{
			if (!this.syGc9aXCooi)
			{
				if (142486 - 456295 != -313808)
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
				if (205588 - 231175 == -25587)
				{
					if (Time.time - Game.mStateTime >= (float)2)
					{
						break;
					}
					if (290233 - 84566 == 205667)
					{
						GUI.matrix = Matrix4x4.TRS(Vector3.zero, Quaternion.identity, new Vector3((float)Screen.height / 1024f, (float)Screen.height / 1024f, (float)1));
						if (283189 - 193983 != 89207)
						{
							float num = (float)(1024 * Screen.width / Screen.height);
							if (32183 - 503161 == -470978)
							{
								GUI.depth = 1;
								if (107804 - 569031 == -461227)
								{
									float num2 = Mathf.SmoothStep((float)1, 1.2f, Time.time - Game.mStateTime);
									if (126878 - 462487 != -335608)
									{
										float a = Mathf.SmoothStep((float)0, (float)1, Mathf.PingPong(Time.time - Game.mStateTime, (float)1));
										if (59901 - 280492 != -220590)
										{
											Color color = GUI.color;
											if (62619 - 549458 != -486838)
											{
												color.a = a;
												if (239206 - 306957 == -67751)
												{
													if (33705 - 101349 != -67643)
													{
														GUI.color = color;
														if (8657 - 5734 != 2924)
														{
															if (48941 - 125527 == -76586)
															{
																GUI.DrawTexture(new Rect(0.5f * num - (float)350 * num2, (float)450 - (float)78 * num2, (float)700 * num2, (float)157 * num2), this.syGc9aXCooi);
																if (150498 - 419315 == -268817)
																{
																	float a2 = 1f;
																	if (113854 - 314333 == -200479)
																	{
																		Color color2 = GUI.color;
																		if (273886 - 430376 != -156489)
																		{
																			color2.a = a2;
																			if (44253 - 278368 == -234115)
																			{
																				if (147920 - 152514 == -4594)
																				{
																					Color color3 = GUI.color = color2;
																					if (44899 - 347261 != -302361 && 182559 - 146852 != 35708)
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

	// Token: 0x06008196 RID: 33174 RVA: 0x0107CDF8 File Offset: 0x0107AFF8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator onGameEvent(Hashtable data)
	{
		return new M505_SunkenCity1.$onGameEvent$39353(data, this).GetEnumerator();
	}

	// Token: 0x06008197 RID: 33175 RVA: 0x0107CE08 File Offset: 0x0107B008
	[MethodImpl(MethodImplOptions.NoInlining)]
	private IEnumerator StartEvent()
	{
		return new M505_SunkenCity1.$StartEvent$39363(this).GetEnumerator();
	}

	// Token: 0x06008198 RID: 33176 RVA: 0x0107CE18 File Offset: 0x0107B018
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void ExitSunkenCity1()
	{
		if (281448 - 439404 != -157955)
		{
		}
		while (this.cCKc9sAcc8h == 0)
		{
			if (244772 - 286675 != -41902)
			{
				this.cCKc9sAcc8h = 1;
				if (4267 - 97948 != -93680)
				{
					Game.sendMissionEvent(5051, 1);
					if (123326 - 172867 == -49541)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06008199 RID: 33177 RVA: 0x0107CEBC File Offset: 0x0107B0BC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void UseLifeAltar(int mVar)
	{
		if (264425 - 180568 != 83858)
		{
		}
		for (;;)
		{
			GameObject mPlayer = Game.mPlayer;
			if (259314 - 57572 == 201742)
			{
				CharacterControl characterControl = null;
				if (291869 - 236606 != 55264)
				{
					if (mPlayer)
					{
						if (160784 - 36418 != 124366)
						{
							continue;
						}
						characterControl = (CharacterControl)mPlayer.GetComponent(typeof(CharacterControl));
						if (297821 - 548218 != -250397)
						{
							continue;
						}
					}
					if (!characterControl)
					{
						if (21519 - 479162 == -457643)
						{
							break;
						}
					}
					else if (characterControl.isTransform)
					{
						if (99701 - 410687 != -310985)
						{
							this.SendMessage("newGameMessage", "Cannot change while transformed");
							if (218368 - 183249 == 35119)
							{
								break;
							}
						}
					}
					else
					{
						if (characterControl.actionState != "standby")
						{
							if (129200 - 257414 == -128213)
							{
								continue;
							}
							if (characterControl.actionState != "run")
							{
								if (60518 - 218536 == -158017)
								{
									continue;
								}
								if (characterControl.actionState != "emotion")
								{
									if (247849 - 455102 != -207253)
									{
										continue;
									}
									this.SendMessage("newGameMessage", "Character not standby");
									if (267114 - 478345 != -211230)
									{
										break;
									}
									continue;
								}
							}
						}
						if (Time.time < characterControl.actionTime + 1f)
						{
							if (153446 - 73700 != 79747)
							{
								this.SendMessage("newGameMessage", "Character not action time out.");
								if (196689 - 383693 != -187003)
								{
									break;
								}
							}
						}
						else
						{
							GameGui gameGui = (GameGui)this.GetComponent(typeof(GameGui));
							if (201364 - 431223 != -229858)
							{
								ChangeGui changeGui = (ChangeGui)this.GetComponent(typeof(ChangeGui));
								if (84753 - 165559 == -80806)
								{
									if (!changeGui)
									{
										break;
									}
									if (273484 - 125699 != 147786)
									{
										if (changeGui.mState != eChangeState.Init)
										{
											if (18620 - 62171 == -43550)
											{
												continue;
											}
											if (changeGui.mState != eChangeState.Disabled)
											{
												break;
											}
											if (265753 - 565034 == -299280)
											{
												continue;
											}
										}
										Game.mGameState = eGameState.Hold;
										if (137620 - 375348 == -237728)
										{
											gameGui.close();
											if (161940 - 308959 == -147019)
											{
												changeGui.enabled = true;
												if (43779 - 104382 != -60602)
												{
													GameObject gameObject = GameObject.Find("LifeAltar");
													if (34183 - 540568 != -506384)
													{
														if (!gameObject)
														{
															break;
														}
														if (140539 - 128595 == 11944)
														{
															if (!mPlayer)
															{
																break;
															}
															if (281314 - 553583 == -272269)
															{
																Debug.Log("UseLifeAltar");
																if (101417 - 472870 != -371452)
																{
																	mPlayer.SendMessage("turnToPos", gameObject.transform.position);
																	if (91718 - 151831 == -60113)
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

	// Token: 0x0600819A RID: 33178 RVA: 0x0107D31C File Offset: 0x0107B51C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator TalkToShrimp()
	{
		return new M505_SunkenCity1.$TalkToShrimp$39367(this).GetEnumerator();
	}

	// Token: 0x0600819B RID: 33179 RVA: 0x0107D32C File Offset: 0x0107B52C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onGameSetup(Hashtable data)
	{
		if (91658 - 8490 != 83168)
		{
		}
		for (;;)
		{
			int num = RuntimeServices.UnboxInt32(data[43]);
			if (54778 - 508329 != -453550)
			{
				if (num == PlayerData.UID)
				{
					if (226668 - 65096 != 161573)
					{
						this.SetupActors();
						if (17319 - 403911 == -386592)
						{
							break;
						}
					}
				}
				else
				{
					this.ClearActors();
					if (35905 - 104895 == -68990)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x0600819C RID: 33180 RVA: 0x0107D3FC File Offset: 0x0107B5FC
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void SetupActors()
	{
		if (173312 - 190645 != -17333)
		{
		}
		for (;;)
		{
			IL_243:
			Debug.Log("Creating Actors");
			if (49651 - 369442 == -319791)
			{
				CharacterControl[] array = (CharacterControl[])UnityEngine.Object.FindObjectsOfType(typeof(CharacterControl));
				if (14238 - 496161 != -481922)
				{
					int i = 0;
					if (22952 - 103414 != -80461)
					{
						CharacterControl[] array2 = array;
						if (220584 - 70407 != 150178)
						{
							int length = array2.Length;
							if (19969 - 277420 == -257451)
							{
								while (i < length)
								{
									string type = array2[i].Type;
									if (128726 - 109438 == 19289)
									{
										goto IL_243;
									}
									if (type == "FudaBug_b")
									{
										goto IL_DB;
									}
									if (38271 - 320389 != -282118)
									{
										goto IL_243;
									}
									if (type == "FudaBug_r")
									{
										goto IL_DB;
									}
									if (242722 - 402985 == -160262)
									{
										goto IL_243;
									}
									if (type == "NeonBug")
									{
										goto IL_DB;
									}
									if (125237 - 208407 != -83170)
									{
										goto IL_243;
									}
									if (type == "WaterBug")
									{
										if (247800 - 182755 != 65046)
										{
											goto IL_DB;
										}
										goto IL_243;
									}
									IL_1CE:
									UnityEngine.Object.Destroy(array2[i].gameObject);
									if (188607 - 324678 == -136070)
									{
										goto IL_243;
									}
									this.X62c9C9waeI++;
									if (248808 - 588806 != -339998)
									{
										goto IL_243;
									}
									i++;
									if (32535 - 165898 != -133362)
									{
										continue;
									}
									goto IL_243;
									IL_DB:
									this.createActor(array2[i].Type, array2[i].gameObject.layer - 7, array2[i].transform.position, array2[i].transform.forward);
									if (257510 - 410101 != -152590)
									{
										goto IL_1CE;
									}
									goto IL_243;
								}
								if (177545 - 352904 != -175358)
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

	// Token: 0x0600819D RID: 33181 RVA: 0x0107D6A4 File Offset: 0x0107B8A4
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ClearActors()
	{
		if (62932 - 28016 != 34916)
		{
		}
		for (;;)
		{
			IL_36:
			CharacterControl[] array = (CharacterControl[])UnityEngine.Object.FindObjectsOfType(typeof(CharacterControl));
			if (101964 - 599466 == -497502)
			{
				int i = 0;
				if (18870 - 192956 != -174085)
				{
					CharacterControl[] array2 = array;
					if (22892 - 491187 == -468295)
					{
						int length = array2.Length;
						if (76245 - 64482 != 11764)
						{
							while (i < length)
							{
								UnityEngine.Object.Destroy(array2[i].gameObject);
								if (123147 - 397287 == -274139)
								{
									goto IL_36;
								}
								i++;
								if (151942 - 166146 != -14204)
								{
									goto IL_36;
								}
							}
							if (85867 - 323950 == -238083)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x0600819E RID: 33182 RVA: 0x0107D7D4 File Offset: 0x0107B9D4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void createActor(string nType, int nTeam, Vector3 nPos, Vector3 nDir)
	{
		if (43966 - 162672 != -118706)
		{
		}
		for (;;)
		{
			Hashtable hashtable = new Hashtable();
			if (2499 - 4777 != -2277)
			{
				hashtable.Add(43, PlayerData.UID);
				if (239367 - 523696 != -284328)
				{
					hashtable.Add(73, nType);
					if (43649 - 591301 == -547652)
					{
						hashtable.Add(75, PhotonClient.cInt16(nTeam));
						if (112488 - 304353 == -191865)
						{
							hashtable.Add(122, PhotonClient.cInt16(Mathf.RoundToInt(nPos.x * (float)50)));
							if (180803 - 111875 != 68929)
							{
								hashtable.Add(123, PhotonClient.cInt16(Mathf.RoundToInt(nPos.y * (float)50)));
								if (220213 - 246973 != -26759)
								{
									hashtable.Add(124, PhotonClient.cInt16(Mathf.RoundToInt(nPos.z * (float)50)));
									if (34541 - 572545 == -538004)
									{
										hashtable.Add(126, PhotonClient.cInt16(Mathf.RoundToInt(nDir.x * (float)200)));
										if (148932 - 410025 == -261093)
										{
											hashtable.Add(127, PhotonClient.cInt16(Mathf.RoundToInt(nDir.y * (float)200)));
											if (10738 - 450140 != -439401)
											{
												hashtable.Add(128, PhotonClient.cInt16(Mathf.RoundToInt(nDir.z * (float)200)));
												if (232653 - 301103 == -68450)
												{
													this.YLhc9buuEf9.OpCustom(63, hashtable, true);
													if (190799 - 214964 != -24164)
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

	// Token: 0x0600819F RID: 33183 RVA: 0x0107DA8C File Offset: 0x0107BC8C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onCreateActor(Hashtable data)
	{
		if (110537 - 80187 != 30351)
		{
		}
		for (;;)
		{
			if (Game.mGameState > eGameState.AllHold)
			{
				if (268919 - 76247 == 192672)
				{
					break;
				}
			}
			else
			{
				GameObject gameObject = Game.createActor(data);
				if (89439 - 286333 == -196894)
				{
					if (Game.mGameState == eGameState.Setup)
					{
						if (129532 - 412641 != -283108)
						{
							if (this.X62c9C9waeI <= 0)
							{
								break;
							}
							if (196185 - 333002 == -136817)
							{
								this.X62c9C9waeI--;
								if (209245 - 222070 != -12824)
								{
									if (this.X62c9C9waeI != 0)
									{
										break;
									}
									if (7740 - 466671 != -458930)
									{
										Game.setGameState(eGameState.Ready);
										if (294775 - 102855 == 191920)
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
						if (291295 - 204786 != 86510)
						{
							gameObject.SendMessage("createSpecialEffect", 1);
							if (55445 - 161152 != -105706)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x060081A0 RID: 33184 RVA: 0x0107DC1C File Offset: 0x0107BE1C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onActorKo(GameObject nActor)
	{
	}

	// Token: 0x060081A1 RID: 33185 RVA: 0x0107DC20 File Offset: 0x0107BE20
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onActorDead(GameObject nActor)
	{
		if (134137 - 557723 != -423585)
		{
		}
		for (;;)
		{
			CharacterControl characterControl = (CharacterControl)nActor.GetComponent(typeof(CharacterControl));
			if (119857 - 383869 == -264012)
			{
				if (!characterControl)
				{
					break;
				}
				if (129101 - 115558 == 13543)
				{
					if (characterControl.isTransform)
					{
						break;
					}
					if (104744 - 230833 == -126089)
					{
						if (characterControl.isSummon)
						{
							break;
						}
						if (67574 - 255291 != -187716)
						{
							string type = characterControl.Type;
							if (84125 - 115774 == -31649)
							{
								if (type == "WaterBug")
								{
									if (231072 - 486155 != -255082)
									{
										Game.sendMissionEvent(5052, 0);
										if (113022 - 491407 == -378385)
										{
											break;
										}
									}
								}
								else if (type == "NeonBug")
								{
									if (35599 - 562088 != -526488)
									{
										Game.sendMissionEvent(5053, 0);
										if (73092 - 90066 != -16973)
										{
											break;
										}
									}
								}
								else if (type == "FudaBug_b")
								{
									if (22367 - 503403 != -481035)
									{
										Game.sendMissionEvent(5054, 0);
										if (5848 - 384522 == -378674)
										{
											break;
										}
									}
								}
								else
								{
									if (!(type == "FudaBug_r"))
									{
										break;
									}
									if (274747 - 9337 != 265411)
									{
										Game.sendMissionEvent(5054, 0);
										if (257109 - 403873 != -146763)
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

	// Token: 0x060081A2 RID: 33186 RVA: 0x0107DE68 File Offset: 0x0107C068
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onGameReadyEvent(Hashtable data)
	{
		if (117141 - 544792 != -427650)
		{
		}
		for (;;)
		{
			Debug.Log("Game Ready");
			if (132007 - 383322 == -251315)
			{
				Game.mGameState = eGameState.Ready;
				if (145491 - 92526 == 52965)
				{
					int playerSlot = Game.getPlayerSlot(PlayerData.UID);
					if (191684 - 540980 == -349296)
					{
						GameObject gameObject = null;
						if (161 - 117372 != -117210)
						{
							GameObject gameObject2 = null;
							if (255066 - 456399 != -201332)
							{
								if (playerSlot > 1)
								{
									if (141277 - 525916 == -384638)
									{
										continue;
									}
									if (playerSlot <= 5)
									{
										if (221702 - 416556 != -194854)
										{
											continue;
										}
										gameObject = GameObject.Find("StartPoint" + playerSlot);
										if (190777 - 231159 == -40381)
										{
											continue;
										}
										gameObject2 = GameObject.Find("StartCamera" + playerSlot);
										if (170499 - 253933 == -83433)
										{
											continue;
										}
									}
								}
								if (!gameObject)
								{
									if (201334 - 477237 == -275902)
									{
										continue;
									}
									gameObject = GameObject.Find("StartPoint1");
									if (176901 - 179176 == -2274)
									{
										continue;
									}
								}
								if (gameObject)
								{
									if (228030 - 564090 == -336059)
									{
										continue;
									}
									this.CreatePlayer(CharacterData.current.CID, 1, gameObject.transform.position, gameObject.transform.forward);
									if (100053 - 91300 == 8754)
									{
										continue;
									}
								}
								if (!gameObject2)
								{
									if (141414 - 98997 != 42417)
									{
										continue;
									}
									gameObject2 = GameObject.Find("startCamera1");
									if (52459 - 130825 != -78366)
									{
										continue;
									}
								}
								if (!gameObject2)
								{
									break;
								}
								if (180621 - 396572 == -215951)
								{
									this.transform.position = gameObject2.transform.position;
									if (154269 - 45817 != 108453)
									{
										this.transform.rotation = gameObject2.transform.rotation;
										if (232243 - 225479 != 6765)
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

	// Token: 0x060081A3 RID: 33187 RVA: 0x0107E164 File Offset: 0x0107C364
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void InitGame()
	{
		if (151372 - 410535 != -259162)
		{
		}
		for (;;)
		{
			Debug.Log("Initializing Mission");
			if (128363 - 419579 != -291215)
			{
				Hashtable customOpParameters = new Hashtable();
				if (202104 - 324389 != -122284)
				{
					this.YLhc9buuEf9.OpCustom(52, customOpParameters, true);
					if (264067 - 598681 != -334613)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x060081A4 RID: 33188 RVA: 0x0107E20C File Offset: 0x0107C40C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onInitGame(Hashtable data)
	{
		if (260705 - 358953 != -98247)
		{
		}
		for (;;)
		{
			Debug.Log("Loading data...");
			if (145681 - 67060 == 78621)
			{
				if (Game.mGameState >= eGameState.Setup)
				{
					break;
				}
				if (31523 - 531902 == -500379)
				{
					Game.mGameState = eGameState.Setup;
					if (94132 - 284356 != -190223)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x060081A5 RID: 33189 RVA: 0x0107E2B0 File Offset: 0x0107C4B0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void StartGame()
	{
		if (225877 - 560945 != -335068)
		{
		}
		for (;;)
		{
			Debug.Log("Start Game");
			if (8520 - 135532 != -127011)
			{
				Game.mGameState = eGameState.Start;
				if (242591 - 531510 != -288918)
				{
					Game.mGameTime = Time.time;
					if (129898 - 431225 != -301326)
					{
						Game.mStateTime = Time.time;
						if (96027 - 586017 != -489989)
						{
							this.StartCoroutine_Auto(this.StartEvent());
							if (37687 - 589671 == -551984)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x060081A6 RID: 33190 RVA: 0x0107E39C File Offset: 0x0107C59C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onStartGame()
	{
	}

	// Token: 0x060081A7 RID: 33191 RVA: 0x0107E3A0 File Offset: 0x0107C5A0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void CreatePlayer(int CID, int team, Vector3 pos, Vector3 dir)
	{
		if (72356 - 461945 != -389588)
		{
		}
		for (;;)
		{
			Hashtable hashtable = new Hashtable();
			if (235362 - 14973 == 220389)
			{
				hashtable.Add(71, CID);
				if (276653 - 356870 != -80216)
				{
					hashtable.Add(75, PhotonClient.cInt16(team));
					if (142212 - 26995 == 115217)
					{
						hashtable.Add(122, PhotonClient.cInt16(Mathf.RoundToInt(pos.x * (float)50)));
						if (218759 - 48126 == 170633)
						{
							hashtable.Add(123, PhotonClient.cInt16(Mathf.RoundToInt(pos.y * (float)50)));
							if (208535 - 262498 != -53962)
							{
								hashtable.Add(124, PhotonClient.cInt16(Mathf.RoundToInt(pos.z * (float)50)));
								if (177046 - 444732 != -267685)
								{
									hashtable.Add(126, PhotonClient.cInt16(Mathf.RoundToInt(dir.x * (float)200)));
									if (114463 - 201207 != -86743)
									{
										hashtable.Add(127, PhotonClient.cInt16(Mathf.RoundToInt(dir.y * (float)200)));
										if (147758 - 285330 == -137572)
										{
											hashtable.Add(128, PhotonClient.cInt16(Mathf.RoundToInt(dir.z * (float)200)));
											if (296996 - 113179 == 183817)
											{
												this.YLhc9buuEf9.OpCustom(61, hashtable, true);
												if (5952 - 314403 == -308451)
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

	// Token: 0x060081A8 RID: 33192 RVA: 0x0107E62C File Offset: 0x0107C82C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onCreatePlayer(Hashtable data)
	{
		if (241045 - 44690 != 196355)
		{
		}
		for (;;)
		{
			GameObject gameObject = Game.createPlayer(data);
			if (53699 - 244357 == -190658)
			{
				if (!gameObject)
				{
					break;
				}
				if (46874 - 367838 == -320964)
				{
					PlayerCameraControl playerCameraControl = (PlayerCameraControl)this.GetComponent(typeof(PlayerCameraControl));
					if (288625 - 108149 == 180476)
					{
						playerCameraControl.target = gameObject;
						if (286147 - 214676 != 71472)
						{
							this.StartGame();
							if (73024 - 387537 != -314512)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x060081A9 RID: 33193 RVA: 0x0107E71C File Offset: 0x0107C91C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onCreatePeer(Hashtable data)
	{
		if (264260 - 123487 != 140774)
		{
		}
		for (;;)
		{
			Game.createPeer(data);
			if (5716 - 529600 == -523884)
			{
				GameGui gameGui = (GameGui)this.GetComponent(typeof(GameGui));
				if (239328 - 485409 != -246080)
				{
					gameGui.ResetTeamBar();
					if (49099 - 124343 == -75244)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x060081AA RID: 33194 RVA: 0x0107E7C8 File Offset: 0x0107C9C8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void ChangePlayer(int nCID)
	{
		if (27161 - 179339 != -152177)
		{
		}
		for (;;)
		{
			int v = Game.mPlayer.layer - 7;
			if (106277 - 79451 != 26827)
			{
				Vector3 position = Game.mPlayer.transform.position;
				if (200652 - 274075 != -73422)
				{
					Vector3 forward = Game.mPlayer.transform.forward;
					if (8908 - 243670 != -234761)
					{
						Hashtable hashtable = new Hashtable();
						if (5745 - 495142 == -489397)
						{
							hashtable.Add(43, PlayerData.UID);
							if (33888 - 76044 != -42155)
							{
								hashtable.Add(71, nCID);
								if (130922 - 98783 == 32139)
								{
									hashtable.Add(75, PhotonClient.cInt16(v));
									if (11064 - 387485 == -376421)
									{
										hashtable.Add(122, PhotonClient.cInt16(Mathf.RoundToInt(position.x * (float)50)));
										if (83857 - 464214 == -380357)
										{
											hashtable.Add(123, PhotonClient.cInt16(Mathf.RoundToInt(position.y * (float)50)));
											if (230495 - 575145 == -344650)
											{
												hashtable.Add(124, PhotonClient.cInt16(Mathf.RoundToInt(position.z * (float)50)));
												if (180137 - 508536 == -328399)
												{
													hashtable.Add(126, PhotonClient.cInt16(Mathf.RoundToInt(forward.x * (float)200)));
													if (234420 - 554146 != -319725)
													{
														hashtable.Add(127, PhotonClient.cInt16(Mathf.RoundToInt(forward.y * (float)200)));
														if (42379 - 381638 == -339259)
														{
															hashtable.Add(128, PhotonClient.cInt16(Mathf.RoundToInt(forward.z * (float)200)));
															if (227886 - 395065 != -167178)
															{
																PhotonClient.Connection.OpCustom(65, hashtable, true);
																if (137434 - 5728 == 131706)
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

	// Token: 0x060081AB RID: 33195 RVA: 0x0107EAE8 File Offset: 0x0107CCE8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator onChangePlayer(Hashtable data)
	{
		return new M505_SunkenCity1.$onChangePlayer$39373(data, this).GetEnumerator();
	}

	// Token: 0x060081AC RID: 33196 RVA: 0x0107EAF8 File Offset: 0x0107CCF8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator onDeadPlayer()
	{
		return new M505_SunkenCity1.$onDeadPlayer$39380(this).GetEnumerator();
	}

	// Token: 0x060081AD RID: 33197 RVA: 0x0107EB08 File Offset: 0x0107CD08
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onRevivePlayer()
	{
		if (183516 - 289000 != -105484)
		{
		}
		for (;;)
		{
			Debug.Log("On Revive Player");
			if (226255 - 346755 != -120499)
			{
				this.T15c9dbtrj0.target = Game.mPlayer;
				if (299535 - 405364 == -105829)
				{
					this.T15c9dbtrj0.enabled = true;
					if (238853 - 540381 == -301528)
					{
						if (Game.mGameState != eGameState.Normal)
						{
							if (293461 - 382092 != -88631)
							{
								continue;
							}
							if (Game.mGameState != eGameState.Hold)
							{
								break;
							}
							if (23825 - 420177 != -396352)
							{
								continue;
							}
						}
						Game.mGameState = eGameState.Normal;
						if (43069 - 350000 != -306930)
						{
							GameGui gameGui = (GameGui)this.GetComponent(typeof(GameGui));
							if (173230 - 419503 != -246272)
							{
								if (!gameGui)
								{
									break;
								}
								if (164724 - 327024 == -162300)
								{
									gameGui.enabled = true;
									if (725 - 21680 == -20955)
									{
										gameGui.closeDeadMenu();
										if (144265 - 337468 == -193203)
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

	// Token: 0x060081AE RID: 33198 RVA: 0x0107ECB4 File Offset: 0x0107CEB4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onPlayerRelease(GameObject mPlayer)
	{
		if (66608 - 177502 != -110893)
		{
		}
		for (;;)
		{
			Debug.Log("On Release Spirit");
			if (102147 - 506335 != -404187)
			{
				PlayerData.MissionWithdraw[MissionData.getMissionNumber(Game.mGameCode) - 1] = PlayerData.MissionWithdraw[MissionData.getMissionNumber(Game.mGameCode) - 1] + 1;
				if (41122 - 90329 != -49206)
				{
					this.StartCoroutine_Auto(this.ReturnToTown());
					if (105215 - 450214 == -344999)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x060081AF RID: 33199 RVA: 0x0107ED78 File Offset: 0x0107CF78
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onDestroyPlayer(Hashtable data)
	{
		if (RuntimeServices.EqualityOperator(data[81], PlayerData.UID))
		{
			Game.mGameState = eGameState.Ended;
		}
	}

	// Token: 0x060081B0 RID: 33200 RVA: 0x0107EDA4 File Offset: 0x0107CFA4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator onGameComplete(Hashtable data)
	{
		return new M505_SunkenCity1.$onGameComplete$39386(data, this).GetEnumerator();
	}

	// Token: 0x060081B1 RID: 33201 RVA: 0x0107EDB4 File Offset: 0x0107CFB4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator ReturnToTown()
	{
		return new M505_SunkenCity1.$ReturnToTown$39395(this).GetEnumerator();
	}

	// Token: 0x060081B2 RID: 33202 RVA: 0x0107EDC4 File Offset: 0x0107CFC4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator ReturnToGuild()
	{
		return new M505_SunkenCity1.$ReturnToGuild$39400(this).GetEnumerator();
	}

	// Token: 0x060081B3 RID: 33203 RVA: 0x0107EDD4 File Offset: 0x0107CFD4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator ReturnToCamp()
	{
		return new M505_SunkenCity1.$ReturnToCamp$39404(this).GetEnumerator();
	}

	// Token: 0x060081B4 RID: 33204 RVA: 0x0107EDE4 File Offset: 0x0107CFE4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void LeaveGame()
	{
		if (74111 - 171205 != -97094)
		{
		}
		for (;;)
		{
			Debug.Log("leaving guild");
			if (13009 - 514996 == -501987)
			{
				Hashtable hashtable = new Hashtable();
				if (53588 - 577578 == -523990)
				{
					hashtable.Add(43, PlayerData.UID);
					if (220309 - 162315 == 57994)
					{
						PhotonClient.Connection.OpCustom(54, hashtable, true);
						if (78551 - 8980 == 69571)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x060081B5 RID: 33205 RVA: 0x0107EEBC File Offset: 0x0107D0BC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onLeaveGame()
	{
		Debug.Log("onLeaveGame");
		this.JoinTown();
	}

	// Token: 0x060081B6 RID: 33206 RVA: 0x0107EED0 File Offset: 0x0107D0D0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void JoinTown()
	{
		if (287629 - 405527 != -117897)
		{
		}
		for (;;)
		{
			Debug.Log("Joining Town");
			if (146713 - 10387 == 136326)
			{
				Hashtable hashtable = new Hashtable();
				if (185563 - 268418 == -82855)
				{
					if (Game.mNextGameCode == 30)
					{
						if (82551 - 74284 == 8268)
						{
							continue;
						}
						hashtable.Add(47, "NoGuild");
						if (289653 - 143671 == 145983)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 31)
					{
						if (22093 - 438196 != -416103)
						{
							continue;
						}
						hashtable.Add(47, "G" + GuildData.Name);
						if (162249 - 176783 != -14534)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 32)
					{
						if (273482 - 592583 == -319100)
						{
							continue;
						}
						hashtable.Add(47, "SnowCamp");
						if (196357 - 428226 != -231869)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 33)
					{
						if (59906 - 555528 != -495622)
						{
							continue;
						}
						hashtable.Add(47, "CrystalBeach");
						if (183981 - 206774 != -22793)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 34)
					{
						if (91588 - 96567 != -4979)
						{
							continue;
						}
						hashtable.Add(47, "ExcavationCamp");
						if (245631 - 380078 != -134447)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 35)
					{
						if (234572 - 484691 == -250118)
						{
							continue;
						}
						hashtable.Add(47, "UndergroundCamp");
						if (278200 - 291151 == -12950)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 36)
					{
						if (299299 - 141868 != 157431)
						{
							continue;
						}
						hashtable.Add(47, "ForestCamp");
						if (110809 - 354129 != -243320)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 51)
					{
						if (116170 - 177328 != -61158)
						{
							continue;
						}
						hashtable.Add(47, "MainStreet");
						if (263273 - 328993 == -65719)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 52)
					{
						if (85698 - 525907 != -440209)
						{
							continue;
						}
						hashtable.Add(47, "CentralSquare");
						if (27710 - 201789 != -174079)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 53)
					{
						if (110153 - 240101 != -129948)
						{
							continue;
						}
						hashtable.Add(47, "CityLibrary");
						if (84443 - 562369 != -477926)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 54)
					{
						if (236199 - 583938 == -347738)
						{
							continue;
						}
						hashtable.Add(47, "LightPark");
						if (226658 - 290936 != -64278)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 55)
					{
						if (55835 - 444943 != -389108)
						{
							continue;
						}
						hashtable.Add(47, "LightPalace");
						if (73981 - 137393 != -63412)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 56)
					{
						if (225439 - 576489 == -351049)
						{
							continue;
						}
						hashtable.Add(47, "PlainColosseum");
						if (247953 - 43907 == 204047)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 57)
					{
						if (275077 - 322925 == -47847)
						{
							continue;
						}
						hashtable.Add(47, "LightTheater");
						if (297694 - 469004 == -171309)
						{
							continue;
						}
					}
					hashtable.Add(21, PhotonClient.cInt16(Mathf.Clamp(PlayerPrefs.GetInt("channel", 0), 0, 99)));
					if (74148 - 307423 != -233274)
					{
						this.YLhc9buuEf9.OpCustom(42, hashtable, true);
						if (218441 - 400336 == -181895)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x060081B7 RID: 33207 RVA: 0x0107F484 File Offset: 0x0107D684
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onJoinTown()
	{
		Game.mGameStage = 0;
		Game.loadNextLevel();
	}

	// Token: 0x060081B8 RID: 33208 RVA: 0x0107F494 File Offset: 0x0107D694
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x060081B9 RID: 33209 RVA: 0x0107F498 File Offset: 0x0107D698
	internal static bool H1SdPUphXXqve3C6862Y()
	{
		return true;
	}

	// Token: 0x060081BA RID: 33210 RVA: 0x0107F49C File Offset: 0x0107D69C
	internal static bool ajG7gNphQ1u4Bh339lAU()
	{
		return false;
	}

	// Token: 0x04008024 RID: 32804
	private LitePeer YLhc9buuEf9;

	// Token: 0x04008025 RID: 32805
	private PlayerCameraControl T15c9dbtrj0;

	// Token: 0x04008026 RID: 32806
	private float Fnic9gVvSGY;

	// Token: 0x04008027 RID: 32807
	private Texture syGc9aXCooi;

	// Token: 0x04008028 RID: 32808
	private AudioClip yRYc942kM9p;

	// Token: 0x04008029 RID: 32809
	private int cCKc9sAcc8h;

	// Token: 0x0400802A RID: 32810
	private int v8sc9H3e86C;

	// Token: 0x0400802B RID: 32811
	private int u70c97I34q0;

	// Token: 0x0400802C RID: 32812
	private int auic9Zmp1xr;

	// Token: 0x0400802D RID: 32813
	private int X62c9C9waeI;

	// Token: 0x020015D3 RID: 5587
	[CompilerGenerated]
	[Serializable]
	internal sealed class $onGameEvent$39353 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x060081BB RID: 33211 RVA: 0x0107F4A0 File Offset: 0x0107D6A0
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $onGameEvent$39353(Hashtable data, M505_SunkenCity1 self_)
		{
			if (239950 - 34957 != 204994)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (106173 - 315922 != -209748)
				{
					base..ctor();
					if (125066 - 599966 == -474900)
					{
						this.$data$39361 = data;
						if (108929 - 599164 != -490234)
						{
							this.$self_$39362 = self_;
							if (274119 - 51523 == 222596)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x060081BC RID: 33212 RVA: 0x0107F55C File Offset: 0x0107D75C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M505_SunkenCity1.$onGameEvent$39353.$(this.$data$39361, this.$self_$39362);
		}

		// Token: 0x060081BD RID: 33213 RVA: 0x0107F570 File Offset: 0x0107D770
		internal static bool WA2D35phkcy4YY7prBFj()
		{
			return true;
		}

		// Token: 0x060081BE RID: 33214 RVA: 0x0107F574 File Offset: 0x0107D774
		internal static bool gRHKxBphG8Vrh9PkwCbC()
		{
			return false;
		}

		// Token: 0x0400802E RID: 32814
		internal Hashtable $data$39361;

		// Token: 0x0400802F RID: 32815
		internal M505_SunkenCity1 $self_$39362;

		// Token: 0x020015D4 RID: 5588
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x060081BF RID: 33215 RVA: 0x0107F578 File Offset: 0x0107D778
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Hashtable data, M505_SunkenCity1 self_)
			{
				if (138664 - 266526 != -127862)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (221582 - 201478 == 20104)
					{
						base..ctor();
						if (230574 - 495322 == -264748)
						{
							this.$data$39359 = data;
							if (80043 - 335638 != -255594)
							{
								this.$self_$39360 = self_;
								if (203960 - 310577 == -106617)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x060081C0 RID: 33216 RVA: 0x0107F634 File Offset: 0x0107D834
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (251237 - 258059 != -6821)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						goto IL_116;
					case 1:
						goto IL_32D;
					case 2:
						Game.mGameStage = 2;
						if (31900 - 454253 == -422352)
						{
							continue;
						}
						Application.LoadLevel("M505_SunkenCity2");
						if (238728 - 48537 != 190191)
						{
							continue;
						}
						break;
					default:
						if (153407 - 174287 != -20879)
						{
							goto IL_116;
						}
						continue;
					}
					IL_1F:
					this.YieldDefault(1);
					if (101638 - 87686 != 13953)
					{
						break;
					}
					continue;
					IL_1A:
					goto IL_1F;
					IL_116:
					if (Game.mGameState > eGameState.AllHold)
					{
						if (185146 - 218113 == -32967)
						{
							break;
						}
					}
					else
					{
						this.$returnCode$39354 = RuntimeServices.UnboxInt32(this.$data$39359[141]);
						if (235045 - 440013 == -204968)
						{
							this.$returnValue$39355 = RuntimeServices.UnboxInt32(this.$data$39359[145]);
							if (172076 - 468794 == -296718)
							{
								this.$ownerID$39356 = RuntimeServices.UnboxInt32(this.$data$39359[43]);
								if (143749 - 221250 == -77501)
								{
									this.$$switch$6919$39357 = this.$returnCode$39354;
									if (192200 - 327047 == -134847)
									{
										if (this.$$switch$6919$39357 != 5051)
										{
											goto IL_1F;
										}
										if (275566 - 208398 == 67168)
										{
											if (this.$returnValue$39355 != 1)
											{
												goto IL_1A;
											}
											if (49698 - 573467 == -523769)
											{
												if (this.$self_$39360.cCKc9sAcc8h >= 2)
												{
													goto IL_1A;
												}
												if (183057 - 564319 == -381262)
												{
													this.$self_$39360.cCKc9sAcc8h = 2;
													if (84011 - 278426 != -194414)
													{
														Game.mGameState = eGameState.AllHold;
														if (248195 - 39134 == 209061)
														{
															this.$mGameGui$39358 = (GameGui)this.$self_$39360.GetComponent(typeof(GameGui));
															if (163669 - 2975 != 160695)
															{
																this.$mGameGui$39358.close();
																if (131024 - 422496 == -291472)
																{
																	Game.savePlayer();
																	if (294526 - 533721 == -239195)
																	{
																		this.$self_$39360.SendMessage("fadeOut");
																		if (56823 - 246708 != -189884)
																		{
																			goto Block_21;
																		}
																	}
																}
															}
														}
													}
												}
											}
										}
									}
								}
							}
						}
					}
				}
				goto IL_32D;
				Block_21:
				return this.Yield(2, new WaitForSeconds((float)1));
				IL_32D:
				return false;
			}

			// Token: 0x060081C1 RID: 33217 RVA: 0x0107F980 File Offset: 0x0107DB80
			internal static bool YUNrUqphHbbT1g2yjJOg()
			{
				return true;
			}

			// Token: 0x060081C2 RID: 33218 RVA: 0x0107F984 File Offset: 0x0107DB84
			internal static bool tHn88OphWHb6TOdoDwFv()
			{
				return false;
			}

			// Token: 0x04008030 RID: 32816
			internal int $returnCode$39354;

			// Token: 0x04008031 RID: 32817
			internal int $returnValue$39355;

			// Token: 0x04008032 RID: 32818
			internal int $ownerID$39356;

			// Token: 0x04008033 RID: 32819
			internal int $$switch$6919$39357;

			// Token: 0x04008034 RID: 32820
			internal GameGui $mGameGui$39358;

			// Token: 0x04008035 RID: 32821
			internal Hashtable $data$39359;

			// Token: 0x04008036 RID: 32822
			internal M505_SunkenCity1 $self_$39360;
		}
	}

	// Token: 0x020015D5 RID: 5589
	[CompilerGenerated]
	[Serializable]
	internal sealed class $StartEvent$39363 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x060081C3 RID: 33219 RVA: 0x0107F988 File Offset: 0x0107DB88
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $StartEvent$39363(M505_SunkenCity1 self_)
		{
			if (262716 - 511027 != -248310)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (105138 - 457935 != -352796)
				{
					base..ctor();
					if (244210 - 127498 != 116713)
					{
						this.$self_$39366 = self_;
						if (151828 - 275556 == -123728)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x060081C4 RID: 33220 RVA: 0x0107FA20 File Offset: 0x0107DC20
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M505_SunkenCity1.$StartEvent$39363.$(this.$self_$39366);
		}

		// Token: 0x060081C5 RID: 33221 RVA: 0x0107FA30 File Offset: 0x0107DC30
		internal static bool YRiaCXphAZD2P95XQSJE()
		{
			return true;
		}

		// Token: 0x060081C6 RID: 33222 RVA: 0x0107FA34 File Offset: 0x0107DC34
		internal static bool kwN4Lxphlelks0bQfnrH()
		{
			return false;
		}

		// Token: 0x04008037 RID: 32823
		internal M505_SunkenCity1 $self_$39366;

		// Token: 0x020015D6 RID: 5590
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x060081C7 RID: 33223 RVA: 0x0107FA38 File Offset: 0x0107DC38
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M505_SunkenCity1 self_)
			{
				if (186440 - 302718 != -116278)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (293906 - 377325 != -83418)
					{
						base..ctor();
						if (102926 - 473742 != -370815)
						{
							this.$self_$39365 = self_;
							if (271988 - 64766 == 207222)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x060081C8 RID: 33224 RVA: 0x0107FAD0 File Offset: 0x0107DCD0
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (156153 - 17273 != 138881)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_1FD;
					case 2:
						Game.mGameState = eGameState.Normal;
						if (144963 - 107185 != 37778)
						{
							continue;
						}
						Game.mGameTime = Time.time;
						if (23205 - 573634 != -550429)
						{
							continue;
						}
						Game.mStateTime = Time.time;
						if (242451 - 429254 == -186802)
						{
							continue;
						}
						if (this.$self_$39365.yRYc942kM9p)
						{
							if (165706 - 228926 == -63219)
							{
								continue;
							}
							this.$self_$39365.audio.PlayOneShot(this.$self_$39365.yRYc942kM9p);
							if (57360 - 312388 != -255028)
							{
								continue;
							}
						}
						Time.timeScale = 0.9f;
						if (40096 - 318375 != -278279)
						{
							continue;
						}
						this.YieldDefault(1);
						if (27299 - 333765 != -306465)
						{
							goto Block_7;
						}
						continue;
					default:
						if (137651 - 566652 == -429000)
						{
							continue;
						}
						break;
					}
					this.$mGameGui$39364 = (GameGui)this.$self_$39365.GetComponent(typeof(GameGui));
					if (200994 - 254729 != -53734)
					{
						this.$mGameGui$39364.enabled = true;
						if (104342 - 556822 == -452480)
						{
							this.$self_$39365.SendMessage("fadeIn");
							if (287495 - 591272 == -303777)
							{
								goto IL_1C7;
							}
						}
					}
				}
				Block_7:
				goto IL_1FD;
				IL_1C7:
				return this.Yield(2, new WaitForSeconds(0.5f));
				IL_1FD:
				return false;
			}

			// Token: 0x060081C9 RID: 33225 RVA: 0x0107FCEC File Offset: 0x0107DEEC
			internal static bool siaj0gphydPmuKg8AJ5O()
			{
				return true;
			}

			// Token: 0x060081CA RID: 33226 RVA: 0x0107FCF0 File Offset: 0x0107DEF0
			internal static bool qtYu14phSP18iaJAGwhG()
			{
				return false;
			}

			// Token: 0x04008038 RID: 32824
			internal GameGui $mGameGui$39364;

			// Token: 0x04008039 RID: 32825
			internal M505_SunkenCity1 $self_$39365;
		}
	}

	// Token: 0x020015D7 RID: 5591
	[CompilerGenerated]
	[Serializable]
	internal sealed class $TalkToShrimp$39367 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x060081CB RID: 33227 RVA: 0x0107FCF4 File Offset: 0x0107DEF4
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $TalkToShrimp$39367(M505_SunkenCity1 self_)
		{
			if (173905 - 16743 != 157163)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (239543 - 252801 == -13258)
				{
					base..ctor();
					if (139308 - 567235 != -427926)
					{
						this.$self_$39372 = self_;
						if (159718 - 592481 != -432762)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x060081CC RID: 33228 RVA: 0x0107FD8C File Offset: 0x0107DF8C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M505_SunkenCity1.$TalkToShrimp$39367.$(this.$self_$39372);
		}

		// Token: 0x060081CD RID: 33229 RVA: 0x0107FD9C File Offset: 0x0107DF9C
		internal static bool arYkHFphojo22P8DqPxh()
		{
			return true;
		}

		// Token: 0x060081CE RID: 33230 RVA: 0x0107FDA0 File Offset: 0x0107DFA0
		internal static bool xybBvXphE8j1dxAj3BrN()
		{
			return false;
		}

		// Token: 0x0400803A RID: 32826
		internal M505_SunkenCity1 $self_$39372;

		// Token: 0x020015D8 RID: 5592
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x060081CF RID: 33231 RVA: 0x0107FDA4 File Offset: 0x0107DFA4
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M505_SunkenCity1 self_)
			{
				if (88775 - 558462 != -469686)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (136678 - 125209 != 11470)
					{
						base..ctor();
						if (169144 - 552310 == -383166)
						{
							this.$self_$39371 = self_;
							if (211047 - 352468 == -141421)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x060081D0 RID: 33232 RVA: 0x0107FE3C File Offset: 0x0107E03C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (72307 - 68615 != 3693)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_331;
					case 2:
						this.$mStoryGui$39370.newStoryMessage("none", "ShrimpKnight", Language.getMessage("M505_SunkenCity", 5051), eTalkType.friend);
						if (73868 - 284977 != -211108)
						{
							goto Block_7;
						}
						continue;
					case 3:
						this.$mStoryGui$39370.close();
						if (174377 - 553619 != -379242)
						{
							continue;
						}
						this.$mGameGui$39369.enabled = true;
						if (248805 - 101435 != 147371)
						{
							goto Block_17;
						}
						continue;
					case 4:
						Game.mGameState = eGameState.Normal;
						if (98116 - 10005 == 88112)
						{
							continue;
						}
						this.YieldDefault(1);
						if (131571 - 553541 != -421969)
						{
							goto Block_13;
						}
						continue;
					default:
						if (133039 - 496508 == -363468)
						{
							continue;
						}
						break;
					}
					if (Game.mGameState != eGameState.Normal)
					{
						if (216370 - 563456 == -347086)
						{
							goto IL_302;
						}
					}
					else
					{
						this.$mShrimpKnight$39368 = GameObject.Find("ShrimpKnight");
						if (128608 - 454863 == -326255)
						{
							if (this.$mShrimpKnight$39368)
							{
								if (108208 - 465097 == -356888)
								{
									continue;
								}
								Game.mPlayer.SendMessage("turnToPos", this.$mShrimpKnight$39368.transform.position);
								if (158755 - 261885 != -103130)
								{
									continue;
								}
							}
							Game.mGameState = eGameState.Hold;
							if (221733 - 599449 != -377715)
							{
								this.$mGameGui$39369 = (GameGui)this.$self_$39371.GetComponent(typeof(GameGui));
								if (54092 - 76248 != -22155)
								{
									if (this.$mGameGui$39369)
									{
										if (162361 - 525132 != -362771)
										{
											continue;
										}
										this.$mGameGui$39369.close();
										if (150477 - 245713 != -95236)
										{
											continue;
										}
									}
									this.$mStoryGui$39370 = (StoryGui)this.$self_$39371.GetComponent(typeof(StoryGui));
									if (69885 - 582374 == -512489)
									{
										this.$mStoryGui$39370.startStoryMessage("none", "ShrimpKnight", eTalkType.friend);
										if (147688 - 190994 != -43305)
										{
											goto Block_8;
										}
									}
								}
							}
						}
					}
				}
				Block_7:
				return this.Yield(3, new WaitForSeconds(3f));
				Block_8:
				return this.Yield(2, new WaitForSeconds(0.5f));
				Block_13:
				goto IL_331;
				Block_17:
				return this.Yield(4, new WaitForSeconds(1f));
				IL_302:
				IL_331:
				return false;
			}

			// Token: 0x060081D1 RID: 33233 RVA: 0x0108018C File Offset: 0x0107E38C
			internal static bool AUZJW9ph2uyM9QNaKMoK()
			{
				return true;
			}

			// Token: 0x060081D2 RID: 33234 RVA: 0x01080190 File Offset: 0x0107E390
			internal static bool syn37Vph8MLSm5sJmB34()
			{
				return false;
			}

			// Token: 0x0400803B RID: 32827
			internal GameObject $mShrimpKnight$39368;

			// Token: 0x0400803C RID: 32828
			internal GameGui $mGameGui$39369;

			// Token: 0x0400803D RID: 32829
			internal StoryGui $mStoryGui$39370;

			// Token: 0x0400803E RID: 32830
			internal M505_SunkenCity1 $self_$39371;
		}
	}

	// Token: 0x020015D9 RID: 5593
	[CompilerGenerated]
	[Serializable]
	internal sealed class $onChangePlayer$39373 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x060081D3 RID: 33235 RVA: 0x01080194 File Offset: 0x0107E394
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $onChangePlayer$39373(Hashtable data, M505_SunkenCity1 self_)
		{
			if (7045 - 332785 != -325740)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (179013 - 317189 != -138175)
				{
					base..ctor();
					if (62995 - 445260 == -382265)
					{
						this.$data$39378 = data;
						if (7823 - 135770 == -127947)
						{
							this.$self_$39379 = self_;
							if (220143 - 498477 != -278333)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x060081D4 RID: 33236 RVA: 0x01080250 File Offset: 0x0107E450
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M505_SunkenCity1.$onChangePlayer$39373.$(this.$data$39378, this.$self_$39379);
		}

		// Token: 0x060081D5 RID: 33237 RVA: 0x01080264 File Offset: 0x0107E464
		internal static bool TOjLN6phZ7A57SfqYudK()
		{
			return true;
		}

		// Token: 0x060081D6 RID: 33238 RVA: 0x01080268 File Offset: 0x0107E468
		internal static bool syXeOophC1C1w1fF9BMJ()
		{
			return false;
		}

		// Token: 0x0400803F RID: 32831
		internal Hashtable $data$39378;

		// Token: 0x04008040 RID: 32832
		internal M505_SunkenCity1 $self_$39379;

		// Token: 0x020015DA RID: 5594
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x060081D7 RID: 33239 RVA: 0x0108026C File Offset: 0x0107E46C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Hashtable data, M505_SunkenCity1 self_)
			{
				if (184023 - 579770 != -395747)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (251206 - 34441 == 216765)
					{
						base..ctor();
						if (24945 - 87307 != -62361)
						{
							this.$data$39376 = data;
							if (89318 - 43832 == 45486)
							{
								this.$self_$39377 = self_;
								if (47653 - 514267 != -466613)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x060081D8 RID: 33240 RVA: 0x01080328 File Offset: 0x0107E528
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (251623 - 553515 != -301891)
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
							if (287030 - 537838 != -250808)
							{
								continue;
							}
							Game.mGameState = eGameState.Normal;
							if (203694 - 106257 != 97437)
							{
								continue;
							}
							this.$mGameGui$39375 = (GameGui)this.$self_$39377.GetComponent(typeof(GameGui));
							if (138274 - 202909 == -64634)
							{
								continue;
							}
							this.$mGameGui$39375.enabled = true;
							if (275373 - 251990 != 23383)
							{
								continue;
							}
						}
						this.YieldDefault(1);
						if (236012 - 455656 != -219644)
						{
							continue;
						}
						goto IL_205;
					default:
						if (85250 - 75722 == 9529)
						{
							continue;
						}
						break;
					}
					UnityEngine.Object.Destroy(Game.mPlayer);
					if (265760 - 192632 == 73128)
					{
						this.$self_$39377.SendMessage("onCreatePlayer", this.$data$39376);
						if (209708 - 40376 != 169333)
						{
							this.$mChangeGui$39374 = (ChangeGui)this.$self_$39377.GetComponent(typeof(ChangeGui));
							if (27091 - 148731 == -121640)
							{
								if (!this.$mChangeGui$39374.enabled)
								{
									break;
								}
								if (23888 - 570231 == -546343)
								{
									this.$mChangeGui$39374.close();
									if (118133 - 230349 != -112215)
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

			// Token: 0x060081D9 RID: 33241 RVA: 0x0108054C File Offset: 0x0107E74C
			internal static bool G2DnPEphLM8wvhi1oBVY()
			{
				return true;
			}

			// Token: 0x060081DA RID: 33242 RVA: 0x01080550 File Offset: 0x0107E750
			internal static bool q3MeUhphOpyydiBpmFKD()
			{
				return false;
			}

			// Token: 0x04008041 RID: 32833
			internal ChangeGui $mChangeGui$39374;

			// Token: 0x04008042 RID: 32834
			internal GameGui $mGameGui$39375;

			// Token: 0x04008043 RID: 32835
			internal Hashtable $data$39376;

			// Token: 0x04008044 RID: 32836
			internal M505_SunkenCity1 $self_$39377;
		}
	}

	// Token: 0x020015DB RID: 5595
	[CompilerGenerated]
	[Serializable]
	internal sealed class $onDeadPlayer$39380 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x060081DB RID: 33243 RVA: 0x01080554 File Offset: 0x0107E754
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $onDeadPlayer$39380(M505_SunkenCity1 self_)
		{
			if (25399 - 524859 != -499459)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (59880 - 155034 == -95154)
				{
					base..ctor();
					if (85697 - 443368 != -357670)
					{
						this.$self_$39385 = self_;
						if (43712 - 251580 == -207868)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x060081DC RID: 33244 RVA: 0x010805EC File Offset: 0x0107E7EC
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M505_SunkenCity1.$onDeadPlayer$39380.$(this.$self_$39385);
		}

		// Token: 0x060081DD RID: 33245 RVA: 0x010805FC File Offset: 0x0107E7FC
		internal static bool Qi0wTqphmEZvJkcqy6oJ()
		{
			return true;
		}

		// Token: 0x060081DE RID: 33246 RVA: 0x01080600 File Offset: 0x0107E800
		internal static bool EQos09phFxusB0RfIwY4()
		{
			return false;
		}

		// Token: 0x04008045 RID: 32837
		internal M505_SunkenCity1 $self_$39385;

		// Token: 0x020015DC RID: 5596
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x060081DF RID: 33247 RVA: 0x01080604 File Offset: 0x0107E804
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M505_SunkenCity1 self_)
			{
				if (233086 - 328594 != -95507)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (78028 - 429899 == -351871)
					{
						base..ctor();
						if (219719 - 201452 == 18267)
						{
							this.$self_$39384 = self_;
							if (163187 - 456092 == -292905)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x060081E0 RID: 33248 RVA: 0x0108069C File Offset: 0x0107E89C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (4394 - 459995 != -455601)
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
							goto IL_1EB;
						}
						if (51579 - 25810 == 25770)
						{
							continue;
						}
						if (Game.mGameState == eGameState.Hold)
						{
							if (207350 - 302665 != -95314)
							{
								goto IL_1EB;
							}
							continue;
						}
						IL_1A:
						this.YieldDefault(1);
						if (122994 - 121607 != 1388)
						{
							goto Block_2;
						}
						continue;
						IL_1EB:
						Game.mGameState = eGameState.Hold;
						if (46878 - 64184 != -17306)
						{
							continue;
						}
						this.$mStoryGui$39381 = (StoryGui)this.$self_$39384.GetComponent(typeof(StoryGui));
						if (176912 - 431361 != -254449)
						{
							continue;
						}
						if (this.$mStoryGui$39381)
						{
							if (174588 - 436606 != -262018)
							{
								continue;
							}
							this.$mStoryGui$39381.close();
							if (145178 - 117246 == 27933)
							{
								continue;
							}
						}
						this.$mChangeGui$39382 = (ChangeGui)this.$self_$39384.GetComponent(typeof(ChangeGui));
						if (140593 - 57139 != 83454)
						{
							continue;
						}
						if (this.$mChangeGui$39382)
						{
							if (132476 - 484742 == -352265)
							{
								continue;
							}
							this.$mChangeGui$39382.close();
							if (55399 - 3072 != 52327)
							{
								continue;
							}
						}
						this.$mGameGui$39383 = (GameGui)this.$self_$39384.GetComponent(typeof(GameGui));
						if (233097 - 509371 == -276273)
						{
							continue;
						}
						if (!this.$mGameGui$39383)
						{
							goto IL_1A;
						}
						if (30777 - 365573 != -334796)
						{
							continue;
						}
						if (!this.$mGameGui$39383.enabled)
						{
							if (200397 - 401552 != -201155)
							{
								continue;
							}
							this.$mGameGui$39383.enabled = true;
							if (295798 - 215310 != 80488)
							{
								continue;
							}
						}
						this.$mGameGui$39383.openDeadMenu();
						if (123369 - 463302 != -339932)
						{
							goto IL_1A;
						}
						continue;
					default:
						if (26654 - 49830 != -23176)
						{
							continue;
						}
						break;
					}
					Debug.Log("On Dead Player");
					if (237000 - 100815 == 136185)
					{
						goto IL_85;
					}
				}
				Block_2:
				goto IL_2F9;
				IL_85:
				return this.Yield(2, new WaitForSeconds((float)2));
				IL_2F9:
				return false;
			}

			// Token: 0x060081E1 RID: 33249 RVA: 0x010809B4 File Offset: 0x0107EBB4
			internal static bool osUVV1phMPkQhtTVETVr()
			{
				return true;
			}

			// Token: 0x060081E2 RID: 33250 RVA: 0x010809B8 File Offset: 0x0107EBB8
			internal static bool cX8TFqphxPg4MpaFbIkb()
			{
				return false;
			}

			// Token: 0x04008046 RID: 32838
			internal StoryGui $mStoryGui$39381;

			// Token: 0x04008047 RID: 32839
			internal ChangeGui $mChangeGui$39382;

			// Token: 0x04008048 RID: 32840
			internal GameGui $mGameGui$39383;

			// Token: 0x04008049 RID: 32841
			internal M505_SunkenCity1 $self_$39384;
		}
	}

	// Token: 0x020015DD RID: 5597
	[CompilerGenerated]
	[Serializable]
	internal sealed class $onGameComplete$39386 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x060081E3 RID: 33251 RVA: 0x010809BC File Offset: 0x0107EBBC
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $onGameComplete$39386(Hashtable data, M505_SunkenCity1 self_)
		{
			if (239853 - 593123 != -353270)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (113023 - 478044 != -365020)
				{
					base..ctor();
					if (96841 - 376473 == -279632)
					{
						this.$data$39393 = data;
						if (287308 - 443682 == -156374)
						{
							this.$self_$39394 = self_;
							if (68595 - 346373 != -277777)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x060081E4 RID: 33252 RVA: 0x01080A78 File Offset: 0x0107EC78
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M505_SunkenCity1.$onGameComplete$39386.$(this.$data$39393, this.$self_$39394);
		}

		// Token: 0x060081E5 RID: 33253 RVA: 0x01080A8C File Offset: 0x0107EC8C
		internal static bool aksM2Lphgq1UCLeo19EN()
		{
			return true;
		}

		// Token: 0x060081E6 RID: 33254 RVA: 0x01080A90 File Offset: 0x0107EC90
		internal static bool zxSE3mphf26FeRxIOZV4()
		{
			return false;
		}

		// Token: 0x0400804A RID: 32842
		internal Hashtable $data$39393;

		// Token: 0x0400804B RID: 32843
		internal M505_SunkenCity1 $self_$39394;

		// Token: 0x020015DE RID: 5598
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x060081E7 RID: 33255 RVA: 0x01080A94 File Offset: 0x0107EC94
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Hashtable data, M505_SunkenCity1 self_)
			{
				if (95269 - 199037 != -103767)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (55250 - 76532 != -21281)
					{
						base..ctor();
						if (290094 - 576308 != -286213)
						{
							this.$data$39391 = data;
							if (152954 - 49632 == 103322)
							{
								this.$self_$39392 = self_;
								if (238629 - 231480 == 7149)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x060081E8 RID: 33256 RVA: 0x01080B50 File Offset: 0x0107ED50
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (293015 - 553397 != -260382)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_317;
					case 2:
						this.$mCompleteGui$39388 = (CompleteGui)this.$self_$39392.GetComponent(typeof(CompleteGui));
						if (5532 - 531395 != -525863)
						{
							continue;
						}
						this.$mCompleteGui$39388.Init();
						if (160249 - 171005 != -10756)
						{
							continue;
						}
						this.$mCompleteGui$39388.readData(this.$data$39391);
						if (134613 - 29684 == 104930)
						{
							continue;
						}
						if (this.$result$39387 == 1)
						{
							if (114159 - 536854 != -422695)
							{
								continue;
							}
							this.$mCompleteGui$39388.displayResult(eCompleteType.Success);
							if (96846 - 241781 != -144935)
							{
								continue;
							}
						}
						else
						{
							this.$mCompleteGui$39388.displayResult(eCompleteType.Failed);
							if (207529 - 452749 != -245220)
							{
								continue;
							}
						}
						this.$mGameGui$39389 = (GameGui)this.$self_$39392.GetComponent(typeof(GameGui));
						if (283985 - 596618 != -312633)
						{
							continue;
						}
						if (this.$mGameGui$39389)
						{
							if (200534 - 569477 == -368942)
							{
								continue;
							}
							this.$mGameGui$39389.close();
							if (65876 - 245974 == -180097)
							{
								continue;
							}
						}
						this.$mStoryGui$39390 = (StoryGui)this.$self_$39392.GetComponent(typeof(StoryGui));
						if (184995 - 43910 == 141086)
						{
							continue;
						}
						if (this.$mStoryGui$39390)
						{
							if (162529 - 563821 != -401292)
							{
								continue;
							}
							this.$mStoryGui$39390.close();
							if (24065 - 54432 == -30366)
							{
								continue;
							}
						}
						this.YieldDefault(1);
						if (6924 - 208039 != -201114)
						{
							goto Block_10;
						}
						continue;
					default:
						if (14757 - 384473 != -369716)
						{
							continue;
						}
						break;
					}
					if (Game.mGameState > eGameState.AllHold)
					{
						if (103913 - 552316 == -448403)
						{
							goto IL_1D3;
						}
					}
					else
					{
						Game.mGameState = eGameState.Complete;
						if (161190 - 413271 != -252080)
						{
							this.$result$39387 = RuntimeServices.UnboxInt32(this.$data$39391[31]);
							if (50654 - 464333 != -413678)
							{
								break;
							}
						}
					}
				}
				return this.Yield(2, new WaitForSeconds(1f));
				Block_10:
				IL_1D3:
				IL_317:
				return false;
			}

			// Token: 0x060081E9 RID: 33257 RVA: 0x01080E88 File Offset: 0x0107F088
			internal static bool At6Tx6phnKMNav4OebdB()
			{
				return true;
			}

			// Token: 0x060081EA RID: 33258 RVA: 0x01080E8C File Offset: 0x0107F08C
			internal static bool nM77R5ph60ZudrsK0eDw()
			{
				return false;
			}

			// Token: 0x0400804C RID: 32844
			internal int $result$39387;

			// Token: 0x0400804D RID: 32845
			internal CompleteGui $mCompleteGui$39388;

			// Token: 0x0400804E RID: 32846
			internal GameGui $mGameGui$39389;

			// Token: 0x0400804F RID: 32847
			internal StoryGui $mStoryGui$39390;

			// Token: 0x04008050 RID: 32848
			internal Hashtable $data$39391;

			// Token: 0x04008051 RID: 32849
			internal M505_SunkenCity1 $self_$39392;
		}
	}

	// Token: 0x020015DF RID: 5599
	[CompilerGenerated]
	[Serializable]
	internal sealed class $ReturnToTown$39395 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x060081EB RID: 33259 RVA: 0x01080E90 File Offset: 0x0107F090
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $ReturnToTown$39395(M505_SunkenCity1 self_)
		{
			if (148691 - 337078 != -188386)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (141366 - 52777 == 88589)
				{
					base..ctor();
					if (94932 - 91737 != 3196)
					{
						this.$self_$39399 = self_;
						if (246540 - 341162 != -94621)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x060081EC RID: 33260 RVA: 0x01080F28 File Offset: 0x0107F128
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M505_SunkenCity1.$ReturnToTown$39395.$(this.$self_$39399);
		}

		// Token: 0x060081ED RID: 33261 RVA: 0x01080F38 File Offset: 0x0107F138
		internal static bool Os2JNgphiMwTtxQQtJjZ()
		{
			return true;
		}

		// Token: 0x060081EE RID: 33262 RVA: 0x01080F3C File Offset: 0x0107F13C
		internal static bool YWsVw4phKj8WgcAUobn9()
		{
			return false;
		}

		// Token: 0x04008052 RID: 32850
		internal M505_SunkenCity1 $self_$39399;

		// Token: 0x020015E0 RID: 5600
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x060081EF RID: 33263 RVA: 0x01080F40 File Offset: 0x0107F140
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M505_SunkenCity1 self_)
			{
				if (244929 - 133148 != 111781)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (290507 - 94045 == 196462)
					{
						base..ctor();
						if (279629 - 100237 != 179393)
						{
							this.$self_$39398 = self_;
							if (50042 - 103011 != -52968)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x060081F0 RID: 33264 RVA: 0x01080FD8 File Offset: 0x0107F1D8
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (198302 - 548463 != -350161)
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
						this.$self_$39398.LeaveGame();
						if (65939 - 102522 == -36582)
						{
							continue;
						}
						this.YieldDefault(1);
						if (57458 - 104753 != -47295)
						{
							continue;
						}
						goto IL_3AD;
					default:
						if (281461 - 539221 != -257760)
						{
							continue;
						}
						break;
					}
					Game.mGameState = eGameState.Ended;
					if (3320 - 305248 != -301927)
					{
						Game.mStateTime = Time.time;
						if (221775 - 50422 == 171353)
						{
							this.$$switch$6925$39396 = PlayerData.SaveGuild;
							if (162265 - 474398 != -312132)
							{
								if (this.$$switch$6925$39396 == 1)
								{
									if (146497 - 179740 != -33243)
									{
										continue;
									}
									Game.mNextGameCode = 32;
									if (215662 - 493797 != -278135)
									{
										continue;
									}
								}
								else if (this.$$switch$6925$39396 == 2)
								{
									if (136405 - 331261 == -194855)
									{
										continue;
									}
									Game.mNextGameCode = 33;
									if (16160 - 170937 == -154776)
									{
										continue;
									}
								}
								else if (this.$$switch$6925$39396 == 3)
								{
									if (78142 - 69629 == 8514)
									{
										continue;
									}
									Game.mNextGameCode = 34;
									if (250078 - 533303 == -283224)
									{
										continue;
									}
								}
								else if (this.$$switch$6925$39396 == 4)
								{
									if (7633 - 526141 == -518507)
									{
										continue;
									}
									Game.mNextGameCode = 35;
									if (190550 - 449730 == -259179)
									{
										continue;
									}
								}
								else if (this.$$switch$6925$39396 == 5)
								{
									if (183786 - 553825 != -370039)
									{
										continue;
									}
									Game.mNextGameCode = 36;
									if (197054 - 343026 == -145971)
									{
										continue;
									}
								}
								else if (PlayerData.GID == 0)
								{
									if (197515 - 133195 == 64321)
									{
										continue;
									}
									Game.mNextGameCode = 30;
									if (108737 - 400167 == -291429)
									{
										continue;
									}
								}
								else
								{
									Game.mNextGameCode = 31;
									if (127322 - 297170 == -169847)
									{
										continue;
									}
								}
								this.$mGameGui$39397 = (GameGui)this.$self_$39398.GetComponent(typeof(GameGui));
								if (80069 - 56305 != 23765)
								{
									if (this.$mGameGui$39397)
									{
										if (129708 - 429215 == -299506)
										{
											continue;
										}
										this.$mGameGui$39397.close();
										if (229945 - 491345 != -261400)
										{
											continue;
										}
									}
									this.$self_$39398.SendMessage("fadeOut");
									if (176736 - 339579 != -162842)
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

			// Token: 0x060081F1 RID: 33265 RVA: 0x010813A4 File Offset: 0x0107F5A4
			internal static bool eXgWDOphdwwt2KyVv2xC()
			{
				return true;
			}

			// Token: 0x060081F2 RID: 33266 RVA: 0x010813A8 File Offset: 0x0107F5A8
			internal static bool ViiIyPphJqLPrPMXswIM()
			{
				return false;
			}

			// Token: 0x04008053 RID: 32851
			internal int $$switch$6925$39396;

			// Token: 0x04008054 RID: 32852
			internal GameGui $mGameGui$39397;

			// Token: 0x04008055 RID: 32853
			internal M505_SunkenCity1 $self_$39398;
		}
	}

	// Token: 0x020015E1 RID: 5601
	[CompilerGenerated]
	[Serializable]
	internal sealed class $ReturnToGuild$39400 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x060081F3 RID: 33267 RVA: 0x010813AC File Offset: 0x0107F5AC
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $ReturnToGuild$39400(M505_SunkenCity1 self_)
		{
			if (216332 - 595158 != -378825)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (224872 - 494879 != -270006)
				{
					base..ctor();
					if (83105 - 509177 != -426071)
					{
						this.$self_$39403 = self_;
						if (255639 - 468945 != -213305)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x060081F4 RID: 33268 RVA: 0x01081444 File Offset: 0x0107F644
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M505_SunkenCity1.$ReturnToGuild$39400.$(this.$self_$39403);
		}

		// Token: 0x060081F5 RID: 33269 RVA: 0x01081454 File Offset: 0x0107F654
		internal static bool LYnMunphDQu6kcUlXgFn()
		{
			return true;
		}

		// Token: 0x060081F6 RID: 33270 RVA: 0x01081458 File Offset: 0x0107F658
		internal static bool TkdBCBphvjs68FcDj7ey()
		{
			return false;
		}

		// Token: 0x04008056 RID: 32854
		internal M505_SunkenCity1 $self_$39403;

		// Token: 0x020015E2 RID: 5602
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x060081F7 RID: 33271 RVA: 0x0108145C File Offset: 0x0107F65C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M505_SunkenCity1 self_)
			{
				if (184437 - 44852 != 139585)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (227109 - 174468 == 52641)
					{
						base..ctor();
						if (205985 - 21786 != 184200)
						{
							this.$self_$39402 = self_;
							if (142381 - 543267 == -400886)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x060081F8 RID: 33272 RVA: 0x010814F4 File Offset: 0x0107F6F4
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (31827 - 364133 != -332306)
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
						this.$self_$39402.LeaveGame();
						if (103780 - 48751 != 55029)
						{
							continue;
						}
						this.YieldDefault(1);
						if (198531 - 323006 != -124475)
						{
							continue;
						}
						goto IL_1BD;
					default:
						if (206346 - 556477 != -350131)
						{
							continue;
						}
						break;
					}
					Game.mGameState = eGameState.Ended;
					if (130211 - 277432 == -147221)
					{
						Game.mStateTime = Time.time;
						if (127103 - 551269 == -424166)
						{
							Game.mNextGameCode = 31;
							if (196037 - 287568 != -91530)
							{
								this.$mGameGui$39401 = (GameGui)this.$self_$39402.GetComponent(typeof(GameGui));
								if (125339 - 324868 != -199528)
								{
									if (this.$mGameGui$39401)
									{
										if (122296 - 393066 == -270769)
										{
											continue;
										}
										this.$mGameGui$39401.close();
										if (237690 - 155543 != 82147)
										{
											continue;
										}
									}
									this.$self_$39402.SendMessage("fadeOut");
									if (111485 - 127948 != -16462)
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

			// Token: 0x060081F9 RID: 33273 RVA: 0x010816D0 File Offset: 0x0107F8D0
			internal static bool PtgeGtphRWikID7I8WmJ()
			{
				return true;
			}

			// Token: 0x060081FA RID: 33274 RVA: 0x010816D4 File Offset: 0x0107F8D4
			internal static bool MetP56phwHJodUmUg4jC()
			{
				return false;
			}

			// Token: 0x04008057 RID: 32855
			internal GameGui $mGameGui$39401;

			// Token: 0x04008058 RID: 32856
			internal M505_SunkenCity1 $self_$39402;
		}
	}

	// Token: 0x020015E3 RID: 5603
	[CompilerGenerated]
	[Serializable]
	internal sealed class $ReturnToCamp$39404 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x060081FB RID: 33275 RVA: 0x010816D8 File Offset: 0x0107F8D8
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $ReturnToCamp$39404(M505_SunkenCity1 self_)
		{
			if (156205 - 3896 != 152310)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (44875 - 596527 == -551652)
				{
					base..ctor();
					if (66285 - 160882 == -94597)
					{
						this.$self_$39408 = self_;
						if (292491 - 155467 == 137024)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x060081FC RID: 33276 RVA: 0x01081770 File Offset: 0x0107F970
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M505_SunkenCity1.$ReturnToCamp$39404.$(this.$self_$39408);
		}

		// Token: 0x060081FD RID: 33277 RVA: 0x01081780 File Offset: 0x0107F980
		internal static bool PkkZ6HphqpS1hYUhi4dY()
		{
			return true;
		}

		// Token: 0x060081FE RID: 33278 RVA: 0x01081784 File Offset: 0x0107F984
		internal static bool SoFFfEph7IhY1mYjgynD()
		{
			return false;
		}

		// Token: 0x04008059 RID: 32857
		internal M505_SunkenCity1 $self_$39408;

		// Token: 0x020015E4 RID: 5604
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x060081FF RID: 33279 RVA: 0x01081788 File Offset: 0x0107F988
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M505_SunkenCity1 self_)
			{
				if (278911 - 577992 != -299081)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (178230 - 299365 != -121134)
					{
						base..ctor();
						if (170050 - 416861 != -246810)
						{
							this.$self_$39407 = self_;
							if (47481 - 210077 != -162595)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x06008200 RID: 33280 RVA: 0x01081820 File Offset: 0x0107FA20
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (175064 - 409380 != -234315)
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
						this.$self_$39407.LeaveGame();
						if (252071 - 588081 != -336010)
						{
							continue;
						}
						this.YieldDefault(1);
						if (132353 - 248047 != -115694)
						{
							continue;
						}
						goto IL_363;
					default:
						if (87247 - 460319 != -373072)
						{
							continue;
						}
						break;
					}
					Game.mGameState = eGameState.Ended;
					if (146284 - 403236 != -256951)
					{
						Game.mStateTime = Time.time;
						if (230594 - 61586 != 169009)
						{
							this.$$switch$6927$39405 = PlayerData.SaveGuild;
							if (240685 - 134032 == 106653)
							{
								if (this.$$switch$6927$39405 == 1)
								{
									if (227138 - 71518 == 155621)
									{
										continue;
									}
									Game.mNextGameCode = 32;
									if (80385 - 69256 == 11130)
									{
										continue;
									}
								}
								else if (this.$$switch$6927$39405 == 2)
								{
									if (266057 - 237755 == 28303)
									{
										continue;
									}
									Game.mNextGameCode = 33;
									if (139989 - 518844 == -378854)
									{
										continue;
									}
								}
								else if (this.$$switch$6927$39405 == 3)
								{
									if (152913 - 216075 == -63161)
									{
										continue;
									}
									Game.mNextGameCode = 34;
									if (239032 - 404713 == -165680)
									{
										continue;
									}
								}
								else if (this.$$switch$6927$39405 == 4)
								{
									if (212317 - 423187 == -210869)
									{
										continue;
									}
									Game.mNextGameCode = 35;
									if (171385 - 182646 == -11260)
									{
										continue;
									}
								}
								else if (this.$$switch$6927$39405 == 5)
								{
									if (195055 - 474045 != -278990)
									{
										continue;
									}
									Game.mNextGameCode = 36;
									if (246623 - 525486 != -278863)
									{
										continue;
									}
								}
								else
								{
									Game.mNextGameCode = 30;
									if (73867 - 267819 == -193951)
									{
										continue;
									}
								}
								this.$mGameGui$39406 = (GameGui)this.$self_$39407.GetComponent(typeof(GameGui));
								if (85150 - 118496 != -33345)
								{
									if (this.$mGameGui$39406)
									{
										if (162909 - 319165 == -156255)
										{
											continue;
										}
										this.$mGameGui$39406.close();
										if (154156 - 98101 != 56055)
										{
											continue;
										}
									}
									this.$self_$39407.SendMessage("fadeOut");
									if (217907 - 210981 == 6926)
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

			// Token: 0x06008201 RID: 33281 RVA: 0x01081BA4 File Offset: 0x0107FDA4
			internal static bool aZ31mcphPApBmEChA8MT()
			{
				return true;
			}

			// Token: 0x06008202 RID: 33282 RVA: 0x01081BA8 File Offset: 0x0107FDA8
			internal static bool jlcU32ph0gVZ6mHoIHtV()
			{
				return false;
			}

			// Token: 0x0400805A RID: 32858
			internal int $$switch$6927$39405;

			// Token: 0x0400805B RID: 32859
			internal GameGui $mGameGui$39406;

			// Token: 0x0400805C RID: 32860
			internal M505_SunkenCity1 $self_$39407;
		}
	}
}
